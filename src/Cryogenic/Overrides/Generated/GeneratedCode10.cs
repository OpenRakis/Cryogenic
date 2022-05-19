namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action not_observed_1000_8B10_018B10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8B10_18B10:
    // RET  (1000_8B10 / 0x18B10)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8B11_018B11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8B11_18B11:
    // PUSH SI (1000_8B11 / 0x18B11)
    Stack.Push(SI);
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
    label_1000_8B15_18B15:
    // POP SI (1000_8B15 / 0x18B15)
    SI = Stack.Pop();
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
    label_1000_8B19_18B19:
    // JC 0x1000:8b10 (1000_8B19 / 0x18B19)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_8B10 / 0x18B10)
      return NearRet();
    }
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
    label_1000_8B1E_18B1E:
    // CALL 0x1000:8df0 (1000_8B1E / 0x18B1E)
    NearCall(cs1, 0x8B21, spice86_generated_label_call_target_1000_8DF0_018DF0);
    label_1000_8B21_18B21:
    // MOV DX,word ptr [0x4791] (1000_8B21 / 0x18B21)
    DX = UInt16[DS, 0x4791];
    // MOV BX,word ptr [0x4793] (1000_8B25 / 0x18B25)
    BX = UInt16[DS, 0x4793];
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
    label_1000_8B2C_18B2C:
    // MOV BP,0xa9d0 (1000_8B2C / 0x18B2C)
    BP = 0xA9D0;
    // MOV word ptr [0x479a],0xa (1000_8B2F / 0x18B2F)
    UInt16[DS, 0x479A] = 0xA;
    // MOV AL,[0x4799] (1000_8B35 / 0x18B35)
    AL = UInt8[DS, 0x4799];
    // AND AL,0xc (1000_8B38 / 0x18B38)
    // AL &= 0xC;
    AL = Alu.And8(AL, 0xC);
    // JZ 0x1000:8b8b (1000_8B3A / 0x18B3A)
    if(ZeroFlag) {
      goto label_1000_8B8B_18B8B;
    }
    // CMP AL,0x8 (1000_8B3C / 0x18B3C)
    Alu.Sub8(AL, 0x8);
    // JNC 0x1000:8b66 (1000_8B3E / 0x18B3E)
    if(!CarryFlag) {
      goto label_1000_8B66_18B66;
    }
    // MOV BX,word ptr [BP + 0x0] (1000_8B40 / 0x18B40)
    BX = UInt16[SS, BP];
    // XOR DX,DX (1000_8B43 / 0x18B43)
    DX = 0;
    // MOV AX,[0x478d] (1000_8B45 / 0x18B45)
    AX = UInt16[DS, 0x478D];
    // SUB AX,0x8 (1000_8B48 / 0x18B48)
    AX -= 0x8;
    // DEC BX (1000_8B4B / 0x18B4B)
    BX = Alu.Dec16(BX);
    // JZ 0x1000:8b55 (1000_8B4C / 0x18B4C)
    if(ZeroFlag) {
      goto label_1000_8B55_18B55;
    }
    // DIV BX (1000_8B4E / 0x18B4E)
    Cpu.Div16(BX);
    // MOV [0x479a],AX (1000_8B50 / 0x18B50)
    UInt16[DS, 0x479A] = AX;
    // JMP 0x1000:8b8b (1000_8B53 / 0x18B53)
    goto label_1000_8B8B_18B8B;
    label_1000_8B55_18B55:
    // SHR AX,1 (1000_8B55 / 0x18B55)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV BX,AX (1000_8B57 / 0x18B57)
    BX = AX;
    // MOV DX,word ptr [0xd82c] (1000_8B59 / 0x18B59)
    DX = UInt16[DS, 0xD82C];
    // ADD BX,word ptr [0xd82e] (1000_8B5D / 0x18B5D)
    // BX += UInt16[DS, 0xD82E];
    BX = Alu.Add16(BX, UInt16[DS, 0xD82E]);
    // CALL 0x1000:d04e (1000_8B61 / 0x18B61)
    NearCall(cs1, 0x8B64, spice86_generated_label_call_target_1000_D04E_01D04E);
    // JMP 0x1000:8b8b (1000_8B64 / 0x18B64)
    goto label_1000_8B8B_18B8B;
    label_1000_8B66_18B66:
    // PUSHF  (1000_8B66 / 0x18B66)
    Stack.Push(FlagRegister);
    // MOV AX,word ptr [BP + 0x0] (1000_8B67 / 0x18B67)
    AX = UInt16[SS, BP];
    // MOV AH,0xa (1000_8B6A / 0x18B6A)
    AH = 0xA;
    // MUL AH (1000_8B6C / 0x18B6C)
    Cpu.Mul8(AH);
    // MOV BX,word ptr [0x478d] (1000_8B6E / 0x18B6E)
    BX = UInt16[DS, 0x478D];
    // SUB BX,AX (1000_8B72 / 0x18B72)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // JNC 0x1000:8b78 (1000_8B74 / 0x18B74)
    if(!CarryFlag) {
      goto label_1000_8B78_18B78;
    }
    // XOR BX,BX (1000_8B76 / 0x18B76)
    BX = 0;
    label_1000_8B78_18B78:
    // MOV [0x478d],AX (1000_8B78 / 0x18B78)
    UInt16[DS, 0x478D] = AX;
    // POPF  (1000_8B7B / 0x18B7B)
    FlagRegister = Stack.Pop();
    // JNZ 0x1000:8b80 (1000_8B7C / 0x18B7C)
    if(!ZeroFlag) {
      goto label_1000_8B80_18B80;
    }
    // SHR BX,1 (1000_8B7E / 0x18B7E)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    label_1000_8B80_18B80:
    // MOV DX,word ptr [0xd82c] (1000_8B80 / 0x18B80)
    DX = UInt16[DS, 0xD82C];
    // ADD BX,word ptr [0xd82e] (1000_8B84 / 0x18B84)
    // BX += UInt16[DS, 0xD82E];
    BX = Alu.Add16(BX, UInt16[DS, 0xD82E]);
    // CALL 0x1000:d04e (1000_8B88 / 0x18B88)
    NearCall(cs1, 0x8B8B, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_8B8B_18B8B:
    // MOV DX,word ptr [BP + 0x0] (1000_8B8B / 0x18B8B)
    DX = UInt16[SS, BP];
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
    label_1000_8B91_18B91:
    // PUSH DX (1000_8B91 / 0x18B91)
    Stack.Push(DX);
    // MOV CX,word ptr [BP + 0x0] (1000_8B92 / 0x18B92)
    CX = UInt16[SS, BP];
    // ADD BP,0x2 (1000_8B95 / 0x18B95)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    // MOV DX,word ptr [BP + 0x0] (1000_8B98 / 0x18B98)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (1000_8B9B / 0x18B9B)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // ADD BP,0x4 (1000_8B9E / 0x18B9E)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    // JCXZ 0x1000:8c0c (1000_8BA1 / 0x18BA1)
    if(CX == 0) {
      // JCXZ target is JMP, inlining.
      // JMP 0x1000:8c47 (1000_8C0C / 0x18C0C)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C47 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // TEST byte ptr [0x4799],0x2 (1000_8BA3 / 0x18BA3)
    Alu.And8(UInt8[DS, 0x4799], 0x2);
    // JZ 0x1000:8bd1 (1000_8BA8 / 0x18BA8)
    if(ZeroFlag) {
      goto label_1000_8BD1_18BD1;
    }
    // MOV AL,DL (1000_8BAA / 0x18BAA)
    AL = DL;
    // MOV DL,CL (1000_8BAC / 0x18BAC)
    DL = CL;
    // DEC DL (1000_8BAE / 0x18BAE)
    DL = Alu.Dec8(DL);
    // JZ 0x1000:8bb4 (1000_8BB0 / 0x18BB0)
    if(ZeroFlag) {
      goto label_1000_8BB4_18BB4;
    }
    // MUL DL (1000_8BB2 / 0x18BB2)
    Cpu.Mul8(DL);
    label_1000_8BB4_18BB4:
    // ADD AL,BL (1000_8BB4 / 0x18BB4)
    // AL += BL;
    AL = Alu.Add8(AL, BL);
    // MOV DL,AL (1000_8BB6 / 0x18BB6)
    DL = AL;
    // MOV AL,CL (1000_8BB8 / 0x18BB8)
    AL = CL;
    // DEC AL (1000_8BBA / 0x18BBA)
    AL--;
    // XOR AH,AH (1000_8BBC / 0x18BBC)
    AH = 0;
    // SHL AX,1 (1000_8BBE / 0x18BBE)
    AX <<= 0x1;
    // SUB DX,AX (1000_8BC0 / 0x18BC0)
    DX -= AX;
    // SHL AX,1 (1000_8BC2 / 0x18BC2)
    AX <<= 0x1;
    // SUB DX,AX (1000_8BC4 / 0x18BC4)
    DX -= AX;
    // SHR DX,1 (1000_8BC6 / 0x18BC6)
    DX >>= 0x1;
    // ADD word ptr [0xd82c],DX (1000_8BC8 / 0x18BC8)
    UInt16[DS, 0xD82C] += DX;
    // AND byte ptr [0x4799],0xfe (1000_8BCC / 0x18BCC)
    // UInt8[DS, 0x4799] &= 0xFE;
    UInt8[DS, 0x4799] = Alu.And8(UInt8[DS, 0x4799], 0xFE);
    label_1000_8BD1_18BD1:
    // POP AX (1000_8BD1 / 0x18BD1)
    AX = Stack.Pop();
    // PUSH AX (1000_8BD2 / 0x18BD2)
    Stack.Push(AX);
    // CMP AX,0x1 (1000_8BD3 / 0x18BD3)
    Alu.Sub16(AX, 0x1);
    // JZ 0x1000:8bdf (1000_8BD6 / 0x18BD6)
    if(ZeroFlag) {
      goto label_1000_8BDF_18BDF;
    }
    // TEST byte ptr [0x4799],0x1 (1000_8BD8 / 0x18BD8)
    Alu.And8(UInt8[DS, 0x4799], 0x1);
    // JNZ 0x1000:8be5 (1000_8BDD / 0x18BDD)
    if(!ZeroFlag) {
      goto label_1000_8BE5_18BE5;
    }
    label_1000_8BDF_18BDF:
    // MOV DX,0x6 (1000_8BDF / 0x18BDF)
    DX = 0x6;
    // MOV BX,0x0 (1000_8BE2 / 0x18BE2)
    BX = 0x0;
    label_1000_8BE5_18BE5:
    // MOV word ptr [0x479c],BX (1000_8BE5 / 0x18BE5)
    UInt16[DS, 0x479C] = BX;
    label_1000_8BE9_18BE9:
    // LODSB SI (1000_8BE9 / 0x18BE9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_8BEA / 0x18BEA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:8c26 (1000_8BEC / 0x18BEC)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C26 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AL,0x20 (1000_8BEE / 0x18BEE)
    Alu.Sub8(AL, 0x20);
    // JZ 0x1000:8c19 (1000_8BF0 / 0x18BF0)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C19 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AL,0xd (1000_8BF2 / 0x18BF2)
    Alu.Sub8(AL, 0xD);
    // JZ 0x1000:8c19 (1000_8BF4 / 0x18BF4)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C19 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AL,0x6 (1000_8BF6 / 0x18BF6)
    Alu.Sub8(AL, 0x6);
    // JZ 0x1000:8c0f (1000_8BF8 / 0x18BF8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AL,0x8 (1000_8BFA / 0x18BFA)
    Alu.Sub8(AL, 0x8);
    // JZ 0x1000:8c14 (1000_8BFC / 0x18BFC)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C14 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AL,0x1 (1000_8BFE / 0x18BFE)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:8c41 (1000_8C00 / 0x18C00)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8C0F_018C0F, 0x18C41 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0xdbe4] (1000_8C02 / 0x18C02)
    AX = UInt16[DS, 0xDBE4];
    // XCHG AL,AH (1000_8C05 / 0x18C05)
    byte tmp_1000_8C05 = AL;
    AL = AH;
    AH = tmp_1000_8C05;
    // MOV [0xdbe4],AX (1000_8C07 / 0x18C07)
    UInt16[DS, 0xDBE4] = AX;
    // JMP 0x1000:8be9 (1000_8C0A / 0x18C0A)
    goto label_1000_8BE9_18BE9;
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
    label_1000_8C0F_18C0F:
    // CALL 0x1000:d075 (1000_8C0F / 0x18C0F)
    NearCall(cs1, 0x8C12, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_8C12_18C12:
    // JMP 0x1000:8be9 (1000_8C12 / 0x18C12)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8C14_18C14:
    // CALL 0x1000:d068 (1000_8C14 / 0x18C14)
    NearCall(cs1, 0x8C17, spice86_generated_label_call_target_1000_D068_01D068);
    // JMP 0x1000:8be9 (1000_8C17 / 0x18C17)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8C19_18C19:
    // CMP byte ptr [SI],0x20 (1000_8C19 / 0x18C19)
    Alu.Sub8(UInt8[DS, SI], 0x20);
    // JZ 0x1000:8c23 (1000_8C1C / 0x18C1C)
    if(ZeroFlag) {
      goto label_1000_8C23_18C23;
    }
    // CMP byte ptr [SI],0xd (1000_8C1E / 0x18C1E)
    Alu.Sub8(UInt8[DS, SI], 0xD);
    // JNZ 0x1000:8c26 (1000_8C21 / 0x18C21)
    if(!ZeroFlag) {
      goto label_1000_8C26_18C26;
    }
    label_1000_8C23_18C23:
    // INC SI (1000_8C23 / 0x18C23)
    SI = Alu.Inc16(SI);
    // JMP 0x1000:8c19 (1000_8C24 / 0x18C24)
    goto label_1000_8C19_18C19;
    label_1000_8C26_18C26:
    // DEC CX (1000_8C26 / 0x18C26)
    CX = Alu.Dec16(CX);
    // JZ 0x1000:8c47 (1000_8C27 / 0x18C27)
    if(ZeroFlag) {
      goto label_1000_8C47_18C47;
    }
    // PUSH DX (1000_8C29 / 0x18C29)
    Stack.Push(DX);
    // ADD DX,word ptr [0xd82c] (1000_8C2A / 0x18C2A)
    DX += UInt16[DS, 0xD82C];
    // CMP word ptr [0x479c],0x0 (1000_8C2E / 0x18C2E)
    Alu.Sub16(UInt16[DS, 0x479C], 0x0);
    // JZ 0x1000:8c3a (1000_8C33 / 0x18C33)
    if(ZeroFlag) {
      goto label_1000_8C3A_18C3A;
    }
    // INC DX (1000_8C35 / 0x18C35)
    DX++;
    // DEC word ptr [0x479c] (1000_8C36 / 0x18C36)
    UInt16[DS, 0x479C] = Alu.Dec16(UInt16[DS, 0x479C]);
    label_1000_8C3A_18C3A:
    // MOV word ptr [0xd82c],DX (1000_8C3A / 0x18C3A)
    UInt16[DS, 0xD82C] = DX;
    // POP DX (1000_8C3E / 0x18C3E)
    DX = Stack.Pop();
    // JMP 0x1000:8be9 (1000_8C3F / 0x18C3F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
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
    label_1000_8C45_18C45:
    // JMP 0x1000:8be9 (1000_8C45 / 0x18C45)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8C47_18C47:
    // MOV DX,word ptr [0xd830] (1000_8C47 / 0x18C47)
    DX = UInt16[DS, 0xD830];
    // MOV BX,word ptr [0xd832] (1000_8C4B / 0x18C4B)
    BX = UInt16[DS, 0xD832];
    // MOV AX,[0x479a] (1000_8C4F / 0x18C4F)
    AX = UInt16[DS, 0x479A];
    // ADD BX,AX (1000_8C52 / 0x18C52)
    BX += AX;
    // SUB word ptr [0x478d],AX (1000_8C54 / 0x18C54)
    // UInt16[DS, 0x478D] -= AX;
    UInt16[DS, 0x478D] = Alu.Sub16(UInt16[DS, 0x478D], AX);
    // JNC 0x1000:8c60 (1000_8C58 / 0x18C58)
    if(!CarryFlag) {
      goto label_1000_8C60_18C60;
    }
    // MOV word ptr [0x478d],0x0 (1000_8C5A / 0x18C5A)
    UInt16[DS, 0x478D] = 0x0;
    label_1000_8C60_18C60:
    // CALL 0x1000:d04e (1000_8C60 / 0x18C60)
    NearCall(cs1, 0x8C63, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_8C63_18C63:
    // POP DX (1000_8C63 / 0x18C63)
    DX = Stack.Pop();
    // DEC DX (1000_8C64 / 0x18C64)
    DX = Alu.Dec16(DX);
    // JZ 0x1000:8c6a (1000_8C65 / 0x18C65)
    if(ZeroFlag) {
      goto label_1000_8C6A_18C6A;
    }
    // JMP 0x1000:8b91 (1000_8C67 / 0x18C67)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8B91_018B91, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8C6A_18C6A:
    // MOV DX,word ptr [0xd830] (1000_8C6A / 0x18C6A)
    DX = UInt16[DS, 0xD830];
    // MOV BX,word ptr [0xd832] (1000_8C6E / 0x18C6E)
    BX = UInt16[DS, 0xD832];
    // MOV word ptr [0x4791],DX (1000_8C72 / 0x18C72)
    UInt16[DS, 0x4791] = DX;
    // MOV word ptr [0x4793],BX (1000_8C76 / 0x18C76)
    UInt16[DS, 0x4793] = BX;
    // DEC SI (1000_8C7A / 0x18C7A)
    SI--;
    // CMP word ptr [0x479e],0x223c (1000_8C7B / 0x18C7B)
    Alu.Sub16(UInt16[DS, 0x479E], 0x223C);
    // JNZ 0x1000:8c89 (1000_8C81 / 0x18C81)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_8C89 / 0x18C89)
      return NearRet();
    }
    // CALL 0x1000:9046 (1000_8C83 / 0x18C83)
    NearCall(cs1, 0x8C86, spice86_generated_label_call_target_1000_9046_019046);
    label_1000_8C86_18C86:
    // JMP 0x1000:c07c (1000_8C86 / 0x18C86)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8C89_18C89:
    // RET  (1000_8C89 / 0x18C89)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8C8A_018C8A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8C8A_18C8A:
    // XOR AX,AX (1000_8C8A / 0x18C8A)
    AX = 0;
    // XCHG word ptr [0x479e],AX (1000_8C8C / 0x18C8C)
    ushort tmp_1000_8C8C = UInt16[DS, 0x479E];
    UInt16[DS, 0x479E] = AX;
    AX = tmp_1000_8C8C;
    // CMP AX,0x2 (1000_8C90 / 0x18C90)
    Alu.Sub16(AX, 0x2);
    // JC 0x1000:8ccc (1000_8C93 / 0x18C93)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_8CCC / 0x18CCC)
      return NearRet();
    }
    // MOV SI,0x1470 (1000_8C95 / 0x18C95)
    SI = 0x1470;
    // CMP byte ptr [0x28e7],0x0 (1000_8C98 / 0x18C98)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    // JZ 0x1000:8cb5 (1000_8C9D / 0x18C9D)
    if(ZeroFlag) {
      goto label_1000_8CB5_18CB5;
    }
    // MOV BP,0x1be2 (1000_8C9F / 0x18C9F)
    BP = 0x1BE2;
    // MOV SI,0x4c60 (1000_8CA2 / 0x18CA2)
    SI = 0x4C60;
    // MOV ES,word ptr [0xdbde] (1000_8CA5 / 0x18CA5)
    ES = UInt16[DS, 0xDBDE];
    // CALLF [0x391d] (1000_8CA9 / 0x18CA9)
    // Indirect call to [0x391d], generating possible targets from emulator records
    uint targetAddress_1000_8CA9 = (uint)(UInt16[DS, 0x391F] * 0x10 + UInt16[DS, 0x391D] - cs1 * 0x10);
    switch(targetAddress_1000_8CA9) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8CA9));
        break;
    }
    // MOV SI,0x1be2 (1000_8CAD / 0x18CAD)
    SI = 0x1BE2;
    // MOV word ptr [SI + 0x8],0x0 (1000_8CB0 / 0x18CB0)
    UInt16[DS, (ushort)(SI + 0x8)] = 0x0;
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
    label_1000_8CB8_18CB8:
    // MOV SI,word ptr [0x47c8] (1000_8CB8 / 0x18CB8)
    SI = UInt16[DS, 0x47C8];
    // OR SI,SI (1000_8CBC / 0x18CBC)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:8cc9 (1000_8CBE / 0x18CBE)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8CC9_018CC9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV word ptr [0x4540],0x0 (1000_8CC0 / 0x18CC0)
    UInt16[DS, 0x4540] = 0x0;
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
    label_1000_8CC9_18CC9:
    // CALL 0x1000:c4dd (1000_8CC9 / 0x18CC9)
    NearCall(cs1, 0x8CCC, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_8CCC_18CCC:
    // RET  (1000_8CCC / 0x18CCC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8CCD_018CCD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8CCD_18CCD:
    // MOV byte ptr [0x4799],0x9 (1000_8CCD / 0x18CCD)
    UInt8[DS, 0x4799] = 0x9;
    // MOV word ptr [0xdbe4],0xf0 (1000_8CD2 / 0x18CD2)
    UInt16[DS, 0xDBE4] = 0xF0;
    // CMP byte ptr [0x46eb],0x0 (1000_8CD8 / 0x18CD8)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JZ 0x1000:8cfb (1000_8CDD / 0x18CDD)
    if(ZeroFlag) {
      goto label_1000_8CFB_18CFB;
    }
    // CMP word ptr [0x46ef],0x0 (1000_8CDF / 0x18CDF)
    Alu.Sub16(UInt16[DS, 0x46EF], 0x0);
    // JNZ 0x1000:8cf5 (1000_8CE4 / 0x18CE4)
    if(!ZeroFlag) {
      goto label_1000_8CF5_18CF5;
    }
    // CALL 0x1000:e270 (1000_8CE6 / 0x18CE6)
    NearCall(cs1, 0x8CE9, spice86_generated_label_call_target_1000_E270_01E270);
    // PUSH ES (1000_8CE9 / 0x18CE9)
    Stack.Push(ES);
    // MOV SI,word ptr [0x46f1] (1000_8CEA / 0x18CEA)
    SI = UInt16[DS, 0x46F1];
    // CALL 0x1000:79ee (1000_8CEE / 0x18CEE)
    NearCall(cs1, 0x8CF1, spice86_generated_label_call_target_1000_79EE_0179EE);
    // POP ES (1000_8CF1 / 0x18CF1)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_8CF2 / 0x18CF2)
    NearCall(cs1, 0x8CF5, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_8CF5_18CF5:
    // MOV BP,0x2244 (1000_8CF5 / 0x18CF5)
    BP = 0x2244;
    // JMP 0x1000:8ddb (1000_8CF8 / 0x18CF8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8CFB_18CFB:
    // CMP word ptr [0x47c4],-0x1 (1000_8CFB / 0x18CFB)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xFFFF);
    // JNZ 0x1000:8d1b (1000_8D00 / 0x18D00)
    if(!ZeroFlag) {
      goto label_1000_8D1B_18D1B;
    }
    // MOV AX,0x48 (1000_8D02 / 0x18D02)
    AX = 0x48;
    // MOV [0x4784],AX (1000_8D05 / 0x18D05)
    UInt16[DS, 0x4784] = AX;
    // MOV AL,0x10 (1000_8D08 / 0x18D08)
    AL = 0x10;
    // MOV [0x4786],AX (1000_8D0A / 0x18D0A)
    UInt16[DS, 0x4786] = AX;
    // MOV AL,0x8 (1000_8D0D / 0x18D0D)
    AL = 0x8;
    // MOV [0x4788],AX (1000_8D0F / 0x18D0F)
    UInt16[DS, 0x4788] = AX;
    // MOV [0x478a],AX (1000_8D12 / 0x18D12)
    UInt16[DS, 0x478A] = AX;
    // MOV BP,0x224c (1000_8D15 / 0x18D15)
    BP = 0x224C;
    // JMP 0x1000:8ddb (1000_8D18 / 0x18D18)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8D1B_18D1B:
    // CMP byte ptr [0xc6],0x0 (1000_8D1B / 0x18D1B)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    // JZ 0x1000:8d43 (1000_8D20 / 0x18D20)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8D43_018D43, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BP,0x2265 (1000_8D22 / 0x18D22)
    BP = 0x2265;
    // MOV AX,0x3c (1000_8D25 / 0x18D25)
    AX = 0x3C;
    // MOV [0x4784],AX (1000_8D28 / 0x18D28)
    UInt16[DS, 0x4784] = AX;
    // MOV AL,0x32 (1000_8D2B / 0x18D2B)
    AL = 0x32;
    // MOV [0x4786],AX (1000_8D2D / 0x18D2D)
    UInt16[DS, 0x4786] = AX;
    // MOV AL,0xa (1000_8D30 / 0x18D30)
    AL = 0xA;
    // MOV [0x4788],AX (1000_8D32 / 0x18D32)
    UInt16[DS, 0x4788] = AX;
    // MOV [0x478a],AX (1000_8D35 / 0x18D35)
    UInt16[DS, 0x478A] = AX;
    // MOV byte ptr [0xdbe4],0x64 (1000_8D38 / 0x18D38)
    UInt8[DS, 0xDBE4] = 0x64;
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
    label_1000_8D43_18D43:
    // CMP byte ptr [0x227d],0x0 (1000_8D43 / 0x18D43)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JZ 0x1000:8d62 (1000_8D48 / 0x18D48)
    if(ZeroFlag) {
      goto label_1000_8D62_18D62;
    }
    // MOV byte ptr [0xdbe4],0x6 (1000_8D4A / 0x18D4A)
    UInt8[DS, 0xDBE4] = 0x6;
    // MOV BP,0x2275 (1000_8D4F / 0x18D4F)
    BP = 0x2275;
    // XOR AX,AX (1000_8D52 / 0x18D52)
    AX = 0;
    // MOV [0x4788],AX (1000_8D54 / 0x18D54)
    UInt16[DS, 0x4788] = AX;
    // MOV [0x478a],AX (1000_8D57 / 0x18D57)
    UInt16[DS, 0x478A] = AX;
    // MOV [0x4784],AX (1000_8D5A / 0x18D5A)
    UInt16[DS, 0x4784] = AX;
    // MOV [0x4786],AX (1000_8D5D / 0x18D5D)
    UInt16[DS, 0x4786] = AX;
    // JMP 0x1000:8ddb (1000_8D60 / 0x18D60)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8D62_18D62:
    // CMP byte ptr [0x28e7],0x0 (1000_8D62 / 0x18D62)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    // JNZ 0x1000:8d8a (1000_8D67 / 0x18D67)
    if(!ZeroFlag) {
      goto label_1000_8D8A_18D8A;
    }
    // MOV byte ptr [0x4799],0x1 (1000_8D69 / 0x18D69)
    UInt8[DS, 0x4799] = 0x1;
    // MOV byte ptr [0xdbe4],0xf (1000_8D6E / 0x18D6E)
    UInt8[DS, 0xDBE4] = 0xF;
    // MOV BP,0x223c (1000_8D73 / 0x18D73)
    BP = 0x223C;
    // XOR AX,AX (1000_8D76 / 0x18D76)
    AX = 0;
    // MOV [0x478a],AX (1000_8D78 / 0x18D78)
    UInt16[DS, 0x478A] = AX;
    // INC AX (1000_8D7B / 0x18D7B)
    AX = Alu.Inc16(AX);
    // MOV [0x4788],AX (1000_8D7C / 0x18D7C)
    UInt16[DS, 0x4788] = AX;
    // MOV AX,0x10 (1000_8D7F / 0x18D7F)
    AX = 0x10;
    // MOV [0x4784],AX (1000_8D82 / 0x18D82)
    UInt16[DS, 0x4784] = AX;
    // MOV [0x4786],AX (1000_8D85 / 0x18D85)
    UInt16[DS, 0x4786] = AX;
    // JMP 0x1000:8ddb (1000_8D88 / 0x18D88)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8D8A_18D8A:
    // MOV BP,0x2224 (1000_8D8A / 0x18D8A)
    BP = 0x2224;
    // MOV CX,0x3 (1000_8D8D / 0x18D8D)
    CX = 0x3;
    label_1000_8D90_18D90:
    // MOV AX,word ptr [BP + 0x4] (1000_8D90 / 0x18D90)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // SUB AX,word ptr [0x4784] (1000_8D93 / 0x18D93)
    AX -= UInt16[DS, 0x4784];
    // SUB AX,word ptr [0x4786] (1000_8D97 / 0x18D97)
    // AX -= UInt16[DS, 0x4786];
    AX = Alu.Sub16(AX, UInt16[DS, 0x4786]);
    // MOV [0x478f],AX (1000_8D9B / 0x18D9B)
    UInt16[DS, 0x478F] = AX;
    // PUSH SI (1000_8D9E / 0x18D9E)
    Stack.Push(SI);
    // PUSH CX (1000_8D9F / 0x18D9F)
    Stack.Push(CX);
    // CALL 0x1000:8e16 (1000_8DA0 / 0x18DA0)
    NearCall(cs1, 0x8DA3, spice86_generated_label_call_target_1000_8E16_018E16);
    // POP CX (1000_8DA3 / 0x18DA3)
    CX = Stack.Pop();
    // POP SI (1000_8DA4 / 0x18DA4)
    SI = Stack.Pop();
    // MOV AX,[0xa9d0] (1000_8DA5 / 0x18DA5)
    AX = UInt16[DS, 0xA9D0];
    // MOV AH,0xa (1000_8DA8 / 0x18DA8)
    AH = 0xA;
    // MUL AH (1000_8DAA / 0x18DAA)
    Cpu.Mul8(AH);
    // ADD AX,word ptr [0x4788] (1000_8DAC / 0x18DAC)
    AX += UInt16[DS, 0x4788];
    // ADD AX,word ptr [0x478a] (1000_8DB0 / 0x18DB0)
    AX += UInt16[DS, 0x478A];
    // CMP AX,word ptr [BP + 0x6] (1000_8DB4 / 0x18DB4)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    // JC 0x1000:8dcd (1000_8DB7 / 0x18DB7)
    if(CarryFlag) {
      goto label_1000_8DCD_18DCD;
    }
    // ADD BP,0x8 (1000_8DB9 / 0x18DB9)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    // LOOP 0x1000:8d90 (1000_8DBC / 0x18DBC)
    if(--CX != 0) {
      goto label_1000_8D90_18D90;
    }
    // SUB BP,0x8 (1000_8DBE / 0x18DBE)
    BP -= 0x8;
    // XOR AX,AX (1000_8DC1 / 0x18DC1)
    AX = 0;
    // MOV [0x4788],AX (1000_8DC3 / 0x18DC3)
    UInt16[DS, 0x4788] = AX;
    // XCHG word ptr [0x478a],AX (1000_8DC6 / 0x18DC6)
    ushort tmp_1000_8DC6 = UInt16[DS, 0x478A];
    UInt16[DS, 0x478A] = AX;
    AX = tmp_1000_8DC6;
    // OR AX,AX (1000_8DCA / 0x18DCA)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // RET  (1000_8DCC / 0x18DCC)
    return NearRet();
    label_1000_8DCD_18DCD:
    // DEC CX (1000_8DCD / 0x18DCD)
    CX = Alu.Dec16(CX);
    // JZ 0x1000:8dee (1000_8DCE / 0x18DCE)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0x18DEE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BX,0x1 (1000_8DD0 / 0x18DD0)
    BX = 0x1;
    // CALL 0x1000:e3b7 (1000_8DD3 / 0x18DD3)
    NearCall(cs1, 0x8DD6, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // JZ 0x1000:8dee (1000_8DD6 / 0x18DD6)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8DDB_018DDB, 0x18DEE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
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
    label_1000_8DDB_18DDB:
    // MOV AX,word ptr [BP + 0x4] (1000_8DDB / 0x18DDB)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // SUB AX,word ptr [0x4784] (1000_8DDE / 0x18DDE)
    AX -= UInt16[DS, 0x4784];
    // SUB AX,word ptr [0x4786] (1000_8DE2 / 0x18DE2)
    // AX -= UInt16[DS, 0x4786];
    AX = Alu.Sub16(AX, UInt16[DS, 0x4786]);
    // MOV [0x478f],AX (1000_8DE6 / 0x18DE6)
    UInt16[DS, 0x478F] = AX;
    // PUSH SI (1000_8DE9 / 0x18DE9)
    Stack.Push(SI);
    // CALL 0x1000:8e16 (1000_8DEA / 0x18DEA)
    NearCall(cs1, 0x8DED, spice86_generated_label_call_target_1000_8E16_018E16);
    label_1000_8DED_18DED:
    // POP SI (1000_8DED / 0x18DED)
    SI = Stack.Pop();
    label_1000_8DEE_18DEE:
    // CLC  (1000_8DEE / 0x18DEE)
    CarryFlag = false;
    // RET  (1000_8DEF / 0x18DEF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8DF0_018DF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8DF0_18DF0:
    // TEST byte ptr [0x4799],0x1 (1000_8DF0 / 0x18DF0)
    Alu.And8(UInt8[DS, 0x4799], 0x1);
    // JZ 0x1000:8e15 (1000_8DF5 / 0x18DF5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_8E15 / 0x18E15)
      return NearRet();
    }
    // PUSH SI (1000_8DF7 / 0x18DF7)
    Stack.Push(SI);
    // MOV SI,0xa9d0 (1000_8DF8 / 0x18DF8)
    SI = 0xA9D0;
    // LODSW SI (1000_8DFB / 0x18DFB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_8DFC / 0x18DFC)
    CX = AX;
    label_1000_8DFE_18DFE:
    // LODSW SI (1000_8DFE / 0x18DFE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_8DFF / 0x18DFF)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:8e08 (1000_8E01 / 0x18E01)
    if(ZeroFlag) {
      goto label_1000_8E08_18E08;
    }
    // CMP word ptr [SI],0x1e (1000_8E03 / 0x18E03)
    Alu.Sub16(UInt16[DS, SI], 0x1E);
    // JNC 0x1000:8e0f (1000_8E06 / 0x18E06)
    if(!CarryFlag) {
      goto label_1000_8E0F_18E0F;
    }
    label_1000_8E08_18E08:
    // ADD SI,0x4 (1000_8E08 / 0x18E08)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LOOP 0x1000:8dfe (1000_8E0B / 0x18E0B)
    if(--CX != 0) {
      goto label_1000_8DFE_18DFE;
    }
    // POP SI (1000_8E0D / 0x18E0D)
    SI = Stack.Pop();
    // RET  (1000_8E0E / 0x18E0E)
    return NearRet();
    label_1000_8E0F_18E0F:
    // AND byte ptr [0x4799],0xfe (1000_8E0F / 0x18E0F)
    // UInt8[DS, 0x4799] &= 0xFE;
    UInt8[DS, 0x4799] = Alu.And8(UInt8[DS, 0x4799], 0xFE);
    // POP SI (1000_8E14 / 0x18E14)
    SI = Stack.Pop();
    label_1000_8E15_18E15:
    // RET  (1000_8E15 / 0x18E15)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8E16_018E16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8E16_18E16:
    // PUSH DS (1000_8E16 / 0x18E16)
    Stack.Push(DS);
    // POP ES (1000_8E17 / 0x18E17)
    ES = Stack.Pop();
    // MOV byte ptr [0x478c],0x0 (1000_8E18 / 0x18E18)
    UInt8[DS, 0x478C] = 0x0;
    // MOV DI,0xa9d2 (1000_8E1D / 0x18E1D)
    DI = 0xA9D2;
    // XOR DH,DH (1000_8E20 / 0x18E20)
    DH = 0;
    // MOV BX,word ptr [0x478f] (1000_8E22 / 0x18E22)
    BX = UInt16[DS, 0x478F];
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
    label_1000_8E28_18E28:
    // MOV AL,byte ptr [SI] (1000_8E28 / 0x18E28)
    AL = UInt8[DS, SI];
    // OR AL,AL (1000_8E2A / 0x18E2A)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:8e74 (1000_8E2C / 0x18E2C)
    if(SignFlag) {
      goto label_1000_8E74_18E74;
    }
    // CMP AL,0xd (1000_8E2E / 0x18E2E)
    Alu.Sub8(AL, 0xD);
    // JZ 0x1000:8e39 (1000_8E30 / 0x18E30)
    if(ZeroFlag) {
      goto label_1000_8E39_18E39;
    }
    // CMP AL,0x20 (1000_8E32 / 0x18E32)
    Alu.Sub8(AL, 0x20);
    // JNZ 0x1000:8e4b (1000_8E34 / 0x18E34)
    if(!ZeroFlag) {
      goto label_1000_8E4B_18E4B;
    }
    // INC SI (1000_8E36 / 0x18E36)
    SI = Alu.Inc16(SI);
    // JMP 0x1000:8e28 (1000_8E37 / 0x18E37)
    goto label_1000_8E28_18E28;
    label_1000_8E39_18E39:
    // CALL 0x1000:8e9e (1000_8E39 / 0x18E39)
    NearCall(cs1, 0x8E3C, spice86_generated_label_call_target_1000_8E9E_018E9E);
    label_1000_8E3C_18E3C:
    // MOV word ptr [DI + -0x4],0x6 (1000_8E3C / 0x18E3C)
    UInt16[DS, (ushort)(DI - 0x4)] = 0x6;
    // MOV word ptr [DI + -0x2],0x0 (1000_8E41 / 0x18E41)
    UInt16[DS, (ushort)(DI - 0x2)] = 0x0;
    // XOR DL,DL (1000_8E46 / 0x18E46)
    DL = 0;
    // INC SI (1000_8E48 / 0x18E48)
    SI = Alu.Inc16(SI);
    // JMP 0x1000:8e28 (1000_8E49 / 0x18E49)
    goto label_1000_8E28_18E28;
    label_1000_8E4B_18E4B:
    // CALL 0x1000:8ed3 (1000_8E4B / 0x18E4B)
    NearCall(cs1, 0x8E4E, spice86_generated_label_call_target_1000_8ED3_018ED3);
    label_1000_8E4E_18E4E:
    // OR CX,CX (1000_8E4E / 0x18E4E)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JZ 0x1000:8e28 (1000_8E50 / 0x18E50)
    if(ZeroFlag) {
      goto label_1000_8E28_18E28;
    }
    // ADD CX,0x6 (1000_8E52 / 0x18E52)
    CX += 0x6;
    label_1000_8E55_18E55:
    // SUB BX,CX (1000_8E55 / 0x18E55)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // JC 0x1000:8e5d (1000_8E57 / 0x18E57)
    if(CarryFlag) {
      goto label_1000_8E5D_18E5D;
    }
    // INC DL (1000_8E59 / 0x18E59)
    DL = Alu.Inc8(DL);
    // JMP 0x1000:8e28 (1000_8E5B / 0x18E5B)
    goto label_1000_8E28_18E28;
    label_1000_8E5D_18E5D:
    // ADD BX,0x6 (1000_8E5D / 0x18E5D)
    // BX += 0x6;
    BX = Alu.Add16(BX, 0x6);
    // JS 0x1000:8e69 (1000_8E60 / 0x18E60)
    if(SignFlag) {
      goto label_1000_8E69_18E69;
    }
    // INC DL (1000_8E62 / 0x18E62)
    DL = Alu.Inc8(DL);
    // CALL 0x1000:8e9e (1000_8E64 / 0x18E64)
    NearCall(cs1, 0x8E67, spice86_generated_label_call_target_1000_8E9E_018E9E);
    label_1000_8E67_18E67:
    // JMP 0x1000:8e28 (1000_8E67 / 0x18E67)
    goto label_1000_8E28_18E28;
    label_1000_8E69_18E69:
    // OR DL,DL (1000_8E69 / 0x18E69)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:8e97 (1000_8E6B / 0x18E6B)
    if(ZeroFlag) {
      goto label_1000_8E97_18E97;
    }
    // ADD BX,CX (1000_8E6D / 0x18E6D)
    // BX += CX;
    BX = Alu.Add16(BX, CX);
    // CALL 0x1000:8e9e (1000_8E6F / 0x18E6F)
    NearCall(cs1, 0x8E72, spice86_generated_label_call_target_1000_8E9E_018E9E);
    label_1000_8E72_18E72:
    // JMP 0x1000:8e55 (1000_8E72 / 0x18E72)
    goto label_1000_8E55_18E55;
    label_1000_8E74_18E74:
    // OR DL,DL (1000_8E74 / 0x18E74)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:8e7b (1000_8E76 / 0x18E76)
    if(ZeroFlag) {
      goto label_1000_8E7B_18E7B;
    }
    // CALL 0x1000:8e9e (1000_8E78 / 0x18E78)
    NearCall(cs1, 0x8E7B, spice86_generated_label_call_target_1000_8E9E_018E9E);
    label_1000_8E7B_18E7B:
    // MOV word ptr [DI + -0x4],0x6 (1000_8E7B / 0x18E7B)
    UInt16[DS, (ushort)(DI - 0x4)] = 0x6;
    // MOV word ptr [DI + -0x2],0x0 (1000_8E80 / 0x18E80)
    UInt16[DS, (ushort)(DI - 0x2)] = 0x0;
    // MOV word ptr [DI],0x0 (1000_8E85 / 0x18E85)
    UInt16[DS, DI] = 0x0;
    // MOV word ptr [DI + 0x2],0x0 (1000_8E89 / 0x18E89)
    UInt16[DS, (ushort)(DI + 0x2)] = 0x0;
    // XOR DL,DL (1000_8E8E / 0x18E8E)
    DL = 0;
    // XCHG DL,DH (1000_8E90 / 0x18E90)
    byte tmp_1000_8E90 = DL;
    DL = DH;
    DH = tmp_1000_8E90;
    // MOV word ptr [0xa9d0],DX (1000_8E92 / 0x18E92)
    UInt16[DS, 0xA9D0] = DX;
    // RET  (1000_8E96 / 0x18E96)
    return NearRet();
    label_1000_8E97_18E97:
    // MOV word ptr [0xa9d0],0xc8 (1000_8E97 / 0x18E97)
    UInt16[DS, 0xA9D0] = 0xC8;
    // RET  (1000_8E9D / 0x18E9D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8E9E_018E9E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8E9E_18E9E:
    // MOV AX,DX (1000_8E9E / 0x18E9E)
    AX = DX;
    // XOR AH,AH (1000_8EA0 / 0x18EA0)
    AH = 0;
    // STOSW ES:DI (1000_8EA2 / 0x18EA2)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD byte ptr [0x478c],AL (1000_8EA3 / 0x18EA3)
    // UInt8[DS, 0x478C] += AL;
    UInt8[DS, 0x478C] = Alu.Add8(UInt8[DS, 0x478C], AL);
    // OR AX,AX (1000_8EA7 / 0x18EA7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:8eca (1000_8EA9 / 0x18EA9)
    if(ZeroFlag) {
      goto label_1000_8ECA_18ECA;
    }
    // PUSH DX (1000_8EAB / 0x18EAB)
    Stack.Push(DX);
    // MOV AX,BX (1000_8EAC / 0x18EAC)
    AX = BX;
    // MOV BX,DX (1000_8EAE / 0x18EAE)
    BX = DX;
    // XOR BH,BH (1000_8EB0 / 0x18EB0)
    BH = 0;
    // XOR DX,DX (1000_8EB2 / 0x18EB2)
    DX = 0;
    // DEC BX (1000_8EB4 / 0x18EB4)
    BX = Alu.Dec16(BX);
    // JZ 0x1000:8eb9 (1000_8EB5 / 0x18EB5)
    if(ZeroFlag) {
      goto label_1000_8EB9_18EB9;
    }
    // DIV BX (1000_8EB7 / 0x18EB7)
    Cpu.Div16(BX);
    label_1000_8EB9_18EB9:
    // ADD AX,0x6 (1000_8EB9 / 0x18EB9)
    // AX += 0x6;
    AX = Alu.Add16(AX, 0x6);
    // STOSW ES:DI (1000_8EBC / 0x18EBC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AX,DX (1000_8EBD / 0x18EBD)
    AX = DX;
    // STOSW ES:DI (1000_8EBF / 0x18EBF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // POP DX (1000_8EC0 / 0x18EC0)
    DX = Stack.Pop();
    // INC DH (1000_8EC1 / 0x18EC1)
    DH++;
    // XOR DL,DL (1000_8EC3 / 0x18EC3)
    DL = 0;
    // MOV BX,word ptr [0x478f] (1000_8EC5 / 0x18EC5)
    BX = UInt16[DS, 0x478F];
    // RET  (1000_8EC9 / 0x18EC9)
    return NearRet();
    label_1000_8ECA_18ECA:
    // STOSW ES:DI (1000_8ECA / 0x18ECA)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_8ECB / 0x18ECB)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // INC DH (1000_8ECC / 0x18ECC)
    DH = Alu.Inc8(DH);
    // MOV BX,word ptr [0x478f] (1000_8ECE / 0x18ECE)
    BX = UInt16[DS, 0x478F];
    // RET  (1000_8ED2 / 0x18ED2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8ED3_018ED3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8ED3_18ED3:
    // XOR CX,CX (1000_8ED3 / 0x18ED3)
    CX = 0;
    // PUSH BX (1000_8ED5 / 0x18ED5)
    Stack.Push(BX);
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
    label_1000_8EDA_18EDA:
    // LODSB SI (1000_8EDA / 0x18EDA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0x20 (1000_8EDB / 0x18EDB)
    Alu.Sub8(AL, 0x20);
    // JZ 0x1000:8f25 (1000_8EDD / 0x18EDD)
    if(ZeroFlag) {
      goto label_1000_8F25_18F25;
    }
    // CMP AL,0xd (1000_8EDF / 0x18EDF)
    Alu.Sub8(AL, 0xD);
    // JZ 0x1000:8f25 (1000_8EE1 / 0x18EE1)
    if(ZeroFlag) {
      goto label_1000_8F25_18F25;
    }
    // OR AL,AL (1000_8EE3 / 0x18EE3)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:8eed (1000_8EE5 / 0x18EE5)
    if(ZeroFlag) {
      goto label_1000_8EED_18EED;
    }
    // CMP AL,0x9 (1000_8EE7 / 0x18EE7)
    Alu.Sub8(AL, 0x9);
    // JC 0x1000:8f09 (1000_8EE9 / 0x18EE9)
    if(CarryFlag) {
      goto label_1000_8F09_18F09;
    }
    // JS 0x1000:8f25 (1000_8EEB / 0x18EEB)
    if(SignFlag) {
      goto label_1000_8F25_18F25;
    }
    label_1000_8EED_18EED:
    // CMP word ptr [0x2518],0xd0ff (1000_8EED / 0x18EED)
    Alu.Sub16(UInt16[DS, 0x2518], 0xD0FF);
    // JNZ 0x1000:8f04 (1000_8EF3 / 0x18EF3)
    if(!ZeroFlag) {
      goto label_1000_8F04_18F04;
    }
    // CMP SI,0xa6b1 (1000_8EF5 / 0x18EF5)
    Alu.Sub16(SI, 0xA6B1);
    // JNZ 0x1000:8f04 (1000_8EF9 / 0x18EF9)
    if(!ZeroFlag) {
      goto label_1000_8F04_18F04;
    }
    // CALL 0x1000:d0e3 (1000_8EFB / 0x18EFB)
    NearCall(cs1, 0x8EFE, spice86_generated_label_call_target_1000_D0E3_01D0E3);
    label_1000_8EFE_18EFE:
    // JC 0x1000:8f04 (1000_8EFE / 0x18EFE)
    if(CarryFlag) {
      goto label_1000_8F04_18F04;
    }
    // ADD CL,AL (1000_8F00 / 0x18F00)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    // JMP 0x1000:8eda (1000_8F02 / 0x18F02)
    goto label_1000_8EDA_18EDA;
    label_1000_8F04_18F04:
    // XLAT BX (1000_8F04 / 0x18F04)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // ADD CL,AL (1000_8F05 / 0x18F05)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    // JMP 0x1000:8eda (1000_8F07 / 0x18F07)
    goto label_1000_8EDA_18EDA;
    label_1000_8F09_18F09:
    // CMP AL,0xd (1000_8F09 / 0x18F09)
    Alu.Sub8(AL, 0xD);
    // JZ 0x1000:8f25 (1000_8F0B / 0x18F0B)
    if(ZeroFlag) {
      goto label_1000_8F25_18F25;
    }
    // CMP AL,0x6 (1000_8F0D / 0x18F0D)
    Alu.Sub8(AL, 0x6);
    // JZ 0x1000:8f1d (1000_8F0F / 0x18F0F)
    if(ZeroFlag) {
      goto label_1000_8F1D_18F1D;
    }
    // CMP AL,0x8 (1000_8F11 / 0x18F11)
    Alu.Sub8(AL, 0x8);
    // JNZ 0x1000:8eda (1000_8F13 / 0x18F13)
    if(!ZeroFlag) {
      goto label_1000_8EDA_18EDA;
    }
    // MOV word ptr [0x47a0],0xceec (1000_8F15 / 0x18F15)
    UInt16[DS, 0x47A0] = 0xCEEC;
    // JMP 0x1000:8eda (1000_8F1B / 0x18F1B)
    goto label_1000_8EDA_18EDA;
    label_1000_8F1D_18F1D:
    // MOV word ptr [0x47a0],0xcf6c (1000_8F1D / 0x18F1D)
    UInt16[DS, 0x47A0] = 0xCF6C;
    // JMP 0x1000:8eda (1000_8F23 / 0x18F23)
    goto label_1000_8EDA_18EDA;
    label_1000_8F25_18F25:
    // DEC SI (1000_8F25 / 0x18F25)
    SI = Alu.Dec16(SI);
    // POP BX (1000_8F26 / 0x18F26)
    BX = Stack.Pop();
    // RET  (1000_8F27 / 0x18F27)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8F28_018F28(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8F28_18F28:
    // MOV word ptr [0x479e],BP (1000_8F28 / 0x18F28)
    UInt16[DS, 0x479E] = BP;
    // MOV DI,0x1be2 (1000_8F2C / 0x18F2C)
    DI = 0x1BE2;
    // PUSH DS (1000_8F2F / 0x18F2F)
    Stack.Push(DS);
    // POP ES (1000_8F30 / 0x18F30)
    ES = Stack.Pop();
    // MOV AX,word ptr [BP + 0x0] (1000_8F31 / 0x18F31)
    AX = UInt16[SS, BP];
    // STOSW ES:DI (1000_8F34 / 0x18F34)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV DX,AX (1000_8F35 / 0x18F35)
    DX = AX;
    // ADD AX,word ptr [0x4784] (1000_8F37 / 0x18F37)
    // AX += UInt16[DS, 0x4784];
    AX = Alu.Add16(AX, UInt16[DS, 0x4784]);
    // MOV [0x4791],AX (1000_8F3B / 0x18F3B)
    UInt16[DS, 0x4791] = AX;
    // MOV [0x4795],AX (1000_8F3E / 0x18F3E)
    UInt16[DS, 0x4795] = AX;
    // MOV AX,word ptr [BP + 0x2] (1000_8F41 / 0x18F41)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    // STOSW ES:DI (1000_8F44 / 0x18F44)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV BX,AX (1000_8F45 / 0x18F45)
    BX = AX;
    // ADD AX,word ptr [0x4788] (1000_8F47 / 0x18F47)
    // AX += UInt16[DS, 0x4788];
    AX = Alu.Add16(AX, UInt16[DS, 0x4788]);
    // MOV [0x4793],AX (1000_8F4B / 0x18F4B)
    UInt16[DS, 0x4793] = AX;
    // MOV [0x4797],AX (1000_8F4E / 0x18F4E)
    UInt16[DS, 0x4797] = AX;
    // MOV AX,word ptr [BP + 0x4] (1000_8F51 / 0x18F51)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // ADD DX,AX (1000_8F54 / 0x18F54)
    DX += AX;
    // SUB AX,word ptr [0x4784] (1000_8F56 / 0x18F56)
    AX -= UInt16[DS, 0x4784];
    // SUB AX,word ptr [0x4786] (1000_8F5A / 0x18F5A)
    // AX -= UInt16[DS, 0x4786];
    AX = Alu.Sub16(AX, UInt16[DS, 0x4786]);
    // MOV [0x478f],AX (1000_8F5E / 0x18F5E)
    UInt16[DS, 0x478F] = AX;
    // MOV AX,word ptr [BP + 0x6] (1000_8F61 / 0x18F61)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // ADD BX,AX (1000_8F64 / 0x18F64)
    BX += AX;
    // SUB AX,word ptr [0x4788] (1000_8F66 / 0x18F66)
    AX -= UInt16[DS, 0x4788];
    // SUB AX,word ptr [0x478a] (1000_8F6A / 0x18F6A)
    // AX -= UInt16[DS, 0x478A];
    AX = Alu.Sub16(AX, UInt16[DS, 0x478A]);
    // MOV [0x478d],AX (1000_8F6E / 0x18F6E)
    UInt16[DS, 0x478D] = AX;
    // MOV AX,DX (1000_8F71 / 0x18F71)
    AX = DX;
    // CMP AX,0x140 (1000_8F73 / 0x18F73)
    Alu.Sub16(AX, 0x140);
    // JC 0x1000:8f7b (1000_8F76 / 0x18F76)
    if(CarryFlag) {
      goto label_1000_8F7B_18F7B;
    }
    // MOV AX,0x140 (1000_8F78 / 0x18F78)
    AX = 0x140;
    label_1000_8F7B_18F7B:
    // STOSW ES:DI (1000_8F7B / 0x18F7B)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AX,BX (1000_8F7C / 0x18F7C)
    AX = BX;
    // STOSW ES:DI (1000_8F7E / 0x18F7E)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP byte ptr [0x46eb],0x0 (1000_8F7F / 0x18F7F)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNZ 0x1000:8fd1 (1000_8F84 / 0x18F84)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_8FD1_18FD1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0xc6],0x0 (1000_8F86 / 0x18F86)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    // JNZ 0x1000:8ff5 (1000_8F8B / 0x18F8B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8FF5_018FF5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x227d],0x0 (1000_8F8D / 0x18F8D)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:8fd0 (1000_8F92 / 0x18F92)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_8FD0 / 0x18FD0)
      return NearRet();
    }
    // CMP byte ptr [0x46d9],0x0 (1000_8F94 / 0x18F94)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JNZ 0x1000:8fd0 (1000_8F99 / 0x18F99)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_8FD0 / 0x18FD0)
      return NearRet();
    }
    // CMP byte ptr [0x28e7],0x0 (1000_8F9B / 0x18F9B)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    // JZ 0x1000:900b (1000_8FA0 / 0x18FA0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_900B_01900B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH SI (1000_8FA2 / 0x18FA2)
    Stack.Push(SI);
    // MOV SI,0x4c60 (1000_8FA3 / 0x18FA3)
    SI = 0x4C60;
    // MOV BP,0x1be2 (1000_8FA6 / 0x18FA6)
    BP = 0x1BE2;
    // MOV AX,0x80 (1000_8FA9 / 0x18FA9)
    AX = 0x80;
    // MOV word ptr [BP + 0x8],AX (1000_8FAC / 0x18FAC)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    // MOV [0x1c06],AX (1000_8FAF / 0x18FAF)
    UInt16[DS, 0x1C06] = AX;
    // MOV word ptr [BP + 0xc],0x9468 (1000_8FB2 / 0x18FB2)
    UInt16[SS, (ushort)(BP + 0xC)] = 0x9468;
    // MOV ES,word ptr [0xdbde] (1000_8FB7 / 0x18FB7)
    ES = UInt16[DS, 0xDBDE];
    // CALLF [0x3919] (1000_8FBB / 0x18FBB)
    // Indirect call to [0x3919], generating possible targets from emulator records
    uint targetAddress_1000_8FBB = (uint)(UInt16[DS, 0x391B] * 0x10 + UInt16[DS, 0x3919] - cs1 * 0x10);
    switch(targetAddress_1000_8FBB) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8FBB));
        break;
    }
    // CALL 0x1000:c137 (1000_8FBF / 0x18FBF)
    NearCall(cs1, 0x8FC2, spice86_generated_label_call_target_1000_C137_01C137);
    // MOV SI,0x1be2 (1000_8FC2 / 0x18FC2)
    SI = 0x1BE2;
    // MOV ES,word ptr [0xdbd6] (1000_8FC5 / 0x18FC5)
    ES = UInt16[DS, 0xDBD6];
    // MOV AX,0x1c (1000_8FC9 / 0x18FC9)
    AX = 0x1C;
    // CALL 0x1000:c370 (1000_8FCC / 0x18FCC)
    NearCall(cs1, 0x8FCF, spice86_generated_label_call_target_1000_C370_01C370);
    // POP SI (1000_8FCF / 0x18FCF)
    SI = Stack.Pop();
    label_1000_8FD0_18FD0:
    // RET  (1000_8FD0 / 0x18FD0)
    return NearRet();
  }
  
  public virtual Action spice86_label_1000_8FD1_18FD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8FD1_18FD1:
    // PUSH SI (1000_8FD1 / 0x18FD1)
    Stack.Push(SI);
    // MOV SI,0x1be2 (1000_8FD2 / 0x18FD2)
    SI = 0x1BE2;
    // MOV word ptr [SI + 0x8],0x80 (1000_8FD5 / 0x18FD5)
    UInt16[DS, (ushort)(SI + 0x8)] = 0x80;
    // MOV word ptr [SI + 0xc],0x7bed (1000_8FDA / 0x18FDA)
    UInt16[DS, (ushort)(SI + 0xC)] = 0x7BED;
    // SUB word ptr [SI + 0x2],0x2 (1000_8FDF / 0x18FDF)
    // UInt16[DS, (ushort)(SI + 0x2)] -= 0x2;
    UInt16[DS, (ushort)(SI + 0x2)] = Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], 0x2);
    // MOV AL,[0x18f2] (1000_8FE3 / 0x18FE3)
    AL = UInt8[DS, 0x18F2];
    // MOV ES,word ptr [0xdbda] (1000_8FE6 / 0x18FE6)
    ES = UInt16[DS, 0xDBDA];
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
    label_1000_8FEE_18FEE:
    // ADD word ptr [0x1be4],0x2 (1000_8FEE / 0x18FEE)
    // UInt16[DS, 0x1BE4] += 0x2;
    UInt16[DS, 0x1BE4] = Alu.Add16(UInt16[DS, 0x1BE4], 0x2);
    // POP SI (1000_8FF3 / 0x18FF3)
    SI = Stack.Pop();
    // RET  (1000_8FF4 / 0x18FF4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_8FF5_018FF5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8FF5_18FF5:
    // PUSH SI (1000_8FF5 / 0x18FF5)
    Stack.Push(SI);
    // MOV AX,0x32 (1000_8FF6 / 0x18FF6)
    AX = 0x32;
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
    label_1000_8FFC_18FFC:
    // MOV AX,0x3 (1000_8FFC / 0x18FFC)
    AX = 0x3;
    // MOV SI,0x2265 (1000_8FFF / 0x18FFF)
    SI = 0x2265;
    // MOV ES,word ptr [0xdbd6] (1000_9002 / 0x19002)
    ES = UInt16[DS, 0xDBD6];
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
    label_1000_9009_19009:
    // POP SI (1000_9009 / 0x19009)
    SI = Stack.Pop();
    // RET  (1000_900A / 0x1900A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_900B_01900B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_900B_1900B:
    // MOV DI,0x4c60 (1000_900B / 0x1900B)
    DI = 0x4C60;
    // MOV CX,0x5960 (1000_900E / 0x1900E)
    CX = 0x5960;
    // PUSH DS (1000_9011 / 0x19011)
    Stack.Push(DS);
    // POP ES (1000_9012 / 0x19012)
    ES = Stack.Pop();
    // XOR AL,AL (1000_9013 / 0x19013)
    AL = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_9015 / 0x19015)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV AX,0x4c6f (1000_9017 / 0x19017)
    AX = 0x4C6F;
    // AND AL,0xf0 (1000_901A / 0x1901A)
    // AL &= 0xF0;
    AL = Alu.And8(AL, 0xF0);
    // MOV [0x22fc],AX (1000_901C / 0x1901C)
    UInt16[DS, 0x22FC] = AX;
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
    label_1000_9025_19025:
    // MOV CX,word ptr [0x4793] (1000_9025 / 0x19025)
    CX = UInt16[DS, 0x4793];
    // MOV BX,0x92 (1000_9029 / 0x19029)
    BX = 0x92;
    // SUB BX,CX (1000_902C / 0x1902C)
    BX -= CX;
    // XOR DX,DX (1000_902E / 0x1902E)
    DX = 0;
    // MOV CH,0xff (1000_9030 / 0x19030)
    CH = 0xFF;
    // MOV DI,0x140 (1000_9032 / 0x19032)
    DI = 0x140;
    // MOV SI,word ptr [0x22fc] (1000_9035 / 0x19035)
    SI = UInt16[DS, 0x22FC];
    // MOV ES,word ptr [0xdbda] (1000_9039 / 0x19039)
    ES = UInt16[DS, 0xDBDA];
    // MOV word ptr [0x4782],BX (1000_903D / 0x1903D)
    UInt16[DS, 0x4782] = BX;
    // CALLF [0x38c9] (1000_9041 / 0x19041)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_9041 = (uint)(UInt16[DS, 0x38CB] * 0x10 + UInt16[DS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_9041) {
      case 0x235BF : FarCall(cs1, 0x9045, spice86_generated_label_call_target_334B_010F_0335BF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9041));
        break;
    }
    label_1000_9045_19045:
    // RET  (1000_9045 / 0x19045)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9046_019046(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9046_19046:
    // PUSH DS (1000_9046 / 0x19046)
    Stack.Push(DS);
    // POP ES (1000_9047 / 0x19047)
    ES = Stack.Pop();
    // MOV AX,[0x4793] (1000_9048 / 0x19048)
    AX = UInt16[DS, 0x4793];
    // MUL word ptr [0x2240] (1000_904B / 0x1904B)
    Cpu.Mul16(UInt16[DS, 0x2240]);
    // MOV CX,AX (1000_904F / 0x1904F)
    CX = AX;
    // MOV DI,word ptr [0x22fc] (1000_9051 / 0x19051)
    DI = UInt16[DS, 0x22FC];
    // MOV AX,0xf00f (1000_9055 / 0x19055)
    AX = 0xF00F;
    // XOR BX,BX (1000_9058 / 0x19058)
    BX = 0;
    // CMP byte ptr [0xea],0x0 (1000_905A / 0x1905A)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    // JLE 0x1000:9063 (1000_905F / 0x1905F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9063_19063;
    }
    // MOV AH,0x8 (1000_9061 / 0x19061)
    AH = 0x8;
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
    // JNZ 0x1000:908b (1000_9065 / 0x19065)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_908B / 0x1908B)
      return NearRet();
    }
    // CMP byte ptr [DI + -0x2],BL (1000_9067 / 0x19067)
    Alu.Sub8(UInt8[DS, (ushort)(DI - 0x2)], BL);
    // JNZ 0x1000:906f (1000_906A / 0x1906A)
    if(!ZeroFlag) {
      goto label_1000_906F_1906F;
    }
    // MOV byte ptr [DI + -0x2],AH (1000_906C / 0x1906C)
    UInt8[DS, (ushort)(DI - 0x2)] = AH;
    label_1000_906F_1906F:
    // CMP byte ptr [DI],BL (1000_906F / 0x1906F)
    Alu.Sub8(UInt8[DS, DI], BL);
    // JNZ 0x1000:9075 (1000_9071 / 0x19071)
    if(!ZeroFlag) {
      goto label_1000_9075_19075;
    }
    // MOV byte ptr [DI],AH (1000_9073 / 0x19073)
    UInt8[DS, DI] = AH;
    label_1000_9075_19075:
    // CMP byte ptr [DI + 0xfebf],BL (1000_9075 / 0x19075)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0xFEBF)], BL);
    // JNZ 0x1000:907f (1000_9079 / 0x19079)
    if(!ZeroFlag) {
      goto label_1000_907F_1907F;
    }
    // MOV byte ptr [DI + 0xfebf],AH (1000_907B / 0x1907B)
    UInt8[DS, (ushort)(DI + 0xFEBF)] = AH;
    label_1000_907F_1907F:
    // CMP byte ptr [DI + 0x13f],BL (1000_907F / 0x1907F)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x13F)], BL);
    // JNZ 0x1000:9063 (1000_9083 / 0x19083)
    if(!ZeroFlag) {
      goto label_1000_9063_19063;
    }
    // MOV byte ptr [DI + 0x13f],AH (1000_9085 / 0x19085)
    UInt8[DS, (ushort)(DI + 0x13F)] = AH;
    // JMP 0x1000:9063 (1000_9089 / 0x19089)
    goto label_1000_9063_19063;
    label_1000_908B_1908B:
    // RET  (1000_908B / 0x1908B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_908C_01908C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_908C_1908C:
    // MOV AX,[0xd83a] (1000_908C / 0x1908C)
    AX = UInt16[DS, 0xD83A];
    // CMP AX,word ptr [0x4782] (1000_908F / 0x1908F)
    Alu.Sub16(AX, UInt16[DS, 0x4782]);
    // JBE 0x1000:90bc (1000_9093 / 0x19093)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_90BC / 0x190BC)
      return NearRet();
    }
    // CMP word ptr [0x479e],0x223c (1000_9095 / 0x19095)
    Alu.Sub16(UInt16[DS, 0x479E], 0x223C);
    // JNZ 0x1000:90bc (1000_909B / 0x1909B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_90BC / 0x190BC)
      return NearRet();
    }
    // MOV CX,word ptr [0x4793] (1000_909D / 0x1909D)
    CX = UInt16[DS, 0x4793];
    // MOV BX,0x92 (1000_90A1 / 0x190A1)
    BX = 0x92;
    // SUB BX,CX (1000_90A4 / 0x190A4)
    BX -= CX;
    // XOR DX,DX (1000_90A6 / 0x190A6)
    DX = 0;
    // MOV CH,0xff (1000_90A8 / 0x190A8)
    CH = 0xFF;
    // MOV DI,0x140 (1000_90AA / 0x190AA)
    DI = 0x140;
    // MOV SI,word ptr [0x22fc] (1000_90AD / 0x190AD)
    SI = UInt16[DS, 0x22FC];
    // MOV ES,word ptr [0xdbda] (1000_90B1 / 0x190B1)
    ES = UInt16[DS, 0xDBDA];
    // MOV BP,0xd834 (1000_90B5 / 0x190B5)
    BP = 0xD834;
    // CALLF [0x38cd] (1000_90B8 / 0x190B8)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_90B8 = (uint)(UInt16[DS, 0x38CF] * 0x10 + UInt16[DS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_90B8) {
      case 0x235C2 : FarCall(cs1, 0x90BC, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_90B8));
        break;
    }
    label_1000_90BC_190BC:
    // RET  (1000_90BC / 0x190BC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_90BD_0190BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_90BD_190BD:
    // MOV AL,byte ptr [SI + 0xe] (1000_90BD / 0x190BD)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // CMP AL,0xc (1000_90C0 / 0x190C0)
    Alu.Sub8(AL, 0xC);
    // JZ 0x1000:90d9 (1000_90C2 / 0x190C2)
    if(ZeroFlag) {
      goto label_1000_90D9_190D9;
    }
    // TEST word ptr [0x12],0x1000 (1000_90C4 / 0x190C4)
    Alu.And16(UInt16[DS, 0x12], 0x1000);
    // JZ 0x1000:90d9 (1000_90CA / 0x190CA)
    if(ZeroFlag) {
      goto label_1000_90D9_190D9;
    }
    // MOV BX,0x9c (1000_90CC / 0x190CC)
    BX = 0x9C;
    // MOV DX,0x9584 (1000_90CF / 0x190CF)
    DX = 0x9584;
    // TEST byte ptr [0x10a7],0x10 (1000_90D2 / 0x190D2)
    Alu.And8(UInt8[DS, 0x10A7], 0x10);
    // JZ 0x1000:9111 (1000_90D7 / 0x190D7)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    label_1000_90D9_190D9:
    // CMP AL,0xf (1000_90D9 / 0x190D9)
    Alu.Sub8(AL, 0xF);
    // MOV BX,0x93 (1000_90DB / 0x190DB)
    BX = 0x93;
    // MOV DX,0x5a03 (1000_90DE / 0x190DE)
    DX = 0x5A03;
    // JZ 0x1000:9111 (1000_90E1 / 0x190E1)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    // CMP AL,0xe (1000_90E3 / 0x190E3)
    Alu.Sub8(AL, 0xE);
    // JNZ 0x1000:90f7 (1000_90E5 / 0x190E5)
    if(!ZeroFlag) {
      goto label_1000_90F7_190F7;
    }
    // MOV BX,0x96 (1000_90E7 / 0x190E7)
    BX = 0x96;
    // MOV DX,0x95c1 (1000_90EA / 0x190EA)
    DX = 0x95C1;
    // TEST byte ptr [0xa],0x10 (1000_90ED / 0x190ED)
    Alu.And8(UInt8[DS, 0xA], 0x10);
    // JZ 0x1000:9111 (1000_90F2 / 0x190F2)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    // INC BX (1000_90F4 / 0x190F4)
    BX = Alu.Inc16(BX);
    // JMP 0x1000:9111 (1000_90F5 / 0x190F5)
    goto label_1000_9111_19111;
    label_1000_90F7_190F7:
    // MOV CL,byte ptr [SI + 0xf] (1000_90F7 / 0x190F7)
    CL = UInt8[DS, (ushort)(SI + 0xF)];
    // MOV BX,0x4091 (1000_90FA / 0x190FA)
    BX = 0x4091;
    // TEST CL,0x80 (1000_90FD / 0x190FD)
    Alu.And8(CL, 0x80);
    // JNZ 0x1000:9111 (1000_9100 / 0x19100)
    if(!ZeroFlag) {
      goto label_1000_9111_19111;
    }
    // AND BH,0xbf (1000_9102 / 0x19102)
    // BH &= 0xBF;
    BH = Alu.And8(BH, 0xBF);
    // MOV DX,0x95e2 (1000_9105 / 0x19105)
    DX = 0x95E2;
    // TEST CL,0x40 (1000_9108 / 0x19108)
    Alu.And8(CL, 0x40);
    // JZ 0x1000:9111 (1000_910B / 0x1910B)
    if(ZeroFlag) {
      goto label_1000_9111_19111;
    }
    // INC BX (1000_910D / 0x1910D)
    BX = Alu.Inc16(BX);
    // MOV DX,0x9533 (1000_910E / 0x1910E)
    DX = 0x9533;
    label_1000_9111_19111:
    // MOV BP,0x1f7e (1000_9111 / 0x19111)
    BP = 0x1F7E;
    // MOV word ptr [BP + 0x6],BX (1000_9114 / 0x19114)
    UInt16[SS, (ushort)(BP + 0x6)] = BX;
    // MOV word ptr [BP + 0x8],DX (1000_9117 / 0x19117)
    UInt16[SS, (ushort)(BP + 0x8)] = DX;
    // CALL 0x1000:d316 (1000_911A / 0x1911A)
    NearCall(cs1, 0x911D, spice86_generated_label_call_target_1000_D316_01D316);
    label_1000_911D_1911D:
    // MOV BX,0x97cf (1000_911D / 0x1911D)
    BX = 0x97CF;
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
    label_1000_9123_19123:
    // CMP AL,0x11 (1000_9123 / 0x19123)
    Alu.Sub8(AL, 0x11);
    // JNC 0x1000:917a (1000_9125 / 0x19125)
    if(!CarryFlag) {
      goto label_1000_917A_1917A;
    }
    // XOR AH,AH (1000_9127 / 0x19127)
    AH = 0;
    // CMP AL,0xd (1000_9129 / 0x19129)
    Alu.Sub8(AL, 0xD);
    // JC 0x1000:9173 (1000_912B / 0x1912B)
    if(CarryFlag) {
      goto label_1000_9173_19173;
    }
    // JNZ 0x1000:913b (1000_912D / 0x1912D)
    if(!ZeroFlag) {
      goto label_1000_913B_1913B;
    }
    // MOV DI,word ptr [0x114e] (1000_912F / 0x1912F)
    DI = UInt16[DS, 0x114E];
    // MOV AH,byte ptr [DI] (1000_9133 / 0x19133)
    AH = UInt8[DS, DI];
    // SHR AH,1 (1000_9135 / 0x19135)
    AH >>= 0x1;
    // INC AH (1000_9137 / 0x19137)
    AH = Alu.Inc8(AH);
    // JMP 0x1000:9173 (1000_9139 / 0x19139)
    goto label_1000_9173_19173;
    label_1000_913B_1913B:
    // MOV SI,word ptr [0x4756] (1000_913B / 0x1913B)
    SI = UInt16[DS, 0x4756];
    // CMP AL,0xe (1000_913F / 0x1913F)
    Alu.Sub8(AL, 0xE);
    // JZ 0x1000:9155 (1000_9141 / 0x19141)
    if(ZeroFlag) {
      goto label_1000_9155_19155;
    }
    // CMP byte ptr [0x2a],0xc8 (1000_9143 / 0x19143)
    Alu.Sub8(UInt8[DS, 0x2A], 0xC8);
    // JZ 0x1000:9173 (1000_9148 / 0x19148)
    if(ZeroFlag) {
      goto label_1000_9173_19173;
    }
    // MOV AL,[0x476c] (1000_914A / 0x1914A)
    AL = UInt8[DS, 0x476C];
    // SHL AX,1 (1000_914D / 0x1914D)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV SI,AX (1000_914F / 0x1914F)
    SI = AX;
    // MOV SI,word ptr [SI + 0x4758] (1000_9151 / 0x19151)
    SI = UInt16[DS, (ushort)(SI + 0x4758)];
    label_1000_9155_19155:
    // MOV AL,byte ptr [SI] (1000_9155 / 0x19155)
    AL = UInt8[DS, SI];
    // PUSH DX (1000_9157 / 0x19157)
    Stack.Push(DX);
    // MOV DL,0x3 (1000_9158 / 0x19158)
    DL = 0x3;
    // DIV DL (1000_915A / 0x1915A)
    Cpu.Div8(DL);
    // MOV DL,0xf (1000_915C / 0x1915C)
    DL = 0xF;
    // OR AH,AH (1000_915E / 0x1915E)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:9164 (1000_9160 / 0x19160)
    if(ZeroFlag) {
      goto label_1000_9164_19164;
    }
    // MOV DL,0x11 (1000_9162 / 0x19162)
    DL = 0x11;
    label_1000_9164_19164:
    // CMP AL,DL (1000_9164 / 0x19164)
    Alu.Sub8(AL, DL);
    // JC 0x1000:916c (1000_9166 / 0x19166)
    if(CarryFlag) {
      goto label_1000_916C_1916C;
    }
    // SUB AL,DL (1000_9168 / 0x19168)
    // AL -= DL;
    AL = Alu.Sub8(AL, DL);
    // JMP 0x1000:9164 (1000_916A / 0x1916A)
    goto label_1000_9164_19164;
    label_1000_916C_1916C:
    // POP DX (1000_916C / 0x1916C)
    DX = Stack.Pop();
    // XCHG AH,AL (1000_916D / 0x1916D)
    byte tmp_1000_916D = AH;
    AH = AL;
    AL = tmp_1000_916D;
    // ADD AL,0xe (1000_916F / 0x1916F)
    AL += 0xE;
    label_1000_9171_19171:
    // INC AH (1000_9171 / 0x19171)
    AH = Alu.Inc8(AH);
    label_1000_9173_19173:
    // MOV byte ptr [0x47d0],AH (1000_9173 / 0x19173)
    UInt8[DS, 0x47D0] = AH;
    // XOR AH,AH (1000_9177 / 0x19177)
    AH = 0;
    // RET  (1000_9179 / 0x19179)
    return NearRet();
    label_1000_917A_1917A:
    // MOV AX,[0x2] (1000_917A / 0x1917A)
    AX = UInt16[DS, 0x2];
    // SHL AX,1 (1000_917D / 0x1917D)
    AX <<= 0x1;
    // SHL AX,1 (1000_917F / 0x1917F)
    AX <<= 0x1;
    // CMP AH,0x8 (1000_9181 / 0x19181)
    Alu.Sub8(AH, 0x8);
    // JC 0x1000:9188 (1000_9184 / 0x19184)
    if(CarryFlag) {
      goto label_1000_9188_19188;
    }
    // MOV AH,0x8 (1000_9186 / 0x19186)
    AH = 0x8;
    label_1000_9188_19188:
    // SHL AH,1 (1000_9188 / 0x19188)
    AH <<= 0x1;
    // CMP byte ptr [0xf4],0x10 (1000_918A / 0x1918A)
    Alu.Sub8(UInt8[DS, 0xF4], 0x10);
    // CMC  (1000_918F / 0x1918F)
    CarryFlag = !CarryFlag;
    // ADC AH,0x0 (1000_9190 / 0x19190)
    AH = Alu.Adc8(AH, 0x0);
    // MOV AL,0x2d (1000_9193 / 0x19193)
    AL = 0x2D;
    // JMP 0x1000:9171 (1000_9195 / 0x19195)
    goto label_1000_9171_19171;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9197_019197(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9197_19197:
    // MOV AX,[0x47c4] (1000_9197 / 0x19197)
    AX = UInt16[DS, 0x47C4];
    // CMP AX,0xffff (1000_919A / 0x1919A)
    Alu.Sub16(AX, 0xFFFF);
    // JNZ 0x1000:91a0 (1000_919D / 0x1919D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_91A0_0191A0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_919F / 0x1919F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_91A0_0191A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_91A0_191A0:
    // MOV word ptr [0xf0],0x0 (1000_91A0 / 0x191A0)
    UInt16[DS, 0xF0] = 0x0;
    // CMP AX,0xc (1000_91A6 / 0x191A6)
    Alu.Sub16(AX, 0xC);
    // JNZ 0x1000:91b8 (1000_91A9 / 0x191A9)
    if(!ZeroFlag) {
      goto label_1000_91B8_191B8;
    }
    // TEST byte ptr [0x10a7],0x10 (1000_91AB / 0x191AB)
    Alu.And8(UInt8[DS, 0x10A7], 0x10);
    // JZ 0x1000:91b8 (1000_91B0 / 0x191B0)
    if(ZeroFlag) {
      goto label_1000_91B8_191B8;
    }
    // MOV word ptr [0xf0],0xa (1000_91B2 / 0x191B2)
    UInt16[DS, 0xF0] = 0xA;
    label_1000_91B8_191B8:
    // CALL 0x1000:9123 (1000_91B8 / 0x191B8)
    NearCall(cs1, 0x91BB, spice86_generated_label_call_target_1000_9123_019123);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_91BB_0191BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_91BB_0191BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_91BB_191BB:
    // CMP AX,word ptr [0x22a6] (1000_91BB / 0x191BB)
    Alu.Sub16(AX, UInt16[DS, 0x22A6]);
    // JZ 0x1000:920f (1000_91BF / 0x191BF)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_920F_01920F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_91C1 / 0x191C1)
    Stack.Push(AX);
    // CALL 0x1000:98b2 (1000_91C2 / 0x191C2)
    NearCall(cs1, 0x91C5, spice86_generated_label_call_target_1000_98B2_0198B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_91C5_0191C5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_91C5_0191C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_91C5_191C5:
    // POP AX (1000_91C5 / 0x191C5)
    AX = Stack.Pop();
    // MOV [0x22a6],AX (1000_91C6 / 0x191C6)
    UInt16[DS, 0x22A6] = AX;
    // MOV SI,AX (1000_91C9 / 0x191C9)
    SI = AX;
    // CALL 0x1000:920f (1000_91CB / 0x191CB)
    NearCall(cs1, 0x91CE, spice86_generated_label_call_target_1000_920F_01920F);
    label_1000_91CE_191CE:
    // MOV AL,byte ptr [SI + 0x22a8] (1000_91CE / 0x191CE)
    AL = UInt8[DS, (ushort)(SI + 0x22A8)];
    // XOR AH,AH (1000_91D2 / 0x191D2)
    AH = 0;
    // MOV [0x2224],AX (1000_91D4 / 0x191D4)
    UInt16[DS, 0x2224] = AX;
    // MOV [0x222c],AX (1000_91D7 / 0x191D7)
    UInt16[DS, 0x222C] = AX;
    // MOV [0x2234],AX (1000_91DA / 0x191DA)
    UInt16[DS, 0x2234] = AX;
    // PUSH DS (1000_91DD / 0x191DD)
    Stack.Push(DS);
    // PUSH DS (1000_91DE / 0x191DE)
    Stack.Push(DS);
    // POP ES (1000_91DF / 0x191DF)
    ES = Stack.Pop();
    // LDS SI,[0xdbb0] (1000_91E0 / 0x191E0)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BX,word ptr [SI] (1000_91E4 / 0x191E4)
    BX = UInt16[DS, SI];
    // ADD SI,word ptr [BX + SI + -0x2] (1000_91E6 / 0x191E6)
    SI += UInt16[DS, (ushort)(BX + SI - 0x2)];
    // ADD SI,0x4 (1000_91E9 / 0x191E9)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // MOV DI,0x1bf0 (1000_91EC / 0x191EC)
    DI = 0x1BF0;
    // MOVSW ES:DI,SI (1000_91EF / 0x191EF)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_91F0 / 0x191F0)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_91F1 / 0x191F1)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_91F2 / 0x191F2)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOV AX,SI (1000_91F3 / 0x191F3)
    AX = SI;
    // ADD AX,0x2 (1000_91F5 / 0x191F5)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // MOV SS:[0x47cc],AX (1000_91F8 / 0x191F8)
    UInt16[SS, 0x47CC] = AX;
    // ADD SI,word ptr [SI] (1000_91FC / 0x191FC)
    // SI += UInt16[DS, SI];
    SI = Alu.Add16(SI, UInt16[DS, SI]);
    // MOV BX,word ptr [SI] (1000_91FE / 0x191FE)
    BX = UInt16[DS, SI];
    // MOV DI,SI (1000_9200 / 0x19200)
    DI = SI;
    // ADD DI,word ptr [BX + SI + -0x2] (1000_9202 / 0x19202)
    // DI += UInt16[DS, (ushort)(BX + SI - 0x2)];
    DI = Alu.Add16(DI, UInt16[DS, (ushort)(BX + SI - 0x2)]);
    // POP DS (1000_9205 / 0x19205)
    DS = Stack.Pop();
    // MOV word ptr [0x47ca],SI (1000_9206 / 0x19206)
    UInt16[DS, 0x47CA] = SI;
    // MOV word ptr [0x47d2],DI (1000_920A / 0x1920A)
    UInt16[DS, 0x47D2] = DI;
    // RET  (1000_920E / 0x1920E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_920F_01920F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_920F_1920F:
    // ADD AX,0x2 (1000_920F / 0x1920F)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // JMP 0x1000:c13e (1000_9212 / 0x19212)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9215_019215(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9281: goto label_1000_9281_19281;break; // Target of external jump from 0x19251, 0x192E3, 0x192D2, 0x19268, 0x192DA, 0x1924C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9215_19215:
    // CALL 0x1000:d41b (1000_9215 / 0x19215)
    NearCall(cs1, 0x9218, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_9218_19218:
    // CMP BP,0x1f0e (1000_9218 / 0x19218)
    Alu.Sub16(BP, 0x1F0E);
    // JNZ 0x1000:9248 (1000_921C / 0x1921C)
    if(!ZeroFlag) {
      goto label_1000_9248_19248;
    }
    // CMP byte ptr [0x11c9],0x0 (1000_921E / 0x1921E)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:9281 (1000_9223 / 0x19223)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // CALL 0x1000:9285 (1000_9225 / 0x19225)
    NearCall(cs1, 0x9228, spice86_generated_label_call_target_1000_9285_019285);
    label_1000_9228_19228:
    // JNC 0x1000:9263 (1000_9228 / 0x19228)
    if(!CarryFlag) {
      goto label_1000_9263_19263;
    }
    // CMP CL,0x2f (1000_922A / 0x1922A)
    Alu.Sub8(CL, 0x2F);
    // JZ 0x1000:9282 (1000_922D / 0x1922D)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:42e9 (1000_9282 / 0x19282)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_42E9_0142E9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP CL,0xf (1000_922F / 0x1922F)
    Alu.Sub8(CL, 0xF);
    // JNC 0x1000:9240 (1000_9232 / 0x19232)
    if(!CarryFlag) {
      goto label_1000_9240_19240;
    }
    label_1000_9234_19234:
    // MOV AL,0x10 (1000_9234 / 0x19234)
    AL = 0x10;
    // MUL CL (1000_9236 / 0x19236)
    Cpu.Mul8(CL);
    // ADD AX,0xfd8 (1000_9238 / 0x19238)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    // MOV SI,AX (1000_923B / 0x1923B)
    SI = AX;
    // JMP word ptr [SI + 0x4] (1000_923D / 0x1923D)
    // Indirect jump to word ptr [SI + 0x4], generating possible targets from emulator records
    uint targetAddress_1000_923D = (uint)(UInt16[DS, (ushort)(SI + 0x4)]);
    switch(targetAddress_1000_923D) {
      case 0x92F2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_92F2_0192F2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9373 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9373_019373, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9306 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9306_019306, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9301 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9301_019301, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x92F7 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_92F7_0192F7, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_923D));
        break;
    }
    label_1000_9240_19240:
    // SUB CL,0xf (1000_9240 / 0x19240)
    // CL -= 0xF;
    CL = Alu.Sub8(CL, 0xF);
    // MOV AL,CL (1000_9243 / 0x19243)
    AL = CL;
    // JMP 0x1000:9381 (1000_9245 / 0x19245)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9381_019381, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9248_19248:
    // CMP BP,0x1f7e (1000_9248 / 0x19248)
    Alu.Sub16(BP, 0x1F7E);
    // JNZ 0x1000:9281 (1000_924C / 0x1924C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // CALL 0x1000:92c9 (1000_924E / 0x1924E)
    NearCall(cs1, 0x9251, spice86_generated_label_call_target_1000_92C9_0192C9);
    label_1000_9251_19251:
    // JNC 0x1000:9281 (1000_9251 / 0x19251)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // CMP CX,word ptr [0x47c4] (1000_9253 / 0x19253)
    Alu.Sub16(CX, UInt16[DS, 0x47C4]);
    // JNZ 0x1000:925c (1000_9257 / 0x19257)
    if(!ZeroFlag) {
      goto label_1000_925C_1925C;
    }
    // JMP 0x1000:945b (1000_9259 / 0x19259)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_945B_01945B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_925C_1925C:
    // PUSH CX (1000_925C / 0x1925C)
    Stack.Push(CX);
    // CALL 0x1000:d2bd (1000_925D / 0x1925D)
    NearCall(cs1, 0x9260, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // POP CX (1000_9260 / 0x19260)
    CX = Stack.Pop();
    // JMP 0x1000:9234 (1000_9261 / 0x19261)
    goto label_1000_9234_19234;
    label_1000_9263_19263:
    // CMP byte ptr [0xb],0x1 (1000_9263 / 0x19263)
    Alu.Sub8(UInt8[DS, 0xB], 0x1);
    // JNZ 0x1000:9281 (1000_9268 / 0x19268)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // CMP BX,0x98 (1000_926A / 0x1926A)
    Alu.Sub16(BX, 0x98);
    // JNC 0x1000:9281 (1000_926E / 0x1926E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // CMP byte ptr [0x8],0x21 (1000_9270 / 0x19270)
    Alu.Sub8(UInt8[DS, 0x8], 0x21);
    // JZ 0x1000:9281 (1000_9275 / 0x19275)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // CMP byte ptr [0x2b],0x0 (1000_9277 / 0x19277)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:9281 (1000_927C / 0x1927C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // JMP 0x1000:3f15 (1000_927E / 0x1927E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3F15_013F15, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9281_19281:
    // RET  (1000_9281 / 0x19281)
    return NearRet();
    label_1000_9282_19282:
    // JMP 0x1000:42e9 (1000_9282 / 0x19282)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_42E9_0142E9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9285_019285(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9285_19285:
    // CMP BX,0x98 (1000_9285 / 0x19285)
    Alu.Sub16(BX, 0x98);
    // JNC 0x1000:92c9 (1000_9289 / 0x19289)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_92C9_0192C9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x47f8 (1000_928B / 0x1928B)
    SI = 0x47F8;
    // MOV CX,0x17 (1000_928E / 0x1928E)
    CX = 0x17;
    label_1000_9291_19291:
    // LODSW SI (1000_9291 / 0x19291)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_9292 / 0x19292)
    DI = AX;
    // LODSW SI (1000_9294 / 0x19294)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BP,AX (1000_9295 / 0x19295)
    BP = AX;
    // OR DI,DI (1000_9297 / 0x19297)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JS 0x1000:92a9 (1000_9299 / 0x19299)
    if(SignFlag) {
      goto label_1000_92A9_192A9;
    }
    // SUB DI,DX (1000_929B / 0x1929B)
    DI -= DX;
    // CMP DI,-0x20 (1000_929D / 0x1929D)
    Alu.Sub16(DI, 0xFFE0);
    // JC 0x1000:92a9 (1000_92A0 / 0x192A0)
    if(CarryFlag) {
      goto label_1000_92A9_192A9;
    }
    // SUB BP,BX (1000_92A2 / 0x192A2)
    BP -= BX;
    // CMP BP,-0x50 (1000_92A4 / 0x192A4)
    Alu.Sub16(BP, 0xFFB0);
    // JNC 0x1000:92eb (1000_92A7 / 0x192A7)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_92EB_0192EB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_92A9_192A9:
    // LOOP 0x1000:9291 (1000_92A9 / 0x192A9)
    if(--CX != 0) {
      goto label_1000_9291_19291;
    }
    // MOV AX,[0x472d] (1000_92AB / 0x192AB)
    AX = UInt16[DS, 0x472D];
    // OR AX,AX (1000_92AE / 0x192AE)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:92c8 (1000_92B0 / 0x192B0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_92C8 / 0x192C8)
      return NearRet();
    }
    // SUB AX,DX (1000_92B2 / 0x192B2)
    AX -= DX;
    // CMP AX,0xffb2 (1000_92B4 / 0x192B4)
    Alu.Sub16(AX, 0xFFB2);
    // CMC  (1000_92B7 / 0x192B7)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:92c8 (1000_92B8 / 0x192B8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_92C8 / 0x192C8)
      return NearRet();
    }
    // MOV AX,BX (1000_92BA / 0x192BA)
    AX = BX;
    // SUB AX,word ptr [0x472f] (1000_92BC / 0x192BC)
    AX -= UInt16[DS, 0x472F];
    // CMP AX,0x3c (1000_92C0 / 0x192C0)
    Alu.Sub16(AX, 0x3C);
    // JNC 0x1000:92c8 (1000_92C3 / 0x192C3)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_92C8 / 0x192C8)
      return NearRet();
    }
    // MOV CX,0x2f (1000_92C5 / 0x192C5)
    CX = 0x2F;
    label_1000_92C8_192C8:
    // RET  (1000_92C8 / 0x192C8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_92C9_0192C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_92C9_192C9:
    // XOR CX,CX (1000_92C9 / 0x192C9)
    CX = 0;
    // MOV CL,byte ptr [0x1152] (1000_92CB / 0x192CB)
    CL = UInt8[DS, 0x1152];
    // CMP CL,0xff (1000_92CF / 0x192CF)
    Alu.Sub8(CL, 0xFF);
    // JZ 0x1000:9281 (1000_92D2 / 0x192D2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // MOV DI,0x1c0c (1000_92D4 / 0x192D4)
    DI = 0x1C0C;
    // CALL 0x1000:d6fe (1000_92D7 / 0x192D7)
    NearCall(cs1, 0x92DA, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_92DA_192DA:
    // JC 0x1000:9281 (1000_92DA / 0x192DA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // MOV CL,byte ptr [0x1153] (1000_92DC / 0x192DC)
    CL = UInt8[DS, 0x1153];
    // CMP CL,0xff (1000_92E0 / 0x192E0)
    Alu.Sub8(CL, 0xFF);
    // JZ 0x1000:9281 (1000_92E3 / 0x192E3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    // MOV DI,0x1c1a (1000_92E5 / 0x192E5)
    DI = 0x1C1A;
    // JMP 0x1000:d6fe (1000_92E8 / 0x192E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D6FE_01D6FE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_92EB_0192EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_92EB_192EB:
    // SUB CX,0x17 (1000_92EB / 0x192EB)
    CX -= 0x17;
    // NEG CX (1000_92EE / 0x192EE)
    CX = Alu.Sub16(0, CX);
    // STC  (1000_92F0 / 0x192F0)
    CarryFlag = true;
    // RET  (1000_92F1 / 0x192F1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_92F2_0192F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_92F2_192F2:
    // XOR AL,AL (1000_92F2 / 0x192F2)
    AL = 0;
    // JMP 0x1000:93aa (1000_92F4 / 0x192F4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_92F7_0192F7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_92F7_192F7:
    // MOV AL,0x1 (1000_92F7 / 0x192F7)
    AL = 0x1;
    // JMP 0x1000:93aa (1000_92F9 / 0x192F9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9301_019301(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9301_19301:
    // MOV AL,0x3 (1000_9301 / 0x19301)
    AL = 0x3;
    // JMP 0x1000:93aa (1000_9303 / 0x19303)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9306_019306(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9306_19306:
    // MOV AL,0x4 (1000_9306 / 0x19306)
    AL = 0x4;
    // JMP 0x1000:93aa (1000_9308 / 0x19308)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9373_019373(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9373_19373:
    // MOV SI,word ptr [0x4756] (1000_9373 / 0x19373)
    SI = UInt16[DS, 0x4756];
    // CALL 0x1000:31f6 (1000_9377 / 0x19377)
    NearCall(cs1, 0x937A, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_937A_01937A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_937A_01937A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_937A_1937A:
    // MOV AL,0xe (1000_937A / 0x1937A)
    AL = 0xE;
    // JMP 0x1000:93aa (1000_937C / 0x1937C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9381_019381(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9381_19381:
    // CMP AL,0x9 (1000_9381 / 0x19381)
    Alu.Sub8(AL, 0x9);
    // JC 0x1000:9387 (1000_9383 / 0x19383)
    if(CarryFlag) {
      goto label_1000_9387_19387;
    }
    // XOR AX,AX (1000_9385 / 0x19385)
    AX = 0;
    label_1000_9387_19387:
    // CMP AL,0x8 (1000_9387 / 0x19387)
    Alu.Sub8(AL, 0x8);
    // JNZ 0x1000:9394 (1000_9389 / 0x19389)
    if(!ZeroFlag) {
      goto label_1000_9394_19394;
    }
    // MOV AL,[0x476b] (1000_938B / 0x1938B)
    AL = UInt8[DS, 0x476B];
    // DEC AL (1000_938E / 0x1938E)
    AL = Alu.Dec8(AL);
    // JNS 0x1000:9394 (1000_9390 / 0x19390)
    if(!SignFlag) {
      goto label_1000_9394_19394;
    }
    // XOR AX,AX (1000_9392 / 0x19392)
    AX = 0;
    label_1000_9394_19394:
    // MOV [0x476c],AL (1000_9394 / 0x19394)
    UInt8[DS, 0x476C] = AL;
    // MOV SI,0x4758 (1000_9397 / 0x19397)
    SI = 0x4758;
    // XOR AH,AH (1000_939A / 0x1939A)
    AH = 0;
    // ADD AX,AX (1000_939C / 0x1939C)
    AX += AX;
    // ADD SI,AX (1000_939E / 0x1939E)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV SI,word ptr [SI] (1000_93A0 / 0x193A0)
    SI = UInt16[DS, SI];
    // CALL 0x1000:1ebe (1000_93A2 / 0x193A2)
    NearCall(cs1, 0x93A5, spice86_generated_label_call_target_1000_1EBE_011EBE);
    label_1000_93A5_193A5:
    // CALL 0x1000:31f6 (1000_93A5 / 0x193A5)
    NearCall(cs1, 0x93A8, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_93A8_0193A8(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x93AA: goto label_1000_93AA_193AA;break; // Target of external jump from 0x19303, 0x192F4, 0x192F9, 0x19308, 0x1937C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_93A8_193A8:
    // MOV AL,0xf (1000_93A8 / 0x193A8)
    AL = 0xF;
    label_1000_93AA_193AA:
    // XOR AH,AH (1000_93AA / 0x193AA)
    AH = 0;
    // MOV word ptr [0x47e1],0x0 (1000_93AC / 0x193AC)
    UInt16[DS, 0x47E1] = 0x0;
    // PUSH AX (1000_93B2 / 0x193B2)
    Stack.Push(AX);
    // MOV [0x47c4],AX (1000_93B3 / 0x193B3)
    UInt16[DS, 0x47C4] = AX;
    // CALL 0x1000:91a0 (1000_93B6 / 0x193B6)
    NearCall(cs1, 0x93B9, spice86_generated_label_call_target_1000_91A0_0191A0);
    label_1000_93B9_193B9:
    // CALL 0x1000:3af9 (1000_93B9 / 0x193B9)
    NearCall(cs1, 0x93BC, spice86_generated_label_call_target_1000_3AF9_013AF9);
    label_1000_93BC_193BC:
    // CALL 0x1000:9197 (1000_93BC / 0x193BC)
    NearCall(cs1, 0x93BF, spice86_generated_label_call_target_1000_9197_019197);
    label_1000_93BF_193BF:
    // CALL 0x1000:9908 (1000_93BF / 0x193BF)
    NearCall(cs1, 0x93C2, spice86_generated_label_call_target_1000_9908_019908);
    label_1000_93C2_193C2:
    // MOV SI,word ptr [0x47c8] (1000_93C2 / 0x193C2)
    SI = UInt16[DS, 0x47C8];
    // MOV word ptr [0x4540],0x0 (1000_93C6 / 0x193C6)
    UInt16[DS, 0x4540] = 0x0;
    // CALL 0x1000:9bac (1000_93CC / 0x193CC)
    NearCall(cs1, 0x93CF, spice86_generated_label_call_target_1000_9BAC_019BAC);
    label_1000_93CF_193CF:
    // CALL 0x1000:1834 (1000_93CF / 0x193CF)
    NearCall(cs1, 0x93D2, spice86_generated_label_call_target_1000_1834_011834);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93D2_0193D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_93D2_0193D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_93D2_193D2:
    // CALL 0x1000:c0f4 (1000_93D2 / 0x193D2)
    NearCall(cs1, 0x93D5, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93D5_0193D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_93D5_0193D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_93D5_193D5:
    // CALL 0x1000:c4dd (1000_93D5 / 0x193D5)
    NearCall(cs1, 0x93D8, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_93D8_193D8:
    // POP AX (1000_93D8 / 0x193D8)
    AX = Stack.Pop();
    // CALL 0x1000:93df (1000_93D9 / 0x193D9)
    NearCall(cs1, 0x93DC, spice86_generated_label_call_target_1000_93DF_0193DF);
    label_1000_93DC_193DC:
    // JMP 0x1000:9472 (1000_93DC / 0x193DC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9472_019472, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_93DF_0193DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_93DF_193DF:
    // MOV CL,AL (1000_93DF / 0x193DF)
    CL = AL;
    // SHL AL,1 (1000_93E1 / 0x193E1)
    AL <<= 0x1;
    // SHL AL,1 (1000_93E3 / 0x193E3)
    AL <<= 0x1;
    // SHL AL,1 (1000_93E5 / 0x193E5)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // MOV [0x47be],AX (1000_93E7 / 0x193E7)
    UInt16[DS, 0x47BE] = AX;
    // MOV AX,0x1 (1000_93EA / 0x193EA)
    AX = 0x1;
    // SHL AX,CL (1000_93ED / 0x193ED)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    // OR word ptr [0xe],AX (1000_93EF / 0x193EF)
    // UInt16[DS, 0xE] |= AX;
    UInt16[DS, 0xE] = Alu.Or16(UInt16[DS, 0xE], AX);
    // OR word ptr [0x14],AX (1000_93F3 / 0x193F3)
    // UInt16[DS, 0x14] |= AX;
    UInt16[DS, 0x14] = Alu.Or16(UInt16[DS, 0x14], AX);
    // MOV AL,0x10 (1000_93F7 / 0x193F7)
    AL = 0x10;
    // MUL CL (1000_93F9 / 0x193F9)
    Cpu.Mul8(CL);
    // ADD AX,0xfd8 (1000_93FB / 0x193FB)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    // MOV [0x47a2],AX (1000_93FE / 0x193FE)
    UInt16[DS, 0x47A2] = AX;
    // MOV SI,AX (1000_9401 / 0x19401)
    SI = AX;
    // MOV word ptr [0x47ba],0x0 (1000_9403 / 0x19403)
    UInt16[DS, 0x47BA] = 0x0;
    // CALL 0x1000:90bd (1000_9409 / 0x19409)
    NearCall(cs1, 0x940C, spice86_generated_label_call_target_1000_90BD_0190BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_940C_01940C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_940C_01940C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_940C_1940C:
    // MOV word ptr [0x47b6],0x0 (1000_940C / 0x1940C)
    UInt16[DS, 0x47B6] = 0x0;
    // MOV byte ptr [0x47c2],0x80 (1000_9412 / 0x19412)
    UInt8[DS, 0x47C2] = 0x80;
    // MOV byte ptr [0x19],0x0 (1000_9417 / 0x19417)
    UInt8[DS, 0x19] = 0x0;
    // RET  (1000_941C / 0x1941C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_941D_01941D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_941D_1941D:
    // CMP byte ptr [0x47a9],0x0 (1000_941D / 0x1941D)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    // JZ 0x1000:9427 (1000_9422 / 0x19422)
    if(ZeroFlag) {
      goto label_1000_9427_19427;
    }
    // JMP 0x1000:2993 (1000_9424 / 0x19424)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2992_012992, 0x12993 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9427_19427:
    // CALL 0x1000:d41b (1000_9427 / 0x19427)
    NearCall(cs1, 0x942A, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_942A_1942A:
    // CMP BP,0x20c2 (1000_942A / 0x1942A)
    Alu.Sub16(BP, 0x20C2);
    // JNZ 0x1000:9436 (1000_942E / 0x1942E)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9436_019436, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:d2ea (1000_9430 / 0x19430)
    NearCall(cs1, 0x9433, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9433_019433, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9433_019433(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9433_19433:
    // JMP 0x1000:0eb9 (1000_9433 / 0x19433)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0EB9_010EB9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9436_019436(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9436_19436:
    // TEST byte ptr [0x11c9],0x3 (1000_9436 / 0x19436)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JZ 0x1000:9447 (1000_943B / 0x1943B)
    if(ZeroFlag) {
      goto label_1000_9447_19447;
    }
    // CMP byte ptr [0x11ca],0x0 (1000_943D / 0x1943D)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    // JNZ 0x1000:9447 (1000_9442 / 0x19442)
    if(!ZeroFlag) {
      goto label_1000_9447_19447;
    }
    // JMP 0x1000:4aad (1000_9444 / 0x19444)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_4AAD_014AAD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9447_19447:
    // CMP word ptr [0x479e],0x0 (1000_9447 / 0x19447)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    // JNZ 0x1000:9458 (1000_944C / 0x1944C)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:d2e2 (1000_9458 / 0x19458)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH BX (1000_944E / 0x1944E)
    Stack.Push(BX);
    // PUSH DX (1000_944F / 0x1944F)
    Stack.Push(DX);
    // CALL 0x1000:2db1 (1000_9450 / 0x19450)
    NearCall(cs1, 0x9453, spice86_generated_label_call_target_1000_2DB1_012DB1);
    // POP DX (1000_9453 / 0x19453)
    DX = Stack.Pop();
    // POP BX (1000_9454 / 0x19454)
    BX = Stack.Pop();
    // JMP 0x1000:9215 (1000_9455 / 0x19455)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9215_019215, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9458_19458:
    // JMP 0x1000:d2e2 (1000_9458 / 0x19458)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_945B_01945B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_945B_1945B:
    // CMP word ptr [0x479e],0x0 (1000_945B / 0x1945B)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    // JNZ 0x1000:9468 (1000_9460 / 0x19460)
    if(!ZeroFlag) {
      goto label_1000_9468_19468;
    }
    // MOV AX,[0x47c4] (1000_9462 / 0x19462)
    AX = UInt16[DS, 0x47C4];
    // JMP 0x1000:93aa (1000_9465 / 0x19465)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9468_19468:
    // CALL 0x1000:d41b (1000_9468 / 0x19468)
    NearCall(cs1, 0x946B, spice86_generated_label_call_target_1000_D41B_01D41B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_946B_01946B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_946B_01946B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_946B_1946B:
    // CMP BP,0x1ffe (1000_946B / 0x1946B)
    Alu.Sub16(BP, 0x1FFE);
    // JNZ 0x1000:9472 (1000_946F / 0x1946F)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9472_019472, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_9471 / 0x19471)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9472_019472(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9472_19472:
    // CALL 0x1000:9f40 (1000_9472 / 0x19472)
    NearCall(cs1, 0x9475, spice86_generated_label_call_target_1000_9F40_019F40);
    label_1000_9475_19475:
    // MOV byte ptr [0x226d],0xa (1000_9475 / 0x19475)
    UInt8[DS, 0x226D] = 0xA;
    // MOV byte ptr [0x1b],0x0 (1000_947A / 0x1947A)
    UInt8[DS, 0x1B] = 0x0;
    // CMP word ptr [0x47b6],0x0 (1000_947F / 0x1947F)
    Alu.Sub16(UInt16[DS, 0x47B6], 0x0);
    // JNZ 0x1000:94dd (1000_9484 / 0x19484)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_94DD_0194DD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,word ptr [0x47ba] (1000_9486 / 0x19486)
    SI = UInt16[DS, 0x47BA];
    // OR SI,SI (1000_948A / 0x1948A)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JNZ 0x1000:949a (1000_948C / 0x1948C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9492_019492, 0x1949A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,word ptr [0x47be] (1000_948E / 0x1948E)
    SI = UInt16[DS, 0x47BE];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9492_019492, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9492_019492(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x94A5: goto label_1000_94A5_194A5;break; // Target of external jump from 0x194F1
      case 0x949A: goto label_1000_949A_1949A;break; // Target of external jump from 0x1948C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9492_19492:
    // MOV AX,SI (1000_9492 / 0x19492)
    AX = SI;
    // SHL SI,1 (1000_9494 / 0x19494)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV SI,word ptr [SI + 0xaa76] (1000_9496 / 0x19496)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    label_1000_949A_1949A:
    // CMP SI,-0x1 (1000_949A / 0x1949A)
    Alu.Sub16(SI, 0xFFFF);
    // JZ 0x1000:94b9 (1000_949D / 0x1949D)
    if(ZeroFlag) {
      goto label_1000_94B9_194B9;
    }
    // CALL 0x1000:9b49 (1000_949F / 0x1949F)
    NearCall(cs1, 0x94A2, spice86_generated_label_call_target_1000_9B49_019B49);
    label_1000_94A2_194A2:
    // CALL 0x1000:9f9e (1000_94A2 / 0x194A2)
    NearCall(cs1, 0x94A5, spice86_generated_label_call_target_1000_9F9E_019F9E);
    label_1000_94A5_194A5:
    // MOV word ptr [0x47ba],SI (1000_94A5 / 0x194A5)
    UInt16[DS, 0x47BA] = SI;
    // JNC 0x1000:94da (1000_94A9 / 0x194A9)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      // JMP 0x1000:d280 (1000_94DA / 0x194DA)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0x47be] (1000_94AB / 0x194AB)
    AX = UInt16[DS, 0x47BE];
    // INC AX (1000_94AE / 0x194AE)
    AX = Alu.Inc16(AX);
    // MOV [0x47be],AX (1000_94AF / 0x194AF)
    UInt16[DS, 0x47BE] = AX;
    // MOV SI,AX (1000_94B2 / 0x194B2)
    SI = AX;
    // AND AX,0x3 (1000_94B4 / 0x194B4)
    // AX &= 0x3;
    AX = Alu.And16(AX, 0x3);
    // JNZ 0x1000:9492 (1000_94B7 / 0x194B7)
    if(!ZeroFlag) {
      goto label_1000_9492_19492;
    }
    label_1000_94B9_194B9:
    // CMP word ptr [0x47c4],0xd (1000_94B9 / 0x194B9)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xD);
    // JZ 0x1000:94c3 (1000_94BE / 0x194BE)
    if(ZeroFlag) {
      goto label_1000_94C3_194C3;
    }
    // JMP 0x1000:d2e2 (1000_94C0 / 0x194C0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_94C3_194C3:
    // CMP SI,-0x1 (1000_94C3 / 0x194C3)
    Alu.Sub16(SI, 0xFFFF);
    // JNZ 0x1000:94cc (1000_94C6 / 0x194C6)
    if(!ZeroFlag) {
      goto label_1000_94CC_194CC;
    }
    // MOV SI,word ptr [0x47be] (1000_94C8 / 0x194C8)
    SI = UInt16[DS, 0x47BE];
    label_1000_94CC_194CC:
    // AND SI,0xfff8 (1000_94CC / 0x194CC)
    // SI &= 0xFFF8;
    SI = Alu.And16(SI, 0xFFF8);
    // MOV word ptr [0x47be],SI (1000_94CF / 0x194CF)
    UInt16[DS, 0x47BE] = SI;
    // MOV byte ptr [0x47c2],0x20 (1000_94D3 / 0x194D3)
    UInt8[DS, 0x47C2] = 0x20;
    // JMP 0x1000:9492 (1000_94D8 / 0x194D8)
    goto label_1000_9492_19492;
    label_1000_94DA_194DA:
    // JMP 0x1000:d280 (1000_94DA / 0x194DA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_94DD_0194DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_94DD_194DD:
    // LDS SI,[0x47b6] (1000_94DD / 0x194DD)
    DS = UInt16[DS, 0x47B8];
    SI = UInt16[DS, 0x47B6];
    // CALL 0x1000:88d2 (1000_94E1 / 0x194E1)
    NearCall(cs1, 0x94E4, spice86_generated_label_ret_target_1000_88D2_0188D2);
    label_1000_94E4_194E4:
    // MOV SI,word ptr [0x47ba] (1000_94E4 / 0x194E4)
    SI = UInt16[DS, 0x47BA];
    // ADD word ptr [0x4780],0x1000 (1000_94E8 / 0x194E8)
    // UInt16[DS, 0x4780] += 0x1000;
    UInt16[DS, 0x4780] = Alu.Add16(UInt16[DS, 0x4780], 0x1000);
    // CALL 0x1000:a03f (1000_94EE / 0x194EE)
    NearCall(cs1, 0x94F1, spice86_generated_label_call_target_1000_A03F_01A03F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_94F1_0194F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_94F1_0194F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_94F1_194F1:
    // JMP 0x1000:94a5 (1000_94F1 / 0x194F1)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9492_019492, 0x194A5 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_94F3_0194F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_94F3_194F3:
    // CMP word ptr [0x47c4],0x10 (1000_94F3 / 0x194F3)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    // JNC 0x1000:9532 (1000_94F8 / 0x194F8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    // PUSH SI (1000_94FA / 0x194FA)
    Stack.Push(SI);
    // MOV SI,word ptr [0x47a2] (1000_94FB / 0x194FB)
    SI = UInt16[DS, 0x47A2];
    // MOV AL,byte ptr [SI + 0xf] (1000_94FF / 0x194FF)
    AL = UInt8[DS, (ushort)(SI + 0xF)];
    // MOV [0x18],AL (1000_9502 / 0x19502)
    UInt8[DS, 0x18] = AL;
    // TEST AL,0x40 (1000_9505 / 0x19505)
    Alu.And8(AL, 0x40);
    // MOV AX,word ptr [SI + 0x8] (1000_9507 / 0x19507)
    AX = UInt16[DS, (ushort)(SI + 0x8)];
    // JNZ 0x1000:950f (1000_950A / 0x1950A)
    if(!ZeroFlag) {
      goto label_1000_950F_1950F;
    }
    // MOV AX,word ptr [SI + 0xa] (1000_950C / 0x1950C)
    AX = UInt16[DS, (ushort)(SI + 0xA)];
    label_1000_950F_1950F:
    // SUB AX,word ptr [0x2] (1000_950F / 0x1950F)
    AX -= UInt16[DS, 0x2];
    // NEG AX (1000_9513 / 0x19513)
    AX = Alu.Sub16(0, AX);
    // MOV [0x16],AX (1000_9515 / 0x19515)
    UInt16[DS, 0x16] = AX;
    // POP SI (1000_9518 / 0x19518)
    SI = Stack.Pop();
    // CMP byte ptr [0x2a],0x64 (1000_9519 / 0x19519)
    Alu.Sub8(UInt8[DS, 0x2A], 0x64);
    // JNC 0x1000:9532 (1000_951E / 0x1951E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    // CMP word ptr [0x47c4],0x9 (1000_9520 / 0x19520)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x9);
    // JNC 0x1000:9532 (1000_9525 / 0x19525)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    // MOV DI,word ptr [0x11db] (1000_9527 / 0x19527)
    DI = UInt16[DS, 0x11DB];
    // OR DI,DI (1000_952B / 0x1952B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:9532 (1000_952D / 0x1952D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    // CALL 0x1000:2e98 (1000_952F / 0x1952F)
    NearCall(cs1, 0x9532, spice86_generated_label_call_target_1000_2E98_012E98);
    label_1000_9532_19532:
    // RET  (1000_9532 / 0x19532)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_9556_019556(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9556_19556:
    // AND byte ptr [SI + 0xf],0xbf (1000_9556 / 0x19556)
    // UInt8[DS, (ushort)(SI + 0xF)] &= 0xBF;
    UInt8[DS, (ushort)(SI + 0xF)] = Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0xBF);
    // MOV BX,0x2 (1000_955A / 0x1955A)
    BX = 0x2;
    // CALL 0x1000:956d (1000_955D / 0x1955D)
    NearCall(cs1, 0x9560, spice86_generated_label_call_target_1000_956D_01956D);
    // MOV CL,byte ptr [SI + 0xe] (1000_9560 / 0x19560)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    // MOV AX,0xfffe (1000_9563 / 0x19563)
    AX = 0xFFFE;
    // ROL AX,CL (1000_9566 / 0x19566)
    AX = Alu.Rol16(AX, CL);
    // AND word ptr [0x10],AX (1000_9568 / 0x19568)
    // UInt16[DS, 0x10] &= AX;
    UInt16[DS, 0x10] = Alu.And16(UInt16[DS, 0x10], AX);
    // RET  (1000_956C / 0x1956C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_956D_01956D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_956D_1956D:
    // MOV BP,BX (1000_956D / 0x1956D)
    BP = BX;
    // XOR BP,0x2 (1000_956F / 0x1956F)
    // BP ^= 0x2;
    BP = Alu.Xor16(BP, 0x2);
    // MOV AX,[0x2] (1000_9572 / 0x19572)
    AX = UInt16[DS, 0x2];
    // SUB AX,word ptr [BP + SI + 0x8] (1000_9575 / 0x19575)
    AX -= UInt16[SS, (ushort)(BP + SI + 0x8)];
    // CMP AX,0x2 (1000_9578 / 0x19578)
    Alu.Sub16(AX, 0x2);
    // JC 0x1000:9583 (1000_957B / 0x1957B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_9583 / 0x19583)
      return NearRet();
    }
    // MOV AX,[0x2] (1000_957D / 0x1957D)
    AX = UInt16[DS, 0x2];
    // MOV word ptr [BX + SI + 0x8],AX (1000_9580 / 0x19580)
    UInt16[DS, (ushort)(BX + SI + 0x8)] = AX;
    label_1000_9583_19583:
    // RET  (1000_9583 / 0x19583)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_95C1_0195C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95C1_195C1:
    // MOV AX,0x64 (1000_95C1 / 0x195C1)
    AX = 0x64;
    // CMP word ptr [0xac],0x3e8 (1000_95C4 / 0x195C4)
    Alu.Sub16(UInt16[DS, 0xAC], 0x3E8);
    // JC 0x1000:95de (1000_95CA / 0x195CA)
    if(CarryFlag) {
      goto label_1000_95DE_195DE;
    }
    // SUB AL,byte ptr [0x29] (1000_95CC / 0x195CC)
    // AL -= UInt8[DS, 0x29];
    AL = Alu.Sub8(AL, UInt8[DS, 0x29]);
    // JC 0x1000:95de (1000_95D0 / 0x195D0)
    if(CarryFlag) {
      goto label_1000_95DE_195DE;
    }
    // SHR AL,1 (1000_95D2 / 0x195D2)
    AL >>= 0x1;
    // SHR AL,1 (1000_95D4 / 0x195D4)
    AL >>= 0x1;
    // CMP AL,byte ptr [0x36] (1000_95D6 / 0x195D6)
    Alu.Sub8(AL, UInt8[DS, 0x36]);
    // JBE 0x1000:95de (1000_95DA / 0x195DA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_95DE_195DE;
    }
    // MOV AH,0x2 (1000_95DC / 0x195DC)
    AH = 0x2;
    label_1000_95DE_195DE:
    // MOV byte ptr [0x23],AH (1000_95DE / 0x195DE)
    UInt8[DS, 0x23] = AH;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_95E2_0195E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_95E2_0195E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95E2_195E2:
    // CALL 0x1000:a1c4 (1000_95E2 / 0x195E2)
    NearCall(cs1, 0x95E5, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95E5_0195E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95E5_0195E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95E5_195E5:
    // MOV AX,0x5 (1000_95E5 / 0x195E5)
    AX = 0x5;
    // CALL 0x1000:9f31 (1000_95E8 / 0x195E8)
    NearCall(cs1, 0x95EB, spice86_generated_label_call_target_1000_9F31_019F31);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95EB_0195EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95EB_0195EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95EB_195EB:
    // CALL 0x1000:9f8b (1000_95EB / 0x195EB)
    NearCall(cs1, 0x95EE, spice86_generated_label_call_target_1000_9F8B_019F8B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95EE_0195EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95EE_0195EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95EE_195EE:
    // INC byte ptr [0x1b] (1000_95EE / 0x195EE)
    UInt8[DS, 0x1B] = Alu.Inc8(UInt8[DS, 0x1B]);
    // MOV byte ptr [0x23],0x0 (1000_95F2 / 0x195F2)
    UInt8[DS, 0x23] = 0x0;
    // CALL 0x1000:a1e2 (1000_95F7 / 0x195F7)
    NearCall(cs1, 0x95FA, spice86_generated_label_call_target_1000_A1E2_01A1E2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95FA_0195FA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95FA_0195FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95FA_195FA:
    // JNZ 0x1000:961a (1000_95FA / 0x195FA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    // MOV SI,word ptr [0x47a2] (1000_95FC / 0x195FC)
    SI = UInt16[DS, 0x47A2];
    // MOV CL,byte ptr [SI + 0xe] (1000_9600 / 0x19600)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    // CMP CL,0xe (1000_9603 / 0x19603)
    Alu.Sub8(CL, 0xE);
    // JZ 0x1000:961b (1000_9606 / 0x19606)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_961B_01961B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // OR byte ptr [SI + 0xf],0x40 (1000_9608 / 0x19608)
    UInt8[DS, (ushort)(SI + 0xF)] |= 0x40;
    // XOR BX,BX (1000_960C / 0x1960C)
    BX = 0;
    // CALL 0x1000:956d (1000_960E / 0x1960E)
    NearCall(cs1, 0x9611, spice86_generated_label_call_target_1000_956D_01956D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9611_019611, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9611_019611(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9611_19611:
    // MOV AX,0x1 (1000_9611 / 0x19611)
    AX = 0x1;
    // SHL AX,CL (1000_9614 / 0x19614)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    // OR word ptr [0x10],AX (1000_9616 / 0x19616)
    // UInt16[DS, 0x10] |= AX;
    UInt16[DS, 0x10] = Alu.Or16(UInt16[DS, 0x10], AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_961A_01961A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_961A_01961A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_961A_1961A:
    // RET  (1000_961A / 0x1961A)
    return NearRet();
  }
  
  public virtual Action split_1000_961B_01961B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_961B_1961B:
    // MOV SI,word ptr [0x4756] (1000_961B / 0x1961B)
    SI = UInt16[DS, 0x4756];
    // PUSH SI (1000_961F / 0x1961F)
    Stack.Push(SI);
    // CALL 0x1000:66ce (1000_9620 / 0x19620)
    NearCall(cs1, 0x9623, spice86_generated_label_call_target_1000_66CE_0166CE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9623_019623, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9623_019623(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9623_19623:
    // CALL 0x1000:2efb (1000_9623 / 0x19623)
    NearCall(cs1, 0x9626, spice86_generated_label_call_target_1000_2EFB_012EFB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9626_019626, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9626_019626(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9626_19626:
    // CALL 0x1000:3093 (1000_9626 / 0x19626)
    NearCall(cs1, 0x9629, spice86_generated_label_ret_target_1000_3093_013093);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9629_019629, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9629_019629(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9629_19629:
    // POP SI (1000_9629 / 0x19629)
    SI = Stack.Pop();
    // CMP SI,0x8e0 (1000_962A / 0x1962A)
    Alu.Sub16(SI, 0x8E0);
    // JNZ 0x1000:9639 (1000_962E / 0x1962E)
    if(!ZeroFlag) {
      goto label_1000_9639_19639;
    }
    // ADD byte ptr [SI + 0x15],0x18 (1000_9630 / 0x19630)
    UInt8[DS, (ushort)(SI + 0x15)] += 0x18;
    // ADD byte ptr [0x36],0x18 (1000_9634 / 0x19634)
    // UInt8[DS, 0x36] += 0x18;
    UInt8[DS, 0x36] = Alu.Add8(UInt8[DS, 0x36], 0x18);
    label_1000_9639_19639:
    // MOV AX,SI (1000_9639 / 0x19639)
    AX = SI;
    // MOV CX,0x8 (1000_963B / 0x1963B)
    CX = 0x8;
    // PUSH DS (1000_963E / 0x1963E)
    Stack.Push(DS);
    // POP ES (1000_963F / 0x1963F)
    ES = Stack.Pop();
    // MOV DI,0x4758 (1000_9640 / 0x19640)
    DI = 0x4758;
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASW ES:DI (1000_9643 / 0x19643)
      Alu.Sub16(AX, UInt16[ES, DI]);
      DI = (ushort)(DI + Direction16);
      if(ZeroFlag != false) {
        break;
      }
    }
    // MOV AL,0x7 (1000_9645 / 0x19645)
    AL = 0x7;
    // SUB AL,CL (1000_9647 / 0x19647)
    // AL -= CL;
    AL = Alu.Sub8(AL, CL);
    // MOV [0x476c],AL (1000_9649 / 0x19649)
    UInt8[DS, 0x476C] = AL;
    // MOV SI,0x10c8 (1000_964C / 0x1964C)
    SI = 0x10C8;
    // CALL 0x1000:90bd (1000_964F / 0x1964F)
    NearCall(cs1, 0x9652, spice86_generated_label_call_target_1000_90BD_0190BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9652_019652, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9652_019652(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9652_19652:
    // JMP 0x1000:d280 (1000_9652 / 0x19652)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9655_019655(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9655_19655:
    // MOV CL,byte ptr [SI + 0xe] (1000_9655 / 0x19655)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    // MOV DI,0x1153 (1000_9658 / 0x19658)
    DI = 0x1153;
    // MOV AL,0xff (1000_965B / 0x1965B)
    AL = 0xFF;
    // CMP byte ptr [DI],CL (1000_965D / 0x1965D)
    Alu.Sub8(UInt8[DS, DI], CL);
    // JZ 0x1000:9669 (1000_965F / 0x1965F)
    if(ZeroFlag) {
      goto label_1000_9669_19669;
    }
    // DEC DI (1000_9661 / 0x19661)
    DI--;
    // CMP byte ptr [DI],CL (1000_9662 / 0x19662)
    Alu.Sub8(UInt8[DS, DI], CL);
    // JNZ 0x1000:961a (1000_9664 / 0x19664)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    // XCHG byte ptr [DI + 0x1],AL (1000_9666 / 0x19666)
    byte tmp_1000_9666 = UInt8[DS, (ushort)(DI + 0x1)];
    UInt8[DS, (ushort)(DI + 0x1)] = AL;
    AL = tmp_1000_9666;
    label_1000_9669_19669:
    // MOV byte ptr [DI],AL (1000_9669 / 0x19669)
    UInt8[DS, DI] = AL;
    // MOV byte ptr [DI + 0x10d0],0x0 (1000_966B / 0x1966B)
    UInt8[DS, (ushort)(DI + 0x10D0)] = 0x0;
    // JMP 0x1000:d763 (1000_9670 / 0x19670)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9673_019673(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9673_19673:
    // MOV CL,byte ptr [SI + 0xe] (1000_9673 / 0x19673)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    // MOV DI,0x1152 (1000_9676 / 0x19676)
    DI = 0x1152;
    // CMP byte ptr [DI],CL (1000_9679 / 0x19679)
    Alu.Sub8(UInt8[DS, DI], CL);
    // JZ 0x1000:961a (1000_967B / 0x1967B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    // CMP byte ptr [DI],0xff (1000_967D / 0x1967D)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JZ 0x1000:96ab (1000_9680 / 0x19680)
    if(ZeroFlag) {
      goto label_1000_96AB_196AB;
    }
    // INC DI (1000_9682 / 0x19682)
    DI++;
    // CMP byte ptr [DI],CL (1000_9683 / 0x19683)
    Alu.Sub8(UInt8[DS, DI], CL);
    // JZ 0x1000:961a (1000_9685 / 0x19685)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    // CMP byte ptr [DI],0xff (1000_9687 / 0x19687)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JZ 0x1000:96ab (1000_968A / 0x1968A)
    if(ZeroFlag) {
      goto label_1000_96AB_196AB;
    }
    // DEC DI (1000_968C / 0x1968C)
    DI = Alu.Dec16(DI);
    // PUSH CX (1000_968D / 0x1968D)
    Stack.Push(CX);
    // MOV CL,byte ptr [DI] (1000_968E / 0x1968E)
    CL = UInt8[DS, DI];
    // MOV AL,0x10 (1000_9690 / 0x19690)
    AL = 0x10;
    // MUL CL (1000_9692 / 0x19692)
    Cpu.Mul8(CL);
    // ADD AX,0xfd8 (1000_9694 / 0x19694)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    // MOV SI,AX (1000_9697 / 0x19697)
    SI = AX;
    // MOV AL,byte ptr [SI + 0xe] (1000_9699 / 0x19699)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // ADD AL,0x64 (1000_969C / 0x1969C)
    // AL += 0x64;
    AL = Alu.Add8(AL, 0x64);
    // MOV [0x23],AL (1000_969E / 0x1969E)
    UInt8[DS, 0x23] = AL;
    // CALL 0x1000:9556 (1000_96A1 / 0x196A1)
    NearCall(cs1, 0x96A4, not_observed_1000_9556_019556);
    // POP CX (1000_96A4 / 0x196A4)
    CX = Stack.Pop();
    // INC DI (1000_96A5 / 0x196A5)
    DI = Alu.Inc16(DI);
    // MOV AL,byte ptr [DI] (1000_96A6 / 0x196A6)
    AL = UInt8[DS, DI];
    // MOV byte ptr [DI + -0x1],AL (1000_96A8 / 0x196A8)
    UInt8[DS, (ushort)(DI - 0x1)] = AL;
    label_1000_96AB_196AB:
    // MOV byte ptr [DI],CL (1000_96AB / 0x196AB)
    UInt8[DS, DI] = CL;
    // MOV byte ptr [DI + 0x10d0],0x10 (1000_96AD / 0x196AD)
    UInt8[DS, (ushort)(DI + 0x10D0)] = 0x10;
    // JMP 0x1000:d763 (1000_96B2 / 0x196B2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_96B5_0196B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96B5_196B5:
    // PUSH word ptr [0x47c4] (1000_96B5 / 0x196B5)
    Stack.Push(UInt16[DS, 0x47C4]);
    // PUSH word ptr [0x47c2] (1000_96B9 / 0x196B9)
    Stack.Push(UInt16[DS, 0x47C2]);
    // MOV word ptr [0x47c4],0x10 (1000_96BD / 0x196BD)
    UInt16[DS, 0x47C4] = 0x10;
    // MOV byte ptr [0x47c2],0x80 (1000_96C3 / 0x196C3)
    UInt8[DS, 0x47C2] = 0x80;
    // MOV SI,word ptr [0xab84] (1000_96C8 / 0x196C8)
    SI = UInt16[DS, 0xAB84];
    // CALL 0x1000:9f9e (1000_96CC / 0x196CC)
    NearCall(cs1, 0x96CF, spice86_generated_label_call_target_1000_9F9E_019F9E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_96CF_0196CF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_96CF_0196CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96CF_196CF:
    // POP word ptr [0x47c2] (1000_96CF / 0x196CF)
    UInt16[DS, 0x47C2] = Stack.Pop();
    // POP word ptr [0x47c4] (1000_96D3 / 0x196D3)
    UInt16[DS, 0x47C4] = Stack.Pop();
    // RET  (1000_96D7 / 0x196D7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_96D8_0196D8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96D8_196D8:
    // MOV [0x47c4],AX (1000_96D8 / 0x196D8)
    UInt16[DS, 0x47C4] = AX;
    // INC byte ptr [0x47dc] (1000_96DB / 0x196DB)
    UInt8[DS, 0x47DC] = Alu.Inc8(UInt8[DS, 0x47DC]);
    // MOV AX,0x10 (1000_96DF / 0x196DF)
    AX = 0x10;
    // CALL 0x1000:9702 (1000_96E2 / 0x196E2)
    NearCall(cs1, 0x96E5, spice86_generated_label_call_target_1000_9702_019702);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_96E5_0196E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_96E5_0196E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96E5_196E5:
    // MOV word ptr [0x1bea],0x0 (1000_96E5 / 0x196E5)
    UInt16[DS, 0x1BEA] = 0x0;
    // MOV byte ptr [0x47dc],0x0 (1000_96EB / 0x196EB)
    UInt8[DS, 0x47DC] = 0x0;
    // RET  (1000_96F0 / 0x196F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_96F1_0196F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96F1_196F1:
    // MOV [0x47c4],AX (1000_96F1 / 0x196F1)
    UInt16[DS, 0x47C4] = AX;
    // CMP AL,0xe (1000_96F4 / 0x196F4)
    Alu.Sub8(AL, 0xE);
    // JNZ 0x1000:9702 (1000_96F6 / 0x196F6)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9702_019702, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,word ptr [0x4756] (1000_96F8 / 0x196F8)
    SI = UInt16[DS, 0x4756];
    // CALL 0x1000:31f6 (1000_96FC / 0x196FC)
    NearCall(cs1, 0x96FF, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_96FF_0196FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_96FF_0196FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96FF_196FF:
    // MOV AX,0xe (1000_96FF / 0x196FF)
    AX = 0xE;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9702_019702, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9702_019702(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9702_19702:
    // SHL AX,1 (1000_9702 / 0x19702)
    AX <<= 0x1;
    // SHL AX,1 (1000_9704 / 0x19704)
    AX <<= 0x1;
    // SHL AX,1 (1000_9706 / 0x19706)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // OR AX,0x4 (1000_9708 / 0x19708)
    // AX |= 0x4;
    AX = Alu.Or16(AX, 0x4);
    // MOV SI,AX (1000_970B / 0x1970B)
    SI = AX;
    // SHL SI,1 (1000_970D / 0x1970D)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV SI,word ptr [SI + 0xaa76] (1000_970F / 0x1970F)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    // CALL 0x1000:9f40 (1000_9713 / 0x19713)
    NearCall(cs1, 0x9716, spice86_generated_label_call_target_1000_9F40_019F40);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9716_019716, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9716_019716(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9716_19716:
    // JMP 0x1000:9f8b (1000_9716 / 0x19716)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F8B_019F8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9719_019719(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9719_19719:
    // CMP byte ptr [0x4c],0x0 (1000_9719 / 0x19719)
    Alu.Sub8(UInt8[DS, 0x4C], 0x0);
    // JS 0x1000:972c (1000_971E / 0x1971E)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_972C_01972C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,word ptr [0x46ef] (1000_9720 / 0x19720)
    SI = UInt16[DS, 0x46EF];
    // MOV DI,word ptr [SI + 0x4] (1000_9724 / 0x19724)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AL,0xf (1000_9727 / 0x19727)
    AL = 0xF;
    // CALL 0x1000:2a51 (1000_9729 / 0x19729)
    NearCall(cs1, 0x972C, spice86_generated_label_call_target_1000_2A51_012A51);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_972C_01972C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_972C_01972C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_972C_1972C:
    // CALL 0x1000:9f82 (1000_972C / 0x1972C)
    NearCall(cs1, 0x972F, spice86_generated_label_call_target_1000_9F82_019F82);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_972F_01972F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_972F_01972F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_972F_1972F:
    // MOV word ptr [0x47c4],0xf (1000_972F / 0x1972F)
    UInt16[DS, 0x47C4] = 0xF;
    // MOV word ptr [0x47a2],0x10c8 (1000_9735 / 0x19735)
    UInt16[DS, 0x47A2] = 0x10C8;
    // CALL 0x1000:a1c4 (1000_973B / 0x1973B)
    NearCall(cs1, 0x973E, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    label_1000_973E_1973E:
    // MOV SI,word ptr [0x47ba] (1000_973E / 0x1973E)
    SI = UInt16[DS, 0x47BA];
    // INC SI (1000_9742 / 0x19742)
    SI = Alu.Inc16(SI);
    // JZ 0x1000:9748 (1000_9743 / 0x19743)
    if(ZeroFlag) {
      goto label_1000_9748_19748;
    }
    // DEC SI (1000_9745 / 0x19745)
    SI = Alu.Dec16(SI);
    // JNZ 0x1000:974c (1000_9746 / 0x19746)
    if(!ZeroFlag) {
      goto label_1000_974C_1974C;
    }
    label_1000_9748_19748:
    // MOV SI,word ptr [0xab6a] (1000_9748 / 0x19748)
    SI = UInt16[DS, 0xAB6A];
    label_1000_974C_1974C:
    // MOV byte ptr [0x47c2],0x20 (1000_974C / 0x1974C)
    UInt8[DS, 0x47C2] = 0x20;
    // CALL 0x1000:9f9e (1000_9751 / 0x19751)
    NearCall(cs1, 0x9754, spice86_generated_label_call_target_1000_9F9E_019F9E);
    label_1000_9754_19754:
    // MOV word ptr [0x47ba],SI (1000_9754 / 0x19754)
    UInt16[DS, 0x47BA] = SI;
    // JNC 0x1000:9760 (1000_9758 / 0x19758)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_9760 / 0x19760)
      return NearRet();
    }
    // MOV word ptr [0x47ba],0x0 (1000_975A / 0x1975A)
    UInt16[DS, 0x47BA] = 0x0;
    label_1000_9760_19760:
    // RET  (1000_9760 / 0x19760)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_978E_01978E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_978E_1978E:
    // CALL 0x1000:4aca (1000_978E / 0x1978E)
    NearCall(cs1, 0x9791, spice86_generated_label_call_target_1000_4ACA_014ACA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9791_019791, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9791_019791(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9791_19791:
    // MOV AX,[0x47c4] (1000_9791 / 0x19791)
    AX = UInt16[DS, 0x47C4];
    // CMP AX,0xffff (1000_9794 / 0x19794)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:97ce (1000_9797 / 0x19797)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_97CE / 0x197CE)
      return NearRet();
    }
    // CALL 0x1000:91a0 (1000_9799 / 0x19799)
    NearCall(cs1, 0x979C, spice86_generated_label_call_target_1000_91A0_0191A0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_979C_01979C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_979C_01979C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_979C_1979C:
    // CALL 0x1000:9908 (1000_979C / 0x1979C)
    NearCall(cs1, 0x979F, spice86_generated_label_call_target_1000_9908_019908);
    label_1000_979F_1979F:
    // CMP word ptr [0x479e],0x0 (1000_979F / 0x1979F)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    // JZ 0x1000:97ac (1000_97A4 / 0x197A4)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97AC_0197AC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1be2 (1000_97A6 / 0x197A6)
    SI = 0x1BE2;
    // CALL 0x1000:c477 (1000_97A9 / 0x197A9)
    NearCall(cs1, 0x97AC, spice86_generated_label_call_target_1000_C477_01C477);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97AC_0197AC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
