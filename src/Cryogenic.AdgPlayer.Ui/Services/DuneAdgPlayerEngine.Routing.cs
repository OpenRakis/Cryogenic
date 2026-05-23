namespace Cryogenic.AdgPlayer.Ui.Services;

/// <summary>
/// DNADG logical-channel to OPL voice routing.
/// </summary>
public sealed partial class DuneAdgPlayerEngine {
    /// <summary>
    /// Dynamic OPL voice routing for a logical channel.
    /// Faithful port of <c>AdgConfigureInstrumentRouting_090D</c> from <c>AdgDriverCode.cs</c>.
    /// </summary>
#pragma warning disable S907
    private void ConfigureInstrumentRouting(int ch, byte patchType) {
        ushort bp = _fadeScratch;
        ushort cx = _fadeScratch2;

        ushort axMask = (ushort)~_channelRouteScratch[ch];
        if ((axMask & 0x8000) == 0) {
            cx = (ushort)(cx & axMask);
        } else {
            bp = (ushort)(bp & axMask);
        }

        ushort ax = 0;
        ushort bx;

        if (patchType == 4) {
            bx = 0x0009; ax = 0x0000;
            if ((bp & bx) != 0) { bp |= bx; goto WriteBack; }
            bx = 0x0012; ax = 0x0101;
            if ((bp & bx) != 0) { bp |= bx; goto WriteBack; }
            bx = 0x0024; ax = 0x0202;
            if ((bp & bx) != 0) { bp |= bx; goto WriteBack; }

            bx = 0x0009; ax = 0x8080;
            if ((cx & bx) != 0) {
                cx |= bx;
                bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
                goto WriteBack;
            }
            bx = 0x0012; ax = 0x8181;
            if ((cx & bx) != 0) {
                cx |= bx;
                bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
                goto WriteBack;
            }
            bx = 0x0024; ax = 0x8282;
            if ((cx & bx) != 0) {
                cx |= bx;
                bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
                goto WriteBack;
            }
        }

        bx = (ushort)(~bp & 0x01C0);
        if (bx != 0) {
            bx = (ushort)(bx >> 4);
            (ax, bx) = AdgRoutingLookup(bx);
            bp = (ushort)(bp | bx);
        } else {
            bx = (ushort)~cx;
            if ((bx & 0x01C0) == 0) {
                byte bh = (byte)(((Lo8(bx) >> 3) ^ Lo8(bx)) & 0x07);
                if (bh != 0) {
                    bool carryBh = (bh & 0x01) != 0;
                    bh = (byte)(bh >> 1);
                    if (carryBh) { goto ChooseSec0; }
                    carryBh = (bh & 0x01) != 0;
                    if (carryBh) { goto ChooseSec1; }
                    goto ChooseSec2;
                }

                ax = bp;
                byte folded = (byte)((Lo8(ax) ^ (Lo8(ax) >> 3)) & 0x07);
                if (folded != 0) {
                    bx = (ushort)~bp;
                    bool cf = (folded & 0x01) != 0;
                    folded = (byte)(folded >> 1);
                    if (cf) { goto ChoosePri0; }
                    cf = (folded & 0x01) != 0;
                    if (cf) { goto ChoosePri1; }
                    goto ChoosePri2;
                }

                bx = (ushort)(bx & 0x003F);
                if (bx == 0) {
                    bx = (ushort)~bp;
                    if ((bx & 0x0024) != 0) { goto ChoosePri2; }
                    if ((bx & 0x0012) != 0) { goto ChoosePri1; }
                    goto ChoosePri0;
                }

                if ((bx & 0x0024) != 0) { goto ChooseSec2; }
                if ((bx & 0x0012) != 0) { goto ChooseSec1; }
                goto ChooseSec0;
            }

            bx = (ushort)((bx & 0x01C0) >> 4);
            (ax, bx) = AdgRoutingLookup(bx);
            ax = (ushort)(ax | 0x8080);
            cx = (ushort)(cx | bx);
            bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
        }
        goto WriteBack;

    ChoosePri0:
        ax = 0x0000;
        bx = (ushort)(bx & 0x0001);
        if (bx != 0) { bp = (ushort)(bp | bx); goto WriteBack; }
        ax = 0x0308;
        bx = Make16(0x08, Hi8(bx));
        bp = (ushort)(bp | bx);
        goto WriteBack;

    ChoosePri1:
        ax = 0x0101;
        bx = (ushort)(bx & 0x0002);
        if (bx != 0) { bp = (ushort)(bp | bx); goto WriteBack; }
        ax = 0x0409;
        bx = Make16(0x10, Hi8(bx));
        bp = (ushort)(bp | bx);
        goto WriteBack;

    ChoosePri2:
        ax = 0x0202;
        bx = (ushort)(bx & 0x0004);
        if (bx == 0) {
            ax = 0x050A;
            bx = Make16(0x20, Hi8(bx));
        }
        bp = (ushort)(bp | bx);
        goto WriteBack;

    ChooseSec0:
        ax = 0x8080;
        bx = (ushort)(bx & 0x0001);
        if (bx == 0) {
            ax = 0x8388;
            bx = Make16(0x08, Hi8(bx));
        }
        cx = (ushort)(cx | bx);
        bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
        goto WriteBack;

    ChooseSec1:
        ax = 0x8181;
        bx = (ushort)(bx & 0x0002);
        if (bx == 0) {
            ax = 0x8489;
            bx = Make16(0x10, Hi8(bx));
        }
        cx = (ushort)(cx | bx);
        bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
        goto WriteBack;

    ChooseSec2:
        ax = 0x8282;
        bx = (ushort)(bx & 0x0004);
        if (bx == 0) {
            ax = 0x858A;
            bx = Make16(0x20, Hi8(bx));
        }
        cx = (ushort)(cx | bx);
        bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));

    WriteBack:
        _channelRouteScratch[ch] = bx;
        _fadeScratch = bp;
        _fadeScratch2 = cx;
        _channelRoute[ch] = Hi8(ax);
        _channelPrimaryOpRoute[ch] = Lo8(ax);
        ax = (ushort)(ax + 0x0303);
        _channelRouteShadow[ch] = Hi8(ax);
        _channelSecondaryOpRoute[ch] = Lo8(ax);
    }
#pragma warning restore S907

    /// <summary>
    /// Routing lookup table at driver runtime offset 0x08ED (UNHSQ file offset 0x07ED).
    /// </summary>
    private static (ushort ax, ushort bxOut) AdgRoutingLookup(ushort index) {
        switch (index) {
            case 0x04: return (0x0610, 0x0040);
            case 0x08: return (0x0711, 0x0080);
            case 0x0C: return (0x0711, 0x0080);
            case 0x10: return (0x0812, 0x0100);
            case 0x14: return (0x0812, 0x0100);
            case 0x18: return (0x0812, 0x0100);
            case 0x1C: return (0x0812, 0x0100);
            default: return (0x0000, 0x0000);
        }
    }
}