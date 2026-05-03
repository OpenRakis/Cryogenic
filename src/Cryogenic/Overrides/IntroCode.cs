namespace Cryogenic.Overrides;

using System;

/// <summary>
/// Partial class containing intro-scene override stubs.
/// </summary>
/// <remarks>
/// <para>
/// Covers three batches of intro-sequence functions from the IDA disassembly:
/// </para>
/// <list type="bullet">
/// <item><description>Batch A (0x0083–0x0301): simple intro dispatchers</description></item>
/// <item><description>Batch B (0x06CE–0x076A): intro scene frame-task cluster</description></item>
/// <item><description>Batch C (0x0771–0x0868): intro scene per-scene callbacks</description></item>
/// </list>
/// <para>
/// All methods in this file are documented stubs: they are <b>not</b> registered via
/// <c>DefineFunction</c>. Spice86 continues executing the original x86 code for these
/// addresses. A stub becomes a full override once all of its callees are registered.
/// </para>
/// <para>
/// Method names contain underscores to separate segment, offset, and linear addresses
/// for traceability back to the original DOS disassembly.
/// </para>
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers intro-scene function overrides with Spice86.
	/// No registrations yet — all functions in this file remain stubs pending callee registration.
	/// </summary>
	public void DefineIntroCodeOverrides() {
		// All intro functions below are stubs pending registration of their callees.
	}

	// -------------------------------------------------------------------------
	// Batch A — simple intro dispatchers (seg000:0083–0301)
	// -------------------------------------------------------------------------

	/// <summary>
	/// Stub for CS1:0083 — <c>loc_00083</c> (seg000:0083).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>ui_draw_head_and_shoulders</c> (CS1:1797) — unregistered</description></item>
	/// </list>
	/// Also present: <c>check_amr_or_eng_language</c> (CS1:CFA0, registered),
	/// <c>set_fb1_as_active_framebuffer</c> (CS1:C07C, registered),
	/// <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered),
	/// <c>gfx_call_bp_with_front_buffer_as_screen</c> (CS1:C097, registered).
	/// Source: seg000:0083–00B0 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0083_010083(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:02C1 — <c>loc_002c1</c> (seg000:02C1).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_088af</c> (CS1:88AF) — unregistered</description></item>
	/// </list>
	/// Also present: <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered),
	/// <c>font_select_tall_font</c> (CS1:D068, registered),
	/// <c>loc_09901</c> (CS1:9901, registered).
	/// Tail-jumps to <c>loc_09901</c> (CS1:9901, registered) — cannot tail-call from C#.
	/// Source: seg000:02C1–02DC in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_02C1_0102C1(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:02DE — <c>intro_part_2</c> (seg000:02DE).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_00a44</c> (CS1:0A44) — unregistered (draw_stars tail-calls it)</description></item>
	/// </list>
	/// Sets CX=0 then falls through to <c>draw_stars</c> (CS1:02E0) which immediately
	/// tail-jumps to <c>loc_00a44</c> — cannot tail-call from C#.
	/// Source: seg000:02DE–02E0 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroPart2_1000_02DE_0102DE(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:02E3 — <c>loc_002e3</c> (seg000:02E3).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>setup_globe_draw</c> (CS1:B8A7) — unregistered</description></item>
	/// <item><description><c>draw_globe_with_atmosphere</c> (CS1:B85A) — unregistered</description></item>
	/// <item><description><c>loc_0b8ea</c> (CS1:B8EA) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>draw_stars</c> (CS1:02E0, falls-through to loc_00a44 — unregistered),
	/// <c>open_resource_by_index</c> (CS1:C13E, registered).
	/// Source: seg000:02E3–02F5 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_02E3_0102E3(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:02F8 — <c>intro_paul_on_red_background</c> dispatch entry (seg000:02F8).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// This is a self-modifying-code placeholder. At rest the instruction is
	/// <c>jmp 02F8h</c> (jump to self, infinite loop). The 3 bytes are patched at
	/// runtime by the script dispatch system to an unconditional jump to the real
	/// handler at <c>intro_paul_on_red_background</c> (CS1:07EE).
	/// Source: seg000:02F8–02FA in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroPaulOnRedBackgroundDispatch_1000_02F8_0102F8(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:02FB — <c>intro_26_baron</c> dispatch entry (seg000:02FB).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Self-modifying-code placeholder identical in structure to the dispatch at CS1:02F8.
	/// At rest the instruction is <c>jmp 02FBh</c> (jump to self). Patched at runtime
	/// to jump to the actual baron scene handler.
	/// Source: seg000:02FB–02FD in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Intro26BaronDispatch_1000_02FB_0102FB(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:02FE — <c>loc_002fe</c> (seg000:02FE).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because of the following unregistered jump chain:
	/// <list type="bullet">
	/// <item><description><c>loc_0076a</c> (CS1:076A) → <c>loc_0c2f2</c> (CS1:C2F2) — unregistered</description></item>
	/// </list>
	/// Body: <c>jmp loc_0076a</c> only.
	/// Source: seg000:02FE–0300 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc002fe_1000_02FE_0102FE(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0301 — <c>loc_00301</c> (seg000:0301).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following jump target is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_0c2f2</c> (CS1:C2F2) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0301_10301</c>.
	/// Source: seg000:0301–0308 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc00301_1000_0301_010301(int gotoAddress) {
		return NearRet();
	}

	// -------------------------------------------------------------------------
	// Batch B — intro scene frame-task cluster (seg000:06CE–076A)
	// -------------------------------------------------------------------------

	/// <summary>
	/// Stub for CS1:06CE — <c>intro_load_desert_flyover_video</c> (seg000:06CE).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented due to tail-call limitation:
	/// <list type="bullet">
	/// <item><description>
	/// Sets AX=0x10 then jumps to <c>loc_006f3</c> which tail-calls
	/// <c>hnm_load_first_frame</c> (CS1:CA1B, static-def only). There is no
	/// supported mechanism to tail-call a static-def from a C# override.
	/// </description></item>
	/// </list>
	/// Source: seg000:06CE–06D1 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroLoadDesertFlyoverVideo_1000_06CE_0106CE(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:06D3 — <c>intro_desert_flight_to_sietch</c> (seg000:06D3).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented due to tail-call limitation:
	/// <list type="bullet">
	/// <item><description>
	/// Sets AX=0x11 then jumps to <c>loc_006f3</c> which tail-calls
	/// <c>hnm_load_first_frame</c> (CS1:CA1B, static-def only).
	/// </description></item>
	/// </list>
	/// Source: seg000:06D3–06D6 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroDesertFlightToSietch_1000_06D3_0106D3(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:06D8 — <c>loc_006d8</c> (seg000:06D8).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_038a2</c> (CS1:38A2) — unregistered</description></item>
	/// </list>
	/// Also: tail-calls <c>hnm_load_first_frame</c> (CS1:CA1B, static-def only) via
	/// <c>loc_006f3</c>.
	/// Also present: <c>pcm_stop_voc_q</c> (CS1:AC14, registered).
	/// Source: seg000:06D8–06E8 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_06D8_0106D8(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:06EA — <c>loc_006ea</c> (seg000:06EA).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented due to tail-call limitation:
	/// <list type="bullet">
	/// <item><description>
	/// Sets word DS:[4]=2 and AX=0x13, falls through to <c>loc_006f3</c> which
	/// tail-calls <c>hnm_load_first_frame</c> (CS1:CA1B, static-def only).
	/// </description></item>
	/// </list>
	/// Source: seg000:06EA–06F2 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_06EA_0106EA(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:06FC — <c>loc_006fc</c> (seg000:06FC).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_03901</c> (CS1:3901) — unregistered</description></item>
	/// </list>
	/// Falls through to <c>intro_play_hnm_with_frame_task</c> (CS1:0704).
	/// Source: seg000:06FC–0703 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_06FC_0106FC(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0704 — <c>intro_play_hnm_with_frame_task</c> (seg000:0704).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>add_frame_task</c> (CS1:DA25) — unregistered</description></item>
	/// </list>
	/// Also present: <c>hnm_do_frame</c> (CS1:CA60, registered static-def).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0704_10704</c>.
	/// Source: seg000:0704–0710 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroPlayHnmWithFrameTask_1000_0704_010704(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0711 — <c>loc_00711</c> (seg000:0711).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented due to tail-call limitation:
	/// <list type="bullet">
	/// <item><description>
	/// Adjusts DS:[0DBDA] then tail-calls <c>hnm_load_first_frame</c>
	/// (CS1:CA1B, static-def only).
	/// </description></item>
	/// </list>
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0711_10711</c>.
	/// Source: seg000:0711–071C in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0711_010711(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:071D — <c>loc_0071d</c> (seg000:071D).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_04b16</c> (CS1:4B16) — unregistered</description></item>
	/// <item><description><c>loc_04937</c> (CS1:4937) — unregistered</description></item>
	/// </list>
	/// Also present: <c>audio_start_voc</c> (CS1:AB15, registered),
	/// <c>hnm_do_frame_and_check_if_frame_advanced</c> (CS1:C9F4, registered),
	/// <c>stc_on_user_input</c> (CS1:DD63, registered).
	/// Source: seg000:071D–0736 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_071D_01071D(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0737 — <c>loc_00737</c> (seg000:0737).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following jump target is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_0c2f2</c> (CS1:C2F2) — unregistered (tail-jump target via loc_00739)</description></item>
	/// </list>
	/// Sets AL=0x56 then tail-jumps to <c>loc_0c2f2</c> via <c>loc_00739</c>.
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0737_10737</c>.
	/// Source: seg000:0737–0739 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0737_010737(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:073C — <c>loc_0073c</c> (seg000:073C).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x57 then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Source: seg000:073C–073E in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_073C_01073C(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0740 — <c>loc_00740</c> (seg000:0740).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Calls <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered), sets AL=0x58,
	/// then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0740_10740</c>.
	/// Source: seg000:0740–0745 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0740_010740(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0747 — <c>loc_00747</c> (seg000:0747).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x59 then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0747_10747</c>.
	/// Source: seg000:0747–0749 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0747_010747(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:074B — <c>loc_0074b</c> (seg000:074B).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Calls <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered), sets AL=0x5A,
	/// then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Source: seg000:074B–0750 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_074B_01074B(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0752 — <c>loc_00752</c> (seg000:0752).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x5B then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0752_10752</c>.
	/// Source: seg000:0752–0754 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0752_010752(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0756 — <c>loc_00756</c> (seg000:0756).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x5C then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0756_10756</c>.
	/// Source: seg000:0756–0758 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0756_010756(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:075A — <c>loc_0075a</c> (seg000:075A).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x5D then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Source: seg000:075A–075C in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_075A_01075A(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:075E — <c>loc_0075e</c> (seg000:075E).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x5E then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Source: seg000:075E–0760 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_075E_01075E(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0762 — <c>loc_00762</c> (seg000:0762).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x5F then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0762_10762</c>.
	/// Source: seg000:0762–0764 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0762_010762(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0766 — <c>loc_00766</c> (seg000:0766).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Sets AL=0x60 then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0766_10766</c>.
	/// Source: seg000:0766–0768 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0766_010766(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:076A — <c>loc_0076a</c> (seg000:076A).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Calls <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered), sets AL=0x61,
	/// then tail-jumps to <c>loc_0c2f2</c> (CS1:C2F2, unregistered).
	/// Also called by <c>loc_002fe</c> (CS1:02FE) via a direct jump.
	/// Source: seg000:076A–076F in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_076A_01076A(int gotoAddress) {
		return NearRet();
	}

	// -------------------------------------------------------------------------
	// Batch C — intro scene per-scene callbacks (seg000:0771–0868)
	// -------------------------------------------------------------------------

	/// <summary>
	/// Stub for CS1:0771 — <c>intro_lady_jessica_2</c> (seg000:0771).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_00978</c> (CS1:0978) — unregistered</description></item>
	/// <item><description><c>loc_0099d</c> (CS1:099D) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0771_10771</c>.
	/// Source: seg000:0771–077A in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroLadyJessica2_1000_0771_010771(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:077C — <c>intro_inside_sietch</c> (seg000:077C).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_00981</c> (CS1:0981) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered).
	/// Source: seg000:077C–0786 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroInsideSietch_1000_077C_01077C(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0788 — <c>intro_chani_in_sietch</c> (seg000:0788).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_0099d</c> (CS1:099D) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Sets AL=7 then tail-jumps to <c>loc_0099d</c>.
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0788_10788</c>.
	/// Source: seg000:0788–078B in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroChaniInSietch_1000_0788_010788(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:078D — <c>loc_0078d</c> (seg000:078D).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>update_screen_palette</c> (CS1:C0F4) — unregistered</description></item>
	/// <item><description><c>loc_0c868</c> (CS1:C868) — unregistered (falls through to intro_talking_head_play)</description></item>
	/// </list>
	/// Source: seg000:078D–0797 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_078D_01078D(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0798 — <c>intro_talking_head_play</c> (seg000:0798).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_09efd</c> (CS1:9EFD) — unregistered</description></item>
	/// </list>
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0798_10798</c>.
	/// Source: seg000:0798–07A2 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroTalkingHeadPlay_1000_0798_010798(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:07A3 — <c>intro_kynes</c> (seg000:07A3).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>draw_icons_list_at_si</c> (CS1:C21B) — unregistered</description></item>
	/// <item><description><c>copy_active_framebuffer_to_framebuffer_2</c> (CS1:C412) — unregistered</description></item>
	/// <item><description><c>loc_0099d</c> (CS1:099D) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>open_resource_by_index</c> (CS1:C13E, registered),
	/// <c>draw_sprite_clobbering_bx_dx</c> (CS1:C22F, registered).
	/// Source: seg000:07A3–07C4 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroKynes_1000_07A3_0107A3(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:07C6 — <c>intro_somebody_in_sietch</c> (seg000:07C6).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_00981</c> (CS1:0981) — unregistered</description></item>
	/// <item><description><c>loc_0099d</c> (CS1:099D) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Source: seg000:07C6–07DD in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroSomebodyInSietch_1000_07C6_0107C6(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:07E0 — <c>intro_water_ripples_in_cave</c> (seg000:07E0).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>play_pcm_al</c> (CS1:ABDB) — unregistered</description></item>
	/// <item><description><c>loc_00981</c> (CS1:0981) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Source: seg000:07E0–07EC in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroWaterRipplesInCave_1000_07E0_0107E0(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:07EE — <c>intro_paul_on_red_background</c> real handler (seg000:07EE).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>draw_icons_list_at_si</c> (CS1:C21B) — unregistered</description></item>
	/// <item><description><c>loc_00960</c> (CS1:0960) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>open_resource_by_index</c> (CS1:C13E, registered).
	/// Note: the dispatch entry at CS1:02F8 is a separate self-patching trampoline;
	/// this is the actual scene handler at CS1:07EE.
	/// Source: seg000:07EE–07FA in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroPaulOnRedBackground_1000_07EE_0107EE(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:07FD — <c>intro_load_desert_sky_animation</c> (seg000:07FD).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>open_skyrs_palette</c> (CS1:0820) — unregistered (tail-calls unregistered <c>open_sky_palette_al_sub_bl_dsdx</c>)</description></item>
	/// <item><description><c>draw_icons_list_at_si</c> (CS1:C21B) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Also present: <c>gfx_clear_active_framebuffer</c> (CS1:C0AD, registered),
	/// <c>open_resource_by_index</c> (CS1:C13E, registered).
	/// Falls through to <c>loc_00802</c> (interior label at CS1:0802).
	/// Source: seg000:07FD–081D in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroLoadDesertSkyAnimation_1000_07FD_0107FD(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0820 — <c>open_skyrs_palette</c> (seg000:0820).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented due to tail-call limitation:
	/// <list type="bullet">
	/// <item><description>
	/// Sets AX=0x2E then tail-jumps to <c>open_sky_palette_al_sub_bl_dsdx</c>
	/// (CS1:3978, unregistered).
	/// </description></item>
	/// </list>
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0820_10820</c>.
	/// Source: seg000:0820–0824 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action OpenSkyrsPalette_1000_0820_010820(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0826 — <c>loc_00826</c> (seg000:0826).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callees are not yet registered:
	/// <list type="bullet">
	/// <item><description><c>open_skyrs_palette</c> (CS1:0820) — unregistered</description></item>
	/// <item><description><c>loc_0391d</c> (CS1:391D) — unregistered (tail-jump target)</description></item>
	/// </list>
	/// Conditional logic reads DS:[46D6], DS:[46D7] to determine sky palette transitions.
	/// Confirmed in Ghidra symbols as <c>unknown_1000_0826_10826</c>.
	/// Source: seg000:0826–0854 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0826_010826(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0857 — <c>loc_00857</c> (seg000:0857).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented due to tail-call limitation:
	/// <list type="bullet">
	/// <item><description>
	/// Sets AX=9 then tail-jumps to <c>open_resource_by_index</c>
	/// (CS1:C13E, static-def only).
	/// </description></item>
	/// </list>
	/// Source: seg000:0857–085C in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Unknown_1000_0857_010857(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:085D — <c>intro_play_desert_sky_animation</c> (seg000:085D).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>add_frame_task</c> (CS1:DA25) — unregistered</description></item>
	/// </list>
	/// Loads frame task SI=0x0826, BP=9, clears carry, then returns.
	/// Source: seg000:085D–0867 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroPlayDesertSkyAnimation_1000_085D_01085D(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:0868 — <c>intro_midnight</c> (seg000:0868).
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return (stub; original x86 executes when not registered).</returns>
	/// <remarks>
	/// Cannot be fully implemented because the following callee is not yet registered:
	/// <list type="bullet">
	/// <item><description><c>loc_00802</c> (CS1:0802) — interior entry of <c>intro_load_desert_sky_animation</c>, not a standalone registered override</description></item>
	/// </list>
	/// Also present: <c>draw_sprite_clobbering_bx_dx</c> (CS1:C22F, registered).
	/// Source: seg000:0868–087A in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action IntroMidnight_1000_0868_010868(int gotoAddress) {
		return NearRet();
	}
}