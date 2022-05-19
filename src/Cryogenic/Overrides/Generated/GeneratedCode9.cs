namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_7C56_017C56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C56_17C56:
    // CMP byte ptr [0x46eb],0x0 (1000_7C56 / 0x17C56)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:7c60 (1000_7C5B / 0x17C5B)
    if(!SignFlag) {
      // JNS target is JMP, inlining.
      // JMP 0x1000:c07c (1000_7C60 / 0x17C60)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:9901 (1000_7C5D / 0x17C5D)
    NearCall(cs1, 0x7C60, spice86_generated_label_call_target_1000_9901_019901);
    label_1000_7C60_17C60:
    // JMP 0x1000:c07c (1000_7C60 / 0x17C60)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7C63_017C63(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C63_17C63:
    // PUSH SI (1000_7C63 / 0x17C63)
    Stack.Push(SI);
    // CALL 0x1000:407e (1000_7C64 / 0x17C64)
    NearCall(cs1, 0x7C67, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C67_017C67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C67_017C67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C67_17C67:
    // POP SI (1000_7C67 / 0x17C67)
    SI = Stack.Pop();
    // MOV BP,BX (1000_7C68 / 0x17C68)
    BP = BX;
    // SHL BP,1 (1000_7C6A / 0x17C6A)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // JNS 0x1000:7c70 (1000_7C6C / 0x17C6C)
    if(!SignFlag) {
      goto label_1000_7C70_17C70;
    }
    // NEG BP (1000_7C6E / 0x17C6E)
    BP = Alu.Sub16(0, BP);
    label_1000_7C70_17C70:
    // MOV BP,word ptr [BP + 0x4880] (1000_7C70 / 0x17C70)
    BP = UInt16[SS, (ushort)(BP + 0x4880)];
    // MOV AX,word ptr [SI + 0x6] (1000_7C74 / 0x17C74)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB AX,DX (1000_7C77 / 0x17C77)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    // JNS 0x1000:7c7d (1000_7C79 / 0x17C79)
    if(!SignFlag) {
      goto label_1000_7C7D_17C7D;
    }
    // NEG AX (1000_7C7B / 0x17C7B)
    AX = Alu.Sub16(0, AX);
    label_1000_7C7D_17C7D:
    // XOR DX,DX (1000_7C7D / 0x17C7D)
    DX = 0;
    // DIV BP (1000_7C7F / 0x17C7F)
    Cpu.Div16(BP);
    // SUB BX,word ptr [SI + 0x8] (1000_7C81 / 0x17C81)
    // BX -= UInt16[DS, (ushort)(SI + 0x8)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x8)]);
    // JNS 0x1000:7c88 (1000_7C84 / 0x17C84)
    if(!SignFlag) {
      goto label_1000_7C88_17C88;
    }
    // NEG BX (1000_7C86 / 0x17C86)
    BX = Alu.Sub16(0, BX);
    label_1000_7C88_17C88:
    // CMP AX,BX (1000_7C88 / 0x17C88)
    Alu.Sub16(AX, BX);
    // JNC 0x1000:7c8e (1000_7C8A / 0x17C8A)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_7C8E / 0x17C8E)
      return NearRet();
    }
    // MOV AX,BX (1000_7C8C / 0x17C8C)
    AX = BX;
    label_1000_7C8E_17C8E:
    // RET  (1000_7C8E / 0x17C8E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7C8F_017C8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C8F_17C8F:
    // PUSH SI (1000_7C8F / 0x17C8F)
    Stack.Push(SI);
    // CALL 0x1000:407e (1000_7C90 / 0x17C90)
    NearCall(cs1, 0x7C93, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C93_017C93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C93_017C93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7C93_17C93:
    // POP SI (1000_7C93 / 0x17C93)
    SI = Stack.Pop();
    // MOV BP,BX (1000_7C94 / 0x17C94)
    BP = BX;
    // SHL BP,1 (1000_7C96 / 0x17C96)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // JNS 0x1000:7c9c (1000_7C98 / 0x17C98)
    if(!SignFlag) {
      goto label_1000_7C9C_17C9C;
    }
    // NEG BP (1000_7C9A / 0x17C9A)
    BP = Alu.Sub16(0, BP);
    label_1000_7C9C_17C9C:
    // MOV BP,word ptr [BP + 0x4880] (1000_7C9C / 0x17C9C)
    BP = UInt16[SS, (ushort)(BP + 0x4880)];
    // MOV AX,word ptr [SI + 0x2] (1000_7CA0 / 0x17CA0)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB AX,DX (1000_7CA3 / 0x17CA3)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    // JNS 0x1000:7ca9 (1000_7CA5 / 0x17CA5)
    if(!SignFlag) {
      goto label_1000_7CA9_17CA9;
    }
    // NEG AX (1000_7CA7 / 0x17CA7)
    AX = Alu.Sub16(0, AX);
    label_1000_7CA9_17CA9:
    // XOR DX,DX (1000_7CA9 / 0x17CA9)
    DX = 0;
    // DIV BP (1000_7CAB / 0x17CAB)
    Cpu.Div16(BP);
    // SUB BX,word ptr [SI + 0x4] (1000_7CAD / 0x17CAD)
    // BX -= UInt16[DS, (ushort)(SI + 0x4)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JNS 0x1000:7cb4 (1000_7CB0 / 0x17CB0)
    if(!SignFlag) {
      goto label_1000_7CB4_17CB4;
    }
    // NEG BX (1000_7CB2 / 0x17CB2)
    BX = Alu.Sub16(0, BX);
    label_1000_7CB4_17CB4:
    // CMP AX,BX (1000_7CB4 / 0x17CB4)
    Alu.Sub16(AX, BX);
    // JNC 0x1000:7cba (1000_7CB6 / 0x17CB6)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_7CBA / 0x17CBA)
      return NearRet();
    }
    // MOV AX,BX (1000_7CB8 / 0x17CB8)
    AX = BX;
    label_1000_7CBA_17CBA:
    // RET  (1000_7CBA / 0x17CBA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7CBB_017CBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CBB_17CBB:
    // MOV byte ptr [0x46f5],0x1 (1000_7CBB / 0x17CBB)
    UInt8[DS, 0x46F5] = 0x1;
    // MOV BP,0x2012 (1000_7CC0 / 0x17CC0)
    BP = 0x2012;
    // MOV BX,0x7d68 (1000_7CC3 / 0x17CC3)
    BX = 0x7D68;
    // CALL 0x1000:d323 (1000_7CC6 / 0x17CC6)
    NearCall(cs1, 0x7CC9, spice86_generated_label_call_target_1000_D323_01D323);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CC9_017CC9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CC9_017CC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CC9_17CC9:
    // CALL 0x1000:c13b (1000_7CC9 / 0x17CC9)
    NearCall(cs1, 0x7CCC, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CCC_017CCC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CCC_017CCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CCC_17CCC:
    // CMP byte ptr [0x46f4],0x0 (1000_7CCC / 0x17CCC)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    // JNZ 0x1000:7cf1 (1000_7CD1 / 0x17CD1)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,word ptr [0x46ef] (1000_7CD3 / 0x17CD3)
    SI = UInt16[DS, 0x46EF];
    // CALL 0x1000:7be0 (1000_7CD7 / 0x17CD7)
    NearCall(cs1, 0x7CDA, spice86_generated_label_call_target_1000_7BE0_017BE0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CDA_017CDA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CDA_017CDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CDA_17CDA:
    // CALL 0x1000:7c02 (1000_7CDA / 0x17CDA)
    NearCall(cs1, 0x7CDD, spice86_generated_label_call_target_1000_7C02_017C02);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CDD_017CDD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CDD_017CDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CDD_17CDD:
    // CMP byte ptr [0x46f4],0x0 (1000_7CDD / 0x17CDD)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    // JNZ 0x1000:7cf1 (1000_7CE2 / 0x17CE2)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:7c02 (1000_7CE4 / 0x17CE4)
    NearCall(cs1, 0x7CE7, spice86_generated_label_call_target_1000_7C02_017C02);
    // CMP byte ptr [0x46f4],0x0 (1000_7CE7 / 0x17CE7)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    // JNZ 0x1000:7cf1 (1000_7CEC / 0x17CEC)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:7c02 (1000_7CEE / 0x17CEE)
    NearCall(cs1, 0x7CF1, spice86_generated_label_call_target_1000_7C02_017C02);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_7CF1_017CF1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CF1_17CF1:
    // CALL 0x1000:7dd9 (1000_7CF1 / 0x17CF1)
    NearCall(cs1, 0x7CF4, spice86_generated_label_call_target_1000_7DD9_017DD9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CF4_017CF4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CF4_017CF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CF4_17CF4:
    // CALL 0x1000:68eb (1000_7CF4 / 0x17CF4)
    NearCall(cs1, 0x7CF7, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CF7_017CF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CF7_017CF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7CF7_17CF7:
    // MOV AL,byte ptr [SI + 0x19] (1000_7CF7 / 0x17CF7)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // MOV [0x3d],AL (1000_7CFA / 0x17CFA)
    UInt8[DS, 0x3D] = AL;
    // CALL 0x1000:7efb (1000_7CFD / 0x17CFD)
    NearCall(cs1, 0x7D00, spice86_generated_label_call_target_1000_7EFB_017EFB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D00_017D00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D00_017D00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D00_17D00:
    // MOV DI,word ptr [SI + 0x4] (1000_7D00 / 0x17D00)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:7f27 (1000_7D03 / 0x17D03)
    NearCall(cs1, 0x7D06, spice86_generated_label_call_target_1000_7F27_017F27);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D06_017D06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D06_017D06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D06_17D06:
    // MOV word ptr [0x1bea],0x0 (1000_7D06 / 0x17D06)
    UInt16[DS, 0x1BEA] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7D0C_017D0C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7D0C_017D0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D0C_17D0C:
    // CALL 0x1000:c08e (1000_7D0C / 0x17D0C)
    NearCall(cs1, 0x7D0F, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D0F_017D0F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D0F_017D0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D0F_17D0F:
    // MOV SI,0x1936 (1000_7D0F / 0x17D0F)
    SI = 0x1936;
    // CALL 0x1000:7b1b (1000_7D12 / 0x17D12)
    NearCall(cs1, 0x7D15, spice86_generated_label_call_target_1000_7B1B_017B1B);
    label_1000_7D15_17D15:
    // MOV SI,0x1940 (1000_7D15 / 0x17D15)
    SI = 0x1940;
    // CALL 0x1000:7b1b (1000_7D18 / 0x17D18)
    NearCall(cs1, 0x7D1B, spice86_generated_label_call_target_1000_7B1B_017B1B);
    label_1000_7D1B_17D1B:
    // CALL 0x1000:7e1e (1000_7D1B / 0x17D1B)
    NearCall(cs1, 0x7D1E, spice86_generated_label_call_target_1000_7E1E_017E1E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D1E_017D1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D1E_017D1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D1E_17D1E:
    // PUSH DS (1000_7D1E / 0x17D1E)
    Stack.Push(DS);
    // POP ES (1000_7D1F / 0x17D1F)
    ES = Stack.Pop();
    // MOV SI,0x4c60 (1000_7D20 / 0x17D20)
    SI = 0x4C60;
    // MOV DI,0x4c7c (1000_7D23 / 0x17D23)
    DI = 0x4C7C;
    // MOV CX,0xe (1000_7D26 / 0x17D26)
    CX = 0xE;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_7D29 / 0x17D29)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // MOV BX,word ptr [0x1942] (1000_7D2B / 0x17D2B)
    BX = UInt16[DS, 0x1942];
    // ADD BX,0x4 (1000_7D2F / 0x17D2F)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    // MOV DX,word ptr [0x1940] (1000_7D32 / 0x17D32)
    DX = UInt16[DS, 0x1940];
    // ADD DX,0x50 (1000_7D36 / 0x17D36)
    // DX += 0x50;
    DX = Alu.Add16(DX, 0x50);
    // MOV SI,0x46fe (1000_7D39 / 0x17D39)
    SI = 0x46FE;
    // MOV BP,word ptr [0x1946] (1000_7D3C / 0x17D3C)
    BP = UInt16[DS, 0x1946];
    // MOV CX,word ptr [0x1948] (1000_7D40 / 0x17D40)
    CX = UInt16[DS, 0x1948];
    // MOV word ptr [0xdbe4],CX (1000_7D44 / 0x17D44)
    UInt16[DS, 0xDBE4] = CX;
    // CALL 0x1000:7e3d (1000_7D48 / 0x17D48)
    NearCall(cs1, 0x7D4B, spice86_generated_label_call_target_1000_7E3D_017E3D);
    label_1000_7D4B_17D4B:
    // MOV CX,word ptr [0x1948] (1000_7D4B / 0x17D4B)
    CX = UInt16[DS, 0x1948];
    // MOV DX,word ptr [0x1940] (1000_7D4F / 0x17D4F)
    DX = UInt16[DS, 0x1940];
    // ADD DX,0x8 (1000_7D53 / 0x17D53)
    // DX += 0x8;
    DX = Alu.Add16(DX, 0x8);
    // MOV AX,0x6f (1000_7D56 / 0x17D56)
    AX = 0x6F;
    // CALL 0x1000:d194 (1000_7D59 / 0x17D59)
    NearCall(cs1, 0x7D5C, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_7D5C_17D5C:
    // CALL 0x1000:e270 (1000_7D5C / 0x17D5C)
    NearCall(cs1, 0x7D5F, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_7D5F_17D5F:
    // CALL 0x1000:d280 (1000_7D5F / 0x17D5F)
    NearCall(cs1, 0x7D62, spice86_generated_label_call_target_1000_D280_01D280);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D62_017D62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D62_017D62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D62_17D62:
    // CALL 0x1000:e283 (1000_7D62 / 0x17D62)
    NearCall(cs1, 0x7D65, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_7D65_17D65:
    // JMP 0x1000:c07c (1000_7D65 / 0x17D65)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7D68_017D68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D68_17D68:
    // MOV byte ptr [0x46f5],0x0 (1000_7D68 / 0x17D68)
    UInt8[DS, 0x46F5] = 0x0;
    // XOR SI,SI (1000_7D6D / 0x17D6D)
    SI = 0;
    // MOV word ptr [0xdbe2],0x0 (1000_7D6F / 0x17D6F)
    UInt16[DS, 0xDBE2] = 0x0;
    // MOV SI,0x1940 (1000_7D75 / 0x17D75)
    SI = 0x1940;
    // CALL 0x1000:c6ad (1000_7D78 / 0x17D78)
    NearCall(cs1, 0x7D7B, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D7B_017D7B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D7B_017D7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7D7B_17D7B:
    // CALL 0x1000:68eb (1000_7D7B / 0x17D7B)
    NearCall(cs1, 0x7D7E, spice86_generated_label_call_target_1000_68EB_0168EB);
    label_1000_7D7E_17D7E:
    // CALL 0x1000:7f11 (1000_7D7E / 0x17D7E)
    NearCall(cs1, 0x7D81, spice86_generated_label_call_target_1000_7F11_017F11);
    label_1000_7D81_17D81:
    // CALL 0x1000:8461 (1000_7D81 / 0x17D81)
    NearCall(cs1, 0x7D84, spice86_generated_label_call_target_1000_8461_018461);
    label_1000_7D84_17D84:
    // MOV AH,byte ptr [SI + 0x19] (1000_7D84 / 0x17D84)
    AH = UInt8[DS, (ushort)(SI + 0x19)];
    // MOV AL,[0x3d] (1000_7D87 / 0x17D87)
    AL = UInt8[DS, 0x3D];
    // MOV BL,AL (1000_7D8A / 0x17D8A)
    BL = AL;
    // XOR BL,AH (1000_7D8C / 0x17D8C)
    BL ^= AH;
    // AND AH,BL (1000_7D8E / 0x17D8E)
    // AH &= BL;
    AH = Alu.And8(AH, BL);
    // MOV byte ptr [0x3d],AH (1000_7D90 / 0x17D90)
    UInt8[DS, 0x3D] = AH;
    // AND AL,BL (1000_7D94 / 0x17D94)
    // AL &= BL;
    AL = Alu.And8(AL, BL);
    // MOV [0x3e],AL (1000_7D96 / 0x17D96)
    UInt8[DS, 0x3E] = AL;
    // MOV byte ptr [0x3f],0x0 (1000_7D99 / 0x17D99)
    UInt8[DS, 0x3F] = 0x0;
    // TEST AH,0x40 (1000_7D9E / 0x17D9E)
    Alu.And8(AH, 0x40);
    // JZ 0x1000:7db1 (1000_7DA1 / 0x17DA1)
    if(ZeroFlag) {
      goto label_1000_7DB1_17DB1;
    }
    // MOV DI,word ptr [SI + 0x4] (1000_7DA3 / 0x17DA3)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP DI,word ptr [0x1150] (1000_7DA6 / 0x17DA6)
    Alu.Sub16(DI, UInt16[DS, 0x1150]);
    // JNZ 0x1000:7db1 (1000_7DAA / 0x17DAA)
    if(!ZeroFlag) {
      goto label_1000_7DB1_17DB1;
    }
    // MOV byte ptr [0x3f],0x40 (1000_7DAC / 0x17DAC)
    UInt8[DS, 0x3F] = 0x40;
    label_1000_7DB1_17DB1:
    // MOV AL,byte ptr [SI + 0x3] (1000_7DB1 / 0x17DB1)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_7DB4 / 0x17DB4)
    AL &= 0xF;
    // CMP AL,0x8 (1000_7DB6 / 0x17DB6)
    Alu.Sub8(AL, 0x8);
    // JNZ 0x1000:7dbd (1000_7DB8 / 0x17DB8)
    if(!ZeroFlag) {
      goto label_1000_7DBD_17DBD;
    }
    // CALL 0x1000:6c15 (1000_7DBA / 0x17DBA)
    NearCall(cs1, 0x7DBD, spice86_generated_label_call_target_1000_6C15_016C15);
    label_1000_7DBD_17DBD:
    // MOV AL,0xc (1000_7DBD / 0x17DBD)
    AL = 0xC;
    // CALL 0x1000:7bb9 (1000_7DBF / 0x17DBF)
    NearCall(cs1, 0x7DC2, spice86_generated_label_call_target_1000_7BB9_017BB9);
    label_1000_7DC2_17DC2:
    // MOV byte ptr [0x46f4],0x0 (1000_7DC2 / 0x17DC2)
    UInt8[DS, 0x46F4] = 0x0;
    // CMP word ptr [0x1bea],0x0 (1000_7DC7 / 0x17DC7)
    Alu.Sub16(UInt16[DS, 0x1BEA], 0x0);
    // JNZ 0x1000:7dd8 (1000_7DCC / 0x17DCC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_7DD8 / 0x17DD8)
      return NearRet();
    }
    // MOV SI,word ptr [0x46ef] (1000_7DCE / 0x17DCE)
    SI = UInt16[DS, 0x46EF];
    // CALL 0x1000:7be0 (1000_7DD2 / 0x17DD2)
    NearCall(cs1, 0x7DD5, spice86_generated_label_call_target_1000_7BE0_017BE0);
    // CALL 0x1000:7c02 (1000_7DD5 / 0x17DD5)
    NearCall(cs1, 0x7DD8, spice86_generated_label_call_target_1000_7C02_017C02);
    label_1000_7DD8_17DD8:
    // RET  (1000_7DD8 / 0x17DD8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7DD9_017DD9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7DD9_17DD9:
    // MOV SI,0x18e9 (1000_7DD9 / 0x17DD9)
    SI = 0x18E9;
    // MOV DI,0x1936 (1000_7DDC / 0x17DDC)
    DI = 0x1936;
    // MOV BP,0x1940 (1000_7DDF / 0x17DDF)
    BP = 0x1940;
    // MOV word ptr [0xdbe2],BP (1000_7DE2 / 0x17DE2)
    UInt16[DS, 0xDBE2] = BP;
    // MOV AX,word ptr [SI] (1000_7DE6 / 0x17DE6)
    AX = UInt16[DS, SI];
    // ADD AX,0x30 (1000_7DE8 / 0x17DE8)
    // AX += 0x30;
    AX = Alu.Add16(AX, 0x30);
    // MOV word ptr [BP + 0x0],AX (1000_7DEB / 0x17DEB)
    UInt16[SS, BP] = AX;
    // ADD AX,0x4d (1000_7DEE / 0x17DEE)
    // AX += 0x4D;
    AX = Alu.Add16(AX, 0x4D);
    // MOV word ptr [DI],AX (1000_7DF1 / 0x17DF1)
    UInt16[DS, DI] = AX;
    // MOV AX,word ptr [SI + 0x4] (1000_7DF3 / 0x17DF3)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV word ptr [DI + 0x4],AX (1000_7DF6 / 0x17DF6)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    // MOV word ptr [BP + 0x4],AX (1000_7DF9 / 0x17DF9)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV AX,word ptr [SI + 0x2] (1000_7DFC / 0x17DFC)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // ADD AX,0x2b (1000_7DFF / 0x17DFF)
    // AX += 0x2B;
    AX = Alu.Add16(AX, 0x2B);
    // MOV word ptr [DI + 0x2],AX (1000_7E02 / 0x17E02)
    UInt16[DS, (ushort)(DI + 0x2)] = AX;
    // MOV AX,word ptr [SI + 0x6] (1000_7E05 / 0x17E05)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV word ptr [DI + 0x6],AX (1000_7E08 / 0x17E08)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    // INC AX (1000_7E0B / 0x17E0B)
    AX++;
    // CMP AX,0x70 (1000_7E0C / 0x17E0C)
    Alu.Sub16(AX, 0x70);
    // JC 0x1000:7e14 (1000_7E0F / 0x17E0F)
    if(CarryFlag) {
      goto label_1000_7E14_17E14;
    }
    // SUB AX,0x6d (1000_7E11 / 0x17E11)
    // AX -= 0x6D;
    AX = Alu.Sub16(AX, 0x6D);
    label_1000_7E14_17E14:
    // MOV word ptr [BP + 0x2],AX (1000_7E14 / 0x17E14)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // ADD AX,0x28 (1000_7E17 / 0x17E17)
    // AX += 0x28;
    AX = Alu.Add16(AX, 0x28);
    // MOV word ptr [BP + 0x6],AX (1000_7E1A / 0x17E1A)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    // RET  (1000_7E1D / 0x17E1D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7E1E_017E1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E1E_17E1E:
    // CALL 0x1000:d068 (1000_7E1E / 0x17E1E)
    NearCall(cs1, 0x7E21, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7E21_017E21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7E21_017E21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E21_17E21:
    // MOV SI,0x4705 (1000_7E21 / 0x17E21)
    SI = 0x4705;
    // MOV DX,word ptr [0x18e9] (1000_7E24 / 0x17E24)
    DX = UInt16[DS, 0x18E9];
    // MOV BX,word ptr [0x18eb] (1000_7E28 / 0x17E28)
    BX = UInt16[DS, 0x18EB];
    // ADD DX,0x80 (1000_7E2C / 0x17E2C)
    DX += 0x80;
    // ADD BX,0x2d (1000_7E30 / 0x17E30)
    // BX += 0x2D;
    BX = Alu.Add16(BX, 0x2D);
    // MOV BP,word ptr [0x18ef] (1000_7E33 / 0x17E33)
    BP = UInt16[DS, 0x18EF];
    // MOV word ptr [0xdbe4],0xf0 (1000_7E37 / 0x17E37)
    UInt16[DS, 0xDBE4] = 0xF0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7E3D_017E3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7E3D_017E3D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E3D_17E3D:
    // CALL 0x1000:c13b (1000_7E3D / 0x17E3D)
    NearCall(cs1, 0x7E40, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7E40_017E40, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7E40_017E40(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E40_17E40:
    // PUSH DI (1000_7E40 / 0x17E40)
    Stack.Push(DI);
    // PUSH DS (1000_7E41 / 0x17E41)
    Stack.Push(DS);
    // POP ES (1000_7E42 / 0x17E42)
    ES = Stack.Pop();
    // MOV DI,0x4c60 (1000_7E43 / 0x17E43)
    DI = 0x4C60;
    // MOV CX,0xe (1000_7E46 / 0x17E46)
    CX = 0xE;
    // XOR AX,AX (1000_7E49 / 0x17E49)
    AX = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_7E4B / 0x17E4B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // MOV DI,SI (1000_7E4D / 0x17E4D)
    DI = SI;
    // MOV CX,0x7 (1000_7E4F / 0x17E4F)
    CX = 0x7;
    // XOR AL,AL (1000_7E52 / 0x17E52)
    AL = 0;
    // REPE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_7E54 / 0x17E54)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    // JNZ 0x1000:7e69 (1000_7E56 / 0x17E56)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E69_017E69, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD BX,0x5 (1000_7E58 / 0x17E58)
    BX += 0x5;
    // ADD DX,0xc (1000_7E5B / 0x17E5B)
    // DX += 0xC;
    DX = Alu.Add16(DX, 0xC);
    // CALL 0x1000:d04e (1000_7E5E / 0x17E5E)
    NearCall(cs1, 0x7E61, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7E61_017E61, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7E61_017E61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E61_17E61:
    // MOV AX,0x69 (1000_7E61 / 0x17E61)
    AX = 0x69;
    // CALL 0x1000:d19b (1000_7E64 / 0x17E64)
    NearCall(cs1, 0x7E67, spice86_generated_label_ret_target_1000_D19B_01D19B);
    label_1000_7E67_17E67:
    // POP DI (1000_7E67 / 0x17E67)
    DI = Stack.Pop();
    // RET  (1000_7E68 / 0x17E68)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7E69_017E69(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E69_17E69:
    // XOR DI,DI (1000_7E69 / 0x17E69)
    DI = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E6B_017E6B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7E6B_017E6B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E6B_17E6B:
    // MOV AL,byte ptr [SI] (1000_7E6B / 0x17E6B)
    AL = UInt8[DS, SI];
    // OR AL,AL (1000_7E6D / 0x17E6D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:7e8e (1000_7E6F / 0x17E6F)
    if(ZeroFlag) {
      goto label_1000_7E8E_17E8E;
    }
    // MOV CL,AL (1000_7E71 / 0x17E71)
    CL = AL;
    // PUSH SI (1000_7E73 / 0x17E73)
    Stack.Push(SI);
    // PUSH DI (1000_7E74 / 0x17E74)
    Stack.Push(DI);
    // PUSH BP (1000_7E75 / 0x17E75)
    Stack.Push(BP);
    // MOV AL,byte ptr [DI + 0x192f] (1000_7E76 / 0x17E76)
    AL = UInt8[DS, (ushort)(DI + 0x192F)];
    // XOR AH,AH (1000_7E7A / 0x17E7A)
    AH = 0;
    // SHL DI,1 (1000_7E7C / 0x17E7C)
    DI <<= 0x1;
    // SHL DI,1 (1000_7E7E / 0x17E7E)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    // MOV word ptr [DI + 0x4c60],DX (1000_7E80 / 0x17E80)
    UInt16[DS, (ushort)(DI + 0x4C60)] = DX;
    // CALL 0x1000:61d3 (1000_7E84 / 0x17E84)
    NearCall(cs1, 0x7E87, spice86_generated_label_call_target_1000_61D3_0161D3);
    label_1000_7E87_17E87:
    // MOV word ptr [DI + 0x4c62],DX (1000_7E87 / 0x17E87)
    UInt16[DS, (ushort)(DI + 0x4C62)] = DX;
    // POP BP (1000_7E8B / 0x17E8B)
    BP = Stack.Pop();
    // POP DI (1000_7E8C / 0x17E8C)
    DI = Stack.Pop();
    // POP SI (1000_7E8D / 0x17E8D)
    SI = Stack.Pop();
    label_1000_7E8E_17E8E:
    // INC SI (1000_7E8E / 0x17E8E)
    SI++;
    // INC DI (1000_7E8F / 0x17E8F)
    DI++;
    // CMP DI,0x7 (1000_7E90 / 0x17E90)
    Alu.Sub16(DI, 0x7);
    // JC 0x1000:7e6b (1000_7E93 / 0x17E93)
    if(CarryFlag) {
      goto label_1000_7E6B_17E6B;
    }
    // POP DI (1000_7E95 / 0x17E95)
    DI = Stack.Pop();
    // RET  (1000_7E96 / 0x17E96)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7E97_017E97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7E97_17E97:
    // CMP byte ptr [0x46f5],0x0 (1000_7E97 / 0x17E97)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    // JZ 0x1000:7ee1 (1000_7E9C / 0x17E9C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // MOV DI,0x1936 (1000_7E9E / 0x17E9E)
    DI = 0x1936;
    // CALL 0x1000:d6fe (1000_7EA1 / 0x17EA1)
    NearCall(cs1, 0x7EA4, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_7EA4_17EA4:
    // JNC 0x1000:7ee1 (1000_7EA4 / 0x17EA4)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // MOV SI,0x4c7c (1000_7EA6 / 0x17EA6)
    SI = 0x4C7C;
    // CALL 0x1000:7ee2 (1000_7EA9 / 0x17EA9)
    NearCall(cs1, 0x7EAC, spice86_generated_label_call_target_1000_7EE2_017EE2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7EAC_017EAC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7EAC_017EAC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7EAC_17EAC:
    // JNC 0x1000:7ee1 (1000_7EAC / 0x17EAC)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // DEC byte ptr [DI + 0x4705] (1000_7EAE / 0x17EAE)
    UInt8[DS, (ushort)(DI + 0x4705)]--;
    // INC byte ptr [DI + 0x46fe] (1000_7EB2 / 0x17EB2)
    UInt8[DS, (ushort)(DI + 0x46FE)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0x46FE)]);
    // JMP 0x1000:7ede (1000_7EB6 / 0x17EB6)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7ECD_017ECD, 0x17EDE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7EB8_017EB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7EB8_17EB8:
    // CMP byte ptr [0x46f5],0x0 (1000_7EB8 / 0x17EB8)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    // JZ 0x1000:7ee1 (1000_7EBD / 0x17EBD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // MOV DI,0x1940 (1000_7EBF / 0x17EBF)
    DI = 0x1940;
    // CALL 0x1000:d6fe (1000_7EC2 / 0x17EC2)
    NearCall(cs1, 0x7EC5, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_7EC5_17EC5:
    // JNC 0x1000:7ee1 (1000_7EC5 / 0x17EC5)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // MOV SI,0x4c60 (1000_7EC7 / 0x17EC7)
    SI = 0x4C60;
    // CALL 0x1000:7ee2 (1000_7ECA / 0x17ECA)
    NearCall(cs1, 0x7ECD, spice86_generated_label_call_target_1000_7EE2_017EE2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7ECD_017ECD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7ECD_017ECD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x7EE1: goto label_1000_7EE1_17EE1;break; // Target of external jump from 0x17EEF
      case 0x7EDE: goto label_1000_7EDE_17EDE;break; // Target of external jump from 0x17EB6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_7ECD_17ECD:
    // JNC 0x1000:7ee1 (1000_7ECD / 0x17ECD)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // CMP byte ptr [DI + 0x4705],0x0 (1000_7ECF / 0x17ECF)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x4705)], 0x0);
    // JNZ 0x1000:7ee1 (1000_7ED4 / 0x17ED4)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    // INC byte ptr [DI + 0x4705] (1000_7ED6 / 0x17ED6)
    UInt8[DS, (ushort)(DI + 0x4705)]++;
    // DEC byte ptr [DI + 0x46fe] (1000_7EDA / 0x17EDA)
    UInt8[DS, (ushort)(DI + 0x46FE)] = Alu.Dec8(UInt8[DS, (ushort)(DI + 0x46FE)]);
    label_1000_7EDE_17EDE:
    // CALL 0x1000:7d0c (1000_7EDE / 0x17EDE)
    NearCall(cs1, 0x7EE1, spice86_generated_label_call_target_1000_7D0C_017D0C);
    label_1000_7EE1_17EE1:
    // RET  (1000_7EE1 / 0x17EE1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7EE2_017EE2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7EE2_17EE2:
    // XOR DI,DI (1000_7EE2 / 0x17EE2)
    DI = 0;
    label_1000_7EE4_17EE4:
    // LODSW SI (1000_7EE4 / 0x17EE4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_7EE5 / 0x17EE5)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:7ef1 (1000_7EE7 / 0x17EE7)
    if(ZeroFlag) {
      goto label_1000_7EF1_17EF1;
    }
    // CMP DX,AX (1000_7EE9 / 0x17EE9)
    Alu.Sub16(DX, AX);
    // JC 0x1000:7ef1 (1000_7EEB / 0x17EEB)
    if(CarryFlag) {
      goto label_1000_7EF1_17EF1;
    }
    // CMP DX,word ptr [SI] (1000_7EED / 0x17EED)
    Alu.Sub16(DX, UInt16[DS, SI]);
    // JC 0x1000:7ee1 (1000_7EEF / 0x17EEF)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    label_1000_7EF1_17EF1:
    // ADD SI,0x2 (1000_7EF1 / 0x17EF1)
    SI += 0x2;
    // INC DI (1000_7EF4 / 0x17EF4)
    DI++;
    // CMP DI,0x7 (1000_7EF5 / 0x17EF5)
    Alu.Sub16(DI, 0x7);
    // JC 0x1000:7ee4 (1000_7EF8 / 0x17EF8)
    if(CarryFlag) {
      goto label_1000_7EE4_17EE4;
    }
    // RET  (1000_7EFA / 0x17EFA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7EFB_017EFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7EFB_17EFB:
    // PUSH DI (1000_7EFB / 0x17EFB)
    Stack.Push(DI);
    // PUSH DS (1000_7EFC / 0x17EFC)
    Stack.Push(DS);
    // POP ES (1000_7EFD / 0x17EFD)
    ES = Stack.Pop();
    // MOV DI,0x4705 (1000_7EFE / 0x17EFE)
    DI = 0x4705;
    // MOV AH,byte ptr [SI + 0x19] (1000_7F01 / 0x17F01)
    AH = UInt8[DS, (ushort)(SI + 0x19)];
    label_1000_7F04_17F04:
    // XOR AL,AL (1000_7F04 / 0x17F04)
    AL = 0;
    // ROL AX,1 (1000_7F06 / 0x17F06)
    AX = Alu.Rol16(AX, 0x1);
    // STOSB ES:DI (1000_7F08 / 0x17F08)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP DI,0x470c (1000_7F09 / 0x17F09)
    Alu.Sub16(DI, 0x470C);
    // JC 0x1000:7f04 (1000_7F0D / 0x17F0D)
    if(CarryFlag) {
      goto label_1000_7F04_17F04;
    }
    // POP DI (1000_7F0F / 0x17F0F)
    DI = Stack.Pop();
    // RET  (1000_7F10 / 0x17F10)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7F11_017F11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7F11_17F11:
    // PUSH SI (1000_7F11 / 0x17F11)
    Stack.Push(SI);
    // MOV SI,0x470b (1000_7F12 / 0x17F12)
    SI = 0x470B;
    // STD  (1000_7F15 / 0x17F15)
    DirectionFlag = true;
    // XOR AX,AX (1000_7F16 / 0x17F16)
    AX = 0;
    label_1000_7F18_17F18:
    // LODSB SI (1000_7F18 / 0x17F18)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // ROR AX,1 (1000_7F19 / 0x17F19)
    AX = Alu.Ror16(AX, 0x1);
    // CMP SI,0x4705 (1000_7F1B / 0x17F1B)
    Alu.Sub16(SI, 0x4705);
    // JNC 0x1000:7f18 (1000_7F1F / 0x17F1F)
    if(!CarryFlag) {
      goto label_1000_7F18_17F18;
    }
    // POP SI (1000_7F21 / 0x17F21)
    SI = Stack.Pop();
    // CLD  (1000_7F22 / 0x17F22)
    DirectionFlag = false;
    // MOV byte ptr [SI + 0x19],AH (1000_7F23 / 0x17F23)
    UInt8[DS, (ushort)(SI + 0x19)] = AH;
    // RET  (1000_7F26 / 0x17F26)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7F27_017F27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7F27_17F27:
    // MOV BX,0x46fe (1000_7F27 / 0x17F27)
    BX = 0x46FE;
    // PUSH DI (1000_7F2A / 0x17F2A)
    Stack.Push(DI);
    // PUSH DS (1000_7F2B / 0x17F2B)
    Stack.Push(DS);
    // POP ES (1000_7F2C / 0x17F2C)
    ES = Stack.Pop();
    // MOV AL,byte ptr [DI + 0x9] (1000_7F2D / 0x17F2D)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // LEA SI,[DI + 0x14] (1000_7F30 / 0x17F30)
    SI = (ushort)(DI + 0x14);
    // MOV DI,BX (1000_7F33 / 0x17F33)
    DI = BX;
    // MOV CX,0x7 (1000_7F35 / 0x17F35)
    CX = 0x7;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_7F38 / 0x17F38)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7F3A_017F3A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7F3A_017F3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7F3A_17F3A:
    // OR AL,AL (1000_7F3A / 0x17F3A)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:7f5d (1000_7F3C / 0x17F3C)
    if(ZeroFlag) {
      goto label_1000_7F5D_17F5D;
    }
    // CALL 0x1000:6906 (1000_7F3E / 0x17F3E)
    NearCall(cs1, 0x7F41, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_7F41_17F41:
    // MOV AL,byte ptr [SI + 0x19] (1000_7F41 / 0x17F41)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // MOV DI,BX (1000_7F44 / 0x17F44)
    DI = BX;
    // SHL AL,1 (1000_7F46 / 0x17F46)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JNC 0x1000:7f51 (1000_7F48 / 0x17F48)
    if(!CarryFlag) {
      goto label_1000_7F51_17F51;
    }
    label_1000_7F4A_17F4A:
    // SUB byte ptr [DI],0x1 (1000_7F4A / 0x17F4A)
    // UInt8[DS, DI] -= 0x1;
    UInt8[DS, DI] = Alu.Sub8(UInt8[DS, DI], 0x1);
    // JNC 0x1000:7f51 (1000_7F4D / 0x17F4D)
    if(!CarryFlag) {
      goto label_1000_7F51_17F51;
    }
    // INC byte ptr [DI] (1000_7F4F / 0x17F4F)
    UInt8[DS, DI]++;
    label_1000_7F51_17F51:
    // INC DI (1000_7F51 / 0x17F51)
    DI++;
    // SHL AL,1 (1000_7F52 / 0x17F52)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JC 0x1000:7f4a (1000_7F54 / 0x17F54)
    if(CarryFlag) {
      goto label_1000_7F4A_17F4A;
    }
    // JNZ 0x1000:7f51 (1000_7F56 / 0x17F56)
    if(!ZeroFlag) {
      goto label_1000_7F51_17F51;
    }
    // MOV AL,byte ptr [SI + 0x1] (1000_7F58 / 0x17F58)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // JMP 0x1000:7f3a (1000_7F5B / 0x17F5B)
    goto label_1000_7F3A_17F3A;
    label_1000_7F5D_17F5D:
    // POP DI (1000_7F5D / 0x17F5D)
    DI = Stack.Pop();
    // RET  (1000_7F5E / 0x17F5E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_7F5F_017F5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7F5F_17F5F:
    // MOV AL,byte ptr [SI + 0x19] (1000_7F5F / 0x17F5F)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // PUSH DI (1000_7F62 / 0x17F62)
    Stack.Push(DI);
    // ADD DI,0x14 (1000_7F63 / 0x17F63)
    DI += 0x14;
    // SHL AL,1 (1000_7F66 / 0x17F66)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JNC 0x1000:7f6c (1000_7F68 / 0x17F68)
    if(!CarryFlag) {
      goto label_1000_7F6C_17F6C;
    }
    label_1000_7F6A_17F6A:
    // INC byte ptr [DI] (1000_7F6A / 0x17F6A)
    UInt8[DS, DI]++;
    label_1000_7F6C_17F6C:
    // INC DI (1000_7F6C / 0x17F6C)
    DI++;
    // SHL AL,1 (1000_7F6D / 0x17F6D)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JC 0x1000:7f6a (1000_7F6F / 0x17F6F)
    if(CarryFlag) {
      goto label_1000_7F6A_17F6A;
    }
    // JNZ 0x1000:7f6c (1000_7F71 / 0x17F71)
    if(!ZeroFlag) {
      goto label_1000_7F6C_17F6C;
    }
    // POP DI (1000_7F73 / 0x17F73)
    DI = Stack.Pop();
    // RET  (1000_7F74 / 0x17F74)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_7F75_017F75(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7F75_17F75:
    // MOV AL,byte ptr [SI + 0x19] (1000_7F75 / 0x17F75)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // PUSH DI (1000_7F78 / 0x17F78)
    Stack.Push(DI);
    // ADD DI,0x14 (1000_7F79 / 0x17F79)
    DI += 0x14;
    // SHL AL,1 (1000_7F7C / 0x17F7C)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JNC 0x1000:7f87 (1000_7F7E / 0x17F7E)
    if(!CarryFlag) {
      goto label_1000_7F87_17F87;
    }
    label_1000_7F80_17F80:
    // SUB byte ptr [DI],0x1 (1000_7F80 / 0x17F80)
    // UInt8[DS, DI] -= 0x1;
    UInt8[DS, DI] = Alu.Sub8(UInt8[DS, DI], 0x1);
    // JNC 0x1000:7f87 (1000_7F83 / 0x17F83)
    if(!CarryFlag) {
      goto label_1000_7F87_17F87;
    }
    // INC byte ptr [DI] (1000_7F85 / 0x17F85)
    UInt8[DS, DI]++;
    label_1000_7F87_17F87:
    // INC DI (1000_7F87 / 0x17F87)
    DI++;
    // SHL AL,1 (1000_7F88 / 0x17F88)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JC 0x1000:7f80 (1000_7F8A / 0x17F8A)
    if(CarryFlag) {
      goto label_1000_7F80_17F80;
    }
    // JNZ 0x1000:7f87 (1000_7F8C / 0x17F8C)
    if(!ZeroFlag) {
      goto label_1000_7F87_17F87;
    }
    // POP DI (1000_7F8E / 0x17F8E)
    DI = Stack.Pop();
    // RET  (1000_7F8F / 0x17F8F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_80DF_0180DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_80DF_180DF:
    // PUSH AX (1000_80DF / 0x180DF)
    Stack.Push(AX);
    // CALL 0x1000:c08e (1000_80E0 / 0x180E0)
    NearCall(cs1, 0x80E3, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:8fd1 (1000_80E3 / 0x180E3)
    NearCall(cs1, 0x80E6, spice86_label_1000_8FD1_18FD1);
    // POP BX (1000_80E6 / 0x180E6)
    BX = Stack.Pop();
    // MOV SI,0x2244 (1000_80E7 / 0x180E7)
    SI = 0x2244;
    // MOV AX,word ptr [SI + 0x2] (1000_80EA / 0x180EA)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // PUSH AX (1000_80ED / 0x180ED)
    Stack.Push(AX);
    // PUSH word ptr [SI + 0x6] (1000_80EE / 0x180EE)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x6)]);
    // PUSH BX (1000_80F1 / 0x180F1)
    Stack.Push(BX);
    // CMP AX,0x32 (1000_80F2 / 0x180F2)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:80fa (1000_80F5 / 0x180F5)
    if(CarryFlag) {
      goto label_1000_80FA_180FA;
    }
    // ADD AX,0x26 (1000_80F7 / 0x180F7)
    // AX += 0x26;
    AX = Alu.Add16(AX, 0x26);
    label_1000_80FA_180FA:
    // MOV word ptr [SI + 0x2],AX (1000_80FA / 0x180FA)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // MOV word ptr [SI + 0x6],0x19 (1000_80FD / 0x180FD)
    UInt16[DS, (ushort)(SI + 0x6)] = 0x19;
    // CALL 0x1000:9f82 (1000_8102 / 0x18102)
    NearCall(cs1, 0x8105, spice86_generated_label_call_target_1000_9F82_019F82);
    // POP AX (1000_8105 / 0x18105)
    AX = Stack.Pop();
    // CALL 0x1000:88af (1000_8106 / 0x18106)
    NearCall(cs1, 0x8109, spice86_generated_label_call_target_1000_88AF_0188AF);
    // CMP byte ptr [0x4774],0x0 (1000_8109 / 0x18109)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JNZ 0x1000:811e (1000_810E / 0x1810E)
    if(!ZeroFlag) {
      goto label_1000_811E_1811E;
    }
    // MOV AX,0x10a (1000_8110 / 0x18110)
    AX = 0x10A;
    // ADD AX,word ptr [0xd810] (1000_8113 / 0x18113)
    AX += UInt16[DS, 0xD810];
    // ADD word ptr [0x4780],AX (1000_8117 / 0x18117)
    // UInt16[DS, 0x4780] += AX;
    UInt16[DS, 0x4780] = Alu.Add16(UInt16[DS, 0x4780], AX);
    // CALL 0x1000:9efd (1000_811B / 0x1811B)
    NearCall(cs1, 0x811E, spice86_generated_label_call_target_1000_9EFD_019EFD);
    label_1000_811E_1811E:
    // POP word ptr [0x224a] (1000_811E / 0x1811E)
    UInt16[DS, 0x224A] = Stack.Pop();
    // POP word ptr [0x2246] (1000_8122 / 0x18122)
    UInt16[DS, 0x2246] = Stack.Pop();
    // CALL 0x1000:c07c (1000_8126 / 0x18126)
    NearCall(cs1, 0x8129, spice86_generated_label_call_target_1000_C07C_01C07C);
    // MOV word ptr [0x4720],0x18f3 (1000_8129 / 0x18129)
    UInt16[DS, 0x4720] = 0x18F3;
    // MOV byte ptr [0x4722],0x0 (1000_812F / 0x1812F)
    UInt8[DS, 0x4722] = 0x0;
    // CALL 0x1000:541f (1000_8134 / 0x18134)
    NearCall(cs1, 0x8137, not_observed_1000_541F_01541F);
    // MOV word ptr [0x1bea],0x0 (1000_8137 / 0x18137)
    UInt16[DS, 0x1BEA] = 0x0;
    // RET  (1000_813D / 0x1813D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_813E_01813E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_813E_1813E:
    // SUB SP,0x30 (1000_813E / 0x1813E)
    // SP -= 0x30;
    SP = Alu.Sub16(SP, 0x30);
    // MOV DI,SP (1000_8141 / 0x18141)
    DI = SP;
    // CALL 0x1000:68eb (1000_8143 / 0x18143)
    NearCall(cs1, 0x8146, spice86_generated_label_call_target_1000_68EB_0168EB);
    // MOV DX,word ptr [SI + 0x6] (1000_8146 / 0x18146)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV BX,word ptr [SI + 0x8] (1000_8149 / 0x18149)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    // CALL 0x1000:81d7 (1000_814C / 0x1814C)
    NearCall(cs1, 0x814F, not_observed_1000_81D7_0181D7);
    // CMP SI,0x8e0 (1000_814F / 0x1814F)
    Alu.Sub16(SI, 0x8E0);
    // JNZ 0x1000:816a (1000_8153 / 0x18153)
    if(!ZeroFlag) {
      goto label_1000_816A_1816A;
    }
    // MOV SI,0x4718 (1000_8155 / 0x18155)
    SI = 0x4718;
    label_1000_8158_18158:
    // LODSW SI (1000_8158 / 0x18158)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_8159 / 0x18159)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:8176 (1000_815B / 0x1815B)
    if(ZeroFlag) {
      goto label_1000_8176_18176;
    }
    // MOV BX,AX (1000_815D / 0x1815D)
    BX = AX;
    // MOV DX,word ptr [BX + 0x2] (1000_815F / 0x1815F)
    DX = UInt16[DS, (ushort)(BX + 0x2)];
    // MOV BX,word ptr [BX + 0x4] (1000_8162 / 0x18162)
    BX = UInt16[DS, (ushort)(BX + 0x4)];
    // CALL 0x1000:81d7 (1000_8165 / 0x18165)
    NearCall(cs1, 0x8168, not_observed_1000_81D7_0181D7);
    // JMP 0x1000:8158 (1000_8168 / 0x18168)
    goto label_1000_8158_18158;
    label_1000_816A_1816A:
    // MOV BX,word ptr [SI + 0x4] (1000_816A / 0x1816A)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV DX,word ptr [BX + 0x2] (1000_816D / 0x1816D)
    DX = UInt16[DS, (ushort)(BX + 0x2)];
    // MOV BX,word ptr [BX + 0x4] (1000_8170 / 0x18170)
    BX = UInt16[DS, (ushort)(BX + 0x4)];
    // CALL 0x1000:81d7 (1000_8173 / 0x18173)
    NearCall(cs1, 0x8176, not_observed_1000_81D7_0181D7);
    label_1000_8176_18176:
    // MOV SI,SP (1000_8176 / 0x18176)
    SI = SP;
    label_1000_8178_18178:
    // LODSW SI (1000_8178 / 0x18178)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_8179 / 0x18179)
    DX = AX;
    // LODSW SI (1000_817B / 0x1817B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_817C / 0x1817C)
    BX = AX;
    // LODSW SI (1000_817E / 0x1817E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,word ptr [SI] (1000_817F / 0x1817F)
    DI = UInt16[DS, SI];
    // CMP DI,0x8000 (1000_8181 / 0x18181)
    Alu.Sub16(DI, 0x8000);
    // JZ 0x1000:81d3 (1000_8185 / 0x18185)
    if(ZeroFlag) {
      goto label_1000_81D3_181D3;
    }
    // PUSH SI (1000_8187 / 0x18187)
    Stack.Push(SI);
    // MOV CX,word ptr [SI + 0x2] (1000_8188 / 0x18188)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB AX,word ptr [SI + 0x4] (1000_818B / 0x1818B)
    // AX -= UInt16[DS, (ushort)(SI + 0x4)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    // MOV SI,DX (1000_818E / 0x1818E)
    SI = DX;
    // SUB SI,DI (1000_8190 / 0x18190)
    SI -= DI;
    // XOR AX,SI (1000_8192 / 0x18192)
    // AX ^= SI;
    AX = Alu.Xor16(AX, SI);
    // JNS 0x1000:81c0 (1000_8194 / 0x18194)
    if(!SignFlag) {
      goto label_1000_81C0_181C0;
    }
    // MOV AX,SI (1000_8196 / 0x18196)
    AX = SI;
    // OR AX,AX (1000_8198 / 0x18198)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:819e (1000_819A / 0x1819A)
    if(!SignFlag) {
      goto label_1000_819E_1819E;
    }
    // NEG AX (1000_819C / 0x1819C)
    AX = Alu.Sub16(0, AX);
    label_1000_819E_1819E:
    // CMP AX,0x50 (1000_819E / 0x1819E)
    Alu.Sub16(AX, 0x50);
    // JC 0x1000:81c0 (1000_81A1 / 0x181A1)
    if(CarryFlag) {
      goto label_1000_81C0_181C0;
    }
    // CMP DX,word ptr [0x46e3] (1000_81A3 / 0x181A3)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // JL 0x1000:81b5 (1000_81A7 / 0x181A7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_81B5_181B5;
    }
    // CMP DX,word ptr [0x46e7] (1000_81A9 / 0x181A9)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // JGE 0x1000:81b5 (1000_81AD / 0x181AD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_81B5_181B5;
    }
    // XCHG DI,DX (1000_81AF / 0x181AF)
    ushort tmp_1000_81AF = DI;
    DI = DX;
    DX = tmp_1000_81AF;
    // XCHG CX,BX (1000_81B1 / 0x181B1)
    ushort tmp_1000_81B1 = CX;
    CX = BX;
    BX = tmp_1000_81B1;
    // NEG SI (1000_81B3 / 0x181B3)
    SI = Alu.Sub16(0, SI);
    label_1000_81B5_181B5:
    // MOV AX,0x190 (1000_81B5 / 0x181B5)
    AX = 0x190;
    // OR SI,SI (1000_81B8 / 0x181B8)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JS 0x1000:81be (1000_81BA / 0x181BA)
    if(SignFlag) {
      goto label_1000_81BE_181BE;
    }
    // NEG AX (1000_81BC / 0x181BC)
    AX = Alu.Sub16(0, AX);
    label_1000_81BE_181BE:
    // ADD DX,AX (1000_81BE / 0x181BE)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    label_1000_81C0_181C0:
    // MOV ES,word ptr [0xdbda] (1000_81C0 / 0x181C0)
    ES = UInt16[DS, 0xDBDA];
    // MOV AL,0xc (1000_81C4 / 0x181C4)
    AL = 0xC;
    // MOV BP,0x5555 (1000_81C6 / 0x181C6)
    BP = 0x5555;
    // MOV SI,0x46e3 (1000_81C9 / 0x181C9)
    SI = 0x46E3;
    // CALLF [0x3901] (1000_81CC / 0x181CC)
    // Indirect call to [0x3901], generating possible targets from emulator records
    uint targetAddress_1000_81CC = (uint)(UInt16[DS, 0x3903] * 0x10 + UInt16[DS, 0x3901] - cs1 * 0x10);
    switch(targetAddress_1000_81CC) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_81CC));
        break;
    }
    // POP SI (1000_81D0 / 0x181D0)
    SI = Stack.Pop();
    // JMP 0x1000:8178 (1000_81D1 / 0x181D1)
    goto label_1000_8178_18178;
    label_1000_81D3_181D3:
    // ADD SP,0x30 (1000_81D3 / 0x181D3)
    // SP += 0x30;
    SP = Alu.Add16(SP, 0x30);
    // RET  (1000_81D6 / 0x181D6)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_81D7_0181D7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_81D7_181D7:
    // MOV word ptr [DI + 0x4],DX (1000_81D7 / 0x181D7)
    UInt16[DS, (ushort)(DI + 0x4)] = DX;
    // PUSH DI (1000_81DA / 0x181DA)
    Stack.Push(DI);
    // CALL 0x1000:b647 (1000_81DB / 0x181DB)
    NearCall(cs1, 0x81DE, spice86_generated_label_call_target_1000_B647_01B647);
    // POP DI (1000_81DE / 0x181DE)
    DI = Stack.Pop();
    // MOV word ptr [DI],DX (1000_81DF / 0x181DF)
    UInt16[DS, DI] = DX;
    // MOV word ptr [DI + 0x2],BX (1000_81E1 / 0x181E1)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    // ADD DI,0x6 (1000_81E4 / 0x181E4)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    // MOV word ptr [DI],0x8000 (1000_81E7 / 0x181E7)
    UInt16[DS, DI] = 0x8000;
    // RET  (1000_81EB / 0x181EB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_82A0_0182A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_82A0_182A0:
    // CALL 0x1000:d41b (1000_82A0 / 0x182A0)
    NearCall(cs1, 0x82A3, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_82A3_182A3:
    // CMP BP,0x212e (1000_82A3 / 0x182A3)
    Alu.Sub16(BP, 0x212E);
    // JZ 0x1000:82ad (1000_82A7 / 0x182A7)
    if(ZeroFlag) {
      goto label_1000_82AD_182AD;
    }
    // CMP BP,0x2136 (1000_82A9 / 0x182A9)
    Alu.Sub16(BP, 0x2136);
    label_1000_82AD_182AD:
    // JNZ 0x1000:82b6 (1000_82AD / 0x182AD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_82B6 / 0x182B6)
      return NearRet();
    }
    // MOV AL,[0x46eb] (1000_82AF / 0x182AF)
    AL = UInt8[DS, 0x46EB];
    // NOT AL (1000_82B2 / 0x182B2)
    AL = (byte)~AL;
    // TEST AL,0x40 (1000_82B4 / 0x182B4)
    Alu.And8(AL, 0x40);
    label_1000_82B6_182B6:
    // RET  (1000_82B6 / 0x182B6)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8308_018308(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8308_18308:
    // MOV CX,0x4 (1000_8308 / 0x18308)
    CX = 0x4;
    // TEST byte ptr [SI + 0x19],0x40 (1000_830B / 0x1830B)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x40);
    // JZ 0x1000:8313 (1000_830F / 0x1830F)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_8313_018313, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CL,0x8 (1000_8311 / 0x18311)
    CL = 0x8;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_8313_018313, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_8313_018313(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8313_18313:
    // PUSH CX (1000_8313 / 0x18313)
    Stack.Push(CX);
    // CALL 0x1000:8604 (1000_8314 / 0x18314)
    NearCall(cs1, 0x8317, not_observed_1000_8604_018604);
    // POP CX (1000_8317 / 0x18317)
    CX = Stack.Pop();
    // MOV AX,BX (1000_8318 / 0x18318)
    AX = BX;
    // OR AX,DX (1000_831A / 0x1831A)
    // AX |= DX;
    AX = Alu.Or16(AX, DX);
    // JZ 0x1000:8357 (1000_831C / 0x1831C)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_8357_018357, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD word ptr [SI + 0x6],DX (1000_831E / 0x1831E)
    UInt16[DS, (ushort)(SI + 0x6)] += DX;
    // ADD word ptr [SI + 0x8],BX (1000_8321 / 0x18321)
    // UInt16[DS, (ushort)(SI + 0x8)] += BX;
    UInt16[DS, (ushort)(SI + 0x8)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x8)], BX);
    // LOOP 0x1000:8313 (1000_8324 / 0x18324)
    if(--CX != 0) {
      goto label_1000_8313_18313;
    }
    // CALL 0x1000:686e (1000_8326 / 0x18326)
    NearCall(cs1, 0x8329, spice86_generated_label_call_target_1000_686E_01686E);
    // JC 0x1000:8333 (1000_8329 / 0x18329)
    if(CarryFlag) {
      goto label_1000_8333_18333;
    }
    // CALL 0x1000:6917 (1000_832B / 0x1832B)
    NearCall(cs1, 0x832E, spice86_generated_label_call_target_1000_6917_016917);
    // JNZ 0x1000:833c (1000_832E / 0x1832E)
    if(!ZeroFlag) {
      goto label_1000_833C_1833C;
    }
    // JMP 0x1000:c653 (1000_8330 / 0x18330)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C653_01C653, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8333_18333:
    // CALL 0x1000:6917 (1000_8333 / 0x18333)
    NearCall(cs1, 0x8336, spice86_generated_label_call_target_1000_6917_016917);
    // JNZ 0x1000:833b (1000_8336 / 0x18336)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_833B / 0x1833B)
      return NearRet();
    }
    // JMP 0x1000:c58a (1000_8338 / 0x18338)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C58A_01C58A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_833B_1833B:
    // RET  (1000_833B / 0x1833B)
    return NearRet();
    label_1000_833C_1833C:
    // CALL 0x1000:6827 (1000_833C / 0x1833C)
    NearCall(cs1, 0x833F, not_observed_1000_6827_016827);
    // CALL 0x1000:c5cf (1000_833F / 0x1833F)
    NearCall(cs1, 0x8342, spice86_generated_label_call_target_1000_C5CF_01C5CF);
    // MOV SI,DI (1000_8342 / 0x18342)
    SI = DI;
    // JMP 0x1000:c6ad (1000_8344 / 0x18344)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C6AD_01C6AD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_8347_018347(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8347_18347:
    // PUSH SI (1000_8347 / 0x18347)
    Stack.Push(SI);
    // PUSH DI (1000_8348 / 0x18348)
    Stack.Push(DI);
    // MOV DI,0x11d3 (1000_8349 / 0x18349)
    DI = 0x11D3;
    // LEA SI,[DI + 0x2] (1000_834C / 0x1834C)
    SI = (ushort)(DI + 0x2);
    // PUSH DS (1000_834F / 0x1834F)
    Stack.Push(DS);
    // POP ES (1000_8350 / 0x18350)
    ES = Stack.Pop();
    // MOVSW ES:DI,SI (1000_8351 / 0x18351)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_8352 / 0x18352)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_8353 / 0x18353)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // POP DI (1000_8354 / 0x18354)
    DI = Stack.Pop();
    // POP SI (1000_8355 / 0x18355)
    SI = Stack.Pop();
    // RET  (1000_8356 / 0x18356)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8357_018357(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8357_18357:
    // CMP SI,0x8e0 (1000_8357 / 0x18357)
    Alu.Sub16(SI, 0x8E0);
    // JNZ 0x1000:8368 (1000_835B / 0x1835B)
    if(!ZeroFlag) {
      goto label_1000_8368_18368;
    }
    // MOV AX,[0x11d3] (1000_835D / 0x1835D)
    AX = UInt16[DS, 0x11D3];
    // CMP AX,word ptr [SI + 0x4] (1000_8360 / 0x18360)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JNZ 0x1000:8368 (1000_8363 / 0x18363)
    if(!ZeroFlag) {
      goto label_1000_8368_18368;
    }
    // CALL 0x1000:8347 (1000_8365 / 0x18365)
    NearCall(cs1, 0x8368, not_observed_1000_8347_018347);
    label_1000_8368_18368:
    // MOV AL,byte ptr [SI + 0x3] (1000_8368 / 0x18368)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0xf (1000_836B / 0x1836B)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // MOV DI,word ptr [SI + 0x4] (1000_836D / 0x1836D)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV DX,word ptr [DI + 0x2] (1000_8370 / 0x18370)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_8373 / 0x18373)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV word ptr [SI + 0x6],DX (1000_8376 / 0x18376)
    UInt16[DS, (ushort)(SI + 0x6)] = DX;
    // MOV word ptr [SI + 0x8],BX (1000_8379 / 0x18379)
    UInt16[DS, (ushort)(SI + 0x8)] = BX;
    // TEST byte ptr [DI + 0xa],0x2 (1000_837C / 0x1837C)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:8387 (1000_8380 / 0x18380)
    if(!ZeroFlag) {
      goto label_1000_8387_18387;
    }
    // CALL 0x1000:5d36 (1000_8382 / 0x18382)
    NearCall(cs1, 0x8385, spice86_generated_label_call_target_1000_5D36_015D36);
    // JC 0x1000:83a7 (1000_8385 / 0x18385)
    if(CarryFlag) {
      goto label_1000_83A7_183A7;
    }
    label_1000_8387_18387:
    // PUSH AX (1000_8387 / 0x18387)
    Stack.Push(AX);
    // CALL 0x1000:83bc (1000_8388 / 0x18388)
    NearCall(cs1, 0x838B, not_observed_1000_83BC_0183BC);
    // POP AX (1000_838B / 0x1838B)
    AX = Stack.Pop();
    // CMP AL,0x5 (1000_838C / 0x1838C)
    Alu.Sub8(AL, 0x5);
    // JZ 0x1000:839a (1000_838E / 0x1838E)
    if(ZeroFlag) {
      goto label_1000_839A_1839A;
    }
    // MOV AL,byte ptr [SI] (1000_8390 / 0x18390)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [DI + 0x9] (1000_8392 / 0x18392)
    Alu.Sub8(AL, UInt8[DS, (ushort)(DI + 0x9)]);
    // JNZ 0x1000:83fd (1000_8395 / 0x18395)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_83FD_0183FD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:7429 (1000_8397 / 0x18397)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_7429_017429, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_839A_1839A:
    // TEST byte ptr [DI + 0xa],0x80 (1000_839A / 0x1839A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    // JZ 0x1000:83fd (1000_839E / 0x1839E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_83FD_0183FD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [DI + 0xa],0x7f (1000_83A0 / 0x183A0)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x7F);
    // JMP 0x1000:5d44 (1000_83A4 / 0x183A4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D44_015D44, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_83A7_183A7:
    // CMP AL,0x5 (1000_83A7 / 0x183A7)
    Alu.Sub8(AL, 0x5);
    // JC 0x1000:83b6 (1000_83A9 / 0x183A9)
    if(CarryFlag) {
      goto label_1000_83B6_183B6;
    }
    // CMP AL,0x6 (1000_83AB / 0x183AB)
    Alu.Sub8(AL, 0x6);
    // JA 0x1000:83b6 (1000_83AD / 0x183AD)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_83B6_183B6;
    }
    // PUSH DI (1000_83AF / 0x183AF)
    Stack.Push(DI);
    // CALL 0x1000:6ac5 (1000_83B0 / 0x183B0)
    NearCall(cs1, 0x83B3, not_observed_1000_6AC5_016AC5);
    // POP DI (1000_83B3 / 0x183B3)
    DI = Stack.Pop();
    // XOR AL,AL (1000_83B4 / 0x183B4)
    AL = 0;
    label_1000_83B6_183B6:
    // AND AL,0x3 (1000_83B6 / 0x183B6)
    AL &= 0x3;
    // CMP AL,0x3 (1000_83B8 / 0x183B8)
    Alu.Sub8(AL, 0x3);
    // JZ 0x1000:841f (1000_83BA / 0x183BA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_841F_01841F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_83BC_0183BC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_83BC_0183BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_83BC_183BC:
    // CALL 0x1000:851f (1000_83BC / 0x183BC)
    NearCall(cs1, 0x83BF, not_observed_1000_851F_01851F);
    // AND byte ptr [SI + 0x3],0xbf (1000_83BF / 0x183BF)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0xBF;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xBF);
    // CALL 0x1000:85cc (1000_83C3 / 0x183C3)
    NearCall(cs1, 0x83C6, not_observed_1000_85CC_0185CC);
    // CALL 0x1000:7f5f (1000_83C6 / 0x183C6)
    NearCall(cs1, 0x83C9, not_observed_1000_7F5F_017F5F);
    // MOV CL,byte ptr [SI + 0x3] (1000_83C9 / 0x183C9)
    CL = UInt8[DS, (ushort)(SI + 0x3)];
    // OR CL,CL (1000_83CC / 0x183CC)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JS 0x1000:83fc (1000_83CE / 0x183CE)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    // AND CL,0xf (1000_83D0 / 0x183D0)
    // CL &= 0xF;
    CL = Alu.And8(CL, 0xF);
    // CALL 0x1000:6ad4 (1000_83D3 / 0x183D3)
    NearCall(cs1, 0x83D6, not_observed_1000_6AD4_016AD4);
    // MOV DI,word ptr [SI + 0x4] (1000_83D6 / 0x183D6)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP DI,word ptr [0x114e] (1000_83D9 / 0x183D9)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JNZ 0x1000:83fc (1000_83DD / 0x183DD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    // CALL 0x1000:d41b (1000_83DF / 0x183DF)
    NearCall(cs1, 0x83E2, spice86_generated_label_call_target_1000_D41B_01D41B);
    // CMP BP,0x1f0e (1000_83E2 / 0x183E2)
    Alu.Sub16(BP, 0x1F0E);
    // JNZ 0x1000:83fc (1000_83E6 / 0x183E6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    // MOV AL,0x1 (1000_83E8 / 0x183E8)
    AL = 0x1;
    // CMP byte ptr [0x2b],0x1 (1000_83EA / 0x183EA)
    Alu.Sub8(UInt8[DS, 0x2B], 0x1);
    // ADC AL,0x0 (1000_83EF / 0x183EF)
    AL = Alu.Adc8(AL, 0x0);
    // CMP byte ptr [0xb],AL (1000_83F1 / 0x183F1)
    Alu.Sub8(UInt8[DS, 0xB], AL);
    // JNZ 0x1000:83fc (1000_83F5 / 0x183F5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    // OR byte ptr [0x473b],0x1 (1000_83F7 / 0x183F7)
    // UInt8[DS, 0x473B] |= 0x1;
    UInt8[DS, 0x473B] = Alu.Or8(UInt8[DS, 0x473B], 0x1);
    label_1000_83FC_183FC:
    // RET  (1000_83FC / 0x183FC)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_83FD_0183FD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_83FD_183FD:
    // MOV BP,0x8403 (1000_83FD / 0x183FD)
    BP = 0x8403;
    // JMP 0x1000:661d (1000_8400 / 0x18400)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_661D_01661D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_841F_01841F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_841F_1841F:
    // MOV DI,word ptr [SI + 0x4] (1000_841F / 0x1841F)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP DI,word ptr [SI + 0xc] (1000_8422 / 0x18422)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0xC)]);
    // JZ 0x1000:844d (1000_8425 / 0x18425)
    if(ZeroFlag) {
      goto label_1000_844D_1844D;
    }
    // PUSH SI (1000_8427 / 0x18427)
    Stack.Push(SI);
    // CALL 0x1000:7f27 (1000_8428 / 0x18428)
    NearCall(cs1, 0x842B, spice86_generated_label_call_target_1000_7F27_017F27);
    // POP SI (1000_842B / 0x1842B)
    SI = Stack.Pop();
    // MOV BX,word ptr [SI + 0xe] (1000_842C / 0x1842C)
    BX = UInt16[DS, (ushort)(SI + 0xE)];
    // MOV CX,BX (1000_842F / 0x1842F)
    CX = BX;
    // XOR BH,BH (1000_8431 / 0x18431)
    BH = 0;
    // CMP byte ptr [BX + 0x46fe],0x0 (1000_8433 / 0x18433)
    Alu.Sub8(UInt8[DS, (ushort)(BX + 0x46FE)], 0x0);
    // JZ 0x1000:8442 (1000_8438 / 0x18438)
    if(ZeroFlag) {
      goto label_1000_8442_18442;
    }
    // DEC byte ptr [BX + DI + 0x14] (1000_843A / 0x1843A)
    UInt8[DS, (ushort)(BX + DI + 0x14)] = Alu.Dec8(UInt8[DS, (ushort)(BX + DI + 0x14)]);
    // OR byte ptr [SI + 0x19],CH (1000_843D / 0x1843D)
    UInt8[DS, (ushort)(SI + 0x19)] |= CH;
    // XOR CH,CH (1000_8440 / 0x18440)
    CH = 0;
    label_1000_8442_18442:
    // MOV word ptr [SI + 0xe],CX (1000_8442 / 0x18442)
    UInt16[DS, (ushort)(SI + 0xE)] = CX;
    // MOV DI,word ptr [SI + 0xc] (1000_8445 / 0x18445)
    DI = UInt16[DS, (ushort)(SI + 0xC)];
    // MOV word ptr [SI + 0x4],DI (1000_8448 / 0x18448)
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    // JMP 0x1000:8461 (1000_844B / 0x1844B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8461_018461, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_844D_1844D:
    // AND byte ptr [SI + 0x3],0xfc (1000_844D / 0x1844D)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0xFC;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xFC);
    // JMP 0x1000:83bc (1000_8451 / 0x18451)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_83BC_0183BC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8461_018461(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8461_18461:
    // CALL 0x1000:6917 (1000_8461 / 0x18461)
    NearCall(cs1, 0x8464, spice86_generated_label_call_target_1000_6917_016917);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8464_018464, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8464_018464(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8464_18464:
    // JZ 0x1000:8467 (1000_8464 / 0x18464)
    if(ZeroFlag) {
      goto label_1000_8467_18467;
    }
    // RET  (1000_8466 / 0x18466)
    return NearRet();
    label_1000_8467_18467:
    // PUSH SI (1000_8467 / 0x18467)
    Stack.Push(SI);
    // CALL 0x1000:c58a (1000_8468 / 0x18468)
    NearCall(cs1, 0x846B, spice86_generated_label_call_target_1000_C58A_01C58A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_846B_01846B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_846B_01846B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_846B_1846B:
    // POP SI (1000_846B / 0x1846B)
    SI = Stack.Pop();
    // PUSH SI (1000_846C / 0x1846C)
    Stack.Push(SI);
    // TEST byte ptr [SI + 0x3],0x40 (1000_846D / 0x1846D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:847b (1000_8471 / 0x18471)
    if(!ZeroFlag) {
      goto label_1000_847B_1847B;
    }
    // MOV DI,word ptr [SI + 0x4] (1000_8473 / 0x18473)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:5ed0 (1000_8476 / 0x18476)
    NearCall(cs1, 0x8479, spice86_generated_label_call_target_1000_5ED0_015ED0);
    label_1000_8479_18479:
    // JNZ 0x1000:848b (1000_8479 / 0x18479)
    if(!ZeroFlag) {
      goto label_1000_848B_1848B;
    }
    label_1000_847B_1847B:
    // MOV AL,byte ptr [SI] (1000_847B / 0x1847B)
    AL = UInt8[DS, SI];
    // CALL 0x1000:6757 (1000_847D / 0x1847D)
    NearCall(cs1, 0x8480, spice86_generated_label_call_target_1000_6757_016757);
    label_1000_8480_18480:
    // JC 0x1000:848b (1000_8480 / 0x18480)
    if(CarryFlag) {
      goto label_1000_848B_1848B;
    }
    // MOV SI,DI (1000_8482 / 0x18482)
    SI = DI;
    // PUSH DI (1000_8484 / 0x18484)
    Stack.Push(DI);
    // CALL 0x1000:c6ad (1000_8485 / 0x18485)
    NearCall(cs1, 0x8488, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    label_1000_8488_18488:
    // POP DI (1000_8488 / 0x18488)
    DI = Stack.Pop();
    label_1000_8489_18489:
    // POP SI (1000_8489 / 0x18489)
    SI = Stack.Pop();
    // RET  (1000_848A / 0x1848A)
    return NearRet();
    label_1000_848B_1848B:
    // XOR DI,DI (1000_848B / 0x1848B)
    DI = 0;
    // JMP 0x1000:8489 (1000_848D / 0x1848D)
    goto label_1000_8489_18489;
  }
  
  public virtual Action not_observed_1000_848F_01848F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_848F_1848F:
    // MOV DI,word ptr [0x11d3] (1000_848F / 0x1848F)
    DI = UInt16[DS, 0x11D3];
    // CMP word ptr [SI + 0x4],DI (1000_8493 / 0x18493)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], DI);
    // JNZ 0x1000:84a3 (1000_8496 / 0x18496)
    if(!ZeroFlag) {
      goto label_1000_84A3_184A3;
    }
    // TEST byte ptr [SI + 0x3],0x40 (1000_8498 / 0x18498)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:84a3 (1000_849C / 0x1849C)
    if(!ZeroFlag) {
      goto label_1000_84A3_184A3;
    }
    // CALL 0x1000:8347 (1000_849E / 0x1849E)
    NearCall(cs1, 0x84A1, not_observed_1000_8347_018347);
    // JMP 0x1000:848f (1000_84A1 / 0x184A1)
    goto label_1000_848F_1848F;
    label_1000_84A3_184A3:
    // OR DI,DI (1000_84A3 / 0x184A3)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // RET  (1000_84A5 / 0x184A5)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_84A6_0184A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_84A6_184A6:
    // CMP SI,0x8e0 (1000_84A6 / 0x184A6)
    Alu.Sub16(SI, 0x8E0);
    // JNZ 0x1000:84b2 (1000_84AA / 0x184AA)
    if(!ZeroFlag) {
      goto label_1000_84B2_184B2;
    }
    // CALL 0x1000:848f (1000_84AC / 0x184AC)
    NearCall(cs1, 0x84AF, not_observed_1000_848F_01848F);
    // JNZ 0x1000:84b2 (1000_84AF / 0x184AF)
    if(!ZeroFlag) {
      goto label_1000_84B2_184B2;
    }
    // RET  (1000_84B1 / 0x184B1)
    return NearRet();
    label_1000_84B2_184B2:
    // TEST byte ptr [SI + 0x3],0x40 (1000_84B2 / 0x184B2)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JZ 0x1000:84ca (1000_84B6 / 0x184B6)
    if(ZeroFlag) {
      goto label_1000_84CA_184CA;
    }
    // MOV word ptr [SI + 0x4],DI (1000_84B8 / 0x184B8)
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    // MOV AL,0x3 (1000_84BB / 0x184BB)
    AL = 0x3;
    // AND AL,byte ptr [SI + 0x3] (1000_84BD / 0x184BD)
    AL &= UInt8[DS, (ushort)(SI + 0x3)];
    // CMP AL,0x3 (1000_84C0 / 0x184C0)
    Alu.Sub8(AL, 0x3);
    // JNZ 0x1000:84c8 (1000_84C2 / 0x184C2)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:8461 (1000_84C8 / 0x184C8)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8461_018461, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [SI + 0x3],0xfc (1000_84C4 / 0x184C4)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0xFC;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xFC);
    label_1000_84C8_184C8:
    // JMP 0x1000:8461 (1000_84C8 / 0x184C8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8461_018461, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_84CA_184CA:
    // CALL 0x1000:6ebf (1000_84CA / 0x184CA)
    NearCall(cs1, 0x84CD, not_observed_1000_6EBF_016EBF);
    // PUSH DI (1000_84CD / 0x184CD)
    Stack.Push(DI);
    // CALL 0x1000:858c (1000_84CE / 0x184CE)
    NearCall(cs1, 0x84D1, not_observed_1000_858C_01858C);
    // POP DI (1000_84D1 / 0x184D1)
    DI = Stack.Pop();
    // CMP byte ptr [SI + 0x3],0x6 (1000_84D2 / 0x184D2)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x6);
    // JNZ 0x1000:8501 (1000_84D6 / 0x184D6)
    if(!ZeroFlag) {
      goto label_1000_8501_18501;
    }
    // PUSH DI (1000_84D8 / 0x184D8)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_84D9 / 0x184D9)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [DI + 0xa],0x2 (1000_84DC / 0x184DC)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JZ 0x1000:84ef (1000_84E0 / 0x184E0)
    if(ZeroFlag) {
      goto label_1000_84EF_184EF;
    }
    // CALL 0x1000:5098 (1000_84E2 / 0x184E2)
    NearCall(cs1, 0x84E5, not_observed_1000_5098_015098);
    // JCXZ 0x1000:84ef (1000_84E5 / 0x184E5)
    if(CX == 0) {
      goto label_1000_84EF_184EF;
    }
    // DEC DX (1000_84E7 / 0x184E7)
    DX = Alu.Dec16(DX);
    // JG 0x1000:84ef (1000_84E8 / 0x184E8)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_84EF_184EF;
    }
    // PUSH SI (1000_84EA / 0x184EA)
    Stack.Push(SI);
    // CALL 0x1000:74b6 (1000_84EB / 0x184EB)
    NearCall(cs1, 0x84EE, not_observed_1000_74B6_0174B6);
    // POP SI (1000_84EE / 0x184EE)
    SI = Stack.Pop();
    label_1000_84EF_184EF:
    // POP DI (1000_84EF / 0x184EF)
    DI = Stack.Pop();
    // CMP byte ptr [DI + 0x8],0x28 (1000_84F0 / 0x184F0)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JNC 0x1000:8501 (1000_84F4 / 0x184F4)
    if(!CarryFlag) {
      goto label_1000_8501_18501;
    }
    // TEST byte ptr [DI + 0xa],0x2 (1000_84F6 / 0x184F6)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:851e (1000_84FA / 0x184FA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_851E / 0x1851E)
      return NearRet();
    }
    // MOV AL,0x3 (1000_84FC / 0x184FC)
    AL = 0x3;
    // CALL 0x1000:6f93 (1000_84FE / 0x184FE)
    NearCall(cs1, 0x8501, not_observed_1000_6F93_016F93);
    label_1000_8501_18501:
    // XCHG word ptr [SI + 0x4],DI (1000_8501 / 0x18501)
    ushort tmp_1000_8501 = UInt16[DS, (ushort)(SI + 0x4)];
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    DI = tmp_1000_8501;
    // OR byte ptr [SI + 0x3],0x40 (1000_8504 / 0x18504)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x40;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // MOV byte ptr [SI + 0x2],0x0 (1000_8508 / 0x18508)
    UInt8[DS, (ushort)(SI + 0x2)] = 0x0;
    // CALL 0x1000:7f75 (1000_850C / 0x1850C)
    NearCall(cs1, 0x850F, not_observed_1000_7F75_017F75);
    // CALL 0x1000:8461 (1000_850F / 0x1850F)
    NearCall(cs1, 0x8512, spice86_generated_label_call_target_1000_8461_018461);
    // TEST byte ptr [SI + 0x10],0x10 (1000_8512 / 0x18512)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    // JNZ 0x1000:851e (1000_8516 / 0x18516)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_851E / 0x1851E)
      return NearRet();
    }
    // MOV CX,0x7 (1000_8518 / 0x18518)
    CX = 0x7;
    // JMP 0x1000:8313 (1000_851B / 0x1851B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8313_018313, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_851E_1851E:
    // RET  (1000_851E / 0x1851E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_851F_01851F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_851F_1851F:
    // MOV AH,byte ptr [SI] (1000_851F / 0x1851F)
    AH = UInt8[DS, SI];
    // MOV AL,byte ptr [DI + 0x9] (1000_8521 / 0x18521)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // OR AL,AL (1000_8524 / 0x18524)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:8540 (1000_8526 / 0x18526)
    if(!ZeroFlag) {
      goto label_1000_8540_18540;
    }
    // MOV byte ptr [DI + 0x9],AH (1000_8528 / 0x18528)
    UInt8[DS, (ushort)(DI + 0x9)] = AH;
    // MOV CX,0x1 (1000_852B / 0x1852B)
    CX = 0x1;
    // MOV byte ptr [SI + 0x2],CL (1000_852E / 0x1852E)
    UInt8[DS, (ushort)(SI + 0x2)] = CL;
    // TEST word ptr [SI + 0x10],0x80 (1000_8531 / 0x18531)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x80);
    // JZ 0x1000:853f (1000_8536 / 0x18536)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_853F / 0x1853F)
      return NearRet();
    }
    // ADD byte ptr [SI + 0x2],0x8 (1000_8538 / 0x18538)
    UInt8[DS, (ushort)(SI + 0x2)] += 0x8;
    // ADD CL,0x8 (1000_853C / 0x1853C)
    // CL += 0x8;
    CL = Alu.Add8(CL, 0x8);
    label_1000_853F_1853F:
    // RET  (1000_853F / 0x1853F)
    return NearRet();
    label_1000_8540_18540:
    // PUSH DI (1000_8540 / 0x18540)
    Stack.Push(DI);
    // PUSH DS (1000_8541 / 0x18541)
    Stack.Push(DS);
    // POP ES (1000_8542 / 0x18542)
    ES = Stack.Pop();
    // SUB SP,0x1e (1000_8543 / 0x18543)
    // SP -= 0x1E;
    SP = Alu.Sub16(SP, 0x1E);
    // MOV DI,SP (1000_8546 / 0x18546)
    DI = SP;
    // MOV CX,0x1e (1000_8548 / 0x18548)
    CX = 0x1E;
    // PUSH AX (1000_854B / 0x1854B)
    Stack.Push(AX);
    // XOR AL,AL (1000_854C / 0x1854C)
    AL = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_854E / 0x1854E)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // POP AX (1000_8550 / 0x18550)
    AX = Stack.Pop();
    // MOV DI,SP (1000_8551 / 0x18551)
    DI = SP;
    // PUSH SI (1000_8553 / 0x18553)
    Stack.Push(SI);
    // XOR BX,BX (1000_8554 / 0x18554)
    BX = 0;
    label_1000_8556_18556:
    // CALL 0x1000:6906 (1000_8556 / 0x18556)
    NearCall(cs1, 0x8559, spice86_generated_label_call_target_1000_6906_016906);
    // MOV BL,byte ptr [SI + 0x2] (1000_8559 / 0x18559)
    BL = UInt8[DS, (ushort)(SI + 0x2)];
    // MOV byte ptr [BX + DI + -0x1],0xff (1000_855C / 0x1855C)
    UInt8[DS, (ushort)(BX + DI - 0x1)] = 0xFF;
    // MOV AL,byte ptr [SI + 0x1] (1000_8560 / 0x18560)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // OR AL,AL (1000_8563 / 0x18563)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:8556 (1000_8565 / 0x18565)
    if(!ZeroFlag) {
      goto label_1000_8556_18556;
    }
    // MOV byte ptr [SI + 0x1],AH (1000_8567 / 0x18567)
    UInt8[DS, (ushort)(SI + 0x1)] = AH;
    // MOV CX,0x1e (1000_856A / 0x1856A)
    CX = 0x1E;
    // POP SI (1000_856D / 0x1856D)
    SI = Stack.Pop();
    // TEST word ptr [SI + 0x10],0x80 (1000_856E / 0x1856E)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x80);
    // JZ 0x1000:857b (1000_8573 / 0x18573)
    if(ZeroFlag) {
      goto label_1000_857B_1857B;
    }
    // SUB CX,0x8 (1000_8575 / 0x18575)
    CX -= 0x8;
    // ADD DI,0x8 (1000_8578 / 0x18578)
    DI += 0x8;
    label_1000_857B_1857B:
    // XOR AL,AL (1000_857B / 0x1857B)
    AL = 0;
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_857D / 0x1857D)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    // SUB CX,0x1e (1000_857F / 0x1857F)
    CX -= 0x1E;
    // NEG CX (1000_8582 / 0x18582)
    CX = Alu.Sub16(0, CX);
    // ADD SP,0x1e (1000_8584 / 0x18584)
    // SP += 0x1E;
    SP = Alu.Add16(SP, 0x1E);
    // POP DI (1000_8587 / 0x18587)
    DI = Stack.Pop();
    // MOV byte ptr [SI + 0x2],CL (1000_8588 / 0x18588)
    UInt8[DS, (ushort)(SI + 0x2)] = CL;
    // RET  (1000_858B / 0x1858B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_858C_01858C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_858C_1858C:
    // MOV BP,SI (1000_858C / 0x1858C)
    BP = SI;
    // MOV AL,byte ptr [SI] (1000_858E / 0x1858E)
    AL = UInt8[DS, SI];
    // MOV DI,word ptr [SI + 0x4] (1000_8590 / 0x18590)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // PUSH DI (1000_8593 / 0x18593)
    Stack.Push(DI);
    // TEST byte ptr [SI + 0x3],0x40 (1000_8594 / 0x18594)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:85ba (1000_8598 / 0x18598)
    if(!ZeroFlag) {
      goto label_1000_85BA_185BA;
    }
    // CMP AL,byte ptr [DI + 0x9] (1000_859A / 0x1859A)
    Alu.Sub8(AL, UInt8[DS, (ushort)(DI + 0x9)]);
    // JZ 0x1000:85c2 (1000_859D / 0x1859D)
    if(ZeroFlag) {
      goto label_1000_85C2_185C2;
    }
    // MOV CL,AL (1000_859F / 0x1859F)
    CL = AL;
    // MOV AL,byte ptr [DI + 0x9] (1000_85A1 / 0x185A1)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    label_1000_85A4_185A4:
    // CALL 0x1000:6906 (1000_85A4 / 0x185A4)
    NearCall(cs1, 0x85A7, spice86_generated_label_call_target_1000_6906_016906);
    // MOV AL,byte ptr [SI + 0x1] (1000_85A7 / 0x185A7)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // MOV DI,SI (1000_85AA / 0x185AA)
    DI = SI;
    // OR AL,AL (1000_85AC / 0x185AC)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:85ba (1000_85AE / 0x185AE)
    if(ZeroFlag) {
      goto label_1000_85BA_185BA;
    }
    // CMP AL,CL (1000_85B0 / 0x185B0)
    Alu.Sub8(AL, CL);
    // JNZ 0x1000:85a4 (1000_85B2 / 0x185B2)
    if(!ZeroFlag) {
      goto label_1000_85A4_185A4;
    }
    // MOV AH,byte ptr [BP + 0x1] (1000_85B4 / 0x185B4)
    AH = UInt8[SS, (ushort)(BP + 0x1)];
    // MOV byte ptr [SI + 0x1],AH (1000_85B7 / 0x185B7)
    UInt8[DS, (ushort)(SI + 0x1)] = AH;
    label_1000_85BA_185BA:
    // MOV SI,BP (1000_85BA / 0x185BA)
    SI = BP;
    // MOV byte ptr [SI + 0x1],0x0 (1000_85BC / 0x185BC)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x0;
    // POP DI (1000_85C0 / 0x185C0)
    DI = Stack.Pop();
    // RET  (1000_85C1 / 0x185C1)
    return NearRet();
    label_1000_85C2_185C2:
    // XOR AH,AH (1000_85C2 / 0x185C2)
    AH = 0;
    // XCHG byte ptr [SI + 0x1],AH (1000_85C4 / 0x185C4)
    byte tmp_1000_85C4 = UInt8[DS, (ushort)(SI + 0x1)];
    UInt8[DS, (ushort)(SI + 0x1)] = AH;
    AH = tmp_1000_85C4;
    // POP DI (1000_85C7 / 0x185C7)
    DI = Stack.Pop();
    // MOV byte ptr [DI + 0x9],AH (1000_85C8 / 0x185C8)
    UInt8[DS, (ushort)(DI + 0x9)] = AH;
    // RET  (1000_85CB / 0x185CB)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_85CC_0185CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_85CC_185CC:
    // TEST word ptr [SI + 0x10],0x80 (1000_85CC / 0x185CC)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:8603 (1000_85D1 / 0x185D1)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_8603 / 0x18603)
      return NearRet();
    }
    // CMP byte ptr [SI + 0x2],0x8 (1000_85D3 / 0x185D3)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    // JBE 0x1000:8603 (1000_85D7 / 0x185D7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_8603 / 0x18603)
      return NearRet();
    }
    // CALL 0x1000:858c (1000_85D9 / 0x185D9)
    NearCall(cs1, 0x85DC, not_observed_1000_858C_01858C);
    // PUSH SI (1000_85DC / 0x185DC)
    Stack.Push(SI);
    // MOV AL,byte ptr [DI + 0x9] (1000_85DD / 0x185DD)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    label_1000_85E0_185E0:
    // OR AL,AL (1000_85E0 / 0x185E0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:85ff (1000_85E2 / 0x185E2)
    if(ZeroFlag) {
      goto label_1000_85FF_185FF;
    }
    // CALL 0x1000:6906 (1000_85E4 / 0x185E4)
    NearCall(cs1, 0x85E7, spice86_generated_label_call_target_1000_6906_016906);
    // MOV AL,byte ptr [SI + 0x1] (1000_85E7 / 0x185E7)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // TEST byte ptr [SI + 0x10],0x80 (1000_85EA / 0x185EA)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:85e0 (1000_85EE / 0x185EE)
    if(!ZeroFlag) {
      goto label_1000_85E0_185E0;
    }
    // TEST byte ptr [SI + 0x3],0x20 (1000_85F0 / 0x185F0)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JZ 0x1000:85e0 (1000_85F4 / 0x185F4)
    if(ZeroFlag) {
      goto label_1000_85E0_185E0;
    }
    // CALL 0x1000:e270 (1000_85F6 / 0x185F6)
    NearCall(cs1, 0x85F9, spice86_generated_label_call_target_1000_E270_01E270);
    // CALL 0x1000:66b1 (1000_85F9 / 0x185F9)
    NearCall(cs1, 0x85FC, not_observed_1000_66B1_0166B1);
    // CALL 0x1000:e283 (1000_85FC / 0x185FC)
    NearCall(cs1, 0x85FF, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_85FF_185FF:
    // POP SI (1000_85FF / 0x185FF)
    SI = Stack.Pop();
    // CALL 0x1000:851f (1000_8600 / 0x18600)
    NearCall(cs1, 0x8603, not_observed_1000_851F_01851F);
    label_1000_8603_18603:
    // RET  (1000_8603 / 0x18603)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8604_018604(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8604_18604:
    // PUSH SI (1000_8604 / 0x18604)
    Stack.Push(SI);
    // MOV DI,word ptr [SI + 0x4] (1000_8605 / 0x18605)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV DX,word ptr [DI + 0x2] (1000_8608 / 0x18608)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [SI + 0x8] (1000_860B / 0x1860B)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    // MOV BP,BX (1000_860E / 0x1860E)
    BP = BX;
    // SHL BP,1 (1000_8610 / 0x18610)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // JNS 0x1000:8616 (1000_8612 / 0x18612)
    if(!SignFlag) {
      goto label_1000_8616_18616;
    }
    // NEG BP (1000_8614 / 0x18614)
    BP = Alu.Sub16(0, BP);
    label_1000_8616_18616:
    // MOV BP,word ptr [BP + 0x4880] (1000_8616 / 0x18616)
    BP = UInt16[SS, (ushort)(BP + 0x4880)];
    // SUB BX,word ptr [DI + 0x4] (1000_861A / 0x1861A)
    BX -= UInt16[DS, (ushort)(DI + 0x4)];
    // NEG BX (1000_861D / 0x1861D)
    BX = Alu.Sub16(0, BX);
    // MOV DI,0x1 (1000_861F / 0x1861F)
    DI = 0x1;
    // JNS 0x1000:8628 (1000_8622 / 0x18622)
    if(!SignFlag) {
      goto label_1000_8628_18628;
    }
    // NEG DI (1000_8624 / 0x18624)
    DI = Alu.Sub16(0, DI);
    // NEG BX (1000_8626 / 0x18626)
    BX = Alu.Sub16(0, BX);
    label_1000_8628_18628:
    // SUB DX,word ptr [SI + 0x6] (1000_8628 / 0x18628)
    // DX -= UInt16[DS, (ushort)(SI + 0x6)];
    DX = Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x6)]);
    // MOV AX,DX (1000_862B / 0x1862B)
    AX = DX;
    // JNS 0x1000:8631 (1000_862D / 0x1862D)
    if(!SignFlag) {
      goto label_1000_8631_18631;
    }
    // NEG AX (1000_862F / 0x1862F)
    AX = Alu.Sub16(0, AX);
    label_1000_8631_18631:
    // MOV SI,DX (1000_8631 / 0x18631)
    SI = DX;
    // XOR DX,DX (1000_8633 / 0x18633)
    DX = 0;
    // DIV BP (1000_8635 / 0x18635)
    Cpu.Div16(BP);
    // MOV DX,SI (1000_8637 / 0x18637)
    DX = SI;
    // XCHG DI,BX (1000_8639 / 0x18639)
    ushort tmp_1000_8639 = DI;
    DI = BX;
    BX = tmp_1000_8639;
    // CMP AX,DI (1000_863B / 0x1863B)
    Alu.Sub16(AX, DI);
    // JC 0x1000:8666 (1000_863D / 0x1863D)
    if(CarryFlag) {
      goto label_1000_8666_18666;
    }
    // CMP AX,0x7 (1000_863F / 0x1863F)
    Alu.Sub16(AX, 0x7);
    // JC 0x1000:8660 (1000_8642 / 0x18642)
    if(CarryFlag) {
      goto label_1000_8660_18660;
    }
    // OR DI,DI (1000_8644 / 0x18644)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:864a (1000_8646 / 0x18646)
    if(!ZeroFlag) {
      goto label_1000_864A_1864A;
    }
    // XOR BX,BX (1000_8648 / 0x18648)
    BX = 0;
    label_1000_864A_1864A:
    // OR DX,DX (1000_864A / 0x1864A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNS 0x1000:8650 (1000_864C / 0x1864C)
    if(!SignFlag) {
      goto label_1000_8650_18650;
    }
    // NEG BP (1000_864E / 0x1864E)
    BP = Alu.Sub16(0, BP);
    label_1000_8650_18650:
    // SHR AX,1 (1000_8650 / 0x18650)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // JZ 0x1000:865e (1000_8652 / 0x18652)
    if(ZeroFlag) {
      goto label_1000_865E_1865E;
    }
    // MOV DX,BP (1000_8654 / 0x18654)
    DX = BP;
    // ROL word ptr [0x0],1 (1000_8656 / 0x18656)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // JC 0x1000:865e (1000_865A / 0x1865A)
    if(CarryFlag) {
      goto label_1000_865E_1865E;
    }
    // XOR BX,BX (1000_865C / 0x1865C)
    BX = 0;
    label_1000_865E_1865E:
    // POP SI (1000_865E / 0x1865E)
    SI = Stack.Pop();
    // RET  (1000_865F / 0x1865F)
    return NearRet();
    label_1000_8660_18660:
    // XOR BX,BX (1000_8660 / 0x18660)
    BX = 0;
    // XOR DX,DX (1000_8662 / 0x18662)
    DX = 0;
    // POP SI (1000_8664 / 0x18664)
    SI = Stack.Pop();
    // RET  (1000_8665 / 0x18665)
    return NearRet();
    label_1000_8666_18666:
    // CMP DI,0x7 (1000_8666 / 0x18666)
    Alu.Sub16(DI, 0x7);
    // JC 0x1000:8660 (1000_8669 / 0x18669)
    if(CarryFlag) {
      goto label_1000_8660_18660;
    }
    // OR AX,AX (1000_866B / 0x1866B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:865e (1000_866D / 0x1866D)
    if(ZeroFlag) {
      goto label_1000_865E_1865E;
    }
    // OR DX,DX (1000_866F / 0x1866F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNS 0x1000:8675 (1000_8671 / 0x18671)
    if(!SignFlag) {
      goto label_1000_8675_18675;
    }
    // NEG BP (1000_8673 / 0x18673)
    BP = Alu.Sub16(0, BP);
    label_1000_8675_18675:
    // SHR DI,1 (1000_8675 / 0x18675)
    // DI >>= 0x1;
    DI = Alu.Shr16(DI, 0x1);
    // JZ 0x1000:865e (1000_8677 / 0x18677)
    if(ZeroFlag) {
      goto label_1000_865E_1865E;
    }
    // MOV DX,BP (1000_8679 / 0x18679)
    DX = BP;
    // ROL word ptr [0x0],1 (1000_867B / 0x1867B)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // JC 0x1000:865e (1000_867F / 0x1867F)
    if(CarryFlag) {
      goto label_1000_865E_1865E;
    }
    // XOR DX,DX (1000_8681 / 0x18681)
    DX = 0;
    // POP SI (1000_8683 / 0x18683)
    SI = Stack.Pop();
    // RET  (1000_8684 / 0x18684)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8685_018685(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8685_18685:
    // MOV byte ptr [0x46d8],0x1 (1000_8685 / 0x18685)
    UInt8[DS, 0x46D8] = 0x1;
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
    label_1000_8690_18690:
    // CALL 0x1000:5f79 (1000_8690 / 0x18690)
    NearCall(cs1, 0x8693, spice86_generated_label_call_target_1000_5F79_015F79);
    label_1000_8693_18693:
    // CALL 0x1000:79de (1000_8693 / 0x18693)
    NearCall(cs1, 0x8696, spice86_generated_label_call_target_1000_79DE_0179DE);
    label_1000_8696_18696:
    // CALL 0x1000:58fa (1000_8696 / 0x18696)
    NearCall(cs1, 0x8699, spice86_generated_label_call_target_1000_58FA_0158FA);
    label_1000_8699_18699:
    // MOV AL,[0x1954] (1000_8699 / 0x18699)
    AL = UInt8[DS, 0x1954];
    // CMP AL,0x43 (1000_869C / 0x1869C)
    Alu.Sub8(AL, 0x43);
    // JA 0x1000:86b8 (1000_869E / 0x1869E)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_86B8 / 0x186B8)
      return NearRet();
    }
    // CALL 0x1000:6906 (1000_86A0 / 0x186A0)
    NearCall(cs1, 0x86A3, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_86A3_186A3:
    // JNC 0x1000:86b8 (1000_86A3 / 0x186A3)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_86B8 / 0x186B8)
      return NearRet();
    }
    // MOV [0x1955],AL (1000_86A5 / 0x186A5)
    UInt8[DS, 0x1955] = AL;
    // PUSH SI (1000_86A8 / 0x186A8)
    Stack.Push(SI);
    // CALL 0x1000:697c (1000_86A9 / 0x186A9)
    NearCall(cs1, 0x86AC, spice86_generated_label_call_target_1000_697C_01697C);
    label_1000_86AC_186AC:
    // POP SI (1000_86AC / 0x186AC)
    SI = Stack.Pop();
    // PUSH SI (1000_86AD / 0x186AD)
    Stack.Push(SI);
    // CALL 0x1000:780a (1000_86AE / 0x186AE)
    NearCall(cs1, 0x86B1, spice86_generated_label_call_target_1000_780A_01780A);
    label_1000_86B1_186B1:
    // POP SI (1000_86B1 / 0x186B1)
    SI = Stack.Pop();
    // MOV DI,word ptr [SI + 0x4] (1000_86B2 / 0x186B2)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:7c02 (1000_86B5 / 0x186B5)
    NearCall(cs1, 0x86B8, spice86_generated_label_call_target_1000_7C02_017C02);
    label_1000_86B8_186B8:
    // RET  (1000_86B8 / 0x186B8)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_872C_01872C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_872C_1872C:
    // MOV SI,word ptr [SI + 0xa] (1000_872C / 0x1872C)
    SI = UInt16[DS, (ushort)(SI + 0xA)];
    // MOV AL,byte ptr [SI] (1000_872F / 0x1872F)
    AL = UInt8[DS, SI];
    // CMP word ptr [0x1176],0x2 (1000_8731 / 0x18731)
    Alu.Sub16(UInt16[DS, 0x1176], 0x2);
    // JNC 0x1000:8741 (1000_8736 / 0x18736)
    if(!CarryFlag) {
      goto label_1000_8741_18741;
    }
    // MOV DI,word ptr [SI + 0x4] (1000_8738 / 0x18738)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP DI,word ptr [0x114e] (1000_873B / 0x1873B)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JNZ 0x1000:8750 (1000_873F / 0x1873F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_8750 / 0x18750)
      return NearRet();
    }
    label_1000_8741_18741:
    // CMP AL,byte ptr [0x1954] (1000_8741 / 0x18741)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    // JZ 0x1000:874d (1000_8745 / 0x18745)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:7c02 (1000_874D / 0x1874D)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7C02_017C02, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV [0x1954],AL (1000_8747 / 0x18747)
    UInt8[DS, 0x1954] = AL;
    // JMP 0x1000:8685 (1000_874A / 0x1874A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8685_018685, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_874D_1874D:
    // JMP 0x1000:7c02 (1000_874D / 0x1874D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7C02_017C02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8750_18750:
    // RET  (1000_8750 / 0x18750)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8751_018751(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8751_18751:
    // CMP byte ptr [0x1954],0x0 (1000_8751 / 0x18751)
    Alu.Sub8(UInt8[DS, 0x1954], 0x0);
    // JZ 0x1000:878b (1000_8756 / 0x18756)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_878B / 0x1878B)
      return NearRet();
    }
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
    label_1000_875B_1875B:
    // MOV byte ptr [0x1954],0x0 (1000_875B / 0x1875B)
    UInt8[DS, 0x1954] = 0x0;
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
    label_1000_8763_18763:
    // CMP byte ptr [0x46f3],0x0 (1000_8763 / 0x18763)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x0);
    // JZ 0x1000:8770 (1000_8768 / 0x18768)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8770_018770, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
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
    label_1000_8770_18770:
    // CMP byte ptr [0x1954],0x0 (1000_8770 / 0x18770)
    Alu.Sub8(UInt8[DS, 0x1954], 0x0);
    // JZ 0x1000:878b (1000_8775 / 0x18775)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_878B / 0x1878B)
      return NearRet();
    }
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
    label_1000_877A_1877A:
    // MOV byte ptr [0x46f3],0x0 (1000_877A / 0x1877A)
    UInt8[DS, 0x46F3] = 0x0;
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
    label_1000_8782_18782:
    // MOV word ptr [0x1bea],0x0 (1000_8782 / 0x18782)
    UInt16[DS, 0x1BEA] = 0x0;
    // CALL 0x1000:e283 (1000_8788 / 0x18788)
    NearCall(cs1, 0x878B, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_878B_1878B:
    // RET  (1000_878B / 0x1878B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_878C_01878C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_878C_1878C:
    // MOV word ptr [0x47ba],0x0 (1000_878C / 0x1878C)
    UInt16[DS, 0x47BA] = 0x0;
    // MOV AX,0x40a7 (1000_8792 / 0x18792)
    AX = 0x40A7;
    // CMP byte ptr [0x8],0xff (1000_8795 / 0x18795)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    // JZ 0x1000:87c0 (1000_879A / 0x1879A)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_87B2_0187B2, 0x187C0 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x8],0x20 (1000_879C / 0x1879C)
    Alu.Sub8(UInt8[DS, 0x8], 0x20);
    // JC 0x1000:87aa (1000_87A1 / 0x187A1)
    if(CarryFlag) {
      goto label_1000_87AA_187AA;
    }
    // CMP byte ptr [0xb],0x3 (1000_87A3 / 0x187A3)
    Alu.Sub8(UInt8[DS, 0xB], 0x3);
    // JNC 0x1000:87c0 (1000_87A8 / 0x187A8)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_87B2_0187B2, 0x187C0 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_87AA_187AA:
    // PUSH DI (1000_87AA / 0x187AA)
    Stack.Push(DI);
    // MOV DI,word ptr [0x114e] (1000_87AB / 0x187AB)
    DI = UInt16[DS, 0x114E];
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
    label_1000_87B2_187B2:
    // POP DI (1000_87B2 / 0x187B2)
    DI = Stack.Pop();
    // MOV AX,0xa7 (1000_87B3 / 0x187B3)
    AX = 0xA7;
    // CMP byte ptr [0x46ff],0x0 (1000_87B6 / 0x187B6)
    Alu.Sub8(UInt8[DS, 0x46FF], 0x0);
    // JNZ 0x1000:87c0 (1000_87BB / 0x187BB)
    if(!ZeroFlag) {
      goto label_1000_87C0_187C0;
    }
    // OR AH,0x40 (1000_87BD / 0x187BD)
    // AH |= 0x40;
    AH = Alu.Or8(AH, 0x40);
    label_1000_87C0_187C0:
    // MOV BP,0x20f2 (1000_87C0 / 0x187C0)
    BP = 0x20F2;
    // MOV word ptr [BP + 0xe],AX (1000_87C3 / 0x187C3)
    UInt16[SS, (ushort)(BP + 0xE)] = AX;
    // OR byte ptr [BP + 0xb],0x40 (1000_87C6 / 0x187C6)
    // UInt8[SS, (ushort)(BP + 0xB)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xB)], 0x40);
    // MOV word ptr [BP + 0x12],0x0 (1000_87CA / 0x187CA)
    UInt16[SS, (ushort)(BP + 0x12)] = 0x0;
    // CMP byte ptr [0x2a],0x5 (1000_87CF / 0x187CF)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5);
    // JC 0x1000:87df (1000_87D4 / 0x187D4)
    if(CarryFlag) {
      goto label_1000_87DF_187DF;
    }
    // AND byte ptr [BP + 0xb],0xbf (1000_87D6 / 0x187D6)
    // UInt8[SS, (ushort)(BP + 0xB)] &= 0xBF;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.And8(UInt8[SS, (ushort)(BP + 0xB)], 0xBF);
    // MOV word ptr [BP + 0x12],0x67 (1000_87DA / 0x187DA)
    UInt16[SS, (ushort)(BP + 0x12)] = 0x67;
    label_1000_87DF_187DF:
    // CMP word ptr [0x1176],0x2 (1000_87DF / 0x187DF)
    Alu.Sub16(UInt16[DS, 0x1176], 0x2);
    // JNC 0x1000:8806 (1000_87E4 / 0x187E4)
    if(!CarryFlag) {
      goto label_1000_8806_18806;
    }
    // MOV word ptr [BP + 0x6],0x4093 (1000_87E6 / 0x187E6)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x4093;
    // MOV DI,word ptr [0x114e] (1000_87EB / 0x187EB)
    DI = UInt16[DS, 0x114E];
    // OR DI,DI (1000_87EF / 0x187EF)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:8816 (1000_87F1 / 0x187F1)
    if(ZeroFlag) {
      goto label_1000_8816_18816;
    }
    // MOV AL,byte ptr [DI + 0x9] (1000_87F3 / 0x187F3)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // OR AL,AL (1000_87F6 / 0x187F6)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:8816 (1000_87F8 / 0x187F8)
    if(ZeroFlag) {
      goto label_1000_8816_18816;
    }
    // CALL 0x1000:6906 (1000_87FA / 0x187FA)
    NearCall(cs1, 0x87FD, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_87FD_187FD:
    // JNC 0x1000:8816 (1000_87FD / 0x187FD)
    if(!CarryFlag) {
      goto label_1000_8816_18816;
    }
    // AND word ptr [BP + 0x6],0xbfff (1000_87FF / 0x187FF)
    // UInt16[SS, (ushort)(BP + 0x6)] &= 0xBFFF;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu.And16(UInt16[SS, (ushort)(BP + 0x6)], 0xBFFF);
    // JMP 0x1000:8816 (1000_8804 / 0x18804)
    goto label_1000_8816_18816;
    label_1000_8806_18806:
    // MOV AX,0x62 (1000_8806 / 0x18806)
    AX = 0x62;
    // CMP word ptr [0x3cbe],0x0 (1000_8809 / 0x18809)
    Alu.Sub16(UInt16[DS, 0x3CBE], 0x0);
    // JNZ 0x1000:8813 (1000_880E / 0x1880E)
    if(!ZeroFlag) {
      goto label_1000_8813_18813;
    }
    // OR AH,0x40 (1000_8810 / 0x18810)
    // AH |= 0x40;
    AH = Alu.Or8(AH, 0x40);
    label_1000_8813_18813:
    // MOV word ptr [BP + 0x6],AX (1000_8813 / 0x18813)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    label_1000_8816_18816:
    // MOV BX,0xf66 (1000_8816 / 0x18816)
    BX = 0xF66;
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
    label_1000_882E_1882E:
    // MOV SI,0x1466 (1000_882E / 0x1882E)
    SI = 0x1466;
    // TEST AL,0x1 (1000_8831 / 0x18831)
    Alu.And8(AL, 0x1);
    // JZ 0x1000:8857 (1000_8833 / 0x18833)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_8857 / 0x18857)
      return NearRet();
    }
    // CMP byte ptr [0x46eb],0x0 (1000_8835 / 0x18835)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:8846 (1000_883A / 0x1883A)
    if(!SignFlag) {
      goto label_1000_8846_18846;
    }
    // TEST byte ptr [0x46eb],0x40 (1000_883C / 0x1883C)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JNZ 0x1000:8858 (1000_8841 / 0x18841)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8857_018857, 0x18858 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:5beb (1000_8843 / 0x18843)
    NearCall(cs1, 0x8846, spice86_generated_label_call_target_1000_5BEB_015BEB);
    label_1000_8846_18846:
    // LODSW SI (1000_8846 / 0x18846)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD word ptr [0x197c],AX (1000_8847 / 0x18847)
    // UInt16[DS, 0x197C] += AX;
    UInt16[DS, 0x197C] = Alu.Add16(UInt16[DS, 0x197C], AX);
    // LODSW SI (1000_884B / 0x1884B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
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
    label_1000_8850_18850:
    // CALL 0x1000:7b36 (1000_8850 / 0x18850)
    NearCall(cs1, 0x8853, spice86_generated_label_call_target_1000_7B36_017B36);
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
    label_1000_8857_18857:
    // RET  (1000_8857 / 0x18857)
    return NearRet();
    label_1000_8858_18858:
    // LODSW SI (1000_8858 / 0x18858)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD word ptr [0x1980],AX (1000_8859 / 0x18859)
    // UInt16[DS, 0x1980] += AX;
    UInt16[DS, 0x1980] = Alu.Add16(UInt16[DS, 0x1980], AX);
    // LODSW SI (1000_885D / 0x1885D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD word ptr [0x1982],AX (1000_885E / 0x1885E)
    // UInt16[DS, 0x1982] += AX;
    UInt16[DS, 0x1982] = Alu.Add16(UInt16[DS, 0x1982], AX);
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
    label_1000_8865_18865:
    // CALL 0x1000:e270 (1000_8865 / 0x18865)
    NearCall(cs1, 0x8868, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_8868_18868:
    // MOV SI,AX (1000_8868 / 0x18868)
    SI = AX;
    // MOV word ptr [0xdbe4],CX (1000_886A / 0x1886A)
    UInt16[DS, 0xDBE4] = CX;
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
    label_1000_8871_18871:
    // CALL 0x1000:cf70 (1000_8871 / 0x18871)
    NearCall(cs1, 0x8874, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_8874_18874:
    // CALL 0x1000:88f1 (1000_8874 / 0x18874)
    NearCall(cs1, 0x8877, spice86_generated_label_call_target_1000_88F1_0188F1);
    label_1000_8877_18877:
    // MOV DI,0xa6b0 (1000_8877 / 0x18877)
    DI = 0xA6B0;
    // PUSH DI (1000_887A / 0x1887A)
    Stack.Push(DI);
    // CALL 0x1000:8944 (1000_887B / 0x1887B)
    NearCall(cs1, 0x887E, spice86_generated_label_call_target_1000_8944_018944);
    label_1000_887E_1887E:
    // POP SI (1000_887E / 0x1887E)
    SI = Stack.Pop();
    // PUSH DS (1000_887F / 0x1887F)
    Stack.Push(DS);
    // POP ES (1000_8880 / 0x18880)
    ES = Stack.Pop();
    // CALL 0x1000:d1bb (1000_8881 / 0x18881)
    NearCall(cs1, 0x8884, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    label_1000_8884_18884:
    // CALL 0x1000:e283 (1000_8884 / 0x18884)
    NearCall(cs1, 0x8887, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_8887_18887:
    // RET  (1000_8887 / 0x18887)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8888_018888(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8888_18888:
    // CMP byte ptr [0x46d9],0x0 (1000_8888 / 0x18888)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JNZ 0x1000:88e1 (1000_888D / 0x1888D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_88E1_0188E1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
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
    label_1000_8895_18895:
    // MOV AL,[0xfb] (1000_8895 / 0x18895)
    AL = UInt8[DS, 0xFB];
    // NOT AL (1000_8898 / 0x18898)
    AL = (byte)~AL;
    // AND AL,0x80 (1000_889A / 0x1889A)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    // MOV [0x1c06],AL (1000_889C / 0x1889C)
    UInt8[DS, 0x1C06] = AL;
    // PUSH DS (1000_889F / 0x1889F)
    Stack.Push(DS);
    // POP ES (1000_88A0 / 0x188A0)
    ES = Stack.Pop();
    // MOV DI,0x1be2 (1000_88A1 / 0x188A1)
    DI = 0x1BE2;
    // XOR AX,AX (1000_88A4 / 0x188A4)
    AX = 0;
    // STOSW ES:DI (1000_88A6 / 0x188A6)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_88A7 / 0x188A7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_88A8 / 0x188A8)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_88A9 / 0x188A9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,0x80 (1000_88AA / 0x188AA)
    AL = 0x80;
    // STOSW ES:DI (1000_88AC / 0x188AC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // RET  (1000_88AD / 0x188AD)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_88AE_0188AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_88AE_188AE:
    // RET  (1000_88AE / 0x188AE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_88AF_0188AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_88AF_188AF:
    // OR AX,AX (1000_88AF / 0x188AF)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:88ae (1000_88B1 / 0x188B1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_88AE / 0x188AE)
      return NearRet();
    }
    // MOV [0x4780],AX (1000_88B3 / 0x188B3)
    UInt16[DS, 0x4780] = AX;
    // MOV byte ptr [0x47e0],0x0 (1000_88B6 / 0x188B6)
    UInt8[DS, 0x47E0] = 0x0;
    // TEST byte ptr [0x46eb],0x40 (1000_88BB / 0x188BB)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JZ 0x1000:88ca (1000_88C0 / 0x188C0)
    if(ZeroFlag) {
      goto label_1000_88CA_188CA;
    }
    // AND byte ptr [0x46eb],0xbf (1000_88C2 / 0x188C2)
    // UInt8[DS, 0x46EB] &= 0xBF;
    UInt8[DS, 0x46EB] = Alu.And8(UInt8[DS, 0x46EB], 0xBF);
    // JMP 0x1000:80df (1000_88C7 / 0x188C7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_80DF_0180DF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_88CA_188CA:
    // MOV SI,AX (1000_88CA / 0x188CA)
    SI = AX;
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
    label_1000_88D2_188D2:
    // MOV DI,0xa6b0 (1000_88D2 / 0x188D2)
    DI = 0xA6B0;
    // PUSH DI (1000_88D5 / 0x188D5)
    Stack.Push(DI);
    // CALL 0x1000:8944 (1000_88D6 / 0x188D6)
    NearCall(cs1, 0x88D9, spice86_generated_label_call_target_1000_8944_018944);
    label_1000_88D9_188D9:
    // POP SI (1000_88D9 / 0x188D9)
    SI = Stack.Pop();
    // CMP byte ptr [0x28e7],0x2 (1000_88DA / 0x188DA)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x2);
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
    label_1000_88E1_188E1:
    // LODSB SI (1000_88E1 / 0x188E1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_88E2 / 0x188E2)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:88f0 (1000_88E4 / 0x188E4)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_88F0 / 0x188F0)
      return NearRet();
    }
    // DEC SI (1000_88E6 / 0x188E6)
    SI = Alu.Dec16(SI);
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
    label_1000_88EA_188EA:
    // CMP byte ptr [SI],0xfe (1000_88EA / 0x188EA)
    Alu.Sub8(UInt8[DS, SI], 0xFE);
    // JNC 0x1000:88f0 (1000_88ED / 0x188ED)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_88F0 / 0x188F0)
      return NearRet();
    }
    // NOP  (1000_88EF / 0x188EF)
    
    label_1000_88F0_188F0:
    // RET  (1000_88F0 / 0x188F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_88F1_0188F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_88F1_188F1:
    // PUSH DS (1000_88F1 / 0x188F1)
    Stack.Push(DS);
    // PUSH ES (1000_88F2 / 0x188F2)
    Stack.Push(ES);
    // POP DS (1000_88F3 / 0x188F3)
    DS = Stack.Pop();
    // POP ES (1000_88F4 / 0x188F4)
    ES = Stack.Pop();
    // MOV DI,0xa840 (1000_88F5 / 0x188F5)
    DI = 0xA840;
    label_1000_88F8_188F8:
    // LODSB SI (1000_88F8 / 0x188F8)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_88F9 / 0x188F9)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:893d (1000_88FB / 0x188FB)
    if(ZeroFlag) {
      goto label_1000_893D_1893D;
    }
    // CMP AL,0xfe (1000_88FD / 0x188FD)
    Alu.Sub8(AL, 0xFE);
    // JZ 0x1000:8905 (1000_88FF / 0x188FF)
    if(ZeroFlag) {
      goto label_1000_8905_18905;
    }
    // CMP AL,0xe0 (1000_8901 / 0x18901)
    Alu.Sub8(AL, 0xE0);
    // JNC 0x1000:8910 (1000_8903 / 0x18903)
    if(!CarryFlag) {
      goto label_1000_8910_18910;
    }
    label_1000_8905_18905:
    // STOSB ES:DI (1000_8905 / 0x18905)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,0xff (1000_8906 / 0x18906)
    AL = 0xFF;
    // CMP DI,0xa9cf (1000_8908 / 0x18908)
    Alu.Sub16(DI, 0xA9CF);
    // JNC 0x1000:893d (1000_890C / 0x1890C)
    if(!CarryFlag) {
      goto label_1000_893D_1893D;
    }
    // JMP 0x1000:88f8 (1000_890E / 0x1890E)
    goto label_1000_88F8_188F8;
    label_1000_8910_18910:
    // AND AL,0xf (1000_8910 / 0x18910)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // MOV CH,AL (1000_8912 / 0x18912)
    CH = AL;
    // LODSW SI (1000_8914 / 0x18914)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CL,AH (1000_8915 / 0x18915)
    CL = AH;
    // AND AX,0x3fff (1000_8917 / 0x18917)
    AX &= 0x3FFF;
    // SHR CL,1 (1000_891A / 0x1891A)
    CL >>= 0x1;
    // SHR CL,1 (1000_891C / 0x1891C)
    CL >>= 0x1;
    // AND CL,0x30 (1000_891E / 0x1891E)
    // CL &= 0x30;
    CL = Alu.And8(CL, 0x30);
    // OR CL,CH (1000_8921 / 0x18921)
    CL |= CH;
    // XOR CH,CH (1000_8923 / 0x18923)
    CH = 0;
    // PUSH SI (1000_8925 / 0x18925)
    Stack.Push(SI);
    // MOV SI,word ptr SS:[0x47b4] (1000_8926 / 0x18926)
    SI = UInt16[SS, 0x47B4];
    // ADD SI,AX (1000_892B / 0x1892B)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_892D / 0x1892D)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP SI (1000_892F / 0x1892F)
    SI = Stack.Pop();
    // CMP byte ptr [SI],0xff (1000_8930 / 0x18930)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JZ 0x1000:893c (1000_8933 / 0x18933)
    if(ZeroFlag) {
      goto label_1000_893C_1893C;
    }
    // MOV byte ptr ES:[DI],0x20 (1000_8935 / 0x18935)
    UInt8[ES, DI] = 0x20;
    // INC DI (1000_8939 / 0x18939)
    DI = Alu.Inc16(DI);
    // JMP 0x1000:88f8 (1000_893A / 0x1893A)
    goto label_1000_88F8_188F8;
    label_1000_893C_1893C:
    // LODSB SI (1000_893C / 0x1893C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_893D_1893D:
    // STOSB ES:DI (1000_893D / 0x1893D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV SI,0xa840 (1000_893E / 0x1893E)
    SI = 0xA840;
    // PUSH SS (1000_8941 / 0x18941)
    Stack.Push(SS);
    // POP DS (1000_8942 / 0x18942)
    DS = Stack.Pop();
    // RET  (1000_8943 / 0x18943)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8944_018944(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8944_18944:
    // SUB SP,0x32 (1000_8944 / 0x18944)
    // SP -= 0x32;
    SP = Alu.Sub16(SP, 0x32);
    // MOV BP,SP (1000_8947 / 0x18947)
    BP = SP;
    // PUSH DS (1000_8949 / 0x18949)
    Stack.Push(DS);
    // POP ES (1000_894A / 0x1894A)
    ES = Stack.Pop();
    label_1000_894B_1894B:
    // CMP byte ptr [SI],0x20 (1000_894B / 0x1894B)
    Alu.Sub8(UInt8[DS, SI], 0x20);
    // JNZ 0x1000:8953 (1000_894E / 0x1894E)
    if(!ZeroFlag) {
      goto label_1000_8953_18953;
    }
    // INC SI (1000_8950 / 0x18950)
    SI = Alu.Inc16(SI);
    // JMP 0x1000:894b (1000_8951 / 0x18951)
    goto label_1000_894B_1894B;
    label_1000_8953_18953:
    // LODSB SI (1000_8953 / 0x18953)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_8954 / 0x18954)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:895b (1000_8956 / 0x18956)
    if(SignFlag) {
      goto label_1000_895B_1895B;
    }
    // STOSB ES:DI (1000_8958 / 0x18958)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // JMP 0x1000:8953 (1000_8959 / 0x18959)
    goto label_1000_8953_18953;
    label_1000_895B_1895B:
    // MOV [0x477f],AL (1000_895B / 0x1895B)
    UInt8[DS, 0x477F] = AL;
    // CMP AL,0xf0 (1000_895E / 0x1895E)
    Alu.Sub8(AL, 0xF0);
    // JNC 0x1000:89b0 (1000_8960 / 0x18960)
    if(!CarryFlag) {
      goto label_1000_89B0_189B0;
    }
    // CMP AL,0xd0 (1000_8962 / 0x18962)
    Alu.Sub8(AL, 0xD0);
    // JNC 0x1000:899b (1000_8964 / 0x18964)
    if(!CarryFlag) {
      goto label_1000_899B_1899B;
    }
    // CMP AL,0xa0 (1000_8966 / 0x18966)
    Alu.Sub8(AL, 0xA0);
    // JNC 0x1000:89ad (1000_8968 / 0x18968)
    if(!CarryFlag) {
      goto label_1000_89AD_189AD;
    }
    // CMP AL,0x90 (1000_896A / 0x1896A)
    Alu.Sub8(AL, 0x90);
    // JC 0x1000:8970 (1000_896C / 0x1896C)
    if(CarryFlag) {
      goto label_1000_8970_18970;
    }
    // JMP 0x1000:89e4 (1000_896E / 0x1896E)
    goto label_1000_89E4_189E4;
    label_1000_8970_18970:
    // CMP AL,0x80 (1000_8970 / 0x18970)
    Alu.Sub8(AL, 0x80);
    // JNZ 0x1000:8979 (1000_8972 / 0x18972)
    if(!ZeroFlag) {
      goto label_1000_8979_18979;
    }
    // LODSW SI (1000_8974 / 0x18974)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AL,AH (1000_8975 / 0x18975)
    byte tmp_1000_8975 = AL;
    AL = AH;
    AH = tmp_1000_8975;
    // JMP 0x1000:8984 (1000_8977 / 0x18977)
    goto label_1000_8984_18984;
    label_1000_8979_18979:
    // AND AX,0xf (1000_8979 / 0x18979)
    AX &= 0xF;
    // SHL AX,1 (1000_897C / 0x1897C)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BX,AX (1000_897E / 0x1897E)
    BX = AX;
    // MOV AX,word ptr [BX + 0x11eb] (1000_8980 / 0x18980)
    AX = UInt16[DS, (ushort)(BX + 0x11EB)];
    label_1000_8984_18984:
    // MOV word ptr [BP + 0x0],SI (1000_8984 / 0x18984)
    UInt16[SS, BP] = SI;
    // MOV word ptr [BP + 0x2],DS (1000_8987 / 0x18987)
    UInt16[SS, (ushort)(BP + 0x2)] = DS;
    // ADD BP,0x4 (1000_898A / 0x1898A)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    // MOV SI,AX (1000_898D / 0x1898D)
    SI = AX;
    // CALL 0x1000:8a3b (1000_898F / 0x1898F)
    NearCall(cs1, 0x8992, spice86_generated_label_call_target_1000_8A3B_018A3B);
    label_1000_8992_18992:
    // PUSH ES (1000_8992 / 0x18992)
    Stack.Push(ES);
    // CALL 0x1000:cf70 (1000_8993 / 0x18993)
    NearCall(cs1, 0x8996, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_8996_18996:
    // PUSH ES (1000_8996 / 0x18996)
    Stack.Push(ES);
    // POP DS (1000_8997 / 0x18997)
    DS = Stack.Pop();
    // POP ES (1000_8998 / 0x18998)
    ES = Stack.Pop();
    // JMP 0x1000:8953 (1000_8999 / 0x18999)
    goto label_1000_8953_18953;
    label_1000_899B_1899B:
    // STOSB ES:DI (1000_899B / 0x1899B)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOVSB ES:DI,SI (1000_899C / 0x1899C)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // CMP AL,0xd2 (1000_899D / 0x1899D)
    Alu.Sub8(AL, 0xD2);
    // JC 0x1000:89a3 (1000_899F / 0x1899F)
    if(CarryFlag) {
      goto label_1000_89A3_189A3;
    }
    // JMP 0x1000:8953 (1000_89A1 / 0x189A1)
    goto label_1000_8953_18953;
    label_1000_89A3_189A3:
    // MOVSB ES:DI,SI (1000_89A3 / 0x189A3)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // CMP AL,0xd0 (1000_89A4 / 0x189A4)
    Alu.Sub8(AL, 0xD0);
    // JNZ 0x1000:89aa (1000_89A6 / 0x189A6)
    if(!ZeroFlag) {
      goto label_1000_89AA_189AA;
    }
    // JMP 0x1000:8953 (1000_89A8 / 0x189A8)
    goto label_1000_8953_18953;
    label_1000_89AA_189AA:
    // MOVSW ES:DI,SI (1000_89AA / 0x189AA)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // JMP 0x1000:8953 (1000_89AB / 0x189AB)
    goto label_1000_8953_18953;
    label_1000_89AD_189AD:
    // STOSB ES:DI (1000_89AD / 0x189AD)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // JMP 0x1000:8953 (1000_89AE / 0x189AE)
    goto label_1000_8953_18953;
    label_1000_89B0_189B0:
    // MOV BX,SP (1000_89B0 / 0x189B0)
    BX = SP;
    // CMP BP,BX (1000_89B2 / 0x189B2)
    Alu.Sub16(BP, BX);
    // JZ 0x1000:89c1 (1000_89B4 / 0x189B4)
    if(ZeroFlag) {
      goto label_1000_89C1_189C1;
    }
    // SUB BP,0x4 (1000_89B6 / 0x189B6)
    // BP -= 0x4;
    BP = Alu.Sub16(BP, 0x4);
    // MOV SI,word ptr [BP + 0x0] (1000_89B9 / 0x189B9)
    SI = UInt16[SS, BP];
    // MOV DS,word ptr [BP + 0x2] (1000_89BC / 0x189BC)
    DS = UInt16[SS, (ushort)(BP + 0x2)];
    // JMP 0x1000:8953 (1000_89BF / 0x189BF)
    goto label_1000_8953_18953;
    label_1000_89C1_189C1:
    // STOSB ES:DI (1000_89C1 / 0x189C1)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP AL,0xff (1000_89C2 / 0x189C2)
    Alu.Sub8(AL, 0xFF);
    // JNZ 0x1000:89c8 (1000_89C4 / 0x189C4)
    if(!ZeroFlag) {
      goto label_1000_89C8_189C8;
    }
    // XOR SI,SI (1000_89C6 / 0x189C6)
    SI = 0;
    label_1000_89C8_189C8:
    // MOV word ptr [0x47b6],SI (1000_89C8 / 0x189C8)
    UInt16[DS, 0x47B6] = SI;
    // MOV word ptr [0x47b8],DS (1000_89CC / 0x189CC)
    UInt16[DS, 0x47B8] = DS;
    // ADD SP,0x32 (1000_89D0 / 0x189D0)
    SP += 0x32;
    // TEST byte ptr [0x47de],0x10 (1000_89D3 / 0x189D3)
    Alu.And8(UInt8[DS, 0x47DE], 0x10);
    // JZ 0x1000:89e3 (1000_89D8 / 0x189D8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_89E3 / 0x189E3)
      return NearRet();
    }
    // MOV BX,0x3 (1000_89DA / 0x189DA)
    BX = 0x3;
    // CALL 0x1000:e3b7 (1000_89DD / 0x189DD)
    NearCall(cs1, 0x89E0, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    label_1000_89E0_189E0:
    // CALL 0x1000:8ac3 (1000_89E0 / 0x189E0)
    NearCall(cs1, 0x89E3, spice86_generated_label_call_target_1000_8AC3_018AC3);
    label_1000_89E3_189E3:
    // RET  (1000_89E3 / 0x189E3)
    return NearRet();
    label_1000_89E4_189E4:
    // PUSH BP (1000_89E4 / 0x189E4)
    Stack.Push(BP);
    // MOV BL,AL (1000_89E5 / 0x189E5)
    BL = AL;
    // LODSB SI (1000_89E7 / 0x189E7)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_89E8 / 0x189E8)
    AH = 0;
    // MOV BP,AX (1000_89EA / 0x189EA)
    BP = AX;
    // MOV AX,word ptr [BP + 0x0] (1000_89EC / 0x189EC)
    AX = UInt16[SS, BP];
    // CMP BL,0x92 (1000_89F0 / 0x189F0)
    Alu.Sub8(BL, 0x92);
    // JZ 0x1000:89f7 (1000_89F3 / 0x189F3)
    if(ZeroFlag) {
      goto label_1000_89F7_189F7;
    }
    // XOR AH,AH (1000_89F5 / 0x189F5)
    AH = 0;
    label_1000_89F7_189F7:
    // PUSH AX (1000_89F7 / 0x189F7)
    Stack.Push(AX);
    // CALL 0x1000:8acc (1000_89F8 / 0x189F8)
    NearCall(cs1, 0x89FB, spice86_generated_label_call_target_1000_8ACC_018ACC);
    label_1000_89FB_189FB:
    // POP AX (1000_89FB / 0x189FB)
    AX = Stack.Pop();
    // CALL 0x1000:8a23 (1000_89FC / 0x189FC)
    NearCall(cs1, 0x89FF, spice86_generated_label_call_target_1000_8A23_018A23);
    label_1000_89FF_189FF:
    // XCHG AX,BX (1000_89FF / 0x189FF)
    ushort tmp_1000_89FF = AX;
    AX = BX;
    BX = tmp_1000_89FF;
    // MOV CX,0x5 (1000_8A00 / 0x18A00)
    CX = 0x5;
    // JMP 0x1000:8a0d (1000_8A03 / 0x18A03)
    goto label_1000_8A0D_18A0D;
    label_1000_8A05_18A05:
    // MOV AL,DH (1000_8A05 / 0x18A05)
    AL = DH;
    // MOV DH,DL (1000_8A07 / 0x18A07)
    DH = DL;
    // MOV DL,BH (1000_8A09 / 0x18A09)
    DL = BH;
    // MOV BH,BL (1000_8A0B / 0x18A0B)
    BH = BL;
    label_1000_8A0D_18A0D:
    // OR AL,AL (1000_8A0D / 0x18A0D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // LOOPZ 0x1000:8a05 (1000_8A0F / 0x18A0F)
    if(--CX != 0 && ZeroFlag) {
      goto label_1000_8A05_18A05;
    }
    // INC CX (1000_8A11 / 0x18A11)
    CX++;
    label_1000_8A12_18A12:
    // ADD AL,0x30 (1000_8A12 / 0x18A12)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    // STOSB ES:DI (1000_8A14 / 0x18A14)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,DH (1000_8A15 / 0x18A15)
    AL = DH;
    // MOV DH,DL (1000_8A17 / 0x18A17)
    DH = DL;
    // MOV DL,BH (1000_8A19 / 0x18A19)
    DL = BH;
    // MOV BH,BL (1000_8A1B / 0x18A1B)
    BH = BL;
    // LOOP 0x1000:8a12 (1000_8A1D / 0x18A1D)
    if(--CX != 0) {
      goto label_1000_8A12_18A12;
    }
    // POP BP (1000_8A1F / 0x18A1F)
    BP = Stack.Pop();
    // JMP 0x1000:8953 (1000_8A20 / 0x18A20)
    goto label_1000_8953_18953;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8A23_018A23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8A23_18A23:
    // XOR DX,DX (1000_8A23 / 0x18A23)
    DX = 0;
    // MOV CX,0x2710 (1000_8A25 / 0x18A25)
    CX = 0x2710;
    // DIV CX (1000_8A28 / 0x18A28)
    Cpu.Div16(CX);
    // MOV BL,AL (1000_8A2A / 0x18A2A)
    BL = AL;
    // MOV CX,0x64 (1000_8A2C / 0x18A2C)
    CX = 0x64;
    // MOV AX,DX (1000_8A2F / 0x18A2F)
    AX = DX;
    // XOR DX,DX (1000_8A31 / 0x18A31)
    DX = 0;
    // DIV CX (1000_8A33 / 0x18A33)
    Cpu.Div16(CX);
    // AAM 0xa (1000_8A35 / 0x18A35)
    Cpu.Aam(0xA);
    // XCHG AX,DX (1000_8A37 / 0x18A37)
    ushort tmp_1000_8A37 = AX;
    AX = DX;
    DX = tmp_1000_8A37;
    // AAM 0xa (1000_8A38 / 0x18A38)
    Cpu.Aam(0xA);
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
    label_1000_8A3B_18A3B:
    // TEST byte ptr [0x47de],0x10 (1000_8A3B / 0x18A3B)
    Alu.And8(UInt8[DS, 0x47DE], 0x10);
    // JNZ 0x1000:8a43 (1000_8A40 / 0x18A40)
    if(!ZeroFlag) {
      goto label_1000_8A43_18A43;
    }
    // RET  (1000_8A42 / 0x18A42)
    return NearRet();
    label_1000_8A43_18A43:
    // PUSH BX (1000_8A43 / 0x18A43)
    Stack.Push(BX);
    // MOV BH,byte ptr [0x477f] (1000_8A44 / 0x18A44)
    BH = UInt8[DS, 0x477F];
    // CMP BH,0x8b (1000_8A48 / 0x18A48)
    Alu.Sub8(BH, 0x8B);
    // JNZ 0x1000:8a52 (1000_8A4B / 0x18A4B)
    if(!ZeroFlag) {
      goto label_1000_8A52_18A52;
    }
    // SUB AX,0x108 (1000_8A4D / 0x18A4D)
    // AX -= 0x108;
    AX = Alu.Sub16(AX, 0x108);
    // JMP 0x1000:8abe (1000_8A50 / 0x18A50)
    goto label_1000_8ABE_18ABE;
    label_1000_8A52_18A52:
    // CMP BH,0x84 (1000_8A52 / 0x18A52)
    Alu.Sub8(BH, 0x84);
    // JNZ 0x1000:8a69 (1000_8A55 / 0x18A55)
    if(!ZeroFlag) {
      goto label_1000_8A69_18A69;
    }
    // SUB AX,0x48 (1000_8A57 / 0x18A57)
    // AX -= 0x48;
    AX = Alu.Sub16(AX, 0x48);
    // JZ 0x1000:8abe (1000_8A5A / 0x18A5A)
    if(ZeroFlag) {
      goto label_1000_8ABE_18ABE;
    }
    // DEC AX (1000_8A5C / 0x18A5C)
    AX--;
    // CMP AL,0x3 (1000_8A5D / 0x18A5D)
    Alu.Sub8(AL, 0x3);
    // JC 0x1000:8abe (1000_8A5F / 0x18A5F)
    if(CarryFlag) {
      goto label_1000_8ABE_18ABE;
    }
    // SUB AX,0xffcf (1000_8A61 / 0x18A61)
    AX -= 0xFFCF;
    // CMP AX,0xc (1000_8A64 / 0x18A64)
    Alu.Sub16(AX, 0xC);
    // JMP 0x1000:8abc (1000_8A67 / 0x18A67)
    goto label_1000_8ABC_18ABC;
    label_1000_8A69_18A69:
    // CMP BH,0x83 (1000_8A69 / 0x18A69)
    Alu.Sub8(BH, 0x83);
    // JZ 0x1000:8a71 (1000_8A6C / 0x18A6C)
    if(ZeroFlag) {
      goto label_1000_8A71_18A71;
    }
    // CMP BH,0x8c (1000_8A6E / 0x18A6E)
    Alu.Sub8(BH, 0x8C);
    label_1000_8A71_18A71:
    // JNZ 0x1000:8a7a (1000_8A71 / 0x18A71)
    if(!ZeroFlag) {
      goto label_1000_8A7A_18A7A;
    }
    // SUB AX,0xe8 (1000_8A73 / 0x18A73)
    AX -= 0xE8;
    // CMP AL,0x7 (1000_8A76 / 0x18A76)
    Alu.Sub8(AL, 0x7);
    // JMP 0x1000:8abc (1000_8A78 / 0x18A78)
    goto label_1000_8ABC_18ABC;
    label_1000_8A7A_18A7A:
    // MOV BL,BH (1000_8A7A / 0x18A7A)
    BL = BH;
    // SUB BL,0x86 (1000_8A7C / 0x18A7C)
    BL -= 0x86;
    // CMP BL,0x3 (1000_8A7F / 0x18A7F)
    Alu.Sub8(BL, 0x3);
    // JNC 0x1000:8a97 (1000_8A82 / 0x18A82)
    if(!CarryFlag) {
      goto label_1000_8A97_18A97;
    }
    // MOV BL,byte ptr [0x47de] (1000_8A84 / 0x18A84)
    BL = UInt8[DS, 0x47DE];
    // AND BL,0xf (1000_8A88 / 0x18A88)
    BL &= 0xF;
    // CMP BL,0x1 (1000_8A8B / 0x18A8B)
    Alu.Sub8(BL, 0x1);
    // JNZ 0x1000:8ac1 (1000_8A8E / 0x18A8E)
    if(!ZeroFlag) {
      goto label_1000_8AC1_18AC1;
    }
    // SUB AX,0xd1 (1000_8A90 / 0x18A90)
    AX -= 0xD1;
    // CMP AL,0x7 (1000_8A93 / 0x18A93)
    Alu.Sub8(AL, 0x7);
    // JMP 0x1000:8abc (1000_8A95 / 0x18A95)
    goto label_1000_8ABC_18ABC;
    label_1000_8A97_18A97:
    // CMP BH,0x85 (1000_8A97 / 0x18A97)
    Alu.Sub8(BH, 0x85);
    // JNZ 0x1000:8ab2 (1000_8A9A / 0x18A9A)
    if(!ZeroFlag) {
      goto label_1000_8AB2_18AB2;
    }
    // MOV BL,byte ptr [0x47de] (1000_8A9C / 0x18A9C)
    BL = UInt8[DS, 0x47DE];
    // AND BL,0xf (1000_8AA0 / 0x18AA0)
    BL &= 0xF;
    // CMP BL,0x1 (1000_8AA3 / 0x18AA3)
    Alu.Sub8(BL, 0x1);
    // JNZ 0x1000:8ac1 (1000_8AA6 / 0x18AA6)
    if(!ZeroFlag) {
      goto label_1000_8AC1_18AC1;
    }
    // CMP AX,0x74 (1000_8AA8 / 0x18AA8)
    Alu.Sub16(AX, 0x74);
    // MOV AL,0x0 (1000_8AAB / 0x18AAB)
    AL = 0x0;
    // JNZ 0x1000:8abe (1000_8AAD / 0x18AAD)
    if(!ZeroFlag) {
      goto label_1000_8ABE_18ABE;
    }
    // INC AX (1000_8AAF / 0x18AAF)
    AX = Alu.Inc16(AX);
    // JMP 0x1000:8abe (1000_8AB0 / 0x18AB0)
    goto label_1000_8ABE_18ABE;
    label_1000_8AB2_18AB2:
    // CMP BH,0x89 (1000_8AB2 / 0x18AB2)
    Alu.Sub8(BH, 0x89);
    // JNZ 0x1000:8ac1 (1000_8AB5 / 0x18AB5)
    if(!ZeroFlag) {
      goto label_1000_8AC1_18AC1;
    }
    // SUB AX,0xda (1000_8AB7 / 0x18AB7)
    AX -= 0xDA;
    // CMP AL,0x8 (1000_8ABA / 0x18ABA)
    Alu.Sub8(AL, 0x8);
    label_1000_8ABC_18ABC:
    // JNC 0x1000:8ac1 (1000_8ABC / 0x18ABC)
    if(!CarryFlag) {
      goto label_1000_8AC1_18AC1;
    }
    label_1000_8ABE_18ABE:
    // CALL 0x1000:8ac3 (1000_8ABE / 0x18ABE)
    NearCall(cs1, 0x8AC1, spice86_generated_label_call_target_1000_8AC3_018AC3);
    label_1000_8AC1_18AC1:
    // POP BX (1000_8AC1 / 0x18AC1)
    BX = Stack.Pop();
    label_1000_8AC2_18AC2:
    // RET  (1000_8AC2 / 0x18AC2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8AC3_018AC3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8AC3_18AC3:
    // MOV [0x47e0],AL (1000_8AC3 / 0x18AC3)
    UInt8[DS, 0x47E0] = AL;
    // AND byte ptr [0x47de],0xef (1000_8AC6 / 0x18AC6)
    // UInt8[DS, 0x47DE] &= 0xEF;
    UInt8[DS, 0x47DE] = Alu.And8(UInt8[DS, 0x47DE], 0xEF);
    // RET  (1000_8ACB / 0x18ACB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8ACC_018ACC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8ACC_18ACC:
    // TEST byte ptr SS:[0x47de],0x10 (1000_8ACC / 0x18ACC)
    Alu.And8(UInt8[SS, 0x47DE], 0x10);
    // JZ 0x1000:8ac2 (1000_8AD2 / 0x18AD2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_8AC2 / 0x18AC2)
      return NearRet();
    }
    // PUSH BX (1000_8AD4 / 0x18AD4)
    Stack.Push(BX);
    // LEA BP,[BP + 0x0] (1000_8AD5 / 0x18AD5)
    BP = BP;
    // CMP BP,0xcf (1000_8AD9 / 0x18AD9)
    Alu.Sub16(BP, 0xCF);
    // JZ 0x1000:8aff (1000_8ADD / 0x18ADD)
    if(ZeroFlag) {
      goto label_1000_8AFF_18AFF;
    }
    // CMP BP,0x55 (1000_8ADF / 0x18ADF)
    Alu.Sub16(BP, 0x55);
    // JZ 0x1000:8b07 (1000_8AE3 / 0x18AE3)
    if(ZeroFlag) {
      goto label_1000_8B07_18B07;
    }
    // CMP BP,0x61 (1000_8AE5 / 0x18AE5)
    Alu.Sub16(BP, 0x61);
    // JZ 0x1000:8b07 (1000_8AE9 / 0x18AE9)
    if(ZeroFlag) {
      goto label_1000_8B07_18B07;
    }
    // CMP BP,0x44 (1000_8AEB / 0x18AEB)
    Alu.Sub16(BP, 0x44);
    // JNZ 0x1000:8ac1 (1000_8AEF / 0x18AEF)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18AC1 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BH,byte ptr SS:[0x47de] (1000_8AF1 / 0x18AF1)
    BH = UInt8[SS, 0x47DE];
    // AND BH,0xf (1000_8AF6 / 0x18AF6)
    BH &= 0xF;
    // CMP BH,0x1 (1000_8AF9 / 0x18AF9)
    Alu.Sub8(BH, 0x1);
    // JNZ 0x1000:8ac1 (1000_8AFC / 0x18AFC)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18AC1 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC AX (1000_8AFE / 0x18AFE)
    AX--;
    label_1000_8AFF_18AFF:
    // CMP AL,0x8 (1000_8AFF / 0x18AFF)
    Alu.Sub8(AL, 0x8);
    // JBE 0x1000:8abe (1000_8B01 / 0x18B01)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,0x8 (1000_8B03 / 0x18B03)
    AL = 0x8;
    // JMP 0x1000:8abe (1000_8B05 / 0x18B05)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8B07_18B07:
    // DEC AX (1000_8B07 / 0x18B07)
    AX--;
    // CMP AL,0x4 (1000_8B08 / 0x18B08)
    Alu.Sub8(AL, 0x4);
    // JBE 0x1000:8abe (1000_8B0A / 0x18B0A)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,0x4 (1000_8B0C / 0x18B0C)
    AL = 0x4;
    // JMP 0x1000:8abe (1000_8B0E / 0x18B0E)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8A3B_018A3B, 0x18ABE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
