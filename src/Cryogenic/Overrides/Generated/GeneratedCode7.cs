namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_5CD0_015CD0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5CD0_15CD0:
    // CALL 0x1000:58fa (1000_5CD0 / 0x15CD0)
    NearCall(cs1, 0x5CD3, spice86_generated_label_call_target_1000_58FA_0158FA);
    label_1000_5CD3_15CD3:
    // CMP byte ptr [0x1954],0x0 (1000_5CD3 / 0x15CD3)
    Alu.Sub8(UInt8[DS, 0x1954], 0x0);
    // JZ 0x1000:5ce3 (1000_5CD8 / 0x15CD8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5CE3 / 0x15CE3)
      return NearRet();
    }
    // CALL 0x1000:d316 (1000_5CDA / 0x15CDA)
    NearCall(cs1, 0x5CDD, spice86_generated_label_call_target_1000_D316_01D316);
    // CALL 0x1000:8763 (1000_5CDD / 0x15CDD)
    NearCall(cs1, 0x5CE0, spice86_generated_label_jump_target_1000_8763_018763);
    // CALL 0x1000:d280 (1000_5CE0 / 0x15CE0)
    NearCall(cs1, 0x5CE3, spice86_generated_label_call_target_1000_D280_01D280);
    label_1000_5CE3_15CE3:
    // RET  (1000_5CE3 / 0x15CE3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5D1D_015D1D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5D1D_15D1D:
    // CMP DX,word ptr [0x46e3] (1000_5D1D / 0x15D1D)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // CMC  (1000_5D21 / 0x15D21)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:5d35 (1000_5D22 / 0x15D22)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    // CMP DX,word ptr [0x46e7] (1000_5D24 / 0x15D24)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // JNC 0x1000:5d35 (1000_5D28 / 0x15D28)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e5] (1000_5D2A / 0x15D2A)
    Alu.Sub16(BX, UInt16[DS, 0x46E5]);
    // CMC  (1000_5D2E / 0x15D2E)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:5d35 (1000_5D2F / 0x15D2F)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e9] (1000_5D31 / 0x15D31)
    Alu.Sub16(BX, UInt16[DS, 0x46E9]);
    label_1000_5D35_15D35:
    // RET  (1000_5D35 / 0x15D35)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5D36_015D36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5D36_15D36:
    // CMP byte ptr [DI + 0x8],0x28 (1000_5D36 / 0x15D36)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JC 0x1000:5d43 (1000_5D3A / 0x15D3A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5D43 / 0x15D43)
      return NearRet();
    }
    // TEST byte ptr [DI + 0xa],0x8 (1000_5D3C / 0x15D3C)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    // JZ 0x1000:5d43 (1000_5D40 / 0x15D40)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5D43 / 0x15D43)
      return NearRet();
    }
    // STC  (1000_5D42 / 0x15D42)
    CarryFlag = true;
    label_1000_5D43_15D43:
    // RET  (1000_5D43 / 0x15D43)
    return NearRet();
  }
  
  public virtual Action split_1000_5D44_015D44(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5D44_15D44:
    // TEST byte ptr [0x11c9],0x3 (1000_5D44 / 0x15D44)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JZ 0x1000:5d50 (1000_5D49 / 0x15D49)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // OR byte ptr [0x4728],0x1 (1000_5D4B / 0x15D4B)
    // UInt8[DS, 0x4728] |= 0x1;
    UInt8[DS, 0x4728] = Alu.Or8(UInt8[DS, 0x4728], 0x1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5D50_015D50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5D50_15D50:
    // PUSH SI (1000_5D50 / 0x15D50)
    Stack.Push(SI);
    // PUSH DI (1000_5D51 / 0x15D51)
    Stack.Push(DI);
    // TEST byte ptr [DI + 0xa],0x80 (1000_5D52 / 0x15D52)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    // JNZ 0x1000:5d6a (1000_5D56 / 0x15D56)
    if(!ZeroFlag) {
      goto label_1000_5D6A_15D6A;
    }
    // CMP byte ptr [0x46eb],0x0 (1000_5D58 / 0x15D58)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JZ 0x1000:5d6a (1000_5D5D / 0x15D5D)
    if(ZeroFlag) {
      goto label_1000_5D6A_15D6A;
    }
    // MOV SI,DI (1000_5D5F / 0x15D5F)
    SI = DI;
    // CALL 0x1000:62c9 (1000_5D61 / 0x15D61)
    NearCall(cs1, 0x5D64, spice86_generated_label_call_target_1000_62C9_0162C9);
    // JC 0x1000:5d6a (1000_5D64 / 0x15D64)
    if(CarryFlag) {
      goto label_1000_5D6A_15D6A;
    }
    // INC byte ptr [0x46ec] (1000_5D66 / 0x15D66)
    UInt8[DS, 0x46EC] = Alu.Inc8(UInt8[DS, 0x46EC]);
    label_1000_5D6A_15D6A:
    // POP DI (1000_5D6A / 0x15D6A)
    DI = Stack.Pop();
    // POP SI (1000_5D6B / 0x15D6B)
    SI = Stack.Pop();
    // RET  (1000_5D6C / 0x15D6C)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5D6D_015D6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5D6D_15D6D:
    // MOV byte ptr [0x46ec],0x0 (1000_5D6D / 0x15D6D)
    UInt8[DS, 0x46EC] = 0x0;
    // CMP byte ptr [0x46eb],0x0 (1000_5D72 / 0x15D72)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:5d82 (1000_5D77 / 0x15D77)
    if(SignFlag) {
      goto label_1000_5D82_15D82;
    }
    // JZ 0x1000:5dcd (1000_5D79 / 0x15D79)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5DCD / 0x15DCD)
      return NearRet();
    }
    // CALL 0x1000:dbb2 (1000_5D7B / 0x15D7B)
    NearCall(cs1, 0x5D7E, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // JMP word ptr [0x46ed] (1000_5D7E / 0x15D7E)
    // Indirect jump to word ptr [0x46ed], generating possible targets from emulator records
    uint targetAddress_1000_5D7E = (uint)(UInt16[DS, 0x46ED]);
    switch(targetAddress_1000_5D7E) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5D7E));
        break;
    }
    label_1000_5D82_15D82:
    // CALL 0x1000:c07c (1000_5D82 / 0x15D82)
    NearCall(cs1, 0x5D85, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:dbb2 (1000_5D85 / 0x15D85)
    NearCall(cs1, 0x5D88, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:5b8d (1000_5D88 / 0x15D88)
    NearCall(cs1, 0x5D8B, spice86_generated_label_call_target_1000_5B8D_015B8D);
    // MOV AL,0x80 (1000_5D8B / 0x15D8B)
    AL = 0x80;
    // XCHG byte ptr [0x46eb],AL (1000_5D8D / 0x15D8D)
    byte tmp_1000_5D8D = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_5D8D;
    // PUSH AX (1000_5D91 / 0x15D91)
    Stack.Push(AX);
    // PUSH word ptr [0x46ef] (1000_5D92 / 0x15D92)
    Stack.Push(UInt16[DS, 0x46EF]);
    // CALL 0x1000:b6c3 (1000_5D96 / 0x15D96)
    NearCall(cs1, 0x5D99, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    // CALL 0x1000:c13b (1000_5D99 / 0x15D99)
    NearCall(cs1, 0x5D9C, spice86_generated_label_call_target_1000_C13B_01C13B);
    // CALL 0x1000:5dce (1000_5D9C / 0x15D9C)
    NearCall(cs1, 0x5D9F, spice86_generated_label_call_target_1000_5DCE_015DCE);
    // CALL 0x1000:6314 (1000_5D9F / 0x15D9F)
    NearCall(cs1, 0x5DA2, spice86_generated_label_call_target_1000_6314_016314);
    // CALL 0x1000:c412 (1000_5DA2 / 0x15DA2)
    NearCall(cs1, 0x5DA5, spice86_generated_label_call_target_1000_C412_01C412);
    // MOV word ptr [0x3cbe],0x0 (1000_5DA5 / 0x15DA5)
    UInt16[DS, 0x3CBE] = 0x0;
    // CALL 0x1000:6715 (1000_5DAB / 0x15DAB)
    NearCall(cs1, 0x5DAE, spice86_generated_label_call_target_1000_6715_016715);
    // MOV SI,0x46e3 (1000_5DAE / 0x15DAE)
    SI = 0x46E3;
    // CALL 0x1000:c6ad (1000_5DB1 / 0x15DB1)
    NearCall(cs1, 0x5DB4, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // POP SI (1000_5DB4 / 0x15DB4)
    SI = Stack.Pop();
    // OR SI,SI (1000_5DB5 / 0x15DB5)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:5dbc (1000_5DB7 / 0x15DB7)
    if(ZeroFlag) {
      goto label_1000_5DBC_15DBC;
    }
    // CALL 0x1000:697c (1000_5DB9 / 0x15DB9)
    NearCall(cs1, 0x5DBC, spice86_generated_label_call_target_1000_697C_01697C);
    label_1000_5DBC_15DBC:
    // CALL 0x1000:1c18 (1000_5DBC / 0x15DBC)
    NearCall(cs1, 0x5DBF, spice86_generated_label_call_target_1000_1C18_011C18);
    // POP AX (1000_5DBF / 0x15DBF)
    AX = Stack.Pop();
    // MOV [0x46eb],AL (1000_5DC0 / 0x15DC0)
    UInt8[DS, 0x46EB] = AL;
    // AND AL,0x40 (1000_5DC3 / 0x15DC3)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    // JZ 0x1000:5dca (1000_5DC5 / 0x15DC5)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:c13b (1000_5DCA / 0x15DCA)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:542f (1000_5DC7 / 0x15DC7)
    NearCall(cs1, 0x5DCA, not_observed_1000_542F_01542F);
    label_1000_5DCA_15DCA:
    // JMP 0x1000:c13b (1000_5DCA / 0x15DCA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5DCD_15DCD:
    // RET  (1000_5DCD / 0x15DCD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5DCE_015DCE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5DCE_15DCE:
    // MOV AL,[0x46eb] (1000_5DCE / 0x15DCE)
    AL = UInt8[DS, 0x46EB];
    // OR AL,AL (1000_5DD1 / 0x15DD1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:5dda (1000_5DD3 / 0x15DD3)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5DD9_015DD9, 0x15DDA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_5DD5 / 0x15DD5)
    Stack.Push(AX);
    // CALL 0x1000:633b (1000_5DD6 / 0x15DD6)
    NearCall(cs1, 0x5DD9, spice86_generated_label_call_target_1000_633B_01633B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5DD9_015DD9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5DD9_015DD9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x5DDA: goto label_1000_5DDA_15DDA;break; // Target of external jump from 0x15DD3
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_5DD9_15DD9:
    // POP AX (1000_5DD9 / 0x15DD9)
    AX = Stack.Pop();
    label_1000_5DDA_15DDA:
    // MOV DI,0xa5c0 (1000_5DDA / 0x15DDA)
    DI = 0xA5C0;
    // AND AL,0x40 (1000_5DDD / 0x15DDD)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    // JZ 0x1000:5df1 (1000_5DDF / 0x15DDF)
    if(ZeroFlag) {
      goto label_1000_5DF1_15DF1;
    }
    // SUB DI,0x6 (1000_5DE1 / 0x15DE1)
    DI -= 0x6;
    label_1000_5DE4_15DE4:
    // ADD DI,0x6 (1000_5DE4 / 0x15DE4)
    DI += 0x6;
    // CMP word ptr [DI],0x0 (1000_5DE7 / 0x15DE7)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    // JZ 0x1000:5df1 (1000_5DEA / 0x15DEA)
    if(ZeroFlag) {
      goto label_1000_5DF1_15DF1;
    }
    // TEST byte ptr [DI + 0x5],AL (1000_5DEC / 0x15DEC)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x5)], AL);
    // JZ 0x1000:5de4 (1000_5DEF / 0x15DEF)
    if(ZeroFlag) {
      goto label_1000_5DE4_15DE4;
    }
    label_1000_5DF1_15DF1:
    // MOV SI,0x100 (1000_5DF1 / 0x15DF1)
    SI = 0x100;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5DF4_015DF4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5DF4_015DF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5DF4_15DF4:
    // CMP word ptr [SI],-0x1 (1000_5DF4 / 0x15DF4)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JZ 0x1000:5e3d (1000_5DF7 / 0x15DF7)
    if(ZeroFlag) {
      goto label_1000_5E3D_15E3D;
    }
    // TEST byte ptr [SI + 0xa],0x80 (1000_5DF9 / 0x15DF9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JNZ 0x1000:5e38 (1000_5DFD / 0x15DFD)
    if(!ZeroFlag) {
      goto label_1000_5E38_15E38;
    }
    // CALL 0x1000:62c9 (1000_5DFF / 0x15DFF)
    NearCall(cs1, 0x5E02, spice86_generated_label_call_target_1000_62C9_0162C9);
    label_1000_5E02_15E02:
    // JC 0x1000:5e38 (1000_5E02 / 0x15E02)
    if(CarryFlag) {
      goto label_1000_5E38_15E38;
    }
    // MOV word ptr [DI],SI (1000_5E04 / 0x15E04)
    UInt16[DS, DI] = SI;
    // MOV word ptr [DI + 0x2],DX (1000_5E06 / 0x15E06)
    UInt16[DS, (ushort)(DI + 0x2)] = DX;
    // MOV BH,byte ptr [0x46eb] (1000_5E09 / 0x15E09)
    BH = UInt8[DS, 0x46EB];
    // MOV word ptr [DI + 0x4],BX (1000_5E0D / 0x15E0D)
    UInt16[DS, (ushort)(DI + 0x4)] = BX;
    // XOR BH,BH (1000_5E10 / 0x15E10)
    BH = 0;
    // CALL 0x1000:5e42 (1000_5E12 / 0x15E12)
    NearCall(cs1, 0x5E15, spice86_generated_label_call_target_1000_5E42_015E42);
    label_1000_5E15_15E15:
    // CMP CL,0x20 (1000_5E15 / 0x15E15)
    Alu.Sub8(CL, 0x20);
    // JNC 0x1000:5e2e (1000_5E18 / 0x15E18)
    if(!CarryFlag) {
      goto label_1000_5E2E_15E2E;
    }
    // PUSH AX (1000_5E1A / 0x15E1A)
    Stack.Push(AX);
    // PUSH BX (1000_5E1B / 0x15E1B)
    Stack.Push(BX);
    // PUSH DX (1000_5E1C / 0x15E1C)
    Stack.Push(DX);
    // PUSH SI (1000_5E1D / 0x15E1D)
    Stack.Push(SI);
    // CALL 0x1000:7c8f (1000_5E1E / 0x15E1E)
    NearCall(cs1, 0x5E21, spice86_generated_label_call_target_1000_7C8F_017C8F);
    label_1000_5E21_15E21:
    // CMP AX,word ptr [0x1176] (1000_5E21 / 0x15E21)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    // POP SI (1000_5E25 / 0x15E25)
    SI = Stack.Pop();
    // POP DX (1000_5E26 / 0x15E26)
    DX = Stack.Pop();
    // POP BX (1000_5E27 / 0x15E27)
    BX = Stack.Pop();
    // POP AX (1000_5E28 / 0x15E28)
    AX = Stack.Pop();
    // JBE 0x1000:5e2e (1000_5E29 / 0x15E29)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5E2E_15E2E;
    }
    // ADD AX,0x5 (1000_5E2B / 0x15E2B)
    // AX += 0x5;
    AX = Alu.Add16(AX, 0x5);
    label_1000_5E2E_15E2E:
    // PUSH SI (1000_5E2E / 0x15E2E)
    Stack.Push(SI);
    // PUSH DI (1000_5E2F / 0x15E2F)
    Stack.Push(DI);
    // CALL 0x1000:c343 (1000_5E30 / 0x15E30)
    NearCall(cs1, 0x5E33, spice86_generated_label_call_target_1000_C343_01C343);
    label_1000_5E33_15E33:
    // POP DI (1000_5E33 / 0x15E33)
    DI = Stack.Pop();
    // POP SI (1000_5E34 / 0x15E34)
    SI = Stack.Pop();
    // ADD DI,0x6 (1000_5E35 / 0x15E35)
    DI += 0x6;
    label_1000_5E38_15E38:
    // ADD SI,0x1c (1000_5E38 / 0x15E38)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    // JMP 0x1000:5df4 (1000_5E3B / 0x15E3B)
    goto label_1000_5DF4_15DF4;
    label_1000_5E3D_15E3D:
    // MOV word ptr [DI],0x0 (1000_5E3D / 0x15E3D)
    UInt16[DS, DI] = 0x0;
    // RET  (1000_5E41 / 0x15E41)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5E42_015E42(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5E42_15E42:
    // MOV AX,0x3a (1000_5E42 / 0x15E42)
    AX = 0x3A;
    // TEST byte ptr [0x46eb],0x80 (1000_5E45 / 0x15E45)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    // JZ 0x1000:5e4f (1000_5E4A / 0x15E4A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5E4F_015E4F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,0x7a (1000_5E4C / 0x15E4C)
    AX = 0x7A;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5E4F_015E4F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5E4F_015E4F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5E4F_15E4F:
    // MOV CL,byte ptr [SI + 0x8] (1000_5E4F / 0x15E4F)
    CL = UInt8[DS, (ushort)(SI + 0x8)];
    // CMP CL,0x20 (1000_5E52 / 0x15E52)
    Alu.Sub8(CL, 0x20);
    // JC 0x1000:5e6a (1000_5E55 / 0x15E55)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E57 / 0x15E57)
    AX++;
    // CMP CL,0x21 (1000_5E58 / 0x15E58)
    Alu.Sub8(CL, 0x21);
    // JC 0x1000:5e6a (1000_5E5B / 0x15E5B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E5D / 0x15E5D)
    AX++;
    // CMP CL,0x28 (1000_5E5E / 0x15E5E)
    Alu.Sub8(CL, 0x28);
    // JC 0x1000:5e6a (1000_5E61 / 0x15E61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E63 / 0x15E63)
    AX++;
    // CMP CL,0x30 (1000_5E64 / 0x15E64)
    Alu.Sub8(CL, 0x30);
    // JC 0x1000:5e6a (1000_5E67 / 0x15E67)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E69 / 0x15E69)
    AX = Alu.Inc16(AX);
    label_1000_5E6A_15E6A:
    // RET  (1000_5E6A / 0x15E6A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5E6D_015E6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5E6D_15E6D:
    // PUSH SI (1000_5E6D / 0x15E6D)
    Stack.Push(SI);
    // MOV BP,SP (1000_5E6E / 0x15E6E)
    BP = SP;
    // SUB SP,0x8 (1000_5E70 / 0x15E70)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    // MOV word ptr [BP + -0x8],0xffff (1000_5E73 / 0x15E73)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xFFFF;
    // MOV word ptr [BP + -0x6],DX (1000_5E78 / 0x15E78)
    UInt16[SS, (ushort)(BP - 0x6)] = DX;
    // MOV word ptr [BP + -0x4],BX (1000_5E7B / 0x15E7B)
    UInt16[SS, (ushort)(BP - 0x4)] = BX;
    // MOV word ptr [BP + -0x2],0x0 (1000_5E7E / 0x15E7E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    // MOV SI,0xa5ba (1000_5E83 / 0x15E83)
    SI = 0xA5BA;
    label_1000_5E86_15E86:
    // ADD SI,0x6 (1000_5E86 / 0x15E86)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    // MOV DI,word ptr [SI] (1000_5E89 / 0x15E89)
    DI = UInt16[DS, SI];
    // OR DI,DI (1000_5E8B / 0x15E8B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:5ebf (1000_5E8D / 0x15E8D)
    if(ZeroFlag) {
      goto label_1000_5EBF_15EBF;
    }
    // CMP byte ptr [DI + 0x8],AL (1000_5E8F / 0x15E8F)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], AL);
    // JNC 0x1000:5e86 (1000_5E92 / 0x15E92)
    if(!CarryFlag) {
      goto label_1000_5E86_15E86;
    }
    // MOV BX,word ptr [SI + 0x4] (1000_5E94 / 0x15E94)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP BH,byte ptr [0x46eb] (1000_5E97 / 0x15E97)
    Alu.Sub8(BH, UInt8[DS, 0x46EB]);
    // JNZ 0x1000:5e86 (1000_5E9B / 0x15E9B)
    if(!ZeroFlag) {
      goto label_1000_5E86_15E86;
    }
    // XOR BH,BH (1000_5E9D / 0x15E9D)
    BH = 0;
    // MOV DX,word ptr [SI + 0x2] (1000_5E9F / 0x15E9F)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB DX,word ptr [BP + -0x6] (1000_5EA2 / 0x15EA2)
    // DX -= UInt16[SS, (ushort)(BP - 0x6)];
    DX = Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x6)]);
    // JNS 0x1000:5ea9 (1000_5EA5 / 0x15EA5)
    if(!SignFlag) {
      goto label_1000_5EA9_15EA9;
    }
    // NEG DX (1000_5EA7 / 0x15EA7)
    DX = Alu.Sub16(0, DX);
    label_1000_5EA9_15EA9:
    // SUB BX,word ptr [BP + -0x4] (1000_5EA9 / 0x15EA9)
    // BX -= UInt16[SS, (ushort)(BP - 0x4)];
    BX = Alu.Sub16(BX, UInt16[SS, (ushort)(BP - 0x4)]);
    // JNS 0x1000:5eb0 (1000_5EAC / 0x15EAC)
    if(!SignFlag) {
      goto label_1000_5EB0_15EB0;
    }
    // NEG BX (1000_5EAE / 0x15EAE)
    BX = Alu.Sub16(0, BX);
    label_1000_5EB0_15EB0:
    // ADD DX,BX (1000_5EB0 / 0x15EB0)
    DX += BX;
    // CMP DX,word ptr [BP + -0x8] (1000_5EB2 / 0x15EB2)
    Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x8)]);
    // JNC 0x1000:5e86 (1000_5EB5 / 0x15EB5)
    if(!CarryFlag) {
      goto label_1000_5E86_15E86;
    }
    // MOV word ptr [BP + -0x8],DX (1000_5EB7 / 0x15EB7)
    UInt16[SS, (ushort)(BP - 0x8)] = DX;
    // MOV word ptr [BP + -0x2],DI (1000_5EBA / 0x15EBA)
    UInt16[SS, (ushort)(BP - 0x2)] = DI;
    // JMP 0x1000:5e86 (1000_5EBD / 0x15EBD)
    goto label_1000_5E86_15E86;
    label_1000_5EBF_15EBF:
    // MOV DI,word ptr [BP + -0x2] (1000_5EBF / 0x15EBF)
    DI = UInt16[SS, (ushort)(BP - 0x2)];
    // MOV AX,word ptr [BP + -0x8] (1000_5EC2 / 0x15EC2)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    // MOV DX,word ptr [BP + -0x6] (1000_5EC5 / 0x15EC5)
    DX = UInt16[SS, (ushort)(BP - 0x6)];
    // MOV BX,word ptr [BP + -0x4] (1000_5EC8 / 0x15EC8)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    // ADD SP,0x8 (1000_5ECB / 0x15ECB)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    // POP SI (1000_5ECE / 0x15ECE)
    SI = Stack.Pop();
    // RET  (1000_5ECF / 0x15ECF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5ED0_015ED0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5ED0_15ED0:
    // MOV BP,0xa5ba (1000_5ED0 / 0x15ED0)
    BP = 0xA5BA;
    label_1000_5ED3_15ED3:
    // ADD BP,0x6 (1000_5ED3 / 0x15ED3)
    // BP += 0x6;
    BP = Alu.Add16(BP, 0x6);
    // MOV AX,word ptr [BP + 0x0] (1000_5ED6 / 0x15ED6)
    AX = UInt16[SS, BP];
    // CMP AX,DI (1000_5ED9 / 0x15ED9)
    Alu.Sub16(AX, DI);
    // JZ 0x1000:5ee3 (1000_5EDB / 0x15EDB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5EE3 / 0x15EE3)
      return NearRet();
    }
    // OR AX,AX (1000_5EDD / 0x15EDD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNZ 0x1000:5ed3 (1000_5EDF / 0x15EDF)
    if(!ZeroFlag) {
      goto label_1000_5ED3_15ED3;
    }
    // OR BP,BP (1000_5EE1 / 0x15EE1)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5EE3_015EE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5EE3_015EE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5EE3_15EE3:
    // RET  (1000_5EE3 / 0x15EE3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5EE4_015EE4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5EE4_15EE4:
    // CALL 0x1000:5ed0 (1000_5EE4 / 0x15EE4)
    NearCall(cs1, 0x5EE7, spice86_generated_label_call_target_1000_5ED0_015ED0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5EE7_015EE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5EE7_015EE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5EE7_15EE7:
    // JNZ 0x1000:5ee3 (1000_5EE7 / 0x15EE7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_5EE3 / 0x15EE3)
      return NearRet();
    }
    // MOV SI,0x1668 (1000_5EE9 / 0x15EE9)
    SI = 0x1668;
    // CALL 0x1000:6252 (1000_5EEC / 0x15EEC)
    NearCall(cs1, 0x5EEF, spice86_generated_label_call_target_1000_6252_016252);
    label_1000_5EEF_15EEF:
    // MOV BX,AX (1000_5EEF / 0x15EEF)
    BX = AX;
    // INC AX (1000_5EF1 / 0x15EF1)
    AX++;
    // CMP DI,word ptr [0x46f8] (1000_5EF2 / 0x15EF2)
    Alu.Sub16(DI, UInt16[DS, 0x46F8]);
    // JNZ 0x1000:5f12 (1000_5EF6 / 0x15EF6)
    if(!ZeroFlag) {
      goto label_1000_5F12_15F12;
    }
    // CMP AL,byte ptr [0x46f7] (1000_5EF8 / 0x15EF8)
    Alu.Sub8(AL, UInt8[DS, 0x46F7]);
    // JNZ 0x1000:5f01 (1000_5EFC / 0x15EFC)
    if(!ZeroFlag) {
      goto label_1000_5F01_15F01;
    }
    // JMP 0x1000:7b1b (1000_5EFE / 0x15EFE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B1B_017B1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5F01_15F01:
    // CALL 0x1000:e270 (1000_5F01 / 0x15F01)
    NearCall(cs1, 0x5F04, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV byte ptr [0x46d8],0x1 (1000_5F04 / 0x15F04)
    UInt8[DS, 0x46D8] = 0x1;
    // CALL 0x1000:5f91 (1000_5F09 / 0x15F09)
    NearCall(cs1, 0x5F0C, spice86_generated_label_call_target_1000_5F91_015F91);
    // CALL 0x1000:c08e (1000_5F0C / 0x15F0C)
    NearCall(cs1, 0x5F0F, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:e283 (1000_5F0F / 0x15F0F)
    NearCall(cs1, 0x5F12, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_5F12_15F12:
    // MOV [0x46f7],AL (1000_5F12 / 0x15F12)
    UInt8[DS, 0x46F7] = AL;
    // MOV CL,byte ptr [BX + 0x11d0] (1000_5F15 / 0x15F15)
    CL = UInt8[DS, (ushort)(BX + 0x11D0)];
    // XOR CH,CH (1000_5F19 / 0x15F19)
    CH = 0;
    // MOV DX,word ptr [BP + 0x2] (1000_5F1B / 0x15F1B)
    DX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV BX,word ptr [BP + 0x4] (1000_5F1E / 0x15F1E)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    // OR BH,BH (1000_5F21 / 0x15F21)
    // BH |= BH;
    BH = Alu.Or8(BH, BH);
    // JNS 0x1000:5ee3 (1000_5F23 / 0x15F23)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_5EE3 / 0x15EE3)
      return NearRet();
    }
    // XOR BH,BH (1000_5F25 / 0x15F25)
    BH = 0;
    // PUSH BX (1000_5F27 / 0x15F27)
    Stack.Push(BX);
    // PUSH DX (1000_5F28 / 0x15F28)
    Stack.Push(DX);
    // MOV AX,CX (1000_5F29 / 0x15F29)
    AX = CX;
    // SHR AX,1 (1000_5F2B / 0x15F2B)
    AX >>= 0x1;
    // SUB BX,AX (1000_5F2D / 0x15F2D)
    BX -= AX;
    // CMP BX,0x4 (1000_5F2F / 0x15F2F)
    Alu.Sub16(BX, 0x4);
    // JGE 0x1000:5f37 (1000_5F32 / 0x15F32)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5F37_15F37;
    }
    // MOV BX,0x4 (1000_5F34 / 0x15F34)
    BX = 0x4;
    label_1000_5F37_15F37:
    // MOV AX,0x94 (1000_5F37 / 0x15F37)
    AX = 0x94;
    // SUB AX,CX (1000_5F3A / 0x15F3A)
    AX -= CX;
    // CMP BX,AX (1000_5F3C / 0x15F3C)
    Alu.Sub16(BX, AX);
    // JL 0x1000:5f42 (1000_5F3E / 0x15F3E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F42_15F42;
    }
    // MOV BX,AX (1000_5F40 / 0x15F40)
    BX = AX;
    label_1000_5F42_15F42:
    // ADD DX,0xf (1000_5F42 / 0x15F42)
    DX += 0xF;
    // CMP DX,0xd2 (1000_5F45 / 0x15F45)
    Alu.Sub16(DX, 0xD2);
    // JL 0x1000:5f4f (1000_5F49 / 0x15F49)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F4F_15F4F;
    }
    // SUB DX,0x82 (1000_5F4B / 0x15F4B)
    // DX -= 0x82;
    DX = Alu.Sub16(DX, 0x82);
    label_1000_5F4F_15F4F:
    // MOV word ptr [SI],DX (1000_5F4F / 0x15F4F)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_5F51 / 0x15F51)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // ADD DX,0x6a (1000_5F54 / 0x15F54)
    // DX += 0x6A;
    DX = Alu.Add16(DX, 0x6A);
    // MOV word ptr [SI + 0x4],DX (1000_5F57 / 0x15F57)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    // ADD BX,CX (1000_5F5A / 0x15F5A)
    // BX += CX;
    BX = Alu.Add16(BX, CX);
    // MOV word ptr [SI + 0x6],BX (1000_5F5C / 0x15F5C)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV word ptr [0xdbe0],SI (1000_5F5F / 0x15F5F)
    UInt16[DS, 0xDBE0] = SI;
    // POP DX (1000_5F63 / 0x15F63)
    DX = Stack.Pop();
    // POP BX (1000_5F64 / 0x15F64)
    BX = Stack.Pop();
    // MOV AX,0xa (1000_5F65 / 0x15F65)
    AX = 0xA;
    // SUB DX,AX (1000_5F68 / 0x15F68)
    DX -= AX;
    // SUB BX,AX (1000_5F6A / 0x15F6A)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // MOV DI,0xd816 (1000_5F6C / 0x15F6C)
    DI = 0xD816;
    // MOV word ptr [DI],DX (1000_5F6F / 0x15F6F)
    UInt16[DS, DI] = DX;
    // MOV word ptr [DI + 0x2],BX (1000_5F71 / 0x15F71)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    // MOV AL,0x6 (1000_5F74 / 0x15F74)
    AL = 0x6;
    // JMP 0x1000:7b0f (1000_5F76 / 0x15F76)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B0F_017B0F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5F79_015F79(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5F79_15F79:
    // XOR AX,AX (1000_5F79 / 0x15F79)
    AX = 0;
    // XCHG word ptr [0x46f8],AX (1000_5F7B / 0x15F7B)
    ushort tmp_1000_5F7B = UInt16[DS, 0x46F8];
    UInt16[DS, 0x46F8] = AX;
    AX = tmp_1000_5F7B;
    // OR AX,AX (1000_5F7F / 0x15F7F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:5f90 (1000_5F81 / 0x15F81)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5F90 / 0x15F90)
      return NearRet();
    }
    // CALL 0x1000:d41b (1000_5F83 / 0x15F83)
    NearCall(cs1, 0x5F86, spice86_generated_label_call_target_1000_D41B_01D41B);
    // MOV AL,byte ptr [BP + 0x0] (1000_5F86 / 0x15F86)
    AL = UInt8[SS, BP];
    // INC AL (1000_5F89 / 0x15F89)
    AL = Alu.Inc8(AL);
    // JZ 0x1000:5f91 (1000_5F8B / 0x15F8B)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5F91_015F91, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:d2e2 (1000_5F8D / 0x15F8D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5F90_15F90:
    // RET  (1000_5F90 / 0x15F90)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5F91_015F91(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5F91_15F91:
    // MOV word ptr [0x46f8],0x0 (1000_5F91 / 0x15F91)
    UInt16[DS, 0x46F8] = 0x0;
    // MOV byte ptr [0x46f7],0x0 (1000_5F97 / 0x15F97)
    UInt8[DS, 0x46F7] = 0x0;
    // MOV SI,0x1668 (1000_5F9C / 0x15F9C)
    SI = 0x1668;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_5F9F_015F9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5F9F_015F9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5F9F_15F9F:
    // CALL 0x1000:c07c (1000_5F9F / 0x15F9F)
    NearCall(cs1, 0x5FA2, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5FA2_015FA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5FA2_015FA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5FA2_15FA2:
    // MOV word ptr [0xdbe0],0x0 (1000_5FA2 / 0x15FA2)
    UInt16[DS, 0xDBE0] = 0x0;
    // CALL 0x1000:c6ad (1000_5FA8 / 0x15FA8)
    NearCall(cs1, 0x5FAB, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5FAB_015FAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5FAB_015FAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5FAB_15FAB:
    // MOV AL,0x8 (1000_5FAB / 0x15FAB)
    AL = 0x8;
    // JMP 0x1000:7b2b (1000_5FAD / 0x15FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B2B_017B2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5FB0_015FB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5FB0_15FB0:
    // CALL 0x1000:58fa (1000_5FB0 / 0x15FB0)
    NearCall(cs1, 0x5FB3, spice86_generated_label_call_target_1000_58FA_0158FA);
    label_1000_5FB3_15FB3:
    // CALL 0x1000:7b36 (1000_5FB3 / 0x15FB3)
    NearCall(cs1, 0x5FB6, spice86_generated_label_call_target_1000_7B36_017B36);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5FB6_015FB6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5FB6_015FB6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5FB6_15FB6:
    // CMP DI,word ptr [0x114e] (1000_5FB6 / 0x15FB6)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JZ 0x1000:600e (1000_5FBA / 0x15FBA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x8],0xff (1000_5FBC / 0x15FBC)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    // JZ 0x1000:5ff9 (1000_5FC1 / 0x15FC1)
    if(ZeroFlag) {
      goto label_1000_5FF9_15FF9;
    }
    // CMP byte ptr [0xb],0x2 (1000_5FC3 / 0x15FC3)
    Alu.Sub8(UInt8[DS, 0xB], 0x2);
    // JBE 0x1000:5fd8 (1000_5FC8 / 0x15FC8)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5FD8_15FD8;
    }
    // CMP byte ptr [0x8],0x20 (1000_5FCA / 0x15FCA)
    Alu.Sub8(UInt8[DS, 0x8], 0x20);
    // JNC 0x1000:600e (1000_5FCF / 0x15FCF)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x8],0x28 (1000_5FD1 / 0x15FD1)
    Alu.Sub8(UInt8[DS, 0x8], 0x28);
    // JNC 0x1000:600e (1000_5FD6 / 0x15FD6)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_5FD8_15FD8:
    // PUSH DI (1000_5FD8 / 0x15FD8)
    Stack.Push(DI);
    // MOV DI,word ptr [0x114e] (1000_5FD9 / 0x15FD9)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:7f27 (1000_5FDD / 0x15FDD)
    NearCall(cs1, 0x5FE0, spice86_generated_label_call_target_1000_7F27_017F27);
    label_1000_5FE0_15FE0:
    // POP DI (1000_5FE0 / 0x15FE0)
    DI = Stack.Pop();
    // MOV BP,0x20da (1000_5FE1 / 0x15FE1)
    BP = 0x20DA;
    // MOV AX,word ptr [BP + 0x2] (1000_5FE4 / 0x15FE4)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    // AND AH,0x1f (1000_5FE7 / 0x15FE7)
    AH &= 0x1F;
    // CMP byte ptr [0x46ff],0x0 (1000_5FEA / 0x15FEA)
    Alu.Sub8(UInt8[DS, 0x46FF], 0x0);
    // JNZ 0x1000:5ff4 (1000_5FEF / 0x15FEF)
    if(!ZeroFlag) {
      goto label_1000_5FF4_15FF4;
    }
    // OR AH,0x40 (1000_5FF1 / 0x15FF1)
    // AH |= 0x40;
    AH = Alu.Or8(AH, 0x40);
    label_1000_5FF4_15FF4:
    // MOV word ptr [BP + 0x2],AX (1000_5FF4 / 0x15FF4)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // JMP 0x1000:6003 (1000_5FF7 / 0x15FF7)
    goto label_1000_6003_16003;
    label_1000_5FF9_15FF9:
    // TEST byte ptr [0xa],0x40 (1000_5FF9 / 0x15FF9)
    Alu.And8(UInt8[DS, 0xA], 0x40);
    // JZ 0x1000:600e (1000_5FFE / 0x15FFE)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BP,0x20e6 (1000_6000 / 0x16000)
    BP = 0x20E6;
    label_1000_6003_16003:
    // PUSH BP (1000_6003 / 0x16003)
    Stack.Push(BP);
    // CALL 0x1000:600e (1000_6004 / 0x16004)
    NearCall(cs1, 0x6007, spice86_generated_label_call_target_1000_600E_01600E);
    label_1000_6007_16007:
    // POP BP (1000_6007 / 0x16007)
    BP = Stack.Pop();
    // MOV BX,0x5f91 (1000_6008 / 0x16008)
    BX = 0x5F91;
    // JMP 0x1000:d323 (1000_600B / 0x1600B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_600E_01600E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_600E_1600E:
    // CALL 0x1000:c08e (1000_600E / 0x1600E)
    NearCall(cs1, 0x6011, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_6011_16011:
    // PUSH DI (1000_6011 / 0x16011)
    Stack.Push(DI);
    // CALL 0x1000:5ee4 (1000_6012 / 0x16012)
    NearCall(cs1, 0x6015, spice86_generated_label_call_target_1000_5EE4_015EE4);
    label_1000_6015_16015:
    // POP DI (1000_6015 / 0x16015)
    DI = Stack.Pop();
    // MOV word ptr [0x46f8],DI (1000_6016 / 0x16016)
    UInt16[DS, 0x46F8] = DI;
    // CALL 0x1000:d068 (1000_601A / 0x1601A)
    NearCall(cs1, 0x601D, spice86_generated_label_call_target_1000_D068_01D068);
    label_1000_601D_1601D:
    // MOV CL,0x9a (1000_601D / 0x1601D)
    CL = 0x9A;
    // MOV CH,byte ptr [0x1671] (1000_601F / 0x1601F)
    CH = UInt8[DS, 0x1671];
    // MOV DX,word ptr [0x1668] (1000_6023 / 0x16023)
    DX = UInt16[DS, 0x1668];
    // MOV BX,word ptr [0x166a] (1000_6027 / 0x16027)
    BX = UInt16[DS, 0x166A];
    // ADD DX,0xc (1000_602B / 0x1602B)
    DX += 0xC;
    // ADD BX,0x4 (1000_602E / 0x1602E)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    // CALL 0x1000:629d (1000_6031 / 0x16031)
    NearCall(cs1, 0x6034, spice86_generated_label_call_target_1000_629D_01629D);
    label_1000_6034_16034:
    // MOV CL,0x96 (1000_6034 / 0x16034)
    CL = 0x96;
    // SUB DX,0x8 (1000_6036 / 0x16036)
    DX -= 0x8;
    // ADD BX,0x9 (1000_6039 / 0x16039)
    // BX += 0x9;
    BX = Alu.Add16(BX, 0x9);
    // CALL 0x1000:62a6 (1000_603C / 0x1603C)
    NearCall(cs1, 0x603F, spice86_generated_label_call_target_1000_62A6_0162A6);
    label_1000_603F_1603F:
    // CALL 0x1000:6252 (1000_603F / 0x1603F)
    NearCall(cs1, 0x6042, spice86_generated_label_call_target_1000_6252_016252);
    label_1000_6042_16042:
    // CMP AL,0x2 (1000_6042 / 0x16042)
    Alu.Sub8(AL, 0x2);
    // JZ 0x1000:6059 (1000_6044 / 0x16044)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:c07c (1000_6059 / 0x16059)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // TEST byte ptr [0xa],0x20 (1000_6046 / 0x16046)
    Alu.And8(UInt8[DS, 0xA], 0x20);
    // JZ 0x1000:6056 (1000_604B / 0x1604B)
    if(ZeroFlag) {
      goto label_1000_6056_16056;
    }
    // OR AL,AL (1000_604D / 0x1604D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:6056 (1000_604F / 0x1604F)
    if(!ZeroFlag) {
      goto label_1000_6056_16056;
    }
    // PUSH AX (1000_6051 / 0x16051)
    Stack.Push(AX);
    // CALL 0x1000:605c (1000_6052 / 0x16052)
    NearCall(cs1, 0x6055, not_observed_1000_605C_01605C);
    // POP AX (1000_6055 / 0x16055)
    AX = Stack.Pop();
    label_1000_6056_16056:
    // CALL 0x1000:60ac (1000_6056 / 0x16056)
    NearCall(cs1, 0x6059, not_observed_1000_60AC_0160AC);
    label_1000_6059_16059:
    // JMP 0x1000:c07c (1000_6059 / 0x16059)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_605C_01605C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_605C_1605C:
    // CALL 0x1000:d075 (1000_605C / 0x1605C)
    NearCall(cs1, 0x605F, spice86_generated_label_call_target_1000_D075_01D075);
    // MOV CL,0x90 (1000_605F / 0x1605F)
    CL = 0x90;
    // ADD BX,0xa (1000_6061 / 0x16061)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    // MOV DX,word ptr [0x1668] (1000_6064 / 0x16064)
    DX = UInt16[DS, 0x1668];
    // ADD DX,0x4 (1000_6068 / 0x16068)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // MOV AX,0x6c (1000_606B / 0x1606B)
    AX = 0x6C;
    // CALL 0x1000:d194 (1000_606E / 0x1606E)
    NearCall(cs1, 0x6071, spice86_generated_label_call_target_1000_D194_01D194);
    // MOV AL,byte ptr [DI + 0x1b] (1000_6071 / 0x16071)
    AL = UInt8[DS, (ushort)(DI + 0x1B)];
    // MOV SI,0x75 (1000_6074 / 0x16074)
    SI = 0x75;
    // MOV BP,0x6d (1000_6077 / 0x16077)
    BP = 0x6D;
    // TEST byte ptr [DI + 0xa],0x20 (1000_607A / 0x1607A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x20);
    // JZ 0x1000:609d (1000_607E / 0x1607E)
    if(ZeroFlag) {
      goto label_1000_609D_1609D;
    }
    // PUSH CX (1000_6080 / 0x16080)
    Stack.Push(CX);
    // PUSH AX (1000_6081 / 0x16081)
    Stack.Push(AX);
    // PUSH SI (1000_6082 / 0x16082)
    Stack.Push(SI);
    // CALL 0x1000:e295 (1000_6083 / 0x16083)
    NearCall(cs1, 0x6086, not_observed_1000_E295_01E295);
    // POP AX (1000_6086 / 0x16086)
    AX = Stack.Pop();
    // POP CX (1000_6087 / 0x16087)
    CX = Stack.Pop();
    // ADD BX,0x7 (1000_6088 / 0x16088)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    // MOV DX,word ptr [0x1668] (1000_608B / 0x1608B)
    DX = UInt16[DS, 0x1668];
    // ADD DX,0x4 (1000_608F / 0x1608F)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // MOV BP,word ptr [0x166c] (1000_6092 / 0x16092)
    BP = UInt16[DS, 0x166C];
    // PUSH BX (1000_6096 / 0x16096)
    Stack.Push(BX);
    // CALL 0x1000:617a (1000_6097 / 0x16097)
    NearCall(cs1, 0x609A, not_observed_1000_617A_01617A);
    // POP BX (1000_609A / 0x1609A)
    BX = Stack.Pop();
    // POP CX (1000_609B / 0x1609B)
    CX = Stack.Pop();
    // RET  (1000_609C / 0x1609C)
    return NearRet();
    label_1000_609D_1609D:
    // MOV AX,BP (1000_609D / 0x1609D)
    AX = BP;
    // ADD BX,0x7 (1000_609F / 0x1609F)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    // MOV DX,word ptr [0x1668] (1000_60A2 / 0x160A2)
    DX = UInt16[DS, 0x1668];
    // ADD DX,0xa (1000_60A6 / 0x160A6)
    // DX += 0xA;
    DX = Alu.Add16(DX, 0xA);
    // JMP 0x1000:d194 (1000_60A9 / 0x160A9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_60AC_0160AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_60AC_160AC:
    // CALL 0x1000:c13b (1000_60AC / 0x160AC)
    NearCall(cs1, 0x60AF, spice86_generated_label_call_target_1000_C13B_01C13B);
    // CALL 0x1000:d068 (1000_60AF / 0x160AF)
    NearCall(cs1, 0x60B2, spice86_generated_label_call_target_1000_D068_01D068);
    // MOV CL,0x9a (1000_60B2 / 0x160B2)
    CL = 0x9A;
    // MOV DX,word ptr [0x1668] (1000_60B4 / 0x160B4)
    DX = UInt16[DS, 0x1668];
    // ADD BX,0xc (1000_60B8 / 0x160B8)
    BX += 0xC;
    // ADD DX,0x4 (1000_60BB / 0x160BB)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // CALL 0x1000:627e (1000_60BE / 0x160BE)
    NearCall(cs1, 0x60C1, spice86_generated_label_call_target_1000_627E_01627E);
    // JC 0x1000:60d6 (1000_60C1 / 0x160C1)
    if(CarryFlag) {
      goto label_1000_60D6_160D6;
    }
    // MOV AX,0x6e (1000_60C3 / 0x160C3)
    AX = 0x6E;
    // CALL 0x1000:d194 (1000_60C6 / 0x160C6)
    NearCall(cs1, 0x60C9, spice86_generated_label_call_target_1000_D194_01D194);
    // ADD BX,0xa (1000_60C9 / 0x160C9)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    // LEA SI,[DI + 0x14] (1000_60CC / 0x160CC)
    SI = (ushort)(DI + 0x14);
    // MOV BP,word ptr [0x166e] (1000_60CF / 0x160CF)
    BP = UInt16[DS, 0x166E];
    // JMP 0x1000:7e3d (1000_60D3 / 0x160D3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7E3D_017E3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_60D6_160D6:
    // MOV AX,0x4c (1000_60D6 / 0x160D6)
    AX = 0x4C;
    // CALL 0x1000:d194 (1000_60D9 / 0x160D9)
    NearCall(cs1, 0x60DC, spice86_generated_label_call_target_1000_D194_01D194);
    // ADD BX,0x6 (1000_60DC / 0x160DC)
    BX += 0x6;
    // ADD DX,0x2f (1000_60DF / 0x160DF)
    // DX += 0x2F;
    DX = Alu.Add16(DX, 0x2F);
    // PUSH BX (1000_60E2 / 0x160E2)
    Stack.Push(BX);
    // PUSH DX (1000_60E3 / 0x160E3)
    Stack.Push(DX);
    // CALL 0x1000:60f8 (1000_60E4 / 0x160E4)
    NearCall(cs1, 0x60E7, not_observed_1000_60F8_0160F8);
    // XOR AH,AH (1000_60E7 / 0x160E7)
    AH = 0;
    // ADD AX,0xf (1000_60E9 / 0x160E9)
    // AX += 0xF;
    AX = Alu.Add16(AX, 0xF);
    // MOV CL,0x5 (1000_60EC / 0x160EC)
    CL = 0x5;
    // SHR AX,CL (1000_60EE / 0x160EE)
    AX >>= CL;
    // ADD AX,0x8e (1000_60F0 / 0x160F0)
    // AX += 0x8E;
    AX = Alu.Add16(AX, 0x8E);
    // POP DX (1000_60F3 / 0x160F3)
    DX = Stack.Pop();
    // POP BX (1000_60F4 / 0x160F4)
    BX = Stack.Pop();
    // JMP 0x1000:c22f (1000_60F5 / 0x160F5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_60F8_0160F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_60F8_160F8:
    // XOR BX,BX (1000_60F8 / 0x160F8)
    BX = 0;
    // XOR CX,CX (1000_60FA / 0x160FA)
    CX = 0;
    // XOR DX,DX (1000_60FC / 0x160FC)
    DX = 0;
    // MOV word ptr [0xd81c],DX (1000_60FE / 0x160FE)
    UInt16[DS, 0xD81C] = DX;
    // MOV BP,0x6155 (1000_6102 / 0x16102)
    BP = 0x6155;
    // CALL 0x1000:6603 (1000_6105 / 0x16105)
    NearCall(cs1, 0x6108, spice86_generated_label_call_target_1000_6603_016603);
    // XOR AX,AX (1000_6108 / 0x16108)
    AX = 0;
    // ADD BX,DX (1000_610A / 0x1610A)
    // BX += DX;
    BX = Alu.Add16(BX, DX);
    // JZ 0x1000:6114 (1000_610C / 0x1610C)
    if(ZeroFlag) {
      goto label_1000_6114_16114;
    }
    // XCHG DL,AH (1000_610E / 0x1610E)
    byte tmp_1000_610E = DL;
    DL = AH;
    AH = tmp_1000_610E;
    // XCHG DL,DH (1000_6110 / 0x16110)
    byte tmp_1000_6110 = DL;
    DL = DH;
    DH = tmp_1000_6110;
    // DIV BX (1000_6112 / 0x16112)
    Cpu.Div16(BX);
    label_1000_6114_16114:
    // MOV BX,AX (1000_6114 / 0x16114)
    BX = AX;
    // XOR AX,AX (1000_6116 / 0x16116)
    AX = 0;
    // MOV DX,word ptr [0xd81c] (1000_6118 / 0x16118)
    DX = UInt16[DS, 0xD81C];
    // ADD CX,DX (1000_611C / 0x1611C)
    // CX += DX;
    CX = Alu.Add16(CX, DX);
    // JZ 0x1000:6126 (1000_611E / 0x1611E)
    if(ZeroFlag) {
      goto label_1000_6126_16126;
    }
    // XCHG DL,AH (1000_6120 / 0x16120)
    byte tmp_1000_6120 = DL;
    DL = AH;
    AH = tmp_1000_6120;
    // XCHG DL,DH (1000_6122 / 0x16122)
    byte tmp_1000_6122 = DL;
    DL = DH;
    DH = tmp_1000_6122;
    // DIV CX (1000_6124 / 0x16124)
    Cpu.Div16(CX);
    label_1000_6126_16126:
    // MOV CX,AX (1000_6126 / 0x16126)
    CX = AX;
    // MOV SI,BX (1000_6128 / 0x16128)
    SI = BX;
    // CMP SI,CX (1000_612A / 0x1612A)
    Alu.Sub16(SI, CX);
    // JNC 0x1000:6130 (1000_612C / 0x1612C)
    if(!CarryFlag) {
      goto label_1000_6130_16130;
    }
    // MOV SI,CX (1000_612E / 0x1612E)
    SI = CX;
    label_1000_6130_16130:
    // MOV AX,BX (1000_6130 / 0x16130)
    AX = BX;
    // SUB AX,CX (1000_6132 / 0x16132)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // OR SI,SI (1000_6134 / 0x16134)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:613f (1000_6136 / 0x16136)
    if(ZeroFlag) {
      goto label_1000_613F_1613F;
    }
    // CWD  (1000_6138 / 0x16138)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    // XCHG AH,AL (1000_6139 / 0x16139)
    byte tmp_1000_6139 = AH;
    AH = AL;
    AL = tmp_1000_6139;
    // XCHG DL,AL (1000_613B / 0x1613B)
    byte tmp_1000_613B = DL;
    DL = AL;
    AL = tmp_1000_613B;
    // IDIV SI (1000_613D / 0x1613D)
    Cpu.IDiv16(SI);
    label_1000_613F_1613F:
    // SAR AX,1 (1000_613F / 0x1613F)
    AX = Alu.Sar16(AX, 0x1);
    // ADD AL,0x80 (1000_6141 / 0x16141)
    // AL += 0x80;
    AL = Alu.Add8(AL, 0x80);
    // RET  (1000_6143 / 0x16143)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6144_016144(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6144_16144:
    // CALL 0x1000:e270 (1000_6144 / 0x16144)
    NearCall(cs1, 0x6147, spice86_generated_label_call_target_1000_E270_01E270);
    // PUSH ES (1000_6147 / 0x16147)
    Stack.Push(ES);
    // CALL 0x1000:60f8 (1000_6148 / 0x16148)
    NearCall(cs1, 0x614B, not_observed_1000_60F8_0160F8);
    // OR AL,0x1 (1000_614B / 0x1614B)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // MOV [0xfd],AL (1000_614D / 0x1614D)
    UInt8[DS, 0xFD] = AL;
    // POP ES (1000_6150 / 0x16150)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_6151 / 0x16151)
    NearCall(cs1, 0x6154, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_6154 / 0x16154)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_617A_01617A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_617A_1617A:
    // AND CX,0xff (1000_617A / 0x1617A)
    // CX &= 0xFF;
    CX = Alu.And16(CX, 0xFF);
    // JZ 0x1000:61d2 (1000_617E / 0x1617E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_61D2 / 0x161D2)
      return NearRet();
    }
    // PUSH BX (1000_6180 / 0x16180)
    Stack.Push(BX);
    // PUSH DI (1000_6181 / 0x16181)
    Stack.Push(DI);
    // PUSH AX (1000_6182 / 0x16182)
    Stack.Push(AX);
    // PUSH DX (1000_6183 / 0x16183)
    Stack.Push(DX);
    // CALL 0x1000:c1f4 (1000_6184 / 0x16184)
    NearCall(cs1, 0x6187, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    // MOV DI,BP (1000_6187 / 0x16187)
    DI = BP;
    // SUB DI,DX (1000_6189 / 0x16189)
    // DI -= DX;
    DI = Alu.Sub16(DI, DX);
    // MOV BP,word ptr ES:[SI] (1000_618B / 0x1618B)
    BP = UInt16[ES, SI];
    // AND BP,0xfff (1000_618E / 0x1618E)
    BP &= 0xFFF;
    // ADD BP,0x2 (1000_6192 / 0x16192)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    // MOV AX,DI (1000_6195 / 0x16195)
    AX = DI;
    // XOR DX,DX (1000_6197 / 0x16197)
    DX = 0;
    // DIV CX (1000_6199 / 0x16199)
    Cpu.Div16(CX);
    // CMP AX,BP (1000_619B / 0x1619B)
    Alu.Sub16(AX, BP);
    // JNC 0x1000:61b5 (1000_619D / 0x1619D)
    if(!CarryFlag) {
      goto label_1000_61B5_161B5;
    }
    // SUB DI,BP (1000_619F / 0x1619F)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    // MOV AX,DI (1000_61A1 / 0x161A1)
    AX = DI;
    // XOR DX,DX (1000_61A3 / 0x161A3)
    DX = 0;
    // DIV CX (1000_61A5 / 0x161A5)
    Cpu.Div16(CX);
    // MOV BP,AX (1000_61A7 / 0x161A7)
    BP = AX;
    // CMP BP,0x2 (1000_61A9 / 0x161A9)
    Alu.Sub16(BP, 0x2);
    // JNC 0x1000:61b5 (1000_61AC / 0x161AC)
    if(!CarryFlag) {
      goto label_1000_61B5_161B5;
    }
    // MOV BP,0x2 (1000_61AE / 0x161AE)
    BP = 0x2;
    // MOV CX,DI (1000_61B1 / 0x161B1)
    CX = DI;
    // SHR CX,1 (1000_61B3 / 0x161B3)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    label_1000_61B5_161B5:
    // POP DX (1000_61B5 / 0x161B5)
    DX = Stack.Pop();
    // POP AX (1000_61B6 / 0x161B6)
    AX = Stack.Pop();
    label_1000_61B7_161B7:
    // PUSH AX (1000_61B7 / 0x161B7)
    Stack.Push(AX);
    // PUSH BX (1000_61B8 / 0x161B8)
    Stack.Push(BX);
    // PUSH CX (1000_61B9 / 0x161B9)
    Stack.Push(CX);
    // PUSH DX (1000_61BA / 0x161BA)
    Stack.Push(DX);
    // PUSH BP (1000_61BB / 0x161BB)
    Stack.Push(BP);
    // CALL 0x1000:c22f (1000_61BC / 0x161BC)
    NearCall(cs1, 0x61BF, spice86_generated_label_call_target_1000_C22F_01C22F);
    // POP BP (1000_61BF / 0x161BF)
    BP = Stack.Pop();
    // POP DX (1000_61C0 / 0x161C0)
    DX = Stack.Pop();
    // POP CX (1000_61C1 / 0x161C1)
    CX = Stack.Pop();
    // POP BX (1000_61C2 / 0x161C2)
    BX = Stack.Pop();
    // POP AX (1000_61C3 / 0x161C3)
    AX = Stack.Pop();
    // ADD DX,BP (1000_61C4 / 0x161C4)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    // LOOP 0x1000:61b7 (1000_61C6 / 0x161C6)
    if(--CX != 0) {
      goto label_1000_61B7_161B7;
    }
    // POP DI (1000_61C8 / 0x161C8)
    DI = Stack.Pop();
    // POP BX (1000_61C9 / 0x161C9)
    BX = Stack.Pop();
    // CALL 0x1000:c1f4 (1000_61CA / 0x161CA)
    NearCall(cs1, 0x61CD, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    // ADD BL,byte ptr ES:[SI + 0x2] (1000_61CD / 0x161CD)
    BL += UInt8[ES, (ushort)(SI + 0x2)];
    // INC BX (1000_61D1 / 0x161D1)
    BX = Alu.Inc16(BX);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_61D3_0161D3, 0x161D2 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_61D3_0161D3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x61D2: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_61D2_161D2:
    // RET  (1000_61D2 / 0x161D2)
    return NearRet();
    entry:
    label_1000_61D3_161D3:
    // AND CX,0xff (1000_61D3 / 0x161D3)
    // CX &= 0xFF;
    CX = Alu.And16(CX, 0xFF);
    // JZ 0x1000:61d2 (1000_61D7 / 0x161D7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_61D2 / 0x161D2)
      return NearRet();
    }
    // PUSH BX (1000_61D9 / 0x161D9)
    Stack.Push(BX);
    // PUSH DI (1000_61DA / 0x161DA)
    Stack.Push(DI);
    // PUSH AX (1000_61DB / 0x161DB)
    Stack.Push(AX);
    // PUSH DX (1000_61DC / 0x161DC)
    Stack.Push(DX);
    // CALL 0x1000:c1f4 (1000_61DD / 0x161DD)
    NearCall(cs1, 0x61E0, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_61E0_161E0:
    // MOV DI,BP (1000_61E0 / 0x161E0)
    DI = BP;
    // SUB DI,BX (1000_61E2 / 0x161E2)
    // DI -= BX;
    DI = Alu.Sub16(DI, BX);
    // MOV BP,word ptr ES:[SI + 0x2] (1000_61E4 / 0x161E4)
    BP = UInt16[ES, (ushort)(SI + 0x2)];
    // AND BP,0xff (1000_61E8 / 0x161E8)
    BP &= 0xFF;
    // ADD BP,0x2 (1000_61EC / 0x161EC)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    // MOV AX,DI (1000_61EF / 0x161EF)
    AX = DI;
    // XOR DX,DX (1000_61F1 / 0x161F1)
    DX = 0;
    // DIV CX (1000_61F3 / 0x161F3)
    Cpu.Div16(CX);
    // CMP AX,BP (1000_61F5 / 0x161F5)
    Alu.Sub16(AX, BP);
    // JNC 0x1000:620f (1000_61F7 / 0x161F7)
    if(!CarryFlag) {
      goto label_1000_620F_1620F;
    }
    // SUB DI,BP (1000_61F9 / 0x161F9)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    // MOV AX,DI (1000_61FB / 0x161FB)
    AX = DI;
    // XOR DX,DX (1000_61FD / 0x161FD)
    DX = 0;
    // DIV CX (1000_61FF / 0x161FF)
    Cpu.Div16(CX);
    // MOV BP,AX (1000_6201 / 0x16201)
    BP = AX;
    // CMP BP,0x2 (1000_6203 / 0x16203)
    Alu.Sub16(BP, 0x2);
    // JNC 0x1000:620f (1000_6206 / 0x16206)
    if(!CarryFlag) {
      goto label_1000_620F_1620F;
    }
    // MOV BP,0x2 (1000_6208 / 0x16208)
    BP = 0x2;
    // MOV CX,DI (1000_620B / 0x1620B)
    CX = DI;
    // SHR CX,1 (1000_620D / 0x1620D)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    label_1000_620F_1620F:
    // POP DX (1000_620F / 0x1620F)
    DX = Stack.Pop();
    // POP AX (1000_6210 / 0x16210)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_6211_016211, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6211_016211(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6211_16211:
    // PUSH AX (1000_6211 / 0x16211)
    Stack.Push(AX);
    // PUSH BX (1000_6212 / 0x16212)
    Stack.Push(BX);
    // PUSH CX (1000_6213 / 0x16213)
    Stack.Push(CX);
    // PUSH DX (1000_6214 / 0x16214)
    Stack.Push(DX);
    // PUSH BP (1000_6215 / 0x16215)
    Stack.Push(BP);
    // CALL 0x1000:c22f (1000_6216 / 0x16216)
    NearCall(cs1, 0x6219, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_6219_16219:
    // POP BP (1000_6219 / 0x16219)
    BP = Stack.Pop();
    // POP DX (1000_621A / 0x1621A)
    DX = Stack.Pop();
    // POP CX (1000_621B / 0x1621B)
    CX = Stack.Pop();
    // POP BX (1000_621C / 0x1621C)
    BX = Stack.Pop();
    // POP AX (1000_621D / 0x1621D)
    AX = Stack.Pop();
    // ADD BX,BP (1000_621E / 0x1621E)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    // LOOP 0x1000:6211 (1000_6220 / 0x16220)
    if(--CX != 0) {
      goto label_1000_6211_16211;
    }
    // POP DI (1000_6222 / 0x16222)
    DI = Stack.Pop();
    // POP BX (1000_6223 / 0x16223)
    BX = Stack.Pop();
    // CALL 0x1000:c1f4 (1000_6224 / 0x16224)
    NearCall(cs1, 0x6227, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_6227_16227:
    // MOV AX,word ptr ES:[SI] (1000_6227 / 0x16227)
    AX = UInt16[ES, SI];
    // AND AH,0xf (1000_622A / 0x1622A)
    AH &= 0xF;
    // ADD DX,AX (1000_622D / 0x1622D)
    DX += AX;
    // INC DX (1000_622F / 0x1622F)
    DX = Alu.Inc16(DX);
    // RET  (1000_6230 / 0x16230)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6231_016231(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6231_16231:
    // PUSH BX (1000_6231 / 0x16231)
    Stack.Push(BX);
    // MOV BL,byte ptr [DI + 0x8] (1000_6232 / 0x16232)
    BL = UInt8[DS, (ushort)(DI + 0x8)];
    // XOR AX,AX (1000_6235 / 0x16235)
    AX = 0;
    // CMP BL,0x20 (1000_6237 / 0x16237)
    Alu.Sub8(BL, 0x20);
    // JC 0x1000:6250 (1000_623A / 0x1623A)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // INC AX (1000_623C / 0x1623C)
    AX++;
    // CMP BL,0x21 (1000_623D / 0x1623D)
    Alu.Sub8(BL, 0x21);
    // JC 0x1000:6250 (1000_6240 / 0x16240)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // INC AX (1000_6242 / 0x16242)
    AX++;
    // CMP BL,0x28 (1000_6243 / 0x16243)
    Alu.Sub8(BL, 0x28);
    // JC 0x1000:6250 (1000_6246 / 0x16246)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // INC AX (1000_6248 / 0x16248)
    AX++;
    // CMP BL,0x30 (1000_6249 / 0x16249)
    Alu.Sub8(BL, 0x30);
    // JC 0x1000:6250 (1000_624C / 0x1624C)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // SUB AL,0x2 (1000_624E / 0x1624E)
    // AL -= 0x2;
    AL = Alu.Sub8(AL, 0x2);
    label_1000_6250_16250:
    // POP BX (1000_6250 / 0x16250)
    BX = Stack.Pop();
    // RET  (1000_6251 / 0x16251)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6252_016252(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6252_16252:
    // CALL 0x1000:627e (1000_6252 / 0x16252)
    NearCall(cs1, 0x6255, spice86_generated_label_call_target_1000_627E_01627E);
    label_1000_6255_16255:
    // JC 0x1000:627a (1000_6255 / 0x16255)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6269_016269, 0x1627A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:5d36 (1000_6257 / 0x16257)
    NearCall(cs1, 0x625A, spice86_generated_label_call_target_1000_5D36_015D36);
    label_1000_625A_1625A:
    // MOV AX,0x2 (1000_625A / 0x1625A)
    AX = 0x2;
    // JC 0x1000:6260 (1000_625D / 0x1625D)
    if(CarryFlag) {
      goto label_1000_6260_16260;
    }
    // RET  (1000_625F / 0x1625F)
    return NearRet();
    label_1000_6260_16260:
    // TEST byte ptr [DI + 0xa],0x10 (1000_6260 / 0x16260)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x10);
    // JZ 0x1000:627d (1000_6264 / 0x16264)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_627D / 0x1627D)
      return NearRet();
    }
    // CALL 0x1000:6231 (1000_6266 / 0x16266)
    NearCall(cs1, 0x6269, spice86_generated_label_call_target_1000_6231_016231);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6269_016269, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6269_016269(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6269_16269:
    // OR AX,AX (1000_6269 / 0x16269)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:627d (1000_626B / 0x1626B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_627D / 0x1627D)
      return NearRet();
    }
    // CMP AL,0x3 (1000_626D / 0x1626D)
    Alu.Sub8(AL, 0x3);
    // JNZ 0x1000:6274 (1000_626F / 0x1626F)
    if(!ZeroFlag) {
      goto label_1000_6274_16274;
    }
    // XOR AX,AX (1000_6271 / 0x16271)
    AX = 0;
    // RET  (1000_6273 / 0x16273)
    return NearRet();
    label_1000_6274_16274:
    // CMP AL,0x2 (1000_6274 / 0x16274)
    Alu.Sub8(AL, 0x2);
    // MOV AL,0x2 (1000_6276 / 0x16276)
    AL = 0x2;
    // JNZ 0x1000:627d (1000_6278 / 0x16278)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_627D / 0x1627D)
      return NearRet();
    }
    label_1000_627A_1627A:
    // MOV AX,0x1 (1000_627A / 0x1627A)
    AX = 0x1;
    label_1000_627D_1627D:
    // RET  (1000_627D / 0x1627D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_627E_01627E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_627E_1627E:
    // CALL 0x1000:e270 (1000_627E / 0x1627E)
    NearCall(cs1, 0x6281, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_6281_16281:
    // TEST byte ptr [DI + 0xa],0x2 (1000_6281 / 0x16281)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:6293 (1000_6285 / 0x16285)
    if(!ZeroFlag) {
      goto label_1000_6293_16293;
    }
    // CALL 0x1000:5d36 (1000_6287 / 0x16287)
    NearCall(cs1, 0x628A, spice86_generated_label_call_target_1000_5D36_015D36);
    label_1000_628A_1628A:
    // JC 0x1000:6298 (1000_628A / 0x1628A)
    if(CarryFlag) {
      goto label_1000_6298_16298;
    }
    // CALL 0x1000:5098 (1000_628C / 0x1628C)
    NearCall(cs1, 0x628F, not_observed_1000_5098_015098);
    // OR DX,DX (1000_628F / 0x1628F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:6298 (1000_6291 / 0x16291)
    if(ZeroFlag) {
      goto label_1000_6298_16298;
    }
    label_1000_6293_16293:
    // CALL 0x1000:e283 (1000_6293 / 0x16293)
    NearCall(cs1, 0x6296, spice86_generated_label_call_target_1000_E283_01E283);
    // STC  (1000_6296 / 0x16296)
    CarryFlag = true;
    // RET  (1000_6297 / 0x16297)
    return NearRet();
    label_1000_6298_16298:
    // CALL 0x1000:e283 (1000_6298 / 0x16298)
    NearCall(cs1, 0x629B, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_629B_1629B:
    // CLC  (1000_629B / 0x1629B)
    CarryFlag = false;
    // RET  (1000_629C / 0x1629C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_629D_01629D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_629D_1629D:
    // CALL 0x1000:6231 (1000_629D / 0x1629D)
    NearCall(cs1, 0x62A0, spice86_generated_label_call_target_1000_6231_016231);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_62A0_0162A0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_62A0_0162A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62A0_162A0:
    // ADD AX,0x44 (1000_62A0 / 0x162A0)
    // AX += 0x44;
    AX = Alu.Add16(AX, 0x44);
    // JMP 0x1000:d194 (1000_62A3 / 0x162A3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_62A6_0162A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62A6_162A6:
    // MOV AL,byte ptr [DI] (1000_62A6 / 0x162A6)
    AL = UInt8[DS, DI];
    // XOR AH,AH (1000_62A8 / 0x162A8)
    AH = 0;
    // ADD AX,0x0 (1000_62AA / 0x162AA)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    // CALL 0x1000:d194 (1000_62AD / 0x162AD)
    NearCall(cs1, 0x62B0, spice86_generated_label_call_target_1000_D194_01D194);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_62B0_0162B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_62B0_0162B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62B0_162B0:
    // CMP byte ptr [DI + 0x1],0x3 (1000_62B0 / 0x162B0)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x1)], 0x3);
    // MOV AL,0x20 (1000_62B4 / 0x162B4)
    AL = 0x20;
    // JC 0x1000:62ba (1000_62B6 / 0x162B6)
    if(CarryFlag) {
      goto label_1000_62BA_162BA;
    }
    // MOV AL,0x2d (1000_62B8 / 0x162B8)
    AL = 0x2D;
    label_1000_62BA_162BA:
    // CALL word ptr [0x2518] (1000_62BA / 0x162BA)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_62BA = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_62BA) {
      case 0xD12F : NearCall(cs1, 0x62BE, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      case 0xD096 : NearCall(cs1, 0x62BE, spice86_generated_label_call_target_1000_D096_01D096); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_62BA));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_62BE_0162BE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_62BE_0162BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62BE_162BE:
    // MOV AL,byte ptr [DI + 0x1] (1000_62BE / 0x162BE)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    // XOR AH,AH (1000_62C1 / 0x162C1)
    AH = 0;
    // ADD AX,0xc (1000_62C3 / 0x162C3)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    // JMP 0x1000:d19b (1000_62C6 / 0x162C6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D19B_01D19B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_62C9_0162C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62C9_162C9:
    // CMP byte ptr [0x46eb],0x1 (1000_62C9 / 0x162C9)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x1);
    // JC 0x1000:62f1 (1000_62CE / 0x162CE)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // MOV DX,word ptr [SI + 0x2] (1000_62D0 / 0x162D0)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,word ptr [SI + 0x4] (1000_62D3 / 0x162D3)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_62D6_0162D6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_62D6_0162D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62D6_162D6:
    // CALL 0x1000:b647 (1000_62D6 / 0x162D6)
    NearCall(cs1, 0x62D9, spice86_generated_label_call_target_1000_B647_01B647);
    label_1000_62D9_162D9:
    // CMP DX,word ptr [0x46e3] (1000_62D9 / 0x162D9)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // JC 0x1000:62f1 (1000_62DD / 0x162DD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // CMP DX,word ptr [0x46e7] (1000_62DF / 0x162DF)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // CMC  (1000_62E3 / 0x162E3)
    CarryFlag = !CarryFlag;
    // JC 0x1000:62f1 (1000_62E4 / 0x162E4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e5] (1000_62E6 / 0x162E6)
    Alu.Sub16(BX, UInt16[DS, 0x46E5]);
    // JC 0x1000:62f1 (1000_62EA / 0x162EA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e9] (1000_62EC / 0x162EC)
    Alu.Sub16(BX, UInt16[DS, 0x46E9]);
    // CMC  (1000_62F0 / 0x162F0)
    CarryFlag = !CarryFlag;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_62F1_0162F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_62F1_0162F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62F1_162F1:
    // RET  (1000_62F1 / 0x162F1)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_62F2_0162F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_62F2_162F2:
    // CALL 0x1000:68eb (1000_62F2 / 0x162F2)
    NearCall(cs1, 0x62F5, spice86_generated_label_call_target_1000_68EB_0168EB);
    // TEST byte ptr [SI + 0x3],0x40 (1000_62F5 / 0x162F5)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:6306 (1000_62F9 / 0x162F9)
    if(!ZeroFlag) {
      goto label_1000_6306_16306;
    }
    // MOV SI,word ptr [SI + 0x4] (1000_62FB / 0x162FB)
    SI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:62c9 (1000_62FE / 0x162FE)
    NearCall(cs1, 0x6301, spice86_generated_label_call_target_1000_62C9_0162C9);
    // MOV AX,0x36 (1000_6301 / 0x16301)
    AX = 0x36;
    // JMP 0x1000:6322 (1000_6304 / 0x16304)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6317_016317, 0x16322 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6306_16306:
    // MOV DX,word ptr [SI + 0x6] (1000_6306 / 0x16306)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV BX,word ptr [SI + 0x8] (1000_6309 / 0x16309)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    // CALL 0x1000:62d6 (1000_630C / 0x1630C)
    NearCall(cs1, 0x630F, spice86_generated_label_call_target_1000_62D6_0162D6);
    // MOV AX,0x36 (1000_630F / 0x1630F)
    AX = 0x36;
    // JMP 0x1000:6322 (1000_6312 / 0x16312)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6317_016317, 0x16322 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6314_016314(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6314_16314:
    // CALL 0x1000:407e (1000_6314 / 0x16314)
    NearCall(cs1, 0x6317, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6317_016317, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6317_016317(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6317_16317:
    // CALL 0x1000:62d6 (1000_6317 / 0x16317)
    NearCall(cs1, 0x631A, spice86_generated_label_call_target_1000_62D6_0162D6);
    label_1000_631A_1631A:
    // MOV AX,0x4c (1000_631A / 0x1631A)
    AX = 0x4C;
    // PUSHF  (1000_631D / 0x1631D)
    Stack.Push(FlagRegister);
    // SUB DX,0xd (1000_631E / 0x1631E)
    DX -= 0xD;
    // POPF  (1000_6321 / 0x16321)
    FlagRegister = Stack.Pop();
    label_1000_6322_16322:
    // JC 0x1000:62f1 (1000_6322 / 0x16322)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // PUSH word ptr [0x2784] (1000_6324 / 0x16324)
    Stack.Push(UInt16[DS, 0x2784]);
    // PUSH AX (1000_6328 / 0x16328)
    Stack.Push(AX);
    // CALL 0x1000:c137 (1000_6329 / 0x16329)
    NearCall(cs1, 0x632C, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_632C_1632C:
    // POP AX (1000_632C / 0x1632C)
    AX = Stack.Pop();
    // CALL 0x1000:c1f4 (1000_632D / 0x1632D)
    NearCall(cs1, 0x6330, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_6330_16330:
    // SUB BL,byte ptr ES:[SI + 0x2] (1000_6330 / 0x16330)
    // BL -= UInt8[ES, (ushort)(SI + 0x2)];
    BL = Alu.Sub8(BL, UInt8[ES, (ushort)(SI + 0x2)]);
    // CALL 0x1000:c30d (1000_6334 / 0x16334)
    NearCall(cs1, 0x6337, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_6337_16337:
    // POP AX (1000_6337 / 0x16337)
    AX = Stack.Pop();
    // JMP 0x1000:c13e (1000_6338 / 0x16338)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_633B_01633B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_633B_1633B:
    // MOV DX,word ptr [0x197c] (1000_633B / 0x1633B)
    DX = UInt16[DS, 0x197C];
    // MOV BX,word ptr [0x197e] (1000_633F / 0x1633F)
    BX = UInt16[DS, 0x197E];
    // SUB BX,0x12 (1000_6343 / 0x16343)
    // BX -= 0x12;
    BX = Alu.Sub16(BX, 0x12);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6346_016346, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6346_016346(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6346_16346:
    // CALL 0x1000:634d (1000_6346 / 0x16346)
    NearCall(cs1, 0x6349, spice86_generated_label_call_target_1000_634D_01634D);
    label_1000_6349_16349:
    // INC BX (1000_6349 / 0x16349)
    BX = Alu.Inc16(BX);
    // JNC 0x1000:6346 (1000_634A / 0x1634A)
    if(!CarryFlag) {
      goto label_1000_6346_16346;
    }
    // RET  (1000_634C / 0x1634C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_634D_01634D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_634D_1634D:
    // PUSH BX (1000_634D / 0x1634D)
    Stack.Push(BX);
    // PUSH DX (1000_634E / 0x1634E)
    Stack.Push(DX);
    // CALL 0x1000:62d6 (1000_634F / 0x1634F)
    NearCall(cs1, 0x6352, spice86_generated_label_call_target_1000_62D6_0162D6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6352_016352, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6352_016352(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6352_16352:
    // POP SI (1000_6352 / 0x16352)
    SI = Stack.Pop();
    // POP CX (1000_6353 / 0x16353)
    CX = Stack.Pop();
    // JC 0x1000:6369 (1000_6354 / 0x16354)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6369 / 0x16369)
      return NearRet();
    }
    // PUSH BX (1000_6356 / 0x16356)
    Stack.Push(BX);
    // PUSH CX (1000_6357 / 0x16357)
    Stack.Push(CX);
    // PUSH DX (1000_6358 / 0x16358)
    Stack.Push(DX);
    // PUSH SI (1000_6359 / 0x16359)
    Stack.Push(SI);
    // CALL 0x1000:636a (1000_635A / 0x1635A)
    NearCall(cs1, 0x635D, spice86_generated_label_call_target_1000_636A_01636A);
    label_1000_635D_1635D:
    // POP SI (1000_635D / 0x1635D)
    SI = Stack.Pop();
    // POP DX (1000_635E / 0x1635E)
    DX = Stack.Pop();
    // POP CX (1000_635F / 0x1635F)
    CX = Stack.Pop();
    // POP BX (1000_6360 / 0x16360)
    BX = Stack.Pop();
    // PUSH CX (1000_6361 / 0x16361)
    Stack.Push(CX);
    // PUSH SI (1000_6362 / 0x16362)
    Stack.Push(SI);
    // CALL 0x1000:639a (1000_6363 / 0x16363)
    NearCall(cs1, 0x6366, spice86_generated_label_call_target_1000_639A_01639A);
    label_1000_6366_16366:
    // POP DX (1000_6366 / 0x16366)
    DX = Stack.Pop();
    // POP BX (1000_6367 / 0x16367)
    BX = Stack.Pop();
    // CLC  (1000_6368 / 0x16368)
    CarryFlag = false;
    label_1000_6369_16369:
    // RET  (1000_6369 / 0x16369)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_636A_01636A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x6394: goto label_1000_6394_16394;break; // Target of external jump from 0x16386, 0x163B6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_636A_1636A:
    // XCHG SI,DX (1000_636A / 0x1636A)
    ushort tmp_1000_636A = SI;
    SI = DX;
    DX = tmp_1000_636A;
    // XCHG CX,BX (1000_636C / 0x1636C)
    ushort tmp_1000_636C = CX;
    CX = BX;
    BX = tmp_1000_636C;
    // CALL 0x1000:b58b (1000_636E / 0x1636E)
    NearCall(cs1, 0x6371, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_6371_16371:
    // XCHG SI,DX (1000_6371 / 0x16371)
    ushort tmp_1000_6371 = SI;
    SI = DX;
    DX = tmp_1000_6371;
    // MOV BX,CX (1000_6373 / 0x16373)
    BX = CX;
    label_1000_6375_16375:
    // MOV AX,word ptr ES:[DI] (1000_6375 / 0x16375)
    AX = UInt16[ES, DI];
    // AND AX,0x3030 (1000_6378 / 0x16378)
    AX &= 0x3030;
    // CMP AL,0x10 (1000_637B / 0x1637B)
    Alu.Sub8(AL, 0x10);
    // JZ 0x1000:6395 (1000_637D / 0x1637D)
    if(ZeroFlag) {
      goto label_1000_6395_16395;
    }
    label_1000_637F_1637F:
    // ADD DX,0x4 (1000_637F / 0x1637F)
    DX += 0x4;
    // CMP DX,word ptr [0x46e7] (1000_6382 / 0x16382)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // JNC 0x1000:6394 (1000_6386 / 0x16386)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6394 / 0x16394)
      return NearRet();
    }
    // INC DI (1000_6388 / 0x16388)
    DI++;
    // INC SI (1000_6389 / 0x16389)
    SI++;
    // CMP SI,BP (1000_638A / 0x1638A)
    Alu.Sub16(SI, BP);
    // JC 0x1000:6375 (1000_638C / 0x1638C)
    if(CarryFlag) {
      goto label_1000_6375_16375;
    }
    // SUB SI,BP (1000_638E / 0x1638E)
    SI -= BP;
    // SUB DI,BP (1000_6390 / 0x16390)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    // JMP 0x1000:6375 (1000_6392 / 0x16392)
    goto label_1000_6375_16375;
    label_1000_6394_16394:
    // RET  (1000_6394 / 0x16394)
    return NearRet();
    label_1000_6395_16395:
    // CALL 0x1000:63c7 (1000_6395 / 0x16395)
    NearCall(cs1, 0x6398, not_observed_1000_63C7_0163C7);
    // JMP 0x1000:637f (1000_6398 / 0x16398)
    goto label_1000_637F_1637F;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_639A_01639A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_639A_1639A:
    // XCHG SI,DX (1000_639A / 0x1639A)
    ushort tmp_1000_639A = SI;
    SI = DX;
    DX = tmp_1000_639A;
    // XCHG CX,BX (1000_639C / 0x1639C)
    ushort tmp_1000_639C = CX;
    CX = BX;
    BX = tmp_1000_639C;
    // CALL 0x1000:b58b (1000_639E / 0x1639E)
    NearCall(cs1, 0x63A1, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_63A1_163A1:
    // XCHG SI,DX (1000_63A1 / 0x163A1)
    ushort tmp_1000_63A1 = SI;
    SI = DX;
    DX = tmp_1000_63A1;
    // MOV BX,CX (1000_63A3 / 0x163A3)
    BX = CX;
    label_1000_63A5_163A5:
    // MOV AX,word ptr ES:[DI] (1000_63A5 / 0x163A5)
    AX = UInt16[ES, DI];
    // AND AX,0x3030 (1000_63A8 / 0x163A8)
    AX &= 0x3030;
    // CMP AL,0x10 (1000_63AB / 0x163AB)
    Alu.Sub8(AL, 0x10);
    // JZ 0x1000:63c2 (1000_63AD / 0x163AD)
    if(ZeroFlag) {
      goto label_1000_63C2_163C2;
    }
    label_1000_63AF_163AF:
    // SUB DX,0x4 (1000_63AF / 0x163AF)
    DX -= 0x4;
    // CMP DX,word ptr [0x46e3] (1000_63B2 / 0x163B2)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // JC 0x1000:6394 (1000_63B6 / 0x163B6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6394 / 0x16394)
      return NearRet();
    }
    // DEC DI (1000_63B8 / 0x163B8)
    DI--;
    // DEC SI (1000_63B9 / 0x163B9)
    SI = Alu.Dec16(SI);
    // JNS 0x1000:63a5 (1000_63BA / 0x163BA)
    if(!SignFlag) {
      goto label_1000_63A5_163A5;
    }
    // ADD SI,BP (1000_63BC / 0x163BC)
    SI += BP;
    // ADD DI,BP (1000_63BE / 0x163BE)
    // DI += BP;
    DI = Alu.Add16(DI, BP);
    // JMP 0x1000:63a5 (1000_63C0 / 0x163C0)
    goto label_1000_63A5_163A5;
    label_1000_63C2_163C2:
    // CALL 0x1000:63c7 (1000_63C2 / 0x163C2)
    NearCall(cs1, 0x63C5, not_observed_1000_63C7_0163C7);
    // JMP 0x1000:63af (1000_63C5 / 0x163C5)
    goto label_1000_63AF_163AF;
  }
  
  public virtual Action not_observed_1000_63C7_0163C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_63C7_163C7:
    // PUSH BX (1000_63C7 / 0x163C7)
    Stack.Push(BX);
    // PUSH DX (1000_63C8 / 0x163C8)
    Stack.Push(DX);
    // PUSH SI (1000_63C9 / 0x163C9)
    Stack.Push(SI);
    // PUSH DI (1000_63CA / 0x163CA)
    Stack.Push(DI);
    // PUSH BP (1000_63CB / 0x163CB)
    Stack.Push(BP);
    // PUSH ES (1000_63CC / 0x163CC)
    Stack.Push(ES);
    // CMP AH,0x10 (1000_63CD / 0x163CD)
    Alu.Sub8(AH, 0x10);
    // MOV AX,0x78 (1000_63D0 / 0x163D0)
    AX = 0x78;
    // JNZ 0x1000:63d6 (1000_63D3 / 0x163D3)
    if(!ZeroFlag) {
      goto label_1000_63D6_163D6;
    }
    // INC AX (1000_63D5 / 0x163D5)
    AX++;
    label_1000_63D6_163D6:
    // ADD BP,DI (1000_63D6 / 0x163D6)
    BP += DI;
    // AND DI,0x3 (1000_63D8 / 0x163D8)
    DI &= 0x3;
    // SHR BP,1 (1000_63DB / 0x163DB)
    BP >>= 0x1;
    // SHR BP,1 (1000_63DD / 0x163DD)
    BP >>= 0x1;
    // AND BP,0x3 (1000_63DF / 0x163DF)
    BP &= 0x3;
    // ADD BX,DI (1000_63E2 / 0x163E2)
    BX += DI;
    // ADD DX,BP (1000_63E4 / 0x163E4)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    // CALL 0x1000:c343 (1000_63E6 / 0x163E6)
    NearCall(cs1, 0x63E9, spice86_generated_label_call_target_1000_C343_01C343);
    // POP ES (1000_63E9 / 0x163E9)
    ES = Stack.Pop();
    // POP BP (1000_63EA / 0x163EA)
    BP = Stack.Pop();
    // POP DI (1000_63EB / 0x163EB)
    DI = Stack.Pop();
    // POP SI (1000_63EC / 0x163EC)
    SI = Stack.Pop();
    // POP DX (1000_63ED / 0x163ED)
    DX = Stack.Pop();
    // POP BX (1000_63EE / 0x163EE)
    BX = Stack.Pop();
    // RET  (1000_63EF / 0x163EF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_63F0_0163F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_63F0_163F0:
    // CMP byte ptr [0x46de],0x0 (1000_63F0 / 0x163F0)
    Alu.Sub8(UInt8[DS, 0x46DE], 0x0);
    // JZ 0x1000:642d (1000_63F5 / 0x163F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_642D / 0x1642D)
      return NearRet();
    }
    // MOV ES,word ptr [0xdd00] (1000_63F7 / 0x163F7)
    ES = UInt16[DS, 0xDD00];
    // MOV DI,0x100 (1000_63FB / 0x163FB)
    DI = 0x100;
    label_1000_63FE_163FE:
    // MOV AL,byte ptr [DI + 0xa] (1000_63FE / 0x163FE)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    // TEST AL,0x20 (1000_6401 / 0x16401)
    Alu.And8(AL, 0x20);
    // JZ 0x1000:6422 (1000_6403 / 0x16403)
    if(ZeroFlag) {
      goto label_1000_6422_16422;
    }
    // MOV BL,byte ptr [DI + 0x1b] (1000_6405 / 0x16405)
    BL = UInt8[DS, (ushort)(DI + 0x1B)];
    // MOV BH,0xfa (1000_6408 / 0x16408)
    BH = 0xFA;
    // CMP BL,BH (1000_640A / 0x1640A)
    Alu.Sub8(BL, BH);
    // JNC 0x1000:6422 (1000_640C / 0x1640C)
    if(!CarryFlag) {
      goto label_1000_6422_16422;
    }
    // MOV SI,word ptr [DI + 0x6] (1000_640E / 0x1640E)
    SI = UInt16[DS, (ushort)(DI + 0x6)];
    // CALL 0x1000:642e (1000_6411 / 0x16411)
    NearCall(cs1, 0x6414, spice86_generated_label_call_target_1000_642E_01642E);
    label_1000_6414_16414:
    // SHR DX,1 (1000_6414 / 0x16414)
    DX >>= 0x1;
    // INC DX (1000_6416 / 0x16416)
    DX++;
    // ADD BL,DL (1000_6417 / 0x16417)
    BL += DL;
    // CMP BL,BH (1000_6419 / 0x16419)
    Alu.Sub8(BL, BH);
    // JC 0x1000:641f (1000_641B / 0x1641B)
    if(CarryFlag) {
      goto label_1000_641F_1641F;
    }
    // MOV BL,BH (1000_641D / 0x1641D)
    BL = BH;
    label_1000_641F_1641F:
    // MOV byte ptr [DI + 0x1b],BL (1000_641F / 0x1641F)
    UInt8[DS, (ushort)(DI + 0x1B)] = BL;
    label_1000_6422_16422:
    // ADD DI,0x1c (1000_6422 / 0x16422)
    DI += 0x1C;
    // CMP word ptr [DI],-0x1 (1000_6425 / 0x16425)
    Alu.Sub16(UInt16[DS, DI], 0xFFFF);
    // JNZ 0x1000:63fe (1000_6428 / 0x16428)
    if(!ZeroFlag) {
      goto label_1000_63FE_163FE;
    }
    // JMP 0x1000:65b6 (1000_642A / 0x1642A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_65B6_0165B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_642D_1642D:
    // RET  (1000_642D / 0x1642D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_642E_01642E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_642E_1642E:
    // MOV CX,0x3 (1000_642E / 0x1642E)
    CX = 0x3;
    // DEC SI (1000_6431 / 0x16431)
    SI--;
    // XOR DX,DX (1000_6432 / 0x16432)
    DX = 0;
    label_1000_6434_16434:
    // LODSW ES:SI (1000_6434 / 0x16434)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // AND AX,0x3030 (1000_6436 / 0x16436)
    AX &= 0x3030;
    // CMP AH,0x10 (1000_6439 / 0x16439)
    Alu.Sub8(AH, 0x10);
    // JNZ 0x1000:643f (1000_643C / 0x1643C)
    if(!ZeroFlag) {
      goto label_1000_643F_1643F;
    }
    // INC DX (1000_643E / 0x1643E)
    DX++;
    label_1000_643F_1643F:
    // CMP AL,0x10 (1000_643F / 0x1643F)
    Alu.Sub8(AL, 0x10);
    // JNZ 0x1000:6444 (1000_6441 / 0x16441)
    if(!ZeroFlag) {
      goto label_1000_6444_16444;
    }
    // INC DX (1000_6443 / 0x16443)
    DX = Alu.Inc16(DX);
    label_1000_6444_16444:
    // LOOP 0x1000:6434 (1000_6444 / 0x16444)
    if(--CX != 0) {
      goto label_1000_6434_16434;
    }
    // RET  (1000_6446 / 0x16446)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6447_016447(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6447_16447:
    // MOV byte ptr [0x4739],0x30 (1000_6447 / 0x16447)
    UInt8[DS, 0x4739] = 0x30;
    // JMP 0x1000:6458 (1000_644C / 0x1644C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_644E_01644E, 0x16458 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_644E_01644E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_644E_1644E:
    // MOV byte ptr [0x4739],0x20 (1000_644E / 0x1644E)
    UInt8[DS, 0x4739] = 0x20;
    // XOR CX,CX (1000_6453 / 0x16453)
    CX = 0;
    // MOV CL,byte ptr [DI + 0xb] (1000_6455 / 0x16455)
    CL = UInt8[DS, (ushort)(DI + 0xB)];
    label_1000_6458_16458:
    // MOV word ptr CS:[0x64ed],0x646f (1000_6458 / 0x16458)
    UInt16[cs1, 0x64ED] = 0x646F;
    // MOV DX,word ptr [DI + 0x2] (1000_645F / 0x1645F)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_6462 / 0x16462)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV word ptr [0xd81c],DX (1000_6465 / 0x16465)
    UInt16[DS, 0xD81C] = DX;
    // MOV word ptr [0xd818],BX (1000_6469 / 0x16469)
    UInt16[DS, 0xD818] = BX;
    // JMP 0x1000:64b2 (1000_646D / 0x1646D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_64B2_0164B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_646F_01646F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_646F_1646F:
    // ADD BX,word ptr [0xd818] (1000_646F / 0x1646F)
    BX += UInt16[DS, 0xD818];
    // CMP BX,0x5d (1000_6473 / 0x16473)
    Alu.Sub16(BX, 0x5D);
    // JG 0x1000:64b1 (1000_6476 / 0x16476)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_64B1 / 0x164B1)
      return NearRet();
    }
    // CMP BX,-0x5d (1000_6478 / 0x16478)
    Alu.Sub16(BX, 0xFFA3);
    // JL 0x1000:64b1 (1000_647B / 0x1647B)
    if(SignFlag != OverflowFlag) {
      // JL target is RET, inlining.
      // RET  (1000_64B1 / 0x164B1)
      return NearRet();
    }
    // PUSH DX (1000_647D / 0x1647D)
    Stack.Push(DX);
    // MOV DX,word ptr [0xd81c] (1000_647E / 0x1647E)
    DX = UInt16[DS, 0xD81C];
    // CALL 0x1000:b58b (1000_6482 / 0x16482)
    NearCall(cs1, 0x6485, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_6485_16485:
    // POP AX (1000_6485 / 0x16485)
    AX = Stack.Pop();
    // ADD DI,AX (1000_6486 / 0x16486)
    DI += AX;
    // ADD DX,AX (1000_6488 / 0x16488)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // JNS 0x1000:6492 (1000_648A / 0x1648A)
    if(!SignFlag) {
      goto label_1000_6492_16492;
    }
    label_1000_648C_1648C:
    // ADD DI,BP (1000_648C / 0x1648C)
    DI += BP;
    // ADD DX,BP (1000_648E / 0x1648E)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    // JS 0x1000:648c (1000_6490 / 0x16490)
    if(SignFlag) {
      goto label_1000_648C_1648C;
    }
    label_1000_6492_16492:
    // MOV AL,byte ptr ES:[DI] (1000_6492 / 0x16492)
    AL = UInt8[ES, DI];
    // MOV AH,AL (1000_6495 / 0x16495)
    AH = AL;
    // AND AH,0x30 (1000_6497 / 0x16497)
    AH &= 0x30;
    // CMP AH,0x10 (1000_649A / 0x1649A)
    Alu.Sub8(AH, 0x10);
    // JZ 0x1000:64a5 (1000_649D / 0x1649D)
    if(ZeroFlag) {
      goto label_1000_64A5_164A5;
    }
    // XOR AL,AH (1000_649F / 0x1649F)
    // AL ^= AH;
    AL = Alu.Xor8(AL, AH);
    // OR AL,byte ptr [0x4739] (1000_64A1 / 0x164A1)
    // AL |= UInt8[DS, 0x4739];
    AL = Alu.Or8(AL, UInt8[DS, 0x4739]);
    label_1000_64A5_164A5:
    // STOSB ES:DI (1000_64A5 / 0x164A5)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // INC DX (1000_64A6 / 0x164A6)
    DX++;
    // CMP DX,BP (1000_64A7 / 0x164A7)
    Alu.Sub16(DX, BP);
    // JC 0x1000:64af (1000_64A9 / 0x164A9)
    if(CarryFlag) {
      goto label_1000_64AF_164AF;
    }
    // SUB DX,BP (1000_64AB / 0x164AB)
    DX -= BP;
    // SUB DI,BP (1000_64AD / 0x164AD)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    label_1000_64AF_164AF:
    // LOOP 0x1000:6492 (1000_64AF / 0x164AF)
    if(--CX != 0) {
      goto label_1000_6492_16492;
    }
    label_1000_64B1_164B1:
    // RET  (1000_64B1 / 0x164B1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_64B2_0164B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_64B2_164B2:
    // XOR BX,BX (1000_64B2 / 0x164B2)
    BX = 0;
    // MOV DX,BX (1000_64B4 / 0x164B4)
    DX = BX;
    // MOV DI,DX (1000_64B6 / 0x164B6)
    DI = DX;
    // SUB BX,CX (1000_64B8 / 0x164B8)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // MOV SI,CX (1000_64BA / 0x164BA)
    SI = CX;
    // DEC SI (1000_64BC / 0x164BC)
    SI = Alu.Dec16(SI);
    // MOV AX,CX (1000_64BD / 0x164BD)
    AX = CX;
    // XOR BP,BP (1000_64BF / 0x164BF)
    BP = 0;
    // JMP 0x1000:64c6 (1000_64C1 / 0x164C1)
    goto label_1000_64C6_164C6;
    label_1000_64C3_164C3:
    // INC BP (1000_64C3 / 0x164C3)
    BP++;
    // INC DX (1000_64C4 / 0x164C4)
    DX++;
    // DEC DI (1000_64C5 / 0x164C5)
    DI--;
    label_1000_64C6_164C6:
    // SUB AX,BP (1000_64C6 / 0x164C6)
    // AX -= BP;
    AX = Alu.Sub16(AX, BP);
    // JNS 0x1000:64c3 (1000_64C8 / 0x164C8)
    if(!SignFlag) {
      goto label_1000_64C3_164C3;
    }
    // CALL 0x1000:64ef (1000_64CA / 0x164CA)
    NearCall(cs1, 0x64CD, spice86_generated_label_call_target_1000_64EF_0164EF);
    label_1000_64CD_164CD:
    // INC BX (1000_64CD / 0x164CD)
    BX++;
    // DEC SI (1000_64CE / 0x164CE)
    SI--;
    // ADD AX,CX (1000_64CF / 0x164CF)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // JS 0x1000:64d5 (1000_64D1 / 0x164D1)
    if(SignFlag) {
      goto label_1000_64D5_164D5;
    }
    // LOOP 0x1000:64c3 (1000_64D3 / 0x164D3)
    if(--CX != 0) {
      goto label_1000_64C3_164C3;
    }
    label_1000_64D5_164D5:
    // INC BP (1000_64D5 / 0x164D5)
    BP++;
    // DEC CX (1000_64D6 / 0x164D6)
    CX = Alu.Dec16(CX);
    // JMP 0x1000:64de (1000_64D7 / 0x164D7)
    goto label_1000_64DE_164DE;
    label_1000_64D9_164D9:
    // INC DX (1000_64D9 / 0x164D9)
    DX++;
    // DEC DI (1000_64DA / 0x164DA)
    DI--;
    // SUB AX,BP (1000_64DB / 0x164DB)
    AX -= BP;
    // INC BP (1000_64DD / 0x164DD)
    BP = Alu.Inc16(BP);
    label_1000_64DE_164DE:
    // CALL 0x1000:64ef (1000_64DE / 0x164DE)
    NearCall(cs1, 0x64E1, spice86_generated_label_call_target_1000_64EF_0164EF);
    label_1000_64E1_164E1:
    // INC BX (1000_64E1 / 0x164E1)
    BX++;
    // DEC SI (1000_64E2 / 0x164E2)
    SI--;
    // ADD AX,CX (1000_64E3 / 0x164E3)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // JC 0x1000:64e9 (1000_64E5 / 0x164E5)
    if(CarryFlag) {
      goto label_1000_64E9_164E9;
    }
    // LOOP 0x1000:64de (1000_64E7 / 0x164E7)
    if(--CX != 0) {
      goto label_1000_64DE_164DE;
    }
    label_1000_64E9_164E9:
    // DEC CX (1000_64E9 / 0x164E9)
    CX = Alu.Dec16(CX);
    // JNS 0x1000:64d9 (1000_64EA / 0x164EA)
    if(!SignFlag) {
      goto label_1000_64D9_164D9;
    }
    // RET  (1000_64EC / 0x164EC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_64EF_0164EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_64EF_164EF:
    // PUSH AX (1000_64EF / 0x164EF)
    Stack.Push(AX);
    // PUSH BX (1000_64F0 / 0x164F0)
    Stack.Push(BX);
    // PUSH CX (1000_64F1 / 0x164F1)
    Stack.Push(CX);
    // PUSH DX (1000_64F2 / 0x164F2)
    Stack.Push(DX);
    // PUSH SI (1000_64F3 / 0x164F3)
    Stack.Push(SI);
    // PUSH DI (1000_64F4 / 0x164F4)
    Stack.Push(DI);
    // PUSH BP (1000_64F5 / 0x164F5)
    Stack.Push(BP);
    // MOV CX,DX (1000_64F6 / 0x164F6)
    CX = DX;
    // SUB CX,DI (1000_64F8 / 0x164F8)
    CX -= DI;
    // INC CX (1000_64FA / 0x164FA)
    CX = Alu.Inc16(CX);
    // MOV DX,DI (1000_64FB / 0x164FB)
    DX = DI;
    // PUSH SI (1000_64FD / 0x164FD)
    Stack.Push(SI);
    // PUSH CX (1000_64FE / 0x164FE)
    Stack.Push(CX);
    // PUSH DX (1000_64FF / 0x164FF)
    Stack.Push(DX);
    // CALL word ptr CS:[0x64ed] (1000_6500 / 0x16500)
    // Indirect call to word ptr CS:[0x64ed], generating possible targets from emulator records
    uint targetAddress_1000_6500 = (uint)(UInt16[cs1, 0x64ED]);
    switch(targetAddress_1000_6500) {
      case 0x646F : NearCall(cs1, 0x6505, spice86_generated_label_call_target_1000_646F_01646F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6500));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6505_016505, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6505_016505(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6505_16505:
    // POP DX (1000_6505 / 0x16505)
    DX = Stack.Pop();
    // POP CX (1000_6506 / 0x16506)
    CX = Stack.Pop();
    // POP BX (1000_6507 / 0x16507)
    BX = Stack.Pop();
    // CALL word ptr CS:[0x64ed] (1000_6508 / 0x16508)
    // Indirect call to word ptr CS:[0x64ed], generating possible targets from emulator records
    uint targetAddress_1000_6508 = (uint)(UInt16[cs1, 0x64ED]);
    switch(targetAddress_1000_6508) {
      case 0x646F : NearCall(cs1, 0x650D, spice86_generated_label_call_target_1000_646F_01646F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6508));
        break;
    }
    label_1000_650D_1650D:
    // POP BP (1000_650D / 0x1650D)
    BP = Stack.Pop();
    // POP DI (1000_650E / 0x1650E)
    DI = Stack.Pop();
    // POP SI (1000_650F / 0x1650F)
    SI = Stack.Pop();
    // POP DX (1000_6510 / 0x16510)
    DX = Stack.Pop();
    // POP CX (1000_6511 / 0x16511)
    CX = Stack.Pop();
    // POP BX (1000_6512 / 0x16512)
    BX = Stack.Pop();
    // POP AX (1000_6513 / 0x16513)
    AX = Stack.Pop();
    // RET  (1000_6514 / 0x16514)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_65B6_0165B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_65B6_165B6:
    // MOV ES,word ptr [0xdd00] (1000_65B6 / 0x165B6)
    ES = UInt16[DS, 0xDD00];
    // MOV SI,word ptr CS:[0x65b4] (1000_65BA / 0x165BA)
    SI = UInt16[cs1, 0x65B4];
    // XOR BP,BP (1000_65BF / 0x165BF)
    BP = 0;
    // MOV CX,0x46 (1000_65C1 / 0x165C1)
    CX = 0x46;
    label_1000_65C4_165C4:
    // SHR SI,1 (1000_65C4 / 0x165C4)
    // SI >>= 0x1;
    SI = Alu.Shr16(SI, 0x1);
    // JNC 0x1000:65cc (1000_65C6 / 0x165C6)
    if(!CarryFlag) {
      goto label_1000_65CC_165CC;
    }
    // XOR SI,0x402 (1000_65C8 / 0x165C8)
    // SI ^= 0x402;
    SI = Alu.Xor16(SI, 0x402);
    label_1000_65CC_165CC:
    // MOV DI,SI (1000_65CC / 0x165CC)
    DI = SI;
    label_1000_65CE_165CE:
    // MOV AL,byte ptr ES:[DI] (1000_65CE / 0x165CE)
    AL = UInt8[ES, DI];
    // MOV AH,AL (1000_65D1 / 0x165D1)
    AH = AL;
    // AND AH,0x30 (1000_65D3 / 0x165D3)
    AH &= 0x30;
    // CMP AH,0x10 (1000_65D6 / 0x165D6)
    Alu.Sub8(AH, 0x10);
    // JNZ 0x1000:65e2 (1000_65D9 / 0x165D9)
    if(!ZeroFlag) {
      goto label_1000_65E2_165E2;
    }
    // AND AL,0xcf (1000_65DB / 0x165DB)
    // AL &= 0xCF;
    AL = Alu.And8(AL, 0xCF);
    // OR AL,0x20 (1000_65DD / 0x165DD)
    // AL |= 0x20;
    AL = Alu.Or8(AL, 0x20);
    // STOSB ES:DI (1000_65DF / 0x165DF)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // DEC DI (1000_65E0 / 0x165E0)
    DI--;
    // INC BP (1000_65E1 / 0x165E1)
    BP++;
    label_1000_65E2_165E2:
    // ADD DI,0x7ff (1000_65E2 / 0x165E2)
    DI += 0x7FF;
    // CMP DI,0xc5f9 (1000_65E6 / 0x165E6)
    Alu.Sub16(DI, 0xC5F9);
    // JC 0x1000:65ce (1000_65EA / 0x165EA)
    if(CarryFlag) {
      goto label_1000_65CE_165CE;
    }
    // LOOP 0x1000:65c4 (1000_65EC / 0x165EC)
    if(--CX != 0) {
      goto label_1000_65C4_165C4;
    }
    // MOV word ptr CS:[0x65b4],SI (1000_65EE / 0x165EE)
    UInt16[cs1, 0x65B4] = SI;
    // OR BP,BP (1000_65F3 / 0x165F3)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JZ 0x1000:6602 (1000_65F5 / 0x165F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6602 / 0x16602)
      return NearRet();
    }
    // CMP byte ptr [0x46eb],0x0 (1000_65F7 / 0x165F7)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:6602 (1000_65FC / 0x165FC)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_6602 / 0x16602)
      return NearRet();
    }
    // INC byte ptr [0x46ec] (1000_65FE / 0x165FE)
    UInt8[DS, 0x46EC] = Alu.Inc8(UInt8[DS, 0x46EC]);
    label_1000_6602_16602:
    // RET  (1000_6602 / 0x16602)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6603_016603(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6603_16603:
    // PUSH SI (1000_6603 / 0x16603)
    Stack.Push(SI);
    // MOV AL,byte ptr [DI + 0x9] (1000_6604 / 0x16604)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6607_016607, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6607_016607(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6607_16607:
    // OR AL,AL (1000_6607 / 0x16607)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:661b (1000_6609 / 0x16609)
    if(ZeroFlag) {
      goto label_1000_661B_1661B;
    }
    // CALL 0x1000:6906 (1000_660B / 0x1660B)
    NearCall(cs1, 0x660E, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_660E_1660E:
    // PUSH SI (1000_660E / 0x1660E)
    Stack.Push(SI);
    // PUSH DI (1000_660F / 0x1660F)
    Stack.Push(DI);
    // PUSH BP (1000_6610 / 0x16610)
    Stack.Push(BP);
    // CALL BP (1000_6611 / 0x16611)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_6611 = (uint)(BP);
    switch(targetAddress_1000_6611) {
      case 0x1E0 : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_01E0_0101E0); break;
      case 0x316E : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_316E_01316E); break;
      case 0x3406 : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_3406_013406); break;
      case 0x34D0 : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_34D0_0134D0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6611));
        break;
    }
    label_1000_6613_16613:
    // POP BP (1000_6613 / 0x16613)
    BP = Stack.Pop();
    // POP DI (1000_6614 / 0x16614)
    DI = Stack.Pop();
    // POP SI (1000_6615 / 0x16615)
    SI = Stack.Pop();
    // MOV AL,byte ptr [SI + 0x1] (1000_6616 / 0x16616)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // JMP 0x1000:6607 (1000_6619 / 0x16619)
    goto label_1000_6607_16607;
    label_1000_661B_1661B:
    // POP SI (1000_661B / 0x1661B)
    SI = Stack.Pop();
    // RET  (1000_661C / 0x1661C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_661D_01661D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_661D_1661D:
    // PUSH SI (1000_661D / 0x1661D)
    Stack.Push(SI);
    // MOV AL,byte ptr [DI + 0x9] (1000_661E / 0x1661E)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6621_016621, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6621_016621(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6621_16621:
    // OR AL,AL (1000_6621 / 0x16621)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:6637 (1000_6623 / 0x16623)
    if(ZeroFlag) {
      goto label_1000_6637_16637;
    }
    // CALL 0x1000:6906 (1000_6625 / 0x16625)
    NearCall(cs1, 0x6628, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_6628_16628:
    // JNC 0x1000:6632 (1000_6628 / 0x16628)
    if(!CarryFlag) {
      goto label_1000_6632_16632;
    }
    // PUSH SI (1000_662A / 0x1662A)
    Stack.Push(SI);
    // PUSH DI (1000_662B / 0x1662B)
    Stack.Push(DI);
    // PUSH BP (1000_662C / 0x1662C)
    Stack.Push(BP);
    // CALL BP (1000_662D / 0x1662D)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_662D = (uint)(BP);
    switch(targetAddress_1000_662D) {
      case 0x4E04 : NearCall(cs1, 0x662F, spice86_generated_label_call_target_1000_4E04_014E04); break;
      case 0x6E82 : NearCall(cs1, 0x662F, spice86_generated_label_call_target_1000_6E82_016E82); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_662D));
        break;
    }
    label_1000_662F_1662F:
    // POP BP (1000_662F / 0x1662F)
    BP = Stack.Pop();
    // POP DI (1000_6630 / 0x16630)
    DI = Stack.Pop();
    // POP SI (1000_6631 / 0x16631)
    SI = Stack.Pop();
    label_1000_6632_16632:
    // MOV AL,byte ptr [SI + 0x1] (1000_6632 / 0x16632)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // JMP 0x1000:6621 (1000_6635 / 0x16635)
    goto label_1000_6621_16621;
    label_1000_6637_16637:
    // POP SI (1000_6637 / 0x16637)
    SI = Stack.Pop();
    // RET  (1000_6638 / 0x16638)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6639_016639(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6639_16639:
    // CALL 0x1000:6603 (1000_6639 / 0x16639)
    NearCall(cs1, 0x663C, spice86_generated_label_call_target_1000_6603_016603);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_663C_01663C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_663C_01663C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_663C_1663C:
    // PUSH SI (1000_663C / 0x1663C)
    Stack.Push(SI);
    // MOV SI,0x8aa (1000_663D / 0x1663D)
    SI = 0x8AA;
    label_1000_6640_16640:
    // MOV AL,byte ptr [SI + 0x3] (1000_6640 / 0x16640)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST AL,0x40 (1000_6643 / 0x16643)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:6665 (1000_6645 / 0x16645)
    if(ZeroFlag) {
      goto label_1000_6665_16665;
    }
    // PUSH BX (1000_6647 / 0x16647)
    Stack.Push(BX);
    // MOV BX,word ptr [SI + 0x4] (1000_6648 / 0x16648)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // AND AL,0x3 (1000_664B / 0x1664B)
    AL &= 0x3;
    // CMP AL,0x3 (1000_664D / 0x1664D)
    Alu.Sub8(AL, 0x3);
    // JNZ 0x1000:6654 (1000_664F / 0x1664F)
    if(!ZeroFlag) {
      goto label_1000_6654_16654;
    }
    // MOV BX,word ptr [SI + 0xc] (1000_6651 / 0x16651)
    BX = UInt16[DS, (ushort)(SI + 0xC)];
    label_1000_6654_16654:
    // CMP BX,DI (1000_6654 / 0x16654)
    Alu.Sub16(BX, DI);
    // POP BX (1000_6656 / 0x16656)
    BX = Stack.Pop();
    // JNZ 0x1000:6665 (1000_6657 / 0x16657)
    if(!ZeroFlag) {
      goto label_1000_6665_16665;
    }
    // PUSH SI (1000_6659 / 0x16659)
    Stack.Push(SI);
    // PUSH DI (1000_665A / 0x1665A)
    Stack.Push(DI);
    // PUSH BP (1000_665B / 0x1665B)
    Stack.Push(BP);
    // CMP byte ptr [SI + 0x3],0x80 (1000_665C / 0x1665C)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // CALL BP (1000_6660 / 0x16660)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_6660 = (uint)(BP);
    switch(targetAddress_1000_6660) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6660));
        break;
    }
    // POP BP (1000_6662 / 0x16662)
    BP = Stack.Pop();
    // POP DI (1000_6663 / 0x16663)
    DI = Stack.Pop();
    // POP SI (1000_6664 / 0x16664)
    SI = Stack.Pop();
    label_1000_6665_16665:
    // ADD SI,0x1b (1000_6665 / 0x16665)
    SI += 0x1B;
    // CMP SI,0xfbb (1000_6668 / 0x16668)
    Alu.Sub16(SI, 0xFBB);
    // JC 0x1000:6640 (1000_666C / 0x1666C)
    if(CarryFlag) {
      goto label_1000_6640_16640;
    }
    // POP SI (1000_666E / 0x1666E)
    SI = Stack.Pop();
    // RET  (1000_666F / 0x1666F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_668F_01668F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_668F_1668F:
    // TEST byte ptr [SI + 0x3],0x20 (1000_668F / 0x1668F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JNZ 0x1000:66b0 (1000_6693 / 0x16693)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_66B0 / 0x166B0)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_6695 / 0x16695)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:66b0 (1000_6699 / 0x16699)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_66B0 / 0x166B0)
      return NearRet();
    }
    // OR byte ptr [SI + 0x3],0x20 (1000_669B / 0x1669B)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x20;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // MOV byte ptr [SI + 0x19],0x0 (1000_669F / 0x1669F)
    UInt8[DS, (ushort)(SI + 0x19)] = 0x0;
    // MOV AX,[0x2] (1000_66A3 / 0x166A3)
    AX = UInt16[DS, 0x2];
    // MOV word ptr [SI + 0xa],AX (1000_66A6 / 0x166A6)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    // PUSH DI (1000_66A9 / 0x166A9)
    Stack.Push(DI);
    // MOV AL,0x4 (1000_66AA / 0x166AA)
    AL = 0x4;
    // CALL 0x1000:6fb0 (1000_66AC / 0x166AC)
    NearCall(cs1, 0x66AF, not_observed_1000_6FB0_016FB0);
    // POP DI (1000_66AF / 0x166AF)
    DI = Stack.Pop();
    label_1000_66B0_166B0:
    // RET  (1000_66B0 / 0x166B0)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_66B1_0166B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_66B1_166B1:
    // CALL 0x1000:858c (1000_66B1 / 0x166B1)
    NearCall(cs1, 0x66B4, not_observed_1000_858C_01858C);
    // PUSH SI (1000_66B4 / 0x166B4)
    Stack.Push(SI);
    // PUSH DI (1000_66B5 / 0x166B5)
    Stack.Push(DI);
    // CALL 0x1000:6917 (1000_66B6 / 0x166B6)
    NearCall(cs1, 0x66B9, spice86_generated_label_call_target_1000_6917_016917);
    // JNZ 0x1000:66be (1000_66B9 / 0x166B9)
    if(!ZeroFlag) {
      goto label_1000_66BE_166BE;
    }
    // CALL 0x1000:c58a (1000_66BB / 0x166BB)
    NearCall(cs1, 0x66BE, spice86_generated_label_call_target_1000_C58A_01C58A);
    label_1000_66BE_166BE:
    // POP DI (1000_66BE / 0x166BE)
    DI = Stack.Pop();
    // POP SI (1000_66BF / 0x166BF)
    SI = Stack.Pop();
    // MOV word ptr [SI + 0x4],0xfbc (1000_66C0 / 0x166C0)
    UInt16[DS, (ushort)(SI + 0x4)] = 0xFBC;
    // MOV byte ptr [SI + 0x3],0xa0 (1000_66C5 / 0x166C5)
    UInt8[DS, (ushort)(SI + 0x3)] = 0xA0;
    // MOV byte ptr [SI + 0x1a],0x0 (1000_66C9 / 0x166C9)
    UInt8[DS, (ushort)(SI + 0x1A)] = 0x0;
    // RET  (1000_66CD / 0x166CD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_66CE_0166CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_66CE_166CE:
    // TEST byte ptr [SI + 0x3],0x80 (1000_66CE / 0x166CE)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // JZ 0x1000:6714 (1000_66D2 / 0x166D2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6714 / 0x16714)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_66D4 / 0x166D4)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:6714 (1000_66D8 / 0x166D8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6714 / 0x16714)
      return NearRet();
    }
    // INC byte ptr [0x28] (1000_66DA / 0x166DA)
    UInt8[DS, 0x28] = Alu.Inc8(UInt8[DS, 0x28]);
    // MOV AL,[0x28] (1000_66DE / 0x166DE)
    AL = UInt8[DS, 0x28];
    // CMP AL,byte ptr [0x1178] (1000_66E1 / 0x166E1)
    Alu.Sub8(AL, UInt8[DS, 0x1178]);
    // JC 0x1000:66ee (1000_66E5 / 0x166E5)
    if(CarryFlag) {
      goto label_1000_66EE_166EE;
    }
    // PUSH SI (1000_66E7 / 0x166E7)
    Stack.Push(SI);
    // MOV AL,0x4c (1000_66E8 / 0x166E8)
    AL = 0x4C;
    // CALL 0x1000:121f (1000_66EA / 0x166EA)
    NearCall(cs1, 0x66ED, spice86_generated_label_jump_target_1000_121F_01121F);
    // POP SI (1000_66ED / 0x166ED)
    SI = Stack.Pop();
    label_1000_66EE_166EE:
    // MOV AL,0x1 (1000_66EE / 0x166EE)
    AL = 0x1;
    // CALL 0x1000:6f78 (1000_66F0 / 0x166F0)
    NearCall(cs1, 0x66F3, spice86_generated_label_call_target_1000_6F78_016F78);
    label_1000_66F3_166F3:
    // AND byte ptr [SI + 0x3],0x20 (1000_66F3 / 0x166F3)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0x20;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // OR byte ptr [SI + 0x3],0x2 (1000_66F7 / 0x166F7)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x2;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x2);
    // CALL 0x1000:6b25 (1000_66FB / 0x166FB)
    NearCall(cs1, 0x66FE, spice86_generated_label_call_target_1000_6B25_016B25);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_66FE_0166FE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_66FE_0166FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_66FE_166FE:
    // CALL 0x1000:1ac5 (1000_66FE / 0x166FE)
    NearCall(cs1, 0x6701, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6701_016701, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6701_016701(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6701_16701:
    // MOV byte ptr [SI + 0x14],AL (1000_6701 / 0x16701)
    UInt8[DS, (ushort)(SI + 0x14)] = AL;
    // MOV DI,word ptr [SI + 0x4] (1000_6704 / 0x16704)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP byte ptr [DI + 0xb],0x0 (1000_6707 / 0x16707)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0xB)], 0x0);
    // JNZ 0x1000:6714 (1000_670B / 0x1670B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6714 / 0x16714)
      return NearRet();
    }
    // MOV byte ptr [DI + 0xb],0x2 (1000_670D / 0x1670D)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x2;
    // CALL 0x1000:644e (1000_6711 / 0x16711)
    NearCall(cs1, 0x6714, spice86_generated_label_call_target_1000_644E_01644E);
    label_1000_6714_16714:
    // RET  (1000_6714 / 0x16714)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6715_016715(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6715_16715:
    // MOV BP,0xa5c0 (1000_6715 / 0x16715)
    BP = 0xA5C0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6718_016718, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6718_016718(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6718_16718:
    // MOV DI,word ptr [BP + 0x0] (1000_6718 / 0x16718)
    DI = UInt16[SS, BP];
    // OR DI,DI (1000_671B / 0x1671B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:6737 (1000_671D / 0x1671D)
    if(ZeroFlag) {
      goto label_1000_6737_16737;
    }
    // MOV AL,byte ptr [DI + 0x9] (1000_671F / 0x1671F)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // OR AL,AL (1000_6722 / 0x16722)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:6732 (1000_6724 / 0x16724)
    if(ZeroFlag) {
      goto label_1000_6732_16732;
    }
    label_1000_6726_16726:
    // PUSH BP (1000_6726 / 0x16726)
    Stack.Push(BP);
    // CALL 0x1000:6757 (1000_6727 / 0x16727)
    NearCall(cs1, 0x672A, spice86_generated_label_call_target_1000_6757_016757);
    label_1000_672A_1672A:
    // POP BP (1000_672A / 0x1672A)
    BP = Stack.Pop();
    // MOV AL,byte ptr [SI + 0x1] (1000_672B / 0x1672B)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // OR AL,AL (1000_672E / 0x1672E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:6726 (1000_6730 / 0x16730)
    if(!ZeroFlag) {
      goto label_1000_6726_16726;
    }
    label_1000_6732_16732:
    // ADD BP,0x6 (1000_6732 / 0x16732)
    // BP += 0x6;
    BP = Alu.Add16(BP, 0x6);
    // JMP 0x1000:6718 (1000_6735 / 0x16735)
    goto label_1000_6718_16718;
    label_1000_6737_16737:
    // MOV SI,0x88f (1000_6737 / 0x16737)
    SI = 0x88F;
    label_1000_673A_1673A:
    // ADD SI,0x1b (1000_673A / 0x1673A)
    SI += 0x1B;
    // CMP SI,0xfbb (1000_673D / 0x1673D)
    Alu.Sub16(SI, 0xFBB);
    // JNC 0x1000:6756 (1000_6741 / 0x16741)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6756 / 0x16756)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x10 (1000_6743 / 0x16743)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    // JNZ 0x1000:673a (1000_6747 / 0x16747)
    if(!ZeroFlag) {
      goto label_1000_673A_1673A;
    }
    // TEST byte ptr [SI + 0x3],0x40 (1000_6749 / 0x16749)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JZ 0x1000:673a (1000_674D / 0x1674D)
    if(ZeroFlag) {
      goto label_1000_673A_1673A;
    }
    // MOV AL,byte ptr [SI] (1000_674F / 0x1674F)
    AL = UInt8[DS, SI];
    // CALL 0x1000:6757 (1000_6751 / 0x16751)
    NearCall(cs1, 0x6754, spice86_generated_label_call_target_1000_6757_016757);
    // JMP 0x1000:673a (1000_6754 / 0x16754)
    goto label_1000_673A_1673A;
    label_1000_6756_16756:
    // RET  (1000_6756 / 0x16756)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6757_016757(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6757_16757:
    // CALL 0x1000:6906 (1000_6757 / 0x16757)
    NearCall(cs1, 0x675A, spice86_generated_label_call_target_1000_6906_016906);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_675A_01675A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_675A_01675A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_675A_1675A:
    // CALL 0x1000:686e (1000_675A / 0x1675A)
    NearCall(cs1, 0x675D, spice86_generated_label_call_target_1000_686E_01686E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_675D_01675D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_675D_01675D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_675D_1675D:
    // JC 0x1000:676d (1000_675D / 0x1675D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_676D / 0x1676D)
      return NearRet();
    }
    // CALL 0x1000:6770 (1000_675F / 0x1675F)
    NearCall(cs1, 0x6762, spice86_generated_label_call_target_1000_6770_016770);
    label_1000_6762_16762:
    // CMP BP,0x1 (1000_6762 / 0x16762)
    Alu.Sub16(BP, 0x1);
    // JC 0x1000:676d (1000_6765 / 0x16765)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_676D / 0x1676D)
      return NearRet();
    }
    // PUSH SI (1000_6767 / 0x16767)
    Stack.Push(SI);
    // CALL 0x1000:c5cf (1000_6768 / 0x16768)
    NearCall(cs1, 0x676B, spice86_generated_label_call_target_1000_C5CF_01C5CF);
    label_1000_676B_1676B:
    // POP SI (1000_676B / 0x1676B)
    SI = Stack.Pop();
    // CLC  (1000_676C / 0x1676C)
    CarryFlag = false;
    label_1000_676D_1676D:
    // RET  (1000_676D / 0x1676D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6770_016770(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6770_16770:
    // TEST byte ptr [SI + 0x10],0x10 (1000_6770 / 0x16770)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    // JNZ 0x1000:678f (1000_6774 / 0x16774)
    if(!ZeroFlag) {
      goto label_1000_678F_1678F;
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_6776 / 0x16776)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST byte ptr [SI + 0x10],0x80 (1000_6779 / 0x16779)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:6792 (1000_677D / 0x1677D)
    if(!ZeroFlag) {
      goto label_1000_6792_16792;
    }
    // OR AL,AL (1000_677F / 0x1677F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:6792 (1000_6781 / 0x16781)
    if(!SignFlag) {
      goto label_1000_6792_16792;
    }
    // MOV BP,word ptr [SI + 0x4] (1000_6783 / 0x16783)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [BP + 0xa],0x10 (1000_6786 / 0x16786)
    Alu.And8(UInt8[SS, (ushort)(BP + 0xA)], 0x10);
    // MOV BP,0x181f (1000_678A / 0x1678A)
    BP = 0x181F;
    // JNZ 0x1000:6791 (1000_678D / 0x1678D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    label_1000_678F_1678F:
    // XOR BP,BP (1000_678F / 0x1678F)
    BP = 0;
    label_1000_6791_16791:
    // RET  (1000_6791 / 0x16791)
    return NearRet();
    label_1000_6792_16792:
    // TEST AL,0x40 (1000_6792 / 0x16792)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:6799 (1000_6794 / 0x16794)
    if(ZeroFlag) {
      goto label_1000_6799_16799;
    }
    // JMP 0x1000:6827 (1000_6796 / 0x16796)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_6827_016827, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6799_16799:
    // TEST AL,0x30 (1000_6799 / 0x16799)
    Alu.And8(AL, 0x30);
    // JZ 0x1000:67c5 (1000_679B / 0x1679B)
    if(ZeroFlag) {
      goto label_1000_67C5_167C5;
    }
    // AND AX,0xf (1000_679D / 0x1679D)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV BP,AX (1000_67A0 / 0x167A0)
    BP = AX;
    // SHL BP,1 (1000_67A2 / 0x167A2)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x16b6] (1000_67A4 / 0x167A4)
    BP = UInt16[SS, (ushort)(BP + 0x16B6)];
    // OR AX,AX (1000_67A8 / 0x167A8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNZ 0x1000:67c4 (1000_67AA / 0x167AA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x19] (1000_67AC / 0x167AC)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // AND AL,0xc0 (1000_67AF / 0x167AF)
    // AL &= 0xC0;
    AL = Alu.And8(AL, 0xC0);
    // JZ 0x1000:67c4 (1000_67B1 / 0x167B1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV BP,0x1813 (1000_67B3 / 0x167B3)
    BP = 0x1813;
    // CMP AL,0x80 (1000_67B6 / 0x167B6)
    Alu.Sub8(AL, 0x80);
    // JZ 0x1000:67c4 (1000_67B8 / 0x167B8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV BP,0x1817 (1000_67BA / 0x167BA)
    BP = 0x1817;
    // CMP AL,0x40 (1000_67BD / 0x167BD)
    Alu.Sub8(AL, 0x40);
    // JZ 0x1000:67c4 (1000_67BF / 0x167BF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV BP,0x181b (1000_67C1 / 0x167C1)
    BP = 0x181B;
    label_1000_67C4_167C4:
    // RET  (1000_67C4 / 0x167C4)
    return NearRet();
    label_1000_67C5_167C5:
    // AND AX,0xf (1000_67C5 / 0x167C5)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // JZ 0x1000:680a (1000_67C8 / 0x167C8)
    if(ZeroFlag) {
      goto label_1000_680A_1680A;
    }
    label_1000_67CA_167CA:
    // MOV BP,AX (1000_67CA / 0x167CA)
    BP = AX;
    // SHL BP,1 (1000_67CC / 0x167CC)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x179c] (1000_67CE / 0x167CE)
    BP = UInt16[SS, (ushort)(BP + 0x179C)];
    // CMP BP,0x1774 (1000_67D2 / 0x167D2)
    Alu.Sub16(BP, 0x1774);
    // JZ 0x1000:67ed (1000_67D6 / 0x167D6)
    if(ZeroFlag) {
      goto label_1000_67ED_167ED;
    }
    // CMP BP,0x1732 (1000_67D8 / 0x167D8)
    Alu.Sub16(BP, 0x1732);
    // JNZ 0x1000:6791 (1000_67DC / 0x167DC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    // MOV BP,word ptr [SI + 0x4] (1000_67DE / 0x167DE)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [BP + 0xa],0x2 (1000_67E1 / 0x167E1)
    Alu.And8(UInt8[SS, (ushort)(BP + 0xA)], 0x2);
    // MOV BP,0x16aa (1000_67E5 / 0x167E5)
    BP = 0x16AA;
    // JNZ 0x1000:6791 (1000_67E8 / 0x167E8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    // MOV BP,0x1732 (1000_67EA / 0x167EA)
    BP = 0x1732;
    label_1000_67ED_167ED:
    // MOV AL,byte ptr [SI + 0x2] (1000_67ED / 0x167ED)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    // DEC AL (1000_67F0 / 0x167F0)
    AL--;
    // AND AL,0x7 (1000_67F2 / 0x167F2)
    AL &= 0x7;
    // CMP AL,0x3 (1000_67F4 / 0x167F4)
    Alu.Sub8(AL, 0x3);
    // JC 0x1000:6809 (1000_67F6 / 0x167F6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    // ADD BP,0xa (1000_67F8 / 0x167F8)
    BP += 0xA;
    // CMP AL,0x3 (1000_67FB / 0x167FB)
    Alu.Sub8(AL, 0x3);
    // JZ 0x1000:6809 (1000_67FD / 0x167FD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    // ADD BP,0xa (1000_67FF / 0x167FF)
    BP += 0xA;
    // CMP AL,0x4 (1000_6802 / 0x16802)
    Alu.Sub8(AL, 0x4);
    // JZ 0x1000:6809 (1000_6804 / 0x16804)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    // ADD BP,0xa (1000_6806 / 0x16806)
    // BP += 0xA;
    BP = Alu.Add16(BP, 0xA);
    label_1000_6809_16809:
    // RET  (1000_6809 / 0x16809)
    return NearRet();
    label_1000_680A_1680A:
    // TEST byte ptr [SI + 0x19],0xc0 (1000_680A / 0x1680A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0xC0);
    // JZ 0x1000:67ca (1000_680E / 0x1680E)
    if(ZeroFlag) {
      goto label_1000_67CA_167CA;
    }
    // MOV AL,byte ptr [SI + 0x19] (1000_6810 / 0x16810)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // AND AL,0xc0 (1000_6813 / 0x16813)
    // AL &= 0xC0;
    AL = Alu.And8(AL, 0xC0);
    // MOV BP,0x17bc (1000_6815 / 0x16815)
    BP = 0x17BC;
    // CMP AL,0x80 (1000_6818 / 0x16818)
    Alu.Sub8(AL, 0x80);
    // JZ 0x1000:6826 (1000_681A / 0x1681A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6826 / 0x16826)
      return NearRet();
    }
    // MOV BP,0x17c9 (1000_681C / 0x1681C)
    BP = 0x17C9;
    // CMP AL,0x40 (1000_681F / 0x1681F)
    Alu.Sub8(AL, 0x40);
    // JZ 0x1000:6826 (1000_6821 / 0x16821)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6826 / 0x16826)
      return NearRet();
    }
    // MOV BP,0x1806 (1000_6823 / 0x16823)
    BP = 0x1806;
    label_1000_6826_16826:
    // RET  (1000_6826 / 0x16826)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6827_016827(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6827_16827:
    // PUSH BX (1000_6827 / 0x16827)
    Stack.Push(BX);
    // PUSH DX (1000_6828 / 0x16828)
    Stack.Push(DX);
    // PUSH DI (1000_6829 / 0x16829)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_682A / 0x1682A)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [DI + 0x2] (1000_682D / 0x1682D)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_6830 / 0x16830)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // SUB AX,word ptr [SI + 0x6] (1000_6833 / 0x16833)
    // AX -= UInt16[DS, (ushort)(SI + 0x6)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    // MOV AL,AH (1000_6836 / 0x16836)
    AL = AH;
    // CBW  (1000_6838 / 0x16838)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_6839 / 0x16839)
    DX = AX;
    // MOV DI,DX (1000_683B / 0x1683B)
    DI = DX;
    // JNS 0x1000:6841 (1000_683D / 0x1683D)
    if(!SignFlag) {
      goto label_1000_6841_16841;
    }
    // NEG DI (1000_683F / 0x1683F)
    DI = Alu.Sub16(0, DI);
    label_1000_6841_16841:
    // SUB BX,word ptr [SI + 0x8] (1000_6841 / 0x16841)
    // BX -= UInt16[DS, (ushort)(SI + 0x8)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x8)]);
    // MOV CX,BX (1000_6844 / 0x16844)
    CX = BX;
    // JNS 0x1000:684a (1000_6846 / 0x16846)
    if(!SignFlag) {
      goto label_1000_684A_1684A;
    }
    // NEG CX (1000_6848 / 0x16848)
    CX = Alu.Sub16(0, CX);
    label_1000_684A_1684A:
    // MOV BP,0x2 (1000_684A / 0x1684A)
    BP = 0x2;
    // CMP DI,CX (1000_684D / 0x1684D)
    Alu.Sub16(DI, CX);
    // JC 0x1000:6854 (1000_684F / 0x1684F)
    if(CarryFlag) {
      goto label_1000_6854_16854;
    }
    // DEC BP (1000_6851 / 0x16851)
    BP = Alu.Dec16(BP);
    // XCHG BX,DX (1000_6852 / 0x16852)
    ushort tmp_1000_6852 = BX;
    BX = DX;
    DX = tmp_1000_6852;
    label_1000_6854_16854:
    // OR BX,BX (1000_6854 / 0x16854)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNS 0x1000:685b (1000_6856 / 0x16856)
    if(!SignFlag) {
      goto label_1000_685B_1685B;
    }
    // XOR BP,0x2 (1000_6858 / 0x16858)
    // BP ^= 0x2;
    BP = Alu.Xor16(BP, 0x2);
    label_1000_685B_1685B:
    // CALL 0x1000:693b (1000_685B / 0x1685B)
    NearCall(cs1, 0x685E, spice86_generated_label_call_target_1000_693B_01693B);
    // SHL AX,1 (1000_685E / 0x1685E)
    AX <<= 0x1;
    // SHL AX,1 (1000_6860 / 0x16860)
    AX <<= 0x1;
    // ADD BP,AX (1000_6862 / 0x16862)
    BP += AX;
    // SHL BP,1 (1000_6864 / 0x16864)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x18bf] (1000_6866 / 0x16866)
    BP = UInt16[SS, (ushort)(BP + 0x18BF)];
    // POP DI (1000_686A / 0x1686A)
    DI = Stack.Pop();
    // POP DX (1000_686B / 0x1686B)
    DX = Stack.Pop();
    // POP BX (1000_686C / 0x1686C)
    BX = Stack.Pop();
    // RET  (1000_686D / 0x1686D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_686E_01686E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_686E_1686E:
    // CMP byte ptr [0x46eb],0x80 (1000_686E / 0x1686E)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x80);
    // JC 0x1000:68ae (1000_6873 / 0x16873)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_68AE / 0x168AE)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x3],0x40 (1000_6875 / 0x16875)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:68af (1000_6879 / 0x16879)
    if(!ZeroFlag) {
      goto label_1000_68AF_168AF;
    }
    // MOV BL,byte ptr [SI + 0x2] (1000_687B / 0x1687B)
    BL = UInt8[DS, (ushort)(SI + 0x2)];
    // DEC BX (1000_687E / 0x1687E)
    BX = Alu.Dec16(BX);
    // PUSH DI (1000_687F / 0x1687F)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_6880 / 0x16880)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [DI + 0xa],0x2 (1000_6883 / 0x16883)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JZ 0x1000:688c (1000_6887 / 0x16887)
    if(ZeroFlag) {
      goto label_1000_688C_1688C;
    }
    // XOR BL,0x8 (1000_6889 / 0x16889)
    // BL ^= 0x8;
    BL = Alu.Xor8(BL, 0x8);
    label_1000_688C_1688C:
    // POP DI (1000_688C / 0x1688C)
    DI = Stack.Pop();
    // AND BX,0xf (1000_688D / 0x1688D)
    BX &= 0xF;
    // ADD BX,BX (1000_6890 / 0x16890)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    // MOV AL,byte ptr [BX + 0x1672] (1000_6892 / 0x16892)
    AL = UInt8[DS, (ushort)(BX + 0x1672)];
    // CBW  (1000_6896 / 0x16896)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_6897 / 0x16897)
    DX = AX;
    // MOV AL,byte ptr [BX + 0x1673] (1000_6899 / 0x16899)
    AL = UInt8[DS, (ushort)(BX + 0x1673)];
    // CBW  (1000_689D / 0x1689D)
    AX = (ushort)((short)((sbyte)AL));
    // ADD DX,word ptr [BP + 0x2] (1000_689E / 0x1689E)
    // DX += UInt16[SS, (ushort)(BP + 0x2)];
    DX = Alu.Add16(DX, UInt16[SS, (ushort)(BP + 0x2)]);
    // MOV BX,word ptr [BP + 0x4] (1000_68A1 / 0x168A1)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    // CMP BH,0x80 (1000_68A4 / 0x168A4)
    Alu.Sub8(BH, 0x80);
    // JC 0x1000:68ae (1000_68A7 / 0x168A7)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_68AE / 0x168AE)
      return NearRet();
    }
    // XOR BH,BH (1000_68A9 / 0x168A9)
    BH = 0;
    // ADD BX,AX (1000_68AB / 0x168AB)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // CLC  (1000_68AD / 0x168AD)
    CarryFlag = false;
    label_1000_68AE_168AE:
    // RET  (1000_68AE / 0x168AE)
    return NearRet();
    label_1000_68AF_168AF:
    // MOV DX,word ptr [SI + 0x6] (1000_68AF / 0x168AF)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV BX,word ptr [SI + 0x8] (1000_68B2 / 0x168B2)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    // CALL 0x1000:b647 (1000_68B5 / 0x168B5)
    NearCall(cs1, 0x68B8, spice86_generated_label_call_target_1000_B647_01B647);
    // CMP DX,-0x10 (1000_68B8 / 0x168B8)
    Alu.Sub16(DX, 0xFFF0);
    // JLE 0x1000:68d0 (1000_68BB / 0x168BB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CMP BX,-0x10 (1000_68BD / 0x168BD)
    Alu.Sub16(BX, 0xFFF0);
    // JLE 0x1000:68d0 (1000_68C0 / 0x168C0)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CMP DX,0x148 (1000_68C2 / 0x168C2)
    Alu.Sub16(DX, 0x148);
    // JGE 0x1000:68d0 (1000_68C6 / 0x168C6)
    if(SignFlag == OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CMP BX,0xa0 (1000_68C8 / 0x168C8)
    Alu.Sub16(BX, 0xA0);
    // JGE 0x1000:68d0 (1000_68CC / 0x168CC)
    if(SignFlag == OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CLC  (1000_68CE / 0x168CE)
    CarryFlag = false;
    // RET  (1000_68CF / 0x168CF)
    return NearRet();
    label_1000_68D0_168D0:
    // STC  (1000_68D0 / 0x168D0)
    CarryFlag = true;
    // RET  (1000_68D1 / 0x168D1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_68EB_0168EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_68EB_168EB:
    // MOV AL,[0x1954] (1000_68EB / 0x168EB)
    AL = UInt8[DS, 0x1954];
    // CMP byte ptr [0x46eb],0x80 (1000_68EE / 0x168EE)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x80);
    // JNC 0x1000:6906 (1000_68F3 / 0x168F3)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6906_016906, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,[0x476c] (1000_68F5 / 0x168F5)
    AL = UInt8[DS, 0x476C];
    // XOR AH,AH (1000_68F8 / 0x168F8)
    AH = 0;
    // ADD AX,AX (1000_68FA / 0x168FA)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // MOV SI,AX (1000_68FC / 0x168FC)
    SI = AX;
    // MOV SI,word ptr [SI + 0x4758] (1000_68FE / 0x168FE)
    SI = UInt16[DS, (ushort)(SI + 0x4758)];
    // MOV AL,byte ptr [SI] (1000_6902 / 0x16902)
    AL = UInt8[DS, SI];
    // JMP 0x1000:6912 (1000_6904 / 0x16904)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6912_016912, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6906_016906(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6906_16906:
    // MOV SI,AX (1000_6906 / 0x16906)
    SI = AX;
    // DEC AL (1000_6908 / 0x16908)
    AL = Alu.Dec8(AL);
    // MOV AH,0x1b (1000_690A / 0x1690A)
    AH = 0x1B;
    // MUL AH (1000_690C / 0x1690C)
    Cpu.Mul8(AH);
    // ADD AX,0x8aa (1000_690E / 0x1690E)
    // AX += 0x8AA;
    AX = Alu.Add16(AX, 0x8AA);
    // XCHG AX,SI (1000_6911 / 0x16911)
    ushort tmp_1000_6911 = AX;
    AX = SI;
    SI = tmp_1000_6911;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6912_016912, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6912_016912(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6912_16912:
    // CMP byte ptr [SI + 0x3],0x80 (1000_6912 / 0x16912)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // RET  (1000_6916 / 0x16916)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6917_016917(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6917_16917:
    // CMP byte ptr [0x46eb],0x0 (1000_6917 / 0x16917)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // MOV DI,0x3caf (1000_691C / 0x1691C)
    DI = 0x3CAF;
    // JNS 0x1000:6938 (1000_691F / 0x1691F)
    if(!SignFlag) {
      goto label_1000_6938_16938;
    }
    // MOV CX,word ptr [0x3cbe] (1000_6921 / 0x16921)
    CX = UInt16[DS, 0x3CBE];
    label_1000_6925_16925:
    // JCXZ 0x1000:6938 (1000_6925 / 0x16925)
    if(CX == 0) {
      goto label_1000_6938_16938;
    }
    label_1000_6927_16927:
    // ADD DI,0x11 (1000_6927 / 0x16927)
    DI += 0x11;
    // CMP word ptr [DI + 0xa],SI (1000_692A / 0x1692A)
    Alu.Sub16(UInt16[DS, (ushort)(DI + 0xA)], SI);
    // LOOPNZ 0x1000:6927 (1000_692D / 0x1692D)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_6927_16927;
    }
    // JNZ 0x1000:6937 (1000_692F / 0x1692F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6937 / 0x16937)
      return NearRet();
    }
    // TEST byte ptr [DI + 0xc],0x40 (1000_6931 / 0x16931)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x40);
    // JNZ 0x1000:6925 (1000_6935 / 0x16935)
    if(!ZeroFlag) {
      goto label_1000_6925_16925;
    }
    label_1000_6937_16937:
    // RET  (1000_6937 / 0x16937)
    return NearRet();
    label_1000_6938_16938:
    // OR DI,DI (1000_6938 / 0x16938)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // RET  (1000_693A / 0x1693A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_693B_01693B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_693B_1693B:
    // MOV AL,byte ptr [SI + 0x3] (1000_693B / 0x1693B)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AX,0xf (1000_693E / 0x1693E)
    AX &= 0xF;
    // SHR AX,1 (1000_6941 / 0x16941)
    AX >>= 0x1;
    // SHR AX,1 (1000_6943 / 0x16943)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_6945 / 0x16945)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6946_016946(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6946_16946:
    // MOV SI,0x3cbe (1000_6946 / 0x16946)
    SI = 0x3CBE;
    // LODSW SI (1000_6949 / 0x16949)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_694A / 0x1694A)
    CX = AX;
    // JCXZ 0x1000:6972 (1000_694C / 0x1694C)
    if(CX == 0) {
      goto label_1000_6972_16972;
    }
    // MOV AL,0x11 (1000_694E / 0x1694E)
    AL = 0x11;
    // MUL CL (1000_6950 / 0x16950)
    Cpu.Mul8(CL);
    // ADD SI,AX (1000_6952 / 0x16952)
    SI += AX;
    label_1000_6954_16954:
    // SUB SI,0x11 (1000_6954 / 0x16954)
    SI -= 0x11;
    // CMP word ptr [SI],DX (1000_6957 / 0x16957)
    Alu.Sub16(UInt16[DS, SI], DX);
    // JGE 0x1000:6970 (1000_6959 / 0x16959)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6970_16970;
    }
    // CMP word ptr [SI + 0x2],BX (1000_695B / 0x1695B)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], BX);
    // JGE 0x1000:6970 (1000_695E / 0x1695E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6970_16970;
    }
    // CMP DX,word ptr [SI + 0x4] (1000_6960 / 0x16960)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JGE 0x1000:6970 (1000_6963 / 0x16963)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6970_16970;
    }
    // TEST byte ptr [SI + 0xc],0x40 (1000_6965 / 0x16965)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xC)], 0x40);
    // JNZ 0x1000:6970 (1000_6969 / 0x16969)
    if(!ZeroFlag) {
      goto label_1000_6970_16970;
    }
    // CMP BX,word ptr [SI + 0x6] (1000_696B / 0x1696B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JL 0x1000:6974 (1000_696E / 0x1696E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_6974_16974;
    }
    label_1000_6970_16970:
    // LOOP 0x1000:6954 (1000_6970 / 0x16970)
    if(--CX != 0) {
      goto label_1000_6954_16954;
    }
    label_1000_6972_16972:
    // CLC  (1000_6972 / 0x16972)
    CarryFlag = false;
    // RET  (1000_6973 / 0x16973)
    return NearRet();
    label_1000_6974_16974:
    // MOV DI,word ptr [SI + 0xa] (1000_6974 / 0x16974)
    DI = UInt16[DS, (ushort)(SI + 0xA)];
    // CMP byte ptr [DI + 0x3],0x80 (1000_6977 / 0x16977)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x3)], 0x80);
    // RET  (1000_697B / 0x1697B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_697C_01697C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_697C_1697C:
    // CALL 0x1000:6917 (1000_697C / 0x1697C)
    NearCall(cs1, 0x697F, spice86_generated_label_call_target_1000_6917_016917);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_697F_01697F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_697F_01697F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_697F_1697F:
    // JNZ 0x1000:69a2 (1000_697F / 0x1697F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_69A2 / 0x169A2)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x3],0x40 (1000_6981 / 0x16981)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:698f (1000_6985 / 0x16985)
    if(!ZeroFlag) {
      goto label_1000_698F_1698F;
    }
    // MOV DI,word ptr [SI + 0x4] (1000_6987 / 0x16987)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:5ed0 (1000_698A / 0x1698A)
    NearCall(cs1, 0x698D, spice86_generated_label_call_target_1000_5ED0_015ED0);
    label_1000_698D_1698D:
    // JNZ 0x1000:69a2 (1000_698D / 0x1698D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_69A2 / 0x169A2)
      return NearRet();
    }
    label_1000_698F_1698F:
    // CALL 0x1000:686e (1000_698F / 0x1698F)
    NearCall(cs1, 0x6992, spice86_generated_label_call_target_1000_686E_01686E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6992_016992, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6992_016992(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6992_16992:
    // JC 0x1000:69a2 (1000_6992 / 0x16992)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_69A2 / 0x169A2)
      return NearRet();
    }
    // MOV BP,0x18fd (1000_6994 / 0x16994)
    BP = 0x18FD;
    // CALL 0x1000:c5cf (1000_6997 / 0x16997)
    NearCall(cs1, 0x699A, spice86_generated_label_call_target_1000_C5CF_01C5CF);
    label_1000_699A_1699A:
    // OR byte ptr [DI + 0xc],0x40 (1000_699A / 0x1699A)
    // UInt8[DS, (ushort)(DI + 0xC)] |= 0x40;
    UInt8[DS, (ushort)(DI + 0xC)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xC)], 0x40);
    // MOV word ptr [0x4752],DI (1000_699E / 0x1699E)
    UInt16[DS, 0x4752] = DI;
    label_1000_69A2_169A2:
    // RET  (1000_69A2 / 0x169A2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_69A3_0169A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_69A3_169A3:
    // PUSH DI (1000_69A3 / 0x169A3)
    Stack.Push(DI);
    // XOR DI,DI (1000_69A4 / 0x169A4)
    DI = 0;
    // XCHG word ptr [0x4752],DI (1000_69A6 / 0x169A6)
    ushort tmp_1000_69A6 = UInt16[DS, 0x4752];
    UInt16[DS, 0x4752] = DI;
    DI = tmp_1000_69A6;
    // OR DI,DI (1000_69AA / 0x169AA)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:69b1 (1000_69AC / 0x169AC)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_69B1_0169B1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c58a (1000_69AE / 0x169AE)
    NearCall(cs1, 0x69B1, spice86_generated_label_call_target_1000_C58A_01C58A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_69B1_0169B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_69B1_0169B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_69B1_169B1:
    // POP DI (1000_69B1 / 0x169B1)
    DI = Stack.Pop();
    // RET  (1000_69B2 / 0x169B2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_69B3_0169B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_69B3_169B3:
    // CALL 0x1000:68eb (1000_69B3 / 0x169B3)
    NearCall(cs1, 0x69B6, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_69B6_0169B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
