namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_C4ED_01C4ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C4F0_1C4F0:
    // MOV DX,word ptr [SI] (1000_C4F0 / 0x1C4F0)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_C4F2 / 0x1C4F2)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x4] (1000_C4F5 / 0x1C4F5)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C4FB_1C4FB:
    // CMP byte ptr [0x227d],0x0 (1000_C4FB / 0x1C4FB)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:c51e (1000_C500 / 0x1C500)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AX,0x89 (1000_C502 / 0x1C502)
    Alu.Sub16(AX, 0x89);
    State.IncCycles();
    // JL 0x1000:c51e (1000_C505 / 0x1C505)
    if(SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP BP,0x7e (1000_C507 / 0x1C507)
    Alu.Sub16(BP, 0x7E);
    State.IncCycles();
    // JL 0x1000:c51e (1000_C50B / 0x1C50B)
    if(SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP DX,0xc2 (1000_C50D / 0x1C50D)
    Alu.Sub16(DX, 0xC2);
    State.IncCycles();
    // JGE 0x1000:c51e (1000_C511 / 0x1C511)
    if(SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH AX (1000_C513 / 0x1C513)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_C514 / 0x1C514)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_C515 / 0x1C515)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BP (1000_C516 / 0x1C516)
    Stack.Push(BP);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C51A_1C51A:
    // POP BP (1000_C51A / 0x1C51A)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_C51B / 0x1C51B)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_C51C / 0x1C51C)
    BX = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C51E_1C51E:
    // SUB BP,DX (1000_C51E / 0x1C51E)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    State.IncCycles();
    // JBE 0x1000:c53d (1000_C520 / 0x1C520)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    State.IncCycles();
    // SUB AX,BX (1000_C522 / 0x1C522)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JBE 0x1000:c53d (1000_C524 / 0x1C524)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    State.IncCycles();
    label_1000_C526_1C526:
    // CMP word ptr [0x2570],0x1ad6 (1000_C526 / 0x1C526)
    Alu.Sub16(UInt16[DS, 0x2570], 0x1AD6);
    State.IncCycles();
    // JZ 0x1000:c53d (1000_C52C / 0x1C52C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    State.IncCycles();
    // PUSH DS (1000_C52E / 0x1C52E)
    Stack.Push(DS);
    State.IncCycles();
    // MOV ES,word ptr [0xdbd8] (1000_C52F / 0x1C52F)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // MOV DS,word ptr [0xdbd6] (1000_C533 / 0x1C533)
    DS = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALLF [0x38f5] (1000_C537 / 0x1C537)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C537 = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C537) {
      case 0x235E0 : FarCall(cs1, 0xC53C, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C537));
        break;
    }
    State.IncCycles();
    label_1000_C53C_1C53C:
    // POP DS (1000_C53C / 0x1C53C)
    DS = Stack.Pop();
    State.IncCycles();
    label_1000_C53D_1C53D:
    // RET  (1000_C53D / 0x1C53D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C53E_01C53E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C53E_1C53E:
    // MOV SI,0x276a (1000_C53E / 0x1C53E)
    SI = 0x276A;
    State.IncCycles();
    // MOV BP,word ptr [0x2772] (1000_C541 / 0x1C541)
    BP = UInt16[DS, 0x2772];
    State.IncCycles();
    // MOV AL,[0xdbe4] (1000_C545 / 0x1C545)
    AL = UInt8[DS, 0xDBE4];
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_C548 / 0x1C548)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C550_1C550:
    // RET  (1000_C550 / 0x1C550)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C551_01C551(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C551_1C551:
    // LODSW SI (1000_C551 / 0x1C551)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_C552 / 0x1C552)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_C554 / 0x1C554)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_C555 / 0x1C555)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_C557 / 0x1C557)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_C558 / 0x1C558)
    DI = AX;
    State.IncCycles();
    // DEC DI (1000_C55A / 0x1C55A)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // LODSW SI (1000_C55B / 0x1C55B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_C55C / 0x1C55C)
    CX = AX;
    State.IncCycles();
    // DEC CX (1000_C55E / 0x1C55E)
    CX = Alu.Dec16(CX);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C560_1C560:
    // MOV [0xdbe4],AL (1000_C560 / 0x1C560)
    UInt8[DS, 0xDBE4] = AL;
    State.IncCycles();
    // PUSH BX (1000_C563 / 0x1C563)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_C564 / 0x1C564)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_C565 / 0x1C565)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_C566 / 0x1C566)
    Stack.Push(DI);
    State.IncCycles();
    // MOV CX,BX (1000_C567 / 0x1C567)
    CX = BX;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C56C_1C56C:
    // MOV BP,SP (1000_C56C / 0x1C56C)
    BP = SP;
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x4] (1000_C56E / 0x1C56E)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV BX,CX (1000_C571 / 0x1C571)
    BX = CX;
    State.IncCycles();
    // CALL 0x1000:c53e (1000_C573 / 0x1C573)
    NearCall(cs1, 0xC576, spice86_generated_label_call_target_1000_C53E_01C53E);
    State.IncCycles();
    label_1000_C576_1C576:
    // MOV BP,SP (1000_C576 / 0x1C576)
    BP = SP;
    State.IncCycles();
    // MOV DI,DX (1000_C578 / 0x1C578)
    DI = DX;
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (1000_C57A / 0x1C57A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // CALL 0x1000:c53e (1000_C57D / 0x1C57D)
    NearCall(cs1, 0xC580, spice86_generated_label_call_target_1000_C53E_01C53E);
    State.IncCycles();
    label_1000_C580_1C580:
    // POP DI (1000_C580 / 0x1C580)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV DX,DI (1000_C581 / 0x1C581)
    DX = DI;
    State.IncCycles();
    // CALL 0x1000:c53e (1000_C583 / 0x1C583)
    NearCall(cs1, 0xC586, spice86_generated_label_call_target_1000_C53E_01C53E);
    State.IncCycles();
    label_1000_C586_1C586:
    // POP DX (1000_C586 / 0x1C586)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_C587 / 0x1C587)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_C588 / 0x1C588)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_C589 / 0x1C589)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C58A_01C58A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C58D_1C58D:
    // MOV SI,0x3cbe (1000_C58D / 0x1C58D)
    SI = 0x3CBE;
    State.IncCycles();
    // LODSW SI (1000_C590 / 0x1C590)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_C591 / 0x1C591)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:c5ce (1000_C593 / 0x1C593)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C5CE / 0x1C5CE)
      return NearRet();
    }
    State.IncCycles();
    // MOV AH,0x11 (1000_C595 / 0x1C595)
    AH = 0x11;
    State.IncCycles();
    // MUL AH (1000_C597 / 0x1C597)
    Cpu.Mul8(AH);
    State.IncCycles();
    // ADD SI,AX (1000_C599 / 0x1C599)
    SI += AX;
    State.IncCycles();
    // CMP DI,SI (1000_C59B / 0x1C59B)
    Alu.Sub16(DI, SI);
    State.IncCycles();
    // JNC 0x1000:c5ce (1000_C59D / 0x1C59D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C5CE / 0x1C5CE)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [DI + 0xc],0x80 (1000_C59F / 0x1C59F)
    // UInt8[DS, (ushort)(DI + 0xC)] |= 0x80;
    UInt8[DS, (ushort)(DI + 0xC)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xC)], 0x80);
    State.IncCycles();
    // PUSH SI (1000_C5A3 / 0x1C5A3)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_C5A4 / 0x1C5A4)
    Stack.Push(DI);
    State.IncCycles();
    // MOV SI,DI (1000_C5A5 / 0x1C5A5)
    SI = DI;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C5AA_1C5AA:
    // POP DI (1000_C5AA / 0x1C5AA)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_C5AB / 0x1C5AB)
    CX = Stack.Pop();
    State.IncCycles();
    // PUSH DI (1000_C5AC / 0x1C5AC)
    Stack.Push(DI);
    State.IncCycles();
    // LEA SI,[DI + 0x11] (1000_C5AD / 0x1C5AD)
    SI = (ushort)(DI + 0x11);
    State.IncCycles();
    // SUB CX,SI (1000_C5B0 / 0x1C5B0)
    // CX -= SI;
    CX = Alu.Sub16(CX, SI);
    State.IncCycles();
    // JZ 0x1000:c5b8 (1000_C5B2 / 0x1C5B2)
    if(ZeroFlag) {
      goto label_1000_C5B8_1C5B8;
    }
    State.IncCycles();
    // PUSH DS (1000_C5B4 / 0x1C5B4)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_C5B5 / 0x1C5B5)
    ES = Stack.Pop();
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_C5B6 / 0x1C5B6)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    label_1000_C5B8_1C5B8:
    // DEC word ptr [0x3cbe] (1000_C5B8 / 0x1C5B8)
    UInt16[DS, 0x3CBE] = Alu.Dec16(UInt16[DS, 0x3CBE]);
    State.IncCycles();
    // POP DI (1000_C5BC / 0x1C5BC)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x4752 (1000_C5BD / 0x1C5BD)
    SI = 0x4752;
    State.IncCycles();
    // MOV CX,0x2 (1000_C5C0 / 0x1C5C0)
    CX = 0x2;
    State.IncCycles();
    label_1000_C5C3_1C5C3:
    // LODSW SI (1000_C5C3 / 0x1C5C3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,DI (1000_C5C4 / 0x1C5C4)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JC 0x1000:c5cc (1000_C5C6 / 0x1C5C6)
    if(CarryFlag) {
      goto label_1000_C5CC_1C5CC;
    }
    State.IncCycles();
    // SUB word ptr [SI + -0x2],0x11 (1000_C5C8 / 0x1C5C8)
    // UInt16[DS, (ushort)(SI - 0x2)] -= 0x11;
    UInt16[DS, (ushort)(SI - 0x2)] = Alu.Sub16(UInt16[DS, (ushort)(SI - 0x2)], 0x11);
    State.IncCycles();
    label_1000_C5CC_1C5CC:
    // LOOP 0x1000:c5c3 (1000_C5CC / 0x1C5CC)
    if(--CX != 0) {
      goto label_1000_C5C3_1C5C3;
    }
    State.IncCycles();
    label_1000_C5CE_1C5CE:
    // RET  (1000_C5CE / 0x1C5CE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C5CF_01C5CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C5CF_1C5CF:
    // XOR AH,AH (1000_C5CF / 0x1C5CF)
    AH = 0;
    State.IncCycles();
    // MOV AL,byte ptr [BP + 0x0] (1000_C5D1 / 0x1C5D1)
    AL = UInt8[SS, BP];
    State.IncCycles();
    // CMP byte ptr [BP + 0x3],0x0 (1000_C5D4 / 0x1C5D4)
    Alu.Sub8(UInt8[SS, (ushort)(BP + 0x3)], 0x0);
    State.IncCycles();
    // JZ 0x1000:c60b (1000_C5D8 / 0x1C5D8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C60B_01C60B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH BP (1000_C5DA / 0x1C5DA)
    Stack.Push(BP);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C5DE_1C5DE:
    // POP BP (1000_C5DE / 0x1C5DE)
    BP = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [DI + 0xf],BP (1000_C5DF / 0x1C5DF)
    UInt16[DS, (ushort)(DI + 0xF)] = BP;
    State.IncCycles();
    // PUSH SI (1000_C5E2 / 0x1C5E2)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,BP (1000_C5E3 / 0x1C5E3)
    SI = BP;
    State.IncCycles();
    // MOV BX,0xffff (1000_C5E5 / 0x1C5E5)
    BX = 0xFFFF;
    State.IncCycles();
    label_1000_C5E8_1C5E8:
    // INC BX (1000_C5E8 / 0x1C5E8)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // JS 0x1000:c609 (1000_C5E9 / 0x1C5E9)
    if(SignFlag) {
      goto label_1000_C609_1C609;
    }
    State.IncCycles();
    // ADD SI,0x3 (1000_C5EB / 0x1C5EB)
    SI += 0x3;
    State.IncCycles();
    // CMP byte ptr [SI],0x0 (1000_C5EE / 0x1C5EE)
    Alu.Sub8(UInt8[DS, SI], 0x0);
    State.IncCycles();
    // JNZ 0x1000:c5e8 (1000_C5F1 / 0x1C5F1)
    if(!ZeroFlag) {
      goto label_1000_C5E8_1C5E8;
    }
    State.IncCycles();
    // OR BX,BX (1000_C5F3 / 0x1C5F3)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:c609 (1000_C5F5 / 0x1C5F5)
    if(ZeroFlag) {
      goto label_1000_C609_1C609;
    }
    State.IncCycles();
    // CALL 0x1000:e3df (1000_C5F7 / 0x1C5F7)
    NearCall(cs1, 0xC5FA, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    State.IncCycles();
    label_1000_C5FA_1C5FA:
    // MOV BX,AX (1000_C5FA / 0x1C5FA)
    BX = AX;
    State.IncCycles();
    // SHL AX,1 (1000_C5FC / 0x1C5FC)
    AX <<= 0x1;
    State.IncCycles();
    // ADD AX,BX (1000_C5FE / 0x1C5FE)
    AX += BX;
    State.IncCycles();
    // ADD BP,AX (1000_C600 / 0x1C600)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    // MOV word ptr [DI + 0xd],BP (1000_C602 / 0x1C602)
    UInt16[DS, (ushort)(DI + 0xD)] = BP;
    State.IncCycles();
    // OR byte ptr [DI + 0xc],0x1 (1000_C605 / 0x1C605)
    // UInt8[DS, (ushort)(DI + 0xC)] |= 0x1;
    UInt8[DS, (ushort)(DI + 0xC)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xC)], 0x1);
    State.IncCycles();
    label_1000_C609_1C609:
    // POP SI (1000_C609 / 0x1C609)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_C60A / 0x1C60A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C60B_01C60B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C60B_1C60B:
    // PUSH AX (1000_C60B / 0x1C60B)
    Stack.Push(AX);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C60F_1C60F:
    // POP AX (1000_C60F / 0x1C60F)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c202 (1000_C610 / 0x1C610)
    NearCall(cs1, 0xC613, spice86_generated_label_call_target_1000_C202_01C202);
    State.IncCycles();
    label_1000_C613_1C613:
    // PUSH SI (1000_C613 / 0x1C613)
    Stack.Push(SI);
    State.IncCycles();
    // MOV DI,0x3cbe (1000_C614 / 0x1C614)
    DI = 0x3CBE;
    State.IncCycles();
    // MOV BP,AX (1000_C617 / 0x1C617)
    BP = AX;
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_C619 / 0x1C619)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // INC word ptr [DI] (1000_C61B / 0x1C61B)
    UInt16[DS, DI] = Alu.Inc16(UInt16[DS, DI]);
    State.IncCycles();
    // MOV AH,0x11 (1000_C61D / 0x1C61D)
    AH = 0x11;
    State.IncCycles();
    // MUL AH (1000_C61F / 0x1C61F)
    Cpu.Mul8(AH);
    State.IncCycles();
    // XCHG AX,BP (1000_C621 / 0x1C621)
    ushort tmp_1000_C621 = AX;
    AX = BP;
    BP = tmp_1000_C621;
    State.IncCycles();
    // LEA DI,[BP + DI + 0x2] (1000_C622 / 0x1C622)
    DI = (ushort)(BP + DI + 0x2);
    State.IncCycles();
    // MOV word ptr [DI],DX (1000_C625 / 0x1C625)
    UInt16[DS, DI] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],BX (1000_C627 / 0x1C627)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    State.IncCycles();
    // MOV word ptr [DI + 0x8],AX (1000_C62A / 0x1C62A)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    State.IncCycles();
    // MOV word ptr [DI + 0xa],SI (1000_C62D / 0x1C62D)
    UInt16[DS, (ushort)(DI + 0xA)] = SI;
    State.IncCycles();
    // MOV byte ptr [DI + 0xc],0x0 (1000_C630 / 0x1C630)
    UInt8[DS, (ushort)(DI + 0xC)] = 0x0;
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_C634 / 0x1C634)
    NearCall(cs1, 0xC637, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    label_1000_C637_1C637:
    // LODSW ES:SI (1000_C637 / 0x1C637)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AH,0xf (1000_C639 / 0x1C639)
    AH &= 0xF;
    State.IncCycles();
    // ADD DX,AX (1000_C63C / 0x1C63C)
    DX += AX;
    State.IncCycles();
    // ADD BL,byte ptr ES:[SI] (1000_C63E / 0x1C63E)
    // BL += UInt8[ES, SI];
    BL = Alu.Add8(BL, UInt8[ES, SI]);
    State.IncCycles();
    // ADC BH,0x0 (1000_C641 / 0x1C641)
    BH = Alu.Adc8(BH, 0x0);
    State.IncCycles();
    // MOV word ptr [DI + 0x4],DX (1000_C644 / 0x1C644)
    UInt16[DS, (ushort)(DI + 0x4)] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x6],BX (1000_C647 / 0x1C647)
    UInt16[DS, (ushort)(DI + 0x6)] = BX;
    State.IncCycles();
    // POP SI (1000_C64A / 0x1C64A)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_C64B / 0x1C64B)
    return NearRet();
  }
  
  public virtual Action split_1000_C653_01C653(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C653_1C653:
    // CALL 0x1000:c13b (1000_C653 / 0x1C653)
    NearCall(cs1, 0xC656, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x8] (1000_C656 / 0x1C656)
    AX = UInt16[DS, (ushort)(DI + 0x8)];
    State.IncCycles();
    // CALL 0x1000:c202 (1000_C659 / 0x1C659)
    NearCall(cs1, 0xC65C, spice86_generated_label_call_target_1000_C202_01C202);
    State.IncCycles();
    // SUB DX,word ptr [DI] (1000_C65C / 0x1C65C)
    DX -= UInt16[DS, DI];
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_C664_1C664:
    // MOV SI,DI (1000_C664 / 0x1C664)
    SI = DI;
    State.IncCycles();
    // SUB SP,0x8 (1000_C666 / 0x1C666)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    State.IncCycles();
    // MOV DI,SP (1000_C669 / 0x1C669)
    DI = SP;
    State.IncCycles();
    // PUSH DS (1000_C66B / 0x1C66B)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_C66C / 0x1C66C)
    ES = Stack.Pop();
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_C66D / 0x1C66D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_C66E / 0x1C66E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_C66F / 0x1C66F)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_C670 / 0x1C670)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // SUB SI,0x8 (1000_C671 / 0x1C671)
    SI -= 0x8;
    State.IncCycles();
    // SUB DI,0x8 (1000_C674 / 0x1C674)
    DI -= 0x8;
    State.IncCycles();
    // ADD word ptr [SI],DX (1000_C677 / 0x1C677)
    UInt16[DS, SI] += DX;
    State.IncCycles();
    // ADD word ptr [SI + 0x2],BX (1000_C679 / 0x1C679)
    UInt16[DS, (ushort)(SI + 0x2)] += BX;
    State.IncCycles();
    // ADD word ptr [SI + 0x4],DX (1000_C67C / 0x1C67C)
    UInt16[DS, (ushort)(SI + 0x4)] += DX;
    State.IncCycles();
    // ADD word ptr [SI + 0x6],BX (1000_C67F / 0x1C67F)
    // UInt16[DS, (ushort)(SI + 0x6)] += BX;
    UInt16[DS, (ushort)(SI + 0x6)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x6)], BX);
    State.IncCycles();
    // OR DX,DX (1000_C682 / 0x1C682)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JS 0x1000:c68e (1000_C684 / 0x1C684)
    if(SignFlag) {
      goto label_1000_C68E_1C68E;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x4] (1000_C686 / 0x1C686)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV word ptr [DI + 0x4],AX (1000_C689 / 0x1C689)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    State.IncCycles();
    // JMP 0x1000:c692 (1000_C68C / 0x1C68C)
    goto label_1000_C692_1C692;
    State.IncCycles();
    label_1000_C68E_1C68E:
    // MOV AX,word ptr [SI] (1000_C68E / 0x1C68E)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // MOV word ptr [DI],AX (1000_C690 / 0x1C690)
    UInt16[DS, DI] = AX;
    State.IncCycles();
    label_1000_C692_1C692:
    // OR BX,BX (1000_C692 / 0x1C692)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JS 0x1000:c69e (1000_C694 / 0x1C694)
    if(SignFlag) {
      goto label_1000_C69E_1C69E;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_C696 / 0x1C696)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV word ptr [DI + 0x6],AX (1000_C699 / 0x1C699)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    State.IncCycles();
    // JMP 0x1000:c6a4 (1000_C69C / 0x1C69C)
    goto label_1000_C6A4_1C6A4;
    State.IncCycles();
    label_1000_C69E_1C69E:
    // MOV AX,word ptr [SI + 0x2] (1000_C69E / 0x1C69E)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV word ptr [DI + 0x2],AX (1000_C6A1 / 0x1C6A1)
    UInt16[DS, (ushort)(DI + 0x2)] = AX;
    State.IncCycles();
    label_1000_C6A4_1C6A4:
    // MOV SI,DI (1000_C6A4 / 0x1C6A4)
    SI = DI;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_C6A6 / 0x1C6A6)
    NearCall(cs1, 0xC6A9, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C6A9_01C6A9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C6A9_01C6A9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C6A9_1C6A9:
    // ADD SP,0x8 (1000_C6A9 / 0x1C6A9)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    State.IncCycles();
    label_1000_C6AC_1C6AC:
    // RET  (1000_C6AC / 0x1C6AC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C6AD_01C6AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C6AD_1C6AD:
    // CALL 0x1000:c13b (1000_C6AD / 0x1C6AD)
    NearCall(cs1, 0xC6B0, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C6B0_01C6B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C6B0_01C6B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C6B0_1C6B0:
    // CMP byte ptr [0xdc46],0x0 (1000_C6B0 / 0x1C6B0)
    Alu.Sub8(UInt8[DS, 0xDC46], 0x0);
    State.IncCycles();
    // JS 0x1000:c6e4 (1000_C6B5 / 0x1C6B5)
    if(SignFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    State.IncCycles();
    // MOV AX,[0xdc44] (1000_C6B7 / 0x1C6B7)
    AX = UInt16[DS, 0xDC44];
    State.IncCycles();
    // CMP AX,word ptr [SI + 0x6] (1000_C6BA / 0x1C6BA)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JGE 0x1000:c6e4 (1000_C6BD / 0x1C6BD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    State.IncCycles();
    // ADD AX,0x10 (1000_C6BF / 0x1C6BF)
    AX += 0x10;
    State.IncCycles();
    // CMP AX,word ptr [SI + 0x2] (1000_C6C2 / 0x1C6C2)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JLE 0x1000:c6e4 (1000_C6C5 / 0x1C6C5)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    State.IncCycles();
    // MOV AX,[0xdc42] (1000_C6C7 / 0x1C6C7)
    AX = UInt16[DS, 0xDC42];
    State.IncCycles();
    // CMP AX,word ptr [SI + 0x4] (1000_C6CA / 0x1C6CA)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JGE 0x1000:c6e4 (1000_C6CD / 0x1C6CD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    State.IncCycles();
    // ADD AX,0x10 (1000_C6CF / 0x1C6CF)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    State.IncCycles();
    // MOV BX,word ptr [SI] (1000_C6D2 / 0x1C6D2)
    BX = UInt16[DS, SI];
    State.IncCycles();
    // AND BH,0xf (1000_C6D4 / 0x1C6D4)
    BH &= 0xF;
    State.IncCycles();
    // CMP AX,BX (1000_C6D7 / 0x1C6D7)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JLE 0x1000:c6e4 (1000_C6D9 / 0x1C6D9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    State.IncCycles();
    // MOV AX,0xdbec (1000_C6DB / 0x1C6DB)
    AX = 0xDBEC;
    State.IncCycles();
    // PUSH AX (1000_C6DE / 0x1C6DE)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_C6DF / 0x1C6DF)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_C6E0 / 0x1C6E0)
    NearCall(cs1, 0xC6E3, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_C6E3_1C6E3:
    // POP SI (1000_C6E3 / 0x1C6E3)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_C6E4_1C6E4:
    // MOV AX,DS (1000_C6E4 / 0x1C6E4)
    AX = DS;
    State.IncCycles();
    // MOV ES,AX (1000_C6E6 / 0x1C6E6)
    ES = AX;
    State.IncCycles();
    // MOV DI,0xd834 (1000_C6E8 / 0x1C6E8)
    DI = 0xD834;
    State.IncCycles();
    // MOV BX,0x8 (1000_C6EB / 0x1C6EB)
    BX = 0x8;
    State.IncCycles();
    // LODSW SI (1000_C6EE / 0x1C6EE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [BX + DI] (1000_C6EF / 0x1C6EF)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    State.IncCycles();
    // JGE 0x1000:c6f5 (1000_C6F1 / 0x1C6F1)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6F5_1C6F5;
    }
    State.IncCycles();
    // MOV AX,word ptr [BX + DI] (1000_C6F3 / 0x1C6F3)
    AX = UInt16[DS, (ushort)(BX + DI)];
    State.IncCycles();
    label_1000_C6F5_1C6F5:
    // STOSW ES:DI (1000_C6F5 / 0x1C6F5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_C6F6 / 0x1C6F6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [BX + DI] (1000_C6F7 / 0x1C6F7)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    State.IncCycles();
    // JGE 0x1000:c6fd (1000_C6F9 / 0x1C6F9)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6FD_1C6FD;
    }
    State.IncCycles();
    // MOV AX,word ptr [BX + DI] (1000_C6FB / 0x1C6FB)
    AX = UInt16[DS, (ushort)(BX + DI)];
    State.IncCycles();
    label_1000_C6FD_1C6FD:
    // STOSW ES:DI (1000_C6FD / 0x1C6FD)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_C6FE / 0x1C6FE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [BX + DI] (1000_C6FF / 0x1C6FF)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    State.IncCycles();
    // JLE 0x1000:c705 (1000_C701 / 0x1C701)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C705_1C705;
    }
    State.IncCycles();
    // MOV AX,word ptr [BX + DI] (1000_C703 / 0x1C703)
    AX = UInt16[DS, (ushort)(BX + DI)];
    State.IncCycles();
    label_1000_C705_1C705:
    // CMP AX,word ptr [DI + -0x4] (1000_C705 / 0x1C705)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI - 0x4)]);
    State.IncCycles();
    // JLE 0x1000:c6ac (1000_C708 / 0x1C708)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C6AC / 0x1C6AC)
      return NearRet();
    }
    State.IncCycles();
    // STOSW ES:DI (1000_C70A / 0x1C70A)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_C70B / 0x1C70B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [BX + DI] (1000_C70C / 0x1C70C)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    State.IncCycles();
    // JLE 0x1000:c712 (1000_C70E / 0x1C70E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C712_1C712;
    }
    State.IncCycles();
    // MOV AX,word ptr [BX + DI] (1000_C710 / 0x1C710)
    AX = UInt16[DS, (ushort)(BX + DI)];
    State.IncCycles();
    label_1000_C712_1C712:
    // CMP AX,word ptr [DI + -0x4] (1000_C712 / 0x1C712)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI - 0x4)]);
    State.IncCycles();
    // JLE 0x1000:c6ac (1000_C715 / 0x1C715)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C6AC / 0x1C6AC)
      return NearRet();
    }
    State.IncCycles();
    // STOSW ES:DI (1000_C717 / 0x1C717)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CALL 0x1000:c443 (1000_C718 / 0x1C718)
    NearCall(cs1, 0xC71B, spice86_generated_label_call_target_1000_C443_01C443);
    State.IncCycles();
    label_1000_C71B_1C71B:
    // SUB SP,0x200 (1000_C71B / 0x1C71B)
    // SP -= 0x200;
    SP = Alu.Sub16(SP, 0x200);
    State.IncCycles();
    // MOV DI,SP (1000_C71F / 0x1C71F)
    DI = SP;
    State.IncCycles();
    // MOV CX,word ptr [0x3cbe] (1000_C721 / 0x1C721)
    CX = UInt16[DS, 0x3CBE];
    State.IncCycles();
    // JCXZ 0x1000:c780 (1000_C725 / 0x1C725)
    if(CX == 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C763_01C763, 0x1C780 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0xd834 (1000_C727 / 0x1C727)
    SI = 0xD834;
    State.IncCycles();
    // LODSW SI (1000_C72A / 0x1C72A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_C72B / 0x1C72B)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_C72D / 0x1C72D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_C72E / 0x1C72E)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_C730 / 0x1C730)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_C731 / 0x1C731)
    BP = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_C733 / 0x1C733)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // MOV SI,0x3cc0 (1000_C735 / 0x1C735)
    SI = 0x3CC0;
    State.IncCycles();
    label_1000_C738_1C738:
    // CMP byte ptr [SI + 0xc],0x0 (1000_C738 / 0x1C738)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0xC)], 0x0);
    State.IncCycles();
    // JS 0x1000:c756 (1000_C73C / 0x1C73C)
    if(SignFlag) {
      goto label_1000_C756_1C756;
    }
    State.IncCycles();
    // CMP word ptr [SI],BP (1000_C73E / 0x1C73E)
    Alu.Sub16(UInt16[DS, SI], BP);
    State.IncCycles();
    // JGE 0x1000:c756 (1000_C740 / 0x1C740)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    State.IncCycles();
    // CMP word ptr [SI + 0x2],AX (1000_C742 / 0x1C742)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], AX);
    State.IncCycles();
    // JGE 0x1000:c756 (1000_C745 / 0x1C745)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    State.IncCycles();
    // CMP word ptr [SI + 0x4],DX (1000_C747 / 0x1C747)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], DX);
    State.IncCycles();
    // JLE 0x1000:c756 (1000_C74A / 0x1C74A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    State.IncCycles();
    // CMP word ptr [SI + 0x6],BX (1000_C74C / 0x1C74C)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x6)], BX);
    State.IncCycles();
    // JLE 0x1000:c756 (1000_C74F / 0x1C74F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    State.IncCycles();
    // MOV word ptr [DI],SI (1000_C751 / 0x1C751)
    UInt16[DS, DI] = SI;
    State.IncCycles();
    // ADD DI,0x2 (1000_C753 / 0x1C753)
    DI += 0x2;
    State.IncCycles();
    label_1000_C756_1C756:
    // ADD SI,0x11 (1000_C756 / 0x1C756)
    // SI += 0x11;
    SI = Alu.Add16(SI, 0x11);
    State.IncCycles();
    // LOOP 0x1000:c738 (1000_C759 / 0x1C759)
    if(--CX != 0) {
      goto label_1000_C738_1C738;
    }
    State.IncCycles();
    // MOV CX,DI (1000_C75B / 0x1C75B)
    CX = DI;
    State.IncCycles();
    // SUB CX,SP (1000_C75D / 0x1C75D)
    CX -= SP;
    State.IncCycles();
    // SHR CX,1 (1000_C75F / 0x1C75F)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // JZ 0x1000:c780 (1000_C761 / 0x1C761)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C763_01C763, 0x1C780 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C763_01C763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_C763_01C763(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC780: goto label_1000_C780_1C780;break; // Target of external jump from 0x1C761, 0x1C725
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_C763_1C763:
    // MOV SI,SP (1000_C763 / 0x1C763)
    SI = SP;
    State.IncCycles();
    // PUSH CX (1000_C765 / 0x1C765)
    Stack.Push(CX);
    State.IncCycles();
    // CALL word ptr [0x2786] (1000_C766 / 0x1C766)
    // Indirect call to word ptr [0x2786], generating possible targets from emulator records
    uint targetAddress_1000_C766 = (uint)(UInt16[DS, 0x2786]);
    switch(targetAddress_1000_C766) {
      case 0xC835 : NearCall(cs1, 0xC76A, spice86_generated_label_call_target_1000_C835_01C835); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C766));
        break;
    }
    State.IncCycles();
    label_1000_C76A_1C76A:
    // JS 0x1000:c77f (1000_C76A / 0x1C76A)
    if(SignFlag) {
      goto label_1000_C77F_1C77F;
    }
    State.IncCycles();
    // XOR SI,SI (1000_C76C / 0x1C76C)
    SI = 0;
    State.IncCycles();
    // XCHG word ptr [BX + -0x2],SI (1000_C76E / 0x1C76E)
    ushort tmp_1000_C76E = UInt16[DS, (ushort)(BX - 0x2)];
    UInt16[DS, (ushort)(BX - 0x2)] = SI;
    SI = tmp_1000_C76E;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x8] (1000_C771 / 0x1C771)
    AX = UInt16[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_C774 / 0x1C774)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_C776 / 0x1C776)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // CALL 0x1000:c30d (1000_C779 / 0x1C779)
    NearCall(cs1, 0xC77C, spice86_generated_label_call_target_1000_C30D_01C30D);
    State.IncCycles();
    label_1000_C77C_1C77C:
    // POP CX (1000_C77C / 0x1C77C)
    CX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c763 (1000_C77D / 0x1C77D)
    goto label_1000_C763_1C763;
    State.IncCycles();
    label_1000_C77F_1C77F:
    // POP CX (1000_C77F / 0x1C77F)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_C780_1C780:
    // CMP byte ptr [0x227d],0x0 (1000_C780 / 0x1C780)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:c7a2 (1000_C785 / 0x1C785)
    if(!ZeroFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    State.IncCycles();
    // CMP word ptr [0xd83a],0x89 (1000_C787 / 0x1C787)
    Alu.Sub16(UInt16[DS, 0xD83A], 0x89);
    State.IncCycles();
    // JL 0x1000:c7a2 (1000_C78D / 0x1C78D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    State.IncCycles();
    // CMP word ptr [0xd838],0x7e (1000_C78F / 0x1C78F)
    Alu.Sub16(UInt16[DS, 0xD838], 0x7E);
    State.IncCycles();
    // JL 0x1000:c7a2 (1000_C795 / 0x1C795)
    if(SignFlag != OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    State.IncCycles();
    // CMP word ptr [0xd834],0xc2 (1000_C797 / 0x1C797)
    Alu.Sub16(UInt16[DS, 0xD834], 0xC2);
    State.IncCycles();
    // JGE 0x1000:c7a2 (1000_C79D / 0x1C79D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    State.IncCycles();
    // CALL 0x1000:1797 (1000_C79F / 0x1C79F)
    NearCall(cs1, 0xC7A2, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    label_1000_C7A2_1C7A2:
    // MOV SI,word ptr [0xdbe0] (1000_C7A2 / 0x1C7A2)
    SI = UInt16[DS, 0xDBE0];
    State.IncCycles();
    // OR SI,SI (1000_C7A6 / 0x1C7A6)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:c7be (1000_C7A8 / 0x1C7A8)
    if(ZeroFlag) {
      goto label_1000_C7BE_1C7BE;
    }
    State.IncCycles();
    // MOV DI,0xd834 (1000_C7AA / 0x1C7AA)
    DI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:c7d4 (1000_C7AD / 0x1C7AD)
    NearCall(cs1, 0xC7B0, spice86_generated_label_call_target_1000_C7D4_01C7D4);
    State.IncCycles();
    label_1000_C7B0_1C7B0:
    // MOV SI,word ptr [0xdbe2] (1000_C7B0 / 0x1C7B0)
    SI = UInt16[DS, 0xDBE2];
    State.IncCycles();
    // OR SI,SI (1000_C7B4 / 0x1C7B4)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:c7be (1000_C7B6 / 0x1C7B6)
    if(ZeroFlag) {
      goto label_1000_C7BE_1C7BE;
    }
    State.IncCycles();
    // MOV DI,0xd834 (1000_C7B8 / 0x1C7B8)
    DI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:c7d4 (1000_C7BB / 0x1C7BB)
    NearCall(cs1, 0xC7BE, spice86_generated_label_call_target_1000_C7D4_01C7D4);
    State.IncCycles();
    label_1000_C7BE_1C7BE:
    // MOV SI,0xd834 (1000_C7BE / 0x1C7BE)
    SI = 0xD834;
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_C7C1 / 0x1C7C1)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_C7C3 / 0x1C7C3)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV BP,word ptr [SI + 0x4] (1000_C7C6 / 0x1C7C6)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_C7C9 / 0x1C7C9)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // CALL 0x1000:c51e (1000_C7CC / 0x1C7CC)
    NearCall(cs1, 0xC7CF, spice86_generated_label_call_target_1000_C51E_01C51E);
    State.IncCycles();
    label_1000_C7CF_1C7CF:
    // ADD SP,0x200 (1000_C7CF / 0x1C7CF)
    // SP += 0x200;
    SP = Alu.Add16(SP, 0x200);
    State.IncCycles();
    // RET  (1000_C7D3 / 0x1C7D3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C7D4_01C7D4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C7D4_1C7D4:
    // LODSW SI (1000_C7D4 / 0x1C7D4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [DI + 0x4] (1000_C7D5 / 0x1C7D5)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JGE 0x1000:c826 (1000_C7D8 / 0x1C7D8)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    State.IncCycles();
    // MOV DX,AX (1000_C7DA / 0x1C7DA)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_C7DC / 0x1C7DC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [DI + 0x6] (1000_C7DD / 0x1C7DD)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // JGE 0x1000:c826 (1000_C7E0 / 0x1C7E0)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,AX (1000_C7E2 / 0x1C7E2)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_C7E4 / 0x1C7E4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [DI] (1000_C7E5 / 0x1C7E5)
    Alu.Sub16(AX, UInt16[DS, DI]);
    State.IncCycles();
    // JLE 0x1000:c826 (1000_C7E7 / 0x1C7E7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,AX (1000_C7E9 / 0x1C7E9)
    BP = AX;
    State.IncCycles();
    // LODSW SI (1000_C7EB / 0x1C7EB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,word ptr [DI + 0x2] (1000_C7EC / 0x1C7EC)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JLE 0x1000:c826 (1000_C7EF / 0x1C7EF)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    State.IncCycles();
    // CMP DX,word ptr [DI] (1000_C7F1 / 0x1C7F1)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JNC 0x1000:c7f7 (1000_C7F3 / 0x1C7F3)
    if(!CarryFlag) {
      goto label_1000_C7F7_1C7F7;
    }
    State.IncCycles();
    // MOV DX,word ptr [DI] (1000_C7F5 / 0x1C7F5)
    DX = UInt16[DS, DI];
    State.IncCycles();
    label_1000_C7F7_1C7F7:
    // CMP BP,word ptr [DI + 0x4] (1000_C7F7 / 0x1C7F7)
    Alu.Sub16(BP, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JC 0x1000:c7ff (1000_C7FA / 0x1C7FA)
    if(CarryFlag) {
      goto label_1000_C7FF_1C7FF;
    }
    State.IncCycles();
    // MOV BP,word ptr [DI + 0x4] (1000_C7FC / 0x1C7FC)
    BP = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    label_1000_C7FF_1C7FF:
    // CMP BX,word ptr [DI + 0x2] (1000_C7FF / 0x1C7FF)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:c807 (1000_C802 / 0x1C802)
    if(!CarryFlag) {
      goto label_1000_C807_1C807;
    }
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x2] (1000_C804 / 0x1C804)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    label_1000_C807_1C807:
    // CMP AX,word ptr [DI + 0x6] (1000_C807 / 0x1C807)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // JC 0x1000:c80f (1000_C80A / 0x1C80A)
    if(CarryFlag) {
      goto label_1000_C80F_1C80F;
    }
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x6] (1000_C80C / 0x1C80C)
    AX = UInt16[DS, (ushort)(DI + 0x6)];
    State.IncCycles();
    label_1000_C80F_1C80F:
    // SUB BP,DX (1000_C80F / 0x1C80F)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    State.IncCycles();
    // JBE 0x1000:c826 (1000_C811 / 0x1C811)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    State.IncCycles();
    // SUB AX,BX (1000_C813 / 0x1C813)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JBE 0x1000:c826 (1000_C815 / 0x1C815)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    State.IncCycles();
    // MOV ES,word ptr [0xdbd6] (1000_C817 / 0x1C817)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // MOV DS,word ptr [0xdbd8] (1000_C81B / 0x1C81B)
    DS = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // CALLF [0x38f5] (1000_C81F / 0x1C81F)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C81F = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C81F) {
      case 0x235E0 : FarCall(cs1, 0xC824, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C81F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C824_01C824, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C824_01C824(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC826: goto label_1000_C826_1C826;break; // Target of external jump from 0x1C7E0, 0x1C7EF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_C824_1C824:
    // PUSH SS (1000_C824 / 0x1C824)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_C825 / 0x1C825)
    DS = Stack.Pop();
    State.IncCycles();
    label_1000_C826_1C826:
    // RET  (1000_C826 / 0x1C826)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C835_01C835(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C835_1C835:
    // MOV DX,0xffff (1000_C835 / 0x1C835)
    DX = 0xFFFF;
    State.IncCycles();
    label_1000_C838_1C838:
    // LODSW SI (1000_C838 / 0x1C838)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_C839 / 0x1C839)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:c856 (1000_C83B / 0x1C83B)
    if(ZeroFlag) {
      goto label_1000_C856_1C856;
    }
    State.IncCycles();
    // MOV DI,AX (1000_C83D / 0x1C83D)
    DI = AX;
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x4] (1000_C83F / 0x1C83F)
    AX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // ADD AX,word ptr [DI + 0x6] (1000_C842 / 0x1C842)
    AX += UInt16[DS, (ushort)(DI + 0x6)];
    State.IncCycles();
    // TEST byte ptr [DI + 0xc],0x40 (1000_C845 / 0x1C845)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x40);
    State.IncCycles();
    // JZ 0x1000:c84e (1000_C849 / 0x1C849)
    if(ZeroFlag) {
      goto label_1000_C84E_1C84E;
    }
    State.IncCycles();
    // MOV AX,0x7fff (1000_C84B / 0x1C84B)
    AX = 0x7FFF;
    State.IncCycles();
    label_1000_C84E_1C84E:
    // CMP AX,DX (1000_C84E / 0x1C84E)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JA 0x1000:c856 (1000_C850 / 0x1C850)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_C856_1C856;
    }
    State.IncCycles();
    // MOV DX,AX (1000_C852 / 0x1C852)
    DX = AX;
    State.IncCycles();
    // MOV BX,SI (1000_C854 / 0x1C854)
    BX = SI;
    State.IncCycles();
    label_1000_C856_1C856:
    // LOOP 0x1000:c838 (1000_C856 / 0x1C856)
    if(--CX != 0) {
      goto label_1000_C838_1C838;
    }
    State.IncCycles();
    // OR DX,DX (1000_C858 / 0x1C858)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // RET  (1000_C85A / 0x1C85A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C85B_01C85B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C85B_1C85B:
    // MOV AX,[0xce7a] (1000_C85B / 0x1C85B)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0x476e],AX (1000_C85E / 0x1C85E)
    UInt16[DS, 0x476E] = AX;
    State.IncCycles();
    // MOV word ptr [0x4772],0x1770 (1000_C861 / 0x1C861)
    UInt16[DS, 0x4772] = 0x1770;
    State.IncCycles();
    // RET  (1000_C867 / 0x1C867)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_C868_01C868(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C868_1C868:
    // CALL 0x1000:abcc (1000_C868 / 0x1C868)
    NearCall(cs1, 0xC86B, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    State.IncCycles();
    // JNZ 0x1000:c8c0 (1000_C86B / 0x1C86B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C8C0 / 0x1C8C0)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0x22a6] (1000_C86D / 0x1C86D)
    SI = UInt16[DS, 0x22A6];
    State.IncCycles();
    // CMP SI,0x11 (1000_C871 / 0x1C871)
    Alu.Sub16(SI, 0x11);
    State.IncCycles();
    // JNC 0x1000:c8c0 (1000_C875 / 0x1C875)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C8C0 / 0x1C8C0)
      return NearRet();
    }
    State.IncCycles();
    // SHL SI,1 (1000_C877 / 0x1C877)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_C879 / 0x1C879)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x27b6] (1000_C87B / 0x1C87B)
    DX = UInt16[DS, (ushort)(SI + 0x27B6)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x27b8] (1000_C87F / 0x1C87F)
    BX = UInt16[DS, (ushort)(SI + 0x27B8)];
    State.IncCycles();
    // MOV AX,BX (1000_C883 / 0x1C883)
    AX = BX;
    State.IncCycles();
    // OR AX,DX (1000_C885 / 0x1C885)
    // AX |= DX;
    AX = Alu.Or16(AX, DX);
    State.IncCycles();
    // JZ 0x1000:c8c0 (1000_C887 / 0x1C887)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C8C0 / 0x1C8C0)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x2792 (1000_C889 / 0x1C889)
    SI = 0x2792;
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_C88C / 0x1C88C)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:c8a3 (1000_C891 / 0x1C891)
    if(!ZeroFlag) {
      goto label_1000_C8A3_1C8A3;
    }
    State.IncCycles();
    // PUSH BX (1000_C893 / 0x1C893)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,0x1 (1000_C894 / 0x1C894)
    BX = 0x1;
    State.IncCycles();
    // CALL 0x1000:e3b7 (1000_C897 / 0x1C897)
    NearCall(cs1, 0xC89A, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    // POP BX (1000_C89A / 0x1C89A)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x2789 (1000_C89B / 0x1C89B)
    SI = 0x2789;
    State.IncCycles();
    // JZ 0x1000:c8a3 (1000_C89E / 0x1C89E)
    if(ZeroFlag) {
      goto label_1000_C8A3_1C8A3;
    }
    State.IncCycles();
    // MOV SI,0x278e (1000_C8A0 / 0x1C8A0)
    SI = 0x278E;
    State.IncCycles();
    label_1000_C8A3_1C8A3:
    // LODSB SI (1000_C8A3 / 0x1C8A3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_C8A4 / 0x1C8A4)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:c8bd (1000_C8A6 / 0x1C8A6)
    if(ZeroFlag) {
      goto label_1000_C8BD_1C8BD;
    }
    State.IncCycles();
    // JNS 0x1000:c8b2 (1000_C8A8 / 0x1C8A8)
    if(!SignFlag) {
      goto label_1000_C8B2_1C8B2;
    }
    State.IncCycles();
    // MOV AX,0x12c (1000_C8AA / 0x1C8AA)
    AX = 0x12C;
    State.IncCycles();
    // CALL 0x1000:e387 (1000_C8AD / 0x1C8AD)
    NearCall(cs1, 0xC8B0, spice86_generated_label_call_target_1000_E387_01E387);
    State.IncCycles();
    // JMP 0x1000:c8a3 (1000_C8B0 / 0x1C8B0)
    goto label_1000_C8A3_1C8A3;
    State.IncCycles();
    label_1000_C8B2_1C8B2:
    // PUSH SI (1000_C8B2 / 0x1C8B2)
    Stack.Push(SI);
    State.IncCycles();
    // XOR AH,AH (1000_C8B3 / 0x1C8B3)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_C8B5 / 0x1C8B5)
    BP = AX;
    State.IncCycles();
    // CALL 0x1000:c8c1 (1000_C8B7 / 0x1C8B7)
    NearCall(cs1, 0xC8BA, not_observed_1000_C8C1_01C8C1);
    State.IncCycles();
    // POP SI (1000_C8BA / 0x1C8BA)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c8a3 (1000_C8BB / 0x1C8BB)
    goto label_1000_C8A3_1C8A3;
    State.IncCycles();
    label_1000_C8BD_1C8BD:
    // CALL 0x1000:c4dd (1000_C8BD / 0x1C8BD)
    NearCall(cs1, 0xC8C0, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_C8C0_1C8C0:
    // RET  (1000_C8C0 / 0x1C8C0)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_C8C1_01C8C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C8C1_1C8C1:
    // PUSH BX (1000_C8C1 / 0x1C8C1)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_C8C2 / 0x1C8C2)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH word ptr [0xce7a] (1000_C8C3 / 0x1C8C3)
    Stack.Push(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // MOV SI,BP (1000_C8C7 / 0x1C8C7)
    SI = BP;
    State.IncCycles();
    // SHL SI,1 (1000_C8C9 / 0x1C8C9)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_C8CB / 0x1C8CB)
    SI <<= 0x1;
    State.IncCycles();
    // SUB DX,word ptr [SI + 0x2796] (1000_C8CD / 0x1C8CD)
    // DX -= UInt16[DS, (ushort)(SI + 0x2796)];
    DX = Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x2796)]);
    State.IncCycles();
    // JNC 0x1000:c8d5 (1000_C8D1 / 0x1C8D1)
    if(!CarryFlag) {
      goto label_1000_C8D5_1C8D5;
    }
    State.IncCycles();
    // XOR DX,DX (1000_C8D3 / 0x1C8D3)
    DX = 0;
    State.IncCycles();
    label_1000_C8D5_1C8D5:
    // SUB BX,word ptr [SI + 0x2798] (1000_C8D5 / 0x1C8D5)
    // BX -= UInt16[DS, (ushort)(SI + 0x2798)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2798)]);
    State.IncCycles();
    // JNC 0x1000:c8dd (1000_C8D9 / 0x1C8D9)
    if(!CarryFlag) {
      goto label_1000_C8DD_1C8DD;
    }
    State.IncCycles();
    // XOR BX,BX (1000_C8DB / 0x1C8DB)
    BX = 0;
    State.IncCycles();
    label_1000_C8DD_1C8DD:
    // PUSH DS (1000_C8DD / 0x1C8DD)
    Stack.Push(DS);
    State.IncCycles();
    // MOV ES,word ptr [0xdbd8] (1000_C8DE / 0x1C8DE)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // MOV DS,word ptr [0xdbd6] (1000_C8E2 / 0x1C8E2)
    DS = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALLF [0x3949] (1000_C8E6 / 0x1C8E6)
    // Indirect call to [0x3949], generating possible targets from emulator records
    uint targetAddress_1000_C8E6 = (uint)(UInt16[SS, 0x394B] * 0x10 + UInt16[SS, 0x3949] - cs1 * 0x10);
    switch(targetAddress_1000_C8E6) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C8E6));
        break;
    }
    State.IncCycles();
    // POP DS (1000_C8EB / 0x1C8EB)
    DS = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_C8EC / 0x1C8EC)
    BX = Stack.Pop();
    State.IncCycles();
    label_1000_C8ED_1C8ED:
    // MOV AX,[0xce7a] (1000_C8ED / 0x1C8ED)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,BX (1000_C8F0 / 0x1C8F0)
    AX -= BX;
    State.IncCycles();
    // CMP AL,byte ptr [0xdbe6] (1000_C8F2 / 0x1C8F2)
    Alu.Sub8(AL, UInt8[DS, 0xDBE6]);
    State.IncCycles();
    // JC 0x1000:c8ed (1000_C8F6 / 0x1C8F6)
    if(CarryFlag) {
      goto label_1000_C8ED_1C8ED;
    }
    State.IncCycles();
    // POP DX (1000_C8F8 / 0x1C8F8)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_C8F9 / 0x1C8F9)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_C8FA / 0x1C8FA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_C8FB_01C8FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C8FB_1C8FB:
    // CALL 0x1000:c07c (1000_C8FB / 0x1C8FB)
    NearCall(cs1, 0xC8FE, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    // PUSH BP (1000_C8FE / 0x1C8FE)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:ca1b (1000_C8FF / 0x1C8FF)
    NearCall(cs1, 0xC902, spice86_generated_label_call_target_1000_CA1B_01CA1B);
    State.IncCycles();
    // CALL 0x1000:c4dd (1000_C902 / 0x1C902)
    NearCall(cs1, 0xC905, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_C905 / 0x1C905)
    NearCall(cs1, 0xC908, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // POP BP (1000_C908 / 0x1C908)
    BP = Stack.Pop();
    State.IncCycles();
    // CALL BP (1000_C909 / 0x1C909)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_C909 = (uint)(BP);
    switch(targetAddress_1000_C909) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C909));
        break;
    }
    State.IncCycles();
    label_1000_C90B_1C90B:
    // CALL 0x1000:c9f4 (1000_C90B / 0x1C90B)
    NearCall(cs1, 0xC90E, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    State.IncCycles();
    // JZ 0x1000:c90b (1000_C90E / 0x1C90E)
    if(ZeroFlag) {
      goto label_1000_C90B_1C90B;
    }
    State.IncCycles();
    // CALL 0x1000:c4dd (1000_C910 / 0x1C910)
    NearCall(cs1, 0xC913, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    // CALL 0x1000:ace6 (1000_C913 / 0x1C913)
    NearCall(cs1, 0xC916, spice86_generated_label_call_target_1000_ACE6_01ACE6);
    State.IncCycles();
    // CALL 0x1000:cc85 (1000_C916 / 0x1C916)
    NearCall(cs1, 0xC919, spice86_generated_label_call_target_1000_CC85_01CC85);
    State.IncCycles();
    // JZ 0x1000:c90b (1000_C919 / 0x1C919)
    if(ZeroFlag) {
      goto label_1000_C90B_1C90B;
    }
    State.IncCycles();
    // CALL 0x1000:c412 (1000_C91B / 0x1C91B)
    NearCall(cs1, 0xC91E, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    // JMP 0x1000:ca01 (1000_C91E / 0x1C91E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C921_01C921(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C921_1C921:
    // MOV BX,0x33a3 (1000_C921 / 0x1C921)
    BX = 0x33A3;
    State.IncCycles();
    // ADD BX,AX (1000_C924 / 0x1C924)
    BX += AX;
    State.IncCycles();
    // ADD BX,AX (1000_C926 / 0x1C926)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // MOV BX,word ptr [BX] (1000_C928 / 0x1C928)
    BX = UInt16[DS, BX];
    State.IncCycles();
    // RET  (1000_C92A / 0x1C92A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C92B_01C92B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C92B_1C92B:
    // MOV [0xdc00],AX (1000_C92B / 0x1C92B)
    UInt16[DS, 0xDC00] = AX;
    State.IncCycles();
    // CALL 0x1000:ca01 (1000_C92E / 0x1C92E)
    NearCall(cs1, 0xC931, spice86_generated_label_call_target_1000_CA01_01CA01);
    State.IncCycles();
    label_1000_C931_1C931:
    // CALL 0x1000:ce1a (1000_C931 / 0x1C931)
    NearCall(cs1, 0xC934, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    State.IncCycles();
    label_1000_C934_1C934:
    // MOV byte ptr [0xdbe7],0x0 (1000_C934 / 0x1C934)
    UInt8[DS, 0xDBE7] = 0x0;
    State.IncCycles();
    // CALL 0x1000:ce01 (1000_C939 / 0x1C939)
    NearCall(cs1, 0xC93C, spice86_generated_label_call_target_1000_CE01_01CE01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C93C_01C93C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C93C_01C93C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C93C_1C93C:
    // MOV AX,[0xdc00] (1000_C93C / 0x1C93C)
    AX = UInt16[DS, 0xDC00];
    State.IncCycles();
    // MOV [0xdc02],AX (1000_C93F / 0x1C93F)
    UInt16[DS, 0xDC02] = AX;
    State.IncCycles();
    // CALL 0x1000:c921 (1000_C942 / 0x1C942)
    NearCall(cs1, 0xC945, spice86_generated_label_call_target_1000_C921_01C921);
    State.IncCycles();
    label_1000_C945_1C945:
    // MOV AX,word ptr [BX] (1000_C945 / 0x1C945)
    AX = UInt16[DS, BX];
    State.IncCycles();
    // MOV [0xdbfe],AX (1000_C947 / 0x1C947)
    UInt16[DS, 0xDBFE] = AX;
    State.IncCycles();
    // LEA DX,[BX + 0x2] (1000_C94A / 0x1C94A)
    DX = (ushort)(BX + 0x2);
    State.IncCycles();
    // CALL 0x1000:f229 (1000_C94D / 0x1C94D)
    NearCall(cs1, 0xC950, spice86_generated_label_call_target_1000_F229_01F229);
    State.IncCycles();
    label_1000_C950_1C950:
    // MOV word ptr [0x35a6],BX (1000_C950 / 0x1C950)
    UInt16[DS, 0x35A6] = BX;
    State.IncCycles();
    // MOV [0xdc04],AX (1000_C954 / 0x1C954)
    UInt16[DS, 0xDC04] = AX;
    State.IncCycles();
    // MOV word ptr [0xdc06],DX (1000_C957 / 0x1C957)
    UInt16[DS, 0xDC06] = DX;
    State.IncCycles();
    // MOV word ptr [0xdc08],CX (1000_C95B / 0x1C95B)
    UInt16[DS, 0xDC08] = CX;
    State.IncCycles();
    // MOV word ptr [0xdc0a],BP (1000_C95F / 0x1C95F)
    UInt16[DS, 0xDC0A] = BP;
    State.IncCycles();
    // PUSH word ptr [0xdc1a] (1000_C963 / 0x1C963)
    Stack.Push(UInt16[DS, 0xDC1A]);
    State.IncCycles();
    // PUSH word ptr [0xdc0c] (1000_C967 / 0x1C967)
    Stack.Push(UInt16[DS, 0xDC0C]);
    State.IncCycles();
    // CALL 0x1000:cd8f (1000_C96B / 0x1C96B)
    NearCall(cs1, 0xC96E, spice86_generated_label_call_target_1000_CD8F_01CD8F);
    State.IncCycles();
    label_1000_C96E_1C96E:
    // JC 0x1000:c988 (1000_C96E / 0x1C96E)
    if(CarryFlag) {
      goto label_1000_C988_1C988;
    }
    State.IncCycles();
    // ADD SI,AX (1000_C970 / 0x1C970)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // JC 0x1000:c97a (1000_C972 / 0x1C972)
    if(CarryFlag) {
      goto label_1000_C97A_1C97A;
    }
    State.IncCycles();
    // CMP SI,word ptr [0xce74] (1000_C974 / 0x1C974)
    Alu.Sub16(SI, UInt16[DS, 0xCE74]);
    State.IncCycles();
    // JBE 0x1000:c980 (1000_C978 / 0x1C978)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C980_1C980;
    }
    State.IncCycles();
    label_1000_C97A_1C97A:
    // MOV word ptr [0xdc0c],0x0 (1000_C97A / 0x1C97A)
    UInt16[DS, 0xDC0C] = 0x0;
    State.IncCycles();
    label_1000_C980_1C980:
    // SUB AX,0x2 (1000_C980 / 0x1C980)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // MOV CX,AX (1000_C983 / 0x1C983)
    CX = AX;
    State.IncCycles();
    // CALL 0x1000:cdbf (1000_C985 / 0x1C985)
    NearCall(cs1, 0xC988, spice86_generated_label_call_target_1000_CDBF_01CDBF);
    State.IncCycles();
    label_1000_C988_1C988:
    // POP word ptr [0xdc0c] (1000_C988 / 0x1C988)
    UInt16[DS, 0xDC0C] = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0xdc1a] (1000_C98C / 0x1C98C)
    UInt16[DS, 0xDC1A] = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:c9e7 (1000_C990 / 0x1C990)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_C9E7 / 0x1C9E7)
      return NearRet();
    }
    State.IncCycles();
    // LES SI,[0xdc0c] (1000_C992 / 0x1C992)
    ES = UInt16[DS, 0xDC0E];
    SI = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // LODSW ES:SI (1000_C996 / 0x1C996)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD AX,SI (1000_C998 / 0x1C998)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    State.IncCycles();
    // JC 0x1000:c9a2 (1000_C99A / 0x1C99A)
    if(CarryFlag) {
      goto label_1000_C9A2_1C9A2;
    }
    State.IncCycles();
    // CMP AX,word ptr [0xce74] (1000_C99C / 0x1C99C)
    Alu.Sub16(AX, UInt16[DS, 0xCE74]);
    State.IncCycles();
    // JBE 0x1000:c9a4 (1000_C9A0 / 0x1C9A0)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C9A4_1C9A4;
    }
    State.IncCycles();
    label_1000_C9A2_1C9A2:
    // XOR SI,SI (1000_C9A2 / 0x1C9A2)
    SI = 0;
    State.IncCycles();
    label_1000_C9A4_1C9A4:
    // MOV byte ptr [0xdbb4],0xff (1000_C9A4 / 0x1C9A4)
    UInt8[DS, 0xDBB4] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:c1ba (1000_C9A9 / 0x1C9A9)
    NearCall(cs1, 0xC9AC, spice86_generated_label_call_target_1000_C1BA_01C1BA);
    State.IncCycles();
    label_1000_C9AC_1C9AC:
    // DEC SI (1000_C9AC / 0x1C9AC)
    SI--;
    State.IncCycles();
    label_1000_C9AD_1C9AD:
    // INC SI (1000_C9AD / 0x1C9AD)
    SI++;
    State.IncCycles();
    // CMP byte ptr ES:[SI],0xff (1000_C9AE / 0x1C9AE)
    Alu.Sub8(UInt8[ES, SI], 0xFF);
    State.IncCycles();
    // JZ 0x1000:c9ad (1000_C9B2 / 0x1C9B2)
    if(ZeroFlag) {
      goto label_1000_C9AD_1C9AD;
    }
    State.IncCycles();
    // XOR BX,BX (1000_C9B4 / 0x1C9B4)
    BX = 0;
    State.IncCycles();
    // TEST byte ptr [0xdbfe],0x4 (1000_C9B6 / 0x1C9B6)
    Alu.And8(UInt8[DS, 0xDBFE], 0x4);
    State.IncCycles();
    // JZ 0x1000:c9bf (1000_C9BB / 0x1C9BB)
    if(ZeroFlag) {
      goto label_1000_C9BF_1C9BF;
    }
    State.IncCycles();
    // MOV BL,0x10 (1000_C9BD / 0x1C9BD)
    BL = 0x10;
    State.IncCycles();
    label_1000_C9BF_1C9BF:
    // MOV CX,word ptr ES:[BX + SI] (1000_C9BF / 0x1C9BF)
    CX = UInt16[ES, (ushort)(BX + SI)];
    State.IncCycles();
    // MOV BX,word ptr ES:[BX + SI + 0x2] (1000_C9C2 / 0x1C9C2)
    BX = UInt16[ES, (ushort)(BX + SI + 0x2)];
    State.IncCycles();
    // MOV AX,[0xdc04] (1000_C9C6 / 0x1C9C6)
    AX = UInt16[DS, 0xDC04];
    State.IncCycles();
    // ADD AX,CX (1000_C9C9 / 0x1C9C9)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // MOV [0xdbf6],AX (1000_C9CB / 0x1C9CB)
    UInt16[DS, 0xDBF6] = AX;
    State.IncCycles();
    // MOV AX,[0xdc06] (1000_C9CE / 0x1C9CE)
    AX = UInt16[DS, 0xDC06];
    State.IncCycles();
    // ADC AX,BX (1000_C9D1 / 0x1C9D1)
    AX = Alu.Adc16(AX, BX);
    State.IncCycles();
    // MOV [0xdbf8],AX (1000_C9D3 / 0x1C9D3)
    UInt16[DS, 0xDBF8] = AX;
    State.IncCycles();
    // MOV AX,[0xdc08] (1000_C9D6 / 0x1C9D6)
    AX = UInt16[DS, 0xDC08];
    State.IncCycles();
    // SUB AX,CX (1000_C9D9 / 0x1C9D9)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // MOV [0xdbfa],AX (1000_C9DB / 0x1C9DB)
    UInt16[DS, 0xDBFA] = AX;
    State.IncCycles();
    // MOV AX,[0xdc0a] (1000_C9DE / 0x1C9DE)
    AX = UInt16[DS, 0xDC0A];
    State.IncCycles();
    // SBB AX,BX (1000_C9E1 / 0x1C9E1)
    AX = Alu.Sbb16(AX, BX);
    State.IncCycles();
    // MOV [0xdbfc],AX (1000_C9E3 / 0x1C9E3)
    UInt16[DS, 0xDBFC] = AX;
    State.IncCycles();
    // CLC  (1000_C9E6 / 0x1C9E6)
    CarryFlag = false;
    State.IncCycles();
    label_1000_C9E7_1C9E7:
    // RET  (1000_C9E7 / 0x1C9E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C9E8_01C9E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C9E8_1C9E8:
    // CALL 0x1000:ca60 (1000_C9E8 / 0x1C9E8)
    NearCall(cs1, 0xC9EB, spice86_generated_label_call_target_1000_CA60_01CA60);
    State.IncCycles();
    label_1000_C9EB_1C9EB:
    // CALL 0x1000:dd63 (1000_C9EB / 0x1C9EB)
    NearCall(cs1, 0xC9EE, spice86_generated_label_call_target_1000_DD63_01DD63);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C9EE_01C9EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C9EE_01C9EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C9EE_1C9EE:
    // JC 0x1000:c9f1 (1000_C9EE / 0x1C9EE)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:de4e (1000_C9F1 / 0x1C9F1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_C9F0 / 0x1C9F0)
    return NearRet();
    State.IncCycles();
    label_1000_C9F1_1C9F1:
    // JMP 0x1000:de4e (1000_C9F1 / 0x1C9F1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C9F4_01C9F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_C9F4_1C9F4:
    // PUSH word ptr [0xdbe8] (1000_C9F4 / 0x1C9F4)
    Stack.Push(UInt16[DS, 0xDBE8]);
    State.IncCycles();
    // CALL 0x1000:ca60 (1000_C9F8 / 0x1C9F8)
    NearCall(cs1, 0xC9FB, spice86_generated_label_call_target_1000_CA60_01CA60);
    State.IncCycles();
    label_1000_C9FB_1C9FB:
    // POP AX (1000_C9FB / 0x1C9FB)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP AX,word ptr [0xdbe8] (1000_C9FC / 0x1C9FC)
    Alu.Sub16(AX, UInt16[DS, 0xDBE8]);
    State.IncCycles();
    // RET  (1000_CA00 / 0x1CA00)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA01_01CA01(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA01_1CA01:
    // XOR BX,BX (1000_CA01 / 0x1CA01)
    BX = 0;
    State.IncCycles();
    // XCHG word ptr [0x35a6],BX (1000_CA03 / 0x1CA03)
    ushort tmp_1000_CA03 = UInt16[DS, 0x35A6];
    UInt16[DS, 0x35A6] = BX;
    BX = tmp_1000_CA03;
    State.IncCycles();
    // OR BX,BX (1000_CA07 / 0x1CA07)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:ca18 (1000_CA09 / 0x1CA09)
    if(ZeroFlag) {
      goto label_1000_CA18_1CA18;
    }
    State.IncCycles();
    // CALL 0x1000:ce01 (1000_CA0B / 0x1CA0B)
    NearCall(cs1, 0xCA0E, spice86_generated_label_call_target_1000_CE01_01CE01);
    State.IncCycles();
    label_1000_CA0E_1CA0E:
    // CMP BX,word ptr [0xdbba] (1000_CA0E / 0x1CA0E)
    Alu.Sub16(BX, UInt16[DS, 0xDBBA]);
    State.IncCycles();
    // JZ 0x1000:ca18 (1000_CA12 / 0x1CA12)
    if(ZeroFlag) {
      goto label_1000_CA18_1CA18;
    }
    State.IncCycles();
    // MOV AH,0x3e (1000_CA14 / 0x1CA14)
    AH = 0x3E;
    State.IncCycles();
    // INT 0x21 (1000_CA16 / 0x1CA16)
    Interrupt(0x21);
    State.IncCycles();
    label_1000_CA18_1CA18:
    // XOR CX,CX (1000_CA18 / 0x1CA18)
    CX = 0;
    State.IncCycles();
    // RET  (1000_CA1A / 0x1CA1A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA1B_01CA1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA1B_1CA1B:
    // CALL 0x1000:c92b (1000_CA1B / 0x1CA1B)
    NearCall(cs1, 0xCA1E, spice86_generated_label_call_target_1000_C92B_01C92B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA1E_01CA1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA1E_01CA1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA1E_1CA1E:
    // JC 0x1000:ca01 (1000_CA1E / 0x1CA1E)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:cda0 (1000_CA20 / 0x1CA20)
    NearCall(cs1, 0xCA23, spice86_generated_label_call_target_1000_CDA0_01CDA0);
    State.IncCycles();
    label_1000_CA23_1CA23:
    // JC 0x1000:ca01 (1000_CA23 / 0x1CA23)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr [0xdce6],0x0 (1000_CA25 / 0x1CA25)
    UInt8[DS, 0xDCE6] = 0x0;
    State.IncCycles();
    // LES SI,[0xdc10] (1000_CA2A / 0x1CA2A)
    ES = UInt16[DS, 0xDC12];
    SI = UInt16[DS, 0xDC10];
    State.IncCycles();
    // LODSW ES:SI (1000_CA2E / 0x1CA2E)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,word ptr [0xdbde] (1000_CA30 / 0x1CA30)
    BP = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // CALL 0x1000:ccf4 (1000_CA34 / 0x1CA34)
    NearCall(cs1, 0xCA37, spice86_generated_label_call_target_1000_CCF4_01CCF4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA37_01CA37, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA37_01CA37(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA37_1CA37:
    // CALL 0x1000:aa0f (1000_CA37 / 0x1CA37)
    NearCall(cs1, 0xCA3A, spice86_generated_label_call_target_1000_AA0F_01AA0F);
    State.IncCycles();
    label_1000_CA3A_1CA3A:
    // CALL 0x1000:cc96 (1000_CA3A / 0x1CA3A)
    NearCall(cs1, 0xCA3D, spice86_generated_label_call_target_1000_CC96_01CC96);
    State.IncCycles();
    label_1000_CA3D_1CA3D:
    // CALL 0x1000:ce1a (1000_CA3D / 0x1CA3D)
    NearCall(cs1, 0xCA40, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    State.IncCycles();
    label_1000_CA40_1CA40:
    // INC word ptr [0xdbe8] (1000_CA40 / 0x1CA40)
    UInt16[DS, 0xDBE8]++;
    State.IncCycles();
    // INC word ptr [0xdbea] (1000_CA44 / 0x1CA44)
    UInt16[DS, 0xDBEA]++;
    State.IncCycles();
    // TEST byte ptr [0xdbfe],0x40 (1000_CA48 / 0x1CA48)
    Alu.And8(UInt8[DS, 0xDBFE], 0x40);
    State.IncCycles();
    // JNZ 0x1000:ca59 (1000_CA4D / 0x1CA4D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA59_01CA59, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x32 (1000_CA4F / 0x1CA4F)
    CX = 0x32;
    State.IncCycles();
    label_1000_CA52_1CA52:
    // PUSH CX (1000_CA52 / 0x1CA52)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:cb1a (1000_CA53 / 0x1CA53)
    NearCall(cs1, 0xCA56, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    State.IncCycles();
    label_1000_CA56_1CA56:
    // POP CX (1000_CA56 / 0x1CA56)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:ca52 (1000_CA57 / 0x1CA57)
    if(--CX != 0) {
      goto label_1000_CA52_1CA52;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA59_01CA59, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA59_01CA59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA59_1CA59:
    // MOV AX,[0xce7a] (1000_CA59 / 0x1CA59)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc22],AX (1000_CA5C / 0x1CA5C)
    UInt16[DS, 0xDC22] = AX;
    State.IncCycles();
    // RET  (1000_CA5F / 0x1CA5F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA60_01CA60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA60_1CA60:
    // CMP word ptr [0x35a6],0x0 (1000_CA60 / 0x1CA60)
    Alu.Sub16(UInt16[DS, 0x35A6], 0x0);
    State.IncCycles();
    // JZ 0x1000:ca9a (1000_CA65 / 0x1CA65)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA9A_01CA9A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0xdbfe],0x0 (1000_CA67 / 0x1CA67)
    Alu.Sub8(UInt8[DS, 0xDBFE], 0x0);
    State.IncCycles();
    // JNS 0x1000:ca71 (1000_CA6C / 0x1CA6C)
    if(!SignFlag) {
      goto label_1000_CA71_1CA71;
    }
    State.IncCycles();
    // CALL 0x1000:ca8f (1000_CA6E / 0x1CA6E)
    NearCall(cs1, 0xCA71, spice86_generated_label_ret_target_1000_CA8F_01CA8F);
    State.IncCycles();
    label_1000_CA71_1CA71:
    // CALL 0x1000:caa0 (1000_CA71 / 0x1CA71)
    NearCall(cs1, 0xCA74, spice86_generated_label_call_target_1000_CAA0_01CAA0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA74_01CA74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA74_01CA74(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA74_1CA74:
    // JNC 0x1000:ca7b (1000_CA74 / 0x1CA74)
    if(!CarryFlag) {
      goto label_1000_CA7B_1CA7B;
    }
    State.IncCycles();
    // CALL 0x1000:cb1a (1000_CA76 / 0x1CA76)
    NearCall(cs1, 0xCA79, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    State.IncCycles();
    label_1000_CA79_1CA79:
    // JMP 0x1000:ca60 (1000_CA79 / 0x1CA79)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA60_01CA60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_CA7B_1CA7B:
    // CALL 0x1000:cad4 (1000_CA7B / 0x1CA7B)
    NearCall(cs1, 0xCA7E, spice86_generated_label_call_target_1000_CAD4_01CAD4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA7E_01CA7E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA7E_01CA7E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA7E_1CA7E:
    // JC 0x1000:ca8f (1000_CA7E / 0x1CA7E)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA8F_01CA8F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xdc1e] (1000_CA80 / 0x1CA80)
    AX = UInt16[DS, 0xDC1E];
    State.IncCycles();
    // INC AX (1000_CA83 / 0x1CA83)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JZ 0x1000:ca89 (1000_CA84 / 0x1CA84)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA89_01CA89, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:ce3b (1000_CA86 / 0x1CA86)
    NearCall(cs1, 0xCA89, spice86_generated_label_call_target_1000_CE3B_01CE3B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA89_01CA89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA89_01CA89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA89_1CA89:
    // CALL 0x1000:cc96 (1000_CA89 / 0x1CA89)
    NearCall(cs1, 0xCA8C, spice86_generated_label_call_target_1000_CC96_01CC96);
    State.IncCycles();
    label_1000_CA8C_1CA8C:
    // CALL 0x1000:cc4e (1000_CA8C / 0x1CA8C)
    NearCall(cs1, 0xCA8F, spice86_generated_label_call_target_1000_CC4E_01CC4E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA8F_01CA8F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA8F_01CA8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA8F_1CA8F:
    // MOV AL,[0xdbfe] (1000_CA8F / 0x1CA8F)
    AL = UInt8[DS, 0xDBFE];
    State.IncCycles();
    // AND AL,0x80 (1000_CA92 / 0x1CA92)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    State.IncCycles();
    // MOV [0xdbb5],AL (1000_CA94 / 0x1CA94)
    UInt8[DS, 0xDBB5] = AL;
    State.IncCycles();
    // CALL 0x1000:cb1a (1000_CA97 / 0x1CA97)
    NearCall(cs1, 0xCA9A, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA9A_01CA9A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA9A_01CA9A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CA9A_1CA9A:
    // MOV byte ptr [0xdbb5],0x0 (1000_CA9A / 0x1CA9A)
    UInt8[DS, 0xDBB5] = 0x0;
    State.IncCycles();
    // RET  (1000_CA9F / 0x1CA9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CAA0_01CAA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CAA0_1CAA0:
    // CMP word ptr [0xdc16],0x0 (1000_CAA0 / 0x1CAA0)
    Alu.Sub16(UInt16[DS, 0xDC16], 0x0);
    State.IncCycles();
    // JA 0x1000:cad3 (1000_CAA5 / 0x1CAA5)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CAD3 / 0x1CAD3)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,word ptr [0xdc1a] (1000_CAA7 / 0x1CAA7)
    CX = UInt16[DS, 0xDC1A];
    State.IncCycles();
    // STC  (1000_CAAB / 0x1CAAB)
    CarryFlag = true;
    State.IncCycles();
    // JCXZ 0x1000:cad3 (1000_CAAC / 0x1CAAC)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CAD3 / 0x1CAD3)
      return NearRet();
    }
    State.IncCycles();
    // LES SI,[0xdc10] (1000_CAAE / 0x1CAAE)
    ES = UInt16[DS, 0xDC12];
    SI = UInt16[DS, 0xDC10];
    State.IncCycles();
    // LODSW ES:SI (1000_CAB2 / 0x1CAB2)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP word ptr ES:[SI],0x6d6d (1000_CAB4 / 0x1CAB4)
    Alu.Sub16(UInt16[ES, SI], 0x6D6D);
    State.IncCycles();
    // JZ 0x1000:cabf (1000_CAB9 / 0x1CAB9)
    if(ZeroFlag) {
      goto label_1000_CABF_1CABF;
    }
    State.IncCycles();
    // CMP CX,AX (1000_CABB / 0x1CABB)
    Alu.Sub16(CX, AX);
    State.IncCycles();
    // JC 0x1000:cad3 (1000_CABD / 0x1CABD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CAD3 / 0x1CAD3)
      return NearRet();
    }
    State.IncCycles();
    label_1000_CABF_1CABF:
    // MOV BP,word ptr [0xdbd6] (1000_CABF / 0x1CABF)
    BP = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // TEST byte ptr [0xdbfe],0x40 (1000_CAC3 / 0x1CAC3)
    Alu.And8(UInt8[DS, 0xDBFE], 0x40);
    State.IncCycles();
    // JZ 0x1000:cace (1000_CAC8 / 0x1CAC8)
    if(ZeroFlag) {
      goto label_1000_CACE_1CACE;
    }
    State.IncCycles();
    // MOV BP,word ptr [0xdc32] (1000_CACA / 0x1CACA)
    BP = UInt16[DS, 0xDC32];
    State.IncCycles();
    label_1000_CACE_1CACE:
    // CALL 0x1000:ccf4 (1000_CACE / 0x1CACE)
    NearCall(cs1, 0xCAD1, spice86_generated_label_call_target_1000_CCF4_01CCF4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CAD1_01CAD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CAD1_01CAD1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCAD3: goto label_1000_CAD3_1CAD3;break; // Target of external jump from 0x1CAA5, 0x1CABD, 0x1CAAC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_CAD1_1CAD1:
    // XOR AX,AX (1000_CAD1 / 0x1CAD1)
    AX = 0;
    State.IncCycles();
    label_1000_CAD3_1CAD3:
    // RET  (1000_CAD3 / 0x1CAD3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CAD4_01CAD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CAD4_1CAD4:
    // MOV AX,[0xdc1c] (1000_CAD4 / 0x1CAD4)
    AX = UInt16[DS, 0xDC1C];
    State.IncCycles();
    // INC AX (1000_CAD7 / 0x1CAD7)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JNZ 0x1000:caf0 (1000_CAD8 / 0x1CAD8)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_CAF0_01CAF0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_CADA / 0x1CADA)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,word ptr [0xdc22] (1000_CADD / 0x1CADD)
    // AX -= UInt16[DS, 0xDC22];
    AX = Alu.Sub16(AX, UInt16[DS, 0xDC22]);
    State.IncCycles();
    // OR AH,AH (1000_CAE1 / 0x1CAE1)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JNZ 0x1000:caeb (1000_CAE3 / 0x1CAE3)
    if(!ZeroFlag) {
      goto label_1000_CAEB_1CAEB;
    }
    State.IncCycles();
    // CMP AL,byte ptr [0xdbff] (1000_CAE5 / 0x1CAE5)
    Alu.Sub8(AL, UInt8[DS, 0xDBFF]);
    State.IncCycles();
    // JC 0x1000:caef (1000_CAE9 / 0x1CAE9)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CAEF / 0x1CAEF)
      return NearRet();
    }
    State.IncCycles();
    label_1000_CAEB_1CAEB:
    // CALL 0x1000:ca59 (1000_CAEB / 0x1CAEB)
    NearCall(cs1, 0xCAEE, spice86_generated_label_call_target_1000_CA59_01CA59);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CAEE_01CAEE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CAEE_01CAEE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCAEF: goto label_1000_CAEF_1CAEF;break; // Target of external jump from 0x1CAE9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_CAEE_1CAEE:
    // CLC  (1000_CAEE / 0x1CAEE)
    CarryFlag = false;
    State.IncCycles();
    label_1000_CAEF_1CAEF:
    // RET  (1000_CAEF / 0x1CAEF)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_CAF0_01CAF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CAF0_1CAF0:
    // MOV SI,word ptr [0x3824] (1000_CAF0 / 0x1CAF0)
    SI = UInt16[DS, 0x3824];
    State.IncCycles();
    // CMP byte ptr [SI + 0x6],0x1 (1000_CAF4 / 0x1CAF4)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x6)], 0x1);
    State.IncCycles();
    // CMC  (1000_CAF8 / 0x1CAF8)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JC 0x1000:caef (1000_CAF9 / 0x1CAF9)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CAEF / 0x1CAEF)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:a9f4 (1000_CAFB / 0x1CAFB)
    NearCall(cs1, 0xCAFE, not_observed_1000_A9F4_01A9F4);
    State.IncCycles();
    // CLC  (1000_CAFE / 0x1CAFE)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_CAFF / 0x1CAFF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CB00_01CB00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CB00_1CB00:
    // MOV AX,[0xdbea] (1000_CB00 / 0x1CB00)
    AX = UInt16[DS, 0xDBEA];
    State.IncCycles();
    // CMP AX,word ptr [0xdbee] (1000_CB03 / 0x1CB03)
    Alu.Sub16(AX, UInt16[DS, 0xDBEE]);
    State.IncCycles();
    // JZ 0x1000:cb61 (1000_CB07 / 0x1CB07)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB61_01CB61, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xdc08] (1000_CB09 / 0x1CB09)
    AX = UInt16[DS, 0xDC08];
    State.IncCycles();
    // OR AX,word ptr [0xdc0a] (1000_CB0C / 0x1CB0C)
    // AX |= UInt16[DS, 0xDC0A];
    AX = Alu.Or16(AX, UInt16[DS, 0xDC0A]);
    State.IncCycles();
    // JZ 0x1000:cb61 (1000_CB10 / 0x1CB10)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB61_01CB61, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:cd8f (1000_CB12 / 0x1CB12)
    NearCall(cs1, 0xCB15, spice86_generated_label_call_target_1000_CD8F_01CD8F);
    State.IncCycles();
    label_1000_CB15_1CB15:
    // JC 0x1000:cb44 (1000_CB15 / 0x1CB15)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:cc0c (1000_CB17 / 0x1CB17)
    NearCall(cs1, 0xCB1A, spice86_generated_label_call_target_1000_CC0C_01CC0C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CB1A_01CB1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CB1A_01CB1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CB1A_1CB1A:
    // MOV CX,word ptr [0xdc20] (1000_CB1A / 0x1CB1A)
    CX = UInt16[DS, 0xDC20];
    State.IncCycles();
    // JCXZ 0x1000:cb00 (1000_CB1E / 0x1CB1E)
    if(CX == 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB00_01CB00, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0xdbfe],0x0 (1000_CB20 / 0x1CB20)
    Alu.Sub8(UInt8[DS, 0xDBFE], 0x0);
    State.IncCycles();
    // JS 0x1000:cb38 (1000_CB25 / 0x1CB25)
    if(SignFlag) {
      goto label_1000_CB38_1CB38;
    }
    State.IncCycles();
    // MOV AX,[0xdc04] (1000_CB27 / 0x1CB27)
    AX = UInt16[DS, 0xDC04];
    State.IncCycles();
    // NEG AX (1000_CB2A / 0x1CB2A)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // AND AX,0x7ff (1000_CB2C / 0x1CB2C)
    AX &= 0x7FF;
    State.IncCycles();
    // ADD AH,0x8 (1000_CB2F / 0x1CB2F)
    AH += 0x8;
    State.IncCycles();
    // CMP AX,CX (1000_CB32 / 0x1CB32)
    Alu.Sub16(AX, CX);
    State.IncCycles();
    // JNC 0x1000:cb38 (1000_CB34 / 0x1CB34)
    if(!CarryFlag) {
      goto label_1000_CB38_1CB38;
    }
    State.IncCycles();
    // MOV CX,AX (1000_CB36 / 0x1CB36)
    CX = AX;
    State.IncCycles();
    label_1000_CB38_1CB38:
    // CALL 0x1000:cc2b (1000_CB38 / 0x1CB38)
    NearCall(cs1, 0xCB3B, spice86_generated_label_call_target_1000_CC2B_01CC2B);
    State.IncCycles();
    label_1000_CB3B_1CB3B:
    // JC 0x1000:cb44 (1000_CB3B / 0x1CB3B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    State.IncCycles();
    // SUB word ptr [0xdc20],CX (1000_CB3D / 0x1CB3D)
    // UInt16[DS, 0xDC20] -= CX;
    UInt16[DS, 0xDC20] = Alu.Sub16(UInt16[DS, 0xDC20], CX);
    State.IncCycles();
    // JMP 0x1000:cdbf (1000_CB41 / 0x1CB41)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CDBF_01CDBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CB44_01CB44(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCB4C: goto label_1000_CB4C_1CB4C;break; // Target of external jump from 0x1CB66
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_CB44_1CB44:
    // RET  (1000_CB44 / 0x1CB44)
    return NearRet();
    State.IncCycles();
    label_1000_CB45_1CB45:
    // MOV [0xdc00],AX (1000_CB45 / 0x1CB45)
    UInt16[DS, 0xDC00] = AX;
    State.IncCycles();
    // CALL 0x1000:c93c (1000_CB48 / 0x1CB48)
    NearCall(cs1, 0xCB4B, spice86_generated_label_ret_target_1000_C93C_01C93C);
    State.IncCycles();
    // RET  (1000_CB4B / 0x1CB4B)
    return NearRet();
    State.IncCycles();
    label_1000_CB4C_1CB4C:
    // OR byte ptr [0xdbe7],0x1 (1000_CB4C / 0x1CB4C)
    UInt8[DS, 0xDBE7] |= 0x1;
    State.IncCycles();
    // CMP word ptr [0xdc1a],0x0 (1000_CB51 / 0x1CB51)
    Alu.Sub16(UInt16[DS, 0xDC1A], 0x0);
    State.IncCycles();
    // JNZ 0x1000:cb60 (1000_CB56 / 0x1CB56)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CB60 / 0x1CB60)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [0xdbe7],0x2 (1000_CB58 / 0x1CB58)
    // UInt8[DS, 0xDBE7] |= 0x2;
    UInt8[DS, 0xDBE7] = Alu.Or8(UInt8[DS, 0xDBE7], 0x2);
    State.IncCycles();
    // CALL 0x1000:ca01 (1000_CB5D / 0x1CB5D)
    NearCall(cs1, 0xCB60, spice86_generated_label_call_target_1000_CA01_01CA01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CB60_01CB60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CB60_01CB60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CB60_1CB60:
    // RET  (1000_CB60 / 0x1CB60)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CB61_01CB61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CB61_1CB61:
    // TEST byte ptr [0xdbfe],0x1 (1000_CB61 / 0x1CB61)
    Alu.And8(UInt8[DS, 0xDBFE], 0x1);
    State.IncCycles();
    // JZ 0x1000:cb4c (1000_CB66 / 0x1CB66)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB44_01CB44, 0x1CB4C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x1000 (1000_CB68 / 0x1CB68)
    CX = 0x1000;
    State.IncCycles();
    // CALL 0x1000:cc2b (1000_CB6B / 0x1CB6B)
    NearCall(cs1, 0xCB6E, spice86_generated_label_call_target_1000_CC2B_01CC2B);
    State.IncCycles();
    label_1000_CB6E_1CB6E:
    // JC 0x1000:cb44 (1000_CB6E / 0x1CB6E)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0xdbea] (1000_CB70 / 0x1CB70)
    AX = UInt16[DS, 0xDBEA];
    State.IncCycles();
    // CALL 0x1000:ce07 (1000_CB73 / 0x1CB73)
    NearCall(cs1, 0xCB76, spice86_generated_label_call_target_1000_CE07_01CE07);
    State.IncCycles();
    label_1000_CB76_1CB76:
    // MOV [0xdbec],AX (1000_CB76 / 0x1CB76)
    UInt16[DS, 0xDBEC] = AX;
    State.IncCycles();
    // CALL 0x1000:ca9a (1000_CB79 / 0x1CB79)
    NearCall(cs1, 0xCB7C, spice86_generated_label_ret_target_1000_CA9A_01CA9A);
    State.IncCycles();
    label_1000_CB7C_1CB7C:
    // MOV AX,[0xdc02] (1000_CB7C / 0x1CB7C)
    AX = UInt16[DS, 0xDC02];
    State.IncCycles();
    // CMP AX,word ptr [0xdc00] (1000_CB7F / 0x1CB7F)
    Alu.Sub16(AX, UInt16[DS, 0xDC00]);
    State.IncCycles();
    // JZ 0x1000:cba0 (1000_CB83 / 0x1CB83)
    if(ZeroFlag) {
      goto label_1000_CBA0_1CBA0;
    }
    State.IncCycles();
    // CALL 0x1000:c921 (1000_CB85 / 0x1CB85)
    NearCall(cs1, 0xCB88, spice86_generated_label_call_target_1000_C921_01C921);
    State.IncCycles();
    // TEST byte ptr [BX],0x8 (1000_CB88 / 0x1CB88)
    Alu.And8(UInt8[DS, BX], 0x8);
    State.IncCycles();
    // JZ 0x1000:cb45 (1000_CB8B / 0x1CB8B)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB44_01CB44, 0x1CB45 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP word ptr [BX + -0x6],0x0 (1000_CB8D / 0x1CB8D)
    Alu.Sub16(UInt16[DS, (ushort)(BX - 0x6)], 0x0);
    State.IncCycles();
    // JZ 0x1000:cb45 (1000_CB91 / 0x1CB91)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB44_01CB44, 0x1CB45 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV [0xdc00],AX (1000_CB93 / 0x1CB93)
    UInt16[DS, 0xDC00] = AX;
    State.IncCycles();
    // LEA SI,[BX + -0x8] (1000_CB96 / 0x1CB96)
    SI = (ushort)(BX - 0x8);
    State.IncCycles();
    // MOV DI,0xdbf6 (1000_CB99 / 0x1CB99)
    DI = 0xDBF6;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_CB9C / 0x1CB9C)
    NearCall(cs1, 0xCB9F, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    // MOVSB ES:DI,SI (1000_CB9F / 0x1CB9F)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_1000_CBA0_1CBA0:
    // MOV AX,[0xdbfa] (1000_CBA0 / 0x1CBA0)
    AX = UInt16[DS, 0xDBFA];
    State.IncCycles();
    // MOV [0xdc08],AX (1000_CBA3 / 0x1CBA3)
    UInt16[DS, 0xDC08] = AX;
    State.IncCycles();
    // MOV AX,[0xdbfc] (1000_CBA6 / 0x1CBA6)
    AX = UInt16[DS, 0xDBFC];
    State.IncCycles();
    // MOV [0xdc0a],AX (1000_CBA9 / 0x1CBA9)
    UInt16[DS, 0xDC0A] = AX;
    State.IncCycles();
    // MOV AX,[0xdbf6] (1000_CBAC / 0x1CBAC)
    AX = UInt16[DS, 0xDBF6];
    State.IncCycles();
    // MOV [0xdc04],AX (1000_CBAF / 0x1CBAF)
    UInt16[DS, 0xDC04] = AX;
    State.IncCycles();
    // MOV AX,[0xdbf8] (1000_CBB2 / 0x1CBB2)
    AX = UInt16[DS, 0xDBF8];
    State.IncCycles();
    // MOV [0xdc06],AX (1000_CBB5 / 0x1CBB5)
    UInt16[DS, 0xDC06] = AX;
    State.IncCycles();
    // TEST byte ptr [0xdbfe],0x4 (1000_CBB8 / 0x1CBB8)
    Alu.And8(UInt8[DS, 0xDBFE], 0x4);
    State.IncCycles();
    // JZ 0x1000:cc09 (1000_CBBD / 0x1CBBD)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:cb00 (1000_CC09 / 0x1CC09)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB00_01CB00, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0xdc00] (1000_CBBF / 0x1CBBF)
    AX = UInt16[DS, 0xDC00];
    State.IncCycles();
    // ADD AX,0x61 (1000_CBC2 / 0x1CBC2)
    // AX += 0x61;
    AX = Alu.Add16(AX, 0x61);
    State.IncCycles();
    // CALL 0x1000:c13e (1000_CBC5 / 0x1CBC5)
    NearCall(cs1, 0xCBC8, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV BP,word ptr [0xdbb0] (1000_CBC8 / 0x1CBC8)
    BP = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // MOV CX,0x4 (1000_CBCC / 0x1CBCC)
    CX = 0x4;
    State.IncCycles();
    label_1000_CBCF_1CBCF:
    // LES DI,[0xdc0c] (1000_CBCF / 0x1CBCF)
    ES = UInt16[DS, 0xDC0E];
    DI = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // MOV AX,0x2 (1000_CBD3 / 0x1CBD3)
    AX = 0x2;
    State.IncCycles();
    // CALL 0x1000:cdf7 (1000_CBD6 / 0x1CBD6)
    NearCall(cs1, 0xCBD9, not_observed_1000_CDF7_01CDF7);
    State.IncCycles();
    // MOV AX,0xa (1000_CBD9 / 0x1CBD9)
    AX = 0xA;
    State.IncCycles();
    // STOSW ES:DI (1000_CBDC / 0x1CBDC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV SI,DI (1000_CBDD / 0x1CBDD)
    SI = DI;
    State.IncCycles();
    // CALL 0x1000:cc0c (1000_CBDF / 0x1CBDF)
    NearCall(cs1, 0xCBE2, spice86_generated_label_call_target_1000_CC0C_01CC0C);
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_CBE2 / 0x1CBE2)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    // PUSH word ptr ES:[BP + 0x0] (1000_CBE6 / 0x1CBE6)
    Stack.Push(UInt16[ES, BP]);
    State.IncCycles();
    // PUSH ES (1000_CBEA / 0x1CBEA)
    Stack.Push(ES);
    State.IncCycles();
    // LES DI,[0xdc0c] (1000_CBEB / 0x1CBEB)
    ES = UInt16[DS, 0xDC0E];
    DI = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // MOV AX,0x6d6d (1000_CBEF / 0x1CBEF)
    AX = 0x6D6D;
    State.IncCycles();
    // STOSW ES:DI (1000_CBF2 / 0x1CBF2)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,BP (1000_CBF3 / 0x1CBF3)
    AX = BP;
    State.IncCycles();
    // STOSW ES:DI (1000_CBF5 / 0x1CBF5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // POP AX (1000_CBF6 / 0x1CBF6)
    AX = Stack.Pop();
    State.IncCycles();
    // STOSW ES:DI (1000_CBF7 / 0x1CBF7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // POP AX (1000_CBF8 / 0x1CBF8)
    AX = Stack.Pop();
    State.IncCycles();
    // STOSW ES:DI (1000_CBF9 / 0x1CBF9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD BP,AX (1000_CBFA / 0x1CBFA)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    // MOV AX,0x8 (1000_CBFC / 0x1CBFC)
    AX = 0x8;
    State.IncCycles();
    // CALL 0x1000:cdf7 (1000_CBFF / 0x1CBFF)
    NearCall(cs1, 0xCC02, not_observed_1000_CDF7_01CDF7);
    State.IncCycles();
    // LOOP 0x1000:cbcf (1000_CC02 / 0x1CC02)
    if(--CX != 0) {
      goto label_1000_CBCF_1CBCF;
    }
    State.IncCycles();
    // MOV byte ptr [0xdbb5],0x80 (1000_CC04 / 0x1CC04)
    UInt8[DS, 0xDBB5] = 0x80;
    State.IncCycles();
    label_1000_CC09_1CC09:
    // JMP 0x1000:cb00 (1000_CC09 / 0x1CC09)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB00_01CB00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC0C_01CC0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CC0C_1CC0C:
    // ADD SI,AX (1000_CC0C / 0x1CC0C)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // JC 0x1000:cc16 (1000_CC0E / 0x1CC0E)
    if(CarryFlag) {
      goto label_1000_CC16_1CC16;
    }
    State.IncCycles();
    // CMP SI,word ptr [0xce74] (1000_CC10 / 0x1CC10)
    Alu.Sub16(SI, UInt16[DS, 0xCE74]);
    State.IncCycles();
    // JBE 0x1000:cc20 (1000_CC14 / 0x1CC14)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CC20_1CC20;
    }
    State.IncCycles();
    label_1000_CC16_1CC16:
    // XOR CX,CX (1000_CC16 / 0x1CC16)
    CX = 0;
    State.IncCycles();
    // XCHG word ptr [0xdc0c],CX (1000_CC18 / 0x1CC18)
    ushort tmp_1000_CC18 = UInt16[DS, 0xDC0C];
    UInt16[DS, 0xDC0C] = CX;
    CX = tmp_1000_CC18;
    State.IncCycles();
    // MOV word ptr [0xdc18],CX (1000_CC1C / 0x1CC1C)
    UInt16[DS, 0xDC18] = CX;
    State.IncCycles();
    label_1000_CC20_1CC20:
    // SUB AX,0x2 (1000_CC20 / 0x1CC20)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // MOV [0xdc20],AX (1000_CC23 / 0x1CC23)
    UInt16[DS, 0xDC20] = AX;
    State.IncCycles();
    // INC word ptr [0xdbea] (1000_CC26 / 0x1CC26)
    UInt16[DS, 0xDBEA] = Alu.Inc16(UInt16[DS, 0xDBEA]);
    State.IncCycles();
    // RET  (1000_CC2A / 0x1CC2A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC2B_01CC2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CC2B_1CC2B:
    // MOV AX,[0xdc0c] (1000_CC2B / 0x1CC2B)
    AX = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // MOV BX,word ptr [0xdc10] (1000_CC2E / 0x1CC2E)
    BX = UInt16[DS, 0xDC10];
    State.IncCycles();
    // CMP AX,BX (1000_CC32 / 0x1CC32)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JNC 0x1000:cc3f (1000_CC34 / 0x1CC34)
    if(!CarryFlag) {
      goto label_1000_CC3F_1CC3F;
    }
    State.IncCycles();
    // ADD AX,CX (1000_CC36 / 0x1CC36)
    AX += CX;
    State.IncCycles();
    // ADD AX,0x12 (1000_CC38 / 0x1CC38)
    AX += 0x12;
    State.IncCycles();
    // CMP BX,AX (1000_CC3B / 0x1CC3B)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JC 0x1000:cc4d (1000_CC3D / 0x1CC3D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CC4D / 0x1CC4D)
      return NearRet();
    }
    State.IncCycles();
    label_1000_CC3F_1CC3F:
    // MOV AX,[0xdc1a] (1000_CC3F / 0x1CC3F)
    AX = UInt16[DS, 0xDC1A];
    State.IncCycles();
    // ADD AX,0xa (1000_CC42 / 0x1CC42)
    AX += 0xA;
    State.IncCycles();
    // ADD AX,CX (1000_CC45 / 0x1CC45)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // JC 0x1000:cc4d (1000_CC47 / 0x1CC47)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CC4D / 0x1CC4D)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0xdc18],AX (1000_CC49 / 0x1CC49)
    Alu.Sub16(UInt16[DS, 0xDC18], AX);
    State.IncCycles();
    label_1000_CC4D_1CC4D:
    // RET  (1000_CC4D / 0x1CC4D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC4E_01CC4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CC4E_1CC4E:
    // LES SI,[0xdc10] (1000_CC4E / 0x1CC4E)
    ES = UInt16[DS, 0xDC12];
    SI = UInt16[DS, 0xDC10];
    State.IncCycles();
    // LODSW ES:SI (1000_CC52 / 0x1CC52)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB word ptr [0xdc1a],AX (1000_CC54 / 0x1CC54)
    UInt16[DS, 0xDC1A] -= AX;
    State.IncCycles();
    // ADD SI,AX (1000_CC58 / 0x1CC58)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // JC 0x1000:cc62 (1000_CC5A / 0x1CC5A)
    if(CarryFlag) {
      goto label_1000_CC62_1CC62;
    }
    State.IncCycles();
    // CMP SI,word ptr [0xce74] (1000_CC5C / 0x1CC5C)
    Alu.Sub16(SI, UInt16[DS, 0xCE74]);
    State.IncCycles();
    // JBE 0x1000:cc6a (1000_CC60 / 0x1CC60)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CC6A_1CC6A;
    }
    State.IncCycles();
    label_1000_CC62_1CC62:
    // SUB AX,0x2 (1000_CC62 / 0x1CC62)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // MOV [0xdc10],AX (1000_CC65 / 0x1CC65)
    UInt16[DS, 0xDC10] = AX;
    State.IncCycles();
    // XOR AX,AX (1000_CC68 / 0x1CC68)
    AX = 0;
    State.IncCycles();
    label_1000_CC6A_1CC6A:
    // ADD word ptr [0xdc10],AX (1000_CC6A / 0x1CC6A)
    // UInt16[DS, 0xDC10] += AX;
    UInt16[DS, 0xDC10] = Alu.Add16(UInt16[DS, 0xDC10], AX);
    State.IncCycles();
    // MOV AX,[0xdbe8] (1000_CC6E / 0x1CC6E)
    AX = UInt16[DS, 0xDBE8];
    State.IncCycles();
    // INC AX (1000_CC71 / 0x1CC71)
    AX++;
    State.IncCycles();
    // CMP AX,word ptr [0xdbec] (1000_CC72 / 0x1CC72)
    Alu.Sub16(AX, UInt16[DS, 0xDBEC]);
    State.IncCycles();
    // JBE 0x1000:cc81 (1000_CC76 / 0x1CC76)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CC81_1CC81;
    }
    State.IncCycles();
    // MOV AX,0x1 (1000_CC78 / 0x1CC78)
    AX = 0x1;
    State.IncCycles();
    // MOV word ptr [0xdbec],0xffff (1000_CC7B / 0x1CC7B)
    UInt16[DS, 0xDBEC] = 0xFFFF;
    State.IncCycles();
    label_1000_CC81_1CC81:
    // MOV [0xdbe8],AX (1000_CC81 / 0x1CC81)
    UInt16[DS, 0xDBE8] = AX;
    State.IncCycles();
    // RET  (1000_CC84 / 0x1CC84)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC85_01CC85(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CC85_1CC85:
    // CMP byte ptr [0xdbe7],0x0 (1000_CC85 / 0x1CC85)
    Alu.Sub8(UInt8[DS, 0xDBE7], 0x0);
    State.IncCycles();
    // JZ 0x1000:cc91 (1000_CC8A / 0x1CC8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CC91 / 0x1CC91)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xdbe7],0x1 (1000_CC8C / 0x1CC8C)
    Alu.Sub8(UInt8[DS, 0xDBE7], 0x1);
    State.IncCycles();
    label_1000_CC91_1CC91:
    // RET  (1000_CC91 / 0x1CC91)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC96_01CC96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CC96_1CC96:
    // MOV AX,[0x38fb] (1000_CC96 / 0x1CC96)
    AX = UInt16[DS, 0x38FB];
    State.IncCycles();
    // MOV CS:[0xcc94],AX (1000_CC99 / 0x1CC99)
    UInt16[cs1, 0xCC94] = AX;
    State.IncCycles();
    // XOR BP,BP (1000_CC9D / 0x1CC9D)
    BP = 0;
    State.IncCycles();
    // XCHG word ptr [0xdc16],BP (1000_CC9F / 0x1CC9F)
    ushort tmp_1000_CC9F = UInt16[DS, 0xDC16];
    UInt16[DS, 0xDC16] = BP;
    BP = tmp_1000_CC9F;
    State.IncCycles();
    // OR BP,BP (1000_CCA3 / 0x1CCA3)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JZ 0x1000:cc4d (1000_CCA5 / 0x1CCA5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CC4D / 0x1CC4D)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0xdc14] (1000_CCA7 / 0x1CCA7)
    SI = UInt16[DS, 0xDC14];
    State.IncCycles();
    // MOV AL,[0xdbfe] (1000_CCAB / 0x1CCAB)
    AL = UInt8[DS, 0xDBFE];
    State.IncCycles();
    // TEST AL,0x30 (1000_CCAE / 0x1CCAE)
    Alu.And8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:ccea (1000_CCB0 / 0x1CCB0)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CCEA_01CCEA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH DS (1000_CCB2 / 0x1CCB2)
    Stack.Push(DS);
    State.IncCycles();
    // TEST word ptr [0xdc24],0x400 (1000_CCB3 / 0x1CCB3)
    Alu.And16(UInt16[DS, 0xDC24], 0x400);
    State.IncCycles();
    // JNZ 0x1000:cce1 (1000_CCB9 / 0x1CCB9)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE1_01CCE1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_CCBB / 0x1CCBB)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV BX,word ptr [0xdc00] (1000_CCBF / 0x1CCBF)
    BX = UInt16[DS, 0xDC00];
    State.IncCycles();
    // MOV DS,BP (1000_CCC3 / 0x1CCC3)
    DS = BP;
    State.IncCycles();
    // LODSW SI (1000_CCC5 / 0x1CCC5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AH,0xf9 (1000_CCC6 / 0x1CCC6)
    // AH &= 0xF9;
    AH = Alu.And8(AH, 0xF9);
    State.IncCycles();
    // MOV DI,AX (1000_CCC9 / 0x1CCC9)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_CCCB / 0x1CCCB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_CCCC / 0x1CCCC)
    CX = AX;
    State.IncCycles();
    // OR CL,CL (1000_CCCE / 0x1CCCE)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JZ 0x1000:cce1 (1000_CCD0 / 0x1CCD0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE1_01CCE1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // LODSW SI (1000_CCD2 / 0x1CCD2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_CCD3 / 0x1CCD3)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_CCD5 / 0x1CCD5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AX,BX (1000_CCD6 / 0x1CCD6)
    ushort tmp_1000_CCD6 = AX;
    AX = BX;
    BX = tmp_1000_CCD6;
    State.IncCycles();
    // CMP AX,0x19 (1000_CCD7 / 0x1CCD7)
    Alu.Sub16(AX, 0x19);
    State.IncCycles();
    // JNC 0x1000:cce3 (1000_CCDA / 0x1CCDA)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CCE3_01CCE3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALLF [0x38c9] (1000_CCDC / 0x1CCDC)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_CCDC = (uint)(UInt16[SS, 0x38CB] * 0x10 + UInt16[SS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_CCDC) {
      case 0x235BF : FarCall(cs1, 0xCCE1, spice86_generated_label_call_target_334B_010F_0335BF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CCDC));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE1_01CCE1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CCE1_01CCE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CCE1_1CCE1:
    // POP DS (1000_CCE1 / 0x1CCE1)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CCE2 / 0x1CCE2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CCE3_01CCE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CCE3_1CCE3:
    // CALLF [0xcc92] (1000_CCE3 / 0x1CCE3)
    // Indirect call to [0xcc92], generating possible targets from emulator records
    uint targetAddress_1000_CCE3 = (uint)(UInt16[cs1, 0xCC94] * 0x10 + UInt16[cs1, 0xCC92]);
    switch(targetAddress_1000_CCE3) {
      case 0x235E3 : FarCall(cs1, 0xCCE8, spice86_generated_label_call_target_334B_0133_0335E3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CCE3));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE8_01CCE8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CCE8_01CCE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CCE8_1CCE8:
    // POP DS (1000_CCE8 / 0x1CCE8)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CCE9 / 0x1CCE9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CCEA_01CCEA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CCEA_1CCEA:
    // TEST AL,0x20 (1000_CCEA / 0x1CCEA)
    Alu.And8(AL, 0x20);
    State.IncCycles();
    // JNZ 0x1000:ccf1 (1000_CCEC / 0x1CCEC)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:4aeb (1000_CCF1 / 0x1CCF1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_4AEB_014AEB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:4afd (1000_CCEE / 0x1CCEE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_4AEB_014AEB, 0x14AFD - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_CCF1_1CCF1:
    // JMP 0x1000:4aeb (1000_CCF1 / 0x1CCF1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_4AEB_014AEB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CCF4_01CCF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CCF4_1CCF4:
    // MOV word ptr [0xdc1c],0xffff (1000_CCF4 / 0x1CCF4)
    UInt16[DS, 0xDC1C] = 0xFFFF;
    State.IncCycles();
    // MOV word ptr [0xdc1e],0xffff (1000_CCFA / 0x1CCFA)
    UInt16[DS, 0xDC1E] = 0xFFFF;
    State.IncCycles();
    // ADD AX,SI (1000_CD00 / 0x1CD00)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    State.IncCycles();
    // JC 0x1000:cd0a (1000_CD02 / 0x1CD02)
    if(CarryFlag) {
      goto label_1000_CD0A_1CD0A;
    }
    State.IncCycles();
    // CMP AX,word ptr [0xce74] (1000_CD04 / 0x1CD04)
    Alu.Sub16(AX, UInt16[DS, 0xCE74]);
    State.IncCycles();
    // JBE 0x1000:cd0c (1000_CD08 / 0x1CD08)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CD0C_1CD0C;
    }
    State.IncCycles();
    label_1000_CD0A_1CD0A:
    // XOR SI,SI (1000_CD0A / 0x1CD0A)
    SI = 0;
    State.IncCycles();
    label_1000_CD0C_1CD0C:
    // LODSW ES:SI (1000_CD0C / 0x1CD0C)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,0x6473 (1000_CD0E / 0x1CD0E)
    Alu.Sub16(AX, 0x6473);
    State.IncCycles();
    // JNZ 0x1000:cd25 (1000_CD11 / 0x1CD11)
    if(!ZeroFlag) {
      goto label_1000_CD25_1CD25;
    }
    State.IncCycles();
    // CALL 0x1000:ae2f (1000_CD13 / 0x1CD13)
    NearCall(cs1, 0xCD16, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    State.IncCycles();
    label_1000_CD16_1CD16:
    // JZ 0x1000:cd1c (1000_CD16 / 0x1CD16)
    if(ZeroFlag) {
      goto label_1000_CD1C_1CD1C;
    }
    State.IncCycles();
    // MOV word ptr [0xdc1c],SI (1000_CD18 / 0x1CD18)
    UInt16[DS, 0xDC1C] = SI;
    State.IncCycles();
    label_1000_CD1C_1CD1C:
    // LODSW ES:SI (1000_CD1C / 0x1CD1C)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB AX,0x4 (1000_CD1E / 0x1CD1E)
    AX -= 0x4;
    State.IncCycles();
    // ADD SI,AX (1000_CD21 / 0x1CD21)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // LODSW ES:SI (1000_CD23 / 0x1CD23)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    label_1000_CD25_1CD25:
    // CMP AX,0x6c70 (1000_CD25 / 0x1CD25)
    Alu.Sub16(AX, 0x6C70);
    State.IncCycles();
    // JNZ 0x1000:cd37 (1000_CD28 / 0x1CD28)
    if(!ZeroFlag) {
      goto label_1000_CD37_1CD37;
    }
    State.IncCycles();
    // LODSW ES:SI (1000_CD2A / 0x1CD2A)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV word ptr [0xdc1e],SI (1000_CD2C / 0x1CD2C)
    UInt16[DS, 0xDC1E] = SI;
    State.IncCycles();
    // SUB AX,0x4 (1000_CD30 / 0x1CD30)
    AX -= 0x4;
    State.IncCycles();
    // ADD SI,AX (1000_CD33 / 0x1CD33)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // JMP 0x1000:cd0c (1000_CD35 / 0x1CD35)
    goto label_1000_CD0C_1CD0C;
    State.IncCycles();
    label_1000_CD37_1CD37:
    // CMP AX,0x6d6d (1000_CD37 / 0x1CD37)
    Alu.Sub16(AX, 0x6D6D);
    State.IncCycles();
    // JNZ 0x1000:cd4e (1000_CD3A / 0x1CD3A)
    if(!ZeroFlag) {
      goto label_1000_CD4E_1CD4E;
    }
    State.IncCycles();
    // MOV BX,word ptr ES:[SI + 0x4] (1000_CD3C / 0x1CD3C)
    BX = UInt16[ES, (ushort)(SI + 0x4)];
    State.IncCycles();
    // LES SI,ES:[SI] (1000_CD40 / 0x1CD40)
    ES = UInt16[ES, (ushort)(SI + 2)];
    SI = UInt16[ES, SI];
    State.IncCycles();
    // LODSW ES:SI (1000_CD43 / 0x1CD43)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,BX (1000_CD45 / 0x1CD45)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // LODSW ES:SI (1000_CD47 / 0x1CD47)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // JZ 0x1000:cd4e (1000_CD49 / 0x1CD49)
    if(ZeroFlag) {
      goto label_1000_CD4E_1CD4E;
    }
    State.IncCycles();
    // JMP 0x1000:cc4e (1000_CD4B / 0x1CD4B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CC4E_01CC4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_CD4E_1CD4E:
    // PUSH DS (1000_CD4E / 0x1CD4E)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_CD4F / 0x1CD4F)
    Stack.Push(ES);
    State.IncCycles();
    // MOV ES,BP (1000_CD50 / 0x1CD50)
    ES = BP;
    State.IncCycles();
    // XOR DI,DI (1000_CD52 / 0x1CD52)
    DI = 0;
    State.IncCycles();
    // TEST AH,0x4 (1000_CD54 / 0x1CD54)
    Alu.And8(AH, 0x4);
    State.IncCycles();
    // JZ 0x1000:cd5d (1000_CD57 / 0x1CD57)
    if(ZeroFlag) {
      goto label_1000_CD5D_1CD5D;
    }
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_CD59 / 0x1CD59)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    label_1000_CD5D_1CD5D:
    // MOV word ptr [0xdc16],ES (1000_CD5D / 0x1CD5D)
    UInt16[DS, 0xDC16] = ES;
    State.IncCycles();
    // MOV word ptr [0xdc14],DI (1000_CD61 / 0x1CD61)
    UInt16[DS, 0xDC14] = DI;
    State.IncCycles();
    // MOV [0xdc24],AX (1000_CD65 / 0x1CD65)
    UInt16[DS, 0xDC24] = AX;
    State.IncCycles();
    // POP DS (1000_CD68 / 0x1CD68)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV CX,AX (1000_CD69 / 0x1CD69)
    CX = AX;
    State.IncCycles();
    // LODSW SI (1000_CD6B / 0x1CD6B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AX,CX (1000_CD6C / 0x1CD6C)
    ushort tmp_1000_CD6C = AX;
    AX = CX;
    CX = tmp_1000_CD6C;
    State.IncCycles();
    // TEST AH,0x4 (1000_CD6D / 0x1CD6D)
    Alu.And8(AH, 0x4);
    State.IncCycles();
    // JNZ 0x1000:cd7c (1000_CD70 / 0x1CD70)
    if(!ZeroFlag) {
      goto label_1000_CD7C_1CD7C;
    }
    State.IncCycles();
    // STOSW ES:DI (1000_CD72 / 0x1CD72)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // XCHG AX,CX (1000_CD73 / 0x1CD73)
    ushort tmp_1000_CD73 = AX;
    AX = CX;
    CX = tmp_1000_CD73;
    State.IncCycles();
    // STOSW ES:DI (1000_CD74 / 0x1CD74)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JCXZ 0x1000:cd7f (1000_CD75 / 0x1CD75)
    if(CX == 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CD7F_01CD7F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST CH,0x2 (1000_CD77 / 0x1CD77)
    Alu.And8(CH, 0x2);
    State.IncCycles();
    // JZ 0x1000:cd81 (1000_CD7A / 0x1CD7A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CD81_01CD81, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_CD7C_1CD7C:
    // CALL 0x1000:f403 (1000_CD7C / 0x1CD7C)
    NearCall(cs1, 0xCD7F, spice86_generated_label_call_target_1000_F403_01F403);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CD7F_01CD7F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CD7F_01CD7F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CD7F_1CD7F:
    // POP DS (1000_CD7F / 0x1CD7F)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_CD80 / 0x1CD80)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CD81_01CD81(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CD81_1CD81:
    // SUB SI,0x4 (1000_CD81 / 0x1CD81)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    State.IncCycles();
    // MOV AX,DS (1000_CD84 / 0x1CD84)
    AX = DS;
    State.IncCycles();
    // POP DS (1000_CD86 / 0x1CD86)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0xdc14],SI (1000_CD87 / 0x1CD87)
    UInt16[DS, 0xDC14] = SI;
    State.IncCycles();
    // MOV [0xdc16],AX (1000_CD8B / 0x1CD8B)
    UInt16[DS, 0xDC16] = AX;
    State.IncCycles();
    // RET  (1000_CD8E / 0x1CD8E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CD8F_01CD8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CD8F_1CD8F:
    // MOV CX,0x2 (1000_CD8F / 0x1CD8F)
    CX = 0x2;
    State.IncCycles();
    // CALL 0x1000:cdbf (1000_CD92 / 0x1CD92)
    NearCall(cs1, 0xCD95, spice86_generated_label_call_target_1000_CDBF_01CDBF);
    State.IncCycles();
    label_1000_CD95_1CD95:
    // JC 0x1000:cd9f (1000_CD95 / 0x1CD95)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CD9F / 0x1CD9F)
      return NearRet();
    }
    State.IncCycles();
    // LES SI,[0xdc0c] (1000_CD97 / 0x1CD97)
    ES = UInt16[DS, 0xDC0E];
    SI = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // MOV AX,word ptr ES:[SI + -0x2] (1000_CD9B / 0x1CD9B)
    AX = UInt16[ES, (ushort)(SI - 0x2)];
    State.IncCycles();
    label_1000_CD9F_1CD9F:
    // RET  (1000_CD9F / 0x1CD9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CDA0_01CDA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CDA0_1CDA0:
    // CALL 0x1000:ce1a (1000_CDA0 / 0x1CDA0)
    NearCall(cs1, 0xCDA3, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    State.IncCycles();
    label_1000_CDA3_1CDA3:
    // CALL 0x1000:cd8f (1000_CDA3 / 0x1CDA3)
    NearCall(cs1, 0xCDA6, spice86_generated_label_call_target_1000_CD8F_01CD8F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CDA6_01CDA6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CDA6_01CDA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CDA6_1CDA6:
    // JC 0x1000:ce00 (1000_CDA6 / 0x1CDA6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CE00 / 0x1CE00)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [0xce74] (1000_CDA8 / 0x1CDA8)
    DI = UInt16[DS, 0xCE74];
    State.IncCycles();
    // SUB DI,AX (1000_CDAC / 0x1CDAC)
    DI -= AX;
    State.IncCycles();
    // SUB DI,0x2 (1000_CDAE / 0x1CDAE)
    // DI -= 0x2;
    DI = Alu.Sub16(DI, 0x2);
    State.IncCycles();
    // MOV word ptr [0xdc10],DI (1000_CDB1 / 0x1CDB1)
    UInt16[DS, 0xDC10] = DI;
    State.IncCycles();
    // STOSW ES:DI (1000_CDB5 / 0x1CDB5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV word ptr [0xdc0c],DI (1000_CDB6 / 0x1CDB6)
    UInt16[DS, 0xDC0C] = DI;
    State.IncCycles();
    // MOV CX,AX (1000_CDBA / 0x1CDBA)
    CX = AX;
    State.IncCycles();
    // SUB CX,0x2 (1000_CDBC / 0x1CDBC)
    // CX -= 0x2;
    CX = Alu.Sub16(CX, 0x2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CDBF_01CDBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CDBF_01CDBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CDBF_1CDBF:
    // MOV BX,word ptr [0x35a6] (1000_CDBF / 0x1CDBF)
    BX = UInt16[DS, 0x35A6];
    State.IncCycles();
    // CMP BX,0x1 (1000_CDC3 / 0x1CDC3)
    Alu.Sub16(BX, 0x1);
    State.IncCycles();
    // JC 0x1000:ce00 (1000_CDC6 / 0x1CDC6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CE00 / 0x1CE00)
      return NearRet();
    }
    State.IncCycles();
    label_1000_CDC8_1CDC8:
    // PUSH CX (1000_CDC8 / 0x1CDC8)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,word ptr [0xdc06] (1000_CDC9 / 0x1CDC9)
    CX = UInt16[DS, 0xDC06];
    State.IncCycles();
    // MOV DX,word ptr [0xdc04] (1000_CDCD / 0x1CDCD)
    DX = UInt16[DS, 0xDC04];
    State.IncCycles();
    // MOV AX,0x4200 (1000_CDD1 / 0x1CDD1)
    AX = 0x4200;
    State.IncCycles();
    // INT 0x21 (1000_CDD4 / 0x1CDD4)
    Interrupt(0x21);
    State.IncCycles();
    // POP CX (1000_CDD6 / 0x1CDD6)
    CX = Stack.Pop();
    State.IncCycles();
    // PUSH DS (1000_CDD7 / 0x1CDD7)
    Stack.Push(DS);
    State.IncCycles();
    // LDS DX,[0xdc0c] (1000_CDD8 / 0x1CDD8)
    DS = UInt16[DS, 0xDC0E];
    DX = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // MOV AH,0x3f (1000_CDDC / 0x1CDDC)
    AH = 0x3F;
    State.IncCycles();
    // INT 0x21 (1000_CDDE / 0x1CDDE)
    Interrupt(0x21);
    State.IncCycles();
    // POP DS (1000_CDE0 / 0x1CDE0)
    DS = Stack.Pop();
    State.IncCycles();
    // CMP AX,CX (1000_CDE1 / 0x1CDE1)
    Alu.Sub16(AX, CX);
    State.IncCycles();
    // JC 0x1000:cdc8 (1000_CDE3 / 0x1CDE3)
    if(CarryFlag) {
      goto label_1000_CDC8_1CDC8;
    }
    State.IncCycles();
    // SUB word ptr [0xdc08],AX (1000_CDE5 / 0x1CDE5)
    // UInt16[DS, 0xDC08] -= AX;
    UInt16[DS, 0xDC08] = Alu.Sub16(UInt16[DS, 0xDC08], AX);
    State.IncCycles();
    // SBB word ptr [0xdc0a],0x0 (1000_CDE9 / 0x1CDE9)
    UInt16[DS, 0xDC0A] = Alu.Sbb16(UInt16[DS, 0xDC0A], 0x0);
    State.IncCycles();
    // ADD word ptr [0xdc04],AX (1000_CDEE / 0x1CDEE)
    // UInt16[DS, 0xDC04] += AX;
    UInt16[DS, 0xDC04] = Alu.Add16(UInt16[DS, 0xDC04], AX);
    State.IncCycles();
    // ADC word ptr [0xdc06],0x0 (1000_CDF2 / 0x1CDF2)
    UInt16[DS, 0xDC06] = Alu.Adc16(UInt16[DS, 0xDC06], 0x0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_CDF7_01CDF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_CDF7_01CDF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CDF7_1CDF7:
    // ADD word ptr [0xdc0c],AX (1000_CDF7 / 0x1CDF7)
    UInt16[DS, 0xDC0C] += AX;
    State.IncCycles();
    // ADD word ptr [0xdc1a],AX (1000_CDFB / 0x1CDFB)
    // UInt16[DS, 0xDC1A] += AX;
    UInt16[DS, 0xDC1A] = Alu.Add16(UInt16[DS, 0xDC1A], AX);
    State.IncCycles();
    // CLC  (1000_CDFF / 0x1CDFF)
    CarryFlag = false;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_CE00_01CE00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_CE00_01CE00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE00_1CE00:
    // RET  (1000_CE00 / 0x1CE00)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE01_01CE01(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE01_1CE01:
    // MOV word ptr [0xdbe8],0x0 (1000_CE01 / 0x1CE01)
    UInt16[DS, 0xDBE8] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CE07_01CE07, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE07_01CE07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE07_1CE07:
    // MOV word ptr [0xdbea],0x0 (1000_CE07 / 0x1CE07)
    UInt16[DS, 0xDBEA] = 0x0;
    State.IncCycles();
    // MOV word ptr [0xdbec],0xffff (1000_CE0D / 0x1CE0D)
    UInt16[DS, 0xDBEC] = 0xFFFF;
    State.IncCycles();
    // MOV word ptr [0xdbee],0xffff (1000_CE13 / 0x1CE13)
    UInt16[DS, 0xDBEE] = 0xFFFF;
    State.IncCycles();
    // RET  (1000_CE19 / 0x1CE19)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE1A_01CE1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE1A_1CE1A:
    // MOV AX,[0xdbde] (1000_CE1A / 0x1CE1A)
    AX = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // MOV [0xdc0e],AX (1000_CE1D / 0x1CE1D)
    UInt16[DS, 0xDC0E] = AX;
    State.IncCycles();
    // MOV [0xdc12],AX (1000_CE20 / 0x1CE20)
    UInt16[DS, 0xDC12] = AX;
    State.IncCycles();
    // XOR AX,AX (1000_CE23 / 0x1CE23)
    AX = 0;
    State.IncCycles();
    // MOV [0xdc0c],AX (1000_CE25 / 0x1CE25)
    UInt16[DS, 0xDC0C] = AX;
    State.IncCycles();
    // MOV [0xdc10],AX (1000_CE28 / 0x1CE28)
    UInt16[DS, 0xDC10] = AX;
    State.IncCycles();
    // MOV [0xdc1a],AX (1000_CE2B / 0x1CE2B)
    UInt16[DS, 0xDC1A] = AX;
    State.IncCycles();
    // MOV [0xdc20],AX (1000_CE2E / 0x1CE2E)
    UInt16[DS, 0xDC20] = AX;
    State.IncCycles();
    // MOV [0xdc16],AX (1000_CE31 / 0x1CE31)
    UInt16[DS, 0xDC16] = AX;
    State.IncCycles();
    // MOV AX,[0xce74] (1000_CE34 / 0x1CE34)
    AX = UInt16[DS, 0xCE74];
    State.IncCycles();
    // MOV [0xdc18],AX (1000_CE37 / 0x1CE37)
    UInt16[DS, 0xDC18] = AX;
    State.IncCycles();
    // RET  (1000_CE3A / 0x1CE3A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE3B_01CE3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE3B_1CE3B:
    // LES SI,[0xdc0c] (1000_CE3B / 0x1CE3B)
    ES = UInt16[DS, 0xDC0E];
    SI = UInt16[DS, 0xDC0C];
    State.IncCycles();
    // MOV SI,word ptr [0xdc1e] (1000_CE3F / 0x1CE3F)
    SI = UInt16[DS, 0xDC1E];
    State.IncCycles();
    // CALL 0x1000:c1ba (1000_CE43 / 0x1CE43)
    NearCall(cs1, 0xCE46, spice86_generated_label_call_target_1000_C1BA_01C1BA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CE46_01CE46, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CE46_01CE46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE46_1CE46:
    // CALLF [0x3935] (1000_CE46 / 0x1CE46)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_CE46 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_CE46) {
      case 0x23610 : FarCall(cs1, 0xCE4A, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CE46));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CE4A_01CE4A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CE4A_01CE4A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE4A_1CE4A:
    // RET  (1000_CE4A / 0x1CE4A)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_CE4B_01CE4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE4B_1CE4B:
    // MOV word ptr [0xdc02],BX (1000_CE4B / 0x1CE4B)
    UInt16[DS, 0xDC02] = BX;
    State.IncCycles();
    // MOV [0xdbee],AX (1000_CE4F / 0x1CE4F)
    UInt16[DS, 0xDBEE] = AX;
    State.IncCycles();
    // RET  (1000_CE52 / 0x1CE52)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE53_01CE53(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE53_1CE53:
    // TEST byte ptr [0x3403],0x4 (1000_CE53 / 0x1CE53)
    Alu.And8(UInt8[DS, 0x3403], 0x4);
    State.IncCycles();
    // JZ 0x1000:ce6b (1000_CE58 / 0x1CE58)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_CE6B / 0x1CE6B)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x2 (1000_CE5A / 0x1CE5A)
    AX = 0x2;
    State.IncCycles();
    label_1000_CE5D_1CE5D:
    // PUSH AX (1000_CE5D / 0x1CE5D)
    Stack.Push(AX);
    State.IncCycles();
    // ADD AX,0x61 (1000_CE5E / 0x1CE5E)
    // AX += 0x61;
    AX = Alu.Add16(AX, 0x61);
    State.IncCycles();
    // CALL 0x1000:c13e (1000_CE61 / 0x1CE61)
    NearCall(cs1, 0xCE64, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // POP AX (1000_CE64 / 0x1CE64)
    AX = Stack.Pop();
    State.IncCycles();
    // INC AX (1000_CE65 / 0x1CE65)
    AX++;
    State.IncCycles();
    // CMP AX,0x8 (1000_CE66 / 0x1CE66)
    Alu.Sub16(AX, 0x8);
    State.IncCycles();
    // JC 0x1000:ce5d (1000_CE69 / 0x1CE69)
    if(CarryFlag) {
      goto label_1000_CE5D_1CE5D;
    }
    State.IncCycles();
    label_1000_CE6B_1CE6B:
    // RET  (1000_CE6B / 0x1CE6B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE6C_01CE6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_CE6C_1CE6C:
    // TEST byte ptr [0x2943],0x2 (1000_CE6C / 0x1CE6C)
    Alu.And8(UInt8[DS, 0x2943], 0x2);
    State.IncCycles();
    // JNZ 0x1000:ce7b (1000_CE71 / 0x1CE71)
    if(!ZeroFlag) {
      goto label_1000_CE7B_1CE7B;
    }
    State.IncCycles();
    // CMP word ptr [0x39a9],0x15e (1000_CE73 / 0x1CE73)
    Alu.Sub16(UInt16[DS, 0x39A9], 0x15E);
    State.IncCycles();
    // JNC 0x1000:ce8a (1000_CE79 / 0x1CE79)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CE7E_01CE7E, 0x1CE8A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_CE7B_1CE7B:
    // MOV AX,0x2 (1000_CE7B / 0x1CE7B)
    AX = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CE7E_01CE7E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
