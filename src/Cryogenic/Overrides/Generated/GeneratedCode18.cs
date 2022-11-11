namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_CE7E_01CE7E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE7E_1CE7E:
    // CALL 0x1000:c921 (1000_CE7E / 0x1CE7E)
    NearCall(cs1, 0xCE81, spice86_generated_label_call_target_1000_C921_01C921);
    State.IncCycles();
    label_1000_CE81_1CE81:
    // AND byte ptr [BX],0xfb (1000_CE81 / 0x1CE81)
    UInt8[DS, BX] &= 0xFB;
    State.IncCycles();
    // INC AX (1000_CE84 / 0x1CE84)
    AX++;
    State.IncCycles();
    // CMP AX,0x9 (1000_CE85 / 0x1CE85)
    Alu.Sub16(AX, 0x9);
    State.IncCycles();
    // JC 0x1000:ce7e (1000_CE88 / 0x1CE88)
    if(CarryFlag) {
      goto label_1000_CE7E_1CE7E;
    }
    State.IncCycles();
    label_1000_CE8A_1CE8A:
    // TEST byte ptr [0x2943],0x3 (1000_CE8A / 0x1CE8A)
    Alu.And8(UInt8[DS, 0x2943], 0x3);
    State.IncCycles();
    // JZ 0x1000:ce9f (1000_CE8F / 0x1CE8F)
    if(ZeroFlag) {
      goto label_1000_CE9F_1CE9F;
    }
    State.IncCycles();
    // XOR AX,AX (1000_CE91 / 0x1CE91)
    AX = 0;
    State.IncCycles();
    label_1000_CE93_1CE93:
    // CALL 0x1000:c921 (1000_CE93 / 0x1CE93)
    NearCall(cs1, 0xCE96, spice86_generated_label_call_target_1000_C921_01C921);
    State.IncCycles();
    // AND byte ptr [BX],0x7f (1000_CE96 / 0x1CE96)
    UInt8[DS, BX] &= 0x7F;
    State.IncCycles();
    // INC AX (1000_CE99 / 0x1CE99)
    AX++;
    State.IncCycles();
    // CMP AX,0x25 (1000_CE9A / 0x1CE9A)
    Alu.Sub16(AX, 0x25);
    State.IncCycles();
    // JC 0x1000:ce93 (1000_CE9D / 0x1CE9D)
    if(CarryFlag) {
      goto label_1000_CE93_1CE93;
    }
    State.IncCycles();
    label_1000_CE9F_1CE9F:
    // MOV AX,0x2 (1000_CE9F / 0x1CE9F)
    AX = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CEA2_01CEA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CEA2_01CEA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEA2_1CEA2:
    // PUSH AX (1000_CEA2 / 0x1CEA2)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:ceb0 (1000_CEA3 / 0x1CEA3)
    NearCall(cs1, 0xCEA6, spice86_generated_label_call_target_1000_CEB0_01CEB0);
    State.IncCycles();
    label_1000_CEA6_1CEA6:
    // POP AX (1000_CEA6 / 0x1CEA6)
    AX = Stack.Pop();
    State.IncCycles();
    // INC AX (1000_CEA7 / 0x1CEA7)
    AX++;
    State.IncCycles();
    // CMP AX,0x8 (1000_CEA8 / 0x1CEA8)
    Alu.Sub16(AX, 0x8);
    State.IncCycles();
    // JC 0x1000:cea2 (1000_CEAB / 0x1CEAB)
    if(CarryFlag) {
      goto label_1000_CEA2_1CEA2;
    }
    State.IncCycles();
    // JMP 0x1000:ca01 (1000_CEAD / 0x1CEAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CEB0_01CEB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEB0_1CEB0:
    // CALL 0x1000:c921 (1000_CEB0 / 0x1CEB0)
    NearCall(cs1, 0xCEB3, spice86_generated_label_call_target_1000_C921_01C921);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEB3_01CEB3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEB3_01CEB3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEB3_1CEB3:
    // PUSH BX (1000_CEB3 / 0x1CEB3)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:c92b (1000_CEB4 / 0x1CEB4)
    NearCall(cs1, 0xCEB7, spice86_generated_label_call_target_1000_C92B_01C92B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEB7_01CEB7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEB7_01CEB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEB7_1CEB7:
    // POP DI (1000_CEB7 / 0x1CEB7)
    DI = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:cec8 (1000_CEB8 / 0x1CEB8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CEC8 / 0x1CEC8)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [DI],0x8 (1000_CEBA / 0x1CEBA)
    Alu.And8(UInt8[DS, DI], 0x8);
    State.IncCycles();
    // JZ 0x1000:cec8 (1000_CEBD / 0x1CEBD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CEC8 / 0x1CEC8)
      return NearRet();
    }
    State.IncCycles();
    // SUB DI,0x8 (1000_CEBF / 0x1CEBF)
    // DI -= 0x8;
    DI = Alu.Sub16(DI, 0x8);
    State.IncCycles();
    // MOV SI,0xdbf6 (1000_CEC2 / 0x1CEC2)
    SI = 0xDBF6;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_CEC5 / 0x1CEC5)
    NearCall(cs1, 0xCEC8, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    label_1000_CEC8_1CEC8:
    // RET  (1000_CEC8 / 0x1CEC8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CEC9_01CEC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEC9_1CEC9:
    // PUSHF  (1000_CEC9 / 0x1CEC9)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // PUSH BX (1000_CECA / 0x1CECA)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_CECB / 0x1CECB)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_CECC / 0x1CECC)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_CECD / 0x1CECD)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_CECE / 0x1CECE)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_CECF / 0x1CECF)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (1000_CED0 / 0x1CED0)
    Stack.Push(ES);
    State.IncCycles();
    // XOR AX,AX (1000_CED1 / 0x1CED1)
    AX = 0;
    State.IncCycles();
    // XCHG byte ptr [0xdbb5],AL (1000_CED3 / 0x1CED3)
    byte tmp_1000_CED3 = UInt8[DS, 0xDBB5];
    UInt8[DS, 0xDBB5] = AL;
    AL = tmp_1000_CED3;
    State.IncCycles();
    // STI  (1000_CED7 / 0x1CED7)
    InterruptFlag = true;
    State.IncCycles();
    // PUSH AX (1000_CED8 / 0x1CED8)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:caa0 (1000_CED9 / 0x1CED9)
    NearCall(cs1, 0xCEDC, spice86_generated_label_call_target_1000_CAA0_01CAA0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEDC_01CEDC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEDC_01CEDC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEDC_1CEDC:
    // JBE 0x1000:ceef (1000_CEDC / 0x1CEDC)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEE7_01CEE7, 0x1CEEF - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xdc1e] (1000_CEDE / 0x1CEDE)
    AX = UInt16[DS, 0xDC1E];
    State.IncCycles();
    // INC AX (1000_CEE1 / 0x1CEE1)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JNZ 0x1000:ceef (1000_CEE2 / 0x1CEE2)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEE7_01CEE7, 0x1CEEF - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:cad4 (1000_CEE4 / 0x1CEE4)
    NearCall(cs1, 0xCEE7, spice86_generated_label_call_target_1000_CAD4_01CAD4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEE7_01CEE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEE7_01CEE7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCEEF: goto label_1000_CEEF_1CEEF;break; // Target of external jump from 0x1CEDC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_CEE7_1CEE7:
    // JC 0x1000:ceef (1000_CEE7 / 0x1CEE7)
    if(CarryFlag) {
      goto label_1000_CEEF_1CEEF;
    }
    State.IncCycles();
    // CALL 0x1000:cc96 (1000_CEE9 / 0x1CEE9)
    NearCall(cs1, 0xCEEC, spice86_generated_label_call_target_1000_CC96_01CC96);
    State.IncCycles();
    label_1000_CEEC_1CEEC:
    // CALL 0x1000:cc4e (1000_CEEC / 0x1CEEC)
    NearCall(cs1, 0xCEEF, spice86_generated_label_call_target_1000_CC4E_01CC4E);
    State.IncCycles();
    label_1000_CEEF_1CEEF:
    // POP AX (1000_CEEF / 0x1CEEF)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0xdbb5],AL (1000_CEF0 / 0x1CEF0)
    UInt8[DS, 0xDBB5] = AL;
    State.IncCycles();
    // POP ES (1000_CEF3 / 0x1CEF3)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_CEF4 / 0x1CEF4)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_CEF5 / 0x1CEF5)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_CEF6 / 0x1CEF6)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_CEF7 / 0x1CEF7)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_CEF8 / 0x1CEF8)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_CEF9 / 0x1CEF9)
    BX = Stack.Pop();
    State.IncCycles();
    // POPF  (1000_CEFA / 0x1CEFA)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CEFB / 0x1CEFB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CEFC_01CEFC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CEFC_1CEFC:
    // MOV AX,0x69 (1000_CEFC / 0x1CEFC)
    AX = 0x69;
    State.IncCycles();
    // ADD AL,byte ptr [0xceeb] (1000_CEFF / 0x1CEFF)
    // AL += UInt8[DS, 0xCEEB];
    AL = Alu.Add8(AL, UInt8[DS, 0xCEEB]);
    State.IncCycles();
    // CALL 0x1000:c13e (1000_CF03 / 0x1CF03)
    NearCall(cs1, 0xCF06, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF06_01CF06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF06_01CF06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF06_1CF06:
    // MOV word ptr [0x3622],0x35a8 (1000_CF06 / 0x1CF06)
    UInt16[DS, 0x3622] = 0x35A8;
    State.IncCycles();
    // XOR AX,AX (1000_CF0C / 0x1CF0C)
    AX = 0;
    State.IncCycles();
    // CALLF [0x3939] (1000_CF0E / 0x1CF0E)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_CF0E = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_CF0E) {
      case 0x23613 : FarCall(cs1, 0xCF12, spice86_generated_label_call_target_334B_0163_033613); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CF0E));
        break;
    }
    State.IncCycles();
    label_1000_CF12_1CF12:
    // CALL 0x1000:c0ad (1000_CF12 / 0x1CF12)
    NearCall(cs1, 0xCF15, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF15_01CF15, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF15_01CF15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF15_1CF15:
    // MOV AX,0x19 (1000_CF15 / 0x1CF15)
    AX = 0x19;
    State.IncCycles();
    // JMP 0x1000:ca1b (1000_CF18 / 0x1CF18)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CF1B_01CF1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF1B_1CF1B:
    // PUSH word ptr [0xdbda] (1000_CF1B / 0x1CF1B)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_CF1F / 0x1CF1F)
    NearCall(cs1, 0xCF22, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF22_01CF22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF22_01CF22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF22_1CF22:
    // MOV SI,word ptr [0x3622] (1000_CF22 / 0x1CF22)
    SI = UInt16[DS, 0x3622];
    State.IncCycles();
    // LODSW SI (1000_CF26 / 0x1CF26)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [0xdbe8] (1000_CF27 / 0x1CF27)
    Alu.Sub16(AX, UInt16[DS, 0xDBE8]);
    State.IncCycles();
    // JA 0x1000:cf30 (1000_CF2B / 0x1CF2B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_CF30_1CF30;
    }
    State.IncCycles();
    // CALL 0x1000:cf4b (1000_CF2D / 0x1CF2D)
    NearCall(cs1, 0xCF30, spice86_generated_label_call_target_1000_CF4B_01CF4B);
    State.IncCycles();
    label_1000_CF30_1CF30:
    // CALL 0x1000:c9e8 (1000_CF30 / 0x1CF30)
    NearCall(cs1, 0xCF33, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    State.IncCycles();
    label_1000_CF33_1CF33:
    // JC 0x1000:cf3b (1000_CF33 / 0x1CF33)
    if(CarryFlag) {
      goto label_1000_CF3B_1CF3B;
    }
    State.IncCycles();
    // CALL 0x1000:cc85 (1000_CF35 / 0x1CF35)
    NearCall(cs1, 0xCF38, spice86_generated_label_call_target_1000_CC85_01CC85);
    State.IncCycles();
    label_1000_CF38_1CF38:
    // JZ 0x1000:cf22 (1000_CF38 / 0x1CF38)
    if(ZeroFlag) {
      goto label_1000_CF22_1CF22;
    }
    State.IncCycles();
    // CLC  (1000_CF3A / 0x1CF3A)
    CarryFlag = false;
    State.IncCycles();
    label_1000_CF3B_1CF3B:
    // PUSHF  (1000_CF3B / 0x1CF3B)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CALL 0x1000:ca01 (1000_CF3C / 0x1CF3C)
    NearCall(cs1, 0xCF3F, spice86_generated_label_call_target_1000_CA01_01CA01);
    State.IncCycles();
    label_1000_CF3F_1CF3F:
    // CALL 0x1000:ac14 (1000_CF3F / 0x1CF3F)
    NearCall(cs1, 0xCF42, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    label_1000_CF42_1CF42:
    // CALL 0x1000:ad57 (1000_CF42 / 0x1CF42)
    NearCall(cs1, 0xCF45, spice86_generated_label_call_target_1000_AD57_01AD57);
    State.IncCycles();
    label_1000_CF45_1CF45:
    // POPF  (1000_CF45 / 0x1CF45)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_CF46 / 0x1CF46)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CF4A / 0x1CF4A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CF4B_01CF4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF4B_1CF4B:
    // MOV AX,SI (1000_CF4B / 0x1CF4B)
    AX = SI;
    State.IncCycles();
    // MOV [0x3622],AX (1000_CF4D / 0x1CF4D)
    UInt16[DS, 0x3622] = AX;
    State.IncCycles();
    // SUB AX,0x35a8 (1000_CF50 / 0x1CF50)
    AX -= 0x35A8;
    State.IncCycles();
    // SHR AX,1 (1000_CF53 / 0x1CF53)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_CF55 / 0x1CF55)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // JNC 0x1000:cf61 (1000_CF57 / 0x1CF57)
    if(!CarryFlag) {
      goto label_1000_CF61_1CF61;
    }
    State.IncCycles();
    // MOV BX,0xbe (1000_CF59 / 0x1CF59)
    BX = 0xBE;
    State.IncCycles();
    // XOR DX,DX (1000_CF5C / 0x1CF5C)
    DX = 0;
    State.IncCycles();
    // JMP 0x1000:c22f (1000_CF5E / 0x1CF5E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_CF61_1CF61:
    // MOV DI,0xed80 (1000_CF61 / 0x1CF61)
    DI = 0xED80;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd8] (1000_CF64 / 0x1CF64)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // XOR AX,AX (1000_CF68 / 0x1CF68)
    AX = 0;
    State.IncCycles();
    // MOV CX,0xb40 (1000_CF6A / 0x1CF6A)
    CX = 0xB40;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_CF6D / 0x1CF6D)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // RET  (1000_CF6F / 0x1CF6F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CF70_01CF70(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF70_1CF70:
    // PUSH BX (1000_CF70 / 0x1CF70)
    Stack.Push(BX);
    State.IncCycles();
    // DEC SI (1000_CF71 / 0x1CF71)
    SI--;
    State.IncCycles();
    // TEST SI,0x800 (1000_CF72 / 0x1CF72)
    Alu.And16(SI, 0x800);
    State.IncCycles();
    // JZ 0x1000:cf95 (1000_CF76 / 0x1CF76)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CF95_01CF95, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:d00f (1000_CF78 / 0x1CF78)
    NearCall(cs1, 0xCF7B, spice86_generated_label_call_target_1000_D00F_01D00F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF7B_01CF7B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF7B_01CF7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF7B_1CF7B:
    // LES BX,[0x47b0] (1000_CF7B / 0x1CF7B)
    ES = UInt16[DS, 0x47B2];
    BX = UInt16[DS, 0x47B0];
    State.IncCycles();
    // AND SI,0x7ff (1000_CF7F / 0x1CF7F)
    SI &= 0x7FF;
    State.IncCycles();
    // SHL SI,1 (1000_CF83 / 0x1CF83)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr ES:[BX + SI] (1000_CF85 / 0x1CF85)
    SI = UInt16[ES, (ushort)(BX + SI)];
    State.IncCycles();
    // MOV BX,word ptr ES:[BX] (1000_CF88 / 0x1CF88)
    BX = UInt16[ES, BX];
    State.IncCycles();
    // MOV BX,word ptr ES:[BX + -0x2] (1000_CF8B / 0x1CF8B)
    BX = UInt16[ES, (ushort)(BX - 0x2)];
    State.IncCycles();
    // MOV word ptr [0x47b4],BX (1000_CF8F / 0x1CF8F)
    UInt16[DS, 0x47B4] = BX;
    State.IncCycles();
    // POP BX (1000_CF93 / 0x1CF93)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CF94 / 0x1CF94)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CF95_01CF95(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CF95_1CF95:
    // SHL SI,1 (1000_CF95 / 0x1CF95)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // LES BX,[0x47ac] (1000_CF97 / 0x1CF97)
    ES = UInt16[DS, 0x47AE];
    BX = UInt16[DS, 0x47AC];
    State.IncCycles();
    // MOV SI,word ptr ES:[BX + SI] (1000_CF9B / 0x1CF9B)
    SI = UInt16[ES, (ushort)(BX + SI)];
    State.IncCycles();
    // POP BX (1000_CF9E / 0x1CF9E)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CF9F / 0x1CF9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CFA0_01CFA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CFA0_1CFA0:
    // CALL 0x1000:ae2f (1000_CFA0 / 0x1CFA0)
    NearCall(cs1, 0xCFA3, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CFA3_01CFA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CFA3_01CFA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CFA3_1CFA3:
    // JZ 0x1000:cfb8 (1000_CFA3 / 0x1CFA3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CFB8 / 0x1CFB8)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,[0xceeb] (1000_CFA5 / 0x1CFA5)
    AL = UInt8[DS, 0xCEEB];
    State.IncCycles();
    // OR AL,AL (1000_CFA8 / 0x1CFA8)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:cfb0 (1000_CFAA / 0x1CFAA)
    if(ZeroFlag) {
      goto label_1000_CFB0_1CFB0;
    }
    State.IncCycles();
    // CMP AL,0x3 (1000_CFAC / 0x1CFAC)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:cfb8 (1000_CFAE / 0x1CFAE)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CFB8 / 0x1CFB8)
      return NearRet();
    }
    State.IncCycles();
    label_1000_CFB0_1CFB0:
    // MOV AL,0x2 (1000_CFB0 / 0x1CFB0)
    AL = 0x2;
    State.IncCycles();
    // MOV [0x28e7],AL (1000_CFB2 / 0x1CFB2)
    UInt8[DS, 0x28E7] = AL;
    State.IncCycles();
    // MOV [0x28e8],AL (1000_CFB5 / 0x1CFB5)
    UInt8[DS, 0x28E8] = AL;
    State.IncCycles();
    label_1000_CFB8_1CFB8:
    // RET  (1000_CFB8 / 0x1CFB8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CFB9_01CFB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CFB9_1CFB9:
    // XOR BX,BX (1000_CFB9 / 0x1CFB9)
    BX = 0;
    State.IncCycles();
    // MOV DI,0xd7f4 (1000_CFBB / 0x1CFBB)
    DI = 0xD7F4;
    State.IncCycles();
    // PUSH DS (1000_CFBE / 0x1CFBE)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_CFBF / 0x1CFBF)
    ES = Stack.Pop();
    State.IncCycles();
    label_1000_CFC0_1CFC0:
    // MOV SI,word ptr [BX + 0xaa76] (1000_CFC0 / 0x1CFC0)
    SI = UInt16[DS, (ushort)(BX + 0xAA76)];
    State.IncCycles();
    // CMP word ptr [SI],-0x1 (1000_CFC4 / 0x1CFC4)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:cfce (1000_CFC7 / 0x1CFC7)
    if(!ZeroFlag) {
      goto label_1000_CFCE_1CFCE;
    }
    State.IncCycles();
    // ADD BX,0x2 (1000_CFC9 / 0x1CFC9)
    // BX += 0x2;
    BX = Alu.Add16(BX, 0x2);
    State.IncCycles();
    // JMP 0x1000:cfc0 (1000_CFCC / 0x1CFCC)
    goto label_1000_CFC0_1CFC0;
    State.IncCycles();
    label_1000_CFCE_1CFCE:
    // MOV AX,word ptr [SI + 0x2] (1000_CFCE / 0x1CFCE)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // XCHG AH,AL (1000_CFD1 / 0x1CFD1)
    byte tmp_1000_CFD1 = AH;
    AH = AL;
    AL = tmp_1000_CFD1;
    State.IncCycles();
    // AND AX,0x3ff (1000_CFD3 / 0x1CFD3)
    AX &= 0x3FF;
    State.IncCycles();
    // DEC AX (1000_CFD6 / 0x1CFD6)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // STOSW ES:DI (1000_CFD7 / 0x1CFD7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // AND BX,0xfff0 (1000_CFD8 / 0x1CFD8)
    BX &= 0xFFF0;
    State.IncCycles();
    // ADD BX,0x10 (1000_CFDB / 0x1CFDB)
    BX += 0x10;
    State.IncCycles();
    // CMP BX,0x110 (1000_CFDE / 0x1CFDE)
    Alu.Sub16(BX, 0x110);
    State.IncCycles();
    // JC 0x1000:cfc0 (1000_CFE2 / 0x1CFE2)
    if(CarryFlag) {
      goto label_1000_CFC0_1CFC0;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CFE4_01CFE4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CFE4_01CFE4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CFE4_1CFE4:
    // MOV AL,[0xceeb] (1000_CFE4 / 0x1CFE4)
    AL = UInt8[DS, 0xCEEB];
    State.IncCycles();
    // MOV SI,0xbb (1000_CFE7 / 0x1CFE7)
    SI = 0xBB;
    State.IncCycles();
    // CMP AL,0x6 (1000_CFEA / 0x1CFEA)
    Alu.Sub8(AL, 0x6);
    State.IncCycles();
    // JNZ 0x1000:cff1 (1000_CFEC / 0x1CFEC)
    if(!ZeroFlag) {
      goto label_1000_CFF1_1CFF1;
    }
    State.IncCycles();
    // MOV SI,0xc7 (1000_CFEE / 0x1CFEE)
    SI = 0xC7;
    State.IncCycles();
    label_1000_CFF1_1CFF1:
    // MOV DI,0xceec (1000_CFF1 / 0x1CFF1)
    DI = 0xCEEC;
    State.IncCycles();
    // PUSH DS (1000_CFF4 / 0x1CFF4)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_CFF5 / 0x1CFF5)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_CFF6 / 0x1CFF6)
    NearCall(cs1, 0xCFF9, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CFF9_01CFF9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CFF9_01CFF9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CFF9_1CFF9:
    // MOV AL,0xc0 (1000_CFF9 / 0x1CFF9)
    AL = 0xC0;
    State.IncCycles();
    // ADD AL,byte ptr [0xceeb] (1000_CFFB / 0x1CFFB)
    AL += UInt8[DS, 0xCEEB];
    State.IncCycles();
    // XOR AH,AH (1000_CFFF / 0x1CFFF)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_D001 / 0x1D001)
    SI = AX;
    State.IncCycles();
    // LES DI,[0x47ac] (1000_D003 / 0x1D003)
    ES = UInt16[DS, 0x47AE];
    DI = UInt16[DS, 0x47AC];
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_D007 / 0x1D007)
    NearCall(cs1, 0xD00A, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    State.IncCycles();
    label_1000_D00A_1D00A:
    // CALL 0x1000:0098 (1000_D00A / 0x1D00A)
    NearCall(cs1, 0xD00D, spice86_generated_label_call_target_1000_0098_010098);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D00D_01D00D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D00D_01D00D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D00D_1D00D:
    // JMP 0x1000:d01a (1000_D00D / 0x1D00D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D00F_01D00F, 0x1D01A - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D00F_01D00F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD01A: goto label_1000_D01A_1D01A;break; // Target of external jump from 0x1D00D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D00F_1D00F:
    // MOV AX,[0x477c] (1000_D00F / 0x1D00F)
    AX = UInt16[DS, 0x477C];
    State.IncCycles();
    // CMP AX,word ptr [0xaad6] (1000_D012 / 0x1D012)
    Alu.Sub16(AX, UInt16[DS, 0xAAD6]);
    State.IncCycles();
    // MOV AL,0x93 (1000_D016 / 0x1D016)
    AL = 0x93;
    State.IncCycles();
    // JC 0x1000:d01c (1000_D018 / 0x1D018)
    if(CarryFlag) {
      goto label_1000_D01C_1D01C;
    }
    State.IncCycles();
    label_1000_D01A_1D01A:
    // MOV AL,0x9a (1000_D01A / 0x1D01A)
    AL = 0x9A;
    State.IncCycles();
    label_1000_D01C_1D01C:
    // ADD AL,byte ptr [0xceeb] (1000_D01C / 0x1D01C)
    AL += UInt8[DS, 0xCEEB];
    State.IncCycles();
    // CMP AL,byte ptr [0x477e] (1000_D020 / 0x1D020)
    Alu.Sub8(AL, UInt8[DS, 0x477E]);
    State.IncCycles();
    // JZ 0x1000:d03b (1000_D024 / 0x1D024)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D03B / 0x1D03B)
      return NearRet();
    }
    State.IncCycles();
    // PUSH SI (1000_D026 / 0x1D026)
    Stack.Push(SI);
    State.IncCycles();
    // MOV [0x477e],AL (1000_D027 / 0x1D027)
    UInt8[DS, 0x477E] = AL;
    State.IncCycles();
    // XOR AH,AH (1000_D02A / 0x1D02A)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_D02C / 0x1D02C)
    SI = AX;
    State.IncCycles();
    // LES DI,[0x47b0] (1000_D02E / 0x1D02E)
    ES = UInt16[DS, 0x47B2];
    DI = UInt16[DS, 0x47B0];
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_D032 / 0x1D032)
    NearCall(cs1, 0xD035, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    State.IncCycles();
    label_1000_D035_1D035:
    // PUSH CX (1000_D035 / 0x1D035)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:0098 (1000_D036 / 0x1D036)
    NearCall(cs1, 0xD039, spice86_generated_label_call_target_1000_0098_010098);
    State.IncCycles();
    label_1000_D039_1D039:
    // POP CX (1000_D039 / 0x1D039)
    CX = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_D03A / 0x1D03A)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_D03B_1D03B:
    // RET  (1000_D03B / 0x1D03B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D03C_01D03C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D03C_1D03C:
    // LODSB ES:SI (1000_D03C / 0x1D03C)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SUB AL,0x30 (1000_D03E / 0x1D03E)
    AL -= 0x30;
    State.IncCycles();
    // CMP AL,0x9 (1000_D040 / 0x1D040)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JA 0x1000:d03c (1000_D042 / 0x1D042)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_D03C_1D03C;
    }
    State.IncCycles();
    label_1000_D044_1D044:
    // LODSB ES:SI (1000_D044 / 0x1D044)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SUB AL,0x30 (1000_D046 / 0x1D046)
    AL -= 0x30;
    State.IncCycles();
    // CMP AL,0x9 (1000_D048 / 0x1D048)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JBE 0x1000:d044 (1000_D04A / 0x1D04A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D044_1D044;
    }
    State.IncCycles();
    // DEC SI (1000_D04C / 0x1D04C)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // RET  (1000_D04D / 0x1D04D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D04E_01D04E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D04E_1D04E:
    // MOV word ptr [0xd82c],DX (1000_D04E / 0x1D04E)
    UInt16[DS, 0xD82C] = DX;
    State.IncCycles();
    // MOV word ptr [0xd82e],BX (1000_D052 / 0x1D052)
    UInt16[DS, 0xD82E] = BX;
    State.IncCycles();
    // MOV word ptr [0xd830],DX (1000_D056 / 0x1D056)
    UInt16[DS, 0xD830] = DX;
    State.IncCycles();
    // MOV word ptr [0xd832],BX (1000_D05A / 0x1D05A)
    UInt16[DS, 0xD832] = BX;
    State.IncCycles();
    // RET  (1000_D05E / 0x1D05E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D05F_01D05F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D05F_1D05F:
    // MOV DX,word ptr [0xd82c] (1000_D05F / 0x1D05F)
    DX = UInt16[DS, 0xD82C];
    State.IncCycles();
    // MOV BX,word ptr [0xd82e] (1000_D063 / 0x1D063)
    BX = UInt16[DS, 0xD82E];
    State.IncCycles();
    // RET  (1000_D067 / 0x1D067)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D068_01D068(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D068_1D068:
    // MOV word ptr [0x2518],0xd096 (1000_D068 / 0x1D068)
    UInt16[DS, 0x2518] = 0xD096;
    State.IncCycles();
    // MOV word ptr [0x47a0],0xceec (1000_D06E / 0x1D06E)
    UInt16[DS, 0x47A0] = 0xCEEC;
    State.IncCycles();
    // RET  (1000_D074 / 0x1D074)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D075_01D075(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D075_1D075:
    // MOV word ptr [0x2518],0xd12f (1000_D075 / 0x1D075)
    UInt16[DS, 0x2518] = 0xD12F;
    State.IncCycles();
    // MOV word ptr [0x47a0],0xcf6c (1000_D07B / 0x1D07B)
    UInt16[DS, 0x47A0] = 0xCF6C;
    State.IncCycles();
    // RET  (1000_D081 / 0x1D081)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D082_01D082(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D082_1D082:
    // MOV word ptr [0x2518],0xd0ff (1000_D082 / 0x1D082)
    UInt16[DS, 0x2518] = 0xD0FF;
    State.IncCycles();
    // MOV word ptr [0x47a0],0xceec (1000_D088 / 0x1D088)
    UInt16[DS, 0x47A0] = 0xCEEC;
    State.IncCycles();
    // RET  (1000_D08E / 0x1D08E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D096_01D096(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D096_1D096:
    // PUSH AX (1000_D096 / 0x1D096)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_D097 / 0x1D097)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_D098 / 0x1D098)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_D099 / 0x1D099)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_D09A / 0x1D09A)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_D09B / 0x1D09B)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_D09C / 0x1D09C)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (1000_D09D / 0x1D09D)
    Stack.Push(ES);
    State.IncCycles();
    // XOR AH,AH (1000_D09E / 0x1D09E)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_D0A0 / 0x1D0A0)
    SI = AX;
    State.IncCycles();
    // SHL SI,1 (1000_D0A2 / 0x1D0A2)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_D0A4 / 0x1D0A4)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_D0A6 / 0x1D0A6)
    SI <<= 0x1;
    State.IncCycles();
    // ADD SI,AX (1000_D0A8 / 0x1D0A8)
    SI += AX;
    State.IncCycles();
    // ADD SI,word ptr [0x2514] (1000_D0AA / 0x1D0AA)
    // SI += UInt16[DS, 0x2514];
    SI = Alu.Add16(SI, UInt16[DS, 0x2514]);
    State.IncCycles();
    // MOV BX,0xceec (1000_D0AE / 0x1D0AE)
    BX = 0xCEEC;
    State.IncCycles();
    // XLAT BX (1000_D0B1 / 0x1D0B1)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // CALL 0x1000:d05f (1000_D0B2 / 0x1D0B2)
    NearCall(cs1, 0xD0B5, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D0B5_01D0B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D0B5_01D0B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D0B5_1D0B5:
    // ADD word ptr [0xd82c],AX (1000_D0B5 / 0x1D0B5)
    // UInt16[DS, 0xD82C] += AX;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], AX);
    State.IncCycles();
    // MOV CL,AL (1000_D0B9 / 0x1D0B9)
    CL = AL;
    State.IncCycles();
    // MOV CH,0x9 (1000_D0BB / 0x1D0BB)
    CH = 0x9;
    State.IncCycles();
    // MOV AX,[0xdbe4] (1000_D0BD / 0x1D0BD)
    AX = UInt16[DS, 0xDBE4];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_D0C0 / 0x1D0C0)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x38d1] (1000_D0C4 / 0x1D0C4)
    // Indirect call to [0x38d1], generating possible targets from emulator records
    uint targetAddress_1000_D0C4 = (uint)(UInt16[DS, 0x38D3] * 0x10 + UInt16[DS, 0x38D1] - cs1 * 0x10);
    switch(targetAddress_1000_D0C4) {
      case 0x235C5 : FarCall(cs1, 0xD0C8, spice86_generated_label_call_target_334B_0115_0335C5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D0C4));
        break;
    }
    State.IncCycles();
    label_1000_D0C8_1D0C8:
    // POP ES (1000_D0C8 / 0x1D0C8)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_D0C9 / 0x1D0C9)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_D0CA / 0x1D0CA)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_D0CB / 0x1D0CB)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_D0CC / 0x1D0CC)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_D0CD / 0x1D0CD)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_D0CE / 0x1D0CE)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_D0CF / 0x1D0CF)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D0D0 / 0x1D0D0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D0E3_01D0E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D0E3_1D0E3:
    // PUSH CX (1000_D0E3 / 0x1D0E3)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_D0E4 / 0x1D0E4)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_D0E5 / 0x1D0E5)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH CS (1000_D0E6 / 0x1D0E6)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_D0E7 / 0x1D0E7)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0xd0d1 (1000_D0E8 / 0x1D0E8)
    DI = 0xD0D1;
    State.IncCycles();
    // MOV CX,0x9 (1000_D0EB / 0x1D0EB)
    CX = 0x9;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_D0EE / 0x1D0EE)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // POP ES (1000_D0F0 / 0x1D0F0)
    ES = Stack.Pop();
    State.IncCycles();
    // STC  (1000_D0F1 / 0x1D0F1)
    CarryFlag = true;
    State.IncCycles();
    // JNZ 0x1000:d0fc (1000_D0F2 / 0x1D0F2)
    if(!ZeroFlag) {
      goto label_1000_D0FC_1D0FC;
    }
    State.IncCycles();
    // MOV AL,byte ptr CS:[DI + 0x8] (1000_D0F4 / 0x1D0F4)
    AL = UInt8[cs1, (ushort)(DI + 0x8)];
    State.IncCycles();
    // MOV AH,0xd (1000_D0F8 / 0x1D0F8)
    AH = 0xD;
    State.IncCycles();
    // SUB AH,CL (1000_D0FA / 0x1D0FA)
    // AH -= CL;
    AH = Alu.Sub8(AH, CL);
    State.IncCycles();
    label_1000_D0FC_1D0FC:
    // POP DI (1000_D0FC / 0x1D0FC)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_D0FD / 0x1D0FD)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D0FE / 0x1D0FE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D0FF_01D0FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D0FF_1D0FF:
    // CALL 0x1000:d068 (1000_D0FF / 0x1D0FF)
    NearCall(cs1, 0xD102, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D102_01D102, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D102_01D102(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D102_1D102:
    // CALL 0x1000:d0e3 (1000_D102 / 0x1D102)
    NearCall(cs1, 0xD105, spice86_generated_label_call_target_1000_D0E3_01D0E3);
    State.IncCycles();
    label_1000_D105_1D105:
    // JC 0x1000:d096 (1000_D105 / 0x1D105)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D096_01D096, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_D107 / 0x1D107)
    NearCall(cs1, 0xD10A, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_D10A_1D10A:
    // PUSH ES (1000_D10A / 0x1D10A)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH AX (1000_D10B / 0x1D10B)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,0x32 (1000_D10C / 0x1D10C)
    AX = 0x32;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_D10F / 0x1D10F)
    NearCall(cs1, 0xD112, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_D112_1D112:
    // CALL 0x1000:d05f (1000_D112 / 0x1D112)
    NearCall(cs1, 0xD115, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D115_01D115, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D115_01D115(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D115_1D115:
    // POP AX (1000_D115 / 0x1D115)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV CL,AH (1000_D116 / 0x1D116)
    CL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_D118 / 0x1D118)
    AH = 0;
    State.IncCycles();
    // ADD word ptr [0xd82c],AX (1000_D11A / 0x1D11A)
    // UInt16[DS, 0xD82C] += AX;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], AX);
    State.IncCycles();
    // MOV AL,CL (1000_D11E / 0x1D11E)
    AL = CL;
    State.IncCycles();
    // SUB BX,0x13 (1000_D120 / 0x1D120)
    // BX -= 0x13;
    BX = Alu.Sub16(BX, 0x13);
    State.IncCycles();
    // JNC 0x1000:d127 (1000_D123 / 0x1D123)
    if(!CarryFlag) {
      goto label_1000_D127_1D127;
    }
    State.IncCycles();
    // XOR BX,BX (1000_D125 / 0x1D125)
    BX = 0;
    State.IncCycles();
    label_1000_D127_1D127:
    // CALL 0x1000:c22f (1000_D127 / 0x1D127)
    NearCall(cs1, 0xD12A, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_D12A_1D12A:
    // POP ES (1000_D12A / 0x1D12A)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_D12B / 0x1D12B)
    NearCall(cs1, 0xD12E, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_D12E_1D12E:
    // RET  (1000_D12E / 0x1D12E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D12F_01D12F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D12F_1D12F:
    // PUSH AX (1000_D12F / 0x1D12F)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_D130 / 0x1D130)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_D131 / 0x1D131)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_D132 / 0x1D132)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_D133 / 0x1D133)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_D134 / 0x1D134)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_D135 / 0x1D135)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (1000_D136 / 0x1D136)
    Stack.Push(ES);
    State.IncCycles();
    // XOR AH,AH (1000_D137 / 0x1D137)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_D139 / 0x1D139)
    SI = AX;
    State.IncCycles();
    // SHL SI,1 (1000_D13B / 0x1D13B)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_D13D / 0x1D13D)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_D13F / 0x1D13F)
    SI <<= 0x1;
    State.IncCycles();
    // SUB SI,AX (1000_D141 / 0x1D141)
    SI -= AX;
    State.IncCycles();
    // ADD SI,word ptr [0x2516] (1000_D143 / 0x1D143)
    // SI += UInt16[DS, 0x2516];
    SI = Alu.Add16(SI, UInt16[DS, 0x2516]);
    State.IncCycles();
    // MOV BX,0xcf6c (1000_D147 / 0x1D147)
    BX = 0xCF6C;
    State.IncCycles();
    // XLAT BX (1000_D14A / 0x1D14A)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // CALL 0x1000:d05f (1000_D14B / 0x1D14B)
    NearCall(cs1, 0xD14E, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D14E_01D14E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D14E_01D14E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D14E_1D14E:
    // ADD word ptr [0xd82c],AX (1000_D14E / 0x1D14E)
    // UInt16[DS, 0xD82C] += AX;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], AX);
    State.IncCycles();
    // MOV CL,AL (1000_D152 / 0x1D152)
    CL = AL;
    State.IncCycles();
    // MOV CH,0x7 (1000_D154 / 0x1D154)
    CH = 0x7;
    State.IncCycles();
    // MOV AX,[0xdbe4] (1000_D156 / 0x1D156)
    AX = UInt16[DS, 0xDBE4];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_D159 / 0x1D159)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x38d1] (1000_D15D / 0x1D15D)
    // Indirect call to [0x38d1], generating possible targets from emulator records
    uint targetAddress_1000_D15D = (uint)(UInt16[DS, 0x38D3] * 0x10 + UInt16[DS, 0x38D1] - cs1 * 0x10);
    switch(targetAddress_1000_D15D) {
      case 0x235C5 : FarCall(cs1, 0xD161, spice86_generated_label_call_target_334B_0115_0335C5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D15D));
        break;
    }
    State.IncCycles();
    label_1000_D161_1D161:
    // POP ES (1000_D161 / 0x1D161)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_D162 / 0x1D162)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_D163 / 0x1D163)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_D164 / 0x1D164)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_D165 / 0x1D165)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_D166 / 0x1D166)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_D167 / 0x1D167)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_D168 / 0x1D168)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D169 / 0x1D169)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D194_01D194(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D194_1D194:
    // MOV word ptr [0xdbe4],CX (1000_D194 / 0x1D194)
    UInt16[DS, 0xDBE4] = CX;
    State.IncCycles();
    // CALL 0x1000:d04e (1000_D198 / 0x1D198)
    NearCall(cs1, 0xD19B, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D19B_01D19B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D19B_01D19B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD1A5: goto label_1000_D1A5_1D1A5;break; // Target of external jump from 0x1D1AA, 0x1D1BF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D19B_1D19B:
    // PUSH SI (1000_D19B / 0x1D19B)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,AX (1000_D19C / 0x1D19C)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_D19E / 0x1D19E)
    NearCall(cs1, 0xD1A1, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_D1A1_1D1A1:
    // CALL 0x1000:d1bb (1000_D1A1 / 0x1D1A1)
    NearCall(cs1, 0xD1A4, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    State.IncCycles();
    label_1000_D1A4_1D1A4:
    // POP SI (1000_D1A4 / 0x1D1A4)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_D1A5_1D1A5:
    // RET  (1000_D1A5 / 0x1D1A5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1A6_01D1A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1A6_1D1A6:
    // LODSW SI (1000_D1A6 / 0x1D1A6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_D1A7 / 0x1D1A7)
    CX = AX;
    State.IncCycles();
    // INC AX (1000_D1A9 / 0x1D1A9)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JZ 0x1000:d1a5 (1000_D1AA / 0x1D1AA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D1A5 / 0x1D1A5)
      return NearRet();
    }
    State.IncCycles();
    // LODSW SI (1000_D1AC / 0x1D1AC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_D1AD / 0x1D1AD)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_D1AF / 0x1D1AF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_D1B0 / 0x1D1B0)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_D1B2 / 0x1D1B2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AX,CX (1000_D1B3 / 0x1D1B3)
    ushort tmp_1000_D1B3 = AX;
    AX = CX;
    CX = tmp_1000_D1B3;
    State.IncCycles();
    // PUSH SI (1000_D1B4 / 0x1D1B4)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:d194 (1000_D1B5 / 0x1D1B5)
    NearCall(cs1, 0xD1B8, spice86_generated_label_call_target_1000_D194_01D194);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D1B8_01D1B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D1B8_01D1B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1B8_1D1B8:
    // POP SI (1000_D1B8 / 0x1D1B8)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:d1a6 (1000_D1B9 / 0x1D1B9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1A6_01D1A6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1BB_01D1BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1BB_1D1BB:
    // LODSB ES:SI (1000_D1BB / 0x1D1BB)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0xff (1000_D1BD / 0x1D1BD)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:d1a5 (1000_D1BF / 0x1D1BF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D1A5 / 0x1D1A5)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0xd (1000_D1C1 / 0x1D1C1)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JZ 0x1000:d1d1 (1000_D1C3 / 0x1D1C3)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D1D1_01D1D1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR AL,AL (1000_D1C5 / 0x1D1C5)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:d1cb (1000_D1C7 / 0x1D1C7)
    if(!SignFlag) {
      goto label_1000_D1CB_1D1CB;
    }
    State.IncCycles();
    // MOV AL,0x40 (1000_D1C9 / 0x1D1C9)
    AL = 0x40;
    State.IncCycles();
    label_1000_D1CB_1D1CB:
    // CALL word ptr [0x2518] (1000_D1CB / 0x1D1CB)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_D1CB = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_D1CB) {
      case 0xD12F : NearCall(cs1, 0xD1CF, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      case 0xD096 : NearCall(cs1, 0xD1CF, spice86_generated_label_call_target_1000_D096_01D096); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D1CB));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D1CF_01D1CF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D1CF_01D1CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1CF_1D1CF:
    // JMP 0x1000:d1bb (1000_D1CF / 0x1D1CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1BB_01D1BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D1D1_01D1D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1D1_1D1D1:
    // MOV AX,[0xd830] (1000_D1D1 / 0x1D1D1)
    AX = UInt16[DS, 0xD830];
    State.IncCycles();
    // MOV [0xd82c],AX (1000_D1D4 / 0x1D1D4)
    UInt16[DS, 0xD82C] = AX;
    State.IncCycles();
    // MOV AX,0xa (1000_D1D7 / 0x1D1D7)
    AX = 0xA;
    State.IncCycles();
    // CMP word ptr [0x2518],0xd12f (1000_D1DA / 0x1D1DA)
    Alu.Sub16(UInt16[DS, 0x2518], 0xD12F);
    State.IncCycles();
    // JNZ 0x1000:d1e5 (1000_D1E0 / 0x1D1E0)
    if(!ZeroFlag) {
      goto label_1000_D1E5_1D1E5;
    }
    State.IncCycles();
    // MOV AX,0x7 (1000_D1E2 / 0x1D1E2)
    AX = 0x7;
    State.IncCycles();
    label_1000_D1E5_1D1E5:
    // ADD word ptr [0xd832],AX (1000_D1E5 / 0x1D1E5)
    UInt16[DS, 0xD832] += AX;
    State.IncCycles();
    // ADD word ptr [0xd82e],AX (1000_D1E9 / 0x1D1E9)
    // UInt16[DS, 0xD82E] += AX;
    UInt16[DS, 0xD82E] = Alu.Add16(UInt16[DS, 0xD82E], AX);
    State.IncCycles();
    // JMP 0x1000:d1bb (1000_D1ED / 0x1D1ED)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1BB_01D1BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1EF_01D1EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1EF_1D1EF:
    // LODSW SI (1000_D1EF / 0x1D1EF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_D1F0 / 0x1D1F0)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1F2_01D1F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1F2_01D1F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1F2_1D1F2:
    // CALL 0x1000:c137 (1000_D1F2 / 0x1D1F2)
    NearCall(cs1, 0xD1F5, spice86_generated_label_call_target_1000_C137_01C137);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D1F5_01D1F5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D1F5_01D1F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D1F5_1D1F5:
    // PUSH CX (1000_D1F5 / 0x1D1F5)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:d200 (1000_D1F6 / 0x1D1F6)
    NearCall(cs1, 0xD1F9, spice86_generated_label_call_target_1000_D200_01D200);
    State.IncCycles();
    label_1000_D1F9_1D1F9:
    // POP CX (1000_D1F9 / 0x1D1F9)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD SI,0xe (1000_D1FA / 0x1D1FA)
    // SI += 0xE;
    SI = Alu.Add16(SI, 0xE);
    State.IncCycles();
    // LOOP 0x1000:d1f5 (1000_D1FD / 0x1D1FD)
    if(--CX != 0) {
      goto label_1000_D1F5_1D1F5;
    }
    State.IncCycles();
    // RET  (1000_D1FF / 0x1D1FF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D200_01D200(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D200_1D200:
    // PUSH word ptr [0xdbda] (1000_D200 / 0x1D200)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_D204 / 0x1D204)
    NearCall(cs1, 0xD207, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D207_01D207, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D207_01D207(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D207_1D207:
    // PUSH SI (1000_D207 / 0x1D207)
    Stack.Push(SI);
    State.IncCycles();
    // TEST byte ptr [SI + 0x8],0x40 (1000_D208 / 0x1D208)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x8)], 0x40);
    State.IncCycles();
    // JZ 0x1000:d218 (1000_D20C / 0x1D20C)
    if(ZeroFlag) {
      goto label_1000_D218_1D218;
    }
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_D20E / 0x1D20E)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // PUSH SI (1000_D212 / 0x1D212)
    Stack.Push(SI);
    State.IncCycles();
    // CALLF [0x38d9] (1000_D213 / 0x1D213)
    // Indirect call to [0x38d9], generating possible targets from emulator records
    uint targetAddress_1000_D213 = (uint)(UInt16[DS, 0x38DB] * 0x10 + UInt16[DS, 0x38D9] - cs1 * 0x10);
    switch(targetAddress_1000_D213) {
      case 0x235CB : FarCall(cs1, 0xD217, spice86_generated_label_call_target_334B_011B_0335CB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D213));
        break;
    }
    State.IncCycles();
    label_1000_D217_1D217:
    // POP SI (1000_D217 / 0x1D217)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_D218_1D218:
    // TEST byte ptr [SI + 0x8],0x20 (1000_D218 / 0x1D218)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x8)], 0x20);
    State.IncCycles();
    // JNZ 0x1000:d233 (1000_D21C / 0x1D21C)
    if(!ZeroFlag) {
      goto label_1000_D233_1D233;
    }
    State.IncCycles();
    // LODSW SI (1000_D21E / 0x1D21E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_D21F / 0x1D21F)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_D221 / 0x1D221)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_D222 / 0x1D222)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_D224 / 0x1D224)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_D225 / 0x1D225)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_D227 / 0x1D227)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_D228 / 0x1D228)
    CX = AX;
    State.IncCycles();
    // LODSW SI (1000_D22A / 0x1D22A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_D22B / 0x1D22B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // INC AX (1000_D22C / 0x1D22C)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JZ 0x1000:d233 (1000_D22D / 0x1D22D)
    if(ZeroFlag) {
      goto label_1000_D233_1D233;
    }
    State.IncCycles();
    // DEC AX (1000_D22F / 0x1D22F)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // CALL 0x1000:c22f (1000_D230 / 0x1D230)
    NearCall(cs1, 0xD233, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_D233_1D233:
    // POP SI (1000_D233 / 0x1D233)
    SI = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_D234 / 0x1D234)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D238 / 0x1D238)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D239_01D239(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D239_1D239:
    // MOV CH,0x2 (1000_D239 / 0x1D239)
    CH = 0x2;
    State.IncCycles();
    // JMP 0x1000:d23f (1000_D23B / 0x1D23B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D23D_01D23D, 0x1D23F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D23D_01D23D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD23F: goto label_1000_D23F_1D23F;break; // Target of external jump from 0x1D23B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D23D_1D23D:
    // XOR CX,CX (1000_D23D / 0x1D23D)
    CX = 0;
    State.IncCycles();
    label_1000_D23F_1D23F:
    // MOV SI,0x1af4 (1000_D23F / 0x1D23F)
    SI = 0x1AF4;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0xa] (1000_D242 / 0x1D242)
    AX = UInt16[DS, (ushort)(SI + 0xA)];
    State.IncCycles();
    // SUB AX,0x0 (1000_D245 / 0x1D245)
    // AX -= 0x0;
    AX = Alu.Sub16(AX, 0x0);
    State.IncCycles();
    // MOV CL,0x3 (1000_D248 / 0x1D248)
    CL = 0x3;
    State.IncCycles();
    // DIV CL (1000_D24A / 0x1D24A)
    Cpu.Div8(CL);
    State.IncCycles();
    // CMP CH,AH (1000_D24C / 0x1D24C)
    Alu.Sub8(CH, AH);
    State.IncCycles();
    // JZ 0x1000:d27f (1000_D24E / 0x1D24E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D27F / 0x1D27F)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x1 (1000_D250 / 0x1D250)
    AX = 0x1;
    State.IncCycles();
    // JNC 0x1000:d257 (1000_D253 / 0x1D253)
    if(!CarryFlag) {
      goto label_1000_D257_1D257;
    }
    State.IncCycles();
    // NEG AX (1000_D255 / 0x1D255)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_D257_1D257:
    // PUSH AX (1000_D257 / 0x1D257)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_D258 / 0x1D258)
    Stack.Push(SI);
    State.IncCycles();
    // ADD word ptr [SI + 0xa],AX (1000_D259 / 0x1D259)
    UInt16[DS, (ushort)(SI + 0xA)] += AX;
    State.IncCycles();
    // ADD word ptr [SI + 0x18],AX (1000_D25C / 0x1D25C)
    // UInt16[DS, (ushort)(SI + 0x18)] += AX;
    UInt16[DS, (ushort)(SI + 0x18)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x18)], AX);
    State.IncCycles();
    // MOV CX,0x2 (1000_D25F / 0x1D25F)
    CX = 0x2;
    State.IncCycles();
    // CALL 0x1000:d1f2 (1000_D262 / 0x1D262)
    NearCall(cs1, 0xD265, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D265_01D265, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D265_01D265(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D265_1D265:
    // CALL 0x1000:1a34 (1000_D265 / 0x1D265)
    NearCall(cs1, 0xD268, spice86_generated_label_call_target_1000_1A34_011A34);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D268_01D268, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D268_01D268(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D268_1D268:
    // MOV AX,0xa (1000_D268 / 0x1D268)
    AX = 0xA;
    State.IncCycles();
    // CALL 0x1000:e387 (1000_D26B / 0x1D26B)
    NearCall(cs1, 0xD26E, spice86_generated_label_call_target_1000_E387_01E387);
    State.IncCycles();
    label_1000_D26E_1D26E:
    // POP SI (1000_D26E / 0x1D26E)
    SI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_D26F / 0x1D26F)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD word ptr [SI + 0xa],AX (1000_D270 / 0x1D270)
    UInt16[DS, (ushort)(SI + 0xA)] += AX;
    State.IncCycles();
    // ADD word ptr [SI + 0x18],AX (1000_D273 / 0x1D273)
    // UInt16[DS, (ushort)(SI + 0x18)] += AX;
    UInt16[DS, (ushort)(SI + 0x18)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x18)], AX);
    State.IncCycles();
    // MOV CX,0x2 (1000_D276 / 0x1D276)
    CX = 0x2;
    State.IncCycles();
    // CALL 0x1000:d1f2 (1000_D279 / 0x1D279)
    NearCall(cs1, 0xD27C, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    State.IncCycles();
    label_1000_D27C_1D27C:
    // CALL 0x1000:1a34 (1000_D27C / 0x1D27C)
    NearCall(cs1, 0xD27F, spice86_generated_label_call_target_1000_1A34_011A34);
    State.IncCycles();
    label_1000_D27F_1D27F:
    // RET  (1000_D27F / 0x1D27F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D280_01D280(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D280_1D280:
    // CMP byte ptr [0xdce6],0x0 (1000_D280 / 0x1D280)
    Alu.Sub8(UInt8[DS, 0xDCE6], 0x0);
    State.IncCycles();
    // JLE 0x1000:d2bc (1000_D285 / 0x1D285)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D2BC / 0x1D2BC)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_D287 / 0x1D287)
    NearCall(cs1, 0xD28A, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D28A_01D28A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D28A_01D28A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D28A_1D28A:
    // MOV byte ptr [0xdce6],0x0 (1000_D28A / 0x1D28A)
    UInt8[DS, 0xDCE6] = 0x0;
    State.IncCycles();
    // CALL 0x1000:d239 (1000_D28F / 0x1D28F)
    NearCall(cs1, 0xD292, spice86_generated_label_call_target_1000_D239_01D239);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D292_01D292, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D292_01D292(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D292_1D292:
    // MOV CX,0x11 (1000_D292 / 0x1D292)
    CX = 0x11;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D295_01D295, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D295_01D295(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD2BC: goto label_1000_D2BC_1D2BC;break; // Target of external jump from 0x1D285
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D295_1D295:
    // PUSH CX (1000_D295 / 0x1D295)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH word ptr [0xce7a] (1000_D296 / 0x1D296)
    Stack.Push(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // MOV SI,word ptr [0xdbde] (1000_D29A / 0x1D29A)
    SI = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // MOV AL,0x18 (1000_D29E / 0x1D29E)
    AL = 0x18;
    State.IncCycles();
    // CALL 0x1000:c0d5 (1000_D2A0 / 0x1D2A0)
    NearCall(cs1, 0xD2A3, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    State.IncCycles();
    label_1000_D2A3_1D2A3:
    // POP BX (1000_D2A3 / 0x1D2A3)
    BX = Stack.Pop();
    State.IncCycles();
    label_1000_D2A4_1D2A4:
    // PUSH BX (1000_D2A4 / 0x1D2A4)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:a7c2 (1000_D2A5 / 0x1D2A5)
    NearCall(cs1, 0xD2A8, spice86_generated_label_call_target_1000_A7C2_01A7C2);
    State.IncCycles();
    label_1000_D2A8_1D2A8:
    // POP BX (1000_D2A8 / 0x1D2A8)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_D2A9 / 0x1D2A9)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,BX (1000_D2AC / 0x1D2AC)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x6 (1000_D2AE / 0x1D2AE)
    Alu.Sub16(AX, 0x6);
    State.IncCycles();
    // JC 0x1000:d2a4 (1000_D2B1 / 0x1D2B1)
    if(CarryFlag) {
      goto label_1000_D2A4_1D2A4;
    }
    State.IncCycles();
    // POP CX (1000_D2B3 / 0x1D2B3)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:d295 (1000_D2B4 / 0x1D2B4)
    if(--CX != 0) {
      goto label_1000_D295_1D295;
    }
    State.IncCycles();
    // CALL 0x1000:d23d (1000_D2B6 / 0x1D2B6)
    NearCall(cs1, 0xD2B9, spice86_generated_label_call_target_1000_D23D_01D23D);
    State.IncCycles();
    label_1000_D2B9_1D2B9:
    // CALL 0x1000:e283 (1000_D2B9 / 0x1D2B9)
    NearCall(cs1, 0xD2BC, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_D2BC_1D2BC:
    // RET  (1000_D2BC / 0x1D2BC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D2BD_01D2BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D2BD_1D2BD:
    // MOV AL,[0xdce6] (1000_D2BD / 0x1D2BD)
    AL = UInt8[DS, 0xDCE6];
    State.IncCycles();
    // PUSH AX (1000_D2C0 / 0x1D2C0)
    Stack.Push(AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2C1_01D2C1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D2C1_01D2C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D2C1_1D2C1:
    // MOV byte ptr [0xdce6],0x80 (1000_D2C1 / 0x1D2C1)
    UInt8[DS, 0xDCE6] = 0x80;
    State.IncCycles();
    // MOV SI,word ptr [0x21da] (1000_D2C6 / 0x1D2C6)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV SI,word ptr [SI] (1000_D2CA / 0x1D2CA)
    SI = UInt16[DS, SI];
    State.IncCycles();
    // LODSB SI (1000_D2CC / 0x1D2CC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0xff (1000_D2CD / 0x1D2CD)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:d2da (1000_D2CF / 0x1D2CF)
    if(ZeroFlag) {
      goto label_1000_D2DA_1D2DA;
    }
    State.IncCycles();
    // AND AL,0xf (1000_D2D1 / 0x1D2D1)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // JZ 0x1000:d2da (1000_D2D3 / 0x1D2D3)
    if(ZeroFlag) {
      goto label_1000_D2DA_1D2DA;
    }
    State.IncCycles();
    // CALL 0x1000:d2ea (1000_D2D5 / 0x1D2D5)
    NearCall(cs1, 0xD2D8, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    State.IncCycles();
    label_1000_D2D8_1D2D8:
    // JMP 0x1000:d2c1 (1000_D2D8 / 0x1D2D8)
    goto label_1000_D2C1_1D2C1;
    State.IncCycles();
    label_1000_D2DA_1D2DA:
    // POP AX (1000_D2DA / 0x1D2DA)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0xdce6],AL (1000_D2DB / 0x1D2DB)
    UInt8[DS, 0xDCE6] = AL;
    State.IncCycles();
    // RET  (1000_D2DE / 0x1D2DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D2E2_01D2E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D2E2_1D2E2:
    // CALL 0x1000:d316 (1000_D2E2 / 0x1D2E2)
    NearCall(cs1, 0xD2E5, spice86_generated_label_call_target_1000_D316_01D316);
    State.IncCycles();
    label_1000_D2E5_1D2E5:
    // CALL 0x1000:d2ea (1000_D2E5 / 0x1D2E5)
    NearCall(cs1, 0xD2E8, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D2E8_01D2E8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D2E8_01D2E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D2E8_1D2E8:
    // JMP 0x1000:d280 (1000_D2E8 / 0x1D2E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D2EA_01D2EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D2EA_1D2EA:
    // MOV SI,word ptr [0x21da] (1000_D2EA / 0x1D2EA)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV DI,word ptr [SI] (1000_D2EE / 0x1D2EE)
    DI = UInt16[DS, SI];
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_D2F0 / 0x1D2F0)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // AND AL,0xf (1000_D2F2 / 0x1D2F2)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,0xf (1000_D2F4 / 0x1D2F4)
    Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JZ 0x1000:d315 (1000_D2F6 / 0x1D2F6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D315 / 0x1D315)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_D2F8 / 0x1D2F8)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // CALL AX (1000_D2FB / 0x1D2FB)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_D2FB = (uint)(AX);
    switch(targetAddress_1000_D2FB) {
      case 0x97CF : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_97CF_0197CF); break;
      case 0xA541 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_A541_01A541); break;
      case 0x19FC : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_19FC_0119FC); break;
      case 0x4415 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_4415_014415); break;
      case 0xF66 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x5F91 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_5F91_015F91); break;
      case 0x7D68 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_7D68_017D68); break;
      case 0xB2B3 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_B2B3_01B2B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D2FB));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D2FD_01D2FD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D2FD_01D2FD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD315: goto label_1000_D315_1D315;break; // Target of external jump from 0x1D2F6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D2FD_1D2FD:
    // MOV SI,word ptr [0x21da] (1000_D2FD / 0x1D2FD)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // CMP SI,0x21be (1000_D301 / 0x1D301)
    Alu.Sub16(SI, 0x21BE);
    State.IncCycles();
    // JZ 0x1000:d315 (1000_D305 / 0x1D305)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D315 / 0x1D315)
      return NearRet();
    }
    State.IncCycles();
    // SUB SI,0x4 (1000_D307 / 0x1D307)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    State.IncCycles();
    // MOV word ptr [0x21da],SI (1000_D30A / 0x1D30A)
    UInt16[DS, 0x21DA] = SI;
    State.IncCycles();
    // MOV BP,word ptr [SI] (1000_D30E / 0x1D30E)
    BP = UInt16[DS, SI];
    State.IncCycles();
    // MOV CL,0xff (1000_D310 / 0x1D310)
    CL = 0xFF;
    State.IncCycles();
    // CALL 0x1000:d36d (1000_D312 / 0x1D312)
    NearCall(cs1, 0xD315, spice86_generated_label_call_target_1000_D36D_01D36D);
    State.IncCycles();
    label_1000_D315_1D315:
    // RET  (1000_D315 / 0x1D315)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D316_01D316(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D316_1D316:
    // CMP word ptr [0x35a6],0x0 (1000_D316 / 0x1D316)
    Alu.Sub16(UInt16[DS, 0x35A6], 0x0);
    State.IncCycles();
    // JNZ 0x1000:d322 (1000_D31B / 0x1D31B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D322 / 0x1D322)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [0xdce6],0x1 (1000_D31D / 0x1D31D)
    // UInt8[DS, 0xDCE6] |= 0x1;
    UInt8[DS, 0xDCE6] = Alu.Or8(UInt8[DS, 0xDCE6], 0x1);
    State.IncCycles();
    label_1000_D322_1D322:
    // RET  (1000_D322 / 0x1D322)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D323_01D323(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D323_1D323:
    // CALL 0x1000:d316 (1000_D323 / 0x1D323)
    NearCall(cs1, 0xD326, spice86_generated_label_call_target_1000_D316_01D316);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D326_01D326, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D326_01D326(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D326_1D326:
    // CALL 0x1000:d338 (1000_D326 / 0x1D326)
    NearCall(cs1, 0xD329, spice86_generated_label_call_target_1000_D338_01D338);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D329_01D329, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D329_01D329(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D329_1D329:
    // CALL 0x1000:d280 (1000_D329 / 0x1D329)
    NearCall(cs1, 0xD32C, spice86_generated_label_call_target_1000_D280_01D280);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D32C_01D32C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D32C_01D32C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D32C_1D32C:
    // JMP 0x1000:d410 (1000_D32C / 0x1D32C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D32F_01D32F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D32F_1D32F:
    // CALL 0x1000:d316 (1000_D32F / 0x1D32F)
    NearCall(cs1, 0xD332, spice86_generated_label_call_target_1000_D316_01D316);
    State.IncCycles();
    label_1000_D332_1D332:
    // CALL 0x1000:d33a (1000_D332 / 0x1D332)
    NearCall(cs1, 0xD335, spice86_generated_label_call_target_1000_D33A_01D33A);
    State.IncCycles();
    label_1000_D335_1D335:
    // JMP 0x1000:d280 (1000_D335 / 0x1D335)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D338_01D338(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D338_1D338:
    // MOV CL,0xff (1000_D338 / 0x1D338)
    CL = 0xFF;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D33A_01D33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D33A_01D33A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D33A_1D33A:
    // MOV SI,word ptr [0x21da] (1000_D33A / 0x1D33A)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV DI,word ptr [SI] (1000_D33E / 0x1D33E)
    DI = UInt16[DS, SI];
    State.IncCycles();
    // MOV AL,byte ptr [BP + 0x0] (1000_D340 / 0x1D340)
    AL = UInt8[SS, BP];
    State.IncCycles();
    // CMP AL,byte ptr [DI] (1000_D343 / 0x1D343)
    Alu.Sub8(AL, UInt8[DS, DI]);
    State.IncCycles();
    // JZ 0x1000:d368 (1000_D345 / 0x1D345)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D35B_01D35B, 0x1D368 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JC 0x1000:d35b (1000_D347 / 0x1D347)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D35B_01D35B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH BP (1000_D349 / 0x1D349)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH BX (1000_D34A / 0x1D34A)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_D34B / 0x1D34B)
    Stack.Push(CX);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_D34C / 0x1D34C)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // CALL AX (1000_D34F / 0x1D34F)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_D34F = (uint)(AX);
    switch(targetAddress_1000_D34F) {
      case 0x8751 : NearCall(cs1, 0xD351, spice86_generated_label_call_target_1000_8751_018751); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D34F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D351_01D351, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D351_01D351(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D351_1D351:
    // SUB word ptr [0x21da],0x4 (1000_D351 / 0x1D351)
    // UInt16[DS, 0x21DA] -= 0x4;
    UInt16[DS, 0x21DA] = Alu.Sub16(UInt16[DS, 0x21DA], 0x4);
    State.IncCycles();
    // POP CX (1000_D356 / 0x1D356)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_D357 / 0x1D357)
    BX = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_D358 / 0x1D358)
    BP = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:d33a (1000_D359 / 0x1D359)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D33A_01D33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D35B_01D35B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD368: goto label_1000_D368_1D368;break; // Target of external jump from 0x1D345
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D35B_1D35B:
    // CMP SI,0x21d6 (1000_D35B / 0x1D35B)
    Alu.Sub16(SI, 0x21D6);
    State.IncCycles();
    // JZ 0x1000:d368 (1000_D35F / 0x1D35F)
    if(ZeroFlag) {
      goto label_1000_D368_1D368;
    }
    State.IncCycles();
    // ADD SI,0x4 (1000_D361 / 0x1D361)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // MOV word ptr [0x21da],SI (1000_D364 / 0x1D364)
    UInt16[DS, 0x21DA] = SI;
    State.IncCycles();
    label_1000_D368_1D368:
    // MOV word ptr [SI],BP (1000_D368 / 0x1D368)
    UInt16[DS, SI] = BP;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],BX (1000_D36A / 0x1D36A)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D36D_01D36D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D36D_01D36D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D36D_1D36D:
    // MOV SI,word ptr [0x21da] (1000_D36D / 0x1D36D)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV word ptr [SI],BP (1000_D371 / 0x1D371)
    UInt16[DS, SI] = BP;
    State.IncCycles();
    // MOV SI,BP (1000_D373 / 0x1D373)
    SI = BP;
    State.IncCycles();
    // ADD BP,0x2 (1000_D375 / 0x1D375)
    BP += 0x2;
    State.IncCycles();
    label_1000_D378_1D378:
    // CMP word ptr [BP + 0x0],0x0 (1000_D378 / 0x1D378)
    Alu.Sub16(UInt16[SS, BP], 0x0);
    State.IncCycles();
    // JZ 0x1000:d388 (1000_D37C / 0x1D37C)
    if(ZeroFlag) {
      goto label_1000_D388_1D388;
    }
    State.IncCycles();
    // AND word ptr [BP + 0x0],0x7fff (1000_D37E / 0x1D37E)
    UInt16[SS, BP] &= 0x7FFF;
    State.IncCycles();
    // ADD BP,0x4 (1000_D383 / 0x1D383)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    State.IncCycles();
    // JMP 0x1000:d378 (1000_D386 / 0x1D386)
    goto label_1000_D378_1D378;
    State.IncCycles();
    label_1000_D388_1D388:
    // CMP CX,0x5 (1000_D388 / 0x1D388)
    Alu.Sub16(CX, 0x5);
    State.IncCycles();
    // JNC 0x1000:d397 (1000_D38B / 0x1D38B)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D397_01D397, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // SHL CX,1 (1000_D38D / 0x1D38D)
    CX <<= 0x1;
    State.IncCycles();
    // SHL CX,1 (1000_D38F / 0x1D38F)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    State.IncCycles();
    // MOV BX,CX (1000_D391 / 0x1D391)
    BX = CX;
    State.IncCycles();
    // OR byte ptr [BX + SI + 0x3],0x80 (1000_D393 / 0x1D393)
    // UInt8[DS, (ushort)(BX + SI + 0x3)] |= 0x80;
    UInt8[DS, (ushort)(BX + SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(BX + SI + 0x3)], 0x80);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D397_01D397, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D397_01D397(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D397_1D397:
    // MOV byte ptr [0xdce7],0xff (1000_D397 / 0x1D397)
    UInt8[DS, 0xDCE7] = 0xFF;
    State.IncCycles();
    // MOV SI,word ptr [0x21da] (1000_D39C / 0x1D39C)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV SI,word ptr [SI] (1000_D3A0 / 0x1D3A0)
    SI = UInt16[DS, SI];
    State.IncCycles();
    // INC SI (1000_D3A2 / 0x1D3A2)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // LODSB SI (1000_D3A3 / 0x1D3A3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV [0xdce4],AL (1000_D3A4 / 0x1D3A4)
    UInt8[DS, 0xDCE4] = AL;
    State.IncCycles();
    // CBW  (1000_D3A7 / 0x1D3A7)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD SI,AX (1000_D3A8 / 0x1D3A8)
    SI += AX;
    State.IncCycles();
    // XOR CX,CX (1000_D3AA / 0x1D3AA)
    CX = 0;
    State.IncCycles();
    // MOV byte ptr [0xdce8],CL (1000_D3AC / 0x1D3AC)
    UInt8[DS, 0xDCE8] = CL;
    State.IncCycles();
    // MOV byte ptr [0xdce5],0xff (1000_D3B0 / 0x1D3B0)
    UInt8[DS, 0xDCE5] = 0xFF;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D3B5_01D3B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D3B5_01D3B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D3B5_1D3B5:
    // MOV AX,word ptr [SI] (1000_D3B5 / 0x1D3B5)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // OR AX,AX (1000_D3B7 / 0x1D3B7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:d3ef (1000_D3B9 / 0x1D3B9)
    if(ZeroFlag) {
      goto label_1000_D3EF_1D3EF;
    }
    State.IncCycles();
    // CMP CL,0x4 (1000_D3BB / 0x1D3BB)
    Alu.Sub8(CL, 0x4);
    State.IncCycles();
    // JC 0x1000:d3d9 (1000_D3BE / 0x1D3BE)
    if(CarryFlag) {
      goto label_1000_D3D9_1D3D9;
    }
    State.IncCycles();
    // CMP byte ptr [0xdce4],0x0 (1000_D3C0 / 0x1D3C0)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    State.IncCycles();
    // JNZ 0x1000:d3cd (1000_D3C5 / 0x1D3C5)
    if(!ZeroFlag) {
      goto label_1000_D3CD_1D3CD;
    }
    State.IncCycles();
    // CMP word ptr [SI + 0x4],0x0 (1000_D3C7 / 0x1D3C7)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], 0x0);
    State.IncCycles();
    // JZ 0x1000:d3d9 (1000_D3CB / 0x1D3CB)
    if(ZeroFlag) {
      goto label_1000_D3D9_1D3D9;
    }
    State.IncCycles();
    label_1000_D3CD_1D3CD:
    // OR byte ptr [0xdce4],0x80 (1000_D3CD / 0x1D3CD)
    // UInt8[DS, 0xDCE4] |= 0x80;
    UInt8[DS, 0xDCE4] = Alu.Or8(UInt8[DS, 0xDCE4], 0x80);
    State.IncCycles();
    // MOV AX,0xa0 (1000_D3D2 / 0x1D3D2)
    AX = 0xA0;
    State.IncCycles();
    // MOV byte ptr [0xdce5],CL (1000_D3D5 / 0x1D3D5)
    UInt8[DS, 0xDCE5] = CL;
    State.IncCycles();
    label_1000_D3D9_1D3D9:
    // ADD SI,0x4 (1000_D3D9 / 0x1D3D9)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // PUSH CX (1000_D3DC / 0x1D3DC)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_D3DD / 0x1D3DD)
    Stack.Push(SI);
    State.IncCycles();
    // INC byte ptr [0xdce8] (1000_D3DE / 0x1D3DE)
    UInt8[DS, 0xDCE8] = Alu.Inc8(UInt8[DS, 0xDCE8]);
    State.IncCycles();
    // CALL 0x1000:d48a (1000_D3E2 / 0x1D3E2)
    NearCall(cs1, 0xD3E5, spice86_generated_label_call_target_1000_D48A_01D48A);
    State.IncCycles();
    label_1000_D3E5_1D3E5:
    // POP SI (1000_D3E5 / 0x1D3E5)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_D3E6 / 0x1D3E6)
    CX = Stack.Pop();
    State.IncCycles();
    // INC CX (1000_D3E7 / 0x1D3E7)
    CX++;
    State.IncCycles();
    // CMP CL,0x5 (1000_D3E8 / 0x1D3E8)
    Alu.Sub8(CL, 0x5);
    State.IncCycles();
    // JC 0x1000:d3b5 (1000_D3EB / 0x1D3EB)
    if(CarryFlag) {
      goto label_1000_D3B5_1D3B5;
    }
    State.IncCycles();
    // JMP 0x1000:d410 (1000_D3ED / 0x1D3ED)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_D3EF_1D3EF:
    // CMP byte ptr [0xdce4],0x0 (1000_D3EF / 0x1D3EF)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    State.IncCycles();
    // JZ 0x1000:d403 (1000_D3F4 / 0x1D3F4)
    if(ZeroFlag) {
      goto label_1000_D403_1D403;
    }
    State.IncCycles();
    // MOV AX,0xa0 (1000_D3F6 / 0x1D3F6)
    AX = 0xA0;
    State.IncCycles();
    // MOV byte ptr [0xdce5],CL (1000_D3F9 / 0x1D3F9)
    UInt8[DS, 0xDCE5] = CL;
    State.IncCycles();
    // INC byte ptr [0xdce8] (1000_D3FD / 0x1D3FD)
    UInt8[DS, 0xDCE8] = Alu.Inc8(UInt8[DS, 0xDCE8]);
    State.IncCycles();
    // JMP 0x1000:d405 (1000_D401 / 0x1D401)
    goto label_1000_D405_1D405;
    State.IncCycles();
    label_1000_D403_1D403:
    // XOR AX,AX (1000_D403 / 0x1D403)
    AX = 0;
    State.IncCycles();
    label_1000_D405_1D405:
    // PUSH CX (1000_D405 / 0x1D405)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:d48a (1000_D406 / 0x1D406)
    NearCall(cs1, 0xD409, spice86_generated_label_call_target_1000_D48A_01D48A);
    State.IncCycles();
    label_1000_D409_1D409:
    // POP CX (1000_D409 / 0x1D409)
    CX = Stack.Pop();
    State.IncCycles();
    // INC CX (1000_D40A / 0x1D40A)
    CX++;
    State.IncCycles();
    // CMP CL,0x5 (1000_D40B / 0x1D40B)
    Alu.Sub8(CL, 0x5);
    State.IncCycles();
    // JC 0x1000:d403 (1000_D40E / 0x1D40E)
    if(CarryFlag) {
      goto label_1000_D403_1D403;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D410_01D410(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D410_1D410:
    // MOV DX,word ptr [0xdc36] (1000_D410 / 0x1D410)
    DX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // MOV BX,word ptr [0xdc38] (1000_D414 / 0x1D414)
    BX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // JMP 0x1000:d50f (1000_D418 / 0x1D418)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D50F_01D50F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D41B_01D41B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D41B_1D41B:
    // MOV BP,word ptr [0x21da] (1000_D41B / 0x1D41B)
    BP = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV BP,word ptr [BP + 0x0] (1000_D41F / 0x1D41F)
    BP = UInt16[SS, BP];
    State.IncCycles();
    // RET  (1000_D422 / 0x1D422)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D42F_01D42F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D42F_1D42F:
    // MOV CX,0x4 (1000_D42F / 0x1D42F)
    CX = 0x4;
    State.IncCycles();
    // JMP 0x1000:d445 (1000_D432 / 0x1D432)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D434_01D434(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D434_1D434:
    // MOV CX,0x3 (1000_D434 / 0x1D434)
    CX = 0x3;
    State.IncCycles();
    // JMP 0x1000:d445 (1000_D437 / 0x1D437)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D439_01D439(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D439_1D439:
    // MOV CX,0x2 (1000_D439 / 0x1D439)
    CX = 0x2;
    State.IncCycles();
    // JMP 0x1000:d445 (1000_D43C / 0x1D43C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D43E_01D43E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D43E_1D43E:
    // MOV CX,0x1 (1000_D43E / 0x1D43E)
    CX = 0x1;
    State.IncCycles();
    // JMP 0x1000:d445 (1000_D441 / 0x1D441)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D443_01D443(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D443_1D443:
    // XOR CX,CX (1000_D443 / 0x1D443)
    CX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D445_01D445(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D445_1D445:
    // CALL 0x1000:d454 (1000_D445 / 0x1D445)
    NearCall(cs1, 0xD448, spice86_generated_label_call_target_1000_D454_01D454);
    State.IncCycles();
    label_1000_D448_1D448:
    // OR BX,BX (1000_D448 / 0x1D448)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:d453 (1000_D44A / 0x1D44A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D453 / 0x1D453)
      return NearRet();
    }
    State.IncCycles();
    // TEST AH,0x40 (1000_D44C / 0x1D44C)
    Alu.And8(AH, 0x40);
    State.IncCycles();
    // JNZ 0x1000:d453 (1000_D44F / 0x1D44F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D453 / 0x1D453)
      return NearRet();
    }
    State.IncCycles();
    // JMP BX (1000_D451 / 0x1D451)
    // Indirect jump to BX, generating possible targets from emulator records
    uint targetAddress_1000_D451 = (uint)(BX);
    switch(targetAddress_1000_D451) {
      case 0xA3F0 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A3F0_01A3F0, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xE3E : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0E3E_010E3E, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x3A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xD2E2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xEA6 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0EA6_010EA6, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x4FFB : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4FFB_014FFB, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x95C1 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_95C1_0195C1, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x5A03 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5A03_015A03, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x69B3 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_69B3_0169B3, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x6A83 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6A83_016A83, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x6A71 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6A71_016A71, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x8763 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8763_018763, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x95E2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_95E2_0195E2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF60 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF60_01AF60, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF68 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF68_01AF68, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF70 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF70_01AF70, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB18B : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B18B_01B18B, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x50A5 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_50A5_0150A5, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x497A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_497A_01497A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x50DB : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_50DB_0150DB, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9ED5 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9ED5_019ED5, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9472 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9472_019472, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x7CBB : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7CBB_017CBB, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB96B : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B96B_01B96B, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB28C : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B28C_01B28C, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB35A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B35A_01B35A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB961 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B961_01B961, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF58 : throw FailAsUntested("Would have been a goto but label label_1000_AF58_1AF58 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D451));
        break;
    }
    State.IncCycles();
    label_1000_D453_1D453:
    // RET  (1000_D453 / 0x1D453)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D454_01D454(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D454_1D454:
    // MOV SI,word ptr [0x21da] (1000_D454 / 0x1D454)
    SI = UInt16[DS, 0x21DA];
    State.IncCycles();
    // MOV SI,word ptr [SI] (1000_D458 / 0x1D458)
    SI = UInt16[DS, SI];
    State.IncCycles();
    // INC SI (1000_D45A / 0x1D45A)
    SI++;
    State.IncCycles();
    // XOR CH,CH (1000_D45B / 0x1D45B)
    CH = 0;
    State.IncCycles();
    // CMP CL,byte ptr [0xdce5] (1000_D45D / 0x1D45D)
    Alu.Sub8(CL, UInt8[DS, 0xDCE5]);
    State.IncCycles();
    // JZ 0x1000:d475 (1000_D461 / 0x1D461)
    if(ZeroFlag) {
      goto label_1000_D475_1D475;
    }
    State.IncCycles();
    // LODSB SI (1000_D463 / 0x1D463)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CBW  (1000_D464 / 0x1D464)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD SI,AX (1000_D465 / 0x1D465)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV AX,CX (1000_D467 / 0x1D467)
    AX = CX;
    State.IncCycles();
    // SHL AX,1 (1000_D469 / 0x1D469)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_D46B / 0x1D46B)
    AX <<= 0x1;
    State.IncCycles();
    // ADD SI,AX (1000_D46D / 0x1D46D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_D46F / 0x1D46F)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_D471 / 0x1D471)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // RET  (1000_D474 / 0x1D474)
    return NearRet();
    State.IncCycles();
    label_1000_D475_1D475:
    // MOV AX,0xa0 (1000_D475 / 0x1D475)
    AX = 0xA0;
    State.IncCycles();
    // MOV BX,0xd423 (1000_D478 / 0x1D478)
    BX = 0xD423;
    State.IncCycles();
    // CMP byte ptr [0xdce4],0x0 (1000_D47B / 0x1D47B)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    State.IncCycles();
    // JS 0x1000:d489 (1000_D480 / 0x1D480)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D489 / 0x1D489)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,0xd429 (1000_D482 / 0x1D482)
    BX = 0xD429;
    State.IncCycles();
    // JG 0x1000:d489 (1000_D485 / 0x1D485)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D489 / 0x1D489)
      return NearRet();
    }
    State.IncCycles();
    // XOR BX,BX (1000_D487 / 0x1D487)
    BX = 0;
    State.IncCycles();
    label_1000_D489_1D489:
    // RET  (1000_D489 / 0x1D489)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D48A_01D48A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D48A_1D48A:
    // PUSH word ptr [0xdbda] (1000_D48A / 0x1D48A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_D48E / 0x1D48E)
    NearCall(cs1, 0xD491, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D491_01D491, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D491_01D491(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D491_1D491:
    // CMP byte ptr [0xdce6],0x0 (1000_D491 / 0x1D491)
    Alu.Sub8(UInt8[DS, 0xDCE6], 0x0);
    State.IncCycles();
    // JLE 0x1000:d49b (1000_D496 / 0x1D496)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D49B_01D49B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:c07c (1000_D498 / 0x1D498)
    NearCall(cs1, 0xD49B, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D49B_01D49B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D49B_01D49B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D49B_1D49B:
    // CALL 0x1000:d075 (1000_D49B / 0x1D49B)
    NearCall(cs1, 0xD49E, spice86_generated_label_call_target_1000_D075_01D075);
    State.IncCycles();
    label_1000_D49E_1D49E:
    // MOV SI,AX (1000_D49E / 0x1D49E)
    SI = AX;
    State.IncCycles();
    // MOV AL,0xe (1000_D4A0 / 0x1D4A0)
    AL = 0xE;
    State.IncCycles();
    // MUL CL (1000_D4A2 / 0x1D4A2)
    Cpu.Mul8(CL);
    State.IncCycles();
    // MOV DI,AX (1000_D4A4 / 0x1D4A4)
    DI = AX;
    State.IncCycles();
    // ADD DI,0x1b48 (1000_D4A6 / 0x1D4A6)
    // DI += 0x1B48;
    DI = Alu.Add16(DI, 0x1B48);
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x2] (1000_D4AA / 0x1D4AA)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // INC BX (1000_D4AD / 0x1D4AD)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // MOV DX,0x5d (1000_D4AE / 0x1D4AE)
    DX = 0x5D;
    State.IncCycles();
    // CALL 0x1000:d04e (1000_D4B1 / 0x1D4B1)
    NearCall(cs1, 0xD4B4, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D4B4_01D4B4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D4B4_01D4B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D4B4_1D4B4:
    // MOV byte ptr [0xdbe5],0xf3 (1000_D4B4 / 0x1D4B4)
    UInt8[DS, 0xDBE5] = 0xF3;
    State.IncCycles();
    // AND byte ptr [DI + 0x8],0x7f (1000_D4B9 / 0x1D4B9)
    // UInt8[DS, (ushort)(DI + 0x8)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0x8)] = Alu.And8(UInt8[DS, (ushort)(DI + 0x8)], 0x7F);
    State.IncCycles();
    // MOV AX,SI (1000_D4BD / 0x1D4BD)
    AX = SI;
    State.IncCycles();
    // AND SI,0x3fff (1000_D4BF / 0x1D4BF)
    // SI &= 0x3FFF;
    SI = Alu.And16(SI, 0x3FFF);
    State.IncCycles();
    // JZ 0x1000:d4e9 (1000_D4C3 / 0x1D4C3)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D4E6_01D4E6, 0x1D4E9 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0xf5 (1000_D4C5 / 0x1D4C5)
    AL = 0xF5;
    State.IncCycles();
    // TEST AH,0x40 (1000_D4C7 / 0x1D4C7)
    Alu.And8(AH, 0x40);
    State.IncCycles();
    // JNZ 0x1000:d4da (1000_D4CA / 0x1D4CA)
    if(!ZeroFlag) {
      goto label_1000_D4DA_1D4DA;
    }
    State.IncCycles();
    // OR byte ptr [DI + 0x8],0x80 (1000_D4CC / 0x1D4CC)
    // UInt8[DS, (ushort)(DI + 0x8)] |= 0x80;
    UInt8[DS, (ushort)(DI + 0x8)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0x8)], 0x80);
    State.IncCycles();
    // MOV AL,0xfa (1000_D4D0 / 0x1D4D0)
    AL = 0xFA;
    State.IncCycles();
    // OR AH,AH (1000_D4D2 / 0x1D4D2)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JNS 0x1000:d4da (1000_D4D4 / 0x1D4D4)
    if(!SignFlag) {
      goto label_1000_D4DA_1D4DA;
    }
    State.IncCycles();
    // XCHG byte ptr [0xdbe5],AL (1000_D4D6 / 0x1D4D6)
    byte tmp_1000_D4D6 = UInt8[DS, 0xDBE5];
    UInt8[DS, 0xDBE5] = AL;
    AL = tmp_1000_D4D6;
    State.IncCycles();
    label_1000_D4DA_1D4DA:
    // MOV [0xdbe4],AL (1000_D4DA / 0x1D4DA)
    UInt8[DS, 0xDBE4] = AL;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_D4DD / 0x1D4DD)
    NearCall(cs1, 0xD4E0, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_D4E0_1D4E0:
    // MOV AL,0x20 (1000_D4E0 / 0x1D4E0)
    AL = 0x20;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_D4E2 / 0x1D4E2)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_D4E2 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_D4E2) {
      case 0xD12F : NearCall(cs1, 0xD4E6, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D4E2));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D4E6_01D4E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D4E6_01D4E6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD4E9: goto label_1000_D4E9_1D4E9;break; // Target of external jump from 0x1D4C3
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D4E6_1D4E6:
    // CALL 0x1000:d1bb (1000_D4E6 / 0x1D4E6)
    NearCall(cs1, 0xD4E9, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    State.IncCycles();
    label_1000_D4E9_1D4E9:
    // CALL 0x1000:d05f (1000_D4E9 / 0x1D4E9)
    NearCall(cs1, 0xD4EC, spice86_generated_label_call_target_1000_D05F_01D05F);
    State.IncCycles();
    label_1000_D4EC_1D4EC:
    // MOV SI,0xdce9 (1000_D4EC / 0x1D4EC)
    SI = 0xDCE9;
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_D4EF / 0x1D4EF)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],BX (1000_D4F1 / 0x1D4F1)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    State.IncCycles();
    // MOV word ptr [SI + 0x4],0xe3 (1000_D4F4 / 0x1D4F4)
    UInt16[DS, (ushort)(SI + 0x4)] = 0xE3;
    State.IncCycles();
    // ADD BX,0x7 (1000_D4F9 / 0x1D4F9)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_D4FC / 0x1D4FC)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    // MOV AL,[0xdbe5] (1000_D4FF / 0x1D4FF)
    AL = UInt8[DS, 0xDBE5];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_D502 / 0x1D502)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x38dd] (1000_D506 / 0x1D506)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_D506 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_D506) {
      case 0x235CE : FarCall(cs1, 0xD50A, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D506));
        break;
    }
    State.IncCycles();
    label_1000_D50A_1D50A:
    // POP word ptr [0xdbda] (1000_D50A / 0x1D50A)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D50E / 0x1D50E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D50F_01D50F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D50F_1D50F:
    // PUSH BX (1000_D50F / 0x1D50F)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_D510 / 0x1D510)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_D511 / 0x1D511)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_D512 / 0x1D512)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_D513 / 0x1D513)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_D514 / 0x1D514)
    Stack.Push(BP);
    State.IncCycles();
    // CMP byte ptr [0x4774],0x0 (1000_D515 / 0x1D515)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JZ 0x1000:d523 (1000_D51A / 0x1D51A)
    if(ZeroFlag) {
      goto label_1000_D523_1D523;
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x4775] (1000_D51C / 0x1D51C)
    CL = UInt8[DS, 0x4775];
    State.IncCycles();
    // JMP 0x1000:d5dd (1000_D520 / 0x1D520)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D5DD - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_D523_1D523:
    // CALL 0x1000:d41b (1000_D523 / 0x1D523)
    NearCall(cs1, 0xD526, spice86_generated_label_call_target_1000_D41B_01D41B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D526_01D526, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D526_01D526(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D526_1D526:
    // CMP BP,0x1f0e (1000_D526 / 0x1D526)
    Alu.Sub16(BP, 0x1F0E);
    State.IncCycles();
    // JNZ 0x1000:d575 (1000_D52A / 0x1D52A)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D575 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x11c9],0x0 (1000_D52C / 0x1D52C)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:d575 (1000_D531 / 0x1D531)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D575 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DI,0x1bf0 (1000_D533 / 0x1D533)
    DI = 0x1BF0;
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x0 (1000_D536 / 0x1D536)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    State.IncCycles();
    // JNS 0x1000:d545 (1000_D53A / 0x1D53A)
    if(!SignFlag) {
      goto label_1000_D545_1D545;
    }
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_D53C / 0x1D53C)
    NearCall(cs1, 0xD53F, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_D53F_1D53F:
    // MOV CX,word ptr [0x47c4] (1000_D53F / 0x1D53F)
    CX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // JC 0x1000:d55d (1000_D543 / 0x1D543)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D55D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_D545_1D545:
    // PUSH BP (1000_D545 / 0x1D545)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:9285 (1000_D546 / 0x1D546)
    NearCall(cs1, 0xD549, spice86_generated_label_call_target_1000_9285_019285);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D549_01D549(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD575: goto label_1000_D575_1D575;break; // Target of external jump from 0x1D531, 0x1D54A, 0x1D52A
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D549_1D549:
    // POP BP (1000_D549 / 0x1D549)
    BP = Stack.Pop();
    State.IncCycles();
    // JNC 0x1000:d575 (1000_D54A / 0x1D54A)
    if(!CarryFlag) {
      goto label_1000_D575_1D575;
    }
    State.IncCycles();
    // MOV AL,CL (1000_D54C / 0x1D54C)
    AL = CL;
    State.IncCycles();
    // SUB AL,0xf (1000_D54E / 0x1D54E)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JC 0x1000:d55d (1000_D550 / 0x1D550)
    if(CarryFlag) {
      goto label_1000_D55D_1D55D;
    }
    State.IncCycles();
    // INC AL (1000_D552 / 0x1D552)
    AL++;
    State.IncCycles();
    // CMP AL,byte ptr [0x476b] (1000_D554 / 0x1D554)
    Alu.Sub8(AL, UInt8[DS, 0x476B]);
    State.IncCycles();
    // JNZ 0x1000:d55d (1000_D558 / 0x1D558)
    if(!ZeroFlag) {
      goto label_1000_D55D_1D55D;
    }
    State.IncCycles();
    // MOV CX,0x17 (1000_D55A / 0x1D55A)
    CX = 0x17;
    State.IncCycles();
    label_1000_D55D_1D55D:
    // MOV BP,CX (1000_D55D / 0x1D55D)
    BP = CX;
    State.IncCycles();
    // ADD BP,0x78 (1000_D55F / 0x1D55F)
    BP += 0x78;
    State.IncCycles();
    // XOR CX,CX (1000_D563 / 0x1D563)
    CX = 0;
    State.IncCycles();
    label_1000_D565_1D565:
    // CALL 0x1000:d454 (1000_D565 / 0x1D565)
    NearCall(cs1, 0xD568, spice86_generated_label_call_target_1000_D454_01D454);
    State.IncCycles();
    label_1000_D568_1D568:
    // CMP AX,BP (1000_D568 / 0x1D568)
    Alu.Sub16(AX, BP);
    State.IncCycles();
    // JZ 0x1000:d5dd (1000_D56A / 0x1D56A)
    if(ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    // INC CX (1000_D56C / 0x1D56C)
    CX++;
    State.IncCycles();
    // CMP CL,byte ptr [0xdce8] (1000_D56D / 0x1D56D)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    State.IncCycles();
    // JC 0x1000:d565 (1000_D571 / 0x1D571)
    if(CarryFlag) {
      goto label_1000_D565_1D565;
    }
    State.IncCycles();
    // JMP 0x1000:d5db (1000_D573 / 0x1D573)
    goto label_1000_D5DB_1D5DB;
    State.IncCycles();
    label_1000_D575_1D575:
    // CMP BP,0x1f7e (1000_D575 / 0x1D575)
    Alu.Sub16(BP, 0x1F7E);
    State.IncCycles();
    // JNZ 0x1000:d5b1 (1000_D579 / 0x1D579)
    if(!ZeroFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    State.IncCycles();
    // MOV DI,0x1be2 (1000_D57B / 0x1D57B)
    DI = 0x1BE2;
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x0 (1000_D57E / 0x1D57E)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    State.IncCycles();
    // JNS 0x1000:d593 (1000_D582 / 0x1D582)
    if(!SignFlag) {
      goto label_1000_D593_1D593;
    }
    State.IncCycles();
    // XOR CX,CX (1000_D584 / 0x1D584)
    CX = 0;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_D586 / 0x1D586)
    NearCall(cs1, 0xD589, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_D589_1D589:
    // JC 0x1000:d5dd (1000_D589 / 0x1D589)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    // MOV DI,0x1bf0 (1000_D58B / 0x1D58B)
    DI = 0x1BF0;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_D58E / 0x1D58E)
    NearCall(cs1, 0xD591, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_D591_1D591:
    // JC 0x1000:d5dd (1000_D591 / 0x1D591)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    label_1000_D593_1D593:
    // CMP byte ptr [0x1bf8],0x0 (1000_D593 / 0x1D593)
    Alu.Sub8(UInt8[DS, 0x1BF8], 0x0);
    State.IncCycles();
    // JNS 0x1000:d5b1 (1000_D598 / 0x1D598)
    if(!SignFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    State.IncCycles();
    // MOV DI,0x1bfe (1000_D59A / 0x1D59A)
    DI = 0x1BFE;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_D59D / 0x1D59D)
    NearCall(cs1, 0xD5A0, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_D5A0_1D5A0:
    // MOV CL,0x3 (1000_D5A0 / 0x1D5A0)
    CL = 0x3;
    State.IncCycles();
    // JC 0x1000:d5dd (1000_D5A2 / 0x1D5A2)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    // CALL 0x1000:92c9 (1000_D5A4 / 0x1D5A4)
    NearCall(cs1, 0xD5A7, spice86_generated_label_call_target_1000_92C9_0192C9);
    State.IncCycles();
    label_1000_D5A7_1D5A7:
    // JNC 0x1000:d5b1 (1000_D5A7 / 0x1D5A7)
    if(!CarryFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    State.IncCycles();
    // CMP CX,word ptr [0x47c4] (1000_D5A9 / 0x1D5A9)
    Alu.Sub16(CX, UInt16[DS, 0x47C4]);
    State.IncCycles();
    // MOV CL,0x2 (1000_D5AD / 0x1D5AD)
    CL = 0x2;
    State.IncCycles();
    // JZ 0x1000:d5dd (1000_D5AF / 0x1D5AF)
    if(ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    label_1000_D5B1_1D5B1:
    // CMP BX,0x98 (1000_D5B1 / 0x1D5B1)
    Alu.Sub16(BX, 0x98);
    State.IncCycles();
    // JC 0x1000:d5db (1000_D5B5 / 0x1D5B5)
    if(CarryFlag) {
      goto label_1000_D5DB_1D5DB;
    }
    State.IncCycles();
    // MOV CL,0xff (1000_D5B7 / 0x1D5B7)
    CL = 0xFF;
    State.IncCycles();
    // MOV DI,0x1b48 (1000_D5B9 / 0x1D5B9)
    DI = 0x1B48;
    State.IncCycles();
    // CMP DX,word ptr [DI] (1000_D5BC / 0x1D5BC)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JC 0x1000:d5dd (1000_D5BE / 0x1D5BE)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI + 0x4] (1000_D5C0 / 0x1D5C0)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JNC 0x1000:d5dd (1000_D5C3 / 0x1D5C3)
    if(!CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    // XOR CX,CX (1000_D5C5 / 0x1D5C5)
    CX = 0;
    State.IncCycles();
    label_1000_D5C7_1D5C7:
    // CMP BX,word ptr [DI + 0x2] (1000_D5C7 / 0x1D5C7)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JBE 0x1000:d5db (1000_D5CA / 0x1D5CA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D5DB_1D5DB;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x6] (1000_D5CC / 0x1D5CC)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // JBE 0x1000:d5dd (1000_D5CF / 0x1D5CF)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    State.IncCycles();
    // ADD DI,0xe (1000_D5D1 / 0x1D5D1)
    DI += 0xE;
    State.IncCycles();
    // INC CX (1000_D5D4 / 0x1D5D4)
    CX++;
    State.IncCycles();
    // CMP CL,byte ptr [0xdce8] (1000_D5D5 / 0x1D5D5)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    State.IncCycles();
    // JC 0x1000:d5c7 (1000_D5D9 / 0x1D5D9)
    if(CarryFlag) {
      goto label_1000_D5C7_1D5C7;
    }
    State.IncCycles();
    label_1000_D5DB_1D5DB:
    // MOV CL,0xff (1000_D5DB / 0x1D5DB)
    CL = 0xFF;
    State.IncCycles();
    label_1000_D5DD_1D5DD:
    // MOV AL,CL (1000_D5DD / 0x1D5DD)
    AL = CL;
    State.IncCycles();
    // XCHG byte ptr [0xdce7],CL (1000_D5DF / 0x1D5DF)
    byte tmp_1000_D5DF = UInt8[DS, 0xDCE7];
    UInt8[DS, 0xDCE7] = CL;
    CL = tmp_1000_D5DF;
    State.IncCycles();
    // CMP AL,CL (1000_D5E3 / 0x1D5E3)
    Alu.Sub8(AL, CL);
    State.IncCycles();
    // JZ 0x1000:d610 (1000_D5E5 / 0x1D5E5)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0x1D610 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_D5E7 / 0x1D5E7)
    NearCall(cs1, 0xD5EA, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_D5EA_1D5EA:
    // OR CL,CL (1000_D5EA / 0x1D5EA)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JS 0x1000:d5fc (1000_D5EC / 0x1D5EC)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0x1D5FC - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP CL,byte ptr [0xdce8] (1000_D5EE / 0x1D5EE)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    State.IncCycles();
    // JNC 0x1000:d5fc (1000_D5F2 / 0x1D5F2)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0x1D5FC - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH AX (1000_D5F4 / 0x1D5F4)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:d454 (1000_D5F5 / 0x1D5F5)
    NearCall(cs1, 0xD5F8, spice86_generated_label_call_target_1000_D454_01D454);
    State.IncCycles();
    label_1000_D5F8_1D5F8:
    // CALL 0x1000:d48a (1000_D5F8 / 0x1D5F8)
    NearCall(cs1, 0xD5FB, spice86_generated_label_call_target_1000_D48A_01D48A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D5FB_01D5FB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD610: goto label_1000_D610_1D610;break; // Target of external jump from 0x1D5E5
      case 0xD5FC: goto label_1000_D5FC_1D5FC;break; // Target of external jump from 0x1D5EC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_D5FB_1D5FB:
    // POP AX (1000_D5FB / 0x1D5FB)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_D5FC_1D5FC:
    // CMP AL,byte ptr [0xdce8] (1000_D5FC / 0x1D5FC)
    Alu.Sub8(AL, UInt8[DS, 0xDCE8]);
    State.IncCycles();
    // JNC 0x1000:d60d (1000_D600 / 0x1D600)
    if(!CarryFlag) {
      goto label_1000_D60D_1D60D;
    }
    State.IncCycles();
    // MOV CX,AX (1000_D602 / 0x1D602)
    CX = AX;
    State.IncCycles();
    // CALL 0x1000:d454 (1000_D604 / 0x1D604)
    NearCall(cs1, 0xD607, spice86_generated_label_call_target_1000_D454_01D454);
    State.IncCycles();
    label_1000_D607_1D607:
    // OR AH,0x80 (1000_D607 / 0x1D607)
    // AH |= 0x80;
    AH = Alu.Or8(AH, 0x80);
    State.IncCycles();
    // CALL 0x1000:d48a (1000_D60A / 0x1D60A)
    NearCall(cs1, 0xD60D, spice86_generated_label_call_target_1000_D48A_01D48A);
    State.IncCycles();
    label_1000_D60D_1D60D:
    // CALL 0x1000:dbec (1000_D60D / 0x1D60D)
    NearCall(cs1, 0xD610, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    State.IncCycles();
    label_1000_D610_1D610:
    // POP BP (1000_D610 / 0x1D610)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_D611 / 0x1D611)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_D612 / 0x1D612)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_D613 / 0x1D613)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_D614 / 0x1D614)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_D615 / 0x1D615)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D616 / 0x1D616)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_D617_01D617(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D617_1D617:
    // PUSH AX (1000_D617 / 0x1D617)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,0x90 (1000_D618 / 0x1D618)
    AX = 0x90;
    State.IncCycles();
    // JMP 0x1000:d621 (1000_D61B / 0x1D61B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D61D_01D61D, 0x1D621 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D61D_01D61D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D61D_1D61D:
    // PUSH AX (1000_D61D / 0x1D61D)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,0x9f (1000_D61E / 0x1D61E)
    AX = 0x9F;
    State.IncCycles();
    label_1000_D621_1D621:
    // CALL 0x1000:e270 (1000_D621 / 0x1D621)
    NearCall(cs1, 0xD624, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D624_01D624, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D624_01D624(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D624_1D624:
    // CALL 0x1000:d41b (1000_D624 / 0x1D624)
    NearCall(cs1, 0xD627, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    label_1000_D627_1D627:
    // MOV SI,0x1f7e (1000_D627 / 0x1D627)
    SI = 0x1F7E;
    State.IncCycles();
    // CMP word ptr [SI + 0x2],AX (1000_D62A / 0x1D62A)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], AX);
    State.IncCycles();
    // MOV word ptr [SI + 0x2],AX (1000_D62D / 0x1D62D)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    State.IncCycles();
    // JZ 0x1000:d649 (1000_D630 / 0x1D630)
    if(ZeroFlag) {
      goto label_1000_D649_1D649;
    }
    State.IncCycles();
    // CMP BP,SI (1000_D632 / 0x1D632)
    Alu.Sub16(BP, SI);
    State.IncCycles();
    // JNZ 0x1000:d649 (1000_D634 / 0x1D634)
    if(!ZeroFlag) {
      goto label_1000_D649_1D649;
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_D636 / 0x1D636)
    NearCall(cs1, 0xD639, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // XOR CX,CX (1000_D639 / 0x1D639)
    CX = 0;
    State.IncCycles();
    // CALL 0x1000:d454 (1000_D63B / 0x1D63B)
    NearCall(cs1, 0xD63E, spice86_generated_label_call_target_1000_D454_01D454);
    State.IncCycles();
    // CALL 0x1000:d48a (1000_D63E / 0x1D63E)
    NearCall(cs1, 0xD641, spice86_generated_label_call_target_1000_D48A_01D48A);
    State.IncCycles();
    // MOV byte ptr [0xdce7],0xff (1000_D641 / 0x1D641)
    UInt8[DS, 0xDCE7] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:dbec (1000_D646 / 0x1D646)
    NearCall(cs1, 0xD649, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    State.IncCycles();
    label_1000_D649_1D649:
    // CALL 0x1000:e283 (1000_D649 / 0x1D649)
    NearCall(cs1, 0xD64C, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_D64C_1D64C:
    // POP AX (1000_D64C / 0x1D64C)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D64D / 0x1D64D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D64E_01D64E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D64E_1D64E:
    // PUSH BX (1000_D64E / 0x1D64E)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_D64F / 0x1D64F)
    Stack.Push(DX);
    State.IncCycles();
    // XOR BX,BX (1000_D650 / 0x1D650)
    BX = 0;
    State.IncCycles();
    // XOR DX,DX (1000_D652 / 0x1D652)
    DX = 0;
    State.IncCycles();
    // CALL 0x1000:d50f (1000_D654 / 0x1D654)
    NearCall(cs1, 0xD657, spice86_generated_label_call_target_1000_D50F_01D50F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D657_01D657, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D657_01D657(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D657_1D657:
    // POP DX (1000_D657 / 0x1D657)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_D658 / 0x1D658)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_D659 / 0x1D659)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D65A_01D65A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D65A_1D65A:
    // TEST byte ptr [DI + 0x9],0x20 (1000_D65A / 0x1D65A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x9)], 0x20);
    State.IncCycles();
    // JZ 0x1000:d676 (1000_D65E / 0x1D65E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D676 / 0x1D676)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [0xdc60],DI (1000_D660 / 0x1D660)
    UInt16[DS, 0xDC60] = DI;
    State.IncCycles();
    // INC word ptr [DI + 0xa] (1000_D664 / 0x1D664)
    UInt16[DS, (ushort)(DI + 0xA)] = Alu.Inc16(UInt16[DS, (ushort)(DI + 0xA)]);
    State.IncCycles();
    // PUSH SI (1000_D667 / 0x1D667)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_D668 / 0x1D668)
    Stack.Push(DI);
    State.IncCycles();
    // MOV SI,DI (1000_D669 / 0x1D669)
    SI = DI;
    State.IncCycles();
    // MOV CX,0x1 (1000_D66B / 0x1D66B)
    CX = 0x1;
    State.IncCycles();
    // CALL 0x1000:d1f2 (1000_D66E / 0x1D66E)
    NearCall(cs1, 0xD671, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    State.IncCycles();
    // POP DI (1000_D671 / 0x1D671)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_D672 / 0x1D672)
    SI = Stack.Pop();
    State.IncCycles();
    // DEC word ptr [DI + 0xa] (1000_D673 / 0x1D673)
    UInt16[DS, (ushort)(DI + 0xA)] = Alu.Dec16(UInt16[DS, (ushort)(DI + 0xA)]);
    State.IncCycles();
    label_1000_D676_1D676:
    // RET  (1000_D676 / 0x1D676)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D694_01D694(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D694_1D694:
    // MOV AX,[0x2582] (1000_D694 / 0x1D694)
    AX = UInt16[DS, 0x2582];
    State.IncCycles();
    // MOV DI,0x1b9c (1000_D697 / 0x1D697)
    DI = 0x1B9C;
    State.IncCycles();
    // CMP AX,0x260c (1000_D69A / 0x1D69A)
    Alu.Sub16(AX, 0x260C);
    State.IncCycles();
    // JZ 0x1000:d6b5 (1000_D69D / 0x1D69D)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    State.IncCycles();
    // ADD DI,0xe (1000_D69F / 0x1D69F)
    DI += 0xE;
    State.IncCycles();
    // CMP AX,0x2650 (1000_D6A2 / 0x1D6A2)
    Alu.Sub16(AX, 0x2650);
    State.IncCycles();
    // JZ 0x1000:d6b5 (1000_D6A5 / 0x1D6A5)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    State.IncCycles();
    // ADD DI,0xe (1000_D6A7 / 0x1D6A7)
    DI += 0xE;
    State.IncCycles();
    // CMP AX,0x2694 (1000_D6AA / 0x1D6AA)
    Alu.Sub16(AX, 0x2694);
    State.IncCycles();
    // JZ 0x1000:d6b5 (1000_D6AD / 0x1D6AD)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    State.IncCycles();
    // ADD DI,0xe (1000_D6AF / 0x1D6AF)
    DI += 0xE;
    State.IncCycles();
    // CMP AX,0x26d8 (1000_D6B2 / 0x1D6B2)
    Alu.Sub16(AX, 0x26D8);
    State.IncCycles();
    label_1000_D6B5_1D6B5:
    // STC  (1000_D6B5 / 0x1D6B5)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_D6B6 / 0x1D6B6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D6B7_01D6B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D6B7_1D6B7:
    // CALL 0x1000:d694 (1000_D6B7 / 0x1D6B7)
    NearCall(cs1, 0xD6BA, spice86_generated_label_call_target_1000_D694_01D694);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D6BA_01D6BA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D6BA_01D6BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D6BA_1D6BA:
    // JZ 0x1000:d6fd (1000_D6BA / 0x1D6BA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D6FD / 0x1D6FD)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x1ae4 (1000_D6BC / 0x1D6BC)
    DI = 0x1AE4;
    State.IncCycles();
    // MOV CX,word ptr [DI] (1000_D6BF / 0x1D6BF)
    CX = UInt16[DS, DI];
    State.IncCycles();
    // ADD DI,0x2 (1000_D6C1 / 0x1D6C1)
    DI += 0x2;
    State.IncCycles();
    // CMP word ptr [0x2570],0x1ad6 (1000_D6C4 / 0x1D6C4)
    Alu.Sub16(UInt16[DS, 0x2570], 0x1AD6);
    State.IncCycles();
    // JNZ 0x1000:d6cf (1000_D6CA / 0x1D6CA)
    if(!ZeroFlag) {
      goto label_1000_D6CF_1D6CF;
    }
    State.IncCycles();
    // SUB CX,0x5 (1000_D6CC / 0x1D6CC)
    CX -= 0x5;
    State.IncCycles();
    label_1000_D6CF_1D6CF:
    // CMP byte ptr [0x46d9],0x0 (1000_D6CF / 0x1D6CF)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    State.IncCycles();
    // JZ 0x1000:d6dc (1000_D6D4 / 0x1D6D4)
    if(ZeroFlag) {
      goto label_1000_D6DC_1D6DC;
    }
    State.IncCycles();
    // MOV CX,0x5 (1000_D6D6 / 0x1D6D6)
    CX = 0x5;
    State.IncCycles();
    // MOV DI,0x1b48 (1000_D6D9 / 0x1D6D9)
    DI = 0x1B48;
    State.IncCycles();
    label_1000_D6DC_1D6DC:
    // CMP byte ptr [DI + 0x8],0x0 (1000_D6DC / 0x1D6DC)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    State.IncCycles();
    // JNS 0x1000:d6f7 (1000_D6E0 / 0x1D6E0)
    if(!SignFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI] (1000_D6E2 / 0x1D6E2)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JBE 0x1000:d6f7 (1000_D6E4 / 0x1D6E4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI + 0x4] (1000_D6E6 / 0x1D6E6)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JNC 0x1000:d6f7 (1000_D6E9 / 0x1D6E9)
    if(!CarryFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x2] (1000_D6EB / 0x1D6EB)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JBE 0x1000:d6f7 (1000_D6EE / 0x1D6EE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    State.IncCycles();
    // DEC BX (1000_D6F0 / 0x1D6F0)
    BX--;
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x6] (1000_D6F1 / 0x1D6F1)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // INC BX (1000_D6F4 / 0x1D6F4)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // JC 0x1000:d6fd (1000_D6F5 / 0x1D6F5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D6FD / 0x1D6FD)
      return NearRet();
    }
    State.IncCycles();
    label_1000_D6F7_1D6F7:
    // ADD DI,0xe (1000_D6F7 / 0x1D6F7)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    State.IncCycles();
    // LOOP 0x1000:d6dc (1000_D6FA / 0x1D6FA)
    if(--CX != 0) {
      goto label_1000_D6DC_1D6DC;
    }
    State.IncCycles();
    // CLC  (1000_D6FC / 0x1D6FC)
    CarryFlag = false;
    State.IncCycles();
    label_1000_D6FD_1D6FD:
    // RET  (1000_D6FD / 0x1D6FD)
    return NearRet();
  }
  
}
