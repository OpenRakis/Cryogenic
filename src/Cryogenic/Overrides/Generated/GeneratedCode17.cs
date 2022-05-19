namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_DBB2_01DBB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DBB2_1DBB2:
    // PUSH AX (1000_DBB2 / 0x1DBB2)
    Stack.Push(AX);
    // MOV AL,[0xdc46] (1000_DBB3 / 0x1DBB3)
    AL = UInt8[DS, 0xDC46];
    // DEC byte ptr [0xdc46] (1000_DBB6 / 0x1DBB6)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    // JS 0x1000:dbc0 (1000_DBBA / 0x1DBBA)
    if(SignFlag) {
      goto label_1000_DBC0_1DBC0;
    }
    // INC byte ptr [0xdc46] (1000_DBBC / 0x1DBBC)
    UInt8[DS, 0xDC46] = Alu.Inc8(UInt8[DS, 0xDC46]);
    label_1000_DBC0_1DBC0:
    // OR AL,AL (1000_DBC0 / 0x1DBC0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:dbc8 (1000_DBC2 / 0x1DBC2)
    if(SignFlag) {
      goto label_1000_DBC8_1DBC8;
    }
    // CALLF [0x38c5] (1000_DBC4 / 0x1DBC4)
    // Indirect call to [0x38c5], generating possible targets from emulator records
    uint targetAddress_1000_DBC4 = (uint)(UInt16[DS, 0x38C7] * 0x10 + UInt16[DS, 0x38C5] - cs1 * 0x10);
    switch(targetAddress_1000_DBC4) {
      case 0x235BC : FarCall(cs1, 0xDBC8, spice86_generated_label_call_target_334B_010C_0335BC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DBC4));
        break;
    }
    label_1000_DBC8_1DBC8:
    // POP AX (1000_DBC8 / 0x1DBC8)
    AX = Stack.Pop();
    // RET  (1000_DBC9 / 0x1DBC9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DBCA_01DBCA(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDBE3: goto label_1000_DBE3_1DBE3;break; // Target of external jump from 0x14B13
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_DBCA_1DBCA:
    // MOV AX,[0xdc44] (1000_DBCA / 0x1DBCA)
    AX = UInt16[DS, 0xDC44];
    // CMP AX,0x98 (1000_DBCD / 0x1DBCD)
    Alu.Sub16(AX, 0x98);
    // JNC 0x1000:dbe2 (1000_DBD0 / 0x1DBD0)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_DBE2 / 0x1DBE2)
      return NearRet();
    }
    // CMP AX,0x88 (1000_DBD2 / 0x1DBD2)
    Alu.Sub16(AX, 0x88);
    // JNC 0x1000:dbb2 (1000_DBD5 / 0x1DBD5)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DBB2_01DBB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC byte ptr [0xdc46] (1000_DBD7 / 0x1DBD7)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    // JS 0x1000:dbe2 (1000_DBDB / 0x1DBDB)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_DBE2 / 0x1DBE2)
      return NearRet();
    }
    // MOV byte ptr [0xdc46],0x80 (1000_DBDD / 0x1DBDD)
    UInt8[DS, 0xDC46] = 0x80;
    label_1000_DBE2_1DBE2:
    // RET  (1000_DBE2 / 0x1DBE2)
    return NearRet();
    label_1000_DBE3_1DBE3:
    // MOV AX,[0xdc44] (1000_DBE3 / 0x1DBE3)
    AX = UInt16[DS, 0xDC44];
    // CMP AX,0x98 (1000_DBE6 / 0x1DBE6)
    Alu.Sub16(AX, 0x98);
    // JC 0x1000:dbec (1000_DBE9 / 0x1DBE9)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_DBEB / 0x1DBEB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DBEC_01DBEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DBEC_1DBEC:
    // INC byte ptr [0xdc46] (1000_DBEC / 0x1DBEC)
    UInt8[DS, 0xDC46] = Alu.Inc8(UInt8[DS, 0xDC46]);
    // JS 0x1000:dc1a (1000_DBF0 / 0x1DBF0)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_DC1A / 0x1DC1A)
      return NearRet();
    }
    // JNZ 0x1000:dc1b (1000_DBF2 / 0x1DBF2)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DC1B_01DC1B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_DBF4 / 0x1DBF4)
    Stack.Push(AX);
    // PUSH BX (1000_DBF5 / 0x1DBF5)
    Stack.Push(BX);
    // PUSH CX (1000_DBF6 / 0x1DBF6)
    Stack.Push(CX);
    // PUSH DX (1000_DBF7 / 0x1DBF7)
    Stack.Push(DX);
    // PUSH SI (1000_DBF8 / 0x1DBF8)
    Stack.Push(SI);
    // PUSH DI (1000_DBF9 / 0x1DBF9)
    Stack.Push(DI);
    // PUSH BP (1000_DBFA / 0x1DBFA)
    Stack.Push(BP);
    // MOV DX,word ptr [0xdc36] (1000_DBFB / 0x1DBFB)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DBFF / 0x1DBFF)
    BX = UInt16[DS, 0xDC38];
    // MOV word ptr [0xdc42],DX (1000_DC03 / 0x1DC03)
    UInt16[DS, 0xDC42] = DX;
    // MOV word ptr [0xdc44],BX (1000_DC07 / 0x1DC07)
    UInt16[DS, 0xDC44] = BX;
    // MOV SI,word ptr [0x2582] (1000_DC0B / 0x1DC0B)
    SI = UInt16[DS, 0x2582];
    // CALLF [0x38c1] (1000_DC0F / 0x1DC0F)
    // Indirect call to [0x38c1], generating possible targets from emulator records
    uint targetAddress_1000_DC0F = (uint)(UInt16[DS, 0x38C3] * 0x10 + UInt16[DS, 0x38C1] - cs1 * 0x10);
    switch(targetAddress_1000_DC0F) {
      case 0x235B9 : FarCall(cs1, 0xDC13, spice86_generated_label_call_target_334B_0109_0335B9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC0F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DC13_01DC13, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DC13_01DC13(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDC1A: goto label_1000_DC1A_1DC1A;break; // Target of external jump from 0x1DBF0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_DC13_1DC13:
    // POP BP (1000_DC13 / 0x1DC13)
    BP = Stack.Pop();
    // POP DI (1000_DC14 / 0x1DC14)
    DI = Stack.Pop();
    // POP SI (1000_DC15 / 0x1DC15)
    SI = Stack.Pop();
    // POP DX (1000_DC16 / 0x1DC16)
    DX = Stack.Pop();
    // POP CX (1000_DC17 / 0x1DC17)
    CX = Stack.Pop();
    // POP BX (1000_DC18 / 0x1DC18)
    BX = Stack.Pop();
    // POP AX (1000_DC19 / 0x1DC19)
    AX = Stack.Pop();
    label_1000_DC1A_1DC1A:
    // RET  (1000_DC1A / 0x1DC1A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DC1B_01DC1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DC1B_1DC1B:
    // DEC byte ptr [0xdc46] (1000_DC1B / 0x1DC1B)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    // RET  (1000_DC1F / 0x1DC1F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DC20_01DC20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DC20_1DC20:
    // PUSH AX (1000_DC20 / 0x1DC20)
    Stack.Push(AX);
    // PUSH BX (1000_DC21 / 0x1DC21)
    Stack.Push(BX);
    // PUSH CX (1000_DC22 / 0x1DC22)
    Stack.Push(CX);
    // PUSH DX (1000_DC23 / 0x1DC23)
    Stack.Push(DX);
    // PUSH SI (1000_DC24 / 0x1DC24)
    Stack.Push(SI);
    // PUSH DI (1000_DC25 / 0x1DC25)
    Stack.Push(DI);
    // PUSH BP (1000_DC26 / 0x1DC26)
    Stack.Push(BP);
    // MOV DX,word ptr [0xdc36] (1000_DC27 / 0x1DC27)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DC2B / 0x1DC2B)
    BX = UInt16[DS, 0xDC38];
    // CALL 0x1000:dc6a (1000_DC2F / 0x1DC2F)
    NearCall(cs1, 0xDC32, spice86_generated_label_call_target_1000_DC6A_01DC6A);
    label_1000_DC32_1DC32:
    // MOV SI,BP (1000_DC32 / 0x1DC32)
    SI = BP;
    // XCHG word ptr [0x2582],BP (1000_DC34 / 0x1DC34)
    ushort tmp_1000_DC34 = UInt16[DS, 0x2582];
    UInt16[DS, 0x2582] = BP;
    BP = tmp_1000_DC34;
    // XOR AL,AL (1000_DC38 / 0x1DC38)
    AL = 0;
    // XCHG byte ptr [0xdc46],AL (1000_DC3A / 0x1DC3A)
    byte tmp_1000_DC3A = UInt8[DS, 0xDC46];
    UInt8[DS, 0xDC46] = AL;
    AL = tmp_1000_DC3A;
    // OR AL,AL (1000_DC3E / 0x1DC3E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:dc56 (1000_DC40 / 0x1DC40)
    if(SignFlag) {
      goto label_1000_DC56_1DC56;
    }
    // CMP DX,word ptr [0xdc42] (1000_DC42 / 0x1DC42)
    Alu.Sub16(DX, UInt16[DS, 0xDC42]);
    // JNZ 0x1000:dc52 (1000_DC46 / 0x1DC46)
    if(!ZeroFlag) {
      goto label_1000_DC52_1DC52;
    }
    // CMP BX,word ptr [0xdc44] (1000_DC48 / 0x1DC48)
    Alu.Sub16(BX, UInt16[DS, 0xDC44]);
    // JNZ 0x1000:dc52 (1000_DC4C / 0x1DC4C)
    if(!ZeroFlag) {
      goto label_1000_DC52_1DC52;
    }
    // CMP SI,BP (1000_DC4E / 0x1DC4E)
    Alu.Sub16(SI, BP);
    // JZ 0x1000:dc62 (1000_DC50 / 0x1DC50)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DC62_01DC62, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_DC52_1DC52:
    // CALLF [0x38c5] (1000_DC52 / 0x1DC52)
    // Indirect call to [0x38c5], generating possible targets from emulator records
    uint targetAddress_1000_DC52 = (uint)(UInt16[DS, 0x38C7] * 0x10 + UInt16[DS, 0x38C5] - cs1 * 0x10);
    switch(targetAddress_1000_DC52) {
      case 0x235BC : FarCall(cs1, 0xDC56, spice86_generated_label_call_target_334B_010C_0335BC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC52));
        break;
    }
    label_1000_DC56_1DC56:
    // MOV word ptr [0xdc42],DX (1000_DC56 / 0x1DC56)
    UInt16[DS, 0xDC42] = DX;
    // MOV word ptr [0xdc44],BX (1000_DC5A / 0x1DC5A)
    UInt16[DS, 0xDC44] = BX;
    // CALLF [0x38c1] (1000_DC5E / 0x1DC5E)
    // Indirect call to [0x38c1], generating possible targets from emulator records
    uint targetAddress_1000_DC5E = (uint)(UInt16[DS, 0x38C3] * 0x10 + UInt16[DS, 0x38C1] - cs1 * 0x10);
    switch(targetAddress_1000_DC5E) {
      case 0x235B9 : FarCall(cs1, 0xDC62, spice86_generated_label_call_target_334B_0109_0335B9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC5E));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DC62_01DC62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DC62_01DC62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DC62_1DC62:
    // POP BP (1000_DC62 / 0x1DC62)
    BP = Stack.Pop();
    // POP DI (1000_DC63 / 0x1DC63)
    DI = Stack.Pop();
    // POP SI (1000_DC64 / 0x1DC64)
    SI = Stack.Pop();
    // POP DX (1000_DC65 / 0x1DC65)
    DX = Stack.Pop();
    // POP CX (1000_DC66 / 0x1DC66)
    CX = Stack.Pop();
    // POP BX (1000_DC67 / 0x1DC67)
    BX = Stack.Pop();
    // POP AX (1000_DC68 / 0x1DC68)
    AX = Stack.Pop();
    // RET  (1000_DC69 / 0x1DC69)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DC6A_01DC6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DC6A_1DC6A:
    // CMP byte ptr [0x28be],0x0 (1000_DC6A / 0x1DC6A)
    Alu.Sub8(UInt8[DS, 0x28BE], 0x0);
    // MOV BP,0x25c8 (1000_DC6F / 0x1DC6F)
    BP = 0x25C8;
    // JNZ 0x1000:dcdf (1000_DC72 / 0x1DC72)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV BP,0x2584 (1000_DC74 / 0x1DC74)
    BP = 0x2584;
    // CMP byte ptr [0x4723],0x0 (1000_DC77 / 0x1DC77)
    Alu.Sub8(UInt8[DS, 0x4723], 0x0);
    // JNZ 0x1000:dcdf (1000_DC7C / 0x1DC7C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV DI,word ptr [0xdc58] (1000_DC7E / 0x1DC7E)
    DI = UInt16[DS, 0xDC58];
    // OR DI,DI (1000_DC82 / 0x1DC82)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:dcdf (1000_DC84 / 0x1DC84)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // CMP BX,0x9b (1000_DC86 / 0x1DC86)
    Alu.Sub16(BX, 0x9B);
    // JGE 0x1000:dcdf (1000_DC8A / 0x1DC8A)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // CALL 0x1000:d6fe (1000_DC8C / 0x1DC8C)
    NearCall(cs1, 0xDC8F, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_DC8F_1DC8F:
    // MOV BP,0x25c8 (1000_DC8F / 0x1DC8F)
    BP = 0x25C8;
    // JC 0x1000:dcdf (1000_DC92 / 0x1DC92)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // CMP BX,word ptr [DI + 0x2] (1000_DC94 / 0x1DC94)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JL 0x1000:dcb9 (1000_DC97 / 0x1DC97)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DCB9_1DCB9;
    }
    // CMP BX,word ptr [DI + 0x6] (1000_DC99 / 0x1DC99)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JGE 0x1000:dcb9 (1000_DC9C / 0x1DC9C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DCB9_1DCB9;
    }
    // MOV BP,0x26d8 (1000_DC9E / 0x1DC9E)
    BP = 0x26D8;
    // MOV AX,word ptr [DI] (1000_DCA1 / 0x1DCA1)
    AX = UInt16[DS, DI];
    // SUB AX,DX (1000_DCA3 / 0x1DCA3)
    AX -= DX;
    // CMP AX,0x32 (1000_DCA5 / 0x1DCA5)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:dcdf (1000_DCA8 / 0x1DCA8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV BP,0x2650 (1000_DCAA / 0x1DCAA)
    BP = 0x2650;
    // MOV AX,DX (1000_DCAD / 0x1DCAD)
    AX = DX;
    // SUB AX,word ptr [DI + 0x4] (1000_DCAF / 0x1DCAF)
    AX -= UInt16[DS, (ushort)(DI + 0x4)];
    // CMP AX,0x32 (1000_DCB2 / 0x1DCB2)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:dcdf (1000_DCB5 / 0x1DCB5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // JMP 0x1000:dcdc (1000_DCB7 / 0x1DCB7)
    goto label_1000_DCDC_1DCDC;
    label_1000_DCB9_1DCB9:
    // CMP DX,word ptr [DI] (1000_DCB9 / 0x1DCB9)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JL 0x1000:dcdc (1000_DCBB / 0x1DCBB)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DCDC_1DCDC;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_DCBD / 0x1DCBD)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JGE 0x1000:dcdc (1000_DCC0 / 0x1DCC0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DCDC_1DCDC;
    }
    // MOV BP,0x260c (1000_DCC2 / 0x1DCC2)
    BP = 0x260C;
    // MOV AX,word ptr [DI + 0x2] (1000_DCC5 / 0x1DCC5)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    // SUB AX,BX (1000_DCC8 / 0x1DCC8)
    AX -= BX;
    // CMP AX,0x19 (1000_DCCA / 0x1DCCA)
    Alu.Sub16(AX, 0x19);
    // JC 0x1000:dcdf (1000_DCCD / 0x1DCCD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV BP,0x2694 (1000_DCCF / 0x1DCCF)
    BP = 0x2694;
    // MOV AX,BX (1000_DCD2 / 0x1DCD2)
    AX = BX;
    // SUB AX,word ptr [DI + 0x6] (1000_DCD4 / 0x1DCD4)
    AX -= UInt16[DS, (ushort)(DI + 0x6)];
    // CMP AX,0x19 (1000_DCD7 / 0x1DCD7)
    Alu.Sub16(AX, 0x19);
    // JC 0x1000:dcdf (1000_DCDA / 0x1DCDA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    label_1000_DCDC_1DCDC:
    // MOV BP,0x2584 (1000_DCDC / 0x1DCDC)
    BP = 0x2584;
    label_1000_DCDF_1DCDF:
    // RET  (1000_DCDF / 0x1DCDF)
    return NearRet();
  }
  
  public virtual Action read_game_port_ida_1000_DCE0_1DCE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DCE0_1DCE0:
    // MOV DX,0x201 (1000_DCE0 / 0x1DCE0)
    DX = 0x201;
    // PUSHF  (1000_DCE3 / 0x1DCE3)
    Stack.Push(FlagRegister);
    // CLI  (1000_DCE4 / 0x1DCE4)
    InterruptFlag = false;
    // OUT DX,AL (1000_DCE5 / 0x1DCE5)
    Cpu.Out8(DX, AL);
    // XOR BX,BX (1000_DCE6 / 0x1DCE6)
    BX = 0;
    // MOV CX,BX (1000_DCE8 / 0x1DCE8)
    CX = BX;
    // MOV DI,0x800 (1000_DCEA / 0x1DCEA)
    DI = 0x800;
    label_1000_DCED_1DCED:
    // IN AL,DX (1000_DCED / 0x1DCED)
    AL = Cpu.In8(DX);
    // MOV AH,AL (1000_DCEE / 0x1DCEE)
    AH = AL;
    // SHR AH,1 (1000_DCF0 / 0x1DCF0)
    AH >>= 0x1;
    // AND AX,0x101 (1000_DCF2 / 0x1DCF2)
    // AX &= 0x101;
    AX = Alu.And16(AX, 0x101);
    // JZ 0x1000:dd09 (1000_DCF5 / 0x1DCF5)
    if(ZeroFlag) {
      goto label_1000_DD09_1DD09;
    }
    // ADD CL,AL (1000_DCF7 / 0x1DCF7)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    // ADC CH,0x0 (1000_DCF9 / 0x1DCF9)
    CH = Alu.Adc8(CH, 0x0);
    // ADD BL,AH (1000_DCFC / 0x1DCFC)
    // BL += AH;
    BL = Alu.Add8(BL, AH);
    // ADC BH,0x0 (1000_DCFE / 0x1DCFE)
    BH = Alu.Adc8(BH, 0x0);
    // DEC DI (1000_DD01 / 0x1DD01)
    DI = Alu.Dec16(DI);
    // JNZ 0x1000:dced (1000_DD02 / 0x1DD02)
    if(!ZeroFlag) {
      goto label_1000_DCED_1DCED;
    }
    // AND byte ptr [0x2942],0x7f (1000_DD04 / 0x1DD04)
    // UInt8[DS, 0x2942] &= 0x7F;
    UInt8[DS, 0x2942] = Alu.And8(UInt8[DS, 0x2942], 0x7F);
    label_1000_DD09_1DD09:
    // IN AL,DX (1000_DD09 / 0x1DD09)
    AL = Cpu.In8(DX);
    // POPF  (1000_DD0A / 0x1DD0A)
    FlagRegister = Stack.Pop();
    // MOV DX,CX (1000_DD0B / 0x1DD0B)
    DX = CX;
    // NOT AL (1000_DD0D / 0x1DD0D)
    AL = (byte)~AL;
    // RET  (1000_DD0F / 0x1DD0F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_DD10_01DD10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DD10_1DD10:
    // CALL 0x1000:dce0 (1000_DD10 / 0x1DD10)
    NearCall(cs1, 0xDD13, read_game_port_ida_1000_DCE0_1DCE0);
    // MOV AH,AL (1000_DD13 / 0x1DD13)
    AH = AL;
    // XOR AL,AL (1000_DD15 / 0x1DD15)
    AL = 0;
    // TEST AH,0x30 (1000_DD17 / 0x1DD17)
    Alu.And8(AH, 0x30);
    // JZ 0x1000:dd1e (1000_DD1A / 0x1DD1A)
    if(ZeroFlag) {
      goto label_1000_DD1E_1DD1E;
    }
    // NOT AL (1000_DD1C / 0x1DD1C)
    AL = (byte)~AL;
    label_1000_DD1E_1DD1E:
    // MOV [0xcee6],AL (1000_DD1E / 0x1DD1E)
    UInt8[DS, 0xCEE6] = AL;
    // MOV AX,0xff (1000_DD21 / 0x1DD21)
    AX = 0xFF;
    // CMP DX,word ptr [0x39ab] (1000_DD24 / 0x1DD24)
    Alu.Sub16(DX, UInt16[DS, 0x39AB]);
    // JA 0x1000:dd2e (1000_DD28 / 0x1DD28)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_DD2E_1DD2E;
    }
    // XCHG AL,AH (1000_DD2A / 0x1DD2A)
    byte tmp_1000_DD2A = AL;
    AL = AH;
    AH = tmp_1000_DD2A;
    // JMP 0x1000:dd36 (1000_DD2C / 0x1DD2C)
    goto label_1000_DD36_1DD36;
    label_1000_DD2E_1DD2E:
    // CMP DX,word ptr [0x39ad] (1000_DD2E / 0x1DD2E)
    Alu.Sub16(DX, UInt16[DS, 0x39AD]);
    // JNC 0x1000:dd36 (1000_DD32 / 0x1DD32)
    if(!CarryFlag) {
      goto label_1000_DD36_1DD36;
    }
    // XOR AX,AX (1000_DD34 / 0x1DD34)
    AX = 0;
    label_1000_DD36_1DD36:
    // MOV [0xcee1],AL (1000_DD36 / 0x1DD36)
    UInt8[DS, 0xCEE1] = AL;
    // MOV byte ptr [0xcedf],AH (1000_DD39 / 0x1DD39)
    UInt8[DS, 0xCEDF] = AH;
    // MOV AX,0xff (1000_DD3D / 0x1DD3D)
    AX = 0xFF;
    // CMP BX,word ptr [0x39af] (1000_DD40 / 0x1DD40)
    Alu.Sub16(BX, UInt16[DS, 0x39AF]);
    // JA 0x1000:dd4a (1000_DD44 / 0x1DD44)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_DD4A_1DD4A;
    }
    // XCHG AH,AL (1000_DD46 / 0x1DD46)
    byte tmp_1000_DD46 = AH;
    AH = AL;
    AL = tmp_1000_DD46;
    // JMP 0x1000:dd52 (1000_DD48 / 0x1DD48)
    goto label_1000_DD52_1DD52;
    label_1000_DD4A_1DD4A:
    // CMP BX,word ptr [0x39b1] (1000_DD4A / 0x1DD4A)
    Alu.Sub16(BX, UInt16[DS, 0x39B1]);
    // JNC 0x1000:dd52 (1000_DD4E / 0x1DD4E)
    if(!CarryFlag) {
      goto label_1000_DD52_1DD52;
    }
    // XOR AX,AX (1000_DD50 / 0x1DD50)
    AX = 0;
    label_1000_DD52_1DD52:
    // MOV [0xcee4],AL (1000_DD52 / 0x1DD52)
    UInt8[DS, 0xCEE4] = AL;
    // MOV byte ptr [0xcedc],AH (1000_DD55 / 0x1DD55)
    UInt8[DS, 0xCEDC] = AH;
    // RET  (1000_DD59 / 0x1DD59)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DD5A_01DD5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DD5A_1DD5A:
    // XOR AL,AL (1000_DD5A / 0x1DD5A)
    AL = 0;
    // XCHG byte ptr [0xcee8],AL (1000_DD5C / 0x1DD5C)
    byte tmp_1000_DD5C = UInt8[DS, 0xCEE8];
    UInt8[DS, 0xCEE8] = AL;
    AL = tmp_1000_DD5C;
    // OR AL,AL (1000_DD60 / 0x1DD60)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // RET  (1000_DD62 / 0x1DD62)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DD63_01DD63(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DD63_1DD63:
    // CALL 0x1000:de7b (1000_DD63 / 0x1DD63)
    NearCall(cs1, 0xDD66, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    label_1000_DD66_1DD66:
    // CALL 0x1000:de54 (1000_DD66 / 0x1DD66)
    NearCall(cs1, 0xDD69, spice86_generated_label_call_target_1000_DE54_01DE54);
    label_1000_DD69_1DD69:
    // JZ 0x1000:ddae (1000_DD69 / 0x1DD69)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0xcee8],0x0 (1000_DD6B / 0x1DD6B)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x0);
    // JNZ 0x1000:ddae (1000_DD70 / 0x1DD70)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // TEST byte ptr [0x2942],0x40 (1000_DD72 / 0x1DD72)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    // JNZ 0x1000:dd89 (1000_DD77 / 0x1DD77)
    if(!ZeroFlag) {
      goto label_1000_DD89_1DD89;
    }
    // MOV AX,0x3 (1000_DD79 / 0x1DD79)
    AX = 0x3;
    // INT 0x33 (1000_DD7C / 0x1DD7C)
    Interrupt(0x33);
    // XCHG SI,BX (1000_DD7E / 0x1DD7E)
    ushort tmp_1000_DD7E = SI;
    SI = BX;
    BX = tmp_1000_DD7E;
    // XOR BX,SI (1000_DD80 / 0x1DD80)
    BX ^= SI;
    // AND BX,SI (1000_DD82 / 0x1DD82)
    BX &= SI;
    // AND BL,0x7 (1000_DD84 / 0x1DD84)
    // BL &= 0x7;
    BL = Alu.And8(BL, 0x7);
    // JNZ 0x1000:ddae (1000_DD87 / 0x1DD87)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_DD89_1DD89:
    // TEST byte ptr [0x2942],0x80 (1000_DD89 / 0x1DD89)
    Alu.And8(UInt8[DS, 0x2942], 0x80);
    // JZ 0x1000:dd9e (1000_DD8E / 0x1DD8E)
    if(ZeroFlag) {
      goto label_1000_DD9E_1DD9E;
    }
    // PUSH DI (1000_DD90 / 0x1DD90)
    Stack.Push(DI);
    // CALL 0x1000:dce0 (1000_DD91 / 0x1DD91)
    NearCall(cs1, 0xDD94, read_game_port_ida_1000_DCE0_1DCE0);
    // POP DI (1000_DD94 / 0x1DD94)
    DI = Stack.Pop();
    // XCHG AX,DI (1000_DD95 / 0x1DD95)
    ushort tmp_1000_DD95 = AX;
    AX = DI;
    DI = tmp_1000_DD95;
    // XOR AX,DI (1000_DD96 / 0x1DD96)
    AX ^= DI;
    // AND AX,DI (1000_DD98 / 0x1DD98)
    AX &= DI;
    // AND AL,0x30 (1000_DD9A / 0x1DD9A)
    // AL &= 0x30;
    AL = Alu.And8(AL, 0x30);
    // JNZ 0x1000:ddae (1000_DD9C / 0x1DD9C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_DD9E_1DD9E:
    // PUSH SI (1000_DD9E / 0x1DD9E)
    Stack.Push(SI);
    // PUSH DI (1000_DD9F / 0x1DD9F)
    Stack.Push(DI);
    // CALL 0x1000:e3cc (1000_DDA0 / 0x1DDA0)
    NearCall(cs1, 0xDDA3, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDA3_01DDA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDA3_01DDA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDA3_1DDA3:
    // MOV [0x0],AX (1000_DDA3 / 0x1DDA3)
    UInt16[DS, 0x0] = AX;
    // CALL 0x1000:d9d2 (1000_DDA6 / 0x1DDA6)
    NearCall(cs1, 0xDDA9, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDA9_01DDA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDA9_01DDA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDA9_1DDA9:
    // POP DI (1000_DDA9 / 0x1DDA9)
    DI = Stack.Pop();
    // POP SI (1000_DDAA / 0x1DDAA)
    SI = Stack.Pop();
    // OR AL,0x1 (1000_DDAB / 0x1DDAB)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // RET  (1000_DDAD / 0x1DDAD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DDAE_01DDAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDAE_1DDAE:
    // STC  (1000_DDAE / 0x1DDAE)
    CarryFlag = true;
    // RET  (1000_DDAF / 0x1DDAF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DDB0_01DDB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDB0_1DDB0:
    // CALL 0x1000:e270 (1000_DDB0 / 0x1DDB0)
    NearCall(cs1, 0xDDB3, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDB3_01DDB3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDB3_01DDB3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDB3_1DDB3:
    // PUSH AX (1000_DDB3 / 0x1DDB3)
    Stack.Push(AX);
    // MOV byte ptr [0xcee8],0x0 (1000_DDB4 / 0x1DDB4)
    UInt8[DS, 0xCEE8] = 0x0;
    // CMP byte ptr [0x227d],0x0 (1000_DDB9 / 0x1DDB9)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:ddc3 (1000_DDBE / 0x1DDBE)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDC3_01DDC3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:d64e (1000_DDC0 / 0x1DDC0)
    NearCall(cs1, 0xDDC3, spice86_generated_label_call_target_1000_D64E_01D64E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDC3_01DDC3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDC3_01DDC3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDC3_1DDC3:
    // MOV SI,0xffff (1000_DDC3 / 0x1DDC3)
    SI = 0xFFFF;
    // MOV DI,SI (1000_DDC6 / 0x1DDC6)
    DI = SI;
    // POP CX (1000_DDC8 / 0x1DDC8)
    CX = Stack.Pop();
    // STI  (1000_DDC9 / 0x1DDC9)
    InterruptFlag = true;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDCA_01DDCA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DDCA_01DDCA(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDDE7: goto label_1000_DDE7_1DDE7;break; // Target of external jump from 0x1DDD4, 0x1DE4C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_DDCA_1DDCA:
    // PUSH word ptr [0xce7a] (1000_DDCA / 0x1DDCA)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // PUSH CX (1000_DDCE / 0x1DDCE)
    Stack.Push(CX);
    // CALL 0x1000:dd63 (1000_DDCF / 0x1DDCF)
    NearCall(cs1, 0xDDD2, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_DDD2_1DDD2:
    // POP CX (1000_DDD2 / 0x1DDD2)
    CX = Stack.Pop();
    // POP AX (1000_DDD3 / 0x1DDD3)
    AX = Stack.Pop();
    // JC 0x1000:dde7 (1000_DDD4 / 0x1DDD4)
    if(CarryFlag) {
      goto label_1000_DDE7_1DDE7;
    }
    // MOV BX,AX (1000_DDD6 / 0x1DDD6)
    BX = AX;
    label_1000_DDD8_1DDD8:
    // MOV AX,BX (1000_DDD8 / 0x1DDD8)
    AX = BX;
    // SUB AX,word ptr SS:[0xce7a] (1000_DDDA / 0x1DDDA)
    // AX -= UInt16[SS, 0xCE7A];
    AX = Alu.Sub16(AX, UInt16[SS, 0xCE7A]);
    // JZ 0x1000:ddd8 (1000_DDDF / 0x1DDDF)
    if(ZeroFlag) {
      goto label_1000_DDD8_1DDD8;
    }
    // ADD CX,AX (1000_DDE1 / 0x1DDE1)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // JC 0x1000:ddca (1000_DDE3 / 0x1DDE3)
    if(CarryFlag) {
      goto label_1000_DDCA_1DDCA;
    }
    // OR AL,0x1 (1000_DDE5 / 0x1DDE5)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    label_1000_DDE7_1DDE7:
    // PUSHF  (1000_DDE7 / 0x1DDE7)
    Stack.Push(FlagRegister);
    // CALL 0x1000:de4e (1000_DDE8 / 0x1DDE8)
    NearCall(cs1, 0xDDEB, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    label_1000_DDEB_1DDEB:
    // POPF  (1000_DDEB / 0x1DDEB)
    FlagRegister = Stack.Pop();
    // CALL 0x1000:e283 (1000_DDEC / 0x1DDEC)
    NearCall(cs1, 0xDDEF, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_DDEF_1DDEF:
    // RET  (1000_DDEF / 0x1DDEF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DDF0_01DDF0(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDE07: goto label_1000_DE07_1DE07;break; // Target of external jump from 0x1DE11, 0x1DDF5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_DDF0_1DDF0:
    // CMP byte ptr [0xdbcd],0x0 (1000_DDF0 / 0x1DDF0)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JS 0x1000:de07 (1000_DDF5 / 0x1DDF5)
    if(SignFlag) {
      goto label_1000_DE07_1DE07;
    }
    // CALL 0x1000:aba3 (1000_DDF7 / 0x1DDF7)
    NearCall(cs1, 0xDDFA, check_res_file_open_ida_1000_ABA3_1ABA3);
    // JZ 0x1000:ddb0 (1000_DDFA / 0x1DDFA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DDB0_01DDB0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_DDFC_1DDFC:
    // CALL 0x1000:aba3 (1000_DDFC / 0x1DDFC)
    NearCall(cs1, 0xDDFF, check_res_file_open_ida_1000_ABA3_1ABA3);
    // JZ 0x1000:de07 (1000_DDFF / 0x1DDFF)
    if(ZeroFlag) {
      goto label_1000_DE07_1DE07;
    }
    // CALL 0x1000:dd63 (1000_DE01 / 0x1DE01)
    NearCall(cs1, 0xDE04, spice86_generated_label_call_target_1000_DD63_01DD63);
    // JNC 0x1000:ddfc (1000_DE04 / 0x1DE04)
    if(!CarryFlag) {
      goto label_1000_DDFC_1DDFC;
    }
    // RET  (1000_DE06 / 0x1DE06)
    return NearRet();
    label_1000_DE07_1DE07:
    // PUSH AX (1000_DE07 / 0x1DE07)
    Stack.Push(AX);
    // OR AL,0x1 (1000_DE08 / 0x1DE08)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // POP AX (1000_DE0A / 0x1DE0A)
    AX = Stack.Pop();
    // RET  (1000_DE0B / 0x1DE0B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE0C_01DE0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE0C_1DE0C:
    // CMP byte ptr [0xdbcd],0x0 (1000_DE0C / 0x1DE0C)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JNS 0x1000:de07 (1000_DE11 / 0x1DE11)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DDF0_01DDF0, 0x1DE07 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:e270 (1000_DE13 / 0x1DE13)
    NearCall(cs1, 0xDE16, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DE16_01DE16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DE16_01DE16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE16_1DE16:
    // MOV byte ptr [0xcee8],0x0 (1000_DE16 / 0x1DE16)
    UInt8[DS, 0xCEE8] = 0x0;
    // MOV SI,0xffff (1000_DE1B / 0x1DE1B)
    SI = 0xFFFF;
    // MOV DI,SI (1000_DE1E / 0x1DE1E)
    DI = SI;
    label_1000_DE20_1DE20:
    // MOV AX,0x60 (1000_DE20 / 0x1DE20)
    AX = 0x60;
    // SUB AX,word ptr [0xdbd0] (1000_DE23 / 0x1DE23)
    AX -= UInt16[DS, 0xDBD0];
    // XOR AH,AH (1000_DE27 / 0x1DE27)
    AH = 0;
    // MOV DL,0x6 (1000_DE29 / 0x1DE29)
    DL = 0x6;
    // DIV DL (1000_DE2B / 0x1DE2B)
    Cpu.Div8(DL);
    // AND AL,0xf (1000_DE2D / 0x1DE2D)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // MOV DX,word ptr [0xdbce] (1000_DE2F / 0x1DE2F)
    DX = UInt16[DS, 0xDBCE];
    // SHL DX,1 (1000_DE33 / 0x1DE33)
    DX <<= 0x1;
    // SHL DX,1 (1000_DE35 / 0x1DE35)
    DX <<= 0x1;
    // SHL DX,1 (1000_DE37 / 0x1DE37)
    DX <<= 0x1;
    // SHL DX,1 (1000_DE39 / 0x1DE39)
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    // OR DL,AL (1000_DE3B / 0x1DE3B)
    DL |= AL;
    // CMP BX,DX (1000_DE3D / 0x1DE3D)
    Alu.Sub16(BX, DX);
    // JBE 0x1000:de4a (1000_DE3F / 0x1DE3F)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_DE4A_1DE4A;
    }
    // PUSH BX (1000_DE41 / 0x1DE41)
    Stack.Push(BX);
    // CALL 0x1000:dd63 (1000_DE42 / 0x1DE42)
    NearCall(cs1, 0xDE45, spice86_generated_label_call_target_1000_DD63_01DD63);
    // POP BX (1000_DE45 / 0x1DE45)
    BX = Stack.Pop();
    // JC 0x1000:dde7 (1000_DE46 / 0x1DE46)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDCA_01DDCA, 0x1DDE7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:de20 (1000_DE48 / 0x1DE48)
    goto label_1000_DE20_1DE20;
    label_1000_DE4A_1DE4A:
    // OR AL,0x1 (1000_DE4A / 0x1DE4A)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // JMP 0x1000:dde7 (1000_DE4C / 0x1DE4C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDCA_01DDCA, 0x1DDE7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE4E_01DE4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE4E_1DE4E:
    // MOV byte ptr [0xcee8],0x0 (1000_DE4E / 0x1DE4E)
    UInt8[DS, 0xCEE8] = 0x0;
    // RET  (1000_DE53 / 0x1DE53)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE54_01DE54(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE54_1DE54:
    // MOV byte ptr [0xcee9],0x0 (1000_DE54 / 0x1DE54)
    UInt8[DS, 0xCEE9] = 0x0;
    // CMP byte ptr [0xcee8],0x1 (1000_DE59 / 0x1DE59)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x1);
    // JNZ 0x1000:de67 (1000_DE5E / 0x1DE5E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DE67 / 0x1DE67)
      return NearRet();
    }
    // MOV byte ptr [0xcee9],0x1 (1000_DE60 / 0x1DE60)
    UInt8[DS, 0xCEE9] = 0x1;
    // JMP 0x1000:de4e (1000_DE65 / 0x1DE65)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_DE67_1DE67:
    // RET  (1000_DE67 / 0x1DE67)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE68_01DE68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE68_1DE68:
    // CALL 0x1000:dd5a (1000_DE68 / 0x1DE68)
    NearCall(cs1, 0xDE6B, spice86_generated_label_call_target_1000_DD5A_01DD5A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DE6B_01DE6B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DE6B_01DE6B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE6B_1DE6B:
    // JNZ 0x1000:de68 (1000_DE6B / 0x1DE6B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE68_01DE68, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:f08e (1000_DE6D / 0x1DE6D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F08E_01F08E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE7B_01DE7B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDE7A: break; // Instructions before entry targeted by 0x1DE80
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_DE7A_1DE7A:
    // RET  (1000_DE7A / 0x1DE7A)
    return NearRet();
    entry:
    label_1000_DE7B_1DE7B:
    // CMP byte ptr [0xce9a],0x0 (1000_DE7B / 0x1DE7B)
    Alu.Sub8(UInt8[DS, 0xCE9A], 0x0);
    // JZ 0x1000:de7a (1000_DE80 / 0x1DE80)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DE7A / 0x1DE7A)
      return NearRet();
    }
    // CMP byte ptr [0xce80],0x0 (1000_DE82 / 0x1DE82)
    Alu.Sub8(UInt8[DS, 0xCE80], 0x0);
    // JZ 0x1000:de7a (1000_DE87 / 0x1DE87)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DE7A / 0x1DE7A)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_DE89 / 0x1DE89)
    NearCall(cs1, 0xDE8C, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DE8C_01DE8C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DE8C_01DE8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DE8C_1DE8C:
    // MOV AL,0x1 (1000_DE8C / 0x1DE8C)
    AL = 0x1;
    // XCHG byte ptr [0x2788],AL (1000_DE8E / 0x1DE8E)
    byte tmp_1000_DE8E = UInt8[DS, 0x2788];
    UInt8[DS, 0x2788] = AL;
    AL = tmp_1000_DE8E;
    // PUSH AX (1000_DE92 / 0x1DE92)
    Stack.Push(AX);
    // PUSH word ptr [0xce7a] (1000_DE93 / 0x1DE93)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // CALL 0x1000:dbb2 (1000_DE97 / 0x1DE97)
    NearCall(cs1, 0xDE9A, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_DE9A_1DE9A:
    // PUSH word ptr [0xdbda] (1000_DE9A / 0x1DE9A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_DE9E / 0x1DE9E)
    NearCall(cs1, 0xDEA1, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DEA1_01DEA1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DEA1_01DEA1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DEA1_1DEA1:
    // PUSH word ptr [0xdbd6] (1000_DEA1 / 0x1DEA1)
    Stack.Push(UInt16[DS, 0xDBD6]);
    // CALLF [0x38b9] (1000_DEA5 / 0x1DEA5)
    // Indirect call to [0x38b9], generating possible targets from emulator records
    uint targetAddress_1000_DEA5 = (uint)(UInt16[DS, 0x38BB] * 0x10 + UInt16[DS, 0x38B9] - cs1 * 0x10);
    switch(targetAddress_1000_DEA5) {
      case 0x235B3 : FarCall(cs1, 0xDEA9, spice86_generated_label_call_target_334B_0103_0335B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DEA5));
        break;
    }
    label_1000_DEA9_1DEA9:
    // MOV [0xdbd6],AX (1000_DEA9 / 0x1DEA9)
    UInt16[DS, 0xDBD6] = AX;
    // MOV SI,0x2945 (1000_DEAC / 0x1DEAC)
    SI = 0x2945;
    // CALL 0x1000:7b1b (1000_DEAF / 0x1DEAF)
    NearCall(cs1, 0xDEB2, spice86_generated_label_call_target_1000_7B1B_017B1B);
    label_1000_DEB2_1DEB2:
    // MOV CX,0xf1fe (1000_DEB2 / 0x1DEB2)
    CX = 0xF1FE;
    // MOV DX,0x82 (1000_DEB5 / 0x1DEB5)
    DX = 0x82;
    // MOV BX,0xa9 (1000_DEB8 / 0x1DEB8)
    BX = 0xA9;
    // MOV AX,0x115 (1000_DEBB / 0x1DEBB)
    AX = 0x115;
    // CALL 0x1000:d068 (1000_DEBE / 0x1DEBE)
    NearCall(cs1, 0xDEC1, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DEC1_01DEC1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DEC1_01DEC1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DEC1_1DEC1:
    // CALL 0x1000:d194 (1000_DEC1 / 0x1DEC1)
    NearCall(cs1, 0xDEC4, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_DEC4_1DEC4:
    // CALL 0x1000:d075 (1000_DEC4 / 0x1DEC4)
    NearCall(cs1, 0xDEC7, spice86_generated_label_call_target_1000_D075_01D075);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DEC7_01DEC7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DEC7_01DEC7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DEC7_1DEC7:
    // MOV DX,0x60 (1000_DEC7 / 0x1DEC7)
    DX = 0x60;
    // MOV BX,0xb8 (1000_DECA / 0x1DECA)
    BX = 0xB8;
    // MOV AX,0x116 (1000_DECD / 0x1DECD)
    AX = 0x116;
    // MOV CX,0xf1f7 (1000_DED0 / 0x1DED0)
    CX = 0xF1F7;
    // CALL 0x1000:d194 (1000_DED3 / 0x1DED3)
    NearCall(cs1, 0xDED6, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_DED6_1DED6:
    // CMP byte ptr [0xce9a],0x0 (1000_DED6 / 0x1DED6)
    Alu.Sub8(UInt8[DS, 0xCE9A], 0x0);
    // JNZ 0x1000:ded6 (1000_DEDB / 0x1DEDB)
    if(!ZeroFlag) {
      goto label_1000_DED6_1DED6;
    }
    // CALL 0x1000:de68 (1000_DEDD / 0x1DEDD)
    NearCall(cs1, 0xDEE0, spice86_generated_label_call_target_1000_DE68_01DE68);
    label_1000_DEE0_1DEE0:
    // CALL 0x1000:dd5a (1000_DEE0 / 0x1DEE0)
    NearCall(cs1, 0xDEE3, spice86_generated_label_call_target_1000_DD5A_01DD5A);
    label_1000_DEE3_1DEE3:
    // JZ 0x1000:dee0 (1000_DEE3 / 0x1DEE3)
    if(ZeroFlag) {
      goto label_1000_DEE0_1DEE0;
    }
    // PUSH AX (1000_DEE5 / 0x1DEE5)
    Stack.Push(AX);
    // CALL 0x1000:de68 (1000_DEE6 / 0x1DEE6)
    NearCall(cs1, 0xDEE9, spice86_generated_label_call_target_1000_DE68_01DE68);
    label_1000_DEE9_1DEE9:
    // CALL 0x1000:df07 (1000_DEE9 / 0x1DEE9)
    NearCall(cs1, 0xDEEC, spice86_generated_label_call_target_1000_DF07_01DF07);
    label_1000_DEEC_1DEEC:
    // POP AX (1000_DEEC / 0x1DEEC)
    AX = Stack.Pop();
    // DEC AL (1000_DEED / 0x1DEED)
    AL = Alu.Dec8(AL);
    // JZ 0x1000:dee0 (1000_DEEF / 0x1DEEF)
    if(ZeroFlag) {
      goto label_1000_DEE0_1DEE0;
    }
    // POP word ptr [0xdbd6] (1000_DEF1 / 0x1DEF1)
    UInt16[DS, 0xDBD6] = Stack.Pop();
    // POP word ptr [0xdbda] (1000_DEF5 / 0x1DEF5)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // POP word ptr [0xce7a] (1000_DEF9 / 0x1DEF9)
    UInt16[DS, 0xCE7A] = Stack.Pop();
    // POP AX (1000_DEFD / 0x1DEFD)
    AX = Stack.Pop();
    // MOV [0x2788],AL (1000_DEFE / 0x1DEFE)
    UInt8[DS, 0x2788] = AL;
    // CALL 0x1000:e283 (1000_DF01 / 0x1DF01)
    NearCall(cs1, 0xDF04, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_DF04_1DF04:
    // XOR AX,AX (1000_DF04 / 0x1DF04)
    AX = 0;
    // RET  (1000_DF06 / 0x1DF06)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DF07_01DF07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DF07_1DF07:
    // PUSH word ptr [0x2784] (1000_DF07 / 0x1DF07)
    Stack.Push(UInt16[DS, 0x2784]);
    // MOV SI,0x1b48 (1000_DF0B / 0x1DF0B)
    SI = 0x1B48;
    // MOV CX,0x5 (1000_DF0E / 0x1DF0E)
    CX = 0x5;
    // CALL 0x1000:d1f2 (1000_DF11 / 0x1DF11)
    NearCall(cs1, 0xDF14, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DF14_01DF14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DF14_01DF14(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DF14_1DF14:
    // POP AX (1000_DF14 / 0x1DF14)
    AX = Stack.Pop();
    // CALL 0x1000:c13e (1000_DF15 / 0x1DF15)
    NearCall(cs1, 0xDF18, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_DF18_1DF18:
    // CALL 0x1000:d397 (1000_DF18 / 0x1DF18)
    NearCall(cs1, 0xDF1B, spice86_generated_label_call_target_1000_D397_01D397);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DF1B_01DF1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DF1B_01DF1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DF1B_1DF1B:
    // JMP 0x1000:dbec (1000_DF1B / 0x1DF1B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DF1E_01DF1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DF1E_1DF1E:
    // CALL 0x1000:de7b (1000_DF1E / 0x1DF1E)
    NearCall(cs1, 0xDF21, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DF21_01DF21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DF21_01DF21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DF21_1DF21:
    // XOR AL,AL (1000_DF21 / 0x1DF21)
    AL = 0;
    // TEST byte ptr [0x2942],0x40 (1000_DF23 / 0x1DF23)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    // JNZ 0x1000:df49 (1000_DF28 / 0x1DF28)
    if(!ZeroFlag) {
      goto label_1000_DF49_1DF49;
    }
    // MOV AX,0x3 (1000_DF2A / 0x1DF2A)
    AX = 0x3;
    // INT 0x33 (1000_DF2D / 0x1DF2D)
    Interrupt(0x33);
    // MOV AX,CX (1000_DF2F / 0x1DF2F)
    AX = CX;
    // MOV CX,word ptr [0x2580] (1000_DF31 / 0x1DF31)
    CX = UInt16[DS, 0x2580];
    // SHR AX,CL (1000_DF35 / 0x1DF35)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV CL,CH (1000_DF37 / 0x1DF37)
    CL = CH;
    // SHR DX,CL (1000_DF39 / 0x1DF39)
    // DX >>= CL;
    DX = Alu.Shr16(DX, CL);
    // MOV CX,AX (1000_DF3B / 0x1DF3B)
    CX = AX;
    // MOV AL,BL (1000_DF3D / 0x1DF3D)
    AL = BL;
    // AND AL,0x3 (1000_DF3F / 0x1DF3F)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    // MOV word ptr [0xdc36],CX (1000_DF41 / 0x1DF41)
    UInt16[DS, 0xDC36] = CX;
    // MOV word ptr [0xdc38],DX (1000_DF45 / 0x1DF45)
    UInt16[DS, 0xDC38] = DX;
    label_1000_DF49_1DF49:
    // MOV [0xdc34],AL (1000_DF49 / 0x1DF49)
    UInt8[DS, 0xDC34] = AL;
    // TEST byte ptr [0x2942],0x80 (1000_DF4C / 0x1DF4C)
    Alu.And8(UInt8[DS, 0x2942], 0x80);
    // JZ 0x1000:df56 (1000_DF51 / 0x1DF51)
    if(ZeroFlag) {
      goto label_1000_DF56_1DF56;
    }
    // CALL 0x1000:dd10 (1000_DF53 / 0x1DF53)
    NearCall(cs1, 0xDF56, not_observed_1000_DD10_01DD10);
    label_1000_DF56_1DF56:
    // MOV SI,0xcec8 (1000_DF56 / 0x1DF56)
    SI = 0xCEC8;
    // MOV DI,word ptr [0xdc48] (1000_DF59 / 0x1DF59)
    DI = UInt16[DS, 0xDC48];
    // XOR DX,DX (1000_DF5D / 0x1DF5D)
    DX = 0;
    // MOV BX,DX (1000_DF5F / 0x1DF5F)
    BX = DX;
    // MOV AX,DX (1000_DF61 / 0x1DF61)
    AX = DX;
    // MOV CX,0xd (1000_DF63 / 0x1DF63)
    CX = 0xD;
    label_1000_DF66_1DF66:
    // LODSB SI (1000_DF66 / 0x1DF66)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,byte ptr [SI + 0x12] (1000_DF67 / 0x1DF67)
    // AL |= UInt8[DS, (ushort)(SI + 0x12)];
    AL = Alu.Or8(AL, UInt8[DS, (ushort)(SI + 0x12)]);
    // JZ 0x1000:df74 (1000_DF6A / 0x1DF6A)
    if(ZeroFlag) {
      goto label_1000_DF74_1DF74;
    }
    // OR AH,byte ptr [DI] (1000_DF6C / 0x1DF6C)
    AH |= UInt8[DS, DI];
    // ADD DX,word ptr [DI + 0x2] (1000_DF6E / 0x1DF6E)
    DX += UInt16[DS, (ushort)(DI + 0x2)];
    // ADD BX,word ptr [DI + 0x4] (1000_DF71 / 0x1DF71)
    BX += UInt16[DS, (ushort)(DI + 0x4)];
    label_1000_DF74_1DF74:
    // ADD DI,0x6 (1000_DF74 / 0x1DF74)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    // LOOP 0x1000:df66 (1000_DF77 / 0x1DF77)
    if(--CX != 0) {
      goto label_1000_DF66_1DF66;
    }
    // MOV AL,[0xceba] (1000_DF79 / 0x1DF79)
    AL = UInt8[DS, 0xCEBA];
    // OR AL,byte ptr [0xce9d] (1000_DF7C / 0x1DF7C)
    // AL |= UInt8[DS, 0xCE9D];
    AL = Alu.Or8(AL, UInt8[DS, 0xCE9D]);
    // OR AL,byte ptr [0xcee6] (1000_DF80 / 0x1DF80)
    AL |= UInt8[DS, 0xCEE6];
    // AND AL,0x1 (1000_DF84 / 0x1DF84)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    // MOV AH,AL (1000_DF86 / 0x1DF86)
    AH = AL;
    // XCHG byte ptr [0xdc57],AL (1000_DF88 / 0x1DF88)
    byte tmp_1000_DF88 = UInt8[DS, 0xDC57];
    UInt8[DS, 0xDC57] = AL;
    AL = tmp_1000_DF88;
    // NOT AL (1000_DF8C / 0x1DF8C)
    AL = (byte)~AL;
    // AND AL,byte ptr [0xdc34] (1000_DF8E / 0x1DF8E)
    // AL &= UInt8[DS, 0xDC34];
    AL = Alu.And8(AL, UInt8[DS, 0xDC34]);
    // OR AL,AH (1000_DF92 / 0x1DF92)
    // AL |= AH;
    AL = Alu.Or8(AL, AH);
    // MOV [0xdc34],AL (1000_DF94 / 0x1DF94)
    UInt8[DS, 0xDC34] = AL;
    // MOV AX,DX (1000_DF97 / 0x1DF97)
    AX = DX;
    // OR AX,BX (1000_DF99 / 0x1DF99)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    // JNZ 0x1000:dfb7 (1000_DF9B / 0x1DF9B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_DFB7_01DFB7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV [0xdc51],AX (1000_DF9D / 0x1DF9D)
    UInt16[DS, 0xDC51] = AX;
    // MOV [0xdc53],AX (1000_DFA0 / 0x1DFA0)
    UInt16[DS, 0xDC53] = AX;
    // MOV [0xdc55],AX (1000_DFA3 / 0x1DFA3)
    UInt16[DS, 0xDC55] = AX;
    label_1000_DFA6_1DFA6:
    // RET  (1000_DFA6 / 0x1DFA6)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_DFB7_01DFB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DFB7_1DFB7:
    // CMP byte ptr [0xce9e],0xff (1000_DFB7 / 0x1DFB7)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    // JNZ 0x1000:dfc1 (1000_DFBC / 0x1DFBC)
    if(!ZeroFlag) {
      goto label_1000_DFC1_1DFC1;
    }
    // JMP 0x1000:e1d1 (1000_DFBE / 0x1DFBE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_E1D1_01E1D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_DFC1_1DFC1:
    // MOV DI,0xdfa9 (1000_DFC1 / 0x1DFC1)
    DI = 0xDFA9;
    // OR DL,DL (1000_DFC4 / 0x1DFC4)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:dfdb (1000_DFC6 / 0x1DFC6)
    if(ZeroFlag) {
      goto label_1000_DFDB_1DFDB;
    }
    // JNS 0x1000:dfcd (1000_DFC8 / 0x1DFC8)
    if(!SignFlag) {
      goto label_1000_DFCD_1DFCD;
    }
    // ADD DI,0x6 (1000_DFCA / 0x1DFCA)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    label_1000_DFCD_1DFCD:
    // OR BL,BL (1000_DFCD / 0x1DFCD)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:dfe7 (1000_DFCF / 0x1DFCF)
    if(ZeroFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    // LEA DI,[DI + -0x2] (1000_DFD1 / 0x1DFD1)
    DI = (ushort)(DI - 0x2);
    // JS 0x1000:dfe7 (1000_DFD4 / 0x1DFD4)
    if(SignFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    // ADD DI,0x4 (1000_DFD6 / 0x1DFD6)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    // JMP 0x1000:dfe7 (1000_DFD9 / 0x1DFD9)
    goto label_1000_DFE7_1DFE7;
    label_1000_DFDB_1DFDB:
    // MOV DI,0xdfb3 (1000_DFDB / 0x1DFDB)
    DI = 0xDFB3;
    // OR BL,BL (1000_DFDE / 0x1DFDE)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:dfa6 (1000_DFE0 / 0x1DFE0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DFA6 / 0x1DFA6)
      return NearRet();
    }
    // JS 0x1000:dfe7 (1000_DFE2 / 0x1DFE2)
    if(SignFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    // ADD DI,0x2 (1000_DFE4 / 0x1DFE4)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    label_1000_DFE7_1DFE7:
    // MOV BX,word ptr CS:[DI] (1000_DFE7 / 0x1DFE7)
    BX = UInt16[cs1, DI];
    // SUB SP,0xa (1000_DFEA / 0x1DFEA)
    // SP -= 0xA;
    SP = Alu.Sub16(SP, 0xA);
    // MOV BP,SP (1000_DFED / 0x1DFED)
    BP = SP;
    // MOV word ptr [BP + 0x0],BX (1000_DFEF / 0x1DFEF)
    UInt16[SS, BP] = BX;
    // CALL 0x1000:de4e (1000_DFF2 / 0x1DFF2)
    NearCall(cs1, 0xDFF5, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    // MOV DX,word ptr [0xdc36] (1000_DFF5 / 0x1DFF5)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DFF9 / 0x1DFF9)
    BX = UInt16[DS, 0xDC38];
    // MOV DI,0x1ae4 (1000_DFFD / 0x1DFFD)
    DI = 0x1AE4;
    // MOV CX,word ptr [DI] (1000_E000 / 0x1E000)
    CX = UInt16[DS, DI];
    // MOV word ptr [BP + 0x2],0x8000 (1000_E002 / 0x1E002)
    UInt16[SS, (ushort)(BP + 0x2)] = 0x8000;
    // ADD DI,0x2 (1000_E007 / 0x1E007)
    DI += 0x2;
    label_1000_E00A_1E00A:
    // TEST byte ptr [DI + 0x8],0x80 (1000_E00A / 0x1E00A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x8)], 0x80);
    // JZ 0x1000:e02c (1000_E00E / 0x1E00E)
    if(ZeroFlag) {
      goto label_1000_E02C_1E02C;
    }
    // CALL 0x1000:d6fe (1000_E010 / 0x1E010)
    NearCall(cs1, 0xE013, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JC 0x1000:e02c (1000_E013 / 0x1E013)
    if(CarryFlag) {
      goto label_1000_E02C_1E02C;
    }
    // CALL 0x1000:e159 (1000_E015 / 0x1E015)
    NearCall(cs1, 0xE018, not_observed_1000_E159_01E159);
    // CALL word ptr [BP + 0x0] (1000_E018 / 0x1E018)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E018 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E018) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E018));
        break;
    }
    // CMP AX,word ptr [BP + 0x2] (1000_E01B / 0x1E01B)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    // JNC 0x1000:e02c (1000_E01E / 0x1E01E)
    if(!CarryFlag) {
      goto label_1000_E02C_1E02C;
    }
    // MOV word ptr [BP + 0x2],AX (1000_E020 / 0x1E020)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // CALL 0x1000:e159 (1000_E023 / 0x1E023)
    NearCall(cs1, 0xE026, not_observed_1000_E159_01E159);
    // MOV word ptr [BP + 0x4],AX (1000_E026 / 0x1E026)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV word ptr [BP + 0x6],SI (1000_E029 / 0x1E029)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    label_1000_E02C_1E02C:
    // ADD DI,0xe (1000_E02C / 0x1E02C)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    // LOOP 0x1000:e00a (1000_E02F / 0x1E02F)
    if(--CX != 0) {
      goto label_1000_E00A_1E00A;
    }
    // CALL 0x1000:e068 (1000_E031 / 0x1E031)
    NearCall(cs1, 0xE034, not_observed_1000_E068_01E068);
    // CALL 0x1000:e0a2 (1000_E034 / 0x1E034)
    NearCall(cs1, 0xE037, not_observed_1000_E0A2_01E0A2);
    // CALL 0x1000:e0db (1000_E037 / 0x1E037)
    NearCall(cs1, 0xE03A, not_observed_1000_E0DB_01E0DB);
    // CALL 0x1000:e11c (1000_E03A / 0x1E03A)
    NearCall(cs1, 0xE03D, not_observed_1000_E11C_01E11C);
    // CMP word ptr [BP + 0x2],0x0 (1000_E03D / 0x1E03D)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], 0x0);
    // JS 0x1000:e064 (1000_E041 / 0x1E041)
    if(SignFlag) {
      goto label_1000_E064_1E064;
    }
    // MOV byte ptr [0xceba],0x0 (1000_E043 / 0x1E043)
    UInt8[DS, 0xCEBA] = 0x0;
    // OR byte ptr [0xce9d],0x0 (1000_E048 / 0x1E048)
    // UInt8[DS, 0xCE9D] |= 0x0;
    UInt8[DS, 0xCE9D] = Alu.Or8(UInt8[DS, 0xCE9D], 0x0);
    // MOV AX,word ptr [BP + 0x4] (1000_E04D / 0x1E04D)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV [0xdc4c],AX (1000_E050 / 0x1E050)
    UInt16[DS, 0xDC4C] = AX;
    // MOV AX,word ptr [BP + 0x6] (1000_E053 / 0x1E053)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // MOV [0xdc4e],AX (1000_E056 / 0x1E056)
    UInt16[DS, 0xDC4E] = AX;
    // MOV byte ptr [0xdc4b],0x64 (1000_E059 / 0x1E059)
    UInt8[DS, 0xDC4B] = 0x64;
    // MOV AX,[0xce7a] (1000_E05E / 0x1E05E)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc4a],AL (1000_E061 / 0x1E061)
    UInt8[DS, 0xDC4A] = AL;
    label_1000_E064_1E064:
    // ADD SP,0xa (1000_E064 / 0x1E064)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    // RET  (1000_E067 / 0x1E067)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E068_01E068(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E068_1E068:
    // PUSH BP (1000_E068 / 0x1E068)
    Stack.Push(BP);
    // CALL 0x1000:d41b (1000_E069 / 0x1E069)
    NearCall(cs1, 0xE06C, spice86_generated_label_call_target_1000_D41B_01D41B);
    // CMP BP,0x201a (1000_E06C / 0x1E06C)
    Alu.Sub16(BP, 0x201A);
    // POP BP (1000_E070 / 0x1E070)
    BP = Stack.Pop();
    // JNZ 0x1000:e0a1 (1000_E071 / 0x1E071)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_E0A1 / 0x1E0A1)
      return NearRet();
    }
    // MOV DI,0x28e9 (1000_E073 / 0x1E073)
    DI = 0x28E9;
    label_1000_E076_1E076:
    // MOV SI,word ptr [DI + 0x2] (1000_E076 / 0x1E076)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV AX,word ptr [DI] (1000_E079 / 0x1E079)
    AX = UInt16[DS, DI];
    // CMP AX,DX (1000_E07B / 0x1E07B)
    Alu.Sub16(AX, DX);
    // JNZ 0x1000:e083 (1000_E07D / 0x1E07D)
    if(!ZeroFlag) {
      goto label_1000_E083_1E083;
    }
    // CMP SI,BX (1000_E07F / 0x1E07F)
    Alu.Sub16(SI, BX);
    // JZ 0x1000:e099 (1000_E081 / 0x1E081)
    if(ZeroFlag) {
      goto label_1000_E099_1E099;
    }
    label_1000_E083_1E083:
    // CALL word ptr [BP + 0x0] (1000_E083 / 0x1E083)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E083 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E083) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E083));
        break;
    }
    // CMP AX,word ptr [BP + 0x2] (1000_E086 / 0x1E086)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    // JNC 0x1000:e099 (1000_E089 / 0x1E089)
    if(!CarryFlag) {
      goto label_1000_E099_1E099;
    }
    // MOV word ptr [BP + 0x2],AX (1000_E08B / 0x1E08B)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // MOV AX,word ptr [DI] (1000_E08E / 0x1E08E)
    AX = UInt16[DS, DI];
    // MOV word ptr [BP + 0x4],AX (1000_E090 / 0x1E090)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV SI,word ptr [DI + 0x2] (1000_E093 / 0x1E093)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV word ptr [BP + 0x6],SI (1000_E096 / 0x1E096)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    label_1000_E099_1E099:
    // ADD DI,0x4 (1000_E099 / 0x1E099)
    DI += 0x4;
    // CMP word ptr [DI],-0x1 (1000_E09C / 0x1E09C)
    Alu.Sub16(UInt16[DS, DI], 0xFFFF);
    // JNZ 0x1000:e076 (1000_E09F / 0x1E09F)
    if(!ZeroFlag) {
      goto label_1000_E076_1E076;
    }
    label_1000_E0A1_1E0A1:
    // RET  (1000_E0A1 / 0x1E0A1)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E0A2_01E0A2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E0A2_1E0A2:
    // CMP byte ptr [0x46eb],0x0 (1000_E0A2 / 0x1E0A2)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:e0da (1000_E0A7 / 0x1E0A7)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    // MOV DI,0x3cbe (1000_E0A9 / 0x1E0A9)
    DI = 0x3CBE;
    // MOV CX,word ptr [DI] (1000_E0AC / 0x1E0AC)
    CX = UInt16[DS, DI];
    // JCXZ 0x1000:e0da (1000_E0AE / 0x1E0AE)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    // ADD DI,0x2 (1000_E0B0 / 0x1E0B0)
    DI += 0x2;
    label_1000_E0B3_1E0B3:
    // TEST byte ptr [DI + 0xc],0xc0 (1000_E0B3 / 0x1E0B3)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0xC0);
    // JNZ 0x1000:e0d5 (1000_E0B7 / 0x1E0B7)
    if(!ZeroFlag) {
      goto label_1000_E0D5_1E0D5;
    }
    // CALL 0x1000:d6fe (1000_E0B9 / 0x1E0B9)
    NearCall(cs1, 0xE0BC, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JC 0x1000:e0d5 (1000_E0BC / 0x1E0BC)
    if(CarryFlag) {
      goto label_1000_E0D5_1E0D5;
    }
    // CALL 0x1000:e159 (1000_E0BE / 0x1E0BE)
    NearCall(cs1, 0xE0C1, not_observed_1000_E159_01E159);
    // CALL word ptr [BP + 0x0] (1000_E0C1 / 0x1E0C1)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E0C1 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E0C1) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E0C1));
        break;
    }
    // CMP AX,word ptr [BP + 0x2] (1000_E0C4 / 0x1E0C4)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    // JNC 0x1000:e0d5 (1000_E0C7 / 0x1E0C7)
    if(!CarryFlag) {
      goto label_1000_E0D5_1E0D5;
    }
    // MOV word ptr [BP + 0x2],AX (1000_E0C9 / 0x1E0C9)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // CALL 0x1000:e159 (1000_E0CC / 0x1E0CC)
    NearCall(cs1, 0xE0CF, not_observed_1000_E159_01E159);
    // MOV word ptr [BP + 0x4],AX (1000_E0CF / 0x1E0CF)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV word ptr [BP + 0x6],SI (1000_E0D2 / 0x1E0D2)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    label_1000_E0D5_1E0D5:
    // ADD DI,0x11 (1000_E0D5 / 0x1E0D5)
    // DI += 0x11;
    DI = Alu.Add16(DI, 0x11);
    // LOOP 0x1000:e0b3 (1000_E0D8 / 0x1E0D8)
    if(--CX != 0) {
      goto label_1000_E0B3_1E0B3;
    }
    label_1000_E0DA_1E0DA:
    // RET  (1000_E0DA / 0x1E0DA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E0DB_01E0DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E0DB_1E0DB:
    // CMP byte ptr [0x46eb],0x0 (1000_E0DB / 0x1E0DB)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JZ 0x1000:e0da (1000_E0E0 / 0x1E0E0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    // MOV DI,0xa5c0 (1000_E0E2 / 0x1E0E2)
    DI = 0xA5C0;
    label_1000_E0E5_1E0E5:
    // CMP word ptr [DI],0x0 (1000_E0E5 / 0x1E0E5)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    // JZ 0x1000:e0da (1000_E0E8 / 0x1E0E8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    // MOV SI,word ptr [DI + 0x4] (1000_E0EA / 0x1E0EA)
    SI = UInt16[DS, (ushort)(DI + 0x4)];
    // AND SI,0xff (1000_E0ED / 0x1E0ED)
    // SI &= 0xFF;
    SI = Alu.And16(SI, 0xFF);
    // MOV AX,word ptr [DI + 0x2] (1000_E0F1 / 0x1E0F1)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    // CMP AX,DX (1000_E0F4 / 0x1E0F4)
    Alu.Sub16(AX, DX);
    // JNZ 0x1000:e0fc (1000_E0F6 / 0x1E0F6)
    if(!ZeroFlag) {
      goto label_1000_E0FC_1E0FC;
    }
    // CMP SI,BX (1000_E0F8 / 0x1E0F8)
    Alu.Sub16(SI, BX);
    // JZ 0x1000:e117 (1000_E0FA / 0x1E0FA)
    if(ZeroFlag) {
      goto label_1000_E117_1E117;
    }
    label_1000_E0FC_1E0FC:
    // CALL word ptr [BP + 0x0] (1000_E0FC / 0x1E0FC)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E0FC = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E0FC) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E0FC));
        break;
    }
    // CMP AX,word ptr [BP + 0x2] (1000_E0FF / 0x1E0FF)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    // JNC 0x1000:e117 (1000_E102 / 0x1E102)
    if(!CarryFlag) {
      goto label_1000_E117_1E117;
    }
    // MOV word ptr [BP + 0x2],AX (1000_E104 / 0x1E104)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // MOV AX,word ptr [DI + 0x2] (1000_E107 / 0x1E107)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV word ptr [BP + 0x4],AX (1000_E10A / 0x1E10A)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV SI,word ptr [DI + 0x4] (1000_E10D / 0x1E10D)
    SI = UInt16[DS, (ushort)(DI + 0x4)];
    // AND SI,0xff (1000_E110 / 0x1E110)
    // SI &= 0xFF;
    SI = Alu.And16(SI, 0xFF);
    // MOV word ptr [BP + 0x6],SI (1000_E114 / 0x1E114)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    label_1000_E117_1E117:
    // ADD DI,0x6 (1000_E117 / 0x1E117)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    // JMP 0x1000:e0e5 (1000_E11A / 0x1E11A)
    goto label_1000_E0E5_1E0E5;
  }
  
  public virtual Action not_observed_1000_E11C_01E11C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E11C_1E11C:
    // TEST byte ptr [0x46eb],0x1 (1000_E11C / 0x1E11C)
    Alu.And8(UInt8[DS, 0x46EB], 0x1);
    // JZ 0x1000:e0da (1000_E121 / 0x1E121)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    // CMP word ptr [0x4749],0x0 (1000_E123 / 0x1E123)
    Alu.Sub16(UInt16[DS, 0x4749], 0x0);
    // JZ 0x1000:e0da (1000_E128 / 0x1E128)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    // MOV DI,0x2462 (1000_E12A / 0x1E12A)
    DI = 0x2462;
    // MOV CX,0x8 (1000_E12D / 0x1E12D)
    CX = 0x8;
    label_1000_E130_1E130:
    // MOV AX,word ptr [DI] (1000_E130 / 0x1E130)
    AX = UInt16[DS, DI];
    // MOV SI,word ptr [DI + 0x2] (1000_E132 / 0x1E132)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    // CMP AX,DX (1000_E135 / 0x1E135)
    Alu.Sub16(AX, DX);
    // JNZ 0x1000:e13d (1000_E137 / 0x1E137)
    if(!ZeroFlag) {
      goto label_1000_E13D_1E13D;
    }
    // CMP SI,BX (1000_E139 / 0x1E139)
    Alu.Sub16(SI, BX);
    // JZ 0x1000:e153 (1000_E13B / 0x1E13B)
    if(ZeroFlag) {
      goto label_1000_E153_1E153;
    }
    label_1000_E13D_1E13D:
    // CALL word ptr [BP + 0x0] (1000_E13D / 0x1E13D)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E13D = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E13D) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E13D));
        break;
    }
    // CMP AX,word ptr [BP + 0x2] (1000_E140 / 0x1E140)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    // JNC 0x1000:e153 (1000_E143 / 0x1E143)
    if(!CarryFlag) {
      goto label_1000_E153_1E153;
    }
    // MOV word ptr [BP + 0x2],AX (1000_E145 / 0x1E145)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // MOV AX,word ptr [DI] (1000_E148 / 0x1E148)
    AX = UInt16[DS, DI];
    // MOV SI,word ptr [DI + 0x2] (1000_E14A / 0x1E14A)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV word ptr [BP + 0x4],AX (1000_E14D / 0x1E14D)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV word ptr [BP + 0x6],SI (1000_E150 / 0x1E150)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    label_1000_E153_1E153:
    // ADD DI,0x4 (1000_E153 / 0x1E153)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    // LOOP 0x1000:e130 (1000_E156 / 0x1E156)
    if(--CX != 0) {
      goto label_1000_E130_1E130;
    }
    // RET  (1000_E158 / 0x1E158)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E159_01E159(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E159_1E159:
    // MOV SI,word ptr [DI + 0x6] (1000_E159 / 0x1E159)
    SI = UInt16[DS, (ushort)(DI + 0x6)];
    // MOV AX,SI (1000_E15C / 0x1E15C)
    AX = SI;
    // SUB AX,word ptr [DI + 0x2] (1000_E15E / 0x1E15E)
    AX -= UInt16[DS, (ushort)(DI + 0x2)];
    // SHR AX,1 (1000_E161 / 0x1E161)
    AX >>= 0x1;
    // SHR AX,1 (1000_E163 / 0x1E163)
    AX >>= 0x1;
    // SUB SI,AX (1000_E165 / 0x1E165)
    // SI -= AX;
    SI = Alu.Sub16(SI, AX);
    // MOV AX,word ptr [DI] (1000_E167 / 0x1E167)
    AX = UInt16[DS, DI];
    // ADD AX,word ptr [DI + 0x4] (1000_E169 / 0x1E169)
    AX += UInt16[DS, (ushort)(DI + 0x4)];
    // SHR AX,1 (1000_E16C / 0x1E16C)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_E16E / 0x1E16E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E1D1_01E1D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E1D1_1E1D1:
    // OR DL,DL (1000_E1D1 / 0x1E1D1)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:e1f3 (1000_E1D3 / 0x1E1D3)
    if(ZeroFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // MOV AX,[0xdc51] (1000_E1D5 / 0x1E1D5)
    AX = UInt16[DS, 0xDC51];
    // OR AX,AX (1000_E1D8 / 0x1E1D8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:e1de (1000_E1DA / 0x1E1DA)
    if(!SignFlag) {
      goto label_1000_E1DE_1E1DE;
    }
    // NEG AX (1000_E1DC / 0x1E1DC)
    AX = Alu.Sub16(0, AX);
    label_1000_E1DE_1E1DE:
    // CMP AX,0x4 (1000_E1DE / 0x1E1DE)
    Alu.Sub16(AX, 0x4);
    // JC 0x1000:e1f3 (1000_E1E1 / 0x1E1E1)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // ADD DL,DL (1000_E1E3 / 0x1E1E3)
    DL += DL;
    // CMP AX,0xc (1000_E1E5 / 0x1E1E5)
    Alu.Sub16(AX, 0xC);
    // JC 0x1000:e1f3 (1000_E1E8 / 0x1E1E8)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // ADD DL,DL (1000_E1EA / 0x1E1EA)
    DL += DL;
    // CMP AX,0x24 (1000_E1EC / 0x1E1EC)
    Alu.Sub16(AX, 0x24);
    // JC 0x1000:e1f3 (1000_E1EF / 0x1E1EF)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // ADD DL,DL (1000_E1F1 / 0x1E1F1)
    // DL += DL;
    DL = Alu.Add8(DL, DL);
    label_1000_E1F3_1E1F3:
    // OR BL,BL (1000_E1F3 / 0x1E1F3)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:e213 (1000_E1F5 / 0x1E1F5)
    if(ZeroFlag) {
      goto label_1000_E213_1E213;
    }
    // MOV AX,[0xdc53] (1000_E1F7 / 0x1E1F7)
    AX = UInt16[DS, 0xDC53];
    // JNS 0x1000:e1fe (1000_E1FA / 0x1E1FA)
    if(!SignFlag) {
      goto label_1000_E1FE_1E1FE;
    }
    // NEG AX (1000_E1FC / 0x1E1FC)
    AX = Alu.Sub16(0, AX);
    label_1000_E1FE_1E1FE:
    // CMP AX,0x3 (1000_E1FE / 0x1E1FE)
    Alu.Sub16(AX, 0x3);
    // JC 0x1000:e213 (1000_E201 / 0x1E201)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    // ADD BL,BL (1000_E203 / 0x1E203)
    BL += BL;
    // CMP AX,0xa (1000_E205 / 0x1E205)
    Alu.Sub16(AX, 0xA);
    // JC 0x1000:e213 (1000_E208 / 0x1E208)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    // ADD BL,BL (1000_E20A / 0x1E20A)
    BL += BL;
    // CMP AX,0x1c (1000_E20C / 0x1E20C)
    Alu.Sub16(AX, 0x1C);
    // JC 0x1000:e213 (1000_E20F / 0x1E20F)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    // ADD BL,BL (1000_E211 / 0x1E211)
    // BL += BL;
    BL = Alu.Add8(BL, BL);
    label_1000_E213_1E213:
    // MOV AL,[0xce7a] (1000_E213 / 0x1E213)
    AL = UInt8[DS, 0xCE7A];
    // MOV AH,AL (1000_E216 / 0x1E216)
    AH = AL;
    // XCHG byte ptr [0xdc50],AH (1000_E218 / 0x1E218)
    byte tmp_1000_E218 = UInt8[DS, 0xDC50];
    UInt8[DS, 0xDC50] = AH;
    AH = tmp_1000_E218;
    // SUB AL,AH (1000_E21C / 0x1E21C)
    AL -= AH;
    // CMP AL,0x8 (1000_E21E / 0x1E21E)
    Alu.Sub8(AL, 0x8);
    // JC 0x1000:e224 (1000_E220 / 0x1E220)
    if(CarryFlag) {
      goto label_1000_E224_1E224;
    }
    // MOV AL,0x8 (1000_E222 / 0x1E222)
    AL = 0x8;
    label_1000_E224_1E224:
    // MOV CL,AL (1000_E224 / 0x1E224)
    CL = AL;
    // MOV SI,0xdc55 (1000_E226 / 0x1E226)
    SI = 0xDC55;
    // MOV AL,DL (1000_E229 / 0x1E229)
    AL = DL;
    // CALL 0x1000:e243 (1000_E22B / 0x1E22B)
    NearCall(cs1, 0xE22E, not_observed_1000_E243_01E243);
    // MOV DX,AX (1000_E22E / 0x1E22E)
    DX = AX;
    // ADD word ptr [0xdc51],AX (1000_E230 / 0x1E230)
    UInt16[DS, 0xDC51] += AX;
    // INC SI (1000_E234 / 0x1E234)
    SI = Alu.Inc16(SI);
    // MOV AL,BL (1000_E235 / 0x1E235)
    AL = BL;
    // CALL 0x1000:e243 (1000_E237 / 0x1E237)
    NearCall(cs1, 0xE23A, not_observed_1000_E243_01E243);
    // MOV BX,AX (1000_E23A / 0x1E23A)
    BX = AX;
    // ADD word ptr [0xdc53],AX (1000_E23C / 0x1E23C)
    // UInt16[DS, 0xDC53] += AX;
    UInt16[DS, 0xDC53] = Alu.Add16(UInt16[DS, 0xDC53], AX);
    // JMP 0x1000:daaf (1000_E240 / 0x1E240)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_DAAF_01DAAF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_E243_01E243(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E243_1E243:
    // IMUL CL (1000_E243 / 0x1E243)
    Cpu.IMul8(CL);
    // OR AX,AX (1000_E245 / 0x1E245)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:e25a (1000_E247 / 0x1E247)
    if(SignFlag) {
      goto label_1000_E25A_1E25A;
    }
    // ADD AL,byte ptr [SI] (1000_E249 / 0x1E249)
    // AL += UInt8[DS, SI];
    AL = Alu.Add8(AL, UInt8[DS, SI]);
    // MOV CH,AL (1000_E24B / 0x1E24B)
    CH = AL;
    // AND CH,0x7 (1000_E24D / 0x1E24D)
    // CH &= 0x7;
    CH = Alu.And8(CH, 0x7);
    // MOV byte ptr [SI],CH (1000_E250 / 0x1E250)
    UInt8[DS, SI] = CH;
    // CBW  (1000_E252 / 0x1E252)
    AX = (ushort)((short)((sbyte)AL));
    // SHR AX,1 (1000_E253 / 0x1E253)
    AX >>= 0x1;
    // SHR AX,1 (1000_E255 / 0x1E255)
    AX >>= 0x1;
    // SHR AX,1 (1000_E257 / 0x1E257)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_E259 / 0x1E259)
    return NearRet();
    label_1000_E25A_1E25A:
    // NEG AX (1000_E25A / 0x1E25A)
    AX = Alu.Sub16(0, AX);
    // ADD AL,byte ptr [SI] (1000_E25C / 0x1E25C)
    // AL += UInt8[DS, SI];
    AL = Alu.Add8(AL, UInt8[DS, SI]);
    // MOV CH,AL (1000_E25E / 0x1E25E)
    CH = AL;
    // AND CH,0x7 (1000_E260 / 0x1E260)
    // CH &= 0x7;
    CH = Alu.And8(CH, 0x7);
    // MOV byte ptr [SI],CH (1000_E263 / 0x1E263)
    UInt8[DS, SI] = CH;
    // CBW  (1000_E265 / 0x1E265)
    AX = (ushort)((short)((sbyte)AL));
    // SHR AX,1 (1000_E266 / 0x1E266)
    AX >>= 0x1;
    // SHR AX,1 (1000_E268 / 0x1E268)
    AX >>= 0x1;
    // SHR AX,1 (1000_E26A / 0x1E26A)
    AX >>= 0x1;
    // NEG AX (1000_E26C / 0x1E26C)
    AX = Alu.Sub16(0, AX);
    // RET  (1000_E26E / 0x1E26E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E26F_01E26F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E26F_1E26F:
    // RET  (1000_E26F / 0x1E26F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E270_01E270(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E270_1E270:
    // PUSH BX (1000_E270 / 0x1E270)
    Stack.Push(BX);
    // PUSH CX (1000_E271 / 0x1E271)
    Stack.Push(CX);
    // PUSH DX (1000_E272 / 0x1E272)
    Stack.Push(DX);
    // PUSH SI (1000_E273 / 0x1E273)
    Stack.Push(SI);
    // PUSH DI (1000_E274 / 0x1E274)
    Stack.Push(DI);
    // PUSH BP (1000_E275 / 0x1E275)
    Stack.Push(BP);
    // MOV BP,SP (1000_E276 / 0x1E276)
    BP = SP;
    // XCHG word ptr [BP + 0xc],AX (1000_E278 / 0x1E278)
    ushort tmp_1000_E278 = UInt16[SS, (ushort)(BP + 0xC)];
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    AX = tmp_1000_E278;
    // PUSH AX (1000_E27B / 0x1E27B)
    Stack.Push(AX);
    // MOV AX,word ptr [BP + 0xc] (1000_E27C / 0x1E27C)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    // MOV BP,word ptr [BP + 0x0] (1000_E27F / 0x1E27F)
    BP = UInt16[SS, BP];
    // RET  (1000_E282 / 0x1E282)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E283_01E283(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E283_1E283:
    // POP AX (1000_E283 / 0x1E283)
    AX = Stack.Pop();
    // MOV BP,SP (1000_E284 / 0x1E284)
    BP = SP;
    // XCHG word ptr [BP + 0xc],AX (1000_E286 / 0x1E286)
    ushort tmp_1000_E286 = UInt16[SS, (ushort)(BP + 0xC)];
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    AX = tmp_1000_E286;
    // POP BP (1000_E289 / 0x1E289)
    BP = Stack.Pop();
    // POP DI (1000_E28A / 0x1E28A)
    DI = Stack.Pop();
    // POP SI (1000_E28B / 0x1E28B)
    SI = Stack.Pop();
    // POP DX (1000_E28C / 0x1E28C)
    DX = Stack.Pop();
    // POP CX (1000_E28D / 0x1E28D)
    CX = Stack.Pop();
    // POP BX (1000_E28E / 0x1E28E)
    BX = Stack.Pop();
    // RET  (1000_E28F / 0x1E28F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E290_01E290(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E290_1E290:
    // CALL 0x1000:d04e (1000_E290 / 0x1E290)
    NearCall(cs1, 0xE293, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E293_01E293, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E293_01E293(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E293_1E293:
    // JMP 0x1000:e297 (1000_E293 / 0x1E293)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_E297_01E297, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_E295_01E295(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E295_1E295:
    // XOR AH,AH (1000_E295 / 0x1E295)
    AH = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_E297_01E297, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_E297_01E297(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E297_1E297:
    // PUSH CX (1000_E297 / 0x1E297)
    Stack.Push(CX);
    // MOV CX,0x64 (1000_E298 / 0x1E298)
    CX = 0x64;
    // DIV CL (1000_E29B / 0x1E29B)
    Cpu.Div8(CL);
    // ADD AL,0x30 (1000_E29D / 0x1E29D)
    AL += 0x30;
    // CMP AL,0x30 (1000_E29F / 0x1E29F)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e2a7 (1000_E2A1 / 0x1E2A1)
    if(!ZeroFlag) {
      goto label_1000_E2A7_1E2A7;
    }
    // MOV AL,0x20 (1000_E2A3 / 0x1E2A3)
    AL = 0x20;
    // DEC CH (1000_E2A5 / 0x1E2A5)
    CH = Alu.Dec8(CH);
    label_1000_E2A7_1E2A7:
    // CALL word ptr [0x2518] (1000_E2A7 / 0x1E2A7)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2A7 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2A7) {
      case 0xD12F : NearCall(cs1, 0xE2AB, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2A7));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E2AB_01E2AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E2AB_01E2AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E2AB_1E2AB:
    // MOV AL,AH (1000_E2AB / 0x1E2AB)
    AL = AH;
    // AAM 0xa (1000_E2AD / 0x1E2AD)
    Cpu.Aam(0xA);
    // XCHG AH,AL (1000_E2AF / 0x1E2AF)
    byte tmp_1000_E2AF = AH;
    AH = AL;
    AL = tmp_1000_E2AF;
    // ADD AX,0x3030 (1000_E2B1 / 0x1E2B1)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    // OR CH,CH (1000_E2B4 / 0x1E2B4)
    // CH |= CH;
    CH = Alu.Or8(CH, CH);
    // JZ 0x1000:e2be (1000_E2B6 / 0x1E2B6)
    if(ZeroFlag) {
      goto label_1000_E2BE_1E2BE;
    }
    // CMP AL,0x30 (1000_E2B8 / 0x1E2B8)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e2be (1000_E2BA / 0x1E2BA)
    if(!ZeroFlag) {
      goto label_1000_E2BE_1E2BE;
    }
    // MOV AL,0x20 (1000_E2BC / 0x1E2BC)
    AL = 0x20;
    label_1000_E2BE_1E2BE:
    // CALL word ptr [0x2518] (1000_E2BE / 0x1E2BE)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2BE = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2BE) {
      case 0xD12F : NearCall(cs1, 0xE2C2, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2BE));
        break;
    }
    label_1000_E2C2_1E2C2:
    // MOV AL,AH (1000_E2C2 / 0x1E2C2)
    AL = AH;
    // CALL word ptr [0x2518] (1000_E2C4 / 0x1E2C4)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2C4 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2C4) {
      case 0xD12F : NearCall(cs1, 0xE2C8, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2C4));
        break;
    }
    label_1000_E2C8_1E2C8:
    // POP CX (1000_E2C8 / 0x1E2C8)
    CX = Stack.Pop();
    // RET  (1000_E2C9 / 0x1E2C9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E2DB_01E2DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E2DB_1E2DB:
    // PUSH AX (1000_E2DB / 0x1E2DB)
    Stack.Push(AX);
    // CALL 0x1000:cf70 (1000_E2DC / 0x1E2DC)
    NearCall(cs1, 0xE2DF, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_E2DF_1E2DF:
    // CALL 0x1000:d03c (1000_E2DF / 0x1E2DF)
    NearCall(cs1, 0xE2E2, spice86_generated_label_call_target_1000_D03C_01D03C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E2E2_01E2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E2E2_01E2E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E2E2_1E2E2:
    // POP AX (1000_E2E2 / 0x1E2E2)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E2E3_01E2E3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xE2F6: goto label_1000_E2F6_1E2F6;break; // Target of external jump from 0x1E351
      case 0xE2FE: goto label_1000_E2FE_1E2FE;break; // Target of external jump from 0x1E2F8, 0x1E34E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_E2E3_1E2E3:
    // PUSH BX (1000_E2E3 / 0x1E2E3)
    Stack.Push(BX);
    // PUSH CX (1000_E2E4 / 0x1E2E4)
    Stack.Push(CX);
    // MOV CX,0x64 (1000_E2E5 / 0x1E2E5)
    CX = 0x64;
    // MOV BX,CX (1000_E2E8 / 0x1E2E8)
    BX = CX;
    // CMP AX,0x3e8 (1000_E2EA / 0x1E2EA)
    Alu.Sub16(AX, 0x3E8);
    // JC 0x1000:e2f2 (1000_E2ED / 0x1E2ED)
    if(CarryFlag) {
      goto label_1000_E2F2_1E2F2;
    }
    // MOV AX,0x3e7 (1000_E2EF / 0x1E2EF)
    AX = 0x3E7;
    label_1000_E2F2_1E2F2:
    // DIV CL (1000_E2F2 / 0x1E2F2)
    Cpu.Div8(CL);
    // ADD AL,0x30 (1000_E2F4 / 0x1E2F4)
    AL += 0x30;
    label_1000_E2F6_1E2F6:
    // CMP AL,0x30 (1000_E2F6 / 0x1E2F6)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e2fe (1000_E2F8 / 0x1E2F8)
    if(!ZeroFlag) {
      goto label_1000_E2FE_1E2FE;
    }
    // MOV AL,0x20 (1000_E2FA / 0x1E2FA)
    AL = 0x20;
    // XOR BX,BX (1000_E2FC / 0x1E2FC)
    BX = 0;
    label_1000_E2FE_1E2FE:
    // MOV byte ptr ES:[SI + -0x3],AL (1000_E2FE / 0x1E2FE)
    UInt8[ES, (ushort)(SI - 0x3)] = AL;
    // MOV AL,AH (1000_E302 / 0x1E302)
    AL = AH;
    // AAM 0xa (1000_E304 / 0x1E304)
    Cpu.Aam(0xA);
    // XCHG AH,AL (1000_E306 / 0x1E306)
    byte tmp_1000_E306 = AH;
    AH = AL;
    AL = tmp_1000_E306;
    // ADD AX,0x3030 (1000_E308 / 0x1E308)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    // OR BX,BX (1000_E30B / 0x1E30B)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNZ 0x1000:e315 (1000_E30D / 0x1E30D)
    if(!ZeroFlag) {
      goto label_1000_E315_1E315;
    }
    // CMP AL,0x30 (1000_E30F / 0x1E30F)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e315 (1000_E311 / 0x1E311)
    if(!ZeroFlag) {
      goto label_1000_E315_1E315;
    }
    // MOV AL,0x20 (1000_E313 / 0x1E313)
    AL = 0x20;
    label_1000_E315_1E315:
    // MOV word ptr ES:[SI + -0x2],AX (1000_E315 / 0x1E315)
    UInt16[ES, (ushort)(SI - 0x2)] = AX;
    // POP CX (1000_E319 / 0x1E319)
    CX = Stack.Pop();
    // POP BX (1000_E31A / 0x1E31A)
    BX = Stack.Pop();
    // RET  (1000_E31B / 0x1E31B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E31C_01E31C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E31C_1E31C:
    // PUSH BX (1000_E31C / 0x1E31C)
    Stack.Push(BX);
    // PUSH CX (1000_E31D / 0x1E31D)
    Stack.Push(CX);
    // MOV CX,0x3e8 (1000_E31E / 0x1E31E)
    CX = 0x3E8;
    // MOV BX,CX (1000_E321 / 0x1E321)
    BX = CX;
    // XOR DX,DX (1000_E323 / 0x1E323)
    DX = 0;
    // DIV CX (1000_E325 / 0x1E325)
    Cpu.Div16(CX);
    // AAM 0xa (1000_E327 / 0x1E327)
    Cpu.Aam(0xA);
    // XCHG AH,AL (1000_E329 / 0x1E329)
    byte tmp_1000_E329 = AH;
    AH = AL;
    AL = tmp_1000_E329;
    // ADD AX,0x3030 (1000_E32B / 0x1E32B)
    AX += 0x3030;
    // CMP AL,0x30 (1000_E32E / 0x1E32E)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e33d (1000_E330 / 0x1E330)
    if(!ZeroFlag) {
      goto label_1000_E33D_1E33D;
    }
    // MOV AL,0x20 (1000_E332 / 0x1E332)
    AL = 0x20;
    // CMP AH,0x30 (1000_E334 / 0x1E334)
    Alu.Sub8(AH, 0x30);
    // JNZ 0x1000:e33d (1000_E337 / 0x1E337)
    if(!ZeroFlag) {
      goto label_1000_E33D_1E33D;
    }
    // MOV AH,AL (1000_E339 / 0x1E339)
    AH = AL;
    // XOR BX,BX (1000_E33B / 0x1E33B)
    BX = 0;
    label_1000_E33D_1E33D:
    // MOV word ptr ES:[SI + -0x5],AX (1000_E33D / 0x1E33D)
    UInt16[ES, (ushort)(SI - 0x5)] = AX;
    // MOV AX,DX (1000_E341 / 0x1E341)
    AX = DX;
    // XOR DX,DX (1000_E343 / 0x1E343)
    DX = 0;
    // MOV CX,0x64 (1000_E345 / 0x1E345)
    CX = 0x64;
    // DIV CL (1000_E348 / 0x1E348)
    Cpu.Div8(CL);
    // ADD AL,0x30 (1000_E34A / 0x1E34A)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    // OR BX,BX (1000_E34C / 0x1E34C)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNZ 0x1000:e2fe (1000_E34E / 0x1E34E)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0x1E2FE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // INC BX (1000_E350 / 0x1E350)
    BX = Alu.Inc16(BX);
    // JMP 0x1000:e2f6 (1000_E351 / 0x1E351)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0x1E2F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E353_01E353(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E353_1E353:
    // PUSH AX (1000_E353 / 0x1E353)
    Stack.Push(AX);
    // PUSH word ptr [0xce7a] (1000_E354 / 0x1E354)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // CALL BP (1000_E358 / 0x1E358)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_E358 = (uint)(BP);
    switch(targetAddress_1000_E358) {
      case 0x4821 : NearCall(cs1, 0xE35A, spice86_generated_label_call_target_1000_4821_014821); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E358));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E35A_01E35A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E35A_01E35A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E35A_1E35A:
    // POP BX (1000_E35A / 0x1E35A)
    BX = Stack.Pop();
    // POP BP (1000_E35B / 0x1E35B)
    BP = Stack.Pop();
    label_1000_E35C_1E35C:
    // CMP byte ptr [0x227d],0x0 (1000_E35C / 0x1E35C)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JZ 0x1000:e378 (1000_E361 / 0x1E361)
    if(ZeroFlag) {
      goto label_1000_E378_1E378;
    }
    // PUSH BX (1000_E363 / 0x1E363)
    Stack.Push(BX);
    // PUSH CX (1000_E364 / 0x1E364)
    Stack.Push(CX);
    // PUSH DX (1000_E365 / 0x1E365)
    Stack.Push(DX);
    // PUSH SI (1000_E366 / 0x1E366)
    Stack.Push(SI);
    // PUSH DI (1000_E367 / 0x1E367)
    Stack.Push(DI);
    // PUSH BP (1000_E368 / 0x1E368)
    Stack.Push(BP);
    // PUSH ES (1000_E369 / 0x1E369)
    Stack.Push(ES);
    // CALL 0x1000:dd63 (1000_E36A / 0x1E36A)
    NearCall(cs1, 0xE36D, spice86_generated_label_call_target_1000_DD63_01DD63);
    // POP ES (1000_E36D / 0x1E36D)
    ES = Stack.Pop();
    // POP BP (1000_E36E / 0x1E36E)
    BP = Stack.Pop();
    // POP DI (1000_E36F / 0x1E36F)
    DI = Stack.Pop();
    // POP SI (1000_E370 / 0x1E370)
    SI = Stack.Pop();
    // POP DX (1000_E371 / 0x1E371)
    DX = Stack.Pop();
    // POP CX (1000_E372 / 0x1E372)
    CX = Stack.Pop();
    // POP BX (1000_E373 / 0x1E373)
    BX = Stack.Pop();
    // JC 0x1000:e386 (1000_E374 / 0x1E374)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E386 / 0x1E386)
      return NearRet();
    }
    // JMP 0x1000:e37b (1000_E376 / 0x1E376)
    goto label_1000_E37B_1E37B;
    label_1000_E378_1E378:
    // CALL 0x1000:de7b (1000_E378 / 0x1E378)
    NearCall(cs1, 0xE37B, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    label_1000_E37B_1E37B:
    // MOV AX,[0xce7a] (1000_E37B / 0x1E37B)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,BX (1000_E37E / 0x1E37E)
    AX -= BX;
    // CMP AX,BP (1000_E380 / 0x1E380)
    Alu.Sub16(AX, BP);
    // JC 0x1000:e35c (1000_E382 / 0x1E382)
    if(CarryFlag) {
      goto label_1000_E35C_1E35C;
    }
    // OR AL,0x1 (1000_E384 / 0x1E384)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    label_1000_E386_1E386:
    // RET  (1000_E386 / 0x1E386)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E387_01E387(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E387_1E387:
    // PUSH AX (1000_E387 / 0x1E387)
    Stack.Push(AX);
    // PUSH CX (1000_E388 / 0x1E388)
    Stack.Push(CX);
    // MOV CX,AX (1000_E389 / 0x1E389)
    CX = AX;
    // JCXZ 0x1000:e39d (1000_E38B / 0x1E38B)
    if(CX == 0) {
      goto label_1000_E39D_1E39D;
    }
    // PUSHF  (1000_E38D / 0x1E38D)
    Stack.Push(FlagRegister);
    // STI  (1000_E38E / 0x1E38E)
    InterruptFlag = true;
    label_1000_E38F_1E38F:
    // MOV AX,SS:[0xce7a] (1000_E38F / 0x1E38F)
    AX = UInt16[SS, 0xCE7A];
    label_1000_E393_1E393:
    // CMP AX,word ptr SS:[0xce7a] (1000_E393 / 0x1E393)
    Alu.Sub16(AX, UInt16[SS, 0xCE7A]);
    // JZ 0x1000:e393 (1000_E398 / 0x1E398)
    if(ZeroFlag) {
      goto label_1000_E393_1E393;
    }
    // LOOP 0x1000:e38f (1000_E39A / 0x1E39A)
    if(--CX != 0) {
      goto label_1000_E38F_1E38F;
    }
    // POPF  (1000_E39C / 0x1E39C)
    FlagRegister = Stack.Pop();
    label_1000_E39D_1E39D:
    // POP CX (1000_E39D / 0x1E39D)
    CX = Stack.Pop();
    // POP AX (1000_E39E / 0x1E39E)
    AX = Stack.Pop();
    // RET  (1000_E39F / 0x1E39F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3A0_01E3A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E3A0_1E3A0:
    // MOV CX,AX (1000_E3A0 / 0x1E3A0)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_E3A2_01E3A2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_E3A2_01E3A2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E3A2_1E3A2:
    // MOV AX,[0xce7a] (1000_E3A2 / 0x1E3A2)
    AX = UInt16[DS, 0xCE7A];
    label_1000_E3A5_1E3A5:
    // CMP AX,word ptr [0xce7a] (1000_E3A5 / 0x1E3A5)
    Alu.Sub16(AX, UInt16[DS, 0xCE7A]);
    // JZ 0x1000:e3a5 (1000_E3A9 / 0x1E3A9)
    if(ZeroFlag) {
      goto label_1000_E3A5_1E3A5;
    }
    // CALL 0x1000:e270 (1000_E3AB / 0x1E3AB)
    NearCall(cs1, 0xE3AE, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_E3AE_1E3AE:
    // CALL 0x1000:d9d2 (1000_E3AE / 0x1E3AE)
    NearCall(cs1, 0xE3B1, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    label_1000_E3B1_1E3B1:
    // CALL 0x1000:e283 (1000_E3B1 / 0x1E3B1)
    NearCall(cs1, 0xE3B4, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_E3B4_1E3B4:
    // LOOP 0x1000:e3a2 (1000_E3B4 / 0x1E3B4)
    if(--CX != 0) {
      goto label_1000_E3A2_1E3A2;
    }
    // RET  (1000_E3B6 / 0x1E3B6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3B7_01E3B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E3B7_1E3B7:
    // PUSH DX (1000_E3B7 / 0x1E3B7)
    Stack.Push(DX);
    // MOV AX,[0xd824] (1000_E3B8 / 0x1E3B8)
    AX = UInt16[DS, 0xD824];
    // MOV DX,0xe56d (1000_E3BB / 0x1E3BB)
    DX = 0xE56D;
    // MUL DX (1000_E3BE / 0x1E3BE)
    Cpu.Mul16(DX);
    // INC AX (1000_E3C0 / 0x1E3C0)
    AX = Alu.Inc16(AX);
    // MOV [0xd824],AX (1000_E3C1 / 0x1E3C1)
    UInt16[DS, 0xD824] = AX;
    // MOV AL,AH (1000_E3C4 / 0x1E3C4)
    AL = AH;
    // MOV AH,DL (1000_E3C6 / 0x1E3C6)
    AH = DL;
    // AND AX,BX (1000_E3C8 / 0x1E3C8)
    // AX &= BX;
    AX = Alu.And16(AX, BX);
    // POP DX (1000_E3CA / 0x1E3CA)
    DX = Stack.Pop();
    // RET  (1000_E3CB / 0x1E3CB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3CC_01E3CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E3CC_1E3CC:
    // PUSH DX (1000_E3CC / 0x1E3CC)
    Stack.Push(DX);
    // MOV AX,[0xd826] (1000_E3CD / 0x1E3CD)
    AX = UInt16[DS, 0xD826];
    // MOV DX,0xcbd1 (1000_E3D0 / 0x1E3D0)
    DX = 0xCBD1;
    // MUL DX (1000_E3D3 / 0x1E3D3)
    Cpu.Mul16(DX);
    // INC AX (1000_E3D5 / 0x1E3D5)
    AX = Alu.Inc16(AX);
    // MOV [0xd826],AX (1000_E3D6 / 0x1E3D6)
    UInt16[DS, 0xD826] = AX;
    // MOV AL,AH (1000_E3D9 / 0x1E3D9)
    AL = AH;
    // MOV AH,DL (1000_E3DB / 0x1E3DB)
    AH = DL;
    // POP DX (1000_E3DD / 0x1E3DD)
    DX = Stack.Pop();
    // RET  (1000_E3DE / 0x1E3DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3DF_01E3DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E3DF_1E3DF:
    // PUSH CX (1000_E3DF / 0x1E3DF)
    Stack.Push(CX);
    // PUSH DX (1000_E3E0 / 0x1E3E0)
    Stack.Push(DX);
    // MOV AX,BX (1000_E3E1 / 0x1E3E1)
    AX = BX;
    // OR AX,AX (1000_E3E3 / 0x1E3E3)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:e408 (1000_E3E5 / 0x1E3E5)
    if(ZeroFlag) {
      goto label_1000_E408_1E408;
    }
    // MOV CX,0xffff (1000_E3E7 / 0x1E3E7)
    CX = 0xFFFF;
    label_1000_E3EA_1E3EA:
    // SHL CX,1 (1000_E3EA / 0x1E3EA)
    CX <<= 0x1;
    // SHR AX,1 (1000_E3EC / 0x1E3EC)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // JNZ 0x1000:e3ea (1000_E3EE / 0x1E3EE)
    if(!ZeroFlag) {
      goto label_1000_E3EA_1E3EA;
    }
    // NOT CX (1000_E3F0 / 0x1E3F0)
    CX = (ushort)~CX;
    label_1000_E3F2_1E3F2:
    // MOV AX,[0xd828] (1000_E3F2 / 0x1E3F2)
    AX = UInt16[DS, 0xD828];
    // MOV DX,0xcbd1 (1000_E3F5 / 0x1E3F5)
    DX = 0xCBD1;
    // MUL DX (1000_E3F8 / 0x1E3F8)
    Cpu.Mul16(DX);
    // INC AX (1000_E3FA / 0x1E3FA)
    AX = Alu.Inc16(AX);
    // MOV [0xd828],AX (1000_E3FB / 0x1E3FB)
    UInt16[DS, 0xD828] = AX;
    // MOV AL,AH (1000_E3FE / 0x1E3FE)
    AL = AH;
    // MOV AH,DL (1000_E400 / 0x1E400)
    AH = DL;
    // AND AX,CX (1000_E402 / 0x1E402)
    AX &= CX;
    // CMP AX,BX (1000_E404 / 0x1E404)
    Alu.Sub16(AX, BX);
    // JA 0x1000:e3f2 (1000_E406 / 0x1E406)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E3F2_1E3F2;
    }
    label_1000_E408_1E408:
    // POP DX (1000_E408 / 0x1E408)
    DX = Stack.Pop();
    // POP CX (1000_E409 / 0x1E409)
    CX = Stack.Pop();
    // RET  (1000_E40A / 0x1E40A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E4AD_01E4AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E4AD_1E4AD:
    // MOV SI,0x80 (1000_E4AD / 0x1E4AD)
    SI = 0x80;
    // LODSB SI (1000_E4B0 / 0x1E4B0)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_E4B1 / 0x1E4B1)
    AH = 0;
    // MOV BP,AX (1000_E4B3 / 0x1E4B3)
    BP = AX;
    // ADD BP,SI (1000_E4B5 / 0x1E4B5)
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    label_1000_E4B7_1E4B7:
    // PUSH CS (1000_E4B7 / 0x1E4B7)
    Stack.Push(cs1);
    // POP ES (1000_E4B8 / 0x1E4B8)
    ES = Stack.Pop();
    label_1000_E4B9_1E4B9:
    // CALL 0x1000:e56b (1000_E4B9 / 0x1E4B9)
    NearCall(cs1, 0xE4BC, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E4BC_1E4BC:
    // JC 0x1000:e4e5 (1000_E4BC / 0x1E4BC)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E4E5 / 0x1E4E5)
      return NearRet();
    }
    // JZ 0x1000:e4b9 (1000_E4BE / 0x1E4BE)
    if(ZeroFlag) {
      goto label_1000_E4B9_1E4B9;
    }
    // MOV DL,AL (1000_E4C0 / 0x1E4C0)
    DL = AL;
    // CALL 0x1000:e56b (1000_E4C2 / 0x1E4C2)
    NearCall(cs1, 0xE4C5, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E4C5_1E4C5:
    // JBE 0x1000:e542 (1000_E4C5 / 0x1E4C5)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // MOV AH,AL (1000_E4C7 / 0x1E4C7)
    AH = AL;
    // CALL 0x1000:e56b (1000_E4C9 / 0x1E4C9)
    NearCall(cs1, 0xE4CC, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E4CC_1E4CC:
    // JBE 0x1000:e542 (1000_E4CC / 0x1E4CC)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // XCHG DL,AL (1000_E4CE / 0x1E4CE)
    byte tmp_1000_E4CE = DL;
    DL = AL;
    AL = tmp_1000_E4CE;
    // MOV DI,0xe40c (1000_E4D0 / 0x1E4D0)
    DI = 0xE40C;
    // MOV CX,0x17 (1000_E4D3 / 0x1E4D3)
    CX = 0x17;
    label_1000_E4D6_1E4D6:
    // SCASW ES:DI (1000_E4D6 / 0x1E4D6)
    Alu.Sub16(AX, UInt16[ES, DI]);
    DI = (ushort)(DI + Direction16);
    // JNZ 0x1000:e4de (1000_E4D7 / 0x1E4D7)
    if(!ZeroFlag) {
      goto label_1000_E4DE_1E4DE;
    }
    // CMP DL,byte ptr ES:[DI] (1000_E4D9 / 0x1E4D9)
    Alu.Sub8(DL, UInt8[ES, DI]);
    // JZ 0x1000:e4e6 (1000_E4DC / 0x1E4DC)
    if(ZeroFlag) {
      goto label_1000_E4E6_1E4E6;
    }
    label_1000_E4DE_1E4DE:
    // ADD DI,0x5 (1000_E4DE / 0x1E4DE)
    // DI += 0x5;
    DI = Alu.Add16(DI, 0x5);
    // LOOP 0x1000:e4d6 (1000_E4E1 / 0x1E4E1)
    if(--CX != 0) {
      goto label_1000_E4D6_1E4D6;
    }
    // JMP 0x1000:e542 (1000_E4E3 / 0x1E4E3)
    goto label_1000_E542_1E542;
    label_1000_E4E5_1E4E5:
    // RET  (1000_E4E5 / 0x1E4E5)
    return NearRet();
    label_1000_E4E6_1E4E6:
    // MOV AX,0x1f4b (1000_E4E6 / 0x1E4E6)
    AX = 0x1F4B;
    // MOV ES,AX (1000_E4E9 / 0x1E4E9)
    ES = AX;
    // MOV BL,byte ptr CS:[DI + 0x1] (1000_E4EB / 0x1E4EB)
    BL = UInt8[cs1, (ushort)(DI + 0x1)];
    // XOR BH,BH (1000_E4EF / 0x1E4EF)
    BH = 0;
    // ADD BX,0x2942 (1000_E4F1 / 0x1E4F1)
    // BX += 0x2942;
    BX = Alu.Add16(BX, 0x2942);
    // MOV AL,byte ptr CS:[DI + 0x2] (1000_E4F5 / 0x1E4F5)
    AL = UInt8[cs1, (ushort)(DI + 0x2)];
    // OR byte ptr ES:[BX],AL (1000_E4F9 / 0x1E4F9)
    // UInt8[ES, BX] |= AL;
    UInt8[ES, BX] = Alu.Or8(UInt8[ES, BX], AL);
    // MOV BX,word ptr CS:[DI + 0x3] (1000_E4FC / 0x1E4FC)
    BX = UInt16[cs1, (ushort)(DI + 0x3)];
    // OR BX,BX (1000_E500 / 0x1E500)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:e542 (1000_E502 / 0x1E502)
    if(ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // CALL 0x1000:e56b (1000_E504 / 0x1E504)
    NearCall(cs1, 0xE507, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E507_1E507:
    // JC 0x1000:e4e5 (1000_E507 / 0x1E507)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E4E5 / 0x1E4E5)
      return NearRet();
    }
    // JZ 0x1000:e542 (1000_E509 / 0x1E509)
    if(ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // DEC SI (1000_E50B / 0x1E50B)
    SI--;
    // CMP BX,0x3826 (1000_E50C / 0x1E50C)
    Alu.Sub16(BX, 0x3826);
    // JZ 0x1000:e54d (1000_E510 / 0x1E510)
    if(ZeroFlag) {
      goto label_1000_E54D_1E54D;
    }
    label_1000_E512_1E512:
    // XOR DX,DX (1000_E512 / 0x1E512)
    DX = 0;
    label_1000_E514_1E514:
    // CALL 0x1000:e56b (1000_E514 / 0x1E514)
    NearCall(cs1, 0xE517, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E517_1E517:
    // MOV AH,AL (1000_E517 / 0x1E517)
    AH = AL;
    // JBE 0x1000:e537 (1000_E519 / 0x1E519)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E537_1E537;
    }
    // SUB AL,0x30 (1000_E51B / 0x1E51B)
    // AL -= 0x30;
    AL = Alu.Sub8(AL, 0x30);
    // JC 0x1000:e537 (1000_E51D / 0x1E51D)
    if(CarryFlag) {
      goto label_1000_E537_1E537;
    }
    // CMP AL,0x9 (1000_E51F / 0x1E51F)
    Alu.Sub8(AL, 0x9);
    // JBE 0x1000:e52b (1000_E521 / 0x1E521)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E52B_1E52B;
    }
    // SUB AL,0x7 (1000_E523 / 0x1E523)
    // AL -= 0x7;
    AL = Alu.Sub8(AL, 0x7);
    // JC 0x1000:e537 (1000_E525 / 0x1E525)
    if(CarryFlag) {
      goto label_1000_E537_1E537;
    }
    // CMP AL,0xf (1000_E527 / 0x1E527)
    Alu.Sub8(AL, 0xF);
    // JA 0x1000:e537 (1000_E529 / 0x1E529)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E537_1E537;
    }
    label_1000_E52B_1E52B:
    // SHL DX,1 (1000_E52B / 0x1E52B)
    DX <<= 0x1;
    // SHL DX,1 (1000_E52D / 0x1E52D)
    DX <<= 0x1;
    // SHL DX,1 (1000_E52F / 0x1E52F)
    DX <<= 0x1;
    // SHL DX,1 (1000_E531 / 0x1E531)
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    // OR DL,AL (1000_E533 / 0x1E533)
    // DL |= AL;
    DL = Alu.Or8(DL, AL);
    // JMP 0x1000:e514 (1000_E535 / 0x1E535)
    goto label_1000_E514_1E514;
    label_1000_E537_1E537:
    // MOV word ptr ES:[BX],DX (1000_E537 / 0x1E537)
    UInt16[ES, BX] = DX;
    // ADD BX,0x2 (1000_E53A / 0x1E53A)
    BX += 0x2;
    // CMP AH,0x20 (1000_E53D / 0x1E53D)
    Alu.Sub8(AH, 0x20);
    // JA 0x1000:e512 (1000_E540 / 0x1E540)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E512_1E512;
    }
    label_1000_E542_1E542:
    // DEC SI (1000_E542 / 0x1E542)
    SI = Alu.Dec16(SI);
    label_1000_E543_1E543:
    // CALL 0x1000:e56b (1000_E543 / 0x1E543)
    NearCall(cs1, 0xE546, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E546_1E546:
    // JC 0x1000:e4e5 (1000_E546 / 0x1E546)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E4E5 / 0x1E4E5)
      return NearRet();
    }
    // JNZ 0x1000:e543 (1000_E548 / 0x1E548)
    if(!ZeroFlag) {
      goto label_1000_E543_1E543;
    }
    // JMP 0x1000:e4b7 (1000_E54A / 0x1E54A)
    goto label_1000_E4B7_1E4B7;
    label_1000_E54D_1E54D:
    // MOV DI,BX (1000_E54D / 0x1E54D)
    DI = BX;
    label_1000_E54F_1E54F:
    // CALL 0x1000:e56b (1000_E54F / 0x1E54F)
    NearCall(cs1, 0xE552, spice86_generated_label_call_target_1000_E56B_01E56B);
    // JBE 0x1000:e55b (1000_E552 / 0x1E552)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E55B_1E55B;
    }
    // STOSB ES:DI (1000_E554 / 0x1E554)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP DI,0x3898 (1000_E555 / 0x1E555)
    Alu.Sub16(DI, 0x3898);
    // JC 0x1000:e54f (1000_E559 / 0x1E559)
    if(CarryFlag) {
      goto label_1000_E54F_1E54F;
    }
    label_1000_E55B_1E55B:
    // MOV AL,0x5c (1000_E55B / 0x1E55B)
    AL = 0x5C;
    // CMP byte ptr ES:[DI + -0x1],AL (1000_E55D / 0x1E55D)
    Alu.Sub8(UInt8[ES, (ushort)(DI - 0x1)], AL);
    // JZ 0x1000:e564 (1000_E561 / 0x1E561)
    if(ZeroFlag) {
      goto label_1000_E564_1E564;
    }
    // STOSB ES:DI (1000_E563 / 0x1E563)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_1000_E564_1E564:
    // MOV word ptr ES:[0x38a6],DI (1000_E564 / 0x1E564)
    UInt16[ES, 0x38A6] = DI;
    // JMP 0x1000:e542 (1000_E569 / 0x1E569)
    goto label_1000_E542_1E542;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E56B_01E56B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E56B_1E56B:
    // MOV AL,0xd (1000_E56B / 0x1E56B)
    AL = 0xD;
    // CMP SI,BP (1000_E56D / 0x1E56D)
    Alu.Sub16(SI, BP);
    // JNC 0x1000:e578 (1000_E56F / 0x1E56F)
    if(!CarryFlag) {
      goto label_1000_E578_1E578;
    }
    // LODSB SI (1000_E571 / 0x1E571)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0x61 (1000_E572 / 0x1E572)
    Alu.Sub8(AL, 0x61);
    // JC 0x1000:e578 (1000_E574 / 0x1E574)
    if(CarryFlag) {
      goto label_1000_E578_1E578;
    }
    // AND AL,0xdf (1000_E576 / 0x1E576)
    AL &= 0xDF;
    label_1000_E578_1E578:
    // CMP AL,0x20 (1000_E578 / 0x1E578)
    Alu.Sub8(AL, 0x20);
    // RET  (1000_E57A / 0x1E57A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E57B_01E57B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E57B_1E57B:
    // PUSH CX (1000_E57B / 0x1E57B)
    Stack.Push(CX);
    // PUSH SI (1000_E57C / 0x1E57C)
    Stack.Push(SI);
    // ADD AX,0xc8 (1000_E57D / 0x1E57D)
    // AX += 0xC8;
    AX = Alu.Add16(AX, 0xC8);
    // MOV SI,AX (1000_E580 / 0x1E580)
    SI = AX;
    // CALL 0x1000:f0b9 (1000_E582 / 0x1E582)
    NearCall(cs1, 0xE585, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E585_01E585, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E585_01E585(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E585_1E585:
    // POP SI (1000_E585 / 0x1E585)
    SI = Stack.Pop();
    // POP CX (1000_E586 / 0x1E586)
    CX = Stack.Pop();
    // MOV AX,ES (1000_E587 / 0x1E587)
    AX = ES;
    // SUB AX,0x10 (1000_E589 / 0x1E589)
    // AX -= 0x10;
    AX = Alu.Sub16(AX, 0x10);
    label_1000_E58C_1E58C:
    // MOV word ptr [SI],AX (1000_E58C / 0x1E58C)
    UInt16[DS, SI] = AX;
    // ADD SI,0x4 (1000_E58E / 0x1E58E)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LOOP 0x1000:e58c (1000_E591 / 0x1E591)
    if(--CX != 0) {
      goto label_1000_E58C_1E58C;
    }
    // RET  (1000_E593 / 0x1E593)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E594_01E594(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E594_1E594:
    // MOV AX,0x1f4b (1000_E594 / 0x1E594)
    AX = 0x1F4B;
    // MOV ES,AX (1000_E597 / 0x1E597)
    ES = AX;
    // MOV CX,0xdd1d (1000_E599 / 0x1E599)
    CX = 0xDD1D;
    // MOV DI,0x3cbc (1000_E59C / 0x1E59C)
    DI = 0x3CBC;
    // SUB CX,DI (1000_E59F / 0x1E59F)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    // CLD  (1000_E5A1 / 0x1E5A1)
    DirectionFlag = false;
    // XOR AX,AX (1000_E5A2 / 0x1E5A2)
    AX = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_E5A4 / 0x1E5A4)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV AX,[0x2] (1000_E5A6 / 0x1E5A6)
    AX = UInt16[DS, 0x2];
    // PUSH ES (1000_E5A9 / 0x1E5A9)
    Stack.Push(ES);
    // POP DS (1000_E5AA / 0x1E5AA)
    DS = Stack.Pop();
    // MOV [0xce68],AX (1000_E5AB / 0x1E5AB)
    UInt16[DS, 0xCE68] = AX;
    // MOV CX,0xdd1d (1000_E5AE / 0x1E5AE)
    CX = 0xDD1D;
    // CALL 0x1000:f0ff (1000_E5B1 / 0x1E5B1)
    NearCall(cs1, 0xE5B4, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E5B4_01E5B4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E5B4_01E5B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E5B4_1E5B4:
    // MOV AX,0x4c6f (1000_E5B4 / 0x1E5B4)
    AX = 0x4C6F;
    // MOV CL,0x4 (1000_E5B7 / 0x1E5B7)
    CL = 0x4;
    // SHR AX,CL (1000_E5B9 / 0x1E5B9)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV CX,DS (1000_E5BB / 0x1E5BB)
    CX = DS;
    // ADD AX,CX (1000_E5BD / 0x1E5BD)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // MOV [0xdc32],AX (1000_E5BF / 0x1E5BF)
    UInt16[DS, 0xDC32] = AX;
    // MOV AH,0x19 (1000_E5C2 / 0x1E5C2)
    AH = 0x19;
    // INT 0x21 (1000_E5C4 / 0x1E5C4)
    Interrupt(0x21);
    // MOV [0xce76],AL (1000_E5C6 / 0x1E5C6)
    UInt8[DS, 0xCE76] = AL;
    // MOV [0xce77],AL (1000_E5C9 / 0x1E5C9)
    UInt8[DS, 0xCE77] = AL;
    // MOV AX,0x3301 (1000_E5CC / 0x1E5CC)
    AX = 0x3301;
    // INT 0x21 (1000_E5CF / 0x1E5CF)
    Interrupt(0x21);
    // MOV byte ptr [0x2941],DL (1000_E5D1 / 0x1E5D1)
    UInt8[DS, 0x2941] = DL;
    // MOV AX,0x3301 (1000_E5D5 / 0x1E5D5)
    AX = 0x3301;
    // XOR DX,DX (1000_E5D8 / 0x1E5D8)
    DX = 0;
    // INT 0x21 (1000_E5DA / 0x1E5DA)
    Interrupt(0x21);
    // CALL 0x1000:e675 (1000_E5DC / 0x1E5DC)
    NearCall(cs1, 0xE5DF, spice86_generated_label_call_target_1000_E675_01E675);
    label_1000_E5DF_1E5DF:
    // MOV AL,[0x2942] (1000_E5DF / 0x1E5DF)
    AL = UInt8[DS, 0x2942];
    // AND AX,0x1 (1000_E5E2 / 0x1E5E2)
    // AX &= 0x1;
    AX = Alu.And16(AX, 0x1);
    // MOV SI,0x38b7 (1000_E5E5 / 0x1E5E5)
    SI = 0x38B7;
    // MOV CX,0x2e (1000_E5E8 / 0x1E5E8)
    CX = 0x2E;
    // CALL 0x1000:e57b (1000_E5EB / 0x1E5EB)
    NearCall(cs1, 0xE5EE, spice86_generated_label_call_target_1000_E57B_01E57B);
    label_1000_E5EE_1E5EE:
    // CALLF [0x38b9] (1000_E5EE / 0x1E5EE)
    // Indirect call to [0x38b9], generating possible targets from emulator records
    uint targetAddress_1000_E5EE = (uint)(UInt16[DS, 0x38BB] * 0x10 + UInt16[DS, 0x38B9] - cs1 * 0x10);
    switch(targetAddress_1000_E5EE) {
      case 0x235B3 : FarCall(cs1, 0xE5F2, spice86_generated_label_call_target_334B_0103_0335B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E5EE));
        break;
    }
    label_1000_E5F2_1E5F2:
    // MOV [0xdbd8],AX (1000_E5F2 / 0x1E5F2)
    UInt16[DS, 0xDBD8] = AX;
    // CALL 0x1000:c08e (1000_E5F5 / 0x1E5F5)
    NearCall(cs1, 0xE5F8, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E5F8_01E5F8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E5F8_01E5F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E5F8_1E5F8:
    // MOV word ptr [0xce74],CX (1000_E5F8 / 0x1E5F8)
    UInt16[DS, 0xCE74] = CX;
    // MOV DI,0xdbdc (1000_E5FC / 0x1E5FC)
    DI = 0xDBDC;
    // CALL 0x1000:f0f6 (1000_E5FF / 0x1E5FF)
    NearCall(cs1, 0xE602, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    label_1000_E602_1E602:
    // MOV word ptr [0xdbd6],BP (1000_E602 / 0x1E602)
    UInt16[DS, 0xDBD6] = BP;
    // OR BP,BP (1000_E606 / 0x1E606)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JNZ 0x1000:e610 (1000_E608 / 0x1E608)
    if(!ZeroFlag) {
      goto label_1000_E610_1E610;
    }
    // MOV DI,0xdbd4 (1000_E60A / 0x1E60A)
    DI = 0xDBD4;
    // CALL 0x1000:f0f6 (1000_E60D / 0x1E60D)
    NearCall(cs1, 0xE610, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    label_1000_E610_1E610:
    // CALLF [0x38b5] (1000_E610 / 0x1E610)
    // Indirect call to [0x38b5], generating possible targets from emulator records
    uint targetAddress_1000_E610 = (uint)(UInt16[DS, 0x38B7] * 0x10 + UInt16[DS, 0x38B5] - cs1 * 0x10);
    switch(targetAddress_1000_E610) {
      case 0x235B0 : FarCall(cs1, 0xE614, spice86_generated_label_call_target_334B_0100_0335B0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E610));
        break;
    }
    label_1000_E614_1E614:
    // MOV AL,[0x2942] (1000_E614 / 0x1E614)
    AL = UInt8[DS, 0x2942];
    // PUSH AX (1000_E617 / 0x1E617)
    Stack.Push(AX);
    // SHR AL,1 (1000_E618 / 0x1E618)
    AL >>= 0x1;
    // SHR AL,1 (1000_E61A / 0x1E61A)
    AL >>= 0x1;
    // AND AL,0x7 (1000_E61C / 0x1E61C)
    // AL &= 0x7;
    AL = Alu.And8(AL, 0x7);
    // MOV [0xceeb],AL (1000_E61E / 0x1E61E)
    UInt8[DS, 0xCEEB] = AL;
    // POP AX (1000_E621 / 0x1E621)
    AX = Stack.Pop();
    // OR AL,AL (1000_E622 / 0x1E622)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:e62b (1000_E624 / 0x1E624)
    if(!SignFlag) {
      goto label_1000_E62B_1E62B;
    }
    // PUSH AX (1000_E626 / 0x1E626)
    Stack.Push(AX);
    // CALL 0x1000:ea32 (1000_E627 / 0x1E627)
    NearCall(cs1, 0xE62A, initialize_joystick_ida_1000_EA32_1EA32);
    // POP AX (1000_E62A / 0x1E62A)
    AX = Stack.Pop();
    label_1000_E62B_1E62B:
    // TEST AL,0x40 (1000_E62B / 0x1E62B)
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:e632 (1000_E62D / 0x1E62D)
    if(!ZeroFlag) {
      goto label_1000_E632_1E632;
    }
    // CALL 0x1000:e97a (1000_E62F / 0x1E62F)
    NearCall(cs1, 0xE632, spice86_generated_label_call_target_1000_E97A_01E97A);
    label_1000_E632_1E632:
    // CALL 0x1000:e85c (1000_E632 / 0x1E632)
    NearCall(cs1, 0xE635, spice86_generated_label_call_target_1000_E85C_01E85C);
    label_1000_E635_1E635:
    // CALL 0x1000:ea7b (1000_E635 / 0x1E635)
    NearCall(cs1, 0xE638, spice86_generated_label_call_target_1000_EA7B_01EA7B);
    label_1000_E638_1E638:
    // MOV AL,[0x2942] (1000_E638 / 0x1E638)
    AL = UInt8[DS, 0x2942];
    // AND AL,0x2 (1000_E63B / 0x1E63B)
    // AL &= 0x2;
    AL = Alu.And8(AL, 0x2);
    // MOV BP,0xce7a (1000_E63D / 0x1E63D)
    BP = 0xCE7A;
    // CALLF [0x3925] (1000_E640 / 0x1E640)
    // Indirect call to [0x3925], generating possible targets from emulator records
    uint targetAddress_1000_E640 = (uint)(UInt16[DS, 0x3927] * 0x10 + UInt16[DS, 0x3925] - cs1 * 0x10);
    switch(targetAddress_1000_E640) {
      case 0x23604 : FarCall(cs1, 0xE644, spice86_generated_label_call_target_334B_0154_033604); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E640));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E644_01E644, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E644_01E644(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E644_1E644:
    // MOV word ptr [0xdc48],0x271c (1000_E644 / 0x1E644)
    UInt16[DS, 0xDC48] = 0x271C;
    // MOV byte ptr [0xdc46],0xff (1000_E64A / 0x1E64A)
    UInt8[DS, 0xDC46] = 0xFF;
    // XOR AX,AX (1000_E64F / 0x1E64F)
    AX = 0;
    // MOV BX,0xc7 (1000_E651 / 0x1E651)
    BX = 0xC7;
    // XOR CX,CX (1000_E654 / 0x1E654)
    CX = 0;
    // MOV DX,0x13f (1000_E656 / 0x1E656)
    DX = 0x13F;
    // CALL 0x1000:db14 (1000_E659 / 0x1E659)
    NearCall(cs1, 0xE65C, spice86_generated_label_call_target_1000_DB14_01DB14);
    label_1000_E65C_1E65C:
    // MOV BX,0xab (1000_E65C / 0x1E65C)
    BX = 0xAB;
    // MOV DX,0xed (1000_E65F / 0x1E65F)
    DX = 0xED;
    // CALL 0x1000:db03 (1000_E662 / 0x1E662)
    NearCall(cs1, 0xE665, spice86_generated_label_call_target_1000_DB03_01DB03);
    label_1000_E665_1E665:
    // CALL 0x1000:e76a (1000_E665 / 0x1E665)
    NearCall(cs1, 0xE668, spice86_generated_label_call_target_1000_E76A_01E76A);
    label_1000_E668_1E668:
    // CALL 0x1000:ce6c (1000_E668 / 0x1E668)
    NearCall(cs1, 0xE66B, spice86_generated_label_call_target_1000_CE6C_01CE6C);
    label_1000_E66B_1E66B:
    // CALL 0x1000:c07c (1000_E66B / 0x1E66B)
    NearCall(cs1, 0xE66E, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_E66E_1E66E:
    // CALL 0x1000:c0ad (1000_E66E / 0x1E66E)
    NearCall(cs1, 0xE671, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    label_1000_E671_1E671:
    // JMP 0x1000:c412 (1000_E671 / 0x1E671)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C412_01C412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_E674_01E674(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E674_1E674:
    // RET  (1000_E674 / 0x1E674)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E675_01E675(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E675_1E675:
    // MOV DX,0x37f2 (1000_E675 / 0x1E675)
    DX = 0x37F2;
    // CALL 0x1000:f1fb (1000_E678 / 0x1E678)
    NearCall(cs1, 0xE67B, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E67B_01E67B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E67B_01E67B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E67B_1E67B:
    // JC 0x1000:e692 (1000_E67B / 0x1E67B)
    if(CarryFlag) {
      goto label_1000_E692_1E692;
    }
    // LES DI,[0x39b7] (1000_E67D / 0x1E67D)
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    // CALL 0x1000:f260 (1000_E681 / 0x1E681)
    NearCall(cs1, 0xE684, read_ffff_to_esdi_and_close_ida_1000_F260_1F260);
    // CMP word ptr ES:[DI],0xc089 (1000_E684 / 0x1E684)
    Alu.Sub16(UInt16[ES, DI], 0xC089);
    // JNZ 0x1000:e692 (1000_E689 / 0x1E689)
    if(!ZeroFlag) {
      goto label_1000_E692_1E692;
    }
    // MOV DX,0x31ff (1000_E68B / 0x1E68B)
    DX = 0x31FF;
    // CALLF [0x39b7] (1000_E68E / 0x1E68E)
    // Indirect call to [0x39b7], generating possible targets from emulator records
    uint targetAddress_1000_E68E = (uint)(UInt16[DS, 0x39B9] * 0x10 + UInt16[DS, 0x39B7] - cs1 * 0x10);
    switch(targetAddress_1000_E68E) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E68E));
        break;
    }
    label_1000_E692_1E692:
    // MOV SI,0x37f7 (1000_E692 / 0x1E692)
    SI = 0x37F7;
    // INC byte ptr [SI] (1000_E695 / 0x1E695)
    UInt8[DS, SI]++;
    // CMP byte ptr [SI],0x39 (1000_E697 / 0x1E697)
    Alu.Sub8(UInt8[DS, SI], 0x39);
    // JBE 0x1000:e675 (1000_E69A / 0x1E69A)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E675_01E675, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV DX,0x37e9 (1000_E69C / 0x1E69C)
    DX = 0x37E9;
    // MOV AX,0x3d00 (1000_E69F / 0x1E69F)
    AX = 0x3D00;
    // INT 0x21 (1000_E6A2 / 0x1E6A2)
    Interrupt(0x21);
    // JC 0x1000:e674 (1000_E6A4 / 0x1E6A4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E674 / 0x1E674)
      return NearRet();
    }
    // MOV [0xdbba],AX (1000_E6A6 / 0x1E6A6)
    UInt16[DS, 0xDBBA] = AX;
    // CALL 0x1000:e741 (1000_E6A9 / 0x1E6A9)
    NearCall(cs1, 0xE6AC, spice86_generated_label_call_target_1000_E741_01E741);
    label_1000_E6AC_1E6AC:
    // MOV SI,DI (1000_E6AC / 0x1E6AC)
    SI = DI;
    // MOV BP,ES (1000_E6AE / 0x1E6AE)
    BP = ES;
    // LES DI,[0x39b7] (1000_E6B0 / 0x1E6B0)
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    // MOV word ptr [0xdbbc],DI (1000_E6B4 / 0x1E6B4)
    UInt16[DS, 0xDBBC] = DI;
    // MOV word ptr [0xdbbe],ES (1000_E6B8 / 0x1E6B8)
    UInt16[DS, 0xDBBE] = ES;
    // MOV AX,0x145 (1000_E6BC / 0x1E6BC)
    AX = 0x145;
    // STOSW ES:DI (1000_E6BF / 0x1E6BF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV CX,0x14d (1000_E6C0 / 0x1E6C0)
    CX = 0x14D;
    // MOV AL,0xff (1000_E6C3 / 0x1E6C3)
    AL = 0xFF;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_E6C5 / 0x1E6C5)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV word ptr [0xd820],DI (1000_E6C7 / 0x1E6C7)
    UInt16[DS, 0xD820] = DI;
    // PUSH DS (1000_E6CB / 0x1E6CB)
    Stack.Push(DS);
    // MOV DS,BP (1000_E6CC / 0x1E6CC)
    DS = BP;
    // LODSW SI (1000_E6CE / 0x1E6CE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    label_1000_E6CF_1E6CF:
    // PUSH SI (1000_E6CF / 0x1E6CF)
    Stack.Push(SI);
    // CALL 0x1000:f314 (1000_E6D0 / 0x1E6D0)
    NearCall(cs1, 0xE6D3, spice86_generated_label_call_target_1000_F314_01F314);
    label_1000_E6D3_1E6D3:
    // POP SI (1000_E6D3 / 0x1E6D3)
    SI = Stack.Pop();
    // JC 0x1000:e702 (1000_E6D4 / 0x1E6D4)
    if(CarryFlag) {
      goto label_1000_E702_1E702;
    }
    // CALL 0x1000:f3a7 (1000_E6D6 / 0x1E6D6)
    NearCall(cs1, 0xE6D9, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    label_1000_E6D9_1E6D9:
    // JZ 0x1000:e6f9 (1000_E6D9 / 0x1E6D9)
    if(ZeroFlag) {
      goto label_1000_E6F9_1E6F9;
    }
    // PUSH AX (1000_E6DB / 0x1E6DB)
    Stack.Push(AX);
    // PUSH DX (1000_E6DC / 0x1E6DC)
    Stack.Push(DX);
    // PUSH SI (1000_E6DD / 0x1E6DD)
    Stack.Push(SI);
    // PUSH DI (1000_E6DE / 0x1E6DE)
    Stack.Push(DI);
    // MOV CX,word ptr SS:[0xd820] (1000_E6DF / 0x1E6DF)
    CX = UInt16[SS, 0xD820];
    // MOV SI,CX (1000_E6E4 / 0x1E6E4)
    SI = CX;
    // SUB CX,DI (1000_E6E6 / 0x1E6E6)
    CX -= DI;
    // SUB SI,0x2 (1000_E6E8 / 0x1E6E8)
    // SI -= 0x2;
    SI = Alu.Sub16(SI, 0x2);
    // LEA DI,[SI + 0xa] (1000_E6EB / 0x1E6EB)
    DI = (ushort)(SI + 0xA);
    // SHR CX,1 (1000_E6EE / 0x1E6EE)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // STD  (1000_E6F0 / 0x1E6F0)
    DirectionFlag = true;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,ES:SI (1000_E6F1 / 0x1E6F1)
      UInt16[ES, DI] = UInt16[ES, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // CLD  (1000_E6F4 / 0x1E6F4)
    DirectionFlag = false;
    // POP DI (1000_E6F5 / 0x1E6F5)
    DI = Stack.Pop();
    // POP SI (1000_E6F6 / 0x1E6F6)
    SI = Stack.Pop();
    // POP DX (1000_E6F7 / 0x1E6F7)
    DX = Stack.Pop();
    // POP AX (1000_E6F8 / 0x1E6F8)
    AX = Stack.Pop();
    label_1000_E6F9_1E6F9:
    // CALL 0x1000:e75b (1000_E6F9 / 0x1E6F9)
    NearCall(cs1, 0xE6FC, spice86_generated_label_call_target_1000_E75B_01E75B);
    label_1000_E6FC_1E6FC:
    // ADD word ptr SS:[0xd820],0xa (1000_E6FC / 0x1E6FC)
    UInt16[SS, 0xD820] += 0xA;
    label_1000_E702_1E702:
    // ADD SI,0x19 (1000_E702 / 0x1E702)
    SI += 0x19;
    // CMP byte ptr [SI],0x0 (1000_E705 / 0x1E705)
    Alu.Sub8(UInt8[DS, SI], 0x0);
    // JNZ 0x1000:e6cf (1000_E708 / 0x1E708)
    if(!ZeroFlag) {
      goto label_1000_E6CF_1E6CF;
    }
    // POP DS (1000_E70A / 0x1E70A)
    DS = Stack.Pop();
    // MOV SI,0x145 (1000_E70B / 0x1E70B)
    SI = 0x145;
    // MOV AX,[0xd820] (1000_E70E / 0x1E70E)
    AX = UInt16[DS, 0xD820];
    // SUB AX,SI (1000_E711 / 0x1E711)
    AX -= SI;
    // XOR DX,DX (1000_E713 / 0x1E713)
    DX = 0;
    // MOV CX,0x280 (1000_E715 / 0x1E715)
    CX = 0x280;
    // DIV CX (1000_E718 / 0x1E718)
    Cpu.Div16(CX);
    // MOV DX,0xa (1000_E71A / 0x1E71A)
    DX = 0xA;
    // MUL DX (1000_E71D / 0x1E71D)
    Cpu.Mul16(DX);
    // MOV DX,AX (1000_E71F / 0x1E71F)
    DX = AX;
    // LES DI,SS:[0xdbbc] (1000_E721 / 0x1E721)
    ES = UInt16[SS, 0xDBBE];
    DI = UInt16[SS, 0xDBBC];
    // ADD DI,0x2 (1000_E726 / 0x1E726)
    DI += 0x2;
    label_1000_E729_1E729:
    // ADD SI,DX (1000_E729 / 0x1E729)
    // SI += DX;
    SI = Alu.Add16(SI, DX);
    // PUSH SI (1000_E72B / 0x1E72B)
    Stack.Push(SI);
    // MOVSW ES:DI,ES:SI (1000_E72C / 0x1E72C)
    UInt16[ES, DI] = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSB ES:DI,ES:SI (1000_E72E / 0x1E72E)
    UInt8[ES, DI] = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // POP SI (1000_E730 / 0x1E730)
    SI = Stack.Pop();
    // MOV AX,SI (1000_E731 / 0x1E731)
    AX = SI;
    // STOSW ES:DI (1000_E733 / 0x1E733)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP DI,0x140 (1000_E734 / 0x1E734)
    Alu.Sub16(DI, 0x140);
    // JC 0x1000:e729 (1000_E738 / 0x1E738)
    if(CarryFlag) {
      goto label_1000_E729_1E729;
    }
    // MOV CX,word ptr [0xd820] (1000_E73A / 0x1E73A)
    CX = UInt16[DS, 0xD820];
    // JMP 0x1000:f0ff (1000_E73E / 0x1E73E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E741_01E741(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E741_1E741:
    // XOR AX,AX (1000_E741 / 0x1E741)
    AX = 0;
    // XOR DX,DX (1000_E743 / 0x1E743)
    DX = 0;
    // CALL 0x1000:f2d6 (1000_E745 / 0x1E745)
    NearCall(cs1, 0xE748, spice86_generated_label_call_target_1000_F2D6_01F2D6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E748_01E748, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E748_01E748(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E748_1E748:
    // MOV AX,[0x39b9] (1000_E748 / 0x1E748)
    AX = UInt16[DS, 0x39B9];
    // ADD AX,0x800 (1000_E74B / 0x1E74B)
    // AX += 0x800;
    AX = Alu.Add16(AX, 0x800);
    // MOV ES,AX (1000_E74E / 0x1E74E)
    ES = AX;
    // XOR DI,DI (1000_E750 / 0x1E750)
    DI = 0;
    // MOV CX,0xffff (1000_E752 / 0x1E752)
    CX = 0xFFFF;
    // CALL 0x1000:f2ea (1000_E755 / 0x1E755)
    NearCall(cs1, 0xE758, spice86_generated_label_call_target_1000_F2EA_01F2EA);
    label_1000_E758_1E758:
    // JC 0x1000:e741 (1000_E758 / 0x1E758)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E741_01E741, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_E75A / 0x1E75A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E75B_01E75B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E75B_1E75B:
    // PUSH SI (1000_E75B / 0x1E75B)
    Stack.Push(SI);
    // STOSW ES:DI (1000_E75C / 0x1E75C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,DL (1000_E75D / 0x1E75D)
    AL = DL;
    // STOSB ES:DI (1000_E75F / 0x1E75F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD SI,0x10 (1000_E760 / 0x1E760)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // MOVSW ES:DI,SI (1000_E763 / 0x1E763)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSB ES:DI,SI (1000_E764 / 0x1E764)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // INC SI (1000_E765 / 0x1E765)
    SI = Alu.Inc16(SI);
    // MOVSW ES:DI,SI (1000_E766 / 0x1E766)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_E767 / 0x1E767)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // POP SI (1000_E768 / 0x1E768)
    SI = Stack.Pop();
    // RET  (1000_E769 / 0x1E769)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E76A_01E76A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E76A_1E76A:
    // MOV AL,[0x2944] (1000_E76A / 0x1E76A)
    AL = UInt8[DS, 0x2944];
    // MOV CL,0x4 (1000_E76D / 0x1E76D)
    CL = 0x4;
    // SHR AL,CL (1000_E76F / 0x1E76F)
    AL >>= CL;
    // ADD AL,0x7 (1000_E771 / 0x1E771)
    AL += 0x7;
    // XOR AH,AH (1000_E773 / 0x1E773)
    AH = 0;
    // MOV SI,0x398b (1000_E775 / 0x1E775)
    SI = 0x398B;
    // MOV CX,0x8 (1000_E778 / 0x1E778)
    CX = 0x8;
    // CALL 0x1000:e57b (1000_E77B / 0x1E77B)
    NearCall(cs1, 0xE77E, spice86_generated_label_call_target_1000_E57B_01E57B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E77E_01E77E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E77E_01E77E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E77E_1E77E:
    // MOV AX,[0x39b5] (1000_E77E / 0x1E77E)
    AX = UInt16[DS, 0x39B5];
    // CALLF [0x3989] (1000_E781 / 0x1E781)
    // Indirect call to [0x3989], generating possible targets from emulator records
    uint targetAddress_1000_E781 = (uint)(UInt16[DS, 0x398B] * 0x10 + UInt16[DS, 0x3989] - cs1 * 0x10);
    switch(targetAddress_1000_E781) {
      case 0x46450 : FarCall(cs1, 0xE785, spice86_generated_label_call_target_5635_0100_056450); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E781));
        break;
    }
    label_1000_E785_1E785:
    // MOV word ptr [0xdbc8],BX (1000_E785 / 0x1E785)
    UInt16[DS, 0xDBC8] = BX;
    // CALL 0x1000:a637 (1000_E789 / 0x1E789)
    NearCall(cs1, 0xE78C, spice86_generated_label_call_target_1000_A637_01A637);
    label_1000_E78C_1E78C:
    // CALL 0x1000:ae54 (1000_E78C / 0x1E78C)
    NearCall(cs1, 0xE78F, spice86_generated_label_call_target_1000_AE54_01AE54);
    label_1000_E78F_1E78F:
    // CALL 0x1000:e851 (1000_E78F / 0x1E78F)
    NearCall(cs1, 0xE792, spice86_generated_label_call_target_1000_E851_01E851);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E792_01E792, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E792_01E792(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E792_1E792:
    // JC 0x1000:e7bc (1000_E792 / 0x1E792)
    if(CarryFlag) {
      goto label_1000_E7BC_1E7BC;
    }
    // TEST byte ptr [0x2944],0xf0 (1000_E794 / 0x1E794)
    Alu.And8(UInt8[DS, 0x2944], 0xF0);
    // JZ 0x1000:e7b9 (1000_E799 / 0x1E799)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [0x2944],0xf (1000_E79B / 0x1E79B)
    UInt8[DS, 0x2944] &= 0xF;
    // XOR AX,AX (1000_E7A0 / 0x1E7A0)
    AX = 0;
    // MOV [0x3813],AX (1000_E7A2 / 0x1E7A2)
    UInt16[DS, 0x3813] = AX;
    // MOV [0xdbc8],AL (1000_E7A5 / 0x1E7A5)
    UInt8[DS, 0xDBC8] = AL;
    // MOV AX,[0x398b] (1000_E7A8 / 0x1E7A8)
    AX = UInt16[DS, 0x398B];
    // ADD AX,0x10 (1000_E7AB / 0x1E7AB)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    // MOV [0x39b9],AX (1000_E7AE / 0x1E7AE)
    UInt16[DS, 0x39B9] = AX;
    // MOV word ptr [0x3cbc],0x3624 (1000_E7B1 / 0x1E7B1)
    UInt16[DS, 0x3CBC] = 0x3624;
    // JMP 0x1000:e76a (1000_E7B7 / 0x1E7B7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E76A_01E76A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_E7B9_1E7B9:
    // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_E7BC_1E7BC:
    // MOV AX,[0x3813] (1000_E7BC / 0x1E7BC)
    AX = UInt16[DS, 0x3813];
    // MOV [0x381b],AX (1000_E7BF / 0x1E7BF)
    UInt16[DS, 0x381B] = AX;
    // CALL 0x1000:a87e (1000_E7C2 / 0x1E7C2)
    NearCall(cs1, 0xE7C5, spice86_generated_label_call_target_1000_A87E_01A87E);
    label_1000_E7C5_1E7C5:
    // MOV AL,[0x2944] (1000_E7C5 / 0x1E7C5)
    AL = UInt8[DS, 0x2944];
    // AND AX,0xf (1000_E7C8 / 0x1E7C8)
    AX &= 0xF;
    // ADD AX,0x2 (1000_E7CB / 0x1E7CB)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // MOV SI,0x396f (1000_E7CE / 0x1E7CE)
    SI = 0x396F;
    // MOV CX,0x7 (1000_E7D1 / 0x1E7D1)
    CX = 0x7;
    // CALL 0x1000:e57b (1000_E7D4 / 0x1E7D4)
    NearCall(cs1, 0xE7D7, spice86_generated_label_call_target_1000_E57B_01E57B);
    label_1000_E7D7_1E7D7:
    // MOV BP,0x3349 (1000_E7D7 / 0x1E7D7)
    BP = 0x3349;
    // MOV CX,0xa (1000_E7DA / 0x1E7DA)
    CX = 0xA;
    // MOV AX,[0x39b3] (1000_E7DD / 0x1E7DD)
    AX = UInt16[DS, 0x39B3];
    // CALLF [0x396d] (1000_E7E0 / 0x1E7E0)
    // Indirect call to [0x396d], generating possible targets from emulator records
    uint targetAddress_1000_E7E0 = (uint)(UInt16[DS, 0x396F] * 0x10 + UInt16[DS, 0x396D] - cs1 * 0x10);
    switch(targetAddress_1000_E7E0) {
      case 0x464E0 : FarCall(cs1, 0xE7E4, spice86_generated_label_call_target_563E_0100_0564E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E7E0));
        break;
    }
    label_1000_E7E4_1E7E4:
    // OR word ptr [0xdbc8],BX (1000_E7E4 / 0x1E7E4)
    // UInt16[DS, 0xDBC8] |= BX;
    UInt16[DS, 0xDBC8] = Alu.Or16(UInt16[DS, 0xDBC8], BX);
    // CALL 0x1000:a650 (1000_E7E8 / 0x1E7E8)
    NearCall(cs1, 0xE7EB, spice86_generated_label_call_target_1000_A650_01A650);
    label_1000_E7EB_1E7EB:
    // CALL 0x1000:ae3f (1000_E7EB / 0x1E7EB)
    NearCall(cs1, 0xE7EE, spice86_generated_label_call_target_1000_AE3F_01AE3F);
    label_1000_E7EE_1E7EE:
    // CALL 0x1000:e851 (1000_E7EE / 0x1E7EE)
    NearCall(cs1, 0xE7F1, spice86_generated_label_call_target_1000_E851_01E851);
    label_1000_E7F1_1E7F1:
    // JC 0x1000:e818 (1000_E7F1 / 0x1E7F1)
    if(CarryFlag) {
      goto label_1000_E818_1E818;
    }
    // TEST byte ptr [0x2944],0xf (1000_E7F3 / 0x1E7F3)
    Alu.And8(UInt8[DS, 0x2944], 0xF);
    // JZ 0x1000:e7b9 (1000_E7F8 / 0x1E7F8)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [0x2944],0xf0 (1000_E7FA / 0x1E7FA)
    UInt8[DS, 0x2944] &= 0xF0;
    // XOR AX,AX (1000_E7FF / 0x1E7FF)
    AX = 0;
    // MOV [0xdbb8],AX (1000_E801 / 0x1E801)
    UInt16[DS, 0xDBB8] = AX;
    // MOV [0xdbc9],AL (1000_E804 / 0x1E804)
    UInt8[DS, 0xDBC9] = AL;
    // MOV AX,[0x396f] (1000_E807 / 0x1E807)
    AX = UInt16[DS, 0x396F];
    // ADD AX,0x10 (1000_E80A / 0x1E80A)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    // MOV [0x39b9],AX (1000_E80D / 0x1E80D)
    UInt16[DS, 0x39B9] = AX;
    // MOV word ptr [0x3cbc],0x364b (1000_E810 / 0x1E810)
    UInt16[DS, 0x3CBC] = 0x364B;
    // JMP 0x1000:e7c5 (1000_E816 / 0x1E816)
    goto label_1000_E7C5_1E7C5;
    label_1000_E818_1E818:
    // CALL 0x1000:ae28 (1000_E818 / 0x1E818)
    NearCall(cs1, 0xE81B, spice86_generated_label_call_target_1000_AE28_01AE28);
    label_1000_E81B_1E81B:
    // JZ 0x1000:e825 (1000_E81B / 0x1E81B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E825 / 0x1E825)
      return NearRet();
    }
    // CALL 0x1000:e826 (1000_E81D / 0x1E81D)
    NearCall(cs1, 0xE820, spice86_generated_label_call_target_1000_E826_01E826);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E826_01E826, 0x1E820 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E826_01E826(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xE820: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_E820_1E820:
    // AND byte ptr [0x2943],0xef (1000_E820 / 0x1E820)
    // UInt8[DS, 0x2943] &= 0xEF;
    UInt8[DS, 0x2943] = Alu.And8(UInt8[DS, 0x2943], 0xEF);
    label_1000_E825_1E825:
    // RET  (1000_E825 / 0x1E825)
    return NearRet();
    entry:
    label_1000_E826_1E826:
    // CMP word ptr [0xdbba],0x0 (1000_E826 / 0x1E826)
    Alu.Sub16(UInt16[DS, 0xDBBA], 0x0);
    // JZ 0x1000:e850 (1000_E82B / 0x1E82B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E850 / 0x1E850)
      return NearRet();
    }
    // CALL 0x1000:e741 (1000_E82D / 0x1E82D)
    NearCall(cs1, 0xE830, spice86_generated_label_call_target_1000_E741_01E741);
    label_1000_E830_1E830:
    // PUSH DS (1000_E830 / 0x1E830)
    Stack.Push(DS);
    // MOV SI,DI (1000_E831 / 0x1E831)
    SI = DI;
    // PUSH ES (1000_E833 / 0x1E833)
    Stack.Push(ES);
    // POP DS (1000_E834 / 0x1E834)
    DS = Stack.Pop();
    // LODSW SI (1000_E835 / 0x1E835)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,0xfa (1000_E836 / 0x1E836)
    CX = 0xFA;
    label_1000_E839_1E839:
    // PUSH CX (1000_E839 / 0x1E839)
    Stack.Push(CX);
    // PUSH SI (1000_E83A / 0x1E83A)
    Stack.Push(SI);
    // CALL 0x1000:f314 (1000_E83B / 0x1E83B)
    NearCall(cs1, 0xE83E, spice86_generated_label_call_target_1000_F314_01F314);
    label_1000_E83E_1E83E:
    // POP SI (1000_E83E / 0x1E83E)
    SI = Stack.Pop();
    // JC 0x1000:e849 (1000_E83F / 0x1E83F)
    if(CarryFlag) {
      goto label_1000_E849_1E849;
    }
    // CALL 0x1000:f3a7 (1000_E841 / 0x1E841)
    NearCall(cs1, 0xE844, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    label_1000_E844_1E844:
    // JNZ 0x1000:e849 (1000_E844 / 0x1E844)
    if(!ZeroFlag) {
      goto label_1000_E849_1E849;
    }
    // CALL 0x1000:e75b (1000_E846 / 0x1E846)
    NearCall(cs1, 0xE849, spice86_generated_label_call_target_1000_E75B_01E75B);
    label_1000_E849_1E849:
    // ADD SI,0x19 (1000_E849 / 0x1E849)
    // SI += 0x19;
    SI = Alu.Add16(SI, 0x19);
    // POP CX (1000_E84C / 0x1E84C)
    CX = Stack.Pop();
    // LOOP 0x1000:e839 (1000_E84D / 0x1E84D)
    if(--CX != 0) {
      goto label_1000_E839_1E839;
    }
    // POP DS (1000_E84F / 0x1E84F)
    DS = Stack.Pop();
    label_1000_E850_1E850:
    // RET  (1000_E850 / 0x1E850)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E851_01E851(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E851_1E851:
    // MOV AX,[0x39b9] (1000_E851 / 0x1E851)
    AX = UInt16[DS, 0x39B9];
    // ADD AX,0x2f13 (1000_E854 / 0x1E854)
    AX += 0x2F13;
    // CMP AX,word ptr [0xce68] (1000_E857 / 0x1E857)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    // RET  (1000_E85B / 0x1E85B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E85C_01E85C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E85C_1E85C:
    // CLI  (1000_E85C / 0x1E85C)
    InterruptFlag = false;
    // CALL 0x1000:e913 (1000_E85D / 0x1E85D)
    NearCall(cs1, 0xE860, spice86_generated_label_call_target_1000_E913_01E913);
    label_1000_E860_1E860:
    // XOR AX,AX (1000_E860 / 0x1E860)
    AX = 0;
    // MOV ES,AX (1000_E862 / 0x1E862)
    ES = AX;
    // MOV DI,0x20 (1000_E864 / 0x1E864)
    DI = 0x20;
    // MOV word ptr ES:[DI],0xe8b8 (1000_E867 / 0x1E867)
    UInt16[ES, DI] = 0xE8B8;
    // PUSHF  (1000_E86C / 0x1E86C)
    Stack.Push(FlagRegister);
    // STI  (1000_E86D / 0x1E86D)
    InterruptFlag = true;
    label_1000_E86E_1E86E:
    CheckExternalEvents(cs1, 0xE874);
    // CMP byte ptr CS:[0xe8d4],0x0 (1000_E86E / 0x1E86E)
    Alu.Sub8(UInt8[cs1, 0xE8D4], 0x0);
    // JZ 0x1000:e86e (1000_E874 / 0x1E874)
    if(ZeroFlag) {
      goto label_1000_E86E_1E86E;
    }
    // POPF  (1000_E876 / 0x1E876)
    FlagRegister = Stack.Pop();
    // MOV word ptr ES:[DI],0xef6a (1000_E877 / 0x1E877)
    UInt16[ES, DI] = 0xEF6A;
    // MOV AX,CS:[0xe8d2] (1000_E87C / 0x1E87C)
    AX = UInt16[cs1, 0xE8D2];
    // OR AH,AH (1000_E880 / 0x1E880)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:e8a5 (1000_E882 / 0x1E882)
    if(ZeroFlag) {
      goto label_1000_E8A5_1E8A5;
    }
    // OR AL,AL (1000_E884 / 0x1E884)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:e8a5 (1000_E886 / 0x1E886)
    if(ZeroFlag) {
      goto label_1000_E8A5_1E8A5;
    }
    // XOR DX,DX (1000_E888 / 0x1E888)
    DX = 0;
    // MOV CX,0x1745 (1000_E88A / 0x1E88A)
    CX = 0x1745;
    // DIV CX (1000_E88D / 0x1E88D)
    Cpu.Div16(CX);
    // SHL DX,1 (1000_E88F / 0x1E88F)
    DX <<= 0x1;
    // CMP DX,CX (1000_E891 / 0x1E891)
    Alu.Sub16(DX, CX);
    // JC 0x1000:e896 (1000_E893 / 0x1E893)
    if(CarryFlag) {
      goto label_1000_E896_1E896;
    }
    // INC AX (1000_E895 / 0x1E895)
    AX++;
    label_1000_E896_1E896:
    // DEC AX (1000_E896 / 0x1E896)
    AX = Alu.Dec16(AX);
    // JNS 0x1000:e89a (1000_E897 / 0x1E897)
    if(!SignFlag) {
      goto label_1000_E89A_1E89A;
    }
    // INC AX (1000_E899 / 0x1E899)
    AX++;
    label_1000_E89A_1E89A:
    // CMP AX,0xa (1000_E89A / 0x1E89A)
    Alu.Sub16(AX, 0xA);
    // JC 0x1000:e8a1 (1000_E89D / 0x1E89D)
    if(CarryFlag) {
      goto label_1000_E8A1_1E8A1;
    }
    // MOV AL,0xa (1000_E89F / 0x1E89F)
    AL = 0xA;
    label_1000_E8A1_1E8A1:
    // MOV CS:[0xefd9],AL (1000_E8A1 / 0x1E8A1)
    UInt8[cs1, 0xEFD9] = AL;
    label_1000_E8A5_1E8A5:
    // MOV AX,0x1745 (1000_E8A5 / 0x1E8A5)
    AX = 0x1745;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E8A8_01E8A8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E8A8_01E8A8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E8A8_1E8A8:
    // PUSHF  (1000_E8A8 / 0x1E8A8)
    Stack.Push(FlagRegister);
    // PUSH AX (1000_E8A9 / 0x1E8A9)
    Stack.Push(AX);
    // CLI  (1000_E8AA / 0x1E8AA)
    InterruptFlag = false;
    // MOV AL,0x36 (1000_E8AB / 0x1E8AB)
    AL = 0x36;
    // OUT 0x43,AL (1000_E8AD / 0x1E8AD)
    Cpu.Out8(0x43, AL);
    // POP AX (1000_E8AF / 0x1E8AF)
    AX = Stack.Pop();
    // OUT 0x40,AL (1000_E8B0 / 0x1E8B0)
    Cpu.Out8(0x40, AL);
    // MOV AL,AH (1000_E8B2 / 0x1E8B2)
    AL = AH;
    // OUT 0x40,AL (1000_E8B4 / 0x1E8B4)
    Cpu.Out8(0x40, AL);
    // POPF  (1000_E8B6 / 0x1E8B6)
    FlagRegister = Stack.Pop();
    // RET  (1000_E8B7 / 0x1E8B7)
    return NearRet();
  }
  
  public virtual Action get_pit_timer_value_ida_1000_E8B8_1E8B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E8B8_1E8B8:
    // PUSH AX (1000_E8B8 / 0x1E8B8)
    Stack.Push(AX);
    // MOV AL,0x36 (1000_E8B9 / 0x1E8B9)
    AL = 0x36;
    // OUT 0x43,AL (1000_E8BB / 0x1E8BB)
    Cpu.Out8(0x43, AL);
    // IN AL,0x40 (1000_E8BD / 0x1E8BD)
    AL = Cpu.In8(0x40);
    // MOV AH,AL (1000_E8BF / 0x1E8BF)
    AH = AL;
    // IN AL,0x40 (1000_E8C1 / 0x1E8C1)
    AL = Cpu.In8(0x40);
    // XCHG AL,AH (1000_E8C3 / 0x1E8C3)
    byte tmp_1000_E8C3 = AL;
    AL = AH;
    AH = tmp_1000_E8C3;
    // MOV CS:[0xe8d2],AX (1000_E8C5 / 0x1E8C5)
    UInt16[cs1, 0xE8D2] = AX;
    // INC byte ptr CS:[0xe8d4] (1000_E8C9 / 0x1E8C9)
    UInt8[cs1, 0xE8D4] = Alu.Inc8(UInt8[cs1, 0xE8D4]);
    // POP AX (1000_E8CE / 0x1E8CE)
    AX = Stack.Pop();
    // JMP 0x1000:ef6a (1000_E8CF / 0x1E8CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_EF6A_01EF6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E8D5_01E8D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E8D5_1E8D5:
    // CMP word ptr CS:[0xee8a],0x0 (1000_E8D5 / 0x1E8D5)
    Alu.Sub16(UInt16[cs1, 0xEE8A], 0x0);
    // JZ 0x1000:e8e2 (1000_E8DB / 0x1E8DB)
    if(ZeroFlag) {
      goto label_1000_E8E2_1E8E2;
    }
    // MOV AH,0xa (1000_E8DD / 0x1E8DD)
    AH = 0xA;
    // CALL 0x1000:ef2b (1000_E8DF / 0x1E8DF)
    NearCall(cs1, 0xE8E2, call_xms_func_on_block_ida_1000_EF2B_1EF2B);
    label_1000_E8E2_1E8E2:
    // CMP word ptr CS:[0xed3a],0x0 (1000_E8E2 / 0x1E8E2)
    Alu.Sub16(UInt16[cs1, 0xED3A], 0x0);
    // JZ 0x1000:e8ef (1000_E8E8 / 0x1E8E8)
    if(ZeroFlag) {
      goto label_1000_E8EF_1E8EF;
    }
    // MOV AH,0x45 (1000_E8EA / 0x1E8EA)
    AH = 0x45;
    // CALL 0x1000:ed40 (1000_E8EC / 0x1E8EC)
    NearCall(cs1, 0xE8EF, get_ems_emm_handle_ida_1000_ED40_1ED40);
    label_1000_E8EF_1E8EF:
    // MOV DX,word ptr CS:[0xed3e] (1000_E8EF / 0x1E8EF)
    DX = UInt16[cs1, 0xED3E];
    // OR DX,DX (1000_E8F4 / 0x1E8F4)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:e8fd (1000_E8F6 / 0x1E8F6)
    if(ZeroFlag) {
      goto label_1000_E8FD_1E8FD;
    }
    // MOV AH,0x45 (1000_E8F8 / 0x1E8F8)
    AH = 0x45;
    // CALL 0x1000:ed45 (1000_E8FA / 0x1E8FA)
    NearCall(cs1, 0xE8FD, call_ems_func_ida_1000_ED45_1ED45);
    label_1000_E8FD_1E8FD:
    // XOR AX,AX (1000_E8FD / 0x1E8FD)
    AX = 0;
    // CALL 0x1000:e8a8 (1000_E8FF / 0x1E8FF)
    NearCall(cs1, 0xE902, spice86_generated_label_call_target_1000_E8A8_01E8A8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E902_01E902, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
