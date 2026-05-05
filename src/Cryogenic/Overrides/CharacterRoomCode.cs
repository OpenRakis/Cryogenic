namespace Cryogenic.Overrides;

using System;

/// <summary>
/// Partial class containing character-room scene setup override stubs.
/// </summary>
/// <remarks>
/// <para>
/// Covers CS1 functions involved in entering and setting up the character-room interface
/// (the dialogue/consultation screens where the player interacts with characters) and a
/// shared time-advancement utility used broadly across the game:
/// </para>
/// <list type="bullet">
/// <item><description>CS1:0ED0 — <c>loc_00ed0</c>: character room display setup (scene type, sprites, dialogue)</description></item>
/// <item><description>CS1:0F08 — <c>loc_00f08</c>: framebuffer/lip-sync initialisation for character scenes</description></item>
/// <item><description>CS1:0FD9 — <c>loc_00fd9</c>: time-advancement loop (advances the in-game day by CX ticks)</description></item>
/// </list>
/// <para>
/// All methods in this file are documented stubs: they are <b>not</b> registered via
/// <c>DefineFunction</c>. Spice86 continues executing the original x86 code for these
/// addresses. A stub becomes a full override once all of its callees are registered.
/// </para>
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers character-room scene setup function overrides with Spice86.
	/// No registrations yet — all functions in this file remain stubs pending callee registration.
	/// </summary>
	public void DefineCharacterRoomCodeOverrides() {
		// All character-room functions below are stubs pending registration of their callees.
	}

	/// <summary>
	/// Stub for CS1:0ED0 — <c>loc_00ed0</c> (seg000:0ED0).
	/// Character-room display setup: selects the scene state via <c>loc_0c2f2</c>, draws the character
	/// portrait and head-and-shoulders sprite, configures the dialogue script entry, and queues a
	/// state-machine transition.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_0c2f2</c> (CS1:C2F2) — unregistered</description></item>
	/// <item><description><c>draw_sprite_clobbering_bx_dx</c> (CS1:C22F) — registered as <c>draw_sprite_ida</c> (used twice but tail-jump path not expressible)</description></item>
	/// <item><description><c>loc_00f08</c> (CS1:0F08) — unregistered stub (callee)</description></item>
	/// <item><description><c>ui_draw_head_and_shoulders</c> (CS1:1797) — unregistered</description></item>
	/// <item><description><c>loc_0d72b</c> (CS1:D72B) — unregistered</description></item>
	/// <item><description><c>loc_098f5</c> (CS1:98F5) — unregistered</description></item>
	/// <item><description><c>loc_0d338</c> (CS1:D338) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>open_resource_by_index</c> (CS1:C13E, registered).
	/// Body: AL=0x3B → calls <c>loc_0c2f2</c> (scene-type dispatch); AX=1 → draws sprite 1;
	/// calls <c>loc_00f08</c>; opens resource 0x3B; draws sprite 2 at (0,0,0); calls
	/// <c>ui_draw_head_and_shoulders</c>; sets SI=0x1D1E and calls <c>loc_0d72b</c> (dialogue init);
	/// calls <c>loc_098f5</c>; sets <c>[1C06h]=0x80</c>;
	/// sets BP=0x20C2, BX=0x0EB9 and tail-jumps to <c>loc_0d338</c>.
	/// Source: seg000:0ED0–0F07 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc00ed0_1000_0ED0_10ED0(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0F08 — <c>loc_00f08</c> (seg000:0F08).
	/// Framebuffer and lip-sync initialisation for character scenes: conditionally copies the
	/// active framebuffer, configures the mouth-region animation state, and sets up the lip-sync engine.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>copy_active_framebuffer_to_framebuffer_2</c> (CS1:C412) — unregistered</description></item>
	/// <item><description><c>setup_lip_sync_data_from_current</c> (CS1:9197) — unregistered</description></item>
	/// <item><description><c>loc_0978e</c> (CS1:978E) — unregistered</description></item>
	/// <item><description><c>loc_0998e</c> (CS1:998E) — unregistered</description></item>
	/// <item><description><c>loc_00965</c> (CS1:0965) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Body: tests bit 7 of <c>word ptr [10h]</c>; if clear tail-jumps to <c>loc_00960</c>
	/// (which copies framebuffer and calls <c>loc_009c7</c>).
	/// If set: calls <c>copy_active_framebuffer_to_framebuffer_2</c>, sets <c>[47C4h]=7</c>,
	/// calls <c>setup_lip_sync_data_from_current</c>, clears <c>[478Ch]</c>,
	/// adds 0x0F to <c>[1BF2h]</c>, calls <c>loc_0978e</c> and <c>loc_0998e</c>,
	/// sets <c>[22A6h]=0xFFFF</c>, increments <c>[47C3h]</c>, sets <c>[47C6h]=1</c>,
	/// calls <c>copy_active_framebuffer_to_framebuffer_2</c> again, DX=0x2D,
	/// tail-jumps to <c>loc_00965</c>.
	/// Source: seg000:0F08–0F47 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc00f08_1000_0F08_10F08(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0FD9 — <c>loc_00fd9</c> (seg000:0FD9).
	/// Time-advancement loop: advances the in-game day counter by CX game ticks, processing
	/// each tick via the day-transition handler.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_01b23</c> (CS1:1B23) — unregistered</description></item>
	/// </list>
	/// Also present: <c>loc_0b2be</c> (CS1:B2BE, registered as <c>SetUnknown2788To0_1000_B2BE_1B2BE</c>).
	/// Body: sets <c>[46DAh]=1</c> (time-advancing flag), calls <c>loc_0b2be</c> (clears unknown state),
	/// loops CX times: saves <c>[146Eh]</c> into <c>[46DBh]</c>; if <c>[46DDh] != 0</c>
	/// calls <c>loc_01b23</c> (day-tick handler); increments <c>word ptr [2]</c> (day counter);
	/// sets <c>[46DDh]=1</c>; calls <c>loc_01b23</c> again; loops.
	/// After loop clears <c>[46DAh]</c> and returns.
	/// Source: seg000:0FD9–100A in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc00fd9_1000_0FD9_10FD9(int gotoAddress) {
		return NearRet();
	}
}