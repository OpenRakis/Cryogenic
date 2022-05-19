namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_0010_010010(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0010_10010:
    // CALL 0x1000:0309 (1000_0010 / 0x10010)
    NearCall(cs1, 0x13, spice86_generated_label_call_target_1000_0309_010309);
    label_1000_0013_10013:
    // CALL 0x1000:021c (1000_0013 / 0x10013)
    NearCall(cs1, 0x16, spice86_generated_label_call_target_1000_021C_01021C);
    label_1000_0016_10016:
    // CALL 0x1000:aeb7 (1000_0016 / 0x10016)
    NearCall(cs1, 0x19, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_0019_10019:
    // MOV byte ptr [0x3810],0x0 (1000_0019 / 0x10019)
    UInt8[DS, 0x3810] = 0x0;
    // MOV word ptr [0x2],0x2 (1000_001E / 0x1001E)
    UInt16[DS, 0x2] = 0x2;
    // CALL 0x1000:0083 (1000_0024 / 0x10024)
    NearCall(cs1, 0x27, spice86_generated_label_call_target_1000_0083_010083);
    label_1000_0027_10027:
    // MOV CL,0xff (1000_0027 / 0x10027)
    CL = 0xFF;
    // CALL 0x1000:b389 (1000_0029 / 0x10029)
    NearCall(cs1, 0x2C, spice86_generated_label_call_target_1000_B389_01B389);
    label_1000_002C_1002C:
    // CALL 0x1000:1860 (1000_002C / 0x1002C)
    NearCall(cs1, 0x2F, spice86_generated_label_call_target_1000_1860_011860);
    label_1000_002F_1002F:
    // MOV byte ptr [0xce80],0xff (1000_002F / 0x1002F)
    UInt8[DS, 0xCE80] = 0xFF;
    // CALL 0x1000:b2be (1000_0034 / 0x10034)
    NearCall(cs1, 0x37, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    label_1000_0037_10037:
    // CALL 0x1000:d815 (1000_0037 / 0x10037)
    NearCall(cs1, 0x3A, spice86_generated_label_call_target_1000_D815_01D815);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_003A_01003A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_003A_1003A:
    // CLD  (1000_003A / 0x1003A)
    DirectionFlag = false;
    // XOR AX,AX (1000_003B / 0x1003B)
    AX = 0;
    // INT 0x33 (1000_003D / 0x1003D)
    Interrupt(0x33);
    // MOV AX,0x1f4b (1000_003F / 0x1003F)
    AX = 0x1F4B;
    // MOV DS,AX (1000_0042 / 0x10042)
    DS = AX;
    // CALL 0x1000:e8d5 (1000_0044 / 0x10044)
    NearCall(cs1, 0x47, spice86_generated_label_call_target_1000_E8D5_01E8D5);
    label_1000_0047_10047:
    // CMP word ptr [0x3977],0x0 (1000_0047 / 0x10047)
    Alu.Sub16(UInt16[DS, 0x3977], 0x0);
    // JZ 0x1000:0056 (1000_004C / 0x1004C)
    if(ZeroFlag) {
      goto label_1000_0056_10056;
    }
    // CALLF [0x3975] (1000_004E / 0x1004E)
    // Indirect call to [0x3975], generating possible targets from emulator records
    uint targetAddress_1000_004E = (uint)(UInt16[DS, 0x3977] * 0x10 + UInt16[DS, 0x3975] - cs1 * 0x10);
    switch(targetAddress_1000_004E) {
      case 0x464E6 : FarCall(cs1, 0x52, spice86_generated_label_call_target_563E_0106_0564E6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_004E));
        break;
    }
    label_1000_0052_10052:
    // CALLF [0x398d] (1000_0052 / 0x10052)
    // Indirect call to [0x398d], generating possible targets from emulator records
    uint targetAddress_1000_0052 = (uint)(UInt16[DS, 0x398F] * 0x10 + UInt16[DS, 0x398D] - cs1 * 0x10);
    switch(targetAddress_1000_0052) {
      case 0x46453 : FarCall(cs1, 0x56, spice86_generated_label_call_target_5635_0103_056453); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0052));
        break;
    }
    label_1000_0056_10056:
    // MOV AX,0x3 (1000_0056 / 0x10056)
    AX = 0x3;
    // INT 0x10 (1000_0059 / 0x10059)
    Interrupt(0x10);
    // MOV SI,word ptr [0x3cbc] (1000_005B / 0x1005B)
    SI = UInt16[DS, 0x3CBC];
    // OR SI,SI (1000_005F / 0x1005F)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:006e (1000_0061 / 0x10061)
    if(ZeroFlag) {
      goto label_1000_006E_1006E;
    }
    label_1000_0063_10063:
    // LODSB SI (1000_0063 / 0x10063)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_0064 / 0x10064)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:006e (1000_0066 / 0x10066)
    if(ZeroFlag) {
      goto label_1000_006E_1006E;
    }
    // MOV AH,0xe (1000_0068 / 0x10068)
    AH = 0xE;
    // INT 0x10 (1000_006A / 0x1006A)
    Interrupt(0x10);
    // JMP 0x1000:0063 (1000_006C / 0x1006C)
    goto label_1000_0063_10063;
    label_1000_006E_1006E:
    // MOV AX,0xe0d (1000_006E / 0x1006E)
    AX = 0xE0D;
    // INT 0x10 (1000_0071 / 0x10071)
    Interrupt(0x10);
    // MOV AX,0xe0a (1000_0073 / 0x10073)
    AX = 0xE0A;
    // INT 0x10 (1000_0076 / 0x10076)
    Interrupt(0x10);
    // MOV DL,0xff (1000_0078 / 0x10078)
    DL = 0xFF;
    // MOV AX,0xc06 (1000_007A / 0x1007A)
    AX = 0xC06;
    // INT 0x21 (1000_007D / 0x1007D)
    Interrupt(0x21);
    // MOV AH,0x4c (1000_007F / 0x1007F)
    AH = 0x4C;
    // INT 0x21 (1000_0081 / 0x10081)
    Interrupt(0x21);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0083_010083, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0083_010083(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0083_10083:
    // CALL 0x1000:cfa0 (1000_0083 / 0x10083)
    NearCall(cs1, 0x86, spice86_generated_label_call_target_1000_CFA0_01CFA0);
    label_1000_0086_10086:
    // CALL 0x1000:c07c (1000_0086 / 0x10086)
    NearCall(cs1, 0x89, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0089_010089, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0089_010089(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0089_10089:
    // CALL 0x1000:c0ad (1000_0089 / 0x10089)
    NearCall(cs1, 0x8C, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    label_1000_008C_1008C:
    // MOV SI,0x1ae4 (1000_008C / 0x1008C)
    SI = 0x1AE4;
    // MOV BP,0xd1ef (1000_008F / 0x1008F)
    BP = 0xD1EF;
    // CALL 0x1000:c097 (1000_0092 / 0x10092)
    NearCall(cs1, 0x95, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0095_010095, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0095_010095(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0095_10095:
    // JMP 0x1000:1797 (1000_0095 / 0x10095)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_1797_011797, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0098_010098(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0098_10098:
    // MOV CX,word ptr ES:[DI] (1000_0098 / 0x10098)
    CX = UInt16[ES, DI];
    // SHR CX,1 (1000_009B / 0x1009B)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // MOV BX,DI (1000_009D / 0x1009D)
    BX = DI;
    label_1000_009F_1009F:
    // MOV AX,word ptr ES:[DI] (1000_009F / 0x1009F)
    AX = UInt16[ES, DI];
    // ADD AX,BX (1000_00A2 / 0x100A2)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    // STOSW ES:DI (1000_00A4 / 0x100A4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x1000:009f (1000_00A5 / 0x100A5)
    if(--CX != 0) {
      goto label_1000_009F_1009F;
    }
    // RET  (1000_00A7 / 0x100A7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_00B0_0100B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_00B0_100B0:
    // CALL 0x1000:00d1 (1000_00B0 / 0x100B0)
    NearCall(cs1, 0xB3, spice86_generated_label_call_target_1000_00D1_0100D1);
    label_1000_00B3_100B3:
    // CALL 0x1000:0169 (1000_00B3 / 0x100B3)
    NearCall(cs1, 0xB6, spice86_generated_label_call_target_1000_0169_010169);
    label_1000_00B6_100B6:
    // CALL 0x1000:da53 (1000_00B6 / 0x100B6)
    NearCall(cs1, 0xB9, spice86_generated_label_call_target_1000_DA53_01DA53);
    label_1000_00B9_100B9:
    // CALL 0x1000:b17a (1000_00B9 / 0x100B9)
    NearCall(cs1, 0xBC, spice86_generated_label_call_target_1000_B17A_01B17A);
    label_1000_00BC_100BC:
    // CALL 0x1000:b17a (1000_00BC / 0x100BC)
    NearCall(cs1, 0xBF, spice86_generated_label_call_target_1000_B17A_01B17A);
    label_1000_00BF_100BF:
    // XOR AX,AX (1000_00BF / 0x100BF)
    AX = 0;
    // MOV ES,AX (1000_00C1 / 0x100C1)
    ES = AX;
    // MOV AX,ES:[0x46c] (1000_00C3 / 0x100C3)
    AX = UInt16[ES, 0x46C];
    // MOV [0xd824],AX (1000_00C7 / 0x100C7)
    UInt16[DS, 0xD824] = AX;
    // MOV [0xd826],AX (1000_00CA / 0x100CA)
    UInt16[DS, 0xD826] = AX;
    // MOV [0xd828],AX (1000_00CD / 0x100CD)
    UInt16[DS, 0xD828] = AX;
    // RET  (1000_00D0 / 0x100D0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_00D1_0100D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_00D1_100D1:
    // PUSH DS (1000_00D1 / 0x100D1)
    Stack.Push(DS);
    // POP ES (1000_00D2 / 0x100D2)
    ES = Stack.Pop();
    // MOV DI,0x4948 (1000_00D3 / 0x100D3)
    DI = 0x4948;
    // MOV SI,0xba (1000_00D6 / 0x100D6)
    SI = 0xBA;
    // CALL 0x1000:f0b9 (1000_00D9 / 0x100D9)
    NearCall(cs1, 0xDC, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_00DC_0100DC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_00DC_0100DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_00DC_100DC:
    // MOV CX,0x18c (1000_00DC / 0x100DC)
    CX = 0x18C;
    // MOV SI,DI (1000_00DF / 0x100DF)
    SI = DI;
    label_1000_00E1_100E1:
    // LODSW SI (1000_00E1 / 0x100E1)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AL,AH (1000_00E2 / 0x100E2)
    byte tmp_1000_00E2 = AL;
    AL = AH;
    AH = tmp_1000_00E2;
    // STOSW ES:DI (1000_00E4 / 0x100E4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x1000:00e1 (1000_00E5 / 0x100E5)
    if(--CX != 0) {
      goto label_1000_00E1_100E1;
    }
    // MOV DI,0x4880 (1000_00E7 / 0x100E7)
    DI = 0x4880;
    // MOV CX,0x63 (1000_00EA / 0x100EA)
    CX = 0x63;
    // MOV SI,0x494a (1000_00ED / 0x100ED)
    SI = 0x494A;
    label_1000_00F0_100F0:
    // XOR AX,AX (1000_00F0 / 0x100F0)
    AX = 0;
    // MOV DX,0x1 (1000_00F2 / 0x100F2)
    DX = 0x1;
    // MOV BX,word ptr [SI] (1000_00F5 / 0x100F5)
    BX = UInt16[DS, SI];
    // SHL BX,1 (1000_00F7 / 0x100F7)
    BX <<= 0x1;
    // DIV BX (1000_00F9 / 0x100F9)
    Cpu.Div16(BX);
    // CMP word ptr [SI],DX (1000_00FB / 0x100FB)
    Alu.Sub16(UInt16[DS, SI], DX);
    // ADC AX,0x0 (1000_00FD / 0x100FD)
    AX = Alu.Adc16(AX, 0x0);
    // STOSW ES:DI (1000_0100 / 0x10100)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD SI,0x8 (1000_0101 / 0x10101)
    // SI += 0x8;
    SI = Alu.Add16(SI, 0x8);
    // LOOP 0x1000:00f0 (1000_0104 / 0x10104)
    if(--CX != 0) {
      goto label_1000_00F0_100F0;
    }
    // MOV SI,0xbf (1000_0106 / 0x10106)
    SI = 0xBF;
    // CALL 0x1000:f0b9 (1000_0109 / 0x10109)
    NearCall(cs1, 0x10C, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_010C_1010C:
    // MOV AX,DI (1000_010C / 0x1010C)
    AX = DI;
    // ADD AX,0x62fc (1000_010E / 0x1010E)
    // AX += 0x62FC;
    AX = Alu.Add16(AX, 0x62FC);
    // MOV [0xdcfe],AX (1000_0111 / 0x10111)
    UInt16[DS, 0xDCFE] = AX;
    // MOV word ptr [0xdd00],ES (1000_0114 / 0x10114)
    UInt16[DS, 0xDD00] = ES;
    // PUSH DS (1000_0118 / 0x10118)
    Stack.Push(DS);
    // POP ES (1000_0119 / 0x10119)
    ES = Stack.Pop();
    // MOV DI,0xaa76 (1000_011A / 0x1011A)
    DI = 0xAA76;
    // MOV SI,0xbd (1000_011D / 0x1011D)
    SI = 0xBD;
    // CALL 0x1000:f0a0 (1000_0120 / 0x10120)
    NearCall(cs1, 0x123, spice86_generated_label_call_target_1000_F0A0_01F0A0);
    label_1000_0123_10123:
    // CALL 0x1000:0098 (1000_0123 / 0x10123)
    NearCall(cs1, 0x126, spice86_generated_label_call_target_1000_0098_010098);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0126_010126, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0126_010126(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0126_10126:
    // MOV SI,0xbc (1000_0126 / 0x10126)
    SI = 0xBC;
    // CALL 0x1000:f0b9 (1000_0129 / 0x10129)
    NearCall(cs1, 0x12C, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_012C_1012C:
    // MOV word ptr [0xaa72],DI (1000_012C / 0x1012C)
    UInt16[DS, 0xAA72] = DI;
    // MOV word ptr [0xaa74],ES (1000_0130 / 0x10130)
    UInt16[DS, 0xAA74] = ES;
    // CALL 0x1000:0098 (1000_0134 / 0x10134)
    NearCall(cs1, 0x137, spice86_generated_label_call_target_1000_0098_010098);
    label_1000_0137_10137:
    // LES AX,[0x39b7] (1000_0137 / 0x10137)
    ES = UInt16[DS, 0x39B9];
    AX = UInt16[DS, 0x39B7];
    // MOV [0x47ac],AX (1000_013B / 0x1013B)
    UInt16[DS, 0x47AC] = AX;
    // MOV word ptr [0x47ae],ES (1000_013E / 0x1013E)
    UInt16[DS, 0x47AE] = ES;
    // MOV CX,0x1d4c (1000_0142 / 0x10142)
    CX = 0x1D4C;
    // CALL 0x1000:f0ff (1000_0145 / 0x10145)
    NearCall(cs1, 0x148, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    label_1000_0148_10148:
    // LES AX,[0x39b7] (1000_0148 / 0x10148)
    ES = UInt16[DS, 0x39B9];
    AX = UInt16[DS, 0x39B7];
    // MOV [0x47b0],AX (1000_014C / 0x1014C)
    UInt16[DS, 0x47B0] = AX;
    // MOV word ptr [0x47b2],ES (1000_014F / 0x1014F)
    UInt16[DS, 0x47B2] = ES;
    // MOV CX,0xadd4 (1000_0153 / 0x10153)
    CX = 0xADD4;
    // CALL 0x1000:f0ff (1000_0156 / 0x10156)
    NearCall(cs1, 0x159, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    label_1000_0159_10159:
    // CALL 0x1000:cfb9 (1000_0159 / 0x10159)
    NearCall(cs1, 0x15C, spice86_generated_label_call_target_1000_CFB9_01CFB9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_015C_01015C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_015C_01015C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_015C_1015C:
    // JMP 0x1000:c137 (1000_015C / 0x1015C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C137_01C137, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0169_010169(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0169_10169:
    // MOV AX,0x3a (1000_0169 / 0x10169)
    AX = 0x3A;
    // CALL 0x1000:c13e (1000_016C / 0x1016C)
    NearCall(cs1, 0x16F, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_016F_01016F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_016F_01016F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_016F_1016F:
    // PUSH DS (1000_016F / 0x1016F)
    Stack.Push(DS);
    // POP ES (1000_0170 / 0x10170)
    ES = Stack.Pop();
    // MOV DI,0x4c60 (1000_0171 / 0x10171)
    DI = 0x4C60;
    // PUSH DI (1000_0174 / 0x10174)
    Stack.Push(DI);
    // MOV AX,0x7 (1000_0175 / 0x10175)
    AX = 0x7;
    // MOV CX,0x100 (1000_0178 / 0x10178)
    CX = 0x100;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_017B / 0x1017B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // POP DI (1000_017D / 0x1017D)
    DI = Stack.Pop();
    // LES SI,[0xdbb0] (1000_017E / 0x1017E)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV CX,0xc5f9 (1000_0182 / 0x10182)
    CX = 0xC5F9;
    label_1000_0185_10185:
    // LODSB ES:SI (1000_0185 / 0x10185)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_0187 / 0x10187)
    BX = AX;
    // SHL BX,1 (1000_0189 / 0x10189)
    BX <<= 0x1;
    // INC word ptr [BX + DI] (1000_018B / 0x1018B)
    UInt16[DS, (ushort)(BX + DI)] = Alu.Inc16(UInt16[DS, (ushort)(BX + DI)]);
    // LOOP 0x1000:0185 (1000_018D / 0x1018D)
    if(--CX != 0) {
      goto label_1000_0185_10185;
    }
    // MOV SI,0x100 (1000_018F / 0x1018F)
    SI = 0x100;
    label_1000_0192_10192:
    // MOV DX,word ptr [SI + 0x2] (1000_0192 / 0x10192)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,word ptr [SI + 0x4] (1000_0195 / 0x10195)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:b5c5 (1000_0198 / 0x10198)
    NearCall(cs1, 0x19B, spice86_generated_label_call_target_1000_B5C5_01B5C5);
    label_1000_019B_1019B:
    // MOV word ptr [SI + 0x2],DX (1000_019B / 0x1019B)
    UInt16[DS, (ushort)(SI + 0x2)] = DX;
    // MOV word ptr [SI + 0x6],DI (1000_019E / 0x1019E)
    UInt16[DS, (ushort)(SI + 0x6)] = DI;
    // OR byte ptr ES:[DI],0x40 (1000_01A1 / 0x101A1)
    // UInt8[ES, DI] |= 0x40;
    UInt8[ES, DI] = Alu.Or8(UInt8[ES, DI], 0x40);
    // MOV ES,word ptr [0xdbb2] (1000_01A5 / 0x101A5)
    ES = UInt16[DS, 0xDBB2];
    // MOV AL,byte ptr ES:[DI] (1000_01A9 / 0x101A9)
    AL = UInt8[ES, DI];
    // MOV byte ptr [SI + 0x10],AL (1000_01AC / 0x101AC)
    UInt8[DS, (ushort)(SI + 0x10)] = AL;
    // XOR BX,BX (1000_01AF / 0x101AF)
    BX = 0;
    // MOV BL,AL (1000_01B1 / 0x101B1)
    BL = AL;
    // SHL BX,1 (1000_01B3 / 0x101B3)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV AX,word ptr [BX + 0x4c60] (1000_01B5 / 0x101B5)
    AX = UInt16[DS, (ushort)(BX + 0x4C60)];
    // MOV CL,0x4 (1000_01B9 / 0x101B9)
    CL = 0x4;
    // SHR AX,CL (1000_01BB / 0x101BB)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV byte ptr [SI + 0x11],AL (1000_01BD / 0x101BD)
    UInt8[DS, (ushort)(SI + 0x11)] = AL;
    // ADD SI,0x1c (1000_01C0 / 0x101C0)
    SI += 0x1C;
    // CMP byte ptr [SI],0xff (1000_01C3 / 0x101C3)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:0192 (1000_01C6 / 0x101C6)
    if(!ZeroFlag) {
      goto label_1000_0192_10192;
    }
    // MOV DI,0x100 (1000_01C8 / 0x101C8)
    DI = 0x100;
    label_1000_01CB_101CB:
    // MOV BP,0x1e0 (1000_01CB / 0x101CB)
    BP = 0x1E0;
    // MOV DX,word ptr [DI + 0x2] (1000_01CE / 0x101CE)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_01D1 / 0x101D1)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // CALL 0x1000:6603 (1000_01D4 / 0x101D4)
    NearCall(cs1, 0x1D7, spice86_generated_label_call_target_1000_6603_016603);
    label_1000_01D7_101D7:
    // ADD DI,0x1c (1000_01D7 / 0x101D7)
    DI += 0x1C;
    // CMP byte ptr [DI],0xff (1000_01DA / 0x101DA)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:01cb (1000_01DD / 0x101DD)
    if(!ZeroFlag) {
      goto label_1000_01CB_101CB;
    }
    // RET  (1000_01DF / 0x101DF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_01E0_0101E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_01E0_101E0:
    // MOV word ptr [SI + 0x4],DI (1000_01E0 / 0x101E0)
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    // MOV word ptr [SI + 0x6],DX (1000_01E3 / 0x101E3)
    UInt16[DS, (ushort)(SI + 0x6)] = DX;
    // MOV word ptr [SI + 0x8],BX (1000_01E6 / 0x101E6)
    UInt16[DS, (ushort)(SI + 0x8)] = BX;
    // MOV AL,byte ptr [DI] (1000_01E9 / 0x101E9)
    AL = UInt8[DS, DI];
    // MOV AH,byte ptr [SI + 0x12] (1000_01EB / 0x101EB)
    AH = UInt8[DS, (ushort)(SI + 0x12)];
    // AND AX,0x700f (1000_01EE / 0x101EE)
    AX &= 0x700F;
    // CMP AL,0x3 (1000_01F1 / 0x101F1)
    Alu.Sub8(AL, 0x3);
    // JBE 0x1000:0206 (1000_01F3 / 0x101F3)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0206_10206;
    }
    // XOR AH,0x80 (1000_01F5 / 0x101F5)
    AH ^= 0x80;
    // CMP AL,0x5 (1000_01F8 / 0x101F8)
    Alu.Sub8(AL, 0x5);
    // JBE 0x1000:0206 (1000_01FA / 0x101FA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0206_10206;
    }
    // XOR AH,0x80 (1000_01FC / 0x101FC)
    AH ^= 0x80;
    // CMP AL,0x9 (1000_01FF / 0x101FF)
    Alu.Sub8(AL, 0x9);
    // JBE 0x1000:0206 (1000_0201 / 0x10201)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0206_10206;
    }
    // XOR AH,0x80 (1000_0203 / 0x10203)
    // AH ^= 0x80;
    AH = Alu.Xor8(AH, 0x80);
    label_1000_0206_10206:
    // OR AL,AH (1000_0206 / 0x10206)
    // AL |= AH;
    AL = Alu.Or8(AL, AH);
    // MOV byte ptr [SI + 0x12],AL (1000_0208 / 0x10208)
    UInt8[DS, (ushort)(SI + 0x12)] = AL;
    // RET  (1000_020B / 0x1020B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_021C_01021C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_021C_1021C:
    // MOV byte ptr [0x289e],0x8c (1000_021C / 0x1021C)
    UInt8[DS, 0x289E] = 0x8C;
    // MOV byte ptr [0x28e7],0x1 (1000_0221 / 0x10221)
    UInt8[DS, 0x28E7] = 0x1;
    // JZ 0x1000:0292 (1000_0226 / 0x10226)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0231_010231, 0x10292 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:ad50 (1000_0228 / 0x10228)
    NearCall(cs1, 0x22B, spice86_generated_label_call_target_1000_AD50_01AD50);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_022B_01022B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_022B_01022B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_022B_1022B:
    // MOV AX,0x3e8 (1000_022B / 0x1022B)
    AX = 0x3E8;
    // MOV SI,0x1 (1000_022E / 0x1022E)
    SI = 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0231_010231, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0231_010231(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x292: goto label_1000_0292_10292;break; // Target of external jump from 0x10226, 0x1025C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_0231_10231:
    // PUSH SI (1000_0231 / 0x10231)
    Stack.Push(SI);
    // MOV BP,0x2c1 (1000_0232 / 0x10232)
    BP = 0x2C1;
    // CALL 0x1000:c102 (1000_0235 / 0x10235)
    NearCall(cs1, 0x238, spice86_generated_label_call_target_1000_C102_01C102);
    label_1000_0238_10238:
    // CALL 0x1000:ade0 (1000_0238 / 0x10238)
    NearCall(cs1, 0x23B, spice86_generated_label_call_target_1000_ADE0_01ADE0);
    label_1000_023B_1023B:
    // POP AX (1000_023B / 0x1023B)
    AX = Stack.Pop();
    // PUSH AX (1000_023C / 0x1023C)
    Stack.Push(AX);
    // CALL 0x1000:ab4f (1000_023D / 0x1023D)
    NearCall(cs1, 0x240, spice86_generated_label_call_target_1000_AB4F_01AB4F);
    label_1000_0240_10240:
    // POP SI (1000_0240 / 0x10240)
    SI = Stack.Pop();
    // CALL 0x1000:de54 (1000_0241 / 0x10241)
    NearCall(cs1, 0x244, spice86_generated_label_call_target_1000_DE54_01DE54);
    label_1000_0244_10244:
    // JZ 0x1000:0292 (1000_0244 / 0x10244)
    if(ZeroFlag) {
      goto label_1000_0292_10292;
    }
    // PUSH SI (1000_0246 / 0x10246)
    Stack.Push(SI);
    // MOV AX,0x320 (1000_0247 / 0x10247)
    AX = 0x320;
    // MOV AX,0xfa0 (1000_024A / 0x1024A)
    AX = 0xFA0;
    // CALL 0x1000:ddb0 (1000_024D / 0x1024D)
    NearCall(cs1, 0x250, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    label_1000_0250_10250:
    // PUSHF  (1000_0250 / 0x10250)
    Stack.Push(FlagRegister);
    // CALL 0x1000:0911 (1000_0251 / 0x10251)
    NearCall(cs1, 0x254, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_0254_10254:
    // CALL 0x1000:ac14 (1000_0254 / 0x10254)
    NearCall(cs1, 0x257, spice86_generated_label_call_target_1000_AC14_01AC14);
    label_1000_0257_10257:
    // CALL 0x1000:aded (1000_0257 / 0x10257)
    NearCall(cs1, 0x25A, spice86_generated_label_call_target_1000_ADED_01ADED);
    label_1000_025A_1025A:
    // POPF  (1000_025A / 0x1025A)
    FlagRegister = Stack.Pop();
    // POP SI (1000_025B / 0x1025B)
    SI = Stack.Pop();
    // JZ 0x1000:0292 (1000_025C / 0x1025C)
    if(ZeroFlag) {
      goto label_1000_0292_10292;
    }
    // INC SI (1000_025E / 0x1025E)
    SI++;
    // CMP SI,0x8 (1000_025F / 0x1025F)
    Alu.Sub16(SI, 0x8);
    // JBE 0x1000:0231 (1000_0262 / 0x10262)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0231_10231;
    }
    // MOV BP,0x301 (1000_0264 / 0x10264)
    BP = 0x301;
    // MOV AL,0x10 (1000_0267 / 0x10267)
    AL = 0x10;
    // CALL 0x1000:c108 (1000_0269 / 0x10269)
    NearCall(cs1, 0x26C, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_026C_1026C:
    // MOV AX,0xc8 (1000_026C / 0x1026C)
    AX = 0xC8;
    // CALL 0x1000:ddb0 (1000_026F / 0x1026F)
    NearCall(cs1, 0x272, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    label_1000_0272_10272:
    // MOV BL,0xc (1000_0272 / 0x10272)
    BL = 0xC;
    // CALL 0x1000:38f1 (1000_0274 / 0x10274)
    NearCall(cs1, 0x277, spice86_generated_label_call_target_1000_38F1_0138F1);
    label_1000_0277_10277:
    // MOV byte ptr [0x46df],0x1 (1000_0277 / 0x10277)
    UInt8[DS, 0x46DF] = 0x1;
    // MOV AX,0x4b0 (1000_027C / 0x1027C)
    AX = 0x4B0;
    // CALL 0x1000:ddb0 (1000_027F / 0x1027F)
    NearCall(cs1, 0x282, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    label_1000_0282_10282:
    // CALL 0x1000:3950 (1000_0282 / 0x10282)
    NearCall(cs1, 0x285, spice86_generated_label_call_target_1000_3950_013950);
    label_1000_0285_10285:
    // MOV byte ptr [0x46df],0x0 (1000_0285 / 0x10285)
    UInt8[DS, 0x46DF] = 0x0;
    // MOV BP,0xc0ad (1000_028A / 0x1028A)
    BP = 0xC0AD;
    // MOV AL,0x10 (1000_028D / 0x1028D)
    AL = 0x10;
    // CALL 0x1000:c108 (1000_028F / 0x1028F)
    NearCall(cs1, 0x292, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_0292_10292:
    // MOV ES,word ptr [0xdbd8] (1000_0292 / 0x10292)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x38d5] (1000_0296 / 0x10296)
    // Indirect call to [0x38d5], generating possible targets from emulator records
    uint targetAddress_1000_0296 = (uint)(UInt16[DS, 0x38D7] * 0x10 + UInt16[DS, 0x38D5] - cs1 * 0x10);
    switch(targetAddress_1000_0296) {
      case 0x235C8 : FarCall(cs1, 0x29A, spice86_generated_label_call_target_334B_0118_0335C8); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0296));
        break;
    }
    label_1000_029A_1029A:
    // CALL 0x1000:ac14 (1000_029A / 0x1029A)
    NearCall(cs1, 0x29D, spice86_generated_label_call_target_1000_AC14_01AC14);
    label_1000_029D_1029D:
    // MOV byte ptr [0x227d],0x0 (1000_029D / 0x1029D)
    UInt8[DS, 0x227D] = 0x0;
    // MOV byte ptr [0xc5],0x0 (1000_02A2 / 0x102A2)
    UInt8[DS, 0xC5] = 0x0;
    // CALL 0x1000:0911 (1000_02A7 / 0x102A7)
    NearCall(cs1, 0x2AA, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_02AA_102AA:
    // MOV byte ptr [0x28e7],0x0 (1000_02AA / 0x102AA)
    UInt8[DS, 0x28E7] = 0x0;
    // MOV byte ptr [0xdbe6],0x6 (1000_02AF / 0x102AF)
    UInt8[DS, 0xDBE6] = 0x6;
    // INC byte ptr [0x115] (1000_02B4 / 0x102B4)
    UInt8[DS, 0x115] = Alu.Inc8(UInt8[DS, 0x115]);
    // MOV DX,0x200a (1000_02B8 / 0x102B8)
    DX = 0x200A;
    // MOV BX,0x180 (1000_02BB / 0x102BB)
    BX = 0x180;
    // JMP 0x1000:08f0 (1000_02BE / 0x102BE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_08F0_0108F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02C1_0102C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02C1_102C1:
    // PUSH SI (1000_02C1 / 0x102C1)
    Stack.Push(SI);
    // CALL 0x1000:c0ad (1000_02C2 / 0x102C2)
    NearCall(cs1, 0x2C5, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_02C5_0102C5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_02C5_0102C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02C5_102C5:
    // ADD SI,SI (1000_02C5 / 0x102C5)
    // SI += SI;
    SI = Alu.Add16(SI, SI);
    // MOV BP,word ptr CS:[SI + 0x20a] (1000_02C7 / 0x102C7)
    BP = UInt16[cs1, (ushort)(SI + 0x20A)];
    // CALL BP (1000_02CC / 0x102CC)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_02CC = (uint)(BP);
    switch(targetAddress_1000_02CC) {
      case 0x2DE : NearCall(cs1, 0x2CE, spice86_generated_label_call_target_1000_02DE_0102DE); break;
      case 0x2E3 : NearCall(cs1, 0x2CE, spice86_generated_label_call_target_1000_02E3_0102E3); break;
      case 0x94A : NearCall(cs1, 0x2CE, spice86_generated_label_call_target_1000_094A_01094A); break;
      case 0x2F8 : NearCall(cs1, 0x2CE, spice86_generated_label_call_target_1000_02F8_0102F8); break;
      case 0x2FB : NearCall(cs1, 0x2CE, spice86_generated_label_call_target_1000_02FB_0102FB); break;
      case 0x2FE : NearCall(cs1, 0x2CE, spice86_generated_label_call_target_1000_02FE_0102FE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_02CC));
        break;
    }
    label_1000_02CE_102CE:
    // POP AX (1000_02CE / 0x102CE)
    AX = Stack.Pop();
    // ADD AX,0x117 (1000_02CF / 0x102CF)
    // AX += 0x117;
    AX = Alu.Add16(AX, 0x117);
    // CALL 0x1000:d068 (1000_02D2 / 0x102D2)
    NearCall(cs1, 0x2D5, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_02D5_0102D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_02D5_0102D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02D5_102D5:
    // CALL 0x1000:9901 (1000_02D5 / 0x102D5)
    NearCall(cs1, 0x2D8, spice86_generated_label_call_target_1000_9901_019901);
    label_1000_02D8_102D8:
    // CALL 0x1000:88af (1000_02D8 / 0x102D8)
    NearCall(cs1, 0x2DB, spice86_generated_label_call_target_1000_88AF_0188AF);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_02DB_0102DB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_02DB_0102DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02DB_102DB:
    // JMP 0x1000:9901 (1000_02DB / 0x102DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9901_019901, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02DE_0102DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02DE_102DE:
    // XOR CX,CX (1000_02DE / 0x102DE)
    CX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_02E0_0102E0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02E0_0102E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02E0_102E0:
    // JMP 0x1000:0a44 (1000_02E0 / 0x102E0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0A44_010A44, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02E3_0102E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02E3_102E3:
    // MOV CX,0x20 (1000_02E3 / 0x102E3)
    CX = 0x20;
    // CALL 0x1000:02e0 (1000_02E6 / 0x102E6)
    NearCall(cs1, 0x2E9, spice86_generated_label_call_target_1000_02E0_0102E0);
    label_1000_02E9_102E9:
    // CALL 0x1000:b8a7 (1000_02E9 / 0x102E9)
    NearCall(cs1, 0x2EC, spice86_generated_label_call_target_1000_B8A7_01B8A7);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_02EC_0102EC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_02EC_0102EC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02EC_102EC:
    // CALL 0x1000:b85a (1000_02EC / 0x102EC)
    NearCall(cs1, 0x2EF, spice86_generated_label_ret_target_1000_B85A_01B85A);
    label_1000_02EF_102EF:
    // MOV AX,0x2c (1000_02EF / 0x102EF)
    AX = 0x2C;
    // CALL 0x1000:c13e (1000_02F2 / 0x102F2)
    NearCall(cs1, 0x2F5, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_02F5_102F5:
    // JMP 0x1000:b8ea (1000_02F5 / 0x102F5)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B8C9_01B8C9, 0x1B8EA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02F8_0102F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02F8_102F8:
    // JMP 0x1000:07ee (1000_02F8 / 0x102F8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_07EE_0107EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02FB_0102FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02FB_102FB:
    // JMP 0x1000:09ad (1000_02FB / 0x102FB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_09AD_0109AD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_02FE_0102FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_02FE_102FE:
    // JMP 0x1000:076a (1000_02FE / 0x102FE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_076A_01076A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0301_010301(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0301_10301:
    // CALL 0x1000:c0ad (1000_0301 / 0x10301)
    NearCall(cs1, 0x304, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0304_010304, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0304_010304(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0304_10304:
    // MOV AL,0x1b (1000_0304 / 0x10304)
    AL = 0x1B;
    // JMP 0x1000:c2f2 (1000_0306 / 0x10306)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0309_010309(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0309_10309:
    // JZ 0x1000:0331 (1000_0309 / 0x10309)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0321_010321, 0x10331 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:de4e (1000_030B / 0x1030B)
    NearCall(cs1, 0x30E, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    label_1000_030E_1030E:
    // CALL 0x1000:c07c (1000_030E / 0x1030E)
    NearCall(cs1, 0x311, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0311_010311, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0311_010311(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0311_10311:
    // CALL 0x1000:c0ad (1000_0311 / 0x10311)
    NearCall(cs1, 0x314, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    label_1000_0314_10314:
    // MOV AX,0x18 (1000_0314 / 0x10314)
    AX = 0x18;
    // CALLF [0x3939] (1000_0317 / 0x10317)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_0317 = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_0317) {
      case 0x23613 : FarCall(cs1, 0x31B, spice86_generated_label_call_target_334B_0163_033613); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0317));
        break;
    }
    label_1000_031B_1031B:
    // MOV BP,0x9ef (1000_031B / 0x1031B)
    BP = 0x9EF;
    // CALL 0x1000:c102 (1000_031E / 0x1031E)
    NearCall(cs1, 0x321, spice86_generated_label_call_target_1000_C102_01C102);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0321_010321, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0321_010321(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0321_10321:
    // CALL 0x1000:ad50 (1000_0321 / 0x10321)
    NearCall(cs1, 0x324, spice86_generated_label_call_target_1000_AD50_01AD50);
    label_1000_0324_10324:
    // CALL 0x1000:0a16 (1000_0324 / 0x10324)
    NearCall(cs1, 0x327, spice86_generated_label_call_target_1000_0A16_010A16);
    label_1000_0327_10327:
    // CALL 0x1000:cc85 (1000_0327 / 0x10327)
    NearCall(cs1, 0x32A, spice86_generated_label_call_target_1000_CC85_01CC85);
    label_1000_032A_1032A:
    // JNZ 0x1000:0331 (1000_032A / 0x1032A)
    if(!ZeroFlag) {
      goto label_1000_0331_10331;
    }
    // CALL 0x1000:dd63 (1000_032C / 0x1032C)
    NearCall(cs1, 0x32F, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_032F_1032F:
    // JNC 0x1000:0324 (1000_032F / 0x1032F)
    if(!CarryFlag) {
      goto label_1000_0324_10324;
    }
    label_1000_0331_10331:
    // PUSHF  (1000_0331 / 0x10331)
    Stack.Push(FlagRegister);
    // CALL 0x1000:0579 (1000_0332 / 0x10332)
    NearCall(cs1, 0x335, spice86_generated_label_call_target_1000_0579_010579);
    label_1000_0335_10335:
    // POPF  (1000_0335 / 0x10335)
    FlagRegister = Stack.Pop();
    // RET  (1000_0336 / 0x10336)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0579_010579(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0579_10579:
    // XOR AX,AX (1000_0579 / 0x10579)
    AX = 0;
    // CALLF [0x3939] (1000_057B / 0x1057B)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_057B = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_057B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_057B));
        break;
    }
    // RET  (1000_057F / 0x1057F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0580_010580(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0580_10580:
    // CALL 0x1000:de54 (1000_0580 / 0x10580)
    NearCall(cs1, 0x583, spice86_generated_label_call_target_1000_DE54_01DE54);
    label_1000_0583_10583:
    // JZ 0x1000:05fd (1000_0583 / 0x10583)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0592_010592, 0x105FD - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALLF [0x3959] (1000_0585 / 0x10585)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_0585 = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_0585) {
      case 0x2362B : FarCall(cs1, 0x589, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0585));
        break;
    }
    label_1000_0589_10589:
    // CALL 0x1000:aeb7 (1000_0589 / 0x10589)
    NearCall(cs1, 0x58C, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_058C_1058C:
    // MOV SI,0x337 (1000_058C / 0x1058C)
    SI = 0x337;
    // CALL 0x1000:0945 (1000_058F / 0x1058F)
    NearCall(cs1, 0x592, spice86_generated_label_call_target_1000_0945_010945);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0592_010592, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0592_010592(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0592_10592:
    // MOV AX,0x18 (1000_0592 / 0x10592)
    AX = 0x18;
    // CALLF [0x3939] (1000_0595 / 0x10595)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_0595 = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_0595) {
      case 0x23613 : FarCall(cs1, 0x599, spice86_generated_label_call_target_334B_0163_033613); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0595));
        break;
    }
    label_1000_0599_10599:
    // CALL 0x1000:093f (1000_0599 / 0x10599)
    NearCall(cs1, 0x59C, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_059C_1059C:
    // MOV BX,AX (1000_059C / 0x1059C)
    BX = AX;
    // INC AX (1000_059E / 0x1059E)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:05a3 (1000_059F / 0x1059F)
    if(!ZeroFlag) {
      goto label_1000_05A3_105A3;
    }
    // JMP 0x1000:0580 (1000_05A1 / 0x105A1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0580_010580, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_05A3_105A3:
    // CALL 0x1000:de0c (1000_05A3 / 0x105A3)
    NearCall(cs1, 0x5A6, spice86_generated_label_call_target_1000_DE0C_01DE0C);
    label_1000_05A6_105A6:
    // JC 0x1000:05fd (1000_05A6 / 0x105A6)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:0911 (1000_05A8 / 0x105A8)
    NearCall(cs1, 0x5AB, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_05AB_105AB:
    // CALLF [0x3959] (1000_05AB / 0x105AB)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_05AB = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_05AB) {
      case 0x2362B : FarCall(cs1, 0x5AF, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_05AB));
        break;
    }
    label_1000_05AF_105AF:
    // CALL 0x1000:093f (1000_05AF / 0x105AF)
    NearCall(cs1, 0x5B2, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05B2_105B2:
    // MOV BP,AX (1000_05B2 / 0x105B2)
    BP = AX;
    // CALL 0x1000:c097 (1000_05B4 / 0x105B4)
    NearCall(cs1, 0x5B7, spice86_generated_label_call_target_1000_C097_01C097);
    label_1000_05B7_105B7:
    // AND byte ptr [0x47d1],0x7f (1000_05B7 / 0x105B7)
    // UInt8[DS, 0x47D1] &= 0x7F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x7F);
    // CALL 0x1000:39e6 (1000_05BC / 0x105BC)
    NearCall(cs1, 0x5BF, spice86_generated_label_call_target_1000_39E6_0139E6);
    label_1000_05BF_105BF:
    // CALL 0x1000:093f (1000_05BF / 0x105BF)
    NearCall(cs1, 0x5C2, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05C2_105C2:
    // MOV BX,AX (1000_05C2 / 0x105C2)
    BX = AX;
    // CALL 0x1000:de0c (1000_05C4 / 0x105C4)
    NearCall(cs1, 0x5C7, spice86_generated_label_call_target_1000_DE0C_01DE0C);
    label_1000_05C7_105C7:
    // JC 0x1000:05fd (1000_05C7 / 0x105C7)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:093f (1000_05C9 / 0x105C9)
    NearCall(cs1, 0x5CC, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05CC_105CC:
    // OR AX,AX (1000_05CC / 0x105CC)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:05dc (1000_05CE / 0x105CE)
    if(SignFlag) {
      goto label_1000_05DC_105DC;
    }
    // MOV BP,0xf66 (1000_05D0 / 0x105D0)
    BP = 0xF66;
    // CALL 0x1000:c108 (1000_05D3 / 0x105D3)
    NearCall(cs1, 0x5D6, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_05D6_105D6:
    // CALL 0x1000:c0f4 (1000_05D6 / 0x105D6)
    NearCall(cs1, 0x5D9, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    label_1000_05D9_105D9:
    // CALL 0x1000:3a7c (1000_05D9 / 0x105D9)
    NearCall(cs1, 0x5DC, spice86_generated_label_call_target_1000_3A7C_013A7C);
    label_1000_05DC_105DC:
    // CALL 0x1000:c07c (1000_05DC / 0x105DC)
    NearCall(cs1, 0x5DF, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_05DF_105DF:
    // OR byte ptr [0x47d1],0x80 (1000_05DF / 0x105DF)
    // UInt8[DS, 0x47D1] |= 0x80;
    UInt8[DS, 0x47D1] = Alu.Or8(UInt8[DS, 0x47D1], 0x80);
    // CALL 0x1000:dd63 (1000_05E4 / 0x105E4)
    NearCall(cs1, 0x5E7, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_05E7_105E7:
    // JC 0x1000:05fd (1000_05E7 / 0x105E7)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:093f (1000_05E9 / 0x105E9)
    NearCall(cs1, 0x5EC, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05EC_105EC:
    // CLC  (1000_05EC / 0x105EC)
    CarryFlag = false;
    // CALL AX (1000_05ED / 0x105ED)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_05ED = (uint)(AX);
    switch(targetAddress_1000_05ED) {
      case 0x625 : NearCall(cs1, 0x5EF, spice86_generated_label_call_target_1000_0625_010625); break;
      case 0xF66 : NearCall(cs1, 0x5EF, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x661 : NearCall(cs1, 0x5EF, spice86_generated_label_call_target_1000_0661_010661); break;
      case 0x684 : NearCall(cs1, 0x5EF, spice86_generated_label_call_target_1000_0684_010684); break;
      case 0xCF1B : NearCall(cs1, 0x5EF, spice86_generated_label_call_target_1000_CF1B_01CF1B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_05ED));
        break;
    }
    label_1000_05EF_105EF:
    // JC 0x1000:05fd (1000_05EF / 0x105EF)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:093f (1000_05F1 / 0x105F1)
    NearCall(cs1, 0x5F4, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05F4_105F4:
    // OR AX,AX (1000_05F4 / 0x105F4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:0592 (1000_05F6 / 0x105F6)
    if(ZeroFlag) {
      goto label_1000_0592_10592;
    }
    // CALL 0x1000:ddf0 (1000_05F8 / 0x105F8)
    NearCall(cs1, 0x5FB, spice86_generated_label_call_target_1000_DDF0_01DDF0);
    label_1000_05FB_105FB:
    // JNC 0x1000:0592 (1000_05FB / 0x105FB)
    if(!CarryFlag) {
      goto label_1000_0592_10592;
    }
    label_1000_05FD_105FD:
    // PUSHF  (1000_05FD / 0x105FD)
    Stack.Push(FlagRegister);
    // CALL 0x1000:9985 (1000_05FE / 0x105FE)
    NearCall(cs1, 0x601, spice86_generated_label_ret_target_1000_9985_019985);
    label_1000_0601_10601:
    // MOV ES,word ptr [0xdbd8] (1000_0601 / 0x10601)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x38d5] (1000_0605 / 0x10605)
    // Indirect call to [0x38d5], generating possible targets from emulator records
    uint targetAddress_1000_0605 = (uint)(UInt16[DS, 0x38D7] * 0x10 + UInt16[DS, 0x38D5] - cs1 * 0x10);
    switch(targetAddress_1000_0605) {
      case 0x235C8 : FarCall(cs1, 0x609, spice86_generated_label_call_target_334B_0118_0335C8); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0605));
        break;
    }
    label_1000_0609_10609:
    // POPF  (1000_0609 / 0x10609)
    FlagRegister = Stack.Pop();
    // PUSHF  (1000_060A / 0x1060A)
    Stack.Push(FlagRegister);
    // CALL 0x1000:0579 (1000_060B / 0x1060B)
    NearCall(cs1, 0x60E, spice86_generated_label_call_target_1000_0579_010579);
    label_1000_060E_1060E:
    // CALL 0x1000:ca01 (1000_060E / 0x1060E)
    NearCall(cs1, 0x611, spice86_generated_label_call_target_1000_CA01_01CA01);
    label_1000_0611_10611:
    // MOV word ptr [0x2],0x2 (1000_0611 / 0x10611)
    UInt16[DS, 0x2] = 0x2;
    // CALL 0x1000:0911 (1000_0617 / 0x10617)
    NearCall(cs1, 0x61A, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_061A_1061A:
    // POPF  (1000_061A / 0x1061A)
    FlagRegister = Stack.Pop();
    // RET  (1000_061B / 0x1061B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_061C_01061C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_061C_1061C:
    // CALL 0x1000:ad57 (1000_061C / 0x1061C)
    NearCall(cs1, 0x61F, spice86_generated_label_call_target_1000_AD57_01AD57);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_061F_01061F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_061F_01061F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_061F_1061F:
    // MOV AX,0x15 (1000_061F / 0x1061F)
    AX = 0x15;
    // JMP 0x1000:ca1b (1000_0622 / 0x10622)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0625_010625(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0625_10625:
    // CALL 0x1000:c07c (1000_0625 / 0x10625)
    NearCall(cs1, 0x628, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0628_010628, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0628_010628(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0628_10628:
    // CALL 0x1000:dd63 (1000_0628 / 0x10628)
    NearCall(cs1, 0x62B, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_062B_1062B:
    // JC 0x1000:064c (1000_062B / 0x1062B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_064C / 0x1064C)
      return NearRet();
    }
    // CALL 0x1000:c9f4 (1000_062D / 0x1062D)
    NearCall(cs1, 0x630, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    label_1000_0630_10630:
    // JZ 0x1000:0628 (1000_0630 / 0x10630)
    if(ZeroFlag) {
      goto label_1000_0628_10628;
    }
    // CALL 0x1000:c4cd (1000_0632 / 0x10632)
    NearCall(cs1, 0x635, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    label_1000_0635_10635:
    // CMP word ptr [0xdbce],0x8 (1000_0635 / 0x10635)
    Alu.Sub16(UInt16[DS, 0xDBCE], 0x8);
    // JC 0x1000:0646 (1000_063A / 0x1063A)
    if(CarryFlag) {
      goto label_1000_0646_10646;
    }
    // CMP byte ptr [0xdbcb],0x0 (1000_063C / 0x1063C)
    Alu.Sub8(UInt8[DS, 0xDBCB], 0x0);
    // JZ 0x1000:0646 (1000_0641 / 0x10641)
    if(ZeroFlag) {
      goto label_1000_0646_10646;
    }
    // CALL 0x1000:aeb7 (1000_0643 / 0x10643)
    NearCall(cs1, 0x646, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_0646_10646:
    // CALL 0x1000:cc85 (1000_0646 / 0x10646)
    NearCall(cs1, 0x649, spice86_generated_label_call_target_1000_CC85_01CC85);
    label_1000_0649_10649:
    // JZ 0x1000:0628 (1000_0649 / 0x10649)
    if(ZeroFlag) {
      goto label_1000_0628_10628;
    }
    // CLC  (1000_064B / 0x1064B)
    CarryFlag = false;
    label_1000_064C_1064C:
    // RET  (1000_064C / 0x1064C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_064D_01064D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_064D_1064D:
    // MOV AL,0xa (1000_064D / 0x1064D)
    AL = 0xA;
    // CALL 0x1000:ad95 (1000_064F / 0x1064F)
    NearCall(cs1, 0x652, spice86_generated_label_call_target_1000_AD95_01AD95);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0652_010652, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0652_010652(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0652_10652:
    // MOV AX,0x16 (1000_0652 / 0x10652)
    AX = 0x16;
    // JMP 0x1000:ca1b (1000_0655 / 0x10655)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0658_010658(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0658_10658:
    // CALL 0x1000:c0ad (1000_0658 / 0x10658)
    NearCall(cs1, 0x65B, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_065B_01065B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_065B_01065B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_065B_1065B:
    // MOV AX,0x17 (1000_065B / 0x1065B)
    AX = 0x17;
    // JMP 0x1000:ca1b (1000_065E / 0x1065E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0661_010661(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0661_10661:
    // CALL 0x1000:c07c (1000_0661 / 0x10661)
    NearCall(cs1, 0x664, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0664_010664, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0664_010664(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0664_10664:
    // CALL 0x1000:dd63 (1000_0664 / 0x10664)
    NearCall(cs1, 0x667, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_0667_10667:
    // JC 0x1000:064c (1000_0667 / 0x10667)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_064C / 0x1064C)
      return NearRet();
    }
    // CALL 0x1000:c9f4 (1000_0669 / 0x10669)
    NearCall(cs1, 0x66C, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    label_1000_066C_1066C:
    // JZ 0x1000:0664 (1000_066C / 0x1066C)
    if(ZeroFlag) {
      goto label_1000_0664_10664;
    }
    // CALL 0x1000:c4cd (1000_066E / 0x1066E)
    NearCall(cs1, 0x671, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    label_1000_0671_10671:
    // CALL 0x1000:cc85 (1000_0671 / 0x10671)
    NearCall(cs1, 0x674, spice86_generated_label_call_target_1000_CC85_01CC85);
    label_1000_0674_10674:
    // JZ 0x1000:0664 (1000_0674 / 0x10674)
    if(ZeroFlag) {
      goto label_1000_0664_10664;
    }
    // CLC  (1000_0676 / 0x10676)
    CarryFlag = false;
    // RET  (1000_0677 / 0x10677)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0678_010678(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0678_10678:
    // CALL 0x1000:0579 (1000_0678 / 0x10678)
    NearCall(cs1, 0x67B, spice86_generated_label_call_target_1000_0579_010579);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_067B_01067B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_067B_01067B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_067B_1067B:
    // CALL 0x1000:c0ad (1000_067B / 0x1067B)
    NearCall(cs1, 0x67E, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_067E_01067E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_067E_01067E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_067E_1067E:
    // MOV AX,0x18 (1000_067E / 0x1067E)
    AX = 0x18;
    // JMP 0x1000:ca1b (1000_0681 / 0x10681)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0684_010684(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0684_10684:
    // JMP 0x1000:06bd (1000_0684 / 0x10684)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_06BD_0106BD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action load_INTRO_HNM_ida_1000_069E_1069E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_069E_1069E:
    // CALL 0x1000:c07c (1000_069E / 0x1069E)
    NearCall(cs1, 0x6A1, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:0579 (1000_06A1 / 0x106A1)
    NearCall(cs1, 0x6A4, spice86_generated_label_call_target_1000_0579_010579);
    // MOV AX,0xf (1000_06A4 / 0x106A4)
    AX = 0xF;
    // JMP 0x1000:ca1b (1000_06A7 / 0x106A7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action play_hnm_86_frames_ida_1000_06AA_106AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_06AA_106AA:
    // CALL 0x1000:0579 (1000_06AA / 0x106AA)
    NearCall(cs1, 0x6AD, spice86_generated_label_call_target_1000_0579_010579);
    // CALL 0x1000:c08e (1000_06AD / 0x106AD)
    NearCall(cs1, 0x6B0, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_06B0_106B0:
    // CALL 0x1000:c9e8 (1000_06B0 / 0x106B0)
    NearCall(cs1, 0x6B3, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    // JC 0x1000:06bc (1000_06B3 / 0x106B3)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_06BC / 0x106BC)
      return NearRet();
    }
    // CMP word ptr [0xdbe8],0x56 (1000_06B5 / 0x106B5)
    Alu.Sub16(UInt16[DS, 0xDBE8], 0x56);
    // JNZ 0x1000:06b0 (1000_06BA / 0x106BA)
    if(!ZeroFlag) {
      goto label_1000_06B0_106B0;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_06BC_0106BC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_06BC_0106BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_06BC_106BC:
    // RET  (1000_06BC / 0x106BC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_06BD_0106BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_06BD_106BD:
    // CALL 0x1000:0579 (1000_06BD / 0x106BD)
    NearCall(cs1, 0x6C0, spice86_generated_label_call_target_1000_0579_010579);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_06C0_0106C0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_06C0_0106C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_06C0_106C0:
    // CALL 0x1000:c08e (1000_06C0 / 0x106C0)
    NearCall(cs1, 0x6C3, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_06C3_0106C3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_06C3_0106C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_06C3_106C3:
    // CALL 0x1000:c9e8 (1000_06C3 / 0x106C3)
    NearCall(cs1, 0x6C6, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    label_1000_06C6_106C6:
    // JC 0x1000:06bc (1000_06C6 / 0x106C6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_06BC / 0x106BC)
      return NearRet();
    }
    // CALL 0x1000:cc85 (1000_06C8 / 0x106C8)
    NearCall(cs1, 0x6CB, spice86_generated_label_call_target_1000_CC85_01CC85);
    label_1000_06CB_106CB:
    // JZ 0x1000:06c3 (1000_06CB / 0x106CB)
    if(ZeroFlag) {
      goto label_1000_06C3_106C3;
    }
    // RET  (1000_06CD / 0x106CD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0739_010739(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0739_10739:
    // JMP 0x1000:c2f2 (1000_0739 / 0x10739)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_076A_01076A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_076A_1076A:
    // CALL 0x1000:c0ad (1000_076A / 0x1076A)
    NearCall(cs1, 0x76D, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_076D_01076D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_076D_01076D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_076D_1076D:
    // MOV AL,0x61 (1000_076D / 0x1076D)
    AL = 0x61;
    // JMP 0x1000:0739 (1000_076F / 0x1076F)
    // JMP target is JMP, inlining.
    // JMP 0x1000:c2f2 (1000_0739 / 0x10739)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_07EE_0107EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_07EE_107EE:
    // MOV AX,0x30 (1000_07EE / 0x107EE)
    AX = 0x30;
    // CALL 0x1000:c13e (1000_07F1 / 0x107F1)
    NearCall(cs1, 0x7F4, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_07F4_0107F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_07F4_0107F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_07F4_107F4:
    // MOV SI,0x1526 (1000_07F4 / 0x107F4)
    SI = 0x1526;
    // CALL 0x1000:c21b (1000_07F7 / 0x107F7)
    NearCall(cs1, 0x7FA, spice86_generated_label_call_target_1000_C21B_01C21B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_07FA_0107FA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_07FA_0107FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_07FA_107FA:
    // JMP 0x1000:0960 (1000_07FA / 0x107FA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0960_010960, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_08F0_0108F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_08F0_108F0:
    // XOR AL,AL (1000_08F0 / 0x108F0)
    AL = 0;
    // MOV [0x47a4],AL (1000_08F2 / 0x108F2)
    UInt8[DS, 0x47A4] = AL;
    // MOV [0x46df],AL (1000_08F5 / 0x108F5)
    UInt8[DS, 0x46DF] = AL;
    // MOV word ptr [0x4],DX (1000_08F8 / 0x108F8)
    UInt16[DS, 0x4] = DX;
    // MOV word ptr [0x6],BX (1000_08FC / 0x108FC)
    UInt16[DS, 0x6] = BX;
    // MOV byte ptr [0x8],DH (1000_0900 / 0x10900)
    UInt8[DS, 0x8] = DH;
    // MOV AL,0x1c (1000_0904 / 0x10904)
    AL = 0x1C;
    // MUL BH (1000_0906 / 0x10906)
    Cpu.Mul8(BH);
    // ADD AX,0xe4 (1000_0908 / 0x10908)
    // AX += 0xE4;
    AX = Alu.Add16(AX, 0xE4);
    // MOV [0x114e],AX (1000_090B / 0x1090B)
    UInt16[DS, 0x114E] = AX;
    // JMP 0x1000:2d74 (1000_090E / 0x1090E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2D74_012D74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0911_010911(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0911_10911:
    // CALL 0x1000:39e6 (1000_0911 / 0x10911)
    NearCall(cs1, 0x914, spice86_generated_label_call_target_1000_39E6_0139E6);
    label_1000_0914_10914:
    // CALL 0x1000:b930 (1000_0914 / 0x10914)
    NearCall(cs1, 0x917, spice86_generated_label_call_target_1000_B930_01B930);
    label_1000_0917_10917:
    // CALL 0x1000:0b21 (1000_0917 / 0x10917)
    NearCall(cs1, 0x91A, spice86_generated_label_call_target_1000_0B21_010B21);
    label_1000_091A_1091A:
    // CALL 0x1000:9985 (1000_091A / 0x1091A)
    NearCall(cs1, 0x91D, spice86_generated_label_ret_target_1000_9985_019985);
    label_1000_091D_1091D:
    // CALL 0x1000:98e6 (1000_091D / 0x1091D)
    NearCall(cs1, 0x920, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0920_010920, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0920_010920(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0920_10920:
    // MOV byte ptr [0x22e3],0x1 (1000_0920 / 0x10920)
    UInt8[DS, 0x22E3] = 0x1;
    // MOV byte ptr [0x46d7],0x0 (1000_0925 / 0x10925)
    UInt8[DS, 0x46D7] = 0x0;
    // MOV SI,0x70c (1000_092A / 0x1092A)
    SI = 0x70C;
    // CALL 0x1000:da5f (1000_092D / 0x1092D)
    NearCall(cs1, 0x930, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_0930_10930:
    // MOV SI,0x3916 (1000_0930 / 0x10930)
    SI = 0x3916;
    // CALL 0x1000:da5f (1000_0933 / 0x10933)
    NearCall(cs1, 0x936, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_0936_10936:
    // CALL 0x1000:0a3e (1000_0936 / 0x10936)
    NearCall(cs1, 0x939, spice86_generated_label_call_target_1000_0A3E_010A3E);
    label_1000_0939_10939:
    // MOV SI,0x826 (1000_0939 / 0x10939)
    SI = 0x826;
    // JMP 0x1000:da5f (1000_093C / 0x1093C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_093F_01093F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_093F_1093F:
    // MOV SI,word ptr [0x4854] (1000_093F / 0x1093F)
    SI = UInt16[DS, 0x4854];
    // LODSW CS:SI (1000_0943 / 0x10943)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0945_010945, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0945_010945(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0945_10945:
    // MOV word ptr [0x4854],SI (1000_0945 / 0x10945)
    UInt16[DS, 0x4854] = SI;
    // RET  (1000_0949 / 0x10949)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_094A_01094A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_094A_1094A:
    // CALL 0x1000:38b4 (1000_094A / 0x1094A)
    NearCall(cs1, 0x94D, spice86_generated_label_call_target_1000_38B4_0138B4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_094D_01094D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_094D_01094D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_094D_1094D:
    // MOV AX,0x2d (1000_094D / 0x1094D)
    AX = 0x2D;
    // CALL 0x1000:c13e (1000_0950 / 0x10950)
    NearCall(cs1, 0x953, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_0953_10953:
    // XOR AX,AX (1000_0953 / 0x10953)
    AX = 0;
    // XOR DX,DX (1000_0955 / 0x10955)
    DX = 0;
    // MOV BX,0x3c (1000_0957 / 0x10957)
    BX = 0x3C;
    // JMP 0x1000:c22f (1000_095A / 0x1095A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0960_010960(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0960_10960:
    // CALL 0x1000:c412 (1000_0960 / 0x10960)
    NearCall(cs1, 0x963, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_0963_10963:
    // XOR DX,DX (1000_0963 / 0x10963)
    DX = 0;
    label_1000_0965_10965:
    // MOV AL,0x2d (1000_0965 / 0x10965)
    AL = 0x2D;
    // CALL 0x1000:09c7 (1000_0967 / 0x10967)
    NearCall(cs1, 0x96A, spice86_generated_label_call_target_1000_09C7_0109C7);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_096A_01096A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_096A_01096A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_096A_1096A:
    // MOV byte ptr [0x478c],0x1 (1000_096A / 0x1096A)
    UInt8[DS, 0x478C] = 0x1;
    // JMP 0x1000:978e (1000_096F / 0x1096F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_978E_01978E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_09AD_0109AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09AD_109AD:
    // MOV AX,0x30 (1000_09AD / 0x109AD)
    AX = 0x30;
    // CALL 0x1000:c13e (1000_09B0 / 0x109B0)
    NearCall(cs1, 0x9B3, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_09B3_0109B3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_09B3_0109B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09B3_109B3:
    // MOV SI,0x153a (1000_09B3 / 0x109B3)
    SI = 0x153A;
    // CALL 0x1000:c21b (1000_09B6 / 0x109B6)
    NearCall(cs1, 0x9B9, spice86_generated_label_call_target_1000_C21B_01C21B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_09B9_0109B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_09B9_0109B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09B9_109B9:
    // CALL 0x1000:c412 (1000_09B9 / 0x109B9)
    NearCall(cs1, 0x9BC, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_09BC_109BC:
    // MOV AL,0x9 (1000_09BC / 0x109BC)
    AL = 0x9;
    // MOV DX,0x52 (1000_09BE / 0x109BE)
    DX = 0x52;
    // CALL 0x1000:09c7 (1000_09C1 / 0x109C1)
    NearCall(cs1, 0x9C4, spice86_generated_label_call_target_1000_09C7_0109C7);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_09C4_0109C4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_09C4_0109C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09C4_109C4:
    // JMP 0x1000:978e (1000_09C4 / 0x109C4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_978E_01978E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_09C7_0109C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09C7_109C7:
    // PUSH DX (1000_09C7 / 0x109C7)
    Stack.Push(DX);
    // XOR AH,AH (1000_09C8 / 0x109C8)
    AH = 0;
    // MOV [0x47c4],AX (1000_09CA / 0x109CA)
    UInt16[DS, 0x47C4] = AX;
    // CALL 0x1000:91a0 (1000_09CD / 0x109CD)
    NearCall(cs1, 0x9D0, spice86_generated_label_call_target_1000_91A0_0191A0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_09D0_0109D0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_09D0_0109D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09D0_109D0:
    // MOV byte ptr [0x478c],0x1e (1000_09D0 / 0x109D0)
    UInt8[DS, 0x478C] = 0x1E;
    // MOV DI,0x1bf0 (1000_09D5 / 0x109D5)
    DI = 0x1BF0;
    // POP AX (1000_09D8 / 0x109D8)
    AX = Stack.Pop();
    // CMP word ptr [DI],AX (1000_09D9 / 0x109D9)
    Alu.Sub16(UInt16[DS, DI], AX);
    // JNC 0x1000:09ee (1000_09DB / 0x109DB)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_09EE / 0x109EE)
      return NearRet();
    }
    // ADD word ptr [DI],AX (1000_09DD / 0x109DD)
    UInt16[DS, DI] += AX;
    // ADD word ptr [DI + 0x4],AX (1000_09DF / 0x109DF)
    UInt16[DS, (ushort)(DI + 0x4)] += AX;
    // CMP word ptr [DI + 0x4],0x140 (1000_09E2 / 0x109E2)
    Alu.Sub16(UInt16[DS, (ushort)(DI + 0x4)], 0x140);
    // JLE 0x1000:09ee (1000_09E7 / 0x109E7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_09EE / 0x109EE)
      return NearRet();
    }
    // MOV word ptr [DI + 0x4],0x140 (1000_09E9 / 0x109E9)
    UInt16[DS, (ushort)(DI + 0x4)] = 0x140;
    label_1000_09EE_109EE:
    // RET  (1000_09EE / 0x109EE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_09EF_0109EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09EF_109EF:
    // MOV AX,0x14 (1000_09EF / 0x109EF)
    AX = 0x14;
    // JMP 0x1000:ca1b (1000_09F2 / 0x109F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_09F5_0109F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_09F5_109F5:
    // CALL 0x1000:09ef (1000_09F5 / 0x109F5)
    NearCall(cs1, 0x9F8, spice86_generated_label_call_target_1000_09EF_0109EF);
    // CALL 0x1000:c0f4 (1000_09F8 / 0x109F8)
    NearCall(cs1, 0x9FB, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // CMP byte ptr [0x227d],0x0 (1000_09FB / 0x109FB)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:0a09 (1000_0A00 / 0x10A00)
    if(!ZeroFlag) {
      goto label_1000_0A09_10A09;
    }
    // TEST byte ptr [0x3810],0x1 (1000_0A02 / 0x10A02)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    // JNZ 0x1000:0a0c (1000_0A07 / 0x10A07)
    if(!ZeroFlag) {
      goto label_1000_0A0C_10A0C;
    }
    label_1000_0A09_10A09:
    // CALL 0x1000:ad50 (1000_0A09 / 0x10A09)
    NearCall(cs1, 0xA0C, spice86_generated_label_call_target_1000_AD50_01AD50);
    label_1000_0A0C_10A0C:
    // MOV SI,0xa16 (1000_0A0C / 0x10A0C)
    SI = 0xA16;
    // XOR BP,BP (1000_0A0F / 0x10A0F)
    BP = 0;
    // CALL 0x1000:da25 (1000_0A11 / 0x10A11)
    NearCall(cs1, 0xA14, spice86_generated_label_call_target_1000_DA25_01DA25);
    // CLC  (1000_0A14 / 0x10A14)
    CarryFlag = false;
    // RET  (1000_0A15 / 0x10A15)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0A16_010A16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A16_10A16:
    // PUSH word ptr [0xdbda] (1000_0A16 / 0x10A16)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:0a23 (1000_0A1A / 0x10A1A)
    NearCall(cs1, 0xA1D, spice86_generated_label_call_target_1000_0A23_010A23);
    label_1000_0A1D_10A1D:
    // POP word ptr [0xdbda] (1000_0A1D / 0x10A1D)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    label_1000_0A21_10A21:
    // CLC  (1000_0A21 / 0x10A21)
    CarryFlag = false;
    // RET  (1000_0A22 / 0x10A22)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0A23_010A23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A23_10A23:
    // CMP byte ptr [0x227d],0x0 (1000_0A23 / 0x10A23)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JZ 0x1000:0a30 (1000_0A28 / 0x10A28)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_0A30_010A30, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c08e (1000_0A2A / 0x10A2A)
    NearCall(cs1, 0xA2D, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0A2D_010A2D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0A2D_010A2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A2D_10A2D:
    // JMP 0x1000:ca60 (1000_0A2D / 0x10A2D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA60_01CA60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_0A30_010A30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A30_10A30:
    // CALL 0x1000:c07c (1000_0A30 / 0x10A30)
    NearCall(cs1, 0xA33, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:c9f4 (1000_0A33 / 0x10A33)
    NearCall(cs1, 0xA36, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    // JZ 0x1000:0a21 (1000_0A36 / 0x10A36)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0A16_010A16, 0x10A21 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c4dd (1000_0A38 / 0x10A38)
    NearCall(cs1, 0xA3B, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    // JMP 0x1000:dbec (1000_0A3B / 0x10A3B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0A3E_010A3E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A3E_10A3E:
    // MOV SI,0xa16 (1000_0A3E / 0x10A3E)
    SI = 0xA16;
    // JMP 0x1000:da5f (1000_0A41 / 0x10A41)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0A44_010A44(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A44_10A44:
    // MOV AX,0x2c (1000_0A44 / 0x10A44)
    AX = 0x2C;
    // CALL 0x1000:c13e (1000_0A47 / 0x10A47)
    NearCall(cs1, 0xA4A, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0A4A_010A4A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0A4A_010A4A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A4A_10A4A:
    // CALL 0x1000:5ba8 (1000_0A4A / 0x10A4A)
    NearCall(cs1, 0xA4D, spice86_generated_label_call_target_1000_5BA8_015BA8);
    label_1000_0A4D_10A4D:
    // CALL 0x1000:c07c (1000_0A4D / 0x10A4D)
    NearCall(cs1, 0xA50, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0A50_010A50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0A50_010A50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A50_10A50:
    // PUSH CX (1000_0A50 / 0x10A50)
    Stack.Push(CX);
    // CALL 0x1000:c432 (1000_0A51 / 0x10A51)
    NearCall(cs1, 0xA54, spice86_generated_label_call_target_1000_C432_01C432);
    label_1000_0A54_10A54:
    // POP AX (1000_0A54 / 0x10A54)
    AX = Stack.Pop();
    // PUSH AX (1000_0A55 / 0x10A55)
    Stack.Push(AX);
    // MUL AL (1000_0A56 / 0x10A56)
    Cpu.Mul8(AL);
    // SHR AX,1 (1000_0A58 / 0x10A58)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV DX,AX (1000_0A5A / 0x10A5A)
    DX = AX;
    // NEG DX (1000_0A5C / 0x10A5C)
    DX = Alu.Sub16(0, DX);
    // PUSH DX (1000_0A5E / 0x10A5E)
    Stack.Push(DX);
    // XOR BX,BX (1000_0A5F / 0x10A5F)
    BX = 0;
    // XOR AX,AX (1000_0A61 / 0x10A61)
    AX = 0;
    // CALL 0x1000:c305 (1000_0A63 / 0x10A63)
    NearCall(cs1, 0xA66, spice86_generated_label_call_target_1000_C305_01C305);
    label_1000_0A66_10A66:
    // MOV AX,0x1 (1000_0A66 / 0x10A66)
    AX = 0x1;
    // ADD DX,0x130 (1000_0A69 / 0x10A69)
    // DX += 0x130;
    DX = Alu.Add16(DX, 0x130);
    // CALL 0x1000:c305 (1000_0A6D / 0x10A6D)
    NearCall(cs1, 0xA70, spice86_generated_label_call_target_1000_C305_01C305);
    label_1000_0A70_10A70:
    // MOV AX,0x2 (1000_0A70 / 0x10A70)
    AX = 0x2;
    // ADD DX,0x130 (1000_0A73 / 0x10A73)
    // DX += 0x130;
    DX = Alu.Add16(DX, 0x130);
    // CALL 0x1000:c30d (1000_0A77 / 0x10A77)
    NearCall(cs1, 0xA7A, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_0A7A_10A7A:
    // POP DX (1000_0A7A / 0x10A7A)
    DX = Stack.Pop();
    // PUSH DX (1000_0A7B / 0x10A7B)
    Stack.Push(DX);
    // SHL DX,1 (1000_0A7C / 0x10A7C)
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    // PUSH DX (1000_0A7E / 0x10A7E)
    Stack.Push(DX);
    // SHL DX,1 (1000_0A7F / 0x10A7F)
    DX <<= 0x1;
    // ADD DX,0x45 (1000_0A81 / 0x10A81)
    // DX += 0x45;
    DX = Alu.Add16(DX, 0x45);
    // MOV AX,0x24 (1000_0A84 / 0x10A84)
    AX = 0x24;
    // MOV BX,0x4e (1000_0A87 / 0x10A87)
    BX = 0x4E;
    // CALL 0x1000:c343 (1000_0A8A / 0x10A8A)
    NearCall(cs1, 0xA8D, spice86_generated_label_call_target_1000_C343_01C343);
    label_1000_0A8D_10A8D:
    // POP DX (1000_0A8D / 0x10A8D)
    DX = Stack.Pop();
    // POP CX (1000_0A8E / 0x10A8E)
    CX = Stack.Pop();
    // POP AX (1000_0A8F / 0x10A8F)
    AX = Stack.Pop();
    // PUSH AX (1000_0A90 / 0x10A90)
    Stack.Push(AX);
    // PUSH CX (1000_0A91 / 0x10A91)
    Stack.Push(CX);
    // ADD DX,0x3e2 (1000_0A92 / 0x10A92)
    DX += 0x3E2;
    // CMP AX,0x14 (1000_0A96 / 0x10A96)
    Alu.Sub16(AX, 0x14);
    // JA 0x1000:0aa5 (1000_0A99 / 0x10A99)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_0AA5_10AA5;
    }
    // MOV DX,AX (1000_0A9B / 0x10A9B)
    DX = AX;
    // SHL DX,1 (1000_0A9D / 0x10A9D)
    DX <<= 0x1;
    // SHL DX,1 (1000_0A9F / 0x10A9F)
    DX <<= 0x1;
    // ADD DX,0xf2 (1000_0AA1 / 0x10AA1)
    DX += 0xF2;
    label_1000_0AA5_10AA5:
    // SHR AX,1 (1000_0AA5 / 0x10AA5)
    AX >>= 0x1;
    // SHR AX,1 (1000_0AA7 / 0x10AA7)
    AX >>= 0x1;
    // ADD AX,0x25 (1000_0AA9 / 0x10AA9)
    // AX += 0x25;
    AX = Alu.Add16(AX, 0x25);
    // MOV BX,0x67 (1000_0AAC / 0x10AAC)
    BX = 0x67;
    // CALL 0x1000:c343 (1000_0AAF / 0x10AAF)
    NearCall(cs1, 0xAB2, spice86_generated_label_call_target_1000_C343_01C343);
    label_1000_0AB2_10AB2:
    // POP DX (1000_0AB2 / 0x10AB2)
    DX = Stack.Pop();
    // POP AX (1000_0AB3 / 0x10AB3)
    AX = Stack.Pop();
    // NEG DX (1000_0AB4 / 0x10AB4)
    DX = Alu.Sub16(0, DX);
    // SHR DX,1 (1000_0AB6 / 0x10AB6)
    DX >>= 0x1;
    // SHR DX,1 (1000_0AB8 / 0x10AB8)
    DX >>= 0x1;
    // SHR DX,1 (1000_0ABA / 0x10ABA)
    DX >>= 0x1;
    // SHR DX,1 (1000_0ABC / 0x10ABC)
    DX >>= 0x1;
    // ADD DX,0x80 (1000_0ABE / 0x10ABE)
    DX += 0x80;
    // ADD AL,0x3 (1000_0AC2 / 0x10AC2)
    // AL += 0x3;
    AL = Alu.Add8(AL, 0x3);
    // MOV BX,0x4f (1000_0AC4 / 0x10AC4)
    BX = 0x4F;
    // CALL 0x1000:c343 (1000_0AC7 / 0x10AC7)
    NearCall(cs1, 0xACA, spice86_generated_label_call_target_1000_C343_01C343);
    label_1000_0ACA_10ACA:
    // JMP 0x1000:c4dd (1000_0ACA / 0x10ACA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_0ACD_010ACD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0ACD_10ACD:
    // MOV word ptr [0x2786],0xc827 (1000_0ACD / 0x10ACD)
    UInt16[DS, 0x2786] = 0xC827;
    // MOV byte ptr CS:[0xc13c],0x2b (1000_0AD3 / 0x10AD3)
    UInt8[cs1, 0xC13C] = 0x2B;
    // CALL 0x1000:c13b (1000_0AD9 / 0x10AD9)
    NearCall(cs1, 0xADC, spice86_generated_label_call_target_1000_C13B_01C13B);
    // CALL 0x1000:c07c (1000_0ADC / 0x10ADC)
    NearCall(cs1, 0xADF, spice86_generated_label_call_target_1000_C07C_01C07C);
    // MOV SI,0x1582 (1000_0ADF / 0x10ADF)
    SI = 0x1582;
    // MOV ES,word ptr [0xdbda] (1000_0AE2 / 0x10AE2)
    ES = UInt16[DS, 0xDBDA];
    // MOV AX,0x2 (1000_0AE6 / 0x10AE6)
    AX = 0x2;
    // CALL 0x1000:c370 (1000_0AE9 / 0x10AE9)
    NearCall(cs1, 0xAEC, spice86_generated_label_call_target_1000_C370_01C370);
    // MOV SI,0x158a (1000_0AEC / 0x10AEC)
    SI = 0x158A;
    // MOV AX,0x3 (1000_0AEF / 0x10AEF)
    AX = 0x3;
    // CALL 0x1000:c370 (1000_0AF2 / 0x10AF2)
    NearCall(cs1, 0xAF5, spice86_generated_label_call_target_1000_C370_01C370);
    // MOV SI,0x11dd (1000_0AF5 / 0x10AF5)
    SI = 0x11DD;
    // CALL 0x1000:c21b (1000_0AF8 / 0x10AF8)
    NearCall(cs1, 0xAFB, spice86_generated_label_call_target_1000_C21B_01C21B);
    // CALL 0x1000:5ba0 (1000_0AFB / 0x10AFB)
    NearCall(cs1, 0xAFE, spice86_generated_label_call_target_1000_5BA0_015BA0);
    // MOV DI,0x4856 (1000_0AFE / 0x10AFE)
    DI = 0x4856;
    // XOR AX,AX (1000_0B01 / 0x10B01)
    AX = 0;
    // PUSH DS (1000_0B03 / 0x10B03)
    Stack.Push(DS);
    // POP ES (1000_0B04 / 0x10B04)
    ES = Stack.Pop();
    // MOV CX,0x8 (1000_0B05 / 0x10B05)
    CX = 0x8;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_0B08 / 0x10B08)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV SI,0xb45 (1000_0B0A / 0x10B0A)
    SI = 0xB45;
    // CALL 0x1000:da5f (1000_0B0D / 0x10B0D)
    NearCall(cs1, 0xB10, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // MOV SI,0xb45 (1000_0B10 / 0x10B10)
    SI = 0xB45;
    // MOV BP,0x3 (1000_0B13 / 0x10B13)
    BP = 0x3;
    // CALL 0x1000:da25 (1000_0B16 / 0x10B16)
    NearCall(cs1, 0xB19, spice86_generated_label_call_target_1000_DA25_01DA25);
    // CALL 0x1000:c412 (1000_0B19 / 0x10B19)
    NearCall(cs1, 0xB1C, spice86_generated_label_call_target_1000_C412_01C412);
    // MOV AL,0x3 (1000_0B1C / 0x10B1C)
    AL = 0x3;
    // JMP 0x1000:ab15 (1000_0B1E / 0x10B1E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AB15_01AB15, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0B21_010B21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0B21_10B21:
    // CALL 0x1000:ac30 (1000_0B21 / 0x10B21)
    NearCall(cs1, 0xB24, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_0B24_10B24:
    // MOV byte ptr CS:[0xc13c],0x25 (1000_0B24 / 0x10B24)
    UInt8[cs1, 0xC13C] = 0x25;
    // MOV SI,0xb45 (1000_0B2A / 0x10B2A)
    SI = 0xB45;
    // CALL 0x1000:da5f (1000_0B2D / 0x10B2D)
    NearCall(cs1, 0xB30, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0B30_010B30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0B30_010B30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0B30_10B30:
    // CMP byte ptr [0x227d],0x0 (1000_0B30 / 0x10B30)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:0b3e (1000_0B35 / 0x10B35)
    if(!ZeroFlag) {
      goto label_1000_0B3E_10B3E;
    }
    // CMP byte ptr [0xfb],0x0 (1000_0B37 / 0x10B37)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:0b44 (1000_0B3C / 0x10B3C)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_0B44 / 0x10B44)
      return NearRet();
    }
    label_1000_0B3E_10B3E:
    // MOV word ptr [0x3cbe],0x0 (1000_0B3E / 0x10B3E)
    UInt16[DS, 0x3CBE] = 0x0;
    label_1000_0B44_10B44:
    // RET  (1000_0B44 / 0x10B44)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_0D45_010D45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0D45_10D45:
    // CALL 0x1000:395c (1000_0D45 / 0x10D45)
    NearCall(cs1, 0xD48, spice86_generated_label_call_target_1000_395C_01395C);
    // CALL 0x1000:3971 (1000_0D48 / 0x10D48)
    NearCall(cs1, 0xD4B, spice86_generated_label_call_target_1000_3971_013971);
    // CALL 0x1000:39b9 (1000_0D4B / 0x10D4B)
    NearCall(cs1, 0xD4E, spice86_generated_label_call_target_1000_39B9_0139B9);
    // INC byte ptr [0x227d] (1000_0D4E / 0x10D4E)
    UInt8[DS, 0x227D] = Alu.Inc8(UInt8[DS, 0x227D]);
    // MOV CX,0x3 (1000_0D52 / 0x10D52)
    CX = 0x3;
    label_1000_0D55_10D55:
    // PUSH CX (1000_0D55 / 0x10D55)
    Stack.Push(CX);
    // MOV BL,0x28 (1000_0D56 / 0x10D56)
    BL = 0x28;
    // CALL 0x1000:3971 (1000_0D58 / 0x10D58)
    NearCall(cs1, 0xD5B, spice86_generated_label_call_target_1000_3971_013971);
    // CALL 0x1000:398c (1000_0D5B / 0x10D5B)
    NearCall(cs1, 0xD5E, spice86_generated_label_call_target_1000_398C_01398C);
    // CALL 0x1000:c0f4 (1000_0D5E / 0x10D5E)
    NearCall(cs1, 0xD61, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // MOV byte ptr [0x46d7],0x20 (1000_0D61 / 0x10D61)
    UInt8[DS, 0x46D7] = 0x20;
    label_1000_0D66_10D66:
    // MOV BP,0x391d (1000_0D66 / 0x10D66)
    BP = 0x391D;
    // MOV AX,0x3 (1000_0D69 / 0x10D69)
    AX = 0x3;
    // CALL 0x1000:e353 (1000_0D6C / 0x10D6C)
    NearCall(cs1, 0xD6F, spice86_generated_label_call_target_1000_E353_01E353);
    // CMP byte ptr [0x46d7],0x10 (1000_0D6F / 0x10D6F)
    Alu.Sub8(UInt8[DS, 0x46D7], 0x10);
    // JNC 0x1000:0d66 (1000_0D74 / 0x10D74)
    if(!CarryFlag) {
      goto label_1000_0D66_10D66;
    }
    // POP CX (1000_0D76 / 0x10D76)
    CX = Stack.Pop();
    // LOOP 0x1000:0d55 (1000_0D77 / 0x10D77)
    if(--CX != 0) {
      goto label_1000_0D55_10D55;
    }
    label_1000_0D79_10D79:
    // MOV BP,0x391d (1000_0D79 / 0x10D79)
    BP = 0x391D;
    // MOV AX,0x3 (1000_0D7C / 0x10D7C)
    AX = 0x3;
    // CALL 0x1000:e353 (1000_0D7F / 0x10D7F)
    NearCall(cs1, 0xD82, spice86_generated_label_call_target_1000_E353_01E353);
    // CMP byte ptr [0x46d7],0x0 (1000_0D82 / 0x10D82)
    Alu.Sub8(UInt8[DS, 0x46D7], 0x0);
    // JNZ 0x1000:0d79 (1000_0D87 / 0x10D87)
    if(!ZeroFlag) {
      goto label_1000_0D79_10D79;
    }
    // DEC byte ptr [0x227d] (1000_0D89 / 0x10D89)
    UInt8[DS, 0x227D] = Alu.Dec8(UInt8[DS, 0x227D]);
    // RET  (1000_0D8D / 0x10D8D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_0D8E_010D8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0D8E_10D8E:
    // CMP byte ptr [0x47a9],0x0 (1000_0D8E / 0x10D8E)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    // JNZ 0x1000:0d9d (1000_0D93 / 0x10D93)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_0D9D / 0x10D9D)
      return NearRet();
    }
    // XOR AX,AX (1000_0D95 / 0x10D95)
    AX = 0;
    // CMP byte ptr [0x46d9],AL (1000_0D97 / 0x10D97)
    Alu.Sub8(UInt8[DS, 0x46D9], AL);
    // JNS 0x1000:0d9e (1000_0D9B / 0x10D9B)
    if(!SignFlag) {
      goto label_1000_0D9E_10D9E;
    }
    label_1000_0D9D_10D9D:
    // RET  (1000_0D9D / 0x10D9D)
    return NearRet();
    label_1000_0D9E_10D9E:
    // MOV [0x473b],AL (1000_0D9E / 0x10D9E)
    UInt8[DS, 0x473B] = AL;
    // MOV [0x46ec],AL (1000_0DA1 / 0x10DA1)
    UInt8[DS, 0x46EC] = AL;
    // CMP byte ptr [0xfb],AL (1000_0DA4 / 0x10DA4)
    Alu.Sub8(UInt8[DS, 0xFB], AL);
    // JNS 0x1000:0db0 (1000_0DA8 / 0x10DA8)
    if(!SignFlag) {
      goto label_1000_0DB0_10DB0;
    }
    // CALL 0x1000:dbb2 (1000_0DAA / 0x10DAA)
    NearCall(cs1, 0xDAD, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // JMP 0x1000:186b (1000_0DAD / 0x10DAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_186B_01186B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_0DB0_10DB0:
    // CALL 0x1000:d2bd (1000_0DB0 / 0x10DB0)
    NearCall(cs1, 0xDB3, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // CALL 0x1000:0d45 (1000_0DB3 / 0x10DB3)
    NearCall(cs1, 0xDB6, not_observed_1000_0D45_010D45);
    // CALL 0x1000:dbb2 (1000_0DB6 / 0x10DB6)
    NearCall(cs1, 0xDB9, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:98e6 (1000_0DB9 / 0x10DB9)
    NearCall(cs1, 0xDBC, spice86_generated_label_call_target_1000_98E6_0198E6);
    // MOV word ptr [0x2],0x16c5 (1000_0DBC / 0x10DBC)
    UInt16[DS, 0x2] = 0x16C5;
    // CALL 0x1000:0e66 (1000_0DC2 / 0x10DC2)
    NearCall(cs1, 0xDC5, not_observed_1000_0E66_010E66);
    // MOV byte ptr [0x11ca],0x1 (1000_0DC5 / 0x10DC5)
    UInt8[DS, 0x11CA] = 0x1;
    // CALL 0x1000:9f40 (1000_0DCA / 0x10DCA)
    NearCall(cs1, 0xDCD, spice86_generated_label_call_target_1000_9F40_019F40);
    // MOV word ptr [0x47c4],0xffff (1000_0DCD / 0x10DCD)
    UInt16[DS, 0x47C4] = 0xFFFF;
    // MOV AL,0x80 (1000_0DD3 / 0x10DD3)
    AL = 0x80;
    // XCHG byte ptr [0x46d9],AL (1000_0DD5 / 0x10DD5)
    byte tmp_1000_0DD5 = UInt8[DS, 0x46D9];
    UInt8[DS, 0x46D9] = AL;
    AL = tmp_1000_0DD5;
    // XOR AH,AH (1000_0DD9 / 0x10DD9)
    AH = 0;
    // PUSH AX (1000_0DDB / 0x10DDB)
    Stack.Push(AX);
    // ADD AX,0xba (1000_0DDC / 0x10DDC)
    // AX += 0xBA;
    AX = Alu.Add16(AX, 0xBA);
    // CALL 0x1000:9901 (1000_0DDF / 0x10DDF)
    NearCall(cs1, 0xDE2, spice86_generated_label_call_target_1000_9901_019901);
    // CALL 0x1000:88af (1000_0DE2 / 0x10DE2)
    NearCall(cs1, 0xDE5, spice86_generated_label_call_target_1000_88AF_0188AF);
    // CALL 0x1000:9901 (1000_0DE5 / 0x10DE5)
    NearCall(cs1, 0xDE8, spice86_generated_label_call_target_1000_9901_019901);
    // MOV SI,0x2254 (1000_0DE8 / 0x10DE8)
    SI = 0x2254;
    // CALL 0x1000:7b1b (1000_0DEB / 0x10DEB)
    NearCall(cs1, 0xDEE, spice86_generated_label_call_target_1000_7B1B_017B1B);
    // CALL 0x1000:da53 (1000_0DEE / 0x10DEE)
    NearCall(cs1, 0xDF1, spice86_generated_label_call_target_1000_DA53_01DA53);
    // POP AX (1000_0DF1 / 0x10DF1)
    AX = Stack.Pop();
    // MOV BX,0x225d (1000_0DF2 / 0x10DF2)
    BX = 0x225D;
    // XLAT BX (1000_0DF5 / 0x10DF5)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // OR AL,AL (1000_0DF6 / 0x10DF6)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:0e22 (1000_0DF8 / 0x10DF8)
    if(SignFlag) {
      goto label_1000_0E22_10E22;
    }
    // CALL 0x1000:91a0 (1000_0DFA / 0x10DFA)
    NearCall(cs1, 0xDFD, spice86_generated_label_call_target_1000_91A0_0191A0);
    // LES SI,[0xdbb0] (1000_0DFD / 0x10DFD)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // LODSW ES:SI (1000_0E01 / 0x10E01)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // SHR AX,1 (1000_0E03 / 0x10E03)
    AX >>= 0x1;
    // SUB AX,0x3 (1000_0E05 / 0x10E05)
    // AX -= 0x3;
    AX = Alu.Sub16(AX, 0x3);
    // MOV DX,word ptr [0x2254] (1000_0E08 / 0x10E08)
    DX = UInt16[DS, 0x2254];
    // MOV BX,word ptr [0x2256] (1000_0E0C / 0x10E0C)
    BX = UInt16[DS, 0x2256];
    // INC DX (1000_0E10 / 0x10E10)
    DX++;
    // INC BX (1000_0E11 / 0x10E11)
    BX = Alu.Inc16(BX);
    // PUSH AX (1000_0E12 / 0x10E12)
    Stack.Push(AX);
    // CALL 0x1000:c2fd (1000_0E13 / 0x10E13)
    NearCall(cs1, 0xE16, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    // POP AX (1000_0E16 / 0x10E16)
    AX = Stack.Pop();
    // INC AX (1000_0E17 / 0x10E17)
    AX = Alu.Inc16(AX);
    // CALL 0x1000:c22f (1000_0E18 / 0x10E18)
    NearCall(cs1, 0xE1B, spice86_generated_label_call_target_1000_C22F_01C22F);
    // CALLF [0x3935] (1000_0E1B / 0x10E1B)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_0E1B = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_0E1B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0E1B));
        break;
    }
    // CALL 0x1000:9efd (1000_0E1F / 0x10E1F)
    NearCall(cs1, 0xE22, spice86_generated_label_call_target_1000_9EFD_019EFD);
    label_1000_0E22_10E22:
    // CALL 0x1000:c4cd (1000_0E22 / 0x10E22)
    NearCall(cs1, 0xE25, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    // MOV byte ptr [0x4727],0x0 (1000_0E25 / 0x10E25)
    UInt8[DS, 0x4727] = 0x0;
    // CALL 0x1000:d741 (1000_0E2A / 0x10E2A)
    NearCall(cs1, 0xE2D, spice86_generated_label_call_target_1000_D741_01D741);
    // MOV byte ptr [0x47a7],0x1 (1000_0E2D / 0x10E2D)
    UInt8[DS, 0x47A7] = 0x1;
    // MOV BP,0x20a2 (1000_0E32 / 0x10E32)
    BP = 0x20A2;
    // MOV BX,0xf66 (1000_0E35 / 0x10E35)
    BX = 0xF66;
    // CALL 0x1000:d323 (1000_0E38 / 0x10E38)
    NearCall(cs1, 0xE3B, spice86_generated_label_call_target_1000_D323_01D323);
    // JMP 0x1000:dbec (1000_0E3B / 0x10E3B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0E3E_010E3E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0E3E_10E3E:
    // MOV BX,0xf66 (1000_0E3E / 0x10E3E)
    BX = 0xF66;
    // MOV BP,0x20b6 (1000_0E41 / 0x10E41)
    BP = 0x20B6;
    // JMP 0x1000:d323 (1000_0E44 / 0x10E44)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_0E66_010E66(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0E66_10E66:
    // CALL 0x1000:ad5e (1000_0E66 / 0x10E66)
    NearCall(cs1, 0xE69, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    // MOV AX,0xc (1000_0E69 / 0x10E69)
    AX = 0xC;
    // PUSH AX (1000_0E6C / 0x10E6C)
    Stack.Push(AX);
    // CALL 0x1000:a7a5 (1000_0E6D / 0x10E6D)
    NearCall(cs1, 0xE70, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // POP AX (1000_0E70 / 0x10E70)
    AX = Stack.Pop();
    // MOV BP,0x181e (1000_0E71 / 0x10E71)
    BP = 0x181E;
    // JMP 0x1000:c8fb (1000_0E74 / 0x10E74)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_C8FB_01C8FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0EA6_010EA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0EA6_10EA6:
    // CALL 0x1000:b2b9 (1000_0EA6 / 0x10EA6)
    NearCall(cs1, 0xEA9, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0EA9_010EA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0EA9_010EA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0EA9_10EA9:
    // CALL 0x1000:98e6 (1000_0EA9 / 0x10EA9)
    NearCall(cs1, 0xEAC, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0EAC_010EAC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0EAC_010EAC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0EAC_10EAC:
    // CALL 0x1000:181e (1000_0EAC / 0x10EAC)
    NearCall(cs1, 0xEAF, spice86_generated_label_call_target_1000_181E_01181E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0EAF_010EAF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0EAF_010EAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0EAF_10EAF:
    // MOV AL,0x4 (1000_0EAF / 0x10EAF)
    AL = 0x4;
    // XOR DX,DX (1000_0EB1 / 0x10EB1)
    DX = 0;
    // MOV BP,0xed0 (1000_0EB3 / 0x10EB3)
    BP = 0xED0;
    // JMP 0x1000:c108 (1000_0EB6 / 0x10EB6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C108_01C108, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_0EB9_010EB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0EB9_10EB9:
    // XOR AX,AX (1000_0EB9 / 0x10EB9)
    AX = 0;
    // MOV [0x47c3],AL (1000_0EBB / 0x10EBB)
    UInt8[DS, 0x47C3] = AL;
    // CALL 0x1000:b2be (1000_0EBE / 0x10EBE)
    NearCall(cs1, 0xEC1, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    label_1000_0EC1_10EC1:
    // MOV byte ptr [0x47a6],0xff (1000_0EC1 / 0x10EC1)
    UInt8[DS, 0x47A6] = 0xFF;
    // MOV AL,0x4 (1000_0EC6 / 0x10EC6)
    AL = 0x4;
    // XOR DX,DX (1000_0EC8 / 0x10EC8)
    DX = 0;
    // CALL 0x1000:189a (1000_0ECA / 0x10ECA)
    NearCall(cs1, 0xECD, spice86_generated_label_call_target_1000_189A_01189A);
    label_1000_0ECD_10ECD:
    // JMP 0x1000:2db1 (1000_0ECD / 0x10ECD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2DB1_012DB1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0ED0_010ED0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0ED0_10ED0:
    // MOV AL,0x3b (1000_0ED0 / 0x10ED0)
    AL = 0x3B;
    // CALL 0x1000:c2f2 (1000_0ED2 / 0x10ED2)
    NearCall(cs1, 0xED5, spice86_generated_label_call_target_1000_C2F2_01C2F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0ED5_010ED5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0ED5_010ED5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0ED5_10ED5:
    // MOV AX,0x1 (1000_0ED5 / 0x10ED5)
    AX = 0x1;
    // CALL 0x1000:c22f (1000_0ED8 / 0x10ED8)
    NearCall(cs1, 0xEDB, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_0EDB_10EDB:
    // CALL 0x1000:0f08 (1000_0EDB / 0x10EDB)
    NearCall(cs1, 0xEDE, spice86_generated_label_call_target_1000_0F08_010F08);
    label_1000_0EDE_10EDE:
    // MOV AX,0x3b (1000_0EDE / 0x10EDE)
    AX = 0x3B;
    // CALL 0x1000:c13e (1000_0EE1 / 0x10EE1)
    NearCall(cs1, 0xEE4, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_0EE4_10EE4:
    // MOV AX,0x2 (1000_0EE4 / 0x10EE4)
    AX = 0x2;
    // XOR DX,DX (1000_0EE7 / 0x10EE7)
    DX = 0;
    // XOR BX,BX (1000_0EE9 / 0x10EE9)
    BX = 0;
    // CALL 0x1000:c22f (1000_0EEB / 0x10EEB)
    NearCall(cs1, 0xEEE, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_0EEE_10EEE:
    // CALL 0x1000:1797 (1000_0EEE / 0x10EEE)
    NearCall(cs1, 0xEF1, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_0EF1_10EF1:
    // MOV SI,0x1d1e (1000_0EF1 / 0x10EF1)
    SI = 0x1D1E;
    // CALL 0x1000:d72b (1000_0EF4 / 0x10EF4)
    NearCall(cs1, 0xEF7, spice86_generated_label_call_target_1000_D72B_01D72B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0EF7_010EF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0EF7_010EF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0EF7_10EF7:
    // CALL 0x1000:98f5 (1000_0EF7 / 0x10EF7)
    NearCall(cs1, 0xEFA, spice86_generated_label_call_target_1000_98F5_0198F5);
    label_1000_0EFA_10EFA:
    // MOV byte ptr [0x1c06],0x80 (1000_0EFA / 0x10EFA)
    UInt8[DS, 0x1C06] = 0x80;
    // MOV BP,0x20c2 (1000_0EFF / 0x10EFF)
    BP = 0x20C2;
    // MOV BX,0xeb9 (1000_0F02 / 0x10F02)
    BX = 0xEB9;
    // JMP 0x1000:d338 (1000_0F05 / 0x10F05)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D338_01D338, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0F08_010F08(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0F08_10F08:
    // TEST word ptr [0x10],0x80 (1000_0F08 / 0x10F08)
    Alu.And16(UInt16[DS, 0x10], 0x80);
    // JNZ 0x1000:0f13 (1000_0F0E / 0x10F0E)
    if(!ZeroFlag) {
      goto label_1000_0F13_10F13;
    }
    // JMP 0x1000:0960 (1000_0F10 / 0x10F10)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0960_010960, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_0F13_10F13:
    // CALL 0x1000:c412 (1000_0F13 / 0x10F13)
    NearCall(cs1, 0xF16, spice86_generated_label_call_target_1000_C412_01C412);
    // MOV word ptr [0x47c4],0x7 (1000_0F16 / 0x10F16)
    UInt16[DS, 0x47C4] = 0x7;
    // CALL 0x1000:9197 (1000_0F1C / 0x10F1C)
    NearCall(cs1, 0xF1F, spice86_generated_label_call_target_1000_9197_019197);
    // MOV byte ptr [0x478c],0x0 (1000_0F1F / 0x10F1F)
    UInt8[DS, 0x478C] = 0x0;
    // ADD word ptr [0x1bf2],0xf (1000_0F24 / 0x10F24)
    // UInt16[DS, 0x1BF2] += 0xF;
    UInt16[DS, 0x1BF2] = Alu.Add16(UInt16[DS, 0x1BF2], 0xF);
    // CALL 0x1000:978e (1000_0F29 / 0x10F29)
    NearCall(cs1, 0xF2C, spice86_generated_label_call_target_1000_978E_01978E);
    // CALL 0x1000:998e (1000_0F2C / 0x10F2C)
    NearCall(cs1, 0xF2F, not_observed_1000_998E_01998E);
    // MOV word ptr [0x22a6],0xffff (1000_0F2F / 0x10F2F)
    UInt16[DS, 0x22A6] = 0xFFFF;
    // INC byte ptr [0x47c3] (1000_0F35 / 0x10F35)
    UInt8[DS, 0x47C3] = Alu.Inc8(UInt8[DS, 0x47C3]);
    // MOV word ptr [0x47c6],0x1 (1000_0F39 / 0x10F39)
    UInt16[DS, 0x47C6] = 0x1;
    // CALL 0x1000:c412 (1000_0F3F / 0x10F3F)
    NearCall(cs1, 0xF42, spice86_generated_label_call_target_1000_C412_01C412);
    // MOV DX,0x2d (1000_0F42 / 0x10F42)
    DX = 0x2D;
    // JMP 0x1000:0965 (1000_0F45 / 0x10F45)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0960_010960, 0x10965 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0F66_010F66(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0F66_10F66:
    // RET  (1000_0F66 / 0x10F66)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_0FA7_010FA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0FA7_10FA7:
    // CALL 0x1000:dbb2 (1000_0FA7 / 0x10FA7)
    NearCall(cs1, 0xFAA, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // MOV AL,0x2a (1000_0FAA / 0x10FAA)
    AL = 0x2A;
    // CALL 0x1000:189a (1000_0FAC / 0x10FAC)
    NearCall(cs1, 0xFAF, spice86_generated_label_call_target_1000_189A_01189A);
    // JMP 0x1000:d763 (1000_0FAF / 0x10FAF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_0FD9_010FD9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0FD9_10FD9:
    // MOV byte ptr [0x46da],0x1 (1000_0FD9 / 0x10FD9)
    UInt8[DS, 0x46DA] = 0x1;
    // CALL 0x1000:b2be (1000_0FDE / 0x10FDE)
    NearCall(cs1, 0xFE1, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_0FE1_010FE1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_0FE1_010FE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0FE1_10FE1:
    // OR CX,CX (1000_0FE1 / 0x10FE1)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JLE 0x1000:1005 (1000_0FE3 / 0x10FE3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1002_011002, 0x11005 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH CX (1000_0FE5 / 0x10FE5)
    Stack.Push(CX);
    // MOV AX,[0x146e] (1000_0FE6 / 0x10FE6)
    AX = UInt16[DS, 0x146E];
    // MOV [0x46db],AX (1000_0FE9 / 0x10FE9)
    UInt16[DS, 0x46DB] = AX;
    // CMP byte ptr [0x46dd],0x0 (1000_0FEC / 0x10FEC)
    Alu.Sub8(UInt8[DS, 0x46DD], 0x0);
    // JZ 0x1000:0ff6 (1000_0FF1 / 0x10FF1)
    if(ZeroFlag) {
      goto label_1000_0FF6_10FF6;
    }
    // CALL 0x1000:1b23 (1000_0FF3 / 0x10FF3)
    NearCall(cs1, 0xFF6, spice86_generated_label_ret_target_1000_1B23_011B23);
    label_1000_0FF6_10FF6:
    // INC word ptr [0x2] (1000_0FF6 / 0x10FF6)
    UInt16[DS, 0x2] = Alu.Inc16(UInt16[DS, 0x2]);
    // MOV byte ptr [0x46dd],0x1 (1000_0FFA / 0x10FFA)
    UInt8[DS, 0x46DD] = 0x1;
    // CALL 0x1000:1b23 (1000_0FFF / 0x10FFF)
    NearCall(cs1, 0x1002, spice86_generated_label_ret_target_1000_1B23_011B23);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1002_011002, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1002_011002(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1002_11002:
    // POP CX (1000_1002 / 0x11002)
    CX = Stack.Pop();
    // LOOP 0x1000:0fd9 (1000_1003 / 0x11003)
    if(--CX != 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0FD9_010FD9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_1005_11005:
    // MOV byte ptr [0x46da],0x0 (1000_1005 / 0x11005)
    UInt8[DS, 0x46DA] = 0x0;
    // RET  (1000_100A / 0x1100A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_100B_01100B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_100B_1100B:
    // MOV byte ptr [0x100b],0x1 (1000_100B / 0x1100B)
    UInt8[DS, 0x100B] = 0x1;
    // RET  (1000_1010 / 0x11010)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1011_011011(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1011_11011:
    // DEC byte ptr [0x122a] (1000_1011 / 0x11011)
    UInt8[DS, 0x122A] = Alu.Dec8(UInt8[DS, 0x122A]);
    // MOV SI,0x1021 (1000_1015 / 0x11015)
    SI = 0x1021;
    // CALL 0x1000:105b (1000_1018 / 0x11018)
    NearCall(cs1, 0x101B, spice86_generated_label_call_target_1000_105B_01105B);
    label_1000_101B_1101B:
    // MOV byte ptr [0xfe8],0x9 (1000_101B / 0x1101B)
    UInt8[DS, 0xFE8] = 0x9;
    // RET  (1000_1020 / 0x11020)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_105B_01105B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_105B_1105B:
    // LODSW CS:SI (1000_105B / 0x1105B)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_105D / 0x1105D)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:1068 (1000_105F / 0x1105F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1068 / 0x11068)
      return NearRet();
    }
    // MOV DI,AX (1000_1061 / 0x11061)
    DI = AX;
    // CALL 0x1000:425b (1000_1063 / 0x11063)
    NearCall(cs1, 0x1066, spice86_generated_label_call_target_1000_425B_01425B);
    label_1000_1066_11066:
    // JMP 0x1000:105b (1000_1066 / 0x11066)
    goto label_1000_105B_1105B;
    label_1000_1068_11068:
    // RET  (1000_1068 / 0x11068)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_1071_011071(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1071_11071:
    // MOV byte ptr [0xff],0x0 (1000_1071 / 0x11071)
    UInt8[DS, 0xFF] = 0x0;
    // MOV byte ptr [0x2a],0x15 (1000_1076 / 0x11076)
    UInt8[DS, 0x2A] = 0x15;
    // MOV byte ptr [0xfdb],0x1 (1000_107B / 0x1107B)
    UInt8[DS, 0xFDB] = 0x1;
    // MOV word ptr [0x1018],0x200b (1000_1080 / 0x11080)
    UInt16[DS, 0x1018] = 0x200B;
    // MOV word ptr [0x101a],0x180 (1000_1086 / 0x11086)
    UInt16[DS, 0x101A] = 0x180;
    // MOV byte ptr [0xfe8],0xa (1000_108C / 0x1108C)
    UInt8[DS, 0xFE8] = 0xA;
    // MOV byte ptr [0xd5],0xff (1000_1091 / 0x11091)
    UInt8[DS, 0xD5] = 0xFF;
    // CALL 0x1000:2090 (1000_1096 / 0x11096)
    NearCall(cs1, 0x1099, not_observed_1000_2090_012090);
    // OR byte ptr [0xa],0x1 (1000_1099 / 0x11099)
    // UInt8[DS, 0xA] |= 0x1;
    UInt8[DS, 0xA] = Alu.Or8(UInt8[DS, 0xA], 0x1);
    // MOV AX,0x1 (1000_109E / 0x1109E)
    AX = 0x1;
    // JMP 0x1000:29ee (1000_10A1 / 0x110A1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_29EE_0129EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_11CB_0111CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_11CB_111CB:
    // MOV byte ptr [0xff],0x0 (1000_11CB / 0x111CB)
    UInt8[DS, 0xFF] = 0x0;
    // MOV byte ptr [0x2a],0x60 (1000_11D0 / 0x111D0)
    UInt8[DS, 0x2A] = 0x60;
    // MOV DI,0x11c (1000_11D5 / 0x111D5)
    DI = 0x11C;
    // CALL 0x1000:40ae (1000_11D8 / 0x111D8)
    NearCall(cs1, 0x11DB, spice86_generated_label_call_target_1000_40AE_0140AE);
    // MOV DL,0x2 (1000_11DB / 0x111DB)
    DL = 0x2;
    // MOV word ptr [0x1048],DX (1000_11DD / 0x111DD)
    UInt16[DS, 0x1048] = DX;
    // MOV word ptr [0x104a],BX (1000_11E1 / 0x111E1)
    UInt16[DS, 0x104A] = BX;
    // RET  (1000_11E5 / 0x111E5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_121F_01121F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_121F_1121F:
    // CMP AL,byte ptr [0x2a] (1000_121F / 0x1121F)
    Alu.Sub8(AL, UInt8[DS, 0x2A]);
    // JBE 0x1000:1242 (1000_1223 / 0x11223)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_1242 / 0x11242)
      return NearRet();
    }
    // MOV [0x2a],AL (1000_1225 / 0x11225)
    UInt8[DS, 0x2A] = AL;
    // MOV byte ptr [0xff],0x0 (1000_1228 / 0x11228)
    UInt8[DS, 0xFF] = 0x0;
    // CALL 0x1000:b17a (1000_122D / 0x1122D)
    NearCall(cs1, 0x1230, spice86_generated_label_call_target_1000_B17A_01B17A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1230_011230, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1230_011230(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1230_11230:
    // MOV BL,byte ptr [0x2a] (1000_1230 / 0x11230)
    BL = UInt8[DS, 0x2A];
    // CMP BL,0x6c (1000_1234 / 0x11234)
    Alu.Sub8(BL, 0x6C);
    // JA 0x1000:1242 (1000_1237 / 0x11237)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_1242 / 0x11242)
      return NearRet();
    }
    // XOR BH,BH (1000_1239 / 0x11239)
    BH = 0;
    // SHR BX,1 (1000_123B / 0x1123B)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // CALL word ptr CS:[BX + 0x11e7] (1000_123D / 0x1123D)
    // Indirect call to word ptr CS:[BX + 0x11e7], generating possible targets from emulator records
    uint targetAddress_1000_123D = (uint)(UInt16[cs1, (ushort)(BX + 0x11E7)]);
    switch(targetAddress_1000_123D) {
      case 0x1011 : NearCall(cs1, 0x1242, spice86_generated_label_call_target_1000_1011_011011); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_123D));
        break;
    }
    label_1000_1242_11242:
    // RET  (1000_1242 / 0x11242)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_1243_011243(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1243_11243:
    // MOV BP,0x1269 (1000_1243 / 0x11243)
    BP = 0x1269;
    // XOR DX,DX (1000_1246 / 0x11246)
    DX = 0;
    // XOR BX,BX (1000_1248 / 0x11248)
    BX = 0;
    // CALL 0x1000:1258 (1000_124A / 0x1124A)
    NearCall(cs1, 0x124D, not_observed_1000_1258_011258);
    // CMP BX,0x3e8 (1000_124D / 0x1124D)
    Alu.Sub16(BX, 0x3E8);
    // JC 0x1000:1257 (1000_1251 / 0x11251)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_1257 / 0x11257)
      return NearRet();
    }
    // INC byte ptr [0xc2] (1000_1253 / 0x11253)
    UInt8[DS, 0xC2] = Alu.Inc8(UInt8[DS, 0xC2]);
    label_1000_1257_11257:
    // RET  (1000_1257 / 0x11257)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_1258_011258(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1258_11258:
    // MOV DI,0x138 (1000_1258 / 0x11258)
    DI = 0x138;
    // MOV CX,0x3 (1000_125B / 0x1125B)
    CX = 0x3;
    label_1000_125E_1125E:
    // PUSH CX (1000_125E / 0x1125E)
    Stack.Push(CX);
    // CALL 0x1000:661d (1000_125F / 0x1125F)
    NearCall(cs1, 0x1262, spice86_generated_label_call_target_1000_661D_01661D);
    // POP CX (1000_1262 / 0x11262)
    CX = Stack.Pop();
    // ADD DI,0x1c (1000_1263 / 0x11263)
    // DI += 0x1C;
    DI = Alu.Add16(DI, 0x1C);
    // LOOP 0x1000:125e (1000_1266 / 0x11266)
    if(--CX != 0) {
      goto label_1000_125E_1125E;
    }
    // RET  (1000_1268 / 0x11268)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_127C_01127C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_127C_1127C:
    // CMP AL,0x4 (1000_127C / 0x1127C)
    Alu.Sub8(AL, 0x4);
    // JNZ 0x1000:128d (1000_127E / 0x1127E)
    if(!ZeroFlag) {
      goto label_1000_128D_1128D;
    }
    // CMP byte ptr [0x2a],0x15 (1000_1280 / 0x11280)
    Alu.Sub8(UInt8[DS, 0x2A], 0x15);
    // JC 0x1000:128d (1000_1285 / 0x11285)
    if(CarryFlag) {
      goto label_1000_128D_1128D;
    }
    // CMP byte ptr [0x2a],0x20 (1000_1287 / 0x11287)
    Alu.Sub8(UInt8[DS, 0x2A], 0x20);
    // RET  (1000_128C / 0x1128C)
    return NearRet();
    label_1000_128D_1128D:
    // CLC  (1000_128D / 0x1128D)
    CarryFlag = false;
    // RET  (1000_128E / 0x1128E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_16FC_0116FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_16FC_116FC:
    // MOV byte ptr [0x2a],0xc8 (1000_16FC / 0x116FC)
    UInt8[DS, 0x2A] = 0xC8;
    // MOV AX,0x128f (1000_1701 / 0x11701)
    AX = 0x128F;
    // CALL 0x1000:1771 (1000_1704 / 0x11704)
    NearCall(cs1, 0x1707, not_observed_1000_1771_011771);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_1707_011707, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_1707_011707(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1707_11707:
    // CMP word ptr [0x2220],0x1fae (1000_1707 / 0x11707)
    Alu.Sub16(UInt16[DS, 0x2220], 0x1FAE);
    // JNZ 0x1000:171a (1000_170D / 0x1170D)
    if(!ZeroFlag) {
      goto label_1000_171A_1171A;
    }
    // MOV DI,0x1b56 (1000_170F / 0x1170F)
    DI = 0x1B56;
    // CALL 0x1000:d6fe (1000_1712 / 0x11712)
    NearCall(cs1, 0x1715, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JNC 0x1000:171a (1000_1715 / 0x11715)
    if(!CarryFlag) {
      goto label_1000_171A_1171A;
    }
    // JMP 0x1000:9ed5 (1000_1717 / 0x11717)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9ED5_019ED5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_171A_1171A:
    // MOV byte ptr [0xce9d],0x0 (1000_171A / 0x1171A)
    UInt8[DS, 0xCE9D] = 0x0;
    // MOV SI,word ptr [0x477a] (1000_171F / 0x1171F)
    SI = UInt16[DS, 0x477A];
    // LODSB CS:SI (1000_1723 / 0x11723)
    AL = UInt8[cs1, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_1725 / 0x11725)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:1736 (1000_1727 / 0x11727)
    if(ZeroFlag) {
      goto label_1000_1736_11736;
    }
    // MOV word ptr [0x477a],SI (1000_1729 / 0x11729)
    UInt16[DS, 0x477A] = SI;
    // XOR AH,AH (1000_172D / 0x1172D)
    AH = 0;
    // MOV BX,AX (1000_172F / 0x1172F)
    BX = AX;
    // JMP word ptr CS:[BX + 0x1475] (1000_1731 / 0x11731)
    // Indirect jump to word ptr CS:[BX + 0x1475], generating possible targets from emulator records
    uint targetAddress_1000_1731 = (uint)(UInt16[cs1, (ushort)(BX + 0x1475)]);
    switch(targetAddress_1000_1731) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_1731));
        break;
    }
    label_1000_1736_11736:
    // MOV SI,0x176b (1000_1736 / 0x11736)
    SI = 0x176B;
    // CALL 0x1000:da5f (1000_1739 / 0x11739)
    NearCall(cs1, 0x173C, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // MOV AX,[0x4776] (1000_173C / 0x1173C)
    AX = UInt16[DS, 0x4776];
    // MOV [0x4],AL (1000_173F / 0x1173F)
    UInt8[DS, 0x4] = AL;
    // MOV byte ptr [0x46e0],AH (1000_1742 / 0x11742)
    UInt8[DS, 0x46E0] = AH;
    // XOR AL,AL (1000_1746 / 0x11746)
    AL = 0;
    // MOV [0x4774],AL (1000_1748 / 0x11748)
    UInt8[DS, 0x4774] = AL;
    // CMP byte ptr [0x2a],0x48 (1000_174B / 0x1174B)
    Alu.Sub8(UInt8[DS, 0x2A], 0x48);
    // JZ 0x1000:1755 (1000_1750 / 0x11750)
    if(ZeroFlag) {
      goto label_1000_1755_11755;
    }
    // CALL 0x1000:adbe (1000_1752 / 0x11752)
    NearCall(cs1, 0x1755, spice86_generated_label_call_target_1000_ADBE_01ADBE);
    label_1000_1755_11755:
    // CALL 0x1000:b2be (1000_1755 / 0x11755)
    NearCall(cs1, 0x1758, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    // CMP byte ptr [0xfb],0x0 (1000_1758 / 0x11758)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:1762 (1000_175D / 0x1175D)
    if(SignFlag) {
      goto label_1000_1762_11762;
    }
    // JMP 0x1000:0fa7 (1000_175F / 0x1175F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_0FA7_010FA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1762_11762:
    // CALL 0x1000:ad5e (1000_1762 / 0x11762)
    NearCall(cs1, 0x1765, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    // CALL 0x1000:68eb (1000_1765 / 0x11765)
    NearCall(cs1, 0x1768, spice86_generated_label_call_target_1000_68EB_0168EB);
    // JMP 0x1000:780a (1000_1768 / 0x11768)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_780A_01780A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_1771_011771(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1771_11771:
    // MOV [0x477a],AX (1000_1771 / 0x11771)
    UInt16[DS, 0x477A] = AX;
    // MOV word ptr [0x4778],0x0 (1000_1774 / 0x11774)
    UInt16[DS, 0x4778] = 0x0;
    // INC byte ptr [0x4774] (1000_177A / 0x1177A)
    UInt8[DS, 0x4774] = Alu.Inc8(UInt8[DS, 0x4774]);
    // CALL 0x1000:b2b9 (1000_177E / 0x1177E)
    NearCall(cs1, 0x1781, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    // CALL 0x1000:ad5e (1000_1781 / 0x11781)
    NearCall(cs1, 0x1784, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    // MOV AL,[0x4] (1000_1784 / 0x11784)
    AL = UInt8[DS, 0x4];
    // MOV AH,byte ptr [0x46e0] (1000_1787 / 0x11787)
    AH = UInt8[DS, 0x46E0];
    // MOV [0x4776],AX (1000_178B / 0x1178B)
    UInt16[DS, 0x4776] = AX;
    // MOV BP,0x64 (1000_178E / 0x1178E)
    BP = 0x64;
    // MOV SI,0x176b (1000_1791 / 0x11791)
    SI = 0x176B;
    // JMP 0x1000:da25 (1000_1794 / 0x11794)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA25_01DA25, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1797_011797(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1797_11797:
    // PUSH word ptr [0x2784] (1000_1797 / 0x11797)
    Stack.Push(UInt16[DS, 0x2784]);
    // CALL 0x1000:c137 (1000_179B / 0x1179B)
    NearCall(cs1, 0x179E, spice86_generated_label_call_target_1000_C137_01C137);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_179E_01179E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_179E_01179E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_179E_1179E:
    // MOV DX,0x7e (1000_179E / 0x1179E)
    DX = 0x7E;
    // MOV BX,0x94 (1000_17A1 / 0x117A1)
    BX = 0x94;
    // MOV AX,0xf (1000_17A4 / 0x117A4)
    AX = 0xF;
    // CALL 0x1000:c22f (1000_17A7 / 0x117A7)
    NearCall(cs1, 0x17AA, spice86_generated_label_call_target_1000_C22F_01C22F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_17AA_0117AA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_17AA_0117AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17AA_117AA:
    // MOV AX,0x10 (1000_17AA / 0x117AA)
    AX = 0x10;
    // ADD AL,byte ptr [0xe8] (1000_17AD / 0x117AD)
    // AL += UInt8[DS, 0xE8];
    AL = Alu.Add8(AL, UInt8[DS, 0xE8]);
    // MOV DX,0x96 (1000_17B1 / 0x117B1)
    DX = 0x96;
    // MOV BX,0x89 (1000_17B4 / 0x117B4)
    BX = 0x89;
    // CALL 0x1000:c22f (1000_17B7 / 0x117B7)
    NearCall(cs1, 0x17BA, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_17BA_117BA:
    // POP AX (1000_17BA / 0x117BA)
    AX = Stack.Pop();
    // JMP 0x1000:c13e (1000_17BB / 0x117BB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_17BE_0117BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17BE_117BE:
    // CALL 0x1000:c07c (1000_17BE / 0x117BE)
    NearCall(cs1, 0x17C1, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_17C1_0117C1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_17C1_0117C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17C1_117C1:
    // MOV SI,0x1e6e (1000_17C1 / 0x117C1)
    SI = 0x1E6E;
    // PUSH SI (1000_17C4 / 0x117C4)
    Stack.Push(SI);
    // CMP byte ptr [0xce66],0x0 (1000_17C5 / 0x117C5)
    Alu.Sub8(UInt8[DS, 0xCE66], 0x0);
    // JNZ 0x1000:17d1 (1000_17CA / 0x117CA)
    if(!ZeroFlag) {
      goto label_1000_17D1_117D1;
    }
    // CALL 0x1000:c446 (1000_17CC / 0x117CC)
    NearCall(cs1, 0x17CF, spice86_generated_label_call_target_1000_C446_01C446);
    label_1000_17CF_117CF:
    // JMP 0x1000:17df (1000_17CF / 0x117CF)
    goto label_1000_17DF_117DF;
    label_1000_17D1_117D1:
    // MOV BP,0x1e76 (1000_17D1 / 0x117D1)
    BP = 0x1E76;
    // MOV SI,0xcd9e (1000_17D4 / 0x117D4)
    SI = 0xCD9E;
    // MOV ES,word ptr [0xdbd6] (1000_17D7 / 0x117D7)
    ES = UInt16[DS, 0xDBD6];
    // CALLF [0x391d] (1000_17DB / 0x117DB)
    // Indirect call to [0x391d], generating possible targets from emulator records
    uint targetAddress_1000_17DB = (uint)(UInt16[DS, 0x391F] * 0x10 + UInt16[DS, 0x391D] - cs1 * 0x10);
    switch(targetAddress_1000_17DB) {
      case 0x235FE : FarCall(cs1, 0x17DF, spice86_generated_label_call_target_334B_014E_0335FE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_17DB));
        break;
    }
    label_1000_17DF_117DF:
    // CALL 0x1000:1797 (1000_17DF / 0x117DF)
    NearCall(cs1, 0x17E2, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_17E2_117E2:
    // POP SI (1000_17E2 / 0x117E2)
    SI = Stack.Pop();
    // JMP 0x1000:c4f0 (1000_17E3 / 0x117E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_17E6_0117E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17E6_117E6:
    // CMP byte ptr [0x11c9],0x0 (1000_17E6 / 0x117E6)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:181d (1000_17EB / 0x117EB)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // CMP byte ptr [0xe8],0xa (1000_17ED / 0x117ED)
    Alu.Sub8(UInt8[DS, 0xE8], 0xA);
    // JZ 0x1000:181d (1000_17F2 / 0x117F2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // INC byte ptr [0xe8] (1000_17F4 / 0x117F4)
    UInt8[DS, 0xE8] = Alu.Inc8(UInt8[DS, 0xE8]);
    // CALL 0x1000:17be (1000_17F8 / 0x117F8)
    NearCall(cs1, 0x17FB, spice86_generated_label_call_target_1000_17BE_0117BE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_17FB_0117FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_17FB_0117FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17FB_117FB:
    // MOV AX,0x8 (1000_17FB / 0x117FB)
    AX = 0x8;
    // CALL 0x1000:e387 (1000_17FE / 0x117FE)
    NearCall(cs1, 0x1801, spice86_generated_label_call_target_1000_E387_01E387);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1801_011801, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1801_011801(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1801_11801:
    // JMP 0x1000:17e6 (1000_1801 / 0x11801)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1803_011803(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1803_11803:
    // CMP byte ptr [0x28e7],0x0 (1000_1803 / 0x11803)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    // JNZ 0x1000:181d (1000_1808 / 0x11808)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // CMP byte ptr [0xe8],0x0 (1000_180A / 0x1180A)
    Alu.Sub8(UInt8[DS, 0xE8], 0x0);
    // JZ 0x1000:181d (1000_180F / 0x1180F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // MOV byte ptr [0xce66],0x1 (1000_1811 / 0x11811)
    UInt8[DS, 0xCE66] = 0x1;
    // CALL 0x1000:181e (1000_1816 / 0x11816)
    NearCall(cs1, 0x1819, spice86_generated_label_call_target_1000_181E_01181E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1819_011819, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1819_011819(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1819_11819:
    // DEC byte ptr [0xce66] (1000_1819 / 0x11819)
    UInt8[DS, 0xCE66] = Alu.Dec8(UInt8[DS, 0xCE66]);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_181E_01181E, 0x1181D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
