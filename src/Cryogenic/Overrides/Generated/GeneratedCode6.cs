namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_4F33_014F33(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4F33_14F33:
    // RET  (1000_4F33 / 0x14F33)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4F34_014F34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4F34_14F34:
    // MOV AX,[0xce7a] (1000_4F34 / 0x14F34)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0x4729],AX (1000_4F37 / 0x14F37)
    UInt16[DS, 0x4729] = AX;
    // CALL 0x1000:4b3b (1000_4F3A / 0x14F3A)
    NearCall(cs1, 0x4F3D, spice86_generated_label_call_target_1000_4B3B_014B3B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F3D_014F3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4F3D_014F3D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4FC3: goto label_1000_4FC3_14FC3;break; // Target of external jump from 0x1503A
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_4F3D_14F3D:
    // CALL 0x1000:4a1a (1000_4F3D / 0x14F3D)
    NearCall(cs1, 0x4F40, spice86_generated_label_call_target_1000_4A1A_014A1A);
    label_1000_4F40_14F40:
    // CALL 0x1000:407e (1000_4F40 / 0x14F40)
    NearCall(cs1, 0x4F43, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4F43_14F43:
    // CALL 0x1000:4a00 (1000_4F43 / 0x14F43)
    NearCall(cs1, 0x4F46, spice86_generated_label_call_target_1000_4A00_014A00);
    label_1000_4F46_14F46:
    // CALL 0x1000:b58b (1000_4F46 / 0x14F46)
    NearCall(cs1, 0x4F49, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_4F49_14F49:
    // MOV SI,word ptr [0x11c5] (1000_4F49 / 0x14F49)
    SI = UInt16[DS, 0x11C5];
    // CMP DI,word ptr [SI + 0x6] (1000_4F4D / 0x14F4D)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    // JZ 0x1000:4fb0 (1000_4F50 / 0x14F50)
    if(ZeroFlag) {
      goto label_1000_4FB0_14FB0;
    }
    // CALL 0x1000:2e52 (1000_4F52 / 0x14F52)
    NearCall(cs1, 0x4F55, spice86_generated_label_ret_target_1000_2E52_012E52);
    label_1000_4F55_14F55:
    // CMP byte ptr [0x47a7],0x0 (1000_4F55 / 0x14F55)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    // JNZ 0x1000:4f33 (1000_4F5A / 0x14F5A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    // CMP byte ptr [0x4728],0x0 (1000_4F5C / 0x14F5C)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    // JS 0x1000:4fad (1000_4F61 / 0x14F61)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JZ 0x1000:4f70 (1000_4F63 / 0x14F63)
    if(ZeroFlag) {
      goto label_1000_4F70_14F70;
    }
    // MOV byte ptr [0x4728],0x0 (1000_4F65 / 0x14F65)
    UInt8[DS, 0x4728] = 0x0;
    // CALL 0x1000:5b5d (1000_4F6A / 0x14F6A)
    NearCall(cs1, 0x4F6D, spice86_generated_label_call_target_1000_5B5D_015B5D);
    // CALL 0x1000:49d9 (1000_4F6D / 0x14F6D)
    NearCall(cs1, 0x4F70, not_observed_1000_49D9_0149D9);
    label_1000_4F70_14F70:
    // CALL 0x1000:407e (1000_4F70 / 0x14F70)
    NearCall(cs1, 0x4F73, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4F73_14F73:
    // CALL 0x1000:62d6 (1000_4F73 / 0x14F73)
    NearCall(cs1, 0x4F76, spice86_generated_label_call_target_1000_62D6_0162D6);
    label_1000_4F76_14F76:
    // JC 0x1000:4fad (1000_4F76 / 0x14F76)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP DX,0xd6 (1000_4F78 / 0x14F78)
    Alu.Sub16(DX, 0xD6);
    // JL 0x1000:4f8e (1000_4F7C / 0x14F7C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    // CMP BX,0xa (1000_4F7E / 0x14F7E)
    Alu.Sub16(BX, 0xA);
    // JL 0x1000:4f8e (1000_4F81 / 0x14F81)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    // CMP DX,0x132 (1000_4F83 / 0x14F83)
    Alu.Sub16(DX, 0x132);
    // JGE 0x1000:4f8e (1000_4F87 / 0x14F87)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    // CMP BX,0x36 (1000_4F89 / 0x14F89)
    Alu.Sub16(BX, 0x36);
    // JL 0x1000:4f95 (1000_4F8C / 0x14F8C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F95_14F95;
    }
    label_1000_4F8E_14F8E:
    // MOV byte ptr [0x4728],0x1 (1000_4F8E / 0x14F8E)
    UInt8[DS, 0x4728] = 0x1;
    // JMP 0x1000:4fad (1000_4F93 / 0x14F93)
    // JMP target is JMP, inlining.
    // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_4F95_14F95:
    // CMP byte ptr [0x11ca],0x0 (1000_4F95 / 0x14F95)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    // JNZ 0x1000:4fad (1000_4F9A / 0x14F9A)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC BX (1000_4F9C / 0x14F9C)
    BX--;
    // DEC DX (1000_4F9D / 0x14F9D)
    DX = Alu.Dec16(DX);
    // CALL 0x1000:c137 (1000_4F9E / 0x14F9E)
    NearCall(cs1, 0x4FA1, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_4FA1_14FA1:
    // MOV AX,0x30 (1000_4FA1 / 0x14FA1)
    AX = 0x30;
    // CALL 0x1000:c085 (1000_4FA4 / 0x14FA4)
    NearCall(cs1, 0x4FA7, spice86_generated_label_call_target_1000_C085_01C085);
    label_1000_4FA7_14FA7:
    // CALL 0x1000:c22f (1000_4FA7 / 0x14FA7)
    NearCall(cs1, 0x4FAA, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_4FAA_14FAA:
    // CALL 0x1000:c07c (1000_4FAA / 0x14FAA)
    NearCall(cs1, 0x4FAD, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_4FAD_14FAD:
    // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_4FB0_14FB0:
    // MOV word ptr [0x1c06],0x0 (1000_4FB0 / 0x14FB0)
    UInt16[DS, 0x1C06] = 0x0;
    // MOV AL,[0x11c9] (1000_4FB6 / 0x14FB6)
    AL = UInt8[DS, 0x11C9];
    // AND AL,0x1 (1000_4FB9 / 0x14FB9)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    // MOV [0x4732],AL (1000_4FBB / 0x14FBB)
    UInt8[DS, 0x4732] = AL;
    // JNZ 0x1000:4fc3 (1000_4FBE / 0x14FBE)
    if(!ZeroFlag) {
      goto label_1000_4FC3_14FC3;
    }
    // CALL 0x1000:ca01 (1000_4FC0 / 0x14FC0)
    NearCall(cs1, 0x4FC3, spice86_generated_label_call_target_1000_CA01_01CA01);
    label_1000_4FC3_14FC3:
    // CALL 0x1000:e3cc (1000_4FC3 / 0x14FC3)
    NearCall(cs1, 0x4FC6, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    label_1000_4FC6_14FC6:
    // MOV [0xc5],AL (1000_4FC6 / 0x14FC6)
    UInt8[DS, 0xC5] = AL;
    // XOR AL,AL (1000_4FC9 / 0x14FC9)
    AL = 0;
    // MOV [0x4727],AL (1000_4FCB / 0x14FCB)
    UInt8[DS, 0x4727] = AL;
    // XCHG byte ptr [0x11c9],AL (1000_4FCE / 0x14FCE)
    byte tmp_1000_4FCE = UInt8[DS, 0x11C9];
    UInt8[DS, 0x11C9] = AL;
    AL = tmp_1000_4FCE;
    // AND AL,0x3 (1000_4FD2 / 0x14FD2)
    AL &= 0x3;
    // DEC AL (1000_4FD4 / 0x14FD4)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:4fdf (1000_4FD6 / 0x14FD6)
    if(!ZeroFlag) {
      goto label_1000_4FDF_14FDF;
    }
    // MOV DI,word ptr [0x11c5] (1000_4FD8 / 0x14FD8)
    DI = UInt16[DS, 0x11C5];
    // INC byte ptr [DI + 0x15] (1000_4FDC / 0x14FDC)
    UInt8[DS, (ushort)(DI + 0x15)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0x15)]);
    label_1000_4FDF_14FDF:
    // CALL 0x1000:4ac4 (1000_4FDF / 0x14FDF)
    NearCall(cs1, 0x4FE2, spice86_generated_label_ret_target_1000_4AC4_014AC4);
    label_1000_4FE2_14FE2:
    // CALL 0x1000:dbb2 (1000_4FE2 / 0x14FE2)
    NearCall(cs1, 0x4FE5, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_4FE5_14FE5:
    // CALL 0x1000:d717 (1000_4FE5 / 0x14FE5)
    NearCall(cs1, 0x4FE8, spice86_generated_label_call_target_1000_D717_01D717);
    label_1000_4FE8_14FE8:
    // MOV DI,word ptr [0x11c5] (1000_4FE8 / 0x14FE8)
    DI = UInt16[DS, 0x11C5];
    // MOV BX,word ptr [DI + 0x4] (1000_4FEC / 0x14FEC)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DX,word ptr [DI + 0x2] (1000_4FEF / 0x14FEF)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV word ptr [0x11c5],0x0 (1000_4FF2 / 0x14FF2)
    UInt16[DS, 0x11C5] = 0x0;
    // JMP 0x1000:4002 (1000_4FF8 / 0x14FF8)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3F2B_013F2B, 0x14002 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4FFB_014FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4FFB_14FFB:
    // MOV word ptr [0x1c06],0x0 (1000_4FFB / 0x14FFB)
    UInt16[DS, 0x1C06] = 0x0;
    // CALL 0x1000:ca01 (1000_5001 / 0x15001)
    NearCall(cs1, 0x5004, spice86_generated_label_call_target_1000_CA01_01CA01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5004_015004, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5004_015004(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x500C: goto label_1000_500C_1500C;break; // Target of external jump from 0x1502D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_5004_15004:
    // MOV byte ptr [0x11c8],0x0 (1000_5004 / 0x15004)
    UInt8[DS, 0x11C8] = 0x0;
    // MOV CX,0xc8 (1000_5009 / 0x15009)
    CX = 0xC8;
    label_1000_500C_1500C:
    // PUSH CX (1000_500C / 0x1500C)
    Stack.Push(CX);
    // CALL 0x1000:4b3b (1000_500D / 0x1500D)
    NearCall(cs1, 0x5010, spice86_generated_label_call_target_1000_4B3B_014B3B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5010_015010, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5010_015010(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5010_15010:
    // CALL 0x1000:407e (1000_5010 / 0x15010)
    NearCall(cs1, 0x5013, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5013_015013, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5013_015013(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5013_15013:
    // CALL 0x1000:b58b (1000_5013 / 0x15013)
    NearCall(cs1, 0x5016, spice86_generated_label_call_target_1000_B58B_01B58B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5016_015016, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5016_015016(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5016_15016:
    // MOV SI,word ptr [0x11c5] (1000_5016 / 0x15016)
    SI = UInt16[DS, 0x11C5];
    // CMP DI,word ptr [SI + 0x6] (1000_501A / 0x1501A)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    // JZ 0x1000:5039 (1000_501D / 0x1501D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_5039_015039, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [0x23],0x0 (1000_501F / 0x1501F)
    UInt8[DS, 0x23] = 0x0;
    // CALL 0x1000:4182 (1000_5024 / 0x15024)
    NearCall(cs1, 0x5027, spice86_generated_label_call_target_1000_4182_014182);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5027_015027, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5027_015027(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5027_15027:
    // CMP byte ptr [0x23],0x0 (1000_5027 / 0x15027)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    // POP CX (1000_502C / 0x1502C)
    CX = Stack.Pop();
    // LOOPZ 0x1000:500c (1000_502D / 0x1502D)
    if(--CX != 0 && ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5004_015004, 0x1500C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JZ 0x1000:4fc3 (1000_502F / 0x1502F)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F3D_014F3D, 0x14FC3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD byte ptr [0x4726],0x20 (1000_5031 / 0x15031)
    // UInt8[DS, 0x4726] += 0x20;
    UInt8[DS, 0x4726] = Alu.Add8(UInt8[DS, 0x4726], 0x20);
    // JMP 0x1000:2e52 (1000_5036 / 0x15036)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_5039_015039(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5039_15039:
    // POP CX (1000_5039 / 0x15039)
    CX = Stack.Pop();
    // JMP 0x1000:4fc3 (1000_503A / 0x1503A)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F3D_014F3D, 0x14FC3 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_503C_01503C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_503C_1503C:
    // MOV byte ptr [0xfd],0x0 (1000_503C / 0x1503C)
    UInt8[DS, 0xFD] = 0x0;
    // MOV byte ptr [0x2b],0x0 (1000_5041 / 0x15041)
    UInt8[DS, 0x2B] = 0x0;
    // TEST byte ptr [DI + 0xa],0x2 (1000_5046 / 0x15046)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:5058 (1000_504A / 0x1504A)
    if(!ZeroFlag) {
      goto label_1000_5058_15058;
    }
    // CALL 0x1000:5d36 (1000_504C / 0x1504C)
    NearCall(cs1, 0x504F, spice86_generated_label_call_target_1000_5D36_015D36);
    label_1000_504F_1504F:
    // JC 0x1000:5081 (1000_504F / 0x1504F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5081 / 0x15081)
      return NearRet();
    }
    // CALL 0x1000:5098 (1000_5051 / 0x15051)
    NearCall(cs1, 0x5054, not_observed_1000_5098_015098);
    // OR DX,DX (1000_5054 / 0x15054)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:507a (1000_5056 / 0x15056)
    if(ZeroFlag) {
      goto label_1000_507A_1507A;
    }
    label_1000_5058_15058:
    // INC byte ptr [0x2b] (1000_5058 / 0x15058)
    UInt8[DS, 0x2B] = Alu.Inc8(UInt8[DS, 0x2B]);
    // CALL 0x1000:6144 (1000_505C / 0x1505C)
    NearCall(cs1, 0x505F, not_observed_1000_6144_016144);
    // MOV AL,byte ptr [DI + 0x8] (1000_505F / 0x1505F)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    // MOV AH,0x2f (1000_5062 / 0x15062)
    AH = 0x2F;
    // CMP AL,0x20 (1000_5064 / 0x15064)
    Alu.Sub8(AL, 0x20);
    // JC 0x1000:5075 (1000_5066 / 0x15066)
    if(CarryFlag) {
      goto label_1000_5075_15075;
    }
    // INC AH (1000_5068 / 0x15068)
    AH++;
    // CMP AL,0x30 (1000_506A / 0x1506A)
    Alu.Sub8(AL, 0x30);
    // JZ 0x1000:5075 (1000_506C / 0x1506C)
    if(ZeroFlag) {
      goto label_1000_5075_15075;
    }
    // SUB AL,0x28 (1000_506E / 0x1506E)
    // AL -= 0x28;
    AL = Alu.Sub8(AL, 0x28);
    // JC 0x1000:5075 (1000_5070 / 0x15070)
    if(CarryFlag) {
      goto label_1000_5075_15075;
    }
    // ADD AH,0x3 (1000_5072 / 0x15072)
    // AH += 0x3;
    AH = Alu.Add8(AH, 0x3);
    label_1000_5075_15075:
    // MOV byte ptr [0x11dd],AH (1000_5075 / 0x15075)
    UInt8[DS, 0x11DD] = AH;
    // RET  (1000_5079 / 0x15079)
    return NearRet();
    label_1000_507A_1507A:
    // JCXZ 0x1000:5081 (1000_507A / 0x1507A)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_5081 / 0x15081)
      return NearRet();
    }
    // MOV byte ptr [0x46d9],0x4 (1000_507C / 0x1507C)
    UInt8[DS, 0x46D9] = 0x4;
    label_1000_5081_15081:
    // RET  (1000_5081 / 0x15081)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5098_015098(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5098_15098:
    // MOV BP,0x5082 (1000_5098 / 0x15098)
    BP = 0x5082;
    // XOR CX,CX (1000_509B / 0x1509B)
    CX = 0;
    // XOR DX,DX (1000_509D / 0x1509D)
    DX = 0;
    // JMP 0x1000:6603 (1000_509F / 0x1509F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6603_016603, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_50A5_0150A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50A5_150A5:
    // MOV AX,[0xdc00] (1000_50A5 / 0x150A5)
    AX = UInt16[DS, 0xDC00];
    // CALL 0x1000:ca1b (1000_50A8 / 0x150A8)
    NearCall(cs1, 0x50AB, spice86_generated_label_call_target_1000_CA1B_01CA1B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50AB_0150AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50AB_0150AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50AB_150AB:
    // MOV DI,word ptr [0x1150] (1000_50AB / 0x150AB)
    DI = UInt16[DS, 0x1150];
    // CALL 0x1000:407e (1000_50AF / 0x150AF)
    NearCall(cs1, 0x50B2, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50B2_0150B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50B2_0150B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50B2_150B2:
    // CALL 0x1000:4965 (1000_50B2 / 0x150B2)
    NearCall(cs1, 0x50B5, spice86_generated_label_call_target_1000_4965_014965);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50B5_0150B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50B5_0150B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50B5_150B5:
    // CALL 0x1000:4ac4 (1000_50B5 / 0x150B5)
    NearCall(cs1, 0x50B8, spice86_generated_label_ret_target_1000_4AC4_014AC4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50B8_0150B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50B8_0150B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50B8_150B8:
    // CALL 0x1000:50be (1000_50B8 / 0x150B8)
    NearCall(cs1, 0x50BB, spice86_generated_label_call_target_1000_50BE_0150BE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50BB_0150BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50BB_0150BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50BB_150BB:
    // JMP 0x1000:2eb2 (1000_50BB / 0x150BB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2EB2_012EB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_50BE_0150BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50BE_150BE:
    // MOV byte ptr [0x11cb],0x0 (1000_50BE / 0x150BE)
    UInt8[DS, 0x11CB] = 0x0;
    // RET  (1000_50C3 / 0x150C3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_50DB_0150DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50DB_150DB:
    // MOV word ptr [0x487e],0x2 (1000_50DB / 0x150DB)
    UInt16[DS, 0x487E] = 0x2;
    // MOV byte ptr [0x473e],0x1 (1000_50E1 / 0x150E1)
    UInt8[DS, 0x473E] = 0x1;
    // MOV AL,0x4 (1000_50E6 / 0x150E6)
    AL = 0x4;
    // JMP 0x1000:50ef (1000_50E8 / 0x150E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_50EF_0150EF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_50EF_0150EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50EF_150EF:
    // MOV DI,word ptr [0x46f8] (1000_50EF / 0x150EF)
    DI = UInt16[DS, 0x46F8];
    // PUSH DI (1000_50F3 / 0x150F3)
    Stack.Push(DI);
    // PUSH AX (1000_50F4 / 0x150F4)
    Stack.Push(AX);
    // CALL 0x1000:d2bd (1000_50F5 / 0x150F5)
    NearCall(cs1, 0x50F8, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50F8_0150F8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50F8_0150F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50F8_150F8:
    // CALL 0x1000:49ea (1000_50F8 / 0x150F8)
    NearCall(cs1, 0x50FB, spice86_generated_label_call_target_1000_49EA_0149EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50FB_0150FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50FB_0150FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_50FB_150FB:
    // MOV DX,word ptr [0x4] (1000_50FB / 0x150FB)
    DX = UInt16[DS, 0x4];
    // MOV BX,word ptr [0x6] (1000_50FF / 0x150FF)
    BX = UInt16[DS, 0x6];
    // POP AX (1000_5103 / 0x15103)
    AX = Stack.Pop();
    // PUSH AX (1000_5104 / 0x15104)
    Stack.Push(AX);
    // CMP AL,0x4 (1000_5105 / 0x15105)
    Alu.Sub8(AL, 0x4);
    // JNZ 0x1000:510b (1000_5107 / 0x15107)
    if(!ZeroFlag) {
      goto label_1000_510B_1510B;
    }
    // MOV DL,0x1 (1000_5109 / 0x15109)
    DL = 0x1;
    label_1000_510B_1510B:
    // CALL 0x1000:4057 (1000_510B / 0x1510B)
    NearCall(cs1, 0x510E, spice86_generated_label_ret_target_1000_4057_014057);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_510E_01510E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_510E_01510E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_510E_1510E:
    // CALL 0x1000:186b (1000_510E / 0x1510E)
    NearCall(cs1, 0x5111, spice86_generated_label_ret_target_1000_186B_01186B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5111_015111, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5111_015111(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5111_15111:
    // POP AX (1000_5111 / 0x15111)
    AX = Stack.Pop();
    // MOV [0x11c9],AL (1000_5112 / 0x15112)
    UInt8[DS, 0x11C9] = AL;
    // POP DI (1000_5115 / 0x15115)
    DI = Stack.Pop();
    // JMP 0x1000:4703 (1000_5116 / 0x15116)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4703_014703, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5119_015119(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5119_15119:
    // ADD byte ptr [0x11c7],AL (1000_5119 / 0x15119)
    // UInt8[DS, 0x11C7] += AL;
    UInt8[DS, 0x11C7] = Alu.Add8(UInt8[DS, 0x11C7], AL);
    // MOV word ptr [0x11cc],0x80 (1000_511D / 0x1511D)
    UInt16[DS, 0x11CC] = 0x80;
    // RET  (1000_5123 / 0x15123)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5124_015124(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5124_15124:
    // PUSH DI (1000_5124 / 0x15124)
    Stack.Push(DI);
    // CALL 0x1000:407e (1000_5125 / 0x15125)
    NearCall(cs1, 0x5128, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5128_015128, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5128_015128(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5128_15128:
    // MOV CX,word ptr [DI + 0x4] (1000_5128 / 0x15128)
    CX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DI,word ptr [DI + 0x2] (1000_512B / 0x1512B)
    DI = UInt16[DS, (ushort)(DI + 0x2)];
    // CALL 0x1000:5133 (1000_512E / 0x1512E)
    NearCall(cs1, 0x5131, spice86_generated_label_call_target_1000_5133_015133);
    label_1000_5131_15131:
    // POP DI (1000_5131 / 0x15131)
    DI = Stack.Pop();
    // RET  (1000_5132 / 0x15132)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5133_015133(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5133_15133:
    // SUB BX,CX (1000_5133 / 0x15133)
    BX -= CX;
    // NEG BX (1000_5135 / 0x15135)
    BX = Alu.Sub16(0, BX);
    // SUB DX,DI (1000_5137 / 0x15137)
    DX -= DI;
    // NEG DX (1000_5139 / 0x15139)
    DX = Alu.Sub16(0, DX);
    // CMP BX,-0x80 (1000_513B / 0x1513B)
    Alu.Sub16(BX, 0xFF80);
    // JL 0x1000:5146 (1000_513E / 0x1513E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5146_15146;
    }
    // CMP BX,0x80 (1000_5140 / 0x15140)
    Alu.Sub16(BX, 0x80);
    // JL 0x1000:514a (1000_5144 / 0x15144)
    if(SignFlag != OverflowFlag) {
      goto label_1000_514A_1514A;
    }
    label_1000_5146_15146:
    // SAR BX,1 (1000_5146 / 0x15146)
    BX = Alu.Sar16(BX, 0x1);
    // SAR DX,1 (1000_5148 / 0x15148)
    DX = Alu.Sar16(DX, 0x1);
    label_1000_514A_1514A:
    // MOV BH,BL (1000_514A / 0x1514A)
    BH = BL;
    // XOR BL,BL (1000_514C / 0x1514C)
    BL = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_514E_01514E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_514E_01514E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_514E_1514E:
    // OR BX,BX (1000_514E / 0x1514E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // MOV AX,BX (1000_5150 / 0x15150)
    AX = BX;
    // JNS 0x1000:5156 (1000_5152 / 0x15152)
    if(!SignFlag) {
      goto label_1000_5156_15156;
    }
    // NEG AX (1000_5154 / 0x15154)
    AX = Alu.Sub16(0, AX);
    label_1000_5156_15156:
    // OR DX,DX (1000_5156 / 0x15156)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // MOV DI,DX (1000_5158 / 0x15158)
    DI = DX;
    // MOV CX,DX (1000_515A / 0x1515A)
    CX = DX;
    // JNS 0x1000:5160 (1000_515C / 0x1515C)
    if(!SignFlag) {
      goto label_1000_5160_15160;
    }
    // NEG CX (1000_515E / 0x1515E)
    CX = Alu.Sub16(0, CX);
    label_1000_5160_15160:
    // CMP CX,AX (1000_5160 / 0x15160)
    Alu.Sub16(CX, AX);
    // JC 0x1000:5180 (1000_5162 / 0x15162)
    if(CarryFlag) {
      goto label_1000_5180_15180;
    }
    // CMP CX,0x1 (1000_5164 / 0x15164)
    Alu.Sub16(CX, 0x1);
    // JC 0x1000:517f (1000_5167 / 0x15167)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_517F / 0x1517F)
      return NearRet();
    }
    // MOV AX,0x20 (1000_5169 / 0x15169)
    AX = 0x20;
    // MOV CX,DX (1000_516C / 0x1516C)
    CX = DX;
    // IMUL BX (1000_516E / 0x1516E)
    Cpu.IMul16(BX);
    // IDIV CX (1000_5170 / 0x15170)
    Cpu.IDiv16(CX);
    // MOV DX,DI (1000_5172 / 0x15172)
    DX = DI;
    // OR CX,CX (1000_5174 / 0x15174)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JS 0x1000:517c (1000_5176 / 0x15176)
    if(SignFlag) {
      goto label_1000_517C_1517C;
    }
    // ADD AL,0x40 (1000_5178 / 0x15178)
    // AL += 0x40;
    AL = Alu.Add8(AL, 0x40);
    // CLC  (1000_517A / 0x1517A)
    CarryFlag = false;
    // RET  (1000_517B / 0x1517B)
    return NearRet();
    label_1000_517C_1517C:
    // ADD AL,0xc0 (1000_517C / 0x1517C)
    // AL += 0xC0;
    AL = Alu.Add8(AL, 0xC0);
    // CLC  (1000_517E / 0x1517E)
    CarryFlag = false;
    label_1000_517F_1517F:
    // RET  (1000_517F / 0x1517F)
    return NearRet();
    label_1000_5180_15180:
    // CMP AX,0x1 (1000_5180 / 0x15180)
    Alu.Sub16(AX, 0x1);
    // JC 0x1000:517f (1000_5183 / 0x15183)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_517F / 0x1517F)
      return NearRet();
    }
    // MOV AX,0x20 (1000_5185 / 0x15185)
    AX = 0x20;
    // IMUL DX (1000_5188 / 0x15188)
    Cpu.IMul16(DX);
    // IDIV BX (1000_518A / 0x1518A)
    Cpu.IDiv16(BX);
    // MOV DX,DI (1000_518C / 0x1518C)
    DX = DI;
    // OR BX,BX (1000_518E / 0x1518E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JS 0x1000:5194 (1000_5190 / 0x15190)
    if(SignFlag) {
      goto label_1000_5194_15194;
    }
    // SUB AL,0x80 (1000_5192 / 0x15192)
    AL -= 0x80;
    label_1000_5194_15194:
    // NEG AL (1000_5194 / 0x15194)
    AL = Alu.Sub8(0, AL);
    // CLC  (1000_5196 / 0x15196)
    CarryFlag = false;
    // RET  (1000_5197 / 0x15197)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5198_015198(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5198_15198:
    // MOV BX,AX (1000_5198 / 0x15198)
    BX = AX;
    // ADD BL,0x20 (1000_519A / 0x1519A)
    // BL += 0x20;
    BL = Alu.Add8(BL, 0x20);
    // MOV BH,BL (1000_519D / 0x1519D)
    BH = BL;
    // AND BH,0x7f (1000_519F / 0x1519F)
    BH &= 0x7F;
    // CMP BH,0x40 (1000_51A2 / 0x151A2)
    Alu.Sub8(BH, 0x40);
    // JC 0x1000:51ba (1000_51A5 / 0x151A5)
    if(CarryFlag) {
      goto label_1000_51BA_151BA;
    }
    // MOV DX,0x20 (1000_51A7 / 0x151A7)
    DX = 0x20;
    // SUB AL,0x40 (1000_51AA / 0x151AA)
    // AL -= 0x40;
    AL = Alu.Sub8(AL, 0x40);
    // OR BL,BL (1000_51AC / 0x151AC)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JNS 0x1000:51b6 (1000_51AE / 0x151AE)
    if(!SignFlag) {
      goto label_1000_51B6_151B6;
    }
    // NEG DX (1000_51B0 / 0x151B0)
    DX = Alu.Sub16(0, DX);
    // SUB AL,0x80 (1000_51B2 / 0x151B2)
    AL -= 0x80;
    // NEG AL (1000_51B4 / 0x151B4)
    AL = Alu.Sub8(0, AL);
    label_1000_51B6_151B6:
    // CBW  (1000_51B6 / 0x151B6)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BX,AX (1000_51B7 / 0x151B7)
    BX = AX;
    // RET  (1000_51B9 / 0x151B9)
    return NearRet();
    label_1000_51BA_151BA:
    // OR BL,BL (1000_51BA / 0x151BA)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // MOV BX,0xffe0 (1000_51BC / 0x151BC)
    BX = 0xFFE0;
    // JNS 0x1000:51c7 (1000_51BF / 0x151BF)
    if(!SignFlag) {
      goto label_1000_51C7_151C7;
    }
    // SUB AL,0x80 (1000_51C1 / 0x151C1)
    AL -= 0x80;
    // NEG AL (1000_51C3 / 0x151C3)
    AL = Alu.Sub8(0, AL);
    // NEG BX (1000_51C5 / 0x151C5)
    BX = Alu.Sub16(0, BX);
    label_1000_51C7_151C7:
    // CBW  (1000_51C7 / 0x151C7)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_51C8 / 0x151C8)
    DX = AX;
    // RET  (1000_51CA / 0x151CA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_51CB_0151CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_51CB_151CB:
    // CMP byte ptr [0x11cb],0x0 (1000_51CB / 0x151CB)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    // JNZ 0x1000:51d9 (1000_51D0 / 0x151D0)
    if(!ZeroFlag) {
      goto label_1000_51D9_151D9;
    }
    // CMP byte ptr [0x11c8],0x0 (1000_51D2 / 0x151D2)
    Alu.Sub8(UInt8[DS, 0x11C8], 0x0);
    // JZ 0x1000:51f5 (1000_51D7 / 0x151D7)
    if(ZeroFlag) {
      goto label_1000_51F5_151F5;
    }
    label_1000_51D9_151D9:
    // CMP BX,-0x4d (1000_51D9 / 0x151D9)
    Alu.Sub16(BX, 0xFFB3);
    // JL 0x1000:51e3 (1000_51DC / 0x151DC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_51E3_151E3;
    }
    // CMP BX,0x4d (1000_51DE / 0x151DE)
    Alu.Sub16(BX, 0x4D);
    // JLE 0x1000:5205 (1000_51E1 / 0x151E1)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    label_1000_51E3_151E3:
    // MOV AL,[0x11c7] (1000_51E3 / 0x151E3)
    AL = UInt8[DS, 0x11C7];
    // MOV AH,AL (1000_51E6 / 0x151E6)
    AH = AL;
    // SUB AH,0x40 (1000_51E8 / 0x151E8)
    AH -= 0x40;
    // XOR AH,BH (1000_51EB / 0x151EB)
    // AH ^= BH;
    AH = Alu.Xor8(AH, BH);
    // JS 0x1000:5205 (1000_51ED / 0x151ED)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    // AND AL,0x80 (1000_51EF / 0x151EF)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    // OR AL,0x40 (1000_51F1 / 0x151F1)
    // AL |= 0x40;
    AL = Alu.Or8(AL, 0x40);
    // JMP 0x1000:5202 (1000_51F3 / 0x151F3)
    goto label_1000_5202_15202;
    label_1000_51F5_151F5:
    // MOV DI,word ptr [0x11c5] (1000_51F5 / 0x151F5)
    DI = UInt16[DS, 0x11C5];
    // PUSH BX (1000_51F9 / 0x151F9)
    Stack.Push(BX);
    // PUSH DX (1000_51FA / 0x151FA)
    Stack.Push(DX);
    // CALL 0x1000:5124 (1000_51FB / 0x151FB)
    NearCall(cs1, 0x51FE, spice86_generated_label_call_target_1000_5124_015124);
    label_1000_51FE_151FE:
    // POP DX (1000_51FE / 0x151FE)
    DX = Stack.Pop();
    // POP BX (1000_51FF / 0x151FF)
    BX = Stack.Pop();
    // JC 0x1000:5205 (1000_5200 / 0x15200)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    label_1000_5202_15202:
    // MOV [0x11c7],AL (1000_5202 / 0x15202)
    UInt8[DS, 0x11C7] = AL;
    label_1000_5205_15205:
    // RET  (1000_5205 / 0x15205)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5206_015206(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5206_15206:
    // CALL 0x1000:51cb (1000_5206 / 0x15206)
    NearCall(cs1, 0x5209, spice86_generated_label_call_target_1000_51CB_0151CB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5209_015209, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5209_015209(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5209_15209:
    // MOV AL,[0x11c7] (1000_5209 / 0x15209)
    AL = UInt8[DS, 0x11C7];
    // PUSH DX (1000_520C / 0x1520C)
    Stack.Push(DX);
    // PUSH BX (1000_520D / 0x1520D)
    Stack.Push(BX);
    // SHL BX,1 (1000_520E / 0x1520E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // JNS 0x1000:5214 (1000_5210 / 0x15210)
    if(!SignFlag) {
      goto label_1000_5214_15214;
    }
    // NEG BX (1000_5212 / 0x15212)
    BX = Alu.Sub16(0, BX);
    label_1000_5214_15214:
    // MOV BP,word ptr [BX + 0x4880] (1000_5214 / 0x15214)
    BP = UInt16[DS, (ushort)(BX + 0x4880)];
    // CALL 0x1000:5198 (1000_5218 / 0x15218)
    NearCall(cs1, 0x521B, spice86_generated_label_call_target_1000_5198_015198);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_521B_01521B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_521B_01521B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_521B_1521B:
    // MOV CX,0x20 (1000_521B / 0x1521B)
    CX = 0x20;
    // MOV AX,BP (1000_521E / 0x1521E)
    AX = BP;
    // IMUL DX (1000_5220 / 0x15220)
    Cpu.IMul16(DX);
    // IDIV CX (1000_5222 / 0x15222)
    Cpu.IDiv16(CX);
    // XCHG AX,BX (1000_5224 / 0x15224)
    ushort tmp_1000_5224 = AX;
    AX = BX;
    BX = tmp_1000_5224;
    // IMUL BP (1000_5225 / 0x15225)
    Cpu.IMul16(BP);
    // IDIV CX (1000_5227 / 0x15227)
    Cpu.IDiv16(CX);
    // MOV DX,BX (1000_5229 / 0x15229)
    DX = BX;
    // MOV BX,AX (1000_522B / 0x1522B)
    BX = AX;
    // OR AX,AX (1000_522D / 0x1522D)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:5233 (1000_522F / 0x1522F)
    if(!SignFlag) {
      goto label_1000_5233_15233;
    }
    // NEG AX (1000_5231 / 0x15231)
    AX = Alu.Sub16(0, AX);
    label_1000_5233_15233:
    // ADD AX,word ptr [0x11cc] (1000_5233 / 0x15233)
    AX += UInt16[DS, 0x11CC];
    // CMP AH,0x1 (1000_5237 / 0x15237)
    Alu.Sub8(AH, 0x1);
    // JBE 0x1000:524e (1000_523A / 0x1523A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_524E_1524E;
    }
    // MOV CX,AX (1000_523C / 0x1523C)
    CX = AX;
    // MOV AX,DX (1000_523E / 0x1523E)
    AX = DX;
    // CWD  (1000_5240 / 0x15240)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    // MOV DL,AH (1000_5241 / 0x15241)
    DL = AH;
    // MOV AH,AL (1000_5243 / 0x15243)
    AH = AL;
    // XOR AL,AL (1000_5245 / 0x15245)
    AL = 0;
    // IDIV CX (1000_5247 / 0x15247)
    Cpu.IDiv16(CX);
    // MOV DX,AX (1000_5249 / 0x15249)
    DX = AX;
    // MOV AX,0x100 (1000_524B / 0x1524B)
    AX = 0x100;
    label_1000_524E_1524E:
    // MOV [0x11cc],AL (1000_524E / 0x1524E)
    UInt8[DS, 0x11CC] = AL;
    // MOV AL,AH (1000_5251 / 0x15251)
    AL = AH;
    // CBW  (1000_5253 / 0x15253)
    AX = (ushort)((short)((sbyte)AL));
    // OR BX,BX (1000_5254 / 0x15254)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNS 0x1000:525a (1000_5256 / 0x15256)
    if(!SignFlag) {
      goto label_1000_525A_1525A;
    }
    // NEG AX (1000_5258 / 0x15258)
    AX = Alu.Sub16(0, AX);
    label_1000_525A_1525A:
    // POP BX (1000_525A / 0x1525A)
    BX = Stack.Pop();
    // ADD BX,AX (1000_525B / 0x1525B)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // POP AX (1000_525D / 0x1525D)
    AX = Stack.Pop();
    // ADD DX,AX (1000_525E / 0x1525E)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // MOV AX,BX (1000_5260 / 0x15260)
    AX = BX;
    // ADD AX,0x60 (1000_5262 / 0x15262)
    AX += 0x60;
    // CMP AX,0xc0 (1000_5265 / 0x15265)
    Alu.Sub16(AX, 0xC0);
    // JC 0x1000:5273 (1000_5268 / 0x15268)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5273 / 0x15273)
      return NearRet();
    }
    // ADD byte ptr [0x11c7],0x80 (1000_526A / 0x1526A)
    UInt8[DS, 0x11C7] += 0x80;
    // ADD DX,0x8000 (1000_526F / 0x1526F)
    // DX += 0x8000;
    DX = Alu.Add16(DX, 0x8000);
    label_1000_5273_15273:
    // RET  (1000_5273 / 0x15273)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5274_015274(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5274_15274:
    // MOV DX,word ptr [DI + 0x2] (1000_5274 / 0x15274)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_5277 / 0x15277)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // PUSH SI (1000_527A / 0x1527A)
    Stack.Push(SI);
    // MOV AX,0xffff (1000_527B / 0x1527B)
    AX = 0xFFFF;
    // MOV [0xca],AX (1000_527E / 0x1527E)
    UInt16[DS, 0xCA] = AX;
    // MOV [0xd0],AX (1000_5281 / 0x15281)
    UInt16[DS, 0xD0] = AX;
    // MOV [0xd6],AX (1000_5284 / 0x15284)
    UInt16[DS, 0xD6] = AX;
    // MOV [0xdc],AX (1000_5287 / 0x15287)
    UInt16[DS, 0xDC] = AX;
    // MOV [0xe2],AX (1000_528A / 0x1528A)
    UInt16[DS, 0xE2] = AX;
    // MOV SI,0x100 (1000_528D / 0x1528D)
    SI = 0x100;
    label_1000_5290_15290:
    // CMP word ptr [SI],-0x1 (1000_5290 / 0x15290)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JZ 0x1000:52fb (1000_5293 / 0x15293)
    if(ZeroFlag) {
      goto label_1000_52FB_152FB;
    }
    // CMP SI,DI (1000_5295 / 0x15295)
    Alu.Sub16(SI, DI);
    // JZ 0x1000:52f6 (1000_5297 / 0x15297)
    if(ZeroFlag) {
      goto label_1000_52F6_152F6;
    }
    // MOV CX,word ptr [SI + 0x2] (1000_5299 / 0x15299)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB CX,DX (1000_529C / 0x1529C)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // JNS 0x1000:52a2 (1000_529E / 0x1529E)
    if(!SignFlag) {
      goto label_1000_52A2_152A2;
    }
    // NEG CX (1000_52A0 / 0x152A0)
    CX = Alu.Sub16(0, CX);
    label_1000_52A2_152A2:
    // MOV AX,word ptr [SI + 0x4] (1000_52A2 / 0x152A2)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // SUB AX,BX (1000_52A5 / 0x152A5)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JNS 0x1000:52ab (1000_52A7 / 0x152A7)
    if(!SignFlag) {
      goto label_1000_52AB_152AB;
    }
    // NEG AX (1000_52A9 / 0x152A9)
    AX = Alu.Sub16(0, AX);
    label_1000_52AB_152AB:
    // MOV CL,CH (1000_52AB / 0x152AB)
    CL = CH;
    // XOR CH,CH (1000_52AD / 0x152AD)
    CH = 0;
    // CMP CL,AL (1000_52AF / 0x152AF)
    Alu.Sub8(CL, AL);
    // JNC 0x1000:52b5 (1000_52B1 / 0x152B1)
    if(!CarryFlag) {
      goto label_1000_52B5_152B5;
    }
    // MOV CX,AX (1000_52B3 / 0x152B3)
    CX = AX;
    label_1000_52B5_152B5:
    // CMP byte ptr [SI + 0x8],0x28 (1000_52B5 / 0x152B5)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x8)], 0x28);
    // JC 0x1000:52c9 (1000_52B9 / 0x152B9)
    if(CarryFlag) {
      goto label_1000_52C9_152C9;
    }
    // MOV BP,0xe2 (1000_52BB / 0x152BB)
    BP = 0xE2;
    // TEST byte ptr [SI + 0xa],0x80 (1000_52BE / 0x152BE)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JNZ 0x1000:52dd (1000_52C2 / 0x152C2)
    if(!ZeroFlag) {
      goto label_1000_52DD_152DD;
    }
    // MOV BP,0xdc (1000_52C4 / 0x152C4)
    BP = 0xDC;
    // JMP 0x1000:52dd (1000_52C7 / 0x152C7)
    goto label_1000_52DD_152DD;
    label_1000_52C9_152C9:
    // MOV BP,0xd0 (1000_52C9 / 0x152C9)
    BP = 0xD0;
    // TEST byte ptr [SI + 0xa],0x80 (1000_52CC / 0x152CC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JZ 0x1000:52dd (1000_52D0 / 0x152D0)
    if(ZeroFlag) {
      goto label_1000_52DD_152DD;
    }
    // MOV AL,[0x2a] (1000_52D2 / 0x152D2)
    AL = UInt8[DS, 0x2A];
    // CMP AL,byte ptr [SI + 0xb] (1000_52D5 / 0x152D5)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    // JC 0x1000:52f6 (1000_52D8 / 0x152D8)
    if(CarryFlag) {
      goto label_1000_52F6_152F6;
    }
    // MOV BP,0xd6 (1000_52DA / 0x152DA)
    BP = 0xD6;
    label_1000_52DD_152DD:
    // CMP CX,word ptr [BP + 0x0] (1000_52DD / 0x152DD)
    Alu.Sub16(CX, UInt16[SS, BP]);
    // JNC 0x1000:52e8 (1000_52E0 / 0x152E0)
    if(!CarryFlag) {
      goto label_1000_52E8_152E8;
    }
    // MOV word ptr [BP + 0x0],CX (1000_52E2 / 0x152E2)
    UInt16[SS, BP] = CX;
    // MOV word ptr [BP + 0x2],SI (1000_52E5 / 0x152E5)
    UInt16[SS, (ushort)(BP + 0x2)] = SI;
    label_1000_52E8_152E8:
    // CMP CX,word ptr [0xca] (1000_52E8 / 0x152E8)
    Alu.Sub16(CX, UInt16[DS, 0xCA]);
    // JNC 0x1000:52f6 (1000_52EC / 0x152EC)
    if(!CarryFlag) {
      goto label_1000_52F6_152F6;
    }
    // MOV word ptr [0xca],CX (1000_52EE / 0x152EE)
    UInt16[DS, 0xCA] = CX;
    // MOV word ptr [0xcc],SI (1000_52F2 / 0x152F2)
    UInt16[DS, 0xCC] = SI;
    label_1000_52F6_152F6:
    // ADD SI,0x1c (1000_52F6 / 0x152F6)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    // JMP 0x1000:5290 (1000_52F9 / 0x152F9)
    goto label_1000_5290_15290;
    label_1000_52FB_152FB:
    // PUSH DI (1000_52FB / 0x152FB)
    Stack.Push(DI);
    // MOV BP,0xde (1000_52FC / 0x152FC)
    BP = 0xDE;
    // CALL 0x1000:5323 (1000_52FF / 0x152FF)
    NearCall(cs1, 0x5302, spice86_generated_label_call_target_1000_5323_015323);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5302_015302, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5302_015302(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5302_15302:
    // MOV BP,0xe4 (1000_5302 / 0x15302)
    BP = 0xE4;
    // CALL 0x1000:5323 (1000_5305 / 0x15305)
    NearCall(cs1, 0x5308, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_5308_15308:
    // MOV BP,0xd8 (1000_5308 / 0x15308)
    BP = 0xD8;
    // CALL 0x1000:5323 (1000_530B / 0x1530B)
    NearCall(cs1, 0x530E, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_530E_1530E:
    // ADD AX,0xda (1000_530E / 0x1530E)
    // AX += 0xDA;
    AX = Alu.Add16(AX, 0xDA);
    // MOV [0x11fd],AX (1000_5311 / 0x15311)
    UInt16[DS, 0x11FD] = AX;
    // MOV BP,0xcc (1000_5314 / 0x15314)
    BP = 0xCC;
    // CALL 0x1000:5323 (1000_5317 / 0x15317)
    NearCall(cs1, 0x531A, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_531A_1531A:
    // MOV BP,0xd2 (1000_531A / 0x1531A)
    BP = 0xD2;
    // CALL 0x1000:5323 (1000_531D / 0x1531D)
    NearCall(cs1, 0x5320, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_5320_15320:
    // POP DI (1000_5320 / 0x15320)
    DI = Stack.Pop();
    // POP SI (1000_5321 / 0x15321)
    SI = Stack.Pop();
    // RET  (1000_5322 / 0x15322)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5323_015323(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5323_15323:
    // PUSH BX (1000_5323 / 0x15323)
    Stack.Push(BX);
    // PUSH DX (1000_5324 / 0x15324)
    Stack.Push(DX);
    // MOV DI,word ptr [BP + 0x0] (1000_5325 / 0x15325)
    DI = UInt16[SS, BP];
    // MOV CX,word ptr [DI + 0x4] (1000_5328 / 0x15328)
    CX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DI,word ptr [DI + 0x2] (1000_532B / 0x1532B)
    DI = UInt16[DS, (ushort)(DI + 0x2)];
    // PUSH BP (1000_532E / 0x1532E)
    Stack.Push(BP);
    // CALL 0x1000:5133 (1000_532F / 0x1532F)
    NearCall(cs1, 0x5332, spice86_generated_label_call_target_1000_5133_015133);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5332_015332, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5332_015332(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5332_15332:
    // POP BP (1000_5332 / 0x15332)
    BP = Stack.Pop();
    // ADD AL,0x10 (1000_5333 / 0x15333)
    AL += 0x10;
    // ROL AL,1 (1000_5335 / 0x15335)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,1 (1000_5337 / 0x15337)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,1 (1000_5339 / 0x15339)
    AL = Alu.Rol8(AL, 0x1);
    // AND AX,0x7 (1000_533B / 0x1533B)
    // AX &= 0x7;
    AX = Alu.And16(AX, 0x7);
    // MOV byte ptr [BP + 0x2],AL (1000_533E / 0x1533E)
    UInt8[SS, (ushort)(BP + 0x2)] = AL;
    // POP DX (1000_5341 / 0x15341)
    DX = Stack.Pop();
    // POP BX (1000_5342 / 0x15342)
    BX = Stack.Pop();
    // RET  (1000_5343 / 0x15343)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5344_015344(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5344_15344:
    // PUSH SI (1000_5344 / 0x15344)
    Stack.Push(SI);
    // MOV BP,0xffff (1000_5345 / 0x15345)
    BP = 0xFFFF;
    // MOV SI,0x100 (1000_5348 / 0x15348)
    SI = 0x100;
    label_1000_534B_1534B:
    // CMP word ptr [SI],-0x1 (1000_534B / 0x1534B)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JZ 0x1000:537f (1000_534E / 0x1534E)
    if(ZeroFlag) {
      goto label_1000_537F_1537F;
    }
    // TEST byte ptr [SI + 0xa],0x80 (1000_5350 / 0x15350)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JNZ 0x1000:537a (1000_5354 / 0x15354)
    if(!ZeroFlag) {
      goto label_1000_537A_1537A;
    }
    // MOV CX,word ptr [SI + 0x2] (1000_5356 / 0x15356)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB CX,DX (1000_5359 / 0x15359)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // JNS 0x1000:535f (1000_535B / 0x1535B)
    if(!SignFlag) {
      goto label_1000_535F_1535F;
    }
    // NEG CX (1000_535D / 0x1535D)
    CX = Alu.Sub16(0, CX);
    label_1000_535F_1535F:
    // MOV AX,word ptr [SI + 0x4] (1000_535F / 0x1535F)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // SUB AX,BX (1000_5362 / 0x15362)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JNS 0x1000:5368 (1000_5364 / 0x15364)
    if(!SignFlag) {
      goto label_1000_5368_15368;
    }
    // NEG AX (1000_5366 / 0x15366)
    AX = Alu.Sub16(0, AX);
    label_1000_5368_15368:
    // MOV CL,CH (1000_5368 / 0x15368)
    CL = CH;
    // XOR CH,CH (1000_536A / 0x1536A)
    CH = 0;
    // CMP CL,AL (1000_536C / 0x1536C)
    Alu.Sub8(CL, AL);
    // JNC 0x1000:5372 (1000_536E / 0x1536E)
    if(!CarryFlag) {
      goto label_1000_5372_15372;
    }
    // MOV CX,AX (1000_5370 / 0x15370)
    CX = AX;
    label_1000_5372_15372:
    // CMP CX,BP (1000_5372 / 0x15372)
    Alu.Sub16(CX, BP);
    // JNC 0x1000:537a (1000_5374 / 0x15374)
    if(!CarryFlag) {
      goto label_1000_537A_1537A;
    }
    // MOV BP,CX (1000_5376 / 0x15376)
    BP = CX;
    // MOV DI,SI (1000_5378 / 0x15378)
    DI = SI;
    label_1000_537A_1537A:
    // ADD SI,0x1c (1000_537A / 0x1537A)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    // JMP 0x1000:534b (1000_537D / 0x1537D)
    goto label_1000_534B_1534B;
    label_1000_537F_1537F:
    // POP SI (1000_537F / 0x1537F)
    SI = Stack.Pop();
    // RET  (1000_5380 / 0x15380)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5406_015406(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5406_15406:
    // MOV DX,word ptr [0x11c1] (1000_5406 / 0x15406)
    DX = UInt16[DS, 0x11C1];
    // MOV BX,word ptr [0x11c3] (1000_540A / 0x1540A)
    BX = UInt16[DS, 0x11C3];
    // MOV word ptr [0x4710],DX (1000_540E / 0x1540E)
    UInt16[DS, 0x4710] = DX;
    // MOV word ptr [0x4712],BX (1000_5412 / 0x15412)
    UInt16[DS, 0x4712] = BX;
    // CALL 0x1000:5beb (1000_5416 / 0x15416)
    NearCall(cs1, 0x5419, spice86_generated_label_call_target_1000_5BEB_015BEB);
    // CALL 0x1000:5f79 (1000_5419 / 0x15419)
    NearCall(cs1, 0x541C, spice86_generated_label_call_target_1000_5F79_015F79);
    // CALL 0x1000:79de (1000_541C / 0x1541C)
    NearCall(cs1, 0x541F, spice86_generated_label_call_target_1000_79DE_0179DE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_541F_01541F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_541F_01541F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_541F_1541F:
    // PUSH word ptr [0x197c] (1000_541F / 0x1541F)
    Stack.Push(UInt16[DS, 0x197C]);
    // PUSH word ptr [0x197e] (1000_5423 / 0x15423)
    Stack.Push(UInt16[DS, 0x197E]);
    // POP word ptr [0x1982] (1000_5427 / 0x15427)
    UInt16[DS, 0x1982] = Stack.Pop();
    // POP word ptr [0x1980] (1000_542B / 0x1542B)
    UInt16[DS, 0x1980] = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_542F_01542F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_542F_01542F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_542F_1542F:
    // MOV word ptr [0x46fc],0x0 (1000_542F / 0x1542F)
    UInt16[DS, 0x46FC] = 0x0;
    // MOV word ptr [0x479e],0x0 (1000_5435 / 0x15435)
    UInt16[DS, 0x479E] = 0x0;
    // CALL 0x1000:557b (1000_543B / 0x1543B)
    NearCall(cs1, 0x543E, not_observed_1000_557B_01557B);
    // MOV DI,0x46e3 (1000_543E / 0x1543E)
    DI = 0x46E3;
    // ADD DX,0x5 (1000_5441 / 0x15441)
    DX += 0x5;
    // ADD BX,0x7 (1000_5444 / 0x15444)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    // MOV word ptr [DI],DX (1000_5447 / 0x15447)
    UInt16[DS, DI] = DX;
    // MOV word ptr [DI + 0x2],BX (1000_5449 / 0x15449)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    // ADD DX,0xa0 (1000_544C / 0x1544C)
    // DX += 0xA0;
    DX = Alu.Add16(DX, 0xA0);
    // MOV word ptr [DI + 0x4],DX (1000_5450 / 0x15450)
    UInt16[DS, (ushort)(DI + 0x4)] = DX;
    // ADD BX,0x59 (1000_5453 / 0x15453)
    // BX += 0x59;
    BX = Alu.Add16(BX, 0x59);
    // MOV word ptr [DI + 0x6],BX (1000_5456 / 0x15456)
    UInt16[DS, (ushort)(DI + 0x6)] = BX;
    // MOV SI,0x4710 (1000_5459 / 0x15459)
    SI = 0x4710;
    // ADD DX,0x5 (1000_545C / 0x1545C)
    // DX += 0x5;
    DX = Alu.Add16(DX, 0x5);
    // MOV word ptr [SI + 0x4],DX (1000_545F / 0x1545F)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    // ADD BX,0xc (1000_5462 / 0x15462)
    // BX += 0xC;
    BX = Alu.Add16(BX, 0xC);
    // MOV word ptr [SI + 0x6],BX (1000_5465 / 0x15465)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // CALL 0x1000:c13b (1000_5468 / 0x15468)
    NearCall(cs1, 0x546B, spice86_generated_label_call_target_1000_C13B_01C13B);
    // CALL 0x1000:557b (1000_546B / 0x1546B)
    NearCall(cs1, 0x546E, not_observed_1000_557B_01557B);
    // MOV AX,0x8d (1000_546E / 0x1546E)
    AX = 0x8D;
    // CALL 0x1000:c22f (1000_5471 / 0x15471)
    NearCall(cs1, 0x5474, spice86_generated_label_call_target_1000_C22F_01C22F);
    // CALL 0x1000:c07c (1000_5474 / 0x15474)
    NearCall(cs1, 0x5477, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:5b8d (1000_5477 / 0x15477)
    NearCall(cs1, 0x547A, spice86_generated_label_call_target_1000_5B8D_015B8D);
    // PUSH word ptr [0xdd00] (1000_547A / 0x1547A)
    Stack.Push(UInt16[DS, 0xDD00]);
    // MOV AX,0x3a (1000_547E / 0x1547E)
    AX = 0x3A;
    // CALL 0x1000:c13e (1000_5481 / 0x15481)
    NearCall(cs1, 0x5484, spice86_generated_label_call_target_1000_C13E_01C13E);
    // CALL 0x1000:5584 (1000_5484 / 0x15484)
    NearCall(cs1, 0x5487, not_observed_1000_5584_015584);
    // PUSH word ptr [0xdbb2] (1000_5487 / 0x15487)
    Stack.Push(UInt16[DS, 0xDBB2]);
    // POP word ptr [0xdd00] (1000_548B / 0x1548B)
    UInt16[DS, 0xDD00] = Stack.Pop();
    // MOV byte ptr [0x46eb],0x40 (1000_548F / 0x1548F)
    UInt8[DS, 0x46EB] = 0x40;
    // CALL 0x1000:b69a (1000_5494 / 0x15494)
    NearCall(cs1, 0x5497, not_observed_1000_B69A_01B69A);
    // CALL 0x1000:b6c3 (1000_5497 / 0x15497)
    NearCall(cs1, 0x549A, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    // POP word ptr [0xdd00] (1000_549A / 0x1549A)
    UInt16[DS, 0xDD00] = Stack.Pop();
    // CALL 0x1000:58e4 (1000_549E / 0x1549E)
    NearCall(cs1, 0x54A1, not_observed_1000_58E4_0158E4);
    // CALL 0x1000:c137 (1000_54A1 / 0x154A1)
    NearCall(cs1, 0x54A4, spice86_generated_label_call_target_1000_C137_01C137);
    // CALL 0x1000:5dce (1000_54A4 / 0x154A4)
    NearCall(cs1, 0x54A7, spice86_generated_label_call_target_1000_5DCE_015DCE);
    // CALL 0x1000:5605 (1000_54A7 / 0x154A7)
    NearCall(cs1, 0x54AA, not_observed_1000_5605_015605);
    // CALL 0x1000:563e (1000_54AA / 0x154AA)
    NearCall(cs1, 0x54AD, not_observed_1000_563E_01563E);
    // MOV word ptr [0x2772],0x5555 (1000_54AD / 0x154AD)
    UInt16[DS, 0x2772] = 0x5555;
    // MOV DX,word ptr [0x1980] (1000_54B3 / 0x154B3)
    DX = UInt16[DS, 0x1980];
    // MOV BX,word ptr [0x1982] (1000_54B7 / 0x154B7)
    BX = UInt16[DS, 0x1982];
    // CALL 0x1000:b647 (1000_54BB / 0x154BB)
    NearCall(cs1, 0x54BE, spice86_generated_label_call_target_1000_B647_01B647);
    // MOV CX,BX (1000_54BE / 0x154BE)
    CX = BX;
    // MOV DI,DX (1000_54C0 / 0x154C0)
    DI = DX;
    // SUB BX,0x14 (1000_54C2 / 0x154C2)
    BX -= 0x14;
    // ADD CX,0x13 (1000_54C5 / 0x154C5)
    CX += 0x13;
    // SUB DX,0x28 (1000_54C8 / 0x154C8)
    DX -= 0x28;
    // ADD DI,0x27 (1000_54CB / 0x154CB)
    // DI += 0x27;
    DI = Alu.Add16(DI, 0x27);
    // MOV AX,[0x4710] (1000_54CE / 0x154CE)
    AX = UInt16[DS, 0x4710];
    // ADD AX,0x5 (1000_54D1 / 0x154D1)
    AX += 0x5;
    // CMP DX,AX (1000_54D4 / 0x154D4)
    Alu.Sub16(DX, AX);
    // JGE 0x1000:54da (1000_54D6 / 0x154D6)
    if(SignFlag == OverflowFlag) {
      goto label_1000_54DA_154DA;
    }
    // MOV DX,AX (1000_54D8 / 0x154D8)
    DX = AX;
    label_1000_54DA_154DA:
    // CMP DI,AX (1000_54DA / 0x154DA)
    Alu.Sub16(DI, AX);
    // JGE 0x1000:54e0 (1000_54DC / 0x154DC)
    if(SignFlag == OverflowFlag) {
      goto label_1000_54E0_154E0;
    }
    // MOV DI,AX (1000_54DE / 0x154DE)
    DI = AX;
    label_1000_54E0_154E0:
    // ADD AX,0x9f (1000_54E0 / 0x154E0)
    AX += 0x9F;
    // CMP DX,AX (1000_54E3 / 0x154E3)
    Alu.Sub16(DX, AX);
    // JBE 0x1000:54e9 (1000_54E5 / 0x154E5)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_54E9_154E9;
    }
    // MOV DX,AX (1000_54E7 / 0x154E7)
    DX = AX;
    label_1000_54E9_154E9:
    // CMP DI,AX (1000_54E9 / 0x154E9)
    Alu.Sub16(DI, AX);
    // JBE 0x1000:54ef (1000_54EB / 0x154EB)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_54EF_154EF;
    }
    // MOV DI,AX (1000_54ED / 0x154ED)
    DI = AX;
    label_1000_54EF_154EF:
    // MOV AX,[0x4712] (1000_54EF / 0x154EF)
    AX = UInt16[DS, 0x4712];
    // ADD AX,0x7 (1000_54F2 / 0x154F2)
    AX += 0x7;
    // CMP BX,AX (1000_54F5 / 0x154F5)
    Alu.Sub16(BX, AX);
    // JGE 0x1000:54fb (1000_54F7 / 0x154F7)
    if(SignFlag == OverflowFlag) {
      goto label_1000_54FB_154FB;
    }
    // MOV BX,AX (1000_54F9 / 0x154F9)
    BX = AX;
    label_1000_54FB_154FB:
    // CMP CX,AX (1000_54FB / 0x154FB)
    Alu.Sub16(CX, AX);
    // JGE 0x1000:5501 (1000_54FD / 0x154FD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5501_15501;
    }
    // MOV CX,AX (1000_54FF / 0x154FF)
    CX = AX;
    label_1000_5501_15501:
    // ADD AX,0x58 (1000_5501 / 0x15501)
    AX += 0x58;
    // CMP BX,AX (1000_5504 / 0x15504)
    Alu.Sub16(BX, AX);
    // JBE 0x1000:550a (1000_5506 / 0x15506)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_550A_1550A;
    }
    // MOV BX,AX (1000_5508 / 0x15508)
    BX = AX;
    label_1000_550A_1550A:
    // CMP CX,AX (1000_550A / 0x1550A)
    Alu.Sub16(CX, AX);
    // JBE 0x1000:5510 (1000_550C / 0x1550C)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5510_15510;
    }
    // MOV CX,AX (1000_550E / 0x1550E)
    CX = AX;
    label_1000_5510_15510:
    // CMP BX,CX (1000_5510 / 0x15510)
    Alu.Sub16(BX, CX);
    // JZ 0x1000:551d (1000_5512 / 0x15512)
    if(ZeroFlag) {
      goto label_1000_551D_1551D;
    }
    // CMP DX,DI (1000_5514 / 0x15514)
    Alu.Sub16(DX, DI);
    // JZ 0x1000:551d (1000_5516 / 0x15516)
    if(ZeroFlag) {
      goto label_1000_551D_1551D;
    }
    // MOV AL,0xfb (1000_5518 / 0x15518)
    AL = 0xFB;
    // CALL 0x1000:c560 (1000_551A / 0x1551A)
    NearCall(cs1, 0x551D, spice86_generated_label_call_target_1000_C560_01C560);
    label_1000_551D_1551D:
    // MOV word ptr [0x2772],0xffff (1000_551D / 0x1551D)
    UInt16[DS, 0x2772] = 0xFFFF;
    // MOV SI,0x4710 (1000_5523 / 0x15523)
    SI = 0x4710;
    // MOV DI,0xdbe0 (1000_5526 / 0x15526)
    DI = 0xDBE0;
    // CMP word ptr [DI],0x0 (1000_5529 / 0x15529)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    // JZ 0x1000:5535 (1000_552C / 0x1552C)
    if(ZeroFlag) {
      goto label_1000_5535_15535;
    }
    // CMP word ptr [DI],SI (1000_552E / 0x1552E)
    Alu.Sub16(UInt16[DS, DI], SI);
    // JZ 0x1000:5535 (1000_5530 / 0x15530)
    if(ZeroFlag) {
      goto label_1000_5535_15535;
    }
    // MOV DI,0xdbe2 (1000_5532 / 0x15532)
    DI = 0xDBE2;
    label_1000_5535_15535:
    // MOV word ptr [DI],SI (1000_5535 / 0x15535)
    UInt16[DS, DI] = SI;
    // CMP DI,0xdbe2 (1000_5537 / 0x15537)
    Alu.Sub16(DI, 0xDBE2);
    // PUSHF  (1000_553B / 0x1553B)
    Stack.Push(FlagRegister);
    // XOR DI,DI (1000_553C / 0x1553C)
    DI = 0;
    // XCHG word ptr [0x4720],DI (1000_553E / 0x1553E)
    ushort tmp_1000_553E = UInt16[DS, 0x4720];
    UInt16[DS, 0x4720] = DI;
    DI = tmp_1000_553E;
    // OR DI,DI (1000_5542 / 0x15542)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:554d (1000_5544 / 0x15544)
    if(ZeroFlag) {
      goto label_1000_554D_1554D;
    }
    // XCHG DI,SI (1000_5546 / 0x15546)
    ushort tmp_1000_5546 = DI;
    DI = SI;
    SI = tmp_1000_5546;
    // MOV AL,0x6 (1000_5548 / 0x15548)
    AL = 0x6;
    // CALL 0x1000:c0e8 (1000_554A / 0x1554A)
    NearCall(cs1, 0x554D, spice86_generated_label_call_target_1000_C0E8_01C0E8);
    label_1000_554D_1554D:
    // POPF  (1000_554D / 0x1554D)
    FlagRegister = Stack.Pop();
    // JNZ 0x1000:5558 (1000_554E / 0x1554E)
    if(!ZeroFlag) {
      goto label_1000_5558_15558;
    }
    // CALL 0x1000:62f2 (1000_5550 / 0x15550)
    NearCall(cs1, 0x5553, not_observed_1000_62F2_0162F2);
    // CALL 0x1000:813e (1000_5553 / 0x15553)
    NearCall(cs1, 0x5556, not_observed_1000_813E_01813E);
    // JMP 0x1000:555b (1000_5556 / 0x15556)
    goto label_1000_555B_1555B;
    label_1000_5558_15558:
    // CALL 0x1000:6314 (1000_5558 / 0x15558)
    NearCall(cs1, 0x555B, spice86_generated_label_call_target_1000_6314_016314);
    label_1000_555B_1555B:
    // MOV SI,0x4710 (1000_555B / 0x1555B)
    SI = 0x4710;
    // CALL 0x1000:c4f0 (1000_555E / 0x1555E)
    NearCall(cs1, 0x5561, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    // CALL 0x1000:b69a (1000_5561 / 0x15561)
    NearCall(cs1, 0x5564, not_observed_1000_B69A_01B69A);
    // MOV byte ptr [0x46eb],0xc0 (1000_5564 / 0x15564)
    UInt8[DS, 0x46EB] = 0xC0;
    // MOV SI,0x1482 (1000_5569 / 0x15569)
    SI = 0x1482;
    // MOV DI,0x46e3 (1000_556C / 0x1556C)
    DI = 0x46E3;
    // CALL 0x1000:5b99 (1000_556F / 0x1556F)
    NearCall(cs1, 0x5572, spice86_generated_label_call_target_1000_5B99_015B99);
    // CALL 0x1000:5b8d (1000_5572 / 0x15572)
    NearCall(cs1, 0x5575, spice86_generated_label_call_target_1000_5B8D_015B8D);
    label_1000_5575_15575:
    // MOV SI,0x4710 (1000_5575 / 0x15575)
    SI = 0x4710;
    // JMP 0x1000:daaa (1000_5578 / 0x15578)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAAA_01DAAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_557B_01557B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_557B_1557B:
    // MOV DX,word ptr [0x4710] (1000_557B / 0x1557B)
    DX = UInt16[DS, 0x4710];
    // MOV BX,word ptr [0x4712] (1000_557F / 0x1557F)
    BX = UInt16[DS, 0x4712];
    // RET  (1000_5583 / 0x15583)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5584_015584(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5584_15584:
    // XOR AX,AX (1000_5584 / 0x15584)
    AX = 0;
    // XCHG word ptr [0x115a],AX (1000_5586 / 0x15586)
    ushort tmp_1000_5586 = UInt16[DS, 0x115A];
    UInt16[DS, 0x115A] = AX;
    AX = tmp_1000_5586;
    // OR AX,AX (1000_558A / 0x1558A)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:55bf (1000_558C / 0x1558C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_55BF / 0x155BF)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_558E / 0x1558E)
    NearCall(cs1, 0x5591, spice86_generated_label_call_target_1000_E270_01E270);
    // PUSH DS (1000_5591 / 0x15591)
    Stack.Push(DS);
    // PUSH ES (1000_5592 / 0x15592)
    Stack.Push(ES);
    // MOV CL,0xc (1000_5593 / 0x15593)
    CL = 0xC;
    label_1000_5595_15595:
    // SHR AX,1 (1000_5595 / 0x15595)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // JNC 0x1000:55b8 (1000_5597 / 0x15597)
    if(!CarryFlag) {
      goto label_1000_55B8_155B8;
    }
    // PUSH AX (1000_5599 / 0x15599)
    Stack.Push(AX);
    // PUSH CX (1000_559A / 0x1559A)
    Stack.Push(CX);
    // MOV BL,0xd (1000_559B / 0x1559B)
    BL = 0xD;
    // SUB BL,CL (1000_559D / 0x1559D)
    // BL -= CL;
    BL = Alu.Sub8(BL, CL);
    // MOV DI,0x100 (1000_559F / 0x1559F)
    DI = 0x100;
    label_1000_55A2_155A2:
    // CMP byte ptr [DI],BL (1000_55A2 / 0x155A2)
    Alu.Sub8(UInt8[DS, DI], BL);
    // JNZ 0x1000:55ab (1000_55A4 / 0x155A4)
    if(!ZeroFlag) {
      goto label_1000_55AB_155AB;
    }
    // CALL 0x1000:5d36 (1000_55A6 / 0x155A6)
    NearCall(cs1, 0x55A9, spice86_generated_label_call_target_1000_5D36_015D36);
    // JNC 0x1000:55b6 (1000_55A9 / 0x155A9)
    if(!CarryFlag) {
      goto label_1000_55B6_155B6;
    }
    label_1000_55AB_155AB:
    // ADD DI,0x1c (1000_55AB / 0x155AB)
    DI += 0x1C;
    // CMP byte ptr [DI],0xff (1000_55AE / 0x155AE)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:55a2 (1000_55B1 / 0x155B1)
    if(!ZeroFlag) {
      goto label_1000_55A2_155A2;
    }
    // CALL 0x1000:55c0 (1000_55B3 / 0x155B3)
    NearCall(cs1, 0x55B6, not_observed_1000_55C0_0155C0);
    label_1000_55B6_155B6:
    // POP CX (1000_55B6 / 0x155B6)
    CX = Stack.Pop();
    // POP AX (1000_55B7 / 0x155B7)
    AX = Stack.Pop();
    label_1000_55B8_155B8:
    // LOOP 0x1000:5595 (1000_55B8 / 0x155B8)
    if(--CX != 0) {
      goto label_1000_5595_15595;
    }
    // POP ES (1000_55BA / 0x155BA)
    ES = Stack.Pop();
    // POP DS (1000_55BB / 0x155BB)
    DS = Stack.Pop();
    // CALL 0x1000:e283 (1000_55BC / 0x155BC)
    NearCall(cs1, 0x55BF, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_55BF_155BF:
    // RET  (1000_55BF / 0x155BF)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_55C0_0155C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_55C0_155C0:
    // MOV SI,0x100 (1000_55C0 / 0x155C0)
    SI = 0x100;
    label_1000_55C3_155C3:
    // CMP byte ptr [SI],BL (1000_55C3 / 0x155C3)
    Alu.Sub8(UInt8[DS, SI], BL);
    // JNZ 0x1000:55cd (1000_55C5 / 0x155C5)
    if(!ZeroFlag) {
      goto label_1000_55CD_155CD;
    }
    // MOV AL,byte ptr [SI + 0x10] (1000_55C7 / 0x155C7)
    AL = UInt8[DS, (ushort)(SI + 0x10)];
    // CALL 0x1000:55dd (1000_55CA / 0x155CA)
    NearCall(cs1, 0x55CD, map_func_ida_1000_55DD_155DD);
    label_1000_55CD_155CD:
    // ADD SI,0x1c (1000_55CD / 0x155CD)
    SI += 0x1C;
    // CMP byte ptr [SI],0xff (1000_55D0 / 0x155D0)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:55c3 (1000_55D3 / 0x155D3)
    if(!ZeroFlag) {
      goto label_1000_55C3_155C3;
    }
    // MOV AL,0x42 (1000_55D5 / 0x155D5)
    AL = 0x42;
    // CMP BL,0x7 (1000_55D7 / 0x155D7)
    Alu.Sub8(BL, 0x7);
    // JZ 0x1000:55dd (1000_55DA / 0x155DA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(map_func_ida_1000_55DD_155DD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_55DC / 0x155DC)
    return NearRet();
  }
  
  public virtual Action map_func_ida_1000_55DD_155DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_55DD_155DD:
    // PUSH DS (1000_55DD / 0x155DD)
    Stack.Push(DS);
    // OR AL,AL (1000_55DE / 0x155DE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:5603 (1000_55E0 / 0x155E0)
    if(ZeroFlag) {
      goto label_1000_5603_15603;
    }
    // LES DI,[0xdbb0] (1000_55E2 / 0x155E2)
    ES = UInt16[DS, 0xDBB2];
    DI = UInt16[DS, 0xDBB0];
    // MOV DS,word ptr [0xdd00] (1000_55E6 / 0x155E6)
    DS = UInt16[DS, 0xDD00];
    // MOV CX,0xc5f9 (1000_55EA / 0x155EA)
    CX = 0xC5F9;
    label_1000_55ED_155ED:
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_55ED / 0x155ED)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    // JNZ 0x1000:5603 (1000_55EF / 0x155EF)
    if(!ZeroFlag) {
      goto label_1000_5603_15603;
    }
    // MOV AH,byte ptr [DI + -0x1] (1000_55F1 / 0x155F1)
    AH = UInt8[DS, (ushort)(DI - 0x1)];
    // AND AH,0x30 (1000_55F4 / 0x155F4)
    AH &= 0x30;
    // CMP AH,0x30 (1000_55F7 / 0x155F7)
    Alu.Sub8(AH, 0x30);
    // JNZ 0x1000:5600 (1000_55FA / 0x155FA)
    if(!ZeroFlag) {
      goto label_1000_5600_15600;
    }
    // AND byte ptr [DI + -0x1],0xef (1000_55FC / 0x155FC)
    UInt8[DS, (ushort)(DI - 0x1)] &= 0xEF;
    label_1000_5600_15600:
    // INC CX (1000_5600 / 0x15600)
    CX = Alu.Inc16(CX);
    // LOOP 0x1000:55ed (1000_5601 / 0x15601)
    if(--CX != 0) {
      goto label_1000_55ED_155ED;
    }
    label_1000_5603_15603:
    // POP DS (1000_5603 / 0x15603)
    DS = Stack.Pop();
    // RET  (1000_5604 / 0x15604)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5605_015605(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5605_15605:
    // SUB SP,0x8 (1000_5605 / 0x15605)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    // MOV SI,0x4710 (1000_5608 / 0x15608)
    SI = 0x4710;
    // MOV DI,SP (1000_560B / 0x1560B)
    DI = SP;
    // PUSH DS (1000_560D / 0x1560D)
    Stack.Push(DS);
    // POP ES (1000_560E / 0x1560E)
    ES = Stack.Pop();
    // LODSW SI (1000_560F / 0x1560F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD AX,0x6 (1000_5610 / 0x15610)
    // AX += 0x6;
    AX = Alu.Add16(AX, 0x6);
    // STOSW ES:DI (1000_5613 / 0x15613)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_5614 / 0x15614)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD AX,0x62 (1000_5615 / 0x15615)
    // AX += 0x62;
    AX = Alu.Add16(AX, 0x62);
    // STOSW ES:DI (1000_5618 / 0x15618)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_5619 / 0x15619)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB AX,0x6 (1000_561A / 0x1561A)
    // AX -= 0x6;
    AX = Alu.Sub16(AX, 0x6);
    // STOSW ES:DI (1000_561D / 0x1561D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_561E / 0x1561E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB AX,0x2 (1000_561F / 0x1561F)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    // STOSW ES:DI (1000_5622 / 0x15622)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LEA SI,[DI + -0x8] (1000_5623 / 0x15623)
    SI = (ushort)(DI - 0x8);
    // MOV AL,0xf5 (1000_5626 / 0x15626)
    AL = 0xF5;
    // MOV ES,word ptr [0xdbda] (1000_5628 / 0x15628)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38dd] (1000_562C / 0x1562C)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_562C = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_562C) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_562C));
        break;
    }
    // MOV byte ptr [0x4724],0xff (1000_5630 / 0x15630)
    UInt8[DS, 0x4724] = 0xFF;
    // CALL 0x1000:d075 (1000_5635 / 0x15635)
    NearCall(cs1, 0x5638, spice86_generated_label_call_target_1000_D075_01D075);
    // ADD SP,0x8 (1000_5638 / 0x15638)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    // JMP 0x1000:557b (1000_563B / 0x1563B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_557B_01557B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_563E_01563E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_563E_1563E:
    // ADD BX,0x62 (1000_563E / 0x1563E)
    BX += 0x62;
    // ADD DX,0x6 (1000_5641 / 0x15641)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    // MOV CX,0xf5fe (1000_5644 / 0x15644)
    CX = 0xF5FE;
    // MOV byte ptr [0x4725],CL (1000_5647 / 0x15647)
    UInt8[DS, 0x4725] = CL;
    // CMP byte ptr [0x4722],0x0 (1000_564B / 0x1564B)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    // JNZ 0x1000:568c (1000_5650 / 0x15650)
    if(!ZeroFlag) {
      goto label_1000_568C_1568C;
    }
    // PUSH DX (1000_5652 / 0x15652)
    Stack.Push(DX);
    // MOV AX,0x65 (1000_5653 / 0x15653)
    AX = 0x65;
    // CALL 0x1000:d194 (1000_5656 / 0x15656)
    NearCall(cs1, 0x5659, spice86_generated_label_call_target_1000_D194_01D194);
    // POP AX (1000_5659 / 0x15659)
    AX = Stack.Pop();
    // ADD AX,0x53 (1000_565A / 0x1565A)
    // AX += 0x53;
    AX = Alu.Add16(AX, 0x53);
    // MOV [0xd82c],AX (1000_565D / 0x1565D)
    UInt16[DS, 0xD82C] = AX;
    // MOV AL,0x2d (1000_5660 / 0x15660)
    AL = 0x2D;
    // CALL word ptr [0x2518] (1000_5662 / 0x15662)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_5662 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_5662) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5662));
        break;
    }
    // ADD word ptr [0xd82c],0x41 (1000_5666 / 0x15666)
    // UInt16[DS, 0xD82C] += 0x41;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], 0x41);
    // MOV AL,0x2b (1000_566B / 0x1566B)
    AL = 0x2B;
    // CALL word ptr [0x2518] (1000_566D / 0x1566D)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_566D = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_566D) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_566D));
        break;
    }
    // CALL 0x1000:c13b (1000_5671 / 0x15671)
    NearCall(cs1, 0x5674, spice86_generated_label_call_target_1000_C13B_01C13B);
    // CALL 0x1000:557b (1000_5674 / 0x15674)
    NearCall(cs1, 0x5677, not_observed_1000_557B_01557B);
    // ADD DX,0x5f (1000_5677 / 0x15677)
    DX += 0x5F;
    // ADD BX,0x63 (1000_567A / 0x1567A)
    // BX += 0x63;
    BX = Alu.Add16(BX, 0x63);
    // MOV AX,0x80 (1000_567D / 0x1567D)
    AX = 0x80;
    // CALL 0x1000:c2fd (1000_5680 / 0x15680)
    NearCall(cs1, 0x5683, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    // ADD DX,0x3c (1000_5683 / 0x15683)
    // DX += 0x3C;
    DX = Alu.Add16(DX, 0x3C);
    // MOV AX,0x81 (1000_5686 / 0x15686)
    AX = 0x81;
    // JMP 0x1000:c22f (1000_5689 / 0x15689)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_568C_1568C:
    // MOV AX,0x68 (1000_568C / 0x1568C)
    AX = 0x68;
    // JMP 0x1000:d194 (1000_568F / 0x1568F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5692_015692(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5692_15692:
    // PUSH DI (1000_5692 / 0x15692)
    Stack.Push(DI);
    // CALL 0x1000:5605 (1000_5693 / 0x15693)
    NearCall(cs1, 0x5696, not_observed_1000_5605_015605);
    // POP DI (1000_5696 / 0x15696)
    DI = Stack.Pop();
    // OR DI,DI (1000_5697 / 0x15697)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:563e (1000_5699 / 0x15699)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_563E_01563E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD BX,0x62 (1000_569B / 0x1569B)
    BX += 0x62;
    // ADD DX,0x6 (1000_569E / 0x1569E)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    // MOV CX,0xf5fe (1000_56A1 / 0x156A1)
    CX = 0xF5FE;
    // CALL 0x1000:629d (1000_56A4 / 0x156A4)
    NearCall(cs1, 0x56A7, spice86_generated_label_call_target_1000_629D_01629D);
    // CALL 0x1000:d05f (1000_56A7 / 0x156A7)
    NearCall(cs1, 0x56AA, spice86_generated_label_call_target_1000_D05F_01D05F);
    // MOV CX,0xf5fe (1000_56AA / 0x156AA)
    CX = 0xF5FE;
    // CALL 0x1000:62a6 (1000_56AD / 0x156AD)
    NearCall(cs1, 0x56B0, spice86_generated_label_call_target_1000_62A6_0162A6);
    // CMP DI,0x138 (1000_56B0 / 0x156B0)
    Alu.Sub16(DI, 0x138);
    // JC 0x1000:5719 (1000_56B4 / 0x156B4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5719 / 0x15719)
      return NearRet();
    }
    // CMP byte ptr [DI + 0x8],0x21 (1000_56B6 / 0x156B6)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x21);
    // JZ 0x1000:5719 (1000_56BA / 0x156BA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5719 / 0x15719)
      return NearRet();
    }
    // XOR BX,BX (1000_56BC / 0x156BC)
    BX = 0;
    // XOR CX,CX (1000_56BE / 0x156BE)
    CX = 0;
    // MOV BP,0x5728 (1000_56C0 / 0x156C0)
    BP = 0x5728;
    // CALL 0x1000:6639 (1000_56C3 / 0x156C3)
    NearCall(cs1, 0x56C6, spice86_generated_label_call_target_1000_6639_016639);
    // MOV DX,word ptr [0x4710] (1000_56C6 / 0x156C6)
    DX = UInt16[DS, 0x4710];
    // ADD DX,0x71 (1000_56CA / 0x156CA)
    // DX += 0x71;
    DX = Alu.Add16(DX, 0x71);
    // MOV AX,CX (1000_56CD / 0x156CD)
    AX = CX;
    // OR AX,BX (1000_56CF / 0x156CF)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    // JZ 0x1000:571a (1000_56D1 / 0x156D1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_571A_01571A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c13b (1000_56D3 / 0x156D3)
    NearCall(cs1, 0x56D6, spice86_generated_label_call_target_1000_C13B_01C13B);
    // SUB byte ptr [0xdbe4],0x3 (1000_56D6 / 0x156D6)
    UInt8[DS, 0xDBE4] -= 0x3;
    // XOR AX,AX (1000_56DB / 0x156DB)
    AX = 0;
    // CALL 0x1000:56ed (1000_56DD / 0x156DD)
    NearCall(cs1, 0x56E0, not_observed_1000_56ED_0156ED);
    // MOV BL,CH (1000_56E0 / 0x156E0)
    BL = CH;
    // MOV AX,0x1 (1000_56E2 / 0x156E2)
    AX = 0x1;
    // CALL 0x1000:56ed (1000_56E5 / 0x156E5)
    NearCall(cs1, 0x56E8, not_observed_1000_56ED_0156ED);
    // MOV BL,CL (1000_56E8 / 0x156E8)
    BL = CL;
    // MOV AX,0x2 (1000_56EA / 0x156EA)
    AX = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_56ED_0156ED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_56ED_0156ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_56ED_156ED:
    // OR BL,BL (1000_56ED / 0x156ED)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:5719 (1000_56EF / 0x156EF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5719 / 0x15719)
      return NearRet();
    }
    // PUSH CX (1000_56F1 / 0x156F1)
    Stack.Push(CX);
    // PUSH DX (1000_56F2 / 0x156F2)
    Stack.Push(DX);
    // PUSH BX (1000_56F3 / 0x156F3)
    Stack.Push(BX);
    // MOV BX,word ptr [0x4712] (1000_56F4 / 0x156F4)
    BX = UInt16[DS, 0x4712];
    // ADD BX,0x62 (1000_56F8 / 0x156F8)
    BX += 0x62;
    // ADD AX,0x82 (1000_56FB / 0x156FB)
    // AX += 0x82;
    AX = Alu.Add16(AX, 0x82);
    // CALL 0x1000:c2fd (1000_56FE / 0x156FE)
    NearCall(cs1, 0x5701, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    // ADD DX,0x6 (1000_5701 / 0x15701)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    // CALL 0x1000:d04e (1000_5704 / 0x15704)
    NearCall(cs1, 0x5707, spice86_generated_label_call_target_1000_D04E_01D04E);
    // MOV AL,0x3a (1000_5707 / 0x15707)
    AL = 0x3A;
    // CALL word ptr [0x2518] (1000_5709 / 0x15709)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_5709 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_5709) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5709));
        break;
    }
    // POP AX (1000_570D / 0x1570D)
    AX = Stack.Pop();
    // ADD AL,0x30 (1000_570E / 0x1570E)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    // CALL word ptr [0x2518] (1000_5710 / 0x15710)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_5710 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_5710) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5710));
        break;
    }
    // POP DX (1000_5714 / 0x15714)
    DX = Stack.Pop();
    // POP CX (1000_5715 / 0x15715)
    CX = Stack.Pop();
    // ADD DX,0x12 (1000_5716 / 0x15716)
    // DX += 0x12;
    DX = Alu.Add16(DX, 0x12);
    label_1000_5719_15719:
    // RET  (1000_5719 / 0x15719)
    return NearRet();
  }
  
  public virtual Action split_1000_571A_01571A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_571A_1571A:
    // PUSH DX (1000_571A / 0x1571A)
    Stack.Push(DX);
    // CALL 0x1000:d05f (1000_571B / 0x1571B)
    NearCall(cs1, 0x571E, spice86_generated_label_call_target_1000_D05F_01D05F);
    // POP DX (1000_571E / 0x1571E)
    DX = Stack.Pop();
    // MOV CX,0xf5fb (1000_571F / 0x1571F)
    CX = 0xF5FB;
    // MOV AX,0x66 (1000_5722 / 0x15722)
    AX = 0x66;
    // JMP 0x1000:d194 (1000_5725 / 0x15725)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5746_015746(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5746_15746:
    // MOV DI,0x4710 (1000_5746 / 0x15746)
    DI = 0x4710;
    // CALL 0x1000:d6fe (1000_5749 / 0x15749)
    NearCall(cs1, 0x574C, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JNC 0x1000:57b2 (1000_574C / 0x1574C)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_57B2_0157B2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0x4716] (1000_574E / 0x1574E)
    AX = UInt16[DS, 0x4716];
    // SUB AX,0xa (1000_5751 / 0x15751)
    AX -= 0xA;
    // CMP BX,AX (1000_5754 / 0x15754)
    Alu.Sub16(BX, AX);
    // JNC 0x1000:57ad (1000_5756 / 0x15756)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_57AD_0157AD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:57b2 (1000_5758 / 0x15758)
    NearCall(cs1, 0x575B, not_observed_1000_57B2_0157B2);
    // CMP byte ptr [0x4722],0x0 (1000_575B / 0x1575B)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    // JNZ 0x1000:578a (1000_5760 / 0x15760)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    // MOV ES,word ptr [0xdbd8] (1000_5762 / 0x15762)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x3965] (1000_5766 / 0x15766)
    // Indirect call to [0x3965], generating possible targets from emulator records
    uint targetAddress_1000_5766 = (uint)(UInt16[DS, 0x3967] * 0x10 + UInt16[DS, 0x3965] - cs1 * 0x10);
    switch(targetAddress_1000_5766) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5766));
        break;
    }
    // SUB AL,0x50 (1000_576A / 0x1576A)
    AL -= 0x50;
    // CMP AL,0x10 (1000_576C / 0x1576C)
    Alu.Sub8(AL, 0x10);
    // JC 0x1000:5772 (1000_576E / 0x1576E)
    if(CarryFlag) {
      goto label_1000_5772_15772;
    }
    // MOV AL,0xff (1000_5770 / 0x15770)
    AL = 0xFF;
    label_1000_5772_15772:
    // MOV AH,AL (1000_5772 / 0x15772)
    AH = AL;
    // XCHG byte ptr [0x4724],AL (1000_5774 / 0x15774)
    byte tmp_1000_5774 = UInt8[DS, 0x4724];
    UInt8[DS, 0x4724] = AL;
    AL = tmp_1000_5774;
    // CMP AL,AH (1000_5778 / 0x15778)
    Alu.Sub8(AL, AH);
    // JZ 0x1000:578a (1000_577A / 0x1577A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    // CALL 0x1000:dbb2 (1000_577C / 0x1577C)
    NearCall(cs1, 0x577F, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:578b (1000_577F / 0x1577F)
    NearCall(cs1, 0x5782, not_observed_1000_578B_01578B);
    // MOV AL,AH (1000_5782 / 0x15782)
    AL = AH;
    // CALL 0x1000:578b (1000_5784 / 0x15784)
    NearCall(cs1, 0x5787, not_observed_1000_578B_01578B);
    // CALL 0x1000:dbec (1000_5787 / 0x15787)
    NearCall(cs1, 0x578A, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_578A_01578A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_578A_01578A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_578A_1578A:
    // RET  (1000_578A / 0x1578A)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_578B_01578B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_578B_1578B:
    // OR AL,AL (1000_578B / 0x1578B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:578a (1000_578D / 0x1578D)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    // PUSH AX (1000_578F / 0x1578F)
    Stack.Push(AX);
    // CALL 0x1000:557b (1000_5790 / 0x15790)
    NearCall(cs1, 0x5793, not_observed_1000_557B_01557B);
    // ADD DX,0x5e (1000_5793 / 0x15793)
    DX += 0x5E;
    // ADD BX,0x62 (1000_5796 / 0x15796)
    BX += 0x62;
    // XOR AH,AH (1000_5799 / 0x15799)
    AH = 0;
    // SHL AX,1 (1000_579B / 0x1579B)
    AX <<= 0x1;
    // SHL AX,1 (1000_579D / 0x1579D)
    AX <<= 0x1;
    // ADD DX,AX (1000_579F / 0x1579F)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // MOV SI,0x5 (1000_57A1 / 0x157A1)
    SI = 0x5;
    // MOV CX,0x7 (1000_57A4 / 0x157A4)
    CX = 0x7;
    // CALLF [0x3961] (1000_57A7 / 0x157A7)
    // Indirect call to [0x3961], generating possible targets from emulator records
    uint targetAddress_1000_57A7 = (uint)(UInt16[DS, 0x3963] * 0x10 + UInt16[DS, 0x3961] - cs1 * 0x10);
    switch(targetAddress_1000_57A7) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_57A7));
        break;
    }
    // POP AX (1000_57AB / 0x157AB)
    AX = Stack.Pop();
    // RET  (1000_57AC / 0x157AC)
    return NearRet();
  }
  
  public virtual Action split_1000_57AD_0157AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_57AD_157AD:
    // MOV CX,0xfef5 (1000_57AD / 0x157AD)
    CX = 0xFEF5;
    // JMP 0x1000:57b5 (1000_57B0 / 0x157B0)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_57B2_0157B2, 0x157B5 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_57B2_0157B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_57B2_157B2:
    // MOV CX,0xf5fe (1000_57B2 / 0x157B2)
    CX = 0xF5FE;
    label_1000_57B5_157B5:
    // MOV AL,CL (1000_57B5 / 0x157B5)
    AL = CL;
    // XCHG byte ptr [0x4725],AL (1000_57B7 / 0x157B7)
    byte tmp_1000_57B7 = UInt8[DS, 0x4725];
    UInt8[DS, 0x4725] = AL;
    AL = tmp_1000_57B7;
    // CMP AL,CL (1000_57BB / 0x157BB)
    Alu.Sub8(AL, CL);
    // JZ 0x1000:578a (1000_57BD / 0x157BD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    // PUSH BX (1000_57BF / 0x157BF)
    Stack.Push(BX);
    // PUSH DX (1000_57C0 / 0x157C0)
    Stack.Push(DX);
    // CALL 0x1000:c08e (1000_57C1 / 0x157C1)
    NearCall(cs1, 0x57C4, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:557b (1000_57C4 / 0x157C4)
    NearCall(cs1, 0x57C7, not_observed_1000_557B_01557B);
    // ADD BX,0x62 (1000_57C7 / 0x157C7)
    BX += 0x62;
    // ADD DX,0x6 (1000_57CA / 0x157CA)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    // MOV AX,0x65 (1000_57CD / 0x157CD)
    AX = 0x65;
    // CMP byte ptr [0x4722],0x0 (1000_57D0 / 0x157D0)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    // JZ 0x1000:57da (1000_57D5 / 0x157D5)
    if(ZeroFlag) {
      goto label_1000_57DA_157DA;
    }
    // MOV AX,0x68 (1000_57D7 / 0x157D7)
    AX = 0x68;
    label_1000_57DA_157DA:
    // CALL 0x1000:dbb2 (1000_57DA / 0x157DA)
    NearCall(cs1, 0x57DD, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:d194 (1000_57DD / 0x157DD)
    NearCall(cs1, 0x57E0, spice86_generated_label_call_target_1000_D194_01D194);
    // POP DX (1000_57E0 / 0x157E0)
    DX = Stack.Pop();
    // POP BX (1000_57E1 / 0x157E1)
    BX = Stack.Pop();
    // JMP 0x1000:c07c (1000_57E2 / 0x157E2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_57E5_0157E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_57E5_157E5:
    // CALL 0x1000:e270 (1000_57E5 / 0x157E5)
    NearCall(cs1, 0x57E8, spice86_generated_label_call_target_1000_E270_01E270);
    // PUSH ES (1000_57E8 / 0x157E8)
    Stack.Push(ES);
    // MOV AX,0x3a (1000_57E9 / 0x157E9)
    AX = 0x3A;
    // CALL 0x1000:c13e (1000_57EC / 0x157EC)
    NearCall(cs1, 0x57EF, spice86_generated_label_call_target_1000_C13E_01C13E);
    // PUSH DS (1000_57EF / 0x157EF)
    Stack.Push(DS);
    // POP ES (1000_57F0 / 0x157F0)
    ES = Stack.Pop();
    // MOV DI,BP (1000_57F1 / 0x157F1)
    DI = BP;
    // MOV AL,0x70 (1000_57F3 / 0x157F3)
    AL = 0x70;
    // MOV CX,0x100 (1000_57F5 / 0x157F5)
    CX = 0x100;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_57F8 / 0x157F8)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // CMP byte ptr [0x4722],0x0 (1000_57FA / 0x157FA)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    // JNZ 0x1000:583f (1000_57FF / 0x157FF)
    if(!ZeroFlag) {
      goto label_1000_583F_1583F;
    }
    // MOV SI,0x100 (1000_5801 / 0x15801)
    SI = 0x100;
    // MOV DI,BP (1000_5804 / 0x15804)
    DI = BP;
    // XOR BX,BX (1000_5806 / 0x15806)
    BX = 0;
    label_1000_5808_15808:
    // MOV AL,byte ptr [SI + 0xa] (1000_5808 / 0x15808)
    AL = UInt8[DS, (ushort)(SI + 0xA)];
    // TEST AL,0x80 (1000_580B / 0x1580B)
    Alu.And8(AL, 0x80);
    // JNZ 0x1000:5832 (1000_580D / 0x1580D)
    if(!ZeroFlag) {
      goto label_1000_5832_15832;
    }
    // MOV BL,byte ptr [SI + 0x10] (1000_580F / 0x1580F)
    BL = UInt8[DS, (ushort)(SI + 0x10)];
    // TEST AL,0x40 (1000_5812 / 0x15812)
    Alu.And8(AL, 0x40);
    // PUSHF  (1000_5814 / 0x15814)
    Stack.Push(FlagRegister);
    // MOV AL,0x75 (1000_5815 / 0x15815)
    AL = 0x75;
    // TEST byte ptr [0x2942],0x2 (1000_5817 / 0x15817)
    Alu.And8(UInt8[DS, 0x2942], 0x2);
    // JZ 0x1000:5820 (1000_581C / 0x1581C)
    if(ZeroFlag) {
      goto label_1000_5820_15820;
    }
    // MOV AL,0x78 (1000_581E / 0x1581E)
    AL = 0x78;
    label_1000_5820_15820:
    // POPF  (1000_5820 / 0x15820)
    FlagRegister = Stack.Pop();
    // JZ 0x1000:5830 (1000_5821 / 0x15821)
    if(ZeroFlag) {
      goto label_1000_5830_15830;
    }
    // MOV AL,byte ptr [SI + 0x12] (1000_5823 / 0x15823)
    AL = UInt8[DS, (ushort)(SI + 0x12)];
    // SHR AL,1 (1000_5826 / 0x15826)
    AL >>= 0x1;
    // SHR AL,1 (1000_5828 / 0x15828)
    AL >>= 0x1;
    // SHR AL,1 (1000_582A / 0x1582A)
    AL >>= 0x1;
    // SHR AL,1 (1000_582C / 0x1582C)
    AL >>= 0x1;
    // ADD AL,0x50 (1000_582E / 0x1582E)
    // AL += 0x50;
    AL = Alu.Add8(AL, 0x50);
    label_1000_5830_15830:
    // MOV byte ptr [BX + DI],AL (1000_5830 / 0x15830)
    UInt8[DS, (ushort)(BX + DI)] = AL;
    label_1000_5832_15832:
    // ADD SI,0x1c (1000_5832 / 0x15832)
    SI += 0x1C;
    // CMP byte ptr [SI],0xff (1000_5835 / 0x15835)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:5808 (1000_5838 / 0x15838)
    if(!ZeroFlag) {
      goto label_1000_5808_15808;
    }
    // POP ES (1000_583A / 0x1583A)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_583B / 0x1583B)
    NearCall(cs1, 0x583E, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_583E / 0x1583E)
    return NearRet();
    label_1000_583F_1583F:
    // MOV DI,0x100 (1000_583F / 0x1583F)
    DI = 0x100;
    label_1000_5842_15842:
    // MOV AL,byte ptr [DI + 0xa] (1000_5842 / 0x15842)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    // TEST AL,0x80 (1000_5845 / 0x15845)
    Alu.And8(AL, 0x80);
    // JNZ 0x1000:5861 (1000_5847 / 0x15847)
    if(!ZeroFlag) {
      goto label_1000_5861_15861;
    }
    // PUSH BP (1000_5849 / 0x15849)
    Stack.Push(BP);
    // XOR BX,BX (1000_584A / 0x1584A)
    BX = 0;
    // XOR CX,CX (1000_584C / 0x1584C)
    CX = 0;
    // MOV BP,0x5728 (1000_584E / 0x1584E)
    BP = 0x5728;
    // CALL 0x1000:6639 (1000_5851 / 0x15851)
    NearCall(cs1, 0x5854, spice86_generated_label_call_target_1000_6639_016639);
    // POP BP (1000_5854 / 0x15854)
    BP = Stack.Pop();
    // CALL 0x1000:586e (1000_5855 / 0x15855)
    NearCall(cs1, 0x5858, not_observed_1000_586E_01586E);
    // MOV AL,byte ptr [DI + 0x10] (1000_5858 / 0x15858)
    AL = UInt8[DS, (ushort)(DI + 0x10)];
    // XOR AH,AH (1000_585B / 0x1585B)
    AH = 0;
    // MOV SI,AX (1000_585D / 0x1585D)
    SI = AX;
    // MOV byte ptr [BP + SI],BH (1000_585F / 0x1585F)
    UInt8[SS, (ushort)(BP + SI)] = BH;
    label_1000_5861_15861:
    // ADD DI,0x1c (1000_5861 / 0x15861)
    DI += 0x1C;
    // CMP byte ptr [DI],0xff (1000_5864 / 0x15864)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:5842 (1000_5867 / 0x15867)
    if(!ZeroFlag) {
      goto label_1000_5842_15842;
    }
    // POP ES (1000_5869 / 0x15869)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_586A / 0x1586A)
    NearCall(cs1, 0x586D, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_586D / 0x1586D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_586E_01586E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_586E_1586E:
    // XOR AX,AX (1000_586E / 0x1586E)
    AX = 0;
    // OR BL,BL (1000_5870 / 0x15870)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:5876 (1000_5872 / 0x15872)
    if(ZeroFlag) {
      goto label_1000_5876_15876;
    }
    // MOV AL,0x1 (1000_5874 / 0x15874)
    AL = 0x1;
    label_1000_5876_15876:
    // OR CH,CH (1000_5876 / 0x15876)
    // CH |= CH;
    CH = Alu.Or8(CH, CH);
    // JZ 0x1000:587c (1000_5878 / 0x15878)
    if(ZeroFlag) {
      goto label_1000_587C_1587C;
    }
    // ADD AL,0x2 (1000_587A / 0x1587A)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    label_1000_587C_1587C:
    // OR CL,CL (1000_587C / 0x1587C)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JZ 0x1000:5882 (1000_587E / 0x1587E)
    if(ZeroFlag) {
      goto label_1000_5882_15882;
    }
    // ADD AL,0x4 (1000_5880 / 0x15880)
    AL += 0x4;
    label_1000_5882_15882:
    // SHL AX,1 (1000_5882 / 0x15882)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV SI,AX (1000_5884 / 0x15884)
    SI = AX;
    // JMP word ptr CS:[SI + 0x588b] (1000_5886 / 0x15886)
    // Indirect jump to word ptr CS:[SI + 0x588b], generating possible targets from emulator records
    uint targetAddress_1000_5886 = (uint)(UInt16[cs1, (ushort)(SI + 0x588B)]);
    switch(targetAddress_1000_5886) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5886));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action not_observed_1000_58E4_0158E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_58E4_158E4:
    // SUB SP,0x100 (1000_58E4 / 0x158E4)
    // SP -= 0x100;
    SP = Alu.Sub16(SP, 0x100);
    // MOV BP,SP (1000_58E8 / 0x158E8)
    BP = SP;
    // CALL 0x1000:57e5 (1000_58EA / 0x158EA)
    NearCall(cs1, 0x58ED, not_observed_1000_57E5_0157E5);
    // MOV BH,byte ptr [0x4722] (1000_58ED / 0x158ED)
    BH = UInt8[DS, 0x4722];
    // CALLF [0x395d] (1000_58F1 / 0x158F1)
    // Indirect call to [0x395d], generating possible targets from emulator records
    uint targetAddress_1000_58F1 = (uint)(UInt16[DS, 0x395F] * 0x10 + UInt16[DS, 0x395D] - cs1 * 0x10);
    switch(targetAddress_1000_58F1) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_58F1));
        break;
    }
    // ADD SP,0x100 (1000_58F5 / 0x158F5)
    // SP += 0x100;
    SP = Alu.Add16(SP, 0x100);
    // RET  (1000_58F9 / 0x158F9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_58FA_0158FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_58FA_158FA:
    // TEST byte ptr [0x46eb],0x40 (1000_58FA / 0x158FA)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JZ 0x1000:5922 (1000_58FF / 0x158FF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5922 / 0x15922)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_5901 / 0x15901)
    NearCall(cs1, 0x5904, spice86_generated_label_call_target_1000_E270_01E270);
    // AND byte ptr [0x46eb],0xbf (1000_5904 / 0x15904)
    // UInt8[DS, 0x46EB] &= 0xBF;
    UInt8[DS, 0x46EB] = Alu.And8(UInt8[DS, 0x46EB], 0xBF);
    // MOV DI,0xdbe0 (1000_5909 / 0x15909)
    DI = 0xDBE0;
    // CMP word ptr [DI],0x4710 (1000_590C / 0x1590C)
    Alu.Sub16(UInt16[DS, DI], 0x4710);
    // JZ 0x1000:5915 (1000_5910 / 0x15910)
    if(ZeroFlag) {
      goto label_1000_5915_15915;
    }
    // MOV DI,0xdbe2 (1000_5912 / 0x15912)
    DI = 0xDBE2;
    label_1000_5915_15915:
    // XOR SI,SI (1000_5915 / 0x15915)
    SI = 0;
    // XCHG word ptr [DI],SI (1000_5917 / 0x15917)
    ushort tmp_1000_5917 = UInt16[DS, DI];
    UInt16[DS, DI] = SI;
    SI = tmp_1000_5917;
    // CALL 0x1000:c6ad (1000_5919 / 0x15919)
    NearCall(cs1, 0x591C, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // CALL 0x1000:5ad9 (1000_591C / 0x1591C)
    NearCall(cs1, 0x591F, spice86_generated_label_ret_target_1000_5AD9_015AD9);
    // CALL 0x1000:e283 (1000_591F / 0x1591F)
    NearCall(cs1, 0x5922, spice86_generated_label_call_target_1000_E283_01E283);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5922_015922, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5922_015922(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5922_15922:
    // RET  (1000_5922 / 0x15922)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5982_015982(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5982_15982:
    // CALL 0x1000:e270 (1000_5982 / 0x15982)
    NearCall(cs1, 0x5985, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV DX,word ptr [0x11c1] (1000_5985 / 0x15985)
    DX = UInt16[DS, 0x11C1];
    // MOV BX,word ptr [0x11c3] (1000_5989 / 0x15989)
    BX = UInt16[DS, 0x11C3];
    // MOV SI,0xaa (1000_598D / 0x1598D)
    SI = 0xAA;
    // MOV CX,0x6c (1000_5990 / 0x15990)
    CX = 0x6C;
    // MOV ES,word ptr [0xdbd8] (1000_5993 / 0x15993)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x3961] (1000_5997 / 0x15997)
    // Indirect call to [0x3961], generating possible targets from emulator records
    uint targetAddress_1000_5997 = (uint)(UInt16[DS, 0x3963] * 0x10 + UInt16[DS, 0x3961] - cs1 * 0x10);
    switch(targetAddress_1000_5997) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5997));
        break;
    }
    // CALL 0x1000:e283 (1000_599B / 0x1599B)
    NearCall(cs1, 0x599E, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_599E_1599E:
    // RET  (1000_599E / 0x1599E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_599F_01599F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_599F_1599F:
    // XOR AL,AL (1000_599F / 0x1599F)
    AL = 0;
    // XCHG byte ptr [0x4723],AL (1000_59A1 / 0x159A1)
    byte tmp_1000_59A1 = UInt8[DS, 0x4723];
    UInt8[DS, 0x4723] = AL;
    AL = tmp_1000_59A1;
    // OR AL,AL (1000_59A5 / 0x159A5)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:5a02 (1000_59A7 / 0x159A7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5A02 / 0x15A02)
      return NearRet();
    }
    // CALL 0x1000:557b (1000_59A9 / 0x159A9)
    NearCall(cs1, 0x59AC, not_observed_1000_557B_01557B);
    // CMP DX,word ptr [0x11c1] (1000_59AC / 0x159AC)
    Alu.Sub16(DX, UInt16[DS, 0x11C1]);
    // JNZ 0x1000:59b8 (1000_59B0 / 0x159B0)
    if(!ZeroFlag) {
      goto label_1000_59B8_159B8;
    }
    // CMP BX,word ptr [0x11c3] (1000_59B2 / 0x159B2)
    Alu.Sub16(BX, UInt16[DS, 0x11C3]);
    // JZ 0x1000:5982 (1000_59B6 / 0x159B6)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_5982_015982, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_59B8_159B8:
    // MOV word ptr [0xdbe0],0x0 (1000_59B8 / 0x159B8)
    UInt16[DS, 0xDBE0] = 0x0;
    // JMP 0x1000:5b10 (1000_59BE / 0x159BE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B10_015B10, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_59C1_0159C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_59C1_159C1:
    // CMP byte ptr [0x4723],0x0 (1000_59C1 / 0x159C1)
    Alu.Sub8(UInt8[DS, 0x4723], 0x0);
    // JZ 0x1000:5a02 (1000_59C6 / 0x159C6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5A02 / 0x15A02)
      return NearRet();
    }
    // CMP BX,0x98 (1000_59C8 / 0x159C8)
    Alu.Sub16(BX, 0x98);
    // JNC 0x1000:599f (1000_59CC / 0x159CC)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_599F_01599F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:5982 (1000_59CE / 0x159CE)
    NearCall(cs1, 0x59D1, not_observed_1000_5982_015982);
    // MOV SI,0x11c1 (1000_59D1 / 0x159D1)
    SI = 0x11C1;
    // MOV AX,word ptr [SI] (1000_59D4 / 0x159D4)
    AX = UInt16[DS, SI];
    // ADD AX,DI (1000_59D6 / 0x159D6)
    AX += DI;
    // SUB AX,0x5 (1000_59D8 / 0x159D8)
    AX -= 0x5;
    // CMP AX,0x8c (1000_59DB / 0x159DB)
    Alu.Sub16(AX, 0x8C);
    // JC 0x1000:59e7 (1000_59DE / 0x159DE)
    if(CarryFlag) {
      goto label_1000_59E7_159E7;
    }
    // JL 0x1000:59e5 (1000_59E0 / 0x159E0)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59E5_159E5;
    }
    // SUB AX,0x8c (1000_59E2 / 0x159E2)
    AX -= 0x8C;
    label_1000_59E5_159E5:
    // SUB DI,AX (1000_59E5 / 0x159E5)
    DI -= AX;
    label_1000_59E7_159E7:
    // ADD word ptr [SI],DI (1000_59E7 / 0x159E7)
    // UInt16[DS, SI] += DI;
    UInt16[DS, SI] = Alu.Add16(UInt16[DS, SI], DI);
    // MOV AX,word ptr [SI + 0x2] (1000_59E9 / 0x159E9)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // ADD AX,CX (1000_59EC / 0x159EC)
    AX += CX;
    // SUB AX,0x5 (1000_59EE / 0x159EE)
    AX -= 0x5;
    // CMP AX,0x18 (1000_59F1 / 0x159F1)
    Alu.Sub16(AX, 0x18);
    // JC 0x1000:59fd (1000_59F4 / 0x159F4)
    if(CarryFlag) {
      goto label_1000_59FD_159FD;
    }
    // JL 0x1000:59fb (1000_59F6 / 0x159F6)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59FB_159FB;
    }
    // SUB AX,0x18 (1000_59F8 / 0x159F8)
    AX -= 0x18;
    label_1000_59FB_159FB:
    // SUB CX,AX (1000_59FB / 0x159FB)
    CX -= AX;
    label_1000_59FD_159FD:
    // ADD word ptr [SI + 0x2],CX (1000_59FD / 0x159FD)
    // UInt16[DS, (ushort)(SI + 0x2)] += CX;
    UInt16[DS, (ushort)(SI + 0x2)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x2)], CX);
    // JMP 0x1000:5982 (1000_5A00 / 0x15A00)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5982_015982, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5A02_015A02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A02_15A02:
    // RET  (1000_5A02 / 0x15A02)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5A03_015A03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A03_15A03:
    // CALL 0x1000:8c8a (1000_5A03 / 0x15A03)
    NearCall(cs1, 0x5A06, spice86_generated_label_call_target_1000_8C8A_018C8A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A06_015A06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A06_015A06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A06_15A06:
    // INC byte ptr [0x46f3] (1000_5A06 / 0x15A06)
    UInt8[DS, 0x46F3] = Alu.Inc8(UInt8[DS, 0x46F3]);
    // CALL 0x1000:68eb (1000_5A0A / 0x15A0A)
    NearCall(cs1, 0x5A0D, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A0D_015A0D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A0D_015A0D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A0D_15A0D:
    // MOV [0x1954],AL (1000_5A0D / 0x15A0D)
    UInt8[DS, 0x1954] = AL;
    // NOT byte ptr [0xfb] (1000_5A10 / 0x15A10)
    UInt8[DS, 0xFB] = (byte)~UInt8[DS, 0xFB];
    // CALL 0x1000:5a1a (1000_5A14 / 0x15A14)
    NearCall(cs1, 0x5A17, spice86_generated_label_call_target_1000_5A1A_015A1A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A17_015A17, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A17_015A17(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A17_15A17:
    // JMP 0x1000:8685 (1000_5A17 / 0x15A17)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8685_018685, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5A1A_015A1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A1A_15A1A:
    // MOV byte ptr [0x28e7],0x1 (1000_5A1A / 0x15A1A)
    UInt8[DS, 0x28E7] = 0x1;
    // CALL 0x1000:18ba (1000_5A1F / 0x15A1F)
    NearCall(cs1, 0x5A22, spice86_generated_label_call_target_1000_18BA_0118BA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A22_015A22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A22_015A22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A22_15A22:
    // CALL 0x1000:5b5d (1000_5A22 / 0x15A22)
    NearCall(cs1, 0x5A25, spice86_generated_label_call_target_1000_5B5D_015B5D);
    label_1000_5A25_15A25:
    // MOV BP,0x5a56 (1000_5A25 / 0x15A25)
    BP = 0x5A56;
    // MOV AL,0x34 (1000_5A28 / 0x15A28)
    AL = 0x34;
    // MOV DX,0xffff (1000_5A2A / 0x15A2A)
    DX = 0xFFFF;
    // CALL 0x1000:c108 (1000_5A2D / 0x15A2D)
    NearCall(cs1, 0x5A30, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_5A30_15A30:
    // CMP byte ptr [0x46f3],0x0 (1000_5A30 / 0x15A30)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x0);
    // JNZ 0x1000:5a3a (1000_5A35 / 0x15A35)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:17e6 (1000_5A3A / 0x15A3A)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:5bb0 (1000_5A37 / 0x15A37)
    NearCall(cs1, 0x5A3A, not_observed_1000_5BB0_015BB0);
    label_1000_5A3A_15A3A:
    // JMP 0x1000:17e6 (1000_5A3A / 0x15A3A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5A3D_015A3D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A3D_15A3D:
    // MOV byte ptr [0xfb],0xff (1000_5A3D / 0x15A3D)
    UInt8[DS, 0xFB] = 0xFF;
    // CALL 0x1000:c13b (1000_5A42 / 0x15A42)
    NearCall(cs1, 0x5A45, spice86_generated_label_call_target_1000_C13B_01C13B);
    label_1000_5A45_15A45:
    // CALLF [0x3935] (1000_5A45 / 0x15A45)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_5A45 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_5A45) {
      case 0x23610 : FarCall(cs1, 0x5A49, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5A45));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A49_015A49, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A49_015A49(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A49_15A49:
    // MOV BP,0x5a56 (1000_5A49 / 0x15A49)
    BP = 0x5A56;
    // MOV AL,0x2 (1000_5A4C / 0x15A4C)
    AL = 0x2;
    // XOR DX,DX (1000_5A4E / 0x15A4E)
    DX = 0;
    // CALL 0x1000:c108 (1000_5A50 / 0x15A50)
    NearCall(cs1, 0x5A53, spice86_generated_label_call_target_1000_C108_01C108);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A53_015A53, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A53_015A53(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A53_15A53:
    // JMP 0x1000:ae04 (1000_5A53 / 0x15A53)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AE04_01AE04, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5A56_015A56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A56_15A56:
    // CMP byte ptr [0x46eb],0x0 (1000_5A56 / 0x15A56)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:5a9a (1000_5A5B / 0x15A5B)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5A9A_015A9A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:d2bd (1000_5A5D / 0x15A5D)
    NearCall(cs1, 0x5A60, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A60_015A60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A60_015A60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A60_15A60:
    // CALL 0x1000:4aca (1000_5A60 / 0x15A60)
    NearCall(cs1, 0x5A63, spice86_generated_label_call_target_1000_4ACA_014ACA);
    label_1000_5A63_15A63:
    // CALL 0x1000:b930 (1000_5A63 / 0x15A63)
    NearCall(cs1, 0x5A66, spice86_generated_label_call_target_1000_B930_01B930);
    label_1000_5A66_15A66:
    // MOV SI,0x6b34 (1000_5A66 / 0x15A66)
    SI = 0x6B34;
    // MOV BP,0xf (1000_5A69 / 0x15A69)
    BP = 0xF;
    // CALL 0x1000:da25 (1000_5A6C / 0x15A6C)
    NearCall(cs1, 0x5A6F, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_5A6F_15A6F:
    // MOV SI,0x1482 (1000_5A6F / 0x15A6F)
    SI = 0x1482;
    // MOV DI,0x46e3 (1000_5A72 / 0x15A72)
    DI = 0x46E3;
    // CALL 0x1000:5b99 (1000_5A75 / 0x15A75)
    NearCall(cs1, 0x5A78, spice86_generated_label_call_target_1000_5B99_015B99);
    label_1000_5A78_15A78:
    // CALL 0x1000:5b69 (1000_5A78 / 0x15A78)
    NearCall(cs1, 0x5A7B, spice86_generated_label_call_target_1000_5B69_015B69);
    label_1000_5A7B_15A7B:
    // CALL 0x1000:1797 (1000_5A7B / 0x15A7B)
    NearCall(cs1, 0x5A7E, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_5A7E_15A7E:
    // MOV byte ptr [0x46eb],0x80 (1000_5A7E / 0x15A7E)
    UInt8[DS, 0x46EB] = 0x80;
    // CALL 0x1000:ad5e (1000_5A83 / 0x15A83)
    NearCall(cs1, 0x5A86, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    label_1000_5A86_15A86:
    // MOV word ptr [0x2786],0xc835 (1000_5A86 / 0x15A86)
    UInt16[DS, 0x2786] = 0xC835;
    // MOV AX,0x5a9a (1000_5A8C / 0x15A8C)
    AX = 0x5A9A;
    // MOV [0x46ed],AX (1000_5A8F / 0x15A8F)
    UInt16[DS, 0x46ED] = AX;
    // CALL AX (1000_5A92 / 0x15A92)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_5A92 = (uint)(AX);
    switch(targetAddress_1000_5A92) {
      case 0x5A9A : NearCall(cs1, 0x5A94, spice86_generated_label_call_target_1000_5A9A_015A9A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5A92));
        break;
    }
    label_1000_5A94_15A94:
    // CALL 0x1000:d792 (1000_5A94 / 0x15A94)
    NearCall(cs1, 0x5A97, spice86_generated_label_call_target_1000_D792_01D792);
    label_1000_5A97_15A97:
    // JMP 0x1000:d712 (1000_5A97 / 0x15A97)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D712_01D712, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5A9A_015A9A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A9A_15A9A:
    // CALL 0x1000:c07c (1000_5A9A / 0x15A9A)
    NearCall(cs1, 0x5A9D, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A9D_015A9D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A9D_015A9D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5A9D_15A9D:
    // CALL 0x1000:5b8d (1000_5A9D / 0x15A9D)
    NearCall(cs1, 0x5AA0, spice86_generated_label_call_target_1000_5B8D_015B8D);
    label_1000_5AA0_15AA0:
    // MOV AL,0x80 (1000_5AA0 / 0x15AA0)
    AL = 0x80;
    // XCHG byte ptr [0x46eb],AL (1000_5AA2 / 0x15AA2)
    byte tmp_1000_5AA2 = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_5AA2;
    // PUSH AX (1000_5AA6 / 0x15AA6)
    Stack.Push(AX);
    // CALL 0x1000:b6c3 (1000_5AA7 / 0x15AA7)
    NearCall(cs1, 0x5AAA, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    label_1000_5AAA_15AAA:
    // CALL 0x1000:c13b (1000_5AAA / 0x15AAA)
    NearCall(cs1, 0x5AAD, spice86_generated_label_call_target_1000_C13B_01C13B);
    label_1000_5AAD_15AAD:
    // CALL 0x1000:5dce (1000_5AAD / 0x15AAD)
    NearCall(cs1, 0x5AB0, spice86_generated_label_call_target_1000_5DCE_015DCE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AB0_015AB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AB0_015AB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5AB0_15AB0:
    // CALL 0x1000:6314 (1000_5AB0 / 0x15AB0)
    NearCall(cs1, 0x5AB3, spice86_generated_label_call_target_1000_6314_016314);
    label_1000_5AB3_15AB3:
    // CALL 0x1000:c412 (1000_5AB3 / 0x15AB3)
    NearCall(cs1, 0x5AB6, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_5AB6_15AB6:
    // MOV word ptr [0x3cbe],0x0 (1000_5AB6 / 0x15AB6)
    UInt16[DS, 0x3CBE] = 0x0;
    // CALL 0x1000:6715 (1000_5ABC / 0x15ABC)
    NearCall(cs1, 0x5ABF, spice86_generated_label_call_target_1000_6715_016715);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5ABF_015ABF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5ABF_015ABF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5ABF_15ABF:
    // MOV SI,0x46e3 (1000_5ABF / 0x15ABF)
    SI = 0x46E3;
    // CALL 0x1000:c6ad (1000_5AC2 / 0x15AC2)
    NearCall(cs1, 0x5AC5, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AC5_015AC5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AC5_015AC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5AC5_15AC5:
    // CALL 0x1000:878c (1000_5AC5 / 0x15AC5)
    NearCall(cs1, 0x5AC8, spice86_generated_label_call_target_1000_878C_01878C);
    label_1000_5AC8_15AC8:
    // POP AX (1000_5AC8 / 0x15AC8)
    AX = Stack.Pop();
    // MOV [0x46eb],AL (1000_5AC9 / 0x15AC9)
    UInt8[DS, 0x46EB] = AL;
    // AND AL,0x40 (1000_5ACC / 0x15ACC)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    // JZ 0x1000:5ad3 (1000_5ACE / 0x15ACE)
    if(ZeroFlag) {
      goto label_1000_5AD3_15AD3;
    }
    // CALL 0x1000:5406 (1000_5AD0 / 0x15AD0)
    NearCall(cs1, 0x5AD3, not_observed_1000_5406_015406);
    label_1000_5AD3_15AD3:
    // MOV AX,0x1a9e (1000_5AD3 / 0x15AD3)
    AX = 0x1A9E;
    // CALL 0x1000:d95e (1000_5AD6 / 0x15AD6)
    NearCall(cs1, 0x5AD9, spice86_generated_label_call_target_1000_D95E_01D95E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AD9_015AD9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AD9_015AD9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5AD9_15AD9:
    // MOV SI,0x46e3 (1000_5AD9 / 0x15AD9)
    SI = 0x46E3;
    // JMP 0x1000:daaa (1000_5ADC / 0x15ADC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAAA_01DAAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5ADF_015ADF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5ADF_15ADF:
    // CALL 0x1000:7b36 (1000_5ADF / 0x15ADF)
    NearCall(cs1, 0x5AE2, spice86_generated_label_call_target_1000_7B36_017B36);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AE2_015AE2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AE2_015AE2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5AE2_15AE2:
    // XOR AX,AX (1000_5AE2 / 0x15AE2)
    AX = 0;
    // MOV [0x46eb],AL (1000_5AE4 / 0x15AE4)
    UInt8[DS, 0x46EB] = AL;
    // MOV [0x46f3],AL (1000_5AE7 / 0x15AE7)
    UInt8[DS, 0x46F3] = AL;
    // MOV [0x3cbe],AX (1000_5AEA / 0x15AEA)
    UInt16[DS, 0x3CBE] = AX;
    // MOV [0xa5c0],AX (1000_5AED / 0x15AED)
    UInt16[DS, 0xA5C0] = AX;
    // MOV [0xdbe0],AX (1000_5AF0 / 0x15AF0)
    UInt16[DS, 0xDBE0] = AX;
    // MOV [0xdbe2],AX (1000_5AF3 / 0x15AF3)
    UInt16[DS, 0xDBE2] = AX;
    // MOV [0x1954],AX (1000_5AF6 / 0x15AF6)
    UInt16[DS, 0x1954] = AX;
    // MOV word ptr [0x2786],0xc827 (1000_5AF9 / 0x15AF9)
    UInt16[DS, 0x2786] = 0xC827;
    // MOV SI,0x6b34 (1000_5AFF / 0x15AFF)
    SI = 0x6B34;
    // JMP 0x1000:da5f (1000_5B02 / 0x15B02)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B05_015B05(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B05_15B05:
    // CALL 0x1000:82a0 (1000_5B05 / 0x15B05)
    NearCall(cs1, 0x5B08, spice86_generated_label_call_target_1000_82A0_0182A0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B08_015B08, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B08_015B08(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B08_15B08:
    // JNZ 0x1000:5b0d (1000_5B08 / 0x15B08)
    if(!ZeroFlag) {
      goto label_1000_5B0D_15B0D;
    }
    // JMP 0x1000:541f (1000_5B0A / 0x15B0A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_541F_01541F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5B0D_15B0D:
    // CALL 0x1000:5b5d (1000_5B0D / 0x15B0D)
    NearCall(cs1, 0x5B10, spice86_generated_label_call_target_1000_5B5D_015B5D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B10_015B10, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B10_015B10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B10_15B10:
    // CALL 0x1000:8850 (1000_5B10 / 0x15B10)
    NearCall(cs1, 0x5B13, spice86_generated_label_call_target_1000_8850_018850);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B13_015B13, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B13_015B13(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B13_15B13:
    // TEST byte ptr [0x46eb],0x40 (1000_5B13 / 0x15B13)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JZ 0x1000:5b1d (1000_5B18 / 0x15B18)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5B1D / 0x15B1D)
      return NearRet();
    }
    // JMP 0x1000:5575 (1000_5B1A / 0x15B1A)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_542F_01542F, 0x15575 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5B1D_15B1D:
    // RET  (1000_5B1D / 0x15B1D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B5D_015B5D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B5D_15B5D:
    // CALL 0x1000:407e (1000_5B5D / 0x15B5D)
    NearCall(cs1, 0x5B60, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B60_015B60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B60_015B60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B60_15B60:
    // MOV word ptr [0x197e],BX (1000_5B60 / 0x15B60)
    UInt16[DS, 0x197E] = BX;
    // MOV word ptr [0x197c],DX (1000_5B64 / 0x15B64)
    UInt16[DS, 0x197C] = DX;
    // RET  (1000_5B68 / 0x15B68)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B69_015B69(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B69_15B69:
    // MOV SI,0x46e3 (1000_5B69 / 0x15B69)
    SI = 0x46E3;
    // MOV AL,0xfc (1000_5B6C / 0x15B6C)
    AL = 0xFC;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B6E_015B6E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B6E_015B6E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B6E_15B6E:
    // MOV DX,word ptr [SI] (1000_5B6E / 0x15B6E)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_5B70 / 0x15B70)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV DI,word ptr [SI + 0x4] (1000_5B73 / 0x15B73)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV CX,word ptr [SI + 0x6] (1000_5B76 / 0x15B76)
    CX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV BP,0x4 (1000_5B79 / 0x15B79)
    BP = 0x4;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5B7C_015B7C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5B7C_015B7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B7C_15B7C:
    // PUSH AX (1000_5B7C / 0x15B7C)
    Stack.Push(AX);
    // PUSH BP (1000_5B7D / 0x15B7D)
    Stack.Push(BP);
    // DEC DX (1000_5B7E / 0x15B7E)
    DX--;
    // DEC BX (1000_5B7F / 0x15B7F)
    BX = Alu.Dec16(BX);
    // CALL 0x1000:c560 (1000_5B80 / 0x15B80)
    NearCall(cs1, 0x5B83, spice86_generated_label_call_target_1000_C560_01C560);
    label_1000_5B83_15B83:
    // POP BP (1000_5B83 / 0x15B83)
    BP = Stack.Pop();
    // POP AX (1000_5B84 / 0x15B84)
    AX = Stack.Pop();
    // INC DI (1000_5B85 / 0x15B85)
    DI++;
    // INC CX (1000_5B86 / 0x15B86)
    CX++;
    // SUB AL,0x2 (1000_5B87 / 0x15B87)
    AL -= 0x2;
    // DEC BP (1000_5B89 / 0x15B89)
    BP = Alu.Dec16(BP);
    // JNZ 0x1000:5b7c (1000_5B8A / 0x15B8A)
    if(!ZeroFlag) {
      goto label_1000_5B7C_15B7C;
    }
    // RET  (1000_5B8C / 0x15B8C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B8D_015B8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B8D_15B8D:
    // MOV DI,0xd83c (1000_5B8D / 0x15B8D)
    DI = 0xD83C;
    // CALL 0x1000:5b96 (1000_5B90 / 0x15B90)
    NearCall(cs1, 0x5B93, spice86_generated_label_call_target_1000_5B96_015B96);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B93_015B93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B93_015B93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B93_15B93:
    // MOV DI,0xd834 (1000_5B93 / 0x15B93)
    DI = 0xD834;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B96_015B96, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B96_015B96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B96_15B96:
    // MOV SI,0x46e3 (1000_5B96 / 0x15B96)
    SI = 0x46E3;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B99_015B99(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5B99_15B99:
    // PUSH DS (1000_5B99 / 0x15B99)
    Stack.Push(DS);
    // POP ES (1000_5B9A / 0x15B9A)
    ES = Stack.Pop();
    // MOVSW ES:DI,SI (1000_5B9B / 0x15B9B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_5B9C / 0x15B9C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_5B9D / 0x15B9D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_5B9E / 0x15B9E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // RET  (1000_5B9F / 0x15B9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5BA0_015BA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5BA0_15BA0:
    // MOV SI,0x1470 (1000_5BA0 / 0x15BA0)
    SI = 0x1470;
    // MOV DI,0xd83c (1000_5BA3 / 0x15BA3)
    DI = 0xD83C;
    // JMP 0x1000:5b99 (1000_5BA6 / 0x15BA6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5BA8_015BA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5BA8_15BA8:
    // MOV SI,0x1470 (1000_5BA8 / 0x15BA8)
    SI = 0x1470;
    // MOV DI,0xd834 (1000_5BAB / 0x15BAB)
    DI = 0xD834;
    // JMP 0x1000:5b99 (1000_5BAE / 0x15BAE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5BB0_015BB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5BB0_15BB0:
    // CALL 0x1000:c08e (1000_5BB0 / 0x15BB0)
    NearCall(cs1, 0x5BB3, spice86_generated_label_call_target_1000_C08E_01C08E);
    // MOV SI,0x194a (1000_5BB3 / 0x15BB3)
    SI = 0x194A;
    // MOV word ptr [0xdbe0],SI (1000_5BB6 / 0x15BB6)
    UInt16[DS, 0xDBE0] = SI;
    // CALL 0x1000:7b1b (1000_5BBA / 0x15BBA)
    NearCall(cs1, 0x5BBD, spice86_generated_label_call_target_1000_7B1B_017B1B);
    // CALL 0x1000:d068 (1000_5BBD / 0x15BBD)
    NearCall(cs1, 0x5BC0, spice86_generated_label_call_target_1000_D068_01D068);
    // MOV SI,0xe2 (1000_5BC0 / 0x15BC0)
    SI = 0xE2;
    // CALL 0x1000:cf70 (1000_5BC3 / 0x15BC3)
    NearCall(cs1, 0x5BC6, spice86_generated_label_call_target_1000_CF70_01CF70);
    // CALL 0x1000:d03c (1000_5BC6 / 0x15BC6)
    NearCall(cs1, 0x5BC9, spice86_generated_label_call_target_1000_D03C_01D03C);
    // MOV AL,[0x28] (1000_5BC9 / 0x15BC9)
    AL = UInt8[DS, 0x28];
    // XOR AH,AH (1000_5BCC / 0x15BCC)
    AH = 0;
    // CALL 0x1000:e2e3 (1000_5BCE / 0x15BCE)
    NearCall(cs1, 0x5BD1, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    // MOV DX,word ptr [0x194a] (1000_5BD1 / 0x15BD1)
    DX = UInt16[DS, 0x194A];
    // MOV BX,word ptr [0x194c] (1000_5BD5 / 0x15BD5)
    BX = UInt16[DS, 0x194C];
    // ADD DX,0xa (1000_5BD9 / 0x15BD9)
    DX += 0xA;
    // ADD BX,0x8 (1000_5BDC / 0x15BDC)
    // BX += 0x8;
    BX = Alu.Add16(BX, 0x8);
    // MOV CX,0xf0 (1000_5BDF / 0x15BDF)
    CX = 0xF0;
    // MOV AX,0xe2 (1000_5BE2 / 0x15BE2)
    AX = 0xE2;
    // CALL 0x1000:d194 (1000_5BE5 / 0x15BE5)
    NearCall(cs1, 0x5BE8, spice86_generated_label_call_target_1000_D194_01D194);
    // JMP 0x1000:c07c (1000_5BE8 / 0x15BE8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5BEB_015BEB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5BEB_15BEB:
    // CMP word ptr [0xdbe0],0x194a (1000_5BEB / 0x15BEB)
    Alu.Sub16(UInt16[DS, 0xDBE0], 0x194A);
    // JNZ 0x1000:5c02 (1000_5BF1 / 0x15BF1)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_5C02 / 0x15C02)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_5BF3 / 0x15BF3)
    NearCall(cs1, 0x5BF6, spice86_generated_label_call_target_1000_E270_01E270);
    // XOR SI,SI (1000_5BF6 / 0x15BF6)
    SI = 0;
    // XCHG word ptr [0xdbe0],SI (1000_5BF8 / 0x15BF8)
    ushort tmp_1000_5BF8 = UInt16[DS, 0xDBE0];
    UInt16[DS, 0xDBE0] = SI;
    SI = tmp_1000_5BF8;
    // CALL 0x1000:c6ad (1000_5BFC / 0x15BFC)
    NearCall(cs1, 0x5BFF, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // CALL 0x1000:e283 (1000_5BFF / 0x15BFF)
    NearCall(cs1, 0x5C02, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_5C02_15C02:
    // RET  (1000_5C02 / 0x15C02)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5C03_015C03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5C03_15C03:
    // MOV DI,word ptr [0xdbe0] (1000_5C03 / 0x15C03)
    DI = UInt16[DS, 0xDBE0];
    // CMP DI,0x194a (1000_5C07 / 0x15C07)
    Alu.Sub16(DI, 0x194A);
    // JNZ 0x1000:5c22 (1000_5C0B / 0x15C0B)
    if(!ZeroFlag) {
      goto label_1000_5C22_15C22;
    }
    // MOV AX,[0xce7a] (1000_5C0D / 0x15C0D)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,word ptr [0xdc5a] (1000_5C10 / 0x15C10)
    AX -= UInt16[DS, 0xDC5A];
    // CMP AX,0x3e8 (1000_5C14 / 0x15C14)
    Alu.Sub16(AX, 0x3E8);
    // JC 0x1000:5c22 (1000_5C17 / 0x15C17)
    if(CarryFlag) {
      goto label_1000_5C22_15C22;
    }
    // CALL 0x1000:dbb2 (1000_5C19 / 0x15C19)
    NearCall(cs1, 0x5C1C, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:5beb (1000_5C1C / 0x15C1C)
    NearCall(cs1, 0x5C1F, spice86_generated_label_call_target_1000_5BEB_015BEB);
    // JMP 0x1000:dbec (1000_5C1F / 0x15C1F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5C22_15C22:
    // CMP DI,0x4710 (1000_5C22 / 0x15C22)
    Alu.Sub16(DI, 0x4710);
    // JZ 0x1000:5c32 (1000_5C26 / 0x15C26)
    if(ZeroFlag) {
      goto label_1000_5C32_15C32;
    }
    // MOV DI,word ptr [0xdbe2] (1000_5C28 / 0x15C28)
    DI = UInt16[DS, 0xDBE2];
    // CMP DI,0x4710 (1000_5C2C / 0x15C2C)
    Alu.Sub16(DI, 0x4710);
    // JNZ 0x1000:5c75 (1000_5C30 / 0x15C30)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_5C75 / 0x15C75)
      return NearRet();
    }
    label_1000_5C32_15C32:
    // CALL 0x1000:d6fe (1000_5C32 / 0x15C32)
    NearCall(cs1, 0x5C35, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JNC 0x1000:5c4b (1000_5C35 / 0x15C35)
    if(!CarryFlag) {
      goto label_1000_5C4B_15C4B;
    }
    // MOV byte ptr [0x46eb],0x40 (1000_5C37 / 0x15C37)
    UInt8[DS, 0x46EB] = 0x40;
    // MOV AL,0xff (1000_5C3C / 0x15C3C)
    AL = 0xFF;
    // CALL 0x1000:5e6d (1000_5C3E / 0x15C3E)
    NearCall(cs1, 0x5C41, spice86_generated_label_call_target_1000_5E6D_015E6D);
    // MOV byte ptr [0x46eb],0xc0 (1000_5C41 / 0x15C41)
    UInt8[DS, 0x46EB] = 0xC0;
    // CMP AX,0x9 (1000_5C46 / 0x15C46)
    Alu.Sub16(AX, 0x9);
    // JC 0x1000:5c4d (1000_5C49 / 0x15C49)
    if(CarryFlag) {
      goto label_1000_5C4D_15C4D;
    }
    label_1000_5C4B_15C4B:
    // XOR DI,DI (1000_5C4B / 0x15C4B)
    DI = 0;
    label_1000_5C4D_15C4D:
    // MOV AX,DI (1000_5C4D / 0x15C4D)
    AX = DI;
    // XCHG word ptr [0x46fc],AX (1000_5C4F / 0x15C4F)
    ushort tmp_1000_5C4F = UInt16[DS, 0x46FC];
    UInt16[DS, 0x46FC] = AX;
    AX = tmp_1000_5C4F;
    // CMP AX,DI (1000_5C53 / 0x15C53)
    Alu.Sub16(AX, DI);
    // JZ 0x1000:5c6e (1000_5C55 / 0x15C55)
    if(ZeroFlag) {
      goto label_1000_5C6E_15C6E;
    }
    // PUSH BX (1000_5C57 / 0x15C57)
    Stack.Push(BX);
    // PUSH DX (1000_5C58 / 0x15C58)
    Stack.Push(DX);
    // PUSH DI (1000_5C59 / 0x15C59)
    Stack.Push(DI);
    // PUSH word ptr [0xdbda] (1000_5C5A / 0x15C5A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:dbb2 (1000_5C5E / 0x15C5E)
    NearCall(cs1, 0x5C61, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:c08e (1000_5C61 / 0x15C61)
    NearCall(cs1, 0x5C64, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:5692 (1000_5C64 / 0x15C64)
    NearCall(cs1, 0x5C67, not_observed_1000_5692_015692);
    // POP word ptr [0xdbda] (1000_5C67 / 0x15C67)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // POP DI (1000_5C6B / 0x15C6B)
    DI = Stack.Pop();
    // POP DX (1000_5C6C / 0x15C6C)
    DX = Stack.Pop();
    // POP BX (1000_5C6D / 0x15C6D)
    BX = Stack.Pop();
    label_1000_5C6E_15C6E:
    // OR DI,DI (1000_5C6E / 0x15C6E)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:5c75 (1000_5C70 / 0x15C70)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_5C75 / 0x15C75)
      return NearRet();
    }
    // CALL 0x1000:5746 (1000_5C72 / 0x15C72)
    NearCall(cs1, 0x5C75, not_observed_1000_5746_015746);
    label_1000_5C75_15C75:
    // RET  (1000_5C75 / 0x15C75)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5C76_015C76(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5C76_15C76:
    // CALL 0x1000:5beb (1000_5C76 / 0x15C76)
    NearCall(cs1, 0x5C79, spice86_generated_label_call_target_1000_5BEB_015BEB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5C79_015C79, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5C79_015C79(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5C79_15C79:
    // CALL 0x1000:c13b (1000_5C79 / 0x15C79)
    NearCall(cs1, 0x5C7C, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5C7C_015C7C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5C7C_015C7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5C7C_15C7C:
    // MOV DI,word ptr [0xdbe0] (1000_5C7C / 0x15C7C)
    DI = UInt16[DS, 0xDBE0];
    // OR DI,DI (1000_5C80 / 0x15C80)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:5c95 (1000_5C82 / 0x15C82)
    if(ZeroFlag) {
      goto label_1000_5C95_15C95;
    }
    // CALL 0x1000:d6fe (1000_5C84 / 0x15C84)
    NearCall(cs1, 0x5C87, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_5C87_15C87:
    // JNC 0x1000:5c95 (1000_5C87 / 0x15C87)
    if(!CarryFlag) {
      goto label_1000_5C95_15C95;
    }
    // CMP DI,0x4710 (1000_5C89 / 0x15C89)
    Alu.Sub16(DI, 0x4710);
    // JNZ 0x1000:5c92 (1000_5C8D / 0x15C8D)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:7e97 (1000_5C92 / 0x15C92)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E97_017E97, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:5923 (1000_5C8F / 0x15C8F)
    throw FailAsUntested("Would have been a goto but label label_1000_5923_15923 does not exist because no instruction was found there that belongs to a function.");
    label_1000_5C92_15C92:
    // JMP 0x1000:7e97 (1000_5C92 / 0x15C92)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E97_017E97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5C95_15C95:
    // MOV DI,word ptr [0xdbe2] (1000_5C95 / 0x15C95)
    DI = UInt16[DS, 0xDBE2];
    // OR DI,DI (1000_5C99 / 0x15C99)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:5ca5 (1000_5C9B / 0x15C9B)
    if(ZeroFlag) {
      goto label_1000_5CA5_15CA5;
    }
    // CALL 0x1000:d6fe (1000_5C9D / 0x15C9D)
    NearCall(cs1, 0x5CA0, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_5CA0_15CA0:
    // JNC 0x1000:5ca5 (1000_5CA0 / 0x15CA0)
    if(!CarryFlag) {
      goto label_1000_5CA5_15CA5;
    }
    // JMP 0x1000:7eb8 (1000_5CA2 / 0x15CA2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7EB8_017EB8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5CA5_15CA5:
    // CMP byte ptr [0x46f5],0x0 (1000_5CA5 / 0x15CA5)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    // JZ 0x1000:5caf (1000_5CAA / 0x15CAA)
    if(ZeroFlag) {
      goto label_1000_5CAF_15CAF;
    }
    // JMP 0x1000:d2e2 (1000_5CAC / 0x15CAC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5CAF_15CAF:
    // CALL 0x1000:6946 (1000_5CAF / 0x15CAF)
    NearCall(cs1, 0x5CB2, spice86_generated_label_call_target_1000_6946_016946);
    label_1000_5CB2_15CB2:
    // JNC 0x1000:5cb7 (1000_5CB2 / 0x15CB2)
    if(!CarryFlag) {
      goto label_1000_5CB7_15CB7;
    }
    // JMP 0x1000:872c (1000_5CB4 / 0x15CB4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_872C_01872C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5CB7_15CB7:
    // MOV AL,0x31 (1000_5CB7 / 0x15CB7)
    AL = 0x31;
    // CALL 0x1000:5e6d (1000_5CB9 / 0x15CB9)
    NearCall(cs1, 0x5CBC, spice86_generated_label_call_target_1000_5E6D_015E6D);
    label_1000_5CBC_15CBC:
    // CMP AX,0x14 (1000_5CBC / 0x15CBC)
    Alu.Sub16(AX, 0x14);
    // JNC 0x1000:5cca (1000_5CBF / 0x15CBF)
    if(!CarryFlag) {
      goto label_1000_5CCA_15CCA;
    }
    // CMP DI,word ptr [0x46f8] (1000_5CC1 / 0x15CC1)
    Alu.Sub16(DI, UInt16[DS, 0x46F8]);
    // JZ 0x1000:5cca (1000_5CC5 / 0x15CC5)
    if(ZeroFlag) {
      goto label_1000_5CCA_15CCA;
    }
    // JMP 0x1000:5fb0 (1000_5CC7 / 0x15CC7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5FB0_015FB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5CCA_15CCA:
    // CALL 0x1000:5f79 (1000_5CCA / 0x15CCA)
    NearCall(cs1, 0x5CCD, spice86_generated_label_call_target_1000_5F79_015F79);
    label_1000_5CCD_15CCD:
    // CALL 0x1000:79de (1000_5CCD / 0x15CCD)
    NearCall(cs1, 0x5CD0, spice86_generated_label_call_target_1000_79DE_0179DE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5CD0_015CD0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
