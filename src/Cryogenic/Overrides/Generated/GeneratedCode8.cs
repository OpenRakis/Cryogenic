namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_5DCE_015DCE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5DCE_15DCE:
    // MOV AL,[0x46eb] (1000_5DCE / 0x15DCE)
    AL = UInt8[DS, 0x46EB];
    State.IncCycles();
    // OR AL,AL (1000_5DD1 / 0x15DD1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:5dda (1000_5DD3 / 0x15DD3)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5DD9_015DD9, 0x15DDA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH AX (1000_5DD5 / 0x15DD5)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:633b (1000_5DD6 / 0x15DD6)
    NearCall(cs1, 0x5DD9, spice86_generated_label_call_target_1000_633B_01633B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5DD9_015DD9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5DD9_015DD9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x5DDA: goto label_1000_5DDA_15DDA;break; // Target of external jump from 0x15DD3
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_5DD9_15DD9:
    // POP AX (1000_5DD9 / 0x15DD9)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_5DDA_15DDA:
    // MOV DI,0xa5c0 (1000_5DDA / 0x15DDA)
    DI = 0xA5C0;
    State.IncCycles();
    // AND AL,0x40 (1000_5DDD / 0x15DDD)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:5df1 (1000_5DDF / 0x15DDF)
    if(ZeroFlag) {
      goto label_1000_5DF1_15DF1;
    }
    State.IncCycles();
    // SUB DI,0x6 (1000_5DE1 / 0x15DE1)
    DI -= 0x6;
    State.IncCycles();
    label_1000_5DE4_15DE4:
    // ADD DI,0x6 (1000_5DE4 / 0x15DE4)
    DI += 0x6;
    State.IncCycles();
    // CMP word ptr [DI],0x0 (1000_5DE7 / 0x15DE7)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    State.IncCycles();
    // JZ 0x1000:5df1 (1000_5DEA / 0x15DEA)
    if(ZeroFlag) {
      goto label_1000_5DF1_15DF1;
    }
    State.IncCycles();
    // TEST byte ptr [DI + 0x5],AL (1000_5DEC / 0x15DEC)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x5)], AL);
    State.IncCycles();
    // JZ 0x1000:5de4 (1000_5DEF / 0x15DEF)
    if(ZeroFlag) {
      goto label_1000_5DE4_15DE4;
    }
    State.IncCycles();
    label_1000_5DF1_15DF1:
    // MOV SI,0x100 (1000_5DF1 / 0x15DF1)
    SI = 0x100;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5DF4_015DF4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5DF4_015DF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5DF4_15DF4:
    // CMP word ptr [SI],-0x1 (1000_5DF4 / 0x15DF4)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:5e3d (1000_5DF7 / 0x15DF7)
    if(ZeroFlag) {
      goto label_1000_5E3D_15E3D;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x80 (1000_5DF9 / 0x15DF9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:5e38 (1000_5DFD / 0x15DFD)
    if(!ZeroFlag) {
      goto label_1000_5E38_15E38;
    }
    State.IncCycles();
    // CALL 0x1000:62c9 (1000_5DFF / 0x15DFF)
    NearCall(cs1, 0x5E02, spice86_generated_label_call_target_1000_62C9_0162C9);
    State.IncCycles();
    label_1000_5E02_15E02:
    // JC 0x1000:5e38 (1000_5E02 / 0x15E02)
    if(CarryFlag) {
      goto label_1000_5E38_15E38;
    }
    State.IncCycles();
    // MOV word ptr [DI],SI (1000_5E04 / 0x15E04)
    UInt16[DS, DI] = SI;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],DX (1000_5E06 / 0x15E06)
    UInt16[DS, (ushort)(DI + 0x2)] = DX;
    State.IncCycles();
    // MOV BH,byte ptr [0x46eb] (1000_5E09 / 0x15E09)
    BH = UInt8[DS, 0x46EB];
    State.IncCycles();
    // MOV word ptr [DI + 0x4],BX (1000_5E0D / 0x15E0D)
    UInt16[DS, (ushort)(DI + 0x4)] = BX;
    State.IncCycles();
    // XOR BH,BH (1000_5E10 / 0x15E10)
    BH = 0;
    State.IncCycles();
    // CALL 0x1000:5e42 (1000_5E12 / 0x15E12)
    NearCall(cs1, 0x5E15, spice86_generated_label_call_target_1000_5E42_015E42);
    State.IncCycles();
    label_1000_5E15_15E15:
    // CMP CL,0x20 (1000_5E15 / 0x15E15)
    Alu.Sub8(CL, 0x20);
    State.IncCycles();
    // JNC 0x1000:5e2e (1000_5E18 / 0x15E18)
    if(!CarryFlag) {
      goto label_1000_5E2E_15E2E;
    }
    State.IncCycles();
    // PUSH AX (1000_5E1A / 0x15E1A)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_5E1B / 0x15E1B)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_5E1C / 0x15E1C)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_5E1D / 0x15E1D)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:7c8f (1000_5E1E / 0x15E1E)
    NearCall(cs1, 0x5E21, spice86_generated_label_call_target_1000_7C8F_017C8F);
    State.IncCycles();
    label_1000_5E21_15E21:
    // CMP AX,word ptr [0x1176] (1000_5E21 / 0x15E21)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    State.IncCycles();
    // POP SI (1000_5E25 / 0x15E25)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_5E26 / 0x15E26)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_5E27 / 0x15E27)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_5E28 / 0x15E28)
    AX = Stack.Pop();
    State.IncCycles();
    // JBE 0x1000:5e2e (1000_5E29 / 0x15E29)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5E2E_15E2E;
    }
    State.IncCycles();
    // ADD AX,0x5 (1000_5E2B / 0x15E2B)
    // AX += 0x5;
    AX = Alu.Add16(AX, 0x5);
    State.IncCycles();
    label_1000_5E2E_15E2E:
    // PUSH SI (1000_5E2E / 0x15E2E)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_5E2F / 0x15E2F)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:c343 (1000_5E30 / 0x15E30)
    NearCall(cs1, 0x5E33, spice86_generated_label_call_target_1000_C343_01C343);
    State.IncCycles();
    label_1000_5E33_15E33:
    // POP DI (1000_5E33 / 0x15E33)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_5E34 / 0x15E34)
    SI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x6 (1000_5E35 / 0x15E35)
    DI += 0x6;
    State.IncCycles();
    label_1000_5E38_15E38:
    // ADD SI,0x1c (1000_5E38 / 0x15E38)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    State.IncCycles();
    // JMP 0x1000:5df4 (1000_5E3B / 0x15E3B)
    goto label_1000_5DF4_15DF4;
    State.IncCycles();
    label_1000_5E3D_15E3D:
    // MOV word ptr [DI],0x0 (1000_5E3D / 0x15E3D)
    UInt16[DS, DI] = 0x0;
    State.IncCycles();
    // RET  (1000_5E41 / 0x15E41)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5E42_015E42(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5E42_15E42:
    // MOV AX,0x3a (1000_5E42 / 0x15E42)
    AX = 0x3A;
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x80 (1000_5E45 / 0x15E45)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    State.IncCycles();
    // JZ 0x1000:5e4f (1000_5E4A / 0x15E4A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5E4F_015E4F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,0x7a (1000_5E4C / 0x15E4C)
    AX = 0x7A;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5E4F_015E4F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5E4F_015E4F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5E4F_15E4F:
    // MOV CL,byte ptr [SI + 0x8] (1000_5E4F / 0x15E4F)
    CL = UInt8[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // CMP CL,0x20 (1000_5E52 / 0x15E52)
    Alu.Sub8(CL, 0x20);
    State.IncCycles();
    // JC 0x1000:5e6a (1000_5E55 / 0x15E55)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_5E57 / 0x15E57)
    AX++;
    State.IncCycles();
    // CMP CL,0x21 (1000_5E58 / 0x15E58)
    Alu.Sub8(CL, 0x21);
    State.IncCycles();
    // JC 0x1000:5e6a (1000_5E5B / 0x15E5B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_5E5D / 0x15E5D)
    AX++;
    State.IncCycles();
    // CMP CL,0x28 (1000_5E5E / 0x15E5E)
    Alu.Sub8(CL, 0x28);
    State.IncCycles();
    // JC 0x1000:5e6a (1000_5E61 / 0x15E61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_5E63 / 0x15E63)
    AX++;
    State.IncCycles();
    // CMP CL,0x30 (1000_5E64 / 0x15E64)
    Alu.Sub8(CL, 0x30);
    State.IncCycles();
    // JC 0x1000:5e6a (1000_5E67 / 0x15E67)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5E6A / 0x15E6A)
      return NearRet();
    }
    State.IncCycles();
    // INC AX (1000_5E69 / 0x15E69)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    label_1000_5E6A_15E6A:
    // RET  (1000_5E6A / 0x15E6A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5E6D_015E6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5E6D_15E6D:
    // PUSH SI (1000_5E6D / 0x15E6D)
    Stack.Push(SI);
    State.IncCycles();
    // MOV BP,SP (1000_5E6E / 0x15E6E)
    BP = SP;
    State.IncCycles();
    // SUB SP,0x8 (1000_5E70 / 0x15E70)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    State.IncCycles();
    // MOV word ptr [BP + -0x8],0xffff (1000_5E73 / 0x15E73)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xFFFF;
    State.IncCycles();
    // MOV word ptr [BP + -0x6],DX (1000_5E78 / 0x15E78)
    UInt16[SS, (ushort)(BP - 0x6)] = DX;
    State.IncCycles();
    // MOV word ptr [BP + -0x4],BX (1000_5E7B / 0x15E7B)
    UInt16[SS, (ushort)(BP - 0x4)] = BX;
    State.IncCycles();
    // MOV word ptr [BP + -0x2],0x0 (1000_5E7E / 0x15E7E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    State.IncCycles();
    // MOV SI,0xa5ba (1000_5E83 / 0x15E83)
    SI = 0xA5BA;
    State.IncCycles();
    label_1000_5E86_15E86:
    // ADD SI,0x6 (1000_5E86 / 0x15E86)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    State.IncCycles();
    // MOV DI,word ptr [SI] (1000_5E89 / 0x15E89)
    DI = UInt16[DS, SI];
    State.IncCycles();
    // OR DI,DI (1000_5E8B / 0x15E8B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:5ebf (1000_5E8D / 0x15E8D)
    if(ZeroFlag) {
      goto label_1000_5EBF_15EBF;
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],AL (1000_5E8F / 0x15E8F)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], AL);
    State.IncCycles();
    // JNC 0x1000:5e86 (1000_5E92 / 0x15E92)
    if(!CarryFlag) {
      goto label_1000_5E86_15E86;
    }
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x4] (1000_5E94 / 0x15E94)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP BH,byte ptr [0x46eb] (1000_5E97 / 0x15E97)
    Alu.Sub8(BH, UInt8[DS, 0x46EB]);
    State.IncCycles();
    // JNZ 0x1000:5e86 (1000_5E9B / 0x15E9B)
    if(!ZeroFlag) {
      goto label_1000_5E86_15E86;
    }
    State.IncCycles();
    // XOR BH,BH (1000_5E9D / 0x15E9D)
    BH = 0;
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x2] (1000_5E9F / 0x15E9F)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SUB DX,word ptr [BP + -0x6] (1000_5EA2 / 0x15EA2)
    // DX -= UInt16[SS, (ushort)(BP - 0x6)];
    DX = Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x6)]);
    State.IncCycles();
    // JNS 0x1000:5ea9 (1000_5EA5 / 0x15EA5)
    if(!SignFlag) {
      goto label_1000_5EA9_15EA9;
    }
    State.IncCycles();
    // NEG DX (1000_5EA7 / 0x15EA7)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_1000_5EA9_15EA9:
    // SUB BX,word ptr [BP + -0x4] (1000_5EA9 / 0x15EA9)
    // BX -= UInt16[SS, (ushort)(BP - 0x4)];
    BX = Alu.Sub16(BX, UInt16[SS, (ushort)(BP - 0x4)]);
    State.IncCycles();
    // JNS 0x1000:5eb0 (1000_5EAC / 0x15EAC)
    if(!SignFlag) {
      goto label_1000_5EB0_15EB0;
    }
    State.IncCycles();
    // NEG BX (1000_5EAE / 0x15EAE)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_5EB0_15EB0:
    // ADD DX,BX (1000_5EB0 / 0x15EB0)
    DX += BX;
    State.IncCycles();
    // CMP DX,word ptr [BP + -0x8] (1000_5EB2 / 0x15EB2)
    Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x8)]);
    State.IncCycles();
    // JNC 0x1000:5e86 (1000_5EB5 / 0x15EB5)
    if(!CarryFlag) {
      goto label_1000_5E86_15E86;
    }
    State.IncCycles();
    // MOV word ptr [BP + -0x8],DX (1000_5EB7 / 0x15EB7)
    UInt16[SS, (ushort)(BP - 0x8)] = DX;
    State.IncCycles();
    // MOV word ptr [BP + -0x2],DI (1000_5EBA / 0x15EBA)
    UInt16[SS, (ushort)(BP - 0x2)] = DI;
    State.IncCycles();
    // JMP 0x1000:5e86 (1000_5EBD / 0x15EBD)
    goto label_1000_5E86_15E86;
    State.IncCycles();
    label_1000_5EBF_15EBF:
    // MOV DI,word ptr [BP + -0x2] (1000_5EBF / 0x15EBF)
    DI = UInt16[SS, (ushort)(BP - 0x2)];
    State.IncCycles();
    // MOV AX,word ptr [BP + -0x8] (1000_5EC2 / 0x15EC2)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    State.IncCycles();
    // MOV DX,word ptr [BP + -0x6] (1000_5EC5 / 0x15EC5)
    DX = UInt16[SS, (ushort)(BP - 0x6)];
    State.IncCycles();
    // MOV BX,word ptr [BP + -0x4] (1000_5EC8 / 0x15EC8)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    State.IncCycles();
    // ADD SP,0x8 (1000_5ECB / 0x15ECB)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    State.IncCycles();
    // POP SI (1000_5ECE / 0x15ECE)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5ECF / 0x15ECF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5ED0_015ED0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5ED0_15ED0:
    // MOV BP,0xa5ba (1000_5ED0 / 0x15ED0)
    BP = 0xA5BA;
    State.IncCycles();
    label_1000_5ED3_15ED3:
    // ADD BP,0x6 (1000_5ED3 / 0x15ED3)
    // BP += 0x6;
    BP = Alu.Add16(BP, 0x6);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (1000_5ED6 / 0x15ED6)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // CMP AX,DI (1000_5ED9 / 0x15ED9)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JZ 0x1000:5ee3 (1000_5EDB / 0x15EDB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5EE3 / 0x15EE3)
      return NearRet();
    }
    State.IncCycles();
    // OR AX,AX (1000_5EDD / 0x15EDD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNZ 0x1000:5ed3 (1000_5EDF / 0x15EDF)
    if(!ZeroFlag) {
      goto label_1000_5ED3_15ED3;
    }
    State.IncCycles();
    // OR BP,BP (1000_5EE1 / 0x15EE1)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5EE3_015EE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5EE3_015EE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5EE3_15EE3:
    // RET  (1000_5EE3 / 0x15EE3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5EE4_015EE4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5EE4_15EE4:
    // CALL 0x1000:5ed0 (1000_5EE4 / 0x15EE4)
    NearCall(cs1, 0x5EE7, spice86_generated_label_call_target_1000_5ED0_015ED0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5EE7_015EE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5EE7_015EE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5EE7_15EE7:
    // JNZ 0x1000:5ee3 (1000_5EE7 / 0x15EE7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5EE3 / 0x15EE3)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x1668 (1000_5EE9 / 0x15EE9)
    SI = 0x1668;
    State.IncCycles();
    // CALL 0x1000:6252 (1000_5EEC / 0x15EEC)
    NearCall(cs1, 0x5EEF, spice86_generated_label_call_target_1000_6252_016252);
    State.IncCycles();
    label_1000_5EEF_15EEF:
    // MOV BX,AX (1000_5EEF / 0x15EEF)
    BX = AX;
    State.IncCycles();
    // INC AX (1000_5EF1 / 0x15EF1)
    AX++;
    State.IncCycles();
    // CMP DI,word ptr [0x46f8] (1000_5EF2 / 0x15EF2)
    Alu.Sub16(DI, UInt16[DS, 0x46F8]);
    State.IncCycles();
    // JNZ 0x1000:5f12 (1000_5EF6 / 0x15EF6)
    if(!ZeroFlag) {
      goto label_1000_5F12_15F12;
    }
    State.IncCycles();
    // CMP AL,byte ptr [0x46f7] (1000_5EF8 / 0x15EF8)
    Alu.Sub8(AL, UInt8[DS, 0x46F7]);
    State.IncCycles();
    // JNZ 0x1000:5f01 (1000_5EFC / 0x15EFC)
    if(!ZeroFlag) {
      goto label_1000_5F01_15F01;
    }
    State.IncCycles();
    // JMP 0x1000:7b1b (1000_5EFE / 0x15EFE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B1B_017B1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5F01_15F01:
    // CALL 0x1000:e270 (1000_5F01 / 0x15F01)
    NearCall(cs1, 0x5F04, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // MOV byte ptr [0x46d8],0x1 (1000_5F04 / 0x15F04)
    UInt8[DS, 0x46D8] = 0x1;
    State.IncCycles();
    // CALL 0x1000:5f91 (1000_5F09 / 0x15F09)
    NearCall(cs1, 0x5F0C, spice86_generated_label_call_target_1000_5F91_015F91);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_5F0C / 0x15F0C)
    NearCall(cs1, 0x5F0F, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:e283 (1000_5F0F / 0x15F0F)
    NearCall(cs1, 0x5F12, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_5F12_15F12:
    // MOV [0x46f7],AL (1000_5F12 / 0x15F12)
    UInt8[DS, 0x46F7] = AL;
    State.IncCycles();
    // MOV CL,byte ptr [BX + 0x11d0] (1000_5F15 / 0x15F15)
    CL = UInt8[DS, (ushort)(BX + 0x11D0)];
    State.IncCycles();
    // XOR CH,CH (1000_5F19 / 0x15F19)
    CH = 0;
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x2] (1000_5F1B / 0x15F1B)
    DX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x4] (1000_5F1E / 0x15F1E)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // OR BH,BH (1000_5F21 / 0x15F21)
    // BH |= BH;
    BH = Alu.Or8(BH, BH);
    State.IncCycles();
    // JNS 0x1000:5ee3 (1000_5F23 / 0x15F23)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5EE3 / 0x15EE3)
      return NearRet();
    }
    State.IncCycles();
    // XOR BH,BH (1000_5F25 / 0x15F25)
    BH = 0;
    State.IncCycles();
    // PUSH BX (1000_5F27 / 0x15F27)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_5F28 / 0x15F28)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,CX (1000_5F29 / 0x15F29)
    AX = CX;
    State.IncCycles();
    // SHR AX,1 (1000_5F2B / 0x15F2B)
    AX >>= 0x1;
    State.IncCycles();
    // SUB BX,AX (1000_5F2D / 0x15F2D)
    BX -= AX;
    State.IncCycles();
    // CMP BX,0x4 (1000_5F2F / 0x15F2F)
    Alu.Sub16(BX, 0x4);
    State.IncCycles();
    // JGE 0x1000:5f37 (1000_5F32 / 0x15F32)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5F37_15F37;
    }
    State.IncCycles();
    // MOV BX,0x4 (1000_5F34 / 0x15F34)
    BX = 0x4;
    State.IncCycles();
    label_1000_5F37_15F37:
    // MOV AX,0x94 (1000_5F37 / 0x15F37)
    AX = 0x94;
    State.IncCycles();
    // SUB AX,CX (1000_5F3A / 0x15F3A)
    AX -= CX;
    State.IncCycles();
    // CMP BX,AX (1000_5F3C / 0x15F3C)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JL 0x1000:5f42 (1000_5F3E / 0x15F3E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F42_15F42;
    }
    State.IncCycles();
    // MOV BX,AX (1000_5F40 / 0x15F40)
    BX = AX;
    State.IncCycles();
    label_1000_5F42_15F42:
    // ADD DX,0xf (1000_5F42 / 0x15F42)
    DX += 0xF;
    State.IncCycles();
    // CMP DX,0xd2 (1000_5F45 / 0x15F45)
    Alu.Sub16(DX, 0xD2);
    State.IncCycles();
    // JL 0x1000:5f4f (1000_5F49 / 0x15F49)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F4F_15F4F;
    }
    State.IncCycles();
    // SUB DX,0x82 (1000_5F4B / 0x15F4B)
    // DX -= 0x82;
    DX = Alu.Sub16(DX, 0x82);
    State.IncCycles();
    label_1000_5F4F_15F4F:
    // MOV word ptr [SI],DX (1000_5F4F / 0x15F4F)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],BX (1000_5F51 / 0x15F51)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    State.IncCycles();
    // ADD DX,0x6a (1000_5F54 / 0x15F54)
    // DX += 0x6A;
    DX = Alu.Add16(DX, 0x6A);
    State.IncCycles();
    // MOV word ptr [SI + 0x4],DX (1000_5F57 / 0x15F57)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    State.IncCycles();
    // ADD BX,CX (1000_5F5A / 0x15F5A)
    // BX += CX;
    BX = Alu.Add16(BX, CX);
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_5F5C / 0x15F5C)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    // MOV word ptr [0xdbe0],SI (1000_5F5F / 0x15F5F)
    UInt16[DS, 0xDBE0] = SI;
    State.IncCycles();
    // POP DX (1000_5F63 / 0x15F63)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_5F64 / 0x15F64)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV AX,0xa (1000_5F65 / 0x15F65)
    AX = 0xA;
    State.IncCycles();
    // SUB DX,AX (1000_5F68 / 0x15F68)
    DX -= AX;
    State.IncCycles();
    // SUB BX,AX (1000_5F6A / 0x15F6A)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // MOV DI,0xd816 (1000_5F6C / 0x15F6C)
    DI = 0xD816;
    State.IncCycles();
    // MOV word ptr [DI],DX (1000_5F6F / 0x15F6F)
    UInt16[DS, DI] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],BX (1000_5F71 / 0x15F71)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    State.IncCycles();
    // MOV AL,0x6 (1000_5F74 / 0x15F74)
    AL = 0x6;
    State.IncCycles();
    // JMP 0x1000:7b0f (1000_5F76 / 0x15F76)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B0F_017B0F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5F79_015F79(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5F79_15F79:
    // XOR AX,AX (1000_5F79 / 0x15F79)
    AX = 0;
    State.IncCycles();
    // XCHG word ptr [0x46f8],AX (1000_5F7B / 0x15F7B)
    ushort tmp_1000_5F7B = UInt16[DS, 0x46F8];
    UInt16[DS, 0x46F8] = AX;
    AX = tmp_1000_5F7B;
    State.IncCycles();
    // OR AX,AX (1000_5F7F / 0x15F7F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:5f90 (1000_5F81 / 0x15F81)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5F90 / 0x15F90)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:d41b (1000_5F83 / 0x15F83)
    NearCall(cs1, 0x5F86, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    // MOV AL,byte ptr [BP + 0x0] (1000_5F86 / 0x15F86)
    AL = UInt8[SS, BP];
    State.IncCycles();
    // INC AL (1000_5F89 / 0x15F89)
    AL = Alu.Inc8(AL);
    State.IncCycles();
    // JZ 0x1000:5f91 (1000_5F8B / 0x15F8B)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5F91_015F91, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:d2e2 (1000_5F8D / 0x15F8D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5F90_15F90:
    // RET  (1000_5F90 / 0x15F90)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5F91_015F91(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5F91_15F91:
    // MOV word ptr [0x46f8],0x0 (1000_5F91 / 0x15F91)
    UInt16[DS, 0x46F8] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x46f7],0x0 (1000_5F97 / 0x15F97)
    UInt8[DS, 0x46F7] = 0x0;
    State.IncCycles();
    // MOV SI,0x1668 (1000_5F9C / 0x15F9C)
    SI = 0x1668;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_5F9F_015F9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5F9F_015F9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5F9F_15F9F:
    // CALL 0x1000:c07c (1000_5F9F / 0x15F9F)
    NearCall(cs1, 0x5FA2, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5FA2_015FA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5FA2_015FA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5FA2_15FA2:
    // MOV word ptr [0xdbe0],0x0 (1000_5FA2 / 0x15FA2)
    UInt16[DS, 0xDBE0] = 0x0;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_5FA8 / 0x15FA8)
    NearCall(cs1, 0x5FAB, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5FAB_015FAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5FAB_015FAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5FAB_15FAB:
    // MOV AL,0x8 (1000_5FAB / 0x15FAB)
    AL = 0x8;
    State.IncCycles();
    // JMP 0x1000:7b2b (1000_5FAD / 0x15FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B2B_017B2B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5FB0_015FB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5FB0_15FB0:
    // CALL 0x1000:58fa (1000_5FB0 / 0x15FB0)
    NearCall(cs1, 0x5FB3, spice86_generated_label_call_target_1000_58FA_0158FA);
    State.IncCycles();
    label_1000_5FB3_15FB3:
    // CALL 0x1000:7b36 (1000_5FB3 / 0x15FB3)
    NearCall(cs1, 0x5FB6, spice86_generated_label_call_target_1000_7B36_017B36);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5FB6_015FB6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5FB6_015FB6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5FB6_15FB6:
    // CMP DI,word ptr [0x114e] (1000_5FB6 / 0x15FB6)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JZ 0x1000:600e (1000_5FBA / 0x15FBA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x8],0xff (1000_5FBC / 0x15FBC)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    State.IncCycles();
    // JZ 0x1000:5ff9 (1000_5FC1 / 0x15FC1)
    if(ZeroFlag) {
      goto label_1000_5FF9_15FF9;
    }
    State.IncCycles();
    // CMP byte ptr [0xb],0x2 (1000_5FC3 / 0x15FC3)
    Alu.Sub8(UInt8[DS, 0xB], 0x2);
    State.IncCycles();
    // JBE 0x1000:5fd8 (1000_5FC8 / 0x15FC8)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5FD8_15FD8;
    }
    State.IncCycles();
    // CMP byte ptr [0x8],0x20 (1000_5FCA / 0x15FCA)
    Alu.Sub8(UInt8[DS, 0x8], 0x20);
    State.IncCycles();
    // JNC 0x1000:600e (1000_5FCF / 0x15FCF)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x8],0x28 (1000_5FD1 / 0x15FD1)
    Alu.Sub8(UInt8[DS, 0x8], 0x28);
    State.IncCycles();
    // JNC 0x1000:600e (1000_5FD6 / 0x15FD6)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_5FD8_15FD8:
    // PUSH DI (1000_5FD8 / 0x15FD8)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_5FD9 / 0x15FD9)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_5FDD / 0x15FDD)
    NearCall(cs1, 0x5FE0, spice86_generated_label_call_target_1000_7F27_017F27);
    State.IncCycles();
    label_1000_5FE0_15FE0:
    // POP DI (1000_5FE0 / 0x15FE0)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV BP,0x20da (1000_5FE1 / 0x15FE1)
    BP = 0x20DA;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (1000_5FE4 / 0x15FE4)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // AND AH,0x1f (1000_5FE7 / 0x15FE7)
    AH &= 0x1F;
    State.IncCycles();
    // CMP byte ptr [0x46ff],0x0 (1000_5FEA / 0x15FEA)
    Alu.Sub8(UInt8[DS, 0x46FF], 0x0);
    State.IncCycles();
    // JNZ 0x1000:5ff4 (1000_5FEF / 0x15FEF)
    if(!ZeroFlag) {
      goto label_1000_5FF4_15FF4;
    }
    State.IncCycles();
    // OR AH,0x40 (1000_5FF1 / 0x15FF1)
    // AH |= 0x40;
    AH = Alu.Or8(AH, 0x40);
    State.IncCycles();
    label_1000_5FF4_15FF4:
    // MOV word ptr [BP + 0x2],AX (1000_5FF4 / 0x15FF4)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // JMP 0x1000:6003 (1000_5FF7 / 0x15FF7)
    goto label_1000_6003_16003;
    State.IncCycles();
    label_1000_5FF9_15FF9:
    // TEST byte ptr [0xa],0x40 (1000_5FF9 / 0x15FF9)
    Alu.And8(UInt8[DS, 0xA], 0x40);
    State.IncCycles();
    // JZ 0x1000:600e (1000_5FFE / 0x15FFE)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_600E_01600E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BP,0x20e6 (1000_6000 / 0x16000)
    BP = 0x20E6;
    State.IncCycles();
    label_1000_6003_16003:
    // PUSH BP (1000_6003 / 0x16003)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:600e (1000_6004 / 0x16004)
    NearCall(cs1, 0x6007, spice86_generated_label_call_target_1000_600E_01600E);
    State.IncCycles();
    label_1000_6007_16007:
    // POP BP (1000_6007 / 0x16007)
    BP = Stack.Pop();
    State.IncCycles();
    // MOV BX,0x5f91 (1000_6008 / 0x16008)
    BX = 0x5F91;
    State.IncCycles();
    // JMP 0x1000:d323 (1000_600B / 0x1600B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_600E_01600E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_600E_1600E:
    // CALL 0x1000:c08e (1000_600E / 0x1600E)
    NearCall(cs1, 0x6011, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    label_1000_6011_16011:
    // PUSH DI (1000_6011 / 0x16011)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:5ee4 (1000_6012 / 0x16012)
    NearCall(cs1, 0x6015, spice86_generated_label_call_target_1000_5EE4_015EE4);
    State.IncCycles();
    label_1000_6015_16015:
    // POP DI (1000_6015 / 0x16015)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0x46f8],DI (1000_6016 / 0x16016)
    UInt16[DS, 0x46F8] = DI;
    State.IncCycles();
    // CALL 0x1000:d068 (1000_601A / 0x1601A)
    NearCall(cs1, 0x601D, spice86_generated_label_call_target_1000_D068_01D068);
    State.IncCycles();
    label_1000_601D_1601D:
    // MOV CL,0x9a (1000_601D / 0x1601D)
    CL = 0x9A;
    State.IncCycles();
    // MOV CH,byte ptr [0x1671] (1000_601F / 0x1601F)
    CH = UInt8[DS, 0x1671];
    State.IncCycles();
    // MOV DX,word ptr [0x1668] (1000_6023 / 0x16023)
    DX = UInt16[DS, 0x1668];
    State.IncCycles();
    // MOV BX,word ptr [0x166a] (1000_6027 / 0x16027)
    BX = UInt16[DS, 0x166A];
    State.IncCycles();
    // ADD DX,0xc (1000_602B / 0x1602B)
    DX += 0xC;
    State.IncCycles();
    // ADD BX,0x4 (1000_602E / 0x1602E)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    State.IncCycles();
    // CALL 0x1000:629d (1000_6031 / 0x16031)
    NearCall(cs1, 0x6034, spice86_generated_label_call_target_1000_629D_01629D);
    State.IncCycles();
    label_1000_6034_16034:
    // MOV CL,0x96 (1000_6034 / 0x16034)
    CL = 0x96;
    State.IncCycles();
    // SUB DX,0x8 (1000_6036 / 0x16036)
    DX -= 0x8;
    State.IncCycles();
    // ADD BX,0x9 (1000_6039 / 0x16039)
    // BX += 0x9;
    BX = Alu.Add16(BX, 0x9);
    State.IncCycles();
    // CALL 0x1000:62a6 (1000_603C / 0x1603C)
    NearCall(cs1, 0x603F, spice86_generated_label_call_target_1000_62A6_0162A6);
    State.IncCycles();
    label_1000_603F_1603F:
    // CALL 0x1000:6252 (1000_603F / 0x1603F)
    NearCall(cs1, 0x6042, spice86_generated_label_call_target_1000_6252_016252);
    State.IncCycles();
    label_1000_6042_16042:
    // CMP AL,0x2 (1000_6042 / 0x16042)
    Alu.Sub8(AL, 0x2);
    State.IncCycles();
    // JZ 0x1000:6059 (1000_6044 / 0x16044)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:c07c (1000_6059 / 0x16059)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST byte ptr [0xa],0x20 (1000_6046 / 0x16046)
    Alu.And8(UInt8[DS, 0xA], 0x20);
    State.IncCycles();
    // JZ 0x1000:6056 (1000_604B / 0x1604B)
    if(ZeroFlag) {
      goto label_1000_6056_16056;
    }
    State.IncCycles();
    // OR AL,AL (1000_604D / 0x1604D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:6056 (1000_604F / 0x1604F)
    if(!ZeroFlag) {
      goto label_1000_6056_16056;
    }
    State.IncCycles();
    // PUSH AX (1000_6051 / 0x16051)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:605c (1000_6052 / 0x16052)
    NearCall(cs1, 0x6055, not_observed_1000_605C_01605C);
    State.IncCycles();
    // POP AX (1000_6055 / 0x16055)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_6056_16056:
    // CALL 0x1000:60ac (1000_6056 / 0x16056)
    NearCall(cs1, 0x6059, not_observed_1000_60AC_0160AC);
    State.IncCycles();
    label_1000_6059_16059:
    // JMP 0x1000:c07c (1000_6059 / 0x16059)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_605C_01605C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_605C_1605C:
    // CALL 0x1000:d075 (1000_605C / 0x1605C)
    NearCall(cs1, 0x605F, spice86_generated_label_call_target_1000_D075_01D075);
    State.IncCycles();
    // MOV CL,0x90 (1000_605F / 0x1605F)
    CL = 0x90;
    State.IncCycles();
    // ADD BX,0xa (1000_6061 / 0x16061)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    State.IncCycles();
    // MOV DX,word ptr [0x1668] (1000_6064 / 0x16064)
    DX = UInt16[DS, 0x1668];
    State.IncCycles();
    // ADD DX,0x4 (1000_6068 / 0x16068)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    State.IncCycles();
    // MOV AX,0x6c (1000_606B / 0x1606B)
    AX = 0x6C;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_606E / 0x1606E)
    NearCall(cs1, 0x6071, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x1b] (1000_6071 / 0x16071)
    AL = UInt8[DS, (ushort)(DI + 0x1B)];
    State.IncCycles();
    // MOV SI,0x75 (1000_6074 / 0x16074)
    SI = 0x75;
    State.IncCycles();
    // MOV BP,0x6d (1000_6077 / 0x16077)
    BP = 0x6D;
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x20 (1000_607A / 0x1607A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x20);
    State.IncCycles();
    // JZ 0x1000:609d (1000_607E / 0x1607E)
    if(ZeroFlag) {
      goto label_1000_609D_1609D;
    }
    State.IncCycles();
    // PUSH CX (1000_6080 / 0x16080)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH AX (1000_6081 / 0x16081)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_6082 / 0x16082)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:e295 (1000_6083 / 0x16083)
    NearCall(cs1, 0x6086, not_observed_1000_E295_01E295);
    State.IncCycles();
    // POP AX (1000_6086 / 0x16086)
    AX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_6087 / 0x16087)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD BX,0x7 (1000_6088 / 0x16088)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    State.IncCycles();
    // MOV DX,word ptr [0x1668] (1000_608B / 0x1608B)
    DX = UInt16[DS, 0x1668];
    State.IncCycles();
    // ADD DX,0x4 (1000_608F / 0x1608F)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    State.IncCycles();
    // MOV BP,word ptr [0x166c] (1000_6092 / 0x16092)
    BP = UInt16[DS, 0x166C];
    State.IncCycles();
    // PUSH BX (1000_6096 / 0x16096)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:617a (1000_6097 / 0x16097)
    NearCall(cs1, 0x609A, not_observed_1000_617A_01617A);
    State.IncCycles();
    // POP BX (1000_609A / 0x1609A)
    BX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_609B / 0x1609B)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_609C / 0x1609C)
    return NearRet();
    State.IncCycles();
    label_1000_609D_1609D:
    // MOV AX,BP (1000_609D / 0x1609D)
    AX = BP;
    State.IncCycles();
    // ADD BX,0x7 (1000_609F / 0x1609F)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    State.IncCycles();
    // MOV DX,word ptr [0x1668] (1000_60A2 / 0x160A2)
    DX = UInt16[DS, 0x1668];
    State.IncCycles();
    // ADD DX,0xa (1000_60A6 / 0x160A6)
    // DX += 0xA;
    DX = Alu.Add16(DX, 0xA);
    State.IncCycles();
    // JMP 0x1000:d194 (1000_60A9 / 0x160A9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_60AC_0160AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_60AC_160AC:
    // CALL 0x1000:c13b (1000_60AC / 0x160AC)
    NearCall(cs1, 0x60AF, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    // CALL 0x1000:d068 (1000_60AF / 0x160AF)
    NearCall(cs1, 0x60B2, spice86_generated_label_call_target_1000_D068_01D068);
    State.IncCycles();
    // MOV CL,0x9a (1000_60B2 / 0x160B2)
    CL = 0x9A;
    State.IncCycles();
    // MOV DX,word ptr [0x1668] (1000_60B4 / 0x160B4)
    DX = UInt16[DS, 0x1668];
    State.IncCycles();
    // ADD BX,0xc (1000_60B8 / 0x160B8)
    BX += 0xC;
    State.IncCycles();
    // ADD DX,0x4 (1000_60BB / 0x160BB)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    State.IncCycles();
    // CALL 0x1000:627e (1000_60BE / 0x160BE)
    NearCall(cs1, 0x60C1, spice86_generated_label_call_target_1000_627E_01627E);
    State.IncCycles();
    // JC 0x1000:60d6 (1000_60C1 / 0x160C1)
    if(CarryFlag) {
      goto label_1000_60D6_160D6;
    }
    State.IncCycles();
    // MOV AX,0x6e (1000_60C3 / 0x160C3)
    AX = 0x6E;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_60C6 / 0x160C6)
    NearCall(cs1, 0x60C9, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // ADD BX,0xa (1000_60C9 / 0x160C9)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    State.IncCycles();
    // LEA SI,[DI + 0x14] (1000_60CC / 0x160CC)
    SI = (ushort)(DI + 0x14);
    State.IncCycles();
    // MOV BP,word ptr [0x166e] (1000_60CF / 0x160CF)
    BP = UInt16[DS, 0x166E];
    State.IncCycles();
    // JMP 0x1000:7e3d (1000_60D3 / 0x160D3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7E3D_017E3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_60D6_160D6:
    // MOV AX,0x4c (1000_60D6 / 0x160D6)
    AX = 0x4C;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_60D9 / 0x160D9)
    NearCall(cs1, 0x60DC, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // ADD BX,0x6 (1000_60DC / 0x160DC)
    BX += 0x6;
    State.IncCycles();
    // ADD DX,0x2f (1000_60DF / 0x160DF)
    // DX += 0x2F;
    DX = Alu.Add16(DX, 0x2F);
    State.IncCycles();
    // PUSH BX (1000_60E2 / 0x160E2)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_60E3 / 0x160E3)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:60f8 (1000_60E4 / 0x160E4)
    NearCall(cs1, 0x60E7, not_observed_1000_60F8_0160F8);
    State.IncCycles();
    // XOR AH,AH (1000_60E7 / 0x160E7)
    AH = 0;
    State.IncCycles();
    // ADD AX,0xf (1000_60E9 / 0x160E9)
    // AX += 0xF;
    AX = Alu.Add16(AX, 0xF);
    State.IncCycles();
    // MOV CL,0x5 (1000_60EC / 0x160EC)
    CL = 0x5;
    State.IncCycles();
    // SHR AX,CL (1000_60EE / 0x160EE)
    AX >>= CL;
    State.IncCycles();
    // ADD AX,0x8e (1000_60F0 / 0x160F0)
    // AX += 0x8E;
    AX = Alu.Add16(AX, 0x8E);
    State.IncCycles();
    // POP DX (1000_60F3 / 0x160F3)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_60F4 / 0x160F4)
    BX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c22f (1000_60F5 / 0x160F5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_60F8_0160F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_60F8_160F8:
    // XOR BX,BX (1000_60F8 / 0x160F8)
    BX = 0;
    State.IncCycles();
    // XOR CX,CX (1000_60FA / 0x160FA)
    CX = 0;
    State.IncCycles();
    // XOR DX,DX (1000_60FC / 0x160FC)
    DX = 0;
    State.IncCycles();
    // MOV word ptr [0xd81c],DX (1000_60FE / 0x160FE)
    UInt16[DS, 0xD81C] = DX;
    State.IncCycles();
    // MOV BP,0x6155 (1000_6102 / 0x16102)
    BP = 0x6155;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_6105 / 0x16105)
    NearCall(cs1, 0x6108, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // XOR AX,AX (1000_6108 / 0x16108)
    AX = 0;
    State.IncCycles();
    // ADD BX,DX (1000_610A / 0x1610A)
    // BX += DX;
    BX = Alu.Add16(BX, DX);
    State.IncCycles();
    // JZ 0x1000:6114 (1000_610C / 0x1610C)
    if(ZeroFlag) {
      goto label_1000_6114_16114;
    }
    State.IncCycles();
    // XCHG DL,AH (1000_610E / 0x1610E)
    byte tmp_1000_610E = DL;
    DL = AH;
    AH = tmp_1000_610E;
    State.IncCycles();
    // XCHG DL,DH (1000_6110 / 0x16110)
    byte tmp_1000_6110 = DL;
    DL = DH;
    DH = tmp_1000_6110;
    State.IncCycles();
    // DIV BX (1000_6112 / 0x16112)
    Cpu.Div16(BX);
    State.IncCycles();
    label_1000_6114_16114:
    // MOV BX,AX (1000_6114 / 0x16114)
    BX = AX;
    State.IncCycles();
    // XOR AX,AX (1000_6116 / 0x16116)
    AX = 0;
    State.IncCycles();
    // MOV DX,word ptr [0xd81c] (1000_6118 / 0x16118)
    DX = UInt16[DS, 0xD81C];
    State.IncCycles();
    // ADD CX,DX (1000_611C / 0x1611C)
    // CX += DX;
    CX = Alu.Add16(CX, DX);
    State.IncCycles();
    // JZ 0x1000:6126 (1000_611E / 0x1611E)
    if(ZeroFlag) {
      goto label_1000_6126_16126;
    }
    State.IncCycles();
    // XCHG DL,AH (1000_6120 / 0x16120)
    byte tmp_1000_6120 = DL;
    DL = AH;
    AH = tmp_1000_6120;
    State.IncCycles();
    // XCHG DL,DH (1000_6122 / 0x16122)
    byte tmp_1000_6122 = DL;
    DL = DH;
    DH = tmp_1000_6122;
    State.IncCycles();
    // DIV CX (1000_6124 / 0x16124)
    Cpu.Div16(CX);
    State.IncCycles();
    label_1000_6126_16126:
    // MOV CX,AX (1000_6126 / 0x16126)
    CX = AX;
    State.IncCycles();
    // MOV SI,BX (1000_6128 / 0x16128)
    SI = BX;
    State.IncCycles();
    // CMP SI,CX (1000_612A / 0x1612A)
    Alu.Sub16(SI, CX);
    State.IncCycles();
    // JNC 0x1000:6130 (1000_612C / 0x1612C)
    if(!CarryFlag) {
      goto label_1000_6130_16130;
    }
    State.IncCycles();
    // MOV SI,CX (1000_612E / 0x1612E)
    SI = CX;
    State.IncCycles();
    label_1000_6130_16130:
    // MOV AX,BX (1000_6130 / 0x16130)
    AX = BX;
    State.IncCycles();
    // SUB AX,CX (1000_6132 / 0x16132)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // OR SI,SI (1000_6134 / 0x16134)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:613f (1000_6136 / 0x16136)
    if(ZeroFlag) {
      goto label_1000_613F_1613F;
    }
    State.IncCycles();
    // CWD  (1000_6138 / 0x16138)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    State.IncCycles();
    // XCHG AH,AL (1000_6139 / 0x16139)
    byte tmp_1000_6139 = AH;
    AH = AL;
    AL = tmp_1000_6139;
    State.IncCycles();
    // XCHG DL,AL (1000_613B / 0x1613B)
    byte tmp_1000_613B = DL;
    DL = AL;
    AL = tmp_1000_613B;
    State.IncCycles();
    // IDIV SI (1000_613D / 0x1613D)
    Cpu.IDiv16(SI);
    State.IncCycles();
    label_1000_613F_1613F:
    // SAR AX,1 (1000_613F / 0x1613F)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // ADD AL,0x80 (1000_6141 / 0x16141)
    // AL += 0x80;
    AL = Alu.Add8(AL, 0x80);
    State.IncCycles();
    // RET  (1000_6143 / 0x16143)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6144_016144(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6144_16144:
    // CALL 0x1000:e270 (1000_6144 / 0x16144)
    NearCall(cs1, 0x6147, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // PUSH ES (1000_6147 / 0x16147)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:60f8 (1000_6148 / 0x16148)
    NearCall(cs1, 0x614B, not_observed_1000_60F8_0160F8);
    State.IncCycles();
    // OR AL,0x1 (1000_614B / 0x1614B)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    State.IncCycles();
    // MOV [0xfd],AL (1000_614D / 0x1614D)
    UInt8[DS, 0xFD] = AL;
    State.IncCycles();
    // POP ES (1000_6150 / 0x16150)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_6151 / 0x16151)
    NearCall(cs1, 0x6154, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // RET  (1000_6154 / 0x16154)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_617A_01617A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_617A_1617A:
    // AND CX,0xff (1000_617A / 0x1617A)
    // CX &= 0xFF;
    CX = Alu.And16(CX, 0xFF);
    State.IncCycles();
    // JZ 0x1000:61d2 (1000_617E / 0x1617E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_61D2 / 0x161D2)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_6180 / 0x16180)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DI (1000_6181 / 0x16181)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH AX (1000_6182 / 0x16182)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DX (1000_6183 / 0x16183)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_6184 / 0x16184)
    NearCall(cs1, 0x6187, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    // MOV DI,BP (1000_6187 / 0x16187)
    DI = BP;
    State.IncCycles();
    // SUB DI,DX (1000_6189 / 0x16189)
    // DI -= DX;
    DI = Alu.Sub16(DI, DX);
    State.IncCycles();
    // MOV BP,word ptr ES:[SI] (1000_618B / 0x1618B)
    BP = UInt16[ES, SI];
    State.IncCycles();
    // AND BP,0xfff (1000_618E / 0x1618E)
    BP &= 0xFFF;
    State.IncCycles();
    // ADD BP,0x2 (1000_6192 / 0x16192)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    State.IncCycles();
    // MOV AX,DI (1000_6195 / 0x16195)
    AX = DI;
    State.IncCycles();
    // XOR DX,DX (1000_6197 / 0x16197)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_6199 / 0x16199)
    Cpu.Div16(CX);
    State.IncCycles();
    // CMP AX,BP (1000_619B / 0x1619B)
    Alu.Sub16(AX, BP);
    State.IncCycles();
    // JNC 0x1000:61b5 (1000_619D / 0x1619D)
    if(!CarryFlag) {
      goto label_1000_61B5_161B5;
    }
    State.IncCycles();
    // SUB DI,BP (1000_619F / 0x1619F)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    State.IncCycles();
    // MOV AX,DI (1000_61A1 / 0x161A1)
    AX = DI;
    State.IncCycles();
    // XOR DX,DX (1000_61A3 / 0x161A3)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_61A5 / 0x161A5)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV BP,AX (1000_61A7 / 0x161A7)
    BP = AX;
    State.IncCycles();
    // CMP BP,0x2 (1000_61A9 / 0x161A9)
    Alu.Sub16(BP, 0x2);
    State.IncCycles();
    // JNC 0x1000:61b5 (1000_61AC / 0x161AC)
    if(!CarryFlag) {
      goto label_1000_61B5_161B5;
    }
    State.IncCycles();
    // MOV BP,0x2 (1000_61AE / 0x161AE)
    BP = 0x2;
    State.IncCycles();
    // MOV CX,DI (1000_61B1 / 0x161B1)
    CX = DI;
    State.IncCycles();
    // SHR CX,1 (1000_61B3 / 0x161B3)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    label_1000_61B5_161B5:
    // POP DX (1000_61B5 / 0x161B5)
    DX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_61B6 / 0x161B6)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_61B7_161B7:
    // PUSH AX (1000_61B7 / 0x161B7)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_61B8 / 0x161B8)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_61B9 / 0x161B9)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_61BA / 0x161BA)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BP (1000_61BB / 0x161BB)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:c22f (1000_61BC / 0x161BC)
    NearCall(cs1, 0x61BF, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    // POP BP (1000_61BF / 0x161BF)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_61C0 / 0x161C0)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_61C1 / 0x161C1)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_61C2 / 0x161C2)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_61C3 / 0x161C3)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD DX,BP (1000_61C4 / 0x161C4)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    State.IncCycles();
    // LOOP 0x1000:61b7 (1000_61C6 / 0x161C6)
    if(--CX != 0) {
      goto label_1000_61B7_161B7;
    }
    State.IncCycles();
    // POP DI (1000_61C8 / 0x161C8)
    DI = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_61C9 / 0x161C9)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_61CA / 0x161CA)
    NearCall(cs1, 0x61CD, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    // ADD BL,byte ptr ES:[SI + 0x2] (1000_61CD / 0x161CD)
    BL += UInt8[ES, (ushort)(SI + 0x2)];
    State.IncCycles();
    // INC BX (1000_61D1 / 0x161D1)
    BX = Alu.Inc16(BX);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_61D3_0161D3, 0x161D2 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_61D3_0161D3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x61D2: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_61D2_161D2:
    // RET  (1000_61D2 / 0x161D2)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_61D3_161D3:
    // AND CX,0xff (1000_61D3 / 0x161D3)
    // CX &= 0xFF;
    CX = Alu.And16(CX, 0xFF);
    State.IncCycles();
    // JZ 0x1000:61d2 (1000_61D7 / 0x161D7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_61D2 / 0x161D2)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_61D9 / 0x161D9)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DI (1000_61DA / 0x161DA)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH AX (1000_61DB / 0x161DB)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DX (1000_61DC / 0x161DC)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_61DD / 0x161DD)
    NearCall(cs1, 0x61E0, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    label_1000_61E0_161E0:
    // MOV DI,BP (1000_61E0 / 0x161E0)
    DI = BP;
    State.IncCycles();
    // SUB DI,BX (1000_61E2 / 0x161E2)
    // DI -= BX;
    DI = Alu.Sub16(DI, BX);
    State.IncCycles();
    // MOV BP,word ptr ES:[SI + 0x2] (1000_61E4 / 0x161E4)
    BP = UInt16[ES, (ushort)(SI + 0x2)];
    State.IncCycles();
    // AND BP,0xff (1000_61E8 / 0x161E8)
    BP &= 0xFF;
    State.IncCycles();
    // ADD BP,0x2 (1000_61EC / 0x161EC)
    // BP += 0x2;
    BP = Alu.Add16(BP, 0x2);
    State.IncCycles();
    // MOV AX,DI (1000_61EF / 0x161EF)
    AX = DI;
    State.IncCycles();
    // XOR DX,DX (1000_61F1 / 0x161F1)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_61F3 / 0x161F3)
    Cpu.Div16(CX);
    State.IncCycles();
    // CMP AX,BP (1000_61F5 / 0x161F5)
    Alu.Sub16(AX, BP);
    State.IncCycles();
    // JNC 0x1000:620f (1000_61F7 / 0x161F7)
    if(!CarryFlag) {
      goto label_1000_620F_1620F;
    }
    State.IncCycles();
    // SUB DI,BP (1000_61F9 / 0x161F9)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    State.IncCycles();
    // MOV AX,DI (1000_61FB / 0x161FB)
    AX = DI;
    State.IncCycles();
    // XOR DX,DX (1000_61FD / 0x161FD)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_61FF / 0x161FF)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV BP,AX (1000_6201 / 0x16201)
    BP = AX;
    State.IncCycles();
    // CMP BP,0x2 (1000_6203 / 0x16203)
    Alu.Sub16(BP, 0x2);
    State.IncCycles();
    // JNC 0x1000:620f (1000_6206 / 0x16206)
    if(!CarryFlag) {
      goto label_1000_620F_1620F;
    }
    State.IncCycles();
    // MOV BP,0x2 (1000_6208 / 0x16208)
    BP = 0x2;
    State.IncCycles();
    // MOV CX,DI (1000_620B / 0x1620B)
    CX = DI;
    State.IncCycles();
    // SHR CX,1 (1000_620D / 0x1620D)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    label_1000_620F_1620F:
    // POP DX (1000_620F / 0x1620F)
    DX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_6210 / 0x16210)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_6211_016211, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6211_016211(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6211_16211:
    // PUSH AX (1000_6211 / 0x16211)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_6212 / 0x16212)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_6213 / 0x16213)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_6214 / 0x16214)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BP (1000_6215 / 0x16215)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:c22f (1000_6216 / 0x16216)
    NearCall(cs1, 0x6219, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_6219_16219:
    // POP BP (1000_6219 / 0x16219)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_621A / 0x1621A)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_621B / 0x1621B)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_621C / 0x1621C)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_621D / 0x1621D)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD BX,BP (1000_621E / 0x1621E)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    State.IncCycles();
    // LOOP 0x1000:6211 (1000_6220 / 0x16220)
    if(--CX != 0) {
      goto label_1000_6211_16211;
    }
    State.IncCycles();
    // POP DI (1000_6222 / 0x16222)
    DI = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_6223 / 0x16223)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_6224 / 0x16224)
    NearCall(cs1, 0x6227, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    label_1000_6227_16227:
    // MOV AX,word ptr ES:[SI] (1000_6227 / 0x16227)
    AX = UInt16[ES, SI];
    State.IncCycles();
    // AND AH,0xf (1000_622A / 0x1622A)
    AH &= 0xF;
    State.IncCycles();
    // ADD DX,AX (1000_622D / 0x1622D)
    DX += AX;
    State.IncCycles();
    // INC DX (1000_622F / 0x1622F)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // RET  (1000_6230 / 0x16230)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6231_016231(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6231_16231:
    // PUSH BX (1000_6231 / 0x16231)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BL,byte ptr [DI + 0x8] (1000_6232 / 0x16232)
    BL = UInt8[DS, (ushort)(DI + 0x8)];
    State.IncCycles();
    // XOR AX,AX (1000_6235 / 0x16235)
    AX = 0;
    State.IncCycles();
    // CMP BL,0x20 (1000_6237 / 0x16237)
    Alu.Sub8(BL, 0x20);
    State.IncCycles();
    // JC 0x1000:6250 (1000_623A / 0x1623A)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    State.IncCycles();
    // INC AX (1000_623C / 0x1623C)
    AX++;
    State.IncCycles();
    // CMP BL,0x21 (1000_623D / 0x1623D)
    Alu.Sub8(BL, 0x21);
    State.IncCycles();
    // JC 0x1000:6250 (1000_6240 / 0x16240)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    State.IncCycles();
    // INC AX (1000_6242 / 0x16242)
    AX++;
    State.IncCycles();
    // CMP BL,0x28 (1000_6243 / 0x16243)
    Alu.Sub8(BL, 0x28);
    State.IncCycles();
    // JC 0x1000:6250 (1000_6246 / 0x16246)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    State.IncCycles();
    // INC AX (1000_6248 / 0x16248)
    AX++;
    State.IncCycles();
    // CMP BL,0x30 (1000_6249 / 0x16249)
    Alu.Sub8(BL, 0x30);
    State.IncCycles();
    // JC 0x1000:6250 (1000_624C / 0x1624C)
    if(CarryFlag) {
      goto label_1000_6250_16250;
    }
    State.IncCycles();
    // SUB AL,0x2 (1000_624E / 0x1624E)
    // AL -= 0x2;
    AL = Alu.Sub8(AL, 0x2);
    State.IncCycles();
    label_1000_6250_16250:
    // POP BX (1000_6250 / 0x16250)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6251 / 0x16251)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6252_016252(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6252_16252:
    // CALL 0x1000:627e (1000_6252 / 0x16252)
    NearCall(cs1, 0x6255, spice86_generated_label_call_target_1000_627E_01627E);
    State.IncCycles();
    label_1000_6255_16255:
    // JC 0x1000:627a (1000_6255 / 0x16255)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6269_016269, 0x1627A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_6257 / 0x16257)
    NearCall(cs1, 0x625A, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    label_1000_625A_1625A:
    // MOV AX,0x2 (1000_625A / 0x1625A)
    AX = 0x2;
    State.IncCycles();
    // JC 0x1000:6260 (1000_625D / 0x1625D)
    if(CarryFlag) {
      goto label_1000_6260_16260;
    }
    State.IncCycles();
    // RET  (1000_625F / 0x1625F)
    return NearRet();
    State.IncCycles();
    label_1000_6260_16260:
    // TEST byte ptr [DI + 0xa],0x10 (1000_6260 / 0x16260)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x10);
    State.IncCycles();
    // JZ 0x1000:627d (1000_6264 / 0x16264)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_627D / 0x1627D)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:6231 (1000_6266 / 0x16266)
    NearCall(cs1, 0x6269, spice86_generated_label_call_target_1000_6231_016231);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6269_016269, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6269_016269(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6269_16269:
    // OR AX,AX (1000_6269 / 0x16269)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:627d (1000_626B / 0x1626B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_627D / 0x1627D)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0x3 (1000_626D / 0x1626D)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:6274 (1000_626F / 0x1626F)
    if(!ZeroFlag) {
      goto label_1000_6274_16274;
    }
    State.IncCycles();
    // XOR AX,AX (1000_6271 / 0x16271)
    AX = 0;
    State.IncCycles();
    // RET  (1000_6273 / 0x16273)
    return NearRet();
    State.IncCycles();
    label_1000_6274_16274:
    // CMP AL,0x2 (1000_6274 / 0x16274)
    Alu.Sub8(AL, 0x2);
    State.IncCycles();
    // MOV AL,0x2 (1000_6276 / 0x16276)
    AL = 0x2;
    State.IncCycles();
    // JNZ 0x1000:627d (1000_6278 / 0x16278)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_627D / 0x1627D)
      return NearRet();
    }
    State.IncCycles();
    label_1000_627A_1627A:
    // MOV AX,0x1 (1000_627A / 0x1627A)
    AX = 0x1;
    State.IncCycles();
    label_1000_627D_1627D:
    // RET  (1000_627D / 0x1627D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_627E_01627E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_627E_1627E:
    // CALL 0x1000:e270 (1000_627E / 0x1627E)
    NearCall(cs1, 0x6281, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_6281_16281:
    // TEST byte ptr [DI + 0xa],0x2 (1000_6281 / 0x16281)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JNZ 0x1000:6293 (1000_6285 / 0x16285)
    if(!ZeroFlag) {
      goto label_1000_6293_16293;
    }
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_6287 / 0x16287)
    NearCall(cs1, 0x628A, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    label_1000_628A_1628A:
    // JC 0x1000:6298 (1000_628A / 0x1628A)
    if(CarryFlag) {
      goto label_1000_6298_16298;
    }
    State.IncCycles();
    // CALL 0x1000:5098 (1000_628C / 0x1628C)
    NearCall(cs1, 0x628F, not_observed_1000_5098_015098);
    State.IncCycles();
    // OR DX,DX (1000_628F / 0x1628F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:6298 (1000_6291 / 0x16291)
    if(ZeroFlag) {
      goto label_1000_6298_16298;
    }
    State.IncCycles();
    label_1000_6293_16293:
    // CALL 0x1000:e283 (1000_6293 / 0x16293)
    NearCall(cs1, 0x6296, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // STC  (1000_6296 / 0x16296)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_6297 / 0x16297)
    return NearRet();
    State.IncCycles();
    label_1000_6298_16298:
    // CALL 0x1000:e283 (1000_6298 / 0x16298)
    NearCall(cs1, 0x629B, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_629B_1629B:
    // CLC  (1000_629B / 0x1629B)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_629C / 0x1629C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_629D_01629D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_629D_1629D:
    // CALL 0x1000:6231 (1000_629D / 0x1629D)
    NearCall(cs1, 0x62A0, spice86_generated_label_call_target_1000_6231_016231);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_62A0_0162A0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_62A0_0162A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62A0_162A0:
    // ADD AX,0x44 (1000_62A0 / 0x162A0)
    // AX += 0x44;
    AX = Alu.Add16(AX, 0x44);
    State.IncCycles();
    // JMP 0x1000:d194 (1000_62A3 / 0x162A3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_62A6_0162A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62A6_162A6:
    // MOV AL,byte ptr [DI] (1000_62A6 / 0x162A6)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // XOR AH,AH (1000_62A8 / 0x162A8)
    AH = 0;
    State.IncCycles();
    // ADD AX,0x0 (1000_62AA / 0x162AA)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    State.IncCycles();
    // CALL 0x1000:d194 (1000_62AD / 0x162AD)
    NearCall(cs1, 0x62B0, spice86_generated_label_call_target_1000_D194_01D194);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_62B0_0162B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_62B0_0162B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62B0_162B0:
    // CMP byte ptr [DI + 0x1],0x3 (1000_62B0 / 0x162B0)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x1)], 0x3);
    State.IncCycles();
    // MOV AL,0x20 (1000_62B4 / 0x162B4)
    AL = 0x20;
    State.IncCycles();
    // JC 0x1000:62ba (1000_62B6 / 0x162B6)
    if(CarryFlag) {
      goto label_1000_62BA_162BA;
    }
    State.IncCycles();
    // MOV AL,0x2d (1000_62B8 / 0x162B8)
    AL = 0x2D;
    State.IncCycles();
    label_1000_62BA_162BA:
    // CALL word ptr [0x2518] (1000_62BA / 0x162BA)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_62BA = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_62BA) {
      case 0xD12F : NearCall(cs1, 0x62BE, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      case 0xD096 : NearCall(cs1, 0x62BE, spice86_generated_label_call_target_1000_D096_01D096); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_62BA));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_62BE_0162BE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_62BE_0162BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62BE_162BE:
    // MOV AL,byte ptr [DI + 0x1] (1000_62BE / 0x162BE)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    State.IncCycles();
    // XOR AH,AH (1000_62C1 / 0x162C1)
    AH = 0;
    State.IncCycles();
    // ADD AX,0xc (1000_62C3 / 0x162C3)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    State.IncCycles();
    // JMP 0x1000:d19b (1000_62C6 / 0x162C6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D19B_01D19B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_62C9_0162C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62C9_162C9:
    // CMP byte ptr [0x46eb],0x1 (1000_62C9 / 0x162C9)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x1);
    State.IncCycles();
    // JC 0x1000:62f1 (1000_62CE / 0x162CE)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x2] (1000_62D0 / 0x162D0)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x4] (1000_62D3 / 0x162D3)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_62D6_0162D6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_62D6_0162D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62D6_162D6:
    // CALL 0x1000:b647 (1000_62D6 / 0x162D6)
    NearCall(cs1, 0x62D9, spice86_generated_label_call_target_1000_B647_01B647);
    State.IncCycles();
    label_1000_62D9_162D9:
    // CMP DX,word ptr [0x46e3] (1000_62D9 / 0x162D9)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    State.IncCycles();
    // JC 0x1000:62f1 (1000_62DD / 0x162DD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    State.IncCycles();
    // CMP DX,word ptr [0x46e7] (1000_62DF / 0x162DF)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    State.IncCycles();
    // CMC  (1000_62E3 / 0x162E3)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JC 0x1000:62f1 (1000_62E4 / 0x162E4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,word ptr [0x46e5] (1000_62E6 / 0x162E6)
    Alu.Sub16(BX, UInt16[DS, 0x46E5]);
    State.IncCycles();
    // JC 0x1000:62f1 (1000_62EA / 0x162EA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,word ptr [0x46e9] (1000_62EC / 0x162EC)
    Alu.Sub16(BX, UInt16[DS, 0x46E9]);
    State.IncCycles();
    // CMC  (1000_62F0 / 0x162F0)
    CarryFlag = !CarryFlag;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_62F1_0162F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_62F1_0162F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62F1_162F1:
    // RET  (1000_62F1 / 0x162F1)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_62F2_0162F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_62F2_162F2:
    // CALL 0x1000:68eb (1000_62F2 / 0x162F2)
    NearCall(cs1, 0x62F5, spice86_generated_label_call_target_1000_68EB_0168EB);
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_62F5 / 0x162F5)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:6306 (1000_62F9 / 0x162F9)
    if(!ZeroFlag) {
      goto label_1000_6306_16306;
    }
    State.IncCycles();
    // MOV SI,word ptr [SI + 0x4] (1000_62FB / 0x162FB)
    SI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL 0x1000:62c9 (1000_62FE / 0x162FE)
    NearCall(cs1, 0x6301, spice86_generated_label_call_target_1000_62C9_0162C9);
    State.IncCycles();
    // MOV AX,0x36 (1000_6301 / 0x16301)
    AX = 0x36;
    State.IncCycles();
    // JMP 0x1000:6322 (1000_6304 / 0x16304)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6317_016317, 0x16322 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_6306_16306:
    // MOV DX,word ptr [SI + 0x6] (1000_6306 / 0x16306)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x8] (1000_6309 / 0x16309)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // CALL 0x1000:62d6 (1000_630C / 0x1630C)
    NearCall(cs1, 0x630F, spice86_generated_label_call_target_1000_62D6_0162D6);
    State.IncCycles();
    // MOV AX,0x36 (1000_630F / 0x1630F)
    AX = 0x36;
    State.IncCycles();
    // JMP 0x1000:6322 (1000_6312 / 0x16312)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6317_016317, 0x16322 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6314_016314(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6314_16314:
    // CALL 0x1000:407e (1000_6314 / 0x16314)
    NearCall(cs1, 0x6317, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6317_016317, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6317_016317(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6317_16317:
    // CALL 0x1000:62d6 (1000_6317 / 0x16317)
    NearCall(cs1, 0x631A, spice86_generated_label_call_target_1000_62D6_0162D6);
    State.IncCycles();
    label_1000_631A_1631A:
    // MOV AX,0x4c (1000_631A / 0x1631A)
    AX = 0x4C;
    State.IncCycles();
    // PUSHF  (1000_631D / 0x1631D)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // SUB DX,0xd (1000_631E / 0x1631E)
    DX -= 0xD;
    State.IncCycles();
    // POPF  (1000_6321 / 0x16321)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    label_1000_6322_16322:
    // JC 0x1000:62f1 (1000_6322 / 0x16322)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_62F1 / 0x162F1)
      return NearRet();
    }
    State.IncCycles();
    // PUSH word ptr [0x2784] (1000_6324 / 0x16324)
    Stack.Push(UInt16[DS, 0x2784]);
    State.IncCycles();
    // PUSH AX (1000_6328 / 0x16328)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:c137 (1000_6329 / 0x16329)
    NearCall(cs1, 0x632C, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_632C_1632C:
    // POP AX (1000_632C / 0x1632C)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_632D / 0x1632D)
    NearCall(cs1, 0x6330, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    label_1000_6330_16330:
    // SUB BL,byte ptr ES:[SI + 0x2] (1000_6330 / 0x16330)
    // BL -= UInt8[ES, (ushort)(SI + 0x2)];
    BL = Alu.Sub8(BL, UInt8[ES, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // CALL 0x1000:c30d (1000_6334 / 0x16334)
    NearCall(cs1, 0x6337, spice86_generated_label_call_target_1000_C30D_01C30D);
    State.IncCycles();
    label_1000_6337_16337:
    // POP AX (1000_6337 / 0x16337)
    AX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c13e (1000_6338 / 0x16338)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_633B_01633B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_633B_1633B:
    // MOV DX,word ptr [0x197c] (1000_633B / 0x1633B)
    DX = UInt16[DS, 0x197C];
    State.IncCycles();
    // MOV BX,word ptr [0x197e] (1000_633F / 0x1633F)
    BX = UInt16[DS, 0x197E];
    State.IncCycles();
    // SUB BX,0x12 (1000_6343 / 0x16343)
    // BX -= 0x12;
    BX = Alu.Sub16(BX, 0x12);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6346_016346, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6346_016346(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6346_16346:
    // CALL 0x1000:634d (1000_6346 / 0x16346)
    NearCall(cs1, 0x6349, spice86_generated_label_call_target_1000_634D_01634D);
    State.IncCycles();
    label_1000_6349_16349:
    // INC BX (1000_6349 / 0x16349)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // JNC 0x1000:6346 (1000_634A / 0x1634A)
    if(!CarryFlag) {
      goto label_1000_6346_16346;
    }
    State.IncCycles();
    // RET  (1000_634C / 0x1634C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_634D_01634D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_634D_1634D:
    // PUSH BX (1000_634D / 0x1634D)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_634E / 0x1634E)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:62d6 (1000_634F / 0x1634F)
    NearCall(cs1, 0x6352, spice86_generated_label_call_target_1000_62D6_0162D6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6352_016352, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6352_016352(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6352_16352:
    // POP SI (1000_6352 / 0x16352)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_6353 / 0x16353)
    CX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:6369 (1000_6354 / 0x16354)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6369 / 0x16369)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_6356 / 0x16356)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_6357 / 0x16357)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_6358 / 0x16358)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_6359 / 0x16359)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:636a (1000_635A / 0x1635A)
    NearCall(cs1, 0x635D, spice86_generated_label_call_target_1000_636A_01636A);
    State.IncCycles();
    label_1000_635D_1635D:
    // POP SI (1000_635D / 0x1635D)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_635E / 0x1635E)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_635F / 0x1635F)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_6360 / 0x16360)
    BX = Stack.Pop();
    State.IncCycles();
    // PUSH CX (1000_6361 / 0x16361)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_6362 / 0x16362)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:639a (1000_6363 / 0x16363)
    NearCall(cs1, 0x6366, spice86_generated_label_call_target_1000_639A_01639A);
    State.IncCycles();
    label_1000_6366_16366:
    // POP DX (1000_6366 / 0x16366)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_6367 / 0x16367)
    BX = Stack.Pop();
    State.IncCycles();
    // CLC  (1000_6368 / 0x16368)
    CarryFlag = false;
    State.IncCycles();
    label_1000_6369_16369:
    // RET  (1000_6369 / 0x16369)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_636A_01636A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x6394: goto label_1000_6394_16394;break; // Target of external jump from 0x16386, 0x163B6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_636A_1636A:
    // XCHG SI,DX (1000_636A / 0x1636A)
    ushort tmp_1000_636A = SI;
    SI = DX;
    DX = tmp_1000_636A;
    State.IncCycles();
    // XCHG CX,BX (1000_636C / 0x1636C)
    ushort tmp_1000_636C = CX;
    CX = BX;
    BX = tmp_1000_636C;
    State.IncCycles();
    // CALL 0x1000:b58b (1000_636E / 0x1636E)
    NearCall(cs1, 0x6371, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    label_1000_6371_16371:
    // XCHG SI,DX (1000_6371 / 0x16371)
    ushort tmp_1000_6371 = SI;
    SI = DX;
    DX = tmp_1000_6371;
    State.IncCycles();
    // MOV BX,CX (1000_6373 / 0x16373)
    BX = CX;
    State.IncCycles();
    label_1000_6375_16375:
    // MOV AX,word ptr ES:[DI] (1000_6375 / 0x16375)
    AX = UInt16[ES, DI];
    State.IncCycles();
    // AND AX,0x3030 (1000_6378 / 0x16378)
    AX &= 0x3030;
    State.IncCycles();
    // CMP AL,0x10 (1000_637B / 0x1637B)
    Alu.Sub8(AL, 0x10);
    State.IncCycles();
    // JZ 0x1000:6395 (1000_637D / 0x1637D)
    if(ZeroFlag) {
      goto label_1000_6395_16395;
    }
    State.IncCycles();
    label_1000_637F_1637F:
    // ADD DX,0x4 (1000_637F / 0x1637F)
    DX += 0x4;
    State.IncCycles();
    // CMP DX,word ptr [0x46e7] (1000_6382 / 0x16382)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    State.IncCycles();
    // JNC 0x1000:6394 (1000_6386 / 0x16386)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6394 / 0x16394)
      return NearRet();
    }
    State.IncCycles();
    // INC DI (1000_6388 / 0x16388)
    DI++;
    State.IncCycles();
    // INC SI (1000_6389 / 0x16389)
    SI++;
    State.IncCycles();
    // CMP SI,BP (1000_638A / 0x1638A)
    Alu.Sub16(SI, BP);
    State.IncCycles();
    // JC 0x1000:6375 (1000_638C / 0x1638C)
    if(CarryFlag) {
      goto label_1000_6375_16375;
    }
    State.IncCycles();
    // SUB SI,BP (1000_638E / 0x1638E)
    SI -= BP;
    State.IncCycles();
    // SUB DI,BP (1000_6390 / 0x16390)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    State.IncCycles();
    // JMP 0x1000:6375 (1000_6392 / 0x16392)
    goto label_1000_6375_16375;
    State.IncCycles();
    label_1000_6394_16394:
    // RET  (1000_6394 / 0x16394)
    return NearRet();
    State.IncCycles();
    label_1000_6395_16395:
    // CALL 0x1000:63c7 (1000_6395 / 0x16395)
    NearCall(cs1, 0x6398, not_observed_1000_63C7_0163C7);
    State.IncCycles();
    // JMP 0x1000:637f (1000_6398 / 0x16398)
    goto label_1000_637F_1637F;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_639A_01639A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_639A_1639A:
    // XCHG SI,DX (1000_639A / 0x1639A)
    ushort tmp_1000_639A = SI;
    SI = DX;
    DX = tmp_1000_639A;
    State.IncCycles();
    // XCHG CX,BX (1000_639C / 0x1639C)
    ushort tmp_1000_639C = CX;
    CX = BX;
    BX = tmp_1000_639C;
    State.IncCycles();
    // CALL 0x1000:b58b (1000_639E / 0x1639E)
    NearCall(cs1, 0x63A1, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    label_1000_63A1_163A1:
    // XCHG SI,DX (1000_63A1 / 0x163A1)
    ushort tmp_1000_63A1 = SI;
    SI = DX;
    DX = tmp_1000_63A1;
    State.IncCycles();
    // MOV BX,CX (1000_63A3 / 0x163A3)
    BX = CX;
    State.IncCycles();
    label_1000_63A5_163A5:
    // MOV AX,word ptr ES:[DI] (1000_63A5 / 0x163A5)
    AX = UInt16[ES, DI];
    State.IncCycles();
    // AND AX,0x3030 (1000_63A8 / 0x163A8)
    AX &= 0x3030;
    State.IncCycles();
    // CMP AL,0x10 (1000_63AB / 0x163AB)
    Alu.Sub8(AL, 0x10);
    State.IncCycles();
    // JZ 0x1000:63c2 (1000_63AD / 0x163AD)
    if(ZeroFlag) {
      goto label_1000_63C2_163C2;
    }
    State.IncCycles();
    label_1000_63AF_163AF:
    // SUB DX,0x4 (1000_63AF / 0x163AF)
    DX -= 0x4;
    State.IncCycles();
    // CMP DX,word ptr [0x46e3] (1000_63B2 / 0x163B2)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    State.IncCycles();
    // JC 0x1000:6394 (1000_63B6 / 0x163B6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6394 / 0x16394)
      return NearRet();
    }
    State.IncCycles();
    // DEC DI (1000_63B8 / 0x163B8)
    DI--;
    State.IncCycles();
    // DEC SI (1000_63B9 / 0x163B9)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // JNS 0x1000:63a5 (1000_63BA / 0x163BA)
    if(!SignFlag) {
      goto label_1000_63A5_163A5;
    }
    State.IncCycles();
    // ADD SI,BP (1000_63BC / 0x163BC)
    SI += BP;
    State.IncCycles();
    // ADD DI,BP (1000_63BE / 0x163BE)
    // DI += BP;
    DI = Alu.Add16(DI, BP);
    State.IncCycles();
    // JMP 0x1000:63a5 (1000_63C0 / 0x163C0)
    goto label_1000_63A5_163A5;
    State.IncCycles();
    label_1000_63C2_163C2:
    // CALL 0x1000:63c7 (1000_63C2 / 0x163C2)
    NearCall(cs1, 0x63C5, not_observed_1000_63C7_0163C7);
    State.IncCycles();
    // JMP 0x1000:63af (1000_63C5 / 0x163C5)
    goto label_1000_63AF_163AF;
  }
  
  public virtual Action not_observed_1000_63C7_0163C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_63C7_163C7:
    // PUSH BX (1000_63C7 / 0x163C7)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_63C8 / 0x163C8)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_63C9 / 0x163C9)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_63CA / 0x163CA)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_63CB / 0x163CB)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (1000_63CC / 0x163CC)
    Stack.Push(ES);
    State.IncCycles();
    // CMP AH,0x10 (1000_63CD / 0x163CD)
    Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // MOV AX,0x78 (1000_63D0 / 0x163D0)
    AX = 0x78;
    State.IncCycles();
    // JNZ 0x1000:63d6 (1000_63D3 / 0x163D3)
    if(!ZeroFlag) {
      goto label_1000_63D6_163D6;
    }
    State.IncCycles();
    // INC AX (1000_63D5 / 0x163D5)
    AX++;
    State.IncCycles();
    label_1000_63D6_163D6:
    // ADD BP,DI (1000_63D6 / 0x163D6)
    BP += DI;
    State.IncCycles();
    // AND DI,0x3 (1000_63D8 / 0x163D8)
    DI &= 0x3;
    State.IncCycles();
    // SHR BP,1 (1000_63DB / 0x163DB)
    BP >>= 0x1;
    State.IncCycles();
    // SHR BP,1 (1000_63DD / 0x163DD)
    BP >>= 0x1;
    State.IncCycles();
    // AND BP,0x3 (1000_63DF / 0x163DF)
    BP &= 0x3;
    State.IncCycles();
    // ADD BX,DI (1000_63E2 / 0x163E2)
    BX += DI;
    State.IncCycles();
    // ADD DX,BP (1000_63E4 / 0x163E4)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    State.IncCycles();
    // CALL 0x1000:c343 (1000_63E6 / 0x163E6)
    NearCall(cs1, 0x63E9, spice86_generated_label_call_target_1000_C343_01C343);
    State.IncCycles();
    // POP ES (1000_63E9 / 0x163E9)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_63EA / 0x163EA)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_63EB / 0x163EB)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_63EC / 0x163EC)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_63ED / 0x163ED)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_63EE / 0x163EE)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_63EF / 0x163EF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_63F0_0163F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_63F0_163F0:
    // CMP byte ptr [0x46de],0x0 (1000_63F0 / 0x163F0)
    Alu.Sub8(UInt8[DS, 0x46DE], 0x0);
    State.IncCycles();
    // JZ 0x1000:642d (1000_63F5 / 0x163F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_642D / 0x1642D)
      return NearRet();
    }
    State.IncCycles();
    // MOV ES,word ptr [0xdd00] (1000_63F7 / 0x163F7)
    ES = UInt16[DS, 0xDD00];
    State.IncCycles();
    // MOV DI,0x100 (1000_63FB / 0x163FB)
    DI = 0x100;
    State.IncCycles();
    label_1000_63FE_163FE:
    // MOV AL,byte ptr [DI + 0xa] (1000_63FE / 0x163FE)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    State.IncCycles();
    // TEST AL,0x20 (1000_6401 / 0x16401)
    Alu.And8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:6422 (1000_6403 / 0x16403)
    if(ZeroFlag) {
      goto label_1000_6422_16422;
    }
    State.IncCycles();
    // MOV BL,byte ptr [DI + 0x1b] (1000_6405 / 0x16405)
    BL = UInt8[DS, (ushort)(DI + 0x1B)];
    State.IncCycles();
    // MOV BH,0xfa (1000_6408 / 0x16408)
    BH = 0xFA;
    State.IncCycles();
    // CMP BL,BH (1000_640A / 0x1640A)
    Alu.Sub8(BL, BH);
    State.IncCycles();
    // JNC 0x1000:6422 (1000_640C / 0x1640C)
    if(!CarryFlag) {
      goto label_1000_6422_16422;
    }
    State.IncCycles();
    // MOV SI,word ptr [DI + 0x6] (1000_640E / 0x1640E)
    SI = UInt16[DS, (ushort)(DI + 0x6)];
    State.IncCycles();
    // CALL 0x1000:642e (1000_6411 / 0x16411)
    NearCall(cs1, 0x6414, spice86_generated_label_call_target_1000_642E_01642E);
    State.IncCycles();
    label_1000_6414_16414:
    // SHR DX,1 (1000_6414 / 0x16414)
    DX >>= 0x1;
    State.IncCycles();
    // INC DX (1000_6416 / 0x16416)
    DX++;
    State.IncCycles();
    // ADD BL,DL (1000_6417 / 0x16417)
    BL += DL;
    State.IncCycles();
    // CMP BL,BH (1000_6419 / 0x16419)
    Alu.Sub8(BL, BH);
    State.IncCycles();
    // JC 0x1000:641f (1000_641B / 0x1641B)
    if(CarryFlag) {
      goto label_1000_641F_1641F;
    }
    State.IncCycles();
    // MOV BL,BH (1000_641D / 0x1641D)
    BL = BH;
    State.IncCycles();
    label_1000_641F_1641F:
    // MOV byte ptr [DI + 0x1b],BL (1000_641F / 0x1641F)
    UInt8[DS, (ushort)(DI + 0x1B)] = BL;
    State.IncCycles();
    label_1000_6422_16422:
    // ADD DI,0x1c (1000_6422 / 0x16422)
    DI += 0x1C;
    State.IncCycles();
    // CMP word ptr [DI],-0x1 (1000_6425 / 0x16425)
    Alu.Sub16(UInt16[DS, DI], 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:63fe (1000_6428 / 0x16428)
    if(!ZeroFlag) {
      goto label_1000_63FE_163FE;
    }
    State.IncCycles();
    // JMP 0x1000:65b6 (1000_642A / 0x1642A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_65B6_0165B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_642D_1642D:
    // RET  (1000_642D / 0x1642D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_642E_01642E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_642E_1642E:
    // MOV CX,0x3 (1000_642E / 0x1642E)
    CX = 0x3;
    State.IncCycles();
    // DEC SI (1000_6431 / 0x16431)
    SI--;
    State.IncCycles();
    // XOR DX,DX (1000_6432 / 0x16432)
    DX = 0;
    State.IncCycles();
    label_1000_6434_16434:
    // LODSW ES:SI (1000_6434 / 0x16434)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AX,0x3030 (1000_6436 / 0x16436)
    AX &= 0x3030;
    State.IncCycles();
    // CMP AH,0x10 (1000_6439 / 0x16439)
    Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JNZ 0x1000:643f (1000_643C / 0x1643C)
    if(!ZeroFlag) {
      goto label_1000_643F_1643F;
    }
    State.IncCycles();
    // INC DX (1000_643E / 0x1643E)
    DX++;
    State.IncCycles();
    label_1000_643F_1643F:
    // CMP AL,0x10 (1000_643F / 0x1643F)
    Alu.Sub8(AL, 0x10);
    State.IncCycles();
    // JNZ 0x1000:6444 (1000_6441 / 0x16441)
    if(!ZeroFlag) {
      goto label_1000_6444_16444;
    }
    State.IncCycles();
    // INC DX (1000_6443 / 0x16443)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    label_1000_6444_16444:
    // LOOP 0x1000:6434 (1000_6444 / 0x16444)
    if(--CX != 0) {
      goto label_1000_6434_16434;
    }
    State.IncCycles();
    // RET  (1000_6446 / 0x16446)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6447_016447(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6447_16447:
    // MOV byte ptr [0x4739],0x30 (1000_6447 / 0x16447)
    UInt8[DS, 0x4739] = 0x30;
    State.IncCycles();
    // JMP 0x1000:6458 (1000_644C / 0x1644C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_644E_01644E, 0x16458 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_644E_01644E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_644E_1644E:
    // MOV byte ptr [0x4739],0x20 (1000_644E / 0x1644E)
    UInt8[DS, 0x4739] = 0x20;
    State.IncCycles();
    // XOR CX,CX (1000_6453 / 0x16453)
    CX = 0;
    State.IncCycles();
    // MOV CL,byte ptr [DI + 0xb] (1000_6455 / 0x16455)
    CL = UInt8[DS, (ushort)(DI + 0xB)];
    State.IncCycles();
    label_1000_6458_16458:
    // MOV word ptr CS:[0x64ed],0x646f (1000_6458 / 0x16458)
    UInt16[cs1, 0x64ED] = 0x646F;
    State.IncCycles();
    // MOV DX,word ptr [DI + 0x2] (1000_645F / 0x1645F)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x4] (1000_6462 / 0x16462)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // MOV word ptr [0xd81c],DX (1000_6465 / 0x16465)
    UInt16[DS, 0xD81C] = DX;
    State.IncCycles();
    // MOV word ptr [0xd818],BX (1000_6469 / 0x16469)
    UInt16[DS, 0xD818] = BX;
    State.IncCycles();
    // JMP 0x1000:64b2 (1000_646D / 0x1646D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_64B2_0164B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_646F_01646F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_646F_1646F:
    // ADD BX,word ptr [0xd818] (1000_646F / 0x1646F)
    BX += UInt16[DS, 0xD818];
    State.IncCycles();
    // CMP BX,0x5d (1000_6473 / 0x16473)
    Alu.Sub16(BX, 0x5D);
    State.IncCycles();
    // JG 0x1000:64b1 (1000_6476 / 0x16476)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (1000_64B1 / 0x164B1)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,-0x5d (1000_6478 / 0x16478)
    Alu.Sub16(BX, 0xFFA3);
    State.IncCycles();
    // JL 0x1000:64b1 (1000_647B / 0x1647B)
    if(SignFlag != OverflowFlag) {
      // JL target is RET, inlining.
      State.IncCycles();
      // RET  (1000_64B1 / 0x164B1)
      return NearRet();
    }
    State.IncCycles();
    // PUSH DX (1000_647D / 0x1647D)
    Stack.Push(DX);
    State.IncCycles();
    // MOV DX,word ptr [0xd81c] (1000_647E / 0x1647E)
    DX = UInt16[DS, 0xD81C];
    State.IncCycles();
    // CALL 0x1000:b58b (1000_6482 / 0x16482)
    NearCall(cs1, 0x6485, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    label_1000_6485_16485:
    // POP AX (1000_6485 / 0x16485)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD DI,AX (1000_6486 / 0x16486)
    DI += AX;
    State.IncCycles();
    // ADD DX,AX (1000_6488 / 0x16488)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // JNS 0x1000:6492 (1000_648A / 0x1648A)
    if(!SignFlag) {
      goto label_1000_6492_16492;
    }
    State.IncCycles();
    label_1000_648C_1648C:
    // ADD DI,BP (1000_648C / 0x1648C)
    DI += BP;
    State.IncCycles();
    // ADD DX,BP (1000_648E / 0x1648E)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    State.IncCycles();
    // JS 0x1000:648c (1000_6490 / 0x16490)
    if(SignFlag) {
      goto label_1000_648C_1648C;
    }
    State.IncCycles();
    label_1000_6492_16492:
    // MOV AL,byte ptr ES:[DI] (1000_6492 / 0x16492)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // MOV AH,AL (1000_6495 / 0x16495)
    AH = AL;
    State.IncCycles();
    // AND AH,0x30 (1000_6497 / 0x16497)
    AH &= 0x30;
    State.IncCycles();
    // CMP AH,0x10 (1000_649A / 0x1649A)
    Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JZ 0x1000:64a5 (1000_649D / 0x1649D)
    if(ZeroFlag) {
      goto label_1000_64A5_164A5;
    }
    State.IncCycles();
    // XOR AL,AH (1000_649F / 0x1649F)
    // AL ^= AH;
    AL = Alu.Xor8(AL, AH);
    State.IncCycles();
    // OR AL,byte ptr [0x4739] (1000_64A1 / 0x164A1)
    // AL |= UInt8[DS, 0x4739];
    AL = Alu.Or8(AL, UInt8[DS, 0x4739]);
    State.IncCycles();
    label_1000_64A5_164A5:
    // STOSB ES:DI (1000_64A5 / 0x164A5)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC DX (1000_64A6 / 0x164A6)
    DX++;
    State.IncCycles();
    // CMP DX,BP (1000_64A7 / 0x164A7)
    Alu.Sub16(DX, BP);
    State.IncCycles();
    // JC 0x1000:64af (1000_64A9 / 0x164A9)
    if(CarryFlag) {
      goto label_1000_64AF_164AF;
    }
    State.IncCycles();
    // SUB DX,BP (1000_64AB / 0x164AB)
    DX -= BP;
    State.IncCycles();
    // SUB DI,BP (1000_64AD / 0x164AD)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    State.IncCycles();
    label_1000_64AF_164AF:
    // LOOP 0x1000:6492 (1000_64AF / 0x164AF)
    if(--CX != 0) {
      goto label_1000_6492_16492;
    }
    State.IncCycles();
    label_1000_64B1_164B1:
    // RET  (1000_64B1 / 0x164B1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_64B2_0164B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_64B2_164B2:
    // XOR BX,BX (1000_64B2 / 0x164B2)
    BX = 0;
    State.IncCycles();
    // MOV DX,BX (1000_64B4 / 0x164B4)
    DX = BX;
    State.IncCycles();
    // MOV DI,DX (1000_64B6 / 0x164B6)
    DI = DX;
    State.IncCycles();
    // SUB BX,CX (1000_64B8 / 0x164B8)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    State.IncCycles();
    // MOV SI,CX (1000_64BA / 0x164BA)
    SI = CX;
    State.IncCycles();
    // DEC SI (1000_64BC / 0x164BC)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // MOV AX,CX (1000_64BD / 0x164BD)
    AX = CX;
    State.IncCycles();
    // XOR BP,BP (1000_64BF / 0x164BF)
    BP = 0;
    State.IncCycles();
    // JMP 0x1000:64c6 (1000_64C1 / 0x164C1)
    goto label_1000_64C6_164C6;
    State.IncCycles();
    label_1000_64C3_164C3:
    // INC BP (1000_64C3 / 0x164C3)
    BP++;
    State.IncCycles();
    // INC DX (1000_64C4 / 0x164C4)
    DX++;
    State.IncCycles();
    // DEC DI (1000_64C5 / 0x164C5)
    DI--;
    State.IncCycles();
    label_1000_64C6_164C6:
    // SUB AX,BP (1000_64C6 / 0x164C6)
    // AX -= BP;
    AX = Alu.Sub16(AX, BP);
    State.IncCycles();
    // JNS 0x1000:64c3 (1000_64C8 / 0x164C8)
    if(!SignFlag) {
      goto label_1000_64C3_164C3;
    }
    State.IncCycles();
    // CALL 0x1000:64ef (1000_64CA / 0x164CA)
    NearCall(cs1, 0x64CD, spice86_generated_label_call_target_1000_64EF_0164EF);
    State.IncCycles();
    label_1000_64CD_164CD:
    // INC BX (1000_64CD / 0x164CD)
    BX++;
    State.IncCycles();
    // DEC SI (1000_64CE / 0x164CE)
    SI--;
    State.IncCycles();
    // ADD AX,CX (1000_64CF / 0x164CF)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // JS 0x1000:64d5 (1000_64D1 / 0x164D1)
    if(SignFlag) {
      goto label_1000_64D5_164D5;
    }
    State.IncCycles();
    // LOOP 0x1000:64c3 (1000_64D3 / 0x164D3)
    if(--CX != 0) {
      goto label_1000_64C3_164C3;
    }
    State.IncCycles();
    label_1000_64D5_164D5:
    // INC BP (1000_64D5 / 0x164D5)
    BP++;
    State.IncCycles();
    // DEC CX (1000_64D6 / 0x164D6)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JMP 0x1000:64de (1000_64D7 / 0x164D7)
    goto label_1000_64DE_164DE;
    State.IncCycles();
    label_1000_64D9_164D9:
    // INC DX (1000_64D9 / 0x164D9)
    DX++;
    State.IncCycles();
    // DEC DI (1000_64DA / 0x164DA)
    DI--;
    State.IncCycles();
    // SUB AX,BP (1000_64DB / 0x164DB)
    AX -= BP;
    State.IncCycles();
    // INC BP (1000_64DD / 0x164DD)
    BP = Alu.Inc16(BP);
    State.IncCycles();
    label_1000_64DE_164DE:
    // CALL 0x1000:64ef (1000_64DE / 0x164DE)
    NearCall(cs1, 0x64E1, spice86_generated_label_call_target_1000_64EF_0164EF);
    State.IncCycles();
    label_1000_64E1_164E1:
    // INC BX (1000_64E1 / 0x164E1)
    BX++;
    State.IncCycles();
    // DEC SI (1000_64E2 / 0x164E2)
    SI--;
    State.IncCycles();
    // ADD AX,CX (1000_64E3 / 0x164E3)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // JC 0x1000:64e9 (1000_64E5 / 0x164E5)
    if(CarryFlag) {
      goto label_1000_64E9_164E9;
    }
    State.IncCycles();
    // LOOP 0x1000:64de (1000_64E7 / 0x164E7)
    if(--CX != 0) {
      goto label_1000_64DE_164DE;
    }
    State.IncCycles();
    label_1000_64E9_164E9:
    // DEC CX (1000_64E9 / 0x164E9)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JNS 0x1000:64d9 (1000_64EA / 0x164EA)
    if(!SignFlag) {
      goto label_1000_64D9_164D9;
    }
    State.IncCycles();
    // RET  (1000_64EC / 0x164EC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_64EF_0164EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_64EF_164EF:
    // PUSH AX (1000_64EF / 0x164EF)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_64F0 / 0x164F0)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_64F1 / 0x164F1)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_64F2 / 0x164F2)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_64F3 / 0x164F3)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_64F4 / 0x164F4)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_64F5 / 0x164F5)
    Stack.Push(BP);
    State.IncCycles();
    // MOV CX,DX (1000_64F6 / 0x164F6)
    CX = DX;
    State.IncCycles();
    // SUB CX,DI (1000_64F8 / 0x164F8)
    CX -= DI;
    State.IncCycles();
    // INC CX (1000_64FA / 0x164FA)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // MOV DX,DI (1000_64FB / 0x164FB)
    DX = DI;
    State.IncCycles();
    // PUSH SI (1000_64FD / 0x164FD)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH CX (1000_64FE / 0x164FE)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_64FF / 0x164FF)
    Stack.Push(DX);
    State.IncCycles();
    // CALL word ptr CS:[0x64ed] (1000_6500 / 0x16500)
    // Indirect call to word ptr CS:[0x64ed], generating possible targets from emulator records
    uint targetAddress_1000_6500 = (uint)(UInt16[cs1, 0x64ED]);
    switch(targetAddress_1000_6500) {
      case 0x646F : NearCall(cs1, 0x6505, spice86_generated_label_call_target_1000_646F_01646F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6500));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6505_016505, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6505_016505(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6505_16505:
    // POP DX (1000_6505 / 0x16505)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_6506 / 0x16506)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_6507 / 0x16507)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL word ptr CS:[0x64ed] (1000_6508 / 0x16508)
    // Indirect call to word ptr CS:[0x64ed], generating possible targets from emulator records
    uint targetAddress_1000_6508 = (uint)(UInt16[cs1, 0x64ED]);
    switch(targetAddress_1000_6508) {
      case 0x646F : NearCall(cs1, 0x650D, spice86_generated_label_call_target_1000_646F_01646F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6508));
        break;
    }
    State.IncCycles();
    label_1000_650D_1650D:
    // POP BP (1000_650D / 0x1650D)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_650E / 0x1650E)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_650F / 0x1650F)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_6510 / 0x16510)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_6511 / 0x16511)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_6512 / 0x16512)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_6513 / 0x16513)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6514 / 0x16514)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_65B6_0165B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_65B6_165B6:
    // MOV ES,word ptr [0xdd00] (1000_65B6 / 0x165B6)
    ES = UInt16[DS, 0xDD00];
    State.IncCycles();
    // MOV SI,word ptr CS:[0x65b4] (1000_65BA / 0x165BA)
    SI = UInt16[cs1, 0x65B4];
    State.IncCycles();
    // XOR BP,BP (1000_65BF / 0x165BF)
    BP = 0;
    State.IncCycles();
    // MOV CX,0x46 (1000_65C1 / 0x165C1)
    CX = 0x46;
    State.IncCycles();
    label_1000_65C4_165C4:
    // SHR SI,1 (1000_65C4 / 0x165C4)
    // SI >>= 0x1;
    SI = Alu.Shr16(SI, 0x1);
    State.IncCycles();
    // JNC 0x1000:65cc (1000_65C6 / 0x165C6)
    if(!CarryFlag) {
      goto label_1000_65CC_165CC;
    }
    State.IncCycles();
    // XOR SI,0x402 (1000_65C8 / 0x165C8)
    // SI ^= 0x402;
    SI = Alu.Xor16(SI, 0x402);
    State.IncCycles();
    label_1000_65CC_165CC:
    // MOV DI,SI (1000_65CC / 0x165CC)
    DI = SI;
    State.IncCycles();
    label_1000_65CE_165CE:
    // MOV AL,byte ptr ES:[DI] (1000_65CE / 0x165CE)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // MOV AH,AL (1000_65D1 / 0x165D1)
    AH = AL;
    State.IncCycles();
    // AND AH,0x30 (1000_65D3 / 0x165D3)
    AH &= 0x30;
    State.IncCycles();
    // CMP AH,0x10 (1000_65D6 / 0x165D6)
    Alu.Sub8(AH, 0x10);
    State.IncCycles();
    // JNZ 0x1000:65e2 (1000_65D9 / 0x165D9)
    if(!ZeroFlag) {
      goto label_1000_65E2_165E2;
    }
    State.IncCycles();
    // AND AL,0xcf (1000_65DB / 0x165DB)
    // AL &= 0xCF;
    AL = Alu.And8(AL, 0xCF);
    State.IncCycles();
    // OR AL,0x20 (1000_65DD / 0x165DD)
    // AL |= 0x20;
    AL = Alu.Or8(AL, 0x20);
    State.IncCycles();
    // STOSB ES:DI (1000_65DF / 0x165DF)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // DEC DI (1000_65E0 / 0x165E0)
    DI--;
    State.IncCycles();
    // INC BP (1000_65E1 / 0x165E1)
    BP++;
    State.IncCycles();
    label_1000_65E2_165E2:
    // ADD DI,0x7ff (1000_65E2 / 0x165E2)
    DI += 0x7FF;
    State.IncCycles();
    // CMP DI,0xc5f9 (1000_65E6 / 0x165E6)
    Alu.Sub16(DI, 0xC5F9);
    State.IncCycles();
    // JC 0x1000:65ce (1000_65EA / 0x165EA)
    if(CarryFlag) {
      goto label_1000_65CE_165CE;
    }
    State.IncCycles();
    // LOOP 0x1000:65c4 (1000_65EC / 0x165EC)
    if(--CX != 0) {
      goto label_1000_65C4_165C4;
    }
    State.IncCycles();
    // MOV word ptr CS:[0x65b4],SI (1000_65EE / 0x165EE)
    UInt16[cs1, 0x65B4] = SI;
    State.IncCycles();
    // OR BP,BP (1000_65F3 / 0x165F3)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JZ 0x1000:6602 (1000_65F5 / 0x165F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6602 / 0x16602)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_65F7 / 0x165F7)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNS 0x1000:6602 (1000_65FC / 0x165FC)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6602 / 0x16602)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0x46ec] (1000_65FE / 0x165FE)
    UInt8[DS, 0x46EC] = Alu.Inc8(UInt8[DS, 0x46EC]);
    State.IncCycles();
    label_1000_6602_16602:
    // RET  (1000_6602 / 0x16602)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6603_016603(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6603_16603:
    // PUSH SI (1000_6603 / 0x16603)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_6604 / 0x16604)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6607_016607, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6607_016607(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6607_16607:
    // OR AL,AL (1000_6607 / 0x16607)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:661b (1000_6609 / 0x16609)
    if(ZeroFlag) {
      goto label_1000_661B_1661B;
    }
    State.IncCycles();
    // CALL 0x1000:6906 (1000_660B / 0x1660B)
    NearCall(cs1, 0x660E, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    label_1000_660E_1660E:
    // PUSH SI (1000_660E / 0x1660E)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_660F / 0x1660F)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_6610 / 0x16610)
    Stack.Push(BP);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_6613_16613:
    // POP BP (1000_6613 / 0x16613)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_6614 / 0x16614)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_6615 / 0x16615)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1] (1000_6616 / 0x16616)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // JMP 0x1000:6607 (1000_6619 / 0x16619)
    goto label_1000_6607_16607;
    State.IncCycles();
    label_1000_661B_1661B:
    // POP SI (1000_661B / 0x1661B)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_661C / 0x1661C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_661D_01661D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_661D_1661D:
    // PUSH SI (1000_661D / 0x1661D)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_661E / 0x1661E)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6621_016621, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6621_016621(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6621_16621:
    // OR AL,AL (1000_6621 / 0x16621)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:6637 (1000_6623 / 0x16623)
    if(ZeroFlag) {
      goto label_1000_6637_16637;
    }
    State.IncCycles();
    // CALL 0x1000:6906 (1000_6625 / 0x16625)
    NearCall(cs1, 0x6628, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    label_1000_6628_16628:
    // JNC 0x1000:6632 (1000_6628 / 0x16628)
    if(!CarryFlag) {
      goto label_1000_6632_16632;
    }
    State.IncCycles();
    // PUSH SI (1000_662A / 0x1662A)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_662B / 0x1662B)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_662C / 0x1662C)
    Stack.Push(BP);
    State.IncCycles();
    // CALL BP (1000_662D / 0x1662D)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_662D = (uint)(BP);
    switch(targetAddress_1000_662D) {
      case 0x4E04 : NearCall(cs1, 0x662F, spice86_generated_label_call_target_1000_4E04_014E04); break;
      case 0x6E82 : NearCall(cs1, 0x662F, spice86_generated_label_call_target_1000_6E82_016E82); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_662D));
        break;
    }
    State.IncCycles();
    label_1000_662F_1662F:
    // POP BP (1000_662F / 0x1662F)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_6630 / 0x16630)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_6631 / 0x16631)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_6632_16632:
    // MOV AL,byte ptr [SI + 0x1] (1000_6632 / 0x16632)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // JMP 0x1000:6621 (1000_6635 / 0x16635)
    goto label_1000_6621_16621;
    State.IncCycles();
    label_1000_6637_16637:
    // POP SI (1000_6637 / 0x16637)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6638 / 0x16638)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6639_016639(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6639_16639:
    // CALL 0x1000:6603 (1000_6639 / 0x16639)
    NearCall(cs1, 0x663C, spice86_generated_label_call_target_1000_6603_016603);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_663C_01663C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_663C_01663C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_663C_1663C:
    // PUSH SI (1000_663C / 0x1663C)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x8aa (1000_663D / 0x1663D)
    SI = 0x8AA;
    State.IncCycles();
    label_1000_6640_16640:
    // MOV AL,byte ptr [SI + 0x3] (1000_6640 / 0x16640)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // TEST AL,0x40 (1000_6643 / 0x16643)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:6665 (1000_6645 / 0x16645)
    if(ZeroFlag) {
      goto label_1000_6665_16665;
    }
    State.IncCycles();
    // PUSH BX (1000_6647 / 0x16647)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x4] (1000_6648 / 0x16648)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // AND AL,0x3 (1000_664B / 0x1664B)
    AL &= 0x3;
    State.IncCycles();
    // CMP AL,0x3 (1000_664D / 0x1664D)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:6654 (1000_664F / 0x1664F)
    if(!ZeroFlag) {
      goto label_1000_6654_16654;
    }
    State.IncCycles();
    // MOV BX,word ptr [SI + 0xc] (1000_6651 / 0x16651)
    BX = UInt16[DS, (ushort)(SI + 0xC)];
    State.IncCycles();
    label_1000_6654_16654:
    // CMP BX,DI (1000_6654 / 0x16654)
    Alu.Sub16(BX, DI);
    State.IncCycles();
    // POP BX (1000_6656 / 0x16656)
    BX = Stack.Pop();
    State.IncCycles();
    // JNZ 0x1000:6665 (1000_6657 / 0x16657)
    if(!ZeroFlag) {
      goto label_1000_6665_16665;
    }
    State.IncCycles();
    // PUSH SI (1000_6659 / 0x16659)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_665A / 0x1665A)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_665B / 0x1665B)
    Stack.Push(BP);
    State.IncCycles();
    // CMP byte ptr [SI + 0x3],0x80 (1000_665C / 0x1665C)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    State.IncCycles();
    // CALL BP (1000_6660 / 0x16660)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_6660 = (uint)(BP);
    switch(targetAddress_1000_6660) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6660));
        break;
    }
    State.IncCycles();
    // POP BP (1000_6662 / 0x16662)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_6663 / 0x16663)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_6664 / 0x16664)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_6665_16665:
    // ADD SI,0x1b (1000_6665 / 0x16665)
    SI += 0x1B;
    State.IncCycles();
    // CMP SI,0xfbb (1000_6668 / 0x16668)
    Alu.Sub16(SI, 0xFBB);
    State.IncCycles();
    // JC 0x1000:6640 (1000_666C / 0x1666C)
    if(CarryFlag) {
      goto label_1000_6640_16640;
    }
    State.IncCycles();
    // POP SI (1000_666E / 0x1666E)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_666F / 0x1666F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_668F_01668F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_668F_1668F:
    // TEST byte ptr [SI + 0x3],0x20 (1000_668F / 0x1668F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // JNZ 0x1000:66b0 (1000_6693 / 0x16693)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_66B0 / 0x166B0)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_6695 / 0x16695)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:66b0 (1000_6699 / 0x16699)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_66B0 / 0x166B0)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [SI + 0x3],0x20 (1000_669B / 0x1669B)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x20;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // MOV byte ptr [SI + 0x19],0x0 (1000_669F / 0x1669F)
    UInt8[DS, (ushort)(SI + 0x19)] = 0x0;
    State.IncCycles();
    // MOV AX,[0x2] (1000_66A3 / 0x166A3)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV word ptr [SI + 0xa],AX (1000_66A6 / 0x166A6)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    State.IncCycles();
    // PUSH DI (1000_66A9 / 0x166A9)
    Stack.Push(DI);
    State.IncCycles();
    // MOV AL,0x4 (1000_66AA / 0x166AA)
    AL = 0x4;
    State.IncCycles();
    // CALL 0x1000:6fb0 (1000_66AC / 0x166AC)
    NearCall(cs1, 0x66AF, not_observed_1000_6FB0_016FB0);
    State.IncCycles();
    // POP DI (1000_66AF / 0x166AF)
    DI = Stack.Pop();
    State.IncCycles();
    label_1000_66B0_166B0:
    // RET  (1000_66B0 / 0x166B0)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_66B1_0166B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_66B1_166B1:
    // CALL 0x1000:858c (1000_66B1 / 0x166B1)
    NearCall(cs1, 0x66B4, not_observed_1000_858C_01858C);
    State.IncCycles();
    // PUSH SI (1000_66B4 / 0x166B4)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_66B5 / 0x166B5)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:6917 (1000_66B6 / 0x166B6)
    NearCall(cs1, 0x66B9, spice86_generated_label_call_target_1000_6917_016917);
    State.IncCycles();
    // JNZ 0x1000:66be (1000_66B9 / 0x166B9)
    if(!ZeroFlag) {
      goto label_1000_66BE_166BE;
    }
    State.IncCycles();
    // CALL 0x1000:c58a (1000_66BB / 0x166BB)
    NearCall(cs1, 0x66BE, spice86_generated_label_call_target_1000_C58A_01C58A);
    State.IncCycles();
    label_1000_66BE_166BE:
    // POP DI (1000_66BE / 0x166BE)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_66BF / 0x166BF)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [SI + 0x4],0xfbc (1000_66C0 / 0x166C0)
    UInt16[DS, (ushort)(SI + 0x4)] = 0xFBC;
    State.IncCycles();
    // MOV byte ptr [SI + 0x3],0xa0 (1000_66C5 / 0x166C5)
    UInt8[DS, (ushort)(SI + 0x3)] = 0xA0;
    State.IncCycles();
    // MOV byte ptr [SI + 0x1a],0x0 (1000_66C9 / 0x166C9)
    UInt8[DS, (ushort)(SI + 0x1A)] = 0x0;
    State.IncCycles();
    // RET  (1000_66CD / 0x166CD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_66CE_0166CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_66CE_166CE:
    // TEST byte ptr [SI + 0x3],0x80 (1000_66CE / 0x166CE)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    State.IncCycles();
    // JZ 0x1000:6714 (1000_66D2 / 0x166D2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6714 / 0x16714)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_66D4 / 0x166D4)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:6714 (1000_66D8 / 0x166D8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6714 / 0x16714)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0x28] (1000_66DA / 0x166DA)
    UInt8[DS, 0x28] = Alu.Inc8(UInt8[DS, 0x28]);
    State.IncCycles();
    // MOV AL,[0x28] (1000_66DE / 0x166DE)
    AL = UInt8[DS, 0x28];
    State.IncCycles();
    // CMP AL,byte ptr [0x1178] (1000_66E1 / 0x166E1)
    Alu.Sub8(AL, UInt8[DS, 0x1178]);
    State.IncCycles();
    // JC 0x1000:66ee (1000_66E5 / 0x166E5)
    if(CarryFlag) {
      goto label_1000_66EE_166EE;
    }
    State.IncCycles();
    // PUSH SI (1000_66E7 / 0x166E7)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AL,0x4c (1000_66E8 / 0x166E8)
    AL = 0x4C;
    State.IncCycles();
    // CALL 0x1000:121f (1000_66EA / 0x166EA)
    NearCall(cs1, 0x66ED, spice86_generated_label_jump_target_1000_121F_01121F);
    State.IncCycles();
    // POP SI (1000_66ED / 0x166ED)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_66EE_166EE:
    // MOV AL,0x1 (1000_66EE / 0x166EE)
    AL = 0x1;
    State.IncCycles();
    // CALL 0x1000:6f78 (1000_66F0 / 0x166F0)
    NearCall(cs1, 0x66F3, spice86_generated_label_call_target_1000_6F78_016F78);
    State.IncCycles();
    label_1000_66F3_166F3:
    // AND byte ptr [SI + 0x3],0x20 (1000_66F3 / 0x166F3)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0x20;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // OR byte ptr [SI + 0x3],0x2 (1000_66F7 / 0x166F7)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x2;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x2);
    State.IncCycles();
    // CALL 0x1000:6b25 (1000_66FB / 0x166FB)
    NearCall(cs1, 0x66FE, spice86_generated_label_call_target_1000_6B25_016B25);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_66FE_0166FE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_66FE_0166FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_66FE_166FE:
    // CALL 0x1000:1ac5 (1000_66FE / 0x166FE)
    NearCall(cs1, 0x6701, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6701_016701, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6701_016701(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6701_16701:
    // MOV byte ptr [SI + 0x14],AL (1000_6701 / 0x16701)
    UInt8[DS, (ushort)(SI + 0x14)] = AL;
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6704 / 0x16704)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP byte ptr [DI + 0xb],0x0 (1000_6707 / 0x16707)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0xB)], 0x0);
    State.IncCycles();
    // JNZ 0x1000:6714 (1000_670B / 0x1670B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6714 / 0x16714)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [DI + 0xb],0x2 (1000_670D / 0x1670D)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x2;
    State.IncCycles();
    // CALL 0x1000:644e (1000_6711 / 0x16711)
    NearCall(cs1, 0x6714, spice86_generated_label_call_target_1000_644E_01644E);
    State.IncCycles();
    label_1000_6714_16714:
    // RET  (1000_6714 / 0x16714)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6715_016715(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6715_16715:
    // MOV BP,0xa5c0 (1000_6715 / 0x16715)
    BP = 0xA5C0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6718_016718, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6718_016718(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6718_16718:
    // MOV DI,word ptr [BP + 0x0] (1000_6718 / 0x16718)
    DI = UInt16[SS, BP];
    State.IncCycles();
    // OR DI,DI (1000_671B / 0x1671B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:6737 (1000_671D / 0x1671D)
    if(ZeroFlag) {
      goto label_1000_6737_16737;
    }
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_671F / 0x1671F)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    // OR AL,AL (1000_6722 / 0x16722)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:6732 (1000_6724 / 0x16724)
    if(ZeroFlag) {
      goto label_1000_6732_16732;
    }
    State.IncCycles();
    label_1000_6726_16726:
    // PUSH BP (1000_6726 / 0x16726)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:6757 (1000_6727 / 0x16727)
    NearCall(cs1, 0x672A, spice86_generated_label_call_target_1000_6757_016757);
    State.IncCycles();
    label_1000_672A_1672A:
    // POP BP (1000_672A / 0x1672A)
    BP = Stack.Pop();
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1] (1000_672B / 0x1672B)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // OR AL,AL (1000_672E / 0x1672E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:6726 (1000_6730 / 0x16730)
    if(!ZeroFlag) {
      goto label_1000_6726_16726;
    }
    State.IncCycles();
    label_1000_6732_16732:
    // ADD BP,0x6 (1000_6732 / 0x16732)
    // BP += 0x6;
    BP = Alu.Add16(BP, 0x6);
    State.IncCycles();
    // JMP 0x1000:6718 (1000_6735 / 0x16735)
    goto label_1000_6718_16718;
    State.IncCycles();
    label_1000_6737_16737:
    // MOV SI,0x88f (1000_6737 / 0x16737)
    SI = 0x88F;
    State.IncCycles();
    label_1000_673A_1673A:
    // ADD SI,0x1b (1000_673A / 0x1673A)
    SI += 0x1B;
    State.IncCycles();
    // CMP SI,0xfbb (1000_673D / 0x1673D)
    Alu.Sub16(SI, 0xFBB);
    State.IncCycles();
    // JNC 0x1000:6756 (1000_6741 / 0x16741)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6756 / 0x16756)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x10 (1000_6743 / 0x16743)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    State.IncCycles();
    // JNZ 0x1000:673a (1000_6747 / 0x16747)
    if(!ZeroFlag) {
      goto label_1000_673A_1673A;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_6749 / 0x16749)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JZ 0x1000:673a (1000_674D / 0x1674D)
    if(ZeroFlag) {
      goto label_1000_673A_1673A;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_674F / 0x1674F)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CALL 0x1000:6757 (1000_6751 / 0x16751)
    NearCall(cs1, 0x6754, spice86_generated_label_call_target_1000_6757_016757);
    State.IncCycles();
    // JMP 0x1000:673a (1000_6754 / 0x16754)
    goto label_1000_673A_1673A;
    State.IncCycles();
    label_1000_6756_16756:
    // RET  (1000_6756 / 0x16756)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6757_016757(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6757_16757:
    // CALL 0x1000:6906 (1000_6757 / 0x16757)
    NearCall(cs1, 0x675A, spice86_generated_label_call_target_1000_6906_016906);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_675A_01675A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_675A_01675A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_675A_1675A:
    // CALL 0x1000:686e (1000_675A / 0x1675A)
    NearCall(cs1, 0x675D, spice86_generated_label_call_target_1000_686E_01686E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_675D_01675D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_675D_01675D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_675D_1675D:
    // JC 0x1000:676d (1000_675D / 0x1675D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_676D / 0x1676D)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:6770 (1000_675F / 0x1675F)
    NearCall(cs1, 0x6762, spice86_generated_label_call_target_1000_6770_016770);
    State.IncCycles();
    label_1000_6762_16762:
    // CMP BP,0x1 (1000_6762 / 0x16762)
    Alu.Sub16(BP, 0x1);
    State.IncCycles();
    // JC 0x1000:676d (1000_6765 / 0x16765)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_676D / 0x1676D)
      return NearRet();
    }
    State.IncCycles();
    // PUSH SI (1000_6767 / 0x16767)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:c5cf (1000_6768 / 0x16768)
    NearCall(cs1, 0x676B, spice86_generated_label_call_target_1000_C5CF_01C5CF);
    State.IncCycles();
    label_1000_676B_1676B:
    // POP SI (1000_676B / 0x1676B)
    SI = Stack.Pop();
    State.IncCycles();
    // CLC  (1000_676C / 0x1676C)
    CarryFlag = false;
    State.IncCycles();
    label_1000_676D_1676D:
    // RET  (1000_676D / 0x1676D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6770_016770(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6770_16770:
    // TEST byte ptr [SI + 0x10],0x10 (1000_6770 / 0x16770)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    State.IncCycles();
    // JNZ 0x1000:678f (1000_6774 / 0x16774)
    if(!ZeroFlag) {
      goto label_1000_678F_1678F;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_6776 / 0x16776)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_6779 / 0x16779)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:6792 (1000_677D / 0x1677D)
    if(!ZeroFlag) {
      goto label_1000_6792_16792;
    }
    State.IncCycles();
    // OR AL,AL (1000_677F / 0x1677F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:6792 (1000_6781 / 0x16781)
    if(!SignFlag) {
      goto label_1000_6792_16792;
    }
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x4] (1000_6783 / 0x16783)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // TEST byte ptr [BP + 0xa],0x10 (1000_6786 / 0x16786)
    Alu.And8(UInt8[SS, (ushort)(BP + 0xA)], 0x10);
    State.IncCycles();
    // MOV BP,0x181f (1000_678A / 0x1678A)
    BP = 0x181F;
    State.IncCycles();
    // JNZ 0x1000:6791 (1000_678D / 0x1678D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    State.IncCycles();
    label_1000_678F_1678F:
    // XOR BP,BP (1000_678F / 0x1678F)
    BP = 0;
    State.IncCycles();
    label_1000_6791_16791:
    // RET  (1000_6791 / 0x16791)
    return NearRet();
    State.IncCycles();
    label_1000_6792_16792:
    // TEST AL,0x40 (1000_6792 / 0x16792)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:6799 (1000_6794 / 0x16794)
    if(ZeroFlag) {
      goto label_1000_6799_16799;
    }
    State.IncCycles();
    // JMP 0x1000:6827 (1000_6796 / 0x16796)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_6827_016827, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_6799_16799:
    // TEST AL,0x30 (1000_6799 / 0x16799)
    Alu.And8(AL, 0x30);
    State.IncCycles();
    // JZ 0x1000:67c5 (1000_679B / 0x1679B)
    if(ZeroFlag) {
      goto label_1000_67C5_167C5;
    }
    State.IncCycles();
    // AND AX,0xf (1000_679D / 0x1679D)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // MOV BP,AX (1000_67A0 / 0x167A0)
    BP = AX;
    State.IncCycles();
    // SHL BP,1 (1000_67A2 / 0x167A2)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // MOV BP,word ptr [BP + 0x16b6] (1000_67A4 / 0x167A4)
    BP = UInt16[SS, (ushort)(BP + 0x16B6)];
    State.IncCycles();
    // OR AX,AX (1000_67A8 / 0x167A8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNZ 0x1000:67c4 (1000_67AA / 0x167AA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x19] (1000_67AC / 0x167AC)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // AND AL,0xc0 (1000_67AF / 0x167AF)
    // AL &= 0xC0;
    AL = Alu.And8(AL, 0xC0);
    State.IncCycles();
    // JZ 0x1000:67c4 (1000_67B1 / 0x167B1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x1813 (1000_67B3 / 0x167B3)
    BP = 0x1813;
    State.IncCycles();
    // CMP AL,0x80 (1000_67B6 / 0x167B6)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JZ 0x1000:67c4 (1000_67B8 / 0x167B8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x1817 (1000_67BA / 0x167BA)
    BP = 0x1817;
    State.IncCycles();
    // CMP AL,0x40 (1000_67BD / 0x167BD)
    Alu.Sub8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:67c4 (1000_67BF / 0x167BF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_67C4 / 0x167C4)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x181b (1000_67C1 / 0x167C1)
    BP = 0x181B;
    State.IncCycles();
    label_1000_67C4_167C4:
    // RET  (1000_67C4 / 0x167C4)
    return NearRet();
    State.IncCycles();
    label_1000_67C5_167C5:
    // AND AX,0xf (1000_67C5 / 0x167C5)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // JZ 0x1000:680a (1000_67C8 / 0x167C8)
    if(ZeroFlag) {
      goto label_1000_680A_1680A;
    }
    State.IncCycles();
    label_1000_67CA_167CA:
    // MOV BP,AX (1000_67CA / 0x167CA)
    BP = AX;
    State.IncCycles();
    // SHL BP,1 (1000_67CC / 0x167CC)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // MOV BP,word ptr [BP + 0x179c] (1000_67CE / 0x167CE)
    BP = UInt16[SS, (ushort)(BP + 0x179C)];
    State.IncCycles();
    // CMP BP,0x1774 (1000_67D2 / 0x167D2)
    Alu.Sub16(BP, 0x1774);
    State.IncCycles();
    // JZ 0x1000:67ed (1000_67D6 / 0x167D6)
    if(ZeroFlag) {
      goto label_1000_67ED_167ED;
    }
    State.IncCycles();
    // CMP BP,0x1732 (1000_67D8 / 0x167D8)
    Alu.Sub16(BP, 0x1732);
    State.IncCycles();
    // JNZ 0x1000:6791 (1000_67DC / 0x167DC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x4] (1000_67DE / 0x167DE)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // TEST byte ptr [BP + 0xa],0x2 (1000_67E1 / 0x167E1)
    Alu.And8(UInt8[SS, (ushort)(BP + 0xA)], 0x2);
    State.IncCycles();
    // MOV BP,0x16aa (1000_67E5 / 0x167E5)
    BP = 0x16AA;
    State.IncCycles();
    // JNZ 0x1000:6791 (1000_67E8 / 0x167E8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6791 / 0x16791)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x1732 (1000_67EA / 0x167EA)
    BP = 0x1732;
    State.IncCycles();
    label_1000_67ED_167ED:
    // MOV AL,byte ptr [SI + 0x2] (1000_67ED / 0x167ED)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // DEC AL (1000_67F0 / 0x167F0)
    AL--;
    State.IncCycles();
    // AND AL,0x7 (1000_67F2 / 0x167F2)
    AL &= 0x7;
    State.IncCycles();
    // CMP AL,0x3 (1000_67F4 / 0x167F4)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JC 0x1000:6809 (1000_67F6 / 0x167F6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    State.IncCycles();
    // ADD BP,0xa (1000_67F8 / 0x167F8)
    BP += 0xA;
    State.IncCycles();
    // CMP AL,0x3 (1000_67FB / 0x167FB)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JZ 0x1000:6809 (1000_67FD / 0x167FD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    State.IncCycles();
    // ADD BP,0xa (1000_67FF / 0x167FF)
    BP += 0xA;
    State.IncCycles();
    // CMP AL,0x4 (1000_6802 / 0x16802)
    Alu.Sub8(AL, 0x4);
    State.IncCycles();
    // JZ 0x1000:6809 (1000_6804 / 0x16804)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6809 / 0x16809)
      return NearRet();
    }
    State.IncCycles();
    // ADD BP,0xa (1000_6806 / 0x16806)
    // BP += 0xA;
    BP = Alu.Add16(BP, 0xA);
    State.IncCycles();
    label_1000_6809_16809:
    // RET  (1000_6809 / 0x16809)
    return NearRet();
    State.IncCycles();
    label_1000_680A_1680A:
    // TEST byte ptr [SI + 0x19],0xc0 (1000_680A / 0x1680A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0xC0);
    State.IncCycles();
    // JZ 0x1000:67ca (1000_680E / 0x1680E)
    if(ZeroFlag) {
      goto label_1000_67CA_167CA;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x19] (1000_6810 / 0x16810)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // AND AL,0xc0 (1000_6813 / 0x16813)
    // AL &= 0xC0;
    AL = Alu.And8(AL, 0xC0);
    State.IncCycles();
    // MOV BP,0x17bc (1000_6815 / 0x16815)
    BP = 0x17BC;
    State.IncCycles();
    // CMP AL,0x80 (1000_6818 / 0x16818)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JZ 0x1000:6826 (1000_681A / 0x1681A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6826 / 0x16826)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x17c9 (1000_681C / 0x1681C)
    BP = 0x17C9;
    State.IncCycles();
    // CMP AL,0x40 (1000_681F / 0x1681F)
    Alu.Sub8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:6826 (1000_6821 / 0x16821)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6826 / 0x16826)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x1806 (1000_6823 / 0x16823)
    BP = 0x1806;
    State.IncCycles();
    label_1000_6826_16826:
    // RET  (1000_6826 / 0x16826)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6827_016827(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6827_16827:
    // PUSH BX (1000_6827 / 0x16827)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_6828 / 0x16828)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_6829 / 0x16829)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_682A / 0x1682A)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x2] (1000_682D / 0x1682D)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x4] (1000_6830 / 0x16830)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // SUB AX,word ptr [SI + 0x6] (1000_6833 / 0x16833)
    // AX -= UInt16[DS, (ushort)(SI + 0x6)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // MOV AL,AH (1000_6836 / 0x16836)
    AL = AH;
    State.IncCycles();
    // CBW  (1000_6838 / 0x16838)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV DX,AX (1000_6839 / 0x16839)
    DX = AX;
    State.IncCycles();
    // MOV DI,DX (1000_683B / 0x1683B)
    DI = DX;
    State.IncCycles();
    // JNS 0x1000:6841 (1000_683D / 0x1683D)
    if(!SignFlag) {
      goto label_1000_6841_16841;
    }
    State.IncCycles();
    // NEG DI (1000_683F / 0x1683F)
    DI = Alu.Sub16(0, DI);
    State.IncCycles();
    label_1000_6841_16841:
    // SUB BX,word ptr [SI + 0x8] (1000_6841 / 0x16841)
    // BX -= UInt16[DS, (ushort)(SI + 0x8)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x8)]);
    State.IncCycles();
    // MOV CX,BX (1000_6844 / 0x16844)
    CX = BX;
    State.IncCycles();
    // JNS 0x1000:684a (1000_6846 / 0x16846)
    if(!SignFlag) {
      goto label_1000_684A_1684A;
    }
    State.IncCycles();
    // NEG CX (1000_6848 / 0x16848)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_1000_684A_1684A:
    // MOV BP,0x2 (1000_684A / 0x1684A)
    BP = 0x2;
    State.IncCycles();
    // CMP DI,CX (1000_684D / 0x1684D)
    Alu.Sub16(DI, CX);
    State.IncCycles();
    // JC 0x1000:6854 (1000_684F / 0x1684F)
    if(CarryFlag) {
      goto label_1000_6854_16854;
    }
    State.IncCycles();
    // DEC BP (1000_6851 / 0x16851)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // XCHG BX,DX (1000_6852 / 0x16852)
    ushort tmp_1000_6852 = BX;
    BX = DX;
    DX = tmp_1000_6852;
    State.IncCycles();
    label_1000_6854_16854:
    // OR BX,BX (1000_6854 / 0x16854)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNS 0x1000:685b (1000_6856 / 0x16856)
    if(!SignFlag) {
      goto label_1000_685B_1685B;
    }
    State.IncCycles();
    // XOR BP,0x2 (1000_6858 / 0x16858)
    // BP ^= 0x2;
    BP = Alu.Xor16(BP, 0x2);
    State.IncCycles();
    label_1000_685B_1685B:
    // CALL 0x1000:693b (1000_685B / 0x1685B)
    NearCall(cs1, 0x685E, spice86_generated_label_call_target_1000_693B_01693B);
    State.IncCycles();
    // SHL AX,1 (1000_685E / 0x1685E)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_6860 / 0x16860)
    AX <<= 0x1;
    State.IncCycles();
    // ADD BP,AX (1000_6862 / 0x16862)
    BP += AX;
    State.IncCycles();
    // SHL BP,1 (1000_6864 / 0x16864)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // MOV BP,word ptr [BP + 0x18bf] (1000_6866 / 0x16866)
    BP = UInt16[SS, (ushort)(BP + 0x18BF)];
    State.IncCycles();
    // POP DI (1000_686A / 0x1686A)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_686B / 0x1686B)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_686C / 0x1686C)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_686D / 0x1686D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_686E_01686E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_686E_1686E:
    // CMP byte ptr [0x46eb],0x80 (1000_686E / 0x1686E)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x80);
    State.IncCycles();
    // JC 0x1000:68ae (1000_6873 / 0x16873)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_68AE / 0x168AE)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_6875 / 0x16875)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:68af (1000_6879 / 0x16879)
    if(!ZeroFlag) {
      goto label_1000_68AF_168AF;
    }
    State.IncCycles();
    // MOV BL,byte ptr [SI + 0x2] (1000_687B / 0x1687B)
    BL = UInt8[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // DEC BX (1000_687E / 0x1687E)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // PUSH DI (1000_687F / 0x1687F)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6880 / 0x16880)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x2 (1000_6883 / 0x16883)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JZ 0x1000:688c (1000_6887 / 0x16887)
    if(ZeroFlag) {
      goto label_1000_688C_1688C;
    }
    State.IncCycles();
    // XOR BL,0x8 (1000_6889 / 0x16889)
    // BL ^= 0x8;
    BL = Alu.Xor8(BL, 0x8);
    State.IncCycles();
    label_1000_688C_1688C:
    // POP DI (1000_688C / 0x1688C)
    DI = Stack.Pop();
    State.IncCycles();
    // AND BX,0xf (1000_688D / 0x1688D)
    BX &= 0xF;
    State.IncCycles();
    // ADD BX,BX (1000_6890 / 0x16890)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    State.IncCycles();
    // MOV AL,byte ptr [BX + 0x1672] (1000_6892 / 0x16892)
    AL = UInt8[DS, (ushort)(BX + 0x1672)];
    State.IncCycles();
    // CBW  (1000_6896 / 0x16896)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV DX,AX (1000_6897 / 0x16897)
    DX = AX;
    State.IncCycles();
    // MOV AL,byte ptr [BX + 0x1673] (1000_6899 / 0x16899)
    AL = UInt8[DS, (ushort)(BX + 0x1673)];
    State.IncCycles();
    // CBW  (1000_689D / 0x1689D)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD DX,word ptr [BP + 0x2] (1000_689E / 0x1689E)
    // DX += UInt16[SS, (ushort)(BP + 0x2)];
    DX = Alu.Add16(DX, UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x4] (1000_68A1 / 0x168A1)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // CMP BH,0x80 (1000_68A4 / 0x168A4)
    Alu.Sub8(BH, 0x80);
    State.IncCycles();
    // JC 0x1000:68ae (1000_68A7 / 0x168A7)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_68AE / 0x168AE)
      return NearRet();
    }
    State.IncCycles();
    // XOR BH,BH (1000_68A9 / 0x168A9)
    BH = 0;
    State.IncCycles();
    // ADD BX,AX (1000_68AB / 0x168AB)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // CLC  (1000_68AD / 0x168AD)
    CarryFlag = false;
    State.IncCycles();
    label_1000_68AE_168AE:
    // RET  (1000_68AE / 0x168AE)
    return NearRet();
    State.IncCycles();
    label_1000_68AF_168AF:
    // MOV DX,word ptr [SI + 0x6] (1000_68AF / 0x168AF)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x8] (1000_68B2 / 0x168B2)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // CALL 0x1000:b647 (1000_68B5 / 0x168B5)
    NearCall(cs1, 0x68B8, spice86_generated_label_call_target_1000_B647_01B647);
    State.IncCycles();
    // CMP DX,-0x10 (1000_68B8 / 0x168B8)
    Alu.Sub16(DX, 0xFFF0);
    State.IncCycles();
    // JLE 0x1000:68d0 (1000_68BB / 0x168BB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    State.IncCycles();
    // CMP BX,-0x10 (1000_68BD / 0x168BD)
    Alu.Sub16(BX, 0xFFF0);
    State.IncCycles();
    // JLE 0x1000:68d0 (1000_68C0 / 0x168C0)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    State.IncCycles();
    // CMP DX,0x148 (1000_68C2 / 0x168C2)
    Alu.Sub16(DX, 0x148);
    State.IncCycles();
    // JGE 0x1000:68d0 (1000_68C6 / 0x168C6)
    if(SignFlag == OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    State.IncCycles();
    // CMP BX,0xa0 (1000_68C8 / 0x168C8)
    Alu.Sub16(BX, 0xA0);
    State.IncCycles();
    // JGE 0x1000:68d0 (1000_68CC / 0x168CC)
    if(SignFlag == OverflowFlag) {
      goto label_1000_68D0_168D0;
    }
    State.IncCycles();
    // CLC  (1000_68CE / 0x168CE)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_68CF / 0x168CF)
    return NearRet();
    State.IncCycles();
    label_1000_68D0_168D0:
    // STC  (1000_68D0 / 0x168D0)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_68D1 / 0x168D1)
    return NearRet();
  }
  
}
