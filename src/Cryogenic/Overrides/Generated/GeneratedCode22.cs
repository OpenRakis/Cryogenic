namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action not_observed_334B_0C06_0340B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0C06_340B6:
    // MOV DX,0x140 (334B_0C06 / 0x340B6)
    DX = 0x140;
    State.IncCycles();
    // MUL DX (334B_0C09 / 0x340B9)
    Cpu.Mul16(DX);
    State.IncCycles();
    // MOV CS:[0x1a3],AX (334B_0C0B / 0x340BB)
    UInt16[cs2, 0x1A3] = AX;
    State.IncCycles();
    // RETF  (334B_0C0F / 0x340BF)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0C10_0340C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0C10_340C0:
    // CMP BX,0xc8 (334B_0C10 / 0x340C0)
    Alu.Sub16(BX, 0xC8);
    State.IncCycles();
    // JC 0x3000:40c9 (334B_0C14 / 0x340C4)
    if(CarryFlag) {
      goto label_334B_0C19_340C9;
    }
    State.IncCycles();
    // MOV BX,0xc7 (334B_0C16 / 0x340C6)
    BX = 0xC7;
    State.IncCycles();
    label_334B_0C19_340C9:
    // XCHG BL,BH (334B_0C19 / 0x340C9)
    byte tmp_334B_0C19 = BL;
    BL = BH;
    BH = tmp_334B_0C19;
    State.IncCycles();
    // MOV DI,BX (334B_0C1B / 0x340CB)
    DI = BX;
    State.IncCycles();
    // SHR DI,1 (334B_0C1D / 0x340CD)
    DI >>= 0x1;
    State.IncCycles();
    // SHR DI,1 (334B_0C1F / 0x340CF)
    DI >>= 0x1;
    State.IncCycles();
    // ADD DI,BX (334B_0C21 / 0x340D1)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // XCHG BL,BH (334B_0C23 / 0x340D3)
    byte tmp_334B_0C23 = BL;
    BL = BH;
    BH = tmp_334B_0C23;
    State.IncCycles();
    // ADD DI,DX (334B_0C25 / 0x340D5)
    DI += DX;
    State.IncCycles();
    // ADD DI,word ptr CS:[0x1a3] (334B_0C27 / 0x340D7)
    // DI += UInt16[cs2, 0x1A3];
    DI = Alu.Add16(DI, UInt16[cs2, 0x1A3]);
    State.IncCycles();
    // RET  (334B_0C2C / 0x340DC)
    return NearRet();
  }
  
  public virtual Action not_observed_334B_0C2D_0340DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0C2D_340DD:
    // PUSH BX (334B_0C2D / 0x340DD)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_0C2E / 0x340DE)
    NearCall(cs2, 0xC31, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    // POP BX (334B_0C31 / 0x340E1)
    BX = Stack.Pop();
    State.IncCycles();
    // STOSB ES:DI (334B_0C32 / 0x340E2)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // RETF  (334B_0C33 / 0x340E3)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0C3B_0340EB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24190: goto label_334B_0CE0_34190;break; // Target of external jump from 0x344B2, 0x341F4, 0x341DA, 0x341E9, 0x341BD
      case 0x240F6: goto label_334B_0C46_340F6;break; // Target of external jump from 0x34486, 0x3411F, 0x3415F, 0x3489E, 0x3416C, 0x3417C
      case 0x24185: goto label_334B_0CD5_34185;break; // Target of external jump from 0x341C0, 0x341F7
      case 0x241D4: goto label_334B_0D24_341D4;break; // Target of external jump from 0x3420F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_0C3B_340EB:
    // Instruction bytes at index 1 modified by those instruction(s): 3488D, 34464
    // Instruction bytes at index 2 modified by those instruction(s): 3488D
    // Instruction is modified by code, generator handled: First value group is modified
    // MOV BP,0x1234 (334B_0C3B / 0x340EB)
    BP = UInt16[cs2, 0xC3C];
    State.IncCycles();
    // SUB DI,BP (334B_0C3E / 0x340EE)
    DI -= BP;
    State.IncCycles();
    // SUB DI,BP (334B_0C40 / 0x340F0)
    DI -= BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_0C42 / 0x340F2)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_0C46_340F6:
    // LODSB SI (334B_0C46 / 0x340F6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_0C47 / 0x340F7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:4135 (334B_0C49 / 0x340F9)
    if(SignFlag) {
      goto label_334B_0C85_34135;
    }
    State.IncCycles();
    // MOV CX,AX (334B_0C4B / 0x340FB)
    CX = AX;
    State.IncCycles();
    // XOR CH,CH (334B_0C4D / 0x340FD)
    CH = 0;
    State.IncCycles();
    // INC CX (334B_0C4F / 0x340FF)
    CX++;
    State.IncCycles();
    // SUB BP,CX (334B_0C50 / 0x34100)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    label_334B_0C52_34102:
    // LODSB SI (334B_0C52 / 0x34102)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,AL (334B_0C53 / 0x34103)
    AH = AL;
    State.IncCycles();
    // AND AL,DL (334B_0C55 / 0x34105)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:412b (334B_0C57 / 0x34107)
    if(ZeroFlag) {
      goto label_334B_0C7B_3412B;
    }
    State.IncCycles();
    // ADD AL,DH (334B_0C59 / 0x34109)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_0C5B / 0x3410B)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SHR AH,1 (334B_0C5C / 0x3410C)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_0C5E_3410E:
    // SHR AH,1 (334B_0C5E / 0x3410E)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_0C60 / 0x34110)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_0C62 / 0x34112)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:4130 (334B_0C64 / 0x34114)
    if(ZeroFlag) {
      goto label_334B_0C80_34130;
    }
    State.IncCycles();
    // MOV AL,AH (334B_0C66 / 0x34116)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_0C68 / 0x34118)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_0C6A / 0x3411A)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4102 (334B_0C6B / 0x3411B)
    if(--CX != 0) {
      goto label_334B_0C52_34102;
    }
    State.IncCycles();
    label_334B_0C6D_3411D:
    // OR BP,BP (334B_0C6D / 0x3411D)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:40f6 (334B_0C6F / 0x3411F)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0C46_340F6;
    }
    State.IncCycles();
    // DEC BX (334B_0C71 / 0x34121)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:40eb (334B_0C72 / 0x34122)
    if(!ZeroFlag) {
      goto label_334B_0C3B_340EB;
    }
    State.IncCycles();
    label_334B_0C74_34124:
    // MOV byte ptr CS:[0xc43],0xc7 (334B_0C74 / 0x34124)
    UInt8[cs2, 0xC43] = 0xC7;
    State.IncCycles();
    // RETF  (334B_0C7A / 0x3412A)
    return FarRet();
    State.IncCycles();
    label_334B_0C7B_3412B:
    // INC DI (334B_0C7B / 0x3412B)
    DI++;
    State.IncCycles();
    // SHR AH,1 (334B_0C7C / 0x3412C)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JNZ 0x3000:410e (334B_0C7E / 0x3412E)
    if(!ZeroFlag) {
      goto label_334B_0C5E_3410E;
    }
    State.IncCycles();
    label_334B_0C80_34130:
    // INC DI (334B_0C80 / 0x34130)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:4102 (334B_0C81 / 0x34131)
    if(--CX != 0) {
      goto label_334B_0C52_34102;
    }
    State.IncCycles();
    // JMP 0x3000:411d (334B_0C83 / 0x34133)
    goto label_334B_0C6D_3411D;
    State.IncCycles();
    label_334B_0C85_34135:
    // MOV CX,0x101 (334B_0C85 / 0x34135)
    CX = 0x101;
    State.IncCycles();
    // XOR AH,AH (334B_0C88 / 0x34138)
    AH = 0;
    State.IncCycles();
    // SUB CX,AX (334B_0C8A / 0x3413A)
    CX -= AX;
    State.IncCycles();
    // SUB BP,CX (334B_0C8C / 0x3413C)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // LODSB SI (334B_0C8E / 0x3413E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SHL AX,1 (334B_0C8F / 0x3413F)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JZ 0x3000:4166 (334B_0C91 / 0x34141)
    if(ZeroFlag) {
      goto label_334B_0CB6_34166;
    }
    State.IncCycles();
    // SHL AX,1 (334B_0C93 / 0x34143)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_0C95 / 0x34145)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_0C97 / 0x34147)
    AX <<= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0C99 / 0x34149)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x3000:4170 (334B_0C9B / 0x3414B)
    if(ZeroFlag) {
      goto label_334B_0CC0_34170;
    }
    State.IncCycles();
    // SHR AL,1 (334B_0C9D / 0x3414D)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0C9F / 0x3414F)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0CA1 / 0x34151)
    AL >>= 0x1;
    State.IncCycles();
    // ADD AL,DH (334B_0CA3 / 0x34153)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // OR AH,AH (334B_0CA5 / 0x34155)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x3000:417f (334B_0CA7 / 0x34157)
    if(ZeroFlag) {
      goto label_334B_0CCF_3417F;
    }
    State.IncCycles();
    // ADD AH,DH (334B_0CA9 / 0x34159)
    // AH += DH;
    AH = Alu.Add8(AH, DH);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_0CAB / 0x3415B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    label_334B_0CAD_3415D:
    // OR BP,BP (334B_0CAD / 0x3415D)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:40f6 (334B_0CAF / 0x3415F)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0C46_340F6;
    }
    State.IncCycles();
    label_334B_0CB1_34161:
    // DEC BX (334B_0CB1 / 0x34161)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:40eb (334B_0CB2 / 0x34162)
    if(!ZeroFlag) {
      goto label_334B_0C3B_340EB;
    }
    State.IncCycles();
    // JMP 0x3000:4124 (334B_0CB4 / 0x34164)
    goto label_334B_0C74_34124;
    State.IncCycles();
    label_334B_0CB6_34166:
    // SHL CX,1 (334B_0CB6 / 0x34166)
    CX <<= 0x1;
    State.IncCycles();
    // ADD DI,CX (334B_0CB8 / 0x34168)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // OR BP,BP (334B_0CBA / 0x3416A)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:40f6 (334B_0CBC / 0x3416C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0C46_340F6;
    }
    State.IncCycles();
    // JMP 0x3000:4161 (334B_0CBE / 0x3416E)
    goto label_334B_0CB1_34161;
    State.IncCycles();
    label_334B_0CC0_34170:
    // MOV AL,AH (334B_0CC0 / 0x34170)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_0CC2 / 0x34172)
    AL += DH;
    State.IncCycles();
    label_334B_0CC4_34174:
    // INC DI (334B_0CC4 / 0x34174)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // STOSB ES:DI (334B_0CC5 / 0x34175)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4174 (334B_0CC6 / 0x34176)
    if(--CX != 0) {
      goto label_334B_0CC4_34174;
    }
    State.IncCycles();
    // OR BP,BP (334B_0CC8 / 0x34178)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JBE 0x3000:4161 (334B_0CCA / 0x3417A)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_0CB1_34161;
    }
    State.IncCycles();
    // JMP 0x3000:40f6 (334B_0CCC / 0x3417C)
    goto label_334B_0C46_340F6;
    State.IncCycles();
    label_334B_0CCF_3417F:
    // STOSB ES:DI (334B_0CCF / 0x3417F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC DI (334B_0CD0 / 0x34180)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:417f (334B_0CD1 / 0x34181)
    if(--CX != 0) {
      goto label_334B_0CCF_3417F;
    }
    State.IncCycles();
    // JMP 0x3000:415d (334B_0CD3 / 0x34183)
    goto label_334B_0CAD_3415D;
    State.IncCycles();
    label_334B_0CD5_34185:
    // Instruction bytes at index 1, 2 modified by those instruction(s): 34489
    // Instruction is modified by code, generator handled: First value group is modified
    // MOV BP,0x1234 (334B_0CD5 / 0x34185)
    BP = UInt16[cs2, 0xCD6];
    State.IncCycles();
    // ADD DI,BP (334B_0CD8 / 0x34188)
    DI += BP;
    State.IncCycles();
    // ADD DI,BP (334B_0CDA / 0x3418A)
    DI += BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_0CDC / 0x3418C)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_0CE0_34190:
    // MOV AL,byte ptr [SI] (334B_0CE0 / 0x34190)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0CE2 / 0x34192)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // OR AL,AL (334B_0CE3 / 0x34193)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:4201 (334B_0CE5 / 0x34195)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0D3E_0341EE, 0x34201 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,AX (334B_0CE7 / 0x34197)
    CX = AX;
    State.IncCycles();
    // XOR CH,CH (334B_0CE9 / 0x34199)
    CH = 0;
    State.IncCycles();
    // INC CX (334B_0CEB / 0x3419B)
    CX++;
    State.IncCycles();
    // SUB BP,CX (334B_0CEC / 0x3419C)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    label_334B_0CEE_3419E:
    // MOV AL,byte ptr [SI] (334B_0CEE / 0x3419E)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0CF0 / 0x341A0)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV AH,AL (334B_0CF1 / 0x341A1)
    AH = AL;
    State.IncCycles();
    // AND AL,DL (334B_0CF3 / 0x341A3)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:41ca (334B_0CF5 / 0x341A5)
    if(ZeroFlag) {
      goto label_334B_0D1A_341CA;
    }
    State.IncCycles();
    // ADD AL,DH (334B_0CF7 / 0x341A7)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_0CF9 / 0x341A9)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SHR AH,1 (334B_0CFA / 0x341AA)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_0CFC_341AC:
    // SHR AH,1 (334B_0CFC / 0x341AC)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_0CFE / 0x341AE)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_0D00 / 0x341B0)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:41cf (334B_0D02 / 0x341B2)
    if(ZeroFlag) {
      goto label_334B_0D1F_341CF;
    }
    State.IncCycles();
    // MOV AL,AH (334B_0D04 / 0x341B4)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_0D06 / 0x341B6)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_0D08 / 0x341B8)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:419e (334B_0D09 / 0x341B9)
    if(--CX != 0) {
      goto label_334B_0CEE_3419E;
    }
    State.IncCycles();
    label_334B_0D0B_341BB:
    // OR BP,BP (334B_0D0B / 0x341BB)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4190 (334B_0D0D / 0x341BD)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0CE0_34190;
    }
    State.IncCycles();
    // DEC BX (334B_0D0F / 0x341BF)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:4185 (334B_0D10 / 0x341C0)
    if(!ZeroFlag) {
      goto label_334B_0CD5_34185;
    }
    State.IncCycles();
    // CLD  (334B_0D12 / 0x341C2)
    DirectionFlag = false;
    State.IncCycles();
    // MOV byte ptr CS:[0xcdd],0xc7 (334B_0D13 / 0x341C3)
    UInt8[cs2, 0xCDD] = 0xC7;
    State.IncCycles();
    // RETF  (334B_0D19 / 0x341C9)
    return FarRet();
    State.IncCycles();
    label_334B_0D1A_341CA:
    // DEC DI (334B_0D1A / 0x341CA)
    DI--;
    State.IncCycles();
    // SHR AH,1 (334B_0D1B / 0x341CB)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JNZ 0x3000:41ac (334B_0D1D / 0x341CD)
    if(!ZeroFlag) {
      goto label_334B_0CFC_341AC;
    }
    State.IncCycles();
    label_334B_0D1F_341CF:
    // DEC DI (334B_0D1F / 0x341CF)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // LOOP 0x3000:419e (334B_0D20 / 0x341D0)
    if(--CX != 0) {
      goto label_334B_0CEE_3419E;
    }
    State.IncCycles();
    // JMP 0x3000:41bb (334B_0D22 / 0x341D2)
    goto label_334B_0D0B_341BB;
    State.IncCycles();
    label_334B_0D24_341D4:
    // SHL CX,1 (334B_0D24 / 0x341D4)
    CX <<= 0x1;
    State.IncCycles();
    // SUB DI,CX (334B_0D26 / 0x341D6)
    // DI -= CX;
    DI = Alu.Sub16(DI, CX);
    State.IncCycles();
    // OR BP,BP (334B_0D28 / 0x341D8)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4190 (334B_0D2A / 0x341DA)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0CE0_34190;
    }
    State.IncCycles();
    // JMP 0x3000:41f6 (334B_0D2C / 0x341DC)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0D3E_0341EE, 0x341F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0D2F_0341DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0D2F_341DF:
    // MOV AL,AH (334B_0D2F / 0x341DF)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_0D31 / 0x341E1)
    AL += DH;
    State.IncCycles();
    label_334B_0D33_341E3:
    // DEC DI (334B_0D33 / 0x341E3)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // STOSB ES:DI (334B_0D34 / 0x341E4)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:41e3 (334B_0D35 / 0x341E5)
    if(--CX != 0) {
      goto label_334B_0D33_341E3;
    }
    State.IncCycles();
    // OR BP,BP (334B_0D37 / 0x341E7)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4190 (334B_0D39 / 0x341E9)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x34190 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x3000:41f6 (334B_0D3B / 0x341EB)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0D3E_0341EE, 0x341F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0D3E_0341EE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24201: goto label_334B_0D51_34201;break; // Target of external jump from 0x34195
      case 0x241F6: goto label_334B_0D46_341F6;break; // Target of external jump from 0x341DC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_0D3E_341EE:
    // STOSB ES:DI (334B_0D3E / 0x341EE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // DEC DI (334B_0D3F / 0x341EF)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // LOOP 0x3000:41ee (334B_0D40 / 0x341F0)
    if(--CX != 0) {
      goto label_334B_0D3E_341EE;
    }
    State.IncCycles();
    label_334B_0D42_341F2:
    // OR BP,BP (334B_0D42 / 0x341F2)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4190 (334B_0D44 / 0x341F4)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x34190 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_334B_0D46_341F6:
    // DEC BX (334B_0D46 / 0x341F6)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:4185 (334B_0D47 / 0x341F7)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x34185 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CLD  (334B_0D49 / 0x341F9)
    DirectionFlag = false;
    State.IncCycles();
    // MOV byte ptr CS:[0xcdd],0xc7 (334B_0D4A / 0x341FA)
    UInt8[cs2, 0xCDD] = 0xC7;
    State.IncCycles();
    // RETF  (334B_0D50 / 0x34200)
    return FarRet();
    State.IncCycles();
    label_334B_0D51_34201:
    // MOV CX,0x101 (334B_0D51 / 0x34201)
    CX = 0x101;
    State.IncCycles();
    // XOR AH,AH (334B_0D54 / 0x34204)
    AH = 0;
    State.IncCycles();
    // SUB CX,AX (334B_0D56 / 0x34206)
    CX -= AX;
    State.IncCycles();
    // SUB BP,CX (334B_0D58 / 0x34208)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // MOV AL,byte ptr [SI] (334B_0D5A / 0x3420A)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0D5C / 0x3420C)
    SI++;
    State.IncCycles();
    // SHL AX,1 (334B_0D5D / 0x3420D)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JZ 0x3000:41d4 (334B_0D5F / 0x3420F)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x341D4 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // SHL AX,1 (334B_0D61 / 0x34211)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_0D63 / 0x34213)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_0D65 / 0x34215)
    AX <<= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0D67 / 0x34217)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x3000:41df (334B_0D69 / 0x34219)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0D2F_0341DF, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // SHR AL,1 (334B_0D6B / 0x3421B)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0D6D / 0x3421D)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0D6F / 0x3421F)
    AL >>= 0x1;
    State.IncCycles();
    // ADD AL,DH (334B_0D71 / 0x34221)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // OR AH,AH (334B_0D73 / 0x34223)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x3000:41ee (334B_0D75 / 0x34225)
    if(ZeroFlag) {
      goto label_334B_0D3E_341EE;
    }
    State.IncCycles();
    // ADD AH,DH (334B_0D77 / 0x34227)
    AH += DH;
    State.IncCycles();
    // DEC DI (334B_0D79 / 0x34229)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // XCHG AL,AH (334B_0D7A / 0x3422A)
    byte tmp_334B_0D7A = AL;
    AL = AH;
    AH = tmp_334B_0D7A;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_0D7C / 0x3422C)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // INC DI (334B_0D7E / 0x3422E)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // JMP 0x3000:41f2 (334B_0D7F / 0x3422F)
    goto label_334B_0D42_341F2;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0D85_034235(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0D85_34235:
    // MOV byte ptr CS:[0x19e],CH (334B_0D85 / 0x34235)
    UInt8[cs2, 0x19E] = CH;
    State.IncCycles();
    // XOR CH,CH (334B_0D8A / 0x3423A)
    CH = 0;
    State.IncCycles();
    // AND AX,0x3ff (334B_0D8C / 0x3423C)
    // AX &= 0x3FF;
    AX = Alu.And16(AX, 0x3FF);
    State.IncCycles();
    // MOV CS:[0xd81],AX (334B_0D8F / 0x3423F)
    UInt16[cs2, 0xD81] = AX;
    State.IncCycles();
    // MOV AX,DI (334B_0D93 / 0x34243)
    AX = DI;
    State.IncCycles();
    // AND DI,0x1ff (334B_0D95 / 0x34245)
    DI &= 0x1FF;
    State.IncCycles();
    // ADD DI,0x3 (334B_0D99 / 0x34249)
    DI += 0x3;
    State.IncCycles();
    // SHR DI,1 (334B_0D9C / 0x3424C)
    DI >>= 0x1;
    State.IncCycles();
    // SHR DI,1 (334B_0D9E / 0x3424E)
    DI >>= 0x1;
    State.IncCycles();
    // SHL DI,1 (334B_0DA0 / 0x34250)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV word ptr CS:[0xdde],DI (334B_0DA2 / 0x34252)
    UInt16[cs2, 0xDDE] = DI;
    State.IncCycles();
    // MOV byte ptr CS:[0xe13],0xc7 (334B_0DA7 / 0x34257)
    UInt8[cs2, 0xE13] = 0xC7;
    State.IncCycles();
    // TEST AX,0x2000 (334B_0DAD / 0x3425D)
    Alu.And16(AX, 0x2000);
    State.IncCycles();
    // JZ 0x3000:426b (334B_0DB0 / 0x34260)
    if(ZeroFlag) {
      goto label_334B_0DBB_3426B;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0xe13],0xef (334B_0DB2 / 0x34262)
    UInt8[cs2, 0xE13] = 0xEF;
    State.IncCycles();
    // ADD BX,CX (334B_0DB8 / 0x34268)
    BX += CX;
    State.IncCycles();
    // DEC BX (334B_0DBA / 0x3426A)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    label_334B_0DBB_3426B:
    // MOV byte ptr CS:[0xe26],0x47 (334B_0DBB / 0x3426B)
    UInt8[cs2, 0xE26] = 0x47;
    State.IncCycles();
    // TEST AX,0x4000 (334B_0DC1 / 0x34271)
    Alu.And16(AX, 0x4000);
    State.IncCycles();
    // JZ 0x3000:4283 (334B_0DC4 / 0x34274)
    if(ZeroFlag) {
      goto label_334B_0DD3_34283;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0xe26],0x4f (334B_0DC6 / 0x34276)
    UInt8[cs2, 0xE26] = 0x4F;
    State.IncCycles();
    // ADD DX,word ptr CS:[0xd81] (334B_0DCC / 0x3427C)
    DX += UInt16[cs2, 0xD81];
    State.IncCycles();
    // DEC DX (334B_0DD1 / 0x34281)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // STD  (334B_0DD2 / 0x34282)
    DirectionFlag = true;
    State.IncCycles();
    label_334B_0DD3_34283:
    // CALL 0x3000:40c0 (334B_0DD3 / 0x34283)
    NearCall(cs2, 0xDD6, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_0DD6_034286(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x243A3: goto label_334B_0EF3_343A3;break; // Target of external jump from 0x34552, 0x343B1, 0x343C5
      case 0x242E5: goto label_334B_0E35_342E5;break; // Target of external jump from 0x34313, 0x34337, 0x34555, 0x342FB, 0x3432C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_0DD6_34286:
    // XOR BX,BX (334B_0DD6 / 0x34286)
    BX = 0;
    State.IncCycles();
    // MOV word ptr CS:[0xd83],BX (334B_0DD8 / 0x34288)
    UInt16[cs2, 0xD83] = BX;
    State.IncCycles();
    label_334B_0DDD_3428D:
    // Instruction bytes at index 1, 2 modified by those instruction(s): 34252
    // Instruction is modified by code, generator handled: First value group is modified
    // MOV AX,0x1234 (334B_0DDD / 0x3428D)
    AX = UInt16[cs2, 0xDDE];
    State.IncCycles();
    // PUSH SI (334B_0DE0 / 0x34290)
    Stack.Push(SI);
    State.IncCycles();
    // MUL BH (334B_0DE1 / 0x34291)
    Cpu.Mul8(BH);
    State.IncCycles();
    // ADD SI,AX (334B_0DE3 / 0x34293)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // PUSH DI (334B_0DE5 / 0x34295)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH CX (334B_0DE6 / 0x34296)
    Stack.Push(CX);
    State.IncCycles();
    // XOR DX,DX (334B_0DE7 / 0x34297)
    DX = 0;
    State.IncCycles();
    // MOV BX,SI (334B_0DE9 / 0x34299)
    BX = SI;
    State.IncCycles();
    // MOV CX,word ptr CS:[0xd81] (334B_0DEB / 0x3429B)
    CX = UInt16[cs2, 0xD81];
    State.IncCycles();
    // MOV AH,byte ptr CS:[0x19e] (334B_0DF0 / 0x342A0)
    AH = UInt8[cs2, 0x19E];
    State.IncCycles();
    label_334B_0DF5_342A5:
    // MOV AL,DH (334B_0DF5 / 0x342A5)
    AL = DH;
    State.IncCycles();
    // SHR AL,1 (334B_0DF7 / 0x342A7)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // XLAT BX (334B_0DF9 / 0x342A9)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // JNC 0x3000:42b4 (334B_0DFA / 0x342AA)
    if(!CarryFlag) {
      goto label_334B_0E04_342B4;
    }
    State.IncCycles();
    // SHR AL,1 (334B_0DFC / 0x342AC)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0DFE / 0x342AE)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0E00 / 0x342B0)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_0E02 / 0x342B2)
    AL >>= 0x1;
    State.IncCycles();
    label_334B_0E04_342B4:
    // AND AL,0xf (334B_0E04 / 0x342B4)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // JZ 0x3000:42d6 (334B_0E06 / 0x342B6)
    if(ZeroFlag) {
      goto label_334B_0E26_342D6;
    }
    State.IncCycles();
    // ADD AL,AH (334B_0E08 / 0x342B8)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    // STOSB ES:DI (334B_0E0A / 0x342BA)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DX,BP (334B_0E0B / 0x342BB)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    State.IncCycles();
    // LOOP 0x3000:42a5 (334B_0E0D / 0x342BD)
    if(--CX != 0) {
      goto label_334B_0DF5_342A5;
    }
    State.IncCycles();
    label_334B_0E0F_342BF:
    // POP CX (334B_0E0F / 0x342BF)
    CX = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_0E10 / 0x342C0)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0E11 / 0x342C1)
    SI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x140 (334B_0E12 / 0x342C2)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    // MOV BX,word ptr CS:[0xd83] (334B_0E16 / 0x342C6)
    BX = UInt16[cs2, 0xD83];
    State.IncCycles();
    // ADD BX,BP (334B_0E1B / 0x342CB)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    State.IncCycles();
    // MOV word ptr CS:[0xd83],BX (334B_0E1D / 0x342CD)
    UInt16[cs2, 0xD83] = BX;
    State.IncCycles();
    // LOOP 0x3000:428d (334B_0E22 / 0x342D2)
    if(--CX != 0) {
      goto label_334B_0DDD_3428D;
    }
    State.IncCycles();
    // CLD  (334B_0E24 / 0x342D4)
    DirectionFlag = false;
    State.IncCycles();
    // RETF  (334B_0E25 / 0x342D5)
    return FarRet();
    State.IncCycles();
    label_334B_0E26_342D6:
    // Instruction bytes at index 0 modified by those instruction(s): 34276, 3426B
    // Instruction is modified by code, generator handled: Opcode is modified
    // INC DI (334B_0E26 / 0x342D6)
    switch(UInt8[cs2, 0xE26]) {
      case 71: DI++;break;
      case 79: DI--;break;
    }
    State.IncCycles();
    // ADD DX,BP (334B_0E27 / 0x342D7)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    State.IncCycles();
    // LOOP 0x3000:42a5 (334B_0E29 / 0x342D9)
    if(--CX != 0) {
      goto label_334B_0DF5_342A5;
    }
    State.IncCycles();
    // JMP 0x3000:42bf (334B_0E2B / 0x342DB)
    goto label_334B_0E0F_342BF;
    State.IncCycles();
    label_334B_0E2D_342DD:
    // MOV BP,DX (334B_0E2D / 0x342DD)
    BP = DX;
    State.IncCycles();
    // SUB DI,BP (334B_0E2F / 0x342DF)
    DI -= BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_0E31 / 0x342E1)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_0E35_342E5:
    // LODSB SI (334B_0E35 / 0x342E5)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_0E36 / 0x342E6)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:431a (334B_0E38 / 0x342E8)
    if(SignFlag) {
      goto label_334B_0E6A_3431A;
    }
    State.IncCycles();
    // MOV CX,AX (334B_0E3A / 0x342EA)
    CX = AX;
    State.IncCycles();
    // XOR CH,CH (334B_0E3C / 0x342EC)
    CH = 0;
    State.IncCycles();
    // INC CX (334B_0E3E / 0x342EE)
    CX++;
    State.IncCycles();
    // SUB BP,CX (334B_0E3F / 0x342EF)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    label_334B_0E41_342F1:
    // LODSB SI (334B_0E41 / 0x342F1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_0E42 / 0x342F2)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:430e (334B_0E44 / 0x342F4)
    if(ZeroFlag) {
      goto label_334B_0E5E_3430E;
    }
    State.IncCycles();
    // STOSB ES:DI (334B_0E46 / 0x342F6)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:42f1 (334B_0E47 / 0x342F7)
    if(--CX != 0) {
      goto label_334B_0E41_342F1;
    }
    State.IncCycles();
    // OR BP,BP (334B_0E49 / 0x342F9)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:42e5 (334B_0E4B / 0x342FB)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E35_342E5;
    }
    State.IncCycles();
    // DEC BX (334B_0E4D / 0x342FD)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:42dd (334B_0E4E / 0x342FE)
    if(!ZeroFlag) {
      goto label_334B_0E2D_342DD;
    }
    State.IncCycles();
    label_334B_0E50_34300:
    // CLD  (334B_0E50 / 0x34300)
    DirectionFlag = false;
    State.IncCycles();
    // MOV byte ptr CS:[0xe32],0xc7 (334B_0E51 / 0x34301)
    UInt8[cs2, 0xE32] = 0xC7;
    State.IncCycles();
    // MOV byte ptr CS:[0xef0],0xc7 (334B_0E57 / 0x34307)
    UInt8[cs2, 0xEF0] = 0xC7;
    State.IncCycles();
    // RETF  (334B_0E5D / 0x3430D)
    return FarRet();
    State.IncCycles();
    label_334B_0E5E_3430E:
    // INC DI (334B_0E5E / 0x3430E)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:42f1 (334B_0E5F / 0x3430F)
    if(--CX != 0) {
      goto label_334B_0E41_342F1;
    }
    State.IncCycles();
    // OR BP,BP (334B_0E61 / 0x34311)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:42e5 (334B_0E63 / 0x34313)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E35_342E5;
    }
    State.IncCycles();
    // DEC BX (334B_0E65 / 0x34315)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:42dd (334B_0E66 / 0x34316)
    if(!ZeroFlag) {
      goto label_334B_0E2D_342DD;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0E68 / 0x34318)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0E6A_3431A:
    // MOV CX,0x101 (334B_0E6A / 0x3431A)
    CX = 0x101;
    State.IncCycles();
    // XOR AH,AH (334B_0E6D / 0x3431D)
    AH = 0;
    State.IncCycles();
    // SUB CX,AX (334B_0E6F / 0x3431F)
    CX -= AX;
    State.IncCycles();
    // SUB BP,CX (334B_0E71 / 0x34321)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // LODSB SI (334B_0E73 / 0x34323)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_0E74 / 0x34324)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:4333 (334B_0E76 / 0x34326)
    if(ZeroFlag) {
      goto label_334B_0E83_34333;
    }
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_0E78 / 0x34328)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // OR BP,BP (334B_0E7A / 0x3432A)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:42e5 (334B_0E7C / 0x3432C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E35_342E5;
    }
    State.IncCycles();
    // DEC BX (334B_0E7E / 0x3432E)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:42dd (334B_0E7F / 0x3432F)
    if(!ZeroFlag) {
      goto label_334B_0E2D_342DD;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0E81 / 0x34331)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0E83_34333:
    // ADD DI,CX (334B_0E83 / 0x34333)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // OR BP,BP (334B_0E85 / 0x34335)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:42e5 (334B_0E87 / 0x34337)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E35_342E5;
    }
    State.IncCycles();
    // DEC BX (334B_0E89 / 0x34339)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:42dd (334B_0E8A / 0x3433A)
    if(!ZeroFlag) {
      goto label_334B_0E2D_342DD;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0E8C / 0x3433C)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0E8E_3433E:
    // MOV BP,DX (334B_0E8E / 0x3433E)
    BP = DX;
    State.IncCycles();
    // ADD DI,BP (334B_0E90 / 0x34340)
    DI += BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_0E92 / 0x34342)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_0E96_34346:
    // MOV AL,byte ptr [SI] (334B_0E96 / 0x34346)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0E98 / 0x34348)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // OR AL,AL (334B_0E99 / 0x34349)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:4373 (334B_0E9B / 0x3434B)
    if(ZeroFlag) {
      goto label_334B_0EC3_34373;
    }
    State.IncCycles();
    // MOV CX,AX (334B_0E9D / 0x3434D)
    CX = AX;
    State.IncCycles();
    // XOR CH,CH (334B_0E9F / 0x3434F)
    CH = 0;
    State.IncCycles();
    // INC CX (334B_0EA1 / 0x34351)
    CX++;
    State.IncCycles();
    // SUB BP,CX (334B_0EA2 / 0x34352)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    label_334B_0EA4_34354:
    // MOV AL,byte ptr [SI] (334B_0EA4 / 0x34354)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0EA6 / 0x34356)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // OR AL,AL (334B_0EA7 / 0x34357)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:4367 (334B_0EA9 / 0x34359)
    if(ZeroFlag) {
      goto label_334B_0EB7_34367;
    }
    State.IncCycles();
    // STOSB ES:DI (334B_0EAB / 0x3435B)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4354 (334B_0EAC / 0x3435C)
    if(--CX != 0) {
      goto label_334B_0EA4_34354;
    }
    State.IncCycles();
    // OR BP,BP (334B_0EAE / 0x3435E)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4346 (334B_0EB0 / 0x34360)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E96_34346;
    }
    State.IncCycles();
    // DEC BX (334B_0EB2 / 0x34362)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:433e (334B_0EB3 / 0x34363)
    if(!ZeroFlag) {
      goto label_334B_0E8E_3433E;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0EB5 / 0x34365)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0EB7_34367:
    // DEC DI (334B_0EB7 / 0x34367)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // LOOP 0x3000:4354 (334B_0EB8 / 0x34368)
    if(--CX != 0) {
      goto label_334B_0EA4_34354;
    }
    State.IncCycles();
    // OR BP,BP (334B_0EBA / 0x3436A)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4346 (334B_0EBC / 0x3436C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E96_34346;
    }
    State.IncCycles();
    // DEC BX (334B_0EBE / 0x3436E)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:433e (334B_0EBF / 0x3436F)
    if(!ZeroFlag) {
      goto label_334B_0E8E_3433E;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0EC1 / 0x34371)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0EC3_34373:
    // MOV CX,0x101 (334B_0EC3 / 0x34373)
    CX = 0x101;
    State.IncCycles();
    // XOR AH,AH (334B_0EC6 / 0x34376)
    AH = 0;
    State.IncCycles();
    // SUB CX,AX (334B_0EC8 / 0x34378)
    CX -= AX;
    State.IncCycles();
    // SUB BP,CX (334B_0ECA / 0x3437A)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // MOV AL,byte ptr [SI] (334B_0ECC / 0x3437C)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0ECE / 0x3437E)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // OR AL,AL (334B_0ECF / 0x3437F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:438f (334B_0ED1 / 0x34381)
    if(ZeroFlag) {
      goto label_334B_0EDF_3438F;
    }
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_0ED3 / 0x34383)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // OR BP,BP (334B_0ED5 / 0x34385)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4346 (334B_0ED7 / 0x34387)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E96_34346;
    }
    State.IncCycles();
    // DEC BX (334B_0ED9 / 0x34389)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:433e (334B_0EDA / 0x3438A)
    if(!ZeroFlag) {
      goto label_334B_0E8E_3433E;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0EDC / 0x3438C)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0EDF_3438F:
    // SUB DI,CX (334B_0EDF / 0x3438F)
    // DI -= CX;
    DI = Alu.Sub16(DI, CX);
    State.IncCycles();
    // OR BP,BP (334B_0EE1 / 0x34391)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:4346 (334B_0EE3 / 0x34393)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0E96_34346;
    }
    State.IncCycles();
    // DEC BX (334B_0EE5 / 0x34395)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:433e (334B_0EE6 / 0x34396)
    if(!ZeroFlag) {
      goto label_334B_0E8E_3433E;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0EE8 / 0x34398)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0EEB_3439B:
    // MOV BP,DX (334B_0EEB / 0x3439B)
    BP = DX;
    State.IncCycles();
    // SUB DI,BP (334B_0EED / 0x3439D)
    DI -= BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_0EEF / 0x3439F)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_0EF3_343A3:
    // LODSB SI (334B_0EF3 / 0x343A3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_0EF4 / 0x343A4)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:43b9 (334B_0EF6 / 0x343A6)
    if(SignFlag) {
      goto label_334B_0F09_343B9;
    }
    State.IncCycles();
    // MOV CX,AX (334B_0EF8 / 0x343A8)
    CX = AX;
    State.IncCycles();
    // XOR CH,CH (334B_0EFA / 0x343AA)
    CH = 0;
    State.IncCycles();
    // INC CX (334B_0EFC / 0x343AC)
    CX++;
    State.IncCycles();
    // SUB BP,CX (334B_0EFD / 0x343AD)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_0EFF / 0x343AF)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // JA 0x3000:43a3 (334B_0F01 / 0x343B1)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0EF3_343A3;
    }
    State.IncCycles();
    // DEC BX (334B_0F03 / 0x343B3)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:439b (334B_0F04 / 0x343B4)
    if(!ZeroFlag) {
      goto label_334B_0EEB_3439B;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0F06 / 0x343B6)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0F09_343B9:
    // MOV CX,0x101 (334B_0F09 / 0x343B9)
    CX = 0x101;
    State.IncCycles();
    // XOR AH,AH (334B_0F0C / 0x343BC)
    AH = 0;
    State.IncCycles();
    // SUB CX,AX (334B_0F0E / 0x343BE)
    CX -= AX;
    State.IncCycles();
    // SUB BP,CX (334B_0F10 / 0x343C0)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // LODSB SI (334B_0F12 / 0x343C2)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_0F13 / 0x343C3)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // JA 0x3000:43a3 (334B_0F15 / 0x343C5)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0EF3_343A3;
    }
    State.IncCycles();
    // DEC BX (334B_0F17 / 0x343C7)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:439b (334B_0F18 / 0x343C8)
    if(!ZeroFlag) {
      goto label_334B_0EEB_3439B;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0F1A / 0x343CA)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0F1D_343CD:
    // MOV BP,DX (334B_0F1D / 0x343CD)
    BP = DX;
    State.IncCycles();
    // ADD DI,BP (334B_0F1F / 0x343CF)
    DI += BP;
    State.IncCycles();
    // ADD DI,0x140 (334B_0F21 / 0x343D1)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_0F25_343D5:
    // MOV AL,byte ptr [SI] (334B_0F25 / 0x343D5)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0F27 / 0x343D7)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // OR AL,AL (334B_0F28 / 0x343D8)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:43f3 (334B_0F2A / 0x343DA)
    if(ZeroFlag) {
      goto label_334B_0F43_343F3;
    }
    State.IncCycles();
    // MOV CX,AX (334B_0F2C / 0x343DC)
    CX = AX;
    State.IncCycles();
    // XOR CH,CH (334B_0F2E / 0x343DE)
    CH = 0;
    State.IncCycles();
    // INC CX (334B_0F30 / 0x343E0)
    CX++;
    State.IncCycles();
    // SUB BP,CX (334B_0F31 / 0x343E1)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    label_334B_0F33_343E3:
    // MOV AL,byte ptr [SI] (334B_0F33 / 0x343E3)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0F35 / 0x343E5)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // STOSB ES:DI (334B_0F36 / 0x343E6)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:43e3 (334B_0F37 / 0x343E7)
    if(--CX != 0) {
      goto label_334B_0F33_343E3;
    }
    State.IncCycles();
    // OR BP,BP (334B_0F39 / 0x343E9)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:43d5 (334B_0F3B / 0x343EB)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0F25_343D5;
    }
    State.IncCycles();
    // DEC BX (334B_0F3D / 0x343ED)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:43cd (334B_0F3E / 0x343EE)
    if(!ZeroFlag) {
      goto label_334B_0F1D_343CD;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0F40 / 0x343F0)
    goto label_334B_0E50_34300;
    State.IncCycles();
    label_334B_0F43_343F3:
    // MOV CX,0x101 (334B_0F43 / 0x343F3)
    CX = 0x101;
    State.IncCycles();
    // XOR AH,AH (334B_0F46 / 0x343F6)
    AH = 0;
    State.IncCycles();
    // SUB CX,AX (334B_0F48 / 0x343F8)
    CX -= AX;
    State.IncCycles();
    // SUB BP,CX (334B_0F4A / 0x343FA)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // MOV AL,byte ptr [SI] (334B_0F4C / 0x343FC)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (334B_0F4E / 0x343FE)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_0F4F / 0x343FF)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // OR BP,BP (334B_0F51 / 0x34401)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JA 0x3000:43d5 (334B_0F53 / 0x34403)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_0F25_343D5;
    }
    State.IncCycles();
    // DEC BX (334B_0F55 / 0x34405)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:43cd (334B_0F56 / 0x34406)
    if(!ZeroFlag) {
      goto label_334B_0F1D_343CD;
    }
    State.IncCycles();
    // JMP 0x3000:4300 (334B_0F58 / 0x34408)
    goto label_334B_0E50_34300;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0F5B_03440B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0F5B_3440B:
    // CMP CH,0xfe (334B_0F5B / 0x3440B)
    Alu.Sub8(CH, 0xFE);
    State.IncCycles();
    // JC 0x3000:4413 (334B_0F5E / 0x3440E)
    if(CarryFlag) {
      goto label_334B_0F63_34413;
    }
    State.IncCycles();
    // JMP 0x3000:44ba (334B_0F60 / 0x34410)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_100A_0344BA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_0F63_34413:
    // OR DI,DI (334B_0F63 / 0x34413)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JS 0x3000:443e (334B_0F65 / 0x34415)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0F8E_03443E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,DI (334B_0F67 / 0x34417)
    AX = DI;
    State.IncCycles();
    // MOV BP,0x100 (334B_0F69 / 0x34419)
    BP = 0x100;
    State.IncCycles();
    // TEST AX,0x6000 (334B_0F6C / 0x3441C)
    Alu.And16(AX, 0x6000);
    State.IncCycles();
    // JZ 0x3000:4424 (334B_0F6F / 0x3441F)
    if(ZeroFlag) {
      goto label_334B_0F74_34424;
    }
    State.IncCycles();
    // JMP 0x3000:4235 (334B_0F71 / 0x34421)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0D85_034235, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_0F74_34424:
    // AND AX,0x1ff (334B_0F74 / 0x34424)
    AX &= 0x1FF;
    State.IncCycles();
    // ADD AX,0x3 (334B_0F77 / 0x34427)
    AX += 0x3;
    State.IncCycles();
    // SHR AX,1 (334B_0F7A / 0x3442A)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_0F7C / 0x3442C)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV CS:[0x158b],AX (334B_0F7E / 0x3442E)
    UInt16[cs2, 0x158B] = AX;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_0F82 / 0x34432)
    NearCall(cs2, 0xF85, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0F85_034435, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_0F85_034435(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0F85_34435:
    // MOV DH,CH (334B_0F85 / 0x34435)
    DH = CH;
    State.IncCycles();
    // XOR CH,CH (334B_0F87 / 0x34437)
    CH = 0;
    State.IncCycles();
    // MOV DL,0xf (334B_0F89 / 0x34439)
    DL = 0xF;
    State.IncCycles();
    // JMP 0x3000:4a3a (334B_0F8B / 0x3443B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_158A_034A3A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0F8E_03443E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0F8E_3443E:
    // MOV AX,DI (334B_0F8E / 0x3443E)
    AX = DI;
    State.IncCycles();
    // AND AX,0x1ff (334B_0F90 / 0x34440)
    // AX &= 0x1FF;
    AX = Alu.And16(AX, 0x1FF);
    State.IncCycles();
    // MOV CS:[0xd81],AX (334B_0F93 / 0x34443)
    UInt16[cs2, 0xD81] = AX;
    State.IncCycles();
    // ADD AX,0x3 (334B_0F97 / 0x34447)
    AX += 0x3;
    State.IncCycles();
    // SHR AX,1 (334B_0F9A / 0x3444A)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_0F9C / 0x3444C)
    AX >>= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_0F9E / 0x3444E)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (334B_0FA0 / 0x34450)
    BP = AX;
    State.IncCycles();
    // MOV AX,DI (334B_0FA2 / 0x34452)
    AX = DI;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_0FA4 / 0x34454)
    NearCall(cs2, 0xFA7, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0FA7_034457, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_0FA7_034457(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0FA7_34457:
    // MOV DH,CH (334B_0FA7 / 0x34457)
    DH = CH;
    State.IncCycles();
    // XOR CH,CH (334B_0FA9 / 0x34459)
    CH = 0;
    State.IncCycles();
    // MOV DL,0xf (334B_0FAB / 0x3445B)
    DL = 0xF;
    State.IncCycles();
    // MOV BX,CX (334B_0FAD / 0x3445D)
    BX = CX;
    State.IncCycles();
    // TEST AX,0x4000 (334B_0FAF / 0x3445F)
    Alu.And16(AX, 0x4000);
    State.IncCycles();
    // JNZ 0x3000:4489 (334B_0FB2 / 0x34462)
    if(!ZeroFlag) {
      goto label_334B_0FD9_34489;
    }
    State.IncCycles();
    // MOV word ptr CS:[0xc3c],BP (334B_0FB4 / 0x34464)
    UInt16[cs2, 0xC3C] = BP;
    State.IncCycles();
    // TEST AX,0x2000 (334B_0FB9 / 0x34469)
    Alu.And16(AX, 0x2000);
    State.IncCycles();
    // JZ 0x3000:4486 (334B_0FBC / 0x3446C)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x3000:40f6 (334B_0FD6 / 0x34486)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x340F6 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0xc43],0xef (334B_0FBE / 0x3446E)
    UInt8[cs2, 0xC43] = 0xEF;
    State.IncCycles();
    // MOV AH,BL (334B_0FC4 / 0x34474)
    AH = BL;
    State.IncCycles();
    // DEC AH (334B_0FC6 / 0x34476)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // MOV CH,AH (334B_0FC8 / 0x34478)
    CH = AH;
    State.IncCycles();
    // XOR CL,CL (334B_0FCA / 0x3447A)
    CL = 0;
    State.IncCycles();
    // MOV AL,CL (334B_0FCC / 0x3447C)
    AL = CL;
    State.IncCycles();
    // SHR CX,1 (334B_0FCE / 0x3447E)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (334B_0FD0 / 0x34480)
    CX >>= 0x1;
    State.IncCycles();
    // ADD DI,AX (334B_0FD2 / 0x34482)
    DI += AX;
    State.IncCycles();
    // ADD DI,CX (334B_0FD4 / 0x34484)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    label_334B_0FD6_34486:
    // JMP 0x3000:40f6 (334B_0FD6 / 0x34486)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x340F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_0FD9_34489:
    // MOV word ptr CS:[0xcd6],BP (334B_0FD9 / 0x34489)
    UInt16[cs2, 0xCD6] = BP;
    State.IncCycles();
    // TEST AX,0x2000 (334B_0FDE / 0x3448E)
    Alu.And16(AX, 0x2000);
    State.IncCycles();
    // JZ 0x3000:44ab (334B_0FE1 / 0x34491)
    if(ZeroFlag) {
      goto label_334B_0FFB_344AB;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0xcdd],0xef (334B_0FE3 / 0x34493)
    UInt8[cs2, 0xCDD] = 0xEF;
    State.IncCycles();
    // MOV AH,BL (334B_0FE9 / 0x34499)
    AH = BL;
    State.IncCycles();
    // DEC AH (334B_0FEB / 0x3449B)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // MOV CH,AH (334B_0FED / 0x3449D)
    CH = AH;
    State.IncCycles();
    // XOR CL,CL (334B_0FEF / 0x3449F)
    CL = 0;
    State.IncCycles();
    // MOV AL,CL (334B_0FF1 / 0x344A1)
    AL = CL;
    State.IncCycles();
    // SHR CX,1 (334B_0FF3 / 0x344A3)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (334B_0FF5 / 0x344A5)
    CX >>= 0x1;
    State.IncCycles();
    // ADD DI,AX (334B_0FF7 / 0x344A7)
    DI += AX;
    State.IncCycles();
    // ADD DI,CX (334B_0FF9 / 0x344A9)
    DI += CX;
    State.IncCycles();
    label_334B_0FFB_344AB:
    // ADD DI,word ptr CS:[0xd81] (334B_0FFB / 0x344AB)
    DI += UInt16[cs2, 0xD81];
    State.IncCycles();
    // DEC DI (334B_1000 / 0x344B0)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // STD  (334B_1001 / 0x344B1)
    DirectionFlag = true;
    State.IncCycles();
    // JMP 0x3000:4190 (334B_1002 / 0x344B2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x34190 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_100A_0344BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_100A_344BA:
    // OR DI,DI (334B_100A / 0x344BA)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JS 0x3000:4514 (334B_100C / 0x344BC)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1064_034514, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BP,DI (334B_100E / 0x344BE)
    BP = DI;
    State.IncCycles();
    // AND BP,0x1ff (334B_1010 / 0x344C0)
    // BP &= 0x1FF;
    BP = Alu.And16(BP, 0x1FF);
    State.IncCycles();
    // MOV AX,DI (334B_1014 / 0x344C4)
    AX = DI;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1016 / 0x344C6)
    NearCall(cs2, 0x1019, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1019_0344C9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1019_0344C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1019_344C9:
    // MOV BX,CX (334B_1019 / 0x344C9)
    BX = CX;
    State.IncCycles();
    // XOR BH,BH (334B_101B / 0x344CB)
    BH = 0;
    State.IncCycles();
    // CMP CH,0xff (334B_101D / 0x344CD)
    Alu.Sub8(CH, 0xFF);
    State.IncCycles();
    // JZ 0x3000:44f3 (334B_1020 / 0x344D0)
    if(ZeroFlag) {
      goto label_334B_1043_344F3;
    }
    State.IncCycles();
    // SHR BP,1 (334B_1022 / 0x344D2)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // MOV AX,DI (334B_1024 / 0x344D4)
    AX = DI;
    State.IncCycles();
    // JC 0x3000:44e5 (334B_1026 / 0x344D6)
    if(CarryFlag) {
      goto label_334B_1035_344E5;
    }
    State.IncCycles();
    label_334B_1028_344D8:
    // MOV CX,BP (334B_1028 / 0x344D8)
    CX = BP;
    State.IncCycles();
    // MOV DI,AX (334B_102A / 0x344DA)
    DI = AX;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_102C / 0x344DC)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD AX,0x140 (334B_102E / 0x344DE)
    AX += 0x140;
    State.IncCycles();
    // DEC BX (334B_1031 / 0x344E1)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:44d8 (334B_1032 / 0x344E2)
    if(!ZeroFlag) {
      goto label_334B_1028_344D8;
    }
    State.IncCycles();
    // RETF  (334B_1034 / 0x344E4)
    return FarRet();
    State.IncCycles();
    label_334B_1035_344E5:
    // MOV CX,BP (334B_1035 / 0x344E5)
    CX = BP;
    State.IncCycles();
    // MOV DI,AX (334B_1037 / 0x344E7)
    DI = AX;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1039 / 0x344E9)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOVSB ES:DI,SI (334B_103B / 0x344EB)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD AX,0x140 (334B_103C / 0x344EC)
    AX += 0x140;
    State.IncCycles();
    // DEC BX (334B_103F / 0x344EF)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:44e5 (334B_1040 / 0x344F0)
    if(!ZeroFlag) {
      goto label_334B_1035_344E5;
    }
    State.IncCycles();
    // RETF  (334B_1042 / 0x344F2)
    return FarRet();
    State.IncCycles();
    label_334B_1043_344F3:
    // MOV DX,DI (334B_1043 / 0x344F3)
    DX = DI;
    State.IncCycles();
    label_334B_1045_344F5:
    // MOV CX,BP (334B_1045 / 0x344F5)
    CX = BP;
    State.IncCycles();
    // MOV DI,DX (334B_1047 / 0x344F7)
    DI = DX;
    State.IncCycles();
    label_334B_1049_344F9:
    // LODSB SI (334B_1049 / 0x344F9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_104A / 0x344FA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x3000:4509 (334B_104C / 0x344FC)
    if(ZeroFlag) {
      goto label_334B_1059_34509;
    }
    State.IncCycles();
    // STOSB ES:DI (334B_104E / 0x344FE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:44f9 (334B_104F / 0x344FF)
    if(--CX != 0) {
      goto label_334B_1049_344F9;
    }
    State.IncCycles();
    // ADD DX,0x140 (334B_1051 / 0x34501)
    DX += 0x140;
    State.IncCycles();
    // DEC BX (334B_1055 / 0x34505)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:44f5 (334B_1056 / 0x34506)
    if(!ZeroFlag) {
      goto label_334B_1045_344F5;
    }
    State.IncCycles();
    // RETF  (334B_1058 / 0x34508)
    return FarRet();
    State.IncCycles();
    label_334B_1059_34509:
    // INC DI (334B_1059 / 0x34509)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:44f9 (334B_105A / 0x3450A)
    if(--CX != 0) {
      goto label_334B_1049_344F9;
    }
    State.IncCycles();
    // ADD DX,0x140 (334B_105C / 0x3450C)
    DX += 0x140;
    State.IncCycles();
    // DEC BX (334B_1060 / 0x34510)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:44f5 (334B_1061 / 0x34511)
    if(!ZeroFlag) {
      goto label_334B_1045_344F5;
    }
    State.IncCycles();
    // RETF  (334B_1063 / 0x34513)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1064_034514(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1064_34514:
    // MOV BP,DI (334B_1064 / 0x34514)
    BP = DI;
    State.IncCycles();
    // AND BP,0x1ff (334B_1066 / 0x34516)
    // BP &= 0x1FF;
    BP = Alu.And16(BP, 0x1FF);
    State.IncCycles();
    // MOV AX,DI (334B_106A / 0x3451A)
    AX = DI;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_106C / 0x3451C)
    NearCall(cs2, 0x106F, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_106F_03451F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_106F_03451F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_106F_3451F:
    // MOV BX,CX (334B_106F / 0x3451F)
    BX = CX;
    State.IncCycles();
    // XOR BH,BH (334B_1071 / 0x34521)
    BH = 0;
    State.IncCycles();
    // TEST AX,0x4000 (334B_1073 / 0x34523)
    Alu.And16(AX, 0x4000);
    State.IncCycles();
    // JNZ 0x3000:4558 (334B_1076 / 0x34526)
    if(!ZeroFlag) {
      goto label_334B_10A8_34558;
    }
    State.IncCycles();
    // TEST AX,0x2000 (334B_1078 / 0x34528)
    Alu.And16(AX, 0x2000);
    State.IncCycles();
    // JZ 0x3000:454b (334B_107B / 0x3452B)
    if(ZeroFlag) {
      goto label_334B_109B_3454B;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0xe32],0xef (334B_107D / 0x3452D)
    UInt8[cs2, 0xE32] = 0xEF;
    State.IncCycles();
    // MOV byte ptr CS:[0xef0],0xef (334B_1083 / 0x34533)
    UInt8[cs2, 0xEF0] = 0xEF;
    State.IncCycles();
    // MOV AH,BL (334B_1089 / 0x34539)
    AH = BL;
    State.IncCycles();
    // DEC AH (334B_108B / 0x3453B)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // MOV DH,AH (334B_108D / 0x3453D)
    DH = AH;
    State.IncCycles();
    // XOR DL,DL (334B_108F / 0x3453F)
    DL = 0;
    State.IncCycles();
    // MOV AL,DL (334B_1091 / 0x34541)
    AL = DL;
    State.IncCycles();
    // SHR DX,1 (334B_1093 / 0x34543)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_1095 / 0x34545)
    DX >>= 0x1;
    State.IncCycles();
    // ADD DI,AX (334B_1097 / 0x34547)
    DI += AX;
    State.IncCycles();
    // ADD DI,DX (334B_1099 / 0x34549)
    // DI += DX;
    DI = Alu.Add16(DI, DX);
    State.IncCycles();
    label_334B_109B_3454B:
    // MOV DX,BP (334B_109B / 0x3454B)
    DX = BP;
    State.IncCycles();
    // CMP CH,0xff (334B_109D / 0x3454D)
    Alu.Sub8(CH, 0xFF);
    State.IncCycles();
    // JZ 0x3000:4555 (334B_10A0 / 0x34550)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x3000:42e5 (334B_10A5 / 0x34555)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0x342E5 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x3000:43a3 (334B_10A2 / 0x34552)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0x343A3 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_10A5_34555:
    // JMP 0x3000:42e5 (334B_10A5 / 0x34555)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0x342E5 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_10A8_34558:
    // TEST AX,0x2000 (334B_10A8 / 0x34558)
    Alu.And16(AX, 0x2000);
    State.IncCycles();
    // JZ 0x3000:457b (334B_10AB / 0x3455B)
    if(ZeroFlag) {
      goto label_334B_10CB_3457B;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0xe93],0xef (334B_10AD / 0x3455D)
    UInt8[cs2, 0xE93] = 0xEF;
    State.IncCycles();
    // MOV byte ptr CS:[0xf22],0xef (334B_10B3 / 0x34563)
    UInt8[cs2, 0xF22] = 0xEF;
    State.IncCycles();
    // MOV AH,BL (334B_10B9 / 0x34569)
    AH = BL;
    State.IncCycles();
    // DEC AH (334B_10BB / 0x3456B)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // MOV DH,AH (334B_10BD / 0x3456D)
    DH = AH;
    State.IncCycles();
    // XOR DL,DL (334B_10BF / 0x3456F)
    DL = 0;
    State.IncCycles();
    // MOV AL,DL (334B_10C1 / 0x34571)
    AL = DL;
    State.IncCycles();
    // SHR DX,1 (334B_10C3 / 0x34573)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_10C5 / 0x34575)
    DX >>= 0x1;
    State.IncCycles();
    // ADD DI,AX (334B_10C7 / 0x34577)
    DI += AX;
    State.IncCycles();
    // ADD DI,DX (334B_10C9 / 0x34579)
    DI += DX;
    State.IncCycles();
    label_334B_10CB_3457B:
    // ADD DI,BP (334B_10CB / 0x3457B)
    DI += BP;
    State.IncCycles();
    // DEC DI (334B_10CD / 0x3457D)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // STD  (334B_10CE / 0x3457E)
    DirectionFlag = true;
    State.IncCycles();
    // MOV DX,BP (334B_10CF / 0x3457F)
    DX = BP;
    State.IncCycles();
    // CMP CH,0xff (334B_10D1 / 0x34581)
    Alu.Sub8(CH, 0xFF);
    State.IncCycles();
    // JZ 0x3000:4589 (334B_10D4 / 0x34584)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x3000:4346 (334B_10D9 / 0x34589)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0x34346 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x3000:43d5 (334B_10D6 / 0x34586)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0x343D5 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_10D9_34589:
    // JMP 0x3000:4346 (334B_10D9 / 0x34589)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0DD6_034286, 0x34346 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_10E2_034592(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_10E2_34592:
    // MOV BP,word ptr CS:[0x10de] (334B_10E2 / 0x34592)
    BP = UInt16[cs2, 0x10DE];
    State.IncCycles();
    // SHR BP,1 (334B_10E7 / 0x34597)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // PUSHF  (334B_10E9 / 0x34599)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JCXZ 0x3000:45a4 (334B_10EA / 0x3459A)
    if(CX == 0) {
      goto label_334B_10F4_345A4;
    }
    State.IncCycles();
    // OR DL,DL (334B_10EC / 0x3459C)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JS 0x3000:45cd (334B_10EE / 0x3459E)
    if(SignFlag) {
      goto label_334B_111D_345CD;
    }
    State.IncCycles();
    // JMP 0x3000:45b0 (334B_10F0 / 0x345A0)
    goto label_334B_1100_345B0;
    State.IncCycles();
    label_334B_10F2_345A2:
    // ADD SI,CX (334B_10F2 / 0x345A2)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    label_334B_10F4_345A4:
    // LODSB SI (334B_10F4 / 0x345A4)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (334B_10F5 / 0x345A5)
    AH = 0;
    State.IncCycles();
    // MOV DL,AL (334B_10F7 / 0x345A7)
    DL = AL;
    State.IncCycles();
    // OR AL,AL (334B_10F9 / 0x345A9)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:45c7 (334B_10FB / 0x345AB)
    if(SignFlag) {
      goto label_334B_1117_345C7;
    }
    State.IncCycles();
    // MOV CX,AX (334B_10FD / 0x345AD)
    CX = AX;
    State.IncCycles();
    // INC CX (334B_10FF / 0x345AF)
    CX++;
    State.IncCycles();
    label_334B_1100_345B0:
    // SUB BP,CX (334B_1100 / 0x345B0)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:45a2 (334B_1102 / 0x345B2)
    if(!CarryFlag) {
      goto label_334B_10F2_345A2;
    }
    State.IncCycles();
    // ADD CX,BP (334B_1104 / 0x345B4)
    CX += BP;
    State.IncCycles();
    // ADD SI,CX (334B_1106 / 0x345B6)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // MOV CX,BP (334B_1108 / 0x345B8)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_110A / 0x345BA)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10e0] (334B_110C / 0x345BC)
    BP = UInt16[cs2, 0x10E0];
    State.IncCycles();
    // POPF  (334B_1111 / 0x345C1)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x3000:45f6 (334B_1112 / 0x345C2)
    if(!CarryFlag) {
      goto label_334B_1146_345F6;
    }
    State.IncCycles();
    // LODSB SI (334B_1114 / 0x345C4)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // JMP 0x3000:45e2 (334B_1115 / 0x345C5)
    goto label_334B_1132_345E2;
    State.IncCycles();
    label_334B_1117_345C7:
    // MOV CX,0x101 (334B_1117 / 0x345C7)
    CX = 0x101;
    State.IncCycles();
    // SUB CX,AX (334B_111A / 0x345CA)
    CX -= AX;
    State.IncCycles();
    // INC SI (334B_111C / 0x345CC)
    SI++;
    State.IncCycles();
    label_334B_111D_345CD:
    // SUB BP,CX (334B_111D / 0x345CD)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:45a4 (334B_111F / 0x345CF)
    if(!CarryFlag) {
      goto label_334B_10F4_345A4;
    }
    State.IncCycles();
    // XOR AH,AH (334B_1121 / 0x345D1)
    AH = 0;
    State.IncCycles();
    // MOV CX,BP (334B_1123 / 0x345D3)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_1125 / 0x345D5)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10e0] (334B_1127 / 0x345D7)
    BP = UInt16[cs2, 0x10E0];
    State.IncCycles();
    // POPF  (334B_112C / 0x345DC)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x3000:45f6 (334B_112D / 0x345DD)
    if(!CarryFlag) {
      goto label_334B_1146_345F6;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (334B_112F / 0x345DF)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    label_334B_1132_345E2:
    // SHR AL,1 (334B_1132 / 0x345E2)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1134 / 0x345E4)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1136 / 0x345E6)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1138 / 0x345E8)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x3000:45f1 (334B_113A / 0x345EA)
    if(ZeroFlag) {
      goto label_334B_1141_345F1;
    }
    State.IncCycles();
    // ADD AL,DH (334B_113C / 0x345EC)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // MOV byte ptr ES:[DI],AL (334B_113E / 0x345EE)
    UInt8[ES, DI] = AL;
    State.IncCycles();
    label_334B_1141_345F1:
    // INC DI (334B_1141 / 0x345F1)
    DI++;
    State.IncCycles();
    // DEC CX (334B_1142 / 0x345F2)
    CX--;
    State.IncCycles();
    // DEC BP (334B_1143 / 0x345F3)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JZ 0x3000:4634 (334B_1144 / 0x345F4)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1151_034601, 0x34634 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_334B_1146_345F6:
    // SHR BP,1 (334B_1146 / 0x345F6)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JCXZ 0x3000:4601 (334B_1148 / 0x345F8)
    if(CX == 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1151_034601, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR DL,DL (334B_114A / 0x345FA)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JNS 0x3000:460d (334B_114C / 0x345FC)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1151_034601, 0x3460D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x3000:4658 (334B_114E / 0x345FE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1151_034601, 0x34658 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1151_034601(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24658: goto label_334B_11A8_34658;break; // Target of external jump from 0x345FE
      case 0x2469E: goto label_334B_11EE_3469E;break; // Target of external jump from 0x3481E, 0x348FC
      case 0x2460D: goto label_334B_115D_3460D;break; // Target of external jump from 0x345FC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_1151_34601:
    // LODSB SI (334B_1151 / 0x34601)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (334B_1152 / 0x34602)
    AH = 0;
    State.IncCycles();
    // MOV DL,AL (334B_1154 / 0x34604)
    DL = AL;
    State.IncCycles();
    // OR AL,AL (334B_1156 / 0x34606)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:4652 (334B_1158 / 0x34608)
    if(SignFlag) {
      goto label_334B_11A2_34652;
    }
    State.IncCycles();
    // MOV CX,AX (334B_115A / 0x3460A)
    CX = AX;
    State.IncCycles();
    // INC CX (334B_115C / 0x3460C)
    CX++;
    State.IncCycles();
    label_334B_115D_3460D:
    // SUB BP,CX (334B_115D / 0x3460D)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:4615 (334B_115F / 0x3460F)
    if(!CarryFlag) {
      goto label_334B_1165_34615;
    }
    State.IncCycles();
    // ADD CX,BP (334B_1161 / 0x34611)
    // CX += BP;
    CX = Alu.Add16(CX, BP);
    State.IncCycles();
    // JZ 0x3000:4630 (334B_1163 / 0x34613)
    if(ZeroFlag) {
      goto label_334B_1180_34630;
    }
    State.IncCycles();
    label_334B_1165_34615:
    // LODSB SI (334B_1165 / 0x34615)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,AL (334B_1166 / 0x34616)
    AH = AL;
    State.IncCycles();
    // AND AL,0xf (334B_1168 / 0x34618)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // JZ 0x3000:4648 (334B_116A / 0x3461A)
    if(ZeroFlag) {
      goto label_334B_1198_34648;
    }
    State.IncCycles();
    // ADD AL,DH (334B_116C / 0x3461C)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_116E / 0x3461E)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SHR AH,1 (334B_116F / 0x3461F)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_1171_34621:
    // SHR AH,1 (334B_1171 / 0x34621)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_1173 / 0x34623)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_1175 / 0x34625)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:464d (334B_1177 / 0x34627)
    if(ZeroFlag) {
      goto label_334B_119D_3464D;
    }
    State.IncCycles();
    // MOV AL,AH (334B_1179 / 0x34629)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_117B / 0x3462B)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_117D / 0x3462D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4615 (334B_117E / 0x3462E)
    if(--CX != 0) {
      goto label_334B_1165_34615;
    }
    State.IncCycles();
    label_334B_1180_34630:
    // OR BP,BP (334B_1180 / 0x34630)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JNS 0x3000:4601 (334B_1182 / 0x34632)
    if(!SignFlag) {
      goto label_334B_1151_34601;
    }
    State.IncCycles();
    label_334B_1184_34634:
    // MOV CX,BP (334B_1184 / 0x34634)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_1186 / 0x34636)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // SUB DI,word ptr CS:[0x10e0] (334B_1188 / 0x34638)
    DI -= UInt16[cs2, 0x10E0];
    State.IncCycles();
    // ADD DI,0x140 (334B_118D / 0x3463D)
    DI += 0x140;
    State.IncCycles();
    // DEC BX (334B_1191 / 0x34641)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JZ 0x3000:4647 (334B_1192 / 0x34642)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1197 / 0x34647)
      return FarRet();
    }
    State.IncCycles();
    // JMP 0x3000:4592 (334B_1194 / 0x34644)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_10E2_034592, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1197_34647:
    // RETF  (334B_1197 / 0x34647)
    return FarRet();
    State.IncCycles();
    label_334B_1198_34648:
    // INC DI (334B_1198 / 0x34648)
    DI++;
    State.IncCycles();
    // SHR AH,1 (334B_1199 / 0x34649)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JNZ 0x3000:4621 (334B_119B / 0x3464B)
    if(!ZeroFlag) {
      goto label_334B_1171_34621;
    }
    State.IncCycles();
    label_334B_119D_3464D:
    // INC DI (334B_119D / 0x3464D)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:4615 (334B_119E / 0x3464E)
    if(--CX != 0) {
      goto label_334B_1165_34615;
    }
    State.IncCycles();
    // JMP 0x3000:4630 (334B_11A0 / 0x34650)
    goto label_334B_1180_34630;
    State.IncCycles();
    label_334B_11A2_34652:
    // MOV CX,0x101 (334B_11A2 / 0x34652)
    CX = 0x101;
    State.IncCycles();
    // SUB CX,AX (334B_11A5 / 0x34655)
    CX -= AX;
    State.IncCycles();
    // INC SI (334B_11A7 / 0x34657)
    SI++;
    State.IncCycles();
    label_334B_11A8_34658:
    // SUB BP,CX (334B_11A8 / 0x34658)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:4660 (334B_11AA / 0x3465A)
    if(!CarryFlag) {
      goto label_334B_11B0_34660;
    }
    State.IncCycles();
    // ADD CX,BP (334B_11AC / 0x3465C)
    // CX += BP;
    CX = Alu.Add16(CX, BP);
    State.IncCycles();
    // JZ 0x3000:4681 (334B_11AE / 0x3465E)
    if(ZeroFlag) {
      goto label_334B_11D1_34681;
    }
    State.IncCycles();
    label_334B_11B0_34660:
    // MOV AL,byte ptr [SI + -0x1] (334B_11B0 / 0x34660)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // SHL AX,1 (334B_11B3 / 0x34663)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JZ 0x3000:4688 (334B_11B5 / 0x34665)
    if(ZeroFlag) {
      goto label_334B_11D8_34688;
    }
    State.IncCycles();
    // SHL AX,1 (334B_11B7 / 0x34667)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_11B9 / 0x34669)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_11BB / 0x3466B)
    AX <<= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_11BD / 0x3466D)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x3000:468e (334B_11BF / 0x3466F)
    if(ZeroFlag) {
      goto label_334B_11DE_3468E;
    }
    State.IncCycles();
    // SHR AL,1 (334B_11C1 / 0x34671)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_11C3 / 0x34673)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_11C5 / 0x34675)
    AL >>= 0x1;
    State.IncCycles();
    // ADD AL,DH (334B_11C7 / 0x34677)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // OR AH,AH (334B_11C9 / 0x34679)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x3000:4698 (334B_11CB / 0x3467B)
    if(ZeroFlag) {
      goto label_334B_11E8_34698;
    }
    State.IncCycles();
    // ADD AH,DH (334B_11CD / 0x3467D)
    // AH += DH;
    AH = Alu.Add8(AH, DH);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_11CF / 0x3467F)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    label_334B_11D1_34681:
    // OR BP,BP (334B_11D1 / 0x34681)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JS 0x3000:4634 (334B_11D3 / 0x34683)
    if(SignFlag) {
      goto label_334B_1184_34634;
    }
    State.IncCycles();
    // JMP 0x3000:4601 (334B_11D5 / 0x34685)
    goto label_334B_1151_34601;
    State.IncCycles();
    label_334B_11D8_34688:
    // SHL CX,1 (334B_11D8 / 0x34688)
    CX <<= 0x1;
    State.IncCycles();
    // ADD DI,CX (334B_11DA / 0x3468A)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // JMP 0x3000:4681 (334B_11DC / 0x3468C)
    goto label_334B_11D1_34681;
    State.IncCycles();
    label_334B_11DE_3468E:
    // MOV AL,AH (334B_11DE / 0x3468E)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_11E0 / 0x34690)
    AL += DH;
    State.IncCycles();
    label_334B_11E2_34692:
    // INC DI (334B_11E2 / 0x34692)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // STOSB ES:DI (334B_11E3 / 0x34693)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4692 (334B_11E4 / 0x34694)
    if(--CX != 0) {
      goto label_334B_11E2_34692;
    }
    State.IncCycles();
    // JMP 0x3000:4681 (334B_11E6 / 0x34696)
    goto label_334B_11D1_34681;
    State.IncCycles();
    label_334B_11E8_34698:
    // STOSB ES:DI (334B_11E8 / 0x34698)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC DI (334B_11E9 / 0x34699)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:4698 (334B_11EA / 0x3469A)
    if(--CX != 0) {
      goto label_334B_11E8_34698;
    }
    State.IncCycles();
    // JMP 0x3000:4681 (334B_11EC / 0x3469C)
    goto label_334B_11D1_34681;
    State.IncCycles();
    label_334B_11EE_3469E:
    // MOV BP,word ptr CS:[0x10de] (334B_11EE / 0x3469E)
    BP = UInt16[cs2, 0x10DE];
    State.IncCycles();
    // OR BP,BP (334B_11F3 / 0x346A3)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JNZ 0x3000:46af (334B_11F5 / 0x346A5)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_11FF_0346AF, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10e0] (334B_11F7 / 0x346A7)
    BP = UInt16[cs2, 0x10E0];
    State.IncCycles();
    // JMP 0x3000:4716 (334B_11FC / 0x346AC)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_11FF_0346AF, 0x34716 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_11FF_0346AF(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24716: goto label_334B_1266_34716;break; // Target of external jump from 0x346F5, 0x346DA, 0x346AC, 0x3470C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_11FF_346AF:
    // SHR BP,1 (334B_11FF / 0x346AF)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // PUSHF  (334B_1201 / 0x346B1)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JCXZ 0x3000:46bc (334B_1202 / 0x346B2)
    if(CX == 0) {
      goto label_334B_120C_346BC;
    }
    State.IncCycles();
    // OR DL,DL (334B_1204 / 0x346B4)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JS 0x3000:46e5 (334B_1206 / 0x346B6)
    if(SignFlag) {
      goto label_334B_1235_346E5;
    }
    State.IncCycles();
    // JMP 0x3000:46c8 (334B_1208 / 0x346B8)
    goto label_334B_1218_346C8;
    State.IncCycles();
    label_334B_120A_346BA:
    // ADD SI,CX (334B_120A / 0x346BA)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    label_334B_120C_346BC:
    // LODSB SI (334B_120C / 0x346BC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (334B_120D / 0x346BD)
    AH = 0;
    State.IncCycles();
    // MOV DL,AL (334B_120F / 0x346BF)
    DL = AL;
    State.IncCycles();
    // OR AL,AL (334B_1211 / 0x346C1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:46df (334B_1213 / 0x346C3)
    if(SignFlag) {
      goto label_334B_122F_346DF;
    }
    State.IncCycles();
    // MOV CX,AX (334B_1215 / 0x346C5)
    CX = AX;
    State.IncCycles();
    // INC CX (334B_1217 / 0x346C7)
    CX++;
    State.IncCycles();
    label_334B_1218_346C8:
    // SUB BP,CX (334B_1218 / 0x346C8)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:46ba (334B_121A / 0x346CA)
    if(!CarryFlag) {
      goto label_334B_120A_346BA;
    }
    State.IncCycles();
    // ADD CX,BP (334B_121C / 0x346CC)
    CX += BP;
    State.IncCycles();
    // ADD SI,CX (334B_121E / 0x346CE)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // MOV CX,BP (334B_1220 / 0x346D0)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_1222 / 0x346D2)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10e0] (334B_1224 / 0x346D4)
    BP = UInt16[cs2, 0x10E0];
    State.IncCycles();
    // POPF  (334B_1229 / 0x346D9)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x3000:4716 (334B_122A / 0x346DA)
    if(!CarryFlag) {
      goto label_334B_1266_34716;
    }
    State.IncCycles();
    // LODSB SI (334B_122C / 0x346DC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // JMP 0x3000:46fa (334B_122D / 0x346DD)
    goto label_334B_124A_346FA;
    State.IncCycles();
    label_334B_122F_346DF:
    // MOV CX,0x101 (334B_122F / 0x346DF)
    CX = 0x101;
    State.IncCycles();
    // SUB CX,AX (334B_1232 / 0x346E2)
    CX -= AX;
    State.IncCycles();
    // INC SI (334B_1234 / 0x346E4)
    SI++;
    State.IncCycles();
    label_334B_1235_346E5:
    // SUB BP,CX (334B_1235 / 0x346E5)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:46bc (334B_1237 / 0x346E7)
    if(!CarryFlag) {
      goto label_334B_120C_346BC;
    }
    State.IncCycles();
    // XOR AH,AH (334B_1239 / 0x346E9)
    AH = 0;
    State.IncCycles();
    // MOV CX,BP (334B_123B / 0x346EB)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_123D / 0x346ED)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10e0] (334B_123F / 0x346EF)
    BP = UInt16[cs2, 0x10E0];
    State.IncCycles();
    // POPF  (334B_1244 / 0x346F4)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x3000:4716 (334B_1245 / 0x346F5)
    if(!CarryFlag) {
      goto label_334B_1266_34716;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (334B_1247 / 0x346F7)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    label_334B_124A_346FA:
    // SHR AL,1 (334B_124A / 0x346FA)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_124C / 0x346FC)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_124E / 0x346FE)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1250 / 0x34700)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x3000:4709 (334B_1252 / 0x34702)
    if(ZeroFlag) {
      goto label_334B_1259_34709;
    }
    State.IncCycles();
    // ADD AL,DH (334B_1254 / 0x34704)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // MOV byte ptr ES:[DI],AL (334B_1256 / 0x34706)
    UInt8[ES, DI] = AL;
    State.IncCycles();
    label_334B_1259_34709:
    // INC DI (334B_1259 / 0x34709)
    DI++;
    State.IncCycles();
    // DEC CX (334B_125A / 0x3470A)
    CX--;
    State.IncCycles();
    // DEC BP (334B_125B / 0x3470B)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x3000:4716 (334B_125C / 0x3470C)
    if(!ZeroFlag) {
      goto label_334B_1266_34716;
    }
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10dc] (334B_125E / 0x3470E)
    BP = UInt16[cs2, 0x10DC];
    State.IncCycles();
    // JMP 0x3000:47dc (334B_1263 / 0x34713)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0x347DC - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1266_34716:
    // SHR BP,1 (334B_1266 / 0x34716)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // PUSHF  (334B_1268 / 0x34718)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JCXZ 0x3000:4722 (334B_1269 / 0x34719)
    if(CX == 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1272_034722, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR DL,DL (334B_126B / 0x3471B)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JNS 0x3000:472e (334B_126D / 0x3471D)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1272_034722, 0x3472E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x3000:4777 (334B_126F / 0x3471F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0x34777 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1272_034722(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24742: goto label_334B_1292_34742;break; // Target of external jump from 0x3476A
      case 0x24751: goto label_334B_12A1_34751;break; // Target of external jump from 0x34734, 0x3476F
      case 0x24736: goto label_334B_1286_34736;break; // Target of external jump from 0x34730, 0x3474F, 0x3476D
      case 0x2472E: goto label_334B_127E_3472E;break; // Target of external jump from 0x3471D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_1272_34722:
    // LODSB SI (334B_1272 / 0x34722)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (334B_1273 / 0x34723)
    AH = 0;
    State.IncCycles();
    // MOV DL,AL (334B_1275 / 0x34725)
    DL = AL;
    State.IncCycles();
    // OR AL,AL (334B_1277 / 0x34727)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:4771 (334B_1279 / 0x34729)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0x34771 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,AX (334B_127B / 0x3472B)
    CX = AX;
    State.IncCycles();
    // INC CX (334B_127D / 0x3472D)
    CX++;
    State.IncCycles();
    label_334B_127E_3472E:
    // SUB BP,CX (334B_127E / 0x3472E)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:4736 (334B_1280 / 0x34730)
    if(!CarryFlag) {
      goto label_334B_1286_34736;
    }
    State.IncCycles();
    // ADD CX,BP (334B_1282 / 0x34732)
    // CX += BP;
    CX = Alu.Add16(CX, BP);
    State.IncCycles();
    // JZ 0x3000:4751 (334B_1284 / 0x34734)
    if(ZeroFlag) {
      goto label_334B_12A1_34751;
    }
    State.IncCycles();
    label_334B_1286_34736:
    // LODSB SI (334B_1286 / 0x34736)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,AL (334B_1287 / 0x34737)
    AH = AL;
    State.IncCycles();
    // AND AL,0xf (334B_1289 / 0x34739)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // JZ 0x3000:4767 (334B_128B / 0x3473B)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD AL,DH (334B_128D / 0x3473D)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_128F / 0x3473F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SHR AH,1 (334B_1290 / 0x34740)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_1292_34742:
    // SHR AH,1 (334B_1292 / 0x34742)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_1294 / 0x34744)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_1296 / 0x34746)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:476c (334B_1298 / 0x34748)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0x3476C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,AH (334B_129A / 0x3474A)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_129C / 0x3474C)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_129E / 0x3474E)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:4736 (334B_129F / 0x3474F)
    if(--CX != 0) {
      goto label_334B_1286_34736;
    }
    State.IncCycles();
    label_334B_12A1_34751:
    // OR BP,BP (334B_12A1 / 0x34751)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JNS 0x3000:4722 (334B_12A3 / 0x34753)
    if(!SignFlag) {
      goto label_334B_1272_34722;
    }
    State.IncCycles();
    // MOV CX,BP (334B_12A5 / 0x34755)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_12A7 / 0x34757)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10dc] (334B_12A9 / 0x34759)
    BP = UInt16[cs2, 0x10DC];
    State.IncCycles();
    // XOR AH,AH (334B_12AE / 0x3475E)
    AH = 0;
    State.IncCycles();
    // POPF  (334B_12B0 / 0x34760)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x3000:47dc (334B_12B1 / 0x34761)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0x347DC - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // LODSB SI (334B_12B3 / 0x34763)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // JMP 0x3000:47ce (334B_12B4 / 0x34764)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_12B7_034767, 0x347CE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_12B7_034767(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24771: goto label_334B_12C1_34771;break; // Target of external jump from 0x34729
      case 0x24777: goto label_334B_12C7_34777;break; // Target of external jump from 0x3471F
      case 0x247CE: goto label_334B_131E_347CE;break; // Target of external jump from 0x34764
      case 0x2476C: goto label_334B_12BC_3476C;break; // Target of external jump from 0x34748
      case 0x247DC: goto label_334B_132C_347DC;break; // Target of external jump from 0x34761, 0x347C9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_12B7_34767:
    // INC DI (334B_12B7 / 0x34767)
    DI++;
    State.IncCycles();
    // SHR AH,1 (334B_12B8 / 0x34768)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JNZ 0x3000:4742 (334B_12BA / 0x3476A)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1272_034722, 0x34742 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_334B_12BC_3476C:
    // INC DI (334B_12BC / 0x3476C)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:4736 (334B_12BD / 0x3476D)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1272_034722, 0x34736 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x3000:4751 (334B_12BF / 0x3476F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1272_034722, 0x34751 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_12C1_34771:
    // MOV CX,0x101 (334B_12C1 / 0x34771)
    CX = 0x101;
    State.IncCycles();
    // SUB CX,AX (334B_12C4 / 0x34774)
    CX -= AX;
    State.IncCycles();
    // INC SI (334B_12C6 / 0x34776)
    SI++;
    State.IncCycles();
    label_334B_12C7_34777:
    // SUB BP,CX (334B_12C7 / 0x34777)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:477f (334B_12C9 / 0x34779)
    if(!CarryFlag) {
      goto label_334B_12CF_3477F;
    }
    State.IncCycles();
    // ADD CX,BP (334B_12CB / 0x3477B)
    // CX += BP;
    CX = Alu.Add16(CX, BP);
    State.IncCycles();
    // JZ 0x3000:47b6 (334B_12CD / 0x3477D)
    if(ZeroFlag) {
      goto label_334B_1306_347B6;
    }
    State.IncCycles();
    label_334B_12CF_3477F:
    // MOV AL,byte ptr [SI + -0x1] (334B_12CF / 0x3477F)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // SHL AX,1 (334B_12D2 / 0x34782)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JZ 0x3000:47a2 (334B_12D4 / 0x34784)
    if(ZeroFlag) {
      goto label_334B_12F2_347A2;
    }
    State.IncCycles();
    // SHL AX,1 (334B_12D6 / 0x34786)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_12D8 / 0x34788)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (334B_12DA / 0x3478A)
    AX <<= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_12DC / 0x3478C)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x3000:47a8 (334B_12DE / 0x3478E)
    if(ZeroFlag) {
      goto label_334B_12F8_347A8;
    }
    State.IncCycles();
    // SHR AL,1 (334B_12E0 / 0x34790)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_12E2 / 0x34792)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_12E4 / 0x34794)
    AL >>= 0x1;
    State.IncCycles();
    // ADD AL,DH (334B_12E6 / 0x34796)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // OR AH,AH (334B_12E8 / 0x34798)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x3000:47b2 (334B_12EA / 0x3479A)
    if(ZeroFlag) {
      goto label_334B_1302_347B2;
    }
    State.IncCycles();
    // ADD AH,DH (334B_12EC / 0x3479C)
    // AH += DH;
    AH = Alu.Add8(AH, DH);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_12EE / 0x3479E)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // JMP 0x3000:47b6 (334B_12F0 / 0x347A0)
    goto label_334B_1306_347B6;
    State.IncCycles();
    label_334B_12F2_347A2:
    // SHL CX,1 (334B_12F2 / 0x347A2)
    CX <<= 0x1;
    State.IncCycles();
    // ADD DI,CX (334B_12F4 / 0x347A4)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // JMP 0x3000:47b6 (334B_12F6 / 0x347A6)
    goto label_334B_1306_347B6;
    State.IncCycles();
    label_334B_12F8_347A8:
    // MOV AL,AH (334B_12F8 / 0x347A8)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_12FA / 0x347AA)
    AL += DH;
    State.IncCycles();
    label_334B_12FC_347AC:
    // INC DI (334B_12FC / 0x347AC)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // STOSB ES:DI (334B_12FD / 0x347AD)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:47ac (334B_12FE / 0x347AE)
    if(--CX != 0) {
      goto label_334B_12FC_347AC;
    }
    State.IncCycles();
    // JMP 0x3000:47b6 (334B_1300 / 0x347B0)
    goto label_334B_1306_347B6;
    State.IncCycles();
    label_334B_1302_347B2:
    // STOSB ES:DI (334B_1302 / 0x347B2)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC DI (334B_1303 / 0x347B3)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:47b2 (334B_1304 / 0x347B4)
    if(--CX != 0) {
      goto label_334B_1302_347B2;
    }
    State.IncCycles();
    label_334B_1306_347B6:
    // OR BP,BP (334B_1306 / 0x347B6)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JS 0x3000:47bd (334B_1308 / 0x347B8)
    if(SignFlag) {
      goto label_334B_130D_347BD;
    }
    State.IncCycles();
    // JMP 0x3000:4722 (334B_130A / 0x347BA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1272_034722, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_130D_347BD:
    // XOR AH,AH (334B_130D / 0x347BD)
    AH = 0;
    State.IncCycles();
    // MOV CX,BP (334B_130F / 0x347BF)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_1311 / 0x347C1)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV BP,word ptr CS:[0x10dc] (334B_1313 / 0x347C3)
    BP = UInt16[cs2, 0x10DC];
    State.IncCycles();
    // POPF  (334B_1318 / 0x347C8)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x3000:47dc (334B_1319 / 0x347C9)
    if(!CarryFlag) {
      goto label_334B_132C_347DC;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (334B_131B / 0x347CB)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    label_334B_131E_347CE:
    // AND AL,0xf (334B_131E / 0x347CE)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // JZ 0x3000:47d7 (334B_1320 / 0x347D0)
    if(ZeroFlag) {
      goto label_334B_1327_347D7;
    }
    State.IncCycles();
    // ADD AL,DH (334B_1322 / 0x347D2)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // MOV byte ptr ES:[DI],AL (334B_1324 / 0x347D4)
    UInt8[ES, DI] = AL;
    State.IncCycles();
    label_334B_1327_347D7:
    // INC DI (334B_1327 / 0x347D7)
    DI++;
    State.IncCycles();
    // DEC CX (334B_1328 / 0x347D8)
    CX--;
    State.IncCycles();
    // DEC BP (334B_1329 / 0x347D9)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JZ 0x3000:4812 (334B_132A / 0x347DA)
    if(ZeroFlag) {
      goto label_334B_1362_34812;
    }
    State.IncCycles();
    label_334B_132C_347DC:
    // SHR BP,1 (334B_132C / 0x347DC)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JCXZ 0x3000:47e8 (334B_132E / 0x347DE)
    if(CX == 0) {
      goto label_334B_1338_347E8;
    }
    State.IncCycles();
    // OR DL,DL (334B_1330 / 0x347E0)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JS 0x3000:4808 (334B_1332 / 0x347E2)
    if(SignFlag) {
      goto label_334B_1358_34808;
    }
    State.IncCycles();
    // JMP 0x3000:47f4 (334B_1334 / 0x347E4)
    goto label_334B_1344_347F4;
    State.IncCycles();
    label_334B_1336_347E6:
    // ADD SI,CX (334B_1336 / 0x347E6)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    label_334B_1338_347E8:
    // LODSB SI (334B_1338 / 0x347E8)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (334B_1339 / 0x347E9)
    AH = 0;
    State.IncCycles();
    // MOV DL,AL (334B_133B / 0x347EB)
    DL = AL;
    State.IncCycles();
    // OR AL,AL (334B_133D / 0x347ED)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:4802 (334B_133F / 0x347EF)
    if(SignFlag) {
      goto label_334B_1352_34802;
    }
    State.IncCycles();
    // MOV CX,AX (334B_1341 / 0x347F1)
    CX = AX;
    State.IncCycles();
    // INC CX (334B_1343 / 0x347F3)
    CX++;
    State.IncCycles();
    label_334B_1344_347F4:
    // SUB BP,CX (334B_1344 / 0x347F4)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:47e6 (334B_1346 / 0x347F6)
    if(!CarryFlag) {
      goto label_334B_1336_347E6;
    }
    State.IncCycles();
    // ADD CX,BP (334B_1348 / 0x347F8)
    CX += BP;
    State.IncCycles();
    // ADD SI,CX (334B_134A / 0x347FA)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // MOV CX,BP (334B_134C / 0x347FC)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_134E / 0x347FE)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // JMP 0x3000:4812 (334B_1350 / 0x34800)
    goto label_334B_1362_34812;
    State.IncCycles();
    label_334B_1352_34802:
    // MOV CX,0x101 (334B_1352 / 0x34802)
    CX = 0x101;
    State.IncCycles();
    // SUB CX,AX (334B_1355 / 0x34805)
    CX -= AX;
    State.IncCycles();
    // INC SI (334B_1357 / 0x34807)
    SI++;
    State.IncCycles();
    label_334B_1358_34808:
    // SUB BP,CX (334B_1358 / 0x34808)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNC 0x3000:47e8 (334B_135A / 0x3480A)
    if(!CarryFlag) {
      goto label_334B_1338_347E8;
    }
    State.IncCycles();
    // XOR AH,AH (334B_135C / 0x3480C)
    AH = 0;
    State.IncCycles();
    // MOV CX,BP (334B_135E / 0x3480E)
    CX = BP;
    State.IncCycles();
    // NEG CX (334B_1360 / 0x34810)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_334B_1362_34812:
    // SUB DI,word ptr CS:[0x10e0] (334B_1362 / 0x34812)
    DI -= UInt16[cs2, 0x10E0];
    State.IncCycles();
    // ADD DI,0x140 (334B_1367 / 0x34817)
    DI += 0x140;
    State.IncCycles();
    // DEC BX (334B_136B / 0x3481B)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JZ 0x3000:4821 (334B_136C / 0x3481C)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_1371 / 0x34821)
      return FarRet();
    }
    State.IncCycles();
    // JMP 0x3000:469e (334B_136E / 0x3481E)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1151_034601, 0x3469E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1371_34821:
    // RETF  (334B_1371 / 0x34821)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1372_034822(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1372_34822:
    // MOV AL,byte ptr [SI + -0x1] (334B_1372 / 0x34822)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // MOV CS:[0x19e],AL (334B_1375 / 0x34825)
    UInt8[cs2, 0x19E] = AL;
    State.IncCycles();
    // AND DI,0x1fff (334B_1379 / 0x34829)
    // DI &= 0x1FFF;
    DI = Alu.And16(DI, 0x1FFF);
    State.IncCycles();
    // MOV word ptr CS:[0x158b],DI (334B_137D / 0x3482D)
    UInt16[cs2, 0x158B] = DI;
    State.IncCycles();
    // ADD DI,0x3 (334B_1382 / 0x34832)
    DI += 0x3;
    State.IncCycles();
    // SHR DI,1 (334B_1385 / 0x34835)
    DI >>= 0x1;
    State.IncCycles();
    // SHR DI,1 (334B_1387 / 0x34837)
    DI >>= 0x1;
    State.IncCycles();
    // SHL DI,1 (334B_1389 / 0x34839)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (334B_138B / 0x3483B)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // SUB AX,BX (334B_138E / 0x3483E)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JLE 0x3000:486e (334B_1390 / 0x34840)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_13BE_3486E;
    }
    State.IncCycles();
    // SUB CX,AX (334B_1392 / 0x34842)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x3000:48a1 (334B_1394 / 0x34844)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_13F1 / 0x348A1)
      return FarRet();
    }
    State.IncCycles();
    // ADD BX,AX (334B_1396 / 0x34846)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // PUSH DX (334B_1398 / 0x34848)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH CX (334B_1399 / 0x34849)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH BP (334B_139A / 0x3484A)
    Stack.Push(BP);
    State.IncCycles();
    // MUL DI (334B_139B / 0x3484B)
    Cpu.Mul16(DI);
    State.IncCycles();
    // MOV BP,AX (334B_139D / 0x3484D)
    BP = AX;
    State.IncCycles();
    // XOR AH,AH (334B_139F / 0x3484F)
    AH = 0;
    State.IncCycles();
    label_334B_13A1_34851:
    // LODSB SI (334B_13A1 / 0x34851)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (334B_13A2 / 0x34852)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x3000:4861 (334B_13A4 / 0x34854)
    if(SignFlag) {
      goto label_334B_13B1_34861;
    }
    State.IncCycles();
    // MOV CX,AX (334B_13A6 / 0x34856)
    CX = AX;
    State.IncCycles();
    // INC CX (334B_13A8 / 0x34858)
    CX++;
    State.IncCycles();
    // ADD SI,CX (334B_13A9 / 0x34859)
    SI += CX;
    State.IncCycles();
    // SUB BP,CX (334B_13AB / 0x3485B)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNZ 0x3000:4851 (334B_13AD / 0x3485D)
    if(!ZeroFlag) {
      goto label_334B_13A1_34851;
    }
    State.IncCycles();
    // JMP 0x3000:486b (334B_13AF / 0x3485F)
    goto label_334B_13BB_3486B;
    State.IncCycles();
    label_334B_13B1_34861:
    // MOV CX,0x101 (334B_13B1 / 0x34861)
    CX = 0x101;
    State.IncCycles();
    // SUB CX,AX (334B_13B4 / 0x34864)
    CX -= AX;
    State.IncCycles();
    // INC SI (334B_13B6 / 0x34866)
    SI++;
    State.IncCycles();
    // SUB BP,CX (334B_13B7 / 0x34867)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    State.IncCycles();
    // JNZ 0x3000:4851 (334B_13B9 / 0x34869)
    if(!ZeroFlag) {
      goto label_334B_13A1_34851;
    }
    State.IncCycles();
    label_334B_13BB_3486B:
    // POP BP (334B_13BB / 0x3486B)
    BP = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_13BC / 0x3486C)
    CX = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_13BD / 0x3486D)
    DX = Stack.Pop();
    State.IncCycles();
    label_334B_13BE_3486E:
    // MOV AX,BX (334B_13BE / 0x3486E)
    AX = BX;
    State.IncCycles();
    // ADD AX,CX (334B_13C0 / 0x34870)
    AX += CX;
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x6] (334B_13C2 / 0x34872)
    // AX -= UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    State.IncCycles();
    // JBE 0x3000:487b (334B_13C5 / 0x34875)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_13CB_3487B;
    }
    State.IncCycles();
    // SUB CX,AX (334B_13C7 / 0x34877)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x3000:48a1 (334B_13C9 / 0x34879)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_13F1 / 0x348A1)
      return FarRet();
    }
    State.IncCycles();
    label_334B_13CB_3487B:
    // MOV AX,DX (334B_13CB / 0x3487B)
    AX = DX;
    State.IncCycles();
    // ADD AX,DI (334B_13CD / 0x3487D)
    AX += DI;
    State.IncCycles();
    // ADD AX,DI (334B_13CF / 0x3487F)
    AX += DI;
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x4] (334B_13D1 / 0x34881)
    // AX -= UInt16[SS, (ushort)(BP + 0x4)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x4)]);
    State.IncCycles();
    // JG 0x3000:48c9 (334B_13D4 / 0x34884)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1419_0348C9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_13D6 / 0x34886)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,DX (334B_13D9 / 0x34889)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JG 0x3000:48a2 (334B_13DB / 0x3488B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_13F1_0348A1, 0x348A2 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr CS:[0xc3c],DI (334B_13DD / 0x3488D)
    UInt16[cs2, 0xC3C] = DI;
    State.IncCycles();
    // MOV BP,DI (334B_13E2 / 0x34892)
    BP = DI;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_13E4 / 0x34894)
    NearCall(cs2, 0x13E7, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_13E7_034897, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_13E7_034897(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_13E7_34897:
    // MOV BX,CX (334B_13E7 / 0x34897)
    BX = CX;
    State.IncCycles();
    // MOV DX,word ptr CS:[0x19d] (334B_13E9 / 0x34899)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // JMP 0x3000:40f6 (334B_13EE / 0x3489E)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0C3B_0340EB, 0x340F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_13F1_0348A1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x248A2: goto label_334B_13F2_348A2;break; // Target of external jump from 0x3488B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_13F1_348A1:
    // RETF  (334B_13F1 / 0x348A1)
    return FarRet();
    State.IncCycles();
    label_334B_13F2_348A2:
    // CMP AX,word ptr CS:[0x158b] (334B_13F2 / 0x348A2)
    Alu.Sub16(AX, UInt16[cs2, 0x158B]);
    State.IncCycles();
    // JNC 0x3000:48a1 (334B_13F7 / 0x348A7)
    if(!CarryFlag) {
      // JNC target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_13F1 / 0x348A1)
      return FarRet();
    }
    State.IncCycles();
    // MOV BP,DI (334B_13F9 / 0x348A9)
    BP = DI;
    State.IncCycles();
    // SHL BP,1 (334B_13FB / 0x348AB)
    BP <<= 0x1;
    State.IncCycles();
    // SUB BP,AX (334B_13FD / 0x348AD)
    // BP -= AX;
    BP = Alu.Sub16(BP, AX);
    State.IncCycles();
    // MOV word ptr CS:[0x10e0],BP (334B_13FF / 0x348AF)
    UInt16[cs2, 0x10E0] = BP;
    State.IncCycles();
    // MOV CS:[0x10de],AX (334B_1404 / 0x348B4)
    UInt16[cs2, 0x10DE] = AX;
    State.IncCycles();
    // ADD DX,AX (334B_1408 / 0x348B8)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_140A / 0x348BA)
    NearCall(cs2, 0x140D, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_140D_0348BD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_140D_0348BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_140D_348BD:
    // MOV DX,word ptr CS:[0x19d] (334B_140D / 0x348BD)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // MOV BX,CX (334B_1412 / 0x348C2)
    BX = CX;
    State.IncCycles();
    // XOR CX,CX (334B_1414 / 0x348C4)
    CX = 0;
    State.IncCycles();
    // JMP 0x3000:4592 (334B_1416 / 0x348C6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_10E2_034592, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_1419_0348C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1419_348C9:
    // SHL DI,1 (334B_1419 / 0x348C9)
    DI <<= 0x1;
    State.IncCycles();
    // SUB DI,AX (334B_141B / 0x348CB)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // JLE 0x3000:48a1 (334B_141D / 0x348CD)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_13F1 / 0x348A1)
      return FarRet();
    }
    State.IncCycles();
    // MOV CS:[0x10dc],AX (334B_141F / 0x348CF)
    UInt16[cs2, 0x10DC] = AX;
    State.IncCycles();
    // MOV word ptr CS:[0x10de],0x0 (334B_1423 / 0x348D3)
    UInt16[cs2, 0x10DE] = 0x0;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_142A / 0x348DA)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,DX (334B_142D / 0x348DD)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JLE 0x3000:48eb (334B_142F / 0x348DF)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_143B_348EB;
    }
    State.IncCycles();
    // MOV CS:[0x10de],AX (334B_1431 / 0x348E1)
    UInt16[cs2, 0x10DE] = AX;
    State.IncCycles();
    // SUB DI,AX (334B_1435 / 0x348E5)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // JLE 0x3000:48a1 (334B_1437 / 0x348E7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_13F1 / 0x348A1)
      return FarRet();
    }
    State.IncCycles();
    // ADD DX,AX (334B_1439 / 0x348E9)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    label_334B_143B_348EB:
    // MOV word ptr CS:[0x10e0],DI (334B_143B / 0x348EB)
    UInt16[cs2, 0x10E0] = DI;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1440 / 0x348F0)
    NearCall(cs2, 0x1443, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1443_0348F3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1443_0348F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1443_348F3:
    // MOV DX,word ptr CS:[0x19d] (334B_1443 / 0x348F3)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // MOV BX,CX (334B_1448 / 0x348F8)
    BX = CX;
    State.IncCycles();
    // XOR CX,CX (334B_144A / 0x348FA)
    CX = 0;
    State.IncCycles();
    // JMP 0x3000:469e (334B_144C / 0x348FC)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1151_034601, 0x3469E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_144F_0348FF(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24902: goto label_334B_1452_34902;break; // Target of external jump from 0x335C2
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_144F_348FF:
    // JMP 0x3000:4c98 (334B_144F / 0x348FF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_17E8_034C98, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_1452_34902:
    // CMP CH,0xfe (334B_1452 / 0x34902)
    Alu.Sub8(CH, 0xFE);
    State.IncCycles();
    // JNC 0x3000:48ff (334B_1455 / 0x34905)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x3000:4c98 (334B_144F / 0x348FF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_17E8_034C98, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR DI,DI (334B_1457 / 0x34907)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JNS 0x3000:490e (334B_1459 / 0x34909)
    if(!SignFlag) {
      goto label_334B_145E_3490E;
    }
    State.IncCycles();
    // JMP 0x3000:4822 (334B_145B / 0x3490B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1372_034822, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_145E_3490E:
    // MOV AL,byte ptr [SI + -0x1] (334B_145E / 0x3490E)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // MOV CS:[0x19e],AL (334B_1461 / 0x34911)
    UInt8[cs2, 0x19E] = AL;
    State.IncCycles();
    // MOV word ptr CS:[0x158b],DI (334B_1465 / 0x34915)
    UInt16[cs2, 0x158B] = DI;
    State.IncCycles();
    // ADD DI,0x3 (334B_146A / 0x3491A)
    DI += 0x3;
    State.IncCycles();
    // SHR DI,1 (334B_146D / 0x3491D)
    DI >>= 0x1;
    State.IncCycles();
    // SHR DI,1 (334B_146F / 0x3491F)
    DI >>= 0x1;
    State.IncCycles();
    // SHL DI,1 (334B_1471 / 0x34921)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (334B_1473 / 0x34923)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // SUB AX,BX (334B_1476 / 0x34926)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JLE 0x3000:4935 (334B_1478 / 0x34928)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_1485_34935;
    }
    State.IncCycles();
    // SUB CX,AX (334B_147A / 0x3492A)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x3000:4968 (334B_147C / 0x3492C)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_14B8 / 0x34968)
      return FarRet();
    }
    State.IncCycles();
    // ADD BX,AX (334B_147E / 0x3492E)
    BX += AX;
    State.IncCycles();
    label_334B_1480_34930:
    // ADD SI,DI (334B_1480 / 0x34930)
    SI += DI;
    State.IncCycles();
    // DEC AX (334B_1482 / 0x34932)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:4930 (334B_1483 / 0x34933)
    if(!ZeroFlag) {
      goto label_334B_1480_34930;
    }
    State.IncCycles();
    label_334B_1485_34935:
    // MOV AX,BX (334B_1485 / 0x34935)
    AX = BX;
    State.IncCycles();
    // ADD AX,CX (334B_1487 / 0x34937)
    AX += CX;
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x6] (334B_1489 / 0x34939)
    // AX -= UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    State.IncCycles();
    // JBE 0x3000:4942 (334B_148C / 0x3493C)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_1492_34942;
    }
    State.IncCycles();
    // SUB CX,AX (334B_148E / 0x3493E)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x3000:4968 (334B_1490 / 0x34940)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_14B8 / 0x34968)
      return FarRet();
    }
    State.IncCycles();
    label_334B_1492_34942:
    // MOV AX,DX (334B_1492 / 0x34942)
    AX = DX;
    State.IncCycles();
    // ADD AX,word ptr CS:[0x158b] (334B_1494 / 0x34944)
    AX += UInt16[cs2, 0x158B];
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x4] (334B_1499 / 0x34949)
    // AX -= UInt16[SS, (ushort)(BP + 0x4)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x4)]);
    State.IncCycles();
    // JG 0x3000:49ad (334B_149C / 0x3494C)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_14FD_0349AD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_149E / 0x3494E)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,DX (334B_14A1 / 0x34951)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JG 0x3000:4969 (334B_14A3 / 0x34953)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_14B8_034968, 0x34969 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,DI (334B_14A5 / 0x34955)
    AX = DI;
    State.IncCycles();
    // SHR AX,1 (334B_14A7 / 0x34957)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV CS:[0x158b],AX (334B_14A9 / 0x34959)
    UInt16[cs2, 0x158B] = AX;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_14AD / 0x3495D)
    NearCall(cs2, 0x14B0, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_14B0_034960, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_14B0_034960(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_14B0_34960:
    // MOV DX,word ptr CS:[0x19d] (334B_14B0 / 0x34960)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // JMP 0x3000:4a3a (334B_14B5 / 0x34965)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_158A_034A3A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_14B8_034968(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24969: goto label_334B_14B9_34969;break; // Target of external jump from 0x34953
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_14B8_34968:
    // RETF  (334B_14B8 / 0x34968)
    return FarRet();
    State.IncCycles();
    label_334B_14B9_34969:
    // SUB word ptr CS:[0x158b],AX (334B_14B9 / 0x34969)
    // UInt16[cs2, 0x158B] -= AX;
    UInt16[cs2, 0x158B] = Alu.Sub16(UInt16[cs2, 0x158B], AX);
    State.IncCycles();
    // JLE 0x3000:4968 (334B_14BE / 0x3496E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_14B8 / 0x34968)
      return FarRet();
    }
    State.IncCycles();
    // PUSH SI (334B_14C0 / 0x34970)
    Stack.Push(SI);
    State.IncCycles();
    // ADD DX,AX (334B_14C1 / 0x34971)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // MOV SI,AX (334B_14C3 / 0x34973)
    SI = AX;
    State.IncCycles();
    // AND SI,0x3 (334B_14C5 / 0x34975)
    SI &= 0x3;
    State.IncCycles();
    // SHL SI,1 (334B_14C8 / 0x34978)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr CS:[SI + 0x14f5] (334B_14CA / 0x3497A)
    SI = UInt16[cs2, (ushort)(SI + 0x14F5)];
    State.IncCycles();
    // SHR DI,1 (334B_14CF / 0x3497F)
    DI >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_14D1 / 0x34981)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV byte ptr CS:[SI + 0x2],AL (334B_14D3 / 0x34983)
    UInt8[cs2, (ushort)(SI + 0x2)] = AL;
    State.IncCycles();
    // SHR AX,1 (334B_14D7 / 0x34987)
    AX >>= 0x1;
    State.IncCycles();
    // SUB DI,AX (334B_14D9 / 0x34989)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x4],DI (334B_14DB / 0x3498B)
    UInt16[cs2, (ushort)(SI + 0x4)] = DI;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_14DF / 0x3498F)
    NearCall(cs2, 0x14E2, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_14E2_034992, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_14E2_034992(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_14E2_34992:
    // MOV BP,SI (334B_14E2 / 0x34992)
    BP = SI;
    State.IncCycles();
    // POP SI (334B_14E4 / 0x34994)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV AX,BP (334B_14E5 / 0x34995)
    AX = BP;
    State.IncCycles();
    // SUB AX,0x163d (334B_14E7 / 0x34997)
    // AX -= 0x163D;
    AX = Alu.Sub16(AX, 0x163D);
    State.IncCycles();
    // MOV CS:[0x163c],AL (334B_14EA / 0x3499A)
    UInt8[cs2, 0x163C] = AL;
    State.IncCycles();
    // MOV DX,word ptr CS:[0x19d] (334B_14EE / 0x3499E)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // JMP BP (334B_14F3 / 0x349A3)
    // Indirect jump to BP, generating possible targets from emulator records
    uint targetAddress_334B_14F3 = (uint)(cs2 * 0x10 + BP - cs1 * 0x10);
    switch(targetAddress_334B_14F3) {
      case 0x24AAB : throw FailAsUntested("Would have been a goto but label label_334B_15FB_34AAB does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_14F3));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_14FD_0349AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_14FD_349AD:
    // SUB word ptr CS:[0x158b],AX (334B_14FD / 0x349AD)
    // UInt16[cs2, 0x158B] -= AX;
    UInt16[cs2, 0x158B] = Alu.Sub16(UInt16[cs2, 0x158B], AX);
    State.IncCycles();
    // JLE 0x3000:4968 (334B_1502 / 0x349B2)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_14B8 / 0x34968)
      return FarRet();
    }
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_1504 / 0x349B4)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,DX (334B_1507 / 0x349B7)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JG 0x3000:49dd (334B_1509 / 0x349B9)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_152D_0349DD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,CS:[0x158b] (334B_150B / 0x349BB)
    AX = UInt16[cs2, 0x158B];
    State.IncCycles();
    // MOV CS:[0x16ab],AX (334B_150F / 0x349BF)
    UInt16[cs2, 0x16AB] = AX;
    State.IncCycles();
    // ADD AX,0x3 (334B_1513 / 0x349C3)
    AX += 0x3;
    State.IncCycles();
    // SHR AX,1 (334B_1516 / 0x349C6)
    AX >>= 0x1;
    State.IncCycles();
    // AND AL,0xfe (334B_1518 / 0x349C8)
    AL &= 0xFE;
    State.IncCycles();
    // SUB DI,AX (334B_151A / 0x349CA)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // MOV AX,DI (334B_151C / 0x349CC)
    AX = DI;
    State.IncCycles();
    // MOV CS:[0x16a9],AL (334B_151E / 0x349CE)
    UInt8[cs2, 0x16A9] = AL;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1522 / 0x349D2)
    NearCall(cs2, 0x1525, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_1525_0349D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_1525_0349D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_1525_349D5:
    // MOV DX,word ptr CS:[0x19d] (334B_1525 / 0x349D5)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // JMP 0x3000:4b5a (334B_152A / 0x349DA)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_16A7_034B57, 0x34B5A - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_152D_0349DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_152D_349DD:
    // SUB word ptr CS:[0x158b],AX (334B_152D / 0x349DD)
    // UInt16[cs2, 0x158B] -= AX;
    UInt16[cs2, 0x158B] = Alu.Sub16(UInt16[cs2, 0x158B], AX);
    State.IncCycles();
    // JLE 0x3000:4968 (334B_1532 / 0x349E2)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_14B8 / 0x34968)
      return FarRet();
    }
    State.IncCycles();
    // PUSH CX (334B_1534 / 0x349E4)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,AX (334B_1535 / 0x349E5)
    CX = AX;
    State.IncCycles();
    // SHR CX,1 (334B_1537 / 0x349E7)
    CX >>= 0x1;
    State.IncCycles();
    // ADD SI,CX (334B_1539 / 0x349E9)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // PUSH SI (334B_153B / 0x349EB)
    Stack.Push(SI);
    State.IncCycles();
    // ADD DX,AX (334B_153C / 0x349EC)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // MOV SI,AX (334B_153E / 0x349EE)
    SI = AX;
    State.IncCycles();
    // AND SI,0x3 (334B_1540 / 0x349F0)
    SI &= 0x3;
    State.IncCycles();
    // SHL SI,1 (334B_1543 / 0x349F3)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr CS:[SI + 0x1582] (334B_1545 / 0x349F5)
    SI = UInt16[cs2, (ushort)(SI + 0x1582)];
    State.IncCycles();
    // ADD AX,word ptr CS:[0x158b] (334B_154A / 0x349FA)
    AX += UInt16[cs2, 0x158B];
    State.IncCycles();
    // ADD AX,0x3 (334B_154F / 0x349FF)
    AX += 0x3;
    State.IncCycles();
    // SHR AX,1 (334B_1552 / 0x34A02)
    AX >>= 0x1;
    State.IncCycles();
    // AND AL,0xfe (334B_1554 / 0x34A04)
    AL &= 0xFE;
    State.IncCycles();
    // SUB DI,AX (334B_1556 / 0x34A06)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // MOV AX,DI (334B_1558 / 0x34A08)
    AX = DI;
    State.IncCycles();
    // ADD AX,CX (334B_155A / 0x34A0A)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // MOV byte ptr CS:[SI + 0x2],AL (334B_155C / 0x34A0C)
    UInt8[cs2, (ushort)(SI + 0x2)] = AL;
    State.IncCycles();
    // MOV AX,CS:[0x158b] (334B_1560 / 0x34A10)
    AX = UInt16[cs2, 0x158B];
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x4],AX (334B_1564 / 0x34A14)
    UInt16[cs2, (ushort)(SI + 0x4)] = AX;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_1568 / 0x34A18)
    NearCall(cs2, 0x156B, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_156B_034A1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_156B_034A1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_156B_34A1B:
    // MOV BP,SI (334B_156B / 0x34A1B)
    BP = SI;
    State.IncCycles();
    // POP SI (334B_156D / 0x34A1D)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_156E / 0x34A1E)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV AX,BP (334B_156F / 0x34A1F)
    AX = BP;
    State.IncCycles();
    // SUB AX,0x1779 (334B_1571 / 0x34A21)
    // AX -= 0x1779;
    AX = Alu.Sub16(AX, 0x1779);
    State.IncCycles();
    // MOV CS:[0x1778],AL (334B_1574 / 0x34A24)
    UInt8[cs2, 0x1778] = AL;
    State.IncCycles();
    // MOV DX,word ptr CS:[0x19d] (334B_1578 / 0x34A28)
    DX = UInt16[cs2, 0x19D];
    State.IncCycles();
    // ADD BP,0x3 (334B_157D / 0x34A2D)
    // BP += 0x3;
    BP = Alu.Add16(BP, 0x3);
    State.IncCycles();
    // JMP BP (334B_1580 / 0x34A30)
    // Indirect jump to BP, generating possible targets from emulator records
    uint targetAddress_334B_1580 = (uint)(cs2 * 0x10 + BP - cs1 * 0x10);
    switch(targetAddress_334B_1580) {
      case 0x24C82 : {
        // Jump converted to non entry function call
        if(JumpDispatcher.Jump(split_334B_17CF_034C7F, 0x34C82 - cs1 * 0x10)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_1580));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_158A_034A3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_158A_34A3A:
    // Instruction bytes at index 2 modified by those instruction(s): 3482D, 34969, 349AD
    // Instruction bytes at index 1 modified by those instruction(s): 3482D, 34915, 34959, 34969, 349AD, 3442E
    // Instruction is modified by code, generator handled: First value group is modified
    // MOV BP,0x1234 (334B_158A / 0x34A3A)
    BP = UInt16[cs2, 0x158B];
    State.IncCycles();
    // PUSH DI (334B_158D / 0x34A3D)
    Stack.Push(DI);
    State.IncCycles();
    label_334B_158E_34A3E:
    // LODSW SI (334B_158E / 0x34A3E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BL,AL (334B_158F / 0x34A3F)
    BL = AL;
    State.IncCycles();
    // AND AL,DL (334B_1591 / 0x34A41)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:4a7a (334B_1593 / 0x34A43)
    if(ZeroFlag) {
      goto label_334B_15CA_34A7A;
    }
    State.IncCycles();
    // ADD AL,DH (334B_1595 / 0x34A45)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_1597 / 0x34A47)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SHR BL,1 (334B_1598 / 0x34A48)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_159A / 0x34A4A)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_159C / 0x34A4C)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_159E / 0x34A4E)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    State.IncCycles();
    // JZ 0x3000:4a89 (334B_15A0 / 0x34A50)
    if(ZeroFlag) {
      goto label_334B_15D9_34A89;
    }
    State.IncCycles();
    // MOV AL,BL (334B_15A2 / 0x34A52)
    AL = BL;
    State.IncCycles();
    label_334B_15A4_34A54:
    // ADD AL,DH (334B_15A4 / 0x34A54)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_15A6 / 0x34A56)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,AH (334B_15A7 / 0x34A57)
    AL = AH;
    State.IncCycles();
    label_334B_15A9_34A59:
    // AND AL,DL (334B_15A9 / 0x34A59)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:4a9e (334B_15AB / 0x34A5B)
    if(ZeroFlag) {
      goto label_334B_15EE_34A9E;
    }
    State.IncCycles();
    // ADD AL,DH (334B_15AD / 0x34A5D)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_15AF / 0x34A5F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SHR AH,1 (334B_15B0 / 0x34A60)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_15B2_34A62:
    // SHR AH,1 (334B_15B2 / 0x34A62)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_15B4 / 0x34A64)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_15B6 / 0x34A66)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:4aa5 (334B_15B8 / 0x34A68)
    if(ZeroFlag) {
      goto label_334B_15F5_34AA5;
    }
    State.IncCycles();
    // MOV AL,AH (334B_15BA / 0x34A6A)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_15BC / 0x34A6C)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_15BE / 0x34A6E)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // DEC BP (334B_15BF / 0x34A6F)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x3000:4a3e (334B_15C0 / 0x34A70)
    if(!ZeroFlag) {
      goto label_334B_158E_34A3E;
    }
    State.IncCycles();
    // POP DI (334B_15C2 / 0x34A72)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x140 (334B_15C3 / 0x34A73)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    // LOOP 0x3000:4a3a (334B_15C7 / 0x34A77)
    if(--CX != 0) {
      goto label_334B_158A_34A3A;
    }
    State.IncCycles();
    // RETF  (334B_15C9 / 0x34A79)
    return FarRet();
    State.IncCycles();
    label_334B_15CA_34A7A:
    // INC DI (334B_15CA / 0x34A7A)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // OR AL,BL (334B_15CB / 0x34A7B)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    State.IncCycles();
    // JZ 0x3000:4a89 (334B_15CD / 0x34A7D)
    if(ZeroFlag) {
      goto label_334B_15D9_34A89;
    }
    State.IncCycles();
    // SHR AL,1 (334B_15CF / 0x34A7F)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_15D1 / 0x34A81)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_15D3 / 0x34A83)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_15D5 / 0x34A85)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JMP 0x3000:4a54 (334B_15D7 / 0x34A87)
    goto label_334B_15A4_34A54;
    State.IncCycles();
    label_334B_15D9_34A89:
    // INC DI (334B_15D9 / 0x34A89)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // MOV AL,AH (334B_15DA / 0x34A8A)
    AL = AH;
    State.IncCycles();
    // OR AL,AL (334B_15DC / 0x34A8C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x3000:4a59 (334B_15DE / 0x34A8E)
    if(!ZeroFlag) {
      goto label_334B_15A9_34A59;
    }
    State.IncCycles();
    label_334B_15E0_34A90:
    // ADD DI,0x2 (334B_15E0 / 0x34A90)
    DI += 0x2;
    State.IncCycles();
    // DEC BP (334B_15E3 / 0x34A93)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x3000:4a3e (334B_15E4 / 0x34A94)
    if(!ZeroFlag) {
      goto label_334B_158E_34A3E;
    }
    State.IncCycles();
    label_334B_15E6_34A96:
    // POP DI (334B_15E6 / 0x34A96)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x140 (334B_15E7 / 0x34A97)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    // LOOP 0x3000:4a3a (334B_15EB / 0x34A9B)
    if(--CX != 0) {
      goto label_334B_158A_34A3A;
    }
    State.IncCycles();
    // RETF  (334B_15ED / 0x34A9D)
    return FarRet();
    State.IncCycles();
    label_334B_15EE_34A9E:
    // SHR AH,1 (334B_15EE / 0x34A9E)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:4a90 (334B_15F0 / 0x34AA0)
    if(ZeroFlag) {
      goto label_334B_15E0_34A90;
    }
    State.IncCycles();
    // INC DI (334B_15F2 / 0x34AA2)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // JMP 0x3000:4a62 (334B_15F3 / 0x34AA3)
    goto label_334B_15B2_34A62;
    State.IncCycles();
    label_334B_15F5_34AA5:
    // INC DI (334B_15F5 / 0x34AA5)
    DI++;
    State.IncCycles();
    // DEC BP (334B_15F6 / 0x34AA6)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x3000:4a3e (334B_15F7 / 0x34AA7)
    if(!ZeroFlag) {
      goto label_334B_158E_34A3E;
    }
    State.IncCycles();
    // JMP 0x3000:4a96 (334B_15F9 / 0x34AA9)
    goto label_334B_15E6_34A96;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_16A7_034B57(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24B5A: goto label_334B_16AA_34B5A;break; // Target of external jump from 0x349DA
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_16A7_34B57:
    // ADD SI,0x12 (334B_16A7 / 0x34B57)
    // SI += 0x12;
    SI = Alu.Add16(SI, 0x12);
    State.IncCycles();
    label_334B_16AA_34B5A:
    // MOV BP,0x1234 (334B_16AA / 0x34B5A)
    BP = 0x1234;
    State.IncCycles();
    // PUSH DI (334B_16AD / 0x34B5D)
    Stack.Push(DI);
    State.IncCycles();
    // ADD BP,DI (334B_16AE / 0x34B5E)
    // BP += DI;
    BP = Alu.Add16(BP, DI);
    State.IncCycles();
    label_334B_16B0_34B60:
    // LODSW SI (334B_16B0 / 0x34B60)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BL,AL (334B_16B1 / 0x34B61)
    BL = AL;
    State.IncCycles();
    // AND AL,DL (334B_16B3 / 0x34B63)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:4ba9 (334B_16B5 / 0x34B65)
    if(ZeroFlag) {
      goto label_334B_16F9_34BA9;
    }
    State.IncCycles();
    // ADD AL,DH (334B_16B7 / 0x34B67)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_16B9 / 0x34B69)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,BP (334B_16BA / 0x34B6A)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4ba1 (334B_16BC / 0x34B6C)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    State.IncCycles();
    // SHR BL,1 (334B_16BE / 0x34B6E)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_16C0 / 0x34B70)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_16C2 / 0x34B72)
    BL >>= 0x1;
    State.IncCycles();
    // SHR BL,1 (334B_16C4 / 0x34B74)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    State.IncCycles();
    // JZ 0x3000:4bbc (334B_16C6 / 0x34B76)
    if(ZeroFlag) {
      goto label_334B_170C_34BBC;
    }
    State.IncCycles();
    // MOV AL,BL (334B_16C8 / 0x34B78)
    AL = BL;
    State.IncCycles();
    label_334B_16CA_34B7A:
    // ADD AL,DH (334B_16CA / 0x34B7A)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_16CC / 0x34B7C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,BP (334B_16CD / 0x34B7D)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4ba1 (334B_16CF / 0x34B7F)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    State.IncCycles();
    // MOV AL,AH (334B_16D1 / 0x34B81)
    AL = AH;
    State.IncCycles();
    label_334B_16D3_34B83:
    // AND AL,DL (334B_16D3 / 0x34B83)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    State.IncCycles();
    // JZ 0x3000:4bcc (334B_16D5 / 0x34B85)
    if(ZeroFlag) {
      goto label_334B_171C_34BCC;
    }
    State.IncCycles();
    // ADD AL,DH (334B_16D7 / 0x34B87)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_16D9 / 0x34B89)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,BP (334B_16DA / 0x34B8A)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4ba1 (334B_16DC / 0x34B8C)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    State.IncCycles();
    // SHR AH,1 (334B_16DE / 0x34B8E)
    AH >>= 0x1;
    State.IncCycles();
    label_334B_16E0_34B90:
    // SHR AH,1 (334B_16E0 / 0x34B90)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_16E2 / 0x34B92)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (334B_16E4 / 0x34B94)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JZ 0x3000:4bd5 (334B_16E6 / 0x34B96)
    if(ZeroFlag) {
      goto label_334B_1725_34BD5;
    }
    State.IncCycles();
    // MOV AL,AH (334B_16E8 / 0x34B98)
    AL = AH;
    State.IncCycles();
    // ADD AL,DH (334B_16EA / 0x34B9A)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_16EC / 0x34B9C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_334B_16ED_34B9D:
    // CMP DI,BP (334B_16ED / 0x34B9D)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JC 0x3000:4b60 (334B_16EF / 0x34B9F)
    if(CarryFlag) {
      goto label_334B_16B0_34B60;
    }
    State.IncCycles();
    label_334B_16F1_34BA1:
    // POP DI (334B_16F1 / 0x34BA1)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x140 (334B_16F2 / 0x34BA2)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    // LOOP 0x3000:4b57 (334B_16F6 / 0x34BA6)
    if(--CX != 0) {
      goto label_334B_16A7_34B57;
    }
    State.IncCycles();
    // RETF  (334B_16F8 / 0x34BA8)
    return FarRet();
    State.IncCycles();
    label_334B_16F9_34BA9:
    // INC DI (334B_16F9 / 0x34BA9)
    DI++;
    State.IncCycles();
    // CMP DI,BP (334B_16FA / 0x34BAA)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4ba1 (334B_16FC / 0x34BAC)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    State.IncCycles();
    // OR AL,BL (334B_16FE / 0x34BAE)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    State.IncCycles();
    // JZ 0x3000:4bbc (334B_1700 / 0x34BB0)
    if(ZeroFlag) {
      goto label_334B_170C_34BBC;
    }
    State.IncCycles();
    // SHR AL,1 (334B_1702 / 0x34BB2)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1704 / 0x34BB4)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1706 / 0x34BB6)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_1708 / 0x34BB8)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JMP 0x3000:4b7a (334B_170A / 0x34BBA)
    goto label_334B_16CA_34B7A;
    State.IncCycles();
    label_334B_170C_34BBC:
    // INC DI (334B_170C / 0x34BBC)
    DI++;
    State.IncCycles();
    // CMP DI,BP (334B_170D / 0x34BBD)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4ba1 (334B_170F / 0x34BBF)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    State.IncCycles();
    // MOV AL,AH (334B_1711 / 0x34BC1)
    AL = AH;
    State.IncCycles();
    // OR AL,AL (334B_1713 / 0x34BC3)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x3000:4b83 (334B_1715 / 0x34BC5)
    if(!ZeroFlag) {
      goto label_334B_16D3_34B83;
    }
    State.IncCycles();
    // ADD DI,0x2 (334B_1717 / 0x34BC7)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // JMP 0x3000:4b9d (334B_171A / 0x34BCA)
    goto label_334B_16ED_34B9D;
    State.IncCycles();
    label_334B_171C_34BCC:
    // INC DI (334B_171C / 0x34BCC)
    DI++;
    State.IncCycles();
    // CMP DI,BP (334B_171D / 0x34BCD)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNC 0x3000:4ba1 (334B_171F / 0x34BCF)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    State.IncCycles();
    // SHR AH,1 (334B_1721 / 0x34BD1)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // JNZ 0x3000:4b90 (334B_1723 / 0x34BD3)
    if(!ZeroFlag) {
      goto label_334B_16E0_34B90;
    }
    State.IncCycles();
    label_334B_1725_34BD5:
    // INC DI (334B_1725 / 0x34BD5)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // JMP 0x3000:4b9d (334B_1726 / 0x34BD6)
    goto label_334B_16ED_34B9D;
  }
  
}
