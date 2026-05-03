namespace Cryogenic.Overrides;

using System;

/// <summary>
/// Partial class containing frame-task management override stubs.
/// </summary>
/// <remarks>
/// <para>
/// Covers CS1 functions responsible for scheduling, running, and stopping per-frame callbacks
/// (frame tasks) — specifically the night-attack stop handler and its frame-task body:
/// </para>
/// <list type="bullet">
/// <item><description>CS1:0B21 — <c>loc_00b21</c>: stops PCM audio and removes the night-attack frame task</description></item>
/// <item><description>CS1:0B45 — <c>loc_00b45</c>: night-attack frame-task body (particle spawning and sprite updates)</description></item>
/// </list>
/// <para>
/// All methods in this file are documented stubs: they are <b>not</b> registered via
/// <c>DefineFunction</c>. Spice86 continues executing the original x86 code for these
/// addresses. A stub becomes a full override once all of its callees are registered.
/// </para>
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers frame-task function overrides with Spice86.
	/// No registrations yet — all functions in this file remain stubs pending callee registration.
	/// </summary>
	public void DefineFrameTaskCodeOverrides() {
		// All frame-task functions below are stubs pending registration of their callees.
	}

	/// <summary>
	/// Stub for CS1:0B21 — <c>loc_00b21</c> (seg000:0B21).
	/// Stops PCM audio and removes the night-attack frame task, optionally resetting the 3CBEh counter.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>call_pcm_audio_vtable_func_5</c> (address TBD from CFG) — unregistered</description></item>
	/// <item><description><c>remove_frame_task</c> (CS1:DA5F) — unregistered</description></item>
	/// </list>
	/// Body: calls <c>call_pcm_audio_vtable_func_5</c> to stop PCM playback,
	/// patches CS byte <c>[C13Ch]=0x25</c>, sets SI=0x0B45 and calls <c>remove_frame_task</c>.
	/// Then checks <c>[227Dh]</c>: if non-zero skip; else checks <c>[0FBh]</c>: if negative skip;
	/// otherwise clears <c>word ptr [3CBEh]</c>.
	/// Source: seg000:0B21–0B44 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc00b21_1000_0B21_10B21(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0B45 — <c>loc_00b45</c> (seg000:0B45).
	/// Night-attack frame-task body: drives the particle system and sprite updates each frame.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_00d0d</c> (CS1:0D0D) — unregistered stub</description></item>
	/// <item><description><c>rand</c> (CS1:E3CC) — unregistered</description></item>
	/// <item><description><c>particles_spawn_particle</c> (CS1:C60B) — unregistered</description></item>
	/// <item><description><c>loc_00c3b</c> (CS1:0C3B) — unregistered stub</description></item>
	/// <item><description><c>loc_0c661</c> (CS1:C661) — unregistered</description></item>
	/// <item><description><c>particles_remove_particle</c> (CS1:C58A) — unregistered</description></item>
	/// </list>
	/// Body: loads SI=0x4856 (particle state block), decrements the frame counter at <c>[SI+7]</c>.
	/// If <c>[0EAh] &gt; 0</c> or <c>[SI+7] &gt; 0x10</c>: skips sprite dispatch.
	/// Otherwise calls <c>loc_00d0d</c> with BL from <c>[SI+7]</c> to update the night-attack sprite.
	/// If <c>[479Eh] | [46EBh] != 0</c>: returns early.
	/// Decrements the delay counter at <c>[SI+4]</c>; if still positive jumps to the active-particle loop.
	/// Decrements the phase counter at <c>[SI+6]</c>; if still positive calls <c>rand</c> to choose
	/// a random spawn position and conditionally calls <c>particles_spawn_particle</c>.
	/// Decrements the top-level counter at <c>[SI]</c>; if zero calls <c>loc_00c3b</c> to refill.
	/// Iterates all active particle slots updating their positions via <c>loc_0c661</c>
	/// and removes out-of-bounds particles via <c>particles_remove_particle</c>.
	/// Source: seg000:0B45–0C3A in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc00b45_1000_0B45_10B45(int gotoAddress) {
		return NearRet();
	}
}