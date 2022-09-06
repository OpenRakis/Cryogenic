namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_A72A_01A72A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A72A_1A72A:
    // CALL 0x1000:a7a5 (1000_A72A / 0x1A72A)
    NearCall(cs1, 0xA72D, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A72D_01A72D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA788: goto label_1000_A788_1A788;break; // Target of external jump from 0x1A7C5, 0x1A7B7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_A72D_1A72D:
    // POP AX (1000_A72D / 0x1A72D)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:9123 (1000_A72E / 0x1A72E)
    NearCall(cs1, 0xA731, spice86_generated_label_call_target_1000_9123_019123);
    State.IncCycles();
    label_1000_A731_1A731:
    // SHL AX,1 (1000_A731 / 0x1A731)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_A733 / 0x1A733)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_A735 / 0x1A735)
    AX <<= 0x1;
    State.IncCycles();
    // ADD AX,0x27fa (1000_A737 / 0x1A737)
    // AX += 0x27FA;
    AX = Alu.Add16(AX, 0x27FA);
    State.IncCycles();
    // MOV SI,AX (1000_A73A / 0x1A73A)
    SI = AX;
    State.IncCycles();
    // MOV word ptr [0xdc28],SI (1000_A73C / 0x1A73C)
    UInt16[DS, 0xDC28] = SI;
    State.IncCycles();
    label_1000_A740_1A740:
    // MOV byte ptr [0xdc2a],0xff (1000_A740 / 0x1A740)
    UInt8[DS, 0xDC2A] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:a83f (1000_A745 / 0x1A745)
    NearCall(cs1, 0xA748, spice86_generated_label_call_target_1000_A83F_01A83F);
    State.IncCycles();
    label_1000_A748_1A748:
    // JC 0x1000:a754 (1000_A748 / 0x1A748)
    if(CarryFlag) {
      goto label_1000_A754_1A754;
    }
    State.IncCycles();
    // XOR byte ptr [0x37e2],0x6 (1000_A74A / 0x1A74A)
    // UInt8[DS, 0x37E2] ^= 0x6;
    UInt8[DS, 0x37E2] = Alu.Xor8(UInt8[DS, 0x37E2], 0x6);
    State.IncCycles();
    // CALL 0x1000:a83f (1000_A74F / 0x1A74F)
    NearCall(cs1, 0xA752, spice86_generated_label_call_target_1000_A83F_01A83F);
    State.IncCycles();
    label_1000_A752_1A752:
    // JNC 0x1000:a75b (1000_A752 / 0x1A752)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A75B / 0x1A75B)
      return NearRet();
    }
    State.IncCycles();
    label_1000_A754_1A754:
    // CALL 0x1000:ade0 (1000_A754 / 0x1A754)
    NearCall(cs1, 0xA757, spice86_generated_label_call_target_1000_ADE0_01ADE0);
    State.IncCycles();
    // CALL 0x1000:d617 (1000_A757 / 0x1A757)
    NearCall(cs1, 0xA75A, not_observed_1000_D617_01D617);
    State.IncCycles();
    // STC  (1000_A75A / 0x1A75A)
    CarryFlag = true;
    State.IncCycles();
    label_1000_A75B_1A75B:
    // RET  (1000_A75B / 0x1A75B)
    return NearRet();
    State.IncCycles();
    label_1000_A75C_1A75C:
    // CALL 0x1000:9197 (1000_A75C / 0x1A75C)
    NearCall(cs1, 0xA75F, spice86_generated_label_call_target_1000_9197_019197);
    State.IncCycles();
    // MOV BP,0x0 (1000_A75F / 0x1A75F)
    BP = 0x0;
    State.IncCycles();
    // MOV SI,0xa7c2 (1000_A762 / 0x1A762)
    SI = 0xA7C2;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_A765 / 0x1A765)
    NearCall(cs1, 0xA768, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    // MOV byte ptr [0xdc2b],0x1 (1000_A768 / 0x1A768)
    UInt8[DS, 0xDC2B] = 0x1;
    State.IncCycles();
    // MOV SI,0x3811 (1000_A76D / 0x1A76D)
    SI = 0x3811;
    State.IncCycles();
    // CALLF [0x3991] (1000_A770 / 0x1A770)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_A770 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_A770) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A770));
        break;
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_A774 / 0x1A774)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc2c],AX (1000_A777 / 0x1A777)
    UInt16[DS, 0xDC2C] = AX;
    State.IncCycles();
    // MOV word ptr [0xdc2e],0x8000 (1000_A77A / 0x1A77A)
    UInt16[DS, 0xDC2E] = 0x8000;
    State.IncCycles();
    // CALL 0x1000:a814 (1000_A780 / 0x1A780)
    NearCall(cs1, 0xA783, not_observed_1000_A814_01A814);
    State.IncCycles();
    // JNC 0x1000:a788 (1000_A783 / 0x1A783)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:a82e (1000_A785 / 0x1A785)
    NearCall(cs1, 0xA788, not_observed_1000_A82E_01A82E);
    State.IncCycles();
    label_1000_A788_1A788:
    // RET  (1000_A788 / 0x1A788)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_A789_01A789(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A789_1A789:
    // XOR AX,AX (1000_A789 / 0x1A789)
    AX = 0;
    State.IncCycles();
    // XCHG word ptr [0xdc30],AX (1000_A78B / 0x1A78B)
    ushort tmp_1000_A78B = UInt16[DS, 0xDC30];
    UInt16[DS, 0xDC30] = AX;
    AX = tmp_1000_A78B;
    State.IncCycles();
    // OR AX,AX (1000_A78F / 0x1A78F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:a7a5 (1000_A791 / 0x1A791)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A7A5_01A7A5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH AX (1000_A793 / 0x1A793)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:a7a5 (1000_A794 / 0x1A794)
    NearCall(cs1, 0xA797, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    State.IncCycles();
    // POP AX (1000_A797 / 0x1A797)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD AX,word ptr [0xd810] (1000_A798 / 0x1A798)
    // AX += UInt16[DS, 0xD810];
    AX = Alu.Add16(AX, UInt16[DS, 0xD810]);
    State.IncCycles();
    // MOV BL,0xe (1000_A79C / 0x1A79C)
    BL = 0xE;
    State.IncCycles();
    // CALL 0x1000:a6cc (1000_A79E / 0x1A79E)
    NearCall(cs1, 0xA7A1, spice86_generated_label_call_target_1000_A6CC_01A6CC);
    State.IncCycles();
    // JNC 0x1000:a788 (1000_A7A1 / 0x1A7A1)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:a75c (1000_A7A3 / 0x1A7A3)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0x1A75C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A7A5_01A7A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A7A5_1A7A5:
    // MOV SI,0xa7c2 (1000_A7A5 / 0x1A7A5)
    SI = 0xA7C2;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_A7A8 / 0x1A7A8)
    NearCall(cs1, 0xA7AB, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A7AB_01A7AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A7AB_01A7AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A7AB_1A7AB:
    // MOV word ptr [0xdc26],0x0 (1000_A7AB / 0x1A7AB)
    UInt16[DS, 0xDC26] = 0x0;
    State.IncCycles();
    // CALL 0x1000:d61d (1000_A7B1 / 0x1A7B1)
    NearCall(cs1, 0xA7B4, spice86_generated_label_call_target_1000_D61D_01D61D);
    State.IncCycles();
    label_1000_A7B4_1A7B4:
    // CALL 0x1000:abcc (1000_A7B4 / 0x1A7B4)
    NearCall(cs1, 0xA7B7, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    State.IncCycles();
    label_1000_A7B7_1A7B7:
    // JZ 0x1000:a788 (1000_A7B7 / 0x1A7B7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:abc6 (1000_A7B9 / 0x1A7B9)
    NearCall(cs1, 0xA7BC, spice86_generated_label_jump_target_1000_ABC6_01ABC6);
    State.IncCycles();
    // CALL 0x1000:a9a1 (1000_A7BC / 0x1A7BC)
    NearCall(cs1, 0xA7BF, spice86_generated_label_call_target_1000_A9A1_01A9A1);
    State.IncCycles();
    // JMP 0x1000:aded (1000_A7BF / 0x1A7BF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ADED_01ADED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A7C2_01A7C2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A7C2_1A7C2:
    // CALL 0x1000:abcc (1000_A7C2 / 0x1A7C2)
    NearCall(cs1, 0xA7C5, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A7C5_01A7C5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A7C5_01A7C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A7C5_1A7C5:
    // JZ 0x1000:a788 (1000_A7C5 / 0x1A7C5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0xdc26],0x0 (1000_A7C7 / 0x1A7C7)
    Alu.Sub16(UInt16[DS, 0xDC26], 0x0);
    State.IncCycles();
    // JNZ 0x1000:a7d5 (1000_A7CC / 0x1A7CC)
    if(!ZeroFlag) {
      goto label_1000_A7D5_1A7D5;
    }
    State.IncCycles();
    // CALL 0x1000:a9e7 (1000_A7CE / 0x1A7CE)
    NearCall(cs1, 0xA7D1, pcm_test_audio_done_ida_1000_A9E7_1A9E7);
    State.IncCycles();
    // JNZ 0x1000:a789 (1000_A7D1 / 0x1A7D1)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A789_01A789, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:a811 (1000_A7D3 / 0x1A7D3)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x1000:a9b9 (1000_A811 / 0x1A811)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_A9B9_01A9B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_A7D5_1A7D5:
    // MOV DX,word ptr [0xce7a] (1000_A7D5 / 0x1A7D5)
    DX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // XOR DI,DI (1000_A7D9 / 0x1A7D9)
    DI = 0;
    State.IncCycles();
    // MOV BX,word ptr [0xdc2c] (1000_A7DB / 0x1A7DB)
    BX = UInt16[DS, 0xDC2C];
    State.IncCycles();
    // MOV BP,word ptr [0xdc2e] (1000_A7DF / 0x1A7DF)
    BP = UInt16[DS, 0xDC2E];
    State.IncCycles();
    // MOV CX,word ptr [0x2882] (1000_A7E3 / 0x1A7E3)
    CX = UInt16[DS, 0x2882];
    State.IncCycles();
    // MOV SI,word ptr [0x2884] (1000_A7E7 / 0x1A7E7)
    SI = UInt16[DS, 0x2884];
    State.IncCycles();
    // ADD BP,SI (1000_A7EB / 0x1A7EB)
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    State.IncCycles();
    // ADC BX,CX (1000_A7ED / 0x1A7ED)
    BX = Alu.Adc16(BX, CX);
    State.IncCycles();
    // SUB DX,BX (1000_A7EF / 0x1A7EF)
    // DX -= BX;
    DX = Alu.Sub16(DX, BX);
    State.IncCycles();
    // JS 0x1000:a811 (1000_A7F1 / 0x1A7F1)
    if(SignFlag) {
      // JS target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:a9b9 (1000_A811 / 0x1A811)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A9B9_01A9B9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_A7F3_1A7F3:
    // PUSH DI (1000_A7F3 / 0x1A7F3)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:a814 (1000_A7F4 / 0x1A7F4)
    NearCall(cs1, 0xA7F7, not_observed_1000_A814_01A814);
    State.IncCycles();
    // POP DI (1000_A7F7 / 0x1A7F7)
    DI = Stack.Pop();
    State.IncCycles();
    // JNC 0x1000:a789 (1000_A7F8 / 0x1A7F8)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A789_01A789, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // SUB DI,SI (1000_A7FA / 0x1A7FA)
    // DI -= SI;
    DI = Alu.Sub16(DI, SI);
    State.IncCycles();
    // SBB DX,CX (1000_A7FC / 0x1A7FC)
    DX = Alu.Sbb16(DX, CX);
    State.IncCycles();
    // JC 0x1000:a806 (1000_A7FE / 0x1A7FE)
    if(CarryFlag) {
      goto label_1000_A806_1A806;
    }
    State.IncCycles();
    // ADD BP,SI (1000_A800 / 0x1A800)
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    State.IncCycles();
    // ADC BX,CX (1000_A802 / 0x1A802)
    BX = Alu.Adc16(BX, CX);
    State.IncCycles();
    // JMP 0x1000:a7f3 (1000_A804 / 0x1A804)
    goto label_1000_A7F3_1A7F3;
    State.IncCycles();
    label_1000_A806_1A806:
    // MOV word ptr [0xdc2c],BX (1000_A806 / 0x1A806)
    UInt16[DS, 0xDC2C] = BX;
    State.IncCycles();
    // MOV word ptr [0xdc2e],BP (1000_A80A / 0x1A80A)
    UInt16[DS, 0xDC2E] = BP;
    State.IncCycles();
    // CALL 0x1000:a82e (1000_A80E / 0x1A80E)
    NearCall(cs1, 0xA811, not_observed_1000_A82E_01A82E);
    State.IncCycles();
    label_1000_A811_1A811:
    // JMP 0x1000:a9b9 (1000_A811 / 0x1A811)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_A9B9_01A9B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A814_01A814(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A814_1A814:
    // MOV DI,word ptr [0xdc26] (1000_A814 / 0x1A814)
    DI = UInt16[DS, 0xDC26];
    State.IncCycles();
    // OR DI,DI (1000_A818 / 0x1A818)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:a82d (1000_A81A / 0x1A81A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A82D / 0x1A82D)
      return NearRet();
    }
    State.IncCycles();
    // MOV ES,word ptr [0x3813] (1000_A81C / 0x1A81C)
    ES = UInt16[DS, 0x3813];
    State.IncCycles();
    // MOV AL,byte ptr ES:[DI] (1000_A820 / 0x1A820)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // CMP AL,0xff (1000_A823 / 0x1A823)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JNC 0x1000:a82d (1000_A825 / 0x1A825)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A82D / 0x1A82D)
      return NearRet();
    }
    State.IncCycles();
    // INC DI (1000_A827 / 0x1A827)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // MOV word ptr [0xdc26],DI (1000_A828 / 0x1A828)
    UInt16[DS, 0xDC26] = DI;
    State.IncCycles();
    // STC  (1000_A82C / 0x1A82C)
    CarryFlag = true;
    State.IncCycles();
    label_1000_A82D_1A82D:
    // RET  (1000_A82D / 0x1A82D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_A82E_01A82E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A82E_1A82E:
    // CMP AL,byte ptr [0xdc2a] (1000_A82E / 0x1A82E)
    Alu.Sub8(AL, UInt8[DS, 0xDC2A]);
    State.IncCycles();
    // JZ 0x1000:a83e (1000_A832 / 0x1A832)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A83E / 0x1A83E)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0xdc2a],AL (1000_A834 / 0x1A834)
    UInt8[DS, 0xDC2A] = AL;
    State.IncCycles();
    // MOV SI,word ptr [0xdc28] (1000_A837 / 0x1A837)
    SI = UInt16[DS, 0xDC28];
    State.IncCycles();
    // JMP 0x1000:9de3 (1000_A83B / 0x1A83B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_9DE3_019DE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_A83E_1A83E:
    // RET  (1000_A83E / 0x1A83E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A83F_01A83F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A83F_1A83F:
    // MOV word ptr [0xdc26],0x0 (1000_A83F / 0x1A83F)
    UInt16[DS, 0xDC26] = 0x0;
    State.IncCycles();
    // CALL 0x1000:ae2f (1000_A845 / 0x1A845)
    NearCall(cs1, 0xA848, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_A848_1A848:
    // JZ 0x1000:a87d (1000_A848 / 0x1A848)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A87D / 0x1A87D)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:ac14 (1000_A84A / 0x1A84A)
    NearCall(cs1, 0xA84D, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    // CALL 0x1000:a90b (1000_A84D / 0x1A84D)
    NearCall(cs1, 0xA850, open_res_file_ida_1000_A90B_1A90B);
    State.IncCycles();
    // CMC  (1000_A850 / 0x1A850)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JNC 0x1000:a87d (1000_A851 / 0x1A851)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A87D / 0x1A87D)
      return NearRet();
    }
    State.IncCycles();
    // LES DI,[0x3811] (1000_A853 / 0x1A853)
    ES = UInt16[DS, 0x3813];
    DI = UInt16[DS, 0x3811];
    State.IncCycles();
    // ADD DI,0x1a (1000_A857 / 0x1A857)
    DI += 0x1A;
    State.IncCycles();
    // CMP byte ptr ES:[DI],0x5 (1000_A85A / 0x1A85A)
    Alu.Sub8(UInt8[ES, DI], 0x5);
    State.IncCycles();
    // JNZ 0x1000:a871 (1000_A85E / 0x1A85E)
    if(!ZeroFlag) {
      goto label_1000_A871_1A871;
    }
    State.IncCycles();
    // MOV CX,word ptr ES:[DI + 0x1] (1000_A860 / 0x1A860)
    CX = UInt16[ES, (ushort)(DI + 0x1)];
    State.IncCycles();
    // ADD DI,0x4 (1000_A864 / 0x1A864)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    State.IncCycles();
    // MOV AX,DI (1000_A867 / 0x1A867)
    AX = DI;
    State.IncCycles();
    // ADD AX,0x2 (1000_A869 / 0x1A869)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    // MOV [0xdc26],AX (1000_A86C / 0x1A86C)
    UInt16[DS, 0xDC26] = AX;
    State.IncCycles();
    // ADD DI,CX (1000_A86F / 0x1A86F)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    label_1000_A871_1A871:
    // MOV word ptr [0x3811],DI (1000_A871 / 0x1A871)
    UInt16[DS, 0x3811] = DI;
    State.IncCycles();
    // SUB word ptr [0x3815],DI (1000_A875 / 0x1A875)
    // UInt16[DS, 0x3815] -= DI;
    UInt16[DS, 0x3815] = Alu.Sub16(UInt16[DS, 0x3815], DI);
    State.IncCycles();
    // CALL 0x1000:a9b9 (1000_A879 / 0x1A879)
    NearCall(cs1, 0xA87C, not_observed_1000_A9B9_01A9B9);
    State.IncCycles();
    // STC  (1000_A87C / 0x1A87C)
    CarryFlag = true;
    State.IncCycles();
    label_1000_A87D_1A87D:
    // RET  (1000_A87D / 0x1A87D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A87E_01A87E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A87E_1A87E:
    // PUSHF  (1000_A87E / 0x1A87E)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // STI  (1000_A87F / 0x1A87F)
    InterruptFlag = true;
    State.IncCycles();
    // CALL 0x1000:ae2f (1000_A880 / 0x1A880)
    NearCall(cs1, 0xA883, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_A883_1A883:
    // JZ 0x1000:a8af (1000_A883 / 0x1A883)
    if(ZeroFlag) {
      goto label_1000_A8AF_1A8AF;
    }
    State.IncCycles();
    // CALL 0x1000:ac14 (1000_A885 / 0x1A885)
    NearCall(cs1, 0xA888, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    // MOV AL,0xb (1000_A888 / 0x1A888)
    AL = 0xB;
    State.IncCycles();
    // CALL 0x1000:abe9 (1000_A88A / 0x1A88A)
    NearCall(cs1, 0xA88D, open_voc_resource_ida_1000_ABE9_1ABE9);
    State.IncCycles();
    // MOV SI,0x3811 (1000_A88D / 0x1A88D)
    SI = 0x3811;
    State.IncCycles();
    // CALLF [0x3991] (1000_A890 / 0x1A890)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_A890 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_A890) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A890));
        break;
    }
    State.IncCycles();
    // PUSH word ptr [0xce7a] (1000_A894 / 0x1A894)
    Stack.Push(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    label_1000_A898_1A898:
    // CALL 0x1000:a9e7 (1000_A898 / 0x1A898)
    NearCall(cs1, 0xA89B, pcm_test_audio_done_ida_1000_A9E7_1A9E7);
    State.IncCycles();
    // JZ 0x1000:a898 (1000_A89B / 0x1A89B)
    if(ZeroFlag) {
      goto label_1000_A898_1A898;
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_A89D / 0x1A89D)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // POP BX (1000_A8A0 / 0x1A8A0)
    BX = Stack.Pop();
    State.IncCycles();
    // SUB AX,BX (1000_A8A1 / 0x1A8A1)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // MOV CX,0x800 (1000_A8A3 / 0x1A8A3)
    CX = 0x800;
    State.IncCycles();
    // MUL CX (1000_A8A6 / 0x1A8A6)
    Cpu.Mul16(CX);
    State.IncCycles();
    // MOV word ptr [0x2882],DX (1000_A8A8 / 0x1A8A8)
    UInt16[DS, 0x2882] = DX;
    State.IncCycles();
    // MOV [0x2884],AX (1000_A8AC / 0x1A8AC)
    UInt16[DS, 0x2884] = AX;
    State.IncCycles();
    label_1000_A8AF_1A8AF:
    // POPF  (1000_A8AF / 0x1A8AF)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_A8B0 / 0x1A8B0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A8B1_01A8B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A8B1_1A8B1:
    // AND AL,0xf (1000_A8B1 / 0x1A8B1)
    AL &= 0xF;
    State.IncCycles();
    // ADD AL,0x30 (1000_A8B3 / 0x1A8B3)
    AL += 0x30;
    State.IncCycles();
    // CMP AL,0x39 (1000_A8B5 / 0x1A8B5)
    Alu.Sub8(AL, 0x39);
    State.IncCycles();
    // JBE 0x1000:a8bb (1000_A8B7 / 0x1A8B7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A8BB / 0x1A8BB)
      return NearRet();
    }
    State.IncCycles();
    // ADD AL,0x7 (1000_A8B9 / 0x1A8B9)
    // AL += 0x7;
    AL = Alu.Add8(AL, 0x7);
    State.IncCycles();
    label_1000_A8BB_1A8BB:
    // RET  (1000_A8BB / 0x1A8BB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A8BC_01A8BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A8BC_1A8BC:
    // MOV DI,0x37db (1000_A8BC / 0x1A8BC)
    DI = 0x37DB;
    State.IncCycles();
    // PUSH DS (1000_A8BF / 0x1A8BF)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_A8C0 / 0x1A8C0)
    ES = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_A8C1 / 0x1A8C1)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AL,BL (1000_A8C2 / 0x1A8C2)
    AL = BL;
    State.IncCycles();
    // ADD AL,0x41 (1000_A8C4 / 0x1A8C4)
    // AL += 0x41;
    AL = Alu.Add8(AL, 0x41);
    State.IncCycles();
    // STOSB ES:DI (1000_A8C6 / 0x1A8C6)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC DI (1000_A8C7 / 0x1A8C7)
    DI++;
    State.IncCycles();
    // INC DI (1000_A8C8 / 0x1A8C8)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // STOSB ES:DI (1000_A8C9 / 0x1A8C9)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // POP BX (1000_A8CA / 0x1A8CA)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV CL,0x4 (1000_A8CB / 0x1A8CB)
    CL = 0x4;
    State.IncCycles();
    // MOV AL,BH (1000_A8CD / 0x1A8CD)
    AL = BH;
    State.IncCycles();
    // CALL 0x1000:a8b1 (1000_A8CF / 0x1A8CF)
    NearCall(cs1, 0xA8D2, spice86_generated_label_call_target_1000_A8B1_01A8B1);
    State.IncCycles();
    label_1000_A8D2_1A8D2:
    // STOSB ES:DI (1000_A8D2 / 0x1A8D2)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,BL (1000_A8D3 / 0x1A8D3)
    AL = BL;
    State.IncCycles();
    // SHR AL,CL (1000_A8D5 / 0x1A8D5)
    // AL >>= CL;
    AL = Alu.Shr8(AL, CL);
    State.IncCycles();
    // CALL 0x1000:a8b1 (1000_A8D7 / 0x1A8D7)
    NearCall(cs1, 0xA8DA, spice86_generated_label_call_target_1000_A8B1_01A8B1);
    State.IncCycles();
    label_1000_A8DA_1A8DA:
    // STOSB ES:DI (1000_A8DA / 0x1A8DA)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,BL (1000_A8DB / 0x1A8DB)
    AL = BL;
    State.IncCycles();
    // CALL 0x1000:a8b1 (1000_A8DD / 0x1A8DD)
    NearCall(cs1, 0xA8E0, spice86_generated_label_call_target_1000_A8B1_01A8B1);
    State.IncCycles();
    label_1000_A8E0_1A8E0:
    // STOSB ES:DI (1000_A8E0 / 0x1A8E0)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,0x4f (1000_A8E1 / 0x1A8E1)
    AL = 0x4F;
    State.IncCycles();
    // CMP byte ptr [0xea],0x0 (1000_A8E3 / 0x1A8E3)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    State.IncCycles();
    // JG 0x1000:a8fa (1000_A8E8 / 0x1A8E8)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_A8FA_1A8FA;
    }
    State.IncCycles();
    // CMP byte ptr [0x6],0x80 (1000_A8EA / 0x1A8EA)
    Alu.Sub8(UInt8[DS, 0x6], 0x80);
    State.IncCycles();
    // JNZ 0x1000:a8fa (1000_A8EF / 0x1A8EF)
    if(!ZeroFlag) {
      goto label_1000_A8FA_1A8FA;
    }
    State.IncCycles();
    // CMP byte ptr [0x4],0x1 (1000_A8F1 / 0x1A8F1)
    Alu.Sub8(UInt8[DS, 0x4], 0x1);
    State.IncCycles();
    // JZ 0x1000:a8fa (1000_A8F6 / 0x1A8F6)
    if(ZeroFlag) {
      goto label_1000_A8FA_1A8FA;
    }
    State.IncCycles();
    // MOV AL,0x49 (1000_A8F8 / 0x1A8F8)
    AL = 0x49;
    State.IncCycles();
    label_1000_A8FA_1A8FA:
    // STOSB ES:DI (1000_A8FA / 0x1A8FA)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,0x20 (1000_A8FB / 0x1A8FB)
    AL = 0x20;
    State.IncCycles();
    // SHR BH,CL (1000_A8FD / 0x1A8FD)
    // BH >>= CL;
    BH = Alu.Shr8(BH, CL);
    State.IncCycles();
    // OR BH,byte ptr [0x47e0] (1000_A8FF / 0x1A8FF)
    // BH |= UInt8[DS, 0x47E0];
    BH = Alu.Or8(BH, UInt8[DS, 0x47E0]);
    State.IncCycles();
    // JZ 0x1000:a909 (1000_A903 / 0x1A903)
    if(ZeroFlag) {
      goto label_1000_A909_1A909;
    }
    State.IncCycles();
    // MOV AL,BH (1000_A905 / 0x1A905)
    AL = BH;
    State.IncCycles();
    // ADD AL,0x41 (1000_A907 / 0x1A907)
    // AL += 0x41;
    AL = Alu.Add8(AL, 0x41);
    State.IncCycles();
    label_1000_A909_1A909:
    // STOSB ES:DI (1000_A909 / 0x1A909)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_1000_A90A_1A90A:
    // RET  (1000_A90A / 0x1A90A)
    return NearRet();
  }
  
  public virtual Action open_res_file_ida_1000_A90B_1A90B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A90B_1A90B:
    // MOV DX,0x37da (1000_A90B / 0x1A90B)
    DX = 0x37DA;
    State.IncCycles();
    // XOR AX,AX (1000_A90E / 0x1A90E)
    AX = 0;
    State.IncCycles();
    // MOV [0x3811],AX (1000_A910 / 0x1A910)
    UInt16[DS, 0x3811] = AX;
    State.IncCycles();
    // MOV [0x3817],AX (1000_A913 / 0x1A913)
    UInt16[DS, 0x3817] = AX;
    State.IncCycles();
    // MOV [0x381f],AX (1000_A916 / 0x1A916)
    UInt16[DS, 0x381F] = AX;
    State.IncCycles();
    // MOV [0x3823],AL (1000_A919 / 0x1A919)
    UInt8[DS, 0x3823] = AL;
    State.IncCycles();
    // CALL 0x1000:f1fb (1000_A91C / 0x1A91C)
    NearCall(cs1, 0xA91F, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    State.IncCycles();
    // JC 0x1000:a90a (1000_A91F / 0x1A91F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A90A / 0x1A90A)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [0x3821],BX (1000_A921 / 0x1A921)
    UInt16[DS, 0x3821] = BX;
    State.IncCycles();
    // SUB CX,0x1 (1000_A925 / 0x1A925)
    // CX -= 0x1;
    CX = Alu.Sub16(CX, 0x1);
    State.IncCycles();
    // SBB BP,0x0 (1000_A928 / 0x1A928)
    BP = Alu.Sbb16(BP, 0x0);
    State.IncCycles();
    // MOV word ptr [0xdbc4],CX (1000_A92B / 0x1A92B)
    UInt16[DS, 0xDBC4] = CX;
    State.IncCycles();
    // MOV word ptr [0xdbc6],BP (1000_A92F / 0x1A92F)
    UInt16[DS, 0xDBC6] = BP;
    State.IncCycles();
    // MOV [0xdbc0],AX (1000_A933 / 0x1A933)
    UInt16[DS, 0xDBC0] = AX;
    State.IncCycles();
    // MOV word ptr [0xdbc2],DX (1000_A936 / 0x1A936)
    UInt16[DS, 0xDBC2] = DX;
    State.IncCycles();
    // MOV SI,0x3811 (1000_A93A / 0x1A93A)
    SI = 0x3811;
    State.IncCycles();
    // LES DX,[SI] (1000_A93D / 0x1A93D)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DX = UInt16[DS, SI];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(read_audio_file_ida_1000_A93F_1A93F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action read_audio_file_ida_1000_A93F_1A93F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A93F_1A93F:
    // PUSH DX (1000_A93F / 0x1A93F)
    Stack.Push(DX);
    State.IncCycles();
    // MOV DX,word ptr [0xdbc0] (1000_A940 / 0x1A940)
    DX = UInt16[DS, 0xDBC0];
    State.IncCycles();
    // MOV CX,word ptr [0xdbc2] (1000_A944 / 0x1A944)
    CX = UInt16[DS, 0xDBC2];
    State.IncCycles();
    // MOV AX,0x4200 (1000_A948 / 0x1A948)
    AX = 0x4200;
    State.IncCycles();
    // INT 0x21 (1000_A94B / 0x1A94B)
    Interrupt(0x21);
    State.IncCycles();
    // POP DX (1000_A94D / 0x1A94D)
    DX = Stack.Pop();
    State.IncCycles();
    // PUSH SI (1000_A94E / 0x1A94E)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_A94F / 0x1A94F)
    Stack.Push(DS);
    State.IncCycles();
    // MOV CX,0x2000 (1000_A950 / 0x1A950)
    CX = 0x2000;
    State.IncCycles();
    // MOV AX,[0xdbc4] (1000_A953 / 0x1A953)
    AX = UInt16[DS, 0xDBC4];
    State.IncCycles();
    // SUB word ptr [0xdbc4],CX (1000_A956 / 0x1A956)
    // UInt16[DS, 0xDBC4] -= CX;
    UInt16[DS, 0xDBC4] = Alu.Sub16(UInt16[DS, 0xDBC4], CX);
    State.IncCycles();
    // SBB word ptr [0xdbc6],0x0 (1000_A95A / 0x1A95A)
    UInt16[DS, 0xDBC6] = Alu.Sbb16(UInt16[DS, 0xDBC6], 0x0);
    State.IncCycles();
    // JNC 0x1000:a964 (1000_A95F / 0x1A95F)
    if(!CarryFlag) {
      goto label_1000_A964_1A964;
    }
    State.IncCycles();
    // MOV CX,AX (1000_A961 / 0x1A961)
    CX = AX;
    State.IncCycles();
    // INC CX (1000_A963 / 0x1A963)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    label_1000_A964_1A964:
    // PUSH ES (1000_A964 / 0x1A964)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_A965 / 0x1A965)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV AH,0x3f (1000_A966 / 0x1A966)
    AH = 0x3F;
    State.IncCycles();
    // INT 0x21 (1000_A968 / 0x1A968)
    Interrupt(0x21);
    State.IncCycles();
    // POP DS (1000_A96A / 0x1A96A)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_A96B / 0x1A96B)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [SI + 0x4],AX (1000_A96C / 0x1A96C)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    State.IncCycles();
    // JC 0x1000:a9b8 (1000_A96F / 0x1A96F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A9B8 / 0x1A9B8)
      return NearRet();
    }
    State.IncCycles();
    // ADD word ptr [0xdbc0],AX (1000_A971 / 0x1A971)
    // UInt16[DS, 0xDBC0] += AX;
    UInt16[DS, 0xDBC0] = Alu.Add16(UInt16[DS, 0xDBC0], AX);
    State.IncCycles();
    // ADC word ptr [0xdbc2],0x0 (1000_A975 / 0x1A975)
    UInt16[DS, 0xDBC2] = Alu.Adc16(UInt16[DS, 0xDBC2], 0x0);
    State.IncCycles();
    // MOV byte ptr [0x376a],0xff (1000_A97A / 0x1A97A)
    UInt8[DS, 0x376A] = 0xFF;
    State.IncCycles();
    // MOV byte ptr [SI + 0x6],0x1 (1000_A97F / 0x1A97F)
    UInt8[DS, (ushort)(SI + 0x6)] = 0x1;
    State.IncCycles();
    // MOV BL,byte ptr [0x3823] (1000_A983 / 0x1A983)
    BL = UInt8[DS, 0x3823];
    State.IncCycles();
    // CMP BL,0x3f (1000_A987 / 0x1A987)
    Alu.Sub8(BL, 0x3F);
    State.IncCycles();
    // JNC 0x1000:a992 (1000_A98A / 0x1A98A)
    if(!CarryFlag) {
      goto label_1000_A992_1A992;
    }
    State.IncCycles();
    // INC byte ptr [0x3823] (1000_A98C / 0x1A98C)
    UInt8[DS, 0x3823]++;
    State.IncCycles();
    // INC BL (1000_A990 / 0x1A990)
    BL = Alu.Inc8(BL);
    State.IncCycles();
    label_1000_A992_1A992:
    // MOV byte ptr [SI + 0x7],BL (1000_A992 / 0x1A992)
    UInt8[DS, (ushort)(SI + 0x7)] = BL;
    State.IncCycles();
    // CMP word ptr [0xdbc6],0x0 (1000_A995 / 0x1A995)
    Alu.Sub16(UInt16[DS, 0xDBC6], 0x0);
    State.IncCycles();
    // CLC  (1000_A99A / 0x1A99A)
    CarryFlag = false;
    State.IncCycles();
    // JNS 0x1000:a9b8 (1000_A99B / 0x1A99B)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A9B8 / 0x1A9B8)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [SI + 0x7],0x80 (1000_A99D / 0x1A99D)
    UInt8[DS, (ushort)(SI + 0x7)] |= 0x80;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A9A1_01A9A1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A9A1_01A9A1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A9A1_1A9A1:
    // XOR BX,BX (1000_A9A1 / 0x1A9A1)
    BX = 0;
    State.IncCycles();
    // XCHG word ptr [0x3821],BX (1000_A9A3 / 0x1A9A3)
    ushort tmp_1000_A9A3 = UInt16[DS, 0x3821];
    UInt16[DS, 0x3821] = BX;
    BX = tmp_1000_A9A3;
    State.IncCycles();
    // OR BX,BX (1000_A9A7 / 0x1A9A7)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:a9b7 (1000_A9A9 / 0x1A9A9)
    if(ZeroFlag) {
      goto label_1000_A9B7_1A9B7;
    }
    State.IncCycles();
    // CMP BX,word ptr [0xdbba] (1000_A9AB / 0x1A9AB)
    Alu.Sub16(BX, UInt16[DS, 0xDBBA]);
    State.IncCycles();
    // JZ 0x1000:a9b7 (1000_A9AF / 0x1A9AF)
    if(ZeroFlag) {
      goto label_1000_A9B7_1A9B7;
    }
    State.IncCycles();
    // PUSH AX (1000_A9B1 / 0x1A9B1)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AH,0x3e (1000_A9B2 / 0x1A9B2)
    AH = 0x3E;
    State.IncCycles();
    // INT 0x21 (1000_A9B4 / 0x1A9B4)
    Interrupt(0x21);
    State.IncCycles();
    // POP AX (1000_A9B6 / 0x1A9B6)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_A9B7_1A9B7:
    // CLC  (1000_A9B7 / 0x1A9B7)
    CarryFlag = false;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_A9B8_01A9B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A9B8_01A9B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A9B8_1A9B8:
    // RET  (1000_A9B8 / 0x1A9B8)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_A9B9_01A9B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A9B9_1A9B9:
    // CALL 0x1000:aba3 (1000_A9B9 / 0x1A9B9)
    NearCall(cs1, 0xA9BC, check_res_file_open_ida_1000_ABA3_1ABA3);
    State.IncCycles();
    // JZ 0x1000:a9e6 (1000_A9BC / 0x1A9BC)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A9E6 / 0x1A9E6)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x3811 (1000_A9BE / 0x1A9BE)
    SI = 0x3811;
    State.IncCycles();
    // CMP byte ptr [0x3817],0x0 (1000_A9C1 / 0x1A9C1)
    Alu.Sub8(UInt8[DS, 0x3817], 0x0);
    State.IncCycles();
    // JZ 0x1000:a9d2 (1000_A9C6 / 0x1A9C6)
    if(ZeroFlag) {
      goto label_1000_A9D2_1A9D2;
    }
    State.IncCycles();
    // CMP byte ptr [0x381f],0x0 (1000_A9C8 / 0x1A9C8)
    Alu.Sub8(UInt8[DS, 0x381F], 0x0);
    State.IncCycles();
    // JNZ 0x1000:a9e6 (1000_A9CD / 0x1A9CD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A9E6 / 0x1A9E6)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x3819 (1000_A9CF / 0x1A9CF)
    SI = 0x3819;
    State.IncCycles();
    label_1000_A9D2_1A9D2:
    // MOV BX,word ptr [0x3821] (1000_A9D2 / 0x1A9D2)
    BX = UInt16[DS, 0x3821];
    State.IncCycles();
    // LES DX,[SI] (1000_A9D6 / 0x1A9D6)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DX = UInt16[DS, SI];
    State.IncCycles();
    // ADD DX,0x6 (1000_A9D8 / 0x1A9D8)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    State.IncCycles();
    // PUSH SI (1000_A9DB / 0x1A9DB)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:a93f (1000_A9DC / 0x1A9DC)
    NearCall(cs1, 0xA9DF, read_audio_file_ida_1000_A93F_1A93F);
    State.IncCycles();
    // POP SI (1000_A9DF / 0x1A9DF)
    SI = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:a9e6 (1000_A9E0 / 0x1A9E0)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A9E6 / 0x1A9E6)
      return NearRet();
    }
    State.IncCycles();
    // CALLF [0x39a1] (1000_A9E2 / 0x1A9E2)
    // Indirect call to [0x39a1], generating possible targets from emulator records
    uint targetAddress_1000_A9E2 = (uint)(UInt16[DS, 0x39A3] * 0x10 + UInt16[DS, 0x39A1] - cs1 * 0x10);
    switch(targetAddress_1000_A9E2) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A9E2));
        break;
    }
    State.IncCycles();
    label_1000_A9E6_1A9E6:
    // RET  (1000_A9E6 / 0x1A9E6)
    return NearRet();
  }
  
  public virtual Action pcm_test_audio_done_ida_1000_A9E7_1A9E7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A9E7_1A9E7:
    // CMP byte ptr [0x3817],0x3 (1000_A9E7 / 0x1A9E7)
    Alu.Sub8(UInt8[DS, 0x3817], 0x3);
    State.IncCycles();
    // JZ 0x1000:a9f3 (1000_A9EC / 0x1A9EC)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A9F3 / 0x1A9F3)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x381f],0x3 (1000_A9EE / 0x1A9EE)
    Alu.Sub8(UInt8[DS, 0x381F], 0x3);
    State.IncCycles();
    label_1000_A9F3_1A9F3:
    // RET  (1000_A9F3 / 0x1A9F3)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_A9F4_01A9F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A9F4_1A9F4:
    // MOV SI,word ptr [0x3824] (1000_A9F4 / 0x1A9F4)
    SI = UInt16[DS, 0x3824];
    State.IncCycles();
    // LES DI,[SI] (1000_A9F8 / 0x1A9F8)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DI = UInt16[DS, SI];
    State.IncCycles();
    // ADD DI,0x6 (1000_A9FA / 0x1A9FA)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    State.IncCycles();
    // CALL 0x1000:aa70 (1000_A9FD / 0x1A9FD)
    NearCall(cs1, 0xAA00, transfer_sd_block_qq_ida_1000_AA70_1AA70);
    State.IncCycles();
    // CALLF [0x39a1] (1000_AA00 / 0x1AA00)
    // Indirect call to [0x39a1], generating possible targets from emulator records
    uint targetAddress_1000_AA00 = (uint)(UInt16[DS, 0x39A3] * 0x10 + UInt16[DS, 0x39A1] - cs1 * 0x10);
    switch(targetAddress_1000_AA00) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AA00));
        break;
    }
    State.IncCycles();
    // MOV AX,0x3811 (1000_AA04 / 0x1AA04)
    AX = 0x3811;
    State.IncCycles();
    // XOR AX,0x3819 (1000_AA07 / 0x1AA07)
    AX ^= 0x3819;
    State.IncCycles();
    // XOR word ptr [0x3824],AX (1000_AA0A / 0x1AA0A)
    // UInt16[DS, 0x3824] ^= AX;
    UInt16[DS, 0x3824] = Alu.Xor16(UInt16[DS, 0x3824], AX);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AA0F_01AA0F, 0x1AA0E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AA0F_01AA0F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xAA0E: break; // Instructions before entry targeted by 0x1AA13
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_AA0E_1AA0E:
    // RET  (1000_AA0E / 0x1AA0E)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_AA0F_1AA0F:
    // MOV AX,[0xdc1c] (1000_AA0F / 0x1AA0F)
    AX = UInt16[DS, 0xDC1C];
    State.IncCycles();
    // INC AX (1000_AA12 / 0x1AA12)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JZ 0x1000:aa0e (1000_AA13 / 0x1AA13)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AA0E / 0x1AA0E)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x376a],0xff (1000_AA15 / 0x1AA15)
    UInt8[DS, 0x376A] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:ac14 (1000_AA1A / 0x1AA1A)
    NearCall(cs1, 0xAA1D, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    // XOR AX,AX (1000_AA1D / 0x1AA1D)
    AX = 0;
    State.IncCycles();
    // MOV [0x3811],AX (1000_AA1F / 0x1AA1F)
    UInt16[DS, 0x3811] = AX;
    State.IncCycles();
    // MOV [0x3817],AX (1000_AA22 / 0x1AA22)
    UInt16[DS, 0x3817] = AX;
    State.IncCycles();
    // MOV [0x381f],AX (1000_AA25 / 0x1AA25)
    UInt16[DS, 0x381F] = AX;
    State.IncCycles();
    // MOV SI,0x3811 (1000_AA28 / 0x1AA28)
    SI = 0x3811;
    State.IncCycles();
    // LES DI,[SI] (1000_AA2B / 0x1AA2B)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DI = UInt16[DS, SI];
    State.IncCycles();
    // CALL 0x1000:aa70 (1000_AA2D / 0x1AA2D)
    NearCall(cs1, 0xAA30, transfer_sd_block_qq_ida_1000_AA70_1AA70);
    State.IncCycles();
    // SUB word ptr [0x3815],0x20 (1000_AA30 / 0x1AA30)
    // UInt16[DS, 0x3815] -= 0x20;
    UInt16[DS, 0x3815] = Alu.Sub16(UInt16[DS, 0x3815], 0x20);
    State.IncCycles();
    // MOV CX,word ptr [0x3815] (1000_AA35 / 0x1AA35)
    CX = UInt16[DS, 0x3815];
    State.IncCycles();
    // MOV word ptr [0x381d],CX (1000_AA39 / 0x1AA39)
    UInt16[DS, 0x381D] = CX;
    State.IncCycles();
    // ADD CX,0x6 (1000_AA3D / 0x1AA3D)
    // CX += 0x6;
    CX = Alu.Add16(CX, 0x6);
    State.IncCycles();
    // MOV SI,0x1a (1000_AA40 / 0x1AA40)
    SI = 0x1A;
    State.IncCycles();
    // XOR DI,DI (1000_AA43 / 0x1AA43)
    DI = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,ES:SI (1000_AA45 / 0x1AA45)
      UInt8[ES, DI] = UInt8[ES, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // LES DI,[0x3819] (1000_AA48 / 0x1AA48)
    ES = UInt16[DS, 0x381B];
    DI = UInt16[DS, 0x3819];
    State.IncCycles();
    // MOV CX,word ptr [0x3815] (1000_AA4C / 0x1AA4C)
    CX = UInt16[DS, 0x3815];
    State.IncCycles();
    // PUSH DS (1000_AA50 / 0x1AA50)
    Stack.Push(DS);
    State.IncCycles();
    // LDS SI,[0x3811] (1000_AA51 / 0x1AA51)
    DS = UInt16[DS, 0x3813];
    SI = UInt16[DS, 0x3811];
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_AA55 / 0x1AA55)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_AA56 / 0x1AA56)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_AA57 / 0x1AA57)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,0x80 (1000_AA58 / 0x1AA58)
    AL = 0x80;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_AA5A / 0x1AA5A)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DS (1000_AA5C / 0x1AA5C)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x3819 (1000_AA5D / 0x1AA5D)
    SI = 0x3819;
    State.IncCycles();
    // MOV word ptr [0x3824],SI (1000_AA60 / 0x1AA60)
    UInt16[DS, 0x3824] = SI;
    State.IncCycles();
    // CALLF [0x3991] (1000_AA64 / 0x1AA64)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_AA64 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_AA64) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AA64));
        break;
    }
    State.IncCycles();
    // MOV SI,0x3811 (1000_AA68 / 0x1AA68)
    SI = 0x3811;
    State.IncCycles();
    // CALLF [0x39a1] (1000_AA6B / 0x1AA6B)
    // Indirect call to [0x39a1], generating possible targets from emulator records
    uint targetAddress_1000_AA6B = (uint)(UInt16[DS, 0x39A3] * 0x10 + UInt16[DS, 0x39A1] - cs1 * 0x10);
    switch(targetAddress_1000_AA6B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AA6B));
        break;
    }
    State.IncCycles();
    // RET  (1000_AA6F / 0x1AA6F)
    return NearRet();
  }
  
  public virtual Action transfer_sd_block_qq_ida_1000_AA70_1AA70(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AA70_1AA70:
    // PUSH SI (1000_AA70 / 0x1AA70)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_AA71 / 0x1AA71)
    Stack.Push(DS);
    State.IncCycles();
    // MOV SI,word ptr [0xdc1c] (1000_AA72 / 0x1AA72)
    SI = UInt16[DS, 0xDC1C];
    State.IncCycles();
    // MOV DS,word ptr [0xdbde] (1000_AA76 / 0x1AA76)
    DS = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // LODSW SI (1000_AA7A / 0x1AA7A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB AX,0x4 (1000_AA7B / 0x1AA7B)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    State.IncCycles();
    // MOV CX,AX (1000_AA7E / 0x1AA7E)
    CX = AX;
    State.IncCycles();
    // SHR CX,1 (1000_AA80 / 0x1AA80)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_AA82 / 0x1AA82)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADC CL,CL (1000_AA84 / 0x1AA84)
    CL = Alu.Adc8(CL, CL);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_AA86 / 0x1AA86)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DS (1000_AA88 / 0x1AA88)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_AA89 / 0x1AA89)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [SI + 0x4],AX (1000_AA8A / 0x1AA8A)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    State.IncCycles();
    // MOV byte ptr [SI + 0x6],0x1 (1000_AA8D / 0x1AA8D)
    UInt8[DS, (ushort)(SI + 0x6)] = 0x1;
    State.IncCycles();
    // MOV byte ptr [SI + 0x7],0x41 (1000_AA91 / 0x1AA91)
    UInt8[DS, (ushort)(SI + 0x7)] = 0x41;
    State.IncCycles();
    // RET  (1000_AA95 / 0x1AA95)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AA96_01AA96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AA96_1AA96:
    // XOR AX,AX (1000_AA96 / 0x1AA96)
    AX = 0;
    State.IncCycles();
    // CMP byte ptr [0x4774],AH (1000_AA98 / 0x1AA98)
    Alu.Sub8(UInt8[DS, 0x4774], AH);
    State.IncCycles();
    // JZ 0x1000:aaa7 (1000_AA9C / 0x1AA9C)
    if(ZeroFlag) {
      goto label_1000_AAA7_1AAA7;
    }
    State.IncCycles();
    // CMP byte ptr [0x2a],0x48 (1000_AA9E / 0x1AA9E)
    Alu.Sub8(UInt8[DS, 0x2A], 0x48);
    State.IncCycles();
    // JNZ 0x1000:ab14 (1000_AAA3 / 0x1AAA3)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:ab12 (1000_AAA5 / 0x1AAA5)
    goto label_1000_AB12_1AB12;
    State.IncCycles();
    label_1000_AAA7_1AAA7:
    // MOV AL,0xd (1000_AAA7 / 0x1AAA7)
    AL = 0xD;
    State.IncCycles();
    // CMP byte ptr [0x46d9],AH (1000_AAA9 / 0x1AAA9)
    Alu.Sub8(UInt8[DS, 0x46D9], AH);
    State.IncCycles();
    // JNZ 0x1000:ab14 (1000_AAAD / 0x1AAAD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_AAAF / 0x1AAAF)
    AL = 0x1;
    State.IncCycles();
    // CMP byte ptr [0xdd03],AH (1000_AAB1 / 0x1AAB1)
    Alu.Sub8(UInt8[DS, 0xDD03], AH);
    State.IncCycles();
    // JNZ 0x1000:ab14 (1000_AAB5 / 0x1AAB5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_AAB7 / 0x1AAB7)
    AX++;
    State.IncCycles();
    // CMP byte ptr [0xfb],AH (1000_AAB8 / 0x1AAB8)
    Alu.Sub8(UInt8[DS, 0xFB], AH);
    State.IncCycles();
    // JS 0x1000:ab14 (1000_AABC / 0x1AABC)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_AABE / 0x1AABE)
    AX++;
    State.IncCycles();
    // CMP byte ptr [0xc6],AH (1000_AABF / 0x1AABF)
    Alu.Sub8(UInt8[DS, 0xC6], AH);
    State.IncCycles();
    // JNZ 0x1000:ab14 (1000_AAC3 / 0x1AAC3)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_AAC5 / 0x1AAC5)
    AX++;
    State.IncCycles();
    // CMP byte ptr [0xea],AH (1000_AAC6 / 0x1AAC6)
    Alu.Sub8(UInt8[DS, 0xEA], AH);
    State.IncCycles();
    // JG 0x1000:ab14 (1000_AACA / 0x1AACA)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_AACC / 0x1AACC)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_AACD / 0x1AACD)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_AAD1 / 0x1AAD1)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP BL,0x80 (1000_AAD5 / 0x1AAD5)
    Alu.Sub8(BL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:aadf (1000_AAD8 / 0x1AAD8)
    if(!ZeroFlag) {
      goto label_1000_AADF_1AADF;
    }
    State.IncCycles();
    // CMP DL,0x1 (1000_AADA / 0x1AADA)
    Alu.Sub8(DL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:aaef (1000_AADD / 0x1AADD)
    if(!ZeroFlag) {
      goto label_1000_AAEF_1AAEF;
    }
    State.IncCycles();
    label_1000_AADF_1AADF:
    // MOV BL,byte ptr [0x11c9] (1000_AADF / 0x1AADF)
    BL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // AND BL,0x3 (1000_AAE3 / 0x1AAE3)
    // BL &= 0x3;
    BL = Alu.And8(BL, 0x3);
    State.IncCycles();
    // JZ 0x1000:ab14 (1000_AAE6 / 0x1AAE6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_AAE8 / 0x1AAE8)
    AX++;
    State.IncCycles();
    // DEC BL (1000_AAE9 / 0x1AAE9)
    BL = Alu.Dec8(BL);
    State.IncCycles();
    // JZ 0x1000:ab14 (1000_AAEB / 0x1AAEB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_AAED / 0x1AAED)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // RET  (1000_AAEE / 0x1AAEE)
    return NearRet();
    State.IncCycles();
    label_1000_AAEF_1AAEF:
    // CMP DH,0x20 (1000_AAEF / 0x1AAEF)
    Alu.Sub8(DH, 0x20);
    State.IncCycles();
    // JNC 0x1000:ab08 (1000_AAF2 / 0x1AAF2)
    if(!CarryFlag) {
      goto label_1000_AB08_1AB08;
    }
    State.IncCycles();
    // MOV AL,0x9 (1000_AAF4 / 0x1AAF4)
    AL = 0x9;
    State.IncCycles();
    // CMP DH,0x7 (1000_AAF6 / 0x1AAF6)
    Alu.Sub8(DH, 0x7);
    State.IncCycles();
    // SBB AL,0x0 (1000_AAF9 / 0x1AAF9)
    AL = Alu.Sbb8(AL, 0x0);
    State.IncCycles();
    // CMP byte ptr [0x2a],0x48 (1000_AAFB / 0x1AAFB)
    Alu.Sub8(UInt8[DS, 0x2A], 0x48);
    State.IncCycles();
    // JC 0x1000:ab14 (1000_AB00 / 0x1AB00)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // SHR BL,1 (1000_AB02 / 0x1AB02)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    State.IncCycles();
    // JC 0x1000:ab14 (1000_AB04 / 0x1AB04)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:ab12 (1000_AB06 / 0x1AB06)
    goto label_1000_AB12_1AB12;
    State.IncCycles();
    label_1000_AB08_1AB08:
    // MOV AL,0xc (1000_AB08 / 0x1AB08)
    AL = 0xC;
    State.IncCycles();
    // JNZ 0x1000:ab14 (1000_AB0A / 0x1AB0A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    // DEC AX (1000_AB0C / 0x1AB0C)
    AX--;
    State.IncCycles();
    // CMP DL,0x3 (1000_AB0D / 0x1AB0D)
    Alu.Sub8(DL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:ab14 (1000_AB10 / 0x1AB10)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    State.IncCycles();
    label_1000_AB12_1AB12:
    // MOV AL,0xa (1000_AB12 / 0x1AB12)
    AL = 0xA;
    State.IncCycles();
    label_1000_AB14_1AB14:
    // RET  (1000_AB14 / 0x1AB14)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AB15_01AB15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AB15_1AB15:
    // CALL 0x1000:abcc (1000_AB15 / 0x1AB15)
    NearCall(cs1, 0xAB18, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    State.IncCycles();
    label_1000_AB18_1AB18:
    // JNZ 0x1000:ab44 (1000_AB18 / 0x1AB18)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:ae2f (1000_AB1A / 0x1AB1A)
    NearCall(cs1, 0xAB1D, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_AB1D_1AB1D:
    // JZ 0x1000:ab44 (1000_AB1D / 0x1AB1D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // PUSH ES (1000_AB1F / 0x1AB1F)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:e270 (1000_AB20 / 0x1AB20)
    NearCall(cs1, 0xAB23, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // CMP AL,byte ptr [0x376a] (1000_AB23 / 0x1AB23)
    Alu.Sub8(AL, UInt8[DS, 0x376A]);
    State.IncCycles();
    // JZ 0x1000:ab35 (1000_AB27 / 0x1AB27)
    if(ZeroFlag) {
      goto label_1000_AB35_1AB35;
    }
    State.IncCycles();
    // CALL 0x1000:ac14 (1000_AB29 / 0x1AB29)
    NearCall(cs1, 0xAB2C, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    // OR AL,AL (1000_AB2C / 0x1AB2C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:ab40 (1000_AB2E / 0x1AB2E)
    if(ZeroFlag) {
      goto label_1000_AB40_1AB40;
    }
    State.IncCycles();
    // CALL 0x1000:abe9 (1000_AB30 / 0x1AB30)
    NearCall(cs1, 0xAB33, open_voc_resource_ida_1000_ABE9_1ABE9);
    State.IncCycles();
    // JMP 0x1000:ab39 (1000_AB33 / 0x1AB33)
    goto label_1000_AB39_1AB39;
    State.IncCycles();
    label_1000_AB35_1AB35:
    // LES DI,[0x3811] (1000_AB35 / 0x1AB35)
    ES = UInt16[DS, 0x3813];
    DI = UInt16[DS, 0x3811];
    State.IncCycles();
    label_1000_AB39_1AB39:
    // MOV SI,0x3811 (1000_AB39 / 0x1AB39)
    SI = 0x3811;
    State.IncCycles();
    // CALLF [0x3991] (1000_AB3C / 0x1AB3C)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_AB3C = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_AB3C) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AB3C));
        break;
    }
    State.IncCycles();
    label_1000_AB40_1AB40:
    // CALL 0x1000:e283 (1000_AB40 / 0x1AB40)
    NearCall(cs1, 0xAB43, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // POP ES (1000_AB43 / 0x1AB43)
    ES = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AB44_01AB44, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_AB44_01AB44(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AB44_1AB44:
    // RET  (1000_AB44 / 0x1AB44)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AB45_01AB45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AB45_1AB45:
    // CALL 0x1000:ae2f (1000_AB45 / 0x1AB45)
    NearCall(cs1, 0xAB48, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_AB48_1AB48:
    // JZ 0x1000:ab44 (1000_AB48 / 0x1AB48)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // PUSH AX (1000_AB4A / 0x1AB4A)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:ade0 (1000_AB4B / 0x1AB4B)
    NearCall(cs1, 0xAB4E, spice86_generated_label_call_target_1000_ADE0_01ADE0);
    State.IncCycles();
    // POP AX (1000_AB4E / 0x1AB4E)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AB4F_01AB4F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AB4F_01AB4F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AB4F_1AB4F:
    // MOV byte ptr [0x47e0],0x0 (1000_AB4F / 0x1AB4F)
    UInt8[DS, 0x47E0] = 0x0;
    State.IncCycles();
    // MOV BX,0x19 (1000_AB54 / 0x1AB54)
    BX = 0x19;
    State.IncCycles();
    // CALL 0x1000:a8bc (1000_AB57 / 0x1AB57)
    NearCall(cs1, 0xAB5A, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AB5A_01AB5A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AB5A_01AB5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AB5A_1AB5A:
    // MOV byte ptr [0x37e2],0x49 (1000_AB5A / 0x1AB5A)
    UInt8[DS, 0x37E2] = 0x49;
    State.IncCycles();
    // CALL 0x1000:abcc (1000_AB5F / 0x1AB5F)
    NearCall(cs1, 0xAB62, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    State.IncCycles();
    label_1000_AB62_1AB62:
    // JNZ 0x1000:ab44 (1000_AB62 / 0x1AB62)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:ae2f (1000_AB64 / 0x1AB64)
    NearCall(cs1, 0xAB67, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_AB67_1AB67:
    // JZ 0x1000:ab44 (1000_AB67 / 0x1AB67)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // PUSH ES (1000_AB69 / 0x1AB69)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:e270 (1000_AB6A / 0x1AB6A)
    NearCall(cs1, 0xAB6D, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // CALL 0x1000:ac14 (1000_AB6D / 0x1AB6D)
    NearCall(cs1, 0xAB70, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    // CALL 0x1000:a90b (1000_AB70 / 0x1AB70)
    NearCall(cs1, 0xAB73, open_res_file_ida_1000_A90B_1A90B);
    State.IncCycles();
    // JC 0x1000:ab8d (1000_AB73 / 0x1AB73)
    if(CarryFlag) {
      goto label_1000_AB8D_1AB8D;
    }
    State.IncCycles();
    // ADD word ptr [0x3811],0x1a (1000_AB75 / 0x1AB75)
    // UInt16[DS, 0x3811] += 0x1A;
    UInt16[DS, 0x3811] = Alu.Add16(UInt16[DS, 0x3811], 0x1A);
    State.IncCycles();
    // CALL 0x1000:a9b9 (1000_AB7A / 0x1AB7A)
    NearCall(cs1, 0xAB7D, not_observed_1000_A9B9_01A9B9);
    State.IncCycles();
    // MOV SI,0xab92 (1000_AB7D / 0x1AB7D)
    SI = 0xAB92;
    State.IncCycles();
    // MOV BP,0x1 (1000_AB80 / 0x1AB80)
    BP = 0x1;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_AB83 / 0x1AB83)
    NearCall(cs1, 0xAB86, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    // MOV SI,0x3811 (1000_AB86 / 0x1AB86)
    SI = 0x3811;
    State.IncCycles();
    // CALLF [0x3991] (1000_AB89 / 0x1AB89)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_AB89 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_AB89) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AB89));
        break;
    }
    State.IncCycles();
    label_1000_AB8D_1AB8D:
    // CALL 0x1000:e283 (1000_AB8D / 0x1AB8D)
    NearCall(cs1, 0xAB90, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // POP ES (1000_AB90 / 0x1AB90)
    ES = Stack.Pop();
    State.IncCycles();
    // RET  (1000_AB91 / 0x1AB91)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_AB92_01AB92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AB92_1AB92:
    // CALL 0x1000:a9b9 (1000_AB92 / 0x1AB92)
    NearCall(cs1, 0xAB95, not_observed_1000_A9B9_01A9B9);
    State.IncCycles();
    // CALL 0x1000:aba3 (1000_AB95 / 0x1AB95)
    NearCall(cs1, 0xAB98, check_res_file_open_ida_1000_ABA3_1ABA3);
    State.IncCycles();
    // JNZ 0x1000:ab44 (1000_AB98 / 0x1AB98)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:aded (1000_AB9A / 0x1AB9A)
    NearCall(cs1, 0xAB9D, spice86_generated_label_call_target_1000_ADED_01ADED);
    State.IncCycles();
    // MOV SI,0xab92 (1000_AB9D / 0x1AB9D)
    SI = 0xAB92;
    State.IncCycles();
    // JMP 0x1000:da5f (1000_ABA0 / 0x1ABA0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action check_res_file_open_ida_1000_ABA3_1ABA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ABA3_1ABA3:
    // CMP word ptr [0x3821],0x0 (1000_ABA3 / 0x1ABA3)
    Alu.Sub16(UInt16[DS, 0x3821], 0x0);
    State.IncCycles();
    // RET  (1000_ABA8 / 0x1ABA8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ABA9_01ABA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ABA9_1ABA9:
    // CALL 0x1000:ae2f (1000_ABA9 / 0x1ABA9)
    NearCall(cs1, 0xABAC, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_ABAC_1ABAC:
    // JZ 0x1000:ab44 (1000_ABAC / 0x1ABAC)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,word ptr [0xce7a] (1000_ABAE / 0x1ABAE)
    BX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    label_1000_ABB2_1ABB2:
    // PUSH BX (1000_ABB2 / 0x1ABB2)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:ab92 (1000_ABB3 / 0x1ABB3)
    NearCall(cs1, 0xABB6, not_observed_1000_AB92_01AB92);
    State.IncCycles();
    // CALL 0x1000:aba3 (1000_ABB6 / 0x1ABB6)
    NearCall(cs1, 0xABB9, check_res_file_open_ida_1000_ABA3_1ABA3);
    State.IncCycles();
    // POP BX (1000_ABB9 / 0x1ABB9)
    BX = Stack.Pop();
    State.IncCycles();
    // JZ 0x1000:abc6 (1000_ABBA / 0x1ABBA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_ABC6_01ABC6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_ABBC / 0x1ABBC)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,BX (1000_ABBF / 0x1ABBF)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x3e8 (1000_ABC1 / 0x1ABC1)
    Alu.Sub16(AX, 0x3E8);
    State.IncCycles();
    // JC 0x1000:abb2 (1000_ABC4 / 0x1ABC4)
    if(CarryFlag) {
      goto label_1000_ABB2_1ABB2;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_ABC6_01ABC6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_ABC6_01ABC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ABC6_1ABC6:
    // MOV byte ptr [0xdc2b],0x0 (1000_ABC6 / 0x1ABC6)
    UInt8[DS, 0xDC2B] = 0x0;
    State.IncCycles();
    // RET  (1000_ABCB / 0x1ABCB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ABCC_01ABCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ABCC_1ABCC:
    // CMP byte ptr [0xdc2b],0x0 (1000_ABCC / 0x1ABCC)
    Alu.Sub8(UInt8[DS, 0xDC2B], 0x0);
    State.IncCycles();
    // RET  (1000_ABD1 / 0x1ABD1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ABD5_01ABD5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xABD2: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_ABD2_1ABD2:
    // CALL 0x1000:a7c2 (1000_ABD2 / 0x1ABD2)
    NearCall(cs1, 0xABD5, spice86_generated_label_call_target_1000_A7C2_01A7C2);
    entry:
    State.IncCycles();
    label_1000_ABD5_1ABD5:
    // CALL 0x1000:abcc (1000_ABD5 / 0x1ABD5)
    NearCall(cs1, 0xABD8, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    State.IncCycles();
    label_1000_ABD8_1ABD8:
    // JNZ 0x1000:abd2 (1000_ABD8 / 0x1ABD8)
    if(!ZeroFlag) {
      goto label_1000_ABD2_1ABD2;
    }
    State.IncCycles();
    // RET  (1000_ABDA / 0x1ABDA)
    return NearRet();
  }
  
  public virtual Action open_voc_resource_ida_1000_ABE9_1ABE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ABE9_1ABE9:
    // MOV word ptr [0x3811],0x0 (1000_ABE9 / 0x1ABE9)
    UInt16[DS, 0x3811] = 0x0;
    State.IncCycles();
    // LES DI,[0x3811] (1000_ABEF / 0x1ABEF)
    ES = UInt16[DS, 0x3813];
    DI = UInt16[DS, 0x3811];
    State.IncCycles();
    // ADD word ptr [0x3811],0x1a (1000_ABF3 / 0x1ABF3)
    UInt16[DS, 0x3811] += 0x1A;
    State.IncCycles();
    // XOR AH,AH (1000_ABF8 / 0x1ABF8)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_ABFA / 0x1ABFA)
    SI = AX;
    State.IncCycles();
    // ADD SI,0xae (1000_ABFC / 0x1ABFC)
    // SI += 0xAE;
    SI = Alu.Add16(SI, 0xAE);
    State.IncCycles();
    // MOV [0x376a],AL (1000_AC00 / 0x1AC00)
    UInt8[DS, 0x376A] = AL;
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_AC03 / 0x1AC03)
    NearCall(cs1, 0xAC06, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    State.IncCycles();
    // SUB CX,0x1a (1000_AC06 / 0x1AC06)
    // CX -= 0x1A;
    CX = Alu.Sub16(CX, 0x1A);
    State.IncCycles();
    // MOV word ptr [0x3815],CX (1000_AC09 / 0x1AC09)
    UInt16[DS, 0x3815] = CX;
    State.IncCycles();
    // MOV word ptr [0x3817],0x8101 (1000_AC0D / 0x1AC0D)
    UInt16[DS, 0x3817] = 0x8101;
    State.IncCycles();
    // RET  (1000_AC13 / 0x1AC13)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AC14_01AC14(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AC14_1AC14:
    // PUSH AX (1000_AC14 / 0x1AC14)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_AC15 / 0x1AC15)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_AC16 / 0x1AC16)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_AC17 / 0x1AC17)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_AC18 / 0x1AC18)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_AC19 / 0x1AC19)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (1000_AC1A / 0x1AC1A)
    Stack.Push(ES);
    State.IncCycles();
    // MOV SI,0xab92 (1000_AC1B / 0x1AC1B)
    SI = 0xAB92;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_AC1E / 0x1AC1E)
    NearCall(cs1, 0xAC21, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AC21_01AC21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AC21_01AC21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AC21_1AC21:
    // CALL 0x1000:a9a1 (1000_AC21 / 0x1AC21)
    NearCall(cs1, 0xAC24, spice86_generated_label_call_target_1000_A9A1_01A9A1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AC24_01AC24, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AC24_01AC24(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AC24_1AC24:
    // CALLF [0x3995] (1000_AC24 / 0x1AC24)
    // Indirect call to [0x3995], generating possible targets from emulator records
    uint targetAddress_1000_AC24 = (uint)(UInt16[DS, 0x3997] * 0x10 + UInt16[DS, 0x3995] - cs1 * 0x10);
    switch(targetAddress_1000_AC24) {
      case 0x46459 : FarCall(cs1, 0xAC28, spice86_generated_label_call_target_5635_0109_056459); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AC24));
        break;
    }
    State.IncCycles();
    label_1000_AC28_1AC28:
    // POP ES (1000_AC28 / 0x1AC28)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_AC29 / 0x1AC29)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_AC2A / 0x1AC2A)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_AC2B / 0x1AC2B)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_AC2C / 0x1AC2C)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_AC2D / 0x1AC2D)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_AC2E / 0x1AC2E)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_AC2F / 0x1AC2F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AC30_01AC30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AC30_1AC30:
    // CALLF [0x3999] (1000_AC30 / 0x1AC30)
    // Indirect call to [0x3999], generating possible targets from emulator records
    uint targetAddress_1000_AC30 = (uint)(UInt16[DS, 0x399B] * 0x10 + UInt16[DS, 0x3999] - cs1 * 0x10);
    switch(targetAddress_1000_AC30) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AC30));
        break;
    }
    State.IncCycles();
    // RET  (1000_AC34 / 0x1AC34)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AC3A_01AC3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AC3A_1AC3A:
    // MOV BP,0x201a (1000_AC3A / 0x1AC3A)
    BP = 0x201A;
    State.IncCycles();
    // OR byte ptr [BP + 0x3],0x40 (1000_AC3D / 0x1AC3D)
    // UInt8[SS, (ushort)(BP + 0x3)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0x3)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0x3)], 0x40);
    State.IncCycles();
    // OR byte ptr [BP + 0x7],0x40 (1000_AC41 / 0x1AC41)
    // UInt8[SS, (ushort)(BP + 0x7)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0x7)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0x7)], 0x40);
    State.IncCycles();
    // OR byte ptr [BP + 0xb],0x40 (1000_AC45 / 0x1AC45)
    // UInt8[SS, (ushort)(BP + 0xB)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xB)], 0x40);
    State.IncCycles();
    // MOV CL,0xff (1000_AC49 / 0x1AC49)
    CL = 0xFF;
    State.IncCycles();
    // CALL 0x1000:ae28 (1000_AC4B / 0x1AC4B)
    NearCall(cs1, 0xAC4E, spice86_generated_label_call_target_1000_AE28_01AE28);
    State.IncCycles();
    label_1000_AC4E_1AC4E:
    // JZ 0x1000:ac6d (1000_AC4E / 0x1AC4E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AC6D / 0x1AC6D)
      return NearRet();
    }
    State.IncCycles();
    // AND byte ptr [BP + 0x3],0xbf (1000_AC50 / 0x1AC50)
    UInt8[SS, (ushort)(BP + 0x3)] &= 0xBF;
    State.IncCycles();
    // AND byte ptr [BP + 0x7],0xbf (1000_AC54 / 0x1AC54)
    UInt8[SS, (ushort)(BP + 0x7)] &= 0xBF;
    State.IncCycles();
    // AND byte ptr [BP + 0xb],0xbf (1000_AC58 / 0x1AC58)
    UInt8[SS, (ushort)(BP + 0xB)] &= 0xBF;
    State.IncCycles();
    // XOR CX,CX (1000_AC5C / 0x1AC5C)
    CX = 0;
    State.IncCycles();
    // TEST byte ptr [0x2943],0x10 (1000_AC5E / 0x1AC5E)
    Alu.And8(UInt8[DS, 0x2943], 0x10);
    State.IncCycles();
    // JNZ 0x1000:ac6d (1000_AC63 / 0x1AC63)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AC6D / 0x1AC6D)
      return NearRet();
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x3810] (1000_AC65 / 0x1AC65)
    CL = UInt8[DS, 0x3810];
    State.IncCycles();
    // AND CL,0x1 (1000_AC69 / 0x1AC69)
    CL &= 0x1;
    State.IncCycles();
    // INC CX (1000_AC6C / 0x1AC6C)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    label_1000_AC6D_1AC6D:
    // RET  (1000_AC6D / 0x1AC6D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_ACBF_01ACBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ACBF_1ACBF:
    // MOV BP,0x37fa (1000_ACBF / 0x1ACBF)
    BP = 0x37FA;
    State.IncCycles();
    // MOV CX,0x12 (1000_ACC2 / 0x1ACC2)
    CX = 0x12;
    State.IncCycles();
    label_1000_ACC5_1ACC5:
    // MOV BX,0x8 (1000_ACC5 / 0x1ACC5)
    BX = 0x8;
    State.IncCycles();
    // CALL 0x1000:e3df (1000_ACC8 / 0x1ACC8)
    NearCall(cs1, 0xACCB, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    State.IncCycles();
    // MOV SI,AX (1000_ACCB / 0x1ACCB)
    SI = AX;
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_ACCD / 0x1ACCD)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // XOR AX,CX (1000_ACD0 / 0x1ACD0)
    AX ^= CX;
    State.IncCycles();
    // ADD word ptr [0xd828],AX (1000_ACD2 / 0x1ACD2)
    // UInt16[DS, 0xD828] += AX;
    UInt16[DS, 0xD828] = Alu.Add16(UInt16[DS, 0xD828], AX);
    State.IncCycles();
    // CALL 0x1000:e3df (1000_ACD6 / 0x1ACD6)
    NearCall(cs1, 0xACD9, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    State.IncCycles();
    // MOV DI,AX (1000_ACD9 / 0x1ACD9)
    DI = AX;
    State.IncCycles();
    // MOV AL,byte ptr [BP + SI] (1000_ACDB / 0x1ACDB)
    AL = UInt8[SS, (ushort)(BP + SI)];
    State.IncCycles();
    // XCHG byte ptr [BP + DI],AL (1000_ACDD / 0x1ACDD)
    byte tmp_1000_ACDD = UInt8[SS, (ushort)(BP + DI)];
    UInt8[SS, (ushort)(BP + DI)] = AL;
    AL = tmp_1000_ACDD;
    State.IncCycles();
    // MOV byte ptr [BP + SI],AL (1000_ACDF / 0x1ACDF)
    UInt8[SS, (ushort)(BP + SI)] = AL;
    State.IncCycles();
    // LOOP 0x1000:acc5 (1000_ACE1 / 0x1ACE1)
    if(--CX != 0) {
      goto label_1000_ACC5_1ACC5;
    }
    State.IncCycles();
    // MOV SI,BP (1000_ACE3 / 0x1ACE3)
    SI = BP;
    State.IncCycles();
    // RET  (1000_ACE5 / 0x1ACE5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ACE6_01ACE6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ACE6_1ACE6:
    // CALL 0x1000:abcc (1000_ACE6 / 0x1ACE6)
    NearCall(cs1, 0xACE9, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_ACE9_01ACE9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_ACE9_01ACE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ACE9_1ACE9:
    // JNZ 0x1000:ad36 (1000_ACE9 / 0x1ACE9)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [0x3810],0x1 (1000_ACEB / 0x1ACEB)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    State.IncCycles();
    // JZ 0x1000:ad37 (1000_ACF0 / 0x1ACF0)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AD36_01AD36, 0x1AD37 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_ACF2 / 0x1ACF2)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:ad36 (1000_ACF7 / 0x1ACF7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xdbcd],0x0 (1000_ACF9 / 0x1ACF9)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    State.IncCycles();
    // JS 0x1000:ad36 (1000_ACFE / 0x1ACFE)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0xdbd2] (1000_AD00 / 0x1AD00)
    AX = UInt16[DS, 0xDBD2];
    State.IncCycles();
    // OR AX,AX (1000_AD03 / 0x1AD03)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNZ 0x1000:ad0d (1000_AD05 / 0x1AD05)
    if(!ZeroFlag) {
      goto label_1000_AD0D_1AD0D;
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_AD07 / 0x1AD07)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdbd2],AX (1000_AD0A / 0x1AD0A)
    UInt16[DS, 0xDBD2] = AX;
    State.IncCycles();
    label_1000_AD0D_1AD0D:
    // SUB AX,word ptr [0xce7a] (1000_AD0D / 0x1AD0D)
    AX -= UInt16[DS, 0xCE7A];
    State.IncCycles();
    // NEG AX (1000_AD11 / 0x1AD11)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // CMP AX,0xc8 (1000_AD13 / 0x1AD13)
    Alu.Sub16(AX, 0xC8);
    State.IncCycles();
    // JC 0x1000:ad36 (1000_AD16 / 0x1AD16)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_AD18_01AD18, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_AD18_01AD18(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD18_1AD18:
    // MOV SI,word ptr [0x380e] (1000_AD18 / 0x1AD18)
    SI = UInt16[DS, 0x380E];
    State.IncCycles();
    // LODSB SI (1000_AD1C / 0x1AD1C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_AD1D / 0x1AD1D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:ad30 (1000_AD1F / 0x1AD1F)
    if(!SignFlag) {
      goto label_1000_AD30_1AD30;
    }
    State.IncCycles();
    // MOV SI,0x37fa (1000_AD21 / 0x1AD21)
    SI = 0x37FA;
    State.IncCycles();
    // LODSB SI (1000_AD24 / 0x1AD24)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // TEST byte ptr [0x3810],0x2 (1000_AD25 / 0x1AD25)
    Alu.And8(UInt8[DS, 0x3810], 0x2);
    State.IncCycles();
    // JZ 0x1000:ad30 (1000_AD2A / 0x1AD2A)
    if(ZeroFlag) {
      goto label_1000_AD30_1AD30;
    }
    State.IncCycles();
    // CALL 0x1000:acbf (1000_AD2C / 0x1AD2C)
    NearCall(cs1, 0xAD2F, not_observed_1000_ACBF_01ACBF);
    State.IncCycles();
    // LODSB SI (1000_AD2F / 0x1AD2F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_AD30_1AD30:
    // MOV word ptr [0x380e],SI (1000_AD30 / 0x1AD30)
    UInt16[DS, 0x380E] = SI;
    State.IncCycles();
    // JMP 0x1000:ad95 (1000_AD34 / 0x1AD34)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD95_01AD95, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_AD36_01AD36(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xAD37: goto label_1000_AD37_1AD37;break; // Target of external jump from 0x1ACF0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_AD36_1AD36:
    // RET  (1000_AD36 / 0x1AD36)
    return NearRet();
    State.IncCycles();
    label_1000_AD37_1AD37:
    // CALL 0x1000:aec6 (1000_AD37 / 0x1AD37)
    NearCall(cs1, 0xAD3A, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    State.IncCycles();
    label_1000_AD3A_1AD3A:
    // JC 0x1000:ad36 (1000_AD3A / 0x1AD3A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xdbcd],0x0 (1000_AD3C / 0x1AD3C)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    State.IncCycles();
    // JS 0x1000:ad36 (1000_AD41 / 0x1AD41)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD43_01AD43, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AD43_01AD43(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD43_1AD43:
    // MOV AL,[0xdbcc] (1000_AD43 / 0x1AD43)
    AL = UInt8[DS, 0xDBCC];
    State.IncCycles();
    // MOV byte ptr [0xdbcb],0x0 (1000_AD46 / 0x1AD46)
    UInt8[DS, 0xDBCB] = 0x0;
    State.IncCycles();
    // OR AL,AL (1000_AD4B / 0x1AD4B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:ad95 (1000_AD4D / 0x1AD4D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD95_01AD95, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_AD4F / 0x1AD4F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AD50_01AD50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD50_1AD50:
    // CALL 0x1000:aeb7 (1000_AD50 / 0x1AD50)
    NearCall(cs1, 0xAD53, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    State.IncCycles();
    label_1000_AD53_1AD53:
    // MOV AL,0x3 (1000_AD53 / 0x1AD53)
    AL = 0x3;
    State.IncCycles();
    // JMP 0x1000:ad95 (1000_AD55 / 0x1AD55)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD95_01AD95, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AD57_01AD57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD57_1AD57:
    // CALL 0x1000:aeb7 (1000_AD57 / 0x1AD57)
    NearCall(cs1, 0xAD5A, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    State.IncCycles();
    label_1000_AD5A_1AD5A:
    // MOV AL,0x6 (1000_AD5A / 0x1AD5A)
    AL = 0x6;
    State.IncCycles();
    // JMP 0x1000:ad95 (1000_AD5C / 0x1AD5C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD95_01AD95, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AD5E_01AD5E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD5E_1AD5E:
    // CALL 0x1000:aec6 (1000_AD5E / 0x1AD5E)
    NearCall(cs1, 0xAD61, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    State.IncCycles();
    label_1000_AD61_1AD61:
    // JC 0x1000:ad74 (1000_AD61 / 0x1AD61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AD74 / 0x1AD74)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:aa96 (1000_AD63 / 0x1AD63)
    NearCall(cs1, 0xAD66, spice86_generated_label_call_target_1000_AA96_01AA96);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AD66_01AD66, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AD66_01AD66(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD66_1AD66:
    // CMP byte ptr [0x3810],0x0 (1000_AD66 / 0x1AD66)
    Alu.Sub8(UInt8[DS, 0x3810], 0x0);
    State.IncCycles();
    // JZ 0x1000:ad75 (1000_AD6B / 0x1AD6B)
    if(ZeroFlag) {
      goto label_1000_AD75_1AD75;
    }
    State.IncCycles();
    // CMP byte ptr [0xdbcd],0x0 (1000_AD6D / 0x1AD6D)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    State.IncCycles();
    // JNS 0x1000:ad18 (1000_AD72 / 0x1AD72)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_AD18_01AD18, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_AD74_1AD74:
    // RET  (1000_AD74 / 0x1AD74)
    return NearRet();
    State.IncCycles();
    label_1000_AD75_1AD75:
    // MOV BX,0x375c (1000_AD75 / 0x1AD75)
    BX = 0x375C;
    State.IncCycles();
    // XLAT BX (1000_AD78 / 0x1AD78)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // OR AL,AL (1000_AD79 / 0x1AD79)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:adbd (1000_AD7B / 0x1AD7B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // OR AL,AL (1000_AD7D / 0x1AD7D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:ad89 (1000_AD7F / 0x1AD7F)
    if(SignFlag) {
      goto label_1000_AD89_1AD89;
    }
    State.IncCycles();
    // MOV [0xdbcc],AL (1000_AD81 / 0x1AD81)
    UInt8[DS, 0xDBCC] = AL;
    State.IncCycles();
    // CALLF [0x3979] (1000_AD84 / 0x1AD84)
    // Indirect call to [0x3979], generating possible targets from emulator records
    uint targetAddress_1000_AD84 = (uint)(UInt16[DS, 0x397B] * 0x10 + UInt16[DS, 0x3979] - cs1 * 0x10);
    switch(targetAddress_1000_AD84) {
      case 0x464E9 : FarCall(cs1, 0xAD88, spice86_generated_label_call_target_563E_0109_0564E9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AD84));
        break;
    }
    State.IncCycles();
    label_1000_AD88_1AD88:
    // RET  (1000_AD88 / 0x1AD88)
    return NearRet();
    State.IncCycles();
    label_1000_AD89_1AD89:
    // AND AL,0x3f (1000_AD89 / 0x1AD89)
    // AL &= 0x3F;
    AL = Alu.And8(AL, 0x3F);
    State.IncCycles();
    // MOV [0xdbcc],AL (1000_AD8B / 0x1AD8B)
    UInt8[DS, 0xDBCC] = AL;
    State.IncCycles();
    // CMP AL,byte ptr [0xdbcb] (1000_AD8E / 0x1AD8E)
    Alu.Sub8(AL, UInt8[DS, 0xDBCB]);
    State.IncCycles();
    // JNZ 0x1000:adbe (1000_AD92 / 0x1AD92)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ADBE_01ADBE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_AD94 / 0x1AD94)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AD95_01AD95(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AD95_1AD95:
    // XOR AH,AH (1000_AD95 / 0x1AD95)
    AH = 0;
    State.IncCycles();
    // CALL 0x1000:aec6 (1000_AD97 / 0x1AD97)
    NearCall(cs1, 0xAD9A, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    State.IncCycles();
    label_1000_AD9A_1AD9A:
    // JC 0x1000:adbd (1000_AD9A / 0x1AD9A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,byte ptr [0xdbcb] (1000_AD9C / 0x1AD9C)
    Alu.Sub8(AL, UInt8[DS, 0xDBCB]);
    State.IncCycles();
    // JZ 0x1000:adbd (1000_ADA0 / 0x1ADA0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:ae62 (1000_ADA2 / 0x1ADA2)
    NearCall(cs1, 0xADA5, spice86_generated_label_call_target_1000_AE62_01AE62);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_ADA5_01ADA5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_ADA5_01ADA5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ADA5_1ADA5:
    // MOV [0xdbcb],AL (1000_ADA5 / 0x1ADA5)
    UInt8[DS, 0xDBCB] = AL;
    State.IncCycles();
    // LES SI,[0xdbb6] (1000_ADA8 / 0x1ADA8)
    ES = UInt16[DS, 0xDBB8];
    SI = UInt16[DS, 0xDBB6];
    State.IncCycles();
    // MOV AL,[0x3810] (1000_ADAC / 0x1ADAC)
    AL = UInt8[DS, 0x3810];
    State.IncCycles();
    // AND AL,0x1 (1000_ADAF / 0x1ADAF)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    State.IncCycles();
    // CALLF [0x3971] (1000_ADB1 / 0x1ADB1)
    // Indirect call to [0x3971], generating possible targets from emulator records
    uint targetAddress_1000_ADB1 = (uint)(UInt16[DS, 0x3973] * 0x10 + UInt16[DS, 0x3971] - cs1 * 0x10);
    switch(targetAddress_1000_ADB1) {
      case 0x464E3 : FarCall(cs1, 0xADB5, spice86_generated_label_call_target_563E_0103_0564E3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_ADB1));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_ADB5_01ADB5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_ADB5_01ADB5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xADBD: goto label_1000_ADBD_1ADBD;break; // Target of external jump from 0x1AE1C, 0x1ADCF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_ADB5_1ADB5:
    // MOV [0xdbcd],AL (1000_ADB5 / 0x1ADB5)
    UInt8[DS, 0xDBCD] = AL;
    State.IncCycles();
    // XOR AX,AX (1000_ADB8 / 0x1ADB8)
    AX = 0;
    State.IncCycles();
    // MOV [0xdbd2],AX (1000_ADBA / 0x1ADBA)
    UInt16[DS, 0xDBD2] = AX;
    State.IncCycles();
    label_1000_ADBD_1ADBD:
    // RET  (1000_ADBD / 0x1ADBD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ADBE_01ADBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ADBE_1ADBE:
    // CALL 0x1000:aec6 (1000_ADBE / 0x1ADBE)
    NearCall(cs1, 0xADC1, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    State.IncCycles();
    label_1000_ADC1_1ADC1:
    // JC 0x1000:adbd (1000_ADC1 / 0x1ADC1)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [0x3810],0x1 (1000_ADC3 / 0x1ADC3)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    State.IncCycles();
    // JNZ 0x1000:adbd (1000_ADC8 / 0x1ADC8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [0xdbcd],0x40 (1000_ADCA / 0x1ADCA)
    Alu.And8(UInt8[DS, 0xDBCD], 0x40);
    State.IncCycles();
    // JNZ 0x1000:adbd (1000_ADCF / 0x1ADCF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_ADD1 / 0x1ADD1)
    Stack.Push(BX);
    State.IncCycles();
    // MOV AX,0x12c (1000_ADD2 / 0x1ADD2)
    AX = 0x12C;
    State.IncCycles();
    // XOR BX,BX (1000_ADD5 / 0x1ADD5)
    BX = 0;
    State.IncCycles();
    // CALLF [0x397d] (1000_ADD7 / 0x1ADD7)
    // Indirect call to [0x397d], generating possible targets from emulator records
    uint targetAddress_1000_ADD7 = (uint)(UInt16[DS, 0x397F] * 0x10 + UInt16[DS, 0x397D] - cs1 * 0x10);
    switch(targetAddress_1000_ADD7) {
      case 0x464EC : FarCall(cs1, 0xADDB, spice86_generated_label_call_target_563E_010C_0564EC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_ADD7));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_ADDB_01ADDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_ADDB_01ADDB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ADDB_1ADDB:
    // MOV [0xdbcd],AL (1000_ADDB / 0x1ADDB)
    UInt8[DS, 0xDBCD] = AL;
    State.IncCycles();
    // POP BX (1000_ADDE / 0x1ADDE)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_ADDF / 0x1ADDF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ADE0_01ADE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ADE0_1ADE0:
    // MOV AX,0x64 (1000_ADE0 / 0x1ADE0)
    AX = 0x64;
    State.IncCycles();
    // MOV BL,byte ptr [0x289e] (1000_ADE3 / 0x1ADE3)
    BL = UInt8[DS, 0x289E];
    State.IncCycles();
    // MOV BH,byte ptr [0x28b6] (1000_ADE7 / 0x1ADE7)
    BH = UInt8[DS, 0x28B6];
    State.IncCycles();
    // JMP 0x1000:adf8 (1000_ADEB / 0x1ADEB)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ADED_01ADED, 0x1ADF8 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_ADED_01ADED(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xADF8: goto label_1000_ADF8_1ADF8;break; // Target of external jump from 0x1ADEB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_ADED_1ADED:
    // MOV AX,0x190 (1000_ADED / 0x1ADED)
    AX = 0x190;
    State.IncCycles();
    // MOV BL,byte ptr [0x2896] (1000_ADF0 / 0x1ADF0)
    BL = UInt8[DS, 0x2896];
    State.IncCycles();
    // MOV BH,byte ptr [0x28ae] (1000_ADF4 / 0x1ADF4)
    BH = UInt8[DS, 0x28AE];
    State.IncCycles();
    label_1000_ADF8_1ADF8:
    // CMP BL,0x4 (1000_ADF8 / 0x1ADF8)
    Alu.Sub8(BL, 0x4);
    State.IncCycles();
    // JNC 0x1000:adff (1000_ADFB / 0x1ADFB)
    if(!CarryFlag) {
      goto label_1000_ADFF_1ADFF;
    }
    State.IncCycles();
    // MOV BL,0x4 (1000_ADFD / 0x1ADFD)
    BL = 0x4;
    State.IncCycles();
    label_1000_ADFF_1ADFF:
    // CALLF [0x397d] (1000_ADFF / 0x1ADFF)
    // Indirect call to [0x397d], generating possible targets from emulator records
    uint targetAddress_1000_ADFF = (uint)(UInt16[DS, 0x397F] * 0x10 + UInt16[DS, 0x397D] - cs1 * 0x10);
    switch(targetAddress_1000_ADFF) {
      case 0x464EC : FarCall(cs1, 0xAE03, spice86_generated_label_call_target_563E_010C_0564EC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_ADFF));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AE03_01AE03, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AE03_01AE03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE03_1AE03:
    // RET  (1000_AE03 / 0x1AE03)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AE04_01AE04(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE04_1AE04:
    // CALL 0x1000:aec6 (1000_AE04 / 0x1AE04)
    NearCall(cs1, 0xAE07, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    State.IncCycles();
    label_1000_AE07_1AE07:
    // JC 0x1000:adbd (1000_AE07 / 0x1AE07)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [0x3810],0x1 (1000_AE09 / 0x1AE09)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    State.IncCycles();
    // JNZ 0x1000:adbd (1000_AE0E / 0x1AE0E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xdbcd],0x0 (1000_AE10 / 0x1AE10)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    State.IncCycles();
    // JNS 0x1000:ae1e (1000_AE15 / 0x1AE15)
    if(!SignFlag) {
      goto label_1000_AE1E_1AE1E;
    }
    State.IncCycles();
    // TEST byte ptr [0xdbcd],0x40 (1000_AE17 / 0x1AE17)
    Alu.And8(UInt8[DS, 0xDBCD], 0x40);
    State.IncCycles();
    // JZ 0x1000:adbd (1000_AE1C / 0x1AE1C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    State.IncCycles();
    label_1000_AE1E_1AE1E:
    // CALL 0x1000:e270 (1000_AE1E / 0x1AE1E)
    NearCall(cs1, 0xAE21, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AE21_01AE21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AE21_01AE21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE21_1AE21:
    // CALL 0x1000:ad43 (1000_AE21 / 0x1AE21)
    NearCall(cs1, 0xAE24, spice86_generated_label_call_target_1000_AD43_01AD43);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AE24_01AE24, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AE24_01AE24(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE24_1AE24:
    // CALL 0x1000:e283 (1000_AE24 / 0x1AE24)
    NearCall(cs1, 0xAE27, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_AE27_1AE27:
    // RET  (1000_AE27 / 0x1AE27)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AE28_01AE28(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE28_1AE28:
    // TEST word ptr [0xdbc8],0x100 (1000_AE28 / 0x1AE28)
    Alu.And16(UInt16[DS, 0xDBC8], 0x100);
    State.IncCycles();
    // RET  (1000_AE2E / 0x1AE2E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AE2F_01AE2F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE2F_1AE2F:
    // PUSH AX (1000_AE2F / 0x1AE2F)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DS (1000_AE30 / 0x1AE30)
    Stack.Push(DS);
    State.IncCycles();
    // MOV AX,0x1f4b (1000_AE31 / 0x1AE31)
    AX = 0x1F4B;
    State.IncCycles();
    // MOV DS,AX (1000_AE34 / 0x1AE34)
    DS = AX;
    State.IncCycles();
    // TEST word ptr [0xdbc8],0x1 (1000_AE36 / 0x1AE36)
    Alu.And16(UInt16[DS, 0xDBC8], 0x1);
    State.IncCycles();
    // POP DS (1000_AE3C / 0x1AE3C)
    DS = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_AE3D / 0x1AE3D)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AE3F_01AE3F, 0x1AE3E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AE3F_01AE3F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xAE3E: break; // Instructions before entry targeted by 0x1AE57
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_AE3E_1AE3E:
    // RET  (1000_AE3E / 0x1AE3E)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_AE3F_1AE3F:
    // CALL 0x1000:ae28 (1000_AE3F / 0x1AE3F)
    NearCall(cs1, 0xAE42, spice86_generated_label_call_target_1000_AE28_01AE28);
    State.IncCycles();
    label_1000_AE42_1AE42:
    // JZ 0x1000:ae3e (1000_AE42 / 0x1AE42)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AE3E / 0x1AE3E)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0xdbb6 (1000_AE44 / 0x1AE44)
    DI = 0xDBB6;
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_AE47 / 0x1AE47)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // OR AX,word ptr [DI + 0x2] (1000_AE49 / 0x1AE49)
    // AX |= UInt16[DS, (ushort)(DI + 0x2)];
    AX = Alu.Or16(AX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:ae3e (1000_AE4C / 0x1AE4C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AE3E / 0x1AE3E)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0x9c40 (1000_AE4E / 0x1AE4E)
    CX = 0x9C40;
    State.IncCycles();
    // JMP 0x1000:f0f6 (1000_AE51 / 0x1AE51)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0F6_01F0F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AE54_01AE54(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE54_1AE54:
    // CALL 0x1000:ae2f (1000_AE54 / 0x1AE54)
    NearCall(cs1, 0xAE57, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AE57_01AE57, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AE57_01AE57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE57_1AE57:
    // JZ 0x1000:ae3e (1000_AE57 / 0x1AE57)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AE3E / 0x1AE3E)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x3811 (1000_AE59 / 0x1AE59)
    DI = 0x3811;
    State.IncCycles();
    // MOV CX,0x4e20 (1000_AE5C / 0x1AE5C)
    CX = 0x4E20;
    State.IncCycles();
    // JMP 0x1000:f0f6 (1000_AE5F / 0x1AE5F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0F6_01F0F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AE62_01AE62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE62_1AE62:
    // CMP AL,byte ptr [0xdbca] (1000_AE62 / 0x1AE62)
    Alu.Sub8(AL, UInt8[DS, 0xDBCA]);
    State.IncCycles();
    // JZ 0x1000:ae84 (1000_AE66 / 0x1AE66)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AE84 / 0x1AE84)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:aeb7 (1000_AE68 / 0x1AE68)
    NearCall(cs1, 0xAE6B, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    State.IncCycles();
    label_1000_AE6B_1AE6B:
    // MOV [0xdbca],AL (1000_AE6B / 0x1AE6B)
    UInt8[DS, 0xDBCA] = AL;
    State.IncCycles();
    // PUSH AX (1000_AE6E / 0x1AE6E)
    Stack.Push(AX);
    State.IncCycles();
    // ADD AX,0xa4 (1000_AE6F / 0x1AE6F)
    // AX += 0xA4;
    AX = Alu.Add16(AX, 0xA4);
    State.IncCycles();
    // MOV SI,AX (1000_AE72 / 0x1AE72)
    SI = AX;
    State.IncCycles();
    // LES DI,[0xdbb6] (1000_AE74 / 0x1AE74)
    ES = UInt16[DS, 0xDBB8];
    DI = UInt16[DS, 0xDBB6];
    State.IncCycles();
    // MOV AX,ES (1000_AE78 / 0x1AE78)
    AX = ES;
    State.IncCycles();
    // CMP AX,word ptr [0xce68] (1000_AE7A / 0x1AE7A)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    State.IncCycles();
    // JNC 0x1000:ae85 (1000_AE7E / 0x1AE7E)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_AE85_01AE85, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_AE80 / 0x1AE80)
    NearCall(cs1, 0xAE83, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AE83_01AE83, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AE83_01AE83(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE83_1AE83:
    // POP AX (1000_AE83 / 0x1AE83)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_AE84_1AE84:
    // RET  (1000_AE84 / 0x1AE84)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_AE85_01AE85(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AE85_1AE85:
    // PUSH word ptr [0x2784] (1000_AE85 / 0x1AE85)
    Stack.Push(UInt16[DS, 0x2784]);
    State.IncCycles();
    // PUSH SI (1000_AE89 / 0x1AE89)
    Stack.Push(SI);
    State.IncCycles();
    // MOV CX,0x2af (1000_AE8A / 0x1AE8A)
    CX = 0x2AF;
    State.IncCycles();
    // CALL 0x1000:f11c (1000_AE8D / 0x1AE8D)
    NearCall(cs1, 0xAE90, spice86_generated_label_call_target_1000_F11C_01F11C);
    State.IncCycles();
    // POP SI (1000_AE90 / 0x1AE90)
    SI = Stack.Pop();
    State.IncCycles();
    // INC byte ptr [0xce71] (1000_AE91 / 0x1AE91)
    UInt8[DS, 0xCE71] = Alu.Inc8(UInt8[DS, 0xCE71]);
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_AE95 / 0x1AE95)
    NearCall(cs1, 0xAE98, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    State.IncCycles();
    // DEC byte ptr [0xce71] (1000_AE98 / 0x1AE98)
    UInt8[DS, 0xCE71] = Alu.Dec8(UInt8[DS, 0xCE71]);
    State.IncCycles();
    // PUSH DS (1000_AE9C / 0x1AE9C)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH DI (1000_AE9D / 0x1AE9D)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_AE9E / 0x1AE9E)
    Stack.Push(ES);
    State.IncCycles();
    // LES DI,[0xdbb6] (1000_AE9F / 0x1AE9F)
    ES = UInt16[DS, 0xDBB8];
    DI = UInt16[DS, 0xDBB6];
    State.IncCycles();
    // POP DS (1000_AEA3 / 0x1AEA3)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_AEA4 / 0x1AEA4)
    SI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:f403 (1000_AEA5 / 0x1AEA5)
    NearCall(cs1, 0xAEA8, spice86_generated_label_call_target_1000_F403_01F403);
    State.IncCycles();
    // POP DS (1000_AEA8 / 0x1AEA8)
    DS = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_AEA9 / 0x1AEA9)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c13e (1000_AEAA / 0x1AEAA)
    NearCall(cs1, 0xAEAD, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // POP AX (1000_AEAD / 0x1AEAD)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_AEAE / 0x1AEAE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AEB7_01AEB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AEB7_1AEB7:
    // PUSH AX (1000_AEB7 / 0x1AEB7)
    Stack.Push(AX);
    State.IncCycles();
    // MOV byte ptr [0xdbcb],0x0 (1000_AEB8 / 0x1AEB8)
    UInt8[DS, 0xDBCB] = 0x0;
    State.IncCycles();
    // CALLF [0x3975] (1000_AEBD / 0x1AEBD)
    // Indirect call to [0x3975], generating possible targets from emulator records
    uint targetAddress_1000_AEBD = (uint)(UInt16[DS, 0x3977] * 0x10 + UInt16[DS, 0x3975] - cs1 * 0x10);
    switch(targetAddress_1000_AEBD) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AEBD));
        break;
    }
    State.IncCycles();
    // MOV [0xdbcd],AL (1000_AEC1 / 0x1AEC1)
    UInt8[DS, 0xDBCD] = AL;
    State.IncCycles();
    // POP AX (1000_AEC4 / 0x1AEC4)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_AEC5 / 0x1AEC5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AEC6_01AEC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AEC6_1AEC6:
    // TEST byte ptr [0x2943],0x10 (1000_AEC6 / 0x1AEC6)
    Alu.And8(UInt8[DS, 0x2943], 0x10);
    State.IncCycles();
    // JNZ 0x1000:aed4 (1000_AECB / 0x1AECB)
    if(!ZeroFlag) {
      goto label_1000_AED4_1AED4;
    }
    State.IncCycles();
    // CALL 0x1000:ae28 (1000_AECD / 0x1AECD)
    NearCall(cs1, 0xAED0, spice86_generated_label_call_target_1000_AE28_01AE28);
    State.IncCycles();
    // JZ 0x1000:aed4 (1000_AED0 / 0x1AED0)
    if(ZeroFlag) {
      goto label_1000_AED4_1AED4;
    }
    State.IncCycles();
    // CLC  (1000_AED2 / 0x1AED2)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_AED3 / 0x1AED3)
    return NearRet();
    State.IncCycles();
    label_1000_AED4_1AED4:
    // STC  (1000_AED4 / 0x1AED4)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_AED5 / 0x1AED5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AED6_01AED6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AED6_1AED6:
    // CMP byte ptr [0x11c9],0x0 (1000_AED6 / 0x1AED6)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JZ 0x1000:aede (1000_AEDB / 0x1AEDB)
    if(ZeroFlag) {
      goto label_1000_AEDE_1AEDE;
    }
    State.IncCycles();
    // RET  (1000_AEDD / 0x1AEDD)
    return NearRet();
    State.IncCycles();
    label_1000_AEDE_1AEDE:
    // CALL 0x1000:18ba (1000_AEDE / 0x1AEDE)
    NearCall(cs1, 0xAEE1, spice86_generated_label_call_target_1000_18BA_0118BA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AEE1_01AEE1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AEE1_01AEE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AEE1_1AEE1:
    // CALL 0x1000:181e (1000_AEE1 / 0x1AEE1)
    NearCall(cs1, 0xAEE4, spice86_generated_label_call_target_1000_181E_01181E);
    State.IncCycles();
    label_1000_AEE4_1AEE4:
    // CALL 0x1000:daa3 (1000_AEE4 / 0x1AEE4)
    NearCall(cs1, 0xAEE7, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    State.IncCycles();
    label_1000_AEE7_1AEE7:
    // MOV byte ptr [0xc6],0x1 (1000_AEE7 / 0x1AEE7)
    UInt8[DS, 0xC6] = 0x1;
    State.IncCycles();
    // CALL 0x1000:b2b9 (1000_AEEC / 0x1AEEC)
    NearCall(cs1, 0xAEEF, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    State.IncCycles();
    label_1000_AEEF_1AEEF:
    // CALL 0x1000:d95b (1000_AEEF / 0x1AEEF)
    NearCall(cs1, 0xAEF2, spice86_generated_label_call_target_1000_D95B_01D95B);
    State.IncCycles();
    label_1000_AEF2_1AEF2:
    // CALL 0x1000:ad5e (1000_AEF2 / 0x1AEF2)
    NearCall(cs1, 0xAEF5, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    State.IncCycles();
    label_1000_AEF5_1AEF5:
    // MOV AL,0x34 (1000_AEF5 / 0x1AEF5)
    AL = 0x34;
    State.IncCycles();
    // MOV BP,0xaf26 (1000_AEF7 / 0x1AEF7)
    BP = 0xAF26;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_AEFA / 0x1AEFA)
    NearCall(cs1, 0xAEFD, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    label_1000_AEFD_1AEFD:
    // JMP 0x1000:ae04 (1000_AEFD / 0x1AEFD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AE04_01AE04, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AF00_01AF00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF00_1AF00:
    // MOV BH,0x4 (1000_AF00 / 0x1AF00)
    BH = 0x4;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF02_01AF02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_AF02_01AF02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF02_1AF02:
    // MOV BL,0x1c (1000_AF02 / 0x1AF02)
    BL = 0x1C;
    State.IncCycles();
    // CALL 0x1000:b147 (1000_AF04 / 0x1AF04)
    NearCall(cs1, 0xAF07, spice86_generated_label_call_target_1000_B147_01B147);
    State.IncCycles();
    label_1000_AF07_1AF07:
    // MOV AX,0x4000 (1000_AF07 / 0x1AF07)
    AX = 0x4000;
    State.IncCycles();
    // JZ 0x1000:af0e (1000_AF0A / 0x1AF0A)
    if(ZeroFlag) {
      goto label_1000_AF0E_1AF0E;
    }
    State.IncCycles();
    // XOR AH,AH (1000_AF0C / 0x1AF0C)
    AH = 0;
    State.IncCycles();
    label_1000_AF0E_1AF0E:
    // XOR CX,CX (1000_AF0E / 0x1AF0E)
    CX = 0;
    State.IncCycles();
    // MOV CL,BH (1000_AF10 / 0x1AF10)
    CL = BH;
    State.IncCycles();
    // MOV SI,0x2034 (1000_AF12 / 0x1AF12)
    SI = 0x2034;
    State.IncCycles();
    // ADD SI,CX (1000_AF15 / 0x1AF15)
    SI += CX;
    State.IncCycles();
    // AND word ptr [SI],0xbfff (1000_AF17 / 0x1AF17)
    // UInt16[DS, SI] &= 0xBFFF;
    UInt16[DS, SI] = Alu.And16(UInt16[DS, SI], 0xBFFF);
    State.IncCycles();
    // OR word ptr [SI],AX (1000_AF1B / 0x1AF1B)
    UInt16[DS, SI] |= AX;
    State.IncCycles();
    // ADD BH,0x4 (1000_AF1D / 0x1AF1D)
    BH += 0x4;
    State.IncCycles();
    // CMP BH,0xc (1000_AF20 / 0x1AF20)
    Alu.Sub8(BH, 0xC);
    State.IncCycles();
    // JBE 0x1000:af02 (1000_AF23 / 0x1AF23)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_AF02_1AF02;
    }
    State.IncCycles();
    // RET  (1000_AF25 / 0x1AF25)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_AF26_01AF26(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF26_1AF26:
    // CALL 0x1000:d7ad (1000_AF26 / 0x1AF26)
    NearCall(cs1, 0xAF29, spice86_generated_label_call_target_1000_D7AD_01D7AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF29_01AF29, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF29_01AF29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF29_1AF29:
    // MOV SI,0x1e1a (1000_AF29 / 0x1AF29)
    SI = 0x1E1A;
    State.IncCycles();
    // CALL 0x1000:d72b (1000_AF2C / 0x1AF2C)
    NearCall(cs1, 0xAF2F, spice86_generated_label_call_target_1000_D72B_01D72B);
    State.IncCycles();
    label_1000_AF2F_1AF2F:
    // CALL 0x1000:af00 (1000_AF2F / 0x1AF2F)
    NearCall(cs1, 0xAF32, spice86_generated_label_call_target_1000_AF00_01AF00);
    State.IncCycles();
    label_1000_AF32_1AF32:
    // MOV word ptr [0x2406],0x0 (1000_AF32 / 0x1AF32)
    UInt16[DS, 0x2406] = 0x0;
    State.IncCycles();
    // MOV BP,0x2032 (1000_AF38 / 0x1AF38)
    BP = 0x2032;
    State.IncCycles();
    // MOV BX,0xd917 (1000_AF3B / 0x1AF3B)
    BX = 0xD917;
    State.IncCycles();
    // XOR CX,CX (1000_AF3E / 0x1AF3E)
    CX = 0;
    State.IncCycles();
    // CALL 0x1000:d33a (1000_AF40 / 0x1AF40)
    NearCall(cs1, 0xAF43, spice86_generated_label_call_target_1000_D33A_01D33A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF43_01AF43, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF43_01AF43(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF43_1AF43:
    // OR byte ptr [0xc6],0x2 (1000_AF43 / 0x1AF43)
    // UInt8[DS, 0xC6] |= 0x2;
    UInt8[DS, 0xC6] = Alu.Or8(UInt8[DS, 0xC6], 0x2);
    State.IncCycles();
    // CALL 0x1000:c432 (1000_AF48 / 0x1AF48)
    NearCall(cs1, 0xAF4B, spice86_generated_label_call_target_1000_C432_01C432);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF4B_01AF4B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF4B_01AF4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF4B_1AF4B:
    // MOV AL,0x32 (1000_AF4B / 0x1AF4B)
    AL = 0x32;
    State.IncCycles();
    // CALL 0x1000:c2f2 (1000_AF4D / 0x1AF4D)
    NearCall(cs1, 0xAF50, spice86_generated_label_call_target_1000_C2F2_01C2F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF50_01AF50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF50_01AF50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF50_1AF50:
    // MOV byte ptr [0x1c30],0x0 (1000_AF50 / 0x1AF50)
    UInt8[DS, 0x1C30] = 0x0;
    State.IncCycles();
    // JMP 0x1000:1797 (1000_AF55 / 0x1AF55)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_1797_011797, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_AF60_01AF60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF60_1AF60:
    // MOV BX,0x41c (1000_AF60 / 0x1AF60)
    BX = 0x41C;
    State.IncCycles();
    // MOV BP,0x4 (1000_AF63 / 0x1AF63)
    BP = 0x4;
    State.IncCycles();
    // JMP 0x1000:af76 (1000_AF66 / 0x1AF66)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_AF76_01AF76, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_AF68_01AF68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF68_1AF68:
    // MOV BX,0x81c (1000_AF68 / 0x1AF68)
    BX = 0x81C;
    State.IncCycles();
    // MOV BP,0x8 (1000_AF6B / 0x1AF6B)
    BP = 0x8;
    State.IncCycles();
    // JMP 0x1000:af76 (1000_AF6E / 0x1AF6E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_AF76_01AF76, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_AF70_01AF70(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF70_1AF70:
    // MOV BX,0xc1c (1000_AF70 / 0x1AF70)
    BX = 0xC1C;
    State.IncCycles();
    // MOV BP,0xc (1000_AF73 / 0x1AF73)
    BP = 0xC;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_AF76_01AF76, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_AF76_01AF76(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF76_1AF76:
    // PUSH BP (1000_AF76 / 0x1AF76)
    Stack.Push(BP);
    State.IncCycles();
    // TEST byte ptr [0xc6],0x2 (1000_AF77 / 0x1AF77)
    Alu.And8(UInt8[DS, 0xC6], 0x2);
    State.IncCycles();
    // JNZ 0x1000:af86 (1000_AF7C / 0x1AF7C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_AF86_01AF86, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH BX (1000_AF7E / 0x1AF7E)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:0a3e (1000_AF7F / 0x1AF7F)
    NearCall(cs1, 0xAF82, spice86_generated_label_call_target_1000_0A3E_010A3E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF82_01AF82, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF82_01AF82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF82_1AF82:
    // CALL 0x1000:b024 (1000_AF82 / 0x1AF82)
    NearCall(cs1, 0xAF85, spice86_generated_label_call_target_1000_B024_01B024);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF85_01AF85, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF85_01AF85(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF85_1AF85:
    // POP BX (1000_AF85 / 0x1AF85)
    BX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_AF86_01AF86, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_AF86_01AF86(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF86_1AF86:
    // CALL 0x1000:b147 (1000_AF86 / 0x1AF86)
    NearCall(cs1, 0xAF89, spice86_generated_label_call_target_1000_B147_01B147);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AF89_01AF89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AF89_01AF89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AF89_1AF89:
    // POP BP (1000_AF89 / 0x1AF89)
    BP = Stack.Pop();
    State.IncCycles();
    // JZ 0x1000:afc6 (1000_AF8A / 0x1AF8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AFC6 / 0x1AFC6)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [0x2406],BX (1000_AF8C / 0x1AF8C)
    UInt16[DS, 0x2406] = BX;
    State.IncCycles();
    // MOV AX,0xa8 (1000_AF90 / 0x1AF90)
    AX = 0xA8;
    State.IncCycles();
    // TEST byte ptr [0xc6],0x2 (1000_AF93 / 0x1AF93)
    Alu.And8(UInt8[DS, 0xC6], 0x2);
    State.IncCycles();
    // JZ 0x1000:af9d (1000_AF98 / 0x1AF98)
    if(ZeroFlag) {
      goto label_1000_AF9D_1AF9D;
    }
    State.IncCycles();
    // ADD AX,0x2 (1000_AF9A / 0x1AF9A)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    label_1000_AF9D_1AF9D:
    // MOV [0x11bf],AX (1000_AF9D / 0x1AF9D)
    UInt16[DS, 0x11BF] = AX;
    State.IncCycles();
    // MOV SI,0x2034 (1000_AFA0 / 0x1AFA0)
    SI = 0x2034;
    State.IncCycles();
    // MOV CX,0x4 (1000_AFA3 / 0x1AFA3)
    CX = 0x4;
    State.IncCycles();
    // PUSH SI (1000_AFA6 / 0x1AFA6)
    Stack.Push(SI);
    State.IncCycles();
    label_1000_AFA7_1AFA7:
    // AND word ptr [SI],0x7fff (1000_AFA7 / 0x1AFA7)
    UInt16[DS, SI] &= 0x7FFF;
    State.IncCycles();
    // ADD SI,0x4 (1000_AFAB / 0x1AFAB)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:afa7 (1000_AFAE / 0x1AFAE)
    if(--CX != 0) {
      goto label_1000_AFA7_1AFA7;
    }
    State.IncCycles();
    // POP SI (1000_AFB0 / 0x1AFB0)
    SI = Stack.Pop();
    State.IncCycles();
    // OR word ptr [BP + SI],0x8000 (1000_AFB1 / 0x1AFB1)
    // UInt16[SS, (ushort)(BP + SI)] |= 0x8000;
    UInt16[SS, (ushort)(BP + SI)] = Alu.Or16(UInt16[SS, (ushort)(BP + SI)], 0x8000);
    State.IncCycles();
    // MOV CX,0x1 (1000_AFB5 / 0x1AFB5)
    CX = 0x1;
    State.IncCycles();
    // MOV DX,0x2 (1000_AFB8 / 0x1AFB8)
    DX = 0x2;
    State.IncCycles();
    // TEST byte ptr [0xc6],0x2 (1000_AFBB / 0x1AFBB)
    Alu.And8(UInt8[DS, 0xC6], 0x2);
    State.IncCycles();
    // JZ 0x1000:afe6 (1000_AFC0 / 0x1AFC0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_AFE6_01AFE6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XOR DX,DX (1000_AFC2 / 0x1AFC2)
    DX = 0;
    State.IncCycles();
    // JMP 0x1000:afe6 (1000_AFC4 / 0x1AFC4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_AFE6_01AFE6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_AFC6_1AFC6:
    // RET  (1000_AFC6 / 0x1AFC6)
    return NearRet();
  }
  
  public virtual Action split_1000_AFE6_01AFE6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AFE6_1AFE6:
    // MOV BX,word ptr [0x2406] (1000_AFE6 / 0x1AFE6)
    BX = UInt16[DS, 0x2406];
    State.IncCycles();
    // MOV SI,word ptr [0x11bf] (1000_AFEA / 0x1AFEA)
    SI = UInt16[DS, 0x11BF];
    State.IncCycles();
    // CALL 0x1000:b150 (1000_AFEE / 0x1AFEE)
    NearCall(cs1, 0xAFF1, spice86_generated_label_call_target_1000_B150_01B150);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AFF1_01AFF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AFF1_01AFF1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AFF1_1AFF1:
    // JZ 0x1000:b006 (1000_AFF1 / 0x1AFF1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_B006_01B006, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr [0x11bf],DI (1000_AFF3 / 0x1AFF3)
    UInt16[DS, 0x11BF] = DI;
    State.IncCycles();
    // CALL 0x1000:b1af (1000_AFF7 / 0x1AFF7)
    NearCall(cs1, 0xAFFA, spice86_generated_label_call_target_1000_B1AF_01B1AF);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_AFFA_01AFFA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_AFFA_01AFFA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_AFFA_1AFFA:
    // MOV BP,0xb039 (1000_AFFA / 0x1AFFA)
    BP = 0xB039;
    State.IncCycles();
    // CALL 0x1000:b02c (1000_AFFD / 0x1AFFD)
    NearCall(cs1, 0xB000, spice86_generated_label_call_target_1000_B02C_01B02C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B000_01B000, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B000_01B000(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B000_1B000:
    // CALL 0x1000:9901 (1000_B000 / 0x1B000)
    NearCall(cs1, 0xB003, spice86_generated_label_call_target_1000_9901_019901);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B003_01B003, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B003_01B003(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B003_1B003:
    // JMP 0x1000:d397 (1000_B003 / 0x1B003)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D397_01D397, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_B006_01B006(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B006_1B006:
    // OR DX,DX (1000_B006 / 0x1B006)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JS 0x1000:b024 (1000_B008 / 0x1B008)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B024_01B024, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST byte ptr [0xc6],0x4 (1000_B00A / 0x1B00A)
    Alu.And8(UInt8[DS, 0xC6], 0x4);
    State.IncCycles();
    // JNZ 0x1000:afc6 (1000_B00F / 0x1B00F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_AFC6 / 0x1AFC6)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [0xc6],0x4 (1000_B011 / 0x1B011)
    // UInt8[DS, 0xC6] |= 0x4;
    UInt8[DS, 0xC6] = Alu.Or8(UInt8[DS, 0xC6], 0x4);
    State.IncCycles();
    // CALL 0x1000:09f5 (1000_B016 / 0x1B016)
    NearCall(cs1, 0xB019, not_observed_1000_09F5_0109F5);
    State.IncCycles();
    // XOR DX,DX (1000_B019 / 0x1B019)
    DX = 0;
    State.IncCycles();
    // CALL 0x1000:b1af (1000_B01B / 0x1B01B)
    NearCall(cs1, 0xB01E, spice86_generated_label_call_target_1000_B1AF_01B1AF);
    State.IncCycles();
    // MOV BP,0x1797 (1000_B01E / 0x1B01E)
    BP = 0x1797;
    State.IncCycles();
    // JMP 0x1000:b02c (1000_B021 / 0x1B021)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B02C_01B02C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B024_01B024(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B024_1B024:
    // MOV DH,0xff (1000_B024 / 0x1B024)
    DH = 0xFF;
    State.IncCycles();
    // CALL 0x1000:b1af (1000_B026 / 0x1B026)
    NearCall(cs1, 0xB029, spice86_generated_label_call_target_1000_B1AF_01B1AF);
    State.IncCycles();
    label_1000_B029_1B029:
    // MOV BP,0xaf43 (1000_B029 / 0x1B029)
    BP = 0xAF43;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B02C_01B02C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B02C_01B02C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B02C_1B02C:
    // CALL 0x1000:ac14 (1000_B02C / 0x1B02C)
    NearCall(cs1, 0xB02F, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    label_1000_B02F_1B02F:
    // MOV AL,0x2 (1000_B02F / 0x1B02F)
    AL = 0x2;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_B031 / 0x1B031)
    NearCall(cs1, 0xB034, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    label_1000_B034_1B034:
    // MOV AL,0xe (1000_B034 / 0x1B034)
    AL = 0xE;
    State.IncCycles();
    // JMP 0x1000:c108 (1000_B036 / 0x1B036)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C108_01C108, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B039_01B039(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B039_1B039:
    // AND byte ptr [0xc6],0xf9 (1000_B039 / 0x1B039)
    // UInt8[DS, 0xC6] &= 0xF9;
    UInt8[DS, 0xC6] = Alu.And8(UInt8[DS, 0xC6], 0xF9);
    State.IncCycles();
    // MOV SI,0xa6b0 (1000_B03E / 0x1B03E)
    SI = 0xA6B0;
    State.IncCycles();
    // MOV word ptr [0x47bc],SI (1000_B041 / 0x1B041)
    UInt16[DS, 0x47BC] = SI;
    State.IncCycles();
    // PUSH SI (1000_B045 / 0x1B045)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,word ptr [0x11bf] (1000_B046 / 0x1B046)
    SI = UInt16[DS, 0x11BF];
    State.IncCycles();
    // MOV SI,word ptr CS:[SI] (1000_B04A / 0x1B04A)
    SI = UInt16[cs1, SI];
    State.IncCycles();
    // MOV AX,SI (1000_B04D / 0x1B04D)
    AX = SI;
    State.IncCycles();
    // CALL 0x1000:b254 (1000_B04F / 0x1B04F)
    NearCall(cs1, 0xB052, spice86_generated_label_call_target_1000_B254_01B254);
    State.IncCycles();
    label_1000_B052_1B052:
    // SHR AH,1 (1000_B052 / 0x1B052)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (1000_B054 / 0x1B054)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (1000_B056 / 0x1B056)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    State.IncCycles();
    // MOV AL,AH (1000_B058 / 0x1B058)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_B05A / 0x1B05A)
    AH = 0;
    State.IncCycles();
    // ADD AX,0xf3 (1000_B05C / 0x1B05C)
    // AX += 0xF3;
    AX = Alu.Add16(AX, 0xF3);
    State.IncCycles();
    // CALL 0x1000:b126 (1000_B05F / 0x1B05F)
    NearCall(cs1, 0xB062, spice86_generated_label_call_target_1000_B126_01B126);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B062_01B062, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B062_01B062(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B062_1B062:
    // AND SI,0x7ff (1000_B062 / 0x1B062)
    SI &= 0x7FF;
    State.IncCycles();
    // SHL SI,1 (1000_B066 / 0x1B066)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_B068 / 0x1B068)
    SI <<= 0x1;
    State.IncCycles();
    // ADD SI,0xaa7a (1000_B06A / 0x1B06A)
    // SI += 0xAA7A;
    SI = Alu.Add16(SI, 0xAA7A);
    State.IncCycles();
    // MOV word ptr [0x477c],SI (1000_B06E / 0x1B06E)
    UInt16[DS, 0x477C] = SI;
    State.IncCycles();
    // LODSW SI (1000_B072 / 0x1B072)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // POP SI (1000_B073 / 0x1B073)
    SI = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_B074 / 0x1B074)
    Stack.Push(AX);
    State.IncCycles();
    // XCHG AH,AL (1000_B075 / 0x1B075)
    byte tmp_1000_B075 = AH;
    AH = AL;
    AL = tmp_1000_B075;
    State.IncCycles();
    // AND AH,0x3 (1000_B077 / 0x1B077)
    // AH &= 0x3;
    AH = Alu.And8(AH, 0x3);
    State.IncCycles();
    // OR AH,0x8 (1000_B07A / 0x1B07A)
    // AH |= 0x8;
    AH = Alu.Or8(AH, 0x8);
    State.IncCycles();
    // CALL 0x1000:b126 (1000_B07D / 0x1B07D)
    NearCall(cs1, 0xB080, spice86_generated_label_call_target_1000_B126_01B126);
    State.IncCycles();
    label_1000_B080_1B080:
    // MOV DI,word ptr [0x47bc] (1000_B080 / 0x1B080)
    DI = UInt16[DS, 0x47BC];
    State.IncCycles();
    // MOV byte ptr [DI + -0x1],0xff (1000_B084 / 0x1B084)
    UInt8[DS, (ushort)(DI - 0x1)] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:88e1 (1000_B088 / 0x1B088)
    NearCall(cs1, 0xB08B, spice86_generated_label_call_target_1000_88E1_0188E1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B08B_01B08B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B08B_01B08B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B08B_1B08B:
    // MOV SI,0x2408 (1000_B08B / 0x1B08B)
    SI = 0x2408;
    State.IncCycles();
    // CALL 0x1000:c551 (1000_B08E / 0x1B08E)
    NearCall(cs1, 0xB091, spice86_generated_label_call_target_1000_C551_01C551);
    State.IncCycles();
    label_1000_B091_1B091:
    // CALL 0x1000:1797 (1000_B091 / 0x1B091)
    NearCall(cs1, 0xB094, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    label_1000_B094_1B094:
    // MOV AX,[0xd82e] (1000_B094 / 0x1B094)
    AX = UInt16[DS, 0xD82E];
    State.IncCycles();
    // MOV BX,0x8c (1000_B097 / 0x1B097)
    BX = 0x8C;
    State.IncCycles();
    // SUB BX,AX (1000_B09A / 0x1B09A)
    BX -= AX;
    State.IncCycles();
    // SHR BX,1 (1000_B09C / 0x1B09C)
    BX >>= 0x1;
    State.IncCycles();
    // ADD BX,AX (1000_B09E / 0x1B09E)
    BX += AX;
    State.IncCycles();
    // CMP BX,0x8a (1000_B0A0 / 0x1B0A0)
    Alu.Sub16(BX, 0x8A);
    State.IncCycles();
    // JNC 0x1000:b0b5 (1000_B0A4 / 0x1B0A4)
    if(!CarryFlag) {
      goto label_1000_B0B5_1B0B5;
    }
    State.IncCycles();
    // MOV DX,0x93 (1000_B0A6 / 0x1B0A6)
    DX = 0x93;
    State.IncCycles();
    // MOV AX,0x32 (1000_B0A9 / 0x1B0A9)
    AX = 0x32;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_B0AC / 0x1B0AC)
    NearCall(cs1, 0xB0AF, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_B0AF_1B0AF:
    // MOV AX,0x4 (1000_B0AF / 0x1B0AF)
    AX = 0x4;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_B0B2 / 0x1B0B2)
    NearCall(cs1, 0xB0B5, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_B0B5_1B0B5:
    // POP AX (1000_B0B5 / 0x1B0B5)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP word ptr [0x11bf],0xaa (1000_B0B6 / 0x1B0B6)
    Alu.Sub16(UInt16[DS, 0x11BF], 0xAA);
    State.IncCycles();
    // JZ 0x1000:b0d4 (1000_B0BC / 0x1B0BC)
    if(ZeroFlag) {
      goto label_1000_B0D4_1B0D4;
    }
    State.IncCycles();
    // AND AX,0xc (1000_B0BE / 0x1B0BE)
    AX &= 0xC;
    State.IncCycles();
    // SHR AX,1 (1000_B0C1 / 0x1B0C1)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_B0C3 / 0x1B0C3)
    AX >>= 0x1;
    State.IncCycles();
    // ADD AX,0x103 (1000_B0C5 / 0x1B0C5)
    // AX += 0x103;
    AX = Alu.Add16(AX, 0x103);
    State.IncCycles();
    // MOV BX,0x8b (1000_B0C8 / 0x1B0C8)
    BX = 0x8B;
    State.IncCycles();
    // MOV DX,0xfa (1000_B0CB / 0x1B0CB)
    DX = 0xFA;
    State.IncCycles();
    // MOV CX,0x64 (1000_B0CE / 0x1B0CE)
    CX = 0x64;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_B0D1 / 0x1B0D1)
    NearCall(cs1, 0xB0D4, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    label_1000_B0D4_1B0D4:
    // MOV BX,0x3 (1000_B0D4 / 0x1B0D4)
    BX = 0x3;
    State.IncCycles();
    // MOV DX,0x132 (1000_B0D7 / 0x1B0D7)
    DX = 0x132;
    State.IncCycles();
    // CALL 0x1000:d04e (1000_B0DA / 0x1B0DA)
    NearCall(cs1, 0xB0DD, spice86_generated_label_call_target_1000_D04E_01D04E);
    State.IncCycles();
    label_1000_B0DD_1B0DD:
    // MOV word ptr [0xdbe4],0x53 (1000_B0DD / 0x1B0DD)
    UInt16[DS, 0xDBE4] = 0x53;
    State.IncCycles();
    // MOV AX,[0x11bf] (1000_B0E3 / 0x1B0E3)
    AX = UInt16[DS, 0x11BF];
    State.IncCycles();
    // SUB AX,0xaa (1000_B0E6 / 0x1B0E6)
    AX -= 0xAA;
    State.IncCycles();
    // SHR AX,1 (1000_B0E9 / 0x1B0E9)
    AX >>= 0x1;
    State.IncCycles();
    // INC AX (1000_B0EB / 0x1B0EB)
    AX++;
    State.IncCycles();
    // AAM 0xa (1000_B0EC / 0x1B0EC)
    Cpu.Aam(0xA);
    State.IncCycles();
    // ADD AX,0x3030 (1000_B0EE / 0x1B0EE)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    State.IncCycles();
    // XCHG AH,AL (1000_B0F1 / 0x1B0F1)
    byte tmp_1000_B0F1 = AH;
    AH = AL;
    AL = tmp_1000_B0F1;
    State.IncCycles();
    // CMP AL,0x30 (1000_B0F3 / 0x1B0F3)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:b0f9 (1000_B0F5 / 0x1B0F5)
    if(!ZeroFlag) {
      goto label_1000_B0F9_1B0F9;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_B0F7 / 0x1B0F7)
    AL = 0x20;
    State.IncCycles();
    label_1000_B0F9_1B0F9:
    // PUSH AX (1000_B0F9 / 0x1B0F9)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:d12f (1000_B0FA / 0x1B0FA)
    NearCall(cs1, 0xB0FD, spice86_generated_label_call_target_1000_D12F_01D12F);
    State.IncCycles();
    label_1000_B0FD_1B0FD:
    // POP AX (1000_B0FD / 0x1B0FD)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV AL,AH (1000_B0FE / 0x1B0FE)
    AL = AH;
    State.IncCycles();
    // CALL 0x1000:d12f (1000_B100 / 0x1B100)
    NearCall(cs1, 0xB103, spice86_generated_label_call_target_1000_D12F_01D12F);
    State.IncCycles();
    label_1000_B103_1B103:
    // MOV byte ptr [0x1c30],0x0 (1000_B103 / 0x1B103)
    UInt8[DS, 0x1C30] = 0x0;
    State.IncCycles();
    // MOV AX,[0x243e] (1000_B108 / 0x1B108)
    AX = UInt16[DS, 0x243E];
    State.IncCycles();
    // OR AX,AX (1000_B10B / 0x1B10B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:b125 (1000_B10D / 0x1B10D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_B125 / 0x1B125)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x1c30],0x80 (1000_B10F / 0x1B10F)
    UInt8[DS, 0x1C30] = 0x80;
    State.IncCycles();
    // MOV SI,0x2412 (1000_B114 / 0x1B114)
    SI = 0x2412;
    State.IncCycles();
    // ADD AX,0xfff5 (1000_B117 / 0x1B117)
    // AX += 0xFFF5;
    AX = Alu.Add16(AX, 0xFFF5);
    State.IncCycles();
    // MOV word ptr [SI],AX (1000_B11A / 0x1B11A)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0x6],AX (1000_B11C / 0x1B11C)
    UInt16[DS, (ushort)(SI + 0x6)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0xc],AX (1000_B11F / 0x1B11F)
    UInt16[DS, (ushort)(SI + 0xC)] = AX;
    State.IncCycles();
    // CALL 0x1000:c21b (1000_B122 / 0x1B122)
    NearCall(cs1, 0xB125, spice86_generated_label_call_target_1000_C21B_01C21B);
    State.IncCycles();
    label_1000_B125_1B125:
    // RET  (1000_B125 / 0x1B125)
    return NearRet();
  }
  
}
