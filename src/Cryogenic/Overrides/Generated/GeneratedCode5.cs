namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_8E16_018E16(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_8E9E_018E9E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    DH = Alu.Inc8(DH);
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
  
  public Action spice86_generated_label_call_target_1000_8ED3_018ED3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_8ED3_18ED3:
    // XOR CX,CX (1000_8ED3 / 0x18ED3)
    CX = 0;
    // PUSH BX (1000_8ED5 / 0x18ED5)
    Stack.Push(BX);
    // MOV BX,word ptr [0x47a0] (1000_8ED6 / 0x18ED6)
    BX = UInt16[DS, 0x47A0];
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
    throw FailAsUntested("Could not find a valid function at address 1000_D0E3 / 0x1D0E3");
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
  
  public Action spice86_generated_label_call_target_1000_8F28_018F28(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_8FD1_18FD1;
    }
    // CMP byte ptr [0xc6],0x0 (1000_8F86 / 0x18F86)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    // JNZ 0x1000:8ff5 (1000_8F8B / 0x18F8B)
    if(!ZeroFlag) {
      goto label_1000_8FF5_18FF5;
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
      goto label_1000_900B_1900B;
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
    throw FailAsUntested("Could not find a valid function at address 1000_C370 / 0x1C370");
    // POP SI (1000_8FCF / 0x18FCF)
    SI = Stack.Pop();
    label_1000_8FD0_18FD0:
    // RET  (1000_8FD0 / 0x18FD0)
    return NearRet();
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
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8FEA));
        break;
    }
    // ADD word ptr [0x1be4],0x2 (1000_8FEE / 0x18FEE)
    // UInt16[DS, 0x1BE4] += 0x2;
    UInt16[DS, 0x1BE4] = Alu.Add16(UInt16[DS, 0x1BE4], 0x2);
    // POP SI (1000_8FF3 / 0x18FF3)
    SI = Stack.Pop();
    // RET  (1000_8FF4 / 0x18FF4)
    return NearRet();
    label_1000_8FF5_18FF5:
    // PUSH SI (1000_8FF5 / 0x18FF5)
    Stack.Push(SI);
    // MOV AX,0x32 (1000_8FF6 / 0x18FF6)
    AX = 0x32;
    // CALL 0x1000:c13e (1000_8FF9 / 0x18FF9)
    NearCall(cs1, 0x8FFC, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV AX,0x3 (1000_8FFC / 0x18FFC)
    AX = 0x3;
    // MOV SI,0x2265 (1000_8FFF / 0x18FFF)
    SI = 0x2265;
    // MOV ES,word ptr [0xdbd6] (1000_9002 / 0x19002)
    ES = UInt16[DS, 0xDBD6];
    // CALL 0x1000:c370 (1000_9006 / 0x19006)
    throw FailAsUntested("Could not find a valid function at address 1000_C370 / 0x1C370");
    // POP SI (1000_9009 / 0x19009)
    SI = Stack.Pop();
    // RET  (1000_900A / 0x1900A)
    return NearRet();
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
    label_1000_9022_19022:
    // JMP 0x1000:8895 (1000_9022 / 0x19022)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_8888_018888, 0x18895 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_9025_019025(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      case 0x235BF : throw FailAsUntested("Could not find a valid function at address 334B_010F / 0x335BF");
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9041));
        break;
    }
    label_1000_9045_19045:
    // RET  (1000_9045 / 0x19045)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_9046_019046(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_908C_01908C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_90B8));
        break;
    }
    label_1000_90BC_190BC:
    // RET  (1000_90BC / 0x190BC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_90BD_0190BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_9123_019123(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHR AH,0x1 (1000_9135 / 0x19135)
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
    // SHL AX,0x1 (1000_914D / 0x1914D)
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
    // SHL AX,0x1 (1000_917D / 0x1917D)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_917F / 0x1917F)
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
    // SHL AH,0x1 (1000_9188 / 0x19188)
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
  
  public Action spice86_generated_label_call_target_1000_9197_019197(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_91A0_0191A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_920F_01920F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_9215_019215(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9281: goto label_1000_9281_19281;break; // Target of external jump from 0x192D2, 0x1924C
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
      if(JumpDispatcher.Jump(split_1000_42E9_0142E9, 0)) {
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
    if(JumpDispatcher.Jump(split_1000_9381_019381, 0)) {
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
    if(JumpDispatcher.Jump(split_1000_945B_01945B, 0)) {
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_3F14_013F14, 0x13F15 - cs1 * 0x10)) {
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
    if(JumpDispatcher.Jump(split_1000_42E9_0142E9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_9285_019285(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      if(JumpDispatcher.Jump(split_1000_92EB_0192EB, 0)) {
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
  
  public Action spice86_generated_label_call_target_1000_92C9_0192C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action split_1000_92EB_0192EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action split_1000_9381_019381(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    throw FailAsUntested("Could not find a valid function at address 1000_1EBE / 0x11EBE");
    // CALL 0x1000:31f6 (1000_93A5 / 0x193A5)
    throw FailAsUntested("Could not find a valid function at address 1000_31F6 / 0x131F6");
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
    label_1000_93D2_193D2:
    // CALL 0x1000:c0f4 (1000_93D2 / 0x193D2)
    NearCall(cs1, 0x93D5, spice86_generated_label_call_target_1000_C0F4_01C0F4);
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_945B_01945B, 0x19472 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_93DF_0193DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_93DF_193DF:
    // MOV CL,AL (1000_93DF / 0x193DF)
    CL = AL;
    // SHL AL,0x1 (1000_93E1 / 0x193E1)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_93E3 / 0x193E3)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_93E5 / 0x193E5)
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
  
  public Action split_1000_945B_01945B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9472: goto label_1000_9472_19472;break; // Target of external jump from 0x193DC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
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
    if(JumpDispatcher.Jump(split_1000_9381_019381, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_9468_19468:
    // CALL 0x1000:d41b (1000_9468 / 0x19468)
    NearCall(cs1, 0x946B, spice86_generated_label_call_target_1000_D41B_01D41B);
    // CMP BP,0x1ffe (1000_946B / 0x1946B)
    Alu.Sub16(BP, 0x1FFE);
    // JNZ 0x1000:9472 (1000_946F / 0x1946F)
    if(!ZeroFlag) {
      goto label_1000_9472_19472;
    }
    // RET  (1000_9471 / 0x19471)
    return NearRet();
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
      goto label_1000_94DD_194DD;
    }
    // MOV SI,word ptr [0x47ba] (1000_9486 / 0x19486)
    SI = UInt16[DS, 0x47BA];
    // OR SI,SI (1000_948A / 0x1948A)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JNZ 0x1000:949a (1000_948C / 0x1948C)
    if(!ZeroFlag) {
      goto label_1000_949A_1949A;
    }
    // MOV SI,word ptr [0x47be] (1000_948E / 0x1948E)
    SI = UInt16[DS, 0x47BE];
    label_1000_9492_19492:
    // MOV AX,SI (1000_9492 / 0x19492)
    AX = SI;
    // SHL SI,0x1 (1000_9494 / 0x19494)
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
    throw FailAsUntested("Could not find a valid function at address 1000_9F9E / 0x19F9E");
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
    if(JumpDispatcher.Jump(split_1000_D2E2_01D2E2, 0)) {
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
    label_1000_94DD_194DD:
    // LDS SI,[0x47b6] (1000_94DD / 0x194DD)
    DS = UInt16[DS, 0x47B8];
    SI = UInt16[DS, 0x47B6];
    // CALL 0x1000:88d2 (1000_94E1 / 0x194E1)
    throw FailAsUntested("Could not find a valid function at address 1000_88D2 / 0x188D2");
    // MOV SI,word ptr [0x47ba] (1000_94E4 / 0x194E4)
    SI = UInt16[DS, 0x47BA];
    // ADD word ptr [0x4780],0x1000 (1000_94E8 / 0x194E8)
    // UInt16[DS, 0x4780] += 0x1000;
    UInt16[DS, 0x4780] = Alu.Add16(UInt16[DS, 0x4780], 0x1000);
    // CALL 0x1000:a03f (1000_94EE / 0x194EE)
    throw FailAsUntested("Could not find a valid function at address 1000_A03F / 0x1A03F");
    // JMP 0x1000:94a5 (1000_94F1 / 0x194F1)
    goto label_1000_94A5_194A5;
  }
  
  public Action spice86_generated_label_call_target_1000_94F3_0194F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action split_1000_961A_01961A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_961A_1961A:
    // RET  (1000_961A / 0x1961A)
    return NearRet();
  }
  
  public Action split_1000_9673_019673(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    DI = Alu.Inc16(DI);
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
    throw FailAsUntested("Could not find a valid function at address 1000_9556 / 0x19556");
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
  
  public Action spice86_generated_label_call_target_1000_96B5_0196B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    throw FailAsUntested("Could not find a valid function at address 1000_9F9E / 0x19F9E");
    label_1000_96CF_196CF:
    // POP word ptr [0x47c2] (1000_96CF / 0x196CF)
    UInt16[DS, 0x47C2] = Stack.Pop();
    // POP word ptr [0x47c4] (1000_96D3 / 0x196D3)
    UInt16[DS, 0x47C4] = Stack.Pop();
    // RET  (1000_96D7 / 0x196D7)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_96F1_0196F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_96F1_196F1:
    // MOV [0x47c4],AX (1000_96F1 / 0x196F1)
    UInt16[DS, 0x47C4] = AX;
    // CMP AL,0xe (1000_96F4 / 0x196F4)
    Alu.Sub8(AL, 0xE);
    // JNZ 0x1000:9702 (1000_96F6 / 0x196F6)
    if(!ZeroFlag) {
      goto label_1000_9702_19702;
    }
    // MOV SI,word ptr [0x4756] (1000_96F8 / 0x196F8)
    SI = UInt16[DS, 0x4756];
    // CALL 0x1000:31f6 (1000_96FC / 0x196FC)
    throw FailAsUntested("Could not find a valid function at address 1000_31F6 / 0x131F6");
    // MOV AX,0xe (1000_96FF / 0x196FF)
    AX = 0xE;
    label_1000_9702_19702:
    // SHL AX,0x1 (1000_9702 / 0x19702)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_9704 / 0x19704)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_9706 / 0x19706)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // OR AX,0x4 (1000_9708 / 0x19708)
    // AX |= 0x4;
    AX = Alu.Or16(AX, 0x4);
    // MOV SI,AX (1000_970B / 0x1970B)
    SI = AX;
    // SHL SI,0x1 (1000_970D / 0x1970D)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV SI,word ptr [SI + 0xaa76] (1000_970F / 0x1970F)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    // CALL 0x1000:9f40 (1000_9713 / 0x19713)
    NearCall(cs1, 0x9716, spice86_generated_label_call_target_1000_9F40_019F40);
    label_1000_9716_19716:
    // JMP 0x1000:9f8b (1000_9716 / 0x19716)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_9F8B_019F8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_978E_01978E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_978E_1978E:
    // CALL 0x1000:4aca (1000_978E / 0x1978E)
    NearCall(cs1, 0x9791, spice86_generated_label_call_target_1000_4ACA_014ACA);
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
    label_1000_979C_1979C:
    // CALL 0x1000:9908 (1000_979C / 0x1979C)
    NearCall(cs1, 0x979F, spice86_generated_label_call_target_1000_9908_019908);
    label_1000_979F_1979F:
    // CMP word ptr [0x479e],0x0 (1000_979F / 0x1979F)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    // JZ 0x1000:97ac (1000_97A4 / 0x197A4)
    if(ZeroFlag) {
      goto label_1000_97AC_197AC;
    }
    // MOV SI,0x1be2 (1000_97A6 / 0x197A6)
    SI = 0x1BE2;
    // CALL 0x1000:c477 (1000_97A9 / 0x197A9)
    NearCall(cs1, 0x97AC, spice86_generated_label_call_target_1000_C477_01C477);
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
    label_1000_97CB_197CB:
    // JMP 0x1000:c4dd (1000_97CB / 0x197CB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_97CE_197CE:
    // RET  (1000_97CE / 0x197CE)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_97CF_0197CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_97CF_197CF:
    // CALL 0x1000:a7a5 (1000_97CF / 0x197CF)
    NearCall(cs1, 0x97D2, spice86_generated_label_call_target_1000_A7A5_01A7A5);
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
      goto label_1000_980C_1980C;
    }
    // CALL 0x1000:8c8a (1000_97F2 / 0x197F2)
    NearCall(cs1, 0x97F5, spice86_generated_label_call_target_1000_8C8A_018C8A);
    // MOV BP,0x98b2 (1000_97F5 / 0x197F5)
    BP = 0x98B2;
    // CALL 0x1000:c097 (1000_97F8 / 0x197F8)
    NearCall(cs1, 0x97FB, spice86_generated_label_call_target_1000_C097_01C097);
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
    // POP AX (1000_9805 / 0x19805)
    AX = Stack.Pop();
    // MOV [0x11ca],AL (1000_9806 / 0x19806)
    UInt8[DS, 0x11CA] = AL;
    // JMP 0x1000:4abe (1000_9809 / 0x19809)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_4ABE_014ABE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
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
      if(JumpDispatcher.Jump(split_1000_9849_019849, 0)) {
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
    if(JumpDispatcher.Jump(split_1000_9673_019673, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_982E_1982E:
    // CALL 0x1000:9655 (1000_982E / 0x1982E)
    throw FailAsUntested("Could not find a valid function at address 1000_9655 / 0x19655");
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
      if(JumpDispatcher.Jump(split_1000_9849_019849, 0x19879 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_983F_1983F:
    // RET  (1000_983F / 0x1983F)
    return NearRet();
  }
  
  public Action split_1000_9849_019849(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    NearCall(cs1, 0x9858, split_1000_9673_019673);
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
      goto label_1000_9898_19898;
    }
    label_1000_9879_19879:
    // CALL 0x1000:2efb (1000_9879 / 0x19879)
    NearCall(cs1, 0x987C, spice86_generated_label_call_target_1000_2EFB_012EFB);
    label_1000_987C_1987C:
    // CMP byte ptr [0x11c9],0x0 (1000_987C / 0x1987C)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:9886 (1000_9881 / 0x19881)
    if(!ZeroFlag) {
      goto label_1000_9886_19886;
    }
    // CALL 0x1000:3090 (1000_9883 / 0x19883)
    NearCall(cs1, 0x9886, spice86_generated_label_call_target_1000_3090_013090);
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
    goto label_1000_9858_19858;
  }
  
  public Action spice86_generated_label_call_target_1000_98B2_0198B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // MOV SI,0x1bf0 (1000_98DC / 0x198DC)
    SI = 0x1BF0;
    // CALL 0x1000:c4f0 (1000_98DF / 0x198DF)
    NearCall(cs1, 0x98E2, spice86_generated_label_call_target_1000_C4F0_01C4F0);
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
  
  public Action spice86_generated_label_call_target_1000_98E6_0198E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_98E6_198E6:
    // CALL 0x1000:98f5 (1000_98E6 / 0x198E6)
    NearCall(cs1, 0x98E9, spice86_generated_label_call_target_1000_98F5_0198F5);
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
  }
  
  public Action spice86_generated_label_call_target_1000_98F5_0198F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
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
  
  public Action Set479ETo0_1000_9901_19901(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_9901_19901:
    // MOV word ptr [0x479e],0x0 (1000_9901 / 0x19901)
    UInt16[DS, 0x479E] = 0x0;
    // RET  (1000_9907 / 0x19907)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_9908_019908(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHL AX,0x1 (1000_991D / 0x1991D)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_991F / 0x1991F)
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
  
  public Action spice86_generated_label_call_target_1000_994F_01994F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AL = Alu.Dec8(AL);
    // XOR AH,AH (1000_9965 / 0x19965)
    AH = 0;
    // SHL AX,0x1 (1000_9967 / 0x19967)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_9969 / 0x19969)
    BP = AX;
    // RET  (1000_996B / 0x1996B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_996C_01996C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_9985_019985(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9982: break; // Instructions before entry targeted by 
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
  
  public Action spice86_generated_label_call_target_1000_99BE_0199BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_99BE_199BE:
    // CMP byte ptr [0x47c3],0x0 (1000_99BE / 0x199BE)
    Alu.Sub8(UInt8[DS, 0x47C3], 0x0);
    // JZ 0x1000:99da (1000_99C3 / 0x199C3)
    if(ZeroFlag) {
      goto label_1000_99DA_199DA;
    }
    // CALL 0x1000:998e (1000_99C5 / 0x199C5)
    throw FailAsUntested("Could not find a valid function at address 1000_998E / 0x1998E");
    // MOV AX,0x7 (1000_99C8 / 0x199C8)
    AX = 0x7;
    // CALL 0x1000:920f (1000_99CB / 0x199CB)
    NearCall(cs1, 0x99CE, spice86_generated_label_call_target_1000_920F_01920F);
    // CALL 0x1000:99da (1000_99CE / 0x199CE)
    throw FailAsUntested("Could not find a valid function at address 1000_99DA / 0x199DA");
    // CALL 0x1000:998e (1000_99D1 / 0x199D1)
    throw FailAsUntested("Could not find a valid function at address 1000_998E / 0x1998E");
    // MOV AX,0x2d (1000_99D4 / 0x199D4)
    AX = 0x2D;
    // CALL 0x1000:920f (1000_99D7 / 0x199D7)
    NearCall(cs1, 0x99DA, spice86_generated_label_call_target_1000_920F_01920F);
    label_1000_99DA_199DA:
    // CALL 0x1000:9197 (1000_99DA / 0x199DA)
    NearCall(cs1, 0x99DD, spice86_generated_label_call_target_1000_9197_019197);
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
      goto label_1000_9A40_19A40;
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
      goto label_1000_9A1D_19A1D;
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
    // ADD SI,word ptr ES:[BP + SI] (1000_9A2F / 0x19A2F)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    // CALL 0x1000:996c (1000_9A32 / 0x19A32)
    NearCall(cs1, 0x9A35, spice86_generated_label_call_target_1000_996C_01996C);
    // MOV word ptr [0x47c6],SI (1000_9A35 / 0x19A35)
    UInt16[DS, 0x47C6] = SI;
    // JMP 0x1000:99f0 (1000_9A39 / 0x19A39)
    goto label_1000_99F0_199F0;
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
      goto label_1000_99F6_199F6;
    }
    // CALL 0x1000:9ab4 (1000_9A4F / 0x19A4F)
    throw FailAsUntested("Could not find a valid function at address 1000_9AB4 / 0x19AB4");
    // JC 0x1000:99f6 (1000_9A52 / 0x19A52)
    if(CarryFlag) {
      goto label_1000_99F6_199F6;
    }
    // CALL 0x1000:9a7b (1000_9A54 / 0x19A54)
    throw FailAsUntested("Could not find a valid function at address 1000_9A7B / 0x19A7B");
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
    throw FailAsUntested("Could not find a valid function at address 1000_9A60 / 0x19A60");
    // JMP 0x1000:99f6 (1000_9A5E / 0x19A5E)
    goto label_1000_99F6_199F6;
  }
  
  public Action spice86_generated_label_call_target_1000_9B49_019B49(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AX = Alu.Inc16(AX);
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
  
  public Action spice86_generated_label_call_target_1000_9B8B_019B8B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_9B8B_19B8B:
    // CALL 0x1000:a7a5 (1000_9B8B / 0x19B8B)
    NearCall(cs1, 0x9B8E, spice86_generated_label_call_target_1000_A7A5_01A7A5);
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
  
  public Action spice86_generated_label_call_target_1000_9BAC_019BAC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_9BAC_19BAC:
    // PUSH SI (1000_9BAC / 0x19BAC)
    Stack.Push(SI);
    // CALL 0x1000:9197 (1000_9BAD / 0x19BAD)
    NearCall(cs1, 0x9BB0, spice86_generated_label_call_target_1000_9197_019197);
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
  
  public Action spice86_generated_label_call_target_1000_9BB1_019BB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      if(JumpDispatcher.Jump(split_1000_9BCC_019BCC, 0)) {
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
    label_1000_9BC5_19BC5:
    // MOV word ptr [SI],0x80 (1000_9BC5 / 0x19BC5)
    UInt16[DS, SI] = 0x80;
    // JMP 0x1000:9bd7 (1000_9BC9 / 0x19BC9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_9BCC_019BCC, 0x19BD7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_9BCC_019BCC(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9BD7: goto label_1000_9BD7_19BD7;break; // Target of external jump from 0x19BC9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9BCC_19BCC:
    // CALL 0x1000:9c2d (1000_9BCC / 0x19BCC)
    NearCall(cs1, 0x9BCF, spice86_generated_label_call_target_1000_9C2D_019C2D);
    label_1000_9BCF_19BCF:
    // CMP word ptr [0xd834],0x13f (1000_9BCF / 0x19BCF)
    Alu.Sub16(UInt16[DS, 0xD834], 0x13F);
    // JZ 0x1000:9bec (1000_9BD5 / 0x19BD5)
    if(ZeroFlag) {
      goto label_1000_9BEC_19BEC;
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
    label_1000_9BEC_19BEC:
    // POP SI (1000_9BEC / 0x19BEC)
    SI = Stack.Pop();
    // RET  (1000_9BED / 0x19BED)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_9BEE_019BEE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    
    // SHL AX,0x1 (1000_9C0C / 0x19C0C)
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
  
  public Action spice86_generated_label_call_target_1000_9C2D_019C2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_9C54_019C54(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_9CA6_19CA6;
    }
    // CALL 0x1000:abcc (1000_9C80 / 0x19C80)
    NearCall(cs1, 0x9C83, spice86_generated_label_call_target_1000_ABCC_01ABCC);
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
  
  public Action spice86_generated_label_call_target_1000_9CC6_019CC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHL BP,0x1 (1000_9CE0 / 0x19CE0)
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
  
  public Action spice86_generated_label_call_target_1000_9D16_019D16(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHL CX,0x1 (1000_9D23 / 0x19D23)
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
    label_1000_9D2D_19D2D:
    // LODSW SI (1000_9D2D / 0x19D2D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_9D2E / 0x19D2E)
    CX = AX;
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
    // SHL BP,0x1 (1000_9D4E / 0x19D4E)
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
      case 0x235C2 : throw FailAsUntested("Could not find a valid function at address 334B_0112 / 0x335C2");
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
  
  public Action split_1000_9ED5_019ED5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9EFC: goto label_1000_9EFC_19EFC;break; // Target of external jump from 0x19F0D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_9ED5_19ED5:
    // CMP word ptr [0x47c4],0x10 (1000_9ED5 / 0x19ED5)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    // JNC 0x1000:9eeb (1000_9EDA / 0x19EDA)
    if(!CarryFlag) {
      goto label_1000_9EEB_19EEB;
    }
    // CALL 0x1000:9985 (1000_9EDC / 0x19EDC)
    NearCall(cs1, 0x9EDF, spice86_generated_label_call_target_1000_9985_019985);
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
    // MOV AL,[0x47dd] (1000_9EEE / 0x19EEE)
    AL = UInt8[DS, 0x47DD];
    label_1000_9EF1_19EF1:
    // MOV [0x47dc],AL (1000_9EF1 / 0x19EF1)
    UInt8[DS, 0x47DC] = AL;
    // CALL 0x1000:9efd (1000_9EF4 / 0x19EF4)
    NearCall(cs1, 0x9EF7, spice86_generated_label_call_target_1000_9EFD_019EFD);
    // MOV byte ptr [0x47dc],0x0 (1000_9EF7 / 0x19EF7)
    UInt8[DS, 0x47DC] = 0x0;
    label_1000_9EFC_19EFC:
    // RET  (1000_9EFC / 0x19EFC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_9EFD_019EFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A75C_01A75C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:9f1c (1000_9F16 / 0x19F16)
    throw FailAsUntested("Could not find a valid function at address 1000_9F1C / 0x19F1C");
    label_1000_9F19_19F19:
    // JMP 0x1000:a75c (1000_9F19 / 0x19F19)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_A75C_01A75C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_9F40_019F40(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    throw FailAsUntested("Could not find a valid function at address 1000_1243 / 0x11243");
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
      goto label_1000_9F82_19F82;
    }
    // CALL 0x1000:c07c (1000_9F67 / 0x19F67)
    NearCall(cs1, 0x9F6A, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_9F6A_19F6A:
    // MOV word ptr [0x4784],0x28 (1000_9F6A / 0x19F6A)
    UInt16[DS, 0x4784] = 0x28;
    // MOV word ptr [0x4786],0x10 (1000_9F70 / 0x19F70)
    UInt16[DS, 0x4786] = 0x10;
    // MOV word ptr [0x4788],0x10 (1000_9F76 / 0x19F76)
    UInt16[DS, 0x4788] = 0x10;
    // MOV word ptr [0x478a],0x10 (1000_9F7C / 0x19F7C)
    UInt16[DS, 0x478A] = 0x10;
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
  
  public Action split_1000_9F8B_019F8B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_9F8B_19F8B:
    // PUSH word ptr [0x47c2] (1000_9F8B / 0x19F8B)
    Stack.Push(UInt16[DS, 0x47C2]);
    // MOV byte ptr [0x47c2],0x20 (1000_9F8F / 0x19F8F)
    UInt8[DS, 0x47C2] = 0x20;
    // CALL 0x1000:9f9e (1000_9F94 / 0x19F94)
    throw FailAsUntested("Could not find a valid function at address 1000_9F9E / 0x19F9E");
    label_1000_9F97_19F97:
    // POP word ptr [0x47c2] (1000_9F97 / 0x19F97)
    UInt16[DS, 0x47C2] = Stack.Pop();
    // RET  (1000_9F9B / 0x19F9B)
    return NearRet();
  }
  
  public Action split_1000_9F9C_019F9C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_9F9C_19F9C:
    // STC  (1000_9F9C / 0x19F9C)
    CarryFlag = true;
    // RET  (1000_9F9D / 0x19F9D)
    return NearRet();
    label_1000_9F9E_19F9E:
    // MOV word ptr [0x477c],SI (1000_9F9E / 0x19F9E)
    UInt16[DS, 0x477C] = SI;
    // CALL 0x1000:94f3 (1000_9FA2 / 0x19FA2)
    NearCall(cs1, 0x9FA5, spice86_generated_label_call_target_1000_94F3_0194F3);
    label_1000_9FA5_19FA5:
    // MOV word ptr [0x47bc],0xa6b0 (1000_9FA5 / 0x19FA5)
    UInt16[DS, 0x47BC] = 0xA6B0;
    label_1000_9FAB_19FAB:
    // MOV AX,word ptr [SI] (1000_9FAB / 0x19FAB)
    AX = UInt16[DS, SI];
    // CMP AX,0xffff (1000_9FAD / 0x19FAD)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:9f9c (1000_9FB0 / 0x19FB0)
    if(ZeroFlag) {
      goto label_1000_9F9C_19F9C;
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
    // ROL AH,0x1 (1000_9FC6 / 0x19FC6)
    AH = Alu.Rol8(AH, 0x1);
    // ROL AH,0x1 (1000_9FC8 / 0x19FC8)
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
      goto label_1000_9FF7_19FF7;
    }
    // MOV AX,[0x47c4] (1000_9FDF / 0x19FDF)
    AX = UInt16[DS, 0x47C4];
    // CMP AX,0x10 (1000_9FE2 / 0x19FE2)
    Alu.Sub16(AX, 0x10);
    // JNC 0x1000:9ff7 (1000_9FE5 / 0x19FE5)
    if(!CarryFlag) {
      goto label_1000_9FF7_19FF7;
    }
    // PUSH SI (1000_9FE7 / 0x19FE7)
    Stack.Push(SI);
    // PUSH AX (1000_9FE8 / 0x19FE8)
    Stack.Push(AX);
    // CALL 0x1000:a0f1 (1000_9FE9 / 0x19FE9)
    NearCall(cs1, 0x9FEC, spice86_generated_label_call_target_1000_A0F1_01A0F1);
    label_1000_9FEC_19FEC:
    // CALL 0x1000:1803 (1000_9FEC / 0x19FEC)
    NearCall(cs1, 0x9FEF, spice86_generated_label_call_target_1000_1803_011803);
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
      if(JumpDispatcher.Jump(split_1000_A026_01A026, 0x1A034 - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_A026_01A026, 0)) {
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
    if(JumpDispatcher.Jump(split_1000_A026_01A026, 0x1A02C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_A026_01A026(int loadOffset) {
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
    throw FailAsUntested("Could not find a valid function at address 1000_8B11 / 0x18B11");
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
    throw FailAsUntested("Could not find a valid function at address 1000_88AF / 0x188AF");
    label_1000_A03E_1A03E:
    // POP SI (1000_A03E / 0x1A03E)
    SI = Stack.Pop();
    label_1000_A03F_1A03F:
    // CALL 0x1000:c85b (1000_A03F / 0x1A03F)
    NearCall(cs1, 0xA042, spice86_generated_label_call_target_1000_C85B_01C85B);
    label_1000_A042_1A042:
    // CMP word ptr [0x47b6],0x0 (1000_A042 / 0x1A042)
    Alu.Sub16(UInt16[DS, 0x47B6], 0x0);
    // JNZ 0x1000:a0aa (1000_A047 / 0x1A047)
    if(!ZeroFlag) {
      goto label_1000_A0AA_1A0AA;
    }
    // MOV AL,byte ptr [SI] (1000_A049 / 0x1A049)
    AL = UInt8[DS, SI];
    // AND AL,0xf (1000_A04B / 0x1A04B)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // JZ 0x1000:a05e (1000_A04D / 0x1A04D)
    if(ZeroFlag) {
      goto label_1000_A05E_1A05E;
    }
    // XOR AH,AH (1000_A04F / 0x1A04F)
    AH = 0;
    // PUSH SI (1000_A051 / 0x1A051)
    Stack.Push(SI);
    // DEC AX (1000_A052 / 0x1A052)
    AX = Alu.Dec16(AX);
    // SHL AX,0x1 (1000_A053 / 0x1A053)
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
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A05A));
        break;
    }
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
    
    // SHR AX,0x1 (1000_A06F / 0x1A06F)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_A071 / 0x1A071)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV BL,byte ptr [0x47c4] (1000_A073 / 0x1A073)
    BL = UInt8[DS, 0x47C4];
    // SHL BL,0x1 (1000_A077 / 0x1A077)
    BL <<= 0x1;
    
    // SHL BL,0x1 (1000_A079 / 0x1A079)
    BL <<= 0x1;
    
    // SHL BL,0x1 (1000_A07B / 0x1A07B)
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
    throw FailAsUntested("Could not find a valid function at address 1000_2EBF / 0x12EBF");
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
  
  public Action spice86_generated_label_call_target_1000_A0F1_01A0F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_A1C4_01A1C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A1C4_1A1C4:
    // MOV byte ptr [0x47a5],0xff (1000_A1C4 / 0x1A1C4)
    UInt8[DS, 0x47A5] = 0xFF;
    // RET  (1000_A1C9 / 0x1A1C9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A1E2_01A1E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A1E2_1A1E2:
    // CMP byte ptr [0x47a5],0xff (1000_A1E2 / 0x1A1E2)
    Alu.Sub8(UInt8[DS, 0x47A5], 0xFF);
    // RET  (1000_A1E7 / 0x1A1E7)
    return NearRet();
  }
  
  public Action IncUnknown47A8_1000_A1E8_1A1E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A1E8_1A1E8:
    // INC byte ptr [0x47a8] (1000_A1E8 / 0x1A1E8)
    UInt8[DS, 0x47A8] = Alu.Inc8(UInt8[DS, 0x47A8]);
    // RET  (1000_A1EC / 0x1A1EC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A30B_01A30B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    SI = Alu.Inc16(SI);
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
  
  public Action spice86_generated_label_call_target_1000_A334_01A334(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      case 0xA348 : throw FailAsUntested("Would have been a goto but label label_1000_A348_1A348 does not exist because no instruction was found there that belongs to a function.");
      case 0xA342 : throw FailAsUntested("Would have been a goto but label label_1000_A342_1A342 does not exist because no instruction was found there that belongs to a function.");
      case 0xA33F : throw FailAsUntested("Would have been a goto but label label_1000_A33F_1A33F does not exist because no instruction was found there that belongs to a function.");
      case 0xA34F : throw FailAsUntested("Would have been a goto but label label_1000_A34F_1A34F does not exist because no instruction was found there that belongs to a function.");
      case 0xA356 : throw FailAsUntested("Would have been a goto but label label_1000_A356_1A356 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A337));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public Action spice86_generated_label_call_target_1000_A396_01A396(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A396_1A396:
    // SUB SP,0x32 (1000_A396 / 0x1A396)
    // SP -= 0x32;
    SP = Alu.Sub16(SP, 0x32);
    // MOV BP,SP (1000_A399 / 0x1A399)
    BP = SP;
    // SHL AX,0x1 (1000_A39B / 0x1A39B)
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
  
  public Action split_1000_A3F9_01A3F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    if(JumpDispatcher.Jump(split_1000_D32F_01D32F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A42C_01A42C(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA435: goto label_1000_A435_1A435;break; // Target of external jump from 0x1A451
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A42C_1A42C:
    // MOV AX,0x55 (1000_A42C / 0x1A42C)
    AX = 0x55;
    // CALL 0x1000:c13e (1000_A42F / 0x1A42F)
    NearCall(cs1, 0xA432, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_A432_1A432:
    // MOV AL,[0xceeb] (1000_A432 / 0x1A432)
    AL = UInt8[DS, 0xCEEB];
    label_1000_A435_1A435:
    // PUSH word ptr [0xdbda] (1000_A435 / 0x1A435)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_A439 / 0x1A439)
    NearCall(cs1, 0xA43C, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_A43C_1A43C:
    // CBW  (1000_A43C / 0x1A43C)
    AX = (ushort)((short)((sbyte)AL));
    // CALL 0x1000:a465 (1000_A43D / 0x1A43D)
    NearCall(cs1, 0xA440, spice86_generated_label_call_target_1000_A465_01A465);
    label_1000_A440_1A440:
    // SHL AX,0x1 (1000_A440 / 0x1A440)
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
  
}
