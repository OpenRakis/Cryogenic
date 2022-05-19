namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_69B6_0169B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_69B6_169B6:
    // MOV BP,0x215a (1000_69B6 / 0x169B6)
    BP = 0x215A;
    // MOV AL,byte ptr [SI + 0x3] (1000_69B9 / 0x169B9)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_69BC / 0x169BC)
    AL &= 0xF;
    // CMP AL,0x2 (1000_69BE / 0x169BE)
    Alu.Sub8(AL, 0x2);
    // JZ 0x1000:6a07 (1000_69C0 / 0x169C0)
    if(ZeroFlag) {
      goto label_1000_6A07_16A07;
    }
    // CALL 0x1000:693b (1000_69C2 / 0x169C2)
    NearCall(cs1, 0x69C5, spice86_generated_label_call_target_1000_693B_01693B);
    // MOV BP,0x216e (1000_69C5 / 0x169C5)
    BP = 0x216E;
    // CMP AX,0x1 (1000_69C8 / 0x169C8)
    Alu.Sub16(AX, 0x1);
    // JC 0x1000:69f6 (1000_69CB / 0x169CB)
    if(CarryFlag) {
      goto label_1000_69F6_169F6;
    }
    // MOV BP,0x21a6 (1000_69CD / 0x169CD)
    BP = 0x21A6;
    // JNZ 0x1000:69f6 (1000_69D0 / 0x169D0)
    if(!ZeroFlag) {
      goto label_1000_69F6_169F6;
    }
    // MOV BP,0x2182 (1000_69D2 / 0x169D2)
    BP = 0x2182;
    // AND word ptr [0x2188],0xbfff (1000_69D5 / 0x169D5)
    UInt16[DS, 0x2188] &= 0xBFFF;
    // CMP word ptr [0xe2],0x1e (1000_69DB / 0x169DB)
    Alu.Sub16(UInt16[DS, 0xE2], 0x1E);
    // JC 0x1000:69e8 (1000_69E0 / 0x169E0)
    if(CarryFlag) {
      goto label_1000_69E8_169E8;
    }
    // OR word ptr [0x2188],0x4000 (1000_69E2 / 0x169E2)
    // UInt16[DS, 0x2188] |= 0x4000;
    UInt16[DS, 0x2188] = Alu.Or16(UInt16[DS, 0x2188], 0x4000);
    label_1000_69E8_169E8:
    // MOV AL,byte ptr [SI + 0x3] (1000_69E8 / 0x169E8)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_69EB / 0x169EB)
    AL &= 0xF;
    // CMP AL,0x5 (1000_69ED / 0x169ED)
    Alu.Sub8(AL, 0x5);
    // JNZ 0x1000:69f6 (1000_69EF / 0x169EF)
    if(!ZeroFlag) {
      goto label_1000_69F6_169F6;
    }
    // MOV BP,0x219a (1000_69F1 / 0x169F1)
    BP = 0x219A;
    // JMP 0x1000:6a25 (1000_69F4 / 0x169F4)
    goto label_1000_6A25_16A25;
    label_1000_69F6_169F6:
    // AND word ptr [BP + 0x2],0xbfff (1000_69F6 / 0x169F6)
    UInt16[SS, (ushort)(BP + 0x2)] &= 0xBFFF;
    // CMP byte ptr [0x2a],0x10 (1000_69FB / 0x169FB)
    Alu.Sub8(UInt8[DS, 0x2A], 0x10);
    // JNC 0x1000:6a07 (1000_6A00 / 0x16A00)
    if(!CarryFlag) {
      goto label_1000_6A07_16A07;
    }
    // OR word ptr [BP + 0x2],0x4000 (1000_6A02 / 0x16A02)
    // UInt16[SS, (ushort)(BP + 0x2)] |= 0x4000;
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Or16(UInt16[SS, (ushort)(BP + 0x2)], 0x4000);
    label_1000_6A07_16A07:
    // LEA BX,[BP + -0x2] (1000_6A07 / 0x16A07)
    BX = (ushort)(BP - 0x2);
    label_1000_6A0A_16A0A:
    // ADD BX,0x4 (1000_6A0A / 0x16A0A)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    // MOV AX,word ptr [BX] (1000_6A0D / 0x16A0D)
    AX = UInt16[DS, BX];
    // AND AX,0xfff (1000_6A0F / 0x16A0F)
    // AX &= 0xFFF;
    AX = Alu.And16(AX, 0xFFF);
    // JZ 0x1000:6a25 (1000_6A12 / 0x16A12)
    if(ZeroFlag) {
      goto label_1000_6A25_16A25;
    }
    // CMP AX,0x77 (1000_6A14 / 0x16A14)
    Alu.Sub16(AX, 0x77);
    // JNZ 0x1000:6a0a (1000_6A17 / 0x16A17)
    if(!ZeroFlag) {
      goto label_1000_6A0A_16A0A;
    }
    // TEST byte ptr [0xa],0x20 (1000_6A19 / 0x16A19)
    Alu.And8(UInt8[DS, 0xA], 0x20);
    // JNZ 0x1000:6a23 (1000_6A1E / 0x16A1E)
    if(!ZeroFlag) {
      goto label_1000_6A23_16A23;
    }
    // OR AX,0x4000 (1000_6A20 / 0x16A20)
    // AX |= 0x4000;
    AX = Alu.Or16(AX, 0x4000);
    label_1000_6A23_16A23:
    // MOV word ptr [BX],AX (1000_6A23 / 0x16A23)
    UInt16[DS, BX] = AX;
    label_1000_6A25_16A25:
    // MOV BX,0xf66 (1000_6A25 / 0x16A25)
    BX = 0xF66;
    // JMP 0x1000:d323 (1000_6A28 / 0x16A28)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6A71_016A71(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6A71_16A71:
    // CALL 0x1000:68eb (1000_6A71 / 0x16A71)
    NearCall(cs1, 0x6A74, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6A74_016A74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6A74_016A74(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6A74_16A74:
    // XOR CL,CL (1000_6A74 / 0x16A74)
    CL = 0;
    // CMP SI,0x8e0 (1000_6A76 / 0x16A76)
    Alu.Sub16(SI, 0x8E0);
    // JNZ 0x1000:6a89 (1000_6A7A / 0x16A7A)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_6A89_16A89, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // INC CX (1000_6A7C / 0x16A7C)
    CX = Alu.Inc16(CX);
    // CALL 0x1000:6a89 (1000_6A7D / 0x16A7D)
    NearCall(cs1, 0x6A80, spice86_label_1000_6A89_16A89);
    // JMP 0x1000:2ebf (1000_6A80 / 0x16A80)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2EBF_012EBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6A83_016A83(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6A83_16A83:
    // MOV CL,0x4 (1000_6A83 / 0x16A83)
    CL = 0x4;
    // JMP 0x1000:6a89 (1000_6A85 / 0x16A85)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_label_1000_6A89_16A89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_label_1000_6A89_16A89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6A89_16A89:
    // CALL 0x1000:68eb (1000_6A89 / 0x16A89)
    NearCall(cs1, 0x6A8C, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6A8C_016A8C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6A8C_016A8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6A8C_16A8C:
    // MOV AL,byte ptr [SI + 0x3] (1000_6A8C / 0x16A8C)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_6A8F / 0x16A8F)
    AL &= 0xF;
    // CMP AL,CL (1000_6A91 / 0x16A91)
    Alu.Sub8(AL, CL);
    // JZ 0x1000:6ab5 (1000_6A93 / 0x16A93)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH word ptr [SI + 0x3] (1000_6A95 / 0x16A95)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x3)]);
    // PUSH SI (1000_6A98 / 0x16A98)
    Stack.Push(SI);
    // PUSH word ptr [SI + 0x12] (1000_6A99 / 0x16A99)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x12)]);
    // CALL 0x1000:6acb (1000_6A9C / 0x16A9C)
    NearCall(cs1, 0x6A9F, spice86_generated_label_call_target_1000_6ACB_016ACB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6A9F_016A9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6A9F_016A9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6A9F_16A9F:
    // CALL 0x1000:a1c4 (1000_6A9F / 0x16A9F)
    NearCall(cs1, 0x6AA2, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AA2_016AA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AA2_016AA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AA2_16AA2:
    // MOV AL,0xa (1000_6AA2 / 0x16AA2)
    AL = 0xA;
    // CALL 0x1000:7bb9 (1000_6AA4 / 0x16AA4)
    NearCall(cs1, 0x6AA7, spice86_generated_label_call_target_1000_7BB9_017BB9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AA7_016AA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AA7_016AA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AA7_16AA7:
    // CALL 0x1000:a1e2 (1000_6AA7 / 0x16AA7)
    NearCall(cs1, 0x6AAA, spice86_generated_label_call_target_1000_A1E2_01A1E2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AAA_016AAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AAA_016AAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AAA_16AAA:
    // POP AX (1000_6AAA / 0x16AAA)
    AX = Stack.Pop();
    // POP SI (1000_6AAB / 0x16AAB)
    SI = Stack.Pop();
    // POP CX (1000_6AAC / 0x16AAC)
    CX = Stack.Pop();
    // JZ 0x1000:6ab8 (1000_6AAD / 0x16AAD)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_6AB8_016AB8, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV word ptr [SI + 0x12],AX (1000_6AAF / 0x16AAF)
    UInt16[DS, (ushort)(SI + 0x12)] = AX;
    // CALL 0x1000:6acb (1000_6AB2 / 0x16AB2)
    NearCall(cs1, 0x6AB5, spice86_generated_label_call_target_1000_6ACB_016ACB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AB5_016AB5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AB5_016AB5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AB5_16AB5:
    // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_6AB8_016AB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AB8_16AB8:
    // CALL 0x1000:693b (1000_6AB8 / 0x16AB8)
    NearCall(cs1, 0x6ABB, spice86_generated_label_call_target_1000_693B_01693B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6ABB_016ABB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6ABB_016ABB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6ABB_16ABB:
    // OR AL,AL (1000_6ABB / 0x16ABB)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:6ab5 (1000_6ABD / 0x16ABD)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [SI + 0x19],0x7f (1000_6ABF / 0x16ABF)
    // UInt8[DS, (ushort)(SI + 0x19)] &= 0x7F;
    UInt8[DS, (ushort)(SI + 0x19)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x7F);
    // JMP 0x1000:6ab5 (1000_6AC3 / 0x16AC3)
    // JMP target is JMP, inlining.
    // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6AC5_016AC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AC5_16AC5:
    // MOV CL,byte ptr [SI + 0x3] (1000_6AC5 / 0x16AC5)
    CL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND CL,0xfc (1000_6AC8 / 0x16AC8)
    // CL &= 0xFC;
    CL = Alu.And8(CL, 0xFC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6ACB_016ACB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6ACB_016ACB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6ACB_16ACB:
    // MOV AL,byte ptr [SI + 0x3] (1000_6ACB / 0x16ACB)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_6ACE / 0x16ACE)
    AL &= 0xF;
    // CMP AL,CL (1000_6AD0 / 0x16AD0)
    Alu.Sub8(AL, CL);
    // JZ 0x1000:6b24 (1000_6AD2 / 0x16AD2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6B24 / 0x16B24)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_6AD4_016AD4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6AD4_016AD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6AD4_16AD4:
    // MOV DI,word ptr [SI + 0x4] (1000_6AD4 / 0x16AD4)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP CL,0x8 (1000_6AD7 / 0x16AD7)
    Alu.Sub8(CL, 0x8);
    // JNZ 0x1000:6aea (1000_6ADA / 0x16ADA)
    if(!ZeroFlag) {
      goto label_1000_6AEA_16AEA;
    }
    // CMP DI,0x7c8 (1000_6ADC / 0x16ADC)
    Alu.Sub16(DI, 0x7C8);
    // JNZ 0x1000:6aea (1000_6AE0 / 0x16AE0)
    if(!ZeroFlag) {
      goto label_1000_6AEA_16AEA;
    }
    // CMP byte ptr [DI + 0x1a],0x0 (1000_6AE2 / 0x16AE2)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x1A)], 0x0);
    // JNZ 0x1000:6aea (1000_6AE6 / 0x16AE6)
    if(!ZeroFlag) {
      goto label_1000_6AEA_16AEA;
    }
    // MOV CL,0xa (1000_6AE8 / 0x16AE8)
    CL = 0xA;
    label_1000_6AEA_16AEA:
    // MOV byte ptr [SI + 0x3],CL (1000_6AEA / 0x16AEA)
    UInt8[DS, (ushort)(SI + 0x3)] = CL;
    // AND byte ptr [SI + 0x12],0xcf (1000_6AED / 0x16AED)
    UInt8[DS, (ushort)(SI + 0x12)] &= 0xCF;
    // AND word ptr [SI + 0x10],0xfeff (1000_6AF1 / 0x16AF1)
    // UInt16[DS, (ushort)(SI + 0x10)] &= 0xFEFF;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0xFEFF);
    // CALL 0x1000:6c15 (1000_6AF6 / 0x16AF6)
    NearCall(cs1, 0x6AF9, spice86_generated_label_call_target_1000_6C15_016C15);
    label_1000_6AF9_16AF9:
    // JC 0x1000:6b00 (1000_6AF9 / 0x16AF9)
    if(CarryFlag) {
      goto label_1000_6B00_16B00;
    }
    // OR word ptr [SI + 0x10],0x100 (1000_6AFB / 0x16AFB)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x100;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x100);
    label_1000_6B00_16B00:
    // CALL 0x1000:8461 (1000_6B00 / 0x16B00)
    NearCall(cs1, 0x6B03, spice86_generated_label_call_target_1000_8461_018461);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6B03_016B03, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6B03_016B03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6B03_16B03:
    // CALL 0x1000:6b25 (1000_6B03 / 0x16B03)
    NearCall(cs1, 0x6B06, spice86_generated_label_call_target_1000_6B25_016B25);
    label_1000_6B06_16B06:
    // CMP byte ptr [SI + 0x3],0x2 (1000_6B06 / 0x16B06)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x2);
    // JZ 0x1000:6b19 (1000_6B0A / 0x16B0A)
    if(ZeroFlag) {
      goto label_1000_6B19_16B19;
    }
    // CALL 0x1000:693b (1000_6B0C / 0x16B0C)
    NearCall(cs1, 0x6B0F, spice86_generated_label_call_target_1000_693B_01693B);
    label_1000_6B0F_16B0F:
    // MOV CL,AL (1000_6B0F / 0x16B0F)
    CL = AL;
    // MOV AX,0x2000 (1000_6B11 / 0x16B11)
    AX = 0x2000;
    // SHL AX,CL (1000_6B14 / 0x16B14)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    // OR word ptr [SI + 0x12],AX (1000_6B16 / 0x16B16)
    // UInt16[DS, (ushort)(SI + 0x12)] |= AX;
    UInt16[DS, (ushort)(SI + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x12)], AX);
    label_1000_6B19_16B19:
    // MOV AL,byte ptr [SI] (1000_6B19 / 0x16B19)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [0x1954] (1000_6B1B / 0x16B1B)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    // JNZ 0x1000:6b24 (1000_6B1F / 0x16B1F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6B24 / 0x16B24)
      return NearRet();
    }
    // CALL 0x1000:7847 (1000_6B21 / 0x16B21)
    NearCall(cs1, 0x6B24, spice86_generated_label_call_target_1000_7847_017847);
    label_1000_6B24_16B24:
    // RET  (1000_6B24 / 0x16B24)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6B25_016B25(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6B25_16B25:
    // MOV AX,[0x2] (1000_6B25 / 0x16B25)
    AX = UInt16[DS, 0x2];
    // MOV word ptr [SI + 0xa],AX (1000_6B28 / 0x16B28)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    // XOR AX,AX (1000_6B2B / 0x16B2B)
    AX = 0;
    // MOV word ptr [SI + 0xc],AX (1000_6B2D / 0x16B2D)
    UInt16[DS, (ushort)(SI + 0xC)] = AX;
    // MOV word ptr [SI + 0xe],AX (1000_6B30 / 0x16B30)
    UInt16[DS, (ushort)(SI + 0xE)] = AX;
    // RET  (1000_6B33 / 0x16B33)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6B34_016B34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6B34_16B34:
    // INC byte ptr [0x46f6] (1000_6B34 / 0x16B34)
    UInt8[DS, 0x46F6] = Alu.Inc8(UInt8[DS, 0x46F6]);
    // MOV AL,[0x46f6] (1000_6B38 / 0x16B38)
    AL = UInt8[DS, 0x46F6];
    // AND AL,0x3 (1000_6B3B / 0x16B3B)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    // JZ 0x1000:6b4b (1000_6B3D / 0x16B3D)
    if(ZeroFlag) {
      goto label_1000_6B4B_16B4B;
    }
    // MOV CX,0x1 (1000_6B3F / 0x16B3F)
    CX = 0x1;
    // MOV DI,word ptr [0x4752] (1000_6B42 / 0x16B42)
    DI = UInt16[DS, 0x4752];
    // OR DI,DI (1000_6B46 / 0x16B46)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:6b55 (1000_6B48 / 0x16B48)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6B55_016B55, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_6B4A / 0x16B4A)
    return NearRet();
    label_1000_6B4B_16B4B:
    // MOV SI,0x3cbe (1000_6B4B / 0x16B4B)
    SI = 0x3CBE;
    // LODSW SI (1000_6B4E / 0x16B4E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_6B4F / 0x16B4F)
    CX = AX;
    // JCXZ 0x1000:6b89 (1000_6B51 / 0x16B51)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_6B89 / 0x16B89)
      return NearRet();
    }
    // MOV DI,SI (1000_6B53 / 0x16B53)
    DI = SI;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6B55_016B55, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6B55_016B55(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x6B89: goto label_1000_6B89_16B89;break; // Target of external jump from 0x16B51
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_6B55_16B55:
    // TEST byte ptr [DI + 0xc],0x1 (1000_6B55 / 0x16B55)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x1);
    // JZ 0x1000:6b84 (1000_6B59 / 0x16B59)
    if(ZeroFlag) {
      goto label_1000_6B84_16B84;
    }
    // MOV SI,word ptr [DI + 0xd] (1000_6B5B / 0x16B5B)
    SI = UInt16[DS, (ushort)(DI + 0xD)];
    // LODSB SI (1000_6B5E / 0x16B5E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_6B5F / 0x16B5F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:6b6d (1000_6B61 / 0x16B61)
    if(!ZeroFlag) {
      goto label_1000_6B6D_16B6D;
    }
    // MOV SI,word ptr [DI + 0xf] (1000_6B63 / 0x16B63)
    SI = UInt16[DS, (ushort)(DI + 0xF)];
    // LODSB SI (1000_6B66 / 0x16B66)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST byte ptr [DI + 0xc],0x2 (1000_6B67 / 0x16B67)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x2);
    // JNZ 0x1000:6b84 (1000_6B6B / 0x16B6B)
    if(!ZeroFlag) {
      goto label_1000_6B84_16B84;
    }
    label_1000_6B6D_16B6D:
    // XOR AH,AH (1000_6B6D / 0x16B6D)
    AH = 0;
    // MOV word ptr [DI + 0x8],AX (1000_6B6F / 0x16B6F)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    // LODSB SI (1000_6B72 / 0x16B72)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_6B73 / 0x16B73)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_6B74 / 0x16B74)
    DX = AX;
    // LODSB SI (1000_6B76 / 0x16B76)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_6B77 / 0x16B77)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BX,AX (1000_6B78 / 0x16B78)
    BX = AX;
    // MOV word ptr [DI + 0xd],SI (1000_6B7A / 0x16B7A)
    UInt16[DS, (ushort)(DI + 0xD)] = SI;
    // PUSH CX (1000_6B7D / 0x16B7D)
    Stack.Push(CX);
    // PUSH DI (1000_6B7E / 0x16B7E)
    Stack.Push(DI);
    // CALL 0x1000:c661 (1000_6B7F / 0x16B7F)
    NearCall(cs1, 0x6B82, spice86_generated_label_call_target_1000_C661_01C661);
    label_1000_6B82_16B82:
    // POP DI (1000_6B82 / 0x16B82)
    DI = Stack.Pop();
    // POP CX (1000_6B83 / 0x16B83)
    CX = Stack.Pop();
    label_1000_6B84_16B84:
    // ADD DI,0x11 (1000_6B84 / 0x16B84)
    // DI += 0x11;
    DI = Alu.Add16(DI, 0x11);
    // LOOP 0x1000:6b55 (1000_6B87 / 0x16B87)
    if(--CX != 0) {
      goto label_1000_6B55_16B55;
    }
    label_1000_6B89_16B89:
    // RET  (1000_6B89 / 0x16B89)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6B96_016B96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6B96_16B96:
    // TEST word ptr [SI + 0x10],0x200 (1000_6B96 / 0x16B96)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    // STC  (1000_6B9B / 0x16B9B)
    CarryFlag = true;
    // JNZ 0x1000:6bb6 (1000_6B9C / 0x16B9C)
    if(!ZeroFlag) {
      goto label_1000_6BB6_16BB6;
    }
    // TEST word ptr [SI + 0x12],0x30 (1000_6B9E / 0x16B9E)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x30);
    // STC  (1000_6BA3 / 0x16BA3)
    CarryFlag = true;
    // JNZ 0x1000:6bb6 (1000_6BA4 / 0x16BA4)
    if(!ZeroFlag) {
      goto label_1000_6BB6_16BB6;
    }
    // CMP byte ptr [DI + 0x12],0x1 (1000_6BA6 / 0x16BA6)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x12)], 0x1);
    // JC 0x1000:6bb6 (1000_6BAA / 0x16BAA)
    if(CarryFlag) {
      goto label_1000_6BB6_16BB6;
    }
    // MOV AL,byte ptr [DI + 0xa] (1000_6BAC / 0x16BAC)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    // XOR AL,0x40 (1000_6BAF / 0x16BAF)
    AL ^= 0x40;
    // AND AL,0x41 (1000_6BB1 / 0x16BB1)
    // AL &= 0x41;
    AL = Alu.And8(AL, 0x41);
    // JZ 0x1000:6bb6 (1000_6BB3 / 0x16BB3)
    if(ZeroFlag) {
      goto label_1000_6BB6_16BB6;
    }
    // STC  (1000_6BB5 / 0x16BB5)
    CarryFlag = true;
    label_1000_6BB6_16BB6:
    // PUSHF  (1000_6BB6 / 0x16BB6)
    Stack.Push(FlagRegister);
    // SBB AH,AH (1000_6BB7 / 0x16BB7)
    AH = Alu.Sbb8(AH, AH);
    // MOV AL,byte ptr [SI + 0x3] (1000_6BB9 / 0x16BB9)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AX,0x1010 (1000_6BBC / 0x16BBC)
    AX &= 0x1010;
    // CMP AL,AH (1000_6BBF / 0x16BBF)
    Alu.Sub8(AL, AH);
    // JZ 0x1000:6bd5 (1000_6BC1 / 0x16BC1)
    if(ZeroFlag) {
      goto label_1000_6BD5_16BD5;
    }
    // XOR byte ptr [SI + 0x3],0x10 (1000_6BC3 / 0x16BC3)
    // UInt8[DS, (ushort)(SI + 0x3)] ^= 0x10;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Xor8(UInt8[DS, (ushort)(SI + 0x3)], 0x10);
    // PUSH AX (1000_6BC7 / 0x16BC7)
    Stack.Push(AX);
    // PUSH DI (1000_6BC8 / 0x16BC8)
    Stack.Push(DI);
    // CALL 0x1000:8461 (1000_6BC9 / 0x16BC9)
    NearCall(cs1, 0x6BCC, spice86_generated_label_call_target_1000_8461_018461);
    // POP DI (1000_6BCC / 0x16BCC)
    DI = Stack.Pop();
    // POP AX (1000_6BCD / 0x16BCD)
    AX = Stack.Pop();
    // TEST AL,0x10 (1000_6BCE / 0x16BCE)
    Alu.And8(AL, 0x10);
    // JZ 0x1000:6bd5 (1000_6BD0 / 0x16BD0)
    if(ZeroFlag) {
      goto label_1000_6BD5_16BD5;
    }
    // CALL 0x1000:6b25 (1000_6BD2 / 0x16BD2)
    NearCall(cs1, 0x6BD5, spice86_generated_label_call_target_1000_6B25_016B25);
    label_1000_6BD5_16BD5:
    // POPF  (1000_6BD5 / 0x16BD5)
    FlagRegister = Stack.Pop();
    // RET  (1000_6BD6 / 0x16BD6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6C15_016C15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6C15_16C15:
    // MOV DI,word ptr [SI + 0x4] (1000_6C15 / 0x16C15)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV BL,byte ptr [SI + 0x3] (1000_6C18 / 0x16C18)
    BL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND BX,0xf (1000_6C1B / 0x16C1B)
    BX &= 0xF;
    // SHL BX,1 (1000_6C1E / 0x16C1E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // CLC  (1000_6C20 / 0x16C20)
    CarryFlag = false;
    // JMP word ptr CS:[BX + 0x6bf5] (1000_6C21 / 0x16C21)
    // Indirect jump to word ptr CS:[BX + 0x6bf5], generating possible targets from emulator records
    uint targetAddress_1000_6C21 = (uint)(UInt16[cs1, (ushort)(BX + 0x6BF5)]);
    switch(targetAddress_1000_6C21) {
      case 0xF66 : {
        // JMP target is RET, inlining.
        // RET  (1000_0F66 / 0x10F66)
        return NearRet();
      }
      case 0x6B96 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6B96_016B96, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6C21));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6C46_016C46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6C46_16C46:
    // MOV AL,[0x2a] (1000_6C46 / 0x16C46)
    AL = UInt8[DS, 0x2A];
    // SUB AL,0x2d (1000_6C49 / 0x16C49)
    AL -= 0x2D;
    // CMP AL,0x3 (1000_6C4B / 0x16C4B)
    Alu.Sub8(AL, 0x3);
    // JNC 0x1000:6c6e (1000_6C4D / 0x16C4D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // TEST word ptr [0x10],0x10 (1000_6C4F / 0x16C4F)
    Alu.And16(UInt16[DS, 0x10], 0x10);
    // JNZ 0x1000:6c6e (1000_6C55 / 0x16C55)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // MOV DI,word ptr [0x473c] (1000_6C57 / 0x16C57)
    DI = UInt16[DS, 0x473C];
    // OR DI,DI (1000_6C5B / 0x16C5B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:6c6e (1000_6C5D / 0x16C5D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // CALL 0x1000:331e (1000_6C5F / 0x16C5F)
    NearCall(cs1, 0x6C62, spice86_generated_label_call_target_1000_331E_01331E);
    // CMP byte ptr [0x66],0x0 (1000_6C62 / 0x16C62)
    Alu.Sub8(UInt8[DS, 0x66], 0x0);
    // JZ 0x1000:6c6e (1000_6C67 / 0x16C67)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // MOV AL,0x30 (1000_6C69 / 0x16C69)
    AL = 0x30;
    // JMP 0x1000:121f (1000_6C6B / 0x16C6B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_121F_01121F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6C6E_16C6E:
    // RET  (1000_6C6E / 0x16C6E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6C6F_016C6F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6C6F_16C6F:
    // XOR SI,SI (1000_6C6F / 0x16C6F)
    SI = 0;
    // MOV AX,[0x101a] (1000_6C71 / 0x16C71)
    AX = UInt16[DS, 0x101A];
    // CMP AL,0x80 (1000_6C74 / 0x16C74)
    Alu.Sub8(AL, 0x80);
    // JNZ 0x1000:6c83 (1000_6C76 / 0x16C76)
    if(!ZeroFlag) {
      goto label_1000_6C83_16C83;
    }
    // MOV AL,0x1c (1000_6C78 / 0x16C78)
    AL = 0x1C;
    // DEC AH (1000_6C7A / 0x16C7A)
    AH--;
    // MUL AH (1000_6C7C / 0x16C7C)
    Cpu.Mul8(AH);
    // ADD AX,0x100 (1000_6C7E / 0x16C7E)
    // AX += 0x100;
    AX = Alu.Add16(AX, 0x100);
    // MOV SI,AX (1000_6C81 / 0x16C81)
    SI = AX;
    label_1000_6C83_16C83:
    // MOV word ptr [0x473c],SI (1000_6C83 / 0x16C83)
    UInt16[DS, 0x473C] = SI;
    // CALL 0x1000:6c46 (1000_6C87 / 0x16C87)
    NearCall(cs1, 0x6C8A, spice86_generated_label_call_target_1000_6C46_016C46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6C8A_016C8A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6C8A_016C8A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6C8A_16C8A:
    // MOV byte ptr [0x4737],0x0 (1000_6C8A / 0x16C8A)
    UInt8[DS, 0x4737] = 0x0;
    // MOV SI,0x8aa (1000_6C8F / 0x16C8F)
    SI = 0x8AA;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6C92_016C92, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6C92_016C92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6C92_16C92:
    // TEST word ptr [SI + 0x12],0x430 (1000_6C92 / 0x16C92)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x430);
    // JNZ 0x1000:6cd3 (1000_6C97 / 0x16C97)
    if(!ZeroFlag) {
      goto label_1000_6CD3_16CD3;
    }
    // CMP byte ptr [SI + 0x1a],0x14 (1000_6C99 / 0x16C99)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x14);
    // JNC 0x1000:6ca4 (1000_6C9D / 0x16C9D)
    if(!CarryFlag) {
      goto label_1000_6CA4_16CA4;
    }
    // CALL 0x1000:6d19 (1000_6C9F / 0x16C9F)
    NearCall(cs1, 0x6CA2, spice86_generated_label_call_target_1000_6D19_016D19);
    label_1000_6CA2_16CA2:
    // JC 0x1000:6cc3 (1000_6CA2 / 0x16CA2)
    if(CarryFlag) {
      goto label_1000_6CC3_16CC3;
    }
    label_1000_6CA4_16CA4:
    // MOV AL,byte ptr [SI + 0x3] (1000_6CA4 / 0x16CA4)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST AL,0xa0 (1000_6CA7 / 0x16CA7)
    Alu.And8(AL, 0xA0);
    // JNZ 0x1000:6cc3 (1000_6CA9 / 0x16CA9)
    if(!ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // TEST AL,0x40 (1000_6CAB / 0x16CAB)
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:6ced (1000_6CAD / 0x16CAD)
    if(!ZeroFlag) {
      goto label_1000_6CED_16CED;
    }
    // AND AX,0xf (1000_6CAF / 0x16CAF)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV BX,AX (1000_6CB2 / 0x16CB2)
    BX = AX;
    // SHL BX,1 (1000_6CB4 / 0x16CB4)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // PUSH SI (1000_6CB6 / 0x16CB6)
    Stack.Push(SI);
    // MOV DI,word ptr [SI + 0x4] (1000_6CB7 / 0x16CB7)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL word ptr CS:[BX + 0x6c26] (1000_6CBA / 0x16CBA)
    // Indirect call to word ptr CS:[BX + 0x6c26], generating possible targets from emulator records
    uint targetAddress_1000_6CBA = (uint)(UInt16[cs1, (ushort)(BX + 0x6C26)]);
    switch(targetAddress_1000_6CBA) {
      case 0xF66 : NearCall(cs1, 0x6CBF, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x6FE5 : NearCall(cs1, 0x6CBF, spice86_generated_label_call_target_1000_6FE5_016FE5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6CBA));
        break;
    }
    label_1000_6CBF_16CBF:
    // POP SI (1000_6CBF / 0x16CBF)
    SI = Stack.Pop();
    // CALL 0x1000:6d7b (1000_6CC0 / 0x16CC0)
    NearCall(cs1, 0x6CC3, spice86_generated_label_call_target_1000_6D7B_016D7B);
    label_1000_6CC3_16CC3:
    // ADD SI,0x1b (1000_6CC3 / 0x16CC3)
    SI += 0x1B;
    // CMP SI,0xfbb (1000_6CC6 / 0x16CC6)
    Alu.Sub16(SI, 0xFBB);
    // JC 0x1000:6c92 (1000_6CCA / 0x16CCA)
    if(CarryFlag) {
      goto label_1000_6C92_16C92;
    }
    // MOV AL,[0x4737] (1000_6CCC / 0x16CCC)
    AL = UInt8[DS, 0x4737];
    // MOV [0xfa],AL (1000_6CCF / 0x16CCF)
    UInt8[DS, 0xFA] = AL;
    // RET  (1000_6CD2 / 0x16CD2)
    return NearRet();
    label_1000_6CD3_16CD3:
    // TEST byte ptr [SI + 0x3],0x40 (1000_6CD3 / 0x16CD3)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:6ced (1000_6CD7 / 0x16CD7)
    if(!ZeroFlag) {
      goto label_1000_6CED_16CED;
    }
    // CMP byte ptr [0xfa],0x0 (1000_6CD9 / 0x16CD9)
    Alu.Sub8(UInt8[DS, 0xFA], 0x0);
    // JZ 0x1000:6cc3 (1000_6CDE / 0x16CDE)
    if(ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // AND byte ptr [SI + 0x12],0xcf (1000_6CE0 / 0x16CE0)
    UInt8[DS, (ushort)(SI + 0x12)] &= 0xCF;
    // TEST word ptr [SI + 0x12],0x400 (1000_6CE4 / 0x16CE4)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x400);
    // JNZ 0x1000:6cc3 (1000_6CE9 / 0x16CE9)
    if(!ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // JMP 0x1000:6c92 (1000_6CEB / 0x16CEB)
    goto label_1000_6C92_16C92;
    label_1000_6CED_16CED:
    // MOV AL,byte ptr [SI] (1000_6CED / 0x16CED)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [0x1954] (1000_6CEF / 0x16CEF)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    // JZ 0x1000:6cc3 (1000_6CF3 / 0x16CF3)
    if(ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // PUSH SI (1000_6CF5 / 0x16CF5)
    Stack.Push(SI);
    // CALL 0x1000:8308 (1000_6CF6 / 0x16CF6)
    NearCall(cs1, 0x6CF9, not_observed_1000_8308_018308);
    // POP SI (1000_6CF9 / 0x16CF9)
    SI = Stack.Pop();
    // JMP 0x1000:6cc3 (1000_6CFA / 0x16CFA)
    goto label_1000_6CC3_16CC3;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6CFC_016CFC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6CFC_16CFC:
    // CMP byte ptr [DI + 0x8],0x20 (1000_6CFC / 0x16CFC)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x20);
    // JNC 0x1000:6d18 (1000_6D00 / 0x16D00)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6D18 / 0x16D18)
      return NearRet();
    }
    // CMP byte ptr [DI + 0xb],0xc (1000_6D02 / 0x16D02)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0xB)], 0xC);
    // JNC 0x1000:6d18 (1000_6D06 / 0x16D06)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6D18 / 0x16D18)
      return NearRet();
    }
    // TEST byte ptr [DI + 0xa],0x1 (1000_6D08 / 0x16D08)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x1);
    // JNZ 0x1000:6d18 (1000_6D0C / 0x16D0C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6D18 / 0x16D18)
      return NearRet();
    }
    // INC byte ptr [DI + 0xb] (1000_6D0E / 0x16D0E)
    UInt8[DS, (ushort)(DI + 0xB)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0xB)]);
    // PUSH SI (1000_6D11 / 0x16D11)
    Stack.Push(SI);
    // PUSH DI (1000_6D12 / 0x16D12)
    Stack.Push(DI);
    // CALL 0x1000:644e (1000_6D13 / 0x16D13)
    NearCall(cs1, 0x6D16, spice86_generated_label_call_target_1000_644E_01644E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6D16_016D16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6D16_016D16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6D16_16D16:
    // POP DI (1000_6D16 / 0x16D16)
    DI = Stack.Pop();
    // POP SI (1000_6D17 / 0x16D17)
    SI = Stack.Pop();
    label_1000_6D18_16D18:
    // RET  (1000_6D18 / 0x16D18)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6D19_016D19(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6D19_16D19:
    // TEST byte ptr [SI + 0x3],0xe3 (1000_6D19 / 0x16D19)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xE3);
    // JNZ 0x1000:6d5e (1000_6D1D / 0x16D1D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_6D1F / 0x16D1F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:6d5e (1000_6D23 / 0x16D23)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // CMP SI,0x8e0 (1000_6D25 / 0x16D25)
    Alu.Sub16(SI, 0x8E0);
    // JZ 0x1000:6d5e (1000_6D29 / 0x16D29)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // MOV DI,word ptr [SI + 0x4] (1000_6D2B / 0x16D2B)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // XOR BX,BX (1000_6D2E / 0x16D2E)
    BX = 0;
    // MOV CL,byte ptr [SI + 0x1a] (1000_6D30 / 0x16D30)
    CL = UInt8[DS, (ushort)(SI + 0x1A)];
    // NOT CL (1000_6D33 / 0x16D33)
    CL = (byte)~CL;
    // MOV DX,SI (1000_6D35 / 0x16D35)
    DX = SI;
    // MOV BP,0x6d5f (1000_6D37 / 0x16D37)
    BP = 0x6D5F;
    // CALL 0x1000:661d (1000_6D3A / 0x16D3A)
    NearCall(cs1, 0x6D3D, spice86_generated_label_call_target_1000_661D_01661D);
    // OR BX,BX (1000_6D3D / 0x16D3D)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:6d5e (1000_6D3F / 0x16D3F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x1a] (1000_6D41 / 0x16D41)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    // ADD byte ptr [BX + 0x1a],AL (1000_6D44 / 0x16D44)
    // UInt8[DS, (ushort)(BX + 0x1A)] += AL;
    UInt8[DS, (ushort)(BX + 0x1A)] = Alu.Add8(UInt8[DS, (ushort)(BX + 0x1A)], AL);
    // MOV AL,byte ptr [SI + 0x19] (1000_6D47 / 0x16D47)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // MOV AH,AL (1000_6D4A / 0x16D4A)
    AH = AL;
    // AND AL,byte ptr [BX + 0x19] (1000_6D4C / 0x16D4C)
    // AL &= UInt8[DS, (ushort)(BX + 0x19)];
    AL = Alu.And8(AL, UInt8[DS, (ushort)(BX + 0x19)]);
    // MOV byte ptr [SI + 0x19],AL (1000_6D4F / 0x16D4F)
    UInt8[DS, (ushort)(SI + 0x19)] = AL;
    // OR byte ptr [BX + 0x19],AH (1000_6D52 / 0x16D52)
    // UInt8[DS, (ushort)(BX + 0x19)] |= AH;
    UInt8[DS, (ushort)(BX + 0x19)] = Alu.Or8(UInt8[DS, (ushort)(BX + 0x19)], AH);
    // OR word ptr [BX + 0x12],0x200 (1000_6D55 / 0x16D55)
    // UInt16[DS, (ushort)(BX + 0x12)] |= 0x200;
    UInt16[DS, (ushort)(BX + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(BX + 0x12)], 0x200);
    // CALL 0x1000:66b1 (1000_6D5A / 0x16D5A)
    NearCall(cs1, 0x6D5D, not_observed_1000_66B1_0166B1);
    // STC  (1000_6D5D / 0x16D5D)
    CarryFlag = true;
    label_1000_6D5E_16D5E:
    // RET  (1000_6D5E / 0x16D5E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6D7B_016D7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6D7B_16D7B:
    // TEST word ptr [0x2],0x3f (1000_6D7B / 0x16D7B)
    Alu.And16(UInt16[DS, 0x2], 0x3F);
    // JZ 0x1000:6d84 (1000_6D81 / 0x16D81)
    if(ZeroFlag) {
      goto label_1000_6D84_16D84;
    }
    // RET  (1000_6D83 / 0x16D83)
    return NearRet();
    label_1000_6D84_16D84:
    // CALL 0x1000:693b (1000_6D84 / 0x16D84)
    NearCall(cs1, 0x6D87, spice86_generated_label_call_target_1000_693B_01693B);
    // MOV CL,AL (1000_6D87 / 0x16D87)
    CL = AL;
    // MOV AX,0xc000 (1000_6D89 / 0x16D89)
    AX = 0xC000;
    // ROL AX,CL (1000_6D8C / 0x16D8C)
    AX = Alu.Rol16(AX, CL);
    // AND AX,word ptr [SI + 0x12] (1000_6D8E / 0x16D8E)
    // AX &= UInt16[DS, (ushort)(SI + 0x12)];
    AX = Alu.And16(AX, UInt16[DS, (ushort)(SI + 0x12)]);
    // JZ 0x1000:6dba (1000_6D91 / 0x16D91)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6DBA / 0x16DBA)
      return NearRet();
    }
    // SHL AX,1 (1000_6D93 / 0x16D93)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // JNC 0x1000:6da0 (1000_6D95 / 0x16D95)
    if(!CarryFlag) {
      goto label_1000_6DA0_16DA0;
    }
    // CMP byte ptr [SI + 0x18],0x0 (1000_6D97 / 0x16D97)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x18)], 0x0);
    // JZ 0x1000:6da0 (1000_6D9B / 0x16D9B)
    if(ZeroFlag) {
      goto label_1000_6DA0_16DA0;
    }
    // DEC byte ptr [SI + 0x18] (1000_6D9D / 0x16D9D)
    UInt8[DS, (ushort)(SI + 0x18)]--;
    label_1000_6DA0_16DA0:
    // SHL AX,1 (1000_6DA0 / 0x16DA0)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // JNC 0x1000:6dad (1000_6DA2 / 0x16DA2)
    if(!CarryFlag) {
      goto label_1000_6DAD_16DAD;
    }
    // CMP byte ptr [SI + 0x17],0x0 (1000_6DA4 / 0x16DA4)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x17)], 0x0);
    // JZ 0x1000:6dad (1000_6DA8 / 0x16DA8)
    if(ZeroFlag) {
      goto label_1000_6DAD_16DAD;
    }
    // DEC byte ptr [SI + 0x17] (1000_6DAA / 0x16DAA)
    UInt8[DS, (ushort)(SI + 0x17)]--;
    label_1000_6DAD_16DAD:
    // SHL AX,1 (1000_6DAD / 0x16DAD)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // JNC 0x1000:6dba (1000_6DAF / 0x16DAF)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6DBA / 0x16DBA)
      return NearRet();
    }
    // CMP byte ptr [SI + 0x16],0x0 (1000_6DB1 / 0x16DB1)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x16)], 0x0);
    // JZ 0x1000:6dba (1000_6DB5 / 0x16DB5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6DBA / 0x16DBA)
      return NearRet();
    }
    // DEC byte ptr [SI + 0x16] (1000_6DB7 / 0x16DB7)
    UInt8[DS, (ushort)(SI + 0x16)] = Alu.Dec8(UInt8[DS, (ushort)(SI + 0x16)]);
    label_1000_6DBA_16DBA:
    // RET  (1000_6DBA / 0x16DBA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6DBB_016DBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6DBB_16DBB:
    // PUSH SI (1000_6DBB / 0x16DBB)
    Stack.Push(SI);
    // CALL 0x1000:40ae (1000_6DBC / 0x16DBC)
    NearCall(cs1, 0x6DBF, spice86_generated_label_call_target_1000_40AE_0140AE);
    // MOV SI,0xfd8 (1000_6DBF / 0x16DBF)
    SI = 0xFD8;
    // MOV CX,0xc (1000_6DC2 / 0x16DC2)
    CX = 0xC;
    label_1000_6DC5_16DC5:
    // CMP BX,word ptr [SI + 0x2] (1000_6DC5 / 0x16DC5)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:6dd6 (1000_6DC8 / 0x16DC8)
    if(!ZeroFlag) {
      goto label_1000_6DD6_16DD6;
    }
    // MOV AX,word ptr [SI] (1000_6DCA / 0x16DCA)
    AX = UInt16[DS, SI];
    // MOV AH,DH (1000_6DCC / 0x16DCC)
    AH = DH;
    // CMP AL,0x1 (1000_6DCE / 0x16DCE)
    Alu.Sub8(AL, 0x1);
    // JZ 0x1000:6dd4 (1000_6DD0 / 0x16DD0)
    if(ZeroFlag) {
      goto label_1000_6DD4_16DD4;
    }
    // MOV AL,0x2 (1000_6DD2 / 0x16DD2)
    AL = 0x2;
    label_1000_6DD4_16DD4:
    // MOV word ptr [SI],AX (1000_6DD4 / 0x16DD4)
    UInt16[DS, SI] = AX;
    label_1000_6DD6_16DD6:
    // ADD SI,0x10 (1000_6DD6 / 0x16DD6)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:6dc5 (1000_6DD9 / 0x16DD9)
    if(--CX != 0) {
      goto label_1000_6DC5_16DC5;
    }
    // CMP BX,word ptr [0x6] (1000_6DDB / 0x16DDB)
    Alu.Sub16(BX, UInt16[DS, 0x6]);
    // JNZ 0x1000:6dfb (1000_6DDF / 0x16DDF)
    if(!ZeroFlag) {
      goto label_1000_6DFB_16DFB;
    }
    // OR byte ptr [0x473b],0x80 (1000_6DE1 / 0x16DE1)
    // UInt8[DS, 0x473B] |= 0x80;
    UInt8[DS, 0x473B] = Alu.Or8(UInt8[DS, 0x473B], 0x80);
    // MOV AX,[0x4] (1000_6DE6 / 0x16DE6)
    AX = UInt16[DS, 0x4];
    // MOV AH,DH (1000_6DE9 / 0x16DE9)
    AH = DH;
    // CMP AL,0x1 (1000_6DEB / 0x16DEB)
    Alu.Sub8(AL, 0x1);
    // JZ 0x1000:6df1 (1000_6DED / 0x16DED)
    if(ZeroFlag) {
      goto label_1000_6DF1_16DF1;
    }
    // MOV AL,0x2 (1000_6DEF / 0x16DEF)
    AL = 0x2;
    label_1000_6DF1_16DF1:
    // MOV [0x4],AX (1000_6DF1 / 0x16DF1)
    UInt16[DS, 0x4] = AX;
    // MOV [0xb],AL (1000_6DF4 / 0x16DF4)
    UInt8[DS, 0xB] = AL;
    // MOV byte ptr [0x8],AH (1000_6DF7 / 0x16DF7)
    UInt8[DS, 0x8] = AH;
    label_1000_6DFB_16DFB:
    // POP SI (1000_6DFB / 0x16DFB)
    SI = Stack.Pop();
    // MOV BP,0x6e0f (1000_6DFC / 0x16DFC)
    BP = 0x6E0F;
    // CALL 0x1000:6603 (1000_6DFF / 0x16DFF)
    NearCall(cs1, 0x6E02, spice86_generated_label_call_target_1000_6603_016603);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_6E02_016E02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6E02_016E02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6E02_16E02:
    // XOR CX,CX (1000_6E02 / 0x16E02)
    CX = 0;
    // MOV BP,0x764d (1000_6E04 / 0x16E04)
    BP = 0x764D;
    // CALL 0x1000:6603 (1000_6E07 / 0x16E07)
    NearCall(cs1, 0x6E0A, spice86_generated_label_call_target_1000_6603_016603);
    // OR CX,CX (1000_6E0A / 0x16E0A)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JNZ 0x1000:6e02 (1000_6E0C / 0x16E0C)
    if(!ZeroFlag) {
      goto label_1000_6E02_16E02;
    }
    // RET  (1000_6E0E / 0x16E0E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6E20_016E20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6E20_16E20:
    // CMP byte ptr [0x46de],0x0 (1000_6E20 / 0x16E20)
    Alu.Sub8(UInt8[DS, 0x46DE], 0x0);
    // JNZ 0x1000:6e28 (1000_6E25 / 0x16E25)
    if(!ZeroFlag) {
      goto label_1000_6E28_16E28;
    }
    // RET  (1000_6E27 / 0x16E27)
    return NearRet();
    label_1000_6E28_16E28:
    // TEST byte ptr [DI + 0xa],0x8 (1000_6E28 / 0x16E28)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    // JZ 0x1000:6e4b (1000_6E2C / 0x16E2C)
    if(ZeroFlag) {
      goto label_1000_6E4B_16E4B;
    }
    // CALL 0x1000:1ac5 (1000_6E2E / 0x16E2E)
    NearCall(cs1, 0x6E31, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // SUB AL,byte ptr [DI + 0xb] (1000_6E31 / 0x16E31)
    AL -= UInt8[DS, (ushort)(DI + 0xB)];
    // CMP AL,0xfe (1000_6E34 / 0x16E34)
    Alu.Sub8(AL, 0xFE);
    // JNC 0x1000:6e81 (1000_6E36 / 0x16E36)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6E81 / 0x16E81)
      return NearRet();
    }
    // AND byte ptr [DI + 0xa],0xf7 (1000_6E38 / 0x16E38)
    UInt8[DS, (ushort)(DI + 0xA)] &= 0xF7;
    // AND byte ptr [DI + 0x8],0x7 (1000_6E3C / 0x16E3C)
    UInt8[DS, (ushort)(DI + 0x8)] &= 0x7;
    // INC byte ptr [0x27] (1000_6E40 / 0x16E40)
    UInt8[DS, 0x27] = Alu.Inc8(UInt8[DS, 0x27]);
    // CALL 0x1000:6dbb (1000_6E44 / 0x16E44)
    NearCall(cs1, 0x6E47, not_observed_1000_6DBB_016DBB);
    // MOV byte ptr [DI + 0xb],0x5 (1000_6E47 / 0x16E47)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x5;
    label_1000_6E4B_16E4B:
    // CALL 0x1000:6cfc (1000_6E4B / 0x16E4B)
    NearCall(cs1, 0x6E4E, spice86_generated_label_call_target_1000_6CFC_016CFC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6E4E_016E4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6E4E_016E4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6E4E_16E4E:
    // CALL 0x1000:1ac5 (1000_6E4E / 0x16E4E)
    NearCall(cs1, 0x6E51, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6E51_016E51, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6E51_016E51(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6E51_16E51:
    // SUB AL,byte ptr [SI + 0x14] (1000_6E51 / 0x16E51)
    AL -= UInt8[DS, (ushort)(SI + 0x14)];
    // CMP AL,0x8 (1000_6E54 / 0x16E54)
    Alu.Sub8(AL, 0x8);
    // JBE 0x1000:6e5d (1000_6E56 / 0x16E56)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6E5D_16E5D;
    }
    // MOV AL,0x1 (1000_6E58 / 0x16E58)
    AL = 0x1;
    // CALL 0x1000:6f93 (1000_6E5A / 0x16E5A)
    NearCall(cs1, 0x6E5D, not_observed_1000_6F93_016F93);
    label_1000_6E5D_16E5D:
    // MOV AL,byte ptr [SI] (1000_6E5D / 0x16E5D)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [DI + 0x9] (1000_6E5F / 0x16E5F)
    Alu.Sub8(AL, UInt8[DS, (ushort)(DI + 0x9)]);
    // JNZ 0x1000:6e81 (1000_6E62 / 0x16E62)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6E81 / 0x16E81)
      return NearRet();
    }
    // XOR DX,DX (1000_6E64 / 0x16E64)
    DX = 0;
    // MOV BP,0x6e82 (1000_6E66 / 0x16E66)
    BP = 0x6E82;
    // CALL 0x1000:661d (1000_6E69 / 0x16E69)
    NearCall(cs1, 0x6E6C, spice86_generated_label_call_target_1000_661D_01661D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6E6C_016E6C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6E6C_016E6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6E6C_16E6C:
    // CMP DL,0x3 (1000_6E6C / 0x16E6C)
    Alu.Sub8(DL, 0x3);
    // JNZ 0x1000:6e81 (1000_6E6F / 0x16E6F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6E81 / 0x16E81)
      return NearRet();
    }
    // MOV BP,0x6ea8 (1000_6E71 / 0x16E71)
    BP = 0x6EA8;
    // CALL 0x1000:661d (1000_6E74 / 0x16E74)
    NearCall(cs1, 0x6E77, spice86_generated_label_call_target_1000_661D_01661D);
    // MOV AX,0x302 (1000_6E77 / 0x16E77)
    AX = 0x302;
    // PUSH SI (1000_6E7A / 0x16E7A)
    Stack.Push(SI);
    // PUSH DI (1000_6E7B / 0x16E7B)
    Stack.Push(DI);
    // CALL 0x1000:29f0 (1000_6E7C / 0x16E7C)
    NearCall(cs1, 0x6E7F, not_observed_1000_29F0_0129F0);
    // POP DI (1000_6E7F / 0x16E7F)
    DI = Stack.Pop();
    // POP SI (1000_6E80 / 0x16E80)
    SI = Stack.Pop();
    label_1000_6E81_16E81:
    // RET  (1000_6E81 / 0x16E81)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6E82_016E82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6E82_16E82:
    // CMP DI,word ptr [0x114e] (1000_6E82 / 0x16E82)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JZ 0x1000:6ea7 (1000_6E86 / 0x16E86)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    // CMP byte ptr [DI + 0x8],0x21 (1000_6E88 / 0x16E88)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x21);
    // JNC 0x1000:6ea7 (1000_6E8C / 0x16E8C)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    // CMP byte ptr [SI + 0x15],0x28 (1000_6E8E / 0x16E8E)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], 0x28);
    // JNC 0x1000:6ea7 (1000_6E92 / 0x16E92)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_6E94 / 0x16E94)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0x2f (1000_6E97 / 0x16E97)
    // AL &= 0x2F;
    AL = Alu.And8(AL, 0x2F);
    // JNZ 0x1000:6ea7 (1000_6E99 / 0x16E99)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    // MOV DH,0x1 (1000_6E9B / 0x16E9B)
    DH = 0x1;
    // TEST byte ptr [SI + 0x12],0x80 (1000_6E9D / 0x16E9D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x12)], 0x80);
    // JZ 0x1000:6ea5 (1000_6EA1 / 0x16EA1)
    if(ZeroFlag) {
      goto label_1000_6EA5_16EA5;
    }
    // SHL DH,1 (1000_6EA3 / 0x16EA3)
    // DH <<= 0x1;
    DH = Alu.Shl8(DH, 0x1);
    label_1000_6EA5_16EA5:
    // OR DL,DH (1000_6EA5 / 0x16EA5)
    // DL |= DH;
    DL = Alu.Or8(DL, DH);
    label_1000_6EA7_16EA7:
    // RET  (1000_6EA7 / 0x16EA7)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6EBF_016EBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6EBF_16EBF:
    // PUSH DI (1000_6EBF / 0x16EBF)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_6EC0 / 0x16EC0)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV BP,0x6ecb (1000_6EC3 / 0x16EC3)
    BP = 0x6ECB;
    // CALL 0x1000:661d (1000_6EC6 / 0x16EC6)
    NearCall(cs1, 0x6EC9, spice86_generated_label_call_target_1000_661D_01661D);
    // POP DI (1000_6EC9 / 0x16EC9)
    DI = Stack.Pop();
    // RET  (1000_6ECA / 0x16ECA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6EDD_016EDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6EDD_16EDD:
    // MOV DL,byte ptr [BX + SI + 0x16] (1000_6EDD / 0x16EDD)
    DL = UInt8[DS, (ushort)(BX + SI + 0x16)];
    // ADD AL,DL (1000_6EE0 / 0x16EE0)
    AL += DL;
    // CMP AL,0x5f (1000_6EE2 / 0x16EE2)
    Alu.Sub8(AL, 0x5F);
    // JBE 0x1000:6ee8 (1000_6EE4 / 0x16EE4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6EE8_16EE8;
    }
    // MOV AL,0x5f (1000_6EE6 / 0x16EE6)
    AL = 0x5F;
    label_1000_6EE8_16EE8:
    // MOV byte ptr [BX + SI + 0x16],AL (1000_6EE8 / 0x16EE8)
    UInt8[DS, (ushort)(BX + SI + 0x16)] = AL;
    // XOR AL,DL (1000_6EEB / 0x16EEB)
    AL ^= DL;
    // AND AL,0xf0 (1000_6EED / 0x16EED)
    // AL &= 0xF0;
    AL = Alu.And8(AL, 0xF0);
    // JZ 0x1000:6efc (1000_6EEF / 0x16EEF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6EFC / 0x16EFC)
      return NearRet();
    }
    // MOV AX,word ptr [SI + 0x10] (1000_6EF1 / 0x16EF1)
    AX = UInt16[DS, (ushort)(SI + 0x10)];
    // AND AL,0xfc (1000_6EF4 / 0x16EF4)
    AL &= 0xFC;
    // INC BX (1000_6EF6 / 0x16EF6)
    BX = Alu.Inc16(BX);
    // OR AL,BL (1000_6EF7 / 0x16EF7)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    // MOV word ptr [SI + 0x10],AX (1000_6EF9 / 0x16EF9)
    UInt16[DS, (ushort)(SI + 0x10)] = AX;
    label_1000_6EFC_16EFC:
    // RET  (1000_6EFC / 0x16EFC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6EFD_016EFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6EFD_16EFD:
    // MOV AH,byte ptr [SI + 0x3] (1000_6EFD / 0x16EFD)
    AH = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AH,0xf (1000_6F00 / 0x16F00)
    // AH &= 0xF;
    AH = Alu.And8(AH, 0xF);
    // MOV AL,byte ptr [SI + 0x15] (1000_6F03 / 0x16F03)
    AL = UInt8[DS, (ushort)(SI + 0x15)];
    // CMP byte ptr [0xfa],0x0 (1000_6F06 / 0x16F06)
    Alu.Sub8(UInt8[DS, 0xFA], 0x0);
    // JZ 0x1000:6f0f (1000_6F0B / 0x16F0B)
    if(ZeroFlag) {
      goto label_1000_6F0F_16F0F;
    }
    // ADD AL,0x14 (1000_6F0D / 0x16F0D)
    AL += 0x14;
    label_1000_6F0F_16F0F:
    // CMP AH,0x6 (1000_6F0F / 0x16F0F)
    Alu.Sub8(AH, 0x6);
    // JNZ 0x1000:6f23 (1000_6F12 / 0x16F12)
    if(!ZeroFlag) {
      goto label_1000_6F23_16F23;
    }
    // PUSH DI (1000_6F14 / 0x16F14)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_6F15 / 0x16F15)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP DI,word ptr [0x114e] (1000_6F18 / 0x16F18)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // POP DI (1000_6F1C / 0x16F1C)
    DI = Stack.Pop();
    // JNZ 0x1000:6f31 (1000_6F1D / 0x16F1D)
    if(!ZeroFlag) {
      goto label_1000_6F31_16F31;
    }
    // ADD AL,0x1e (1000_6F1F / 0x16F1F)
    // AL += 0x1E;
    AL = Alu.Add8(AL, 0x1E);
    // JMP 0x1000:6f2b (1000_6F21 / 0x16F21)
    goto label_1000_6F2B_16F2B;
    label_1000_6F23_16F23:
    // AND AH,0xfe (1000_6F23 / 0x16F23)
    AH &= 0xFE;
    // CMP AH,0x8 (1000_6F26 / 0x16F26)
    Alu.Sub8(AH, 0x8);
    // JZ 0x1000:6f2f (1000_6F29 / 0x16F29)
    if(ZeroFlag) {
      goto label_1000_6F2F_16F2F;
    }
    label_1000_6F2B_16F2B:
    // CMP AL,0x64 (1000_6F2B / 0x16F2B)
    Alu.Sub8(AL, 0x64);
    // JC 0x1000:6f31 (1000_6F2D / 0x16F2D)
    if(CarryFlag) {
      goto label_1000_6F31_16F31;
    }
    label_1000_6F2F_16F2F:
    // MOV AL,0x64 (1000_6F2F / 0x16F2F)
    AL = 0x64;
    label_1000_6F31_16F31:
    // CMP byte ptr [0x2a],0x64 (1000_6F31 / 0x16F31)
    Alu.Sub8(UInt8[DS, 0x2A], 0x64);
    // JC 0x1000:6f47 (1000_6F36 / 0x16F36)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    // CMP byte ptr [0x2a],0x68 (1000_6F38 / 0x16F38)
    Alu.Sub8(UInt8[DS, 0x2A], 0x68);
    // JNC 0x1000:6f47 (1000_6F3D / 0x16F3D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    // SUB AL,0x28 (1000_6F3F / 0x16F3F)
    AL -= 0x28;
    // CMP AL,0xa (1000_6F41 / 0x16F41)
    Alu.Sub8(AL, 0xA);
    // JGE 0x1000:6f47 (1000_6F43 / 0x16F43)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    // MOV AL,0xa (1000_6F45 / 0x16F45)
    AL = 0xA;
    label_1000_6F47_16F47:
    // RET  (1000_6F47 / 0x16F47)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6F56_016F56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6F56_16F56:
    // PUSH SI (1000_6F56 / 0x16F56)
    Stack.Push(SI);
    // MOV SI,0x8aa (1000_6F57 / 0x16F57)
    SI = 0x8AA;
    label_1000_6F5A_16F5A:
    // TEST byte ptr [SI + 0x3],0xa0 (1000_6F5A / 0x16F5A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xA0);
    // JNZ 0x1000:6f6d (1000_6F5E / 0x16F5E)
    if(!ZeroFlag) {
      goto label_1000_6F6D_16F6D;
    }
    // ADD byte ptr [SI + 0x15],AL (1000_6F60 / 0x16F60)
    UInt8[DS, (ushort)(SI + 0x15)] += AL;
    // CMP byte ptr [SI + 0x15],0x64 (1000_6F63 / 0x16F63)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], 0x64);
    // JBE 0x1000:6f6d (1000_6F67 / 0x16F67)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6F6D_16F6D;
    }
    // MOV byte ptr [SI + 0x15],0x64 (1000_6F69 / 0x16F69)
    UInt8[DS, (ushort)(SI + 0x15)] = 0x64;
    label_1000_6F6D_16F6D:
    // ADD SI,0x1b (1000_6F6D / 0x16F6D)
    SI += 0x1B;
    // CMP SI,0xfbb (1000_6F70 / 0x16F70)
    Alu.Sub16(SI, 0xFBB);
    // JC 0x1000:6f5a (1000_6F74 / 0x16F74)
    if(CarryFlag) {
      goto label_1000_6F5A_16F5A;
    }
    // POP SI (1000_6F76 / 0x16F76)
    SI = Stack.Pop();
    // RET  (1000_6F77 / 0x16F77)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6F78_016F78(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6F78_16F78:
    // MOV AH,byte ptr [0x29] (1000_6F78 / 0x16F78)
    AH = UInt8[DS, 0x29];
    // ADD AL,AH (1000_6F7C / 0x16F7C)
    AL += AH;
    // CMP AL,0xc8 (1000_6F7E / 0x16F7E)
    Alu.Sub8(AL, 0xC8);
    // JBE 0x1000:6f84 (1000_6F80 / 0x16F80)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6F84_16F84;
    }
    // MOV AL,0xc8 (1000_6F82 / 0x16F82)
    AL = 0xC8;
    label_1000_6F84_16F84:
    // MOV [0x29],AL (1000_6F84 / 0x16F84)
    UInt8[DS, 0x29] = AL;
    // AND AX,0xfcfc (1000_6F87 / 0x16F87)
    AX &= 0xFCFC;
    // SUB AL,AH (1000_6F8A / 0x16F8A)
    AL -= AH;
    // SHR AL,1 (1000_6F8C / 0x16F8C)
    AL >>= 0x1;
    // SHR AL,1 (1000_6F8E / 0x16F8E)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNZ 0x1000:6f56 (1000_6F90 / 0x16F90)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_6F56_016F56, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_6F92 / 0x16F92)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6F93_016F93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6F93_16F93:
    // SUB byte ptr [SI + 0x15],AL (1000_6F93 / 0x16F93)
    // UInt8[DS, (ushort)(SI + 0x15)] -= AL;
    UInt8[DS, (ushort)(SI + 0x15)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], AL);
    // JNC 0x1000:6f9c (1000_6F96 / 0x16F96)
    if(!CarryFlag) {
      goto label_1000_6F9C_16F9C;
    }
    // MOV byte ptr [SI + 0x15],0x0 (1000_6F98 / 0x16F98)
    UInt8[DS, (ushort)(SI + 0x15)] = 0x0;
    label_1000_6F9C_16F9C:
    // CMP byte ptr [SI + 0x15],0x5 (1000_6F9C / 0x16F9C)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], 0x5);
    // JNC 0x1000:6faf (1000_6FA0 / 0x16FA0)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6FAF / 0x16FAF)
      return NearRet();
    }
    // MOV byte ptr [SI + 0x15],0x4 (1000_6FA2 / 0x16FA2)
    UInt8[DS, (ushort)(SI + 0x15)] = 0x4;
    // PUSH AX (1000_6FA6 / 0x16FA6)
    Stack.Push(AX);
    // CALL 0x1000:7085 (1000_6FA7 / 0x16FA7)
    NearCall(cs1, 0x6FAA, not_observed_1000_7085_017085);
    // OR word ptr [SI + 0x12],0x20 (1000_6FAA / 0x16FAA)
    // UInt16[DS, (ushort)(SI + 0x12)] |= 0x20;
    UInt16[DS, (ushort)(SI + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x12)], 0x20);
    // POP AX (1000_6FAE / 0x16FAE)
    AX = Stack.Pop();
    label_1000_6FAF_16FAF:
    // RET  (1000_6FAF / 0x16FAF)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6FB0_016FB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6FB0_16FB0:
    // MOV AH,AL (1000_6FB0 / 0x16FB0)
    AH = AL;
    // MOV AL,[0x29] (1000_6FB2 / 0x16FB2)
    AL = UInt8[DS, 0x29];
    // SUB AL,AH (1000_6FB5 / 0x16FB5)
    // AL -= AH;
    AL = Alu.Sub8(AL, AH);
    // JA 0x1000:6fbb (1000_6FB7 / 0x16FB7)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_6FBB_16FBB;
    }
    // MOV AL,0x1 (1000_6FB9 / 0x16FB9)
    AL = 0x1;
    label_1000_6FBB_16FBB:
    // MOV AH,AL (1000_6FBB / 0x16FBB)
    AH = AL;
    // XCHG byte ptr [0x29],AL (1000_6FBD / 0x16FBD)
    byte tmp_1000_6FBD = UInt8[DS, 0x29];
    UInt8[DS, 0x29] = AL;
    AL = tmp_1000_6FBD;
    // AND AX,0xfcfc (1000_6FC1 / 0x16FC1)
    AX &= 0xFCFC;
    // SUB AL,AH (1000_6FC4 / 0x16FC4)
    AL -= AH;
    // SHR AL,1 (1000_6FC6 / 0x16FC6)
    AL >>= 0x1;
    // SHR AL,1 (1000_6FC8 / 0x16FC8)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNZ 0x1000:6fcd (1000_6FCA / 0x16FCA)
    if(!ZeroFlag) {
      goto label_1000_6FCD_16FCD;
    }
    // RET  (1000_6FCC / 0x16FCC)
    return NearRet();
    label_1000_6FCD_16FCD:
    // PUSH SI (1000_6FCD / 0x16FCD)
    Stack.Push(SI);
    // MOV SI,0x8aa (1000_6FCE / 0x16FCE)
    SI = 0x8AA;
    label_1000_6FD1_16FD1:
    // TEST byte ptr [SI + 0x3],0xa0 (1000_6FD1 / 0x16FD1)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xA0);
    // JNZ 0x1000:6fda (1000_6FD5 / 0x16FD5)
    if(!ZeroFlag) {
      goto label_1000_6FDA_16FDA;
    }
    // CALL 0x1000:6f93 (1000_6FD7 / 0x16FD7)
    NearCall(cs1, 0x6FDA, not_observed_1000_6F93_016F93);
    label_1000_6FDA_16FDA:
    // ADD SI,0x1b (1000_6FDA / 0x16FDA)
    SI += 0x1B;
    // CMP SI,0xfbb (1000_6FDD / 0x16FDD)
    Alu.Sub16(SI, 0xFBB);
    // JC 0x1000:6fd1 (1000_6FE1 / 0x16FE1)
    if(CarryFlag) {
      goto label_1000_6FD1_16FD1;
    }
    // POP SI (1000_6FE3 / 0x16FE3)
    SI = Stack.Pop();
    // RET  (1000_6FE4 / 0x16FE4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6FE5_016FE5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6FE5_16FE5:
    // CALL 0x1000:6e20 (1000_6FE5 / 0x16FE5)
    NearCall(cs1, 0x6FE8, spice86_generated_label_call_target_1000_6E20_016E20);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6FE8_016FE8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6FE8_016FE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6FE8_16FE8:
    // TEST word ptr [SI + 0x10],0x200 (1000_6FE8 / 0x16FE8)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    // JNZ 0x1000:705c (1000_6FED / 0x16FED)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_705C_01705C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:6b96 (1000_6FEF / 0x16FEF)
    NearCall(cs1, 0x6FF2, spice86_generated_label_call_target_1000_6B96_016B96);
    label_1000_6FF2_16FF2:
    // JNC 0x1000:6ff7 (1000_6FF2 / 0x16FF2)
    if(!CarryFlag) {
      goto label_1000_6FF7_16FF7;
    }
    // JMP 0x1000:707b (1000_6FF4 / 0x16FF4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_705C_01705C, 0x1707B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6FF7_16FF7:
    // CALL 0x1000:714c (1000_6FF7 / 0x16FF7)
    NearCall(cs1, 0x6FFA, spice86_generated_label_call_target_1000_714C_01714C);
    label_1000_6FFA_16FFA:
    // OR word ptr [SI + 0x10],0x100 (1000_6FFA / 0x16FFA)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x100;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x100);
    // CALL 0x1000:708a (1000_6FFF / 0x16FFF)
    NearCall(cs1, 0x7002, spice86_generated_label_call_target_1000_708A_01708A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7002_017002, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7002_017002(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7002_17002:
    // PUSH AX (1000_7002 / 0x17002)
    Stack.Push(AX);
    // MOV DX,word ptr [SI + 0xe] (1000_7003 / 0x17003)
    DX = UInt16[DS, (ushort)(SI + 0xE)];
    // ADD AX,DX (1000_7006 / 0x17006)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // MOV word ptr [SI + 0xe],AX (1000_7008 / 0x17008)
    UInt16[DS, (ushort)(SI + 0xE)] = AX;
    // XOR AX,DX (1000_700B / 0x1700B)
    AX ^= DX;
    // AND AX,0xff80 (1000_700D / 0x1700D)
    // AX &= 0xFF80;
    AX = Alu.And16(AX, 0xFF80);
    // JZ 0x1000:7019 (1000_7010 / 0x17010)
    if(ZeroFlag) {
      goto label_1000_7019_17019;
    }
    // MOV AL,0x1 (1000_7012 / 0x17012)
    AL = 0x1;
    // XOR BX,BX (1000_7014 / 0x17014)
    BX = 0;
    // CALL 0x1000:6edd (1000_7016 / 0x17016)
    NearCall(cs1, 0x7019, not_observed_1000_6EDD_016EDD);
    label_1000_7019_17019:
    // POP AX (1000_7019 / 0x17019)
    AX = Stack.Pop();
    // PUSH AX (1000_701A / 0x1701A)
    Stack.Push(AX);
    // ADD AX,word ptr [0x46e1] (1000_701B / 0x1701B)
    AX += UInt16[DS, 0x46E1];
    // XOR DX,DX (1000_701F / 0x1701F)
    DX = 0;
    // MOV CX,0xa (1000_7021 / 0x17021)
    CX = 0xA;
    // DIV CX (1000_7024 / 0x17024)
    Cpu.Div16(CX);
    // MOV word ptr [0x46e1],DX (1000_7026 / 0x17026)
    UInt16[DS, 0x46E1] = DX;
    // ADD word ptr [0xa0],AX (1000_702A / 0x1702A)
    // UInt16[DS, 0xA0] += AX;
    UInt16[DS, 0xA0] = Alu.Add16(UInt16[DS, 0xA0], AX);
    // POP AX (1000_702E / 0x1702E)
    AX = Stack.Pop();
    // ADD AL,byte ptr [DI + 0x13] (1000_702F / 0x1702F)
    // AL += UInt8[DS, (ushort)(DI + 0x13)];
    AL = Alu.Add8(AL, UInt8[DS, (ushort)(DI + 0x13)]);
    // ADC AH,0x0 (1000_7032 / 0x17032)
    AH = Alu.Adc8(AH, 0x0);
    // MOV CL,byte ptr [DI + 0x11] (1000_7035 / 0x17035)
    CL = UInt8[DS, (ushort)(DI + 0x11)];
    // DIV CL (1000_7038 / 0x17038)
    Cpu.Div8(CL);
    // MOV byte ptr [DI + 0x13],AH (1000_703A / 0x1703A)
    UInt8[DS, (ushort)(DI + 0x13)] = AH;
    // MOV AH,byte ptr [DI + 0x12] (1000_703D / 0x1703D)
    AH = UInt8[DS, (ushort)(DI + 0x12)];
    // AND AH,0xf (1000_7040 / 0x17040)
    AH &= 0xF;
    // CMP AL,AH (1000_7043 / 0x17043)
    Alu.Sub8(AL, AH);
    // JBE 0x1000:7052 (1000_7045 / 0x17045)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_7052_17052;
    }
    // TEST byte ptr [0x46eb],0x40 (1000_7047 / 0x17047)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JZ 0x1000:7052 (1000_704C / 0x1704C)
    if(ZeroFlag) {
      goto label_1000_7052_17052;
    }
    // INC byte ptr [0x46ec] (1000_704E / 0x1704E)
    UInt8[DS, 0x46EC]++;
    label_1000_7052_17052:
    // SUB byte ptr [DI + 0x12],AL (1000_7052 / 0x17052)
    // UInt8[DS, (ushort)(DI + 0x12)] -= AL;
    UInt8[DS, (ushort)(DI + 0x12)] = Alu.Sub8(UInt8[DS, (ushort)(DI + 0x12)], AL);
    // JNC 0x1000:705b (1000_7055 / 0x17055)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_705B / 0x1705B)
      return NearRet();
    }
    // MOV byte ptr [DI + 0x12],0x0 (1000_7057 / 0x17057)
    UInt8[DS, (ushort)(DI + 0x12)] = 0x0;
    label_1000_705B_1705B:
    // RET  (1000_705B / 0x1705B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_705C_01705C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_705C_1705C:
    // MOV AX,[0x2] (1000_705C / 0x1705C)
    AX = UInt16[DS, 0x2];
    // MOV AH,byte ptr [SI] (1000_705F / 0x1705F)
    AH = UInt8[DS, SI];
    // AND AX,0xf0f (1000_7061 / 0x17061)
    AX &= 0xF0F;
    // CMP AL,AH (1000_7064 / 0x17064)
    Alu.Sub8(AL, AH);
    // JNZ 0x1000:7074 (1000_7066 / 0x17066)
    if(!ZeroFlag) {
      goto label_1000_7074_17074;
    }
    // AND word ptr [SI + 0x10],0xfdff (1000_7068 / 0x17068)
    // UInt16[DS, (ushort)(SI + 0x10)] &= 0xFDFF;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0xFDFF);
    // CALL 0x1000:6b96 (1000_706D / 0x1706D)
    NearCall(cs1, 0x7070, spice86_generated_label_call_target_1000_6B96_016B96);
    // JC 0x1000:705b (1000_7070 / 0x17070)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_705B / 0x1705B)
      return NearRet();
    }
    // JMP 0x1000:6ffa (1000_7072 / 0x17072)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6FE8_016FE8, 0x16FFA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_7074_17074:
    // MOV word ptr [SI + 0xc],0x0 (1000_7074 / 0x17074)
    UInt16[DS, (ushort)(SI + 0xC)] = 0x0;
    // JMP 0x1000:7085 (1000_7079 / 0x17079)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_7085_017085, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_707B_1707B:
    // MOV word ptr [SI + 0xc],0x0 (1000_707B / 0x1707B)
    UInt16[DS, (ushort)(SI + 0xC)] = 0x0;
    // MOV word ptr [SI + 0xe],0x0 (1000_7080 / 0x17080)
    UInt16[DS, (ushort)(SI + 0xE)] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_7085_017085, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_7085_017085(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7085_17085:
    // OR byte ptr [SI + 0x3],0x10 (1000_7085 / 0x17085)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x10;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x10);
    // RET  (1000_7089 / 0x17089)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_708A_01708A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_708A_1708A:
    // CALL 0x1000:6efd (1000_708A / 0x1708A)
    NearCall(cs1, 0x708D, spice86_generated_label_call_target_1000_6EFD_016EFD);
    label_1000_708D_1708D:
    // MOV AH,byte ptr [SI + 0x16] (1000_708D / 0x1708D)
    AH = UInt8[DS, (ushort)(SI + 0x16)];
    // AND AH,0xf0 (1000_7090 / 0x17090)
    AH &= 0xF0;
    // ADD AL,AH (1000_7093 / 0x17093)
    AL += AH;
    // MUL byte ptr [SI + 0x1a] (1000_7095 / 0x17095)
    Cpu.Mul8(UInt8[DS, (ushort)(SI + 0x1A)]);
    // TEST byte ptr [SI + 0x19],0x80 (1000_7098 / 0x17098)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x80);
    // JNZ 0x1000:70a2 (1000_709C / 0x1709C)
    if(!ZeroFlag) {
      goto label_1000_70A2_170A2;
    }
    // SHR AX,1 (1000_709E / 0x1709E)
    AX >>= 0x1;
    // SHR AX,1 (1000_70A0 / 0x170A0)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    label_1000_70A2_170A2:
    // MOV AL,byte ptr [DI + 0x12] (1000_70A2 / 0x170A2)
    AL = UInt8[DS, (ushort)(DI + 0x12)];
    // AND AL,0xf0 (1000_70A5 / 0x170A5)
    AL &= 0xF0;
    // INC AX (1000_70A7 / 0x170A7)
    AX++;
    // MUL AH (1000_70A8 / 0x170A8)
    Cpu.Mul8(AH);
    // XCHG AH,AL (1000_70AA / 0x170AA)
    byte tmp_1000_70AA = AH;
    AH = AL;
    AL = tmp_1000_70AA;
    // ROL AX,1 (1000_70AC / 0x170AC)
    AX = Alu.Rol16(AX, 0x1);
    // AND AH,0x1 (1000_70AE / 0x170AE)
    // AH &= 0x1;
    AH = Alu.And8(AH, 0x1);
    // MOV DX,AX (1000_70B1 / 0x170B1)
    DX = AX;
    // XCHG word ptr [SI + 0xc],DX (1000_70B3 / 0x170B3)
    ushort tmp_1000_70B3 = UInt16[DS, (ushort)(SI + 0xC)];
    UInt16[DS, (ushort)(SI + 0xC)] = DX;
    DX = tmp_1000_70B3;
    // SUB DX,AX (1000_70B6 / 0x170B6)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // JZ 0x1000:70cb (1000_70B8 / 0x170B8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_70CB / 0x170CB)
      return NearRet();
    }
    // MOV BL,0x8 (1000_70BA / 0x170BA)
    BL = 0x8;
    // JC 0x1000:70c0 (1000_70BC / 0x170BC)
    if(CarryFlag) {
      goto label_1000_70C0_170C0;
    }
    // MOV BL,0x4 (1000_70BE / 0x170BE)
    BL = 0x4;
    label_1000_70C0_170C0:
    // MOV CX,word ptr [SI + 0x10] (1000_70C0 / 0x170C0)
    CX = UInt16[DS, (ushort)(SI + 0x10)];
    // AND CL,0xf3 (1000_70C3 / 0x170C3)
    // CL &= 0xF3;
    CL = Alu.And8(CL, 0xF3);
    // OR CL,BL (1000_70C6 / 0x170C6)
    // CL |= BL;
    CL = Alu.Or8(CL, BL);
    // MOV word ptr [SI + 0x10],CX (1000_70C8 / 0x170C8)
    UInt16[DS, (ushort)(SI + 0x10)] = CX;
    label_1000_70CB_170CB:
    // RET  (1000_70CB / 0x170CB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_714C_01714C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_714C_1714C:
    // TEST byte ptr [0xa],0x1 (1000_714C / 0x1714C)
    Alu.And8(UInt8[DS, 0xA], 0x1);
    // JZ 0x1000:71bb (1000_7151 / 0x17151)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x19],0x80 (1000_7153 / 0x17153)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x80);
    // JZ 0x1000:71bb (1000_7157 / 0x17157)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // MOV AX,[0x2] (1000_7159 / 0x17159)
    AX = UInt16[DS, 0x2];
    // MOV AH,byte ptr [SI] (1000_715C / 0x1715C)
    AH = UInt8[DS, SI];
    // AND AX,0xf0f (1000_715E / 0x1715E)
    AX &= 0xF0F;
    // CMP AL,AH (1000_7161 / 0x17161)
    Alu.Sub8(AL, AH);
    // JNZ 0x1000:71bb (1000_7163 / 0x17163)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // CALL 0x1000:71bc (1000_7165 / 0x17165)
    NearCall(cs1, 0x7168, not_observed_1000_71BC_0171BC);
    // CALL 0x1000:e3cc (1000_7168 / 0x17168)
    NearCall(cs1, 0x716B, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    // MOV AL,byte ptr [DI] (1000_716B / 0x1716B)
    AL = UInt8[DS, DI];
    // MOV BX,0x1141 (1000_716D / 0x1716D)
    BX = 0x1141;
    // XLAT BX (1000_7170 / 0x17170)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // CMP AL,AH (1000_7171 / 0x17171)
    Alu.Sub8(AL, AH);
    // JC 0x1000:71bb (1000_7173 / 0x17173)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // OR word ptr [SI + 0x10],0x4000 (1000_7175 / 0x17175)
    UInt16[DS, (ushort)(SI + 0x10)] |= 0x4000;
    // TEST byte ptr [SI + 0x19],0x40 (1000_717A / 0x1717A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x40);
    // JNZ 0x1000:71bb (1000_717E / 0x1717E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // AND AH,0x3 (1000_7180 / 0x17180)
    // AH &= 0x3;
    AH = Alu.And8(AH, 0x3);
    // JZ 0x1000:71bb (1000_7183 / 0x17183)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // CMP AH,0x2 (1000_7185 / 0x17185)
    Alu.Sub8(AH, 0x2);
    // JA 0x1000:71a4 (1000_7188 / 0x17188)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_71A4_0171A4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JZ 0x1000:719c (1000_718A / 0x1718A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_719C_01719C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // OR word ptr [SI + 0x10],0x2000 (1000_718C / 0x1718C)
    UInt16[DS, (ushort)(SI + 0x10)] |= 0x2000;
    // SUB byte ptr [SI + 0x1a],0x2 (1000_7191 / 0x17191)
    // UInt8[DS, (ushort)(SI + 0x1A)] -= 0x2;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x2);
    // JA 0x1000:71bb (1000_7195 / 0x17195)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    // ADD byte ptr [SI + 0x1a],0x2 (1000_7197 / 0x17197)
    // UInt8[DS, (ushort)(SI + 0x1A)] += 0x2;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Add8(UInt8[DS, (ushort)(SI + 0x1A)], 0x2);
    // RET  (1000_719B / 0x1719B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_719C_01719C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_719C_1719C:
    // OR word ptr [SI + 0x10],0x200 (1000_719C / 0x1719C)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x200;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    // JMP 0x1000:7085 (1000_71A1 / 0x171A1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_7085_017085, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_71A4_0171A4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_71A4_171A4:
    // OR word ptr [SI + 0x10],0x1000 (1000_71A4 / 0x171A4)
    UInt16[DS, (ushort)(SI + 0x10)] |= 0x1000;
    // AND byte ptr [SI + 0x19],0x7f (1000_71A9 / 0x171A9)
    UInt8[DS, (ushort)(SI + 0x19)] &= 0x7F;
    // DEC byte ptr [DI + 0x14] (1000_71AD / 0x171AD)
    UInt8[DS, (ushort)(DI + 0x14)] = Alu.Dec8(UInt8[DS, (ushort)(DI + 0x14)]);
    // MOV AL,0x6 (1000_71B0 / 0x171B0)
    AL = 0x6;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_71B2_0171B2(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x71BB: goto label_1000_71BB_171BB;break; // Target of external jump from 0x17151
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_71B2_171B2:
    // MOV AH,0xf (1000_71B2 / 0x171B2)
    AH = 0xF;
    // PUSH SI (1000_71B4 / 0x171B4)
    Stack.Push(SI);
    // PUSH DI (1000_71B5 / 0x171B5)
    Stack.Push(DI);
    // CALL 0x1000:29f0 (1000_71B6 / 0x171B6)
    NearCall(cs1, 0x71B9, not_observed_1000_29F0_0129F0);
    // POP DI (1000_71B9 / 0x171B9)
    DI = Stack.Pop();
    // POP SI (1000_71BA / 0x171BA)
    SI = Stack.Pop();
    label_1000_71BB_171BB:
    // RET  (1000_71BB / 0x171BB)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_71BC_0171BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_71BC_171BC:
    // CMP byte ptr [0x2a],0x35 (1000_71BC / 0x171BC)
    Alu.Sub8(UInt8[DS, 0x2A], 0x35);
    // JC 0x1000:71ee (1000_71C1 / 0x171C1)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_71EE / 0x171EE)
      return NearRet();
    }
    // TEST word ptr [SI + 0x12],0x40 (1000_71C3 / 0x171C3)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x40);
    // JZ 0x1000:71ee (1000_71C8 / 0x171C8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_71EE / 0x171EE)
      return NearRet();
    }
    // ROL word ptr [0x0],1 (1000_71CA / 0x171CA)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // ROL word ptr [0x0],1 (1000_71CE / 0x171CE)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // ROL word ptr [0x0],1 (1000_71D2 / 0x171D2)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // TEST word ptr [0x0],0x7 (1000_71D6 / 0x171D6)
    Alu.And16(UInt16[DS, 0x0], 0x7);
    // JNZ 0x1000:71ee (1000_71DC / 0x171DC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_71EE / 0x171EE)
      return NearRet();
    }
    // CALL 0x1000:719c (1000_71DE / 0x171DE)
    NearCall(cs1, 0x71E1, not_observed_1000_719C_01719C);
    // OR word ptr [SI + 0x10],0x8000 (1000_71E1 / 0x171E1)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x8000;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x8000);
    // OR byte ptr [DI + 0xa],0x4 (1000_71E6 / 0x171E6)
    // UInt8[DS, (ushort)(DI + 0xA)] |= 0x4;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xA)], 0x4);
    // MOV AL,0x3 (1000_71EA / 0x171EA)
    AL = 0x3;
    // JMP 0x1000:71b2 (1000_71EC / 0x171EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_71EE_171EE:
    // RET  (1000_71EE / 0x171EE)
    return NearRet();
  }
  
  public virtual Action map_func_ida_1000_739E_1739E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_739E_1739E:
    // OR byte ptr [0x11bc],0x1 (1000_739E / 0x1739E)
    UInt8[DS, 0x11BC] |= 0x1;
    // CMP DI,0x11c (1000_73A3 / 0x173A3)
    Alu.Sub16(DI, 0x11C);
    // JNZ 0x1000:73d9 (1000_73A7 / 0x173A7)
    if(!ZeroFlag) {
      goto label_1000_73D9_173D9;
    }
    // INC byte ptr [0xc2] (1000_73A9 / 0x173A9)
    UInt8[DS, 0xC2] = Alu.Inc8(UInt8[DS, 0xC2]);
    // MOV BP,0x7399 (1000_73AD / 0x173AD)
    BP = 0x7399;
    // CALL 0x1000:661d (1000_73B0 / 0x173B0)
    NearCall(cs1, 0x73B3, spice86_generated_label_call_target_1000_661D_01661D);
    // CALL 0x1000:6e02 (1000_73B3 / 0x173B3)
    NearCall(cs1, 0x73B6, not_observed_1000_6E02_016E02);
    // LES DI,[0xdcfe] (1000_73B6 / 0x173B6)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    // XOR DI,DI (1000_73BA / 0x173BA)
    DI = 0;
    // MOV CX,0xc5f9 (1000_73BC / 0x173BC)
    CX = 0xC5F9;
    label_1000_73BF_173BF:
    // MOV AL,byte ptr ES:[DI] (1000_73BF / 0x173BF)
    AL = UInt8[ES, DI];
    // MOV AH,AL (1000_73C2 / 0x173C2)
    AH = AL;
    // AND AH,0x30 (1000_73C4 / 0x173C4)
    AH &= 0x30;
    // CMP AH,0x30 (1000_73C7 / 0x173C7)
    Alu.Sub8(AH, 0x30);
    // JNZ 0x1000:73ce (1000_73CA / 0x173CA)
    if(!ZeroFlag) {
      goto label_1000_73CE_173CE;
    }
    // AND AL,0xef (1000_73CC / 0x173CC)
    // AL &= 0xEF;
    AL = Alu.And8(AL, 0xEF);
    label_1000_73CE_173CE:
    // STOSB ES:DI (1000_73CE / 0x173CE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x1000:73bf (1000_73CF / 0x173CF)
    if(--CX != 0) {
      goto label_1000_73BF_173BF;
    }
    // MOV AL,0xa (1000_73D1 / 0x173D1)
    AL = 0xA;
    // MOV DI,0x11c (1000_73D3 / 0x173D3)
    DI = 0x11C;
    // JMP 0x1000:71b2 (1000_73D6 / 0x173D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_73D9_173D9:
    // CALL 0x1000:33be (1000_73D9 / 0x173D9)
    NearCall(cs1, 0x73DC, spice86_generated_label_call_target_1000_33BE_0133BE);
    // CMP word ptr [0x94],0x0 (1000_73DC / 0x173DC)
    Alu.Sub16(UInt16[DS, 0x94], 0x0);
    // JZ 0x1000:7429 (1000_73E1 / 0x173E1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_7429_017429, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:e3cc (1000_73E3 / 0x173E3)
    NearCall(cs1, 0x73E6, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    // CMP AL,byte ptr [0x9c] (1000_73E6 / 0x173E6)
    Alu.Sub8(AL, UInt8[DS, 0x9C]);
    // JC 0x1000:73ef (1000_73EA / 0x173EA)
    if(CarryFlag) {
      goto label_1000_73EF_173EF;
    }
    // JMP 0x1000:751d (1000_73EC / 0x173EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_751D_01751D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_73EF_173EF:
    // CALL 0x1000:5098 (1000_73EF / 0x173EF)
    NearCall(cs1, 0x73F2, not_observed_1000_5098_015098);
    // PUSH CX (1000_73F2 / 0x173F2)
    Stack.Push(CX);
    // CALL 0x1000:342d (1000_73F3 / 0x173F3)
    NearCall(cs1, 0x73F6, spice86_generated_label_call_target_1000_342D_01342D);
    // POP CX (1000_73F6 / 0x173F6)
    CX = Stack.Pop();
    // JCXZ 0x1000:73fd (1000_73F7 / 0x173F7)
    if(CX == 0) {
      goto label_1000_73FD_173FD;
    }
    // XOR DX,DX (1000_73F9 / 0x173F9)
    DX = 0;
    // DIV CX (1000_73FB / 0x173FB)
    Cpu.Div16(CX);
    label_1000_73FD_173FD:
    // MOV DL,AL (1000_73FD / 0x173FD)
    DL = AL;
    // INC DL (1000_73FF / 0x173FF)
    DL = Alu.Inc8(DL);
    // JNZ 0x1000:7405 (1000_7401 / 0x17401)
    if(!ZeroFlag) {
      goto label_1000_7405_17405;
    }
    // DEC DL (1000_7403 / 0x17403)
    DL--;
    label_1000_7405_17405:
    // XOR DH,DH (1000_7405 / 0x17405)
    DH = 0;
    // XOR CX,CX (1000_7407 / 0x17407)
    CX = 0;
    // XOR BX,BX (1000_7409 / 0x17409)
    BX = 0;
    // MOV BP,0x7552 (1000_740B / 0x1740B)
    BP = 0x7552;
    // CALL 0x1000:6603 (1000_740E / 0x1740E)
    NearCall(cs1, 0x7411, spice86_generated_label_call_target_1000_6603_016603);
    // ADD word ptr [SI + 0xc],CX (1000_7411 / 0x17411)
    // UInt16[DS, (ushort)(SI + 0xC)] += CX;
    UInt16[DS, (ushort)(SI + 0xC)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0xC)], CX);
    // OR BX,BX (1000_7414 / 0x17414)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:7429 (1000_7416 / 0x17416)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_7429_017429, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_7418 / 0x17418)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_7429_017429(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7429_17429:
    // CMP DI,word ptr [0x114e] (1000_7429 / 0x17429)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JZ 0x1000:7434 (1000_742D / 0x1742D)
    if(ZeroFlag) {
      goto label_1000_7434_17434;
    }
    // MOV AL,0x7 (1000_742F / 0x1742F)
    AL = 0x7;
    // CALL 0x1000:71b2 (1000_7431 / 0x17431)
    NearCall(cs1, 0x7434, not_observed_1000_71B2_0171B2);
    label_1000_7434_17434:
    // CMP byte ptr [DI + 0x8],0x28 (1000_7434 / 0x17434)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JNC 0x1000:7443 (1000_7438 / 0x17438)
    if(!CarryFlag) {
      goto label_1000_7443_17443;
    }
    // AND byte ptr [DI + 0xa],0xfd (1000_743A / 0x1743A)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0xFD;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0xFD);
    // MOV BP,0x75af (1000_743E / 0x1743E)
    BP = 0x75AF;
    // JMP 0x1000:7479 (1000_7441 / 0x17441)
    goto label_1000_7479_17479;
    label_1000_7443_17443:
    // PUSH SI (1000_7443 / 0x17443)
    Stack.Push(SI);
    // PUSH DI (1000_7444 / 0x17444)
    Stack.Push(DI);
    // MOV byte ptr [DI + 0xb],0x5 (1000_7445 / 0x17445)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x5;
    // CALL 0x1000:644e (1000_7449 / 0x17449)
    NearCall(cs1, 0x744C, spice86_generated_label_call_target_1000_644E_01644E);
    // POP DI (1000_744C / 0x1744C)
    DI = Stack.Pop();
    // POP SI (1000_744D / 0x1744D)
    SI = Stack.Pop();
    // CALL 0x1000:1ac5 (1000_744E / 0x1744E)
    NearCall(cs1, 0x7451, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // ADD AL,0x2 (1000_7451 / 0x17451)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    // MOV byte ptr [DI + 0xb],AL (1000_7453 / 0x17453)
    UInt8[DS, (ushort)(DI + 0xB)] = AL;
    // MOV AL,0x4 (1000_7456 / 0x17456)
    AL = 0x4;
    // CALL 0x1000:6f78 (1000_7458 / 0x17458)
    NearCall(cs1, 0x745B, spice86_generated_label_call_target_1000_6F78_016F78);
    // MOV AL,0x1 (1000_745B / 0x1745B)
    AL = 0x1;
    // CALL 0x1000:6f56 (1000_745D / 0x1745D)
    NearCall(cs1, 0x7460, not_observed_1000_6F56_016F56);
    // OR byte ptr [DI + 0xa],0x8 (1000_7460 / 0x17460)
    // UInt8[DS, (ushort)(DI + 0xA)] |= 0x8;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    // PUSH CX (1000_7464 / 0x17464)
    Stack.Push(CX);
    // MOV CL,byte ptr [DI] (1000_7465 / 0x17465)
    CL = UInt8[DS, DI];
    // MOV AX,0x8000 (1000_7467 / 0x17467)
    AX = 0x8000;
    // ROL AX,CL (1000_746A / 0x1746A)
    AX = Alu.Rol16(AX, CL);
    // MOV [0x115a],AX (1000_746C / 0x1746C)
    UInt16[DS, 0x115A] = AX;
    // POP CX (1000_746F / 0x1746F)
    CX = Stack.Pop();
    // MOV BP,0x75af (1000_7470 / 0x17470)
    BP = 0x75AF;
    // CALL 0x1000:6603 (1000_7473 / 0x17473)
    NearCall(cs1, 0x7476, spice86_generated_label_call_target_1000_6603_016603);
    // MOV BP,0x75ea (1000_7476 / 0x17476)
    BP = 0x75EA;
    label_1000_7479_17479:
    // CALL 0x1000:6603 (1000_7479 / 0x17479)
    NearCall(cs1, 0x747C, spice86_generated_label_call_target_1000_6603_016603);
    // XOR DX,DX (1000_747C / 0x1747C)
    DX = 0;
    // TEST word ptr [0x0],0x3 (1000_747E / 0x1747E)
    Alu.And16(UInt16[DS, 0x0], 0x3);
    // JNZ 0x1000:7487 (1000_7484 / 0x17484)
    if(!ZeroFlag) {
      goto label_1000_7487_17487;
    }
    // INC DX (1000_7486 / 0x17486)
    DX++;
    label_1000_7487_17487:
    // XOR CX,CX (1000_7487 / 0x17487)
    CX = 0;
    // MOV BP,0x762a (1000_7489 / 0x17489)
    BP = 0x762A;
    // CALL 0x1000:6603 (1000_748C / 0x1748C)
    NearCall(cs1, 0x748F, spice86_generated_label_call_target_1000_6603_016603);
    // CMP CX,DX (1000_748F / 0x1748F)
    Alu.Sub16(CX, DX);
    // JA 0x1000:7487 (1000_7491 / 0x17491)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_7487_17487;
    }
    // PUSH SI (1000_7493 / 0x17493)
    Stack.Push(SI);
    // PUSH DI (1000_7494 / 0x17494)
    Stack.Push(DI);
    // CALL 0x1000:1cda (1000_7495 / 0x17495)
    NearCall(cs1, 0x7498, spice86_generated_label_call_target_1000_1CDA_011CDA);
    // CMP DL,0x1 (1000_7498 / 0x17498)
    Alu.Sub8(DL, 0x1);
    // JA 0x1000:74b1 (1000_749B / 0x1749B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_74B1_174B1;
    }
    // MOV byte ptr [0xc2],0x1 (1000_749D / 0x1749D)
    UInt8[DS, 0xC2] = 0x1;
    // AND byte ptr [0xff7],0xfd (1000_74A2 / 0x174A2)
    UInt8[DS, 0xFF7] &= 0xFD;
    // AND byte ptr [0x1007],0xfd (1000_74A7 / 0x174A7)
    // UInt8[DS, 0x1007] &= 0xFD;
    UInt8[DS, 0x1007] = Alu.And8(UInt8[DS, 0x1007], 0xFD);
    // POP DI (1000_74AC / 0x174AC)
    DI = Stack.Pop();
    // CALL 0x1000:765e (1000_74AD / 0x174AD)
    NearCall(cs1, 0x74B0, not_observed_1000_765E_01765E);
    // PUSH DI (1000_74B0 / 0x174B0)
    Stack.Push(DI);
    label_1000_74B1_174B1:
    // POP DI (1000_74B1 / 0x174B1)
    DI = Stack.Pop();
    // POP SI (1000_74B2 / 0x174B2)
    SI = Stack.Pop();
    // JMP 0x1000:5d50 (1000_74B3 / 0x174B3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_74B6_0174B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_74B6_174B6:
    // AND byte ptr [DI + 0xa],0xfd (1000_74B6 / 0x174B6)
    UInt8[DS, (ushort)(DI + 0xA)] &= 0xFD;
    // CMP DI,word ptr [0x114e] (1000_74BA / 0x174BA)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JZ 0x1000:7500 (1000_74BE / 0x174BE)
    if(ZeroFlag) {
      goto label_1000_7500_17500;
    }
    // MOV AL,byte ptr [DI + 0x8] (1000_74C0 / 0x174C0)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    // CMP AL,0x28 (1000_74C3 / 0x174C3)
    Alu.Sub8(AL, 0x28);
    // JNC 0x1000:74eb (1000_74C5 / 0x174C5)
    if(!CarryFlag) {
      goto label_1000_74EB_174EB;
    }
    // AND AL,0x7 (1000_74C7 / 0x174C7)
    AL &= 0x7;
    // ADD AL,0x28 (1000_74C9 / 0x174C9)
    // AL += 0x28;
    AL = Alu.Add8(AL, 0x28);
    // MOV byte ptr [DI + 0x8],AL (1000_74CB / 0x174CB)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    // DEC byte ptr [0x27] (1000_74CE / 0x174CE)
    UInt8[DS, 0x27] = Alu.Dec8(UInt8[DS, 0x27]);
    // PUSH SI (1000_74D2 / 0x174D2)
    Stack.Push(SI);
    // CALL 0x1000:40ae (1000_74D3 / 0x174D3)
    NearCall(cs1, 0x74D6, spice86_generated_label_call_target_1000_40AE_0140AE);
    // MOV DL,0x3 (1000_74D6 / 0x174D6)
    DL = 0x3;
    // MOV SI,0xfd8 (1000_74D8 / 0x174D8)
    SI = 0xFD8;
    // MOV CX,0x9 (1000_74DB / 0x174DB)
    CX = 0x9;
    label_1000_74DE_174DE:
    // CMP BX,word ptr [SI + 0x2] (1000_74DE / 0x174DE)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:74e5 (1000_74E1 / 0x174E1)
    if(!ZeroFlag) {
      goto label_1000_74E5_174E5;
    }
    // MOV word ptr [SI],DX (1000_74E3 / 0x174E3)
    UInt16[DS, SI] = DX;
    label_1000_74E5_174E5:
    // ADD SI,0x10 (1000_74E5 / 0x174E5)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:74de (1000_74E8 / 0x174E8)
    if(--CX != 0) {
      goto label_1000_74DE_174DE;
    }
    // POP SI (1000_74EA / 0x174EA)
    SI = Stack.Pop();
    label_1000_74EB_174EB:
    // MOV BP,0x7506 (1000_74EB / 0x174EB)
    BP = 0x7506;
    // CALL 0x1000:6603 (1000_74EE / 0x174EE)
    NearCall(cs1, 0x74F1, spice86_generated_label_call_target_1000_6603_016603);
    // PUSH DI (1000_74F1 / 0x174F1)
    Stack.Push(DI);
    // MOV CX,0x5 (1000_74F2 / 0x174F2)
    CX = 0x5;
    // CALL 0x1000:6447 (1000_74F5 / 0x174F5)
    NearCall(cs1, 0x74F8, not_observed_1000_6447_016447);
    // POP DI (1000_74F8 / 0x174F8)
    DI = Stack.Pop();
    // AND byte ptr [DI + 0xa],0xf6 (1000_74F9 / 0x174F9)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0xF6;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0xF6);
    // JMP 0x1000:5d44 (1000_74FD / 0x174FD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D44_015D44, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_7500_17500:
    // MOV byte ptr [0x46d9],0x6 (1000_7500 / 0x17500)
    UInt8[DS, 0x46D9] = 0x6;
    // RET  (1000_7505 / 0x17505)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_751D_01751D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_751D_1751D:
    // MOV AX,[0x94] (1000_751D / 0x1751D)
    AX = UInt16[DS, 0x94];
    // XOR DX,DX (1000_7520 / 0x17520)
    DX = 0;
    // XOR CX,CX (1000_7522 / 0x17522)
    CX = 0;
    // MOV CL,byte ptr [0x60] (1000_7524 / 0x17524)
    CL = UInt8[DS, 0x60];
    // JCXZ 0x1000:752c (1000_7528 / 0x17528)
    if(CX == 0) {
      goto label_1000_752C_1752C;
    }
    // DIV CX (1000_752A / 0x1752A)
    Cpu.Div16(CX);
    label_1000_752C_1752C:
    // MOV DX,AX (1000_752C / 0x1752C)
    DX = AX;
    // CALL 0x1000:758d (1000_752E / 0x1752E)
    NearCall(cs1, 0x7531, not_observed_1000_758D_01758D);
    // ADD word ptr [SI + 0xe],AX (1000_7531 / 0x17531)
    UInt16[DS, (ushort)(SI + 0xE)] += AX;
    // SUB byte ptr [SI + 0x1a],AL (1000_7534 / 0x17534)
    // UInt8[DS, (ushort)(SI + 0x1A)] -= AL;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], AL);
    // JA 0x1000:7551 (1000_7537 / 0x17537)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_7551 / 0x17551)
      return NearRet();
    }
    // MOV BX,0x7f (1000_7539 / 0x17539)
    BX = 0x7F;
    // CALL 0x1000:e3b7 (1000_753C / 0x1753C)
    NearCall(cs1, 0x753F, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // ADD AL,0x1e (1000_753F / 0x1753F)
    // AL += 0x1E;
    AL = Alu.Add8(AL, 0x1E);
    // MOV byte ptr [SI + 0x1a],AL (1000_7541 / 0x17541)
    UInt8[DS, (ushort)(SI + 0x1A)] = AL;
    // CALL 0x1000:668f (1000_7544 / 0x17544)
    NearCall(cs1, 0x7547, not_observed_1000_668F_01668F);
    // CALL 0x1000:5098 (1000_7547 / 0x17547)
    NearCall(cs1, 0x754A, not_observed_1000_5098_015098);
    // OR DX,DX (1000_754A / 0x1754A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNZ 0x1000:7551 (1000_754C / 0x1754C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_7551 / 0x17551)
      return NearRet();
    }
    // CALL 0x1000:74b6 (1000_754E / 0x1754E)
    NearCall(cs1, 0x7551, not_observed_1000_74B6_0174B6);
    label_1000_7551_17551:
    // RET  (1000_7551 / 0x17551)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_758D_01758D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_758D_1758D:
    // PUSH DX (1000_758D / 0x1758D)
    Stack.Push(DX);
    // MOV AX,DX (1000_758E / 0x1758E)
    AX = DX;
    // MOV DX,0xff (1000_7590 / 0x17590)
    DX = 0xFF;
    // SUB DL,byte ptr [SI + 0x17] (1000_7593 / 0x17593)
    DL -= UInt8[DS, (ushort)(SI + 0x17)];
    // SUB DL,byte ptr [SI + 0x17] (1000_7596 / 0x17596)
    DL -= UInt8[DS, (ushort)(SI + 0x17)];
    // MUL DX (1000_7599 / 0x17599)
    Cpu.Mul16(DX);
    // MOV AL,AH (1000_759B / 0x1759B)
    AL = AH;
    // XOR AH,AH (1000_759D / 0x1759D)
    AH = 0;
    // OR DX,DX (1000_759F / 0x1759F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:75a5 (1000_75A1 / 0x175A1)
    if(ZeroFlag) {
      goto label_1000_75A5_175A5;
    }
    // MOV AL,0xff (1000_75A3 / 0x175A3)
    AL = 0xFF;
    label_1000_75A5_175A5:
    // POP DX (1000_75A5 / 0x175A5)
    DX = Stack.Pop();
    // CMP AL,byte ptr [SI + 0x1a] (1000_75A6 / 0x175A6)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x1A)]);
    // JBE 0x1000:75ae (1000_75A9 / 0x175A9)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_75AE / 0x175AE)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x1a] (1000_75AB / 0x175AB)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    label_1000_75AE_175AE:
    // RET  (1000_75AE / 0x175AE)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_765E_01765E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_765E_1765E:
    // CALL 0x1000:e270 (1000_765E / 0x1765E)
    NearCall(cs1, 0x7661, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV SI,0x100 (1000_7661 / 0x17661)
    SI = 0x100;
    // XOR CX,CX (1000_7664 / 0x17664)
    CX = 0;
    label_1000_7666_17666:
    // ADD CL,byte ptr [SI + 0x19] (1000_7666 / 0x17666)
    CL += UInt8[DS, (ushort)(SI + 0x19)];
    // ADD SI,0x1c (1000_7669 / 0x17669)
    SI += 0x1C;
    // CMP byte ptr [SI],0xff (1000_766C / 0x1766C)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:7666 (1000_766F / 0x1766F)
    if(!ZeroFlag) {
      goto label_1000_7666_17666;
    }
    // SUB CL,0xa (1000_7671 / 0x17671)
    // CL -= 0xA;
    CL = Alu.Sub8(CL, 0xA);
    // JC 0x1000:7679 (1000_7674 / 0x17674)
    if(CarryFlag) {
      goto label_1000_7679_17679;
    }
    // ADD byte ptr [DI + 0x19],CL (1000_7676 / 0x17676)
    // UInt8[DS, (ushort)(DI + 0x19)] += CL;
    UInt8[DS, (ushort)(DI + 0x19)] = Alu.Add8(UInt8[DS, (ushort)(DI + 0x19)], CL);
    label_1000_7679_17679:
    // CALL 0x1000:e283 (1000_7679 / 0x17679)
    NearCall(cs1, 0x767C, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_767C / 0x1767C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_780A_01780A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_780A_1780A:
    // CALL 0x1000:7c63 (1000_780A / 0x1780A)
    NearCall(cs1, 0x780D, spice86_generated_label_call_target_1000_7C63_017C63);
    label_1000_780D_1780D:
    // MOV BP,0x2122 (1000_780D / 0x1780D)
    BP = 0x2122;
    // CMP AX,word ptr [0x1176] (1000_7810 / 0x17810)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    // JA 0x1000:783e (1000_7814 / 0x17814)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_7816 / 0x17816)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST AL,0x20 (1000_7819 / 0x17819)
    Alu.And8(AL, 0x20);
    // JZ 0x1000:7821 (1000_781B / 0x1781B)
    if(ZeroFlag) {
      goto label_1000_7821_17821;
    }
    // CMP AL,0x22 (1000_781D / 0x1781D)
    Alu.Sub8(AL, 0x22);
    // JNZ 0x1000:783e (1000_781F / 0x1781F)
    if(!ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    label_1000_7821_17821:
    // MOV BP,0x214a (1000_7821 / 0x17821)
    BP = 0x214A;
    // TEST byte ptr [SI + 0x3],0x40 (1000_7824 / 0x17824)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:783e (1000_7828 / 0x17828)
    if(!ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    // MOV BP,0x210a (1000_782A / 0x1782A)
    BP = 0x210A;
    // MOV AX,0x52 (1000_782D / 0x1782D)
    AX = 0x52;
    // CMP byte ptr [0x46f3],0x1 (1000_7830 / 0x17830)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x1);
    // ADC AX,0x0 (1000_7835 / 0x17835)
    AX = Alu.Adc16(AX, 0x0);
    // MOV word ptr [BP + 0x12],AX (1000_7838 / 0x17838)
    UInt16[SS, (ushort)(BP + 0x12)] = AX;
    // CALL 0x1000:7847 (1000_783B / 0x1783B)
    NearCall(cs1, 0x783E, spice86_generated_label_call_target_1000_7847_017847);
    label_1000_783E_1783E:
    // MOV BX,0x8751 (1000_783E / 0x1783E)
    BX = 0x8751;
    // CALL 0x1000:d323 (1000_7841 / 0x17841)
    NearCall(cs1, 0x7844, spice86_generated_label_call_target_1000_D323_01D323);
    label_1000_7844_17844:
    // JMP 0x1000:c13b (1000_7844 / 0x17844)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7847_017847(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7847_17847:
    // MOV word ptr [0x2110],0x404f (1000_7847 / 0x17847)
    UInt16[DS, 0x2110] = 0x404F;
    // OR byte ptr [0x2115],0x40 (1000_784D / 0x1784D)
    // UInt8[DS, 0x2115] |= 0x40;
    UInt8[DS, 0x2115] = Alu.Or8(UInt8[DS, 0x2115], 0x40);
    // OR byte ptr [0x2119],0x40 (1000_7852 / 0x17852)
    UInt8[DS, 0x2119] |= 0x40;
    // TEST word ptr [SI + 0x12],0x400 (1000_7857 / 0x17857)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x400);
    // JNZ 0x1000:78bb (1000_785C / 0x1785C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_785E / 0x1785E)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_7861 / 0x17861)
    AL &= 0xF;
    // CMP AL,0x1 (1000_7863 / 0x17863)
    Alu.Sub8(AL, 0x1);
    // JZ 0x1000:786c (1000_7865 / 0x17865)
    if(ZeroFlag) {
      goto label_1000_786C_1786C;
    }
    // AND byte ptr [0x2111],0xbf (1000_7867 / 0x17867)
    UInt8[DS, 0x2111] &= 0xBF;
    label_1000_786C_1786C:
    // CMP AL,0x2 (1000_786C / 0x1786C)
    Alu.Sub8(AL, 0x2);
    // JNZ 0x1000:7876 (1000_786E / 0x1786E)
    if(!ZeroFlag) {
      goto label_1000_7876_17876;
    }
    // MOV byte ptr [0x2110],0x56 (1000_7870 / 0x17870)
    UInt8[DS, 0x2110] = 0x56;
    // RET  (1000_7875 / 0x17875)
    return NearRet();
    label_1000_7876_17876:
    // CMP byte ptr [0x2a],0x5 (1000_7876 / 0x17876)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5);
    // JC 0x1000:7882 (1000_787B / 0x1787B)
    if(CarryFlag) {
      goto label_1000_7882_17882;
    }
    // AND byte ptr [0x2119],0xbf (1000_787D / 0x1787D)
    UInt8[DS, 0x2119] &= 0xBF;
    label_1000_7882_17882:
    // CMP byte ptr [0x2a],0x4 (1000_7882 / 0x17882)
    Alu.Sub8(UInt8[DS, 0x2A], 0x4);
    // JC 0x1000:78bb (1000_7887 / 0x17887)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    // TEST word ptr [SI + 0x10],0x200 (1000_7889 / 0x17889)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    // JNZ 0x1000:78bb (1000_788E / 0x1788E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    // MOV DI,word ptr [SI + 0x4] (1000_7890 / 0x17890)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [DI + 0xa],0x8 (1000_7893 / 0x17893)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    // JNZ 0x1000:789f (1000_7897 / 0x17897)
    if(!ZeroFlag) {
      goto label_1000_789F_1789F;
    }
    // CMP byte ptr [DI + 0x8],0x28 (1000_7899 / 0x17899)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JNC 0x1000:78bb (1000_789D / 0x1789D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    label_1000_789F_1789F:
    // PUSH SI (1000_789F / 0x1789F)
    Stack.Push(SI);
    // CALL 0x1000:7f27 (1000_78A0 / 0x178A0)
    NearCall(cs1, 0x78A3, spice86_generated_label_call_target_1000_7F27_017F27);
    label_1000_78A3_178A3:
    // MOV SI,0x46fe (1000_78A3 / 0x178A3)
    SI = 0x46FE;
    // MOV CX,0x7 (1000_78A6 / 0x178A6)
    CX = 0x7;
    // XOR AL,AL (1000_78A9 / 0x178A9)
    AL = 0;
    label_1000_78AB_178AB:
    // OR AL,byte ptr [SI] (1000_78AB / 0x178AB)
    AL |= UInt8[DS, SI];
    // INC SI (1000_78AD / 0x178AD)
    SI = Alu.Inc16(SI);
    // LOOP 0x1000:78ab (1000_78AE / 0x178AE)
    if(--CX != 0) {
      goto label_1000_78AB_178AB;
    }
    // POP SI (1000_78B0 / 0x178B0)
    SI = Stack.Pop();
    // OR AL,byte ptr [SI + 0x19] (1000_78B1 / 0x178B1)
    // AL |= UInt8[DS, (ushort)(SI + 0x19)];
    AL = Alu.Or8(AL, UInt8[DS, (ushort)(SI + 0x19)]);
    // JZ 0x1000:78bb (1000_78B4 / 0x178B4)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    // AND byte ptr [0x2115],0xbf (1000_78B6 / 0x178B6)
    // UInt8[DS, 0x2115] &= 0xBF;
    UInt8[DS, 0x2115] = Alu.And8(UInt8[DS, 0x2115], 0xBF);
    label_1000_78BB_178BB:
    // RET  (1000_78BB / 0x178BB)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_78E9_0178E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_78E9_178E9:
    // CALL 0x1000:6917 (1000_78E9 / 0x178E9)
    NearCall(cs1, 0x78EC, spice86_generated_label_call_target_1000_6917_016917);
    // JZ 0x1000:78f1 (1000_78EC / 0x178EC)
    if(ZeroFlag) {
      goto label_1000_78F1_178F1;
    }
    // JMP 0x1000:79de (1000_78EE / 0x178EE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_79DE_0179DE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_78F1_178F1:
    // CALL 0x1000:c08e (1000_78F1 / 0x178F1)
    NearCall(cs1, 0x78F4, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:31f6 (1000_78F4 / 0x178F4)
    NearCall(cs1, 0x78F7, spice86_generated_label_call_target_1000_31F6_0131F6);
    // ADD word ptr [0x11f3],0xc (1000_78F7 / 0x178F7)
    // UInt16[DS, 0x11F3] += 0xC;
    UInt16[DS, 0x11F3] = Alu.Add16(UInt16[DS, 0x11F3], 0xC);
    // MOV SI,0x18df (1000_78FC / 0x178FC)
    SI = 0x18DF;
    // CALL 0x1000:7b1b (1000_78FF / 0x178FF)
    NearCall(cs1, 0x7902, spice86_generated_label_call_target_1000_7B1B_017B1B);
    // CALL 0x1000:d075 (1000_7902 / 0x17902)
    NearCall(cs1, 0x7905, spice86_generated_label_call_target_1000_D075_01D075);
    // MOV CL,0x9a (1000_7905 / 0x17905)
    CL = 0x9A;
    // MOV CH,byte ptr [0x18e8] (1000_7907 / 0x17907)
    CH = UInt8[DS, 0x18E8];
    // MOV DX,word ptr [0x18df] (1000_790B / 0x1790B)
    DX = UInt16[DS, 0x18DF];
    // MOV BX,word ptr [0x18e1] (1000_790F / 0x1790F)
    BX = UInt16[DS, 0x18E1];
    // ADD DX,0xc (1000_7913 / 0x17913)
    DX += 0xC;
    // ADD BX,0x4 (1000_7916 / 0x17916)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    // MOV AX,0x3a (1000_7919 / 0x17919)
    AX = 0x3A;
    // TEST byte ptr [0x30],0x40 (1000_791C / 0x1791C)
    Alu.And8(UInt8[DS, 0x30], 0x40);
    // JZ 0x1000:7924 (1000_7921 / 0x17921)
    if(ZeroFlag) {
      goto label_1000_7924_17924;
    }
    // INC AX (1000_7923 / 0x17923)
    AX = Alu.Inc16(AX);
    label_1000_7924_17924:
    // CALL 0x1000:8865 (1000_7924 / 0x17924)
    NearCall(cs1, 0x7927, spice86_generated_label_call_target_1000_8865_018865);
    // MOV CL,0x96 (1000_7927 / 0x17927)
    CL = 0x96;
    // SUB DX,0x8 (1000_7929 / 0x17929)
    DX -= 0x8;
    // ADD BX,0x9 (1000_792C / 0x1792C)
    // BX += 0x9;
    BX = Alu.Add16(BX, 0x9);
    // MOV DI,word ptr [0x2c] (1000_792F / 0x1792F)
    DI = UInt16[DS, 0x2C];
    // CALL 0x1000:62a6 (1000_7933 / 0x17933)
    NearCall(cs1, 0x7936, spice86_generated_label_call_target_1000_62A6_0162A6);
    // MOV CL,0x9a (1000_7936 / 0x17936)
    CL = 0x9A;
    // ADD BX,0xa (1000_7938 / 0x17938)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    // MOV AL,[0x30] (1000_793B / 0x1793B)
    AL = UInt8[DS, 0x30];
    // TEST AL,0x20 (1000_793E / 0x1793E)
    Alu.And8(AL, 0x20);
    // JZ 0x1000:794c (1000_7940 / 0x17940)
    if(ZeroFlag) {
      goto label_1000_794C_1794C;
    }
    // CMP AL,0x22 (1000_7942 / 0x17942)
    Alu.Sub8(AL, 0x22);
    // MOV AX,0x41 (1000_7944 / 0x17944)
    AX = 0x41;
    // JNZ 0x1000:79b6 (1000_7947 / 0x17947)
    if(!ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // INC AX (1000_7949 / 0x17949)
    AX = Alu.Inc16(AX);
    // JMP 0x1000:79b6 (1000_794A / 0x1794A)
    goto label_1000_79B6_179B6;
    label_1000_794C_1794C:
    // MOV AX,0x3c (1000_794C / 0x1794C)
    AX = 0x3C;
    // CALL 0x1000:8865 (1000_794F / 0x1794F)
    NearCall(cs1, 0x7952, spice86_generated_label_call_target_1000_8865_018865);
    // ADD BX,0xf (1000_7952 / 0x17952)
    BX += 0xF;
    // CMP byte ptr [0x30],0x2 (1000_7955 / 0x17955)
    Alu.Sub8(UInt8[DS, 0x30], 0x2);
    // JZ 0x1000:79bc (1000_795A / 0x1795A)
    if(ZeroFlag) {
      goto label_1000_79BC_179BC;
    }
    // MOV AL,[0x2f] (1000_795C / 0x1795C)
    AL = UInt8[DS, 0x2F];
    // SHR AL,1 (1000_795F / 0x1795F)
    AL >>= 0x1;
    // AND AX,0x6 (1000_7961 / 0x17961)
    AX &= 0x6;
    // ADD AX,0x11f7 (1000_7964 / 0x17964)
    // AX += 0x11F7;
    AX = Alu.Add16(AX, 0x11F7);
    // MOV SI,AX (1000_7967 / 0x17967)
    SI = AX;
    // MOV AX,word ptr [SI] (1000_7969 / 0x17969)
    AX = UInt16[DS, SI];
    // CALL 0x1000:d194 (1000_796B / 0x1796B)
    NearCall(cs1, 0x796E, spice86_generated_label_call_target_1000_D194_01D194);
    // ADD BX,0xa (1000_796E / 0x1796E)
    BX += 0xA;
    // TEST byte ptr [0x30],0x40 (1000_7971 / 0x17971)
    Alu.And8(UInt8[DS, 0x30], 0x40);
    // JNZ 0x1000:79bc (1000_7976 / 0x17976)
    if(!ZeroFlag) {
      goto label_1000_79BC_179BC;
    }
    // MOV AX,0x3f (1000_7978 / 0x17978)
    AX = 0x3F;
    // TEST word ptr [0x32],0x200 (1000_797B / 0x1797B)
    Alu.And16(UInt16[DS, 0x32], 0x200);
    // JNZ 0x1000:79b6 (1000_7981 / 0x17981)
    if(!ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // MOV AX,0x40 (1000_7983 / 0x17983)
    AX = 0x40;
    // TEST word ptr [0x32],0x100 (1000_7986 / 0x17986)
    Alu.And16(UInt16[DS, 0x32], 0x100);
    // JZ 0x1000:79b6 (1000_798C / 0x1798C)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // TEST word ptr [0x34],0x30 (1000_798E / 0x1798E)
    Alu.And16(UInt16[DS, 0x34], 0x30);
    // JNZ 0x1000:79b6 (1000_7994 / 0x17994)
    if(!ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // MOV AX,0x3d (1000_7996 / 0x17996)
    AX = 0x3D;
    // CMP byte ptr [0x30],0x0 (1000_7999 / 0x17999)
    Alu.Sub8(UInt8[DS, 0x30], 0x0);
    // JZ 0x1000:79b6 (1000_799E / 0x1799E)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // MOV AX,0x43 (1000_79A0 / 0x179A0)
    AX = 0x43;
    // CMP byte ptr [0x2f],0x1 (1000_79A3 / 0x179A3)
    Alu.Sub8(UInt8[DS, 0x2F], 0x1);
    // JZ 0x1000:79b6 (1000_79A8 / 0x179A8)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // MOV AX,0x3e (1000_79AA / 0x179AA)
    AX = 0x3E;
    // CMP byte ptr [0x30],0x6 (1000_79AD / 0x179AD)
    Alu.Sub8(UInt8[DS, 0x30], 0x6);
    // JZ 0x1000:79b6 (1000_79B2 / 0x179B2)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    // JMP 0x1000:79bc (1000_79B4 / 0x179B4)
    goto label_1000_79BC_179BC;
    label_1000_79B6_179B6:
    // CALL 0x1000:8865 (1000_79B6 / 0x179B6)
    NearCall(cs1, 0x79B9, spice86_generated_label_call_target_1000_8865_018865);
    // ADD BX,0x11 (1000_79B9 / 0x179B9)
    BX += 0x11;
    label_1000_79BC_179BC:
    // ADD BX,0x4 (1000_79BC / 0x179BC)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    // MOV AX,0x6e (1000_79BF / 0x179BF)
    AX = 0x6E;
    // MOV CL,0x96 (1000_79C2 / 0x179C2)
    CL = 0x96;
    // CALL 0x1000:d194 (1000_79C4 / 0x179C4)
    NearCall(cs1, 0x79C7, spice86_generated_label_call_target_1000_D194_01D194);
    // ADD BX,0x8 (1000_79C7 / 0x179C7)
    // BX += 0x8;
    BX = Alu.Add16(BX, 0x8);
    // MOV SI,word ptr [0x46fa] (1000_79CA / 0x179CA)
    SI = UInt16[DS, 0x46FA];
    // CALL 0x1000:7efb (1000_79CE / 0x179CE)
    NearCall(cs1, 0x79D1, spice86_generated_label_call_target_1000_7EFB_017EFB);
    // MOV SI,0x4705 (1000_79D1 / 0x179D1)
    SI = 0x4705;
    // MOV BP,word ptr [0x18e5] (1000_79D4 / 0x179D4)
    BP = UInt16[DS, 0x18E5];
    // CALL 0x1000:7e3d (1000_79D8 / 0x179D8)
    NearCall(cs1, 0x79DB, spice86_generated_label_call_target_1000_7E3D_017E3D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_79DB_0179DB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_79DB_0179DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_79DB_179DB:
    // JMP 0x1000:c07c (1000_79DB / 0x179DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_79DE_0179DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_79DE_179DE:
    // XOR AX,AX (1000_79DE / 0x179DE)
    AX = 0;
    // XCHG word ptr [0x46fa],AX (1000_79E0 / 0x179E0)
    ushort tmp_1000_79E0 = UInt16[DS, 0x46FA];
    UInt16[DS, 0x46FA] = AX;
    AX = tmp_1000_79E0;
    // OR AX,AX (1000_79E4 / 0x179E4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:79db (1000_79E6 / 0x179E6)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:c07c (1000_79DB / 0x179DB)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x18df (1000_79E8 / 0x179E8)
    SI = 0x18DF;
    // JMP 0x1000:5f9f (1000_79EB / 0x179EB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5F9F_015F9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_79EE_0179EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_79EE_179EE:
    // MOV word ptr [0x46ef],SI (1000_79EE / 0x179EE)
    UInt16[DS, 0x46EF] = SI;
    // CALL 0x1000:6917 (1000_79F2 / 0x179F2)
    NearCall(cs1, 0x79F5, spice86_generated_label_call_target_1000_6917_016917);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_79F5_0179F5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_79F5_0179F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_79F5_179F5:
    // MOV SI,0x18e9 (1000_79F5 / 0x179F5)
    SI = 0x18E9;
    // JNZ 0x1000:7a1e (1000_79F8 / 0x179F8)
    if(!ZeroFlag) {
      goto label_1000_7A1E_17A1E;
    }
    // MOV AX,0x1e (1000_79FA / 0x179FA)
    AX = 0x1E;
    // MOV BX,0x5 (1000_79FD / 0x179FD)
    BX = 0x5;
    // CMP word ptr [DI + 0x2],0x4c (1000_7A00 / 0x17A00)
    Alu.Sub16(UInt16[DS, (ushort)(DI + 0x2)], 0x4C);
    // JGE 0x1000:7a0c (1000_7A04 / 0x17A04)
    if(SignFlag == OverflowFlag) {
      goto label_1000_7A0C_17A0C;
    }
    // MOV AX,0xe (1000_7A06 / 0x17A06)
    AX = 0xE;
    // MOV BX,0x50 (1000_7A09 / 0x17A09)
    BX = 0x50;
    label_1000_7A0C_17A0C:
    // MOV word ptr [SI + 0x2],BX (1000_7A0C / 0x17A0C)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // ADD BX,0x43 (1000_7A0F / 0x17A0F)
    // BX += 0x43;
    BX = Alu.Add16(BX, 0x43);
    // MOV word ptr [SI + 0x6],BX (1000_7A12 / 0x17A12)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV word ptr [0x4710],0x5c (1000_7A15 / 0x17A15)
    UInt16[DS, 0x4710] = 0x5C;
    // MOV [0x4712],AX (1000_7A1B / 0x17A1B)
    UInt16[DS, 0x4712] = AX;
    label_1000_7A1E_17A1E:
    // MOV word ptr [0xdbe0],SI (1000_7A1E / 0x17A1E)
    UInt16[DS, 0xDBE0] = SI;
    // MOV AL,0x2 (1000_7A22 / 0x17A22)
    AL = 0x2;
    // CALL 0x1000:7b0f (1000_7A24 / 0x17A24)
    NearCall(cs1, 0x7A27, spice86_generated_label_call_target_1000_7B0F_017B0F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7A27_017A27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7A27_017A27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7A27_17A27:
    // MOV DI,0x18e9 (1000_7A27 / 0x17A27)
    DI = 0x18E9;
    // MOV SI,0x18f3 (1000_7A2A / 0x17A2A)
    SI = 0x18F3;
    // MOV DX,word ptr [DI] (1000_7A2D / 0x17A2D)
    DX = UInt16[DS, DI];
    // MOV BX,word ptr [DI + 0x2] (1000_7A2F / 0x17A2F)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV AX,DX (1000_7A32 / 0x17A32)
    AX = DX;
    // ADD AX,0x49 (1000_7A34 / 0x17A34)
    // AX += 0x49;
    AX = Alu.Add16(AX, 0x49);
    // MOV [0x2244],AX (1000_7A37 / 0x17A37)
    UInt16[DS, 0x2244] = AX;
    // ADD BX,0x3 (1000_7A3A / 0x17A3A)
    // BX += 0x3;
    BX = Alu.Add16(BX, 0x3);
    // MOV word ptr [0x2246],BX (1000_7A3D / 0x17A3D)
    UInt16[DS, 0x2246] = BX;
    // XOR AX,AX (1000_7A41 / 0x17A41)
    AX = 0;
    // MOV [0x4784],AX (1000_7A43 / 0x17A43)
    UInt16[DS, 0x4784] = AX;
    // MOV word ptr [0x4786],0x5 (1000_7A46 / 0x17A46)
    UInt16[DS, 0x4786] = 0x5;
    // MOV [0x4788],AX (1000_7A4C / 0x17A4C)
    UInt16[DS, 0x4788] = AX;
    // INC AX (1000_7A4F / 0x17A4F)
    AX = Alu.Inc16(AX);
    // MOV [0x478a],AX (1000_7A50 / 0x17A50)
    UInt16[DS, 0x478A] = AX;
    // ADD DX,0x4 (1000_7A53 / 0x17A53)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // MOV word ptr [SI],DX (1000_7A56 / 0x17A56)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_7A58 / 0x17A58)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // ADD DX,0x3d (1000_7A5B / 0x17A5B)
    DX += 0x3D;
    // ADD BX,0x3d (1000_7A5E / 0x17A5E)
    // BX += 0x3D;
    BX = Alu.Add16(BX, 0x3D);
    // MOV word ptr [SI + 0x4],DX (1000_7A61 / 0x17A61)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    // MOV word ptr [SI + 0x6],BX (1000_7A64 / 0x17A64)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // CALL 0x1000:7b1b (1000_7A67 / 0x17A67)
    NearCall(cs1, 0x7A6A, spice86_generated_label_call_target_1000_7B1B_017B1B);
    label_1000_7A6A_17A6A:
    // MOV SI,word ptr [0x46ef] (1000_7A6A / 0x17A6A)
    SI = UInt16[DS, 0x46EF];
    // TEST byte ptr [SI + 0x3],0x20 (1000_7A6E / 0x17A6E)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JZ 0x1000:7a96 (1000_7A72 / 0x17A72)
    if(ZeroFlag) {
      goto label_1000_7A96_17A96;
    }
    // MOV DI,word ptr [SI + 0x4] (1000_7A74 / 0x17A74)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [DI + 0xa],0x2 (1000_7A77 / 0x17A77)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:7a82 (1000_7A7B / 0x17A7B)
    if(!ZeroFlag) {
      goto label_1000_7A82_17A82;
    }
    // CALL 0x1000:5d36 (1000_7A7D / 0x17A7D)
    NearCall(cs1, 0x7A80, spice86_generated_label_call_target_1000_5D36_015D36);
    // JC 0x1000:7a96 (1000_7A80 / 0x17A80)
    if(CarryFlag) {
      goto label_1000_7A96_17A96;
    }
    label_1000_7A82_17A82:
    // MOV AX,0xc (1000_7A82 / 0x17A82)
    AX = 0xC;
    // MOV [0x47c4],AX (1000_7A85 / 0x17A85)
    UInt16[DS, 0x47C4] = AX;
    // CALL 0x1000:91a0 (1000_7A88 / 0x17A88)
    NearCall(cs1, 0x7A8B, spice86_generated_label_call_target_1000_91A0_0191A0);
    // CALL 0x1000:c0f4 (1000_7A8B / 0x17A8B)
    NearCall(cs1, 0x7A8E, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // MOV AX,0xc (1000_7A8E / 0x17A8E)
    AX = 0xC;
    // MOV BP,0x0 (1000_7A91 / 0x17A91)
    BP = 0x0;
    // JMP 0x1000:7ac1 (1000_7A94 / 0x17A94)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7AAB_017AAB, 0x17AC1 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_7A96_17A96:
    // MOV AX,0xf (1000_7A96 / 0x17A96)
    AX = 0xF;
    // MOV [0x47c4],AX (1000_7A99 / 0x17A99)
    UInt16[DS, 0x47C4] = AX;
    // MOV word ptr [0x4758],SI (1000_7A9C / 0x17A9C)
    UInt16[DS, 0x4758] = SI;
    // MOV byte ptr [0x476c],0x0 (1000_7AA0 / 0x17AA0)
    UInt8[DS, 0x476C] = 0x0;
    // CALL 0x1000:91a0 (1000_7AA5 / 0x17AA5)
    NearCall(cs1, 0x7AA8, spice86_generated_label_call_target_1000_91A0_0191A0);
    label_1000_7AA8_17AA8:
    // CALL 0x1000:c0f4 (1000_7AA8 / 0x17AA8)
    NearCall(cs1, 0x7AAB, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7AAB_017AAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7AAB_017AAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7AAB_17AAB:
    // MOV AX,[0x22a6] (1000_7AAB / 0x17AAB)
    AX = UInt16[DS, 0x22A6];
    // SUB AX,0xe (1000_7AAE / 0x17AAE)
    AX -= 0xE;
    // SHL AX,1 (1000_7AB1 / 0x17AB1)
    AX <<= 0x1;
    // SHL AX,1 (1000_7AB3 / 0x17AB3)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BL,byte ptr [0x47d0] (1000_7AB5 / 0x17AB5)
    BL = UInt8[DS, 0x47D0];
    // DEC BL (1000_7AB9 / 0x17AB9)
    BL--;
    // XOR BH,BH (1000_7ABB / 0x17ABB)
    BH = 0;
    // SHL BX,1 (1000_7ABD / 0x17ABD)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV BP,BX (1000_7ABF / 0x17ABF)
    BP = BX;
    label_1000_7AC1_17AC1:
    // MOV SI,0x22b9 (1000_7AC1 / 0x17AC1)
    SI = 0x22B9;
    // ADD SI,AX (1000_7AC4 / 0x17AC4)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // LODSW SI (1000_7AC6 / 0x17AC6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV [0x46d2],AX (1000_7AC7 / 0x17AC7)
    UInt16[DS, 0x46D2] = AX;
    // LODSW SI (1000_7ACA / 0x17ACA)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV [0x46d4],AX (1000_7ACB / 0x17ACB)
    UInt16[DS, 0x46D4] = AX;
    // PUSH DS (1000_7ACE / 0x17ACE)
    Stack.Push(DS);
    // MOV SI,word ptr SS:[0x47ca] (1000_7ACF / 0x17ACF)
    SI = UInt16[SS, 0x47CA];
    // MOV DS,word ptr SS:[0xdbb2] (1000_7AD4 / 0x17AD4)
    DS = UInt16[SS, 0xDBB2];
    // ADD SI,word ptr DS:[BP + SI] (1000_7AD9 / 0x17AD9)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // MOV DX,word ptr SS:[0x18f3] (1000_7ADC / 0x17ADC)
    DX = UInt16[SS, 0x18F3];
    // MOV BX,word ptr SS:[0x18f5] (1000_7AE1 / 0x17AE1)
    BX = UInt16[SS, 0x18F5];
    // INC BX (1000_7AE6 / 0x17AE6)
    BX++;
    // INC DX (1000_7AE7 / 0x17AE7)
    DX = Alu.Inc16(DX);
    // MOV word ptr SS:[0x47d4],DX (1000_7AE8 / 0x17AE8)
    UInt16[SS, 0x47D4] = DX;
    // MOV word ptr SS:[0x47d6],BX (1000_7AED / 0x17AED)
    UInt16[SS, 0x47D6] = BX;
    // ADD DX,0x3b (1000_7AF2 / 0x17AF2)
    DX += 0x3B;
    // ADD BX,0x3b (1000_7AF5 / 0x17AF5)
    // BX += 0x3B;
    BX = Alu.Add16(BX, 0x3B);
    // MOV word ptr SS:[0x47d8],DX (1000_7AF8 / 0x17AF8)
    UInt16[SS, 0x47D8] = DX;
    // MOV word ptr SS:[0x47da],BX (1000_7AFD / 0x17AFD)
    UInt16[SS, 0x47DA] = BX;
    // CALL 0x1000:9d6a (1000_7B02 / 0x17B02)
    NearCall(cs1, 0x7B05, spice86_generated_label_call_target_1000_9D6A_019D6A);
    label_1000_7B05_17B05:
    // POP DS (1000_7B05 / 0x17B05)
    DS = Stack.Pop();
    // MOV SI,0x47d4 (1000_7B06 / 0x17B06)
    SI = 0x47D4;
    // CALL 0x1000:c4aa (1000_7B09 / 0x17B09)
    NearCall(cs1, 0x7B0C, spice86_generated_label_call_target_1000_C4AA_01C4AA);
    label_1000_7B0C_17B0C:
    // JMP 0x1000:c13b (1000_7B0C / 0x17B0C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B0F_017B0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B0F_17B0F:
    // MOV byte ptr [0x46d8],0x0 (1000_7B0F / 0x17B0F)
    UInt8[DS, 0x46D8] = 0x0;
    // PUSH SI (1000_7B14 / 0x17B14)
    Stack.Push(SI);
    // XCHG DI,SI (1000_7B15 / 0x17B15)
    ushort tmp_1000_7B15 = DI;
    DI = SI;
    SI = tmp_1000_7B15;
    // CALL 0x1000:c0e8 (1000_7B17 / 0x17B17)
    NearCall(cs1, 0x7B1A, spice86_generated_label_call_target_1000_C0E8_01C0E8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B1A_017B1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B1A_017B1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B1A_17B1A:
    // POP SI (1000_7B1A / 0x17B1A)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B1B_017B1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B1B_017B1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B1B_17B1B:
    // MOV ES,word ptr [0xdbda] (1000_7B1B / 0x17B1B)
    ES = UInt16[DS, 0xDBDA];
    // MOV AL,byte ptr [SI + 0x9] (1000_7B1F / 0x17B1F)
    AL = UInt8[DS, (ushort)(SI + 0x9)];
    // PUSH SI (1000_7B22 / 0x17B22)
    Stack.Push(SI);
    // CALLF [0x38dd] (1000_7B23 / 0x17B23)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_7B23 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_7B23) {
      case 0x235CE : FarCall(cs1, 0x7B27, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_7B23));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B27_017B27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B27_017B27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B27_17B27:
    // POP SI (1000_7B27 / 0x17B27)
    SI = Stack.Pop();
    // JMP 0x1000:c551 (1000_7B28 / 0x17B28)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C551_01C551, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B2B_017B2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B2B_17B2B:
    // CMP byte ptr [0x46d8],0x0 (1000_7B2B / 0x17B2B)
    Alu.Sub8(UInt8[DS, 0x46D8], 0x0);
    // JNZ 0x1000:7b35 (1000_7B30 / 0x17B30)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_7B35 / 0x17B35)
      return NearRet();
    }
    // JMP 0x1000:c0e8 (1000_7B32 / 0x17B32)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0E8_01C0E8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_7B35_17B35:
    // RET  (1000_7B35 / 0x17B35)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B36_017B36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B36_17B36:
    // PUSH SI (1000_7B36 / 0x17B36)
    Stack.Push(SI);
    // PUSH DI (1000_7B37 / 0x17B37)
    Stack.Push(DI);
    // MOV byte ptr [0x46d8],0x1 (1000_7B38 / 0x17B38)
    UInt8[DS, 0x46D8] = 0x1;
    // MOV byte ptr [0xdce6],0x80 (1000_7B3D / 0x17B3D)
    UInt8[DS, 0xDCE6] = 0x80;
    // CALL 0x1000:8770 (1000_7B42 / 0x17B42)
    NearCall(cs1, 0x7B45, spice86_generated_label_call_target_1000_8770_018770);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B45_017B45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B45_017B45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B45_17B45:
    // CALL 0x1000:5f79 (1000_7B45 / 0x17B45)
    NearCall(cs1, 0x7B48, spice86_generated_label_call_target_1000_5F79_015F79);
    label_1000_7B48_17B48:
    // CALL 0x1000:79de (1000_7B48 / 0x17B48)
    NearCall(cs1, 0x7B4B, spice86_generated_label_call_target_1000_79DE_0179DE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B4B_017B4B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B4B_017B4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B4B_17B4B:
    // MOV byte ptr [0xdce6],0x0 (1000_7B4B / 0x17B4B)
    UInt8[DS, 0xDCE6] = 0x0;
    // MOV byte ptr [0x46f4],0x0 (1000_7B50 / 0x17B50)
    UInt8[DS, 0x46F4] = 0x0;
    // POP DI (1000_7B55 / 0x17B55)
    DI = Stack.Pop();
    // POP SI (1000_7B56 / 0x17B56)
    SI = Stack.Pop();
    // RET  (1000_7B57 / 0x17B57)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B58_017B58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B58_17B58:
    // MOV word ptr [0x1bea],0x0 (1000_7B58 / 0x17B58)
    UInt16[DS, 0x1BEA] = 0x0;
    // MOV byte ptr [0x46f4],0x0 (1000_7B5E / 0x17B5E)
    UInt8[DS, 0x46F4] = 0x0;
    // XOR SI,SI (1000_7B63 / 0x17B63)
    SI = 0;
    // MOV byte ptr [0x4c],0x0 (1000_7B65 / 0x17B65)
    UInt8[DS, 0x4C] = 0x0;
    // XCHG word ptr [0x46ef],SI (1000_7B6A / 0x17B6A)
    ushort tmp_1000_7B6A = UInt16[DS, 0x46EF];
    UInt16[DS, 0x46EF] = SI;
    SI = tmp_1000_7B6A;
    // OR SI,SI (1000_7B6E / 0x17B6E)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:7ba2 (1000_7B70 / 0x17B70)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_7BA2 / 0x17BA2)
      return NearRet();
    }
    // CMP byte ptr [0x4c],0x0 (1000_7B72 / 0x17B72)
    Alu.Sub8(UInt8[DS, 0x4C], 0x0);
    // JNZ 0x1000:7b8c (1000_7B77 / 0x17B77)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B89_017B89, 0x17B8C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:1ebe (1000_7B79 / 0x17B79)
    NearCall(cs1, 0x7B7C, spice86_generated_label_call_target_1000_1EBE_011EBE);
    label_1000_7B7C_17B7C:
    // AND word ptr [SI + 0x10],0x3f0 (1000_7B7C / 0x17B7C)
    UInt16[DS, (ushort)(SI + 0x10)] &= 0x3F0;
    // AND word ptr [SI + 0x12],0xe5ff (1000_7B81 / 0x17B81)
    // UInt16[DS, (ushort)(SI + 0x12)] &= 0xE5FF;
    UInt16[DS, (ushort)(SI + 0x12)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0xE5FF);
    // CALL 0x1000:1ac5 (1000_7B86 / 0x17B86)
    NearCall(cs1, 0x7B89, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B89_017B89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B89_017B89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7B89_17B89:
    // MOV byte ptr [SI + 0x14],AL (1000_7B89 / 0x17B89)
    UInt8[DS, (ushort)(SI + 0x14)] = AL;
    label_1000_7B8C_17B8C:
    // CALL 0x1000:a7a5 (1000_7B8C / 0x17B8C)
    NearCall(cs1, 0x7B8F, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B8F_017B8F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B8F_017B8F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x7BA2: goto label_1000_7BA2_17BA2;break; // Target of external jump from 0x17B70
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_7B8F_17B8F:
    // MOV SI,0x18e9 (1000_7B8F / 0x17B8F)
    SI = 0x18E9;
    // XOR AX,AX (1000_7B92 / 0x17B92)
    AX = 0;
    // MOV [0xdbe0],AX (1000_7B94 / 0x17B94)
    UInt16[DS, 0xDBE0] = AX;
    // MOV [0x47ba],AX (1000_7B97 / 0x17B97)
    UInt16[DS, 0x47BA] = AX;
    // CALL 0x1000:c6ad (1000_7B9A / 0x17B9A)
    NearCall(cs1, 0x7B9D, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    label_1000_7B9D_17B9D:
    // MOV AL,0x4 (1000_7B9D / 0x17B9D)
    AL = 0x4;
    // CALL 0x1000:7b2b (1000_7B9F / 0x17B9F)
    NearCall(cs1, 0x7BA2, spice86_generated_label_call_target_1000_7B2B_017B2B);
    label_1000_7BA2_17BA2:
    // RET  (1000_7BA2 / 0x17BA2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7BA3_017BA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BA3_17BA3:
    // CALL 0x1000:c08e (1000_7BA3 / 0x17BA3)
    NearCall(cs1, 0x7BA6, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BA6_017BA6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BA6_017BA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BA6_17BA6:
    // CMP SI,word ptr [0x46ef] (1000_7BA6 / 0x17BA6)
    Alu.Sub16(SI, UInt16[DS, 0x46EF]);
    // JZ 0x1000:7bb8 (1000_7BAA / 0x17BAA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_7BB8 / 0x17BB8)
      return NearRet();
    }
    // PUSH SI (1000_7BAC / 0x17BAC)
    Stack.Push(SI);
    // MOV word ptr [0x46f1],SI (1000_7BAD / 0x17BAD)
    UInt16[DS, 0x46F1] = SI;
    // CALL 0x1000:79ee (1000_7BB1 / 0x17BB1)
    NearCall(cs1, 0x7BB4, spice86_generated_label_call_target_1000_79EE_0179EE);
    label_1000_7BB4_17BB4:
    // CALL 0x1000:9f40 (1000_7BB4 / 0x17BB4)
    NearCall(cs1, 0x7BB7, spice86_generated_label_call_target_1000_9F40_019F40);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BB7_017BB7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BB7_017BB7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x7BB8: goto label_1000_7BB8_17BB8;break; // Target of external jump from 0x17BAA
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_7BB7_17BB7:
    // POP SI (1000_7BB7 / 0x17BB7)
    SI = Stack.Pop();
    label_1000_7BB8_17BB8:
    // RET  (1000_7BB8 / 0x17BB8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7BB9_017BB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BB9_17BB9:
    // PUSH AX (1000_7BB9 / 0x17BB9)
    Stack.Push(AX);
    // CALL 0x1000:31f6 (1000_7BBA / 0x17BBA)
    NearCall(cs1, 0x7BBD, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BBD_017BBD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BBD_017BBD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BBD_17BBD:
    // POP AX (1000_7BBD / 0x17BBD)
    AX = Stack.Pop();
    // MOV word ptr [0x46f1],SI (1000_7BBE / 0x17BBE)
    UInt16[DS, 0x46F1] = SI;
    // MOV [0x23],AL (1000_7BC2 / 0x17BC2)
    UInt8[DS, 0x23] = AL;
    // MOV word ptr [0x47ba],0x0 (1000_7BC5 / 0x17BC5)
    UInt16[DS, 0x47BA] = 0x0;
    // CALL 0x1000:c08e (1000_7BCB / 0x17BCB)
    NearCall(cs1, 0x7BCE, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BCE_017BCE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BCE_017BCE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BCE_17BCE:
    // MOV AX,0xf (1000_7BCE / 0x17BCE)
    AX = 0xF;
    // CALL 0x1000:96f1 (1000_7BD1 / 0x17BD1)
    NearCall(cs1, 0x7BD4, spice86_generated_label_call_target_1000_96F1_0196F1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BD4_017BD4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BD4_017BD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BD4_17BD4:
    // JC 0x1000:7bd9 (1000_7BD4 / 0x17BD4)
    if(CarryFlag) {
      goto label_1000_7BD9_17BD9;
    }
    // CALL 0x1000:9efd (1000_7BD6 / 0x17BD6)
    NearCall(cs1, 0x7BD9, spice86_generated_label_call_target_1000_9EFD_019EFD);
    label_1000_7BD9_17BD9:
    // MOV SI,word ptr [0x46f1] (1000_7BD9 / 0x17BD9)
    SI = UInt16[DS, 0x46F1];
    // JMP 0x1000:7c56 (1000_7BDD / 0x17BDD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C56_017C56, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7BE0_017BE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BE0_17BE0:
    // CMP SI,word ptr [0x46ef] (1000_7BE0 / 0x17BE0)
    Alu.Sub16(SI, UInt16[DS, 0x46EF]);
    // JZ 0x1000:7be7 (1000_7BE4 / 0x17BE4)
    if(ZeroFlag) {
      goto label_1000_7BE7_17BE7;
    }
    // RET  (1000_7BE6 / 0x17BE6)
    return NearRet();
    label_1000_7BE7_17BE7:
    // MOV word ptr [0x47ba],0x0 (1000_7BE7 / 0x17BE7)
    UInt16[DS, 0x47BA] = 0x0;
    // CMP byte ptr [0x46f4],0x0 (1000_7BED / 0x17BED)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    // JZ 0x1000:7bfe (1000_7BF2 / 0x17BF2)
    if(ZeroFlag) {
      goto label_1000_7BFE_17BFE;
    }
    // CMP byte ptr [0x46f5],0x0 (1000_7BF4 / 0x17BF4)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    // JZ 0x1000:7bfe (1000_7BF9 / 0x17BF9)
    if(ZeroFlag) {
      goto label_1000_7BFE_17BFE;
    }
    // JMP 0x1000:7e97 (1000_7BFB / 0x17BFB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E97_017E97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_7BFE_17BFE:
    // MOV SI,word ptr [0x46ef] (1000_7BFE / 0x17BFE)
    SI = UInt16[DS, 0x46EF];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7C02_017C02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7C02_017C02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C02_17C02:
    // CALL 0x1000:7ba3 (1000_7C02 / 0x17C02)
    NearCall(cs1, 0x7C05, spice86_generated_label_call_target_1000_7BA3_017BA3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C05_017C05, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C05_017C05(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C05_17C05:
    // CALL 0x1000:31f6 (1000_7C05 / 0x17C05)
    NearCall(cs1, 0x7C08, spice86_generated_label_call_target_1000_31F6_0131F6);
    label_1000_7C08_17C08:
    // MOV DI,word ptr [SI + 0x4] (1000_7C08 / 0x17C08)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:2e98 (1000_7C0B / 0x17C0B)
    NearCall(cs1, 0x7C0E, spice86_generated_label_call_target_1000_2E98_012E98);
    label_1000_7C0E_17C0E:
    // CALL 0x1000:7c63 (1000_7C0E / 0x17C0E)
    NearCall(cs1, 0x7C11, spice86_generated_label_call_target_1000_7C63_017C63);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C11_017C11, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C11_017C11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C11_17C11:
    // CMP AX,word ptr [0x1176] (1000_7C11 / 0x17C11)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    // JBE 0x1000:7c2d (1000_7C15 / 0x17C15)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C2D_017C2D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [0x4c],0xff (1000_7C17 / 0x17C17)
    UInt8[DS, 0x4C] = 0xFF;
    // MOV DI,word ptr [0x4752] (1000_7C1C / 0x17C1C)
    DI = UInt16[DS, 0x4752];
    // OR DI,DI (1000_7C20 / 0x17C20)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:7c2d (1000_7C22 / 0x17C22)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C2D_017C2D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,0x1916 (1000_7C24 / 0x17C24)
    AX = 0x1916;
    // MOV word ptr [DI + 0xd],AX (1000_7C27 / 0x17C27)
    UInt16[DS, (ushort)(DI + 0xD)] = AX;
    // MOV word ptr [DI + 0xf],AX (1000_7C2A / 0x17C2A)
    UInt16[DS, (ushort)(DI + 0xF)] = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C2D_017C2D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7C2D_017C2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C2D_17C2D:
    // CALL 0x1000:9719 (1000_7C2D / 0x17C2D)
    NearCall(cs1, 0x7C30, spice86_generated_label_call_target_1000_9719_019719);
    label_1000_7C30_17C30:
    // MOV SI,word ptr [0x46ef] (1000_7C30 / 0x17C30)
    SI = UInt16[DS, 0x46EF];
    // JC 0x1000:7c2d (1000_7C34 / 0x17C34)
    if(CarryFlag) {
      goto label_1000_7C2D_17C2D;
    }
    // PUSH SI (1000_7C36 / 0x17C36)
    Stack.Push(SI);
    // CALL 0x1000:9efd (1000_7C37 / 0x17C37)
    NearCall(cs1, 0x7C3A, spice86_generated_label_call_target_1000_9EFD_019EFD);
    label_1000_7C3A_17C3A:
    // POP SI (1000_7C3A / 0x17C3A)
    SI = Stack.Pop();
    // MOV byte ptr [0x46f4],0x0 (1000_7C3B / 0x17C3B)
    UInt8[DS, 0x46F4] = 0x0;
    // CMP byte ptr [0x47a5],0x80 (1000_7C40 / 0x17C40)
    Alu.Sub8(UInt8[DS, 0x47A5], 0x80);
    // JNZ 0x1000:7c56 (1000_7C45 / 0x17C45)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C56_017C56, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // INC byte ptr [0x46f4] (1000_7C47 / 0x17C47)
    UInt8[DS, 0x46F4] = Alu.Inc8(UInt8[DS, 0x46F4]);
    // CALL 0x1000:7efb (1000_7C4B / 0x17C4B)
    NearCall(cs1, 0x7C4E, spice86_generated_label_call_target_1000_7EFB_017EFB);
    label_1000_7C4E_17C4E:
    // PUSH SI (1000_7C4E / 0x17C4E)
    Stack.Push(SI);
    // CALL 0x1000:7e1e (1000_7C4F / 0x17C4F)
    NearCall(cs1, 0x7C52, spice86_generated_label_call_target_1000_7E1E_017E1E);
    label_1000_7C52_17C52:
    // POP SI (1000_7C52 / 0x17C52)
    SI = Stack.Pop();
    // JMP 0x1000:7c56 (1000_7C53 / 0x17C53)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C56_017C56, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
