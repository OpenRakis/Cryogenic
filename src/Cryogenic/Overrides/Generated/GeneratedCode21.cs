namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_334B_272E_035BDE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_272E_35BDE:
    // PUSH CS (334B_272E / 0x35BDE)
    Stack.Push(cs2);
    // PUSH CS (334B_272F / 0x35BDF)
    Stack.Push(cs2);
    // POP DS (334B_2730 / 0x35BE0)
    DS = Stack.Pop();
    // POP ES (334B_2731 / 0x35BE1)
    ES = Stack.Pop();
    // MOV SI,0x5c2 (334B_2732 / 0x35BE2)
    SI = 0x5C2;
    // MOV DI,0x2c2 (334B_2735 / 0x35BE5)
    DI = 0x2C2;
    // MOV CX,0x17d (334B_2738 / 0x35BE8)
    CX = 0x17D;
    label_334B_273B_35BEB:
    // MOV AX,word ptr [DI] (334B_273B / 0x35BEB)
    AX = UInt16[DS, DI];
    // XCHG word ptr [SI],AX (334B_273D / 0x35BED)
    ushort tmp_334B_273D = UInt16[DS, SI];
    UInt16[DS, SI] = AX;
    AX = tmp_334B_273D;
    // STOSW ES:DI (334B_273F / 0x35BEF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD SI,0x2 (334B_2740 / 0x35BF0)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // LOOP 0x3000:5beb (334B_2743 / 0x35BF3)
    if(--CX != 0) {
      goto label_334B_273B_35BEB;
    }
    // MOV AX,0x55 (334B_2745 / 0x35BF5)
    AX = 0x55;
    // MOV DX,0x316 (334B_2748 / 0x35BF8)
    DX = 0x316;
    // CALL 0x3000:5b93 (334B_274B / 0x35BFB)
    NearCall(cs2, 0x274E, spice86_generated_label_call_target_334B_26E3_035B93);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_274E_035BFE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_274E_035BFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_274E_35BFE:
    // MOV CX,0xff (334B_274E / 0x35BFE)
    CX = 0xFF;
    // MOV DX,0x316 (334B_2751 / 0x35C01)
    DX = 0x316;
    // JMP 0x3000:5afd (334B_2754 / 0x35C04)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_264D_035AFD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2757_035C07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2757_35C07:
    // PUSH CS (334B_2757 / 0x35C07)
    Stack.Push(cs2);
    // CALL 0x3000:3fbc (334B_2758 / 0x35C08)
    NearCall(cs2, 0x275B, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_275B_035C0B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_275B_035C0B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_275B_35C0B:
    // MOV DI,word ptr CS:[0x1a3] (334B_275B / 0x35C0B)
    DI = UInt16[cs2, 0x1A3];
    // MOV SI,DI (334B_2760 / 0x35C10)
    SI = DI;
    // MOV CX,0x5f00 (334B_2762 / 0x35C12)
    CX = 0x5F00;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2765 / 0x35C15)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // RETF  (334B_2767 / 0x35C17)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2A68_035F18(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2A68_35F18:
    // MOV BX,0x4a (334B_2A68 / 0x35F18)
    BX = 0x4A;
    // MOV DX,0x9c (334B_2A6B / 0x35F1B)
    DX = 0x9C;
    // CALL 0x3000:40c0 (334B_2A6E / 0x35F1E)
    NearCall(cs2, 0x2A71, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A71_035F21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A71_035F21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2A71_35F21:
    // MOV DX,0x1 (334B_2A71 / 0x35F21)
    DX = 0x1;
    // MOV AX,0xfb08 (334B_2A74 / 0x35F24)
    AX = 0xFB08;
    // CALL 0x3000:5f60 (334B_2A77 / 0x35F27)
    NearCall(cs2, 0x2A7A, spice86_generated_label_call_target_334B_2AB0_035F60);
    label_334B_2A7A_35F2A:
    // INC DX (334B_2A7A / 0x35F2A)
    DX++;
    // XOR AX,AX (334B_2A7B / 0x35F2B)
    AX = 0;
    // CALL 0x3000:5f60 (334B_2A7D / 0x35F2D)
    NearCall(cs2, 0x2A80, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A80_035F30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A80_035F30(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25F33: goto label_334B_2A83_35F33;break; // Target of external jump from 0x35F5D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_2A80_35F30:
    // MOV DX,0x2 (334B_2A80 / 0x35F30)
    DX = 0x2;
    label_334B_2A83_35F33:
    // MOV AX,0xfaf8 (334B_2A83 / 0x35F33)
    AX = 0xFAF8;
    // ADD DI,AX (334B_2A86 / 0x35F36)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // CALL 0x3000:5f60 (334B_2A88 / 0x35F38)
    NearCall(cs2, 0x2A8B, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A8B_035F3B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A8B_035F3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2A8B_35F3B:
    // SUB DI,0x4f8 (334B_2A8B / 0x35F3B)
    // DI -= 0x4F8;
    DI = Alu.Sub16(DI, 0x4F8);
    // MOV AX,0xf600 (334B_2A8F / 0x35F3F)
    AX = 0xF600;
    // CALL 0x3000:5f60 (334B_2A92 / 0x35F42)
    NearCall(cs2, 0x2A95, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A95_035F45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A95_035F45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2A95_35F45:
    // ADD DI,0x508 (334B_2A95 / 0x35F45)
    DI += 0x508;
    // INC DX (334B_2A99 / 0x35F49)
    DX = Alu.Inc16(DX);
    // MOV AX,0xfb08 (334B_2A9A / 0x35F4A)
    AX = 0xFB08;
    // CALL 0x3000:5f60 (334B_2A9D / 0x35F4D)
    NearCall(cs2, 0x2AA0, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AA0_035F50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AA0_035F50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2AA0_35F50:
    // ADD DI,0x4f8 (334B_2AA0 / 0x35F50)
    DI += 0x4F8;
    // XOR AX,AX (334B_2AA4 / 0x35F54)
    AX = 0;
    // CALL 0x3000:5f60 (334B_2AA6 / 0x35F56)
    NearCall(cs2, 0x2AA9, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AA9_035F59, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AA9_035F59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2AA9_35F59:
    // INC DX (334B_2AA9 / 0x35F59)
    DX++;
    // CMP DX,0x26 (334B_2AAA / 0x35F5A)
    Alu.Sub16(DX, 0x26);
    // JC 0x3000:5f33 (334B_2AAD / 0x35F5D)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A80_035F30, 0x35F33 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RETF  (334B_2AAF / 0x35F5F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2AB0_035F60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2AB0_35F60:
    // PUSH word ptr [BP + 0x0] (334B_2AB0 / 0x35F60)
    Stack.Push(UInt16[SS, BP]);
    // MOV BX,DX (334B_2AB3 / 0x35F63)
    BX = DX;
    label_334B_2AB5_35F65:
    // MOV CX,0x4 (334B_2AB5 / 0x35F65)
    CX = 0x4;
    label_334B_2AB8_35F68:
    // MOV SI,DI (334B_2AB8 / 0x35F68)
    SI = DI;
    // MOVSW ES:DI,SI (334B_2ABA / 0x35F6A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_2ABB / 0x35F6B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_2ABC / 0x35F6C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_2ABD / 0x35F6D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // ADD DI,0x138 (334B_2ABE / 0x35F6E)
    // DI += 0x138;
    DI = Alu.Add16(DI, 0x138);
    // LOOP 0x3000:5f68 (334B_2AC2 / 0x35F72)
    if(--CX != 0) {
      goto label_334B_2AB8_35F68;
    }
    // ADD DI,AX (334B_2AC4 / 0x35F74)
    DI += AX;
    // DEC BX (334B_2AC6 / 0x35F76)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:5f65 (334B_2AC7 / 0x35F77)
    if(!ZeroFlag) {
      goto label_334B_2AB5_35F65;
    }
    // POP AX (334B_2AC9 / 0x35F79)
    AX = Stack.Pop();
    label_334B_2ACA_35F7A:
    // CMP AX,word ptr [BP + 0x0] (334B_2ACA / 0x35F7A)
    Alu.Sub16(AX, UInt16[SS, BP]);
    // JZ 0x3000:5f7a (334B_2ACD / 0x35F7D)
    if(ZeroFlag) {
      goto label_334B_2ACA_35F7A;
    }
    // RET  (334B_2ACF / 0x35F7F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2AD1_035F81(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2AD1_35F81:
    // PUSH CS (334B_2AD1 / 0x35F81)
    Stack.Push(cs2);
    // CALL 0x3000:3fbc (334B_2AD2 / 0x35F82)
    NearCall(cs2, 0x2AD5, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AD5_035F85, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AD5_035F85(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2AD5_35F85:
    // OR DX,DX (334B_2AD5 / 0x35F85)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JS 0x3000:5fca (334B_2AD7 / 0x35F87)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_2B1A_035FCA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH CX (334B_2AD9 / 0x35F89)
    Stack.Push(CX);
    // PUSH DS (334B_2ADA / 0x35F8A)
    Stack.Push(DS);
    // MOV DS,word ptr CS:[0x2539] (334B_2ADB / 0x35F8B)
    DS = UInt16[cs2, 0x2539];
    // CALL 0x3000:6102 (334B_2AE0 / 0x35F90)
    NearCall(cs2, 0x2AE3, spice86_generated_label_call_target_334B_2C52_036102);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AE3_035F93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AE3_035F93(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25F97: goto label_334B_2AE7_35F97;break; // Target of external jump from 0x35FC7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_2AE3_35F93:
    // POP DS (334B_2AE3 / 0x35F93)
    DS = Stack.Pop();
    // POP CX (334B_2AE4 / 0x35F94)
    CX = Stack.Pop();
    // MOV BX,CX (334B_2AE5 / 0x35F95)
    BX = CX;
    label_334B_2AE7_35F97:
    // MOV DX,0x140 (334B_2AE7 / 0x35F97)
    DX = 0x140;
    // SUB BX,0x8 (334B_2AEA / 0x35F9A)
    // BX -= 0x8;
    BX = Alu.Sub16(BX, 0x8);
    // PUSH BX (334B_2AED / 0x35F9D)
    Stack.Push(BX);
    // PUSH word ptr [BP + 0x0] (334B_2AEE / 0x35F9E)
    Stack.Push(UInt16[SS, BP]);
    // JNS 0x3000:5fa7 (334B_2AF1 / 0x35FA1)
    if(!SignFlag) {
      goto label_334B_2AF7_35FA7;
    }
    // ADD DX,BX (334B_2AF3 / 0x35FA3)
    DX += BX;
    // XOR BX,BX (334B_2AF5 / 0x35FA5)
    BX = 0;
    label_334B_2AF7_35FA7:
    // MOV AX,word ptr [BP + 0x0] (334B_2AF7 / 0x35FA7)
    AX = UInt16[SS, BP];
    label_334B_2AFA_35FAA:
    // CMP AX,word ptr [BP + 0x0] (334B_2AFA / 0x35FAA)
    Alu.Sub16(AX, UInt16[SS, BP]);
    // JZ 0x3000:5faa (334B_2AFD / 0x35FAD)
    if(ZeroFlag) {
      goto label_334B_2AFA_35FAA;
    }
    // CALL 0x3000:40c0 (334B_2AFF / 0x35FAF)
    NearCall(cs2, 0x2B02, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B02_035FB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B02_035FB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B02_35FB2:
    // PUSH BX (334B_2B02 / 0x35FB2)
    Stack.Push(BX);
    // PUSH DX (334B_2B03 / 0x35FB3)
    Stack.Push(DX);
    // PUSH DI (334B_2B04 / 0x35FB4)
    Stack.Push(DI);
    // CALL 0x3000:605c (334B_2B05 / 0x35FB5)
    NearCall(cs2, 0x2B08, spice86_generated_label_call_target_334B_2BAC_03605C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B08_035FB8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B08_035FB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B08_35FB8:
    // POP DI (334B_2B08 / 0x35FB8)
    DI = Stack.Pop();
    // POP DX (334B_2B09 / 0x35FB9)
    DX = Stack.Pop();
    // POP BX (334B_2B0A / 0x35FBA)
    BX = Stack.Pop();
    // CALL 0x3000:6006 (334B_2B0B / 0x35FBB)
    NearCall(cs2, 0x2B0E, spice86_generated_label_call_target_334B_2B56_036006);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B0E_035FBE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B0E_035FBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B0E_35FBE:
    // POP BX (334B_2B0E / 0x35FBE)
    BX = Stack.Pop();
    // CALL 0x3000:5a22 (334B_2B0F / 0x35FBF)
    NearCall(cs2, 0x2B12, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B12_035FC2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B12_035FC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B12_35FC2:
    // POP BX (334B_2B12 / 0x35FC2)
    BX = Stack.Pop();
    // CMP BX,0xfec8 (334B_2B13 / 0x35FC3)
    Alu.Sub16(BX, 0xFEC8);
    // JG 0x3000:5f97 (334B_2B17 / 0x35FC7)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AE3_035F93, 0x35F97 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RETF  (334B_2B19 / 0x35FC9)
    return FarRet();
  }
  
  public virtual Action split_334B_2B1A_035FCA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B1A_35FCA:
    // PUSH CX (334B_2B1A / 0x35FCA)
    Stack.Push(CX);
    // PUSH DS (334B_2B1B / 0x35FCB)
    Stack.Push(DS);
    // MOV DS,word ptr CS:[0x2537] (334B_2B1C / 0x35FCC)
    DS = UInt16[cs2, 0x2537];
    // CALL 0x3000:6102 (334B_2B21 / 0x35FD1)
    NearCall(cs2, 0x2B24, spice86_generated_label_call_target_334B_2C52_036102);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B24_035FD4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B24_035FD4(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25FD9: goto label_334B_2B29_35FD9;break; // Target of external jump from 0x36003
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_2B24_35FD4:
    // POP DS (334B_2B24 / 0x35FD4)
    DS = Stack.Pop();
    // POP CX (334B_2B25 / 0x35FD5)
    CX = Stack.Pop();
    // MOV BX,0xfec8 (334B_2B26 / 0x35FD6)
    BX = 0xFEC8;
    label_334B_2B29_35FD9:
    // MOV DX,0x140 (334B_2B29 / 0x35FD9)
    DX = 0x140;
    // PUSH BX (334B_2B2C / 0x35FDC)
    Stack.Push(BX);
    // PUSH word ptr [BP + 0x0] (334B_2B2D / 0x35FDD)
    Stack.Push(UInt16[SS, BP]);
    // OR BX,BX (334B_2B30 / 0x35FE0)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNS 0x3000:5fe8 (334B_2B32 / 0x35FE2)
    if(!SignFlag) {
      goto label_334B_2B38_35FE8;
    }
    // ADD DX,BX (334B_2B34 / 0x35FE4)
    DX += BX;
    // XOR BX,BX (334B_2B36 / 0x35FE6)
    BX = 0;
    label_334B_2B38_35FE8:
    // CALL 0x3000:40c0 (334B_2B38 / 0x35FE8)
    NearCall(cs2, 0x2B3B, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B3B_035FEB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B3B_035FEB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B3B_35FEB:
    // PUSH BX (334B_2B3B / 0x35FEB)
    Stack.Push(BX);
    // PUSH DX (334B_2B3C / 0x35FEC)
    Stack.Push(DX);
    // PUSH DI (334B_2B3D / 0x35FED)
    Stack.Push(DI);
    // CALL 0x3000:60b2 (334B_2B3E / 0x35FEE)
    NearCall(cs2, 0x2B41, spice86_generated_label_call_target_334B_2C02_0360B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B41_035FF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B41_035FF1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B41_35FF1:
    // POP DI (334B_2B41 / 0x35FF1)
    DI = Stack.Pop();
    // POP DX (334B_2B42 / 0x35FF2)
    DX = Stack.Pop();
    // POP BX (334B_2B43 / 0x35FF3)
    BX = Stack.Pop();
    // CALL 0x3000:6006 (334B_2B44 / 0x35FF4)
    NearCall(cs2, 0x2B47, spice86_generated_label_call_target_334B_2B56_036006);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B47_035FF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B47_035FF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B47_35FF7:
    // POP BX (334B_2B47 / 0x35FF7)
    BX = Stack.Pop();
    // CALL 0x3000:5a22 (334B_2B48 / 0x35FF8)
    NearCall(cs2, 0x2B4B, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B4B_035FFB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B4B_035FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B4B_35FFB:
    // POP BX (334B_2B4B / 0x35FFB)
    BX = Stack.Pop();
    // ADD BX,0x8 (334B_2B4C / 0x35FFC)
    BX += 0x8;
    // CMP BX,0x98 (334B_2B4F / 0x35FFF)
    Alu.Sub16(BX, 0x98);
    // JL 0x3000:5fd9 (334B_2B53 / 0x36003)
    if(SignFlag != OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B24_035FD4, 0x35FD9 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RETF  (334B_2B55 / 0x36005)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2B56_036006(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2B56_36006:
    // PUSH DX (334B_2B56 / 0x36006)
    Stack.Push(DX);
    // MOV AX,0xc8 (334B_2B57 / 0x36007)
    AX = 0xC8;
    // NEG DX (334B_2B5A / 0x3600A)
    DX = Alu.Sub16(0, DX);
    // ADD DX,0x140 (334B_2B5C / 0x3600C)
    DX += 0x140;
    // INC DX (334B_2B60 / 0x36010)
    DX++;
    // MUL DX (334B_2B61 / 0x36011)
    Cpu.Mul16(DX);
    // MOV SI,AX (334B_2B63 / 0x36013)
    SI = AX;
    // MOV AX,0x98 (334B_2B65 / 0x36015)
    AX = 0x98;
    // SUB SI,AX (334B_2B68 / 0x36018)
    // SI -= AX;
    SI = Alu.Sub16(SI, AX);
    // POP DX (334B_2B6A / 0x3601A)
    DX = Stack.Pop();
    // CMP DX,AX (334B_2B6B / 0x3601B)
    Alu.Sub16(DX, AX);
    // JNC 0x3000:6023 (334B_2B6D / 0x3601D)
    if(!CarryFlag) {
      goto label_334B_2B73_36023;
    }
    // ADD SI,AX (334B_2B6F / 0x3601F)
    SI += AX;
    // SUB SI,DX (334B_2B71 / 0x36021)
    SI -= DX;
    label_334B_2B73_36023:
    // SUB AX,BX (334B_2B73 / 0x36023)
    AX -= BX;
    // CMP AX,DX (334B_2B75 / 0x36025)
    Alu.Sub16(AX, DX);
    // JC 0x3000:602b (334B_2B77 / 0x36027)
    if(CarryFlag) {
      goto label_334B_2B7B_3602B;
    }
    // MOV AX,DX (334B_2B79 / 0x36029)
    AX = DX;
    label_334B_2B7B_3602B:
    // MOV DS,word ptr CS:[0x2535] (334B_2B7B / 0x3602B)
    DS = UInt16[cs2, 0x2535];
    // SUB DI,AX (334B_2B80 / 0x36030)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    label_334B_2B82_36032:
    // MOV CX,AX (334B_2B82 / 0x36032)
    CX = AX;
    // SHR CX,1 (334B_2B84 / 0x36034)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2B86 / 0x36036)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // SUB SI,AX (334B_2B88 / 0x36038)
    SI -= AX;
    // SUB DI,AX (334B_2B8A / 0x3603A)
    DI -= AX;
    // ADD SI,0xc8 (334B_2B8C / 0x3603C)
    SI += 0xC8;
    // ADD DI,0x140 (334B_2B90 / 0x36040)
    DI += 0x140;
    // DEC AX (334B_2B94 / 0x36044)
    AX = Alu.Dec16(AX);
    // MOV CX,AX (334B_2B95 / 0x36045)
    CX = AX;
    // SHR CX,1 (334B_2B97 / 0x36047)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2B99 / 0x36049)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // MOVSB ES:DI,SI (334B_2B9B / 0x3604B)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // SUB SI,AX (334B_2B9C / 0x3604C)
    SI -= AX;
    // SUB DI,AX (334B_2B9E / 0x3604E)
    DI -= AX;
    // ADD SI,0xc8 (334B_2BA0 / 0x36050)
    SI += 0xC8;
    // ADD DI,0x140 (334B_2BA4 / 0x36054)
    DI += 0x140;
    // DEC AX (334B_2BA8 / 0x36058)
    AX = Alu.Dec16(AX);
    // JG 0x3000:6032 (334B_2BA9 / 0x36059)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_334B_2B82_36032;
    }
    // RET  (334B_2BAB / 0x3605B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2BAC_03605C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2BAC_3605C:
    // MOV DS,word ptr CS:[0x2537] (334B_2BAC / 0x3605C)
    DS = UInt16[cs2, 0x2537];
    // MOV AX,0x98 (334B_2BB1 / 0x36061)
    AX = 0x98;
    // SUB AX,BX (334B_2BB4 / 0x36064)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // MOV BX,DX (334B_2BB6 / 0x36066)
    BX = DX;
    // SUB BX,AX (334B_2BB8 / 0x36068)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // JNS 0x3000:606e (334B_2BBA / 0x3606A)
    if(!SignFlag) {
      goto label_334B_2BBE_3606E;
    }
    // ADD AX,BX (334B_2BBC / 0x3606C)
    AX += BX;
    label_334B_2BBE_3606E:
    // CMP DX,0x138 (334B_2BBE / 0x3606E)
    Alu.Sub16(DX, 0x138);
    // JBE 0x3000:608d (334B_2BC2 / 0x36072)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_2BDD_3608D;
    }
    // XOR DX,DX (334B_2BC4 / 0x36074)
    DX = 0;
    label_334B_2BC6_36076:
    // MOV CX,DX (334B_2BC6 / 0x36076)
    CX = DX;
    // MOV SI,DI (334B_2BC8 / 0x36078)
    SI = DI;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_2BCA / 0x3607A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // SUB DI,DX (334B_2BCC / 0x3607C)
    DI -= DX;
    // ADD DI,0x13f (334B_2BCE / 0x3607E)
    DI += 0x13F;
    // INC DX (334B_2BD2 / 0x36082)
    DX++;
    // CMP DX,0x8 (334B_2BD3 / 0x36083)
    Alu.Sub16(DX, 0x8);
    // JC 0x3000:6076 (334B_2BD6 / 0x36086)
    if(CarryFlag) {
      goto label_334B_2BC6_36076;
    }
    // SUB AX,0x8 (334B_2BD8 / 0x36088)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    // JBE 0x3000:60b1 (334B_2BDB / 0x3608B)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (334B_2C01 / 0x360B1)
      return NearRet();
    }
    label_334B_2BDD_3608D:
    // MOV SI,DI (334B_2BDD / 0x3608D)
    SI = DI;
    // MOV CX,0x4 (334B_2BDF / 0x3608F)
    CX = 0x4;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2BE2 / 0x36092)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADD DI,0x137 (334B_2BE4 / 0x36094)
    DI += 0x137;
    // DEC AX (334B_2BE8 / 0x36098)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:608d (334B_2BE9 / 0x36099)
    if(!ZeroFlag) {
      goto label_334B_2BDD_3608D;
    }
    // OR BX,BX (334B_2BEB / 0x3609B)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JGE 0x3000:60b1 (334B_2BED / 0x3609D)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (334B_2C01 / 0x360B1)
      return NearRet();
    }
    // MOV DX,0x8 (334B_2BEF / 0x3609F)
    DX = 0x8;
    label_334B_2BF2_360A2:
    // MOV CX,DX (334B_2BF2 / 0x360A2)
    CX = DX;
    // MOV SI,DI (334B_2BF4 / 0x360A4)
    SI = DI;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_2BF6 / 0x360A6)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // SUB DI,DX (334B_2BF8 / 0x360A8)
    DI -= DX;
    // ADD DI,0x140 (334B_2BFA / 0x360AA)
    DI += 0x140;
    // DEC DX (334B_2BFE / 0x360AE)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:60a2 (334B_2BFF / 0x360AF)
    if(!ZeroFlag) {
      goto label_334B_2BF2_360A2;
    }
    label_334B_2C01_360B1:
    // RET  (334B_2C01 / 0x360B1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2C02_0360B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2C02_360B2:
    // MOV DS,word ptr CS:[0x2537] (334B_2C02 / 0x360B2)
    DS = UInt16[cs2, 0x2537];
    // MOV AX,0x98 (334B_2C07 / 0x360B7)
    AX = 0x98;
    // ADD AX,0x8 (334B_2C0A / 0x360BA)
    AX += 0x8;
    // CMP DI,AX (334B_2C0D / 0x360BD)
    Alu.Sub16(DI, AX);
    // JC 0x3000:6101 (334B_2C0F / 0x360BF)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (334B_2C51 / 0x36101)
      return NearRet();
    }
    // OR BX,BX (334B_2C11 / 0x360C1)
    BX |= BX;
    // SUB AX,0x8 (334B_2C13 / 0x360C3)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    // OR BX,BX (334B_2C16 / 0x360C6)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JLE 0x3000:60ee (334B_2C18 / 0x360C8)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_2C3E_360EE;
    }
    // ADD AX,0x8 (334B_2C1A / 0x360CA)
    AX += 0x8;
    // SUB AX,BX (334B_2C1D / 0x360CD)
    AX -= BX;
    // SUB DI,AX (334B_2C1F / 0x360CF)
    DI -= AX;
    // SUB DI,0xa00 (334B_2C21 / 0x360D1)
    // DI -= 0xA00;
    DI = Alu.Sub16(DI, 0xA00);
    // MOV DX,0x8 (334B_2C25 / 0x360D5)
    DX = 0x8;
    label_334B_2C28_360D8:
    // MOV CX,AX (334B_2C28 / 0x360D8)
    CX = AX;
    // SHR CX,1 (334B_2C2A / 0x360DA)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // MOV SI,DI (334B_2C2C / 0x360DC)
    SI = DI;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2C2E / 0x360DE)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // SUB DI,AX (334B_2C30 / 0x360E0)
    DI -= AX;
    // ADD DI,0x140 (334B_2C32 / 0x360E2)
    DI += 0x140;
    // DEC DX (334B_2C36 / 0x360E6)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:60d8 (334B_2C37 / 0x360E7)
    if(!ZeroFlag) {
      goto label_334B_2C28_360D8;
    }
    // SUB AX,0x8 (334B_2C39 / 0x360E9)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    // JMP 0x3000:60f3 (334B_2C3C / 0x360EC)
    goto label_334B_2C43_360F3;
    label_334B_2C3E_360EE:
    // SUB DI,AX (334B_2C3E / 0x360EE)
    DI -= AX;
    // SUB DI,0x8 (334B_2C40 / 0x360F0)
    // DI -= 0x8;
    DI = Alu.Sub16(DI, 0x8);
    label_334B_2C43_360F3:
    // MOV SI,DI (334B_2C43 / 0x360F3)
    SI = DI;
    // MOV CX,0x4 (334B_2C45 / 0x360F5)
    CX = 0x4;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2C48 / 0x360F8)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADD DI,0x138 (334B_2C4A / 0x360FA)
    DI += 0x138;
    // DEC AX (334B_2C4E / 0x360FE)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:60f3 (334B_2C4F / 0x360FF)
    if(!ZeroFlag) {
      goto label_334B_2C43_360F3;
    }
    label_334B_2C51_36101:
    // RET  (334B_2C51 / 0x36101)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2C52_036102(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2C52_36102:
    // PUSH ES (334B_2C52 / 0x36102)
    Stack.Push(ES);
    // MOV ES,word ptr CS:[0x2535] (334B_2C53 / 0x36103)
    ES = UInt16[cs2, 0x2535];
    // MOV SI,0xf9ff (334B_2C58 / 0x36108)
    SI = 0xF9FF;
    // XOR DI,DI (334B_2C5B / 0x3610B)
    DI = 0;
    // MOV DX,0x140 (334B_2C5D / 0x3610D)
    DX = 0x140;
    // MOV BX,0x6062 (334B_2C60 / 0x36110)
    BX = 0x6062;
    label_334B_2C63_36113:
    // PUSH SI (334B_2C63 / 0x36113)
    Stack.Push(SI);
    // MOV CX,0x32 (334B_2C64 / 0x36114)
    CX = 0x32;
    label_334B_2C67_36117:
    // MOV AH,byte ptr [SI + 0xfec0] (334B_2C67 / 0x36117)
    AH = UInt8[DS, (ushort)(SI + 0xFEC0)];
    // CMP AH,BH (334B_2C6B / 0x3611B)
    Alu.Sub8(AH, BH);
    // JC 0x3000:6126 (334B_2C6D / 0x3611D)
    if(CarryFlag) {
      goto label_334B_2C76_36126;
    }
    // CMP AH,BL (334B_2C6F / 0x3611F)
    Alu.Sub8(AH, BL);
    // JNC 0x3000:6126 (334B_2C71 / 0x36121)
    if(!CarryFlag) {
      goto label_334B_2C76_36126;
    }
    // ADD AH,0x2 (334B_2C73 / 0x36123)
    // AH += 0x2;
    AH = Alu.Add8(AH, 0x2);
    label_334B_2C76_36126:
    // MOV AL,byte ptr [SI] (334B_2C76 / 0x36126)
    AL = UInt8[DS, SI];
    // CMP AL,BH (334B_2C78 / 0x36128)
    Alu.Sub8(AL, BH);
    // JC 0x3000:6132 (334B_2C7A / 0x3612A)
    if(CarryFlag) {
      goto label_334B_2C82_36132;
    }
    // CMP AL,BL (334B_2C7C / 0x3612C)
    Alu.Sub8(AL, BL);
    // JNC 0x3000:6132 (334B_2C7E / 0x3612E)
    if(!CarryFlag) {
      goto label_334B_2C82_36132;
    }
    // ADD AL,0x2 (334B_2C80 / 0x36130)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    label_334B_2C82_36132:
    // STOSW ES:DI (334B_2C82 / 0x36132)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AH,byte ptr [SI + 0xfc40] (334B_2C83 / 0x36133)
    AH = UInt8[DS, (ushort)(SI + 0xFC40)];
    // CMP AH,BH (334B_2C87 / 0x36137)
    Alu.Sub8(AH, BH);
    // JC 0x3000:6142 (334B_2C89 / 0x36139)
    if(CarryFlag) {
      goto label_334B_2C92_36142;
    }
    // CMP AH,BL (334B_2C8B / 0x3613B)
    Alu.Sub8(AH, BL);
    // JNC 0x3000:6142 (334B_2C8D / 0x3613D)
    if(!CarryFlag) {
      goto label_334B_2C92_36142;
    }
    // ADD AH,0x2 (334B_2C8F / 0x3613F)
    // AH += 0x2;
    AH = Alu.Add8(AH, 0x2);
    label_334B_2C92_36142:
    // MOV AL,byte ptr [SI + 0xfd80] (334B_2C92 / 0x36142)
    AL = UInt8[DS, (ushort)(SI + 0xFD80)];
    // CMP AL,BH (334B_2C96 / 0x36146)
    Alu.Sub8(AL, BH);
    // JC 0x3000:6150 (334B_2C98 / 0x36148)
    if(CarryFlag) {
      goto label_334B_2CA0_36150;
    }
    // CMP AL,BL (334B_2C9A / 0x3614A)
    Alu.Sub8(AL, BL);
    // JNC 0x3000:6150 (334B_2C9C / 0x3614C)
    if(!CarryFlag) {
      goto label_334B_2CA0_36150;
    }
    // ADD AL,0x2 (334B_2C9E / 0x3614E)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    label_334B_2CA0_36150:
    // STOSW ES:DI (334B_2CA0 / 0x36150)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // SUB SI,0x500 (334B_2CA1 / 0x36151)
    // SI -= 0x500;
    SI = Alu.Sub16(SI, 0x500);
    // LOOP 0x3000:6117 (334B_2CA5 / 0x36155)
    if(--CX != 0) {
      goto label_334B_2C67_36117;
    }
    // POP SI (334B_2CA7 / 0x36157)
    SI = Stack.Pop();
    // DEC SI (334B_2CA8 / 0x36158)
    SI--;
    // DEC DX (334B_2CA9 / 0x36159)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:6113 (334B_2CAA / 0x3615A)
    if(!ZeroFlag) {
      goto label_334B_2C63_36113;
    }
    // PUSH DS (334B_2CAC / 0x3615C)
    Stack.Push(DS);
    // PUSH ES (334B_2CAD / 0x3615D)
    Stack.Push(ES);
    // POP DS (334B_2CAE / 0x3615E)
    DS = Stack.Pop();
    // MOV DI,0x62a0 (334B_2CAF / 0x3615F)
    DI = 0x62A0;
    // MOV DX,0x44 (334B_2CB2 / 0x36162)
    DX = 0x44;
    label_334B_2CB5_36165:
    // LEA SI,[DI + 0xd5d0] (334B_2CB5 / 0x36165)
    SI = (ushort)(DI + 0xD5D0);
    // MOVSW ES:DI,SI (334B_2CB9 / 0x36169)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_2CBA / 0x3616A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_2CBB / 0x3616B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_2CBC / 0x3616C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // ADD DI,0xc0 (334B_2CBD / 0x3616D)
    DI += 0xC0;
    // DEC DX (334B_2CC1 / 0x36171)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:6165 (334B_2CC2 / 0x36172)
    if(!ZeroFlag) {
      goto label_334B_2CB5_36165;
    }
    // POP DS (334B_2CC4 / 0x36174)
    DS = Stack.Pop();
    // POP ES (334B_2CC5 / 0x36175)
    ES = Stack.Pop();
    // RET  (334B_2CC6 / 0x36176)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2CCA_03617A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2CCA_3617A:
    // OR DL,DL (334B_2CCA / 0x3617A)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JS 0x3000:61ae (334B_2CCC / 0x3617C)
    if(SignFlag) {
      goto label_334B_2CFE_361AE;
    }
    // MOV AX,0x140 (334B_2CCE / 0x3617E)
    AX = 0x140;
    // MUL CX (334B_2CD1 / 0x36181)
    Cpu.Mul16(CX);
    // MOV DX,AX (334B_2CD3 / 0x36183)
    DX = AX;
    // MOV SI,DX (334B_2CD5 / 0x36185)
    SI = DX;
    // MOV BX,word ptr [BP + 0x0] (334B_2CD7 / 0x36187)
    BX = UInt16[SS, BP];
    label_334B_2CDA_3618A:
    // XOR DI,DI (334B_2CDA / 0x3618A)
    DI = 0;
    // MOV CX,DX (334B_2CDC / 0x3618C)
    CX = DX;
    // SUB CX,SI (334B_2CDE / 0x3618E)
    // CX -= SI;
    CX = Alu.Sub16(CX, SI);
    // JZ 0x3000:6198 (334B_2CE0 / 0x36190)
    if(ZeroFlag) {
      goto label_334B_2CE8_36198;
    }
    // PUSH SI (334B_2CE2 / 0x36192)
    Stack.Push(SI);
    // SHR CX,1 (334B_2CE3 / 0x36193)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2CE5 / 0x36195)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // POP SI (334B_2CE7 / 0x36197)
    SI = Stack.Pop();
    label_334B_2CE8_36198:
    // MOV CX,0x500 (334B_2CE8 / 0x36198)
    CX = 0x500;
    // MOV AX,0x707 (334B_2CEB / 0x3619B)
    AX = 0x707;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_2CEE / 0x3619E)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // SUB SI,0xa00 (334B_2CF0 / 0x361A0)
    // SI -= 0xA00;
    SI = Alu.Sub16(SI, 0xA00);
    // CALL 0x3000:59ed (334B_2CF4 / 0x361A4)
    NearCall(cs2, 0x2CF7, spice86_generated_label_call_target_334B_253D_0359ED);
    // CMP SI,0xa00 (334B_2CF7 / 0x361A7)
    Alu.Sub16(SI, 0xA00);
    // JA 0x3000:618a (334B_2CFB / 0x361AB)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_2CDA_3618A;
    }
    // RETF  (334B_2CFD / 0x361AD)
    return FarRet();
    label_334B_2CFE_361AE:
    // CALL 0x3000:5a46 (334B_2CFE / 0x361AE)
    NearCall(cs2, 0x2D01, spice86_generated_label_call_target_334B_2596_035A46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2D01_0361B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2D01_0361B1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x261BE: goto label_334B_2D0E_361BE;break; // Target of external jump from 0x361EF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_2D01_361B1:
    // MOV AX,0x140 (334B_2D01 / 0x361B1)
    AX = 0x140;
    // MUL CX (334B_2D04 / 0x361B4)
    Cpu.Mul16(CX);
    // MOV DX,AX (334B_2D06 / 0x361B6)
    DX = AX;
    // MOV SI,0xa00 (334B_2D08 / 0x361B8)
    SI = 0xA00;
    // MOV BX,word ptr [BP + 0x0] (334B_2D0B / 0x361BB)
    BX = UInt16[SS, BP];
    label_334B_2D0E_361BE:
    // PUSH SI (334B_2D0E / 0x361BE)
    Stack.Push(SI);
    // XOR DI,DI (334B_2D0F / 0x361BF)
    DI = 0;
    // MOV CX,DX (334B_2D11 / 0x361C1)
    CX = DX;
    // SUB CX,SI (334B_2D13 / 0x361C3)
    // CX -= SI;
    CX = Alu.Sub16(CX, SI);
    // MOV AX,DS (334B_2D15 / 0x361C5)
    AX = DS;
    // MOV DS,word ptr CS:[0x2535] (334B_2D17 / 0x361C7)
    DS = UInt16[cs2, 0x2535];
    // SHR CX,1 (334B_2D1C / 0x361CC)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2D1E / 0x361CE)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // MOV DS,AX (334B_2D20 / 0x361D0)
    DS = AX;
    // MOV CX,0x500 (334B_2D22 / 0x361D2)
    CX = 0x500;
    // MOV AX,0x707 (334B_2D25 / 0x361D5)
    AX = 0x707;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_2D28 / 0x361D8)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // CMP DI,DX (334B_2D2A / 0x361DA)
    Alu.Sub16(DI, DX);
    // JNC 0x3000:61e5 (334B_2D2C / 0x361DC)
    if(!CarryFlag) {
      goto label_334B_2D35_361E5;
    }
    // MOV CX,0x500 (334B_2D2E / 0x361DE)
    CX = 0x500;
    // MOV SI,DI (334B_2D31 / 0x361E1)
    SI = DI;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2D33 / 0x361E3)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    label_334B_2D35_361E5:
    // POP SI (334B_2D35 / 0x361E5)
    SI = Stack.Pop();
    // ADD SI,0xa00 (334B_2D36 / 0x361E6)
    // SI += 0xA00;
    SI = Alu.Add16(SI, 0xA00);
    // CALL 0x3000:59ed (334B_2D3A / 0x361EA)
    NearCall(cs2, 0x2D3D, spice86_generated_label_call_target_334B_253D_0359ED);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2D3D_0361ED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2D3D_0361ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2D3D_361ED:
    // CMP SI,DX (334B_2D3D / 0x361ED)
    Alu.Sub16(SI, DX);
    // JBE 0x3000:61be (334B_2D3F / 0x361EF)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2D01_0361B1, 0x361BE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RETF  (334B_2D41 / 0x361F1)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2DC0_036270(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2DC0_36270:
    // MOV CX,0xc8 (334B_2DC0 / 0x36270)
    CX = 0xC8;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2DC3_036273, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2DC3_036273(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x2627D: goto label_334B_2DCD_3627D;break; // Target of external jump from 0x362A5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_2DC3_36273:
    // MOV BX,word ptr [BP + 0x0] (334B_2DC3 / 0x36273)
    BX = UInt16[SS, BP];
    // MOV SI,0x2fd7 (334B_2DC6 / 0x36276)
    SI = 0x2FD7;
    // SHR CX,1 (334B_2DC9 / 0x36279)
    CX >>= 0x1;
    // SHR CX,1 (334B_2DCB / 0x3627B)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    label_334B_2DCD_3627D:
    // LODSW CS:SI (334B_2DCD / 0x3627D)
    AX = UInt16[cs2, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (334B_2DCF / 0x3627F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x3000:62a7 (334B_2DD1 / 0x36281)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_2DF7_0362A7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH CX (334B_2DD3 / 0x36283)
    Stack.Push(CX);
    // PUSH SI (334B_2DD4 / 0x36284)
    Stack.Push(SI);
    // ADD AX,word ptr CS:[0x1a3] (334B_2DD5 / 0x36285)
    // AX += UInt16[cs2, 0x1A3];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1A3]);
    // MOV DI,AX (334B_2DDA / 0x3628A)
    DI = AX;
    // XOR AX,AX (334B_2DDC / 0x3628C)
    AX = 0;
    label_334B_2DDE_3628E:
    // PUSH DI (334B_2DDE / 0x3628E)
    Stack.Push(DI);
    // MOV DX,0x50 (334B_2DDF / 0x3628F)
    DX = 0x50;
    label_334B_2DE2_36292:
    // STOSB ES:DI (334B_2DE2 / 0x36292)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD DI,0x3 (334B_2DE3 / 0x36293)
    DI += 0x3;
    // DEC DX (334B_2DE6 / 0x36296)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:6292 (334B_2DE7 / 0x36297)
    if(!ZeroFlag) {
      goto label_334B_2DE2_36292;
    }
    // POP DI (334B_2DE9 / 0x36299)
    DI = Stack.Pop();
    // ADD DI,0x500 (334B_2DEA / 0x3629A)
    // DI += 0x500;
    DI = Alu.Add16(DI, 0x500);
    // LOOP 0x3000:628e (334B_2DEE / 0x3629E)
    if(--CX != 0) {
      goto label_334B_2DDE_3628E;
    }
    // CALL 0x3000:5a22 (334B_2DF0 / 0x362A0)
    NearCall(cs2, 0x2DF3, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2DF3_0362A3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2DF3_0362A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2DF3_362A3:
    // POP SI (334B_2DF3 / 0x362A3)
    SI = Stack.Pop();
    // POP CX (334B_2DF4 / 0x362A4)
    CX = Stack.Pop();
    // JMP 0x3000:627d (334B_2DF5 / 0x362A5)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2DC3_036273, 0x3627D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_2DF7_0362A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2DF7_362A7:
    // PUSH CS (334B_2DF7 / 0x362A7)
    Stack.Push(cs2);
    // CALL 0x3000:3fbc (334B_2DF8 / 0x362A8)
    NearCall(cs2, 0x2DFB, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2DFB_0362AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2DFB_0362AB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x262B1: goto label_334B_2E01_362B1;break; // Target of external jump from 0x362D9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_2DFB_362AB:
    // MOV BX,word ptr [BP + 0x0] (334B_2DFB / 0x362AB)
    BX = UInt16[SS, BP];
    // MOV SI,0x2fd7 (334B_2DFE / 0x362AE)
    SI = 0x2FD7;
    label_334B_2E01_362B1:
    // LODSW CS:SI (334B_2E01 / 0x362B1)
    AX = UInt16[cs2, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (334B_2E03 / 0x362B3)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x3000:62db (334B_2E05 / 0x362B5)
    if(SignFlag) {
      // JS target is RETF, inlining.
      // RETF  (334B_2E2B / 0x362DB)
      return FarRet();
    }
    // PUSH CX (334B_2E07 / 0x362B7)
    Stack.Push(CX);
    // PUSH SI (334B_2E08 / 0x362B8)
    Stack.Push(SI);
    // ADD AX,word ptr CS:[0x1a3] (334B_2E09 / 0x362B9)
    // AX += UInt16[cs2, 0x1A3];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1A3]);
    // MOV DI,AX (334B_2E0E / 0x362BE)
    DI = AX;
    label_334B_2E10_362C0:
    // PUSH DI (334B_2E10 / 0x362C0)
    Stack.Push(DI);
    // MOV DX,0x50 (334B_2E11 / 0x362C1)
    DX = 0x50;
    label_334B_2E14_362C4:
    // MOV SI,DI (334B_2E14 / 0x362C4)
    SI = DI;
    // MOVSB ES:DI,SI (334B_2E16 / 0x362C6)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // ADD DI,0x3 (334B_2E17 / 0x362C7)
    DI += 0x3;
    // DEC DX (334B_2E1A / 0x362CA)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:62c4 (334B_2E1B / 0x362CB)
    if(!ZeroFlag) {
      goto label_334B_2E14_362C4;
    }
    // POP DI (334B_2E1D / 0x362CD)
    DI = Stack.Pop();
    // ADD DI,0x500 (334B_2E1E / 0x362CE)
    // DI += 0x500;
    DI = Alu.Add16(DI, 0x500);
    // LOOP 0x3000:62c0 (334B_2E22 / 0x362D2)
    if(--CX != 0) {
      goto label_334B_2E10_362C0;
    }
    // CALL 0x3000:5a22 (334B_2E24 / 0x362D4)
    NearCall(cs2, 0x2E27, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2E27_0362D7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2E27_0362D7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2E27_362D7:
    // POP SI (334B_2E27 / 0x362D7)
    SI = Stack.Pop();
    // POP CX (334B_2E28 / 0x362D8)
    CX = Stack.Pop();
    // JMP 0x3000:62b1 (334B_2E29 / 0x362D9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2DFB_0362AB, 0x362B1 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_2E2B_0362DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_2E2B_362DB:
    // RETF  (334B_2E2B / 0x362DB)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_311A_0365CA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_311A_365CA:
    // MOV DI,word ptr CS:[0x3118] (334B_311A / 0x365CA)
    DI = UInt16[cs2, 0x3118];
    // XOR AX,AX (334B_311F / 0x365CF)
    AX = 0;
    // MOV CX,0x12c0 (334B_3121 / 0x365D1)
    CX = 0x12C0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_3124 / 0x365D4)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // MOV DS,word ptr CS:[0x2537] (334B_3126 / 0x365D6)
    DS = UInt16[cs2, 0x2537];
    // PUSH CS (334B_312B / 0x365DB)
    Stack.Push(cs2);
    // CALL 0x3000:3fbc (334B_312C / 0x365DC)
    NearCall(cs2, 0x312F, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_312F_0365DF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_312F_0365DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_312F_365DF:
    // RET  (334B_312F / 0x365DF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3130_0365E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3130_365E0:
    // CALL 0x3000:5a46 (334B_3130 / 0x365E0)
    NearCall(cs2, 0x3133, spice86_generated_label_call_target_334B_2596_035A46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3133_0365E3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3133_0365E3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x265FA: goto label_334B_314A_365FA;break; // Target of external jump from 0x3661A
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_3133_365E3:
    // MOV DS,word ptr CS:[0x2535] (334B_3133 / 0x365E3)
    DS = UInt16[cs2, 0x2535];
    // MOV AX,CS:[0x1a3] (334B_3138 / 0x365E8)
    AX = UInt16[cs2, 0x1A3];
    // MOV CS:[0x3118],AX (334B_313C / 0x365EC)
    UInt16[cs2, 0x3118] = AX;
    // OR DL,DL (334B_3140 / 0x365F0)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // MOV CX,0x101 (334B_3142 / 0x365F2)
    CX = 0x101;
    // JS 0x3000:65fa (334B_3145 / 0x365F5)
    if(SignFlag) {
      goto label_334B_314A_365FA;
    }
    // MOV CX,0xff11 (334B_3147 / 0x365F7)
    CX = 0xFF11;
    label_334B_314A_365FA:
    // PUSH word ptr [BP + 0x0] (334B_314A / 0x365FA)
    Stack.Push(UInt16[SS, BP]);
    // PUSH CX (334B_314D / 0x365FD)
    Stack.Push(CX);
    // PUSH BP (334B_314E / 0x365FE)
    Stack.Push(BP);
    // XOR CH,CH (334B_314F / 0x365FF)
    CH = 0;
    // MOV BX,CX (334B_3151 / 0x36601)
    BX = CX;
    // SHL BX,1 (334B_3153 / 0x36603)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV AX,word ptr CS:[BX + 0x30f0] (334B_3155 / 0x36605)
    AX = UInt16[cs2, (ushort)(BX + 0x30F0)];
    // CALL 0x3000:661d (334B_315A / 0x3660A)
    NearCall(cs2, 0x315D, spice86_generated_label_call_target_334B_316D_03661D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_315D_03660D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_315D_03660D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_315D_3660D:
    // POP BP (334B_315D / 0x3660D)
    BP = Stack.Pop();
    // POP CX (334B_315E / 0x3660E)
    CX = Stack.Pop();
    // POP BX (334B_315F / 0x3660F)
    BX = Stack.Pop();
    // CALL 0x3000:59ed (334B_3160 / 0x36610)
    NearCall(cs2, 0x3163, spice86_generated_label_call_target_334B_253D_0359ED);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3163_036613, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3163_036613(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3163_36613:
    // ADD CL,CH (334B_3163 / 0x36613)
    // CL += CH;
    CL = Alu.Add8(CL, CH);
    // JZ 0x3000:661c (334B_3165 / 0x36615)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      // RETF  (334B_316C / 0x3661C)
      return FarRet();
    }
    // CMP CL,0x11 (334B_3167 / 0x36617)
    Alu.Sub8(CL, 0x11);
    // JC 0x3000:65fa (334B_316A / 0x3661A)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3133_0365E3, 0x365FA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_334B_316C_3661C:
    // RETF  (334B_316C / 0x3661C)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_316D_03661D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_316D_3661D:
    // CMP CL,0x9 (334B_316D / 0x3661D)
    Alu.Sub8(CL, 0x9);
    // JZ 0x3000:65ca (334B_3170 / 0x36620)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_311A_0365CA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CS:[0x3114],AX (334B_3172 / 0x36622)
    UInt16[cs2, 0x3114] = AX;
    // MOV DI,0x5dc0 (334B_3176 / 0x36626)
    DI = 0x5DC0;
    // ADD DI,word ptr CS:[0x1a3] (334B_3179 / 0x36629)
    // DI += UInt16[cs2, 0x1A3];
    DI = Alu.Add16(DI, UInt16[cs2, 0x1A3]);
    // LEA BP,[DI + 0x140] (334B_317E / 0x3662E)
    BP = (ushort)(DI + 0x140);
    // MOV SI,DI (334B_3182 / 0x36632)
    SI = DI;
    // MOV BX,BP (334B_3184 / 0x36634)
    BX = BP;
    // MOV DX,0x4c (334B_3186 / 0x36636)
    DX = 0x4C;
    // JMP 0x3000:6643 (334B_3189 / 0x36639)
    goto label_334B_3193_36643;
    label_334B_318B_3663B:
    // SUB SI,0x280 (334B_318B / 0x3663B)
    SI -= 0x280;
    // SUB DI,0x280 (334B_318F / 0x3663F)
    DI -= 0x280;
    label_334B_3193_36643:
    // DEC DX (334B_3193 / 0x36643)
    DX = Alu.Dec16(DX);
    // JS 0x3000:6675 (334B_3194 / 0x36644)
    if(SignFlag) {
      goto label_334B_31C5_36675;
    }
    // MOV CX,0xa0 (334B_3196 / 0x36646)
    CX = 0xA0;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3199 / 0x36649)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // XCHG BP,DI (334B_319B / 0x3664B)
    ushort tmp_334B_319B = BP;
    BP = DI;
    DI = tmp_334B_319B;
    // XCHG BX,SI (334B_319D / 0x3664D)
    ushort tmp_334B_319D = BX;
    BX = SI;
    SI = tmp_334B_319D;
    // MOV CX,0xa0 (334B_319F / 0x3664F)
    CX = 0xA0;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_31A2 / 0x36652)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // XCHG BP,DI (334B_31A4 / 0x36654)
    ushort tmp_334B_31A4 = BP;
    BP = DI;
    DI = tmp_334B_31A4;
    // XCHG BX,SI (334B_31A6 / 0x36656)
    ushort tmp_334B_31A6 = BX;
    BX = SI;
    SI = tmp_334B_31A6;
    // DEC AL (334B_31A8 / 0x36658)
    AL = Alu.Dec8(AL);
    // JNZ 0x3000:663b (334B_31AA / 0x3665A)
    if(!ZeroFlag) {
      goto label_334B_318B_3663B;
    }
    // MOV CX,0x140 (334B_31AC / 0x3665C)
    CX = 0x140;
    // SUB DL,AH (334B_31AF / 0x3665F)
    // DL -= AH;
    DL = Alu.Sub8(DL, AH);
    // JBE 0x3000:6671 (334B_31B1 / 0x36661)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_31C1_36671;
    }
    label_334B_31B3_36663:
    // SUB SI,CX (334B_31B3 / 0x36663)
    SI -= CX;
    // ADD BX,CX (334B_31B5 / 0x36665)
    BX += CX;
    // DEC AH (334B_31B7 / 0x36667)
    AH = Alu.Dec8(AH);
    // JNZ 0x3000:6663 (334B_31B9 / 0x36669)
    if(!ZeroFlag) {
      goto label_334B_31B3_36663;
    }
    // MOV AX,CS:[0x3114] (334B_31BB / 0x3666B)
    AX = UInt16[cs2, 0x3114];
    // JMP 0x3000:663b (334B_31BF / 0x3666F)
    goto label_334B_318B_3663B;
    label_334B_31C1_36671:
    // SUB DI,0x280 (334B_31C1 / 0x36671)
    // DI -= 0x280;
    DI = Alu.Sub16(DI, 0x280);
    label_334B_31C5_36675:
    // MOV BX,DI (334B_31C5 / 0x36675)
    BX = DI;
    // XCHG word ptr CS:[0x3118],BX (334B_31C7 / 0x36677)
    ushort tmp_334B_31C7 = UInt16[cs2, 0x3118];
    UInt16[cs2, 0x3118] = BX;
    BX = tmp_334B_31C7;
    // XOR AX,AX (334B_31CC / 0x3667C)
    AX = 0;
    label_334B_31CE_3667E:
    // CMP BX,DI (334B_31CE / 0x3667E)
    Alu.Sub16(BX, DI);
    // JG 0x3000:6695 (334B_31D0 / 0x36680)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (334B_31E5 / 0x36695)
      return NearRet();
    }
    // MOV CX,0xa0 (334B_31D2 / 0x36682)
    CX = 0xA0;
    // XCHG DI,BP (334B_31D5 / 0x36685)
    ushort tmp_334B_31D5 = DI;
    DI = BP;
    BP = tmp_334B_31D5;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_31D7 / 0x36687)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // XCHG DI,BP (334B_31D9 / 0x36689)
    ushort tmp_334B_31D9 = DI;
    DI = BP;
    BP = tmp_334B_31D9;
    // MOV CL,0xa0 (334B_31DB / 0x3668B)
    CL = 0xA0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_31DD / 0x3668D)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // SUB DI,0x280 (334B_31DF / 0x3668F)
    // DI -= 0x280;
    DI = Alu.Sub16(DI, 0x280);
    // JMP 0x3000:667e (334B_31E3 / 0x36693)
    goto label_334B_31CE_3667E;
    label_334B_31E5_36695:
    // RET  (334B_31E5 / 0x36695)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3200_0366B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3200_366B0:
    // MOV word ptr CS:[0x2535],SI (334B_3200 / 0x366B0)
    UInt16[cs2, 0x2535] = SI;
    // MOV word ptr CS:[0x2537],DS (334B_3205 / 0x366B5)
    UInt16[cs2, 0x2537] = DS;
    // MOV word ptr CS:[0x2539],ES (334B_320A / 0x366BA)
    UInt16[cs2, 0x2539] = ES;
    // AND AX,0xfe (334B_320F / 0x366BF)
    AX &= 0xFE;
    label_334B_3212_366C2:
    // CMP AX,0x1a (334B_3212 / 0x366C2)
    Alu.Sub16(AX, 0x1A);
    // JC 0x3000:66cc (334B_3215 / 0x366C5)
    if(CarryFlag) {
      goto label_334B_321C_366CC;
    }
    // SUB AX,0x1a (334B_3217 / 0x366C7)
    // AX -= 0x1A;
    AX = Alu.Sub16(AX, 0x1A);
    // JMP 0x3000:66c2 (334B_321A / 0x366CA)
    goto label_334B_3212_366C2;
    label_334B_321C_366CC:
    // MOV BX,AX (334B_321C / 0x366CC)
    BX = AX;
    // JMP word ptr CS:[BX + 0x31e6] (334B_321E / 0x366CE)
    // Indirect jump to word ptr CS:[BX + 0x31e6], generating possible targets from emulator records
    uint targetAddress_334B_321E = (uint)(cs2 * 0x10 + UInt16[cs2, (ushort)(BX + 0x31E6)] - cs1 * 0x10);
    switch(targetAddress_334B_321E) {
      case 0x2687A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_33CA_03687A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x268D9 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3429_0368D9, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26832 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3382_036832, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26AB2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3602_036AB2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26CF1 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3841_036CF1, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26D88 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_38D8_036D88, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26E6B : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_39BB_036E6B, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26A31 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3581_036A31, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_321E));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3280_036730(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3280_36730:
    // MOV DI,0xc71c (334B_3280 / 0x36730)
    DI = 0xC71C;
    // MOV DX,0x10 (334B_3283 / 0x36733)
    DX = 0x10;
    // MOV AX,0xfefe (334B_3286 / 0x36736)
    AX = 0xFEFE;
    label_334B_3289_36739:
    // MOV CX,0x44 (334B_3289 / 0x36739)
    CX = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_328C / 0x3673C)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // ADD DI,0xb8 (334B_328E / 0x3673E)
    DI += 0xB8;
    // DEC DX (334B_3292 / 0x36742)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:6739 (334B_3293 / 0x36743)
    if(!ZeroFlag) {
      goto label_334B_3289_36739;
    }
    // MOV DX,0x8 (334B_3295 / 0x36745)
    DX = 0x8;
    // MOV AX,0xf208 (334B_3298 / 0x36748)
    AX = 0xF208;
    label_334B_329B_3674B:
    // MOV CX,0x44 (334B_329B / 0x3674B)
    CX = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_329E / 0x3674E)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // ADD DI,0xb8 (334B_32A0 / 0x36750)
    // DI += 0xB8;
    DI = Alu.Add16(DI, 0xB8);
    // XCHG AH,AL (334B_32A4 / 0x36754)
    byte tmp_334B_32A4 = AH;
    AH = AL;
    AL = tmp_334B_32A4;
    // DEC DX (334B_32A6 / 0x36756)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:674b (334B_32A7 / 0x36757)
    if(!ZeroFlag) {
      goto label_334B_329B_3674B;
    }
    // MOV DX,0x10 (334B_32A9 / 0x36759)
    DX = 0x10;
    // MOV AX,0xfefe (334B_32AC / 0x3675C)
    AX = 0xFEFE;
    label_334B_32AF_3675F:
    // MOV CX,0x44 (334B_32AF / 0x3675F)
    CX = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_32B2 / 0x36762)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // ADD DI,0xb8 (334B_32B4 / 0x36764)
    DI += 0xB8;
    // DEC DX (334B_32B8 / 0x36768)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:675f (334B_32B9 / 0x36769)
    if(!ZeroFlag) {
      goto label_334B_32AF_3675F;
    }
    // MOV DS,word ptr CS:[0x2537] (334B_32BB / 0x3676B)
    DS = UInt16[cs2, 0x2537];
    // RET  (334B_32C0 / 0x36770)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_32C1_036771(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_32C1_36771:
    // CMP CL,0x9 (334B_32C1 / 0x36771)
    Alu.Sub8(CL, 0x9);
    // JZ 0x3000:6730 (334B_32C4 / 0x36774)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3280_036730, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV word ptr CS:[0x3116],CX (334B_32C6 / 0x36776)
    UInt16[cs2, 0x3116] = CX;
    // MOV CS:[0x3114],AX (334B_32CB / 0x3677B)
    UInt16[cs2, 0x3114] = AX;
    // MOV DI,0xe01c (334B_32CF / 0x3677F)
    DI = 0xE01C;
    // LEA BP,[DI + 0xfec0] (334B_32D2 / 0x36782)
    BP = (ushort)(DI + 0xFEC0);
    // MOV CX,0x44 (334B_32D6 / 0x36786)
    CX = 0x44;
    // MOV SI,DI (334B_32D9 / 0x36789)
    SI = DI;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_32DB / 0x3678B)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADD DI,0xb8 (334B_32DD / 0x3678D)
    // DI += 0xB8;
    DI = Alu.Add16(DI, 0xB8);
    // MOV SI,DI (334B_32E1 / 0x36791)
    SI = DI;
    // MOV BX,BP (334B_32E3 / 0x36793)
    BX = BP;
    // MOV DX,0x14 (334B_32E5 / 0x36795)
    DX = 0x14;
    // JMP 0x3000:67aa (334B_32E8 / 0x36798)
    goto label_334B_32FA_367AA;
    label_334B_32EA_3679A:
    // SUB SI,0x1c8 (334B_32EA / 0x3679A)
    SI -= 0x1C8;
    // SUB DI,0x1c8 (334B_32EE / 0x3679E)
    DI -= 0x1C8;
    // ADD BX,0xb8 (334B_32F2 / 0x367A2)
    BX += 0xB8;
    // ADD BP,0xb8 (334B_32F6 / 0x367A6)
    BP += 0xB8;
    label_334B_32FA_367AA:
    // DEC DX (334B_32FA / 0x367AA)
    DX = Alu.Dec16(DX);
    // JS 0x3000:67e0 (334B_32FB / 0x367AB)
    if(SignFlag) {
      goto label_334B_3330_367E0;
    }
    // MOV CX,0x44 (334B_32FD / 0x367AD)
    CX = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3300 / 0x367B0)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // XCHG BP,DI (334B_3302 / 0x367B2)
    ushort tmp_334B_3302 = BP;
    BP = DI;
    DI = tmp_334B_3302;
    // XCHG BX,SI (334B_3304 / 0x367B4)
    ushort tmp_334B_3304 = BX;
    BX = SI;
    SI = tmp_334B_3304;
    // MOV CX,0x44 (334B_3306 / 0x367B6)
    CX = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3309 / 0x367B9)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // XCHG BP,DI (334B_330B / 0x367BB)
    ushort tmp_334B_330B = BP;
    BP = DI;
    DI = tmp_334B_330B;
    // XCHG BX,SI (334B_330D / 0x367BD)
    ushort tmp_334B_330D = BX;
    BX = SI;
    SI = tmp_334B_330D;
    // DEC AL (334B_330F / 0x367BF)
    AL = Alu.Dec8(AL);
    // JNZ 0x3000:679a (334B_3311 / 0x367C1)
    if(!ZeroFlag) {
      goto label_334B_32EA_3679A;
    }
    // MOV CX,0x140 (334B_3313 / 0x367C3)
    CX = 0x140;
    // SUB DL,AH (334B_3316 / 0x367C6)
    // DL -= AH;
    DL = Alu.Sub8(DL, AH);
    // JBE 0x3000:67d8 (334B_3318 / 0x367C8)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_3328_367D8;
    }
    label_334B_331A_367CA:
    // SUB SI,CX (334B_331A / 0x367CA)
    SI -= CX;
    // ADD BX,CX (334B_331C / 0x367CC)
    BX += CX;
    // DEC AH (334B_331E / 0x367CE)
    AH = Alu.Dec8(AH);
    // JNZ 0x3000:67ca (334B_3320 / 0x367D0)
    if(!ZeroFlag) {
      goto label_334B_331A_367CA;
    }
    // MOV AX,CS:[0x3114] (334B_3322 / 0x367D2)
    AX = UInt16[cs2, 0x3114];
    // JMP 0x3000:679a (334B_3326 / 0x367D6)
    goto label_334B_32EA_3679A;
    label_334B_3328_367D8:
    // SUB DI,0x1c8 (334B_3328 / 0x367D8)
    DI -= 0x1C8;
    // ADD BP,0xb8 (334B_332C / 0x367DC)
    // BP += 0xB8;
    BP = Alu.Add16(BP, 0xB8);
    label_334B_3330_367E0:
    // MOV BX,0xfefe (334B_3330 / 0x367E0)
    BX = 0xFEFE;
    // MOV AX,0xf208 (334B_3333 / 0x367E3)
    AX = 0xF208;
    // MOV DX,word ptr CS:[0x3116] (334B_3336 / 0x367E6)
    DX = UInt16[cs2, 0x3116];
    // CMP DX,0x9 (334B_333B / 0x367EB)
    Alu.Sub16(DX, 0x9);
    // JC 0x3000:67f6 (334B_333E / 0x367EE)
    if(CarryFlag) {
      goto label_334B_3346_367F6;
    }
    // SUB DX,0x12 (334B_3340 / 0x367F0)
    DX -= 0x12;
    // NEG DX (334B_3343 / 0x367F3)
    DX = Alu.Sub16(0, DX);
    // XCHG AX,BX (334B_3345 / 0x367F5)
    ushort tmp_334B_3345 = AX;
    AX = BX;
    BX = tmp_334B_3345;
    label_334B_3346_367F6:
    // MOV CX,0x44 (334B_3346 / 0x367F6)
    CX = 0x44;
    // XCHG AX,BX (334B_3349 / 0x367F9)
    ushort tmp_334B_3349 = AX;
    AX = BX;
    BX = tmp_334B_3349;
    // XCHG DI,BP (334B_334A / 0x367FA)
    ushort tmp_334B_334A = DI;
    DI = BP;
    BP = tmp_334B_334A;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_334C / 0x367FC)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // XCHG AX,BX (334B_334E / 0x367FE)
    ushort tmp_334B_334E = AX;
    AX = BX;
    BX = tmp_334B_334E;
    // XCHG DI,BP (334B_334F / 0x367FF)
    ushort tmp_334B_334F = DI;
    DI = BP;
    BP = tmp_334B_334F;
    // MOV CL,0x44 (334B_3351 / 0x36801)
    CL = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_3353 / 0x36803)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // XCHG AH,AL (334B_3355 / 0x36805)
    byte tmp_334B_3355 = AH;
    AH = AL;
    AL = tmp_334B_3355;
    // XCHG BH,BL (334B_3357 / 0x36807)
    byte tmp_334B_3357 = BH;
    BH = BL;
    BL = tmp_334B_3357;
    // SUB DI,0x1c8 (334B_3359 / 0x36809)
    DI -= 0x1C8;
    // ADD BP,0xb8 (334B_335D / 0x3680D)
    BP += 0xB8;
    // DEC DX (334B_3361 / 0x36811)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:67f6 (334B_3362 / 0x36812)
    if(!ZeroFlag) {
      goto label_334B_3346_367F6;
    }
    // MOV AX,0xfefe (334B_3364 / 0x36814)
    AX = 0xFEFE;
    label_334B_3367_36817:
    // MOV CL,0x44 (334B_3367 / 0x36817)
    CL = 0x44;
    // XCHG DI,BP (334B_3369 / 0x36819)
    ushort tmp_334B_3369 = DI;
    DI = BP;
    BP = tmp_334B_3369;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_336B / 0x3681B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // XCHG DI,BP (334B_336D / 0x3681D)
    ushort tmp_334B_336D = DI;
    DI = BP;
    BP = tmp_334B_336D;
    // MOV CL,0x44 (334B_336F / 0x3681F)
    CL = 0x44;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_3371 / 0x36821)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // SUB DI,0x1c8 (334B_3373 / 0x36823)
    DI -= 0x1C8;
    // ADD BP,0xb8 (334B_3377 / 0x36827)
    BP += 0xB8;
    // CMP DI,0xc6c0 (334B_337B / 0x3682B)
    Alu.Sub16(DI, 0xC6C0);
    // JNC 0x3000:6817 (334B_337F / 0x3682F)
    if(!CarryFlag) {
      goto label_334B_3367_36817;
    }
    // RET  (334B_3381 / 0x36831)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3382_036832(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3382_36832:
    // CMP CX,0x11 (334B_3382 / 0x36832)
    Alu.Sub16(CX, 0x11);
    // JNZ 0x3000:6853 (334B_3385 / 0x36835)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_33A3_036853, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH CX (334B_3387 / 0x36837)
    Stack.Push(CX);
    // PUSH SI (334B_3388 / 0x36838)
    Stack.Push(SI);
    // PUSH DS (334B_3389 / 0x36839)
    Stack.Push(DS);
    // PUSH ES (334B_338A / 0x3683A)
    Stack.Push(ES);
    // PUSH ES (334B_338B / 0x3683B)
    Stack.Push(ES);
    // PUSH SI (334B_338C / 0x3683C)
    Stack.Push(SI);
    // POP ES (334B_338D / 0x3683D)
    ES = Stack.Pop();
    // POP DS (334B_338E / 0x3683E)
    DS = Stack.Pop();
    // MOV DX,0x5c (334B_338F / 0x3683F)
    DX = 0x5C;
    // MOV BX,0x9f (334B_3392 / 0x36842)
    BX = 0x9F;
    // MOV BP,0x88 (334B_3395 / 0x36845)
    BP = 0x88;
    // MOV AX,0x29 (334B_3398 / 0x36848)
    AX = 0x29;
    // PUSH CS (334B_339B / 0x3684B)
    Stack.Push(cs2);
    // CALL 0x3000:503e (334B_339C / 0x3684C)
    NearCall(cs2, 0x339F, spice86_generated_label_call_target_334B_1B8E_03503E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_339F_03684F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_339F_03684F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_339F_3684F:
    // POP ES (334B_339F / 0x3684F)
    ES = Stack.Pop();
    // POP DS (334B_33A0 / 0x36850)
    DS = Stack.Pop();
    // POP SI (334B_33A1 / 0x36851)
    SI = Stack.Pop();
    // POP CX (334B_33A2 / 0x36852)
    CX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_334B_33A3_036853, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_33A3_036853(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_33A3_36853:
    // CMP CL,0x9 (334B_33A3 / 0x36853)
    Alu.Sub8(CL, 0x9);
    // JC 0x3000:685a (334B_33A6 / 0x36856)
    if(CarryFlag) {
      goto label_334B_33AA_3685A;
    }
    // PUSH SI (334B_33A8 / 0x36858)
    Stack.Push(SI);
    // POP DS (334B_33A9 / 0x36859)
    DS = Stack.Pop();
    label_334B_33AA_3685A:
    // PUSH CX (334B_33AA / 0x3685A)
    Stack.Push(CX);
    // MOV BX,CX (334B_33AB / 0x3685B)
    BX = CX;
    // SHL BX,1 (334B_33AD / 0x3685D)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV AX,word ptr CS:[BX + 0x30f0] (334B_33AF / 0x3685F)
    AX = UInt16[cs2, (ushort)(BX + 0x30F0)];
    // CALL 0x3000:6771 (334B_33B4 / 0x36864)
    NearCall(cs2, 0x33B7, spice86_generated_label_call_target_334B_32C1_036771);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_33B7_036867, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_33B7_036867(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_33B7_36867:
    // POP CX (334B_33B7 / 0x36867)
    CX = Stack.Pop();
    // LOOP 0x3000:6879 (334B_33B8 / 0x36868)
    if(--CX != 0) {
      // LOOP target is RETF, inlining.
      // RETF  (334B_33C9 / 0x36879)
      return FarRet();
    }
    // MOV DX,0x5c (334B_33BA / 0x3686A)
    DX = 0x5C;
    // MOV BX,0x9f (334B_33BD / 0x3686D)
    BX = 0x9F;
    // MOV BP,0x88 (334B_33C0 / 0x36870)
    BP = 0x88;
    // MOV AX,0x29 (334B_33C3 / 0x36873)
    AX = 0x29;
    // JMP 0x3000:503e (334B_33C6 / 0x36876)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_334B_33C9_36879:
    // RETF  (334B_33C9 / 0x36879)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_33CA_03687A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_33CA_3687A:
    // MOV BP,SI (334B_33CA / 0x3687A)
    BP = SI;
    // PUSH BP (334B_33CC / 0x3687C)
    Stack.Push(BP);
    // MOV DX,word ptr [BP + 0x0] (334B_33CD / 0x3687D)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x6] (334B_33D0 / 0x36880)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // SUB BX,0x2 (334B_33D3 / 0x36883)
    // BX -= 0x2;
    BX = Alu.Sub16(BX, 0x2);
    // CALL 0x3000:40c0 (334B_33D6 / 0x36886)
    NearCall(cs2, 0x33D9, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_33D9_036889, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_33D9_036889(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_33D9_36889:
    // MOV SI,DI (334B_33D9 / 0x36889)
    SI = DI;
    // MOV DX,word ptr [BP + 0x0] (334B_33DB / 0x3688B)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_33DE / 0x3688E)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // CALL 0x3000:40c0 (334B_33E1 / 0x36891)
    NearCall(cs2, 0x33E4, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_33E4_036894, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_33E4_036894(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_33E4_36894:
    // MOV DX,word ptr [BP + 0x4] (334B_33E4 / 0x36894)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // SUB DX,word ptr [BP + 0x0] (334B_33E7 / 0x36897)
    DX -= UInt16[SS, BP];
    // SHR DX,1 (334B_33EA / 0x3689A)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    // MOV BX,0x2 (334B_33EC / 0x3689C)
    BX = 0x2;
    label_334B_33EF_3689F:
    // PUSH BX (334B_33EF / 0x3689F)
    Stack.Push(BX);
    // PUSH SI (334B_33F0 / 0x368A0)
    Stack.Push(SI);
    // PUSH DI (334B_33F1 / 0x368A1)
    Stack.Push(DI);
    // MOV AX,DX (334B_33F2 / 0x368A2)
    AX = DX;
    // ADD AX,AX (334B_33F4 / 0x368A4)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    label_334B_33F6_368A6:
    // MOV CX,DX (334B_33F6 / 0x368A6)
    CX = DX;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_33F8 / 0x368A8)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // SUB SI,AX (334B_33FA / 0x368AA)
    SI -= AX;
    // SUB DI,AX (334B_33FC / 0x368AC)
    DI -= AX;
    // ADD DI,0x140 (334B_33FE / 0x368AE)
    DI += 0x140;
    // ADD SI,0x140 (334B_3402 / 0x368B2)
    SI += 0x140;
    // DEC BX (334B_3406 / 0x368B6)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:68a6 (334B_3407 / 0x368B7)
    if(!ZeroFlag) {
      goto label_334B_33F6_368A6;
    }
    // POP DI (334B_3409 / 0x368B9)
    DI = Stack.Pop();
    // POP SI (334B_340A / 0x368BA)
    SI = Stack.Pop();
    // POP BX (334B_340B / 0x368BB)
    BX = Stack.Pop();
    // ADD BX,0x2 (334B_340C / 0x368BC)
    BX += 0x2;
    // SUB SI,0x280 (334B_340F / 0x368BF)
    // SI -= 0x280;
    SI = Alu.Sub16(SI, 0x280);
    // JNC 0x3000:689f (334B_3413 / 0x368C3)
    if(!CarryFlag) {
      goto label_334B_33EF_3689F;
    }
    // POP BP (334B_3415 / 0x368C5)
    BP = Stack.Pop();
    // MOV DX,word ptr [BP + 0x0] (334B_3416 / 0x368C6)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_3419 / 0x368C9)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV AX,word ptr [BP + 0x6] (334B_341C / 0x368CC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // MOV BP,word ptr [BP + 0x4] (334B_341F / 0x368CF)
    BP = UInt16[SS, (ushort)(BP + 0x4)];
    // SUB BP,DX (334B_3422 / 0x368D2)
    BP -= DX;
    // SUB AX,BX (334B_3424 / 0x368D4)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JMP 0x3000:503e (334B_3426 / 0x368D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3429_0368D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3429_368D9:
    // MOV BP,SI (334B_3429 / 0x368D9)
    BP = SI;
    // MOV DX,word ptr [BP + 0x0] (334B_342B / 0x368DB)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_342E / 0x368DE)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // CALL 0x3000:40c0 (334B_3431 / 0x368E1)
    NearCall(cs2, 0x3434, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3434_0368E4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3434_0368E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3434_368E4:
    // MOV DX,word ptr [BP + 0x4] (334B_3434 / 0x368E4)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // SUB DX,word ptr [BP + 0x0] (334B_3437 / 0x368E7)
    DX -= UInt16[SS, BP];
    // SHR DX,1 (334B_343A / 0x368EA)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    // MOV BX,word ptr [BP + 0x6] (334B_343C / 0x368EC)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // SUB BX,word ptr [BP + 0x2] (334B_343F / 0x368EF)
    BX -= UInt16[SS, (ushort)(BP + 0x2)];
    // SUB BX,0x6 (334B_3442 / 0x368F2)
    // BX -= 0x6;
    BX = Alu.Sub16(BX, 0x6);
    label_334B_3445_368F5:
    // PUSH BX (334B_3445 / 0x368F5)
    Stack.Push(BX);
    // PUSH DI (334B_3446 / 0x368F6)
    Stack.Push(DI);
    // MOV AX,DX (334B_3447 / 0x368F7)
    AX = DX;
    // ADD AX,AX (334B_3449 / 0x368F9)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // OR BX,BX (334B_344B / 0x368FB)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x3000:6914 (334B_344D / 0x368FD)
    if(ZeroFlag) {
      goto label_334B_3464_36914;
    }
    // PUSH DS (334B_344F / 0x368FF)
    Stack.Push(DS);
    // PUSH ES (334B_3450 / 0x36900)
    Stack.Push(ES);
    // POP DS (334B_3451 / 0x36901)
    DS = Stack.Pop();
    label_334B_3452_36902:
    // MOV CX,DX (334B_3452 / 0x36902)
    CX = DX;
    // LEA SI,[DI + 0x780] (334B_3454 / 0x36904)
    SI = (ushort)(DI + 0x780);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3458 / 0x36908)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // SUB DI,AX (334B_345A / 0x3690A)
    DI -= AX;
    // ADD DI,0x140 (334B_345C / 0x3690C)
    DI += 0x140;
    // DEC BX (334B_3460 / 0x36910)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:6902 (334B_3461 / 0x36911)
    if(!ZeroFlag) {
      goto label_334B_3452_36902;
    }
    // POP DS (334B_3463 / 0x36913)
    DS = Stack.Pop();
    label_334B_3464_36914:
    // MOV BX,0x6 (334B_3464 / 0x36914)
    BX = 0x6;
    label_334B_3467_36917:
    // MOV CX,DX (334B_3467 / 0x36917)
    CX = DX;
    // MOV SI,DI (334B_3469 / 0x36919)
    SI = DI;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_346B / 0x3691B)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // SUB DI,AX (334B_346D / 0x3691D)
    DI -= AX;
    // ADD DI,0x140 (334B_346F / 0x3691F)
    DI += 0x140;
    // DEC BX (334B_3473 / 0x36923)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:6917 (334B_3474 / 0x36924)
    if(!ZeroFlag) {
      goto label_334B_3467_36917;
    }
    // POP DI (334B_3476 / 0x36926)
    DI = Stack.Pop();
    // POP BX (334B_3477 / 0x36927)
    BX = Stack.Pop();
    // SUB BX,0x6 (334B_3478 / 0x36928)
    // BX -= 0x6;
    BX = Alu.Sub16(BX, 0x6);
    // JNC 0x3000:68f5 (334B_347B / 0x3692B)
    if(!CarryFlag) {
      goto label_334B_3445_368F5;
    }
    // CMP BX,-0x6 (334B_347D / 0x3692D)
    Alu.Sub16(BX, 0xFFFA);
    // MOV BX,0x0 (334B_3480 / 0x36930)
    BX = 0x0;
    // JNZ 0x3000:68f5 (334B_3483 / 0x36933)
    if(!ZeroFlag) {
      goto label_334B_3445_368F5;
    }
    // RETF  (334B_3485 / 0x36935)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3581_036A31(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3581_36A31:
    // MOV DX,word ptr SS:[SI] (334B_3581 / 0x36A31)
    DX = UInt16[SS, SI];
    // MOV BX,word ptr SS:[SI + 0x2] (334B_3584 / 0x36A34)
    BX = UInt16[SS, (ushort)(SI + 0x2)];
    // CALL 0x3000:40c0 (334B_3588 / 0x36A38)
    NearCall(cs2, 0x358B, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_358B_036A3B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_358B_036A3B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26A56: goto label_334B_35A6_36A56;break; // Target of external jump from 0x36A74
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_358B_36A3B:
    // MOV DX,word ptr SS:[SI + 0x4] (334B_358B / 0x36A3B)
    DX = UInt16[SS, (ushort)(SI + 0x4)];
    // SUB DX,word ptr SS:[SI] (334B_358F / 0x36A3F)
    DX -= UInt16[SS, SI];
    // SHR DX,1 (334B_3592 / 0x36A42)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    // MOV BX,word ptr SS:[SI + 0x6] (334B_3594 / 0x36A44)
    BX = UInt16[SS, (ushort)(SI + 0x6)];
    // SUB BX,word ptr SS:[SI + 0x2] (334B_3598 / 0x36A48)
    BX -= UInt16[SS, (ushort)(SI + 0x2)];
    // SHR BX,1 (334B_359C / 0x36A4C)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // JZ 0x3000:6a77 (334B_359E / 0x36A4E)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      // RETF  (334B_35C7 / 0x36A77)
      return FarRet();
    }
    // PUSH word ptr [BP + 0x0] (334B_35A0 / 0x36A50)
    Stack.Push(UInt16[SS, BP]);
    label_334B_35A3_36A53:
    // MOV SI,0x2fb7 (334B_35A3 / 0x36A53)
    SI = 0x2FB7;
    label_334B_35A6_36A56:
    // LODSW CS:SI (334B_35A6 / 0x36A56)
    AX = UInt16[cs2, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (334B_35A8 / 0x36A58)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x3000:6a53 (334B_35AA / 0x36A5A)
    if(SignFlag) {
      goto label_334B_35A3_36A53;
    }
    // PUSH BX (334B_35AC / 0x36A5C)
    Stack.Push(BX);
    // PUSH CX (334B_35AD / 0x36A5D)
    Stack.Push(CX);
    // PUSH DX (334B_35AE / 0x36A5E)
    Stack.Push(DX);
    // PUSH SI (334B_35AF / 0x36A5F)
    Stack.Push(SI);
    // PUSH DI (334B_35B0 / 0x36A60)
    Stack.Push(DI);
    // PUSH BP (334B_35B1 / 0x36A61)
    Stack.Push(BP);
    // CALL 0x3000:6a78 (334B_35B2 / 0x36A62)
    NearCall(cs2, 0x35B5, spice86_generated_label_call_target_334B_35C8_036A78);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_35B5_036A65, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_35B5_036A65(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_35B5_36A65:
    // POP BP (334B_35B5 / 0x36A65)
    BP = Stack.Pop();
    // POP DI (334B_35B6 / 0x36A66)
    DI = Stack.Pop();
    // POP SI (334B_35B7 / 0x36A67)
    SI = Stack.Pop();
    // POP DX (334B_35B8 / 0x36A68)
    DX = Stack.Pop();
    // POP CX (334B_35B9 / 0x36A69)
    CX = Stack.Pop();
    // POP BX (334B_35BA / 0x36A6A)
    BX = Stack.Pop();
    // POP AX (334B_35BB / 0x36A6B)
    AX = Stack.Pop();
    // PUSH AX (334B_35BC / 0x36A6C)
    Stack.Push(AX);
    // SUB AX,word ptr [BP + 0x0] (334B_35BD / 0x36A6D)
    AX -= UInt16[SS, BP];
    // NEG AX (334B_35C0 / 0x36A70)
    AX = Alu.Sub16(0, AX);
    // CMP AX,CX (334B_35C2 / 0x36A72)
    Alu.Sub16(AX, CX);
    // JC 0x3000:6a56 (334B_35C4 / 0x36A74)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_358B_036A3B, 0x36A56 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP AX (334B_35C6 / 0x36A76)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_334B_35C7_036A77, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_35C7_036A77(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_35C7_36A77:
    // RETF  (334B_35C7 / 0x36A77)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_35C8_036A78(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_35C8_36A78:
    // MOV SI,DI (334B_35C8 / 0x36A78)
    SI = DI;
    // ADD SI,AX (334B_35CA / 0x36A7A)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    label_334B_35CC_36A7C:
    // PUSH SI (334B_35CC / 0x36A7C)
    Stack.Push(SI);
    // PUSH DI (334B_35CD / 0x36A7D)
    Stack.Push(DI);
    // MOV CX,DX (334B_35CE / 0x36A7E)
    CX = DX;
    label_334B_35D0_36A80:
    // LODSB SI (334B_35D0 / 0x36A80)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // INC SI (334B_35D1 / 0x36A81)
    SI = Alu.Inc16(SI);
    // MOV AH,AL (334B_35D2 / 0x36A82)
    AH = AL;
    // MOV word ptr ES:[DI + 0x140],AX (334B_35D4 / 0x36A84)
    UInt16[ES, (ushort)(DI + 0x140)] = AX;
    // STOSW ES:DI (334B_35D9 / 0x36A89)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x3000:6a80 (334B_35DA / 0x36A8A)
    if(--CX != 0) {
      goto label_334B_35D0_36A80;
    }
    // POP DI (334B_35DC / 0x36A8C)
    DI = Stack.Pop();
    // POP SI (334B_35DD / 0x36A8D)
    SI = Stack.Pop();
    // ADD SI,0x280 (334B_35DE / 0x36A8E)
    SI += 0x280;
    // ADD DI,0x280 (334B_35E2 / 0x36A92)
    DI += 0x280;
    // DEC BX (334B_35E6 / 0x36A96)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:6a7c (334B_35E7 / 0x36A97)
    if(!ZeroFlag) {
      goto label_334B_35CC_36A7C;
    }
    // RET  (334B_35E9 / 0x36A99)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3602_036AB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3602_36AB2:
    // PUSH DS (334B_3602 / 0x36AB2)
    Stack.Push(DS);
    // LODSW SI (334B_3603 / 0x36AB3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (334B_3604 / 0x36AB4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x3000:6aba (334B_3606 / 0x36AB6)
    if(!SignFlag) {
      goto label_334B_360A_36ABA;
    }
    // XOR AX,AX (334B_3608 / 0x36AB8)
    AX = 0;
    label_334B_360A_36ABA:
    // CMP AX,0x12c (334B_360A / 0x36ABA)
    Alu.Sub16(AX, 0x12C);
    // JC 0x3000:6ac2 (334B_360D / 0x36ABD)
    if(CarryFlag) {
      goto label_334B_3612_36AC2;
    }
    // MOV AX,0x12c (334B_360F / 0x36ABF)
    AX = 0x12C;
    label_334B_3612_36AC2:
    // MOV CS:[0x35f2],AX (334B_3612 / 0x36AC2)
    UInt16[cs2, 0x35F2] = AX;
    // PUSH AX (334B_3616 / 0x36AC6)
    Stack.Push(AX);
    // LODSW SI (334B_3617 / 0x36AC7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (334B_3618 / 0x36AC8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x3000:6ace (334B_361A / 0x36ACA)
    if(!SignFlag) {
      goto label_334B_361E_36ACE;
    }
    // XOR AX,AX (334B_361C / 0x36ACC)
    AX = 0;
    label_334B_361E_36ACE:
    // MOV CS:[0x35f4],AX (334B_361E / 0x36ACE)
    UInt16[cs2, 0x35F4] = AX;
    // PUSH AX (334B_3622 / 0x36AD2)
    Stack.Push(AX);
    // CALL 0x3000:6b60 (334B_3623 / 0x36AD3)
    NearCall(cs2, 0x3626, spice86_generated_label_call_target_334B_36B0_036B60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3626_036AD6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3626_036AD6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26AE3: goto label_334B_3633_36AE3;break; // Target of external jump from 0x36AFD
      case 0x26ADD: goto label_334B_362D_36ADD;break; // Target of external jump from 0x36B02
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_3626_36AD6:
    // POP BX (334B_3626 / 0x36AD6)
    BX = Stack.Pop();
    // POP DX (334B_3627 / 0x36AD7)
    DX = Stack.Pop();
    // PUSH ES (334B_3628 / 0x36AD8)
    Stack.Push(ES);
    // POP DS (334B_3629 / 0x36AD9)
    DS = Stack.Pop();
    // MOV CX,0x2 (334B_362A / 0x36ADA)
    CX = 0x2;
    label_334B_362D_36ADD:
    // PUSH BX (334B_362D / 0x36ADD)
    Stack.Push(BX);
    // PUSH CX (334B_362E / 0x36ADE)
    Stack.Push(CX);
    // PUSH DX (334B_362F / 0x36ADF)
    Stack.Push(DX);
    // MOV CX,0x8 (334B_3630 / 0x36AE0)
    CX = 0x8;
    label_334B_3633_36AE3:
    // PUSH BX (334B_3633 / 0x36AE3)
    Stack.Push(BX);
    // PUSH CX (334B_3634 / 0x36AE4)
    Stack.Push(CX);
    // PUSH DX (334B_3635 / 0x36AE5)
    Stack.Push(DX);
    // PUSH word ptr [BP + 0x0] (334B_3636 / 0x36AE6)
    Stack.Push(UInt16[SS, BP]);
    // CALL 0x3000:6bdd (334B_3639 / 0x36AE9)
    NearCall(cs2, 0x363C, spice86_generated_label_call_target_334B_372D_036BDD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_363C_036AEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_363C_036AEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_363C_36AEC:
    // POP BX (334B_363C / 0x36AEC)
    BX = Stack.Pop();
    // CALL 0x3000:5a22 (334B_363D / 0x36AED)
    NearCall(cs2, 0x3640, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3640_036AF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3640_036AF0(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26B07: goto label_334B_3657_36B07;break; // Target of external jump from 0x36B5C
      case 0x26B1B: goto label_334B_366B_36B1B;break; // Target of external jump from 0x36B58
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_3640_36AF0:
    // POP DX (334B_3640 / 0x36AF0)
    DX = Stack.Pop();
    // POP CX (334B_3641 / 0x36AF1)
    CX = Stack.Pop();
    // POP BX (334B_3642 / 0x36AF2)
    BX = Stack.Pop();
    // ADD DX,word ptr CS:[0x35ea] (334B_3643 / 0x36AF3)
    DX += UInt16[cs2, 0x35EA];
    // ADD BX,word ptr CS:[0x35ec] (334B_3648 / 0x36AF8)
    // BX += UInt16[cs2, 0x35EC];
    BX = Alu.Add16(BX, UInt16[cs2, 0x35EC]);
    // LOOP 0x3000:6ae3 (334B_364D / 0x36AFD)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3626_036AD6, 0x36AE3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP DX (334B_364F / 0x36AFF)
    DX = Stack.Pop();
    // POP CX (334B_3650 / 0x36B00)
    CX = Stack.Pop();
    // POP BX (334B_3651 / 0x36B01)
    BX = Stack.Pop();
    // LOOP 0x3000:6add (334B_3652 / 0x36B02)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3626_036AD6, 0x36ADD - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,0x2 (334B_3654 / 0x36B04)
    AX = 0x2;
    label_334B_3657_36B07:
    // PUSH AX (334B_3657 / 0x36B07)
    Stack.Push(AX);
    // MOV DX,word ptr CS:[0x35f6] (334B_3658 / 0x36B08)
    DX = UInt16[cs2, 0x35F6];
    // MOV BX,word ptr CS:[0x35f8] (334B_365D / 0x36B0D)
    BX = UInt16[cs2, 0x35F8];
    // MOV CX,0x14 (334B_3662 / 0x36B12)
    CX = 0x14;
    // MOV SI,0x14 (334B_3665 / 0x36B15)
    SI = 0x14;
    // MOV AX,0x8 (334B_3668 / 0x36B18)
    AX = 0x8;
    label_334B_366B_36B1B:
    // PUSH AX (334B_366B / 0x36B1B)
    Stack.Push(AX);
    // PUSH BX (334B_366C / 0x36B1C)
    Stack.Push(BX);
    // PUSH CX (334B_366D / 0x36B1D)
    Stack.Push(CX);
    // PUSH DX (334B_366E / 0x36B1E)
    Stack.Push(DX);
    // PUSH SI (334B_366F / 0x36B1F)
    Stack.Push(SI);
    // PUSH word ptr [BP + 0x0] (334B_3670 / 0x36B20)
    Stack.Push(UInt16[SS, BP]);
    // MOV word ptr CS:[0x35fa],DX (334B_3673 / 0x36B23)
    UInt16[cs2, 0x35FA] = DX;
    // MOV word ptr CS:[0x35fc],BX (334B_3678 / 0x36B28)
    UInt16[cs2, 0x35FC] = BX;
    // MOV word ptr CS:[0x35fe],CX (334B_367D / 0x36B2D)
    UInt16[cs2, 0x35FE] = CX;
    // MOV word ptr CS:[0x3600],SI (334B_3682 / 0x36B32)
    UInt16[cs2, 0x3600] = SI;
    // CALL 0x3000:6c61 (334B_3687 / 0x36B37)
    NearCall(cs2, 0x368A, spice86_generated_label_call_target_334B_37B1_036C61);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_368A_036B3A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_368A_036B3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_368A_36B3A:
    // POP BX (334B_368A / 0x36B3A)
    BX = Stack.Pop();
    // CALL 0x3000:5a22 (334B_368B / 0x36B3B)
    NearCall(cs2, 0x368E, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_368E_036B3E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_368E_036B3E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_368E_36B3E:
    // POP SI (334B_368E / 0x36B3E)
    SI = Stack.Pop();
    // POP DX (334B_368F / 0x36B3F)
    DX = Stack.Pop();
    // POP CX (334B_3690 / 0x36B40)
    CX = Stack.Pop();
    // POP BX (334B_3691 / 0x36B41)
    BX = Stack.Pop();
    // MOV AX,CS:[0x35ee] (334B_3692 / 0x36B42)
    AX = UInt16[cs2, 0x35EE];
    // SUB DX,AX (334B_3696 / 0x36B46)
    DX -= AX;
    // ADD CX,AX (334B_3698 / 0x36B48)
    CX += AX;
    // ADD CX,AX (334B_369A / 0x36B4A)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // MOV AX,CS:[0x35f0] (334B_369C / 0x36B4C)
    AX = UInt16[cs2, 0x35F0];
    // SUB BX,AX (334B_36A0 / 0x36B50)
    BX -= AX;
    // ADD SI,AX (334B_36A2 / 0x36B52)
    SI += AX;
    // ADD SI,AX (334B_36A4 / 0x36B54)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // POP AX (334B_36A6 / 0x36B56)
    AX = Stack.Pop();
    // DEC AX (334B_36A7 / 0x36B57)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:6b1b (334B_36A8 / 0x36B58)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3640_036AF0, 0x36B1B - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP AX (334B_36AA / 0x36B5A)
    AX = Stack.Pop();
    // DEC AX (334B_36AB / 0x36B5B)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:6b07 (334B_36AC / 0x36B5C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3640_036AF0, 0x36B07 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP DS (334B_36AE / 0x36B5E)
    DS = Stack.Pop();
    // RETF  (334B_36AF / 0x36B5F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_36B0_036B60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_36B0_36B60:
    // MOV AX,word ptr [DI + 0x4] (334B_36B0 / 0x36B60)
    AX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DX,word ptr [DI] (334B_36B3 / 0x36B63)
    DX = UInt16[DS, DI];
    // SUB AX,DX (334B_36B5 / 0x36B65)
    AX -= DX;
    // SUB AX,0x14 (334B_36B7 / 0x36B67)
    AX -= 0x14;
    // SHR AX,1 (334B_36BA / 0x36B6A)
    AX >>= 0x1;
    // ADD DX,AX (334B_36BC / 0x36B6C)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // MOV word ptr CS:[0x35f6],DX (334B_36BE / 0x36B6E)
    UInt16[cs2, 0x35F6] = DX;
    // SHR AX,1 (334B_36C3 / 0x36B73)
    AX >>= 0x1;
    // SHR AX,1 (334B_36C5 / 0x36B75)
    AX >>= 0x1;
    // SHR AX,1 (334B_36C7 / 0x36B77)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV CS:[0x35ee],AX (334B_36C9 / 0x36B79)
    UInt16[cs2, 0x35EE] = AX;
    // MOV AX,word ptr [DI + 0x6] (334B_36CD / 0x36B7D)
    AX = UInt16[DS, (ushort)(DI + 0x6)];
    // MOV BX,word ptr [DI + 0x2] (334B_36D0 / 0x36B80)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    // SUB AX,BX (334B_36D3 / 0x36B83)
    AX -= BX;
    // SUB AX,0x14 (334B_36D5 / 0x36B85)
    AX -= 0x14;
    // SHR AX,1 (334B_36D8 / 0x36B88)
    AX >>= 0x1;
    // ADD BX,AX (334B_36DA / 0x36B8A)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // MOV word ptr CS:[0x35f8],BX (334B_36DC / 0x36B8C)
    UInt16[cs2, 0x35F8] = BX;
    // SHR AX,1 (334B_36E1 / 0x36B91)
    AX >>= 0x1;
    // SHR AX,1 (334B_36E3 / 0x36B93)
    AX >>= 0x1;
    // SHR AX,1 (334B_36E5 / 0x36B95)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV CS:[0x35f0],AX (334B_36E7 / 0x36B97)
    UInt16[cs2, 0x35F0] = AX;
    // SUB DX,word ptr CS:[0x35f2] (334B_36EB / 0x36B9B)
    DX -= UInt16[cs2, 0x35F2];
    // SUB BX,word ptr CS:[0x35f4] (334B_36F0 / 0x36BA0)
    // BX -= UInt16[cs2, 0x35F4];
    BX = Alu.Sub16(BX, UInt16[cs2, 0x35F4]);
    // OR DX,DX (334B_36F5 / 0x36BA5)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // PUSHF  (334B_36F7 / 0x36BA7)
    Stack.Push(FlagRegister);
    // JNS 0x3000:6bac (334B_36F8 / 0x36BA8)
    if(!SignFlag) {
      goto label_334B_36FC_36BAC;
    }
    // NEG DX (334B_36FA / 0x36BAA)
    DX = Alu.Sub16(0, DX);
    label_334B_36FC_36BAC:
    // SHR DX,1 (334B_36FC / 0x36BAC)
    DX >>= 0x1;
    // SHR DX,1 (334B_36FE / 0x36BAE)
    DX >>= 0x1;
    // SHR DX,1 (334B_3700 / 0x36BB0)
    DX >>= 0x1;
    // POPF  (334B_3702 / 0x36BB2)
    FlagRegister = Stack.Pop();
    // JNS 0x3000:6bb7 (334B_3703 / 0x36BB3)
    if(!SignFlag) {
      goto label_334B_3707_36BB7;
    }
    // NEG DX (334B_3705 / 0x36BB5)
    DX = Alu.Sub16(0, DX);
    label_334B_3707_36BB7:
    // OR BX,BX (334B_3707 / 0x36BB7)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // PUSHF  (334B_3709 / 0x36BB9)
    Stack.Push(FlagRegister);
    // JNS 0x3000:6bbe (334B_370A / 0x36BBA)
    if(!SignFlag) {
      goto label_334B_370E_36BBE;
    }
    // NEG BX (334B_370C / 0x36BBC)
    BX = Alu.Sub16(0, BX);
    label_334B_370E_36BBE:
    // SHR BX,1 (334B_370E / 0x36BBE)
    BX >>= 0x1;
    // SHR BX,1 (334B_3710 / 0x36BC0)
    BX >>= 0x1;
    // SHR BX,1 (334B_3712 / 0x36BC2)
    BX >>= 0x1;
    // POPF  (334B_3714 / 0x36BC4)
    FlagRegister = Stack.Pop();
    // JNS 0x3000:6bc9 (334B_3715 / 0x36BC5)
    if(!SignFlag) {
      goto label_334B_3719_36BC9;
    }
    // NEG BX (334B_3717 / 0x36BC7)
    BX = Alu.Sub16(0, BX);
    label_334B_3719_36BC9:
    // MOV word ptr CS:[0x35ea],DX (334B_3719 / 0x36BC9)
    UInt16[cs2, 0x35EA] = DX;
    // MOV word ptr CS:[0x35ec],BX (334B_371E / 0x36BCE)
    UInt16[cs2, 0x35EC] = BX;
    // RET  (334B_3723 / 0x36BD3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_372D_036BDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_372D_36BDD:
    // MOV CX,0x14 (334B_372D / 0x36BDD)
    CX = 0x14;
    // MOV SI,0x14 (334B_3730 / 0x36BE0)
    SI = 0x14;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_3733_036BE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_334B_3733_036BE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3733_36BE3:
    // ADD SI,DX (334B_3733 / 0x36BE3)
    SI += DX;
    // ADD CX,BX (334B_3735 / 0x36BE5)
    // CX += BX;
    CX = Alu.Add16(CX, BX);
    // MOV AX,0x4 (334B_3737 / 0x36BE7)
    AX = 0x4;
    // CMP DX,AX (334B_373A / 0x36BEA)
    Alu.Sub16(DX, AX);
    // JGE 0x3000:6bf0 (334B_373C / 0x36BEC)
    if(SignFlag == OverflowFlag) {
      goto label_334B_3740_36BF0;
    }
    // MOV DX,AX (334B_373E / 0x36BEE)
    DX = AX;
    label_334B_3740_36BF0:
    // CMP SI,AX (334B_3740 / 0x36BF0)
    Alu.Sub16(SI, AX);
    // JGE 0x3000:6bf6 (334B_3742 / 0x36BF2)
    if(SignFlag == OverflowFlag) {
      goto label_334B_3746_36BF6;
    }
    // MOV SI,AX (334B_3744 / 0x36BF4)
    SI = AX;
    label_334B_3746_36BF6:
    // MOV AX,0x13c (334B_3746 / 0x36BF6)
    AX = 0x13C;
    // CMP DX,AX (334B_3749 / 0x36BF9)
    Alu.Sub16(DX, AX);
    // JLE 0x3000:6bff (334B_374B / 0x36BFB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_374F_36BFF;
    }
    // MOV DX,AX (334B_374D / 0x36BFD)
    DX = AX;
    label_334B_374F_36BFF:
    // CMP SI,AX (334B_374F / 0x36BFF)
    Alu.Sub16(SI, AX);
    // JLE 0x3000:6c05 (334B_3751 / 0x36C01)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_3755_36C05;
    }
    // MOV SI,AX (334B_3753 / 0x36C03)
    SI = AX;
    label_334B_3755_36C05:
    // MOV AX,0x4 (334B_3755 / 0x36C05)
    AX = 0x4;
    // CMP BX,AX (334B_3758 / 0x36C08)
    Alu.Sub16(BX, AX);
    // JGE 0x3000:6c0e (334B_375A / 0x36C0A)
    if(SignFlag == OverflowFlag) {
      goto label_334B_375E_36C0E;
    }
    // MOV BX,AX (334B_375C / 0x36C0C)
    BX = AX;
    label_334B_375E_36C0E:
    // CMP CX,AX (334B_375E / 0x36C0E)
    Alu.Sub16(CX, AX);
    // JGE 0x3000:6c14 (334B_3760 / 0x36C10)
    if(SignFlag == OverflowFlag) {
      goto label_334B_3764_36C14;
    }
    // MOV CX,AX (334B_3762 / 0x36C12)
    CX = AX;
    label_334B_3764_36C14:
    // MOV AX,0x94 (334B_3764 / 0x36C14)
    AX = 0x94;
    // CMP BX,AX (334B_3767 / 0x36C17)
    Alu.Sub16(BX, AX);
    // JLE 0x3000:6c1d (334B_3769 / 0x36C19)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_376D_36C1D;
    }
    // MOV BX,AX (334B_376B / 0x36C1B)
    BX = AX;
    label_334B_376D_36C1D:
    // CMP CX,AX (334B_376D / 0x36C1D)
    Alu.Sub16(CX, AX);
    // JLE 0x3000:6c23 (334B_376F / 0x36C1F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_3773_36C23;
    }
    // MOV CX,AX (334B_3771 / 0x36C21)
    CX = AX;
    label_334B_3773_36C23:
    // SUB SI,DX (334B_3773 / 0x36C23)
    SI -= DX;
    // SUB CX,BX (334B_3775 / 0x36C25)
    CX -= BX;
    // INC SI (334B_3777 / 0x36C27)
    SI++;
    // SUB CX,0x2 (334B_3778 / 0x36C28)
    // CX -= 0x2;
    CX = Alu.Sub16(CX, 0x2);
    // CALL 0x3000:40c0 (334B_377B / 0x36C2B)
    NearCall(cs2, 0x377E, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_377E_036C2E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_377E_036C2E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_377E_36C2E:
    // PUSH CX (334B_377E / 0x36C2E)
    Stack.Push(CX);
    // PUSH CX (334B_377F / 0x36C2F)
    Stack.Push(CX);
    // MOV CX,SI (334B_3780 / 0x36C30)
    CX = SI;
    // MOV AL,0xf (334B_3782 / 0x36C32)
    AL = 0xF;
    label_334B_3784_36C34:
    // XOR byte ptr [DI],AL (334B_3784 / 0x36C34)
    UInt8[DS, DI] ^= AL;
    // INC DI (334B_3786 / 0x36C36)
    DI = Alu.Inc16(DI);
    // LOOP 0x3000:6c34 (334B_3787 / 0x36C37)
    if(--CX != 0) {
      goto label_334B_3784_36C34;
    }
    // DEC DI (334B_3789 / 0x36C39)
    DI = Alu.Dec16(DI);
    // POP CX (334B_378A / 0x36C3A)
    CX = Stack.Pop();
    // OR CX,CX (334B_378B / 0x36C3B)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JLE 0x3000:6c4b (334B_378D / 0x36C3D)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_379B_36C4B;
    }
    label_334B_378F_36C3F:
    // ADD DI,0x140 (334B_378F / 0x36C3F)
    DI += 0x140;
    // XOR byte ptr [DI],AL (334B_3793 / 0x36C43)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    // LOOP 0x3000:6c3f (334B_3795 / 0x36C45)
    if(--CX != 0) {
      goto label_334B_378F_36C3F;
    }
    // ADD DI,0x140 (334B_3797 / 0x36C47)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    label_334B_379B_36C4B:
    // MOV CX,SI (334B_379B / 0x36C4B)
    CX = SI;
    label_334B_379D_36C4D:
    // XOR byte ptr [DI],AL (334B_379D / 0x36C4D)
    UInt8[DS, DI] ^= AL;
    // DEC DI (334B_379F / 0x36C4F)
    DI = Alu.Dec16(DI);
    // LOOP 0x3000:6c4d (334B_37A0 / 0x36C50)
    if(--CX != 0) {
      goto label_334B_379D_36C4D;
    }
    // INC DI (334B_37A2 / 0x36C52)
    DI = Alu.Inc16(DI);
    // POP CX (334B_37A3 / 0x36C53)
    CX = Stack.Pop();
    // OR CX,CX (334B_37A4 / 0x36C54)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JLE 0x3000:6c60 (334B_37A6 / 0x36C56)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (334B_37B0 / 0x36C60)
      return NearRet();
    }
    label_334B_37A8_36C58:
    // SUB DI,0x140 (334B_37A8 / 0x36C58)
    DI -= 0x140;
    // XOR byte ptr [DI],AL (334B_37AC / 0x36C5C)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    // LOOP 0x3000:6c58 (334B_37AE / 0x36C5E)
    if(--CX != 0) {
      goto label_334B_37A8_36C58;
    }
    label_334B_37B0_36C60:
    // RET  (334B_37B0 / 0x36C60)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_37B1_036C61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_37B1_36C61:
    // PUSH BP (334B_37B1 / 0x36C61)
    Stack.Push(BP);
    // MOV BP,CX (334B_37B2 / 0x36C62)
    BP = CX;
    // CALL 0x3000:40c0 (334B_37B4 / 0x36C64)
    NearCall(cs2, 0x37B7, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_37B7_036C67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_37B7_036C67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_37B7_36C67:
    // MOV AX,0xf0f (334B_37B7 / 0x36C67)
    AX = 0xF0F;
    // MOV CX,0x5 (334B_37BA / 0x36C6A)
    CX = 0x5;
    label_334B_37BD_36C6D:
    // XOR word ptr [DI],AX (334B_37BD / 0x36C6D)
    UInt16[DS, DI] ^= AX;
    // ADD DI,0x2 (334B_37BF / 0x36C6F)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // LOOP 0x3000:6c6d (334B_37C2 / 0x36C72)
    if(--CX != 0) {
      goto label_334B_37BD_36C6D;
    }
    // ADD DI,BP (334B_37C4 / 0x36C74)
    DI += BP;
    // SUB DI,0x14 (334B_37C6 / 0x36C76)
    // DI -= 0x14;
    DI = Alu.Sub16(DI, 0x14);
    // MOV CX,0x5 (334B_37C9 / 0x36C79)
    CX = 0x5;
    label_334B_37CC_36C7C:
    // XOR word ptr [DI],AX (334B_37CC / 0x36C7C)
    UInt16[DS, DI] ^= AX;
    // ADD DI,0x2 (334B_37CE / 0x36C7E)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // LOOP 0x3000:6c7c (334B_37D1 / 0x36C81)
    if(--CX != 0) {
      goto label_334B_37CC_36C7C;
    }
    // DEC DI (334B_37D3 / 0x36C83)
    DI = Alu.Dec16(DI);
    // MOV CX,0x9 (334B_37D4 / 0x36C84)
    CX = 0x9;
    label_334B_37D7_36C87:
    // ADD DI,0x140 (334B_37D7 / 0x36C87)
    DI += 0x140;
    // XOR byte ptr [DI],AL (334B_37DB / 0x36C8B)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    // LOOP 0x3000:6c87 (334B_37DD / 0x36C8D)
    if(--CX != 0) {
      goto label_334B_37D7_36C87;
    }
    // MOV AX,SI (334B_37DF / 0x36C8F)
    AX = SI;
    // SUB AX,0x14 (334B_37E1 / 0x36C91)
    // AX -= 0x14;
    AX = Alu.Sub16(AX, 0x14);
    // MOV CX,0x140 (334B_37E4 / 0x36C94)
    CX = 0x140;
    // IMUL CX (334B_37E7 / 0x36C97)
    Cpu.IMul16(CX);
    // ADD DI,AX (334B_37E9 / 0x36C99)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV AX,0xf0f (334B_37EB / 0x36C9B)
    AX = 0xF0F;
    // MOV CX,0x9 (334B_37EE / 0x36C9E)
    CX = 0x9;
    label_334B_37F1_36CA1:
    // ADD DI,0x140 (334B_37F1 / 0x36CA1)
    DI += 0x140;
    // XOR byte ptr [DI],AL (334B_37F5 / 0x36CA5)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    // LOOP 0x3000:6ca1 (334B_37F7 / 0x36CA7)
    if(--CX != 0) {
      goto label_334B_37F1_36CA1;
    }
    // ADD DI,0x140 (334B_37F9 / 0x36CA9)
    DI += 0x140;
    // DEC DI (334B_37FD / 0x36CAD)
    DI = Alu.Dec16(DI);
    // MOV CX,0x5 (334B_37FE / 0x36CAE)
    CX = 0x5;
    label_334B_3801_36CB1:
    // XOR word ptr [DI],AX (334B_3801 / 0x36CB1)
    UInt16[DS, DI] ^= AX;
    // SUB DI,0x2 (334B_3803 / 0x36CB3)
    // DI -= 0x2;
    DI = Alu.Sub16(DI, 0x2);
    // LOOP 0x3000:6cb1 (334B_3806 / 0x36CB6)
    if(--CX != 0) {
      goto label_334B_3801_36CB1;
    }
    // SUB DI,BP (334B_3808 / 0x36CB8)
    DI -= BP;
    // ADD DI,0x14 (334B_380A / 0x36CBA)
    // DI += 0x14;
    DI = Alu.Add16(DI, 0x14);
    // MOV CX,0x5 (334B_380D / 0x36CBD)
    CX = 0x5;
    label_334B_3810_36CC0:
    // XOR word ptr [DI],AX (334B_3810 / 0x36CC0)
    UInt16[DS, DI] ^= AX;
    // SUB DI,0x2 (334B_3812 / 0x36CC2)
    // DI -= 0x2;
    DI = Alu.Sub16(DI, 0x2);
    // LOOP 0x3000:6cc0 (334B_3815 / 0x36CC5)
    if(--CX != 0) {
      goto label_334B_3810_36CC0;
    }
    // ADD DI,0x2 (334B_3817 / 0x36CC7)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // MOV CX,0x9 (334B_381A / 0x36CCA)
    CX = 0x9;
    label_334B_381D_36CCD:
    // SUB DI,0x140 (334B_381D / 0x36CCD)
    DI -= 0x140;
    // XOR byte ptr [DI],AL (334B_3821 / 0x36CD1)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    // LOOP 0x3000:6ccd (334B_3823 / 0x36CD3)
    if(--CX != 0) {
      goto label_334B_381D_36CCD;
    }
    // MOV AX,SI (334B_3825 / 0x36CD5)
    AX = SI;
    // SUB AX,0x14 (334B_3827 / 0x36CD7)
    // AX -= 0x14;
    AX = Alu.Sub16(AX, 0x14);
    // MOV CX,0x140 (334B_382A / 0x36CDA)
    CX = 0x140;
    // IMUL CX (334B_382D / 0x36CDD)
    Cpu.IMul16(CX);
    // SUB DI,AX (334B_382F / 0x36CDF)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    // MOV AX,0xf0f (334B_3831 / 0x36CE1)
    AX = 0xF0F;
    // MOV CX,0x9 (334B_3834 / 0x36CE4)
    CX = 0x9;
    label_334B_3837_36CE7:
    // SUB DI,0x140 (334B_3837 / 0x36CE7)
    DI -= 0x140;
    // XOR byte ptr [DI],AL (334B_383B / 0x36CEB)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    // LOOP 0x3000:6ce7 (334B_383D / 0x36CED)
    if(--CX != 0) {
      goto label_334B_3837_36CE7;
    }
    // POP BP (334B_383F / 0x36CEF)
    BP = Stack.Pop();
    // RET  (334B_3840 / 0x36CF0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3841_036CF1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26CF7: goto label_334B_3847_36CF7;break; // Target of external jump from 0x36D3C
      case 0x26D0F: goto label_334B_385F_36D0F;break; // Target of external jump from 0x36D38
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_3841_36CF1:
    // PUSH DS (334B_3841 / 0x36CF1)
    Stack.Push(DS);
    // PUSH ES (334B_3842 / 0x36CF2)
    Stack.Push(ES);
    // POP DS (334B_3843 / 0x36CF3)
    DS = Stack.Pop();
    // MOV AX,0x2 (334B_3844 / 0x36CF4)
    AX = 0x2;
    label_334B_3847_36CF7:
    // PUSH AX (334B_3847 / 0x36CF7)
    Stack.Push(AX);
    // MOV DX,word ptr CS:[0x35fa] (334B_3848 / 0x36CF8)
    DX = UInt16[cs2, 0x35FA];
    // MOV BX,word ptr CS:[0x35fc] (334B_384D / 0x36CFD)
    BX = UInt16[cs2, 0x35FC];
    // MOV CX,word ptr CS:[0x35fe] (334B_3852 / 0x36D02)
    CX = UInt16[cs2, 0x35FE];
    // MOV SI,word ptr CS:[0x3600] (334B_3857 / 0x36D07)
    SI = UInt16[cs2, 0x3600];
    // MOV AX,0x8 (334B_385C / 0x36D0C)
    AX = 0x8;
    label_334B_385F_36D0F:
    // PUSH AX (334B_385F / 0x36D0F)
    Stack.Push(AX);
    // PUSH BX (334B_3860 / 0x36D10)
    Stack.Push(BX);
    // PUSH CX (334B_3861 / 0x36D11)
    Stack.Push(CX);
    // PUSH DX (334B_3862 / 0x36D12)
    Stack.Push(DX);
    // PUSH SI (334B_3863 / 0x36D13)
    Stack.Push(SI);
    // PUSH word ptr [BP + 0x0] (334B_3864 / 0x36D14)
    Stack.Push(UInt16[SS, BP]);
    // CALL 0x3000:6c61 (334B_3867 / 0x36D17)
    NearCall(cs2, 0x386A, spice86_generated_label_call_target_334B_37B1_036C61);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_386A_036D1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_386A_036D1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_386A_36D1A:
    // POP BX (334B_386A / 0x36D1A)
    BX = Stack.Pop();
    // CALL 0x3000:5a22 (334B_386B / 0x36D1B)
    NearCall(cs2, 0x386E, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_386E_036D1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_386E_036D1E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26D41: goto label_334B_3891_36D41;break; // Target of external jump from 0x36D6C
      case 0x26D4F: goto label_334B_389F_36D4F;break; // Target of external jump from 0x36D69
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_386E_36D1E:
    // POP SI (334B_386E / 0x36D1E)
    SI = Stack.Pop();
    // POP DX (334B_386F / 0x36D1F)
    DX = Stack.Pop();
    // POP CX (334B_3870 / 0x36D20)
    CX = Stack.Pop();
    // POP BX (334B_3871 / 0x36D21)
    BX = Stack.Pop();
    // MOV AX,CS:[0x35ee] (334B_3872 / 0x36D22)
    AX = UInt16[cs2, 0x35EE];
    // ADD DX,AX (334B_3876 / 0x36D26)
    DX += AX;
    // SUB CX,AX (334B_3878 / 0x36D28)
    CX -= AX;
    // SUB CX,AX (334B_387A / 0x36D2A)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    // MOV AX,CS:[0x35f0] (334B_387C / 0x36D2C)
    AX = UInt16[cs2, 0x35F0];
    // ADD BX,AX (334B_3880 / 0x36D30)
    BX += AX;
    // SUB SI,AX (334B_3882 / 0x36D32)
    SI -= AX;
    // SUB SI,AX (334B_3884 / 0x36D34)
    // SI -= AX;
    SI = Alu.Sub16(SI, AX);
    // POP AX (334B_3886 / 0x36D36)
    AX = Stack.Pop();
    // DEC AX (334B_3887 / 0x36D37)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:6d0f (334B_3888 / 0x36D38)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3841_036CF1, 0x36D0F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP AX (334B_388A / 0x36D3A)
    AX = Stack.Pop();
    // DEC AX (334B_388B / 0x36D3B)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:6cf7 (334B_388C / 0x36D3C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3841_036CF1, 0x36CF7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,0x2 (334B_388E / 0x36D3E)
    CX = 0x2;
    label_334B_3891_36D41:
    // PUSH CX (334B_3891 / 0x36D41)
    Stack.Push(CX);
    // MOV DX,word ptr CS:[0x35f6] (334B_3892 / 0x36D42)
    DX = UInt16[cs2, 0x35F6];
    // MOV BX,word ptr CS:[0x35f8] (334B_3897 / 0x36D47)
    BX = UInt16[cs2, 0x35F8];
    // MOV CX,0x8 (334B_389C / 0x36D4C)
    CX = 0x8;
    label_334B_389F_36D4F:
    // SUB DX,word ptr CS:[0x35ea] (334B_389F / 0x36D4F)
    DX -= UInt16[cs2, 0x35EA];
    // SUB BX,word ptr CS:[0x35ec] (334B_38A4 / 0x36D54)
    // BX -= UInt16[cs2, 0x35EC];
    BX = Alu.Sub16(BX, UInt16[cs2, 0x35EC]);
    // PUSH BX (334B_38A9 / 0x36D59)
    Stack.Push(BX);
    // PUSH CX (334B_38AA / 0x36D5A)
    Stack.Push(CX);
    // PUSH DX (334B_38AB / 0x36D5B)
    Stack.Push(DX);
    // PUSH word ptr [BP + 0x0] (334B_38AC / 0x36D5C)
    Stack.Push(UInt16[SS, BP]);
    // CALL 0x3000:6bdd (334B_38AF / 0x36D5F)
    NearCall(cs2, 0x38B2, spice86_generated_label_call_target_334B_372D_036BDD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_38B2_036D62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_38B2_036D62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_38B2_36D62:
    // POP BX (334B_38B2 / 0x36D62)
    BX = Stack.Pop();
    // CALL 0x3000:5a22 (334B_38B3 / 0x36D63)
    NearCall(cs2, 0x38B6, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_38B6_036D66, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_38B6_036D66(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_38B6_36D66:
    // POP DX (334B_38B6 / 0x36D66)
    DX = Stack.Pop();
    // POP CX (334B_38B7 / 0x36D67)
    CX = Stack.Pop();
    // POP BX (334B_38B8 / 0x36D68)
    BX = Stack.Pop();
    // LOOP 0x3000:6d4f (334B_38B9 / 0x36D69)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_386E_036D1E, 0x36D4F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP CX (334B_38BB / 0x36D6B)
    CX = Stack.Pop();
    // LOOP 0x3000:6d41 (334B_38BC / 0x36D6C)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_386E_036D1E, 0x36D41 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP DS (334B_38BE / 0x36D6E)
    DS = Stack.Pop();
    // RETF  (334B_38BF / 0x36D6F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_38D8_036D88(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26E20: goto label_334B_3970_36E20;break; // Target of external jump from 0x36E97
      case 0x26E2D: goto label_334B_397D_36E2D;break; // Target of external jump from 0x36E67
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_38D8_36D88:
    // LODSW SI (334B_38D8 / 0x36D88)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD AX,0x8 (334B_38D9 / 0x36D89)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    // MOV CS:[0x38c8],AX (334B_38DC / 0x36D8C)
    UInt16[cs2, 0x38C8] = AX;
    // LODSW SI (334B_38E0 / 0x36D90)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD AX,0x8 (334B_38E1 / 0x36D91)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    // MOV CS:[0x38ca],AX (334B_38E4 / 0x36D94)
    UInt16[cs2, 0x38CA] = AX;
    // MOV SI,DI (334B_38E8 / 0x36D98)
    SI = DI;
    // LODSW SI (334B_38EA / 0x36D9A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (334B_38EB / 0x36D9B)
    DX = AX;
    // LODSW SI (334B_38ED / 0x36D9D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (334B_38EE / 0x36D9E)
    BX = AX;
    // LODSW SI (334B_38F0 / 0x36DA0)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (334B_38F1 / 0x36DA1)
    CX = AX;
    // LODSW SI (334B_38F3 / 0x36DA3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV SI,AX (334B_38F4 / 0x36DA4)
    SI = AX;
    // XCHG SI,CX (334B_38F6 / 0x36DA6)
    ushort tmp_334B_38F6 = SI;
    SI = CX;
    CX = tmp_334B_38F6;
    // MOV word ptr CS:[0x38cc],DX (334B_38F8 / 0x36DA8)
    UInt16[cs2, 0x38CC] = DX;
    // MOV word ptr CS:[0x38ce],BX (334B_38FD / 0x36DAD)
    UInt16[cs2, 0x38CE] = BX;
    // MOV word ptr CS:[0x38d0],SI (334B_3902 / 0x36DB2)
    UInt16[cs2, 0x38D0] = SI;
    // MOV word ptr CS:[0x38d2],CX (334B_3907 / 0x36DB7)
    UInt16[cs2, 0x38D2] = CX;
    // SUB SI,DX (334B_390C / 0x36DBC)
    SI -= DX;
    // SHR SI,1 (334B_390E / 0x36DBE)
    SI >>= 0x1;
    // SHR SI,1 (334B_3910 / 0x36DC0)
    SI >>= 0x1;
    // SHR SI,1 (334B_3912 / 0x36DC2)
    SI >>= 0x1;
    // SHR SI,1 (334B_3914 / 0x36DC4)
    SI >>= 0x1;
    // SUB CX,BX (334B_3916 / 0x36DC6)
    CX -= BX;
    // SHR CX,1 (334B_3918 / 0x36DC8)
    CX >>= 0x1;
    // SHR CX,1 (334B_391A / 0x36DCA)
    CX >>= 0x1;
    // SHR CX,1 (334B_391C / 0x36DCC)
    CX >>= 0x1;
    // SHR CX,1 (334B_391E / 0x36DCE)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // MOV word ptr CS:[0x38c4],SI (334B_3920 / 0x36DD0)
    UInt16[cs2, 0x38C4] = SI;
    // MOV word ptr CS:[0x38c6],CX (334B_3925 / 0x36DD5)
    UInt16[cs2, 0x38C6] = CX;
    // SUB DX,word ptr CS:[0x38c8] (334B_392A / 0x36DDA)
    // DX -= UInt16[cs2, 0x38C8];
    DX = Alu.Sub16(DX, UInt16[cs2, 0x38C8]);
    // PUSHF  (334B_392F / 0x36DDF)
    Stack.Push(FlagRegister);
    // JNS 0x3000:6de4 (334B_3930 / 0x36DE0)
    if(!SignFlag) {
      goto label_334B_3934_36DE4;
    }
    // NEG DX (334B_3932 / 0x36DE2)
    DX = Alu.Sub16(0, DX);
    label_334B_3934_36DE4:
    // SHR DX,1 (334B_3934 / 0x36DE4)
    DX >>= 0x1;
    // SHR DX,1 (334B_3936 / 0x36DE6)
    DX >>= 0x1;
    // SHR DX,1 (334B_3938 / 0x36DE8)
    DX >>= 0x1;
    // SHR DX,1 (334B_393A / 0x36DEA)
    DX >>= 0x1;
    // POPF  (334B_393C / 0x36DEC)
    FlagRegister = Stack.Pop();
    // JNS 0x3000:6df1 (334B_393D / 0x36DED)
    if(!SignFlag) {
      goto label_334B_3941_36DF1;
    }
    // NEG DX (334B_393F / 0x36DEF)
    DX = Alu.Sub16(0, DX);
    label_334B_3941_36DF1:
    // MOV word ptr CS:[0x38c0],DX (334B_3941 / 0x36DF1)
    UInt16[cs2, 0x38C0] = DX;
    // SUB BX,word ptr CS:[0x38ca] (334B_3946 / 0x36DF6)
    // BX -= UInt16[cs2, 0x38CA];
    BX = Alu.Sub16(BX, UInt16[cs2, 0x38CA]);
    // PUSHF  (334B_394B / 0x36DFB)
    Stack.Push(FlagRegister);
    // JNS 0x3000:6e00 (334B_394C / 0x36DFC)
    if(!SignFlag) {
      goto label_334B_3950_36E00;
    }
    // NEG BX (334B_394E / 0x36DFE)
    BX = Alu.Sub16(0, BX);
    label_334B_3950_36E00:
    // SHR BX,1 (334B_3950 / 0x36E00)
    BX >>= 0x1;
    // SHR BX,1 (334B_3952 / 0x36E02)
    BX >>= 0x1;
    // SHR BX,1 (334B_3954 / 0x36E04)
    BX >>= 0x1;
    // SHR BX,1 (334B_3956 / 0x36E06)
    BX >>= 0x1;
    // POPF  (334B_3958 / 0x36E08)
    FlagRegister = Stack.Pop();
    // JNS 0x3000:6e0d (334B_3959 / 0x36E09)
    if(!SignFlag) {
      goto label_334B_395D_36E0D;
    }
    // NEG BX (334B_395B / 0x36E0B)
    BX = Alu.Sub16(0, BX);
    label_334B_395D_36E0D:
    // MOV word ptr CS:[0x38c2],BX (334B_395D / 0x36E0D)
    UInt16[cs2, 0x38C2] = BX;
    // MOV DX,word ptr CS:[0x38c8] (334B_3962 / 0x36E12)
    DX = UInt16[cs2, 0x38C8];
    // MOV BX,word ptr CS:[0x38ca] (334B_3967 / 0x36E17)
    BX = UInt16[cs2, 0x38CA];
    // XOR CX,CX (334B_396C / 0x36E1C)
    CX = 0;
    // XOR SI,SI (334B_396E / 0x36E1E)
    SI = 0;
    label_334B_3970_36E20:
    // PUSH DS (334B_3970 / 0x36E20)
    Stack.Push(DS);
    // PUSH ES (334B_3971 / 0x36E21)
    Stack.Push(ES);
    // POP DS (334B_3972 / 0x36E22)
    DS = Stack.Pop();
    // MOV AX,word ptr [BP + 0x0] (334B_3973 / 0x36E23)
    AX = UInt16[SS, BP];
    // MOV CS:[0x38d4],AX (334B_3976 / 0x36E26)
    UInt16[cs2, 0x38D4] = AX;
    // MOV AX,0xf (334B_397A / 0x36E2A)
    AX = 0xF;
    label_334B_397D_36E2D:
    // PUSH AX (334B_397D / 0x36E2D)
    Stack.Push(AX);
    // ADD DX,word ptr CS:[0x38c0] (334B_397E / 0x36E2E)
    DX += UInt16[cs2, 0x38C0];
    // ADD BX,word ptr CS:[0x38c2] (334B_3983 / 0x36E33)
    BX += UInt16[cs2, 0x38C2];
    // ADD SI,word ptr CS:[0x38c4] (334B_3988 / 0x36E38)
    SI += UInt16[cs2, 0x38C4];
    // ADD CX,word ptr CS:[0x38c6] (334B_398D / 0x36E3D)
    // CX += UInt16[cs2, 0x38C6];
    CX = Alu.Add16(CX, UInt16[cs2, 0x38C6]);
    // PUSH BX (334B_3992 / 0x36E42)
    Stack.Push(BX);
    // PUSH CX (334B_3993 / 0x36E43)
    Stack.Push(CX);
    // PUSH DX (334B_3994 / 0x36E44)
    Stack.Push(DX);
    // PUSH SI (334B_3995 / 0x36E45)
    Stack.Push(SI);
    // CALL 0x3000:6be3 (334B_3996 / 0x36E46)
    NearCall(cs2, 0x3999, spice86_generated_label_call_target_334B_3733_036BE3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3999_036E49, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3999_036E49(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3999_36E49:
    // MOV BX,word ptr CS:[0x38d4] (334B_3999 / 0x36E49)
    BX = UInt16[cs2, 0x38D4];
    // CALL 0x3000:5a22 (334B_399E / 0x36E4E)
    NearCall(cs2, 0x39A1, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_39A1_036E51, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_39A1_036E51(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_39A1_36E51:
    // MOV word ptr CS:[0x38d4],BX (334B_39A1 / 0x36E51)
    UInt16[cs2, 0x38D4] = BX;
    // POP SI (334B_39A6 / 0x36E56)
    SI = Stack.Pop();
    // POP DX (334B_39A7 / 0x36E57)
    DX = Stack.Pop();
    // POP CX (334B_39A8 / 0x36E58)
    CX = Stack.Pop();
    // POP BX (334B_39A9 / 0x36E59)
    BX = Stack.Pop();
    // PUSH BX (334B_39AA / 0x36E5A)
    Stack.Push(BX);
    // PUSH CX (334B_39AB / 0x36E5B)
    Stack.Push(CX);
    // PUSH DX (334B_39AC / 0x36E5C)
    Stack.Push(DX);
    // PUSH SI (334B_39AD / 0x36E5D)
    Stack.Push(SI);
    // CALL 0x3000:6be3 (334B_39AE / 0x36E5E)
    NearCall(cs2, 0x39B1, spice86_generated_label_call_target_334B_3733_036BE3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_39B1_036E61, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_39B1_036E61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_39B1_36E61:
    // POP SI (334B_39B1 / 0x36E61)
    SI = Stack.Pop();
    // POP DX (334B_39B2 / 0x36E62)
    DX = Stack.Pop();
    // POP CX (334B_39B3 / 0x36E63)
    CX = Stack.Pop();
    // POP BX (334B_39B4 / 0x36E64)
    BX = Stack.Pop();
    // POP AX (334B_39B5 / 0x36E65)
    AX = Stack.Pop();
    // DEC AX (334B_39B6 / 0x36E66)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:6e2d (334B_39B7 / 0x36E67)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_38D8_036D88, 0x36E2D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP DS (334B_39B9 / 0x36E69)
    DS = Stack.Pop();
    // RETF  (334B_39BA / 0x36E6A)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_39BB_036E6B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_39BB_36E6B:
    // MOV DX,word ptr CS:[0x38cc] (334B_39BB / 0x36E6B)
    DX = UInt16[cs2, 0x38CC];
    // MOV BX,word ptr CS:[0x38ce] (334B_39C0 / 0x36E70)
    BX = UInt16[cs2, 0x38CE];
    // MOV SI,word ptr CS:[0x38d0] (334B_39C5 / 0x36E75)
    SI = UInt16[cs2, 0x38D0];
    // MOV CX,word ptr CS:[0x38d2] (334B_39CA / 0x36E7A)
    CX = UInt16[cs2, 0x38D2];
    // SUB SI,DX (334B_39CF / 0x36E7F)
    SI -= DX;
    // SUB CX,BX (334B_39D1 / 0x36E81)
    CX -= BX;
    // NEG word ptr CS:[0x38c0] (334B_39D3 / 0x36E83)
    UInt16[cs2, 0x38C0] = Alu.Sub16(0, UInt16[cs2, 0x38C0]);
    // NEG word ptr CS:[0x38c2] (334B_39D8 / 0x36E88)
    UInt16[cs2, 0x38C2] = Alu.Sub16(0, UInt16[cs2, 0x38C2]);
    // NEG word ptr CS:[0x38c4] (334B_39DD / 0x36E8D)
    UInt16[cs2, 0x38C4] = Alu.Sub16(0, UInt16[cs2, 0x38C4]);
    // NEG word ptr CS:[0x38c6] (334B_39E2 / 0x36E92)
    UInt16[cs2, 0x38C6] = Alu.Sub16(0, UInt16[cs2, 0x38C6]);
    // JMP 0x3000:6e20 (334B_39E7 / 0x36E97)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_38D8_036D88, 0x36E20 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_334B_39E9_036E99(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_39E9_36E99:
    // PUSH AX (334B_39E9 / 0x36E99)
    Stack.Push(AX);
    // PUSH DI (334B_39EA / 0x36E9A)
    Stack.Push(DI);
    // CALL 0x3000:40c0 (334B_39EB / 0x36E9B)
    NearCall(cs2, 0x39EE, spice86_generated_label_call_target_334B_0C10_0340C0);
    // POP BX (334B_39EE / 0x36E9E)
    BX = Stack.Pop();
    // MOV DX,AX (334B_39EF / 0x36E9F)
    DX = AX;
    label_334B_39F1_36EA1:
    // SHR BP,1 (334B_39F1 / 0x36EA1)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // JNC 0x3000:6ea7 (334B_39F3 / 0x36EA3)
    if(!CarryFlag) {
      goto label_334B_39F7_36EA7;
    }
    // XOR BP,SI (334B_39F5 / 0x36EA5)
    // BP ^= SI;
    BP = Alu.Xor16(BP, SI);
    label_334B_39F7_36EA7:
    // MOV AX,BP (334B_39F7 / 0x36EA7)
    AX = BP;
    // AND AX,0x3 (334B_39F9 / 0x36EA9)
    AX &= 0x3;
    // DEC AX (334B_39FC / 0x36EAC)
    AX--;
    // ADD AL,DH (334B_39FD / 0x36EAD)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_39FF / 0x36EAF)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD DX,BX (334B_3A00 / 0x36EB0)
    // DX += BX;
    DX = Alu.Add16(DX, BX);
    // LOOP 0x3000:6ea1 (334B_3A02 / 0x36EB2)
    if(--CX != 0) {
      goto label_334B_39F1_36EA1;
    }
    // POP AX (334B_3A04 / 0x36EB4)
    AX = Stack.Pop();
    // RETF  (334B_3A05 / 0x36EB5)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3A14_036EC4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3A14_36EC4:
    // CALL 0x3000:40c0 (334B_3A14 / 0x36EC4)
    NearCall(cs2, 0x3A17, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3A17_036EC7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3A17_036EC7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3A17_36EC7:
    // MOV SI,DI (334B_3A17 / 0x36EC7)
    SI = DI;
    // MOV DI,word ptr CS:[0x1a3] (334B_3A19 / 0x36EC9)
    DI = UInt16[cs2, 0x1A3];
    // SHL BP,1 (334B_3A1E / 0x36ECE)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // JMP word ptr CS:[BP + 0x3a04] (334B_3A20 / 0x36ED0)
    // Indirect jump to word ptr CS:[BP + 0x3a04], generating possible targets from emulator records
    uint targetAddress_334B_3A20 = (uint)(cs2 * 0x10 + UInt16[cs2, (ushort)(BP + 0x3A04)] - cs1 * 0x10);
    switch(targetAddress_334B_3A20) {
      case 0x26FF6 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3B46_036FF6, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_3A20));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3B46_036FF6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_334B_3B46_36FF6:
    // MOV BX,0x26 (334B_3B46 / 0x36FF6)
    BX = 0x26;
    label_334B_3B49_36FF9:
    // MOV CX,0x50 (334B_3B49 / 0x36FF9)
    CX = 0x50;
    label_334B_3B4C_36FFC:
    // LODSB SI (334B_3B4C / 0x36FFC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV AH,AL (334B_3B4D / 0x36FFD)
    AH = AL;
    // MOV BP,0x4 (334B_3B4F / 0x36FFF)
    BP = 0x4;
    label_334B_3B52_37002:
    // STOSW ES:DI (334B_3B52 / 0x37002)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (334B_3B53 / 0x37003)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD DI,0x13c (334B_3B54 / 0x37004)
    DI += 0x13C;
    // DEC BP (334B_3B58 / 0x37008)
    BP = Alu.Dec16(BP);
    // JNZ 0x3000:7002 (334B_3B59 / 0x37009)
    if(!ZeroFlag) {
      goto label_334B_3B52_37002;
    }
    // SUB DI,0x4fc (334B_3B5B / 0x3700B)
    // DI -= 0x4FC;
    DI = Alu.Sub16(DI, 0x4FC);
    // LOOP 0x3000:6ffc (334B_3B5F / 0x3700F)
    if(--CX != 0) {
      goto label_334B_3B4C_36FFC;
    }
    // ADD SI,0xf0 (334B_3B61 / 0x37011)
    SI += 0xF0;
    // ADD DI,0x3c0 (334B_3B65 / 0x37015)
    DI += 0x3C0;
    // DEC BX (334B_3B69 / 0x37019)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:6ff9 (334B_3B6A / 0x3701A)
    if(!ZeroFlag) {
      goto label_334B_3B49_36FF9;
    }
    // RETF  (334B_3B6C / 0x3701C)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_5635_0100_056450(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0100_56450:
    // JMP 0x5000:64cb (5635_0100 / 0x56450)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_5635_017B_0564CB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_5635_0103_056453(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0103_56453:
    // JMP 0x5000:64d5 (5635_0103 / 0x56453)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_5635_0185_0564D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_5635_0109_056459(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0109_56459:
    // JMP 0x5000:64d5 (5635_0109 / 0x56459)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_5635_0185_0564D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ClearAL_5635_010C_5645C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_010C_5645C:
    // JMP 0x5000:64d5 (5635_010C / 0x5645C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_5635_0185_0564D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_5635_0115_056465(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0115_56465:
    // JMP 0x5000:64d5 (5635_0115 / 0x56465)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_5635_0185_0564D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_5635_017B_0564CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_017B_564CB:
    // PUSH CS (5635_017B / 0x564CB)
    Stack.Push(cs3);
    // CALL 0x5000:64d2 (5635_017C / 0x564CC)
    NearCall(cs3, 0x17F, PcSpeakerActivationWithALCleanup_5635_0182_564D2);
    // XOR BX,BX (5635_017F / 0x564CF)
    BX = 0;
    // RETF  (5635_0181 / 0x564D1)
    return FarRet();
  }
  
  public virtual Action PcSpeakerActivationWithALCleanup_5635_0182_564D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0182_564D2:
    // CALL 0x5000:64d8 (5635_0182 / 0x564D2)
    NearCall(cs3, 0x185, PcSpeakerActivation_5635_0188_564D8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_5635_0185_0564D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_5635_0185_0564D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0185_564D5:
    // XOR AL,AL (5635_0185 / 0x564D5)
    AL = 0;
    // RETF  (5635_0187 / 0x564D7)
    return FarRet();
  }
  
  public virtual Action PcSpeakerActivation_5635_0188_564D8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_5635_0188_564D8:
    // IN AL,0x61 (5635_0188 / 0x564D8)
    AL = Cpu.In8(0x61);
    // AND AL,0xfc (5635_018A / 0x564DA)
    // AL &= 0xFC;
    AL = Alu.And8(AL, 0xFC);
    // OUT 0x61,AL (5635_018C / 0x564DC)
    Cpu.Out8(0x61, AL);
    // RET  (5635_018E / 0x564DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0100_0564E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0100_564E0:
    // JMP 0x5000:65ab (563E_0100 / 0x564E0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_563E_01CB_0565AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0103_0564E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0103_564E3:
    // JMP 0x5000:6630 (563E_0103 / 0x564E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_0250_056630, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0106_0564E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0106_564E6:
    // JMP 0x5000:65c1 (563E_0106 / 0x564E6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_563E_01E1_0565C1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0109_0564E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0109_564E9:
    // JMP 0x5000:661b (563E_0109 / 0x564E9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_023B_05661B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_010C_0564EC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_010C_564EC:
    // JMP 0x5000:65ce (563E_010C / 0x564EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_01EE_0565CE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
