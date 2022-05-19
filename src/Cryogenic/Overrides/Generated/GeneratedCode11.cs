namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_97AC_0197AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97AC_197AC:
    // MOV SI,word ptr [0x47c8] (1000_97AC / 0x197AC)
    SI = UInt16[DS, 0x47C8];
    // OR SI,SI (1000_97B0 / 0x197B0)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:97c8 (1000_97B2 / 0x197B2)
    if(ZeroFlag) {
      goto label_1000_97C8_197C8;
    }
    // MOV word ptr [0x4540],0x0 (1000_97B4 / 0x197B4)
    UInt16[DS, 0x4540] = 0x0;
    // CALL 0x1000:9bac (1000_97BA / 0x197BA)
    NearCall(cs1, 0x97BD, spice86_generated_label_call_target_1000_9BAC_019BAC);
    label_1000_97BD_197BD:
    // CMP word ptr [0x479e],0x223c (1000_97BD / 0x197BD)
    Alu.Sub16(UInt16[DS, 0x479E], 0x223C);
    // JNZ 0x1000:97c8 (1000_97C3 / 0x197C3)
    if(!ZeroFlag) {
      goto label_1000_97C8_197C8;
    }
    // CALL 0x1000:9025 (1000_97C5 / 0x197C5)
    NearCall(cs1, 0x97C8, spice86_generated_label_call_target_1000_9025_019025);
    label_1000_97C8_197C8:
    // CALL 0x1000:c0f4 (1000_97C8 / 0x197C8)
    NearCall(cs1, 0x97CB, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97CB_0197CB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97CB_0197CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97CB_197CB:
    // JMP 0x1000:c4dd (1000_97CB / 0x197CB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_97CE_0197CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97CE_197CE:
    // RET  (1000_97CE / 0x197CE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_97CF_0197CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97CF_197CF:
    // CALL 0x1000:a7a5 (1000_97CF / 0x197CF)
    NearCall(cs1, 0x97D2, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97D2_0197D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97D2_0197D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97D2_197D2:
    // CMP word ptr [0x47c4],-0x1 (1000_97D2 / 0x197D2)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xFFFF);
    // JZ 0x1000:97ce (1000_97D7 / 0x197D7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_97CE / 0x197CE)
      return NearRet();
    }
    // MOV SI,word ptr [0x47a2] (1000_97D9 / 0x197D9)
    SI = UInt16[DS, 0x47A2];
    // OR byte ptr [SI + 0xf],0x20 (1000_97DD / 0x197DD)
    UInt8[DS, (ushort)(SI + 0xF)] |= 0x20;
    // AND byte ptr [SI + 0xf],0xfb (1000_97E1 / 0x197E1)
    // UInt8[DS, (ushort)(SI + 0xF)] &= 0xFB;
    UInt8[DS, (ushort)(SI + 0xF)] = Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0xFB);
    // MOV word ptr [0x47e1],0x0 (1000_97E5 / 0x197E5)
    UInt16[DS, 0x47E1] = 0x0;
    // CMP byte ptr [0x11c9],0x0 (1000_97EB / 0x197EB)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JZ 0x1000:980c (1000_97F0 / 0x197F0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_980C_01980C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:8c8a (1000_97F2 / 0x197F2)
    NearCall(cs1, 0x97F5, spice86_generated_label_call_target_1000_8C8A_018C8A);
    label_1000_97F5_197F5:
    // MOV BP,0x98b2 (1000_97F5 / 0x197F5)
    BP = 0x98B2;
    // CALL 0x1000:c097 (1000_97F8 / 0x197F8)
    NearCall(cs1, 0x97FB, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97FB_0197FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97FB_0197FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97FB_197FB:
    // XOR AL,AL (1000_97FB / 0x197FB)
    AL = 0;
    // XCHG byte ptr [0x11ca],AL (1000_97FD / 0x197FD)
    byte tmp_1000_97FD = UInt8[DS, 0x11CA];
    UInt8[DS, 0x11CA] = AL;
    AL = tmp_1000_97FD;
    // PUSH AX (1000_9801 / 0x19801)
    Stack.Push(AX);
    // CALL 0x1000:2ffb (1000_9802 / 0x19802)
    NearCall(cs1, 0x9805, spice86_generated_label_call_target_1000_2FFB_012FFB);
    label_1000_9805_19805:
    // POP AX (1000_9805 / 0x19805)
    AX = Stack.Pop();
    // MOV [0x11ca],AL (1000_9806 / 0x19806)
    UInt8[DS, 0x11CA] = AL;
    // JMP 0x1000:4abe (1000_9809 / 0x19809)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4ABE_014ABE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_980C_01980C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_980C_1980C:
    // CALL 0x1000:8c8a (1000_980C / 0x1980C)
    NearCall(cs1, 0x980F, spice86_generated_label_call_target_1000_8C8A_018C8A);
    label_1000_980F_1980F:
    // CMP byte ptr [0x47a4],0x0 (1000_980F / 0x1980F)
    Alu.Sub8(UInt8[DS, 0x47A4], 0x0);
    // MOV SI,word ptr [0x47a2] (1000_9814 / 0x19814)
    SI = UInt16[DS, 0x47A2];
    // JS 0x1000:9849 (1000_9818 / 0x19818)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9849_019849, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x2b],0x0 (1000_981A / 0x1981A)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:9825 (1000_981F / 0x1981F)
    if(ZeroFlag) {
      goto label_1000_9825_19825;
    }
    // MOV AX,0x9840 (1000_9821 / 0x19821)
    AX = 0x9840;
    // PUSH AX (1000_9824 / 0x19824)
    Stack.Push(AX);
    label_1000_9825_19825:
    // TEST byte ptr [SI + 0xf],0x40 (1000_9825 / 0x19825)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JZ 0x1000:982e (1000_9829 / 0x19829)
    if(ZeroFlag) {
      goto label_1000_982E_1982E;
    }
    // JMP 0x1000:9673 (1000_982B / 0x1982B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9673_019673, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_982E_1982E:
    // CALL 0x1000:9655 (1000_982E / 0x1982E)
    NearCall(cs1, 0x9831, not_observed_1000_9655_019655);
    // CMP byte ptr [0x2b],0x0 (1000_9831 / 0x19831)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:983f (1000_9836 / 0x19836)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_983F / 0x1983F)
      return NearRet();
    }
    // TEST byte ptr [0x47a4],0x1 (1000_9838 / 0x19838)
    Alu.And8(UInt8[DS, 0x47A4], 0x1);
    // JZ 0x1000:9879 (1000_983D / 0x1983D)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9849_019849, 0x19879 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_983F_1983F:
    // RET  (1000_983F / 0x1983F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9849_019849(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9849_19849:
    // MOV word ptr [0x1c06],0x0 (1000_9849 / 0x19849)
    UInt16[DS, 0x1C06] = 0x0;
    // TEST byte ptr [SI + 0xf],0x40 (1000_984F / 0x1984F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JZ 0x1000:9858 (1000_9853 / 0x19853)
    if(ZeroFlag) {
      goto label_1000_9858_19858;
    }
    // CALL 0x1000:9673 (1000_9855 / 0x19855)
    NearCall(cs1, 0x9858, spice86_generated_label_call_target_1000_9673_019673);
    label_1000_9858_19858:
    // XOR AX,AX (1000_9858 / 0x19858)
    AX = 0;
    // MOV [0x4540],AX (1000_985A / 0x1985A)
    UInt16[DS, 0x4540] = AX;
    // MOV [0x479e],AX (1000_985D / 0x1985D)
    UInt16[DS, 0x479E] = AX;
    // AND byte ptr [0x47d1],0x3f (1000_9860 / 0x19860)
    // UInt8[DS, 0x47D1] &= 0x3F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x3F);
    // MOV [0x47c8],AX (1000_9865 / 0x19865)
    UInt16[DS, 0x47C8] = AX;
    // AND byte ptr [0x47a4],0x7f (1000_9868 / 0x19868)
    // UInt8[DS, 0x47A4] &= 0x7F;
    UInt8[DS, 0x47A4] = Alu.And8(UInt8[DS, 0x47A4], 0x7F);
    // CALL 0x1000:9b8b (1000_986D / 0x1986D)
    NearCall(cs1, 0x9870, spice86_generated_label_call_target_1000_9B8B_019B8B);
    label_1000_9870_19870:
    // MOV AL,[0x23] (1000_9870 / 0x19870)
    AL = UInt8[DS, 0x23];
    // SUB AL,0x64 (1000_9873 / 0x19873)
    AL -= 0x64;
    // CMP AL,0x10 (1000_9875 / 0x19875)
    Alu.Sub8(AL, 0x10);
    // JC 0x1000:9898 (1000_9877 / 0x19877)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_9898_019898, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_9879_19879:
    // CALL 0x1000:2efb (1000_9879 / 0x19879)
    NearCall(cs1, 0x987C, spice86_generated_label_call_target_1000_2EFB_012EFB);
    label_1000_987C_1987C:
    // CMP byte ptr [0x11c9],0x0 (1000_987C / 0x1987C)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:9886 (1000_9881 / 0x19881)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9886_019886, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:3090 (1000_9883 / 0x19883)
    NearCall(cs1, 0x9886, spice86_generated_label_call_target_1000_3090_013090);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9886_019886, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9886_019886(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9886_19886:
    // CALL 0x1000:37b2 (1000_9886 / 0x19886)
    NearCall(cs1, 0x9889, spice86_generated_label_call_target_1000_37B2_0137B2);
    label_1000_9889_19889:
    // CALL 0x1000:c412 (1000_9889 / 0x19889)
    NearCall(cs1, 0x988C, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_988C_1988C:
    // CALL 0x1000:c0f4 (1000_988C / 0x1988C)
    NearCall(cs1, 0x988F, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    label_1000_988F_1988F:
    // CALL 0x1000:1834 (1000_988F / 0x1988F)
    NearCall(cs1, 0x9892, spice86_generated_label_call_target_1000_1834_011834);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9892_019892, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9892_019892(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9892_19892:
    // CALL 0x1000:c4dd (1000_9892 / 0x19892)
    NearCall(cs1, 0x9895, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_9895_19895:
    // JMP 0x1000:17e6 (1000_9895 / 0x19895)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9898_019898(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9898_19898:
    // MOV BP,0x37b2 (1000_9898 / 0x19898)
    BP = 0x37B2;
    // CALL 0x1000:c097 (1000_989B / 0x1989B)
    NearCall(cs1, 0x989E, spice86_generated_label_call_target_1000_C097_01C097);
    // CALL 0x1000:36d3 (1000_989E / 0x1989E)
    NearCall(cs1, 0x98A1, spice86_generated_label_call_target_1000_36D3_0136D3);
    // MOV AX,0xc8 (1000_98A1 / 0x198A1)
    AX = 0xC8;
    // CALL 0x1000:e3a0 (1000_98A4 / 0x198A4)
    NearCall(cs1, 0x98A7, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    // MOV word ptr [0x1c06],0x0 (1000_98A7 / 0x198A7)
    UInt16[DS, 0x1C06] = 0x0;
    // JMP 0x1000:9858 (1000_98AD / 0x198AD)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9849_019849, 0x19858 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_98AF_0198AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_98AF_198AF:
    // CALL 0x1000:8c8a (1000_98AF / 0x198AF)
    NearCall(cs1, 0x98B2, spice86_generated_label_call_target_1000_8C8A_018C8A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_98B2_0198B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_98B2_0198B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_98B2_198B2:
    // CMP byte ptr [0x47c3],0x0 (1000_98B2 / 0x198B2)
    Alu.Sub8(UInt8[DS, 0x47C3], 0x0);
    // JNZ 0x1000:98e5 (1000_98B7 / 0x198B7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_98E5 / 0x198E5)
      return NearRet();
    }
    // XOR AX,AX (1000_98B9 / 0x198B9)
    AX = 0;
    // MOV [0x4540],AX (1000_98BB / 0x198BB)
    UInt16[DS, 0x4540] = AX;
    // AND byte ptr [0x47d1],0x3f (1000_98BE / 0x198BE)
    // UInt8[DS, 0x47D1] &= 0x3F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x3F);
    // XCHG word ptr [0x47c8],AX (1000_98C3 / 0x198C3)
    ushort tmp_1000_98C3 = UInt16[DS, 0x47C8];
    UInt16[DS, 0x47C8] = AX;
    AX = tmp_1000_98C3;
    // OR AX,AX (1000_98C7 / 0x198C7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:98e5 (1000_98C9 / 0x198C9)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_98E5 / 0x198E5)
      return NearRet();
    }
    // MOV SI,0x1bf0 (1000_98CB / 0x198CB)
    SI = 0x1BF0;
    // MOV word ptr [SI + 0x8],0x0 (1000_98CE / 0x198CE)
    UInt16[DS, (ushort)(SI + 0x8)] = 0x0;
    // MOV word ptr [0x1c06],0x0 (1000_98D3 / 0x198D3)
    UInt16[DS, 0x1C06] = 0x0;
    // CALL 0x1000:c446 (1000_98D9 / 0x198D9)
    NearCall(cs1, 0x98DC, spice86_generated_label_call_target_1000_C446_01C446);
    label_1000_98DC_198DC:
    // MOV SI,0x1bf0 (1000_98DC / 0x198DC)
    SI = 0x1BF0;
    // CALL 0x1000:c4f0 (1000_98DF / 0x198DF)
    NearCall(cs1, 0x98E2, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    label_1000_98E2_198E2:
    // JMP 0x1000:9b8b (1000_98E2 / 0x198E2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9B8B_019B8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_98E5_198E5:
    // RET  (1000_98E5 / 0x198E5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_98E6_0198E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_98E6_198E6:
    // CALL 0x1000:98f5 (1000_98E6 / 0x198E6)
    NearCall(cs1, 0x98E9, spice86_generated_label_call_target_1000_98F5_0198F5);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_98F5_0198F5, 0x198E9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_98F5_0198F5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x98E9: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_98E9_198E9:
    // MOV [0x47c8],AX (1000_98E9 / 0x198E9)
    UInt16[DS, 0x47C8] = AX;
    // MOV [0x47aa],AX (1000_98EC / 0x198EC)
    UInt16[DS, 0x47AA] = AX;
    // MOV [0x479e],AX (1000_98EF / 0x198EF)
    UInt16[DS, 0x479E] = AX;
    // JMP 0x1000:9b8b (1000_98F2 / 0x198F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9B8B_019B8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    entry:
    label_1000_98F5_198F5:
    // XOR AX,AX (1000_98F5 / 0x198F5)
    AX = 0;
    // MOV [0x1c06],AX (1000_98F7 / 0x198F7)
    UInt16[DS, 0x1C06] = AX;
    // MOV [0x1bf8],AX (1000_98FA / 0x198FA)
    UInt16[DS, 0x1BF8] = AX;
    // MOV [0x1bea],AX (1000_98FD / 0x198FD)
    UInt16[DS, 0x1BEA] = AX;
    // RET  (1000_9900 / 0x19900)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9901_019901(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9901_19901:
    // MOV word ptr [0x479e],0x0 (1000_9901 / 0x19901)
    UInt16[DS, 0x479E] = 0x0;
    // RET  (1000_9907 / 0x19907)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9908_019908(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9908_19908:
    // MOV SI,word ptr [0x47ca] (1000_9908 / 0x19908)
    SI = UInt16[DS, 0x47CA];
    // MOV ES,word ptr [0xdbb2] (1000_990C / 0x1990C)
    ES = UInt16[DS, 0xDBB2];
    // CALL 0x1000:994f (1000_9910 / 0x19910)
    NearCall(cs1, 0x9913, spice86_generated_label_call_target_1000_994F_01994F);
    label_1000_9913_19913:
    // MOV byte ptr [0x47d1],0xc0 (1000_9913 / 0x19913)
    UInt8[DS, 0x47D1] = 0xC0;
    // MOV AL,[0x478c] (1000_9918 / 0x19918)
    AL = UInt8[DS, 0x478C];
    // XOR AH,AH (1000_991B / 0x1991B)
    AH = 0;
    // SHL AX,1 (1000_991D / 0x1991D)
    AX <<= 0x1;
    // SHL AX,1 (1000_991F / 0x1991F)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV [0x47ce],AX (1000_9921 / 0x19921)
    UInt16[DS, 0x47CE] = AX;
    // ADD SI,word ptr ES:[BP + SI] (1000_9924 / 0x19924)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    // CALL 0x1000:996c (1000_9927 / 0x19927)
    NearCall(cs1, 0x992A, spice86_generated_label_call_target_1000_996C_01996C);
    label_1000_992A_1992A:
    // MOV word ptr [0x47c8],SI (1000_992A / 0x1992A)
    UInt16[DS, 0x47C8] = SI;
    // XCHG word ptr [0x47c6],SI (1000_992E / 0x1992E)
    ushort tmp_1000_992E = UInt16[DS, 0x47C6];
    UInt16[DS, 0x47C6] = SI;
    SI = tmp_1000_992E;
    // OR SI,SI (1000_9932 / 0x19932)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JNZ 0x1000:994e (1000_9934 / 0x19934)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_994E / 0x1994E)
      return NearRet();
    }
    // CMP byte ptr [0xea],0x0 (1000_9936 / 0x19936)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    // JG 0x1000:994e (1000_993B / 0x1993B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_994E / 0x1994E)
      return NearRet();
    }
    // MOV AX,[0x47c4] (1000_993D / 0x1993D)
    AX = UInt16[DS, 0x47C4];
    // CALL 0x1000:127c (1000_9940 / 0x19940)
    NearCall(cs1, 0x9943, spice86_generated_label_call_target_1000_127C_01127C);
    label_1000_9943_19943:
    // JC 0x1000:994e (1000_9943 / 0x19943)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_994E / 0x1994E)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_9945_019945, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9945_019945(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x994E: goto label_1000_994E_1994E;break; // Target of external jump from 0x19934
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9945_19945:
    // MOV SI,0x99be (1000_9945 / 0x19945)
    SI = 0x99BE;
    // MOV BP,0x10 (1000_9948 / 0x19948)
    BP = 0x10;
    // CALL 0x1000:da25 (1000_994B / 0x1994B)
    NearCall(cs1, 0x994E, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_994E_1994E:
    // RET  (1000_994E / 0x1994E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_994F_01994F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_994F_1994F:
    // MOV AL,[0x47d0] (1000_994F / 0x1994F)
    AL = UInt8[DS, 0x47D0];
    // OR AL,AL (1000_9952 / 0x19952)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:9963 (1000_9954 / 0x19954)
    if(!ZeroFlag) {
      goto label_1000_9963_19963;
    }
    // MOV BX,0x6 (1000_9956 / 0x19956)
    BX = 0x6;
    // CALL 0x1000:e3b7 (1000_9959 / 0x19959)
    NearCall(cs1, 0x995C, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    label_1000_995C_1995C:
    // MOV BP,AX (1000_995C / 0x1995C)
    BP = AX;
    // ADD BP,word ptr [0xf0] (1000_995E / 0x1995E)
    // BP += UInt16[DS, 0xF0];
    BP = Alu.Add16(BP, UInt16[DS, 0xF0]);
    // RET  (1000_9962 / 0x19962)
    return NearRet();
    label_1000_9963_19963:
    // DEC AL (1000_9963 / 0x19963)
    AL--;
    // XOR AH,AH (1000_9965 / 0x19965)
    AH = 0;
    // SHL AX,1 (1000_9967 / 0x19967)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_9969 / 0x19969)
    BP = AX;
    // RET  (1000_996B / 0x1996B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_996C_01996C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_996C_1996C:
    // CMP byte ptr [0x47d0],0x0 (1000_996C / 0x1996C)
    Alu.Sub8(UInt8[DS, 0x47D0], 0x0);
    // JZ 0x1000:9981 (1000_9971 / 0x19971)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9981 / 0x19981)
      return NearRet();
    }
    // MOV CX,0x20 (1000_9973 / 0x19973)
    CX = 0x20;
    // PUSH ES (1000_9976 / 0x19976)
    Stack.Push(ES);
    // POP DS (1000_9977 / 0x19977)
    DS = Stack.Pop();
    label_1000_9978_19978:
    // LODSB SI (1000_9978 / 0x19978)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_9979 / 0x19979)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:9978 (1000_997B / 0x1997B)
    if(!ZeroFlag) {
      goto label_1000_9978_19978;
    }
    // LOOP 0x1000:9978 (1000_997D / 0x1997D)
    if(--CX != 0) {
      goto label_1000_9978_19978;
    }
    // PUSH SS (1000_997F / 0x1997F)
    Stack.Push(SS);
    // POP DS (1000_9980 / 0x19980)
    DS = Stack.Pop();
    label_1000_9981_19981:
    // RET  (1000_9981 / 0x19981)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9985_019985(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9982: break; // Instructions before entry targeted by 0x1998B
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_9982_19982:
    // CALL 0x1000:99be (1000_9982 / 0x19982)
    NearCall(cs1, 0x9985, spice86_generated_label_call_target_1000_99BE_0199BE);
    entry:
    label_1000_9985_19985:
    // TEST word ptr [0x47ce],0x7 (1000_9985 / 0x19985)
    Alu.And16(UInt16[DS, 0x47CE], 0x7);
    // JNZ 0x1000:9982 (1000_998B / 0x1998B)
    if(!ZeroFlag) {
      goto label_1000_9982_19982;
    }
    // RET  (1000_998D / 0x1998D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_998E_01998E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_998E_1998E:
    // MOV DI,0x4c60 (1000_998E / 0x1998E)
    DI = 0x4C60;
    // MOV SI,0x1bf0 (1000_9991 / 0x19991)
    SI = 0x1BF0;
    // MOV CX,0x4 (1000_9994 / 0x19994)
    CX = 0x4;
    // CALL 0x1000:99b2 (1000_9997 / 0x19997)
    NearCall(cs1, 0x999A, not_observed_1000_99B2_0199B2);
    // MOV SI,0x22a6 (1000_999A / 0x1999A)
    SI = 0x22A6;
    // MOV CX,0x1 (1000_999D / 0x1999D)
    CX = 0x1;
    // CALL 0x1000:99b2 (1000_99A0 / 0x199A0)
    NearCall(cs1, 0x99A3, not_observed_1000_99B2_0199B2);
    // MOV SI,0x4540 (1000_99A3 / 0x199A3)
    SI = 0x4540;
    // MOV CX,0xc9 (1000_99A6 / 0x199A6)
    CX = 0xC9;
    // CALL 0x1000:99b2 (1000_99A9 / 0x199A9)
    NearCall(cs1, 0x99AC, not_observed_1000_99B2_0199B2);
    // MOV SI,0x47c4 (1000_99AC / 0x199AC)
    SI = 0x47C4;
    // MOV CX,0x7 (1000_99AF / 0x199AF)
    CX = 0x7;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_99B2_0199B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_99B2_0199B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_99B2_199B2:
    // LODSW SI (1000_99B2 / 0x199B2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG word ptr [DI],AX (1000_99B3 / 0x199B3)
    ushort tmp_1000_99B3 = UInt16[DS, DI];
    UInt16[DS, DI] = AX;
    AX = tmp_1000_99B3;
    // MOV word ptr [SI + -0x2],AX (1000_99B5 / 0x199B5)
    UInt16[DS, (ushort)(SI - 0x2)] = AX;
    // ADD DI,0x2 (1000_99B8 / 0x199B8)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // LOOP 0x1000:99b2 (1000_99BB / 0x199BB)
    if(--CX != 0) {
      goto label_1000_99B2_199B2;
    }
    // RET  (1000_99BD / 0x199BD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_99BE_0199BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_99BE_199BE:
    // CMP byte ptr [0x47c3],0x0 (1000_99BE / 0x199BE)
    Alu.Sub8(UInt8[DS, 0x47C3], 0x0);
    // JZ 0x1000:99da (1000_99C3 / 0x199C3)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_99DA_199DA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:998e (1000_99C5 / 0x199C5)
    NearCall(cs1, 0x99C8, not_observed_1000_998E_01998E);
    // MOV AX,0x7 (1000_99C8 / 0x199C8)
    AX = 0x7;
    // CALL 0x1000:920f (1000_99CB / 0x199CB)
    NearCall(cs1, 0x99CE, spice86_generated_label_call_target_1000_920F_01920F);
    // CALL 0x1000:99da (1000_99CE / 0x199CE)
    NearCall(cs1, 0x99D1, spice86_label_1000_99DA_199DA);
    // CALL 0x1000:998e (1000_99D1 / 0x199D1)
    NearCall(cs1, 0x99D4, not_observed_1000_998E_01998E);
    // MOV AX,0x2d (1000_99D4 / 0x199D4)
    AX = 0x2D;
    // CALL 0x1000:920f (1000_99D7 / 0x199D7)
    NearCall(cs1, 0x99DA, spice86_generated_label_call_target_1000_920F_01920F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_label_1000_99DA_199DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_label_1000_99DA_199DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_99DA_199DA:
    // CALL 0x1000:9197 (1000_99DA / 0x199DA)
    NearCall(cs1, 0x99DD, spice86_generated_label_call_target_1000_9197_019197);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_99DD_0199DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_99DD_0199DD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x99F0: goto label_1000_99F0_199F0;break; // Target of external jump from 0x19A39
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_99DD_199DD:
    // MOV AL,[0x47d1] (1000_99DD / 0x199DD)
    AL = UInt8[DS, 0x47D1];
    // OR AL,AL (1000_99E0 / 0x199E0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:9a1c (1000_99E2 / 0x199E2)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_9A1C / 0x19A1C)
      return NearRet();
    }
    // TEST AL,0x10 (1000_99E4 / 0x199E4)
    Alu.And8(AL, 0x10);
    // JNZ 0x1000:9a40 (1000_99E6 / 0x199E6)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9A1D_019A1D, 0x19A40 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,word ptr [0x47c6] (1000_99E8 / 0x199E8)
    SI = UInt16[DS, 0x47C6];
    // MOV ES,word ptr [0xdbb2] (1000_99EC / 0x199EC)
    ES = UInt16[DS, 0xDBB2];
    label_1000_99F0_199F0:
    // CMP byte ptr ES:[SI],0xff (1000_99F0 / 0x199F0)
    Alu.Sub8(UInt8[ES, SI], 0xFF);
    // JZ 0x1000:9a1d (1000_99F4 / 0x199F4)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9A1D_019A1D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_99F6_0199F6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9A1C: goto label_1000_9A1C_19A1C;break; // Target of external jump from 0x19A59, 0x19A0B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_99F6_199F6:
    // DEC word ptr [0x47ce] (1000_99F6 / 0x199F6)
    UInt16[DS, 0x47CE] = Alu.Dec16(UInt16[DS, 0x47CE]);
    // MOV word ptr [0x47c8],SI (1000_99FA / 0x199FA)
    UInt16[DS, 0x47C8] = SI;
    // CALL 0x1000:9bb1 (1000_99FE / 0x199FE)
    NearCall(cs1, 0x9A01, spice86_generated_label_call_target_1000_9BB1_019BB1);
    label_1000_9A01_19A01:
    // MOV word ptr [0x47c6],SI (1000_9A01 / 0x19A01)
    UInt16[DS, 0x47C6] = SI;
    // CMP word ptr [0xd834],0x13f (1000_9A05 / 0x19A05)
    Alu.Sub16(UInt16[DS, 0xD834], 0x13F);
    // JZ 0x1000:9a1c (1000_9A0B / 0x19A0B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9A1C / 0x19A1C)
      return NearRet();
    }
    // CALL 0x1000:908c (1000_9A0D / 0x19A0D)
    NearCall(cs1, 0x9A10, spice86_generated_label_call_target_1000_908C_01908C);
    label_1000_9A10_19A10:
    // MOV SI,0xd834 (1000_9A10 / 0x19A10)
    SI = 0xD834;
    // CALL 0x1000:db74 (1000_9A13 / 0x19A13)
    NearCall(cs1, 0x9A16, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_9A16_19A16:
    // CALL 0x1000:c4f0 (1000_9A16 / 0x19A16)
    NearCall(cs1, 0x9A19, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    label_1000_9A19_19A19:
    // JMP 0x1000:db67 (1000_9A19 / 0x19A19)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9A1C_19A1C:
    // RET  (1000_9A1C / 0x19A1C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9A1D_019A1D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9A40: goto label_1000_9A40_19A40;break; // Target of external jump from 0x199E6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9A1D_19A1D:
    // CMP word ptr [0x47ce],0x0 (1000_9A1D / 0x19A1D)
    Alu.Sub16(UInt16[DS, 0x47CE], 0x0);
    // JS 0x1000:9a3b (1000_9A22 / 0x19A22)
    if(SignFlag) {
      goto label_1000_9A3B_19A3B;
    }
    // MOV SI,word ptr [0x47ca] (1000_9A24 / 0x19A24)
    SI = UInt16[DS, 0x47CA];
    // MOV ES,word ptr [0xdbb2] (1000_9A28 / 0x19A28)
    ES = UInt16[DS, 0xDBB2];
    // CALL 0x1000:994f (1000_9A2C / 0x19A2C)
    NearCall(cs1, 0x9A2F, spice86_generated_label_call_target_1000_994F_01994F);
    label_1000_9A2F_19A2F:
    // ADD SI,word ptr ES:[BP + SI] (1000_9A2F / 0x19A2F)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    // CALL 0x1000:996c (1000_9A32 / 0x19A32)
    NearCall(cs1, 0x9A35, spice86_generated_label_call_target_1000_996C_01996C);
    label_1000_9A35_19A35:
    // MOV word ptr [0x47c6],SI (1000_9A35 / 0x19A35)
    UInt16[DS, 0x47C6] = SI;
    // JMP 0x1000:99f0 (1000_9A39 / 0x19A39)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_99DD_0199DD, 0x199F0 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9A3B_19A3B:
    // OR byte ptr [0x47d1],0x10 (1000_9A3B / 0x19A3B)
    // UInt8[DS, 0x47D1] |= 0x10;
    UInt8[DS, 0x47D1] = Alu.Or8(UInt8[DS, 0x47D1], 0x10);
    label_1000_9A40_19A40:
    // MOV SI,word ptr [0x47c6] (1000_9A40 / 0x19A40)
    SI = UInt16[DS, 0x47C6];
    // MOV ES,word ptr [0xdbb2] (1000_9A44 / 0x19A44)
    ES = UInt16[DS, 0xDBB2];
    // CMP word ptr [0x47ce],0x0 (1000_9A48 / 0x19A48)
    Alu.Sub16(UInt16[DS, 0x47CE], 0x0);
    // JG 0x1000:99f6 (1000_9A4D / 0x19A4D)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:9ab4 (1000_9A4F / 0x19A4F)
    NearCall(cs1, 0x9A52, spice86_generated_label_call_target_1000_9AB4_019AB4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9A52_019A52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9A52_019A52(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9A52_19A52:
    // JC 0x1000:99f6 (1000_9A52 / 0x19A52)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:9a7b (1000_9A54 / 0x19A54)
    NearCall(cs1, 0x9A57, spice86_generated_label_call_target_1000_9A7B_019A7B);
    label_1000_9A57_19A57:
    // OR AH,AH (1000_9A57 / 0x19A57)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JNZ 0x1000:9a1c (1000_9A59 / 0x19A59)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_9A1C / 0x19A1C)
      return NearRet();
    }
    // CALL 0x1000:9a60 (1000_9A5B / 0x19A5B)
    NearCall(cs1, 0x9A5E, spice86_generated_label_call_target_1000_9A60_019A60);
    label_1000_9A5E_19A5E:
    // JMP 0x1000:99f6 (1000_9A5E / 0x19A5E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9A60_019A60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9A60_19A60:
    // OR AL,AL (1000_9A60 / 0x19A60)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:9a74 (1000_9A62 / 0x19A62)
    if(ZeroFlag) {
      goto label_1000_9A74_19A74;
    }
    // MOV BX,AX (1000_9A64 / 0x19A64)
    BX = AX;
    // XOR AL,AL (1000_9A66 / 0x19A66)
    AL = 0;
    // MOV CX,0xffff (1000_9A68 / 0x19A68)
    CX = 0xFFFF;
    // MOV DI,SI (1000_9A6B / 0x19A6B)
    DI = SI;
    label_1000_9A6D_19A6D:
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_9A6D / 0x19A6D)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    // DEC BX (1000_9A6F / 0x19A6F)
    BX = Alu.Dec16(BX);
    // JNZ 0x1000:9a6d (1000_9A70 / 0x19A70)
    if(!ZeroFlag) {
      goto label_1000_9A6D_19A6D;
    }
    // MOV SI,DI (1000_9A72 / 0x19A72)
    SI = DI;
    label_1000_9A74_19A74:
    // MOV word ptr [0x47ce],0x8 (1000_9A74 / 0x19A74)
    UInt16[DS, 0x47CE] = 0x8;
    // RET  (1000_9A7A / 0x19A7A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9A7B_019A7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9A7B_19A7B:
    // MOV AL,[0x47d0] (1000_9A7B / 0x19A7B)
    AL = UInt8[DS, 0x47D0];
    // MOV BX,0xf18 (1000_9A7E / 0x19A7E)
    BX = 0xF18;
    // OR AL,AL (1000_9A81 / 0x19A81)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:9a9a (1000_9A83 / 0x19A83)
    if(!ZeroFlag) {
      goto label_1000_9A9A_19A9A;
    }
    // MOV AL,0x5 (1000_9A85 / 0x19A85)
    AL = 0x5;
    // MOV BX,0xf38 (1000_9A87 / 0x19A87)
    BX = 0xF38;
    // CMP word ptr [0x47c4],0x7 (1000_9A8A / 0x19A8A)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x7);
    // JNZ 0x1000:9a9a (1000_9A8F / 0x19A8F)
    if(!ZeroFlag) {
      goto label_1000_9A9A_19A9A;
    }
    // CMP byte ptr [0x2a],0xc8 (1000_9A91 / 0x19A91)
    Alu.Sub8(UInt8[DS, 0x2A], 0xC8);
    // JC 0x1000:9a9a (1000_9A96 / 0x19A96)
    if(CarryFlag) {
      goto label_1000_9A9A_19A9A;
    }
    // INC AL (1000_9A98 / 0x19A98)
    AL++;
    label_1000_9A9A_19A9A:
    // DEC AL (1000_9A9A / 0x19A9A)
    AL--;
    // XOR AH,AH (1000_9A9C / 0x19A9C)
    AH = 0;
    // SHL AX,1 (1000_9A9E / 0x19A9E)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_9AA0 / 0x19AA0)
    BP = AX;
    // ADD BP,word ptr [0xf0] (1000_9AA2 / 0x19AA2)
    // BP += UInt16[DS, 0xF0];
    BP = Alu.Add16(BP, UInt16[DS, 0xF0]);
    // MOV SI,word ptr [0x47ca] (1000_9AA6 / 0x19AA6)
    SI = UInt16[DS, 0x47CA];
    // MOV ES,word ptr [0xdbb2] (1000_9AAA / 0x19AAA)
    ES = UInt16[DS, 0xDBB2];
    // ADD SI,word ptr ES:[BP + SI] (1000_9AAE / 0x19AAE)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    // JMP 0x1000:e3b7 (1000_9AB1 / 0x19AB1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E3B7_01E3B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9AB4_019AB4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9AB4_19AB4:
    // MOV AL,[0x47e1] (1000_9AB4 / 0x19AB4)
    AL = UInt8[DS, 0x47E1];
    // OR AL,AL (1000_9AB7 / 0x19AB7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:9b08 (1000_9AB9 / 0x19AB9)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9B08 / 0x19B08)
      return NearRet();
    }
    // JS 0x1000:9adb (1000_9ABB / 0x19ABB)
    if(SignFlag) {
      goto label_1000_9ADB_19ADB;
    }
    // OR byte ptr [0x47e1],0x80 (1000_9ABD / 0x19ABD)
    // UInt8[DS, 0x47E1] |= 0x80;
    UInt8[DS, 0x47E1] = Alu.Or8(UInt8[DS, 0x47E1], 0x80);
    // CALL 0x1000:9b09 (1000_9AC2 / 0x19AC2)
    NearCall(cs1, 0x9AC5, spice86_generated_label_call_target_1000_9B09_019B09);
    label_1000_9AC5_19AC5:
    // MOV AL,[0x47e2] (1000_9AC5 / 0x19AC5)
    AL = UInt8[DS, 0x47E2];
    // XOR AH,AH (1000_9AC8 / 0x19AC8)
    AH = 0;
    // MOV BP,AX (1000_9ACA / 0x19ACA)
    BP = AX;
    // MOV SI,word ptr [0x47ca] (1000_9ACC / 0x19ACC)
    SI = UInt16[DS, 0x47CA];
    // ADD SI,word ptr ES:[BP + SI] (1000_9AD0 / 0x19AD0)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    // MOV word ptr [0x47ce],0x14 (1000_9AD3 / 0x19AD3)
    UInt16[DS, 0x47CE] = 0x14;
    // STC  (1000_9AD9 / 0x19AD9)
    CarryFlag = true;
    // RET  (1000_9ADA / 0x19ADA)
    return NearRet();
    label_1000_9ADB_19ADB:
    // SHR AL,1 (1000_9ADB / 0x19ADB)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNC 0x1000:9b08 (1000_9ADD / 0x19ADD)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9B08 / 0x19B08)
      return NearRet();
    }
    // MOV byte ptr [0x47e1],0x80 (1000_9ADF / 0x19ADF)
    UInt8[DS, 0x47E1] = 0x80;
    // CALL 0x1000:d075 (1000_9AE4 / 0x19AE4)
    NearCall(cs1, 0x9AE7, spice86_generated_label_call_target_1000_D075_01D075);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9AE7_019AE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9AE7_019AE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9AE7_19AE7:
    // MOV SI,word ptr [0x47e4] (1000_9AE7 / 0x19AE7)
    SI = UInt16[DS, 0x47E4];
    // CMP word ptr [SI],0x38 (1000_9AEB / 0x19AEB)
    Alu.Sub16(UInt16[DS, SI], 0x38);
    // JNC 0x1000:9b08 (1000_9AEE / 0x19AEE)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9B08 / 0x19B08)
      return NearRet();
    }
    // LODSW SI (1000_9AF0 / 0x19AF0)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_9AF1 / 0x19AF1)
    CX = AX;
    // LODSW SI (1000_9AF3 / 0x19AF3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_9AF4 / 0x19AF4)
    DX = AX;
    // LODSW SI (1000_9AF6 / 0x19AF6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_9AF7 / 0x19AF7)
    BX = AX;
    // LODSW SI (1000_9AF9 / 0x19AF9)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,CX (1000_9AFA / 0x19AFA)
    ushort tmp_1000_9AFA = AX;
    AX = CX;
    CX = tmp_1000_9AFA;
    // CALL 0x1000:8865 (1000_9AFB / 0x19AFB)
    NearCall(cs1, 0x9AFE, spice86_generated_label_call_target_1000_8865_018865);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9AFE_019AFE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9AFE_019AFE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9B08: goto label_1000_9B08_19B08;break; // Target of external jump from 0x19AB9, 0x19ADD
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9AFE_19AFE:
    // CALL 0x1000:d068 (1000_9AFE / 0x19AFE)
    NearCall(cs1, 0x9B01, spice86_generated_label_call_target_1000_D068_01D068);
    label_1000_9B01_19B01:
    // CALL 0x1000:dbb2 (1000_9B01 / 0x19B01)
    NearCall(cs1, 0x9B04, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_9B04_19B04:
    // CALL 0x1000:c4dd (1000_9B04 / 0x19B04)
    NearCall(cs1, 0x9B07, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_9B07_19B07:
    // CLC  (1000_9B07 / 0x19B07)
    CarryFlag = false;
    label_1000_9B08_19B08:
    // RET  (1000_9B08 / 0x19B08)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9B09_019B09(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9B09_19B09:
    // MOV SI,word ptr [0x47e4] (1000_9B09 / 0x19B09)
    SI = UInt16[DS, 0x47E4];
    // CMP word ptr [SI],0x38 (1000_9B0D / 0x19B0D)
    Alu.Sub16(UInt16[DS, SI], 0x38);
    // JC 0x1000:9b48 (1000_9B10 / 0x19B10)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_9B48 / 0x19B48)
      return NearRet();
    }
    // MOV AX,[0x20] (1000_9B12 / 0x19B12)
    AX = UInt16[DS, 0x20];
    // JZ 0x1000:9b1c (1000_9B15 / 0x19B15)
    if(ZeroFlag) {
      goto label_1000_9B1C_19B1C;
    }
    // MOV AL,[0x9d] (1000_9B17 / 0x19B17)
    AL = UInt8[DS, 0x9D];
    // XOR AH,AH (1000_9B1A / 0x19B1A)
    AH = 0;
    label_1000_9B1C_19B1C:
    // CALL 0x1000:8a23 (1000_9B1C / 0x19B1C)
    NearCall(cs1, 0x9B1F, spice86_generated_label_call_target_1000_8A23_018A23);
    // MOV CX,AX (1000_9B1F / 0x19B1F)
    CX = AX;
    // LES SI,[0xdbb0] (1000_9B21 / 0x19B21)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV DI,SI (1000_9B25 / 0x19B25)
    DI = SI;
    // MOV BP,0x5 (1000_9B27 / 0x19B27)
    BP = 0x5;
    label_1000_9B2A_19B2A:
    // AND BX,0xf (1000_9B2A / 0x19B2A)
    // BX &= 0xF;
    BX = Alu.And16(BX, 0xF);
    // JZ 0x1000:9b32 (1000_9B2D / 0x19B2D)
    if(ZeroFlag) {
      goto label_1000_9B32_19B32;
    }
    // MOV BP,0x6 (1000_9B2F / 0x19B2F)
    BP = 0x6;
    label_1000_9B32_19B32:
    // ADD BX,BP (1000_9B32 / 0x19B32)
    BX += BP;
    // SHL BX,1 (1000_9B34 / 0x19B34)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV AX,word ptr ES:[BX + SI] (1000_9B36 / 0x19B36)
    AX = UInt16[ES, (ushort)(BX + SI)];
    // STOSW ES:DI (1000_9B39 / 0x19B39)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV BL,DH (1000_9B3A / 0x19B3A)
    BL = DH;
    // MOV DH,DL (1000_9B3C / 0x19B3C)
    DH = DL;
    // MOV DL,CH (1000_9B3E / 0x19B3E)
    DL = CH;
    // MOV CH,CL (1000_9B40 / 0x19B40)
    CH = CL;
    // MOV CL,0xff (1000_9B42 / 0x19B42)
    CL = 0xFF;
    // CMP BL,CL (1000_9B44 / 0x19B44)
    Alu.Sub8(BL, CL);
    // JNZ 0x1000:9b2a (1000_9B46 / 0x19B46)
    if(!ZeroFlag) {
      goto label_1000_9B2A_19B2A;
    }
    label_1000_9B48_19B48:
    // RET  (1000_9B48 / 0x19B48)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9B49_019B49(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9B49_19B49:
    // MOV AX,[0x47e1] (1000_9B49 / 0x19B49)
    AX = UInt16[DS, 0x47E1];
    // CMP AL,0x80 (1000_9B4C / 0x19B4C)
    Alu.Sub8(AL, 0x80);
    // JNZ 0x1000:9b84 (1000_9B4E / 0x19B4E)
    if(!ZeroFlag) {
      goto label_1000_9B84_19B84;
    }
    // PUSH SI (1000_9B50 / 0x19B50)
    Stack.Push(SI);
    // PUSH AX (1000_9B51 / 0x19B51)
    Stack.Push(AX);
    // CALL 0x1000:9197 (1000_9B52 / 0x19B52)
    NearCall(cs1, 0x9B55, spice86_generated_label_call_target_1000_9197_019197);
    // POP AX (1000_9B55 / 0x19B55)
    AX = Stack.Pop();
    // MOV AL,AH (1000_9B56 / 0x19B56)
    AL = AH;
    // XOR AH,AH (1000_9B58 / 0x19B58)
    AH = 0;
    // INC AX (1000_9B5A / 0x19B5A)
    AX++;
    // INC AX (1000_9B5B / 0x19B5B)
    AX = Alu.Inc16(AX);
    // MOV BP,AX (1000_9B5C / 0x19B5C)
    BP = AX;
    // MOV SI,word ptr [0x47ca] (1000_9B5E / 0x19B5E)
    SI = UInt16[DS, 0x47CA];
    // MOV ES,word ptr [0xdbb2] (1000_9B62 / 0x19B62)
    ES = UInt16[DS, 0xDBB2];
    // ADD SI,word ptr ES:[BP + SI] (1000_9B66 / 0x19B66)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    // MOV byte ptr [0x47e1],0x81 (1000_9B69 / 0x19B69)
    UInt8[DS, 0x47E1] = 0x81;
    label_1000_9B6E_19B6E:
    // PUSH ES (1000_9B6E / 0x19B6E)
    Stack.Push(ES);
    // MOV BP,0x99f6 (1000_9B6F / 0x19B6F)
    BP = 0x99F6;
    // MOV AX,0xc (1000_9B72 / 0x19B72)
    AX = 0xC;
    // CALL 0x1000:e353 (1000_9B75 / 0x19B75)
    NearCall(cs1, 0x9B78, spice86_generated_label_call_target_1000_E353_01E353);
    // POP ES (1000_9B78 / 0x19B78)
    ES = Stack.Pop();
    // MOV SI,word ptr [0x47c6] (1000_9B79 / 0x19B79)
    SI = UInt16[DS, 0x47C6];
    // CMP byte ptr ES:[SI],0xff (1000_9B7D / 0x19B7D)
    Alu.Sub8(UInt8[ES, SI], 0xFF);
    // JNZ 0x1000:9b6e (1000_9B81 / 0x19B81)
    if(!ZeroFlag) {
      goto label_1000_9B6E_19B6E;
    }
    // POP SI (1000_9B83 / 0x19B83)
    SI = Stack.Pop();
    label_1000_9B84_19B84:
    // MOV word ptr [0x47e1],0x0 (1000_9B84 / 0x19B84)
    UInt16[DS, 0x47E1] = 0x0;
    // RET  (1000_9B8A / 0x19B8A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9B8B_019B8B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9B8B_19B8B:
    // CALL 0x1000:a7a5 (1000_9B8B / 0x19B8B)
    NearCall(cs1, 0x9B8E, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9B8E_019B8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9B8E_019B8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9B8E_19B8E:
    // XOR AX,AX (1000_9B8E / 0x19B8E)
    AX = 0;
    // MOV byte ptr [0x47c3],0x0 (1000_9B90 / 0x19B90)
    UInt8[DS, 0x47C3] = 0x0;
    // MOV [0x47ce],AX (1000_9B95 / 0x19B95)
    UInt16[DS, 0x47CE] = AX;
    // AND byte ptr [0x47d1],0x7f (1000_9B98 / 0x19B98)
    // UInt8[DS, 0x47D1] &= 0x7F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x7F);
    // XCHG word ptr [0x47c6],AX (1000_9B9D / 0x19B9D)
    ushort tmp_1000_9B9D = UInt16[DS, 0x47C6];
    UInt16[DS, 0x47C6] = AX;
    AX = tmp_1000_9B9D;
    // OR AX,AX (1000_9BA1 / 0x19BA1)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:9bab (1000_9BA3 / 0x19BA3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9BAB / 0x19BAB)
      return NearRet();
    }
    // MOV SI,0x99be (1000_9BA5 / 0x19BA5)
    SI = 0x99BE;
    // JMP 0x1000:da5f (1000_9BA8 / 0x19BA8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9BAB_19BAB:
    // RET  (1000_9BAB / 0x19BAB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9BAC_019BAC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BAC_19BAC:
    // PUSH SI (1000_9BAC / 0x19BAC)
    Stack.Push(SI);
    // CALL 0x1000:9197 (1000_9BAD / 0x19BAD)
    NearCall(cs1, 0x9BB0, spice86_generated_label_call_target_1000_9197_019197);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BB0_019BB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9BB0_019BB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BB0_19BB0:
    // POP SI (1000_9BB0 / 0x19BB0)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9BB1_019BB1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9BB1_019BB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BB1_19BB1:
    // CALL 0x1000:9bee (1000_9BB1 / 0x19BB1)
    NearCall(cs1, 0x9BB4, spice86_generated_label_call_target_1000_9BEE_019BEE);
    label_1000_9BB4_19BB4:
    // PUSH SI (1000_9BB4 / 0x19BB4)
    Stack.Push(SI);
    // CMP word ptr [0x4540],0x0 (1000_9BB5 / 0x19BB5)
    Alu.Sub16(UInt16[DS, 0x4540], 0x0);
    // JNZ 0x1000:9bcc (1000_9BBA / 0x19BBA)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9BCC_019BCC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1bf0 (1000_9BBC / 0x19BBC)
    SI = 0x1BF0;
    // MOV DI,0xd834 (1000_9BBF / 0x19BBF)
    DI = 0xD834;
    // CALL 0x1000:5b99 (1000_9BC2 / 0x19BC2)
    NearCall(cs1, 0x9BC5, spice86_generated_label_call_target_1000_5B99_015B99);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BC5_019BC5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9BC5_019BC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BC5_19BC5:
    // MOV word ptr [SI],0x80 (1000_9BC5 / 0x19BC5)
    UInt16[DS, SI] = 0x80;
    // JMP 0x1000:9bd7 (1000_9BC9 / 0x19BC9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9BD7_019BD7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9BCC_019BCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BCC_19BCC:
    // CALL 0x1000:9c2d (1000_9BCC / 0x19BCC)
    NearCall(cs1, 0x9BCF, spice86_generated_label_call_target_1000_9C2D_019C2D);
    label_1000_9BCF_19BCF:
    // CMP word ptr [0xd834],0x13f (1000_9BCF / 0x19BCF)
    Alu.Sub16(UInt16[DS, 0xD834], 0x13F);
    // JZ 0x1000:9bec (1000_9BD5 / 0x19BD5)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BEC_019BEC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9BD7_019BD7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9BD7_019BD7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BD7_19BD7:
    // MOV SI,0xd834 (1000_9BD7 / 0x19BD7)
    SI = 0xD834;
    // CMP word ptr [SI + 0x6],0x98 (1000_9BDA / 0x19BDA)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x6)], 0x98);
    // JC 0x1000:9be6 (1000_9BDF / 0x19BDF)
    if(CarryFlag) {
      goto label_1000_9BE6_19BE6;
    }
    // MOV word ptr [SI + 0x6],0x98 (1000_9BE1 / 0x19BE1)
    UInt16[DS, (ushort)(SI + 0x6)] = 0x98;
    label_1000_9BE6_19BE6:
    // CALL 0x1000:c446 (1000_9BE6 / 0x19BE6)
    NearCall(cs1, 0x9BE9, spice86_generated_label_call_target_1000_C446_01C446);
    label_1000_9BE9_19BE9:
    // CALL 0x1000:9d16 (1000_9BE9 / 0x19BE9)
    NearCall(cs1, 0x9BEC, spice86_generated_label_call_target_1000_9D16_019D16);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BEC_019BEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9BEC_019BEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BEC_19BEC:
    // POP SI (1000_9BEC / 0x19BEC)
    SI = Stack.Pop();
    // RET  (1000_9BED / 0x19BED)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9BEE_019BEE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9BEE_19BEE:
    // XOR CX,CX (1000_9BEE / 0x19BEE)
    CX = 0;
    // PUSH DS (1000_9BF0 / 0x19BF0)
    Stack.Push(DS);
    // POP ES (1000_9BF1 / 0x19BF1)
    ES = Stack.Pop();
    // MOV DS,word ptr SS:[0xdbb2] (1000_9BF2 / 0x19BF2)
    DS = UInt16[SS, 0xDBB2];
    // MOV DI,0x460a (1000_9BF7 / 0x19BF7)
    DI = 0x460A;
    label_1000_9BFA_19BFA:
    // LODSB SI (1000_9BFA / 0x19BFA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_9BFB / 0x19BFB)
    AH = 0;
    // OR AL,AL (1000_9BFD / 0x19BFD)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:9c25 (1000_9BFF / 0x19BFF)
    if(ZeroFlag) {
      goto label_1000_9C25_19C25;
    }
    // CMP AL,0x1 (1000_9C01 / 0x19C01)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:9c08 (1000_9C03 / 0x19C03)
    if(!ZeroFlag) {
      goto label_1000_9C08_19C08;
    }
    // MOV AH,AL (1000_9C05 / 0x19C05)
    AH = AL;
    // LODSB SI (1000_9C07 / 0x19C07)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_9C08_19C08:
    // PUSH SI (1000_9C08 / 0x19C08)
    Stack.Push(SI);
    // SUB AX,0x2 (1000_9C09 / 0x19C09)
    AX -= 0x2;
    // SHL AX,1 (1000_9C0C / 0x19C0C)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_9C0E / 0x19C0E)
    BP = AX;
    // MOV SI,word ptr SS:[0x47cc] (1000_9C10 / 0x19C10)
    SI = UInt16[SS, 0x47CC];
    // ADD SI,word ptr DS:[BP + SI] (1000_9C15 / 0x19C15)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    label_1000_9C18_19C18:
    // LODSB SI (1000_9C18 / 0x19C18)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_9C19 / 0x19C19)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:9c22 (1000_9C1B / 0x19C1B)
    if(ZeroFlag) {
      goto label_1000_9C22_19C22;
    }
    // STOSB ES:DI (1000_9C1D / 0x19C1D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOVSW ES:DI,SI (1000_9C1E / 0x19C1E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // INC CX (1000_9C1F / 0x19C1F)
    CX = Alu.Inc16(CX);
    // JMP 0x1000:9c18 (1000_9C20 / 0x19C20)
    goto label_1000_9C18_19C18;
    label_1000_9C22_19C22:
    // POP SI (1000_9C22 / 0x19C22)
    SI = Stack.Pop();
    // JMP 0x1000:9bfa (1000_9C23 / 0x19C23)
    goto label_1000_9BFA_19BFA;
    label_1000_9C25_19C25:
    // MOV word ptr SS:[0x4608],CX (1000_9C25 / 0x19C25)
    UInt16[SS, 0x4608] = CX;
    // PUSH SS (1000_9C2A / 0x19C2A)
    Stack.Push(SS);
    // POP DS (1000_9C2B / 0x19C2B)
    DS = Stack.Pop();
    // RET  (1000_9C2C / 0x19C2C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9C2D_019C2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9C2D_19C2D:
    // MOV word ptr [0xd834],0x13f (1000_9C2D / 0x19C2D)
    UInt16[DS, 0xD834] = 0x13F;
    // MOV word ptr [0xd836],0xc7 (1000_9C33 / 0x19C33)
    UInt16[DS, 0xD836] = 0xC7;
    // XOR AX,AX (1000_9C39 / 0x19C39)
    AX = 0;
    // MOV [0xd838],AX (1000_9C3B / 0x19C3B)
    UInt16[DS, 0xD838] = AX;
    // MOV [0xd83a],AX (1000_9C3E / 0x19C3E)
    UInt16[DS, 0xD83A] = AX;
    // MOV AX,DS (1000_9C41 / 0x19C41)
    AX = DS;
    // MOV ES,AX (1000_9C43 / 0x19C43)
    ES = AX;
    // MOV SI,0x4540 (1000_9C45 / 0x19C45)
    SI = 0x4540;
    // MOV DI,0x4608 (1000_9C48 / 0x19C48)
    DI = 0x4608;
    // CALL 0x1000:9c54 (1000_9C4B / 0x19C4B)
    NearCall(cs1, 0x9C4E, spice86_generated_label_call_target_1000_9C54_019C54);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9C4E_019C4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9C4E_019C4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9C4E_19C4E:
    // MOV SI,0x4608 (1000_9C4E / 0x19C4E)
    SI = 0x4608;
    // MOV DI,0x4540 (1000_9C51 / 0x19C51)
    DI = 0x4540;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9C54_019C54, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9C54_019C54(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9C54_19C54:
    // LODSW SI (1000_9C54 / 0x19C54)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_9C55 / 0x19C55)
    CX = AX;
    label_1000_9C57_19C57:
    // PUSH CX (1000_9C57 / 0x19C57)
    Stack.Push(CX);
    // PUSH DI (1000_9C58 / 0x19C58)
    Stack.Push(DI);
    // MOV CX,word ptr [DI] (1000_9C59 / 0x19C59)
    CX = UInt16[DS, DI];
    // ADD DI,0x2 (1000_9C5B / 0x19C5B)
    DI += 0x2;
    label_1000_9C5E_19C5E:
    // CMPSW ES:DI,SI (1000_9C5E / 0x19C5E)
    Alu.Sub16(UInt16[DS, SI], UInt16[ES, DI]);
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // LAHF  (1000_9C5F / 0x19C5F)
    AH = (byte)FlagRegister;
    // CMPSB ES:DI,SI (1000_9C60 / 0x19C60)
    Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // MOV AL,AH (1000_9C61 / 0x19C61)
    AL = AH;
    // LAHF  (1000_9C63 / 0x19C63)
    AH = (byte)FlagRegister;
    // AND AL,AH (1000_9C64 / 0x19C64)
    AL &= AH;
    // TEST AL,0x40 (1000_9C66 / 0x19C66)
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:9c75 (1000_9C68 / 0x19C68)
    if(!ZeroFlag) {
      goto label_1000_9C75_19C75;
    }
    // SUB SI,0x3 (1000_9C6A / 0x19C6A)
    // SI -= 0x3;
    SI = Alu.Sub16(SI, 0x3);
    // LOOP 0x1000:9c5e (1000_9C6D / 0x19C6D)
    if(--CX != 0) {
      goto label_1000_9C5E_19C5E;
    }
    // CALL 0x1000:9cc6 (1000_9C6F / 0x19C6F)
    NearCall(cs1, 0x9C72, spice86_generated_label_call_target_1000_9CC6_019CC6);
    label_1000_9C72_19C72:
    // ADD SI,0x3 (1000_9C72 / 0x19C72)
    // SI += 0x3;
    SI = Alu.Add16(SI, 0x3);
    label_1000_9C75_19C75:
    // POP DI (1000_9C75 / 0x19C75)
    DI = Stack.Pop();
    // POP CX (1000_9C76 / 0x19C76)
    CX = Stack.Pop();
    // LOOP 0x1000:9c57 (1000_9C77 / 0x19C77)
    if(--CX != 0) {
      goto label_1000_9C57_19C57;
    }
    // CMP byte ptr [0x47e1],0x81 (1000_9C79 / 0x19C79)
    Alu.Sub8(UInt8[DS, 0x47E1], 0x81);
    // JZ 0x1000:9ca6 (1000_9C7E / 0x19C7E)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9C83_019C83, 0x19CA6 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:abcc (1000_9C80 / 0x19C80)
    NearCall(cs1, 0x9C83, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9C83_019C83, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9C83_019C83(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9CA6: goto label_1000_9CA6_19CA6;break; // Target of external jump from 0x19C83, 0x19C7E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9C83_19C83:
    // JZ 0x1000:9ca6 (1000_9C83 / 0x19C83)
    if(ZeroFlag) {
      goto label_1000_9CA6_19CA6;
    }
    // MOV AX,[0x47c4] (1000_9C85 / 0x19C85)
    AX = UInt16[DS, 0x47C4];
    // CMP AL,0x9 (1000_9C88 / 0x19C88)
    Alu.Sub8(AL, 0x9);
    // JZ 0x1000:9cc5 (1000_9C8A / 0x19C8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    // CMP AL,0xc (1000_9C8C / 0x19C8C)
    Alu.Sub8(AL, 0xC);
    // JZ 0x1000:9cc5 (1000_9C8E / 0x19C8E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    // MOV SI,word ptr [0xdc28] (1000_9C90 / 0x19C90)
    SI = UInt16[DS, 0xDC28];
    // MOV AX,word ptr [SI + 0x2] (1000_9C94 / 0x19C94)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // CMP AX,word ptr [0xd83a] (1000_9C97 / 0x19C97)
    Alu.Sub16(AX, UInt16[DS, 0xD83A]);
    // JNC 0x1000:9ca6 (1000_9C9B / 0x19C9B)
    if(!CarryFlag) {
      goto label_1000_9CA6_19CA6;
    }
    // MOV [0xd83a],AX (1000_9C9D / 0x19C9D)
    UInt16[DS, 0xD83A] = AX;
    // CMP AX,word ptr [0xd836] (1000_9CA0 / 0x19CA0)
    Alu.Sub16(AX, UInt16[DS, 0xD836]);
    // JLE 0x1000:9cbf (1000_9CA4 / 0x19CA4)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9CBF_19CBF;
    }
    label_1000_9CA6_19CA6:
    // CMP byte ptr [0x47e1],0x80 (1000_9CA6 / 0x19CA6)
    Alu.Sub8(UInt8[DS, 0x47E1], 0x80);
    // JNZ 0x1000:9cc5 (1000_9CAB / 0x19CAB)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    // MOV AX,0x4c (1000_9CAD / 0x19CAD)
    AX = 0x4C;
    // CMP AX,word ptr [0xd83a] (1000_9CB0 / 0x19CB0)
    Alu.Sub16(AX, UInt16[DS, 0xD83A]);
    // JNC 0x1000:9cc5 (1000_9CB4 / 0x19CB4)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    // MOV [0xd83a],AX (1000_9CB6 / 0x19CB6)
    UInt16[DS, 0xD83A] = AX;
    // CMP AX,word ptr [0xd836] (1000_9CB9 / 0x19CB9)
    Alu.Sub16(AX, UInt16[DS, 0xD836]);
    // JG 0x1000:9cc5 (1000_9CBD / 0x19CBD)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    label_1000_9CBF_19CBF:
    // MOV word ptr [0xd834],0x13f (1000_9CBF / 0x19CBF)
    UInt16[DS, 0xD834] = 0x13F;
    label_1000_9CC5_19CC5:
    // RET  (1000_9CC5 / 0x19CC5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9CC6_019CC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9CC6_19CC6:
    // PUSH SI (1000_9CC6 / 0x19CC6)
    Stack.Push(SI);
    // PUSH DS (1000_9CC7 / 0x19CC7)
    Stack.Push(DS);
    // XOR AH,AH (1000_9CC8 / 0x19CC8)
    AH = 0;
    // LODSB SI (1000_9CCA / 0x19CCA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BP,AX (1000_9CCB / 0x19CCB)
    BP = AX;
    // DEC BP (1000_9CCD / 0x19CCD)
    BP = Alu.Dec16(BP);
    // LODSB SI (1000_9CCE / 0x19CCE)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV DX,AX (1000_9CCF / 0x19CCF)
    DX = AX;
    // ADD DX,word ptr [0x1bf0] (1000_9CD1 / 0x19CD1)
    // DX += UInt16[DS, 0x1BF0];
    DX = Alu.Add16(DX, UInt16[DS, 0x1BF0]);
    // LODSB SI (1000_9CD5 / 0x19CD5)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_9CD6 / 0x19CD6)
    BX = AX;
    // ADD BX,word ptr [0x1bf2] (1000_9CD8 / 0x19CD8)
    // BX += UInt16[DS, 0x1BF2];
    BX = Alu.Add16(BX, UInt16[DS, 0x1BF2]);
    // LDS SI,[0xdbb0] (1000_9CDC / 0x19CDC)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // SHL BP,1 (1000_9CE0 / 0x19CE0)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_9CE2 / 0x19CE2)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // MOV BP,0xd834 (1000_9CE5 / 0x19CE5)
    BP = 0xD834;
    // CMP word ptr [BP + 0x0],DX (1000_9CE8 / 0x19CE8)
    Alu.Sub16(UInt16[SS, BP], DX);
    // JC 0x1000:9cf0 (1000_9CEB / 0x19CEB)
    if(CarryFlag) {
      goto label_1000_9CF0_19CF0;
    }
    // MOV word ptr [BP + 0x0],DX (1000_9CED / 0x19CED)
    UInt16[SS, BP] = DX;
    label_1000_9CF0_19CF0:
    // CMP word ptr [BP + 0x2],BX (1000_9CF0 / 0x19CF0)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], BX);
    // JC 0x1000:9cf8 (1000_9CF3 / 0x19CF3)
    if(CarryFlag) {
      goto label_1000_9CF8_19CF8;
    }
    // MOV word ptr [BP + 0x2],BX (1000_9CF5 / 0x19CF5)
    UInt16[SS, (ushort)(BP + 0x2)] = BX;
    label_1000_9CF8_19CF8:
    // LODSW SI (1000_9CF8 / 0x19CF8)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // AND AX,0x1ff (1000_9CF9 / 0x19CF9)
    AX &= 0x1FF;
    // ADD DX,AX (1000_9CFC / 0x19CFC)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // LODSW SI (1000_9CFE / 0x19CFE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_9CFF / 0x19CFF)
    AH = 0;
    // ADD BX,AX (1000_9D01 / 0x19D01)
    BX += AX;
    // CMP word ptr [BP + 0x4],DX (1000_9D03 / 0x19D03)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x4)], DX);
    // JNC 0x1000:9d0b (1000_9D06 / 0x19D06)
    if(!CarryFlag) {
      goto label_1000_9D0B_19D0B;
    }
    // MOV word ptr [BP + 0x4],DX (1000_9D08 / 0x19D08)
    UInt16[SS, (ushort)(BP + 0x4)] = DX;
    label_1000_9D0B_19D0B:
    // CMP word ptr [BP + 0x6],BX (1000_9D0B / 0x19D0B)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], BX);
    // JNC 0x1000:9d13 (1000_9D0E / 0x19D0E)
    if(!CarryFlag) {
      goto label_1000_9D13_19D13;
    }
    // MOV word ptr [BP + 0x6],BX (1000_9D10 / 0x19D10)
    UInt16[SS, (ushort)(BP + 0x6)] = BX;
    label_1000_9D13_19D13:
    // POP DS (1000_9D13 / 0x19D13)
    DS = Stack.Pop();
    // POP SI (1000_9D14 / 0x19D14)
    SI = Stack.Pop();
    // RET  (1000_9D15 / 0x19D15)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9D16_019D16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9D16_19D16:
    // PUSH DS (1000_9D16 / 0x19D16)
    Stack.Push(DS);
    // POP ES (1000_9D17 / 0x19D17)
    ES = Stack.Pop();
    // MOV DI,0x4540 (1000_9D18 / 0x19D18)
    DI = 0x4540;
    // MOV SI,0x4608 (1000_9D1B / 0x19D1B)
    SI = 0x4608;
    // MOV CX,word ptr [SI] (1000_9D1E / 0x19D1E)
    CX = UInt16[DS, SI];
    // PUSH SI (1000_9D20 / 0x19D20)
    Stack.Push(SI);
    // MOV AX,CX (1000_9D21 / 0x19D21)
    AX = CX;
    // SHL CX,1 (1000_9D23 / 0x19D23)
    CX <<= 0x1;
    // ADD CX,AX (1000_9D25 / 0x19D25)
    CX += AX;
    // ADD CX,0x2 (1000_9D27 / 0x19D27)
    // CX += 0x2;
    CX = Alu.Add16(CX, 0x2);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_9D2A / 0x19D2A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP SI (1000_9D2C / 0x19D2C)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_9D2D_019D2D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9D2D_019D2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9D2D_19D2D:
    // LODSW SI (1000_9D2D / 0x19D2D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_9D2E / 0x19D2E)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9D30_019D30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9D30_019D30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9D30_19D30:
    // PUSH CX (1000_9D30 / 0x19D30)
    Stack.Push(CX);
    // LODSB SI (1000_9D31 / 0x19D31)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_9D32 / 0x19D32)
    AH = 0;
    // MOV BP,AX (1000_9D34 / 0x19D34)
    BP = AX;
    // LODSB SI (1000_9D36 / 0x19D36)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV DX,AX (1000_9D37 / 0x19D37)
    DX = AX;
    // LODSB SI (1000_9D39 / 0x19D39)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_9D3A / 0x19D3A)
    BX = AX;
    // ADD DX,word ptr [0x1bf0] (1000_9D3C / 0x19D3C)
    DX += UInt16[DS, 0x1BF0];
    // ADD BX,word ptr [0x1bf2] (1000_9D40 / 0x19D40)
    // BX += UInt16[DS, 0x1BF2];
    BX = Alu.Add16(BX, UInt16[DS, 0x1BF2]);
    // PUSH SI (1000_9D44 / 0x19D44)
    Stack.Push(SI);
    // DEC BP (1000_9D45 / 0x19D45)
    BP = Alu.Dec16(BP);
    // MOV ES,word ptr [0xdbda] (1000_9D46 / 0x19D46)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_9D4A / 0x19D4A)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // SHL BP,1 (1000_9D4E / 0x19D4E)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_9D50 / 0x19D50)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_9D53 / 0x19D53)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_9D54 / 0x19D54)
    DI = AX;
    // LODSW SI (1000_9D56 / 0x19D56)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_9D57 / 0x19D57)
    AH = 0;
    // MOV CX,AX (1000_9D59 / 0x19D59)
    CX = AX;
    // MOV BP,0xd834 (1000_9D5B / 0x19D5B)
    BP = 0xD834;
    // CALLF [0x38cd] (1000_9D5E / 0x19D5E)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_9D5E = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_9D5E) {
      case 0x235C2 : FarCall(cs1, 0x9D63, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9D5E));
        break;
    }
    label_1000_9D63_19D63:
    // PUSH SS (1000_9D63 / 0x19D63)
    Stack.Push(SS);
    // POP DS (1000_9D64 / 0x19D64)
    DS = Stack.Pop();
    // POP SI (1000_9D65 / 0x19D65)
    SI = Stack.Pop();
    // POP CX (1000_9D66 / 0x19D66)
    CX = Stack.Pop();
    // LOOP 0x1000:9d30 (1000_9D67 / 0x19D67)
    if(--CX != 0) {
      goto label_1000_9D30_19D30;
    }
    // RET  (1000_9D69 / 0x19D69)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9D6A_019D6A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9D93: goto label_1000_9D93_19D93;break; // Target of external jump from 0x19D74, 0x19D98
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9D6A_19D6A:
    // MOV ES,word ptr SS:[0xdbd8] (1000_9D6A / 0x19D6A)
    ES = UInt16[SS, 0xDBD8];
    label_1000_9D6F_19D6F:
    // LODSB SI (1000_9D6F / 0x19D6F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_9D70 / 0x19D70)
    AH = 0;
    // OR AL,AL (1000_9D72 / 0x19D72)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:9d93 (1000_9D74 / 0x19D74)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9D93 / 0x19D93)
      return NearRet();
    }
    // CMP AL,0x1 (1000_9D76 / 0x19D76)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:9d7d (1000_9D78 / 0x19D78)
    if(!ZeroFlag) {
      goto label_1000_9D7D_19D7D;
    }
    // MOV AH,AL (1000_9D7A / 0x19D7A)
    AH = AL;
    // LODSB SI (1000_9D7C / 0x19D7C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_9D7D_19D7D:
    // PUSH SI (1000_9D7D / 0x19D7D)
    Stack.Push(SI);
    // SUB AX,0x2 (1000_9D7E / 0x19D7E)
    AX -= 0x2;
    // SHL AX,1 (1000_9D81 / 0x19D81)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_9D83 / 0x19D83)
    BP = AX;
    // MOV SI,word ptr SS:[0x47cc] (1000_9D85 / 0x19D85)
    SI = UInt16[SS, 0x47CC];
    // ADD SI,word ptr DS:[BP + SI] (1000_9D8A / 0x19D8A)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // CALL 0x1000:9d94 (1000_9D8D / 0x19D8D)
    NearCall(cs1, 0x9D90, spice86_generated_label_call_target_1000_9D94_019D94);
    label_1000_9D90_19D90:
    // POP SI (1000_9D90 / 0x19D90)
    SI = Stack.Pop();
    // JMP 0x1000:9d6f (1000_9D91 / 0x19D91)
    goto label_1000_9D6F_19D6F;
    label_1000_9D93_19D93:
    // RET  (1000_9D93 / 0x19D93)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9D94_019D94(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9D94_19D94:
    // LODSB SI (1000_9D94 / 0x19D94)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // AND AX,0xff (1000_9D95 / 0x19D95)
    // AX &= 0xFF;
    AX = Alu.And16(AX, 0xFF);
    // JZ 0x1000:9d93 (1000_9D98 / 0x19D98)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9D93 / 0x19D93)
      return NearRet();
    }
    // XOR AH,AH (1000_9D9A / 0x19D9A)
    AH = 0;
    // MOV BP,AX (1000_9D9C / 0x19D9C)
    BP = AX;
    // LODSB SI (1000_9D9E / 0x19D9E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV DX,AX (1000_9D9F / 0x19D9F)
    DX = AX;
    // LODSB SI (1000_9DA1 / 0x19DA1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_9DA2 / 0x19DA2)
    BX = AX;
    // ADD DX,word ptr SS:[0x1bf0] (1000_9DA4 / 0x19DA4)
    DX += UInt16[SS, 0x1BF0];
    // ADD BX,word ptr SS:[0x1bf2] (1000_9DA9 / 0x19DA9)
    BX += UInt16[SS, 0x1BF2];
    // SUB DX,word ptr SS:[0x46d2] (1000_9DAE / 0x19DAE)
    DX -= UInt16[SS, 0x46D2];
    // SUB BX,word ptr SS:[0x46d4] (1000_9DB3 / 0x19DB3)
    BX -= UInt16[SS, 0x46D4];
    // ADD DX,word ptr SS:[0x47d4] (1000_9DB8 / 0x19DB8)
    DX += UInt16[SS, 0x47D4];
    // ADD BX,word ptr SS:[0x47d6] (1000_9DBD / 0x19DBD)
    // BX += UInt16[SS, 0x47D6];
    BX = Alu.Add16(BX, UInt16[SS, 0x47D6]);
    // PUSH SI (1000_9DC2 / 0x19DC2)
    Stack.Push(SI);
    // PUSH DS (1000_9DC3 / 0x19DC3)
    Stack.Push(DS);
    // DEC BP (1000_9DC4 / 0x19DC4)
    BP = Alu.Dec16(BP);
    // LDS SI,SS:[0xdbb0] (1000_9DC5 / 0x19DC5)
    DS = UInt16[SS, 0xDBB2];
    SI = UInt16[SS, 0xDBB0];
    // SHL BP,1 (1000_9DCA / 0x19DCA)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_9DCC / 0x19DCC)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_9DCF / 0x19DCF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_9DD0 / 0x19DD0)
    DI = AX;
    // LODSW SI (1000_9DD2 / 0x19DD2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_9DD3 / 0x19DD3)
    AH = 0;
    // MOV CX,AX (1000_9DD5 / 0x19DD5)
    CX = AX;
    // MOV BP,0x47d4 (1000_9DD7 / 0x19DD7)
    BP = 0x47D4;
    // CALLF [0x38cd] (1000_9DDA / 0x19DDA)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_9DDA = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_9DDA) {
      case 0x235C2 : FarCall(cs1, 0x9DDF, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9DDA));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9DDF_019DDF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9DDF_019DDF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9DDF_19DDF:
    // POP DS (1000_9DDF / 0x19DDF)
    DS = Stack.Pop();
    // POP SI (1000_9DE0 / 0x19DE0)
    SI = Stack.Pop();
    // JMP 0x1000:9d94 (1000_9DE1 / 0x19DE1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9D94_019D94, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_9DE3_019DE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9DE3_19DE3:
    // CMP word ptr [0x47c4],0x10 (1000_9DE3 / 0x19DE3)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    // JNC 0x1000:9d93 (1000_9DE8 / 0x19DE8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9D93 / 0x19D93)
      return NearRet();
    }
    // PUSH AX (1000_9DEA / 0x19DEA)
    Stack.Push(AX);
    // PUSH SI (1000_9DEB / 0x19DEB)
    Stack.Push(SI);
    // CALL 0x1000:9197 (1000_9DEC / 0x19DEC)
    NearCall(cs1, 0x9DEF, spice86_generated_label_call_target_1000_9197_019197);
    // POP SI (1000_9DEF / 0x19DEF)
    SI = Stack.Pop();
    // POP AX (1000_9DF0 / 0x19DF0)
    AX = Stack.Pop();
    // CMP byte ptr [0x46eb],0x0 (1000_9DF1 / 0x19DF1)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:9e75 (1000_9DF6 / 0x19DF6)
    if(SignFlag) {
      goto label_1000_9E75_19E75;
    }
    // MOV DI,0xd834 (1000_9DF8 / 0x19DF8)
    DI = 0xD834;
    // CALL 0x1000:5b99 (1000_9DFB / 0x19DFB)
    NearCall(cs1, 0x9DFE, spice86_generated_label_call_target_1000_5B99_015B99);
    // MOV DX,word ptr [0x1bf0] (1000_9DFE / 0x19DFE)
    DX = UInt16[DS, 0x1BF0];
    // MOV BX,word ptr [0x1bf2] (1000_9E02 / 0x19E02)
    BX = UInt16[DS, 0x1BF2];
    // ADD word ptr [DI + -0x8],DX (1000_9E06 / 0x19E06)
    UInt16[DS, (ushort)(DI - 0x8)] += DX;
    // ADD word ptr [DI + -0x6],BX (1000_9E09 / 0x19E09)
    UInt16[DS, (ushort)(DI - 0x6)] += BX;
    // ADD word ptr [DI + -0x4],DX (1000_9E0C / 0x19E0C)
    UInt16[DS, (ushort)(DI - 0x4)] += DX;
    // ADD word ptr [DI + -0x2],BX (1000_9E0F / 0x19E0F)
    // UInt16[DS, (ushort)(DI - 0x2)] += BX;
    UInt16[DS, (ushort)(DI - 0x2)] = Alu.Add16(UInt16[DS, (ushort)(DI - 0x2)], BX);
    // MOV SI,word ptr [0x47d2] (1000_9E12 / 0x19E12)
    SI = UInt16[DS, 0x47D2];
    // MOV AH,byte ptr [0x47d0] (1000_9E16 / 0x19E16)
    AH = UInt8[DS, 0x47D0];
    // DEC AH (1000_9E1A / 0x19E1A)
    AH = Alu.Dec8(AH);
    // JS 0x1000:9e2d (1000_9E1C / 0x19E1C)
    if(SignFlag) {
      goto label_1000_9E2D_19E2D;
    }
    // CMP word ptr [0x22a6],0xd (1000_9E1E / 0x19E1E)
    Alu.Sub16(UInt16[DS, 0x22A6], 0xD);
    // JNZ 0x1000:9e27 (1000_9E23 / 0x19E23)
    if(!ZeroFlag) {
      goto label_1000_9E27_19E27;
    }
    // ADD AL,AH (1000_9E25 / 0x19E25)
    AL += AH;
    label_1000_9E27_19E27:
    // SHL AH,1 (1000_9E27 / 0x19E27)
    AH <<= 0x1;
    // SHL AH,1 (1000_9E29 / 0x19E29)
    AH <<= 0x1;
    // ADD AL,AH (1000_9E2B / 0x19E2B)
    AL += AH;
    label_1000_9E2D_19E2D:
    // XOR AH,AH (1000_9E2D / 0x19E2D)
    AH = 0;
    // SHL AX,1 (1000_9E2F / 0x19E2F)
    AX <<= 0x1;
    // ADD SI,AX (1000_9E31 / 0x19E31)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // CALL 0x1000:9bee (1000_9E33 / 0x19E33)
    NearCall(cs1, 0x9E36, spice86_generated_label_call_target_1000_9BEE_019BEE);
    // MOV SI,0x4608 (1000_9E36 / 0x19E36)
    SI = 0x4608;
    // CMP byte ptr [0xea],0x0 (1000_9E39 / 0x19E39)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    // JG 0x1000:9e74 (1000_9E3E / 0x19E3E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_9E74 / 0x19E74)
      return NearRet();
    }
    // CMP word ptr [SI],0x2 (1000_9E40 / 0x19E40)
    Alu.Sub16(UInt16[DS, SI], 0x2);
    // JC 0x1000:9e57 (1000_9E43 / 0x19E43)
    if(CarryFlag) {
      goto label_1000_9E57_19E57;
    }
    // CALL 0x1000:9d2d (1000_9E45 / 0x19E45)
    NearCall(cs1, 0x9E48, not_observed_1000_9D2D_019D2D);
    // CALL 0x1000:908c (1000_9E48 / 0x19E48)
    NearCall(cs1, 0x9E4B, spice86_generated_label_call_target_1000_908C_01908C);
    // MOV SI,0xd834 (1000_9E4B / 0x19E4B)
    SI = 0xD834;
    // CALL 0x1000:db74 (1000_9E4E / 0x19E4E)
    NearCall(cs1, 0x9E51, spice86_generated_label_call_target_1000_DB74_01DB74);
    // CALL 0x1000:c4f0 (1000_9E51 / 0x19E51)
    NearCall(cs1, 0x9E54, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    // JMP 0x1000:db67 (1000_9E54 / 0x19E54)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9E57_19E57:
    // MOV SI,0xd834 (1000_9E57 / 0x19E57)
    SI = 0xD834;
    // CALL 0x1000:db74 (1000_9E5A / 0x19E5A)
    NearCall(cs1, 0x9E5D, spice86_generated_label_call_target_1000_DB74_01DB74);
    // PUSH word ptr [0xdbda] (1000_9E5D / 0x19E5D)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_9E61 / 0x19E61)
    NearCall(cs1, 0x9E64, spice86_generated_label_call_target_1000_C08E_01C08E);
    // MOV SI,0x4608 (1000_9E64 / 0x19E64)
    SI = 0x4608;
    // CALL 0x1000:9d2d (1000_9E67 / 0x19E67)
    NearCall(cs1, 0x9E6A, not_observed_1000_9D2D_019D2D);
    // CALL 0x1000:908c (1000_9E6A / 0x19E6A)
    NearCall(cs1, 0x9E6D, spice86_generated_label_call_target_1000_908C_01908C);
    // POP word ptr [0xdbda] (1000_9E6D / 0x19E6D)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // JMP 0x1000:db67 (1000_9E71 / 0x19E71)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9E74_19E74:
    // RET  (1000_9E74 / 0x19E74)
    return NearRet();
    label_1000_9E75_19E75:
    // MOV SI,word ptr [0x47d2] (1000_9E75 / 0x19E75)
    SI = UInt16[DS, 0x47D2];
    // CMP word ptr [0x47c4],0xc (1000_9E79 / 0x19E79)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xC);
    // JZ 0x1000:9e8c (1000_9E7E / 0x19E7E)
    if(ZeroFlag) {
      goto label_1000_9E8C_19E8C;
    }
    // MOV AH,byte ptr [0x47d0] (1000_9E80 / 0x19E80)
    AH = UInt8[DS, 0x47D0];
    // DEC AH (1000_9E84 / 0x19E84)
    AH--;
    // SHL AH,1 (1000_9E86 / 0x19E86)
    AH <<= 0x1;
    // SHL AH,1 (1000_9E88 / 0x19E88)
    AH <<= 0x1;
    // ADD AL,AH (1000_9E8A / 0x19E8A)
    AL += AH;
    label_1000_9E8C_19E8C:
    // XOR AH,AH (1000_9E8C / 0x19E8C)
    AH = 0;
    // SHL AX,1 (1000_9E8E / 0x19E8E)
    AX <<= 0x1;
    // ADD SI,AX (1000_9E90 / 0x19E90)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // PUSH SI (1000_9E92 / 0x19E92)
    Stack.Push(SI);
    // MOV SI,0x47d4 (1000_9E93 / 0x19E93)
    SI = 0x47D4;
    // CALL 0x1000:db74 (1000_9E96 / 0x19E96)
    NearCall(cs1, 0x9E99, spice86_generated_label_call_target_1000_DB74_01DB74);
    // POP SI (1000_9E99 / 0x19E99)
    SI = Stack.Pop();
    // PUSH DS (1000_9E9A / 0x19E9A)
    Stack.Push(DS);
    // MOV DS,word ptr SS:[0xdbb2] (1000_9E9B / 0x19E9B)
    DS = UInt16[SS, 0xDBB2];
    // LODSB SI (1000_9EA0 / 0x19EA0)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_9EA1 / 0x19EA1)
    AH = 0;
    // SUB AL,0x2 (1000_9EA3 / 0x19EA3)
    AL -= 0x2;
    // SHL AX,1 (1000_9EA5 / 0x19EA5)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_9EA7 / 0x19EA7)
    BP = AX;
    // MOV SI,word ptr SS:[0x47cc] (1000_9EA9 / 0x19EA9)
    SI = UInt16[SS, 0x47CC];
    // ADD SI,word ptr DS:[BP + SI] (1000_9EAE / 0x19EAE)
    SI += UInt16[DS, (ushort)(BP + SI)];
    // CMP byte ptr [SI + 0x3],0x0 (1000_9EB1 / 0x19EB1)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x0);
    // JZ 0x1000:9ec9 (1000_9EB5 / 0x19EB5)
    if(ZeroFlag) {
      goto label_1000_9EC9_19EC9;
    }
    // MOV ES,word ptr SS:[0xdbd6] (1000_9EB7 / 0x19EB7)
    ES = UInt16[SS, 0xDBD6];
    // CALL 0x1000:9d94 (1000_9EBC / 0x19EBC)
    NearCall(cs1, 0x9EBF, spice86_generated_label_call_target_1000_9D94_019D94);
    // POP DS (1000_9EBF / 0x19EBF)
    DS = Stack.Pop();
    // MOV SI,0x47d4 (1000_9EC0 / 0x19EC0)
    SI = 0x47D4;
    // CALL 0x1000:c4f0 (1000_9EC3 / 0x19EC3)
    NearCall(cs1, 0x9EC6, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    // JMP 0x1000:db67 (1000_9EC6 / 0x19EC6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9EC9_19EC9:
    // MOV ES,word ptr SS:[0xdbd8] (1000_9EC9 / 0x19EC9)
    ES = UInt16[SS, 0xDBD8];
    // CALL 0x1000:9d94 (1000_9ECE / 0x19ECE)
    NearCall(cs1, 0x9ED1, spice86_generated_label_call_target_1000_9D94_019D94);
    // POP DS (1000_9ED1 / 0x19ED1)
    DS = Stack.Pop();
    // JMP 0x1000:db67 (1000_9ED2 / 0x19ED2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9ED5_019ED5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9ED5_19ED5:
    // CMP word ptr [0x47c4],0x10 (1000_9ED5 / 0x19ED5)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    // JNC 0x1000:9eeb (1000_9EDA / 0x19EDA)
    if(!CarryFlag) {
      goto label_1000_9EEB_19EEB;
    }
    // CALL 0x1000:9985 (1000_9EDC / 0x19EDC)
    NearCall(cs1, 0x9EDF, spice86_generated_label_ret_target_1000_9985_019985);
    label_1000_9EDF_19EDF:
    // CMP byte ptr [0x47e1],0x81 (1000_9EDF / 0x19EDF)
    Alu.Sub8(UInt8[DS, 0x47E1], 0x81);
    // JNZ 0x1000:9eeb (1000_9EE4 / 0x19EE4)
    if(!ZeroFlag) {
      goto label_1000_9EEB_19EEB;
    }
    // MOV byte ptr [0x47e1],0x1 (1000_9EE6 / 0x19EE6)
    UInt8[DS, 0x47E1] = 0x1;
    label_1000_9EEB_19EEB:
    // CALL 0x1000:c85b (1000_9EEB / 0x19EEB)
    NearCall(cs1, 0x9EEE, spice86_generated_label_call_target_1000_C85B_01C85B);
    label_1000_9EEE_19EEE:
    // MOV AL,[0x47dd] (1000_9EEE / 0x19EEE)
    AL = UInt8[DS, 0x47DD];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_9EF1_019EF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9EF1_019EF1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9EFC: goto label_1000_9EFC_19EFC;break; // Target of external jump from 0x19F0D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9EF1_19EF1:
    // MOV [0x47dc],AL (1000_9EF1 / 0x19EF1)
    UInt8[DS, 0x47DC] = AL;
    // CALL 0x1000:9efd (1000_9EF4 / 0x19EF4)
    NearCall(cs1, 0x9EF7, spice86_generated_label_call_target_1000_9EFD_019EFD);
    label_1000_9EF7_19EF7:
    // MOV byte ptr [0x47dc],0x0 (1000_9EF7 / 0x19EF7)
    UInt8[DS, 0x47DC] = 0x0;
    label_1000_9EFC_19EFC:
    // RET  (1000_9EFC / 0x19EFC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9EFD_019EFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9EFD_19EFD:
    // MOV AL,[0x47dc] (1000_9EFD / 0x19EFD)
    AL = UInt8[DS, 0x47DC];
    // MOV [0x47dd],AL (1000_9F00 / 0x19F00)
    UInt8[DS, 0x47DD] = AL;
    // MOV AX,[0x4780] (1000_9F03 / 0x19F03)
    AX = UInt16[DS, 0x4780];
    // MOV BX,word ptr [0x47c4] (1000_9F06 / 0x19F06)
    BX = UInt16[DS, 0x47C4];
    // CALL 0x1000:a6cc (1000_9F0A / 0x19F0A)
    NearCall(cs1, 0x9F0D, spice86_generated_label_call_target_1000_A6CC_01A6CC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9F0D_019F0D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9F0D_019F0D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F0D_19F0D:
    // JNC 0x1000:9efc (1000_9F0D / 0x19F0D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9EFC / 0x19EFC)
      return NearRet();
    }
    // CMP word ptr [0x47c4],0x10 (1000_9F0F / 0x19F0F)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    // JNC 0x1000:9f19 (1000_9F14 / 0x19F14)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      // JMP 0x1000:a75c (1000_9F19 / 0x19F19)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0x1A75C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:9f1c (1000_9F16 / 0x19F16)
    NearCall(cs1, 0x9F19, not_observed_1000_9F1C_019F1C);
    label_1000_9F19_19F19:
    // JMP 0x1000:a75c (1000_9F19 / 0x19F19)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0x1A75C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9F1C_019F1C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F1C_19F1C:
    // CALL 0x1000:9197 (1000_9F1C / 0x19F1C)
    NearCall(cs1, 0x9F1F, spice86_generated_label_call_target_1000_9197_019197);
    // OR byte ptr [0x47d1],0x10 (1000_9F1F / 0x19F1F)
    // UInt8[DS, 0x47D1] |= 0x10;
    UInt8[DS, 0x47D1] = Alu.Or8(UInt8[DS, 0x47D1], 0x10);
    // CALL 0x1000:9a7b (1000_9F24 / 0x19F24)
    NearCall(cs1, 0x9F27, spice86_generated_label_call_target_1000_9A7B_019A7B);
    // XOR AH,AH (1000_9F27 / 0x19F27)
    AH = 0;
    // CALL 0x1000:9a60 (1000_9F29 / 0x19F29)
    NearCall(cs1, 0x9F2C, spice86_generated_label_call_target_1000_9A60_019A60);
    // MOV word ptr [0x47c6],SI (1000_9F2C / 0x19F2C)
    UInt16[DS, 0x47C6] = SI;
    // RET  (1000_9F30 / 0x19F30)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F31_019F31(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F31_19F31:
    // MOV SI,word ptr [0x47be] (1000_9F31 / 0x19F31)
    SI = UInt16[DS, 0x47BE];
    // AND SI,0xfff8 (1000_9F35 / 0x19F35)
    SI &= 0xFFF8;
    // ADD SI,AX (1000_9F38 / 0x19F38)
    SI += AX;
    // SHL SI,1 (1000_9F3A / 0x19F3A)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV SI,word ptr [SI + 0xaa76] (1000_9F3C / 0x19F3C)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F40_019F40, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F40_019F40(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F40_19F40:
    // MOV AX,[0x47c4] (1000_9F40 / 0x19F40)
    AX = UInt16[DS, 0x47C4];
    // CMP AX,0x2 (1000_9F43 / 0x19F43)
    Alu.Sub16(AX, 0x2);
    // JNZ 0x1000:9f56 (1000_9F46 / 0x19F46)
    if(!ZeroFlag) {
      goto label_1000_9F56_19F56;
    }
    // CMP byte ptr [0xc2],0x4 (1000_9F48 / 0x19F48)
    Alu.Sub8(UInt8[DS, 0xC2], 0x4);
    // JNZ 0x1000:9f56 (1000_9F4D / 0x19F4D)
    if(!ZeroFlag) {
      goto label_1000_9F56_19F56;
    }
    // PUSH AX (1000_9F4F / 0x19F4F)
    Stack.Push(AX);
    // PUSH SI (1000_9F50 / 0x19F50)
    Stack.Push(SI);
    // CALL 0x1000:1243 (1000_9F51 / 0x19F51)
    NearCall(cs1, 0x9F54, not_observed_1000_1243_011243);
    // POP SI (1000_9F54 / 0x19F54)
    SI = Stack.Pop();
    // POP AX (1000_9F55 / 0x19F55)
    AX = Stack.Pop();
    label_1000_9F56_19F56:
    // MOV CL,0x10 (1000_9F56 / 0x19F56)
    CL = 0x10;
    // MUL CL (1000_9F58 / 0x19F58)
    Cpu.Mul8(CL);
    // ADD AX,0xfd8 (1000_9F5A / 0x19F5A)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    // MOV [0x47a2],AX (1000_9F5D / 0x19F5D)
    UInt16[DS, 0x47A2] = AX;
    // CMP byte ptr [0x46eb],0x0 (1000_9F60 / 0x19F60)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNZ 0x1000:9f82 (1000_9F65 / 0x19F65)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F82_019F82, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c07c (1000_9F67 / 0x19F67)
    NearCall(cs1, 0x9F6A, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9F6A_019F6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9F6A_019F6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F6A_19F6A:
    // MOV word ptr [0x4784],0x28 (1000_9F6A / 0x19F6A)
    UInt16[DS, 0x4784] = 0x28;
    // MOV word ptr [0x4786],0x10 (1000_9F70 / 0x19F70)
    UInt16[DS, 0x4786] = 0x10;
    // MOV word ptr [0x4788],0x10 (1000_9F76 / 0x19F76)
    UInt16[DS, 0x4788] = 0x10;
    // MOV word ptr [0x478a],0x10 (1000_9F7C / 0x19F7C)
    UInt16[DS, 0x478A] = 0x10;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F82_019F82, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F82_019F82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F82_19F82:
    // MOV word ptr [0xdbe4],0xf0 (1000_9F82 / 0x19F82)
    UInt16[DS, 0xDBE4] = 0xF0;
    // JMP 0x1000:d068 (1000_9F88 / 0x19F88)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D068_01D068, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F8B_019F8B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F8B_19F8B:
    // PUSH word ptr [0x47c2] (1000_9F8B / 0x19F8B)
    Stack.Push(UInt16[DS, 0x47C2]);
    // MOV byte ptr [0x47c2],0x20 (1000_9F8F / 0x19F8F)
    UInt8[DS, 0x47C2] = 0x20;
    // CALL 0x1000:9f9e (1000_9F94 / 0x19F94)
    NearCall(cs1, 0x9F97, spice86_generated_label_call_target_1000_9F9E_019F9E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9F97_019F97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9F97_019F97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F97_19F97:
    // POP word ptr [0x47c2] (1000_9F97 / 0x19F97)
    UInt16[DS, 0x47C2] = Stack.Pop();
    // RET  (1000_9F9B / 0x19F9B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9F9C_019F9C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F9C_19F9C:
    // STC  (1000_9F9C / 0x19F9C)
    CarryFlag = true;
    // RET  (1000_9F9D / 0x19F9D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F9E_019F9E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F9E_19F9E:
    // MOV word ptr [0x477c],SI (1000_9F9E / 0x19F9E)
    UInt16[DS, 0x477C] = SI;
    // CALL 0x1000:94f3 (1000_9FA2 / 0x19FA2)
    NearCall(cs1, 0x9FA5, spice86_generated_label_call_target_1000_94F3_0194F3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FA5_019FA5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9FA5_019FA5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9FA5_19FA5:
    // MOV word ptr [0x47bc],0xa6b0 (1000_9FA5 / 0x19FA5)
    UInt16[DS, 0x47BC] = 0xA6B0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9FAB_019FAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9FAB_019FAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9FAB_19FAB:
    // MOV AX,word ptr [SI] (1000_9FAB / 0x19FAB)
    AX = UInt16[DS, SI];
    // CMP AX,0xffff (1000_9FAD / 0x19FAD)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:9f9c (1000_9FB0 / 0x19FB0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9F9C_019F9C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // TEST AL,0x80 (1000_9FB2 / 0x19FB2)
    Alu.And8(AL, 0x80);
    // JZ 0x1000:9fc0 (1000_9FB4 / 0x19FB4)
    if(ZeroFlag) {
      goto label_1000_9FC0_19FC0;
    }
    // TEST AL,0x40 (1000_9FB6 / 0x19FB6)
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:9fc0 (1000_9FB8 / 0x19FB8)
    if(!ZeroFlag) {
      goto label_1000_9FC0_19FC0;
    }
    // AND AL,byte ptr [0x47c2] (1000_9FBA / 0x19FBA)
    // AL &= UInt8[DS, 0x47C2];
    AL = Alu.And8(AL, UInt8[DS, 0x47C2]);
    // JNZ 0x1000:9fd3 (1000_9FBE / 0x19FBE)
    if(!ZeroFlag) {
      goto label_1000_9FD3_19FD3;
    }
    label_1000_9FC0_19FC0:
    // PUSH SI (1000_9FC0 / 0x19FC0)
    Stack.Push(SI);
    // MOV AL,AH (1000_9FC1 / 0x19FC1)
    AL = AH;
    // MOV AH,byte ptr [SI + 0x2] (1000_9FC3 / 0x19FC3)
    AH = UInt8[DS, (ushort)(SI + 0x2)];
    // ROL AH,1 (1000_9FC6 / 0x19FC6)
    AH = Alu.Rol8(AH, 0x1);
    // ROL AH,1 (1000_9FC8 / 0x19FC8)
    AH = Alu.Rol8(AH, 0x1);
    // AND AH,0x3 (1000_9FCA / 0x19FCA)
    // AH &= 0x3;
    AH = Alu.And8(AH, 0x3);
    // CALL 0x1000:a396 (1000_9FCD / 0x19FCD)
    NearCall(cs1, 0x9FD0, spice86_generated_label_call_target_1000_A396_01A396);
    label_1000_9FD0_19FD0:
    // POP SI (1000_9FD0 / 0x19FD0)
    SI = Stack.Pop();
    // JNZ 0x1000:9fd8 (1000_9FD1 / 0x19FD1)
    if(!ZeroFlag) {
      goto label_1000_9FD8_19FD8;
    }
    label_1000_9FD3_19FD3:
    // ADD SI,0x4 (1000_9FD3 / 0x19FD3)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // JMP 0x1000:9fab (1000_9FD6 / 0x19FD6)
    goto label_1000_9FAB_19FAB;
    label_1000_9FD8_19FD8:
    // CMP byte ptr [0x46eb],0x0 (1000_9FD8 / 0x19FD8)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNZ 0x1000:9ff7 (1000_9FDD / 0x19FDD)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEF_019FEF, 0x19FF7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0x47c4] (1000_9FDF / 0x19FDF)
    AX = UInt16[DS, 0x47C4];
    // CMP AX,0x10 (1000_9FE2 / 0x19FE2)
    Alu.Sub16(AX, 0x10);
    // JNC 0x1000:9ff7 (1000_9FE5 / 0x19FE5)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEF_019FEF, 0x19FF7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH SI (1000_9FE7 / 0x19FE7)
    Stack.Push(SI);
    // PUSH AX (1000_9FE8 / 0x19FE8)
    Stack.Push(AX);
    // CALL 0x1000:a0f1 (1000_9FE9 / 0x19FE9)
    NearCall(cs1, 0x9FEC, spice86_generated_label_call_target_1000_A0F1_01A0F1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEC_019FEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9FEC_019FEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9FEC_19FEC:
    // CALL 0x1000:1803 (1000_9FEC / 0x19FEC)
    NearCall(cs1, 0x9FEF, spice86_generated_label_call_target_1000_1803_011803);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEF_019FEF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9FEF_019FEF(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9FF7: goto label_1000_9FF7_19FF7;break; // Target of external jump from 0x19FE5, 0x19FDD
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9FEF_19FEF:
    // CALL 0x1000:3af9 (1000_9FEF / 0x19FEF)
    NearCall(cs1, 0x9FF2, spice86_generated_label_call_target_1000_3AF9_013AF9);
    label_1000_9FF2_19FF2:
    // POP AX (1000_9FF2 / 0x19FF2)
    AX = Stack.Pop();
    // CALL 0x1000:91a0 (1000_9FF3 / 0x19FF3)
    NearCall(cs1, 0x9FF6, spice86_generated_label_call_target_1000_91A0_0191A0);
    label_1000_9FF6_19FF6:
    // POP SI (1000_9FF6 / 0x19FF6)
    SI = Stack.Pop();
    label_1000_9FF7_19FF7:
    // PUSH SI (1000_9FF7 / 0x19FF7)
    Stack.Push(SI);
    // LODSW SI (1000_9FF8 / 0x19FF8)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV [0x47de],AX (1000_9FF9 / 0x19FF9)
    UInt16[DS, 0x47DE] = AX;
    // LODSW SI (1000_9FFC / 0x19FFC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AL,AH (1000_9FFD / 0x19FFD)
    byte tmp_1000_9FFD = AL;
    AL = AH;
    AH = tmp_1000_9FFD;
    // AND AX,0x3ff (1000_9FFF / 0x19FFF)
    // AX &= 0x3FF;
    AX = Alu.And16(AX, 0x3FF);
    // OR AX,0x800 (1000_A002 / 0x1A002)
    // AX |= 0x800;
    AX = Alu.Or16(AX, 0x800);
    // MOV DI,word ptr [0x47bc] (1000_A005 / 0x1A005)
    DI = UInt16[DS, 0x47BC];
    // CMP DI,0xa6b0 (1000_A009 / 0x1A009)
    Alu.Sub16(DI, 0xA6B0);
    // JZ 0x1000:a034 (1000_A00D / 0x1A00D)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A026_01A026, 0x1A034 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,AX (1000_A00F / 0x1A00F)
    SI = AX;
    // CALL 0x1000:cf70 (1000_A011 / 0x1A011)
    NearCall(cs1, 0xA014, spice86_generated_label_call_target_1000_CF70_01CF70);
    // CMP byte ptr ES:[SI],0x80 (1000_A014 / 0x1A014)
    Alu.Sub8(UInt8[ES, SI], 0x80);
    // JC 0x1000:a026 (1000_A018 / 0x1A018)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A026_01A026, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP AX (1000_A01A / 0x1A01A)
    AX = Stack.Pop();
    // SUB AX,0x4 (1000_A01B / 0x1A01B)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    // PUSH AX (1000_A01E / 0x1A01E)
    Stack.Push(AX);
    // MOV byte ptr [DI + -0x1],0xff (1000_A01F / 0x1A01F)
    UInt8[DS, (ushort)(DI - 0x1)] = 0xFF;
    // JMP 0x1000:a02c (1000_A023 / 0x1A023)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_A026_01A026, 0x1A02C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A026_01A026(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA034: goto label_1000_A034_1A034;break; // Target of external jump from 0x1A00D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A026_1A026:
    // CALL 0x1000:88f1 (1000_A026 / 0x1A026)
    NearCall(cs1, 0xA029, spice86_generated_label_call_target_1000_88F1_0188F1);
    // CALL 0x1000:8944 (1000_A029 / 0x1A029)
    NearCall(cs1, 0xA02C, spice86_generated_label_call_target_1000_8944_018944);
    label_1000_A02C_1A02C:
    // MOV SI,0xa6b0 (1000_A02C / 0x1A02C)
    SI = 0xA6B0;
    // CALL 0x1000:8b11 (1000_A02F / 0x1A02F)
    NearCall(cs1, 0xA032, spice86_generated_label_call_target_1000_8B11_018B11);
    // JMP 0x1000:a03e (1000_A032 / 0x1A032)
    goto label_1000_A03E_1A03E;
    label_1000_A034_1A034:
    // CMP byte ptr [0xc6],0x0 (1000_A034 / 0x1A034)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    // JNZ 0x1000:a03e (1000_A039 / 0x1A039)
    if(!ZeroFlag) {
      goto label_1000_A03E_1A03E;
    }
    // CALL 0x1000:88af (1000_A03B / 0x1A03B)
    NearCall(cs1, 0xA03E, spice86_generated_label_call_target_1000_88AF_0188AF);
    label_1000_A03E_1A03E:
    // POP SI (1000_A03E / 0x1A03E)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A03F_01A03F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A03F_01A03F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A03F_1A03F:
    // CALL 0x1000:c85b (1000_A03F / 0x1A03F)
    NearCall(cs1, 0xA042, spice86_generated_label_call_target_1000_C85B_01C85B);
    label_1000_A042_1A042:
    // CMP word ptr [0x47b6],0x0 (1000_A042 / 0x1A042)
    Alu.Sub16(UInt16[DS, 0x47B6], 0x0);
    // JNZ 0x1000:a0aa (1000_A047 / 0x1A047)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A05D_01A05D, 0x1A0AA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,byte ptr [SI] (1000_A049 / 0x1A049)
    AL = UInt8[DS, SI];
    // AND AL,0xf (1000_A04B / 0x1A04B)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // JZ 0x1000:a05e (1000_A04D / 0x1A04D)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A05D_01A05D, 0x1A05E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // XOR AH,AH (1000_A04F / 0x1A04F)
    AH = 0;
    // PUSH SI (1000_A051 / 0x1A051)
    Stack.Push(SI);
    // DEC AX (1000_A052 / 0x1A052)
    AX--;
    // SHL AX,1 (1000_A053 / 0x1A053)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BX,0xa107 (1000_A055 / 0x1A055)
    BX = 0xA107;
    // ADD BX,AX (1000_A058 / 0x1A058)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // CALL word ptr CS:[BX] (1000_A05A / 0x1A05A)
    // Indirect call to word ptr CS:[BX], generating possible targets from emulator records
    uint targetAddress_1000_A05A = (uint)(UInt16[cs1, BX]);
    switch(targetAddress_1000_A05A) {
      case 0xA1E8 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1E8_01A1E8); break;
      case 0xA1D6 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1D6_01A1D6); break;
      case 0xA1D0 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1D0_01A1D0); break;
      case 0xA219 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A219_01A219); break;
      case 0xA172 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A172_01A172); break;
      case 0xA25B : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A25B_01A25B); break;
      case 0xA235 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A235_01A235); break;
      case 0xA1DC : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1DC_01A1DC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A05A));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A05D_01A05D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A05D_01A05D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA0AA: goto label_1000_A0AA_1A0AA;break; // Target of external jump from 0x1A0A5, 0x1A047
      case 0xA05E: goto label_1000_A05E_1A05E;break; // Target of external jump from 0x1A04D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A05D_1A05D:
    // POP SI (1000_A05D / 0x1A05D)
    SI = Stack.Pop();
    label_1000_A05E_1A05E:
    // MOV AL,byte ptr [SI + 0x2] (1000_A05E / 0x1A05E)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    // AND AL,0xc (1000_A061 / 0x1A061)
    // AL &= 0xC;
    AL = Alu.And8(AL, 0xC);
    // JZ 0x1000:a092 (1000_A063 / 0x1A063)
    if(ZeroFlag) {
      goto label_1000_A092_1A092;
    }
    // TEST byte ptr [SI],0x80 (1000_A065 / 0x1A065)
    Alu.And8(UInt8[DS, SI], 0x80);
    // JNZ 0x1000:a092 (1000_A068 / 0x1A068)
    if(!ZeroFlag) {
      goto label_1000_A092_1A092;
    }
    // MOV AX,SI (1000_A06A / 0x1A06A)
    AX = SI;
    // SUB AX,0xaa78 (1000_A06C / 0x1A06C)
    AX -= 0xAA78;
    // SHR AX,1 (1000_A06F / 0x1A06F)
    AX >>= 0x1;
    // SHR AX,1 (1000_A071 / 0x1A071)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV BL,byte ptr [0x47c4] (1000_A073 / 0x1A073)
    BL = UInt8[DS, 0x47C4];
    // SHL BL,1 (1000_A077 / 0x1A077)
    BL <<= 0x1;
    // SHL BL,1 (1000_A079 / 0x1A079)
    BL <<= 0x1;
    // SHL BL,1 (1000_A07B / 0x1A07B)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    // OR AH,BL (1000_A07D / 0x1A07D)
    // AH |= BL;
    AH = Alu.Or8(AH, BL);
    // MOV BP,word ptr [0x11bd] (1000_A07F / 0x1A07F)
    BP = UInt16[DS, 0x11BD];
    // MOV word ptr CS:[BP + 0x0],AX (1000_A083 / 0x1A083)
    UInt16[cs1, BP] = AX;
    // MOV word ptr CS:[BP + 0x2],0x0 (1000_A087 / 0x1A087)
    UInt16[cs1, (ushort)(BP + 0x2)] = 0x0;
    // ADD word ptr [0x11bd],0x2 (1000_A08D / 0x1A08D)
    // UInt16[DS, 0x11BD] += 0x2;
    UInt16[DS, 0x11BD] = Alu.Add16(UInt16[DS, 0x11BD], 0x2);
    label_1000_A092_1A092:
    // MOV byte ptr [0x19],0xff (1000_A092 / 0x1A092)
    UInt8[DS, 0x19] = 0xFF;
    // OR byte ptr [SI],0x80 (1000_A097 / 0x1A097)
    UInt8[DS, SI] |= 0x80;
    // ADD SI,0x4 (1000_A09A / 0x1A09A)
    SI += 0x4;
    // XOR AL,AL (1000_A09D / 0x1A09D)
    AL = 0;
    // XCHG byte ptr [0x47a8],AL (1000_A09F / 0x1A09F)
    byte tmp_1000_A09F = UInt8[DS, 0x47A8];
    UInt8[DS, 0x47A8] = AL;
    AL = tmp_1000_A09F;
    // OR AL,AL (1000_A0A3 / 0x1A0A3)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:a0aa (1000_A0A5 / 0x1A0A5)
    if(ZeroFlag) {
      goto label_1000_A0AA_1A0AA;
    }
    // MOV SI,0xffff (1000_A0A7 / 0x1A0A7)
    SI = 0xFFFF;
    label_1000_A0AA_1A0AA:
    // CMP byte ptr [0x46eb],0x0 (1000_A0AA / 0x1A0AA)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNZ 0x1000:a0e2 (1000_A0AF / 0x1A0AF)
    if(!ZeroFlag) {
      goto label_1000_A0E2_1A0E2;
    }
    // CMP word ptr [0x47c4],0x10 (1000_A0B1 / 0x1A0B1)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    // JNC 0x1000:a0e2 (1000_A0B6 / 0x1A0B6)
    if(!CarryFlag) {
      goto label_1000_A0E2_1A0E2;
    }
    // PUSH SI (1000_A0B8 / 0x1A0B8)
    Stack.Push(SI);
    // CALL 0x1000:978e (1000_A0B9 / 0x1A0B9)
    NearCall(cs1, 0xA0BC, spice86_generated_label_call_target_1000_978E_01978E);
    label_1000_A0BC_1A0BC:
    // POP SI (1000_A0BC / 0x1A0BC)
    SI = Stack.Pop();
    // CMP byte ptr [0x4774],0x0 (1000_A0BD / 0x1A0BD)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:a0c9 (1000_A0C2 / 0x1A0C2)
    if(ZeroFlag) {
      goto label_1000_A0C9_1A0C9;
    }
    // PUSH SI (1000_A0C4 / 0x1A0C4)
    Stack.Push(SI);
    // CALL 0x1000:2ebf (1000_A0C5 / 0x1A0C5)
    NearCall(cs1, 0xA0C8, not_observed_1000_2EBF_012EBF);
    // POP SI (1000_A0C8 / 0x1A0C8)
    SI = Stack.Pop();
    label_1000_A0C9_1A0C9:
    // CMP byte ptr [0xea],0x0 (1000_A0C9 / 0x1A0C9)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    // JG 0x1000:a0e2 (1000_A0CE / 0x1A0CE)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_A0E2_1A0E2;
    }
    // CALL 0x1000:e270 (1000_A0D0 / 0x1A0D0)
    NearCall(cs1, 0xA0D3, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_A0D3_1A0D3:
    // CALL 0x1000:9efd (1000_A0D3 / 0x1A0D3)
    NearCall(cs1, 0xA0D6, spice86_generated_label_call_target_1000_9EFD_019EFD);
    label_1000_A0D6_1A0D6:
    // MOV AX,0xf66 (1000_A0D6 / 0x1A0D6)
    AX = 0xF66;
    // XCHG word ptr [0x227e],AX (1000_A0D9 / 0x1A0D9)
    ushort tmp_1000_A0D9 = UInt16[DS, 0x227E];
    UInt16[DS, 0x227E] = AX;
    AX = tmp_1000_A0D9;
    // CALL AX (1000_A0DD / 0x1A0DD)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_A0DD = (uint)(AX);
    switch(targetAddress_1000_A0DD) {
      case 0xF66 : NearCall(cs1, 0xA0DF, spice86_generated_label_call_target_1000_0F66_010F66); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A0DD));
        break;
    }
    label_1000_A0DF_1A0DF:
    // CALL 0x1000:e283 (1000_A0DF / 0x1A0DF)
    NearCall(cs1, 0xA0E2, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_A0E2_1A0E2:
    // CMP byte ptr [0xfb],0x0 (1000_A0E2 / 0x1A0E2)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:a0ef (1000_A0E7 / 0x1A0E7)
    if(SignFlag) {
      goto label_1000_A0EF_1A0EF;
    }
    // MOV AL,[0x28e8] (1000_A0E9 / 0x1A0E9)
    AL = UInt8[DS, 0x28E8];
    // MOV [0x28e7],AL (1000_A0EC / 0x1A0EC)
    UInt8[DS, 0x28E7] = AL;
    label_1000_A0EF_1A0EF:
    // CLC  (1000_A0EF / 0x1A0EF)
    CarryFlag = false;
    // RET  (1000_A0F0 / 0x1A0F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A0F1_01A0F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A0F1_1A0F1:
    // CMP byte ptr [0x28e7],0x2 (1000_A0F1 / 0x1A0F1)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x2);
    // JNZ 0x1000:a103 (1000_A0F6 / 0x1A0F6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A103 / 0x1A103)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x2],0x10 (1000_A0F8 / 0x1A0F8)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x2)], 0x10);
    // JZ 0x1000:a104 (1000_A0FC / 0x1A0FC)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:8c8a (1000_A104 / 0x1A104)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8C8A_018C8A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [0x28e7],0x1 (1000_A0FE / 0x1A0FE)
    UInt8[DS, 0x28E7] = 0x1;
    label_1000_A103_1A103:
    // RET  (1000_A103 / 0x1A103)
    return NearRet();
    label_1000_A104_1A104:
    // JMP 0x1000:8c8a (1000_A104 / 0x1A104)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8C8A_018C8A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A156_01A156(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A156_1A156:
    // RET  (1000_A156 / 0x1A156)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A172_01A172(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A172_1A172:
    // MOV AX,[0x47c4] (1000_A172 / 0x1A172)
    AX = UInt16[DS, 0x47C4];
    // CMP AX,0x1 (1000_A175 / 0x1A175)
    Alu.Sub16(AX, 0x1);
    // JNZ 0x1000:a17e (1000_A178 / 0x1A178)
    if(!ZeroFlag) {
      goto label_1000_A17E_1A17E;
    }
    // INC byte ptr [0xf5] (1000_A17A / 0x1A17A)
    UInt8[DS, 0xF5]++;
    label_1000_A17E_1A17E:
    // CMP AX,0x3 (1000_A17E / 0x1A17E)
    Alu.Sub16(AX, 0x3);
    // JNZ 0x1000:a156 (1000_A181 / 0x1A181)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A156 / 0x1A156)
      return NearRet();
    }
    // JMP 0x1000:24a3 (1000_A183 / 0x1A183)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_24A3_0124A3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1C4_01A1C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A1C4_1A1C4:
    // MOV byte ptr [0x47a5],0xff (1000_A1C4 / 0x1A1C4)
    UInt8[DS, 0x47A5] = 0xFF;
    // RET  (1000_A1C9 / 0x1A1C9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1D0_01A1D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A1D0_1A1D0:
    // MOV byte ptr [0x47a5],0xff (1000_A1D0 / 0x1A1D0)
    UInt8[DS, 0x47A5] = 0xFF;
    // RET  (1000_A1D5 / 0x1A1D5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1D6_01A1D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A1D6_1A1D6:
    // MOV byte ptr [0x47a5],0x0 (1000_A1D6 / 0x1A1D6)
    UInt8[DS, 0x47A5] = 0x0;
    // RET  (1000_A1DB / 0x1A1DB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1DC_01A1DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A1DC_1A1DC:
    // MOV byte ptr [0x47a5],0x80 (1000_A1DC / 0x1A1DC)
    UInt8[DS, 0x47A5] = 0x80;
    // RET  (1000_A1E1 / 0x1A1E1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1E2_01A1E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A1E2_1A1E2:
    // CMP byte ptr [0x47a5],0xff (1000_A1E2 / 0x1A1E2)
    Alu.Sub8(UInt8[DS, 0x47A5], 0xFF);
    // RET  (1000_A1E7 / 0x1A1E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1E8_01A1E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A1E8_1A1E8:
    // INC byte ptr [0x47a8] (1000_A1E8 / 0x1A1E8)
    UInt8[DS, 0x47A8] = Alu.Inc8(UInt8[DS, 0x47A8]);
    // RET  (1000_A1EC / 0x1A1EC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A219_01A219(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A219_1A219:
    // TEST byte ptr [SI],0x80 (1000_A219 / 0x1A219)
    Alu.And8(UInt8[DS, SI], 0x80);
    // JNZ 0x1000:a234 (1000_A21C / 0x1A21C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A234 / 0x1A234)
      return NearRet();
    }
    // INC byte ptr [0x2a] (1000_A21E / 0x1A21E)
    UInt8[DS, 0x2A] = Alu.Inc8(UInt8[DS, 0x2A]);
    // MOV byte ptr [0xff],0x0 (1000_A222 / 0x1A222)
    UInt8[DS, 0xFF] = 0x0;
    // CALL 0x1000:b17a (1000_A227 / 0x1A227)
    NearCall(cs1, 0xA22A, spice86_generated_label_call_target_1000_B17A_01B17A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A22A_01A22A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A22A_01A22A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A22A_1A22A:
    // CMP byte ptr [0x2a],0x1 (1000_A22A / 0x1A22A)
    Alu.Sub8(UInt8[DS, 0x2A], 0x1);
    // JNZ 0x1000:a234 (1000_A22F / 0x1A22F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A234 / 0x1A234)
      return NearRet();
    }
    // CALL 0x1000:100b (1000_A231 / 0x1A231)
    NearCall(cs1, 0xA234, spice86_generated_label_call_target_1000_100B_01100B);
    label_1000_A234_1A234:
    // RET  (1000_A234 / 0x1A234)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A235_01A235(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A235_1A235:
    // TEST byte ptr [SI],0x80 (1000_A235 / 0x1A235)
    Alu.And8(UInt8[DS, SI], 0x80);
    // JNZ 0x1000:a234 (1000_A238 / 0x1A238)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A234 / 0x1A234)
      return NearRet();
    }
    // MOV AL,[0x2a] (1000_A23A / 0x1A23A)
    AL = UInt8[DS, 0x2A];
    // AND AL,0xfc (1000_A23D / 0x1A23D)
    AL &= 0xFC;
    // ADD AL,0x4 (1000_A23F / 0x1A23F)
    // AL += 0x4;
    AL = Alu.Add8(AL, 0x4);
    // JMP 0x1000:121f (1000_A241 / 0x1A241)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_121F_01121F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A25B_01A25B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A25B_1A25B:
    // PUSH SI (1000_A25B / 0x1A25B)
    Stack.Push(SI);
    // PUSH DS (1000_A25C / 0x1A25C)
    Stack.Push(DS);
    // POP ES (1000_A25D / 0x1A25D)
    ES = Stack.Pop();
    // MOV AX,[0x4780] (1000_A25E / 0x1A25E)
    AX = UInt16[DS, 0x4780];
    // MOV BX,0xa01 (1000_A261 / 0x1A261)
    BX = 0xA01;
    // MOV DI,0x197c (1000_A264 / 0x1A264)
    DI = 0x197C;
    label_1000_A267_1A267:
    // ADD DI,0x8 (1000_A267 / 0x1A267)
    DI += 0x8;
    // SCASW ES:DI (1000_A26A / 0x1A26A)
    Alu.Sub16(AX, UInt16[ES, DI]);
    DI = (ushort)(DI + Direction16);
    // JA 0x1000:a267 (1000_A26B / 0x1A26B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_A267_1A267;
    }
    // JNZ 0x1000:a28c (1000_A26D / 0x1A26D)
    if(!ZeroFlag) {
      goto label_1000_A28C_1A28C;
    }
    // CMP word ptr [DI],0x38 (1000_A26F / 0x1A26F)
    Alu.Sub16(UInt16[DS, DI], 0x38);
    // JNZ 0x1000:a276 (1000_A272 / 0x1A272)
    if(!ZeroFlag) {
      goto label_1000_A276_1A276;
    }
    // MOV BH,0x10 (1000_A274 / 0x1A274)
    BH = 0x10;
    label_1000_A276_1A276:
    // MOV AL,[0x47d0] (1000_A276 / 0x1A276)
    AL = UInt8[DS, 0x47D0];
    // DEC AL (1000_A279 / 0x1A279)
    AL = Alu.Dec8(AL);
    // JS 0x1000:a284 (1000_A27B / 0x1A27B)
    if(SignFlag) {
      goto label_1000_A284_1A284;
    }
    // SHL AL,1 (1000_A27D / 0x1A27D)
    AL <<= 0x1;
    // INC AX (1000_A27F / 0x1A27F)
    AX++;
    // SHL AL,1 (1000_A280 / 0x1A280)
    AL <<= 0x1;
    // ADD BH,AL (1000_A282 / 0x1A282)
    // BH += AL;
    BH = Alu.Add8(BH, AL);
    label_1000_A284_1A284:
    // MOV word ptr [0x47e1],BX (1000_A284 / 0x1A284)
    UInt16[DS, 0x47E1] = BX;
    // MOV word ptr [0x47e4],DI (1000_A288 / 0x1A288)
    UInt16[DS, 0x47E4] = DI;
    label_1000_A28C_1A28C:
    // POP SI (1000_A28C / 0x1A28C)
    SI = Stack.Pop();
    // RET  (1000_A28D / 0x1A28D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A30B_01A30B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A30B_1A30B:
    // LODSB ES:SI (1000_A30B / 0x1A30B)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0x80 (1000_A30D / 0x1A30D)
    Alu.Sub8(AL, 0x80);
    // JNC 0x1000:a32a (1000_A30F / 0x1A30F)
    if(!CarryFlag) {
      goto label_1000_A32A_1A32A;
    }
    // PUSH BX (1000_A311 / 0x1A311)
    Stack.Push(BX);
    // MOV BL,byte ptr ES:[SI] (1000_A312 / 0x1A312)
    BL = UInt8[ES, SI];
    // INC SI (1000_A315 / 0x1A315)
    SI++;
    // XOR BH,BH (1000_A316 / 0x1A316)
    BH = 0;
    // CMP AL,0x1 (1000_A318 / 0x1A318)
    Alu.Sub8(AL, 0x1);
    // JZ 0x1000:a322 (1000_A31A / 0x1A31A)
    if(ZeroFlag) {
      goto label_1000_A322_1A322;
    }
    // MOV AX,word ptr [BX + 0x0] (1000_A31C / 0x1A31C)
    AX = UInt16[DS, BX];
    // POP BX (1000_A320 / 0x1A320)
    BX = Stack.Pop();
    // RET  (1000_A321 / 0x1A321)
    return NearRet();
    label_1000_A322_1A322:
    // MOV AL,byte ptr [BX + 0x0] (1000_A322 / 0x1A322)
    AL = UInt8[DS, BX];
    // XOR AH,AH (1000_A326 / 0x1A326)
    AH = 0;
    // POP BX (1000_A328 / 0x1A328)
    BX = Stack.Pop();
    // RET  (1000_A329 / 0x1A329)
    return NearRet();
    label_1000_A32A_1A32A:
    // JNZ 0x1000:a331 (1000_A32A / 0x1A32A)
    if(!ZeroFlag) {
      goto label_1000_A331_1A331;
    }
    // LODSB ES:SI (1000_A32C / 0x1A32C)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_A32E / 0x1A32E)
    AH = 0;
    // RET  (1000_A330 / 0x1A330)
    return NearRet();
    label_1000_A331_1A331:
    // LODSW ES:SI (1000_A331 / 0x1A331)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // RET  (1000_A333 / 0x1A333)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A334_01A334(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A334_1A334:
    // AND BX,0x1f (1000_A334 / 0x1A334)
    // BX &= 0x1F;
    BX = Alu.And16(BX, 0x1F);
    // JMP word ptr CS:[BX + 0xa376] (1000_A337 / 0x1A337)
    // Indirect jump to word ptr CS:[BX + 0xa376], generating possible targets from emulator records
    uint targetAddress_1000_A337 = (uint)(UInt16[cs1, (ushort)(BX + 0xA376)]);
    switch(targetAddress_1000_A337) {
      case 0xA348 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A348_01A348, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA345 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A345_01A345, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA342 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A342_01A342, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA356 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A356_01A356, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA34F : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A34F_01A34F, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA33F : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A33F_01A33F, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA35D : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A35D_01A35D, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA33C : {
        goto label_1000_A33C_1A33C;
        break;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A337));
        break;
    }
    label_1000_A33C_1A33C:
    // ADD DX,AX (1000_A33C / 0x1A33C)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // RET  (1000_A33E / 0x1A33E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A33F_01A33F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A33F_1A33F:
    // SUB DX,AX (1000_A33F / 0x1A33F)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // RET  (1000_A341 / 0x1A341)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A342_01A342(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A342_1A342:
    // AND DX,AX (1000_A342 / 0x1A342)
    // DX &= AX;
    DX = Alu.And16(DX, AX);
    // RET  (1000_A344 / 0x1A344)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A345_01A345(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A345_1A345:
    // OR DX,AX (1000_A345 / 0x1A345)
    // DX |= AX;
    DX = Alu.Or16(DX, AX);
    // RET  (1000_A347 / 0x1A347)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A348_01A348(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A348_1A348:
    // CMP DX,AX (1000_A348 / 0x1A348)
    Alu.Sub16(DX, AX);
    // JZ 0x1000:a372 (1000_A34A / 0x1A34A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // XOR DX,DX (1000_A34C / 0x1A34C)
    DX = 0;
    // RET  (1000_A34E / 0x1A34E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A34F_01A34F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A34F_1A34F:
    // CMP DX,AX (1000_A34F / 0x1A34F)
    Alu.Sub16(DX, AX);
    // JC 0x1000:a372 (1000_A351 / 0x1A351)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // XOR DX,DX (1000_A353 / 0x1A353)
    DX = 0;
    // RET  (1000_A355 / 0x1A355)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A356_01A356(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A356_1A356:
    // CMP DX,AX (1000_A356 / 0x1A356)
    Alu.Sub16(DX, AX);
    // JA 0x1000:a372 (1000_A358 / 0x1A358)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // XOR DX,DX (1000_A35A / 0x1A35A)
    DX = 0;
    // RET  (1000_A35C / 0x1A35C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A35D_01A35D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A35D_1A35D:
    // CMP DX,AX (1000_A35D / 0x1A35D)
    Alu.Sub16(DX, AX);
    // JNZ 0x1000:a372 (1000_A35F / 0x1A35F)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // XOR DX,DX (1000_A361 / 0x1A361)
    DX = 0;
    // RET  (1000_A363 / 0x1A363)
    return NearRet();
  }
  
  public virtual Action split_1000_A372_01A372(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A372_1A372:
    // MOV DX,0xffff (1000_A372 / 0x1A372)
    DX = 0xFFFF;
    // RET  (1000_A375 / 0x1A375)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A396_01A396(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A396_1A396:
    // SUB SP,0x32 (1000_A396 / 0x1A396)
    // SP -= 0x32;
    SP = Alu.Sub16(SP, 0x32);
    // MOV BP,SP (1000_A399 / 0x1A399)
    BP = SP;
    // SHL AX,1 (1000_A39B / 0x1A39B)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // LES SI,[0xaa72] (1000_A39D / 0x1A39D)
    ES = UInt16[DS, 0xAA74];
    SI = UInt16[DS, 0xAA72];
    // ADD SI,AX (1000_A3A1 / 0x1A3A1)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV SI,word ptr ES:[SI + -0x2] (1000_A3A3 / 0x1A3A3)
    SI = UInt16[ES, (ushort)(SI - 0x2)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A3A7_01A3A7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A3A7_01A3A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A3A7_1A3A7:
    // CALL 0x1000:a30b (1000_A3A7 / 0x1A3A7)
    NearCall(cs1, 0xA3AA, spice86_generated_label_call_target_1000_A30B_01A30B);
    label_1000_A3AA_1A3AA:
    // MOV DX,AX (1000_A3AA / 0x1A3AA)
    DX = AX;
    label_1000_A3AC_1A3AC:
    // LODSB ES:SI (1000_A3AC / 0x1A3AC)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_A3AE / 0x1A3AE)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:a3cb (1000_A3B0 / 0x1A3B0)
    if(ZeroFlag) {
      goto label_1000_A3CB_1A3CB;
    }
    // TEST AL,0x80 (1000_A3B2 / 0x1A3B2)
    Alu.And8(AL, 0x80);
    // JNZ 0x1000:a3c0 (1000_A3B4 / 0x1A3B4)
    if(!ZeroFlag) {
      goto label_1000_A3C0_1A3C0;
    }
    // MOV BL,AL (1000_A3B6 / 0x1A3B6)
    BL = AL;
    // CALL 0x1000:a30b (1000_A3B8 / 0x1A3B8)
    NearCall(cs1, 0xA3BB, spice86_generated_label_call_target_1000_A30B_01A30B);
    label_1000_A3BB_1A3BB:
    // CALL 0x1000:a334 (1000_A3BB / 0x1A3BB)
    NearCall(cs1, 0xA3BE, spice86_generated_label_call_target_1000_A334_01A334);
    label_1000_A3BE_1A3BE:
    // JMP 0x1000:a3ac (1000_A3BE / 0x1A3BE)
    goto label_1000_A3AC_1A3AC;
    label_1000_A3C0_1A3C0:
    // MOV word ptr [BP + 0x0],DX (1000_A3C0 / 0x1A3C0)
    UInt16[SS, BP] = DX;
    // MOV word ptr [BP + 0x2],AX (1000_A3C3 / 0x1A3C3)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // ADD BP,0x4 (1000_A3C6 / 0x1A3C6)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    // JMP 0x1000:a3a7 (1000_A3C9 / 0x1A3C9)
    goto label_1000_A3A7_1A3A7;
    label_1000_A3CB_1A3CB:
    // MOV SI,SP (1000_A3CB / 0x1A3CB)
    SI = SP;
    // CMP SI,BP (1000_A3CD / 0x1A3CD)
    Alu.Sub16(SI, BP);
    // JZ 0x1000:a3e2 (1000_A3CF / 0x1A3CF)
    if(ZeroFlag) {
      goto label_1000_A3E2_1A3E2;
    }
    // MOV word ptr [BP + 0x0],DX (1000_A3D1 / 0x1A3D1)
    UInt16[SS, BP] = DX;
    // LODSW SI (1000_A3D4 / 0x1A3D4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_A3D5 / 0x1A3D5)
    DX = AX;
    label_1000_A3D7_1A3D7:
    // LODSW SI (1000_A3D7 / 0x1A3D7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_A3D8 / 0x1A3D8)
    BX = AX;
    // LODSW SI (1000_A3DA / 0x1A3DA)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CALL 0x1000:a334 (1000_A3DB / 0x1A3DB)
    NearCall(cs1, 0xA3DE, spice86_generated_label_call_target_1000_A334_01A334);
    label_1000_A3DE_1A3DE:
    // CMP SI,BP (1000_A3DE / 0x1A3DE)
    Alu.Sub16(SI, BP);
    // JC 0x1000:a3d7 (1000_A3E0 / 0x1A3E0)
    if(CarryFlag) {
      goto label_1000_A3D7_1A3D7;
    }
    label_1000_A3E2_1A3E2:
    // ADD SP,0x32 (1000_A3E2 / 0x1A3E2)
    // SP += 0x32;
    SP = Alu.Add16(SP, 0x32);
    // OR DX,DX (1000_A3E5 / 0x1A3E5)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // RET  (1000_A3E7 / 0x1A3E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A3F0_01A3F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A3F0_1A3F0:
    // MOV AX,0x1ad6 (1000_A3F0 / 0x1A3F0)
    AX = 0x1AD6;
    // CALL 0x1000:d95e (1000_A3F3 / 0x1A3F3)
    NearCall(cs1, 0xA3F6, spice86_generated_label_call_target_1000_D95E_01D95E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A3F6_01A3F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A3F6_01A3F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A3F6_1A3F6:
    // CALL 0x1000:d2bd (1000_A3F6 / 0x1A3F6)
    NearCall(cs1, 0xA3F9, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A3F9_01A3F9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A3F9_01A3F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A3F9_1A3F9:
    // PUSH word ptr [0xdbda] (1000_A3F9 / 0x1A3F9)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_A3FD / 0x1A3FD)
    NearCall(cs1, 0xA400, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_A400_1A400:
    // MOV AX,0x55 (1000_A400 / 0x1A400)
    AX = 0x55;
    // CALL 0x1000:c13e (1000_A403 / 0x1A403)
    NearCall(cs1, 0xA406, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_A406_1A406:
    // XOR AX,AX (1000_A406 / 0x1A406)
    AX = 0;
    // MOV DX,word ptr [0x2886] (1000_A408 / 0x1A408)
    DX = UInt16[DS, 0x2886];
    // MOV BX,word ptr [0x2888] (1000_A40C / 0x1A40C)
    BX = UInt16[DS, 0x2888];
    // CALL 0x1000:c22f (1000_A410 / 0x1A410)
    NearCall(cs1, 0xA413, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_A413_1A413:
    // POP word ptr [0xdbda] (1000_A413 / 0x1A413)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // CALL 0x1000:a4c6 (1000_A417 / 0x1A417)
    NearCall(cs1, 0xA41A, spice86_generated_label_call_target_1000_A4C6_01A4C6);
    label_1000_A41A_1A41A:
    // CALL 0x1000:a47d (1000_A41A / 0x1A41A)
    NearCall(cs1, 0xA41D, spice86_generated_label_call_target_1000_A47D_01A47D);
    label_1000_A41D_1A41D:
    // CALL 0x1000:a42c (1000_A41D / 0x1A41D)
    NearCall(cs1, 0xA420, spice86_generated_label_call_target_1000_A42C_01A42C);
    label_1000_A420_1A420:
    // CALL 0x1000:a44c (1000_A420 / 0x1A420)
    NearCall(cs1, 0xA423, spice86_generated_label_call_target_1000_A44C_01A44C);
    label_1000_A423_1A423:
    // CALL 0x1000:ac3a (1000_A423 / 0x1A423)
    NearCall(cs1, 0xA426, spice86_generated_label_call_target_1000_AC3A_01AC3A);
    label_1000_A426_1A426:
    // MOV BX,0xa541 (1000_A426 / 0x1A426)
    BX = 0xA541;
    // JMP 0x1000:d32f (1000_A429 / 0x1A429)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D32F_01D32F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A42C_01A42C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A42C_1A42C:
    // MOV AX,0x55 (1000_A42C / 0x1A42C)
    AX = 0x55;
    // CALL 0x1000:c13e (1000_A42F / 0x1A42F)
    NearCall(cs1, 0xA432, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A432_01A432, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A432_01A432(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA435: goto label_1000_A435_1A435;break; // Target of external jump from 0x1A451
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A432_1A432:
    // MOV AL,[0xceeb] (1000_A432 / 0x1A432)
    AL = UInt8[DS, 0xCEEB];
    label_1000_A435_1A435:
    // PUSH word ptr [0xdbda] (1000_A435 / 0x1A435)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_A439 / 0x1A439)
    NearCall(cs1, 0xA43C, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A43C_01A43C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A43C_01A43C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A43C_1A43C:
    // CBW  (1000_A43C / 0x1A43C)
    AX = (ushort)((short)((sbyte)AL));
    // CALL 0x1000:a465 (1000_A43D / 0x1A43D)
    NearCall(cs1, 0xA440, spice86_generated_label_call_target_1000_A465_01A465);
    label_1000_A440_1A440:
    // SHL AX,1 (1000_A440 / 0x1A440)
    AX <<= 0x1;
    // ADD AL,0x1c (1000_A442 / 0x1A442)
    // AL += 0x1C;
    AL = Alu.Add8(AL, 0x1C);
    // CALL 0x1000:c22f (1000_A444 / 0x1A444)
    NearCall(cs1, 0xA447, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_A447_1A447:
    // POP word ptr [0xdbda] (1000_A447 / 0x1A447)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_A44B / 0x1A44B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A44C_01A44C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A44C_1A44C:
    // MOV AL,[0x28e7] (1000_A44C / 0x1A44C)
    AL = UInt8[DS, 0x28E7];
    // ADD AL,0x8 (1000_A44F / 0x1A44F)
    // AL += 0x8;
    AL = Alu.Add8(AL, 0x8);
    // JMP 0x1000:a435 (1000_A451 / 0x1A451)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A432_01A432, 0x1A435 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
