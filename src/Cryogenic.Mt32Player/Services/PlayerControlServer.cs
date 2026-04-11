namespace Cryogenic.Mt32Player.Services;

using System.Net;
using System.Text;
using System.Text.Json;

public sealed class PlayerControlServer : IDisposable {
	private readonly Func<object> _getState;
	private readonly Action _play;
	private readonly Action _stop;
	private readonly Action<string> _load;
	private readonly Action<float> _setOutputGain;
	private readonly Action<byte> _setMasterVolume;
	private readonly Action<byte> _setTargetVolume;
	private readonly Func<object> _getAudioDebug;
	private readonly Action _resetAudioDebug;
	private readonly Action<byte, byte, byte, int> _triggerTestNote;
	private readonly Action<byte, byte, byte> _sendMidi3;
	private readonly Action<byte, byte> _sendMidi2;
	private readonly Action<byte> _sendMidi1;
	private readonly Action _audioPanic;
	private readonly Func<int, int, int, object> _getRawStreamDebug;
	private readonly Func<int, object> _startGoldenCapture;
	private readonly Func<object> _stopGoldenCapture;
	private readonly Func<object> _resetGoldenCapture;
	private readonly Func<object> _getGoldenCaptureSummary;
	private readonly Func<int, int, string, string, object> _dumpGoldenCapture;
	private readonly Func<int, object> _diagnoseGoldenCapture;
	private readonly Action<string> _log;
	private readonly HttpListener _listener;
	private CancellationTokenSource? _cts;
	private Task? _loopTask;

	public PlayerControlServer(
		Func<object> getState,
		Action play,
		Action stop,
		Action<string> load,
		Action<float> setOutputGain,
		Action<byte> setMasterVolume,
		Action<byte> setTargetVolume,
		Func<object> getAudioDebug,
		Action resetAudioDebug,
		Action<byte, byte, byte, int> triggerTestNote,
		Action<byte, byte, byte> sendMidi3,
		Action<byte, byte> sendMidi2,
		Action<byte> sendMidi1,
		Action audioPanic,
		Func<int, int, int, object> getRawStreamDebug,
		Func<int, object> startGoldenCapture,
		Func<object> stopGoldenCapture,
		Func<object> resetGoldenCapture,
		Func<object> getGoldenCaptureSummary,
		Func<int, int, string, string, object> dumpGoldenCapture,
		Func<int, object> diagnoseGoldenCapture,
		Action<string> log,
		string prefix) {
		_getState = getState;
		_play = play;
		_stop = stop;
		_load = load;
		_setOutputGain = setOutputGain;
		_setMasterVolume = setMasterVolume;
		_setTargetVolume = setTargetVolume;
		_getAudioDebug = getAudioDebug;
		_resetAudioDebug = resetAudioDebug;
		_triggerTestNote = triggerTestNote;
		_sendMidi3 = sendMidi3;
		_sendMidi2 = sendMidi2;
		_sendMidi1 = sendMidi1;
		_audioPanic = audioPanic;
		_getRawStreamDebug = getRawStreamDebug;
		_startGoldenCapture = startGoldenCapture;
		_stopGoldenCapture = stopGoldenCapture;
		_resetGoldenCapture = resetGoldenCapture;
		_getGoldenCaptureSummary = getGoldenCaptureSummary;
		_dumpGoldenCapture = dumpGoldenCapture;
		_diagnoseGoldenCapture = diagnoseGoldenCapture;
		_log = log;
		_listener = new HttpListener();
		_listener.Prefixes.Add(prefix);
	}

	public string Prefix => _listener.Prefixes.First();

	public void Start() {
		if (_listener.IsListening) {
			return;
		}

		_cts = new CancellationTokenSource();
		_listener.Start();
		_loopTask = Task.Run(() => LoopAsync(_cts.Token));
		_log($"MCP control server started at {Prefix}");
	}

	public void Stop() {
		if (!_listener.IsListening) {
			return;
		}

		_cts?.Cancel();
		_listener.Stop();
		_log("MCP control server stopped.");
	}

	public void Dispose() {
		Stop();
		_listener.Close();
	}

	private async Task LoopAsync(CancellationToken cancellationToken) {
		while (!cancellationToken.IsCancellationRequested) {
			HttpListenerContext? context = null;
			try {
				context = await _listener.GetContextAsync();
				await HandleAsync(context);
			} catch when (cancellationToken.IsCancellationRequested) {
				return;
			} catch (Exception ex) {
				_log($"Control server error: {ex.Message}");
				if (context is not null) {
					try {
						context.Response.StatusCode = 500;
						await WriteJsonAsync(context.Response, new { error = ex.Message });
					} catch {
						// Ignore response failures.
					}
				}
			}
		}
	}

