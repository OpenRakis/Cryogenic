namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_334B_3626_036AD6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26AE3: goto label_334B_3633_36AE3;break; // Target of external jump from 0x36AFD
      case 0x26ADD: goto label_334B_362D_36ADD;break; // Target of external jump from 0x36B02
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_3626_36AD6:
    // POP BX (334B_3626 / 0x36AD6)
    BX = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_3627 / 0x36AD7)
    DX = Stack.Pop();
    State.IncCycles();
    // PUSH ES (334B_3628 / 0x36AD8)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_3629 / 0x36AD9)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x2 (334B_362A / 0x36ADA)
    CX = 0x2;
    State.IncCycles();
    label_334B_362D_36ADD:
    // PUSH BX (334B_362D / 0x36ADD)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_362E / 0x36ADE)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_362F / 0x36ADF)
    Stack.Push(DX);
    State.IncCycles();
    // MOV CX,0x8 (334B_3630 / 0x36AE0)
    CX = 0x8;
    State.IncCycles();
    label_334B_3633_36AE3:
    // PUSH BX (334B_3633 / 0x36AE3)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_3634 / 0x36AE4)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_3635 / 0x36AE5)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_3636 / 0x36AE6)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_363C_36AEC:
    // POP BX (334B_363C / 0x36AEC)
    BX = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_334B_3640_36AF0:
    // POP DX (334B_3640 / 0x36AF0)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_3641 / 0x36AF1)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_3642 / 0x36AF2)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD DX,word ptr CS:[0x35ea] (334B_3643 / 0x36AF3)
    DX += UInt16[cs2, 0x35EA];
    State.IncCycles();
    // ADD BX,word ptr CS:[0x35ec] (334B_3648 / 0x36AF8)
    // BX += UInt16[cs2, 0x35EC];
    BX = Alu.Add16(BX, UInt16[cs2, 0x35EC]);
    State.IncCycles();
    // LOOP 0x3000:6ae3 (334B_364D / 0x36AFD)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3626_036AD6, 0x36AE3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP DX (334B_364F / 0x36AFF)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_3650 / 0x36B00)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_3651 / 0x36B01)
    BX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x3000:6add (334B_3652 / 0x36B02)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3626_036AD6, 0x36ADD - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,0x2 (334B_3654 / 0x36B04)
    AX = 0x2;
    State.IncCycles();
    label_334B_3657_36B07:
    // PUSH AX (334B_3657 / 0x36B07)
    Stack.Push(AX);
    State.IncCycles();
    // MOV DX,word ptr CS:[0x35f6] (334B_3658 / 0x36B08)
    DX = UInt16[cs2, 0x35F6];
    State.IncCycles();
    // MOV BX,word ptr CS:[0x35f8] (334B_365D / 0x36B0D)
    BX = UInt16[cs2, 0x35F8];
    State.IncCycles();
    // MOV CX,0x14 (334B_3662 / 0x36B12)
    CX = 0x14;
    State.IncCycles();
    // MOV SI,0x14 (334B_3665 / 0x36B15)
    SI = 0x14;
    State.IncCycles();
    // MOV AX,0x8 (334B_3668 / 0x36B18)
    AX = 0x8;
    State.IncCycles();
    label_334B_366B_36B1B:
    // PUSH AX (334B_366B / 0x36B1B)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_366C / 0x36B1C)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_366D / 0x36B1D)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_366E / 0x36B1E)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_366F / 0x36B1F)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_3670 / 0x36B20)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // MOV word ptr CS:[0x35fa],DX (334B_3673 / 0x36B23)
    UInt16[cs2, 0x35FA] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x35fc],BX (334B_3678 / 0x36B28)
    UInt16[cs2, 0x35FC] = BX;
    State.IncCycles();
    // MOV word ptr CS:[0x35fe],CX (334B_367D / 0x36B2D)
    UInt16[cs2, 0x35FE] = CX;
    State.IncCycles();
    // MOV word ptr CS:[0x3600],SI (334B_3682 / 0x36B32)
    UInt16[cs2, 0x3600] = SI;
    State.IncCycles();
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
    State.IncCycles();
    label_334B_368A_36B3A:
    // POP BX (334B_368A / 0x36B3A)
    BX = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_334B_368E_36B3E:
    // POP SI (334B_368E / 0x36B3E)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_368F / 0x36B3F)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_3690 / 0x36B40)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_3691 / 0x36B41)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV AX,CS:[0x35ee] (334B_3692 / 0x36B42)
    AX = UInt16[cs2, 0x35EE];
    State.IncCycles();
    // SUB DX,AX (334B_3696 / 0x36B46)
    DX -= AX;
    State.IncCycles();
    // ADD CX,AX (334B_3698 / 0x36B48)
    CX += AX;
    State.IncCycles();
    // ADD CX,AX (334B_369A / 0x36B4A)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    // MOV AX,CS:[0x35f0] (334B_369C / 0x36B4C)
    AX = UInt16[cs2, 0x35F0];
    State.IncCycles();
    // SUB BX,AX (334B_36A0 / 0x36B50)
    BX -= AX;
    State.IncCycles();
    // ADD SI,AX (334B_36A2 / 0x36B52)
    SI += AX;
    State.IncCycles();
    // ADD SI,AX (334B_36A4 / 0x36B54)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // POP AX (334B_36A6 / 0x36B56)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AX (334B_36A7 / 0x36B57)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:6b1b (334B_36A8 / 0x36B58)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3640_036AF0, 0x36B1B - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP AX (334B_36AA / 0x36B5A)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AX (334B_36AB / 0x36B5B)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:6b07 (334B_36AC / 0x36B5C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3640_036AF0, 0x36B07 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP DS (334B_36AE / 0x36B5E)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_36AF / 0x36B5F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_36B0_036B60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_36B0_36B60:
    // MOV AX,word ptr [DI + 0x4] (334B_36B0 / 0x36B60)
    AX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // MOV DX,word ptr [DI] (334B_36B3 / 0x36B63)
    DX = UInt16[DS, DI];
    State.IncCycles();
    // SUB AX,DX (334B_36B5 / 0x36B65)
    AX -= DX;
    State.IncCycles();
    // SUB AX,0x14 (334B_36B7 / 0x36B67)
    AX -= 0x14;
    State.IncCycles();
    // SHR AX,1 (334B_36BA / 0x36B6A)
    AX >>= 0x1;
    State.IncCycles();
    // ADD DX,AX (334B_36BC / 0x36B6C)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // MOV word ptr CS:[0x35f6],DX (334B_36BE / 0x36B6E)
    UInt16[cs2, 0x35F6] = DX;
    State.IncCycles();
    // SHR AX,1 (334B_36C3 / 0x36B73)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_36C5 / 0x36B75)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_36C7 / 0x36B77)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV CS:[0x35ee],AX (334B_36C9 / 0x36B79)
    UInt16[cs2, 0x35EE] = AX;
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x6] (334B_36CD / 0x36B7D)
    AX = UInt16[DS, (ushort)(DI + 0x6)];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x2] (334B_36D0 / 0x36B80)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // SUB AX,BX (334B_36D3 / 0x36B83)
    AX -= BX;
    State.IncCycles();
    // SUB AX,0x14 (334B_36D5 / 0x36B85)
    AX -= 0x14;
    State.IncCycles();
    // SHR AX,1 (334B_36D8 / 0x36B88)
    AX >>= 0x1;
    State.IncCycles();
    // ADD BX,AX (334B_36DA / 0x36B8A)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // MOV word ptr CS:[0x35f8],BX (334B_36DC / 0x36B8C)
    UInt16[cs2, 0x35F8] = BX;
    State.IncCycles();
    // SHR AX,1 (334B_36E1 / 0x36B91)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_36E3 / 0x36B93)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_36E5 / 0x36B95)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV CS:[0x35f0],AX (334B_36E7 / 0x36B97)
    UInt16[cs2, 0x35F0] = AX;
    State.IncCycles();
    // SUB DX,word ptr CS:[0x35f2] (334B_36EB / 0x36B9B)
    DX -= UInt16[cs2, 0x35F2];
    State.IncCycles();
    // SUB BX,word ptr CS:[0x35f4] (334B_36F0 / 0x36BA0)
    // BX -= UInt16[cs2, 0x35F4];
    BX = Alu.Sub16(BX, UInt16[cs2, 0x35F4]);
    State.IncCycles();
    // OR DX,DX (334B_36F5 / 0x36BA5)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // PUSHF  (334B_36F7 / 0x36BA7)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JNS 0x3000:6bac (334B_36F8 / 0x36BA8)
    if(!SignFlag) {
      goto label_334B_36FC_36BAC;
    }
    State.IncCycles();
    // NEG DX (334B_36FA / 0x36BAA)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_334B_36FC_36BAC:
    // SHR DX,1 (334B_36FC / 0x36BAC)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_36FE / 0x36BAE)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_3700 / 0x36BB0)
    DX >>= 0x1;
    State.IncCycles();
    // POPF  (334B_3702 / 0x36BB2)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNS 0x3000:6bb7 (334B_3703 / 0x36BB3)
    if(!SignFlag) {
      goto label_334B_3707_36BB7;
    }
    State.IncCycles();
    // NEG DX (334B_3705 / 0x36BB5)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_334B_3707_36BB7:
    // OR BX,BX (334B_3707 / 0x36BB7)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // PUSHF  (334B_3709 / 0x36BB9)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JNS 0x3000:6bbe (334B_370A / 0x36BBA)
    if(!SignFlag) {
      goto label_334B_370E_36BBE;
    }
    State.IncCycles();
    // NEG BX (334B_370C / 0x36BBC)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_334B_370E_36BBE:
    // SHR BX,1 (334B_370E / 0x36BBE)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (334B_3710 / 0x36BC0)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (334B_3712 / 0x36BC2)
    BX >>= 0x1;
    State.IncCycles();
    // POPF  (334B_3714 / 0x36BC4)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNS 0x3000:6bc9 (334B_3715 / 0x36BC5)
    if(!SignFlag) {
      goto label_334B_3719_36BC9;
    }
    State.IncCycles();
    // NEG BX (334B_3717 / 0x36BC7)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_334B_3719_36BC9:
    // MOV word ptr CS:[0x35ea],DX (334B_3719 / 0x36BC9)
    UInt16[cs2, 0x35EA] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x35ec],BX (334B_371E / 0x36BCE)
    UInt16[cs2, 0x35EC] = BX;
    State.IncCycles();
    // RET  (334B_3723 / 0x36BD3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_372D_036BDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_372D_36BDD:
    // MOV CX,0x14 (334B_372D / 0x36BDD)
    CX = 0x14;
    State.IncCycles();
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
    State.IncCycles();
    label_334B_3733_36BE3:
    // ADD SI,DX (334B_3733 / 0x36BE3)
    SI += DX;
    State.IncCycles();
    // ADD CX,BX (334B_3735 / 0x36BE5)
    // CX += BX;
    CX = Alu.Add16(CX, BX);
    State.IncCycles();
    // MOV AX,0x4 (334B_3737 / 0x36BE7)
    AX = 0x4;
    State.IncCycles();
    // CMP DX,AX (334B_373A / 0x36BEA)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JGE 0x3000:6bf0 (334B_373C / 0x36BEC)
    if(SignFlag == OverflowFlag) {
      goto label_334B_3740_36BF0;
    }
    State.IncCycles();
    // MOV DX,AX (334B_373E / 0x36BEE)
    DX = AX;
    State.IncCycles();
    label_334B_3740_36BF0:
    // CMP SI,AX (334B_3740 / 0x36BF0)
    Alu.Sub16(SI, AX);
    State.IncCycles();
    // JGE 0x3000:6bf6 (334B_3742 / 0x36BF2)
    if(SignFlag == OverflowFlag) {
      goto label_334B_3746_36BF6;
    }
    State.IncCycles();
    // MOV SI,AX (334B_3744 / 0x36BF4)
    SI = AX;
    State.IncCycles();
    label_334B_3746_36BF6:
    // MOV AX,0x13c (334B_3746 / 0x36BF6)
    AX = 0x13C;
    State.IncCycles();
    // CMP DX,AX (334B_3749 / 0x36BF9)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JLE 0x3000:6bff (334B_374B / 0x36BFB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_374F_36BFF;
    }
    State.IncCycles();
    // MOV DX,AX (334B_374D / 0x36BFD)
    DX = AX;
    State.IncCycles();
    label_334B_374F_36BFF:
    // CMP SI,AX (334B_374F / 0x36BFF)
    Alu.Sub16(SI, AX);
    State.IncCycles();
    // JLE 0x3000:6c05 (334B_3751 / 0x36C01)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_3755_36C05;
    }
    State.IncCycles();
    // MOV SI,AX (334B_3753 / 0x36C03)
    SI = AX;
    State.IncCycles();
    label_334B_3755_36C05:
    // MOV AX,0x4 (334B_3755 / 0x36C05)
    AX = 0x4;
    State.IncCycles();
    // CMP BX,AX (334B_3758 / 0x36C08)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JGE 0x3000:6c0e (334B_375A / 0x36C0A)
    if(SignFlag == OverflowFlag) {
      goto label_334B_375E_36C0E;
    }
    State.IncCycles();
    // MOV BX,AX (334B_375C / 0x36C0C)
    BX = AX;
    State.IncCycles();
    label_334B_375E_36C0E:
    // CMP CX,AX (334B_375E / 0x36C0E)
    Alu.Sub16(CX, AX);
    State.IncCycles();
    // JGE 0x3000:6c14 (334B_3760 / 0x36C10)
    if(SignFlag == OverflowFlag) {
      goto label_334B_3764_36C14;
    }
    State.IncCycles();
    // MOV CX,AX (334B_3762 / 0x36C12)
    CX = AX;
    State.IncCycles();
    label_334B_3764_36C14:
    // MOV AX,0x94 (334B_3764 / 0x36C14)
    AX = 0x94;
    State.IncCycles();
    // CMP BX,AX (334B_3767 / 0x36C17)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JLE 0x3000:6c1d (334B_3769 / 0x36C19)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_376D_36C1D;
    }
    State.IncCycles();
    // MOV BX,AX (334B_376B / 0x36C1B)
    BX = AX;
    State.IncCycles();
    label_334B_376D_36C1D:
    // CMP CX,AX (334B_376D / 0x36C1D)
    Alu.Sub16(CX, AX);
    State.IncCycles();
    // JLE 0x3000:6c23 (334B_376F / 0x36C1F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_3773_36C23;
    }
    State.IncCycles();
    // MOV CX,AX (334B_3771 / 0x36C21)
    CX = AX;
    State.IncCycles();
    label_334B_3773_36C23:
    // SUB SI,DX (334B_3773 / 0x36C23)
    SI -= DX;
    State.IncCycles();
    // SUB CX,BX (334B_3775 / 0x36C25)
    CX -= BX;
    State.IncCycles();
    // INC SI (334B_3777 / 0x36C27)
    SI++;
    State.IncCycles();
    // SUB CX,0x2 (334B_3778 / 0x36C28)
    // CX -= 0x2;
    CX = Alu.Sub16(CX, 0x2);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_377E_36C2E:
    // PUSH CX (334B_377E / 0x36C2E)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH CX (334B_377F / 0x36C2F)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,SI (334B_3780 / 0x36C30)
    CX = SI;
    State.IncCycles();
    // MOV AL,0xf (334B_3782 / 0x36C32)
    AL = 0xF;
    State.IncCycles();
    label_334B_3784_36C34:
    // XOR byte ptr [DI],AL (334B_3784 / 0x36C34)
    UInt8[DS, DI] ^= AL;
    State.IncCycles();
    // INC DI (334B_3786 / 0x36C36)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:6c34 (334B_3787 / 0x36C37)
    if(--CX != 0) {
      goto label_334B_3784_36C34;
    }
    State.IncCycles();
    // DEC DI (334B_3789 / 0x36C39)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // POP CX (334B_378A / 0x36C3A)
    CX = Stack.Pop();
    State.IncCycles();
    // OR CX,CX (334B_378B / 0x36C3B)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JLE 0x3000:6c4b (334B_378D / 0x36C3D)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_379B_36C4B;
    }
    State.IncCycles();
    label_334B_378F_36C3F:
    // ADD DI,0x140 (334B_378F / 0x36C3F)
    DI += 0x140;
    State.IncCycles();
    // XOR byte ptr [DI],AL (334B_3793 / 0x36C43)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    State.IncCycles();
    // LOOP 0x3000:6c3f (334B_3795 / 0x36C45)
    if(--CX != 0) {
      goto label_334B_378F_36C3F;
    }
    State.IncCycles();
    // ADD DI,0x140 (334B_3797 / 0x36C47)
    // DI += 0x140;
    DI = Alu.Add16(DI, 0x140);
    State.IncCycles();
    label_334B_379B_36C4B:
    // MOV CX,SI (334B_379B / 0x36C4B)
    CX = SI;
    State.IncCycles();
    label_334B_379D_36C4D:
    // XOR byte ptr [DI],AL (334B_379D / 0x36C4D)
    UInt8[DS, DI] ^= AL;
    State.IncCycles();
    // DEC DI (334B_379F / 0x36C4F)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // LOOP 0x3000:6c4d (334B_37A0 / 0x36C50)
    if(--CX != 0) {
      goto label_334B_379D_36C4D;
    }
    State.IncCycles();
    // INC DI (334B_37A2 / 0x36C52)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // POP CX (334B_37A3 / 0x36C53)
    CX = Stack.Pop();
    State.IncCycles();
    // OR CX,CX (334B_37A4 / 0x36C54)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JLE 0x3000:6c60 (334B_37A6 / 0x36C56)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (334B_37B0 / 0x36C60)
      return NearRet();
    }
    State.IncCycles();
    label_334B_37A8_36C58:
    // SUB DI,0x140 (334B_37A8 / 0x36C58)
    DI -= 0x140;
    State.IncCycles();
    // XOR byte ptr [DI],AL (334B_37AC / 0x36C5C)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    State.IncCycles();
    // LOOP 0x3000:6c58 (334B_37AE / 0x36C5E)
    if(--CX != 0) {
      goto label_334B_37A8_36C58;
    }
    State.IncCycles();
    label_334B_37B0_36C60:
    // RET  (334B_37B0 / 0x36C60)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_37B1_036C61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_37B1_36C61:
    // PUSH BP (334B_37B1 / 0x36C61)
    Stack.Push(BP);
    State.IncCycles();
    // MOV BP,CX (334B_37B2 / 0x36C62)
    BP = CX;
    State.IncCycles();
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
    State.IncCycles();
    label_334B_37B7_36C67:
    // MOV AX,0xf0f (334B_37B7 / 0x36C67)
    AX = 0xF0F;
    State.IncCycles();
    // MOV CX,0x5 (334B_37BA / 0x36C6A)
    CX = 0x5;
    State.IncCycles();
    label_334B_37BD_36C6D:
    // XOR word ptr [DI],AX (334B_37BD / 0x36C6D)
    UInt16[DS, DI] ^= AX;
    State.IncCycles();
    // ADD DI,0x2 (334B_37BF / 0x36C6F)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x3000:6c6d (334B_37C2 / 0x36C72)
    if(--CX != 0) {
      goto label_334B_37BD_36C6D;
    }
    State.IncCycles();
    // ADD DI,BP (334B_37C4 / 0x36C74)
    DI += BP;
    State.IncCycles();
    // SUB DI,0x14 (334B_37C6 / 0x36C76)
    // DI -= 0x14;
    DI = Alu.Sub16(DI, 0x14);
    State.IncCycles();
    // MOV CX,0x5 (334B_37C9 / 0x36C79)
    CX = 0x5;
    State.IncCycles();
    label_334B_37CC_36C7C:
    // XOR word ptr [DI],AX (334B_37CC / 0x36C7C)
    UInt16[DS, DI] ^= AX;
    State.IncCycles();
    // ADD DI,0x2 (334B_37CE / 0x36C7E)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x3000:6c7c (334B_37D1 / 0x36C81)
    if(--CX != 0) {
      goto label_334B_37CC_36C7C;
    }
    State.IncCycles();
    // DEC DI (334B_37D3 / 0x36C83)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // MOV CX,0x9 (334B_37D4 / 0x36C84)
    CX = 0x9;
    State.IncCycles();
    label_334B_37D7_36C87:
    // ADD DI,0x140 (334B_37D7 / 0x36C87)
    DI += 0x140;
    State.IncCycles();
    // XOR byte ptr [DI],AL (334B_37DB / 0x36C8B)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    State.IncCycles();
    // LOOP 0x3000:6c87 (334B_37DD / 0x36C8D)
    if(--CX != 0) {
      goto label_334B_37D7_36C87;
    }
    State.IncCycles();
    // MOV AX,SI (334B_37DF / 0x36C8F)
    AX = SI;
    State.IncCycles();
    // SUB AX,0x14 (334B_37E1 / 0x36C91)
    // AX -= 0x14;
    AX = Alu.Sub16(AX, 0x14);
    State.IncCycles();
    // MOV CX,0x140 (334B_37E4 / 0x36C94)
    CX = 0x140;
    State.IncCycles();
    // IMUL CX (334B_37E7 / 0x36C97)
    Cpu.IMul16(CX);
    State.IncCycles();
    // ADD DI,AX (334B_37E9 / 0x36C99)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV AX,0xf0f (334B_37EB / 0x36C9B)
    AX = 0xF0F;
    State.IncCycles();
    // MOV CX,0x9 (334B_37EE / 0x36C9E)
    CX = 0x9;
    State.IncCycles();
    label_334B_37F1_36CA1:
    // ADD DI,0x140 (334B_37F1 / 0x36CA1)
    DI += 0x140;
    State.IncCycles();
    // XOR byte ptr [DI],AL (334B_37F5 / 0x36CA5)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    State.IncCycles();
    // LOOP 0x3000:6ca1 (334B_37F7 / 0x36CA7)
    if(--CX != 0) {
      goto label_334B_37F1_36CA1;
    }
    State.IncCycles();
    // ADD DI,0x140 (334B_37F9 / 0x36CA9)
    DI += 0x140;
    State.IncCycles();
    // DEC DI (334B_37FD / 0x36CAD)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // MOV CX,0x5 (334B_37FE / 0x36CAE)
    CX = 0x5;
    State.IncCycles();
    label_334B_3801_36CB1:
    // XOR word ptr [DI],AX (334B_3801 / 0x36CB1)
    UInt16[DS, DI] ^= AX;
    State.IncCycles();
    // SUB DI,0x2 (334B_3803 / 0x36CB3)
    // DI -= 0x2;
    DI = Alu.Sub16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x3000:6cb1 (334B_3806 / 0x36CB6)
    if(--CX != 0) {
      goto label_334B_3801_36CB1;
    }
    State.IncCycles();
    // SUB DI,BP (334B_3808 / 0x36CB8)
    DI -= BP;
    State.IncCycles();
    // ADD DI,0x14 (334B_380A / 0x36CBA)
    // DI += 0x14;
    DI = Alu.Add16(DI, 0x14);
    State.IncCycles();
    // MOV CX,0x5 (334B_380D / 0x36CBD)
    CX = 0x5;
    State.IncCycles();
    label_334B_3810_36CC0:
    // XOR word ptr [DI],AX (334B_3810 / 0x36CC0)
    UInt16[DS, DI] ^= AX;
    State.IncCycles();
    // SUB DI,0x2 (334B_3812 / 0x36CC2)
    // DI -= 0x2;
    DI = Alu.Sub16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x3000:6cc0 (334B_3815 / 0x36CC5)
    if(--CX != 0) {
      goto label_334B_3810_36CC0;
    }
    State.IncCycles();
    // ADD DI,0x2 (334B_3817 / 0x36CC7)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // MOV CX,0x9 (334B_381A / 0x36CCA)
    CX = 0x9;
    State.IncCycles();
    label_334B_381D_36CCD:
    // SUB DI,0x140 (334B_381D / 0x36CCD)
    DI -= 0x140;
    State.IncCycles();
    // XOR byte ptr [DI],AL (334B_3821 / 0x36CD1)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    State.IncCycles();
    // LOOP 0x3000:6ccd (334B_3823 / 0x36CD3)
    if(--CX != 0) {
      goto label_334B_381D_36CCD;
    }
    State.IncCycles();
    // MOV AX,SI (334B_3825 / 0x36CD5)
    AX = SI;
    State.IncCycles();
    // SUB AX,0x14 (334B_3827 / 0x36CD7)
    // AX -= 0x14;
    AX = Alu.Sub16(AX, 0x14);
    State.IncCycles();
    // MOV CX,0x140 (334B_382A / 0x36CDA)
    CX = 0x140;
    State.IncCycles();
    // IMUL CX (334B_382D / 0x36CDD)
    Cpu.IMul16(CX);
    State.IncCycles();
    // SUB DI,AX (334B_382F / 0x36CDF)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    // MOV AX,0xf0f (334B_3831 / 0x36CE1)
    AX = 0xF0F;
    State.IncCycles();
    // MOV CX,0x9 (334B_3834 / 0x36CE4)
    CX = 0x9;
    State.IncCycles();
    label_334B_3837_36CE7:
    // SUB DI,0x140 (334B_3837 / 0x36CE7)
    DI -= 0x140;
    State.IncCycles();
    // XOR byte ptr [DI],AL (334B_383B / 0x36CEB)
    // UInt8[DS, DI] ^= AL;
    UInt8[DS, DI] = Alu.Xor8(UInt8[DS, DI], AL);
    State.IncCycles();
    // LOOP 0x3000:6ce7 (334B_383D / 0x36CED)
    if(--CX != 0) {
      goto label_334B_3837_36CE7;
    }
    State.IncCycles();
    // POP BP (334B_383F / 0x36CEF)
    BP = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_334B_3841_36CF1:
    // PUSH DS (334B_3841 / 0x36CF1)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_3842 / 0x36CF2)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_3843 / 0x36CF3)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV AX,0x2 (334B_3844 / 0x36CF4)
    AX = 0x2;
    State.IncCycles();
    label_334B_3847_36CF7:
    // PUSH AX (334B_3847 / 0x36CF7)
    Stack.Push(AX);
    State.IncCycles();
    // MOV DX,word ptr CS:[0x35fa] (334B_3848 / 0x36CF8)
    DX = UInt16[cs2, 0x35FA];
    State.IncCycles();
    // MOV BX,word ptr CS:[0x35fc] (334B_384D / 0x36CFD)
    BX = UInt16[cs2, 0x35FC];
    State.IncCycles();
    // MOV CX,word ptr CS:[0x35fe] (334B_3852 / 0x36D02)
    CX = UInt16[cs2, 0x35FE];
    State.IncCycles();
    // MOV SI,word ptr CS:[0x3600] (334B_3857 / 0x36D07)
    SI = UInt16[cs2, 0x3600];
    State.IncCycles();
    // MOV AX,0x8 (334B_385C / 0x36D0C)
    AX = 0x8;
    State.IncCycles();
    label_334B_385F_36D0F:
    // PUSH AX (334B_385F / 0x36D0F)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (334B_3860 / 0x36D10)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_3861 / 0x36D11)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_3862 / 0x36D12)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_3863 / 0x36D13)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_3864 / 0x36D14)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_386A_36D1A:
    // POP BX (334B_386A / 0x36D1A)
    BX = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_334B_386E_36D1E:
    // POP SI (334B_386E / 0x36D1E)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_386F / 0x36D1F)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_3870 / 0x36D20)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_3871 / 0x36D21)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV AX,CS:[0x35ee] (334B_3872 / 0x36D22)
    AX = UInt16[cs2, 0x35EE];
    State.IncCycles();
    // ADD DX,AX (334B_3876 / 0x36D26)
    DX += AX;
    State.IncCycles();
    // SUB CX,AX (334B_3878 / 0x36D28)
    CX -= AX;
    State.IncCycles();
    // SUB CX,AX (334B_387A / 0x36D2A)
    // CX -= AX;
    CX = Alu.Sub16(CX, AX);
    State.IncCycles();
    // MOV AX,CS:[0x35f0] (334B_387C / 0x36D2C)
    AX = UInt16[cs2, 0x35F0];
    State.IncCycles();
    // ADD BX,AX (334B_3880 / 0x36D30)
    BX += AX;
    State.IncCycles();
    // SUB SI,AX (334B_3882 / 0x36D32)
    SI -= AX;
    State.IncCycles();
    // SUB SI,AX (334B_3884 / 0x36D34)
    // SI -= AX;
    SI = Alu.Sub16(SI, AX);
    State.IncCycles();
    // POP AX (334B_3886 / 0x36D36)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AX (334B_3887 / 0x36D37)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:6d0f (334B_3888 / 0x36D38)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3841_036CF1, 0x36D0F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP AX (334B_388A / 0x36D3A)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AX (334B_388B / 0x36D3B)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:6cf7 (334B_388C / 0x36D3C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3841_036CF1, 0x36CF7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x2 (334B_388E / 0x36D3E)
    CX = 0x2;
    State.IncCycles();
    label_334B_3891_36D41:
    // PUSH CX (334B_3891 / 0x36D41)
    Stack.Push(CX);
    State.IncCycles();
    // MOV DX,word ptr CS:[0x35f6] (334B_3892 / 0x36D42)
    DX = UInt16[cs2, 0x35F6];
    State.IncCycles();
    // MOV BX,word ptr CS:[0x35f8] (334B_3897 / 0x36D47)
    BX = UInt16[cs2, 0x35F8];
    State.IncCycles();
    // MOV CX,0x8 (334B_389C / 0x36D4C)
    CX = 0x8;
    State.IncCycles();
    label_334B_389F_36D4F:
    // SUB DX,word ptr CS:[0x35ea] (334B_389F / 0x36D4F)
    DX -= UInt16[cs2, 0x35EA];
    State.IncCycles();
    // SUB BX,word ptr CS:[0x35ec] (334B_38A4 / 0x36D54)
    // BX -= UInt16[cs2, 0x35EC];
    BX = Alu.Sub16(BX, UInt16[cs2, 0x35EC]);
    State.IncCycles();
    // PUSH BX (334B_38A9 / 0x36D59)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_38AA / 0x36D5A)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_38AB / 0x36D5B)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_38AC / 0x36D5C)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_38B2_36D62:
    // POP BX (334B_38B2 / 0x36D62)
    BX = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_334B_38B6_36D66:
    // POP DX (334B_38B6 / 0x36D66)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_38B7 / 0x36D67)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_38B8 / 0x36D68)
    BX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x3000:6d4f (334B_38B9 / 0x36D69)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_386E_036D1E, 0x36D4F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP CX (334B_38BB / 0x36D6B)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x3000:6d41 (334B_38BC / 0x36D6C)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_386E_036D1E, 0x36D41 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP DS (334B_38BE / 0x36D6E)
    DS = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_334B_38D8_36D88:
    // LODSW SI (334B_38D8 / 0x36D88)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD AX,0x8 (334B_38D9 / 0x36D89)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    State.IncCycles();
    // MOV CS:[0x38c8],AX (334B_38DC / 0x36D8C)
    UInt16[cs2, 0x38C8] = AX;
    State.IncCycles();
    // LODSW SI (334B_38E0 / 0x36D90)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD AX,0x8 (334B_38E1 / 0x36D91)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    State.IncCycles();
    // MOV CS:[0x38ca],AX (334B_38E4 / 0x36D94)
    UInt16[cs2, 0x38CA] = AX;
    State.IncCycles();
    // MOV SI,DI (334B_38E8 / 0x36D98)
    SI = DI;
    State.IncCycles();
    // LODSW SI (334B_38EA / 0x36D9A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (334B_38EB / 0x36D9B)
    DX = AX;
    State.IncCycles();
    // LODSW SI (334B_38ED / 0x36D9D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (334B_38EE / 0x36D9E)
    BX = AX;
    State.IncCycles();
    // LODSW SI (334B_38F0 / 0x36DA0)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (334B_38F1 / 0x36DA1)
    CX = AX;
    State.IncCycles();
    // LODSW SI (334B_38F3 / 0x36DA3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV SI,AX (334B_38F4 / 0x36DA4)
    SI = AX;
    State.IncCycles();
    // XCHG SI,CX (334B_38F6 / 0x36DA6)
    ushort tmp_334B_38F6 = SI;
    SI = CX;
    CX = tmp_334B_38F6;
    State.IncCycles();
    // MOV word ptr CS:[0x38cc],DX (334B_38F8 / 0x36DA8)
    UInt16[cs2, 0x38CC] = DX;
    State.IncCycles();
    // MOV word ptr CS:[0x38ce],BX (334B_38FD / 0x36DAD)
    UInt16[cs2, 0x38CE] = BX;
    State.IncCycles();
    // MOV word ptr CS:[0x38d0],SI (334B_3902 / 0x36DB2)
    UInt16[cs2, 0x38D0] = SI;
    State.IncCycles();
    // MOV word ptr CS:[0x38d2],CX (334B_3907 / 0x36DB7)
    UInt16[cs2, 0x38D2] = CX;
    State.IncCycles();
    // SUB SI,DX (334B_390C / 0x36DBC)
    SI -= DX;
    State.IncCycles();
    // SHR SI,1 (334B_390E / 0x36DBE)
    SI >>= 0x1;
    State.IncCycles();
    // SHR SI,1 (334B_3910 / 0x36DC0)
    SI >>= 0x1;
    State.IncCycles();
    // SHR SI,1 (334B_3912 / 0x36DC2)
    SI >>= 0x1;
    State.IncCycles();
    // SHR SI,1 (334B_3914 / 0x36DC4)
    SI >>= 0x1;
    State.IncCycles();
    // SUB CX,BX (334B_3916 / 0x36DC6)
    CX -= BX;
    State.IncCycles();
    // SHR CX,1 (334B_3918 / 0x36DC8)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (334B_391A / 0x36DCA)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (334B_391C / 0x36DCC)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (334B_391E / 0x36DCE)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // MOV word ptr CS:[0x38c4],SI (334B_3920 / 0x36DD0)
    UInt16[cs2, 0x38C4] = SI;
    State.IncCycles();
    // MOV word ptr CS:[0x38c6],CX (334B_3925 / 0x36DD5)
    UInt16[cs2, 0x38C6] = CX;
    State.IncCycles();
    // SUB DX,word ptr CS:[0x38c8] (334B_392A / 0x36DDA)
    // DX -= UInt16[cs2, 0x38C8];
    DX = Alu.Sub16(DX, UInt16[cs2, 0x38C8]);
    State.IncCycles();
    // PUSHF  (334B_392F / 0x36DDF)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JNS 0x3000:6de4 (334B_3930 / 0x36DE0)
    if(!SignFlag) {
      goto label_334B_3934_36DE4;
    }
    State.IncCycles();
    // NEG DX (334B_3932 / 0x36DE2)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_334B_3934_36DE4:
    // SHR DX,1 (334B_3934 / 0x36DE4)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_3936 / 0x36DE6)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_3938 / 0x36DE8)
    DX >>= 0x1;
    State.IncCycles();
    // SHR DX,1 (334B_393A / 0x36DEA)
    DX >>= 0x1;
    State.IncCycles();
    // POPF  (334B_393C / 0x36DEC)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNS 0x3000:6df1 (334B_393D / 0x36DED)
    if(!SignFlag) {
      goto label_334B_3941_36DF1;
    }
    State.IncCycles();
    // NEG DX (334B_393F / 0x36DEF)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_334B_3941_36DF1:
    // MOV word ptr CS:[0x38c0],DX (334B_3941 / 0x36DF1)
    UInt16[cs2, 0x38C0] = DX;
    State.IncCycles();
    // SUB BX,word ptr CS:[0x38ca] (334B_3946 / 0x36DF6)
    // BX -= UInt16[cs2, 0x38CA];
    BX = Alu.Sub16(BX, UInt16[cs2, 0x38CA]);
    State.IncCycles();
    // PUSHF  (334B_394B / 0x36DFB)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JNS 0x3000:6e00 (334B_394C / 0x36DFC)
    if(!SignFlag) {
      goto label_334B_3950_36E00;
    }
    State.IncCycles();
    // NEG BX (334B_394E / 0x36DFE)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_334B_3950_36E00:
    // SHR BX,1 (334B_3950 / 0x36E00)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (334B_3952 / 0x36E02)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (334B_3954 / 0x36E04)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (334B_3956 / 0x36E06)
    BX >>= 0x1;
    State.IncCycles();
    // POPF  (334B_3958 / 0x36E08)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNS 0x3000:6e0d (334B_3959 / 0x36E09)
    if(!SignFlag) {
      goto label_334B_395D_36E0D;
    }
    State.IncCycles();
    // NEG BX (334B_395B / 0x36E0B)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_334B_395D_36E0D:
    // MOV word ptr CS:[0x38c2],BX (334B_395D / 0x36E0D)
    UInt16[cs2, 0x38C2] = BX;
    State.IncCycles();
    // MOV DX,word ptr CS:[0x38c8] (334B_3962 / 0x36E12)
    DX = UInt16[cs2, 0x38C8];
    State.IncCycles();
    // MOV BX,word ptr CS:[0x38ca] (334B_3967 / 0x36E17)
    BX = UInt16[cs2, 0x38CA];
    State.IncCycles();
    // XOR CX,CX (334B_396C / 0x36E1C)
    CX = 0;
    State.IncCycles();
    // XOR SI,SI (334B_396E / 0x36E1E)
    SI = 0;
    State.IncCycles();
    label_334B_3970_36E20:
    // PUSH DS (334B_3970 / 0x36E20)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_3971 / 0x36E21)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_3972 / 0x36E22)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x0] (334B_3973 / 0x36E23)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // MOV CS:[0x38d4],AX (334B_3976 / 0x36E26)
    UInt16[cs2, 0x38D4] = AX;
    State.IncCycles();
    // MOV AX,0xf (334B_397A / 0x36E2A)
    AX = 0xF;
    State.IncCycles();
    label_334B_397D_36E2D:
    // PUSH AX (334B_397D / 0x36E2D)
    Stack.Push(AX);
    State.IncCycles();
    // ADD DX,word ptr CS:[0x38c0] (334B_397E / 0x36E2E)
    DX += UInt16[cs2, 0x38C0];
    State.IncCycles();
    // ADD BX,word ptr CS:[0x38c2] (334B_3983 / 0x36E33)
    BX += UInt16[cs2, 0x38C2];
    State.IncCycles();
    // ADD SI,word ptr CS:[0x38c4] (334B_3988 / 0x36E38)
    SI += UInt16[cs2, 0x38C4];
    State.IncCycles();
    // ADD CX,word ptr CS:[0x38c6] (334B_398D / 0x36E3D)
    // CX += UInt16[cs2, 0x38C6];
    CX = Alu.Add16(CX, UInt16[cs2, 0x38C6]);
    State.IncCycles();
    // PUSH BX (334B_3992 / 0x36E42)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_3993 / 0x36E43)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_3994 / 0x36E44)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_3995 / 0x36E45)
    Stack.Push(SI);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_3999_36E49:
    // MOV BX,word ptr CS:[0x38d4] (334B_3999 / 0x36E49)
    BX = UInt16[cs2, 0x38D4];
    State.IncCycles();
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
    State.IncCycles();
    label_334B_39A1_36E51:
    // MOV word ptr CS:[0x38d4],BX (334B_39A1 / 0x36E51)
    UInt16[cs2, 0x38D4] = BX;
    State.IncCycles();
    // POP SI (334B_39A6 / 0x36E56)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_39A7 / 0x36E57)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_39A8 / 0x36E58)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_39A9 / 0x36E59)
    BX = Stack.Pop();
    State.IncCycles();
    // PUSH BX (334B_39AA / 0x36E5A)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_39AB / 0x36E5B)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_39AC / 0x36E5C)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_39AD / 0x36E5D)
    Stack.Push(SI);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_39B1_36E61:
    // POP SI (334B_39B1 / 0x36E61)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_39B2 / 0x36E62)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_39B3 / 0x36E63)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_39B4 / 0x36E64)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_39B5 / 0x36E65)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AX (334B_39B6 / 0x36E66)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:6e2d (334B_39B7 / 0x36E67)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_38D8_036D88, 0x36E2D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP DS (334B_39B9 / 0x36E69)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_39BA / 0x36E6A)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_39BB_036E6B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_39BB_36E6B:
    // MOV DX,word ptr CS:[0x38cc] (334B_39BB / 0x36E6B)
    DX = UInt16[cs2, 0x38CC];
    State.IncCycles();
    // MOV BX,word ptr CS:[0x38ce] (334B_39C0 / 0x36E70)
    BX = UInt16[cs2, 0x38CE];
    State.IncCycles();
    // MOV SI,word ptr CS:[0x38d0] (334B_39C5 / 0x36E75)
    SI = UInt16[cs2, 0x38D0];
    State.IncCycles();
    // MOV CX,word ptr CS:[0x38d2] (334B_39CA / 0x36E7A)
    CX = UInt16[cs2, 0x38D2];
    State.IncCycles();
    // SUB SI,DX (334B_39CF / 0x36E7F)
    SI -= DX;
    State.IncCycles();
    // SUB CX,BX (334B_39D1 / 0x36E81)
    CX -= BX;
    State.IncCycles();
    // NEG word ptr CS:[0x38c0] (334B_39D3 / 0x36E83)
    UInt16[cs2, 0x38C0] = Alu.Sub16(0, UInt16[cs2, 0x38C0]);
    State.IncCycles();
    // NEG word ptr CS:[0x38c2] (334B_39D8 / 0x36E88)
    UInt16[cs2, 0x38C2] = Alu.Sub16(0, UInt16[cs2, 0x38C2]);
    State.IncCycles();
    // NEG word ptr CS:[0x38c4] (334B_39DD / 0x36E8D)
    UInt16[cs2, 0x38C4] = Alu.Sub16(0, UInt16[cs2, 0x38C4]);
    State.IncCycles();
    // NEG word ptr CS:[0x38c6] (334B_39E2 / 0x36E92)
    UInt16[cs2, 0x38C6] = Alu.Sub16(0, UInt16[cs2, 0x38C6]);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_39E9_36E99:
    // PUSH AX (334B_39E9 / 0x36E99)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DI (334B_39EA / 0x36E9A)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_39EB / 0x36E9B)
    NearCall(cs2, 0x39EE, spice86_generated_label_call_target_334B_0C10_0340C0);
    State.IncCycles();
    // POP BX (334B_39EE / 0x36E9E)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV DX,AX (334B_39EF / 0x36E9F)
    DX = AX;
    State.IncCycles();
    label_334B_39F1_36EA1:
    // SHR BP,1 (334B_39F1 / 0x36EA1)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    State.IncCycles();
    // JNC 0x3000:6ea7 (334B_39F3 / 0x36EA3)
    if(!CarryFlag) {
      goto label_334B_39F7_36EA7;
    }
    State.IncCycles();
    // XOR BP,SI (334B_39F5 / 0x36EA5)
    // BP ^= SI;
    BP = Alu.Xor16(BP, SI);
    State.IncCycles();
    label_334B_39F7_36EA7:
    // MOV AX,BP (334B_39F7 / 0x36EA7)
    AX = BP;
    State.IncCycles();
    // AND AX,0x3 (334B_39F9 / 0x36EA9)
    AX &= 0x3;
    State.IncCycles();
    // DEC AX (334B_39FC / 0x36EAC)
    AX--;
    State.IncCycles();
    // ADD AL,DH (334B_39FD / 0x36EAD)
    // AL += DH;
    AL = Alu.Add8(AL, DH);
    State.IncCycles();
    // STOSB ES:DI (334B_39FF / 0x36EAF)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DX,BX (334B_3A00 / 0x36EB0)
    // DX += BX;
    DX = Alu.Add16(DX, BX);
    State.IncCycles();
    // LOOP 0x3000:6ea1 (334B_3A02 / 0x36EB2)
    if(--CX != 0) {
      goto label_334B_39F1_36EA1;
    }
    State.IncCycles();
    // POP AX (334B_3A04 / 0x36EB4)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (334B_3A05 / 0x36EB5)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3A14_036EC4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_334B_3A17_36EC7:
    // MOV SI,DI (334B_3A17 / 0x36EC7)
    SI = DI;
    State.IncCycles();
    // MOV DI,word ptr CS:[0x1a3] (334B_3A19 / 0x36EC9)
    DI = UInt16[cs2, 0x1A3];
    State.IncCycles();
    // SHL BP,1 (334B_3A1E / 0x36ECE)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
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
    State.IncCycles();
    label_334B_3B46_36FF6:
    // MOV BX,0x26 (334B_3B46 / 0x36FF6)
    BX = 0x26;
    State.IncCycles();
    label_334B_3B49_36FF9:
    // MOV CX,0x50 (334B_3B49 / 0x36FF9)
    CX = 0x50;
    State.IncCycles();
    label_334B_3B4C_36FFC:
    // LODSB SI (334B_3B4C / 0x36FFC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV AH,AL (334B_3B4D / 0x36FFD)
    AH = AL;
    State.IncCycles();
    // MOV BP,0x4 (334B_3B4F / 0x36FFF)
    BP = 0x4;
    State.IncCycles();
    label_334B_3B52_37002:
    // STOSW ES:DI (334B_3B52 / 0x37002)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (334B_3B53 / 0x37003)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0x13c (334B_3B54 / 0x37004)
    DI += 0x13C;
    State.IncCycles();
    // DEC BP (334B_3B58 / 0x37008)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x3000:7002 (334B_3B59 / 0x37009)
    if(!ZeroFlag) {
      goto label_334B_3B52_37002;
    }
    State.IncCycles();
    // SUB DI,0x4fc (334B_3B5B / 0x3700B)
    // DI -= 0x4FC;
    DI = Alu.Sub16(DI, 0x4FC);
    State.IncCycles();
    // LOOP 0x3000:6ffc (334B_3B5F / 0x3700F)
    if(--CX != 0) {
      goto label_334B_3B4C_36FFC;
    }
    State.IncCycles();
    // ADD SI,0xf0 (334B_3B61 / 0x37011)
    SI += 0xF0;
    State.IncCycles();
    // ADD DI,0x3c0 (334B_3B65 / 0x37015)
    DI += 0x3C0;
    State.IncCycles();
    // DEC BX (334B_3B69 / 0x37019)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:6ff9 (334B_3B6A / 0x3701A)
    if(!ZeroFlag) {
      goto label_334B_3B49_36FF9;
    }
    State.IncCycles();
    // RETF  (334B_3B6C / 0x3701C)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_5635_0100_056450(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_5635_017B_564CB:
    // PUSH CS (5635_017B / 0x564CB)
    Stack.Push(cs3);
    State.IncCycles();
    // CALL 0x5000:64d2 (5635_017C / 0x564CC)
    NearCall(cs3, 0x17F, PcSpeakerActivationWithALCleanup_5635_0182_564D2);
    State.IncCycles();
    // XOR BX,BX (5635_017F / 0x564CF)
    BX = 0;
    State.IncCycles();
    // RETF  (5635_0181 / 0x564D1)
    return FarRet();
  }
  
  public virtual Action PcSpeakerActivationWithALCleanup_5635_0182_564D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_5635_0185_564D5:
    // XOR AL,AL (5635_0185 / 0x564D5)
    AL = 0;
    State.IncCycles();
    // RETF  (5635_0187 / 0x564D7)
    return FarRet();
  }
  
  public virtual Action PcSpeakerActivation_5635_0188_564D8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_5635_0188_564D8:
    // IN AL,0x61 (5635_0188 / 0x564D8)
    AL = Cpu.In8(0x61);
    State.IncCycles();
    // AND AL,0xfc (5635_018A / 0x564DA)
    // AL &= 0xFC;
    AL = Alu.And8(AL, 0xFC);
    State.IncCycles();
    // OUT 0x61,AL (5635_018C / 0x564DC)
    Cpu.Out8(0x61, AL);
    State.IncCycles();
    // RET  (5635_018E / 0x564DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0100_0564E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_563E_010C_564EC:
    // JMP 0x5000:65ce (563E_010C / 0x564EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_01EE_0565CE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_010F_0564EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_010F_564EF:
    // JMP 0x5000:66ef (563E_010F / 0x564EF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_030F_0566EF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0112_0564F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0112_564F2:
    // JMP 0x5000:660b (563E_0112 / 0x564F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_563E_022B_05660B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action PcSpeakerActivationWithALCleanup_563E_0182_56562(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0182_56562:
    // XOR AX,0x1310 (563E_0182 / 0x56562)
    AX ^= 0x1310;
    State.IncCycles();
    // ADD byte ptr [SI + -0x2c],CL (563E_0185 / 0x56565)
    UInt8[DS, (ushort)(SI - 0x2C)] += CL;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(PcSpeakerActivation_563E_0188_56568, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action PcSpeakerActivation_563E_0188_56568(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0188_56568:
    // AND AL,0x0 (563E_0188 / 0x56568)
    AL &= 0x0;
    State.IncCycles();
    // XOR AX,0x3d00 (563E_018A / 0x5656A)
    AX ^= 0x3D00;
    State.IncCycles();
    // ADD byte ptr [BX + SI + 0x0],DH (563E_018D / 0x5656D)
    UInt8[DS, (ushort)(BX + SI)] += DH;
    State.IncCycles();
    // IMUL AX,word ptr [BX + SI],0x7d (563E_0190 / 0x56570)
    Cpu.IMul16(AX);
    State.IncCycles();
    // ADD byte ptr [BP + SI],DL (563E_0193 / 0x56573)
    UInt8[SS, (ushort)(BP + SI)] += DL;
    State.IncCycles();
    // ADD word ptr [BX + SI + 0x2b01],SI (563E_0195 / 0x56575)
    UInt16[DS, (ushort)(BX + SI + 0x2B01)] += SI;
    State.IncCycles();
    // ADD word ptr [BP + DI + 0x60aa],SI (563E_0199 / 0x56579)
    // UInt16[SS, (ushort)(BP + DI + 0x60AA)] += SI;
    UInt16[SS, (ushort)(BP + DI + 0x60AA)] = Alu.Add16(UInt16[SS, (ushort)(BP + DI + 0x60AA)], SI);
    State.IncCycles();
    // PUSHA  (563E_019D / 0x5657D)
    ushort sp563E_019D = SP;
    Stack.Push(AX);
    Stack.Push(CX);
    Stack.Push(DX);
    Stack.Push(BX);
    Stack.Push(sp563E_019D);
    Stack.Push(BP);
    Stack.Push(SI);
    Stack.Push(DI);
    State.IncCycles();
    // PUSHA  (563E_019E / 0x5657E)
    ushort sp563E_019E = SP;
    Stack.Push(AX);
    Stack.Push(CX);
    Stack.Push(DX);
    Stack.Push(BX);
    Stack.Push(sp563E_019E);
    Stack.Push(BP);
    Stack.Push(SI);
    Stack.Push(DI);
    State.IncCycles();
    // PUSHA  (563E_019F / 0x5657F)
    ushort sp563E_019F = SP;
    Stack.Push(AX);
    Stack.Push(CX);
    Stack.Push(DX);
    Stack.Push(BX);
    Stack.Push(sp563E_019F);
    Stack.Push(BP);
    Stack.Push(SI);
    Stack.Push(DI);
    State.IncCycles();
    // ADD AL,0x60 (563E_01A0 / 0x56580)
    // AL += 0x60;
    AL = Alu.Add8(AL, 0x60);
    State.IncCycles();
    // PUSHA  (563E_01A2 / 0x56582)
    ushort sp563E_01A2 = SP;
    Stack.Push(AX);
    Stack.Push(CX);
    Stack.Push(DX);
    Stack.Push(BX);
    Stack.Push(sp563E_01A2);
    Stack.Push(BP);
    Stack.Push(SI);
    Stack.Push(DI);
    State.IncCycles();
    // Instruction bytes at index 0 modified by those instruction(s): 56823
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified. Possible opcodes: 60, 7. Opcode offset:0");
    // POP ES (563E_01A3 / 0x56583)
    ES = Stack.Pop();
    State.IncCycles();
    // PUSHA  (563E_01A4 / 0x56584)
    ushort sp563E_01A4 = SP;
    Stack.Push(AX);
    Stack.Push(CX);
    Stack.Push(DX);
    Stack.Push(BX);
    Stack.Push(sp563E_01A4);
    Stack.Push(BP);
    Stack.Push(SI);
    Stack.Push(DI);
    State.IncCycles();
    // DEC BP (563E_01A5 / 0x56585)
    BP--;
    State.IncCycles();
    // XOR SI,word ptr [BP + SI] (563E_01A6 / 0x56586)
    // SI ^= UInt16[SS, (ushort)(BP + SI)];
    SI = Alu.Xor16(SI, UInt16[SS, (ushort)(BP + SI)]);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_563E_01A8_056588, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_563E_01A8_056588(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_01A8_56588:
    // PUSH SS (563E_01A8 / 0x56588)
    Stack.Push(SS);
    State.IncCycles();
    // POP ES (563E_01A9 / 0x56589)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV SI,BP (563E_01AA / 0x5658A)
    SI = BP;
    State.IncCycles();
    label_563E_01AC_5658C:
    // LODSW ES:SI (563E_01AC / 0x5658C)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD AX,0x2 (563E_01AE / 0x5658E)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    // MOV DI,AX (563E_01B1 / 0x56591)
    DI = AX;
    State.IncCycles();
    // PUSH CX (563E_01B3 / 0x56593)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,0x9 (563E_01B4 / 0x56594)
    CX = 0x9;
    State.IncCycles();
    // MOV AL,0x2e (563E_01B7 / 0x56597)
    AL = 0x2E;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (563E_01B9 / 0x56599)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // POP CX (563E_01BB / 0x5659B)
    CX = Stack.Pop();
    State.IncCycles();
    // JNZ 0x5000:65a8 (563E_01BC / 0x5659C)
    if(!ZeroFlag) {
      goto label_563E_01C8_565A8;
    }
    State.IncCycles();
    // MOV AX,CS:[0x1a5] (563E_01BE / 0x5659E)
    AX = UInt16[cs4, 0x1A5];
    State.IncCycles();
    // STOSW ES:DI (563E_01C2 / 0x565A2)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,CS:[0x1a7] (563E_01C3 / 0x565A3)
    AL = UInt8[cs4, 0x1A7];
    State.IncCycles();
    // STOSB ES:DI (563E_01C7 / 0x565A7)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_563E_01C8_565A8:
    // LOOP 0x5000:658c (563E_01C8 / 0x565A8)
    if(--CX != 0) {
      goto label_563E_01AC_5658C;
    }
    State.IncCycles();
    // RET  (563E_01CA / 0x565AA)
    return NearRet();
  }
  
  public virtual Action not_observed_563E_01CB_0565AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_01CB_565AB:
    // OR AX,AX (563E_01CB / 0x565AB)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x5000:65b3 (563E_01CD / 0x565AD)
    if(ZeroFlag) {
      goto label_563E_01D3_565B3;
    }
    State.IncCycles();
    // MOV CS:[0x125],AX (563E_01CF / 0x565AF)
    UInt16[cs4, 0x125] = AX;
    State.IncCycles();
    label_563E_01D3_565B3:
    // CALL 0x5000:6588 (563E_01D3 / 0x565B3)
    NearCall(cs4, 0x1D6, not_observed_563E_01A8_056588);
    State.IncCycles();
    // CALL 0x5000:6939 (563E_01D6 / 0x565B6)
    NearCall(cs4, 0x1D9, not_observed_563E_0559_056939);
    State.IncCycles();
    // PUSH CS (563E_01D9 / 0x565B9)
    Stack.Push(cs4);
    State.IncCycles();
    // CALL 0x5000:65c1 (563E_01DA / 0x565BA)
    NearCall(cs4, 0x1DD, not_observed_563E_01E1_0565C1);
    State.IncCycles();
    // MOV BX,0x500 (563E_01DD / 0x565BD)
    BX = 0x500;
    State.IncCycles();
    // RETF  (563E_01E0 / 0x565C0)
    return FarRet();
  }
  
  public virtual Action not_observed_563E_01E1_0565C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_01E1_565C1:
    // PUSHF  (563E_01E1 / 0x565C1)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CLI  (563E_01E2 / 0x565C2)
    InterruptFlag = false;
    State.IncCycles();
    // CALL 0x5000:690f (563E_01E3 / 0x565C3)
    NearCall(cs4, 0x1E6, spice86_generated_label_call_target_563E_052F_05690F);
    State.IncCycles();
    // XOR AX,AX (563E_01E6 / 0x565C6)
    AX = 0;
    State.IncCycles();
    // MOV CS:[0x139],AL (563E_01E8 / 0x565C8)
    UInt8[cs4, 0x139] = AL;
    State.IncCycles();
    // POPF  (563E_01EC / 0x565CC)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RETF  (563E_01ED / 0x565CD)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_01EE_0565CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_01EE_565CE:
    // PUSH BX (563E_01EE / 0x565CE)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,0xffff (563E_01EF / 0x565CF)
    BX = 0xFFFF;
    State.IncCycles();
    // CMP AX,0x60 (563E_01F2 / 0x565D2)
    Alu.Sub16(AX, 0x60);
    State.IncCycles();
    // JC 0x5000:65f1 (563E_01F5 / 0x565D5)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    State.IncCycles();
    // MOV BX,0xaaaa (563E_01F7 / 0x565D7)
    BX = 0xAAAA;
    State.IncCycles();
    // CMP AX,0xc0 (563E_01FA / 0x565DA)
    Alu.Sub16(AX, 0xC0);
    State.IncCycles();
    // JC 0x5000:65f1 (563E_01FD / 0x565DD)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    State.IncCycles();
    // MOV BX,0x8888 (563E_01FF / 0x565DF)
    BX = 0x8888;
    State.IncCycles();
    // CMP AX,0x180 (563E_0202 / 0x565E2)
    Alu.Sub16(AX, 0x180);
    State.IncCycles();
    // JC 0x5000:65f1 (563E_0205 / 0x565E5)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    State.IncCycles();
    // MOV BX,0x8080 (563E_0207 / 0x565E7)
    BX = 0x8080;
    State.IncCycles();
    // CMP AX,0x300 (563E_020A / 0x565EA)
    Alu.Sub16(AX, 0x300);
    State.IncCycles();
    // JC 0x5000:65f1 (563E_020D / 0x565ED)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    State.IncCycles();
    // XOR BL,BL (563E_020F / 0x565EF)
    BL = 0;
    State.IncCycles();
    label_563E_0211_565F1:
    // MOV word ptr CS:[0x13b],BX (563E_0211 / 0x565F1)
    UInt16[cs4, 0x13B] = BX;
    State.IncCycles();
    // POP BX (563E_0216 / 0x565F6)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr CS:[0x13e],BL (563E_0217 / 0x565F7)
    UInt8[cs4, 0x13E] = BL;
    State.IncCycles();
    // MOV AL,CS:[0x139] (563E_021C / 0x565FC)
    AL = UInt8[cs4, 0x139];
    State.IncCycles();
    // OR AL,AL (563E_0220 / 0x56600)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x5000:660a (563E_0222 / 0x56602)
    if(!SignFlag) {
      // JNS target is RETF, inlining.
      State.IncCycles();
      // RETF  (563E_022A / 0x5660A)
      return FarRet();
    }
    State.IncCycles();
    // OR AL,0x40 (563E_0224 / 0x56604)
    // AL |= 0x40;
    AL = Alu.Or8(AL, 0x40);
    State.IncCycles();
    // MOV CS:[0x139],AL (563E_0226 / 0x56606)
    UInt8[cs4, 0x139] = AL;
    State.IncCycles();
    label_563E_022A_5660A:
    // RETF  (563E_022A / 0x5660A)
    return FarRet();
  }
  
  public virtual Action not_observed_563E_022B_05660B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_022B_5660B:
    // MOV CS:[0x13f],AL (563E_022B / 0x5660B)
    UInt8[cs4, 0x13F] = AL;
    State.IncCycles();
    // MOV CS:[0x13e],AL (563E_022F / 0x5660F)
    UInt8[cs4, 0x13E] = AL;
    State.IncCycles();
    // MOV word ptr CS:[0x13b],0xffff (563E_0233 / 0x56613)
    UInt16[cs4, 0x13B] = 0xFFFF;
    State.IncCycles();
    // RETF  (563E_023A / 0x5661A)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_023B_05661B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_023B_5661B:
    // MOV byte ptr CS:[0x13a],0x1 (563E_023B / 0x5661B)
    UInt8[cs4, 0x13A] = 0x1;
    State.IncCycles();
    // MOV AL,CS:[0x139] (563E_0241 / 0x56621)
    AL = UInt8[cs4, 0x139];
    State.IncCycles();
    // RETF  (563E_0245 / 0x56625)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_0250_056630(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0250_56630:
    // PUSH DS (563E_0250 / 0x56630)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH CS (563E_0251 / 0x56631)
    Stack.Push(cs4);
    State.IncCycles();
    // POP DS (563E_0252 / 0x56632)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV [0x13a],AL (563E_0253 / 0x56633)
    UInt8[DS, 0x13A] = AL;
    State.IncCycles();
    // MOV AX,word ptr ES:[SI] (563E_0256 / 0x56636)
    AX = UInt16[ES, SI];
    State.IncCycles();
    // MOV DI,0x246 (563E_0259 / 0x56639)
    DI = 0x246;
    State.IncCycles();
    // MOV word ptr [DI],SI (563E_025C / 0x5663C)
    UInt16[DS, DI] = SI;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],ES (563E_025E / 0x5663E)
    UInt16[DS, (ushort)(DI + 0x2)] = ES;
    State.IncCycles();
    // MOV word ptr [DI + 0x4],AX (563E_0261 / 0x56641)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    State.IncCycles();
    // MOV AX,word ptr ES:[SI + 0x4000] (563E_0264 / 0x56644)
    AX = UInt16[ES, (ushort)(SI + 0x4000)];
    State.IncCycles();
    // MOV word ptr [DI + 0x6],AX (563E_0269 / 0x56649)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    State.IncCycles();
    // MOV AX,word ptr ES:[SI + 0x8000] (563E_026C / 0x5664C)
    AX = UInt16[ES, (ushort)(SI + 0x8000)];
    State.IncCycles();
    // MOV word ptr [DI + 0x8],AX (563E_0271 / 0x56651)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    State.IncCycles();
    // ADD SI,0x2 (563E_0274 / 0x56654)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // MOV word ptr [0x115],SI (563E_0277 / 0x56657)
    UInt16[DS, 0x115] = SI;
    State.IncCycles();
    // MOV word ptr [0x117],ES (563E_027B / 0x5665B)
    UInt16[DS, 0x117] = ES;
    State.IncCycles();
    // SUB SI,0x2 (563E_027F / 0x5665F)
    SI -= 0x2;
    State.IncCycles();
    // ADD SI,word ptr ES:[SI] (563E_0282 / 0x56662)
    // SI += UInt16[ES, SI];
    SI = Alu.Add16(SI, UInt16[ES, SI]);
    State.IncCycles();
    // MOV word ptr [0x119],SI (563E_0285 / 0x56665)
    UInt16[DS, 0x119] = SI;
    State.IncCycles();
    // MOV word ptr [0x11b],ES (563E_0289 / 0x56669)
    UInt16[DS, 0x11B] = ES;
    State.IncCycles();
    // CALL 0x5000:690f (563E_028D / 0x5666D)
    NearCall(cs4, 0x290, spice86_generated_label_call_target_563E_052F_05690F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_0290_056670, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_563E_0290_056670(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0290_56670:
    // CALL 0x5000:668e (563E_0290 / 0x56670)
    NearCall(cs4, 0x293, spice86_generated_label_call_target_563E_02AE_05668E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_0293_056673, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_563E_0293_056673(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0293_56673:
    // MOV AL,[0x13f] (563E_0293 / 0x56673)
    AL = UInt8[DS, 0x13F];
    State.IncCycles();
    // MOV [0x13d],AL (563E_0296 / 0x56676)
    UInt8[DS, 0x13D] = AL;
    State.IncCycles();
    // MOV [0x13e],AL (563E_0299 / 0x56679)
    UInt8[DS, 0x13E] = AL;
    State.IncCycles();
    // XOR AX,AX (563E_029C / 0x5667C)
    AX = 0;
    State.IncCycles();
    // MOV [0x11d],AX (563E_029E / 0x5667E)
    UInt16[DS, 0x11D] = AX;
    State.IncCycles();
    // MOV [0x123],AX (563E_02A1 / 0x56681)
    UInt16[DS, 0x123] = AX;
    State.IncCycles();
    // CALL 0x5000:674f (563E_02A4 / 0x56684)
    NearCall(cs4, 0x2A7, spice86_generated_label_call_target_563E_036F_05674F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_02A7_056687, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_563E_02A7_056687(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_02A7_56687:
    // MOV AL,0x80 (563E_02A7 / 0x56687)
    AL = 0x80;
    State.IncCycles();
    // MOV [0x139],AL (563E_02A9 / 0x56689)
    UInt8[DS, 0x139] = AL;
    State.IncCycles();
    // POP DS (563E_02AC / 0x5668C)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (563E_02AD / 0x5668D)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_02AE_05668E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_02AE_5668E:
    // PUSH DS (563E_02AE / 0x5668E)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH DS (563E_02AF / 0x5668F)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (563E_02B0 / 0x56690)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0x140],0x0 (563E_02B1 / 0x56691)
    UInt16[DS, 0x140] = 0x0;
    State.IncCycles();
    // LDS SI,[0x115] (563E_02B7 / 0x56697)
    DS = UInt16[DS, 0x117];
    SI = UInt16[DS, 0x115];
    State.IncCycles();
    // MOV BP,SI (563E_02BB / 0x5669B)
    BP = SI;
    State.IncCycles();
    // MOV DI,0x166 (563E_02BD / 0x5669D)
    DI = 0x166;
    State.IncCycles();
    // MOV CX,0x9 (563E_02C0 / 0x566A0)
    CX = 0x9;
    State.IncCycles();
    label_563E_02C3_566A3:
    // LODSW SI (563E_02C3 / 0x566A3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (563E_02C4 / 0x566A4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x5000:66af (563E_02C6 / 0x566A6)
    if(ZeroFlag) {
      goto label_563E_02CF_566AF;
    }
    State.IncCycles();
    // INC word ptr CS:[0x140] (563E_02C8 / 0x566A8)
    UInt16[cs4, 0x140]++;
    State.IncCycles();
    // ADD AX,BP (563E_02CD / 0x566AD)
    // AX += BP;
    AX = Alu.Add16(AX, BP);
    State.IncCycles();
    label_563E_02CF_566AF:
    // STOSW ES:DI (563E_02CF / 0x566AF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LOOP 0x5000:66a3 (563E_02D0 / 0x566B0)
    if(--CX != 0) {
      goto label_563E_02C3_566A3;
    }
    State.IncCycles();
    // MOV DI,0x19c (563E_02D2 / 0x566B2)
    DI = 0x19C;
    State.IncCycles();
    // MOV CL,0x9 (563E_02D5 / 0x566B5)
    CL = 0x9;
    State.IncCycles();
    // MOV AL,0x60 (563E_02D7 / 0x566B7)
    AL = 0x60;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (563E_02D9 / 0x566B9)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DS (563E_02DB / 0x566BB)
    DS = Stack.Pop();
    State.IncCycles();
    // LES SI,[0x115] (563E_02DC / 0x566BC)
    ES = UInt16[DS, 0x117];
    SI = UInt16[DS, 0x115];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_563E_02E0_0566C0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_563E_02E0_0566C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_02E0_566C0:
    // MOV word ptr [0x11f],0x1 (563E_02E0 / 0x566C0)
    UInt16[DS, 0x11F] = 0x1;
    State.IncCycles();
    // MOV word ptr [0x121],0x60 (563E_02E6 / 0x566C6)
    UInt16[DS, 0x121] = 0x60;
    State.IncCycles();
    // MOV CX,0x9 (563E_02EC / 0x566CC)
    CX = 0x9;
    State.IncCycles();
    // MOV DI,0x142 (563E_02EF / 0x566CF)
    DI = 0x142;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_02F2_0566D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_02F2_0566D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_02F2_566D2:
    // MOV SI,word ptr [DI + 0x24] (563E_02F2 / 0x566D2)
    SI = UInt16[DS, (ushort)(DI + 0x24)];
    State.IncCycles();
    // MOV word ptr [DI + 0x12],SI (563E_02F5 / 0x566D5)
    UInt16[DS, (ushort)(DI + 0x12)] = SI;
    State.IncCycles();
    // MOV word ptr [DI],0xffff (563E_02F8 / 0x566D8)
    UInt16[DS, DI] = 0xFFFF;
    State.IncCycles();
    // OR SI,SI (563E_02FC / 0x566DC)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x5000:66e9 (563E_02FE / 0x566DE)
    if(ZeroFlag) {
      goto label_563E_0309_566E9;
    }
    State.IncCycles();
    // MOV AX,CX (563E_0300 / 0x566E0)
    AX = CX;
    State.IncCycles();
    // CALL 0x5000:687b (563E_0302 / 0x566E2)
    NearCall(cs4, 0x305, spice86_generated_label_call_target_563E_049B_05687B);
    State.IncCycles();
    label_563E_0305_566E5:
    // INC word ptr [DI] (563E_0305 / 0x566E5)
    UInt16[DS, DI] = Alu.Inc16(UInt16[DS, DI]);
    State.IncCycles();
    // MOV CX,AX (563E_0307 / 0x566E7)
    CX = AX;
    State.IncCycles();
    label_563E_0309_566E9:
    // ADD DI,0x2 (563E_0309 / 0x566E9)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x5000:66d2 (563E_030C / 0x566EC)
    if(--CX != 0) {
      goto label_563E_02F2_566D2;
    }
    State.IncCycles();
    // RET  (563E_030E / 0x566EE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_030F_0566EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_030F_566EF:
    // PUSH DS (563E_030F / 0x566EF)
    Stack.Push(DS);
    State.IncCycles();
    // MOV AX,CS (563E_0310 / 0x566F0)
    AX = cs4;
    State.IncCycles();
    // MOV DS,AX (563E_0312 / 0x566F2)
    DS = AX;
    State.IncCycles();
    // MOV AL,[0x139] (563E_0314 / 0x566F4)
    AL = UInt8[DS, 0x139];
    State.IncCycles();
    // OR AL,AL (563E_0317 / 0x566F7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x5000:671c (563E_0319 / 0x566F9)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_032E_05670E, 0x5671C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC byte ptr [0x11e] (563E_031B / 0x566FB)
    UInt8[DS, 0x11E] = Alu.Dec8(UInt8[DS, 0x11E]);
    State.IncCycles();
    // JNS 0x5000:6713 (563E_031F / 0x566FF)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_032E_05670E, 0x56713 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x5000:6729 (563E_0321 / 0x56701)
    NearCall(cs4, 0x324, spice86_generated_label_call_target_563E_0349_056729);
    State.IncCycles();
    label_563E_0324_56704:
    // JNZ 0x5000:671c (563E_0324 / 0x56704)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_032E_05670E, 0x5671C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH DX (563E_0326 / 0x56706)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (563E_0327 / 0x56707)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (563E_0328 / 0x56708)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (563E_0329 / 0x56709)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (563E_032A / 0x5670A)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x5000:674f (563E_032B / 0x5670B)
    NearCall(cs4, 0x32E, spice86_generated_label_call_target_563E_036F_05674F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_032E_05670E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_563E_032E_05670E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x46713: goto label_563E_0333_56713;break; // Target of external jump from 0x566FF
      case 0x4671C: goto label_563E_033C_5671C;break; // Target of external jump from 0x56717, 0x566F9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_563E_032E_5670E:
    // POP ES (563E_032E / 0x5670E)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (563E_032F / 0x5670F)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (563E_0330 / 0x56710)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (563E_0331 / 0x56711)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (563E_0332 / 0x56712)
    DX = Stack.Pop();
    State.IncCycles();
    label_563E_0333_56713:
    // ROL word ptr [0x13b],1 (563E_0333 / 0x56713)
    UInt16[DS, 0x13B] = Alu.Rol16(UInt16[DS, 0x13B], 0x1);
    State.IncCycles();
    // JNC 0x5000:671c (563E_0337 / 0x56717)
    if(!CarryFlag) {
      goto label_563E_033C_5671C;
    }
    State.IncCycles();
    // CALL 0x5000:68b7 (563E_0339 / 0x56719)
    NearCall(cs4, 0x33C, spice86_generated_label_call_target_563E_04D7_0568B7);
    State.IncCycles();
    label_563E_033C_5671C:
    // MOV AL,[0x139] (563E_033C / 0x5671C)
    AL = UInt8[DS, 0x139];
    State.IncCycles();
    // MOV BX,word ptr [0x11f] (563E_033F / 0x5671F)
    BX = UInt16[DS, 0x11F];
    State.IncCycles();
    // MOV CX,word ptr [0x121] (563E_0343 / 0x56723)
    CX = UInt16[DS, 0x121];
    State.IncCycles();
    // POP DS (563E_0347 / 0x56727)
    DS = Stack.Pop();
    State.IncCycles();
    // RETF  (563E_0348 / 0x56728)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0349_056729(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0349_56729:
    // PUSH SI (563E_0349 / 0x56729)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH ES (563E_034A / 0x5672A)
    Stack.Push(ES);
    State.IncCycles();
    // LES SI,[0x246] (563E_034B / 0x5672B)
    ES = UInt16[DS, 0x248];
    SI = UInt16[DS, 0x246];
    State.IncCycles();
    // MOV AX,word ptr ES:[SI] (563E_034F / 0x5672F)
    AX = UInt16[ES, SI];
    State.IncCycles();
    // CMP word ptr [0x24a],AX (563E_0352 / 0x56732)
    Alu.Sub16(UInt16[DS, 0x24A], AX);
    State.IncCycles();
    // JNZ 0x5000:674c (563E_0356 / 0x56736)
    if(!ZeroFlag) {
      goto label_563E_036C_5674C;
    }
    State.IncCycles();
    // MOV AX,word ptr ES:[SI + 0x4000] (563E_0358 / 0x56738)
    AX = UInt16[ES, (ushort)(SI + 0x4000)];
    State.IncCycles();
    // CMP word ptr [0x24c],AX (563E_035D / 0x5673D)
    Alu.Sub16(UInt16[DS, 0x24C], AX);
    State.IncCycles();
    // JNZ 0x5000:674c (563E_0361 / 0x56741)
    if(!ZeroFlag) {
      goto label_563E_036C_5674C;
    }
    State.IncCycles();
    // MOV AX,word ptr ES:[SI + 0x8000] (563E_0363 / 0x56743)
    AX = UInt16[ES, (ushort)(SI + 0x8000)];
    State.IncCycles();
    // CMP word ptr [0x24e],AX (563E_0368 / 0x56748)
    Alu.Sub16(UInt16[DS, 0x24E], AX);
    State.IncCycles();
    label_563E_036C_5674C:
    // POP ES (563E_036C / 0x5674C)
    ES = Stack.Pop();
    State.IncCycles();
    // POP SI (563E_036D / 0x5674D)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (563E_036E / 0x5674E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_036F_05674F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_036F_5674F:
    // LES BX,[0x115] (563E_036F / 0x5674F)
    ES = UInt16[DS, 0x117];
    BX = UInt16[DS, 0x115];
    State.IncCycles();
    // MOV AX,word ptr ES:[BX + 0x30] (563E_0373 / 0x56753)
    AX = UInt16[ES, (ushort)(BX + 0x30)];
    State.IncCycles();
    // ADD word ptr [0x11d],AX (563E_0377 / 0x56757)
    // UInt16[DS, 0x11D] += AX;
    UInt16[DS, 0x11D] = Alu.Add16(UInt16[DS, 0x11D], AX);
    State.IncCycles();
    // MOV DI,0x142 (563E_037B / 0x5675B)
    DI = 0x142;
    State.IncCycles();
    // CALL 0x5000:67a7 (563E_037E / 0x5675E)
    NearCall(cs4, 0x381, spice86_generated_label_call_target_563E_03C7_0567A7);
    State.IncCycles();
    label_563E_0381_56761:
    // MOV CX,word ptr [0x140] (563E_0381 / 0x56761)
    CX = UInt16[DS, 0x140];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_0385_056765, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_0385_056765(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0385_56765:
    // DEC word ptr [DI] (563E_0385 / 0x56765)
    UInt16[DS, DI] = Alu.Dec16(UInt16[DS, DI]);
    State.IncCycles();
    // JNZ 0x5000:6792 (563E_0387 / 0x56767)
    if(!ZeroFlag) {
      goto label_563E_03B2_56792;
    }
    State.IncCycles();
    label_563E_0389_56769:
    // MOV SI,word ptr [DI + 0x12] (563E_0389 / 0x56769)
    SI = UInt16[DS, (ushort)(DI + 0x12)];
    State.IncCycles();
    // OR SI,SI (563E_038C / 0x5676C)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x5000:6792 (563E_038E / 0x5676E)
    if(ZeroFlag) {
      goto label_563E_03B2_56792;
    }
    State.IncCycles();
    // PUSH CX (563E_0390 / 0x56770)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (563E_0391 / 0x56771)
    Stack.Push(DI);
    State.IncCycles();
    // LODSW ES:SI (563E_0392 / 0x56772)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,DI (563E_0394 / 0x56774)
    DX = DI;
    State.IncCycles();
    // SUB DX,0x142 (563E_0396 / 0x56776)
    DX -= 0x142;
    State.IncCycles();
    // SHR DX,1 (563E_039A / 0x5677A)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    State.IncCycles();
    // MOV BX,AX (563E_039C / 0x5677C)
    BX = AX;
    State.IncCycles();
    // AND BX,0x70 (563E_039E / 0x5677E)
    BX &= 0x70;
    State.IncCycles();
    // SHR BX,1 (563E_03A1 / 0x56781)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (563E_03A3 / 0x56783)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (563E_03A5 / 0x56785)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    // CALL word ptr [BX + 0x129] (563E_03A7 / 0x56787)
    // Indirect call to word ptr [BX + 0x129], generating possible targets from emulator records
    uint targetAddress_563E_03A7 = (uint)(cs4 * 0x10 + UInt16[DS, (ushort)(BX + 0x129)] - cs1 * 0x10);
    switch(targetAddress_563E_03A7) {
      case 0x4687B : NearCall(cs4, 0x3AB, spice86_generated_label_call_target_563E_049B_05687B); break;
      case 0x46808 : NearCall(cs4, 0x3AB, spice86_generated_label_call_target_563E_0428_056808); break;
      case 0x4683D : NearCall(cs4, 0x3AB, spice86_generated_label_call_target_563E_045D_05683D); break;
      case 0x46802 : NearCall(cs4, 0x3AB, spice86_generated_label_call_target_563E_0422_056802); break;
      case 0x467FC : NearCall(cs4, 0x3AB, spice86_generated_label_call_target_563E_041C_0567FC); break;
      case 0x46812 : NearCall(cs4, 0x3AB, spice86_generated_label_call_target_563E_0432_056812); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_563E_03A7));
        break;
    }
    State.IncCycles();
    label_563E_03AB_5678B:
    // POP DI (563E_03AB / 0x5678B)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (563E_03AC / 0x5678C)
    CX = Stack.Pop();
    State.IncCycles();
    // CMP word ptr [DI],0x0 (563E_03AD / 0x5678D)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    State.IncCycles();
    // JZ 0x5000:6769 (563E_03B0 / 0x56790)
    if(ZeroFlag) {
      goto label_563E_0389_56769;
    }
    State.IncCycles();
    label_563E_03B2_56792:
    // ADD DI,0x2 (563E_03B2 / 0x56792)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x5000:6765 (563E_03B5 / 0x56795)
    if(--CX != 0) {
      goto label_563E_0385_56765;
    }
    State.IncCycles();
    // DEC byte ptr [0x121] (563E_03B7 / 0x56797)
    UInt8[DS, 0x121] = Alu.Dec8(UInt8[DS, 0x121]);
    State.IncCycles();
    // JNZ 0x5000:67a6 (563E_03BB / 0x5679B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (563E_03C6 / 0x567A6)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x121],0x60 (563E_03BD / 0x5679D)
    UInt8[DS, 0x121] = 0x60;
    State.IncCycles();
    // INC word ptr [0x11f] (563E_03C2 / 0x567A2)
    UInt16[DS, 0x11F] = Alu.Inc16(UInt16[DS, 0x11F]);
    State.IncCycles();
    label_563E_03C6_567A6:
    // RET  (563E_03C6 / 0x567A6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_03C7_0567A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_03C7_567A7:
    // CMP word ptr [0x123],0x0 (563E_03C7 / 0x567A7)
    Alu.Sub16(UInt16[DS, 0x123], 0x0);
    State.IncCycles();
    // JNZ 0x5000:67d8 (563E_03CC / 0x567AC)
    if(!ZeroFlag) {
      goto label_563E_03F8_567D8;
    }
    State.IncCycles();
    // MOV AX,word ptr ES:[BX + 0x2a] (563E_03CE / 0x567AE)
    AX = UInt16[ES, (ushort)(BX + 0x2A)];
    State.IncCycles();
    // CMP AX,word ptr [0x11f] (563E_03D2 / 0x567B2)
    Alu.Sub16(AX, UInt16[DS, 0x11F]);
    State.IncCycles();
    // JNZ 0x5000:67d7 (563E_03D6 / 0x567B6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (563E_03F7 / 0x567D7)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x121],0x60 (563E_03D8 / 0x567B8)
    Alu.Sub16(UInt16[DS, 0x121], 0x60);
    State.IncCycles();
    // JNZ 0x5000:67d7 (563E_03DD / 0x567BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (563E_03F7 / 0x567D7)
      return NearRet();
    }
    State.IncCycles();
    // PUSH DI (563E_03DF / 0x567BF)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (563E_03E0 / 0x567C0)
    Stack.Push(ES);
    State.IncCycles();
    // MOV SI,DI (563E_03E1 / 0x567C1)
    SI = DI;
    State.IncCycles();
    // ADD DI,0x36 (563E_03E3 / 0x567C3)
    // DI += 0x36;
    DI = Alu.Add16(DI, 0x36);
    State.IncCycles();
    // PUSH DS (563E_03E6 / 0x567C6)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (563E_03E7 / 0x567C7)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x12 (563E_03E8 / 0x567C8)
    CX = 0x12;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (563E_03EB / 0x567CB)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP ES (563E_03ED / 0x567CD)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (563E_03EE / 0x567CE)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV AX,word ptr ES:[BX + 0x2e] (563E_03EF / 0x567CF)
    AX = UInt16[ES, (ushort)(BX + 0x2E)];
    State.IncCycles();
    // DEC AX (563E_03F3 / 0x567D3)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV [0x123],AX (563E_03F4 / 0x567D4)
    UInt16[DS, 0x123] = AX;
    State.IncCycles();
    label_563E_03F7_567D7:
    // RET  (563E_03F7 / 0x567D7)
    return NearRet();
    State.IncCycles();
    label_563E_03F8_567D8:
    // MOV AX,word ptr ES:[BX + 0x2c] (563E_03F8 / 0x567D8)
    AX = UInt16[ES, (ushort)(BX + 0x2C)];
    State.IncCycles();
    // CMP AX,word ptr [0x11f] (563E_03FC / 0x567DC)
    Alu.Sub16(AX, UInt16[DS, 0x11F]);
    State.IncCycles();
    // JNZ 0x5000:67d7 (563E_0400 / 0x567E0)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (563E_03F7 / 0x567D7)
      return NearRet();
    }
    State.IncCycles();
    // DEC word ptr [0x123] (563E_0402 / 0x567E2)
    UInt16[DS, 0x123] = Alu.Dec16(UInt16[DS, 0x123]);
    State.IncCycles();
    // PUSH DI (563E_0406 / 0x567E6)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (563E_0407 / 0x567E7)
    Stack.Push(ES);
    State.IncCycles();
    // LEA SI,[DI + 0x36] (563E_0408 / 0x567E8)
    SI = (ushort)(DI + 0x36);
    State.IncCycles();
    // PUSH DS (563E_040B / 0x567EB)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (563E_040C / 0x567EC)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x12 (563E_040D / 0x567ED)
    CX = 0x12;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (563E_0410 / 0x567F0)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP ES (563E_0412 / 0x567F2)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (563E_0413 / 0x567F3)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV AX,word ptr ES:[BX + 0x2a] (563E_0414 / 0x567F4)
    AX = UInt16[ES, (ushort)(BX + 0x2A)];
    State.IncCycles();
    // MOV [0x11f],AX (563E_0418 / 0x567F8)
    UInt16[DS, 0x11F] = AX;
    State.IncCycles();
    // RET  (563E_041B / 0x567FB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_041C_0567FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_041C_567FC:
    // CALL 0x5000:687b (563E_041C / 0x567FC)
    NearCall(cs4, 0x41F, spice86_generated_label_call_target_563E_049B_05687B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_041F_0567FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_563E_041F_0567FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_041F_567FF:
    // JMP 0x5000:6972 (563E_041F / 0x567FF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_0592_056972, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0422_056802(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0422_56802:
    // CALL 0x5000:687b (563E_0422 / 0x56802)
    NearCall(cs4, 0x425, spice86_generated_label_call_target_563E_049B_05687B);
    State.IncCycles();
    label_563E_0425_56805:
    // JMP 0x5000:6972 (563E_0425 / 0x56805)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_563E_0592_056972, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0428_056808(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0428_56808:
    // MOV CL,byte ptr ES:[SI] (563E_0428 / 0x56808)
    CL = UInt8[ES, SI];
    State.IncCycles();
    // INC SI (563E_042B / 0x5680B)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // CALL 0x5000:687b (563E_042C / 0x5680C)
    NearCall(cs4, 0x42F, spice86_generated_label_call_target_563E_049B_05687B);
    State.IncCycles();
    label_563E_042F_5680F:
    // JMP 0x5000:6986 (563E_042F / 0x5680F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_563E_05A6_056986, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0432_056812(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0432_56812:
    // MOV CL,byte ptr ES:[SI] (563E_0432 / 0x56812)
    CL = UInt8[ES, SI];
    State.IncCycles();
    // INC SI (563E_0435 / 0x56815)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // CALL 0x5000:687b (563E_0436 / 0x56816)
    NearCall(cs4, 0x439, spice86_generated_label_call_target_563E_049B_05687B);
    State.IncCycles();
    label_563E_0439_56819:
    // CMP AH,0x7 (563E_0439 / 0x56819)
    Alu.Sub8(AH, 0x7);
    State.IncCycles();
    // JNZ 0x5000:6830 (563E_043C / 0x5681C)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x5000:6986 (563E_0450 / 0x56830)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_563E_05A6_056986, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV BX,AX (563E_043E / 0x5681E)
    BX = AX;
    State.IncCycles();
    // AND BX,0xf (563E_0440 / 0x56820)
    // BX &= 0xF;
    BX = Alu.And16(BX, 0xF);
    State.IncCycles();
    // MOV byte ptr [BX + 0x19c],CL (563E_0443 / 0x56823)
    UInt8[DS, (ushort)(BX + 0x19C)] = CL;
    State.IncCycles();
    // PUSH AX (563E_0447 / 0x56827)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AL,[0x13d] (563E_0448 / 0x56828)
    AL = UInt8[DS, 0x13D];
    State.IncCycles();
    // MUL CL (563E_044B / 0x5682B)
    Cpu.Mul8(CL);
    State.IncCycles();
    // MOV CL,AH (563E_044D / 0x5682D)
    CL = AH;
    State.IncCycles();
    // POP AX (563E_044F / 0x5682F)
    AX = Stack.Pop();
    State.IncCycles();
    label_563E_0450_56830:
    // JMP 0x5000:6986 (563E_0450 / 0x56830)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_563E_05A6_056986, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_045D_05683D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_045D_5683D:
    // CMP AL,0xff (563E_045D / 0x5683D)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // JZ 0x5000:6842 (563E_045F / 0x5683F)
    if(ZeroFlag) {
      goto label_563E_0462_56842;
    }
    State.IncCycles();
    // NOP  (563E_0461 / 0x56841)
    
    State.IncCycles();
    label_563E_0462_56842:
    // MOV word ptr [DI],0xffff (563E_0462 / 0x56842)
    UInt16[DS, DI] = 0xFFFF;
    State.IncCycles();
    // SUB byte ptr [DI + 0x12],0x2 (563E_0466 / 0x56846)
    // UInt8[DS, (ushort)(DI + 0x12)] -= 0x2;
    UInt8[DS, (ushort)(DI + 0x12)] = Alu.Sub8(UInt8[DS, (ushort)(DI + 0x12)], 0x2);
    State.IncCycles();
    // OR DX,DX (563E_046A / 0x5684A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNZ 0x5000:6869 (563E_046C / 0x5684C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (563E_0489 / 0x56869)
      return NearRet();
    }
    State.IncCycles();
    // DEC byte ptr [0x13a] (563E_046E / 0x5684E)
    UInt8[DS, 0x13A] = Alu.Dec8(UInt8[DS, 0x13A]);
    State.IncCycles();
    // JZ 0x5000:686a (563E_0472 / 0x56852)
    if(ZeroFlag) {
      goto label_563E_048A_5686A;
    }
    State.IncCycles();
    // JNS 0x5000:685a (563E_0474 / 0x56854)
    if(!SignFlag) {
      goto label_563E_047A_5685A;
    }
    State.IncCycles();
    // INC byte ptr [0x13a] (563E_0476 / 0x56856)
    UInt8[DS, 0x13A] = Alu.Inc8(UInt8[DS, 0x13A]);
    State.IncCycles();
    label_563E_047A_5685A:
    // CALL 0x5000:66c0 (563E_047A / 0x5685A)
    NearCall(cs4, 0x47D, not_observed_563E_02E0_0566C0);
    State.IncCycles();
    // LES BX,[0x115] (563E_047D / 0x5685D)
    ES = UInt16[DS, 0x117];
    BX = UInt16[DS, 0x115];
    State.IncCycles();
    // MOV DI,0x142 (563E_0481 / 0x56861)
    DI = 0x142;
    State.IncCycles();
    // CALL 0x5000:67a7 (563E_0484 / 0x56864)
    NearCall(cs4, 0x487, spice86_generated_label_call_target_563E_03C7_0567A7);
    State.IncCycles();
    // DEC word ptr [DI] (563E_0487 / 0x56867)
    UInt16[DS, DI] = Alu.Dec16(UInt16[DS, DI]);
    State.IncCycles();
    label_563E_0489_56869:
    // RET  (563E_0489 / 0x56869)
    return NearRet();
    State.IncCycles();
    label_563E_048A_5686A:
    // MOV AX,0xffff (563E_048A / 0x5686A)
    AX = 0xFFFF;
    State.IncCycles();
    // PUSH ES (563E_048D / 0x5686D)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH DS (563E_048E / 0x5686E)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (563E_048F / 0x5686F)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x9 (563E_0490 / 0x56870)
    CX = 0x9;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (563E_0493 / 0x56873)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP ES (563E_0495 / 0x56875)
    ES = Stack.Pop();
    State.IncCycles();
    // PUSH CS (563E_0496 / 0x56876)
    Stack.Push(cs4);
    State.IncCycles();
    // CALL 0x5000:65c1 (563E_0497 / 0x56877)
    NearCall(cs4, 0x49A, not_observed_563E_01E1_0565C1);
    State.IncCycles();
    // RET  (563E_049A / 0x5687A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_049B_05687B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_049B_5687B:
    // PUSH AX (563E_049B / 0x5687B)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (563E_049C / 0x5687C)
    Stack.Push(CX);
    State.IncCycles();
    // XOR AX,AX (563E_049D / 0x5687D)
    AX = 0;
    State.IncCycles();
    // LODSB ES:SI (563E_049F / 0x5687F)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (563E_04A1 / 0x56881)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x5000:68af (563E_04A3 / 0x56883)
    if(!SignFlag) {
      goto label_563E_04CF_568AF;
    }
    State.IncCycles();
    // XOR CX,CX (563E_04A5 / 0x56885)
    CX = 0;
    State.IncCycles();
    label_563E_04A7_56887:
    // MOV CH,CL (563E_04A7 / 0x56887)
    CH = CL;
    State.IncCycles();
    // MOV CL,AH (563E_04A9 / 0x56889)
    CL = AH;
    State.IncCycles();
    // MOV AH,AL (563E_04AB / 0x5688B)
    AH = AL;
    State.IncCycles();
    // LODSB ES:SI (563E_04AD / 0x5688D)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (563E_04AF / 0x5688F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x5000:6887 (563E_04B1 / 0x56891)
    if(SignFlag) {
      goto label_563E_04A7_56887;
    }
    State.IncCycles();
    // AND AX,0x7f7f (563E_04B3 / 0x56893)
    AX &= 0x7F7F;
    State.IncCycles();
    // AND CX,0x7f7f (563E_04B6 / 0x56896)
    CX &= 0x7F7F;
    State.IncCycles();
    // SHL CL,1 (563E_04BA / 0x5689A)
    CL <<= 0x1;
    State.IncCycles();
    // SHR CX,1 (563E_04BC / 0x5689C)
    CX >>= 0x1;
    State.IncCycles();
    // SHL AL,1 (563E_04BE / 0x5689E)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (563E_04C0 / 0x568A0)
    AX <<= 0x1;
    State.IncCycles();
    // SHR CX,1 (563E_04C2 / 0x568A2)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // RCR AX,1 (563E_04C4 / 0x568A4)
    AX = Alu.Rcr16(AX, 0x1);
    State.IncCycles();
    // SHR CX,1 (563E_04C6 / 0x568A6)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // RCR AX,1 (563E_04C8 / 0x568A8)
    AX = Alu.Rcr16(AX, 0x1);
    State.IncCycles();
    // JCXZ 0x5000:68af (563E_04CA / 0x568AA)
    if(CX == 0) {
      goto label_563E_04CF_568AF;
    }
    State.IncCycles();
    // MOV AX,0xffff (563E_04CC / 0x568AC)
    AX = 0xFFFF;
    State.IncCycles();
    label_563E_04CF_568AF:
    // MOV word ptr [DI],AX (563E_04CF / 0x568AF)
    UInt16[DS, DI] = AX;
    State.IncCycles();
    // MOV word ptr [DI + 0x12],SI (563E_04D1 / 0x568B1)
    UInt16[DS, (ushort)(DI + 0x12)] = SI;
    State.IncCycles();
    // POP CX (563E_04D4 / 0x568B4)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (563E_04D5 / 0x568B5)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (563E_04D6 / 0x568B6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_04D7_0568B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_04D7_568B7:
    // MOV AL,[0x13d] (563E_04D7 / 0x568B7)
    AL = UInt8[DS, 0x13D];
    State.IncCycles();
    // SUB AL,byte ptr [0x13e] (563E_04DA / 0x568BA)
    // AL -= UInt8[DS, 0x13E];
    AL = Alu.Sub8(AL, UInt8[DS, 0x13E]);
    State.IncCycles();
    // JNZ 0x5000:68cc (563E_04DE / 0x568BE)
    if(!ZeroFlag) {
      goto label_563E_04EC_568CC;
    }
    State.IncCycles();
    // MOV word ptr [0x13b],0x1 (563E_04E0 / 0x568C0)
    UInt16[DS, 0x13B] = 0x1;
    State.IncCycles();
    // AND byte ptr [0x139],0xbf (563E_04E6 / 0x568C6)
    // UInt8[DS, 0x139] &= 0xBF;
    UInt8[DS, 0x139] = Alu.And8(UInt8[DS, 0x139], 0xBF);
    State.IncCycles();
    // RET  (563E_04EB / 0x568CB)
    return NearRet();
    State.IncCycles();
    label_563E_04EC_568CC:
    // PUSH DX (563E_04EC / 0x568CC)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (563E_04ED / 0x568CD)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (563E_04EE / 0x568CE)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (563E_04EF / 0x568CF)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (563E_04F0 / 0x568D0)
    Stack.Push(ES);
    State.IncCycles();
    // JC 0x5000:68db (563E_04F1 / 0x568D1)
    if(CarryFlag) {
      goto label_563E_04FB_568DB;
    }
    State.IncCycles();
    // CMP AL,0x3 (563E_04F3 / 0x568D3)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JC 0x5000:68e1 (563E_04F5 / 0x568D5)
    if(CarryFlag) {
      goto label_563E_0501_568E1;
    }
    State.IncCycles();
    // MOV AL,0x3 (563E_04F7 / 0x568D7)
    AL = 0x3;
    State.IncCycles();
    // JMP 0x5000:68e1 (563E_04F9 / 0x568D9)
    goto label_563E_0501_568E1;
    State.IncCycles();
    label_563E_04FB_568DB:
    // CMP AL,0xfd (563E_04FB / 0x568DB)
    Alu.Sub8(AL, 0xFD);
    State.IncCycles();
    // JNC 0x5000:68e1 (563E_04FD / 0x568DD)
    if(!CarryFlag) {
      goto label_563E_0501_568E1;
    }
    State.IncCycles();
    // MOV AL,0xfd (563E_04FF / 0x568DF)
    AL = 0xFD;
    State.IncCycles();
    label_563E_0501_568E1:
    // SUB byte ptr [0x13d],AL (563E_0501 / 0x568E1)
    // UInt8[DS, 0x13D] -= AL;
    UInt8[DS, 0x13D] = Alu.Sub8(UInt8[DS, 0x13D], AL);
    State.IncCycles();
    // MOV BL,byte ptr [0x13d] (563E_0505 / 0x568E5)
    BL = UInt8[DS, 0x13D];
    State.IncCycles();
    // MOV SI,0x19c (563E_0509 / 0x568E9)
    SI = 0x19C;
    State.IncCycles();
    // MOV DX,0x7b0 (563E_050C / 0x568EC)
    DX = 0x7B0;
    State.IncCycles();
    label_563E_050F_568EF:
    // LODSB SI (563E_050F / 0x568EF)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MUL BL (563E_0510 / 0x568F0)
    Cpu.Mul8(BL);
    State.IncCycles();
    // MOV CL,AH (563E_0512 / 0x568F2)
    CL = AH;
    State.IncCycles();
    // MOV AX,DX (563E_0514 / 0x568F4)
    AX = DX;
    State.IncCycles();
    // CALL 0x5000:6986 (563E_0516 / 0x568F6)
    NearCall(cs4, 0x519, spice86_generated_label_call_target_563E_05A6_056986);
    State.IncCycles();
    label_563E_0519_568F9:
    // INC DX (563E_0519 / 0x568F9)
    DX++;
    State.IncCycles();
    // CMP DL,0xba (563E_051A / 0x568FA)
    Alu.Sub8(DL, 0xBA);
    State.IncCycles();
    // JC 0x5000:68ef (563E_051D / 0x568FD)
    if(CarryFlag) {
      goto label_563E_050F_568EF;
    }
    State.IncCycles();
    // OR BL,BL (563E_051F / 0x568FF)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JNZ 0x5000:6909 (563E_0521 / 0x56901)
    if(!ZeroFlag) {
      goto label_563E_0529_56909;
    }
    State.IncCycles();
    // MOV byte ptr CS:[0x139],0x0 (563E_0523 / 0x56903)
    UInt8[cs4, 0x139] = 0x0;
    State.IncCycles();
    label_563E_0529_56909:
    // POP ES (563E_0529 / 0x56909)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (563E_052A / 0x5690A)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (563E_052B / 0x5690B)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (563E_052C / 0x5690C)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (563E_052D / 0x5690D)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (563E_052E / 0x5690E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_052F_05690F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_052F_5690F:
    // MOV word ptr CS:[0x127],0x50 (563E_052F / 0x5690F)
    UInt16[cs4, 0x127] = 0x50;
    State.IncCycles();
    // XOR DX,DX (563E_0536 / 0x56916)
    DX = 0;
    State.IncCycles();
    label_563E_0538_56918:
    // MOV AX,0x7bb0 (563E_0538 / 0x56918)
    AX = 0x7BB0;
    State.IncCycles();
    // OR AL,DL (563E_053B / 0x5691B)
    AL |= DL;
    State.IncCycles();
    // XOR CL,CL (563E_053D / 0x5691D)
    CL = 0;
    State.IncCycles();
    // CALL 0x5000:6986 (563E_053F / 0x5691F)
    NearCall(cs4, 0x542, spice86_generated_label_call_target_563E_05A6_056986);
    State.IncCycles();
    label_563E_0542_56922:
    // MOV AX,0xe0 (563E_0542 / 0x56922)
    AX = 0xE0;
    State.IncCycles();
    // OR AL,DL (563E_0545 / 0x56925)
    // AL |= DL;
    AL = Alu.Or8(AL, DL);
    State.IncCycles();
    // MOV CL,0x40 (563E_0547 / 0x56927)
    CL = 0x40;
    State.IncCycles();
    // CALL 0x5000:6986 (563E_0549 / 0x56929)
    NearCall(cs4, 0x54C, spice86_generated_label_call_target_563E_05A6_056986);
    State.IncCycles();
    label_563E_054C_5692C:
    // INC DX (563E_054C / 0x5692C)
    DX++;
    State.IncCycles();
    // CMP DX,0xa (563E_054D / 0x5692D)
    Alu.Sub16(DX, 0xA);
    State.IncCycles();
    // JC 0x5000:6918 (563E_0550 / 0x56930)
    if(CarryFlag) {
      goto label_563E_0538_56918;
    }
    State.IncCycles();
    // MOV word ptr CS:[0x127],0x1 (563E_0552 / 0x56932)
    UInt16[cs4, 0x127] = 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_563E_0559_056939, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_563E_0559_056939(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0559_56939:
    // MOV BL,0xff (563E_0559 / 0x56939)
    BL = 0xFF;
    State.IncCycles();
    // CALL 0x5000:6944 (563E_055B / 0x5693B)
    NearCall(cs4, 0x55E, spice86_generated_label_call_target_563E_0564_056944);
    State.IncCycles();
    label_563E_055E_5693E:
    // MOV BL,0x3f (563E_055E / 0x5693E)
    BL = 0x3F;
    State.IncCycles();
    // CALL 0x5000:6944 (563E_0560 / 0x56940)
    NearCall(cs4, 0x563, spice86_generated_label_call_target_563E_0564_056944);
    State.IncCycles();
    label_563E_0563_56943:
    // RET  (563E_0563 / 0x56943)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0564_056944(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0564_56944:
    // PUSH CX (563E_0564 / 0x56944)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (563E_0565 / 0x56945)
    Stack.Push(DX);
    State.IncCycles();
    // PUSHF  (563E_0566 / 0x56946)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CLI  (563E_0567 / 0x56947)
    InterruptFlag = false;
    State.IncCycles();
    // MOV DX,word ptr CS:[0x125] (563E_0568 / 0x56948)
    DX = UInt16[cs4, 0x125];
    State.IncCycles();
    // INC DX (563E_056D / 0x5694D)
    DX++;
    State.IncCycles();
    // XOR CX,CX (563E_056E / 0x5694E)
    CX = 0;
    State.IncCycles();
    label_563E_0570_56950:
    // IN AL,DX (563E_0570 / 0x56950)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // TEST AL,0x40 (563E_0571 / 0x56951)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // LOOPNZ 0x5000:6950 (563E_0573 / 0x56953)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_0570_56950;
    }
    State.IncCycles();
    // MOV AL,BL (563E_0575 / 0x56955)
    AL = BL;
    State.IncCycles();
    // OUT DX,AL (563E_0577 / 0x56957)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // MOV CX,0x64 (563E_0578 / 0x56958)
    CX = 0x64;
    State.IncCycles();
    label_563E_057B_5695B:
    // IN AL,DX (563E_057B / 0x5695B)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // TEST AL,0x80 (563E_057C / 0x5695C)
    Alu.And8(AL, 0x80);
    State.IncCycles();
    // LOOPNZ 0x5000:695b (563E_057E / 0x5695E)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_057B_5695B;
    }
    State.IncCycles();
    // INC CX (563E_0580 / 0x56960)
    CX++;
    State.IncCycles();
    // DEC DX (563E_0581 / 0x56961)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // IN AL,DX (563E_0582 / 0x56962)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // INC DX (563E_0583 / 0x56963)
    DX++;
    State.IncCycles();
    // CMP AL,0xfe (563E_0584 / 0x56964)
    Alu.Sub8(AL, 0xFE);
    State.IncCycles();
    // LOOPNZ 0x5000:695b (563E_0586 / 0x56966)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_057B_5695B;
    }
    State.IncCycles();
    // MOV CX,0x4e20 (563E_0588 / 0x56968)
    CX = 0x4E20;
    State.IncCycles();
    label_563E_058B_5696B:
    // IN AL,DX (563E_058B / 0x5696B)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // LOOP 0x5000:696b (563E_058C / 0x5696C)
    if(--CX != 0) {
      goto label_563E_058B_5696B;
    }
    State.IncCycles();
    // POPF  (563E_058E / 0x5696E)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP DX (563E_058F / 0x5696F)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (563E_0590 / 0x56970)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (563E_0591 / 0x56971)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_0592_056972(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_0592_56972:
    // PUSH BX (563E_0592 / 0x56972)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (563E_0593 / 0x56973)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (563E_0594 / 0x56974)
    Stack.Push(DX);
    State.IncCycles();
    // PUSHF  (563E_0595 / 0x56975)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV BX,AX (563E_0596 / 0x56976)
    BX = AX;
    State.IncCycles();
    // CLI  (563E_0598 / 0x56978)
    InterruptFlag = false;
    State.IncCycles();
    // CALL 0x5000:699f (563E_0599 / 0x56979)
    NearCall(cs4, 0x59C, spice86_generated_label_call_target_563E_05BF_05699F);
    State.IncCycles();
    label_563E_059C_5697C:
    // MOV BL,BH (563E_059C / 0x5697C)
    BL = BH;
    State.IncCycles();
    // CALL 0x5000:699f (563E_059E / 0x5697E)
    NearCall(cs4, 0x5A1, spice86_generated_label_call_target_563E_05BF_05699F);
    State.IncCycles();
    label_563E_05A1_56981:
    // POPF  (563E_05A1 / 0x56981)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP DX (563E_05A2 / 0x56982)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (563E_05A3 / 0x56983)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (563E_05A4 / 0x56984)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (563E_05A5 / 0x56985)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_05A6_056986(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_563E_05A6_56986:
    // PUSH BX (563E_05A6 / 0x56986)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (563E_05A7 / 0x56987)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (563E_05A8 / 0x56988)
    Stack.Push(DX);
    State.IncCycles();
    // PUSHF  (563E_05A9 / 0x56989)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV BX,AX (563E_05AA / 0x5698A)
    BX = AX;
    State.IncCycles();
    // PUSH CX (563E_05AC / 0x5698C)
    Stack.Push(CX);
    State.IncCycles();
    // CLI  (563E_05AD / 0x5698D)
    InterruptFlag = false;
    State.IncCycles();
    // CALL 0x5000:699f (563E_05AE / 0x5698E)
    NearCall(cs4, 0x5B1, spice86_generated_label_call_target_563E_05BF_05699F);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_563E_05BF_05699F, 0x56991 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_563E_05BF_05699F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x46991: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_563E_05B1_56991:
    // MOV BL,BH (563E_05B1 / 0x56991)
    BL = BH;
    State.IncCycles();
    // CALL 0x5000:699f (563E_05B3 / 0x56993)
    NearCall(cs4, 0x5B6, spice86_generated_label_call_target_563E_05BF_05699F);
    State.IncCycles();
    label_563E_05B6_56996:
    // POP BX (563E_05B6 / 0x56996)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x5000:699f (563E_05B7 / 0x56997)
    NearCall(cs4, 0x5BA, spice86_generated_label_call_target_563E_05BF_05699F);
    State.IncCycles();
    label_563E_05BA_5699A:
    // POPF  (563E_05BA / 0x5699A)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // POP DX (563E_05BB / 0x5699B)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (563E_05BC / 0x5699C)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (563E_05BD / 0x5699D)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (563E_05BE / 0x5699E)
    return NearRet();
    entry:
    State.IncCycles();
    label_563E_05BF_5699F:
    // MOV DX,word ptr CS:[0x125] (563E_05BF / 0x5699F)
    DX = UInt16[cs4, 0x125];
    State.IncCycles();
    // INC DX (563E_05C4 / 0x569A4)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // MOV CX,0xff (563E_05C5 / 0x569A5)
    CX = 0xFF;
    State.IncCycles();
    label_563E_05C8_569A8:
    // IN AL,DX (563E_05C8 / 0x569A8)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // TEST AL,0x40 (563E_05C9 / 0x569A9)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // LOOPNZ 0x5000:69a8 (563E_05CB / 0x569AB)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_05C8_569A8;
    }
    State.IncCycles();
    // DEC DX (563E_05CD / 0x569AD)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // MOV AL,BL (563E_05CE / 0x569AE)
    AL = BL;
    State.IncCycles();
    // OUT DX,AL (563E_05D0 / 0x569B0)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // INC DX (563E_05D1 / 0x569B1)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // MOV CX,word ptr CS:[0x127] (563E_05D2 / 0x569B2)
    CX = UInt16[cs4, 0x127];
    State.IncCycles();
    label_563E_05D7_569B7:
    // IN AL,DX (563E_05D7 / 0x569B7)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // LOOP 0x5000:69b7 (563E_05D8 / 0x569B8)
    if(--CX != 0) {
      goto label_563E_05D7_569B7;
    }
    State.IncCycles();
    // RET  (563E_05DA / 0x569BA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_F000_0000_0F0000(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0000_F0000:
    // NOP  (F000_0000 / 0xF0000)
    
    State.IncCycles();
    // INT 0x8 (F000_0001 / 0xF0001)
    Interrupt(0x8);
    State.IncCycles();
    // IRET  (F000_0003 / 0xF0003)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x9_F000_0004_F0004(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0004_F0004:
    // NOP  (F000_0004 / 0xF0004)
    
    State.IncCycles();
    // INT 0x9 (F000_0005 / 0xF0005)
    Interrupt(0x9);
    State.IncCycles();
    // IRET  (F000_0007 / 0xF0007)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x10_F000_0008_F0008(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0008_F0008:
    // NOP  (F000_0008 / 0xF0008)
    
    State.IncCycles();
    // INT 0x10 (F000_0009 / 0xF0009)
    Interrupt(0x10);
    State.IncCycles();
    // IRET  (F000_000B / 0xF000B)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x11_F000_000C_F000C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_000C_F000C:
    // NOP  (F000_000C / 0xF000C)
    
    State.IncCycles();
    // INT 0x11 (F000_000D / 0xF000D)
    Interrupt(0x11);
    State.IncCycles();
    // IRET  (F000_000F / 0xF000F)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x15_F000_0010_F0010(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0010_F0010:
    // NOP  (F000_0010 / 0xF0010)
    
    State.IncCycles();
    // INT 0x15 (F000_0011 / 0xF0011)
    Interrupt(0x15);
    State.IncCycles();
    // IRET  (F000_0013 / 0xF0013)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x16_F000_0014_F0014(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0014_F0014:
    // NOP  (F000_0014 / 0xF0014)
    
    State.IncCycles();
    // INT 0x16 (F000_0015 / 0xF0015)
    Interrupt(0x16);
    State.IncCycles();
    // IRET  (F000_0017 / 0xF0017)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x1A_F000_0018_F0018(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0018_F0018:
    // NOP  (F000_0018 / 0xF0018)
    
    State.IncCycles();
    // INT 0x1a (F000_0019 / 0xF0019)
    Interrupt(0x1a);
    State.IncCycles();
    // IRET  (F000_001B / 0xF001B)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x20_F000_001C_F001C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_001C_F001C:
    // NOP  (F000_001C / 0xF001C)
    
    State.IncCycles();
    // INT 0x20 (F000_001D / 0xF001D)
    Interrupt(0x20);
    State.IncCycles();
    // IRET  (F000_001F / 0xF001F)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x21_F000_0020_F0020(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0020_F0020:
    // NOP  (F000_0020 / 0xF0020)
    
    State.IncCycles();
    // INT 0x21 (F000_0021 / 0xF0021)
    Interrupt(0x21);
    State.IncCycles();
    // IRET  (F000_0023 / 0xF0023)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x33_F000_0024_F0024(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_F000_0024_F0024:
    // NOP  (F000_0024 / 0xF0024)
    
    State.IncCycles();
    // INT 0x33 (F000_0025 / 0xF0025)
    Interrupt(0x33);
    State.IncCycles();
    // IRET  (F000_0027 / 0xF0027)
    return InterruptRet();
  }
  
}
