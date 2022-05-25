namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action get_ems_emm_handle_ida_1000_ED40_1ED40(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ED40_1ED40:
    // MOV DX,word ptr CS:[0xed3a] (1000_ED40 / 0x1ED40)
    DX = UInt16[cs1, 0xED3A];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(call_ems_func_ida_1000_ED45_1ED45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action call_ems_func_ida_1000_ED45_1ED45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ED45_1ED45:
    // INT 0x67 (1000_ED45 / 0x1ED45)
    Interrupt(0x67);
    State.IncCycles();
    // CMP AH,0x80 (1000_ED47 / 0x1ED47)
    Alu.Sub8(AH, 0x80);
    State.IncCycles();
    // CMC  (1000_ED4A / 0x1ED4A)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // RET  (1000_ED4B / 0x1ED4B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_ED4C_01ED4C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ED4C_1ED4C:
    // MOV AH,0x41 (1000_ED4C / 0x1ED4C)
    AH = 0x41;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_ED4E / 0x1ED4E)
    NearCall(cs1, 0xED51, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edb3 (1000_ED51 / 0x1ED51)
    if(CarryFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // MOV word ptr CS:[0xed3c],BX (1000_ED53 / 0x1ED53)
    UInt16[cs1, 0xED3C] = BX;
    State.IncCycles();
    // MOV AH,0x42 (1000_ED58 / 0x1ED58)
    AH = 0x42;
    State.IncCycles();
    // XOR BX,BX (1000_ED5A / 0x1ED5A)
    BX = 0;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_ED5C / 0x1ED5C)
    NearCall(cs1, 0xED5F, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edb3 (1000_ED5F / 0x1ED5F)
    if(CarryFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // CMP BX,0x3 (1000_ED61 / 0x1ED61)
    Alu.Sub16(BX, 0x3);
    State.IncCycles();
    // JC 0x1000:edb3 (1000_ED64 / 0x1ED64)
    if(CarryFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // CALL 0x1000:edb9 (1000_ED66 / 0x1ED66)
    NearCall(cs1, 0xED69, map_ems_for_midi_audio_ida_1000_EDB9_1EDB9);
    State.IncCycles();
    // TEST byte ptr [0x2943],0x8 (1000_ED69 / 0x1ED69)
    Alu.And8(UInt8[DS, 0x2943], 0x8);
    State.IncCycles();
    // JNZ 0x1000:edb3 (1000_ED6E / 0x1ED6E)
    if(!ZeroFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // MOV AH,0x42 (1000_ED70 / 0x1ED70)
    AH = 0x42;
    State.IncCycles();
    // XOR BX,BX (1000_ED72 / 0x1ED72)
    BX = 0;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_ED74 / 0x1ED74)
    NearCall(cs1, 0xED77, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edb3 (1000_ED77 / 0x1ED77)
    if(CarryFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // CMP BX,0x4 (1000_ED79 / 0x1ED79)
    Alu.Sub16(BX, 0x4);
    State.IncCycles();
    // JC 0x1000:edb3 (1000_ED7C / 0x1ED7C)
    if(CarryFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // CMP BX,0x80 (1000_ED7E / 0x1ED7E)
    Alu.Sub16(BX, 0x80);
    State.IncCycles();
    // JC 0x1000:ed87 (1000_ED82 / 0x1ED82)
    if(CarryFlag) {
      goto label_1000_ED87_1ED87;
    }
    State.IncCycles();
    // MOV BX,0x80 (1000_ED84 / 0x1ED84)
    BX = 0x80;
    State.IncCycles();
    label_1000_ED87_1ED87:
    // MOV AX,BX (1000_ED87 / 0x1ED87)
    AX = BX;
    State.IncCycles();
    // SHL AX,1 (1000_ED89 / 0x1ED89)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JZ 0x1000:edb3 (1000_ED8B / 0x1ED8B)
    if(ZeroFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // SHL AX,1 (1000_ED8D / 0x1ED8D)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_ED8F / 0x1ED8F)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_ED91 / 0x1ED91)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV [0x39a9],AX (1000_ED93 / 0x1ED93)
    UInt16[DS, 0x39A9] = AX;
    State.IncCycles();
    // MOV AH,0x43 (1000_ED96 / 0x1ED96)
    AH = 0x43;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_ED98 / 0x1ED98)
    NearCall(cs1, 0xED9B, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edb3 (1000_ED9B / 0x1ED9B)
    if(CarryFlag) {
      goto label_1000_EDB3_1EDB3;
    }
    State.IncCycles();
    // MOV word ptr CS:[0xed3a],DX (1000_ED9D / 0x1ED9D)
    UInt16[cs1, 0xED3A] = DX;
    State.IncCycles();
    // MOV SI,0xee46 (1000_EDA2 / 0x1EDA2)
    SI = 0xEE46;
    State.IncCycles();
    // MOV DI,0xee02 (1000_EDA5 / 0x1EDA5)
    DI = 0xEE02;
    State.IncCycles();
    // MOV word ptr CS:[0xea77],DI (1000_EDA8 / 0x1EDA8)
    UInt16[cs1, 0xEA77] = DI;
    State.IncCycles();
    // MOV word ptr CS:[0xea79],SI (1000_EDAD / 0x1EDAD)
    UInt16[cs1, 0xEA79] = SI;
    State.IncCycles();
    // RET  (1000_EDB2 / 0x1EDB2)
    return NearRet();
    State.IncCycles();
    label_1000_EDB3_1EDB3:
    // AND byte ptr [0x2943],0xb7 (1000_EDB3 / 0x1EDB3)
    // UInt8[DS, 0x2943] &= 0xB7;
    UInt8[DS, 0x2943] = Alu.And8(UInt8[DS, 0x2943], 0xB7);
    State.IncCycles();
    // RET  (1000_EDB8 / 0x1EDB8)
    return NearRet();
  }
  
  public virtual Action map_ems_for_midi_audio_ida_1000_EDB9_1EDB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EDB9_1EDB9:
    // TEST byte ptr [0x2944],0xf (1000_EDB9 / 0x1EDB9)
    Alu.And8(UInt8[DS, 0x2944], 0xF);
    State.IncCycles();
    // JZ 0x1000:edfc (1000_EDBE / 0x1EDBE)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_EDFC / 0x1EDFC)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,0x3 (1000_EDC0 / 0x1EDC0)
    BX = 0x3;
    State.IncCycles();
    // MOV AH,0x43 (1000_EDC3 / 0x1EDC3)
    AH = 0x43;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_EDC5 / 0x1EDC5)
    NearCall(cs1, 0xEDC8, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edfc (1000_EDC8 / 0x1EDC8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_EDFC / 0x1EDFC)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr CS:[0xed3e],DX (1000_EDCA / 0x1EDCA)
    UInt16[cs1, 0xED3E] = DX;
    State.IncCycles();
    // MOV AX,0x4401 (1000_EDCF / 0x1EDCF)
    AX = 0x4401;
    State.IncCycles();
    // XOR BX,BX (1000_EDD2 / 0x1EDD2)
    BX = 0;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_EDD4 / 0x1EDD4)
    NearCall(cs1, 0xEDD7, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edfd (1000_EDD7 / 0x1EDD7)
    if(CarryFlag) {
      goto label_1000_EDFD_1EDFD;
    }
    State.IncCycles();
    // MOV AX,0x4402 (1000_EDD9 / 0x1EDD9)
    AX = 0x4402;
    State.IncCycles();
    // MOV BX,0x1 (1000_EDDC / 0x1EDDC)
    BX = 0x1;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_EDDF / 0x1EDDF)
    NearCall(cs1, 0xEDE2, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edfd (1000_EDE2 / 0x1EDE2)
    if(CarryFlag) {
      goto label_1000_EDFD_1EDFD;
    }
    State.IncCycles();
    // MOV AX,0x4403 (1000_EDE4 / 0x1EDE4)
    AX = 0x4403;
    State.IncCycles();
    // MOV BX,0x2 (1000_EDE7 / 0x1EDE7)
    BX = 0x2;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_EDEA / 0x1EDEA)
    NearCall(cs1, 0xEDED, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    // JC 0x1000:edfd (1000_EDED / 0x1EDED)
    if(CarryFlag) {
      goto label_1000_EDFD_1EDFD;
    }
    State.IncCycles();
    // MOV AX,CS:[0xed3c] (1000_EDEF / 0x1EDEF)
    AX = UInt16[cs1, 0xED3C];
    State.IncCycles();
    // MOV [0xdbb8],AX (1000_EDF3 / 0x1EDF3)
    UInt16[DS, 0xDBB8] = AX;
    State.IncCycles();
    // MOV word ptr [0xdbb6],0x4000 (1000_EDF6 / 0x1EDF6)
    UInt16[DS, 0xDBB6] = 0x4000;
    State.IncCycles();
    label_1000_EDFC_1EDFC:
    // RET  (1000_EDFC / 0x1EDFC)
    return NearRet();
    State.IncCycles();
    label_1000_EDFD_1EDFD:
    // MOV AH,0x45 (1000_EDFD / 0x1EDFD)
    AH = 0x45;
    State.IncCycles();
    // JMP 0x1000:ed45 (1000_EDFF / 0x1EDFF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(call_ems_func_ida_1000_ED45_1ED45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ems_memory_func_2_ida_1000_EE02_1EE02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EE02_1EE02:
    // MOV AX,BX (1000_EE02 / 0x1EE02)
    AX = BX;
    State.IncCycles();
    // SHL AX,1 (1000_EE04 / 0x1EE04)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_EE06 / 0x1EE06)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // XCHG AH,AL (1000_EE08 / 0x1EE08)
    byte tmp_1000_EE08 = AH;
    AH = AL;
    AL = tmp_1000_EE08;
    State.IncCycles();
    // AND AX,0x3c00 (1000_EE0A / 0x1EE0A)
    // AX &= 0x3C00;
    AX = Alu.And16(AX, 0x3C00);
    State.IncCycles();
    // MOV DI,AX (1000_EE0D / 0x1EE0D)
    DI = AX;
    State.IncCycles();
    // SHR BX,1 (1000_EE0F / 0x1EE0F)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_EE11 / 0x1EE11)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_EE13 / 0x1EE13)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_EE15 / 0x1EE15)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    label_1000_EE17_1EE17:
    // MOV AX,0x4400 (1000_EE17 / 0x1EE17)
    AX = 0x4400;
    State.IncCycles();
    // CALL 0x1000:ed40 (1000_EE1A / 0x1EE1A)
    NearCall(cs1, 0xEE1D, get_ems_emm_handle_ida_1000_ED40_1ED40);
    State.IncCycles();
    // JC 0x1000:ee45 (1000_EE1D / 0x1EE1D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_EE45 / 0x1EE45)
      return NearRet();
    }
    State.IncCycles();
    // MOV ES,word ptr CS:[0xed3c] (1000_EE1F / 0x1EE1F)
    ES = UInt16[cs1, 0xED3C];
    State.IncCycles();
    // MOV DX,CX (1000_EE24 / 0x1EE24)
    DX = CX;
    State.IncCycles();
    // MOV CX,0x4000 (1000_EE26 / 0x1EE26)
    CX = 0x4000;
    State.IncCycles();
    // SUB CX,DI (1000_EE29 / 0x1EE29)
    CX -= DI;
    State.IncCycles();
    // CMP CX,DX (1000_EE2B / 0x1EE2B)
    Alu.Sub16(CX, DX);
    State.IncCycles();
    // JC 0x1000:ee31 (1000_EE2D / 0x1EE2D)
    if(CarryFlag) {
      goto label_1000_EE31_1EE31;
    }
    State.IncCycles();
    // MOV CX,DX (1000_EE2F / 0x1EE2F)
    CX = DX;
    State.IncCycles();
    label_1000_EE31_1EE31:
    // SUB DX,CX (1000_EE31 / 0x1EE31)
    DX -= CX;
    State.IncCycles();
    // SHR CX,1 (1000_EE33 / 0x1EE33)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_EE35 / 0x1EE35)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADC CL,CL (1000_EE37 / 0x1EE37)
    CL = Alu.Adc8(CL, CL);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_EE39 / 0x1EE39)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV CX,DX (1000_EE3B / 0x1EE3B)
    CX = DX;
    State.IncCycles();
    // JCXZ 0x1000:ee44 (1000_EE3D / 0x1EE3D)
    if(CX == 0) {
      goto label_1000_EE44_1EE44;
    }
    State.IncCycles();
    // INC BX (1000_EE3F / 0x1EE3F)
    BX++;
    State.IncCycles();
    // XOR DI,DI (1000_EE40 / 0x1EE40)
    DI = 0;
    State.IncCycles();
    // JMP 0x1000:ee17 (1000_EE42 / 0x1EE42)
    goto label_1000_EE17_1EE17;
    State.IncCycles();
    label_1000_EE44_1EE44:
    // CLC  (1000_EE44 / 0x1EE44)
    CarryFlag = false;
    State.IncCycles();
    label_1000_EE45_1EE45:
    // RET  (1000_EE45 / 0x1EE45)
    return NearRet();
  }
  
  public virtual Action ems_memory_func_1_ida_1000_EE46_1EE46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EE46_1EE46:
    // MOV AX,BX (1000_EE46 / 0x1EE46)
    AX = BX;
    State.IncCycles();
    // SHL AX,1 (1000_EE48 / 0x1EE48)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_EE4A / 0x1EE4A)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // XCHG AH,AL (1000_EE4C / 0x1EE4C)
    byte tmp_1000_EE4C = AH;
    AH = AL;
    AL = tmp_1000_EE4C;
    State.IncCycles();
    // AND AX,0x3c00 (1000_EE4E / 0x1EE4E)
    // AX &= 0x3C00;
    AX = Alu.And16(AX, 0x3C00);
    State.IncCycles();
    // MOV SI,AX (1000_EE51 / 0x1EE51)
    SI = AX;
    State.IncCycles();
    // SHR BX,1 (1000_EE53 / 0x1EE53)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_EE55 / 0x1EE55)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_EE57 / 0x1EE57)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_EE59 / 0x1EE59)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    label_1000_EE5B_1EE5B:
    // MOV AX,0x4400 (1000_EE5B / 0x1EE5B)
    AX = 0x4400;
    State.IncCycles();
    // CALL 0x1000:ed40 (1000_EE5E / 0x1EE5E)
    NearCall(cs1, 0xEE61, get_ems_emm_handle_ida_1000_ED40_1ED40);
    State.IncCycles();
    // JC 0x1000:ee45 (1000_EE61 / 0x1EE61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_EE45 / 0x1EE45)
      return NearRet();
    }
    State.IncCycles();
    // MOV DS,word ptr CS:[0xed3c] (1000_EE63 / 0x1EE63)
    DS = UInt16[cs1, 0xED3C];
    State.IncCycles();
    // MOV DX,CX (1000_EE68 / 0x1EE68)
    DX = CX;
    State.IncCycles();
    // MOV CX,0x4000 (1000_EE6A / 0x1EE6A)
    CX = 0x4000;
    State.IncCycles();
    // SUB CX,SI (1000_EE6D / 0x1EE6D)
    CX -= SI;
    State.IncCycles();
    // CMP CX,DX (1000_EE6F / 0x1EE6F)
    Alu.Sub16(CX, DX);
    State.IncCycles();
    // JC 0x1000:ee75 (1000_EE71 / 0x1EE71)
    if(CarryFlag) {
      goto label_1000_EE75_1EE75;
    }
    State.IncCycles();
    // MOV CX,DX (1000_EE73 / 0x1EE73)
    CX = DX;
    State.IncCycles();
    label_1000_EE75_1EE75:
    // SUB DX,CX (1000_EE75 / 0x1EE75)
    DX -= CX;
    State.IncCycles();
    // SHR CX,1 (1000_EE77 / 0x1EE77)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_EE79 / 0x1EE79)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADC CL,CL (1000_EE7B / 0x1EE7B)
    CL = Alu.Adc8(CL, CL);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_EE7D / 0x1EE7D)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV CX,DX (1000_EE7F / 0x1EE7F)
    CX = DX;
    State.IncCycles();
    // JCXZ 0x1000:ee88 (1000_EE81 / 0x1EE81)
    if(CX == 0) {
      goto label_1000_EE88_1EE88;
    }
    State.IncCycles();
    // INC BX (1000_EE83 / 0x1EE83)
    BX++;
    State.IncCycles();
    // XOR SI,SI (1000_EE84 / 0x1EE84)
    SI = 0;
    State.IncCycles();
    // JMP 0x1000:ee5b (1000_EE86 / 0x1EE86)
    goto label_1000_EE5B_1EE5B;
    State.IncCycles();
    label_1000_EE88_1EE88:
    // CLC  (1000_EE88 / 0x1EE88)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_EE89 / 0x1EE89)
    return NearRet();
  }
  
  public virtual Action initialize_himem_sys_ida_1000_EEA0_1EEA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EEA0_1EEA0:
    // MOV AX,0x4310 (1000_EEA0 / 0x1EEA0)
    AX = 0x4310;
    State.IncCycles();
    // INT 0x2f (1000_EEA3 / 0x1EEA3)
    Interrupt(0x2f);
    State.IncCycles();
    // MOV word ptr CS:[0xee8c],BX (1000_EEA5 / 0x1EEA5)
    UInt16[cs1, 0xEE8C] = BX;
    State.IncCycles();
    // MOV word ptr CS:[0xee8e],ES (1000_EEAA / 0x1EEAA)
    UInt16[cs1, 0xEE8E] = ES;
    State.IncCycles();
    // MOV AH,0x8 (1000_EEAF / 0x1EEAF)
    AH = 0x8;
    State.IncCycles();
    // CALL 0x1000:ef22 (1000_EEB1 / 0x1EEB1)
    NearCall(cs1, 0xEEB4, call_xms_driver_func_ida_1000_EF22_1EF22);
    State.IncCycles();
    // CMP AX,0x3f (1000_EEB4 / 0x1EEB4)
    Alu.Sub16(AX, 0x3F);
    State.IncCycles();
    // JC 0x1000:eee3 (1000_EEB7 / 0x1EEB7)
    if(CarryFlag) {
      goto label_1000_EEE3_1EEE3;
    }
    State.IncCycles();
    // CMP AX,0x800 (1000_EEB9 / 0x1EEB9)
    Alu.Sub16(AX, 0x800);
    State.IncCycles();
    // JC 0x1000:eec1 (1000_EEBC / 0x1EEBC)
    if(CarryFlag) {
      goto label_1000_EEC1_1EEC1;
    }
    State.IncCycles();
    // MOV AX,0x800 (1000_EEBE / 0x1EEBE)
    AX = 0x800;
    State.IncCycles();
    label_1000_EEC1_1EEC1:
    // MOV [0x39a9],AX (1000_EEC1 / 0x1EEC1)
    UInt16[DS, 0x39A9] = AX;
    State.IncCycles();
    // MOV DX,AX (1000_EEC4 / 0x1EEC4)
    DX = AX;
    State.IncCycles();
    // MOV AH,0x9 (1000_EEC6 / 0x1EEC6)
    AH = 0x9;
    State.IncCycles();
    // CALL 0x1000:ef22 (1000_EEC8 / 0x1EEC8)
    NearCall(cs1, 0xEECB, call_xms_driver_func_ida_1000_EF22_1EF22);
    State.IncCycles();
    // JC 0x1000:eee3 (1000_EECB / 0x1EECB)
    if(CarryFlag) {
      goto label_1000_EEE3_1EEE3;
    }
    State.IncCycles();
    // MOV word ptr CS:[0xee8a],DX (1000_EECD / 0x1EECD)
    UInt16[cs1, 0xEE8A] = DX;
    State.IncCycles();
    // MOV SI,0xef32 (1000_EED2 / 0x1EED2)
    SI = 0xEF32;
    State.IncCycles();
    // MOV DI,0xeee9 (1000_EED5 / 0x1EED5)
    DI = 0xEEE9;
    State.IncCycles();
    // MOV word ptr CS:[0xea77],DI (1000_EED8 / 0x1EED8)
    UInt16[cs1, 0xEA77] = DI;
    State.IncCycles();
    // MOV word ptr CS:[0xea79],SI (1000_EEDD / 0x1EEDD)
    UInt16[cs1, 0xEA79] = SI;
    State.IncCycles();
    // RET  (1000_EEE2 / 0x1EEE2)
    return NearRet();
    State.IncCycles();
    label_1000_EEE3_1EEE3:
    // AND byte ptr [0x2943],0x7f (1000_EEE3 / 0x1EEE3)
    // UInt8[DS, 0x2943] &= 0x7F;
    UInt8[DS, 0x2943] = Alu.And8(UInt8[DS, 0x2943], 0x7F);
    State.IncCycles();
    // RET  (1000_EEE8 / 0x1EEE8)
    return NearRet();
  }
  
  public virtual Action call_xms_driver_func_ida_1000_EF22_1EF22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EF22_1EF22:
    // CALLF [0xee8c] (1000_EF22 / 0x1EF22)
    // Indirect call to [0xee8c], generating possible targets from emulator records
    uint targetAddress_1000_EF22 = (uint)(UInt16[cs1, 0xEE8E] * 0x10 + UInt16[cs1, 0xEE8C]);
    switch(targetAddress_1000_EF22) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EF22));
        break;
    }
    State.IncCycles();
    // CMP AX,0x1 (1000_EF27 / 0x1EF27)
    Alu.Sub16(AX, 0x1);
    State.IncCycles();
    // RET  (1000_EF2A / 0x1EF2A)
    return NearRet();
  }
  
  public virtual Action call_xms_func_on_block_ida_1000_EF2B_1EF2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EF2B_1EF2B:
    // MOV DX,word ptr CS:[0xee8a] (1000_EF2B / 0x1EF2B)
    DX = UInt16[cs1, 0xEE8A];
    State.IncCycles();
    // JMP 0x1000:ef22 (1000_EF30 / 0x1EF30)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(call_xms_driver_func_ida_1000_EF22_1EF22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action xms_move_memory_ida_1000_EF32_1EF32(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EF32_1EF32:
    // PUSH CS (1000_EF32 / 0x1EF32)
    Stack.Push(cs1);
    State.IncCycles();
    // POP DS (1000_EF33 / 0x1EF33)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0xee90 (1000_EF34 / 0x1EF34)
    SI = 0xEE90;
    State.IncCycles();
    // INC CX (1000_EF37 / 0x1EF37)
    CX++;
    State.IncCycles();
    // AND CL,0xfe (1000_EF38 / 0x1EF38)
    // CL &= 0xFE;
    CL = Alu.And8(CL, 0xFE);
    State.IncCycles();
    // MOV word ptr [SI],CX (1000_EF3B / 0x1EF3B)
    UInt16[DS, SI] = CX;
    State.IncCycles();
    // XOR AX,AX (1000_EF3D / 0x1EF3D)
    AX = 0;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],AX (1000_EF3F / 0x1EF3F)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0xa],AX (1000_EF42 / 0x1EF42)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0xc],DI (1000_EF45 / 0x1EF45)
    UInt16[DS, (ushort)(SI + 0xC)] = DI;
    State.IncCycles();
    // MOV word ptr [SI + 0xe],ES (1000_EF48 / 0x1EF48)
    UInt16[DS, (ushort)(SI + 0xE)] = ES;
    State.IncCycles();
    // MOV AX,CS:[0xee8a] (1000_EF4B / 0x1EF4B)
    AX = UInt16[cs1, 0xEE8A];
    State.IncCycles();
    // MOV word ptr [SI + 0x4],AX (1000_EF4F / 0x1EF4F)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    State.IncCycles();
    // XOR DX,DX (1000_EF52 / 0x1EF52)
    DX = 0;
    State.IncCycles();
    // XCHG BH,BL (1000_EF54 / 0x1EF54)
    byte tmp_1000_EF54 = BH;
    BH = BL;
    BL = tmp_1000_EF54;
    State.IncCycles();
    // XCHG DL,BL (1000_EF56 / 0x1EF56)
    byte tmp_1000_EF56 = DL;
    DL = BL;
    BL = tmp_1000_EF56;
    State.IncCycles();
    // SHL BX,1 (1000_EF58 / 0x1EF58)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // RCL DL,1 (1000_EF5A / 0x1EF5A)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // SHL BX,1 (1000_EF5C / 0x1EF5C)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // RCL DL,1 (1000_EF5E / 0x1EF5E)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_EF60 / 0x1EF60)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    // MOV word ptr [SI + 0x8],DX (1000_EF63 / 0x1EF63)
    UInt16[DS, (ushort)(SI + 0x8)] = DX;
    State.IncCycles();
    // MOV AH,0xb (1000_EF66 / 0x1EF66)
    AH = 0xB;
    State.IncCycles();
    // JMP 0x1000:ef22 (1000_EF68 / 0x1EF68)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(call_xms_driver_func_ida_1000_EF22_1EF22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_EF6A_01EF6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EF6A_1EF6A:
    // PUSH AX (1000_EF6A / 0x1EF6A)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DS (1000_EF6B / 0x1EF6B)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_EF6C / 0x1EF6C)
    Stack.Push(ES);
    State.IncCycles();
    // MOV AX,0x1f4b (1000_EF6D / 0x1EF6D)
    AX = 0x1F4B;
    State.IncCycles();
    // MOV DS,AX (1000_EF70 / 0x1EF70)
    DS = AX;
    State.IncCycles();
    // CLD  (1000_EF72 / 0x1EF72)
    DirectionFlag = false;
    State.IncCycles();
    // CMP byte ptr [0xceea],0x0 (1000_EF73 / 0x1EF73)
    Alu.Sub8(UInt8[DS, 0xCEEA], 0x0);
    State.IncCycles();
    // JG 0x1000:efa2 (1000_EF78 / 0x1EF78)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_EFA2_01EFA2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // INC word ptr [0xce7a] (1000_EF7A / 0x1EF7A)
    UInt16[DS, 0xCE7A] = Alu.Inc16(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // JNZ 0x1000:ef84 (1000_EF7E / 0x1EF7E)
    if(!ZeroFlag) {
      goto label_1000_EF84_1EF84;
    }
    State.IncCycles();
    // INC word ptr [0xce7c] (1000_EF80 / 0x1EF80)
    UInt16[DS, 0xCE7C]++;
    State.IncCycles();
    label_1000_EF84_1EF84:
    // CMP byte ptr [0x2788],0x0 (1000_EF84 / 0x1EF84)
    Alu.Sub8(UInt8[DS, 0x2788], 0x0);
    State.IncCycles();
    // JNZ 0x1000:ef9f (1000_EF89 / 0x1EF89)
    if(!ZeroFlag) {
      goto label_1000_EF9F_1EF9F;
    }
    State.IncCycles();
    // DEC word ptr [0x46db] (1000_EF8B / 0x1EF8B)
    UInt16[DS, 0x46DB] = Alu.Dec16(UInt16[DS, 0x46DB]);
    State.IncCycles();
    // JNS 0x1000:ef9f (1000_EF8F / 0x1EF8F)
    if(!SignFlag) {
      goto label_1000_EF9F_1EF9F;
    }
    State.IncCycles();
    // MOV AX,[0x146e] (1000_EF91 / 0x1EF91)
    AX = UInt16[DS, 0x146E];
    State.IncCycles();
    // MOV [0x46db],AX (1000_EF94 / 0x1EF94)
    UInt16[DS, 0x46DB] = AX;
    State.IncCycles();
    // INC word ptr [0x2] (1000_EF97 / 0x1EF97)
    UInt16[DS, 0x2]++;
    State.IncCycles();
    // INC byte ptr [0x46dd] (1000_EF9B / 0x1EF9B)
    UInt8[DS, 0x46DD] = Alu.Inc8(UInt8[DS, 0x46DD]);
    State.IncCycles();
    label_1000_EF9F_1EF9F:
    // CALL 0x1000:efba (1000_EF9F / 0x1EF9F)
    NearCall(cs1, 0xEFA2, spice86_generated_label_call_target_1000_EFBA_01EFBA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_EFA2_01EFA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_EFA2_01EFA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EFA2_1EFA2:
    // POP ES (1000_EFA2 / 0x1EFA2)
    ES = Stack.Pop();
    State.IncCycles();
    // DEC byte ptr [0xce72] (1000_EFA3 / 0x1EFA3)
    UInt8[DS, 0xCE72] = Alu.Dec8(UInt8[DS, 0xCE72]);
    State.IncCycles();
    // JS 0x1000:efd5 (1000_EFA7 / 0x1EFA7)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_EFC7_01EFC7, 0x1EFD5 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_EFA9 / 0x1EFA9)
    AL = 0x20;
    State.IncCycles();
    // OUT 0x20,AL (1000_EFAB / 0x1EFAB)
    Cpu.Out8(0x20, AL);
    State.IncCycles();
    // CMP byte ptr [0xdbb5],0x0 (1000_EFAD / 0x1EFAD)
    Alu.Sub8(UInt8[DS, 0xDBB5], 0x0);
    State.IncCycles();
    // JZ 0x1000:efb7 (1000_EFB2 / 0x1EFB2)
    if(ZeroFlag) {
      goto label_1000_EFB7_1EFB7;
    }
    State.IncCycles();
    // CALL 0x1000:cec9 (1000_EFB4 / 0x1EFB4)
    NearCall(cs1, 0xEFB7, spice86_generated_label_call_target_1000_CEC9_01CEC9);
    State.IncCycles();
    label_1000_EFB7_1EFB7:
    // POP DS (1000_EFB7 / 0x1EFB7)
    DS = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_EFB8 / 0x1EFB8)
    AX = Stack.Pop();
    State.IncCycles();
    // IRET  (1000_EFB9 / 0x1EFB9)
    return InterruptRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_EFBA_01EFBA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EFBA_1EFBA:
    // PUSH BX (1000_EFBA / 0x1EFBA)
    Stack.Push(BX);
    State.IncCycles();
    // TEST byte ptr [0x2943],0x10 (1000_EFBB / 0x1EFBB)
    Alu.And8(UInt8[DS, 0x2943], 0x10);
    State.IncCycles();
    // JNZ 0x1000:efd3 (1000_EFC0 / 0x1EFC0)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_EFC7_01EFC7, 0x1EFD3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH CX (1000_EFC2 / 0x1EFC2)
    Stack.Push(CX);
    State.IncCycles();
    // CALLF [0x3981] (1000_EFC3 / 0x1EFC3)
    // Indirect call to [0x3981], generating possible targets from emulator records
    uint targetAddress_1000_EFC3 = (uint)(UInt16[DS, 0x3983] * 0x10 + UInt16[DS, 0x3981] - cs1 * 0x10);
    switch(targetAddress_1000_EFC3) {
      case 0x464EF : FarCall(cs1, 0xEFC7, spice86_generated_label_call_target_563E_010F_0564EF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EFC3));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_EFC7_01EFC7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_EFC7_01EFC7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xEFD3: goto label_1000_EFD3_1EFD3;break; // Target of external jump from 0x1EFC0
      case 0xEFD5: goto label_1000_EFD5_1EFD5;break; // Target of external jump from 0x1EFA7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_EFC7_1EFC7:
    // MOV [0xdbcd],AL (1000_EFC7 / 0x1EFC7)
    UInt8[DS, 0xDBCD] = AL;
    State.IncCycles();
    // MOV word ptr [0xdbce],BX (1000_EFCA / 0x1EFCA)
    UInt16[DS, 0xDBCE] = BX;
    State.IncCycles();
    // MOV word ptr [0xdbd0],CX (1000_EFCE / 0x1EFCE)
    UInt16[DS, 0xDBD0] = CX;
    State.IncCycles();
    // POP CX (1000_EFD2 / 0x1EFD2)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_EFD3_1EFD3:
    // POP BX (1000_EFD3 / 0x1EFD3)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_EFD4 / 0x1EFD4)
    return NearRet();
    State.IncCycles();
    label_1000_EFD5_1EFD5:
    // MOV byte ptr [0xce72],0xa (1000_EFD5 / 0x1EFD5)
    UInt8[DS, 0xCE72] = 0xA;
    State.IncCycles();
    // POP DS (1000_EFDA / 0x1EFDA)
    DS = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_EFDB / 0x1EFDB)
    AX = Stack.Pop();
    State.IncCycles();
    // JMPF 0xf000:0000 (1000_EFDC / 0x1EFDC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_F000_0000_0F0000, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_EFE1_01EFE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EFE1_1EFE1:
    // CALL 0x1000:f08e (1000_EFE1 / 0x1EFE1)
    NearCall(cs1, 0xEFE4, spice86_generated_label_jump_target_1000_F08E_01F08E);
    State.IncCycles();
    // JMP 0x1000:f031 (1000_EFE4 / 0x1EFE4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(interrupt_handler_0x9_1000_EFE7_1EFE7, 0x1F031 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action interrupt_handler_0x9_1000_EFE7_1EFE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EFE7_1EFE7:
    // PUSH AX (1000_EFE7 / 0x1EFE7)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (1000_EFE8 / 0x1EFE8)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_EFE9 / 0x1EFE9)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_EFEA / 0x1EFEA)
    Stack.Push(DS);
    State.IncCycles();
    // MOV AX,0x1f4b (1000_EFEB / 0x1EFEB)
    AX = 0x1F4B;
    State.IncCycles();
    // MOV DS,AX (1000_EFEE / 0x1EFEE)
    DS = AX;
    State.IncCycles();
    // CLD  (1000_EFF0 / 0x1EFF0)
    DirectionFlag = false;
    State.IncCycles();
    // IN AL,0x60 (1000_EFF1 / 0x1EFF1)
    AL = Cpu.In8(0x60);
    State.IncCycles();
    // CMP AL,0xff (1000_EFF3 / 0x1EFF3)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:efe1 (1000_EFF5 / 0x1EFF5)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_EFE1_01EFE1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DI,AX (1000_EFF7 / 0x1EFF7)
    DI = AX;
    State.IncCycles();
    // AND DI,0x7f (1000_EFF9 / 0x1EFF9)
    DI &= 0x7F;
    State.IncCycles();
    // CMP DI,0x5a (1000_EFFC / 0x1EFFC)
    Alu.Sub16(DI, 0x5A);
    State.IncCycles();
    // JNC 0x1000:f031 (1000_EFFF / 0x1EFFF)
    if(!CarryFlag) {
      goto label_1000_F031_1F031;
    }
    State.IncCycles();
    // ADD DI,0xce81 (1000_F001 / 0x1F001)
    // DI += 0xCE81;
    DI = Alu.Add16(DI, 0xCE81);
    State.IncCycles();
    // CBW  (1000_F005 / 0x1F005)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // NOT AH (1000_F006 / 0x1F006)
    AH = (byte)~AH;
    State.IncCycles();
    // XCHG AH,AL (1000_F008 / 0x1F008)
    byte tmp_1000_F008 = AH;
    AH = AL;
    AL = tmp_1000_F008;
    State.IncCycles();
    // MOV byte ptr [DI],AL (1000_F00A / 0x1F00A)
    UInt8[DS, DI] = AL;
    State.IncCycles();
    // OR AL,AL (1000_F00C / 0x1F00C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:f031 (1000_F00E / 0x1F00E)
    if(ZeroFlag) {
      goto label_1000_F031_1F031;
    }
    State.IncCycles();
    // MOV AL,AH (1000_F010 / 0x1F010)
    AL = AH;
    State.IncCycles();
    // MOV [0xcee8],AL (1000_F012 / 0x1F012)
    UInt8[DS, 0xCEE8] = AL;
    State.IncCycles();
    // CMP AL,0x53 (1000_F015 / 0x1F015)
    Alu.Sub8(AL, 0x53);
    State.IncCycles();
    // JNZ 0x1000:f026 (1000_F017 / 0x1F017)
    if(!ZeroFlag) {
      goto label_1000_F026_1F026;
    }
    State.IncCycles();
    // MOV AL,[0xceb9] (1000_F019 / 0x1F019)
    AL = UInt8[DS, 0xCEB9];
    State.IncCycles();
    // ADD AL,byte ptr [0xce9e] (1000_F01C / 0x1F01C)
    AL += UInt8[DS, 0xCE9E];
    State.IncCycles();
    // CMP AL,0xfe (1000_F020 / 0x1F020)
    Alu.Sub8(AL, 0xFE);
    State.IncCycles();
    // JZ 0x1000:f052 (1000_F022 / 0x1F022)
    if(ZeroFlag) {
      // JZ target is JMPF, inlining.
      State.IncCycles();
      // JMPF 0xf000:fff0 (1000_F052 / 0x1F052)
      throw FailAsUntested("Would have been a goto but label label_F000_FFF0_FFFF0 does not exist because no instruction was found there that belongs to a function.");
    }
    State.IncCycles();
    // MOV AL,0x53 (1000_F024 / 0x1F024)
    AL = 0x53;
    State.IncCycles();
    label_1000_F026_1F026:
    // CMP AL,0x2e (1000_F026 / 0x1F026)
    Alu.Sub8(AL, 0x2E);
    State.IncCycles();
    // JNZ 0x1000:f031 (1000_F028 / 0x1F028)
    if(!ZeroFlag) {
      goto label_1000_F031_1F031;
    }
    State.IncCycles();
    // CMP byte ptr [0xce9e],0xff (1000_F02A / 0x1F02A)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    State.IncCycles();
    // JZ 0x1000:f057 (1000_F02F / 0x1F02F)
    if(ZeroFlag) {
      goto label_1000_F057_1F057;
    }
    State.IncCycles();
    label_1000_F031_1F031:
    // CMP AL,0x70 (1000_F031 / 0x1F031)
    Alu.Sub8(AL, 0x70);
    State.IncCycles();
    // JNC 0x1000:f049 (1000_F033 / 0x1F033)
    if(!CarryFlag) {
      goto label_1000_F049_1F049;
    }
    State.IncCycles();
    // IN AL,0x61 (1000_F035 / 0x1F035)
    AL = Cpu.In8(0x61);
    State.IncCycles();
    // OR AL,0x80 (1000_F037 / 0x1F037)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    State.IncCycles();
    // OUT 0x61,AL (1000_F039 / 0x1F039)
    Cpu.Out8(0x61, AL);
    State.IncCycles();
    // AND AL,0x7f (1000_F03B / 0x1F03B)
    // AL &= 0x7F;
    AL = Alu.And8(AL, 0x7F);
    State.IncCycles();
    // OUT 0x61,AL (1000_F03D / 0x1F03D)
    Cpu.Out8(0x61, AL);
    State.IncCycles();
    // MOV AL,0x20 (1000_F03F / 0x1F03F)
    AL = 0x20;
    State.IncCycles();
    // CLI  (1000_F041 / 0x1F041)
    InterruptFlag = false;
    State.IncCycles();
    // OUT 0x20,AL (1000_F042 / 0x1F042)
    Cpu.Out8(0x20, AL);
    State.IncCycles();
    // POP DS (1000_F044 / 0x1F044)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F045 / 0x1F045)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_F046 / 0x1F046)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_F047 / 0x1F047)
    AX = Stack.Pop();
    State.IncCycles();
    // IRET  (1000_F048 / 0x1F048)
    return InterruptRet();
    State.IncCycles();
    label_1000_F049_1F049:
    // POP DS (1000_F049 / 0x1F049)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F04A / 0x1F04A)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_F04B / 0x1F04B)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_F04C / 0x1F04C)
    AX = Stack.Pop();
    State.IncCycles();
    // JMPF 0xf000:0004 (1000_F04D / 0x1F04D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(provided_interrupt_handler_0x9_F000_0004_F0004, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_F052_1F052:
    // JMPF 0xf000:fff0 (1000_F052 / 0x1F052)
    throw FailAsUntested("Would have been a goto but label label_F000_FFF0_FFFF0 does not exist because no instruction was found there that belongs to a function.");
    State.IncCycles();
    label_1000_F057_1F057:
    // CALL 0x1000:f05c (1000_F057 / 0x1F057)
    NearCall(cs1, 0xF05A, reset_keyboard_ida_1000_F05C_1F05C);
    State.IncCycles();
    // JMP 0x1000:f031 (1000_F05A / 0x1F05A)
    goto label_1000_F031_1F031;
  }
  
  public virtual Action reset_keyboard_ida_1000_F05C_1F05C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F05C_1F05C:
    // CMP byte ptr [0xceea],0x0 (1000_F05C / 0x1F05C)
    Alu.Sub8(UInt8[DS, 0xCEEA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:f08d (1000_F061 / 0x1F061)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_F08D / 0x1F08D)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_F063 / 0x1F063)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH ES (1000_F064 / 0x1F064)
    Stack.Push(ES);
    State.IncCycles();
    // MOV AH,0x34 (1000_F065 / 0x1F065)
    AH = 0x34;
    State.IncCycles();
    // INT 0x21 (1000_F067 / 0x1F067)
    Interrupt(0x21);
    State.IncCycles();
    // MOV AL,byte ptr ES:[BX] (1000_F069 / 0x1F069)
    AL = UInt8[ES, BX];
    State.IncCycles();
    // POP ES (1000_F06C / 0x1F06C)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_F06D / 0x1F06D)
    BX = Stack.Pop();
    State.IncCycles();
    // OR AL,AL (1000_F06E / 0x1F06E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:f08d (1000_F070 / 0x1F070)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_F08D / 0x1F08D)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0xceea] (1000_F072 / 0x1F072)
    UInt8[DS, 0xCEEA] = Alu.Inc8(UInt8[DS, 0xCEEA]);
    State.IncCycles();
    // IN AL,0x61 (1000_F076 / 0x1F076)
    AL = Cpu.In8(0x61);
    State.IncCycles();
    // OR AL,0x80 (1000_F078 / 0x1F078)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    State.IncCycles();
    // OUT 0x61,AL (1000_F07A / 0x1F07A)
    Cpu.Out8(0x61, AL);
    State.IncCycles();
    // AND AL,0x7c (1000_F07C / 0x1F07C)
    // AL &= 0x7C;
    AL = Alu.And8(AL, 0x7C);
    State.IncCycles();
    // OUT 0x61,AL (1000_F07E / 0x1F07E)
    Cpu.Out8(0x61, AL);
    State.IncCycles();
    // MOV AL,0x20 (1000_F080 / 0x1F080)
    AL = 0x20;
    State.IncCycles();
    // CLI  (1000_F082 / 0x1F082)
    InterruptFlag = false;
    State.IncCycles();
    // OUT 0x20,AL (1000_F083 / 0x1F083)
    Cpu.Out8(0x20, AL);
    State.IncCycles();
    // PUSH DS (1000_F085 / 0x1F085)
    Stack.Push(DS);
    State.IncCycles();
    // POP SS (1000_F086 / 0x1F086)
    SS = Stack.Pop();
    State.IncCycles();
    // MOV SP,0x3cbc (1000_F087 / 0x1F087)
    SP = 0x3CBC;
    State.IncCycles();
    // JMP 0x1000:003a (1000_F08A / 0x1F08A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_F08D_1F08D:
    // RET  (1000_F08D / 0x1F08D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_F08E_01F08E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F08E_1F08E:
    // PUSH ES (1000_F08E / 0x1F08E)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH DS (1000_F08F / 0x1F08F)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_F090 / 0x1F090)
    ES = Stack.Pop();
    State.IncCycles();
    // XOR AX,AX (1000_F091 / 0x1F091)
    AX = 0;
    State.IncCycles();
    // MOV [0xcee8],AL (1000_F093 / 0x1F093)
    UInt8[DS, 0xCEE8] = AL;
    State.IncCycles();
    // MOV DI,0xce81 (1000_F096 / 0x1F096)
    DI = 0xCE81;
    State.IncCycles();
    // MOV CX,0x67 (1000_F099 / 0x1F099)
    CX = 0x67;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_F09C / 0x1F09C)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP ES (1000_F09E / 0x1F09E)
    ES = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F09F / 0x1F09F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F0A0_01F0A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F0A0_1F0A0:
    // PUSH DI (1000_F0A0 / 0x1F0A0)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_F0A1 / 0x1F0A1)
    Stack.Push(ES);
    State.IncCycles();
    // INC byte ptr [0xce71] (1000_F0A2 / 0x1F0A2)
    UInt8[DS, 0xCE71] = Alu.Inc8(UInt8[DS, 0xCE71]);
    State.IncCycles();
    // PUSH DS (1000_F0A6 / 0x1F0A6)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_F0A7 / 0x1F0A7)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x4c60 (1000_F0A8 / 0x1F0A8)
    DI = 0x4C60;
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_F0AB / 0x1F0AB)
    NearCall(cs1, 0xF0AE, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    State.IncCycles();
    label_1000_F0AE_1F0AE:
    // DEC byte ptr [0xce71] (1000_F0AE / 0x1F0AE)
    UInt8[DS, 0xCE71] = Alu.Dec8(UInt8[DS, 0xCE71]);
    State.IncCycles();
    // MOV SI,DI (1000_F0B2 / 0x1F0B2)
    SI = DI;
    State.IncCycles();
    // POP ES (1000_F0B4 / 0x1F0B4)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F0B5 / 0x1F0B5)
    DI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:f403 (1000_F0B6 / 0x1F0B6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F403_01F403, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F0B9_01F0B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F0B9_1F0B9:
    // MOV word ptr [0xce78],SI (1000_F0B9 / 0x1F0B9)
    UInt16[DS, 0xCE78] = SI;
    State.IncCycles();
    // SHL SI,1 (1000_F0BD / 0x1F0BD)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr [SI + 0x31ff] (1000_F0BF / 0x1F0BF)
    SI = UInt16[DS, (ushort)(SI + 0x31FF)];
    State.IncCycles();
    // LODSW SI (1000_F0C3 / 0x1F0C3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,SI (1000_F0C4 / 0x1F0C4)
    DX = SI;
    State.IncCycles();
    // OR AX,AX (1000_F0C6 / 0x1F0C6)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:f0d6 (1000_F0C8 / 0x1F0C8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0D6_01F0D6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,AX (1000_F0CA / 0x1F0CA)
    CX = AX;
    State.IncCycles();
    // PUSH DX (1000_F0CC / 0x1F0CC)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:f11c (1000_F0CD / 0x1F0CD)
    NearCall(cs1, 0xF0D0, spice86_generated_label_call_target_1000_F11C_01F11C);
    State.IncCycles();
    label_1000_F0D0_1F0D0:
    // POP DX (1000_F0D0 / 0x1F0D0)
    DX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:f0d6 (1000_F0D1 / 0x1F0D1)
    NearCall(cs1, 0xF0D4, spice86_generated_label_call_target_1000_F0D6_01F0D6);
    State.IncCycles();
    label_1000_F0D4_1F0D4:
    // JMP 0x1000:f0ff (1000_F0D4 / 0x1F0D4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F0D6_01F0D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F0D6_1F0D6:
    // MOV AX,[0xce78] (1000_F0D6 / 0x1F0D6)
    AX = UInt16[DS, 0xCE78];
    State.IncCycles();
    // CMP AL,byte ptr [0xce70] (1000_F0D9 / 0x1F0D9)
    Alu.Sub8(AL, UInt8[DS, 0xCE70]);
    State.IncCycles();
    // JNC 0x1000:f0e4 (1000_F0DD / 0x1F0DD)
    if(!CarryFlag) {
      goto label_1000_F0E4_1F0E4;
    }
    State.IncCycles();
    // CALL 0x1000:ebe3 (1000_F0DF / 0x1F0DF)
    NearCall(cs1, 0xF0E2, not_observed_1000_EBE3_01EBE3);
    State.IncCycles();
    // JC 0x1000:f0f3 (1000_F0E2 / 0x1F0E2)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:f3d3 (1000_F0F3 / 0x1F0F3)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F3D3_01F3D3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_F0E4_1F0E4:
    // CALL 0x1000:f244 (1000_F0E4 / 0x1F0E4)
    NearCall(cs1, 0xF0E7, spice86_generated_label_call_target_1000_F244_01F244);
    State.IncCycles();
    label_1000_F0E7_1F0E7:
    // MOV AX,[0xce78] (1000_F0E7 / 0x1F0E7)
    AX = UInt16[DS, 0xCE78];
    State.IncCycles();
    // CMP AL,byte ptr [0xce70] (1000_F0EA / 0x1F0EA)
    Alu.Sub8(AL, UInt8[DS, 0xCE70]);
    State.IncCycles();
    // JNC 0x1000:f0f3 (1000_F0EE / 0x1F0EE)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:f3d3 (1000_F0F3 / 0x1F0F3)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F3D3_01F3D3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:eab7 (1000_F0F0 / 0x1F0F0)
    NearCall(cs1, 0xF0F3, memory_func_qq_ida_1000_EAB7_1EAB7);
    State.IncCycles();
    label_1000_F0F3_1F0F3:
    // JMP 0x1000:f3d3 (1000_F0F3 / 0x1F0F3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F3D3_01F3D3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F0F6_01F0F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F0F6_1F0F6:
    // LES SI,[0x39b7] (1000_F0F6 / 0x1F0F6)
    ES = UInt16[DS, 0x39B9];
    SI = UInt16[DS, 0x39B7];
    State.IncCycles();
    // MOV word ptr [DI],SI (1000_F0FA / 0x1F0FA)
    UInt16[DS, DI] = SI;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],ES (1000_F0FC / 0x1F0FC)
    UInt16[DS, (ushort)(DI + 0x2)] = ES;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F0FF_01F0FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F0FF_1F0FF:
    // MOV AX,CX (1000_F0FF / 0x1F0FF)
    AX = CX;
    State.IncCycles();
    // ADD AX,0xf (1000_F101 / 0x1F101)
    // AX += 0xF;
    AX = Alu.Add16(AX, 0xF);
    State.IncCycles();
    // RCR AX,1 (1000_F104 / 0x1F104)
    AX = Alu.Rcr16(AX, 0x1);
    State.IncCycles();
    // SHR AX,1 (1000_F106 / 0x1F106)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_F108 / 0x1F108)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_F10A / 0x1F10A)
    AX >>= 0x1;
    State.IncCycles();
    // ADD word ptr [0x39b9],AX (1000_F10C / 0x1F10C)
    // UInt16[DS, 0x39B9] += AX;
    UInt16[DS, 0x39B9] = Alu.Add16(UInt16[DS, 0x39B9], AX);
    State.IncCycles();
    // PUSH AX (1000_F110 / 0x1F110)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,[0x39b9] (1000_F111 / 0x1F111)
    AX = UInt16[DS, 0x39B9];
    State.IncCycles();
    // CMP AX,word ptr [0xce68] (1000_F114 / 0x1F114)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    State.IncCycles();
    // POP AX (1000_F118 / 0x1F118)
    AX = Stack.Pop();
    State.IncCycles();
    // JA 0x1000:f131 (1000_F119 / 0x1F119)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_F11B / 0x1F11B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F11C_01F11C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F11C_1F11C:
    // LES DI,[0x39b7] (1000_F11C / 0x1F11C)
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    State.IncCycles();
    // MOV AX,ES (1000_F120 / 0x1F120)
    AX = ES;
    State.IncCycles();
    // ADD AX,CX (1000_F122 / 0x1F122)
    AX += CX;
    State.IncCycles();
    // CMP AX,word ptr [0xce68] (1000_F124 / 0x1F124)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    State.IncCycles();
    // JNC 0x1000:f12b (1000_F128 / 0x1F128)
    if(!CarryFlag) {
      goto label_1000_F12B_1F12B;
    }
    State.IncCycles();
    // RET  (1000_F12A / 0x1F12A)
    return NearRet();
    State.IncCycles();
    label_1000_F12B_1F12B:
    // CALL 0x1000:f13f (1000_F12B / 0x1F12B)
    NearCall(cs1, 0xF12E, spice86_generated_label_call_target_1000_F13F_01F13F);
    State.IncCycles();
    label_1000_F12E_1F12E:
    // JMP 0x1000:f11c (1000_F12E / 0x1F12E)
    goto label_1000_F11C_1F11C;
  }
  
  public virtual Action not_observed_1000_F130_01F130(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F130_1F130:
    // POP CX (1000_F130 / 0x1F130)
    CX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_F131_01F131(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F131_1F131:
    // MOV AX,0x1f4b (1000_F131 / 0x1F131)
    AX = 0x1F4B;
    State.IncCycles();
    // MOV DS,AX (1000_F134 / 0x1F134)
    DS = AX;
    State.IncCycles();
    // MOV word ptr [0x3cbc],0x368d (1000_F136 / 0x1F136)
    UInt16[DS, 0x3CBC] = 0x368D;
    State.IncCycles();
    // JMP 0x1000:003a (1000_F13C / 0x1F13C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F13F_01F13F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F13F_1F13F:
    // PUSH CX (1000_F13F / 0x1F13F)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BP,word ptr [0x2] (1000_F140 / 0x1F140)
    BP = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV SI,0xd844 (1000_F144 / 0x1F144)
    SI = 0xD844;
    State.IncCycles();
    // MOV DI,0xda8c (1000_F147 / 0x1F147)
    DI = 0xDA8C;
    State.IncCycles();
    // MOV CX,0x91 (1000_F14A / 0x1F14A)
    CX = 0x91;
    State.IncCycles();
    // XOR DX,DX (1000_F14D / 0x1F14D)
    DX = 0;
    State.IncCycles();
    // MOV BX,DX (1000_F14F / 0x1F14F)
    BX = DX;
    State.IncCycles();
    label_1000_F151_1F151:
    // ADD DI,0x2 (1000_F151 / 0x1F151)
    DI += 0x2;
    State.IncCycles();
    // ADD SI,0x4 (1000_F154 / 0x1F154)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_F157 / 0x1F157)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // OR AX,AX (1000_F15A / 0x1F15A)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:f16a (1000_F15C / 0x1F15C)
    if(ZeroFlag) {
      goto label_1000_F16A_1F16A;
    }
    State.IncCycles();
    // MOV AX,BP (1000_F15E / 0x1F15E)
    AX = BP;
    State.IncCycles();
    // SUB AX,word ptr [DI] (1000_F160 / 0x1F160)
    AX -= UInt16[DS, DI];
    State.IncCycles();
    // CMP AX,DX (1000_F162 / 0x1F162)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JC 0x1000:f16a (1000_F164 / 0x1F164)
    if(CarryFlag) {
      goto label_1000_F16A_1F16A;
    }
    State.IncCycles();
    // MOV DX,AX (1000_F166 / 0x1F166)
    DX = AX;
    State.IncCycles();
    // MOV BX,SI (1000_F168 / 0x1F168)
    BX = SI;
    State.IncCycles();
    label_1000_F16A_1F16A:
    // LOOP 0x1000:f151 (1000_F16A / 0x1F16A)
    if(--CX != 0) {
      goto label_1000_F151_1F151;
    }
    State.IncCycles();
    // OR BX,BX (1000_F16C / 0x1F16C)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:f130 (1000_F16E / 0x1F16E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_F130_01F130, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,BX (1000_F170 / 0x1F170)
    AX = BX;
    State.IncCycles();
    // SUB AX,0xd844 (1000_F172 / 0x1F172)
    AX -= 0xD844;
    State.IncCycles();
    // SHR AX,1 (1000_F175 / 0x1F175)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_F177 / 0x1F177)
    AX >>= 0x1;
    State.IncCycles();
    // CMP AX,word ptr [0x2784] (1000_F179 / 0x1F179)
    Alu.Sub16(AX, UInt16[DS, 0x2784]);
    State.IncCycles();
    // JNZ 0x1000:f185 (1000_F17D / 0x1F17D)
    if(!ZeroFlag) {
      goto label_1000_F185_1F185;
    }
    State.IncCycles();
    // MOV word ptr [0x2784],0xffff (1000_F17F / 0x1F17F)
    UInt16[DS, 0x2784] = 0xFFFF;
    State.IncCycles();
    label_1000_F185_1F185:
    // XOR DX,DX (1000_F185 / 0x1F185)
    DX = 0;
    State.IncCycles();
    // XCHG word ptr [BX + 0x2],DX (1000_F187 / 0x1F187)
    ushort tmp_1000_F187 = UInt16[DS, (ushort)(BX + 0x2)];
    UInt16[DS, (ushort)(BX + 0x2)] = DX;
    DX = tmp_1000_F187;
    State.IncCycles();
    // MOV SI,0xd84a (1000_F18A / 0x1F18A)
    SI = 0xD84A;
    State.IncCycles();
    // MOV CX,0x91 (1000_F18D / 0x1F18D)
    CX = 0x91;
    State.IncCycles();
    // MOV BX,0x8000 (1000_F190 / 0x1F190)
    BX = 0x8000;
    State.IncCycles();
    label_1000_F193_1F193:
    // LODSW SI (1000_F193 / 0x1F193)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD SI,0x2 (1000_F194 / 0x1F194)
    SI += 0x2;
    State.IncCycles();
    // SUB AX,DX (1000_F197 / 0x1F197)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JC 0x1000:f1a1 (1000_F199 / 0x1F199)
    if(CarryFlag) {
      goto label_1000_F1A1_1F1A1;
    }
    State.IncCycles();
    // CMP AX,BX (1000_F19B / 0x1F19B)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JNC 0x1000:f1a1 (1000_F19D / 0x1F19D)
    if(!CarryFlag) {
      goto label_1000_F1A1_1F1A1;
    }
    State.IncCycles();
    // MOV BX,AX (1000_F19F / 0x1F19F)
    BX = AX;
    State.IncCycles();
    label_1000_F1A1_1F1A1:
    // LOOP 0x1000:f193 (1000_F1A1 / 0x1F1A1)
    if(--CX != 0) {
      goto label_1000_F193_1F193;
    }
    State.IncCycles();
    // OR BX,BX (1000_F1A3 / 0x1F1A3)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JS 0x1000:f1f5 (1000_F1A5 / 0x1F1A5)
    if(SignFlag) {
      goto label_1000_F1F5_1F1F5;
    }
    State.IncCycles();
    // MOV SI,0xd846 (1000_F1A7 / 0x1F1A7)
    SI = 0xD846;
    State.IncCycles();
    // MOV CX,0x91 (1000_F1AA / 0x1F1AA)
    CX = 0x91;
    State.IncCycles();
    label_1000_F1AD_1F1AD:
    // ADD SI,0x4 (1000_F1AD / 0x1F1AD)
    SI += 0x4;
    State.IncCycles();
    // CMP word ptr [SI],DX (1000_F1B0 / 0x1F1B0)
    Alu.Sub16(UInt16[DS, SI], DX);
    State.IncCycles();
    // JC 0x1000:f1b6 (1000_F1B2 / 0x1F1B2)
    if(CarryFlag) {
      goto label_1000_F1B6_1F1B6;
    }
    State.IncCycles();
    // SUB word ptr [SI],BX (1000_F1B4 / 0x1F1B4)
    // UInt16[DS, SI] -= BX;
    UInt16[DS, SI] = Alu.Sub16(UInt16[DS, SI], BX);
    State.IncCycles();
    label_1000_F1B6_1F1B6:
    // LOOP 0x1000:f1ad (1000_F1B6 / 0x1F1B6)
    if(--CX != 0) {
      goto label_1000_F1AD_1F1AD;
    }
    State.IncCycles();
    // MOV SI,0xdbb2 (1000_F1B8 / 0x1F1B8)
    SI = 0xDBB2;
    State.IncCycles();
    // CMP word ptr [SI],DX (1000_F1BB / 0x1F1BB)
    Alu.Sub16(UInt16[DS, SI], DX);
    State.IncCycles();
    // JC 0x1000:f1c1 (1000_F1BD / 0x1F1BD)
    if(CarryFlag) {
      goto label_1000_F1C1_1F1C1;
    }
    State.IncCycles();
    // SUB word ptr [SI],BX (1000_F1BF / 0x1F1BF)
    // UInt16[DS, SI] -= BX;
    UInt16[DS, SI] = Alu.Sub16(UInt16[DS, SI], BX);
    State.IncCycles();
    label_1000_F1C1_1F1C1:
    // MOV ES,DX (1000_F1C1 / 0x1F1C1)
    ES = DX;
    State.IncCycles();
    // ADD DX,BX (1000_F1C3 / 0x1F1C3)
    // DX += BX;
    DX = Alu.Add16(DX, BX);
    State.IncCycles();
    // MOV DS,DX (1000_F1C5 / 0x1F1C5)
    DS = DX;
    State.IncCycles();
    // XOR SI,SI (1000_F1C7 / 0x1F1C7)
    SI = 0;
    State.IncCycles();
    // MOV DI,SI (1000_F1C9 / 0x1F1C9)
    DI = SI;
    State.IncCycles();
    // MOV AX,SS:[0x39b9] (1000_F1CB / 0x1F1CB)
    AX = UInt16[SS, 0x39B9];
    State.IncCycles();
    // SUB AX,DX (1000_F1CF / 0x1F1CF)
    AX -= DX;
    State.IncCycles();
    // CMP AX,0x1000 (1000_F1D1 / 0x1F1D1)
    Alu.Sub16(AX, 0x1000);
    State.IncCycles();
    // JBE 0x1000:f1e3 (1000_F1D4 / 0x1F1D4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_F1E3_1F1E3;
    }
    State.IncCycles();
    // MOV CX,0x8000 (1000_F1D6 / 0x1F1D6)
    CX = 0x8000;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_F1D9 / 0x1F1D9)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOV DX,ES (1000_F1DB / 0x1F1DB)
    DX = ES;
    State.IncCycles();
    // ADD DX,0x1000 (1000_F1DD / 0x1F1DD)
    // DX += 0x1000;
    DX = Alu.Add16(DX, 0x1000);
    State.IncCycles();
    // JMP 0x1000:f1c1 (1000_F1E1 / 0x1F1E1)
    goto label_1000_F1C1_1F1C1;
    State.IncCycles();
    label_1000_F1E3_1F1E3:
    // MOV CX,AX (1000_F1E3 / 0x1F1E3)
    CX = AX;
    State.IncCycles();
    // SHL CX,1 (1000_F1E5 / 0x1F1E5)
    CX <<= 0x1;
    State.IncCycles();
    // SHL CX,1 (1000_F1E7 / 0x1F1E7)
    CX <<= 0x1;
    State.IncCycles();
    // SHL CX,1 (1000_F1E9 / 0x1F1E9)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_F1EB / 0x1F1EB)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // PUSH SS (1000_F1ED / 0x1F1ED)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_F1EE / 0x1F1EE)
    DS = Stack.Pop();
    State.IncCycles();
    // SUB word ptr [0x39b9],BX (1000_F1EF / 0x1F1EF)
    // UInt16[DS, 0x39B9] -= BX;
    UInt16[DS, 0x39B9] = Alu.Sub16(UInt16[DS, 0x39B9], BX);
    State.IncCycles();
    // POP CX (1000_F1F3 / 0x1F1F3)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F1F4 / 0x1F1F4)
    return NearRet();
    State.IncCycles();
    label_1000_F1F5_1F1F5:
    // MOV word ptr [0x39b9],DX (1000_F1F5 / 0x1F1F5)
    UInt16[DS, 0x39B9] = DX;
    State.IncCycles();
    // POP CX (1000_F1F9 / 0x1F1F9)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F1FA / 0x1F1FA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F1FB_01F1FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F1FB_1F1FB:
    // PUSH DX (1000_F1FB / 0x1F1FB)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:f2a7 (1000_F1FC / 0x1F1FC)
    NearCall(cs1, 0xF1FF, spice86_generated_label_call_target_1000_F2A7_01F2A7);
    State.IncCycles();
    label_1000_F1FF_1F1FF:
    // POP SI (1000_F1FF / 0x1F1FF)
    SI = Stack.Pop();
    State.IncCycles();
    // JNC 0x1000:f228 (1000_F200 / 0x1F200)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_F228 / 0x1F228)
      return NearRet();
    }
    State.IncCycles();
    // MOV DX,SI (1000_F202 / 0x1F202)
    DX = SI;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_F204_01F204, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_F204_01F204(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xF228: goto label_1000_F228_1F228;break; // Target of external jump from 0x1F200, 0x1F20E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_F204_1F204:
    // PUSH DX (1000_F204 / 0x1F204)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:f2fc (1000_F205 / 0x1F205)
    NearCall(cs1, 0xF208, spice86_generated_label_call_target_1000_F2FC_01F2FC);
    State.IncCycles();
    label_1000_F208_1F208:
    // MOV AX,0x3d00 (1000_F208 / 0x1F208)
    AX = 0x3D00;
    State.IncCycles();
    // INT 0x21 (1000_F20B / 0x1F20B)
    Interrupt(0x21);
    State.IncCycles();
    // POP DX (1000_F20D / 0x1F20D)
    DX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:f228 (1000_F20E / 0x1F20E)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_F228 / 0x1F228)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,AX (1000_F210 / 0x1F210)
    BX = AX;
    State.IncCycles();
    // XOR CX,CX (1000_F212 / 0x1F212)
    CX = 0;
    State.IncCycles();
    // MOV DX,CX (1000_F214 / 0x1F214)
    DX = CX;
    State.IncCycles();
    // MOV AX,0x4202 (1000_F216 / 0x1F216)
    AX = 0x4202;
    State.IncCycles();
    // INT 0x21 (1000_F219 / 0x1F219)
    Interrupt(0x21);
    State.IncCycles();
    // PUSH AX (1000_F21B / 0x1F21B)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DX (1000_F21C / 0x1F21C)
    Stack.Push(DX);
    State.IncCycles();
    // XOR CX,CX (1000_F21D / 0x1F21D)
    CX = 0;
    State.IncCycles();
    // MOV DX,CX (1000_F21F / 0x1F21F)
    DX = CX;
    State.IncCycles();
    // MOV AX,0x4200 (1000_F221 / 0x1F221)
    AX = 0x4200;
    State.IncCycles();
    // INT 0x21 (1000_F224 / 0x1F224)
    Interrupt(0x21);
    State.IncCycles();
    // POP BP (1000_F226 / 0x1F226)
    BP = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_F227 / 0x1F227)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_F228_1F228:
    // RET  (1000_F228 / 0x1F228)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F229_01F229(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F229_1F229:
    // CALL 0x1000:f1fb (1000_F229 / 0x1F229)
    NearCall(cs1, 0xF22C, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_F22C_01F22C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_F22C_01F22C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F22C_1F22C:
    // JC 0x1000:f22f (1000_F22C / 0x1F22C)
    if(CarryFlag) {
      goto label_1000_F22F_1F22F;
    }
    State.IncCycles();
    // RET  (1000_F22E / 0x1F22E)
    return NearRet();
    State.IncCycles();
    label_1000_F22F_1F22F:
    // MOV SI,DX (1000_F22F / 0x1F22F)
    SI = DX;
    State.IncCycles();
    // MOV DI,0x36c4 (1000_F231 / 0x1F231)
    DI = 0x36C4;
    State.IncCycles();
    // MOV CX,0xc (1000_F234 / 0x1F234)
    CX = 0xC;
    State.IncCycles();
    // PUSH DS (1000_F237 / 0x1F237)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_F238 / 0x1F238)
    ES = Stack.Pop();
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_F239 / 0x1F239)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV word ptr [0x3cbc],0x36b4 (1000_F23B / 0x1F23B)
    UInt16[DS, 0x3CBC] = 0x36B4;
    State.IncCycles();
    // JMP 0x1000:003a (1000_F241 / 0x1F241)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F244_01F244(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F244_1F244:
    // PUSH DX (1000_F244 / 0x1F244)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:f229 (1000_F245 / 0x1F245)
    NearCall(cs1, 0xF248, spice86_generated_label_call_target_1000_F229_01F229);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_F248_01F248, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_F248_01F248(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F248_1F248:
    // POP DX (1000_F248 / 0x1F248)
    DX = Stack.Pop();
    State.IncCycles();
    // CMP BX,word ptr [0xdbba] (1000_F249 / 0x1F249)
    Alu.Sub16(BX, UInt16[DS, 0xDBBA]);
    State.IncCycles();
    // JNZ 0x1000:f260 (1000_F24D / 0x1F24D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(read_ffff_to_esdi_and_close_ida_1000_F260_1F260, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:f2ea (1000_F24F / 0x1F24F)
    NearCall(cs1, 0xF252, spice86_generated_label_call_target_1000_F2EA_01F2EA);
    State.IncCycles();
    label_1000_F252_1F252:
    // JC 0x1000:f244 (1000_F252 / 0x1F252)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F244_01F244, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_F254 / 0x1F254)
    return NearRet();
  }
  
  public virtual Action open_nonres_file_ida_1000_F255_1F255(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F255_1F255:
    // PUSH DX (1000_F255 / 0x1F255)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_F256 / 0x1F256)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_F257 / 0x1F257)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:f204 (1000_F258 / 0x1F258)
    NearCall(cs1, 0xF25B, not_observed_1000_F204_01F204);
    State.IncCycles();
    // JC 0x1000:f22f (1000_F25B / 0x1F25B)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_F22C_01F22C, 0x1F22F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP ES (1000_F25D / 0x1F25D)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F25E / 0x1F25E)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_F25F / 0x1F25F)
    DX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(read_ffff_to_esdi_and_close_ida_1000_F260_1F260, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action read_ffff_to_esdi_and_close_ida_1000_F260_1F260(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F260_1F260:
    // PUSH DX (1000_F260 / 0x1F260)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_F261 / 0x1F261)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_F262 / 0x1F262)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH DS (1000_F263 / 0x1F263)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_F264 / 0x1F264)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_F265 / 0x1F265)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV CX,0xffff (1000_F266 / 0x1F266)
    CX = 0xFFFF;
    State.IncCycles();
    // MOV DX,DI (1000_F269 / 0x1F269)
    DX = DI;
    State.IncCycles();
    // MOV AH,0x3f (1000_F26B / 0x1F26B)
    AH = 0x3F;
    State.IncCycles();
    // INT 0x21 (1000_F26D / 0x1F26D)
    Interrupt(0x21);
    State.IncCycles();
    // POP DS (1000_F26F / 0x1F26F)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV CX,AX (1000_F270 / 0x1F270)
    CX = AX;
    State.IncCycles();
    // PUSHF  (1000_F272 / 0x1F272)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV AH,0x3e (1000_F273 / 0x1F273)
    AH = 0x3E;
    State.IncCycles();
    // INT 0x21 (1000_F275 / 0x1F275)
    Interrupt(0x21);
    State.IncCycles();
    // POPF  (1000_F277 / 0x1F277)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP ES (1000_F278 / 0x1F278)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F279 / 0x1F279)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_F27A / 0x1F27A)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F27B / 0x1F27B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_F27C_01F27C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F27C_1F27C:
    // PUSH CX (1000_F27C / 0x1F27C)
    Stack.Push(CX);
    State.IncCycles();
    // MOV AH,0x3c (1000_F27D / 0x1F27D)
    AH = 0x3C;
    State.IncCycles();
    // XOR CX,CX (1000_F27F / 0x1F27F)
    CX = 0;
    State.IncCycles();
    // INT 0x21 (1000_F281 / 0x1F281)
    Interrupt(0x21);
    State.IncCycles();
    // POP CX (1000_F283 / 0x1F283)
    CX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:f29a (1000_F284 / 0x1F284)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_F29A / 0x1F29A)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,AX (1000_F286 / 0x1F286)
    BX = AX;
    State.IncCycles();
    // PUSH DS (1000_F288 / 0x1F288)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_F289 / 0x1F289)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_F28A / 0x1F28A)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV DX,DI (1000_F28B / 0x1F28B)
    DX = DI;
    State.IncCycles();
    // MOV AH,0x40 (1000_F28D / 0x1F28D)
    AH = 0x40;
    State.IncCycles();
    // INT 0x21 (1000_F28F / 0x1F28F)
    Interrupt(0x21);
    State.IncCycles();
    // POP DS (1000_F291 / 0x1F291)
    DS = Stack.Pop();
    State.IncCycles();
    // SUB AX,CX (1000_F292 / 0x1F292)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // PUSHF  (1000_F294 / 0x1F294)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV AH,0x3e (1000_F295 / 0x1F295)
    AH = 0x3E;
    State.IncCycles();
    // INT 0x21 (1000_F297 / 0x1F297)
    Interrupt(0x21);
    State.IncCycles();
    // POPF  (1000_F299 / 0x1F299)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    label_1000_F29A_1F29A:
    // RET  (1000_F29A / 0x1F29A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F2A7_01F2A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F2A7_1F2A7:
    // PUSH DI (1000_F2A7 / 0x1F2A7)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_F2A8 / 0x1F2A8)
    Stack.Push(ES);
    State.IncCycles();
    // CMP word ptr [0xdbba],0x1 (1000_F2A9 / 0x1F2A9)
    Alu.Sub16(UInt16[DS, 0xDBBA], 0x1);
    State.IncCycles();
    // JC 0x1000:f2d3 (1000_F2AE / 0x1F2AE)
    if(CarryFlag) {
      goto label_1000_F2D3_1F2D3;
    }
    State.IncCycles();
    // MOV SI,DX (1000_F2B0 / 0x1F2B0)
    SI = DX;
    State.IncCycles();
    // CALL 0x1000:f314 (1000_F2B2 / 0x1F2B2)
    NearCall(cs1, 0xF2B5, spice86_generated_label_call_target_1000_F314_01F314);
    State.IncCycles();
    label_1000_F2B5_1F2B5:
    // JC 0x1000:f2d3 (1000_F2B5 / 0x1F2B5)
    if(CarryFlag) {
      goto label_1000_F2D3_1F2D3;
    }
    State.IncCycles();
    // CALL 0x1000:f3a7 (1000_F2B7 / 0x1F2B7)
    NearCall(cs1, 0xF2BA, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    State.IncCycles();
    label_1000_F2BA_1F2BA:
    // JC 0x1000:f2d3 (1000_F2BA / 0x1F2BA)
    if(CarryFlag) {
      goto label_1000_F2D3_1F2D3;
    }
    State.IncCycles();
    // XOR CX,CX (1000_F2BC / 0x1F2BC)
    CX = 0;
    State.IncCycles();
    // MOV CL,byte ptr ES:[DI + 0x5] (1000_F2BE / 0x1F2BE)
    CL = UInt8[ES, (ushort)(DI + 0x5)];
    State.IncCycles();
    // MOV BP,CX (1000_F2C2 / 0x1F2C2)
    BP = CX;
    State.IncCycles();
    // MOV CX,word ptr ES:[DI + 0x3] (1000_F2C4 / 0x1F2C4)
    CX = UInt16[ES, (ushort)(DI + 0x3)];
    State.IncCycles();
    // MOV AX,word ptr ES:[DI + 0x6] (1000_F2C8 / 0x1F2C8)
    AX = UInt16[ES, (ushort)(DI + 0x6)];
    State.IncCycles();
    // MOV DX,word ptr ES:[DI + 0x8] (1000_F2CC / 0x1F2CC)
    DX = UInt16[ES, (ushort)(DI + 0x8)];
    State.IncCycles();
    // CALL 0x1000:f2d6 (1000_F2D0 / 0x1F2D0)
    NearCall(cs1, 0xF2D3, spice86_generated_label_call_target_1000_F2D6_01F2D6);
    State.IncCycles();
    label_1000_F2D3_1F2D3:
    // POP ES (1000_F2D3 / 0x1F2D3)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F2D4 / 0x1F2D4)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F2D5 / 0x1F2D5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F2D6_01F2D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F2D6_1F2D6:
    // PUSH CX (1000_F2D6 / 0x1F2D6)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BX,word ptr SS:[0xdbba] (1000_F2D7 / 0x1F2D7)
    BX = UInt16[SS, 0xDBBA];
    State.IncCycles();
    // MOV CX,DX (1000_F2DC / 0x1F2DC)
    CX = DX;
    State.IncCycles();
    // MOV DX,AX (1000_F2DE / 0x1F2DE)
    DX = AX;
    State.IncCycles();
    // MOV AX,0x4200 (1000_F2E0 / 0x1F2E0)
    AX = 0x4200;
    State.IncCycles();
    // INT 0x21 (1000_F2E3 / 0x1F2E3)
    Interrupt(0x21);
    State.IncCycles();
    // POP CX (1000_F2E5 / 0x1F2E5)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F2E6 / 0x1F2E6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F2EA_01F2EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F2EA_1F2EA:
    // PUSH DS (1000_F2EA / 0x1F2EA)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_F2EB / 0x1F2EB)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_F2EC / 0x1F2EC)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV BX,word ptr SS:[0xdbba] (1000_F2ED / 0x1F2ED)
    BX = UInt16[SS, 0xDBBA];
    State.IncCycles();
    // MOV DX,DI (1000_F2F2 / 0x1F2F2)
    DX = DI;
    State.IncCycles();
    // MOV AH,0x3f (1000_F2F4 / 0x1F2F4)
    AH = 0x3F;
    State.IncCycles();
    // INT 0x21 (1000_F2F6 / 0x1F2F6)
    Interrupt(0x21);
    State.IncCycles();
    // CMP AX,CX (1000_F2F8 / 0x1F2F8)
    Alu.Sub16(AX, CX);
    State.IncCycles();
    // POP DS (1000_F2FA / 0x1F2FA)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_F2FB / 0x1F2FB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F2FC_01F2FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F2FC_1F2FC:
    // PUSH SI (1000_F2FC / 0x1F2FC)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_F2FD / 0x1F2FD)
    Stack.Push(DI);
    State.IncCycles();
    // MOV SI,DX (1000_F2FE / 0x1F2FE)
    SI = DX;
    State.IncCycles();
    // MOV DI,word ptr [0x38a6] (1000_F300 / 0x1F300)
    DI = UInt16[DS, 0x38A6];
    State.IncCycles();
    label_1000_F304_1F304:
    // MOV AL,byte ptr [SI] (1000_F304 / 0x1F304)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // INC SI (1000_F306 / 0x1F306)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV byte ptr [DI],AL (1000_F307 / 0x1F307)
    UInt8[DS, DI] = AL;
    State.IncCycles();
    // INC DI (1000_F309 / 0x1F309)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // OR AL,AL (1000_F30A / 0x1F30A)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:f304 (1000_F30C / 0x1F30C)
    if(!ZeroFlag) {
      goto label_1000_F304_1F304;
    }
    State.IncCycles();
    // POP DI (1000_F30E / 0x1F30E)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_F30F / 0x1F30F)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV DX,0x3826 (1000_F310 / 0x1F310)
    DX = 0x3826;
    State.IncCycles();
    // RET  (1000_F313 / 0x1F313)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F314_01F314(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F314_1F314:
    // PUSH SS (1000_F314 / 0x1F314)
    Stack.Push(SS);
    State.IncCycles();
    // POP ES (1000_F315 / 0x1F315)
    ES = Stack.Pop();
    State.IncCycles();
    // CMP word ptr [SI + 0x2],0x505c (1000_F316 / 0x1F316)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], 0x505C);
    State.IncCycles();
    // JZ 0x1000:f36c (1000_F31B / 0x1F31B)
    if(ZeroFlag) {
      goto label_1000_F36C_1F36C;
    }
    State.IncCycles();
    // PUSH SI (1000_F31D / 0x1F31D)
    Stack.Push(SI);
    State.IncCycles();
    // MOV CX,0x10 (1000_F31E / 0x1F31E)
    CX = 0x10;
    State.IncCycles();
    // MOV DX,CX (1000_F321 / 0x1F321)
    DX = CX;
    State.IncCycles();
    label_1000_F323_1F323:
    // LODSB SI (1000_F323 / 0x1F323)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_F324 / 0x1F324)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // LOOPNZ 0x1000:f323 (1000_F326 / 0x1F326)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_F323_1F323;
    }
    State.IncCycles();
    // JNZ 0x1000:f32b (1000_F328 / 0x1F328)
    if(!ZeroFlag) {
      goto label_1000_F32B_1F32B;
    }
    State.IncCycles();
    // INC CX (1000_F32A / 0x1F32A)
    CX++;
    State.IncCycles();
    label_1000_F32B_1F32B:
    // SUB CX,0x10 (1000_F32B / 0x1F32B)
    CX -= 0x10;
    State.IncCycles();
    // NEG CX (1000_F32E / 0x1F32E)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // POP SI (1000_F330 / 0x1F330)
    SI = Stack.Pop();
    State.IncCycles();
    // XOR DX,DX (1000_F331 / 0x1F331)
    DX = 0;
    State.IncCycles();
    // MOV AX,[0xce78] (1000_F333 / 0x1F333)
    AX = UInt16[DS, 0xCE78];
    State.IncCycles();
    // MOV DI,AX (1000_F336 / 0x1F336)
    DI = AX;
    State.IncCycles();
    // SHL DI,1 (1000_F338 / 0x1F338)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV DI,word ptr [DI + 0x31ff] (1000_F33A / 0x1F33A)
    DI = UInt16[DS, (ushort)(DI + 0x31FF)];
    State.IncCycles();
    // ADD DI,0x2 (1000_F33E / 0x1F33E)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // PUSH CX (1000_F341 / 0x1F341)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_F342 / 0x1F342)
    Stack.Push(SI);
    State.IncCycles();
    // REPE
    while (CX != 0) {
      CX--;
      // CMPSB ES:DI,SI (1000_F343 / 0x1F343)
      Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    State.IncCycles();
    // POP SI (1000_F345 / 0x1F345)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_F346 / 0x1F346)
    CX = Stack.Pop();
    State.IncCycles();
    // JZ 0x1000:f3a5 (1000_F347 / 0x1F347)
    if(ZeroFlag) {
      goto label_1000_F3A5_1F3A5;
    }
    State.IncCycles();
    // MOV BX,0x31ff (1000_F349 / 0x1F349)
    BX = 0x31FF;
    State.IncCycles();
    // MOV BP,0xf7 (1000_F34C / 0x1F34C)
    BP = 0xF7;
    State.IncCycles();
    label_1000_F34F_1F34F:
    // MOV DI,word ptr ES:[BX] (1000_F34F / 0x1F34F)
    DI = UInt16[ES, BX];
    State.IncCycles();
    // MOV AX,BX (1000_F352 / 0x1F352)
    AX = BX;
    State.IncCycles();
    // SUB AX,0x31ff (1000_F354 / 0x1F354)
    AX -= 0x31FF;
    State.IncCycles();
    // SHR AX,1 (1000_F357 / 0x1F357)
    AX >>= 0x1;
    State.IncCycles();
    // ADD BX,0x2 (1000_F359 / 0x1F359)
    BX += 0x2;
    State.IncCycles();
    // ADD DI,0x2 (1000_F35C / 0x1F35C)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // PUSH CX (1000_F35F / 0x1F35F)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_F360 / 0x1F360)
    Stack.Push(SI);
    State.IncCycles();
    // REPE
    while (CX != 0) {
      CX--;
      // CMPSB ES:DI,SI (1000_F361 / 0x1F361)
      Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    State.IncCycles();
    // POP SI (1000_F363 / 0x1F363)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_F364 / 0x1F364)
    CX = Stack.Pop();
    State.IncCycles();
    // JZ 0x1000:f3a5 (1000_F365 / 0x1F365)
    if(ZeroFlag) {
      goto label_1000_F3A5_1F3A5;
    }
    State.IncCycles();
    // DEC BP (1000_F367 / 0x1F367)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x1000:f34f (1000_F368 / 0x1F368)
    if(!ZeroFlag) {
      goto label_1000_F34F_1F34F;
    }
    State.IncCycles();
    // STC  (1000_F36A / 0x1F36A)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_F36B / 0x1F36B)
    return NearRet();
    State.IncCycles();
    label_1000_F36C_1F36C:
    // ADD SI,0x4 (1000_F36C / 0x1F36C)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LODSB SI (1000_F36F / 0x1F36F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SUB AL,0x40 (1000_F370 / 0x1F370)
    // AL -= 0x40;
    AL = Alu.Sub8(AL, 0x40);
    State.IncCycles();
    // MOV DL,AL (1000_F372 / 0x1F372)
    DL = AL;
    State.IncCycles();
    // XOR BX,BX (1000_F374 / 0x1F374)
    BX = 0;
    State.IncCycles();
    // MOV CX,0x3 (1000_F376 / 0x1F376)
    CX = 0x3;
    State.IncCycles();
    label_1000_F379_1F379:
    // LODSB SI (1000_F379 / 0x1F379)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0x41 (1000_F37A / 0x1F37A)
    Alu.Sub8(AL, 0x41);
    State.IncCycles();
    // JC 0x1000:f380 (1000_F37C / 0x1F37C)
    if(CarryFlag) {
      goto label_1000_F380_1F380;
    }
    State.IncCycles();
    // SUB AL,0x7 (1000_F37E / 0x1F37E)
    AL -= 0x7;
    State.IncCycles();
    label_1000_F380_1F380:
    // AND AL,0xf (1000_F380 / 0x1F380)
    AL &= 0xF;
    State.IncCycles();
    // SHL BX,1 (1000_F382 / 0x1F382)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_F384 / 0x1F384)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_F386 / 0x1F386)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_F388 / 0x1F388)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // OR BL,AL (1000_F38A / 0x1F38A)
    // BL |= AL;
    BL = Alu.Or8(BL, AL);
    State.IncCycles();
    // LOOP 0x1000:f379 (1000_F38C / 0x1F38C)
    if(--CX != 0) {
      goto label_1000_F379_1F379;
    }
    State.IncCycles();
    // LODSB SI (1000_F38E / 0x1F38E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0x4f (1000_F38F / 0x1F38F)
    Alu.Sub8(AL, 0x4F);
    State.IncCycles();
    // CMC  (1000_F391 / 0x1F391)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // RCL DL,1 (1000_F392 / 0x1F392)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // LODSB SI (1000_F394 / 0x1F394)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SUB AL,0x41 (1000_F395 / 0x1F395)
    // AL -= 0x41;
    AL = Alu.Sub8(AL, 0x41);
    State.IncCycles();
    // JC 0x1000:f3a3 (1000_F397 / 0x1F397)
    if(CarryFlag) {
      goto label_1000_F3A3_1F3A3;
    }
    State.IncCycles();
    // SHL AL,1 (1000_F399 / 0x1F399)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_F39B / 0x1F39B)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_F39D / 0x1F39D)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_F39F / 0x1F39F)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // OR BH,AL (1000_F3A1 / 0x1F3A1)
    // BH |= AL;
    BH = Alu.Or8(BH, AL);
    State.IncCycles();
    label_1000_F3A3_1F3A3:
    // MOV AX,BX (1000_F3A3 / 0x1F3A3)
    AX = BX;
    State.IncCycles();
    label_1000_F3A5_1F3A5:
    // CLC  (1000_F3A5 / 0x1F3A5)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_F3A6 / 0x1F3A6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F3A7_01F3A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F3A7_1F3A7:
    // LES DI,SS:[0xdbbc] (1000_F3A7 / 0x1F3A7)
    ES = UInt16[SS, 0xDBBE];
    DI = UInt16[SS, 0xDBBC];
    State.IncCycles();
    // SUB DI,0x5 (1000_F3AC / 0x1F3AC)
    DI -= 0x5;
    State.IncCycles();
    label_1000_F3AF_1F3AF:
    // ADD DI,0x5 (1000_F3AF / 0x1F3AF)
    DI += 0x5;
    State.IncCycles();
    // CMP DL,byte ptr ES:[DI + 0x4] (1000_F3B2 / 0x1F3B2)
    Alu.Sub8(DL, UInt8[ES, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JNZ 0x1000:f3bc (1000_F3B6 / 0x1F3B6)
    if(!ZeroFlag) {
      goto label_1000_F3BC_1F3BC;
    }
    State.IncCycles();
    // CMP AX,word ptr ES:[DI + 0x2] (1000_F3B8 / 0x1F3B8)
    Alu.Sub16(AX, UInt16[ES, (ushort)(DI + 0x2)]);
    State.IncCycles();
    label_1000_F3BC_1F3BC:
    // JA 0x1000:f3af (1000_F3BC / 0x1F3BC)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_F3AF_1F3AF;
    }
    State.IncCycles();
    // MOV DI,word ptr ES:[DI] (1000_F3BE / 0x1F3BE)
    DI = UInt16[ES, DI];
    State.IncCycles();
    // SUB DI,0xa (1000_F3C1 / 0x1F3C1)
    DI -= 0xA;
    State.IncCycles();
    label_1000_F3C4_1F3C4:
    // ADD DI,0xa (1000_F3C4 / 0x1F3C4)
    DI += 0xA;
    State.IncCycles();
    // CMP DL,byte ptr ES:[DI + 0x2] (1000_F3C7 / 0x1F3C7)
    Alu.Sub8(DL, UInt8[ES, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:f3d0 (1000_F3CB / 0x1F3CB)
    if(!ZeroFlag) {
      goto label_1000_F3D0_1F3D0;
    }
    State.IncCycles();
    // CMP AX,word ptr ES:[DI] (1000_F3CD / 0x1F3CD)
    Alu.Sub16(AX, UInt16[ES, DI]);
    State.IncCycles();
    label_1000_F3D0_1F3D0:
    // JA 0x1000:f3c4 (1000_F3D0 / 0x1F3D0)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_F3C4_1F3C4;
    }
    State.IncCycles();
    // RET  (1000_F3D2 / 0x1F3D2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_F3D3_01F3D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F3D3_1F3D3:
    // CMP byte ptr [0xce71],0x0 (1000_F3D3 / 0x1F3D3)
    Alu.Sub8(UInt8[DS, 0xCE71], 0x0);
    State.IncCycles();
    // JNZ 0x1000:f402 (1000_F3D8 / 0x1F3D8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_F402 / 0x1F402)
      return NearRet();
    }
    State.IncCycles();
    // PUSH CX (1000_F3DA / 0x1F3DA)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_F3DB / 0x1F3DB)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_F3DC / 0x1F3DC)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_F3DD / 0x1F3DD)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_F3DE / 0x1F3DE)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV DX,DI (1000_F3DF / 0x1F3DF)
    DX = DI;
    State.IncCycles();
    // ADD DX,CX (1000_F3E1 / 0x1F3E1)
    // DX += CX;
    DX = Alu.Add16(DX, CX);
    State.IncCycles();
    // MOV CX,0x6 (1000_F3E3 / 0x1F3E3)
    CX = 0x6;
    State.IncCycles();
    // MOV SI,DI (1000_F3E6 / 0x1F3E6)
    SI = DI;
    State.IncCycles();
    // XOR AX,AX (1000_F3E8 / 0x1F3E8)
    AX = 0;
    State.IncCycles();
    label_1000_F3EA_1F3EA:
    // LODSB SI (1000_F3EA / 0x1F3EA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // ADD AH,AL (1000_F3EB / 0x1F3EB)
    // AH += AL;
    AH = Alu.Add8(AH, AL);
    State.IncCycles();
    // LOOP 0x1000:f3ea (1000_F3ED / 0x1F3ED)
    if(--CX != 0) {
      goto label_1000_F3EA_1F3EA;
    }
    State.IncCycles();
    // CMP AH,0xab (1000_F3EF / 0x1F3EF)
    Alu.Sub8(AH, 0xAB);
    State.IncCycles();
    // JNZ 0x1000:f3fe (1000_F3F2 / 0x1F3F2)
    if(!ZeroFlag) {
      goto label_1000_F3FE_1F3FE;
    }
    State.IncCycles();
    // MOV SI,DI (1000_F3F4 / 0x1F3F4)
    SI = DI;
    State.IncCycles();
    // LODSW SI (1000_F3F6 / 0x1F3F6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_F3F7 / 0x1F3F7)
    DI = AX;
    State.IncCycles();
    // LODSB SI (1000_F3F9 / 0x1F3F9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_F3FA / 0x1F3FA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:f40d (1000_F3FC / 0x1F3FC)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F40D_01F40D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_F3FE_1F3FE:
    // STC  (1000_F3FE / 0x1F3FE)
    CarryFlag = true;
    State.IncCycles();
    // POP DS (1000_F3FF / 0x1F3FF)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F400 / 0x1F400)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_F401 / 0x1F401)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_F402_1F402:
    // RET  (1000_F402 / 0x1F402)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_F403_01F403(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_F403_1F403:
    // PUSH CX (1000_F403 / 0x1F403)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_F404 / 0x1F404)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_F405 / 0x1F405)
    Stack.Push(DS);
    State.IncCycles();
    // ADD SI,0x6 (1000_F406 / 0x1F406)
    SI += 0x6;
    State.IncCycles();
    // XOR BP,BP (1000_F409 / 0x1F409)
    BP = 0;
    State.IncCycles();
    // JMP 0x1000:f435 (1000_F40B / 0x1F40B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F40D_01F40D, 0x1F435 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_F40D_01F40D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xF435: goto label_1000_F435_1F435;break; // Target of external jump from 0x1F480, 0x1F40B, 0x1F43C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_F40D_1F40D:
    // LODSW SI (1000_F40D / 0x1F40D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_F40E / 0x1F40E)
    CX = AX;
    State.IncCycles();
    // SUB SI,0x5 (1000_F410 / 0x1F410)
    // SI -= 0x5;
    SI = Alu.Sub16(SI, 0x5);
    State.IncCycles();
    // MOV BP,SI (1000_F413 / 0x1F413)
    BP = SI;
    State.IncCycles();
    // ADD DI,SI (1000_F415 / 0x1F415)
    DI += SI;
    State.IncCycles();
    // ADD DI,0x40 (1000_F417 / 0x1F417)
    DI += 0x40;
    State.IncCycles();
    // ADD SI,CX (1000_F41A / 0x1F41A)
    SI += CX;
    State.IncCycles();
    // DEC SI (1000_F41C / 0x1F41C)
    SI--;
    State.IncCycles();
    // DEC DI (1000_F41D / 0x1F41D)
    DI--;
    State.IncCycles();
    // SUB CX,0x6 (1000_F41E / 0x1F41E)
    // CX -= 0x6;
    CX = Alu.Sub16(CX, 0x6);
    State.IncCycles();
    // STD  (1000_F421 / 0x1F421)
    DirectionFlag = true;
    State.IncCycles();
    // SHR CX,1 (1000_F422 / 0x1F422)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // JNC 0x1000:f427 (1000_F424 / 0x1F424)
    if(!CarryFlag) {
      goto label_1000_F427_1F427;
    }
    State.IncCycles();
    // MOVSB ES:DI,SI (1000_F426 / 0x1F426)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_1000_F427_1F427:
    // DEC SI (1000_F427 / 0x1F427)
    SI--;
    State.IncCycles();
    // DEC DI (1000_F428 / 0x1F428)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_F429 / 0x1F429)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // CLD  (1000_F42B / 0x1F42B)
    DirectionFlag = false;
    State.IncCycles();
    // MOV SI,DI (1000_F42C / 0x1F42C)
    SI = DI;
    State.IncCycles();
    // ADD SI,0x2 (1000_F42E / 0x1F42E)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // MOV DI,BP (1000_F431 / 0x1F431)
    DI = BP;
    State.IncCycles();
    // XOR BP,BP (1000_F433 / 0x1F433)
    BP = 0;
    State.IncCycles();
    label_1000_F435_1F435:
    // SHR BP,1 (1000_F435 / 0x1F435)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JZ 0x1000:f43e (1000_F437 / 0x1F437)
    if(ZeroFlag) {
      goto label_1000_F43E_1F43E;
    }
    State.IncCycles();
    // JNC 0x1000:f446 (1000_F439 / 0x1F439)
    if(!CarryFlag) {
      goto label_1000_F446_1F446;
    }
    State.IncCycles();
    label_1000_F43B_1F43B:
    // MOVSB ES:DI,SI (1000_F43B / 0x1F43B)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // JMP 0x1000:f435 (1000_F43C / 0x1F43C)
    goto label_1000_F435_1F435;
    State.IncCycles();
    label_1000_F43E_1F43E:
    // LODSW SI (1000_F43E / 0x1F43E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_F43F / 0x1F43F)
    BP = AX;
    State.IncCycles();
    // STC  (1000_F441 / 0x1F441)
    CarryFlag = true;
    State.IncCycles();
    // RCR BP,1 (1000_F442 / 0x1F442)
    BP = Alu.Rcr16(BP, 0x1);
    State.IncCycles();
    // JC 0x1000:f43b (1000_F444 / 0x1F444)
    if(CarryFlag) {
      goto label_1000_F43B_1F43B;
    }
    State.IncCycles();
    label_1000_F446_1F446:
    // XOR CX,CX (1000_F446 / 0x1F446)
    CX = 0;
    State.IncCycles();
    // SHR BP,1 (1000_F448 / 0x1F448)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JNZ 0x1000:f452 (1000_F44A / 0x1F44A)
    if(!ZeroFlag) {
      goto label_1000_F452_1F452;
    }
    State.IncCycles();
    // LODSW SI (1000_F44C / 0x1F44C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_F44D / 0x1F44D)
    BP = AX;
    State.IncCycles();
    // STC  (1000_F44F / 0x1F44F)
    CarryFlag = true;
    State.IncCycles();
    // RCR BP,1 (1000_F450 / 0x1F450)
    BP = Alu.Rcr16(BP, 0x1);
    State.IncCycles();
    label_1000_F452_1F452:
    // JC 0x1000:f482 (1000_F452 / 0x1F452)
    if(CarryFlag) {
      goto label_1000_F482_1F482;
    }
    State.IncCycles();
    // SHR BP,1 (1000_F454 / 0x1F454)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JNZ 0x1000:f45e (1000_F456 / 0x1F456)
    if(!ZeroFlag) {
      goto label_1000_F45E_1F45E;
    }
    State.IncCycles();
    // LODSW SI (1000_F458 / 0x1F458)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_F459 / 0x1F459)
    BP = AX;
    State.IncCycles();
    // STC  (1000_F45B / 0x1F45B)
    CarryFlag = true;
    State.IncCycles();
    // RCR BP,1 (1000_F45C / 0x1F45C)
    BP = Alu.Rcr16(BP, 0x1);
    State.IncCycles();
    label_1000_F45E_1F45E:
    // RCL CX,1 (1000_F45E / 0x1F45E)
    CX = Alu.Rcl16(CX, 0x1);
    State.IncCycles();
    // SHR BP,1 (1000_F460 / 0x1F460)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JNZ 0x1000:f46a (1000_F462 / 0x1F462)
    if(!ZeroFlag) {
      goto label_1000_F46A_1F46A;
    }
    State.IncCycles();
    // LODSW SI (1000_F464 / 0x1F464)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_F465 / 0x1F465)
    BP = AX;
    State.IncCycles();
    // STC  (1000_F467 / 0x1F467)
    CarryFlag = true;
    State.IncCycles();
    // RCR BP,1 (1000_F468 / 0x1F468)
    BP = Alu.Rcr16(BP, 0x1);
    State.IncCycles();
    label_1000_F46A_1F46A:
    // RCL CX,1 (1000_F46A / 0x1F46A)
    CX = Alu.Rcl16(CX, 0x1);
    State.IncCycles();
    // LODSB SI (1000_F46C / 0x1F46C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,0xff (1000_F46D / 0x1F46D)
    AH = 0xFF;
    State.IncCycles();
    label_1000_F46F_1F46F:
    // ADD AX,DI (1000_F46F / 0x1F46F)
    // AX += DI;
    AX = Alu.Add16(AX, DI);
    State.IncCycles();
    // XCHG AX,SI (1000_F471 / 0x1F471)
    ushort tmp_1000_F471 = AX;
    AX = SI;
    SI = tmp_1000_F471;
    State.IncCycles();
    // MOV BX,DS (1000_F472 / 0x1F472)
    BX = DS;
    State.IncCycles();
    // MOV DX,ES (1000_F474 / 0x1F474)
    DX = ES;
    State.IncCycles();
    // MOV DS,DX (1000_F476 / 0x1F476)
    DS = DX;
    State.IncCycles();
    // INC CX (1000_F478 / 0x1F478)
    CX++;
    State.IncCycles();
    // INC CX (1000_F479 / 0x1F479)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_F47A / 0x1F47A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV DS,BX (1000_F47C / 0x1F47C)
    DS = BX;
    State.IncCycles();
    // MOV SI,AX (1000_F47E / 0x1F47E)
    SI = AX;
    State.IncCycles();
    // JMP 0x1000:f435 (1000_F480 / 0x1F480)
    goto label_1000_F435_1F435;
    State.IncCycles();
    label_1000_F482_1F482:
    // LODSW SI (1000_F482 / 0x1F482)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CL,AL (1000_F483 / 0x1F483)
    CL = AL;
    State.IncCycles();
    // SHR AX,1 (1000_F485 / 0x1F485)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_F487 / 0x1F487)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_F489 / 0x1F489)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // OR AH,0xe0 (1000_F48B / 0x1F48B)
    AH |= 0xE0;
    State.IncCycles();
    // AND CL,0x7 (1000_F48E / 0x1F48E)
    // CL &= 0x7;
    CL = Alu.And8(CL, 0x7);
    State.IncCycles();
    // JNZ 0x1000:f46f (1000_F491 / 0x1F491)
    if(!ZeroFlag) {
      goto label_1000_F46F_1F46F;
    }
    State.IncCycles();
    // MOV BX,AX (1000_F493 / 0x1F493)
    BX = AX;
    State.IncCycles();
    // LODSB SI (1000_F495 / 0x1F495)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV CL,AL (1000_F496 / 0x1F496)
    CL = AL;
    State.IncCycles();
    // MOV AX,BX (1000_F498 / 0x1F498)
    AX = BX;
    State.IncCycles();
    // OR CL,CL (1000_F49A / 0x1F49A)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JNZ 0x1000:f46f (1000_F49C / 0x1F49C)
    if(!ZeroFlag) {
      goto label_1000_F46F_1F46F;
    }
    State.IncCycles();
    // STC  (1000_F49E / 0x1F49E)
    CarryFlag = true;
    State.IncCycles();
    // MOV CX,DI (1000_F49F / 0x1F49F)
    CX = DI;
    State.IncCycles();
    // POP DS (1000_F4A1 / 0x1F4A1)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_F4A2 / 0x1F4A2)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD SP,0x2 (1000_F4A3 / 0x1F4A3)
    SP += 0x2;
    State.IncCycles();
    // SUB CX,DI (1000_F4A6 / 0x1F4A6)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    State.IncCycles();
    // RET  (1000_F4A8 / 0x1F4A8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0100_0335B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0100_335B0:
    // JMP 0x3000:3e17 (334B_0100 / 0x335B0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0967_033E17, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0103_0335B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0103_335B3:
    // JMP 0x3000:3e89 (334B_0103 / 0x335B3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_09D9_033E89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0106_0335B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0106_335B6:
    // JMP 0x3000:3e92 (334B_0106 / 0x335B6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_09E2_033E92, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0109_0335B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0109_335B9:
    // JMP 0x3000:4d38 (334B_0109 / 0x335B9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1888_034D38, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_010C_0335BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_010C_335BC:
    // JMP 0x3000:4df0 (334B_010C / 0x335BC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_1940_034DF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_010F_0335BF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_010F_335BF:
    // JMP 0x3000:440b (334B_010F / 0x335BF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0F5B_03440B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0112_0335C2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0112_335C2:
    // JMP 0x3000:4902 (334B_0112 / 0x335C2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_144F_0348FF, 0x34902 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0115_0335C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0115_335C5:
    // JMP 0x3000:50a5 (334B_0115 / 0x335C5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1BF5_0350A5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0118_0335C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0118_335C8:
    // JMP 0x3000:4ea7 (334B_0118 / 0x335C8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_19F7_034EA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_011B_0335CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_011B_335CB:
    // JMP 0x3000:4e29 (334B_011B / 0x335CB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1979_034E29, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_011E_0335CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_011E_335CE:
    // JMP 0x3000:4e2b (334B_011E / 0x335CE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_197B_034E2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0121_0335D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0121_335D1:
    // JMP 0x3000:502c (334B_0121 / 0x335D1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B7C_03502C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0124_0335D4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0124_335D4:
    // JMP 0x3000:503e (334B_0124 / 0x335D4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_012A_0335DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_012A_335DA:
    // JMP 0x3000:503c (334B_012A / 0x335DA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_1B8C_03503C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_012D_0335DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_012D_335DD:
    // JMP 0x3000:502c (334B_012D / 0x335DD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B7C_03502C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0130_0335E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0130_335E0:
    // JMP 0x3000:503e (334B_0130 / 0x335E0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0133_0335E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0133_335E3:
    // JMP 0x3000:507a (334B_0133 / 0x335E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1BCA_03507A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0136_0335E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0136_335E6:
    // JMP 0x3000:5097 (334B_0136 / 0x335E6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1BE7_035097, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0139_0335E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0139_335E9:
    // JMP 0x3000:4eb7 (334B_0139 / 0x335E9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1A07_034EB7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_013C_0335EC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_013C_335EC:
    // RETF  (334B_013C / 0x335EC)
    return FarRet();
  }
  
  public virtual Action VgaFunc21SetPixel_334B_013F_335EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_013F_335EF:
    // JMP 0x3000:40dd (334B_013F / 0x335EF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_0C2D_0340DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0142_0335F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0142_335F2:
    // JMP 0x3000:589b (334B_0142 / 0x335F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_23EB_03589B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0145_0335F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0145_335F5:
    // JMP 0x3000:5166 (334B_0145 / 0x335F5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1CB6_035166, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0148_0335F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0148_335F8:
    // JMP 0x3000:51b7 (334B_0148 / 0x335F8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1D07_0351B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_014B_0335FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_014B_335FB:
    // JMP 0x3000:50f6 (334B_014B / 0x335FB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1C46_0350F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_014E_0335FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_014E_335FE:
    // JMP 0x3000:5126 (334B_014E / 0x335FE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1C76_035126, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0151_033601(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0151_33601:
    // JMP 0x3000:5a97 (334B_0151 / 0x33601)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_25E7_035A97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0154_033604(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0154_33604:
    // JMP 0x3000:3e25 (334B_0154 / 0x33604)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0975_033E25, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0157_033607(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0157_33607:
    // JMP 0x3000:53fc (334B_0157 / 0x33607)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_1F4C_0353FC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_015A_03360A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_015A_3360A:
    // JMP 0x3000:66b0 (334B_015A / 0x3360A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3200_0366B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_015D_03360D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_015D_3360D:
    // JMP 0x3000:4e79 (334B_015D / 0x3360D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_19C9_034E79, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0160_033610(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0160_33610:
    // JMP 0x3000:3fbc (334B_0160 / 0x33610)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_0B0C_033FBC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0163_033613(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0163_33613:
    // JMP 0x3000:40b6 (334B_0163 / 0x33613)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_0C06_0340B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0169_033619(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0169_33619:
    // JMP 0x3000:4235 (334B_0169 / 0x33619)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0D85_034235, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_016C_03361C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_016C_3361C:
    // JMP 0x3000:6e99 (334B_016C / 0x3361C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_334B_39E9_036E99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_016F_03361F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_016F_3361F:
    // JMP 0x3000:6ec4 (334B_016F / 0x3361F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3A14_036EC4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0172_033622(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0172_33622:
    // JMP 0x3000:3ef0 (334B_0172 / 0x33622)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0A40_033EF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0175_033625(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0175_33625:
    // JMP 0x3000:3f87 (334B_0175 / 0x33625)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0AD7_033F87, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_017B_03362B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_017B_3362B:
    // JMP 0x3000:3f18 (334B_017B / 0x3362B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0A68_033F18, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0187_033637(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0187_33637:
    // JMP 0x3000:3f26 (334B_0187 / 0x33637)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0A76_033F26, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0967_033E17(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0967_33E17:
    // MOV AH,0xf (334B_0967 / 0x33E17)
    AH = 0xF;
    State.IncCycles();
    // INT 0x10 (334B_0969 / 0x33E19)
    Interrupt(0x10);
    State.IncCycles();
    // CMP AL,0x13 (334B_096B / 0x33E1B)
    Alu.Sub8(AL, 0x13);
    State.IncCycles();
    // JZ 0x3000:3e24 (334B_096D / 0x33E1D)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_0974 / 0x33E24)
      return FarRet();
    }
    State.IncCycles();
    // MOV AX,0x13 (334B_096F / 0x33E1F)
    AX = 0x13;
    State.IncCycles();
    // INT 0x10 (334B_0972 / 0x33E22)
    Interrupt(0x10);
    State.IncCycles();
    label_334B_0974_33E24:
    // RETF  (334B_0974 / 0x33E24)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0975_033E25(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0975_33E25:
    // MOV CS:[0x1bd],AL (334B_0975 / 0x33E25)
    UInt8[cs2, 0x1BD] = AL;
    State.IncCycles();
    // PUSHF  (334B_0979 / 0x33E29)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // STI  (334B_097A / 0x33E2A)
    InterruptFlag = true;
    State.IncCycles();
    // MOV AX,0x40 (334B_097B / 0x33E2B)
    AX = 0x40;
    State.IncCycles();
    // MOV ES,AX (334B_097E / 0x33E2E)
    ES = AX;
    State.IncCycles();
    // MOV DX,word ptr ES:[0x63] (334B_0980 / 0x33E30)
    DX = UInt16[ES, 0x63];
    State.IncCycles();
    // ADD DL,0x6 (334B_0985 / 0x33E35)
    // DL += 0x6;
    DL = Alu.Add8(DL, 0x6);
    State.IncCycles();
    // MOV word ptr CS:[0x19f],DX (334B_0988 / 0x33E38)
    UInt16[cs2, 0x19F] = DX;
    State.IncCycles();
    // IN AL,DX (334B_098D / 0x33E3D)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // AND AL,0x8 (334B_098E / 0x33E3E)
    // AL &= 0x8;
    AL = Alu.And8(AL, 0x8);
    State.IncCycles();
    // CALL 0x3000:3e68 (334B_0990 / 0x33E40)
    NearCall(cs2, 0x993, spice86_generated_label_call_target_334B_09B8_033E68);
    State.IncCycles();
    label_334B_0993_33E43:
    // JNC 0x3000:3e64 (334B_0993 / 0x33E43)
    if(!CarryFlag) {
      goto label_334B_09B4_33E64;
    }
    State.IncCycles();
    // CALL 0x3000:3e68 (334B_0995 / 0x33E45)
    NearCall(cs2, 0x998, spice86_generated_label_call_target_334B_09B8_033E68);
    State.IncCycles();
    label_334B_0998_33E48:
    // JNC 0x3000:3e64 (334B_0998 / 0x33E48)
    if(!CarryFlag) {
      goto label_334B_09B4_33E64;
    }
    State.IncCycles();
    // MOV DI,SI (334B_099A / 0x33E4A)
    DI = SI;
    State.IncCycles();
    // MOV byte ptr CS:[0x1a2],AH (334B_099C / 0x33E4C)
    UInt8[cs2, 0x1A2] = AH;
    State.IncCycles();
    // CALL 0x3000:3e68 (334B_09A1 / 0x33E51)
    NearCall(cs2, 0x9A4, spice86_generated_label_call_target_334B_09B8_033E68);
    State.IncCycles();
    label_334B_09A4_33E54:
    // JNC 0x3000:3e64 (334B_09A4 / 0x33E54)
    if(!CarryFlag) {
      goto label_334B_09B4_33E64;
    }
    State.IncCycles();
    // CMP SI,DI (334B_09A6 / 0x33E56)
    Alu.Sub16(SI, DI);
    State.IncCycles();
    // NOT byte ptr CS:[0x1a1] (334B_09A8 / 0x33E58)
    UInt8[cs2, 0x1A1] = (byte)~UInt8[cs2, 0x1A1];
    State.IncCycles();
    // JNC 0x3000:3e64 (334B_09AD / 0x33E5D)
    if(!CarryFlag) {
      goto label_334B_09B4_33E64;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0x1a2],AH (334B_09AF / 0x33E5F)
    UInt8[cs2, 0x1A2] = AH;
    State.IncCycles();
    label_334B_09B4_33E64:
    // POPF  (334B_09B4 / 0x33E64)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JMP 0x3000:3fbc (334B_09B5 / 0x33E65)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_0B0C_033FBC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_09B8_033E68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_09B8_33E68:
    // MOV AH,AL (334B_09B8 / 0x33E68)
    AH = AL;
    State.IncCycles();
    // XOR SI,SI (334B_09BA / 0x33E6A)
    SI = 0;
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_09BC / 0x33E6C)
    BX = UInt16[SS, BP];
    State.IncCycles();
    label_334B_09BF_33E6F:
    // INC SI (334B_09BF / 0x33E6F)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // JNZ 0x3000:3e73 (334B_09C0 / 0x33E70)
    if(!ZeroFlag) {
      goto label_334B_09C3_33E73;
    }
    State.IncCycles();
    // DEC SI (334B_09C2 / 0x33E72)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    label_334B_09C3_33E73:
    // IN AL,DX (334B_09C3 / 0x33E73)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // AND AL,0x8 (334B_09C4 / 0x33E74)
    AL &= 0x8;
    State.IncCycles();
    // CMP AL,AH (334B_09C6 / 0x33E76)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JNZ 0x3000:3e87 (334B_09C8 / 0x33E78)
    if(!ZeroFlag) {
      goto label_334B_09D7_33E87;
    }
    State.IncCycles();
    // PUSH AX (334B_09CA / 0x33E7A)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_09CB / 0x33E7B)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,BX (334B_09CE / 0x33E7E)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x64 (334B_09D0 / 0x33E80)
    Alu.Sub16(AX, 0x64);
    State.IncCycles();
    // POP AX (334B_09D3 / 0x33E83)
    AX = Stack.Pop();
    State.IncCycles();
    // JC 0x3000:3e6f (334B_09D4 / 0x33E84)
    if(CarryFlag) {
      goto label_334B_09BF_33E6F;
    }
    State.IncCycles();
    // RET  (334B_09D6 / 0x33E86)
    return NearRet();
    State.IncCycles();
    label_334B_09D7_33E87:
    // STC  (334B_09D7 / 0x33E87)
    CarryFlag = true;
    State.IncCycles();
    // RET  (334B_09D8 / 0x33E88)
    return NearRet();
  }
  
  public virtual Action not_observed_334B_09D9_033E89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_09D9_33E89:
    // MOV AX,0xa000 (334B_09D9 / 0x33E89)
    AX = 0xA000;
    State.IncCycles();
    // MOV CX,0xfa00 (334B_09DC / 0x33E8C)
    CX = 0xFA00;
    State.IncCycles();
    // XOR BP,BP (334B_09DF / 0x33E8F)
    BP = 0;
    State.IncCycles();
    // RETF  (334B_09E1 / 0x33E91)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_09E2_033E92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_09E2_33E92:
    // PUSH AX (334B_09E2 / 0x33E92)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_09E3 / 0x33E93)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_09E4 / 0x33E94)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_09E5 / 0x33E95)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_09E6 / 0x33E96)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (334B_09E7 / 0x33E97)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_09E8 / 0x33E98)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH ES (334B_09E9 / 0x33E99)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_09EA / 0x33E9A)
    DS = Stack.Pop();
    State.IncCycles();
    // PUSH CS (334B_09EB / 0x33E9B)
    Stack.Push(cs2);
    State.IncCycles();
    // POP ES (334B_09EC / 0x33E9C)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x5bf (334B_09ED / 0x33E9D)
    DI = 0x5BF;
    State.IncCycles();
    // ADD DI,BX (334B_09F0 / 0x33EA0)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // MOV AX,CX (334B_09F2 / 0x33EA2)
    AX = CX;
    State.IncCycles();
    // MOV SI,DX (334B_09F4 / 0x33EA4)
    SI = DX;
    State.IncCycles();
    // REPE
    while (CX != 0) {
      CX--;
      // CMPSB ES:DI,SI (334B_09F6 / 0x33EA6)
      Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    State.IncCycles();
    // JZ 0x3000:3ec9 (334B_09F8 / 0x33EA8)
    if(ZeroFlag) {
      goto label_334B_0A19_33EC9;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0x1be],0x1 (334B_09FA / 0x33EAA)
    UInt8[cs2, 0x1BE] = 0x1;
    State.IncCycles();
    // MOV DI,0x5bf (334B_0A00 / 0x33EB0)
    DI = 0x5BF;
    State.IncCycles();
    // ADD DI,BX (334B_0A03 / 0x33EB3)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // MOV SI,DX (334B_0A05 / 0x33EB5)
    SI = DX;
    State.IncCycles();
    // MOV CX,AX (334B_0A07 / 0x33EB7)
    CX = AX;
    State.IncCycles();
    // PUSH CX (334B_0A09 / 0x33EB9)
    Stack.Push(CX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_0A0A / 0x33EBA)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP CX (334B_0A0C / 0x33EBC)
    CX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:3ed1 (334B_0A0D / 0x33EBD)
    NearCall(cs2, 0xA10, spice86_generated_label_call_target_334B_0A21_033ED1);
    State.IncCycles();
    label_334B_0A10_33EC0:
    // MOV DI,0x1bf (334B_0A10 / 0x33EC0)
    DI = 0x1BF;
    State.IncCycles();
    // ADD DI,BX (334B_0A13 / 0x33EC3)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // MOV AL,0x1 (334B_0A15 / 0x33EC5)
    AL = 0x1;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_0A17 / 0x33EC7)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    label_334B_0A19_33EC9:
    // POP ES (334B_0A19 / 0x33EC9)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_0A1A / 0x33ECA)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_0A1B / 0x33ECB)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0A1C / 0x33ECC)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_0A1D / 0x33ECD)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_0A1E / 0x33ECE)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_0A1F / 0x33ECF)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_0A20 / 0x33ED0)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0A21_033ED1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0A21_33ED1:
    // PUSH DX (334B_0A21 / 0x33ED1)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,BX (334B_0A22 / 0x33ED2)
    AX = BX;
    State.IncCycles();
    // MOV DL,0x3 (334B_0A24 / 0x33ED4)
    DL = 0x3;
    State.IncCycles();
    // DIV DL (334B_0A26 / 0x33ED6)
    Cpu.Div8(DL);
    State.IncCycles();
    // XOR AH,AH (334B_0A28 / 0x33ED8)
    AH = 0;
    State.IncCycles();
    // MOV BX,AX (334B_0A2A / 0x33EDA)
    BX = AX;
    State.IncCycles();
    // MOV AX,CX (334B_0A2C / 0x33EDC)
    AX = CX;
    State.IncCycles();
    // CMP AX,0x300 (334B_0A2E / 0x33EDE)
    Alu.Sub16(AX, 0x300);
    State.IncCycles();
    // JNC 0x3000:3eeb (334B_0A31 / 0x33EE1)
    if(!CarryFlag) {
      goto label_334B_0A3B_33EEB;
    }
    State.IncCycles();
    // DIV DL (334B_0A33 / 0x33EE3)
    Cpu.Div8(DL);
    State.IncCycles();
    // XOR AH,AH (334B_0A35 / 0x33EE5)
    AH = 0;
    State.IncCycles();
    // MOV CX,AX (334B_0A37 / 0x33EE7)
    CX = AX;
    State.IncCycles();
    // POP DX (334B_0A39 / 0x33EE9)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (334B_0A3A / 0x33EEA)
    return NearRet();
    State.IncCycles();
    label_334B_0A3B_33EEB:
    // MOV CX,0x100 (334B_0A3B / 0x33EEB)
    CX = 0x100;
    State.IncCycles();
    // POP DX (334B_0A3E / 0x33EEE)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (334B_0A3F / 0x33EEF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0A40_033EF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0A40_33EF0:
    // PUSH CX (334B_0A40 / 0x33EF0)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_0A41 / 0x33EF1)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_0A42 / 0x33EF2)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (334B_0A43 / 0x33EF3)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_0A44 / 0x33EF4)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH ES (334B_0A45 / 0x33EF5)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_0A46 / 0x33EF6)
    DS = Stack.Pop();
    State.IncCycles();
    // PUSH CS (334B_0A47 / 0x33EF7)
    Stack.Push(cs2);
    State.IncCycles();
    // POP ES (334B_0A48 / 0x33EF8)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x2bf (334B_0A49 / 0x33EF9)
    DI = 0x2BF;
    State.IncCycles();
    // ADD DI,BX (334B_0A4C / 0x33EFC)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // MOV SI,DX (334B_0A4E / 0x33EFE)
    SI = DX;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_0A50 / 0x33F00)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP ES (334B_0A52 / 0x33F02)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_0A53 / 0x33F03)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_0A54 / 0x33F04)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0A55 / 0x33F05)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_0A56 / 0x33F06)
    CX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_0A57 / 0x33F07)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0A58_033F08(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0A58_33F08:
    // PUSH CS (334B_0A58 / 0x33F08)
    Stack.Push(cs2);
    State.IncCycles();
    // PUSH CS (334B_0A59 / 0x33F09)
    Stack.Push(cs2);
    State.IncCycles();
    // POP DS (334B_0A5A / 0x33F0A)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (334B_0A5B / 0x33F0B)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x5bf (334B_0A5C / 0x33F0C)
    SI = 0x5BF;
    State.IncCycles();
    // MOV DI,0x2bf (334B_0A5F / 0x33F0F)
    DI = 0x2BF;
    State.IncCycles();
    // MOV CX,0x180 (334B_0A62 / 0x33F12)
    CX = 0x180;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_0A65 / 0x33F15)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // RET  (334B_0A67 / 0x33F17)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0A68_033F18(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0A68_33F18:
    // PUSH CX (334B_0A68 / 0x33F18)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_0A69 / 0x33F19)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_0A6A / 0x33F1A)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (334B_0A6B / 0x33F1B)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_0A6C / 0x33F1C)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x3000:3f08 (334B_0A6D / 0x33F1D)
    NearCall(cs2, 0xA70, spice86_generated_label_call_target_334B_0A58_033F08);
    State.IncCycles();
    label_334B_0A70_33F20:
    // POP ES (334B_0A70 / 0x33F20)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_0A71 / 0x33F21)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_0A72 / 0x33F22)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0A73 / 0x33F23)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_0A74 / 0x33F24)
    CX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_0A75 / 0x33F25)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0A76_033F26(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0A76_33F26:
    // PUSH AX (334B_0A76 / 0x33F26)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (334B_0A77 / 0x33F27)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_0A78 / 0x33F28)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_0A79 / 0x33F29)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (334B_0A7A / 0x33F2A)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_0A7B / 0x33F2B)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH CS (334B_0A7C / 0x33F2C)
    Stack.Push(cs2);
    State.IncCycles();
    // PUSH CS (334B_0A7D / 0x33F2D)
    Stack.Push(cs2);
    State.IncCycles();
    // POP DS (334B_0A7E / 0x33F2E)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (334B_0A7F / 0x33F2F)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x5bf (334B_0A80 / 0x33F30)
    SI = 0x5BF;
    State.IncCycles();
    // MOV DI,0x2bf (334B_0A83 / 0x33F33)
    DI = 0x2BF;
    State.IncCycles();
    // MOV CX,0x180 (334B_0A86 / 0x33F36)
    CX = 0x180;
    State.IncCycles();
    label_334B_0A89_33F39:
    // MOV AX,word ptr [DI] (334B_0A89 / 0x33F39)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // XCHG word ptr [SI],AX (334B_0A8B / 0x33F3B)
    ushort tmp_334B_0A8B = UInt16[DS, SI];
    UInt16[DS, SI] = AX;
    AX = tmp_334B_0A8B;
    State.IncCycles();
    // STOSW ES:DI (334B_0A8D / 0x33F3D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD SI,0x2 (334B_0A8E / 0x33F3E)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // LOOP 0x3000:3f39 (334B_0A91 / 0x33F41)
    if(--CX != 0) {
      goto label_334B_0A89_33F39;
    }
    State.IncCycles();
    // MOV AL,0x1 (334B_0A93 / 0x33F43)
    AL = 0x1;
    State.IncCycles();
    // MOV DI,0x1be (334B_0A95 / 0x33F45)
    DI = 0x1BE;
    State.IncCycles();
    // MOV CX,0x101 (334B_0A98 / 0x33F48)
    CX = 0x101;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_0A9B / 0x33F4B)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP ES (334B_0A9D / 0x33F4D)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_0A9E / 0x33F4E)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_0A9F / 0x33F4F)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0AA0 / 0x33F50)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_0AA1 / 0x33F51)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_0AA2 / 0x33F52)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_0AA3 / 0x33F53)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0AD7_033F87(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0AD7_33F87:
    // PUSH AX (334B_0AD7 / 0x33F87)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_0AD8 / 0x33F88)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_0AD9 / 0x33F89)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_0ADA / 0x33F8A)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_0ADB / 0x33F8B)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_0ADC / 0x33F8C)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (334B_0ADD / 0x33F8D)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (334B_0ADE / 0x33F8E)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH DS (334B_0ADF / 0x33F8F)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH CS (334B_0AE0 / 0x33F90)
    Stack.Push(cs2);
    State.IncCycles();
    // POP DS (334B_0AE1 / 0x33F91)
    DS = Stack.Pop();
    State.IncCycles();
    // PUSH CS (334B_0AE2 / 0x33F92)
    Stack.Push(cs2);
    State.IncCycles();
    // POP ES (334B_0AE3 / 0x33F93)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DL,AL (334B_0AE4 / 0x33F94)
    DL = AL;
    State.IncCycles();
    // OR DL,DL (334B_0AE6 / 0x33F96)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JNZ 0x3000:3f9b (334B_0AE8 / 0x33F98)
    if(!ZeroFlag) {
      goto label_334B_0AEB_33F9B;
    }
    State.IncCycles();
    // INC DX (334B_0AEA / 0x33F9A)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    label_334B_0AEB_33F9B:
    // MOV DI,0x5bf (334B_0AEB / 0x33F9B)
    DI = 0x5BF;
    State.IncCycles();
    // ADD DI,BX (334B_0AEE / 0x33F9E)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // LEA SI,[DI + 0xfd00] (334B_0AF0 / 0x33FA0)
    SI = (ushort)(DI + 0xFD00);
    State.IncCycles();
    // PUSH DI (334B_0AF4 / 0x33FA4)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH CX (334B_0AF5 / 0x33FA5)
    Stack.Push(CX);
    State.IncCycles();
    label_334B_0AF6_33FA6:
    // LODSB SI (334B_0AF6 / 0x33FA6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SUB AL,byte ptr [DI] (334B_0AF7 / 0x33FA7)
    // AL -= UInt8[DS, DI];
    AL = Alu.Sub8(AL, UInt8[DS, DI]);
    State.IncCycles();
    // CBW  (334B_0AF9 / 0x33FA9)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // IDIV DL (334B_0AFA / 0x33FAA)
    Cpu.IDiv8(DL);
    State.IncCycles();
    // ADD AL,byte ptr [DI] (334B_0AFC / 0x33FAC)
    // AL += UInt8[DS, DI];
    AL = Alu.Add8(AL, UInt8[DS, DI]);
    State.IncCycles();
    // STOSB ES:DI (334B_0AFE / 0x33FAE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x3000:3fa6 (334B_0AFF / 0x33FAF)
    if(--CX != 0) {
      goto label_334B_0AF6_33FA6;
    }
    State.IncCycles();
    // POP CX (334B_0B01 / 0x33FB1)
    CX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:3ed1 (334B_0B02 / 0x33FB2)
    NearCall(cs2, 0xB05, spice86_generated_label_call_target_334B_0A21_033ED1);
    State.IncCycles();
    label_334B_0B05_33FB5:
    // POP DX (334B_0B05 / 0x33FB5)
    DX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:4018 (334B_0B06 / 0x33FB6)
    NearCall(cs2, 0xB09, spice86_generated_label_call_target_334B_0B68_034018);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_0B09_033FB9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_0B09_033FB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0B09_33FB9:
    // POP DS (334B_0B09 / 0x33FB9)
    DS = Stack.Pop();
    State.IncCycles();
    // JMP 0x3000:400f (334B_0B0A / 0x33FBA)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_0B68_034018, 0x3400F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0B0C_033FBC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0B0C_33FBC:
    // CMP byte ptr CS:[0x1be],0x0 (334B_0B0C / 0x33FBC)
    Alu.Sub8(UInt8[cs2, 0x1BE], 0x0);
    State.IncCycles();
    // JZ 0x3000:4017 (334B_0B12 / 0x33FC2)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_0B67 / 0x34017)
      return FarRet();
    }
    State.IncCycles();
    // MOV byte ptr CS:[0x1be],0x0 (334B_0B14 / 0x33FC4)
    UInt8[cs2, 0x1BE] = 0x0;
    State.IncCycles();
    // PUSH AX (334B_0B1A / 0x33FCA)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_0B1B / 0x33FCB)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_0B1C / 0x33FCC)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_0B1D / 0x33FCD)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_0B1E / 0x33FCE)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_0B1F / 0x33FCF)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (334B_0B20 / 0x33FD0)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (334B_0B21 / 0x33FD1)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH CS (334B_0B22 / 0x33FD2)
    Stack.Push(cs2);
    State.IncCycles();
    // POP ES (334B_0B23 / 0x33FD3)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x1bf (334B_0B24 / 0x33FD4)
    DI = 0x1BF;
    State.IncCycles();
    // MOV CX,0x100 (334B_0B27 / 0x33FD7)
    CX = 0x100;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0B2A_033FDA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_0B2A_033FDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_0B2A_33FDA:
    // XOR AL,AL (334B_0B2A / 0x33FDA)
    AL = 0;
    State.IncCycles();
    // REPE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (334B_0B2C / 0x33FDC)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    State.IncCycles();
    // JZ 0x3000:4005 (334B_0B2E / 0x33FDE)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_0B68_034018, 0x34005 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC DI (334B_0B30 / 0x33FE0)
    DI--;
    State.IncCycles();
    // INC CX (334B_0B31 / 0x33FE1)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // MOV BX,CX (334B_0B32 / 0x33FE2)
    BX = CX;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (334B_0B34 / 0x33FE4)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // PUSH CX (334B_0B36 / 0x33FE6)
    Stack.Push(CX);
    State.IncCycles();
    // JNZ 0x3000:3fea (334B_0B37 / 0x33FE7)
    if(!ZeroFlag) {
      goto label_334B_0B3A_33FEA;
    }
    State.IncCycles();
    // INC CX (334B_0B39 / 0x33FE9)
    CX++;
    State.IncCycles();
    label_334B_0B3A_33FEA:
    // SUB CX,BX (334B_0B3A / 0x33FEA)
    CX -= BX;
    State.IncCycles();
    // NEG CX (334B_0B3C / 0x33FEC)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV DX,0x100 (334B_0B3E / 0x33FEE)
    DX = 0x100;
    State.IncCycles();
    // SUB DX,BX (334B_0B41 / 0x33FF1)
    // DX -= BX;
    DX = Alu.Sub16(DX, BX);
    State.IncCycles();
    // MOV BX,DX (334B_0B43 / 0x33FF3)
    BX = DX;
    State.IncCycles();
    // ADD DX,DX (334B_0B45 / 0x33FF5)
    DX += DX;
    State.IncCycles();
    // ADD DX,BX (334B_0B47 / 0x33FF7)
    DX += BX;
    State.IncCycles();
    // ADD DX,0x5bf (334B_0B49 / 0x33FF9)
    // DX += 0x5BF;
    DX = Alu.Add16(DX, 0x5BF);
    State.IncCycles();
    // CALL 0x3000:4018 (334B_0B4D / 0x33FFD)
    NearCall(cs2, 0xB50, spice86_generated_label_call_target_334B_0B68_034018);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_0B68_034018, 0x34000 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_0B68_034018(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24017: goto label_334B_0B67_34017;break; // Target of external jump from 0x33FC2
      case 0x24005: goto label_334B_0B55_34005;break; // Target of external jump from 0x33FDE
      case 0x2400F: goto label_334B_0B5F_3400F;break; // Target of external jump from 0x33FBA
      case 0x24000: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_0B50_34000:
    // POP CX (334B_0B50 / 0x34000)
    CX = Stack.Pop();
    State.IncCycles();
    // OR CX,CX (334B_0B51 / 0x34001)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JNZ 0x3000:3fda (334B_0B53 / 0x34003)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_0B2A_033FDA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_334B_0B55_34005:
    // MOV DI,0x1bf (334B_0B55 / 0x34005)
    DI = 0x1BF;
    State.IncCycles();
    // MOV CX,0x80 (334B_0B58 / 0x34008)
    CX = 0x80;
    State.IncCycles();
    // XOR AX,AX (334B_0B5B / 0x3400B)
    AX = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_0B5D / 0x3400D)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    label_334B_0B5F_3400F:
    // POP ES (334B_0B5F / 0x3400F)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (334B_0B60 / 0x34010)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_0B61 / 0x34011)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0B62 / 0x34012)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_0B63 / 0x34013)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_0B64 / 0x34014)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_0B65 / 0x34015)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_0B66 / 0x34016)
    AX = Stack.Pop();
    State.IncCycles();
    label_334B_0B67_34017:
    // RETF  (334B_0B67 / 0x34017)
    return FarRet();
    entry:
    State.IncCycles();
    label_334B_0B68_34018:
    // PUSH SI (334B_0B68 / 0x34018)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (334B_0B69 / 0x34019)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_0B6A / 0x3401A)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_0B6B / 0x3401B)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,DX (334B_0B6C / 0x3401C)
    SI = DX;
    State.IncCycles();
    // PUSHF  (334B_0B6E / 0x3401E)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CMP byte ptr [0x1a1],0x0 (334B_0B6F / 0x3401F)
    Alu.Sub8(UInt8[DS, 0x1A1], 0x0);
    State.IncCycles();
    // JZ 0x3000:4033 (334B_0B74 / 0x34024)
    if(ZeroFlag) {
      goto label_334B_0B83_34033;
    }
    State.IncCycles();
    // MOV DX,word ptr [0x19f] (334B_0B76 / 0x34026)
    DX = UInt16[DS, 0x19F];
    State.IncCycles();
    label_334B_0B7A_3402A:
    // IN AL,DX (334B_0B7A / 0x3402A)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // AND AL,0x8 (334B_0B7B / 0x3402B)
    AL &= 0x8;
    State.IncCycles();
    // CMP AL,byte ptr [0x1a2] (334B_0B7D / 0x3402D)
    Alu.Sub8(AL, UInt8[DS, 0x1A2]);
    State.IncCycles();
    // JNZ 0x3000:402a (334B_0B81 / 0x34031)
    if(!ZeroFlag) {
      goto label_334B_0B7A_3402A;
    }
    State.IncCycles();
    label_334B_0B83_34033:
    // CLI  (334B_0B83 / 0x34033)
    InterruptFlag = false;
    State.IncCycles();
    // MOV DX,0x3c8 (334B_0B84 / 0x34034)
    DX = 0x3C8;
    State.IncCycles();
    // MOV AL,BL (334B_0B87 / 0x34037)
    AL = BL;
    State.IncCycles();
    // OUT DX,AL (334B_0B89 / 0x34039)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // JMP 0x3000:403c (334B_0B8A / 0x3403A)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x3000:403e (334B_0B8C / 0x3403C)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x3000:4040 (334B_0B8E / 0x3403E)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x3000:4042 (334B_0B90 / 0x34040)
    goto label_334B_0B92_34042;
    State.IncCycles();
    label_334B_0B8C_3403C:
    // JMP 0x3000:403e (334B_0B8C / 0x3403C)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x3000:4040 (334B_0B8E / 0x3403E)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x3000:4042 (334B_0B90 / 0x34040)
    goto label_334B_0B92_34042;
    State.IncCycles();
    label_334B_0B8E_3403E:
    // JMP 0x3000:4040 (334B_0B8E / 0x3403E)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x3000:4042 (334B_0B90 / 0x34040)
    goto label_334B_0B92_34042;
    State.IncCycles();
    label_334B_0B90_34040:
    // JMP 0x3000:4042 (334B_0B90 / 0x34040)
    goto label_334B_0B92_34042;
    State.IncCycles();
    label_334B_0B92_34042:
    // INC DX (334B_0B92 / 0x34042)
    DX++;
    State.IncCycles();
    // CMP byte ptr CS:[0x1bd],0x0 (334B_0B93 / 0x34043)
    Alu.Sub8(UInt8[cs2, 0x1BD], 0x0);
    State.IncCycles();
    // JNZ 0x3000:4059 (334B_0B99 / 0x34049)
    if(!ZeroFlag) {
      goto label_334B_0BA9_34059;
    }
    State.IncCycles();
    // MOV AX,CX (334B_0B9B / 0x3404B)
    AX = CX;
    State.IncCycles();
    // ADD CX,CX (334B_0B9D / 0x3404D)
    CX += CX;
    State.IncCycles();
    // ADD CX,AX (334B_0B9F / 0x3404F)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    label_334B_0BA1_34051:
    // LODSB SI (334B_0BA1 / 0x34051)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OUT DX,AL (334B_0BA2 / 0x34052)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // LOOP 0x3000:4051 (334B_0BA3 / 0x34053)
    if(--CX != 0) {
      goto label_334B_0BA1_34051;
    }
    State.IncCycles();
    // POPF  (334B_0BA5 / 0x34055)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_0BA6 / 0x34056)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0BA7 / 0x34057)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (334B_0BA8 / 0x34058)
    return NearRet();
    State.IncCycles();
    label_334B_0BA9_34059:
    // LODSB SI (334B_0BA9 / 0x34059)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // AND AX,0x3f (334B_0BAA / 0x3405A)
    // AX &= 0x3F;
    AX = Alu.And16(AX, 0x3F);
    State.IncCycles();
    // MOV BP,AX (334B_0BAD / 0x3405D)
    BP = AX;
    State.IncCycles();
    // SHL BP,1 (334B_0BAF / 0x3405F)
    BP <<= 0x1;
    State.IncCycles();
    // SHL BP,1 (334B_0BB1 / 0x34061)
    BP <<= 0x1;
    State.IncCycles();
    // ADD BP,AX (334B_0BB3 / 0x34063)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    // LODSB SI (334B_0BB5 / 0x34065)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // AND AL,0x3f (334B_0BB6 / 0x34066)
    // AL &= 0x3F;
    AL = Alu.And8(AL, 0x3F);
    State.IncCycles();
    // MOV BX,AX (334B_0BB8 / 0x34068)
    BX = AX;
    State.IncCycles();
    // SHL BX,1 (334B_0BBA / 0x3406A)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (334B_0BBC / 0x3406C)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (334B_0BBE / 0x3406E)
    BX <<= 0x1;
    State.IncCycles();
    // ADD BX,AX (334B_0BC0 / 0x34070)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // LODSB SI (334B_0BC2 / 0x34072)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // AND AL,0x3f (334B_0BC3 / 0x34073)
    AL &= 0x3F;
    State.IncCycles();
    // SHL AX,1 (334B_0BC5 / 0x34075)
    AX <<= 0x1;
    State.IncCycles();
    // ADD AX,BP (334B_0BC7 / 0x34077)
    AX += BP;
    State.IncCycles();
    // ADD AX,BX (334B_0BC9 / 0x34079)
    AX += BX;
    State.IncCycles();
    // SHR AX,1 (334B_0BCB / 0x3407B)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_0BCD / 0x3407D)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_0BCF / 0x3407F)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_0BD1 / 0x34081)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // OUT DX,AL (334B_0BD3 / 0x34083)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // OUT DX,AL (334B_0BD4 / 0x34084)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // OUT DX,AL (334B_0BD5 / 0x34085)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // LOOP 0x3000:4059 (334B_0BD6 / 0x34086)
    if(--CX != 0) {
      goto label_334B_0BA9_34059;
    }
    State.IncCycles();
    // POPF  (334B_0BD8 / 0x34088)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_0BD9 / 0x34089)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_0BDA / 0x3408A)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (334B_0BDB / 0x3408B)
    return NearRet();
  }
  
}
