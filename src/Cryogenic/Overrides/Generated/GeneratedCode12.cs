namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action split_334B_158A_034A3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_158A_34A3A:
    // MOV BP,0x1234 (334B_158A / 0x34A3A)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 334B_0F7E_3442E, 334B_1465_34915, 334B_14A9_34959, 334B_137D_3482D
    BP = 0x1234;
    // PUSH DI (334B_158D / 0x34A3D)
    Stack.Push(DI);
    label_334B_158E_34A3E:
    // LODSW SI (334B_158E / 0x34A3E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BL,AL (334B_158F / 0x34A3F)
    BL = AL;
    // AND AL,DL (334B_1591 / 0x34A41)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    // JZ 0x3000:4a7a (334B_1593 / 0x34A43)
    if(ZeroFlag) {
      goto label_334B_15CA_34A7A;
    }
    // ADD AL,DH (334B_1595 / 0x34A45)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_1597 / 0x34A47)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // SHR BL,0x1 (334B_1598 / 0x34A48)
    BL >>= 0x1;
    
    // SHR BL,0x1 (334B_159A / 0x34A4A)
    BL >>= 0x1;
    
    // SHR BL,0x1 (334B_159C / 0x34A4C)
    BL >>= 0x1;
    
    // SHR BL,0x1 (334B_159E / 0x34A4E)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    // JZ 0x3000:4a89 (334B_15A0 / 0x34A50)
    if(ZeroFlag) {
      goto label_334B_15D9_34A89;
    }
    // MOV AL,BL (334B_15A2 / 0x34A52)
    AL = BL;
    label_334B_15A4_34A54:
    // ADD AL,DH (334B_15A4 / 0x34A54)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_15A6 / 0x34A56)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,AH (334B_15A7 / 0x34A57)
    AL = AH;
    label_334B_15A9_34A59:
    // AND AL,DL (334B_15A9 / 0x34A59)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    // JZ 0x3000:4a9e (334B_15AB / 0x34A5B)
    if(ZeroFlag) {
      goto label_334B_15EE_34A9E;
    }
    // ADD AL,DH (334B_15AD / 0x34A5D)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_15AF / 0x34A5F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // SHR AH,0x1 (334B_15B0 / 0x34A60)
    AH >>= 0x1;
    
    label_334B_15B2_34A62:
    // SHR AH,0x1 (334B_15B2 / 0x34A62)
    AH >>= 0x1;
    
    // SHR AH,0x1 (334B_15B4 / 0x34A64)
    AH >>= 0x1;
    
    // SHR AH,0x1 (334B_15B6 / 0x34A66)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    // JZ 0x3000:4aa5 (334B_15B8 / 0x34A68)
    if(ZeroFlag) {
      goto label_334B_15F5_34AA5;
    }
    // MOV AL,AH (334B_15BA / 0x34A6A)
    AL = AH;
    // ADD AL,DH (334B_15BC / 0x34A6C)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_15BE / 0x34A6E)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // DEC BP (334B_15BF / 0x34A6F)
    BP = Alu.Dec16(BP);
    // JNZ 0x3000:4a3e (334B_15C0 / 0x34A70)
    if(!ZeroFlag) {
      goto label_334B_158E_34A3E;
    }
    // POP DI (334B_15C2 / 0x34A72)
    DI = Stack.Pop();
    // ADD DI,0x140 (334B_15C3 / 0x34A73)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    // LOOP 0x3000:4a3a (334B_15C7 / 0x34A77)
    if(--CX != 0) {
      goto label_334B_158A_34A3A;
    }
    // RETF  (334B_15C9 / 0x34A79)
    return FarRet();
    label_334B_15CA_34A7A:
    // INC DI (334B_15CA / 0x34A7A)
    DI = Alu.Inc16(DI);
    // OR AL,BL (334B_15CB / 0x34A7B)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    // JZ 0x3000:4a89 (334B_15CD / 0x34A7D)
    if(ZeroFlag) {
      goto label_334B_15D9_34A89;
    }
    // SHR AL,0x1 (334B_15CF / 0x34A7F)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_15D1 / 0x34A81)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_15D3 / 0x34A83)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_15D5 / 0x34A85)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JMP 0x3000:4a54 (334B_15D7 / 0x34A87)
    goto label_334B_15A4_34A54;
    label_334B_15D9_34A89:
    // INC DI (334B_15D9 / 0x34A89)
    DI = Alu.Inc16(DI);
    // MOV AL,AH (334B_15DA / 0x34A8A)
    AL = AH;
    // OR AL,AL (334B_15DC / 0x34A8C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x3000:4a59 (334B_15DE / 0x34A8E)
    if(!ZeroFlag) {
      goto label_334B_15A9_34A59;
    }
    label_334B_15E0_34A90:
    // ADD DI,0x2 (334B_15E0 / 0x34A90)
    DI += 0x2;
    
    // DEC BP (334B_15E3 / 0x34A93)
    BP = Alu.Dec16(BP);
    // JNZ 0x3000:4a3e (334B_15E4 / 0x34A94)
    if(!ZeroFlag) {
      goto label_334B_158E_34A3E;
    }
    label_334B_15E6_34A96:
    // POP DI (334B_15E6 / 0x34A96)
    DI = Stack.Pop();
    // ADD DI,0x140 (334B_15E7 / 0x34A97)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    // LOOP 0x3000:4a3a (334B_15EB / 0x34A9B)
    if(--CX != 0) {
      goto label_334B_158A_34A3A;
    }
    // RETF  (334B_15ED / 0x34A9D)
    return FarRet();
    label_334B_15EE_34A9E:
    // SHR AH,0x1 (334B_15EE / 0x34A9E)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    // JZ 0x3000:4a90 (334B_15F0 / 0x34AA0)
    if(ZeroFlag) {
      goto label_334B_15E0_34A90;
    }
    // INC DI (334B_15F2 / 0x34AA2)
    DI = Alu.Inc16(DI);
    // JMP 0x3000:4a62 (334B_15F3 / 0x34AA3)
    goto label_334B_15B2_34A62;
    label_334B_15F5_34AA5:
    // INC DI (334B_15F5 / 0x34AA5)
    DI = Alu.Inc16(DI);
    // DEC BP (334B_15F6 / 0x34AA6)
    BP = Alu.Dec16(BP);
    // JNZ 0x3000:4a3e (334B_15F7 / 0x34AA7)
    if(!ZeroFlag) {
      goto label_334B_158E_34A3E;
    }
    // JMP 0x3000:4a96 (334B_15F9 / 0x34AA9)
    goto label_334B_15E6_34A96;
  }
  
  public Action split_334B_16A7_034B57(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_16A7_34B57:
    // ADD SI,0x12 (334B_16A7 / 0x34B57)
    // SI += 0x12;
    SI = Alu.Add16(SI, 0x12);
    label_334B_16AA_34B5A:
    // MOV BP,0x1234 (334B_16AA / 0x34B5A)
    BP = 0x1234;
    // PUSH DI (334B_16AD / 0x34B5D)
    Stack.Push(DI);
    // ADD BP,DI (334B_16AE / 0x34B5E)
    // BP += DI;
    BP = Alu.Add16(BP, DI);
    label_334B_16B0_34B60:
    // LODSW SI (334B_16B0 / 0x34B60)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BL,AL (334B_16B1 / 0x34B61)
    BL = AL;
    // AND AL,DL (334B_16B3 / 0x34B63)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    // JZ 0x3000:4ba9 (334B_16B5 / 0x34B65)
    if(ZeroFlag) {
      goto label_334B_16F9_34BA9;
    }
    // ADD AL,DH (334B_16B7 / 0x34B67)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_16B9 / 0x34B69)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP DI,BP (334B_16BA / 0x34B6A)
    Alu.Sub16(DI, BP);
    // JNC 0x3000:4ba1 (334B_16BC / 0x34B6C)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    // SHR BL,0x1 (334B_16BE / 0x34B6E)
    BL >>= 0x1;
    
    // SHR BL,0x1 (334B_16C0 / 0x34B70)
    BL >>= 0x1;
    
    // SHR BL,0x1 (334B_16C2 / 0x34B72)
    BL >>= 0x1;
    
    // SHR BL,0x1 (334B_16C4 / 0x34B74)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    // JZ 0x3000:4bbc (334B_16C6 / 0x34B76)
    if(ZeroFlag) {
      goto label_334B_170C_34BBC;
    }
    // MOV AL,BL (334B_16C8 / 0x34B78)
    AL = BL;
    label_334B_16CA_34B7A:
    // ADD AL,DH (334B_16CA / 0x34B7A)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_16CC / 0x34B7C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP DI,BP (334B_16CD / 0x34B7D)
    Alu.Sub16(DI, BP);
    // JNC 0x3000:4ba1 (334B_16CF / 0x34B7F)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    // MOV AL,AH (334B_16D1 / 0x34B81)
    AL = AH;
    label_334B_16D3_34B83:
    // AND AL,DL (334B_16D3 / 0x34B83)
    // AL &= DL;
    AL = Alu.And8(AL, DL);
    // JZ 0x3000:4bcc (334B_16D5 / 0x34B85)
    if(ZeroFlag) {
      goto label_334B_171C_34BCC;
    }
    // ADD AL,DH (334B_16D7 / 0x34B87)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_16D9 / 0x34B89)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP DI,BP (334B_16DA / 0x34B8A)
    Alu.Sub16(DI, BP);
    // JNC 0x3000:4ba1 (334B_16DC / 0x34B8C)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    // SHR AH,0x1 (334B_16DE / 0x34B8E)
    AH >>= 0x1;
    
    label_334B_16E0_34B90:
    // SHR AH,0x1 (334B_16E0 / 0x34B90)
    AH >>= 0x1;
    
    // SHR AH,0x1 (334B_16E2 / 0x34B92)
    AH >>= 0x1;
    
    // SHR AH,0x1 (334B_16E4 / 0x34B94)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    // JZ 0x3000:4bd5 (334B_16E6 / 0x34B96)
    if(ZeroFlag) {
      goto label_334B_1725_34BD5;
    }
    // MOV AL,AH (334B_16E8 / 0x34B98)
    AL = AH;
    // ADD AL,DH (334B_16EA / 0x34B9A)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    // STOSB ES:DI (334B_16EC / 0x34B9C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_334B_16ED_34B9D:
    // CMP DI,BP (334B_16ED / 0x34B9D)
    Alu.Sub16(DI, BP);
    // JC 0x3000:4b60 (334B_16EF / 0x34B9F)
    if(CarryFlag) {
      goto label_334B_16B0_34B60;
    }
    label_334B_16F1_34BA1:
    // POP DI (334B_16F1 / 0x34BA1)
    DI = Stack.Pop();
    // ADD DI,0x140 (334B_16F2 / 0x34BA2)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    // LOOP 0x3000:4b57 (334B_16F6 / 0x34BA6)
    if(--CX != 0) {
      goto label_334B_16A7_34B57;
    }
    // RETF  (334B_16F8 / 0x34BA8)
    return FarRet();
    label_334B_16F9_34BA9:
    // INC DI (334B_16F9 / 0x34BA9)
    DI = Alu.Inc16(DI);
    // CMP DI,BP (334B_16FA / 0x34BAA)
    Alu.Sub16(DI, BP);
    // JNC 0x3000:4ba1 (334B_16FC / 0x34BAC)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    // OR AL,BL (334B_16FE / 0x34BAE)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    // JZ 0x3000:4bbc (334B_1700 / 0x34BB0)
    if(ZeroFlag) {
      goto label_334B_170C_34BBC;
    }
    // SHR AL,0x1 (334B_1702 / 0x34BB2)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_1704 / 0x34BB4)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_1706 / 0x34BB6)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_1708 / 0x34BB8)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JMP 0x3000:4b7a (334B_170A / 0x34BBA)
    goto label_334B_16CA_34B7A;
    label_334B_170C_34BBC:
    // INC DI (334B_170C / 0x34BBC)
    DI = Alu.Inc16(DI);
    // CMP DI,BP (334B_170D / 0x34BBD)
    Alu.Sub16(DI, BP);
    // JNC 0x3000:4ba1 (334B_170F / 0x34BBF)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    // MOV AL,AH (334B_1711 / 0x34BC1)
    AL = AH;
    // OR AL,AL (334B_1713 / 0x34BC3)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x3000:4b83 (334B_1715 / 0x34BC5)
    if(!ZeroFlag) {
      goto label_334B_16D3_34B83;
    }
    // ADD DI,0x2 (334B_1717 / 0x34BC7)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // JMP 0x3000:4b9d (334B_171A / 0x34BCA)
    goto label_334B_16ED_34B9D;
    label_334B_171C_34BCC:
    // INC DI (334B_171C / 0x34BCC)
    DI = Alu.Inc16(DI);
    // CMP DI,BP (334B_171D / 0x34BCD)
    Alu.Sub16(DI, BP);
    // JNC 0x3000:4ba1 (334B_171F / 0x34BCF)
    if(!CarryFlag) {
      goto label_334B_16F1_34BA1;
    }
    // SHR AH,0x1 (334B_1721 / 0x34BD1)
    // AH >>= 0x1;
    AH = Alu.Shr8(AH, 0x1);
    // JNZ 0x3000:4b90 (334B_1723 / 0x34BD3)
    if(!ZeroFlag) {
      goto label_334B_16E0_34B90;
    }
    label_334B_1725_34BD5:
    // INC DI (334B_1725 / 0x34BD5)
    DI = Alu.Inc16(DI);
    // JMP 0x3000:4b9d (334B_1726 / 0x34BD6)
    goto label_334B_16ED_34B9D;
  }
  
  public Action split_334B_17E8_034C98(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_17E8_34C98:
    // XOR CH,CH (334B_17E8 / 0x34C98)
    CH = 0;
    // MOV AX,word ptr [BP + 0x2] (334B_17EA / 0x34C9A)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    // SUB AX,BX (334B_17ED / 0x34C9D)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JLE 0x3000:4cac (334B_17EF / 0x34C9F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_17FC_34CAC;
    }
    // SUB CX,AX (334B_17F1 / 0x34CA1)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    // JBE 0x3000:4cd5 (334B_17F3 / 0x34CA3)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    // ADD BX,AX (334B_17F5 / 0x34CA5)
    BX += AX;
    
    label_334B_17F7_34CA7:
    // ADD SI,DI (334B_17F7 / 0x34CA7)
    SI += DI;
    
    // DEC AX (334B_17F9 / 0x34CA9)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:4ca7 (334B_17FA / 0x34CAA)
    if(!ZeroFlag) {
      goto label_334B_17F7_34CA7;
    }
    label_334B_17FC_34CAC:
    // MOV AX,BX (334B_17FC / 0x34CAC)
    AX = BX;
    // ADD AX,CX (334B_17FE / 0x34CAE)
    AX += CX;
    
    // SUB AX,word ptr [BP + 0x6] (334B_1800 / 0x34CB0)
    // AX -= UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    // JBE 0x3000:4cb9 (334B_1803 / 0x34CB3)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_1809_34CB9;
    }
    // SUB CX,AX (334B_1805 / 0x34CB5)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    // JBE 0x3000:4cd5 (334B_1807 / 0x34CB7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RETF, inlining.
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    label_334B_1809_34CB9:
    // MOV AX,DX (334B_1809 / 0x34CB9)
    AX = DX;
    // ADD AX,DI (334B_180B / 0x34CBB)
    AX += DI;
    
    // SUB AX,word ptr [BP + 0x4] (334B_180D / 0x34CBD)
    // AX -= UInt16[SS, (ushort)(BP + 0x4)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x4)]);
    // JG 0x3000:4d04 (334B_1810 / 0x34CC0)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_334B_1825_034CD5, 0x34D04 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,word ptr [BP + 0x0] (334B_1812 / 0x34CC2)
    AX = UInt16[SS, BP];
    // SUB AX,DX (334B_1815 / 0x34CC5)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    // JG 0x3000:4cd6 (334B_1817 / 0x34CC7)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_334B_1825_034CD5, 0x34CD6 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BP,DI (334B_1819 / 0x34CC9)
    BP = DI;
    // PUSH DI (334B_181B / 0x34CCB)
    Stack.Push(DI);
    // CALL 0x3000:40c0 (334B_181C / 0x34CCC)
    NearCall(cs2, 0x181F, spice86_generated_label_call_target_334B_0C10_0340C0);
    // POP DX (334B_181F / 0x34CCF)
    DX = Stack.Pop();
    // MOV BX,CX (334B_1820 / 0x34CD0)
    BX = CX;
    // JMP 0x3000:4ce7 (334B_1822 / 0x34CD2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_334B_1825_034CD5, 0x34CE7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_334B_1825_034CD5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1825_34CD5:
    // RETF  (334B_1825 / 0x34CD5)
    return FarRet();
    label_334B_1826_34CD6:
    // MOV BP,DI (334B_1826 / 0x34CD6)
    BP = DI;
    // SUB DI,AX (334B_1828 / 0x34CD8)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    // JLE 0x3000:4cd5 (334B_182A / 0x34CDA)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    // ADD DX,AX (334B_182C / 0x34CDC)
    DX += AX;
    
    // ADD SI,AX (334B_182E / 0x34CDE)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // PUSH DI (334B_1830 / 0x34CE0)
    Stack.Push(DI);
    // CALL 0x3000:40c0 (334B_1831 / 0x34CE1)
    NearCall(cs2, 0x1834, spice86_generated_label_call_target_334B_0C10_0340C0);
    // POP DX (334B_1834 / 0x34CE4)
    DX = Stack.Pop();
    // MOV BX,CX (334B_1835 / 0x34CE5)
    BX = CX;
    label_334B_1837_34CE7:
    // SUB BP,DX (334B_1837 / 0x34CE7)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    label_334B_1839_34CE9:
    // MOV CX,DX (334B_1839 / 0x34CE9)
    CX = DX;
    label_334B_183B_34CEB:
    // LODSB SI (334B_183B / 0x34CEB)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (334B_183C / 0x34CEC)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x3000:4cff (334B_183E / 0x34CEE)
    if(ZeroFlag) {
      goto label_334B_184F_34CFF;
    }
    // STOSB ES:DI (334B_1840 / 0x34CF0)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x3000:4ceb (334B_1841 / 0x34CF1)
    if(--CX != 0) {
      goto label_334B_183B_34CEB;
    }
    label_334B_1843_34CF3:
    // SUB DI,DX (334B_1843 / 0x34CF3)
    DI -= DX;
    
    // ADD SI,BP (334B_1845 / 0x34CF5)
    SI += BP;
    
    // ADD DI,0x140 (334B_1847 / 0x34CF7)
    DI += 0x140;
    
    // DEC BX (334B_184B / 0x34CFB)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:4ce9 (334B_184C / 0x34CFC)
    if(!ZeroFlag) {
      goto label_334B_1839_34CE9;
    }
    // RETF  (334B_184E / 0x34CFE)
    return FarRet();
    label_334B_184F_34CFF:
    // INC DI (334B_184F / 0x34CFF)
    DI = Alu.Inc16(DI);
    // LOOP 0x3000:4ceb (334B_1850 / 0x34D00)
    if(--CX != 0) {
      goto label_334B_183B_34CEB;
    }
    // JMP 0x3000:4cf3 (334B_1852 / 0x34D02)
    goto label_334B_1843_34CF3;
    label_334B_1854_34D04:
    // MOV word ptr CS:[0x158b],DI (334B_1854 / 0x34D04)
    UInt16[cs2, 0x158B] = DI;
    // SUB DI,AX (334B_1859 / 0x34D09)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    // JLE 0x3000:4cd5 (334B_185B / 0x34D0B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    // MOV AX,word ptr [BP + 0x0] (334B_185D / 0x34D0D)
    AX = UInt16[SS, BP];
    // SUB AX,DX (334B_1860 / 0x34D10)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    // JG 0x3000:4d22 (334B_1862 / 0x34D12)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_334B_1872_34D22;
    }
    // PUSH DI (334B_1864 / 0x34D14)
    Stack.Push(DI);
    // CALL 0x3000:40c0 (334B_1865 / 0x34D15)
    NearCall(cs2, 0x1868, spice86_generated_label_call_target_334B_0C10_0340C0);
    // POP DX (334B_1868 / 0x34D18)
    DX = Stack.Pop();
    // MOV BP,word ptr CS:[0x158b] (334B_1869 / 0x34D19)
    BP = UInt16[cs2, 0x158B];
    // MOV BX,CX (334B_186E / 0x34D1E)
    BX = CX;
    // JMP 0x3000:4ce7 (334B_1870 / 0x34D20)
    goto label_334B_1837_34CE7;
    label_334B_1872_34D22:
    // SUB DI,AX (334B_1872 / 0x34D22)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    // JLE 0x3000:4cd5 (334B_1874 / 0x34D24)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RETF, inlining.
      // RETF  (334B_1825 / 0x34CD5)
      return FarRet();
    }
    // ADD SI,AX (334B_1876 / 0x34D26)
    SI += AX;
    
    // ADD DX,AX (334B_1878 / 0x34D28)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // PUSH DI (334B_187A / 0x34D2A)
    Stack.Push(DI);
    // CALL 0x3000:40c0 (334B_187B / 0x34D2B)
    NearCall(cs2, 0x187E, spice86_generated_label_call_target_334B_0C10_0340C0);
    // POP DX (334B_187E / 0x34D2E)
    DX = Stack.Pop();
    // MOV BP,word ptr CS:[0x158b] (334B_187F / 0x34D2F)
    BP = UInt16[cs2, 0x158B];
    // MOV BX,CX (334B_1884 / 0x34D34)
    BX = CX;
    // JMP 0x3000:4ce7 (334B_1886 / 0x34D36)
    goto label_334B_1837_34CE7;
  }
  
  public Action spice86_generated_label_jump_target_334B_1888_034D38(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1888_34D38:
    // LODSW SI (334B_1888 / 0x34D38)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB DX,AX (334B_1889 / 0x34D39)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // JNC 0x3000:4d3f (334B_188B / 0x34D3B)
    if(!CarryFlag) {
      goto label_334B_188F_34D3F;
    }
    // XOR DX,DX (334B_188D / 0x34D3D)
    DX = 0;
    label_334B_188F_34D3F:
    // LODSW SI (334B_188F / 0x34D3F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB BX,AX (334B_1890 / 0x34D40)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // JNC 0x3000:4d46 (334B_1892 / 0x34D42)
    if(!CarryFlag) {
      goto label_334B_1896_34D46;
    }
    // XOR BX,BX (334B_1894 / 0x34D44)
    BX = 0;
    label_334B_1896_34D46:
    // MOV CX,0x10 (334B_1896 / 0x34D46)
    CX = 0x10;
    // CMP BX,0xb8 (334B_1899 / 0x34D49)
    Alu.Sub16(BX, 0xB8);
    // JBE 0x3000:4d54 (334B_189D / 0x34D4D)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_18A4_34D54;
    }
    // MOV CX,0xc8 (334B_189F / 0x34D4F)
    CX = 0xC8;
    // SUB CX,BX (334B_18A2 / 0x34D52)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    label_334B_18A4_34D54:
    // CALL 0x3000:40c0 (334B_18A4 / 0x34D54)
    NearCall(cs2, 0x18A7, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_18A7_34D57:
    // MOV AX,0xa000 (334B_18A7 / 0x34D57)
    AX = 0xA000;
    // MOV ES,AX (334B_18AA / 0x34D5A)
    ES = AX;
    // SUB DX,0x140 (334B_18AC / 0x34D5C)
    DX -= 0x140;
    
    // NEG DX (334B_18B0 / 0x34D60)
    DX = Alu.Sub16(0, DX);
    // CMP DX,0x10 (334B_18B2 / 0x34D62)
    Alu.Sub16(DX, 0x10);
    // JBE 0x3000:4d6a (334B_18B5 / 0x34D65)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_18BA_34D6A;
    }
    // MOV DX,0x10 (334B_18B7 / 0x34D67)
    DX = 0x10;
    label_334B_18BA_34D6A:
    // MOV word ptr CS:[0x18c],DX (334B_18BA / 0x34D6A)
    UInt16[cs2, 0x18C] = DX;
    // MOV word ptr CS:[0x18e],CX (334B_18BF / 0x34D6F)
    UInt16[cs2, 0x18E] = CX;
    // MOV word ptr CS:[0x18a],DI (334B_18C4 / 0x34D74)
    UInt16[cs2, 0x18A] = DI;
    // MOV BX,0xfa00 (334B_18C9 / 0x34D79)
    BX = 0xFA00;
    // SHR DX,0x1 (334B_18CC / 0x34D7C)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    // MOV word ptr CS:[0x190],DX (334B_18CE / 0x34D7E)
    UInt16[cs2, 0x190] = DX;
    // MOV word ptr CS:[0x192],CX (334B_18D3 / 0x34D83)
    UInt16[cs2, 0x192] = CX;
    label_334B_18D8_34D88:
    // MOV CX,word ptr CS:[0x190] (334B_18D8 / 0x34D88)
    CX = UInt16[cs2, 0x190];
    // MOV BP,word ptr [SI + 0x20] (334B_18DD / 0x34D8D)
    BP = UInt16[DS, (ushort)(SI + 0x20)];
    // LODSW SI (334B_18E0 / 0x34D90)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (334B_18E1 / 0x34D91)
    DX = AX;
    // JCXZ 0x3000:4dc1 (334B_18E3 / 0x34D93)
    if(CX == 0) {
      goto label_334B_1911_34DC1;
    }
    label_334B_18E5_34D95:
    // MOV AX,word ptr ES:[DI] (334B_18E5 / 0x34D95)
    AX = UInt16[ES, DI];
    // MOV word ptr ES:[BX],AX (334B_18E8 / 0x34D98)
    UInt16[ES, BX] = AX;
    // ADD BX,0x2 (334B_18EB / 0x34D9B)
    BX += 0x2;
    
    // ROL BP,0x1 (334B_18EE / 0x34D9E)
    BP = Alu.Rol16(BP, 0x1);
    // ADD DX,DX (334B_18F0 / 0x34DA0)
    // DX += DX;
    DX = Alu.Add16(DX, DX);
    // JC 0x3000:4dae (334B_18F2 / 0x34DA2)
    if(CarryFlag) {
      goto label_334B_18FE_34DAE;
    }
    // XOR AL,AL (334B_18F4 / 0x34DA4)
    AL = 0;
    // TEST BP,0x1 (334B_18F6 / 0x34DA6)
    Alu.And16(BP, 0x1);
    // JZ 0x3000:4dae (334B_18FA / 0x34DAA)
    if(ZeroFlag) {
      goto label_334B_18FE_34DAE;
    }
    // MOV AL,0xf (334B_18FC / 0x34DAC)
    AL = 0xF;
    label_334B_18FE_34DAE:
    // ROL BP,0x1 (334B_18FE / 0x34DAE)
    BP = Alu.Rol16(BP, 0x1);
    // ADD DX,DX (334B_1900 / 0x34DB0)
    // DX += DX;
    DX = Alu.Add16(DX, DX);
    // JC 0x3000:4dbe (334B_1902 / 0x34DB2)
    if(CarryFlag) {
      goto label_334B_190E_34DBE;
    }
    // XOR AH,AH (334B_1904 / 0x34DB4)
    AH = 0;
    // TEST BP,0x1 (334B_1906 / 0x34DB6)
    Alu.And16(BP, 0x1);
    // JZ 0x3000:4dbe (334B_190A / 0x34DBA)
    if(ZeroFlag) {
      goto label_334B_190E_34DBE;
    }
    // MOV AH,0xf (334B_190C / 0x34DBC)
    AH = 0xF;
    label_334B_190E_34DBE:
    // STOSW ES:DI (334B_190E / 0x34DBE)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x3000:4d95 (334B_190F / 0x34DBF)
    if(--CX != 0) {
      goto label_334B_18E5_34D95;
    }
    label_334B_1911_34DC1:
    // TEST byte ptr CS:[0x18c],0x1 (334B_1911 / 0x34DC1)
    Alu.And8(UInt8[cs2, 0x18C], 0x1);
    // JZ 0x3000:4ddf (334B_1917 / 0x34DC7)
    if(ZeroFlag) {
      goto label_334B_192F_34DDF;
    }
    // MOV AL,byte ptr ES:[DI] (334B_1919 / 0x34DC9)
    AL = UInt8[ES, DI];
    // MOV byte ptr ES:[BX],AL (334B_191C / 0x34DCC)
    UInt8[ES, BX] = AL;
    // INC BX (334B_191F / 0x34DCF)
    BX = Alu.Inc16(BX);
    // INC DI (334B_1920 / 0x34DD0)
    DI = Alu.Inc16(DI);
    // ADD DX,DX (334B_1921 / 0x34DD1)
    // DX += DX;
    DX = Alu.Add16(DX, DX);
    // JC 0x3000:4ddf (334B_1923 / 0x34DD3)
    if(CarryFlag) {
      goto label_334B_192F_34DDF;
    }
    // XOR AL,AL (334B_1925 / 0x34DD5)
    AL = 0;
    // ADD BP,BP (334B_1927 / 0x34DD7)
    // BP += BP;
    BP = Alu.Add16(BP, BP);
    // JNC 0x3000:4ddd (334B_1929 / 0x34DD9)
    if(!CarryFlag) {
      goto label_334B_192D_34DDD;
    }
    // MOV AL,0xf (334B_192B / 0x34DDB)
    AL = 0xF;
    label_334B_192D_34DDD:
    // DEC DI (334B_192D / 0x34DDD)
    DI = Alu.Dec16(DI);
    // STOSB ES:DI (334B_192E / 0x34DDE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_334B_192F_34DDF:
    // SUB DI,word ptr CS:[0x18c] (334B_192F / 0x34DDF)
    DI -= UInt16[cs2, 0x18C];
    
    // ADD DI,0x140 (334B_1934 / 0x34DE4)
    DI += 0x140;
    
    // DEC word ptr CS:[0x192] (334B_1938 / 0x34DE8)
    UInt16[cs2, 0x192] = Alu.Dec16(UInt16[cs2, 0x192]);
    // JNZ 0x3000:4d88 (334B_193D / 0x34DED)
    if(!ZeroFlag) {
      goto label_334B_18D8_34D88;
    }
    // RETF  (334B_193F / 0x34DEF)
    return FarRet();
  }
  
  public Action not_observed_334B_1940_034DF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1940_34DF0:
    // PUSH AX (334B_1940 / 0x34DF0)
    Stack.Push(AX);
    // PUSH BX (334B_1941 / 0x34DF1)
    Stack.Push(BX);
    // PUSH CX (334B_1942 / 0x34DF2)
    Stack.Push(CX);
    // PUSH DX (334B_1943 / 0x34DF3)
    Stack.Push(DX);
    // PUSH SI (334B_1944 / 0x34DF4)
    Stack.Push(SI);
    // PUSH DI (334B_1945 / 0x34DF5)
    Stack.Push(DI);
    // PUSH BP (334B_1946 / 0x34DF6)
    Stack.Push(BP);
    // PUSH DS (334B_1947 / 0x34DF7)
    Stack.Push(DS);
    // PUSH ES (334B_1948 / 0x34DF8)
    Stack.Push(ES);
    // MOV BP,word ptr CS:[0x18a] (334B_1949 / 0x34DF9)
    BP = UInt16[cs2, 0x18A];
    // MOV BX,word ptr CS:[0x18c] (334B_194E / 0x34DFE)
    BX = UInt16[cs2, 0x18C];
    // MOV DX,word ptr CS:[0x18e] (334B_1953 / 0x34E03)
    DX = UInt16[cs2, 0x18E];
    // MOV AX,0xa000 (334B_1958 / 0x34E08)
    AX = 0xA000;
    // MOV ES,AX (334B_195B / 0x34E0B)
    ES = AX;
    // MOV DS,AX (334B_195D / 0x34E0D)
    DS = AX;
    // MOV SI,0xfa00 (334B_195F / 0x34E0F)
    SI = 0xFA00;
    label_334B_1962_34E12:
    // MOV DI,BP (334B_1962 / 0x34E12)
    DI = BP;
    // MOV CX,BX (334B_1964 / 0x34E14)
    CX = BX;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_1966 / 0x34E16)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // ADD BP,0x140 (334B_1968 / 0x34E18)
    BP += 0x140;
    
    // DEC DX (334B_196C / 0x34E1C)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:4e12 (334B_196D / 0x34E1D)
    if(!ZeroFlag) {
      goto label_334B_1962_34E12;
    }
    // POP ES (334B_196F / 0x34E1F)
    ES = Stack.Pop();
    // POP DS (334B_1970 / 0x34E20)
    DS = Stack.Pop();
    // POP BP (334B_1971 / 0x34E21)
    BP = Stack.Pop();
    // POP DI (334B_1972 / 0x34E22)
    DI = Stack.Pop();
    // POP SI (334B_1973 / 0x34E23)
    SI = Stack.Pop();
    // POP DX (334B_1974 / 0x34E24)
    DX = Stack.Pop();
    // POP CX (334B_1975 / 0x34E25)
    CX = Stack.Pop();
    // POP BX (334B_1976 / 0x34E26)
    BX = Stack.Pop();
    // POP AX (334B_1977 / 0x34E27)
    AX = Stack.Pop();
    // RETF  (334B_1978 / 0x34E28)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1979_034E29(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1979_34E29:
    // XOR AX,AX (334B_1979 / 0x34E29)
    AX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_197B_034E2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_jump_target_334B_197B_034E2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_197B_34E2B:
    // MOV AH,AL (334B_197B / 0x34E2B)
    AH = AL;
    // PUSH AX (334B_197D / 0x34E2D)
    Stack.Push(AX);
    // LODSW SI (334B_197E / 0x34E2E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (334B_197F / 0x34E2F)
    DX = AX;
    // LODSW SI (334B_1981 / 0x34E31)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (334B_1982 / 0x34E32)
    BX = AX;
    // CALL 0x3000:40c0 (334B_1984 / 0x34E34)
    NearCall(cs2, 0x1987, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1987_34E37:
    // LODSW SI (334B_1987 / 0x34E37)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BP,AX (334B_1988 / 0x34E38)
    BP = AX;
    // SUB BP,DX (334B_198A / 0x34E3A)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x3000:4e77 (334B_198C / 0x34E3C)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_19C7_34E77;
    }
    // LODSW SI (334B_198E / 0x34E3E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB BX,AX (334B_198F / 0x34E3F)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // JNC 0x3000:4e77 (334B_1991 / 0x34E41)
    if(!CarryFlag) {
      goto label_334B_19C7_34E77;
    }
    // NEG BX (334B_1993 / 0x34E43)
    BX = Alu.Sub16(0, BX);
    // POP AX (334B_1995 / 0x34E45)
    AX = Stack.Pop();
    // MOV SI,DI (334B_1996 / 0x34E46)
    SI = DI;
    // SHR BP,0x1 (334B_1998 / 0x34E48)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // JC 0x3000:4e5c (334B_199A / 0x34E4A)
    if(CarryFlag) {
      goto label_334B_19AC_34E5C;
    }
    // JZ 0x3000:4e76 (334B_199C / 0x34E4C)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      // RETF  (334B_19C6 / 0x34E76)
      return FarRet();
    }
    label_334B_199E_34E4E:
    // MOV DI,SI (334B_199E / 0x34E4E)
    DI = SI;
    // MOV CX,BP (334B_19A0 / 0x34E50)
    CX = BP;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_19A2 / 0x34E52)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // ADD SI,0x140 (334B_19A4 / 0x34E54)
    SI += 0x140;
    
    // DEC BX (334B_19A8 / 0x34E58)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:4e4e (334B_19A9 / 0x34E59)
    if(!ZeroFlag) {
      goto label_334B_199E_34E4E;
    }
    // RETF  (334B_19AB / 0x34E5B)
    return FarRet();
    label_334B_19AC_34E5C:
    // JZ 0x3000:4e6d (334B_19AC / 0x34E5C)
    if(ZeroFlag) {
      goto label_334B_19BD_34E6D;
    }
    label_334B_19AE_34E5E:
    // MOV DI,SI (334B_19AE / 0x34E5E)
    DI = SI;
    // MOV CX,BP (334B_19B0 / 0x34E60)
    CX = BP;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_19B2 / 0x34E62)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // STOSB ES:DI (334B_19B4 / 0x34E64)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD SI,0x140 (334B_19B5 / 0x34E65)
    SI += 0x140;
    
    // DEC BX (334B_19B9 / 0x34E69)
    BX = Alu.Dec16(BX);
    // JNZ 0x3000:4e5e (334B_19BA / 0x34E6A)
    if(!ZeroFlag) {
      goto label_334B_19AE_34E5E;
    }
    // RETF  (334B_19BC / 0x34E6C)
    return FarRet();
    label_334B_19BD_34E6D:
    // MOV CX,BX (334B_19BD / 0x34E6D)
    CX = BX;
    label_334B_19BF_34E6F:
    // STOSB ES:DI (334B_19BF / 0x34E6F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD DI,0x13f (334B_19C0 / 0x34E70)
    // DI += 0x13F;
    DI = Alu.Add16(DI, 0x13F);
    // LOOP 0x3000:4e6f (334B_19C4 / 0x34E74)
    if(--CX != 0) {
      goto label_334B_19BF_34E6F;
    }
    label_334B_19C6_34E76:
    // RETF  (334B_19C6 / 0x34E76)
    return FarRet();
    label_334B_19C7_34E77:
    // POP AX (334B_19C7 / 0x34E77)
    AX = Stack.Pop();
    // RETF  (334B_19C8 / 0x34E78)
    return FarRet();
  }
  
  public Action not_observed_334B_19F7_034EA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_19F7_34EA7:
    // PUSH AX (334B_19F7 / 0x34EA7)
    Stack.Push(AX);
    // PUSH CX (334B_19F8 / 0x34EA8)
    Stack.Push(CX);
    // PUSH DI (334B_19F9 / 0x34EA9)
    Stack.Push(DI);
    // XOR DI,DI (334B_19FA / 0x34EAA)
    DI = 0;
    // XOR AX,AX (334B_19FC / 0x34EAC)
    AX = 0;
    // MOV CX,0x7d00 (334B_19FE / 0x34EAE)
    CX = 0x7D00;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_1A01 / 0x34EB1)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // POP DI (334B_1A03 / 0x34EB3)
    DI = Stack.Pop();
    // POP CX (334B_1A04 / 0x34EB4)
    CX = Stack.Pop();
    // POP AX (334B_1A05 / 0x34EB5)
    AX = Stack.Pop();
    // RETF  (334B_1A06 / 0x34EB6)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1A07_034EB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1A07_34EB7:
    // MOV word ptr CS:[0x19a],BP (334B_1A07 / 0x34EB7)
    UInt16[cs2, 0x19A] = BP;
    // MOV word ptr CS:[0x198],SI (334B_1A0C / 0x34EBC)
    UInt16[cs2, 0x198] = SI;
    // MOV CS:[0x19c],AL (334B_1A11 / 0x34EC1)
    UInt8[cs2, 0x19C] = AL;
    // PUSH AX (334B_1A15 / 0x34EC5)
    Stack.Push(AX);
    // PUSH BX (334B_1A16 / 0x34EC6)
    Stack.Push(BX);
    // PUSH CX (334B_1A17 / 0x34EC7)
    Stack.Push(CX);
    // PUSH DX (334B_1A18 / 0x34EC8)
    Stack.Push(DX);
    // PUSH DI (334B_1A19 / 0x34EC9)
    Stack.Push(DI);
    // MOV word ptr CS:[0x194],DX (334B_1A1A / 0x34ECA)
    UInt16[cs2, 0x194] = DX;
    // MOV word ptr CS:[0x196],BX (334B_1A1F / 0x34ECF)
    UInt16[cs2, 0x196] = BX;
    // SUB BX,CX (334B_1A24 / 0x34ED4)
    BX -= CX;
    
    // SUB DX,DI (334B_1A26 / 0x34ED6)
    DX -= DI;
    
    // NEG BX (334B_1A28 / 0x34ED8)
    BX = Alu.Sub16(0, BX);
    // NEG DX (334B_1A2A / 0x34EDA)
    DX = Alu.Sub16(0, DX);
    // CALL 0x3000:4f8c (334B_1A2C / 0x34EDC)
    NearCall(cs2, 0x1A2F, spice86_generated_label_call_target_334B_1ADC_034F8C);
    label_334B_1A2F_34EDF:
    // MOV BP,word ptr CS:[0x19a] (334B_1A2F / 0x34EDF)
    BP = UInt16[cs2, 0x19A];
    // POP DI (334B_1A34 / 0x34EE4)
    DI = Stack.Pop();
    // POP DX (334B_1A35 / 0x34EE5)
    DX = Stack.Pop();
    // POP CX (334B_1A36 / 0x34EE6)
    CX = Stack.Pop();
    // POP BX (334B_1A37 / 0x34EE7)
    BX = Stack.Pop();
    // POP AX (334B_1A38 / 0x34EE8)
    AX = Stack.Pop();
    // RETF  (334B_1A39 / 0x34EE9)
    return FarRet();
  }
  
  public Action spice86_generated_label_call_target_334B_1ADC_034F8C(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x24EEA: break; // Instructions before entry targeted by 0x34F92
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_334B_1A3A_34EEA:
    // MOV BX,word ptr CS:[0x196] (334B_1A3A / 0x34EEA)
    BX = UInt16[cs2, 0x196];
    // MOV CX,DX (334B_1A3F / 0x34EEF)
    CX = DX;
    // MOV AX,CS:[0x194] (334B_1A41 / 0x34EF1)
    AX = UInt16[cs2, 0x194];
    // MOV DX,AX (334B_1A45 / 0x34EF5)
    DX = AX;
    // ADD AX,CX (334B_1A47 / 0x34EF7)
    AX += CX;
    
    // CMP AX,DX (334B_1A49 / 0x34EF9)
    Alu.Sub16(AX, DX);
    // JG 0x3000:4f01 (334B_1A4B / 0x34EFB)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_334B_1A51_34F01;
    }
    // MOV DX,AX (334B_1A4D / 0x34EFD)
    DX = AX;
    // NEG CX (334B_1A4F / 0x34EFF)
    CX = Alu.Sub16(0, CX);
    label_334B_1A51_34F01:
    // MOV DI,word ptr CS:[0x198] (334B_1A51 / 0x34F01)
    DI = UInt16[cs2, 0x198];
    // CMP BX,word ptr [DI + 0x2] (334B_1A56 / 0x34F06)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JL 0x3000:4f33 (334B_1A59 / 0x34F09)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1A83_34F33;
    }
    // CMP BX,word ptr [DI + 0x6] (334B_1A5B / 0x34F0B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JGE 0x3000:4f33 (334B_1A5E / 0x34F0E)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1A83_34F33;
    }
    // CALL 0x3000:40c0 (334B_1A60 / 0x34F10)
    NearCall(cs2, 0x1A63, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1A63_34F13:
    // INC CX (334B_1A63 / 0x34F13)
    CX = Alu.Inc16(CX);
    // MOV AL,CS:[0x19c] (334B_1A64 / 0x34F14)
    AL = UInt8[cs2, 0x19C];
    // MOV SI,word ptr CS:[0x198] (334B_1A68 / 0x34F18)
    SI = UInt16[cs2, 0x198];
    label_334B_1A6D_34F1D:
    // ROL word ptr CS:[0x19a],0x1 (334B_1A6D / 0x34F1D)
    UInt16[cs2, 0x19A] = Alu.Rol16(UInt16[cs2, 0x19A], 0x1);
    // JNC 0x3000:4f2f (334B_1A72 / 0x34F22)
    if(!CarryFlag) {
      goto label_334B_1A7F_34F2F;
    }
    // CMP DX,word ptr [SI] (334B_1A74 / 0x34F24)
    Alu.Sub16(DX, UInt16[DS, SI]);
    // JL 0x3000:4f2f (334B_1A76 / 0x34F26)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1A7F_34F2F;
    }
    // CMP DX,word ptr [SI + 0x4] (334B_1A78 / 0x34F28)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JGE 0x3000:4f2f (334B_1A7B / 0x34F2B)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1A7F_34F2F;
    }
    // STOSB ES:DI (334B_1A7D / 0x34F2D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // DEC DI (334B_1A7E / 0x34F2E)
    DI = Alu.Dec16(DI);
    label_334B_1A7F_34F2F:
    // INC DI (334B_1A7F / 0x34F2F)
    DI = Alu.Inc16(DI);
    // INC DX (334B_1A80 / 0x34F30)
    DX = Alu.Inc16(DX);
    // LOOP 0x3000:4f1d (334B_1A81 / 0x34F31)
    if(--CX != 0) {
      goto label_334B_1A6D_34F1D;
    }
    label_334B_1A83_34F33:
    // POP SI (334B_1A83 / 0x34F33)
    SI = Stack.Pop();
    // POP DI (334B_1A84 / 0x34F34)
    DI = Stack.Pop();
    // RET  (334B_1A85 / 0x34F35)
    return NearRet();
    label_334B_1A86_34F36:
    // MOV CX,BX (334B_1A86 / 0x34F36)
    CX = BX;
    // MOV BX,word ptr CS:[0x196] (334B_1A88 / 0x34F38)
    BX = UInt16[cs2, 0x196];
    // MOV DX,word ptr CS:[0x194] (334B_1A8D / 0x34F3D)
    DX = UInt16[cs2, 0x194];
    // OR AX,AX (334B_1A92 / 0x34F42)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x3000:4f48 (334B_1A94 / 0x34F44)
    if(!SignFlag) {
      goto label_334B_1A98_34F48;
    }
    // SUB BX,CX (334B_1A96 / 0x34F46)
    BX -= CX;
    
    label_334B_1A98_34F48:
    // CMP BX,0xc8 (334B_1A98 / 0x34F48)
    Alu.Sub16(BX, 0xC8);
    // JC 0x3000:4f54 (334B_1A9C / 0x34F4C)
    if(CarryFlag) {
      goto label_334B_1AA4_34F54;
    }
    // JGE 0x3000:4f89 (334B_1A9E / 0x34F4E)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1AD9_34F89;
    }
    // ADD CX,BX (334B_1AA0 / 0x34F50)
    CX += BX;
    
    // XOR BX,BX (334B_1AA2 / 0x34F52)
    BX = 0;
    label_334B_1AA4_34F54:
    // MOV DI,word ptr CS:[0x198] (334B_1AA4 / 0x34F54)
    DI = UInt16[cs2, 0x198];
    // CMP DX,word ptr [DI] (334B_1AA9 / 0x34F59)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JL 0x3000:4f89 (334B_1AAB / 0x34F5B)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1AD9_34F89;
    }
    // CMP DX,word ptr [DI + 0x4] (334B_1AAD / 0x34F5D)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JGE 0x3000:4f89 (334B_1AB0 / 0x34F60)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1AD9_34F89;
    }
    // CALL 0x3000:40c0 (334B_1AB2 / 0x34F62)
    NearCall(cs2, 0x1AB5, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1AB5_34F65:
    // INC CX (334B_1AB5 / 0x34F65)
    CX = Alu.Inc16(CX);
    // MOV AL,CS:[0x19c] (334B_1AB6 / 0x34F66)
    AL = UInt8[cs2, 0x19C];
    // MOV SI,word ptr CS:[0x198] (334B_1ABA / 0x34F6A)
    SI = UInt16[cs2, 0x198];
    label_334B_1ABF_34F6F:
    // ROL word ptr CS:[0x19a],0x1 (334B_1ABF / 0x34F6F)
    UInt16[cs2, 0x19A] = Alu.Rol16(UInt16[cs2, 0x19A], 0x1);
    // JNC 0x3000:4f82 (334B_1AC4 / 0x34F74)
    if(!CarryFlag) {
      goto label_334B_1AD2_34F82;
    }
    // CMP BX,word ptr [SI + 0x2] (334B_1AC6 / 0x34F76)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JL 0x3000:4f82 (334B_1AC9 / 0x34F79)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1AD2_34F82;
    }
    // CMP BX,word ptr [SI + 0x6] (334B_1ACB / 0x34F7B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JGE 0x3000:4f82 (334B_1ACE / 0x34F7E)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1AD2_34F82;
    }
    // STOSB ES:DI (334B_1AD0 / 0x34F80)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // DEC DI (334B_1AD1 / 0x34F81)
    DI = Alu.Dec16(DI);
    label_334B_1AD2_34F82:
    // INC BX (334B_1AD2 / 0x34F82)
    BX = Alu.Inc16(BX);
    // ADD DI,0x140 (334B_1AD3 / 0x34F83)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    // LOOP 0x3000:4f6f (334B_1AD7 / 0x34F87)
    if(--CX != 0) {
      goto label_334B_1ABF_34F6F;
    }
    label_334B_1AD9_34F89:
    // POP SI (334B_1AD9 / 0x34F89)
    SI = Stack.Pop();
    // POP DI (334B_1ADA / 0x34F8A)
    DI = Stack.Pop();
    // RET  (334B_1ADB / 0x34F8B)
    return NearRet();
    entry:
    label_334B_1ADC_34F8C:
    // PUSH DI (334B_1ADC / 0x34F8C)
    Stack.Push(DI);
    // PUSH SI (334B_1ADD / 0x34F8D)
    Stack.Push(SI);
    // OR BX,BX (334B_1ADE / 0x34F8E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNZ 0x3000:4f95 (334B_1AE0 / 0x34F90)
    if(!ZeroFlag) {
      goto label_334B_1AE5_34F95;
    }
    // JMP 0x3000:4eea (334B_1AE2 / 0x34F92)
    goto label_334B_1A3A_34EEA;
    label_334B_1AE5_34F95:
    // MOV AX,0x1 (334B_1AE5 / 0x34F95)
    AX = 0x1;
    // JNS 0x3000:4f9e (334B_1AE8 / 0x34F98)
    if(!SignFlag) {
      goto label_334B_1AEE_34F9E;
    }
    // NEG BX (334B_1AEA / 0x34F9A)
    BX = Alu.Sub16(0, BX);
    // NEG AX (334B_1AEC / 0x34F9C)
    AX = Alu.Sub16(0, AX);
    label_334B_1AEE_34F9E:
    // OR DX,DX (334B_1AEE / 0x34F9E)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x3000:4f36 (334B_1AF0 / 0x34FA0)
    if(ZeroFlag) {
      goto label_334B_1A86_34F36;
    }
    // MOV CX,0x1 (334B_1AF2 / 0x34FA2)
    CX = 0x1;
    // JNS 0x3000:4fab (334B_1AF5 / 0x34FA5)
    if(!SignFlag) {
      goto label_334B_1AFB_34FAB;
    }
    // NEG CX (334B_1AF7 / 0x34FA7)
    CX = Alu.Sub16(0, CX);
    // NEG DX (334B_1AF9 / 0x34FA9)
    DX = Alu.Sub16(0, DX);
    label_334B_1AFB_34FAB:
    // PUSH AX (334B_1AFB / 0x34FAB)
    Stack.Push(AX);
    // PUSH CX (334B_1AFC / 0x34FAC)
    Stack.Push(CX);
    // PUSH AX (334B_1AFD / 0x34FAD)
    Stack.Push(AX);
    // PUSH CX (334B_1AFE / 0x34FAE)
    Stack.Push(CX);
    // MOV BP,SP (334B_1AFF / 0x34FAF)
    BP = SP;
    // MOV SI,BX (334B_1B01 / 0x34FB1)
    SI = BX;
    // MOV DI,DX (334B_1B03 / 0x34FB3)
    DI = DX;
    // XOR AX,AX (334B_1B05 / 0x34FB5)
    AX = 0;
    // CMP DX,BX (334B_1B07 / 0x34FB7)
    Alu.Sub16(DX, BX);
    // JBE 0x3000:4fc0 (334B_1B09 / 0x34FB9)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_1B10_34FC0;
    }
    // MOV word ptr [BP + 0x2],AX (334B_1B0B / 0x34FBB)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // JMP 0x3000:4fc9 (334B_1B0E / 0x34FBE)
    goto label_334B_1B19_34FC9;
    label_334B_1B10_34FC0:
    // OR BX,BX (334B_1B10 / 0x34FC0)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x3000:5026 (334B_1B12 / 0x34FC2)
    if(ZeroFlag) {
      goto label_334B_1B76_35026;
    }
    // XCHG SI,DI (334B_1B14 / 0x34FC4)
    ushort tmp_334B_1B14 = SI;
    SI = DI;
    DI = tmp_334B_1B14;
    // MOV word ptr [BP + 0x0],AX (334B_1B16 / 0x34FC6)
    UInt16[SS, BP] = AX;
    label_334B_1B19_34FC9:
    // MOV AX,DI (334B_1B19 / 0x34FC9)
    AX = DI;
    // MOV CX,DI (334B_1B1B / 0x34FCB)
    CX = DI;
    // SHR AX,0x1 (334B_1B1D / 0x34FCD)
    AX >>= 0x1;
    
    label_334B_1B1F_34FCF:
    // ADD AX,SI (334B_1B1F / 0x34FCF)
    AX += SI;
    
    // CMP AX,DI (334B_1B21 / 0x34FD1)
    Alu.Sub16(AX, DI);
    // JC 0x3000:4fdf (334B_1B23 / 0x34FD3)
    if(CarryFlag) {
      goto label_334B_1B2F_34FDF;
    }
    // SUB AX,DI (334B_1B25 / 0x34FD5)
    // AX -= DI;
    AX = Alu.Sub16(AX, DI);
    // MOV DX,word ptr [BP + 0x4] (334B_1B27 / 0x34FD7)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV BX,word ptr [BP + 0x6] (334B_1B2A / 0x34FDA)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // JMP 0x3000:4fe5 (334B_1B2D / 0x34FDD)
    goto label_334B_1B35_34FE5;
    label_334B_1B2F_34FDF:
    // MOV DX,word ptr [BP + 0x0] (334B_1B2F / 0x34FDF)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_1B32 / 0x34FE2)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    label_334B_1B35_34FE5:
    // ADD DX,word ptr CS:[0x194] (334B_1B35 / 0x34FE5)
    DX += UInt16[cs2, 0x194];
    
    // ADD BX,word ptr CS:[0x196] (334B_1B3A / 0x34FEA)
    // BX += UInt16[cs2, 0x196];
    BX = Alu.Add16(BX, UInt16[cs2, 0x196]);
    // MOV word ptr CS:[0x194],DX (334B_1B3F / 0x34FEF)
    UInt16[cs2, 0x194] = DX;
    // MOV word ptr CS:[0x196],BX (334B_1B44 / 0x34FF4)
    UInt16[cs2, 0x196] = BX;
    // PUSH AX (334B_1B49 / 0x34FF9)
    Stack.Push(AX);
    // PUSH DI (334B_1B4A / 0x34FFA)
    Stack.Push(DI);
    // ROL word ptr CS:[0x19a],0x1 (334B_1B4B / 0x34FFB)
    UInt16[cs2, 0x19A] = Alu.Rol16(UInt16[cs2, 0x19A], 0x1);
    // JNC 0x3000:5022 (334B_1B50 / 0x35000)
    if(!CarryFlag) {
      goto label_334B_1B72_35022;
    }
    // MOV DI,word ptr CS:[0x198] (334B_1B52 / 0x35002)
    DI = UInt16[cs2, 0x198];
    // CMP DX,word ptr [DI] (334B_1B57 / 0x35007)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JL 0x3000:5022 (334B_1B59 / 0x35009)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    // CMP BX,word ptr [DI + 0x2] (334B_1B5B / 0x3500B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JL 0x3000:5022 (334B_1B5E / 0x3500E)
    if(SignFlag != OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    // CMP DX,word ptr [DI + 0x4] (334B_1B60 / 0x35010)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JGE 0x3000:5022 (334B_1B63 / 0x35013)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    // CMP BX,word ptr [DI + 0x6] (334B_1B65 / 0x35015)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JGE 0x3000:5022 (334B_1B68 / 0x35018)
    if(SignFlag == OverflowFlag) {
      goto label_334B_1B72_35022;
    }
    // CALL 0x3000:40c0 (334B_1B6A / 0x3501A)
    NearCall(cs2, 0x1B6D, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1B6D_3501D:
    // MOV AL,CS:[0x19c] (334B_1B6D / 0x3501D)
    AL = UInt8[cs2, 0x19C];
    // STOSB ES:DI (334B_1B71 / 0x35021)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_334B_1B72_35022:
    // POP DI (334B_1B72 / 0x35022)
    DI = Stack.Pop();
    // POP AX (334B_1B73 / 0x35023)
    AX = Stack.Pop();
    // LOOP 0x3000:4fcf (334B_1B74 / 0x35024)
    if(--CX != 0) {
      goto label_334B_1B1F_34FCF;
    }
    label_334B_1B76_35026:
    // ADD SP,0x8 (334B_1B76 / 0x35026)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    // POP SI (334B_1B79 / 0x35029)
    SI = Stack.Pop();
    // POP DI (334B_1B7A / 0x3502A)
    DI = Stack.Pop();
    // RET  (334B_1B7B / 0x3502B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_1B7C_03502C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1B7C_3502C:
    // PUSH CX (334B_1B7C / 0x3502C)
    Stack.Push(CX);
    // PUSH SI (334B_1B7D / 0x3502D)
    Stack.Push(SI);
    // PUSH DI (334B_1B7E / 0x3502E)
    Stack.Push(DI);
    // XOR SI,SI (334B_1B7F / 0x3502F)
    SI = 0;
    // MOV DI,SI (334B_1B81 / 0x35031)
    DI = SI;
    // MOV CX,0x7d00 (334B_1B83 / 0x35033)
    CX = 0x7D00;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1B86 / 0x35036)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // POP DI (334B_1B88 / 0x35038)
    DI = Stack.Pop();
    // POP SI (334B_1B89 / 0x35039)
    SI = Stack.Pop();
    // POP CX (334B_1B8A / 0x3503A)
    CX = Stack.Pop();
    // RETF  (334B_1B8B / 0x3503B)
    return FarRet();
  }
  
  public Action not_observed_334B_1B8C_03503C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1B8C_3503C:
    // MOV DS,SI (334B_1B8C / 0x3503C)
    DS = SI;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_334B_1B8E_03503E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1B8E_3503E:
    // CALL 0x3000:40c0 (334B_1B8E / 0x3503E)
    NearCall(cs2, 0x1B91, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1B91_35041:
    // SHR BP,0x1 (334B_1B91 / 0x35041)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // JC 0x3000:5059 (334B_1B93 / 0x35043)
    if(CarryFlag) {
      goto label_334B_1BA9_35059;
    }
    // JZ 0x3000:506d (334B_1B95 / 0x35045)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      // RETF  (334B_1BBD / 0x3506D)
      return FarRet();
    }
    // MOV DX,DI (334B_1B97 / 0x35047)
    DX = DI;
    label_334B_1B99_35049:
    // MOV SI,DX (334B_1B99 / 0x35049)
    SI = DX;
    // MOV DI,SI (334B_1B9B / 0x3504B)
    DI = SI;
    // MOV CX,BP (334B_1B9D / 0x3504D)
    CX = BP;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1B9F / 0x3504F)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADD DX,0x140 (334B_1BA1 / 0x35051)
    DX += 0x140;
    
    // DEC AX (334B_1BA5 / 0x35055)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:5049 (334B_1BA6 / 0x35056)
    if(!ZeroFlag) {
      goto label_334B_1B99_35049;
    }
    // RETF  (334B_1BA8 / 0x35058)
    return FarRet();
    label_334B_1BA9_35059:
    // JZ 0x3000:506e (334B_1BA9 / 0x35059)
    if(ZeroFlag) {
      goto label_334B_1BBE_3506E;
    }
    // MOV DX,DI (334B_1BAB / 0x3505B)
    DX = DI;
    label_334B_1BAD_3505D:
    // MOV SI,DX (334B_1BAD / 0x3505D)
    SI = DX;
    // MOV DI,SI (334B_1BAF / 0x3505F)
    DI = SI;
    // MOV CX,BP (334B_1BB1 / 0x35061)
    CX = BP;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1BB3 / 0x35063)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // MOVSB ES:DI,SI (334B_1BB5 / 0x35065)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // ADD DX,0x140 (334B_1BB6 / 0x35066)
    DX += 0x140;
    
    // DEC AX (334B_1BBA / 0x3506A)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:505d (334B_1BBB / 0x3506B)
    if(!ZeroFlag) {
      goto label_334B_1BAD_3505D;
    }
    label_334B_1BBD_3506D:
    // RETF  (334B_1BBD / 0x3506D)
    return FarRet();
    label_334B_1BBE_3506E:
    // MOV CX,AX (334B_1BBE / 0x3506E)
    CX = AX;
    label_334B_1BC0_35070:
    // MOV SI,DI (334B_1BC0 / 0x35070)
    SI = DI;
    // MOVSB ES:DI,SI (334B_1BC2 / 0x35072)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // ADD DI,0x13f (334B_1BC3 / 0x35073)
    // DI += 0x13F;
    DI = Alu.Add16(DI, 0x13F);
    // LOOP 0x3000:5070 (334B_1BC7 / 0x35077)
    if(--CX != 0) {
      goto label_334B_1BC0_35070;
    }
    // RETF  (334B_1BC9 / 0x35079)
    return FarRet();
  }
  
  public Action not_observed_334B_1BCA_03507A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1BCA_3507A:
    // MOV BP,DI (334B_1BCA / 0x3507A)
    BP = DI;
    // AND BP,0x1ff (334B_1BCC / 0x3507C)
    // BP &= 0x1FF;
    BP = Alu.And16(BP, 0x1FF);
    // CALL 0x3000:40c0 (334B_1BD0 / 0x35080)
    NearCall(cs2, 0x1BD3, spice86_generated_label_call_target_334B_0C10_0340C0);
    // MOV DX,CX (334B_1BD3 / 0x35083)
    DX = CX;
    // XOR DH,DH (334B_1BD5 / 0x35085)
    DH = 0;
    label_334B_1BD7_35087:
    // MOV CX,BP (334B_1BD7 / 0x35087)
    CX = BP;
    // PUSH DI (334B_1BD9 / 0x35089)
    Stack.Push(DI);
    label_334B_1BDA_3508A:
    // MOVSB ES:DI,SI (334B_1BDA / 0x3508A)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // INC DI (334B_1BDB / 0x3508B)
    DI = Alu.Inc16(DI);
    // LOOP 0x3000:508a (334B_1BDC / 0x3508C)
    if(--CX != 0) {
      goto label_334B_1BDA_3508A;
    }
    // POP DI (334B_1BDE / 0x3508E)
    DI = Stack.Pop();
    // ADD DI,0x280 (334B_1BDF / 0x3508F)
    DI += 0x280;
    
    // DEC DX (334B_1BE3 / 0x35093)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:5087 (334B_1BE4 / 0x35094)
    if(!ZeroFlag) {
      goto label_334B_1BD7_35087;
    }
    // RETF  (334B_1BE6 / 0x35096)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1BE7_035097(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1BE7_35097:
    // PUSH DS (334B_1BE7 / 0x35097)
    Stack.Push(DS);
    // MOV DS,SI (334B_1BE8 / 0x35098)
    DS = SI;
    // XOR SI,SI (334B_1BEA / 0x3509A)
    SI = 0;
    // MOV DI,SI (334B_1BEC / 0x3509C)
    DI = SI;
    // MOV CX,0x5f00 (334B_1BEE / 0x3509E)
    CX = 0x5F00;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1BF1 / 0x350A1)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // POP DS (334B_1BF3 / 0x350A3)
    DS = Stack.Pop();
    // RETF  (334B_1BF4 / 0x350A4)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1BF5_0350A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1BF5_350A5:
    // CALL 0x3000:40c0 (334B_1BF5 / 0x350A5)
    NearCall(cs2, 0x1BF8, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1BF8_350A8:
    // MOV BX,AX (334B_1BF8 / 0x350A8)
    BX = AX;
    // MOV DX,CX (334B_1BFA / 0x350AA)
    DX = CX;
    // XOR CX,CX (334B_1BFC / 0x350AC)
    CX = 0;
    // MOV BP,DI (334B_1BFE / 0x350AE)
    BP = DI;
    // OR BH,BH (334B_1C00 / 0x350B0)
    // BH |= BH;
    BH = Alu.Or8(BH, BH);
    // JZ 0x3000:50cf (334B_1C02 / 0x350B2)
    if(ZeroFlag) {
      goto label_334B_1C1F_350CF;
    }
    label_334B_1C04_350B4:
    // MOV CL,DL (334B_1C04 / 0x350B4)
    CL = DL;
    // LODSB SI (334B_1C06 / 0x350B6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV AH,AL (334B_1C07 / 0x350B7)
    AH = AL;
    label_334B_1C09_350B9:
    // MOV AL,BL (334B_1C09 / 0x350B9)
    AL = BL;
    // SHL AH,0x1 (334B_1C0B / 0x350BB)
    // AH <<= 0x1;
    AH = Alu.Shl8(AH, 0x1);
    // JC 0x3000:50c1 (334B_1C0D / 0x350BD)
    if(CarryFlag) {
      goto label_334B_1C11_350C1;
    }
    // MOV AL,BH (334B_1C0F / 0x350BF)
    AL = BH;
    label_334B_1C11_350C1:
    // STOSB ES:DI (334B_1C11 / 0x350C1)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x3000:50b9 (334B_1C12 / 0x350C2)
    if(--CX != 0) {
      goto label_334B_1C09_350B9;
    }
    // ADD BP,0x140 (334B_1C14 / 0x350C4)
    // BP += 0x140;
    BP = Alu.Add16(BP, 0x140);
    // MOV DI,BP (334B_1C18 / 0x350C8)
    DI = BP;
    // DEC DH (334B_1C1A / 0x350CA)
    DH = Alu.Dec8(DH);
    // JNZ 0x3000:50b4 (334B_1C1C / 0x350CC)
    if(!ZeroFlag) {
      goto label_334B_1C04_350B4;
    }
    // RETF  (334B_1C1E / 0x350CE)
    return FarRet();
    label_334B_1C1F_350CF:
    // MOV CL,DL (334B_1C1F / 0x350CF)
    CL = DL;
    // LODSB SI (334B_1C21 / 0x350D1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV AH,AL (334B_1C22 / 0x350D2)
    AH = AL;
    // MOV AL,BL (334B_1C24 / 0x350D4)
    AL = BL;
    label_334B_1C26_350D6:
    // SHL AH,0x1 (334B_1C26 / 0x350D6)
    // AH <<= 0x1;
    AH = Alu.Shl8(AH, 0x1);
    // JC 0x3000:50e8 (334B_1C28 / 0x350D8)
    if(CarryFlag) {
      goto label_334B_1C38_350E8;
    }
    // INC DI (334B_1C2A / 0x350DA)
    DI = Alu.Inc16(DI);
    // LOOP 0x3000:50d6 (334B_1C2B / 0x350DB)
    if(--CX != 0) {
      goto label_334B_1C26_350D6;
    }
    // ADD BP,0x140 (334B_1C2D / 0x350DD)
    // BP += 0x140;
    BP = Alu.Add16(BP, 0x140);
    // MOV DI,BP (334B_1C31 / 0x350E1)
    DI = BP;
    // DEC DH (334B_1C33 / 0x350E3)
    DH = Alu.Dec8(DH);
    // JNZ 0x3000:50cf (334B_1C35 / 0x350E5)
    if(!ZeroFlag) {
      goto label_334B_1C1F_350CF;
    }
    // RETF  (334B_1C37 / 0x350E7)
    return FarRet();
    label_334B_1C38_350E8:
    // STOSB ES:DI (334B_1C38 / 0x350E8)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x3000:50d6 (334B_1C39 / 0x350E9)
    if(--CX != 0) {
      goto label_334B_1C26_350D6;
    }
    // ADD BP,0x140 (334B_1C3B / 0x350EB)
    // BP += 0x140;
    BP = Alu.Add16(BP, 0x140);
    // MOV DI,BP (334B_1C3F / 0x350EF)
    DI = BP;
    // DEC DH (334B_1C41 / 0x350F1)
    DH = Alu.Dec8(DH);
    // JNZ 0x3000:50cf (334B_1C43 / 0x350F3)
    if(!ZeroFlag) {
      goto label_334B_1C1F_350CF;
    }
    // RETF  (334B_1C45 / 0x350F5)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1C46_0350F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1C46_350F6:
    // MOV DX,word ptr [BP + 0x0] (334B_1C46 / 0x350F6)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_1C49 / 0x350F9)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // CALL 0x3000:40c0 (334B_1C4C / 0x350FC)
    NearCall(cs2, 0x1C4F, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1C4F_350FF:
    // MOV CX,word ptr [BP + 0x4] (334B_1C4F / 0x350FF)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV AX,word ptr [BP + 0x6] (334B_1C52 / 0x35102)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // SUB CX,DX (334B_1C55 / 0x35105)
    CX -= DX;
    
    // SUB AX,BX (334B_1C57 / 0x35107)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // XCHG SI,DI (334B_1C59 / 0x35109)
    ushort tmp_334B_1C59 = SI;
    SI = DI;
    DI = tmp_334B_1C59;
    // MOV DX,0x140 (334B_1C5B / 0x3510B)
    DX = 0x140;
    // SUB DX,CX (334B_1C5E / 0x3510E)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    // PUSH DS (334B_1C60 / 0x35110)
    Stack.Push(DS);
    // PUSH ES (334B_1C61 / 0x35111)
    Stack.Push(ES);
    // POP DS (334B_1C62 / 0x35112)
    DS = Stack.Pop();
    // POP ES (334B_1C63 / 0x35113)
    ES = Stack.Pop();
    label_334B_1C64_35114:
    // PUSH CX (334B_1C64 / 0x35114)
    Stack.Push(CX);
    // SHR CX,0x1 (334B_1C65 / 0x35115)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1C67 / 0x35117)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADC CX,CX (334B_1C69 / 0x35119)
    CX = Alu.Adc16(CX, CX);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_1C6B / 0x3511B)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP CX (334B_1C6D / 0x3511D)
    CX = Stack.Pop();
    // ADD SI,DX (334B_1C6E / 0x3511E)
    SI += DX;
    
    // DEC AX (334B_1C70 / 0x35120)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:5114 (334B_1C71 / 0x35121)
    if(!ZeroFlag) {
      goto label_334B_1C64_35114;
    }
    // PUSH SS (334B_1C73 / 0x35123)
    Stack.Push(SS);
    // POP DS (334B_1C74 / 0x35124)
    DS = Stack.Pop();
    // RETF  (334B_1C75 / 0x35125)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1C76_035126(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1C76_35126:
    // MOV DX,word ptr [BP + 0x0] (334B_1C76 / 0x35126)
    DX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_1C79 / 0x35129)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // CALL 0x3000:40c0 (334B_1C7C / 0x3512C)
    NearCall(cs2, 0x1C7F, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_1C7F_3512F:
    // MOV CX,word ptr [BP + 0x4] (334B_1C7F / 0x3512F)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV AX,word ptr [BP + 0x6] (334B_1C82 / 0x35132)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // SUB CX,DX (334B_1C85 / 0x35135)
    CX -= DX;
    
    // SUB AX,BX (334B_1C87 / 0x35137)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // MOV DX,0x140 (334B_1C89 / 0x35139)
    DX = 0x140;
    // SUB DX,CX (334B_1C8C / 0x3513C)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    label_334B_1C8E_3513E:
    // PUSH CX (334B_1C8E / 0x3513E)
    Stack.Push(CX);
    // SHR CX,0x1 (334B_1C8F / 0x3513F)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_1C91 / 0x35141)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADC CX,CX (334B_1C93 / 0x35143)
    CX = Alu.Adc16(CX, CX);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_1C95 / 0x35145)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP CX (334B_1C97 / 0x35147)
    CX = Stack.Pop();
    // ADD DI,DX (334B_1C98 / 0x35148)
    DI += DX;
    
    // DEC AX (334B_1C9A / 0x3514A)
    AX = Alu.Dec16(AX);
    // JNZ 0x3000:513e (334B_1C9B / 0x3514B)
    if(!ZeroFlag) {
      goto label_334B_1C8E_3513E;
    }
    // PUSH SS (334B_1C9D / 0x3514D)
    Stack.Push(SS);
    // POP DS (334B_1C9E / 0x3514E)
    DS = Stack.Pop();
    // RETF  (334B_1C9F / 0x3514F)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1CB6_035166(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1CB6_35166:
    // OR AL,AL (334B_1CB6 / 0x35166)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // MOV AX,0x9090 (334B_1CB8 / 0x35168)
    AX = 0x9090;
    // JZ 0x3000:5170 (334B_1CBB / 0x3516B)
    if(ZeroFlag) {
      goto label_334B_1CC0_35170;
    }
    // MOV AX,0x7deb (334B_1CBD / 0x3516D)
    AX = 0x7DEB;
    label_334B_1CC0_35170:
    // MOV CS:[0x1e4a],AX (334B_1CC0 / 0x35170)
    UInt16[cs2, 0x1E4A] = AX;
    // MOV word ptr CS:[0x1ca0],SI (334B_1CC4 / 0x35174)
    UInt16[cs2, 0x1CA0] = SI;
    // MOV word ptr CS:[0x1ca2],DS (334B_1CC9 / 0x35179)
    UInt16[cs2, 0x1CA2] = DS;
    // MOV word ptr CS:[0x1ca4],BP (334B_1CCE / 0x3517E)
    UInt16[cs2, 0x1CA4] = BP;
    // ADD BP,0x319 (334B_1CD3 / 0x35183)
    // BP += 0x319;
    BP = Alu.Add16(BP, 0x319);
    // MOV word ptr CS:[0x1ca8],BP (334B_1CD7 / 0x35187)
    UInt16[cs2, 0x1CA8] = BP;
    // MOV DI,BP (334B_1CDC / 0x3518C)
    DI = BP;
    // MOV word ptr CS:[0x1ca6],BP (334B_1CDE / 0x3518E)
    UInt16[cs2, 0x1CA6] = BP;
    // ADD BP,0xcd9 (334B_1CE3 / 0x35193)
    // BP += 0xCD9;
    BP = Alu.Add16(BP, 0xCD9);
    // MOV word ptr CS:[0x1caa],BP (334B_1CE7 / 0x35197)
    UInt16[cs2, 0x1CAA] = BP;
    // ADD BP,0x3301 (334B_1CEC / 0x3519C)
    // BP += 0x3301;
    BP = Alu.Add16(BP, 0x3301);
    // MOV word ptr CS:[0x1cac],BP (334B_1CF0 / 0x351A0)
    UInt16[cs2, 0x1CAC] = BP;
    // MOV word ptr CS:[0x1cb4],0xfec0 (334B_1CF5 / 0x351A5)
    UInt16[cs2, 0x1CB4] = 0xFEC0;
    // PUSH CS (334B_1CFC / 0x351AC)
    Stack.Push(cs2);
    // CALL 0x3000:520a (334B_1CFD / 0x351AD)
    NearCall(cs2, 0x1D00, spice86_generated_label_call_target_334B_1D5A_03520A);
    label_334B_1D00_351B0:
    // PUSH CS (334B_1D00 / 0x351B0)
    Stack.Push(cs2);
    // CALL 0x3000:51b7 (334B_1D01 / 0x351B1)
    NearCall(cs2, 0x1D04, spice86_generated_label_call_target_334B_1D07_0351B7);
    label_334B_1D04_351B4:
    // JNC 0x3000:51b0 (334B_1D04 / 0x351B4)
    if(!CarryFlag) {
      goto label_334B_1D00_351B0;
    }
    // RETF  (334B_1D06 / 0x351B6)
    return FarRet();
  }
  
  public Action spice86_generated_label_call_target_334B_1D07_0351B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1D07_351B7:
    // MOV DS,word ptr CS:[0x1ca2] (334B_1D07 / 0x351B7)
    DS = UInt16[cs2, 0x1CA2];
    // MOV DI,word ptr CS:[0x1ca6] (334B_1D0C / 0x351BC)
    DI = UInt16[cs2, 0x1CA6];
    // MOV AL,byte ptr SS:[DI] (334B_1D11 / 0x351C1)
    AL = UInt8[SS, DI];
    // XOR AH,AH (334B_1D14 / 0x351C4)
    AH = 0;
    // INC DI (334B_1D16 / 0x351C6)
    DI = Alu.Inc16(DI);
    // OR AL,AL (334B_1D17 / 0x351C7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x3000:5202 (334B_1D19 / 0x351C9)
    if(!SignFlag) {
      goto label_334B_1D52_35202;
    }
    // MOV DI,word ptr CS:[0x1ca8] (334B_1D1B / 0x351CB)
    DI = UInt16[cs2, 0x1CA8];
    // NEG word ptr CS:[0x1cb4] (334B_1D20 / 0x351D0)
    UInt16[cs2, 0x1CB4] = Alu.Sub16(0, UInt16[cs2, 0x1CB4]);
    // JS 0x3000:520a (334B_1D25 / 0x351D5)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1D5A_03520A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV word ptr CS:[0x1ea6],0xfedb (334B_1D27 / 0x351D7)
    UInt16[cs2, 0x1EA6] = 0xFEDB;
    // MOV word ptr CS:[0x1f29],0xfe58 (334B_1D2E / 0x351DE)
    UInt16[cs2, 0x1F29] = 0xFE58;
    // MOV AX,0x64a0 (334B_1D35 / 0x351E5)
    AX = 0x64A0;
    // MOV CS:[0x1cb0],AX (334B_1D38 / 0x351E8)
    UInt16[cs2, 0x1CB0] = AX;
    // MOV CS:[0x1cb2],AX (334B_1D3C / 0x351EC)
    UInt16[cs2, 0x1CB2] = AX;
    // DEC AX (334B_1D40 / 0x351F0)
    AX = Alu.Dec16(AX);
    // MOV CS:[0x1cae],AX (334B_1D41 / 0x351F1)
    UInt16[cs2, 0x1CAE] = AX;
    // MOV AL,byte ptr SS:[DI + -0x1] (334B_1D45 / 0x351F5)
    AL = UInt8[SS, (ushort)(DI - 0x1)];
    // CBW  (334B_1D49 / 0x351F9)
    AX = (ushort)((short)((sbyte)AL));
    // SUB DI,AX (334B_1D4A / 0x351FA)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    // MOV AL,byte ptr SS:[DI] (334B_1D4C / 0x351FC)
    AL = UInt8[SS, DI];
    // XOR AH,AH (334B_1D4F / 0x351FF)
    AH = 0;
    // INC DI (334B_1D51 / 0x35201)
    DI = Alu.Inc16(DI);
    label_334B_1D52_35202:
    // MOV SI,word ptr CS:[0x1caa] (334B_1D52 / 0x35202)
    SI = UInt16[cs2, 0x1CAA];
    // JMP 0x3000:5355 (334B_1D57 / 0x35207)
    // JMP target is JMP, inlining.
    // JMP 0x3000:5235 (334B_1EA5 / 0x35355)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 334B_1D5A_3520A, 334B_1D27_351D7, 334B_1D5F_3520F
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_1D85_035235, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_334B_1D5A_03520A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1D5A_3520A:
    // MOV word ptr CS:[0x1ca6],DI (334B_1D5A / 0x3520A)
    UInt16[cs2, 0x1CA6] = DI;
    // MOV word ptr CS:[0x1ea6],0xfedd (334B_1D5F / 0x3520F)
    UInt16[cs2, 0x1EA6] = 0xFEDD;
    // MOV word ptr CS:[0x1f29],0xfe5a (334B_1D66 / 0x35216)
    UInt16[cs2, 0x1F29] = 0xFE5A;
    // MOV AX,0x6360 (334B_1D6D / 0x3521D)
    AX = 0x6360;
    // MOV CS:[0x1cb0],AX (334B_1D70 / 0x35220)
    UInt16[cs2, 0x1CB0] = AX;
    // MOV CS:[0x1cb2],AX (334B_1D74 / 0x35224)
    UInt16[cs2, 0x1CB2] = AX;
    // DEC AX (334B_1D78 / 0x35228)
    AX = Alu.Dec16(AX);
    // MOV CS:[0x1cae],AX (334B_1D79 / 0x35229)
    UInt16[cs2, 0x1CAE] = AX;
    // MOV AX,SS (334B_1D7D / 0x3522D)
    AX = SS;
    // MOV DS,AX (334B_1D7F / 0x3522F)
    DS = AX;
    // STC  (334B_1D81 / 0x35231)
    CarryFlag = true;
    // RETF  (334B_1D82 / 0x35232)
    return FarRet();
  }
  
  public Action split_334B_1D85_035235(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1D85_35235:
    // ADD AX,AX (334B_1D85 / 0x35235)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // MOV BP,word ptr CS:[0x1cac] (334B_1D87 / 0x35237)
    BP = UInt16[cs2, 0x1CAC];
    // ADD BP,AX (334B_1D8C / 0x3523C)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    // MOV AX,word ptr [BP + 0x0] (334B_1D8E / 0x3523E)
    AX = UInt16[SS, BP];
    // OR AX,AX (334B_1D91 / 0x35241)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x3000:5293 (334B_1D93 / 0x35243)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_334B_1DC2_035272, 0x35293 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CBW  (334B_1D95 / 0x35245)
    AX = (ushort)((short)((sbyte)AL));
    // OR AX,AX (334B_1D96 / 0x35246)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x3000:5272 (334B_1D98 / 0x35248)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_1DC2_035272, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // NEG AX (334B_1D9A / 0x3524A)
    AX = Alu.Sub16(0, AX);
    // MOV BP,AX (334B_1D9C / 0x3524C)
    BP = AX;
    // MOV BL,byte ptr [BP + SI] (334B_1D9E / 0x3524E)
    BL = UInt8[SS, (ushort)(BP + SI)];
    // MOV AL,byte ptr [BP + SI + 0x64] (334B_1DA0 / 0x35250)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    // XOR AH,AH (334B_1DA3 / 0x35253)
    AH = 0;
    // MOV BH,AH (334B_1DA5 / 0x35255)
    BH = AH;
    // SHL BX,0x1 (334B_1DA7 / 0x35257)
    BX <<= 0x1;
    
    // SHL BX,0x1 (334B_1DA9 / 0x35259)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV BP,word ptr CS:[0x1ca4] (334B_1DAB / 0x3525B)
    BP = UInt16[cs2, 0x1CA4];
    // ADD BP,BX (334B_1DB0 / 0x35260)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    // MOV BX,word ptr [BP + 0x0] (334B_1DB2 / 0x35262)
    BX = UInt16[SS, BP];
    // MOV CX,word ptr [BP + 0x2] (334B_1DB5 / 0x35265)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DX,word ptr [BP + 0x4] (334B_1DB8 / 0x35268)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // NEG AX (334B_1DBB / 0x3526B)
    AX = Alu.Sub16(0, AX);
    // ADD AX,CX (334B_1DBD / 0x3526D)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // JMP 0x3000:52e2 (334B_1DBF / 0x3526F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_334B_1DC2_035272, 0x352E2 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_334B_1DC2_035272(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25293: goto label_334B_1DE3_35293;break; // Target of external jump from 0x35243
      case 0x25355: goto label_334B_1EA5_35355;break; // Target of external jump from 0x35207
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_334B_1DC2_35272:
    // MOV BP,AX (334B_1DC2 / 0x35272)
    BP = AX;
    // MOV BL,byte ptr [BP + SI] (334B_1DC4 / 0x35274)
    BL = UInt8[SS, (ushort)(BP + SI)];
    // MOV AL,byte ptr [BP + SI + 0x64] (334B_1DC6 / 0x35276)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    // XOR AH,AH (334B_1DC9 / 0x35279)
    AH = 0;
    // MOV BH,AH (334B_1DCB / 0x3527B)
    BH = AH;
    // SHL BX,0x1 (334B_1DCD / 0x3527D)
    BX <<= 0x1;
    
    // SHL BX,0x1 (334B_1DCF / 0x3527F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV BP,word ptr CS:[0x1ca4] (334B_1DD1 / 0x35281)
    BP = UInt16[cs2, 0x1CA4];
    // ADD BP,BX (334B_1DD6 / 0x35286)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    // MOV BX,word ptr [BP + 0x0] (334B_1DD8 / 0x35288)
    BX = UInt16[SS, BP];
    // MOV CX,word ptr [BP + 0x2] (334B_1DDB / 0x3528B)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DX,word ptr [BP + 0x4] (334B_1DDE / 0x3528E)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // JMP 0x3000:52e2 (334B_1DE1 / 0x35291)
    goto label_334B_1E32_352E2;
    label_334B_1DE3_35293:
    // CBW  (334B_1DE3 / 0x35293)
    AX = (ushort)((short)((sbyte)AL));
    // OR AX,AX (334B_1DE4 / 0x35294)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x3000:52c1 (334B_1DE6 / 0x35296)
    if(!SignFlag) {
      goto label_334B_1E11_352C1;
    }
    // NEG AX (334B_1DE8 / 0x35298)
    AX = Alu.Sub16(0, AX);
    // MOV BP,AX (334B_1DEA / 0x3529A)
    BP = AX;
    // MOV BL,byte ptr [BP + SI] (334B_1DEC / 0x3529C)
    BL = UInt8[SS, (ushort)(BP + SI)];
    // MOV AL,byte ptr [BP + SI + 0x64] (334B_1DEE / 0x3529E)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    // XOR AH,AH (334B_1DF1 / 0x352A1)
    AH = 0;
    // MOV BH,AH (334B_1DF3 / 0x352A3)
    BH = AH;
    // SHL BX,0x1 (334B_1DF5 / 0x352A5)
    BX <<= 0x1;
    
    // SHL BX,0x1 (334B_1DF7 / 0x352A7)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV BP,word ptr CS:[0x1ca4] (334B_1DF9 / 0x352A9)
    BP = UInt16[cs2, 0x1CA4];
    // ADD BP,BX (334B_1DFE / 0x352AE)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    // MOV BX,word ptr [BP + 0x0] (334B_1E00 / 0x352B0)
    BX = UInt16[SS, BP];
    // MOV CX,word ptr [BP + 0x2] (334B_1E03 / 0x352B3)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DX,word ptr [BP + 0x4] (334B_1E06 / 0x352B6)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // NEG AX (334B_1E09 / 0x352B9)
    AX = Alu.Sub16(0, AX);
    // ADD AX,CX (334B_1E0B / 0x352BB)
    AX += CX;
    
    // NEG BX (334B_1E0D / 0x352BD)
    BX = Alu.Sub16(0, BX);
    // JMP 0x3000:52e2 (334B_1E0F / 0x352BF)
    goto label_334B_1E32_352E2;
    label_334B_1E11_352C1:
    // MOV BP,AX (334B_1E11 / 0x352C1)
    BP = AX;
    // MOV BL,byte ptr [BP + SI] (334B_1E13 / 0x352C3)
    BL = UInt8[SS, (ushort)(BP + SI)];
    // MOV AL,byte ptr [BP + SI + 0x64] (334B_1E15 / 0x352C5)
    AL = UInt8[SS, (ushort)(BP + SI + 0x64)];
    // XOR AH,AH (334B_1E18 / 0x352C8)
    AH = 0;
    // MOV BH,AH (334B_1E1A / 0x352CA)
    BH = AH;
    // SHL BX,0x1 (334B_1E1C / 0x352CC)
    BX <<= 0x1;
    
    // SHL BX,0x1 (334B_1E1E / 0x352CE)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV BP,word ptr CS:[0x1ca4] (334B_1E20 / 0x352D0)
    BP = UInt16[cs2, 0x1CA4];
    // ADD BP,BX (334B_1E25 / 0x352D5)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    // MOV BX,word ptr [BP + 0x0] (334B_1E27 / 0x352D7)
    BX = UInt16[SS, BP];
    // MOV CX,word ptr [BP + 0x2] (334B_1E2A / 0x352DA)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DX,word ptr [BP + 0x4] (334B_1E2D / 0x352DD)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    // NEG BX (334B_1E30 / 0x352E0)
    BX = Alu.Sub16(0, BX);
    label_334B_1E32_352E2:
    // ADD CX,CX (334B_1E32 / 0x352E2)
    // CX += CX;
    CX = Alu.Add16(CX, CX);
    // MOV BP,DX (334B_1E34 / 0x352E4)
    BP = DX;
    // SUB BP,AX (334B_1E36 / 0x352E6)
    // BP -= AX;
    BP = Alu.Sub16(BP, AX);
    // JNS 0x3000:52ec (334B_1E38 / 0x352E8)
    if(!SignFlag) {
      goto label_334B_1E3C_352EC;
    }
    // ADD BP,CX (334B_1E3A / 0x352EA)
    BP += CX;
    
    label_334B_1E3C_352EC:
    // ADD BP,BX (334B_1E3C / 0x352EC)
    BP += BX;
    
    // ADD DX,AX (334B_1E3E / 0x352EE)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // PUSH SI (334B_1E40 / 0x352F0)
    Stack.Push(SI);
    // PUSH DI (334B_1E41 / 0x352F1)
    Stack.Push(DI);
    // MOV SI,word ptr CS:[0x1ca0] (334B_1E42 / 0x352F2)
    SI = UInt16[cs2, 0x1CA0];
    // MOV AL,byte ptr DS:[BP + SI] (334B_1E47 / 0x352F7)
    AL = UInt8[DS, (ushort)(BP + SI)];
    // NOP  (334B_1E4A / 0x352FA)
    // Instruction bytes at index 0 modified by those instruction(s): 334B_1CC0_35170
    
    // NOP  (334B_1E4B / 0x352FB)
    // Instruction bytes at index 0 modified by those instruction(s): 334B_1CC0_35170
    
    // MOV AH,AL (334B_1E4C / 0x352FC)
    AH = AL;
    // AND AX,0x300f (334B_1E4E / 0x352FE)
    AX &= 0x300F;
    
    // CMP AH,0x10 (334B_1E51 / 0x35301)
    Alu.Sub8(AH, 0x10);
    // JNZ 0x3000:530c (334B_1E54 / 0x35304)
    if(!ZeroFlag) {
      goto label_334B_1E5C_3530C;
    }
    // CMP AL,0x8 (334B_1E56 / 0x35306)
    Alu.Sub8(AL, 0x8);
    // JNC 0x3000:530c (334B_1E58 / 0x35308)
    if(!CarryFlag) {
      goto label_334B_1E5C_3530C;
    }
    // ADD AL,0xc (334B_1E5A / 0x3530A)
    AL += 0xC;
    
    label_334B_1E5C_3530C:
    // ADD AL,0x10 (334B_1E5C / 0x3530C)
    // AL += 0x10;
    AL = Alu.Add8(AL, 0x10);
    // MOV DI,word ptr CS:[0x1cae] (334B_1E5E / 0x3530E)
    DI = UInt16[cs2, 0x1CAE];
    // STD  (334B_1E63 / 0x35313)
    DirectionFlag = true;
    // STOSB ES:DI (334B_1E64 / 0x35314)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CLD  (334B_1E65 / 0x35315)
    DirectionFlag = false;
    // MOV word ptr CS:[0x1cae],DI (334B_1E66 / 0x35316)
    UInt16[cs2, 0x1CAE] = DI;
    // MOV BP,DX (334B_1E6B / 0x3531B)
    BP = DX;
    // SUB BP,CX (334B_1E6D / 0x3531D)
    // BP -= CX;
    BP = Alu.Sub16(BP, CX);
    // JNS 0x3000:5323 (334B_1E6F / 0x3531F)
    if(!SignFlag) {
      goto label_334B_1E73_35323;
    }
    // ADD BP,CX (334B_1E71 / 0x35321)
    BP += CX;
    
    label_334B_1E73_35323:
    // ADD BP,BX (334B_1E73 / 0x35323)
    // BP += BX;
    BP = Alu.Add16(BP, BX);
    // MOV AL,byte ptr DS:[BP + SI] (334B_1E75 / 0x35325)
    AL = UInt8[DS, (ushort)(BP + SI)];
    // MOV AH,AL (334B_1E78 / 0x35328)
    AH = AL;
    // AND AX,0x300f (334B_1E7A / 0x3532A)
    AX &= 0x300F;
    
    // CMP AH,0x10 (334B_1E7D / 0x3532D)
    Alu.Sub8(AH, 0x10);
    // JNZ 0x3000:5338 (334B_1E80 / 0x35330)
    if(!ZeroFlag) {
      goto label_334B_1E88_35338;
    }
    // CMP AL,0x8 (334B_1E82 / 0x35332)
    Alu.Sub8(AL, 0x8);
    // JNC 0x3000:5338 (334B_1E84 / 0x35334)
    if(!CarryFlag) {
      goto label_334B_1E88_35338;
    }
    // ADD AL,0xc (334B_1E86 / 0x35336)
    AL += 0xC;
    
    label_334B_1E88_35338:
    // ADD AL,0x10 (334B_1E88 / 0x35338)
    // AL += 0x10;
    AL = Alu.Add8(AL, 0x10);
    // MOV DI,word ptr CS:[0x1cb0] (334B_1E8A / 0x3533A)
    DI = UInt16[cs2, 0x1CB0];
    // STOSB ES:DI (334B_1E8F / 0x3533F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV word ptr CS:[0x1cb0],DI (334B_1E90 / 0x35340)
    UInt16[cs2, 0x1CB0] = DI;
    // POP DI (334B_1E95 / 0x35345)
    DI = Stack.Pop();
    // POP SI (334B_1E96 / 0x35346)
    SI = Stack.Pop();
    // ADD SI,0xc8 (334B_1E97 / 0x35347)
    // SI += 0xC8;
    SI = Alu.Add16(SI, 0xC8);
    // MOV AL,byte ptr SS:[DI] (334B_1E9B / 0x3534B)
    AL = UInt8[SS, DI];
    // XOR AH,AH (334B_1E9E / 0x3534E)
    AH = 0;
    // INC DI (334B_1EA0 / 0x35350)
    DI = Alu.Inc16(DI);
    // OR AL,AL (334B_1EA1 / 0x35351)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x3000:5358 (334B_1EA3 / 0x35353)
    if(SignFlag) {
      goto label_334B_1EA8_35358;
    }
    label_334B_1EA5_35355:
    // JMP 0x3000:5235 (334B_1EA5 / 0x35355)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 334B_1D5A_3520A, 334B_1D27_351D7, 334B_1D5F_3520F
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_1D85_035235, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_334B_1EA8_35358:
    // MOV word ptr CS:[0x1ca6],DI (334B_1EA8 / 0x35358)
    UInt16[cs2, 0x1CA6] = DI;
    // MOV AX,CS:[0x1cb4] (334B_1EAD / 0x3535D)
    AX = UInt16[cs2, 0x1CB4];
    // ADD AX,word ptr CS:[0x1cb2] (334B_1EB1 / 0x35361)
    // AX += UInt16[cs2, 0x1CB2];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1CB2]);
    // MOV CS:[0x1cb2],AX (334B_1EB6 / 0x35366)
    UInt16[cs2, 0x1CB2] = AX;
    // MOV CS:[0x1cb0],AX (334B_1EBA / 0x3536A)
    UInt16[cs2, 0x1CB0] = AX;
    // DEC AX (334B_1EBE / 0x3536E)
    AX = Alu.Dec16(AX);
    // MOV CS:[0x1cae],AX (334B_1EBF / 0x3536F)
    UInt16[cs2, 0x1CAE] = AX;
    // CLC  (334B_1EC3 / 0x35373)
    CarryFlag = false;
    // MOV AX,SS (334B_1EC4 / 0x35374)
    AX = SS;
    // MOV DS,AX (334B_1EC6 / 0x35376)
    DS = AX;
    // RETF  (334B_1EC8 / 0x35378)
    return FarRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_1F4C_0353FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_1F4C_353FC:
    // MOV word ptr CS:[0x1a7],DI (334B_1F4C / 0x353FC)
    UInt16[cs2, 0x1A7] = DI;
    // MOV word ptr CS:[0x1a9],ES (334B_1F51 / 0x35401)
    UInt16[cs2, 0x1A9] = ES;
    // MOV word ptr CS:[0x1bb],BP (334B_1F56 / 0x35406)
    UInt16[cs2, 0x1BB] = BP;
    // MOV word ptr CS:[0x1a5],SI (334B_1F5B / 0x3540B)
    UInt16[cs2, 0x1A5] = SI;
    // MOV word ptr CS:[0x1b7],0x24 (334B_1F60 / 0x35410)
    UInt16[cs2, 0x1B7] = 0x24;
    // MOV word ptr CS:[0x1ab],BX (334B_1F67 / 0x35417)
    UInt16[cs2, 0x1AB] = BX;
    // MOV word ptr CS:[0x1cb2],0x504 (334B_1F6C / 0x3541C)
    UInt16[cs2, 0x1CB2] = 0x504;
    // SHL AX,0x1 (334B_1F73 / 0x35423)
    AX <<= 0x1;
    
    // SHL AX,0x1 (334B_1F75 / 0x35425)
    AX <<= 0x1;
    
    // SHL AX,0x1 (334B_1F77 / 0x35427)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // JNS 0x3000:5493 (334B_1F79 / 0x35429)
    if(!SignFlag) {
      goto label_334B_1FE3_35493;
    }
    // NEG AX (334B_1F7B / 0x3542B)
    AX = Alu.Sub16(0, AX);
    // ADD BP,AX (334B_1F7D / 0x3542D)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    // MOV CX,word ptr [BP + 0x0] (334B_1F7F / 0x3542F)
    CX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_1F82 / 0x35432)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // NEG CX (334B_1F85 / 0x35435)
    CX = Alu.Sub16(0, CX);
    // MOV DI,word ptr CS:[0x1a5] (334B_1F87 / 0x35437)
    DI = UInt16[cs2, 0x1A5];
    // MOV word ptr CS:[0x1b9],0x8f7 (334B_1F8C / 0x3543C)
    UInt16[cs2, 0x1B9] = 0x8F7;
    // ADD word ptr CS:[0x1bb],0x2b0 (334B_1F93 / 0x35443)
    UInt16[cs2, 0x1BB] += 0x2B0;
    
    // ADD DI,0x8c (334B_1F9A / 0x3544A)
    // DI += 0x8C;
    DI = Alu.Add16(DI, 0x8C);
    // CALL 0x3000:54d5 (334B_1F9E / 0x3544E)
    NearCall(cs2, 0x1FA1, spice86_generated_label_call_target_334B_2025_0354D5);
    label_334B_1FA1_35451:
    // SUB BP,0x8 (334B_1FA1 / 0x35451)
    // BP -= 0x8;
    BP = Alu.Sub16(BP, 0x8);
    // MOV CX,word ptr [BP + 0x0] (334B_1FA4 / 0x35454)
    CX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_1FA7 / 0x35457)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // NEG CX (334B_1FAA / 0x3545A)
    CX = Alu.Sub16(0, CX);
    // JZ 0x3000:5475 (334B_1FAC / 0x3545C)
    if(ZeroFlag) {
      goto label_334B_1FC5_35475;
    }
    // MOV DI,word ptr CS:[0x1a5] (334B_1FAE / 0x3545E)
    DI = UInt16[cs2, 0x1A5];
    // ADD DI,0x6cc (334B_1FB3 / 0x35463)
    // DI += 0x6CC;
    DI = Alu.Add16(DI, 0x6CC);
    // CALL 0x3000:54d5 (334B_1FB7 / 0x35467)
    NearCall(cs2, 0x1FBA, spice86_generated_label_call_target_334B_2025_0354D5);
    label_334B_1FBA_3546A:
    // CALL 0x3000:55d3 (334B_1FBA / 0x3546A)
    NearCall(cs2, 0x1FBD, spice86_generated_label_call_target_334B_2123_0355D3);
    label_334B_1FBD_3546D:
    // DEC word ptr CS:[0x1b7] (334B_1FBD / 0x3546D)
    UInt16[cs2, 0x1B7] = Alu.Dec16(UInt16[cs2, 0x1B7]);
    // JNZ 0x3000:5451 (334B_1FC2 / 0x35472)
    if(!ZeroFlag) {
      goto label_334B_1FA1_35451;
    }
    // RETF  (334B_1FC4 / 0x35474)
    return FarRet();
    label_334B_1FC5_35475:
    // MOV DI,word ptr CS:[0x1a5] (334B_1FC5 / 0x35475)
    DI = UInt16[cs2, 0x1A5];
    // MOV word ptr CS:[0x1b9],0x92f (334B_1FCA / 0x3547A)
    UInt16[cs2, 0x1B9] = 0x92F;
    // ADD word ptr CS:[0x1bb],0x8 (334B_1FD1 / 0x35481)
    UInt16[cs2, 0x1BB] += 0x8;
    
    // ADD DI,0x6cc (334B_1FD7 / 0x35487)
    // DI += 0x6CC;
    DI = Alu.Add16(DI, 0x6CC);
    // CALL 0x3000:54d5 (334B_1FDB / 0x3548B)
    NearCall(cs2, 0x1FDE, spice86_generated_label_call_target_334B_2025_0354D5);
    label_334B_1FDE_3548E:
    // CALL 0x3000:55d3 (334B_1FDE / 0x3548E)
    NearCall(cs2, 0x1FE1, spice86_generated_label_call_target_334B_2123_0355D3);
    label_334B_1FE1_35491:
    // JMP 0x3000:54cd (334B_1FE1 / 0x35491)
    goto label_334B_201D_354CD;
    label_334B_1FE3_35493:
    // ADD BP,AX (334B_1FE3 / 0x35493)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    // MOV CX,word ptr [BP + 0x0] (334B_1FE5 / 0x35495)
    CX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_1FE8 / 0x35498)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DI,word ptr CS:[0x1a5] (334B_1FEB / 0x3549B)
    DI = UInt16[cs2, 0x1A5];
    // MOV word ptr CS:[0x1b9],0x92f (334B_1FF0 / 0x354A0)
    UInt16[cs2, 0x1B9] = 0x92F;
    // ADD word ptr CS:[0x1bb],0x2b8 (334B_1FF7 / 0x354A7)
    UInt16[cs2, 0x1BB] += 0x2B8;
    
    // ADD DI,0x8c (334B_1FFE / 0x354AE)
    // DI += 0x8C;
    DI = Alu.Add16(DI, 0x8C);
    // CALL 0x3000:54d5 (334B_2002 / 0x354B2)
    NearCall(cs2, 0x2005, spice86_generated_label_call_target_334B_2025_0354D5);
    label_334B_2005_354B5:
    // ADD BP,0x8 (334B_2005 / 0x354B5)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    // MOV CX,word ptr [BP + 0x0] (334B_2008 / 0x354B8)
    CX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (334B_200B / 0x354BB)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DI,word ptr CS:[0x1a5] (334B_200E / 0x354BE)
    DI = UInt16[cs2, 0x1A5];
    // ADD DI,0x6cc (334B_2013 / 0x354C3)
    // DI += 0x6CC;
    DI = Alu.Add16(DI, 0x6CC);
    // CALL 0x3000:54d5 (334B_2017 / 0x354C7)
    NearCall(cs2, 0x201A, spice86_generated_label_call_target_334B_2025_0354D5);
    label_334B_201A_354CA:
    // CALL 0x3000:5603 (334B_201A / 0x354CA)
    NearCall(cs2, 0x201D, spice86_generated_label_call_target_334B_2153_035603);
    label_334B_201D_354CD:
    // DEC word ptr CS:[0x1b7] (334B_201D / 0x354CD)
    UInt16[cs2, 0x1B7] = Alu.Dec16(UInt16[cs2, 0x1B7]);
    // JNZ 0x3000:54b5 (334B_2022 / 0x354D2)
    if(!ZeroFlag) {
      goto label_334B_2005_354B5;
    }
    // RETF  (334B_2024 / 0x354D4)
    return FarRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2025_0354D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2025_354D5:
    // PUSH DX (334B_2025 / 0x354D5)
    Stack.Push(DX);
    // PUSH DS (334B_2026 / 0x354D6)
    Stack.Push(DS);
    // LDS SI,CS:[0x1a7] (334B_2027 / 0x354D7)
    DS = UInt16[cs2, 0x1A9];
    SI = UInt16[cs2, 0x1A7];
    // MOV AX,SS (334B_202C / 0x354DC)
    AX = SS;
    // MOV ES,AX (334B_202E / 0x354DE)
    ES = AX;
    // ADD SI,CX (334B_2030 / 0x354E0)
    SI += CX;
    
    // ADD BX,BX (334B_2032 / 0x354E2)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    // MOV AX,DX (334B_2034 / 0x354E4)
    AX = DX;
    // MUL BX (334B_2036 / 0x354E6)
    Cpu.Mul16(BX);
    // MOV word ptr [BP + 0x4],DX (334B_2038 / 0x354E8)
    UInt16[SS, (ushort)(BP + 0x4)] = DX;
    // ROL AX,0x1 (334B_203B / 0x354EB)
    AX = Alu.Rol16(AX, 0x1);
    // ROL AX,0x1 (334B_203D / 0x354ED)
    AX = Alu.Rol16(AX, 0x1);
    // AND AX,0x3 (334B_203F / 0x354EF)
    AX &= 0x3;
    
    // SUB DI,AX (334B_2042 / 0x354F2)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    // MOV AX,DX (334B_2044 / 0x354F4)
    AX = DX;
    // MOV CX,0x58 (334B_2046 / 0x354F6)
    CX = 0x58;
    // CMP BX,CX (334B_2049 / 0x354F9)
    Alu.Sub16(BX, CX);
    // JNC 0x3000:5529 (334B_204B / 0x354FB)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_2079_035529, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // SUB CX,BX (334B_204D / 0x354FD)
    CX -= BX;
    
    // SHL CX,0x1 (334B_204F / 0x354FF)
    CX <<= 0x1;
    
    // ADD DI,CX (334B_2051 / 0x35501)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    // MOV CX,BX (334B_2053 / 0x35503)
    CX = BX;
    // SHR CX,0x1 (334B_2055 / 0x35505)
    CX >>= 0x1;
    
    // SUB AX,CX (334B_2057 / 0x35507)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // JNS 0x3000:550d (334B_2059 / 0x35509)
    if(!SignFlag) {
      goto label_334B_205D_3550D;
    }
    // ADD AX,BX (334B_205B / 0x3550B)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    label_334B_205D_3550D:
    // MOV CX,BX (334B_205D / 0x3550D)
    CX = BX;
    // SUB BX,AX (334B_205F / 0x3550F)
    BX -= AX;
    
    // INC CX (334B_2061 / 0x35511)
    CX = Alu.Inc16(CX);
    // SUB CX,BX (334B_2062 / 0x35512)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    // JNS 0x3000:554e (334B_2064 / 0x35514)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_209E_03554E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD CX,BX (334B_2066 / 0x35516)
    CX += BX;
    
    // ADD SI,AX (334B_2068 / 0x35518)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AL,byte ptr [SI + -0x1] (334B_206A / 0x3551A)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    // STC  (334B_206D / 0x3551D)
    CarryFlag = true;
    // ADC AL,AL (334B_206E / 0x3551E)
    AL = Alu.Adc8(AL, AL);
    // ADD AL,AL (334B_2070 / 0x35520)
    AL += AL;
    
    // SHL AL,0x1 (334B_2072 / 0x35522)
    AL <<= 0x1;
    
    // SHL AL,0x1 (334B_2074 / 0x35524)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JMP 0x3000:559b (334B_2076 / 0x35526)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_334B_209E_03554E, 0x3559B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_334B_2079_035529(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2079_35529:
    // SHR CX,0x1 (334B_2079 / 0x35529)
    CX >>= 0x1;
    
    // SUB AX,CX (334B_207B / 0x3552B)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // JNS 0x3000:5531 (334B_207D / 0x3552D)
    if(!SignFlag) {
      goto label_334B_2081_35531;
    }
    // ADD AX,BX (334B_207F / 0x3552F)
    AX += BX;
    
    label_334B_2081_35531:
    // SUB BX,AX (334B_2081 / 0x35531)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // MOV CX,0x58 (334B_2083 / 0x35533)
    CX = 0x58;
    // INC CX (334B_2086 / 0x35536)
    CX = Alu.Inc16(CX);
    // SUB CX,BX (334B_2087 / 0x35537)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    // JNS 0x3000:554e (334B_2089 / 0x35539)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_209E_03554E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // ADD CX,BX (334B_208B / 0x3553B)
    CX += BX;
    
    // ADD SI,AX (334B_208D / 0x3553D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AL,byte ptr [SI + -0x1] (334B_208F / 0x3553F)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    // STC  (334B_2092 / 0x35542)
    CarryFlag = true;
    // ADC AL,AL (334B_2093 / 0x35543)
    AL = Alu.Adc8(AL, AL);
    // ADD AL,AL (334B_2095 / 0x35545)
    AL += AL;
    
    // SHL AL,0x1 (334B_2097 / 0x35547)
    AL <<= 0x1;
    
    // SHL AL,0x1 (334B_2099 / 0x35549)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JMP 0x3000:559b (334B_209B / 0x3554B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_334B_209E_03554E, 0x3559B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_334B_209E_03554E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_209E_3554E:
    // OR BX,BX (334B_209E / 0x3554E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x3000:559b (334B_20A0 / 0x35550)
    if(ZeroFlag) {
      goto label_334B_20EB_3559B;
    }
    // XCHG BX,CX (334B_20A2 / 0x35552)
    ushort tmp_334B_20A2 = BX;
    BX = CX;
    CX = tmp_334B_20A2;
    // PUSH SI (334B_20A4 / 0x35554)
    Stack.Push(SI);
    // ADD SI,AX (334B_20A5 / 0x35555)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AL,byte ptr [SI + -0x1] (334B_20A7 / 0x35557)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    // STC  (334B_20AA / 0x3555A)
    CarryFlag = true;
    // ADC AL,AL (334B_20AB / 0x3555B)
    AL = Alu.Adc8(AL, AL);
    // ADD AL,AL (334B_20AD / 0x3555D)
    AL += AL;
    
    // SHL AL,0x1 (334B_20AF / 0x3555F)
    AL <<= 0x1;
    
    // SHL AL,0x1 (334B_20B1 / 0x35561)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    label_334B_20B3_35563:
    // MOV DH,byte ptr [SI] (334B_20B3 / 0x35563)
    DH = UInt8[DS, SI];
    // INC SI (334B_20B5 / 0x35565)
    SI = Alu.Inc16(SI);
    // STC  (334B_20B6 / 0x35566)
    CarryFlag = true;
    // ADC DH,DH (334B_20B7 / 0x35567)
    DH = Alu.Adc8(DH, DH);
    // ADD DH,DH (334B_20B9 / 0x35569)
    DH += DH;
    
    // SHL DH,0x1 (334B_20BB / 0x3556B)
    DH <<= 0x1;
    
    // SHL DH,0x1 (334B_20BD / 0x3556D)
    // DH <<= 0x1;
    DH = Alu.Shl8(DH, 0x1);
    // MOV DL,DH (334B_20BF / 0x3556F)
    DL = DH;
    // SUB DL,AL (334B_20C1 / 0x35571)
    DL -= AL;
    
    // SAR DL,0x1 (334B_20C3 / 0x35573)
    DL = Alu.Sar8(DL, 0x1);
    // SAR DL,0x1 (334B_20C5 / 0x35575)
    DL = Alu.Sar8(DL, 0x1);
    // OR DL,DL (334B_20C7 / 0x35577)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x3000:5590 (334B_20C9 / 0x35579)
    if(ZeroFlag) {
      goto label_334B_20E0_35590;
    }
    // MOV AH,AL (334B_20CB / 0x3557B)
    AH = AL;
    // ADD AH,DL (334B_20CD / 0x3557D)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    // STOSW ES:DI (334B_20CF / 0x3557F)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD AH,DL (334B_20D0 / 0x35580)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    // MOV AL,AH (334B_20D2 / 0x35582)
    AL = AH;
    // ADD AH,DL (334B_20D4 / 0x35584)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    // STOSW ES:DI (334B_20D6 / 0x35586)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,DH (334B_20D7 / 0x35587)
    AL = DH;
    // LOOP 0x3000:5563 (334B_20D9 / 0x35589)
    if(--CX != 0) {
      goto label_334B_20B3_35563;
    }
    // MOV CX,BX (334B_20DB / 0x3558B)
    CX = BX;
    // POP SI (334B_20DD / 0x3558D)
    SI = Stack.Pop();
    // JMP 0x3000:559b (334B_20DE / 0x3558E)
    goto label_334B_20EB_3559B;
    label_334B_20E0_35590:
    // MOV AH,AL (334B_20E0 / 0x35590)
    AH = AL;
    // STOSW ES:DI (334B_20E2 / 0x35592)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (334B_20E3 / 0x35593)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,DH (334B_20E4 / 0x35594)
    AL = DH;
    // LOOP 0x3000:5563 (334B_20E6 / 0x35596)
    if(--CX != 0) {
      goto label_334B_20B3_35563;
    }
    // MOV CX,BX (334B_20E8 / 0x35598)
    CX = BX;
    // POP SI (334B_20EA / 0x3559A)
    SI = Stack.Pop();
    label_334B_20EB_3559B:
    // JCXZ 0x3000:55c5 (334B_20EB / 0x3559B)
    if(CX == 0) {
      goto label_334B_2115_355C5;
    }
    label_334B_20ED_3559D:
    // MOV DH,byte ptr [SI] (334B_20ED / 0x3559D)
    DH = UInt8[DS, SI];
    // INC SI (334B_20EF / 0x3559F)
    SI = Alu.Inc16(SI);
    // STC  (334B_20F0 / 0x355A0)
    CarryFlag = true;
    // ADC DH,DH (334B_20F1 / 0x355A1)
    DH = Alu.Adc8(DH, DH);
    // ADD DH,DH (334B_20F3 / 0x355A3)
    DH += DH;
    
    // SHL DH,0x1 (334B_20F5 / 0x355A5)
    DH <<= 0x1;
    
    // SHL DH,0x1 (334B_20F7 / 0x355A7)
    // DH <<= 0x1;
    DH = Alu.Shl8(DH, 0x1);
    // MOV DL,DH (334B_20F9 / 0x355A9)
    DL = DH;
    // SUB DL,AL (334B_20FB / 0x355AB)
    DL -= AL;
    
    // SAR DL,0x1 (334B_20FD / 0x355AD)
    DL = Alu.Sar8(DL, 0x1);
    // SAR DL,0x1 (334B_20FF / 0x355AF)
    DL = Alu.Sar8(DL, 0x1);
    // OR DL,DL (334B_2101 / 0x355B1)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x3000:55c8 (334B_2103 / 0x355B3)
    if(ZeroFlag) {
      goto label_334B_2118_355C8;
    }
    // MOV AH,AL (334B_2105 / 0x355B5)
    AH = AL;
    // ADD AH,DL (334B_2107 / 0x355B7)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    // STOSW ES:DI (334B_2109 / 0x355B9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD AH,DL (334B_210A / 0x355BA)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    // MOV AL,AH (334B_210C / 0x355BC)
    AL = AH;
    // ADD AH,DL (334B_210E / 0x355BE)
    // AH += DL;
    AH = Alu.Add8(AH, DL);
    // STOSW ES:DI (334B_2110 / 0x355C0)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,DH (334B_2111 / 0x355C1)
    AL = DH;
    // LOOP 0x3000:559d (334B_2113 / 0x355C3)
    if(--CX != 0) {
      goto label_334B_20ED_3559D;
    }
    label_334B_2115_355C5:
    // POP DS (334B_2115 / 0x355C5)
    DS = Stack.Pop();
    // POP DX (334B_2116 / 0x355C6)
    DX = Stack.Pop();
    // RET  (334B_2117 / 0x355C7)
    return NearRet();
    label_334B_2118_355C8:
    // MOV AH,AL (334B_2118 / 0x355C8)
    AH = AL;
    // STOSW ES:DI (334B_211A / 0x355CA)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (334B_211B / 0x355CB)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,DH (334B_211C / 0x355CC)
    AL = DH;
    // LOOP 0x3000:559d (334B_211E / 0x355CE)
    if(--CX != 0) {
      goto label_334B_20ED_3559D;
    }
    // POP DS (334B_2120 / 0x355D0)
    DS = Stack.Pop();
    // POP DX (334B_2121 / 0x355D1)
    DX = Stack.Pop();
    // RET  (334B_2122 / 0x355D2)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2123_0355D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2123_355D3:
    // PUSH DX (334B_2123 / 0x355D3)
    Stack.Push(DX);
    // PUSH BP (334B_2124 / 0x355D4)
    Stack.Push(BP);
    // MOV CX,word ptr [BP + 0xa] (334B_2125 / 0x355D5)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    // MOV DX,word ptr [BP + 0x2] (334B_2128 / 0x355D8)
    DX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DI,word ptr CS:[0x1a5] (334B_212B / 0x355DB)
    DI = UInt16[cs2, 0x1A5];
    // ADD DI,0x13c (334B_2130 / 0x355E0)
    // DI += 0x13C;
    DI = Alu.Add16(DI, 0x13C);
    // MOV word ptr CS:[0x1b3],0xb0 (334B_2134 / 0x355E4)
    UInt16[cs2, 0x1B3] = 0xB0;
    // MOV SI,DI (334B_213B / 0x355EB)
    SI = DI;
    // MOV AX,0x190 (334B_213D / 0x355ED)
    AX = 0x190;
    // ADD DI,AX (334B_2140 / 0x355F0)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV BP,DI (334B_2142 / 0x355F2)
    BP = DI;
    // ADD DI,AX (334B_2144 / 0x355F4)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV BX,DI (334B_2146 / 0x355F6)
    BX = DI;
    // ADD DI,AX (334B_2148 / 0x355F8)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV word ptr CS:[0x1b5],DI (334B_214A / 0x355FA)
    UInt16[cs2, 0x1B5] = DI;
    // ADD DI,AX (334B_214F / 0x355FF)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // JMP 0x3000:5633 (334B_2151 / 0x35601)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_2183_035633, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_334B_2153_035603(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2153_35603:
    // PUSH DX (334B_2153 / 0x35603)
    Stack.Push(DX);
    // PUSH BP (334B_2154 / 0x35604)
    Stack.Push(BP);
    // MOV CX,word ptr [BP + 0x2] (334B_2155 / 0x35605)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV DX,word ptr [BP + -0x6] (334B_2158 / 0x35608)
    DX = UInt16[SS, (ushort)(BP - 0x6)];
    // MOV DI,word ptr CS:[0x1a5] (334B_215B / 0x3560B)
    DI = UInt16[cs2, 0x1A5];
    // ADD DI,0x13c (334B_2160 / 0x35610)
    // DI += 0x13C;
    DI = Alu.Add16(DI, 0x13C);
    // MOV word ptr CS:[0x1b3],0xb0 (334B_2164 / 0x35614)
    UInt16[cs2, 0x1B3] = 0xB0;
    // PUSH DI (334B_216B / 0x3561B)
    Stack.Push(DI);
    // MOV AX,0x190 (334B_216C / 0x3561C)
    AX = 0x190;
    // ADD DI,AX (334B_216F / 0x3561F)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV word ptr CS:[0x1b5],DI (334B_2171 / 0x35621)
    UInt16[cs2, 0x1B5] = DI;
    // ADD DI,AX (334B_2176 / 0x35626)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV BX,DI (334B_2178 / 0x35628)
    BX = DI;
    // ADD DI,AX (334B_217A / 0x3562A)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV BP,DI (334B_217C / 0x3562C)
    BP = DI;
    // ADD DI,AX (334B_217E / 0x3562E)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV SI,DI (334B_2180 / 0x35630)
    SI = DI;
    // POP DI (334B_2182 / 0x35632)
    DI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_334B_2183_035633, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_334B_2183_035633(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2183_35633:
    // PUSH word ptr CS:[0x1b3] (334B_2183 / 0x35633)
    Stack.Push(UInt16[cs2, 0x1B3]);
    // PUSH DI (334B_2188 / 0x35638)
    Stack.Push(DI);
    // PUSH word ptr CS:[0x1b5] (334B_2189 / 0x35639)
    Stack.Push(UInt16[cs2, 0x1B5]);
    // PUSH BX (334B_218E / 0x3563E)
    Stack.Push(BX);
    // PUSH BP (334B_218F / 0x3563F)
    Stack.Push(BP);
    // PUSH SI (334B_2190 / 0x35640)
    Stack.Push(SI);
    // SUB DX,CX (334B_2191 / 0x35641)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    // MOV AX,DS (334B_2193 / 0x35643)
    AX = DS;
    // MOV ES,AX (334B_2195 / 0x35645)
    ES = AX;
    // XOR AX,AX (334B_2197 / 0x35647)
    AX = 0;
    // DIV CX (334B_2199 / 0x35649)
    Cpu.Div16(CX);
    // MOV CS:[0x1ad],AX (334B_219B / 0x3564B)
    UInt16[cs2, 0x1AD] = AX;
    // MOV CS:[0x1af],AX (334B_219F / 0x3564F)
    UInt16[cs2, 0x1AF] = AX;
    // SHR AX,0x1 (334B_21A3 / 0x35653)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV DX,AX (334B_21A5 / 0x35655)
    DX = AX;
    // SHR AX,0x1 (334B_21A7 / 0x35657)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV CX,DX (334B_21A9 / 0x35659)
    CX = DX;
    // ADD CX,AX (334B_21AB / 0x3565B)
    CX += AX;
    
    // ADD AX,0x80 (334B_21AD / 0x3565D)
    AX += 0x80;
    
    // ADD CX,0x80 (334B_21B0 / 0x35660)
    CX += 0x80;
    
    // ADD DX,0x80 (334B_21B4 / 0x35664)
    // DX += 0x80;
    DX = Alu.Add16(DX, 0x80);
    // MOV CL,CH (334B_21B8 / 0x35668)
    CL = CH;
    // MOV CH,AH (334B_21BA / 0x3566A)
    CH = AH;
    // MOV DL,DH (334B_21BC / 0x3566C)
    DL = DH;
    // MOV word ptr CS:[0x1b1],CX (334B_21BE / 0x3566E)
    UInt16[cs2, 0x1B1] = CX;
    label_334B_21C3_35673:
    // LODSB SI (334B_21C3 / 0x35673)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV AH,byte ptr [DI] (334B_21C4 / 0x35674)
    AH = UInt8[DS, DI];
    // INC DI (334B_21C6 / 0x35676)
    DI = Alu.Inc16(DI);
    // SUB AH,AL (334B_21C7 / 0x35677)
    AH -= AL;
    
    // SAR AH,0x1 (334B_21C9 / 0x35679)
    AH = Alu.Sar8(AH, 0x1);
    // SAR AH,0x1 (334B_21CB / 0x3567B)
    AH = Alu.Sar8(AH, 0x1);
    // ADD AL,AH (334B_21CD / 0x3567D)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    // MOV byte ptr [BP + 0x0],AL (334B_21CF / 0x3567F)
    UInt8[SS, BP] = AL;
    // INC BP (334B_21D2 / 0x35682)
    BP = Alu.Inc16(BP);
    // ADD CH,byte ptr CS:[0x1b2] (334B_21D3 / 0x35683)
    // CH += UInt8[cs2, 0x1B2];
    CH = Alu.Add8(CH, UInt8[cs2, 0x1B2]);
    // JC 0x3000:56bb (334B_21D8 / 0x35688)
    if(CarryFlag) {
      goto label_334B_220B_356BB;
    }
    label_334B_21DA_3568A:
    // ADD AL,AH (334B_21DA / 0x3568A)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    // MOV byte ptr [BX],AL (334B_21DC / 0x3568C)
    UInt8[DS, BX] = AL;
    // INC BX (334B_21DE / 0x3568E)
    BX = Alu.Inc16(BX);
    // ADD DL,DH (334B_21DF / 0x3568F)
    // DL += DH;
    DL = Alu.Add8(DL, DH);
    // JC 0x3000:56c1 (334B_21E1 / 0x35691)
    if(CarryFlag) {
      goto label_334B_2211_356C1;
    }
    label_334B_21E3_35693:
    // ADD AL,AH (334B_21E3 / 0x35693)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    // XCHG word ptr CS:[0x1b5],DI (334B_21E5 / 0x35695)
    ushort tmp_334B_21E5 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_21E5;
    // STOSB ES:DI (334B_21EA / 0x3569A)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD CL,byte ptr CS:[0x1b1] (334B_21EB / 0x3569B)
    // CL += UInt8[cs2, 0x1B1];
    CL = Alu.Add8(CL, UInt8[cs2, 0x1B1]);
    // JC 0x3000:56c6 (334B_21F0 / 0x356A0)
    if(CarryFlag) {
      goto label_334B_2216_356C6;
    }
    label_334B_21F2_356A2:
    // XCHG word ptr CS:[0x1b5],DI (334B_21F2 / 0x356A2)
    ushort tmp_334B_21F2 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_21F2;
    // MOV AX,CS:[0x1ad] (334B_21F7 / 0x356A7)
    AX = UInt16[cs2, 0x1AD];
    // ADD word ptr CS:[0x1af],AX (334B_21FB / 0x356AB)
    // UInt16[cs2, 0x1AF] += AX;
    UInt16[cs2, 0x1AF] = Alu.Add16(UInt16[cs2, 0x1AF], AX);
    // JC 0x3000:56c9 (334B_2200 / 0x356B0)
    if(CarryFlag) {
      goto label_334B_2219_356C9;
    }
    // DEC word ptr CS:[0x1b3] (334B_2202 / 0x356B2)
    UInt16[cs2, 0x1B3] = Alu.Dec16(UInt16[cs2, 0x1B3]);
    // JNZ 0x3000:5673 (334B_2207 / 0x356B7)
    if(!ZeroFlag) {
      goto label_334B_21C3_35673;
    }
    // JMP 0x3000:56d1 (334B_2209 / 0x356B9)
    goto label_334B_2221_356D1;
    label_334B_220B_356BB:
    // MOV byte ptr [BP + 0x0],AL (334B_220B / 0x356BB)
    UInt8[SS, BP] = AL;
    // INC BP (334B_220E / 0x356BE)
    BP = Alu.Inc16(BP);
    // JMP 0x3000:568a (334B_220F / 0x356BF)
    goto label_334B_21DA_3568A;
    label_334B_2211_356C1:
    // MOV byte ptr [BX],AL (334B_2211 / 0x356C1)
    UInt8[DS, BX] = AL;
    // INC BX (334B_2213 / 0x356C3)
    BX = Alu.Inc16(BX);
    // JMP 0x3000:5693 (334B_2214 / 0x356C4)
    goto label_334B_21E3_35693;
    label_334B_2216_356C6:
    // STOSB ES:DI (334B_2216 / 0x356C6)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // JMP 0x3000:56a2 (334B_2217 / 0x356C7)
    goto label_334B_21F2_356A2;
    label_334B_2219_356C9:
    // INC DI (334B_2219 / 0x356C9)
    DI = Alu.Inc16(DI);
    // DEC word ptr CS:[0x1b3] (334B_221A / 0x356CA)
    UInt16[cs2, 0x1B3] = Alu.Dec16(UInt16[cs2, 0x1B3]);
    // JNZ 0x3000:5673 (334B_221F / 0x356CF)
    if(!ZeroFlag) {
      goto label_334B_21C3_35673;
    }
    label_334B_2221_356D1:
    // POP SI (334B_2221 / 0x356D1)
    SI = Stack.Pop();
    // POP BP (334B_2222 / 0x356D2)
    BP = Stack.Pop();
    // POP BX (334B_2223 / 0x356D3)
    BX = Stack.Pop();
    // POP word ptr CS:[0x1b5] (334B_2224 / 0x356D4)
    UInt16[cs2, 0x1B5] = Stack.Pop();
    // POP DI (334B_2229 / 0x356D9)
    DI = Stack.Pop();
    // POP word ptr CS:[0x1b3] (334B_222A / 0x356DA)
    UInt16[cs2, 0x1B3] = Stack.Pop();
    // MOV CX,word ptr CS:[0x1b1] (334B_222F / 0x356DF)
    CX = UInt16[cs2, 0x1B1];
    // MOV DL,DH (334B_2234 / 0x356E4)
    DL = DH;
    // MOV AX,CS:[0x1ad] (334B_2236 / 0x356E6)
    AX = UInt16[cs2, 0x1AD];
    // MOV CS:[0x1af],AX (334B_223A / 0x356EA)
    UInt16[cs2, 0x1AF] = AX;
    // DEC SI (334B_223E / 0x356EE)
    SI = Alu.Dec16(SI);
    // DEC DI (334B_223F / 0x356EF)
    DI = Alu.Dec16(DI);
    // DEC word ptr CS:[0x1b5] (334B_2240 / 0x356F0)
    UInt16[cs2, 0x1B5] = Alu.Dec16(UInt16[cs2, 0x1B5]);
    // STD  (334B_2245 / 0x356F5)
    DirectionFlag = true;
    label_334B_2246_356F6:
    // LODSB SI (334B_2246 / 0x356F6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV AH,byte ptr [DI] (334B_2247 / 0x356F7)
    AH = UInt8[DS, DI];
    // DEC DI (334B_2249 / 0x356F9)
    DI = Alu.Dec16(DI);
    // SUB AH,AL (334B_224A / 0x356FA)
    AH -= AL;
    
    // SAR AH,0x1 (334B_224C / 0x356FC)
    AH = Alu.Sar8(AH, 0x1);
    // SAR AH,0x1 (334B_224E / 0x356FE)
    AH = Alu.Sar8(AH, 0x1);
    // ADD AL,AH (334B_2250 / 0x35700)
    AL += AH;
    
    // DEC BP (334B_2252 / 0x35702)
    BP = Alu.Dec16(BP);
    // MOV byte ptr [BP + 0x0],AL (334B_2253 / 0x35703)
    UInt8[SS, BP] = AL;
    // ADD CH,byte ptr CS:[0x1b2] (334B_2256 / 0x35706)
    // CH += UInt8[cs2, 0x1B2];
    CH = Alu.Add8(CH, UInt8[cs2, 0x1B2]);
    // JC 0x3000:573f (334B_225B / 0x3570B)
    if(CarryFlag) {
      goto label_334B_228F_3573F;
    }
    label_334B_225D_3570D:
    // ADD AL,AH (334B_225D / 0x3570D)
    AL += AH;
    
    // DEC BX (334B_225F / 0x3570F)
    BX = Alu.Dec16(BX);
    // MOV byte ptr [BX],AL (334B_2260 / 0x35710)
    UInt8[DS, BX] = AL;
    // ADD DL,DH (334B_2262 / 0x35712)
    // DL += DH;
    DL = Alu.Add8(DL, DH);
    // JC 0x3000:5745 (334B_2264 / 0x35714)
    if(CarryFlag) {
      goto label_334B_2295_35745;
    }
    label_334B_2266_35716:
    // ADD AL,AH (334B_2266 / 0x35716)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    // XCHG word ptr CS:[0x1b5],DI (334B_2268 / 0x35718)
    ushort tmp_334B_2268 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_2268;
    // STOSB ES:DI (334B_226D / 0x3571D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD CL,byte ptr CS:[0x1b1] (334B_226E / 0x3571E)
    // CL += UInt8[cs2, 0x1B1];
    CL = Alu.Add8(CL, UInt8[cs2, 0x1B1]);
    // JC 0x3000:574a (334B_2273 / 0x35723)
    if(CarryFlag) {
      goto label_334B_229A_3574A;
    }
    label_334B_2275_35725:
    // XCHG word ptr CS:[0x1b5],DI (334B_2275 / 0x35725)
    ushort tmp_334B_2275 = UInt16[cs2, 0x1B5];
    UInt16[cs2, 0x1B5] = DI;
    DI = tmp_334B_2275;
    // MOV AX,CS:[0x1ad] (334B_227A / 0x3572A)
    AX = UInt16[cs2, 0x1AD];
    // ADD word ptr CS:[0x1af],AX (334B_227E / 0x3572E)
    // UInt16[cs2, 0x1AF] += AX;
    UInt16[cs2, 0x1AF] = Alu.Add16(UInt16[cs2, 0x1AF], AX);
    // JC 0x3000:574d (334B_2283 / 0x35733)
    if(CarryFlag) {
      goto label_334B_229D_3574D;
    }
    label_334B_2285_35735:
    // DEC word ptr CS:[0x1b3] (334B_2285 / 0x35735)
    UInt16[cs2, 0x1B3] = Alu.Dec16(UInt16[cs2, 0x1B3]);
    // JNZ 0x3000:56f6 (334B_228A / 0x3573A)
    if(!ZeroFlag) {
      goto label_334B_2246_356F6;
    }
    // CLD  (334B_228C / 0x3573C)
    DirectionFlag = false;
    // JMP 0x3000:5750 (334B_228D / 0x3573D)
    goto label_334B_22A0_35750;
    label_334B_228F_3573F:
    // DEC BP (334B_228F / 0x3573F)
    BP = Alu.Dec16(BP);
    // MOV byte ptr [BP + 0x0],AL (334B_2290 / 0x35740)
    UInt8[SS, BP] = AL;
    // JMP 0x3000:570d (334B_2293 / 0x35743)
    goto label_334B_225D_3570D;
    label_334B_2295_35745:
    // DEC BX (334B_2295 / 0x35745)
    BX = Alu.Dec16(BX);
    // MOV byte ptr [BX],AL (334B_2296 / 0x35746)
    UInt8[DS, BX] = AL;
    // JMP 0x3000:5716 (334B_2298 / 0x35748)
    goto label_334B_2266_35716;
    label_334B_229A_3574A:
    // STOSB ES:DI (334B_229A / 0x3574A)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // JMP 0x3000:5725 (334B_229B / 0x3574B)
    goto label_334B_2275_35725;
    label_334B_229D_3574D:
    // DEC DI (334B_229D / 0x3574D)
    DI = Alu.Dec16(DI);
    // JMP 0x3000:5735 (334B_229E / 0x3574E)
    goto label_334B_2285_35735;
    label_334B_22A0_35750:
    // POP BP (334B_22A0 / 0x35750)
    BP = Stack.Pop();
    // PUSH BP (334B_22A1 / 0x35751)
    Stack.Push(BP);
    // SUB BP,word ptr CS:[0x1bb] (334B_22A2 / 0x35752)
    // BP -= UInt16[cs2, 0x1BB];
    BP = Alu.Sub16(BP, UInt16[cs2, 0x1BB]);
    // JC 0x3000:57ba (334B_22A7 / 0x35757)
    if(CarryFlag) {
      goto label_334B_230A_357BA;
    }
    // MOV AX,CS (334B_22A9 / 0x35759)
    AX = cs2;
    // MOV DS,AX (334B_22AB / 0x3575B)
    DS = AX;
    // ADD BP,word ptr CS:[0x1b9] (334B_22AD / 0x3575D)
    // BP += UInt16[cs2, 0x1B9];
    BP = Alu.Add16(BP, UInt16[cs2, 0x1B9]);
    // MOV DI,word ptr CS:[0x1a5] (334B_22B2 / 0x35762)
    DI = UInt16[cs2, 0x1A5];
    // ADD DI,0xa0 (334B_22B7 / 0x35767)
    DI += 0xA0;
    
    // XOR CH,CH (334B_22BB / 0x3576B)
    CH = 0;
    // XOR AL,AL (334B_22BD / 0x3576D)
    AL = 0;
    // MOV BL,0x4 (334B_22BF / 0x3576F)
    BL = 0x4;
    label_334B_22C1_35771:
    // MOV SI,0x8ef (334B_22C1 / 0x35771)
    SI = 0x8EF;
    // MOV CL,byte ptr CS:[BP + 0x0] (334B_22C4 / 0x35774)
    CL = UInt8[cs2, BP];
    // MOV BH,CL (334B_22C8 / 0x35778)
    BH = CL;
    // SUB CX,0x4 (334B_22CA / 0x3577A)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    // JA 0x3000:5789 (334B_22CD / 0x3577D)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_22D9_35789;
    }
    // NEG CX (334B_22CF / 0x3577F)
    CX = Alu.Sub16(0, CX);
    // ADD SI,CX (334B_22D1 / 0x35781)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    // MOV CL,BH (334B_22D3 / 0x35783)
    CL = BH;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_22D5 / 0x35785)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // JMP 0x3000:578f (334B_22D7 / 0x35787)
    goto label_334B_22DF_3578F;
    label_334B_22D9_35789:
    // XOR AL,AL (334B_22D9 / 0x35789)
    AL = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_22DB / 0x3578B)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOVSW ES:DI,SI (334B_22DD / 0x3578D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_22DE / 0x3578E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    label_334B_22DF_3578F:
    // MOV CL,byte ptr CS:[BP + 0x1] (334B_22DF / 0x3578F)
    CL = UInt8[cs2, (ushort)(BP + 0x1)];
    // ADD DI,CX (334B_22E3 / 0x35793)
    DI += CX;
    
    // ADD DI,CX (334B_22E5 / 0x35795)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    // MOV CL,BH (334B_22E7 / 0x35797)
    CL = BH;
    // SUB CX,0x4 (334B_22E9 / 0x35799)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    // JA 0x3000:57a6 (334B_22EC / 0x3579C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_22F6_357A6;
    }
    // MOV CL,BH (334B_22EE / 0x3579E)
    CL = BH;
    // XOR CH,CH (334B_22F0 / 0x357A0)
    CH = 0;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_22F2 / 0x357A2)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // JMP 0x3000:57ac (334B_22F4 / 0x357A4)
    goto label_334B_22FC_357AC;
    label_334B_22F6_357A6:
    // MOVSW ES:DI,SI (334B_22F6 / 0x357A6)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (334B_22F7 / 0x357A7)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // XOR AL,AL (334B_22F8 / 0x357A8)
    AL = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_22FA / 0x357AA)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    label_334B_22FC_357AC:
    // ADD DI,0x58 (334B_22FC / 0x357AC)
    DI += 0x58;
    
    // ADD BP,0x2 (334B_22FF / 0x357AF)
    BP += 0x2;
    
    // DEC BL (334B_2302 / 0x357B2)
    BL = Alu.Dec8(BL);
    // JNZ 0x3000:5771 (334B_2304 / 0x357B4)
    if(!ZeroFlag) {
      goto label_334B_22C1_35771;
    }
    // MOV AX,SS (334B_2306 / 0x357B6)
    AX = SS;
    // MOV DS,AX (334B_2308 / 0x357B8)
    DS = AX;
    label_334B_230A_357BA:
    // MOV ES,word ptr CS:[0x1ab] (334B_230A / 0x357BA)
    ES = UInt16[cs2, 0x1AB];
    // MOV CX,0x138 (334B_230F / 0x357BF)
    CX = 0x138;
    // MOV DI,word ptr CS:[0x1cb2] (334B_2312 / 0x357C2)
    DI = UInt16[cs2, 0x1CB2];
    // MOV SI,word ptr CS:[0x1a5] (334B_2317 / 0x357C7)
    SI = UInt16[cs2, 0x1A5];
    // ADD SI,0xa0 (334B_231C / 0x357CC)
    // SI += 0xA0;
    SI = Alu.Add16(SI, 0xA0);
    // CALL 0x3000:57f3 (334B_2320 / 0x357D0)
    NearCall(cs2, 0x2323, spice86_generated_label_call_target_334B_2343_0357F3);
    label_334B_2323_357D3:
    // MOV word ptr CS:[0x1cb2],DI (334B_2323 / 0x357D3)
    UInt16[cs2, 0x1CB2] = DI;
    // MOV AX,DS (334B_2328 / 0x357D8)
    AX = DS;
    // MOV ES,AX (334B_232A / 0x357DA)
    ES = AX;
    // MOV DI,word ptr CS:[0x1a5] (334B_232C / 0x357DC)
    DI = UInt16[cs2, 0x1A5];
    // ADD DI,0x8c (334B_2331 / 0x357E1)
    // DI += 0x8C;
    DI = Alu.Add16(DI, 0x8C);
    // MOV SI,DI (334B_2335 / 0x357E5)
    SI = DI;
    // ADD SI,0x640 (334B_2337 / 0x357E7)
    // SI += 0x640;
    SI = Alu.Add16(SI, 0x640);
    // MOV CX,0x15e (334B_233B / 0x357EB)
    CX = 0x15E;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_233E / 0x357EE)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // POP BP (334B_2340 / 0x357F0)
    BP = Stack.Pop();
    // POP DX (334B_2341 / 0x357F1)
    DX = Stack.Pop();
    // RET  (334B_2342 / 0x357F2)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2343_0357F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2343_357F3:
    // PUSH DX (334B_2343 / 0x357F3)
    Stack.Push(DX);
    // PUSH BP (334B_2344 / 0x357F4)
    Stack.Push(BP);
    // MOV BH,0x4 (334B_2345 / 0x357F5)
    BH = 0x4;
    // MOV BP,0xf0f (334B_2347 / 0x357F7)
    BP = 0xF0F;
    // MOV DX,0x1010 (334B_234A / 0x357FA)
    DX = 0x1010;
    label_334B_234D_357FD:
    // PUSH CX (334B_234D / 0x357FD)
    Stack.Push(CX);
    // SHR CX,0x1 (334B_234E / 0x357FE)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // JNC 0x3000:5810 (334B_2350 / 0x35800)
    if(!CarryFlag) {
      goto label_334B_2360_35810;
    }
    // LODSB SI (334B_2352 / 0x35802)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // SHR AL,0x1 (334B_2353 / 0x35803)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_2355 / 0x35805)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_2357 / 0x35807)
    AL >>= 0x1;
    
    // SHR AL,0x1 (334B_2359 / 0x35809)
    AL >>= 0x1;
    
    // AND AX,BP (334B_235B / 0x3580B)
    AX &= BP;
    
    // ADD AL,DL (334B_235D / 0x3580D)
    // AL += DL;
    AL = Alu.Add8(AL, DL);
    // STOSB ES:DI (334B_235F / 0x3580F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_334B_2360_35810:
    // LODSW SI (334B_2360 / 0x35810)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SHR AX,0x1 (334B_2361 / 0x35811)
    AX >>= 0x1;
    
    // SHR AX,0x1 (334B_2363 / 0x35813)
    AX >>= 0x1;
    
    // SHR AX,0x1 (334B_2365 / 0x35815)
    AX >>= 0x1;
    
    // SHR AX,0x1 (334B_2367 / 0x35817)
    AX >>= 0x1;
    
    // AND AX,BP (334B_2369 / 0x35819)
    AX &= BP;
    
    // ADD AX,DX (334B_236B / 0x3581B)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // STOSW ES:DI (334B_236D / 0x3581D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x3000:5810 (334B_236E / 0x3581E)
    if(--CX != 0) {
      goto label_334B_2360_35810;
    }
    // POP CX (334B_2370 / 0x35820)
    CX = Stack.Pop();
    // SUB DI,CX (334B_2371 / 0x35821)
    DI -= CX;
    
    // SUB SI,CX (334B_2373 / 0x35823)
    SI -= CX;
    
    // ADD DI,0x140 (334B_2375 / 0x35825)
    DI += 0x140;
    
    // ADD SI,0x190 (334B_2379 / 0x35829)
    SI += 0x190;
    
    // DEC BH (334B_237D / 0x3582D)
    BH = Alu.Dec8(BH);
    // JNZ 0x3000:57fd (334B_237F / 0x3582F)
    if(!ZeroFlag) {
      goto label_334B_234D_357FD;
    }
    // POP BP (334B_2381 / 0x35831)
    BP = Stack.Pop();
    // POP DX (334B_2382 / 0x35832)
    DX = Stack.Pop();
    // RET  (334B_2383 / 0x35833)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2396_035846(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2396_35846:
    // XOR DX,DX (334B_2396 / 0x35846)
    DX = 0;
    // OR AX,AX (334B_2398 / 0x35848)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x3000:584e (334B_239A / 0x3584A)
    if(!SignFlag) {
      goto label_334B_239E_3584E;
    }
    // NEG AX (334B_239C / 0x3584C)
    AX = Alu.Sub16(0, AX);
    label_334B_239E_3584E:
    // SUB AX,0x46 (334B_239E / 0x3584E)
    // AX -= 0x46;
    AX = Alu.Sub16(AX, 0x46);
    // JC 0x3000:587b (334B_23A1 / 0x35851)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (334B_23CB / 0x3587B)
      return NearRet();
    }
    // MOV BX,0x2384 (334B_23A3 / 0x35853)
    BX = 0x2384;
    // XLAT CS:BX (334B_23A6 / 0x35856)
    AL = UInt8[cs2, (ushort)(BX + AL)];
    // XOR AH,AH (334B_23A8 / 0x35858)
    AH = 0;
    // MOV DX,AX (334B_23AA / 0x3585A)
    DX = AX;
    // XOR AL,AL (334B_23AC / 0x3585C)
    AL = 0;
    // ADD SI,DX (334B_23AE / 0x3585E)
    SI += DX;
    
    // SUB CX,DX (334B_23B0 / 0x35860)
    CX -= DX;
    
    // SUB CX,DX (334B_23B2 / 0x35862)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // JC 0x3000:587c (334B_23B4 / 0x35864)
    if(CarryFlag) {
      goto label_334B_23CC_3587C;
    }
    // PUSH DX (334B_23B6 / 0x35866)
    Stack.Push(DX);
    // XCHG DX,CX (334B_23B7 / 0x35867)
    ushort tmp_334B_23B7 = DX;
    DX = CX;
    CX = tmp_334B_23B7;
    // SUB CX,0x4 (334B_23B9 / 0x35869)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    // JC 0x3000:5874 (334B_23BC / 0x3586C)
    if(CarryFlag) {
      goto label_334B_23C4_35874;
    }
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_23BE / 0x3586E)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV AX,0x191c (334B_23C0 / 0x35870)
    AX = 0x191C;
    // STOSW ES:DI (334B_23C3 / 0x35873)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    label_334B_23C4_35874:
    // MOV AX,0x1718 (334B_23C4 / 0x35874)
    AX = 0x1718;
    // STOSW ES:DI (334B_23C7 / 0x35877)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV CX,DX (334B_23C8 / 0x35878)
    CX = DX;
    // POP DX (334B_23CA / 0x3587A)
    DX = Stack.Pop();
    label_334B_23CB_3587B:
    // RET  (334B_23CB / 0x3587B)
    return NearRet();
    label_334B_23CC_3587C:
    // ADD CX,DX (334B_23CC / 0x3587C)
    CX += DX;
    
    // ADD CX,DX (334B_23CE / 0x3587E)
    // CX += DX;
    CX = Alu.Add16(CX, DX);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_23D0 / 0x35880)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // XOR CX,CX (334B_23D2 / 0x35882)
    CX = 0;
    // XOR DX,DX (334B_23D4 / 0x35884)
    DX = 0;
    // RET  (334B_23D6 / 0x35886)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_23D7_035887(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_23D7_35887:
    // JCXZ 0x3000:589a (334B_23D7 / 0x35887)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (334B_23EA / 0x3589A)
      return NearRet();
    }
    // MOV AX,0x1817 (334B_23D9 / 0x35889)
    AX = 0x1817;
    // STOSW ES:DI (334B_23DC / 0x3588C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // SUB CX,0x4 (334B_23DD / 0x3588D)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    // JC 0x3000:589a (334B_23E0 / 0x35890)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (334B_23EA / 0x3589A)
      return NearRet();
    }
    // MOV AX,0x1c19 (334B_23E2 / 0x35892)
    AX = 0x1C19;
    // STOSW ES:DI (334B_23E5 / 0x35895)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // XOR AL,AL (334B_23E6 / 0x35896)
    AL = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_23E8 / 0x35898)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    label_334B_23EA_3589A:
    // RET  (334B_23EA / 0x3589A)
    return NearRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_23EB_03589B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_23EB_3589B:
    // PUSH DI (334B_23EB / 0x3589B)
    Stack.Push(DI);
    // MOV DI,CX (334B_23EC / 0x3589C)
    DI = CX;
    // DEC DI (334B_23EE / 0x3589E)
    DI = Alu.Dec16(DI);
    // ADD BX,DI (334B_23EF / 0x3589F)
    BX += DI;
    
    // ADD AX,DI (334B_23F1 / 0x358A1)
    // AX += DI;
    AX = Alu.Add16(AX, DI);
    // PUSH AX (334B_23F3 / 0x358A3)
    Stack.Push(AX);
    // PUSH DX (334B_23F4 / 0x358A4)
    Stack.Push(DX);
    // MOV AX,0xc8 (334B_23F5 / 0x358A5)
    AX = 0xC8;
    // MUL DI (334B_23F8 / 0x358A8)
    Cpu.Mul16(DI);
    // ADD SI,AX (334B_23FA / 0x358AA)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // POP DX (334B_23FC / 0x358AC)
    DX = Stack.Pop();
    // POP AX (334B_23FD / 0x358AD)
    AX = Stack.Pop();
    // CALL 0x3000:40c0 (334B_23FE / 0x358AE)
    NearCall(cs2, 0x2401, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_2401_358B1:
    // POP DX (334B_2401 / 0x358B1)
    DX = Stack.Pop();
    // XCHG DX,CX (334B_2402 / 0x358B2)
    ushort tmp_334B_2402 = DX;
    DX = CX;
    CX = tmp_334B_2402;
    label_334B_2404_358B4:
    // CALL 0x3000:58c3 (334B_2404 / 0x358B4)
    NearCall(cs2, 0x2407, spice86_generated_label_call_target_334B_2413_0358C3);
    label_334B_2407_358B7:
    // SUB SI,0xc8 (334B_2407 / 0x358B7)
    SI -= 0xC8;
    
    // SUB DI,0x140 (334B_240B / 0x358BB)
    DI -= 0x140;
    
    // DEC DX (334B_240F / 0x358BF)
    DX = Alu.Dec16(DX);
    // JNZ 0x3000:58b4 (334B_2410 / 0x358C0)
    if(!ZeroFlag) {
      goto label_334B_2404_358B4;
    }
    // RETF  (334B_2412 / 0x358C2)
    return FarRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2413_0358C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2413_358C3:
    // PUSH AX (334B_2413 / 0x358C3)
    Stack.Push(AX);
    // PUSH CX (334B_2414 / 0x358C4)
    Stack.Push(CX);
    // PUSH DX (334B_2415 / 0x358C5)
    Stack.Push(DX);
    // PUSH SI (334B_2416 / 0x358C6)
    Stack.Push(SI);
    // PUSH DI (334B_2417 / 0x358C7)
    Stack.Push(DI);
    // CALL 0x3000:5846 (334B_2418 / 0x358C8)
    NearCall(cs2, 0x241B, spice86_generated_label_call_target_334B_2396_035846);
    label_334B_241B_358CB:
    // PUSH DX (334B_241B / 0x358CB)
    Stack.Push(DX);
    // MOV BP,0xf0f (334B_241C / 0x358CC)
    BP = 0xF0F;
    // MOV DX,0x1010 (334B_241F / 0x358CF)
    DX = 0x1010;
    // SHR CX,0x1 (334B_2422 / 0x358D2)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // JNC 0x3000:58dc (334B_2424 / 0x358D4)
    if(!CarryFlag) {
      goto label_334B_242C_358DC;
    }
    // LODSB SI (334B_2426 / 0x358D6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // AND AX,BP (334B_2427 / 0x358D7)
    AX &= BP;
    
    // ADD AL,DL (334B_2429 / 0x358D9)
    // AL += DL;
    AL = Alu.Add8(AL, DL);
    // STOSB ES:DI (334B_242B / 0x358DB)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_334B_242C_358DC:
    // JCXZ 0x3000:58e6 (334B_242C / 0x358DC)
    if(CX == 0) {
      goto label_334B_2436_358E6;
    }
    label_334B_242E_358DE:
    // LODSW SI (334B_242E / 0x358DE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // AND AX,BP (334B_242F / 0x358DF)
    AX &= BP;
    
    // ADD AX,DX (334B_2431 / 0x358E1)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // STOSW ES:DI (334B_2433 / 0x358E3)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x3000:58de (334B_2434 / 0x358E4)
    if(--CX != 0) {
      goto label_334B_242E_358DE;
    }
    label_334B_2436_358E6:
    // POP CX (334B_2436 / 0x358E6)
    CX = Stack.Pop();
    // CALL 0x3000:5887 (334B_2437 / 0x358E7)
    NearCall(cs2, 0x243A, spice86_generated_label_call_target_334B_23D7_035887);
    label_334B_243A_358EA:
    // POP DI (334B_243A / 0x358EA)
    DI = Stack.Pop();
    // POP SI (334B_243B / 0x358EB)
    SI = Stack.Pop();
    // POP DX (334B_243C / 0x358EC)
    DX = Stack.Pop();
    // POP CX (334B_243D / 0x358ED)
    CX = Stack.Pop();
    // POP AX (334B_243E / 0x358EE)
    AX = Stack.Pop();
    // DEC AX (334B_243F / 0x358EF)
    AX = Alu.Dec16(AX);
    // RET  (334B_2440 / 0x358F0)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_253D_0359ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_253D_359ED:
    // CMP byte ptr CS:[0x1a1],0x0 (334B_253D / 0x359ED)
    Alu.Sub8(UInt8[cs2, 0x1A1], 0x0);
    // JZ 0x3000:5a14 (334B_2543 / 0x359F3)
    if(ZeroFlag) {
      goto label_334B_2564_35A14;
    }
    label_334B_2545_359F5:
    // MOV AX,word ptr [BP + 0x0] (334B_2545 / 0x359F5)
    AX = UInt16[SS, BP];
    // SUB AX,BX (334B_2548 / 0x359F8)
    AX -= BX;
    
    // CMP AX,0x5 (334B_254A / 0x359FA)
    Alu.Sub16(AX, 0x5);
    // JC 0x3000:59f5 (334B_254D / 0x359FD)
    if(CarryFlag) {
      goto label_334B_2545_359F5;
    }
    label_334B_254F_359FF:
    // PUSH DX (334B_254F / 0x359FF)
    Stack.Push(DX);
    // MOV DX,word ptr CS:[0x19f] (334B_2550 / 0x35A00)
    DX = UInt16[cs2, 0x19F];
    label_334B_2555_35A05:
    // IN AL,DX (334B_2555 / 0x35A05)
    AL = Cpu.In8(DX);
    // AND AL,0x8 (334B_2556 / 0x35A06)
    AL &= 0x8;
    
    // CMP AL,byte ptr CS:[0x1a2] (334B_2558 / 0x35A08)
    Alu.Sub8(AL, UInt8[cs2, 0x1A2]);
    // JNZ 0x3000:5a05 (334B_255D / 0x35A0D)
    if(!ZeroFlag) {
      goto label_334B_2555_35A05;
    }
    // POP DX (334B_255F / 0x35A0F)
    DX = Stack.Pop();
    // MOV BX,word ptr [BP + 0x0] (334B_2560 / 0x35A10)
    BX = UInt16[SS, BP];
    // RET  (334B_2563 / 0x35A13)
    return NearRet();
    label_334B_2564_35A14:
    // MOV AX,word ptr [BP + 0x0] (334B_2564 / 0x35A14)
    AX = UInt16[SS, BP];
    // SUB AX,BX (334B_2567 / 0x35A17)
    AX -= BX;
    
    // CMP AX,0x6 (334B_2569 / 0x35A19)
    Alu.Sub16(AX, 0x6);
    // JC 0x3000:5a14 (334B_256C / 0x35A1C)
    if(CarryFlag) {
      goto label_334B_2564_35A14;
    }
    // MOV BX,word ptr [BP + 0x0] (334B_256E / 0x35A1E)
    BX = UInt16[SS, BP];
    // RET  (334B_2571 / 0x35A21)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2572_035A22(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2572_35A22:
    // CMP byte ptr CS:[0x1a1],0x0 (334B_2572 / 0x35A22)
    Alu.Sub8(UInt8[cs2, 0x1A1], 0x0);
    // JNZ 0x3000:59ff (334B_2578 / 0x35A28)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_253D_0359ED, 0x359FF - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_334B_257A_35A2A:
    // MOV AX,word ptr [BP + 0x0] (334B_257A / 0x35A2A)
    AX = UInt16[SS, BP];
    // SUB AX,BX (334B_257D / 0x35A2D)
    AX -= BX;
    
    // CMP AX,0x3 (334B_257F / 0x35A2F)
    Alu.Sub16(AX, 0x3);
    // JC 0x3000:5a2a (334B_2582 / 0x35A32)
    if(CarryFlag) {
      goto label_334B_257A_35A2A;
    }
    // MOV BX,word ptr [BP + 0x0] (334B_2584 / 0x35A34)
    BX = UInt16[SS, BP];
    // RET  (334B_2587 / 0x35A37)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2596_035A46(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_2596_35A46:
    // PUSH DS (334B_2596 / 0x35A46)
    Stack.Push(DS);
    // PUSH ES (334B_2597 / 0x35A47)
    Stack.Push(ES);
    // MOV DS,word ptr CS:[0x2539] (334B_2598 / 0x35A48)
    DS = UInt16[cs2, 0x2539];
    // MOV ES,word ptr CS:[0x2535] (334B_259D / 0x35A4D)
    ES = UInt16[cs2, 0x2535];
    // PUSH CS (334B_25A2 / 0x35A52)
    Stack.Push(cs2);
    // CALL 0x3000:502c (334B_25A3 / 0x35A53)
    NearCall(cs2, 0x25A6, spice86_generated_label_call_target_334B_1B7C_03502C);
    label_334B_25A6_35A56:
    // POP ES (334B_25A6 / 0x35A56)
    ES = Stack.Pop();
    // POP DS (334B_25A7 / 0x35A57)
    DS = Stack.Pop();
    // RET  (334B_25A8 / 0x35A58)
    return NearRet();
  }
  
  public Action spice86_generated_label_jump_target_334B_25E7_035A97(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_25E7_35A97:
    // MOV word ptr CS:[0x2768],0x8 (334B_25E7 / 0x35A97)
    UInt16[cs2, 0x2768] = 0x8;
    // MOV word ptr CS:[0x276a],0x1 (334B_25EE / 0x35A9E)
    UInt16[cs2, 0x276A] = 0x1;
    // MOV word ptr CS:[0x2535],SI (334B_25F5 / 0x35AA5)
    UInt16[cs2, 0x2535] = SI;
    // MOV word ptr CS:[0x2537],DS (334B_25FA / 0x35AAA)
    UInt16[cs2, 0x2537] = DS;
    // MOV word ptr CS:[0x2539],ES (334B_25FF / 0x35AAF)
    UInt16[cs2, 0x2539] = ES;
    // MOV CX,0x98 (334B_2604 / 0x35AB4)
    CX = 0x98;
    // AND AX,0xfe (334B_2607 / 0x35AB7)
    AX &= 0xFE;
    
    label_334B_260A_35ABA:
    // CMP AX,0x3e (334B_260A / 0x35ABA)
    Alu.Sub16(AX, 0x3E);
    // JC 0x3000:5ac4 (334B_260D / 0x35ABD)
    if(CarryFlag) {
      goto label_334B_2614_35AC4;
    }
    // SUB AX,0x3e (334B_260F / 0x35ABF)
    // AX -= 0x3E;
    AX = Alu.Sub16(AX, 0x3E);
    // JMP 0x3000:5aba (334B_2612 / 0x35AC2)
    goto label_334B_260A_35ABA;
    label_334B_2614_35AC4:
    // MOV BX,AX (334B_2614 / 0x35AC4)
    BX = AX;
    // JMP word ptr CS:[BX + 0x25a9] (334B_2616 / 0x35AC6)
    // Indirect jump to word ptr CS:[BX + 0x25a9], generating possible targets from emulator records
    uint targetAddress_334B_2616 = (uint)(cs2 * 0x10 + UInt16[cs2, (ushort)(BX + 0x25A9)] - cs1 * 0x10);
    switch(targetAddress_334B_2616) {
      case 0x25BDE : throw FailAsUntested("Would have been a goto but label label_334B_272E_35BDE does not exist because no instruction was found there that belongs to a function.");
      case 0x26270 : throw FailAsUntested("Would have been a goto but label label_334B_2DC0_36270 does not exist because no instruction was found there that belongs to a function.");
      case 0x2617A : throw FailAsUntested("Would have been a goto but label label_334B_2CCA_3617A does not exist because no instruction was found there that belongs to a function.");
      case 0x25F18 : throw FailAsUntested("Would have been a goto but label label_334B_2A68_35F18 does not exist because no instruction was found there that belongs to a function.");
      case 0x26273 : throw FailAsUntested("Would have been a goto but label label_334B_2DC3_36273 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_2616));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public Action spice86_generated_label_call_target_334B_261D_035ACD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_261D_35ACD:
    // CMP byte ptr [0x1a1],0x0 (334B_261D / 0x35ACD)
    Alu.Sub8(UInt8[DS, 0x1A1], 0x0);
    // JNZ 0x3000:5ad7 (334B_2622 / 0x35AD2)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (334B_2627 / 0x35AD7)
      return NearRet();
    }
    // CALL 0x3000:5a22 (334B_2624 / 0x35AD4)
    NearCall(cs2, 0x2627, spice86_generated_label_call_target_334B_2572_035A22);
    label_334B_2627_35AD7:
    // RET  (334B_2627 / 0x35AD7)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_26E3_035B93(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_26E3_35B93:
    // MOV CS:[0x261b],AX (334B_26E3 / 0x35B93)
    UInt16[cs2, 0x261B] = AX;
    label_334B_26E7_35B97:
    // XOR BX,BX (334B_26E7 / 0x35B97)
    BX = 0;
    label_334B_26E9_35B99:
    // PUSH BX (334B_26E9 / 0x35B99)
    Stack.Push(BX);
    // PUSH DX (334B_26EA / 0x35B9A)
    Stack.Push(DX);
    // PUSH word ptr [BP + 0x0] (334B_26EB / 0x35B9B)
    Stack.Push(UInt16[SS, BP]);
    // MOV SI,0x5bf (334B_26EE / 0x35B9E)
    SI = 0x5BF;
    // ADD SI,BX (334B_26F1 / 0x35BA1)
    SI += BX;
    
    // ADD SI,BX (334B_26F3 / 0x35BA3)
    SI += BX;
    
    // ADD SI,BX (334B_26F5 / 0x35BA5)
    // SI += BX;
    SI = Alu.Add16(SI, BX);
    // MOV DI,SI (334B_26F7 / 0x35BA7)
    DI = SI;
    // MOV AX,CS:[0x261b] (334B_26F9 / 0x35BA9)
    AX = UInt16[cs2, 0x261B];
    // PUSH AX (334B_26FD / 0x35BAD)
    Stack.Push(AX);
    // MOV CX,AX (334B_26FE / 0x35BAE)
    CX = AX;
    // ADD CX,CX (334B_2700 / 0x35BB0)
    CX += CX;
    
    // ADD CX,AX (334B_2702 / 0x35BB2)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    label_334B_2704_35BB4:
    // MOV AL,byte ptr [SI] (334B_2704 / 0x35BB4)
    AL = UInt8[DS, SI];
    // SUB AL,DH (334B_2706 / 0x35BB6)
    // AL -= DH;
    AL = Alu.Sub8(AL, DH);
    // JNS 0x3000:5bbc (334B_2708 / 0x35BB8)
    if(!SignFlag) {
      goto label_334B_270C_35BBC;
    }
    // XOR AL,AL (334B_270A / 0x35BBA)
    AL = 0;
    label_334B_270C_35BBC:
    // MOV byte ptr [SI],AL (334B_270C / 0x35BBC)
    UInt8[DS, SI] = AL;
    // INC SI (334B_270E / 0x35BBE)
    SI = Alu.Inc16(SI);
    // LOOP 0x3000:5bb4 (334B_270F / 0x35BBF)
    if(--CX != 0) {
      goto label_334B_2704_35BB4;
    }
    // POP CX (334B_2711 / 0x35BC1)
    CX = Stack.Pop();
    // MOV DX,DI (334B_2712 / 0x35BC2)
    DX = DI;
    // CALL 0x3000:4018 (334B_2714 / 0x35BC4)
    NearCall(cs2, 0x2717, spice86_generated_label_call_target_334B_0B68_034018);
    label_334B_2717_35BC7:
    // POP BX (334B_2717 / 0x35BC7)
    BX = Stack.Pop();
    // CALL 0x3000:5acd (334B_2718 / 0x35BC8)
    NearCall(cs2, 0x271B, spice86_generated_label_call_target_334B_261D_035ACD);
    label_334B_271B_35BCB:
    // POP DX (334B_271B / 0x35BCB)
    DX = Stack.Pop();
    // POP BX (334B_271C / 0x35BCC)
    BX = Stack.Pop();
    // MOV AX,CS:[0x261b] (334B_271D / 0x35BCD)
    AX = UInt16[cs2, 0x261B];
    // ADD BX,AX (334B_2721 / 0x35BD1)
    BX += AX;
    
    // CMP BX,0xff (334B_2723 / 0x35BD3)
    Alu.Sub16(BX, 0xFF);
    // JC 0x3000:5b99 (334B_2727 / 0x35BD7)
    if(CarryFlag) {
      goto label_334B_26E9_35B99;
    }
    // DEC DL (334B_2729 / 0x35BD9)
    DL = Alu.Dec8(DL);
    // JNZ 0x3000:5b97 (334B_272B / 0x35BDB)
    if(!ZeroFlag) {
      goto label_334B_26E7_35B97;
    }
    // RET  (334B_272D / 0x35BDD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_334B_2AB0_035F60(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_jump_target_334B_3200_0366B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      case 0x26832 : throw FailAsUntested("Would have been a goto but label label_334B_3382_36832 does not exist because no instruction was found there that belongs to a function.");
      case 0x26A31 : throw FailAsUntested("Would have been a goto but label label_334B_3581_36A31 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_321E));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public Action spice86_generated_label_call_target_334B_32C1_036771(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26730: break; // Instructions before entry targeted by 0x36774
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
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
    entry:
    label_334B_32C1_36771:
    // CMP CL,0x9 (334B_32C1 / 0x36771)
    Alu.Sub8(CL, 0x9);
    // JZ 0x3000:6730 (334B_32C4 / 0x36774)
    if(ZeroFlag) {
      goto label_334B_3280_36730;
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
  
  public Action spice86_generated_label_call_target_334B_35C8_036A78(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action not_observed_334B_39E9_036E99(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHR BP,0x1 (334B_39F1 / 0x36EA1)
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
    AX = Alu.Dec16(AX);
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
  
  public Action spice86_generated_label_jump_target_334B_3A14_036EC4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_334B_3A14_36EC4:
    // CALL 0x3000:40c0 (334B_3A14 / 0x36EC4)
    NearCall(cs2, 0x3A17, spice86_generated_label_call_target_334B_0C10_0340C0);
    label_334B_3A17_36EC7:
    // MOV SI,DI (334B_3A17 / 0x36EC7)
    SI = DI;
    // MOV DI,word ptr CS:[0x1a3] (334B_3A19 / 0x36EC9)
    DI = UInt16[cs2, 0x1A3];
    // SHL BP,0x1 (334B_3A1E / 0x36ECE)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // JMP word ptr CS:[BP + 0x3a04] (334B_3A20 / 0x36ED0)
    // Indirect jump to word ptr CS:[BP + 0x3a04], generating possible targets from emulator records
    uint targetAddress_334B_3A20 = (uint)(cs2 * 0x10 + UInt16[cs2, (ushort)(BP + 0x3A04)] - cs1 * 0x10);
    switch(targetAddress_334B_3A20) {
      case 0x26FF6 : throw FailAsUntested("Would have been a goto but label label_334B_3B46_36FF6 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_3A20));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public Action spice86_generated_label_call_target_5635_0100_056450(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_5635_0103_056453(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
}