	private async Task HandleAsync(HttpListenerContext context) {
		string path = context.Request.Url?.AbsolutePath ?? "/";
		if (path.Equals("/health", StringComparison.OrdinalIgnoreCase)) {
			await WriteJsonAsync(context.Response, new { ok = true, service = "cryogenic-mt32-player" });
			return;
		}

		if (path.Equals("/state", StringComparison.OrdinalIgnoreCase)) {
			await WriteJsonAsync(context.Response, _getState());
			return;
		}

		if (path.Equals("/mcp/tools", StringComparison.OrdinalIgnoreCase)) {
			await WriteJsonAsync(context.Response, new {
				tools = new[] {
					"state_get",
					"play",
					"stop",
					"load",
					"set_output_gain",
					"set_master_volume",
					"set_target_volume",
					"audio_debug_get",
					"audio_debug_reset",
					"audio_test_note",
					"audio_send_midi3",
					"audio_send_midi2",
					"audio_send_midi1",
					"audio_panic",
					"audio_stream_dump",
					"golden_capture_start",
					"golden_capture_stop",
					"golden_capture_reset",
					"golden_capture_summary",
					"golden_capture_dump",
					"golden_capture_diagnose"
				}
			});
			return;
		}

		if (path.Equals("/mcp/call", StringComparison.OrdinalIgnoreCase)) {
			using StreamReader reader = new(context.Request.InputStream, context.Request.ContentEncoding);
			string body = await reader.ReadToEndAsync();
			if (string.IsNullOrWhiteSpace(body)) {
				context.Response.StatusCode = 400;
				await WriteJsonAsync(context.Response, new { ok = false, error = "Request body is empty." });
				return;
			}

			JsonDocument payload;
			try {
				payload = JsonDocument.Parse(body);
			} catch (JsonException ex) {
				context.Response.StatusCode = 400;
				await WriteJsonAsync(context.Response, new { ok = false, error = $"Invalid JSON payload: {ex.Message}" });
				return;
			}

			using (payload) {
				string tool = string.Empty;
				if (payload.RootElement.TryGetProperty("tool", out JsonElement toolElement)) {
					tool = toolElement.GetString() ?? string.Empty;
				} else if (payload.RootElement.TryGetProperty("name", out JsonElement nameElement)) {
					tool = nameElement.GetString() ?? string.Empty;
				}

				if (string.IsNullOrWhiteSpace(tool)) {
					context.Response.StatusCode = 400;
					await WriteJsonAsync(context.Response, new { ok = false, error = "Missing tool name. Use 'tool' or 'name'." });
					return;
				}

				JsonElement args = payload.RootElement.TryGetProperty("args", out JsonElement argsValue)
					? argsValue
					: payload.RootElement.TryGetProperty("arguments", out JsonElement argumentsValue)
						? argumentsValue
						: default;

				object result = InvokeTool(tool, args);
				await WriteJsonAsync(context.Response, new { ok = true, tool, result });
			}
			return;
		}

		context.Response.StatusCode = 404;
		await WriteJsonAsync(context.Response, new { error = "Not found" });
	}

