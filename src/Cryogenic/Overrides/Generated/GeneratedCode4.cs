namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_5E42_015E42(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5E42_15E42:
    // MOV AX,0x3a (1000_5E42 / 0x15E42)
    AX = 0x3A;
    // TEST byte ptr [0x46eb],0x80 (1000_5E45 / 0x15E45)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    // JZ 0x1000:5e4f (1000_5E4A / 0x15E4A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5E4F_015E4F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,0x7a (1000_5E4C / 0x15E4C)
    AX = 0x7A;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5E4F_015E4F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5E4F_015E4F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5E4F_15E4F:
    // MOV CL,byte ptr [SI + 0x8] (1000_5E4F / 0x15E4F)
    CL = UInt8[DS, (ushort)(SI + 0x8)];
    // CMP CL,0x20 (1000_5E52 / 0x15E52)
    Alu.Sub8(CL, 0x20);
    // JC 0x1000:5e6a (1000_5E55 / 0x15E55)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E57 / 0x15E57)
    AX = Alu.Inc16(AX);
    // CMP CL,0x21 (1000_5E58 / 0x15E58)
    Alu.Sub8(CL, 0x21);
    // JC 0x1000:5e6a (1000_5E5B / 0x15E5B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E5D / 0x15E5D)
    AX = Alu.Inc16(AX);
    // CMP CL,0x28 (1000_5E5E / 0x15E5E)
    Alu.Sub8(CL, 0x28);
    // JC 0x1000:5e6a (1000_5E61 / 0x15E61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E63 / 0x15E63)
    AX = Alu.Inc16(AX);
    // CMP CL,0x30 (1000_5E64 / 0x15E64)
    Alu.Sub8(CL, 0x30);
    // JC 0x1000:5e6a (1000_5E67 / 0x15E67)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    // INC AX (1000_5E69 / 0x15E69)
    AX = Alu.Inc16(AX);
    label_1000_5E6A_15E6A:
    // RET  (1000_5E6A / 0x15E6A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5E6D_015E6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5E6D_15E6D:
    // PUSH SI (1000_5E6D / 0x15E6D)
    Stack.Push(SI);
    // MOV BP,SP (1000_5E6E / 0x15E6E)
    BP = SP;
    // SUB SP,0x8 (1000_5E70 / 0x15E70)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    // MOV word ptr [BP + -0x8],0xffff (1000_5E73 / 0x15E73)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xFFFF;
    // MOV word ptr [BP + -0x6],DX (1000_5E78 / 0x15E78)
    UInt16[SS, (ushort)(BP - 0x6)] = DX;
    // MOV word ptr [BP + -0x4],BX (1000_5E7B / 0x15E7B)
    UInt16[SS, (ushort)(BP - 0x4)] = BX;
    // MOV word ptr [BP + -0x2],0x0 (1000_5E7E / 0x15E7E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    // MOV SI,0xa5ba (1000_5E83 / 0x15E83)
    SI = 0xA5BA;
    label_1000_5E86_15E86:
    // ADD SI,0x6 (1000_5E86 / 0x15E86)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    // MOV DI,word ptr [SI] (1000_5E89 / 0x15E89)
    DI = UInt16[DS, SI];
    // OR DI,DI (1000_5E8B / 0x15E8B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:5ebf (1000_5E8D / 0x15E8D)
    if(ZeroFlag) {
      goto label_1000_5EBF_15EBF;
    }
    // CMP byte ptr [DI + 0x8],AL (1000_5E8F / 0x15E8F)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], AL);
    // JNC 0x1000:5e86 (1000_5E92 / 0x15E92)
    if(!CarryFlag) {
      goto label_1000_5E86_15E86;
    }
    // MOV BX,word ptr [SI + 0x4] (1000_5E94 / 0x15E94)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP BH,byte ptr [0x46eb] (1000_5E97 / 0x15E97)
    Alu.Sub8(BH, UInt8[DS, 0x46EB]);
    // JNZ 0x1000:5e86 (1000_5E9B / 0x15E9B)
    if(!ZeroFlag) {
      goto label_1000_5E86_15E86;
    }
    // XOR BH,BH (1000_5E9D / 0x15E9D)
    BH = 0;
    // MOV DX,word ptr [SI + 0x2] (1000_5E9F / 0x15E9F)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB DX,word ptr [BP + -0x6] (1000_5EA2 / 0x15EA2)
    // DX -= UInt16[SS, (ushort)(BP - 0x6)];
    DX = Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x6)]);
    // JNS 0x1000:5ea9 (1000_5EA5 / 0x15EA5)
    if(!SignFlag) {
      goto label_1000_5EA9_15EA9;
    }
    // NEG DX (1000_5EA7 / 0x15EA7)
    DX = Alu.Sub16(0, DX);
    label_1000_5EA9_15EA9:
    // SUB BX,word ptr [BP + -0x4] (1000_5EA9 / 0x15EA9)
    // BX -= UInt16[SS, (ushort)(BP - 0x4)];
    BX = Alu.Sub16(BX, UInt16[SS, (ushort)(BP - 0x4)]);
    // JNS 0x1000:5eb0 (1000_5EAC / 0x15EAC)
    if(!SignFlag) {
      goto label_1000_5EB0_15EB0;
    }
    // NEG BX (1000_5EAE / 0x15EAE)
    BX = Alu.Sub16(0, BX);
    label_1000_5EB0_15EB0:
    // ADD DX,BX (1000_5EB0 / 0x15EB0)
    DX += BX;
    
    // CMP DX,word ptr [BP + -0x8] (1000_5EB2 / 0x15EB2)
    Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x8)]);
    // JNC 0x1000:5e86 (1000_5EB5 / 0x15EB5)
    if(!CarryFlag) {
      goto label_1000_5E86_15E86;
    }
    // MOV word ptr [BP + -0x8],DX (1000_5EB7 / 0x15EB7)
    UInt16[SS, (ushort)(BP - 0x8)] = DX;
    // MOV word ptr [BP + -0x2],DI (1000_5EBA / 0x15EBA)
    UInt16[SS, (ushort)(BP - 0x2)] = DI;
    // JMP 0x1000:5e86 (1000_5EBD / 0x15EBD)
    goto label_1000_5E86_15E86;
    label_1000_5EBF_15EBF:
    // MOV DI,word ptr [BP + -0x2] (1000_5EBF / 0x15EBF)
    DI = UInt16[SS, (ushort)(BP - 0x2)];
    // MOV AX,word ptr [BP + -0x8] (1000_5EC2 / 0x15EC2)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    // MOV DX,word ptr [BP + -0x6] (1000_5EC5 / 0x15EC5)
    DX = UInt16[SS, (ushort)(BP - 0x6)];
    // MOV BX,word ptr [BP + -0x4] (1000_5EC8 / 0x15EC8)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    // ADD SP,0x8 (1000_5ECB / 0x15ECB)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    // POP SI (1000_5ECE / 0x15ECE)
    SI = Stack.Pop();
    // RET  (1000_5ECF / 0x15ECF)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5F79_015F79(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5F79_15F79:
    // XOR AX,AX (1000_5F79 / 0x15F79)
    AX = 0;
    // XCHG word ptr [0x46f8],AX (1000_5F7B / 0x15F7B)
    ushort tmp_1000_5F7B = UInt16[DS, 0x46F8];
    UInt16[DS, 0x46F8] = AX;
    AX = tmp_1000_5F7B;
    // OR AX,AX (1000_5F7F / 0x15F7F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:5f90 (1000_5F81 / 0x15F81)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5F90 / 0x15F90)
      return NearRet();
    }
    // CALL 0x1000:d41b (1000_5F83 / 0x15F83)
    NearCall(cs1, 0x5F86, spice86_generated_label_call_target_1000_D41B_01D41B);
    // MOV AL,byte ptr [BP + 0x0] (1000_5F86 / 0x15F86)
    AL = UInt8[SS, BP];
    // INC AL (1000_5F89 / 0x15F89)
    AL = Alu.Inc8(AL);
    // JZ 0x1000:5f91 (1000_5F8B / 0x15F8B)
    if(ZeroFlag) {
      goto label_1000_5F91_15F91;
    }
    // JMP 0x1000:d2e2 (1000_5F8D / 0x15F8D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5F90_15F90:
    // RET  (1000_5F90 / 0x15F90)
    return NearRet();
    label_1000_5F91_15F91:
    // MOV word ptr [0x46f8],0x0 (1000_5F91 / 0x15F91)
    UInt16[DS, 0x46F8] = 0x0;
    // MOV byte ptr [0x46f7],0x0 (1000_5F97 / 0x15F97)
    UInt8[DS, 0x46F7] = 0x0;
    // MOV SI,0x1668 (1000_5F9C / 0x15F9C)
    SI = 0x1668;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_5F9F_015F9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_5F9F_015F9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5F9F_15F9F:
    // CALL 0x1000:c07c (1000_5F9F / 0x15F9F)
    NearCall(cs1, 0x5FA2, spice86_generated_label_call_target_1000_C07C_01C07C);
    // MOV word ptr [0xdbe0],0x0 (1000_5FA2 / 0x15FA2)
    UInt16[DS, 0xDBE0] = 0x0;
    // CALL 0x1000:c6ad (1000_5FA8 / 0x15FA8)
    NearCall(cs1, 0x5FAB, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // MOV AL,0x8 (1000_5FAB / 0x15FAB)
    AL = 0x8;
    // JMP 0x1000:7b2b (1000_5FAD / 0x15FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7B2B_017B2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_6231_016231(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6231_16231:
    // PUSH BX (1000_6231 / 0x16231)
    Stack.Push(BX);
    // MOV BL,byte ptr [DI + 0x8] (1000_6232 / 0x16232)
    BL = UInt8[DS, (ushort)(DI + 0x8)];
    // XOR AX,AX (1000_6235 / 0x16235)
    AX = 0;
    // CMP BL,0x20 (1000_6237 / 0x16237)
    Alu.Sub8(BL, 0x20);
    // JC 0x1000:6250 (1000_623A / 0x1623A)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // INC AX (1000_623C / 0x1623C)
    AX = Alu.Inc16(AX);
    // CMP BL,0x21 (1000_623D / 0x1623D)
    Alu.Sub8(BL, 0x21);
    // JC 0x1000:6250 (1000_6240 / 0x16240)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // INC AX (1000_6242 / 0x16242)
    AX = Alu.Inc16(AX);
    // CMP BL,0x28 (1000_6243 / 0x16243)
    Alu.Sub8(BL, 0x28);
    // JC 0x1000:6250 (1000_6246 / 0x16246)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // INC AX (1000_6248 / 0x16248)
    AX = Alu.Inc16(AX);
    // CMP BL,0x30 (1000_6249 / 0x16249)
    Alu.Sub8(BL, 0x30);
    // JC 0x1000:6250 (1000_624C / 0x1624C)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    // SUB AL,0x2 (1000_624E / 0x1624E)
    // AL -= 0x2;
    AL = Alu.Sub8(AL, 0x2);
    label_1000_6250_16250:
    // POP BX (1000_6250 / 0x16250)
    BX = Stack.Pop();
    // RET  (1000_6251 / 0x16251)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_629D_01629D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_629D_1629D:
    // CALL 0x1000:6231 (1000_629D / 0x1629D)
    NearCall(cs1, 0x62A0, spice86_generated_label_call_target_1000_6231_016231);
    label_1000_62A0_162A0:
    // ADD AX,0x44 (1000_62A0 / 0x162A0)
    // AX += 0x44;
    AX = Alu.Add16(AX, 0x44);
    // JMP 0x1000:d194 (1000_62A3 / 0x162A3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_62A6_0162A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_62A6_162A6:
    // MOV AL,byte ptr [DI] (1000_62A6 / 0x162A6)
    AL = UInt8[DS, DI];
    // XOR AH,AH (1000_62A8 / 0x162A8)
    AH = 0;
    // ADD AX,0x0 (1000_62AA / 0x162AA)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    // CALL 0x1000:d194 (1000_62AD / 0x162AD)
    NearCall(cs1, 0x62B0, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_62B0_162B0:
    // CMP byte ptr [DI + 0x1],0x3 (1000_62B0 / 0x162B0)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x1)], 0x3);
    // MOV AL,0x20 (1000_62B4 / 0x162B4)
    AL = 0x20;
    // JC 0x1000:62ba (1000_62B6 / 0x162B6)
    if(CarryFlag) {
      goto label_1000_62BA_162BA;
    }
    // MOV AL,0x2d (1000_62B8 / 0x162B8)
    AL = 0x2D;
    label_1000_62BA_162BA:
    // CALL word ptr [0x2518] (1000_62BA / 0x162BA)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_62BA = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_62BA) {
      case 0xD12F : NearCall(cs1, 0x62BE, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_62BA));
        break;
    }
    label_1000_62BE_162BE:
    // MOV AL,byte ptr [DI + 0x1] (1000_62BE / 0x162BE)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    // XOR AH,AH (1000_62C1 / 0x162C1)
    AH = 0;
    // ADD AX,0xc (1000_62C3 / 0x162C3)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    // JMP 0x1000:d19b (1000_62C6 / 0x162C6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D19B_01D19B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_62C9_0162C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_62C9_162C9:
    // CMP byte ptr [0x46eb],0x1 (1000_62C9 / 0x162C9)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x1);
    // JC 0x1000:62f1 (1000_62CE / 0x162CE)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // MOV DX,word ptr [SI + 0x2] (1000_62D0 / 0x162D0)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,word ptr [SI + 0x4] (1000_62D3 / 0x162D3)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_62D6_0162D6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_62D6_0162D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_62D6_162D6:
    // CALL 0x1000:b647 (1000_62D6 / 0x162D6)
    NearCall(cs1, 0x62D9, spice86_generated_label_call_target_1000_B647_01B647);
    label_1000_62D9_162D9:
    // CMP DX,word ptr [0x46e3] (1000_62D9 / 0x162D9)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // JC 0x1000:62f1 (1000_62DD / 0x162DD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // CMP DX,word ptr [0x46e7] (1000_62DF / 0x162DF)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // CMC  (1000_62E3 / 0x162E3)
    CarryFlag = !CarryFlag;
    // JC 0x1000:62f1 (1000_62E4 / 0x162E4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e5] (1000_62E6 / 0x162E6)
    Alu.Sub16(BX, UInt16[DS, 0x46E5]);
    // JC 0x1000:62f1 (1000_62EA / 0x162EA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e9] (1000_62EC / 0x162EC)
    Alu.Sub16(BX, UInt16[DS, 0x46E9]);
    // CMC  (1000_62F0 / 0x162F0)
    CarryFlag = !CarryFlag;
    label_1000_62F1_162F1:
    // RET  (1000_62F1 / 0x162F1)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6314_016314(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6314_16314:
    // CALL 0x1000:407e (1000_6314 / 0x16314)
    NearCall(cs1, 0x6317, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_6317_16317:
    // CALL 0x1000:62d6 (1000_6317 / 0x16317)
    NearCall(cs1, 0x631A, spice86_generated_label_call_target_1000_62D6_0162D6);
    label_1000_631A_1631A:
    // MOV AX,0x4c (1000_631A / 0x1631A)
    AX = 0x4C;
    // PUSHF  (1000_631D / 0x1631D)
    Stack.Push(FlagRegister);
    // SUB DX,0xd (1000_631E / 0x1631E)
    DX -= 0xD;
    
    // POPF  (1000_6321 / 0x16321)
    FlagRegister = Stack.Pop();
    label_1000_6322_16322:
    // JC 0x1000:62f1 (1000_6322 / 0x16322)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    // PUSH word ptr [0x2784] (1000_6324 / 0x16324)
    Stack.Push(UInt16[DS, 0x2784]);
    // PUSH AX (1000_6328 / 0x16328)
    Stack.Push(AX);
    // CALL 0x1000:c137 (1000_6329 / 0x16329)
    NearCall(cs1, 0x632C, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_632C_1632C:
    // POP AX (1000_632C / 0x1632C)
    AX = Stack.Pop();
    // CALL 0x1000:c1f4 (1000_632D / 0x1632D)
    NearCall(cs1, 0x6330, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_6330_16330:
    // SUB BL,byte ptr ES:[SI + 0x2] (1000_6330 / 0x16330)
    // BL -= UInt8[ES, (ushort)(SI + 0x2)];
    BL = Alu.Sub8(BL, UInt8[ES, (ushort)(SI + 0x2)]);
    // CALL 0x1000:c30d (1000_6334 / 0x16334)
    NearCall(cs1, 0x6337, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_6337_16337:
    // POP AX (1000_6337 / 0x16337)
    AX = Stack.Pop();
    // JMP 0x1000:c13e (1000_6338 / 0x16338)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_633B_01633B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_633B_1633B:
    // MOV DX,word ptr [0x197c] (1000_633B / 0x1633B)
    DX = UInt16[DS, 0x197C];
    // MOV BX,word ptr [0x197e] (1000_633F / 0x1633F)
    BX = UInt16[DS, 0x197E];
    // SUB BX,0x12 (1000_6343 / 0x16343)
    // BX -= 0x12;
    BX = Alu.Sub16(BX, 0x12);
    label_1000_6346_16346:
    // CALL 0x1000:634d (1000_6346 / 0x16346)
    NearCall(cs1, 0x6349, spice86_generated_label_call_target_1000_634D_01634D);
    label_1000_6349_16349:
    // INC BX (1000_6349 / 0x16349)
    BX = Alu.Inc16(BX);
    // JNC 0x1000:6346 (1000_634A / 0x1634A)
    if(!CarryFlag) {
      goto label_1000_6346_16346;
    }
    // RET  (1000_634C / 0x1634C)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_634D_01634D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_634D_1634D:
    // PUSH BX (1000_634D / 0x1634D)
    Stack.Push(BX);
    // PUSH DX (1000_634E / 0x1634E)
    Stack.Push(DX);
    // CALL 0x1000:62d6 (1000_634F / 0x1634F)
    NearCall(cs1, 0x6352, spice86_generated_label_call_target_1000_62D6_0162D6);
    label_1000_6352_16352:
    // POP SI (1000_6352 / 0x16352)
    SI = Stack.Pop();
    // POP CX (1000_6353 / 0x16353)
    CX = Stack.Pop();
    // JC 0x1000:6369 (1000_6354 / 0x16354)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6369 / 0x16369)
      return NearRet();
    }
    // PUSH BX (1000_6356 / 0x16356)
    Stack.Push(BX);
    // PUSH CX (1000_6357 / 0x16357)
    Stack.Push(CX);
    // PUSH DX (1000_6358 / 0x16358)
    Stack.Push(DX);
    // PUSH SI (1000_6359 / 0x16359)
    Stack.Push(SI);
    // CALL 0x1000:636a (1000_635A / 0x1635A)
    NearCall(cs1, 0x635D, spice86_generated_label_call_target_1000_636A_01636A);
    label_1000_635D_1635D:
    // POP SI (1000_635D / 0x1635D)
    SI = Stack.Pop();
    // POP DX (1000_635E / 0x1635E)
    DX = Stack.Pop();
    // POP CX (1000_635F / 0x1635F)
    CX = Stack.Pop();
    // POP BX (1000_6360 / 0x16360)
    BX = Stack.Pop();
    // PUSH CX (1000_6361 / 0x16361)
    Stack.Push(CX);
    // PUSH SI (1000_6362 / 0x16362)
    Stack.Push(SI);
    // CALL 0x1000:639a (1000_6363 / 0x16363)
    NearCall(cs1, 0x6366, spice86_generated_label_call_target_1000_639A_01639A);
    label_1000_6366_16366:
    // POP DX (1000_6366 / 0x16366)
    DX = Stack.Pop();
    // POP BX (1000_6367 / 0x16367)
    BX = Stack.Pop();
    // CLC  (1000_6368 / 0x16368)
    CarryFlag = false;
    label_1000_6369_16369:
    // RET  (1000_6369 / 0x16369)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_636A_01636A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x6394: goto label_1000_6394_16394;break; // Target of external jump from 0x16386, 0x163B6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_636A_1636A:
    // XCHG SI,DX (1000_636A / 0x1636A)
    ushort tmp_1000_636A = SI;
    SI = DX;
    DX = tmp_1000_636A;
    // XCHG CX,BX (1000_636C / 0x1636C)
    ushort tmp_1000_636C = CX;
    CX = BX;
    BX = tmp_1000_636C;
    // CALL 0x1000:b58b (1000_636E / 0x1636E)
    NearCall(cs1, 0x6371, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_6371_16371:
    // XCHG SI,DX (1000_6371 / 0x16371)
    ushort tmp_1000_6371 = SI;
    SI = DX;
    DX = tmp_1000_6371;
    // MOV BX,CX (1000_6373 / 0x16373)
    BX = CX;
    label_1000_6375_16375:
    // MOV AX,word ptr ES:[DI] (1000_6375 / 0x16375)
    AX = UInt16[ES, DI];
    // AND AX,0x3030 (1000_6378 / 0x16378)
    AX &= 0x3030;
    
    // CMP AL,0x10 (1000_637B / 0x1637B)
    Alu.Sub8(AL, 0x10);
    // JZ 0x1000:6395 (1000_637D / 0x1637D)
    if(ZeroFlag) {
      goto label_1000_6395_16395;
    }
    label_1000_637F_1637F:
    // ADD DX,0x4 (1000_637F / 0x1637F)
    DX += 0x4;
    
    // CMP DX,word ptr [0x46e7] (1000_6382 / 0x16382)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // JNC 0x1000:6394 (1000_6386 / 0x16386)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6394 / 0x16394)
      return NearRet();
    }
    // INC DI (1000_6388 / 0x16388)
    DI = Alu.Inc16(DI);
    // INC SI (1000_6389 / 0x16389)
    SI = Alu.Inc16(SI);
    // CMP SI,BP (1000_638A / 0x1638A)
    Alu.Sub16(SI, BP);
    // JC 0x1000:6375 (1000_638C / 0x1638C)
    if(CarryFlag) {
      goto label_1000_6375_16375;
    }
    // SUB SI,BP (1000_638E / 0x1638E)
    SI -= BP;
    
    // SUB DI,BP (1000_6390 / 0x16390)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    // JMP 0x1000:6375 (1000_6392 / 0x16392)
    goto label_1000_6375_16375;
    label_1000_6394_16394:
    // RET  (1000_6394 / 0x16394)
    return NearRet();
    label_1000_6395_16395:
    // CALL 0x1000:63c7 (1000_6395 / 0x16395)
    throw FailAsUntested("Could not find a valid function at address 1000_63C7 / 0x163C7");
    // JMP 0x1000:637f (1000_6398 / 0x16398)
    goto label_1000_637F_1637F;
  }
  
  public Action spice86_generated_label_call_target_1000_639A_01639A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_639A_1639A:
    // XCHG SI,DX (1000_639A / 0x1639A)
    ushort tmp_1000_639A = SI;
    SI = DX;
    DX = tmp_1000_639A;
    // XCHG CX,BX (1000_639C / 0x1639C)
    ushort tmp_1000_639C = CX;
    CX = BX;
    BX = tmp_1000_639C;
    // CALL 0x1000:b58b (1000_639E / 0x1639E)
    NearCall(cs1, 0x63A1, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_63A1_163A1:
    // XCHG SI,DX (1000_63A1 / 0x163A1)
    ushort tmp_1000_63A1 = SI;
    SI = DX;
    DX = tmp_1000_63A1;
    // MOV BX,CX (1000_63A3 / 0x163A3)
    BX = CX;
    label_1000_63A5_163A5:
    // MOV AX,word ptr ES:[DI] (1000_63A5 / 0x163A5)
    AX = UInt16[ES, DI];
    // AND AX,0x3030 (1000_63A8 / 0x163A8)
    AX &= 0x3030;
    
    // CMP AL,0x10 (1000_63AB / 0x163AB)
    Alu.Sub8(AL, 0x10);
    // JZ 0x1000:63c2 (1000_63AD / 0x163AD)
    if(ZeroFlag) {
      goto label_1000_63C2_163C2;
    }
    label_1000_63AF_163AF:
    // SUB DX,0x4 (1000_63AF / 0x163AF)
    DX -= 0x4;
    
    // CMP DX,word ptr [0x46e3] (1000_63B2 / 0x163B2)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // JC 0x1000:6394 (1000_63B6 / 0x163B6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6394 / 0x16394)
      return NearRet();
    }
    // DEC DI (1000_63B8 / 0x163B8)
    DI = Alu.Dec16(DI);
    // DEC SI (1000_63B9 / 0x163B9)
    SI = Alu.Dec16(SI);
    // JNS 0x1000:63a5 (1000_63BA / 0x163BA)
    if(!SignFlag) {
      goto label_1000_63A5_163A5;
    }
    // ADD SI,BP (1000_63BC / 0x163BC)
    SI += BP;
    
    // ADD DI,BP (1000_63BE / 0x163BE)
    // DI += BP;
    DI = Alu.Add16(DI, BP);
    // JMP 0x1000:63a5 (1000_63C0 / 0x163C0)
    goto label_1000_63A5_163A5;
    label_1000_63C2_163C2:
    // CALL 0x1000:63c7 (1000_63C2 / 0x163C2)
    throw FailAsUntested("Could not find a valid function at address 1000_63C7 / 0x163C7");
    // JMP 0x1000:63af (1000_63C5 / 0x163C5)
    goto label_1000_63AF_163AF;
  }
  
  public Action spice86_generated_label_call_target_1000_63F0_0163F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_63F0_163F0:
    // CMP byte ptr [0x46de],0x0 (1000_63F0 / 0x163F0)
    Alu.Sub8(UInt8[DS, 0x46DE], 0x0);
    // JZ 0x1000:642d (1000_63F5 / 0x163F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_642D / 0x1642D)
      return NearRet();
    }
    // MOV ES,word ptr [0xdd00] (1000_63F7 / 0x163F7)
    ES = UInt16[DS, 0xDD00];
    // MOV DI,0x100 (1000_63FB / 0x163FB)
    DI = 0x100;
    label_1000_63FE_163FE:
    // MOV AL,byte ptr [DI + 0xa] (1000_63FE / 0x163FE)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    // TEST AL,0x20 (1000_6401 / 0x16401)
    Alu.And8(AL, 0x20);
    // JZ 0x1000:6422 (1000_6403 / 0x16403)
    if(ZeroFlag) {
      goto label_1000_6422_16422;
    }
    // MOV BL,byte ptr [DI + 0x1b] (1000_6405 / 0x16405)
    BL = UInt8[DS, (ushort)(DI + 0x1B)];
    // MOV BH,0xfa (1000_6408 / 0x16408)
    BH = 0xFA;
    // CMP BL,BH (1000_640A / 0x1640A)
    Alu.Sub8(BL, BH);
    // JNC 0x1000:6422 (1000_640C / 0x1640C)
    if(!CarryFlag) {
      goto label_1000_6422_16422;
    }
    // MOV SI,word ptr [DI + 0x6] (1000_640E / 0x1640E)
    SI = UInt16[DS, (ushort)(DI + 0x6)];
    // CALL 0x1000:642e (1000_6411 / 0x16411)
    NearCall(cs1, 0x6414, spice86_generated_label_call_target_1000_642E_01642E);
    label_1000_6414_16414:
    // SHR DX,0x1 (1000_6414 / 0x16414)
    DX >>= 0x1;
    
    // INC DX (1000_6416 / 0x16416)
    DX = Alu.Inc16(DX);
    // ADD BL,DL (1000_6417 / 0x16417)
    BL += DL;
    
    // CMP BL,BH (1000_6419 / 0x16419)
    Alu.Sub8(BL, BH);
    // JC 0x1000:641f (1000_641B / 0x1641B)
    if(CarryFlag) {
      goto label_1000_641F_1641F;
    }
    // MOV BL,BH (1000_641D / 0x1641D)
    BL = BH;
    label_1000_641F_1641F:
    // MOV byte ptr [DI + 0x1b],BL (1000_641F / 0x1641F)
    UInt8[DS, (ushort)(DI + 0x1B)] = BL;
    label_1000_6422_16422:
    // ADD DI,0x1c (1000_6422 / 0x16422)
    DI += 0x1C;
    
    // CMP word ptr [DI],-0x1 (1000_6425 / 0x16425)
    Alu.Sub16(UInt16[DS, DI], 0xFFFF);
    // JNZ 0x1000:63fe (1000_6428 / 0x16428)
    if(!ZeroFlag) {
      goto label_1000_63FE_163FE;
    }
    // JMP 0x1000:65b6 (1000_642A / 0x1642A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_65B6_0165B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_642D_1642D:
    // RET  (1000_642D / 0x1642D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_642E_01642E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_642E_1642E:
    // MOV CX,0x3 (1000_642E / 0x1642E)
    CX = 0x3;
    // DEC SI (1000_6431 / 0x16431)
    SI = Alu.Dec16(SI);
    // XOR DX,DX (1000_6432 / 0x16432)
    DX = 0;
    label_1000_6434_16434:
    // LODSW ES:SI (1000_6434 / 0x16434)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // AND AX,0x3030 (1000_6436 / 0x16436)
    AX &= 0x3030;
    
    // CMP AH,0x10 (1000_6439 / 0x16439)
    Alu.Sub8(AH, 0x10);
    // JNZ 0x1000:643f (1000_643C / 0x1643C)
    if(!ZeroFlag) {
      goto label_1000_643F_1643F;
    }
    // INC DX (1000_643E / 0x1643E)
    DX = Alu.Inc16(DX);
    label_1000_643F_1643F:
    // CMP AL,0x10 (1000_643F / 0x1643F)
    Alu.Sub8(AL, 0x10);
    // JNZ 0x1000:6444 (1000_6441 / 0x16441)
    if(!ZeroFlag) {
      goto label_1000_6444_16444;
    }
    // INC DX (1000_6443 / 0x16443)
    DX = Alu.Inc16(DX);
    label_1000_6444_16444:
    // LOOP 0x1000:6434 (1000_6444 / 0x16444)
    if(--CX != 0) {
      goto label_1000_6434_16434;
    }
    // RET  (1000_6446 / 0x16446)
    return NearRet();
  }
  
  public Action split_1000_65B6_0165B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_65B6_165B6:
    // MOV ES,word ptr [0xdd00] (1000_65B6 / 0x165B6)
    ES = UInt16[DS, 0xDD00];
    // MOV SI,word ptr CS:[0x65b4] (1000_65BA / 0x165BA)
    SI = UInt16[cs1, 0x65B4];
    // XOR BP,BP (1000_65BF / 0x165BF)
    BP = 0;
    // MOV CX,0x46 (1000_65C1 / 0x165C1)
    CX = 0x46;
    label_1000_65C4_165C4:
    // SHR SI,0x1 (1000_65C4 / 0x165C4)
    // SI >>= 0x1;
    SI = Alu.Shr16(SI, 0x1);
    // JNC 0x1000:65cc (1000_65C6 / 0x165C6)
    if(!CarryFlag) {
      goto label_1000_65CC_165CC;
    }
    // XOR SI,0x402 (1000_65C8 / 0x165C8)
    // SI ^= 0x402;
    SI = Alu.Xor16(SI, 0x402);
    label_1000_65CC_165CC:
    // MOV DI,SI (1000_65CC / 0x165CC)
    DI = SI;
    label_1000_65CE_165CE:
    // MOV AL,byte ptr ES:[DI] (1000_65CE / 0x165CE)
    AL = UInt8[ES, DI];
    // MOV AH,AL (1000_65D1 / 0x165D1)
    AH = AL;
    // AND AH,0x30 (1000_65D3 / 0x165D3)
    AH &= 0x30;
    
    // CMP AH,0x10 (1000_65D6 / 0x165D6)
    Alu.Sub8(AH, 0x10);
    // JNZ 0x1000:65e2 (1000_65D9 / 0x165D9)
    if(!ZeroFlag) {
      goto label_1000_65E2_165E2;
    }
    // AND AL,0xcf (1000_65DB / 0x165DB)
    // AL &= 0xCF;
    AL = Alu.And8(AL, 0xCF);
    // OR AL,0x20 (1000_65DD / 0x165DD)
    // AL |= 0x20;
    AL = Alu.Or8(AL, 0x20);
    // STOSB ES:DI (1000_65DF / 0x165DF)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // DEC DI (1000_65E0 / 0x165E0)
    DI = Alu.Dec16(DI);
    // INC BP (1000_65E1 / 0x165E1)
    BP = Alu.Inc16(BP);
    label_1000_65E2_165E2:
    // ADD DI,0x7ff (1000_65E2 / 0x165E2)
    DI += 0x7FF;
    
    // CMP DI,0xc5f9 (1000_65E6 / 0x165E6)
    Alu.Sub16(DI, 0xC5F9);
    // JC 0x1000:65ce (1000_65EA / 0x165EA)
    if(CarryFlag) {
      goto label_1000_65CE_165CE;
    }
    // LOOP 0x1000:65c4 (1000_65EC / 0x165EC)
    if(--CX != 0) {
      goto label_1000_65C4_165C4;
    }
    // MOV word ptr CS:[0x65b4],SI (1000_65EE / 0x165EE)
    UInt16[cs1, 0x65B4] = SI;
    // OR BP,BP (1000_65F3 / 0x165F3)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JZ 0x1000:6602 (1000_65F5 / 0x165F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6602 / 0x16602)
      return NearRet();
    }
    // CMP byte ptr [0x46eb],0x0 (1000_65F7 / 0x165F7)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:6602 (1000_65FC / 0x165FC)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_6602 / 0x16602)
      return NearRet();
    }
    // INC byte ptr [0x46ec] (1000_65FE / 0x165FE)
    UInt8[DS, 0x46EC] = Alu.Inc8(UInt8[DS, 0x46EC]);
    label_1000_6602_16602:
    // RET  (1000_6602 / 0x16602)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6603_016603(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6603_16603:
    // PUSH SI (1000_6603 / 0x16603)
    Stack.Push(SI);
    // MOV AL,byte ptr [DI + 0x9] (1000_6604 / 0x16604)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    label_1000_6607_16607:
    // OR AL,AL (1000_6607 / 0x16607)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:661b (1000_6609 / 0x16609)
    if(ZeroFlag) {
      goto label_1000_661B_1661B;
    }
    // CALL 0x1000:6906 (1000_660B / 0x1660B)
    NearCall(cs1, 0x660E, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_660E_1660E:
    // PUSH SI (1000_660E / 0x1660E)
    Stack.Push(SI);
    // PUSH DI (1000_660F / 0x1660F)
    Stack.Push(DI);
    // PUSH BP (1000_6610 / 0x16610)
    Stack.Push(BP);
    // CALL BP (1000_6611 / 0x16611)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_6611 = (uint)(BP);
    switch(targetAddress_1000_6611) {
      case 0x1E0 : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_01E0_0101E0); break;
      case 0x316E : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_316E_01316E); break;
      case 0x3406 : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_3406_013406); break;
      case 0x34D0 : NearCall(cs1, 0x6613, spice86_generated_label_call_target_1000_34D0_0134D0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6611));
        break;
    }
    label_1000_6613_16613:
    // POP BP (1000_6613 / 0x16613)
    BP = Stack.Pop();
    // POP DI (1000_6614 / 0x16614)
    DI = Stack.Pop();
    // POP SI (1000_6615 / 0x16615)
    SI = Stack.Pop();
    // MOV AL,byte ptr [SI + 0x1] (1000_6616 / 0x16616)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // JMP 0x1000:6607 (1000_6619 / 0x16619)
    goto label_1000_6607_16607;
    label_1000_661B_1661B:
    // POP SI (1000_661B / 0x1661B)
    SI = Stack.Pop();
    // RET  (1000_661C / 0x1661C)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6639_016639(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6639_16639:
    // CALL 0x1000:6603 (1000_6639 / 0x16639)
    NearCall(cs1, 0x663C, spice86_generated_label_call_target_1000_6603_016603);
    label_1000_663C_1663C:
    // PUSH SI (1000_663C / 0x1663C)
    Stack.Push(SI);
    // MOV SI,0x8aa (1000_663D / 0x1663D)
    SI = 0x8AA;
    label_1000_6640_16640:
    // MOV AL,byte ptr [SI + 0x3] (1000_6640 / 0x16640)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST AL,0x40 (1000_6643 / 0x16643)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:6665 (1000_6645 / 0x16645)
    if(ZeroFlag) {
      goto label_1000_6665_16665;
    }
    // PUSH BX (1000_6647 / 0x16647)
    Stack.Push(BX);
    // MOV BX,word ptr [SI + 0x4] (1000_6648 / 0x16648)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // AND AL,0x3 (1000_664B / 0x1664B)
    AL &= 0x3;
    
    // CMP AL,0x3 (1000_664D / 0x1664D)
    Alu.Sub8(AL, 0x3);
    // JNZ 0x1000:6654 (1000_664F / 0x1664F)
    if(!ZeroFlag) {
      goto label_1000_6654_16654;
    }
    // MOV BX,word ptr [SI + 0xc] (1000_6651 / 0x16651)
    BX = UInt16[DS, (ushort)(SI + 0xC)];
    label_1000_6654_16654:
    // CMP BX,DI (1000_6654 / 0x16654)
    Alu.Sub16(BX, DI);
    // POP BX (1000_6656 / 0x16656)
    BX = Stack.Pop();
    // JNZ 0x1000:6665 (1000_6657 / 0x16657)
    if(!ZeroFlag) {
      goto label_1000_6665_16665;
    }
    // PUSH SI (1000_6659 / 0x16659)
    Stack.Push(SI);
    // PUSH DI (1000_665A / 0x1665A)
    Stack.Push(DI);
    // PUSH BP (1000_665B / 0x1665B)
    Stack.Push(BP);
    // CMP byte ptr [SI + 0x3],0x80 (1000_665C / 0x1665C)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // CALL BP (1000_6660 / 0x16660)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_6660 = (uint)(BP);
    switch(targetAddress_1000_6660) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6660));
        break;
    }
    // POP BP (1000_6662 / 0x16662)
    BP = Stack.Pop();
    // POP DI (1000_6663 / 0x16663)
    DI = Stack.Pop();
    // POP SI (1000_6664 / 0x16664)
    SI = Stack.Pop();
    label_1000_6665_16665:
    // ADD SI,0x1b (1000_6665 / 0x16665)
    SI += 0x1B;
    
    // CMP SI,0xfbb (1000_6668 / 0x16668)
    Alu.Sub16(SI, 0xFBB);
    // JC 0x1000:6640 (1000_666C / 0x1666C)
    if(CarryFlag) {
      goto label_1000_6640_16640;
    }
    // POP SI (1000_666E / 0x1666E)
    SI = Stack.Pop();
    // RET  (1000_666F / 0x1666F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6715_016715(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6715_16715:
    // MOV BP,0xa5c0 (1000_6715 / 0x16715)
    BP = 0xA5C0;
    label_1000_6718_16718:
    // MOV DI,word ptr [BP + 0x0] (1000_6718 / 0x16718)
    DI = UInt16[SS, BP];
    // OR DI,DI (1000_671B / 0x1671B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:6737 (1000_671D / 0x1671D)
    if(ZeroFlag) {
      goto label_1000_6737_16737;
    }
    // MOV AL,byte ptr [DI + 0x9] (1000_671F / 0x1671F)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // OR AL,AL (1000_6722 / 0x16722)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:6732 (1000_6724 / 0x16724)
    if(ZeroFlag) {
      goto label_1000_6732_16732;
    }
    label_1000_6726_16726:
    // PUSH BP (1000_6726 / 0x16726)
    Stack.Push(BP);
    // CALL 0x1000:6757 (1000_6727 / 0x16727)
    NearCall(cs1, 0x672A, spice86_generated_label_call_target_1000_6757_016757);
    label_1000_672A_1672A:
    // POP BP (1000_672A / 0x1672A)
    BP = Stack.Pop();
    // MOV AL,byte ptr [SI + 0x1] (1000_672B / 0x1672B)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // OR AL,AL (1000_672E / 0x1672E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:6726 (1000_6730 / 0x16730)
    if(!ZeroFlag) {
      goto label_1000_6726_16726;
    }
    label_1000_6732_16732:
    // ADD BP,0x6 (1000_6732 / 0x16732)
    // BP += 0x6;
    BP = Alu.Add16(BP, 0x6);
    // JMP 0x1000:6718 (1000_6735 / 0x16735)
    goto label_1000_6718_16718;
    label_1000_6737_16737:
    // MOV SI,0x88f (1000_6737 / 0x16737)
    SI = 0x88F;
    label_1000_673A_1673A:
    // ADD SI,0x1b (1000_673A / 0x1673A)
    SI += 0x1B;
    
    // CMP SI,0xfbb (1000_673D / 0x1673D)
    Alu.Sub16(SI, 0xFBB);
    // JNC 0x1000:6756 (1000_6741 / 0x16741)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6756 / 0x16756)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x10 (1000_6743 / 0x16743)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    // JNZ 0x1000:673a (1000_6747 / 0x16747)
    if(!ZeroFlag) {
      goto label_1000_673A_1673A;
    }
    // TEST byte ptr [SI + 0x3],0x40 (1000_6749 / 0x16749)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JZ 0x1000:673a (1000_674D / 0x1674D)
    if(ZeroFlag) {
      goto label_1000_673A_1673A;
    }
    // MOV AL,byte ptr [SI] (1000_674F / 0x1674F)
    AL = UInt8[DS, SI];
    // CALL 0x1000:6757 (1000_6751 / 0x16751)
    NearCall(cs1, 0x6754, spice86_generated_label_call_target_1000_6757_016757);
    // JMP 0x1000:673a (1000_6754 / 0x16754)
    goto label_1000_673A_1673A;
    label_1000_6756_16756:
    // RET  (1000_6756 / 0x16756)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6757_016757(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6757_16757:
    // CALL 0x1000:6906 (1000_6757 / 0x16757)
    NearCall(cs1, 0x675A, spice86_generated_label_call_target_1000_6906_016906);
    label_1000_675A_1675A:
    // CALL 0x1000:686e (1000_675A / 0x1675A)
    NearCall(cs1, 0x675D, spice86_generated_label_call_target_1000_686E_01686E);
    label_1000_675D_1675D:
    // JC 0x1000:676d (1000_675D / 0x1675D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_676D / 0x1676D)
      return NearRet();
    }
    // CALL 0x1000:6770 (1000_675F / 0x1675F)
    NearCall(cs1, 0x6762, spice86_generated_label_call_target_1000_6770_016770);
    label_1000_6762_16762:
    // CMP BP,0x1 (1000_6762 / 0x16762)
    Alu.Sub16(BP, 0x1);
    // JC 0x1000:676d (1000_6765 / 0x16765)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_676D / 0x1676D)
      return NearRet();
    }
    // PUSH SI (1000_6767 / 0x16767)
    Stack.Push(SI);
    // CALL 0x1000:c5cf (1000_6768 / 0x16768)
    throw FailAsUntested("Could not find a valid function at address 1000_C5CF / 0x1C5CF");
    // POP SI (1000_676B / 0x1676B)
    SI = Stack.Pop();
    // CLC  (1000_676C / 0x1676C)
    CarryFlag = false;
    label_1000_676D_1676D:
    // RET  (1000_676D / 0x1676D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6770_016770(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6770_16770:
    // TEST byte ptr [SI + 0x10],0x10 (1000_6770 / 0x16770)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    // JNZ 0x1000:678f (1000_6774 / 0x16774)
    if(!ZeroFlag) {
      goto label_1000_678F_1678F;
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_6776 / 0x16776)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST byte ptr [SI + 0x10],0x80 (1000_6779 / 0x16779)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:6792 (1000_677D / 0x1677D)
    if(!ZeroFlag) {
      goto label_1000_6792_16792;
    }
    // OR AL,AL (1000_677F / 0x1677F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:6792 (1000_6781 / 0x16781)
    if(!SignFlag) {
      goto label_1000_6792_16792;
    }
    // MOV BP,word ptr [SI + 0x4] (1000_6783 / 0x16783)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [BP + 0xa],0x10 (1000_6786 / 0x16786)
    Alu.And8(UInt8[SS, (ushort)(BP + 0xA)], 0x10);
    // MOV BP,0x181f (1000_678A / 0x1678A)
    BP = 0x181F;
    // JNZ 0x1000:6791 (1000_678D / 0x1678D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    label_1000_678F_1678F:
    // XOR BP,BP (1000_678F / 0x1678F)
    BP = 0;
    label_1000_6791_16791:
    // RET  (1000_6791 / 0x16791)
    return NearRet();
    label_1000_6792_16792:
    // TEST AL,0x40 (1000_6792 / 0x16792)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:6799 (1000_6794 / 0x16794)
    if(ZeroFlag) {
      goto label_1000_6799_16799;
    }
    // JMP 0x1000:6827 (1000_6796 / 0x16796)
    goto label_1000_6827_16827;
    label_1000_6799_16799:
    // TEST AL,0x30 (1000_6799 / 0x16799)
    Alu.And8(AL, 0x30);
    // JZ 0x1000:67c5 (1000_679B / 0x1679B)
    if(ZeroFlag) {
      goto label_1000_67C5_167C5;
    }
    // AND AX,0xf (1000_679D / 0x1679D)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV BP,AX (1000_67A0 / 0x167A0)
    BP = AX;
    // SHL BP,0x1 (1000_67A2 / 0x167A2)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x16b6] (1000_67A4 / 0x167A4)
    BP = UInt16[SS, (ushort)(BP + 0x16B6)];
    // OR AX,AX (1000_67A8 / 0x167A8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNZ 0x1000:67c4 (1000_67AA / 0x167AA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x19] (1000_67AC / 0x167AC)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // AND AL,0xc0 (1000_67AF / 0x167AF)
    // AL &= 0xC0;
    AL = Alu.And8(AL, 0xC0);
    // JZ 0x1000:67c4 (1000_67B1 / 0x167B1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV BP,0x1813 (1000_67B3 / 0x167B3)
    BP = 0x1813;
    // CMP AL,0x80 (1000_67B6 / 0x167B6)
    Alu.Sub8(AL, 0x80);
    // JZ 0x1000:67c4 (1000_67B8 / 0x167B8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV BP,0x1817 (1000_67BA / 0x167BA)
    BP = 0x1817;
    // CMP AL,0x40 (1000_67BD / 0x167BD)
    Alu.Sub8(AL, 0x40);
    // JZ 0x1000:67c4 (1000_67BF / 0x167BF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    // MOV BP,0x181b (1000_67C1 / 0x167C1)
    BP = 0x181B;
    label_1000_67C4_167C4:
    // RET  (1000_67C4 / 0x167C4)
    return NearRet();
    label_1000_67C5_167C5:
    // AND AX,0xf (1000_67C5 / 0x167C5)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // JZ 0x1000:680a (1000_67C8 / 0x167C8)
    if(ZeroFlag) {
      goto label_1000_680A_1680A;
    }
    label_1000_67CA_167CA:
    // MOV BP,AX (1000_67CA / 0x167CA)
    BP = AX;
    // SHL BP,0x1 (1000_67CC / 0x167CC)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x179c] (1000_67CE / 0x167CE)
    BP = UInt16[SS, (ushort)(BP + 0x179C)];
    // CMP BP,0x1774 (1000_67D2 / 0x167D2)
    Alu.Sub16(BP, 0x1774);
    // JZ 0x1000:67ed (1000_67D6 / 0x167D6)
    if(ZeroFlag) {
      goto label_1000_67ED_167ED;
    }
    // CMP BP,0x1732 (1000_67D8 / 0x167D8)
    Alu.Sub16(BP, 0x1732);
    // JNZ 0x1000:6791 (1000_67DC / 0x167DC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    // MOV BP,word ptr [SI + 0x4] (1000_67DE / 0x167DE)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [BP + 0xa],0x2 (1000_67E1 / 0x167E1)
    Alu.And8(UInt8[SS, (ushort)(BP + 0xA)], 0x2);
    // MOV BP,0x16aa (1000_67E5 / 0x167E5)
    BP = 0x16AA;
    // JNZ 0x1000:6791 (1000_67E8 / 0x167E8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    // MOV BP,0x1732 (1000_67EA / 0x167EA)
    BP = 0x1732;
    label_1000_67ED_167ED:
    // MOV AL,byte ptr [SI + 0x2] (1000_67ED / 0x167ED)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    // DEC AL (1000_67F0 / 0x167F0)
    AL = Alu.Dec8(AL);
    // AND AL,0x7 (1000_67F2 / 0x167F2)
    AL &= 0x7;
    
    // CMP AL,0x3 (1000_67F4 / 0x167F4)
    Alu.Sub8(AL, 0x3);
    // JC 0x1000:6809 (1000_67F6 / 0x167F6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    // ADD BP,0xa (1000_67F8 / 0x167F8)
    BP += 0xA;
    
    // CMP AL,0x3 (1000_67FB / 0x167FB)
    Alu.Sub8(AL, 0x3);
    // JZ 0x1000:6809 (1000_67FD / 0x167FD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    // ADD BP,0xa (1000_67FF / 0x167FF)
    BP += 0xA;
    
    // CMP AL,0x4 (1000_6802 / 0x16802)
    Alu.Sub8(AL, 0x4);
    // JZ 0x1000:6809 (1000_6804 / 0x16804)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    // ADD BP,0xa (1000_6806 / 0x16806)
    // BP += 0xA;
    BP = Alu.Add16(BP, 0xA);
    label_1000_6809_16809:
    // RET  (1000_6809 / 0x16809)
    return NearRet();
    label_1000_680A_1680A:
    // TEST byte ptr [SI + 0x19],0xc0 (1000_680A / 0x1680A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0xC0);
    // JZ 0x1000:67ca (1000_680E / 0x1680E)
    if(ZeroFlag) {
      goto label_1000_67CA_167CA;
    }
    // MOV AL,byte ptr [SI + 0x19] (1000_6810 / 0x16810)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // AND AL,0xc0 (1000_6813 / 0x16813)
    // AL &= 0xC0;
    AL = Alu.And8(AL, 0xC0);
    // MOV BP,0x17bc (1000_6815 / 0x16815)
    BP = 0x17BC;
    // CMP AL,0x80 (1000_6818 / 0x16818)
    Alu.Sub8(AL, 0x80);
    // JZ 0x1000:6826 (1000_681A / 0x1681A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6826 / 0x16826)
      return NearRet();
    }
    // MOV BP,0x17c9 (1000_681C / 0x1681C)
    BP = 0x17C9;
    // CMP AL,0x40 (1000_681F / 0x1681F)
    Alu.Sub8(AL, 0x40);
    // JZ 0x1000:6826 (1000_6821 / 0x16821)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6826 / 0x16826)
      return NearRet();
    }
    // MOV BP,0x1806 (1000_6823 / 0x16823)
    BP = 0x1806;
    label_1000_6826_16826:
    // RET  (1000_6826 / 0x16826)
    return NearRet();
    label_1000_6827_16827:
    // PUSH BX (1000_6827 / 0x16827)
    Stack.Push(BX);
    // PUSH DX (1000_6828 / 0x16828)
    Stack.Push(DX);
    // PUSH DI (1000_6829 / 0x16829)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_682A / 0x1682A)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [DI + 0x2] (1000_682D / 0x1682D)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_6830 / 0x16830)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // SUB AX,word ptr [SI + 0x6] (1000_6833 / 0x16833)
    // AX -= UInt16[DS, (ushort)(SI + 0x6)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    // MOV AL,AH (1000_6836 / 0x16836)
    AL = AH;
    // CBW  (1000_6838 / 0x16838)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_6839 / 0x16839)
    DX = AX;
    // MOV DI,DX (1000_683B / 0x1683B)
    DI = DX;
    // JNS 0x1000:6841 (1000_683D / 0x1683D)
    if(!SignFlag) {
      goto label_1000_6841_16841;
    }
    // NEG DI (1000_683F / 0x1683F)
    DI = Alu.Sub16(0, DI);
    label_1000_6841_16841:
    // SUB BX,word ptr [SI + 0x8] (1000_6841 / 0x16841)
    // BX -= UInt16[DS, (ushort)(SI + 0x8)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x8)]);
    // MOV CX,BX (1000_6844 / 0x16844)
    CX = BX;
    // JNS 0x1000:684a (1000_6846 / 0x16846)
    if(!SignFlag) {
      goto label_1000_684A_1684A;
    }
    // NEG CX (1000_6848 / 0x16848)
    CX = Alu.Sub16(0, CX);
    label_1000_684A_1684A:
    // MOV BP,0x2 (1000_684A / 0x1684A)
    BP = 0x2;
    // CMP DI,CX (1000_684D / 0x1684D)
    Alu.Sub16(DI, CX);
    // JC 0x1000:6854 (1000_684F / 0x1684F)
    if(CarryFlag) {
      goto label_1000_6854_16854;
    }
    // DEC BP (1000_6851 / 0x16851)
    BP = Alu.Dec16(BP);
    // XCHG BX,DX (1000_6852 / 0x16852)
    ushort tmp_1000_6852 = BX;
    BX = DX;
    DX = tmp_1000_6852;
    label_1000_6854_16854:
    // OR BX,BX (1000_6854 / 0x16854)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNS 0x1000:685b (1000_6856 / 0x16856)
    if(!SignFlag) {
      goto label_1000_685B_1685B;
    }
    // XOR BP,0x2 (1000_6858 / 0x16858)
    // BP ^= 0x2;
    BP = Alu.Xor16(BP, 0x2);
    label_1000_685B_1685B:
    // CALL 0x1000:693b (1000_685B / 0x1685B)
    throw FailAsUntested("Could not find a valid function at address 1000_693B / 0x1693B");
    // SHL AX,0x1 (1000_685E / 0x1685E)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_6860 / 0x16860)
    AX <<= 0x1;
    
    // ADD BP,AX (1000_6862 / 0x16862)
    BP += AX;
    
    // SHL BP,0x1 (1000_6864 / 0x16864)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x18bf] (1000_6866 / 0x16866)
    BP = UInt16[SS, (ushort)(BP + 0x18BF)];
    // POP DI (1000_686A / 0x1686A)
    DI = Stack.Pop();
    // POP DX (1000_686B / 0x1686B)
    DX = Stack.Pop();
    // POP BX (1000_686C / 0x1686C)
    BX = Stack.Pop();
    // RET  (1000_686D / 0x1686D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_686E_01686E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_686E_1686E:
    // CMP byte ptr [0x46eb],0x80 (1000_686E / 0x1686E)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x80);
    // JC 0x1000:68ae (1000_6873 / 0x16873)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_68AE / 0x168AE)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x3],0x40 (1000_6875 / 0x16875)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:68af (1000_6879 / 0x16879)
    if(!ZeroFlag) {
      goto label_1000_68AF_168AF;
    }
    // MOV BL,byte ptr [SI + 0x2] (1000_687B / 0x1687B)
    BL = UInt8[DS, (ushort)(SI + 0x2)];
    // DEC BX (1000_687E / 0x1687E)
    BX = Alu.Dec16(BX);
    // PUSH DI (1000_687F / 0x1687F)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_6880 / 0x16880)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // TEST byte ptr [DI + 0xa],0x2 (1000_6883 / 0x16883)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JZ 0x1000:688c (1000_6887 / 0x16887)
    if(ZeroFlag) {
      goto label_1000_688C_1688C;
    }
    // XOR BL,0x8 (1000_6889 / 0x16889)
    // BL ^= 0x8;
    BL = Alu.Xor8(BL, 0x8);
    label_1000_688C_1688C:
    // POP DI (1000_688C / 0x1688C)
    DI = Stack.Pop();
    // AND BX,0xf (1000_688D / 0x1688D)
    BX &= 0xF;
    
    // ADD BX,BX (1000_6890 / 0x16890)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    // MOV AL,byte ptr [BX + 0x1672] (1000_6892 / 0x16892)
    AL = UInt8[DS, (ushort)(BX + 0x1672)];
    // CBW  (1000_6896 / 0x16896)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_6897 / 0x16897)
    DX = AX;
    // MOV AL,byte ptr [BX + 0x1673] (1000_6899 / 0x16899)
    AL = UInt8[DS, (ushort)(BX + 0x1673)];
    // CBW  (1000_689D / 0x1689D)
    AX = (ushort)((short)((sbyte)AL));
    // ADD DX,word ptr [BP + 0x2] (1000_689E / 0x1689E)
    // DX += UInt16[SS, (ushort)(BP + 0x2)];
    DX = Alu.Add16(DX, UInt16[SS, (ushort)(BP + 0x2)]);
    // MOV BX,word ptr [BP + 0x4] (1000_68A1 / 0x168A1)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    // CMP BH,0x80 (1000_68A4 / 0x168A4)
    Alu.Sub8(BH, 0x80);
    // JC 0x1000:68ae (1000_68A7 / 0x168A7)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_68AE / 0x168AE)
      return NearRet();
    }
    // XOR BH,BH (1000_68A9 / 0x168A9)
    BH = 0;
    // ADD BX,AX (1000_68AB / 0x168AB)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // CLC  (1000_68AD / 0x168AD)
    CarryFlag = false;
    label_1000_68AE_168AE:
    // RET  (1000_68AE / 0x168AE)
    return NearRet();
    label_1000_68AF_168AF:
    // MOV DX,word ptr [SI + 0x6] (1000_68AF / 0x168AF)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV BX,word ptr [SI + 0x8] (1000_68B2 / 0x168B2)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    // CALL 0x1000:b647 (1000_68B5 / 0x168B5)
    NearCall(cs1, 0x68B8, spice86_generated_label_call_target_1000_B647_01B647);
    // CMP DX,-0x10 (1000_68B8 / 0x168B8)
    Alu.Sub16(DX, 0xFFF0);
    // JLE 0x1000:68d0 (1000_68BB / 0x168BB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CMP BX,-0x10 (1000_68BD / 0x168BD)
    Alu.Sub16(BX, 0xFFF0);
    // JLE 0x1000:68d0 (1000_68C0 / 0x168C0)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CMP DX,0x148 (1000_68C2 / 0x168C2)
    Alu.Sub16(DX, 0x148);
    // JGE 0x1000:68d0 (1000_68C6 / 0x168C6)
    if(SignFlag == OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CMP BX,0xa0 (1000_68C8 / 0x168C8)
    Alu.Sub16(BX, 0xA0);
    // JGE 0x1000:68d0 (1000_68CC / 0x168CC)
    if(SignFlag == OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    // CLC  (1000_68CE / 0x168CE)
    CarryFlag = false;
    // RET  (1000_68CF / 0x168CF)
    return NearRet();
    label_1000_68D0_168D0:
    // STC  (1000_68D0 / 0x168D0)
    CarryFlag = true;
    // RET  (1000_68D1 / 0x168D1)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6906_016906(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6906_16906:
    // MOV SI,AX (1000_6906 / 0x16906)
    SI = AX;
    // DEC AL (1000_6908 / 0x16908)
    AL = Alu.Dec8(AL);
    // MOV AH,0x1b (1000_690A / 0x1690A)
    AH = 0x1B;
    // MUL AH (1000_690C / 0x1690C)
    Cpu.Mul8(AH);
    // ADD AX,0x8aa (1000_690E / 0x1690E)
    // AX += 0x8AA;
    AX = Alu.Add16(AX, 0x8AA);
    // XCHG AX,SI (1000_6911 / 0x16911)
    ushort tmp_1000_6911 = AX;
    AX = SI;
    SI = tmp_1000_6911;
    label_1000_6912_16912:
    // CMP byte ptr [SI + 0x3],0x80 (1000_6912 / 0x16912)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // RET  (1000_6916 / 0x16916)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6B34_016B34(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6B34_16B34:
    // INC byte ptr [0x46f6] (1000_6B34 / 0x16B34)
    UInt8[DS, 0x46F6] = Alu.Inc8(UInt8[DS, 0x46F6]);
    // MOV AL,[0x46f6] (1000_6B38 / 0x16B38)
    AL = UInt8[DS, 0x46F6];
    // AND AL,0x3 (1000_6B3B / 0x16B3B)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    // JZ 0x1000:6b4b (1000_6B3D / 0x16B3D)
    if(ZeroFlag) {
      goto label_1000_6B4B_16B4B;
    }
    // MOV CX,0x1 (1000_6B3F / 0x16B3F)
    CX = 0x1;
    // MOV DI,word ptr [0x4752] (1000_6B42 / 0x16B42)
    DI = UInt16[DS, 0x4752];
    // OR DI,DI (1000_6B46 / 0x16B46)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:6b55 (1000_6B48 / 0x16B48)
    if(!ZeroFlag) {
      goto label_1000_6B55_16B55;
    }
    // RET  (1000_6B4A / 0x16B4A)
    return NearRet();
    label_1000_6B4B_16B4B:
    // MOV SI,0x3cbe (1000_6B4B / 0x16B4B)
    SI = 0x3CBE;
    // LODSW SI (1000_6B4E / 0x16B4E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_6B4F / 0x16B4F)
    CX = AX;
    // JCXZ 0x1000:6b89 (1000_6B51 / 0x16B51)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_6B89 / 0x16B89)
      return NearRet();
    }
    // MOV DI,SI (1000_6B53 / 0x16B53)
    DI = SI;
    label_1000_6B55_16B55:
    // TEST byte ptr [DI + 0xc],0x1 (1000_6B55 / 0x16B55)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x1);
    // JZ 0x1000:6b84 (1000_6B59 / 0x16B59)
    if(ZeroFlag) {
      goto label_1000_6B84_16B84;
    }
    // MOV SI,word ptr [DI + 0xd] (1000_6B5B / 0x16B5B)
    SI = UInt16[DS, (ushort)(DI + 0xD)];
    // LODSB SI (1000_6B5E / 0x16B5E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_6B5F / 0x16B5F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:6b6d (1000_6B61 / 0x16B61)
    if(!ZeroFlag) {
      goto label_1000_6B6D_16B6D;
    }
    // MOV SI,word ptr [DI + 0xf] (1000_6B63 / 0x16B63)
    SI = UInt16[DS, (ushort)(DI + 0xF)];
    // LODSB SI (1000_6B66 / 0x16B66)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST byte ptr [DI + 0xc],0x2 (1000_6B67 / 0x16B67)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x2);
    // JNZ 0x1000:6b84 (1000_6B6B / 0x16B6B)
    if(!ZeroFlag) {
      goto label_1000_6B84_16B84;
    }
    label_1000_6B6D_16B6D:
    // XOR AH,AH (1000_6B6D / 0x16B6D)
    AH = 0;
    // MOV word ptr [DI + 0x8],AX (1000_6B6F / 0x16B6F)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    // LODSB SI (1000_6B72 / 0x16B72)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_6B73 / 0x16B73)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_6B74 / 0x16B74)
    DX = AX;
    // LODSB SI (1000_6B76 / 0x16B76)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_6B77 / 0x16B77)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BX,AX (1000_6B78 / 0x16B78)
    BX = AX;
    // MOV word ptr [DI + 0xd],SI (1000_6B7A / 0x16B7A)
    UInt16[DS, (ushort)(DI + 0xD)] = SI;
    // PUSH CX (1000_6B7D / 0x16B7D)
    Stack.Push(CX);
    // PUSH DI (1000_6B7E / 0x16B7E)
    Stack.Push(DI);
    // CALL 0x1000:c661 (1000_6B7F / 0x16B7F)
    throw FailAsUntested("Could not find a valid function at address 1000_C661 / 0x1C661");
    // POP DI (1000_6B82 / 0x16B82)
    DI = Stack.Pop();
    // POP CX (1000_6B83 / 0x16B83)
    CX = Stack.Pop();
    label_1000_6B84_16B84:
    // ADD DI,0x11 (1000_6B84 / 0x16B84)
    // DI += 0x11;
    DI = Alu.Add16(DI, 0x11);
    // LOOP 0x1000:6b55 (1000_6B87 / 0x16B87)
    if(--CX != 0) {
      goto label_1000_6B55_16B55;
    }
    label_1000_6B89_16B89:
    // RET  (1000_6B89 / 0x16B89)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6C46_016C46(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6C46_16C46:
    // MOV AL,[0x2a] (1000_6C46 / 0x16C46)
    AL = UInt8[DS, 0x2A];
    // SUB AL,0x2d (1000_6C49 / 0x16C49)
    AL -= 0x2D;
    
    // CMP AL,0x3 (1000_6C4B / 0x16C4B)
    Alu.Sub8(AL, 0x3);
    // JNC 0x1000:6c6e (1000_6C4D / 0x16C4D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // TEST word ptr [0x10],0x10 (1000_6C4F / 0x16C4F)
    Alu.And16(UInt16[DS, 0x10], 0x10);
    // JNZ 0x1000:6c6e (1000_6C55 / 0x16C55)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // MOV DI,word ptr [0x473c] (1000_6C57 / 0x16C57)
    DI = UInt16[DS, 0x473C];
    // OR DI,DI (1000_6C5B / 0x16C5B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:6c6e (1000_6C5D / 0x16C5D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // CALL 0x1000:331e (1000_6C5F / 0x16C5F)
    NearCall(cs1, 0x6C62, spice86_generated_label_call_target_1000_331E_01331E);
    // CMP byte ptr [0x66],0x0 (1000_6C62 / 0x16C62)
    Alu.Sub8(UInt8[DS, 0x66], 0x0);
    // JZ 0x1000:6c6e (1000_6C67 / 0x16C67)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    // MOV AL,0x30 (1000_6C69 / 0x16C69)
    AL = 0x30;
    // JMP 0x1000:121f (1000_6C6B / 0x16C6B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_121F_01121F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6C6E_16C6E:
    // RET  (1000_6C6E / 0x16C6E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6C6F_016C6F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6C6F_16C6F:
    // XOR SI,SI (1000_6C6F / 0x16C6F)
    SI = 0;
    // MOV AX,[0x101a] (1000_6C71 / 0x16C71)
    AX = UInt16[DS, 0x101A];
    // CMP AL,0x80 (1000_6C74 / 0x16C74)
    Alu.Sub8(AL, 0x80);
    // JNZ 0x1000:6c83 (1000_6C76 / 0x16C76)
    if(!ZeroFlag) {
      goto label_1000_6C83_16C83;
    }
    // MOV AL,0x1c (1000_6C78 / 0x16C78)
    AL = 0x1C;
    // DEC AH (1000_6C7A / 0x16C7A)
    AH = Alu.Dec8(AH);
    // MUL AH (1000_6C7C / 0x16C7C)
    Cpu.Mul8(AH);
    // ADD AX,0x100 (1000_6C7E / 0x16C7E)
    // AX += 0x100;
    AX = Alu.Add16(AX, 0x100);
    // MOV SI,AX (1000_6C81 / 0x16C81)
    SI = AX;
    label_1000_6C83_16C83:
    // MOV word ptr [0x473c],SI (1000_6C83 / 0x16C83)
    UInt16[DS, 0x473C] = SI;
    // CALL 0x1000:6c46 (1000_6C87 / 0x16C87)
    NearCall(cs1, 0x6C8A, spice86_generated_label_call_target_1000_6C46_016C46);
    label_1000_6C8A_16C8A:
    // MOV byte ptr [0x4737],0x0 (1000_6C8A / 0x16C8A)
    UInt8[DS, 0x4737] = 0x0;
    // MOV SI,0x8aa (1000_6C8F / 0x16C8F)
    SI = 0x8AA;
    label_1000_6C92_16C92:
    // TEST word ptr [SI + 0x12],0x430 (1000_6C92 / 0x16C92)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x430);
    // JNZ 0x1000:6cd3 (1000_6C97 / 0x16C97)
    if(!ZeroFlag) {
      goto label_1000_6CD3_16CD3;
    }
    // CMP byte ptr [SI + 0x1a],0x14 (1000_6C99 / 0x16C99)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x14);
    // JNC 0x1000:6ca4 (1000_6C9D / 0x16C9D)
    if(!CarryFlag) {
      goto label_1000_6CA4_16CA4;
    }
    // CALL 0x1000:6d19 (1000_6C9F / 0x16C9F)
    NearCall(cs1, 0x6CA2, spice86_generated_label_call_target_1000_6D19_016D19);
    label_1000_6CA2_16CA2:
    // JC 0x1000:6cc3 (1000_6CA2 / 0x16CA2)
    if(CarryFlag) {
      goto label_1000_6CC3_16CC3;
    }
    label_1000_6CA4_16CA4:
    // MOV AL,byte ptr [SI + 0x3] (1000_6CA4 / 0x16CA4)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST AL,0xa0 (1000_6CA7 / 0x16CA7)
    Alu.And8(AL, 0xA0);
    // JNZ 0x1000:6cc3 (1000_6CA9 / 0x16CA9)
    if(!ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // TEST AL,0x40 (1000_6CAB / 0x16CAB)
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:6ced (1000_6CAD / 0x16CAD)
    if(!ZeroFlag) {
      goto label_1000_6CED_16CED;
    }
    // AND AX,0xf (1000_6CAF / 0x16CAF)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV BX,AX (1000_6CB2 / 0x16CB2)
    BX = AX;
    // SHL BX,0x1 (1000_6CB4 / 0x16CB4)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // PUSH SI (1000_6CB6 / 0x16CB6)
    Stack.Push(SI);
    // MOV DI,word ptr [SI + 0x4] (1000_6CB7 / 0x16CB7)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL word ptr CS:[BX + 0x6c26] (1000_6CBA / 0x16CBA)
    // Indirect call to word ptr CS:[BX + 0x6c26], generating possible targets from emulator records
    uint targetAddress_1000_6CBA = (uint)(UInt16[cs1, (ushort)(BX + 0x6C26)]);
    switch(targetAddress_1000_6CBA) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6CBA));
        break;
    }
    // POP SI (1000_6CBF / 0x16CBF)
    SI = Stack.Pop();
    // CALL 0x1000:6d7b (1000_6CC0 / 0x16CC0)
    throw FailAsUntested("Could not find a valid function at address 1000_6D7B / 0x16D7B");
    label_1000_6CC3_16CC3:
    // ADD SI,0x1b (1000_6CC3 / 0x16CC3)
    SI += 0x1B;
    
    // CMP SI,0xfbb (1000_6CC6 / 0x16CC6)
    Alu.Sub16(SI, 0xFBB);
    // JC 0x1000:6c92 (1000_6CCA / 0x16CCA)
    if(CarryFlag) {
      goto label_1000_6C92_16C92;
    }
    // MOV AL,[0x4737] (1000_6CCC / 0x16CCC)
    AL = UInt8[DS, 0x4737];
    // MOV [0xfa],AL (1000_6CCF / 0x16CCF)
    UInt8[DS, 0xFA] = AL;
    // RET  (1000_6CD2 / 0x16CD2)
    return NearRet();
    label_1000_6CD3_16CD3:
    // TEST byte ptr [SI + 0x3],0x40 (1000_6CD3 / 0x16CD3)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:6ced (1000_6CD7 / 0x16CD7)
    if(!ZeroFlag) {
      goto label_1000_6CED_16CED;
    }
    // CMP byte ptr [0xfa],0x0 (1000_6CD9 / 0x16CD9)
    Alu.Sub8(UInt8[DS, 0xFA], 0x0);
    // JZ 0x1000:6cc3 (1000_6CDE / 0x16CDE)
    if(ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // AND byte ptr [SI + 0x12],0xcf (1000_6CE0 / 0x16CE0)
    UInt8[DS, (ushort)(SI + 0x12)] &= 0xCF;
    
    // TEST word ptr [SI + 0x12],0x400 (1000_6CE4 / 0x16CE4)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x400);
    // JNZ 0x1000:6cc3 (1000_6CE9 / 0x16CE9)
    if(!ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // JMP 0x1000:6c92 (1000_6CEB / 0x16CEB)
    goto label_1000_6C92_16C92;
    label_1000_6CED_16CED:
    // MOV AL,byte ptr [SI] (1000_6CED / 0x16CED)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [0x1954] (1000_6CEF / 0x16CEF)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    // JZ 0x1000:6cc3 (1000_6CF3 / 0x16CF3)
    if(ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    // PUSH SI (1000_6CF5 / 0x16CF5)
    Stack.Push(SI);
    // CALL 0x1000:8308 (1000_6CF6 / 0x16CF6)
    throw FailAsUntested("Could not find a valid function at address 1000_8308 / 0x18308");
    // POP SI (1000_6CF9 / 0x16CF9)
    SI = Stack.Pop();
    // JMP 0x1000:6cc3 (1000_6CFA / 0x16CFA)
    goto label_1000_6CC3_16CC3;
  }
  
  public Action spice86_generated_label_call_target_1000_6D19_016D19(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6D19_16D19:
    // TEST byte ptr [SI + 0x3],0xe3 (1000_6D19 / 0x16D19)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xE3);
    // JNZ 0x1000:6d5e (1000_6D1D / 0x16D1D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_6D1F / 0x16D1F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:6d5e (1000_6D23 / 0x16D23)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // CMP SI,0x8e0 (1000_6D25 / 0x16D25)
    Alu.Sub16(SI, 0x8E0);
    // JZ 0x1000:6d5e (1000_6D29 / 0x16D29)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // MOV DI,word ptr [SI + 0x4] (1000_6D2B / 0x16D2B)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // XOR BX,BX (1000_6D2E / 0x16D2E)
    BX = 0;
    // MOV CL,byte ptr [SI + 0x1a] (1000_6D30 / 0x16D30)
    CL = UInt8[DS, (ushort)(SI + 0x1A)];
    // NOT CL (1000_6D33 / 0x16D33)
    CL = (byte)~CL;
    // MOV DX,SI (1000_6D35 / 0x16D35)
    DX = SI;
    // MOV BP,0x6d5f (1000_6D37 / 0x16D37)
    BP = 0x6D5F;
    // CALL 0x1000:661d (1000_6D3A / 0x16D3A)
    throw FailAsUntested("Could not find a valid function at address 1000_661D / 0x1661D");
    // OR BX,BX (1000_6D3D / 0x16D3D)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:6d5e (1000_6D3F / 0x16D3F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x1a] (1000_6D41 / 0x16D41)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    // ADD byte ptr [BX + 0x1a],AL (1000_6D44 / 0x16D44)
    // UInt8[DS, (ushort)(BX + 0x1A)] += AL;
    UInt8[DS, (ushort)(BX + 0x1A)] = Alu.Add8(UInt8[DS, (ushort)(BX + 0x1A)], AL);
    // MOV AL,byte ptr [SI + 0x19] (1000_6D47 / 0x16D47)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // MOV AH,AL (1000_6D4A / 0x16D4A)
    AH = AL;
    // AND AL,byte ptr [BX + 0x19] (1000_6D4C / 0x16D4C)
    // AL &= UInt8[DS, (ushort)(BX + 0x19)];
    AL = Alu.And8(AL, UInt8[DS, (ushort)(BX + 0x19)]);
    // MOV byte ptr [SI + 0x19],AL (1000_6D4F / 0x16D4F)
    UInt8[DS, (ushort)(SI + 0x19)] = AL;
    // OR byte ptr [BX + 0x19],AH (1000_6D52 / 0x16D52)
    // UInt8[DS, (ushort)(BX + 0x19)] |= AH;
    UInt8[DS, (ushort)(BX + 0x19)] = Alu.Or8(UInt8[DS, (ushort)(BX + 0x19)], AH);
    // OR word ptr [BX + 0x12],0x200 (1000_6D55 / 0x16D55)
    // UInt16[DS, (ushort)(BX + 0x12)] |= 0x200;
    UInt16[DS, (ushort)(BX + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(BX + 0x12)], 0x200);
    // CALL 0x1000:66b1 (1000_6D5A / 0x16D5A)
    throw FailAsUntested("Could not find a valid function at address 1000_66B1 / 0x166B1");
    // STC  (1000_6D5D / 0x16D5D)
    CarryFlag = true;
    label_1000_6D5E_16D5E:
    // RET  (1000_6D5E / 0x16D5E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_6EFD_016EFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_6EFD_16EFD:
    // MOV AH,byte ptr [SI + 0x3] (1000_6EFD / 0x16EFD)
    AH = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AH,0xf (1000_6F00 / 0x16F00)
    // AH &= 0xF;
    AH = Alu.And8(AH, 0xF);
    // MOV AL,byte ptr [SI + 0x15] (1000_6F03 / 0x16F03)
    AL = UInt8[DS, (ushort)(SI + 0x15)];
    // CMP byte ptr [0xfa],0x0 (1000_6F06 / 0x16F06)
    Alu.Sub8(UInt8[DS, 0xFA], 0x0);
    // JZ 0x1000:6f0f (1000_6F0B / 0x16F0B)
    if(ZeroFlag) {
      goto label_1000_6F0F_16F0F;
    }
    // ADD AL,0x14 (1000_6F0D / 0x16F0D)
    AL += 0x14;
    
    label_1000_6F0F_16F0F:
    // CMP AH,0x6 (1000_6F0F / 0x16F0F)
    Alu.Sub8(AH, 0x6);
    // JNZ 0x1000:6f23 (1000_6F12 / 0x16F12)
    if(!ZeroFlag) {
      goto label_1000_6F23_16F23;
    }
    // PUSH DI (1000_6F14 / 0x16F14)
    Stack.Push(DI);
    // MOV DI,word ptr [SI + 0x4] (1000_6F15 / 0x16F15)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // CMP DI,word ptr [0x114e] (1000_6F18 / 0x16F18)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // POP DI (1000_6F1C / 0x16F1C)
    DI = Stack.Pop();
    // JNZ 0x1000:6f31 (1000_6F1D / 0x16F1D)
    if(!ZeroFlag) {
      goto label_1000_6F31_16F31;
    }
    // ADD AL,0x1e (1000_6F1F / 0x16F1F)
    // AL += 0x1E;
    AL = Alu.Add8(AL, 0x1E);
    // JMP 0x1000:6f2b (1000_6F21 / 0x16F21)
    goto label_1000_6F2B_16F2B;
    label_1000_6F23_16F23:
    // AND AH,0xfe (1000_6F23 / 0x16F23)
    AH &= 0xFE;
    
    // CMP AH,0x8 (1000_6F26 / 0x16F26)
    Alu.Sub8(AH, 0x8);
    // JZ 0x1000:6f2f (1000_6F29 / 0x16F29)
    if(ZeroFlag) {
      goto label_1000_6F2F_16F2F;
    }
    label_1000_6F2B_16F2B:
    // CMP AL,0x64 (1000_6F2B / 0x16F2B)
    Alu.Sub8(AL, 0x64);
    // JC 0x1000:6f31 (1000_6F2D / 0x16F2D)
    if(CarryFlag) {
      goto label_1000_6F31_16F31;
    }
    label_1000_6F2F_16F2F:
    // MOV AL,0x64 (1000_6F2F / 0x16F2F)
    AL = 0x64;
    label_1000_6F31_16F31:
    // CMP byte ptr [0x2a],0x64 (1000_6F31 / 0x16F31)
    Alu.Sub8(UInt8[DS, 0x2A], 0x64);
    // JC 0x1000:6f47 (1000_6F36 / 0x16F36)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    // CMP byte ptr [0x2a],0x68 (1000_6F38 / 0x16F38)
    Alu.Sub8(UInt8[DS, 0x2A], 0x68);
    // JNC 0x1000:6f47 (1000_6F3D / 0x16F3D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    // SUB AL,0x28 (1000_6F3F / 0x16F3F)
    AL -= 0x28;
    
    // CMP AL,0xa (1000_6F41 / 0x16F41)
    Alu.Sub8(AL, 0xA);
    // JGE 0x1000:6f47 (1000_6F43 / 0x16F43)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    // MOV AL,0xa (1000_6F45 / 0x16F45)
    AL = 0xA;
    label_1000_6F47_16F47:
    // RET  (1000_6F47 / 0x16F47)
    return NearRet();
  }
  
  public Action split_1000_71B2_0171B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_71B2_171B2:
    // MOV AH,0xf (1000_71B2 / 0x171B2)
    AH = 0xF;
    // PUSH SI (1000_71B4 / 0x171B4)
    Stack.Push(SI);
    // PUSH DI (1000_71B5 / 0x171B5)
    Stack.Push(DI);
    // CALL 0x1000:29f0 (1000_71B6 / 0x171B6)
    throw FailAsUntested("Could not find a valid function at address 1000_29F0 / 0x129F0");
    // POP DI (1000_71B9 / 0x171B9)
    DI = Stack.Pop();
    // POP SI (1000_71BA / 0x171BA)
    SI = Stack.Pop();
    // RET  (1000_71BB / 0x171BB)
    return NearRet();
  }
  
  public Action map_func_ida_1000_739E_1739E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_739E_1739E:
    // OR byte ptr [0x11bc],0x1 (1000_739E / 0x1739E)
    UInt8[DS, 0x11BC] |= 0x1;
    
    // CMP DI,0x11c (1000_73A3 / 0x173A3)
    Alu.Sub16(DI, 0x11C);
    // JNZ 0x1000:73d9 (1000_73A7 / 0x173A7)
    if(!ZeroFlag) {
      goto label_1000_73D9_173D9;
    }
    // INC byte ptr [0xc2] (1000_73A9 / 0x173A9)
    UInt8[DS, 0xC2] = Alu.Inc8(UInt8[DS, 0xC2]);
    // MOV BP,0x7399 (1000_73AD / 0x173AD)
    BP = 0x7399;
    // CALL 0x1000:661d (1000_73B0 / 0x173B0)
    throw FailAsUntested("Could not find a valid function at address 1000_661D / 0x1661D");
    // CALL 0x1000:6e02 (1000_73B3 / 0x173B3)
    throw FailAsUntested("Could not find a valid function at address 1000_6E02 / 0x16E02");
    // LES DI,[0xdcfe] (1000_73B6 / 0x173B6)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    // XOR DI,DI (1000_73BA / 0x173BA)
    DI = 0;
    // MOV CX,0xc5f9 (1000_73BC / 0x173BC)
    CX = 0xC5F9;
    label_1000_73BF_173BF:
    // MOV AL,byte ptr ES:[DI] (1000_73BF / 0x173BF)
    AL = UInt8[ES, DI];
    // MOV AH,AL (1000_73C2 / 0x173C2)
    AH = AL;
    // AND AH,0x30 (1000_73C4 / 0x173C4)
    AH &= 0x30;
    
    // CMP AH,0x30 (1000_73C7 / 0x173C7)
    Alu.Sub8(AH, 0x30);
    // JNZ 0x1000:73ce (1000_73CA / 0x173CA)
    if(!ZeroFlag) {
      goto label_1000_73CE_173CE;
    }
    // AND AL,0xef (1000_73CC / 0x173CC)
    // AL &= 0xEF;
    AL = Alu.And8(AL, 0xEF);
    label_1000_73CE_173CE:
    // STOSB ES:DI (1000_73CE / 0x173CE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x1000:73bf (1000_73CF / 0x173CF)
    if(--CX != 0) {
      goto label_1000_73BF_173BF;
    }
    // MOV AL,0xa (1000_73D1 / 0x173D1)
    AL = 0xA;
    // MOV DI,0x11c (1000_73D3 / 0x173D3)
    DI = 0x11C;
    // JMP 0x1000:71b2 (1000_73D6 / 0x173D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_73D9_173D9:
    // CALL 0x1000:33be (1000_73D9 / 0x173D9)
    NearCall(cs1, 0x73DC, spice86_generated_label_call_target_1000_33BE_0133BE);
    // CMP word ptr [0x94],0x0 (1000_73DC / 0x173DC)
    Alu.Sub16(UInt16[DS, 0x94], 0x0);
    // JZ 0x1000:7429 (1000_73E1 / 0x173E1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7429_017429, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:e3cc (1000_73E3 / 0x173E3)
    NearCall(cs1, 0x73E6, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    // CMP AL,byte ptr [0x9c] (1000_73E6 / 0x173E6)
    Alu.Sub8(AL, UInt8[DS, 0x9C]);
    // JC 0x1000:73ef (1000_73EA / 0x173EA)
    if(CarryFlag) {
      goto label_1000_73EF_173EF;
    }
    // JMP 0x1000:751d (1000_73EC / 0x173EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_751D_01751D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_73EF_173EF:
    // CALL 0x1000:5098 (1000_73EF / 0x173EF)
    throw FailAsUntested("Could not find a valid function at address 1000_5098 / 0x15098");
    // PUSH CX (1000_73F2 / 0x173F2)
    Stack.Push(CX);
    // CALL 0x1000:342d (1000_73F3 / 0x173F3)
    NearCall(cs1, 0x73F6, spice86_generated_label_call_target_1000_342D_01342D);
    // POP CX (1000_73F6 / 0x173F6)
    CX = Stack.Pop();
    // JCXZ 0x1000:73fd (1000_73F7 / 0x173F7)
    if(CX == 0) {
      goto label_1000_73FD_173FD;
    }
    // XOR DX,DX (1000_73F9 / 0x173F9)
    DX = 0;
    // DIV CX (1000_73FB / 0x173FB)
    Cpu.Div16(CX);
    label_1000_73FD_173FD:
    // MOV DL,AL (1000_73FD / 0x173FD)
    DL = AL;
    // INC DL (1000_73FF / 0x173FF)
    DL = Alu.Inc8(DL);
    // JNZ 0x1000:7405 (1000_7401 / 0x17401)
    if(!ZeroFlag) {
      goto label_1000_7405_17405;
    }
    // DEC DL (1000_7403 / 0x17403)
    DL = Alu.Dec8(DL);
    label_1000_7405_17405:
    // XOR DH,DH (1000_7405 / 0x17405)
    DH = 0;
    // XOR CX,CX (1000_7407 / 0x17407)
    CX = 0;
    // XOR BX,BX (1000_7409 / 0x17409)
    BX = 0;
    // MOV BP,0x7552 (1000_740B / 0x1740B)
    BP = 0x7552;
    // CALL 0x1000:6603 (1000_740E / 0x1740E)
    NearCall(cs1, 0x7411, spice86_generated_label_call_target_1000_6603_016603);
    // ADD word ptr [SI + 0xc],CX (1000_7411 / 0x17411)
    // UInt16[DS, (ushort)(SI + 0xC)] += CX;
    UInt16[DS, (ushort)(SI + 0xC)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0xC)], CX);
    // OR BX,BX (1000_7414 / 0x17414)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:7429 (1000_7416 / 0x17416)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7429_017429, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_7418 / 0x17418)
    return NearRet();
  }
  
  public Action split_1000_7429_017429(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_7429_17429:
    // CMP DI,word ptr [0x114e] (1000_7429 / 0x17429)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JZ 0x1000:7434 (1000_742D / 0x1742D)
    if(ZeroFlag) {
      goto label_1000_7434_17434;
    }
    // MOV AL,0x7 (1000_742F / 0x1742F)
    AL = 0x7;
    // CALL 0x1000:71b2 (1000_7431 / 0x17431)
    NearCall(cs1, 0x7434, split_1000_71B2_0171B2);
    label_1000_7434_17434:
    // CMP byte ptr [DI + 0x8],0x28 (1000_7434 / 0x17434)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JNC 0x1000:7443 (1000_7438 / 0x17438)
    if(!CarryFlag) {
      goto label_1000_7443_17443;
    }
    // AND byte ptr [DI + 0xa],0xfd (1000_743A / 0x1743A)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0xFD;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0xFD);
    // MOV BP,0x75af (1000_743E / 0x1743E)
    BP = 0x75AF;
    // JMP 0x1000:7479 (1000_7441 / 0x17441)
    goto label_1000_7479_17479;
    label_1000_7443_17443:
    // PUSH SI (1000_7443 / 0x17443)
    Stack.Push(SI);
    // PUSH DI (1000_7444 / 0x17444)
    Stack.Push(DI);
    // MOV byte ptr [DI + 0xb],0x5 (1000_7445 / 0x17445)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x5;
    // CALL 0x1000:644e (1000_7449 / 0x17449)
    throw FailAsUntested("Could not find a valid function at address 1000_644E / 0x1644E");
    // POP DI (1000_744C / 0x1744C)
    DI = Stack.Pop();
    // POP SI (1000_744D / 0x1744D)
    SI = Stack.Pop();
    // CALL 0x1000:1ac5 (1000_744E / 0x1744E)
    NearCall(cs1, 0x7451, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // ADD AL,0x2 (1000_7451 / 0x17451)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    // MOV byte ptr [DI + 0xb],AL (1000_7453 / 0x17453)
    UInt8[DS, (ushort)(DI + 0xB)] = AL;
    // MOV AL,0x4 (1000_7456 / 0x17456)
    AL = 0x4;
    // CALL 0x1000:6f78 (1000_7458 / 0x17458)
    throw FailAsUntested("Could not find a valid function at address 1000_6F78 / 0x16F78");
    // MOV AL,0x1 (1000_745B / 0x1745B)
    AL = 0x1;
    // CALL 0x1000:6f56 (1000_745D / 0x1745D)
    throw FailAsUntested("Could not find a valid function at address 1000_6F56 / 0x16F56");
    // OR byte ptr [DI + 0xa],0x8 (1000_7460 / 0x17460)
    // UInt8[DS, (ushort)(DI + 0xA)] |= 0x8;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    // PUSH CX (1000_7464 / 0x17464)
    Stack.Push(CX);
    // MOV CL,byte ptr [DI] (1000_7465 / 0x17465)
    CL = UInt8[DS, DI];
    // MOV AX,0x8000 (1000_7467 / 0x17467)
    AX = 0x8000;
    // ROL AX,CL (1000_746A / 0x1746A)
    AX = Alu.Rol16(AX, CL);
    // MOV [0x115a],AX (1000_746C / 0x1746C)
    UInt16[DS, 0x115A] = AX;
    // POP CX (1000_746F / 0x1746F)
    CX = Stack.Pop();
    // MOV BP,0x75af (1000_7470 / 0x17470)
    BP = 0x75AF;
    // CALL 0x1000:6603 (1000_7473 / 0x17473)
    NearCall(cs1, 0x7476, spice86_generated_label_call_target_1000_6603_016603);
    // MOV BP,0x75ea (1000_7476 / 0x17476)
    BP = 0x75EA;
    label_1000_7479_17479:
    // CALL 0x1000:6603 (1000_7479 / 0x17479)
    NearCall(cs1, 0x747C, spice86_generated_label_call_target_1000_6603_016603);
    // XOR DX,DX (1000_747C / 0x1747C)
    DX = 0;
    // TEST word ptr [0x0],0x3 (1000_747E / 0x1747E)
    Alu.And16(UInt16[DS, 0x0], 0x3);
    // JNZ 0x1000:7487 (1000_7484 / 0x17484)
    if(!ZeroFlag) {
      goto label_1000_7487_17487;
    }
    // INC DX (1000_7486 / 0x17486)
    DX = Alu.Inc16(DX);
    label_1000_7487_17487:
    // XOR CX,CX (1000_7487 / 0x17487)
    CX = 0;
    // MOV BP,0x762a (1000_7489 / 0x17489)
    BP = 0x762A;
    // CALL 0x1000:6603 (1000_748C / 0x1748C)
    NearCall(cs1, 0x748F, spice86_generated_label_call_target_1000_6603_016603);
    // CMP CX,DX (1000_748F / 0x1748F)
    Alu.Sub16(CX, DX);
    // JA 0x1000:7487 (1000_7491 / 0x17491)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_7487_17487;
    }
    // PUSH SI (1000_7493 / 0x17493)
    Stack.Push(SI);
    // PUSH DI (1000_7494 / 0x17494)
    Stack.Push(DI);
    // CALL 0x1000:1cda (1000_7495 / 0x17495)
    NearCall(cs1, 0x7498, spice86_generated_label_call_target_1000_1CDA_011CDA);
    // CMP DL,0x1 (1000_7498 / 0x17498)
    Alu.Sub8(DL, 0x1);
    // JA 0x1000:74b1 (1000_749B / 0x1749B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_74B1_174B1;
    }
    // MOV byte ptr [0xc2],0x1 (1000_749D / 0x1749D)
    UInt8[DS, 0xC2] = 0x1;
    // AND byte ptr [0xff7],0xfd (1000_74A2 / 0x174A2)
    UInt8[DS, 0xFF7] &= 0xFD;
    
    // AND byte ptr [0x1007],0xfd (1000_74A7 / 0x174A7)
    // UInt8[DS, 0x1007] &= 0xFD;
    UInt8[DS, 0x1007] = Alu.And8(UInt8[DS, 0x1007], 0xFD);
    // POP DI (1000_74AC / 0x174AC)
    DI = Stack.Pop();
    // CALL 0x1000:765e (1000_74AD / 0x174AD)
    throw FailAsUntested("Could not find a valid function at address 1000_765E / 0x1765E");
    // PUSH DI (1000_74B0 / 0x174B0)
    Stack.Push(DI);
    label_1000_74B1_174B1:
    // POP DI (1000_74B1 / 0x174B1)
    DI = Stack.Pop();
    // POP SI (1000_74B2 / 0x174B2)
    SI = Stack.Pop();
    // JMP 0x1000:5d50 (1000_74B3 / 0x174B3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_751D_01751D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_751D_1751D:
    // MOV AX,[0x94] (1000_751D / 0x1751D)
    AX = UInt16[DS, 0x94];
    // XOR DX,DX (1000_7520 / 0x17520)
    DX = 0;
    // XOR CX,CX (1000_7522 / 0x17522)
    CX = 0;
    // MOV CL,byte ptr [0x60] (1000_7524 / 0x17524)
    CL = UInt8[DS, 0x60];
    // JCXZ 0x1000:752c (1000_7528 / 0x17528)
    if(CX == 0) {
      goto label_1000_752C_1752C;
    }
    // DIV CX (1000_752A / 0x1752A)
    Cpu.Div16(CX);
    label_1000_752C_1752C:
    // MOV DX,AX (1000_752C / 0x1752C)
    DX = AX;
    // CALL 0x1000:758d (1000_752E / 0x1752E)
    throw FailAsUntested("Could not find a valid function at address 1000_758D / 0x1758D");
    // ADD word ptr [SI + 0xe],AX (1000_7531 / 0x17531)
    UInt16[DS, (ushort)(SI + 0xE)] += AX;
    
    // SUB byte ptr [SI + 0x1a],AL (1000_7534 / 0x17534)
    // UInt8[DS, (ushort)(SI + 0x1A)] -= AL;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], AL);
    // JA 0x1000:7551 (1000_7537 / 0x17537)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_7551 / 0x17551)
      return NearRet();
    }
    // MOV BX,0x7f (1000_7539 / 0x17539)
    BX = 0x7F;
    // CALL 0x1000:e3b7 (1000_753C / 0x1753C)
    NearCall(cs1, 0x753F, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // ADD AL,0x1e (1000_753F / 0x1753F)
    // AL += 0x1E;
    AL = Alu.Add8(AL, 0x1E);
    // MOV byte ptr [SI + 0x1a],AL (1000_7541 / 0x17541)
    UInt8[DS, (ushort)(SI + 0x1A)] = AL;
    // CALL 0x1000:668f (1000_7544 / 0x17544)
    throw FailAsUntested("Could not find a valid function at address 1000_668F / 0x1668F");
    // CALL 0x1000:5098 (1000_7547 / 0x17547)
    throw FailAsUntested("Could not find a valid function at address 1000_5098 / 0x15098");
    // OR DX,DX (1000_754A / 0x1754A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNZ 0x1000:7551 (1000_754C / 0x1754C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_7551 / 0x17551)
      return NearRet();
    }
    // CALL 0x1000:74b6 (1000_754E / 0x1754E)
    throw FailAsUntested("Could not find a valid function at address 1000_74B6 / 0x174B6");
    label_1000_7551_17551:
    // RET  (1000_7551 / 0x17551)
    return NearRet();
  }
  
  public Action split_1000_780A_01780A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_780A_1780A:
    // CALL 0x1000:7c63 (1000_780A / 0x1780A)
    throw FailAsUntested("Could not find a valid function at address 1000_7C63 / 0x17C63");
    // MOV BP,0x2122 (1000_780D / 0x1780D)
    BP = 0x2122;
    // CMP AX,word ptr [0x1176] (1000_7810 / 0x17810)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    // JA 0x1000:783e (1000_7814 / 0x17814)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_7816 / 0x17816)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // TEST AL,0x20 (1000_7819 / 0x17819)
    Alu.And8(AL, 0x20);
    // JZ 0x1000:7821 (1000_781B / 0x1781B)
    if(ZeroFlag) {
      goto label_1000_7821_17821;
    }
    // CMP AL,0x22 (1000_781D / 0x1781D)
    Alu.Sub8(AL, 0x22);
    // JNZ 0x1000:783e (1000_781F / 0x1781F)
    if(!ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    label_1000_7821_17821:
    // MOV BP,0x214a (1000_7821 / 0x17821)
    BP = 0x214A;
    // TEST byte ptr [SI + 0x3],0x40 (1000_7824 / 0x17824)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    // JNZ 0x1000:783e (1000_7828 / 0x17828)
    if(!ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    // MOV BP,0x210a (1000_782A / 0x1782A)
    BP = 0x210A;
    // MOV AX,0x52 (1000_782D / 0x1782D)
    AX = 0x52;
    // CMP byte ptr [0x46f3],0x1 (1000_7830 / 0x17830)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x1);
    // ADC AX,0x0 (1000_7835 / 0x17835)
    AX = Alu.Adc16(AX, 0x0);
    // MOV word ptr [BP + 0x12],AX (1000_7838 / 0x17838)
    UInt16[SS, (ushort)(BP + 0x12)] = AX;
    // CALL 0x1000:7847 (1000_783B / 0x1783B)
    throw FailAsUntested("Could not find a valid function at address 1000_7847 / 0x17847");
    label_1000_783E_1783E:
    // MOV BX,0x8751 (1000_783E / 0x1783E)
    BX = 0x8751;
    // CALL 0x1000:d323 (1000_7841 / 0x17841)
    NearCall(cs1, 0x7844, spice86_generated_label_call_target_1000_D323_01D323);
    // JMP 0x1000:c13b (1000_7844 / 0x17844)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_79DB_0179DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_79DB_179DB:
    // JMP 0x1000:c07c (1000_79DB / 0x179DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_79DE_179DE:
    // XOR AX,AX (1000_79DE / 0x179DE)
    AX = 0;
    // XCHG word ptr [0x46fa],AX (1000_79E0 / 0x179E0)
    ushort tmp_1000_79E0 = UInt16[DS, 0x46FA];
    UInt16[DS, 0x46FA] = AX;
    AX = tmp_1000_79E0;
    // OR AX,AX (1000_79E4 / 0x179E4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:79db (1000_79E6 / 0x179E6)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:c07c (1000_79DB / 0x179DB)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x18df (1000_79E8 / 0x179E8)
    SI = 0x18DF;
    // JMP 0x1000:5f9f (1000_79EB / 0x179EB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5F9F_015F9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_7B1B_017B1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_7B1B_17B1B:
    // MOV ES,word ptr [0xdbda] (1000_7B1B / 0x17B1B)
    ES = UInt16[DS, 0xDBDA];
    // MOV AL,byte ptr [SI + 0x9] (1000_7B1F / 0x17B1F)
    AL = UInt8[DS, (ushort)(SI + 0x9)];
    // PUSH SI (1000_7B22 / 0x17B22)
    Stack.Push(SI);
    // CALLF [0x38dd] (1000_7B23 / 0x17B23)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_7B23 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_7B23) {
      case 0x235CE : FarCall(cs1, 0x7B27, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_7B23));
        break;
    }
    label_1000_7B27_17B27:
    // POP SI (1000_7B27 / 0x17B27)
    SI = Stack.Pop();
    // JMP 0x1000:c551 (1000_7B28 / 0x17B28)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C551_01C551, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_7B2B_017B2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_7B2B_17B2B:
    // CMP byte ptr [0x46d8],0x0 (1000_7B2B / 0x17B2B)
    Alu.Sub8(UInt8[DS, 0x46D8], 0x0);
    // JNZ 0x1000:7b35 (1000_7B30 / 0x17B30)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_7B35 / 0x17B35)
      return NearRet();
    }
    // JMP 0x1000:c0e8 (1000_7B32 / 0x17B32)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C0E8_01C0E8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_7B35_17B35:
    // RET  (1000_7B35 / 0x17B35)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_7B36_017B36(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_7B36_17B36:
    // PUSH SI (1000_7B36 / 0x17B36)
    Stack.Push(SI);
    // PUSH DI (1000_7B37 / 0x17B37)
    Stack.Push(DI);
    // MOV byte ptr [0x46d8],0x1 (1000_7B38 / 0x17B38)
    UInt8[DS, 0x46D8] = 0x1;
    // MOV byte ptr [0xdce6],0x80 (1000_7B3D / 0x17B3D)
    UInt8[DS, 0xDCE6] = 0x80;
    // CALL 0x1000:8770 (1000_7B42 / 0x17B42)
    NearCall(cs1, 0x7B45, spice86_generated_label_call_target_1000_8770_018770);
    label_1000_7B45_17B45:
    // CALL 0x1000:5f79 (1000_7B45 / 0x17B45)
    NearCall(cs1, 0x7B48, spice86_generated_label_call_target_1000_5F79_015F79);
    label_1000_7B48_17B48:
    // CALL 0x1000:79de (1000_7B48 / 0x17B48)
    throw FailAsUntested("Could not find a valid function at address 1000_79DE / 0x179DE");
    label_1000_7B4B_17B4B:
    // MOV byte ptr [0xdce6],0x0 (1000_7B4B / 0x17B4B)
    UInt8[DS, 0xDCE6] = 0x0;
    // MOV byte ptr [0x46f4],0x0 (1000_7B50 / 0x17B50)
    UInt8[DS, 0x46F4] = 0x0;
    // POP DI (1000_7B55 / 0x17B55)
    DI = Stack.Pop();
    // POP SI (1000_7B56 / 0x17B56)
    SI = Stack.Pop();
    // RET  (1000_7B57 / 0x17B57)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_7C8F_017C8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_7C8F_17C8F:
    // PUSH SI (1000_7C8F / 0x17C8F)
    Stack.Push(SI);
    // CALL 0x1000:407e (1000_7C90 / 0x17C90)
    NearCall(cs1, 0x7C93, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_7C93_17C93:
    // POP SI (1000_7C93 / 0x17C93)
    SI = Stack.Pop();
    // MOV BP,BX (1000_7C94 / 0x17C94)
    BP = BX;
    // SHL BP,0x1 (1000_7C96 / 0x17C96)
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
  
  public Action spice86_generated_label_call_target_1000_7F27_017F27(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHL AL,0x1 (1000_7F46 / 0x17F46)
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
    UInt8[DS, DI] = Alu.Inc8(UInt8[DS, DI]);
    label_1000_7F51_17F51:
    // INC DI (1000_7F51 / 0x17F51)
    DI = Alu.Inc16(DI);
    // SHL AL,0x1 (1000_7F52 / 0x17F52)
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
  
  public Action split_1000_80DF_0180DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_80DF_180DF:
    // PUSH AX (1000_80DF / 0x180DF)
    Stack.Push(AX);
    // CALL 0x1000:c08e (1000_80E0 / 0x180E0)
    NearCall(cs1, 0x80E3, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:8fd1 (1000_80E3 / 0x180E3)
    throw FailAsUntested("Could not find a valid function at address 1000_8FD1 / 0x18FD1");
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
    throw FailAsUntested("Could not find a valid function at address 1000_9F82 / 0x19F82");
    // POP AX (1000_8105 / 0x18105)
    AX = Stack.Pop();
    // CALL 0x1000:88af (1000_8106 / 0x18106)
    throw FailAsUntested("Could not find a valid function at address 1000_88AF / 0x188AF");
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
    throw FailAsUntested("Could not find a valid function at address 1000_541F / 0x1541F");
    // MOV word ptr [0x1bea],0x0 (1000_8137 / 0x18137)
    UInt16[DS, 0x1BEA] = 0x0;
    // RET  (1000_813D / 0x1813D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_8770_018770(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // MOV byte ptr [0x46f3],0x0 (1000_877A / 0x1877A)
    UInt8[DS, 0x46F3] = 0x0;
    // CALL 0x1000:878c (1000_877F / 0x1877F)
    NearCall(cs1, 0x8782, spice86_generated_label_call_target_1000_878C_01878C);
    // MOV word ptr [0x1bea],0x0 (1000_8782 / 0x18782)
    UInt16[DS, 0x1BEA] = 0x0;
    // CALL 0x1000:e283 (1000_8788 / 0x18788)
    NearCall(cs1, 0x878B, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_878B_1878B:
    // RET  (1000_878B / 0x1878B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_878C_01878C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_87C0_187C0;
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
      goto label_1000_87C0_187C0;
    }
    label_1000_87AA_187AA:
    // PUSH DI (1000_87AA / 0x187AA)
    Stack.Push(DI);
    // MOV DI,word ptr [0x114e] (1000_87AB / 0x187AB)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:7f27 (1000_87AF / 0x187AF)
    NearCall(cs1, 0x87B2, spice86_generated_label_call_target_1000_7F27_017F27);
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
    label_1000_881C_1881C:
    // JMP 0x1000:c13b (1000_881C / 0x1881C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_8888_018888(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8895: goto label_1000_8895_18895;break; // Target of external jump from 0x19022
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_8888_18888:
    // CMP byte ptr [0x46d9],0x0 (1000_8888 / 0x18888)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JNZ 0x1000:88e1 (1000_888D / 0x1888D)
    if(!ZeroFlag) {
      goto label_1000_88E1_188E1;
    }
    // MOV word ptr [0x479e],0x1 (1000_888F / 0x1888F)
    UInt16[DS, 0x479E] = 0x1;
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
    label_1000_88AE_188AE:
    // RET  (1000_88AE / 0x188AE)
    return NearRet();
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
    if(JumpDispatcher.Jump(split_1000_80DF_0180DF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_88CA_188CA:
    // MOV SI,AX (1000_88CA / 0x188CA)
    SI = AX;
    // CALL 0x1000:cf70 (1000_88CC / 0x188CC)
    NearCall(cs1, 0x88CF, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_88CF_188CF:
    // CALL 0x1000:88f1 (1000_88CF / 0x188CF)
    NearCall(cs1, 0x88D2, spice86_generated_label_call_target_1000_88F1_0188F1);
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
      goto label_1000_8888_18888;
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
    throw FailAsUntested("Could not find a valid function at address 1000_8B11 / 0x18B11");
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
  
  public Action spice86_generated_label_call_target_1000_88F1_0188F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    
    // SHR CL,0x1 (1000_891A / 0x1891A)
    CL >>= 0x1;
    
    // SHR CL,0x1 (1000_891C / 0x1891C)
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
  
  public Action spice86_generated_label_call_target_1000_8944_018944(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    
    // SHL AX,0x1 (1000_897C / 0x1897C)
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
    throw FailAsUntested("Could not find a valid function at address 1000_8A3B / 0x18A3B");
    // PUSH ES (1000_8992 / 0x18992)
    Stack.Push(ES);
    // CALL 0x1000:cf70 (1000_8993 / 0x18993)
    NearCall(cs1, 0x8996, spice86_generated_label_call_target_1000_CF70_01CF70);
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
    // CALL 0x1000:8ac3 (1000_89E0 / 0x189E0)
    throw FailAsUntested("Could not find a valid function at address 1000_8AC3 / 0x18AC3");
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
    throw FailAsUntested("Could not find a valid function at address 1000_8ACC / 0x18ACC");
    // POP AX (1000_89FB / 0x189FB)
    AX = Stack.Pop();
    // CALL 0x1000:8a23 (1000_89FC / 0x189FC)
    throw FailAsUntested("Could not find a valid function at address 1000_8A23 / 0x18A23");
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
    CX = Alu.Inc16(CX);
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
  
  public Action split_1000_8B10_018B10(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8BE9: goto label_1000_8BE9_18BE9;break; // Target of external jump from 0x18C45, 0x18C3F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_8B10_18B10:
    // RET  (1000_8B10 / 0x18B10)
    return NearRet();
    label_1000_8B11_18B11:
    // PUSH SI (1000_8B11 / 0x18B11)
    Stack.Push(SI);
    // CALL 0x1000:8c8a (1000_8B12 / 0x18B12)
    NearCall(cs1, 0x8B15, spice86_generated_label_call_target_1000_8C8A_018C8A);
    label_1000_8B15_18B15:
    // POP SI (1000_8B15 / 0x18B15)
    SI = Stack.Pop();
    // CALL 0x1000:8ccd (1000_8B16 / 0x18B16)
    NearCall(cs1, 0x8B19, spice86_generated_label_call_target_1000_8CCD_018CCD);
    label_1000_8B19_18B19:
    // JC 0x1000:8b10 (1000_8B19 / 0x18B19)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_8B10 / 0x18B10)
      return NearRet();
    }
    // CALL 0x1000:8f28 (1000_8B1B / 0x18B1B)
    NearCall(cs1, 0x8B1E, spice86_generated_label_call_target_1000_8F28_018F28);
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
    // SHR AX,0x1 (1000_8B55 / 0x18B55)
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
    // SHR BX,0x1 (1000_8B7E / 0x18B7E)
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C47 - cs1 * 0x10)) {
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
    AL = Alu.Dec8(AL);
    // XOR AH,AH (1000_8BBC / 0x18BBC)
    AH = 0;
    // SHL AX,0x1 (1000_8BBE / 0x18BBE)
    AX <<= 0x1;
    
    // SUB DX,AX (1000_8BC0 / 0x18BC0)
    DX -= AX;
    
    // SHL AX,0x1 (1000_8BC2 / 0x18BC2)
    AX <<= 0x1;
    
    // SUB DX,AX (1000_8BC4 / 0x18BC4)
    DX -= AX;
    
    // SHR DX,0x1 (1000_8BC6 / 0x18BC6)
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C26 - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C19 - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C19 - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0)) {
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C14 - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C41 - cs1 * 0x10)) {
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
    if(JumpDispatcher.Jump(split_1000_8C0F_018C0F, 0x18C47 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_8C0F_018C0F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x8C41: goto label_1000_8C41_18C41;break; // Target of external jump from 0x18C00
      case 0x8C26: goto label_1000_8C26_18C26;break; // Target of external jump from 0x18C21, 0x18BEC
      case 0x8C19: goto label_1000_8C19_18C19;break; // Target of external jump from 0x18BF0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_8C0F_18C0F:
    // CALL 0x1000:d075 (1000_8C0F / 0x18C0F)
    NearCall(cs1, 0x8C12, spice86_generated_label_call_target_1000_D075_01D075);
    // JMP 0x1000:8be9 (1000_8C12 / 0x18C12)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_8B10_018B10, 0x18BE9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_8C14_18C14:
    // CALL 0x1000:d068 (1000_8C14 / 0x18C14)
    NearCall(cs1, 0x8C17, spice86_generated_label_call_target_1000_D068_01D068);
    // JMP 0x1000:8be9 (1000_8C17 / 0x18C17)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_8B10_018B10, 0x18BE9 - cs1 * 0x10)) {
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
    DX = Alu.Inc16(DX);
    // DEC word ptr [0x479c] (1000_8C36 / 0x18C36)
    UInt16[DS, 0x479C] = Alu.Dec16(UInt16[DS, 0x479C]);
    label_1000_8C3A_18C3A:
    // MOV word ptr [0xd82c],DX (1000_8C3A / 0x18C3A)
    UInt16[DS, 0xD82C] = DX;
    // POP DX (1000_8C3E / 0x18C3E)
    DX = Stack.Pop();
    // JMP 0x1000:8be9 (1000_8C3F / 0x18C3F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_8B10_018B10, 0x18BE9 - cs1 * 0x10)) {
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
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_8C41));
        break;
    }
    label_1000_8C45_18C45:
    // JMP 0x1000:8be9 (1000_8C45 / 0x18C45)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_8B10_018B10, 0x18BE9 - cs1 * 0x10)) {
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_8B10_018B10, 0x18B91 - cs1 * 0x10)) {
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
    SI = Alu.Dec16(SI);
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
  
  public Action spice86_generated_label_call_target_1000_8C8A_018C8A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_8CB8_18CB8:
    // MOV SI,word ptr [0x47c8] (1000_8CB8 / 0x18CB8)
    SI = UInt16[DS, 0x47C8];
    // OR SI,SI (1000_8CBC / 0x18CBC)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:8cc9 (1000_8CBE / 0x18CBE)
    if(ZeroFlag) {
      goto label_1000_8CC9_18CC9;
    }
    // MOV word ptr [0x4540],0x0 (1000_8CC0 / 0x18CC0)
    UInt16[DS, 0x4540] = 0x0;
    // CALL 0x1000:9bac (1000_8CC6 / 0x18CC6)
    NearCall(cs1, 0x8CC9, spice86_generated_label_call_target_1000_9BAC_019BAC);
    label_1000_8CC9_18CC9:
    // CALL 0x1000:c4dd (1000_8CC9 / 0x18CC9)
    NearCall(cs1, 0x8CCC, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_8CCC_18CCC:
    // RET  (1000_8CCC / 0x18CCC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_8CCD_018CCD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    throw FailAsUntested("Could not find a valid function at address 1000_79EE / 0x179EE");
    // POP ES (1000_8CF1 / 0x18CF1)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_8CF2 / 0x18CF2)
    NearCall(cs1, 0x8CF5, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_8CF5_18CF5:
    // MOV BP,0x2244 (1000_8CF5 / 0x18CF5)
    BP = 0x2244;
    // JMP 0x1000:8ddb (1000_8CF8 / 0x18CF8)
    goto label_1000_8DDB_18DDB;
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
    goto label_1000_8DDB_18DDB;
    label_1000_8D1B_18D1B:
    // CMP byte ptr [0xc6],0x0 (1000_8D1B / 0x18D1B)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    // JZ 0x1000:8d43 (1000_8D20 / 0x18D20)
    if(ZeroFlag) {
      goto label_1000_8D43_18D43;
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
    NearCall(cs1, 0x8D40, SetFontToBook_1000_D082_1D082);
    // JMP 0x1000:8ddb (1000_8D40 / 0x18D40)
    goto label_1000_8DDB_18DDB;
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
    goto label_1000_8DDB_18DDB;
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
    goto label_1000_8DDB_18DDB;
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
      goto label_1000_8DEE_18DEE;
    }
    // MOV BX,0x1 (1000_8DD0 / 0x18DD0)
    BX = 0x1;
    // CALL 0x1000:e3b7 (1000_8DD3 / 0x18DD3)
    NearCall(cs1, 0x8DD6, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // JZ 0x1000:8dee (1000_8DD6 / 0x18DD6)
    if(ZeroFlag) {
      goto label_1000_8DEE_18DEE;
    }
    // ADD BP,0x8 (1000_8DD8 / 0x18DD8)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
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
  
  public Action spice86_generated_label_call_target_1000_8DF0_018DF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
}
