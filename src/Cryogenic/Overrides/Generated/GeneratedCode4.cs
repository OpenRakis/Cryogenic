namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_36FE_0136FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36FE_136FE:
    // CMP BX,word ptr [SI + 0x2] (1000_36FE / 0x136FE)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:371b (1000_3701 / 0x13701)
    if(!ZeroFlag) {
      goto label_1000_371B_1371B;
    }
    // CMP DX,word ptr [SI] (1000_3703 / 0x13703)
    Alu.Sub16(DX, UInt16[DS, SI]);
    // JNZ 0x1000:371b (1000_3705 / 0x13705)
    if(!ZeroFlag) {
      goto label_1000_371B_1371B;
    }
    // POP DX (1000_3707 / 0x13707)
    DX = Stack.Pop();
    // POP BX (1000_3708 / 0x13708)
    BX = Stack.Pop();
    // PUSH BX (1000_3709 / 0x13709)
    Stack.Push(BX);
    // PUSH DX (1000_370A / 0x1370A)
    Stack.Push(DX);
    // PUSH CX (1000_370B / 0x1370B)
    Stack.Push(CX);
    // PUSH SI (1000_370C / 0x1370C)
    Stack.Push(SI);
    // PUSH BP (1000_370D / 0x1370D)
    Stack.Push(BP);
    // CALL BP (1000_370E / 0x1370E)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_370E = (uint)(BP);
    switch(targetAddress_1000_370E) {
      case 0x30B9 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_30B9_0130B9); break;
      case 0x3120 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_3120_013120); break;
      case 0x3520 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_3520_013520); break;
      case 0x40C9 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_40C9_0140C9); break;
      case 0x40E6 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_40E6_0140E6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_370E));
        break;
    }
    label_1000_3710_13710:
    // POP BP (1000_3710 / 0x13710)
    BP = Stack.Pop();
    // POP SI (1000_3711 / 0x13711)
    SI = Stack.Pop();
    // POP CX (1000_3712 / 0x13712)
    CX = Stack.Pop();
    // MOV BX,word ptr [0x6] (1000_3713 / 0x13713)
    BX = UInt16[DS, 0x6];
    // MOV DX,word ptr [0x4] (1000_3717 / 0x13717)
    DX = UInt16[DS, 0x4];
    label_1000_371B_1371B:
    // ADD SI,0x10 (1000_371B / 0x1371B)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:36fe (1000_371E / 0x1371E)
    if(--CX != 0) {
      goto label_1000_36FE_136FE;
    }
    // POP DX (1000_3720 / 0x13720)
    DX = Stack.Pop();
    // POP BX (1000_3721 / 0x13721)
    BX = Stack.Pop();
    label_1000_3722_13722:
    // RET  (1000_3722 / 0x13722)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_37B2_0137B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37B2_137B2:
    // CALL 0x1000:98e6 (1000_37B2 / 0x137B2)
    NearCall(cs1, 0x37B5, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37B5_0137B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37B5_0137B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37B5_137B5:
    // CALL 0x1000:4d00 (1000_37B5 / 0x137B5)
    NearCall(cs1, 0x37B8, spice86_generated_label_call_target_1000_4D00_014D00);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37B8_0137B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37B8_0137B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37B8_137B8:
    // MOV word ptr [0x472d],0x0 (1000_37B8 / 0x137B8)
    UInt16[DS, 0x472D] = 0x0;
    // CALL 0x1000:5ba8 (1000_37BE / 0x137BE)
    NearCall(cs1, 0x37C1, spice86_generated_label_call_target_1000_5BA8_015BA8);
    label_1000_37C1_137C1:
    // CALL 0x1000:c432 (1000_37C1 / 0x137C1)
    NearCall(cs1, 0x37C4, spice86_generated_label_call_target_1000_C432_01C432);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37C4_0137C4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37C4_0137C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37C4_137C4:
    // MOV AX,0xffff (1000_37C4 / 0x137C4)
    AX = 0xFFFF;
    // CMP byte ptr [0x8],AL (1000_37C7 / 0x137C7)
    Alu.Sub8(UInt8[DS, 0x8], AL);
    // JZ 0x1000:37d5 (1000_37CB / 0x137CB)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37D4_0137D4, 0x137D5 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV DX,word ptr [0x4] (1000_37CD / 0x137CD)
    DX = UInt16[DS, 0x4];
    // CALL 0x1000:3efe (1000_37D1 / 0x137D1)
    NearCall(cs1, 0x37D4, spice86_generated_label_call_target_1000_3EFE_013EFE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37D4_0137D4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37D4_0137D4(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x37D5: goto label_1000_37D5_137D5;break; // Target of external jump from 0x137CB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_37D4_137D4:
    // LODSB SI (1000_37D4 / 0x137D4)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_37D5_137D5:
    // OR AX,AX (1000_37D5 / 0x137D5)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:37dc (1000_37D7 / 0x137D7)
    if(SignFlag) {
      goto label_1000_37DC_137DC;
    }
    // JMP 0x1000:39ec (1000_37D9 / 0x137D9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_39EC_0139EC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_37DC_137DC:
    // CALL 0x1000:3ae9 (1000_37DC / 0x137DC)
    NearCall(cs1, 0x37DF, spice86_generated_label_call_target_1000_3AE9_013AE9);
    label_1000_37DF_137DF:
    // OR byte ptr [0x47a4],0x1 (1000_37DF / 0x137DF)
    UInt8[DS, 0x47A4] |= 0x1;
    // TEST byte ptr [0x11c9],0x3 (1000_37E4 / 0x137E4)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JNZ 0x1000:37f4 (1000_37E9 / 0x137E9)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_37F4_0137F4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_37EB_0137EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_37EB_0137EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37EB_137EB:
    // CALL 0x1000:380c (1000_37EB / 0x137EB)
    NearCall(cs1, 0x37EE, spice86_generated_label_call_target_1000_380C_01380C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37EE_0137EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37EE_0137EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37EE_137EE:
    // CALL 0x1000:4e12 (1000_37EE / 0x137EE)
    NearCall(cs1, 0x37F1, spice86_generated_label_call_target_1000_4E12_014E12);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37F1_0137F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37F1_0137F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37F1_137F1:
    // JMP 0x1000:4d06 (1000_37F1 / 0x137F1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4D06_014D06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_37F4_0137F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37F4_137F4:
    // MOV byte ptr [0x4728],0x0 (1000_37F4 / 0x137F4)
    UInt8[DS, 0x4728] = 0x0;
    // CALL 0x1000:4988 (1000_37F9 / 0x137F9)
    NearCall(cs1, 0x37FC, spice86_generated_label_call_target_1000_4988_014988);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37FC_0137FC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37FC_0137FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37FC_137FC:
    // CALL 0x1000:4a5a (1000_37FC / 0x137FC)
    NearCall(cs1, 0x37FF, spice86_generated_label_call_target_1000_4A5A_014A5A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37FF_0137FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37FF_0137FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_37FF_137FF:
    // MOV AX,[0x487e] (1000_37FF / 0x137FF)
    AX = UInt16[DS, 0x487E];
    // CALL 0x1000:ca1b (1000_3802 / 0x13802)
    NearCall(cs1, 0x3805, spice86_generated_label_call_target_1000_CA1B_01CA1B);
    label_1000_3805_13805:
    // CALLF [0x3959] (1000_3805 / 0x13805)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_3805 = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_3805) {
      case 0x2362B : FarCall(cs1, 0x3809, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3805));
        break;
    }
    label_1000_3809_13809:
    // JMP 0x1000:388d (1000_3809 / 0x13809)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_388D_01388D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_380C_01380C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_380C_1380C:
    // MOV byte ptr [0x22e3],0x1 (1000_380C / 0x1380C)
    UInt8[DS, 0x22E3] = 0x1;
    // CALL 0x1000:388d (1000_3811 / 0x13811)
    NearCall(cs1, 0x3814, spice86_generated_label_ret_target_1000_388D_01388D);
    label_1000_3814_13814:
    // MOV SI,word ptr [0x1150] (1000_3814 / 0x13814)
    SI = UInt16[DS, 0x1150];
    // MOV AX,0x1972 (1000_3818 / 0x13818)
    AX = 0x1972;
    // CALL 0x1000:5e4f (1000_381B / 0x1381B)
    NearCall(cs1, 0x381E, spice86_generated_label_call_target_1000_5E4F_015E4F);
    label_1000_381E_1381E:
    // MOV BX,AX (1000_381E / 0x1381E)
    BX = AX;
    // MOV DX,word ptr [0x4] (1000_3820 / 0x13820)
    DX = UInt16[DS, 0x4];
    // MOV AX,[0x6] (1000_3824 / 0x13824)
    AX = UInt16[DS, 0x6];
    // CMP AL,0x80 (1000_3827 / 0x13827)
    Alu.Sub8(AL, 0x80);
    // MOV AL,0x0 (1000_3829 / 0x13829)
    AL = 0x0;
    // JZ 0x1000:3834 (1000_382B / 0x1382B)
    if(ZeroFlag) {
      goto label_1000_3834_13834;
    }
    // CMP DX,word ptr [SI + 0x2] (1000_382D / 0x1382D)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:384a (1000_3830 / 0x13830)
    if(!ZeroFlag) {
      goto label_1000_384A_1384A;
    }
    // MOV AL,AH (1000_3832 / 0x13832)
    AL = AH;
    label_1000_3834_13834:
    // CMP AL,byte ptr [BX + 0x5] (1000_3834 / 0x13834)
    Alu.Sub8(AL, UInt8[DS, (ushort)(BX + 0x5)]);
    // JNC 0x1000:384a (1000_3837 / 0x13837)
    if(!CarryFlag) {
      goto label_1000_384A_1384A;
    }
    // ADD AL,byte ptr [BX] (1000_3839 / 0x13839)
    AL += UInt8[DS, BX];
    // CMP AL,0x7f (1000_383B / 0x1383B)
    Alu.Sub8(AL, 0x7F);
    // JNZ 0x1000:3847 (1000_383D / 0x1383D)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:c2f2 (1000_3847 / 0x13847)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AH,byte ptr [SI] (1000_383F / 0x1383F)
    AH = UInt8[DS, SI];
    // SHR AH,1 (1000_3841 / 0x13841)
    AH >>= 0x1;
    // ADD AL,AH (1000_3843 / 0x13843)
    AL += AH;
    // SUB AL,0x5 (1000_3845 / 0x13845)
    // AL -= 0x5;
    AL = Alu.Sub8(AL, 0x5);
    label_1000_3847_13847:
    // JMP 0x1000:c2f2 (1000_3847 / 0x13847)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_384A_1384A:
    // MOV DI,word ptr [0x1150] (1000_384A / 0x1384A)
    DI = UInt16[DS, 0x1150];
    // TEST byte ptr [DI + 0xa],0x1 (1000_384E / 0x1384E)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x1);
    // JNZ 0x1000:3872 (1000_3852 / 0x13852)
    if(!ZeroFlag) {
      goto label_1000_3872_13872;
    }
    // CALL 0x1000:407e (1000_3854 / 0x13854)
    NearCall(cs1, 0x3857, spice86_generated_label_call_target_1000_407E_01407E);
    // CALL 0x1000:b58b (1000_3857 / 0x13857)
    NearCall(cs1, 0x385A, spice86_generated_label_call_target_1000_B58B_01B58B);
    // DEC DI (1000_385A / 0x1385A)
    DI = Alu.Dec16(DI);
    // MOV CX,0x4 (1000_385B / 0x1385B)
    CX = 0x4;
    label_1000_385E_1385E:
    // MOV AL,byte ptr ES:[DI] (1000_385E / 0x1385E)
    AL = UInt8[ES, DI];
    // INC DI (1000_3861 / 0x13861)
    DI++;
    // AND AL,0x30 (1000_3862 / 0x13862)
    AL &= 0x30;
    // CMP AL,0x10 (1000_3864 / 0x13864)
    Alu.Sub8(AL, 0x10);
    // JZ 0x1000:3872 (1000_3866 / 0x13866)
    if(ZeroFlag) {
      goto label_1000_3872_13872;
    }
    // LOOP 0x1000:385e (1000_3868 / 0x13868)
    if(--CX != 0) {
      goto label_1000_385E_1385E;
    }
    // MOV BX,0x13 (1000_386A / 0x1386A)
    BX = 0x13;
    // MOV CX,0x42 (1000_386D / 0x1386D)
    CX = 0x42;
    // JMP 0x1000:3878 (1000_3870 / 0x13870)
    goto label_1000_3878_13878;
    label_1000_3872_13872:
    // MOV BX,0xa (1000_3872 / 0x13872)
    BX = 0xA;
    // MOV CX,0x88 (1000_3875 / 0x13875)
    CX = 0x88;
    label_1000_3878_13878:
    // MOV AX,[0x6] (1000_3878 / 0x13878)
    AX = UInt16[DS, 0x6];
    // XCHG AH,AL (1000_387B / 0x1387B)
    byte tmp_1000_387B = AH;
    AH = AL;
    AL = tmp_1000_387B;
    // XOR AX,word ptr [0x4] (1000_387D / 0x1387D)
    AX ^= UInt16[DS, 0x4];
    // INC AX (1000_3881 / 0x13881)
    AX++;
    // XOR DX,DX (1000_3882 / 0x13882)
    DX = 0;
    // DIV BX (1000_3884 / 0x13884)
    Cpu.Div16(BX);
    // MOV AX,DX (1000_3886 / 0x13886)
    AX = DX;
    // ADD AX,CX (1000_3888 / 0x13888)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // JMP 0x1000:c2f2 (1000_388A / 0x1388A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_388D_01388D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_388D_1388D:
    // MOV byte ptr [0x46df],0x1 (1000_388D / 0x1388D)
    UInt8[DS, 0x46DF] = 0x1;
    // CALL 0x1000:395c (1000_3892 / 0x13892)
    NearCall(cs1, 0x3895, spice86_generated_label_call_target_1000_395C_01395C);
    label_1000_3895_13895:
    // CMP byte ptr [0x46d7],0x0 (1000_3895 / 0x13895)
    Alu.Sub8(UInt8[DS, 0x46D7], 0x0);
    // JZ 0x1000:38ad (1000_389A / 0x1389A)
    if(ZeroFlag) {
      goto label_1000_38AD_138AD;
    }
    // CMP byte ptr [0x46d6],BL (1000_389C / 0x1389C)
    Alu.Sub8(UInt8[DS, 0x46D6], BL);
    // JZ 0x1000:38b3 (1000_38A0 / 0x138A0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_38B3 / 0x138B3)
      return NearRet();
    }
    // MOV byte ptr [0x46d7],0x30 (1000_38A2 / 0x138A2)
    UInt8[DS, 0x46D7] = 0x30;
    // CALL 0x1000:3971 (1000_38A7 / 0x138A7)
    NearCall(cs1, 0x38AA, spice86_generated_label_call_target_1000_3971_013971);
    // JMP 0x1000:39b9 (1000_38AA / 0x138AA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_39B9_0139B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_38AD_138AD:
    // CALL 0x1000:3971 (1000_38AD / 0x138AD)
    NearCall(cs1, 0x38B0, spice86_generated_label_call_target_1000_3971_013971);
    label_1000_38B0_138B0:
    // CALL 0x1000:398c (1000_38B0 / 0x138B0)
    NearCall(cs1, 0x38B3, spice86_generated_label_call_target_1000_398C_01398C);
    label_1000_38B3_138B3:
    // RET  (1000_38B3 / 0x138B3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_38B4_0138B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_38B4_138B4:
    // CALL 0x1000:388d (1000_38B4 / 0x138B4)
    NearCall(cs1, 0x38B7, spice86_generated_label_ret_target_1000_388D_01388D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_38B7_0138B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_38B7_0138B7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x38E0: goto label_1000_38E0_138E0;break; // Target of external jump from 0x138E6, 0x138EF, 0x138FF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_38B7_138B7:
    // MOV AX,0x28 (1000_38B7 / 0x138B7)
    AX = 0x28;
    // CALL 0x1000:c13e (1000_38BA / 0x138BA)
    NearCall(cs1, 0x38BD, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_38BD_138BD:
    // XOR AX,AX (1000_38BD / 0x138BD)
    AX = 0;
    // MOV BP,0x14 (1000_38BF / 0x138BF)
    BP = 0x14;
    // XOR BX,BX (1000_38C2 / 0x138C2)
    BX = 0;
    // MOV CX,0x4 (1000_38C4 / 0x138C4)
    CX = 0x4;
    label_1000_38C7_138C7:
    // XOR DX,DX (1000_38C7 / 0x138C7)
    DX = 0;
    // PUSH CX (1000_38C9 / 0x138C9)
    Stack.Push(CX);
    // PUSH BP (1000_38CA / 0x138CA)
    Stack.Push(BP);
    label_1000_38CB_138CB:
    // PUSH AX (1000_38CB / 0x138CB)
    Stack.Push(AX);
    // CALL 0x1000:c2fd (1000_38CC / 0x138CC)
    NearCall(cs1, 0x38CF, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_38CF_138CF:
    // POP AX (1000_38CF / 0x138CF)
    AX = Stack.Pop();
    // ADD DX,0x28 (1000_38D0 / 0x138D0)
    DX += 0x28;
    // CMP DX,0x140 (1000_38D3 / 0x138D3)
    Alu.Sub16(DX, 0x140);
    // JC 0x1000:38cb (1000_38D7 / 0x138D7)
    if(CarryFlag) {
      goto label_1000_38CB_138CB;
    }
    // POP BP (1000_38D9 / 0x138D9)
    BP = Stack.Pop();
    // POP CX (1000_38DA / 0x138DA)
    CX = Stack.Pop();
    // INC AX (1000_38DB / 0x138DB)
    AX++;
    // ADD BX,BP (1000_38DC / 0x138DC)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    // LOOP 0x1000:38c7 (1000_38DE / 0x138DE)
    if(--CX != 0) {
      goto label_1000_38C7_138C7;
    }
    label_1000_38E0_138E0:
    // RET  (1000_38E0 / 0x138E0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_38E1_0138E1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_38E1_138E1:
    // CMP byte ptr [0x46df],0x0 (1000_38E1 / 0x138E1)
    Alu.Sub8(UInt8[DS, 0x46DF], 0x0);
    // JZ 0x1000:38e0 (1000_38E6 / 0x138E6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_38E0 / 0x138E0)
      return NearRet();
    }
    // CALL 0x1000:395c (1000_38E8 / 0x138E8)
    NearCall(cs1, 0x38EB, spice86_generated_label_call_target_1000_395C_01395C);
    label_1000_38EB_138EB:
    // CMP byte ptr [0x46d6],BL (1000_38EB / 0x138EB)
    Alu.Sub8(UInt8[DS, 0x46D6], BL);
    // JZ 0x1000:38e0 (1000_38EF / 0x138EF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_38E0 / 0x138E0)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_38F1_0138F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_38F1_0138F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_38F1_138F1:
    // CALL 0x1000:3971 (1000_38F1 / 0x138F1)
    NearCall(cs1, 0x38F4, spice86_generated_label_call_target_1000_3971_013971);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_38F4_0138F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_38F4_0138F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_38F4_138F4:
    // CALL 0x1000:39b9 (1000_38F4 / 0x138F4)
    NearCall(cs1, 0x38F7, spice86_generated_label_call_target_1000_39B9_0139B9);
    label_1000_38F7_138F7:
    // MOV AL,0x40 (1000_38F7 / 0x138F7)
    AL = 0x40;
    // XCHG byte ptr [0x46d7],AL (1000_38F9 / 0x138F9)
    byte tmp_1000_38F9 = UInt8[DS, 0x46D7];
    UInt8[DS, 0x46D7] = AL;
    AL = tmp_1000_38F9;
    // OR AL,AL (1000_38FD / 0x138FD)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:38e0 (1000_38FF / 0x138FF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_38E0 / 0x138E0)
      return NearRet();
    }
    // MOV SI,0x3916 (1000_3901 / 0x13901)
    SI = 0x3916;
    // MOV BP,0x10 (1000_3904 / 0x13904)
    BP = 0x10;
    // JMP 0x1000:da25 (1000_3907 / 0x13907)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA25_01DA25, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3916_013916(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3916_13916:
    // CMP byte ptr [0x46df],0x0 (1000_3916 / 0x13916)
    Alu.Sub8(UInt8[DS, 0x46DF], 0x0);
    // JZ 0x1000:3950 (1000_391B / 0x1391B)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3950_013950, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,0x1c5 (1000_391D / 0x1391D)
    CX = 0x1C5;
    // MOV BX,0xdb (1000_3920 / 0x13920)
    BX = 0xDB;
    // CMP byte ptr [0x22e3],0x0 (1000_3923 / 0x13923)
    Alu.Sub8(UInt8[DS, 0x22E3], 0x0);
    // JNZ 0x1000:3930 (1000_3928 / 0x13928)
    if(!ZeroFlag) {
      goto label_1000_3930_13930;
    }
    // MOV CX,0xf0 (1000_392A / 0x1392A)
    CX = 0xF0;
    // MOV BX,0x180 (1000_392D / 0x1392D)
    BX = 0x180;
    label_1000_3930_13930:
    // MOV AL,[0x46d7] (1000_3930 / 0x13930)
    AL = UInt8[DS, 0x46D7];
    // PUSH AX (1000_3933 / 0x13933)
    Stack.Push(AX);
    // CALLF [0x3951] (1000_3934 / 0x13934)
    // Indirect call to [0x3951], generating possible targets from emulator records
    uint targetAddress_1000_3934 = (uint)(UInt16[DS, 0x3953] * 0x10 + UInt16[DS, 0x3951] - cs1 * 0x10);
    switch(targetAddress_1000_3934) {
      case 0x23625 : FarCall(cs1, 0x3938, spice86_generated_label_call_target_334B_0175_033625); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3934));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3938_013938, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3938_013938(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3938_13938:
    // POP AX (1000_3938 / 0x13938)
    AX = Stack.Pop();
    // CMP byte ptr [0x227d],0x0 (1000_3939 / 0x13939)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:394a (1000_393E / 0x1393E)
    if(!ZeroFlag) {
      goto label_1000_394A_1394A;
    }
    // MOV CX,0x30 (1000_3940 / 0x13940)
    CX = 0x30;
    // MOV BX,0x2d0 (1000_3943 / 0x13943)
    BX = 0x2D0;
    // CALLF [0x3951] (1000_3946 / 0x13946)
    // Indirect call to [0x3951], generating possible targets from emulator records
    uint targetAddress_1000_3946 = (uint)(UInt16[DS, 0x3953] * 0x10 + UInt16[DS, 0x3951] - cs1 * 0x10);
    switch(targetAddress_1000_3946) {
      case 0x23625 : FarCall(cs1, 0x394A, spice86_generated_label_call_target_334B_0175_033625); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3946));
        break;
    }
    label_1000_394A_1394A:
    // DEC byte ptr [0x46d7] (1000_394A / 0x1394A)
    UInt8[DS, 0x46D7] = Alu.Dec8(UInt8[DS, 0x46D7]);
    // JNZ 0x1000:395b (1000_394E / 0x1394E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_395B / 0x1395B)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3950_013950, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3950_013950(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3950_13950:
    // MOV byte ptr [0x46d7],0x0 (1000_3950 / 0x13950)
    UInt8[DS, 0x46D7] = 0x0;
    // MOV SI,0x3916 (1000_3955 / 0x13955)
    SI = 0x3916;
    // JMP 0x1000:da5f (1000_3958 / 0x13958)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_395B_01395B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_395B_1395B:
    // RET  (1000_395B / 0x1395B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_395C_01395C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_395C_1395C:
    // MOV AX,[0x2] (1000_395C / 0x1395C)
    AX = UInt16[DS, 0x2];
    // MOV AH,AL (1000_395F / 0x1395F)
    AH = AL;
    // SHR AH,1 (1000_3961 / 0x13961)
    AH >>= 0x1;
    // SHR AH,1 (1000_3963 / 0x13963)
    AH >>= 0x1;
    // AND AX,0x1c0f (1000_3965 / 0x13965)
    // AX &= 0x1C0F;
    AX = Alu.And16(AX, 0x1C0F);
    // MOV BX,0x2280 (1000_3968 / 0x13968)
    BX = 0x2280;
    // XLAT BX (1000_396B / 0x1396B)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // ADD AL,AH (1000_396C / 0x1396C)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    // MOV BL,AL (1000_396E / 0x1396E)
    BL = AL;
    // RET  (1000_3970 / 0x13970)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3971_013971(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3971_13971:
    // MOV AX,0x28 (1000_3971 / 0x13971)
    AX = 0x28;
    // ADD AL,byte ptr [0x22e3] (1000_3974 / 0x13974)
    // AL += UInt8[DS, 0x22E3];
    AL = Alu.Add8(AL, UInt8[DS, 0x22E3]);
    // MOV [0xdbb4],AL (1000_3978 / 0x13978)
    UInt8[DS, 0xDBB4] = AL;
    // CALL 0x1000:c13e (1000_397B / 0x1397B)
    NearCall(cs1, 0x397E, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_397E_01397E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_397E_01397E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_397E_1397E:
    // MOV AL,BL (1000_397E / 0x1397E)
    AL = BL;
    // XOR AH,AH (1000_3980 / 0x13980)
    AH = 0;
    // MOV [0x46d6],AL (1000_3982 / 0x13982)
    UInt8[DS, 0x46D6] = AL;
    // CALL 0x1000:c1f4 (1000_3985 / 0x13985)
    NearCall(cs1, 0x3988, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_3988_13988:
    // LEA DX,[SI + 0x6] (1000_3988 / 0x13988)
    DX = (ushort)(SI + 0x6);
    // RET  (1000_398B / 0x1398B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_398C_01398C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_398C_1398C:
    // MOV CX,0x1c5 (1000_398C / 0x1398C)
    CX = 0x1C5;
    // MOV BX,0xdb (1000_398F / 0x1398F)
    BX = 0xDB;
    // CMP byte ptr [0x22e3],0x0 (1000_3992 / 0x13992)
    Alu.Sub8(UInt8[DS, 0x22E3], 0x0);
    // JNZ 0x1000:399f (1000_3997 / 0x13997)
    if(!ZeroFlag) {
      goto label_1000_399F_1399F;
    }
    // MOV CX,0xf0 (1000_3999 / 0x13999)
    CX = 0xF0;
    // MOV BX,0x180 (1000_399C / 0x1399C)
    BX = 0x180;
    label_1000_399F_1399F:
    // PUSH CX (1000_399F / 0x1399F)
    Stack.Push(CX);
    // CALLF [0x38bd] (1000_39A0 / 0x139A0)
    // Indirect call to [0x38bd], generating possible targets from emulator records
    uint targetAddress_1000_39A0 = (uint)(UInt16[DS, 0x38BF] * 0x10 + UInt16[DS, 0x38BD] - cs1 * 0x10);
    switch(targetAddress_1000_39A0) {
      case 0x235B6 : FarCall(cs1, 0x39A4, spice86_generated_label_call_target_334B_0106_0335B6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39A0));
        break;
    }
    label_1000_39A4_139A4:
    // POP CX (1000_39A4 / 0x139A4)
    CX = Stack.Pop();
    // ADD DX,CX (1000_39A5 / 0x139A5)
    DX += CX;
    // CMP byte ptr [0x227d],0x0 (1000_39A7 / 0x139A7)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:39b8 (1000_39AC / 0x139AC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_39B8 / 0x139B8)
      return NearRet();
    }
    // MOV CX,0x30 (1000_39AE / 0x139AE)
    CX = 0x30;
    // MOV BX,0x2d0 (1000_39B1 / 0x139B1)
    BX = 0x2D0;
    // CALLF [0x38bd] (1000_39B4 / 0x139B4)
    // Indirect call to [0x38bd], generating possible targets from emulator records
    uint targetAddress_1000_39B4 = (uint)(UInt16[DS, 0x38BF] * 0x10 + UInt16[DS, 0x38BD] - cs1 * 0x10);
    switch(targetAddress_1000_39B4) {
      case 0x235B6 : FarCall(cs1, 0x39B8, spice86_generated_label_call_target_334B_0106_0335B6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39B4));
        break;
    }
    label_1000_39B8_139B8:
    // RET  (1000_39B8 / 0x139B8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_39B9_0139B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_39B9_139B9:
    // MOV CX,0x1c5 (1000_39B9 / 0x139B9)
    CX = 0x1C5;
    // MOV BX,0xdb (1000_39BC / 0x139BC)
    BX = 0xDB;
    // CMP byte ptr [0x22e3],0x0 (1000_39BF / 0x139BF)
    Alu.Sub8(UInt8[DS, 0x22E3], 0x0);
    // JNZ 0x1000:39cc (1000_39C4 / 0x139C4)
    if(!ZeroFlag) {
      goto label_1000_39CC_139CC;
    }
    // MOV CX,0xf0 (1000_39C6 / 0x139C6)
    CX = 0xF0;
    // MOV BX,0x180 (1000_39C9 / 0x139C9)
    BX = 0x180;
    label_1000_39CC_139CC:
    // PUSH CX (1000_39CC / 0x139CC)
    Stack.Push(CX);
    // CALLF [0x394d] (1000_39CD / 0x139CD)
    // Indirect call to [0x394d], generating possible targets from emulator records
    uint targetAddress_1000_39CD = (uint)(UInt16[DS, 0x394F] * 0x10 + UInt16[DS, 0x394D] - cs1 * 0x10);
    switch(targetAddress_1000_39CD) {
      case 0x23622 : FarCall(cs1, 0x39D1, spice86_generated_label_call_target_334B_0172_033622); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39CD));
        break;
    }
    label_1000_39D1_139D1:
    // POP CX (1000_39D1 / 0x139D1)
    CX = Stack.Pop();
    // ADD DX,CX (1000_39D2 / 0x139D2)
    DX += CX;
    // CMP byte ptr [0x227d],0x0 (1000_39D4 / 0x139D4)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:39e5 (1000_39D9 / 0x139D9)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_39E5 / 0x139E5)
      return NearRet();
    }
    // MOV CX,0x30 (1000_39DB / 0x139DB)
    CX = 0x30;
    // MOV BX,0x2d0 (1000_39DE / 0x139DE)
    BX = 0x2D0;
    // CALLF [0x394d] (1000_39E1 / 0x139E1)
    // Indirect call to [0x394d], generating possible targets from emulator records
    uint targetAddress_1000_39E1 = (uint)(UInt16[DS, 0x394F] * 0x10 + UInt16[DS, 0x394D] - cs1 * 0x10);
    switch(targetAddress_1000_39E1) {
      case 0x23622 : FarCall(cs1, 0x39E5, spice86_generated_label_call_target_334B_0172_033622); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39E1));
        break;
    }
    label_1000_39E5_139E5:
    // RET  (1000_39E5 / 0x139E5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_39E6_0139E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_39E6_139E6:
    // MOV SI,0xc0b6 (1000_39E6 / 0x139E6)
    SI = 0xC0B6;
    // JMP 0x1000:da5f (1000_39E9 / 0x139E9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_39EC_0139EC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_39EC_139EC:
    // MOV byte ptr [0x22e3],0x1 (1000_39EC / 0x139EC)
    UInt8[DS, 0x22E3] = 0x1;
    // PUSH AX (1000_39F1 / 0x139F1)
    Stack.Push(AX);
    // CALL 0x1000:3ae9 (1000_39F2 / 0x139F2)
    NearCall(cs1, 0x39F5, spice86_generated_label_call_target_1000_3AE9_013AE9);
    label_1000_39F5_139F5:
    // MOV AX,[0x4] (1000_39F5 / 0x139F5)
    AX = UInt16[DS, 0x4];
    // CMP AX,0x2005 (1000_39F8 / 0x139F8)
    Alu.Sub16(AX, 0x2005);
    // JZ 0x1000:3a1d (1000_39FB / 0x139FB)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_3A18_013A18, 0x13A1D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AX,0x1005 (1000_39FD / 0x139FD)
    Alu.Sub16(AX, 0x1005);
    // JZ 0x1000:3a18 (1000_3A00 / 0x13A00)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_3A18_013A18, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC AL (1000_3A02 / 0x13A02)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:3a20 (1000_3A04 / 0x13A04)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A20_013A20, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AH,0x21 (1000_3A06 / 0x13A06)
    Alu.Sub8(AH, 0x21);
    // JNZ 0x1000:3a13 (1000_3A09 / 0x13A09)
    if(!ZeroFlag) {
      goto label_1000_3A13_13A13;
    }
    // POP AX (1000_3A0B / 0x13A0B)
    AX = Stack.Pop();
    // MOV DI,word ptr [0x114e] (1000_3A0C / 0x13A0C)
    DI = UInt16[DS, 0x114E];
    // MOV AL,byte ptr [DI] (1000_3A10 / 0x13A10)
    AL = UInt8[DS, DI];
    // PUSH AX (1000_3A12 / 0x13A12)
    Stack.Push(AX);
    label_1000_3A13_13A13:
    // CALL 0x1000:37eb (1000_3A13 / 0x13A13)
    NearCall(cs1, 0x3A16, spice86_generated_label_call_target_1000_37EB_0137EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A16_013A16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3A16_013A16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3A16_13A16:
    // JMP 0x1000:3a20 (1000_3A16 / 0x13A16)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A20_013A20, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_3A18_013A18(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3A1D: goto label_1000_3A1D_13A1D;break; // Target of external jump from 0x139FB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_3A18_13A18:
    // MOV byte ptr [0x22e3],0x0 (1000_3A18 / 0x13A18)
    UInt8[DS, 0x22E3] = 0x0;
    label_1000_3A1D_13A1D:
    // CALL 0x1000:38b4 (1000_3A1D / 0x13A1D)
    NearCall(cs1, 0x3A20, spice86_generated_label_call_target_1000_38B4_0138B4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A20_013A20, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3A20_013A20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3A20_13A20:
    // POP AX (1000_3A20 / 0x13A20)
    AX = Stack.Pop();
    // CALL 0x1000:3b59 (1000_3A21 / 0x13A21)
    NearCall(cs1, 0x3A24, spice86_generated_label_call_target_1000_3B59_013B59);
    label_1000_3A24_13A24:
    // CMP byte ptr [0x46df],0x0 (1000_3A24 / 0x13A24)
    Alu.Sub8(UInt8[DS, 0x46DF], 0x0);
    // JZ 0x1000:3a7c (1000_3A29 / 0x13A29)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3A7C_013A7C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x4],0x1 (1000_3A2B / 0x13A2B)
    Alu.Sub8(UInt8[DS, 0x4], 0x1);
    // JNZ 0x1000:3a7c (1000_3A30 / 0x13A30)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3A7C_013A7C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x4731],0xff (1000_3A32 / 0x13A32)
    Alu.Sub8(UInt8[DS, 0x4731], 0xFF);
    // JZ 0x1000:3a7b (1000_3A37 / 0x13A37)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_3A7B / 0x13A7B)
      return NearRet();
    }
    // MOV CL,byte ptr [0x46ff] (1000_3A39 / 0x13A39)
    CL = UInt8[DS, 0x46FF];
    // XOR CH,CH (1000_3A3D / 0x13A3D)
    CH = 0;
    // JCXZ 0x1000:3a7b (1000_3A3F / 0x13A3F)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_3A7B / 0x13A7B)
      return NearRet();
    }
    // MOV AX,0x388d (1000_3A41 / 0x13A41)
    AX = 0x388D;
    // PUSH AX (1000_3A44 / 0x13A44)
    Stack.Push(AX);
    // MOV byte ptr [0x4731],0x0 (1000_3A45 / 0x13A45)
    UInt8[DS, 0x4731] = 0x0;
    // TEST byte ptr [0x47a4],0x81 (1000_3A4A / 0x13A4A)
    Alu.And8(UInt8[DS, 0x47A4], 0x81);
    // JNZ 0x1000:3a7b (1000_3A4F / 0x13A4F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_3A7B / 0x13A7B)
      return NearRet();
    }
    // MOV AX,0x33 (1000_3A51 / 0x13A51)
    AX = 0x33;
    // CALL 0x1000:c13e (1000_3A54 / 0x13A54)
    NearCall(cs1, 0x3A57, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_3A57_13A57:
    // CALL 0x1000:3a95 (1000_3A57 / 0x13A57)
    NearCall(cs1, 0x3A5A, spice86_generated_label_call_target_1000_3A95_013A95);
    label_1000_3A5A_13A5A:
    // MOV AX,DX (1000_3A5A / 0x13A5A)
    AX = DX;
    // ADD AX,0xc (1000_3A5C / 0x13A5C)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    // MOV [0x472d],AX (1000_3A5F / 0x13A5F)
    UInt16[DS, 0x472D] = AX;
    // MOV AX,BX (1000_3A62 / 0x13A62)
    AX = BX;
    // ADD AX,0x8 (1000_3A64 / 0x13A64)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    // MOV [0x472f],AX (1000_3A67 / 0x13A67)
    UInt16[DS, 0x472F] = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_3A6A_013A6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_3A6A_013A6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3A6A_13A6A:
    // PUSH CX (1000_3A6A / 0x13A6A)
    Stack.Push(CX);
    // PUSH BX (1000_3A6B / 0x13A6B)
    Stack.Push(BX);
    // PUSH DX (1000_3A6C / 0x13A6C)
    Stack.Push(DX);
    // CALL 0x1000:3aa9 (1000_3A6D / 0x13A6D)
    NearCall(cs1, 0x3A70, spice86_generated_label_call_target_1000_3AA9_013AA9);
    label_1000_3A70_13A70:
    // POP DX (1000_3A70 / 0x13A70)
    DX = Stack.Pop();
    // POP BX (1000_3A71 / 0x13A71)
    BX = Stack.Pop();
    // POP CX (1000_3A72 / 0x13A72)
    CX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3A73_013A73, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3A73_013A73(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3A7B: goto label_1000_3A7B_13A7B;break; // Target of external jump from 0x13A37
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_3A73_13A73:
    // ADD DX,0x46 (1000_3A73 / 0x13A73)
    DX += 0x46;
    // ADD BX,0xa (1000_3A76 / 0x13A76)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    // LOOP 0x1000:3a6a (1000_3A79 / 0x13A79)
    if(--CX != 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_3A6A_013A6A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_3A7B_13A7B:
    // RET  (1000_3A7B / 0x13A7B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3A7C_013A7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3A7C_13A7C:
    // CALL 0x1000:39e6 (1000_3A7C / 0x13A7C)
    NearCall(cs1, 0x3A7F, spice86_generated_label_call_target_1000_39E6_0139E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A7F_013A7F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3A7F_013A7F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3A7F_13A7F:
    // MOV AX,[0x4] (1000_3A7F / 0x13A7F)
    AX = UInt16[DS, 0x4];
    // CMP AL,0x4 (1000_3A82 / 0x13A82)
    Alu.Sub8(AL, 0x4);
    // JNZ 0x1000:3a94 (1000_3A84 / 0x13A84)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_3A94 / 0x13A94)
      return NearRet();
    }
    // CMP AH,0x20 (1000_3A86 / 0x13A86)
    Alu.Sub8(AH, 0x20);
    // JNC 0x1000:3a94 (1000_3A89 / 0x13A89)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_3A94 / 0x13A94)
      return NearRet();
    }
    // MOV SI,0xc0b6 (1000_3A8B / 0x13A8B)
    SI = 0xC0B6;
    // MOV BP,0xc (1000_3A8E / 0x13A8E)
    BP = 0xC;
    // CALL 0x1000:da25 (1000_3A91 / 0x13A91)
    NearCall(cs1, 0x3A94, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_3A94_13A94:
    // RET  (1000_3A94 / 0x13A94)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3A95_013A95(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3A95_13A95:
    // MOV DX,0x95 (1000_3A95 / 0x13A95)
    DX = 0x95;
    // MOV BX,0x39 (1000_3A98 / 0x13A98)
    BX = 0x39;
    // CMP byte ptr [0x5],0x20 (1000_3A9B / 0x13A9B)
    Alu.Sub8(UInt8[DS, 0x5], 0x20);
    // JC 0x1000:3aa8 (1000_3AA0 / 0x13AA0)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_3AA8 / 0x13AA8)
      return NearRet();
    }
    // MOV DX,0xca (1000_3AA2 / 0x13AA2)
    DX = 0xCA;
    // MOV BX,0x49 (1000_3AA5 / 0x13AA5)
    BX = 0x49;
    label_1000_3AA8_13AA8:
    // RET  (1000_3AA8 / 0x13AA8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3AA9_013AA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3AA9_13AA9:
    // XOR AX,AX (1000_3AA9 / 0x13AA9)
    AX = 0;
    // CALL 0x1000:c305 (1000_3AAB / 0x13AAB)
    NearCall(cs1, 0x3AAE, spice86_generated_label_call_target_1000_C305_01C305);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3AAE_013AAE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3AAE_013AAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3AAE_13AAE:
    // ADD DX,0x6 (1000_3AAE / 0x13AAE)
    DX += 0x6;
    // ADD BX,0x1e (1000_3AB1 / 0x13AB1)
    // BX += 0x1E;
    BX = Alu.Add16(BX, 0x1E);
    // MOV AX,0x1 (1000_3AB4 / 0x13AB4)
    AX = 0x1;
    // CALL 0x1000:c305 (1000_3AB7 / 0x13AB7)
    NearCall(cs1, 0x3ABA, spice86_generated_label_call_target_1000_C305_01C305);
    label_1000_3ABA_13ABA:
    // SUB DX,0x2 (1000_3ABA / 0x13ABA)
    DX -= 0x2;
    // ADD BX,0x14 (1000_3ABD / 0x13ABD)
    // BX += 0x14;
    BX = Alu.Add16(BX, 0x14);
    // MOV AL,[0x4731] (1000_3AC0 / 0x13AC0)
    AL = UInt8[DS, 0x4731];
    // XOR AH,AH (1000_3AC3 / 0x13AC3)
    AH = 0;
    // PUSH AX (1000_3AC5 / 0x13AC5)
    Stack.Push(AX);
    // SUB AL,0xf (1000_3AC6 / 0x13AC6)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    // JNC 0x1000:3acc (1000_3AC8 / 0x13AC8)
    if(!CarryFlag) {
      goto label_1000_3ACC_13ACC;
    }
    // XOR AX,AX (1000_3ACA / 0x13ACA)
    AX = 0;
    label_1000_3ACC_13ACC:
    // CMP AL,0x5 (1000_3ACC / 0x13ACC)
    Alu.Sub8(AL, 0x5);
    // JBE 0x1000:3ad2 (1000_3ACE / 0x13ACE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_3AD2_13AD2;
    }
    // MOV AL,0x5 (1000_3AD0 / 0x13AD0)
    AL = 0x5;
    label_1000_3AD2_13AD2:
    // ADD AL,0x2 (1000_3AD2 / 0x13AD2)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    // CALL 0x1000:c305 (1000_3AD4 / 0x13AD4)
    NearCall(cs1, 0x3AD7, spice86_generated_label_call_target_1000_C305_01C305);
    label_1000_3AD7_13AD7:
    // SUB DX,0x55 (1000_3AD7 / 0x13AD7)
    DX -= 0x55;
    // SUB BX,0x35 (1000_3ADA / 0x13ADA)
    // BX -= 0x35;
    BX = Alu.Sub16(BX, 0x35);
    // POP AX (1000_3ADD / 0x13ADD)
    AX = Stack.Pop();
    // CMP AL,0xe (1000_3ADE / 0x13ADE)
    Alu.Sub8(AL, 0xE);
    // JC 0x1000:3ae4 (1000_3AE0 / 0x13AE0)
    if(CarryFlag) {
      goto label_1000_3AE4_13AE4;
    }
    // MOV AL,0xe (1000_3AE2 / 0x13AE2)
    AL = 0xE;
    label_1000_3AE4_13AE4:
    // ADD AL,0x8 (1000_3AE4 / 0x13AE4)
    // AL += 0x8;
    AL = Alu.Add8(AL, 0x8);
    // JMP 0x1000:c30d (1000_3AE6 / 0x13AE6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C30D_01C30D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3AE9_013AE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3AE9_13AE9:
    // PUSH AX (1000_3AE9 / 0x13AE9)
    Stack.Push(AX);
    // PUSH DS (1000_3AEA / 0x13AEA)
    Stack.Push(DS);
    // POP ES (1000_3AEB / 0x13AEB)
    ES = Stack.Pop();
    // MOV CX,0x2e (1000_3AEC / 0x13AEC)
    CX = 0x2E;
    // MOV AX,0xffff (1000_3AEF / 0x13AEF)
    AX = 0xFFFF;
    // MOV DI,0x47f8 (1000_3AF2 / 0x13AF2)
    DI = 0x47F8;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_3AF5 / 0x13AF5)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // POP AX (1000_3AF7 / 0x13AF7)
    AX = Stack.Pop();
    // RET  (1000_3AF8 / 0x13AF8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3AF9_013AF9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3AF9_13AF9:
    // CMP byte ptr [0x2b],0x0 (1000_3AF9 / 0x13AF9)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:3b03 (1000_3AFE / 0x13AFE)
    if(ZeroFlag) {
      goto label_1000_3B03_13B03;
    }
    // JMP 0x1000:c43e (1000_3B00 / 0x13B00)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C43E_01C43E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_3B03_13B03:
    // CMP byte ptr [0x47a4],0x0 (1000_3B03 / 0x13B03)
    Alu.Sub8(UInt8[DS, 0x47A4], 0x0);
    // JS 0x1000:3b58 (1000_3B08 / 0x13B08)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_3B58 / 0x13B58)
      return NearRet();
    }
    // MOV AX,[0x47c4] (1000_3B0A / 0x13B0A)
    AX = UInt16[DS, 0x47C4];
    // CMP AL,0xf (1000_3B0D / 0x13B0D)
    Alu.Sub8(AL, 0xF);
    // JNZ 0x1000:3b15 (1000_3B0F / 0x13B0F)
    if(!ZeroFlag) {
      goto label_1000_3B15_13B15;
    }
    // ADD AL,byte ptr [0x476c] (1000_3B11 / 0x13B11)
    // AL += UInt8[DS, 0x476C];
    AL = Alu.Add8(AL, UInt8[DS, 0x476C]);
    label_1000_3B15_13B15:
    // MOV DI,AX (1000_3B15 / 0x13B15)
    DI = AX;
    // SHL DI,1 (1000_3B17 / 0x13B17)
    DI <<= 0x1;
    // SHL DI,1 (1000_3B19 / 0x13B19)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    // MOV DX,word ptr [DI + 0x47f8] (1000_3B1B / 0x13B1B)
    DX = UInt16[DS, (ushort)(DI + 0x47F8)];
    // OR DX,DX (1000_3B1F / 0x13B1F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JS 0x1000:3b58 (1000_3B21 / 0x13B21)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_3B58 / 0x13B58)
      return NearRet();
    }
    // PUSH word ptr [DI + 0x47fa] (1000_3B23 / 0x13B23)
    Stack.Push(UInt16[DS, (ushort)(DI + 0x47FA)]);
    // PUSH DX (1000_3B27 / 0x13B27)
    Stack.Push(DX);
    // OR byte ptr [0x47a4],0x80 (1000_3B28 / 0x13B28)
    // UInt8[DS, 0x47A4] |= 0x80;
    UInt8[DS, 0x47A4] = Alu.Or8(UInt8[DS, 0x47A4], 0x80);
    // CALL 0x1000:37b5 (1000_3B2D / 0x13B2D)
    NearCall(cs1, 0x3B30, spice86_generated_label_ret_target_1000_37B5_0137B5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B30_013B30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3B30_013B30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3B30_13B30:
    // POP DX (1000_3B30 / 0x13B30)
    DX = Stack.Pop();
    // POP BX (1000_3B31 / 0x13B31)
    BX = Stack.Pop();
    // CMP DX,0xf0 (1000_3B32 / 0x13B32)
    Alu.Sub16(DX, 0xF0);
    // JC 0x1000:3b3b (1000_3B36 / 0x13B36)
    if(CarryFlag) {
      goto label_1000_3B3B_13B3B;
    }
    // MOV DX,0xf0 (1000_3B38 / 0x13B38)
    DX = 0xF0;
    label_1000_3B3B_13B3B:
    // CMP BX,0x71 (1000_3B3B / 0x13B3B)
    Alu.Sub16(BX, 0x71);
    // JC 0x1000:3b43 (1000_3B3E / 0x13B3E)
    if(CarryFlag) {
      goto label_1000_3B43_13B43;
    }
    // MOV BX,0x71 (1000_3B40 / 0x13B40)
    BX = 0x71;
    label_1000_3B43_13B43:
    // MOV ES,word ptr [0xdbde] (1000_3B43 / 0x13B43)
    ES = UInt16[DS, 0xDBDE];
    // PUSH DS (1000_3B47 / 0x13B47)
    Stack.Push(DS);
    // MOV DS,word ptr [0xdbda] (1000_3B48 / 0x13B48)
    DS = UInt16[DS, 0xDBDA];
    // MOV BP,0x6 (1000_3B4C / 0x13B4C)
    BP = 0x6;
    // CALLF [0x3949] (1000_3B4F / 0x13B4F)
    // Indirect call to [0x3949], generating possible targets from emulator records
    uint targetAddress_1000_3B4F = (uint)(UInt16[SS, 0x394B] * 0x10 + UInt16[SS, 0x3949] - cs1 * 0x10);
    switch(targetAddress_1000_3B4F) {
      case 0x2361F : FarCall(cs1, 0x3B54, spice86_generated_label_call_target_334B_016F_03361F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3B4F));
        break;
    }
    label_1000_3B54_13B54:
    // POP DS (1000_3B54 / 0x13B54)
    DS = Stack.Pop();
    // JMP 0x1000:c43e (1000_3B55 / 0x13B55)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C43E_01C43E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3B58_013B58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3B58_13B58:
    // RET  (1000_3B58 / 0x13B58)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3B59_013B59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3B59_13B59:
    // SUB SP,0x18 (1000_3B59 / 0x13B59)
    // SP -= 0x18;
    SP = Alu.Sub16(SP, 0x18);
    // MOV word ptr [0x47f6],SP (1000_3B5C / 0x13B5C)
    UInt16[DS, 0x47F6] = SP;
    // XOR AH,AH (1000_3B60 / 0x13B60)
    AH = 0;
    // DEC AX (1000_3B62 / 0x13B62)
    AX = Alu.Dec16(AX);
    // PUSH AX (1000_3B63 / 0x13B63)
    Stack.Push(AX);
    // MOV CL,0x4 (1000_3B64 / 0x13B64)
    CL = 0x4;
    // SHR AX,CL (1000_3B66 / 0x13B66)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // JZ 0x1000:3b70 (1000_3B68 / 0x13B68)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B70_013B70, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD AX,0x13 (1000_3B6A / 0x13B6A)
    // AX += 0x13;
    AX = Alu.Add16(AX, 0x13);
    // CALL 0x1000:c13e (1000_3B6D / 0x13B6D)
    NearCall(cs1, 0x3B70, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B70_013B70, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3B70_013B70(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3B70_13B70:
    // POP AX (1000_3B70 / 0x13B70)
    AX = Stack.Pop();
    // AND AX,0xf (1000_3B71 / 0x13B71)
    AX &= 0xF;
    // SHL AX,1 (1000_3B74 / 0x13B74)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV SI,0xbc6e (1000_3B76 / 0x13B76)
    SI = 0xBC6E;
    // ADD SI,AX (1000_3B79 / 0x13B79)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV SI,word ptr [SI] (1000_3B7B / 0x13B7B)
    SI = UInt16[DS, SI];
    // CALL 0x1000:3d83 (1000_3B7D / 0x13B7D)
    NearCall(cs1, 0x3B80, spice86_generated_label_call_target_1000_3D83_013D83);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B80_013B80, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3B80_013B80(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3B80_13B80:
    // LODSW SI (1000_3B80 / 0x13B80)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,0xffff (1000_3B81 / 0x13B81)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:3bb5 (1000_3B84 / 0x13B84)
    if(ZeroFlag) {
      goto label_1000_3BB5_13BB5;
    }
    // JS 0x1000:3bbf (1000_3B86 / 0x13B86)
    if(SignFlag) {
      goto label_1000_3BBF_13BBF;
    }
    // MOV DI,AX (1000_3B88 / 0x13B88)
    DI = AX;
    // SHR AH,1 (1000_3B8A / 0x13B8A)
    AH >>= 0x1;
    // AND AH,0x1 (1000_3B8C / 0x13B8C)
    // AH &= 0x1;
    AH = Alu.And8(AH, 0x1);
    // LODSB SI (1000_3B8F / 0x13B8F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV DX,AX (1000_3B90 / 0x13B90)
    DX = AX;
    // LODSB SI (1000_3B92 / 0x13B92)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_3B93 / 0x13B93)
    AH = 0;
    // MOV BX,AX (1000_3B95 / 0x13B95)
    BX = AX;
    // LODSB SI (1000_3B97 / 0x13B97)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // PUSH SI (1000_3B98 / 0x13B98)
    Stack.Push(SI);
    // MOV CS:[0xc21a],AL (1000_3B99 / 0x13B99)
    UInt8[cs1, 0xC21A] = AL;
    // MOV AX,DI (1000_3B9D / 0x13B9D)
    AX = DI;
    // AND AX,0xfdff (1000_3B9F / 0x13B9F)
    AX &= 0xFDFF;
    // DEC AX (1000_3BA2 / 0x13BA2)
    AX--;
    // AND DI,0x1ff (1000_3BA3 / 0x13BA3)
    DI &= 0x1FF;
    // CMP DI,0x1 (1000_3BA7 / 0x13BA7)
    Alu.Sub16(DI, 0x1);
    // JNZ 0x1000:3baf (1000_3BAA / 0x13BAA)
    if(!ZeroFlag) {
      goto label_1000_3BAF_13BAF;
    }
    // JMP 0x1000:3d12 (1000_3BAC / 0x13BAC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3D12_013D12, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_3BAF_13BAF:
    // CALL 0x1000:c22f (1000_3BAF / 0x13BAF)
    NearCall(cs1, 0x3BB2, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_3BB2_13BB2:
    // POP SI (1000_3BB2 / 0x13BB2)
    SI = Stack.Pop();
    // JMP 0x1000:3b80 (1000_3BB3 / 0x13BB3)
    goto label_1000_3B80_13B80;
    label_1000_3BB5_13BB5:
    // MOV byte ptr CS:[0xc21a],0x0 (1000_3BB5 / 0x13BB5)
    UInt8[cs1, 0xC21A] = 0x0;
    // ADD SP,0x18 (1000_3BBB / 0x13BBB)
    // SP += 0x18;
    SP = Alu.Add16(SP, 0x18);
    // RET  (1000_3BBE / 0x13BBE)
    return NearRet();
    label_1000_3BBF_13BBF:
    // CMP AH,0xc0 (1000_3BBF / 0x13BBF)
    Alu.Sub8(AH, 0xC0);
    // JZ 0x1000:3bc9 (1000_3BC2 / 0x13BC2)
    if(ZeroFlag) {
      goto label_1000_3BC9_13BC9;
    }
    // CALL 0x1000:3be9 (1000_3BC4 / 0x13BC4)
    NearCall(cs1, 0x3BC7, spice86_generated_label_call_target_1000_3BE9_013BE9);
    label_1000_3BC7_13BC7:
    // JMP 0x1000:3b80 (1000_3BC7 / 0x13BC7)
    goto label_1000_3B80_13B80;
    label_1000_3BC9_13BC9:
    // PUSH AX (1000_3BC9 / 0x13BC9)
    Stack.Push(AX);
    // MOV ES,word ptr [0xdbda] (1000_3BCA / 0x13BCA)
    ES = UInt16[DS, 0xDBDA];
    // LODSW SI (1000_3BCE / 0x13BCE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_3BCF / 0x13BCF)
    DX = AX;
    // LODSW SI (1000_3BD1 / 0x13BD1)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_3BD2 / 0x13BD2)
    BX = AX;
    // LODSW SI (1000_3BD4 / 0x13BD4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_3BD5 / 0x13BD5)
    DI = AX;
    // LODSW SI (1000_3BD7 / 0x13BD7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_3BD8 / 0x13BD8)
    CX = AX;
    // POP AX (1000_3BDA / 0x13BDA)
    AX = Stack.Pop();
    // PUSH SI (1000_3BDB / 0x13BDB)
    Stack.Push(SI);
    // MOV BP,0xffff (1000_3BDC / 0x13BDC)
    BP = 0xFFFF;
    // MOV SI,0x1470 (1000_3BDF / 0x13BDF)
    SI = 0x1470;
    // CALLF [0x3901] (1000_3BE2 / 0x13BE2)
    // Indirect call to [0x3901], generating possible targets from emulator records
    uint targetAddress_1000_3BE2 = (uint)(UInt16[DS, 0x3903] * 0x10 + UInt16[DS, 0x3901] - cs1 * 0x10);
    switch(targetAddress_1000_3BE2) {
      case 0x235E9 : FarCall(cs1, 0x3BE6, spice86_generated_label_call_target_334B_0139_0335E9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3BE2));
        break;
    }
    label_1000_3BE6_13BE6:
    // POP SI (1000_3BE6 / 0x13BE6)
    SI = Stack.Pop();
    // JMP 0x1000:3b80 (1000_3BE7 / 0x13BE7)
    goto label_1000_3B80_13B80;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3BE9_013BE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3BE9_13BE9:
    // MOV word ptr [0x22d9],0x4c60 (1000_3BE9 / 0x13BE9)
    UInt16[DS, 0x22D9] = 0x4C60;
    // PUSH DS (1000_3BEF / 0x13BEF)
    Stack.Push(DS);
    // POP ES (1000_3BF0 / 0x13BF0)
    ES = Stack.Pop();
    // MOV AL,byte ptr [SI + -0x2] (1000_3BF1 / 0x13BF1)
    AL = UInt8[DS, (ushort)(SI - 0x2)];
    // MOV [0x47ed],AL (1000_3BF4 / 0x13BF4)
    UInt8[DS, 0x47ED] = AL;
    // MOV AL,byte ptr [SI + -0x1] (1000_3BF7 / 0x13BF7)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    // MOV [0x47ec],AL (1000_3BFA / 0x13BFA)
    UInt8[DS, 0x47EC] = AL;
    // LODSB SI (1000_3BFD / 0x13BFD)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_3BFE / 0x13BFE)
    AX = (ushort)((short)((sbyte)AL));
    // SHL AX,1 (1000_3BFF / 0x13BFF)
    AX <<= 0x1;
    // SHL AX,1 (1000_3C01 / 0x13C01)
    AX <<= 0x1;
    // SHL AX,1 (1000_3C03 / 0x13C03)
    AX <<= 0x1;
    // SHL AX,1 (1000_3C05 / 0x13C05)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV [0x22db],AX (1000_3C07 / 0x13C07)
    UInt16[DS, 0x22DB] = AX;
    // LODSB SI (1000_3C0A / 0x13C0A)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_3C0B / 0x13C0B)
    AX = (ushort)((short)((sbyte)AL));
    // SHL AX,1 (1000_3C0C / 0x13C0C)
    AX <<= 0x1;
    // SHL AX,1 (1000_3C0E / 0x13C0E)
    AX <<= 0x1;
    // SHL AX,1 (1000_3C10 / 0x13C10)
    AX <<= 0x1;
    // SHL AX,1 (1000_3C12 / 0x13C12)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV [0x22dd],AX (1000_3C14 / 0x13C14)
    UInt16[DS, 0x22DD] = AX;
    // LODSW SI (1000_3C17 / 0x13C17)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_3C18 / 0x13C18)
    DX = AX;
    // LODSW SI (1000_3C1A / 0x13C1A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_3C1B / 0x13C1B)
    BX = AX;
    // MOV word ptr [0x47ee],DX (1000_3C1D / 0x13C1D)
    UInt16[DS, 0x47EE] = DX;
    // MOV word ptr [0x47f0],BX (1000_3C21 / 0x13C21)
    UInt16[DS, 0x47F0] = BX;
    label_1000_3C25_13C25:
    // LODSW SI (1000_3C25 / 0x13C25)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // PUSH AX (1000_3C26 / 0x13C26)
    Stack.Push(AX);
    // AND AX,0x3fff (1000_3C27 / 0x13C27)
    // AX &= 0x3FFF;
    AX = Alu.And16(AX, 0x3FFF);
    // MOV DI,AX (1000_3C2A / 0x13C2A)
    DI = AX;
    // LODSW SI (1000_3C2C / 0x13C2C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_3C2D / 0x13C2D)
    CX = AX;
    // CALL 0x1000:3e13 (1000_3C2F / 0x13C2F)
    NearCall(cs1, 0x3C32, spice86_generated_label_call_target_1000_3E13_013E13);
    label_1000_3C32_13C32:
    // MOV DX,DI (1000_3C32 / 0x13C32)
    DX = DI;
    // MOV BX,CX (1000_3C34 / 0x13C34)
    BX = CX;
    // POP AX (1000_3C36 / 0x13C36)
    AX = Stack.Pop();
    // TEST AX,0x4000 (1000_3C37 / 0x13C37)
    Alu.And16(AX, 0x4000);
    // JZ 0x1000:3c25 (1000_3C3A / 0x13C3A)
    if(ZeroFlag) {
      goto label_1000_3C25_13C25;
    }
    // MOV word ptr [0x47f2],DI (1000_3C3C / 0x13C3C)
    UInt16[DS, 0x47F2] = DI;
    // MOV word ptr [0x47f4],CX (1000_3C40 / 0x13C40)
    UInt16[DS, 0x47F4] = CX;
    // MOV DX,word ptr [0x47ee] (1000_3C44 / 0x13C44)
    DX = UInt16[DS, 0x47EE];
    // MOV BX,word ptr [0x47f0] (1000_3C48 / 0x13C48)
    BX = UInt16[DS, 0x47F0];
    // MOV word ptr [0x22d9],0x4c62 (1000_3C4C / 0x13C4C)
    UInt16[DS, 0x22D9] = 0x4C62;
    // TEST AX,0x8000 (1000_3C52 / 0x13C52)
    Alu.And16(AX, 0x8000);
    // JNZ 0x1000:3c71 (1000_3C55 / 0x13C55)
    if(!ZeroFlag) {
      goto label_1000_3C71_13C71;
    }
    label_1000_3C57_13C57:
    // LODSW SI (1000_3C57 / 0x13C57)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // PUSH AX (1000_3C58 / 0x13C58)
    Stack.Push(AX);
    // AND AX,0x3fff (1000_3C59 / 0x13C59)
    // AX &= 0x3FFF;
    AX = Alu.And16(AX, 0x3FFF);
    // MOV DI,AX (1000_3C5C / 0x13C5C)
    DI = AX;
    // LODSW SI (1000_3C5E / 0x13C5E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_3C5F / 0x13C5F)
    CX = AX;
    // CALL 0x1000:3e13 (1000_3C61 / 0x13C61)
    NearCall(cs1, 0x3C64, spice86_generated_label_call_target_1000_3E13_013E13);
    label_1000_3C64_13C64:
    // MOV DX,DI (1000_3C64 / 0x13C64)
    DX = DI;
    // MOV BX,CX (1000_3C66 / 0x13C66)
    BX = CX;
    // POP AX (1000_3C68 / 0x13C68)
    AX = Stack.Pop();
    // OR AX,AX (1000_3C69 / 0x13C69)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:3c57 (1000_3C6B / 0x13C6B)
    if(!SignFlag) {
      goto label_1000_3C57_13C57;
    }
    // MOV DX,DI (1000_3C6D / 0x13C6D)
    DX = DI;
    // MOV BX,CX (1000_3C6F / 0x13C6F)
    BX = CX;
    label_1000_3C71_13C71:
    // MOV DI,word ptr [0x47f2] (1000_3C71 / 0x13C71)
    DI = UInt16[DS, 0x47F2];
    // MOV CX,word ptr [0x47f4] (1000_3C75 / 0x13C75)
    CX = UInt16[DS, 0x47F4];
    // CALL 0x1000:3e13 (1000_3C79 / 0x13C79)
    NearCall(cs1, 0x3C7C, spice86_generated_label_call_target_1000_3E13_013E13);
    label_1000_3C7C_13C7C:
    // MOV ES,word ptr [0xdbda] (1000_3C7C / 0x13C7C)
    ES = UInt16[DS, 0xDBDA];
    // PUSH SI (1000_3C80 / 0x13C80)
    Stack.Push(SI);
    // MOV BX,word ptr [0x47f0] (1000_3C81 / 0x13C81)
    BX = UInt16[DS, 0x47F0];
    // MOV BP,word ptr [0x47f4] (1000_3C85 / 0x13C85)
    BP = UInt16[DS, 0x47F4];
    // SUB BP,BX (1000_3C89 / 0x13C89)
    // BP -= BX;
    BP = Alu.Sub16(BP, BX);
    // LEA SI,[0x4c60] (1000_3C8B / 0x13C8B)
    SI = 0x4C60;
    // MOV CX,BP (1000_3C8F / 0x13C8F)
    CX = BP;
    // MOV BP,0x0 (1000_3C91 / 0x13C91)
    BP = 0x0;
    // MOV AH,byte ptr [0x47ec] (1000_3C94 / 0x13C94)
    AH = UInt8[DS, 0x47EC];
    // AND AH,0x3e (1000_3C98 / 0x13C98)
    // AH &= 0x3E;
    AH = Alu.And8(AH, 0x3E);
    // JZ 0x1000:3ca0 (1000_3C9B / 0x13C9B)
    if(ZeroFlag) {
      goto label_1000_3CA0_13CA0;
    }
    // MOV BP,0x1 (1000_3C9D / 0x13C9D)
    BP = 0x1;
    label_1000_3CA0_13CA0:
    // MOV AL,0x2 (1000_3CA0 / 0x13CA0)
    AL = 0x2;
    // MOV [0x22df],AX (1000_3CA2 / 0x13CA2)
    UInt16[DS, 0x22DF] = AX;
    // MOV AH,byte ptr [0x47ed] (1000_3CA5 / 0x13CA5)
    AH = UInt8[DS, 0x47ED];
    // XOR AL,AL (1000_3CA9 / 0x13CA9)
    AL = 0;
    // TEST byte ptr [0x47ec],0x1 (1000_3CAB / 0x13CAB)
    Alu.And8(UInt8[DS, 0x47EC], 0x1);
    // JNZ 0x1000:3ce0 (1000_3CB0 / 0x13CB0)
    if(!ZeroFlag) {
      goto label_1000_3CE0_13CE0;
    }
    label_1000_3CB2_13CB2:
    // PUSH CX (1000_3CB2 / 0x13CB2)
    Stack.Push(CX);
    // PUSH AX (1000_3CB3 / 0x13CB3)
    Stack.Push(AX);
    // LODSW SI (1000_3CB4 / 0x13CB4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_3CB5 / 0x13CB5)
    DX = AX;
    // LODSW SI (1000_3CB7 / 0x13CB7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_3CB8 / 0x13CB8)
    CX = AX;
    // POP AX (1000_3CBA / 0x13CBA)
    AX = Stack.Pop();
    // CMP DX,CX (1000_3CBB / 0x13CBB)
    Alu.Sub16(DX, CX);
    // JC 0x1000:3cc1 (1000_3CBD / 0x13CBD)
    if(CarryFlag) {
      goto label_1000_3CC1_13CC1;
    }
    // XCHG CX,DX (1000_3CBF / 0x13CBF)
    ushort tmp_1000_3CBF = CX;
    CX = DX;
    DX = tmp_1000_3CBF;
    label_1000_3CC1_13CC1:
    // INC CX (1000_3CC1 / 0x13CC1)
    CX++;
    // SUB CX,DX (1000_3CC2 / 0x13CC2)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // JZ 0x1000:3cd6 (1000_3CC4 / 0x13CC4)
    if(ZeroFlag) {
      goto label_1000_3CD6_13CD6;
    }
    // PUSH SI (1000_3CC6 / 0x13CC6)
    Stack.Push(SI);
    // PUSH BX (1000_3CC7 / 0x13CC7)
    Stack.Push(BX);
    // MOV SI,word ptr [0x22df] (1000_3CC8 / 0x13CC8)
    SI = UInt16[DS, 0x22DF];
    // MOV DI,word ptr [0x22db] (1000_3CCC / 0x13CCC)
    DI = UInt16[DS, 0x22DB];
    // CALLF [0x3945] (1000_3CD0 / 0x13CD0)
    // Indirect call to [0x3945], generating possible targets from emulator records
    uint targetAddress_1000_3CD0 = (uint)(UInt16[DS, 0x3947] * 0x10 + UInt16[DS, 0x3945] - cs1 * 0x10);
    switch(targetAddress_1000_3CD0) {
      case 0x2361C : FarCall(cs1, 0x3CD4, spice86_generated_label_call_target_334B_016C_03361C); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3CD0));
        break;
    }
    label_1000_3CD4_13CD4:
    // POP BX (1000_3CD4 / 0x13CD4)
    BX = Stack.Pop();
    // POP SI (1000_3CD5 / 0x13CD5)
    SI = Stack.Pop();
    label_1000_3CD6_13CD6:
    // ADD AX,word ptr [0x22dd] (1000_3CD6 / 0x13CD6)
    AX += UInt16[DS, 0x22DD];
    // INC BX (1000_3CDA / 0x13CDA)
    BX = Alu.Inc16(BX);
    // POP CX (1000_3CDB / 0x13CDB)
    CX = Stack.Pop();
    // LOOP 0x1000:3cb2 (1000_3CDC / 0x13CDC)
    if(--CX != 0) {
      goto label_1000_3CB2_13CB2;
    }
    // POP SI (1000_3CDE / 0x13CDE)
    SI = Stack.Pop();
    // RET  (1000_3CDF / 0x13CDF)
    return NearRet();
    label_1000_3CE0_13CE0:
    // PUSH CX (1000_3CE0 / 0x13CE0)
    Stack.Push(CX);
    // PUSH AX (1000_3CE1 / 0x13CE1)
    Stack.Push(AX);
    // LODSW SI (1000_3CE2 / 0x13CE2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_3CE3 / 0x13CE3)
    DX = AX;
    // LODSW SI (1000_3CE5 / 0x13CE5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_3CE6 / 0x13CE6)
    CX = AX;
    // POP AX (1000_3CE8 / 0x13CE8)
    AX = Stack.Pop();
    // CMP DX,CX (1000_3CE9 / 0x13CE9)
    Alu.Sub16(DX, CX);
    // JNC 0x1000:3cef (1000_3CEB / 0x13CEB)
    if(!CarryFlag) {
      goto label_1000_3CEF_13CEF;
    }
    // XCHG CX,DX (1000_3CED / 0x13CED)
    ushort tmp_1000_3CED = CX;
    CX = DX;
    DX = tmp_1000_3CED;
    label_1000_3CEF_13CEF:
    // DEC CX (1000_3CEF / 0x13CEF)
    CX--;
    // SUB CX,DX (1000_3CF0 / 0x13CF0)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // JZ 0x1000:3d08 (1000_3CF2 / 0x13CF2)
    if(ZeroFlag) {
      goto label_1000_3D08_13D08;
    }
    // NEG CX (1000_3CF4 / 0x13CF4)
    CX = Alu.Sub16(0, CX);
    // PUSH SI (1000_3CF6 / 0x13CF6)
    Stack.Push(SI);
    // PUSH BX (1000_3CF7 / 0x13CF7)
    Stack.Push(BX);
    // MOV SI,word ptr [0x22df] (1000_3CF8 / 0x13CF8)
    SI = UInt16[DS, 0x22DF];
    // MOV DI,word ptr [0x22db] (1000_3CFC / 0x13CFC)
    DI = UInt16[DS, 0x22DB];
    // STD  (1000_3D00 / 0x13D00)
    DirectionFlag = true;
    // CALLF [0x3945] (1000_3D01 / 0x13D01)
    // Indirect call to [0x3945], generating possible targets from emulator records
    uint targetAddress_1000_3D01 = (uint)(UInt16[DS, 0x3947] * 0x10 + UInt16[DS, 0x3945] - cs1 * 0x10);
    switch(targetAddress_1000_3D01) {
      case 0x2361C : FarCall(cs1, 0x3D05, spice86_generated_label_call_target_334B_016C_03361C); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3D01));
        break;
    }
    label_1000_3D05_13D05:
    // POP BX (1000_3D05 / 0x13D05)
    BX = Stack.Pop();
    // POP SI (1000_3D06 / 0x13D06)
    SI = Stack.Pop();
    // CLD  (1000_3D07 / 0x13D07)
    DirectionFlag = false;
    label_1000_3D08_13D08:
    // ADD AX,word ptr [0x22dd] (1000_3D08 / 0x13D08)
    AX += UInt16[DS, 0x22DD];
    // INC BX (1000_3D0C / 0x13D0C)
    BX = Alu.Inc16(BX);
    // POP CX (1000_3D0D / 0x13D0D)
    CX = Stack.Pop();
    // LOOP 0x1000:3ce0 (1000_3D0E / 0x13D0E)
    if(--CX != 0) {
      goto label_1000_3CE0_13CE0;
    }
    // POP SI (1000_3D10 / 0x13D10)
    SI = Stack.Pop();
    // RET  (1000_3D11 / 0x13D11)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3D12_013D12(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3D12_13D12:
    // TEST byte ptr [0x47a4],0x81 (1000_3D12 / 0x13D12)
    Alu.And8(UInt8[DS, 0x47A4], 0x81);
    // JNZ 0x1000:3d2b (1000_3D17 / 0x13D17)
    if(!ZeroFlag) {
      goto label_1000_3D2B_13D2B;
    }
    // MOV DI,word ptr [0x47f6] (1000_3D19 / 0x13D19)
    DI = UInt16[DS, 0x47F6];
    // DEC word ptr [0x47f6] (1000_3D1D / 0x13D1D)
    UInt16[DS, 0x47F6]--;
    // CMP byte ptr [DI],0xff (1000_3D21 / 0x13D21)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JZ 0x1000:3d2b (1000_3D24 / 0x13D24)
    if(ZeroFlag) {
      goto label_1000_3D2B_13D2B;
    }
    // MOV AL,byte ptr [DI] (1000_3D26 / 0x13D26)
    AL = UInt8[DS, DI];
    // CALL 0x1000:3d2f (1000_3D28 / 0x13D28)
    NearCall(cs1, 0x3D2B, spice86_generated_label_call_target_1000_3D2F_013D2F);
    label_1000_3D2B_13D2B:
    // POP SI (1000_3D2B / 0x13D2B)
    SI = Stack.Pop();
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
    label_1000_3D2F_13D2F:
    // PUSH word ptr [0x2784] (1000_3D2F / 0x13D2F)
    Stack.Push(UInt16[DS, 0x2784]);
    // PUSH AX (1000_3D33 / 0x13D33)
    Stack.Push(AX);
    // XOR AH,AH (1000_3D34 / 0x13D34)
    AH = 0;
    // MOV DI,AX (1000_3D36 / 0x13D36)
    DI = AX;
    // SHL DI,1 (1000_3D38 / 0x13D38)
    DI <<= 0x1;
    // SHL DI,1 (1000_3D3A / 0x13D3A)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    // MOV word ptr [DI + 0x47f8],DX (1000_3D3C / 0x13D3C)
    UInt16[DS, (ushort)(DI + 0x47F8)] = DX;
    // MOV word ptr [DI + 0x47fa],BX (1000_3D40 / 0x13D40)
    UInt16[DS, (ushort)(DI + 0x47FA)] = BX;
    // MOV AX,0x26 (1000_3D44 / 0x13D44)
    AX = 0x26;
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
    label_1000_3D4A_13D4A:
    // POP AX (1000_3D4A / 0x13D4A)
    AX = Stack.Pop();
    // MOV CH,AH (1000_3D4B / 0x13D4B)
    CH = AH;
    // CMP AL,0xf (1000_3D4D / 0x13D4D)
    Alu.Sub8(AL, 0xF);
    // JC 0x1000:3d58 (1000_3D4F / 0x13D4F)
    if(CarryFlag) {
      goto label_1000_3D58_13D58;
    }
    // SUB AL,0xf (1000_3D51 / 0x13D51)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    // MOV [0x476c],AL (1000_3D53 / 0x13D53)
    UInt8[DS, 0x476C] = AL;
    // MOV AL,0xf (1000_3D56 / 0x13D56)
    AL = 0xF;
    label_1000_3D58_13D58:
    // CALL 0x1000:9123 (1000_3D58 / 0x13D58)
    NearCall(cs1, 0x3D5B, spice86_generated_label_call_target_1000_9123_019123);
    label_1000_3D5B_13D5B:
    // CALL 0x1000:127c (1000_3D5B / 0x13D5B)
    NearCall(cs1, 0x3D5E, spice86_generated_label_call_target_1000_127C_01127C);
    label_1000_3D5E_13D5E:
    // JNC 0x1000:3d65 (1000_3D5E / 0x13D5E)
    if(!CarryFlag) {
      goto label_1000_3D65_13D65;
    }
    // MOV AL,0x11 (1000_3D60 / 0x13D60)
    AL = 0x11;
    // ADD BX,0x35 (1000_3D62 / 0x13D62)
    BX += 0x35;
    label_1000_3D65_13D65:
    // CMP AL,0xc (1000_3D65 / 0x13D65)
    Alu.Sub8(AL, 0xC);
    // JNZ 0x1000:3d72 (1000_3D67 / 0x13D67)
    if(!ZeroFlag) {
      goto label_1000_3D72_13D72;
    }
    // TEST byte ptr [0x10a7],0x10 (1000_3D69 / 0x13D69)
    Alu.And8(UInt8[DS, 0x10A7], 0x10);
    // JZ 0x1000:3d72 (1000_3D6E / 0x13D6E)
    if(ZeroFlag) {
      goto label_1000_3D72_13D72;
    }
    // MOV AL,0x12 (1000_3D70 / 0x13D70)
    AL = 0x12;
    label_1000_3D72_13D72:
    // MOV AH,CH (1000_3D72 / 0x13D72)
    AH = CH;
    // SHL AL,1 (1000_3D74 / 0x13D74)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // PUSH AX (1000_3D76 / 0x13D76)
    Stack.Push(AX);
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
    label_1000_3D7A_13D7A:
    // POP AX (1000_3D7A / 0x13D7A)
    AX = Stack.Pop();
    // INC AX (1000_3D7B / 0x13D7B)
    AX = Alu.Inc16(AX);
    // CALL 0x1000:c22f (1000_3D7C / 0x13D7C)
    NearCall(cs1, 0x3D7F, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_3D7F_13D7F:
    // POP AX (1000_3D7F / 0x13D7F)
    AX = Stack.Pop();
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
    label_1000_3D83_13D83:
    // PUSH DS (1000_3D83 / 0x13D83)
    Stack.Push(DS);
    // POP ES (1000_3D84 / 0x13D84)
    ES = Stack.Pop();
    // MOV AX,0xffff (1000_3D85 / 0x13D85)
    AX = 0xFFFF;
    // MOV CX,0x17 (1000_3D88 / 0x13D88)
    CX = 0x17;
    // MOV DI,word ptr [0x47f6] (1000_3D8B / 0x13D8B)
    DI = UInt16[DS, 0x47F6];
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_3D8F / 0x13D8F)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV DI,word ptr [0x47f6] (1000_3D91 / 0x13D91)
    DI = UInt16[DS, 0x47F6];
    // CMP byte ptr [0x4774],0x0 (1000_3D95 / 0x13D95)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:3db0 (1000_3D9A / 0x13D9A)
    if(ZeroFlag) {
      goto label_1000_3DB0_13DB0;
    }
    // MOV AX,[0x4778] (1000_3D9C / 0x13D9C)
    AX = UInt16[DS, 0x4778];
    // OR AX,AX (1000_3D9F / 0x13D9F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:3db0 (1000_3DA1 / 0x13DA1)
    if(ZeroFlag) {
      goto label_1000_3DB0_13DB0;
    }
    // PUSH SI (1000_3DA3 / 0x13DA3)
    Stack.Push(SI);
    // MOV SI,AX (1000_3DA4 / 0x13DA4)
    SI = AX;
    // LODSB CS:SI (1000_3DA6 / 0x13DA6)
    AL = UInt8[cs1, SI];
    SI = (ushort)(SI + Direction8);
    // MOV CL,AL (1000_3DA8 / 0x13DA8)
    CL = AL;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,CS:SI (1000_3DAA / 0x13DAA)
      UInt8[ES, DI] = UInt8[cs1, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP SI (1000_3DAD / 0x13DAD)
    SI = Stack.Pop();
    // JMP 0x1000:3de5 (1000_3DAE / 0x13DAE)
    goto label_1000_3DE5_13DE5;
    label_1000_3DB0_13DB0:
    // MOV DX,word ptr [0x12] (1000_3DB0 / 0x13DB0)
    DX = UInt16[DS, 0x12];
    // XOR DX,word ptr [0x10] (1000_3DB4 / 0x13DB4)
    // DX ^= UInt16[DS, 0x10];
    DX = Alu.Xor16(DX, UInt16[DS, 0x10]);
    // MOV CL,byte ptr [SI] (1000_3DB8 / 0x13DB8)
    CL = UInt8[DS, SI];
    // OR CL,CL (1000_3DBA / 0x13DBA)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JZ 0x1000:3de5 (1000_3DBC / 0x13DBC)
    if(ZeroFlag) {
      goto label_1000_3DE5_13DE5;
    }
    // MOV CH,byte ptr [0xc5] (1000_3DBE / 0x13DBE)
    CH = UInt8[DS, 0xC5];
    // AND CH,0xf (1000_3DC2 / 0x13DC2)
    // CH &= 0xF;
    CH = Alu.And8(CH, 0xF);
    // MOV AX,0xffff (1000_3DC5 / 0x13DC5)
    AX = 0xFFFF;
    label_1000_3DC8_13DC8:
    // INC AX (1000_3DC8 / 0x13DC8)
    AX++;
    // SHR DX,1 (1000_3DC9 / 0x13DC9)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    // JNC 0x1000:3dd0 (1000_3DCB / 0x13DCB)
    if(!CarryFlag) {
      goto label_1000_3DD0_13DD0;
    }
    // CALL 0x1000:3df4 (1000_3DCD / 0x13DCD)
    NearCall(cs1, 0x3DD0, spice86_generated_label_call_target_1000_3DF4_013DF4);
    label_1000_3DD0_13DD0:
    // OR DX,DX (1000_3DD0 / 0x13DD0)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNZ 0x1000:3dc8 (1000_3DD2 / 0x13DD2)
    if(!ZeroFlag) {
      goto label_1000_3DC8_13DC8;
    }
    // MOV DL,byte ptr [0x476a] (1000_3DD4 / 0x13DD4)
    DL = UInt8[DS, 0x476A];
    // DEC DX (1000_3DD8 / 0x13DD8)
    DX = Alu.Dec16(DX);
    // JLE 0x1000:3de5 (1000_3DD9 / 0x13DD9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_3DE5_13DE5;
    }
    // MOV AX,0xf (1000_3DDB / 0x13DDB)
    AX = 0xF;
    label_1000_3DDE_13DDE:
    // INC AX (1000_3DDE / 0x13DDE)
    AX = Alu.Inc16(AX);
    // CALL 0x1000:3df4 (1000_3DDF / 0x13DDF)
    NearCall(cs1, 0x3DE2, spice86_generated_label_call_target_1000_3DF4_013DF4);
    // DEC DX (1000_3DE2 / 0x13DE2)
    DX = Alu.Dec16(DX);
    // JNZ 0x1000:3dde (1000_3DE3 / 0x13DE3)
    if(!ZeroFlag) {
      goto label_1000_3DDE_13DDE;
    }
    label_1000_3DE5_13DE5:
    // LODSB SI (1000_3DE5 / 0x13DE5)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_3DE6 / 0x13DE6)
    AH = 0;
    // MOV DI,word ptr [0x47f6] (1000_3DE8 / 0x13DE8)
    DI = UInt16[DS, 0x47F6];
    // DEC AX (1000_3DEC / 0x13DEC)
    AX--;
    // ADD DI,AX (1000_3DED / 0x13DED)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV word ptr [0x47f6],DI (1000_3DEF / 0x13DEF)
    UInt16[DS, 0x47F6] = DI;
    // RET  (1000_3DF3 / 0x13DF3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3DF4_013DF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3DF4_13DF4:
    // MOV BX,AX (1000_3DF4 / 0x13DF4)
    BX = AX;
    // ADD BL,CH (1000_3DF6 / 0x13DF6)
    BL += CH;
    label_1000_3DF8_13DF8:
    // SUB BL,CL (1000_3DF8 / 0x13DF8)
    // BL -= CL;
    BL = Alu.Sub8(BL, CL);
    // JNC 0x1000:3df8 (1000_3DFA / 0x13DFA)
    if(!CarryFlag) {
      goto label_1000_3DF8_13DF8;
    }
    // ADD BL,CL (1000_3DFC / 0x13DFC)
    BL += CL;
    // CMP byte ptr [BX + DI],0xff (1000_3DFE / 0x13DFE)
    Alu.Sub8(UInt8[DS, (ushort)(BX + DI)], 0xFF);
    // JZ 0x1000:3e10 (1000_3E01 / 0x13E01)
    if(ZeroFlag) {
      goto label_1000_3E10_13E10;
    }
    // MOV BX,0xffff (1000_3E03 / 0x13E03)
    BX = 0xFFFF;
    label_1000_3E06_13E06:
    // INC BX (1000_3E06 / 0x13E06)
    BX++;
    // CMP BL,CL (1000_3E07 / 0x13E07)
    Alu.Sub8(BL, CL);
    // JNC 0x1000:3e12 (1000_3E09 / 0x13E09)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_3E12 / 0x13E12)
      return NearRet();
    }
    // CMP byte ptr [BX + DI],0xff (1000_3E0B / 0x13E0B)
    Alu.Sub8(UInt8[DS, (ushort)(BX + DI)], 0xFF);
    // JNZ 0x1000:3e06 (1000_3E0E / 0x13E0E)
    if(!ZeroFlag) {
      goto label_1000_3E06_13E06;
    }
    label_1000_3E10_13E10:
    // MOV byte ptr [BX + DI],AL (1000_3E10 / 0x13E10)
    UInt8[DS, (ushort)(BX + DI)] = AL;
    label_1000_3E12_13E12:
    // RET  (1000_3E12 / 0x13E12)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3E13_013E13(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3E13_13E13:
    // PUSH BX (1000_3E13 / 0x13E13)
    Stack.Push(BX);
    // PUSH CX (1000_3E14 / 0x13E14)
    Stack.Push(CX);
    // PUSH DX (1000_3E15 / 0x13E15)
    Stack.Push(DX);
    // PUSH DI (1000_3E16 / 0x13E16)
    Stack.Push(DI);
    // MOV word ptr [0x47e8],DX (1000_3E17 / 0x13E17)
    UInt16[DS, 0x47E8] = DX;
    // MOV word ptr [0x47ea],BX (1000_3E1B / 0x13E1B)
    UInt16[DS, 0x47EA] = BX;
    // SUB BX,CX (1000_3E1F / 0x13E1F)
    BX -= CX;
    // SUB DX,DI (1000_3E21 / 0x13E21)
    DX -= DI;
    // NEG BX (1000_3E23 / 0x13E23)
    BX = Alu.Sub16(0, BX);
    // NEG DX (1000_3E25 / 0x13E25)
    DX = Alu.Sub16(0, DX);
    // CALL 0x1000:3e80 (1000_3E27 / 0x13E27)
    NearCall(cs1, 0x3E2A, spice86_generated_label_call_target_1000_3E80_013E80);
    label_1000_3E2A_13E2A:
    // POP DI (1000_3E2A / 0x13E2A)
    DI = Stack.Pop();
    // POP DX (1000_3E2B / 0x13E2B)
    DX = Stack.Pop();
    // POP CX (1000_3E2C / 0x13E2C)
    CX = Stack.Pop();
    // POP BX (1000_3E2D / 0x13E2D)
    BX = Stack.Pop();
    // RET  (1000_3E2E / 0x13E2E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3E80_013E80(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3E2F: break; // Instructions before entry targeted by 0x13E84
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_3E2F_13E2F:
    // MOV BX,word ptr [0x47ea] (1000_3E2F / 0x13E2F)
    BX = UInt16[DS, 0x47EA];
    // MOV CX,DX (1000_3E33 / 0x13E33)
    CX = DX;
    // MOV DX,word ptr [0x47e8] (1000_3E35 / 0x13E35)
    DX = UInt16[DS, 0x47E8];
    // ADD word ptr [0x47e8],CX (1000_3E39 / 0x13E39)
    // UInt16[DS, 0x47E8] += CX;
    UInt16[DS, 0x47E8] = Alu.Add16(UInt16[DS, 0x47E8], CX);
    // JNC 0x1000:3e41 (1000_3E3D / 0x13E3D)
    if(!CarryFlag) {
      goto label_1000_3E41_13E41;
    }
    // ADD DX,CX (1000_3E3F / 0x13E3F)
    // DX += CX;
    DX = Alu.Add16(DX, CX);
    label_1000_3E41_13E41:
    // MOV DI,word ptr [0x22d9] (1000_3E41 / 0x13E41)
    DI = UInt16[DS, 0x22D9];
    // MOV AX,DX (1000_3E45 / 0x13E45)
    AX = DX;
    // STOSW ES:DI (1000_3E47 / 0x13E47)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD DI,0x2 (1000_3E48 / 0x13E48)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // MOV word ptr [0x22d9],DI (1000_3E4B / 0x13E4B)
    UInt16[DS, 0x22D9] = DI;
    // POP SI (1000_3E4F / 0x13E4F)
    SI = Stack.Pop();
    // POP DI (1000_3E50 / 0x13E50)
    DI = Stack.Pop();
    // RET  (1000_3E51 / 0x13E51)
    return NearRet();
    label_1000_3E52_13E52:
    // MOV CX,BX (1000_3E52 / 0x13E52)
    CX = BX;
    // MOV BX,word ptr [0x47ea] (1000_3E54 / 0x13E54)
    BX = UInt16[DS, 0x47EA];
    // MOV DX,word ptr [0x47e8] (1000_3E58 / 0x13E58)
    DX = UInt16[DS, 0x47E8];
    // OR AX,AX (1000_3E5C / 0x13E5C)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:3e68 (1000_3E5E / 0x13E5E)
    if(!SignFlag) {
      goto label_1000_3E68_13E68;
    }
    // SUB word ptr [0x47ea],CX (1000_3E60 / 0x13E60)
    UInt16[DS, 0x47EA] -= CX;
    // SUB BX,CX (1000_3E64 / 0x13E64)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // JMP 0x1000:3e6c (1000_3E66 / 0x13E66)
    goto label_1000_3E6C_13E6C;
    label_1000_3E68_13E68:
    // ADD word ptr [0x47ea],CX (1000_3E68 / 0x13E68)
    UInt16[DS, 0x47EA] += CX;
    label_1000_3E6C_13E6C:
    // INC CX (1000_3E6C / 0x13E6C)
    CX = Alu.Inc16(CX);
    // MOV DI,word ptr [0x22d9] (1000_3E6D / 0x13E6D)
    DI = UInt16[DS, 0x22D9];
    // MOV AX,DX (1000_3E71 / 0x13E71)
    AX = DX;
    label_1000_3E73_13E73:
    // STOSW ES:DI (1000_3E73 / 0x13E73)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD DI,0x2 (1000_3E74 / 0x13E74)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // LOOP 0x1000:3e73 (1000_3E77 / 0x13E77)
    if(--CX != 0) {
      goto label_1000_3E73_13E73;
    }
    // MOV word ptr [0x22d9],DI (1000_3E79 / 0x13E79)
    UInt16[DS, 0x22D9] = DI;
    // POP SI (1000_3E7D / 0x13E7D)
    SI = Stack.Pop();
    // POP DI (1000_3E7E / 0x13E7E)
    DI = Stack.Pop();
    // RET  (1000_3E7F / 0x13E7F)
    return NearRet();
    entry:
    label_1000_3E80_13E80:
    // PUSH DI (1000_3E80 / 0x13E80)
    Stack.Push(DI);
    // PUSH SI (1000_3E81 / 0x13E81)
    Stack.Push(SI);
    // OR BX,BX (1000_3E82 / 0x13E82)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:3e2f (1000_3E84 / 0x13E84)
    if(ZeroFlag) {
      goto label_1000_3E2F_13E2F;
    }
    // MOV AX,0x1 (1000_3E86 / 0x13E86)
    AX = 0x1;
    // JNS 0x1000:3e8f (1000_3E89 / 0x13E89)
    if(!SignFlag) {
      goto label_1000_3E8F_13E8F;
    }
    // NEG BX (1000_3E8B / 0x13E8B)
    BX = Alu.Sub16(0, BX);
    // NEG AX (1000_3E8D / 0x13E8D)
    AX = Alu.Sub16(0, AX);
    label_1000_3E8F_13E8F:
    // OR DX,DX (1000_3E8F / 0x13E8F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:3e52 (1000_3E91 / 0x13E91)
    if(ZeroFlag) {
      goto label_1000_3E52_13E52;
    }
    // MOV CX,0x1 (1000_3E93 / 0x13E93)
    CX = 0x1;
    // JNS 0x1000:3e9c (1000_3E96 / 0x13E96)
    if(!SignFlag) {
      goto label_1000_3E9C_13E9C;
    }
    // NEG CX (1000_3E98 / 0x13E98)
    CX = Alu.Sub16(0, CX);
    // NEG DX (1000_3E9A / 0x13E9A)
    DX = Alu.Sub16(0, DX);
    label_1000_3E9C_13E9C:
    // PUSH AX (1000_3E9C / 0x13E9C)
    Stack.Push(AX);
    // PUSH CX (1000_3E9D / 0x13E9D)
    Stack.Push(CX);
    // PUSH AX (1000_3E9E / 0x13E9E)
    Stack.Push(AX);
    // PUSH CX (1000_3E9F / 0x13E9F)
    Stack.Push(CX);
    // MOV BP,SP (1000_3EA0 / 0x13EA0)
    BP = SP;
    // MOV SI,BX (1000_3EA2 / 0x13EA2)
    SI = BX;
    // MOV DI,DX (1000_3EA4 / 0x13EA4)
    DI = DX;
    // XOR AX,AX (1000_3EA6 / 0x13EA6)
    AX = 0;
    // CMP DX,BX (1000_3EA8 / 0x13EA8)
    Alu.Sub16(DX, BX);
    // JBE 0x1000:3eb1 (1000_3EAA / 0x13EAA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_3EB1_13EB1;
    }
    // MOV word ptr [BP + 0x2],AX (1000_3EAC / 0x13EAC)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // JMP 0x1000:3eba (1000_3EAF / 0x13EAF)
    goto label_1000_3EBA_13EBA;
    label_1000_3EB1_13EB1:
    // OR BX,BX (1000_3EB1 / 0x13EB1)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:3ef8 (1000_3EB3 / 0x13EB3)
    if(ZeroFlag) {
      goto label_1000_3EF8_13EF8;
    }
    // XCHG SI,DI (1000_3EB5 / 0x13EB5)
    ushort tmp_1000_3EB5 = SI;
    SI = DI;
    DI = tmp_1000_3EB5;
    // MOV word ptr [BP + 0x0],AX (1000_3EB7 / 0x13EB7)
    UInt16[SS, BP] = AX;
    label_1000_3EBA_13EBA:
    // MOV AX,DI (1000_3EBA / 0x13EBA)
    AX = DI;
    // MOV CX,DI (1000_3EBC / 0x13EBC)
    CX = DI;
    // SHR AX,1 (1000_3EBE / 0x13EBE)
    AX >>= 0x1;
    label_1000_3EC0_13EC0:
    // ADD AX,SI (1000_3EC0 / 0x13EC0)
    AX += SI;
    // CMP AX,DI (1000_3EC2 / 0x13EC2)
    Alu.Sub16(AX, DI);
    // JC 0x1000:3ed0 (1000_3EC4 / 0x13EC4)
    if(CarryFlag) {
      goto label_1000_3ED0_13ED0;
    }
    // SUB AX,DI (1000_3EC6 / 0x13EC6)
    // AX -= DI;
    AX = Alu.Sub16(AX, DI);
    // MOV DX,word ptr [BP + 0x4] (1000_3EC8 / 0x13EC8)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV BX,word ptr [BP + 0x6] (1000_3ECB / 0x13ECB)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // JMP 0x1000:3ed6 (1000_3ECE / 0x13ECE)
    goto label_1000_3ED6_13ED6;
    label_1000_3ED0_13ED0:
    // MOV DX,word ptr [BP + 0x0] (1000_3ED0 / 0x13ED0)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (1000_3ED3 / 0x13ED3)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    label_1000_3ED6_13ED6:
    // ADD DX,word ptr [0x47e8] (1000_3ED6 / 0x13ED6)
    DX += UInt16[DS, 0x47E8];
    // CMP BX,0x1 (1000_3EDA / 0x13EDA)
    Alu.Sub16(BX, 0x1);
    // JNZ 0x1000:3ef2 (1000_3EDD / 0x13EDD)
    if(!ZeroFlag) {
      goto label_1000_3EF2_13EF2;
    }
    // PUSH DI (1000_3EDF / 0x13EDF)
    Stack.Push(DI);
    // PUSH AX (1000_3EE0 / 0x13EE0)
    Stack.Push(AX);
    // MOV DI,word ptr [0x22d9] (1000_3EE1 / 0x13EE1)
    DI = UInt16[DS, 0x22D9];
    // MOV AX,[0x47e8] (1000_3EE5 / 0x13EE5)
    AX = UInt16[DS, 0x47E8];
    // STOSW ES:DI (1000_3EE8 / 0x13EE8)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD DI,0x2 (1000_3EE9 / 0x13EE9)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // MOV word ptr [0x22d9],DI (1000_3EEC / 0x13EEC)
    UInt16[DS, 0x22D9] = DI;
    // POP AX (1000_3EF0 / 0x13EF0)
    AX = Stack.Pop();
    // POP DI (1000_3EF1 / 0x13EF1)
    DI = Stack.Pop();
    label_1000_3EF2_13EF2:
    // MOV word ptr [0x47e8],DX (1000_3EF2 / 0x13EF2)
    UInt16[DS, 0x47E8] = DX;
    // LOOP 0x1000:3ec0 (1000_3EF6 / 0x13EF6)
    if(--CX != 0) {
      goto label_1000_3EC0_13EC0;
    }
    label_1000_3EF8_13EF8:
    // ADD SP,0x8 (1000_3EF8 / 0x13EF8)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    // POP SI (1000_3EFB / 0x13EFB)
    SI = Stack.Pop();
    // POP DI (1000_3EFC / 0x13EFC)
    DI = Stack.Pop();
    // RET  (1000_3EFD / 0x13EFD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3EFE_013EFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3EFE_13EFE:
    // MOV AL,DH (1000_3EFE / 0x13EFE)
    AL = DH;
    // XOR AH,AH (1000_3F00 / 0x13F00)
    AH = 0;
    // SHL AX,1 (1000_3F02 / 0x13F02)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV SI,AX (1000_3F04 / 0x13F04)
    SI = AX;
    // MOV SI,word ptr [SI + 0x13c4] (1000_3F06 / 0x13F06)
    SI = UInt16[DS, (ushort)(SI + 0x13C4)];
    // MOV AL,DL (1000_3F0A / 0x13F0A)
    AL = DL;
    // DEC AL (1000_3F0C / 0x13F0C)
    AL = Alu.Dec8(AL);
    // MOV AH,0x5 (1000_3F0E / 0x13F0E)
    AH = 0x5;
    // MUL AH (1000_3F10 / 0x13F10)
    Cpu.Mul8(AH);
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
    label_1000_3F14_13F14:
    // RET  (1000_3F14 / 0x13F14)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3F15_013F15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3F15_13F15:
    // MOV BP,0x1 (1000_3F15 / 0x13F15)
    BP = 0x1;
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
    label_1000_3F1A_13F1A:
    // MOV BP,0x2 (1000_3F1A / 0x13F1A)
    BP = 0x2;
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
    label_1000_3F1F_13F1F:
    // MOV BP,0x3 (1000_3F1F / 0x13F1F)
    BP = 0x3;
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
    label_1000_3F27_13F27:
    // PUSH BP (1000_3F27 / 0x13F27)
    Stack.Push(BP);
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
    label_1000_3F2B_13F2B:
    // CALL 0x1000:ac30 (1000_3F2B / 0x13F2B)
    NearCall(cs1, 0x3F2E, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_3F2E_13F2E:
    // CALL 0x1000:a7a5 (1000_3F2E / 0x13F2E)
    NearCall(cs1, 0x3F31, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    label_1000_3F31_13F31:
    // POP BP (1000_3F31 / 0x13F31)
    BP = Stack.Pop();
    // MOV byte ptr [0x47a9],0x0 (1000_3F32 / 0x13F32)
    UInt8[DS, 0x47A9] = 0x0;
    // MOV byte ptr [0x26],0x0 (1000_3F37 / 0x13F37)
    UInt8[DS, 0x26] = 0x0;
    // MOV DX,word ptr [0x4] (1000_3F3C / 0x13F3C)
    DX = UInt16[DS, 0x4];
    // MOV BX,word ptr [0x6] (1000_3F40 / 0x13F40)
    BX = UInt16[DS, 0x6];
    // CMP BL,0x80 (1000_3F44 / 0x13F44)
    Alu.Sub8(BL, 0x80);
    // JZ 0x1000:3f67 (1000_3F47 / 0x13F47)
    if(ZeroFlag) {
      goto label_1000_3F67_13F67;
    }
    // MOV AL,[0x4735] (1000_3F49 / 0x13F49)
    AL = UInt8[DS, 0x4735];
    // AND AL,0x7f (1000_3F4C / 0x13F4C)
    AL &= 0x7F;
    // INC AL (1000_3F4E / 0x13F4E)
    AL = Alu.Inc8(AL);
    // JNS 0x1000:3f54 (1000_3F50 / 0x13F50)
    if(!SignFlag) {
      goto label_1000_3F54_13F54;
    }
    // DEC AL (1000_3F52 / 0x13F52)
    AL = Alu.Dec8(AL);
    label_1000_3F54_13F54:
    // OR AL,0x80 (1000_3F54 / 0x13F54)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    // MOV [0x4735],AL (1000_3F56 / 0x13F56)
    UInt8[DS, 0x4735] = AL;
    // CMP byte ptr [0xf4],0x14 (1000_3F59 / 0x13F59)
    Alu.Sub8(UInt8[DS, 0xF4], 0x14);
    // JNC 0x1000:3f64 (1000_3F5E / 0x13F5E)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      // JMP 0x1000:3ff5 (1000_3F64 / 0x13F64)
      goto label_1000_3FF5_13FF5;
    }
    // INC byte ptr [0xf4] (1000_3F60 / 0x13F60)
    UInt8[DS, 0xF4] = Alu.Inc8(UInt8[DS, 0xF4]);
    label_1000_3F64_13F64:
    // JMP 0x1000:3ff5 (1000_3F64 / 0x13F64)
    goto label_1000_3FF5_13FF5;
    label_1000_3F67_13F67:
    // CALL 0x1000:3efe (1000_3F67 / 0x13F67)
    NearCall(cs1, 0x3F6A, spice86_generated_label_call_target_1000_3EFE_013EFE);
    label_1000_3F6A_13F6A:
    // MOV DL,byte ptr [BP + SI] (1000_3F6A / 0x13F6A)
    DL = UInt8[SS, (ushort)(BP + SI)];
    // OR DL,DL (1000_3F6C / 0x13F6C)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:3f14 (1000_3F6E / 0x13F6E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_3F14 / 0x13F14)
      return NearRet();
    }
    // JS 0x1000:3fd2 (1000_3F70 / 0x13F70)
    if(SignFlag) {
      goto label_1000_3FD2_13FD2;
    }
    // CMP byte ptr [0xb],0x1 (1000_3F72 / 0x13F72)
    Alu.Sub8(UInt8[DS, 0xB], 0x1);
    // JNZ 0x1000:3f84 (1000_3F77 / 0x13F77)
    if(!ZeroFlag) {
      goto label_1000_3F84_13F84;
    }
    // CALL 0x1000:e270 (1000_3F79 / 0x13F79)
    NearCall(cs1, 0x3F7C, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_3F7C_13F7C:
    // MOV CL,0x2 (1000_3F7C / 0x13F7C)
    CL = 0x2;
    // CALL 0x1000:b389 (1000_3F7E / 0x13F7E)
    NearCall(cs1, 0x3F81, spice86_generated_label_call_target_1000_B389_01B389);
    label_1000_3F81_13F81:
    // CALL 0x1000:e283 (1000_3F81 / 0x13F81)
    NearCall(cs1, 0x3F84, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_3F84_13F84:
    // MOV SI,word ptr [0x114e] (1000_3F84 / 0x13F84)
    SI = UInt16[DS, 0x114E];
    // TEST byte ptr [SI + 0xa],0x10 (1000_3F88 / 0x13F88)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x10);
    // JNZ 0x1000:3faa (1000_3F8C / 0x13F8C)
    if(!ZeroFlag) {
      goto label_1000_3FAA_13FAA;
    }
    // OR byte ptr [SI + 0xa],0x10 (1000_3F8E / 0x13F8E)
    UInt8[DS, (ushort)(SI + 0xA)] |= 0x10;
    // CMP DH,0x20 (1000_3F92 / 0x13F92)
    Alu.Sub8(DH, 0x20);
    // ADC byte ptr [0x25],0x0 (1000_3F95 / 0x13F95)
    UInt8[DS, 0x25] = Alu.Adc8(UInt8[DS, 0x25], 0x0);
    // MOV byte ptr [0x26],0xff (1000_3F9A / 0x13F9A)
    UInt8[DS, 0x26] = 0xFF;
    // CALL 0x1000:e270 (1000_3F9F / 0x13F9F)
    NearCall(cs1, 0x3FA2, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_3FA2_13FA2:
    // MOV CL,0x3 (1000_3FA2 / 0x13FA2)
    CL = 0x3;
    // CALL 0x1000:b389 (1000_3FA4 / 0x13FA4)
    NearCall(cs1, 0x3FA7, spice86_generated_label_call_target_1000_B389_01B389);
    label_1000_3FA7_13FA7:
    // CALL 0x1000:e283 (1000_3FA7 / 0x13FA7)
    NearCall(cs1, 0x3FAA, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_3FAA_13FAA:
    // MOV byte ptr [0xc],DL (1000_3FAA / 0x13FAA)
    UInt8[DS, 0xC] = DL;
    // MOV byte ptr [0x23],0x1 (1000_3FAE / 0x13FAE)
    UInt8[DS, 0x23] = 0x1;
    // CALL 0x1000:a1c4 (1000_3FB3 / 0x13FB3)
    NearCall(cs1, 0x3FB6, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    label_1000_3FB6_13FB6:
    // PUSH BX (1000_3FB6 / 0x13FB6)
    Stack.Push(BX);
    // PUSH DX (1000_3FB7 / 0x13FB7)
    Stack.Push(DX);
    // CALL 0x1000:36d3 (1000_3FB8 / 0x13FB8)
    NearCall(cs1, 0x3FBB, spice86_generated_label_call_target_1000_36D3_0136D3);
    label_1000_3FBB_13FBB:
    // POP DX (1000_3FBB / 0x13FBB)
    DX = Stack.Pop();
    // POP BX (1000_3FBC / 0x13FBC)
    BX = Stack.Pop();
    // CALL 0x1000:a1e2 (1000_3FBD / 0x13FBD)
    NearCall(cs1, 0x3FC0, spice86_generated_label_call_target_1000_A1E2_01A1E2);
    label_1000_3FC0_13FC0:
    // JZ 0x1000:3fc3 (1000_3FC0 / 0x13FC0)
    if(ZeroFlag) {
      goto label_1000_3FC3_13FC3;
    }
    // RET  (1000_3FC2 / 0x13FC2)
    return NearRet();
    label_1000_3FC3_13FC3:
    // PUSH BX (1000_3FC3 / 0x13FC3)
    Stack.Push(BX);
    // PUSH DX (1000_3FC4 / 0x13FC4)
    Stack.Push(DX);
    // CALL 0x1000:abd5 (1000_3FC5 / 0x13FC5)
    NearCall(cs1, 0x3FC8, spice86_generated_label_call_target_1000_ABD5_01ABD5);
    label_1000_3FC8_13FC8:
    // POP DX (1000_3FC8 / 0x13FC8)
    DX = Stack.Pop();
    // POP BX (1000_3FC9 / 0x13FC9)
    BX = Stack.Pop();
    // MOV byte ptr [0x23],0x5 (1000_3FCA / 0x13FCA)
    UInt8[DS, 0x23] = 0x5;
    // JMP 0x1000:4057 (1000_3FCF / 0x13FCF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_3FD2_13FD2:
    // MOV byte ptr [0xe7],0x0 (1000_3FD2 / 0x13FD2)
    UInt8[DS, 0xE7] = 0x0;
    // XOR DH,DH (1000_3FD7 / 0x13FD7)
    DH = 0;
    // NEG DL (1000_3FD9 / 0x13FD9)
    DL = Alu.Sub8(0, DL);
    // MOV BP,DX (1000_3FDB / 0x13FDB)
    BP = DX;
    // XOR SI,SI (1000_3FDD / 0x13FDD)
    SI = 0;
    // XCHG word ptr [0x114e],SI (1000_3FDF / 0x13FDF)
    ushort tmp_1000_3FDF = UInt16[DS, 0x114E];
    UInt16[DS, 0x114E] = SI;
    SI = tmp_1000_3FDF;
    // MOV DX,word ptr [SI + 0x2] (1000_3FE3 / 0x13FE3)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,word ptr [SI + 0x4] (1000_3FE6 / 0x13FE6)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // XOR BH,BH (1000_3FE9 / 0x13FE9)
    BH = 0;
    // MOV byte ptr [0x8],0xff (1000_3FEB / 0x13FEB)
    UInt8[DS, 0x8] = 0xFF;
    // MOV byte ptr [0x9],0xff (1000_3FF0 / 0x13FF0)
    UInt8[DS, 0x9] = 0xFF;
    label_1000_3FF5_13FF5:
    // SHL BP,1 (1000_3FF5 / 0x13FF5)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV AX,word ptr [BP + 0x1454] (1000_3FF7 / 0x13FF7)
    AX = UInt16[SS, (ushort)(BP + 0x1454)];
    // CALL 0x1000:b5cf (1000_3FFB / 0x13FFB)
    NearCall(cs1, 0x3FFE, spice86_generated_label_call_target_1000_B5CF_01B5CF);
    label_1000_3FFE_13FFE:
    // OR BH,BH (1000_3FFE / 0x13FFE)
    // BH |= BH;
    BH = Alu.Or8(BH, BH);
    // JNZ 0x1000:4057 (1000_4000 / 0x14000)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_4002_14002:
    // MOV AX,BX (1000_4002 / 0x14002)
    AX = BX;
    // CBW  (1000_4004 / 0x14004)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BX,AX (1000_4005 / 0x14005)
    BX = AX;
    // CALL 0x1000:b532 (1000_4007 / 0x14007)
    NearCall(cs1, 0x400A, spice86_generated_label_call_target_1000_B532_01B532);
    label_1000_400A_1400A:
    // XOR BH,BH (1000_400A / 0x1400A)
    BH = 0;
    // TEST AL,0x40 (1000_400C / 0x1400C)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:4057 (1000_400E / 0x1400E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:409a (1000_4010 / 0x14010)
    NearCall(cs1, 0x4013, spice86_generated_label_call_target_1000_409A_01409A);
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
    // CMP DX,word ptr [SI + 0x2] (1000_4015 / 0x14015)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:4057 (1000_4018 / 0x14018)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4057_014057, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,BX (1000_401A / 0x1401A)
    AX = BX;
    // CBW  (1000_401C / 0x1401C)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BX,AX (1000_401D / 0x1401D)
    BX = AX;
    // MOV byte ptr [0x4735],0x0 (1000_401F / 0x1401F)
    UInt8[DS, 0x4735] = 0x0;
    // MOV word ptr [0x114e],SI (1000_4024 / 0x14024)
    UInt16[DS, 0x114E] = SI;
    // MOV word ptr [0x1150],SI (1000_4028 / 0x14028)
    UInt16[DS, 0x1150] = SI;
    // MOV DI,SI (1000_402C / 0x1402C)
    DI = SI;
    // CALL 0x1000:503c (1000_402E / 0x1402E)
    NearCall(cs1, 0x4031, spice86_generated_label_call_target_1000_503C_01503C);
    label_1000_4031_14031:
    // MOV word ptr [0x9a],0x0 (1000_4031 / 0x14031)
    UInt16[DS, 0x9A] = 0x0;
    // MOV word ptr [0x98],0x0 (1000_4037 / 0x14037)
    UInt16[DS, 0x98] = 0x0;
    // CALL 0x1000:425b (1000_403D / 0x1403D)
    NearCall(cs1, 0x4040, spice86_generated_label_call_target_1000_425B_01425B);
    label_1000_4040_14040:
    // CALL 0x1000:40ae (1000_4040 / 0x14040)
    NearCall(cs1, 0x4043, spice86_generated_label_call_target_1000_40AE_0140AE);
    label_1000_4043_14043:
    // MOV byte ptr [0x8],DH (1000_4043 / 0x14043)
    UInt8[DS, 0x8] = DH;
    // MOV byte ptr [0x9],BH (1000_4047 / 0x14047)
    UInt8[DS, 0x9] = BH;
    // CMP DH,0x20 (1000_404B / 0x1404B)
    Alu.Sub8(DH, 0x20);
    // JC 0x1000:4054 (1000_404E / 0x1404E)
    if(CarryFlag) {
      goto label_1000_4054_14054;
    }
    // OR byte ptr [SI + 0xa],0x10 (1000_4050 / 0x14050)
    // UInt8[DS, (ushort)(SI + 0xA)] |= 0x10;
    UInt8[DS, (ushort)(SI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0xA)], 0x10);
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
    label_1000_405A_1405A:
    // MOV word ptr [0x4],DX (1000_405A / 0x1405A)
    UInt16[DS, 0x4] = DX;
    // MOV AL,DL (1000_405E / 0x1405E)
    AL = DL;
    // XCHG byte ptr [0xb],AL (1000_4060 / 0x14060)
    byte tmp_1000_4060 = UInt8[DS, 0xB];
    UInt8[DS, 0xB] = AL;
    AL = tmp_1000_4060;
    // MOV [0xd],AL (1000_4064 / 0x14064)
    UInt8[DS, 0xD] = AL;
    // MOV word ptr [0x6],BX (1000_4067 / 0x14067)
    UInt16[DS, 0x6] = BX;
    // CMP byte ptr [0x46eb],0x0 (1000_406B / 0x1406B)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:4099 (1000_4070 / 0x14070)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_4099 / 0x14099)
      return NearRet();
    }
    // CMP DX,0x3002 (1000_4072 / 0x14072)
    Alu.Sub16(DX, 0x3002);
    // JNZ 0x1000:407b (1000_4076 / 0x14076)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:2dbf (1000_407B / 0x1407B)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2DBF_012DBF, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:16fc (1000_4078 / 0x14078)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_16FC_0116FC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
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
    label_1000_407E_1407E:
    // MOV DX,word ptr [0x4] (1000_407E / 0x1407E)
    DX = UInt16[DS, 0x4];
    // MOV BX,word ptr [0x6] (1000_4082 / 0x14082)
    BX = UInt16[DS, 0x6];
    // CMP BL,0x80 (1000_4086 / 0x14086)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:4096 (1000_4089 / 0x14089)
    if(!ZeroFlag) {
      goto label_1000_4096_14096;
    }
    // MOV SI,word ptr [0x114e] (1000_408B / 0x1408B)
    SI = UInt16[DS, 0x114E];
    // MOV DX,word ptr [SI + 0x2] (1000_408F / 0x1408F)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,word ptr [SI + 0x4] (1000_4092 / 0x14092)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // RET  (1000_4095 / 0x14095)
    return NearRet();
    label_1000_4096_14096:
    // XCHG AX,BX (1000_4096 / 0x14096)
    ushort tmp_1000_4096 = AX;
    AX = BX;
    BX = tmp_1000_4096;
    // CBW  (1000_4097 / 0x14097)
    AX = (ushort)((short)((sbyte)AL));
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
    label_1000_4099_14099:
    // RET  (1000_4099 / 0x14099)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_409A_01409A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_409A_1409A:
    // MOV SI,0xe4 (1000_409A / 0x1409A)
    SI = 0xE4;
    label_1000_409D_1409D:
    // ADD SI,0x1c (1000_409D / 0x1409D)
    SI += 0x1C;
    // CMP word ptr [SI],-0x1 (1000_40A0 / 0x140A0)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JZ 0x1000:40ab (1000_40A3 / 0x140A3)
    if(ZeroFlag) {
      goto label_1000_40AB_140AB;
    }
    // CMP DI,word ptr [SI + 0x6] (1000_40A5 / 0x140A5)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    // JNZ 0x1000:409d (1000_40A8 / 0x140A8)
    if(!ZeroFlag) {
      goto label_1000_409D_1409D;
    }
    // RET  (1000_40AA / 0x140AA)
    return NearRet();
    label_1000_40AB_140AB:
    // OR SI,SI (1000_40AB / 0x140AB)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // RET  (1000_40AD / 0x140AD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40AE_0140AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_40AE_140AE:
    // MOV AX,DI (1000_40AE / 0x140AE)
    AX = DI;
    // SUB AX,0x100 (1000_40B0 / 0x140B0)
    // AX -= 0x100;
    AX = Alu.Sub16(AX, 0x100);
    // MOV BL,0x1c (1000_40B3 / 0x140B3)
    BL = 0x1C;
    // DIV BL (1000_40B5 / 0x140B5)
    Cpu.Div8(BL);
    // MOV BH,AL (1000_40B7 / 0x140B7)
    BH = AL;
    // INC BH (1000_40B9 / 0x140B9)
    BH = Alu.Inc8(BH);
    // MOV BL,0x80 (1000_40BB / 0x140BB)
    BL = 0x80;
    // MOV DH,byte ptr [DI + 0x8] (1000_40BD / 0x140BD)
    DH = UInt8[DS, (ushort)(DI + 0x8)];
    // MOV DL,0x1 (1000_40C0 / 0x140C0)
    DL = 0x1;
    // RET  (1000_40C2 / 0x140C2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40C3_0140C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_40C3_140C3:
    // MOV BP,0x40c9 (1000_40C3 / 0x140C3)
    BP = 0x40C9;
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
    label_1000_40C9_140C9:
    // TEST byte ptr [SI + 0xf],0x40 (1000_40C9 / 0x140C9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JZ 0x1000:40d4 (1000_40CD / 0x140CD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_40D4 / 0x140D4)
      return NearRet();
    }
    // MOV word ptr [SI],DX (1000_40CF / 0x140CF)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_40D1 / 0x140D1)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    label_1000_40D4_140D4:
    // RET  (1000_40D4 / 0x140D4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40D5_0140D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_40D5_140D5:
    // MOV byte ptr [0x23],0x7 (1000_40D5 / 0x140D5)
    UInt8[DS, 0x23] = 0x7;
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
    label_1000_40DD_140DD:
    // CALL 0x1000:4ac4 (1000_40DD / 0x140DD)
    NearCall(cs1, 0x40E0, spice86_generated_label_ret_target_1000_4AC4_014AC4);
    label_1000_40E0_140E0:
    // MOV BP,0x40e6 (1000_40E0 / 0x140E0)
    BP = 0x40E6;
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
    label_1000_40E6_140E6:
    // TEST byte ptr [SI + 0xf],0x40 (1000_40E6 / 0x140E6)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JZ 0x1000:40f8 (1000_40EA / 0x140EA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_40F8 / 0x140F8)
      return NearRet();
    }
    // TEST byte ptr [SI + 0xf],0x2 (1000_40EC / 0x140EC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x2);
    // JZ 0x1000:40f8 (1000_40F0 / 0x140F0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_40F8 / 0x140F8)
      return NearRet();
    }
    // CALL 0x1000:9556 (1000_40F2 / 0x140F2)
    NearCall(cs1, 0x40F5, not_observed_1000_9556_019556);
    // CALL 0x1000:9655 (1000_40F5 / 0x140F5)
    NearCall(cs1, 0x40F8, not_observed_1000_9655_019655);
    label_1000_40F8_140F8:
    // RET  (1000_40F8 / 0x140F8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_40F9_0140F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_40F9_140F9:
    // TEST byte ptr [0x11c9],0x3 (1000_40F9 / 0x140F9)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JNZ 0x1000:4101 (1000_40FE / 0x140FE)
    if(!ZeroFlag) {
      goto label_1000_4101_14101;
    }
    // RET  (1000_4100 / 0x14100)
    return NearRet();
    label_1000_4101_14101:
    // CMP word ptr [0x10],0x0 (1000_4101 / 0x14101)
    Alu.Sub16(UInt16[DS, 0x10], 0x0);
    // JZ 0x1000:4181 (1000_4106 / 0x14106)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4181 / 0x14181)
      return NearRet();
    }
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
    label_1000_410B_1410B:
    // MOV CX,0x9 (1000_410B / 0x1410B)
    CX = 0x9;
    // MOV AX,0x9 (1000_410E / 0x1410E)
    AX = 0x9;
    // CALL 0x1000:b56c (1000_4111 / 0x14111)
    NearCall(cs1, 0x4114, spice86_generated_label_call_target_1000_B56C_01B56C);
    label_1000_4114_14114:
    // MOV CX,0x51 (1000_4114 / 0x14114)
    CX = 0x51;
    label_1000_4117_14117:
    // LODSB SI (1000_4117 / 0x14117)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST AL,0x40 (1000_4118 / 0x14118)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:417c (1000_411A / 0x1411A)
    if(ZeroFlag) {
      goto label_1000_417C_1417C;
    }
    // MOV DI,word ptr [SI] (1000_411C / 0x1411C)
    DI = UInt16[DS, SI];
    // PUSH CX (1000_411E / 0x1411E)
    Stack.Push(CX);
    // PUSH SI (1000_411F / 0x1411F)
    Stack.Push(SI);
    // CALL 0x1000:409a (1000_4120 / 0x14120)
    NearCall(cs1, 0x4123, spice86_generated_label_call_target_1000_409A_01409A);
    label_1000_4123_14123:
    // JNZ 0x1000:417a (1000_4123 / 0x14123)
    if(!ZeroFlag) {
      goto label_1000_417A_1417A;
    }
    // TEST byte ptr [SI + 0xa],0x80 (1000_4125 / 0x14125)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JZ 0x1000:417a (1000_4129 / 0x14129)
    if(ZeroFlag) {
      goto label_1000_417A_1417A;
    }
    // MOV AL,[0x2a] (1000_412B / 0x1412B)
    AL = UInt8[DS, 0x2A];
    // CMP AL,byte ptr [SI + 0xb] (1000_412E / 0x1412E)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    // JC 0x1000:417a (1000_4131 / 0x14131)
    if(CarryFlag) {
      goto label_1000_417A_1417A;
    }
    // MOV DI,SI (1000_4133 / 0x14133)
    DI = SI;
    // CALL 0x1000:5124 (1000_4135 / 0x14135)
    NearCall(cs1, 0x4138, spice86_generated_label_call_target_1000_5124_015124);
    label_1000_4138_14138:
    // JC 0x1000:417a (1000_4138 / 0x14138)
    if(CarryFlag) {
      goto label_1000_417A_1417A;
    }
    // SUB AL,byte ptr [0x11c7] (1000_413A / 0x1413A)
    AL -= UInt8[DS, 0x11C7];
    // ADD AL,0x60 (1000_413E / 0x1413E)
    AL += 0x60;
    // CMP AL,0xc0 (1000_4140 / 0x14140)
    Alu.Sub8(AL, 0xC0);
    // JNC 0x1000:417a (1000_4142 / 0x14142)
    if(!CarryFlag) {
      goto label_1000_417A_1417A;
    }
    // XOR AH,AH (1000_4144 / 0x14144)
    AH = 0;
    // MOV CX,0xce (1000_4146 / 0x14146)
    CX = 0xCE;
    // CMP AL,0x60 (1000_4149 / 0x14149)
    Alu.Sub8(AL, 0x60);
    // JC 0x1000:4152 (1000_414B / 0x1414B)
    if(CarryFlag) {
      goto label_1000_4152_14152;
    }
    // INC AH (1000_414D / 0x1414D)
    AH++;
    // ADD CX,0x2 (1000_414F / 0x1414F)
    // CX += 0x2;
    CX = Alu.Add16(CX, 0x2);
    label_1000_4152_14152:
    // MOV word ptr [0x11f5],CX (1000_4152 / 0x14152)
    UInt16[DS, 0x11F5] = CX;
    // MOV byte ptr [0xe1],AH (1000_4156 / 0x14156)
    UInt8[DS, 0xE1] = AH;
    // CALL 0x1000:6231 (1000_415A / 0x1415A)
    NearCall(cs1, 0x415D, spice86_generated_label_call_target_1000_6231_016231);
    label_1000_415D_1415D:
    // ADD AX,0x48 (1000_415D / 0x1415D)
    // AX += 0x48;
    AX = Alu.Add16(AX, 0x48);
    // MOV [0x11f3],AX (1000_4160 / 0x14160)
    UInt16[DS, 0x11F3] = AX;
    // MOV byte ptr [0x23],0x3 (1000_4163 / 0x14163)
    UInt8[DS, 0x23] = 0x3;
    // CALL 0x1000:425b (1000_4168 / 0x14168)
    NearCall(cs1, 0x416B, spice86_generated_label_call_target_1000_425B_01425B);
    label_1000_416B_1416B:
    // CALL 0x1000:4944 (1000_416B / 0x1416B)
    NearCall(cs1, 0x416E, spice86_generated_label_call_target_1000_4944_014944);
    label_1000_416E_1416E:
    // CALL 0x1000:dbb2 (1000_416E / 0x1416E)
    NearCall(cs1, 0x4171, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_4171_14171:
    // CALL 0x1000:2efb (1000_4171 / 0x14171)
    NearCall(cs1, 0x4174, spice86_generated_label_call_target_1000_2EFB_012EFB);
    label_1000_4174_14174:
    // CALL 0x1000:2ffb (1000_4174 / 0x14174)
    NearCall(cs1, 0x4177, spice86_generated_label_call_target_1000_2FFB_012FFB);
    label_1000_4177_14177:
    // CALL 0x1000:d397 (1000_4177 / 0x14177)
    NearCall(cs1, 0x417A, spice86_generated_label_call_target_1000_D397_01D397);
    label_1000_417A_1417A:
    // POP SI (1000_417A / 0x1417A)
    SI = Stack.Pop();
    // POP CX (1000_417B / 0x1417B)
    CX = Stack.Pop();
    label_1000_417C_1417C:
    // ADD SI,0x2 (1000_417C / 0x1417C)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // LOOP 0x1000:4117 (1000_417F / 0x1417F)
    if(--CX != 0) {
      goto label_1000_4117_14117;
    }
    label_1000_4181_14181:
    // RET  (1000_4181 / 0x14181)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4182_014182(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4182_14182:
    // MOV AL,[0x11c9] (1000_4182 / 0x14182)
    AL = UInt8[DS, 0x11C9];
    // AND AL,0x3 (1000_4185 / 0x14185)
    AL &= 0x3;
    // DEC AL (1000_4187 / 0x14187)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:4181 (1000_4189 / 0x14189)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4181 / 0x14181)
      return NearRet();
    }
    // CMP byte ptr [0x11cb],0x0 (1000_418B / 0x1418B)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    // JNZ 0x1000:419b (1000_4190 / 0x14190)
    if(!ZeroFlag) {
      goto label_1000_419B_1419B;
    }
    // MOV DI,word ptr [0x11c5] (1000_4192 / 0x14192)
    DI = UInt16[DS, 0x11C5];
    // CALL 0x1000:5d36 (1000_4196 / 0x14196)
    NearCall(cs1, 0x4199, spice86_generated_label_call_target_1000_5D36_015D36);
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
    label_1000_419E_1419E:
    // CALL 0x1000:b532 (1000_419E / 0x1419E)
    NearCall(cs1, 0x41A1, spice86_generated_label_call_target_1000_B532_01B532);
    label_1000_41A1_141A1:
    // AND AL,0x30 (1000_41A1 / 0x141A1)
    AL &= 0x30;
    // CMP AL,0x30 (1000_41A3 / 0x141A3)
    Alu.Sub8(AL, 0x30);
    // JC 0x1000:41c5 (1000_41A5 / 0x141A5)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_41C5_0141C5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x4726],0x0 (1000_41A7 / 0x141A7)
    Alu.Sub8(UInt8[DS, 0x4726], 0x0);
    // JNZ 0x1000:41b3 (1000_41AC / 0x141AC)
    if(!ZeroFlag) {
      goto label_1000_41B3_141B3;
    }
    // MOV byte ptr [0x23],0x4 (1000_41AE / 0x141AE)
    UInt8[DS, 0x23] = 0x4;
    label_1000_41B3_141B3:
    // MOV AL,0x40 (1000_41B3 / 0x141B3)
    AL = 0x40;
    // CALL 0x1000:41cc (1000_41B5 / 0x141B5)
    NearCall(cs1, 0x41B8, not_observed_1000_41CC_0141CC);
    // SUB byte ptr [0x4726],0x20 (1000_41B8 / 0x141B8)
    // UInt8[DS, 0x4726] -= 0x20;
    UInt8[DS, 0x4726] = Alu.Sub8(UInt8[DS, 0x4726], 0x20);
    // JNZ 0x1000:4181 (1000_41BD / 0x141BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4181 / 0x14181)
      return NearRet();
    }
    // MOV byte ptr [0x46d9],0x2 (1000_41BF / 0x141BF)
    UInt8[DS, 0x46D9] = 0x2;
    // RET  (1000_41C4 / 0x141C4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_41C5_0141C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_41C5_141C5:
    // MOV byte ptr [0x4726],0x0 (1000_41C5 / 0x141C5)
    UInt8[DS, 0x4726] = 0x0;
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
    label_1000_41CC_141CC:
    // MOV [0x21fd],AL (1000_41CC / 0x141CC)
    UInt8[DS, 0x21FD] = AL;
    // CMP word ptr [0x1f12],0x4ffb (1000_41CF / 0x141CF)
    Alu.Sub16(UInt16[DS, 0x1F12], 0x4FFB);
    // JNZ 0x1000:41da (1000_41D5 / 0x141D5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_41DA / 0x141DA)
      return NearRet();
    }
    // MOV [0x1f11],AL (1000_41D7 / 0x141D7)
    UInt8[DS, 0x1F11] = AL;
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
    label_1000_41DB_141DB:
    // DEC byte ptr [0x196c] (1000_41DB / 0x141DB)
    UInt8[DS, 0x196C] = Alu.Dec8(UInt8[DS, 0x196C]);
    // CLC  (1000_41DF / 0x141DF)
    CarryFlag = false;
    // RET  (1000_41E0 / 0x141E0)
    return NearRet();
    entry:
    label_1000_41E1_141E1:
    // CMP byte ptr [0x196c],0x0 (1000_41E1 / 0x141E1)
    Alu.Sub8(UInt8[DS, 0x196C], 0x0);
    // JNZ 0x1000:41db (1000_41E6 / 0x141E6)
    if(!ZeroFlag) {
      goto label_1000_41DB_141DB;
    }
    // MOV AL,[0x11c7] (1000_41E8 / 0x141E8)
    AL = UInt8[DS, 0x11C7];
    // ADD AL,0x20 (1000_41EB / 0x141EB)
    AL += 0x20;
    // TEST AL,0x40 (1000_41ED / 0x141ED)
    Alu.And8(AL, 0x40);
    // MOV CX,0x1 (1000_41EF / 0x141EF)
    CX = 0x1;
    // MOV AX,0x8 (1000_41F2 / 0x141F2)
    AX = 0x8;
    // JZ 0x1000:41f8 (1000_41F5 / 0x141F5)
    if(ZeroFlag) {
      goto label_1000_41F8_141F8;
    }
    // XCHG AX,CX (1000_41F7 / 0x141F7)
    ushort tmp_1000_41F7 = AX;
    AX = CX;
    CX = tmp_1000_41F7;
    label_1000_41F8_141F8:
    // CALL 0x1000:b56c (1000_41F8 / 0x141F8)
    NearCall(cs1, 0x41FB, spice86_generated_label_call_target_1000_B56C_01B56C);
    label_1000_41FB_141FB:
    // MOV CX,0x8 (1000_41FB / 0x141FB)
    CX = 0x8;
    label_1000_41FE_141FE:
    // LODSB SI (1000_41FE / 0x141FE)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST AL,0x40 (1000_41FF / 0x141FF)
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:420a (1000_4201 / 0x14201)
    if(!ZeroFlag) {
      goto label_1000_420A_1420A;
    }
    label_1000_4203_14203:
    // ADD SI,0x2 (1000_4203 / 0x14203)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // LOOP 0x1000:41fe (1000_4206 / 0x14206)
    if(--CX != 0) {
      goto label_1000_41FE_141FE;
    }
    // CLC  (1000_4208 / 0x14208)
    CarryFlag = false;
    // RET  (1000_4209 / 0x14209)
    return NearRet();
    label_1000_420A_1420A:
    // MOV DI,word ptr [SI] (1000_420A / 0x1420A)
    DI = UInt16[DS, SI];
    // PUSH CX (1000_420C / 0x1420C)
    Stack.Push(CX);
    // PUSH SI (1000_420D / 0x1420D)
    Stack.Push(SI);
    // CALL 0x1000:409a (1000_420E / 0x1420E)
    NearCall(cs1, 0x4211, spice86_generated_label_call_target_1000_409A_01409A);
    label_1000_4211_14211:
    // JNZ 0x1000:4257 (1000_4211 / 0x14211)
    if(!ZeroFlag) {
      goto label_1000_4257_14257;
    }
    // TEST byte ptr [SI + 0xa],0x80 (1000_4213 / 0x14213)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JZ 0x1000:4221 (1000_4217 / 0x14217)
    if(ZeroFlag) {
      goto label_1000_4221_14221;
    }
    // MOV AL,[0x2a] (1000_4219 / 0x14219)
    AL = UInt8[DS, 0x2A];
    // CMP AL,byte ptr [SI + 0xb] (1000_421C / 0x1421C)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    // JC 0x1000:4257 (1000_421F / 0x1421F)
    if(CarryFlag) {
      goto label_1000_4257_14257;
    }
    label_1000_4221_14221:
    // MOV DI,SI (1000_4221 / 0x14221)
    DI = SI;
    // CALL 0x1000:5124 (1000_4223 / 0x14223)
    NearCall(cs1, 0x4226, spice86_generated_label_call_target_1000_5124_015124);
    label_1000_4226_14226:
    // JC 0x1000:4257 (1000_4226 / 0x14226)
    if(CarryFlag) {
      goto label_1000_4257_14257;
    }
    // SUB AL,byte ptr [0x11c7] (1000_4228 / 0x14228)
    AL -= UInt8[DS, 0x11C7];
    // ADD AL,0x20 (1000_422C / 0x1422C)
    AL += 0x20;
    // CMP AL,0x40 (1000_422E / 0x1422E)
    Alu.Sub8(AL, 0x40);
    // JNC 0x1000:4257 (1000_4230 / 0x14230)
    if(!CarryFlag) {
      goto label_1000_4257_14257;
    }
    // SUB AL,0x20 (1000_4232 / 0x14232)
    // AL -= 0x20;
    AL = Alu.Sub8(AL, 0x20);
    // CBW  (1000_4234 / 0x14234)
    AX = (ushort)((short)((sbyte)AL));
    // SHL AX,1 (1000_4235 / 0x14235)
    AX <<= 0x1;
    // SHL AX,1 (1000_4237 / 0x14237)
    AX <<= 0x1;
    // SHL AX,1 (1000_4239 / 0x14239)
    AX <<= 0x1;
    // SHL AX,1 (1000_423B / 0x1423B)
    AX <<= 0x1;
    // SHL AX,1 (1000_423D / 0x1423D)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV [0x1968],AX (1000_423F / 0x1423F)
    UInt16[DS, 0x1968] = AX;
    // XOR AX,AX (1000_4242 / 0x14242)
    AX = 0;
    // CALL 0x1000:5e4f (1000_4244 / 0x14244)
    NearCall(cs1, 0x4247, spice86_generated_label_call_target_1000_5E4F_015E4F);
    label_1000_4247_14247:
    // MOV BX,0x196d (1000_4247 / 0x14247)
    BX = 0x196D;
    // XLAT BX (1000_424A / 0x1424A)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // MOV [0x196a],AX (1000_424B / 0x1424B)
    UInt16[DS, 0x196A] = AX;
    // POP SI (1000_424E / 0x1424E)
    SI = Stack.Pop();
    // POP CX (1000_424F / 0x1424F)
    CX = Stack.Pop();
    // MOV byte ptr [0x196c],0x6 (1000_4250 / 0x14250)
    UInt8[DS, 0x196C] = 0x6;
    // STC  (1000_4255 / 0x14255)
    CarryFlag = true;
    // RET  (1000_4256 / 0x14256)
    return NearRet();
    label_1000_4257_14257:
    // POP SI (1000_4257 / 0x14257)
    SI = Stack.Pop();
    // POP CX (1000_4258 / 0x14258)
    CX = Stack.Pop();
    // JMP 0x1000:4203 (1000_4259 / 0x14259)
    goto label_1000_4203_14203;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_425B_01425B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_425B_1425B:
    // TEST byte ptr [DI + 0xa],0x80 (1000_425B / 0x1425B)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    // JZ 0x1000:4284 (1000_425F / 0x1425F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4284 / 0x14284)
      return NearRet();
    }
    // AND byte ptr [DI + 0xa],0x7f (1000_4261 / 0x14261)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x7F);
    // MOV byte ptr [DI + 0xb],0x0 (1000_4265 / 0x14265)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x0;
    // CMP byte ptr [DI + 0x8],0x20 (1000_4269 / 0x14269)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x20);
    // JNC 0x1000:4284 (1000_426D / 0x1426D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_4284 / 0x14284)
      return NearRet();
    }
    // INC byte ptr [0x27] (1000_426F / 0x1426F)
    UInt8[DS, 0x27]++;
    // CMP word ptr [DI],0x603 (1000_4273 / 0x14273)
    Alu.Sub16(UInt16[DS, DI], 0x603);
    // JNZ 0x1000:4284 (1000_4277 / 0x14277)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4284 / 0x14284)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_4279 / 0x14279)
    NearCall(cs1, 0x427C, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV AL,0x10 (1000_427C / 0x1427C)
    AL = 0x10;
    // CALL 0x1000:121f (1000_427E / 0x1427E)
    NearCall(cs1, 0x4281, spice86_generated_label_jump_target_1000_121F_01121F);
    // CALL 0x1000:e283 (1000_4281 / 0x14281)
    NearCall(cs1, 0x4284, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_4284_14284:
    // RET  (1000_4284 / 0x14284)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_42E9_0142E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    label_1000_42EF_142EF:
    // MOV AX,0x24 (1000_42EF / 0x142EF)
    AX = 0x24;
    // CALL 0x1000:c13e (1000_42F2 / 0x142F2)
    NearCall(cs1, 0x42F5, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_42F5_142F5:
    // MOV byte ptr [0x473e],0x1 (1000_42F5 / 0x142F5)
    UInt8[DS, 0x473E] = 0x1;
    // MOV byte ptr [0x11c9],0x4 (1000_42FA / 0x142FA)
    UInt8[DS, 0x11C9] = 0x4;
    // MOV word ptr [0x487e],0x2 (1000_42FF / 0x142FF)
    UInt16[DS, 0x487E] = 0x2;
    // MOV BP,0x212e (1000_4305 / 0x14305)
    BP = 0x212E;
    // CALL 0x1000:49ea (1000_4308 / 0x14308)
    NearCall(cs1, 0x430B, spice86_generated_label_call_target_1000_49EA_0149EA);
    label_1000_430B_1430B:
    // MOV BX,0x4415 (1000_430B / 0x1430B)
    BX = 0x4415;
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
    label_1000_4311_14311:
    // MOV AX,0x1ac8 (1000_4311 / 0x14311)
    AX = 0x1AC8;
    // CALL 0x1000:d95e (1000_4314 / 0x14314)
    NearCall(cs1, 0x4317, spice86_generated_label_call_target_1000_D95E_01D95E);
    label_1000_4317_14317:
    // CALL 0x1000:4aca (1000_4317 / 0x14317)
    NearCall(cs1, 0x431A, spice86_generated_label_call_target_1000_4ACA_014ACA);
    label_1000_431A_1431A:
    // MOV word ptr [0x46fc],0x0 (1000_431A / 0x1431A)
    UInt16[DS, 0x46FC] = 0x0;
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
    label_1000_4323_14323:
    // MOV byte ptr [0x46eb],0x1 (1000_4323 / 0x14323)
    UInt8[DS, 0x46EB] = 0x1;
    // MOV SI,0x1cca (1000_4328 / 0x14328)
    SI = 0x1CCA;
    // CALL 0x1000:d72b (1000_432B / 0x1432B)
    NearCall(cs1, 0x432E, spice86_generated_label_call_target_1000_D72B_01D72B);
    label_1000_432E_1432E:
    // MOV SI,0x149c (1000_432E / 0x1432E)
    SI = 0x149C;
    // MOV DI,0x46e3 (1000_4331 / 0x14331)
    DI = 0x46E3;
    // CALL 0x1000:daaa (1000_4334 / 0x14334)
    NearCall(cs1, 0x4337, spice86_generated_label_call_target_1000_DAAA_01DAAA);
    label_1000_4337_14337:
    // CALL 0x1000:5b99 (1000_4337 / 0x14337)
    NearCall(cs1, 0x433A, spice86_generated_label_call_target_1000_5B99_015B99);
    label_1000_433A_1433A:
    // CALL 0x1000:439f (1000_433A / 0x1433A)
    NearCall(cs1, 0x433D, spice86_generated_label_call_target_1000_439F_01439F);
    label_1000_433D_1433D:
    // MOV AX,0x2bc (1000_433D / 0x1433D)
    AX = 0x2BC;
    // CALL 0x1000:ab4f (1000_4340 / 0x14340)
    NearCall(cs1, 0x4343, spice86_generated_label_call_target_1000_AB4F_01AB4F);
    label_1000_4343_14343:
    // CALL 0x1000:4658 (1000_4343 / 0x14343)
    NearCall(cs1, 0x4346, spice86_generated_label_call_target_1000_4658_014658);
    label_1000_4346_14346:
    // MOV word ptr [0x46ed],0x4377 (1000_4346 / 0x14346)
    UInt16[DS, 0x46ED] = 0x4377;
    // CALL 0x1000:5b93 (1000_434C / 0x1434C)
    NearCall(cs1, 0x434F, spice86_generated_label_ret_target_1000_5B93_015B93);
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
    label_1000_4352_14352:
    // CALL 0x1000:c137 (1000_4352 / 0x14352)
    NearCall(cs1, 0x4355, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_4355_14355:
    // CALL 0x1000:5dce (1000_4355 / 0x14355)
    NearCall(cs1, 0x4358, spice86_generated_label_call_target_1000_5DCE_015DCE);
    label_1000_4358_14358:
    // CMP byte ptr [0x473e],0x0 (1000_4358 / 0x14358)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    // JZ 0x1000:436e (1000_435D / 0x1435D)
    if(ZeroFlag) {
      goto label_1000_436E_1436E;
    }
    // MOV AX,0x24 (1000_435F / 0x1435F)
    AX = 0x24;
    // CALL 0x1000:c13e (1000_4362 / 0x14362)
    NearCall(cs1, 0x4365, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_4365_14365:
    // MOV SI,0x14c0 (1000_4365 / 0x14365)
    SI = 0x14C0;
    // CALL 0x1000:c21b (1000_4368 / 0x14368)
    NearCall(cs1, 0x436B, spice86_generated_label_call_target_1000_C21B_01C21B);
    label_1000_436B_1436B:
    // CALL 0x1000:c0f4 (1000_436B / 0x1436B)
    NearCall(cs1, 0x436E, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    label_1000_436E_1436E:
    // CALL 0x1000:c4dd (1000_436E / 0x1436E)
    NearCall(cs1, 0x4371, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_4371_14371:
    // CALL 0x1000:445d (1000_4371 / 0x14371)
    NearCall(cs1, 0x4374, spice86_generated_label_call_target_1000_445D_01445D);
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
    label_1000_43A2_143A2:
    // CMP byte ptr [0x473e],0x0 (1000_43A2 / 0x143A2)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    // JNZ 0x1000:43cc (1000_43A7 / 0x143A7)
    if(!ZeroFlag) {
      goto label_1000_43CC_143CC;
    }
    // MOV AX,0x24 (1000_43A9 / 0x143A9)
    AX = 0x24;
    // CALL 0x1000:c13e (1000_43AC / 0x143AC)
    NearCall(cs1, 0x43AF, spice86_generated_label_call_target_1000_C13E_01C13E);
    // CALL 0x1000:c49a (1000_43AF / 0x143AF)
    NearCall(cs1, 0x43B2, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    // CALL 0x1000:c412 (1000_43B2 / 0x143B2)
    NearCall(cs1, 0x43B5, spice86_generated_label_call_target_1000_C412_01C412);
    // CALLF [0x3935] (1000_43B5 / 0x143B5)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_43B5 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_43B5) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_43B5));
        break;
    }
    // CALL 0x1000:5b69 (1000_43B9 / 0x143B9)
    NearCall(cs1, 0x43BC, spice86_generated_label_call_target_1000_5B69_015B69);
    // MOV SI,0x14a4 (1000_43BC / 0x143BC)
    SI = 0x14A4;
    // MOV AL,0xf5 (1000_43BF / 0x143BF)
    AL = 0xF5;
    // MOV ES,word ptr [0xdbda] (1000_43C1 / 0x143C1)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38dd] (1000_43C5 / 0x143C5)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_43C5 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_43C5) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_43C5));
        break;
    }
    // JMP 0x1000:c4dd (1000_43C9 / 0x143C9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_43CC_143CC:
    // CMP byte ptr [0x2b],0x0 (1000_43CC / 0x143CC)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:43d6 (1000_43D1 / 0x143D1)
    if(!ZeroFlag) {
      goto label_1000_43D6_143D6;
    }
    // CALL 0x1000:38b4 (1000_43D3 / 0x143D3)
    NearCall(cs1, 0x43D6, spice86_generated_label_call_target_1000_38B4_0138B4);
    label_1000_43D6_143D6:
    // MOV AX,0x24 (1000_43D6 / 0x143D6)
    AX = 0x24;
    // CALL 0x1000:c13e (1000_43D9 / 0x143D9)
    NearCall(cs1, 0x43DC, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_43DC_143DC:
    // MOV SI,0x14b4 (1000_43DC / 0x143DC)
    SI = 0x14B4;
    // CALL 0x1000:c21b (1000_43DF / 0x143DF)
    NearCall(cs1, 0x43E2, spice86_generated_label_call_target_1000_C21B_01C21B);
    label_1000_43E2_143E2:
    // RET  (1000_43E2 / 0x143E2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_43E3_0143E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_43E3_143E3:
    // CMP byte ptr [0x473e],0x0 (1000_43E3 / 0x143E3)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    // JNZ 0x1000:43fc (1000_43E8 / 0x143E8)
    if(!ZeroFlag) {
      goto label_1000_43FC_143FC;
    }
    // CMP word ptr [0xdbea],0x0 (1000_43EA / 0x143EA)
    Alu.Sub16(UInt16[DS, 0xDBEA], 0x0);
    // JNZ 0x1000:440f (1000_43EF / 0x143EF)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_440F_01440F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x14ac (1000_43F1 / 0x143F1)
    SI = 0x14AC;
    // PUSH SI (1000_43F4 / 0x143F4)
    Stack.Push(SI);
    // CALL 0x1000:c446 (1000_43F5 / 0x143F5)
    NearCall(cs1, 0x43F8, spice86_generated_label_call_target_1000_C446_01C446);
    // POP SI (1000_43F8 / 0x143F8)
    SI = Stack.Pop();
    // JMP 0x1000:c4f0 (1000_43F9 / 0x143F9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_43FC_143FC:
    // CMP byte ptr [0x6],0x80 (1000_43FC / 0x143FC)
    Alu.Sub8(UInt8[DS, 0x6], 0x80);
    // JNZ 0x1000:440f (1000_4401 / 0x14401)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_440F_01440F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:388d (1000_4403 / 0x14403)
    NearCall(cs1, 0x4406, spice86_generated_label_ret_target_1000_388D_01388D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4406_014406, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
