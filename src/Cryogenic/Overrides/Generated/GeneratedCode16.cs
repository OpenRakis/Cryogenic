namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_D1CF_01D1CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1CF_1D1CF:
    // JMP 0x1000:d1bb (1000_D1CF / 0x1D1CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1BB_01D1BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D1D1_01D1D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1D1_1D1D1:
    // MOV AX,[0xd830] (1000_D1D1 / 0x1D1D1)
    AX = UInt16[DS, 0xD830];
    // MOV [0xd82c],AX (1000_D1D4 / 0x1D1D4)
    UInt16[DS, 0xD82C] = AX;
    // MOV AX,0xa (1000_D1D7 / 0x1D1D7)
    AX = 0xA;
    // CMP word ptr [0x2518],0xd12f (1000_D1DA / 0x1D1DA)
    Alu.Sub16(UInt16[DS, 0x2518], 0xD12F);
    // JNZ 0x1000:d1e5 (1000_D1E0 / 0x1D1E0)
    if(!ZeroFlag) {
      goto label_1000_D1E5_1D1E5;
    }
    // MOV AX,0x7 (1000_D1E2 / 0x1D1E2)
    AX = 0x7;
    label_1000_D1E5_1D1E5:
    // ADD word ptr [0xd832],AX (1000_D1E5 / 0x1D1E5)
    UInt16[DS, 0xD832] += AX;
    // ADD word ptr [0xd82e],AX (1000_D1E9 / 0x1D1E9)
    // UInt16[DS, 0xD82E] += AX;
    UInt16[DS, 0xD82E] = Alu.Add16(UInt16[DS, 0xD82E], AX);
    // JMP 0x1000:d1bb (1000_D1ED / 0x1D1ED)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1BB_01D1BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1EF_01D1EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1EF_1D1EF:
    // LODSW SI (1000_D1EF / 0x1D1EF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_D1F0 / 0x1D1F0)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1F2_01D1F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1F2_01D1F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1F2_1D1F2:
    // CALL 0x1000:c137 (1000_D1F2 / 0x1D1F2)
    NearCall(cs1, 0xD1F5, spice86_generated_label_call_target_1000_C137_01C137);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D1F5_01D1F5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D1F5_01D1F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1F5_1D1F5:
    // PUSH CX (1000_D1F5 / 0x1D1F5)
    Stack.Push(CX);
    // CALL 0x1000:d200 (1000_D1F6 / 0x1D1F6)
    NearCall(cs1, 0xD1F9, spice86_generated_label_call_target_1000_D200_01D200);
    label_1000_D1F9_1D1F9:
    // POP CX (1000_D1F9 / 0x1D1F9)
    CX = Stack.Pop();
    // ADD SI,0xe (1000_D1FA / 0x1D1FA)
    // SI += 0xE;
    SI = Alu.Add16(SI, 0xE);
    // LOOP 0x1000:d1f5 (1000_D1FD / 0x1D1FD)
    if(--CX != 0) {
      goto label_1000_D1F5_1D1F5;
    }
    // RET  (1000_D1FF / 0x1D1FF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D200_01D200(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D200_1D200:
    // PUSH word ptr [0xdbda] (1000_D200 / 0x1D200)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_D204 / 0x1D204)
    NearCall(cs1, 0xD207, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D207_01D207, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D207_01D207(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D207_1D207:
    // PUSH SI (1000_D207 / 0x1D207)
    Stack.Push(SI);
    // TEST byte ptr [SI + 0x8],0x40 (1000_D208 / 0x1D208)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x8)], 0x40);
    // JZ 0x1000:d218 (1000_D20C / 0x1D20C)
    if(ZeroFlag) {
      goto label_1000_D218_1D218;
    }
    // MOV ES,word ptr [0xdbda] (1000_D20E / 0x1D20E)
    ES = UInt16[DS, 0xDBDA];
    // PUSH SI (1000_D212 / 0x1D212)
    Stack.Push(SI);
    // CALLF [0x38d9] (1000_D213 / 0x1D213)
    // Indirect call to [0x38d9], generating possible targets from emulator records
    uint targetAddress_1000_D213 = (uint)(UInt16[DS, 0x38DB] * 0x10 + UInt16[DS, 0x38D9] - cs1 * 0x10);
    switch(targetAddress_1000_D213) {
      case 0x235CB : FarCall(cs1, 0xD217, spice86_generated_label_call_target_334B_011B_0335CB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D213));
        break;
    }
    label_1000_D217_1D217:
    // POP SI (1000_D217 / 0x1D217)
    SI = Stack.Pop();
    label_1000_D218_1D218:
    // TEST byte ptr [SI + 0x8],0x20 (1000_D218 / 0x1D218)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x8)], 0x20);
    // JNZ 0x1000:d233 (1000_D21C / 0x1D21C)
    if(!ZeroFlag) {
      goto label_1000_D233_1D233;
    }
    // LODSW SI (1000_D21E / 0x1D21E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_D21F / 0x1D21F)
    DX = AX;
    // LODSW SI (1000_D221 / 0x1D221)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_D222 / 0x1D222)
    BX = AX;
    // LODSW SI (1000_D224 / 0x1D224)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_D225 / 0x1D225)
    DI = AX;
    // LODSW SI (1000_D227 / 0x1D227)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_D228 / 0x1D228)
    CX = AX;
    // LODSW SI (1000_D22A / 0x1D22A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // LODSW SI (1000_D22B / 0x1D22B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // INC AX (1000_D22C / 0x1D22C)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:d233 (1000_D22D / 0x1D22D)
    if(ZeroFlag) {
      goto label_1000_D233_1D233;
    }
    // DEC AX (1000_D22F / 0x1D22F)
    AX = Alu.Dec16(AX);
    // CALL 0x1000:c22f (1000_D230 / 0x1D230)
    NearCall(cs1, 0xD233, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_D233_1D233:
    // POP SI (1000_D233 / 0x1D233)
    SI = Stack.Pop();
    // POP word ptr [0xdbda] (1000_D234 / 0x1D234)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_D238 / 0x1D238)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D239_01D239(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D239_1D239:
    // MOV CH,0x2 (1000_D239 / 0x1D239)
    CH = 0x2;
    // JMP 0x1000:d23f (1000_D23B / 0x1D23B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D23D_01D23D, 0x1D23F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D23D_01D23D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD23F: goto label_1000_D23F_1D23F;break; // Target of external jump from 0x1D23B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D23D_1D23D:
    // XOR CX,CX (1000_D23D / 0x1D23D)
    CX = 0;
    label_1000_D23F_1D23F:
    // MOV SI,0x1af4 (1000_D23F / 0x1D23F)
    SI = 0x1AF4;
    // MOV AX,word ptr [SI + 0xa] (1000_D242 / 0x1D242)
    AX = UInt16[DS, (ushort)(SI + 0xA)];
    // SUB AX,0x0 (1000_D245 / 0x1D245)
    // AX -= 0x0;
    AX = Alu.Sub16(AX, 0x0);
    // MOV CL,0x3 (1000_D248 / 0x1D248)
    CL = 0x3;
    // DIV CL (1000_D24A / 0x1D24A)
    Cpu.Div8(CL);
    // CMP CH,AH (1000_D24C / 0x1D24C)
    Alu.Sub8(CH, AH);
    // JZ 0x1000:d27f (1000_D24E / 0x1D24E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D27F / 0x1D27F)
      return NearRet();
    }
    // MOV AX,0x1 (1000_D250 / 0x1D250)
    AX = 0x1;
    // JNC 0x1000:d257 (1000_D253 / 0x1D253)
    if(!CarryFlag) {
      goto label_1000_D257_1D257;
    }
    // NEG AX (1000_D255 / 0x1D255)
    AX = Alu.Sub16(0, AX);
    label_1000_D257_1D257:
    // PUSH AX (1000_D257 / 0x1D257)
    Stack.Push(AX);
    // PUSH SI (1000_D258 / 0x1D258)
    Stack.Push(SI);
    // ADD word ptr [SI + 0xa],AX (1000_D259 / 0x1D259)
    UInt16[DS, (ushort)(SI + 0xA)] += AX;
    // ADD word ptr [SI + 0x18],AX (1000_D25C / 0x1D25C)
    // UInt16[DS, (ushort)(SI + 0x18)] += AX;
    UInt16[DS, (ushort)(SI + 0x18)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x18)], AX);
    // MOV CX,0x2 (1000_D25F / 0x1D25F)
    CX = 0x2;
    // CALL 0x1000:d1f2 (1000_D262 / 0x1D262)
    NearCall(cs1, 0xD265, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D265_01D265, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D265_01D265(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D265_1D265:
    // CALL 0x1000:1a34 (1000_D265 / 0x1D265)
    NearCall(cs1, 0xD268, spice86_generated_label_call_target_1000_1A34_011A34);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D268_01D268, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D268_01D268(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D268_1D268:
    // MOV AX,0xa (1000_D268 / 0x1D268)
    AX = 0xA;
    // CALL 0x1000:e387 (1000_D26B / 0x1D26B)
    NearCall(cs1, 0xD26E, spice86_generated_label_call_target_1000_E387_01E387);
    label_1000_D26E_1D26E:
    // POP SI (1000_D26E / 0x1D26E)
    SI = Stack.Pop();
    // POP AX (1000_D26F / 0x1D26F)
    AX = Stack.Pop();
    // ADD word ptr [SI + 0xa],AX (1000_D270 / 0x1D270)
    UInt16[DS, (ushort)(SI + 0xA)] += AX;
    // ADD word ptr [SI + 0x18],AX (1000_D273 / 0x1D273)
    // UInt16[DS, (ushort)(SI + 0x18)] += AX;
    UInt16[DS, (ushort)(SI + 0x18)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x18)], AX);
    // MOV CX,0x2 (1000_D276 / 0x1D276)
    CX = 0x2;
    // CALL 0x1000:d1f2 (1000_D279 / 0x1D279)
    NearCall(cs1, 0xD27C, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    label_1000_D27C_1D27C:
    // CALL 0x1000:1a34 (1000_D27C / 0x1D27C)
    NearCall(cs1, 0xD27F, spice86_generated_label_call_target_1000_1A34_011A34);
    label_1000_D27F_1D27F:
    // RET  (1000_D27F / 0x1D27F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D280_01D280(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D280_1D280:
    // CMP byte ptr [0xdce6],0x0 (1000_D280 / 0x1D280)
    Alu.Sub8(UInt8[DS, 0xDCE6], 0x0);
    // JLE 0x1000:d2bc (1000_D285 / 0x1D285)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_D2BC / 0x1D2BC)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_D287 / 0x1D287)
    NearCall(cs1, 0xD28A, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D28A_01D28A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D28A_01D28A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D28A_1D28A:
    // MOV byte ptr [0xdce6],0x0 (1000_D28A / 0x1D28A)
    UInt8[DS, 0xDCE6] = 0x0;
    // CALL 0x1000:d239 (1000_D28F / 0x1D28F)
    NearCall(cs1, 0xD292, spice86_generated_label_call_target_1000_D239_01D239);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D292_01D292, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D292_01D292(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D292_1D292:
    // MOV CX,0x11 (1000_D292 / 0x1D292)
    CX = 0x11;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D295_01D295, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D295_01D295(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD2BC: goto label_1000_D2BC_1D2BC;break; // Target of external jump from 0x1D285
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D295_1D295:
    // PUSH CX (1000_D295 / 0x1D295)
    Stack.Push(CX);
    // PUSH word ptr [0xce7a] (1000_D296 / 0x1D296)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // MOV SI,word ptr [0xdbde] (1000_D29A / 0x1D29A)
    SI = UInt16[DS, 0xDBDE];
    // MOV AL,0x18 (1000_D29E / 0x1D29E)
    AL = 0x18;
    // CALL 0x1000:c0d5 (1000_D2A0 / 0x1D2A0)
    NearCall(cs1, 0xD2A3, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    label_1000_D2A3_1D2A3:
    // POP BX (1000_D2A3 / 0x1D2A3)
    BX = Stack.Pop();
    label_1000_D2A4_1D2A4:
    // PUSH BX (1000_D2A4 / 0x1D2A4)
    Stack.Push(BX);
    // CALL 0x1000:a7c2 (1000_D2A5 / 0x1D2A5)
    NearCall(cs1, 0xD2A8, spice86_generated_label_call_target_1000_A7C2_01A7C2);
    label_1000_D2A8_1D2A8:
    // POP BX (1000_D2A8 / 0x1D2A8)
    BX = Stack.Pop();
    // MOV AX,[0xce7a] (1000_D2A9 / 0x1D2A9)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,BX (1000_D2AC / 0x1D2AC)
    AX -= BX;
    // CMP AX,0x6 (1000_D2AE / 0x1D2AE)
    Alu.Sub16(AX, 0x6);
    // JC 0x1000:d2a4 (1000_D2B1 / 0x1D2B1)
    if(CarryFlag) {
      goto label_1000_D2A4_1D2A4;
    }
    // POP CX (1000_D2B3 / 0x1D2B3)
    CX = Stack.Pop();
    // LOOP 0x1000:d295 (1000_D2B4 / 0x1D2B4)
    if(--CX != 0) {
      goto label_1000_D295_1D295;
    }
    // CALL 0x1000:d23d (1000_D2B6 / 0x1D2B6)
    NearCall(cs1, 0xD2B9, spice86_generated_label_call_target_1000_D23D_01D23D);
    label_1000_D2B9_1D2B9:
    // CALL 0x1000:e283 (1000_D2B9 / 0x1D2B9)
    NearCall(cs1, 0xD2BC, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_D2BC_1D2BC:
    // RET  (1000_D2BC / 0x1D2BC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D2BD_01D2BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D2BD_1D2BD:
    // MOV AL,[0xdce6] (1000_D2BD / 0x1D2BD)
    AL = UInt8[DS, 0xDCE6];
    // PUSH AX (1000_D2C0 / 0x1D2C0)
    Stack.Push(AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2C1_01D2C1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D2C1_01D2C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D2C1_1D2C1:
    // MOV byte ptr [0xdce6],0x80 (1000_D2C1 / 0x1D2C1)
    UInt8[DS, 0xDCE6] = 0x80;
    // MOV SI,word ptr [0x21da] (1000_D2C6 / 0x1D2C6)
    SI = UInt16[DS, 0x21DA];
    // MOV SI,word ptr [SI] (1000_D2CA / 0x1D2CA)
    SI = UInt16[DS, SI];
    // LODSB SI (1000_D2CC / 0x1D2CC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_D2CD / 0x1D2CD)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:d2da (1000_D2CF / 0x1D2CF)
    if(ZeroFlag) {
      goto label_1000_D2DA_1D2DA;
    }
    // AND AL,0xf (1000_D2D1 / 0x1D2D1)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // JZ 0x1000:d2da (1000_D2D3 / 0x1D2D3)
    if(ZeroFlag) {
      goto label_1000_D2DA_1D2DA;
    }
    // CALL 0x1000:d2ea (1000_D2D5 / 0x1D2D5)
    NearCall(cs1, 0xD2D8, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    label_1000_D2D8_1D2D8:
    // JMP 0x1000:d2c1 (1000_D2D8 / 0x1D2D8)
    goto label_1000_D2C1_1D2C1;
    label_1000_D2DA_1D2DA:
    // POP AX (1000_D2DA / 0x1D2DA)
    AX = Stack.Pop();
    // MOV [0xdce6],AL (1000_D2DB / 0x1D2DB)
    UInt8[DS, 0xDCE6] = AL;
    // RET  (1000_D2DE / 0x1D2DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D2E2_01D2E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D2E2_1D2E2:
    // CALL 0x1000:d316 (1000_D2E2 / 0x1D2E2)
    NearCall(cs1, 0xD2E5, spice86_generated_label_call_target_1000_D316_01D316);
    label_1000_D2E5_1D2E5:
    // CALL 0x1000:d2ea (1000_D2E5 / 0x1D2E5)
    NearCall(cs1, 0xD2E8, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D2E8_01D2E8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D2E8_01D2E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D2E8_1D2E8:
    // JMP 0x1000:d280 (1000_D2E8 / 0x1D2E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D2EA_01D2EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D2EA_1D2EA:
    // MOV SI,word ptr [0x21da] (1000_D2EA / 0x1D2EA)
    SI = UInt16[DS, 0x21DA];
    // MOV DI,word ptr [SI] (1000_D2EE / 0x1D2EE)
    DI = UInt16[DS, SI];
    // MOV AL,byte ptr [DI] (1000_D2F0 / 0x1D2F0)
    AL = UInt8[DS, DI];
    // AND AL,0xf (1000_D2F2 / 0x1D2F2)
    AL &= 0xF;
    // CMP AL,0xf (1000_D2F4 / 0x1D2F4)
    Alu.Sub8(AL, 0xF);
    // JZ 0x1000:d315 (1000_D2F6 / 0x1D2F6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D315 / 0x1D315)
      return NearRet();
    }
    // MOV AX,word ptr [SI + 0x2] (1000_D2F8 / 0x1D2F8)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL AX (1000_D2FB / 0x1D2FB)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_D2FB = (uint)(AX);
    switch(targetAddress_1000_D2FB) {
      case 0x97CF : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_97CF_0197CF); break;
      case 0xA541 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_A541_01A541); break;
      case 0x19FC : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_19FC_0119FC); break;
      case 0x4415 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_4415_014415); break;
      case 0xF66 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x5F91 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_5F91_015F91); break;
      case 0x7D68 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_7D68_017D68); break;
      case 0xB2B3 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_B2B3_01B2B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D2FB));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D2FD_01D2FD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D2FD_01D2FD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD315: goto label_1000_D315_1D315;break; // Target of external jump from 0x1D2F6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D2FD_1D2FD:
    // MOV SI,word ptr [0x21da] (1000_D2FD / 0x1D2FD)
    SI = UInt16[DS, 0x21DA];
    // CMP SI,0x21be (1000_D301 / 0x1D301)
    Alu.Sub16(SI, 0x21BE);
    // JZ 0x1000:d315 (1000_D305 / 0x1D305)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D315 / 0x1D315)
      return NearRet();
    }
    // SUB SI,0x4 (1000_D307 / 0x1D307)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    // MOV word ptr [0x21da],SI (1000_D30A / 0x1D30A)
    UInt16[DS, 0x21DA] = SI;
    // MOV BP,word ptr [SI] (1000_D30E / 0x1D30E)
    BP = UInt16[DS, SI];
    // MOV CL,0xff (1000_D310 / 0x1D310)
    CL = 0xFF;
    // CALL 0x1000:d36d (1000_D312 / 0x1D312)
    NearCall(cs1, 0xD315, spice86_generated_label_call_target_1000_D36D_01D36D);
    label_1000_D315_1D315:
    // RET  (1000_D315 / 0x1D315)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D316_01D316(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D316_1D316:
    // CMP word ptr [0x35a6],0x0 (1000_D316 / 0x1D316)
    Alu.Sub16(UInt16[DS, 0x35A6], 0x0);
    // JNZ 0x1000:d322 (1000_D31B / 0x1D31B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_D322 / 0x1D322)
      return NearRet();
    }
    // OR byte ptr [0xdce6],0x1 (1000_D31D / 0x1D31D)
    // UInt8[DS, 0xDCE6] |= 0x1;
    UInt8[DS, 0xDCE6] = Alu.Or8(UInt8[DS, 0xDCE6], 0x1);
    label_1000_D322_1D322:
    // RET  (1000_D322 / 0x1D322)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D323_01D323(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D323_1D323:
    // CALL 0x1000:d316 (1000_D323 / 0x1D323)
    NearCall(cs1, 0xD326, spice86_generated_label_call_target_1000_D316_01D316);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D326_01D326, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D326_01D326(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D326_1D326:
    // CALL 0x1000:d338 (1000_D326 / 0x1D326)
    NearCall(cs1, 0xD329, spice86_generated_label_call_target_1000_D338_01D338);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D329_01D329, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D329_01D329(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D329_1D329:
    // CALL 0x1000:d280 (1000_D329 / 0x1D329)
    NearCall(cs1, 0xD32C, spice86_generated_label_call_target_1000_D280_01D280);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D32C_01D32C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D32C_01D32C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D32C_1D32C:
    // JMP 0x1000:d410 (1000_D32C / 0x1D32C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D32F_01D32F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D32F_1D32F:
    // CALL 0x1000:d316 (1000_D32F / 0x1D32F)
    NearCall(cs1, 0xD332, spice86_generated_label_call_target_1000_D316_01D316);
    label_1000_D332_1D332:
    // CALL 0x1000:d33a (1000_D332 / 0x1D332)
    NearCall(cs1, 0xD335, spice86_generated_label_call_target_1000_D33A_01D33A);
    label_1000_D335_1D335:
    // JMP 0x1000:d280 (1000_D335 / 0x1D335)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D338_01D338(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D338_1D338:
    // MOV CL,0xff (1000_D338 / 0x1D338)
    CL = 0xFF;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D33A_01D33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D33A_01D33A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D33A_1D33A:
    // MOV SI,word ptr [0x21da] (1000_D33A / 0x1D33A)
    SI = UInt16[DS, 0x21DA];
    // MOV DI,word ptr [SI] (1000_D33E / 0x1D33E)
    DI = UInt16[DS, SI];
    // MOV AL,byte ptr [BP + 0x0] (1000_D340 / 0x1D340)
    AL = UInt8[SS, BP];
    // CMP AL,byte ptr [DI] (1000_D343 / 0x1D343)
    Alu.Sub8(AL, UInt8[DS, DI]);
    // JZ 0x1000:d368 (1000_D345 / 0x1D345)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D35B_01D35B, 0x1D368 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JC 0x1000:d35b (1000_D347 / 0x1D347)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D35B_01D35B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH BP (1000_D349 / 0x1D349)
    Stack.Push(BP);
    // PUSH BX (1000_D34A / 0x1D34A)
    Stack.Push(BX);
    // PUSH CX (1000_D34B / 0x1D34B)
    Stack.Push(CX);
    // MOV AX,word ptr [SI + 0x2] (1000_D34C / 0x1D34C)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL AX (1000_D34F / 0x1D34F)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_D34F = (uint)(AX);
    switch(targetAddress_1000_D34F) {
      case 0x8751 : NearCall(cs1, 0xD351, spice86_generated_label_call_target_1000_8751_018751); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D34F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D351_01D351, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D351_01D351(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D351_1D351:
    // SUB word ptr [0x21da],0x4 (1000_D351 / 0x1D351)
    // UInt16[DS, 0x21DA] -= 0x4;
    UInt16[DS, 0x21DA] = Alu.Sub16(UInt16[DS, 0x21DA], 0x4);
    // POP CX (1000_D356 / 0x1D356)
    CX = Stack.Pop();
    // POP BX (1000_D357 / 0x1D357)
    BX = Stack.Pop();
    // POP BP (1000_D358 / 0x1D358)
    BP = Stack.Pop();
    // JMP 0x1000:d33a (1000_D359 / 0x1D359)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D33A_01D33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D35B_01D35B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD368: goto label_1000_D368_1D368;break; // Target of external jump from 0x1D345
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D35B_1D35B:
    // CMP SI,0x21d6 (1000_D35B / 0x1D35B)
    Alu.Sub16(SI, 0x21D6);
    // JZ 0x1000:d368 (1000_D35F / 0x1D35F)
    if(ZeroFlag) {
      goto label_1000_D368_1D368;
    }
    // ADD SI,0x4 (1000_D361 / 0x1D361)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // MOV word ptr [0x21da],SI (1000_D364 / 0x1D364)
    UInt16[DS, 0x21DA] = SI;
    label_1000_D368_1D368:
    // MOV word ptr [SI],BP (1000_D368 / 0x1D368)
    UInt16[DS, SI] = BP;
    // MOV word ptr [SI + 0x2],BX (1000_D36A / 0x1D36A)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D36D_01D36D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D36D_01D36D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D36D_1D36D:
    // MOV SI,word ptr [0x21da] (1000_D36D / 0x1D36D)
    SI = UInt16[DS, 0x21DA];
    // MOV word ptr [SI],BP (1000_D371 / 0x1D371)
    UInt16[DS, SI] = BP;
    // MOV SI,BP (1000_D373 / 0x1D373)
    SI = BP;
    // ADD BP,0x2 (1000_D375 / 0x1D375)
    BP += 0x2;
    label_1000_D378_1D378:
    // CMP word ptr [BP + 0x0],0x0 (1000_D378 / 0x1D378)
    Alu.Sub16(UInt16[SS, BP], 0x0);
    // JZ 0x1000:d388 (1000_D37C / 0x1D37C)
    if(ZeroFlag) {
      goto label_1000_D388_1D388;
    }
    // AND word ptr [BP + 0x0],0x7fff (1000_D37E / 0x1D37E)
    UInt16[SS, BP] &= 0x7FFF;
    // ADD BP,0x4 (1000_D383 / 0x1D383)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    // JMP 0x1000:d378 (1000_D386 / 0x1D386)
    goto label_1000_D378_1D378;
    label_1000_D388_1D388:
    // CMP CX,0x5 (1000_D388 / 0x1D388)
    Alu.Sub16(CX, 0x5);
    // JNC 0x1000:d397 (1000_D38B / 0x1D38B)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D397_01D397, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // SHL CX,1 (1000_D38D / 0x1D38D)
    CX <<= 0x1;
    // SHL CX,1 (1000_D38F / 0x1D38F)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    // MOV BX,CX (1000_D391 / 0x1D391)
    BX = CX;
    // OR byte ptr [BX + SI + 0x3],0x80 (1000_D393 / 0x1D393)
    // UInt8[DS, (ushort)(BX + SI + 0x3)] |= 0x80;
    UInt8[DS, (ushort)(BX + SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(BX + SI + 0x3)], 0x80);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D397_01D397, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D397_01D397(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D397_1D397:
    // MOV byte ptr [0xdce7],0xff (1000_D397 / 0x1D397)
    UInt8[DS, 0xDCE7] = 0xFF;
    // MOV SI,word ptr [0x21da] (1000_D39C / 0x1D39C)
    SI = UInt16[DS, 0x21DA];
    // MOV SI,word ptr [SI] (1000_D3A0 / 0x1D3A0)
    SI = UInt16[DS, SI];
    // INC SI (1000_D3A2 / 0x1D3A2)
    SI = Alu.Inc16(SI);
    // LODSB SI (1000_D3A3 / 0x1D3A3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV [0xdce4],AL (1000_D3A4 / 0x1D3A4)
    UInt8[DS, 0xDCE4] = AL;
    // CBW  (1000_D3A7 / 0x1D3A7)
    AX = (ushort)((short)((sbyte)AL));
    // ADD SI,AX (1000_D3A8 / 0x1D3A8)
    SI += AX;
    // XOR CX,CX (1000_D3AA / 0x1D3AA)
    CX = 0;
    // MOV byte ptr [0xdce8],CL (1000_D3AC / 0x1D3AC)
    UInt8[DS, 0xDCE8] = CL;
    // MOV byte ptr [0xdce5],0xff (1000_D3B0 / 0x1D3B0)
    UInt8[DS, 0xDCE5] = 0xFF;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D3B5_01D3B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D3B5_01D3B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D3B5_1D3B5:
    // MOV AX,word ptr [SI] (1000_D3B5 / 0x1D3B5)
    AX = UInt16[DS, SI];
    // OR AX,AX (1000_D3B7 / 0x1D3B7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:d3ef (1000_D3B9 / 0x1D3B9)
    if(ZeroFlag) {
      goto label_1000_D3EF_1D3EF;
    }
    // CMP CL,0x4 (1000_D3BB / 0x1D3BB)
    Alu.Sub8(CL, 0x4);
    // JC 0x1000:d3d9 (1000_D3BE / 0x1D3BE)
    if(CarryFlag) {
      goto label_1000_D3D9_1D3D9;
    }
    // CMP byte ptr [0xdce4],0x0 (1000_D3C0 / 0x1D3C0)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    // JNZ 0x1000:d3cd (1000_D3C5 / 0x1D3C5)
    if(!ZeroFlag) {
      goto label_1000_D3CD_1D3CD;
    }
    // CMP word ptr [SI + 0x4],0x0 (1000_D3C7 / 0x1D3C7)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], 0x0);
    // JZ 0x1000:d3d9 (1000_D3CB / 0x1D3CB)
    if(ZeroFlag) {
      goto label_1000_D3D9_1D3D9;
    }
    label_1000_D3CD_1D3CD:
    // OR byte ptr [0xdce4],0x80 (1000_D3CD / 0x1D3CD)
    // UInt8[DS, 0xDCE4] |= 0x80;
    UInt8[DS, 0xDCE4] = Alu.Or8(UInt8[DS, 0xDCE4], 0x80);
    // MOV AX,0xa0 (1000_D3D2 / 0x1D3D2)
    AX = 0xA0;
    // MOV byte ptr [0xdce5],CL (1000_D3D5 / 0x1D3D5)
    UInt8[DS, 0xDCE5] = CL;
    label_1000_D3D9_1D3D9:
    // ADD SI,0x4 (1000_D3D9 / 0x1D3D9)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // PUSH CX (1000_D3DC / 0x1D3DC)
    Stack.Push(CX);
    // PUSH SI (1000_D3DD / 0x1D3DD)
    Stack.Push(SI);
    // INC byte ptr [0xdce8] (1000_D3DE / 0x1D3DE)
    UInt8[DS, 0xDCE8] = Alu.Inc8(UInt8[DS, 0xDCE8]);
    // CALL 0x1000:d48a (1000_D3E2 / 0x1D3E2)
    NearCall(cs1, 0xD3E5, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D3E5_1D3E5:
    // POP SI (1000_D3E5 / 0x1D3E5)
    SI = Stack.Pop();
    // POP CX (1000_D3E6 / 0x1D3E6)
    CX = Stack.Pop();
    // INC CX (1000_D3E7 / 0x1D3E7)
    CX++;
    // CMP CL,0x5 (1000_D3E8 / 0x1D3E8)
    Alu.Sub8(CL, 0x5);
    // JC 0x1000:d3b5 (1000_D3EB / 0x1D3EB)
    if(CarryFlag) {
      goto label_1000_D3B5_1D3B5;
    }
    // JMP 0x1000:d410 (1000_D3ED / 0x1D3ED)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D3EF_1D3EF:
    // CMP byte ptr [0xdce4],0x0 (1000_D3EF / 0x1D3EF)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    // JZ 0x1000:d403 (1000_D3F4 / 0x1D3F4)
    if(ZeroFlag) {
      goto label_1000_D403_1D403;
    }
    // MOV AX,0xa0 (1000_D3F6 / 0x1D3F6)
    AX = 0xA0;
    // MOV byte ptr [0xdce5],CL (1000_D3F9 / 0x1D3F9)
    UInt8[DS, 0xDCE5] = CL;
    // INC byte ptr [0xdce8] (1000_D3FD / 0x1D3FD)
    UInt8[DS, 0xDCE8] = Alu.Inc8(UInt8[DS, 0xDCE8]);
    // JMP 0x1000:d405 (1000_D401 / 0x1D401)
    goto label_1000_D405_1D405;
    label_1000_D403_1D403:
    // XOR AX,AX (1000_D403 / 0x1D403)
    AX = 0;
    label_1000_D405_1D405:
    // PUSH CX (1000_D405 / 0x1D405)
    Stack.Push(CX);
    // CALL 0x1000:d48a (1000_D406 / 0x1D406)
    NearCall(cs1, 0xD409, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D409_1D409:
    // POP CX (1000_D409 / 0x1D409)
    CX = Stack.Pop();
    // INC CX (1000_D40A / 0x1D40A)
    CX++;
    // CMP CL,0x5 (1000_D40B / 0x1D40B)
    Alu.Sub8(CL, 0x5);
    // JC 0x1000:d403 (1000_D40E / 0x1D40E)
    if(CarryFlag) {
      goto label_1000_D403_1D403;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D410_01D410(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D410_1D410:
    // MOV DX,word ptr [0xdc36] (1000_D410 / 0x1D410)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_D414 / 0x1D414)
    BX = UInt16[DS, 0xDC38];
    // JMP 0x1000:d50f (1000_D418 / 0x1D418)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D50F_01D50F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D41B_01D41B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D41B_1D41B:
    // MOV BP,word ptr [0x21da] (1000_D41B / 0x1D41B)
    BP = UInt16[DS, 0x21DA];
    // MOV BP,word ptr [BP + 0x0] (1000_D41F / 0x1D41F)
    BP = UInt16[SS, BP];
    // RET  (1000_D422 / 0x1D422)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D42F_01D42F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D42F_1D42F:
    // MOV CX,0x4 (1000_D42F / 0x1D42F)
    CX = 0x4;
    // JMP 0x1000:d445 (1000_D432 / 0x1D432)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D434_01D434(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D434_1D434:
    // MOV CX,0x3 (1000_D434 / 0x1D434)
    CX = 0x3;
    // JMP 0x1000:d445 (1000_D437 / 0x1D437)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D439_01D439(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D439_1D439:
    // MOV CX,0x2 (1000_D439 / 0x1D439)
    CX = 0x2;
    // JMP 0x1000:d445 (1000_D43C / 0x1D43C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D43E_01D43E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D43E_1D43E:
    // MOV CX,0x1 (1000_D43E / 0x1D43E)
    CX = 0x1;
    // JMP 0x1000:d445 (1000_D441 / 0x1D441)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D443_01D443(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D443_1D443:
    // XOR CX,CX (1000_D443 / 0x1D443)
    CX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D445_01D445(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D445_1D445:
    // CALL 0x1000:d454 (1000_D445 / 0x1D445)
    NearCall(cs1, 0xD448, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D448_1D448:
    // OR BX,BX (1000_D448 / 0x1D448)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:d453 (1000_D44A / 0x1D44A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D453 / 0x1D453)
      return NearRet();
    }
    // TEST AH,0x40 (1000_D44C / 0x1D44C)
    Alu.And8(AH, 0x40);
    // JNZ 0x1000:d453 (1000_D44F / 0x1D44F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_D453 / 0x1D453)
      return NearRet();
    }
    // JMP BX (1000_D451 / 0x1D451)
    // Indirect jump to BX, generating possible targets from emulator records
    uint targetAddress_1000_D451 = (uint)(BX);
    switch(targetAddress_1000_D451) {
      case 0xA3F0 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_A3F0_01A3F0, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xE3E : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0E3E_010E3E, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x3A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xD2E2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xEA6 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0EA6_010EA6, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x4FFB : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4FFB_014FFB, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x95C1 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_95C1_0195C1, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x5A03 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5A03_015A03, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x69B3 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_69B3_0169B3, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x6A83 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6A83_016A83, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x6A71 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6A71_016A71, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x8763 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8763_018763, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x95E2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_95E2_0195E2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF60 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF60_01AF60, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF68 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF68_01AF68, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF70 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_AF70_01AF70, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB18B : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B18B_01B18B, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x50A5 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_50A5_0150A5, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x497A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_497A_01497A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x50DB : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_50DB_0150DB, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9ED5 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9ED5_019ED5, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9472 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9472_019472, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x7CBB : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7CBB_017CBB, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB96B : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B96B_01B96B, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB28C : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B28C_01B28C, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB35A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B35A_01B35A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB961 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B961_01B961, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xAF58 : throw FailAsUntested("Would have been a goto but label label_1000_AF58_1AF58 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D451));
        break;
    }
    label_1000_D453_1D453:
    // RET  (1000_D453 / 0x1D453)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D454_01D454(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D454_1D454:
    // MOV SI,word ptr [0x21da] (1000_D454 / 0x1D454)
    SI = UInt16[DS, 0x21DA];
    // MOV SI,word ptr [SI] (1000_D458 / 0x1D458)
    SI = UInt16[DS, SI];
    // INC SI (1000_D45A / 0x1D45A)
    SI++;
    // XOR CH,CH (1000_D45B / 0x1D45B)
    CH = 0;
    // CMP CL,byte ptr [0xdce5] (1000_D45D / 0x1D45D)
    Alu.Sub8(CL, UInt8[DS, 0xDCE5]);
    // JZ 0x1000:d475 (1000_D461 / 0x1D461)
    if(ZeroFlag) {
      goto label_1000_D475_1D475;
    }
    // LODSB SI (1000_D463 / 0x1D463)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_D464 / 0x1D464)
    AX = (ushort)((short)((sbyte)AL));
    // ADD SI,AX (1000_D465 / 0x1D465)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AX,CX (1000_D467 / 0x1D467)
    AX = CX;
    // SHL AX,1 (1000_D469 / 0x1D469)
    AX <<= 0x1;
    // SHL AX,1 (1000_D46B / 0x1D46B)
    AX <<= 0x1;
    // ADD SI,AX (1000_D46D / 0x1D46D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AX,word ptr [SI] (1000_D46F / 0x1D46F)
    AX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_D471 / 0x1D471)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // RET  (1000_D474 / 0x1D474)
    return NearRet();
    label_1000_D475_1D475:
    // MOV AX,0xa0 (1000_D475 / 0x1D475)
    AX = 0xA0;
    // MOV BX,0xd423 (1000_D478 / 0x1D478)
    BX = 0xD423;
    // CMP byte ptr [0xdce4],0x0 (1000_D47B / 0x1D47B)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    // JS 0x1000:d489 (1000_D480 / 0x1D480)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_D489 / 0x1D489)
      return NearRet();
    }
    // MOV BX,0xd429 (1000_D482 / 0x1D482)
    BX = 0xD429;
    // JG 0x1000:d489 (1000_D485 / 0x1D485)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_D489 / 0x1D489)
      return NearRet();
    }
    // XOR BX,BX (1000_D487 / 0x1D487)
    BX = 0;
    label_1000_D489_1D489:
    // RET  (1000_D489 / 0x1D489)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D48A_01D48A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D48A_1D48A:
    // PUSH word ptr [0xdbda] (1000_D48A / 0x1D48A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_D48E / 0x1D48E)
    NearCall(cs1, 0xD491, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D491_01D491, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D491_01D491(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D491_1D491:
    // CMP byte ptr [0xdce6],0x0 (1000_D491 / 0x1D491)
    Alu.Sub8(UInt8[DS, 0xDCE6], 0x0);
    // JLE 0x1000:d49b (1000_D496 / 0x1D496)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D49B_01D49B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c07c (1000_D498 / 0x1D498)
    NearCall(cs1, 0xD49B, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D49B_01D49B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D49B_01D49B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D49B_1D49B:
    // CALL 0x1000:d075 (1000_D49B / 0x1D49B)
    NearCall(cs1, 0xD49E, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_D49E_1D49E:
    // MOV SI,AX (1000_D49E / 0x1D49E)
    SI = AX;
    // MOV AL,0xe (1000_D4A0 / 0x1D4A0)
    AL = 0xE;
    // MUL CL (1000_D4A2 / 0x1D4A2)
    Cpu.Mul8(CL);
    // MOV DI,AX (1000_D4A4 / 0x1D4A4)
    DI = AX;
    // ADD DI,0x1b48 (1000_D4A6 / 0x1D4A6)
    // DI += 0x1B48;
    DI = Alu.Add16(DI, 0x1B48);
    // MOV BX,word ptr [DI + 0x2] (1000_D4AA / 0x1D4AA)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    // INC BX (1000_D4AD / 0x1D4AD)
    BX = Alu.Inc16(BX);
    // MOV DX,0x5d (1000_D4AE / 0x1D4AE)
    DX = 0x5D;
    // CALL 0x1000:d04e (1000_D4B1 / 0x1D4B1)
    NearCall(cs1, 0xD4B4, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D4B4_01D4B4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D4B4_01D4B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D4B4_1D4B4:
    // MOV byte ptr [0xdbe5],0xf3 (1000_D4B4 / 0x1D4B4)
    UInt8[DS, 0xDBE5] = 0xF3;
    // AND byte ptr [DI + 0x8],0x7f (1000_D4B9 / 0x1D4B9)
    // UInt8[DS, (ushort)(DI + 0x8)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0x8)] = Alu.And8(UInt8[DS, (ushort)(DI + 0x8)], 0x7F);
    // MOV AX,SI (1000_D4BD / 0x1D4BD)
    AX = SI;
    // AND SI,0x3fff (1000_D4BF / 0x1D4BF)
    // SI &= 0x3FFF;
    SI = Alu.And16(SI, 0x3FFF);
    // JZ 0x1000:d4e9 (1000_D4C3 / 0x1D4C3)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D4E6_01D4E6, 0x1D4E9 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,0xf5 (1000_D4C5 / 0x1D4C5)
    AL = 0xF5;
    // TEST AH,0x40 (1000_D4C7 / 0x1D4C7)
    Alu.And8(AH, 0x40);
    // JNZ 0x1000:d4da (1000_D4CA / 0x1D4CA)
    if(!ZeroFlag) {
      goto label_1000_D4DA_1D4DA;
    }
    // OR byte ptr [DI + 0x8],0x80 (1000_D4CC / 0x1D4CC)
    // UInt8[DS, (ushort)(DI + 0x8)] |= 0x80;
    UInt8[DS, (ushort)(DI + 0x8)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0x8)], 0x80);
    // MOV AL,0xfa (1000_D4D0 / 0x1D4D0)
    AL = 0xFA;
    // OR AH,AH (1000_D4D2 / 0x1D4D2)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JNS 0x1000:d4da (1000_D4D4 / 0x1D4D4)
    if(!SignFlag) {
      goto label_1000_D4DA_1D4DA;
    }
    // XCHG byte ptr [0xdbe5],AL (1000_D4D6 / 0x1D4D6)
    byte tmp_1000_D4D6 = UInt8[DS, 0xDBE5];
    UInt8[DS, 0xDBE5] = AL;
    AL = tmp_1000_D4D6;
    label_1000_D4DA_1D4DA:
    // MOV [0xdbe4],AL (1000_D4DA / 0x1D4DA)
    UInt8[DS, 0xDBE4] = AL;
    // CALL 0x1000:cf70 (1000_D4DD / 0x1D4DD)
    NearCall(cs1, 0xD4E0, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_D4E0_1D4E0:
    // MOV AL,0x20 (1000_D4E0 / 0x1D4E0)
    AL = 0x20;
    // CALL word ptr [0x2518] (1000_D4E2 / 0x1D4E2)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_D4E2 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_D4E2) {
      case 0xD12F : NearCall(cs1, 0xD4E6, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D4E2));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D4E6_01D4E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D4E6_01D4E6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD4E9: goto label_1000_D4E9_1D4E9;break; // Target of external jump from 0x1D4C3
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D4E6_1D4E6:
    // CALL 0x1000:d1bb (1000_D4E6 / 0x1D4E6)
    NearCall(cs1, 0xD4E9, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    label_1000_D4E9_1D4E9:
    // CALL 0x1000:d05f (1000_D4E9 / 0x1D4E9)
    NearCall(cs1, 0xD4EC, spice86_generated_label_call_target_1000_D05F_01D05F);
    label_1000_D4EC_1D4EC:
    // MOV SI,0xdce9 (1000_D4EC / 0x1D4EC)
    SI = 0xDCE9;
    // MOV word ptr [SI],DX (1000_D4EF / 0x1D4EF)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_D4F1 / 0x1D4F1)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // MOV word ptr [SI + 0x4],0xe3 (1000_D4F4 / 0x1D4F4)
    UInt16[DS, (ushort)(SI + 0x4)] = 0xE3;
    // ADD BX,0x7 (1000_D4F9 / 0x1D4F9)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    // MOV word ptr [SI + 0x6],BX (1000_D4FC / 0x1D4FC)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV AL,[0xdbe5] (1000_D4FF / 0x1D4FF)
    AL = UInt8[DS, 0xDBE5];
    // MOV ES,word ptr [0xdbda] (1000_D502 / 0x1D502)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38dd] (1000_D506 / 0x1D506)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_D506 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_D506) {
      case 0x235CE : FarCall(cs1, 0xD50A, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D506));
        break;
    }
    label_1000_D50A_1D50A:
    // POP word ptr [0xdbda] (1000_D50A / 0x1D50A)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_D50E / 0x1D50E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D50F_01D50F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D50F_1D50F:
    // PUSH BX (1000_D50F / 0x1D50F)
    Stack.Push(BX);
    // PUSH CX (1000_D510 / 0x1D510)
    Stack.Push(CX);
    // PUSH DX (1000_D511 / 0x1D511)
    Stack.Push(DX);
    // PUSH SI (1000_D512 / 0x1D512)
    Stack.Push(SI);
    // PUSH DI (1000_D513 / 0x1D513)
    Stack.Push(DI);
    // PUSH BP (1000_D514 / 0x1D514)
    Stack.Push(BP);
    // CMP byte ptr [0x4774],0x0 (1000_D515 / 0x1D515)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:d523 (1000_D51A / 0x1D51A)
    if(ZeroFlag) {
      goto label_1000_D523_1D523;
    }
    // MOV CL,byte ptr [0x4775] (1000_D51C / 0x1D51C)
    CL = UInt8[DS, 0x4775];
    // JMP 0x1000:d5dd (1000_D520 / 0x1D520)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D5DD - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D523_1D523:
    // CALL 0x1000:d41b (1000_D523 / 0x1D523)
    NearCall(cs1, 0xD526, spice86_generated_label_call_target_1000_D41B_01D41B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D526_01D526, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D526_01D526(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D526_1D526:
    // CMP BP,0x1f0e (1000_D526 / 0x1D526)
    Alu.Sub16(BP, 0x1F0E);
    // JNZ 0x1000:d575 (1000_D52A / 0x1D52A)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D575 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x11c9],0x0 (1000_D52C / 0x1D52C)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:d575 (1000_D531 / 0x1D531)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D575 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV DI,0x1bf0 (1000_D533 / 0x1D533)
    DI = 0x1BF0;
    // CMP byte ptr [DI + 0x8],0x0 (1000_D536 / 0x1D536)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    // JNS 0x1000:d545 (1000_D53A / 0x1D53A)
    if(!SignFlag) {
      goto label_1000_D545_1D545;
    }
    // CALL 0x1000:d6fe (1000_D53C / 0x1D53C)
    NearCall(cs1, 0xD53F, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D53F_1D53F:
    // MOV CX,word ptr [0x47c4] (1000_D53F / 0x1D53F)
    CX = UInt16[DS, 0x47C4];
    // JC 0x1000:d55d (1000_D543 / 0x1D543)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0x1D55D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_D545_1D545:
    // PUSH BP (1000_D545 / 0x1D545)
    Stack.Push(BP);
    // CALL 0x1000:9285 (1000_D546 / 0x1D546)
    NearCall(cs1, 0xD549, spice86_generated_label_call_target_1000_9285_019285);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D549_01D549, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D549_01D549(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD575: goto label_1000_D575_1D575;break; // Target of external jump from 0x1D531, 0x1D54A, 0x1D52A
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D549_1D549:
    // POP BP (1000_D549 / 0x1D549)
    BP = Stack.Pop();
    // JNC 0x1000:d575 (1000_D54A / 0x1D54A)
    if(!CarryFlag) {
      goto label_1000_D575_1D575;
    }
    // MOV AL,CL (1000_D54C / 0x1D54C)
    AL = CL;
    // SUB AL,0xf (1000_D54E / 0x1D54E)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    // JC 0x1000:d55d (1000_D550 / 0x1D550)
    if(CarryFlag) {
      goto label_1000_D55D_1D55D;
    }
    // INC AL (1000_D552 / 0x1D552)
    AL++;
    // CMP AL,byte ptr [0x476b] (1000_D554 / 0x1D554)
    Alu.Sub8(AL, UInt8[DS, 0x476B]);
    // JNZ 0x1000:d55d (1000_D558 / 0x1D558)
    if(!ZeroFlag) {
      goto label_1000_D55D_1D55D;
    }
    // MOV CX,0x17 (1000_D55A / 0x1D55A)
    CX = 0x17;
    label_1000_D55D_1D55D:
    // MOV BP,CX (1000_D55D / 0x1D55D)
    BP = CX;
    // ADD BP,0x78 (1000_D55F / 0x1D55F)
    BP += 0x78;
    // XOR CX,CX (1000_D563 / 0x1D563)
    CX = 0;
    label_1000_D565_1D565:
    // CALL 0x1000:d454 (1000_D565 / 0x1D565)
    NearCall(cs1, 0xD568, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D568_1D568:
    // CMP AX,BP (1000_D568 / 0x1D568)
    Alu.Sub16(AX, BP);
    // JZ 0x1000:d5dd (1000_D56A / 0x1D56A)
    if(ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // INC CX (1000_D56C / 0x1D56C)
    CX++;
    // CMP CL,byte ptr [0xdce8] (1000_D56D / 0x1D56D)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    // JC 0x1000:d565 (1000_D571 / 0x1D571)
    if(CarryFlag) {
      goto label_1000_D565_1D565;
    }
    // JMP 0x1000:d5db (1000_D573 / 0x1D573)
    goto label_1000_D5DB_1D5DB;
    label_1000_D575_1D575:
    // CMP BP,0x1f7e (1000_D575 / 0x1D575)
    Alu.Sub16(BP, 0x1F7E);
    // JNZ 0x1000:d5b1 (1000_D579 / 0x1D579)
    if(!ZeroFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    // MOV DI,0x1be2 (1000_D57B / 0x1D57B)
    DI = 0x1BE2;
    // CMP byte ptr [DI + 0x8],0x0 (1000_D57E / 0x1D57E)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    // JNS 0x1000:d593 (1000_D582 / 0x1D582)
    if(!SignFlag) {
      goto label_1000_D593_1D593;
    }
    // XOR CX,CX (1000_D584 / 0x1D584)
    CX = 0;
    // CALL 0x1000:d6fe (1000_D586 / 0x1D586)
    NearCall(cs1, 0xD589, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D589_1D589:
    // JC 0x1000:d5dd (1000_D589 / 0x1D589)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // MOV DI,0x1bf0 (1000_D58B / 0x1D58B)
    DI = 0x1BF0;
    // CALL 0x1000:d6fe (1000_D58E / 0x1D58E)
    NearCall(cs1, 0xD591, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D591_1D591:
    // JC 0x1000:d5dd (1000_D591 / 0x1D591)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    label_1000_D593_1D593:
    // CMP byte ptr [0x1bf8],0x0 (1000_D593 / 0x1D593)
    Alu.Sub8(UInt8[DS, 0x1BF8], 0x0);
    // JNS 0x1000:d5b1 (1000_D598 / 0x1D598)
    if(!SignFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    // MOV DI,0x1bfe (1000_D59A / 0x1D59A)
    DI = 0x1BFE;
    // CALL 0x1000:d6fe (1000_D59D / 0x1D59D)
    NearCall(cs1, 0xD5A0, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D5A0_1D5A0:
    // MOV CL,0x3 (1000_D5A0 / 0x1D5A0)
    CL = 0x3;
    // JC 0x1000:d5dd (1000_D5A2 / 0x1D5A2)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // CALL 0x1000:92c9 (1000_D5A4 / 0x1D5A4)
    NearCall(cs1, 0xD5A7, spice86_generated_label_call_target_1000_92C9_0192C9);
    label_1000_D5A7_1D5A7:
    // JNC 0x1000:d5b1 (1000_D5A7 / 0x1D5A7)
    if(!CarryFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    // CMP CX,word ptr [0x47c4] (1000_D5A9 / 0x1D5A9)
    Alu.Sub16(CX, UInt16[DS, 0x47C4]);
    // MOV CL,0x2 (1000_D5AD / 0x1D5AD)
    CL = 0x2;
    // JZ 0x1000:d5dd (1000_D5AF / 0x1D5AF)
    if(ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    label_1000_D5B1_1D5B1:
    // CMP BX,0x98 (1000_D5B1 / 0x1D5B1)
    Alu.Sub16(BX, 0x98);
    // JC 0x1000:d5db (1000_D5B5 / 0x1D5B5)
    if(CarryFlag) {
      goto label_1000_D5DB_1D5DB;
    }
    // MOV CL,0xff (1000_D5B7 / 0x1D5B7)
    CL = 0xFF;
    // MOV DI,0x1b48 (1000_D5B9 / 0x1D5B9)
    DI = 0x1B48;
    // CMP DX,word ptr [DI] (1000_D5BC / 0x1D5BC)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JC 0x1000:d5dd (1000_D5BE / 0x1D5BE)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_D5C0 / 0x1D5C0)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JNC 0x1000:d5dd (1000_D5C3 / 0x1D5C3)
    if(!CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // XOR CX,CX (1000_D5C5 / 0x1D5C5)
    CX = 0;
    label_1000_D5C7_1D5C7:
    // CMP BX,word ptr [DI + 0x2] (1000_D5C7 / 0x1D5C7)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JBE 0x1000:d5db (1000_D5CA / 0x1D5CA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D5DB_1D5DB;
    }
    // CMP BX,word ptr [DI + 0x6] (1000_D5CC / 0x1D5CC)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JBE 0x1000:d5dd (1000_D5CF / 0x1D5CF)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // ADD DI,0xe (1000_D5D1 / 0x1D5D1)
    DI += 0xE;
    // INC CX (1000_D5D4 / 0x1D5D4)
    CX++;
    // CMP CL,byte ptr [0xdce8] (1000_D5D5 / 0x1D5D5)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    // JC 0x1000:d5c7 (1000_D5D9 / 0x1D5D9)
    if(CarryFlag) {
      goto label_1000_D5C7_1D5C7;
    }
    label_1000_D5DB_1D5DB:
    // MOV CL,0xff (1000_D5DB / 0x1D5DB)
    CL = 0xFF;
    label_1000_D5DD_1D5DD:
    // MOV AL,CL (1000_D5DD / 0x1D5DD)
    AL = CL;
    // XCHG byte ptr [0xdce7],CL (1000_D5DF / 0x1D5DF)
    byte tmp_1000_D5DF = UInt8[DS, 0xDCE7];
    UInt8[DS, 0xDCE7] = CL;
    CL = tmp_1000_D5DF;
    // CMP AL,CL (1000_D5E3 / 0x1D5E3)
    Alu.Sub8(AL, CL);
    // JZ 0x1000:d610 (1000_D5E5 / 0x1D5E5)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0x1D610 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:dbb2 (1000_D5E7 / 0x1D5E7)
    NearCall(cs1, 0xD5EA, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_D5EA_1D5EA:
    // OR CL,CL (1000_D5EA / 0x1D5EA)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JS 0x1000:d5fc (1000_D5EC / 0x1D5EC)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0x1D5FC - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP CL,byte ptr [0xdce8] (1000_D5EE / 0x1D5EE)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    // JNC 0x1000:d5fc (1000_D5F2 / 0x1D5F2)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0x1D5FC - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_D5F4 / 0x1D5F4)
    Stack.Push(AX);
    // CALL 0x1000:d454 (1000_D5F5 / 0x1D5F5)
    NearCall(cs1, 0xD5F8, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D5F8_1D5F8:
    // CALL 0x1000:d48a (1000_D5F8 / 0x1D5F8)
    NearCall(cs1, 0xD5FB, spice86_generated_label_call_target_1000_D48A_01D48A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D5FB_01D5FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D5FB_01D5FB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD610: goto label_1000_D610_1D610;break; // Target of external jump from 0x1D5E5
      case 0xD5FC: goto label_1000_D5FC_1D5FC;break; // Target of external jump from 0x1D5EC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D5FB_1D5FB:
    // POP AX (1000_D5FB / 0x1D5FB)
    AX = Stack.Pop();
    label_1000_D5FC_1D5FC:
    // CMP AL,byte ptr [0xdce8] (1000_D5FC / 0x1D5FC)
    Alu.Sub8(AL, UInt8[DS, 0xDCE8]);
    // JNC 0x1000:d60d (1000_D600 / 0x1D600)
    if(!CarryFlag) {
      goto label_1000_D60D_1D60D;
    }
    // MOV CX,AX (1000_D602 / 0x1D602)
    CX = AX;
    // CALL 0x1000:d454 (1000_D604 / 0x1D604)
    NearCall(cs1, 0xD607, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D607_1D607:
    // OR AH,0x80 (1000_D607 / 0x1D607)
    // AH |= 0x80;
    AH = Alu.Or8(AH, 0x80);
    // CALL 0x1000:d48a (1000_D60A / 0x1D60A)
    NearCall(cs1, 0xD60D, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D60D_1D60D:
    // CALL 0x1000:dbec (1000_D60D / 0x1D60D)
    NearCall(cs1, 0xD610, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    label_1000_D610_1D610:
    // POP BP (1000_D610 / 0x1D610)
    BP = Stack.Pop();
    // POP DI (1000_D611 / 0x1D611)
    DI = Stack.Pop();
    // POP SI (1000_D612 / 0x1D612)
    SI = Stack.Pop();
    // POP DX (1000_D613 / 0x1D613)
    DX = Stack.Pop();
    // POP CX (1000_D614 / 0x1D614)
    CX = Stack.Pop();
    // POP BX (1000_D615 / 0x1D615)
    BX = Stack.Pop();
    // RET  (1000_D616 / 0x1D616)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_D617_01D617(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D617_1D617:
    // PUSH AX (1000_D617 / 0x1D617)
    Stack.Push(AX);
    // MOV AX,0x90 (1000_D618 / 0x1D618)
    AX = 0x90;
    // JMP 0x1000:d621 (1000_D61B / 0x1D61B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D61D_01D61D, 0x1D621 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D61D_01D61D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D61D_1D61D:
    // PUSH AX (1000_D61D / 0x1D61D)
    Stack.Push(AX);
    // MOV AX,0x9f (1000_D61E / 0x1D61E)
    AX = 0x9F;
    label_1000_D621_1D621:
    // CALL 0x1000:e270 (1000_D621 / 0x1D621)
    NearCall(cs1, 0xD624, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D624_01D624, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D624_01D624(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D624_1D624:
    // CALL 0x1000:d41b (1000_D624 / 0x1D624)
    NearCall(cs1, 0xD627, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_D627_1D627:
    // MOV SI,0x1f7e (1000_D627 / 0x1D627)
    SI = 0x1F7E;
    // CMP word ptr [SI + 0x2],AX (1000_D62A / 0x1D62A)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], AX);
    // MOV word ptr [SI + 0x2],AX (1000_D62D / 0x1D62D)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // JZ 0x1000:d649 (1000_D630 / 0x1D630)
    if(ZeroFlag) {
      goto label_1000_D649_1D649;
    }
    // CMP BP,SI (1000_D632 / 0x1D632)
    Alu.Sub16(BP, SI);
    // JNZ 0x1000:d649 (1000_D634 / 0x1D634)
    if(!ZeroFlag) {
      goto label_1000_D649_1D649;
    }
    // CALL 0x1000:dbb2 (1000_D636 / 0x1D636)
    NearCall(cs1, 0xD639, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // XOR CX,CX (1000_D639 / 0x1D639)
    CX = 0;
    // CALL 0x1000:d454 (1000_D63B / 0x1D63B)
    NearCall(cs1, 0xD63E, spice86_generated_label_call_target_1000_D454_01D454);
    // CALL 0x1000:d48a (1000_D63E / 0x1D63E)
    NearCall(cs1, 0xD641, spice86_generated_label_call_target_1000_D48A_01D48A);
    // MOV byte ptr [0xdce7],0xff (1000_D641 / 0x1D641)
    UInt8[DS, 0xDCE7] = 0xFF;
    // CALL 0x1000:dbec (1000_D646 / 0x1D646)
    NearCall(cs1, 0xD649, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    label_1000_D649_1D649:
    // CALL 0x1000:e283 (1000_D649 / 0x1D649)
    NearCall(cs1, 0xD64C, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_D64C_1D64C:
    // POP AX (1000_D64C / 0x1D64C)
    AX = Stack.Pop();
    // RET  (1000_D64D / 0x1D64D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D64E_01D64E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D64E_1D64E:
    // PUSH BX (1000_D64E / 0x1D64E)
    Stack.Push(BX);
    // PUSH DX (1000_D64F / 0x1D64F)
    Stack.Push(DX);
    // XOR BX,BX (1000_D650 / 0x1D650)
    BX = 0;
    // XOR DX,DX (1000_D652 / 0x1D652)
    DX = 0;
    // CALL 0x1000:d50f (1000_D654 / 0x1D654)
    NearCall(cs1, 0xD657, spice86_generated_label_call_target_1000_D50F_01D50F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D657_01D657, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D657_01D657(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D657_1D657:
    // POP DX (1000_D657 / 0x1D657)
    DX = Stack.Pop();
    // POP BX (1000_D658 / 0x1D658)
    BX = Stack.Pop();
    // RET  (1000_D659 / 0x1D659)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D65A_01D65A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D65A_1D65A:
    // TEST byte ptr [DI + 0x9],0x20 (1000_D65A / 0x1D65A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x9)], 0x20);
    // JZ 0x1000:d676 (1000_D65E / 0x1D65E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D676 / 0x1D676)
      return NearRet();
    }
    // MOV word ptr [0xdc60],DI (1000_D660 / 0x1D660)
    UInt16[DS, 0xDC60] = DI;
    // INC word ptr [DI + 0xa] (1000_D664 / 0x1D664)
    UInt16[DS, (ushort)(DI + 0xA)] = Alu.Inc16(UInt16[DS, (ushort)(DI + 0xA)]);
    // PUSH SI (1000_D667 / 0x1D667)
    Stack.Push(SI);
    // PUSH DI (1000_D668 / 0x1D668)
    Stack.Push(DI);
    // MOV SI,DI (1000_D669 / 0x1D669)
    SI = DI;
    // MOV CX,0x1 (1000_D66B / 0x1D66B)
    CX = 0x1;
    // CALL 0x1000:d1f2 (1000_D66E / 0x1D66E)
    NearCall(cs1, 0xD671, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // POP DI (1000_D671 / 0x1D671)
    DI = Stack.Pop();
    // POP SI (1000_D672 / 0x1D672)
    SI = Stack.Pop();
    // DEC word ptr [DI + 0xa] (1000_D673 / 0x1D673)
    UInt16[DS, (ushort)(DI + 0xA)] = Alu.Dec16(UInt16[DS, (ushort)(DI + 0xA)]);
    label_1000_D676_1D676:
    // RET  (1000_D676 / 0x1D676)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D694_01D694(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D694_1D694:
    // MOV AX,[0x2582] (1000_D694 / 0x1D694)
    AX = UInt16[DS, 0x2582];
    // MOV DI,0x1b9c (1000_D697 / 0x1D697)
    DI = 0x1B9C;
    // CMP AX,0x260c (1000_D69A / 0x1D69A)
    Alu.Sub16(AX, 0x260C);
    // JZ 0x1000:d6b5 (1000_D69D / 0x1D69D)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    // ADD DI,0xe (1000_D69F / 0x1D69F)
    DI += 0xE;
    // CMP AX,0x2650 (1000_D6A2 / 0x1D6A2)
    Alu.Sub16(AX, 0x2650);
    // JZ 0x1000:d6b5 (1000_D6A5 / 0x1D6A5)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    // ADD DI,0xe (1000_D6A7 / 0x1D6A7)
    DI += 0xE;
    // CMP AX,0x2694 (1000_D6AA / 0x1D6AA)
    Alu.Sub16(AX, 0x2694);
    // JZ 0x1000:d6b5 (1000_D6AD / 0x1D6AD)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    // ADD DI,0xe (1000_D6AF / 0x1D6AF)
    DI += 0xE;
    // CMP AX,0x26d8 (1000_D6B2 / 0x1D6B2)
    Alu.Sub16(AX, 0x26D8);
    label_1000_D6B5_1D6B5:
    // STC  (1000_D6B5 / 0x1D6B5)
    CarryFlag = true;
    // RET  (1000_D6B6 / 0x1D6B6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D6B7_01D6B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D6B7_1D6B7:
    // CALL 0x1000:d694 (1000_D6B7 / 0x1D6B7)
    NearCall(cs1, 0xD6BA, spice86_generated_label_call_target_1000_D694_01D694);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D6BA_01D6BA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D6BA_01D6BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D6BA_1D6BA:
    // JZ 0x1000:d6fd (1000_D6BA / 0x1D6BA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D6FD / 0x1D6FD)
      return NearRet();
    }
    // MOV DI,0x1ae4 (1000_D6BC / 0x1D6BC)
    DI = 0x1AE4;
    // MOV CX,word ptr [DI] (1000_D6BF / 0x1D6BF)
    CX = UInt16[DS, DI];
    // ADD DI,0x2 (1000_D6C1 / 0x1D6C1)
    DI += 0x2;
    // CMP word ptr [0x2570],0x1ad6 (1000_D6C4 / 0x1D6C4)
    Alu.Sub16(UInt16[DS, 0x2570], 0x1AD6);
    // JNZ 0x1000:d6cf (1000_D6CA / 0x1D6CA)
    if(!ZeroFlag) {
      goto label_1000_D6CF_1D6CF;
    }
    // SUB CX,0x5 (1000_D6CC / 0x1D6CC)
    CX -= 0x5;
    label_1000_D6CF_1D6CF:
    // CMP byte ptr [0x46d9],0x0 (1000_D6CF / 0x1D6CF)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JZ 0x1000:d6dc (1000_D6D4 / 0x1D6D4)
    if(ZeroFlag) {
      goto label_1000_D6DC_1D6DC;
    }
    // MOV CX,0x5 (1000_D6D6 / 0x1D6D6)
    CX = 0x5;
    // MOV DI,0x1b48 (1000_D6D9 / 0x1D6D9)
    DI = 0x1B48;
    label_1000_D6DC_1D6DC:
    // CMP byte ptr [DI + 0x8],0x0 (1000_D6DC / 0x1D6DC)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    // JNS 0x1000:d6f7 (1000_D6E0 / 0x1D6E0)
    if(!SignFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // CMP DX,word ptr [DI] (1000_D6E2 / 0x1D6E2)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JBE 0x1000:d6f7 (1000_D6E4 / 0x1D6E4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_D6E6 / 0x1D6E6)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JNC 0x1000:d6f7 (1000_D6E9 / 0x1D6E9)
    if(!CarryFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // CMP BX,word ptr [DI + 0x2] (1000_D6EB / 0x1D6EB)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JBE 0x1000:d6f7 (1000_D6EE / 0x1D6EE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // DEC BX (1000_D6F0 / 0x1D6F0)
    BX--;
    // CMP BX,word ptr [DI + 0x6] (1000_D6F1 / 0x1D6F1)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // INC BX (1000_D6F4 / 0x1D6F4)
    BX = Alu.Inc16(BX);
    // JC 0x1000:d6fd (1000_D6F5 / 0x1D6F5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_D6FD / 0x1D6FD)
      return NearRet();
    }
    label_1000_D6F7_1D6F7:
    // ADD DI,0xe (1000_D6F7 / 0x1D6F7)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    // LOOP 0x1000:d6dc (1000_D6FA / 0x1D6FA)
    if(--CX != 0) {
      goto label_1000_D6DC_1D6DC;
    }
    // CLC  (1000_D6FC / 0x1D6FC)
    CarryFlag = false;
    label_1000_D6FD_1D6FD:
    // RET  (1000_D6FD / 0x1D6FD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D6FE_01D6FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D6FE_1D6FE:
    // CMP DX,word ptr [DI] (1000_D6FE / 0x1D6FE)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JBE 0x1000:d710 (1000_D700 / 0x1D700)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D710_1D710;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_D702 / 0x1D702)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JNC 0x1000:d710 (1000_D705 / 0x1D705)
    if(!CarryFlag) {
      goto label_1000_D710_1D710;
    }
    // CMP BX,word ptr [DI + 0x2] (1000_D707 / 0x1D707)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JBE 0x1000:d710 (1000_D70A / 0x1D70A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D710_1D710;
    }
    // CMP BX,word ptr [DI + 0x6] (1000_D70C / 0x1D70C)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // RET  (1000_D70F / 0x1D70F)
    return NearRet();
    label_1000_D710_1D710:
    // CLC  (1000_D710 / 0x1D710)
    CarryFlag = false;
    // RET  (1000_D711 / 0x1D711)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D712_01D712(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D712_1D712:
    // MOV SI,0x1cca (1000_D712 / 0x1D712)
    SI = 0x1CCA;
    // JMP 0x1000:d72b (1000_D715 / 0x1D715)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D717_01D717(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D717_1D717:
    // CMP byte ptr [0x46eb],0x0 (1000_D717 / 0x1D717)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNZ 0x1000:d712 (1000_D71C / 0x1D71C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D712_01D712, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1c76 (1000_D71E / 0x1D71E)
    SI = 0x1C76;
    // TEST byte ptr [0x11c9],0x3 (1000_D721 / 0x1D721)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JZ 0x1000:d72b (1000_D726 / 0x1D726)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1d72 (1000_D728 / 0x1D728)
    SI = 0x1D72;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D72B_01D72B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D72B_1D72B:
    // PUSH DS (1000_D72B / 0x1D72B)
    Stack.Push(DS);
    // POP ES (1000_D72C / 0x1D72C)
    ES = Stack.Pop();
    // MOV DI,0x1b8e (1000_D72D / 0x1D72D)
    DI = 0x1B8E;
    // MOV CX,0x2a (1000_D730 / 0x1D730)
    CX = 0x2A;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_D733 / 0x1D733)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D735_01D735, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D735_01D735(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D735_1D735:
    // CALL 0x1000:d741 (1000_D735 / 0x1D735)
    NearCall(cs1, 0xD738, spice86_generated_label_call_target_1000_D741_01D741);
    label_1000_D738_1D738:
    // MOV SI,0x1b8e (1000_D738 / 0x1D738)
    SI = 0x1B8E;
    // MOV CX,0x6 (1000_D73B / 0x1D73B)
    CX = 0x6;
    // JMP 0x1000:d1f2 (1000_D73E / 0x1D73E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1F2_01D1F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D741_01D741(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D741_1D741:
    // MOV AX,[0x1b0c] (1000_D741 / 0x1D741)
    AX = UInt16[DS, 0x1B0C];
    // SUB AX,0x3 (1000_D744 / 0x1D744)
    AX -= 0x3;
    // CMP AX,0x3 (1000_D747 / 0x1D747)
    Alu.Sub16(AX, 0x3);
    // JNC 0x1000:d759 (1000_D74A / 0x1D74A)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_D759 / 0x1D759)
      return NearRet();
    }
    // MOV SI,0x2458 (1000_D74C / 0x1D74C)
    SI = 0x2458;
    // MOV ES,word ptr [0xdbd8] (1000_D74F / 0x1D74F)
    ES = UInt16[DS, 0xDBD8];
    // MOV AL,0xf0 (1000_D753 / 0x1D753)
    AL = 0xF0;
    // CALLF [0x38dd] (1000_D755 / 0x1D755)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_D755 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_D755) {
      case 0x235CE : FarCall(cs1, 0xD759, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D755));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D759_01D759, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D759_01D759(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D759_1D759:
    // RET  (1000_D759 / 0x1D759)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D75A_01D75A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D75A_1D75A:
    // MOV SI,0x1c36 (1000_D75A / 0x1D75A)
    SI = 0x1C36;
    // CALL 0x1000:d795 (1000_D75D / 0x1D75D)
    NearCall(cs1, 0xD760, spice86_generated_label_call_target_1000_D795_01D795);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D760_01D760, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D760_01D760(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D760_1D760:
    // CALL 0x1000:1a34 (1000_D760 / 0x1D760)
    NearCall(cs1, 0xD763, spice86_generated_label_call_target_1000_1A34_011A34);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D763_01D763(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D763_1D763:
    // MOV SI,0x1c0c (1000_D763 / 0x1D763)
    SI = 0x1C0C;
    // MOV AX,0x40 (1000_D766 / 0x1D766)
    AX = 0x40;
    // MOV word ptr [SI + 0xa],AX (1000_D769 / 0x1D769)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    // MOV word ptr [SI + 0x18],AX (1000_D76C / 0x1D76C)
    UInt16[DS, (ushort)(SI + 0x18)] = AX;
    // MOV CX,0x2 (1000_D76F / 0x1D76F)
    CX = 0x2;
    // CALL 0x1000:d1f2 (1000_D772 / 0x1D772)
    NearCall(cs1, 0xD775, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D775_01D775, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D775_01D775(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D775_1D775:
    // MOV SI,0x1c0c (1000_D775 / 0x1D775)
    SI = 0x1C0C;
    // MOV AL,[0x1152] (1000_D778 / 0x1D778)
    AL = UInt8[DS, 0x1152];
    // CBW  (1000_D77B / 0x1D77B)
    AX = (ushort)((short)((sbyte)AL));
    // ADD AX,0x41 (1000_D77C / 0x1D77C)
    // AX += 0x41;
    AX = Alu.Add16(AX, 0x41);
    // MOV word ptr [SI + 0xa],AX (1000_D77F / 0x1D77F)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    // MOV AL,[0x1153] (1000_D782 / 0x1D782)
    AL = UInt8[DS, 0x1153];
    // CBW  (1000_D785 / 0x1D785)
    AX = (ushort)((short)((sbyte)AL));
    // ADD AX,0x41 (1000_D786 / 0x1D786)
    // AX += 0x41;
    AX = Alu.Add16(AX, 0x41);
    // MOV word ptr [SI + 0x18],AX (1000_D789 / 0x1D789)
    UInt16[DS, (ushort)(SI + 0x18)] = AX;
    // MOV CX,0x2 (1000_D78C / 0x1D78C)
    CX = 0x2;
    // JMP 0x1000:d1f2 (1000_D78F / 0x1D78F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1F2_01D1F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D792_01D792(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D792_1D792:
    // MOV SI,0x1c66 (1000_D792 / 0x1D792)
    SI = 0x1C66;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D795_01D795, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D795_01D795(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D795_1D795:
    // PUSH DS (1000_D795 / 0x1D795)
    Stack.Push(DS);
    // POP ES (1000_D796 / 0x1D796)
    ES = Stack.Pop();
    // MOV DI,0x1aee (1000_D797 / 0x1D797)
    DI = 0x1AEE;
    // MOV CX,0x4 (1000_D79A / 0x1D79A)
    CX = 0x4;
    label_1000_D79D_1D79D:
    // MOVSW ES:DI,SI (1000_D79D / 0x1D79D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_D79E / 0x1D79E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // ADD DI,0xa (1000_D79F / 0x1D79F)
    // DI += 0xA;
    DI = Alu.Add16(DI, 0xA);
    // LOOP 0x1000:d79d (1000_D7A2 / 0x1D7A2)
    if(--CX != 0) {
      goto label_1000_D79D_1D79D;
    }
    // MOV SI,0x1ae6 (1000_D7A4 / 0x1D7A4)
    SI = 0x1AE6;
    // MOV CX,0x3 (1000_D7A7 / 0x1D7A7)
    CX = 0x3;
    // JMP 0x1000:d1f2 (1000_D7AA / 0x1D7AA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1F2_01D1F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D7AD_01D7AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D7AD_1D7AD:
    // MOV SI,0x1c56 (1000_D7AD / 0x1D7AD)
    SI = 0x1C56;
    // JMP 0x1000:d795 (1000_D7B0 / 0x1D7B0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D795_01D795, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D7B2_01D7B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D7B2_1D7B2:
    // MOV SI,0x1c46 (1000_D7B2 / 0x1D7B2)
    SI = 0x1C46;
    // JMP 0x1000:d795 (1000_D7B5 / 0x1D7B5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D795_01D795, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D7B7_01D7B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D7B7_1D7B7:
    // MOV AX,[0xce7a] (1000_D7B7 / 0x1D7B7)
    AX = UInt16[DS, 0xCE7A];
    // SHL AX,1 (1000_D7BA / 0x1D7BA)
    AX <<= 0x1;
    // SHL AX,1 (1000_D7BC / 0x1D7BC)
    AX <<= 0x1;
    // CMP AH,byte ptr [0xdcf1] (1000_D7BE / 0x1D7BE)
    Alu.Sub8(AH, UInt8[DS, 0xDCF1]);
    // JZ 0x1000:d814 (1000_D7C2 / 0x1D7C2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D814 / 0x1D814)
      return NearRet();
    }
    // MOV byte ptr [0xdcf1],AH (1000_D7C4 / 0x1D7C4)
    UInt8[DS, 0xDCF1] = AH;
    // MOV AX,[0x2222] (1000_D7C8 / 0x1D7C8)
    AX = UInt16[DS, 0x2222];
    // OR AX,AX (1000_D7CB / 0x1D7CB)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:d814 (1000_D7CD / 0x1D7CD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D814 / 0x1D814)
      return NearRet();
    }
    // MOV BX,word ptr [0x1152] (1000_D7CF / 0x1D7CF)
    BX = UInt16[DS, 0x1152];
    // PUSH BX (1000_D7D3 / 0x1D7D3)
    Stack.Push(BX);
    // OR AL,AL (1000_D7D4 / 0x1D7D4)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:d7e0 (1000_D7D6 / 0x1D7D6)
    if(ZeroFlag) {
      goto label_1000_D7E0_1D7E0;
    }
    // DEC AL (1000_D7D8 / 0x1D7D8)
    AL--;
    // TEST AL,0x1 (1000_D7DA / 0x1D7DA)
    Alu.And8(AL, 0x1);
    // JZ 0x1000:d7e0 (1000_D7DC / 0x1D7DC)
    if(ZeroFlag) {
      goto label_1000_D7E0_1D7E0;
    }
    // MOV BL,0xff (1000_D7DE / 0x1D7DE)
    BL = 0xFF;
    label_1000_D7E0_1D7E0:
    // OR AH,AH (1000_D7E0 / 0x1D7E0)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:d7ed (1000_D7E2 / 0x1D7E2)
    if(ZeroFlag) {
      goto label_1000_D7ED_1D7ED;
    }
    // DEC AH (1000_D7E4 / 0x1D7E4)
    AH--;
    // TEST AH,0x1 (1000_D7E6 / 0x1D7E6)
    Alu.And8(AH, 0x1);
    // JZ 0x1000:d7ed (1000_D7E9 / 0x1D7E9)
    if(ZeroFlag) {
      goto label_1000_D7ED_1D7ED;
    }
    // MOV BH,0xff (1000_D7EB / 0x1D7EB)
    BH = 0xFF;
    label_1000_D7ED_1D7ED:
    // MOV [0x2222],AX (1000_D7ED / 0x1D7ED)
    UInt16[DS, 0x2222] = AX;
    // MOV word ptr [0x1152],BX (1000_D7F0 / 0x1D7F0)
    UInt16[DS, 0x1152] = BX;
    // CMP word ptr [0x1afe],0x0 (1000_D7F4 / 0x1D7F4)
    Alu.Sub16(UInt16[DS, 0x1AFE], 0x0);
    // JNZ 0x1000:d810 (1000_D7FA / 0x1D7FA)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D809_01D809, 0x1D810 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH word ptr [0x2784] (1000_D7FC / 0x1D7FC)
    Stack.Push(UInt16[DS, 0x2784]);
    // CALL 0x1000:c137 (1000_D800 / 0x1D800)
    NearCall(cs1, 0xD803, spice86_generated_label_call_target_1000_C137_01C137);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D803_01D803, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D803_01D803(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D803_1D803:
    // CALL 0x1000:dbb2 (1000_D803 / 0x1D803)
    NearCall(cs1, 0xD806, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_D806_1D806:
    // CALL 0x1000:d763 (1000_D806 / 0x1D806)
    NearCall(cs1, 0xD809, spice86_generated_label_ret_target_1000_D763_01D763);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D809_01D809, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D809_01D809(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD810: goto label_1000_D810_1D810;break; // Target of external jump from 0x1D7FA
      case 0xD814: goto label_1000_D814_1D814;break; // Target of external jump from 0x1D7C2, 0x1D7CD
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D809_1D809:
    // CALL 0x1000:dbec (1000_D809 / 0x1D809)
    NearCall(cs1, 0xD80C, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    label_1000_D80C_1D80C:
    // POP AX (1000_D80C / 0x1D80C)
    AX = Stack.Pop();
    // CALL 0x1000:c13e (1000_D80D / 0x1D80D)
    NearCall(cs1, 0xD810, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_D810_1D810:
    // POP word ptr [0x1152] (1000_D810 / 0x1D810)
    UInt16[DS, 0x1152] = Stack.Pop();
    label_1000_D814_1D814:
    // RET  (1000_D814 / 0x1D814)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D815_01D815(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D815_1D815:
    // MOV AX,[0xce7a] (1000_D815 / 0x1D815)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc68],AX (1000_D818 / 0x1D818)
    UInt16[DS, 0xDC68] = AX;
    // MOV byte ptr [0xdc4b],0x0 (1000_D81B / 0x1D81B)
    UInt8[DS, 0xDC4B] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D820_01D820, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D820_01D820(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D820_1D820:
    // CMP byte ptr [0xcee8],0x2f (1000_D820 / 0x1D820)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x2F);
    // JNZ 0x1000:d831 (1000_D825 / 0x1D825)
    if(!ZeroFlag) {
      goto label_1000_D831_1D831;
    }
    // CMP byte ptr [0xce9e],0xff (1000_D827 / 0x1D827)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    // JNZ 0x1000:d831 (1000_D82C / 0x1D82C)
    if(!ZeroFlag) {
      goto label_1000_D831_1D831;
    }
    // CALL 0x1000:b270 (1000_D82E / 0x1D82E)
    NearCall(cs1, 0xD831, not_observed_1000_B270_01B270);
    label_1000_D831_1D831:
    // CMP byte ptr [0x46d9],0x0 (1000_D831 / 0x1D831)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JNZ 0x1000:d83e (1000_D836 / 0x1D836)
    if(!ZeroFlag) {
      goto label_1000_D83E_1D83E;
    }
    // CALL 0x1000:d7b7 (1000_D838 / 0x1D838)
    NearCall(cs1, 0xD83B, spice86_generated_label_call_target_1000_D7B7_01D7B7);
    label_1000_D83B_1D83B:
    // CALL 0x1000:1b0d (1000_D83B / 0x1D83B)
    NearCall(cs1, 0xD83E, spice86_generated_label_call_target_1000_1B0D_011B0D);
    label_1000_D83E_1D83E:
    // CALL 0x1000:d9d2 (1000_D83E / 0x1D83E)
    NearCall(cs1, 0xD841, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    label_1000_D841_1D841:
    // CMP byte ptr [0x46d9],0x0 (1000_D841 / 0x1D841)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JZ 0x1000:d84b (1000_D846 / 0x1D846)
    if(ZeroFlag) {
      goto label_1000_D84B_1D84B;
    }
    // CALL 0x1000:0d8e (1000_D848 / 0x1D848)
    NearCall(cs1, 0xD84B, not_observed_1000_0D8E_010D8E);
    label_1000_D84B_1D84B:
    // CALL 0x1000:e3cc (1000_D84B / 0x1D84B)
    NearCall(cs1, 0xD84E, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    label_1000_D84E_1D84E:
    // MOV [0x0],AX (1000_D84E / 0x1D84E)
    UInt16[DS, 0x0] = AX;
    // CALL 0x1000:4f0c (1000_D851 / 0x1D851)
    NearCall(cs1, 0xD854, spice86_generated_label_call_target_1000_4F0C_014F0C);
    label_1000_D854_1D854:
    // CMP byte ptr [0xdc4b],0x0 (1000_D854 / 0x1D854)
    Alu.Sub8(UInt8[DS, 0xDC4B], 0x0);
    // JZ 0x1000:d860 (1000_D859 / 0x1D859)
    if(ZeroFlag) {
      goto label_1000_D860_1D860;
    }
    // CALL 0x1000:d962 (1000_D85B / 0x1D85B)
    NearCall(cs1, 0xD85E, not_observed_1000_D962_01D962);
    // JMP 0x1000:d866 (1000_D85E / 0x1D85E)
    goto label_1000_D866_1D866;
    label_1000_D860_1D860:
    // CALL 0x1000:df1e (1000_D860 / 0x1D860)
    NearCall(cs1, 0xD863, spice86_generated_label_call_target_1000_DF1E_01DF1E);
    label_1000_D863_1D863:
    // CALL 0x1000:db4c (1000_D863 / 0x1D863)
    NearCall(cs1, 0xD866, spice86_generated_label_call_target_1000_DB4C_01DB4C);
    label_1000_D866_1D866:
    // CALL 0x1000:dc20 (1000_D866 / 0x1D866)
    NearCall(cs1, 0xD869, spice86_generated_label_call_target_1000_DC20_01DC20);
    label_1000_D869_1D869:
    // MOV DI,DX (1000_D869 / 0x1D869)
    DI = DX;
    // XCHG word ptr [0xdc62],DI (1000_D86B / 0x1D86B)
    ushort tmp_1000_D86B = UInt16[DS, 0xDC62];
    UInt16[DS, 0xDC62] = DI;
    DI = tmp_1000_D86B;
    // MOV CX,BX (1000_D86F / 0x1D86F)
    CX = BX;
    // XCHG word ptr [0xdc64],CX (1000_D871 / 0x1D871)
    ushort tmp_1000_D871 = UInt16[DS, 0xDC64];
    UInt16[DS, 0xDC64] = CX;
    CX = tmp_1000_D871;
    // SUB DI,DX (1000_D875 / 0x1D875)
    DI -= DX;
    // SUB CX,BX (1000_D877 / 0x1D877)
    CX -= BX;
    // NEG DI (1000_D879 / 0x1D879)
    DI = Alu.Sub16(0, DI);
    // NEG CX (1000_D87B / 0x1D87B)
    CX = Alu.Sub16(0, CX);
    // MOV SI,word ptr [0x2570] (1000_D87D / 0x1D87D)
    SI = UInt16[DS, 0x2570];
    // AND AX,0xf (1000_D881 / 0x1D881)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // JNZ 0x1000:d893 (1000_D884 / 0x1D884)
    if(!ZeroFlag) {
      goto label_1000_D893_1D893;
    }
    // CALL 0x1000:d50f (1000_D886 / 0x1D886)
    NearCall(cs1, 0xD889, spice86_generated_label_call_target_1000_D50F_01D50F);
    label_1000_D889_1D889:
    // MOV AX,CX (1000_D889 / 0x1D889)
    AX = CX;
    // OR AX,DI (1000_D88B / 0x1D88B)
    // AX |= DI;
    AX = Alu.Or16(AX, DI);
    // JZ 0x1000:d88f (1000_D88D / 0x1D88D)
    if(ZeroFlag) {
      goto label_1000_D88F_1D88F;
    }
    label_1000_D88F_1D88F:
    // CALL word ptr [SI] (1000_D88F / 0x1D88F)
    // Indirect call to word ptr [SI], generating possible targets from emulator records
    uint targetAddress_1000_D88F = (uint)(UInt16[DS, SI]);
    switch(targetAddress_1000_D88F) {
      case 0x1AE7 : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_1AE7_011AE7); break;
      case 0xF66 : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x4586 : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_4586_014586); break;
      case 0x5C03 : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_5C03_015C03); break;
      case 0xBC1F : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_BC1F_01BC1F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D88F));
        break;
    }
    label_1000_D891_1D891:
    // JMP 0x1000:d820 (1000_D891 / 0x1D891)
    goto label_1000_D820_1D820;
    label_1000_D893_1D893:
    // MOV BP,word ptr [0xce7a] (1000_D893 / 0x1D893)
    BP = UInt16[DS, 0xCE7A];
    // MOV word ptr [0xdc5a],BP (1000_D897 / 0x1D897)
    UInt16[DS, 0xDC5A] = BP;
    // CMP byte ptr [0x4774],0x0 (1000_D89B / 0x1D89B)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:d8b1 (1000_D8A0 / 0x1D8A0)
    if(ZeroFlag) {
      goto label_1000_D8B1_1D8B1;
    }
    // AND AL,0x5 (1000_D8A2 / 0x1D8A2)
    AL &= 0x5;
    // CMP AL,0x5 (1000_D8A4 / 0x1D8A4)
    Alu.Sub8(AL, 0x5);
    // JNZ 0x1000:d8d7 (1000_D8A6 / 0x1D8A6)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    // CALL 0x1000:dbb2 (1000_D8A8 / 0x1D8A8)
    NearCall(cs1, 0xD8AB, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:1707 (1000_D8AB / 0x1D8AB)
    NearCall(cs1, 0xD8AE, not_observed_1000_1707_011707);
    // JMP 0x1000:d820 (1000_D8AE / 0x1D8AE)
    goto label_1000_D820_1D820;
    label_1000_D8B1_1D8B1:
    // TEST AL,0x5 (1000_D8B1 / 0x1D8B1)
    Alu.And8(AL, 0x5);
    // JNZ 0x1000:d8ba (1000_D8B3 / 0x1D8B3)
    if(!ZeroFlag) {
      goto label_1000_D8BA_1D8BA;
    }
    // ADD SI,0x2 (1000_D8B5 / 0x1D8B5)
    SI += 0x2;
    // SHR AX,1 (1000_D8B8 / 0x1D8B8)
    AX >>= 0x1;
    label_1000_D8BA_1D8BA:
    // AND AL,0x5 (1000_D8BA / 0x1D8BA)
    AL &= 0x5;
    // DEC AL (1000_D8BC / 0x1D8BC)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:d8f4 (1000_D8BE / 0x1D8BE)
    if(!ZeroFlag) {
      goto label_1000_D8F4_1D8F4;
    }
    // MOV BP,word ptr [0xdc5c] (1000_D8C0 / 0x1D8C0)
    BP = UInt16[DS, 0xDC5C];
    // OR BP,BP (1000_D8C4 / 0x1D8C4)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JNZ 0x1000:d8da (1000_D8C6 / 0x1D8C6)
    if(!ZeroFlag) {
      goto label_1000_D8DA_1D8DA;
    }
    // MOV AX,CX (1000_D8C8 / 0x1D8C8)
    AX = CX;
    // OR AX,DI (1000_D8CA / 0x1D8CA)
    // AX |= DI;
    AX = Alu.Or16(AX, DI);
    // JZ 0x1000:d8d7 (1000_D8CC / 0x1D8CC)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    // CALL 0x1000:dbb2 (1000_D8CE / 0x1D8CE)
    NearCall(cs1, 0xD8D1, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_D8D1_1D8D1:
    // MOV AL,[0xdc35] (1000_D8D1 / 0x1D8D1)
    AL = UInt8[DS, 0xDC35];
    // CALL word ptr [SI + 0xa] (1000_D8D4 / 0x1D8D4)
    // Indirect call to word ptr [SI + 0xa], generating possible targets from emulator records
    uint targetAddress_1000_D8D4 = (uint)(UInt16[DS, (ushort)(SI + 0xA)]);
    switch(targetAddress_1000_D8D4) {
      case 0xD917 : NearCall(cs1, 0xD8D7, spice86_generated_label_call_target_1000_D917_01D917); break;
      case 0x59C1 : NearCall(cs1, 0xD8D7, spice86_generated_label_call_target_1000_59C1_0159C1); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D8D4));
        break;
    }
    label_1000_D8D7_1D8D7:
    // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
    goto label_1000_D820_1D820;
    label_1000_D8DA_1D8DA:
    // MOV AX,[0xce7a] (1000_D8DA / 0x1D8DA)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,word ptr [0xdc5e] (1000_D8DD / 0x1D8DD)
    AX -= UInt16[DS, 0xDC5E];
    // CMP AX,0x32 (1000_D8E1 / 0x1D8E1)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:d8d7 (1000_D8E4 / 0x1D8E4)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    // CALL 0x1000:d6b7 (1000_D8E6 / 0x1D8E6)
    NearCall(cs1, 0xD8E9, spice86_generated_label_call_target_1000_D6B7_01D6B7);
    label_1000_D8E9_1D8E9:
    // JNC 0x1000:d8d7 (1000_D8E9 / 0x1D8E9)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    // CMP DI,BP (1000_D8EB / 0x1D8EB)
    Alu.Sub16(DI, BP);
    // JNZ 0x1000:d8d7 (1000_D8ED / 0x1D8ED)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    // CALL 0x1000:dbb2 (1000_D8EF / 0x1D8EF)
    NearCall(cs1, 0xD8F2, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_D8F2_1D8F2:
    // JMP 0x1000:d92b (1000_D8F2 / 0x1D8F2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D918_01D918, 0x1D92B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D8F4_1D8F4:
    // CALL 0x1000:dbb2 (1000_D8F4 / 0x1D8F4)
    NearCall(cs1, 0xD8F7, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_D8F7_1D8F7:
    // CALL 0x1000:e26f (1000_D8F7 / 0x1D8F7)
    NearCall(cs1, 0xD8FA, spice86_generated_label_call_target_1000_E26F_01E26F);
    label_1000_D8FA_1D8FA:
    // SUB AL,0x3 (1000_D8FA / 0x1D8FA)
    // AL -= 0x3;
    AL = Alu.Sub8(AL, 0x3);
    // JZ 0x1000:d944 (1000_D8FC / 0x1D8FC)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D918_01D918, 0x1D944 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP SI,word ptr [0x2570] (1000_D8FE / 0x1D8FE)
    Alu.Sub16(SI, UInt16[DS, 0x2570]);
    // JNZ 0x1000:d90e (1000_D902 / 0x1D902)
    if(!ZeroFlag) {
      goto label_1000_D90E_1D90E;
    }
    // CALL 0x1000:d6b7 (1000_D904 / 0x1D904)
    NearCall(cs1, 0xD907, spice86_generated_label_call_target_1000_D6B7_01D6B7);
    label_1000_D907_1D907:
    // JC 0x1000:d918 (1000_D907 / 0x1D907)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D918_01D918, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH SI (1000_D909 / 0x1D909)
    Stack.Push(SI);
    // CALL 0x1000:9215 (1000_D90A / 0x1D90A)
    NearCall(cs1, 0xD90D, spice86_generated_label_call_target_1000_9215_019215);
    label_1000_D90D_1D90D:
    // POP SI (1000_D90D / 0x1D90D)
    SI = Stack.Pop();
    label_1000_D90E_1D90E:
    // MOV AL,[0xdc35] (1000_D90E / 0x1D90E)
    AL = UInt8[DS, 0xDC35];
    // CALL word ptr [SI + 0x2] (1000_D911 / 0x1D911)
    // Indirect call to word ptr [SI + 0x2], generating possible targets from emulator records
    uint targetAddress_1000_D911 = (uint)(UInt16[DS, (ushort)(SI + 0x2)]);
    switch(targetAddress_1000_D911) {
      case 0xD917 : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_D917_01D917); break;
      case 0xA576 : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_A576_01A576); break;
      case 0x450E : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_450E_01450E); break;
      case 0x5C76 : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_5C76_015C76); break;
      case 0xBC64 : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_BC64_01BC64); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D911));
        break;
    }
    label_1000_D914_1D914:
    // JMP 0x1000:d820 (1000_D914 / 0x1D914)
    goto label_1000_D820_1D820;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D917_01D917(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D917_1D917:
    // RET  (1000_D917 / 0x1D917)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D918_01D918(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD944: goto label_1000_D944_1D944;break; // Target of external jump from 0x1D8FC
      case 0xD92B: goto label_1000_D92B_1D92B;break; // Target of external jump from 0x1D950, 0x1D923, 0x1D8F2
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D918_1D918:
    // MOV word ptr [0xdc60],DI (1000_D918 / 0x1D918)
    UInt16[DS, 0xDC60] = DI;
    // CALL 0x1000:d65a (1000_D91C / 0x1D91C)
    NearCall(cs1, 0xD91F, spice86_generated_label_call_target_1000_D65A_01D65A);
    label_1000_D91F_1D91F:
    // TEST byte ptr [DI + 0x9],0x40 (1000_D91F / 0x1D91F)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x9)], 0x40);
    // JZ 0x1000:d92b (1000_D923 / 0x1D923)
    if(ZeroFlag) {
      goto label_1000_D92B_1D92B;
    }
    // MOV word ptr [0xdc5c],DI (1000_D925 / 0x1D925)
    UInt16[DS, 0xDC5C] = DI;
    // JMP 0x1000:d935 (1000_D929 / 0x1D929)
    goto label_1000_D935_1D935;
    label_1000_D92B_1D92B:
    // MOV byte ptr [0xce9d],0x0 (1000_D92B / 0x1D92B)
    UInt8[DS, 0xCE9D] = 0x0;
    // MOV byte ptr [0xceba],0x0 (1000_D930 / 0x1D930)
    UInt8[DS, 0xCEBA] = 0x0;
    label_1000_D935_1D935:
    // MOV AX,[0xce7a] (1000_D935 / 0x1D935)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc5e],AX (1000_D938 / 0x1D938)
    UInt16[DS, 0xDC5E] = AX;
    // MOV AL,[0xdc35] (1000_D93B / 0x1D93B)
    AL = UInt8[DS, 0xDC35];
    // CALL word ptr [DI + 0xc] (1000_D93E / 0x1D93E)
    // Indirect call to word ptr [DI + 0xc], generating possible targets from emulator records
    uint targetAddress_1000_D93E = (uint)(UInt16[DS, (ushort)(DI + 0xC)]);
    switch(targetAddress_1000_D93E) {
      case 0xD43E : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D43E_01D43E); break;
      case 0xD434 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D434_01D434); break;
      case 0xD443 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D443_01D443); break;
      case 0xD42F : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D42F_01D42F); break;
      case 0x945B : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_945B_01945B); break;
      case 0x3F15 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_3F15_013F15); break;
      case 0x941D : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_941D_01941D); break;
      case 0x3F1F : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_3F1F_013F1F); break;
      case 0x3F1A : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_3F1A_013F1A); break;
      case 0x18EE : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_18EE_0118EE); break;
      case 0x3F24 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_3F24_013F24); break;
      case 0xAED6 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_AED6_01AED6); break;
      case 0xB1EE : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_B1EE_01B1EE); break;
      case 0xD439 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D439_01D439); break;
      case 0x4AD0 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_4AD0_014AD0); break;
      case 0x4AD7 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_4AD7_014AD7); break;
      case 0x9215 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_9215_019215); break;
      case 0x882E : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_882E_01882E); break;
      case 0x5B05 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_5B05_015B05); break;
      case 0xB8C6 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_B8C6_01B8C6); break;
      case 0xB9D3 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_B9D3_01B9D3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D93E));
        break;
    }
    label_1000_D941_1D941:
    // JMP 0x1000:d820 (1000_D941 / 0x1D941)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D820_01D820, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D944_1D944:
    // MOV DI,word ptr [0xdc5c] (1000_D944 / 0x1D944)
    DI = UInt16[DS, 0xDC5C];
    // MOV word ptr [0xdc5c],0x0 (1000_D948 / 0x1D948)
    UInt16[DS, 0xDC5C] = 0x0;
    // OR DI,DI (1000_D94E / 0x1D94E)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:d92b (1000_D950 / 0x1D950)
    if(!ZeroFlag) {
      goto label_1000_D92B_1D92B;
    }
    // MOV AL,[0xdc35] (1000_D952 / 0x1D952)
    AL = UInt8[DS, 0xDC35];
    // CALL word ptr [SI + 0x6] (1000_D955 / 0x1D955)
    // Indirect call to word ptr [SI + 0x6], generating possible targets from emulator records
    uint targetAddress_1000_D955 = (uint)(UInt16[DS, (ushort)(SI + 0x6)]);
    switch(targetAddress_1000_D955) {
      case 0xA5AA : NearCall(cs1, 0xD958, spice86_generated_label_call_target_1000_A5AA_01A5AA); break;
      case 0xD917 : NearCall(cs1, 0xD958, spice86_generated_label_call_target_1000_D917_01D917); break;
      case 0xF66 : NearCall(cs1, 0xD958, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x599F : NearCall(cs1, 0xD958, spice86_generated_label_call_target_1000_599F_01599F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D955));
        break;
    }
    label_1000_D958_1D958:
    // JMP 0x1000:d820 (1000_D958 / 0x1D958)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D820_01D820, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D95B_01D95B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D95B_1D95B:
    // MOV AX,0x2572 (1000_D95B / 0x1D95B)
    AX = 0x2572;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D95E_01D95E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D95E_01D95E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D95E_1D95E:
    // MOV [0x2570],AX (1000_D95E / 0x1D95E)
    UInt16[DS, 0x2570] = AX;
    // RET  (1000_D961 / 0x1D961)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_D962_01D962(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D962_1D962:
    // MOV AX,[0xce7a] (1000_D962 / 0x1D962)
    AX = UInt16[DS, 0xCE7A];
    // SUB AL,byte ptr [0xdc4a] (1000_D965 / 0x1D965)
    AL -= UInt8[DS, 0xDC4A];
    // CMP AL,0x6 (1000_D969 / 0x1D969)
    Alu.Sub8(AL, 0x6);
    // JC 0x1000:d9cf (1000_D96B / 0x1D96B)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      // JMP 0x1000:db4c (1000_D9CF / 0x1D9CF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB4C_01DB4C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,0x2 (1000_D96D / 0x1D96D)
    CX = 0x2;
    // CMP AL,0xc (1000_D970 / 0x1D970)
    Alu.Sub8(AL, 0xC);
    // JC 0x1000:d97a (1000_D972 / 0x1D972)
    if(CarryFlag) {
      goto label_1000_D97A_1D97A;
    }
    // DEC CX (1000_D974 / 0x1D974)
    CX--;
    // CMP AL,0x18 (1000_D975 / 0x1D975)
    Alu.Sub8(AL, 0x18);
    // JC 0x1000:d97a (1000_D977 / 0x1D977)
    if(CarryFlag) {
      goto label_1000_D97A_1D97A;
    }
    // DEC CX (1000_D979 / 0x1D979)
    CX = Alu.Dec16(CX);
    label_1000_D97A_1D97A:
    // MOV AX,[0xce7a] (1000_D97A / 0x1D97A)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc4a],AL (1000_D97D / 0x1D97D)
    UInt8[DS, 0xDC4A] = AL;
    // DEC byte ptr [0xdc4b] (1000_D980 / 0x1D980)
    UInt8[DS, 0xDC4B] = Alu.Dec8(UInt8[DS, 0xDC4B]);
    // MOV DX,word ptr [0xdc4c] (1000_D984 / 0x1D984)
    DX = UInt16[DS, 0xDC4C];
    // MOV BX,word ptr [0xdc4e] (1000_D988 / 0x1D988)
    BX = UInt16[DS, 0xDC4E];
    // SUB DX,word ptr [0xdc36] (1000_D98C / 0x1D98C)
    // DX -= UInt16[DS, 0xDC36];
    DX = Alu.Sub16(DX, UInt16[DS, 0xDC36]);
    // JZ 0x1000:d9a3 (1000_D990 / 0x1D990)
    if(ZeroFlag) {
      goto label_1000_D9A3_1D9A3;
    }
    // JCXZ 0x1000:d99b (1000_D992 / 0x1D992)
    if(CX == 0) {
      goto label_1000_D99B_1D99B;
    }
    // SAR DX,CL (1000_D994 / 0x1D994)
    DX = Alu.Sar16(DX, CL);
    // OR DL,0x1 (1000_D996 / 0x1D996)
    // DL |= 0x1;
    DL = Alu.Or8(DL, 0x1);
    // JMP 0x1000:d9a3 (1000_D999 / 0x1D999)
    goto label_1000_D9A3_1D9A3;
    label_1000_D99B_1D99B:
    // MOV AX,DX (1000_D99B / 0x1D99B)
    AX = DX;
    // SAR AX,1 (1000_D99D / 0x1D99D)
    AX = Alu.Sar16(AX, 0x1);
    // SAR AX,1 (1000_D99F / 0x1D99F)
    AX = Alu.Sar16(AX, 0x1);
    // SUB DX,AX (1000_D9A1 / 0x1D9A1)
    DX -= AX;
    label_1000_D9A3_1D9A3:
    // SUB BX,word ptr [0xdc38] (1000_D9A3 / 0x1D9A3)
    // BX -= UInt16[DS, 0xDC38];
    BX = Alu.Sub16(BX, UInt16[DS, 0xDC38]);
    // JZ 0x1000:d9ba (1000_D9A7 / 0x1D9A7)
    if(ZeroFlag) {
      goto label_1000_D9BA_1D9BA;
    }
    // JCXZ 0x1000:d9b2 (1000_D9A9 / 0x1D9A9)
    if(CX == 0) {
      goto label_1000_D9B2_1D9B2;
    }
    // SAR BX,CL (1000_D9AB / 0x1D9AB)
    BX = Alu.Sar16(BX, CL);
    // OR BL,0x1 (1000_D9AD / 0x1D9AD)
    // BL |= 0x1;
    BL = Alu.Or8(BL, 0x1);
    // JMP 0x1000:d9ba (1000_D9B0 / 0x1D9B0)
    goto label_1000_D9BA_1D9BA;
    label_1000_D9B2_1D9B2:
    // MOV AX,BX (1000_D9B2 / 0x1D9B2)
    AX = BX;
    // SAR AX,1 (1000_D9B4 / 0x1D9B4)
    AX = Alu.Sar16(AX, 0x1);
    // SAR AX,1 (1000_D9B6 / 0x1D9B6)
    AX = Alu.Sar16(AX, 0x1);
    // SUB BX,AX (1000_D9B8 / 0x1D9B8)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    label_1000_D9BA_1D9BA:
    // MOV AX,BX (1000_D9BA / 0x1D9BA)
    AX = BX;
    // OR AX,DX (1000_D9BC / 0x1D9BC)
    // AX |= DX;
    AX = Alu.Or16(AX, DX);
    // JNZ 0x1000:d9c7 (1000_D9BE / 0x1D9BE)
    if(!ZeroFlag) {
      goto label_1000_D9C7_1D9C7;
    }
    // MOV byte ptr [0xdc4b],0x0 (1000_D9C0 / 0x1D9C0)
    UInt8[DS, 0xDC4B] = 0x0;
    // JMP 0x1000:d9cf (1000_D9C5 / 0x1D9C5)
    // JMP target is JMP, inlining.
    // JMP 0x1000:db4c (1000_D9CF / 0x1D9CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB4C_01DB4C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D9C7_1D9C7:
    // CALL 0x1000:daaf (1000_D9C7 / 0x1D9C7)
    NearCall(cs1, 0xD9CA, not_observed_1000_DAAF_01DAAF);
    // MOV byte ptr [0xdc34],0x0 (1000_D9CA / 0x1D9CA)
    UInt8[DS, 0xDC34] = 0x0;
    label_1000_D9CF_1D9CF:
    // JMP 0x1000:db4c (1000_D9CF / 0x1D9CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB4C_01DB4C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D9D2_01D9D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D9D2_1D9D2:
    // CALL 0x1000:ace6 (1000_D9D2 / 0x1D9D2)
    NearCall(cs1, 0xD9D5, spice86_generated_label_call_target_1000_ACE6_01ACE6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D9D5_01D9D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D9D5_01D9D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D9D5_1D9D5:
    // MOV AX,[0xce7a] (1000_D9D5 / 0x1D9D5)
    AX = UInt16[DS, 0xCE7A];
    // MOV CX,AX (1000_D9D8 / 0x1D9D8)
    CX = AX;
    // MOV BX,AX (1000_D9DA / 0x1D9DA)
    BX = AX;
    // MOV SI,0xdc68 (1000_D9DC / 0x1D9DC)
    SI = 0xDC68;
    // XCHG word ptr [SI],CX (1000_D9DF / 0x1D9DF)
    ushort tmp_1000_D9DF = UInt16[DS, SI];
    UInt16[DS, SI] = CX;
    CX = tmp_1000_D9DF;
    // SUB BX,CX (1000_D9E1 / 0x1D9E1)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // MOV CX,word ptr [SI + 0x2] (1000_D9E3 / 0x1D9E3)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    // JCXZ 0x1000:da03 (1000_D9E6 / 0x1D9E6)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_DA03 / 0x1DA03)
      return NearRet();
    }
    // ADD SI,0x4 (1000_D9E8 / 0x1D9E8)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D9EB_01D9EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D9EB_01D9EB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDA03: goto label_1000_DA03_1DA03;break; // Target of external jump from 0x1D9E6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D9EB_1D9EB:
    // LODSW SI (1000_D9EB / 0x1D9EB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BP,AX (1000_D9EC / 0x1D9EC)
    BP = AX;
    // MOV AX,BX (1000_D9EE / 0x1D9EE)
    AX = BX;
    // ADD AX,word ptr [SI] (1000_D9F0 / 0x1D9F0)
    AX += UInt16[DS, SI];
    // CMP AX,BP (1000_D9F2 / 0x1D9F2)
    Alu.Sub16(AX, BP);
    // JNC 0x1000:da04 (1000_D9F4 / 0x1D9F4)
    if(!CarryFlag) {
      goto label_1000_DA04_1DA04;
    }
    // MOV word ptr [SI],AX (1000_D9F6 / 0x1D9F6)
    UInt16[DS, SI] = AX;
    // ADD SI,0x4 (1000_D9F8 / 0x1D9F8)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LOOP 0x1000:d9eb (1000_D9FB / 0x1D9FB)
    if(--CX != 0) {
      goto label_1000_D9EB_1D9EB;
    }
    label_1000_D9FD_1D9FD:
    // MOV word ptr [0xdc66],0x0 (1000_D9FD / 0x1D9FD)
    UInt16[DS, 0xDC66] = 0x0;
    label_1000_DA03_1DA03:
    // RET  (1000_DA03 / 0x1DA03)
    return NearRet();
    label_1000_DA04_1DA04:
    // OR BP,BP (1000_DA04 / 0x1DA04)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JZ 0x1000:da0e (1000_DA06 / 0x1DA06)
    if(ZeroFlag) {
      goto label_1000_DA0E_1DA0E;
    }
    // XOR DX,DX (1000_DA08 / 0x1DA08)
    DX = 0;
    // DIV BP (1000_DA0A / 0x1DA0A)
    Cpu.Div16(BP);
    // MOV word ptr [SI],DX (1000_DA0C / 0x1DA0C)
    UInt16[DS, SI] = DX;
    label_1000_DA0E_1DA0E:
    // SUB SI,0x2 (1000_DA0E / 0x1DA0E)
    // SI -= 0x2;
    SI = Alu.Sub16(SI, 0x2);
    // PUSH BX (1000_DA11 / 0x1DA11)
    Stack.Push(BX);
    // PUSH CX (1000_DA12 / 0x1DA12)
    Stack.Push(CX);
    // PUSH SI (1000_DA13 / 0x1DA13)
    Stack.Push(SI);
    // MOV word ptr [0xdc66],SP (1000_DA14 / 0x1DA14)
    UInt16[DS, 0xDC66] = SP;
    // CALL word ptr [SI + 0x4] (1000_DA18 / 0x1DA18)
    // Indirect call to word ptr [SI + 0x4], generating possible targets from emulator records
    uint targetAddress_1000_DA18 = (uint)(UInt16[DS, (ushort)(SI + 0x4)]);
    switch(targetAddress_1000_DA18) {
      case 0xB9AE : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_B9AE_01B9AE); break;
      case 0x99BE : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_99BE_0199BE); break;
      case 0x3916 : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_3916_013916); break;
      case 0x46B5 : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_46B5_0146B5); break;
      case 0x44AB : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_44AB_0144AB); break;
      case 0x6B34 : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_6B34_016B34); break;
      case 0xBE57 : NearCall(cs1, 0xDA1B, spice86_generated_label_ret_target_1000_BE57_01BE57); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DA18));
        break;
    }
    label_1000_DA1B_1DA1B:
    // POP SI (1000_DA1B / 0x1DA1B)
    SI = Stack.Pop();
    // POP CX (1000_DA1C / 0x1DA1C)
    CX = Stack.Pop();
    // POP BX (1000_DA1D / 0x1DA1D)
    BX = Stack.Pop();
    // ADD SI,0x6 (1000_DA1E / 0x1DA1E)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    // LOOP 0x1000:d9eb (1000_DA21 / 0x1DA21)
    if(--CX != 0) {
      goto label_1000_D9EB_1D9EB;
    }
    // JMP 0x1000:d9fd (1000_DA23 / 0x1DA23)
    goto label_1000_D9FD_1D9FD;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DA25_01DA25(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DA25_1DA25:
    // PUSH DS (1000_DA25 / 0x1DA25)
    Stack.Push(DS);
    // POP ES (1000_DA26 / 0x1DA26)
    ES = Stack.Pop();
    // MOV DI,0xdc6a (1000_DA27 / 0x1DA27)
    DI = 0xDC6A;
    // MOV AX,word ptr [DI] (1000_DA2A / 0x1DA2A)
    AX = UInt16[DS, DI];
    // INC AX (1000_DA2C / 0x1DA2C)
    AX++;
    // CMP AX,0x14 (1000_DA2D / 0x1DA2D)
    Alu.Sub16(AX, 0x14);
    // JA 0x1000:da52 (1000_DA30 / 0x1DA30)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_DA52 / 0x1DA52)
      return NearRet();
    }
    // STOSW ES:DI (1000_DA32 / 0x1DA32)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // DEC AX (1000_DA33 / 0x1DA33)
    AX--;
    // ADD AX,AX (1000_DA34 / 0x1DA34)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // MOV BX,AX (1000_DA36 / 0x1DA36)
    BX = AX;
    // ADD AX,AX (1000_DA38 / 0x1DA38)
    AX += AX;
    // ADD AX,BX (1000_DA3A / 0x1DA3A)
    AX += BX;
    // ADD DI,AX (1000_DA3C / 0x1DA3C)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV AX,BP (1000_DA3E / 0x1DA3E)
    AX = BP;
    // STOSW ES:DI (1000_DA40 / 0x1DA40)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // XOR AX,AX (1000_DA41 / 0x1DA41)
    AX = 0;
    // STOSW ES:DI (1000_DA43 / 0x1DA43)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AX,SI (1000_DA44 / 0x1DA44)
    AX = SI;
    // STOSW ES:DI (1000_DA46 / 0x1DA46)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV BP,word ptr [0xdc66] (1000_DA47 / 0x1DA47)
    BP = UInt16[DS, 0xDC66];
    // OR BP,BP (1000_DA4B / 0x1DA4B)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JZ 0x1000:da52 (1000_DA4D / 0x1DA4D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DA52 / 0x1DA52)
      return NearRet();
    }
    // INC word ptr [BP + 0x2] (1000_DA4F / 0x1DA4F)
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP + 0x2)]);
    label_1000_DA52_1DA52:
    // RET  (1000_DA52 / 0x1DA52)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DA53_01DA53(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DA53_1DA53:
    // MOV word ptr [0xdc6a],0x0 (1000_DA53 / 0x1DA53)
    UInt16[DS, 0xDC6A] = 0x0;
    // MOV byte ptr [0x46d7],0x0 (1000_DA59 / 0x1DA59)
    UInt8[DS, 0x46D7] = 0x0;
    // RET  (1000_DA5E / 0x1DA5E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DA5F_01DA5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DA5F_1DA5F:
    // MOV DI,0xdc6a (1000_DA5F / 0x1DA5F)
    DI = 0xDC6A;
    // MOV CX,word ptr [DI] (1000_DA62 / 0x1DA62)
    CX = UInt16[DS, DI];
    // JCXZ 0x1000:da72 (1000_DA64 / 0x1DA64)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_DA72 / 0x1DA72)
      return NearRet();
    }
    // ADD DI,0x6 (1000_DA66 / 0x1DA66)
    DI += 0x6;
    label_1000_DA69_1DA69:
    // CMP word ptr [DI],SI (1000_DA69 / 0x1DA69)
    Alu.Sub16(UInt16[DS, DI], SI);
    // JZ 0x1000:da73 (1000_DA6B / 0x1DA6B)
    if(ZeroFlag) {
      goto label_1000_DA73_1DA73;
    }
    // ADD DI,0x6 (1000_DA6D / 0x1DA6D)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    // LOOP 0x1000:da69 (1000_DA70 / 0x1DA70)
    if(--CX != 0) {
      goto label_1000_DA69_1DA69;
    }
    label_1000_DA72_1DA72:
    // RET  (1000_DA72 / 0x1DA72)
    return NearRet();
    label_1000_DA73_1DA73:
    // SUB DI,0x4 (1000_DA73 / 0x1DA73)
    DI -= 0x4;
    // DEC word ptr [0xdc6a] (1000_DA76 / 0x1DA76)
    UInt16[DS, 0xDC6A] = Alu.Dec16(UInt16[DS, 0xDC6A]);
    // MOV BP,word ptr [0xdc66] (1000_DA7A / 0x1DA7A)
    BP = UInt16[DS, 0xDC66];
    // OR BP,BP (1000_DA7E / 0x1DA7E)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JZ 0x1000:da90 (1000_DA80 / 0x1DA80)
    if(ZeroFlag) {
      goto label_1000_DA90_1DA90;
    }
    // CMP DI,word ptr [BP + 0x0] (1000_DA82 / 0x1DA82)
    Alu.Sub16(DI, UInt16[SS, BP]);
    // JA 0x1000:da8d (1000_DA85 / 0x1DA85)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_DA8D_1DA8D;
    }
    // SUB word ptr [BP + 0x0],0x6 (1000_DA87 / 0x1DA87)
    // UInt16[SS, BP] -= 0x6;
    UInt16[SS, BP] = Alu.Sub16(UInt16[SS, BP], 0x6);
    // JMP 0x1000:da90 (1000_DA8B / 0x1DA8B)
    goto label_1000_DA90_1DA90;
    label_1000_DA8D_1DA8D:
    // DEC word ptr [BP + 0x2] (1000_DA8D / 0x1DA8D)
    UInt16[SS, (ushort)(BP + 0x2)]--;
    label_1000_DA90_1DA90:
    // DEC CX (1000_DA90 / 0x1DA90)
    CX = Alu.Dec16(CX);
    // JZ 0x1000:da72 (1000_DA91 / 0x1DA91)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DA72 / 0x1DA72)
      return NearRet();
    }
    // MOV AX,CX (1000_DA93 / 0x1DA93)
    AX = CX;
    // ADD CX,CX (1000_DA95 / 0x1DA95)
    CX += CX;
    // ADD CX,AX (1000_DA97 / 0x1DA97)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // MOV SI,DI (1000_DA99 / 0x1DA99)
    SI = DI;
    // ADD SI,0x6 (1000_DA9B / 0x1DA9B)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    // PUSH DS (1000_DA9E / 0x1DA9E)
    Stack.Push(DS);
    // POP ES (1000_DA9F / 0x1DA9F)
    ES = Stack.Pop();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_DAA0 / 0x1DAA0)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // RET  (1000_DAA2 / 0x1DAA2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DAA3_01DAA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DAA3_1DAA3:
    // MOV word ptr [0xdc58],0x0 (1000_DAA3 / 0x1DAA3)
    UInt16[DS, 0xDC58] = 0x0;
    // RET  (1000_DAA9 / 0x1DAA9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DAAA_01DAAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DAAA_1DAAA:
    // MOV word ptr [0xdc58],SI (1000_DAAA / 0x1DAAA)
    UInt16[DS, 0xDC58] = SI;
    // RET  (1000_DAAE / 0x1DAAE)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_DAAF_01DAAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DAAF_1DAAF:
    // MOV SI,0xdc3a (1000_DAAF / 0x1DAAF)
    SI = 0xDC3A;
    // MOV AX,[0xdc36] (1000_DAB2 / 0x1DAB2)
    AX = UInt16[DS, 0xDC36];
    // ADD AX,DX (1000_DAB5 / 0x1DAB5)
    AX += DX;
    // CMP AX,word ptr [SI] (1000_DAB7 / 0x1DAB7)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JGE 0x1000:dabd (1000_DAB9 / 0x1DAB9)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DABD_1DABD;
    }
    // MOV AX,word ptr [SI] (1000_DABB / 0x1DABB)
    AX = UInt16[DS, SI];
    label_1000_DABD_1DABD:
    // ADD SI,0x2 (1000_DABD / 0x1DABD)
    SI += 0x2;
    // CMP AX,word ptr [SI] (1000_DAC0 / 0x1DAC0)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JLE 0x1000:dac6 (1000_DAC2 / 0x1DAC2)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_DAC6_1DAC6;
    }
    // MOV AX,word ptr [SI] (1000_DAC4 / 0x1DAC4)
    AX = UInt16[DS, SI];
    label_1000_DAC6_1DAC6:
    // MOV [0xdc36],AX (1000_DAC6 / 0x1DAC6)
    UInt16[DS, 0xDC36] = AX;
    // ADD SI,0x2 (1000_DAC9 / 0x1DAC9)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // MOV AX,[0xdc38] (1000_DACC / 0x1DACC)
    AX = UInt16[DS, 0xDC38];
    // ADD AX,BX (1000_DACF / 0x1DACF)
    AX += BX;
    // CMP AX,word ptr [SI] (1000_DAD1 / 0x1DAD1)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JGE 0x1000:dad7 (1000_DAD3 / 0x1DAD3)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DAD7_1DAD7;
    }
    // MOV AX,word ptr [SI] (1000_DAD5 / 0x1DAD5)
    AX = UInt16[DS, SI];
    label_1000_DAD7_1DAD7:
    // ADD SI,0x2 (1000_DAD7 / 0x1DAD7)
    SI += 0x2;
    // CMP AX,word ptr [SI] (1000_DADA / 0x1DADA)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JLE 0x1000:dae0 (1000_DADC / 0x1DADC)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_DAE0_1DAE0;
    }
    // MOV AX,word ptr [SI] (1000_DADE / 0x1DADE)
    AX = UInt16[DS, SI];
    label_1000_DAE0_1DAE0:
    // MOV [0xdc38],AX (1000_DAE0 / 0x1DAE0)
    UInt16[DS, 0xDC38] = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAE3_01DAE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DAE3_01DAE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DAE3_1DAE3:
    // TEST byte ptr [0x2942],0x40 (1000_DAE3 / 0x1DAE3)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    // JNZ 0x1000:db02 (1000_DAE8 / 0x1DAE8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DB02 / 0x1DB02)
      return NearRet();
    }
    // MOV AX,[0xdc36] (1000_DAEA / 0x1DAEA)
    AX = UInt16[DS, 0xDC36];
    // MOV DX,word ptr [0xdc38] (1000_DAED / 0x1DAED)
    DX = UInt16[DS, 0xDC38];
    // MOV CX,word ptr [0x2580] (1000_DAF1 / 0x1DAF1)
    CX = UInt16[DS, 0x2580];
    // SHL AX,CL (1000_DAF5 / 0x1DAF5)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    // MOV CL,CH (1000_DAF7 / 0x1DAF7)
    CL = CH;
    // SHL DX,CL (1000_DAF9 / 0x1DAF9)
    // DX <<= CL;
    DX = Alu.Shl16(DX, CL);
    // MOV CX,AX (1000_DAFB / 0x1DAFB)
    CX = AX;
    // MOV AX,0x4 (1000_DAFD / 0x1DAFD)
    AX = 0x4;
    // INT 0x33 (1000_DB00 / 0x1DB00)
    Interrupt(0x33);
    label_1000_DB02_1DB02:
    // RET  (1000_DB02 / 0x1DB02)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB03_01DB03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB03_1DB03:
    // CALL 0x1000:dbb2 (1000_DB03 / 0x1DB03)
    NearCall(cs1, 0xDB06, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_DB06_1DB06:
    // MOV word ptr [0xdc36],DX (1000_DB06 / 0x1DB06)
    UInt16[DS, 0xDC36] = DX;
    // MOV word ptr [0xdc38],BX (1000_DB0A / 0x1DB0A)
    UInt16[DS, 0xDC38] = BX;
    // CALL 0x1000:dae3 (1000_DB0E / 0x1DB0E)
    NearCall(cs1, 0xDB11, spice86_generated_label_call_target_1000_DAE3_01DAE3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DB11_01DB11, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DB11_01DB11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB11_1DB11:
    // JMP 0x1000:dbec (1000_DB11 / 0x1DB11)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB14_01DB14(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB14_1DB14:
    // MOV DI,0xdc3a (1000_DB14 / 0x1DB14)
    DI = 0xDC3A;
    // MOV word ptr [DI],CX (1000_DB17 / 0x1DB17)
    UInt16[DS, DI] = CX;
    // MOV word ptr [DI + 0x2],DX (1000_DB19 / 0x1DB19)
    UInt16[DS, (ushort)(DI + 0x2)] = DX;
    // MOV word ptr [DI + 0x4],AX (1000_DB1C / 0x1DB1C)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    // MOV word ptr [DI + 0x6],BX (1000_DB1F / 0x1DB1F)
    UInt16[DS, (ushort)(DI + 0x6)] = BX;
    // TEST byte ptr [0x2942],0x40 (1000_DB22 / 0x1DB22)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    // JNZ 0x1000:db43 (1000_DB27 / 0x1DB27)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DB43 / 0x1DB43)
      return NearRet();
    }
    // PUSH AX (1000_DB29 / 0x1DB29)
    Stack.Push(AX);
    // PUSH BX (1000_DB2A / 0x1DB2A)
    Stack.Push(BX);
    // MOV AL,[0x2580] (1000_DB2B / 0x1DB2B)
    AL = UInt8[DS, 0x2580];
    // CALL 0x1000:db44 (1000_DB2E / 0x1DB2E)
    NearCall(cs1, 0xDB31, spice86_generated_label_call_target_1000_DB44_01DB44);
    label_1000_DB31_1DB31:
    // MOV AX,0x7 (1000_DB31 / 0x1DB31)
    AX = 0x7;
    // INT 0x33 (1000_DB34 / 0x1DB34)
    Interrupt(0x33);
    // POP DX (1000_DB36 / 0x1DB36)
    DX = Stack.Pop();
    // POP CX (1000_DB37 / 0x1DB37)
    CX = Stack.Pop();
    // MOV AL,[0x2581] (1000_DB38 / 0x1DB38)
    AL = UInt8[DS, 0x2581];
    // CALL 0x1000:db44 (1000_DB3B / 0x1DB3B)
    NearCall(cs1, 0xDB3E, spice86_generated_label_call_target_1000_DB44_01DB44);
    label_1000_DB3E_1DB3E:
    // MOV AX,0x8 (1000_DB3E / 0x1DB3E)
    AX = 0x8;
    // INT 0x33 (1000_DB41 / 0x1DB41)
    Interrupt(0x33);
    label_1000_DB43_1DB43:
    // RET  (1000_DB43 / 0x1DB43)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB44_01DB44(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB44_1DB44:
    // XCHG AX,CX (1000_DB44 / 0x1DB44)
    ushort tmp_1000_DB44 = AX;
    AX = CX;
    CX = tmp_1000_DB44;
    // SHL AX,CL (1000_DB45 / 0x1DB45)
    AX <<= CL;
    // SHL DX,CL (1000_DB47 / 0x1DB47)
    // DX <<= CL;
    DX = Alu.Shl16(DX, CL);
    // MOV CX,AX (1000_DB49 / 0x1DB49)
    CX = AX;
    // RET  (1000_DB4B / 0x1DB4B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB4C_01DB4C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB4C_1DB4C:
    // MOV AX,[0xdc34] (1000_DB4C / 0x1DB4C)
    AX = UInt16[DS, 0xDC34];
    // AND AL,0x3 (1000_DB4F / 0x1DB4F)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    // MOV [0xdc35],AL (1000_DB51 / 0x1DB51)
    UInt8[DS, 0xDC35] = AL;
    // XOR AH,AL (1000_DB54 / 0x1DB54)
    AH ^= AL;
    // ADD AH,AH (1000_DB56 / 0x1DB56)
    AH += AH;
    // ADD AH,AH (1000_DB58 / 0x1DB58)
    // AH += AH;
    AH = Alu.Add8(AH, AH);
    // OR AL,AH (1000_DB5A / 0x1DB5A)
    AL |= AH;
    // XOR AH,AH (1000_DB5C / 0x1DB5C)
    AH = 0;
    // MOV DX,word ptr [0xdc36] (1000_DB5E / 0x1DB5E)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DB62 / 0x1DB62)
    BX = UInt16[DS, 0xDC38];
    // RET  (1000_DB66 / 0x1DB66)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB67_01DB67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB67_1DB67:
    // CMP byte ptr [0xdc47],0x0 (1000_DB67 / 0x1DB67)
    Alu.Sub8(UInt8[DS, 0xDC47], 0x0);
    // JNS 0x1000:dbab (1000_DB6C / 0x1DB6C)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_DBAB / 0x1DBAB)
      return NearRet();
    }
    // INC byte ptr [0xdc47] (1000_DB6E / 0x1DB6E)
    UInt8[DS, 0xDC47] = Alu.Inc8(UInt8[DS, 0xDC47]);
    // JMP 0x1000:dbec (1000_DB72 / 0x1DB72)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB74_01DB74(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDBAB: goto label_1000_DBAB_1DBAB;break; // Target of external jump from 0x1DB79, 0x1DB6C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_DB74_1DB74:
    // CMP byte ptr [0xdc46],0x0 (1000_DB74 / 0x1DB74)
    Alu.Sub8(UInt8[DS, 0xDC46], 0x0);
    // JS 0x1000:dbab (1000_DB79 / 0x1DB79)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_DBAB / 0x1DBAB)
      return NearRet();
    }
    // PUSH BX (1000_DB7B / 0x1DB7B)
    Stack.Push(BX);
    // PUSH DX (1000_DB7C / 0x1DB7C)
    Stack.Push(DX);
    // MOV BX,word ptr [0x2582] (1000_DB7D / 0x1DB7D)
    BX = UInt16[DS, 0x2582];
    // MOV DX,word ptr [0xdc42] (1000_DB81 / 0x1DB81)
    DX = UInt16[DS, 0xDC42];
    // SUB DX,word ptr [BX] (1000_DB85 / 0x1DB85)
    // DX -= UInt16[DS, BX];
    DX = Alu.Sub16(DX, UInt16[DS, BX]);
    // MOV BX,word ptr [BX + 0x2] (1000_DB87 / 0x1DB87)
    BX = UInt16[DS, (ushort)(BX + 0x2)];
    // NEG BX (1000_DB8A / 0x1DB8A)
    BX = Alu.Sub16(0, BX);
    // ADD BX,word ptr [0xdc44] (1000_DB8C / 0x1DB8C)
    BX += UInt16[DS, 0xDC44];
    // CMP DX,word ptr [SI + 0x4] (1000_DB90 / 0x1DB90)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JGE 0x1000:dba9 (1000_DB93 / 0x1DB93)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DBA9_1DBA9;
    }
    // CMP BX,word ptr [SI + 0x6] (1000_DB95 / 0x1DB95)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JGE 0x1000:dba9 (1000_DB98 / 0x1DB98)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DBA9_1DBA9;
    }
    // ADD DX,0x10 (1000_DB9A / 0x1DB9A)
    DX += 0x10;
    // CMP DX,word ptr [SI] (1000_DB9D / 0x1DB9D)
    Alu.Sub16(DX, UInt16[DS, SI]);
    // JLE 0x1000:dba9 (1000_DB9F / 0x1DB9F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_DBA9_1DBA9;
    }
    // ADD BX,0x10 (1000_DBA1 / 0x1DBA1)
    BX += 0x10;
    // CMP BX,word ptr [SI + 0x2] (1000_DBA4 / 0x1DBA4)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JG 0x1000:dbac (1000_DBA7 / 0x1DBA7)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_DBAC_1DBAC;
    }
    label_1000_DBA9_1DBA9:
    // POP DX (1000_DBA9 / 0x1DBA9)
    DX = Stack.Pop();
    // POP BX (1000_DBAA / 0x1DBAA)
    BX = Stack.Pop();
    label_1000_DBAB_1DBAB:
    // RET  (1000_DBAB / 0x1DBAB)
    return NearRet();
    label_1000_DBAC_1DBAC:
    // POP DX (1000_DBAC / 0x1DBAC)
    DX = Stack.Pop();
    // POP BX (1000_DBAD / 0x1DBAD)
    BX = Stack.Pop();
    // DEC byte ptr [0xdc47] (1000_DBAE / 0x1DBAE)
    UInt8[DS, 0xDC47] = Alu.Dec8(UInt8[DS, 0xDC47]);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DBB2_01DBB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
