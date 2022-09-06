namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action split_334B_1731_034BE1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24BFB: goto label_334B_174B_34BFB;break; // Target of external jump from 0x34C95, 0x34C3B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_1731_34BE1:
    // LODSW SI (334B_1731 / 0x34BE1)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BL,AL (334B_1732 / 0x34BE2)
    BL = AL;
    State.IncCycles();
    // AND AL,DL (334B_1734 / 0x34BE4)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:4c2a (334B_1736 / 0x34BE6)
    if(ZeroFlag) {
      goto label_334B_177A_34C2A;
    }
    State.IncCycles();
    // ADD AL,DH (334B_1738 / 0x34BE8)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_173A / 0x34BEA)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,BP (334B_173B / 0x34BEB)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4c22 (334B_173D / 0x34BED)
    if(!CarryFlag) {
      goto label_334B_1772_34C22;
    }
    State.IncCycles();
    // SHR BL,1 (334B_173F / 0x34BEF)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_1741 / 0x34BF1)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_1743 / 0x34BF3)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_1745 / 0x34BF5)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    State.IncCycles();
    // JZ 0x3000:4c3d (334B_1747 / 0x34BF7)
    if(ZeroFlag) {
      goto label_334B_178D_34C3D;
    }
    State.IncCycles();
    // MOV AL,BL (334B_1749 / 0x34BF9)
    AL = BL;
    State.IncCycles();
    label_334B_174B_34BFB:
    // ADD AL,DH (334B_174B / 0x34BFB)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_174D / 0x34BFD)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,BP (334B_174E / 0x34BFE)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4c22 (334B_1750 / 0x34C00)
    if(!CarryFlag) {
      goto label_334B_1772_34C22;
    }
    State.IncCycles();
    // MOV AL,AH (334B_1752 / 0x34C02)
    AL = AH;
    State.IncCycles();
    label_334B_1754_34C04:
    // AND AL,DL (334B_1754 / 0x34C04)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:4c4d (334B_1756 / 0x34C06)
    if(ZeroFlag) {
      goto label_334B_179D_34C4D;
    }
    State.IncCycles();
    // ADD AL,DH (334B_1758 / 0x34C08)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_175A / 0x34C0A)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,BP (334B_175B / 0x34C0B)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4c22 (334B_175D / 0x34C0D)
    if(!CarryFlag) {
      goto label_334B_1772_34C22;
    }
    State.IncCycles();
    // SHR AH,1 (334B_175F / 0x34C0F)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_1761_34C11:
    // SHR AH,1 (334B_1761 / 0x34C11)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_1763 / 0x34C13)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_1765 / 0x34C15)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:4c56 (334B_1767 / 0x34C17)
    if(ZeroFlag) {
      goto label_334B_17A6_34C56;
    }
    State.IncCycles();
    // MOV AL,AH (334B_1769 / 0x34C19)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_176B / 0x34C1B)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_176D / 0x34C1D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_334B_176E_34C1E:
    // CMP DI,BP (334B_176E / 0x34C1E)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JC 0x3000:4be1 (334B_1770 / 0x34C20)
    if(CarryFlag) {
      goto label_334B_1731_34BE1;
    }
    State.IncCycles();
    label_334B_1772_34C22:
    // POP DI (334B_1772 / 0x34C22)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x140 (334B_1773 / 0x34C23)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    // LOOP 0x3000:4bd8 (334B_1777 / 0x34C27)
    if(--CX != 0) {
      throw FailAsUntested("Would have been a goto but label label_334B_1728_34BD8 does not exist because no instruction was found there that belongs to a function.");
    }
    State.IncCycles();
    // RETF  (334B_1779 / 0x34C29)
    return FarRet();
    State.IncCycles();
    label_334B_177A_34C2A:
    // INC DI (334B_177A / 0x34C2A)
    DI++;
    State.IncCycles();
    // CMP DI,BP (334B_177B / 0x34C2B)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4c22 (334B_177D / 0x34C2D)
    if(!CarryFlag) {
      goto label_334B_1772_34C22;
    }
    State.IncCycles();
    // OR AL,BL (334B_177F / 0x34C2F)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    State.IncCycles();
    // JZ 0x3000:4c3d (334B_1781 / 0x34C31)
    if(ZeroFlag) {
      goto label_334B_178D_34C3D;
    }
    State.IncCycles();
    // SHR AL,1 (334B_1783 / 0x34C33)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1785 / 0x34C35)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1787 / 0x34C37)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1789 / 0x34C39)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JMP 0x3000:4bfb (334B_178B / 0x34C3B)
    goto label_334B_174B_34BFB;
    State.IncCycles();
    label_334B_178D_34C3D:
    // INC DI (334B_178D / 0x34C3D)
    DI++;
    State.IncCycles();
    // CMP DI,BP (334B_178E / 0x34C3E)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4c22 (334B_1790 / 0x34C40)
    if(!CarryFlag) {
      goto label_334B_1772_34C22;
    }
    State.IncCycles();
    // MOV AL,AH (334B_1792 / 0x34C42)
    AL = AH;
    State.IncCycles();
    // OR AL,AL (334B_1794 / 0x34C44)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x3000:4c04 (334B_1796 / 0x34C46)
    if(!ZeroFlag) {
      goto label_334B_1754_34C04;
    }
    State.IncCycles();
    // ADD DI,0x2 (334B_1798 / 0x34C48)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // JMP 0x3000:4c1e (334B_179B / 0x34C4B)
    goto label_334B_176E_34C1E;
    State.IncCycles();
    label_334B_179D_34C4D:
    // INC DI (334B_179D / 0x34C4D)
    DI++;
    State.IncCycles();
    // CMP DI,BP (334B_179E / 0x34C4E)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4c22 (334B_17A0 / 0x34C50)
    if(!CarryFlag) {
      goto label_334B_1772_34C22;
    }
    State.IncCycles();
    // SHR AH,1 (334B_17A2 / 0x34C52)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:4c11 (334B_17A4 / 0x34C54)
    if(ZeroFlag) {
      goto label_334B_1761_34C11;
    }
    State.IncCycles();
    label_334B_17A6_34C56:
    // INC DI (334B_17A6 / 0x34C56)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // JMP 0x3000:4c1e (334B_17A7 / 0x34C57)
    goto label_334B_176E_34C1E;
  }
  
  public virtual Action split_334B_17CF_034C7F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24C82: goto label_334B_17D2_34C82;break; // Target of external jump from 0x34A30
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_17CF_34C7F:
    // ADD SI,0x12 (334B_17CF / 0x34C7F)
    // SI += 0x12;
    SI = Alu.Add16(SI, 0x12);
    State.IncCycles();
    label_334B_17D2_34C82:
    // MOV BP,0x1234 (334B_17D2 / 0x34C82)
    BP = 0x1234;
    State.IncCycles();
    // PUSH DI (334B_17D5 / 0x34C85)
    Stack.Push(DI);
    State.IncCycles();
    // ADD BP,DI (334B_17D6 / 0x34C86)
    // BP += DI;
    BP = Alu.Add16(BP, DI);
    State.IncCycles();
    // LODSW SI (334B_17D8 / 0x34C88)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AL,0xf0 (334B_17D9 / 0x34C89)
    // AL &= 0xF0;
    AL = Alu.And8(AL, 0xF0);
    State.IncCycles();
    // JZ 0x3000:4c3d (334B_17DB / 0x34C8B)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_334B_1731_034BE1, 0x34C3D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // SHR AL,1 (334B_17DD / 0x34C8D)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_17DF / 0x34C8F)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_17E1 / 0x34C91)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_17E3 / 0x34C93)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JMP 0x3000:4bfb (334B_17E5 / 0x34C95)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_334B_1731_034BE1, 0x34BFB - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_17E8_034C98(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_17E8_34C98:
    // XOR CH,CH (334B_17E8 / 0x34C98)
    CH = 0;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (334B_17EA / 0x34C9A)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // SUB AX,BX (334B_17ED / 0x34C9D)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JLE 0x3000:4cac (334B_17EF / 0x34C9F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_17FC_34CAC;
    }
    State.IncCycles();
    // SUB CX,AX (334B_17F1 / 0x34CA1)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x3000:4cd5 (334B_17F3 / 0x34CA3)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    State.IncCycles();
    // ADD BX,AX (334B_17F5 / 0x34CA5)
    BX += AX;
    State.IncCycles();
    label_334B_17F7_34CA7:
    // ADD SI,DI (334B_17F7 / 0x34CA7)
    SI += DI;
    State.IncCycles();
    // DEC AX (334B_17F9 / 0x34CA9)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:4ca7 (334B_17FA / 0x34CAA)
    if(!ZeroFlag) {
      goto label_334B_17F7_34CA7;
    }
    State.IncCycles();
    label_334B_17FC_34CAC:
    // MOV AX,BX (334B_17FC / 0x34CAC)
    AX = BX;
    State.IncCycles();
    // ADD AX,CX (334B_17FE / 0x34CAE)
    AX += CX;
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x6] (334B_1800 / 0x34CB0)
    // AX -= UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    State.IncCycles();
    // JBE 0x3000:4cb9 (334B_1803 / 0x34CB3)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_1809_34CB9;
    }
    State.IncCycles();
    // SUB CX,AX (334B_1805 / 0x34CB5)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x3000:4cd5 (334B_1807 / 0x34CB7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    State.IncCycles();
    label_334B_1809_34CB9:
    // MOV AX,DX (334B_1809 / 0x34CB9)
    AX = DX;
    State.IncCycles();
    // ADD AX,DI (334B_180B / 0x34CBB)
    AX += DI;
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x4] (334B_180D / 0x34CBD)
    // AX -= UInt16[SS, (ushort)(BP + 0x4)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x4)]);
    State.IncCycles();
    // JG 0x3000:4d04 (334B_1810 / 0x34CC0)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1854_034D04, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_1812 / 0x34CC2)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,DX (334B_1815 / 0x34CC5)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JG 0x3000:4cd6 (334B_1817 / 0x34CC7)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_334B_1825_034CD5, 0x34CD6 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BP,DI (334B_1819 / 0x34CC9)
    BP = DI;
    State.IncCycles();
    // PUSH DI (334B_181B / 0x34CCB)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_181C / 0x34CCC)
    NearCall(cs2, 0x181F, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    // POP DX (334B_181F / 0x34CCF)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV BX,CX (334B_1820 / 0x34CD0)
    BX = CX;
    State.IncCycles();
    // JMP 0x3000:4ce7 (334B_1822 / 0x34CD2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1837_034CE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_334B_1825_034CD5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1825_34CD5:
    // RETF  (334B_1825 / 0x34CD5)
    return FarRet();
    State.IncCycles();
    label_334B_1826_34CD6:
    // MOV BP,DI (334B_1826 / 0x34CD6)
    BP = DI;
    State.IncCycles();
    // SUB DI,AX (334B_1828 / 0x34CD8)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // JLE 0x3000:4cd5 (334B_182A / 0x34CDA)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    State.IncCycles();
    // ADD DX,AX (334B_182C / 0x34CDC)
    DX += AX;
    State.IncCycles();
    // ADD SI,AX (334B_182E / 0x34CDE)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // PUSH DI (334B_1830 / 0x34CE0)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1831 / 0x34CE1)
    NearCall(cs2, 0x1834, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    // POP DX (334B_1834 / 0x34CE4)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV BX,CX (334B_1835 / 0x34CE5)
    BX = CX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1837_034CE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1837_034CE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1837_34CE7:
    // SUB BP,DX (334B_1837 / 0x34CE7)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    State.IncCycles();
    label_334B_1839_34CE9:
    // MOV CX,DX (334B_1839 / 0x34CE9)
    CX = DX;
    State.IncCycles();
    label_334B_183B_34CEB:
    // LODSB SI (334B_183B / 0x34CEB)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_183C / 0x34CEC)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:4cff (334B_183E / 0x34CEE)
    if(ZeroFlag) {
      goto label_334B_184F_34CFF;
    }
    State.IncCycles();
    // STOSB ES:DI (334B_1840 / 0x34CF0)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4ceb (334B_1841 / 0x34CF1)
    if(--CX != 0) {
      goto label_334B_183B_34CEB;
    }
    State.IncCycles();
    label_334B_1843_34CF3:
    // SUB DI,DX (334B_1843 / 0x34CF3)
    DI -= DX;
    State.IncCycles();
    // ADD SI,BP (334B_1845 / 0x34CF5)
    SI += BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_1847 / 0x34CF7)
    DI += 0x140;
    State.IncCycles();
    // DEC BX (334B_184B / 0x34CFB)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:4ce9 (334B_184C / 0x34CFC)
    if(!ZeroFlag) {
      goto label_334B_1839_34CE9;
    }
    State.IncCycles();
    // RETF  (334B_184E / 0x34CFE)
    return FarRet();
    State.IncCycles();
    label_334B_184F_34CFF:
    // INC DI (334B_184F / 0x34CFF)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:4ceb (334B_1850 / 0x34D00)
    if(--CX != 0) {
      goto label_334B_183B_34CEB;
    }
    State.IncCycles();
    // JMP 0x3000:4cf3 (334B_1852 / 0x34D02)
    goto label_334B_1843_34CF3;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1854_034D04(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1854_34D04:
    // MOV word ptr CS:[0x158b],DI (334B_1854 / 0x34D04)
    UInt16[cs2, 0x158B] = DI;
    State.IncCycles();
    // SUB DI,AX (334B_1859 / 0x34D09)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // JLE 0x3000:4cd5 (334B_185B / 0x34D0B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_185D / 0x34D0D)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,DX (334B_1860 / 0x34D10)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JG 0x3000:4d22 (334B_1862 / 0x34D12)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_334B_1872_34D22;
    }
    State.IncCycles();
    // PUSH DI (334B_1864 / 0x34D14)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1865 / 0x34D15)
    NearCall(cs2, 0x1868, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    // POP DX (334B_1868 / 0x34D18)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV BP,word ptr CS:[0x158b] (334B_1869 / 0x34D19)
    BP = UInt16[cs2, 0x158B];
    State.IncCycles();
    // MOV BX,CX (334B_186E / 0x34D1E)
    BX = CX;
    State.IncCycles();
    // JMP 0x3000:4ce7 (334B_1870 / 0x34D20)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1837_034CE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1872_34D22:
    // SUB DI,AX (334B_1872 / 0x34D22)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // JLE 0x3000:4cd5 (334B_1874 / 0x34D24)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    State.IncCycles();
    // ADD SI,AX (334B_1876 / 0x34D26)
    SI += AX;
    State.IncCycles();
    // ADD DX,AX (334B_1878 / 0x34D28)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // PUSH DI (334B_187A / 0x34D2A)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_187B / 0x34D2B)
    NearCall(cs2, 0x187E, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_187E_034D2E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_187E_034D2E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_187E_34D2E:
    // POP DX (334B_187E / 0x34D2E)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV BP,word ptr CS:[0x158b] (334B_187F / 0x34D2F)
    BP = UInt16[cs2, 0x158B];
    State.IncCycles();
    // MOV BX,CX (334B_1884 / 0x34D34)
    BX = CX;
    State.IncCycles();
    // JMP 0x3000:4ce7 (334B_1886 / 0x34D36)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1837_034CE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1888_034D38(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1888_34D38:
    // LODSW SI (334B_1888 / 0x34D38)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB DX,AX (334B_1889 / 0x34D39)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    State.IncCycles();
    // JNC 0x3000:4d3f (334B_188B / 0x34D3B)
    if(!CarryFlag) {
      goto label_334B_188F_34D3F;
    }
    State.IncCycles();
    // XOR DX,DX (334B_188D / 0x34D3D)
    DX = 0;
    State.IncCycles();
    label_334B_188F_34D3F:
    // LODSW SI (334B_188F / 0x34D3F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB BX,AX (334B_1890 / 0x34D40)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // JNC 0x3000:4d46 (334B_1892 / 0x34D42)
    if(!CarryFlag) {
      goto label_334B_1896_34D46;
    }
    State.IncCycles();
    // XOR BX,BX (334B_1894 / 0x34D44)
    BX = 0;
    State.IncCycles();
    label_334B_1896_34D46:
    // MOV CX,0x10 (334B_1896 / 0x34D46)
    CX = 0x10;
    State.IncCycles();
    // CMP BX,0xb8 (334B_1899 / 0x34D49)
    Alu.Sub16(BX, 0xB8);
    State.IncCycles();
    // JBE 0x3000:4d54 (334B_189D / 0x34D4D)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_18A4_34D54;
    }
    State.IncCycles();
    // MOV CX,0xc8 (334B_189F / 0x34D4F)
    CX = 0xC8;
    State.IncCycles();
    // SUB CX,BX (334B_18A2 / 0x34D52)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    State.IncCycles();
    label_334B_18A4_34D54:
    // CALL 0x3000:40c0 (334B_18A4 / 0x34D54)
    NearCall(cs2, 0x18A7, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_18A7_034D57, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_18A7_034D57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_18A7_34D57:
    // MOV AX,0xa000 (334B_18A7 / 0x34D57)
    AX = 0xA000;
    State.IncCycles();
    // MOV ES,AX (334B_18AA / 0x34D5A)
    ES = AX;
    State.IncCycles();
    // SUB DX,0x140 (334B_18AC / 0x34D5C)
    DX -= 0x140;
    State.IncCycles();
    // NEG DX (334B_18B0 / 0x34D60)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // CMP DX,0x10 (334B_18B2 / 0x34D62)
    Alu.Sub16(DX, 0x10);
    State.IncCycles();
    // JBE 0x3000:4d6a (334B_18B5 / 0x34D65)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_18BA_34D6A;
    }
    State.IncCycles();
    // MOV DX,0x10 (334B_18B7 / 0x34D67)
    DX = 0x10;
    State.IncCycles();
    label_334B_18BA_34D6A:
    // MOV word ptr CS:[0x18c],DX (334B_18BA / 0x34D6A)
    UInt16[cs2, 0x18C] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x18e],CX (334B_18BF / 0x34D6F)
    UInt16[cs2, 0x18E] = CX;
    State.IncCycles();
    // MOV word ptr CS:[0x18a],DI (334B_18C4 / 0x34D74)
    UInt16[cs2, 0x18A] = DI;
    State.IncCycles();
    // MOV BX,0xfa00 (334B_18C9 / 0x34D79)
    BX = 0xFA00;
    State.IncCycles();
    // SHR DX,1 (334B_18CC / 0x34D7C)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    State.IncCycles();
    // MOV word ptr CS:[0x190],DX (334B_18CE / 0x34D7E)
    UInt16[cs2, 0x190] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x192],CX (334B_18D3 / 0x34D83)
    UInt16[cs2, 0x192] = CX;
    State.IncCycles();
    label_334B_18D8_34D88:
    // MOV CX,word ptr CS:[0x190] (334B_18D8 / 0x34D88)
    CX = UInt16[cs2, 0x190];
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x20] (334B_18DD / 0x34D8D)
    BP = UInt16[DS, (ushort)(SI + 0x20)];
    State.IncCycles();
    // LODSW SI (334B_18E0 / 0x34D90)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (334B_18E1 / 0x34D91)
    DX = AX;
    State.IncCycles();
    // JCXZ 0x3000:4dc1 (334B_18E3 / 0x34D93)
    if(CX == 0) {
      goto label_334B_1911_34DC1;
    }
    State.IncCycles();
    label_334B_18E5_34D95:
    // MOV AX,word ptr ES:[DI] (334B_18E5 / 0x34D95)
    AX = UInt16[ES, DI];
    State.IncCycles();
    // MOV word ptr ES:[BX],AX (334B_18E8 / 0x34D98)
    UInt16[ES, BX] = AX;
    State.IncCycles();
    // ADD BX,0x2 (334B_18EB / 0x34D9B)
    BX += 0x2;
    State.IncCycles();
    // ROL BP,1 (334B_18EE / 0x34D9E)
    BP = Alu.Rol16(BP, 0x1);
    State.IncCycles();
    // ADD DX,DX (334B_18F0 / 0x34DA0)
    // DX += DX;
    DX = Alu.Add16(DX, DX);
    State.IncCycles();
    // JC 0x3000:4dae (334B_18F2 / 0x34DA2)
    if(CarryFlag) {
      goto label_334B_18FE_34DAE;
    }
    State.IncCycles();
    // XOR AL,AL (334B_18F4 / 0x34DA4)
    AL = 0;
    State.IncCycles();
    // TEST BP,0x1 (334B_18F6 / 0x34DA6)
    Alu.And16(BP, 0x1);
    State.IncCycles();
    // JZ 0x3000:4dae (334B_18FA / 0x34DAA)
    if(ZeroFlag) {
      goto label_334B_18FE_34DAE;
    }
    State.IncCycles();
    // MOV AL,0xf (334B_18FC / 0x34DAC)
    AL = 0xF;
    State.IncCycles();
    label_334B_18FE_34DAE:
    // ROL BP,1 (334B_18FE / 0x34DAE)
    BP = Alu.Rol16(BP, 0x1);
    State.IncCycles();
    // ADD DX,DX (334B_1900 / 0x34DB0)
    // DX += DX;
    DX = Alu.Add16(DX, DX);
    State.IncCycles();
    // JC 0x3000:4dbe (334B_1902 / 0x34DB2)
    if(CarryFlag) {
      goto label_334B_190E_34DBE;
    }
    State.IncCycles();
    // XOR AH,AH (334B_1904 / 0x34DB4)
    AH = 0;
    State.IncCycles();
    // TEST BP,0x1 (334B_1906 / 0x34DB6)
    Alu.And16(BP, 0x1);
    State.IncCycles();
    // JZ 0x3000:4dbe (334B_190A / 0x34DBA)
    if(ZeroFlag) {
      goto label_334B_190E_34DBE;
    }
    State.IncCycles();
    // MOV AH,0xf (334B_190C / 0x34DBC)
    AH = 0xF;
    State.IncCycles();
    label_334B_190E_34DBE:
    // STOSW ES:DI (334B_190E / 0x34DBE)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LOOP 0x3000:4d95 (334B_190F / 0x34DBF)
    if(--CX != 0) {
      goto label_334B_18E5_34D95;
    }
    State.IncCycles();
    label_334B_1911_34DC1:
    // TEST byte ptr CS:[0x18c],0x1 (334B_1911 / 0x34DC1)
    Alu.And8(UInt8[cs2, 0x18C], 0x1);
    State.IncCycles();
    // JZ 0x3000:4ddf (334B_1917 / 0x34DC7)
    if(ZeroFlag) {
      goto label_334B_192F_34DDF;
    }
    State.IncCycles();
    // MOV AL,byte ptr ES:[DI] (334B_1919 / 0x34DC9)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // MOV byte ptr ES:[BX],AL (334B_191C / 0x34DCC)
    UInt8[ES, BX] = AL;
    State.IncCycles();
    // INC BX (334B_191F / 0x34DCF)
    BX++;
    State.IncCycles();
    // INC DI (334B_1920 / 0x34DD0)
    DI++;
    State.IncCycles();
    // ADD DX,DX (334B_1921 / 0x34DD1)
    // DX += DX;
    DX = Alu.Add16(DX, DX);
    State.IncCycles();
    // JC 0x3000:4ddf (334B_1923 / 0x34DD3)
    if(CarryFlag) {
      goto label_334B_192F_34DDF;
    }
    State.IncCycles();
    // XOR AL,AL (334B_1925 / 0x34DD5)
    AL = 0;
    State.IncCycles();
    // ADD BP,BP (334B_1927 / 0x34DD7)
    // BP += BP;
    BP = Alu.Add16(BP, BP);
    State.IncCycles();
    // JNC 0x3000:4ddd (334B_1929 / 0x34DD9)
    if(!CarryFlag) {
      goto label_334B_192D_34DDD;
    }
    State.IncCycles();
    // MOV AL,0xf (334B_192B / 0x34DDB)
    AL = 0xF;
    State.IncCycles();
    label_334B_192D_34DDD:
    // DEC DI (334B_192D / 0x34DDD)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // STOSB ES:DI (334B_192E / 0x34DDE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_334B_192F_34DDF:
    // SUB DI,word ptr CS:[0x18c] (334B_192F / 0x34DDF)
    DI -= UInt16[cs2, 0x18C];
    State.IncCycles();
    // ADD DI,0x140 (334B_1934 / 0x34DE4)
    DI += 0x140;
    State.IncCycles();
    // DEC word ptr CS:[0x192] (334B_1938 / 0x34DE8)
    UInt16[cs2, 0x192] = Alu.Dec16(UInt16[cs2, 0x192]);
    State.IncCycles();
    // JNZ 0x3000:4d88 (334B_193D / 0x34DED)
    if(!ZeroFlag) {
      goto label_334B_18D8_34D88;
    }
    State.IncCycles();
    // RETF  (334B_193F / 0x34DEF)
    return FarRet();
  }
  
  public virtual Action not_observed_334B_1940_034DF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1940_34DF0:
    // PUSH AX (334B_1940 / 0x34DF0)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_1941 / 0x34DF1)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_1942 / 0x34DF2)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_1943 / 0x34DF3)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_1944 / 0x34DF4)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_1945 / 0x34DF5)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (334B_1946 / 0x34DF6)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH DS (334B_1947 / 0x34DF7)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_1948 / 0x34DF8)
    Stack.Push(ES);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x18a] (334B_1949 / 0x34DF9)
    BP = UInt16[cs2, 0x18A];
    State.IncCycles();
    // MOV BX,word ptr CS:[0x18c] (334B_194E / 0x34DFE)
    BX = UInt16[cs2, 0x18C];
    State.IncCycles();
    // MOV DX,word ptr CS:[0x18e] (334B_1953 / 0x34E03)
    DX = UInt16[cs2, 0x18E];
    State.IncCycles();
    // MOV AX,0xa000 (334B_1958 / 0x34E08)
    AX = 0xA000;
    State.IncCycles();
    // MOV ES,AX (334B_195B / 0x34E0B)
    ES = AX;
    State.IncCycles();
    // MOV DS,AX (334B_195D / 0x34E0D)
    DS = AX;
    State.IncCycles();
    // MOV SI,0xfa00 (334B_195F / 0x34E0F)
    SI = 0xFA00;
    State.IncCycles();
    label_334B_1962_34E12:
    // MOV DI,BP (334B_1962 / 0x34E12)
    DI = BP;
    State.IncCycles();
    // MOV CX,BX (334B_1964 / 0x34E14)
    CX = BX;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_1966 / 0x34E16)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // ADD BP,0x140 (334B_1968 / 0x34E18)
    BP += 0x140;
    State.IncCycles();
    // DEC DX (334B_196C / 0x34E1C)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:4e12 (334B_196D / 0x34E1D)
    if(!ZeroFlag) {
      goto label_334B_1962_34E12;
    }
    State.IncCycles();
    // POP ES (334B_196F / 0x34E1F)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_1970 / 0x34E20)
    DS = Stack.Pop();
    State.IncCycles();
    // POP BP (334B_1971 / 0x34E21)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_1972 / 0x34E22)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_1973 / 0x34E23)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_1974 / 0x34E24)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_1975 / 0x34E25)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_1976 / 0x34E26)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_1977 / 0x34E27)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1978 / 0x34E28)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1979_034E29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1979_34E29:
    // XOR AX,AX (334B_1979 / 0x34E29)
    AX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_197B_034E2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_197B_034E2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_197B_34E2B:
    // MOV AH,AL (334B_197B / 0x34E2B)
    AH = AL;
    State.IncCycles();
    // PUSH AX (334B_197D / 0x34E2D)
    Stack.Push(AX);
    State.IncCycles();
    // LODSW SI (334B_197E / 0x34E2E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (334B_197F / 0x34E2F)
    DX = AX;
    State.IncCycles();
    // LODSW SI (334B_1981 / 0x34E31)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (334B_1982 / 0x34E32)
    BX = AX;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1984 / 0x34E34)
    NearCall(cs2, 0x1987, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1987_034E37, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1987_034E37(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1987_34E37:
    // LODSW SI (334B_1987 / 0x34E37)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (334B_1988 / 0x34E38)
    BP = AX;
    State.IncCycles();
    // SUB BP,DX (334B_198A / 0x34E3A)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    State.IncCycles();
    // JBE 0x3000:4e77 (334B_198C / 0x34E3C)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_19C7_34E77;
    }
    State.IncCycles();
    // LODSW SI (334B_198E / 0x34E3E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB BX,AX (334B_198F / 0x34E3F)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // JNC 0x3000:4e77 (334B_1991 / 0x34E41)
    if(!CarryFlag) {
      goto label_334B_19C7_34E77;
    }
    State.IncCycles();
    // NEG BX (334B_1993 / 0x34E43)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // POP AX (334B_1995 / 0x34E45)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV SI,DI (334B_1996 / 0x34E46)
    SI = DI;
    State.IncCycles();
    // SHR BP,1 (334B_1998 / 0x34E48)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JC 0x3000:4e5c (334B_199A / 0x34E4A)
    if(CarryFlag) {
      goto label_334B_19AC_34E5C;
    }
    State.IncCycles();
    // JZ 0x3000:4e76 (334B_199C / 0x34E4C)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_19C6 / 0x34E76)
      return FarRet();
    }
    State.IncCycles();
    label_334B_199E_34E4E:
    // MOV DI,SI (334B_199E / 0x34E4E)
    DI = SI;
    State.IncCycles();
    // MOV CX,BP (334B_19A0 / 0x34E50)
    CX = BP;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_19A2 / 0x34E52)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD SI,0x140 (334B_19A4 / 0x34E54)
    SI += 0x140;
    State.IncCycles();
    // DEC BX (334B_19A8 / 0x34E58)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:4e4e (334B_19A9 / 0x34E59)
    if(!ZeroFlag) {
      goto label_334B_199E_34E4E;
    }
    State.IncCycles();
    // RETF  (334B_19AB / 0x34E5B)
    return FarRet();
    State.IncCycles();
    label_334B_19AC_34E5C:
    // JZ 0x3000:4e6d (334B_19AC / 0x34E5C)
    if(ZeroFlag) {
      goto label_334B_19BD_34E6D;
    }
    State.IncCycles();
    label_334B_19AE_34E5E:
    // MOV DI,SI (334B_19AE / 0x34E5E)
    DI = SI;
    State.IncCycles();
    // MOV CX,BP (334B_19B0 / 0x34E60)
    CX = BP;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_19B2 / 0x34E62)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // STOSB ES:DI (334B_19B4 / 0x34E64)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD SI,0x140 (334B_19B5 / 0x34E65)
    SI += 0x140;
    State.IncCycles();
    // DEC BX (334B_19B9 / 0x34E69)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:4e5e (334B_19BA / 0x34E6A)
    if(!ZeroFlag) {
      goto label_334B_19AE_34E5E;
    }
    State.IncCycles();
    // RETF  (334B_19BC / 0x34E6C)
    return FarRet();
    State.IncCycles();
    label_334B_19BD_34E6D:
    // MOV CX,BX (334B_19BD / 0x34E6D)
    CX = BX;
    State.IncCycles();
    label_334B_19BF_34E6F:
    // STOSB ES:DI (334B_19BF / 0x34E6F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DI,0x13f (334B_19C0 / 0x34E70)
    // DI += 0x13F;
    DI = Alu.Add16(DI, 0x13F);
    State.IncCycles();
    // LOOP 0x3000:4e6f (334B_19C4 / 0x34E74)
    if(--CX != 0) {
      goto label_334B_19BF_34E6F;
    }
    State.IncCycles();
    label_334B_19C6_34E76:
    // RETF  (334B_19C6 / 0x34E76)
    return FarRet();
    State.IncCycles();
    label_334B_19C7_34E77:
    // POP AX (334B_19C7 / 0x34E77)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_19C8 / 0x34E78)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_19C9_034E79(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_19C9_34E79:
    // MOV DX,word ptr [BP + 0x0] (334B_19C9 / 0x34E79)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_19CC / 0x34E7C)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_19CF / 0x34E7F)
    NearCall(cs2, 0x19D2, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_19D2_034E82, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_19D2_034E82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_19D2_34E82:
    // MOV SI,DI (334B_19D2 / 0x34E82)
    SI = DI;
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x8] (334B_19D4 / 0x34E84)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0xa] (334B_19D7 / 0x34E87)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_19DA / 0x34E8A)
    NearCall(cs2, 0x19DD, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    label_334B_19DD_34E8D:
    // MOV DX,word ptr [BP + 0x4] (334B_19DD / 0x34E8D)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (334B_19E0 / 0x34E90)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    label_334B_19E3_34E93:
    // MOV CX,DX (334B_19E3 / 0x34E93)
    CX = DX;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_19E5 / 0x34E95)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // SUB SI,DX (334B_19E7 / 0x34E97)
    SI -= DX;
    State.IncCycles();
    // SUB DI,DX (334B_19E9 / 0x34E99)
    DI -= DX;
    State.IncCycles();
    // ADD SI,0x140 (334B_19EB / 0x34E9B)
    SI += 0x140;
    State.IncCycles();
    // ADD DI,0x140 (334B_19EF / 0x34E9F)
    DI += 0x140;
    State.IncCycles();
    // DEC BX (334B_19F3 / 0x34EA3)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:4e93 (334B_19F4 / 0x34EA4)
    if(!ZeroFlag) {
      goto label_334B_19E3_34E93;
    }
    State.IncCycles();
    // RETF  (334B_19F6 / 0x34EA6)
    return FarRet();
  }
  
  public virtual Action not_observed_334B_19F7_034EA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_19F7_34EA7:
    // PUSH AX (334B_19F7 / 0x34EA7)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (334B_19F8 / 0x34EA8)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (334B_19F9 / 0x34EA9)
    Stack.Push(DI);
    State.IncCycles();
    // XOR DI,DI (334B_19FA / 0x34EAA)
    DI = 0;
    State.IncCycles();
    // XOR AX,AX (334B_19FC / 0x34EAC)
    AX = 0;
    State.IncCycles();
    // MOV CX,0x7d00 (334B_19FE / 0x34EAE)
    CX = 0x7D00;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_1A01 / 0x34EB1)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP DI (334B_1A03 / 0x34EB3)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_1A04 / 0x34EB4)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_1A05 / 0x34EB5)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1A06 / 0x34EB6)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1A07_034EB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1A07_34EB7:
    // MOV word ptr CS:[0x19a],BP (334B_1A07 / 0x34EB7)
    UInt16[cs2, 0x19A] = BP;
    State.IncCycles();
    // MOV word ptr CS:[0x198],SI (334B_1A0C / 0x34EBC)
    UInt16[cs2, 0x198] = SI;
    State.IncCycles();
    // MOV CS:[0x19c],AL (334B_1A11 / 0x34EC1)
    UInt8[cs2, 0x19C] = AL;
    State.IncCycles();
    // PUSH AX (334B_1A15 / 0x34EC5)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_1A16 / 0x34EC6)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_1A17 / 0x34EC7)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_1A18 / 0x34EC8)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (334B_1A19 / 0x34EC9)
    Stack.Push(DI);
    State.IncCycles();
    // MOV word ptr CS:[0x194],DX (334B_1A1A / 0x34ECA)
    UInt16[cs2, 0x194] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x196],BX (334B_1A1F / 0x34ECF)
    UInt16[cs2, 0x196] = BX;
    State.IncCycles();
    // SUB BX,CX (334B_1A24 / 0x34ED4)
    BX -= CX;
    State.IncCycles();
    // SUB DX,DI (334B_1A26 / 0x34ED6)
    DX -= DI;
    State.IncCycles();
    // NEG BX (334B_1A28 / 0x34ED8)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // NEG DX (334B_1A2A / 0x34EDA)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // CALL 0x3000:4f8c (334B_1A2C / 0x34EDC)
    NearCall(cs2, 0x1A2F, spice86_generated_label_call_target_334B_1ADC_034F8C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1A2F_034EDF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1A2F_034EDF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1A2F_34EDF:
    // MOV BP,word ptr CS:[0x19a] (334B_1A2F / 0x34EDF)
    BP = UInt16[cs2, 0x19A];
    State.IncCycles();
    // POP DI (334B_1A34 / 0x34EE4)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_1A35 / 0x34EE5)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_1A36 / 0x34EE6)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_1A37 / 0x34EE7)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_1A38 / 0x34EE8)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1A39 / 0x34EE9)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1A3A_034EEA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1A3A_34EEA:
    // MOV BX,word ptr CS:[0x196] (334B_1A3A / 0x34EEA)
    BX = UInt16[cs2, 0x196];
    State.IncCycles();
    // MOV CX,DX (334B_1A3F / 0x34EEF)
    CX = DX;
    State.IncCycles();
    // MOV AX,CS:[0x194] (334B_1A41 / 0x34EF1)
    AX = UInt16[cs2, 0x194];
    State.IncCycles();
    // MOV DX,AX (334B_1A45 / 0x34EF5)
    DX = AX;
    State.IncCycles();
    // ADD AX,CX (334B_1A47 / 0x34EF7)
    AX += CX;
    State.IncCycles();
    // CMP AX,DX (334B_1A49 / 0x34EF9)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JG 0x3000:4f01 (334B_1A4B / 0x34EFB)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_334B_1A51_34F01;
    }
    State.IncCycles();
    // MOV DX,AX (334B_1A4D / 0x34EFD)
    DX = AX;
    State.IncCycles();
    // NEG CX (334B_1A4F / 0x34EFF)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_334B_1A51_34F01:
    // MOV DI,word ptr CS:[0x198] (334B_1A51 / 0x34F01)
    DI = UInt16[cs2, 0x198];
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x2] (334B_1A56 / 0x34F06)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JL 0x3000:4f33 (334B_1A59 / 0x34F09)
    if(SignFlag != OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1A63_034F13, 0x34F33 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x6] (334B_1A5B / 0x34F0B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // JGE 0x3000:4f33 (334B_1A5E / 0x34F0E)
    if(SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1A63_034F13, 0x34F33 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1A60 / 0x34F10)
    NearCall(cs2, 0x1A63, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1A63_034F13, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1A63_034F13(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1A63_34F13:
    // INC CX (334B_1A63 / 0x34F13)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // MOV AL,CS:[0x19c] (334B_1A64 / 0x34F14)
    AL = UInt8[cs2, 0x19C];
    State.IncCycles();
    // MOV SI,word ptr CS:[0x198] (334B_1A68 / 0x34F18)
    SI = UInt16[cs2, 0x198];
    State.IncCycles();
    label_334B_1A6D_34F1D:
    // ROL word ptr CS:[0x19a],1 (334B_1A6D / 0x34F1D)
    UInt16[cs2, 0x19A] = Alu.Rol16(UInt16[cs2, 0x19A], 0x1);
    State.IncCycles();
    // JNC 0x3000:4f2f (334B_1A72 / 0x34F22)
    if(!CarryFlag) {
      goto label_334B_1A7F_34F2F;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI] (334B_1A74 / 0x34F24)
    Alu.Sub16(DX, UInt16[DS, SI]);
    State.IncCycles();
    // JL 0x3000:4f2f (334B_1A76 / 0x34F26)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1A7F_34F2F;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI + 0x4] (334B_1A78 / 0x34F28)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JGE 0x3000:4f2f (334B_1A7B / 0x34F2B)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1A7F_34F2F;
    }
    State.IncCycles();
    // STOSB ES:DI (334B_1A7D / 0x34F2D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // DEC DI (334B_1A7E / 0x34F2E)
    DI--;
    State.IncCycles();
    label_334B_1A7F_34F2F:
    // INC DI (334B_1A7F / 0x34F2F)
    DI++;
    State.IncCycles();
    // INC DX (334B_1A80 / 0x34F30)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // LOOP 0x3000:4f1d (334B_1A81 / 0x34F31)
    if(--CX != 0) {
      goto label_334B_1A6D_34F1D;
    }
    State.IncCycles();
    label_334B_1A83_34F33:
    // POP SI (334B_1A83 / 0x34F33)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_1A84 / 0x34F34)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (334B_1A85 / 0x34F35)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1A86_034F36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1A86_34F36:
    // MOV CX,BX (334B_1A86 / 0x34F36)
    CX = BX;
    State.IncCycles();
    // MOV BX,word ptr CS:[0x196] (334B_1A88 / 0x34F38)
    BX = UInt16[cs2, 0x196];
    State.IncCycles();
    // MOV DX,word ptr CS:[0x194] (334B_1A8D / 0x34F3D)
    DX = UInt16[cs2, 0x194];
    State.IncCycles();
    // OR AX,AX (334B_1A92 / 0x34F42)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x3000:4f48 (334B_1A94 / 0x34F44)
    if(!SignFlag) {
      goto label_334B_1A98_34F48;
    }
    State.IncCycles();
    // SUB BX,CX (334B_1A96 / 0x34F46)
    BX -= CX;
    State.IncCycles();
    label_334B_1A98_34F48:
    // CMP BX,0xc8 (334B_1A98 / 0x34F48)
    Alu.Sub16(BX, 0xC8);
    State.IncCycles();
    // JC 0x3000:4f54 (334B_1A9C / 0x34F4C)
    if(CarryFlag) {
      goto label_334B_1AA4_34F54;
    }
    State.IncCycles();
    // JGE 0x3000:4f89 (334B_1A9E / 0x34F4E)
    if(SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1AB5_034F65, 0x34F89 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD CX,BX (334B_1AA0 / 0x34F50)
    CX += BX;
    State.IncCycles();
    // XOR BX,BX (334B_1AA2 / 0x34F52)
    BX = 0;
    State.IncCycles();
    label_334B_1AA4_34F54:
    // MOV DI,word ptr CS:[0x198] (334B_1AA4 / 0x34F54)
    DI = UInt16[cs2, 0x198];
    State.IncCycles();
    // CMP DX,word ptr [DI] (334B_1AA9 / 0x34F59)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JL 0x3000:4f89 (334B_1AAB / 0x34F5B)
    if(SignFlag != OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1AB5_034F65, 0x34F89 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI + 0x4] (334B_1AAD / 0x34F5D)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JGE 0x3000:4f89 (334B_1AB0 / 0x34F60)
    if(SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1AB5_034F65, 0x34F89 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1AB2 / 0x34F62)
    NearCall(cs2, 0x1AB5, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1AB5_034F65, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1AB5_034F65(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1AB5_34F65:
    // INC CX (334B_1AB5 / 0x34F65)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // MOV AL,CS:[0x19c] (334B_1AB6 / 0x34F66)
    AL = UInt8[cs2, 0x19C];
    State.IncCycles();
    // MOV SI,word ptr CS:[0x198] (334B_1ABA / 0x34F6A)
    SI = UInt16[cs2, 0x198];
    State.IncCycles();
    label_334B_1ABF_34F6F:
    // ROL word ptr CS:[0x19a],1 (334B_1ABF / 0x34F6F)
    UInt16[cs2, 0x19A] = Alu.Rol16(UInt16[cs2, 0x19A], 0x1);
    State.IncCycles();
    // JNC 0x3000:4f82 (334B_1AC4 / 0x34F74)
    if(!CarryFlag) {
      goto label_334B_1AD2_34F82;
    }
    State.IncCycles();
    // CMP BX,word ptr [SI + 0x2] (334B_1AC6 / 0x34F76)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JL 0x3000:4f82 (334B_1AC9 / 0x34F79)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1AD2_34F82;
    }
    State.IncCycles();
    // CMP BX,word ptr [SI + 0x6] (334B_1ACB / 0x34F7B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JGE 0x3000:4f82 (334B_1ACE / 0x34F7E)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1AD2_34F82;
    }
    State.IncCycles();
    // STOSB ES:DI (334B_1AD0 / 0x34F80)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // DEC DI (334B_1AD1 / 0x34F81)
    DI--;
    State.IncCycles();
    label_334B_1AD2_34F82:
    // INC BX (334B_1AD2 / 0x34F82)
    BX++;
    State.IncCycles();
    // ADD DI,0x140 (334B_1AD3 / 0x34F83)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    // LOOP 0x3000:4f6f (334B_1AD7 / 0x34F87)
    if(--CX != 0) {
      goto label_334B_1ABF_34F6F;
    }
    State.IncCycles();
    label_334B_1AD9_34F89:
    // POP SI (334B_1AD9 / 0x34F89)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_1ADA / 0x34F8A)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (334B_1ADB / 0x34F8B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_1ADC_034F8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1ADC_34F8C:
    // PUSH DI (334B_1ADC / 0x34F8C)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH SI (334B_1ADD / 0x34F8D)
    Stack.Push(SI);
    State.IncCycles();
    // OR BX,BX (334B_1ADE / 0x34F8E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNZ 0x3000:4f95 (334B_1AE0 / 0x34F90)
    if(!ZeroFlag) {
      goto label_334B_1AE5_34F95;
    }
    State.IncCycles();
    // JMP 0x3000:4eea (334B_1AE2 / 0x34F92)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1A3A_034EEA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1AE5_34F95:
    // MOV AX,0x1 (334B_1AE5 / 0x34F95)
    AX = 0x1;
    State.IncCycles();
    // JNS 0x3000:4f9e (334B_1AE8 / 0x34F98)
    if(!SignFlag) {
      goto label_334B_1AEE_34F9E;
    }
    State.IncCycles();
    // NEG BX (334B_1AEA / 0x34F9A)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // NEG AX (334B_1AEC / 0x34F9C)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_334B_1AEE_34F9E:
    // OR DX,DX (334B_1AEE / 0x34F9E)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x3000:4f36 (334B_1AF0 / 0x34FA0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1A86_034F36, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x1 (334B_1AF2 / 0x34FA2)
    CX = 0x1;
    State.IncCycles();
    // JNS 0x3000:4fab (334B_1AF5 / 0x34FA5)
    if(!SignFlag) {
      goto label_334B_1AFB_34FAB;
    }
    State.IncCycles();
    // NEG CX (334B_1AF7 / 0x34FA7)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // NEG DX (334B_1AF9 / 0x34FA9)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_334B_1AFB_34FAB:
    // PUSH AX (334B_1AFB / 0x34FAB)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (334B_1AFC / 0x34FAC)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH AX (334B_1AFD / 0x34FAD)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (334B_1AFE / 0x34FAE)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BP,SP (334B_1AFF / 0x34FAF)
    BP = SP;
    State.IncCycles();
    // MOV SI,BX (334B_1B01 / 0x34FB1)
    SI = BX;
    State.IncCycles();
    // MOV DI,DX (334B_1B03 / 0x34FB3)
    DI = DX;
    State.IncCycles();
    // XOR AX,AX (334B_1B05 / 0x34FB5)
    AX = 0;
    State.IncCycles();
    // CMP DX,BX (334B_1B07 / 0x34FB7)
    Alu.Sub16(DX, BX);
    State.IncCycles();
    // JBE 0x3000:4fc0 (334B_1B09 / 0x34FB9)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_1B10_34FC0;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (334B_1B0B / 0x34FBB)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // JMP 0x3000:4fc9 (334B_1B0E / 0x34FBE)
    goto label_334B_1B19_34FC9;
    State.IncCycles();
    label_334B_1B10_34FC0:
    // OR BX,BX (334B_1B10 / 0x34FC0)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x3000:5026 (334B_1B12 / 0x34FC2)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1B1F_034FCF, 0x35026 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XCHG SI,DI (334B_1B14 / 0x34FC4)
    ushort tmp_334B_1B14 = SI;
    SI = DI;
    DI = tmp_334B_1B14;
    State.IncCycles();
    // MOV word ptr [BP + 0x0],AX (334B_1B16 / 0x34FC6)
    UInt16[SS, BP] = AX;
    State.IncCycles();
    label_334B_1B19_34FC9:
    // MOV AX,DI (334B_1B19 / 0x34FC9)
    AX = DI;
    State.IncCycles();
    // MOV CX,DI (334B_1B1B / 0x34FCB)
    CX = DI;
    State.IncCycles();
    // SHR AX,1 (334B_1B1D / 0x34FCD)
    AX >>= 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1B1F_034FCF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1B1F_034FCF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1B1F_34FCF:
    // ADD AX,SI (334B_1B1F / 0x34FCF)
    AX += SI;
    State.IncCycles();
    // CMP AX,DI (334B_1B21 / 0x34FD1)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JC 0x3000:4fdf (334B_1B23 / 0x34FD3)
    if(CarryFlag) {
      goto label_334B_1B2F_34FDF;
    }
    State.IncCycles();
    // SUB AX,DI (334B_1B25 / 0x34FD5)
    // AX -= DI;
    AX = Alu.Sub16(AX, DI);
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x4] (334B_1B27 / 0x34FD7)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (334B_1B2A / 0x34FDA)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // JMP 0x3000:4fe5 (334B_1B2D / 0x34FDD)
    goto label_334B_1B35_34FE5;
    State.IncCycles();
    label_334B_1B2F_34FDF:
    // MOV DX,word ptr [BP + 0x0] (334B_1B2F / 0x34FDF)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_1B32 / 0x34FE2)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    label_334B_1B35_34FE5:
    // ADD DX,word ptr CS:[0x194] (334B_1B35 / 0x34FE5)
    DX += UInt16[cs2, 0x194];
    State.IncCycles();
    // ADD BX,word ptr CS:[0x196] (334B_1B3A / 0x34FEA)
    // BX += UInt16[cs2, 0x196];
    BX = Alu.Add16(BX, UInt16[cs2, 0x196]);
    State.IncCycles();
    // MOV word ptr CS:[0x194],DX (334B_1B3F / 0x34FEF)
    UInt16[cs2, 0x194] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x196],BX (334B_1B44 / 0x34FF4)
    UInt16[cs2, 0x196] = BX;
    State.IncCycles();
    // PUSH AX (334B_1B49 / 0x34FF9)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DI (334B_1B4A / 0x34FFA)
    Stack.Push(DI);
    State.IncCycles();
    // ROL word ptr CS:[0x19a],1 (334B_1B4B / 0x34FFB)
    UInt16[cs2, 0x19A] = Alu.Rol16(UInt16[cs2, 0x19A], 0x1);
    State.IncCycles();
    // JNC 0x3000:5022 (334B_1B50 / 0x35000)
    if(!CarryFlag) {
      goto label_334B_1B72_35022;
    }
    State.IncCycles();
    // MOV DI,word ptr CS:[0x198] (334B_1B52 / 0x35002)
    DI = UInt16[cs2, 0x198];
    State.IncCycles();
    // CMP DX,word ptr [DI] (334B_1B57 / 0x35007)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JL 0x3000:5022 (334B_1B59 / 0x35009)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x2] (334B_1B5B / 0x3500B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JL 0x3000:5022 (334B_1B5E / 0x3500E)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI + 0x4] (334B_1B60 / 0x35010)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JGE 0x3000:5022 (334B_1B63 / 0x35013)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x6] (334B_1B65 / 0x35015)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // JGE 0x3000:5022 (334B_1B68 / 0x35018)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1B6A / 0x3501A)
    NearCall(cs2, 0x1B6D, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    label_334B_1B6D_3501D:
    // MOV AL,CS:[0x19c] (334B_1B6D / 0x3501D)
    AL = UInt8[cs2, 0x19C];
    State.IncCycles();
    // STOSB ES:DI (334B_1B71 / 0x35021)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_334B_1B72_35022:
    // POP DI (334B_1B72 / 0x35022)
    DI = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_1B73 / 0x35023)
    AX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x3000:4fcf (334B_1B74 / 0x35024)
    if(--CX != 0) {
      goto label_334B_1B1F_34FCF;
    }
    State.IncCycles();
    label_334B_1B76_35026:
    // ADD SP,0x8 (334B_1B76 / 0x35026)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    State.IncCycles();
    // POP SI (334B_1B79 / 0x35029)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_1B7A / 0x3502A)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (334B_1B7B / 0x3502B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_1B7C_03502C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1B7C_3502C:
    // PUSH CX (334B_1B7C / 0x3502C)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_1B7D / 0x3502D)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_1B7E / 0x3502E)
    Stack.Push(DI);
    State.IncCycles();
    // XOR SI,SI (334B_1B7F / 0x3502F)
    SI = 0;
    State.IncCycles();
    // MOV DI,SI (334B_1B81 / 0x35031)
    DI = SI;
    State.IncCycles();
    // MOV CX,0x7d00 (334B_1B83 / 0x35033)
    CX = 0x7D00;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1B86 / 0x35036)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP DI (334B_1B88 / 0x35038)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_1B89 / 0x35039)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_1B8A / 0x3503A)
    CX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1B8B / 0x3503B)
    return FarRet();
  }
  
  public virtual Action not_observed_334B_1B8C_03503C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1B8C_3503C:
    // MOV DS,SI (334B_1B8C / 0x3503C)
    DS = SI;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_1B8E_03503E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1B8E_3503E:
    // CALL 0x3000:40c0 (334B_1B8E / 0x3503E)
    NearCall(cs2, 0x1B91, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    label_334B_1B91_35041:
    // SHR BP,1 (334B_1B91 / 0x35041)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JC 0x3000:5059 (334B_1B93 / 0x35043)
    if(CarryFlag) {
      goto label_334B_1BA9_35059;
    }
    State.IncCycles();
    // JZ 0x3000:506d (334B_1B95 / 0x35045)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1BBD / 0x3506D)
      return FarRet();
    }
    State.IncCycles();
    // MOV DX,DI (334B_1B97 / 0x35047)
    DX = DI;
    State.IncCycles();
    label_334B_1B99_35049:
    // MOV SI,DX (334B_1B99 / 0x35049)
    SI = DX;
    State.IncCycles();
    // MOV DI,SI (334B_1B9B / 0x3504B)
    DI = SI;
    State.IncCycles();
    // MOV CX,BP (334B_1B9D / 0x3504D)
    CX = BP;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1B9F / 0x3504F)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DX,0x140 (334B_1BA1 / 0x35051)
    DX += 0x140;
    State.IncCycles();
    // DEC AX (334B_1BA5 / 0x35055)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:5049 (334B_1BA6 / 0x35056)
    if(!ZeroFlag) {
      goto label_334B_1B99_35049;
    }
    State.IncCycles();
    // RETF  (334B_1BA8 / 0x35058)
    return FarRet();
    State.IncCycles();
    label_334B_1BA9_35059:
    // JZ 0x3000:506e (334B_1BA9 / 0x35059)
    if(ZeroFlag) {
      goto label_334B_1BBE_3506E;
    }
    State.IncCycles();
    // MOV DX,DI (334B_1BAB / 0x3505B)
    DX = DI;
    State.IncCycles();
    label_334B_1BAD_3505D:
    // MOV SI,DX (334B_1BAD / 0x3505D)
    SI = DX;
    State.IncCycles();
    // MOV DI,SI (334B_1BAF / 0x3505F)
    DI = SI;
    State.IncCycles();
    // MOV CX,BP (334B_1BB1 / 0x35061)
    CX = BP;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1BB3 / 0x35063)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOVSB ES:DI,SI (334B_1BB5 / 0x35065)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DX,0x140 (334B_1BB6 / 0x35066)
    DX += 0x140;
    State.IncCycles();
    // DEC AX (334B_1BBA / 0x3506A)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:505d (334B_1BBB / 0x3506B)
    if(!ZeroFlag) {
      goto label_334B_1BAD_3505D;
    }
    State.IncCycles();
    label_334B_1BBD_3506D:
    // RETF  (334B_1BBD / 0x3506D)
    return FarRet();
    State.IncCycles();
    label_334B_1BBE_3506E:
    // MOV CX,AX (334B_1BBE / 0x3506E)
    CX = AX;
    State.IncCycles();
    label_334B_1BC0_35070:
    // MOV SI,DI (334B_1BC0 / 0x35070)
    SI = DI;
    State.IncCycles();
    // MOVSB ES:DI,SI (334B_1BC2 / 0x35072)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DI,0x13f (334B_1BC3 / 0x35073)
    // DI += 0x13F;
    DI = Alu.Add16(DI, 0x13F);
    State.IncCycles();
    // LOOP 0x3000:5070 (334B_1BC7 / 0x35077)
    if(--CX != 0) {
      goto label_334B_1BC0_35070;
    }
    State.IncCycles();
    // RETF  (334B_1BC9 / 0x35079)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1BCA_03507A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1BCA_3507A:
    // MOV BP,DI (334B_1BCA / 0x3507A)
    BP = DI;
    State.IncCycles();
    // AND BP,0x1ff (334B_1BCC / 0x3507C)
    // BP &= 0x1FF;
    BP = Alu.And16(BP, 0x1FF);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1BD0 / 0x35080)
    NearCall(cs2, 0x1BD3, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1BD3_035083, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1BD3_035083(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1BD3_35083:
    // MOV DX,CX (334B_1BD3 / 0x35083)
    DX = CX;
    State.IncCycles();
    // XOR DH,DH (334B_1BD5 / 0x35085)
    DH = 0;
    State.IncCycles();
    label_334B_1BD7_35087:
    // MOV CX,BP (334B_1BD7 / 0x35087)
    CX = BP;
    State.IncCycles();
    // PUSH DI (334B_1BD9 / 0x35089)
    Stack.Push(DI);
    State.IncCycles();
    label_334B_1BDA_3508A:
    // MOVSB ES:DI,SI (334B_1BDA / 0x3508A)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC DI (334B_1BDB / 0x3508B)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:508a (334B_1BDC / 0x3508C)
    if(--CX != 0) {
      goto label_334B_1BDA_3508A;
    }
    State.IncCycles();
    // POP DI (334B_1BDE / 0x3508E)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x280 (334B_1BDF / 0x3508F)
    DI += 0x280;
    State.IncCycles();
    // DEC DX (334B_1BE3 / 0x35093)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:5087 (334B_1BE4 / 0x35094)
    if(!ZeroFlag) {
      goto label_334B_1BD7_35087;
    }
    State.IncCycles();
    // RETF  (334B_1BE6 / 0x35096)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1BE7_035097(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1BE7_35097:
    // PUSH DS (334B_1BE7 / 0x35097)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,SI (334B_1BE8 / 0x35098)
    DS = SI;
    State.IncCycles();
    // XOR SI,SI (334B_1BEA / 0x3509A)
    SI = 0;
    State.IncCycles();
    // MOV DI,SI (334B_1BEC / 0x3509C)
    DI = SI;
    State.IncCycles();
    // MOV CX,0x5f00 (334B_1BEE / 0x3509E)
    CX = 0x5F00;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1BF1 / 0x350A1)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP DS (334B_1BF3 / 0x350A3)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1BF4 / 0x350A4)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1BF5_0350A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1BF5_350A5:
    // CALL 0x3000:40c0 (334B_1BF5 / 0x350A5)
    NearCall(cs2, 0x1BF8, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1BF8_0350A8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1BF8_0350A8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1BF8_350A8:
    // MOV BX,AX (334B_1BF8 / 0x350A8)
    BX = AX;
    State.IncCycles();
    // MOV DX,CX (334B_1BFA / 0x350AA)
    DX = CX;
    State.IncCycles();
    // XOR CX,CX (334B_1BFC / 0x350AC)
    CX = 0;
    State.IncCycles();
    // MOV BP,DI (334B_1BFE / 0x350AE)
    BP = DI;
    State.IncCycles();
    // OR BH,BH (334B_1C00 / 0x350B0)
    // BH |= BH;
    BH = Alu.Or8(BH, BH);
    State.IncCycles();
    // JZ 0x3000:50cf (334B_1C02 / 0x350B2)
    if(ZeroFlag) {
      goto label_334B_1C1F_350CF;
    }
    State.IncCycles();
    label_334B_1C04_350B4:
    // MOV CL,DL (334B_1C04 / 0x350B4)
    CL = DL;
    State.IncCycles();
    // LODSB SI (334B_1C06 / 0x350B6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,AL (334B_1C07 / 0x350B7)
    AH = AL;
    State.IncCycles();
    label_334B_1C09_350B9:
    // MOV AL,BL (334B_1C09 / 0x350B9)
    AL = BL;
    State.IncCycles();
    // SHL AH,1 (334B_1C0B / 0x350BB)
    // AH <<= 0x1;
    AH = Alu.Shl8(AH, 0x1);
    State.IncCycles();
    // JC 0x3000:50c1 (334B_1C0D / 0x350BD)
    if(CarryFlag) {
      goto label_334B_1C11_350C1;
    }
    State.IncCycles();
    // MOV AL,BH (334B_1C0F / 0x350BF)
    AL = BH;
    State.IncCycles();
    label_334B_1C11_350C1:
    // STOSB ES:DI (334B_1C11 / 0x350C1)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:50b9 (334B_1C12 / 0x350C2)
    if(--CX != 0) {
      goto label_334B_1C09_350B9;
    }
    State.IncCycles();
    // ADD BP,0x140 (334B_1C14 / 0x350C4)
    // BP += 0x140;
    BP = Alu.Add16(BP, 0x140);
    State.IncCycles();
    // MOV DI,BP (334B_1C18 / 0x350C8)
    DI = BP;
    State.IncCycles();
    // DEC DH (334B_1C1A / 0x350CA)
    DH = Alu.Dec8(DH);
    State.IncCycles();
    // JNZ 0x3000:50b4 (334B_1C1C / 0x350CC)
    if(!ZeroFlag) {
      goto label_334B_1C04_350B4;
    }
    State.IncCycles();
    // RETF  (334B_1C1E / 0x350CE)
    return FarRet();
    State.IncCycles();
    label_334B_1C1F_350CF:
    // MOV CL,DL (334B_1C1F / 0x350CF)
    CL = DL;
    State.IncCycles();
    // LODSB SI (334B_1C21 / 0x350D1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,AL (334B_1C22 / 0x350D2)
    AH = AL;
    State.IncCycles();
    // MOV AL,BL (334B_1C24 / 0x350D4)
    AL = BL;
    State.IncCycles();
    label_334B_1C26_350D6:
    // SHL AH,1 (334B_1C26 / 0x350D6)
    // AH <<= 0x1;
    AH = Alu.Shl8(AH, 0x1);
    State.IncCycles();
    // JC 0x3000:50e8 (334B_1C28 / 0x350D8)
    if(CarryFlag) {
      goto label_334B_1C38_350E8;
    }
    State.IncCycles();
    // INC DI (334B_1C2A / 0x350DA)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:50d6 (334B_1C2B / 0x350DB)
    if(--CX != 0) {
      goto label_334B_1C26_350D6;
    }
    State.IncCycles();
    // ADD BP,0x140 (334B_1C2D / 0x350DD)
    // BP += 0x140;
    BP = Alu.Add16(BP, 0x140);
    State.IncCycles();
    // MOV DI,BP (334B_1C31 / 0x350E1)
    DI = BP;
    State.IncCycles();
    // DEC DH (334B_1C33 / 0x350E3)
    DH = Alu.Dec8(DH);
    State.IncCycles();
    // JNZ 0x3000:50cf (334B_1C35 / 0x350E5)
    if(!ZeroFlag) {
      goto label_334B_1C1F_350CF;
    }
    State.IncCycles();
    // RETF  (334B_1C37 / 0x350E7)
    return FarRet();
    State.IncCycles();
    label_334B_1C38_350E8:
    // STOSB ES:DI (334B_1C38 / 0x350E8)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:50d6 (334B_1C39 / 0x350E9)
    if(--CX != 0) {
      goto label_334B_1C26_350D6;
    }
    State.IncCycles();
    // ADD BP,0x140 (334B_1C3B / 0x350EB)
    // BP += 0x140;
    BP = Alu.Add16(BP, 0x140);
    State.IncCycles();
    // MOV DI,BP (334B_1C3F / 0x350EF)
    DI = BP;
    State.IncCycles();
    // DEC DH (334B_1C41 / 0x350F1)
    DH = Alu.Dec8(DH);
    State.IncCycles();
    // JNZ 0x3000:50cf (334B_1C43 / 0x350F3)
    if(!ZeroFlag) {
      goto label_334B_1C1F_350CF;
    }
    State.IncCycles();
    // RETF  (334B_1C45 / 0x350F5)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1C46_0350F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1C46_350F6:
    // MOV DX,word ptr [BP + 0x0] (334B_1C46 / 0x350F6)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_1C49 / 0x350F9)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1C4C / 0x350FC)
    NearCall(cs2, 0x1C4F, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1C4F_0350FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1C4F_0350FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1C4F_350FF:
    // MOV CX,word ptr [BP + 0x4] (334B_1C4F / 0x350FF)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x6] (334B_1C52 / 0x35102)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // SUB CX,DX (334B_1C55 / 0x35105)
    CX -= DX;
    State.IncCycles();
    // SUB AX,BX (334B_1C57 / 0x35107)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // XCHG SI,DI (334B_1C59 / 0x35109)
    ushort tmp_334B_1C59 = SI;
    SI = DI;
    DI = tmp_334B_1C59;
    State.IncCycles();
    // MOV DX,0x140 (334B_1C5B / 0x3510B)
    DX = 0x140;
    State.IncCycles();
    // SUB DX,CX (334B_1C5E / 0x3510E)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    State.IncCycles();
    // PUSH DS (334B_1C60 / 0x35110)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_1C61 / 0x35111)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_1C62 / 0x35112)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (334B_1C63 / 0x35113)
    ES = Stack.Pop();
    State.IncCycles();
    label_334B_1C64_35114:
    // PUSH CX (334B_1C64 / 0x35114)
    Stack.Push(CX);
    State.IncCycles();
    // SHR CX,1 (334B_1C65 / 0x35115)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1C67 / 0x35117)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADC CX,CX (334B_1C69 / 0x35119)
    CX = Alu.Adc16(CX, CX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_1C6B / 0x3511B)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP CX (334B_1C6D / 0x3511D)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD SI,DX (334B_1C6E / 0x3511E)
    SI += DX;
    State.IncCycles();
    // DEC AX (334B_1C70 / 0x35120)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:5114 (334B_1C71 / 0x35121)
    if(!ZeroFlag) {
      goto label_334B_1C64_35114;
    }
    State.IncCycles();
    // PUSH SS (334B_1C73 / 0x35123)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (334B_1C74 / 0x35124)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1C75 / 0x35125)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1C76_035126(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1C76_35126:
    // MOV DX,word ptr [BP + 0x0] (334B_1C76 / 0x35126)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_1C79 / 0x35129)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1C7C / 0x3512C)
    NearCall(cs2, 0x1C7F, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1C7F_03512F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1C7F_03512F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1C7F_3512F:
    // MOV CX,word ptr [BP + 0x4] (334B_1C7F / 0x3512F)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x6] (334B_1C82 / 0x35132)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // SUB CX,DX (334B_1C85 / 0x35135)
    CX -= DX;
    State.IncCycles();
    // SUB AX,BX (334B_1C87 / 0x35137)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // MOV DX,0x140 (334B_1C89 / 0x35139)
    DX = 0x140;
    State.IncCycles();
    // SUB DX,CX (334B_1C8C / 0x3513C)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    State.IncCycles();
    label_334B_1C8E_3513E:
    // PUSH CX (334B_1C8E / 0x3513E)
    Stack.Push(CX);
    State.IncCycles();
    // SHR CX,1 (334B_1C8F / 0x3513F)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1C91 / 0x35141)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADC CX,CX (334B_1C93 / 0x35143)
    CX = Alu.Adc16(CX, CX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_1C95 / 0x35145)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP CX (334B_1C97 / 0x35147)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD DI,DX (334B_1C98 / 0x35148)
    DI += DX;
    State.IncCycles();
    // DEC AX (334B_1C9A / 0x3514A)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:513e (334B_1C9B / 0x3514B)
    if(!ZeroFlag) {
      goto label_334B_1C8E_3513E;
    }
    State.IncCycles();
    // PUSH SS (334B_1C9D / 0x3514D)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (334B_1C9E / 0x3514E)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_1C9F / 0x3514F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1CB6_035166(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1CB6_35166:
    // OR AL,AL (334B_1CB6 / 0x35166)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // MOV AX,0x9090 (334B_1CB8 / 0x35168)
    AX = 0x9090;
    State.IncCycles();
    // JZ 0x3000:5170 (334B_1CBB / 0x3516B)
    if(ZeroFlag) {
      goto label_334B_1CC0_35170;
    }
    State.IncCycles();
    // MOV AX,0x7deb (334B_1CBD / 0x3516D)
    AX = 0x7DEB;
    State.IncCycles();
    label_334B_1CC0_35170:
    // MOV CS:[0x1e4a],AX (334B_1CC0 / 0x35170)
    UInt16[cs2, 0x1E4A] = AX;
    State.IncCycles();
    // MOV word ptr CS:[0x1ca0],SI (334B_1CC4 / 0x35174)
    UInt16[cs2, 0x1CA0] = SI;
    State.IncCycles();
    // MOV word ptr CS:[0x1ca2],DS (334B_1CC9 / 0x35179)
    UInt16[cs2, 0x1CA2] = DS;
    State.IncCycles();
    // MOV word ptr CS:[0x1ca4],BP (334B_1CCE / 0x3517E)
    UInt16[cs2, 0x1CA4] = BP;
    State.IncCycles();
    // ADD BP,0x319 (334B_1CD3 / 0x35183)
    // BP += 0x319;
    BP = Alu.Add16(BP, 0x319);
    State.IncCycles();
    // MOV word ptr CS:[0x1ca8],BP (334B_1CD7 / 0x35187)
    UInt16[cs2, 0x1CA8] = BP;
    State.IncCycles();
    // MOV DI,BP (334B_1CDC / 0x3518C)
    DI = BP;
    State.IncCycles();
    // MOV word ptr CS:[0x1ca6],BP (334B_1CDE / 0x3518E)
    UInt16[cs2, 0x1CA6] = BP;
    State.IncCycles();
    // ADD BP,0xcd9 (334B_1CE3 / 0x35193)
    // BP += 0xCD9;
    BP = Alu.Add16(BP, 0xCD9);
    State.IncCycles();
    // MOV word ptr CS:[0x1caa],BP (334B_1CE7 / 0x35197)
    UInt16[cs2, 0x1CAA] = BP;
    State.IncCycles();
    // ADD BP,0x3301 (334B_1CEC / 0x3519C)
    // BP += 0x3301;
    BP = Alu.Add16(BP, 0x3301);
    State.IncCycles();
    // MOV word ptr CS:[0x1cac],BP (334B_1CF0 / 0x351A0)
    UInt16[cs2, 0x1CAC] = BP;
    State.IncCycles();
    // MOV word ptr CS:[0x1cb4],0xfec0 (334B_1CF5 / 0x351A5)
    UInt16[cs2, 0x1CB4] = 0xFEC0;
    State.IncCycles();
    // PUSH CS (334B_1CFC / 0x351AC)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:520a (334B_1CFD / 0x351AD)
    NearCall(cs2, 0x1D00, spice86_generated_label_call_target_334B_1D5A_03520A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1D00_0351B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1D00_0351B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1D00_351B0:
    // PUSH CS (334B_1D00 / 0x351B0)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:51b7 (334B_1D01 / 0x351B1)
    NearCall(cs2, 0x1D04, spice86_generated_label_call_target_334B_1D07_0351B7);
    State.IncCycles();
    label_334B_1D04_351B4:
    // JNC 0x3000:51b0 (334B_1D04 / 0x351B4)
    if(!CarryFlag) {
      goto label_334B_1D00_351B0;
    }
    State.IncCycles();
    // RETF  (334B_1D06 / 0x351B6)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_1D07_0351B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1D07_351B7:
    // MOV DS,word ptr CS:[0x1ca2] (334B_1D07 / 0x351B7)
    DS = UInt16[cs2, 0x1CA2];
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1ca6] (334B_1D0C / 0x351BC)
    DI = UInt16[cs2, 0x1CA6];
    State.IncCycles();
    // MOV AL,byte ptr SS:[DI] (334B_1D11 / 0x351C1)
    AL = UInt8[SS, DI];
    State.IncCycles();
    // XOR AH,AH (334B_1D14 / 0x351C4)
    AH = 0;
    State.IncCycles();
    // INC DI (334B_1D16 / 0x351C6)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // OR AL,AL (334B_1D17 / 0x351C7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x3000:5202 (334B_1D19 / 0x351C9)
    if(!SignFlag) {
      goto label_334B_1D52_35202;
    }
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1ca8] (334B_1D1B / 0x351CB)
    DI = UInt16[cs2, 0x1CA8];
    State.IncCycles();
    // NEG word ptr CS:[0x1cb4] (334B_1D20 / 0x351D0)
    UInt16[cs2, 0x1CB4] = Alu.Sub16(0, UInt16[cs2, 0x1CB4]);
    State.IncCycles();
    // JS 0x3000:520a (334B_1D25 / 0x351D5)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1D5A_03520A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr CS:[0x1ea6],0xfedb (334B_1D27 / 0x351D7)
    UInt16[cs2, 0x1EA6] = 0xFEDB;
    State.IncCycles();
    // MOV word ptr CS:[0x1f29],0xfe58 (334B_1D2E / 0x351DE)
    UInt16[cs2, 0x1F29] = 0xFE58;
    State.IncCycles();
    // MOV AX,0x64a0 (334B_1D35 / 0x351E5)
    AX = 0x64A0;
    State.IncCycles();
    // MOV CS:[0x1cb0],AX (334B_1D38 / 0x351E8)
    UInt16[cs2, 0x1CB0] = AX;
    State.IncCycles();
    // MOV CS:[0x1cb2],AX (334B_1D3C / 0x351EC)
    UInt16[cs2, 0x1CB2] = AX;
    State.IncCycles();
    // DEC AX (334B_1D40 / 0x351F0)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV CS:[0x1cae],AX (334B_1D41 / 0x351F1)
    UInt16[cs2, 0x1CAE] = AX;
    State.IncCycles();
    // MOV AL,byte ptr SS:[DI + -0x1] (334B_1D45 / 0x351F5)
    AL = UInt8[SS, (ushort)(DI - 0x1)];
    State.IncCycles();
    // CBW  (334B_1D49 / 0x351F9)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SUB DI,AX (334B_1D4A / 0x351FA)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // MOV AL,byte ptr SS:[DI] (334B_1D4C / 0x351FC)
    AL = UInt8[SS, DI];
    State.IncCycles();
    // XOR AH,AH (334B_1D4F / 0x351FF)
    AH = 0;
    State.IncCycles();
    // INC DI (334B_1D51 / 0x35201)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    label_334B_1D52_35202:
    // MOV SI,word ptr CS:[0x1caa] (334B_1D52 / 0x35202)
    SI = UInt16[cs2, 0x1CAA];
    State.IncCycles();
    // JMP 0x3000:5355 (334B_1D57 / 0x35207)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // Instruction bytes at index 1 modified by those instruction(s): 351D7, 3520F, 3520A
    // Instruction is modified by code, generator handled: First value group is modified
    // JMP 0x3000:5235 (334B_1EA5 / 0x35355)
    // Indirect jump to 0x3000:5235, generating possible targets from emulator records
    uint targetAddress_334B_1EA5 = (uint)(cs2 * 0x10 + 0x1EA8 + (short)(UInt16[cs2, 0x1EA6]) - cs1 * 0x10);
    switch(targetAddress_334B_1EA5) {
      case 0x25235 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1D85_035235, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x25233 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1D83_035233, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_1EA5));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1D5A_03520A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_1D5A_03520A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1D5A_3520A:
    // MOV word ptr CS:[0x1ca6],DI (334B_1D5A / 0x3520A)
    UInt16[cs2, 0x1CA6] = DI;
    State.IncCycles();
    // MOV word ptr CS:[0x1ea6],0xfedd (334B_1D5F / 0x3520F)
    UInt16[cs2, 0x1EA6] = 0xFEDD;
    State.IncCycles();
    // MOV word ptr CS:[0x1f29],0xfe5a (334B_1D66 / 0x35216)
    UInt16[cs2, 0x1F29] = 0xFE5A;
    State.IncCycles();
    // MOV AX,0x6360 (334B_1D6D / 0x3521D)
    AX = 0x6360;
    State.IncCycles();
    // MOV CS:[0x1cb0],AX (334B_1D70 / 0x35220)
    UInt16[cs2, 0x1CB0] = AX;
    State.IncCycles();
    // MOV CS:[0x1cb2],AX (334B_1D74 / 0x35224)
    UInt16[cs2, 0x1CB2] = AX;
    State.IncCycles();
    // DEC AX (334B_1D78 / 0x35228)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV CS:[0x1cae],AX (334B_1D79 / 0x35229)
    UInt16[cs2, 0x1CAE] = AX;
    State.IncCycles();
    // MOV AX,SS (334B_1D7D / 0x3522D)
    AX = SS;
    State.IncCycles();
    // MOV DS,AX (334B_1D7F / 0x3522F)
    DS = AX;
    State.IncCycles();
    // STC  (334B_1D81 / 0x35231)
    CarryFlag = true;
    State.IncCycles();
    // RETF  (334B_1D82 / 0x35232)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1D83_035233(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1D83_35233:
    // NEG AX (334B_1D83 / 0x35233)
    AX = Alu.Sub16(0, AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1D85_035235, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1D85_035235(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1D85_35235:
    // ADD AX,AX (334B_1D85 / 0x35235)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x1cac] (334B_1D87 / 0x35237)
    BP = UInt16[cs2, 0x1CAC];
    State.IncCycles();
    // ADD BP,AX (334B_1D8C / 0x3523C)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_1D8E / 0x3523E)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // OR AX,AX (334B_1D91 / 0x35241)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x3000:5293 (334B_1D93 / 0x35243)
    if(SignFlag) {
      throw FailAsUntested("Would have been a goto but label label_334B_1DE3_35293 does not exist because no instruction was found there that belongs to a function.");
    }
    State.IncCycles();
    // CBW  (334B_1D95 / 0x35245)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // OR AX,AX (334B_1D96 / 0x35246)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x3000:5272 (334B_1D98 / 0x35248)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1DC2_035272, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // NEG AX (334B_1D9A / 0x3524A)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // MOV BP,AX (334B_1D9C / 0x3524C)
    BP = AX;
    State.IncCycles();
    // MOV BL,byte ptr [BP + SI] (334B_1D9E / 0x3524E)
    BL = UInt8[SS, (ushort)(BP + SI)];
    State.IncCycles();
    // MOV AL,byte ptr [BP + SI + 0x64] (334B_1DA0 / 0x35250)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    State.IncCycles();
    // XOR AH,AH (334B_1DA3 / 0x35253)
    AH = 0;
    State.IncCycles();
    // MOV BH,AH (334B_1DA5 / 0x35255)
    BH = AH;
    State.IncCycles();
    // SHL BX,1 (334B_1DA7 / 0x35257)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (334B_1DA9 / 0x35259)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x1ca4] (334B_1DAB / 0x3525B)
    BP = UInt16[cs2, 0x1CA4];
    State.IncCycles();
    // ADD BP,BX (334B_1DB0 / 0x35260)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_1DB2 / 0x35262)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x2] (334B_1DB5 / 0x35265)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x4] (334B_1DB8 / 0x35268)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // NEG AX (334B_1DBB / 0x3526B)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // ADD AX,CX (334B_1DBD / 0x3526D)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // JMP 0x3000:52e2 (334B_1DBF / 0x3526F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_1E32_0352E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1DC2_035272(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1DC2_35272:
    // MOV BP,AX (334B_1DC2 / 0x35272)
    BP = AX;
    State.IncCycles();
    // MOV BL,byte ptr [BP + SI] (334B_1DC4 / 0x35274)
    BL = UInt8[SS, (ushort)(BP + SI)];
    State.IncCycles();
    // MOV AL,byte ptr [BP + SI + 0x64] (334B_1DC6 / 0x35276)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    State.IncCycles();
    // XOR AH,AH (334B_1DC9 / 0x35279)
    AH = 0;
    State.IncCycles();
    // MOV BH,AH (334B_1DCB / 0x3527B)
    BH = AH;
    State.IncCycles();
    // SHL BX,1 (334B_1DCD / 0x3527D)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (334B_1DCF / 0x3527F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x1ca4] (334B_1DD1 / 0x35281)
    BP = UInt16[cs2, 0x1CA4];
    State.IncCycles();
    // ADD BP,BX (334B_1DD6 / 0x35286)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_1DD8 / 0x35288)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x2] (334B_1DDB / 0x3528B)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x4] (334B_1DDE / 0x3528E)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // JMP 0x3000:52e2 (334B_1DE1 / 0x35291)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_1E32_0352E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_1E32_0352E2(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25355: goto label_334B_1EA5_35355;break; // Target of external jump from 0x35207
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_1E32_352E2:
    // ADD CX,CX (334B_1E32 / 0x352E2)
    // CX += CX;
    CX = Alu.Add16(CX, CX);
    State.IncCycles();
    // MOV BP,DX (334B_1E34 / 0x352E4)
    BP = DX;
    State.IncCycles();
    // SUB BP,AX (334B_1E36 / 0x352E6)
    // BP -= AX;
    BP = Alu.Sub16(BP, AX);
    State.IncCycles();
    // JNS 0x3000:52ec (334B_1E38 / 0x352E8)
    if(!SignFlag) {
      goto label_334B_1E3C_352EC;
    }
    State.IncCycles();
    // ADD BP,CX (334B_1E3A / 0x352EA)
    BP += CX;
    State.IncCycles();
    label_334B_1E3C_352EC:
    // ADD BP,BX (334B_1E3C / 0x352EC)
    BP += BX;
    State.IncCycles();
    // ADD DX,AX (334B_1E3E / 0x352EE)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // PUSH SI (334B_1E40 / 0x352F0)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_1E41 / 0x352F1)
    Stack.Push(DI);
    State.IncCycles();
    // MOV SI,word ptr CS:[0x1ca0] (334B_1E42 / 0x352F2)
    SI = UInt16[cs2, 0x1CA0];
    State.IncCycles();
    // MOV AL,byte ptr DS:[BP + SI] (334B_1E47 / 0x352F7)
    AL = UInt8[DS, (ushort)(BP + SI)];
    State.IncCycles();
    // NOP  (334B_1E4A / 0x352FA)
    
    State.IncCycles();
    // NOP  (334B_1E4B / 0x352FB)
    
    State.IncCycles();
    // MOV AH,AL (334B_1E4C / 0x352FC)
    AH = AL;
    State.IncCycles();
    // AND AX,0x300f (334B_1E4E / 0x352FE)
    AX &= 0x300F;
    State.IncCycles();
    // CMP AH,0x10 (334B_1E51 / 0x35301)
    Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JNZ 0x3000:530c (334B_1E54 / 0x35304)
    if(!ZeroFlag) {
      goto label_334B_1E5C_3530C;
    }
    State.IncCycles();
    // CMP AL,0x8 (334B_1E56 / 0x35306)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNC 0x3000:530c (334B_1E58 / 0x35308)
    if(!CarryFlag) {
      goto label_334B_1E5C_3530C;
    }
    State.IncCycles();
    // ADD AL,0xc (334B_1E5A / 0x3530A)
    AL += 0xC;
    State.IncCycles();
    label_334B_1E5C_3530C:
    // ADD AL,0x10 (334B_1E5C / 0x3530C)
    // AL += 0x10;
    AL = Alu.Add8(AL, 0x10);
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1cae] (334B_1E5E / 0x3530E)
    DI = UInt16[cs2, 0x1CAE];
    State.IncCycles();
    // STD  (334B_1E63 / 0x35313)
    DirectionFlag = true;
    State.IncCycles();
    // STOSB ES:DI (334B_1E64 / 0x35314)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CLD  (334B_1E65 / 0x35315)
    DirectionFlag = false;
    State.IncCycles();
    // MOV word ptr CS:[0x1cae],DI (334B_1E66 / 0x35316)
    UInt16[cs2, 0x1CAE] = DI;
    State.IncCycles();
    // MOV BP,DX (334B_1E6B / 0x3531B)
    BP = DX;
    State.IncCycles();
    // SUB BP,CX (334B_1E6D / 0x3531D)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNS 0x3000:5323 (334B_1E6F / 0x3531F)
    if(!SignFlag) {
      goto label_334B_1E73_35323;
    }
    State.IncCycles();
    // ADD BP,CX (334B_1E71 / 0x35321)
    BP += CX;
    State.IncCycles();
    label_334B_1E73_35323:
    // ADD BP,BX (334B_1E73 / 0x35323)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    State.IncCycles();
    // MOV AL,byte ptr DS:[BP + SI] (334B_1E75 / 0x35325)
    AL = UInt8[DS, (ushort)(BP + SI)];
    State.IncCycles();
    // MOV AH,AL (334B_1E78 / 0x35328)
    AH = AL;
    State.IncCycles();
    // AND AX,0x300f (334B_1E7A / 0x3532A)
    AX &= 0x300F;
    State.IncCycles();
    // CMP AH,0x10 (334B_1E7D / 0x3532D)
    Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JNZ 0x3000:5338 (334B_1E80 / 0x35330)
    if(!ZeroFlag) {
      goto label_334B_1E88_35338;
    }
    State.IncCycles();
    // CMP AL,0x8 (334B_1E82 / 0x35332)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNC 0x3000:5338 (334B_1E84 / 0x35334)
    if(!CarryFlag) {
      goto label_334B_1E88_35338;
    }
    State.IncCycles();
    // ADD AL,0xc (334B_1E86 / 0x35336)
    AL += 0xC;
    State.IncCycles();
    label_334B_1E88_35338:
    // ADD AL,0x10 (334B_1E88 / 0x35338)
    // AL += 0x10;
    AL = Alu.Add8(AL, 0x10);
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1cb0] (334B_1E8A / 0x3533A)
    DI = UInt16[cs2, 0x1CB0];
    State.IncCycles();
    // STOSB ES:DI (334B_1E8F / 0x3533F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV word ptr CS:[0x1cb0],DI (334B_1E90 / 0x35340)
    UInt16[cs2, 0x1CB0] = DI;
    State.IncCycles();
    // POP DI (334B_1E95 / 0x35345)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_1E96 / 0x35346)
    SI = Stack.Pop();
    State.IncCycles();
    // ADD SI,0xc8 (334B_1E97 / 0x35347)
    // SI += 0xC8;
    SI = Alu.Add16(SI, 0xC8);
    State.IncCycles();
    // MOV AL,byte ptr SS:[DI] (334B_1E9B / 0x3534B)
    AL = UInt8[SS, DI];
    State.IncCycles();
    // XOR AH,AH (334B_1E9E / 0x3534E)
    AH = 0;
    State.IncCycles();
    // INC DI (334B_1EA0 / 0x35350)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // OR AL,AL (334B_1EA1 / 0x35351)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:5358 (334B_1EA3 / 0x35353)
    if(SignFlag) {
      goto label_334B_1EA8_35358;
    }
    State.IncCycles();
    label_334B_1EA5_35355:
    // Instruction bytes at index 1 modified by those instruction(s): 351D7, 3520F, 3520A
    // Instruction is modified by code, generator handled: First value group is modified
    // JMP 0x3000:5235 (334B_1EA5 / 0x35355)
    // Indirect jump to 0x3000:5235, generating possible targets from emulator records
    uint targetAddress_334B_1EA5 = (uint)(cs2 * 0x10 + 0x1EA8 + (short)(UInt16[cs2, 0x1EA6]) - cs1 * 0x10);
    switch(targetAddress_334B_1EA5) {
      case 0x25235 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1D85_035235, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x25233 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1D83_035233, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_1EA5));
        break;
    }
    State.IncCycles();
    label_334B_1EA8_35358:
    // MOV word ptr CS:[0x1ca6],DI (334B_1EA8 / 0x35358)
    UInt16[cs2, 0x1CA6] = DI;
    State.IncCycles();
    // MOV AX,CS:[0x1cb4] (334B_1EAD / 0x3535D)
    AX = UInt16[cs2, 0x1CB4];
    State.IncCycles();
    // ADD AX,word ptr CS:[0x1cb2] (334B_1EB1 / 0x35361)
    // AX += UInt16[cs2, 0x1CB2];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1CB2]);
    State.IncCycles();
    // MOV CS:[0x1cb2],AX (334B_1EB6 / 0x35366)
    UInt16[cs2, 0x1CB2] = AX;
    State.IncCycles();
    // MOV CS:[0x1cb0],AX (334B_1EBA / 0x3536A)
    UInt16[cs2, 0x1CB0] = AX;
    State.IncCycles();
    // DEC AX (334B_1EBE / 0x3536E)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV CS:[0x1cae],AX (334B_1EBF / 0x3536F)
    UInt16[cs2, 0x1CAE] = AX;
    State.IncCycles();
    // CLC  (334B_1EC3 / 0x35373)
    CarryFlag = false;
    State.IncCycles();
    // MOV AX,SS (334B_1EC4 / 0x35374)
    AX = SS;
    State.IncCycles();
    // MOV DS,AX (334B_1EC6 / 0x35376)
    DS = AX;
    State.IncCycles();
    // RETF  (334B_1EC8 / 0x35378)
    return FarRet();
    State.IncCycles();
    label_334B_1EC9_35379:
    // MOV AH,AL (334B_1EC9 / 0x35379)
    AH = AL;
    State.IncCycles();
    // AND AX,0x300f (334B_1ECB / 0x3537B)
    // AX &= 0x300F;
    AX = Alu.And16(AX, 0x300F);
    State.IncCycles();
    // OR AL,0x10 (334B_1ECE / 0x3537E)
    AL |= 0x10;
    State.IncCycles();
    // SUB AH,0x10 (334B_1ED0 / 0x35380)
    // AH -= 0x10;
    AH = Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JC 0x3000:538e (334B_1ED3 / 0x35383)
    if(CarryFlag) {
      goto label_334B_1EDE_3538E;
    }
    State.IncCycles();
    // SHR AH,1 (334B_1ED5 / 0x35385)
    AH >>= 0x1;
    State.IncCycles();
    // AND AH,0x10 (334B_1ED7 / 0x35387)
    AH &= 0x10;
    State.IncCycles();
    // ADD AL,0x10 (334B_1EDA / 0x3538A)
    AL += 0x10;
    State.IncCycles();
    // ADD AL,AH (334B_1EDC / 0x3538C)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    label_334B_1EDE_3538E:
    // MOV DI,word ptr CS:[0x1cae] (334B_1EDE / 0x3538E)
    DI = UInt16[cs2, 0x1CAE];
    State.IncCycles();
    // STD  (334B_1EE3 / 0x35393)
    DirectionFlag = true;
    State.IncCycles();
    // STOSB ES:DI (334B_1EE4 / 0x35394)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CLD  (334B_1EE5 / 0x35395)
    DirectionFlag = false;
    State.IncCycles();
    // MOV word ptr CS:[0x1cae],DI (334B_1EE6 / 0x35396)
    UInt16[cs2, 0x1CAE] = DI;
    State.IncCycles();
    // MOV BP,DX (334B_1EEB / 0x3539B)
    BP = DX;
    State.IncCycles();
    // SUB BP,CX (334B_1EED / 0x3539D)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNS 0x3000:53a3 (334B_1EEF / 0x3539F)
    if(!SignFlag) {
      goto label_334B_1EF3_353A3;
    }
    State.IncCycles();
    // ADD BP,CX (334B_1EF1 / 0x353A1)
    BP += CX;
    State.IncCycles();
    label_334B_1EF3_353A3:
    // ADD BP,BX (334B_1EF3 / 0x353A3)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    State.IncCycles();
    // MOV AL,byte ptr DS:[BP + SI] (334B_1EF5 / 0x353A5)
    AL = UInt8[DS, (ushort)(BP + SI)];
    State.IncCycles();
    // MOV AH,AL (334B_1EF8 / 0x353A8)
    AH = AL;
    State.IncCycles();
    // AND AX,0x300f (334B_1EFA / 0x353AA)
    // AX &= 0x300F;
    AX = Alu.And16(AX, 0x300F);
    State.IncCycles();
    // OR AL,0x10 (334B_1EFD / 0x353AD)
    AL |= 0x10;
    State.IncCycles();
    // SUB AH,0x10 (334B_1EFF / 0x353AF)
    // AH -= 0x10;
    AH = Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JC 0x3000:53bd (334B_1F02 / 0x353B2)
    if(CarryFlag) {
      goto label_334B_1F0D_353BD;
    }
    State.IncCycles();
    // SHR AH,1 (334B_1F04 / 0x353B4)
    AH >>= 0x1;
    State.IncCycles();
    // AND AH,0x10 (334B_1F06 / 0x353B6)
    AH &= 0x10;
    State.IncCycles();
    // ADD AL,0x10 (334B_1F09 / 0x353B9)
    AL += 0x10;
    State.IncCycles();
    // ADD AL,AH (334B_1F0B / 0x353BB)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    label_334B_1F0D_353BD:
    // MOV DI,word ptr CS:[0x1cb0] (334B_1F0D / 0x353BD)
    DI = UInt16[cs2, 0x1CB0];
    State.IncCycles();
    // STOSB ES:DI (334B_1F12 / 0x353C2)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV word ptr CS:[0x1cb0],DI (334B_1F13 / 0x353C3)
    UInt16[cs2, 0x1CB0] = DI;
    State.IncCycles();
    // POP DI (334B_1F18 / 0x353C8)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_1F19 / 0x353C9)
    SI = Stack.Pop();
    State.IncCycles();
    // ADD SI,0xc8 (334B_1F1A / 0x353CA)
    // SI += 0xC8;
    SI = Alu.Add16(SI, 0xC8);
    State.IncCycles();
    // MOV AL,byte ptr SS:[DI] (334B_1F1E / 0x353CE)
    AL = UInt8[SS, DI];
    State.IncCycles();
    // XOR AH,AH (334B_1F21 / 0x353D1)
    AH = 0;
    State.IncCycles();
    // INC DI (334B_1F23 / 0x353D3)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // OR AL,AL (334B_1F24 / 0x353D4)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:53db (334B_1F26 / 0x353D6)
    if(SignFlag) {
      goto label_334B_1F2B_353DB;
    }
    State.IncCycles();
    // JMP 0x3000:5235 (334B_1F28 / 0x353D8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1D85_035235, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1F2B_353DB:
    // MOV word ptr CS:[0x1ca6],DI (334B_1F2B / 0x353DB)
    UInt16[cs2, 0x1CA6] = DI;
    State.IncCycles();
    // MOV AX,CS:[0x1cb4] (334B_1F30 / 0x353E0)
    AX = UInt16[cs2, 0x1CB4];
    State.IncCycles();
    // ADD AX,word ptr CS:[0x1cb2] (334B_1F34 / 0x353E4)
    // AX += UInt16[cs2, 0x1CB2];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1CB2]);
    State.IncCycles();
    // MOV CS:[0x1cb2],AX (334B_1F39 / 0x353E9)
    UInt16[cs2, 0x1CB2] = AX;
    State.IncCycles();
    // MOV CS:[0x1cb0],AX (334B_1F3D / 0x353ED)
    UInt16[cs2, 0x1CB0] = AX;
    State.IncCycles();
    // DEC AX (334B_1F41 / 0x353F1)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV CS:[0x1cae],AX (334B_1F42 / 0x353F2)
    UInt16[cs2, 0x1CAE] = AX;
    State.IncCycles();
    // CLC  (334B_1F46 / 0x353F6)
    CarryFlag = false;
    State.IncCycles();
    // MOV AX,SS (334B_1F47 / 0x353F7)
    AX = SS;
    State.IncCycles();
    // MOV DS,AX (334B_1F49 / 0x353F9)
    DS = AX;
    State.IncCycles();
    // RETF  (334B_1F4B / 0x353FB)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1F4C_0353FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1F4C_353FC:
    // MOV word ptr CS:[0x1a7],DI (334B_1F4C / 0x353FC)
    UInt16[cs2, 0x1A7] = DI;
    State.IncCycles();
    // MOV word ptr CS:[0x1a9],ES (334B_1F51 / 0x35401)
    UInt16[cs2, 0x1A9] = ES;
    State.IncCycles();
    // MOV word ptr CS:[0x1bb],BP (334B_1F56 / 0x35406)
    UInt16[cs2, 0x1BB] = BP;
    State.IncCycles();
    // MOV word ptr CS:[0x1a5],SI (334B_1F5B / 0x3540B)
    UInt16[cs2, 0x1A5] = SI;
    State.IncCycles();
    // MOV word ptr CS:[0x1b7],0x24 (334B_1F60 / 0x35410)
    UInt16[cs2, 0x1B7] = 0x24;
    State.IncCycles();
    // MOV word ptr CS:[0x1ab],BX (334B_1F67 / 0x35417)
    UInt16[cs2, 0x1AB] = BX;
    State.IncCycles();
    // MOV word ptr CS:[0x1cb2],0x504 (334B_1F6C / 0x3541C)
    UInt16[cs2, 0x1CB2] = 0x504;
    State.IncCycles();
    // SHL AX,1 (334B_1F73 / 0x35423)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_1F75 / 0x35425)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_1F77 / 0x35427)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JNS 0x3000:5493 (334B_1F79 / 0x35429)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1FE3_035493, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // NEG AX (334B_1F7B / 0x3542B)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // ADD BP,AX (334B_1F7D / 0x3542D)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (334B_1F7F / 0x3542F)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_1F82 / 0x35432)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // NEG CX (334B_1F85 / 0x35435)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_1F87 / 0x35437)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // MOV word ptr CS:[0x1b9],0x8f7 (334B_1F8C / 0x3543C)
    UInt16[cs2, 0x1B9] = 0x8F7;
    State.IncCycles();
    // ADD word ptr CS:[0x1bb],0x2b0 (334B_1F93 / 0x35443)
    UInt16[cs2, 0x1BB] += 0x2B0;
    State.IncCycles();
    // ADD DI,0x8c (334B_1F9A / 0x3544A)
    // DI += 0x8C;
    DI = Alu.Add16(DI, 0x8C);
    State.IncCycles();
    // CALL 0x3000:54d5 (334B_1F9E / 0x3544E)
    NearCall(cs2, 0x1FA1, spice86_generated_label_call_target_334B_2025_0354D5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1FA1_035451, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1FA1_035451(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1FA1_35451:
    // SUB BP,0x8 (334B_1FA1 / 0x35451)
    // BP -= 0x8;
    BP = Alu.Sub16(BP, 0x8);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (334B_1FA4 / 0x35454)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_1FA7 / 0x35457)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // NEG CX (334B_1FAA / 0x3545A)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // JZ 0x3000:5475 (334B_1FAC / 0x3545C)
    if(ZeroFlag) {
      goto label_334B_1FC5_35475;
    }
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_1FAE / 0x3545E)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD DI,0x6cc (334B_1FB3 / 0x35463)
    // DI += 0x6CC;
    DI = Alu.Add16(DI, 0x6CC);
    State.IncCycles();
    // CALL 0x3000:54d5 (334B_1FB7 / 0x35467)
    NearCall(cs2, 0x1FBA, spice86_generated_label_call_target_334B_2025_0354D5);
    State.IncCycles();
    label_334B_1FBA_3546A:
    // CALL 0x3000:55d3 (334B_1FBA / 0x3546A)
    NearCall(cs2, 0x1FBD, spice86_generated_label_call_target_334B_2123_0355D3);
    State.IncCycles();
    label_334B_1FBD_3546D:
    // DEC word ptr CS:[0x1b7] (334B_1FBD / 0x3546D)
    UInt16[cs2, 0x1B7] = Alu.Dec16(UInt16[cs2, 0x1B7]);
    State.IncCycles();
    // JNZ 0x3000:5451 (334B_1FC2 / 0x35472)
    if(!ZeroFlag) {
      goto label_334B_1FA1_35451;
    }
    State.IncCycles();
    // RETF  (334B_1FC4 / 0x35474)
    return FarRet();
    State.IncCycles();
    label_334B_1FC5_35475:
    // MOV DI,word ptr CS:[0x1a5] (334B_1FC5 / 0x35475)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // MOV word ptr CS:[0x1b9],0x92f (334B_1FCA / 0x3547A)
    UInt16[cs2, 0x1B9] = 0x92F;
    State.IncCycles();
    // ADD word ptr CS:[0x1bb],0x8 (334B_1FD1 / 0x35481)
    UInt16[cs2, 0x1BB] += 0x8;
    State.IncCycles();
    // ADD DI,0x6cc (334B_1FD7 / 0x35487)
    // DI += 0x6CC;
    DI = Alu.Add16(DI, 0x6CC);
    State.IncCycles();
    // CALL 0x3000:54d5 (334B_1FDB / 0x3548B)
    NearCall(cs2, 0x1FDE, spice86_generated_label_call_target_334B_2025_0354D5);
    State.IncCycles();
    label_334B_1FDE_3548E:
    // CALL 0x3000:55d3 (334B_1FDE / 0x3548E)
    NearCall(cs2, 0x1FE1, spice86_generated_label_call_target_334B_2123_0355D3);
    State.IncCycles();
    label_334B_1FE1_35491:
    // JMP 0x3000:54cd (334B_1FE1 / 0x35491)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_2025_0354D5, 0x354CD - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1FE3_035493(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1FE3_35493:
    // ADD BP,AX (334B_1FE3 / 0x35493)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (334B_1FE5 / 0x35495)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_1FE8 / 0x35498)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_1FEB / 0x3549B)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // MOV word ptr CS:[0x1b9],0x92f (334B_1FF0 / 0x354A0)
    UInt16[cs2, 0x1B9] = 0x92F;
    State.IncCycles();
    // ADD word ptr CS:[0x1bb],0x2b8 (334B_1FF7 / 0x354A7)
    UInt16[cs2, 0x1BB] += 0x2B8;
    State.IncCycles();
    // ADD DI,0x8c (334B_1FFE / 0x354AE)
    // DI += 0x8C;
    DI = Alu.Add16(DI, 0x8C);
    State.IncCycles();
    // CALL 0x3000:54d5 (334B_2002 / 0x354B2)
    NearCall(cs2, 0x2005, spice86_generated_label_call_target_334B_2025_0354D5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2005_0354B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2005_0354B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2005_354B5:
    // ADD BP,0x8 (334B_2005 / 0x354B5)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (334B_2008 / 0x354B8)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_200B / 0x354BB)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_200E / 0x354BE)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD DI,0x6cc (334B_2013 / 0x354C3)
    // DI += 0x6CC;
    DI = Alu.Add16(DI, 0x6CC);
    State.IncCycles();
    // CALL 0x3000:54d5 (334B_2017 / 0x354C7)
    NearCall(cs2, 0x201A, spice86_generated_label_call_target_334B_2025_0354D5);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_2025_0354D5, 0x354CA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2025_0354D5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x254CD: goto label_334B_201D_354CD;break; // Target of external jump from 0x35491
      case 0x254CA: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_201A_354CA:
    // CALL 0x3000:5603 (334B_201A / 0x354CA)
    NearCall(cs2, 0x201D, spice86_generated_label_call_target_334B_2153_035603);
    State.IncCycles();
    label_334B_201D_354CD:
    // DEC word ptr CS:[0x1b7] (334B_201D / 0x354CD)
    UInt16[cs2, 0x1B7] = Alu.Dec16(UInt16[cs2, 0x1B7]);
    State.IncCycles();
    // JNZ 0x3000:54b5 (334B_2022 / 0x354D2)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2005_0354B5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RETF  (334B_2024 / 0x354D4)
    return FarRet();
    entry:
    State.IncCycles();
    label_334B_2025_354D5:
    // PUSH DX (334B_2025 / 0x354D5)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DS (334B_2026 / 0x354D6)
    Stack.Push(DS);
    State.IncCycles();
    // LDS SI,CS:[0x1a7] (334B_2027 / 0x354D7)
    DS = UInt16[cs2, 0x1A9];
    SI = UInt16[cs2, 0x1A7];
    State.IncCycles();
    // MOV AX,SS (334B_202C / 0x354DC)
    AX = SS;
    State.IncCycles();
    // MOV ES,AX (334B_202E / 0x354DE)
    ES = AX;
    State.IncCycles();
    // ADD SI,CX (334B_2030 / 0x354E0)
    SI += CX;
    State.IncCycles();
    // ADD BX,BX (334B_2032 / 0x354E2)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    State.IncCycles();
    // MOV AX,DX (334B_2034 / 0x354E4)
    AX = DX;
    State.IncCycles();
    // MUL BX (334B_2036 / 0x354E6)
    Cpu.Mul16(BX);
    State.IncCycles();
    // MOV word ptr [BP + 0x4],DX (334B_2038 / 0x354E8)
    UInt16[SS, (ushort)(BP + 0x4)] = DX;
    State.IncCycles();
    // ROL AX,1 (334B_203B / 0x354EB)
    AX = Alu.Rol16(AX, 0x1);
    State.IncCycles();
    // ROL AX,1 (334B_203D / 0x354ED)
    AX = Alu.Rol16(AX, 0x1);
    State.IncCycles();
    // AND AX,0x3 (334B_203F / 0x354EF)
    AX &= 0x3;
    State.IncCycles();
    // SUB DI,AX (334B_2042 / 0x354F2)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // MOV AX,DX (334B_2044 / 0x354F4)
    AX = DX;
    State.IncCycles();
    // MOV CX,0x58 (334B_2046 / 0x354F6)
    CX = 0x58;
    State.IncCycles();
    // CMP BX,CX (334B_2049 / 0x354F9)
    Alu.Sub16(BX, CX);
    State.IncCycles();
    // JNC 0x3000:5529 (334B_204B / 0x354FB)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2079_035529, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // SUB CX,BX (334B_204D / 0x354FD)
    CX -= BX;
    State.IncCycles();
    // SHL CX,1 (334B_204F / 0x354FF)
    CX <<= 0x1;
    State.IncCycles();
    // ADD DI,CX (334B_2051 / 0x35501)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // MOV CX,BX (334B_2053 / 0x35503)
    CX = BX;
    State.IncCycles();
    // SHR CX,1 (334B_2055 / 0x35505)
    CX >>= 0x1;
    State.IncCycles();
    // SUB AX,CX (334B_2057 / 0x35507)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // JNS 0x3000:550d (334B_2059 / 0x35509)
    if(!SignFlag) {
      goto label_334B_205D_3550D;
    }
    State.IncCycles();
    // ADD AX,BX (334B_205B / 0x3550B)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    State.IncCycles();
    label_334B_205D_3550D:
    // MOV CX,BX (334B_205D / 0x3550D)
    CX = BX;
    State.IncCycles();
    // SUB BX,AX (334B_205F / 0x3550F)
    BX -= AX;
    State.IncCycles();
    // INC CX (334B_2061 / 0x35511)
    CX++;
    State.IncCycles();
    // SUB CX,BX (334B_2062 / 0x35512)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    State.IncCycles();
    // JNS 0x3000:554e (334B_2064 / 0x35514)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_209E_03554E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD CX,BX (334B_2066 / 0x35516)
    CX += BX;
    State.IncCycles();
    // ADD SI,AX (334B_2068 / 0x35518)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (334B_206A / 0x3551A)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // STC  (334B_206D / 0x3551D)
    CarryFlag = true;
    State.IncCycles();
    // ADC AL,AL (334B_206E / 0x3551E)
    AL = Alu.Adc8(AL, AL);
    State.IncCycles();
    // ADD AL,AL (334B_2070 / 0x35520)
    AL += AL;
    State.IncCycles();
    // SHL AL,1 (334B_2072 / 0x35522)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (334B_2074 / 0x35524)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JMP 0x3000:559b (334B_2076 / 0x35526)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_209E_03554E, 0x3559B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2079_035529(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2079_35529:
    // SHR CX,1 (334B_2079 / 0x35529)
    CX >>= 0x1;
    State.IncCycles();
    // SUB AX,CX (334B_207B / 0x3552B)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // JNS 0x3000:5531 (334B_207D / 0x3552D)
    if(!SignFlag) {
      goto label_334B_2081_35531;
    }
    State.IncCycles();
    // ADD AX,BX (334B_207F / 0x3552F)
    AX += BX;
    State.IncCycles();
    label_334B_2081_35531:
    // SUB BX,AX (334B_2081 / 0x35531)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // MOV CX,0x58 (334B_2083 / 0x35533)
    CX = 0x58;
    State.IncCycles();
    // INC CX (334B_2086 / 0x35536)
    CX++;
    State.IncCycles();
    // SUB CX,BX (334B_2087 / 0x35537)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    State.IncCycles();
    // JNS 0x3000:554e (334B_2089 / 0x35539)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_209E_03554E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD CX,BX (334B_208B / 0x3553B)
    CX += BX;
    State.IncCycles();
    // ADD SI,AX (334B_208D / 0x3553D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (334B_208F / 0x3553F)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // STC  (334B_2092 / 0x35542)
    CarryFlag = true;
    State.IncCycles();
    // ADC AL,AL (334B_2093 / 0x35543)
    AL = Alu.Adc8(AL, AL);
    State.IncCycles();
    // ADD AL,AL (334B_2095 / 0x35545)
    AL += AL;
    State.IncCycles();
    // SHL AL,1 (334B_2097 / 0x35547)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (334B_2099 / 0x35549)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JMP 0x3000:559b (334B_209B / 0x3554B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_209E_03554E, 0x3559B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_209E_03554E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x2559B: goto label_334B_20EB_3559B;break; // Target of external jump from 0x3554B, 0x3558E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_209E_3554E:
    // OR BX,BX (334B_209E / 0x3554E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x3000:559b (334B_20A0 / 0x35550)
    if(ZeroFlag) {
      goto label_334B_20EB_3559B;
    }
    State.IncCycles();
    // XCHG BX,CX (334B_20A2 / 0x35552)
    ushort tmp_334B_20A2 = BX;
    BX = CX;
    CX = tmp_334B_20A2;
    State.IncCycles();
    // PUSH SI (334B_20A4 / 0x35554)
    Stack.Push(SI);
    State.IncCycles();
    // ADD SI,AX (334B_20A5 / 0x35555)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (334B_20A7 / 0x35557)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // STC  (334B_20AA / 0x3555A)
    CarryFlag = true;
    State.IncCycles();
    // ADC AL,AL (334B_20AB / 0x3555B)
    AL = Alu.Adc8(AL, AL);
    State.IncCycles();
    // ADD AL,AL (334B_20AD / 0x3555D)
    AL += AL;
    State.IncCycles();
    // SHL AL,1 (334B_20AF / 0x3555F)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (334B_20B1 / 0x35561)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    label_334B_20B3_35563:
    // MOV DH,byte ptr [SI] (334B_20B3 / 0x35563)
    DH = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_20B5 / 0x35565)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // STC  (334B_20B6 / 0x35566)
    CarryFlag = true;
    State.IncCycles();
    // ADC DH,DH (334B_20B7 / 0x35567)
    DH = Alu.Adc8(DH, DH);
    State.IncCycles();
    // ADD DH,DH (334B_20B9 / 0x35569)
    DH += DH;
    State.IncCycles();
    // SHL DH,1 (334B_20BB / 0x3556B)
    DH <<= 0x1;
    State.IncCycles();
    // SHL DH,1 (334B_20BD / 0x3556D)
    // DH <<= 0x1;
    DH = Alu.Shl8(DH, 0x1);
    State.IncCycles();
    // MOV DL,DH (334B_20BF / 0x3556F)
    DL = DH;
    State.IncCycles();
    // SUB DL,AL (334B_20C1 / 0x35571)
    DL -= AL;
    State.IncCycles();
    // SAR DL,1 (334B_20C3 / 0x35573)
    DL = Alu.Sar8(DL, 0x1);
    State.IncCycles();
    // SAR DL,1 (334B_20C5 / 0x35575)
    DL = Alu.Sar8(DL, 0x1);
    State.IncCycles();
    // OR DL,DL (334B_20C7 / 0x35577)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x3000:5590 (334B_20C9 / 0x35579)
    if(ZeroFlag) {
      goto label_334B_20E0_35590;
    }
    State.IncCycles();
    // MOV AH,AL (334B_20CB / 0x3557B)
    AH = AL;
    State.IncCycles();
    // ADD AH,DL (334B_20CD / 0x3557D)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    State.IncCycles();
    // STOSW ES:DI (334B_20CF / 0x3557F)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD AH,DL (334B_20D0 / 0x35580)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    State.IncCycles();
    // MOV AL,AH (334B_20D2 / 0x35582)
    AL = AH;
    State.IncCycles();
    // ADD AH,DL (334B_20D4 / 0x35584)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    State.IncCycles();
    // STOSW ES:DI (334B_20D6 / 0x35586)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,DH (334B_20D7 / 0x35587)
    AL = DH;
    State.IncCycles();
    // LOOP 0x3000:5563 (334B_20D9 / 0x35589)
    if(--CX != 0) {
      goto label_334B_20B3_35563;
    }
    State.IncCycles();
    // MOV CX,BX (334B_20DB / 0x3558B)
    CX = BX;
    State.IncCycles();
    // POP SI (334B_20DD / 0x3558D)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x3000:559b (334B_20DE / 0x3558E)
    goto label_334B_20EB_3559B;
    State.IncCycles();
    label_334B_20E0_35590:
    // MOV AH,AL (334B_20E0 / 0x35590)
    AH = AL;
    State.IncCycles();
    // STOSW ES:DI (334B_20E2 / 0x35592)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (334B_20E3 / 0x35593)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,DH (334B_20E4 / 0x35594)
    AL = DH;
    State.IncCycles();
    // LOOP 0x3000:5563 (334B_20E6 / 0x35596)
    if(--CX != 0) {
      goto label_334B_20B3_35563;
    }
    State.IncCycles();
    // MOV CX,BX (334B_20E8 / 0x35598)
    CX = BX;
    State.IncCycles();
    // POP SI (334B_20EA / 0x3559A)
    SI = Stack.Pop();
    State.IncCycles();
    label_334B_20EB_3559B:
    // JCXZ 0x3000:55c5 (334B_20EB / 0x3559B)
    if(CX == 0) {
      goto label_334B_2115_355C5;
    }
    State.IncCycles();
    label_334B_20ED_3559D:
    // MOV DH,byte ptr [SI] (334B_20ED / 0x3559D)
    DH = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_20EF / 0x3559F)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // STC  (334B_20F0 / 0x355A0)
    CarryFlag = true;
    State.IncCycles();
    // ADC DH,DH (334B_20F1 / 0x355A1)
    DH = Alu.Adc8(DH, DH);
    State.IncCycles();
    // ADD DH,DH (334B_20F3 / 0x355A3)
    DH += DH;
    State.IncCycles();
    // SHL DH,1 (334B_20F5 / 0x355A5)
    DH <<= 0x1;
    State.IncCycles();
    // SHL DH,1 (334B_20F7 / 0x355A7)
    // DH <<= 0x1;
    DH = Alu.Shl8(DH, 0x1);
    State.IncCycles();
    // MOV DL,DH (334B_20F9 / 0x355A9)
    DL = DH;
    State.IncCycles();
    // SUB DL,AL (334B_20FB / 0x355AB)
    DL -= AL;
    State.IncCycles();
    // SAR DL,1 (334B_20FD / 0x355AD)
    DL = Alu.Sar8(DL, 0x1);
    State.IncCycles();
    // SAR DL,1 (334B_20FF / 0x355AF)
    DL = Alu.Sar8(DL, 0x1);
    State.IncCycles();
    // OR DL,DL (334B_2101 / 0x355B1)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x3000:55c8 (334B_2103 / 0x355B3)
    if(ZeroFlag) {
      goto label_334B_2118_355C8;
    }
    State.IncCycles();
    // MOV AH,AL (334B_2105 / 0x355B5)
    AH = AL;
    State.IncCycles();
    // ADD AH,DL (334B_2107 / 0x355B7)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    State.IncCycles();
    // STOSW ES:DI (334B_2109 / 0x355B9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD AH,DL (334B_210A / 0x355BA)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    State.IncCycles();
    // MOV AL,AH (334B_210C / 0x355BC)
    AL = AH;
    State.IncCycles();
    // ADD AH,DL (334B_210E / 0x355BE)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    State.IncCycles();
    // STOSW ES:DI (334B_2110 / 0x355C0)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,DH (334B_2111 / 0x355C1)
    AL = DH;
    State.IncCycles();
    // LOOP 0x3000:559d (334B_2113 / 0x355C3)
    if(--CX != 0) {
      goto label_334B_20ED_3559D;
    }
    State.IncCycles();
    label_334B_2115_355C5:
    // POP DS (334B_2115 / 0x355C5)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_2116 / 0x355C6)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (334B_2117 / 0x355C7)
    return NearRet();
    State.IncCycles();
    label_334B_2118_355C8:
    // MOV AH,AL (334B_2118 / 0x355C8)
    AH = AL;
    State.IncCycles();
    // STOSW ES:DI (334B_211A / 0x355CA)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (334B_211B / 0x355CB)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,DH (334B_211C / 0x355CC)
    AL = DH;
    State.IncCycles();
    // LOOP 0x3000:559d (334B_211E / 0x355CE)
    if(--CX != 0) {
      goto label_334B_20ED_3559D;
    }
    State.IncCycles();
    // POP DS (334B_2120 / 0x355D0)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_2121 / 0x355D1)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (334B_2122 / 0x355D2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2123_0355D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2123_355D3:
    // PUSH DX (334B_2123 / 0x355D3)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BP (334B_2124 / 0x355D4)
    Stack.Push(BP);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0xa] (334B_2125 / 0x355D5)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x2] (334B_2128 / 0x355D8)
    DX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_212B / 0x355DB)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD DI,0x13c (334B_2130 / 0x355E0)
    // DI += 0x13C;
    DI = Alu.Add16(DI, 0x13C);
    State.IncCycles();
    // MOV word ptr CS:[0x1b3],0xb0 (334B_2134 / 0x355E4)
    UInt16[cs2, 0x1B3] = 0xB0;
    State.IncCycles();
    // MOV SI,DI (334B_213B / 0x355EB)
    SI = DI;
    State.IncCycles();
    // MOV AX,0x190 (334B_213D / 0x355ED)
    AX = 0x190;
    State.IncCycles();
    // ADD DI,AX (334B_2140 / 0x355F0)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV BP,DI (334B_2142 / 0x355F2)
    BP = DI;
    State.IncCycles();
    // ADD DI,AX (334B_2144 / 0x355F4)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV BX,DI (334B_2146 / 0x355F6)
    BX = DI;
    State.IncCycles();
    // ADD DI,AX (334B_2148 / 0x355F8)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV word ptr CS:[0x1b5],DI (334B_214A / 0x355FA)
    UInt16[cs2, 0x1B5] = DI;
    State.IncCycles();
    // ADD DI,AX (334B_214F / 0x355FF)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // JMP 0x3000:5633 (334B_2151 / 0x35601)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2183_035633, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2153_035603(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2153_35603:
    // PUSH DX (334B_2153 / 0x35603)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BP (334B_2154 / 0x35604)
    Stack.Push(BP);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x2] (334B_2155 / 0x35605)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV DX,word ptr [BP + -0x6] (334B_2158 / 0x35608)
    DX = UInt16[SS, (ushort)(BP - 0x6)];
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_215B / 0x3560B)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD DI,0x13c (334B_2160 / 0x35610)
    // DI += 0x13C;
    DI = Alu.Add16(DI, 0x13C);
    State.IncCycles();
    // MOV word ptr CS:[0x1b3],0xb0 (334B_2164 / 0x35614)
    UInt16[cs2, 0x1B3] = 0xB0;
    State.IncCycles();
    // PUSH DI (334B_216B / 0x3561B)
    Stack.Push(DI);
    State.IncCycles();
    // MOV AX,0x190 (334B_216C / 0x3561C)
    AX = 0x190;
    State.IncCycles();
    // ADD DI,AX (334B_216F / 0x3561F)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV word ptr CS:[0x1b5],DI (334B_2171 / 0x35621)
    UInt16[cs2, 0x1B5] = DI;
    State.IncCycles();
    // ADD DI,AX (334B_2176 / 0x35626)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV BX,DI (334B_2178 / 0x35628)
    BX = DI;
    State.IncCycles();
    // ADD DI,AX (334B_217A / 0x3562A)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV BP,DI (334B_217C / 0x3562C)
    BP = DI;
    State.IncCycles();
    // ADD DI,AX (334B_217E / 0x3562E)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV SI,DI (334B_2180 / 0x35630)
    SI = DI;
    State.IncCycles();
    // POP DI (334B_2182 / 0x35632)
    DI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2183_035633, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2183_035633(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2183_35633:
    // PUSH word ptr CS:[0x1b3] (334B_2183 / 0x35633)
    Stack.Push(UInt16[cs2, 0x1B3]);
    State.IncCycles();
    // PUSH DI (334B_2188 / 0x35638)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH word ptr CS:[0x1b5] (334B_2189 / 0x35639)
    Stack.Push(UInt16[cs2, 0x1B5]);
    State.IncCycles();
    // PUSH BX (334B_218E / 0x3563E)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH BP (334B_218F / 0x3563F)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH SI (334B_2190 / 0x35640)
    Stack.Push(SI);
    State.IncCycles();
    // SUB DX,CX (334B_2191 / 0x35641)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    State.IncCycles();
    // MOV AX,DS (334B_2193 / 0x35643)
    AX = DS;
    State.IncCycles();
    // MOV ES,AX (334B_2195 / 0x35645)
    ES = AX;
    State.IncCycles();
    // XOR AX,AX (334B_2197 / 0x35647)
    AX = 0;
    State.IncCycles();
    // DIV CX (334B_2199 / 0x35649)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV CS:[0x1ad],AX (334B_219B / 0x3564B)
    UInt16[cs2, 0x1AD] = AX;
    State.IncCycles();
    // MOV CS:[0x1af],AX (334B_219F / 0x3564F)
    UInt16[cs2, 0x1AF] = AX;
    State.IncCycles();
    // SHR AX,1 (334B_21A3 / 0x35653)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV DX,AX (334B_21A5 / 0x35655)
    DX = AX;
    State.IncCycles();
    // SHR AX,1 (334B_21A7 / 0x35657)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV CX,DX (334B_21A9 / 0x35659)
    CX = DX;
    State.IncCycles();
    // ADD CX,AX (334B_21AB / 0x3565B)
    CX += AX;
    State.IncCycles();
    // ADD AX,0x80 (334B_21AD / 0x3565D)
    AX += 0x80;
    State.IncCycles();
    // ADD CX,0x80 (334B_21B0 / 0x35660)
    CX += 0x80;
    State.IncCycles();
    // ADD DX,0x80 (334B_21B4 / 0x35664)
    // DX += 0x80;
    DX = Alu.Add16(DX, 0x80);
    State.IncCycles();
    // MOV CL,CH (334B_21B8 / 0x35668)
    CL = CH;
    State.IncCycles();
    // MOV CH,AH (334B_21BA / 0x3566A)
    CH = AH;
    State.IncCycles();
    // MOV DL,DH (334B_21BC / 0x3566C)
    DL = DH;
    State.IncCycles();
    // MOV word ptr CS:[0x1b1],CX (334B_21BE / 0x3566E)
    UInt16[cs2, 0x1B1] = CX;
    State.IncCycles();
    label_334B_21C3_35673:
    // LODSB SI (334B_21C3 / 0x35673)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,byte ptr [DI] (334B_21C4 / 0x35674)
    AH = UInt8[DS, DI];
    State.IncCycles();
    // INC DI (334B_21C6 / 0x35676)
    DI++;
    State.IncCycles();
    // SUB AH,AL (334B_21C7 / 0x35677)
    AH -= AL;
    State.IncCycles();
    // SAR AH,1 (334B_21C9 / 0x35679)
    AH = Alu.Sar8(AH, 0x1);
    State.IncCycles();
    // SAR AH,1 (334B_21CB / 0x3567B)
    AH = Alu.Sar8(AH, 0x1);
    State.IncCycles();
    // ADD AL,AH (334B_21CD / 0x3567D)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    // MOV byte ptr [BP + 0x0],AL (334B_21CF / 0x3567F)
    UInt8[SS, BP] = AL;
    State.IncCycles();
    // INC BP (334B_21D2 / 0x35682)
    BP++;
    State.IncCycles();
    // ADD CH,byte ptr CS:[0x1b2] (334B_21D3 / 0x35683)
    // CH += UInt8[cs2, 0x1B2];
    CH = Alu.Add8(CH, UInt8[cs2, 0x1B2]);
    State.IncCycles();
    // JC 0x3000:56bb (334B_21D8 / 0x35688)
    if(CarryFlag) {
      goto label_334B_220B_356BB;
    }
    State.IncCycles();
    label_334B_21DA_3568A:
    // ADD AL,AH (334B_21DA / 0x3568A)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    // MOV byte ptr [BX],AL (334B_21DC / 0x3568C)
    UInt8[DS, BX] = AL;
    State.IncCycles();
    // INC BX (334B_21DE / 0x3568E)
    BX++;
    State.IncCycles();
    // ADD DL,DH (334B_21DF / 0x3568F)
    // DL += DH;
    DL = Alu.Add8(DL, DH);
    State.IncCycles();
    // JC 0x3000:56c1 (334B_21E1 / 0x35691)
    if(CarryFlag) {
      goto label_334B_2211_356C1;
    }
    State.IncCycles();
    label_334B_21E3_35693:
    // ADD AL,AH (334B_21E3 / 0x35693)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    // XCHG word ptr CS:[0x1b5],DI (334B_21E5 / 0x35695)
    ushort tmp_334B_21E5 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_21E5;
    State.IncCycles();
    // STOSB ES:DI (334B_21EA / 0x3569A)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD CL,byte ptr CS:[0x1b1] (334B_21EB / 0x3569B)
    // CL += UInt8[cs2, 0x1B1];
    CL = Alu.Add8(CL, UInt8[cs2, 0x1B1]);
    State.IncCycles();
    // JC 0x3000:56c6 (334B_21F0 / 0x356A0)
    if(CarryFlag) {
      goto label_334B_2216_356C6;
    }
    State.IncCycles();
    label_334B_21F2_356A2:
    // XCHG word ptr CS:[0x1b5],DI (334B_21F2 / 0x356A2)
    ushort tmp_334B_21F2 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_21F2;
    State.IncCycles();
    // MOV AX,CS:[0x1ad] (334B_21F7 / 0x356A7)
    AX = UInt16[cs2, 0x1AD];
    State.IncCycles();
    // ADD word ptr CS:[0x1af],AX (334B_21FB / 0x356AB)
    // UInt16[cs2, 0x1AF] += AX;
    UInt16[cs2, 0x1AF] = Alu.Add16(UInt16[cs2, 0x1AF], AX);
    State.IncCycles();
    // JC 0x3000:56c9 (334B_2200 / 0x356B0)
    if(CarryFlag) {
      goto label_334B_2219_356C9;
    }
    State.IncCycles();
    // DEC word ptr CS:[0x1b3] (334B_2202 / 0x356B2)
    UInt16[cs2, 0x1B3] = Alu.Dec16(UInt16[cs2, 0x1B3]);
    State.IncCycles();
    // JNZ 0x3000:5673 (334B_2207 / 0x356B7)
    if(!ZeroFlag) {
      goto label_334B_21C3_35673;
    }
    State.IncCycles();
    // JMP 0x3000:56d1 (334B_2209 / 0x356B9)
    goto label_334B_2221_356D1;
    State.IncCycles();
    label_334B_220B_356BB:
    // MOV byte ptr [BP + 0x0],AL (334B_220B / 0x356BB)
    UInt8[SS, BP] = AL;
    State.IncCycles();
    // INC BP (334B_220E / 0x356BE)
    BP = Alu.Inc16(BP);
    State.IncCycles();
    // JMP 0x3000:568a (334B_220F / 0x356BF)
    goto label_334B_21DA_3568A;
    State.IncCycles();
    label_334B_2211_356C1:
    // MOV byte ptr [BX],AL (334B_2211 / 0x356C1)
    UInt8[DS, BX] = AL;
    State.IncCycles();
    // INC BX (334B_2213 / 0x356C3)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // JMP 0x3000:5693 (334B_2214 / 0x356C4)
    goto label_334B_21E3_35693;
    State.IncCycles();
    label_334B_2216_356C6:
    // STOSB ES:DI (334B_2216 / 0x356C6)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // JMP 0x3000:56a2 (334B_2217 / 0x356C7)
    goto label_334B_21F2_356A2;
    State.IncCycles();
    label_334B_2219_356C9:
    // INC DI (334B_2219 / 0x356C9)
    DI++;
    State.IncCycles();
    // DEC word ptr CS:[0x1b3] (334B_221A / 0x356CA)
    UInt16[cs2, 0x1B3] = Alu.Dec16(UInt16[cs2, 0x1B3]);
    State.IncCycles();
    // JNZ 0x3000:5673 (334B_221F / 0x356CF)
    if(!ZeroFlag) {
      goto label_334B_21C3_35673;
    }
    State.IncCycles();
    label_334B_2221_356D1:
    // POP SI (334B_2221 / 0x356D1)
    SI = Stack.Pop();
    State.IncCycles();
    // POP BP (334B_2222 / 0x356D2)
    BP = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_2223 / 0x356D3)
    BX = Stack.Pop();
    State.IncCycles();
    // POP word ptr CS:[0x1b5] (334B_2224 / 0x356D4)
    UInt16[cs2, 0x1B5] = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_2229 / 0x356D9)
    DI = Stack.Pop();
    State.IncCycles();
    // POP word ptr CS:[0x1b3] (334B_222A / 0x356DA)
    UInt16[cs2, 0x1B3] = Stack.Pop();
    State.IncCycles();
    // MOV CX,word ptr CS:[0x1b1] (334B_222F / 0x356DF)
    CX = UInt16[cs2, 0x1B1];
    State.IncCycles();
    // MOV DL,DH (334B_2234 / 0x356E4)
    DL = DH;
    State.IncCycles();
    // MOV AX,CS:[0x1ad] (334B_2236 / 0x356E6)
    AX = UInt16[cs2, 0x1AD];
    State.IncCycles();
    // MOV CS:[0x1af],AX (334B_223A / 0x356EA)
    UInt16[cs2, 0x1AF] = AX;
    State.IncCycles();
    // DEC SI (334B_223E / 0x356EE)
    SI--;
    State.IncCycles();
    // DEC DI (334B_223F / 0x356EF)
    DI--;
    State.IncCycles();
    // DEC word ptr CS:[0x1b5] (334B_2240 / 0x356F0)
    UInt16[cs2, 0x1B5] = Alu.Dec16(UInt16[cs2, 0x1B5]);
    State.IncCycles();
    // STD  (334B_2245 / 0x356F5)
    DirectionFlag = true;
    State.IncCycles();
    label_334B_2246_356F6:
    // LODSB SI (334B_2246 / 0x356F6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,byte ptr [DI] (334B_2247 / 0x356F7)
    AH = UInt8[DS, DI];
    State.IncCycles();
    // DEC DI (334B_2249 / 0x356F9)
    DI--;
    State.IncCycles();
    // SUB AH,AL (334B_224A / 0x356FA)
    AH -= AL;
    State.IncCycles();
    // SAR AH,1 (334B_224C / 0x356FC)
    AH = Alu.Sar8(AH, 0x1);
    State.IncCycles();
    // SAR AH,1 (334B_224E / 0x356FE)
    AH = Alu.Sar8(AH, 0x1);
    State.IncCycles();
    // ADD AL,AH (334B_2250 / 0x35700)
    AL += AH;
    State.IncCycles();
    // DEC BP (334B_2252 / 0x35702)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // MOV byte ptr [BP + 0x0],AL (334B_2253 / 0x35703)
    UInt8[SS, BP] = AL;
    State.IncCycles();
    // ADD CH,byte ptr CS:[0x1b2] (334B_2256 / 0x35706)
    // CH += UInt8[cs2, 0x1B2];
    CH = Alu.Add8(CH, UInt8[cs2, 0x1B2]);
    State.IncCycles();
    // JC 0x3000:573f (334B_225B / 0x3570B)
    if(CarryFlag) {
      goto label_334B_228F_3573F;
    }
    State.IncCycles();
    label_334B_225D_3570D:
    // ADD AL,AH (334B_225D / 0x3570D)
    AL += AH;
    State.IncCycles();
    // DEC BX (334B_225F / 0x3570F)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // MOV byte ptr [BX],AL (334B_2260 / 0x35710)
    UInt8[DS, BX] = AL;
    State.IncCycles();
    // ADD DL,DH (334B_2262 / 0x35712)
    // DL += DH;
    DL = Alu.Add8(DL, DH);
    State.IncCycles();
    // JC 0x3000:5745 (334B_2264 / 0x35714)
    if(CarryFlag) {
      goto label_334B_2295_35745;
    }
    State.IncCycles();
    label_334B_2266_35716:
    // ADD AL,AH (334B_2266 / 0x35716)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    // XCHG word ptr CS:[0x1b5],DI (334B_2268 / 0x35718)
    ushort tmp_334B_2268 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_2268;
    State.IncCycles();
    // STOSB ES:DI (334B_226D / 0x3571D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD CL,byte ptr CS:[0x1b1] (334B_226E / 0x3571E)
    // CL += UInt8[cs2, 0x1B1];
    CL = Alu.Add8(CL, UInt8[cs2, 0x1B1]);
    State.IncCycles();
    // JC 0x3000:574a (334B_2273 / 0x35723)
    if(CarryFlag) {
      goto label_334B_229A_3574A;
    }
    State.IncCycles();
    label_334B_2275_35725:
    // XCHG word ptr CS:[0x1b5],DI (334B_2275 / 0x35725)
    ushort tmp_334B_2275 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_2275;
    State.IncCycles();
    // MOV AX,CS:[0x1ad] (334B_227A / 0x3572A)
    AX = UInt16[cs2, 0x1AD];
    State.IncCycles();
    // ADD word ptr CS:[0x1af],AX (334B_227E / 0x3572E)
    // UInt16[cs2, 0x1AF] += AX;
    UInt16[cs2, 0x1AF] = Alu.Add16(UInt16[cs2, 0x1AF], AX);
    State.IncCycles();
    // JC 0x3000:574d (334B_2283 / 0x35733)
    if(CarryFlag) {
      goto label_334B_229D_3574D;
    }
    State.IncCycles();
    label_334B_2285_35735:
    // DEC word ptr CS:[0x1b3] (334B_2285 / 0x35735)
    UInt16[cs2, 0x1B3] = Alu.Dec16(UInt16[cs2, 0x1B3]);
    State.IncCycles();
    // JNZ 0x3000:56f6 (334B_228A / 0x3573A)
    if(!ZeroFlag) {
      goto label_334B_2246_356F6;
    }
    State.IncCycles();
    // CLD  (334B_228C / 0x3573C)
    DirectionFlag = false;
    State.IncCycles();
    // JMP 0x3000:5750 (334B_228D / 0x3573D)
    goto label_334B_22A0_35750;
    State.IncCycles();
    label_334B_228F_3573F:
    // DEC BP (334B_228F / 0x3573F)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // MOV byte ptr [BP + 0x0],AL (334B_2290 / 0x35740)
    UInt8[SS, BP] = AL;
    State.IncCycles();
    // JMP 0x3000:570d (334B_2293 / 0x35743)
    goto label_334B_225D_3570D;
    State.IncCycles();
    label_334B_2295_35745:
    // DEC BX (334B_2295 / 0x35745)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // MOV byte ptr [BX],AL (334B_2296 / 0x35746)
    UInt8[DS, BX] = AL;
    State.IncCycles();
    // JMP 0x3000:5716 (334B_2298 / 0x35748)
    goto label_334B_2266_35716;
    State.IncCycles();
    label_334B_229A_3574A:
    // STOSB ES:DI (334B_229A / 0x3574A)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // JMP 0x3000:5725 (334B_229B / 0x3574B)
    goto label_334B_2275_35725;
    State.IncCycles();
    label_334B_229D_3574D:
    // DEC DI (334B_229D / 0x3574D)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // JMP 0x3000:5735 (334B_229E / 0x3574E)
    goto label_334B_2285_35735;
    State.IncCycles();
    label_334B_22A0_35750:
    // POP BP (334B_22A0 / 0x35750)
    BP = Stack.Pop();
    State.IncCycles();
    // PUSH BP (334B_22A1 / 0x35751)
    Stack.Push(BP);
    State.IncCycles();
    // SUB BP,word ptr CS:[0x1bb] (334B_22A2 / 0x35752)
    // BP -= UInt16[cs2, 0x1BB];
    BP = Alu.Sub16(BP, UInt16[cs2, 0x1BB]);
    State.IncCycles();
    // JC 0x3000:57ba (334B_22A7 / 0x35757)
    if(CarryFlag) {
      goto label_334B_230A_357BA;
    }
    State.IncCycles();
    // MOV AX,CS (334B_22A9 / 0x35759)
    AX = cs2;
    State.IncCycles();
    // MOV DS,AX (334B_22AB / 0x3575B)
    DS = AX;
    State.IncCycles();
    // ADD BP,word ptr CS:[0x1b9] (334B_22AD / 0x3575D)
    // BP += UInt16[cs2, 0x1B9];
    BP = Alu.Add16(BP, UInt16[cs2, 0x1B9]);
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_22B2 / 0x35762)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD DI,0xa0 (334B_22B7 / 0x35767)
    DI += 0xA0;
    State.IncCycles();
    // XOR CH,CH (334B_22BB / 0x3576B)
    CH = 0;
    State.IncCycles();
    // XOR AL,AL (334B_22BD / 0x3576D)
    AL = 0;
    State.IncCycles();
    // MOV BL,0x4 (334B_22BF / 0x3576F)
    BL = 0x4;
    State.IncCycles();
    label_334B_22C1_35771:
    // MOV SI,0x8ef (334B_22C1 / 0x35771)
    SI = 0x8EF;
    State.IncCycles();
    // MOV CL,byte ptr CS:[BP + 0x0] (334B_22C4 / 0x35774)
    CL = UInt8[cs2, BP];
    State.IncCycles();
    // MOV BH,CL (334B_22C8 / 0x35778)
    BH = CL;
    State.IncCycles();
    // SUB CX,0x4 (334B_22CA / 0x3577A)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    State.IncCycles();
    // JA 0x3000:5789 (334B_22CD / 0x3577D)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_22D9_35789;
    }
    State.IncCycles();
    // NEG CX (334B_22CF / 0x3577F)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // ADD SI,CX (334B_22D1 / 0x35781)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // MOV CL,BH (334B_22D3 / 0x35783)
    CL = BH;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_22D5 / 0x35785)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // JMP 0x3000:578f (334B_22D7 / 0x35787)
    goto label_334B_22DF_3578F;
    State.IncCycles();
    label_334B_22D9_35789:
    // XOR AL,AL (334B_22D9 / 0x35789)
    AL = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_22DB / 0x3578B)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_22DD / 0x3578D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_22DE / 0x3578E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    label_334B_22DF_3578F:
    // MOV CL,byte ptr CS:[BP + 0x1] (334B_22DF / 0x3578F)
    CL = UInt8[cs2, (ushort)(BP + 0x1)];
    State.IncCycles();
    // ADD DI,CX (334B_22E3 / 0x35793)
    DI += CX;
    State.IncCycles();
    // ADD DI,CX (334B_22E5 / 0x35795)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // MOV CL,BH (334B_22E7 / 0x35797)
    CL = BH;
    State.IncCycles();
    // SUB CX,0x4 (334B_22E9 / 0x35799)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    State.IncCycles();
    // JA 0x3000:57a6 (334B_22EC / 0x3579C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_22F6_357A6;
    }
    State.IncCycles();
    // MOV CL,BH (334B_22EE / 0x3579E)
    CL = BH;
    State.IncCycles();
    // XOR CH,CH (334B_22F0 / 0x357A0)
    CH = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_22F2 / 0x357A2)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // JMP 0x3000:57ac (334B_22F4 / 0x357A4)
    goto label_334B_22FC_357AC;
    State.IncCycles();
    label_334B_22F6_357A6:
    // MOVSW ES:DI,SI (334B_22F6 / 0x357A6)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_22F7 / 0x357A7)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // XOR AL,AL (334B_22F8 / 0x357A8)
    AL = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_22FA / 0x357AA)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    label_334B_22FC_357AC:
    // ADD DI,0x58 (334B_22FC / 0x357AC)
    DI += 0x58;
    State.IncCycles();
    // ADD BP,0x2 (334B_22FF / 0x357AF)
    BP += 0x2;
    State.IncCycles();
    // DEC BL (334B_2302 / 0x357B2)
    BL = Alu.Dec8(BL);
    State.IncCycles();
    // JNZ 0x3000:5771 (334B_2304 / 0x357B4)
    if(!ZeroFlag) {
      goto label_334B_22C1_35771;
    }
    State.IncCycles();
    // MOV AX,SS (334B_2306 / 0x357B6)
    AX = SS;
    State.IncCycles();
    // MOV DS,AX (334B_2308 / 0x357B8)
    DS = AX;
    State.IncCycles();
    label_334B_230A_357BA:
    // MOV ES,word ptr CS:[0x1ab] (334B_230A / 0x357BA)
    ES = UInt16[cs2, 0x1AB];
    State.IncCycles();
    // MOV CX,0x138 (334B_230F / 0x357BF)
    CX = 0x138;
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1cb2] (334B_2312 / 0x357C2)
    DI = UInt16[cs2, 0x1CB2];
    State.IncCycles();
    // MOV SI,word ptr CS:[0x1a5] (334B_2317 / 0x357C7)
    SI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD SI,0xa0 (334B_231C / 0x357CC)
    // SI += 0xA0;
    SI = Alu.Add16(SI, 0xA0);
    State.IncCycles();
    // CALL 0x3000:57f3 (334B_2320 / 0x357D0)
    NearCall(cs2, 0x2323, spice86_generated_label_call_target_334B_2343_0357F3);
    State.IncCycles();
    label_334B_2323_357D3:
    // MOV word ptr CS:[0x1cb2],DI (334B_2323 / 0x357D3)
    UInt16[cs2, 0x1CB2] = DI;
    State.IncCycles();
    // MOV AX,DS (334B_2328 / 0x357D8)
    AX = DS;
    State.IncCycles();
    // MOV ES,AX (334B_232A / 0x357DA)
    ES = AX;
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a5] (334B_232C / 0x357DC)
    DI = UInt16[cs2, 0x1A5];
    State.IncCycles();
    // ADD DI,0x8c (334B_2331 / 0x357E1)
    // DI += 0x8C;
    DI = Alu.Add16(DI, 0x8C);
    State.IncCycles();
    // MOV SI,DI (334B_2335 / 0x357E5)
    SI = DI;
    State.IncCycles();
    // ADD SI,0x640 (334B_2337 / 0x357E7)
    // SI += 0x640;
    SI = Alu.Add16(SI, 0x640);
    State.IncCycles();
    // MOV CX,0x15e (334B_233B / 0x357EB)
    CX = 0x15E;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_233E / 0x357EE)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP BP (334B_2340 / 0x357F0)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_2341 / 0x357F1)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (334B_2342 / 0x357F2)
    return NearRet();
  }
  
}