	private object InvokeTool(string tool, JsonElement args) {
		switch (tool) {
			case "state_get":
				return _getState();
			case "play":
				_play();
				return new { started = true };
			case "stop":
				_stop();
				return new { stopped = true };
			case "load":
				string path = args.GetProperty("path").GetString() ?? string.Empty;
				_load(path);
				return new { loaded = path };
			case "set_output_gain":
				float gain = args.GetProperty("gain").GetSingle();
				_setOutputGain(gain);
				return new { gain };
			case "set_master_volume":
				byte master = (byte)args.GetProperty("volume").GetInt32();
				_setMasterVolume(master);
				return new { volume = master };
			case "set_target_volume":
				byte target = (byte)args.GetProperty("volume").GetInt32();
				_setTargetVolume(target);
				return new { volume = target };
			case "audio_debug_get":
				return _getAudioDebug();
			case "audio_debug_reset":
				_resetAudioDebug();
				return new { reset = true };
			case "audio_test_note":
				byte channel = (byte)GetIntArg(args, "channel", 0);
				byte note = (byte)GetIntArg(args, "note", 60);
				byte velocity = (byte)GetIntArg(args, "velocity", 100);
				int durationMs = GetIntArg(args, "durationMs", 450);
				_triggerTestNote(channel, note, velocity, durationMs);
				return new { channel, note, velocity, durationMs };
			case "audio_send_midi3":
				byte status3 = (byte)GetIntArg(args, "status", 0x90);
				byte data13 = (byte)GetIntArg(args, "data1", 60);
				byte data23 = (byte)GetIntArg(args, "data2", 100);
				_sendMidi3(status3, data13, data23);
				return new { status = status3, data1 = data13, data2 = data23 };
			case "audio_send_midi2":
				byte status2 = (byte)GetIntArg(args, "status", 0xC0);
				byte data12 = (byte)GetIntArg(args, "data1", 0);
				_sendMidi2(status2, data12);
				return new { status = status2, data1 = data12 };
			case "audio_send_midi1":
				byte status1 = (byte)GetIntArg(args, "status", 0xFF);
				_sendMidi1(status1);
				return new { status = status1 };
			case "audio_panic":
				_audioPanic();
				return new { panic = true };
			case "audio_stream_dump":
				int channelDump = GetIntArg(args, "channel", 0);
				int before = GetIntArg(args, "before", 16);
				int count = GetIntArg(args, "count", 96);
				return _getRawStreamDebug(channelDump, before, count);
			case "golden_capture_start":
				int maxEvents = GetIntArg(args, "maxEvents", 20000);
				return _startGoldenCapture(maxEvents);
			case "golden_capture_stop":
				bool includeEvents = GetBoolArg(args, "includeEvents", false);
				_stopGoldenCapture();
				return true;
			case "golden_capture_reset":
				return _resetGoldenCapture();
			case "golden_capture_summary":
				return _getGoldenCaptureSummary();
			case "golden_capture_dump":
				int offset = GetIntArg(args, "offset", 0);
				int limit = GetIntArg(args, "limit", 0);
				string sourceFilter = GetStringArg(args, "source", string.Empty);
				string kindFilter = GetStringArg(args, "kind", string.Empty);
				return _dumpGoldenCapture(offset, limit, sourceFilter, kindFilter);
			case "golden_capture_diagnose":
				int sampleSize = GetIntArg(args, "sampleSize", 32);
				return _diagnoseGoldenCapture(sampleSize);
			default:
				throw new InvalidOperationException($"Unknown tool '{tool}'.");
		}
	}

	private static int GetIntArg(JsonElement args, string propertyName, int defaultValue) {
		if (args.ValueKind != JsonValueKind.Object) {
			return defaultValue;
		}

		if (!args.TryGetProperty(propertyName, out JsonElement value)) {
			return defaultValue;
		}

		if (value.ValueKind != JsonValueKind.Number) {
			return defaultValue;
		}

		if (!value.TryGetInt32(out int result)) {
			return defaultValue;
		}

		return result;
	}

	private static bool GetBoolArg(JsonElement args, string propertyName, bool defaultValue) {
		if (args.ValueKind != JsonValueKind.Object) {
			return defaultValue;
		}

		if (!args.TryGetProperty(propertyName, out JsonElement value)) {
			return defaultValue;
		}

		if (value.ValueKind == JsonValueKind.True) {
			return true;
		}

		if (value.ValueKind == JsonValueKind.False) {
			return false;
		}

		if (value.ValueKind == JsonValueKind.Number && value.TryGetInt32(out int numberValue)) {
			return numberValue != 0;
		}

		return defaultValue;
	}

	private static string GetStringArg(JsonElement args, string propertyName, string defaultValue) {
		if (args.ValueKind != JsonValueKind.Object) {
			return defaultValue;
		}

		if (!args.TryGetProperty(propertyName, out JsonElement value)) {
			return defaultValue;
		}

		if (value.ValueKind != JsonValueKind.String) {
			return defaultValue;
		}

		return value.GetString() ?? defaultValue;
	}

	private static async Task WriteJsonAsync(HttpListenerResponse response, object payload) {
		byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(payload, new JsonSerializerOptions {
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		});
		response.ContentType = "application/json";
		response.ContentEncoding = Encoding.UTF8;
		response.ContentLength64 = bytes.Length;
		await response.OutputStream.WriteAsync(bytes, 0, bytes.Length);
		response.OutputStream.Close();
	}
}