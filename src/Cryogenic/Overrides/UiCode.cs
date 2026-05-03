namespace Cryogenic.Overrides;

using System;

/// <summary>
/// Partial class containing C# overrides for UI-rendering routines in DNCDPRG.EXE.
/// </summary>
/// <remarks>
/// Covers character portrait rendering (draw-head-and-shoulders, animate-up/down),
/// the palace-plan overlay, troop-count icons, and the moon/sun indicator widget.
/// Source references are from <c>doc/DNCDPRG.lst</c>.
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers all UI-rendering function overrides (stubs only — no <c>DefineFunction</c> calls).
	/// </summary>
	/// <remarks>
	/// All methods in this file are unregistered stubs pending full implementation.
	/// </remarks>
	public void DefineUiCodeOverrides() {
		// Stubs: not yet registered — x86 executes when not registered.
	}

	/// <summary>
	/// Stub for CS1:1797 — <c>ui_draw_head_and_shoulders</c> (seg000:1797).
	/// Draws the character portrait (head and shoulders sprite) into the active frame buffer.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Pushes DS:[2784h], calls <c>load_icones_sprites</c>, then draws two sprites via
	/// <c>draw_sprite_clobbering_bx_dx</c>, and tail-jumps to <c>open_resource_by_index</c>.
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>load_icones_sprites</c> — unregistered callee</description></item>
	/// <item><description><c>draw_sprite_clobbering_bx_dx</c> — unregistered callee</description></item>
	/// <item><description><c>open_resource_by_index</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1797–17BD in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action UiDrawHeadAndShoulders_1000_1797_11797(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:17BE — <c>loc_017be</c> (seg000:17BE).
	/// Redraws the head-and-shoulders portrait: copies FB2→FB1 or uses an indirect blit,
	/// then calls <c>ui_draw_head_and_shoulders</c> and updates the screen rect.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>copy_rect_fb2_to_fb1</c> — unregistered callee</description></item>
	/// <item><description><c>draw_head_if_needed_and_update_screen_rect_at_si</c> — unregistered callee</description></item>
	/// <item><description><c>word ptr [391dh]</c> — indirect vtable call, unresolved at override registration</description></item>
	/// </list>
	/// Source: seg000:17BE–17E5 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc017be_1000_17BE_117BE(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:17E6 — <c>ui_head_animate_up</c> (seg000:17E6).
	/// Loops incrementing DS:[0E8h] (head-position index) and redrawing the portrait until
	/// the maximum position (0x0A) is reached or DS:[11C9h] is non-zero.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_017be</c> (CS1:17BE) — unregistered callee</description></item>
	/// <item><description><c>wait_a_bit</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:17E6–1802 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action UiHeadAnimateUp_1000_17E6_117E6(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1803 — <c>ui_head_animate_down</c> wrapper (seg000:1803).
	/// Guards the inner animate-down loop by checking DS:[28E7h]; if non-zero, returns immediately.
	/// Sets DS:[0CE66h]=1 before calling the inner loop at CS1:181E, then clears it.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>ui_head_animate_down</c> (CS1:181E) — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1803–181C in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action UiHeadAnimateDownWrapper_1000_1803_11803(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:181E — <c>ui_head_animate_down</c> inner loop (seg000:181E).
	/// Loops decrementing DS:[0E8h] and redrawing the portrait via <c>loc_017be</c>
	/// until DS:[0E8h] reaches zero.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_017be</c> (CS1:17BE) — unregistered callee</description></item>
	/// <item><description><c>wait_a_bit</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:181E–1832 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action UiHeadAnimateDown_1000_181E_1181E(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1834 — <c>loc_01834</c> (seg000:1834).
	/// Calls an indirect function pointer at DS:[3919h] with SI=0xCD9E, BP=0x1E76,
	/// ES=DS:[0DBD6h]. Used to restore or redraw the head area from a source buffer.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>word ptr [3919h]</c> — indirect vtable call; target not deterministic at registration</description></item>
	/// </list>
	/// Source: seg000:1834–1842 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01834_1000_1834_11834(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1843 — <c>loc_01843</c> (seg000:1843).
	/// Snaps the head position to 9, calls <c>loc_017be</c>, waits, sets position to 8,
	/// then tail-jumps to <c>loc_017be</c> again. Used to instantly jump-animate the portrait.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_017be</c> (CS1:17BE) — unregistered callee</description></item>
	/// <item><description><c>wait_a_bit</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1843–1862 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01843_1000_1843_11843(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1860 — <c>loc_01860</c> (seg000:1860).
	/// Guarded call to <c>loc_01843</c>: returns immediately if DS:[11C9h] is non-zero;
	/// otherwise calls <c>loc_01843</c> then falls through to <c>loc_0186b</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_01843</c> (CS1:1843) — unregistered callee</description></item>
	/// <item><description><c>clear_some_mouse_rect</c> — unregistered callee (falls through to loc_0186b)</description></item>
	/// </list>
	/// Source: seg000:1860–186A in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01860_1000_1860_11860(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:189A — <c>loc_0189a</c> (seg000:189A).
	/// Initiates the in-game character view: loads BP with the scene address 0x2DB1,
	/// checks DS:[46D9h], applies a transition effect if zero, loads frame buffer 1,
	/// copies a camera-related value, and tail-jumps to <c>ui_head_animate_up</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_0ae04</c> — unregistered callee</description></item>
	/// <item><description><c>ui_head_animate_up</c> (CS1:17E6) — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:189A–18B9 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc0189a_1000_189A_1189A(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:18BA — <c>loc_018ba</c> (seg000:18BA).
	/// Room teardown: clears three word fields at DS:[1C06h/1C14h/1C22h], stops the
	/// room frame-task, stops PCM audio, and calls several cleanup routines.
	/// If DS:[2Bh] is non-zero, also calls <c>loc_00b21</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>remove_room_frame_task</c> — unregistered callee</description></item>
	/// <item><description><c>call_pcm_audio_vtable_func_5</c> — unregistered callee</description></item>
	/// <item><description><c>loc_04d00</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0d2bd</c> — unregistered callee</description></item>
	/// <item><description><c>loc_04aca</c> — unregistered callee</description></item>
	/// <item><description><c>loc_098e6</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:18BA–18ED in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc018ba_1000_18BA_118BA(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:18EE — <c>ui_draw_palace_plan</c> (seg000:18EE).
	/// Displays the Arrakeen palace floor-plan overlay when the current scene is 0x2012.
	/// Loads resource #33 (0x21), renders icon lists, draws troop-count markers via
	/// <c>loc_01948</c>, and transitions to the palace-plan input loop.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_0d2e2</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0d2bd</c> — unregistered callee</description></item>
	/// <item><description><c>draw_icons_list_at_si</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0c0d5</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0d323</c> — unregistered callee</description></item>
	/// <item><description><c>open_resource_by_index</c> — unregistered callee</description></item>
	/// <item><description><c>word ptr [38ddh]</c> — indirect vtable call</description></item>
	/// <item><description><c>loc_05b6e</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:18EE–1946 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action UiDrawPalacePlan_1000_18EE_118EE(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1948 — <c>loc_01948</c> (seg000:1948).
	/// Allocates a 0x24-byte zero-filled stack frame, then for each of the 16 character
	/// slots at DS:[0FD8h] counts troop assignments into the frame and renders sprite
	/// columns via <c>loc_019df</c> and <c>draw_sprite_clobbering_bx_dx</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>draw_sprite_clobbering_bx_dx</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1948–19DE in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01948_1000_1948_11948(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:19DF — <c>loc_019df</c> (seg000:19DF).
	/// Draws a column of up to 5 sprite #2 tiles at (DX, BX) spaced 4 pixels apart,
	/// using CL as the count (clamped to 5). Ignores zero-count column.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Callee <c>draw_sprite</c> (CS1:C22F) is registered; this stub can be fully implemented
	/// once the palace-plan caller chain is verified in-game.
	/// Source: seg000:19DF–19FB in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc019df_1000_19DF_119DF(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:19FC — <c>loc_019fc</c> (seg000:19FC).
	/// Clears the mouse cursor rect, copies a region from FB2 to FB1, calls
	/// <c>loc_0c0d5</c> with AL=0x12, then tail-jumps to <c>loc_0d95b</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>clear_some_mouse_rect</c> — unregistered callee</description></item>
	/// <item><description><c>copy_rect_fb2_to_fb1</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0c0d5</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0d95b</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:19FC–1A0E in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc019fc_1000_19FC_119FC(int gotoAddress) {
		return NearRet();
	}
}