namespace Cryogenic.Overrides;

using Spice86.Shared.Emulator.Memory;

using System;

/// <summary>
/// Partial class containing miscellaneous C# overrides from DNCDPRG.EXE that do not
/// fit cleanly into an existing domain file.
/// </summary>
/// <remarks>
/// Covers the phase-check helper (<c>loc_0127c</c>), the Fremen-status/room-load function
/// (<c>loc_01bec</c>, <c>loc_01c18</c>), the time-of-day dispatcher table functions
/// (0x1D9F–0x1E01), and several tiny trampoline stubs.
/// Source references are from <c>doc/DNCDPRG.lst</c>.
/// </remarks>
public partial class Overrides {

	/// <summary>
	/// Registers miscellaneous function overrides.
	/// </summary>
	/// <remarks>
	/// <c>Loc0127c_1000_127C_1127C</c> is fully implemented and registered.
	/// All other methods in this file are unregistered stubs.
	/// </remarks>
	public void DefineMiscCodeOverrides() {
		DefineFunction(cs1, 0x127C, Loc0127c_1000_127C_1127C);
	}

	/// <summary>
	/// Full implementation of CS1:127C — <c>loc_0127c</c> (seg000:127C).
	/// Phase-range check: returns with CF=1 (carry set) when AL==4 and
	/// DS:[2Ah] is in the half-open range [0x15, 0x20), otherwise CF=0.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused).</param>
	/// <returns>Near return with <c>CarryFlag</c> set appropriately.</returns>
	/// <remarks>
	/// Assembly:
	/// <code>
	/// cmp  al, 4
	/// jnz  loc_0128d     ; → clc ; ret
	/// cmp  [2ah], 15h
	/// jb   loc_0128d     ; → clc ; ret
	/// cmp  [2ah], 20h    ; sets CF = ([2ah] &lt; 0x20)
	/// ret
	/// </code>
	/// Callers test the carry flag with <c>jb</c> (jump-if-carry) after calling this routine.
	/// This is a pure flag-computation with no side effects.
	/// Source: seg000:127C–128E in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc0127c_1000_127C_1127C(int gotoAddress) {
		byte al = (byte)(AX & 0xFF);
		byte val = Memory.UInt8[MemoryUtils.ToPhysicalAddress(DS, 0x002A)];
		if (al != 4 || val < 0x15) {
			CarryFlag = false;
			return NearRet();
		}
		// cmp [2ah], 20h  → CF=1 if val < 0x20
		CarryFlag = val < 0x20;
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1BEC — <c>loc_01bec</c> (seg000:1BEC).
	/// Fremen-status handler: if DS:[2Bh] (Fremen-available flag) is zero, returns.
	/// Otherwise loads the character DI from DS:[114Eh], calls <c>loc_0503c</c>,
	/// sets DS:[46D9h] to 6 if it was non-zero, and potentially calls <c>loc_00b21</c>
	/// and sets a bit in DS:[473Bh].
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_0503c</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1BEC–1C17 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01bec_1000_1BEC_11BEC(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1C18 — <c>loc_01c18</c> (seg000:1C18).
	/// On-map room loader: if DS:[46EBh] is negative, loads the on-map resource, calls
	/// optional character-list and room-object hooks; if zero, optionally calls
	/// <c>loc_0bdbb</c>. Positive value causes immediate return.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>open_onmap_resource</c> — unregistered callee</description></item>
	/// <item><description><c>loc_078e9</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0600e</c> — unregistered callee</description></item>
	/// <item><description><c>loc_0bdbb</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1C18–1C45 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01c18_1000_1C18_11C18(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1D9F — <c>loc_01d9f</c> (seg000:1D9F).
	/// Time-of-day dispatcher entry: tests DS:[12h] bit 7 (0x80); if clear, checks
	/// a character slot at SI=0x1048 via <c>loc_01e01</c> and, if that succeeds (CF clear),
	/// calls <c>loc_01eda</c>.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_01e01</c> (CS1:1E01) — unregistered callee</description></item>
	/// <item><description><c>loc_01eda</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1D9F–1DB2 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01d9f_1000_1D9F_11D9F(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1DD3 — <c>loc_01dd3</c> (seg000:1DD3).
	/// No-op: bare <c>ret</c>. Used as a default (do-nothing) entry in the dispatcher
	/// table at DS:[1DB3h].
	/// Not registered (trivial; x86 executes the single <c>ret</c> byte directly).
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return.</returns>
	/// <remarks>
	/// Source: seg000:1DD3 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01dd3_1000_1DD3_11DD3(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1DD4 — <c>loc_01dd4</c> (seg000:1DD4).
	/// Trampoline: <c>jmp loc_020a4</c>. Dispatches to the spice-report scene entry point.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_020a4</c> — unregistered jump target</description></item>
	/// </list>
	/// Source: seg000:1DD4 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01dd4_1000_1DD4_11DD4(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1DD7 — <c>loc_01dd7</c> (seg000:1DD7).
	/// Trampoline: <c>jmp loc_01f64</c>. Dispatches to the night/morning scene transition.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_01f64</c> — unregistered jump target</description></item>
	/// </list>
	/// Source: seg000:1DD7 in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01dd7_1000_1DD7_11DD7(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1DDA — <c>loc_01dda</c> (seg000:1DDA).
	/// Combat-check dispatcher: tests DS:[0BFh] bit 4 and DS:[10h] bit 3 and DS:[0Bh]==8
	/// and DS:[0C2h]==0; if all pass, calls <c>loc_029ee</c> with AX=0x030B.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because:
	/// <list type="bullet">
	/// <item><description><c>loc_029ee</c> — unregistered callee</description></item>
	/// </list>
	/// Source: seg000:1DDA–1DFD in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01dda_1000_1DDA_11DDA(int gotoAddress) {
		return NearRet();
	}

	/// <summary>
	/// Stub for CS1:1E01 — <c>loc_01e01</c> (seg000:1E01).
	/// Character-slot morning check: verifies DS:[2Ah]==0x5D, checks the slot at DS:SI
	/// for type 7 and movement-state 0x80, then walks the character table to find and
	/// trigger a morning-event callback.
	/// Not registered pending full implementation.
	/// </summary>
	/// <param name="gotoAddress">Target address for potential jumps (unused in stub).</param>
	/// <returns>Near return (stub).</returns>
	/// <remarks>
	/// Cannot be fully implemented because: full callee list requires deeper CFG tracing
	/// of the inner loop beyond seg000:1E24.
	/// Source: seg000:1E01–1E3D in <c>doc/DNCDPRG.lst</c>.
	/// </remarks>
	public Action Loc01e01_1000_1E01_11E01(int gotoAddress) {
		return NearRet();
	}
}