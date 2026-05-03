namespace Cryogenic.Overrides;

using Spice86.Shared.Emulator.Memory;

using System;

/// <summary>
/// Partial class containing C# overrides for game-state query and calendar-display routines
/// in DNCDPRG.EXE.
/// </summary>
/// <remarks>
/// Covers the in-game day/time accessors, the date-and-time HUD indicator, the moon/sun
/// widget renderer, and the ambient-sound/phase-change polling loop.
/// Source references are from <c>doc/DNCDPRG.lst</c>.
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers game-state function overrides.
	/// </summary>
	/// <remarks>
	/// <c>GetIngameDayQ_1000_1AC5_11AC5</c> is fully implemented and registered.
	/// All other methods in this file are unregistered stubs.
	/// </remarks>
	public void DefineGameStateCodeOverrides() {
		DefineFunction(cs1, 0x1AC5, GetIngameDayQ_1000_1AC5_11AC5);
	}

	/// <summary>
	/// Stub for CS1:1A0F — <c>loc_01a0f</c> (seg000:1A0F).
	/// Refreshes the in-game UI when the elapsed-time area (DS:[1AFEh]) is inactive:
	/// restores cursor, reloads icon sprites, draws the UI element at SI=0x1AF4,
	/// draws the date/time indicator, copies a rect to screen, and reopens the resource.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>call_restore_cursor</c> — unregistered callee</description></item>
	/// <item><description><c>load_icones_sprites</c> — unregistered callee</description></item>
	/// <item><description><c>draw_ui_element</c> — unregistered callee</description></item>
	/// <item><description><c>open_resource_by_index</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1A0F–1A32 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01a0f_1000_1A0F_11A0F(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1A34 — <c>ui_draw_date_and_time_indicator</c> (seg000:1A34).
	/// Draws the moon/sun time-of-day widget and the current in-game day number into the
	/// text framebuffer. Returns immediately if DS:[1AFEh] is non-zero.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>draw_moon_and_sun</c> (CS1:1A9B) — unregistered callee</description></item>
	/// <item><description><c>font_select_small_font</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0e290</c> — unregistered callee</description></item>
	/// <item><description><c>word ptr [2518h]</c> — indirect font/blit call</description></item>
	/// </list>
	/// Source: seg000:1A34–1A99 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action UiDrawDateAndTimeIndicator_1000_1A34_11A34(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1A9B — <c>draw_moon_and_sun</c> (seg000:1A9B).
	/// Loads DX (resource sub-index) and BX (sprite index) from the table at DS:SI,
	/// looks up the sub-resource pointer, and blits the moon or sun sprite into the
	/// HUD framebuffer using an indirect call at SS:[38CDh].
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>get_subresource_ax_pointer_to_dssi</c> — unregistered callee</description></item>
	/// <item><description><c>word ptr ss:[38CDh]</c> — indirect sprite-blit vtable call</description></item>
	/// </list>
	/// Source: seg000:1A9B–1AC4 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action DrawMoonAndSun_1000_1A9B_11A9B(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Full implementation of CS1:1AC5 — <c>get_ingame_day_q</c> (seg000:1AC5).
	/// Returns the current in-game day counter in AX by reading the 16-bit elapsed-tick
	/// word at DS:[0002h] and right-shifting it by 4.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return.</returns>
	/// <remarks>
	/// Assembly: <c>mov ax, [2] / shr ax, 1 / shr ax, 1 / shr ax, 1 / shr ax, 1 / ret</c>.
	/// AX = DS:[0002h] &gt;&gt; 4.
	/// This is a pure memory-read with no side-effects; it is safe to register.
	/// Source: seg000:1AC5–1AD0 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action GetIngameDayQ_1000_1AC5_11AC5(int gotoAddress) {
		ushort elapsedTicks = Memory.UInt16[MemoryUtils.ToPhysicalAddress(DS, 0x0002)];
		AX = (ushort)(elapsedTicks >> 4);
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1AE7 — <c>loc_01ae7</c> (seg000:1AE7).
	/// Polls for a day-phase change: calls <c>loc_0d41b</c>, then if BP==0x1F7E checks
	/// whether DS:[0CE7Ah] (current VGA palette tick) differs from DS:[4770h]. If so,
	/// updates DS:[4770h] and possibly triggers a palette-scroll via <c>loc_0c85b</c>/<c>loc_0c868</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_0c868</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1AE7–1B0B in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01ae7_1000_1AE7_11AE7(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1B0D — <c>loc_01b0d</c> (seg000:1B0D).
	/// Ambient music trigger: checks whether PCM audio is playing and whether DS:[2788h]
	/// and DS:[2Ah] pass thresholds; if all clear, triggers the ambient music sequence
	/// via <c>loc_02b2a</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>is_voc_pcm_playing</c> — unregistered callee</description></item>
	/// <item><description><c>loc_02b2a</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1B0D–1B22 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01b0d_1000_1B0D_11B0D(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1B23 — <c>loc_01b23</c> (seg000:1B23).
	/// Per-day tick: checks DS:[46DDh] (day-change flag); if set, clears it, adjusts
	/// DS:[0F4h] (brightness level), calls <c>loc_01a0f</c>, triggers map scroll/phase
	/// change, updates DS:[1174h], and dispatches time-of-day callbacks.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_038e1</c> — unregistered callee</description></item>
	/// <item><description><c>loc_01c46</c> — unregistered callee</description></item>
	/// <item><description><c>loc_01d9f</c> (CS1:1D9F) — unregistered callee</description></item>
	/// <item><description><c>loc_06c6f</c> — unregistered callee</description></item>
	/// <item><description><c>map_func_qq</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1B23–1B5D in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01b23_1000_1B23_11B23(int gotoAddress) {
		return NearRet();
	}
}