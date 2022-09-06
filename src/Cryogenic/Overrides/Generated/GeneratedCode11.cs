namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_8685_018685(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8685_18685:
    // MOV byte ptr [0x46d8],0x1 (1000_8685 / 0x18685)
    UInt8[DS, 0x46D8] = 0x1;
    State.IncCycles();
    // CALL 0x1000:69a3 (1000_868A / 0x1868A)
    NearCall(cs1, 0x868D, spice86_generated_label_call_target_1000_69A3_0169A3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_868D_01868D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_868D_01868D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_868D_1868D:
    // CALL 0x1000:7b58 (1000_868D / 0x1868D)
    NearCall(cs1, 0x8690, spice86_generated_label_call_target_1000_7B58_017B58);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8690_018690, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8690_018690(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8690_18690:
    // CALL 0x1000:5f79 (1000_8690 / 0x18690)
    NearCall(cs1, 0x8693, spice86_generated_label_call_target_1000_5F79_015F79);
    State.IncCycles();
    label_1000_8693_18693:
    // CALL 0x1000:79de (1000_8693 / 0x18693)
    NearCall(cs1, 0x8696, spice86_generated_label_call_target_1000_79DE_0179DE);
    State.IncCycles();
    label_1000_8696_18696:
    // CALL 0x1000:58fa (1000_8696 / 0x18696)
    NearCall(cs1, 0x8699, spice86_generated_label_call_target_1000_58FA_0158FA);
    State.IncCycles();
    label_1000_8699_18699:
    // MOV AL,[0x1954] (1000_8699 / 0x18699)
    AL = UInt8[DS, 0x1954];
    State.IncCycles();
    // CMP AL,0x43 (1000_869C / 0x1869C)
    Alu.Sub8(AL, 0x43);
    State.IncCycles();
    // JA 0x1000:86b8 (1000_869E / 0x1869E)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_86B8 / 0x186B8)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:6906 (1000_86A0 / 0x186A0)
    NearCall(cs1, 0x86A3, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    label_1000_86A3_186A3:
    // JNC 0x1000:86b8 (1000_86A3 / 0x186A3)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_86B8 / 0x186B8)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0x1955],AL (1000_86A5 / 0x186A5)
    UInt8[DS, 0x1955] = AL;
    State.IncCycles();
    // PUSH SI (1000_86A8 / 0x186A8)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:697c (1000_86A9 / 0x186A9)
    NearCall(cs1, 0x86AC, spice86_generated_label_call_target_1000_697C_01697C);
    State.IncCycles();
    label_1000_86AC_186AC:
    // POP SI (1000_86AC / 0x186AC)
    SI = Stack.Pop();
    State.IncCycles();
    // PUSH SI (1000_86AD / 0x186AD)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:780a (1000_86AE / 0x186AE)
    NearCall(cs1, 0x86B1, spice86_generated_label_call_target_1000_780A_01780A);
    State.IncCycles();
    label_1000_86B1_186B1:
    // POP SI (1000_86B1 / 0x186B1)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_86B2 / 0x186B2)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL 0x1000:7c02 (1000_86B5 / 0x186B5)
    NearCall(cs1, 0x86B8, spice86_generated_label_call_target_1000_7C02_017C02);
    State.IncCycles();
    label_1000_86B8_186B8:
    // RET  (1000_86B8 / 0x186B8)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_872C_01872C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_872C_1872C:
    // MOV SI,word ptr [SI + 0xa] (1000_872C / 0x1872C)
    SI = UInt16[DS, (ushort)(SI + 0xA)];
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_872F / 0x1872F)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CMP word ptr [0x1176],0x2 (1000_8731 / 0x18731)
    Alu.Sub16(UInt16[DS, 0x1176], 0x2);
    State.IncCycles();
    // JNC 0x1000:8741 (1000_8736 / 0x18736)
    if(!CarryFlag) {
      goto label_1000_8741_18741;
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_8738 / 0x18738)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP DI,word ptr [0x114e] (1000_873B / 0x1873B)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JNZ 0x1000:8750 (1000_873F / 0x1873F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8750 / 0x18750)
      return NearRet();
    }
    State.IncCycles();
    label_1000_8741_18741:
    // CMP AL,byte ptr [0x1954] (1000_8741 / 0x18741)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    State.IncCycles();
    // JZ 0x1000:874d (1000_8745 / 0x18745)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:7c02 (1000_874D / 0x1874D)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7C02_017C02, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV [0x1954],AL (1000_8747 / 0x18747)
    UInt8[DS, 0x1954] = AL;
    State.IncCycles();
    // JMP 0x1000:8685 (1000_874A / 0x1874A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8685_018685, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_874D_1874D:
    // JMP 0x1000:7c02 (1000_874D / 0x1874D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7C02_017C02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8750_18750:
    // RET  (1000_8750 / 0x18750)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8751_018751(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8751_18751:
    // CMP byte ptr [0x1954],0x0 (1000_8751 / 0x18751)
    Alu.Sub8(UInt8[DS, 0x1954], 0x0);
    State.IncCycles();
    // JZ 0x1000:878b (1000_8756 / 0x18756)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_878B / 0x1878B)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:69a3 (1000_8758 / 0x18758)
    NearCall(cs1, 0x875B, spice86_generated_label_call_target_1000_69A3_0169A3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_875B_01875B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_875B_01875B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_875B_1875B:
    // MOV byte ptr [0x1954],0x0 (1000_875B / 0x1875B)
    UInt8[DS, 0x1954] = 0x0;
    State.IncCycles();
    // JMP 0x1000:7b58 (1000_8760 / 0x18760)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B58_017B58, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8763_018763(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8763_18763:
    // CMP byte ptr [0x46f3],0x0 (1000_8763 / 0x18763)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x0);
    State.IncCycles();
    // JZ 0x1000:8770 (1000_8768 / 0x18768)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8770_018770, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:8770 (1000_876A / 0x1876A)
    NearCall(cs1, 0x876D, spice86_generated_label_call_target_1000_8770_018770);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_876D_01876D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_876D_01876D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_876D_1876D:
    // JMP 0x1000:186b (1000_876D / 0x1876D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_186B_01186B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8770_018770(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8770_18770:
    // CMP byte ptr [0x1954],0x0 (1000_8770 / 0x18770)
    Alu.Sub8(UInt8[DS, 0x1954], 0x0);
    State.IncCycles();
    // JZ 0x1000:878b (1000_8775 / 0x18775)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_878B / 0x1878B)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_8777 / 0x18777)
    NearCall(cs1, 0x877A, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_877A_01877A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_877A_01877A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_877A_1877A:
    // MOV byte ptr [0x46f3],0x0 (1000_877A / 0x1877A)
    UInt8[DS, 0x46F3] = 0x0;
    State.IncCycles();
    // CALL 0x1000:878c (1000_877F / 0x1877F)
    NearCall(cs1, 0x8782, spice86_generated_label_call_target_1000_878C_01878C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8782_018782, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8782_018782(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x878B: goto label_1000_878B_1878B;break; // Target of external jump from 0x18775
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_8782_18782:
    // MOV word ptr [0x1bea],0x0 (1000_8782 / 0x18782)
    UInt16[DS, 0x1BEA] = 0x0;
    State.IncCycles();
    // CALL 0x1000:e283 (1000_8788 / 0x18788)
    NearCall(cs1, 0x878B, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_878B_1878B:
    // RET  (1000_878B / 0x1878B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_878C_01878C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_878C_1878C:
    // MOV word ptr [0x47ba],0x0 (1000_878C / 0x1878C)
    UInt16[DS, 0x47BA] = 0x0;
    State.IncCycles();
    // MOV AX,0x40a7 (1000_8792 / 0x18792)
    AX = 0x40A7;
    State.IncCycles();
    // CMP byte ptr [0x8],0xff (1000_8795 / 0x18795)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    State.IncCycles();
    // JZ 0x1000:87c0 (1000_879A / 0x1879A)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_87B2_0187B2, 0x187C0 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x8],0x20 (1000_879C / 0x1879C)
    Alu.Sub8(UInt8[DS, 0x8], 0x20);
    State.IncCycles();
    // JC 0x1000:87aa (1000_87A1 / 0x187A1)
    if(CarryFlag) {
      goto label_1000_87AA_187AA;
    }
    State.IncCycles();
    // CMP byte ptr [0xb],0x3 (1000_87A3 / 0x187A3)
    Alu.Sub8(UInt8[DS, 0xB], 0x3);
    State.IncCycles();
    // JNC 0x1000:87c0 (1000_87A8 / 0x187A8)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_87B2_0187B2, 0x187C0 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_87AA_187AA:
    // PUSH DI (1000_87AA / 0x187AA)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_87AB / 0x187AB)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_87AF / 0x187AF)
    NearCall(cs1, 0x87B2, spice86_generated_label_call_target_1000_7F27_017F27);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_87B2_0187B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_87B2_0187B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_87B2_187B2:
    // POP DI (1000_87B2 / 0x187B2)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV AX,0xa7 (1000_87B3 / 0x187B3)
    AX = 0xA7;
    State.IncCycles();
    // CMP byte ptr [0x46ff],0x0 (1000_87B6 / 0x187B6)
    Alu.Sub8(UInt8[DS, 0x46FF], 0x0);
    State.IncCycles();
    // JNZ 0x1000:87c0 (1000_87BB / 0x187BB)
    if(!ZeroFlag) {
      goto label_1000_87C0_187C0;
    }
    State.IncCycles();
    // OR AH,0x40 (1000_87BD / 0x187BD)
    // AH |= 0x40;
    AH = Alu.Or8(AH, 0x40);
    State.IncCycles();
    label_1000_87C0_187C0:
    // MOV BP,0x20f2 (1000_87C0 / 0x187C0)
    BP = 0x20F2;
    State.IncCycles();
    // MOV word ptr [BP + 0xe],AX (1000_87C3 / 0x187C3)
    UInt16[SS, (ushort)(BP + 0xE)] = AX;
    State.IncCycles();
    // OR byte ptr [BP + 0xb],0x40 (1000_87C6 / 0x187C6)
    // UInt8[SS, (ushort)(BP + 0xB)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xB)], 0x40);
    State.IncCycles();
    // MOV word ptr [BP + 0x12],0x0 (1000_87CA / 0x187CA)
    UInt16[SS, (ushort)(BP + 0x12)] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x2a],0x5 (1000_87CF / 0x187CF)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5);
    State.IncCycles();
    // JC 0x1000:87df (1000_87D4 / 0x187D4)
    if(CarryFlag) {
      goto label_1000_87DF_187DF;
    }
    State.IncCycles();
    // AND byte ptr [BP + 0xb],0xbf (1000_87D6 / 0x187D6)
    // UInt8[SS, (ushort)(BP + 0xB)] &= 0xBF;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.And8(UInt8[SS, (ushort)(BP + 0xB)], 0xBF);
    State.IncCycles();
    // MOV word ptr [BP + 0x12],0x67 (1000_87DA / 0x187DA)
    UInt16[SS, (ushort)(BP + 0x12)] = 0x67;
    State.IncCycles();
    label_1000_87DF_187DF:
    // CMP word ptr [0x1176],0x2 (1000_87DF / 0x187DF)
    Alu.Sub16(UInt16[DS, 0x1176], 0x2);
    State.IncCycles();
    // JNC 0x1000:8806 (1000_87E4 / 0x187E4)
    if(!CarryFlag) {
      goto label_1000_8806_18806;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x6],0x4093 (1000_87E6 / 0x187E6)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x4093;
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_87EB / 0x187EB)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // OR DI,DI (1000_87EF / 0x187EF)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:8816 (1000_87F1 / 0x187F1)
    if(ZeroFlag) {
      goto label_1000_8816_18816;
    }
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_87F3 / 0x187F3)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    // OR AL,AL (1000_87F6 / 0x187F6)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:8816 (1000_87F8 / 0x187F8)
    if(ZeroFlag) {
      goto label_1000_8816_18816;
    }
    State.IncCycles();
    // CALL 0x1000:6906 (1000_87FA / 0x187FA)
    NearCall(cs1, 0x87FD, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    label_1000_87FD_187FD:
    // JNC 0x1000:8816 (1000_87FD / 0x187FD)
    if(!CarryFlag) {
      goto label_1000_8816_18816;
    }
    State.IncCycles();
    // AND word ptr [BP + 0x6],0xbfff (1000_87FF / 0x187FF)
    // UInt16[SS, (ushort)(BP + 0x6)] &= 0xBFFF;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu.And16(UInt16[SS, (ushort)(BP + 0x6)], 0xBFFF);
    State.IncCycles();
    // JMP 0x1000:8816 (1000_8804 / 0x18804)
    goto label_1000_8816_18816;
    State.IncCycles();
    label_1000_8806_18806:
    // MOV AX,0x62 (1000_8806 / 0x18806)
    AX = 0x62;
    State.IncCycles();
    // CMP word ptr [0x3cbe],0x0 (1000_8809 / 0x18809)
    Alu.Sub16(UInt16[DS, 0x3CBE], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8813 (1000_880E / 0x1880E)
    if(!ZeroFlag) {
      goto label_1000_8813_18813;
    }
    State.IncCycles();
    // OR AH,0x40 (1000_8810 / 0x18810)
    // AH |= 0x40;
    AH = Alu.Or8(AH, 0x40);
    State.IncCycles();
    label_1000_8813_18813:
    // MOV word ptr [BP + 0x6],AX (1000_8813 / 0x18813)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    State.IncCycles();
    label_1000_8816_18816:
    // MOV BX,0xf66 (1000_8816 / 0x18816)
    BX = 0xF66;
    State.IncCycles();
    // CALL 0x1000:d338 (1000_8819 / 0x18819)
    NearCall(cs1, 0x881C, spice86_generated_label_call_target_1000_D338_01D338);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_881C_01881C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_881C_01881C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_881C_1881C:
    // JMP 0x1000:c13b (1000_881C / 0x1881C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_882E_01882E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_882E_1882E:
    // MOV SI,0x1466 (1000_882E / 0x1882E)
    SI = 0x1466;
    State.IncCycles();
    // TEST AL,0x1 (1000_8831 / 0x18831)
    Alu.And8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:8857 (1000_8833 / 0x18833)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8857 / 0x18857)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_8835 / 0x18835)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNS 0x1000:8846 (1000_883A / 0x1883A)
    if(!SignFlag) {
      goto label_1000_8846_18846;
    }
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x40 (1000_883C / 0x1883C)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    State.IncCycles();
    // JNZ 0x1000:8858 (1000_8841 / 0x18841)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8857_018857, 0x18858 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:5beb (1000_8843 / 0x18843)
    NearCall(cs1, 0x8846, spice86_generated_label_call_target_1000_5BEB_015BEB);
    State.IncCycles();
    label_1000_8846_18846:
    // LODSW SI (1000_8846 / 0x18846)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD word ptr [0x197c],AX (1000_8847 / 0x18847)
    // UInt16[DS, 0x197C] += AX;
    UInt16[DS, 0x197C] = Alu.Add16(UInt16[DS, 0x197C], AX);
    State.IncCycles();
    // LODSW SI (1000_884B / 0x1884B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD word ptr [0x197e],AX (1000_884C / 0x1884C)
    // UInt16[DS, 0x197E] += AX;
    UInt16[DS, 0x197E] = Alu.Add16(UInt16[DS, 0x197E], AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8850_018850, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8850_018850(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8850_18850:
    // CALL 0x1000:7b36 (1000_8850 / 0x18850)
    NearCall(cs1, 0x8853, spice86_generated_label_call_target_1000_7B36_017B36);
    State.IncCycles();
    label_1000_8853_18853:
    // CALL word ptr [0x46ed] (1000_8853 / 0x18853)
    // Indirect call to word ptr [0x46ed], generating possible targets from emulator records
    uint targetAddress_1000_8853 = (uint)(UInt16[DS, 0x46ED]);
    switch(targetAddress_1000_8853) {
      case 0x5A9A : NearCall(cs1, 0x8857, spice86_generated_label_call_target_1000_5A9A_015A9A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8853));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8857_018857, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8857_018857(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8857_18857:
    // RET  (1000_8857 / 0x18857)
    return NearRet();
    State.IncCycles();
    label_1000_8858_18858:
    // LODSW SI (1000_8858 / 0x18858)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD word ptr [0x1980],AX (1000_8859 / 0x18859)
    // UInt16[DS, 0x1980] += AX;
    UInt16[DS, 0x1980] = Alu.Add16(UInt16[DS, 0x1980], AX);
    State.IncCycles();
    // LODSW SI (1000_885D / 0x1885D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD word ptr [0x1982],AX (1000_885E / 0x1885E)
    // UInt16[DS, 0x1982] += AX;
    UInt16[DS, 0x1982] = Alu.Add16(UInt16[DS, 0x1982], AX);
    State.IncCycles();
    // JMP 0x1000:542f (1000_8862 / 0x18862)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_542F_01542F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8865_018865(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8865_18865:
    // CALL 0x1000:e270 (1000_8865 / 0x18865)
    NearCall(cs1, 0x8868, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_8868_18868:
    // MOV SI,AX (1000_8868 / 0x18868)
    SI = AX;
    State.IncCycles();
    // MOV word ptr [0xdbe4],CX (1000_886A / 0x1886A)
    UInt16[DS, 0xDBE4] = CX;
    State.IncCycles();
    // CALL 0x1000:d04e (1000_886E / 0x1886E)
    NearCall(cs1, 0x8871, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8871_018871, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8871_018871(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8871_18871:
    // CALL 0x1000:cf70 (1000_8871 / 0x18871)
    NearCall(cs1, 0x8874, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_8874_18874:
    // CALL 0x1000:88f1 (1000_8874 / 0x18874)
    NearCall(cs1, 0x8877, spice86_generated_label_call_target_1000_88F1_0188F1);
    State.IncCycles();
    label_1000_8877_18877:
    // MOV DI,0xa6b0 (1000_8877 / 0x18877)
    DI = 0xA6B0;
    State.IncCycles();
    // PUSH DI (1000_887A / 0x1887A)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:8944 (1000_887B / 0x1887B)
    NearCall(cs1, 0x887E, spice86_generated_label_call_target_1000_8944_018944);
    State.IncCycles();
    label_1000_887E_1887E:
    // POP SI (1000_887E / 0x1887E)
    SI = Stack.Pop();
    State.IncCycles();
    // PUSH DS (1000_887F / 0x1887F)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_8880 / 0x18880)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:d1bb (1000_8881 / 0x18881)
    NearCall(cs1, 0x8884, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    State.IncCycles();
    label_1000_8884_18884:
    // CALL 0x1000:e283 (1000_8884 / 0x18884)
    NearCall(cs1, 0x8887, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_8887_18887:
    // RET  (1000_8887 / 0x18887)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8888_018888(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8888_18888:
    // CMP byte ptr [0x46d9],0x0 (1000_8888 / 0x18888)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:88e1 (1000_888D / 0x1888D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_88E1_0188E1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr [0x479e],0x1 (1000_888F / 0x1888F)
    UInt16[DS, 0x479E] = 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8895_018895, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8895_018895(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8895_18895:
    // MOV AL,[0xfb] (1000_8895 / 0x18895)
    AL = UInt8[DS, 0xFB];
    State.IncCycles();
    // NOT AL (1000_8898 / 0x18898)
    AL = (byte)~AL;
    State.IncCycles();
    // AND AL,0x80 (1000_889A / 0x1889A)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    State.IncCycles();
    // MOV [0x1c06],AL (1000_889C / 0x1889C)
    UInt8[DS, 0x1C06] = AL;
    State.IncCycles();
    // PUSH DS (1000_889F / 0x1889F)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_88A0 / 0x188A0)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x1be2 (1000_88A1 / 0x188A1)
    DI = 0x1BE2;
    State.IncCycles();
    // XOR AX,AX (1000_88A4 / 0x188A4)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_88A6 / 0x188A6)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_88A7 / 0x188A7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_88A8 / 0x188A8)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_88A9 / 0x188A9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,0x80 (1000_88AA / 0x188AA)
    AL = 0x80;
    State.IncCycles();
    // STOSW ES:DI (1000_88AC / 0x188AC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // RET  (1000_88AD / 0x188AD)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_88AE_0188AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88AE_188AE:
    // RET  (1000_88AE / 0x188AE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_88AF_0188AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88AF_188AF:
    // OR AX,AX (1000_88AF / 0x188AF)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:88ae (1000_88B1 / 0x188B1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_88AE / 0x188AE)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0x4780],AX (1000_88B3 / 0x188B3)
    UInt16[DS, 0x4780] = AX;
    State.IncCycles();
    // MOV byte ptr [0x47e0],0x0 (1000_88B6 / 0x188B6)
    UInt8[DS, 0x47E0] = 0x0;
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x40 (1000_88BB / 0x188BB)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    State.IncCycles();
    // JZ 0x1000:88ca (1000_88C0 / 0x188C0)
    if(ZeroFlag) {
      goto label_1000_88CA_188CA;
    }
    State.IncCycles();
    // AND byte ptr [0x46eb],0xbf (1000_88C2 / 0x188C2)
    // UInt8[DS, 0x46EB] &= 0xBF;
    UInt8[DS, 0x46EB] = Alu.And8(UInt8[DS, 0x46EB], 0xBF);
    State.IncCycles();
    // JMP 0x1000:80df (1000_88C7 / 0x188C7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_80DF_0180DF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_88CA_188CA:
    // MOV SI,AX (1000_88CA / 0x188CA)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_88CC / 0x188CC)
    NearCall(cs1, 0x88CF, spice86_generated_label_call_target_1000_CF70_01CF70);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_88CF_0188CF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_88CF_0188CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88CF_188CF:
    // CALL 0x1000:88f1 (1000_88CF / 0x188CF)
    NearCall(cs1, 0x88D2, spice86_generated_label_call_target_1000_88F1_0188F1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_88D2_0188D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_88D2_0188D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88D2_188D2:
    // MOV DI,0xa6b0 (1000_88D2 / 0x188D2)
    DI = 0xA6B0;
    State.IncCycles();
    // PUSH DI (1000_88D5 / 0x188D5)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:8944 (1000_88D6 / 0x188D6)
    NearCall(cs1, 0x88D9, spice86_generated_label_call_target_1000_8944_018944);
    State.IncCycles();
    label_1000_88D9_188D9:
    // POP SI (1000_88D9 / 0x188D9)
    SI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [0x28e7],0x2 (1000_88DA / 0x188DA)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x2);
    State.IncCycles();
    // JNC 0x1000:8888 (1000_88DF / 0x188DF)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_8888_018888, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_88E1_0188E1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_88E1_0188E1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88E1_188E1:
    // LODSB SI (1000_88E1 / 0x188E1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_88E2 / 0x188E2)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:88f0 (1000_88E4 / 0x188E4)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_88F0 / 0x188F0)
      return NearRet();
    }
    State.IncCycles();
    // DEC SI (1000_88E6 / 0x188E6)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // CALL 0x1000:8b11 (1000_88E7 / 0x188E7)
    NearCall(cs1, 0x88EA, spice86_generated_label_call_target_1000_8B11_018B11);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_88EA_0188EA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_88EA_0188EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88EA_188EA:
    // CMP byte ptr [SI],0xfe (1000_88EA / 0x188EA)
    Alu.Sub8(UInt8[DS, SI], 0xFE);
    State.IncCycles();
    // JNC 0x1000:88f0 (1000_88ED / 0x188ED)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_88F0 / 0x188F0)
      return NearRet();
    }
    State.IncCycles();
    // NOP  (1000_88EF / 0x188EF)
    
    State.IncCycles();
    label_1000_88F0_188F0:
    // RET  (1000_88F0 / 0x188F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_88F1_0188F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_88F1_188F1:
    // PUSH DS (1000_88F1 / 0x188F1)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_88F2 / 0x188F2)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_88F3 / 0x188F3)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (1000_88F4 / 0x188F4)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0xa840 (1000_88F5 / 0x188F5)
    DI = 0xA840;
    State.IncCycles();
    label_1000_88F8_188F8:
    // LODSB SI (1000_88F8 / 0x188F8)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0xff (1000_88F9 / 0x188F9)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:893d (1000_88FB / 0x188FB)
    if(ZeroFlag) {
      goto label_1000_893D_1893D;
    }
    State.IncCycles();
    // CMP AL,0xfe (1000_88FD / 0x188FD)
    Alu.Sub8(AL, 0xFE);
    State.IncCycles();
    // JZ 0x1000:8905 (1000_88FF / 0x188FF)
    if(ZeroFlag) {
      goto label_1000_8905_18905;
    }
    State.IncCycles();
    // CMP AL,0xe0 (1000_8901 / 0x18901)
    Alu.Sub8(AL, 0xE0);
    State.IncCycles();
    // JNC 0x1000:8910 (1000_8903 / 0x18903)
    if(!CarryFlag) {
      goto label_1000_8910_18910;
    }
    State.IncCycles();
    label_1000_8905_18905:
    // STOSB ES:DI (1000_8905 / 0x18905)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,0xff (1000_8906 / 0x18906)
    AL = 0xFF;
    State.IncCycles();
    // CMP DI,0xa9cf (1000_8908 / 0x18908)
    Alu.Sub16(DI, 0xA9CF);
    State.IncCycles();
    // JNC 0x1000:893d (1000_890C / 0x1890C)
    if(!CarryFlag) {
      goto label_1000_893D_1893D;
    }
    State.IncCycles();
    // JMP 0x1000:88f8 (1000_890E / 0x1890E)
    goto label_1000_88F8_188F8;
    State.IncCycles();
    label_1000_8910_18910:
    // AND AL,0xf (1000_8910 / 0x18910)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // MOV CH,AL (1000_8912 / 0x18912)
    CH = AL;
    State.IncCycles();
    // LODSW SI (1000_8914 / 0x18914)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CL,AH (1000_8915 / 0x18915)
    CL = AH;
    State.IncCycles();
    // AND AX,0x3fff (1000_8917 / 0x18917)
    AX &= 0x3FFF;
    State.IncCycles();
    // SHR CL,1 (1000_891A / 0x1891A)
    CL >>= 0x1;
    State.IncCycles();
    // SHR CL,1 (1000_891C / 0x1891C)
    CL >>= 0x1;
    State.IncCycles();
    // AND CL,0x30 (1000_891E / 0x1891E)
    // CL &= 0x30;
    CL = Alu.And8(CL, 0x30);
    State.IncCycles();
    // OR CL,CH (1000_8921 / 0x18921)
    CL |= CH;
    State.IncCycles();
    // XOR CH,CH (1000_8923 / 0x18923)
    CH = 0;
    State.IncCycles();
    // PUSH SI (1000_8925 / 0x18925)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,word ptr SS:[0x47b4] (1000_8926 / 0x18926)
    SI = UInt16[SS, 0x47B4];
    State.IncCycles();
    // ADD SI,AX (1000_892B / 0x1892B)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_892D / 0x1892D)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP SI (1000_892F / 0x1892F)
    SI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [SI],0xff (1000_8930 / 0x18930)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    State.IncCycles();
    // JZ 0x1000:893c (1000_8933 / 0x18933)
    if(ZeroFlag) {
      goto label_1000_893C_1893C;
    }
    State.IncCycles();
    // MOV byte ptr ES:[DI],0x20 (1000_8935 / 0x18935)
    UInt8[ES, DI] = 0x20;
    State.IncCycles();
    // INC DI (1000_8939 / 0x18939)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // JMP 0x1000:88f8 (1000_893A / 0x1893A)
    goto label_1000_88F8_188F8;
    State.IncCycles();
    label_1000_893C_1893C:
    // LODSB SI (1000_893C / 0x1893C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_893D_1893D:
    // STOSB ES:DI (1000_893D / 0x1893D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV SI,0xa840 (1000_893E / 0x1893E)
    SI = 0xA840;
    State.IncCycles();
    // PUSH SS (1000_8941 / 0x18941)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_8942 / 0x18942)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8943 / 0x18943)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8944_018944(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8944_18944:
    // SUB SP,0x32 (1000_8944 / 0x18944)
    // SP -= 0x32;
    SP = Alu.Sub16(SP, 0x32);
    State.IncCycles();
    // MOV BP,SP (1000_8947 / 0x18947)
    BP = SP;
    State.IncCycles();
    // PUSH DS (1000_8949 / 0x18949)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_894A / 0x1894A)
    ES = Stack.Pop();
    State.IncCycles();
    label_1000_894B_1894B:
    // CMP byte ptr [SI],0x20 (1000_894B / 0x1894B)
    Alu.Sub8(UInt8[DS, SI], 0x20);
    State.IncCycles();
    // JNZ 0x1000:8953 (1000_894E / 0x1894E)
    if(!ZeroFlag) {
      goto label_1000_8953_18953;
    }
    State.IncCycles();
    // INC SI (1000_8950 / 0x18950)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // JMP 0x1000:894b (1000_8951 / 0x18951)
    goto label_1000_894B_1894B;
    State.IncCycles();
    label_1000_8953_18953:
    // LODSB SI (1000_8953 / 0x18953)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_8954 / 0x18954)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:895b (1000_8956 / 0x18956)
    if(SignFlag) {
      goto label_1000_895B_1895B;
    }
    State.IncCycles();
    // STOSB ES:DI (1000_8958 / 0x18958)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // JMP 0x1000:8953 (1000_8959 / 0x18959)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_895B_1895B:
    // MOV [0x477f],AL (1000_895B / 0x1895B)
    UInt8[DS, 0x477F] = AL;
    State.IncCycles();
    // CMP AL,0xf0 (1000_895E / 0x1895E)
    Alu.Sub8(AL, 0xF0);
    State.IncCycles();
    // JNC 0x1000:89b0 (1000_8960 / 0x18960)
    if(!CarryFlag) {
      goto label_1000_89B0_189B0;
    }
    State.IncCycles();
    // CMP AL,0xd0 (1000_8962 / 0x18962)
    Alu.Sub8(AL, 0xD0);
    State.IncCycles();
    // JNC 0x1000:899b (1000_8964 / 0x18964)
    if(!CarryFlag) {
      goto label_1000_899B_1899B;
    }
    State.IncCycles();
    // CMP AL,0xa0 (1000_8966 / 0x18966)
    Alu.Sub8(AL, 0xA0);
    State.IncCycles();
    // JNC 0x1000:89ad (1000_8968 / 0x18968)
    if(!CarryFlag) {
      goto label_1000_89AD_189AD;
    }
    State.IncCycles();
    // CMP AL,0x90 (1000_896A / 0x1896A)
    Alu.Sub8(AL, 0x90);
    State.IncCycles();
    // JC 0x1000:8970 (1000_896C / 0x1896C)
    if(CarryFlag) {
      goto label_1000_8970_18970;
    }
    State.IncCycles();
    // JMP 0x1000:89e4 (1000_896E / 0x1896E)
    goto label_1000_89E4_189E4;
    State.IncCycles();
    label_1000_8970_18970:
    // CMP AL,0x80 (1000_8970 / 0x18970)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:8979 (1000_8972 / 0x18972)
    if(!ZeroFlag) {
      goto label_1000_8979_18979;
    }
    State.IncCycles();
    // LODSW SI (1000_8974 / 0x18974)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AL,AH (1000_8975 / 0x18975)
    byte tmp_1000_8975 = AL;
    AL = AH;
    AH = tmp_1000_8975;
    State.IncCycles();
    // JMP 0x1000:8984 (1000_8977 / 0x18977)
    goto label_1000_8984_18984;
    State.IncCycles();
    label_1000_8979_18979:
    // AND AX,0xf (1000_8979 / 0x18979)
    AX &= 0xF;
    State.IncCycles();
    // SHL AX,1 (1000_897C / 0x1897C)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BX,AX (1000_897E / 0x1897E)
    BX = AX;
    State.IncCycles();
    // MOV AX,word ptr [BX + 0x11eb] (1000_8980 / 0x18980)
    AX = UInt16[DS, (ushort)(BX + 0x11EB)];
    State.IncCycles();
    label_1000_8984_18984:
    // MOV word ptr [BP + 0x0],SI (1000_8984 / 0x18984)
    UInt16[SS, BP] = SI;
    State.IncCycles();
    // MOV word ptr [BP + 0x2],DS (1000_8987 / 0x18987)
    UInt16[SS, (ushort)(BP + 0x2)] = DS;
    State.IncCycles();
    // ADD BP,0x4 (1000_898A / 0x1898A)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    State.IncCycles();
    // MOV SI,AX (1000_898D / 0x1898D)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:8a3b (1000_898F / 0x1898F)
    NearCall(cs1, 0x8992, spice86_generated_label_call_target_1000_8A3B_018A3B);
    State.IncCycles();
    label_1000_8992_18992:
    // PUSH ES (1000_8992 / 0x18992)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_8993 / 0x18993)
    NearCall(cs1, 0x8996, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_8996_18996:
    // PUSH ES (1000_8996 / 0x18996)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_8997 / 0x18997)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (1000_8998 / 0x18998)
    ES = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:8953 (1000_8999 / 0x18999)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_899B_1899B:
    // STOSB ES:DI (1000_899B / 0x1899B)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOVSB ES:DI,SI (1000_899C / 0x1899C)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP AL,0xd2 (1000_899D / 0x1899D)
    Alu.Sub8(AL, 0xD2);
    State.IncCycles();
    // JC 0x1000:89a3 (1000_899F / 0x1899F)
    if(CarryFlag) {
      goto label_1000_89A3_189A3;
    }
    State.IncCycles();
    // JMP 0x1000:8953 (1000_89A1 / 0x189A1)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_89A3_189A3:
    // MOVSB ES:DI,SI (1000_89A3 / 0x189A3)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP AL,0xd0 (1000_89A4 / 0x189A4)
    Alu.Sub8(AL, 0xD0);
    State.IncCycles();
    // JNZ 0x1000:89aa (1000_89A6 / 0x189A6)
    if(!ZeroFlag) {
      goto label_1000_89AA_189AA;
    }
    State.IncCycles();
    // JMP 0x1000:8953 (1000_89A8 / 0x189A8)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_89AA_189AA:
    // MOVSW ES:DI,SI (1000_89AA / 0x189AA)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JMP 0x1000:8953 (1000_89AB / 0x189AB)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_89AD_189AD:
    // STOSB ES:DI (1000_89AD / 0x189AD)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // JMP 0x1000:8953 (1000_89AE / 0x189AE)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_89B0_189B0:
    // MOV BX,SP (1000_89B0 / 0x189B0)
    BX = SP;
    State.IncCycles();
    // CMP BP,BX (1000_89B2 / 0x189B2)
    Alu.Sub16(BP, BX);
    State.IncCycles();
    // JZ 0x1000:89c1 (1000_89B4 / 0x189B4)
    if(ZeroFlag) {
      goto label_1000_89C1_189C1;
    }
    State.IncCycles();
    // SUB BP,0x4 (1000_89B6 / 0x189B6)
    // BP -= 0x4;
    BP = Alu.Sub16(BP, 0x4);
    State.IncCycles();
    // MOV SI,word ptr [BP + 0x0] (1000_89B9 / 0x189B9)
    SI = UInt16[SS, BP];
    State.IncCycles();
    // MOV DS,word ptr [BP + 0x2] (1000_89BC / 0x189BC)
    DS = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // JMP 0x1000:8953 (1000_89BF / 0x189BF)
    goto label_1000_8953_18953;
    State.IncCycles();
    label_1000_89C1_189C1:
    // STOSB ES:DI (1000_89C1 / 0x189C1)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP AL,0xff (1000_89C2 / 0x189C2)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JNZ 0x1000:89c8 (1000_89C4 / 0x189C4)
    if(!ZeroFlag) {
      goto label_1000_89C8_189C8;
    }
    State.IncCycles();
    // XOR SI,SI (1000_89C6 / 0x189C6)
    SI = 0;
    State.IncCycles();
    label_1000_89C8_189C8:
    // MOV word ptr [0x47b6],SI (1000_89C8 / 0x189C8)
    UInt16[DS, 0x47B6] = SI;
    State.IncCycles();
    // MOV word ptr [0x47b8],DS (1000_89CC / 0x189CC)
    UInt16[DS, 0x47B8] = DS;
    State.IncCycles();
    // ADD SP,0x32 (1000_89D0 / 0x189D0)
    SP += 0x32;
    State.IncCycles();
    // TEST byte ptr [0x47de],0x10 (1000_89D3 / 0x189D3)
    Alu.And8(UInt8[DS, 0x47DE], 0x10);
    State.IncCycles();
    // JZ 0x1000:89e3 (1000_89D8 / 0x189D8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_89E3 / 0x189E3)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,0x3 (1000_89DA / 0x189DA)
    BX = 0x3;
    State.IncCycles();
    // CALL 0x1000:e3b7 (1000_89DD / 0x189DD)
    NearCall(cs1, 0x89E0, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    label_1000_89E0_189E0:
    // CALL 0x1000:8ac3 (1000_89E0 / 0x189E0)
    NearCall(cs1, 0x89E3, spice86_generated_label_call_target_1000_8AC3_018AC3);
    State.IncCycles();
    label_1000_89E3_189E3:
    // RET  (1000_89E3 / 0x189E3)
    return NearRet();
    State.IncCycles();
    label_1000_89E4_189E4:
    // PUSH BP (1000_89E4 / 0x189E4)
    Stack.Push(BP);
    State.IncCycles();
    // MOV BL,AL (1000_89E5 / 0x189E5)
    BL = AL;
    State.IncCycles();
    // LODSB SI (1000_89E7 / 0x189E7)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_89E8 / 0x189E8)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_89EA / 0x189EA)
    BP = AX;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (1000_89EC / 0x189EC)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // CMP BL,0x92 (1000_89F0 / 0x189F0)
    Alu.Sub8(BL, 0x92);
    State.IncCycles();
    // JZ 0x1000:89f7 (1000_89F3 / 0x189F3)
    if(ZeroFlag) {
      goto label_1000_89F7_189F7;
    }
    State.IncCycles();
    // XOR AH,AH (1000_89F5 / 0x189F5)
    AH = 0;
    State.IncCycles();
    label_1000_89F7_189F7:
    // PUSH AX (1000_89F7 / 0x189F7)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:8acc (1000_89F8 / 0x189F8)
    NearCall(cs1, 0x89FB, spice86_generated_label_call_target_1000_8ACC_018ACC);
    State.IncCycles();
    label_1000_89FB_189FB:
    // POP AX (1000_89FB / 0x189FB)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:8a23 (1000_89FC / 0x189FC)
    NearCall(cs1, 0x89FF, spice86_generated_label_call_target_1000_8A23_018A23);
    State.IncCycles();
    label_1000_89FF_189FF:
    // XCHG AX,BX (1000_89FF / 0x189FF)
    ushort tmp_1000_89FF = AX;
    AX = BX;
    BX = tmp_1000_89FF;
    State.IncCycles();
    // MOV CX,0x5 (1000_8A00 / 0x18A00)
    CX = 0x5;
    State.IncCycles();
    // JMP 0x1000:8a0d (1000_8A03 / 0x18A03)
    goto label_1000_8A0D_18A0D;
    State.IncCycles();
    label_1000_8A05_18A05:
    // MOV AL,DH (1000_8A05 / 0x18A05)
    AL = DH;
    State.IncCycles();
    // MOV DH,DL (1000_8A07 / 0x18A07)
    DH = DL;
    State.IncCycles();
    // MOV DL,BH (1000_8A09 / 0x18A09)
    DL = BH;
    State.IncCycles();
    // MOV BH,BL (1000_8A0B / 0x18A0B)
    BH = BL;
    State.IncCycles();
    label_1000_8A0D_18A0D:
    // OR AL,AL (1000_8A0D / 0x18A0D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // LOOPZ 0x1000:8a05 (1000_8A0F / 0x18A0F)
    if(--CX != 0 && ZeroFlag) {
      goto label_1000_8A05_18A05;
    }
    State.IncCycles();
    // INC CX (1000_8A11 / 0x18A11)
    CX++;
    State.IncCycles();
    label_1000_8A12_18A12:
    // ADD AL,0x30 (1000_8A12 / 0x18A12)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    State.IncCycles();
    // STOSB ES:DI (1000_8A14 / 0x18A14)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,DH (1000_8A15 / 0x18A15)
    AL = DH;
    State.IncCycles();
    // MOV DH,DL (1000_8A17 / 0x18A17)
    DH = DL;
    State.IncCycles();
    // MOV DL,BH (1000_8A19 / 0x18A19)
    DL = BH;
    State.IncCycles();
    // MOV BH,BL (1000_8A1B / 0x18A1B)
    BH = BL;
    State.IncCycles();
    // LOOP 0x1000:8a12 (1000_8A1D / 0x18A1D)
    if(--CX != 0) {
      goto label_1000_8A12_18A12;
    }
    State.IncCycles();
    // POP BP (1000_8A1F / 0x18A1F)
    BP = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:8953 (1000_8A20 / 0x18A20)
    goto label_1000_8953_18953;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8A23_018A23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8A23_18A23:
    // XOR DX,DX (1000_8A23 / 0x18A23)
    DX = 0;
    State.IncCycles();
    // MOV CX,0x2710 (1000_8A25 / 0x18A25)
    CX = 0x2710;
    State.IncCycles();
    // DIV CX (1000_8A28 / 0x18A28)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV BL,AL (1000_8A2A / 0x18A2A)
    BL = AL;
    State.IncCycles();
    // MOV CX,0x64 (1000_8A2C / 0x18A2C)
    CX = 0x64;
    State.IncCycles();
    // MOV AX,DX (1000_8A2F / 0x18A2F)
    AX = DX;
    State.IncCycles();
    // XOR DX,DX (1000_8A31 / 0x18A31)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_8A33 / 0x18A33)
    Cpu.Div16(CX);
    State.IncCycles();
    // AAM 0xa (1000_8A35 / 0x18A35)
    Cpu.Aam(0xA);
    State.IncCycles();
    // XCHG AX,DX (1000_8A37 / 0x18A37)
    ushort tmp_1000_8A37 = AX;
    AX = DX;
    DX = tmp_1000_8A37;
    State.IncCycles();
    // AAM 0xa (1000_8A38 / 0x18A38)
    Cpu.Aam(0xA);
    State.IncCycles();
    // RET  (1000_8A3A / 0x18A3A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8A3B_018A3B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8AC1: goto label_1000_8AC1_18AC1;break; // Target of external jump from 0x18AB5, 0x18AEF, 0x18A8E
      case 0x8AC2: goto label_1000_8AC2_18AC2;break; // Target of external jump from 0x18AD2
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_8A3B_18A3B:
    // TEST byte ptr [0x47de],0x10 (1000_8A3B / 0x18A3B)
    Alu.And8(UInt8[DS, 0x47DE], 0x10);
    State.IncCycles();
    // JNZ 0x1000:8a43 (1000_8A40 / 0x18A40)
    if(!ZeroFlag) {
      goto label_1000_8A43_18A43;
    }
    State.IncCycles();
    // RET  (1000_8A42 / 0x18A42)
    return NearRet();
    State.IncCycles();
    label_1000_8A43_18A43:
    // PUSH BX (1000_8A43 / 0x18A43)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BH,byte ptr [0x477f] (1000_8A44 / 0x18A44)
    BH = UInt8[DS, 0x477F];
    State.IncCycles();
    // CMP BH,0x8b (1000_8A48 / 0x18A48)
    Alu.Sub8(BH, 0x8B);
    State.IncCycles();
    // JNZ 0x1000:8a52 (1000_8A4B / 0x18A4B)
    if(!ZeroFlag) {
      goto label_1000_8A52_18A52;
    }
    State.IncCycles();
    // SUB AX,0x108 (1000_8A4D / 0x18A4D)
    // AX -= 0x108;
    AX = Alu.Sub16(AX, 0x108);
    State.IncCycles();
    // JMP 0x1000:8abe (1000_8A50 / 0x18A50)
    goto label_1000_8ABE_18ABE;
    State.IncCycles();
    label_1000_8A52_18A52:
    // CMP BH,0x84 (1000_8A52 / 0x18A52)
    Alu.Sub8(BH, 0x84);
    State.IncCycles();
    // JNZ 0x1000:8a69 (1000_8A55 / 0x18A55)
    if(!ZeroFlag) {
      goto label_1000_8A69_18A69;
    }
    State.IncCycles();
    // SUB AX,0x48 (1000_8A57 / 0x18A57)
    // AX -= 0x48;
    AX = Alu.Sub16(AX, 0x48);
    State.IncCycles();
    // JZ 0x1000:8abe (1000_8A5A / 0x18A5A)
    if(ZeroFlag) {
      goto label_1000_8ABE_18ABE;
    }
    State.IncCycles();
    // DEC AX (1000_8A5C / 0x18A5C)
    AX--;
    State.IncCycles();
    // CMP AL,0x3 (1000_8A5D / 0x18A5D)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JC 0x1000:8abe (1000_8A5F / 0x18A5F)
    if(CarryFlag) {
      goto label_1000_8ABE_18ABE;
    }
    State.IncCycles();
    // SUB AX,0xffcf (1000_8A61 / 0x18A61)
    AX -= 0xFFCF;
    State.IncCycles();
    // CMP AX,0xc (1000_8A64 / 0x18A64)
    Alu.Sub16(AX, 0xC);
    State.IncCycles();
    // JMP 0x1000:8abc (1000_8A67 / 0x18A67)
    goto label_1000_8ABC_18ABC;
    State.IncCycles();
    label_1000_8A69_18A69:
    // CMP BH,0x83 (1000_8A69 / 0x18A69)
    Alu.Sub8(BH, 0x83);
    State.IncCycles();
    // JZ 0x1000:8a71 (1000_8A6C / 0x18A6C)
    if(ZeroFlag) {
      goto label_1000_8A71_18A71;
    }
    State.IncCycles();
    // CMP BH,0x8c (1000_8A6E / 0x18A6E)
    Alu.Sub8(BH, 0x8C);
    State.IncCycles();
    label_1000_8A71_18A71:
    // JNZ 0x1000:8a7a (1000_8A71 / 0x18A71)
    if(!ZeroFlag) {
      goto label_1000_8A7A_18A7A;
    }
    State.IncCycles();
    // SUB AX,0xe8 (1000_8A73 / 0x18A73)
    AX -= 0xE8;
    State.IncCycles();
    // CMP AL,0x7 (1000_8A76 / 0x18A76)
    Alu.Sub8(AL, 0x7);
    State.IncCycles();
    // JMP 0x1000:8abc (1000_8A78 / 0x18A78)
    goto label_1000_8ABC_18ABC;
    State.IncCycles();
    label_1000_8A7A_18A7A:
    // MOV BL,BH (1000_8A7A / 0x18A7A)
    BL = BH;
    State.IncCycles();
    // SUB BL,0x86 (1000_8A7C / 0x18A7C)
    BL -= 0x86;
    State.IncCycles();
    // CMP BL,0x3 (1000_8A7F / 0x18A7F)
    Alu.Sub8(BL, 0x3);
    State.IncCycles();
    // JNC 0x1000:8a97 (1000_8A82 / 0x18A82)
    if(!CarryFlag) {
      goto label_1000_8A97_18A97;
    }
    State.IncCycles();
    // MOV BL,byte ptr [0x47de] (1000_8A84 / 0x18A84)
    BL = UInt8[DS, 0x47DE];
    State.IncCycles();
    // AND BL,0xf (1000_8A88 / 0x18A88)
    BL &= 0xF;
    State.IncCycles();
    // CMP BL,0x1 (1000_8A8B / 0x18A8B)
    Alu.Sub8(BL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:8ac1 (1000_8A8E / 0x18A8E)
    if(!ZeroFlag) {
      goto label_1000_8AC1_18AC1;
    }
    State.IncCycles();
    // SUB AX,0xd1 (1000_8A90 / 0x18A90)
    AX -= 0xD1;
    State.IncCycles();
    // CMP AL,0x7 (1000_8A93 / 0x18A93)
    Alu.Sub8(AL, 0x7);
    State.IncCycles();
    // JMP 0x1000:8abc (1000_8A95 / 0x18A95)
    goto label_1000_8ABC_18ABC;
    State.IncCycles();
    label_1000_8A97_18A97:
    // CMP BH,0x85 (1000_8A97 / 0x18A97)
    Alu.Sub8(BH, 0x85);
    State.IncCycles();
    // JNZ 0x1000:8ab2 (1000_8A9A / 0x18A9A)
    if(!ZeroFlag) {
      goto label_1000_8AB2_18AB2;
    }
    State.IncCycles();
    // MOV BL,byte ptr [0x47de] (1000_8A9C / 0x18A9C)
    BL = UInt8[DS, 0x47DE];
    State.IncCycles();
    // AND BL,0xf (1000_8AA0 / 0x18AA0)
    BL &= 0xF;
    State.IncCycles();
    // CMP BL,0x1 (1000_8AA3 / 0x18AA3)
    Alu.Sub8(BL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:8ac1 (1000_8AA6 / 0x18AA6)
    if(!ZeroFlag) {
      goto label_1000_8AC1_18AC1;
    }
    State.IncCycles();
    // CMP AX,0x74 (1000_8AA8 / 0x18AA8)
    Alu.Sub16(AX, 0x74);
    State.IncCycles();
    // MOV AL,0x0 (1000_8AAB / 0x18AAB)
    AL = 0x0;
    State.IncCycles();
    // JNZ 0x1000:8abe (1000_8AAD / 0x18AAD)
    if(!ZeroFlag) {
      goto label_1000_8ABE_18ABE;
    }
    State.IncCycles();
    // INC AX (1000_8AAF / 0x18AAF)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JMP 0x1000:8abe (1000_8AB0 / 0x18AB0)
    goto label_1000_8ABE_18ABE;
    State.IncCycles();
    label_1000_8AB2_18AB2:
    // CMP BH,0x89 (1000_8AB2 / 0x18AB2)
    Alu.Sub8(BH, 0x89);
    State.IncCycles();
    // JNZ 0x1000:8ac1 (1000_8AB5 / 0x18AB5)
    if(!ZeroFlag) {
      goto label_1000_8AC1_18AC1;
    }
    State.IncCycles();
    // SUB AX,0xda (1000_8AB7 / 0x18AB7)
    AX -= 0xDA;
    State.IncCycles();
    // CMP AL,0x8 (1000_8ABA / 0x18ABA)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    label_1000_8ABC_18ABC:
    // JNC 0x1000:8ac1 (1000_8ABC / 0x18ABC)
    if(!CarryFlag) {
      goto label_1000_8AC1_18AC1;
    }
    State.IncCycles();
    label_1000_8ABE_18ABE:
    // CALL 0x1000:8ac3 (1000_8ABE / 0x18ABE)
    NearCall(cs1, 0x8AC1, spice86_generated_label_call_target_1000_8AC3_018AC3);
    State.IncCycles();
    label_1000_8AC1_18AC1:
    // POP BX (1000_8AC1 / 0x18AC1)
    BX = Stack.Pop();
    State.IncCycles();
    label_1000_8AC2_18AC2:
    // RET  (1000_8AC2 / 0x18AC2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8AC3_018AC3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8AC3_18AC3:
    // MOV [0x47e0],AL (1000_8AC3 / 0x18AC3)
    UInt8[DS, 0x47E0] = AL;
    State.IncCycles();
    // AND byte ptr [0x47de],0xef (1000_8AC6 / 0x18AC6)
    // UInt8[DS, 0x47DE] &= 0xEF;
    UInt8[DS, 0x47DE] = Alu.And8(UInt8[DS, 0x47DE], 0xEF);
    State.IncCycles();
    // RET  (1000_8ACB / 0x18ACB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8ACC_018ACC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8ACC_18ACC:
    // TEST byte ptr SS:[0x47de],0x10 (1000_8ACC / 0x18ACC)
    Alu.And8(UInt8[SS, 0x47DE], 0x10);
    State.IncCycles();
    // JZ 0x1000:8ac2 (1000_8AD2 / 0x18AD2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8AC2 / 0x18AC2)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_8AD4 / 0x18AD4)
    Stack.Push(BX);
    State.IncCycles();
    // LEA BP,[BP + 0x0] (1000_8AD5 / 0x18AD5)
    BP = BP;
    State.IncCycles();
    // CMP BP,0xcf (1000_8AD9 / 0x18AD9)
    Alu.Sub16(BP, 0xCF);
    State.IncCycles();
    // JZ 0x1000:8aff (1000_8ADD / 0x18ADD)
    if(ZeroFlag) {
      goto label_1000_8AFF_18AFF;
    }
    State.IncCycles();
    // CMP BP,0x55 (1000_8ADF / 0x18ADF)
    Alu.Sub16(BP, 0x55);
    State.IncCycles();
    // JZ 0x1000:8b07 (1000_8AE3 / 0x18AE3)
    if(ZeroFlag) {
      goto label_1000_8B07_18B07;
    }
    State.IncCycles();
    // CMP BP,0x61 (1000_8AE5 / 0x18AE5)
    Alu.Sub16(BP, 0x61);
    State.IncCycles();
    // JZ 0x1000:8b07 (1000_8AE9 / 0x18AE9)
    if(ZeroFlag) {
      goto label_1000_8B07_18B07;
    }
    State.IncCycles();
    // CMP BP,0x44 (1000_8AEB / 0x18AEB)
    Alu.Sub16(BP, 0x44);
    State.IncCycles();
    // JNZ 0x1000:8ac1 (1000_8AEF / 0x18AEF)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18AC1 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BH,byte ptr SS:[0x47de] (1000_8AF1 / 0x18AF1)
    BH = UInt8[SS, 0x47DE];
    State.IncCycles();
    // AND BH,0xf (1000_8AF6 / 0x18AF6)
    BH &= 0xF;
    State.IncCycles();
    // CMP BH,0x1 (1000_8AF9 / 0x18AF9)
    Alu.Sub8(BH, 0x1);
    State.IncCycles();
    // JNZ 0x1000:8ac1 (1000_8AFC / 0x18AFC)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18AC1 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC AX (1000_8AFE / 0x18AFE)
    AX--;
    State.IncCycles();
    label_1000_8AFF_18AFF:
    // CMP AL,0x8 (1000_8AFF / 0x18AFF)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JBE 0x1000:8abe (1000_8B01 / 0x18B01)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0x8 (1000_8B03 / 0x18B03)
    AL = 0x8;
    State.IncCycles();
    // JMP 0x1000:8abe (1000_8B05 / 0x18B05)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8B07_18B07:
    // DEC AX (1000_8B07 / 0x18B07)
    AX--;
    State.IncCycles();
    // CMP AL,0x4 (1000_8B08 / 0x18B08)
    Alu.Sub8(AL, 0x4);
    State.IncCycles();
    // JBE 0x1000:8abe (1000_8B0A / 0x18B0A)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0x4 (1000_8B0C / 0x18B0C)
    AL = 0x4;
    State.IncCycles();
    // JMP 0x1000:8abe (1000_8B0E / 0x18B0E)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_8B10_018B10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8B10_18B10:
    // RET  (1000_8B10 / 0x18B10)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8B11_018B11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8B11_18B11:
    // PUSH SI (1000_8B11 / 0x18B11)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:8c8a (1000_8B12 / 0x18B12)
    NearCall(cs1, 0x8B15, spice86_generated_label_call_target_1000_8C8A_018C8A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8B15_018B15, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8B15_018B15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8B15_18B15:
    // POP SI (1000_8B15 / 0x18B15)
    SI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:8ccd (1000_8B16 / 0x18B16)
    NearCall(cs1, 0x8B19, spice86_generated_label_call_target_1000_8CCD_018CCD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8B19_018B19, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8B19_018B19(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8B19_18B19:
    // JC 0x1000:8b10 (1000_8B19 / 0x18B19)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8B10 / 0x18B10)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:8f28 (1000_8B1B / 0x18B1B)
    NearCall(cs1, 0x8B1E, spice86_generated_label_call_target_1000_8F28_018F28);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8B1E_018B1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8B1E_018B1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8B1E_18B1E:
    // CALL 0x1000:8df0 (1000_8B1E / 0x18B1E)
    NearCall(cs1, 0x8B21, spice86_generated_label_call_target_1000_8DF0_018DF0);
    State.IncCycles();
    label_1000_8B21_18B21:
    // MOV DX,word ptr [0x4791] (1000_8B21 / 0x18B21)
    DX = UInt16[DS, 0x4791];
    State.IncCycles();
    // MOV BX,word ptr [0x4793] (1000_8B25 / 0x18B25)
    BX = UInt16[DS, 0x4793];
    State.IncCycles();
    // CALL 0x1000:d04e (1000_8B29 / 0x18B29)
    NearCall(cs1, 0x8B2C, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8B2C_018B2C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8B2C_018B2C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8B2C_18B2C:
    // MOV BP,0xa9d0 (1000_8B2C / 0x18B2C)
    BP = 0xA9D0;
    State.IncCycles();
    // MOV word ptr [0x479a],0xa (1000_8B2F / 0x18B2F)
    UInt16[DS, 0x479A] = 0xA;
    State.IncCycles();
    // MOV AL,[0x4799] (1000_8B35 / 0x18B35)
    AL = UInt8[DS, 0x4799];
    State.IncCycles();
    // AND AL,0xc (1000_8B38 / 0x18B38)
    // AL &= 0xC;
    AL = Alu.And8(AL, 0xC);
    State.IncCycles();
    // JZ 0x1000:8b8b (1000_8B3A / 0x18B3A)
    if(ZeroFlag) {
      goto label_1000_8B8B_18B8B;
    }
    State.IncCycles();
    // CMP AL,0x8 (1000_8B3C / 0x18B3C)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNC 0x1000:8b66 (1000_8B3E / 0x18B3E)
    if(!CarryFlag) {
      goto label_1000_8B66_18B66;
    }
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (1000_8B40 / 0x18B40)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // XOR DX,DX (1000_8B43 / 0x18B43)
    DX = 0;
    State.IncCycles();
    // MOV AX,[0x478d] (1000_8B45 / 0x18B45)
    AX = UInt16[DS, 0x478D];
    State.IncCycles();
    // SUB AX,0x8 (1000_8B48 / 0x18B48)
    AX -= 0x8;
    State.IncCycles();
    // DEC BX (1000_8B4B / 0x18B4B)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JZ 0x1000:8b55 (1000_8B4C / 0x18B4C)
    if(ZeroFlag) {
      goto label_1000_8B55_18B55;
    }
    State.IncCycles();
    // DIV BX (1000_8B4E / 0x18B4E)
    Cpu.Div16(BX);
    State.IncCycles();
    // MOV [0x479a],AX (1000_8B50 / 0x18B50)
    UInt16[DS, 0x479A] = AX;
    State.IncCycles();
    // JMP 0x1000:8b8b (1000_8B53 / 0x18B53)
    goto label_1000_8B8B_18B8B;
    State.IncCycles();
    label_1000_8B55_18B55:
    // SHR AX,1 (1000_8B55 / 0x18B55)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV BX,AX (1000_8B57 / 0x18B57)
    BX = AX;
    State.IncCycles();
    // MOV DX,word ptr [0xd82c] (1000_8B59 / 0x18B59)
    DX = UInt16[DS, 0xD82C];
    State.IncCycles();
    // ADD BX,word ptr [0xd82e] (1000_8B5D / 0x18B5D)
    // BX += UInt16[DS, 0xD82E];
    BX = Alu.Add16(BX, UInt16[DS, 0xD82E]);
    State.IncCycles();
    // CALL 0x1000:d04e (1000_8B61 / 0x18B61)
    NearCall(cs1, 0x8B64, spice86_generated_label_call_target_1000_D04E_01D04E);
    State.IncCycles();
    // JMP 0x1000:8b8b (1000_8B64 / 0x18B64)
    goto label_1000_8B8B_18B8B;
    State.IncCycles();
    label_1000_8B66_18B66:
    // PUSHF  (1000_8B66 / 0x18B66)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (1000_8B67 / 0x18B67)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // MOV AH,0xa (1000_8B6A / 0x18B6A)
    AH = 0xA;
    State.IncCycles();
    // MUL AH (1000_8B6C / 0x18B6C)
    Cpu.Mul8(AH);
    State.IncCycles();
    // MOV BX,word ptr [0x478d] (1000_8B6E / 0x18B6E)
    BX = UInt16[DS, 0x478D];
    State.IncCycles();
    // SUB BX,AX (1000_8B72 / 0x18B72)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // JNC 0x1000:8b78 (1000_8B74 / 0x18B74)
    if(!CarryFlag) {
      goto label_1000_8B78_18B78;
    }
    State.IncCycles();
    // XOR BX,BX (1000_8B76 / 0x18B76)
    BX = 0;
    State.IncCycles();
    label_1000_8B78_18B78:
    // MOV [0x478d],AX (1000_8B78 / 0x18B78)
    UInt16[DS, 0x478D] = AX;
    State.IncCycles();
    // POPF  (1000_8B7B / 0x18B7B)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNZ 0x1000:8b80 (1000_8B7C / 0x18B7C)
    if(!ZeroFlag) {
      goto label_1000_8B80_18B80;
    }
    State.IncCycles();
    // SHR BX,1 (1000_8B7E / 0x18B7E)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    label_1000_8B80_18B80:
    // MOV DX,word ptr [0xd82c] (1000_8B80 / 0x18B80)
    DX = UInt16[DS, 0xD82C];
    State.IncCycles();
    // ADD BX,word ptr [0xd82e] (1000_8B84 / 0x18B84)
    // BX += UInt16[DS, 0xD82E];
    BX = Alu.Add16(BX, UInt16[DS, 0xD82E]);
    State.IncCycles();
    // CALL 0x1000:d04e (1000_8B88 / 0x18B88)
    NearCall(cs1, 0x8B8B, spice86_generated_label_call_target_1000_D04E_01D04E);
    State.IncCycles();
    label_1000_8B8B_18B8B:
    // MOV DX,word ptr [BP + 0x0] (1000_8B8B / 0x18B8B)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // ADD BP,0x2 (1000_8B8E / 0x18B8E)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8B91_018B91(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8BE9: goto label_1000_8BE9_18BE9;break; // Target of external jump from 0x18C12, 0x18C45, 0x18C3F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_8B91_18B91:
    // PUSH DX (1000_8B91 / 0x18B91)
    Stack.Push(DX);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (1000_8B92 / 0x18B92)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // ADD BP,0x2 (1000_8B95 / 0x18B95)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x0] (1000_8B98 / 0x18B98)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (1000_8B9B / 0x18B9B)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // ADD BP,0x4 (1000_8B9E / 0x18B9E)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    State.IncCycles();
    // JCXZ 0x1000:8c0c (1000_8BA1 / 0x18BA1)
    if(CX == 0) {
      // JCXZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:8c47 (1000_8C0C / 0x18C0C)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C47 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST byte ptr [0x4799],0x2 (1000_8BA3 / 0x18BA3)
    Alu.And8(UInt8[DS, 0x4799], 0x2);
    State.IncCycles();
    // JZ 0x1000:8bd1 (1000_8BA8 / 0x18BA8)
    if(ZeroFlag) {
      goto label_1000_8BD1_18BD1;
    }
    State.IncCycles();
    // MOV AL,DL (1000_8BAA / 0x18BAA)
    AL = DL;
    State.IncCycles();
    // MOV DL,CL (1000_8BAC / 0x18BAC)
    DL = CL;
    State.IncCycles();
    // DEC DL (1000_8BAE / 0x18BAE)
    DL = Alu.Dec8(DL);
    State.IncCycles();
    // JZ 0x1000:8bb4 (1000_8BB0 / 0x18BB0)
    if(ZeroFlag) {
      goto label_1000_8BB4_18BB4;
    }
    State.IncCycles();
    // MUL DL (1000_8BB2 / 0x18BB2)
    Cpu.Mul8(DL);
    State.IncCycles();
    label_1000_8BB4_18BB4:
    // ADD AL,BL (1000_8BB4 / 0x18BB4)
    // AL += BL;
    AL = Alu.Add8(AL, BL);
    State.IncCycles();
    // MOV DL,AL (1000_8BB6 / 0x18BB6)
    DL = AL;
    State.IncCycles();
    // MOV AL,CL (1000_8BB8 / 0x18BB8)
    AL = CL;
    State.IncCycles();
    // DEC AL (1000_8BBA / 0x18BBA)
    AL--;
    State.IncCycles();
    // XOR AH,AH (1000_8BBC / 0x18BBC)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_8BBE / 0x18BBE)
    AX <<= 0x1;
    State.IncCycles();
    // SUB DX,AX (1000_8BC0 / 0x18BC0)
    DX -= AX;
    State.IncCycles();
    // SHL AX,1 (1000_8BC2 / 0x18BC2)
    AX <<= 0x1;
    State.IncCycles();
    // SUB DX,AX (1000_8BC4 / 0x18BC4)
    DX -= AX;
    State.IncCycles();
    // SHR DX,1 (1000_8BC6 / 0x18BC6)
    DX >>= 0x1;
    State.IncCycles();
    // ADD word ptr [0xd82c],DX (1000_8BC8 / 0x18BC8)
    UInt16[DS, 0xD82C] += DX;
    State.IncCycles();
    // AND byte ptr [0x4799],0xfe (1000_8BCC / 0x18BCC)
    // UInt8[DS, 0x4799] &= 0xFE;
    UInt8[DS, 0x4799] = Alu.And8(UInt8[DS, 0x4799], 0xFE);
    State.IncCycles();
    label_1000_8BD1_18BD1:
    // POP AX (1000_8BD1 / 0x18BD1)
    AX = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_8BD2 / 0x18BD2)
    Stack.Push(AX);
    State.IncCycles();
    // CMP AX,0x1 (1000_8BD3 / 0x18BD3)
    Alu.Sub16(AX, 0x1);
    State.IncCycles();
    // JZ 0x1000:8bdf (1000_8BD6 / 0x18BD6)
    if(ZeroFlag) {
      goto label_1000_8BDF_18BDF;
    }
    State.IncCycles();
    // TEST byte ptr [0x4799],0x1 (1000_8BD8 / 0x18BD8)
    Alu.And8(UInt8[DS, 0x4799], 0x1);
    State.IncCycles();
    // JNZ 0x1000:8be5 (1000_8BDD / 0x18BDD)
    if(!ZeroFlag) {
      goto label_1000_8BE5_18BE5;
    }
    State.IncCycles();
    label_1000_8BDF_18BDF:
    // MOV DX,0x6 (1000_8BDF / 0x18BDF)
    DX = 0x6;
    State.IncCycles();
    // MOV BX,0x0 (1000_8BE2 / 0x18BE2)
    BX = 0x0;
    State.IncCycles();
    label_1000_8BE5_18BE5:
    // MOV word ptr [0x479c],BX (1000_8BE5 / 0x18BE5)
    UInt16[DS, 0x479C] = BX;
    State.IncCycles();
    label_1000_8BE9_18BE9:
    // LODSB SI (1000_8BE9 / 0x18BE9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_8BEA / 0x18BEA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:8c26 (1000_8BEC / 0x18BEC)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C26 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AL,0x20 (1000_8BEE / 0x18BEE)
    Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:8c19 (1000_8BF0 / 0x18BF0)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C19 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AL,0xd (1000_8BF2 / 0x18BF2)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JZ 0x1000:8c19 (1000_8BF4 / 0x18BF4)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C19 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AL,0x6 (1000_8BF6 / 0x18BF6)
    Alu.Sub8(AL, 0x6);
    State.IncCycles();
    // JZ 0x1000:8c0f (1000_8BF8 / 0x18BF8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AL,0x8 (1000_8BFA / 0x18BFA)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JZ 0x1000:8c14 (1000_8BFC / 0x18BFC)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C14 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AL,0x1 (1000_8BFE / 0x18BFE)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:8c41 (1000_8C00 / 0x18C00)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C41 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xdbe4] (1000_8C02 / 0x18C02)
    AX = UInt16[DS, 0xDBE4];
    State.IncCycles();
    // XCHG AL,AH (1000_8C05 / 0x18C05)
    byte tmp_1000_8C05 = AL;
    AL = AH;
    AH = tmp_1000_8C05;
    State.IncCycles();
    // MOV [0xdbe4],AX (1000_8C07 / 0x18C07)
    UInt16[DS, 0xDBE4] = AX;
    State.IncCycles();
    // JMP 0x1000:8be9 (1000_8C0A / 0x18C0A)
    goto label_1000_8BE9_18BE9;
    State.IncCycles();
    label_1000_8C0C_18C0C:
    // JMP 0x1000:8c47 (1000_8C0C / 0x18C0C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C47 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8C0F_018C0F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8C41: goto label_1000_8C41_18C41;break; // Target of external jump from 0x18C00
      case 0x8C47: goto label_1000_8C47_18C47;break; // Target of external jump from 0x18C27, 0x18C0C
      case 0x8C26: goto label_1000_8C26_18C26;break; // Target of external jump from 0x18C21, 0x18BEC
      case 0x8C19: goto label_1000_8C19_18C19;break; // Target of external jump from 0x18BF0, 0x18C24, 0x18BF4
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_8C0F_18C0F:
    // CALL 0x1000:d075 (1000_8C0F / 0x18C0F)
    NearCall(cs1, 0x8C12, spice86_generated_label_call_target_1000_D075_01D075);
    State.IncCycles();
    label_1000_8C12_18C12:
    // JMP 0x1000:8be9 (1000_8C12 / 0x18C12)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8C14_18C14:
    // CALL 0x1000:d068 (1000_8C14 / 0x18C14)
    NearCall(cs1, 0x8C17, spice86_generated_label_call_target_1000_D068_01D068);
    State.IncCycles();
    // JMP 0x1000:8be9 (1000_8C17 / 0x18C17)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8C19_18C19:
    // CMP byte ptr [SI],0x20 (1000_8C19 / 0x18C19)
    Alu.Sub8(UInt8[DS, SI], 0x20);
    State.IncCycles();
    // JZ 0x1000:8c23 (1000_8C1C / 0x18C1C)
    if(ZeroFlag) {
      goto label_1000_8C23_18C23;
    }
    State.IncCycles();
    // CMP byte ptr [SI],0xd (1000_8C1E / 0x18C1E)
    Alu.Sub8(UInt8[DS, SI], 0xD);
    State.IncCycles();
    // JNZ 0x1000:8c26 (1000_8C21 / 0x18C21)
    if(!ZeroFlag) {
      goto label_1000_8C26_18C26;
    }
    State.IncCycles();
    label_1000_8C23_18C23:
    // INC SI (1000_8C23 / 0x18C23)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // JMP 0x1000:8c19 (1000_8C24 / 0x18C24)
    goto label_1000_8C19_18C19;
    State.IncCycles();
    label_1000_8C26_18C26:
    // DEC CX (1000_8C26 / 0x18C26)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JZ 0x1000:8c47 (1000_8C27 / 0x18C27)
    if(ZeroFlag) {
      goto label_1000_8C47_18C47;
    }
    State.IncCycles();
    // PUSH DX (1000_8C29 / 0x18C29)
    Stack.Push(DX);
    State.IncCycles();
    // ADD DX,word ptr [0xd82c] (1000_8C2A / 0x18C2A)
    DX += UInt16[DS, 0xD82C];
    State.IncCycles();
    // CMP word ptr [0x479c],0x0 (1000_8C2E / 0x18C2E)
    Alu.Sub16(UInt16[DS, 0x479C], 0x0);
    State.IncCycles();
    // JZ 0x1000:8c3a (1000_8C33 / 0x18C33)
    if(ZeroFlag) {
      goto label_1000_8C3A_18C3A;
    }
    State.IncCycles();
    // INC DX (1000_8C35 / 0x18C35)
    DX++;
    State.IncCycles();
    // DEC word ptr [0x479c] (1000_8C36 / 0x18C36)
    UInt16[DS, 0x479C] = Alu.Dec16(UInt16[DS, 0x479C]);
    State.IncCycles();
    label_1000_8C3A_18C3A:
    // MOV word ptr [0xd82c],DX (1000_8C3A / 0x18C3A)
    UInt16[DS, 0xD82C] = DX;
    State.IncCycles();
    // POP DX (1000_8C3E / 0x18C3E)
    DX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:8be9 (1000_8C3F / 0x18C3F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8C41_18C41:
    // CALL word ptr [0x2518] (1000_8C41 / 0x18C41)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_8C41 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_8C41) {
      case 0xD096 : NearCall(cs1, 0x8C45, spice86_generated_label_call_target_1000_D096_01D096); break;
      case 0xD12F : NearCall(cs1, 0x8C45, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      case 0xD0FF : NearCall(cs1, 0x8C45, spice86_generated_label_call_target_1000_D0FF_01D0FF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8C41));
        break;
    }
    State.IncCycles();
    label_1000_8C45_18C45:
    // JMP 0x1000:8be9 (1000_8C45 / 0x18C45)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8C47_18C47:
    // MOV DX,word ptr [0xd830] (1000_8C47 / 0x18C47)
    DX = UInt16[DS, 0xD830];
    State.IncCycles();
    // MOV BX,word ptr [0xd832] (1000_8C4B / 0x18C4B)
    BX = UInt16[DS, 0xD832];
    State.IncCycles();
    // MOV AX,[0x479a] (1000_8C4F / 0x18C4F)
    AX = UInt16[DS, 0x479A];
    State.IncCycles();
    // ADD BX,AX (1000_8C52 / 0x18C52)
    BX += AX;
    State.IncCycles();
    // SUB word ptr [0x478d],AX (1000_8C54 / 0x18C54)
    // UInt16[DS, 0x478D] -= AX;
    UInt16[DS, 0x478D] = Alu.Sub16(UInt16[DS, 0x478D], AX);
    State.IncCycles();
    // JNC 0x1000:8c60 (1000_8C58 / 0x18C58)
    if(!CarryFlag) {
      goto label_1000_8C60_18C60;
    }
    State.IncCycles();
    // MOV word ptr [0x478d],0x0 (1000_8C5A / 0x18C5A)
    UInt16[DS, 0x478D] = 0x0;
    State.IncCycles();
    label_1000_8C60_18C60:
    // CALL 0x1000:d04e (1000_8C60 / 0x18C60)
    NearCall(cs1, 0x8C63, spice86_generated_label_call_target_1000_D04E_01D04E);
    State.IncCycles();
    label_1000_8C63_18C63:
    // POP DX (1000_8C63 / 0x18C63)
    DX = Stack.Pop();
    State.IncCycles();
    // DEC DX (1000_8C64 / 0x18C64)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JZ 0x1000:8c6a (1000_8C65 / 0x18C65)
    if(ZeroFlag) {
      goto label_1000_8C6A_18C6A;
    }
    State.IncCycles();
    // JMP 0x1000:8b91 (1000_8C67 / 0x18C67)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8C6A_18C6A:
    // MOV DX,word ptr [0xd830] (1000_8C6A / 0x18C6A)
    DX = UInt16[DS, 0xD830];
    State.IncCycles();
    // MOV BX,word ptr [0xd832] (1000_8C6E / 0x18C6E)
    BX = UInt16[DS, 0xD832];
    State.IncCycles();
    // MOV word ptr [0x4791],DX (1000_8C72 / 0x18C72)
    UInt16[DS, 0x4791] = DX;
    State.IncCycles();
    // MOV word ptr [0x4793],BX (1000_8C76 / 0x18C76)
    UInt16[DS, 0x4793] = BX;
    State.IncCycles();
    // DEC SI (1000_8C7A / 0x18C7A)
    SI--;
    State.IncCycles();
    // CMP word ptr [0x479e],0x223c (1000_8C7B / 0x18C7B)
    Alu.Sub16(UInt16[DS, 0x479E], 0x223C);
    State.IncCycles();
    // JNZ 0x1000:8c89 (1000_8C81 / 0x18C81)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8C89 / 0x18C89)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:9046 (1000_8C83 / 0x18C83)
    NearCall(cs1, 0x8C86, spice86_generated_label_call_target_1000_9046_019046);
    State.IncCycles();
    label_1000_8C86_18C86:
    // JMP 0x1000:c07c (1000_8C86 / 0x18C86)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8C89_18C89:
    // RET  (1000_8C89 / 0x18C89)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8C8A_018C8A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8C8A_18C8A:
    // XOR AX,AX (1000_8C8A / 0x18C8A)
    AX = 0;
    State.IncCycles();
    // XCHG word ptr [0x479e],AX (1000_8C8C / 0x18C8C)
    ushort tmp_1000_8C8C = UInt16[DS, 0x479E];
    UInt16[DS, 0x479E] = AX;
    AX = tmp_1000_8C8C;
    State.IncCycles();
    // CMP AX,0x2 (1000_8C90 / 0x18C90)
    Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // JC 0x1000:8ccc (1000_8C93 / 0x18C93)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8CCC / 0x18CCC)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x1470 (1000_8C95 / 0x18C95)
    SI = 0x1470;
    State.IncCycles();
    // CMP byte ptr [0x28e7],0x0 (1000_8C98 / 0x18C98)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    State.IncCycles();
    // JZ 0x1000:8cb5 (1000_8C9D / 0x18C9D)
    if(ZeroFlag) {
      goto label_1000_8CB5_18CB5;
    }
    State.IncCycles();
    // MOV BP,0x1be2 (1000_8C9F / 0x18C9F)
    BP = 0x1BE2;
    State.IncCycles();
    // MOV SI,0x4c60 (1000_8CA2 / 0x18CA2)
    SI = 0x4C60;
    State.IncCycles();
    // MOV ES,word ptr [0xdbde] (1000_8CA5 / 0x18CA5)
    ES = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // CALLF [0x391d] (1000_8CA9 / 0x18CA9)
    // Indirect call to [0x391d], generating possible targets from emulator records
    uint targetAddress_1000_8CA9 = (uint)(UInt16[DS, 0x391F] * 0x10 + UInt16[DS, 0x391D] - cs1 * 0x10);
    switch(targetAddress_1000_8CA9) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8CA9));
        break;
    }
    State.IncCycles();
    // MOV SI,0x1be2 (1000_8CAD / 0x18CAD)
    SI = 0x1BE2;
    State.IncCycles();
    // MOV word ptr [SI + 0x8],0x0 (1000_8CB0 / 0x18CB0)
    UInt16[DS, (ushort)(SI + 0x8)] = 0x0;
    State.IncCycles();
    label_1000_8CB5_18CB5:
    // CALL 0x1000:c446 (1000_8CB5 / 0x18CB5)
    NearCall(cs1, 0x8CB8, spice86_generated_label_call_target_1000_C446_01C446);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8CB8_018CB8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8CB8_018CB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8CB8_18CB8:
    // MOV SI,word ptr [0x47c8] (1000_8CB8 / 0x18CB8)
    SI = UInt16[DS, 0x47C8];
    State.IncCycles();
    // OR SI,SI (1000_8CBC / 0x18CBC)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:8cc9 (1000_8CBE / 0x18CBE)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8CC9_018CC9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr [0x4540],0x0 (1000_8CC0 / 0x18CC0)
    UInt16[DS, 0x4540] = 0x0;
    State.IncCycles();
    // CALL 0x1000:9bac (1000_8CC6 / 0x18CC6)
    NearCall(cs1, 0x8CC9, spice86_generated_label_call_target_1000_9BAC_019BAC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8CC9_018CC9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8CC9_018CC9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8CCC: goto label_1000_8CCC_18CCC;break; // Target of external jump from 0x18C93
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_8CC9_18CC9:
    // CALL 0x1000:c4dd (1000_8CC9 / 0x18CC9)
    NearCall(cs1, 0x8CCC, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_8CCC_18CCC:
    // RET  (1000_8CCC / 0x18CCC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8CCD_018CCD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8CCD_18CCD:
    // MOV byte ptr [0x4799],0x9 (1000_8CCD / 0x18CCD)
    UInt8[DS, 0x4799] = 0x9;
    State.IncCycles();
    // MOV word ptr [0xdbe4],0xf0 (1000_8CD2 / 0x18CD2)
    UInt16[DS, 0xDBE4] = 0xF0;
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_8CD8 / 0x18CD8)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JZ 0x1000:8cfb (1000_8CDD / 0x18CDD)
    if(ZeroFlag) {
      goto label_1000_8CFB_18CFB;
    }
    State.IncCycles();
    // CMP word ptr [0x46ef],0x0 (1000_8CDF / 0x18CDF)
    Alu.Sub16(UInt16[DS, 0x46EF], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8cf5 (1000_8CE4 / 0x18CE4)
    if(!ZeroFlag) {
      goto label_1000_8CF5_18CF5;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_8CE6 / 0x18CE6)
    NearCall(cs1, 0x8CE9, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // PUSH ES (1000_8CE9 / 0x18CE9)
    Stack.Push(ES);
    State.IncCycles();
    // MOV SI,word ptr [0x46f1] (1000_8CEA / 0x18CEA)
    SI = UInt16[DS, 0x46F1];
    State.IncCycles();
    // CALL 0x1000:79ee (1000_8CEE / 0x18CEE)
    NearCall(cs1, 0x8CF1, spice86_generated_label_call_target_1000_79EE_0179EE);
    State.IncCycles();
    // POP ES (1000_8CF1 / 0x18CF1)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_8CF2 / 0x18CF2)
    NearCall(cs1, 0x8CF5, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_8CF5_18CF5:
    // MOV BP,0x2244 (1000_8CF5 / 0x18CF5)
    BP = 0x2244;
    State.IncCycles();
    // JMP 0x1000:8ddb (1000_8CF8 / 0x18CF8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8CFB_18CFB:
    // CMP word ptr [0x47c4],-0x1 (1000_8CFB / 0x18CFB)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:8d1b (1000_8D00 / 0x18D00)
    if(!ZeroFlag) {
      goto label_1000_8D1B_18D1B;
    }
    State.IncCycles();
    // MOV AX,0x48 (1000_8D02 / 0x18D02)
    AX = 0x48;
    State.IncCycles();
    // MOV [0x4784],AX (1000_8D05 / 0x18D05)
    UInt16[DS, 0x4784] = AX;
    State.IncCycles();
    // MOV AL,0x10 (1000_8D08 / 0x18D08)
    AL = 0x10;
    State.IncCycles();
    // MOV [0x4786],AX (1000_8D0A / 0x18D0A)
    UInt16[DS, 0x4786] = AX;
    State.IncCycles();
    // MOV AL,0x8 (1000_8D0D / 0x18D0D)
    AL = 0x8;
    State.IncCycles();
    // MOV [0x4788],AX (1000_8D0F / 0x18D0F)
    UInt16[DS, 0x4788] = AX;
    State.IncCycles();
    // MOV [0x478a],AX (1000_8D12 / 0x18D12)
    UInt16[DS, 0x478A] = AX;
    State.IncCycles();
    // MOV BP,0x224c (1000_8D15 / 0x18D15)
    BP = 0x224C;
    State.IncCycles();
    // JMP 0x1000:8ddb (1000_8D18 / 0x18D18)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8D1B_18D1B:
    // CMP byte ptr [0xc6],0x0 (1000_8D1B / 0x18D1B)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    State.IncCycles();
    // JZ 0x1000:8d43 (1000_8D20 / 0x18D20)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8D43_018D43, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BP,0x2265 (1000_8D22 / 0x18D22)
    BP = 0x2265;
    State.IncCycles();
    // MOV AX,0x3c (1000_8D25 / 0x18D25)
    AX = 0x3C;
    State.IncCycles();
    // MOV [0x4784],AX (1000_8D28 / 0x18D28)
    UInt16[DS, 0x4784] = AX;
    State.IncCycles();
    // MOV AL,0x32 (1000_8D2B / 0x18D2B)
    AL = 0x32;
    State.IncCycles();
    // MOV [0x4786],AX (1000_8D2D / 0x18D2D)
    UInt16[DS, 0x4786] = AX;
    State.IncCycles();
    // MOV AL,0xa (1000_8D30 / 0x18D30)
    AL = 0xA;
    State.IncCycles();
    // MOV [0x4788],AX (1000_8D32 / 0x18D32)
    UInt16[DS, 0x4788] = AX;
    State.IncCycles();
    // MOV [0x478a],AX (1000_8D35 / 0x18D35)
    UInt16[DS, 0x478A] = AX;
    State.IncCycles();
    // MOV byte ptr [0xdbe4],0x64 (1000_8D38 / 0x18D38)
    UInt8[DS, 0xDBE4] = 0x64;
    State.IncCycles();
    // CALL 0x1000:d082 (1000_8D3D / 0x18D3D)
    NearCall(cs1, 0x8D40, spice86_generated_label_call_target_1000_D082_01D082);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8D40_018D40, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8D40_018D40(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8D40_18D40:
    // JMP 0x1000:8ddb (1000_8D40 / 0x18D40)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8D43_018D43(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8D43_18D43:
    // CMP byte ptr [0x227d],0x0 (1000_8D43 / 0x18D43)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JZ 0x1000:8d62 (1000_8D48 / 0x18D48)
    if(ZeroFlag) {
      goto label_1000_8D62_18D62;
    }
    State.IncCycles();
    // MOV byte ptr [0xdbe4],0x6 (1000_8D4A / 0x18D4A)
    UInt8[DS, 0xDBE4] = 0x6;
    State.IncCycles();
    // MOV BP,0x2275 (1000_8D4F / 0x18D4F)
    BP = 0x2275;
    State.IncCycles();
    // XOR AX,AX (1000_8D52 / 0x18D52)
    AX = 0;
    State.IncCycles();
    // MOV [0x4788],AX (1000_8D54 / 0x18D54)
    UInt16[DS, 0x4788] = AX;
    State.IncCycles();
    // MOV [0x478a],AX (1000_8D57 / 0x18D57)
    UInt16[DS, 0x478A] = AX;
    State.IncCycles();
    // MOV [0x4784],AX (1000_8D5A / 0x18D5A)
    UInt16[DS, 0x4784] = AX;
    State.IncCycles();
    // MOV [0x4786],AX (1000_8D5D / 0x18D5D)
    UInt16[DS, 0x4786] = AX;
    State.IncCycles();
    // JMP 0x1000:8ddb (1000_8D60 / 0x18D60)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8D62_18D62:
    // CMP byte ptr [0x28e7],0x0 (1000_8D62 / 0x18D62)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8d8a (1000_8D67 / 0x18D67)
    if(!ZeroFlag) {
      goto label_1000_8D8A_18D8A;
    }
    State.IncCycles();
    // MOV byte ptr [0x4799],0x1 (1000_8D69 / 0x18D69)
    UInt8[DS, 0x4799] = 0x1;
    State.IncCycles();
    // MOV byte ptr [0xdbe4],0xf (1000_8D6E / 0x18D6E)
    UInt8[DS, 0xDBE4] = 0xF;
    State.IncCycles();
    // MOV BP,0x223c (1000_8D73 / 0x18D73)
    BP = 0x223C;
    State.IncCycles();
    // XOR AX,AX (1000_8D76 / 0x18D76)
    AX = 0;
    State.IncCycles();
    // MOV [0x478a],AX (1000_8D78 / 0x18D78)
    UInt16[DS, 0x478A] = AX;
    State.IncCycles();
    // INC AX (1000_8D7B / 0x18D7B)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0x4788],AX (1000_8D7C / 0x18D7C)
    UInt16[DS, 0x4788] = AX;
    State.IncCycles();
    // MOV AX,0x10 (1000_8D7F / 0x18D7F)
    AX = 0x10;
    State.IncCycles();
    // MOV [0x4784],AX (1000_8D82 / 0x18D82)
    UInt16[DS, 0x4784] = AX;
    State.IncCycles();
    // MOV [0x4786],AX (1000_8D85 / 0x18D85)
    UInt16[DS, 0x4786] = AX;
    State.IncCycles();
    // JMP 0x1000:8ddb (1000_8D88 / 0x18D88)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8D8A_18D8A:
    // MOV BP,0x2224 (1000_8D8A / 0x18D8A)
    BP = 0x2224;
    State.IncCycles();
    // MOV CX,0x3 (1000_8D8D / 0x18D8D)
    CX = 0x3;
    State.IncCycles();
    label_1000_8D90_18D90:
    // MOV AX,word ptr [BP + 0x4] (1000_8D90 / 0x18D90)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // SUB AX,word ptr [0x4784] (1000_8D93 / 0x18D93)
    AX -= UInt16[DS, 0x4784];
    State.IncCycles();
    // SUB AX,word ptr [0x4786] (1000_8D97 / 0x18D97)
    // AX -= UInt16[DS, 0x4786];
    AX = Alu.Sub16(AX, UInt16[DS, 0x4786]);
    State.IncCycles();
    // MOV [0x478f],AX (1000_8D9B / 0x18D9B)
    UInt16[DS, 0x478F] = AX;
    State.IncCycles();
    // PUSH SI (1000_8D9E / 0x18D9E)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH CX (1000_8D9F / 0x18D9F)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:8e16 (1000_8DA0 / 0x18DA0)
    NearCall(cs1, 0x8DA3, spice86_generated_label_call_target_1000_8E16_018E16);
    State.IncCycles();
    // POP CX (1000_8DA3 / 0x18DA3)
    CX = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_8DA4 / 0x18DA4)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV AX,[0xa9d0] (1000_8DA5 / 0x18DA5)
    AX = UInt16[DS, 0xA9D0];
    State.IncCycles();
    // MOV AH,0xa (1000_8DA8 / 0x18DA8)
    AH = 0xA;
    State.IncCycles();
    // MUL AH (1000_8DAA / 0x18DAA)
    Cpu.Mul8(AH);
    State.IncCycles();
    // ADD AX,word ptr [0x4788] (1000_8DAC / 0x18DAC)
    AX += UInt16[DS, 0x4788];
    State.IncCycles();
    // ADD AX,word ptr [0x478a] (1000_8DB0 / 0x18DB0)
    AX += UInt16[DS, 0x478A];
    State.IncCycles();
    // CMP AX,word ptr [BP + 0x6] (1000_8DB4 / 0x18DB4)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    State.IncCycles();
    // JC 0x1000:8dcd (1000_8DB7 / 0x18DB7)
    if(CarryFlag) {
      goto label_1000_8DCD_18DCD;
    }
    State.IncCycles();
    // ADD BP,0x8 (1000_8DB9 / 0x18DB9)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    State.IncCycles();
    // LOOP 0x1000:8d90 (1000_8DBC / 0x18DBC)
    if(--CX != 0) {
      goto label_1000_8D90_18D90;
    }
    State.IncCycles();
    // SUB BP,0x8 (1000_8DBE / 0x18DBE)
    BP -= 0x8;
    State.IncCycles();
    // XOR AX,AX (1000_8DC1 / 0x18DC1)
    AX = 0;
    State.IncCycles();
    // MOV [0x4788],AX (1000_8DC3 / 0x18DC3)
    UInt16[DS, 0x4788] = AX;
    State.IncCycles();
    // XCHG word ptr [0x478a],AX (1000_8DC6 / 0x18DC6)
    ushort tmp_1000_8DC6 = UInt16[DS, 0x478A];
    UInt16[DS, 0x478A] = AX;
    AX = tmp_1000_8DC6;
    State.IncCycles();
    // OR AX,AX (1000_8DCA / 0x18DCA)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // RET  (1000_8DCC / 0x18DCC)
    return NearRet();
    State.IncCycles();
    label_1000_8DCD_18DCD:
    // DEC CX (1000_8DCD / 0x18DCD)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JZ 0x1000:8dee (1000_8DCE / 0x18DCE)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0x18DEE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BX,0x1 (1000_8DD0 / 0x18DD0)
    BX = 0x1;
    State.IncCycles();
    // CALL 0x1000:e3b7 (1000_8DD3 / 0x18DD3)
    NearCall(cs1, 0x8DD6, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    // JZ 0x1000:8dee (1000_8DD6 / 0x18DD6)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0x18DEE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD BP,0x8 (1000_8DD8 / 0x18DD8)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8DDB_018DDB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8DDB_18DDB:
    // MOV AX,word ptr [BP + 0x4] (1000_8DDB / 0x18DDB)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // SUB AX,word ptr [0x4784] (1000_8DDE / 0x18DDE)
    AX -= UInt16[DS, 0x4784];
    State.IncCycles();
    // SUB AX,word ptr [0x4786] (1000_8DE2 / 0x18DE2)
    // AX -= UInt16[DS, 0x4786];
    AX = Alu.Sub16(AX, UInt16[DS, 0x4786]);
    State.IncCycles();
    // MOV [0x478f],AX (1000_8DE6 / 0x18DE6)
    UInt16[DS, 0x478F] = AX;
    State.IncCycles();
    // PUSH SI (1000_8DE9 / 0x18DE9)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:8e16 (1000_8DEA / 0x18DEA)
    NearCall(cs1, 0x8DED, spice86_generated_label_call_target_1000_8E16_018E16);
    State.IncCycles();
    label_1000_8DED_18DED:
    // POP SI (1000_8DED / 0x18DED)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_8DEE_18DEE:
    // CLC  (1000_8DEE / 0x18DEE)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_8DEF / 0x18DEF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8DF0_018DF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8DF0_18DF0:
    // TEST byte ptr [0x4799],0x1 (1000_8DF0 / 0x18DF0)
    Alu.And8(UInt8[DS, 0x4799], 0x1);
    State.IncCycles();
    // JZ 0x1000:8e15 (1000_8DF5 / 0x18DF5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8E15 / 0x18E15)
      return NearRet();
    }
    State.IncCycles();
    // PUSH SI (1000_8DF7 / 0x18DF7)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0xa9d0 (1000_8DF8 / 0x18DF8)
    SI = 0xA9D0;
    State.IncCycles();
    // LODSW SI (1000_8DFB / 0x18DFB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_8DFC / 0x18DFC)
    CX = AX;
    State.IncCycles();
    label_1000_8DFE_18DFE:
    // LODSW SI (1000_8DFE / 0x18DFE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_8DFF / 0x18DFF)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:8e08 (1000_8E01 / 0x18E01)
    if(ZeroFlag) {
      goto label_1000_8E08_18E08;
    }
    State.IncCycles();
    // CMP word ptr [SI],0x1e (1000_8E03 / 0x18E03)
    Alu.Sub16(UInt16[DS, SI], 0x1E);
    State.IncCycles();
    // JNC 0x1000:8e0f (1000_8E06 / 0x18E06)
    if(!CarryFlag) {
      goto label_1000_8E0F_18E0F;
    }
    State.IncCycles();
    label_1000_8E08_18E08:
    // ADD SI,0x4 (1000_8E08 / 0x18E08)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:8dfe (1000_8E0B / 0x18E0B)
    if(--CX != 0) {
      goto label_1000_8DFE_18DFE;
    }
    State.IncCycles();
    // POP SI (1000_8E0D / 0x18E0D)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8E0E / 0x18E0E)
    return NearRet();
    State.IncCycles();
    label_1000_8E0F_18E0F:
    // AND byte ptr [0x4799],0xfe (1000_8E0F / 0x18E0F)
    // UInt8[DS, 0x4799] &= 0xFE;
    UInt8[DS, 0x4799] = Alu.And8(UInt8[DS, 0x4799], 0xFE);
    State.IncCycles();
    // POP SI (1000_8E14 / 0x18E14)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_8E15_18E15:
    // RET  (1000_8E15 / 0x18E15)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8E16_018E16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8E16_18E16:
    // PUSH DS (1000_8E16 / 0x18E16)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_8E17 / 0x18E17)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x478c],0x0 (1000_8E18 / 0x18E18)
    UInt8[DS, 0x478C] = 0x0;
    State.IncCycles();
    // MOV DI,0xa9d2 (1000_8E1D / 0x18E1D)
    DI = 0xA9D2;
    State.IncCycles();
    // XOR DH,DH (1000_8E20 / 0x18E20)
    DH = 0;
    State.IncCycles();
    // MOV BX,word ptr [0x478f] (1000_8E22 / 0x18E22)
    BX = UInt16[DS, 0x478F];
    State.IncCycles();
    // XOR DL,DL (1000_8E26 / 0x18E26)
    DL = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8E28_018E28, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8E28_018E28(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8E28_18E28:
    // MOV AL,byte ptr [SI] (1000_8E28 / 0x18E28)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // OR AL,AL (1000_8E2A / 0x18E2A)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:8e74 (1000_8E2C / 0x18E2C)
    if(SignFlag) {
      goto label_1000_8E74_18E74;
    }
    State.IncCycles();
    // CMP AL,0xd (1000_8E2E / 0x18E2E)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JZ 0x1000:8e39 (1000_8E30 / 0x18E30)
    if(ZeroFlag) {
      goto label_1000_8E39_18E39;
    }
    State.IncCycles();
    // CMP AL,0x20 (1000_8E32 / 0x18E32)
    Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // JNZ 0x1000:8e4b (1000_8E34 / 0x18E34)
    if(!ZeroFlag) {
      goto label_1000_8E4B_18E4B;
    }
    State.IncCycles();
    // INC SI (1000_8E36 / 0x18E36)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // JMP 0x1000:8e28 (1000_8E37 / 0x18E37)
    goto label_1000_8E28_18E28;
    State.IncCycles();
    label_1000_8E39_18E39:
    // CALL 0x1000:8e9e (1000_8E39 / 0x18E39)
    NearCall(cs1, 0x8E3C, spice86_generated_label_call_target_1000_8E9E_018E9E);
    State.IncCycles();
    label_1000_8E3C_18E3C:
    // MOV word ptr [DI + -0x4],0x6 (1000_8E3C / 0x18E3C)
    UInt16[DS, (ushort)(DI - 0x4)] = 0x6;
    State.IncCycles();
    // MOV word ptr [DI + -0x2],0x0 (1000_8E41 / 0x18E41)
    UInt16[DS, (ushort)(DI - 0x2)] = 0x0;
    State.IncCycles();
    // XOR DL,DL (1000_8E46 / 0x18E46)
    DL = 0;
    State.IncCycles();
    // INC SI (1000_8E48 / 0x18E48)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // JMP 0x1000:8e28 (1000_8E49 / 0x18E49)
    goto label_1000_8E28_18E28;
    State.IncCycles();
    label_1000_8E4B_18E4B:
    // CALL 0x1000:8ed3 (1000_8E4B / 0x18E4B)
    NearCall(cs1, 0x8E4E, spice86_generated_label_call_target_1000_8ED3_018ED3);
    State.IncCycles();
    label_1000_8E4E_18E4E:
    // OR CX,CX (1000_8E4E / 0x18E4E)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JZ 0x1000:8e28 (1000_8E50 / 0x18E50)
    if(ZeroFlag) {
      goto label_1000_8E28_18E28;
    }
    State.IncCycles();
    // ADD CX,0x6 (1000_8E52 / 0x18E52)
    CX += 0x6;
    State.IncCycles();
    label_1000_8E55_18E55:
    // SUB BX,CX (1000_8E55 / 0x18E55)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    State.IncCycles();
    // JC 0x1000:8e5d (1000_8E57 / 0x18E57)
    if(CarryFlag) {
      goto label_1000_8E5D_18E5D;
    }
    State.IncCycles();
    // INC DL (1000_8E59 / 0x18E59)
    DL = Alu.Inc8(DL);
    State.IncCycles();
    // JMP 0x1000:8e28 (1000_8E5B / 0x18E5B)
    goto label_1000_8E28_18E28;
    State.IncCycles();
    label_1000_8E5D_18E5D:
    // ADD BX,0x6 (1000_8E5D / 0x18E5D)
    // BX += 0x6;
    BX = Alu.Add16(BX, 0x6);
    State.IncCycles();
    // JS 0x1000:8e69 (1000_8E60 / 0x18E60)
    if(SignFlag) {
      goto label_1000_8E69_18E69;
    }
    State.IncCycles();
    // INC DL (1000_8E62 / 0x18E62)
    DL = Alu.Inc8(DL);
    State.IncCycles();
    // CALL 0x1000:8e9e (1000_8E64 / 0x18E64)
    NearCall(cs1, 0x8E67, spice86_generated_label_call_target_1000_8E9E_018E9E);
    State.IncCycles();
    label_1000_8E67_18E67:
    // JMP 0x1000:8e28 (1000_8E67 / 0x18E67)
    goto label_1000_8E28_18E28;
    State.IncCycles();
    label_1000_8E69_18E69:
    // OR DL,DL (1000_8E69 / 0x18E69)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x1000:8e97 (1000_8E6B / 0x18E6B)
    if(ZeroFlag) {
      goto label_1000_8E97_18E97;
    }
    State.IncCycles();
    // ADD BX,CX (1000_8E6D / 0x18E6D)
    // BX += CX;
    BX = Alu.Add16(BX, CX);
    State.IncCycles();
    // CALL 0x1000:8e9e (1000_8E6F / 0x18E6F)
    NearCall(cs1, 0x8E72, spice86_generated_label_call_target_1000_8E9E_018E9E);
    State.IncCycles();
    label_1000_8E72_18E72:
    // JMP 0x1000:8e55 (1000_8E72 / 0x18E72)
    goto label_1000_8E55_18E55;
    State.IncCycles();
    label_1000_8E74_18E74:
    // OR DL,DL (1000_8E74 / 0x18E74)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x1000:8e7b (1000_8E76 / 0x18E76)
    if(ZeroFlag) {
      goto label_1000_8E7B_18E7B;
    }
    State.IncCycles();
    // CALL 0x1000:8e9e (1000_8E78 / 0x18E78)
    NearCall(cs1, 0x8E7B, spice86_generated_label_call_target_1000_8E9E_018E9E);
    State.IncCycles();
    label_1000_8E7B_18E7B:
    // MOV word ptr [DI + -0x4],0x6 (1000_8E7B / 0x18E7B)
    UInt16[DS, (ushort)(DI - 0x4)] = 0x6;
    State.IncCycles();
    // MOV word ptr [DI + -0x2],0x0 (1000_8E80 / 0x18E80)
    UInt16[DS, (ushort)(DI - 0x2)] = 0x0;
    State.IncCycles();
    // MOV word ptr [DI],0x0 (1000_8E85 / 0x18E85)
    UInt16[DS, DI] = 0x0;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],0x0 (1000_8E89 / 0x18E89)
    UInt16[DS, (ushort)(DI + 0x2)] = 0x0;
    State.IncCycles();
    // XOR DL,DL (1000_8E8E / 0x18E8E)
    DL = 0;
    State.IncCycles();
    // XCHG DL,DH (1000_8E90 / 0x18E90)
    byte tmp_1000_8E90 = DL;
    DL = DH;
    DH = tmp_1000_8E90;
    State.IncCycles();
    // MOV word ptr [0xa9d0],DX (1000_8E92 / 0x18E92)
    UInt16[DS, 0xA9D0] = DX;
    State.IncCycles();
    // RET  (1000_8E96 / 0x18E96)
    return NearRet();
    State.IncCycles();
    label_1000_8E97_18E97:
    // MOV word ptr [0xa9d0],0xc8 (1000_8E97 / 0x18E97)
    UInt16[DS, 0xA9D0] = 0xC8;
    State.IncCycles();
    // RET  (1000_8E9D / 0x18E9D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8E9E_018E9E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8E9E_18E9E:
    // MOV AX,DX (1000_8E9E / 0x18E9E)
    AX = DX;
    State.IncCycles();
    // XOR AH,AH (1000_8EA0 / 0x18EA0)
    AH = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_8EA2 / 0x18EA2)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD byte ptr [0x478c],AL (1000_8EA3 / 0x18EA3)
    // UInt8[DS, 0x478C] += AL;
    UInt8[DS, 0x478C] = Alu.Add8(UInt8[DS, 0x478C], AL);
    State.IncCycles();
    // OR AX,AX (1000_8EA7 / 0x18EA7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:8eca (1000_8EA9 / 0x18EA9)
    if(ZeroFlag) {
      goto label_1000_8ECA_18ECA;
    }
    State.IncCycles();
    // PUSH DX (1000_8EAB / 0x18EAB)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,BX (1000_8EAC / 0x18EAC)
    AX = BX;
    State.IncCycles();
    // MOV BX,DX (1000_8EAE / 0x18EAE)
    BX = DX;
    State.IncCycles();
    // XOR BH,BH (1000_8EB0 / 0x18EB0)
    BH = 0;
    State.IncCycles();
    // XOR DX,DX (1000_8EB2 / 0x18EB2)
    DX = 0;
    State.IncCycles();
    // DEC BX (1000_8EB4 / 0x18EB4)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JZ 0x1000:8eb9 (1000_8EB5 / 0x18EB5)
    if(ZeroFlag) {
      goto label_1000_8EB9_18EB9;
    }
    State.IncCycles();
    // DIV BX (1000_8EB7 / 0x18EB7)
    Cpu.Div16(BX);
    State.IncCycles();
    label_1000_8EB9_18EB9:
    // ADD AX,0x6 (1000_8EB9 / 0x18EB9)
    // AX += 0x6;
    AX = Alu.Add16(AX, 0x6);
    State.IncCycles();
    // STOSW ES:DI (1000_8EBC / 0x18EBC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,DX (1000_8EBD / 0x18EBD)
    AX = DX;
    State.IncCycles();
    // STOSW ES:DI (1000_8EBF / 0x18EBF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // POP DX (1000_8EC0 / 0x18EC0)
    DX = Stack.Pop();
    State.IncCycles();
    // INC DH (1000_8EC1 / 0x18EC1)
    DH++;
    State.IncCycles();
    // XOR DL,DL (1000_8EC3 / 0x18EC3)
    DL = 0;
    State.IncCycles();
    // MOV BX,word ptr [0x478f] (1000_8EC5 / 0x18EC5)
    BX = UInt16[DS, 0x478F];
    State.IncCycles();
    // RET  (1000_8EC9 / 0x18EC9)
    return NearRet();
    State.IncCycles();
    label_1000_8ECA_18ECA:
    // STOSW ES:DI (1000_8ECA / 0x18ECA)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_8ECB / 0x18ECB)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // INC DH (1000_8ECC / 0x18ECC)
    DH = Alu.Inc8(DH);
    State.IncCycles();
    // MOV BX,word ptr [0x478f] (1000_8ECE / 0x18ECE)
    BX = UInt16[DS, 0x478F];
    State.IncCycles();
    // RET  (1000_8ED2 / 0x18ED2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8ED3_018ED3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8ED3_18ED3:
    // XOR CX,CX (1000_8ED3 / 0x18ED3)
    CX = 0;
    State.IncCycles();
    // PUSH BX (1000_8ED5 / 0x18ED5)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,word ptr [0x47a0] (1000_8ED6 / 0x18ED6)
    BX = UInt16[DS, 0x47A0];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8EDA_018EDA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8EDA_018EDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8EDA_18EDA:
    // LODSB SI (1000_8EDA / 0x18EDA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0x20 (1000_8EDB / 0x18EDB)
    Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:8f25 (1000_8EDD / 0x18EDD)
    if(ZeroFlag) {
      goto label_1000_8F25_18F25;
    }
    State.IncCycles();
    // CMP AL,0xd (1000_8EDF / 0x18EDF)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JZ 0x1000:8f25 (1000_8EE1 / 0x18EE1)
    if(ZeroFlag) {
      goto label_1000_8F25_18F25;
    }
    State.IncCycles();
    // OR AL,AL (1000_8EE3 / 0x18EE3)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:8eed (1000_8EE5 / 0x18EE5)
    if(ZeroFlag) {
      goto label_1000_8EED_18EED;
    }
    State.IncCycles();
    // CMP AL,0x9 (1000_8EE7 / 0x18EE7)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JC 0x1000:8f09 (1000_8EE9 / 0x18EE9)
    if(CarryFlag) {
      goto label_1000_8F09_18F09;
    }
    State.IncCycles();
    // JS 0x1000:8f25 (1000_8EEB / 0x18EEB)
    if(SignFlag) {
      goto label_1000_8F25_18F25;
    }
    State.IncCycles();
    label_1000_8EED_18EED:
    // CMP word ptr [0x2518],0xd0ff (1000_8EED / 0x18EED)
    Alu.Sub16(UInt16[DS, 0x2518], 0xD0FF);
    State.IncCycles();
    // JNZ 0x1000:8f04 (1000_8EF3 / 0x18EF3)
    if(!ZeroFlag) {
      goto label_1000_8F04_18F04;
    }
    State.IncCycles();
    // CMP SI,0xa6b1 (1000_8EF5 / 0x18EF5)
    Alu.Sub16(SI, 0xA6B1);
    State.IncCycles();
    // JNZ 0x1000:8f04 (1000_8EF9 / 0x18EF9)
    if(!ZeroFlag) {
      goto label_1000_8F04_18F04;
    }
    State.IncCycles();
    // CALL 0x1000:d0e3 (1000_8EFB / 0x18EFB)
    NearCall(cs1, 0x8EFE, spice86_generated_label_call_target_1000_D0E3_01D0E3);
    State.IncCycles();
    label_1000_8EFE_18EFE:
    // JC 0x1000:8f04 (1000_8EFE / 0x18EFE)
    if(CarryFlag) {
      goto label_1000_8F04_18F04;
    }
    State.IncCycles();
    // ADD CL,AL (1000_8F00 / 0x18F00)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    State.IncCycles();
    // JMP 0x1000:8eda (1000_8F02 / 0x18F02)
    goto label_1000_8EDA_18EDA;
    State.IncCycles();
    label_1000_8F04_18F04:
    // XLAT BX (1000_8F04 / 0x18F04)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // ADD CL,AL (1000_8F05 / 0x18F05)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    State.IncCycles();
    // JMP 0x1000:8eda (1000_8F07 / 0x18F07)
    goto label_1000_8EDA_18EDA;
    State.IncCycles();
    label_1000_8F09_18F09:
    // CMP AL,0xd (1000_8F09 / 0x18F09)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JZ 0x1000:8f25 (1000_8F0B / 0x18F0B)
    if(ZeroFlag) {
      goto label_1000_8F25_18F25;
    }
    State.IncCycles();
    // CMP AL,0x6 (1000_8F0D / 0x18F0D)
    Alu.Sub8(AL, 0x6);
    State.IncCycles();
    // JZ 0x1000:8f1d (1000_8F0F / 0x18F0F)
    if(ZeroFlag) {
      goto label_1000_8F1D_18F1D;
    }
    State.IncCycles();
    // CMP AL,0x8 (1000_8F11 / 0x18F11)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNZ 0x1000:8eda (1000_8F13 / 0x18F13)
    if(!ZeroFlag) {
      goto label_1000_8EDA_18EDA;
    }
    State.IncCycles();
    // MOV word ptr [0x47a0],0xceec (1000_8F15 / 0x18F15)
    UInt16[DS, 0x47A0] = 0xCEEC;
    State.IncCycles();
    // JMP 0x1000:8eda (1000_8F1B / 0x18F1B)
    goto label_1000_8EDA_18EDA;
    State.IncCycles();
    label_1000_8F1D_18F1D:
    // MOV word ptr [0x47a0],0xcf6c (1000_8F1D / 0x18F1D)
    UInt16[DS, 0x47A0] = 0xCF6C;
    State.IncCycles();
    // JMP 0x1000:8eda (1000_8F23 / 0x18F23)
    goto label_1000_8EDA_18EDA;
    State.IncCycles();
    label_1000_8F25_18F25:
    // DEC SI (1000_8F25 / 0x18F25)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // POP BX (1000_8F26 / 0x18F26)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8F27 / 0x18F27)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8F28_018F28(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8F28_18F28:
    // MOV word ptr [0x479e],BP (1000_8F28 / 0x18F28)
    UInt16[DS, 0x479E] = BP;
    State.IncCycles();
    // MOV DI,0x1be2 (1000_8F2C / 0x18F2C)
    DI = 0x1BE2;
    State.IncCycles();
    // PUSH DS (1000_8F2F / 0x18F2F)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_8F30 / 0x18F30)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (1000_8F31 / 0x18F31)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // STOSW ES:DI (1000_8F34 / 0x18F34)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_8F35 / 0x18F35)
    DX = AX;
    State.IncCycles();
    // ADD AX,word ptr [0x4784] (1000_8F37 / 0x18F37)
    // AX += UInt16[DS, 0x4784];
    AX = Alu.Add16(AX, UInt16[DS, 0x4784]);
    State.IncCycles();
    // MOV [0x4791],AX (1000_8F3B / 0x18F3B)
    UInt16[DS, 0x4791] = AX;
    State.IncCycles();
    // MOV [0x4795],AX (1000_8F3E / 0x18F3E)
    UInt16[DS, 0x4795] = AX;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (1000_8F41 / 0x18F41)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // STOSW ES:DI (1000_8F44 / 0x18F44)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_8F45 / 0x18F45)
    BX = AX;
    State.IncCycles();
    // ADD AX,word ptr [0x4788] (1000_8F47 / 0x18F47)
    // AX += UInt16[DS, 0x4788];
    AX = Alu.Add16(AX, UInt16[DS, 0x4788]);
    State.IncCycles();
    // MOV [0x4793],AX (1000_8F4B / 0x18F4B)
    UInt16[DS, 0x4793] = AX;
    State.IncCycles();
    // MOV [0x4797],AX (1000_8F4E / 0x18F4E)
    UInt16[DS, 0x4797] = AX;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x4] (1000_8F51 / 0x18F51)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // ADD DX,AX (1000_8F54 / 0x18F54)
    DX += AX;
    State.IncCycles();
    // SUB AX,word ptr [0x4784] (1000_8F56 / 0x18F56)
    AX -= UInt16[DS, 0x4784];
    State.IncCycles();
    // SUB AX,word ptr [0x4786] (1000_8F5A / 0x18F5A)
    // AX -= UInt16[DS, 0x4786];
    AX = Alu.Sub16(AX, UInt16[DS, 0x4786]);
    State.IncCycles();
    // MOV [0x478f],AX (1000_8F5E / 0x18F5E)
    UInt16[DS, 0x478F] = AX;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x6] (1000_8F61 / 0x18F61)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // ADD BX,AX (1000_8F64 / 0x18F64)
    BX += AX;
    State.IncCycles();
    // SUB AX,word ptr [0x4788] (1000_8F66 / 0x18F66)
    AX -= UInt16[DS, 0x4788];
    State.IncCycles();
    // SUB AX,word ptr [0x478a] (1000_8F6A / 0x18F6A)
    // AX -= UInt16[DS, 0x478A];
    AX = Alu.Sub16(AX, UInt16[DS, 0x478A]);
    State.IncCycles();
    // MOV [0x478d],AX (1000_8F6E / 0x18F6E)
    UInt16[DS, 0x478D] = AX;
    State.IncCycles();
    // MOV AX,DX (1000_8F71 / 0x18F71)
    AX = DX;
    State.IncCycles();
    // CMP AX,0x140 (1000_8F73 / 0x18F73)
    Alu.Sub16(AX, 0x140);
    State.IncCycles();
    // JC 0x1000:8f7b (1000_8F76 / 0x18F76)
    if(CarryFlag) {
      goto label_1000_8F7B_18F7B;
    }
    State.IncCycles();
    // MOV AX,0x140 (1000_8F78 / 0x18F78)
    AX = 0x140;
    State.IncCycles();
    label_1000_8F7B_18F7B:
    // STOSW ES:DI (1000_8F7B / 0x18F7B)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,BX (1000_8F7C / 0x18F7C)
    AX = BX;
    State.IncCycles();
    // STOSW ES:DI (1000_8F7E / 0x18F7E)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_8F7F / 0x18F7F)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8fd1 (1000_8F84 / 0x18F84)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_8FD1_18FD1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0xc6],0x0 (1000_8F86 / 0x18F86)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8ff5 (1000_8F8B / 0x18F8B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8FF5_018FF5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_8F8D / 0x18F8D)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8fd0 (1000_8F92 / 0x18F92)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8FD0 / 0x18FD0)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x46d9],0x0 (1000_8F94 / 0x18F94)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:8fd0 (1000_8F99 / 0x18F99)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8FD0 / 0x18FD0)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x28e7],0x0 (1000_8F9B / 0x18F9B)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    State.IncCycles();
    // JZ 0x1000:900b (1000_8FA0 / 0x18FA0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_900B_01900B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH SI (1000_8FA2 / 0x18FA2)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x4c60 (1000_8FA3 / 0x18FA3)
    SI = 0x4C60;
    State.IncCycles();
    // MOV BP,0x1be2 (1000_8FA6 / 0x18FA6)
    BP = 0x1BE2;
    State.IncCycles();
    // MOV AX,0x80 (1000_8FA9 / 0x18FA9)
    AX = 0x80;
    State.IncCycles();
    // MOV word ptr [BP + 0x8],AX (1000_8FAC / 0x18FAC)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    State.IncCycles();
    // MOV [0x1c06],AX (1000_8FAF / 0x18FAF)
    UInt16[DS, 0x1C06] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0xc],0x9468 (1000_8FB2 / 0x18FB2)
    UInt16[SS, (ushort)(BP + 0xC)] = 0x9468;
    State.IncCycles();
    // MOV ES,word ptr [0xdbde] (1000_8FB7 / 0x18FB7)
    ES = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // CALLF [0x3919] (1000_8FBB / 0x18FBB)
    // Indirect call to [0x3919], generating possible targets from emulator records
    uint targetAddress_1000_8FBB = (uint)(UInt16[DS, 0x391B] * 0x10 + UInt16[DS, 0x3919] - cs1 * 0x10);
    switch(targetAddress_1000_8FBB) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8FBB));
        break;
    }
    State.IncCycles();
    // CALL 0x1000:c137 (1000_8FBF / 0x18FBF)
    NearCall(cs1, 0x8FC2, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    // MOV SI,0x1be2 (1000_8FC2 / 0x18FC2)
    SI = 0x1BE2;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd6] (1000_8FC5 / 0x18FC5)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // MOV AX,0x1c (1000_8FC9 / 0x18FC9)
    AX = 0x1C;
    State.IncCycles();
    // CALL 0x1000:c370 (1000_8FCC / 0x18FCC)
    NearCall(cs1, 0x8FCF, spice86_generated_label_call_target_1000_C370_01C370);
    State.IncCycles();
    // POP SI (1000_8FCF / 0x18FCF)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_8FD0_18FD0:
    // RET  (1000_8FD0 / 0x18FD0)
    return NearRet();
  }
  
  public virtual Action spice86_label_1000_8FD1_18FD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8FD1_18FD1:
    // PUSH SI (1000_8FD1 / 0x18FD1)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x1be2 (1000_8FD2 / 0x18FD2)
    SI = 0x1BE2;
    State.IncCycles();
    // MOV word ptr [SI + 0x8],0x80 (1000_8FD5 / 0x18FD5)
    UInt16[DS, (ushort)(SI + 0x8)] = 0x80;
    State.IncCycles();
    // MOV word ptr [SI + 0xc],0x7bed (1000_8FDA / 0x18FDA)
    UInt16[DS, (ushort)(SI + 0xC)] = 0x7BED;
    State.IncCycles();
    // SUB word ptr [SI + 0x2],0x2 (1000_8FDF / 0x18FDF)
    // UInt16[DS, (ushort)(SI + 0x2)] -= 0x2;
    UInt16[DS, (ushort)(SI + 0x2)] = Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], 0x2);
    State.IncCycles();
    // MOV AL,[0x18f2] (1000_8FE3 / 0x18FE3)
    AL = UInt8[DS, 0x18F2];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_8FE6 / 0x18FE6)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x38dd] (1000_8FEA / 0x18FEA)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_8FEA = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_8FEA) {
      case 0x235CE : FarCall(cs1, 0x8FEE, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8FEA));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8FEE_018FEE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8FEE_018FEE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8FEE_18FEE:
    // ADD word ptr [0x1be4],0x2 (1000_8FEE / 0x18FEE)
    // UInt16[DS, 0x1BE4] += 0x2;
    UInt16[DS, 0x1BE4] = Alu.Add16(UInt16[DS, 0x1BE4], 0x2);
    State.IncCycles();
    // POP SI (1000_8FF3 / 0x18FF3)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8FF4 / 0x18FF4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8FF5_018FF5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8FF5_18FF5:
    // PUSH SI (1000_8FF5 / 0x18FF5)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AX,0x32 (1000_8FF6 / 0x18FF6)
    AX = 0x32;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_8FF9 / 0x18FF9)
    NearCall(cs1, 0x8FFC, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8FFC_018FFC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8FFC_018FFC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8FFC_18FFC:
    // MOV AX,0x3 (1000_8FFC / 0x18FFC)
    AX = 0x3;
    State.IncCycles();
    // MOV SI,0x2265 (1000_8FFF / 0x18FFF)
    SI = 0x2265;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd6] (1000_9002 / 0x19002)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALL 0x1000:c370 (1000_9006 / 0x19006)
    NearCall(cs1, 0x9009, spice86_generated_label_call_target_1000_C370_01C370);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9009_019009, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9009_019009(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9009_19009:
    // POP SI (1000_9009 / 0x19009)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_900A / 0x1900A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_900B_01900B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_900B_1900B:
    // MOV DI,0x4c60 (1000_900B / 0x1900B)
    DI = 0x4C60;
    State.IncCycles();
    // MOV CX,0x5960 (1000_900E / 0x1900E)
    CX = 0x5960;
    State.IncCycles();
    // PUSH DS (1000_9011 / 0x19011)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_9012 / 0x19012)
    ES = Stack.Pop();
    State.IncCycles();
    // XOR AL,AL (1000_9013 / 0x19013)
    AL = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_9015 / 0x19015)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV AX,0x4c6f (1000_9017 / 0x19017)
    AX = 0x4C6F;
    State.IncCycles();
    // AND AL,0xf0 (1000_901A / 0x1901A)
    // AL &= 0xF0;
    AL = Alu.And8(AL, 0xF0);
    State.IncCycles();
    // MOV [0x22fc],AX (1000_901C / 0x1901C)
    UInt16[DS, 0x22FC] = AX;
    State.IncCycles();
    // CALL 0x1000:c085 (1000_901F / 0x1901F)
    NearCall(cs1, 0x9022, spice86_generated_label_call_target_1000_C085_01C085);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9022_019022, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9022_019022(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9022_19022:
    // JMP 0x1000:8895 (1000_9022 / 0x19022)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8895_018895, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9025_019025(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9025_19025:
    // MOV CX,word ptr [0x4793] (1000_9025 / 0x19025)
    CX = UInt16[DS, 0x4793];
    State.IncCycles();
    // MOV BX,0x92 (1000_9029 / 0x19029)
    BX = 0x92;
    State.IncCycles();
    // SUB BX,CX (1000_902C / 0x1902C)
    BX -= CX;
    State.IncCycles();
    // XOR DX,DX (1000_902E / 0x1902E)
    DX = 0;
    State.IncCycles();
    // MOV CH,0xff (1000_9030 / 0x19030)
    CH = 0xFF;
    State.IncCycles();
    // MOV DI,0x140 (1000_9032 / 0x19032)
    DI = 0x140;
    State.IncCycles();
    // MOV SI,word ptr [0x22fc] (1000_9035 / 0x19035)
    SI = UInt16[DS, 0x22FC];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_9039 / 0x19039)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV word ptr [0x4782],BX (1000_903D / 0x1903D)
    UInt16[DS, 0x4782] = BX;
    State.IncCycles();
    // CALLF [0x38c9] (1000_9041 / 0x19041)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_9041 = (uint)(UInt16[DS, 0x38CB] * 0x10 + UInt16[DS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_9041) {
      case 0x235BF : FarCall(cs1, 0x9045, spice86_generated_label_call_target_334B_010F_0335BF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9041));
        break;
    }
    State.IncCycles();
    label_1000_9045_19045:
    // RET  (1000_9045 / 0x19045)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9046_019046(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9046_19046:
    // PUSH DS (1000_9046 / 0x19046)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_9047 / 0x19047)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV AX,[0x4793] (1000_9048 / 0x19048)
    AX = UInt16[DS, 0x4793];
    State.IncCycles();
    // MUL word ptr [0x2240] (1000_904B / 0x1904B)
    Cpu.Mul16(UInt16[DS, 0x2240]);
    State.IncCycles();
    // MOV CX,AX (1000_904F / 0x1904F)
    CX = AX;
    State.IncCycles();
    // MOV DI,word ptr [0x22fc] (1000_9051 / 0x19051)
    DI = UInt16[DS, 0x22FC];
    State.IncCycles();
    // MOV AX,0xf00f (1000_9055 / 0x19055)
    AX = 0xF00F;
    State.IncCycles();
    // XOR BX,BX (1000_9058 / 0x19058)
    BX = 0;
    State.IncCycles();
    // CMP byte ptr [0xea],0x0 (1000_905A / 0x1905A)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    State.IncCycles();
    // JLE 0x1000:9063 (1000_905F / 0x1905F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9063_19063;
    }
    State.IncCycles();
    // MOV AH,0x8 (1000_9061 / 0x19061)
    AH = 0x8;
    State.IncCycles();
    label_1000_9063_19063:
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_9063 / 0x19063)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // JNZ 0x1000:908b (1000_9065 / 0x19065)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_908B / 0x1908B)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI + -0x2],BL (1000_9067 / 0x19067)
    Alu.Sub8(UInt8[DS, (ushort)(DI - 0x2)], BL);
    State.IncCycles();
    // JNZ 0x1000:906f (1000_906A / 0x1906A)
    if(!ZeroFlag) {
      goto label_1000_906F_1906F;
    }
    State.IncCycles();
    // MOV byte ptr [DI + -0x2],AH (1000_906C / 0x1906C)
    UInt8[DS, (ushort)(DI - 0x2)] = AH;
    State.IncCycles();
    label_1000_906F_1906F:
    // CMP byte ptr [DI],BL (1000_906F / 0x1906F)
    Alu.Sub8(UInt8[DS, DI], BL);
    State.IncCycles();
    // JNZ 0x1000:9075 (1000_9071 / 0x19071)
    if(!ZeroFlag) {
      goto label_1000_9075_19075;
    }
    State.IncCycles();
    // MOV byte ptr [DI],AH (1000_9073 / 0x19073)
    UInt8[DS, DI] = AH;
    State.IncCycles();
    label_1000_9075_19075:
    // CMP byte ptr [DI + 0xfebf],BL (1000_9075 / 0x19075)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0xFEBF)], BL);
    State.IncCycles();
    // JNZ 0x1000:907f (1000_9079 / 0x19079)
    if(!ZeroFlag) {
      goto label_1000_907F_1907F;
    }
    State.IncCycles();
    // MOV byte ptr [DI + 0xfebf],AH (1000_907B / 0x1907B)
    UInt8[DS, (ushort)(DI + 0xFEBF)] = AH;
    State.IncCycles();
    label_1000_907F_1907F:
    // CMP byte ptr [DI + 0x13f],BL (1000_907F / 0x1907F)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x13F)], BL);
    State.IncCycles();
    // JNZ 0x1000:9063 (1000_9083 / 0x19083)
    if(!ZeroFlag) {
      goto label_1000_9063_19063;
    }
    State.IncCycles();
    // MOV byte ptr [DI + 0x13f],AH (1000_9085 / 0x19085)
    UInt8[DS, (ushort)(DI + 0x13F)] = AH;
    State.IncCycles();
    // JMP 0x1000:9063 (1000_9089 / 0x19089)
    goto label_1000_9063_19063;
    State.IncCycles();
    label_1000_908B_1908B:
    // RET  (1000_908B / 0x1908B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_908C_01908C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_908C_1908C:
    // MOV AX,[0xd83a] (1000_908C / 0x1908C)
    AX = UInt16[DS, 0xD83A];
    State.IncCycles();
    // CMP AX,word ptr [0x4782] (1000_908F / 0x1908F)
    Alu.Sub16(AX, UInt16[DS, 0x4782]);
    State.IncCycles();
    // JBE 0x1000:90bc (1000_9093 / 0x19093)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_90BC / 0x190BC)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x479e],0x223c (1000_9095 / 0x19095)
    Alu.Sub16(UInt16[DS, 0x479E], 0x223C);
    State.IncCycles();
    // JNZ 0x1000:90bc (1000_909B / 0x1909B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_90BC / 0x190BC)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,word ptr [0x4793] (1000_909D / 0x1909D)
    CX = UInt16[DS, 0x4793];
    State.IncCycles();
    // MOV BX,0x92 (1000_90A1 / 0x190A1)
    BX = 0x92;
    State.IncCycles();
    // SUB BX,CX (1000_90A4 / 0x190A4)
    BX -= CX;
    State.IncCycles();
    // XOR DX,DX (1000_90A6 / 0x190A6)
    DX = 0;
    State.IncCycles();
    // MOV CH,0xff (1000_90A8 / 0x190A8)
    CH = 0xFF;
    State.IncCycles();
    // MOV DI,0x140 (1000_90AA / 0x190AA)
    DI = 0x140;
    State.IncCycles();
    // MOV SI,word ptr [0x22fc] (1000_90AD / 0x190AD)
    SI = UInt16[DS, 0x22FC];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_90B1 / 0x190B1)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV BP,0xd834 (1000_90B5 / 0x190B5)
    BP = 0xD834;
    State.IncCycles();
    // CALLF [0x38cd] (1000_90B8 / 0x190B8)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_90B8 = (uint)(UInt16[DS, 0x38CF] * 0x10 + UInt16[DS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_90B8) {
      case 0x235C2 : FarCall(cs1, 0x90BC, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_90B8));
        break;
    }
    State.IncCycles();
    label_1000_90BC_190BC:
    // RET  (1000_90BC / 0x190BC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_90BD_0190BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_90BD_190BD:
    // MOV AL,byte ptr [SI + 0xe] (1000_90BD / 0x190BD)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // CMP AL,0xc (1000_90C0 / 0x190C0)
    Alu.Sub8(AL, 0xC);
    State.IncCycles();
    // JZ 0x1000:90d9 (1000_90C2 / 0x190C2)
    if(ZeroFlag) {
      goto label_1000_90D9_190D9;
    }
    State.IncCycles();
    // TEST word ptr [0x12],0x1000 (1000_90C4 / 0x190C4)
    Alu.And16(UInt16[DS, 0x12], 0x1000);
    State.IncCycles();
    // JZ 0x1000:90d9 (1000_90CA / 0x190CA)
    if(ZeroFlag) {
      goto label_1000_90D9_190D9;
    }
    State.IncCycles();
    // MOV BX,0x9c (1000_90CC / 0x190CC)
    BX = 0x9C;
    State.IncCycles();
    // MOV DX,0x9584 (1000_90CF / 0x190CF)
    DX = 0x9584;
    State.IncCycles();
    // TEST byte ptr [0x10a7],0x10 (1000_90D2 / 0x190D2)
    Alu.And8(UInt8[DS, 0x10A7], 0x10);
    State.IncCycles();
    // JZ 0x1000:9111 (1000_90D7 / 0x190D7)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    State.IncCycles();
    label_1000_90D9_190D9:
    // CMP AL,0xf (1000_90D9 / 0x190D9)
    Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // MOV BX,0x93 (1000_90DB / 0x190DB)
    BX = 0x93;
    State.IncCycles();
    // MOV DX,0x5a03 (1000_90DE / 0x190DE)
    DX = 0x5A03;
    State.IncCycles();
    // JZ 0x1000:9111 (1000_90E1 / 0x190E1)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    State.IncCycles();
    // CMP AL,0xe (1000_90E3 / 0x190E3)
    Alu.Sub8(AL, 0xE);
    State.IncCycles();
    // JNZ 0x1000:90f7 (1000_90E5 / 0x190E5)
    if(!ZeroFlag) {
      goto label_1000_90F7_190F7;
    }
    State.IncCycles();
    // MOV BX,0x96 (1000_90E7 / 0x190E7)
    BX = 0x96;
    State.IncCycles();
    // MOV DX,0x95c1 (1000_90EA / 0x190EA)
    DX = 0x95C1;
    State.IncCycles();
    // TEST byte ptr [0xa],0x10 (1000_90ED / 0x190ED)
    Alu.And8(UInt8[DS, 0xA], 0x10);
    State.IncCycles();
    // JZ 0x1000:9111 (1000_90F2 / 0x190F2)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    State.IncCycles();
    // INC BX (1000_90F4 / 0x190F4)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // JMP 0x1000:9111 (1000_90F5 / 0x190F5)
    goto label_1000_9111_19111;
    State.IncCycles();
    label_1000_90F7_190F7:
    // MOV CL,byte ptr [SI + 0xf] (1000_90F7 / 0x190F7)
    CL = UInt8[DS, (ushort)(SI + 0xF)];
    State.IncCycles();
    // MOV BX,0x4091 (1000_90FA / 0x190FA)
    BX = 0x4091;
    State.IncCycles();
    // TEST CL,0x80 (1000_90FD / 0x190FD)
    Alu.And8(CL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:9111 (1000_9100 / 0x19100)
    if(!ZeroFlag) {
      goto label_1000_9111_19111;
    }
    State.IncCycles();
    // AND BH,0xbf (1000_9102 / 0x19102)
    // BH &= 0xBF;
    BH = Alu.And8(BH, 0xBF);
    State.IncCycles();
    // MOV DX,0x95e2 (1000_9105 / 0x19105)
    DX = 0x95E2;
    State.IncCycles();
    // TEST CL,0x40 (1000_9108 / 0x19108)
    Alu.And8(CL, 0x40);
    State.IncCycles();
    // JZ 0x1000:9111 (1000_910B / 0x1910B)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    State.IncCycles();
    // INC BX (1000_910D / 0x1910D)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // MOV DX,0x9533 (1000_910E / 0x1910E)
    DX = 0x9533;
    State.IncCycles();
    label_1000_9111_19111:
    // MOV BP,0x1f7e (1000_9111 / 0x19111)
    BP = 0x1F7E;
    State.IncCycles();
    // MOV word ptr [BP + 0x6],BX (1000_9114 / 0x19114)
    UInt16[SS, (ushort)(BP + 0x6)] = BX;
    State.IncCycles();
    // MOV word ptr [BP + 0x8],DX (1000_9117 / 0x19117)
    UInt16[SS, (ushort)(BP + 0x8)] = DX;
    State.IncCycles();
    // CALL 0x1000:d316 (1000_911A / 0x1911A)
    NearCall(cs1, 0x911D, spice86_generated_label_call_target_1000_D316_01D316);
    State.IncCycles();
    label_1000_911D_1911D:
    // MOV BX,0x97cf (1000_911D / 0x1911D)
    BX = 0x97CF;
    State.IncCycles();
    // JMP 0x1000:d338 (1000_9120 / 0x19120)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D338_01D338, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9123_019123(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9123_19123:
    // CMP AL,0x11 (1000_9123 / 0x19123)
    Alu.Sub8(AL, 0x11);
    State.IncCycles();
    // JNC 0x1000:917a (1000_9125 / 0x19125)
    if(!CarryFlag) {
      goto label_1000_917A_1917A;
    }
    State.IncCycles();
    // XOR AH,AH (1000_9127 / 0x19127)
    AH = 0;
    State.IncCycles();
    // CMP AL,0xd (1000_9129 / 0x19129)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JC 0x1000:9173 (1000_912B / 0x1912B)
    if(CarryFlag) {
      goto label_1000_9173_19173;
    }
    State.IncCycles();
    // JNZ 0x1000:913b (1000_912D / 0x1912D)
    if(!ZeroFlag) {
      goto label_1000_913B_1913B;
    }
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_912F / 0x1912F)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // MOV AH,byte ptr [DI] (1000_9133 / 0x19133)
    AH = UInt8[DS, DI];
    State.IncCycles();
    // SHR AH,1 (1000_9135 / 0x19135)
    AH >>= 0x1;
    State.IncCycles();
    // INC AH (1000_9137 / 0x19137)
    AH = Alu.Inc8(AH);
    State.IncCycles();
    // JMP 0x1000:9173 (1000_9139 / 0x19139)
    goto label_1000_9173_19173;
    State.IncCycles();
    label_1000_913B_1913B:
    // MOV SI,word ptr [0x4756] (1000_913B / 0x1913B)
    SI = UInt16[DS, 0x4756];
    State.IncCycles();
    // CMP AL,0xe (1000_913F / 0x1913F)
    Alu.Sub8(AL, 0xE);
    State.IncCycles();
    // JZ 0x1000:9155 (1000_9141 / 0x19141)
    if(ZeroFlag) {
      goto label_1000_9155_19155;
    }
    State.IncCycles();
    // CMP byte ptr [0x2a],0xc8 (1000_9143 / 0x19143)
    Alu.Sub8(UInt8[DS, 0x2A], 0xC8);
    State.IncCycles();
    // JZ 0x1000:9173 (1000_9148 / 0x19148)
    if(ZeroFlag) {
      goto label_1000_9173_19173;
    }
    State.IncCycles();
    // MOV AL,[0x476c] (1000_914A / 0x1914A)
    AL = UInt8[DS, 0x476C];
    State.IncCycles();
    // SHL AX,1 (1000_914D / 0x1914D)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV SI,AX (1000_914F / 0x1914F)
    SI = AX;
    State.IncCycles();
    // MOV SI,word ptr [SI + 0x4758] (1000_9151 / 0x19151)
    SI = UInt16[DS, (ushort)(SI + 0x4758)];
    State.IncCycles();
    label_1000_9155_19155:
    // MOV AL,byte ptr [SI] (1000_9155 / 0x19155)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // PUSH DX (1000_9157 / 0x19157)
    Stack.Push(DX);
    State.IncCycles();
    // MOV DL,0x3 (1000_9158 / 0x19158)
    DL = 0x3;
    State.IncCycles();
    // DIV DL (1000_915A / 0x1915A)
    Cpu.Div8(DL);
    State.IncCycles();
    // MOV DL,0xf (1000_915C / 0x1915C)
    DL = 0xF;
    State.IncCycles();
    // OR AH,AH (1000_915E / 0x1915E)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x1000:9164 (1000_9160 / 0x19160)
    if(ZeroFlag) {
      goto label_1000_9164_19164;
    }
    State.IncCycles();
    // MOV DL,0x11 (1000_9162 / 0x19162)
    DL = 0x11;
    State.IncCycles();
    label_1000_9164_19164:
    // CMP AL,DL (1000_9164 / 0x19164)
    Alu.Sub8(AL, DL);
    State.IncCycles();
    // JC 0x1000:916c (1000_9166 / 0x19166)
    if(CarryFlag) {
      goto label_1000_916C_1916C;
    }
    State.IncCycles();
    // SUB AL,DL (1000_9168 / 0x19168)
    // AL -= DL;
    AL = Alu.Sub8(AL, DL);
    State.IncCycles();
    // JMP 0x1000:9164 (1000_916A / 0x1916A)
    goto label_1000_9164_19164;
    State.IncCycles();
    label_1000_916C_1916C:
    // POP DX (1000_916C / 0x1916C)
    DX = Stack.Pop();
    State.IncCycles();
    // XCHG AH,AL (1000_916D / 0x1916D)
    byte tmp_1000_916D = AH;
    AH = AL;
    AL = tmp_1000_916D;
    State.IncCycles();
    // ADD AL,0xe (1000_916F / 0x1916F)
    AL += 0xE;
    State.IncCycles();
    label_1000_9171_19171:
    // INC AH (1000_9171 / 0x19171)
    AH = Alu.Inc8(AH);
    State.IncCycles();
    label_1000_9173_19173:
    // MOV byte ptr [0x47d0],AH (1000_9173 / 0x19173)
    UInt8[DS, 0x47D0] = AH;
    State.IncCycles();
    // XOR AH,AH (1000_9177 / 0x19177)
    AH = 0;
    State.IncCycles();
    // RET  (1000_9179 / 0x19179)
    return NearRet();
    State.IncCycles();
    label_1000_917A_1917A:
    // MOV AX,[0x2] (1000_917A / 0x1917A)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // SHL AX,1 (1000_917D / 0x1917D)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_917F / 0x1917F)
    AX <<= 0x1;
    State.IncCycles();
    // CMP AH,0x8 (1000_9181 / 0x19181)
    Alu.Sub8(AH, 0x8);
    State.IncCycles();
    // JC 0x1000:9188 (1000_9184 / 0x19184)
    if(CarryFlag) {
      goto label_1000_9188_19188;
    }
    State.IncCycles();
    // MOV AH,0x8 (1000_9186 / 0x19186)
    AH = 0x8;
    State.IncCycles();
    label_1000_9188_19188:
    // SHL AH,1 (1000_9188 / 0x19188)
    AH <<= 0x1;
    State.IncCycles();
    // CMP byte ptr [0xf4],0x10 (1000_918A / 0x1918A)
    Alu.Sub8(UInt8[DS, 0xF4], 0x10);
    State.IncCycles();
    // CMC  (1000_918F / 0x1918F)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // ADC AH,0x0 (1000_9190 / 0x19190)
    AH = Alu.Adc8(AH, 0x0);
    State.IncCycles();
    // MOV AL,0x2d (1000_9193 / 0x19193)
    AL = 0x2D;
    State.IncCycles();
    // JMP 0x1000:9171 (1000_9195 / 0x19195)
    goto label_1000_9171_19171;
  }
  
}
