namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_3D12_013D12(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3D12_13D12:
    // TEST byte ptr [0x47a4],0x81 (1000_3D12 / 0x13D12)
    Alu.And8(UInt8[DS, 0x47A4], 0x81);
    State.IncCycles();
    // JNZ 0x1000:3d2b (1000_3D17 / 0x13D17)
    if(!ZeroFlag) {
      goto label_1000_3D2B_13D2B;
    }
    State.IncCycles();
    // MOV DI,word ptr [0x47f6] (1000_3D19 / 0x13D19)
    DI = UInt16[DS, 0x47F6];
    State.IncCycles();
    // DEC word ptr [0x47f6] (1000_3D1D / 0x13D1D)
    UInt16[DS, 0x47F6]--;
    State.IncCycles();
    // CMP byte ptr [DI],0xff (1000_3D21 / 0x13D21)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    State.IncCycles();
    // JZ 0x1000:3d2b (1000_3D24 / 0x13D24)
    if(ZeroFlag) {
      goto label_1000_3D2B_13D2B;
    }
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_3D26 / 0x13D26)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // CALL 0x1000:3d2f (1000_3D28 / 0x13D28)
    NearCall(cs1, 0x3D2B, spice86_generated_label_call_target_1000_3D2F_013D2F);
    State.IncCycles();
    label_1000_3D2B_13D2B:
    // POP SI (1000_3D2B / 0x13D2B)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:3b80 (1000_3D2C / 0x13D2C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B80_013B80, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3D2F_013D2F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3D2F_13D2F:
    // PUSH word ptr [0x2784] (1000_3D2F / 0x13D2F)
    Stack.Push(UInt16[DS, 0x2784]);
    State.IncCycles();
    // PUSH AX (1000_3D33 / 0x13D33)
    Stack.Push(AX);
    State.IncCycles();
    // XOR AH,AH (1000_3D34 / 0x13D34)
    AH = 0;
    State.IncCycles();
    // MOV DI,AX (1000_3D36 / 0x13D36)
    DI = AX;
    State.IncCycles();
    // SHL DI,1 (1000_3D38 / 0x13D38)
    DI <<= 0x1;
    State.IncCycles();
    // SHL DI,1 (1000_3D3A / 0x13D3A)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV word ptr [DI + 0x47f8],DX (1000_3D3C / 0x13D3C)
    UInt16[DS, (ushort)(DI + 0x47F8)] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x47fa],BX (1000_3D40 / 0x13D40)
    UInt16[DS, (ushort)(DI + 0x47FA)] = BX;
    State.IncCycles();
    // MOV AX,0x26 (1000_3D44 / 0x13D44)
    AX = 0x26;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_3D47 / 0x13D47)
    NearCall(cs1, 0x3D4A, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3D4A_013D4A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3D4A_013D4A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3D4A_13D4A:
    // POP AX (1000_3D4A / 0x13D4A)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV CH,AH (1000_3D4B / 0x13D4B)
    CH = AH;
    State.IncCycles();
    // CMP AL,0xf (1000_3D4D / 0x13D4D)
    Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JC 0x1000:3d58 (1000_3D4F / 0x13D4F)
    if(CarryFlag) {
      goto label_1000_3D58_13D58;
    }
    State.IncCycles();
    // SUB AL,0xf (1000_3D51 / 0x13D51)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // MOV [0x476c],AL (1000_3D53 / 0x13D53)
    UInt8[DS, 0x476C] = AL;
    State.IncCycles();
    // MOV AL,0xf (1000_3D56 / 0x13D56)
    AL = 0xF;
    State.IncCycles();
    label_1000_3D58_13D58:
    // CALL 0x1000:9123 (1000_3D58 / 0x13D58)
    NearCall(cs1, 0x3D5B, spice86_generated_label_call_target_1000_9123_019123);
    State.IncCycles();
    label_1000_3D5B_13D5B:
    // CALL 0x1000:127c (1000_3D5B / 0x13D5B)
    NearCall(cs1, 0x3D5E, spice86_generated_label_call_target_1000_127C_01127C);
    State.IncCycles();
    label_1000_3D5E_13D5E:
    // JNC 0x1000:3d65 (1000_3D5E / 0x13D5E)
    if(!CarryFlag) {
      goto label_1000_3D65_13D65;
    }
    State.IncCycles();
    // MOV AL,0x11 (1000_3D60 / 0x13D60)
    AL = 0x11;
    State.IncCycles();
    // ADD BX,0x35 (1000_3D62 / 0x13D62)
    BX += 0x35;
    State.IncCycles();
    label_1000_3D65_13D65:
    // CMP AL,0xc (1000_3D65 / 0x13D65)
    Alu.Sub8(AL, 0xC);
    State.IncCycles();
    // JNZ 0x1000:3d72 (1000_3D67 / 0x13D67)
    if(!ZeroFlag) {
      goto label_1000_3D72_13D72;
    }
    State.IncCycles();
    // TEST byte ptr [0x10a7],0x10 (1000_3D69 / 0x13D69)
    Alu.And8(UInt8[DS, 0x10A7], 0x10);
    State.IncCycles();
    // JZ 0x1000:3d72 (1000_3D6E / 0x13D6E)
    if(ZeroFlag) {
      goto label_1000_3D72_13D72;
    }
    State.IncCycles();
    // MOV AL,0x12 (1000_3D70 / 0x13D70)
    AL = 0x12;
    State.IncCycles();
    label_1000_3D72_13D72:
    // MOV AH,CH (1000_3D72 / 0x13D72)
    AH = CH;
    State.IncCycles();
    // SHL AL,1 (1000_3D74 / 0x13D74)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // PUSH AX (1000_3D76 / 0x13D76)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_3D77 / 0x13D77)
    NearCall(cs1, 0x3D7A, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3D7A_013D7A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3D7A_013D7A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3D7A_13D7A:
    // POP AX (1000_3D7A / 0x13D7A)
    AX = Stack.Pop();
    State.IncCycles();
    // INC AX (1000_3D7B / 0x13D7B)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // CALL 0x1000:c22f (1000_3D7C / 0x13D7C)
    NearCall(cs1, 0x3D7F, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_3D7F_13D7F:
    // POP AX (1000_3D7F / 0x13D7F)
    AX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c13e (1000_3D80 / 0x13D80)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3D83_013D83(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3D83_13D83:
    // PUSH DS (1000_3D83 / 0x13D83)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_3D84 / 0x13D84)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV AX,0xffff (1000_3D85 / 0x13D85)
    AX = 0xFFFF;
    State.IncCycles();
    // MOV CX,0x17 (1000_3D88 / 0x13D88)
    CX = 0x17;
    State.IncCycles();
    // MOV DI,word ptr [0x47f6] (1000_3D8B / 0x13D8B)
    DI = UInt16[DS, 0x47F6];
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_3D8F / 0x13D8F)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV DI,word ptr [0x47f6] (1000_3D91 / 0x13D91)
    DI = UInt16[DS, 0x47F6];
    State.IncCycles();
    // CMP byte ptr [0x4774],0x0 (1000_3D95 / 0x13D95)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JZ 0x1000:3db0 (1000_3D9A / 0x13D9A)
    if(ZeroFlag) {
      goto label_1000_3DB0_13DB0;
    }
    State.IncCycles();
    // MOV AX,[0x4778] (1000_3D9C / 0x13D9C)
    AX = UInt16[DS, 0x4778];
    State.IncCycles();
    // OR AX,AX (1000_3D9F / 0x13D9F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:3db0 (1000_3DA1 / 0x13DA1)
    if(ZeroFlag) {
      goto label_1000_3DB0_13DB0;
    }
    State.IncCycles();
    // PUSH SI (1000_3DA3 / 0x13DA3)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,AX (1000_3DA4 / 0x13DA4)
    SI = AX;
    State.IncCycles();
    // LODSB CS:SI (1000_3DA6 / 0x13DA6)
    AL = UInt8[cs1, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV CL,AL (1000_3DA8 / 0x13DA8)
    CL = AL;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,CS:SI (1000_3DAA / 0x13DAA)
      UInt8[ES, DI] = UInt8[cs1, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP SI (1000_3DAD / 0x13DAD)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:3de5 (1000_3DAE / 0x13DAE)
    goto label_1000_3DE5_13DE5;
    State.IncCycles();
    label_1000_3DB0_13DB0:
    // MOV DX,word ptr [0x12] (1000_3DB0 / 0x13DB0)
    DX = UInt16[DS, 0x12];
    State.IncCycles();
    // XOR DX,word ptr [0x10] (1000_3DB4 / 0x13DB4)
    // DX ^= UInt16[DS, 0x10];
    DX = Alu.Xor16(DX, UInt16[DS, 0x10]);
    State.IncCycles();
    // MOV CL,byte ptr [SI] (1000_3DB8 / 0x13DB8)
    CL = UInt8[DS, SI];
    State.IncCycles();
    // OR CL,CL (1000_3DBA / 0x13DBA)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JZ 0x1000:3de5 (1000_3DBC / 0x13DBC)
    if(ZeroFlag) {
      goto label_1000_3DE5_13DE5;
    }
    State.IncCycles();
    // MOV CH,byte ptr [0xc5] (1000_3DBE / 0x13DBE)
    CH = UInt8[DS, 0xC5];
    State.IncCycles();
    // AND CH,0xf (1000_3DC2 / 0x13DC2)
    // CH &= 0xF;
    CH = Alu.And8(CH, 0xF);
    State.IncCycles();
    // MOV AX,0xffff (1000_3DC5 / 0x13DC5)
    AX = 0xFFFF;
    State.IncCycles();
    label_1000_3DC8_13DC8:
    // INC AX (1000_3DC8 / 0x13DC8)
    AX++;
    State.IncCycles();
    // SHR DX,1 (1000_3DC9 / 0x13DC9)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    State.IncCycles();
    // JNC 0x1000:3dd0 (1000_3DCB / 0x13DCB)
    if(!CarryFlag) {
      goto label_1000_3DD0_13DD0;
    }
    State.IncCycles();
    // CALL 0x1000:3df4 (1000_3DCD / 0x13DCD)
    NearCall(cs1, 0x3DD0, spice86_generated_label_call_target_1000_3DF4_013DF4);
    State.IncCycles();
    label_1000_3DD0_13DD0:
    // OR DX,DX (1000_3DD0 / 0x13DD0)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNZ 0x1000:3dc8 (1000_3DD2 / 0x13DD2)
    if(!ZeroFlag) {
      goto label_1000_3DC8_13DC8;
    }
    State.IncCycles();
    // MOV DL,byte ptr [0x476a] (1000_3DD4 / 0x13DD4)
    DL = UInt8[DS, 0x476A];
    State.IncCycles();
    // DEC DX (1000_3DD8 / 0x13DD8)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JLE 0x1000:3de5 (1000_3DD9 / 0x13DD9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_3DE5_13DE5;
    }
    State.IncCycles();
    // MOV AX,0xf (1000_3DDB / 0x13DDB)
    AX = 0xF;
    State.IncCycles();
    label_1000_3DDE_13DDE:
    // INC AX (1000_3DDE / 0x13DDE)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // CALL 0x1000:3df4 (1000_3DDF / 0x13DDF)
    NearCall(cs1, 0x3DE2, spice86_generated_label_call_target_1000_3DF4_013DF4);
    State.IncCycles();
    // DEC DX (1000_3DE2 / 0x13DE2)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x1000:3dde (1000_3DE3 / 0x13DE3)
    if(!ZeroFlag) {
      goto label_1000_3DDE_13DDE;
    }
    State.IncCycles();
    label_1000_3DE5_13DE5:
    // LODSB SI (1000_3DE5 / 0x13DE5)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_3DE6 / 0x13DE6)
    AH = 0;
    State.IncCycles();
    // MOV DI,word ptr [0x47f6] (1000_3DE8 / 0x13DE8)
    DI = UInt16[DS, 0x47F6];
    State.IncCycles();
    // DEC AX (1000_3DEC / 0x13DEC)
    AX--;
    State.IncCycles();
    // ADD DI,AX (1000_3DED / 0x13DED)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV word ptr [0x47f6],DI (1000_3DEF / 0x13DEF)
    UInt16[DS, 0x47F6] = DI;
    State.IncCycles();
    // RET  (1000_3DF3 / 0x13DF3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3DF4_013DF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3DF4_13DF4:
    // MOV BX,AX (1000_3DF4 / 0x13DF4)
    BX = AX;
    State.IncCycles();
    // ADD BL,CH (1000_3DF6 / 0x13DF6)
    BL += CH;
    State.IncCycles();
    label_1000_3DF8_13DF8:
    // SUB BL,CL (1000_3DF8 / 0x13DF8)
    // BL -= CL;
    BL = Alu.Sub8(BL, CL);
    State.IncCycles();
    // JNC 0x1000:3df8 (1000_3DFA / 0x13DFA)
    if(!CarryFlag) {
      goto label_1000_3DF8_13DF8;
    }
    State.IncCycles();
    // ADD BL,CL (1000_3DFC / 0x13DFC)
    BL += CL;
    State.IncCycles();
    // CMP byte ptr [BX + DI],0xff (1000_3DFE / 0x13DFE)
    Alu.Sub8(UInt8[DS, (ushort)(BX + DI)], 0xFF);
    State.IncCycles();
    // JZ 0x1000:3e10 (1000_3E01 / 0x13E01)
    if(ZeroFlag) {
      goto label_1000_3E10_13E10;
    }
    State.IncCycles();
    // MOV BX,0xffff (1000_3E03 / 0x13E03)
    BX = 0xFFFF;
    State.IncCycles();
    label_1000_3E06_13E06:
    // INC BX (1000_3E06 / 0x13E06)
    BX++;
    State.IncCycles();
    // CMP BL,CL (1000_3E07 / 0x13E07)
    Alu.Sub8(BL, CL);
    State.IncCycles();
    // JNC 0x1000:3e12 (1000_3E09 / 0x13E09)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3E12 / 0x13E12)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [BX + DI],0xff (1000_3E0B / 0x13E0B)
    Alu.Sub8(UInt8[DS, (ushort)(BX + DI)], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:3e06 (1000_3E0E / 0x13E0E)
    if(!ZeroFlag) {
      goto label_1000_3E06_13E06;
    }
    State.IncCycles();
    label_1000_3E10_13E10:
    // MOV byte ptr [BX + DI],AL (1000_3E10 / 0x13E10)
    UInt8[DS, (ushort)(BX + DI)] = AL;
    State.IncCycles();
    label_1000_3E12_13E12:
    // RET  (1000_3E12 / 0x13E12)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3E13_013E13(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3E13_13E13:
    // PUSH BX (1000_3E13 / 0x13E13)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_3E14 / 0x13E14)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_3E15 / 0x13E15)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_3E16 / 0x13E16)
    Stack.Push(DI);
    State.IncCycles();
    // MOV word ptr [0x47e8],DX (1000_3E17 / 0x13E17)
    UInt16[DS, 0x47E8] = DX;
    State.IncCycles();
    // MOV word ptr [0x47ea],BX (1000_3E1B / 0x13E1B)
    UInt16[DS, 0x47EA] = BX;
    State.IncCycles();
    // SUB BX,CX (1000_3E1F / 0x13E1F)
    BX -= CX;
    State.IncCycles();
    // SUB DX,DI (1000_3E21 / 0x13E21)
    DX -= DI;
    State.IncCycles();
    // NEG BX (1000_3E23 / 0x13E23)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // NEG DX (1000_3E25 / 0x13E25)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // CALL 0x1000:3e80 (1000_3E27 / 0x13E27)
    NearCall(cs1, 0x3E2A, spice86_generated_label_call_target_1000_3E80_013E80);
    State.IncCycles();
    label_1000_3E2A_13E2A:
    // POP DI (1000_3E2A / 0x13E2A)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_3E2B / 0x13E2B)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_3E2C / 0x13E2C)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3E2D / 0x13E2D)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3E2E / 0x13E2E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3E80_013E80(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3E2F: break; // Instructions before entry targeted by 0x13E84
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_3E2F_13E2F:
    // MOV BX,word ptr [0x47ea] (1000_3E2F / 0x13E2F)
    BX = UInt16[DS, 0x47EA];
    State.IncCycles();
    // MOV CX,DX (1000_3E33 / 0x13E33)
    CX = DX;
    State.IncCycles();
    // MOV DX,word ptr [0x47e8] (1000_3E35 / 0x13E35)
    DX = UInt16[DS, 0x47E8];
    State.IncCycles();
    // ADD word ptr [0x47e8],CX (1000_3E39 / 0x13E39)
    // UInt16[DS, 0x47E8] += CX;
    UInt16[DS, 0x47E8] = Alu.Add16(UInt16[DS, 0x47E8], CX);
    State.IncCycles();
    // JNC 0x1000:3e41 (1000_3E3D / 0x13E3D)
    if(!CarryFlag) {
      goto label_1000_3E41_13E41;
    }
    State.IncCycles();
    // ADD DX,CX (1000_3E3F / 0x13E3F)
    // DX += CX;
    DX = Alu.Add16(DX, CX);
    State.IncCycles();
    label_1000_3E41_13E41:
    // MOV DI,word ptr [0x22d9] (1000_3E41 / 0x13E41)
    DI = UInt16[DS, 0x22D9];
    State.IncCycles();
    // MOV AX,DX (1000_3E45 / 0x13E45)
    AX = DX;
    State.IncCycles();
    // STOSW ES:DI (1000_3E47 / 0x13E47)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0x2 (1000_3E48 / 0x13E48)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // MOV word ptr [0x22d9],DI (1000_3E4B / 0x13E4B)
    UInt16[DS, 0x22D9] = DI;
    State.IncCycles();
    // POP SI (1000_3E4F / 0x13E4F)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_3E50 / 0x13E50)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3E51 / 0x13E51)
    return NearRet();
    State.IncCycles();
    label_1000_3E52_13E52:
    // MOV CX,BX (1000_3E52 / 0x13E52)
    CX = BX;
    State.IncCycles();
    // MOV BX,word ptr [0x47ea] (1000_3E54 / 0x13E54)
    BX = UInt16[DS, 0x47EA];
    State.IncCycles();
    // MOV DX,word ptr [0x47e8] (1000_3E58 / 0x13E58)
    DX = UInt16[DS, 0x47E8];
    State.IncCycles();
    // OR AX,AX (1000_3E5C / 0x13E5C)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x1000:3e68 (1000_3E5E / 0x13E5E)
    if(!SignFlag) {
      goto label_1000_3E68_13E68;
    }
    State.IncCycles();
    // SUB word ptr [0x47ea],CX (1000_3E60 / 0x13E60)
    UInt16[DS, 0x47EA] -= CX;
    State.IncCycles();
    // SUB BX,CX (1000_3E64 / 0x13E64)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    State.IncCycles();
    // JMP 0x1000:3e6c (1000_3E66 / 0x13E66)
    goto label_1000_3E6C_13E6C;
    State.IncCycles();
    label_1000_3E68_13E68:
    // ADD word ptr [0x47ea],CX (1000_3E68 / 0x13E68)
    UInt16[DS, 0x47EA] += CX;
    State.IncCycles();
    label_1000_3E6C_13E6C:
    // INC CX (1000_3E6C / 0x13E6C)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // MOV DI,word ptr [0x22d9] (1000_3E6D / 0x13E6D)
    DI = UInt16[DS, 0x22D9];
    State.IncCycles();
    // MOV AX,DX (1000_3E71 / 0x13E71)
    AX = DX;
    State.IncCycles();
    label_1000_3E73_13E73:
    // STOSW ES:DI (1000_3E73 / 0x13E73)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0x2 (1000_3E74 / 0x13E74)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x1000:3e73 (1000_3E77 / 0x13E77)
    if(--CX != 0) {
      goto label_1000_3E73_13E73;
    }
    State.IncCycles();
    // MOV word ptr [0x22d9],DI (1000_3E79 / 0x13E79)
    UInt16[DS, 0x22D9] = DI;
    State.IncCycles();
    // POP SI (1000_3E7D / 0x13E7D)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_3E7E / 0x13E7E)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3E7F / 0x13E7F)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_3E80_13E80:
    // PUSH DI (1000_3E80 / 0x13E80)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH SI (1000_3E81 / 0x13E81)
    Stack.Push(SI);
    State.IncCycles();
    // OR BX,BX (1000_3E82 / 0x13E82)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:3e2f (1000_3E84 / 0x13E84)
    if(ZeroFlag) {
      goto label_1000_3E2F_13E2F;
    }
    State.IncCycles();
    // MOV AX,0x1 (1000_3E86 / 0x13E86)
    AX = 0x1;
    State.IncCycles();
    // JNS 0x1000:3e8f (1000_3E89 / 0x13E89)
    if(!SignFlag) {
      goto label_1000_3E8F_13E8F;
    }
    State.IncCycles();
    // NEG BX (1000_3E8B / 0x13E8B)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // NEG AX (1000_3E8D / 0x13E8D)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_3E8F_13E8F:
    // OR DX,DX (1000_3E8F / 0x13E8F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:3e52 (1000_3E91 / 0x13E91)
    if(ZeroFlag) {
      goto label_1000_3E52_13E52;
    }
    State.IncCycles();
    // MOV CX,0x1 (1000_3E93 / 0x13E93)
    CX = 0x1;
    State.IncCycles();
    // JNS 0x1000:3e9c (1000_3E96 / 0x13E96)
    if(!SignFlag) {
      goto label_1000_3E9C_13E9C;
    }
    State.IncCycles();
    // NEG CX (1000_3E98 / 0x13E98)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // NEG DX (1000_3E9A / 0x13E9A)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_1000_3E9C_13E9C:
    // PUSH AX (1000_3E9C / 0x13E9C)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (1000_3E9D / 0x13E9D)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH AX (1000_3E9E / 0x13E9E)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (1000_3E9F / 0x13E9F)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BP,SP (1000_3EA0 / 0x13EA0)
    BP = SP;
    State.IncCycles();
    // MOV SI,BX (1000_3EA2 / 0x13EA2)
    SI = BX;
    State.IncCycles();
    // MOV DI,DX (1000_3EA4 / 0x13EA4)
    DI = DX;
    State.IncCycles();
    // XOR AX,AX (1000_3EA6 / 0x13EA6)
    AX = 0;
    State.IncCycles();
    // CMP DX,BX (1000_3EA8 / 0x13EA8)
    Alu.Sub16(DX, BX);
    State.IncCycles();
    // JBE 0x1000:3eb1 (1000_3EAA / 0x13EAA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_3EB1_13EB1;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_3EAC / 0x13EAC)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // JMP 0x1000:3eba (1000_3EAF / 0x13EAF)
    goto label_1000_3EBA_13EBA;
    State.IncCycles();
    label_1000_3EB1_13EB1:
    // OR BX,BX (1000_3EB1 / 0x13EB1)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:3ef8 (1000_3EB3 / 0x13EB3)
    if(ZeroFlag) {
      goto label_1000_3EF8_13EF8;
    }
    State.IncCycles();
    // XCHG SI,DI (1000_3EB5 / 0x13EB5)
    ushort tmp_1000_3EB5 = SI;
    SI = DI;
    DI = tmp_1000_3EB5;
    State.IncCycles();
    // MOV word ptr [BP + 0x0],AX (1000_3EB7 / 0x13EB7)
    UInt16[SS, BP] = AX;
    State.IncCycles();
    label_1000_3EBA_13EBA:
    // MOV AX,DI (1000_3EBA / 0x13EBA)
    AX = DI;
    State.IncCycles();
    // MOV CX,DI (1000_3EBC / 0x13EBC)
    CX = DI;
    State.IncCycles();
    // SHR AX,1 (1000_3EBE / 0x13EBE)
    AX >>= 0x1;
    State.IncCycles();
    label_1000_3EC0_13EC0:
    // ADD AX,SI (1000_3EC0 / 0x13EC0)
    AX += SI;
    State.IncCycles();
    // CMP AX,DI (1000_3EC2 / 0x13EC2)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JC 0x1000:3ed0 (1000_3EC4 / 0x13EC4)
    if(CarryFlag) {
      goto label_1000_3ED0_13ED0;
    }
    State.IncCycles();
    // SUB AX,DI (1000_3EC6 / 0x13EC6)
    // AX -= DI;
    AX = Alu.Sub16(AX, DI);
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x4] (1000_3EC8 / 0x13EC8)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (1000_3ECB / 0x13ECB)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // JMP 0x1000:3ed6 (1000_3ECE / 0x13ECE)
    goto label_1000_3ED6_13ED6;
    State.IncCycles();
    label_1000_3ED0_13ED0:
    // MOV DX,word ptr [BP + 0x0] (1000_3ED0 / 0x13ED0)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (1000_3ED3 / 0x13ED3)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    label_1000_3ED6_13ED6:
    // ADD DX,word ptr [0x47e8] (1000_3ED6 / 0x13ED6)
    DX += UInt16[DS, 0x47E8];
    State.IncCycles();
    // CMP BX,0x1 (1000_3EDA / 0x13EDA)
    Alu.Sub16(BX, 0x1);
    State.IncCycles();
    // JNZ 0x1000:3ef2 (1000_3EDD / 0x13EDD)
    if(!ZeroFlag) {
      goto label_1000_3EF2_13EF2;
    }
    State.IncCycles();
    // PUSH DI (1000_3EDF / 0x13EDF)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH AX (1000_3EE0 / 0x13EE0)
    Stack.Push(AX);
    State.IncCycles();
    // MOV DI,word ptr [0x22d9] (1000_3EE1 / 0x13EE1)
    DI = UInt16[DS, 0x22D9];
    State.IncCycles();
    // MOV AX,[0x47e8] (1000_3EE5 / 0x13EE5)
    AX = UInt16[DS, 0x47E8];
    State.IncCycles();
    // STOSW ES:DI (1000_3EE8 / 0x13EE8)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0x2 (1000_3EE9 / 0x13EE9)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // MOV word ptr [0x22d9],DI (1000_3EEC / 0x13EEC)
    UInt16[DS, 0x22D9] = DI;
    State.IncCycles();
    // POP AX (1000_3EF0 / 0x13EF0)
    AX = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_3EF1 / 0x13EF1)
    DI = Stack.Pop();
    State.IncCycles();
    label_1000_3EF2_13EF2:
    // MOV word ptr [0x47e8],DX (1000_3EF2 / 0x13EF2)
    UInt16[DS, 0x47E8] = DX;
    State.IncCycles();
    // LOOP 0x1000:3ec0 (1000_3EF6 / 0x13EF6)
    if(--CX != 0) {
      goto label_1000_3EC0_13EC0;
    }
    State.IncCycles();
    label_1000_3EF8_13EF8:
    // ADD SP,0x8 (1000_3EF8 / 0x13EF8)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    State.IncCycles();
    // POP SI (1000_3EFB / 0x13EFB)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_3EFC / 0x13EFC)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3EFD / 0x13EFD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3EFE_013EFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3EFE_13EFE:
    // MOV AL,DH (1000_3EFE / 0x13EFE)
    AL = DH;
    State.IncCycles();
    // XOR AH,AH (1000_3F00 / 0x13F00)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_3F02 / 0x13F02)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV SI,AX (1000_3F04 / 0x13F04)
    SI = AX;
    State.IncCycles();
    // MOV SI,word ptr [SI + 0x13c4] (1000_3F06 / 0x13F06)
    SI = UInt16[DS, (ushort)(SI + 0x13C4)];
    State.IncCycles();
    // MOV AL,DL (1000_3F0A / 0x13F0A)
    AL = DL;
    State.IncCycles();
    // DEC AL (1000_3F0C / 0x13F0C)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // MOV AH,0x5 (1000_3F0E / 0x13F0E)
    AH = 0x5;
    State.IncCycles();
    // MUL AH (1000_3F10 / 0x13F10)
    Cpu.Mul8(AH);
    State.IncCycles();
    // ADD SI,AX (1000_3F12 / 0x13F12)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_3F14_013F14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_3F14_013F14(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3F14_13F14:
    // RET  (1000_3F14 / 0x13F14)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3F15_013F15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3F15_13F15:
    // MOV BP,0x1 (1000_3F15 / 0x13F15)
    BP = 0x1;
    State.IncCycles();
    // JMP 0x1000:3f27 (1000_3F18 / 0x13F18)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3F27_013F27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3F1A_013F1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3F1A_13F1A:
    // MOV BP,0x2 (1000_3F1A / 0x13F1A)
    BP = 0x2;
    State.IncCycles();
    // JMP 0x1000:3f27 (1000_3F1D / 0x13F1D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3F27_013F27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3F1F_013F1F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3F1F_13F1F:
    // MOV BP,0x3 (1000_3F1F / 0x13F1F)
    BP = 0x3;
    State.IncCycles();
    // JMP 0x1000:3f27 (1000_3F22 / 0x13F22)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3F27_013F27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3F24_013F24(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3F24_13F24:
    // MOV BP,0x4 (1000_3F24 / 0x13F24)
    BP = 0x4;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3F27_013F27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3F27_013F27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3F27_13F27:
    // PUSH BP (1000_3F27 / 0x13F27)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:d2bd (1000_3F28 / 0x13F28)
    NearCall(cs1, 0x3F2B, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3F2B_013F2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3F2B_013F2B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4002: goto label_1000_4002_14002;break; // Target of external jump from 0x14FF8
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_3F2B_13F2B:
    // CALL 0x1000:ac30 (1000_3F2B / 0x13F2B)
    NearCall(cs1, 0x3F2E, spice86_generated_label_call_target_1000_AC30_01AC30);
    State.IncCycles();
    label_1000_3F2E_13F2E:
    // CALL 0x1000:a7a5 (1000_3F2E / 0x13F2E)
    NearCall(cs1, 0x3F31, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    State.IncCycles();
    label_1000_3F31_13F31:
    // POP BP (1000_3F31 / 0x13F31)
    BP = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x47a9],0x0 (1000_3F32 / 0x13F32)
    UInt8[DS, 0x47A9] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x26],0x0 (1000_3F37 / 0x13F37)
    UInt8[DS, 0x26] = 0x0;
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_3F3C / 0x13F3C)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_3F40 / 0x13F40)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP BL,0x80 (1000_3F44 / 0x13F44)
    Alu.Sub8(BL, 0x80);
    State.IncCycles();
    // JZ 0x1000:3f67 (1000_3F47 / 0x13F47)
    if(ZeroFlag) {
      goto label_1000_3F67_13F67;
    }
    State.IncCycles();
    // MOV AL,[0x4735] (1000_3F49 / 0x13F49)
    AL = UInt8[DS, 0x4735];
    State.IncCycles();
    // AND AL,0x7f (1000_3F4C / 0x13F4C)
    AL &= 0x7F;
    State.IncCycles();
    // INC AL (1000_3F4E / 0x13F4E)
    AL = Alu.Inc8(AL);
    State.IncCycles();
    // JNS 0x1000:3f54 (1000_3F50 / 0x13F50)
    if(!SignFlag) {
      goto label_1000_3F54_13F54;
    }
    State.IncCycles();
    // DEC AL (1000_3F52 / 0x13F52)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    label_1000_3F54_13F54:
    // OR AL,0x80 (1000_3F54 / 0x13F54)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    State.IncCycles();
    // MOV [0x4735],AL (1000_3F56 / 0x13F56)
    UInt8[DS, 0x4735] = AL;
    State.IncCycles();
    // CMP byte ptr [0xf4],0x14 (1000_3F59 / 0x13F59)
    Alu.Sub8(UInt8[DS, 0xF4], 0x14);
    State.IncCycles();
    // JNC 0x1000:3f64 (1000_3F5E / 0x13F5E)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:3ff5 (1000_3F64 / 0x13F64)
      goto label_1000_3FF5_13FF5;
    }
    State.IncCycles();
    // INC byte ptr [0xf4] (1000_3F60 / 0x13F60)
    UInt8[DS, 0xF4] = Alu.Inc8(UInt8[DS, 0xF4]);
    State.IncCycles();
    label_1000_3F64_13F64:
    // JMP 0x1000:3ff5 (1000_3F64 / 0x13F64)
    goto label_1000_3FF5_13FF5;
    State.IncCycles();
    label_1000_3F67_13F67:
    // CALL 0x1000:3efe (1000_3F67 / 0x13F67)
    NearCall(cs1, 0x3F6A, spice86_generated_label_call_target_1000_3EFE_013EFE);
    State.IncCycles();
    label_1000_3F6A_13F6A:
    // MOV DL,byte ptr [BP + SI] (1000_3F6A / 0x13F6A)
    DL = UInt8[SS, (ushort)(BP + SI)];
    State.IncCycles();
    // OR DL,DL (1000_3F6C / 0x13F6C)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x1000:3f14 (1000_3F6E / 0x13F6E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3F14 / 0x13F14)
      return NearRet();
    }
    State.IncCycles();
    // JS 0x1000:3fd2 (1000_3F70 / 0x13F70)
    if(SignFlag) {
      goto label_1000_3FD2_13FD2;
    }
    State.IncCycles();
    // CMP byte ptr [0xb],0x1 (1000_3F72 / 0x13F72)
    Alu.Sub8(UInt8[DS, 0xB], 0x1);
    State.IncCycles();
    // JNZ 0x1000:3f84 (1000_3F77 / 0x13F77)
    if(!ZeroFlag) {
      goto label_1000_3F84_13F84;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_3F79 / 0x13F79)
    NearCall(cs1, 0x3F7C, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_3F7C_13F7C:
    // MOV CL,0x2 (1000_3F7C / 0x13F7C)
    CL = 0x2;
    State.IncCycles();
    // CALL 0x1000:b389 (1000_3F7E / 0x13F7E)
    NearCall(cs1, 0x3F81, spice86_generated_label_call_target_1000_B389_01B389);
    State.IncCycles();
    label_1000_3F81_13F81:
    // CALL 0x1000:e283 (1000_3F81 / 0x13F81)
    NearCall(cs1, 0x3F84, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_3F84_13F84:
    // MOV SI,word ptr [0x114e] (1000_3F84 / 0x13F84)
    SI = UInt16[DS, 0x114E];
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x10 (1000_3F88 / 0x13F88)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x10);
    State.IncCycles();
    // JNZ 0x1000:3faa (1000_3F8C / 0x13F8C)
    if(!ZeroFlag) {
      goto label_1000_3FAA_13FAA;
    }
    State.IncCycles();
    // OR byte ptr [SI + 0xa],0x10 (1000_3F8E / 0x13F8E)
    UInt8[DS, (ushort)(SI + 0xA)] |= 0x10;
    State.IncCycles();
    // CMP DH,0x20 (1000_3F92 / 0x13F92)
    Alu.Sub8(DH, 0x20);
    State.IncCycles();
    // ADC byte ptr [0x25],0x0 (1000_3F95 / 0x13F95)
    UInt8[DS, 0x25] = Alu.Adc8(UInt8[DS, 0x25], 0x0);
    State.IncCycles();
    // MOV byte ptr [0x26],0xff (1000_3F9A / 0x13F9A)
    UInt8[DS, 0x26] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:e270 (1000_3F9F / 0x13F9F)
    NearCall(cs1, 0x3FA2, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_3FA2_13FA2:
    // MOV CL,0x3 (1000_3FA2 / 0x13FA2)
    CL = 0x3;
    State.IncCycles();
    // CALL 0x1000:b389 (1000_3FA4 / 0x13FA4)
    NearCall(cs1, 0x3FA7, spice86_generated_label_call_target_1000_B389_01B389);
    State.IncCycles();
    label_1000_3FA7_13FA7:
    // CALL 0x1000:e283 (1000_3FA7 / 0x13FA7)
    NearCall(cs1, 0x3FAA, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_3FAA_13FAA:
    // MOV byte ptr [0xc],DL (1000_3FAA / 0x13FAA)
    UInt8[DS, 0xC] = DL;
    State.IncCycles();
    // MOV byte ptr [0x23],0x1 (1000_3FAE / 0x13FAE)
    UInt8[DS, 0x23] = 0x1;
    State.IncCycles();
    // CALL 0x1000:a1c4 (1000_3FB3 / 0x13FB3)
    NearCall(cs1, 0x3FB6, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    State.IncCycles();
    label_1000_3FB6_13FB6:
    // PUSH BX (1000_3FB6 / 0x13FB6)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_3FB7 / 0x13FB7)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:36d3 (1000_3FB8 / 0x13FB8)
    NearCall(cs1, 0x3FBB, spice86_generated_label_call_target_1000_36D3_0136D3);
    State.IncCycles();
    label_1000_3FBB_13FBB:
    // POP DX (1000_3FBB / 0x13FBB)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3FBC / 0x13FBC)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:a1e2 (1000_3FBD / 0x13FBD)
    NearCall(cs1, 0x3FC0, spice86_generated_label_call_target_1000_A1E2_01A1E2);
    State.IncCycles();
    label_1000_3FC0_13FC0:
    // JZ 0x1000:3fc3 (1000_3FC0 / 0x13FC0)
    if(ZeroFlag) {
      goto label_1000_3FC3_13FC3;
    }
    State.IncCycles();
    // RET  (1000_3FC2 / 0x13FC2)
    return NearRet();
    State.IncCycles();
    label_1000_3FC3_13FC3:
    // PUSH BX (1000_3FC3 / 0x13FC3)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_3FC4 / 0x13FC4)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:abd5 (1000_3FC5 / 0x13FC5)
    NearCall(cs1, 0x3FC8, spice86_generated_label_call_target_1000_ABD5_01ABD5);
    State.IncCycles();
    label_1000_3FC8_13FC8:
    // POP DX (1000_3FC8 / 0x13FC8)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3FC9 / 0x13FC9)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x23],0x5 (1000_3FCA / 0x13FCA)
    UInt8[DS, 0x23] = 0x5;
    State.IncCycles();
    // JMP 0x1000:4057 (1000_3FCF / 0x13FCF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_3FD2_13FD2:
    // MOV byte ptr [0xe7],0x0 (1000_3FD2 / 0x13FD2)
    UInt8[DS, 0xE7] = 0x0;
    State.IncCycles();
    // XOR DH,DH (1000_3FD7 / 0x13FD7)
    DH = 0;
    State.IncCycles();
    // NEG DL (1000_3FD9 / 0x13FD9)
    DL = Alu.Sub8(0, DL);
    State.IncCycles();
    // MOV BP,DX (1000_3FDB / 0x13FDB)
    BP = DX;
    State.IncCycles();
    // XOR SI,SI (1000_3FDD / 0x13FDD)
    SI = 0;
    State.IncCycles();
    // XCHG word ptr [0x114e],SI (1000_3FDF / 0x13FDF)
    ushort tmp_1000_3FDF = UInt16[DS, 0x114E];
    UInt16[DS, 0x114E] = SI;
    SI = tmp_1000_3FDF;
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x2] (1000_3FE3 / 0x13FE3)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x4] (1000_3FE6 / 0x13FE6)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // XOR BH,BH (1000_3FE9 / 0x13FE9)
    BH = 0;
    State.IncCycles();
    // MOV byte ptr [0x8],0xff (1000_3FEB / 0x13FEB)
    UInt8[DS, 0x8] = 0xFF;
    State.IncCycles();
    // MOV byte ptr [0x9],0xff (1000_3FF0 / 0x13FF0)
    UInt8[DS, 0x9] = 0xFF;
    State.IncCycles();
    label_1000_3FF5_13FF5:
    // SHL BP,1 (1000_3FF5 / 0x13FF5)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x1454] (1000_3FF7 / 0x13FF7)
    AX = UInt16[SS, (ushort)(BP + 0x1454)];
    State.IncCycles();
    // CALL 0x1000:b5cf (1000_3FFB / 0x13FFB)
    NearCall(cs1, 0x3FFE, spice86_generated_label_call_target_1000_B5CF_01B5CF);
    State.IncCycles();
    label_1000_3FFE_13FFE:
    // OR BH,BH (1000_3FFE / 0x13FFE)
    // BH |= BH;
    BH = Alu.Or8(BH, BH);
    State.IncCycles();
    // JNZ 0x1000:4057 (1000_4000 / 0x14000)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_4002_14002:
    // MOV AX,BX (1000_4002 / 0x14002)
    AX = BX;
    State.IncCycles();
    // CBW  (1000_4004 / 0x14004)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV BX,AX (1000_4005 / 0x14005)
    BX = AX;
    State.IncCycles();
    // CALL 0x1000:b532 (1000_4007 / 0x14007)
    NearCall(cs1, 0x400A, spice86_generated_label_call_target_1000_B532_01B532);
    State.IncCycles();
    label_1000_400A_1400A:
    // XOR BH,BH (1000_400A / 0x1400A)
    BH = 0;
    State.IncCycles();
    // TEST AL,0x40 (1000_400C / 0x1400C)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:4057 (1000_400E / 0x1400E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:409a (1000_4010 / 0x14010)
    NearCall(cs1, 0x4013, spice86_generated_label_call_target_1000_409A_01409A);
    State.IncCycles();
    label_1000_4013_14013:
    // JNZ 0x1000:4057 (1000_4013 / 0x14013)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI + 0x2] (1000_4015 / 0x14015)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:4057 (1000_4018 / 0x14018)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,BX (1000_401A / 0x1401A)
    AX = BX;
    State.IncCycles();
    // CBW  (1000_401C / 0x1401C)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV BX,AX (1000_401D / 0x1401D)
    BX = AX;
    State.IncCycles();
    // MOV byte ptr [0x4735],0x0 (1000_401F / 0x1401F)
    UInt8[DS, 0x4735] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x114e],SI (1000_4024 / 0x14024)
    UInt16[DS, 0x114E] = SI;
    State.IncCycles();
    // MOV word ptr [0x1150],SI (1000_4028 / 0x14028)
    UInt16[DS, 0x1150] = SI;
    State.IncCycles();
    // MOV DI,SI (1000_402C / 0x1402C)
    DI = SI;
    State.IncCycles();
    // CALL 0x1000:503c (1000_402E / 0x1402E)
    NearCall(cs1, 0x4031, spice86_generated_label_call_target_1000_503C_01503C);
    State.IncCycles();
    label_1000_4031_14031:
    // MOV word ptr [0x9a],0x0 (1000_4031 / 0x14031)
    UInt16[DS, 0x9A] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x98],0x0 (1000_4037 / 0x14037)
    UInt16[DS, 0x98] = 0x0;
    State.IncCycles();
    // CALL 0x1000:425b (1000_403D / 0x1403D)
    NearCall(cs1, 0x4040, spice86_generated_label_call_target_1000_425B_01425B);
    State.IncCycles();
    label_1000_4040_14040:
    // CALL 0x1000:40ae (1000_4040 / 0x14040)
    NearCall(cs1, 0x4043, spice86_generated_label_call_target_1000_40AE_0140AE);
    State.IncCycles();
    label_1000_4043_14043:
    // MOV byte ptr [0x8],DH (1000_4043 / 0x14043)
    UInt8[DS, 0x8] = DH;
    State.IncCycles();
    // MOV byte ptr [0x9],BH (1000_4047 / 0x14047)
    UInt8[DS, 0x9] = BH;
    State.IncCycles();
    // CMP DH,0x20 (1000_404B / 0x1404B)
    Alu.Sub8(DH, 0x20);
    State.IncCycles();
    // JC 0x1000:4054 (1000_404E / 0x1404E)
    if(CarryFlag) {
      goto label_1000_4054_14054;
    }
    State.IncCycles();
    // OR byte ptr [SI + 0xa],0x10 (1000_4050 / 0x14050)
    // UInt8[DS, (ushort)(SI + 0xA)] |= 0x10;
    UInt8[DS, (ushort)(SI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0xA)], 0x10);
    State.IncCycles();
    label_1000_4054_14054:
    // CALL 0x1000:2170 (1000_4054 / 0x14054)
    NearCall(cs1, 0x4057, spice86_generated_label_call_target_1000_2170_012170);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4057_014057(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4057_14057:
    // CALL 0x1000:40c3 (1000_4057 / 0x14057)
    NearCall(cs1, 0x405A, spice86_generated_label_call_target_1000_40C3_0140C3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_405A_01405A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_405A_01405A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_405A_1405A:
    // MOV word ptr [0x4],DX (1000_405A / 0x1405A)
    UInt16[DS, 0x4] = DX;
    State.IncCycles();
    // MOV AL,DL (1000_405E / 0x1405E)
    AL = DL;
    State.IncCycles();
    // XCHG byte ptr [0xb],AL (1000_4060 / 0x14060)
    byte tmp_1000_4060 = UInt8[DS, 0xB];
    UInt8[DS, 0xB] = AL;
    AL = tmp_1000_4060;
    State.IncCycles();
    // MOV [0xd],AL (1000_4064 / 0x14064)
    UInt8[DS, 0xD] = AL;
    State.IncCycles();
    // MOV word ptr [0x6],BX (1000_4067 / 0x14067)
    UInt16[DS, 0x6] = BX;
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_406B / 0x1406B)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:4099 (1000_4070 / 0x14070)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4099 / 0x14099)
      return NearRet();
    }
    State.IncCycles();
    // CMP DX,0x3002 (1000_4072 / 0x14072)
    Alu.Sub16(DX, 0x3002);
    State.IncCycles();
    // JNZ 0x1000:407b (1000_4076 / 0x14076)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:2dbf (1000_407B / 0x1407B)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2DBF_012DBF, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:16fc (1000_4078 / 0x14078)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_16FC_0116FC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_407B_1407B:
    // JMP 0x1000:2dbf (1000_407B / 0x1407B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2DBF_012DBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_407E_01407E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_407E_1407E:
    // MOV DX,word ptr [0x4] (1000_407E / 0x1407E)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_4082 / 0x14082)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP BL,0x80 (1000_4086 / 0x14086)
    Alu.Sub8(BL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:4096 (1000_4089 / 0x14089)
    if(!ZeroFlag) {
      goto label_1000_4096_14096;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x114e] (1000_408B / 0x1408B)
    SI = UInt16[DS, 0x114E];
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x2] (1000_408F / 0x1408F)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x4] (1000_4092 / 0x14092)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // RET  (1000_4095 / 0x14095)
    return NearRet();
    State.IncCycles();
    label_1000_4096_14096:
    // XCHG AX,BX (1000_4096 / 0x14096)
    ushort tmp_1000_4096 = AX;
    AX = BX;
    BX = tmp_1000_4096;
    State.IncCycles();
    // CBW  (1000_4097 / 0x14097)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // XCHG AX,BX (1000_4098 / 0x14098)
    ushort tmp_1000_4098 = AX;
    AX = BX;
    BX = tmp_1000_4098;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4099_014099, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4099_014099(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4099_14099:
    // RET  (1000_4099 / 0x14099)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_409A_01409A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_409A_1409A:
    // MOV SI,0xe4 (1000_409A / 0x1409A)
    SI = 0xE4;
    State.IncCycles();
    label_1000_409D_1409D:
    // ADD SI,0x1c (1000_409D / 0x1409D)
    SI += 0x1C;
    State.IncCycles();
    // CMP word ptr [SI],-0x1 (1000_40A0 / 0x140A0)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:40ab (1000_40A3 / 0x140A3)
    if(ZeroFlag) {
      goto label_1000_40AB_140AB;
    }
    State.IncCycles();
    // CMP DI,word ptr [SI + 0x6] (1000_40A5 / 0x140A5)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JNZ 0x1000:409d (1000_40A8 / 0x140A8)
    if(!ZeroFlag) {
      goto label_1000_409D_1409D;
    }
    State.IncCycles();
    // RET  (1000_40AA / 0x140AA)
    return NearRet();
    State.IncCycles();
    label_1000_40AB_140AB:
    // OR SI,SI (1000_40AB / 0x140AB)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // RET  (1000_40AD / 0x140AD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40AE_0140AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40AE_140AE:
    // MOV AX,DI (1000_40AE / 0x140AE)
    AX = DI;
    State.IncCycles();
    // SUB AX,0x100 (1000_40B0 / 0x140B0)
    // AX -= 0x100;
    AX = Alu.Sub16(AX, 0x100);
    State.IncCycles();
    // MOV BL,0x1c (1000_40B3 / 0x140B3)
    BL = 0x1C;
    State.IncCycles();
    // DIV BL (1000_40B5 / 0x140B5)
    Cpu.Div8(BL);
    State.IncCycles();
    // MOV BH,AL (1000_40B7 / 0x140B7)
    BH = AL;
    State.IncCycles();
    // INC BH (1000_40B9 / 0x140B9)
    BH = Alu.Inc8(BH);
    State.IncCycles();
    // MOV BL,0x80 (1000_40BB / 0x140BB)
    BL = 0x80;
    State.IncCycles();
    // MOV DH,byte ptr [DI + 0x8] (1000_40BD / 0x140BD)
    DH = UInt8[DS, (ushort)(DI + 0x8)];
    State.IncCycles();
    // MOV DL,0x1 (1000_40C0 / 0x140C0)
    DL = 0x1;
    State.IncCycles();
    // RET  (1000_40C2 / 0x140C2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40C3_0140C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40C3_140C3:
    // MOV BP,0x40c9 (1000_40C3 / 0x140C3)
    BP = 0x40C9;
    State.IncCycles();
    // JMP 0x1000:36ee (1000_40C6 / 0x140C6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_36EE_0136EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40C9_0140C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40C9_140C9:
    // TEST byte ptr [SI + 0xf],0x40 (1000_40C9 / 0x140C9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    State.IncCycles();
    // JZ 0x1000:40d4 (1000_40CD / 0x140CD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_40D4 / 0x140D4)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_40CF / 0x140CF)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],BX (1000_40D1 / 0x140D1)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    State.IncCycles();
    label_1000_40D4_140D4:
    // RET  (1000_40D4 / 0x140D4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40D5_0140D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40D5_140D5:
    // MOV byte ptr [0x23],0x7 (1000_40D5 / 0x140D5)
    UInt8[DS, 0x23] = 0x7;
    State.IncCycles();
    // CALL 0x1000:36d3 (1000_40DA / 0x140DA)
    NearCall(cs1, 0x40DD, spice86_generated_label_call_target_1000_36D3_0136D3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_40DD_0140DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_40DD_0140DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40DD_140DD:
    // CALL 0x1000:4ac4 (1000_40DD / 0x140DD)
    NearCall(cs1, 0x40E0, spice86_generated_label_ret_target_1000_4AC4_014AC4);
    State.IncCycles();
    label_1000_40E0_140E0:
    // MOV BP,0x40e6 (1000_40E0 / 0x140E0)
    BP = 0x40E6;
    State.IncCycles();
    // JMP 0x1000:36ee (1000_40E3 / 0x140E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_36EE_0136EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40E6_0140E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40E6_140E6:
    // TEST byte ptr [SI + 0xf],0x40 (1000_40E6 / 0x140E6)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    State.IncCycles();
    // JZ 0x1000:40f8 (1000_40EA / 0x140EA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_40F8 / 0x140F8)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0xf],0x2 (1000_40EC / 0x140EC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x2);
    State.IncCycles();
    // JZ 0x1000:40f8 (1000_40F0 / 0x140F0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_40F8 / 0x140F8)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:9556 (1000_40F2 / 0x140F2)
    NearCall(cs1, 0x40F5, not_observed_1000_9556_019556);
    State.IncCycles();
    // CALL 0x1000:9655 (1000_40F5 / 0x140F5)
    NearCall(cs1, 0x40F8, not_observed_1000_9655_019655);
    State.IncCycles();
    label_1000_40F8_140F8:
    // RET  (1000_40F8 / 0x140F8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40F9_0140F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_40F9_140F9:
    // TEST byte ptr [0x11c9],0x3 (1000_40F9 / 0x140F9)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JNZ 0x1000:4101 (1000_40FE / 0x140FE)
    if(!ZeroFlag) {
      goto label_1000_4101_14101;
    }
    State.IncCycles();
    // RET  (1000_4100 / 0x14100)
    return NearRet();
    State.IncCycles();
    label_1000_4101_14101:
    // CMP word ptr [0x10],0x0 (1000_4101 / 0x14101)
    Alu.Sub16(UInt16[DS, 0x10], 0x0);
    State.IncCycles();
    // JZ 0x1000:4181 (1000_4106 / 0x14106)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4181 / 0x14181)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:407e (1000_4108 / 0x14108)
    NearCall(cs1, 0x410B, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_410B_01410B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_410B_01410B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_410B_1410B:
    // MOV CX,0x9 (1000_410B / 0x1410B)
    CX = 0x9;
    State.IncCycles();
    // MOV AX,0x9 (1000_410E / 0x1410E)
    AX = 0x9;
    State.IncCycles();
    // CALL 0x1000:b56c (1000_4111 / 0x14111)
    NearCall(cs1, 0x4114, spice86_generated_label_call_target_1000_B56C_01B56C);
    State.IncCycles();
    label_1000_4114_14114:
    // MOV CX,0x51 (1000_4114 / 0x14114)
    CX = 0x51;
    State.IncCycles();
    label_1000_4117_14117:
    // LODSB SI (1000_4117 / 0x14117)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // TEST AL,0x40 (1000_4118 / 0x14118)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:417c (1000_411A / 0x1411A)
    if(ZeroFlag) {
      goto label_1000_417C_1417C;
    }
    State.IncCycles();
    // MOV DI,word ptr [SI] (1000_411C / 0x1411C)
    DI = UInt16[DS, SI];
    State.IncCycles();
    // PUSH CX (1000_411E / 0x1411E)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_411F / 0x1411F)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:409a (1000_4120 / 0x14120)
    NearCall(cs1, 0x4123, spice86_generated_label_call_target_1000_409A_01409A);
    State.IncCycles();
    label_1000_4123_14123:
    // JNZ 0x1000:417a (1000_4123 / 0x14123)
    if(!ZeroFlag) {
      goto label_1000_417A_1417A;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x80 (1000_4125 / 0x14125)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    State.IncCycles();
    // JZ 0x1000:417a (1000_4129 / 0x14129)
    if(ZeroFlag) {
      goto label_1000_417A_1417A;
    }
    State.IncCycles();
    // MOV AL,[0x2a] (1000_412B / 0x1412B)
    AL = UInt8[DS, 0x2A];
    State.IncCycles();
    // CMP AL,byte ptr [SI + 0xb] (1000_412E / 0x1412E)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    State.IncCycles();
    // JC 0x1000:417a (1000_4131 / 0x14131)
    if(CarryFlag) {
      goto label_1000_417A_1417A;
    }
    State.IncCycles();
    // MOV DI,SI (1000_4133 / 0x14133)
    DI = SI;
    State.IncCycles();
    // CALL 0x1000:5124 (1000_4135 / 0x14135)
    NearCall(cs1, 0x4138, spice86_generated_label_call_target_1000_5124_015124);
    State.IncCycles();
    label_1000_4138_14138:
    // JC 0x1000:417a (1000_4138 / 0x14138)
    if(CarryFlag) {
      goto label_1000_417A_1417A;
    }
    State.IncCycles();
    // SUB AL,byte ptr [0x11c7] (1000_413A / 0x1413A)
    AL -= UInt8[DS, 0x11C7];
    State.IncCycles();
    // ADD AL,0x60 (1000_413E / 0x1413E)
    AL += 0x60;
    State.IncCycles();
    // CMP AL,0xc0 (1000_4140 / 0x14140)
    Alu.Sub8(AL, 0xC0);
    State.IncCycles();
    // JNC 0x1000:417a (1000_4142 / 0x14142)
    if(!CarryFlag) {
      goto label_1000_417A_1417A;
    }
    State.IncCycles();
    // XOR AH,AH (1000_4144 / 0x14144)
    AH = 0;
    State.IncCycles();
    // MOV CX,0xce (1000_4146 / 0x14146)
    CX = 0xCE;
    State.IncCycles();
    // CMP AL,0x60 (1000_4149 / 0x14149)
    Alu.Sub8(AL, 0x60);
    State.IncCycles();
    // JC 0x1000:4152 (1000_414B / 0x1414B)
    if(CarryFlag) {
      goto label_1000_4152_14152;
    }
    State.IncCycles();
    // INC AH (1000_414D / 0x1414D)
    AH++;
    State.IncCycles();
    // ADD CX,0x2 (1000_414F / 0x1414F)
    // CX += 0x2;
    CX = Alu.Add16(CX, 0x2);
    State.IncCycles();
    label_1000_4152_14152:
    // MOV word ptr [0x11f5],CX (1000_4152 / 0x14152)
    UInt16[DS, 0x11F5] = CX;
    State.IncCycles();
    // MOV byte ptr [0xe1],AH (1000_4156 / 0x14156)
    UInt8[DS, 0xE1] = AH;
    State.IncCycles();
    // CALL 0x1000:6231 (1000_415A / 0x1415A)
    NearCall(cs1, 0x415D, spice86_generated_label_call_target_1000_6231_016231);
    State.IncCycles();
    label_1000_415D_1415D:
    // ADD AX,0x48 (1000_415D / 0x1415D)
    // AX += 0x48;
    AX = Alu.Add16(AX, 0x48);
    State.IncCycles();
    // MOV [0x11f3],AX (1000_4160 / 0x14160)
    UInt16[DS, 0x11F3] = AX;
    State.IncCycles();
    // MOV byte ptr [0x23],0x3 (1000_4163 / 0x14163)
    UInt8[DS, 0x23] = 0x3;
    State.IncCycles();
    // CALL 0x1000:425b (1000_4168 / 0x14168)
    NearCall(cs1, 0x416B, spice86_generated_label_call_target_1000_425B_01425B);
    State.IncCycles();
    label_1000_416B_1416B:
    // CALL 0x1000:4944 (1000_416B / 0x1416B)
    NearCall(cs1, 0x416E, spice86_generated_label_call_target_1000_4944_014944);
    State.IncCycles();
    label_1000_416E_1416E:
    // CALL 0x1000:dbb2 (1000_416E / 0x1416E)
    NearCall(cs1, 0x4171, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_4171_14171:
    // CALL 0x1000:2efb (1000_4171 / 0x14171)
    NearCall(cs1, 0x4174, spice86_generated_label_call_target_1000_2EFB_012EFB);
    State.IncCycles();
    label_1000_4174_14174:
    // CALL 0x1000:2ffb (1000_4174 / 0x14174)
    NearCall(cs1, 0x4177, spice86_generated_label_call_target_1000_2FFB_012FFB);
    State.IncCycles();
    label_1000_4177_14177:
    // CALL 0x1000:d397 (1000_4177 / 0x14177)
    NearCall(cs1, 0x417A, spice86_generated_label_call_target_1000_D397_01D397);
    State.IncCycles();
    label_1000_417A_1417A:
    // POP SI (1000_417A / 0x1417A)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_417B / 0x1417B)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_417C_1417C:
    // ADD SI,0x2 (1000_417C / 0x1417C)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // LOOP 0x1000:4117 (1000_417F / 0x1417F)
    if(--CX != 0) {
      goto label_1000_4117_14117;
    }
    State.IncCycles();
    label_1000_4181_14181:
    // RET  (1000_4181 / 0x14181)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4182_014182(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4182_14182:
    // MOV AL,[0x11c9] (1000_4182 / 0x14182)
    AL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // AND AL,0x3 (1000_4185 / 0x14185)
    AL &= 0x3;
    State.IncCycles();
    // DEC AL (1000_4187 / 0x14187)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x1000:4181 (1000_4189 / 0x14189)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4181 / 0x14181)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x11cb],0x0 (1000_418B / 0x1418B)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:419b (1000_4190 / 0x14190)
    if(!ZeroFlag) {
      goto label_1000_419B_1419B;
    }
    State.IncCycles();
    // MOV DI,word ptr [0x11c5] (1000_4192 / 0x14192)
    DI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_4196 / 0x14196)
    NearCall(cs1, 0x4199, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    label_1000_4199_14199:
    // JC 0x1000:41c5 (1000_4199 / 0x14199)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_41C5_0141C5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_419B_1419B:
    // CALL 0x1000:407e (1000_419B / 0x1419B)
    NearCall(cs1, 0x419E, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_419E_01419E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_419E_01419E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_419E_1419E:
    // CALL 0x1000:b532 (1000_419E / 0x1419E)
    NearCall(cs1, 0x41A1, spice86_generated_label_call_target_1000_B532_01B532);
    State.IncCycles();
    label_1000_41A1_141A1:
    // AND AL,0x30 (1000_41A1 / 0x141A1)
    AL &= 0x30;
    State.IncCycles();
    // CMP AL,0x30 (1000_41A3 / 0x141A3)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JC 0x1000:41c5 (1000_41A5 / 0x141A5)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_41C5_0141C5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x4726],0x0 (1000_41A7 / 0x141A7)
    Alu.Sub8(UInt8[DS, 0x4726], 0x0);
    State.IncCycles();
    // JNZ 0x1000:41b3 (1000_41AC / 0x141AC)
    if(!ZeroFlag) {
      goto label_1000_41B3_141B3;
    }
    State.IncCycles();
    // MOV byte ptr [0x23],0x4 (1000_41AE / 0x141AE)
    UInt8[DS, 0x23] = 0x4;
    State.IncCycles();
    label_1000_41B3_141B3:
    // MOV AL,0x40 (1000_41B3 / 0x141B3)
    AL = 0x40;
    State.IncCycles();
    // CALL 0x1000:41cc (1000_41B5 / 0x141B5)
    NearCall(cs1, 0x41B8, not_observed_1000_41CC_0141CC);
    State.IncCycles();
    // SUB byte ptr [0x4726],0x20 (1000_41B8 / 0x141B8)
    // UInt8[DS, 0x4726] -= 0x20;
    UInt8[DS, 0x4726] = Alu.Sub8(UInt8[DS, 0x4726], 0x20);
    State.IncCycles();
    // JNZ 0x1000:4181 (1000_41BD / 0x141BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4181 / 0x14181)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x46d9],0x2 (1000_41BF / 0x141BF)
    UInt8[DS, 0x46D9] = 0x2;
    State.IncCycles();
    // RET  (1000_41C4 / 0x141C4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_41C5_0141C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_41C5_141C5:
    // MOV byte ptr [0x4726],0x0 (1000_41C5 / 0x141C5)
    UInt8[DS, 0x4726] = 0x0;
    State.IncCycles();
    // XOR AL,AL (1000_41CA / 0x141CA)
    AL = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_41CC_0141CC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_41CC_0141CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_41CC_141CC:
    // MOV [0x21fd],AL (1000_41CC / 0x141CC)
    UInt8[DS, 0x21FD] = AL;
    State.IncCycles();
    // CMP word ptr [0x1f12],0x4ffb (1000_41CF / 0x141CF)
    Alu.Sub16(UInt16[DS, 0x1F12], 0x4FFB);
    State.IncCycles();
    // JNZ 0x1000:41da (1000_41D5 / 0x141D5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_41DA / 0x141DA)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0x1f11],AL (1000_41D7 / 0x141D7)
    UInt8[DS, 0x1F11] = AL;
    State.IncCycles();
    label_1000_41DA_141DA:
    // RET  (1000_41DA / 0x141DA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_41E1_0141E1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x41DB: break; // Instructions before entry targeted by 0x141E6
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_41DB_141DB:
    // DEC byte ptr [0x196c] (1000_41DB / 0x141DB)
    UInt8[DS, 0x196C] = Alu.Dec8(UInt8[DS, 0x196C]);
    State.IncCycles();
    // CLC  (1000_41DF / 0x141DF)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_41E0 / 0x141E0)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_41E1_141E1:
    // CMP byte ptr [0x196c],0x0 (1000_41E1 / 0x141E1)
    Alu.Sub8(UInt8[DS, 0x196C], 0x0);
    State.IncCycles();
    // JNZ 0x1000:41db (1000_41E6 / 0x141E6)
    if(!ZeroFlag) {
      goto label_1000_41DB_141DB;
    }
    State.IncCycles();
    // MOV AL,[0x11c7] (1000_41E8 / 0x141E8)
    AL = UInt8[DS, 0x11C7];
    State.IncCycles();
    // ADD AL,0x20 (1000_41EB / 0x141EB)
    AL += 0x20;
    State.IncCycles();
    // TEST AL,0x40 (1000_41ED / 0x141ED)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // MOV CX,0x1 (1000_41EF / 0x141EF)
    CX = 0x1;
    State.IncCycles();
    // MOV AX,0x8 (1000_41F2 / 0x141F2)
    AX = 0x8;
    State.IncCycles();
    // JZ 0x1000:41f8 (1000_41F5 / 0x141F5)
    if(ZeroFlag) {
      goto label_1000_41F8_141F8;
    }
    State.IncCycles();
    // XCHG AX,CX (1000_41F7 / 0x141F7)
    ushort tmp_1000_41F7 = AX;
    AX = CX;
    CX = tmp_1000_41F7;
    State.IncCycles();
    label_1000_41F8_141F8:
    // CALL 0x1000:b56c (1000_41F8 / 0x141F8)
    NearCall(cs1, 0x41FB, spice86_generated_label_call_target_1000_B56C_01B56C);
    State.IncCycles();
    label_1000_41FB_141FB:
    // MOV CX,0x8 (1000_41FB / 0x141FB)
    CX = 0x8;
    State.IncCycles();
    label_1000_41FE_141FE:
    // LODSB SI (1000_41FE / 0x141FE)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // TEST AL,0x40 (1000_41FF / 0x141FF)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JNZ 0x1000:420a (1000_4201 / 0x14201)
    if(!ZeroFlag) {
      goto label_1000_420A_1420A;
    }
    State.IncCycles();
    label_1000_4203_14203:
    // ADD SI,0x2 (1000_4203 / 0x14203)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // LOOP 0x1000:41fe (1000_4206 / 0x14206)
    if(--CX != 0) {
      goto label_1000_41FE_141FE;
    }
    State.IncCycles();
    // CLC  (1000_4208 / 0x14208)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_4209 / 0x14209)
    return NearRet();
    State.IncCycles();
    label_1000_420A_1420A:
    // MOV DI,word ptr [SI] (1000_420A / 0x1420A)
    DI = UInt16[DS, SI];
    State.IncCycles();
    // PUSH CX (1000_420C / 0x1420C)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_420D / 0x1420D)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:409a (1000_420E / 0x1420E)
    NearCall(cs1, 0x4211, spice86_generated_label_call_target_1000_409A_01409A);
    State.IncCycles();
    label_1000_4211_14211:
    // JNZ 0x1000:4257 (1000_4211 / 0x14211)
    if(!ZeroFlag) {
      goto label_1000_4257_14257;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x80 (1000_4213 / 0x14213)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    State.IncCycles();
    // JZ 0x1000:4221 (1000_4217 / 0x14217)
    if(ZeroFlag) {
      goto label_1000_4221_14221;
    }
    State.IncCycles();
    // MOV AL,[0x2a] (1000_4219 / 0x14219)
    AL = UInt8[DS, 0x2A];
    State.IncCycles();
    // CMP AL,byte ptr [SI + 0xb] (1000_421C / 0x1421C)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    State.IncCycles();
    // JC 0x1000:4257 (1000_421F / 0x1421F)
    if(CarryFlag) {
      goto label_1000_4257_14257;
    }
    State.IncCycles();
    label_1000_4221_14221:
    // MOV DI,SI (1000_4221 / 0x14221)
    DI = SI;
    State.IncCycles();
    // CALL 0x1000:5124 (1000_4223 / 0x14223)
    NearCall(cs1, 0x4226, spice86_generated_label_call_target_1000_5124_015124);
    State.IncCycles();
    label_1000_4226_14226:
    // JC 0x1000:4257 (1000_4226 / 0x14226)
    if(CarryFlag) {
      goto label_1000_4257_14257;
    }
    State.IncCycles();
    // SUB AL,byte ptr [0x11c7] (1000_4228 / 0x14228)
    AL -= UInt8[DS, 0x11C7];
    State.IncCycles();
    // ADD AL,0x20 (1000_422C / 0x1422C)
    AL += 0x20;
    State.IncCycles();
    // CMP AL,0x40 (1000_422E / 0x1422E)
    Alu.Sub8(AL, 0x40);
    State.IncCycles();
    // JNC 0x1000:4257 (1000_4230 / 0x14230)
    if(!CarryFlag) {
      goto label_1000_4257_14257;
    }
    State.IncCycles();
    // SUB AL,0x20 (1000_4232 / 0x14232)
    // AL -= 0x20;
    AL = Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // CBW  (1000_4234 / 0x14234)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SHL AX,1 (1000_4235 / 0x14235)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_4237 / 0x14237)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_4239 / 0x14239)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_423B / 0x1423B)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_423D / 0x1423D)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV [0x1968],AX (1000_423F / 0x1423F)
    UInt16[DS, 0x1968] = AX;
    State.IncCycles();
    // XOR AX,AX (1000_4242 / 0x14242)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:5e4f (1000_4244 / 0x14244)
    NearCall(cs1, 0x4247, spice86_generated_label_call_target_1000_5E4F_015E4F);
    State.IncCycles();
    label_1000_4247_14247:
    // MOV BX,0x196d (1000_4247 / 0x14247)
    BX = 0x196D;
    State.IncCycles();
    // XLAT BX (1000_424A / 0x1424A)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // MOV [0x196a],AX (1000_424B / 0x1424B)
    UInt16[DS, 0x196A] = AX;
    State.IncCycles();
    // POP SI (1000_424E / 0x1424E)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_424F / 0x1424F)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x196c],0x6 (1000_4250 / 0x14250)
    UInt8[DS, 0x196C] = 0x6;
    State.IncCycles();
    // STC  (1000_4255 / 0x14255)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_4256 / 0x14256)
    return NearRet();
    State.IncCycles();
    label_1000_4257_14257:
    // POP SI (1000_4257 / 0x14257)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_4258 / 0x14258)
    CX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4203 (1000_4259 / 0x14259)
    goto label_1000_4203_14203;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_425B_01425B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_425B_1425B:
    // TEST byte ptr [DI + 0xa],0x80 (1000_425B / 0x1425B)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    State.IncCycles();
    // JZ 0x1000:4284 (1000_425F / 0x1425F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4284 / 0x14284)
      return NearRet();
    }
    State.IncCycles();
    // AND byte ptr [DI + 0xa],0x7f (1000_4261 / 0x14261)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x7F);
    State.IncCycles();
    // MOV byte ptr [DI + 0xb],0x0 (1000_4265 / 0x14265)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x0;
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x20 (1000_4269 / 0x14269)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x20);
    State.IncCycles();
    // JNC 0x1000:4284 (1000_426D / 0x1426D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4284 / 0x14284)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0x27] (1000_426F / 0x1426F)
    UInt8[DS, 0x27]++;
    State.IncCycles();
    // CMP word ptr [DI],0x603 (1000_4273 / 0x14273)
    Alu.Sub16(UInt16[DS, DI], 0x603);
    State.IncCycles();
    // JNZ 0x1000:4284 (1000_4277 / 0x14277)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4284 / 0x14284)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_4279 / 0x14279)
    NearCall(cs1, 0x427C, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // MOV AL,0x10 (1000_427C / 0x1427C)
    AL = 0x10;
    State.IncCycles();
    // CALL 0x1000:121f (1000_427E / 0x1427E)
    NearCall(cs1, 0x4281, spice86_generated_label_jump_target_1000_121F_01121F);
    State.IncCycles();
    // CALL 0x1000:e283 (1000_4281 / 0x14281)
    NearCall(cs1, 0x4284, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_4284_14284:
    // RET  (1000_4284 / 0x14284)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_42E9_0142E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_42E9_142E9:
    // CALL 0x1000:98b2 (1000_42E9 / 0x142E9)
    NearCall(cs1, 0x42EC, spice86_generated_label_call_target_1000_98B2_0198B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_42EC_0142EC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_42EC_0142EC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_42EC_142EC:
    // CALL 0x1000:38e1 (1000_42EC / 0x142EC)
    NearCall(cs1, 0x42EF, spice86_generated_label_call_target_1000_38E1_0138E1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_42EF_0142EF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_42EF_0142EF(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x430B: goto label_1000_430B_1430B;break; // Target of external jump from 0x14985
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_42EF_142EF:
    // MOV AX,0x24 (1000_42EF / 0x142EF)
    AX = 0x24;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_42F2 / 0x142F2)
    NearCall(cs1, 0x42F5, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_42F5_142F5:
    // MOV byte ptr [0x473e],0x1 (1000_42F5 / 0x142F5)
    UInt8[DS, 0x473E] = 0x1;
    State.IncCycles();
    // MOV byte ptr [0x11c9],0x4 (1000_42FA / 0x142FA)
    UInt8[DS, 0x11C9] = 0x4;
    State.IncCycles();
    // MOV word ptr [0x487e],0x2 (1000_42FF / 0x142FF)
    UInt16[DS, 0x487E] = 0x2;
    State.IncCycles();
    // MOV BP,0x212e (1000_4305 / 0x14305)
    BP = 0x212E;
    State.IncCycles();
    // CALL 0x1000:49ea (1000_4308 / 0x14308)
    NearCall(cs1, 0x430B, spice86_generated_label_call_target_1000_49EA_0149EA);
    State.IncCycles();
    label_1000_430B_1430B:
    // MOV BX,0x4415 (1000_430B / 0x1430B)
    BX = 0x4415;
    State.IncCycles();
    // CALL 0x1000:d323 (1000_430E / 0x1430E)
    NearCall(cs1, 0x4311, spice86_generated_label_call_target_1000_D323_01D323);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4311_014311, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4311_014311(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4311_14311:
    // MOV AX,0x1ac8 (1000_4311 / 0x14311)
    AX = 0x1AC8;
    State.IncCycles();
    // CALL 0x1000:d95e (1000_4314 / 0x14314)
    NearCall(cs1, 0x4317, spice86_generated_label_call_target_1000_D95E_01D95E);
    State.IncCycles();
    label_1000_4317_14317:
    // CALL 0x1000:4aca (1000_4317 / 0x14317)
    NearCall(cs1, 0x431A, spice86_generated_label_call_target_1000_4ACA_014ACA);
    State.IncCycles();
    label_1000_431A_1431A:
    // MOV word ptr [0x46fc],0x0 (1000_431A / 0x1431A)
    UInt16[DS, 0x46FC] = 0x0;
    State.IncCycles();
    // CALL 0x1000:5b5d (1000_4320 / 0x14320)
    NearCall(cs1, 0x4323, spice86_generated_label_call_target_1000_5B5D_015B5D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4323_014323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4323_014323(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4323_14323:
    // MOV byte ptr [0x46eb],0x1 (1000_4323 / 0x14323)
    UInt8[DS, 0x46EB] = 0x1;
    State.IncCycles();
    // MOV SI,0x1cca (1000_4328 / 0x14328)
    SI = 0x1CCA;
    State.IncCycles();
    // CALL 0x1000:d72b (1000_432B / 0x1432B)
    NearCall(cs1, 0x432E, spice86_generated_label_call_target_1000_D72B_01D72B);
    State.IncCycles();
    label_1000_432E_1432E:
    // MOV SI,0x149c (1000_432E / 0x1432E)
    SI = 0x149C;
    State.IncCycles();
    // MOV DI,0x46e3 (1000_4331 / 0x14331)
    DI = 0x46E3;
    State.IncCycles();
    // CALL 0x1000:daaa (1000_4334 / 0x14334)
    NearCall(cs1, 0x4337, spice86_generated_label_call_target_1000_DAAA_01DAAA);
    State.IncCycles();
    label_1000_4337_14337:
    // CALL 0x1000:5b99 (1000_4337 / 0x14337)
    NearCall(cs1, 0x433A, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    label_1000_433A_1433A:
    // CALL 0x1000:439f (1000_433A / 0x1433A)
    NearCall(cs1, 0x433D, spice86_generated_label_call_target_1000_439F_01439F);
    State.IncCycles();
    label_1000_433D_1433D:
    // MOV AX,0x2bc (1000_433D / 0x1433D)
    AX = 0x2BC;
    State.IncCycles();
    // CALL 0x1000:ab4f (1000_4340 / 0x14340)
    NearCall(cs1, 0x4343, spice86_generated_label_call_target_1000_AB4F_01AB4F);
    State.IncCycles();
    label_1000_4343_14343:
    // CALL 0x1000:4658 (1000_4343 / 0x14343)
    NearCall(cs1, 0x4346, spice86_generated_label_call_target_1000_4658_014658);
    State.IncCycles();
    label_1000_4346_14346:
    // MOV word ptr [0x46ed],0x4377 (1000_4346 / 0x14346)
    UInt16[DS, 0x46ED] = 0x4377;
    State.IncCycles();
    // CALL 0x1000:5b93 (1000_434C / 0x1434C)
    NearCall(cs1, 0x434F, spice86_generated_label_ret_target_1000_5B93_015B93);
    State.IncCycles();
    label_1000_434F_1434F:
    // CALL 0x1000:b6c3 (1000_434F / 0x1434F)
    NearCall(cs1, 0x4352, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4352_014352, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4352_014352(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4352_14352:
    // CALL 0x1000:c137 (1000_4352 / 0x14352)
    NearCall(cs1, 0x4355, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_4355_14355:
    // CALL 0x1000:5dce (1000_4355 / 0x14355)
    NearCall(cs1, 0x4358, spice86_generated_label_call_target_1000_5DCE_015DCE);
    State.IncCycles();
    label_1000_4358_14358:
    // CMP byte ptr [0x473e],0x0 (1000_4358 / 0x14358)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    State.IncCycles();
    // JZ 0x1000:436e (1000_435D / 0x1435D)
    if(ZeroFlag) {
      goto label_1000_436E_1436E;
    }
    State.IncCycles();
    // MOV AX,0x24 (1000_435F / 0x1435F)
    AX = 0x24;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_4362 / 0x14362)
    NearCall(cs1, 0x4365, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_4365_14365:
    // MOV SI,0x14c0 (1000_4365 / 0x14365)
    SI = 0x14C0;
    State.IncCycles();
    // CALL 0x1000:c21b (1000_4368 / 0x14368)
    NearCall(cs1, 0x436B, spice86_generated_label_call_target_1000_C21B_01C21B);
    State.IncCycles();
    label_1000_436B_1436B:
    // CALL 0x1000:c0f4 (1000_436B / 0x1436B)
    NearCall(cs1, 0x436E, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    label_1000_436E_1436E:
    // CALL 0x1000:c4dd (1000_436E / 0x1436E)
    NearCall(cs1, 0x4371, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_4371_14371:
    // CALL 0x1000:445d (1000_4371 / 0x14371)
    NearCall(cs1, 0x4374, spice86_generated_label_call_target_1000_445D_01445D);
    State.IncCycles();
    label_1000_4374_14374:
    // JMP 0x1000:d280 (1000_4374 / 0x14374)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_439F_01439F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_439F_1439F:
    // CALL 0x1000:c07c (1000_439F / 0x1439F)
    NearCall(cs1, 0x43A2, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_43A2_0143A2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_43A2_0143A2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_43A2_143A2:
    // CMP byte ptr [0x473e],0x0 (1000_43A2 / 0x143A2)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    State.IncCycles();
    // JNZ 0x1000:43cc (1000_43A7 / 0x143A7)
    if(!ZeroFlag) {
      goto label_1000_43CC_143CC;
    }
    State.IncCycles();
    // MOV AX,0x24 (1000_43A9 / 0x143A9)
    AX = 0x24;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_43AC / 0x143AC)
    NearCall(cs1, 0x43AF, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // CALL 0x1000:c49a (1000_43AF / 0x143AF)
    NearCall(cs1, 0x43B2, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    State.IncCycles();
    // CALL 0x1000:c412 (1000_43B2 / 0x143B2)
    NearCall(cs1, 0x43B5, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    // CALLF [0x3935] (1000_43B5 / 0x143B5)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_43B5 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_43B5) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_43B5));
        break;
    }
    State.IncCycles();
    // CALL 0x1000:5b69 (1000_43B9 / 0x143B9)
    NearCall(cs1, 0x43BC, spice86_generated_label_call_target_1000_5B69_015B69);
    State.IncCycles();
    // MOV SI,0x14a4 (1000_43BC / 0x143BC)
    SI = 0x14A4;
    State.IncCycles();
    // MOV AL,0xf5 (1000_43BF / 0x143BF)
    AL = 0xF5;
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_43C1 / 0x143C1)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x38dd] (1000_43C5 / 0x143C5)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_43C5 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_43C5) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_43C5));
        break;
    }
    State.IncCycles();
    // JMP 0x1000:c4dd (1000_43C9 / 0x143C9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_43CC_143CC:
    // CMP byte ptr [0x2b],0x0 (1000_43CC / 0x143CC)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JNZ 0x1000:43d6 (1000_43D1 / 0x143D1)
    if(!ZeroFlag) {
      goto label_1000_43D6_143D6;
    }
    State.IncCycles();
    // CALL 0x1000:38b4 (1000_43D3 / 0x143D3)
    NearCall(cs1, 0x43D6, spice86_generated_label_call_target_1000_38B4_0138B4);
    State.IncCycles();
    label_1000_43D6_143D6:
    // MOV AX,0x24 (1000_43D6 / 0x143D6)
    AX = 0x24;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_43D9 / 0x143D9)
    NearCall(cs1, 0x43DC, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_43DC_143DC:
    // MOV SI,0x14b4 (1000_43DC / 0x143DC)
    SI = 0x14B4;
    State.IncCycles();
    // CALL 0x1000:c21b (1000_43DF / 0x143DF)
    NearCall(cs1, 0x43E2, spice86_generated_label_call_target_1000_C21B_01C21B);
    State.IncCycles();
    label_1000_43E2_143E2:
    // RET  (1000_43E2 / 0x143E2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_43E3_0143E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_43E3_143E3:
    // CMP byte ptr [0x473e],0x0 (1000_43E3 / 0x143E3)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    State.IncCycles();
    // JNZ 0x1000:43fc (1000_43E8 / 0x143E8)
    if(!ZeroFlag) {
      goto label_1000_43FC_143FC;
    }
    State.IncCycles();
    // CMP word ptr [0xdbea],0x0 (1000_43EA / 0x143EA)
    Alu.Sub16(UInt16[DS, 0xDBEA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:440f (1000_43EF / 0x143EF)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_440F_01440F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x14ac (1000_43F1 / 0x143F1)
    SI = 0x14AC;
    State.IncCycles();
    // PUSH SI (1000_43F4 / 0x143F4)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:c446 (1000_43F5 / 0x143F5)
    NearCall(cs1, 0x43F8, spice86_generated_label_call_target_1000_C446_01C446);
    State.IncCycles();
    // POP SI (1000_43F8 / 0x143F8)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c4f0 (1000_43F9 / 0x143F9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_43FC_143FC:
    // CMP byte ptr [0x6],0x80 (1000_43FC / 0x143FC)
    Alu.Sub8(UInt8[DS, 0x6], 0x80);
    State.IncCycles();
    // JNZ 0x1000:440f (1000_4401 / 0x14401)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_440F_01440F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:388d (1000_4403 / 0x14403)
    NearCall(cs1, 0x4406, spice86_generated_label_ret_target_1000_388D_01388D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4406_014406, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4406_014406(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4406_14406:
    // CALL 0x1000:c43e (1000_4406 / 0x14406)
    NearCall(cs1, 0x4409, spice86_generated_label_call_target_1000_C43E_01C43E);
    State.IncCycles();
    label_1000_4409_14409:
    // CALL 0x1000:c4dd (1000_4409 / 0x14409)
    NearCall(cs1, 0x440C, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_440C_1440C:
    // JMP 0x1000:c0f4 (1000_440C / 0x1440C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_440F_01440F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_440F_1440F:
    // CALL 0x1000:4abe (1000_440F / 0x1440F)
    NearCall(cs1, 0x4412, spice86_generated_label_call_target_1000_4ABE_014ABE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4412_014412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4412_014412(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4412_14412:
    // JMP 0x1000:c0f4 (1000_4412 / 0x14412)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4415_014415(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4415_14415:
    // XOR AL,AL (1000_4415 / 0x14415)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0x46eb],AL (1000_4417 / 0x14417)
    byte tmp_1000_4417 = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_4417;
    State.IncCycles();
    // OR AL,AL (1000_441B / 0x1441B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:4420 (1000_441D / 0x1441D)
    if(!ZeroFlag) {
      goto label_1000_4420_14420;
    }
    State.IncCycles();
    // RET  (1000_441F / 0x1441F)
    return NearRet();
    State.IncCycles();
    label_1000_4420_14420:
    // MOV word ptr [0xa5c0],0x0 (1000_4420 / 0x14420)
    UInt16[DS, 0xA5C0] = 0x0;
    State.IncCycles();
    // CALL 0x1000:daa3 (1000_4426 / 0x14426)
    NearCall(cs1, 0x4429, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4429_014429, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4429_014429(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4429_14429:
    // MOV SI,0x44ab (1000_4429 / 0x14429)
    SI = 0x44AB;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_442C / 0x1442C)
    NearCall(cs1, 0x442F, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_442F_01442F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_442F_01442F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_442F_1442F:
    // CALL 0x1000:469b (1000_442F / 0x1442F)
    NearCall(cs1, 0x4432, spice86_generated_label_call_target_1000_469B_01469B);
    State.IncCycles();
    label_1000_4432_14432:
    // CALL 0x1000:5ba0 (1000_4432 / 0x14432)
    NearCall(cs1, 0x4435, spice86_generated_label_call_target_1000_5BA0_015BA0);
    State.IncCycles();
    label_1000_4435_14435:
    // CALL 0x1000:43e3 (1000_4435 / 0x14435)
    NearCall(cs1, 0x4438, spice86_generated_label_call_target_1000_43E3_0143E3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4438_014438, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4438_014438(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4438_14438:
    // CALL 0x1000:c0f4 (1000_4438 / 0x14438)
    NearCall(cs1, 0x443B, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    label_1000_443B_1443B:
    // CMP word ptr [0x11c5],0x0 (1000_443B / 0x1443B)
    Alu.Sub16(UInt16[DS, 0x11C5], 0x0);
    State.IncCycles();
    // JNZ 0x1000:4447 (1000_4440 / 0x14440)
    if(!ZeroFlag) {
      goto label_1000_4447_14447;
    }
    State.IncCycles();
    // MOV byte ptr [0x11c9],0x0 (1000_4442 / 0x14442)
    UInt8[DS, 0x11C9] = 0x0;
    State.IncCycles();
    label_1000_4447_14447:
    // CALL 0x1000:d95b (1000_4447 / 0x14447)
    NearCall(cs1, 0x444A, spice86_generated_label_call_target_1000_D95B_01D95B);
    State.IncCycles();
    label_1000_444A_1444A:
    // CALL 0x1000:d717 (1000_444A / 0x1444A)
    NearCall(cs1, 0x444D, spice86_generated_label_call_target_1000_D717_01D717);
    State.IncCycles();
    label_1000_444D_1444D:
    // CALL 0x1000:2ffb (1000_444D / 0x1444D)
    NearCall(cs1, 0x4450, spice86_generated_label_call_target_1000_2FFB_012FFB);
    State.IncCycles();
    label_1000_4450_14450:
    // CMP byte ptr [0x4728],0x0 (1000_4450 / 0x14450)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    State.IncCycles();
    // JLE 0x1000:445a (1000_4455 / 0x14455)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:4ac4 (1000_445A / 0x1445A)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AC4_014AC4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:49d4 (1000_4457 / 0x14457)
    NearCall(cs1, 0x445A, not_observed_1000_49D4_0149D4);
    State.IncCycles();
    label_1000_445A_1445A:
    // JMP 0x1000:4ac4 (1000_445A / 0x1445A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AC4_014AC4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_445D_01445D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_445D_1445D:
    // MOV SI,0x44ab (1000_445D / 0x1445D)
    SI = 0x44AB;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_4460 / 0x14460)
    NearCall(cs1, 0x4463, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4463_014463, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4463_014463(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4463_14463:
    // CALL 0x1000:407e (1000_4463 / 0x14463)
    NearCall(cs1, 0x4466, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4466_014466, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4466_014466(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4466_14466:
    // CALL 0x1000:62d6 (1000_4466 / 0x14466)
    NearCall(cs1, 0x4469, spice86_generated_label_call_target_1000_62D6_0162D6);
    State.IncCycles();
    label_1000_4469_14469:
    // JNC 0x1000:4472 (1000_4469 / 0x14469)
    if(!CarryFlag) {
      goto label_1000_4472_14472;
    }
    State.IncCycles();
    // MOV word ptr [0x4749],0x0 (1000_446B / 0x1446B)
    UInt16[DS, 0x4749] = 0x0;
    State.IncCycles();
    // RET  (1000_4471 / 0x14471)
    return NearRet();
    State.IncCycles();
    label_1000_4472_14472:
    // CALL 0x1000:c137 (1000_4472 / 0x14472)
    NearCall(cs1, 0x4475, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_4475_14475:
    // MOV AX,0x4c (1000_4475 / 0x14475)
    AX = 0x4C;
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_4478 / 0x14478)
    NearCall(cs1, 0x447B, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_447B_01447B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_447B_01447B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_447B_1447B:
    // LODSW ES:SI (1000_447B / 0x1447B)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AH,0xf (1000_447D / 0x1447D)
    // AH &= 0xF;
    AH = Alu.And8(AH, 0xF);
    State.IncCycles();
    // MOV BP,AX (1000_4480 / 0x14480)
    BP = AX;
    State.IncCycles();
    // LODSW ES:SI (1000_4482 / 0x14482)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XOR AH,AH (1000_4484 / 0x14484)
    AH = 0;
    State.IncCycles();
    // SUB BX,AX (1000_4486 / 0x14486)
    BX -= AX;
    State.IncCycles();
    // SUB DX,0xd (1000_4488 / 0x14488)
    DX -= 0xD;
    State.IncCycles();
    // ADD BP,DX (1000_448B / 0x1448B)
    BP += DX;
    State.IncCycles();
    // ADD AX,BX (1000_448D / 0x1448D)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    State.IncCycles();
    // MOV DI,0x4749 (1000_448F / 0x1448F)
    DI = 0x4749;
    State.IncCycles();
    // MOV word ptr [DI],DX (1000_4492 / 0x14492)
    UInt16[DS, DI] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],BX (1000_4494 / 0x14494)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    State.IncCycles();
    // MOV word ptr [DI + 0x4],BP (1000_4497 / 0x14497)
    UInt16[DS, (ushort)(DI + 0x4)] = BP;
    State.IncCycles();
    // MOV word ptr [DI + 0x6],AX (1000_449A / 0x1449A)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    State.IncCycles();
    // MOV SI,0x44ab (1000_449D / 0x1449D)
    SI = 0x44AB;
    State.IncCycles();
    // MOV BP,0x12c (1000_44A0 / 0x144A0)
    BP = 0x12C;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_44A3 / 0x144A3)
    NearCall(cs1, 0x44A6, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    label_1000_44A6_144A6:
    // MOV byte ptr [0x4751],0x0 (1000_44A6 / 0x144A6)
    UInt8[DS, 0x4751] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_44AB_0144AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_44AB_0144AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_44AB_144AB:
    // INC byte ptr [0x4751] (1000_44AB / 0x144AB)
    UInt8[DS, 0x4751] = Alu.Inc8(UInt8[DS, 0x4751]);
    State.IncCycles();
    // PUSH word ptr [0xdbda] (1000_44AF / 0x144AF)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_44B3 / 0x144B3)
    NearCall(cs1, 0x44B6, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_44B6_0144B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_44B6_0144B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_44B6_144B6:
    // CALL 0x1000:5b93 (1000_44B6 / 0x144B6)
    NearCall(cs1, 0x44B9, spice86_generated_label_ret_target_1000_5B93_015B93);
    State.IncCycles();
    label_1000_44B9_144B9:
    // CALL 0x1000:c137 (1000_44B9 / 0x144B9)
    NearCall(cs1, 0x44BC, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_44BC_144BC:
    // MOV SI,0x4749 (1000_44BC / 0x144BC)
    SI = 0x4749;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_44BF / 0x144BF)
    NearCall(cs1, 0x44C2, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    label_1000_44C2_144C2:
    // MOV DX,word ptr [SI] (1000_44C2 / 0x144C2)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_44C4 / 0x144C4)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x4] (1000_44C7 / 0x144C7)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_44CA / 0x144CA)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV SI,0xd834 (1000_44CD / 0x144CD)
    SI = 0xD834;
    State.IncCycles();
    // CMP BP,word ptr [SI + 0x4] (1000_44D0 / 0x144D0)
    Alu.Sub16(BP, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JC 0x1000:44d8 (1000_44D3 / 0x144D3)
    if(CarryFlag) {
      goto label_1000_44D8_144D8;
    }
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x4] (1000_44D5 / 0x144D5)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    label_1000_44D8_144D8:
    // CMP AX,word ptr [SI + 0x6] (1000_44D8 / 0x144D8)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JC 0x1000:44e0 (1000_44DB / 0x144DB)
    if(CarryFlag) {
      goto label_1000_44E0_144E0;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_44DD / 0x144DD)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    label_1000_44E0_144E0:
    // CMP DX,word ptr [SI] (1000_44E0 / 0x144E0)
    Alu.Sub16(DX, UInt16[DS, SI]);
    State.IncCycles();
    // JNC 0x1000:44e6 (1000_44E2 / 0x144E2)
    if(!CarryFlag) {
      goto label_1000_44E6_144E6;
    }
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_44E4 / 0x144E4)
    DX = UInt16[DS, SI];
    State.IncCycles();
    label_1000_44E6_144E6:
    // CMP BX,word ptr [SI + 0x2] (1000_44E6 / 0x144E6)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:44ee (1000_44E9 / 0x144E9)
    if(!CarryFlag) {
      goto label_1000_44EE_144EE;
    }
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_44EB / 0x144EB)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    label_1000_44EE_144EE:
    // CALL 0x1000:c4fb (1000_44EE / 0x144EE)
    NearCall(cs1, 0x44F1, spice86_generated_label_call_target_1000_C4FB_01C4FB);
    State.IncCycles();
    label_1000_44F1_144F1:
    // MOV BL,byte ptr [0x4751] (1000_44F1 / 0x144F1)
    BL = UInt8[DS, 0x4751];
    State.IncCycles();
    // SHR BL,1 (1000_44F5 / 0x144F5)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    State.IncCycles();
    // JNC 0x1000:4507 (1000_44F7 / 0x144F7)
    if(!CarryFlag) {
      goto label_1000_4507_14507;
    }
    State.IncCycles();
    // MOV AX,0x4c (1000_44F9 / 0x144F9)
    AX = 0x4C;
    State.IncCycles();
    // MOV DX,word ptr [0x4749] (1000_44FC / 0x144FC)
    DX = UInt16[DS, 0x4749];
    State.IncCycles();
    // MOV BX,word ptr [0x474b] (1000_4500 / 0x14500)
    BX = UInt16[DS, 0x474B];
    State.IncCycles();
    // CALL 0x1000:c30d (1000_4504 / 0x14504)
    NearCall(cs1, 0x4507, spice86_generated_label_call_target_1000_C30D_01C30D);
    State.IncCycles();
    label_1000_4507_14507:
    // POP word ptr [0xdbda] (1000_4507 / 0x14507)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:db67 (1000_450B / 0x1450B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_450E_01450E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_450E_1450E:
    // TEST byte ptr [0x11c9],0xf (1000_450E / 0x1450E)
    Alu.And8(UInt8[DS, 0x11C9], 0xF);
    State.IncCycles();
    // JZ 0x1000:4533 (1000_4513 / 0x14513)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4533 / 0x14533)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_4515 / 0x14515)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_4516 / 0x14516)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:4586 (1000_4517 / 0x14517)
    NearCall(cs1, 0x451A, spice86_generated_label_call_target_1000_4586_014586);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_451A_01451A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_451A_01451A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_451A_1451A:
    // POP DX (1000_451A / 0x1451A)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_451B / 0x1451B)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV DI,word ptr [0x46fc] (1000_451C / 0x1451C)
    DI = UInt16[DS, 0x46FC];
    State.IncCycles();
    // OR DI,DI (1000_4520 / 0x14520)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:4533 (1000_4522 / 0x14522)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4533 / 0x14533)
      return NearRet();
    }
    State.IncCycles();
    // JS 0x1000:4534 (1000_4524 / 0x14524)
    if(SignFlag) {
      goto label_1000_4534_14534;
    }
    State.IncCycles();
    // TEST byte ptr [0x11c9],0x3 (1000_4526 / 0x14526)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JNZ 0x1000:4534 (1000_452B / 0x1452B)
    if(!ZeroFlag) {
      goto label_1000_4534_14534;
    }
    State.IncCycles();
    // CMP DI,word ptr [0x114e] (1000_452D / 0x1452D)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JNZ 0x1000:4534 (1000_4531 / 0x14531)
    if(!ZeroFlag) {
      goto label_1000_4534_14534;
    }
    State.IncCycles();
    label_1000_4533_14533:
    // RET  (1000_4533 / 0x14533)
    return NearRet();
    State.IncCycles();
    label_1000_4534_14534:
    // PUSH BX (1000_4534 / 0x14534)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_4535 / 0x14535)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_4536 / 0x14536)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:456c (1000_4537 / 0x14537)
    NearCall(cs1, 0x453A, spice86_generated_label_call_target_1000_456C_01456C);
    State.IncCycles();
    label_1000_453A_1453A:
    // CALL 0x1000:ab45 (1000_453A / 0x1453A)
    NearCall(cs1, 0x453D, spice86_generated_label_call_target_1000_AB45_01AB45);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_453D_01453D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_453D_01453D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_453D_1453D:
    // POP DI (1000_453D / 0x1453D)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x9 (1000_453E / 0x1453E)
    CX = 0x9;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4541_014541, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4541_014541(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4541_14541:
    // PUSH CX (1000_4541 / 0x14541)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_4542 / 0x14542)
    Stack.Push(DI);
    State.IncCycles();
    // MOV AX,0x14 (1000_4543 / 0x14543)
    AX = 0x14;
    State.IncCycles();
    // CALL 0x1000:e3a0 (1000_4546 / 0x14546)
    NearCall(cs1, 0x4549, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    State.IncCycles();
    label_1000_4549_14549:
    // PUSH DI (1000_4549 / 0x14549)
    Stack.Push(DI);
    State.IncCycles();
    // XOR DI,DI (1000_454A / 0x1454A)
    DI = 0;
    State.IncCycles();
    // CALL 0x1000:45de (1000_454C / 0x1454C)
    NearCall(cs1, 0x454F, spice86_generated_label_call_target_1000_45DE_0145DE);
    State.IncCycles();
    label_1000_454F_1454F:
    // POP DI (1000_454F / 0x1454F)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV AX,0xa (1000_4550 / 0x14550)
    AX = 0xA;
    State.IncCycles();
    // CALL 0x1000:e3a0 (1000_4553 / 0x14553)
    NearCall(cs1, 0x4556, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    State.IncCycles();
    label_1000_4556_14556:
    // CALL 0x1000:45de (1000_4556 / 0x14556)
    NearCall(cs1, 0x4559, spice86_generated_label_call_target_1000_45DE_0145DE);
    State.IncCycles();
    label_1000_4559_14559:
    // POP DI (1000_4559 / 0x14559)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_455A / 0x1455A)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:4541 (1000_455B / 0x1455B)
    if(--CX != 0) {
      goto label_1000_4541_14541;
    }
    State.IncCycles();
    // PUSH DI (1000_455D / 0x1455D)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:aba9 (1000_455E / 0x1455E)
    NearCall(cs1, 0x4561, spice86_generated_label_call_target_1000_ABA9_01ABA9);
    State.IncCycles();
    label_1000_4561_14561:
    // POP DI (1000_4561 / 0x14561)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_4562 / 0x14562)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_4563 / 0x14563)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x4732],0x80 (1000_4564 / 0x14564)
    UInt8[DS, 0x4732] = 0x80;
    State.IncCycles();
    // JMP 0x1000:4703 (1000_4569 / 0x14569)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4703_014703, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_456C_01456C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_456C_1456C:
    // MOV AX,DI (1000_456C / 0x1456C)
    AX = DI;
    State.IncCycles();
    // CMP AH,0xff (1000_456E / 0x1456E)
    Alu.Sub8(AH, 0xFF);
    State.IncCycles();
    // JZ 0x1000:4582 (1000_4571 / 0x14571)
    if(ZeroFlag) {
      goto label_1000_4582_14582;
    }
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_4573 / 0x14573)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // DEC AX (1000_4575 / 0x14575)
    AX--;
    State.IncCycles();
    // SHL AL,1 (1000_4576 / 0x14576)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_4578 / 0x14578)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_457A / 0x1457A)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_457C / 0x1457C)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // OR AL,AH (1000_457E / 0x1457E)
    AL |= AH;
    State.IncCycles();
    // XOR AH,AH (1000_4580 / 0x14580)
    AH = 0;
    State.IncCycles();
    label_1000_4582_14582:
    // ADD AX,0x2bc (1000_4582 / 0x14582)
    // AX += 0x2BC;
    AX = Alu.Add16(AX, 0x2BC);
    State.IncCycles();
    // RET  (1000_4585 / 0x14585)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4586_014586(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4586_14586:
    // CALL 0x1000:5d1d (1000_4586 / 0x14586)
    NearCall(cs1, 0x4589, spice86_generated_label_call_target_1000_5D1D_015D1D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4589_014589, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4589_014589(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4589_14589:
    // MOV DI,0x0 (1000_4589 / 0x14589)
    DI = 0x0;
    State.IncCycles();
    // JNC 0x1000:45d3 (1000_458C / 0x1458C)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0x145D3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0xff (1000_458E / 0x1458E)
    AL = 0xFF;
    State.IncCycles();
    // CALL 0x1000:5e6d (1000_4590 / 0x14590)
    NearCall(cs1, 0x4593, spice86_generated_label_call_target_1000_5E6D_015E6D);
    State.IncCycles();
    label_1000_4593_14593:
    // CMP AX,0x9 (1000_4593 / 0x14593)
    Alu.Sub16(AX, 0x9);
    State.IncCycles();
    // JC 0x1000:45d3 (1000_4596 / 0x14596)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0x145D3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DI,0xffff (1000_4598 / 0x14598)
    DI = 0xFFFF;
    State.IncCycles();
    // MOV DX,word ptr [0x4749] (1000_459B / 0x1459B)
    DX = UInt16[DS, 0x4749];
    State.IncCycles();
    // OR DX,DX (1000_459F / 0x1459F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:45d3 (1000_45A1 / 0x145A1)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0x145D3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD DX,0xb (1000_45A3 / 0x145A3)
    DX += 0xB;
    State.IncCycles();
    // SUB DX,word ptr [0xdc36] (1000_45A6 / 0x145A6)
    DX -= UInt16[DS, 0xDC36];
    State.IncCycles();
    // NEG DX (1000_45AA / 0x145AA)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // MOV BX,word ptr [0xdc38] (1000_45AC / 0x145AC)
    BX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // SUB BX,word ptr [0x474f] (1000_45B0 / 0x145B0)
    // BX -= UInt16[DS, 0x474F];
    BX = Alu.Sub16(BX, UInt16[DS, 0x474F]);
    State.IncCycles();
    // CALL 0x1000:514e (1000_45B4 / 0x145B4)
    NearCall(cs1, 0x45B7, spice86_generated_label_call_target_1000_514E_01514E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_45B7_0145B7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x45D3: goto label_1000_45D3_145D3;break; // Target of external jump from 0x145C4, 0x14596, 0x1458C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_45B7_145B7:
    // ADD AL,0x3 (1000_45B7 / 0x145B7)
    // AL += 0x3;
    AL = Alu.Add8(AL, 0x3);
    State.IncCycles();
    // MOV AH,AL (1000_45B9 / 0x145B9)
    AH = AL;
    State.IncCycles();
    // AND AH,0x1f (1000_45BB / 0x145BB)
    AH &= 0x1F;
    State.IncCycles();
    // CMP AH,0x6 (1000_45BE / 0x145BE)
    Alu.Sub8(AH, 0x6);
    State.IncCycles();
    // MOV DI,0xffff (1000_45C1 / 0x145C1)
    DI = 0xFFFF;
    State.IncCycles();
    // JNC 0x1000:45d3 (1000_45C4 / 0x145C4)
    if(!CarryFlag) {
      goto label_1000_45D3_145D3;
    }
    State.IncCycles();
    // ROL AL,1 (1000_45C6 / 0x145C6)
    AL = Alu.Rol8(AL, 0x1);
    State.IncCycles();
    // ROL AL,1 (1000_45C8 / 0x145C8)
    AL = Alu.Rol8(AL, 0x1);
    State.IncCycles();
    // ROL AL,1 (1000_45CA / 0x145CA)
    AL = Alu.Rol8(AL, 0x1);
    State.IncCycles();
    // AND AL,0x7 (1000_45CC / 0x145CC)
    // AL &= 0x7;
    AL = Alu.And8(AL, 0x7);
    State.IncCycles();
    // OR AX,0xfff0 (1000_45CE / 0x145CE)
    // AX |= 0xFFF0;
    AX = Alu.Or16(AX, 0xFFF0);
    State.IncCycles();
    // MOV DI,AX (1000_45D1 / 0x145D1)
    DI = AX;
    State.IncCycles();
    label_1000_45D3_145D3:
    // MOV AX,DI (1000_45D3 / 0x145D3)
    AX = DI;
    State.IncCycles();
    // XCHG word ptr [0x46fc],AX (1000_45D5 / 0x145D5)
    ushort tmp_1000_45D5 = UInt16[DS, 0x46FC];
    UInt16[DS, 0x46FC] = AX;
    AX = tmp_1000_45D5;
    State.IncCycles();
    // CMP AX,DI (1000_45D9 / 0x145D9)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JNZ 0x1000:45de (1000_45DB / 0x145DB)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_45DE_0145DE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_45DD / 0x145DD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_45DE_0145DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_45DE_145DE:
    // PUSH word ptr [0xdbda] (1000_45DE / 0x145DE)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_45E2 / 0x145E2)
    NearCall(cs1, 0x45E5, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45E5_0145E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_45E5_0145E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_45E5_145E5:
    // CALL 0x1000:dbb2 (1000_45E5 / 0x145E5)
    NearCall(cs1, 0x45E8, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_45E8_145E8:
    // CALL 0x1000:d075 (1000_45E8 / 0x145E8)
    NearCall(cs1, 0x45EB, spice86_generated_label_call_target_1000_D075_01D075);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45EB_0145EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_45EB_0145EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_45EB_145EB:
    // MOV DX,0x55 (1000_45EB / 0x145EB)
    DX = 0x55;
    State.IncCycles();
    // MOV BX,0x22 (1000_45EE / 0x145EE)
    BX = 0x22;
    State.IncCycles();
    // MOV CX,0xf5fe (1000_45F1 / 0x145F1)
    CX = 0xF5FE;
    State.IncCycles();
    // CMP byte ptr [0x473e],0x0 (1000_45F4 / 0x145F4)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    State.IncCycles();
    // JZ 0x1000:4600 (1000_45F9 / 0x145F9)
    if(ZeroFlag) {
      goto label_1000_4600_14600;
    }
    State.IncCycles();
    // ADD BX,0x4 (1000_45FB / 0x145FB)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    State.IncCycles();
    // MOV CH,0x20 (1000_45FE / 0x145FE)
    CH = 0x20;
    State.IncCycles();
    label_1000_4600_14600:
    // OR DI,DI (1000_4600 / 0x14600)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:462a (1000_4602 / 0x14602)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_462A_01462A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:469b (1000_4604 / 0x14604)
    NearCall(cs1, 0x4607, spice86_generated_label_call_target_1000_469B_01469B);
    State.IncCycles();
    label_1000_4607_14607:
    // CMP DI,-0x10 (1000_4607 / 0x14607)
    Alu.Sub16(DI, 0xFFF0);
    State.IncCycles();
    // JC 0x1000:4636 (1000_460A / 0x1460A)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4636_014636, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,0xa4 (1000_460C / 0x1460C)
    AX = 0xA4;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_460F / 0x1460F)
    NearCall(cs1, 0x4612, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    label_1000_4612_14612:
    // SUB DI,-0x10 (1000_4612 / 0x14612)
    DI -= 0xFFF0;
    State.IncCycles();
    // CMP DI,0x8 (1000_4615 / 0x14615)
    Alu.Sub16(DI, 0x8);
    State.IncCycles();
    // JNC 0x1000:4641 (1000_4618 / 0x14618)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0x14641 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_461A / 0x1461A)
    AL = 0x20;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_461C / 0x1461C)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_461C = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_461C) {
      case 0xD12F : NearCall(cs1, 0x4620, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_461C));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4620_014620, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4620_014620(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4620_14620:
    // MOV AX,DI (1000_4620 / 0x14620)
    AX = DI;
    State.IncCycles();
    // ADD AX,0xda (1000_4622 / 0x14622)
    // AX += 0xDA;
    AX = Alu.Add16(AX, 0xDA);
    State.IncCycles();
    // CALL 0x1000:d19b (1000_4625 / 0x14625)
    NearCall(cs1, 0x4628, spice86_generated_label_ret_target_1000_D19B_01D19B);
    State.IncCycles();
    label_1000_4628_14628:
    // JMP 0x1000:4641 (1000_4628 / 0x14628)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0x14641 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_462A_01462A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_462A_1462A:
    // CALL 0x1000:4658 (1000_462A / 0x1462A)
    NearCall(cs1, 0x462D, spice86_generated_label_call_target_1000_4658_014658);
    State.IncCycles();
    label_1000_462D_1462D:
    // MOV word ptr [0xdbe4],CX (1000_462D / 0x1462D)
    UInt16[DS, 0xDBE4] = CX;
    State.IncCycles();
    // CALL 0x1000:d04e (1000_4631 / 0x14631)
    NearCall(cs1, 0x4634, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4634_014634, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4634_014634(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4634_14634:
    // JMP 0x1000:4641 (1000_4634 / 0x14634)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0x14641 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4636_014636(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4636_14636:
    // PUSH CX (1000_4636 / 0x14636)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:629d (1000_4637 / 0x14637)
    NearCall(cs1, 0x463A, spice86_generated_label_call_target_1000_629D_01629D);
    State.IncCycles();
    label_1000_463A_1463A:
    // CALL 0x1000:d05f (1000_463A / 0x1463A)
    NearCall(cs1, 0x463D, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_463D_01463D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4641: goto label_1000_4641_14641;break; // Target of external jump from 0x14634, 0x14618, 0x14628, 0x1464F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_463D_1463D:
    // POP CX (1000_463D / 0x1463D)
    CX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:62a6 (1000_463E / 0x1463E)
    NearCall(cs1, 0x4641, spice86_generated_label_call_target_1000_62A6_0162A6);
    State.IncCycles();
    label_1000_4641_14641:
    // CMP word ptr [0xd82c],0xed (1000_4641 / 0x14641)
    Alu.Sub16(UInt16[DS, 0xD82C], 0xED);
    State.IncCycles();
    // JA 0x1000:4651 (1000_4647 / 0x14647)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_4651_14651;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_4649 / 0x14649)
    AL = 0x20;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_464B / 0x1464B)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_464B = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_464B) {
      case 0xD12F : NearCall(cs1, 0x464F, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_464B));
        break;
    }
    State.IncCycles();
    label_1000_464F_1464F:
    // JMP 0x1000:4641 (1000_464F / 0x1464F)
    goto label_1000_4641_14641;
    State.IncCycles();
    label_1000_4651_14651:
    // POP word ptr [0xdbda] (1000_4651 / 0x14651)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:dbec (1000_4655 / 0x14655)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4658_014658(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4658_14658:
    // CMP word ptr [0x473f],0x0 (1000_4658 / 0x14658)
    Alu.Sub16(UInt16[DS, 0x473F], 0x0);
    State.IncCycles();
    // JNZ 0x1000:469a (1000_465D / 0x1465D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_469A / 0x1469A)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_465F / 0x1465F)
    NearCall(cs1, 0x4662, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4662_014662, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4662_014662(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4662_14662:
    // MOV SI,0x57 (1000_4662 / 0x14662)
    SI = 0x57;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_4665 / 0x14665)
    NearCall(cs1, 0x4668, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_4668_14668:
    // MOV word ptr [0x4741],ES (1000_4668 / 0x14668)
    UInt16[DS, 0x4741] = ES;
    State.IncCycles();
    // MOV word ptr [0x473f],SI (1000_466C / 0x1466C)
    UInt16[DS, 0x473F] = SI;
    State.IncCycles();
    // MOV word ptr [0x4743],0x55 (1000_4670 / 0x14670)
    UInt16[DS, 0x4743] = 0x55;
    State.IncCycles();
    // MOV CX,0xf561 (1000_4676 / 0x14676)
    CX = 0xF561;
    State.IncCycles();
    // MOV AX,0x22 (1000_4679 / 0x14679)
    AX = 0x22;
    State.IncCycles();
    // CMP byte ptr [0x473e],0x0 (1000_467C / 0x1467C)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    State.IncCycles();
    // JZ 0x1000:4687 (1000_4681 / 0x14681)
    if(ZeroFlag) {
      goto label_1000_4687_14687;
    }
    State.IncCycles();
    // ADD AL,0x4 (1000_4683 / 0x14683)
    // AL += 0x4;
    AL = Alu.Add8(AL, 0x4);
    State.IncCycles();
    // MOV CH,0x20 (1000_4685 / 0x14685)
    CH = 0x20;
    State.IncCycles();
    label_1000_4687_14687:
    // MOV [0x4745],AX (1000_4687 / 0x14687)
    UInt16[DS, 0x4745] = AX;
    State.IncCycles();
    // MOV word ptr [0x4747],CX (1000_468A / 0x1468A)
    UInt16[DS, 0x4747] = CX;
    State.IncCycles();
    // MOV SI,0x46b5 (1000_468E / 0x1468E)
    SI = 0x46B5;
    State.IncCycles();
    // MOV BP,0x18 (1000_4691 / 0x14691)
    BP = 0x18;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_4694 / 0x14694)
    NearCall(cs1, 0x4697, spice86_generated_label_call_target_1000_DA25_01DA25);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4697_014697, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4697_014697(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4697_14697:
    // CALL 0x1000:e283 (1000_4697 / 0x14697)
    NearCall(cs1, 0x469A, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_469A_1469A:
    // RET  (1000_469A / 0x1469A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_469B_01469B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_469B_1469B:
    // CMP word ptr [0x473f],0x0 (1000_469B / 0x1469B)
    Alu.Sub16(UInt16[DS, 0x473F], 0x0);
    State.IncCycles();
    // JZ 0x1000:46b4 (1000_46A0 / 0x146A0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_46B4 / 0x146B4)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [0x473f],0x0 (1000_46A2 / 0x146A2)
    UInt16[DS, 0x473F] = 0x0;
    State.IncCycles();
    // CALL 0x1000:e270 (1000_46A8 / 0x146A8)
    NearCall(cs1, 0x46AB, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46AB_0146AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46AB_0146AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_46AB_146AB:
    // MOV SI,0x46b5 (1000_46AB / 0x146AB)
    SI = 0x46B5;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_46AE / 0x146AE)
    NearCall(cs1, 0x46B1, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46B1_0146B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46B1_0146B1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x46B4: goto label_1000_46B4_146B4;break; // Target of external jump from 0x146A0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_46B1_146B1:
    // CALL 0x1000:e283 (1000_46B1 / 0x146B1)
    NearCall(cs1, 0x46B4, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_46B4_146B4:
    // RET  (1000_46B4 / 0x146B4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_46B5_0146B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_46B5_146B5:
    // LES SI,[0x473f] (1000_46B5 / 0x146B5)
    ES = UInt16[DS, 0x4741];
    SI = UInt16[DS, 0x473F];
    State.IncCycles();
    // MOV AL,byte ptr ES:[SI] (1000_46B9 / 0x146B9)
    AL = UInt8[ES, SI];
    State.IncCycles();
    // OR AL,AL (1000_46BC / 0x146BC)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:4702 (1000_46BE / 0x146BE)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4702 / 0x14702)
      return NearRet();
    }
    State.IncCycles();
    // INC word ptr [0x473f] (1000_46C0 / 0x146C0)
    UInt16[DS, 0x473F] = Alu.Inc16(UInt16[DS, 0x473F]);
    State.IncCycles();
    // MOV SI,0x14a4 (1000_46C4 / 0x146C4)
    SI = 0x14A4;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_46C7 / 0x146C7)
    NearCall(cs1, 0x46CA, spice86_generated_label_call_target_1000_DB74_01DB74);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46CA_0146CA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46CA_0146CA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_46CA_146CA:
    // PUSH word ptr [0xdbda] (1000_46CA / 0x146CA)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_46CE / 0x146CE)
    NearCall(cs1, 0x46D1, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46D1_0146D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46D1_0146D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_46D1_146D1:
    // MOV DX,word ptr [0x4743] (1000_46D1 / 0x146D1)
    DX = UInt16[DS, 0x4743];
    State.IncCycles();
    // MOV BX,word ptr [0x4745] (1000_46D5 / 0x146D5)
    BX = UInt16[DS, 0x4745];
    State.IncCycles();
    // CALL 0x1000:d04e (1000_46D9 / 0x146D9)
    NearCall(cs1, 0x46DC, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46DC_0146DC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46DC_0146DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_46DC_146DC:
    // MOV CX,word ptr [0x4747] (1000_46DC / 0x146DC)
    CX = UInt16[DS, 0x4747];
    State.IncCycles();
    // MOV word ptr [0xdbe4],CX (1000_46E0 / 0x146E0)
    UInt16[DS, 0xDBE4] = CX;
    State.IncCycles();
    // CALL 0x1000:d075 (1000_46E4 / 0x146E4)
    NearCall(cs1, 0x46E7, spice86_generated_label_call_target_1000_D075_01D075);
    State.IncCycles();
    label_1000_46E7_146E7:
    // PUSH AX (1000_46E7 / 0x146E7)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:d12f (1000_46E8 / 0x146E8)
    NearCall(cs1, 0x46EB, spice86_generated_label_call_target_1000_D12F_01D12F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46EB_0146EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46EB_0146EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_46EB_146EB:
    // CALL 0x1000:d05f (1000_46EB / 0x146EB)
    NearCall(cs1, 0x46EE, spice86_generated_label_call_target_1000_D05F_01D05F);
    State.IncCycles();
    label_1000_46EE_146EE:
    // MOV word ptr [0x4743],DX (1000_46EE / 0x146EE)
    UInt16[DS, 0x4743] = DX;
    State.IncCycles();
    // MOV word ptr [0x4745],BX (1000_46F2 / 0x146F2)
    UInt16[DS, 0x4745] = BX;
    State.IncCycles();
    // POP AX (1000_46F6 / 0x146F6)
    AX = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_46F7 / 0x146F7)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:db67 (1000_46FB / 0x146FB)
    NearCall(cs1, 0x46FE, spice86_generated_label_call_target_1000_DB67_01DB67);
    State.IncCycles();
    label_1000_46FE_146FE:
    // CMP AL,0x20 (1000_46FE / 0x146FE)
    Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:46b5 (1000_4700 / 0x14700)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_46B5_0146B5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_4702_14702:
    // RET  (1000_4702 / 0x14702)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4703_014703(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4703_14703:
    // CALL 0x1000:4944 (1000_4703 / 0x14703)
    NearCall(cs1, 0x4706, spice86_generated_label_call_target_1000_4944_014944);
    State.IncCycles();
    label_1000_4706_14706:
    // CALL 0x1000:38e1 (1000_4706 / 0x14706)
    NearCall(cs1, 0x4709, spice86_generated_label_call_target_1000_38E1_0138E1);
    State.IncCycles();
    label_1000_4709_14709:
    // MOV AL,[0x11c9] (1000_4709 / 0x14709)
    AL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // PUSH AX (1000_470C / 0x1470C)
    Stack.Push(AX);
    State.IncCycles();
    // SHR AL,1 (1000_470D / 0x1470D)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_470F / 0x1470F)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // OR byte ptr [0x11c9],AL (1000_4711 / 0x14711)
    // UInt8[DS, 0x11C9] |= AL;
    UInt8[DS, 0x11C9] = Alu.Or8(UInt8[DS, 0x11C9], AL);
    State.IncCycles();
    // CALL 0x1000:ad5e (1000_4715 / 0x14715)
    NearCall(cs1, 0x4718, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    State.IncCycles();
    label_1000_4718_14718:
    // CMP byte ptr [0x2b],0x0 (1000_4718 / 0x14718)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JZ 0x1000:4727 (1000_471D / 0x1471D)
    if(ZeroFlag) {
      goto label_1000_4727_14727;
    }
    State.IncCycles();
    // MOV byte ptr [0x2b],0x0 (1000_471F / 0x1471F)
    UInt8[DS, 0x2B] = 0x0;
    State.IncCycles();
    // CALL 0x1000:0b21 (1000_4724 / 0x14724)
    NearCall(cs1, 0x4727, spice86_generated_label_call_target_1000_0B21_010B21);
    State.IncCycles();
    label_1000_4727_14727:
    // CALL 0x1000:d2ea (1000_4727 / 0x14727)
    NearCall(cs1, 0x472A, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_472A_01472A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_472A_01472A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_472A_1472A:
    // CALL 0x1000:4d00 (1000_472A / 0x1472A)
    NearCall(cs1, 0x472D, spice86_generated_label_call_target_1000_4D00_014D00);
    State.IncCycles();
    label_1000_472D_1472D:
    // POP AX (1000_472D / 0x1472D)
    AX = Stack.Pop();
    State.IncCycles();
    // TEST AL,0x3 (1000_472E / 0x1472E)
    Alu.And8(AL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:478f (1000_4730 / 0x14730)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4757_014757, 0x1478F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr [0x472b],0x0 (1000_4732 / 0x14732)
    UInt16[DS, 0x472B] = 0x0;
    State.IncCycles();
    // PUSH AX (1000_4738 / 0x14738)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:41c5 (1000_4739 / 0x14739)
    NearCall(cs1, 0x473C, spice86_generated_label_call_target_1000_41C5_0141C5);
    State.IncCycles();
    label_1000_473C_1473C:
    // MOV AL,[0x11c9] (1000_473C / 0x1473C)
    AL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // AND AL,0x3 (1000_473F / 0x1473F)
    AL &= 0x3;
    State.IncCycles();
    // DEC AL (1000_4741 / 0x14741)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x1000:4748 (1000_4743 / 0x14743)
    if(!ZeroFlag) {
      goto label_1000_4748_14748;
    }
    State.IncCycles();
    // CALL 0x1000:181e (1000_4745 / 0x14745)
    NearCall(cs1, 0x4748, spice86_generated_label_call_target_1000_181E_01181E);
    State.IncCycles();
    label_1000_4748_14748:
    // CALL 0x1000:c474 (1000_4748 / 0x14748)
    NearCall(cs1, 0x474B, spice86_generated_label_call_target_1000_C474_01C474);
    State.IncCycles();
    label_1000_474B_1474B:
    // CALL 0x1000:40d5 (1000_474B / 0x1474B)
    NearCall(cs1, 0x474E, spice86_generated_label_call_target_1000_40D5_0140D5);
    State.IncCycles();
    label_1000_474E_1474E:
    // POP AX (1000_474E / 0x1474E)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV BL,byte ptr [0x11c7] (1000_474F / 0x1474F)
    BL = UInt8[DS, 0x11C7];
    State.IncCycles();
    // PUSH BX (1000_4753 / 0x14753)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:4795 (1000_4754 / 0x14754)
    NearCall(cs1, 0x4757, spice86_generated_label_call_target_1000_4795_014795);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4757_014757, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4757_014757(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x478F: goto label_1000_478F_1478F;break; // Target of external jump from 0x14730
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_4757_14757:
    // POP AX (1000_4757 / 0x14757)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x11c7],AL (1000_4758 / 0x14758)
    UInt8[DS, 0x11C7] = AL;
    State.IncCycles();
    // MOV byte ptr [0x8],0xff (1000_475B / 0x1475B)
    UInt8[DS, 0x8] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:4b3b (1000_4760 / 0x14760)
    NearCall(cs1, 0x4763, spice86_generated_label_call_target_1000_4B3B_014B3B);
    State.IncCycles();
    label_1000_4763_14763:
    // MOV word ptr [0x114e],0x0 (1000_4763 / 0x14763)
    UInt16[DS, 0x114E] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x4729],0x0 (1000_4769 / 0x14769)
    UInt16[DS, 0x4729] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_476F / 0x1476F)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:4779 (1000_4774 / 0x14774)
    if(SignFlag) {
      goto label_1000_4779_14779;
    }
    State.IncCycles();
    // CALL 0x1000:2dbf (1000_4776 / 0x14776)
    NearCall(cs1, 0x4779, spice86_generated_label_call_target_1000_2DBF_012DBF);
    State.IncCycles();
    label_1000_4779_14779:
    // CALL 0x1000:4ab8 (1000_4779 / 0x14779)
    NearCall(cs1, 0x477C, spice86_generated_label_call_target_1000_4AB8_014AB8);
    State.IncCycles();
    label_1000_477C_1477C:
    // MOV AL,[0x11c9] (1000_477C / 0x1477C)
    AL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // AND AL,0x3 (1000_477F / 0x1477F)
    AL &= 0x3;
    State.IncCycles();
    // DEC AL (1000_4781 / 0x14781)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x1000:478f (1000_4783 / 0x14783)
    if(!ZeroFlag) {
      goto label_1000_478F_1478F;
    }
    State.IncCycles();
    // MOV DI,word ptr [0x1150] (1000_4785 / 0x14785)
    DI = UInt16[DS, 0x1150];
    State.IncCycles();
    // DEC byte ptr [DI + 0x15] (1000_4789 / 0x14789)
    UInt8[DS, (ushort)(DI + 0x15)] = Alu.Dec8(UInt8[DS, (ushort)(DI + 0x15)]);
    State.IncCycles();
    // JMP 0x1000:ac14 (1000_478C / 0x1478C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AC14_01AC14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_478F_1478F:
    // CALL 0x1000:2eb2 (1000_478F / 0x1478F)
    NearCall(cs1, 0x4792, spice86_generated_label_call_target_1000_2EB2_012EB2);
    State.IncCycles();
    label_1000_4792_14792:
    // JMP 0x1000:c0f4 (1000_4792 / 0x14792)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
