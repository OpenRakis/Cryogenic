namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_9BC5_019BC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BC5_19BC5:
    // MOV word ptr [SI],0x80 (1000_9BC5 / 0x19BC5)
    UInt16[DS, SI] = 0x80;
    State.IncCycles();
    // JMP 0x1000:9bd7 (1000_9BC9 / 0x19BC9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9BD7_019BD7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9BCC_019BCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BCC_19BCC:
    // CALL 0x1000:9c2d (1000_9BCC / 0x19BCC)
    NearCall(cs1, 0x9BCF, spice86_generated_label_call_target_1000_9C2D_019C2D);
    State.IncCycles();
    label_1000_9BCF_19BCF:
    // CMP word ptr [0xd834],0x13f (1000_9BCF / 0x19BCF)
    Alu.Sub16(UInt16[DS, 0xD834], 0x13F);
    State.IncCycles();
    // JZ 0x1000:9bec (1000_9BD5 / 0x19BD5)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BEC_019BEC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9BD7_019BD7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9BD7_019BD7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BD7_19BD7:
    // MOV SI,0xd834 (1000_9BD7 / 0x19BD7)
    SI = 0xD834;
    State.IncCycles();
    // CMP word ptr [SI + 0x6],0x98 (1000_9BDA / 0x19BDA)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x6)], 0x98);
    State.IncCycles();
    // JC 0x1000:9be6 (1000_9BDF / 0x19BDF)
    if(CarryFlag) {
      goto label_1000_9BE6_19BE6;
    }
    State.IncCycles();
    // MOV word ptr [SI + 0x6],0x98 (1000_9BE1 / 0x19BE1)
    UInt16[DS, (ushort)(SI + 0x6)] = 0x98;
    State.IncCycles();
    label_1000_9BE6_19BE6:
    // CALL 0x1000:c446 (1000_9BE6 / 0x19BE6)
    NearCall(cs1, 0x9BE9, spice86_generated_label_call_target_1000_C446_01C446);
    State.IncCycles();
    label_1000_9BE9_19BE9:
    // CALL 0x1000:9d16 (1000_9BE9 / 0x19BE9)
    NearCall(cs1, 0x9BEC, spice86_generated_label_call_target_1000_9D16_019D16);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BEC_019BEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9BEC_019BEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BEC_19BEC:
    // POP SI (1000_9BEC / 0x19BEC)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_9BED / 0x19BED)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9BEE_019BEE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BEE_19BEE:
    // XOR CX,CX (1000_9BEE / 0x19BEE)
    CX = 0;
    State.IncCycles();
    // PUSH DS (1000_9BF0 / 0x19BF0)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_9BF1 / 0x19BF1)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DS,word ptr SS:[0xdbb2] (1000_9BF2 / 0x19BF2)
    DS = UInt16[SS, 0xDBB2];
    State.IncCycles();
    // MOV DI,0x460a (1000_9BF7 / 0x19BF7)
    DI = 0x460A;
    State.IncCycles();
    label_1000_9BFA_19BFA:
    // LODSB SI (1000_9BFA / 0x19BFA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_9BFB / 0x19BFB)
    AH = 0;
    State.IncCycles();
    // OR AL,AL (1000_9BFD / 0x19BFD)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:9c25 (1000_9BFF / 0x19BFF)
    if(ZeroFlag) {
      goto label_1000_9C25_19C25;
    }
    State.IncCycles();
    // CMP AL,0x1 (1000_9C01 / 0x19C01)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:9c08 (1000_9C03 / 0x19C03)
    if(!ZeroFlag) {
      goto label_1000_9C08_19C08;
    }
    State.IncCycles();
    // MOV AH,AL (1000_9C05 / 0x19C05)
    AH = AL;
    State.IncCycles();
    // LODSB SI (1000_9C07 / 0x19C07)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_9C08_19C08:
    // PUSH SI (1000_9C08 / 0x19C08)
    Stack.Push(SI);
    State.IncCycles();
    // SUB AX,0x2 (1000_9C09 / 0x19C09)
    AX -= 0x2;
    State.IncCycles();
    // SHL AX,1 (1000_9C0C / 0x19C0C)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_9C0E / 0x19C0E)
    BP = AX;
    State.IncCycles();
    // MOV SI,word ptr SS:[0x47cc] (1000_9C10 / 0x19C10)
    SI = UInt16[SS, 0x47CC];
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_9C15 / 0x19C15)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    label_1000_9C18_19C18:
    // LODSB SI (1000_9C18 / 0x19C18)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_9C19 / 0x19C19)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:9c22 (1000_9C1B / 0x19C1B)
    if(ZeroFlag) {
      goto label_1000_9C22_19C22;
    }
    State.IncCycles();
    // STOSB ES:DI (1000_9C1D / 0x19C1D)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_9C1E / 0x19C1E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // INC CX (1000_9C1F / 0x19C1F)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // JMP 0x1000:9c18 (1000_9C20 / 0x19C20)
    goto label_1000_9C18_19C18;
    State.IncCycles();
    label_1000_9C22_19C22:
    // POP SI (1000_9C22 / 0x19C22)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:9bfa (1000_9C23 / 0x19C23)
    goto label_1000_9BFA_19BFA;
    State.IncCycles();
    label_1000_9C25_19C25:
    // MOV word ptr SS:[0x4608],CX (1000_9C25 / 0x19C25)
    UInt16[SS, 0x4608] = CX;
    State.IncCycles();
    // PUSH SS (1000_9C2A / 0x19C2A)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_9C2B / 0x19C2B)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_9C2C / 0x19C2C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9C2D_019C2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9C2D_19C2D:
    // MOV word ptr [0xd834],0x13f (1000_9C2D / 0x19C2D)
    UInt16[DS, 0xD834] = 0x13F;
    State.IncCycles();
    // MOV word ptr [0xd836],0xc7 (1000_9C33 / 0x19C33)
    UInt16[DS, 0xD836] = 0xC7;
    State.IncCycles();
    // XOR AX,AX (1000_9C39 / 0x19C39)
    AX = 0;
    State.IncCycles();
    // MOV [0xd838],AX (1000_9C3B / 0x19C3B)
    UInt16[DS, 0xD838] = AX;
    State.IncCycles();
    // MOV [0xd83a],AX (1000_9C3E / 0x19C3E)
    UInt16[DS, 0xD83A] = AX;
    State.IncCycles();
    // MOV AX,DS (1000_9C41 / 0x19C41)
    AX = DS;
    State.IncCycles();
    // MOV ES,AX (1000_9C43 / 0x19C43)
    ES = AX;
    State.IncCycles();
    // MOV SI,0x4540 (1000_9C45 / 0x19C45)
    SI = 0x4540;
    State.IncCycles();
    // MOV DI,0x4608 (1000_9C48 / 0x19C48)
    DI = 0x4608;
    State.IncCycles();
    // CALL 0x1000:9c54 (1000_9C4B / 0x19C4B)
    NearCall(cs1, 0x9C4E, spice86_generated_label_call_target_1000_9C54_019C54);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9C4E_019C4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9C4E_019C4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9C4E_19C4E:
    // MOV SI,0x4608 (1000_9C4E / 0x19C4E)
    SI = 0x4608;
    State.IncCycles();
    // MOV DI,0x4540 (1000_9C51 / 0x19C51)
    DI = 0x4540;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9C54_019C54, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9C54_019C54(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9C54_19C54:
    // LODSW SI (1000_9C54 / 0x19C54)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_9C55 / 0x19C55)
    CX = AX;
    State.IncCycles();
    label_1000_9C57_19C57:
    // PUSH CX (1000_9C57 / 0x19C57)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_9C58 / 0x19C58)
    Stack.Push(DI);
    State.IncCycles();
    // MOV CX,word ptr [DI] (1000_9C59 / 0x19C59)
    CX = UInt16[DS, DI];
    State.IncCycles();
    // ADD DI,0x2 (1000_9C5B / 0x19C5B)
    DI += 0x2;
    State.IncCycles();
    label_1000_9C5E_19C5E:
    // CMPSW ES:DI,SI (1000_9C5E / 0x19C5E)
    Alu.Sub16(UInt16[DS, SI], UInt16[ES, DI]);
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LAHF  (1000_9C5F / 0x19C5F)
    AH = (byte)FlagRegister;
    State.IncCycles();
    // CMPSB ES:DI,SI (1000_9C60 / 0x19C60)
    Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,AH (1000_9C61 / 0x19C61)
    AL = AH;
    State.IncCycles();
    // LAHF  (1000_9C63 / 0x19C63)
    AH = (byte)FlagRegister;
    State.IncCycles();
    // AND AL,AH (1000_9C64 / 0x19C64)
    AL &= AH;
    State.IncCycles();
    // TEST AL,0x40 (1000_9C66 / 0x19C66)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JNZ 0x1000:9c75 (1000_9C68 / 0x19C68)
    if(!ZeroFlag) {
      goto label_1000_9C75_19C75;
    }
    State.IncCycles();
    // SUB SI,0x3 (1000_9C6A / 0x19C6A)
    // SI -= 0x3;
    SI = Alu.Sub16(SI, 0x3);
    State.IncCycles();
    // LOOP 0x1000:9c5e (1000_9C6D / 0x19C6D)
    if(--CX != 0) {
      goto label_1000_9C5E_19C5E;
    }
    State.IncCycles();
    // CALL 0x1000:9cc6 (1000_9C6F / 0x19C6F)
    NearCall(cs1, 0x9C72, spice86_generated_label_call_target_1000_9CC6_019CC6);
    State.IncCycles();
    label_1000_9C72_19C72:
    // ADD SI,0x3 (1000_9C72 / 0x19C72)
    // SI += 0x3;
    SI = Alu.Add16(SI, 0x3);
    State.IncCycles();
    label_1000_9C75_19C75:
    // POP DI (1000_9C75 / 0x19C75)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_9C76 / 0x19C76)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:9c57 (1000_9C77 / 0x19C77)
    if(--CX != 0) {
      goto label_1000_9C57_19C57;
    }
    State.IncCycles();
    // CMP byte ptr [0x47e1],0x81 (1000_9C79 / 0x19C79)
    Alu.Sub8(UInt8[DS, 0x47E1], 0x81);
    State.IncCycles();
    // JZ 0x1000:9ca6 (1000_9C7E / 0x19C7E)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9C83_019C83, 0x19CA6 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:abcc (1000_9C80 / 0x19C80)
    NearCall(cs1, 0x9C83, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9C83_019C83, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9C83_019C83(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9CA6: goto label_1000_9CA6_19CA6;break; // Target of external jump from 0x19C83, 0x19C7E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9C83_19C83:
    // JZ 0x1000:9ca6 (1000_9C83 / 0x19C83)
    if(ZeroFlag) {
      goto label_1000_9CA6_19CA6;
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_9C85 / 0x19C85)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AL,0x9 (1000_9C88 / 0x19C88)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JZ 0x1000:9cc5 (1000_9C8A / 0x19C8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0xc (1000_9C8C / 0x19C8C)
    Alu.Sub8(AL, 0xC);
    State.IncCycles();
    // JZ 0x1000:9cc5 (1000_9C8E / 0x19C8E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0xdc28] (1000_9C90 / 0x19C90)
    SI = UInt16[DS, 0xDC28];
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_9C94 / 0x19C94)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // CMP AX,word ptr [0xd83a] (1000_9C97 / 0x19C97)
    Alu.Sub16(AX, UInt16[DS, 0xD83A]);
    State.IncCycles();
    // JNC 0x1000:9ca6 (1000_9C9B / 0x19C9B)
    if(!CarryFlag) {
      goto label_1000_9CA6_19CA6;
    }
    State.IncCycles();
    // MOV [0xd83a],AX (1000_9C9D / 0x19C9D)
    UInt16[DS, 0xD83A] = AX;
    State.IncCycles();
    // CMP AX,word ptr [0xd836] (1000_9CA0 / 0x19CA0)
    Alu.Sub16(AX, UInt16[DS, 0xD836]);
    State.IncCycles();
    // JLE 0x1000:9cbf (1000_9CA4 / 0x19CA4)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9CBF_19CBF;
    }
    State.IncCycles();
    label_1000_9CA6_19CA6:
    // CMP byte ptr [0x47e1],0x80 (1000_9CA6 / 0x19CA6)
    Alu.Sub8(UInt8[DS, 0x47E1], 0x80);
    State.IncCycles();
    // JNZ 0x1000:9cc5 (1000_9CAB / 0x19CAB)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x4c (1000_9CAD / 0x19CAD)
    AX = 0x4C;
    State.IncCycles();
    // CMP AX,word ptr [0xd83a] (1000_9CB0 / 0x19CB0)
    Alu.Sub16(AX, UInt16[DS, 0xD83A]);
    State.IncCycles();
    // JNC 0x1000:9cc5 (1000_9CB4 / 0x19CB4)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0xd83a],AX (1000_9CB6 / 0x19CB6)
    UInt16[DS, 0xD83A] = AX;
    State.IncCycles();
    // CMP AX,word ptr [0xd836] (1000_9CB9 / 0x19CB9)
    Alu.Sub16(AX, UInt16[DS, 0xD836]);
    State.IncCycles();
    // JG 0x1000:9cc5 (1000_9CBD / 0x19CBD)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9CC5 / 0x19CC5)
      return NearRet();
    }
    State.IncCycles();
    label_1000_9CBF_19CBF:
    // MOV word ptr [0xd834],0x13f (1000_9CBF / 0x19CBF)
    UInt16[DS, 0xD834] = 0x13F;
    State.IncCycles();
    label_1000_9CC5_19CC5:
    // RET  (1000_9CC5 / 0x19CC5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9CC6_019CC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9CC6_19CC6:
    // PUSH SI (1000_9CC6 / 0x19CC6)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_9CC7 / 0x19CC7)
    Stack.Push(DS);
    State.IncCycles();
    // XOR AH,AH (1000_9CC8 / 0x19CC8)
    AH = 0;
    State.IncCycles();
    // LODSB SI (1000_9CCA / 0x19CCA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV BP,AX (1000_9CCB / 0x19CCB)
    BP = AX;
    State.IncCycles();
    // DEC BP (1000_9CCD / 0x19CCD)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // LODSB SI (1000_9CCE / 0x19CCE)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV DX,AX (1000_9CCF / 0x19CCF)
    DX = AX;
    State.IncCycles();
    // ADD DX,word ptr [0x1bf0] (1000_9CD1 / 0x19CD1)
    // DX += UInt16[DS, 0x1BF0];
    DX = Alu.Add16(DX, UInt16[DS, 0x1BF0]);
    State.IncCycles();
    // LODSB SI (1000_9CD5 / 0x19CD5)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV BX,AX (1000_9CD6 / 0x19CD6)
    BX = AX;
    State.IncCycles();
    // ADD BX,word ptr [0x1bf2] (1000_9CD8 / 0x19CD8)
    // BX += UInt16[DS, 0x1BF2];
    BX = Alu.Add16(BX, UInt16[DS, 0x1BF2]);
    State.IncCycles();
    // LDS SI,[0xdbb0] (1000_9CDC / 0x19CDC)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // SHL BP,1 (1000_9CE0 / 0x19CE0)
    BP <<= 0x1;
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_9CE2 / 0x19CE2)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // MOV BP,0xd834 (1000_9CE5 / 0x19CE5)
    BP = 0xD834;
    State.IncCycles();
    // CMP word ptr [BP + 0x0],DX (1000_9CE8 / 0x19CE8)
    Alu.Sub16(UInt16[SS, BP], DX);
    State.IncCycles();
    // JC 0x1000:9cf0 (1000_9CEB / 0x19CEB)
    if(CarryFlag) {
      goto label_1000_9CF0_19CF0;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x0],DX (1000_9CED / 0x19CED)
    UInt16[SS, BP] = DX;
    State.IncCycles();
    label_1000_9CF0_19CF0:
    // CMP word ptr [BP + 0x2],BX (1000_9CF0 / 0x19CF0)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], BX);
    State.IncCycles();
    // JC 0x1000:9cf8 (1000_9CF3 / 0x19CF3)
    if(CarryFlag) {
      goto label_1000_9CF8_19CF8;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],BX (1000_9CF5 / 0x19CF5)
    UInt16[SS, (ushort)(BP + 0x2)] = BX;
    State.IncCycles();
    label_1000_9CF8_19CF8:
    // LODSW SI (1000_9CF8 / 0x19CF8)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AX,0x1ff (1000_9CF9 / 0x19CF9)
    AX &= 0x1FF;
    State.IncCycles();
    // ADD DX,AX (1000_9CFC / 0x19CFC)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // LODSW SI (1000_9CFE / 0x19CFE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XOR AH,AH (1000_9CFF / 0x19CFF)
    AH = 0;
    State.IncCycles();
    // ADD BX,AX (1000_9D01 / 0x19D01)
    BX += AX;
    State.IncCycles();
    // CMP word ptr [BP + 0x4],DX (1000_9D03 / 0x19D03)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x4)], DX);
    State.IncCycles();
    // JNC 0x1000:9d0b (1000_9D06 / 0x19D06)
    if(!CarryFlag) {
      goto label_1000_9D0B_19D0B;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x4],DX (1000_9D08 / 0x19D08)
    UInt16[SS, (ushort)(BP + 0x4)] = DX;
    State.IncCycles();
    label_1000_9D0B_19D0B:
    // CMP word ptr [BP + 0x6],BX (1000_9D0B / 0x19D0B)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], BX);
    State.IncCycles();
    // JNC 0x1000:9d13 (1000_9D0E / 0x19D0E)
    if(!CarryFlag) {
      goto label_1000_9D13_19D13;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x6],BX (1000_9D10 / 0x19D10)
    UInt16[SS, (ushort)(BP + 0x6)] = BX;
    State.IncCycles();
    label_1000_9D13_19D13:
    // POP DS (1000_9D13 / 0x19D13)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_9D14 / 0x19D14)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_9D15 / 0x19D15)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9D16_019D16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9D16_19D16:
    // PUSH DS (1000_9D16 / 0x19D16)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_9D17 / 0x19D17)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x4540 (1000_9D18 / 0x19D18)
    DI = 0x4540;
    State.IncCycles();
    // MOV SI,0x4608 (1000_9D1B / 0x19D1B)
    SI = 0x4608;
    State.IncCycles();
    // MOV CX,word ptr [SI] (1000_9D1E / 0x19D1E)
    CX = UInt16[DS, SI];
    State.IncCycles();
    // PUSH SI (1000_9D20 / 0x19D20)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AX,CX (1000_9D21 / 0x19D21)
    AX = CX;
    State.IncCycles();
    // SHL CX,1 (1000_9D23 / 0x19D23)
    CX <<= 0x1;
    State.IncCycles();
    // ADD CX,AX (1000_9D25 / 0x19D25)
    CX += AX;
    State.IncCycles();
    // ADD CX,0x2 (1000_9D27 / 0x19D27)
    // CX += 0x2;
    CX = Alu.Add16(CX, 0x2);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_9D2A / 0x19D2A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP SI (1000_9D2C / 0x19D2C)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_9D2D_019D2D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9D2D_019D2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9D2D_19D2D:
    // LODSW SI (1000_9D2D / 0x19D2D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_9D2E / 0x19D2E)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9D30_019D30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9D30_019D30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9D30_19D30:
    // PUSH CX (1000_9D30 / 0x19D30)
    Stack.Push(CX);
    State.IncCycles();
    // LODSB SI (1000_9D31 / 0x19D31)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_9D32 / 0x19D32)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_9D34 / 0x19D34)
    BP = AX;
    State.IncCycles();
    // LODSB SI (1000_9D36 / 0x19D36)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV DX,AX (1000_9D37 / 0x19D37)
    DX = AX;
    State.IncCycles();
    // LODSB SI (1000_9D39 / 0x19D39)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV BX,AX (1000_9D3A / 0x19D3A)
    BX = AX;
    State.IncCycles();
    // ADD DX,word ptr [0x1bf0] (1000_9D3C / 0x19D3C)
    DX += UInt16[DS, 0x1BF0];
    State.IncCycles();
    // ADD BX,word ptr [0x1bf2] (1000_9D40 / 0x19D40)
    // BX += UInt16[DS, 0x1BF2];
    BX = Alu.Add16(BX, UInt16[DS, 0x1BF2]);
    State.IncCycles();
    // PUSH SI (1000_9D44 / 0x19D44)
    Stack.Push(SI);
    State.IncCycles();
    // DEC BP (1000_9D45 / 0x19D45)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_9D46 / 0x19D46)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // LDS SI,[0xdbb0] (1000_9D4A / 0x19D4A)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // SHL BP,1 (1000_9D4E / 0x19D4E)
    BP <<= 0x1;
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_9D50 / 0x19D50)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // LODSW SI (1000_9D53 / 0x19D53)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_9D54 / 0x19D54)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_9D56 / 0x19D56)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XOR AH,AH (1000_9D57 / 0x19D57)
    AH = 0;
    State.IncCycles();
    // MOV CX,AX (1000_9D59 / 0x19D59)
    CX = AX;
    State.IncCycles();
    // MOV BP,0xd834 (1000_9D5B / 0x19D5B)
    BP = 0xD834;
    State.IncCycles();
    // CALLF [0x38cd] (1000_9D5E / 0x19D5E)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_9D5E = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_9D5E) {
      case 0x235C2 : FarCall(cs1, 0x9D63, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9D5E));
        break;
    }
    State.IncCycles();
    label_1000_9D63_19D63:
    // PUSH SS (1000_9D63 / 0x19D63)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_9D64 / 0x19D64)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_9D65 / 0x19D65)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_9D66 / 0x19D66)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:9d30 (1000_9D67 / 0x19D67)
    if(--CX != 0) {
      goto label_1000_9D30_19D30;
    }
    State.IncCycles();
    // RET  (1000_9D69 / 0x19D69)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9D6A_019D6A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9D93: goto label_1000_9D93_19D93;break; // Target of external jump from 0x19D74, 0x19D98
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9D6A_19D6A:
    // MOV ES,word ptr SS:[0xdbd8] (1000_9D6A / 0x19D6A)
    ES = UInt16[SS, 0xDBD8];
    State.IncCycles();
    label_1000_9D6F_19D6F:
    // LODSB SI (1000_9D6F / 0x19D6F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_9D70 / 0x19D70)
    AH = 0;
    State.IncCycles();
    // OR AL,AL (1000_9D72 / 0x19D72)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:9d93 (1000_9D74 / 0x19D74)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9D93 / 0x19D93)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0x1 (1000_9D76 / 0x19D76)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:9d7d (1000_9D78 / 0x19D78)
    if(!ZeroFlag) {
      goto label_1000_9D7D_19D7D;
    }
    State.IncCycles();
    // MOV AH,AL (1000_9D7A / 0x19D7A)
    AH = AL;
    State.IncCycles();
    // LODSB SI (1000_9D7C / 0x19D7C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_9D7D_19D7D:
    // PUSH SI (1000_9D7D / 0x19D7D)
    Stack.Push(SI);
    State.IncCycles();
    // SUB AX,0x2 (1000_9D7E / 0x19D7E)
    AX -= 0x2;
    State.IncCycles();
    // SHL AX,1 (1000_9D81 / 0x19D81)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_9D83 / 0x19D83)
    BP = AX;
    State.IncCycles();
    // MOV SI,word ptr SS:[0x47cc] (1000_9D85 / 0x19D85)
    SI = UInt16[SS, 0x47CC];
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_9D8A / 0x19D8A)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // CALL 0x1000:9d94 (1000_9D8D / 0x19D8D)
    NearCall(cs1, 0x9D90, spice86_generated_label_call_target_1000_9D94_019D94);
    State.IncCycles();
    label_1000_9D90_19D90:
    // POP SI (1000_9D90 / 0x19D90)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:9d6f (1000_9D91 / 0x19D91)
    goto label_1000_9D6F_19D6F;
    State.IncCycles();
    label_1000_9D93_19D93:
    // RET  (1000_9D93 / 0x19D93)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9D94_019D94(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9D94_19D94:
    // LODSB SI (1000_9D94 / 0x19D94)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // AND AX,0xff (1000_9D95 / 0x19D95)
    // AX &= 0xFF;
    AX = Alu.And16(AX, 0xFF);
    State.IncCycles();
    // JZ 0x1000:9d93 (1000_9D98 / 0x19D98)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9D93 / 0x19D93)
      return NearRet();
    }
    State.IncCycles();
    // XOR AH,AH (1000_9D9A / 0x19D9A)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_9D9C / 0x19D9C)
    BP = AX;
    State.IncCycles();
    // LODSB SI (1000_9D9E / 0x19D9E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV DX,AX (1000_9D9F / 0x19D9F)
    DX = AX;
    State.IncCycles();
    // LODSB SI (1000_9DA1 / 0x19DA1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV BX,AX (1000_9DA2 / 0x19DA2)
    BX = AX;
    State.IncCycles();
    // ADD DX,word ptr SS:[0x1bf0] (1000_9DA4 / 0x19DA4)
    DX += UInt16[SS, 0x1BF0];
    State.IncCycles();
    // ADD BX,word ptr SS:[0x1bf2] (1000_9DA9 / 0x19DA9)
    BX += UInt16[SS, 0x1BF2];
    State.IncCycles();
    // SUB DX,word ptr SS:[0x46d2] (1000_9DAE / 0x19DAE)
    DX -= UInt16[SS, 0x46D2];
    State.IncCycles();
    // SUB BX,word ptr SS:[0x46d4] (1000_9DB3 / 0x19DB3)
    BX -= UInt16[SS, 0x46D4];
    State.IncCycles();
    // ADD DX,word ptr SS:[0x47d4] (1000_9DB8 / 0x19DB8)
    DX += UInt16[SS, 0x47D4];
    State.IncCycles();
    // ADD BX,word ptr SS:[0x47d6] (1000_9DBD / 0x19DBD)
    // BX += UInt16[SS, 0x47D6];
    BX = Alu.Add16(BX, UInt16[SS, 0x47D6]);
    State.IncCycles();
    // PUSH SI (1000_9DC2 / 0x19DC2)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_9DC3 / 0x19DC3)
    Stack.Push(DS);
    State.IncCycles();
    // DEC BP (1000_9DC4 / 0x19DC4)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // LDS SI,SS:[0xdbb0] (1000_9DC5 / 0x19DC5)
    DS = UInt16[SS, 0xDBB2];
    SI = UInt16[SS, 0xDBB0];
    State.IncCycles();
    // SHL BP,1 (1000_9DCA / 0x19DCA)
    BP <<= 0x1;
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_9DCC / 0x19DCC)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // LODSW SI (1000_9DCF / 0x19DCF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_9DD0 / 0x19DD0)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_9DD2 / 0x19DD2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XOR AH,AH (1000_9DD3 / 0x19DD3)
    AH = 0;
    State.IncCycles();
    // MOV CX,AX (1000_9DD5 / 0x19DD5)
    CX = AX;
    State.IncCycles();
    // MOV BP,0x47d4 (1000_9DD7 / 0x19DD7)
    BP = 0x47D4;
    State.IncCycles();
    // CALLF [0x38cd] (1000_9DDA / 0x19DDA)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_9DDA = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_9DDA) {
      case 0x235C2 : FarCall(cs1, 0x9DDF, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9DDA));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9DDF_019DDF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9DDF_019DDF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9DDF_19DDF:
    // POP DS (1000_9DDF / 0x19DDF)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_9DE0 / 0x19DE0)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:9d94 (1000_9DE1 / 0x19DE1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9D94_019D94, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_9DE3_019DE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9DE3_19DE3:
    // CMP word ptr [0x47c4],0x10 (1000_9DE3 / 0x19DE3)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    State.IncCycles();
    // JNC 0x1000:9d93 (1000_9DE8 / 0x19DE8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9D93 / 0x19D93)
      return NearRet();
    }
    State.IncCycles();
    // PUSH AX (1000_9DEA / 0x19DEA)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_9DEB / 0x19DEB)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:9197 (1000_9DEC / 0x19DEC)
    NearCall(cs1, 0x9DEF, spice86_generated_label_call_target_1000_9197_019197);
    State.IncCycles();
    // POP SI (1000_9DEF / 0x19DEF)
    SI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_9DF0 / 0x19DF0)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_9DF1 / 0x19DF1)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:9e75 (1000_9DF6 / 0x19DF6)
    if(SignFlag) {
      goto label_1000_9E75_19E75;
    }
    State.IncCycles();
    // MOV DI,0xd834 (1000_9DF8 / 0x19DF8)
    DI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_9DFB / 0x19DFB)
    NearCall(cs1, 0x9DFE, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    // MOV DX,word ptr [0x1bf0] (1000_9DFE / 0x19DFE)
    DX = UInt16[DS, 0x1BF0];
    State.IncCycles();
    // MOV BX,word ptr [0x1bf2] (1000_9E02 / 0x19E02)
    BX = UInt16[DS, 0x1BF2];
    State.IncCycles();
    // ADD word ptr [DI + -0x8],DX (1000_9E06 / 0x19E06)
    UInt16[DS, (ushort)(DI - 0x8)] += DX;
    State.IncCycles();
    // ADD word ptr [DI + -0x6],BX (1000_9E09 / 0x19E09)
    UInt16[DS, (ushort)(DI - 0x6)] += BX;
    State.IncCycles();
    // ADD word ptr [DI + -0x4],DX (1000_9E0C / 0x19E0C)
    UInt16[DS, (ushort)(DI - 0x4)] += DX;
    State.IncCycles();
    // ADD word ptr [DI + -0x2],BX (1000_9E0F / 0x19E0F)
    // UInt16[DS, (ushort)(DI - 0x2)] += BX;
    UInt16[DS, (ushort)(DI - 0x2)] = Alu.Add16(UInt16[DS, (ushort)(DI - 0x2)], BX);
    State.IncCycles();
    // MOV SI,word ptr [0x47d2] (1000_9E12 / 0x19E12)
    SI = UInt16[DS, 0x47D2];
    State.IncCycles();
    // MOV AH,byte ptr [0x47d0] (1000_9E16 / 0x19E16)
    AH = UInt8[DS, 0x47D0];
    State.IncCycles();
    // DEC AH (1000_9E1A / 0x19E1A)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // JS 0x1000:9e2d (1000_9E1C / 0x19E1C)
    if(SignFlag) {
      goto label_1000_9E2D_19E2D;
    }
    State.IncCycles();
    // CMP word ptr [0x22a6],0xd (1000_9E1E / 0x19E1E)
    Alu.Sub16(UInt16[DS, 0x22A6], 0xD);
    State.IncCycles();
    // JNZ 0x1000:9e27 (1000_9E23 / 0x19E23)
    if(!ZeroFlag) {
      goto label_1000_9E27_19E27;
    }
    State.IncCycles();
    // ADD AL,AH (1000_9E25 / 0x19E25)
    AL += AH;
    State.IncCycles();
    label_1000_9E27_19E27:
    // SHL AH,1 (1000_9E27 / 0x19E27)
    AH <<= 0x1;
    State.IncCycles();
    // SHL AH,1 (1000_9E29 / 0x19E29)
    AH <<= 0x1;
    State.IncCycles();
    // ADD AL,AH (1000_9E2B / 0x19E2B)
    AL += AH;
    State.IncCycles();
    label_1000_9E2D_19E2D:
    // XOR AH,AH (1000_9E2D / 0x19E2D)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_9E2F / 0x19E2F)
    AX <<= 0x1;
    State.IncCycles();
    // ADD SI,AX (1000_9E31 / 0x19E31)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // CALL 0x1000:9bee (1000_9E33 / 0x19E33)
    NearCall(cs1, 0x9E36, spice86_generated_label_call_target_1000_9BEE_019BEE);
    State.IncCycles();
    // MOV SI,0x4608 (1000_9E36 / 0x19E36)
    SI = 0x4608;
    State.IncCycles();
    // CMP byte ptr [0xea],0x0 (1000_9E39 / 0x19E39)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    State.IncCycles();
    // JG 0x1000:9e74 (1000_9E3E / 0x19E3E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9E74 / 0x19E74)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [SI],0x2 (1000_9E40 / 0x19E40)
    Alu.Sub16(UInt16[DS, SI], 0x2);
    State.IncCycles();
    // JC 0x1000:9e57 (1000_9E43 / 0x19E43)
    if(CarryFlag) {
      goto label_1000_9E57_19E57;
    }
    State.IncCycles();
    // CALL 0x1000:9d2d (1000_9E45 / 0x19E45)
    NearCall(cs1, 0x9E48, not_observed_1000_9D2D_019D2D);
    State.IncCycles();
    // CALL 0x1000:908c (1000_9E48 / 0x19E48)
    NearCall(cs1, 0x9E4B, spice86_generated_label_call_target_1000_908C_01908C);
    State.IncCycles();
    // MOV SI,0xd834 (1000_9E4B / 0x19E4B)
    SI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_9E4E / 0x19E4E)
    NearCall(cs1, 0x9E51, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    // CALL 0x1000:c4f0 (1000_9E51 / 0x19E51)
    NearCall(cs1, 0x9E54, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    State.IncCycles();
    // JMP 0x1000:db67 (1000_9E54 / 0x19E54)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9E57_19E57:
    // MOV SI,0xd834 (1000_9E57 / 0x19E57)
    SI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_9E5A / 0x19E5A)
    NearCall(cs1, 0x9E5D, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    // PUSH word ptr [0xdbda] (1000_9E5D / 0x19E5D)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_9E61 / 0x19E61)
    NearCall(cs1, 0x9E64, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // MOV SI,0x4608 (1000_9E64 / 0x19E64)
    SI = 0x4608;
    State.IncCycles();
    // CALL 0x1000:9d2d (1000_9E67 / 0x19E67)
    NearCall(cs1, 0x9E6A, not_observed_1000_9D2D_019D2D);
    State.IncCycles();
    // CALL 0x1000:908c (1000_9E6A / 0x19E6A)
    NearCall(cs1, 0x9E6D, spice86_generated_label_call_target_1000_908C_01908C);
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_9E6D / 0x19E6D)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:db67 (1000_9E71 / 0x19E71)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9E74_19E74:
    // RET  (1000_9E74 / 0x19E74)
    return NearRet();
    State.IncCycles();
    label_1000_9E75_19E75:
    // MOV SI,word ptr [0x47d2] (1000_9E75 / 0x19E75)
    SI = UInt16[DS, 0x47D2];
    State.IncCycles();
    // CMP word ptr [0x47c4],0xc (1000_9E79 / 0x19E79)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xC);
    State.IncCycles();
    // JZ 0x1000:9e8c (1000_9E7E / 0x19E7E)
    if(ZeroFlag) {
      goto label_1000_9E8C_19E8C;
    }
    State.IncCycles();
    // MOV AH,byte ptr [0x47d0] (1000_9E80 / 0x19E80)
    AH = UInt8[DS, 0x47D0];
    State.IncCycles();
    // DEC AH (1000_9E84 / 0x19E84)
    AH--;
    State.IncCycles();
    // SHL AH,1 (1000_9E86 / 0x19E86)
    AH <<= 0x1;
    State.IncCycles();
    // SHL AH,1 (1000_9E88 / 0x19E88)
    AH <<= 0x1;
    State.IncCycles();
    // ADD AL,AH (1000_9E8A / 0x19E8A)
    AL += AH;
    State.IncCycles();
    label_1000_9E8C_19E8C:
    // XOR AH,AH (1000_9E8C / 0x19E8C)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_9E8E / 0x19E8E)
    AX <<= 0x1;
    State.IncCycles();
    // ADD SI,AX (1000_9E90 / 0x19E90)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // PUSH SI (1000_9E92 / 0x19E92)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x47d4 (1000_9E93 / 0x19E93)
    SI = 0x47D4;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_9E96 / 0x19E96)
    NearCall(cs1, 0x9E99, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    // POP SI (1000_9E99 / 0x19E99)
    SI = Stack.Pop();
    State.IncCycles();
    // PUSH DS (1000_9E9A / 0x19E9A)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,word ptr SS:[0xdbb2] (1000_9E9B / 0x19E9B)
    DS = UInt16[SS, 0xDBB2];
    State.IncCycles();
    // LODSB SI (1000_9EA0 / 0x19EA0)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_9EA1 / 0x19EA1)
    AH = 0;
    State.IncCycles();
    // SUB AL,0x2 (1000_9EA3 / 0x19EA3)
    AL -= 0x2;
    State.IncCycles();
    // SHL AX,1 (1000_9EA5 / 0x19EA5)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_9EA7 / 0x19EA7)
    BP = AX;
    State.IncCycles();
    // MOV SI,word ptr SS:[0x47cc] (1000_9EA9 / 0x19EA9)
    SI = UInt16[SS, 0x47CC];
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_9EAE / 0x19EAE)
    SI += UInt16[DS, (ushort)(BP + SI)];
    State.IncCycles();
    // CMP byte ptr [SI + 0x3],0x0 (1000_9EB1 / 0x19EB1)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x0);
    State.IncCycles();
    // JZ 0x1000:9ec9 (1000_9EB5 / 0x19EB5)
    if(ZeroFlag) {
      goto label_1000_9EC9_19EC9;
    }
    State.IncCycles();
    // MOV ES,word ptr SS:[0xdbd6] (1000_9EB7 / 0x19EB7)
    ES = UInt16[SS, 0xDBD6];
    State.IncCycles();
    // CALL 0x1000:9d94 (1000_9EBC / 0x19EBC)
    NearCall(cs1, 0x9EBF, spice86_generated_label_call_target_1000_9D94_019D94);
    State.IncCycles();
    // POP DS (1000_9EBF / 0x19EBF)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x47d4 (1000_9EC0 / 0x19EC0)
    SI = 0x47D4;
    State.IncCycles();
    // CALL 0x1000:c4f0 (1000_9EC3 / 0x19EC3)
    NearCall(cs1, 0x9EC6, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    State.IncCycles();
    // JMP 0x1000:db67 (1000_9EC6 / 0x19EC6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9EC9_19EC9:
    // MOV ES,word ptr SS:[0xdbd8] (1000_9EC9 / 0x19EC9)
    ES = UInt16[SS, 0xDBD8];
    State.IncCycles();
    // CALL 0x1000:9d94 (1000_9ECE / 0x19ECE)
    NearCall(cs1, 0x9ED1, spice86_generated_label_call_target_1000_9D94_019D94);
    State.IncCycles();
    // POP DS (1000_9ED1 / 0x19ED1)
    DS = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:db67 (1000_9ED2 / 0x19ED2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9ED5_019ED5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9ED5_19ED5:
    // CMP word ptr [0x47c4],0x10 (1000_9ED5 / 0x19ED5)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    State.IncCycles();
    // JNC 0x1000:9eeb (1000_9EDA / 0x19EDA)
    if(!CarryFlag) {
      goto label_1000_9EEB_19EEB;
    }
    State.IncCycles();
    // CALL 0x1000:9985 (1000_9EDC / 0x19EDC)
    NearCall(cs1, 0x9EDF, spice86_generated_label_ret_target_1000_9985_019985);
    State.IncCycles();
    label_1000_9EDF_19EDF:
    // CMP byte ptr [0x47e1],0x81 (1000_9EDF / 0x19EDF)
    Alu.Sub8(UInt8[DS, 0x47E1], 0x81);
    State.IncCycles();
    // JNZ 0x1000:9eeb (1000_9EE4 / 0x19EE4)
    if(!ZeroFlag) {
      goto label_1000_9EEB_19EEB;
    }
    State.IncCycles();
    // MOV byte ptr [0x47e1],0x1 (1000_9EE6 / 0x19EE6)
    UInt8[DS, 0x47E1] = 0x1;
    State.IncCycles();
    label_1000_9EEB_19EEB:
    // CALL 0x1000:c85b (1000_9EEB / 0x19EEB)
    NearCall(cs1, 0x9EEE, spice86_generated_label_call_target_1000_C85B_01C85B);
    State.IncCycles();
    label_1000_9EEE_19EEE:
    // MOV AL,[0x47dd] (1000_9EEE / 0x19EEE)
    AL = UInt8[DS, 0x47DD];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_9EF1_019EF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9EF1_019EF1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9EFC: goto label_1000_9EFC_19EFC;break; // Target of external jump from 0x19F0D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9EF1_19EF1:
    // MOV [0x47dc],AL (1000_9EF1 / 0x19EF1)
    UInt8[DS, 0x47DC] = AL;
    State.IncCycles();
    // CALL 0x1000:9efd (1000_9EF4 / 0x19EF4)
    NearCall(cs1, 0x9EF7, spice86_generated_label_call_target_1000_9EFD_019EFD);
    State.IncCycles();
    label_1000_9EF7_19EF7:
    // MOV byte ptr [0x47dc],0x0 (1000_9EF7 / 0x19EF7)
    UInt8[DS, 0x47DC] = 0x0;
    State.IncCycles();
    label_1000_9EFC_19EFC:
    // RET  (1000_9EFC / 0x19EFC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9EFD_019EFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9EFD_19EFD:
    // MOV AL,[0x47dc] (1000_9EFD / 0x19EFD)
    AL = UInt8[DS, 0x47DC];
    State.IncCycles();
    // MOV [0x47dd],AL (1000_9F00 / 0x19F00)
    UInt8[DS, 0x47DD] = AL;
    State.IncCycles();
    // MOV AX,[0x4780] (1000_9F03 / 0x19F03)
    AX = UInt16[DS, 0x4780];
    State.IncCycles();
    // MOV BX,word ptr [0x47c4] (1000_9F06 / 0x19F06)
    BX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CALL 0x1000:a6cc (1000_9F0A / 0x19F0A)
    NearCall(cs1, 0x9F0D, spice86_generated_label_call_target_1000_A6CC_01A6CC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9F0D_019F0D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9F0D_019F0D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F0D_19F0D:
    // JNC 0x1000:9efc (1000_9F0D / 0x19F0D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9EFC / 0x19EFC)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x47c4],0x10 (1000_9F0F / 0x19F0F)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    State.IncCycles();
    // JNC 0x1000:9f19 (1000_9F14 / 0x19F14)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:a75c (1000_9F19 / 0x19F19)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0x1A75C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:9f1c (1000_9F16 / 0x19F16)
    NearCall(cs1, 0x9F19, not_observed_1000_9F1C_019F1C);
    State.IncCycles();
    label_1000_9F19_19F19:
    // JMP 0x1000:a75c (1000_9F19 / 0x19F19)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0x1A75C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9F1C_019F1C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F1C_19F1C:
    // CALL 0x1000:9197 (1000_9F1C / 0x19F1C)
    NearCall(cs1, 0x9F1F, spice86_generated_label_call_target_1000_9197_019197);
    State.IncCycles();
    // OR byte ptr [0x47d1],0x10 (1000_9F1F / 0x19F1F)
    // UInt8[DS, 0x47D1] |= 0x10;
    UInt8[DS, 0x47D1] = Alu.Or8(UInt8[DS, 0x47D1], 0x10);
    State.IncCycles();
    // CALL 0x1000:9a7b (1000_9F24 / 0x19F24)
    NearCall(cs1, 0x9F27, spice86_generated_label_call_target_1000_9A7B_019A7B);
    State.IncCycles();
    // XOR AH,AH (1000_9F27 / 0x19F27)
    AH = 0;
    State.IncCycles();
    // CALL 0x1000:9a60 (1000_9F29 / 0x19F29)
    NearCall(cs1, 0x9F2C, spice86_generated_label_call_target_1000_9A60_019A60);
    State.IncCycles();
    // MOV word ptr [0x47c6],SI (1000_9F2C / 0x19F2C)
    UInt16[DS, 0x47C6] = SI;
    State.IncCycles();
    // RET  (1000_9F30 / 0x19F30)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F31_019F31(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F31_19F31:
    // MOV SI,word ptr [0x47be] (1000_9F31 / 0x19F31)
    SI = UInt16[DS, 0x47BE];
    State.IncCycles();
    // AND SI,0xfff8 (1000_9F35 / 0x19F35)
    SI &= 0xFFF8;
    State.IncCycles();
    // ADD SI,AX (1000_9F38 / 0x19F38)
    SI += AX;
    State.IncCycles();
    // SHL SI,1 (1000_9F3A / 0x19F3A)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr [SI + 0xaa76] (1000_9F3C / 0x19F3C)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F40_019F40, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F40_019F40(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F40_19F40:
    // MOV AX,[0x47c4] (1000_9F40 / 0x19F40)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AX,0x2 (1000_9F43 / 0x19F43)
    Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // JNZ 0x1000:9f56 (1000_9F46 / 0x19F46)
    if(!ZeroFlag) {
      goto label_1000_9F56_19F56;
    }
    State.IncCycles();
    // CMP byte ptr [0xc2],0x4 (1000_9F48 / 0x19F48)
    Alu.Sub8(UInt8[DS, 0xC2], 0x4);
    State.IncCycles();
    // JNZ 0x1000:9f56 (1000_9F4D / 0x19F4D)
    if(!ZeroFlag) {
      goto label_1000_9F56_19F56;
    }
    State.IncCycles();
    // PUSH AX (1000_9F4F / 0x19F4F)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_9F50 / 0x19F50)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:1243 (1000_9F51 / 0x19F51)
    NearCall(cs1, 0x9F54, not_observed_1000_1243_011243);
    State.IncCycles();
    // POP SI (1000_9F54 / 0x19F54)
    SI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_9F55 / 0x19F55)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_9F56_19F56:
    // MOV CL,0x10 (1000_9F56 / 0x19F56)
    CL = 0x10;
    State.IncCycles();
    // MUL CL (1000_9F58 / 0x19F58)
    Cpu.Mul8(CL);
    State.IncCycles();
    // ADD AX,0xfd8 (1000_9F5A / 0x19F5A)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    State.IncCycles();
    // MOV [0x47a2],AX (1000_9F5D / 0x19F5D)
    UInt16[DS, 0x47A2] = AX;
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_9F60 / 0x19F60)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9f82 (1000_9F65 / 0x19F65)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F82_019F82, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:c07c (1000_9F67 / 0x19F67)
    NearCall(cs1, 0x9F6A, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9F6A_019F6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9F6A_019F6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F6A_19F6A:
    // MOV word ptr [0x4784],0x28 (1000_9F6A / 0x19F6A)
    UInt16[DS, 0x4784] = 0x28;
    State.IncCycles();
    // MOV word ptr [0x4786],0x10 (1000_9F70 / 0x19F70)
    UInt16[DS, 0x4786] = 0x10;
    State.IncCycles();
    // MOV word ptr [0x4788],0x10 (1000_9F76 / 0x19F76)
    UInt16[DS, 0x4788] = 0x10;
    State.IncCycles();
    // MOV word ptr [0x478a],0x10 (1000_9F7C / 0x19F7C)
    UInt16[DS, 0x478A] = 0x10;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F82_019F82, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F82_019F82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F82_19F82:
    // MOV word ptr [0xdbe4],0xf0 (1000_9F82 / 0x19F82)
    UInt16[DS, 0xDBE4] = 0xF0;
    State.IncCycles();
    // JMP 0x1000:d068 (1000_9F88 / 0x19F88)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D068_01D068, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F8B_019F8B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F8B_19F8B:
    // PUSH word ptr [0x47c2] (1000_9F8B / 0x19F8B)
    Stack.Push(UInt16[DS, 0x47C2]);
    State.IncCycles();
    // MOV byte ptr [0x47c2],0x20 (1000_9F8F / 0x19F8F)
    UInt8[DS, 0x47C2] = 0x20;
    State.IncCycles();
    // CALL 0x1000:9f9e (1000_9F94 / 0x19F94)
    NearCall(cs1, 0x9F97, spice86_generated_label_call_target_1000_9F9E_019F9E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9F97_019F97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9F97_019F97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F97_19F97:
    // POP word ptr [0x47c2] (1000_9F97 / 0x19F97)
    UInt16[DS, 0x47C2] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_9F9B / 0x19F9B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9F9C_019F9C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F9C_19F9C:
    // STC  (1000_9F9C / 0x19F9C)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_9F9D / 0x19F9D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9F9E_019F9E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9F9E_19F9E:
    // MOV word ptr [0x477c],SI (1000_9F9E / 0x19F9E)
    UInt16[DS, 0x477C] = SI;
    State.IncCycles();
    // CALL 0x1000:94f3 (1000_9FA2 / 0x19FA2)
    NearCall(cs1, 0x9FA5, spice86_generated_label_call_target_1000_94F3_0194F3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FA5_019FA5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9FA5_019FA5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9FA5_19FA5:
    // MOV word ptr [0x47bc],0xa6b0 (1000_9FA5 / 0x19FA5)
    UInt16[DS, 0x47BC] = 0xA6B0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9FAB_019FAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9FAB_019FAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9FAB_19FAB:
    // MOV AX,word ptr [SI] (1000_9FAB / 0x19FAB)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // CMP AX,0xffff (1000_9FAD / 0x19FAD)
    Alu.Sub16(AX, 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:9f9c (1000_9FB0 / 0x19FB0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9F9C_019F9C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST AL,0x80 (1000_9FB2 / 0x19FB2)
    Alu.And8(AL, 0x80);
    State.IncCycles();
    // JZ 0x1000:9fc0 (1000_9FB4 / 0x19FB4)
    if(ZeroFlag) {
      goto label_1000_9FC0_19FC0;
    }
    State.IncCycles();
    // TEST AL,0x40 (1000_9FB6 / 0x19FB6)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JNZ 0x1000:9fc0 (1000_9FB8 / 0x19FB8)
    if(!ZeroFlag) {
      goto label_1000_9FC0_19FC0;
    }
    State.IncCycles();
    // AND AL,byte ptr [0x47c2] (1000_9FBA / 0x19FBA)
    // AL &= UInt8[DS, 0x47C2];
    AL = Alu.And8(AL, UInt8[DS, 0x47C2]);
    State.IncCycles();
    // JNZ 0x1000:9fd3 (1000_9FBE / 0x19FBE)
    if(!ZeroFlag) {
      goto label_1000_9FD3_19FD3;
    }
    State.IncCycles();
    label_1000_9FC0_19FC0:
    // PUSH SI (1000_9FC0 / 0x19FC0)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AL,AH (1000_9FC1 / 0x19FC1)
    AL = AH;
    State.IncCycles();
    // MOV AH,byte ptr [SI + 0x2] (1000_9FC3 / 0x19FC3)
    AH = UInt8[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // ROL AH,1 (1000_9FC6 / 0x19FC6)
    AH = Alu.Rol8(AH, 0x1);
    State.IncCycles();
    // ROL AH,1 (1000_9FC8 / 0x19FC8)
    AH = Alu.Rol8(AH, 0x1);
    State.IncCycles();
    // AND AH,0x3 (1000_9FCA / 0x19FCA)
    // AH &= 0x3;
    AH = Alu.And8(AH, 0x3);
    State.IncCycles();
    // CALL 0x1000:a396 (1000_9FCD / 0x19FCD)
    NearCall(cs1, 0x9FD0, spice86_generated_label_call_target_1000_A396_01A396);
    State.IncCycles();
    label_1000_9FD0_19FD0:
    // POP SI (1000_9FD0 / 0x19FD0)
    SI = Stack.Pop();
    State.IncCycles();
    // JNZ 0x1000:9fd8 (1000_9FD1 / 0x19FD1)
    if(!ZeroFlag) {
      goto label_1000_9FD8_19FD8;
    }
    State.IncCycles();
    label_1000_9FD3_19FD3:
    // ADD SI,0x4 (1000_9FD3 / 0x19FD3)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // JMP 0x1000:9fab (1000_9FD6 / 0x19FD6)
    goto label_1000_9FAB_19FAB;
    State.IncCycles();
    label_1000_9FD8_19FD8:
    // CMP byte ptr [0x46eb],0x0 (1000_9FD8 / 0x19FD8)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9ff7 (1000_9FDD / 0x19FDD)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEF_019FEF, 0x19FF7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_9FDF / 0x19FDF)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AX,0x10 (1000_9FE2 / 0x19FE2)
    Alu.Sub16(AX, 0x10);
    State.IncCycles();
    // JNC 0x1000:9ff7 (1000_9FE5 / 0x19FE5)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEF_019FEF, 0x19FF7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH SI (1000_9FE7 / 0x19FE7)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH AX (1000_9FE8 / 0x19FE8)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:a0f1 (1000_9FE9 / 0x19FE9)
    NearCall(cs1, 0x9FEC, spice86_generated_label_call_target_1000_A0F1_01A0F1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEC_019FEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9FEC_019FEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9FEC_19FEC:
    // CALL 0x1000:1803 (1000_9FEC / 0x19FEC)
    NearCall(cs1, 0x9FEF, spice86_generated_label_call_target_1000_1803_011803);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9FEF_019FEF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9FEF_019FEF(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9FF7: goto label_1000_9FF7_19FF7;break; // Target of external jump from 0x19FE5, 0x19FDD
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9FEF_19FEF:
    // CALL 0x1000:3af9 (1000_9FEF / 0x19FEF)
    NearCall(cs1, 0x9FF2, spice86_generated_label_call_target_1000_3AF9_013AF9);
    State.IncCycles();
    label_1000_9FF2_19FF2:
    // POP AX (1000_9FF2 / 0x19FF2)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:91a0 (1000_9FF3 / 0x19FF3)
    NearCall(cs1, 0x9FF6, spice86_generated_label_call_target_1000_91A0_0191A0);
    State.IncCycles();
    label_1000_9FF6_19FF6:
    // POP SI (1000_9FF6 / 0x19FF6)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_9FF7_19FF7:
    // PUSH SI (1000_9FF7 / 0x19FF7)
    Stack.Push(SI);
    State.IncCycles();
    // LODSW SI (1000_9FF8 / 0x19FF8)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV [0x47de],AX (1000_9FF9 / 0x19FF9)
    UInt16[DS, 0x47DE] = AX;
    State.IncCycles();
    // LODSW SI (1000_9FFC / 0x19FFC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AL,AH (1000_9FFD / 0x19FFD)
    byte tmp_1000_9FFD = AL;
    AL = AH;
    AH = tmp_1000_9FFD;
    State.IncCycles();
    // AND AX,0x3ff (1000_9FFF / 0x19FFF)
    // AX &= 0x3FF;
    AX = Alu.And16(AX, 0x3FF);
    State.IncCycles();
    // OR AX,0x800 (1000_A002 / 0x1A002)
    // AX |= 0x800;
    AX = Alu.Or16(AX, 0x800);
    State.IncCycles();
    // MOV DI,word ptr [0x47bc] (1000_A005 / 0x1A005)
    DI = UInt16[DS, 0x47BC];
    State.IncCycles();
    // CMP DI,0xa6b0 (1000_A009 / 0x1A009)
    Alu.Sub16(DI, 0xA6B0);
    State.IncCycles();
    // JZ 0x1000:a034 (1000_A00D / 0x1A00D)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A026_01A026, 0x1A034 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,AX (1000_A00F / 0x1A00F)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_A011 / 0x1A011)
    NearCall(cs1, 0xA014, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    // CMP byte ptr ES:[SI],0x80 (1000_A014 / 0x1A014)
    Alu.Sub8(UInt8[ES, SI], 0x80);
    State.IncCycles();
    // JC 0x1000:a026 (1000_A018 / 0x1A018)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A026_01A026, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP AX (1000_A01A / 0x1A01A)
    AX = Stack.Pop();
    State.IncCycles();
    // SUB AX,0x4 (1000_A01B / 0x1A01B)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    State.IncCycles();
    // PUSH AX (1000_A01E / 0x1A01E)
    Stack.Push(AX);
    State.IncCycles();
    // MOV byte ptr [DI + -0x1],0xff (1000_A01F / 0x1A01F)
    UInt8[DS, (ushort)(DI - 0x1)] = 0xFF;
    State.IncCycles();
    // JMP 0x1000:a02c (1000_A023 / 0x1A023)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_A026_01A026, 0x1A02C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A026_01A026(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA034: goto label_1000_A034_1A034;break; // Target of external jump from 0x1A00D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_A026_1A026:
    // CALL 0x1000:88f1 (1000_A026 / 0x1A026)
    NearCall(cs1, 0xA029, spice86_generated_label_call_target_1000_88F1_0188F1);
    State.IncCycles();
    // CALL 0x1000:8944 (1000_A029 / 0x1A029)
    NearCall(cs1, 0xA02C, spice86_generated_label_call_target_1000_8944_018944);
    State.IncCycles();
    label_1000_A02C_1A02C:
    // MOV SI,0xa6b0 (1000_A02C / 0x1A02C)
    SI = 0xA6B0;
    State.IncCycles();
    // CALL 0x1000:8b11 (1000_A02F / 0x1A02F)
    NearCall(cs1, 0xA032, spice86_generated_label_call_target_1000_8B11_018B11);
    State.IncCycles();
    // JMP 0x1000:a03e (1000_A032 / 0x1A032)
    goto label_1000_A03E_1A03E;
    State.IncCycles();
    label_1000_A034_1A034:
    // CMP byte ptr [0xc6],0x0 (1000_A034 / 0x1A034)
    Alu.Sub8(UInt8[DS, 0xC6], 0x0);
    State.IncCycles();
    // JNZ 0x1000:a03e (1000_A039 / 0x1A039)
    if(!ZeroFlag) {
      goto label_1000_A03E_1A03E;
    }
    State.IncCycles();
    // CALL 0x1000:88af (1000_A03B / 0x1A03B)
    NearCall(cs1, 0xA03E, spice86_generated_label_call_target_1000_88AF_0188AF);
    State.IncCycles();
    label_1000_A03E_1A03E:
    // POP SI (1000_A03E / 0x1A03E)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A03F_01A03F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A03F_01A03F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A03F_1A03F:
    // CALL 0x1000:c85b (1000_A03F / 0x1A03F)
    NearCall(cs1, 0xA042, spice86_generated_label_call_target_1000_C85B_01C85B);
    State.IncCycles();
    label_1000_A042_1A042:
    // CMP word ptr [0x47b6],0x0 (1000_A042 / 0x1A042)
    Alu.Sub16(UInt16[DS, 0x47B6], 0x0);
    State.IncCycles();
    // JNZ 0x1000:a0aa (1000_A047 / 0x1A047)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A05D_01A05D, 0x1A0AA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_A049 / 0x1A049)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // AND AL,0xf (1000_A04B / 0x1A04B)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // JZ 0x1000:a05e (1000_A04D / 0x1A04D)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A05D_01A05D, 0x1A05E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XOR AH,AH (1000_A04F / 0x1A04F)
    AH = 0;
    State.IncCycles();
    // PUSH SI (1000_A051 / 0x1A051)
    Stack.Push(SI);
    State.IncCycles();
    // DEC AX (1000_A052 / 0x1A052)
    AX--;
    State.IncCycles();
    // SHL AX,1 (1000_A053 / 0x1A053)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BX,0xa107 (1000_A055 / 0x1A055)
    BX = 0xA107;
    State.IncCycles();
    // ADD BX,AX (1000_A058 / 0x1A058)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // CALL word ptr CS:[BX] (1000_A05A / 0x1A05A)
    // Indirect call to word ptr CS:[BX], generating possible targets from emulator records
    uint targetAddress_1000_A05A = (uint)(UInt16[cs1, BX]);
    switch(targetAddress_1000_A05A) {
      case 0xA1E8 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1E8_01A1E8); break;
      case 0xA1D6 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1D6_01A1D6); break;
      case 0xA1D0 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1D0_01A1D0); break;
      case 0xA219 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A219_01A219); break;
      case 0xA172 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A172_01A172); break;
      case 0xA25B : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A25B_01A25B); break;
      case 0xA235 : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A235_01A235); break;
      case 0xA1DC : NearCall(cs1, 0xA05D, spice86_generated_label_call_target_1000_A1DC_01A1DC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A05A));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A05D_01A05D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A05D_01A05D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA0AA: goto label_1000_A0AA_1A0AA;break; // Target of external jump from 0x1A0A5, 0x1A047
      case 0xA05E: goto label_1000_A05E_1A05E;break; // Target of external jump from 0x1A04D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_A05D_1A05D:
    // POP SI (1000_A05D / 0x1A05D)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_A05E_1A05E:
    // MOV AL,byte ptr [SI + 0x2] (1000_A05E / 0x1A05E)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // AND AL,0xc (1000_A061 / 0x1A061)
    // AL &= 0xC;
    AL = Alu.And8(AL, 0xC);
    State.IncCycles();
    // JZ 0x1000:a092 (1000_A063 / 0x1A063)
    if(ZeroFlag) {
      goto label_1000_A092_1A092;
    }
    State.IncCycles();
    // TEST byte ptr [SI],0x80 (1000_A065 / 0x1A065)
    Alu.And8(UInt8[DS, SI], 0x80);
    State.IncCycles();
    // JNZ 0x1000:a092 (1000_A068 / 0x1A068)
    if(!ZeroFlag) {
      goto label_1000_A092_1A092;
    }
    State.IncCycles();
    // MOV AX,SI (1000_A06A / 0x1A06A)
    AX = SI;
    State.IncCycles();
    // SUB AX,0xaa78 (1000_A06C / 0x1A06C)
    AX -= 0xAA78;
    State.IncCycles();
    // SHR AX,1 (1000_A06F / 0x1A06F)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_A071 / 0x1A071)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV BL,byte ptr [0x47c4] (1000_A073 / 0x1A073)
    BL = UInt8[DS, 0x47C4];
    State.IncCycles();
    // SHL BL,1 (1000_A077 / 0x1A077)
    BL <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_A079 / 0x1A079)
    BL <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_A07B / 0x1A07B)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    State.IncCycles();
    // OR AH,BL (1000_A07D / 0x1A07D)
    // AH |= BL;
    AH = Alu.Or8(AH, BL);
    State.IncCycles();
    // MOV BP,word ptr [0x11bd] (1000_A07F / 0x1A07F)
    BP = UInt16[DS, 0x11BD];
    State.IncCycles();
    // MOV word ptr CS:[BP + 0x0],AX (1000_A083 / 0x1A083)
    UInt16[cs1, BP] = AX;
    State.IncCycles();
    // MOV word ptr CS:[BP + 0x2],0x0 (1000_A087 / 0x1A087)
    UInt16[cs1, (ushort)(BP + 0x2)] = 0x0;
    State.IncCycles();
    // ADD word ptr [0x11bd],0x2 (1000_A08D / 0x1A08D)
    // UInt16[DS, 0x11BD] += 0x2;
    UInt16[DS, 0x11BD] = Alu.Add16(UInt16[DS, 0x11BD], 0x2);
    State.IncCycles();
    label_1000_A092_1A092:
    // MOV byte ptr [0x19],0xff (1000_A092 / 0x1A092)
    UInt8[DS, 0x19] = 0xFF;
    State.IncCycles();
    // OR byte ptr [SI],0x80 (1000_A097 / 0x1A097)
    UInt8[DS, SI] |= 0x80;
    State.IncCycles();
    // ADD SI,0x4 (1000_A09A / 0x1A09A)
    SI += 0x4;
    State.IncCycles();
    // XOR AL,AL (1000_A09D / 0x1A09D)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0x47a8],AL (1000_A09F / 0x1A09F)
    byte tmp_1000_A09F = UInt8[DS, 0x47A8];
    UInt8[DS, 0x47A8] = AL;
    AL = tmp_1000_A09F;
    State.IncCycles();
    // OR AL,AL (1000_A0A3 / 0x1A0A3)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:a0aa (1000_A0A5 / 0x1A0A5)
    if(ZeroFlag) {
      goto label_1000_A0AA_1A0AA;
    }
    State.IncCycles();
    // MOV SI,0xffff (1000_A0A7 / 0x1A0A7)
    SI = 0xFFFF;
    State.IncCycles();
    label_1000_A0AA_1A0AA:
    // CMP byte ptr [0x46eb],0x0 (1000_A0AA / 0x1A0AA)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:a0e2 (1000_A0AF / 0x1A0AF)
    if(!ZeroFlag) {
      goto label_1000_A0E2_1A0E2;
    }
    State.IncCycles();
    // CMP word ptr [0x47c4],0x10 (1000_A0B1 / 0x1A0B1)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    State.IncCycles();
    // JNC 0x1000:a0e2 (1000_A0B6 / 0x1A0B6)
    if(!CarryFlag) {
      goto label_1000_A0E2_1A0E2;
    }
    State.IncCycles();
    // PUSH SI (1000_A0B8 / 0x1A0B8)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:978e (1000_A0B9 / 0x1A0B9)
    NearCall(cs1, 0xA0BC, spice86_generated_label_call_target_1000_978E_01978E);
    State.IncCycles();
    label_1000_A0BC_1A0BC:
    // POP SI (1000_A0BC / 0x1A0BC)
    SI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [0x4774],0x0 (1000_A0BD / 0x1A0BD)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JZ 0x1000:a0c9 (1000_A0C2 / 0x1A0C2)
    if(ZeroFlag) {
      goto label_1000_A0C9_1A0C9;
    }
    State.IncCycles();
    // PUSH SI (1000_A0C4 / 0x1A0C4)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:2ebf (1000_A0C5 / 0x1A0C5)
    NearCall(cs1, 0xA0C8, not_observed_1000_2EBF_012EBF);
    State.IncCycles();
    // POP SI (1000_A0C8 / 0x1A0C8)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_A0C9_1A0C9:
    // CMP byte ptr [0xea],0x0 (1000_A0C9 / 0x1A0C9)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    State.IncCycles();
    // JG 0x1000:a0e2 (1000_A0CE / 0x1A0CE)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_A0E2_1A0E2;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_A0D0 / 0x1A0D0)
    NearCall(cs1, 0xA0D3, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_A0D3_1A0D3:
    // CALL 0x1000:9efd (1000_A0D3 / 0x1A0D3)
    NearCall(cs1, 0xA0D6, spice86_generated_label_call_target_1000_9EFD_019EFD);
    State.IncCycles();
    label_1000_A0D6_1A0D6:
    // MOV AX,0xf66 (1000_A0D6 / 0x1A0D6)
    AX = 0xF66;
    State.IncCycles();
    // XCHG word ptr [0x227e],AX (1000_A0D9 / 0x1A0D9)
    ushort tmp_1000_A0D9 = UInt16[DS, 0x227E];
    UInt16[DS, 0x227E] = AX;
    AX = tmp_1000_A0D9;
    State.IncCycles();
    // CALL AX (1000_A0DD / 0x1A0DD)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_A0DD = (uint)(AX);
    switch(targetAddress_1000_A0DD) {
      case 0xF66 : NearCall(cs1, 0xA0DF, spice86_generated_label_call_target_1000_0F66_010F66); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A0DD));
        break;
    }
    State.IncCycles();
    label_1000_A0DF_1A0DF:
    // CALL 0x1000:e283 (1000_A0DF / 0x1A0DF)
    NearCall(cs1, 0xA0E2, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_A0E2_1A0E2:
    // CMP byte ptr [0xfb],0x0 (1000_A0E2 / 0x1A0E2)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    State.IncCycles();
    // JS 0x1000:a0ef (1000_A0E7 / 0x1A0E7)
    if(SignFlag) {
      goto label_1000_A0EF_1A0EF;
    }
    State.IncCycles();
    // MOV AL,[0x28e8] (1000_A0E9 / 0x1A0E9)
    AL = UInt8[DS, 0x28E8];
    State.IncCycles();
    // MOV [0x28e7],AL (1000_A0EC / 0x1A0EC)
    UInt8[DS, 0x28E7] = AL;
    State.IncCycles();
    label_1000_A0EF_1A0EF:
    // CLC  (1000_A0EF / 0x1A0EF)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_A0F0 / 0x1A0F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A0F1_01A0F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A0F1_1A0F1:
    // CMP byte ptr [0x28e7],0x2 (1000_A0F1 / 0x1A0F1)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x2);
    State.IncCycles();
    // JNZ 0x1000:a103 (1000_A0F6 / 0x1A0F6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A103 / 0x1A103)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x2],0x10 (1000_A0F8 / 0x1A0F8)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x2)], 0x10);
    State.IncCycles();
    // JZ 0x1000:a104 (1000_A0FC / 0x1A0FC)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:8c8a (1000_A104 / 0x1A104)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8C8A_018C8A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr [0x28e7],0x1 (1000_A0FE / 0x1A0FE)
    UInt8[DS, 0x28E7] = 0x1;
    State.IncCycles();
    label_1000_A103_1A103:
    // RET  (1000_A103 / 0x1A103)
    return NearRet();
    State.IncCycles();
    label_1000_A104_1A104:
    // JMP 0x1000:8c8a (1000_A104 / 0x1A104)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8C8A_018C8A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A156_01A156(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A156_1A156:
    // RET  (1000_A156 / 0x1A156)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A172_01A172(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A172_1A172:
    // MOV AX,[0x47c4] (1000_A172 / 0x1A172)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AX,0x1 (1000_A175 / 0x1A175)
    Alu.Sub16(AX, 0x1);
    State.IncCycles();
    // JNZ 0x1000:a17e (1000_A178 / 0x1A178)
    if(!ZeroFlag) {
      goto label_1000_A17E_1A17E;
    }
    State.IncCycles();
    // INC byte ptr [0xf5] (1000_A17A / 0x1A17A)
    UInt8[DS, 0xF5]++;
    State.IncCycles();
    label_1000_A17E_1A17E:
    // CMP AX,0x3 (1000_A17E / 0x1A17E)
    Alu.Sub16(AX, 0x3);
    State.IncCycles();
    // JNZ 0x1000:a156 (1000_A181 / 0x1A181)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A156 / 0x1A156)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:24a3 (1000_A183 / 0x1A183)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_24A3_0124A3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1C4_01A1C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A1C4_1A1C4:
    // MOV byte ptr [0x47a5],0xff (1000_A1C4 / 0x1A1C4)
    UInt8[DS, 0x47A5] = 0xFF;
    State.IncCycles();
    // RET  (1000_A1C9 / 0x1A1C9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1D0_01A1D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A1D0_1A1D0:
    // MOV byte ptr [0x47a5],0xff (1000_A1D0 / 0x1A1D0)
    UInt8[DS, 0x47A5] = 0xFF;
    State.IncCycles();
    // RET  (1000_A1D5 / 0x1A1D5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1D6_01A1D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A1D6_1A1D6:
    // MOV byte ptr [0x47a5],0x0 (1000_A1D6 / 0x1A1D6)
    UInt8[DS, 0x47A5] = 0x0;
    State.IncCycles();
    // RET  (1000_A1DB / 0x1A1DB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1DC_01A1DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A1DC_1A1DC:
    // MOV byte ptr [0x47a5],0x80 (1000_A1DC / 0x1A1DC)
    UInt8[DS, 0x47A5] = 0x80;
    State.IncCycles();
    // RET  (1000_A1E1 / 0x1A1E1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1E2_01A1E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A1E2_1A1E2:
    // CMP byte ptr [0x47a5],0xff (1000_A1E2 / 0x1A1E2)
    Alu.Sub8(UInt8[DS, 0x47A5], 0xFF);
    State.IncCycles();
    // RET  (1000_A1E7 / 0x1A1E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A1E8_01A1E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A1E8_1A1E8:
    // INC byte ptr [0x47a8] (1000_A1E8 / 0x1A1E8)
    UInt8[DS, 0x47A8] = Alu.Inc8(UInt8[DS, 0x47A8]);
    State.IncCycles();
    // RET  (1000_A1EC / 0x1A1EC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A219_01A219(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A219_1A219:
    // TEST byte ptr [SI],0x80 (1000_A219 / 0x1A219)
    Alu.And8(UInt8[DS, SI], 0x80);
    State.IncCycles();
    // JNZ 0x1000:a234 (1000_A21C / 0x1A21C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A234 / 0x1A234)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0x2a] (1000_A21E / 0x1A21E)
    UInt8[DS, 0x2A] = Alu.Inc8(UInt8[DS, 0x2A]);
    State.IncCycles();
    // MOV byte ptr [0xff],0x0 (1000_A222 / 0x1A222)
    UInt8[DS, 0xFF] = 0x0;
    State.IncCycles();
    // CALL 0x1000:b17a (1000_A227 / 0x1A227)
    NearCall(cs1, 0xA22A, spice86_generated_label_call_target_1000_B17A_01B17A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A22A_01A22A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A22A_01A22A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A22A_1A22A:
    // CMP byte ptr [0x2a],0x1 (1000_A22A / 0x1A22A)
    Alu.Sub8(UInt8[DS, 0x2A], 0x1);
    State.IncCycles();
    // JNZ 0x1000:a234 (1000_A22F / 0x1A22F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A234 / 0x1A234)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:100b (1000_A231 / 0x1A231)
    NearCall(cs1, 0xA234, spice86_generated_label_call_target_1000_100B_01100B);
    State.IncCycles();
    label_1000_A234_1A234:
    // RET  (1000_A234 / 0x1A234)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A235_01A235(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A235_1A235:
    // TEST byte ptr [SI],0x80 (1000_A235 / 0x1A235)
    Alu.And8(UInt8[DS, SI], 0x80);
    State.IncCycles();
    // JNZ 0x1000:a234 (1000_A238 / 0x1A238)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A234 / 0x1A234)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,[0x2a] (1000_A23A / 0x1A23A)
    AL = UInt8[DS, 0x2A];
    State.IncCycles();
    // AND AL,0xfc (1000_A23D / 0x1A23D)
    AL &= 0xFC;
    State.IncCycles();
    // ADD AL,0x4 (1000_A23F / 0x1A23F)
    // AL += 0x4;
    AL = Alu.Add8(AL, 0x4);
    State.IncCycles();
    // JMP 0x1000:121f (1000_A241 / 0x1A241)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_121F_01121F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A25B_01A25B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A25B_1A25B:
    // PUSH SI (1000_A25B / 0x1A25B)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_A25C / 0x1A25C)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_A25D / 0x1A25D)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV AX,[0x4780] (1000_A25E / 0x1A25E)
    AX = UInt16[DS, 0x4780];
    State.IncCycles();
    // MOV BX,0xa01 (1000_A261 / 0x1A261)
    BX = 0xA01;
    State.IncCycles();
    // MOV DI,0x197c (1000_A264 / 0x1A264)
    DI = 0x197C;
    State.IncCycles();
    label_1000_A267_1A267:
    // ADD DI,0x8 (1000_A267 / 0x1A267)
    DI += 0x8;
    State.IncCycles();
    // SCASW ES:DI (1000_A26A / 0x1A26A)
    Alu.Sub16(AX, UInt16[ES, DI]);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JA 0x1000:a267 (1000_A26B / 0x1A26B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_A267_1A267;
    }
    State.IncCycles();
    // JNZ 0x1000:a28c (1000_A26D / 0x1A26D)
    if(!ZeroFlag) {
      goto label_1000_A28C_1A28C;
    }
    State.IncCycles();
    // CMP word ptr [DI],0x38 (1000_A26F / 0x1A26F)
    Alu.Sub16(UInt16[DS, DI], 0x38);
    State.IncCycles();
    // JNZ 0x1000:a276 (1000_A272 / 0x1A272)
    if(!ZeroFlag) {
      goto label_1000_A276_1A276;
    }
    State.IncCycles();
    // MOV BH,0x10 (1000_A274 / 0x1A274)
    BH = 0x10;
    State.IncCycles();
    label_1000_A276_1A276:
    // MOV AL,[0x47d0] (1000_A276 / 0x1A276)
    AL = UInt8[DS, 0x47D0];
    State.IncCycles();
    // DEC AL (1000_A279 / 0x1A279)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JS 0x1000:a284 (1000_A27B / 0x1A27B)
    if(SignFlag) {
      goto label_1000_A284_1A284;
    }
    State.IncCycles();
    // SHL AL,1 (1000_A27D / 0x1A27D)
    AL <<= 0x1;
    State.IncCycles();
    // INC AX (1000_A27F / 0x1A27F)
    AX++;
    State.IncCycles();
    // SHL AL,1 (1000_A280 / 0x1A280)
    AL <<= 0x1;
    State.IncCycles();
    // ADD BH,AL (1000_A282 / 0x1A282)
    // BH += AL;
    BH = Alu.Add8(BH, AL);
    State.IncCycles();
    label_1000_A284_1A284:
    // MOV word ptr [0x47e1],BX (1000_A284 / 0x1A284)
    UInt16[DS, 0x47E1] = BX;
    State.IncCycles();
    // MOV word ptr [0x47e4],DI (1000_A288 / 0x1A288)
    UInt16[DS, 0x47E4] = DI;
    State.IncCycles();
    label_1000_A28C_1A28C:
    // POP SI (1000_A28C / 0x1A28C)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_A28D / 0x1A28D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A30B_01A30B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A30B_1A30B:
    // LODSB ES:SI (1000_A30B / 0x1A30B)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0x80 (1000_A30D / 0x1A30D)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JNC 0x1000:a32a (1000_A30F / 0x1A30F)
    if(!CarryFlag) {
      goto label_1000_A32A_1A32A;
    }
    State.IncCycles();
    // PUSH BX (1000_A311 / 0x1A311)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BL,byte ptr ES:[SI] (1000_A312 / 0x1A312)
    BL = UInt8[ES, SI];
    State.IncCycles();
    // INC SI (1000_A315 / 0x1A315)
    SI++;
    State.IncCycles();
    // XOR BH,BH (1000_A316 / 0x1A316)
    BH = 0;
    State.IncCycles();
    // CMP AL,0x1 (1000_A318 / 0x1A318)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:a322 (1000_A31A / 0x1A31A)
    if(ZeroFlag) {
      goto label_1000_A322_1A322;
    }
    State.IncCycles();
    // MOV AX,word ptr [BX + 0x0] (1000_A31C / 0x1A31C)
    AX = UInt16[DS, BX];
    State.IncCycles();
    // POP BX (1000_A320 / 0x1A320)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_A321 / 0x1A321)
    return NearRet();
    State.IncCycles();
    label_1000_A322_1A322:
    // MOV AL,byte ptr [BX + 0x0] (1000_A322 / 0x1A322)
    AL = UInt8[DS, BX];
    State.IncCycles();
    // XOR AH,AH (1000_A326 / 0x1A326)
    AH = 0;
    State.IncCycles();
    // POP BX (1000_A328 / 0x1A328)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_A329 / 0x1A329)
    return NearRet();
    State.IncCycles();
    label_1000_A32A_1A32A:
    // JNZ 0x1000:a331 (1000_A32A / 0x1A32A)
    if(!ZeroFlag) {
      goto label_1000_A331_1A331;
    }
    State.IncCycles();
    // LODSB ES:SI (1000_A32C / 0x1A32C)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_A32E / 0x1A32E)
    AH = 0;
    State.IncCycles();
    // RET  (1000_A330 / 0x1A330)
    return NearRet();
    State.IncCycles();
    label_1000_A331_1A331:
    // LODSW ES:SI (1000_A331 / 0x1A331)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // RET  (1000_A333 / 0x1A333)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A334_01A334(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A334_1A334:
    // AND BX,0x1f (1000_A334 / 0x1A334)
    // BX &= 0x1F;
    BX = Alu.And16(BX, 0x1F);
    State.IncCycles();
    // JMP word ptr CS:[BX + 0xa376] (1000_A337 / 0x1A337)
    // Indirect jump to word ptr CS:[BX + 0xa376], generating possible targets from emulator records
    uint targetAddress_1000_A337 = (uint)(UInt16[cs1, (ushort)(BX + 0xA376)]);
    switch(targetAddress_1000_A337) {
      case 0xA348 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A348_01A348, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA345 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A345_01A345, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA342 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A342_01A342, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA356 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A356_01A356, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA34F : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A34F_01A34F, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA33F : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A33F_01A33F, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA35D : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A35D_01A35D, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xA33C : {
        goto label_1000_A33C_1A33C;
        break;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A337));
        break;
    }
    State.IncCycles();
    label_1000_A33C_1A33C:
    // ADD DX,AX (1000_A33C / 0x1A33C)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // RET  (1000_A33E / 0x1A33E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A33F_01A33F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A33F_1A33F:
    // SUB DX,AX (1000_A33F / 0x1A33F)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    State.IncCycles();
    // RET  (1000_A341 / 0x1A341)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A342_01A342(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A342_1A342:
    // AND DX,AX (1000_A342 / 0x1A342)
    // DX &= AX;
    DX = Alu.And16(DX, AX);
    State.IncCycles();
    // RET  (1000_A344 / 0x1A344)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A345_01A345(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A345_1A345:
    // OR DX,AX (1000_A345 / 0x1A345)
    // DX |= AX;
    DX = Alu.Or16(DX, AX);
    State.IncCycles();
    // RET  (1000_A347 / 0x1A347)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A348_01A348(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A348_1A348:
    // CMP DX,AX (1000_A348 / 0x1A348)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JZ 0x1000:a372 (1000_A34A / 0x1A34A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XOR DX,DX (1000_A34C / 0x1A34C)
    DX = 0;
    State.IncCycles();
    // RET  (1000_A34E / 0x1A34E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A34F_01A34F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A34F_1A34F:
    // CMP DX,AX (1000_A34F / 0x1A34F)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JC 0x1000:a372 (1000_A351 / 0x1A351)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XOR DX,DX (1000_A353 / 0x1A353)
    DX = 0;
    State.IncCycles();
    // RET  (1000_A355 / 0x1A355)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A356_01A356(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A356_1A356:
    // CMP DX,AX (1000_A356 / 0x1A356)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JA 0x1000:a372 (1000_A358 / 0x1A358)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XOR DX,DX (1000_A35A / 0x1A35A)
    DX = 0;
    State.IncCycles();
    // RET  (1000_A35C / 0x1A35C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A35D_01A35D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A35D_1A35D:
    // CMP DX,AX (1000_A35D / 0x1A35D)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JNZ 0x1000:a372 (1000_A35F / 0x1A35F)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A372_01A372, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // XOR DX,DX (1000_A361 / 0x1A361)
    DX = 0;
    State.IncCycles();
    // RET  (1000_A363 / 0x1A363)
    return NearRet();
  }
  
  public virtual Action split_1000_A372_01A372(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A372_1A372:
    // MOV DX,0xffff (1000_A372 / 0x1A372)
    DX = 0xFFFF;
    State.IncCycles();
    // RET  (1000_A375 / 0x1A375)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A396_01A396(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A396_1A396:
    // SUB SP,0x32 (1000_A396 / 0x1A396)
    // SP -= 0x32;
    SP = Alu.Sub16(SP, 0x32);
    State.IncCycles();
    // MOV BP,SP (1000_A399 / 0x1A399)
    BP = SP;
    State.IncCycles();
    // SHL AX,1 (1000_A39B / 0x1A39B)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // LES SI,[0xaa72] (1000_A39D / 0x1A39D)
    ES = UInt16[DS, 0xAA74];
    SI = UInt16[DS, 0xAA72];
    State.IncCycles();
    // ADD SI,AX (1000_A3A1 / 0x1A3A1)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV SI,word ptr ES:[SI + -0x2] (1000_A3A3 / 0x1A3A3)
    SI = UInt16[ES, (ushort)(SI - 0x2)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A3A7_01A3A7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A3A7_01A3A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A3A7_1A3A7:
    // CALL 0x1000:a30b (1000_A3A7 / 0x1A3A7)
    NearCall(cs1, 0xA3AA, spice86_generated_label_call_target_1000_A30B_01A30B);
    State.IncCycles();
    label_1000_A3AA_1A3AA:
    // MOV DX,AX (1000_A3AA / 0x1A3AA)
    DX = AX;
    State.IncCycles();
    label_1000_A3AC_1A3AC:
    // LODSB ES:SI (1000_A3AC / 0x1A3AC)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0xff (1000_A3AE / 0x1A3AE)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:a3cb (1000_A3B0 / 0x1A3B0)
    if(ZeroFlag) {
      goto label_1000_A3CB_1A3CB;
    }
    State.IncCycles();
    // TEST AL,0x80 (1000_A3B2 / 0x1A3B2)
    Alu.And8(AL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:a3c0 (1000_A3B4 / 0x1A3B4)
    if(!ZeroFlag) {
      goto label_1000_A3C0_1A3C0;
    }
    State.IncCycles();
    // MOV BL,AL (1000_A3B6 / 0x1A3B6)
    BL = AL;
    State.IncCycles();
    // CALL 0x1000:a30b (1000_A3B8 / 0x1A3B8)
    NearCall(cs1, 0xA3BB, spice86_generated_label_call_target_1000_A30B_01A30B);
    State.IncCycles();
    label_1000_A3BB_1A3BB:
    // CALL 0x1000:a334 (1000_A3BB / 0x1A3BB)
    NearCall(cs1, 0xA3BE, spice86_generated_label_call_target_1000_A334_01A334);
    State.IncCycles();
    label_1000_A3BE_1A3BE:
    // JMP 0x1000:a3ac (1000_A3BE / 0x1A3BE)
    goto label_1000_A3AC_1A3AC;
    State.IncCycles();
    label_1000_A3C0_1A3C0:
    // MOV word ptr [BP + 0x0],DX (1000_A3C0 / 0x1A3C0)
    UInt16[SS, BP] = DX;
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_A3C3 / 0x1A3C3)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // ADD BP,0x4 (1000_A3C6 / 0x1A3C6)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    State.IncCycles();
    // JMP 0x1000:a3a7 (1000_A3C9 / 0x1A3C9)
    goto label_1000_A3A7_1A3A7;
    State.IncCycles();
    label_1000_A3CB_1A3CB:
    // MOV SI,SP (1000_A3CB / 0x1A3CB)
    SI = SP;
    State.IncCycles();
    // CMP SI,BP (1000_A3CD / 0x1A3CD)
    Alu.Sub16(SI, BP);
    State.IncCycles();
    // JZ 0x1000:a3e2 (1000_A3CF / 0x1A3CF)
    if(ZeroFlag) {
      goto label_1000_A3E2_1A3E2;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x0],DX (1000_A3D1 / 0x1A3D1)
    UInt16[SS, BP] = DX;
    State.IncCycles();
    // LODSW SI (1000_A3D4 / 0x1A3D4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_A3D5 / 0x1A3D5)
    DX = AX;
    State.IncCycles();
    label_1000_A3D7_1A3D7:
    // LODSW SI (1000_A3D7 / 0x1A3D7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_A3D8 / 0x1A3D8)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_A3DA / 0x1A3DA)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CALL 0x1000:a334 (1000_A3DB / 0x1A3DB)
    NearCall(cs1, 0xA3DE, spice86_generated_label_call_target_1000_A334_01A334);
    State.IncCycles();
    label_1000_A3DE_1A3DE:
    // CMP SI,BP (1000_A3DE / 0x1A3DE)
    Alu.Sub16(SI, BP);
    State.IncCycles();
    // JC 0x1000:a3d7 (1000_A3E0 / 0x1A3E0)
    if(CarryFlag) {
      goto label_1000_A3D7_1A3D7;
    }
    State.IncCycles();
    label_1000_A3E2_1A3E2:
    // ADD SP,0x32 (1000_A3E2 / 0x1A3E2)
    // SP += 0x32;
    SP = Alu.Add16(SP, 0x32);
    State.IncCycles();
    // OR DX,DX (1000_A3E5 / 0x1A3E5)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // RET  (1000_A3E7 / 0x1A3E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A3F0_01A3F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A3F0_1A3F0:
    // MOV AX,0x1ad6 (1000_A3F0 / 0x1A3F0)
    AX = 0x1AD6;
    State.IncCycles();
    // CALL 0x1000:d95e (1000_A3F3 / 0x1A3F3)
    NearCall(cs1, 0xA3F6, spice86_generated_label_call_target_1000_D95E_01D95E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A3F6_01A3F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A3F6_01A3F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A3F6_1A3F6:
    // CALL 0x1000:d2bd (1000_A3F6 / 0x1A3F6)
    NearCall(cs1, 0xA3F9, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A3F9_01A3F9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A3F9_01A3F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A3F9_1A3F9:
    // PUSH word ptr [0xdbda] (1000_A3F9 / 0x1A3F9)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_A3FD / 0x1A3FD)
    NearCall(cs1, 0xA400, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    label_1000_A400_1A400:
    // MOV AX,0x55 (1000_A400 / 0x1A400)
    AX = 0x55;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_A403 / 0x1A403)
    NearCall(cs1, 0xA406, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_A406_1A406:
    // XOR AX,AX (1000_A406 / 0x1A406)
    AX = 0;
    State.IncCycles();
    // MOV DX,word ptr [0x2886] (1000_A408 / 0x1A408)
    DX = UInt16[DS, 0x2886];
    State.IncCycles();
    // MOV BX,word ptr [0x2888] (1000_A40C / 0x1A40C)
    BX = UInt16[DS, 0x2888];
    State.IncCycles();
    // CALL 0x1000:c22f (1000_A410 / 0x1A410)
    NearCall(cs1, 0xA413, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_A413_1A413:
    // POP word ptr [0xdbda] (1000_A413 / 0x1A413)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:a4c6 (1000_A417 / 0x1A417)
    NearCall(cs1, 0xA41A, spice86_generated_label_call_target_1000_A4C6_01A4C6);
    State.IncCycles();
    label_1000_A41A_1A41A:
    // CALL 0x1000:a47d (1000_A41A / 0x1A41A)
    NearCall(cs1, 0xA41D, spice86_generated_label_call_target_1000_A47D_01A47D);
    State.IncCycles();
    label_1000_A41D_1A41D:
    // CALL 0x1000:a42c (1000_A41D / 0x1A41D)
    NearCall(cs1, 0xA420, spice86_generated_label_call_target_1000_A42C_01A42C);
    State.IncCycles();
    label_1000_A420_1A420:
    // CALL 0x1000:a44c (1000_A420 / 0x1A420)
    NearCall(cs1, 0xA423, spice86_generated_label_call_target_1000_A44C_01A44C);
    State.IncCycles();
    label_1000_A423_1A423:
    // CALL 0x1000:ac3a (1000_A423 / 0x1A423)
    NearCall(cs1, 0xA426, spice86_generated_label_call_target_1000_AC3A_01AC3A);
    State.IncCycles();
    label_1000_A426_1A426:
    // MOV BX,0xa541 (1000_A426 / 0x1A426)
    BX = 0xA541;
    State.IncCycles();
    // JMP 0x1000:d32f (1000_A429 / 0x1A429)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D32F_01D32F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A42C_01A42C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A42C_1A42C:
    // MOV AX,0x55 (1000_A42C / 0x1A42C)
    AX = 0x55;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_A42F / 0x1A42F)
    NearCall(cs1, 0xA432, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A432_01A432, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A432_01A432(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA435: goto label_1000_A435_1A435;break; // Target of external jump from 0x1A451
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_A432_1A432:
    // MOV AL,[0xceeb] (1000_A432 / 0x1A432)
    AL = UInt8[DS, 0xCEEB];
    State.IncCycles();
    label_1000_A435_1A435:
    // PUSH word ptr [0xdbda] (1000_A435 / 0x1A435)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_A439 / 0x1A439)
    NearCall(cs1, 0xA43C, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A43C_01A43C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A43C_01A43C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A43C_1A43C:
    // CBW  (1000_A43C / 0x1A43C)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // CALL 0x1000:a465 (1000_A43D / 0x1A43D)
    NearCall(cs1, 0xA440, spice86_generated_label_call_target_1000_A465_01A465);
    State.IncCycles();
    label_1000_A440_1A440:
    // SHL AX,1 (1000_A440 / 0x1A440)
    AX <<= 0x1;
    State.IncCycles();
    // ADD AL,0x1c (1000_A442 / 0x1A442)
    // AL += 0x1C;
    AL = Alu.Add8(AL, 0x1C);
    State.IncCycles();
    // CALL 0x1000:c22f (1000_A444 / 0x1A444)
    NearCall(cs1, 0xA447, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_A447_1A447:
    // POP word ptr [0xdbda] (1000_A447 / 0x1A447)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_A44B / 0x1A44B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A44C_01A44C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A44C_1A44C:
    // MOV AL,[0x28e7] (1000_A44C / 0x1A44C)
    AL = UInt8[DS, 0x28E7];
    State.IncCycles();
    // ADD AL,0x8 (1000_A44F / 0x1A44F)
    // AL += 0x8;
    AL = Alu.Add8(AL, 0x8);
    State.IncCycles();
    // JMP 0x1000:a435 (1000_A451 / 0x1A451)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A432_01A432, 0x1A435 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A453_01A453(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A453_1A453:
    // SUB DX,word ptr [0x2886] (1000_A453 / 0x1A453)
    DX -= UInt16[DS, 0x2886];
    State.IncCycles();
    // SUB BX,word ptr [0x2888] (1000_A457 / 0x1A457)
    // BX -= UInt16[DS, 0x2888];
    BX = Alu.Sub16(BX, UInt16[DS, 0x2888]);
    State.IncCycles();
    // RET  (1000_A45B / 0x1A45B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A45C_01A45C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A45C_1A45C:
    // ADD DX,word ptr [0x2886] (1000_A45C / 0x1A45C)
    DX += UInt16[DS, 0x2886];
    State.IncCycles();
    // ADD BX,word ptr [0x2888] (1000_A460 / 0x1A460)
    // BX += UInt16[DS, 0x2888];
    BX = Alu.Add16(BX, UInt16[DS, 0x2888]);
    State.IncCycles();
    // RET  (1000_A464 / 0x1A464)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A465_01A465(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A465_1A465:
    // PUSH AX (1000_A465 / 0x1A465)
    Stack.Push(AX);
    State.IncCycles();
    // MOV DX,word ptr [0x28c7] (1000_A466 / 0x1A466)
    DX = UInt16[DS, 0x28C7];
    State.IncCycles();
    // MOV BX,0x28dc (1000_A46A / 0x1A46A)
    BX = 0x28DC;
    State.IncCycles();
    // XLAT BX (1000_A46D / 0x1A46D)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // MOV BL,0x7 (1000_A46E / 0x1A46E)
    BL = 0x7;
    State.IncCycles();
    // MUL BL (1000_A470 / 0x1A470)
    Cpu.Mul8(BL);
    State.IncCycles();
    // MOV BX,AX (1000_A472 / 0x1A472)
    BX = AX;
    State.IncCycles();
    // ADD BX,word ptr [0x28c9] (1000_A474 / 0x1A474)
    // BX += UInt16[DS, 0x28C9];
    BX = Alu.Add16(BX, UInt16[DS, 0x28C9]);
    State.IncCycles();
    // CALL 0x1000:a45c (1000_A478 / 0x1A478)
    NearCall(cs1, 0xA47B, spice86_generated_label_call_target_1000_A45C_01A45C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A47B_01A47B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A47B_01A47B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A47B_1A47B:
    // POP AX (1000_A47B / 0x1A47B)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_A47C / 0x1A47C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A47D_01A47D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A47D_1A47D:
    // TEST word ptr [0xdbc8],0x8 (1000_A47D / 0x1A47D)
    Alu.And16(UInt16[DS, 0xDBC8], 0x8);
    State.IncCycles();
    // JZ 0x1000:a48b (1000_A483 / 0x1A483)
    if(ZeroFlag) {
      goto label_1000_A48B_1A48B;
    }
    State.IncCycles();
    // MOV SI,0x28a6 (1000_A485 / 0x1A485)
    SI = 0x28A6;
    State.IncCycles();
    // CALL 0x1000:a49c (1000_A488 / 0x1A488)
    NearCall(cs1, 0xA48B, not_observed_1000_A49C_01A49C);
    State.IncCycles();
    label_1000_A48B_1A48B:
    // TEST word ptr [0xdbc8],0x800 (1000_A48B / 0x1A48B)
    Alu.And16(UInt16[DS, 0xDBC8], 0x800);
    State.IncCycles();
    // JZ 0x1000:a4c5 (1000_A491 / 0x1A491)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A4C5 / 0x1A4C5)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x28ae (1000_A493 / 0x1A493)
    SI = 0x28AE;
    State.IncCycles();
    // CALL 0x1000:a49c (1000_A496 / 0x1A496)
    NearCall(cs1, 0xA499, not_observed_1000_A49C_01A49C);
    State.IncCycles();
    // MOV SI,0x28b6 (1000_A499 / 0x1A499)
    SI = 0x28B6;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_A49C_01A49C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A49C_01A49C(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA4C5: goto label_1000_A4C5_1A4C5;break; // Target of external jump from 0x1A491
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_A49C_1A49C:
    // PUSH word ptr [0xdbda] (1000_A49C / 0x1A49C)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_A4A0 / 0x1A4A0)
    NearCall(cs1, 0xA4A3, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // MOV AX,0x55 (1000_A4A3 / 0x1A4A3)
    AX = 0x55;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_A4A6 / 0x1A4A6)
    NearCall(cs1, 0xA4A9, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // LODSB SI (1000_A4A9 / 0x1A4A9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // AAM 0xa (1000_A4AA / 0x1A4AA)
    Cpu.Aam(0xA);
    State.IncCycles();
    // MOV AL,AH (1000_A4AC / 0x1A4AC)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_A4AE / 0x1A4AE)
    AH = 0;
    State.IncCycles();
    // ADD AL,0x3 (1000_A4B0 / 0x1A4B0)
    // AL += 0x3;
    AL = Alu.Add8(AL, 0x3);
    State.IncCycles();
    // MOV byte ptr [SI],0x1 (1000_A4B2 / 0x1A4B2)
    UInt8[DS, SI] = 0x1;
    State.IncCycles();
    // INC SI (1000_A4B5 / 0x1A4B5)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_A4B6 / 0x1A4B6)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_A4B8 / 0x1A4B8)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // CALL 0x1000:a45c (1000_A4BB / 0x1A4BB)
    NearCall(cs1, 0xA4BE, spice86_generated_label_call_target_1000_A45C_01A45C);
    State.IncCycles();
    // CALL 0x1000:c22f (1000_A4BE / 0x1A4BE)
    NearCall(cs1, 0xA4C1, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_A4C1 / 0x1A4C1)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    label_1000_A4C5_1A4C5:
    // RET  (1000_A4C5 / 0x1A4C5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A4C6_01A4C6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A4C6_1A4C6:
    // CALL 0x1000:ae2f (1000_A4C6 / 0x1A4C6)
    NearCall(cs1, 0xA4C9, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_A4C9_1A4C9:
    // JZ 0x1000:a4de (1000_A4C9 / 0x1A4C9)
    if(ZeroFlag) {
      goto label_1000_A4DE_1A4DE;
    }
    State.IncCycles();
    // MOV SI,0x288e (1000_A4CB / 0x1A4CB)
    SI = 0x288E;
    State.IncCycles();
    // CALL 0x1000:a502 (1000_A4CE / 0x1A4CE)
    NearCall(cs1, 0xA4D1, spice86_generated_label_call_target_1000_A502_01A502);
    State.IncCycles();
    // TEST word ptr [0xdbc8],0x4 (1000_A4D1 / 0x1A4D1)
    Alu.And16(UInt16[DS, 0xDBC8], 0x4);
    State.IncCycles();
    // JNZ 0x1000:a4de (1000_A4D7 / 0x1A4D7)
    if(!ZeroFlag) {
      goto label_1000_A4DE_1A4DE;
    }
    State.IncCycles();
    // MOV byte ptr [0x288f],0x0 (1000_A4D9 / 0x1A4D9)
    UInt8[DS, 0x288F] = 0x0;
    State.IncCycles();
    label_1000_A4DE_1A4DE:
    // CALL 0x1000:ae28 (1000_A4DE / 0x1A4DE)
    NearCall(cs1, 0xA4E1, spice86_generated_label_call_target_1000_AE28_01AE28);
    State.IncCycles();
    label_1000_A4E1_1A4E1:
    // JZ 0x1000:a540 (1000_A4E1 / 0x1A4E1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A540 / 0x1A540)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x2896 (1000_A4E3 / 0x1A4E3)
    SI = 0x2896;
    State.IncCycles();
    // CALL 0x1000:a502 (1000_A4E6 / 0x1A4E6)
    NearCall(cs1, 0xA4E9, spice86_generated_label_call_target_1000_A502_01A502);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A4E9_01A4E9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A4E9_01A4E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A4E9_1A4E9:
    // MOV SI,0x289e (1000_A4E9 / 0x1A4E9)
    SI = 0x289E;
    State.IncCycles();
    // CALL 0x1000:a502 (1000_A4EC / 0x1A4EC)
    NearCall(cs1, 0xA4EF, spice86_generated_label_call_target_1000_A502_01A502);
    State.IncCycles();
    label_1000_A4EF_1A4EF:
    // TEST word ptr [0xdbc8],0x400 (1000_A4EF / 0x1A4EF)
    Alu.And16(UInt16[DS, 0xDBC8], 0x400);
    State.IncCycles();
    // JNZ 0x1000:a540 (1000_A4F5 / 0x1A4F5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A540 / 0x1A540)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x2897],0x0 (1000_A4F7 / 0x1A4F7)
    UInt8[DS, 0x2897] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x289f],0x0 (1000_A4FC / 0x1A4FC)
    UInt8[DS, 0x289F] = 0x0;
    State.IncCycles();
    // RET  (1000_A501 / 0x1A501)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A502_01A502(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A502_1A502:
    // PUSH word ptr [0xdbda] (1000_A502 / 0x1A502)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_A506 / 0x1A506)
    NearCall(cs1, 0xA509, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A509_01A509, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A509_01A509(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A509_1A509:
    // PUSH SI (1000_A509 / 0x1A509)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AX,0x55 (1000_A50A / 0x1A50A)
    AX = 0x55;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_A50D / 0x1A50D)
    NearCall(cs1, 0xA510, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_A510_1A510:
    // MOV DX,word ptr [SI + 0x2] (1000_A510 / 0x1A510)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BX,0x22 (1000_A513 / 0x1A513)
    BX = 0x22;
    State.IncCycles();
    // CALL 0x1000:a45c (1000_A516 / 0x1A516)
    NearCall(cs1, 0xA519, spice86_generated_label_call_target_1000_A45C_01A45C);
    State.IncCycles();
    label_1000_A519_1A519:
    // MOV AX,0x1 (1000_A519 / 0x1A519)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_A51C / 0x1A51C)
    NearCall(cs1, 0xA51F, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    State.IncCycles();
    label_1000_A51F_1A51F:
    // POP SI (1000_A51F / 0x1A51F)
    SI = Stack.Pop();
    State.IncCycles();
    // LODSB SI (1000_A520 / 0x1A520)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV byte ptr [SI],0x1 (1000_A521 / 0x1A521)
    UInt8[DS, SI] = 0x1;
    State.IncCycles();
    // NOT AX (1000_A524 / 0x1A524)
    AX = (ushort)~AX;
    State.IncCycles();
    // SHR AL,1 (1000_A526 / 0x1A526)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_A528 / 0x1A528)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // CBW  (1000_A52A / 0x1A52A)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD AX,BX (1000_A52B / 0x1A52B)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    State.IncCycles();
    // MOV BX,AX (1000_A52D / 0x1A52D)
    BX = AX;
    State.IncCycles();
    // SUB AX,word ptr [0x2888] (1000_A52F / 0x1A52F)
    // AX -= UInt16[DS, 0x2888];
    AX = Alu.Sub16(AX, UInt16[DS, 0x2888]);
    State.IncCycles();
    // MOV word ptr [SI + 0x3],AX (1000_A533 / 0x1A533)
    UInt16[DS, (ushort)(SI + 0x3)] = AX;
    State.IncCycles();
    // MOV AX,0x2 (1000_A536 / 0x1A536)
    AX = 0x2;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_A539 / 0x1A539)
    NearCall(cs1, 0xA53C, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_A53C_1A53C:
    // POP word ptr [0xdbda] (1000_A53C / 0x1A53C)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    label_1000_A540_1A540:
    // RET  (1000_A540 / 0x1A540)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A541_01A541(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A541_1A541:
    // MOV AL,[0x28e7] (1000_A541 / 0x1A541)
    AL = UInt8[DS, 0x28E7];
    State.IncCycles();
    // MOV [0x28e8],AL (1000_A544 / 0x1A544)
    UInt8[DS, 0x28E8] = AL;
    State.IncCycles();
    // CALL 0x1000:daa3 (1000_A547 / 0x1A547)
    NearCall(cs1, 0xA54A, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A54A_01A54A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A54A_01A54A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A54A_1A54A:
    // CALL 0x1000:d95b (1000_A54A / 0x1A54A)
    NearCall(cs1, 0xA54D, spice86_generated_label_call_target_1000_D95B_01D95B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A54D_01A54D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A54D_01A54D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A54D_1A54D:
    // MOV SI,0x2886 (1000_A54D / 0x1A54D)
    SI = 0x2886;
    State.IncCycles();
    // JMP 0x1000:c4f0 (1000_A550 / 0x1A550)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A553_01A553(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A553_1A553:
    // CALL 0x1000:ae2f (1000_A553 / 0x1A553)
    NearCall(cs1, 0xA556, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    // JZ 0x1000:a540 (1000_A556 / 0x1A556)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A540 / 0x1A540)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x4 (1000_A558 / 0x1A558)
    AX = 0x4;
    State.IncCycles();
    // MOV BX,0x5 (1000_A55B / 0x1A55B)
    BX = 0x5;
    State.IncCycles();
    // CALL 0x1000:a8bc (1000_A55E / 0x1A55E)
    NearCall(cs1, 0xA561, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    State.IncCycles();
    // CALL 0x1000:a83f (1000_A561 / 0x1A561)
    NearCall(cs1, 0xA564, spice86_generated_label_call_target_1000_A83F_01A83F);
    State.IncCycles();
    // CALL 0x1000:ade0 (1000_A564 / 0x1A564)
    NearCall(cs1, 0xA567, spice86_generated_label_call_target_1000_ADE0_01ADE0);
    State.IncCycles();
    // MOV byte ptr [0xdc2b],0x1 (1000_A567 / 0x1A567)
    UInt8[DS, 0xDC2B] = 0x1;
    State.IncCycles();
    // MOV SI,0x3811 (1000_A56C / 0x1A56C)
    SI = 0x3811;
    State.IncCycles();
    // CALLF [0x3991] (1000_A56F / 0x1A56F)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_A56F = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_A56F) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A56F));
        break;
    }
    State.IncCycles();
    // JMP 0x1000:aba9 (1000_A573 / 0x1A573)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ABA9_01ABA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A576_01A576(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A576_1A576:
    // MOV DI,0x2886 (1000_A576 / 0x1A576)
    DI = 0x2886;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_A579 / 0x1A579)
    NearCall(cs1, 0xA57C, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_A57C_1A57C:
    // JC 0x1000:a581 (1000_A57C / 0x1A57C)
    if(CarryFlag) {
      goto label_1000_A581_1A581;
    }
    State.IncCycles();
    // JMP 0x1000:d2e2 (1000_A57E / 0x1A57E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_A581_1A581:
    // CALL 0x1000:a453 (1000_A581 / 0x1A581)
    NearCall(cs1, 0xA584, spice86_generated_label_call_target_1000_A453_01A453);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A584_01A584, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A584_01A584(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A584_1A584:
    // MOV DI,0x28bf (1000_A584 / 0x1A584)
    DI = 0x28BF;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_A587 / 0x1A587)
    NearCall(cs1, 0xA58A, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_A58A_1A58A:
    // JC 0x1000:a553 (1000_A58A / 0x1A58A)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_A553_01A553, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DI,0x28c7 (1000_A58C / 0x1A58C)
    DI = 0x28C7;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_A58F / 0x1A58F)
    NearCall(cs1, 0xA592, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_A592_1A592:
    // JC 0x1000:a5b0 (1000_A592 / 0x1A592)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A5B0_01A5B0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:a672 (1000_A594 / 0x1A594)
    NearCall(cs1, 0xA597, not_observed_1000_A672_01A672);
    State.IncCycles();
    // JNC 0x1000:a59f (1000_A597 / 0x1A597)
    if(!CarryFlag) {
      goto label_1000_A59F_1A59F;
    }
    State.IncCycles();
    // MOV byte ptr [0x28be],0x1 (1000_A599 / 0x1A599)
    UInt8[DS, 0x28BE] = 0x1;
    State.IncCycles();
    // RET  (1000_A59E / 0x1A59E)
    return NearRet();
    State.IncCycles();
    label_1000_A59F_1A59F:
    // CALL 0x1000:a69f (1000_A59F / 0x1A59F)
    NearCall(cs1, 0xA5A2, not_observed_1000_A69F_01A69F);
    State.IncCycles();
    // JNC 0x1000:a5aa (1000_A5A2 / 0x1A5A2)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A5AA_01A5AA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr [0x28be],0x2 (1000_A5A4 / 0x1A5A4)
    UInt8[DS, 0x28BE] = 0x2;
    State.IncCycles();
    // RET  (1000_A5A9 / 0x1A5A9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A5AA_01A5AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A5AA_1A5AA:
    // MOV byte ptr [0x28be],0x0 (1000_A5AA / 0x1A5AA)
    UInt8[DS, 0x28BE] = 0x0;
    State.IncCycles();
    // RET  (1000_A5AF / 0x1A5AF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_A5B0_01A5B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A5B0_1A5B0:
    // SUB BX,word ptr [DI + 0x2] (1000_A5B0 / 0x1A5B0)
    // BX -= UInt16[DS, (ushort)(DI + 0x2)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // MOV AX,BX (1000_A5B3 / 0x1A5B3)
    AX = BX;
    State.IncCycles();
    // MOV BL,0x7 (1000_A5B5 / 0x1A5B5)
    BL = 0x7;
    State.IncCycles();
    // DIV BL (1000_A5B7 / 0x1A5B7)
    Cpu.Div8(BL);
    State.IncCycles();
    // MOV BX,0x28cf (1000_A5B9 / 0x1A5B9)
    BX = 0x28CF;
    State.IncCycles();
    // XLAT BX (1000_A5BC / 0x1A5BC)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // CMP AL,0x7 (1000_A5BD / 0x1A5BD)
    Alu.Sub8(AL, 0x7);
    State.IncCycles();
    // JC 0x1000:a5ca (1000_A5BF / 0x1A5BF)
    if(CarryFlag) {
      goto label_1000_A5CA_1A5CA;
    }
    State.IncCycles();
    // JZ 0x1000:a5de (1000_A5C1 / 0x1A5C1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A5DE / 0x1A5DE)
      return NearRet();
    }
    State.IncCycles();
    // SUB AL,0x8 (1000_A5C3 / 0x1A5C3)
    // AL -= 0x8;
    AL = Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // MOV [0x28e7],AL (1000_A5C5 / 0x1A5C5)
    UInt8[DS, 0x28E7] = AL;
    State.IncCycles();
    // JMP 0x1000:a5db (1000_A5C8 / 0x1A5C8)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x1000:a3f9 (1000_A5DB / 0x1A5DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A3F9_01A3F9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_A5CA_1A5CA:
    // CMP AL,byte ptr [0xceeb] (1000_A5CA / 0x1A5CA)
    Alu.Sub8(AL, UInt8[DS, 0xCEEB]);
    State.IncCycles();
    // JZ 0x1000:a5de (1000_A5CE / 0x1A5CE)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A5DE / 0x1A5DE)
      return NearRet();
    }
    State.IncCycles();
    // AND byte ptr [0x28e7],0xfd (1000_A5D0 / 0x1A5D0)
    // UInt8[DS, 0x28E7] &= 0xFD;
    UInt8[DS, 0x28E7] = Alu.And8(UInt8[DS, 0x28E7], 0xFD);
    State.IncCycles();
    // MOV [0xceeb],AL (1000_A5D5 / 0x1A5D5)
    UInt8[DS, 0xCEEB] = AL;
    State.IncCycles();
    // CALL 0x1000:cfe4 (1000_A5D8 / 0x1A5D8)
    NearCall(cs1, 0xA5DB, spice86_generated_label_call_target_1000_CFE4_01CFE4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A5DB_01A5DB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A5DB_01A5DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A5DB_1A5DB:
    // JMP 0x1000:a3f9 (1000_A5DB / 0x1A5DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A3F9_01A3F9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A5DE_01A5DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A5DE_1A5DE:
    // RET  (1000_A5DE / 0x1A5DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A637_01A637(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A637_1A637:
    // TEST word ptr [0xdbc8],0x4 (1000_A637 / 0x1A637)
    Alu.And16(UInt16[DS, 0xDBC8], 0x4);
    State.IncCycles();
    // JNZ 0x1000:a644 (1000_A63D / 0x1A63D)
    if(!ZeroFlag) {
      goto label_1000_A644_1A644;
    }
    State.IncCycles();
    // MOV byte ptr [0x288e],0xff (1000_A63F / 0x1A63F)
    UInt8[DS, 0x288E] = 0xFF;
    State.IncCycles();
    label_1000_A644_1A644:
    // MOV AL,[0x288e] (1000_A644 / 0x1A644)
    AL = UInt8[DS, 0x288E];
    State.IncCycles();
    // MOV AH,byte ptr [0x28a6] (1000_A647 / 0x1A647)
    AH = UInt8[DS, 0x28A6];
    State.IncCycles();
    // CALLF [0x39a5] (1000_A64B / 0x1A64B)
    // Indirect call to [0x39a5], generating possible targets from emulator records
    uint targetAddress_1000_A64B = (uint)(UInt16[DS, 0x39A7] * 0x10 + UInt16[DS, 0x39A5] - cs1 * 0x10);
    switch(targetAddress_1000_A64B) {
      case 0x46465 : FarCall(cs1, 0xA64F, spice86_generated_label_call_target_5635_0115_056465); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A64B));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A64F_01A64F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A64F_01A64F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A64F_1A64F:
    // RET  (1000_A64F / 0x1A64F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A650_01A650(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A650_1A650:
    // TEST word ptr [0xdbc8],0x400 (1000_A650 / 0x1A650)
    Alu.And16(UInt16[DS, 0xDBC8], 0x400);
    State.IncCycles();
    // JNZ 0x1000:a660 (1000_A656 / 0x1A656)
    if(!ZeroFlag) {
      goto label_1000_A660_1A660;
    }
    State.IncCycles();
    // MOV AL,0xff (1000_A658 / 0x1A658)
    AL = 0xFF;
    State.IncCycles();
    // MOV [0x2896],AL (1000_A65A / 0x1A65A)
    UInt8[DS, 0x2896] = AL;
    State.IncCycles();
    // MOV [0x289e],AL (1000_A65D / 0x1A65D)
    UInt8[DS, 0x289E] = AL;
    State.IncCycles();
    label_1000_A660_1A660:
    // MOV AH,byte ptr [0x28ae] (1000_A660 / 0x1A660)
    AH = UInt8[DS, 0x28AE];
    State.IncCycles();
    // MOV AL,[0x2896] (1000_A664 / 0x1A664)
    AL = UInt8[DS, 0x2896];
    State.IncCycles();
    // CMP AL,0x4 (1000_A667 / 0x1A667)
    Alu.Sub8(AL, 0x4);
    State.IncCycles();
    // JNC 0x1000:a66d (1000_A669 / 0x1A669)
    if(!CarryFlag) {
      goto label_1000_A66D_1A66D;
    }
    State.IncCycles();
    // MOV AL,0x4 (1000_A66B / 0x1A66B)
    AL = 0x4;
    State.IncCycles();
    label_1000_A66D_1A66D:
    // CALLF [0x3985] (1000_A66D / 0x1A66D)
    // Indirect call to [0x3985], generating possible targets from emulator records
    uint targetAddress_1000_A66D = (uint)(UInt16[DS, 0x3987] * 0x10 + UInt16[DS, 0x3985] - cs1 * 0x10);
    switch(targetAddress_1000_A66D) {
      case 0x464F2 : FarCall(cs1, 0xA671, spice86_generated_label_call_target_563E_0112_0564F2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A66D));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A671_01A671, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_A671_01A671(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A671_1A671:
    // RET  (1000_A671 / 0x1A671)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_A672_01A672(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A672_1A672:
    // MOV SI,0x288e (1000_A672 / 0x1A672)
    SI = 0x288E;
    State.IncCycles();
    // CALL 0x1000:a685 (1000_A675 / 0x1A675)
    NearCall(cs1, 0xA678, not_observed_1000_A685_01A685);
    State.IncCycles();
    // JC 0x1000:a69e (1000_A678 / 0x1A678)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x2896 (1000_A67A / 0x1A67A)
    SI = 0x2896;
    State.IncCycles();
    // CALL 0x1000:a685 (1000_A67D / 0x1A67D)
    NearCall(cs1, 0xA680, not_observed_1000_A685_01A685);
    State.IncCycles();
    // JC 0x1000:a69e (1000_A680 / 0x1A680)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x289e (1000_A682 / 0x1A682)
    SI = 0x289E;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_A685_01A685, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A685_01A685(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A685_1A685:
    // CMP byte ptr [SI + 0x1],0x1 (1000_A685 / 0x1A685)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1)], 0x1);
    State.IncCycles();
    // CMC  (1000_A689 / 0x1A689)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JNC 0x1000:a69e (1000_A68A / 0x1A68A)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,DX (1000_A68C / 0x1A68C)
    AX = DX;
    State.IncCycles();
    // SUB AX,word ptr [SI + 0x2] (1000_A68E / 0x1A68E)
    // AX -= UInt16[DS, (ushort)(SI + 0x2)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // MOV BP,BX (1000_A691 / 0x1A691)
    BP = BX;
    State.IncCycles();
    // SUB BP,word ptr [SI + 0x4] (1000_A693 / 0x1A693)
    BP -= UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP AX,0x16 (1000_A696 / 0x1A696)
    Alu.Sub16(AX, 0x16);
    State.IncCycles();
    // JNC 0x1000:a69e (1000_A699 / 0x1A699)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    State.IncCycles();
    // CMP BP,0x5 (1000_A69B / 0x1A69B)
    Alu.Sub16(BP, 0x5);
    State.IncCycles();
    label_1000_A69E_1A69E:
    // RET  (1000_A69E / 0x1A69E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_A69F_01A69F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A69F_1A69F:
    // MOV SI,0x28a6 (1000_A69F / 0x1A69F)
    SI = 0x28A6;
    State.IncCycles();
    // CALL 0x1000:a6b2 (1000_A6A2 / 0x1A6A2)
    NearCall(cs1, 0xA6A5, not_observed_1000_A6B2_01A6B2);
    State.IncCycles();
    // JC 0x1000:a6cb (1000_A6A5 / 0x1A6A5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x28ae (1000_A6A7 / 0x1A6A7)
    SI = 0x28AE;
    State.IncCycles();
    // CALL 0x1000:a6b2 (1000_A6AA / 0x1A6AA)
    NearCall(cs1, 0xA6AD, not_observed_1000_A6B2_01A6B2);
    State.IncCycles();
    // JC 0x1000:a6cb (1000_A6AD / 0x1A6AD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x28b6 (1000_A6AF / 0x1A6AF)
    SI = 0x28B6;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_A6B2_01A6B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_A6B2_01A6B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A6B2_1A6B2:
    // CMP byte ptr [SI + 0x1],0x1 (1000_A6B2 / 0x1A6B2)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1)], 0x1);
    State.IncCycles();
    // CMC  (1000_A6B6 / 0x1A6B6)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JNC 0x1000:a6cb (1000_A6B7 / 0x1A6B7)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,DX (1000_A6B9 / 0x1A6B9)
    AX = DX;
    State.IncCycles();
    // SUB AX,word ptr [SI + 0x2] (1000_A6BB / 0x1A6BB)
    // AX -= UInt16[DS, (ushort)(SI + 0x2)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // MOV BP,BX (1000_A6BE / 0x1A6BE)
    BP = BX;
    State.IncCycles();
    // SUB BP,word ptr [SI + 0x4] (1000_A6C0 / 0x1A6C0)
    BP -= UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP AX,0xd (1000_A6C3 / 0x1A6C3)
    Alu.Sub16(AX, 0xD);
    State.IncCycles();
    // JNC 0x1000:a6cb (1000_A6C6 / 0x1A6C6)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    State.IncCycles();
    // CMP BP,0xb (1000_A6C8 / 0x1A6C8)
    Alu.Sub16(BP, 0xB);
    State.IncCycles();
    label_1000_A6CB_1A6CB:
    // RET  (1000_A6CB / 0x1A6CB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_A6CC_01A6CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_A6CC_1A6CC:
    // CMP BX,-0x1 (1000_A6CC / 0x1A6CC)
    Alu.Sub16(BX, 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:a6e6 (1000_A6CF / 0x1A6CF)
    if(!ZeroFlag) {
      goto label_1000_A6E6_1A6E6;
    }
    State.IncCycles();
    // MOV AX,0xfff (1000_A6D1 / 0x1A6D1)
    AX = 0xFFF;
    State.IncCycles();
    // XOR byte ptr CS:[0xa6d3],0x10 (1000_A6D4 / 0x1A6D4)
    // UInt8[cs1, 0xA6D3] ^= 0x10;
    UInt8[cs1, 0xA6D3] = Alu.Xor8(UInt8[cs1, 0xA6D3], 0x10);
    State.IncCycles();
    // MOV BX,word ptr [0x22a6] (1000_A6DA / 0x1A6DA)
    BX = UInt16[DS, 0x22A6];
    State.IncCycles();
    // CALL 0x1000:a8bc (1000_A6DE / 0x1A6DE)
    NearCall(cs1, 0xA6E1, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    State.IncCycles();
    // CALL 0x1000:a7a5 (1000_A6E1 / 0x1A6E1)
    NearCall(cs1, 0xA6E4, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    State.IncCycles();
    // JMP 0x1000:a740 (1000_A6E4 / 0x1A6E4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72D_01A72D, 0x1A740 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_A6E6_1A6E6:
    // PUSH BX (1000_A6E6 / 0x1A6E6)
    Stack.Push(BX);
    State.IncCycles();
    // CMP BL,0xe (1000_A6E7 / 0x1A6E7)
    Alu.Sub8(BL, 0xE);
    State.IncCycles();
    // JC 0x1000:a6ee (1000_A6EA / 0x1A6EA)
    if(CarryFlag) {
      goto label_1000_A6EE_1A6EE;
    }
    State.IncCycles();
    // MOV BL,0xe (1000_A6EC / 0x1A6EC)
    BL = 0xE;
    State.IncCycles();
    label_1000_A6EE_1A6EE:
    // AND AH,0xf3 (1000_A6EE / 0x1A6EE)
    AH &= 0xF3;
    State.IncCycles();
    // CMP byte ptr [0x47dc],0x0 (1000_A6F1 / 0x1A6F1)
    Alu.Sub8(UInt8[DS, 0x47DC], 0x0);
    State.IncCycles();
    // JZ 0x1000:a701 (1000_A6F6 / 0x1A6F6)
    if(ZeroFlag) {
      goto label_1000_A701_1A701;
    }
    State.IncCycles();
    // SUB AX,word ptr [0xd814] (1000_A6F8 / 0x1A6F8)
    AX -= UInt16[DS, 0xD814];
    State.IncCycles();
    // ADD AX,0x3e7 (1000_A6FC / 0x1A6FC)
    // AX += 0x3E7;
    AX = Alu.Add16(AX, 0x3E7);
    State.IncCycles();
    // JMP 0x1000:a710 (1000_A6FF / 0x1A6FF)
    goto label_1000_A710_1A710;
    State.IncCycles();
    label_1000_A701_1A701:
    // CMP byte ptr [0x227d],0x0 (1000_A701 / 0x1A701)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:a710 (1000_A706 / 0x1A706)
    if(!ZeroFlag) {
      goto label_1000_A710_1A710;
    }
    State.IncCycles();
    // SHL BX,1 (1000_A708 / 0x1A708)
    BX <<= 0x1;
    State.IncCycles();
    // SUB AX,word ptr [BX + 0xd7f4] (1000_A70A / 0x1A70A)
    AX -= UInt16[DS, (ushort)(BX + 0xD7F4)];
    State.IncCycles();
    // SHR BX,1 (1000_A70E / 0x1A70E)
    BX >>= 0x1;
    State.IncCycles();
    label_1000_A710_1A710:
    // CMP BL,0xe (1000_A710 / 0x1A710)
    Alu.Sub8(BL, 0xE);
    State.IncCycles();
    // JNZ 0x1000:a727 (1000_A713 / 0x1A713)
    if(!ZeroFlag) {
      goto label_1000_A727_1A727;
    }
    State.IncCycles();
    // MOV CX,AX (1000_A715 / 0x1A715)
    CX = AX;
    State.IncCycles();
    // AND CL,0xfe (1000_A717 / 0x1A717)
    CL &= 0xFE;
    State.IncCycles();
    // CMP CL,0x2c (1000_A71A / 0x1A71A)
    Alu.Sub8(CL, 0x2C);
    State.IncCycles();
    // JNZ 0x1000:a727 (1000_A71D / 0x1A71D)
    if(!ZeroFlag) {
      goto label_1000_A727_1A727;
    }
    State.IncCycles();
    // POP CX (1000_A71F / 0x1A71F)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV CL,0xc (1000_A720 / 0x1A720)
    CL = 0xC;
    State.IncCycles();
    // MOV word ptr [0x47c4],CX (1000_A722 / 0x1A722)
    UInt16[DS, 0x47C4] = CX;
    State.IncCycles();
    // PUSH CX (1000_A726 / 0x1A726)
    Stack.Push(CX);
    State.IncCycles();
    label_1000_A727_1A727:
    // CALL 0x1000:a8bc (1000_A727 / 0x1A727)
    NearCall(cs1, 0xA72A, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_A72A_01A72A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
