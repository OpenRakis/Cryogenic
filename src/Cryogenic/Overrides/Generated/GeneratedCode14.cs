namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action not_observed_1000_BC7E_01BC7E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BC7E_1BC7E:
    // POP DX (1000_BC7E / 0x1BC7E)
    DX = Stack.Pop();
    // POP BX (1000_BC7F / 0x1BC7F)
    BX = Stack.Pop();
    // RET  (1000_BC80 / 0x1BC80)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_BC8D_01BC8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BC8D_1BC8D:
    // CALL 0x1000:dbb2 (1000_BC8D / 0x1BC8D)
    NearCall(cs1, 0xBC90, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_BC90_1BC90:
    // CALL 0x1000:bc99 (1000_BC90 / 0x1BC90)
    NearCall(cs1, 0xBC93, spice86_generated_label_call_target_1000_BC99_01BC99);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BC93_01BC93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BC93_01BC93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BC93_1BC93:
    // CALL 0x1000:adbe (1000_BC93 / 0x1BC93)
    NearCall(cs1, 0xBC96, spice86_generated_label_call_target_1000_ADBE_01ADBE);
    label_1000_BC96_1BC96:
    // JMP 0x1000:5a3d (1000_BC96 / 0x1BC96)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5A3D_015A3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BC99_01BC99(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BC99_1BC99:
    // MOV SI,0xdd06 (1000_BC99 / 0x1BC99)
    SI = 0xDD06;
    // MOV word ptr [SI],DX (1000_BC9C / 0x1BC9C)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_BC9E / 0x1BC9E)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // INC DX (1000_BCA1 / 0x1BCA1)
    DX++;
    // INC DX (1000_BCA2 / 0x1BCA2)
    DX++;
    // INC BX (1000_BCA3 / 0x1BCA3)
    BX = Alu.Inc16(BX);
    // MOV word ptr [SI + 0x4],DX (1000_BCA4 / 0x1BCA4)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    // MOV word ptr [SI + 0x6],BX (1000_BCA7 / 0x1BCA7)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV byte ptr [SI + 0x8],0x7 (1000_BCAA / 0x1BCAA)
    UInt8[DS, (ushort)(SI + 0x8)] = 0x7;
    // CALL 0x1000:c08e (1000_BCAE / 0x1BCAE)
    NearCall(cs1, 0xBCB1, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BCB1_01BCB1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BCB1_01BCB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BCB1_1BCB1:
    // MOV CX,0x8 (1000_BCB1 / 0x1BCB1)
    CX = 0x8;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_BCB4_01BCB4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_BCB4_01BCB4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BCB4_1BCB4:
    // PUSH CX (1000_BCB4 / 0x1BCB4)
    Stack.Push(CX);
    // MOV SI,0xdd06 (1000_BCB5 / 0x1BCB5)
    SI = 0xDD06;
    // MOV DI,0x2440 (1000_BCB8 / 0x1BCB8)
    DI = 0x2440;
    // MOV CX,0x2 (1000_BCBB / 0x1BCBB)
    CX = 0x2;
    // MOV DX,0xfffc (1000_BCBE / 0x1BCBE)
    DX = 0xFFFC;
    label_1000_BCC1_1BCC1:
    // MOV AX,word ptr [SI] (1000_BCC1 / 0x1BCC1)
    AX = UInt16[DS, SI];
    // ADD AX,DX (1000_BCC3 / 0x1BCC3)
    AX += DX;
    // CMP AX,word ptr [DI] (1000_BCC5 / 0x1BCC5)
    Alu.Sub16(AX, UInt16[DS, DI]);
    // JNC 0x1000:bccb (1000_BCC7 / 0x1BCC7)
    if(!CarryFlag) {
      goto label_1000_BCCB_1BCCB;
    }
    // MOV AX,word ptr [DI] (1000_BCC9 / 0x1BCC9)
    AX = UInt16[DS, DI];
    label_1000_BCCB_1BCCB:
    // MOV word ptr [SI],AX (1000_BCCB / 0x1BCCB)
    UInt16[DS, SI] = AX;
    // ADD DI,0x2 (1000_BCCD / 0x1BCCD)
    DI += 0x2;
    // ADD SI,0x2 (1000_BCD0 / 0x1BCD0)
    SI += 0x2;
    // SAR DX,1 (1000_BCD3 / 0x1BCD3)
    DX = Alu.Sar16(DX, 0x1);
    // LOOP 0x1000:bcc1 (1000_BCD5 / 0x1BCD5)
    if(--CX != 0) {
      goto label_1000_BCC1_1BCC1;
    }
    // MOV CX,0x2 (1000_BCD7 / 0x1BCD7)
    CX = 0x2;
    // MOV DX,0x4 (1000_BCDA / 0x1BCDA)
    DX = 0x4;
    label_1000_BCDD_1BCDD:
    // MOV AX,word ptr [SI] (1000_BCDD / 0x1BCDD)
    AX = UInt16[DS, SI];
    // ADD AX,DX (1000_BCDF / 0x1BCDF)
    AX += DX;
    // CMP AX,word ptr [DI] (1000_BCE1 / 0x1BCE1)
    Alu.Sub16(AX, UInt16[DS, DI]);
    // JC 0x1000:bce7 (1000_BCE3 / 0x1BCE3)
    if(CarryFlag) {
      goto label_1000_BCE7_1BCE7;
    }
    // MOV AX,word ptr [DI] (1000_BCE5 / 0x1BCE5)
    AX = UInt16[DS, DI];
    label_1000_BCE7_1BCE7:
    // MOV word ptr [SI],AX (1000_BCE7 / 0x1BCE7)
    UInt16[DS, SI] = AX;
    // ADD DI,0x2 (1000_BCE9 / 0x1BCE9)
    DI += 0x2;
    // ADD SI,0x2 (1000_BCEC / 0x1BCEC)
    SI += 0x2;
    // SAR DX,1 (1000_BCEF / 0x1BCEF)
    DX = Alu.Sar16(DX, 0x1);
    // LOOP 0x1000:bcdd (1000_BCF1 / 0x1BCF1)
    if(--CX != 0) {
      goto label_1000_BCDD_1BCDD;
    }
    // MOV SI,0xdd06 (1000_BCF3 / 0x1BCF3)
    SI = 0xDD06;
    // CALL 0x1000:c551 (1000_BCF6 / 0x1BCF6)
    NearCall(cs1, 0xBCF9, spice86_generated_label_call_target_1000_C551_01C551);
    label_1000_BCF9_1BCF9:
    // CALL 0x1000:bd00 (1000_BCF9 / 0x1BCF9)
    NearCall(cs1, 0xBCFC, spice86_generated_label_call_target_1000_BD00_01BD00);
    label_1000_BCFC_1BCFC:
    // POP CX (1000_BCFC / 0x1BCFC)
    CX = Stack.Pop();
    // LOOP 0x1000:bcb4 (1000_BCFD / 0x1BCFD)
    if(--CX != 0) {
      goto label_1000_BCB4_1BCB4;
    }
    // RET  (1000_BCFF / 0x1BCFF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BD00_01BD00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BD00_1BD00:
    // XOR AX,AX (1000_BD00 / 0x1BD00)
    AX = 0;
    // MOV CX,0xa (1000_BD02 / 0x1BD02)
    CX = 0xA;
    // MOV SI,0xdd06 (1000_BD05 / 0x1BD05)
    SI = 0xDD06;
    // INC word ptr [SI] (1000_BD08 / 0x1BD08)
    UInt16[DS, SI]++;
    // INC word ptr [SI + 0x2] (1000_BD0A / 0x1BD0A)
    UInt16[DS, (ushort)(SI + 0x2)]++;
    // DEC word ptr [SI + 0x4] (1000_BD0D / 0x1BD0D)
    UInt16[DS, (ushort)(SI + 0x4)]--;
    // DEC word ptr [SI + 0x6] (1000_BD10 / 0x1BD10)
    UInt16[DS, (ushort)(SI + 0x6)] = Alu.Dec16(UInt16[DS, (ushort)(SI + 0x6)]);
    // CALL 0x1000:c0d5 (1000_BD13 / 0x1BD13)
    NearCall(cs1, 0xBD16, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BD16_01BD16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BD16_01BD16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BD16_1BD16:
    // MOV SI,0xdd06 (1000_BD16 / 0x1BD16)
    SI = 0xDD06;
    // DEC word ptr [SI] (1000_BD19 / 0x1BD19)
    UInt16[DS, SI]--;
    // DEC word ptr [SI + 0x2] (1000_BD1B / 0x1BD1B)
    UInt16[DS, (ushort)(SI + 0x2)]--;
    // INC word ptr [SI + 0x4] (1000_BD1E / 0x1BD1E)
    UInt16[DS, (ushort)(SI + 0x4)]++;
    // INC word ptr [SI + 0x6] (1000_BD21 / 0x1BD21)
    UInt16[DS, (ushort)(SI + 0x6)] = Alu.Inc16(UInt16[DS, (ushort)(SI + 0x6)]);
    // RET  (1000_BD24 / 0x1BD24)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BD25_01BD25(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BD25_1BD25:
    // SUB BX,0x36 (1000_BD25 / 0x1BD25)
    // BX -= 0x36;
    BX = Alu.Sub16(BX, 0x36);
    // MOV CX,BX (1000_BD28 / 0x1BD28)
    CX = BX;
    // JNS 0x1000:bd2e (1000_BD2A / 0x1BD2A)
    if(!SignFlag) {
      goto label_1000_BD2E_1BD2E;
    }
    // NEG CX (1000_BD2C / 0x1BD2C)
    CX = Alu.Sub16(0, CX);
    label_1000_BD2E_1BD2E:
    // PUSH DS (1000_BD2E / 0x1BD2E)
    Stack.Push(DS);
    // POP ES (1000_BD2F / 0x1BD2F)
    ES = Stack.Pop();
    // MOV SI,0x4c60 (1000_BD30 / 0x1BD30)
    SI = 0x4C60;
    // INC CX (1000_BD33 / 0x1BD33)
    CX++;
    // XOR AX,AX (1000_BD34 / 0x1BD34)
    AX = 0;
    label_1000_BD36_1BD36:
    // ADD SI,AX (1000_BD36 / 0x1BD36)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // LODSB SI (1000_BD38 / 0x1BD38)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // INC AL (1000_BD39 / 0x1BD39)
    AL++;
    // NEG AL (1000_BD3B / 0x1BD3B)
    AL = Alu.Sub8(0, AL);
    // LOOPNZ 0x1000:bd36 (1000_BD3D / 0x1BD3D)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_BD36_1BD36;
    }
    // MOV DI,SI (1000_BD3F / 0x1BD3F)
    DI = SI;
    // ADD DI,AX (1000_BD41 / 0x1BD41)
    DI += AX;
    // SUB DX,0x40 (1000_BD43 / 0x1BD43)
    // DX -= 0x40;
    DX = Alu.Sub16(DX, 0x40);
    // MOV AX,DX (1000_BD46 / 0x1BD46)
    AX = DX;
    // JNS 0x1000:bd4c (1000_BD48 / 0x1BD48)
    if(!SignFlag) {
      goto label_1000_BD4C_1BD4C;
    }
    // NEG DX (1000_BD4A / 0x1BD4A)
    DX = Alu.Sub16(0, DX);
    label_1000_BD4C_1BD4C:
    // ADD SI,DX (1000_BD4C / 0x1BD4C)
    SI += DX;
    // CMP SI,DI (1000_BD4E / 0x1BD4E)
    Alu.Sub16(SI, DI);
    // JNC 0x1000:bdba (1000_BD50 / 0x1BD50)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_BDBA / 0x1BDBA)
      return NearRet();
    }
    // PUSH AX (1000_BD52 / 0x1BD52)
    Stack.Push(AX);
    // LODSB SI (1000_BD53 / 0x1BD53)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_BD54 / 0x1BD54)
    AH = 0;
    // OR BX,BX (1000_BD56 / 0x1BD56)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JS 0x1000:bd5c (1000_BD58 / 0x1BD58)
    if(SignFlag) {
      goto label_1000_BD5C_1BD5C;
    }
    // NEG AX (1000_BD5A / 0x1BD5A)
    AX = Alu.Sub16(0, AX);
    label_1000_BD5C_1BD5C:
    // MOV SI,0x8c3b (1000_BD5C / 0x1BD5C)
    SI = 0x8C3B;
    // ADD SI,AX (1000_BD5F / 0x1BD5F)
    SI += AX;
    // ADD SI,AX (1000_BD61 / 0x1BD61)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // LODSW SI (1000_BD63 / 0x1BD63)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // PUSH AX (1000_BD64 / 0x1BD64)
    Stack.Push(AX);
    // MOV SI,0x593a (1000_BD65 / 0x1BD65)
    SI = 0x593A;
    // CBW  (1000_BD68 / 0x1BD68)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BP,AX (1000_BD69 / 0x1BD69)
    BP = AX;
    // OR AX,AX (1000_BD6B / 0x1BD6B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:bd71 (1000_BD6D / 0x1BD6D)
    if(!SignFlag) {
      goto label_1000_BD71_1BD71;
    }
    // NEG BP (1000_BD6F / 0x1BD6F)
    BP = Alu.Sub16(0, BP);
    label_1000_BD71_1BD71:
    // MOV AX,0xc8 (1000_BD71 / 0x1BD71)
    AX = 0xC8;
    // MUL DX (1000_BD74 / 0x1BD74)
    Cpu.Mul16(DX);
    // ADD SI,AX (1000_BD76 / 0x1BD76)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV BL,byte ptr [BP + SI] (1000_BD78 / 0x1BD78)
    BL = UInt8[SS, (ushort)(BP + SI)];
    // MOV AL,byte ptr [BP + SI + 0x64] (1000_BD7A / 0x1BD7A)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    // XOR AH,AH (1000_BD7D / 0x1BD7D)
    AH = 0;
    // XOR BH,BH (1000_BD7F / 0x1BD7F)
    BH = 0;
    // MOV DI,BX (1000_BD81 / 0x1BD81)
    DI = BX;
    // ADD DI,DI (1000_BD83 / 0x1BD83)
    DI += DI;
    // ADD DI,DI (1000_BD85 / 0x1BD85)
    // DI += DI;
    DI = Alu.Add16(DI, DI);
    // MOV CX,word ptr [DI + 0x494a] (1000_BD87 / 0x1BD87)
    CX = UInt16[DS, (ushort)(DI + 0x494A)];
    // POP DX (1000_BD8B / 0x1BD8B)
    DX = Stack.Pop();
    // OR DH,DH (1000_BD8C / 0x1BD8C)
    // DH |= DH;
    DH = Alu.Or8(DH, DH);
    // JNS 0x1000:bd92 (1000_BD8E / 0x1BD8E)
    if(!SignFlag) {
      goto label_1000_BD92_1BD92;
    }
    // NEG BX (1000_BD90 / 0x1BD90)
    BX = Alu.Sub16(0, BX);
    label_1000_BD92_1BD92:
    // OR DL,DL (1000_BD92 / 0x1BD92)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JNS 0x1000:bd9a (1000_BD94 / 0x1BD94)
    if(!SignFlag) {
      goto label_1000_BD9A_1BD9A;
    }
    // NEG AX (1000_BD96 / 0x1BD96)
    AX = Alu.Sub16(0, AX);
    // ADD AX,CX (1000_BD98 / 0x1BD98)
    AX += CX;
    label_1000_BD9A_1BD9A:
    // ADD CX,CX (1000_BD9A / 0x1BD9A)
    // CX += CX;
    CX = Alu.Add16(CX, CX);
    // MOV DX,word ptr [DI + 0x494c] (1000_BD9C / 0x1BD9C)
    DX = UInt16[DS, (ushort)(DI + 0x494C)];
    // POP DI (1000_BDA0 / 0x1BDA0)
    DI = Stack.Pop();
    // OR DI,DI (1000_BDA1 / 0x1BDA1)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNS 0x1000:bda7 (1000_BDA3 / 0x1BDA3)
    if(!SignFlag) {
      goto label_1000_BDA7_1BDA7;
    }
    // NEG AX (1000_BDA5 / 0x1BDA5)
    AX = Alu.Sub16(0, AX);
    label_1000_BDA7_1BDA7:
    // ADD DX,AX (1000_BDA7 / 0x1BDA7)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // JNS 0x1000:bdad (1000_BDA9 / 0x1BDA9)
    if(!SignFlag) {
      goto label_1000_BDAD_1BDAD;
    }
    // ADD DX,CX (1000_BDAB / 0x1BDAB)
    DX += CX;
    label_1000_BDAD_1BDAD:
    // CMP DX,CX (1000_BDAD / 0x1BDAD)
    Alu.Sub16(DX, CX);
    // JC 0x1000:bdb3 (1000_BDAF / 0x1BDAF)
    if(CarryFlag) {
      goto label_1000_BDB3_1BDB3;
    }
    // SUB DX,CX (1000_BDB1 / 0x1BDB1)
    DX -= CX;
    label_1000_BDB3_1BDB3:
    // XOR AX,AX (1000_BDB3 / 0x1BDB3)
    AX = 0;
    // DIV CX (1000_BDB5 / 0x1BDB5)
    Cpu.Div16(CX);
    // SAR BX,1 (1000_BDB7 / 0x1BDB7)
    BX = Alu.Sar16(BX, 0x1);
    // STC  (1000_BDB9 / 0x1BDB9)
    CarryFlag = true;
    label_1000_BDBA_1BDBA:
    // RET  (1000_BDBA / 0x1BDBA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BDBB_01BDBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDBB_1BDBB:
    // CMP word ptr [0xdd0f],0x0 (1000_BDBB / 0x1BDBB)
    Alu.Sub16(UInt16[DS, 0xDD0F], 0x0);
    // JZ 0x1000:bdf9 (1000_BDC0 / 0x1BDC0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_BDF9 / 0x1BDF9)
      return NearRet();
    }
    // CALL 0x1000:c08e (1000_BDC2 / 0x1BDC2)
    NearCall(cs1, 0xBDC5, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BDC5_01BDC5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BDC5_01BDC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDC5_1BDC5:
    // CALL 0x1000:dbb2 (1000_BDC5 / 0x1BDC5)
    NearCall(cs1, 0xBDC8, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_BDC8_1BDC8:
    // CALL 0x1000:bdfa (1000_BDC8 / 0x1BDC8)
    NearCall(cs1, 0xBDCB, spice86_generated_label_call_target_1000_BDFA_01BDFA);
    label_1000_BDCB_1BDCB:
    // CALL 0x1000:bed7 (1000_BDCB / 0x1BDCB)
    NearCall(cs1, 0xBDCE, spice86_generated_label_call_target_1000_BED7_01BED7);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BDCE_01BDCE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BDCE_01BDCE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDCE_1BDCE:
    // MOV AX,[0x2] (1000_BDCE / 0x1BDCE)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BDD1 / 0x1BDD1)
    // AX &= 0xFFF0;
    AX = Alu.And16(AX, 0xFFF0);
    // MOV [0x115c],AX (1000_BDD4 / 0x1BDD4)
    UInt16[DS, 0x115C] = AX;
    // CALL 0x1000:d075 (1000_BDD7 / 0x1BDD7)
    NearCall(cs1, 0xBDDA, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_BDDA_1BDDA:
    // MOV SI,0x2494 (1000_BDDA / 0x1BDDA)
    SI = 0x2494;
    // CALL 0x1000:d1a6 (1000_BDDD / 0x1BDDD)
    NearCall(cs1, 0xBDE0, spice86_generated_label_call_target_1000_D1A6_01D1A6);
    label_1000_BDE0_1BDE0:
    // MOV SI,0xdd11 (1000_BDE0 / 0x1BDE0)
    SI = 0xDD11;
    // MOV DI,0xdd17 (1000_BDE3 / 0x1BDE3)
    DI = 0xDD17;
    // PUSH DS (1000_BDE6 / 0x1BDE6)
    Stack.Push(DS);
    // POP ES (1000_BDE7 / 0x1BDE7)
    ES = Stack.Pop();
    // MOV CX,0x6 (1000_BDE8 / 0x1BDE8)
    CX = 0x6;
    label_1000_BDEB_1BDEB:
    // CMPSB ES:DI,SI (1000_BDEB / 0x1BDEB)
    Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // LOOPNZ 0x1000:bdeb (1000_BDEC / 0x1BDEC)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_BDEB_1BDEB;
    }
    // JNZ 0x1000:bdf9 (1000_BDEE / 0x1BDEE)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_BDF9 / 0x1BDF9)
      return NearRet();
    }
    // DEC byte ptr [DI + -0x1] (1000_BDF0 / 0x1BDF0)
    UInt8[DS, (ushort)(DI - 0x1)]--;
    // INC CX (1000_BDF3 / 0x1BDF3)
    CX = Alu.Inc16(CX);
    // LOOP 0x1000:bdeb (1000_BDF4 / 0x1BDF4)
    if(--CX != 0) {
      goto label_1000_BDEB_1BDEB;
    }
    // CALL 0x1000:dbec (1000_BDF6 / 0x1BDF6)
    NearCall(cs1, 0xBDF9, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    label_1000_BDF9_1BDF9:
    // RET  (1000_BDF9 / 0x1BDF9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BDFA_01BDFA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDFA_1BDFA:
    // MOV SI,0xc2 (1000_BDFA / 0x1BDFA)
    SI = 0xC2;
    // CALL 0x1000:1ad1 (1000_BDFD / 0x1BDFD)
    NearCall(cs1, 0xBE00, spice86_generated_label_call_target_1000_1AD1_011AD1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE00_01BE00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE00_01BE00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE00_1BE00:
    // INC AX (1000_BE00 / 0x1BE00)
    AX = Alu.Inc16(AX);
    // CALL 0x1000:e2db (1000_BE01 / 0x1BE01)
    NearCall(cs1, 0xBE04, spice86_generated_label_call_target_1000_E2DB_01E2DB);
    label_1000_BE04_1BE04:
    // CALL 0x1000:bfa7 (1000_BE04 / 0x1BE04)
    NearCall(cs1, 0xBE07, spice86_generated_label_call_target_1000_BFA7_01BFA7);
    label_1000_BE07_1BE07:
    // MOV AL,[0x29] (1000_BE07 / 0x1BE07)
    AL = UInt8[DS, 0x29];
    // XOR AH,AH (1000_BE0A / 0x1BE0A)
    AH = 0;
    // SHR AX,1 (1000_BE0C / 0x1BE0C)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV SI,0xc3 (1000_BE0E / 0x1BE0E)
    SI = 0xC3;
    // CALL 0x1000:e2db (1000_BE11 / 0x1BE11)
    NearCall(cs1, 0xBE14, spice86_generated_label_call_target_1000_E2DB_01E2DB);
    label_1000_BE14_1BE14:
    // CALL 0x1000:d068 (1000_BE14 / 0x1BE14)
    NearCall(cs1, 0xBE17, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE17_01BE17, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE17_01BE17(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE17_1BE17:
    // MOV SI,0x2482 (1000_BE17 / 0x1BE17)
    SI = 0x2482;
    // JMP 0x1000:d1a6 (1000_BE1A / 0x1BE1A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1A6_01D1A6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BE1D_01BE1D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE1D_1BE1D:
    // MOV AX,0x1 (1000_BE1D / 0x1BE1D)
    AX = 0x1;
    // CALL 0x1000:c13e (1000_BE20 / 0x1BE20)
    NearCall(cs1, 0xBE23, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE23_01BE23, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE23_01BE23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE23_1BE23:
    // MOV SI,0x2506 (1000_BE23 / 0x1BE23)
    SI = 0x2506;
    // CALL 0x1000:c21b (1000_BE26 / 0x1BE26)
    NearCall(cs1, 0xBE29, spice86_generated_label_call_target_1000_C21B_01C21B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE29_01BE29, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE29_01BE29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE29_1BE29:
    // CALL 0x1000:bed7 (1000_BE29 / 0x1BE29)
    NearCall(cs1, 0xBE2C, spice86_generated_label_call_target_1000_BED7_01BED7);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE2C_01BE2C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE2C_01BE2C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE2C_1BE2C:
    // CALL 0x1000:bdfa (1000_BE2C / 0x1BE2C)
    NearCall(cs1, 0xBE2F, spice86_generated_label_call_target_1000_BDFA_01BDFA);
    label_1000_BE2F_1BE2F:
    // MOV SI,0xdd17 (1000_BE2F / 0x1BE2F)
    SI = 0xDD17;
    // XOR AX,AX (1000_BE32 / 0x1BE32)
    AX = 0;
    // MOV word ptr [SI],AX (1000_BE34 / 0x1BE34)
    UInt16[DS, SI] = AX;
    // MOV word ptr [SI + 0x2],AX (1000_BE36 / 0x1BE36)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // MOV word ptr [SI + 0x4],AX (1000_BE39 / 0x1BE39)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    // MOV AX,[0x2] (1000_BE3C / 0x1BE3C)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BE3F / 0x1BE3F)
    // AX &= 0xFFF0;
    AX = Alu.And16(AX, 0xFFF0);
    // MOV [0x115c],AX (1000_BE42 / 0x1BE42)
    UInt16[DS, 0x115C] = AX;
    // CALL 0x1000:d075 (1000_BE45 / 0x1BE45)
    NearCall(cs1, 0xBE48, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_BE48_1BE48:
    // MOV SI,0x2494 (1000_BE48 / 0x1BE48)
    SI = 0x2494;
    // CALL 0x1000:d1a6 (1000_BE4B / 0x1BE4B)
    NearCall(cs1, 0xBE4E, spice86_generated_label_call_target_1000_D1A6_01D1A6);
    label_1000_BE4E_1BE4E:
    // MOV SI,0xbe57 (1000_BE4E / 0x1BE4E)
    SI = 0xBE57;
    // MOV BP,0xc (1000_BE51 / 0x1BE51)
    BP = 0xC;
    // CALL 0x1000:da25 (1000_BE54 / 0x1BE54)
    NearCall(cs1, 0xBE57, spice86_generated_label_call_target_1000_DA25_01DA25);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE57_01BE57, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE57_01BE57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE57_1BE57:
    // CALL 0x1000:c08e (1000_BE57 / 0x1BE57)
    NearCall(cs1, 0xBE5A, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE5A_01BE5A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BE5A_01BE5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE5A_1BE5A:
    // MOV SI,0x1470 (1000_BE5A / 0x1BE5A)
    SI = 0x1470;
    // CALL 0x1000:db74 (1000_BE5D / 0x1BE5D)
    NearCall(cs1, 0xBE60, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_BE60_1BE60:
    // CALL 0x1000:c137 (1000_BE60 / 0x1BE60)
    NearCall(cs1, 0xBE63, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_BE63_1BE63:
    // MOV SI,0xdd11 (1000_BE63 / 0x1BE63)
    SI = 0xDD11;
    // XOR BP,BP (1000_BE66 / 0x1BE66)
    BP = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_BE68_01BE68, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_BE68_01BE68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE68_1BE68:
    // MOV CL,byte ptr [SI] (1000_BE68 / 0x1BE68)
    CL = UInt8[DS, SI];
    // SUB CL,byte ptr [SI + 0x6] (1000_BE6A / 0x1BE6A)
    // CL -= UInt8[DS, (ushort)(SI + 0x6)];
    CL = Alu.Sub8(CL, UInt8[DS, (ushort)(SI + 0x6)]);
    // JZ 0x1000:becd (1000_BE6D / 0x1BE6D)
    if(ZeroFlag) {
      goto label_1000_BECD_1BECD;
    }
    // MOV AL,0x1 (1000_BE6F / 0x1BE6F)
    AL = 0x1;
    // JNC 0x1000:be75 (1000_BE71 / 0x1BE71)
    if(!CarryFlag) {
      goto label_1000_BE75_1BE75;
    }
    // NEG AL (1000_BE73 / 0x1BE73)
    AL = Alu.Sub8(0, AL);
    label_1000_BE75_1BE75:
    // ADD byte ptr [SI + 0x6],AL (1000_BE75 / 0x1BE75)
    // UInt8[DS, (ushort)(SI + 0x6)] += AL;
    UInt8[DS, (ushort)(SI + 0x6)] = Alu.Add8(UInt8[DS, (ushort)(SI + 0x6)], AL);
    // MOV AL,byte ptr [SI + 0x6] (1000_BE78 / 0x1BE78)
    AL = UInt8[DS, (ushort)(SI + 0x6)];
    // CMP AL,0x1e (1000_BE7B / 0x1BE7B)
    Alu.Sub8(AL, 0x1E);
    // JC 0x1000:be81 (1000_BE7D / 0x1BE7D)
    if(CarryFlag) {
      goto label_1000_BE81_1BE81;
    }
    // MOV AL,0x1e (1000_BE7F / 0x1BE7F)
    AL = 0x1E;
    label_1000_BE81_1BE81:
    // MOV BX,BP (1000_BE81 / 0x1BE81)
    BX = BP;
    // SHL BX,1 (1000_BE83 / 0x1BE83)
    BX <<= 0x1;
    // SHL BX,1 (1000_BE85 / 0x1BE85)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV DX,word ptr [BX + 0x24ee] (1000_BE87 / 0x1BE87)
    DX = UInt16[DS, (ushort)(BX + 0x24EE)];
    // MOV BX,word ptr [BX + 0x24f0] (1000_BE8B / 0x1BE8B)
    BX = UInt16[DS, (ushort)(BX + 0x24F0)];
    // XOR AH,AH (1000_BE8F / 0x1BE8F)
    AH = 0;
    // SUB BX,AX (1000_BE91 / 0x1BE91)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // PUSH SI (1000_BE93 / 0x1BE93)
    Stack.Push(SI);
    // PUSH BP (1000_BE94 / 0x1BE94)
    Stack.Push(BP);
    // MOV AX,0x37 (1000_BE95 / 0x1BE95)
    AX = 0x37;
    // SHR BP,1 (1000_BE98 / 0x1BE98)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // ADC AX,0x0 (1000_BE9A / 0x1BE9A)
    AX = Alu.Adc16(AX, 0x0);
    // CALL 0x1000:c2fd (1000_BE9D / 0x1BE9D)
    NearCall(cs1, 0xBEA0, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_BEA0_1BEA0:
    // SUB BX,0xa (1000_BEA0 / 0x1BEA0)
    // BX -= 0xA;
    BX = Alu.Sub16(BX, 0xA);
    // MOV AX,0x39 (1000_BEA3 / 0x1BEA3)
    AX = 0x39;
    // CALL 0x1000:c2fd (1000_BEA6 / 0x1BEA6)
    NearCall(cs1, 0xBEA9, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_BEA9_1BEA9:
    // POP BP (1000_BEA9 / 0x1BEA9)
    BP = Stack.Pop();
    // POP SI (1000_BEAA / 0x1BEAA)
    SI = Stack.Pop();
    // MOV AL,byte ptr [SI] (1000_BEAB / 0x1BEAB)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [SI + 0x6] (1000_BEAD / 0x1BEAD)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x6)]);
    // JNZ 0x1000:becd (1000_BEB0 / 0x1BEB0)
    if(!ZeroFlag) {
      goto label_1000_BECD_1BECD;
    }
    // TEST BP,0x1 (1000_BEB2 / 0x1BEB2)
    Alu.And16(BP, 0x1);
    // MOV AX,0x3f (1000_BEB6 / 0x1BEB6)
    AX = 0x3F;
    // JZ 0x1000:bebd (1000_BEB9 / 0x1BEB9)
    if(ZeroFlag) {
      goto label_1000_BEBD_1BEBD;
    }
    // MOV AL,0x25 (1000_BEBB / 0x1BEBB)
    AL = 0x25;
    label_1000_BEBD_1BEBD:
    // MOV [0xdbe4],AX (1000_BEBD / 0x1BEBD)
    UInt16[DS, 0xDBE4] = AX;
    // ADD DX,0x4 (1000_BEC0 / 0x1BEC0)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // CALL 0x1000:d04e (1000_BEC3 / 0x1BEC3)
    NearCall(cs1, 0xBEC6, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_BEC6_1BEC6:
    // MOV AL,byte ptr [BP + 0x116a] (1000_BEC6 / 0x1BEC6)
    AL = UInt8[SS, (ushort)(BP + 0x116A)];
    // CALL 0x1000:d12f (1000_BECA / 0x1BECA)
    NearCall(cs1, 0xBECD, spice86_generated_label_call_target_1000_D12F_01D12F);
    label_1000_BECD_1BECD:
    // INC SI (1000_BECD / 0x1BECD)
    SI++;
    // INC BP (1000_BECE / 0x1BECE)
    BP++;
    // CMP BP,0x6 (1000_BECF / 0x1BECF)
    Alu.Sub16(BP, 0x6);
    // JC 0x1000:be68 (1000_BED2 / 0x1BED2)
    if(CarryFlag) {
      goto label_1000_BE68_1BE68;
    }
    // JMP 0x1000:c07c (1000_BED4 / 0x1BED4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BED7_01BED7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BED7_1BED7:
    // MOV AX,[0x2] (1000_BED7 / 0x1BED7)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BEDA / 0x1BEDA)
    // AX &= 0xFFF0;
    AX = Alu.And16(AX, 0xFFF0);
    // MOV [0x115c],AX (1000_BEDD / 0x1BEDD)
    UInt16[DS, 0x115C] = AX;
    // CALL 0x1000:c02e (1000_BEE0 / 0x1BEE0)
    NearCall(cs1, 0xBEE3, spice86_generated_label_call_target_1000_C02E_01C02E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BEE3_01BEE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BEE3_01BEE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BEE3_1BEE3:
    // CALL 0x1000:bf26 (1000_BEE3 / 0x1BEE3)
    NearCall(cs1, 0xBEE6, spice86_generated_label_call_target_1000_BF26_01BF26);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BEE6_01BEE6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BEE6_01BEE6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BEE6_1BEE6:
    // PUSH DS (1000_BEE6 / 0x1BEE6)
    Stack.Push(DS);
    // POP ES (1000_BEE7 / 0x1BEE7)
    ES = Stack.Pop();
    // MOV DI,0xdd11 (1000_BEE8 / 0x1BEE8)
    DI = 0xDD11;
    // MOV AX,[0xa4] (1000_BEEB / 0x1BEEB)
    AX = UInt16[DS, 0xA4];
    // SHR AX,1 (1000_BEEE / 0x1BEEE)
    AX >>= 0x1;
    // INC AX (1000_BEF0 / 0x1BEF0)
    AX = Alu.Inc16(AX);
    // STOSB ES:DI (1000_BEF1 / 0x1BEF1)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xa2] (1000_BEF2 / 0x1BEF2)
    AX = UInt16[DS, 0xA2];
    // SHR AX,1 (1000_BEF5 / 0x1BEF5)
    AX >>= 0x1;
    // INC AX (1000_BEF7 / 0x1BEF7)
    AX = Alu.Inc16(AX);
    // STOSB ES:DI (1000_BEF8 / 0x1BEF8)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xa8] (1000_BEF9 / 0x1BEF9)
    AX = UInt16[DS, 0xA8];
    // SHR AX,1 (1000_BEFC / 0x1BEFC)
    AX >>= 0x1;
    // SHR AX,1 (1000_BEFE / 0x1BEFE)
    AX >>= 0x1;
    // SHR AX,1 (1000_BF00 / 0x1BF00)
    AX >>= 0x1;
    // SHR AX,1 (1000_BF02 / 0x1BF02)
    AX >>= 0x1;
    // INC AL (1000_BF04 / 0x1BF04)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF06 / 0x1BF06)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xa6] (1000_BF07 / 0x1BF07)
    AX = UInt16[DS, 0xA6];
    // SHR AX,1 (1000_BF0A / 0x1BF0A)
    AX >>= 0x1;
    // SHR AX,1 (1000_BF0C / 0x1BF0C)
    AX >>= 0x1;
    // SHR AX,1 (1000_BF0E / 0x1BF0E)
    AX >>= 0x1;
    // SHR AX,1 (1000_BF10 / 0x1BF10)
    AX >>= 0x1;
    // INC AL (1000_BF12 / 0x1BF12)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF14 / 0x1BF14)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xac] (1000_BF15 / 0x1BF15)
    AX = UInt16[DS, 0xAC];
    // MOV AL,AH (1000_BF18 / 0x1BF18)
    AL = AH;
    // INC AL (1000_BF1A / 0x1BF1A)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF1C / 0x1BF1C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xaa] (1000_BF1D / 0x1BF1D)
    AX = UInt16[DS, 0xAA];
    // MOV AL,AH (1000_BF20 / 0x1BF20)
    AL = AH;
    // INC AL (1000_BF22 / 0x1BF22)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF24 / 0x1BF24)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // RET  (1000_BF25 / 0x1BF25)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BF26_01BF26(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BF26_1BF26:
    // MOV DI,0x115e (1000_BF26 / 0x1BF26)
    DI = 0x115E;
    // MOV BP,0x116a (1000_BF29 / 0x1BF29)
    BP = 0x116A;
    // MOV SI,0xc4 (1000_BF2C / 0x1BF2C)
    SI = 0xC4;
    // CALL 0x1000:cf70 (1000_BF2F / 0x1BF2F)
    NearCall(cs1, 0xBF32, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_BF32_1BF32:
    // MOV AX,[0xa4] (1000_BF32 / 0x1BF32)
    AX = UInt16[DS, 0xA4];
    // CALL 0x1000:bf73 (1000_BF35 / 0x1BF35)
    NearCall(cs1, 0xBF38, spice86_generated_label_call_target_1000_BF73_01BF73);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BF38_01BF38, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BF38_01BF38(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BF38_1BF38:
    // MOV AX,[0xa2] (1000_BF38 / 0x1BF38)
    AX = UInt16[DS, 0xA2];
    // CALL 0x1000:bf73 (1000_BF3B / 0x1BF3B)
    NearCall(cs1, 0xBF3E, spice86_generated_label_call_target_1000_BF73_01BF73);
    label_1000_BF3E_1BF3E:
    // MOV AX,[0xa8] (1000_BF3E / 0x1BF3E)
    AX = UInt16[DS, 0xA8];
    // CALL 0x1000:bf61 (1000_BF41 / 0x1BF41)
    NearCall(cs1, 0xBF44, spice86_generated_label_call_target_1000_BF61_01BF61);
    label_1000_BF44_1BF44:
    // MOV AX,[0xa6] (1000_BF44 / 0x1BF44)
    AX = UInt16[DS, 0xA6];
    // CALL 0x1000:bf61 (1000_BF47 / 0x1BF47)
    NearCall(cs1, 0xBF4A, spice86_generated_label_call_target_1000_BF61_01BF61);
    label_1000_BF4A_1BF4A:
    // MOV AX,[0xac] (1000_BF4A / 0x1BF4A)
    AX = UInt16[DS, 0xAC];
    // CALL 0x1000:bf61 (1000_BF4D / 0x1BF4D)
    NearCall(cs1, 0xBF50, spice86_generated_label_call_target_1000_BF61_01BF61);
    label_1000_BF50_1BF50:
    // MOV AX,[0xaa] (1000_BF50 / 0x1BF50)
    AX = UInt16[DS, 0xAA];
    // JMP 0x1000:bf61 (1000_BF53 / 0x1BF53)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_BF61_01BF61, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BF61_01BF61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BF61_1BF61:
    // PUSH DI (1000_BF61 / 0x1BF61)
    Stack.Push(DI);
    // PUSH AX (1000_BF62 / 0x1BF62)
    Stack.Push(AX);
    // CALL 0x1000:d03c (1000_BF63 / 0x1BF63)
    NearCall(cs1, 0xBF66, spice86_generated_label_call_target_1000_D03C_01D03C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BF66_01BF66, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BF66_01BF66(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BF66_1BF66:
    // DEC SI (1000_BF66 / 0x1BF66)
    SI = Alu.Dec16(SI);
    // MOV byte ptr ES:[SI],0x30 (1000_BF67 / 0x1BF67)
    UInt8[ES, SI] = 0x30;
    // POP AX (1000_BF6B / 0x1BF6B)
    AX = Stack.Pop();
    // PUSH AX (1000_BF6C / 0x1BF6C)
    Stack.Push(AX);
    // CALL 0x1000:e31c (1000_BF6D / 0x1BF6D)
    NearCall(cs1, 0xBF70, spice86_generated_label_call_target_1000_E31C_01E31C);
    label_1000_BF70_1BF70:
    // INC SI (1000_BF70 / 0x1BF70)
    SI = Alu.Inc16(SI);
    // JMP 0x1000:bf7d (1000_BF71 / 0x1BF71)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BF78_01BF78, 0x1BF7D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BF73_01BF73(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BF73_1BF73:
    // PUSH DI (1000_BF73 / 0x1BF73)
    Stack.Push(DI);
    // PUSH AX (1000_BF74 / 0x1BF74)
    Stack.Push(AX);
    // CALL 0x1000:d03c (1000_BF75 / 0x1BF75)
    NearCall(cs1, 0xBF78, spice86_generated_label_call_target_1000_D03C_01D03C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BF78_01BF78, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BF78_01BF78(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xBF7D: goto label_1000_BF7D_1BF7D;break; // Target of external jump from 0x1BF71
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_BF78_1BF78:
    // POP AX (1000_BF78 / 0x1BF78)
    AX = Stack.Pop();
    // PUSH AX (1000_BF79 / 0x1BF79)
    Stack.Push(AX);
    // CALL 0x1000:e2e3 (1000_BF7A / 0x1BF7A)
    NearCall(cs1, 0xBF7D, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    label_1000_BF7D_1BF7D:
    // POP AX (1000_BF7D / 0x1BF7D)
    AX = Stack.Pop();
    // POP DI (1000_BF7E / 0x1BF7E)
    DI = Stack.Pop();
    // MOV DX,AX (1000_BF7F / 0x1BF7F)
    DX = AX;
    // XCHG word ptr [DI],AX (1000_BF81 / 0x1BF81)
    ushort tmp_1000_BF81 = UInt16[DS, DI];
    UInt16[DS, DI] = AX;
    AX = tmp_1000_BF81;
    // CMP DX,AX (1000_BF83 / 0x1BF83)
    Alu.Sub16(DX, AX);
    // MOV AL,0x3 (1000_BF85 / 0x1BF85)
    AL = 0x3;
    // JNZ 0x1000:bf99 (1000_BF87 / 0x1BF87)
    if(!ZeroFlag) {
      goto label_1000_BF99_1BF99;
    }
    // MOV AX,[0x2] (1000_BF89 / 0x1BF89)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BF8C / 0x1BF8C)
    AX &= 0xFFF0;
    // CMP word ptr [0x115c],AX (1000_BF8F / 0x1BF8F)
    Alu.Sub16(UInt16[DS, 0x115C], AX);
    // JZ 0x1000:bfa2 (1000_BF93 / 0x1BF93)
    if(ZeroFlag) {
      goto label_1000_BFA2_1BFA2;
    }
    // MOV AL,0x3 (1000_BF95 / 0x1BF95)
    AL = 0x3;
    // JMP 0x1000:bf9f (1000_BF97 / 0x1BF97)
    goto label_1000_BF9F_1BF9F;
    label_1000_BF99_1BF99:
    // MOV AL,0x2 (1000_BF99 / 0x1BF99)
    AL = 0x2;
    // JC 0x1000:bf9f (1000_BF9B / 0x1BF9B)
    if(CarryFlag) {
      goto label_1000_BF9F_1BF9F;
    }
    // DEC AL (1000_BF9D / 0x1BF9D)
    AL = Alu.Dec8(AL);
    label_1000_BF9F_1BF9F:
    // MOV byte ptr [BP + 0x0],AL (1000_BF9F / 0x1BF9F)
    UInt8[SS, BP] = AL;
    label_1000_BFA2_1BFA2:
    // ADD DI,0x2 (1000_BFA2 / 0x1BFA2)
    DI += 0x2;
    // INC BP (1000_BFA5 / 0x1BFA5)
    BP = Alu.Inc16(BP);
    // RET  (1000_BFA6 / 0x1BFA6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BFA7_01BFA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BFA7_1BFA7:
    // MOV BL,byte ptr [0xceeb] (1000_BFA7 / 0x1BFA7)
    BL = UInt8[DS, 0xCEEB];
    // XOR BH,BH (1000_BFAB / 0x1BFAB)
    BH = 0;
    // SHL BX,1 (1000_BFAD / 0x1BFAD)
    BX <<= 0x1;
    // SHL BX,1 (1000_BFAF / 0x1BFAF)
    BX <<= 0x1;
    // SHL BX,1 (1000_BFB1 / 0x1BFB1)
    BX <<= 0x1;
    // ADD BX,0x251a (1000_BFB3 / 0x1BFB3)
    // BX += 0x251A;
    BX = Alu.Add16(BX, 0x251A);
    // MOV AX,word ptr ES:[SI + -0x2] (1000_BFB7 / 0x1BFB7)
    AX = UInt16[ES, (ushort)(SI - 0x2)];
    // XCHG AH,AL (1000_BFBB / 0x1BFBB)
    byte tmp_1000_BFBB = AH;
    AH = AL;
    AL = tmp_1000_BFBB;
    // AND AL,0xf (1000_BFBD / 0x1BFBD)
    AL &= 0xF;
    // CMP AH,0x31 (1000_BFBF / 0x1BFBF)
    Alu.Sub8(AH, 0x31);
    // JZ 0x1000:bfdd (1000_BFC2 / 0x1BFC2)
    if(ZeroFlag) {
      goto label_1000_BFDD_1BFDD;
    }
    // CMP AL,0x4 (1000_BFC4 / 0x1BFC4)
    Alu.Sub8(AL, 0x4);
    // JNC 0x1000:bfdd (1000_BFC6 / 0x1BFC6)
    if(!CarryFlag) {
      goto label_1000_BFDD_1BFDD;
    }
    // CMP AL,0x1 (1000_BFC8 / 0x1BFC8)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:bfd7 (1000_BFCA / 0x1BFCA)
    if(!ZeroFlag) {
      goto label_1000_BFD7_1BFD7;
    }
    // CMP BX,0x2522 (1000_BFCC / 0x1BFCC)
    Alu.Sub16(BX, 0x2522);
    // JNZ 0x1000:bfd7 (1000_BFD0 / 0x1BFD0)
    if(!ZeroFlag) {
      goto label_1000_BFD7_1BFD7;
    }
    // CMP AH,0x20 (1000_BFD2 / 0x1BFD2)
    Alu.Sub8(AH, 0x20);
    // JNZ 0x1000:bfdd (1000_BFD5 / 0x1BFD5)
    if(!ZeroFlag) {
      goto label_1000_BFDD_1BFDD;
    }
    label_1000_BFD7_1BFD7:
    // XOR AH,AH (1000_BFD7 / 0x1BFD7)
    AH = 0;
    // SHL AX,1 (1000_BFD9 / 0x1BFD9)
    AX <<= 0x1;
    // ADD BX,AX (1000_BFDB / 0x1BFDB)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    label_1000_BFDD_1BFDD:
    // MOV AX,word ptr [BX] (1000_BFDD / 0x1BFDD)
    AX = UInt16[DS, BX];
    // MOV word ptr ES:[SI],AX (1000_BFDF / 0x1BFDF)
    UInt16[ES, SI] = AX;
    // RET  (1000_BFE2 / 0x1BFE2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BFE3_01BFE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BFE3_1BFE3:
    // PUSH DS (1000_BFE3 / 0x1BFE3)
    Stack.Push(DS);
    // XOR BX,BX (1000_BFE4 / 0x1BFE4)
    BX = 0;
    // XOR DX,DX (1000_BFE6 / 0x1BFE6)
    DX = 0;
    // MOV CX,0xc5f9 (1000_BFE8 / 0x1BFE8)
    CX = 0xC5F9;
    // XOR SI,SI (1000_BFEB / 0x1BFEB)
    SI = 0;
    // MOV DS,word ptr [0xdd00] (1000_BFED / 0x1BFED)
    DS = UInt16[DS, 0xDD00];
    label_1000_BFF1_1BFF1:
    // LODSB SI (1000_BFF1 / 0x1BFF1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // AND AL,0x30 (1000_BFF2 / 0x1BFF2)
    // AL &= 0x30;
    AL = Alu.And8(AL, 0x30);
    // JZ 0x1000:bffc (1000_BFF4 / 0x1BFF4)
    if(ZeroFlag) {
      goto label_1000_BFFC_1BFFC;
    }
    // INC DX (1000_BFF6 / 0x1BFF6)
    DX++;
    // CMP AL,0x30 (1000_BFF7 / 0x1BFF7)
    Alu.Sub8(AL, 0x30);
    // JZ 0x1000:bffc (1000_BFF9 / 0x1BFF9)
    if(ZeroFlag) {
      goto label_1000_BFFC_1BFFC;
    }
    // INC BX (1000_BFFB / 0x1BFFB)
    BX = Alu.Inc16(BX);
    label_1000_BFFC_1BFFC:
    // LOOP 0x1000:bff1 (1000_BFFC / 0x1BFFC)
    if(--CX != 0) {
      goto label_1000_BFF1_1BFF1;
    }
    // SUB DX,BX (1000_BFFE / 0x1BFFE)
    DX -= BX;
    // XOR AX,AX (1000_C000 / 0x1C000)
    AX = 0;
    // SUB SI,0x188 (1000_C002 / 0x1C002)
    SI -= 0x188;
    // INC SI (1000_C006 / 0x1C006)
    SI++;
    // DIV SI (1000_C007 / 0x1C007)
    Cpu.Div16(SI);
    // MOV DX,0x64 (1000_C009 / 0x1C009)
    DX = 0x64;
    // MUL DX (1000_C00C / 0x1C00C)
    Cpu.Mul16(DX);
    // ADD AX,AX (1000_C00E / 0x1C00E)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // ADC DX,0x0 (1000_C010 / 0x1C010)
    DX = Alu.Adc16(DX, 0x0);
    // XCHG BX,DX (1000_C013 / 0x1C013)
    ushort tmp_1000_C013 = BX;
    BX = DX;
    DX = tmp_1000_C013;
    // XOR AX,AX (1000_C015 / 0x1C015)
    AX = 0;
    // DIV SI (1000_C017 / 0x1C017)
    Cpu.Div16(SI);
    // MOV DX,0x64 (1000_C019 / 0x1C019)
    DX = 0x64;
    // MUL DX (1000_C01C / 0x1C01C)
    Cpu.Mul16(DX);
    // ADD AX,AX (1000_C01E / 0x1C01E)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // ADC DX,0x0 (1000_C020 / 0x1C020)
    DX = Alu.Adc16(DX, 0x0);
    // INC DX (1000_C023 / 0x1C023)
    DX = Alu.Inc16(DX);
    // POP DS (1000_C024 / 0x1C024)
    DS = Stack.Pop();
    // MOV word ptr [0xa2],DX (1000_C025 / 0x1C025)
    UInt16[DS, 0xA2] = DX;
    // MOV word ptr [0xa4],BX (1000_C029 / 0x1C029)
    UInt16[DS, 0xA4] = BX;
    // RET  (1000_C02D / 0x1C02D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C02E_01C02E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C02E_1C02E:
    // CALL 0x1000:bfe3 (1000_C02E / 0x1C02E)
    NearCall(cs1, 0xC031, spice86_generated_label_call_target_1000_BFE3_01BFE3);
    label_1000_C031_1C031:
    // MOV AX,[0xa0] (1000_C031 / 0x1C031)
    AX = UInt16[DS, 0xA0];
    // ADD AX,word ptr [0x1172] (1000_C034 / 0x1C034)
    AX += UInt16[DS, 0x1172];
    // SUB AX,word ptr [0x1170] (1000_C038 / 0x1C038)
    // AX -= UInt16[DS, 0x1170];
    AX = Alu.Sub16(AX, UInt16[DS, 0x1170]);
    // JNC 0x1000:c040 (1000_C03C / 0x1C03C)
    if(!CarryFlag) {
      goto label_1000_C040_1C040;
    }
    // XOR AX,AX (1000_C03E / 0x1C03E)
    AX = 0;
    label_1000_C040_1C040:
    // CMP AX,word ptr [0xa6] (1000_C040 / 0x1C040)
    Alu.Sub16(AX, UInt16[DS, 0xA6]);
    // JC 0x1000:c049 (1000_C044 / 0x1C044)
    if(CarryFlag) {
      goto label_1000_C049_1C049;
    }
    // MOV [0xa6],AX (1000_C046 / 0x1C046)
    UInt16[DS, 0xA6] = AX;
    label_1000_C049_1C049:
    // XOR AX,AX (1000_C049 / 0x1C049)
    AX = 0;
    // MOV [0xaa],AX (1000_C04B / 0x1C04B)
    UInt16[DS, 0xAA] = AX;
    // MOV [0xac],AX (1000_C04E / 0x1C04E)
    UInt16[DS, 0xAC] = AX;
    // MOV SI,0x8aa (1000_C051 / 0x1C051)
    SI = 0x8AA;
    label_1000_C054_1C054:
    // MOV AL,byte ptr [SI + 0x1a] (1000_C054 / 0x1C054)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    // TEST byte ptr [SI + 0x3],0x20 (1000_C057 / 0x1C057)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JNZ 0x1000:c073 (1000_C05B / 0x1C05B)
    if(!ZeroFlag) {
      goto label_1000_C073_1C073;
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_C05D / 0x1C05D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JZ 0x1000:c069 (1000_C061 / 0x1C061)
    if(ZeroFlag) {
      goto label_1000_C069_1C069;
    }
    // ADD word ptr [0xac],AX (1000_C063 / 0x1C063)
    // UInt16[DS, 0xAC] += AX;
    UInt16[DS, 0xAC] = Alu.Add16(UInt16[DS, 0xAC], AX);
    // JMP 0x1000:c073 (1000_C067 / 0x1C067)
    goto label_1000_C073_1C073;
    label_1000_C069_1C069:
    // TEST byte ptr [SI + 0x3],0x80 (1000_C069 / 0x1C069)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // JNZ 0x1000:c073 (1000_C06D / 0x1C06D)
    if(!ZeroFlag) {
      goto label_1000_C073_1C073;
    }
    // ADD word ptr [0xaa],AX (1000_C06F / 0x1C06F)
    UInt16[DS, 0xAA] += AX;
    label_1000_C073_1C073:
    // ADD SI,0x1b (1000_C073 / 0x1C073)
    SI += 0x1B;
    // CMP byte ptr [SI],0x0 (1000_C076 / 0x1C076)
    Alu.Sub8(UInt8[DS, SI], 0x0);
    // JNZ 0x1000:c054 (1000_C079 / 0x1C079)
    if(!ZeroFlag) {
      goto label_1000_C054_1C054;
    }
    // RET  (1000_C07B / 0x1C07B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C07C_01C07C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C07C_1C07C:
    // PUSH word ptr [0xdbd6] (1000_C07C / 0x1C07C)
    Stack.Push(UInt16[DS, 0xDBD6]);
    // POP word ptr [0xdbda] (1000_C080 / 0x1C080)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_C084 / 0x1C084)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C085_01C085(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C085_1C085:
    // PUSH word ptr [0xdc32] (1000_C085 / 0x1C085)
    Stack.Push(UInt16[DS, 0xDC32]);
    // POP word ptr [0xdbda] (1000_C089 / 0x1C089)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_C08D / 0x1C08D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C08E_01C08E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C08E_1C08E:
    // PUSH word ptr [0xdbd8] (1000_C08E / 0x1C08E)
    Stack.Push(UInt16[DS, 0xDBD8]);
    // POP word ptr [0xdbda] (1000_C092 / 0x1C092)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_C096 / 0x1C096)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C097_01C097(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C097_1C097:
    // CALL 0x1000:c07c (1000_C097 / 0x1C097)
    NearCall(cs1, 0xC09A, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C09A_01C09A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C09A_01C09A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C09A_1C09A:
    // PUSH word ptr [0xdbd8] (1000_C09A / 0x1C09A)
    Stack.Push(UInt16[DS, 0xDBD8]);
    // PUSH word ptr [0xdbd6] (1000_C09E / 0x1C09E)
    Stack.Push(UInt16[DS, 0xDBD6]);
    // POP word ptr [0xdbd8] (1000_C0A2 / 0x1C0A2)
    UInt16[DS, 0xDBD8] = Stack.Pop();
    // CALL BP (1000_C0A6 / 0x1C0A6)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_C0A6 = (uint)(BP);
    switch(targetAddress_1000_C0A6) {
      case 0x61C : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_061C_01061C); break;
      case 0xF66 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x9EF : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_09EF_0109EF); break;
      case 0xD1EF : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_D1EF_01D1EF); break;
      case 0xD75A : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_D75A_01D75A); break;
      case 0x2DB1 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_2DB1_012DB1); break;
      case 0xD717 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_D717_01D717); break;
      case 0x2EB2 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_2EB2_012EB2); break;
      case 0x2C1 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_02C1_0102C1); break;
      case 0xC0AD : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_C0AD_01C0AD); break;
      case 0x64D : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_064D_01064D); break;
      case 0x658 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_0658_010658); break;
      case 0x678 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_0678_010678); break;
      case 0xCEFC : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_CEFC_01CEFC); break;
      case 0x301 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_0301_010301); break;
      case 0xED0 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_0ED0_010ED0); break;
      case 0x5A56 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_5A56_015A56); break;
      case 0xAF26 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_AF26_01AF26); break;
      case 0xB039 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_B039_01B039); break;
      case 0xB236 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_B236_01B236); break;
      case 0xB23F : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_B23F_01B23F); break;
      case 0xAF43 : NearCall(cs1, 0xC0A8, spice86_generated_label_ret_target_1000_AF43_01AF43); break;
      case 0x98B2 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_98B2_0198B2); break;
      case 0xB827 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_B827_01B827); break;
      case 0xBE1D : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_BE1D_01BE1D); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0A6));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C0A8_01C0A8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C0A8_01C0A8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0A8_1C0A8:
    // POP word ptr [0xdbd8] (1000_C0A8 / 0x1C0A8)
    UInt16[DS, 0xDBD8] = Stack.Pop();
    // RET  (1000_C0AC / 0x1C0AC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C0AD_01C0AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0AD_1C0AD:
    // MOV ES,word ptr [0xdbda] (1000_C0AD / 0x1C0AD)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38d5] (1000_C0B1 / 0x1C0B1)
    // Indirect call to [0x38d5], generating possible targets from emulator records
    uint targetAddress_1000_C0B1 = (uint)(UInt16[DS, 0x38D7] * 0x10 + UInt16[DS, 0x38D5] - cs1 * 0x10);
    switch(targetAddress_1000_C0B1) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0B1));
        break;
    }
    // RET  (1000_C0B5 / 0x1C0B5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C0D5_01C0D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0D5_1C0D5:
    // PUSH DS (1000_C0D5 / 0x1C0D5)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C0D6 / 0x1C0D6)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C0DA / 0x1C0DA)
    DS = UInt16[DS, 0xDBD6];
    // MOV BP,0xce7a (1000_C0DE / 0x1C0DE)
    BP = 0xCE7A;
    // CALLF [0x392d] (1000_C0E1 / 0x1C0E1)
    // Indirect call to [0x392d], generating possible targets from emulator records
    uint targetAddress_1000_C0E1 = (uint)(UInt16[SS, 0x392F] * 0x10 + UInt16[SS, 0x392D] - cs1 * 0x10);
    switch(targetAddress_1000_C0E1) {
      case 0x2360A : FarCall(cs1, 0xC0E6, spice86_generated_label_call_target_334B_015A_03360A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0E1));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C0E6_01C0E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C0E6_01C0E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0E6_1C0E6:
    // POP DS (1000_C0E6 / 0x1C0E6)
    DS = Stack.Pop();
    // RET  (1000_C0E7 / 0x1C0E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C0E8_01C0E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0E8_1C0E8:
    // MOV ES,word ptr [0xdbd8] (1000_C0E8 / 0x1C0E8)
    ES = UInt16[DS, 0xDBD8];
    // MOV BP,0xce7a (1000_C0EC / 0x1C0EC)
    BP = 0xCE7A;
    // CALLF [0x392d] (1000_C0EF / 0x1C0EF)
    // Indirect call to [0x392d], generating possible targets from emulator records
    uint targetAddress_1000_C0EF = (uint)(UInt16[DS, 0x392F] * 0x10 + UInt16[DS, 0x392D] - cs1 * 0x10);
    switch(targetAddress_1000_C0EF) {
      case 0x2360A : FarCall(cs1, 0xC0F3, spice86_generated_label_call_target_334B_015A_03360A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0EF));
        break;
    }
    label_1000_C0F3_1C0F3:
    // RET  (1000_C0F3 / 0x1C0F3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C0F4_01C0F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0F4_1C0F4:
    // MOV AX,[0xdbd6] (1000_C0F4 / 0x1C0F4)
    AX = UInt16[DS, 0xDBD6];
    // CMP AX,word ptr [0xdbd8] (1000_C0F7 / 0x1C0F7)
    Alu.Sub16(AX, UInt16[DS, 0xDBD8]);
    // JZ 0x1000:c101 (1000_C0FB / 0x1C0FB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C101 / 0x1C101)
      return NearRet();
    }
    // CALLF [0x3935] (1000_C0FD / 0x1C0FD)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_C0FD = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_C0FD) {
      case 0x23610 : FarCall(cs1, 0xC101, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0FD));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C101_01C101, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C101_01C101(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C101_1C101:
    // RET  (1000_C101 / 0x1C101)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C102_01C102(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C102_1C102:
    // CALLF [0x3959] (1000_C102 / 0x1C102)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_C102 = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_C102) {
      case 0x2362B : FarCall(cs1, 0xC106, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C102));
        break;
    }
    label_1000_C106_1C106:
    // MOV AL,0x3a (1000_C106 / 0x1C106)
    AL = 0x3A;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C108_01C108, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C108_01C108(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C108_1C108:
    // MOV byte ptr [0xdce6],0x80 (1000_C108 / 0x1C108)
    UInt8[DS, 0xDCE6] = 0x80;
    // PUSH AX (1000_C10D / 0x1C10D)
    Stack.Push(AX);
    // PUSH DX (1000_C10E / 0x1C10E)
    Stack.Push(DX);
    // CALL 0x1000:c097 (1000_C10F / 0x1C10F)
    NearCall(cs1, 0xC112, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C112_01C112, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C112_01C112(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C112_1C112:
    // POP DX (1000_C112 / 0x1C112)
    DX = Stack.Pop();
    // POP AX (1000_C113 / 0x1C113)
    AX = Stack.Pop();
    // PUSH DS (1000_C114 / 0x1C114)
    Stack.Push(DS);
    // MOV SI,word ptr [0xdbde] (1000_C115 / 0x1C115)
    SI = UInt16[DS, 0xDBDE];
    // MOV ES,word ptr [0xdbd8] (1000_C119 / 0x1C119)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C11D / 0x1C11D)
    DS = UInt16[DS, 0xDBD6];
    // MOV BP,0xce7a (1000_C121 / 0x1C121)
    BP = 0xCE7A;
    // CALLF [0x3921] (1000_C124 / 0x1C124)
    // Indirect call to [0x3921], generating possible targets from emulator records
    uint targetAddress_1000_C124 = (uint)(UInt16[SS, 0x3923] * 0x10 + UInt16[SS, 0x3921] - cs1 * 0x10);
    switch(targetAddress_1000_C124) {
      case 0x23601 : FarCall(cs1, 0xC129, spice86_generated_label_call_target_334B_0151_033601); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C124));
        break;
    }
    label_1000_C129_1C129:
    // POP DS (1000_C129 / 0x1C129)
    DS = Stack.Pop();
    // CALL 0x1000:c4cd (1000_C12A / 0x1C12A)
    NearCall(cs1, 0xC12D, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    label_1000_C12D_1C12D:
    // CALLF [0x3935] (1000_C12D / 0x1C12D)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_C12D = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_C12D) {
      case 0x23610 : FarCall(cs1, 0xC131, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C12D));
        break;
    }
    label_1000_C131_1C131:
    // MOV byte ptr [0xdce6],0x0 (1000_C131 / 0x1C131)
    UInt8[DS, 0xDCE6] = 0x0;
    // RET  (1000_C136 / 0x1C136)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C137_01C137(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C137_1C137:
    // XOR AX,AX (1000_C137 / 0x1C137)
    AX = 0;
    // JMP 0x1000:c13e (1000_C139 / 0x1C139)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C13B_01C13B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C13B_1C13B:
    // MOV AX,0x25 (1000_C13B / 0x1C13B)
    AX = 0x25;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C13E_01C13E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C13E_1C13E:
    // OR AX,AX (1000_C13E / 0x1C13E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:c1a9 (1000_C140 / 0x1C140)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_C1A9 / 0x1C1A9)
      return NearRet();
    }
    // PUSH BX (1000_C142 / 0x1C142)
    Stack.Push(BX);
    // MOV BX,AX (1000_C143 / 0x1C143)
    BX = AX;
    // XCHG word ptr [0x2784],BX (1000_C145 / 0x1C145)
    ushort tmp_1000_C145 = UInt16[DS, 0x2784];
    UInt16[DS, 0x2784] = BX;
    BX = tmp_1000_C145;
    // CMP AX,BX (1000_C149 / 0x1C149)
    Alu.Sub16(AX, BX);
    // JZ 0x1000:c1a8 (1000_C14B / 0x1C14B)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C180_01C180, 0x1C1A8 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH SI (1000_C14D / 0x1C14D)
    Stack.Push(SI);
    // PUSH DI (1000_C14E / 0x1C14E)
    Stack.Push(DI);
    // SHL BX,1 (1000_C14F / 0x1C14F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // JS 0x1000:c15b (1000_C151 / 0x1C151)
    if(SignFlag) {
      goto label_1000_C15B_1C15B;
    }
    // MOV SI,word ptr [0xce7b] (1000_C153 / 0x1C153)
    SI = UInt16[DS, 0xCE7B];
    // MOV word ptr [BX + 0xda8c],SI (1000_C157 / 0x1C157)
    UInt16[DS, (ushort)(BX + 0xDA8C)] = SI;
    label_1000_C15B_1C15B:
    // MOV SI,AX (1000_C15B / 0x1C15B)
    SI = AX;
    // SHL SI,1 (1000_C15D / 0x1C15D)
    SI <<= 0x1;
    // SHL SI,1 (1000_C15F / 0x1C15F)
    SI <<= 0x1;
    // ADD SI,0xd844 (1000_C161 / 0x1C161)
    // SI += 0xD844;
    SI = Alu.Add16(SI, 0xD844);
    // LES DI,[SI] (1000_C165 / 0x1C165)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DI = UInt16[DS, SI];
    // MOV BX,ES (1000_C167 / 0x1C167)
    BX = ES;
    // OR BX,BX (1000_C169 / 0x1C169)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:c177 (1000_C16B / 0x1C16B)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C177_01C177, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP DI,0x2 (1000_C16D / 0x1C16D)
    Alu.Sub16(DI, 0x2);
    // JBE 0x1000:c19e (1000_C170 / 0x1C170)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C180_01C180, 0x1C19E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c1aa (1000_C172 / 0x1C172)
    NearCall(cs1, 0xC175, spice86_generated_label_call_target_1000_C1AA_01C1AA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C175_01C175, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C175_01C175(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C175_1C175:
    // JMP 0x1000:c19e (1000_C175 / 0x1C175)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C180_01C180, 0x1C19E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_C177_01C177(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C177_1C177:
    // PUSH CX (1000_C177 / 0x1C177)
    Stack.Push(CX);
    // PUSH DX (1000_C178 / 0x1C178)
    Stack.Push(DX);
    // PUSH BP (1000_C179 / 0x1C179)
    Stack.Push(BP);
    // PUSH SI (1000_C17A / 0x1C17A)
    Stack.Push(SI);
    // MOV SI,AX (1000_C17B / 0x1C17B)
    SI = AX;
    // CALL 0x1000:f0b9 (1000_C17D / 0x1C17D)
    NearCall(cs1, 0xC180, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C180_01C180, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C180_01C180(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC1A9: goto label_1000_C1A9_1C1A9;break; // Target of external jump from 0x1C1B5
      case 0xC1A8: goto label_1000_C1A8_1C1A8;break; // Target of external jump from 0x1C14B
      case 0xC19E: goto label_1000_C19E_1C19E;break; // Target of external jump from 0x1C170, 0x1C175
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C180_1C180:
    // CMP word ptr ES:[DI],0x2 (1000_C180 / 0x1C180)
    Alu.Sub16(UInt16[ES, DI], 0x2);
    // JBE 0x1000:c189 (1000_C184 / 0x1C184)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C189_1C189;
    }
    // CALL 0x1000:c1aa (1000_C186 / 0x1C186)
    NearCall(cs1, 0xC189, spice86_generated_label_call_target_1000_C1AA_01C1AA);
    label_1000_C189_1C189:
    // POP SI (1000_C189 / 0x1C189)
    SI = Stack.Pop();
    // MOV DI,word ptr ES:[DI] (1000_C18A / 0x1C18A)
    DI = UInt16[ES, DI];
    // SUB CX,DI (1000_C18D / 0x1C18D)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    // MOV word ptr [SI],DI (1000_C18F / 0x1C18F)
    UInt16[DS, SI] = DI;
    // MOV word ptr [SI + 0x2],ES (1000_C191 / 0x1C191)
    UInt16[DS, (ushort)(SI + 0x2)] = ES;
    // MOV AX,[0x2784] (1000_C194 / 0x1C194)
    AX = UInt16[DS, 0x2784];
    // CALLF [0x3905] (1000_C197 / 0x1C197)
    // Indirect call to [0x3905], generating possible targets from emulator records
    uint targetAddress_1000_C197 = (uint)(UInt16[DS, 0x3907] * 0x10 + UInt16[DS, 0x3905] - cs1 * 0x10);
    switch(targetAddress_1000_C197) {
      case 0x235EC : FarCall(cs1, 0xC19B, spice86_generated_label_call_target_334B_013C_0335EC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C197));
        break;
    }
    label_1000_C19B_1C19B:
    // POP BP (1000_C19B / 0x1C19B)
    BP = Stack.Pop();
    // POP DX (1000_C19C / 0x1C19C)
    DX = Stack.Pop();
    // POP CX (1000_C19D / 0x1C19D)
    CX = Stack.Pop();
    label_1000_C19E_1C19E:
    // MOV word ptr [0xdbb0],DI (1000_C19E / 0x1C19E)
    UInt16[DS, 0xDBB0] = DI;
    // MOV word ptr [0xdbb2],ES (1000_C1A2 / 0x1C1A2)
    UInt16[DS, 0xDBB2] = ES;
    // POP DI (1000_C1A6 / 0x1C1A6)
    DI = Stack.Pop();
    // POP SI (1000_C1A7 / 0x1C1A7)
    SI = Stack.Pop();
    label_1000_C1A8_1C1A8:
    // POP BX (1000_C1A8 / 0x1C1A8)
    BX = Stack.Pop();
    label_1000_C1A9_1C1A9:
    // RET  (1000_C1A9 / 0x1C1A9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C1AA_01C1AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C1AA_1C1AA:
    // MOV AX,[0x2784] (1000_C1AA / 0x1C1AA)
    AX = UInt16[DS, 0x2784];
    // MOV AH,AL (1000_C1AD / 0x1C1AD)
    AH = AL;
    // XCHG byte ptr [0xdbb4],AL (1000_C1AF / 0x1C1AF)
    byte tmp_1000_C1AF = UInt8[DS, 0xDBB4];
    UInt8[DS, 0xDBB4] = AL;
    AL = tmp_1000_C1AF;
    // CMP AL,AH (1000_C1B3 / 0x1C1B3)
    Alu.Sub8(AL, AH);
    // JZ 0x1000:c1a9 (1000_C1B5 / 0x1C1B5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C1A9 / 0x1C1A9)
      return NearRet();
    }
    // MOV SI,0x2 (1000_C1B7 / 0x1C1B7)
    SI = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C1BA_01C1BA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C1BA_01C1BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C1BA_1C1BA:
    // PUSH CX (1000_C1BA / 0x1C1BA)
    Stack.Push(CX);
    // PUSH DX (1000_C1BB / 0x1C1BB)
    Stack.Push(DX);
    // PUSH DI (1000_C1BC / 0x1C1BC)
    Stack.Push(DI);
    label_1000_C1BD_1C1BD:
    // LODSW ES:SI (1000_C1BD / 0x1C1BD)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,0x100 (1000_C1BF / 0x1C1BF)
    Alu.Sub16(AX, 0x100);
    // JNZ 0x1000:c1c9 (1000_C1C2 / 0x1C1C2)
    if(!ZeroFlag) {
      goto label_1000_C1C9_1C1C9;
    }
    // ADD SI,0x3 (1000_C1C4 / 0x1C1C4)
    // SI += 0x3;
    SI = Alu.Add16(SI, 0x3);
    // JMP 0x1000:c1bd (1000_C1C7 / 0x1C1C7)
    goto label_1000_C1BD_1C1BD;
    label_1000_C1C9_1C1C9:
    // MOV BX,AX (1000_C1C9 / 0x1C1C9)
    BX = AX;
    // INC AX (1000_C1CB / 0x1C1CB)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:c1f0 (1000_C1CC / 0x1C1CC)
    if(ZeroFlag) {
      goto label_1000_C1F0_1C1F0;
    }
    // MOV CL,BH (1000_C1CE / 0x1C1CE)
    CL = BH;
    // XOR BH,BH (1000_C1D0 / 0x1C1D0)
    BH = 0;
    // AND CX,0xff (1000_C1D2 / 0x1C1D2)
    // CX &= 0xFF;
    CX = Alu.And16(CX, 0xFF);
    // JNZ 0x1000:c1da (1000_C1D6 / 0x1C1D6)
    if(!ZeroFlag) {
      goto label_1000_C1DA_1C1DA;
    }
    // INC CH (1000_C1D8 / 0x1C1D8)
    CH = Alu.Inc8(CH);
    label_1000_C1DA_1C1DA:
    // MOV AX,BX (1000_C1DA / 0x1C1DA)
    AX = BX;
    // ADD BX,BX (1000_C1DC / 0x1C1DC)
    BX += BX;
    // ADD BX,AX (1000_C1DE / 0x1C1DE)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // MOV AX,CX (1000_C1E0 / 0x1C1E0)
    AX = CX;
    // ADD CX,CX (1000_C1E2 / 0x1C1E2)
    CX += CX;
    // ADD CX,AX (1000_C1E4 / 0x1C1E4)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // MOV DX,SI (1000_C1E6 / 0x1C1E6)
    DX = SI;
    // ADD SI,CX (1000_C1E8 / 0x1C1E8)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    // CALLF [0x38bd] (1000_C1EA / 0x1C1EA)
    // Indirect call to [0x38bd], generating possible targets from emulator records
    uint targetAddress_1000_C1EA = (uint)(UInt16[DS, 0x38BF] * 0x10 + UInt16[DS, 0x38BD] - cs1 * 0x10);
    switch(targetAddress_1000_C1EA) {
      case 0x235B6 : FarCall(cs1, 0xC1EE, spice86_generated_label_call_target_334B_0106_0335B6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C1EA));
        break;
    }
    label_1000_C1EE_1C1EE:
    // JMP 0x1000:c1bd (1000_C1EE / 0x1C1EE)
    goto label_1000_C1BD_1C1BD;
    label_1000_C1F0_1C1F0:
    // POP DI (1000_C1F0 / 0x1C1F0)
    DI = Stack.Pop();
    // POP DX (1000_C1F1 / 0x1C1F1)
    DX = Stack.Pop();
    // POP CX (1000_C1F2 / 0x1C1F2)
    CX = Stack.Pop();
    // RET  (1000_C1F3 / 0x1C1F3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C1F4_01C1F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C1F4_1C1F4:
    // PUSH BX (1000_C1F4 / 0x1C1F4)
    Stack.Push(BX);
    // LES SI,[0xdbb0] (1000_C1F5 / 0x1C1F5)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BX,AX (1000_C1F9 / 0x1C1F9)
    BX = AX;
    // SHL BX,1 (1000_C1FB / 0x1C1FB)
    BX <<= 0x1;
    // ADD SI,word ptr ES:[BX + SI] (1000_C1FD / 0x1C1FD)
    // SI += UInt16[ES, (ushort)(BX + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BX + SI)]);
    // POP BX (1000_C200 / 0x1C200)
    BX = Stack.Pop();
    // RET  (1000_C201 / 0x1C201)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C202_01C202(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C202_1C202:
    // PUSH AX (1000_C202 / 0x1C202)
    Stack.Push(AX);
    // PUSH SI (1000_C203 / 0x1C203)
    Stack.Push(SI);
    // CALL 0x1000:c1f4 (1000_C204 / 0x1C204)
    NearCall(cs1, 0xC207, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C207_01C207, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C207_01C207(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C207_1C207:
    // LODSW ES:SI (1000_C207 / 0x1C207)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // AND AH,0xf (1000_C209 / 0x1C209)
    AH &= 0xF;
    // SHR AX,1 (1000_C20C / 0x1C20C)
    AX >>= 0x1;
    // SUB DX,AX (1000_C20E / 0x1C20E)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // LODSB ES:SI (1000_C210 / 0x1C210)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // SHR AL,1 (1000_C212 / 0x1C212)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // CBW  (1000_C214 / 0x1C214)
    AX = (ushort)((short)((sbyte)AL));
    // SUB BX,AX (1000_C215 / 0x1C215)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // POP SI (1000_C217 / 0x1C217)
    SI = Stack.Pop();
    // POP AX (1000_C218 / 0x1C218)
    AX = Stack.Pop();
    // RET  (1000_C219 / 0x1C219)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C21B_01C21B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C21B_1C21B:
    // LODSW SI (1000_C21B / 0x1C21B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,0xffff (1000_C21C / 0x1C21C)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:c26a (1000_C21F / 0x1C21F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C26A / 0x1C26A)
      return NearRet();
    }
    // MOV BX,AX (1000_C221 / 0x1C221)
    BX = AX;
    // LODSW SI (1000_C223 / 0x1C223)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_C224 / 0x1C224)
    DX = AX;
    // LODSW SI (1000_C226 / 0x1C226)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,BX (1000_C227 / 0x1C227)
    ushort tmp_1000_C227 = AX;
    AX = BX;
    BX = tmp_1000_C227;
    // PUSH SI (1000_C228 / 0x1C228)
    Stack.Push(SI);
    // CALL 0x1000:c22f (1000_C229 / 0x1C229)
    NearCall(cs1, 0xC22C, spice86_generated_label_call_target_1000_C22F_01C22F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C22C_01C22C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C22C_01C22C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C22C_1C22C:
    // POP SI (1000_C22C / 0x1C22C)
    SI = Stack.Pop();
    // JMP 0x1000:c21b (1000_C22D / 0x1C22D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C21B_01C21B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C22F_01C22F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C22F_1C22F:
    // MOV ES,word ptr [0xdbda] (1000_C22F / 0x1C22F)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_C233 / 0x1C233)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C237 / 0x1C237)
    BP = AX;
    // AND BP,0x1ff (1000_C239 / 0x1C239)
    BP &= 0x1FF;
    // SHL BP,1 (1000_C23D / 0x1C23D)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_C23F / 0x1C23F)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // MOV CX,AX (1000_C242 / 0x1C242)
    CX = AX;
    // PUSH AX (1000_C244 / 0x1C244)
    Stack.Push(AX);
    // LODSW SI (1000_C245 / 0x1C245)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // AND CH,0x60 (1000_C246 / 0x1C246)
    // CH &= 0x60;
    CH = Alu.And8(CH, 0x60);
    // OR AH,CH (1000_C249 / 0x1C249)
    // AH |= CH;
    AH = Alu.Or8(AH, CH);
    // MOV DI,AX (1000_C24B / 0x1C24B)
    DI = AX;
    // LODSW SI (1000_C24D / 0x1C24D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_C24E / 0x1C24E)
    CX = AX;
    // CMP byte ptr CS:[0xc21a],0x0 (1000_C250 / 0x1C250)
    Alu.Sub8(UInt8[cs1, 0xC21A], 0x0);
    // JZ 0x1000:c25d (1000_C256 / 0x1C256)
    if(ZeroFlag) {
      goto label_1000_C25D_1C25D;
    }
    // MOV CH,byte ptr CS:[0xc21a] (1000_C258 / 0x1C258)
    CH = UInt8[cs1, 0xC21A];
    label_1000_C25D_1C25D:
    // POP AX (1000_C25D / 0x1C25D)
    AX = Stack.Pop();
    // AND AX,0x1c00 (1000_C25E / 0x1C25E)
    // AX &= 0x1C00;
    AX = Alu.And16(AX, 0x1C00);
    // JNZ 0x1000:c26b (1000_C261 / 0x1C261)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C26B_01C26B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALLF [0x38c9] (1000_C263 / 0x1C263)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_C263 = (uint)(UInt16[SS, 0x38CB] * 0x10 + UInt16[SS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_C263) {
      case 0x235BF : FarCall(cs1, 0xC268, spice86_generated_label_call_target_334B_010F_0335BF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C263));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C268_01C268, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C268_01C268(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC26A: goto label_1000_C26A_1C26A;break; // Target of external jump from 0x1C21F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C268_1C268:
    // PUSH SS (1000_C268 / 0x1C268)
    Stack.Push(SS);
    // POP DS (1000_C269 / 0x1C269)
    DS = Stack.Pop();
    label_1000_C26A_1C26A:
    // RET  (1000_C26A / 0x1C26A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_C26B_01C26B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C26B_1C26B:
    // XCHG AL,AH (1000_C26B / 0x1C26B)
    byte tmp_1000_C26B = AL;
    AL = AH;
    AH = tmp_1000_C26B;
    // MOV BP,AX (1000_C26D / 0x1C26D)
    BP = AX;
    // SHR BP,1 (1000_C26F / 0x1C26F)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x2774] (1000_C271 / 0x1C271)
    BP = UInt16[SS, (ushort)(BP + 0x2774)];
    // MOV AX,DI (1000_C275 / 0x1C275)
    AX = DI;
    // AND AX,0x1ff (1000_C277 / 0x1C277)
    // AX &= 0x1FF;
    AX = Alu.And16(AX, 0x1FF);
    // PUSH DX (1000_C27A / 0x1C27A)
    Stack.Push(DX);
    // XCHG AL,AH (1000_C27B / 0x1C27B)
    byte tmp_1000_C27B = AL;
    AL = AH;
    AH = tmp_1000_C27B;
    // XOR DX,DX (1000_C27D / 0x1C27D)
    DX = 0;
    // DIV BP (1000_C27F / 0x1C27F)
    Cpu.Div16(BP);
    // POP DX (1000_C281 / 0x1C281)
    DX = Stack.Pop();
    // PUSH AX (1000_C282 / 0x1C282)
    Stack.Push(AX);
    // MOV AX,CX (1000_C283 / 0x1C283)
    AX = CX;
    // XOR AH,AH (1000_C285 / 0x1C285)
    AH = 0;
    // PUSH DX (1000_C287 / 0x1C287)
    Stack.Push(DX);
    // XCHG AL,AH (1000_C288 / 0x1C288)
    byte tmp_1000_C288 = AL;
    AL = AH;
    AH = tmp_1000_C288;
    // XOR DX,DX (1000_C28A / 0x1C28A)
    DX = 0;
    // DIV BP (1000_C28C / 0x1C28C)
    Cpu.Div16(BP);
    // POP DX (1000_C28E / 0x1C28E)
    DX = Stack.Pop();
    // MOV CL,AL (1000_C28F / 0x1C28F)
    CL = AL;
    // POP AX (1000_C291 / 0x1C291)
    AX = Stack.Pop();
    // OR DI,DI (1000_C292 / 0x1C292)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNS 0x1000:c299 (1000_C294 / 0x1C294)
    if(!SignFlag) {
      goto label_1000_C299_1C299;
    }
    // CALL 0x1000:c2a1 (1000_C296 / 0x1C296)
    NearCall(cs1, 0xC299, spice86_generated_label_call_target_1000_C2A1_01C2A1);
    label_1000_C299_1C299:
    // CALLF [0x3941] (1000_C299 / 0x1C299)
    // Indirect call to [0x3941], generating possible targets from emulator records
    uint targetAddress_1000_C299 = (uint)(UInt16[SS, 0x3943] * 0x10 + UInt16[SS, 0x3941] - cs1 * 0x10);
    switch(targetAddress_1000_C299) {
      case 0x23619 : FarCall(cs1, 0xC29E, spice86_generated_label_call_target_334B_0169_033619); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C299));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C29E_01C29E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C29E_01C29E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C29E_1C29E:
    // PUSH SS (1000_C29E / 0x1C29E)
    Stack.Push(SS);
    // POP DS (1000_C29F / 0x1C29F)
    DS = Stack.Pop();
    // RET  (1000_C2A0 / 0x1C2A0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C2A1_01C2A1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C2A1_1C2A1:
    // PUSH AX (1000_C2A1 / 0x1C2A1)
    Stack.Push(AX);
    // PUSH BX (1000_C2A2 / 0x1C2A2)
    Stack.Push(BX);
    // PUSH CX (1000_C2A3 / 0x1C2A3)
    Stack.Push(CX);
    // PUSH DI (1000_C2A4 / 0x1C2A4)
    Stack.Push(DI);
    // PUSH ES (1000_C2A5 / 0x1C2A5)
    Stack.Push(ES);
    // PUSH BP (1000_C2A6 / 0x1C2A6)
    Stack.Push(BP);
    // PUSH SS (1000_C2A7 / 0x1C2A7)
    Stack.Push(SS);
    // POP ES (1000_C2A8 / 0x1C2A8)
    ES = Stack.Pop();
    // MOV BP,DI (1000_C2A9 / 0x1C2A9)
    BP = DI;
    // MOV DI,0x4c60 (1000_C2AB / 0x1C2AB)
    DI = 0x4C60;
    // AND BP,0x1ff (1000_C2AE / 0x1C2AE)
    BP &= 0x1FF;
    // ADD BP,0x3 (1000_C2B2 / 0x1C2B2)
    BP += 0x3;
    // SHR BP,1 (1000_C2B5 / 0x1C2B5)
    BP >>= 0x1;
    // SHR BP,1 (1000_C2B7 / 0x1C2B7)
    BP >>= 0x1;
    // SHL BP,1 (1000_C2B9 / 0x1C2B9)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV CX,word ptr [SI + -0x2] (1000_C2BB / 0x1C2BB)
    CX = UInt16[DS, (ushort)(SI - 0x2)];
    // XOR CH,CH (1000_C2BE / 0x1C2BE)
    CH = 0;
    label_1000_C2C0_1C2C0:
    // PUSH CX (1000_C2C0 / 0x1C2C0)
    Stack.Push(CX);
    // MOV BX,BP (1000_C2C1 / 0x1C2C1)
    BX = BP;
    label_1000_C2C3_1C2C3:
    // LODSB SI (1000_C2C3 / 0x1C2C3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST AL,0x80 (1000_C2C4 / 0x1C2C4)
    Alu.And8(AL, 0x80);
    // JNZ 0x1000:c2d6 (1000_C2C6 / 0x1C2C6)
    if(!ZeroFlag) {
      goto label_1000_C2D6_1C2D6;
    }
    // MOV CL,0x1 (1000_C2C8 / 0x1C2C8)
    CL = 0x1;
    // ADD CL,AL (1000_C2CA / 0x1C2CA)
    CL += AL;
    // XOR CH,CH (1000_C2CC / 0x1C2CC)
    CH = 0;
    // SUB BX,CX (1000_C2CE / 0x1C2CE)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_C2D0 / 0x1C2D0)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // JNZ 0x1000:c2c3 (1000_C2D2 / 0x1C2D2)
    if(!ZeroFlag) {
      goto label_1000_C2C3_1C2C3;
    }
    // JMP 0x1000:c2e3 (1000_C2D4 / 0x1C2D4)
    goto label_1000_C2E3_1C2E3;
    label_1000_C2D6_1C2D6:
    // MOV CL,0x1 (1000_C2D6 / 0x1C2D6)
    CL = 0x1;
    // SUB CL,AL (1000_C2D8 / 0x1C2D8)
    CL -= AL;
    // XOR CH,CH (1000_C2DA / 0x1C2DA)
    CH = 0;
    // SUB BX,CX (1000_C2DC / 0x1C2DC)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // LODSB SI (1000_C2DE / 0x1C2DE)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_C2DF / 0x1C2DF)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // JNZ 0x1000:c2c3 (1000_C2E1 / 0x1C2E1)
    if(!ZeroFlag) {
      goto label_1000_C2C3_1C2C3;
    }
    label_1000_C2E3_1C2E3:
    // POP CX (1000_C2E3 / 0x1C2E3)
    CX = Stack.Pop();
    // LOOP 0x1000:c2c0 (1000_C2E4 / 0x1C2E4)
    if(--CX != 0) {
      goto label_1000_C2C0_1C2C0;
    }
    // MOV SI,0x4c60 (1000_C2E6 / 0x1C2E6)
    SI = 0x4C60;
    // PUSH SS (1000_C2E9 / 0x1C2E9)
    Stack.Push(SS);
    // POP DS (1000_C2EA / 0x1C2EA)
    DS = Stack.Pop();
    // POP BP (1000_C2EB / 0x1C2EB)
    BP = Stack.Pop();
    // POP ES (1000_C2EC / 0x1C2EC)
    ES = Stack.Pop();
    // POP DI (1000_C2ED / 0x1C2ED)
    DI = Stack.Pop();
    // POP CX (1000_C2EE / 0x1C2EE)
    CX = Stack.Pop();
    // POP BX (1000_C2EF / 0x1C2EF)
    BX = Stack.Pop();
    // POP AX (1000_C2F0 / 0x1C2F0)
    AX = Stack.Pop();
    // RET  (1000_C2F1 / 0x1C2F1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C2F2_01C2F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C2F2_1C2F2:
    // XOR AH,AH (1000_C2F2 / 0x1C2F2)
    AH = 0;
    // CALL 0x1000:c13e (1000_C2F4 / 0x1C2F4)
    NearCall(cs1, 0xC2F7, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C2F7_01C2F7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C2F7_01C2F7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C2F7_1C2F7:
    // XOR AX,AX (1000_C2F7 / 0x1C2F7)
    AX = 0;
    // XOR BX,BX (1000_C2F9 / 0x1C2F9)
    BX = 0;
    // XOR DX,DX (1000_C2FB / 0x1C2FB)
    DX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2FD_01C2FD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C2FD_01C2FD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C2FD_1C2FD:
    // PUSH BX (1000_C2FD / 0x1C2FD)
    Stack.Push(BX);
    // PUSH DX (1000_C2FE / 0x1C2FE)
    Stack.Push(DX);
    // CALL 0x1000:c22f (1000_C2FF / 0x1C2FF)
    NearCall(cs1, 0xC302, spice86_generated_label_call_target_1000_C22F_01C22F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C302_01C302, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C302_01C302(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C302_1C302:
    // POP DX (1000_C302 / 0x1C302)
    DX = Stack.Pop();
    // POP BX (1000_C303 / 0x1C303)
    BX = Stack.Pop();
    // RET  (1000_C304 / 0x1C304)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C305_01C305(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C305_1C305:
    // PUSH BX (1000_C305 / 0x1C305)
    Stack.Push(BX);
    // PUSH DX (1000_C306 / 0x1C306)
    Stack.Push(DX);
    // CALL 0x1000:c30d (1000_C307 / 0x1C307)
    NearCall(cs1, 0xC30A, spice86_generated_label_call_target_1000_C30D_01C30D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C30A_01C30A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C30A_01C30A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C30A_1C30A:
    // POP DX (1000_C30A / 0x1C30A)
    DX = Stack.Pop();
    // POP BX (1000_C30B / 0x1C30B)
    BX = Stack.Pop();
    // RET  (1000_C30C / 0x1C30C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C30D_01C30D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C30D_1C30D:
    // MOV ES,word ptr [0xdbda] (1000_C30D / 0x1C30D)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_C311 / 0x1C311)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C315 / 0x1C315)
    BP = AX;
    // SHL BP,1 (1000_C317 / 0x1C317)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_C319 / 0x1C319)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_C31C / 0x1C31C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C31D / 0x1C31D)
    DI = AX;
    // LODSW SI (1000_C31F / 0x1C31F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_C320 / 0x1C320)
    AH = 0;
    // MOV CX,AX (1000_C322 / 0x1C322)
    CX = AX;
    // MOV BP,0xd834 (1000_C324 / 0x1C324)
    BP = 0xD834;
    // CALLF [0x38cd] (1000_C327 / 0x1C327)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_C327 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_C327) {
      case 0x235C2 : FarCall(cs1, 0xC32C, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C327));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C32C_01C32C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C32C_01C32C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C32C_1C32C:
    // PUSH SS (1000_C32C / 0x1C32C)
    Stack.Push(SS);
    // POP DS (1000_C32D / 0x1C32D)
    DS = Stack.Pop();
    // RET  (1000_C32E / 0x1C32E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C343_01C343(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C343_1C343:
    // MOV ES,word ptr [0xdbda] (1000_C343 / 0x1C343)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_C347 / 0x1C347)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C34B / 0x1C34B)
    BP = AX;
    // SHL BP,1 (1000_C34D / 0x1C34D)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_C34F / 0x1C34F)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_C352 / 0x1C352)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C353 / 0x1C353)
    DI = AX;
    // AND AH,0xf (1000_C355 / 0x1C355)
    AH &= 0xF;
    // SHR AX,1 (1000_C358 / 0x1C358)
    AX >>= 0x1;
    // SUB DX,AX (1000_C35A / 0x1C35A)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // LODSW SI (1000_C35C / 0x1C35C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_C35D / 0x1C35D)
    AH = 0;
    // MOV CX,AX (1000_C35F / 0x1C35F)
    CX = AX;
    // SHR AX,1 (1000_C361 / 0x1C361)
    AX >>= 0x1;
    // SUB BX,AX (1000_C363 / 0x1C363)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // MOV BP,0xd834 (1000_C365 / 0x1C365)
    BP = 0xD834;
    // CALLF [0x38cd] (1000_C368 / 0x1C368)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_C368 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_C368) {
      case 0x235C2 : FarCall(cs1, 0xC36D, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C368));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C36D_01C36D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C36D_01C36D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C36D_1C36D:
    // PUSH SS (1000_C36D / 0x1C36D)
    Stack.Push(SS);
    // POP DS (1000_C36E / 0x1C36E)
    DS = Stack.Pop();
    // RET  (1000_C36F / 0x1C36F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C370_01C370(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C370_1C370:
    // PUSH DS (1000_C370 / 0x1C370)
    Stack.Push(DS);
    // PUSH DS (1000_C371 / 0x1C371)
    Stack.Push(DS);
    // PUSH AX (1000_C372 / 0x1C372)
    Stack.Push(AX);
    // PUSH SI (1000_C373 / 0x1C373)
    Stack.Push(SI);
    // CALLF [0x38d9] (1000_C374 / 0x1C374)
    // Indirect call to [0x38d9], generating possible targets from emulator records
    uint targetAddress_1000_C374 = (uint)(UInt16[DS, 0x38DB] * 0x10 + UInt16[DS, 0x38D9] - cs1 * 0x10);
    switch(targetAddress_1000_C374) {
      case 0x235CB : FarCall(cs1, 0xC378, spice86_generated_label_call_target_334B_011B_0335CB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C374));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C378_01C378, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C378_01C378(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C378_1C378:
    // POP SI (1000_C378 / 0x1C378)
    SI = Stack.Pop();
    // POP AX (1000_C379 / 0x1C379)
    AX = Stack.Pop();
    // POP DS (1000_C37A / 0x1C37A)
    DS = Stack.Pop();
    // MOV DX,word ptr [SI] (1000_C37B / 0x1C37B)
    DX = UInt16[DS, SI];
    // PUSH DX (1000_C37D / 0x1C37D)
    Stack.Push(DX);
    // MOV BX,word ptr [SI + 0x2] (1000_C37E / 0x1C37E)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // PUSH BX (1000_C381 / 0x1C381)
    Stack.Push(BX);
    // MOV CX,word ptr [SI + 0x4] (1000_C382 / 0x1C382)
    CX = UInt16[DS, (ushort)(SI + 0x4)];
    // SUB CX,DX (1000_C385 / 0x1C385)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // PUSH CX (1000_C387 / 0x1C387)
    Stack.Push(CX);
    // MOV CX,word ptr [SI + 0x6] (1000_C388 / 0x1C388)
    CX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB CX,BX (1000_C38B / 0x1C38B)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    // PUSH CX (1000_C38D / 0x1C38D)
    Stack.Push(CX);
    // LDS SI,[0xdbb0] (1000_C38E / 0x1C38E)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C392 / 0x1C392)
    BP = AX;
    // SHL BP,1 (1000_C394 / 0x1C394)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_C396 / 0x1C396)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_C399 / 0x1C399)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C39A / 0x1C39A)
    DI = AX;
    // AND AX,0x1ff (1000_C39C / 0x1C39C)
    // AX &= 0x1FF;
    AX = Alu.And16(AX, 0x1FF);
    // PUSH AX (1000_C39F / 0x1C39F)
    Stack.Push(AX);
    // LODSW SI (1000_C3A0 / 0x1C3A0)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_C3A1 / 0x1C3A1)
    CX = AX;
    // XOR AH,AH (1000_C3A3 / 0x1C3A3)
    AH = 0;
    // PUSH AX (1000_C3A5 / 0x1C3A5)
    Stack.Push(AX);
    // CALLF [0x38c9] (1000_C3A6 / 0x1C3A6)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_C3A6 = (uint)(UInt16[SS, 0x38CB] * 0x10 + UInt16[SS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_C3A6) {
      case 0x235BF : FarCall(cs1, 0xC3AB, spice86_generated_label_call_target_334B_010F_0335BF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C3A6));
        break;
    }
    label_1000_C3AB_1C3AB:
    // PUSH ES (1000_C3AB / 0x1C3AB)
    Stack.Push(ES);
    // POP DS (1000_C3AC / 0x1C3AC)
    DS = Stack.Pop();
    // MOV BP,SP (1000_C3AD / 0x1C3AD)
    BP = SP;
    // MOV DX,word ptr [BP + 0xa] (1000_C3AF / 0x1C3AF)
    DX = UInt16[SS, (ushort)(BP + 0xA)];
    // MOV BX,word ptr [BP + 0x8] (1000_C3B2 / 0x1C3B2)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    // PUSH BX (1000_C3B5 / 0x1C3B5)
    Stack.Push(BX);
    // PUSH DX (1000_C3B6 / 0x1C3B6)
    Stack.Push(DX);
    // PUSH word ptr [BP + 0x0] (1000_C3B7 / 0x1C3B7)
    Stack.Push(UInt16[SS, BP]);
    // PUSH word ptr [BP + 0x2] (1000_C3BA / 0x1C3BA)
    Stack.Push(UInt16[SS, (ushort)(BP + 0x2)]);
    // PUSH BX (1000_C3BD / 0x1C3BD)
    Stack.Push(BX);
    // PUSH DX (1000_C3BE / 0x1C3BE)
    Stack.Push(DX);
    // MOV BP,SP (1000_C3BF / 0x1C3BF)
    BP = SP;
    // MOV DX,word ptr [BP + 0x12] (1000_C3C1 / 0x1C3C1)
    DX = UInt16[SS, (ushort)(BP + 0x12)];
    // SUB DX,word ptr [BP + 0x4] (1000_C3C4 / 0x1C3C4)
    // DX -= UInt16[SS, (ushort)(BP + 0x4)];
    DX = Alu.Sub16(DX, UInt16[SS, (ushort)(BP + 0x4)]);
    label_1000_C3C7_1C3C7:
    // MOV AX,word ptr [BP + 0x4] (1000_C3C7 / 0x1C3C7)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // ADD word ptr [BP + 0x8],AX (1000_C3CA / 0x1C3CA)
    UInt16[SS, (ushort)(BP + 0x8)] += AX;
    // SUB DX,AX (1000_C3CD / 0x1C3CD)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // JNC 0x1000:c3d4 (1000_C3CF / 0x1C3CF)
    if(!CarryFlag) {
      goto label_1000_C3D4_1C3D4;
    }
    // ADD word ptr [BP + 0x4],DX (1000_C3D1 / 0x1C3D1)
    // UInt16[SS, (ushort)(BP + 0x4)] += DX;
    UInt16[SS, (ushort)(BP + 0x4)] = Alu.Add16(UInt16[SS, (ushort)(BP + 0x4)], DX);
    label_1000_C3D4_1C3D4:
    // PUSH DX (1000_C3D4 / 0x1C3D4)
    Stack.Push(DX);
    // CALLF [0x3931] (1000_C3D5 / 0x1C3D5)
    // Indirect call to [0x3931], generating possible targets from emulator records
    uint targetAddress_1000_C3D5 = (uint)(UInt16[SS, 0x3933] * 0x10 + UInt16[SS, 0x3931] - cs1 * 0x10);
    switch(targetAddress_1000_C3D5) {
      case 0x2360D : FarCall(cs1, 0xC3DA, spice86_generated_label_call_target_334B_015D_03360D); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C3D5));
        break;
    }
    label_1000_C3DA_1C3DA:
    // POP DX (1000_C3DA / 0x1C3DA)
    DX = Stack.Pop();
    // CMP DX,0x0 (1000_C3DB / 0x1C3DB)
    Alu.Sub16(DX, 0x0);
    // JG 0x1000:c3c7 (1000_C3DE / 0x1C3DE)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_C3C7_1C3C7;
    }
    // MOV AX,word ptr [BP + 0x12] (1000_C3E0 / 0x1C3E0)
    AX = UInt16[SS, (ushort)(BP + 0x12)];
    // MOV word ptr [BP + 0x4],AX (1000_C3E3 / 0x1C3E3)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV AX,word ptr [BP + 0x0] (1000_C3E6 / 0x1C3E6)
    AX = UInt16[SS, BP];
    // MOV word ptr [BP + 0x8],AX (1000_C3E9 / 0x1C3E9)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    // MOV BX,word ptr [BP + 0x10] (1000_C3EC / 0x1C3EC)
    BX = UInt16[SS, (ushort)(BP + 0x10)];
    // SUB BX,word ptr [BP + 0x6] (1000_C3EF / 0x1C3EF)
    // BX -= UInt16[SS, (ushort)(BP + 0x6)];
    BX = Alu.Sub16(BX, UInt16[SS, (ushort)(BP + 0x6)]);
    // JZ 0x1000:c40d (1000_C3F2 / 0x1C3F2)
    if(ZeroFlag) {
      goto label_1000_C40D_1C40D;
    }
    label_1000_C3F4_1C3F4:
    // MOV AX,word ptr [BP + 0x6] (1000_C3F4 / 0x1C3F4)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // ADD word ptr [BP + 0xa],AX (1000_C3F7 / 0x1C3F7)
    UInt16[SS, (ushort)(BP + 0xA)] += AX;
    // SUB BX,AX (1000_C3FA / 0x1C3FA)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // JNC 0x1000:c401 (1000_C3FC / 0x1C3FC)
    if(!CarryFlag) {
      goto label_1000_C401_1C401;
    }
    // ADD word ptr [BP + 0x6],BX (1000_C3FE / 0x1C3FE)
    // UInt16[SS, (ushort)(BP + 0x6)] += BX;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu.Add16(UInt16[SS, (ushort)(BP + 0x6)], BX);
    label_1000_C401_1C401:
    // PUSH BX (1000_C401 / 0x1C401)
    Stack.Push(BX);
    // CALLF [0x3931] (1000_C402 / 0x1C402)
    // Indirect call to [0x3931], generating possible targets from emulator records
    uint targetAddress_1000_C402 = (uint)(UInt16[SS, 0x3933] * 0x10 + UInt16[SS, 0x3931] - cs1 * 0x10);
    switch(targetAddress_1000_C402) {
      case 0x2360D : FarCall(cs1, 0xC407, spice86_generated_label_call_target_334B_015D_03360D); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C402));
        break;
    }
    label_1000_C407_1C407:
    // POP BX (1000_C407 / 0x1C407)
    BX = Stack.Pop();
    // CMP BX,0x0 (1000_C408 / 0x1C408)
    Alu.Sub16(BX, 0x0);
    // JG 0x1000:c3f4 (1000_C40B / 0x1C40B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_C3F4_1C3F4;
    }
    label_1000_C40D_1C40D:
    // ADD SP,0x18 (1000_C40D / 0x1C40D)
    // SP += 0x18;
    SP = Alu.Add16(SP, 0x18);
    // POP DS (1000_C410 / 0x1C410)
    DS = Stack.Pop();
    // RET  (1000_C411 / 0x1C411)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C412_01C412(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C412_1C412:
    // PUSH DS (1000_C412 / 0x1C412)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbde] (1000_C413 / 0x1C413)
    ES = UInt16[DS, 0xDBDE];
    // MOV DS,word ptr [0xdbda] (1000_C417 / 0x1C417)
    DS = UInt16[DS, 0xDBDA];
    // CALLF [0x38e1] (1000_C41B / 0x1C41B)
    // Indirect call to [0x38e1], generating possible targets from emulator records
    uint targetAddress_1000_C41B = (uint)(UInt16[SS, 0x38E3] * 0x10 + UInt16[SS, 0x38E1] - cs1 * 0x10);
    switch(targetAddress_1000_C41B) {
      case 0x235D1 : FarCall(cs1, 0xC420, spice86_generated_label_call_target_334B_0121_0335D1); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C41B));
        break;
    }
    label_1000_C420_1C420:
    // POP DS (1000_C420 / 0x1C420)
    DS = Stack.Pop();
    // RET  (1000_C421 / 0x1C421)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C432_01C432(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C432_1C432:
    // MOV SI,0x1470 (1000_C432 / 0x1C432)
    SI = 0x1470;
    // MOV ES,word ptr [0xdbda] (1000_C435 / 0x1C435)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38d9] (1000_C439 / 0x1C439)
    // Indirect call to [0x38d9], generating possible targets from emulator records
    uint targetAddress_1000_C439 = (uint)(UInt16[DS, 0x38DB] * 0x10 + UInt16[DS, 0x38D9] - cs1 * 0x10);
    switch(targetAddress_1000_C439) {
      case 0x235CB : FarCall(cs1, 0xC43D, spice86_generated_label_call_target_334B_011B_0335CB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C439));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C43D_01C43D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C43D_01C43D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C43D_1C43D:
    // RET  (1000_C43D / 0x1C43D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C43E_01C43E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C43E_1C43E:
    // MOV SI,0x1470 (1000_C43E / 0x1C43E)
    SI = 0x1470;
    // JMP 0x1000:c446 (1000_C441 / 0x1C441)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C446_01C446, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C443_01C443(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C443_1C443:
    // MOV SI,0xd834 (1000_C443 / 0x1C443)
    SI = 0xD834;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C446_01C446, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C446_01C446(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC449: goto label_1000_C449_1C449;break; // Target of external jump from 0x1C472
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C446_1C446:
    // MOV AX,[0xdbde] (1000_C446 / 0x1C446)
    AX = UInt16[DS, 0xDBDE];
    label_1000_C449_1C449:
    // PUSH CX (1000_C449 / 0x1C449)
    Stack.Push(CX);
    // MOV CX,AX (1000_C44A / 0x1C44A)
    CX = AX;
    // MOV DX,word ptr [SI] (1000_C44C / 0x1C44C)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C44E / 0x1C44E)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C451 / 0x1C451)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C454 / 0x1C454)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB BP,DX (1000_C457 / 0x1C457)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c46d (1000_C459 / 0x1C459)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C46D_1C46D;
    }
    // SUB AX,BX (1000_C45B / 0x1C45B)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c46d (1000_C45D / 0x1C45D)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C46D_1C46D;
    }
    // MOV ES,word ptr [0xdbd6] (1000_C45F / 0x1C45F)
    ES = UInt16[DS, 0xDBD6];
    // PUSH SI (1000_C463 / 0x1C463)
    Stack.Push(SI);
    // PUSH DS (1000_C464 / 0x1C464)
    Stack.Push(DS);
    // MOV SI,CX (1000_C465 / 0x1C465)
    SI = CX;
    // CALLF [0x38ed] (1000_C467 / 0x1C467)
    // Indirect call to [0x38ed], generating possible targets from emulator records
    uint targetAddress_1000_C467 = (uint)(UInt16[DS, 0x38EF] * 0x10 + UInt16[DS, 0x38ED] - cs1 * 0x10);
    switch(targetAddress_1000_C467) {
      case 0x235DA : FarCall(cs1, 0xC46B, spice86_generated_label_call_target_334B_012A_0335DA); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C467));
        break;
    }
    label_1000_C46B_1C46B:
    // POP DS (1000_C46B / 0x1C46B)
    DS = Stack.Pop();
    // POP SI (1000_C46C / 0x1C46C)
    SI = Stack.Pop();
    label_1000_C46D_1C46D:
    // POP CX (1000_C46D / 0x1C46D)
    CX = Stack.Pop();
    // RET  (1000_C46E / 0x1C46E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C46F_01C46F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C46F_1C46F:
    // MOV AX,[0xdc32] (1000_C46F / 0x1C46F)
    AX = UInt16[DS, 0xDC32];
    // JMP 0x1000:c449 (1000_C472 / 0x1C472)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C446_01C446, 0x1C449 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C474_01C474(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C474_1C474:
    // MOV SI,0x1470 (1000_C474 / 0x1C474)
    SI = 0x1470;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C477_01C477, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C477_01C477(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C477_1C477:
    // MOV DX,word ptr [SI] (1000_C477 / 0x1C477)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C479 / 0x1C479)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C47C / 0x1C47C)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C47F / 0x1C47F)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB BP,DX (1000_C482 / 0x1C482)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c499 (1000_C484 / 0x1C484)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C499 / 0x1C499)
      return NearRet();
    }
    // SUB AX,BX (1000_C486 / 0x1C486)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c499 (1000_C488 / 0x1C488)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C499 / 0x1C499)
      return NearRet();
    }
    // MOV ES,word ptr [0xdbde] (1000_C48A / 0x1C48A)
    ES = UInt16[DS, 0xDBDE];
    // PUSH DS (1000_C48E / 0x1C48E)
    Stack.Push(DS);
    // MOV DS,word ptr [0xdbd6] (1000_C48F / 0x1C48F)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x38e5] (1000_C493 / 0x1C493)
    // Indirect call to [0x38e5], generating possible targets from emulator records
    uint targetAddress_1000_C493 = (uint)(UInt16[SS, 0x38E7] * 0x10 + UInt16[SS, 0x38E5] - cs1 * 0x10);
    switch(targetAddress_1000_C493) {
      case 0x235D4 : FarCall(cs1, 0xC498, spice86_generated_label_call_target_334B_0124_0335D4); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C493));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C498_01C498, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C498_01C498(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC499: goto label_1000_C499_1C499;break; // Target of external jump from 0x1C484
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C498_1C498:
    // POP DS (1000_C498 / 0x1C498)
    DS = Stack.Pop();
    label_1000_C499_1C499:
    // RET  (1000_C499 / 0x1C499)
    return NearRet();
  }
  
  public virtual Action gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C49A_1C49A:
    // PUSH DS (1000_C49A / 0x1C49A)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd6] (1000_C49B / 0x1C49B)
    ES = UInt16[DS, 0xDBD6];
    // MOV DS,word ptr [0xdbd8] (1000_C49F / 0x1C49F)
    DS = UInt16[DS, 0xDBD8];
    // CALLF [0x38f1] (1000_C4A3 / 0x1C4A3)
    // Indirect call to [0x38f1], generating possible targets from emulator records
    uint targetAddress_1000_C4A3 = (uint)(UInt16[SS, 0x38F3] * 0x10 + UInt16[SS, 0x38F1] - cs1 * 0x10);
    switch(targetAddress_1000_C4A3) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C4A3));
        break;
    }
    // POP DS (1000_C4A8 / 0x1C4A8)
    DS = Stack.Pop();
    // RET  (1000_C4A9 / 0x1C4A9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C4AA_01C4AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4AA_1C4AA:
    // MOV DX,word ptr [SI] (1000_C4AA / 0x1C4AA)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C4AC / 0x1C4AC)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C4AF / 0x1C4AF)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C4B2 / 0x1C4B2)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB BP,DX (1000_C4B5 / 0x1C4B5)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c4cc (1000_C4B7 / 0x1C4B7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C4CC / 0x1C4CC)
      return NearRet();
    }
    // SUB AX,BX (1000_C4B9 / 0x1C4B9)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c4cc (1000_C4BB / 0x1C4BB)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C4CC / 0x1C4CC)
      return NearRet();
    }
    // PUSH DS (1000_C4BD / 0x1C4BD)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd6] (1000_C4BE / 0x1C4BE)
    ES = UInt16[DS, 0xDBD6];
    // MOV DS,word ptr [0xdbd8] (1000_C4C2 / 0x1C4C2)
    DS = UInt16[DS, 0xDBD8];
    // CALLF [0x38f5] (1000_C4C6 / 0x1C4C6)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C4C6 = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C4C6) {
      case 0x235E0 : FarCall(cs1, 0xC4CB, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C4C6));
        break;
    }
    label_1000_C4CB_1C4CB:
    // POP DS (1000_C4CB / 0x1C4CB)
    DS = Stack.Pop();
    label_1000_C4CC_1C4CC:
    // RET  (1000_C4CC / 0x1C4CC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C4CD_01C4CD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4CD_1C4CD:
    // PUSH DS (1000_C4CD / 0x1C4CD)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C4CE / 0x1C4CE)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C4D2 / 0x1C4D2)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x38f1] (1000_C4D6 / 0x1C4D6)
    // Indirect call to [0x38f1], generating possible targets from emulator records
    uint targetAddress_1000_C4D6 = (uint)(UInt16[SS, 0x38F3] * 0x10 + UInt16[SS, 0x38F1] - cs1 * 0x10);
    switch(targetAddress_1000_C4D6) {
      case 0x235DD : FarCall(cs1, 0xC4DB, spice86_generated_label_call_target_334B_012D_0335DD); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C4D6));
        break;
    }
    label_1000_C4DB_1C4DB:
    // POP DS (1000_C4DB / 0x1C4DB)
    DS = Stack.Pop();
    // RET  (1000_C4DC / 0x1C4DC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C4DD_01C4DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4DD_1C4DD:
    // MOV AX,[0xdc38] (1000_C4DD / 0x1C4DD)
    AX = UInt16[DS, 0xDC38];
    // CMP AX,0x98 (1000_C4E0 / 0x1C4E0)
    Alu.Sub16(AX, 0x98);
    // JNC 0x1000:c4e8 (1000_C4E3 / 0x1C4E3)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C4E8_01C4E8, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:dbb2 (1000_C4E5 / 0x1C4E5)
    NearCall(cs1, 0xC4E8, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C4E8_01C4E8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C4E8_01C4E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4E8_1C4E8:
    // MOV SI,0x1470 (1000_C4E8 / 0x1C4E8)
    SI = 0x1470;
    // JMP 0x1000:c4f0 (1000_C4EB / 0x1C4EB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C4ED_01C4ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4ED_1C4ED:
    // MOV SI,0xd834 (1000_C4ED / 0x1C4ED)
    SI = 0xD834;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C4F0_01C4F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4F0_1C4F0:
    // MOV DX,word ptr [SI] (1000_C4F0 / 0x1C4F0)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C4F2 / 0x1C4F2)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C4F5 / 0x1C4F5)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C4F8 / 0x1C4F8)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4FB_01C4FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C4FB_01C4FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C4FB_1C4FB:
    // CMP byte ptr [0x227d],0x0 (1000_C4FB / 0x1C4FB)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:c51e (1000_C500 / 0x1C500)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AX,0x89 (1000_C502 / 0x1C502)
    Alu.Sub16(AX, 0x89);
    // JL 0x1000:c51e (1000_C505 / 0x1C505)
    if(SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP BP,0x7e (1000_C507 / 0x1C507)
    Alu.Sub16(BP, 0x7E);
    // JL 0x1000:c51e (1000_C50B / 0x1C50B)
    if(SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP DX,0xc2 (1000_C50D / 0x1C50D)
    Alu.Sub16(DX, 0xC2);
    // JGE 0x1000:c51e (1000_C511 / 0x1C511)
    if(SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_C513 / 0x1C513)
    Stack.Push(AX);
    // PUSH BX (1000_C514 / 0x1C514)
    Stack.Push(BX);
    // PUSH DX (1000_C515 / 0x1C515)
    Stack.Push(DX);
    // PUSH BP (1000_C516 / 0x1C516)
    Stack.Push(BP);
    // CALL 0x1000:1797 (1000_C517 / 0x1C517)
    NearCall(cs1, 0xC51A, spice86_generated_label_call_target_1000_1797_011797);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C51A_01C51A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C51A_01C51A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C51A_1C51A:
    // POP BP (1000_C51A / 0x1C51A)
    BP = Stack.Pop();
    // POP DX (1000_C51B / 0x1C51B)
    DX = Stack.Pop();
    // POP BX (1000_C51C / 0x1C51C)
    BX = Stack.Pop();
    // POP AX (1000_C51D / 0x1C51D)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C51E_01C51E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C51E_1C51E:
    // SUB BP,DX (1000_C51E / 0x1C51E)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c53d (1000_C520 / 0x1C520)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    // SUB AX,BX (1000_C522 / 0x1C522)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c53d (1000_C524 / 0x1C524)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    label_1000_C526_1C526:
    // CMP word ptr [0x2570],0x1ad6 (1000_C526 / 0x1C526)
    Alu.Sub16(UInt16[DS, 0x2570], 0x1AD6);
    // JZ 0x1000:c53d (1000_C52C / 0x1C52C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    // PUSH DS (1000_C52E / 0x1C52E)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C52F / 0x1C52F)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C533 / 0x1C533)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x38f5] (1000_C537 / 0x1C537)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C537 = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C537) {
      case 0x235E0 : FarCall(cs1, 0xC53C, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C537));
        break;
    }
    label_1000_C53C_1C53C:
    // POP DS (1000_C53C / 0x1C53C)
    DS = Stack.Pop();
    label_1000_C53D_1C53D:
    // RET  (1000_C53D / 0x1C53D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C53E_01C53E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C53E_1C53E:
    // MOV SI,0x276a (1000_C53E / 0x1C53E)
    SI = 0x276A;
    // MOV BP,word ptr [0x2772] (1000_C541 / 0x1C541)
    BP = UInt16[DS, 0x2772];
    // MOV AL,[0xdbe4] (1000_C545 / 0x1C545)
    AL = UInt8[DS, 0xDBE4];
    // MOV ES,word ptr [0xdbda] (1000_C548 / 0x1C548)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x3901] (1000_C54C / 0x1C54C)
    // Indirect call to [0x3901], generating possible targets from emulator records
    uint targetAddress_1000_C54C = (uint)(UInt16[DS, 0x3903] * 0x10 + UInt16[DS, 0x3901] - cs1 * 0x10);
    switch(targetAddress_1000_C54C) {
      case 0x235E9 : FarCall(cs1, 0xC550, spice86_generated_label_call_target_334B_0139_0335E9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C54C));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C550_01C550, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C550_01C550(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C550_1C550:
    // RET  (1000_C550 / 0x1C550)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C551_01C551(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C551_1C551:
    // LODSW SI (1000_C551 / 0x1C551)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_C552 / 0x1C552)
    DX = AX;
    // LODSW SI (1000_C554 / 0x1C554)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_C555 / 0x1C555)
    BX = AX;
    // LODSW SI (1000_C557 / 0x1C557)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C558 / 0x1C558)
    DI = AX;
    // DEC DI (1000_C55A / 0x1C55A)
    DI = Alu.Dec16(DI);
    // LODSW SI (1000_C55B / 0x1C55B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_C55C / 0x1C55C)
    CX = AX;
    // DEC CX (1000_C55E / 0x1C55E)
    CX = Alu.Dec16(CX);
    // LODSB SI (1000_C55F / 0x1C55F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C560_01C560, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C560_01C560(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C560_1C560:
    // MOV [0xdbe4],AL (1000_C560 / 0x1C560)
    UInt8[DS, 0xDBE4] = AL;
    // PUSH BX (1000_C563 / 0x1C563)
    Stack.Push(BX);
    // PUSH CX (1000_C564 / 0x1C564)
    Stack.Push(CX);
    // PUSH DX (1000_C565 / 0x1C565)
    Stack.Push(DX);
    // PUSH DI (1000_C566 / 0x1C566)
    Stack.Push(DI);
    // MOV CX,BX (1000_C567 / 0x1C567)
    CX = BX;
    // CALL 0x1000:c53e (1000_C569 / 0x1C569)
    NearCall(cs1, 0xC56C, spice86_generated_label_call_target_1000_C53E_01C53E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C56C_01C56C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C56C_01C56C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C56C_1C56C:
    // MOV BP,SP (1000_C56C / 0x1C56C)
    BP = SP;
    // MOV CX,word ptr [BP + 0x4] (1000_C56E / 0x1C56E)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV BX,CX (1000_C571 / 0x1C571)
    BX = CX;
    // CALL 0x1000:c53e (1000_C573 / 0x1C573)
    NearCall(cs1, 0xC576, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C576_1C576:
    // MOV BP,SP (1000_C576 / 0x1C576)
    BP = SP;
    // MOV DI,DX (1000_C578 / 0x1C578)
    DI = DX;
    // MOV BX,word ptr [BP + 0x6] (1000_C57A / 0x1C57A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // CALL 0x1000:c53e (1000_C57D / 0x1C57D)
    NearCall(cs1, 0xC580, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C580_1C580:
    // POP DI (1000_C580 / 0x1C580)
    DI = Stack.Pop();
    // MOV DX,DI (1000_C581 / 0x1C581)
    DX = DI;
    // CALL 0x1000:c53e (1000_C583 / 0x1C583)
    NearCall(cs1, 0xC586, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C586_1C586:
    // POP DX (1000_C586 / 0x1C586)
    DX = Stack.Pop();
    // POP CX (1000_C587 / 0x1C587)
    CX = Stack.Pop();
    // POP BX (1000_C588 / 0x1C588)
    BX = Stack.Pop();
    // RET  (1000_C589 / 0x1C589)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C58A_01C58A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C58A_1C58A:
    // CALL 0x1000:c13b (1000_C58A / 0x1C58A)
    NearCall(cs1, 0xC58D, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C58D_01C58D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C58D_01C58D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C58D_1C58D:
    // MOV SI,0x3cbe (1000_C58D / 0x1C58D)
    SI = 0x3CBE;
    // LODSW SI (1000_C590 / 0x1C590)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_C591 / 0x1C591)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:c5ce (1000_C593 / 0x1C593)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C5CE / 0x1C5CE)
      return NearRet();
    }
    // MOV AH,0x11 (1000_C595 / 0x1C595)
    AH = 0x11;
    // MUL AH (1000_C597 / 0x1C597)
    Cpu.Mul8(AH);
    // ADD SI,AX (1000_C599 / 0x1C599)
    SI += AX;
    // CMP DI,SI (1000_C59B / 0x1C59B)
    Alu.Sub16(DI, SI);
    // JNC 0x1000:c5ce (1000_C59D / 0x1C59D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_C5CE / 0x1C5CE)
      return NearRet();
    }
    // OR byte ptr [DI + 0xc],0x80 (1000_C59F / 0x1C59F)
    // UInt8[DS, (ushort)(DI + 0xC)] |= 0x80;
    UInt8[DS, (ushort)(DI + 0xC)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xC)], 0x80);
    // PUSH SI (1000_C5A3 / 0x1C5A3)
    Stack.Push(SI);
    // PUSH DI (1000_C5A4 / 0x1C5A4)
    Stack.Push(DI);
    // MOV SI,DI (1000_C5A5 / 0x1C5A5)
    SI = DI;
    // CALL 0x1000:c6ad (1000_C5A7 / 0x1C5A7)
    NearCall(cs1, 0xC5AA, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C5AA_01C5AA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C5AA_01C5AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C5AA_1C5AA:
    // POP DI (1000_C5AA / 0x1C5AA)
    DI = Stack.Pop();
    // POP CX (1000_C5AB / 0x1C5AB)
    CX = Stack.Pop();
    // PUSH DI (1000_C5AC / 0x1C5AC)
    Stack.Push(DI);
    // LEA SI,[DI + 0x11] (1000_C5AD / 0x1C5AD)
    SI = (ushort)(DI + 0x11);
    // SUB CX,SI (1000_C5B0 / 0x1C5B0)
    // CX -= SI;
    CX = Alu.Sub16(CX, SI);
    // JZ 0x1000:c5b8 (1000_C5B2 / 0x1C5B2)
    if(ZeroFlag) {
      goto label_1000_C5B8_1C5B8;
    }
    // PUSH DS (1000_C5B4 / 0x1C5B4)
    Stack.Push(DS);
    // POP ES (1000_C5B5 / 0x1C5B5)
    ES = Stack.Pop();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_C5B6 / 0x1C5B6)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    label_1000_C5B8_1C5B8:
    // DEC word ptr [0x3cbe] (1000_C5B8 / 0x1C5B8)
    UInt16[DS, 0x3CBE] = Alu.Dec16(UInt16[DS, 0x3CBE]);
    // POP DI (1000_C5BC / 0x1C5BC)
    DI = Stack.Pop();
    // MOV SI,0x4752 (1000_C5BD / 0x1C5BD)
    SI = 0x4752;
    // MOV CX,0x2 (1000_C5C0 / 0x1C5C0)
    CX = 0x2;
    label_1000_C5C3_1C5C3:
    // LODSW SI (1000_C5C3 / 0x1C5C3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,DI (1000_C5C4 / 0x1C5C4)
    Alu.Sub16(AX, DI);
    // JC 0x1000:c5cc (1000_C5C6 / 0x1C5C6)
    if(CarryFlag) {
      goto label_1000_C5CC_1C5CC;
    }
    // SUB word ptr [SI + -0x2],0x11 (1000_C5C8 / 0x1C5C8)
    // UInt16[DS, (ushort)(SI - 0x2)] -= 0x11;
    UInt16[DS, (ushort)(SI - 0x2)] = Alu.Sub16(UInt16[DS, (ushort)(SI - 0x2)], 0x11);
    label_1000_C5CC_1C5CC:
    // LOOP 0x1000:c5c3 (1000_C5CC / 0x1C5CC)
    if(--CX != 0) {
      goto label_1000_C5C3_1C5C3;
    }
    label_1000_C5CE_1C5CE:
    // RET  (1000_C5CE / 0x1C5CE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C5CF_01C5CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C5CF_1C5CF:
    // XOR AH,AH (1000_C5CF / 0x1C5CF)
    AH = 0;
    // MOV AL,byte ptr [BP + 0x0] (1000_C5D1 / 0x1C5D1)
    AL = UInt8[SS, BP];
    // CMP byte ptr [BP + 0x3],0x0 (1000_C5D4 / 0x1C5D4)
    Alu.Sub8(UInt8[SS, (ushort)(BP + 0x3)], 0x0);
    // JZ 0x1000:c60b (1000_C5D8 / 0x1C5D8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C60B_01C60B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH BP (1000_C5DA / 0x1C5DA)
    Stack.Push(BP);
    // CALL 0x1000:c60b (1000_C5DB / 0x1C5DB)
    NearCall(cs1, 0xC5DE, spice86_generated_label_call_target_1000_C60B_01C60B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C5DE_01C5DE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C5DE_01C5DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C5DE_1C5DE:
    // POP BP (1000_C5DE / 0x1C5DE)
    BP = Stack.Pop();
    // MOV word ptr [DI + 0xf],BP (1000_C5DF / 0x1C5DF)
    UInt16[DS, (ushort)(DI + 0xF)] = BP;
    // PUSH SI (1000_C5E2 / 0x1C5E2)
    Stack.Push(SI);
    // MOV SI,BP (1000_C5E3 / 0x1C5E3)
    SI = BP;
    // MOV BX,0xffff (1000_C5E5 / 0x1C5E5)
    BX = 0xFFFF;
    label_1000_C5E8_1C5E8:
    // INC BX (1000_C5E8 / 0x1C5E8)
    BX = Alu.Inc16(BX);
    // JS 0x1000:c609 (1000_C5E9 / 0x1C5E9)
    if(SignFlag) {
      goto label_1000_C609_1C609;
    }
    // ADD SI,0x3 (1000_C5EB / 0x1C5EB)
    SI += 0x3;
    // CMP byte ptr [SI],0x0 (1000_C5EE / 0x1C5EE)
    Alu.Sub8(UInt8[DS, SI], 0x0);
    // JNZ 0x1000:c5e8 (1000_C5F1 / 0x1C5F1)
    if(!ZeroFlag) {
      goto label_1000_C5E8_1C5E8;
    }
    // OR BX,BX (1000_C5F3 / 0x1C5F3)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:c609 (1000_C5F5 / 0x1C5F5)
    if(ZeroFlag) {
      goto label_1000_C609_1C609;
    }
    // CALL 0x1000:e3df (1000_C5F7 / 0x1C5F7)
    NearCall(cs1, 0xC5FA, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    label_1000_C5FA_1C5FA:
    // MOV BX,AX (1000_C5FA / 0x1C5FA)
    BX = AX;
    // SHL AX,1 (1000_C5FC / 0x1C5FC)
    AX <<= 0x1;
    // ADD AX,BX (1000_C5FE / 0x1C5FE)
    AX += BX;
    // ADD BP,AX (1000_C600 / 0x1C600)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    // MOV word ptr [DI + 0xd],BP (1000_C602 / 0x1C602)
    UInt16[DS, (ushort)(DI + 0xD)] = BP;
    // OR byte ptr [DI + 0xc],0x1 (1000_C605 / 0x1C605)
    // UInt8[DS, (ushort)(DI + 0xC)] |= 0x1;
    UInt8[DS, (ushort)(DI + 0xC)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xC)], 0x1);
    label_1000_C609_1C609:
    // POP SI (1000_C609 / 0x1C609)
    SI = Stack.Pop();
    // RET  (1000_C60A / 0x1C60A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C60B_01C60B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C60B_1C60B:
    // PUSH AX (1000_C60B / 0x1C60B)
    Stack.Push(AX);
    // CALL 0x1000:c13b (1000_C60C / 0x1C60C)
    NearCall(cs1, 0xC60F, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C60F_01C60F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C60F_01C60F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C60F_1C60F:
    // POP AX (1000_C60F / 0x1C60F)
    AX = Stack.Pop();
    // CALL 0x1000:c202 (1000_C610 / 0x1C610)
    NearCall(cs1, 0xC613, spice86_generated_label_call_target_1000_C202_01C202);
    label_1000_C613_1C613:
    // PUSH SI (1000_C613 / 0x1C613)
    Stack.Push(SI);
    // MOV DI,0x3cbe (1000_C614 / 0x1C614)
    DI = 0x3CBE;
    // MOV BP,AX (1000_C617 / 0x1C617)
    BP = AX;
    // MOV AX,word ptr [DI] (1000_C619 / 0x1C619)
    AX = UInt16[DS, DI];
    // INC word ptr [DI] (1000_C61B / 0x1C61B)
    UInt16[DS, DI] = Alu.Inc16(UInt16[DS, DI]);
    // MOV AH,0x11 (1000_C61D / 0x1C61D)
    AH = 0x11;
    // MUL AH (1000_C61F / 0x1C61F)
    Cpu.Mul8(AH);
    // XCHG AX,BP (1000_C621 / 0x1C621)
    ushort tmp_1000_C621 = AX;
    AX = BP;
    BP = tmp_1000_C621;
    // LEA DI,[BP + DI + 0x2] (1000_C622 / 0x1C622)
    DI = (ushort)(BP + DI + 0x2);
    // MOV word ptr [DI],DX (1000_C625 / 0x1C625)
    UInt16[DS, DI] = DX;
    // MOV word ptr [DI + 0x2],BX (1000_C627 / 0x1C627)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    // MOV word ptr [DI + 0x8],AX (1000_C62A / 0x1C62A)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    // MOV word ptr [DI + 0xa],SI (1000_C62D / 0x1C62D)
    UInt16[DS, (ushort)(DI + 0xA)] = SI;
    // MOV byte ptr [DI + 0xc],0x0 (1000_C630 / 0x1C630)
    UInt8[DS, (ushort)(DI + 0xC)] = 0x0;
    // CALL 0x1000:c1f4 (1000_C634 / 0x1C634)
    NearCall(cs1, 0xC637, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_C637_1C637:
    // LODSW ES:SI (1000_C637 / 0x1C637)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // AND AH,0xf (1000_C639 / 0x1C639)
    AH &= 0xF;
    // ADD DX,AX (1000_C63C / 0x1C63C)
    DX += AX;
    // ADD BL,byte ptr ES:[SI] (1000_C63E / 0x1C63E)
    // BL += UInt8[ES, SI];
    BL = Alu.Add8(BL, UInt8[ES, SI]);
    // ADC BH,0x0 (1000_C641 / 0x1C641)
    BH = Alu.Adc8(BH, 0x0);
    // MOV word ptr [DI + 0x4],DX (1000_C644 / 0x1C644)
    UInt16[DS, (ushort)(DI + 0x4)] = DX;
    // MOV word ptr [DI + 0x6],BX (1000_C647 / 0x1C647)
    UInt16[DS, (ushort)(DI + 0x6)] = BX;
    // POP SI (1000_C64A / 0x1C64A)
    SI = Stack.Pop();
    // RET  (1000_C64B / 0x1C64B)
    return NearRet();
  }
  
  public virtual Action split_1000_C653_01C653(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C653_1C653:
    // CALL 0x1000:c13b (1000_C653 / 0x1C653)
    NearCall(cs1, 0xC656, spice86_generated_label_call_target_1000_C13B_01C13B);
    // MOV AX,word ptr [DI + 0x8] (1000_C656 / 0x1C656)
    AX = UInt16[DS, (ushort)(DI + 0x8)];
    // CALL 0x1000:c202 (1000_C659 / 0x1C659)
    NearCall(cs1, 0xC65C, spice86_generated_label_call_target_1000_C202_01C202);
    // SUB DX,word ptr [DI] (1000_C65C / 0x1C65C)
    DX -= UInt16[DS, DI];
    // SUB BX,word ptr [DI + 0x2] (1000_C65E / 0x1C65E)
    // BX -= UInt16[DS, (ushort)(DI + 0x2)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C661_01C661, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C661_01C661(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C661_1C661:
    // CALL 0x1000:c13b (1000_C661 / 0x1C661)
    NearCall(cs1, 0xC664, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C664_01C664, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C664_01C664(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C664_1C664:
    // MOV SI,DI (1000_C664 / 0x1C664)
    SI = DI;
    // SUB SP,0x8 (1000_C666 / 0x1C666)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    // MOV DI,SP (1000_C669 / 0x1C669)
    DI = SP;
    // PUSH DS (1000_C66B / 0x1C66B)
    Stack.Push(DS);
    // POP ES (1000_C66C / 0x1C66C)
    ES = Stack.Pop();
    // MOVSW ES:DI,SI (1000_C66D / 0x1C66D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_C66E / 0x1C66E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_C66F / 0x1C66F)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_C670 / 0x1C670)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // SUB SI,0x8 (1000_C671 / 0x1C671)
    SI -= 0x8;
    // SUB DI,0x8 (1000_C674 / 0x1C674)
    DI -= 0x8;
    // ADD word ptr [SI],DX (1000_C677 / 0x1C677)
    UInt16[DS, SI] += DX;
    // ADD word ptr [SI + 0x2],BX (1000_C679 / 0x1C679)
    UInt16[DS, (ushort)(SI + 0x2)] += BX;
    // ADD word ptr [SI + 0x4],DX (1000_C67C / 0x1C67C)
    UInt16[DS, (ushort)(SI + 0x4)] += DX;
    // ADD word ptr [SI + 0x6],BX (1000_C67F / 0x1C67F)
    // UInt16[DS, (ushort)(SI + 0x6)] += BX;
    UInt16[DS, (ushort)(SI + 0x6)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x6)], BX);
    // OR DX,DX (1000_C682 / 0x1C682)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JS 0x1000:c68e (1000_C684 / 0x1C684)
    if(SignFlag) {
      goto label_1000_C68E_1C68E;
    }
    // MOV AX,word ptr [SI + 0x4] (1000_C686 / 0x1C686)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV word ptr [DI + 0x4],AX (1000_C689 / 0x1C689)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    // JMP 0x1000:c692 (1000_C68C / 0x1C68C)
    goto label_1000_C692_1C692;
    label_1000_C68E_1C68E:
    // MOV AX,word ptr [SI] (1000_C68E / 0x1C68E)
    AX = UInt16[DS, SI];
    // MOV word ptr [DI],AX (1000_C690 / 0x1C690)
    UInt16[DS, DI] = AX;
    label_1000_C692_1C692:
    // OR BX,BX (1000_C692 / 0x1C692)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JS 0x1000:c69e (1000_C694 / 0x1C694)
    if(SignFlag) {
      goto label_1000_C69E_1C69E;
    }
    // MOV AX,word ptr [SI + 0x6] (1000_C696 / 0x1C696)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV word ptr [DI + 0x6],AX (1000_C699 / 0x1C699)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    // JMP 0x1000:c6a4 (1000_C69C / 0x1C69C)
    goto label_1000_C6A4_1C6A4;
    label_1000_C69E_1C69E:
    // MOV AX,word ptr [SI + 0x2] (1000_C69E / 0x1C69E)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV word ptr [DI + 0x2],AX (1000_C6A1 / 0x1C6A1)
    UInt16[DS, (ushort)(DI + 0x2)] = AX;
    label_1000_C6A4_1C6A4:
    // MOV SI,DI (1000_C6A4 / 0x1C6A4)
    SI = DI;
    // CALL 0x1000:c6ad (1000_C6A6 / 0x1C6A6)
    NearCall(cs1, 0xC6A9, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C6A9_01C6A9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
