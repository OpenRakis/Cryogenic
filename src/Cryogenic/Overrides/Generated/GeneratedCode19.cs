namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_D6FE_01D6FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D6FE_1D6FE:
    // CMP DX,word ptr [DI] (1000_D6FE / 0x1D6FE)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JBE 0x1000:d710 (1000_D700 / 0x1D700)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D710_1D710;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI + 0x4] (1000_D702 / 0x1D702)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JNC 0x1000:d710 (1000_D705 / 0x1D705)
    if(!CarryFlag) {
      goto label_1000_D710_1D710;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x2] (1000_D707 / 0x1D707)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JBE 0x1000:d710 (1000_D70A / 0x1D70A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D710_1D710;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x6] (1000_D70C / 0x1D70C)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // RET  (1000_D70F / 0x1D70F)
    return NearRet();
    State.IncCycles();
    label_1000_D710_1D710:
    // CLC  (1000_D710 / 0x1D710)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_D711 / 0x1D711)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_D712_01D712(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D712_1D712:
    // MOV SI,0x1cca (1000_D712 / 0x1D712)
    SI = 0x1CCA;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D717_1D717:
    // CMP byte ptr [0x46eb],0x0 (1000_D717 / 0x1D717)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:d712 (1000_D71C / 0x1D71C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D712_01D712, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x1c76 (1000_D71E / 0x1D71E)
    SI = 0x1C76;
    State.IncCycles();
    // TEST byte ptr [0x11c9],0x3 (1000_D721 / 0x1D721)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JZ 0x1000:d72b (1000_D726 / 0x1D726)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D72B_1D72B:
    // PUSH DS (1000_D72B / 0x1D72B)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_D72C / 0x1D72C)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x1b8e (1000_D72D / 0x1D72D)
    DI = 0x1B8E;
    State.IncCycles();
    // MOV CX,0x2a (1000_D730 / 0x1D730)
    CX = 0x2A;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D735_1D735:
    // CALL 0x1000:d741 (1000_D735 / 0x1D735)
    NearCall(cs1, 0xD738, spice86_generated_label_call_target_1000_D741_01D741);
    State.IncCycles();
    label_1000_D738_1D738:
    // MOV SI,0x1b8e (1000_D738 / 0x1D738)
    SI = 0x1B8E;
    State.IncCycles();
    // MOV CX,0x6 (1000_D73B / 0x1D73B)
    CX = 0x6;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D741_1D741:
    // MOV AX,[0x1b0c] (1000_D741 / 0x1D741)
    AX = UInt16[DS, 0x1B0C];
    State.IncCycles();
    // SUB AX,0x3 (1000_D744 / 0x1D744)
    AX -= 0x3;
    State.IncCycles();
    // CMP AX,0x3 (1000_D747 / 0x1D747)
    Alu.Sub16(AX, 0x3);
    State.IncCycles();
    // JNC 0x1000:d759 (1000_D74A / 0x1D74A)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D759 / 0x1D759)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x2458 (1000_D74C / 0x1D74C)
    SI = 0x2458;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd8] (1000_D74F / 0x1D74F)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // MOV AL,0xf0 (1000_D753 / 0x1D753)
    AL = 0xF0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D759_1D759:
    // RET  (1000_D759 / 0x1D759)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D75A_01D75A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D75A_1D75A:
    // MOV SI,0x1c36 (1000_D75A / 0x1D75A)
    SI = 0x1C36;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D763_1D763:
    // MOV SI,0x1c0c (1000_D763 / 0x1D763)
    SI = 0x1C0C;
    State.IncCycles();
    // MOV AX,0x40 (1000_D766 / 0x1D766)
    AX = 0x40;
    State.IncCycles();
    // MOV word ptr [SI + 0xa],AX (1000_D769 / 0x1D769)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0x18],AX (1000_D76C / 0x1D76C)
    UInt16[DS, (ushort)(SI + 0x18)] = AX;
    State.IncCycles();
    // MOV CX,0x2 (1000_D76F / 0x1D76F)
    CX = 0x2;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D775_1D775:
    // MOV SI,0x1c0c (1000_D775 / 0x1D775)
    SI = 0x1C0C;
    State.IncCycles();
    // MOV AL,[0x1152] (1000_D778 / 0x1D778)
    AL = UInt8[DS, 0x1152];
    State.IncCycles();
    // CBW  (1000_D77B / 0x1D77B)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD AX,0x41 (1000_D77C / 0x1D77C)
    // AX += 0x41;
    AX = Alu.Add16(AX, 0x41);
    State.IncCycles();
    // MOV word ptr [SI + 0xa],AX (1000_D77F / 0x1D77F)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    State.IncCycles();
    // MOV AL,[0x1153] (1000_D782 / 0x1D782)
    AL = UInt8[DS, 0x1153];
    State.IncCycles();
    // CBW  (1000_D785 / 0x1D785)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD AX,0x41 (1000_D786 / 0x1D786)
    // AX += 0x41;
    AX = Alu.Add16(AX, 0x41);
    State.IncCycles();
    // MOV word ptr [SI + 0x18],AX (1000_D789 / 0x1D789)
    UInt16[DS, (ushort)(SI + 0x18)] = AX;
    State.IncCycles();
    // MOV CX,0x2 (1000_D78C / 0x1D78C)
    CX = 0x2;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D795_1D795:
    // PUSH DS (1000_D795 / 0x1D795)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_D796 / 0x1D796)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x1aee (1000_D797 / 0x1D797)
    DI = 0x1AEE;
    State.IncCycles();
    // MOV CX,0x4 (1000_D79A / 0x1D79A)
    CX = 0x4;
    State.IncCycles();
    label_1000_D79D_1D79D:
    // MOVSW ES:DI,SI (1000_D79D / 0x1D79D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_D79E / 0x1D79E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0xa (1000_D79F / 0x1D79F)
    // DI += 0xA;
    DI = Alu.Add16(DI, 0xA);
    State.IncCycles();
    // LOOP 0x1000:d79d (1000_D7A2 / 0x1D7A2)
    if(--CX != 0) {
      goto label_1000_D79D_1D79D;
    }
    State.IncCycles();
    // MOV SI,0x1ae6 (1000_D7A4 / 0x1D7A4)
    SI = 0x1AE6;
    State.IncCycles();
    // MOV CX,0x3 (1000_D7A7 / 0x1D7A7)
    CX = 0x3;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D7AD_1D7AD:
    // MOV SI,0x1c56 (1000_D7AD / 0x1D7AD)
    SI = 0x1C56;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D7B2_1D7B2:
    // MOV SI,0x1c46 (1000_D7B2 / 0x1D7B2)
    SI = 0x1C46;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D7B7_1D7B7:
    // MOV AX,[0xce7a] (1000_D7B7 / 0x1D7B7)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SHL AX,1 (1000_D7BA / 0x1D7BA)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_D7BC / 0x1D7BC)
    AX <<= 0x1;
    State.IncCycles();
    // CMP AH,byte ptr [0xdcf1] (1000_D7BE / 0x1D7BE)
    Alu.Sub8(AH, UInt8[DS, 0xDCF1]);
    State.IncCycles();
    // JZ 0x1000:d814 (1000_D7C2 / 0x1D7C2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D814 / 0x1D814)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0xdcf1],AH (1000_D7C4 / 0x1D7C4)
    UInt8[DS, 0xDCF1] = AH;
    State.IncCycles();
    // MOV AX,[0x2222] (1000_D7C8 / 0x1D7C8)
    AX = UInt16[DS, 0x2222];
    State.IncCycles();
    // OR AX,AX (1000_D7CB / 0x1D7CB)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:d814 (1000_D7CD / 0x1D7CD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_D814 / 0x1D814)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,word ptr [0x1152] (1000_D7CF / 0x1D7CF)
    BX = UInt16[DS, 0x1152];
    State.IncCycles();
    // PUSH BX (1000_D7D3 / 0x1D7D3)
    Stack.Push(BX);
    State.IncCycles();
    // OR AL,AL (1000_D7D4 / 0x1D7D4)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:d7e0 (1000_D7D6 / 0x1D7D6)
    if(ZeroFlag) {
      goto label_1000_D7E0_1D7E0;
    }
    State.IncCycles();
    // DEC AL (1000_D7D8 / 0x1D7D8)
    AL--;
    State.IncCycles();
    // TEST AL,0x1 (1000_D7DA / 0x1D7DA)
    Alu.And8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:d7e0 (1000_D7DC / 0x1D7DC)
    if(ZeroFlag) {
      goto label_1000_D7E0_1D7E0;
    }
    State.IncCycles();
    // MOV BL,0xff (1000_D7DE / 0x1D7DE)
    BL = 0xFF;
    State.IncCycles();
    label_1000_D7E0_1D7E0:
    // OR AH,AH (1000_D7E0 / 0x1D7E0)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x1000:d7ed (1000_D7E2 / 0x1D7E2)
    if(ZeroFlag) {
      goto label_1000_D7ED_1D7ED;
    }
    State.IncCycles();
    // DEC AH (1000_D7E4 / 0x1D7E4)
    AH--;
    State.IncCycles();
    // TEST AH,0x1 (1000_D7E6 / 0x1D7E6)
    Alu.And8(AH, 0x1);
    State.IncCycles();
    // JZ 0x1000:d7ed (1000_D7E9 / 0x1D7E9)
    if(ZeroFlag) {
      goto label_1000_D7ED_1D7ED;
    }
    State.IncCycles();
    // MOV BH,0xff (1000_D7EB / 0x1D7EB)
    BH = 0xFF;
    State.IncCycles();
    label_1000_D7ED_1D7ED:
    // MOV [0x2222],AX (1000_D7ED / 0x1D7ED)
    UInt16[DS, 0x2222] = AX;
    State.IncCycles();
    // MOV word ptr [0x1152],BX (1000_D7F0 / 0x1D7F0)
    UInt16[DS, 0x1152] = BX;
    State.IncCycles();
    // CMP word ptr [0x1afe],0x0 (1000_D7F4 / 0x1D7F4)
    Alu.Sub16(UInt16[DS, 0x1AFE], 0x0);
    State.IncCycles();
    // JNZ 0x1000:d810 (1000_D7FA / 0x1D7FA)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D809_01D809, 0x1D810 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH word ptr [0x2784] (1000_D7FC / 0x1D7FC)
    Stack.Push(UInt16[DS, 0x2784]);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D803_1D803:
    // CALL 0x1000:dbb2 (1000_D803 / 0x1D803)
    NearCall(cs1, 0xD806, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D809_1D809:
    // CALL 0x1000:dbec (1000_D809 / 0x1D809)
    NearCall(cs1, 0xD80C, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    State.IncCycles();
    label_1000_D80C_1D80C:
    // POP AX (1000_D80C / 0x1D80C)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c13e (1000_D80D / 0x1D80D)
    NearCall(cs1, 0xD810, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_D810_1D810:
    // POP word ptr [0x1152] (1000_D810 / 0x1D810)
    UInt16[DS, 0x1152] = Stack.Pop();
    State.IncCycles();
    label_1000_D814_1D814:
    // RET  (1000_D814 / 0x1D814)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D815_01D815(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D815_1D815:
    // MOV AX,[0xce7a] (1000_D815 / 0x1D815)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc68],AX (1000_D818 / 0x1D818)
    UInt16[DS, 0xDC68] = AX;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D820_1D820:
    // CMP byte ptr [0xcee8],0x2f (1000_D820 / 0x1D820)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x2F);
    State.IncCycles();
    // JNZ 0x1000:d831 (1000_D825 / 0x1D825)
    if(!ZeroFlag) {
      goto label_1000_D831_1D831;
    }
    State.IncCycles();
    // CMP byte ptr [0xce9e],0xff (1000_D827 / 0x1D827)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:d831 (1000_D82C / 0x1D82C)
    if(!ZeroFlag) {
      goto label_1000_D831_1D831;
    }
    State.IncCycles();
    // CALL 0x1000:b270 (1000_D82E / 0x1D82E)
    NearCall(cs1, 0xD831, not_observed_1000_B270_01B270);
    State.IncCycles();
    label_1000_D831_1D831:
    // CMP byte ptr [0x46d9],0x0 (1000_D831 / 0x1D831)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:d83e (1000_D836 / 0x1D836)
    if(!ZeroFlag) {
      goto label_1000_D83E_1D83E;
    }
    State.IncCycles();
    // CALL 0x1000:d7b7 (1000_D838 / 0x1D838)
    NearCall(cs1, 0xD83B, spice86_generated_label_call_target_1000_D7B7_01D7B7);
    State.IncCycles();
    label_1000_D83B_1D83B:
    // CALL 0x1000:1b0d (1000_D83B / 0x1D83B)
    NearCall(cs1, 0xD83E, spice86_generated_label_call_target_1000_1B0D_011B0D);
    State.IncCycles();
    label_1000_D83E_1D83E:
    // CALL 0x1000:d9d2 (1000_D83E / 0x1D83E)
    NearCall(cs1, 0xD841, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    State.IncCycles();
    label_1000_D841_1D841:
    // CMP byte ptr [0x46d9],0x0 (1000_D841 / 0x1D841)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    State.IncCycles();
    // JZ 0x1000:d84b (1000_D846 / 0x1D846)
    if(ZeroFlag) {
      goto label_1000_D84B_1D84B;
    }
    State.IncCycles();
    // CALL 0x1000:0d8e (1000_D848 / 0x1D848)
    NearCall(cs1, 0xD84B, not_observed_1000_0D8E_010D8E);
    State.IncCycles();
    label_1000_D84B_1D84B:
    // CALL 0x1000:e3cc (1000_D84B / 0x1D84B)
    NearCall(cs1, 0xD84E, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    State.IncCycles();
    label_1000_D84E_1D84E:
    // MOV [0x0],AX (1000_D84E / 0x1D84E)
    UInt16[DS, 0x0] = AX;
    State.IncCycles();
    // CALL 0x1000:4f0c (1000_D851 / 0x1D851)
    NearCall(cs1, 0xD854, spice86_generated_label_call_target_1000_4F0C_014F0C);
    State.IncCycles();
    label_1000_D854_1D854:
    // CMP byte ptr [0xdc4b],0x0 (1000_D854 / 0x1D854)
    Alu.Sub8(UInt8[DS, 0xDC4B], 0x0);
    State.IncCycles();
    // JZ 0x1000:d860 (1000_D859 / 0x1D859)
    if(ZeroFlag) {
      goto label_1000_D860_1D860;
    }
    State.IncCycles();
    // CALL 0x1000:d962 (1000_D85B / 0x1D85B)
    NearCall(cs1, 0xD85E, not_observed_1000_D962_01D962);
    State.IncCycles();
    // JMP 0x1000:d866 (1000_D85E / 0x1D85E)
    goto label_1000_D866_1D866;
    State.IncCycles();
    label_1000_D860_1D860:
    // CALL 0x1000:df1e (1000_D860 / 0x1D860)
    NearCall(cs1, 0xD863, spice86_generated_label_call_target_1000_DF1E_01DF1E);
    State.IncCycles();
    label_1000_D863_1D863:
    // CALL 0x1000:db4c (1000_D863 / 0x1D863)
    NearCall(cs1, 0xD866, spice86_generated_label_call_target_1000_DB4C_01DB4C);
    State.IncCycles();
    label_1000_D866_1D866:
    // CALL 0x1000:dc20 (1000_D866 / 0x1D866)
    NearCall(cs1, 0xD869, spice86_generated_label_call_target_1000_DC20_01DC20);
    State.IncCycles();
    label_1000_D869_1D869:
    // MOV DI,DX (1000_D869 / 0x1D869)
    DI = DX;
    State.IncCycles();
    // XCHG word ptr [0xdc62],DI (1000_D86B / 0x1D86B)
    ushort tmp_1000_D86B = UInt16[DS, 0xDC62];
    UInt16[DS, 0xDC62] = DI;
    DI = tmp_1000_D86B;
    State.IncCycles();
    // MOV CX,BX (1000_D86F / 0x1D86F)
    CX = BX;
    State.IncCycles();
    // XCHG word ptr [0xdc64],CX (1000_D871 / 0x1D871)
    ushort tmp_1000_D871 = UInt16[DS, 0xDC64];
    UInt16[DS, 0xDC64] = CX;
    CX = tmp_1000_D871;
    State.IncCycles();
    // SUB DI,DX (1000_D875 / 0x1D875)
    DI -= DX;
    State.IncCycles();
    // SUB CX,BX (1000_D877 / 0x1D877)
    CX -= BX;
    State.IncCycles();
    // NEG DI (1000_D879 / 0x1D879)
    DI = Alu.Sub16(0, DI);
    State.IncCycles();
    // NEG CX (1000_D87B / 0x1D87B)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // MOV SI,word ptr [0x2570] (1000_D87D / 0x1D87D)
    SI = UInt16[DS, 0x2570];
    State.IncCycles();
    // AND AX,0xf (1000_D881 / 0x1D881)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // JNZ 0x1000:d893 (1000_D884 / 0x1D884)
    if(!ZeroFlag) {
      goto label_1000_D893_1D893;
    }
    State.IncCycles();
    // CALL 0x1000:d50f (1000_D886 / 0x1D886)
    NearCall(cs1, 0xD889, spice86_generated_label_call_target_1000_D50F_01D50F);
    State.IncCycles();
    label_1000_D889_1D889:
    // MOV AX,CX (1000_D889 / 0x1D889)
    AX = CX;
    State.IncCycles();
    // OR AX,DI (1000_D88B / 0x1D88B)
    // AX |= DI;
    AX = Alu.Or16(AX, DI);
    State.IncCycles();
    // JZ 0x1000:d88f (1000_D88D / 0x1D88D)
    if(ZeroFlag) {
      goto label_1000_D88F_1D88F;
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D891_1D891:
    // JMP 0x1000:d820 (1000_D891 / 0x1D891)
    goto label_1000_D820_1D820;
    State.IncCycles();
    label_1000_D893_1D893:
    // MOV BP,word ptr [0xce7a] (1000_D893 / 0x1D893)
    BP = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV word ptr [0xdc5a],BP (1000_D897 / 0x1D897)
    UInt16[DS, 0xDC5A] = BP;
    State.IncCycles();
    // CMP byte ptr [0x4774],0x0 (1000_D89B / 0x1D89B)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JZ 0x1000:d8b1 (1000_D8A0 / 0x1D8A0)
    if(ZeroFlag) {
      goto label_1000_D8B1_1D8B1;
    }
    State.IncCycles();
    // AND AL,0x5 (1000_D8A2 / 0x1D8A2)
    AL &= 0x5;
    State.IncCycles();
    // CMP AL,0x5 (1000_D8A4 / 0x1D8A4)
    Alu.Sub8(AL, 0x5);
    State.IncCycles();
    // JNZ 0x1000:d8d7 (1000_D8A6 / 0x1D8A6)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_D8A8 / 0x1D8A8)
    NearCall(cs1, 0xD8AB, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:1707 (1000_D8AB / 0x1D8AB)
    NearCall(cs1, 0xD8AE, not_observed_1000_1707_011707);
    State.IncCycles();
    // JMP 0x1000:d820 (1000_D8AE / 0x1D8AE)
    goto label_1000_D820_1D820;
    State.IncCycles();
    label_1000_D8B1_1D8B1:
    // TEST AL,0x5 (1000_D8B1 / 0x1D8B1)
    Alu.And8(AL, 0x5);
    State.IncCycles();
    // JNZ 0x1000:d8ba (1000_D8B3 / 0x1D8B3)
    if(!ZeroFlag) {
      goto label_1000_D8BA_1D8BA;
    }
    State.IncCycles();
    // ADD SI,0x2 (1000_D8B5 / 0x1D8B5)
    SI += 0x2;
    State.IncCycles();
    // SHR AX,1 (1000_D8B8 / 0x1D8B8)
    AX >>= 0x1;
    State.IncCycles();
    label_1000_D8BA_1D8BA:
    // AND AL,0x5 (1000_D8BA / 0x1D8BA)
    AL &= 0x5;
    State.IncCycles();
    // DEC AL (1000_D8BC / 0x1D8BC)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x1000:d8f4 (1000_D8BE / 0x1D8BE)
    if(!ZeroFlag) {
      goto label_1000_D8F4_1D8F4;
    }
    State.IncCycles();
    // MOV BP,word ptr [0xdc5c] (1000_D8C0 / 0x1D8C0)
    BP = UInt16[DS, 0xDC5C];
    State.IncCycles();
    // OR BP,BP (1000_D8C4 / 0x1D8C4)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JNZ 0x1000:d8da (1000_D8C6 / 0x1D8C6)
    if(!ZeroFlag) {
      goto label_1000_D8DA_1D8DA;
    }
    State.IncCycles();
    // MOV AX,CX (1000_D8C8 / 0x1D8C8)
    AX = CX;
    State.IncCycles();
    // OR AX,DI (1000_D8CA / 0x1D8CA)
    // AX |= DI;
    AX = Alu.Or16(AX, DI);
    State.IncCycles();
    // JZ 0x1000:d8d7 (1000_D8CC / 0x1D8CC)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_D8CE / 0x1D8CE)
    NearCall(cs1, 0xD8D1, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_D8D1_1D8D1:
    // MOV AL,[0xdc35] (1000_D8D1 / 0x1D8D1)
    AL = UInt8[DS, 0xDC35];
    State.IncCycles();
    // CALL word ptr [SI + 0xa] (1000_D8D4 / 0x1D8D4)
    // Indirect call to word ptr [SI + 0xa], generating possible targets from emulator records
    uint targetAddress_1000_D8D4 = (uint)(UInt16[DS, (ushort)(SI + 0xA)]);
    switch(targetAddress_1000_D8D4) {
      case 0xD917 : NearCall(cs1, 0xD8D7, spice86_generated_label_call_target_1000_D917_01D917); break;
      case 0x59C1 : NearCall(cs1, 0xD8D7, spice86_generated_label_call_target_1000_59C1_0159C1); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D8D4));
        break;
    }
    State.IncCycles();
    label_1000_D8D7_1D8D7:
    // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
    goto label_1000_D820_1D820;
    State.IncCycles();
    label_1000_D8DA_1D8DA:
    // MOV AX,[0xce7a] (1000_D8DA / 0x1D8DA)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,word ptr [0xdc5e] (1000_D8DD / 0x1D8DD)
    AX -= UInt16[DS, 0xDC5E];
    State.IncCycles();
    // CMP AX,0x32 (1000_D8E1 / 0x1D8E1)
    Alu.Sub16(AX, 0x32);
    State.IncCycles();
    // JC 0x1000:d8d7 (1000_D8E4 / 0x1D8E4)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    State.IncCycles();
    // CALL 0x1000:d6b7 (1000_D8E6 / 0x1D8E6)
    NearCall(cs1, 0xD8E9, spice86_generated_label_call_target_1000_D6B7_01D6B7);
    State.IncCycles();
    label_1000_D8E9_1D8E9:
    // JNC 0x1000:d8d7 (1000_D8E9 / 0x1D8E9)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    State.IncCycles();
    // CMP DI,BP (1000_D8EB / 0x1D8EB)
    Alu.Sub16(DI, BP);
    State.IncCycles();
    // JNZ 0x1000:d8d7 (1000_D8ED / 0x1D8ED)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d820 (1000_D8D7 / 0x1D8D7)
      goto label_1000_D820_1D820;
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_D8EF / 0x1D8EF)
    NearCall(cs1, 0xD8F2, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_D8F2_1D8F2:
    // JMP 0x1000:d92b (1000_D8F2 / 0x1D8F2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D918_01D918, 0x1D92B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_D8F4_1D8F4:
    // CALL 0x1000:dbb2 (1000_D8F4 / 0x1D8F4)
    NearCall(cs1, 0xD8F7, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_D8F7_1D8F7:
    // CALL 0x1000:e26f (1000_D8F7 / 0x1D8F7)
    NearCall(cs1, 0xD8FA, spice86_generated_label_call_target_1000_E26F_01E26F);
    State.IncCycles();
    label_1000_D8FA_1D8FA:
    // SUB AL,0x3 (1000_D8FA / 0x1D8FA)
    // AL -= 0x3;
    AL = Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JZ 0x1000:d944 (1000_D8FC / 0x1D8FC)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D918_01D918, 0x1D944 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP SI,word ptr [0x2570] (1000_D8FE / 0x1D8FE)
    Alu.Sub16(SI, UInt16[DS, 0x2570]);
    State.IncCycles();
    // JNZ 0x1000:d90e (1000_D902 / 0x1D902)
    if(!ZeroFlag) {
      goto label_1000_D90E_1D90E;
    }
    State.IncCycles();
    // CALL 0x1000:d6b7 (1000_D904 / 0x1D904)
    NearCall(cs1, 0xD907, spice86_generated_label_call_target_1000_D6B7_01D6B7);
    State.IncCycles();
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
    State.IncCycles();
    // PUSH SI (1000_D909 / 0x1D909)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:9215 (1000_D90A / 0x1D90A)
    NearCall(cs1, 0xD90D, spice86_generated_label_call_target_1000_9215_019215);
    State.IncCycles();
    label_1000_D90D_1D90D:
    // POP SI (1000_D90D / 0x1D90D)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_D90E_1D90E:
    // MOV AL,[0xdc35] (1000_D90E / 0x1D90E)
    AL = UInt8[DS, 0xDC35];
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D914_1D914:
    // JMP 0x1000:d820 (1000_D914 / 0x1D914)
    goto label_1000_D820_1D820;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D917_01D917(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D918_1D918:
    // MOV word ptr [0xdc60],DI (1000_D918 / 0x1D918)
    UInt16[DS, 0xDC60] = DI;
    State.IncCycles();
    // CALL 0x1000:d65a (1000_D91C / 0x1D91C)
    NearCall(cs1, 0xD91F, spice86_generated_label_call_target_1000_D65A_01D65A);
    State.IncCycles();
    label_1000_D91F_1D91F:
    // TEST byte ptr [DI + 0x9],0x40 (1000_D91F / 0x1D91F)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x9)], 0x40);
    State.IncCycles();
    // JZ 0x1000:d92b (1000_D923 / 0x1D923)
    if(ZeroFlag) {
      goto label_1000_D92B_1D92B;
    }
    State.IncCycles();
    // MOV word ptr [0xdc5c],DI (1000_D925 / 0x1D925)
    UInt16[DS, 0xDC5C] = DI;
    State.IncCycles();
    // JMP 0x1000:d935 (1000_D929 / 0x1D929)
    goto label_1000_D935_1D935;
    State.IncCycles();
    label_1000_D92B_1D92B:
    // MOV byte ptr [0xce9d],0x0 (1000_D92B / 0x1D92B)
    UInt8[DS, 0xCE9D] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0xceba],0x0 (1000_D930 / 0x1D930)
    UInt8[DS, 0xCEBA] = 0x0;
    State.IncCycles();
    label_1000_D935_1D935:
    // MOV AX,[0xce7a] (1000_D935 / 0x1D935)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc5e],AX (1000_D938 / 0x1D938)
    UInt16[DS, 0xDC5E] = AX;
    State.IncCycles();
    // MOV AL,[0xdc35] (1000_D93B / 0x1D93B)
    AL = UInt8[DS, 0xDC35];
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D941_1D941:
    // JMP 0x1000:d820 (1000_D941 / 0x1D941)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D820_01D820, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_D944_1D944:
    // MOV DI,word ptr [0xdc5c] (1000_D944 / 0x1D944)
    DI = UInt16[DS, 0xDC5C];
    State.IncCycles();
    // MOV word ptr [0xdc5c],0x0 (1000_D948 / 0x1D948)
    UInt16[DS, 0xDC5C] = 0x0;
    State.IncCycles();
    // OR DI,DI (1000_D94E / 0x1D94E)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JNZ 0x1000:d92b (1000_D950 / 0x1D950)
    if(!ZeroFlag) {
      goto label_1000_D92B_1D92B;
    }
    State.IncCycles();
    // MOV AL,[0xdc35] (1000_D952 / 0x1D952)
    AL = UInt8[DS, 0xDC35];
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D95E_1D95E:
    // MOV [0x2570],AX (1000_D95E / 0x1D95E)
    UInt16[DS, 0x2570] = AX;
    State.IncCycles();
    // RET  (1000_D961 / 0x1D961)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_D962_01D962(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_D962_1D962:
    // MOV AX,[0xce7a] (1000_D962 / 0x1D962)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AL,byte ptr [0xdc4a] (1000_D965 / 0x1D965)
    AL -= UInt8[DS, 0xDC4A];
    State.IncCycles();
    // CMP AL,0x6 (1000_D969 / 0x1D969)
    Alu.Sub8(AL, 0x6);
    State.IncCycles();
    // JC 0x1000:d9cf (1000_D96B / 0x1D96B)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:db4c (1000_D9CF / 0x1D9CF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB4C_01DB4C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x2 (1000_D96D / 0x1D96D)
    CX = 0x2;
    State.IncCycles();
    // CMP AL,0xc (1000_D970 / 0x1D970)
    Alu.Sub8(AL, 0xC);
    State.IncCycles();
    // JC 0x1000:d97a (1000_D972 / 0x1D972)
    if(CarryFlag) {
      goto label_1000_D97A_1D97A;
    }
    State.IncCycles();
    // DEC CX (1000_D974 / 0x1D974)
    CX--;
    State.IncCycles();
    // CMP AL,0x18 (1000_D975 / 0x1D975)
    Alu.Sub8(AL, 0x18);
    State.IncCycles();
    // JC 0x1000:d97a (1000_D977 / 0x1D977)
    if(CarryFlag) {
      goto label_1000_D97A_1D97A;
    }
    State.IncCycles();
    // DEC CX (1000_D979 / 0x1D979)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    label_1000_D97A_1D97A:
    // MOV AX,[0xce7a] (1000_D97A / 0x1D97A)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc4a],AL (1000_D97D / 0x1D97D)
    UInt8[DS, 0xDC4A] = AL;
    State.IncCycles();
    // DEC byte ptr [0xdc4b] (1000_D980 / 0x1D980)
    UInt8[DS, 0xDC4B] = Alu.Dec8(UInt8[DS, 0xDC4B]);
    State.IncCycles();
    // MOV DX,word ptr [0xdc4c] (1000_D984 / 0x1D984)
    DX = UInt16[DS, 0xDC4C];
    State.IncCycles();
    // MOV BX,word ptr [0xdc4e] (1000_D988 / 0x1D988)
    BX = UInt16[DS, 0xDC4E];
    State.IncCycles();
    // SUB DX,word ptr [0xdc36] (1000_D98C / 0x1D98C)
    // DX -= UInt16[DS, 0xDC36];
    DX = Alu.Sub16(DX, UInt16[DS, 0xDC36]);
    State.IncCycles();
    // JZ 0x1000:d9a3 (1000_D990 / 0x1D990)
    if(ZeroFlag) {
      goto label_1000_D9A3_1D9A3;
    }
    State.IncCycles();
    // JCXZ 0x1000:d99b (1000_D992 / 0x1D992)
    if(CX == 0) {
      goto label_1000_D99B_1D99B;
    }
    State.IncCycles();
    // SAR DX,CL (1000_D994 / 0x1D994)
    DX = Alu.Sar16(DX, CL);
    State.IncCycles();
    // OR DL,0x1 (1000_D996 / 0x1D996)
    // DL |= 0x1;
    DL = Alu.Or8(DL, 0x1);
    State.IncCycles();
    // JMP 0x1000:d9a3 (1000_D999 / 0x1D999)
    goto label_1000_D9A3_1D9A3;
    State.IncCycles();
    label_1000_D99B_1D99B:
    // MOV AX,DX (1000_D99B / 0x1D99B)
    AX = DX;
    State.IncCycles();
    // SAR AX,1 (1000_D99D / 0x1D99D)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // SAR AX,1 (1000_D99F / 0x1D99F)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // SUB DX,AX (1000_D9A1 / 0x1D9A1)
    DX -= AX;
    State.IncCycles();
    label_1000_D9A3_1D9A3:
    // SUB BX,word ptr [0xdc38] (1000_D9A3 / 0x1D9A3)
    // BX -= UInt16[DS, 0xDC38];
    BX = Alu.Sub16(BX, UInt16[DS, 0xDC38]);
    State.IncCycles();
    // JZ 0x1000:d9ba (1000_D9A7 / 0x1D9A7)
    if(ZeroFlag) {
      goto label_1000_D9BA_1D9BA;
    }
    State.IncCycles();
    // JCXZ 0x1000:d9b2 (1000_D9A9 / 0x1D9A9)
    if(CX == 0) {
      goto label_1000_D9B2_1D9B2;
    }
    State.IncCycles();
    // SAR BX,CL (1000_D9AB / 0x1D9AB)
    BX = Alu.Sar16(BX, CL);
    State.IncCycles();
    // OR BL,0x1 (1000_D9AD / 0x1D9AD)
    // BL |= 0x1;
    BL = Alu.Or8(BL, 0x1);
    State.IncCycles();
    // JMP 0x1000:d9ba (1000_D9B0 / 0x1D9B0)
    goto label_1000_D9BA_1D9BA;
    State.IncCycles();
    label_1000_D9B2_1D9B2:
    // MOV AX,BX (1000_D9B2 / 0x1D9B2)
    AX = BX;
    State.IncCycles();
    // SAR AX,1 (1000_D9B4 / 0x1D9B4)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // SAR AX,1 (1000_D9B6 / 0x1D9B6)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // SUB BX,AX (1000_D9B8 / 0x1D9B8)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    label_1000_D9BA_1D9BA:
    // MOV AX,BX (1000_D9BA / 0x1D9BA)
    AX = BX;
    State.IncCycles();
    // OR AX,DX (1000_D9BC / 0x1D9BC)
    // AX |= DX;
    AX = Alu.Or16(AX, DX);
    State.IncCycles();
    // JNZ 0x1000:d9c7 (1000_D9BE / 0x1D9BE)
    if(!ZeroFlag) {
      goto label_1000_D9C7_1D9C7;
    }
    State.IncCycles();
    // MOV byte ptr [0xdc4b],0x0 (1000_D9C0 / 0x1D9C0)
    UInt8[DS, 0xDC4B] = 0x0;
    State.IncCycles();
    // JMP 0x1000:d9cf (1000_D9C5 / 0x1D9C5)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x1000:db4c (1000_D9CF / 0x1D9CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB4C_01DB4C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_D9C7_1D9C7:
    // CALL 0x1000:daaf (1000_D9C7 / 0x1D9C7)
    NearCall(cs1, 0xD9CA, not_observed_1000_DAAF_01DAAF);
    State.IncCycles();
    // MOV byte ptr [0xdc34],0x0 (1000_D9CA / 0x1D9CA)
    UInt8[DS, 0xDC34] = 0x0;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D9D5_1D9D5:
    // MOV AX,[0xce7a] (1000_D9D5 / 0x1D9D5)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV CX,AX (1000_D9D8 / 0x1D9D8)
    CX = AX;
    State.IncCycles();
    // MOV BX,AX (1000_D9DA / 0x1D9DA)
    BX = AX;
    State.IncCycles();
    // MOV SI,0xdc68 (1000_D9DC / 0x1D9DC)
    SI = 0xDC68;
    State.IncCycles();
    // XCHG word ptr [SI],CX (1000_D9DF / 0x1D9DF)
    ushort tmp_1000_D9DF = UInt16[DS, SI];
    UInt16[DS, SI] = CX;
    CX = tmp_1000_D9DF;
    State.IncCycles();
    // SUB BX,CX (1000_D9E1 / 0x1D9E1)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    State.IncCycles();
    // MOV CX,word ptr [SI + 0x2] (1000_D9E3 / 0x1D9E3)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // JCXZ 0x1000:da03 (1000_D9E6 / 0x1D9E6)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DA03 / 0x1DA03)
      return NearRet();
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_D9EB_1D9EB:
    // LODSW SI (1000_D9EB / 0x1D9EB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_D9EC / 0x1D9EC)
    BP = AX;
    State.IncCycles();
    // MOV AX,BX (1000_D9EE / 0x1D9EE)
    AX = BX;
    State.IncCycles();
    // ADD AX,word ptr [SI] (1000_D9F0 / 0x1D9F0)
    AX += UInt16[DS, SI];
    State.IncCycles();
    // CMP AX,BP (1000_D9F2 / 0x1D9F2)
    Alu.Sub16(AX, BP);
    State.IncCycles();
    // JNC 0x1000:da04 (1000_D9F4 / 0x1D9F4)
    if(!CarryFlag) {
      goto label_1000_DA04_1DA04;
    }
    State.IncCycles();
    // MOV word ptr [SI],AX (1000_D9F6 / 0x1D9F6)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    // ADD SI,0x4 (1000_D9F8 / 0x1D9F8)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:d9eb (1000_D9FB / 0x1D9FB)
    if(--CX != 0) {
      goto label_1000_D9EB_1D9EB;
    }
    State.IncCycles();
    label_1000_D9FD_1D9FD:
    // MOV word ptr [0xdc66],0x0 (1000_D9FD / 0x1D9FD)
    UInt16[DS, 0xDC66] = 0x0;
    State.IncCycles();
    label_1000_DA03_1DA03:
    // RET  (1000_DA03 / 0x1DA03)
    return NearRet();
    State.IncCycles();
    label_1000_DA04_1DA04:
    // OR BP,BP (1000_DA04 / 0x1DA04)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JZ 0x1000:da0e (1000_DA06 / 0x1DA06)
    if(ZeroFlag) {
      goto label_1000_DA0E_1DA0E;
    }
    State.IncCycles();
    // XOR DX,DX (1000_DA08 / 0x1DA08)
    DX = 0;
    State.IncCycles();
    // DIV BP (1000_DA0A / 0x1DA0A)
    Cpu.Div16(BP);
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_DA0C / 0x1DA0C)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    label_1000_DA0E_1DA0E:
    // SUB SI,0x2 (1000_DA0E / 0x1DA0E)
    // SI -= 0x2;
    SI = Alu.Sub16(SI, 0x2);
    State.IncCycles();
    // PUSH BX (1000_DA11 / 0x1DA11)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_DA12 / 0x1DA12)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_DA13 / 0x1DA13)
    Stack.Push(SI);
    State.IncCycles();
    // MOV word ptr [0xdc66],SP (1000_DA14 / 0x1DA14)
    UInt16[DS, 0xDC66] = SP;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_DA1B_1DA1B:
    // POP SI (1000_DA1B / 0x1DA1B)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_DA1C / 0x1DA1C)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_DA1D / 0x1DA1D)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD SI,0x6 (1000_DA1E / 0x1DA1E)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    State.IncCycles();
    // LOOP 0x1000:d9eb (1000_DA21 / 0x1DA21)
    if(--CX != 0) {
      goto label_1000_D9EB_1D9EB;
    }
    State.IncCycles();
    // JMP 0x1000:d9fd (1000_DA23 / 0x1DA23)
    goto label_1000_D9FD_1D9FD;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DA25_01DA25(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DA25_1DA25:
    // PUSH DS (1000_DA25 / 0x1DA25)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_DA26 / 0x1DA26)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0xdc6a (1000_DA27 / 0x1DA27)
    DI = 0xDC6A;
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_DA2A / 0x1DA2A)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // INC AX (1000_DA2C / 0x1DA2C)
    AX++;
    State.IncCycles();
    // CMP AX,0x14 (1000_DA2D / 0x1DA2D)
    Alu.Sub16(AX, 0x14);
    State.IncCycles();
    // JA 0x1000:da52 (1000_DA30 / 0x1DA30)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DA52 / 0x1DA52)
      return NearRet();
    }
    State.IncCycles();
    // STOSW ES:DI (1000_DA32 / 0x1DA32)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // DEC AX (1000_DA33 / 0x1DA33)
    AX--;
    State.IncCycles();
    // ADD AX,AX (1000_DA34 / 0x1DA34)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    // MOV BX,AX (1000_DA36 / 0x1DA36)
    BX = AX;
    State.IncCycles();
    // ADD AX,AX (1000_DA38 / 0x1DA38)
    AX += AX;
    State.IncCycles();
    // ADD AX,BX (1000_DA3A / 0x1DA3A)
    AX += BX;
    State.IncCycles();
    // ADD DI,AX (1000_DA3C / 0x1DA3C)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV AX,BP (1000_DA3E / 0x1DA3E)
    AX = BP;
    State.IncCycles();
    // STOSW ES:DI (1000_DA40 / 0x1DA40)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // XOR AX,AX (1000_DA41 / 0x1DA41)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_DA43 / 0x1DA43)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,SI (1000_DA44 / 0x1DA44)
    AX = SI;
    State.IncCycles();
    // STOSW ES:DI (1000_DA46 / 0x1DA46)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV BP,word ptr [0xdc66] (1000_DA47 / 0x1DA47)
    BP = UInt16[DS, 0xDC66];
    State.IncCycles();
    // OR BP,BP (1000_DA4B / 0x1DA4B)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JZ 0x1000:da52 (1000_DA4D / 0x1DA4D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DA52 / 0x1DA52)
      return NearRet();
    }
    State.IncCycles();
    // INC word ptr [BP + 0x2] (1000_DA4F / 0x1DA4F)
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    label_1000_DA52_1DA52:
    // RET  (1000_DA52 / 0x1DA52)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DA53_01DA53(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DA53_1DA53:
    // MOV word ptr [0xdc6a],0x0 (1000_DA53 / 0x1DA53)
    UInt16[DS, 0xDC6A] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x46d7],0x0 (1000_DA59 / 0x1DA59)
    UInt8[DS, 0x46D7] = 0x0;
    State.IncCycles();
    // RET  (1000_DA5E / 0x1DA5E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DA5F_01DA5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DA5F_1DA5F:
    // MOV DI,0xdc6a (1000_DA5F / 0x1DA5F)
    DI = 0xDC6A;
    State.IncCycles();
    // MOV CX,word ptr [DI] (1000_DA62 / 0x1DA62)
    CX = UInt16[DS, DI];
    State.IncCycles();
    // JCXZ 0x1000:da72 (1000_DA64 / 0x1DA64)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DA72 / 0x1DA72)
      return NearRet();
    }
    State.IncCycles();
    // ADD DI,0x6 (1000_DA66 / 0x1DA66)
    DI += 0x6;
    State.IncCycles();
    label_1000_DA69_1DA69:
    // CMP word ptr [DI],SI (1000_DA69 / 0x1DA69)
    Alu.Sub16(UInt16[DS, DI], SI);
    State.IncCycles();
    // JZ 0x1000:da73 (1000_DA6B / 0x1DA6B)
    if(ZeroFlag) {
      goto label_1000_DA73_1DA73;
    }
    State.IncCycles();
    // ADD DI,0x6 (1000_DA6D / 0x1DA6D)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    State.IncCycles();
    // LOOP 0x1000:da69 (1000_DA70 / 0x1DA70)
    if(--CX != 0) {
      goto label_1000_DA69_1DA69;
    }
    State.IncCycles();
    label_1000_DA72_1DA72:
    // RET  (1000_DA72 / 0x1DA72)
    return NearRet();
    State.IncCycles();
    label_1000_DA73_1DA73:
    // SUB DI,0x4 (1000_DA73 / 0x1DA73)
    DI -= 0x4;
    State.IncCycles();
    // DEC word ptr [0xdc6a] (1000_DA76 / 0x1DA76)
    UInt16[DS, 0xDC6A] = Alu.Dec16(UInt16[DS, 0xDC6A]);
    State.IncCycles();
    // MOV BP,word ptr [0xdc66] (1000_DA7A / 0x1DA7A)
    BP = UInt16[DS, 0xDC66];
    State.IncCycles();
    // OR BP,BP (1000_DA7E / 0x1DA7E)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JZ 0x1000:da90 (1000_DA80 / 0x1DA80)
    if(ZeroFlag) {
      goto label_1000_DA90_1DA90;
    }
    State.IncCycles();
    // CMP DI,word ptr [BP + 0x0] (1000_DA82 / 0x1DA82)
    Alu.Sub16(DI, UInt16[SS, BP]);
    State.IncCycles();
    // JA 0x1000:da8d (1000_DA85 / 0x1DA85)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_DA8D_1DA8D;
    }
    State.IncCycles();
    // SUB word ptr [BP + 0x0],0x6 (1000_DA87 / 0x1DA87)
    // UInt16[SS, BP] -= 0x6;
    UInt16[SS, BP] = Alu.Sub16(UInt16[SS, BP], 0x6);
    State.IncCycles();
    // JMP 0x1000:da90 (1000_DA8B / 0x1DA8B)
    goto label_1000_DA90_1DA90;
    State.IncCycles();
    label_1000_DA8D_1DA8D:
    // DEC word ptr [BP + 0x2] (1000_DA8D / 0x1DA8D)
    UInt16[SS, (ushort)(BP + 0x2)]--;
    State.IncCycles();
    label_1000_DA90_1DA90:
    // DEC CX (1000_DA90 / 0x1DA90)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JZ 0x1000:da72 (1000_DA91 / 0x1DA91)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DA72 / 0x1DA72)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,CX (1000_DA93 / 0x1DA93)
    AX = CX;
    State.IncCycles();
    // ADD CX,CX (1000_DA95 / 0x1DA95)
    CX += CX;
    State.IncCycles();
    // ADD CX,AX (1000_DA97 / 0x1DA97)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    // MOV SI,DI (1000_DA99 / 0x1DA99)
    SI = DI;
    State.IncCycles();
    // ADD SI,0x6 (1000_DA9B / 0x1DA9B)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    State.IncCycles();
    // PUSH DS (1000_DA9E / 0x1DA9E)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_DA9F / 0x1DA9F)
    ES = Stack.Pop();
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_DAA0 / 0x1DAA0)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // RET  (1000_DAA2 / 0x1DAA2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DAA3_01DAA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DAA3_1DAA3:
    // MOV word ptr [0xdc58],0x0 (1000_DAA3 / 0x1DAA3)
    UInt16[DS, 0xDC58] = 0x0;
    State.IncCycles();
    // RET  (1000_DAA9 / 0x1DAA9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DAAA_01DAAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DAAA_1DAAA:
    // MOV word ptr [0xdc58],SI (1000_DAAA / 0x1DAAA)
    UInt16[DS, 0xDC58] = SI;
    State.IncCycles();
    // RET  (1000_DAAE / 0x1DAAE)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_DAAF_01DAAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DAAF_1DAAF:
    // MOV SI,0xdc3a (1000_DAAF / 0x1DAAF)
    SI = 0xDC3A;
    State.IncCycles();
    // MOV AX,[0xdc36] (1000_DAB2 / 0x1DAB2)
    AX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // ADD AX,DX (1000_DAB5 / 0x1DAB5)
    AX += DX;
    State.IncCycles();
    // CMP AX,word ptr [SI] (1000_DAB7 / 0x1DAB7)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JGE 0x1000:dabd (1000_DAB9 / 0x1DAB9)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DABD_1DABD;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_DABB / 0x1DABB)
    AX = UInt16[DS, SI];
    State.IncCycles();
    label_1000_DABD_1DABD:
    // ADD SI,0x2 (1000_DABD / 0x1DABD)
    SI += 0x2;
    State.IncCycles();
    // CMP AX,word ptr [SI] (1000_DAC0 / 0x1DAC0)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JLE 0x1000:dac6 (1000_DAC2 / 0x1DAC2)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_DAC6_1DAC6;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_DAC4 / 0x1DAC4)
    AX = UInt16[DS, SI];
    State.IncCycles();
    label_1000_DAC6_1DAC6:
    // MOV [0xdc36],AX (1000_DAC6 / 0x1DAC6)
    UInt16[DS, 0xDC36] = AX;
    State.IncCycles();
    // ADD SI,0x2 (1000_DAC9 / 0x1DAC9)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // MOV AX,[0xdc38] (1000_DACC / 0x1DACC)
    AX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // ADD AX,BX (1000_DACF / 0x1DACF)
    AX += BX;
    State.IncCycles();
    // CMP AX,word ptr [SI] (1000_DAD1 / 0x1DAD1)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JGE 0x1000:dad7 (1000_DAD3 / 0x1DAD3)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DAD7_1DAD7;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_DAD5 / 0x1DAD5)
    AX = UInt16[DS, SI];
    State.IncCycles();
    label_1000_DAD7_1DAD7:
    // ADD SI,0x2 (1000_DAD7 / 0x1DAD7)
    SI += 0x2;
    State.IncCycles();
    // CMP AX,word ptr [SI] (1000_DADA / 0x1DADA)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JLE 0x1000:dae0 (1000_DADC / 0x1DADC)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_DAE0_1DAE0;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_DADE / 0x1DADE)
    AX = UInt16[DS, SI];
    State.IncCycles();
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
    State.IncCycles();
    label_1000_DAE3_1DAE3:
    // TEST byte ptr [0x2942],0x40 (1000_DAE3 / 0x1DAE3)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    State.IncCycles();
    // JNZ 0x1000:db02 (1000_DAE8 / 0x1DAE8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DB02 / 0x1DB02)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0xdc36] (1000_DAEA / 0x1DAEA)
    AX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // MOV DX,word ptr [0xdc38] (1000_DAED / 0x1DAED)
    DX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // MOV CX,word ptr [0x2580] (1000_DAF1 / 0x1DAF1)
    CX = UInt16[DS, 0x2580];
    State.IncCycles();
    // SHL AX,CL (1000_DAF5 / 0x1DAF5)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    State.IncCycles();
    // MOV CL,CH (1000_DAF7 / 0x1DAF7)
    CL = CH;
    State.IncCycles();
    // SHL DX,CL (1000_DAF9 / 0x1DAF9)
    // DX <<= CL;
    DX = Alu.Shl16(DX, CL);
    State.IncCycles();
    // MOV CX,AX (1000_DAFB / 0x1DAFB)
    CX = AX;
    State.IncCycles();
    // MOV AX,0x4 (1000_DAFD / 0x1DAFD)
    AX = 0x4;
    State.IncCycles();
    // INT 0x33 (1000_DB00 / 0x1DB00)
    Interrupt(0x33);
    State.IncCycles();
    label_1000_DB02_1DB02:
    // RET  (1000_DB02 / 0x1DB02)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB03_01DB03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DB03_1DB03:
    // CALL 0x1000:dbb2 (1000_DB03 / 0x1DB03)
    NearCall(cs1, 0xDB06, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_DB06_1DB06:
    // MOV word ptr [0xdc36],DX (1000_DB06 / 0x1DB06)
    UInt16[DS, 0xDC36] = DX;
    State.IncCycles();
    // MOV word ptr [0xdc38],BX (1000_DB0A / 0x1DB0A)
    UInt16[DS, 0xDC38] = BX;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_DB14_1DB14:
    // MOV DI,0xdc3a (1000_DB14 / 0x1DB14)
    DI = 0xDC3A;
    State.IncCycles();
    // MOV word ptr [DI],CX (1000_DB17 / 0x1DB17)
    UInt16[DS, DI] = CX;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],DX (1000_DB19 / 0x1DB19)
    UInt16[DS, (ushort)(DI + 0x2)] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x4],AX (1000_DB1C / 0x1DB1C)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    State.IncCycles();
    // MOV word ptr [DI + 0x6],BX (1000_DB1F / 0x1DB1F)
    UInt16[DS, (ushort)(DI + 0x6)] = BX;
    State.IncCycles();
    // TEST byte ptr [0x2942],0x40 (1000_DB22 / 0x1DB22)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    State.IncCycles();
    // JNZ 0x1000:db43 (1000_DB27 / 0x1DB27)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DB43 / 0x1DB43)
      return NearRet();
    }
    State.IncCycles();
    // PUSH AX (1000_DB29 / 0x1DB29)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_DB2A / 0x1DB2A)
    Stack.Push(BX);
    State.IncCycles();
    // MOV AL,[0x2580] (1000_DB2B / 0x1DB2B)
    AL = UInt8[DS, 0x2580];
    State.IncCycles();
    // CALL 0x1000:db44 (1000_DB2E / 0x1DB2E)
    NearCall(cs1, 0xDB31, spice86_generated_label_call_target_1000_DB44_01DB44);
    State.IncCycles();
    label_1000_DB31_1DB31:
    // MOV AX,0x7 (1000_DB31 / 0x1DB31)
    AX = 0x7;
    State.IncCycles();
    // INT 0x33 (1000_DB34 / 0x1DB34)
    Interrupt(0x33);
    State.IncCycles();
    // POP DX (1000_DB36 / 0x1DB36)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_DB37 / 0x1DB37)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV AL,[0x2581] (1000_DB38 / 0x1DB38)
    AL = UInt8[DS, 0x2581];
    State.IncCycles();
    // CALL 0x1000:db44 (1000_DB3B / 0x1DB3B)
    NearCall(cs1, 0xDB3E, spice86_generated_label_call_target_1000_DB44_01DB44);
    State.IncCycles();
    label_1000_DB3E_1DB3E:
    // MOV AX,0x8 (1000_DB3E / 0x1DB3E)
    AX = 0x8;
    State.IncCycles();
    // INT 0x33 (1000_DB41 / 0x1DB41)
    Interrupt(0x33);
    State.IncCycles();
    label_1000_DB43_1DB43:
    // RET  (1000_DB43 / 0x1DB43)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB44_01DB44(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DB44_1DB44:
    // XCHG AX,CX (1000_DB44 / 0x1DB44)
    ushort tmp_1000_DB44 = AX;
    AX = CX;
    CX = tmp_1000_DB44;
    State.IncCycles();
    // SHL AX,CL (1000_DB45 / 0x1DB45)
    AX <<= CL;
    State.IncCycles();
    // SHL DX,CL (1000_DB47 / 0x1DB47)
    // DX <<= CL;
    DX = Alu.Shl16(DX, CL);
    State.IncCycles();
    // MOV CX,AX (1000_DB49 / 0x1DB49)
    CX = AX;
    State.IncCycles();
    // RET  (1000_DB4B / 0x1DB4B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB4C_01DB4C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DB4C_1DB4C:
    // MOV AX,[0xdc34] (1000_DB4C / 0x1DB4C)
    AX = UInt16[DS, 0xDC34];
    State.IncCycles();
    // AND AL,0x3 (1000_DB4F / 0x1DB4F)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    State.IncCycles();
    // MOV [0xdc35],AL (1000_DB51 / 0x1DB51)
    UInt8[DS, 0xDC35] = AL;
    State.IncCycles();
    // XOR AH,AL (1000_DB54 / 0x1DB54)
    AH ^= AL;
    State.IncCycles();
    // ADD AH,AH (1000_DB56 / 0x1DB56)
    AH += AH;
    State.IncCycles();
    // ADD AH,AH (1000_DB58 / 0x1DB58)
    // AH += AH;
    AH = Alu.Add8(AH, AH);
    State.IncCycles();
    // OR AL,AH (1000_DB5A / 0x1DB5A)
    AL |= AH;
    State.IncCycles();
    // XOR AH,AH (1000_DB5C / 0x1DB5C)
    AH = 0;
    State.IncCycles();
    // MOV DX,word ptr [0xdc36] (1000_DB5E / 0x1DB5E)
    DX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // MOV BX,word ptr [0xdc38] (1000_DB62 / 0x1DB62)
    BX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // RET  (1000_DB66 / 0x1DB66)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DB67_01DB67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DB67_1DB67:
    // CMP byte ptr [0xdc47],0x0 (1000_DB67 / 0x1DB67)
    Alu.Sub8(UInt8[DS, 0xDC47], 0x0);
    State.IncCycles();
    // JNS 0x1000:dbab (1000_DB6C / 0x1DB6C)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DBAB / 0x1DBAB)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0xdc47] (1000_DB6E / 0x1DB6E)
    UInt8[DS, 0xDC47] = Alu.Inc8(UInt8[DS, 0xDC47]);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_DB74_1DB74:
    // CMP byte ptr [0xdc46],0x0 (1000_DB74 / 0x1DB74)
    Alu.Sub8(UInt8[DS, 0xDC46], 0x0);
    State.IncCycles();
    // JS 0x1000:dbab (1000_DB79 / 0x1DB79)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DBAB / 0x1DBAB)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_DB7B / 0x1DB7B)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_DB7C / 0x1DB7C)
    Stack.Push(DX);
    State.IncCycles();
    // MOV BX,word ptr [0x2582] (1000_DB7D / 0x1DB7D)
    BX = UInt16[DS, 0x2582];
    State.IncCycles();
    // MOV DX,word ptr [0xdc42] (1000_DB81 / 0x1DB81)
    DX = UInt16[DS, 0xDC42];
    State.IncCycles();
    // SUB DX,word ptr [BX] (1000_DB85 / 0x1DB85)
    // DX -= UInt16[DS, BX];
    DX = Alu.Sub16(DX, UInt16[DS, BX]);
    State.IncCycles();
    // MOV BX,word ptr [BX + 0x2] (1000_DB87 / 0x1DB87)
    BX = UInt16[DS, (ushort)(BX + 0x2)];
    State.IncCycles();
    // NEG BX (1000_DB8A / 0x1DB8A)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // ADD BX,word ptr [0xdc44] (1000_DB8C / 0x1DB8C)
    BX += UInt16[DS, 0xDC44];
    State.IncCycles();
    // CMP DX,word ptr [SI + 0x4] (1000_DB90 / 0x1DB90)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JGE 0x1000:dba9 (1000_DB93 / 0x1DB93)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DBA9_1DBA9;
    }
    State.IncCycles();
    // CMP BX,word ptr [SI + 0x6] (1000_DB95 / 0x1DB95)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JGE 0x1000:dba9 (1000_DB98 / 0x1DB98)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DBA9_1DBA9;
    }
    State.IncCycles();
    // ADD DX,0x10 (1000_DB9A / 0x1DB9A)
    DX += 0x10;
    State.IncCycles();
    // CMP DX,word ptr [SI] (1000_DB9D / 0x1DB9D)
    Alu.Sub16(DX, UInt16[DS, SI]);
    State.IncCycles();
    // JLE 0x1000:dba9 (1000_DB9F / 0x1DB9F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_DBA9_1DBA9;
    }
    State.IncCycles();
    // ADD BX,0x10 (1000_DBA1 / 0x1DBA1)
    BX += 0x10;
    State.IncCycles();
    // CMP BX,word ptr [SI + 0x2] (1000_DBA4 / 0x1DBA4)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JG 0x1000:dbac (1000_DBA7 / 0x1DBA7)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_DBAC_1DBAC;
    }
    State.IncCycles();
    label_1000_DBA9_1DBA9:
    // POP DX (1000_DBA9 / 0x1DBA9)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_DBAA / 0x1DBAA)
    BX = Stack.Pop();
    State.IncCycles();
    label_1000_DBAB_1DBAB:
    // RET  (1000_DBAB / 0x1DBAB)
    return NearRet();
    State.IncCycles();
    label_1000_DBAC_1DBAC:
    // POP DX (1000_DBAC / 0x1DBAC)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_DBAD / 0x1DBAD)
    BX = Stack.Pop();
    State.IncCycles();
    // DEC byte ptr [0xdc47] (1000_DBAE / 0x1DBAE)
    UInt8[DS, 0xDC47] = Alu.Dec8(UInt8[DS, 0xDC47]);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DBB2_01DBB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DBB2_01DBB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DBB2_1DBB2:
    // PUSH AX (1000_DBB2 / 0x1DBB2)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AL,[0xdc46] (1000_DBB3 / 0x1DBB3)
    AL = UInt8[DS, 0xDC46];
    State.IncCycles();
    // DEC byte ptr [0xdc46] (1000_DBB6 / 0x1DBB6)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    State.IncCycles();
    // JS 0x1000:dbc0 (1000_DBBA / 0x1DBBA)
    if(SignFlag) {
      goto label_1000_DBC0_1DBC0;
    }
    State.IncCycles();
    // INC byte ptr [0xdc46] (1000_DBBC / 0x1DBBC)
    UInt8[DS, 0xDC46] = Alu.Inc8(UInt8[DS, 0xDC46]);
    State.IncCycles();
    label_1000_DBC0_1DBC0:
    // OR AL,AL (1000_DBC0 / 0x1DBC0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:dbc8 (1000_DBC2 / 0x1DBC2)
    if(SignFlag) {
      goto label_1000_DBC8_1DBC8;
    }
    State.IncCycles();
    // CALLF [0x38c5] (1000_DBC4 / 0x1DBC4)
    // Indirect call to [0x38c5], generating possible targets from emulator records
    uint targetAddress_1000_DBC4 = (uint)(UInt16[DS, 0x38C7] * 0x10 + UInt16[DS, 0x38C5] - cs1 * 0x10);
    switch(targetAddress_1000_DBC4) {
      case 0x235BC : FarCall(cs1, 0xDBC8, spice86_generated_label_call_target_334B_010C_0335BC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DBC4));
        break;
    }
    State.IncCycles();
    label_1000_DBC8_1DBC8:
    // POP AX (1000_DBC8 / 0x1DBC8)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_DBC9 / 0x1DBC9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DBCA_01DBCA(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDBE3: goto label_1000_DBE3_1DBE3;break; // Target of external jump from 0x14B13
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_DBCA_1DBCA:
    // MOV AX,[0xdc44] (1000_DBCA / 0x1DBCA)
    AX = UInt16[DS, 0xDC44];
    State.IncCycles();
    // CMP AX,0x98 (1000_DBCD / 0x1DBCD)
    Alu.Sub16(AX, 0x98);
    State.IncCycles();
    // JNC 0x1000:dbe2 (1000_DBD0 / 0x1DBD0)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DBE2 / 0x1DBE2)
      return NearRet();
    }
    State.IncCycles();
    // CMP AX,0x88 (1000_DBD2 / 0x1DBD2)
    Alu.Sub16(AX, 0x88);
    State.IncCycles();
    // JNC 0x1000:dbb2 (1000_DBD5 / 0x1DBD5)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DBB2_01DBB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC byte ptr [0xdc46] (1000_DBD7 / 0x1DBD7)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    State.IncCycles();
    // JS 0x1000:dbe2 (1000_DBDB / 0x1DBDB)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DBE2 / 0x1DBE2)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0xdc46],0x80 (1000_DBDD / 0x1DBDD)
    UInt8[DS, 0xDC46] = 0x80;
    State.IncCycles();
    label_1000_DBE2_1DBE2:
    // RET  (1000_DBE2 / 0x1DBE2)
    return NearRet();
    State.IncCycles();
    label_1000_DBE3_1DBE3:
    // MOV AX,[0xdc44] (1000_DBE3 / 0x1DBE3)
    AX = UInt16[DS, 0xDC44];
    State.IncCycles();
    // CMP AX,0x98 (1000_DBE6 / 0x1DBE6)
    Alu.Sub16(AX, 0x98);
    State.IncCycles();
    // JC 0x1000:dbec (1000_DBE9 / 0x1DBE9)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_DBEB / 0x1DBEB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DBEC_01DBEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DBEC_1DBEC:
    // INC byte ptr [0xdc46] (1000_DBEC / 0x1DBEC)
    UInt8[DS, 0xDC46] = Alu.Inc8(UInt8[DS, 0xDC46]);
    State.IncCycles();
    // JS 0x1000:dc1a (1000_DBF0 / 0x1DBF0)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DC1A / 0x1DC1A)
      return NearRet();
    }
    State.IncCycles();
    // JNZ 0x1000:dc1b (1000_DBF2 / 0x1DBF2)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DC1B_01DC1B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH AX (1000_DBF4 / 0x1DBF4)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_DBF5 / 0x1DBF5)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_DBF6 / 0x1DBF6)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_DBF7 / 0x1DBF7)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_DBF8 / 0x1DBF8)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_DBF9 / 0x1DBF9)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_DBFA / 0x1DBFA)
    Stack.Push(BP);
    State.IncCycles();
    // MOV DX,word ptr [0xdc36] (1000_DBFB / 0x1DBFB)
    DX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // MOV BX,word ptr [0xdc38] (1000_DBFF / 0x1DBFF)
    BX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // MOV word ptr [0xdc42],DX (1000_DC03 / 0x1DC03)
    UInt16[DS, 0xDC42] = DX;
    State.IncCycles();
    // MOV word ptr [0xdc44],BX (1000_DC07 / 0x1DC07)
    UInt16[DS, 0xDC44] = BX;
    State.IncCycles();
    // MOV SI,word ptr [0x2582] (1000_DC0B / 0x1DC0B)
    SI = UInt16[DS, 0x2582];
    State.IncCycles();
    // CALLF [0x38c1] (1000_DC0F / 0x1DC0F)
    // Indirect call to [0x38c1], generating possible targets from emulator records
    uint targetAddress_1000_DC0F = (uint)(UInt16[DS, 0x38C3] * 0x10 + UInt16[DS, 0x38C1] - cs1 * 0x10);
    switch(targetAddress_1000_DC0F) {
      case 0x235B9 : FarCall(cs1, 0xDC13, spice86_generated_label_call_target_334B_0109_0335B9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC0F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DC13_01DC13, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DC13_01DC13(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDC1A: goto label_1000_DC1A_1DC1A;break; // Target of external jump from 0x1DBF0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_DC13_1DC13:
    // POP BP (1000_DC13 / 0x1DC13)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_DC14 / 0x1DC14)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_DC15 / 0x1DC15)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_DC16 / 0x1DC16)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_DC17 / 0x1DC17)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_DC18 / 0x1DC18)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_DC19 / 0x1DC19)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_DC1A_1DC1A:
    // RET  (1000_DC1A / 0x1DC1A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DC1B_01DC1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DC1B_1DC1B:
    // DEC byte ptr [0xdc46] (1000_DC1B / 0x1DC1B)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    State.IncCycles();
    // RET  (1000_DC1F / 0x1DC1F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DC20_01DC20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DC20_1DC20:
    // PUSH AX (1000_DC20 / 0x1DC20)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_DC21 / 0x1DC21)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_DC22 / 0x1DC22)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_DC23 / 0x1DC23)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_DC24 / 0x1DC24)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_DC25 / 0x1DC25)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_DC26 / 0x1DC26)
    Stack.Push(BP);
    State.IncCycles();
    // MOV DX,word ptr [0xdc36] (1000_DC27 / 0x1DC27)
    DX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // MOV BX,word ptr [0xdc38] (1000_DC2B / 0x1DC2B)
    BX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // CALL 0x1000:dc6a (1000_DC2F / 0x1DC2F)
    NearCall(cs1, 0xDC32, spice86_generated_label_call_target_1000_DC6A_01DC6A);
    State.IncCycles();
    label_1000_DC32_1DC32:
    // MOV SI,BP (1000_DC32 / 0x1DC32)
    SI = BP;
    State.IncCycles();
    // XCHG word ptr [0x2582],BP (1000_DC34 / 0x1DC34)
    ushort tmp_1000_DC34 = UInt16[DS, 0x2582];
    UInt16[DS, 0x2582] = BP;
    BP = tmp_1000_DC34;
    State.IncCycles();
    // XOR AL,AL (1000_DC38 / 0x1DC38)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0xdc46],AL (1000_DC3A / 0x1DC3A)
    byte tmp_1000_DC3A = UInt8[DS, 0xDC46];
    UInt8[DS, 0xDC46] = AL;
    AL = tmp_1000_DC3A;
    State.IncCycles();
    // OR AL,AL (1000_DC3E / 0x1DC3E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:dc56 (1000_DC40 / 0x1DC40)
    if(SignFlag) {
      goto label_1000_DC56_1DC56;
    }
    State.IncCycles();
    // CMP DX,word ptr [0xdc42] (1000_DC42 / 0x1DC42)
    Alu.Sub16(DX, UInt16[DS, 0xDC42]);
    State.IncCycles();
    // JNZ 0x1000:dc52 (1000_DC46 / 0x1DC46)
    if(!ZeroFlag) {
      goto label_1000_DC52_1DC52;
    }
    State.IncCycles();
    // CMP BX,word ptr [0xdc44] (1000_DC48 / 0x1DC48)
    Alu.Sub16(BX, UInt16[DS, 0xDC44]);
    State.IncCycles();
    // JNZ 0x1000:dc52 (1000_DC4C / 0x1DC4C)
    if(!ZeroFlag) {
      goto label_1000_DC52_1DC52;
    }
    State.IncCycles();
    // CMP SI,BP (1000_DC4E / 0x1DC4E)
    Alu.Sub16(SI, BP);
    State.IncCycles();
    // JZ 0x1000:dc62 (1000_DC50 / 0x1DC50)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DC62_01DC62, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_DC52_1DC52:
    // CALLF [0x38c5] (1000_DC52 / 0x1DC52)
    // Indirect call to [0x38c5], generating possible targets from emulator records
    uint targetAddress_1000_DC52 = (uint)(UInt16[DS, 0x38C7] * 0x10 + UInt16[DS, 0x38C5] - cs1 * 0x10);
    switch(targetAddress_1000_DC52) {
      case 0x235BC : FarCall(cs1, 0xDC56, spice86_generated_label_call_target_334B_010C_0335BC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC52));
        break;
    }
    State.IncCycles();
    label_1000_DC56_1DC56:
    // MOV word ptr [0xdc42],DX (1000_DC56 / 0x1DC56)
    UInt16[DS, 0xDC42] = DX;
    State.IncCycles();
    // MOV word ptr [0xdc44],BX (1000_DC5A / 0x1DC5A)
    UInt16[DS, 0xDC44] = BX;
    State.IncCycles();
    // CALLF [0x38c1] (1000_DC5E / 0x1DC5E)
    // Indirect call to [0x38c1], generating possible targets from emulator records
    uint targetAddress_1000_DC5E = (uint)(UInt16[DS, 0x38C3] * 0x10 + UInt16[DS, 0x38C1] - cs1 * 0x10);
    switch(targetAddress_1000_DC5E) {
      case 0x235B9 : FarCall(cs1, 0xDC62, spice86_generated_label_call_target_334B_0109_0335B9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC5E));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DC62_01DC62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DC62_01DC62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DC62_1DC62:
    // POP BP (1000_DC62 / 0x1DC62)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_DC63 / 0x1DC63)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_DC64 / 0x1DC64)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_DC65 / 0x1DC65)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_DC66 / 0x1DC66)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_DC67 / 0x1DC67)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_DC68 / 0x1DC68)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_DC69 / 0x1DC69)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DC6A_01DC6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DC6A_1DC6A:
    // CMP byte ptr [0x28be],0x0 (1000_DC6A / 0x1DC6A)
    Alu.Sub8(UInt8[DS, 0x28BE], 0x0);
    State.IncCycles();
    // MOV BP,0x25c8 (1000_DC6F / 0x1DC6F)
    BP = 0x25C8;
    State.IncCycles();
    // JNZ 0x1000:dcdf (1000_DC72 / 0x1DC72)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x2584 (1000_DC74 / 0x1DC74)
    BP = 0x2584;
    State.IncCycles();
    // CMP byte ptr [0x4723],0x0 (1000_DC77 / 0x1DC77)
    Alu.Sub8(UInt8[DS, 0x4723], 0x0);
    State.IncCycles();
    // JNZ 0x1000:dcdf (1000_DC7C / 0x1DC7C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [0xdc58] (1000_DC7E / 0x1DC7E)
    DI = UInt16[DS, 0xDC58];
    State.IncCycles();
    // OR DI,DI (1000_DC82 / 0x1DC82)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:dcdf (1000_DC84 / 0x1DC84)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,0x9b (1000_DC86 / 0x1DC86)
    Alu.Sub16(BX, 0x9B);
    State.IncCycles();
    // JGE 0x1000:dcdf (1000_DC8A / 0x1DC8A)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_DC8C / 0x1DC8C)
    NearCall(cs1, 0xDC8F, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_DC8F_1DC8F:
    // MOV BP,0x25c8 (1000_DC8F / 0x1DC8F)
    BP = 0x25C8;
    State.IncCycles();
    // JC 0x1000:dcdf (1000_DC92 / 0x1DC92)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x2] (1000_DC94 / 0x1DC94)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    State.IncCycles();
    // JL 0x1000:dcb9 (1000_DC97 / 0x1DC97)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DCB9_1DCB9;
    }
    State.IncCycles();
    // CMP BX,word ptr [DI + 0x6] (1000_DC99 / 0x1DC99)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    State.IncCycles();
    // JGE 0x1000:dcb9 (1000_DC9C / 0x1DC9C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DCB9_1DCB9;
    }
    State.IncCycles();
    // MOV BP,0x26d8 (1000_DC9E / 0x1DC9E)
    BP = 0x26D8;
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_DCA1 / 0x1DCA1)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // SUB AX,DX (1000_DCA3 / 0x1DCA3)
    AX -= DX;
    State.IncCycles();
    // CMP AX,0x32 (1000_DCA5 / 0x1DCA5)
    Alu.Sub16(AX, 0x32);
    State.IncCycles();
    // JC 0x1000:dcdf (1000_DCA8 / 0x1DCA8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x2650 (1000_DCAA / 0x1DCAA)
    BP = 0x2650;
    State.IncCycles();
    // MOV AX,DX (1000_DCAD / 0x1DCAD)
    AX = DX;
    State.IncCycles();
    // SUB AX,word ptr [DI + 0x4] (1000_DCAF / 0x1DCAF)
    AX -= UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // CMP AX,0x32 (1000_DCB2 / 0x1DCB2)
    Alu.Sub16(AX, 0x32);
    State.IncCycles();
    // JC 0x1000:dcdf (1000_DCB5 / 0x1DCB5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:dcdc (1000_DCB7 / 0x1DCB7)
    goto label_1000_DCDC_1DCDC;
    State.IncCycles();
    label_1000_DCB9_1DCB9:
    // CMP DX,word ptr [DI] (1000_DCB9 / 0x1DCB9)
    Alu.Sub16(DX, UInt16[DS, DI]);
    State.IncCycles();
    // JL 0x1000:dcdc (1000_DCBB / 0x1DCBB)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DCDC_1DCDC;
    }
    State.IncCycles();
    // CMP DX,word ptr [DI + 0x4] (1000_DCBD / 0x1DCBD)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JGE 0x1000:dcdc (1000_DCC0 / 0x1DCC0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DCDC_1DCDC;
    }
    State.IncCycles();
    // MOV BP,0x260c (1000_DCC2 / 0x1DCC2)
    BP = 0x260C;
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x2] (1000_DCC5 / 0x1DCC5)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // SUB AX,BX (1000_DCC8 / 0x1DCC8)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x19 (1000_DCCA / 0x1DCCA)
    Alu.Sub16(AX, 0x19);
    State.IncCycles();
    // JC 0x1000:dcdf (1000_DCCD / 0x1DCCD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x2694 (1000_DCCF / 0x1DCCF)
    BP = 0x2694;
    State.IncCycles();
    // MOV AX,BX (1000_DCD2 / 0x1DCD2)
    AX = BX;
    State.IncCycles();
    // SUB AX,word ptr [DI + 0x6] (1000_DCD4 / 0x1DCD4)
    AX -= UInt16[DS, (ushort)(DI + 0x6)];
    State.IncCycles();
    // CMP AX,0x19 (1000_DCD7 / 0x1DCD7)
    Alu.Sub16(AX, 0x19);
    State.IncCycles();
    // JC 0x1000:dcdf (1000_DCDA / 0x1DCDA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    State.IncCycles();
    label_1000_DCDC_1DCDC:
    // MOV BP,0x2584 (1000_DCDC / 0x1DCDC)
    BP = 0x2584;
    State.IncCycles();
    label_1000_DCDF_1DCDF:
    // RET  (1000_DCDF / 0x1DCDF)
    return NearRet();
  }
  
  public virtual Action read_game_port_ida_1000_DCE0_1DCE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DCE0_1DCE0:
    // MOV DX,0x201 (1000_DCE0 / 0x1DCE0)
    DX = 0x201;
    State.IncCycles();
    // PUSHF  (1000_DCE3 / 0x1DCE3)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CLI  (1000_DCE4 / 0x1DCE4)
    InterruptFlag = false;
    State.IncCycles();
    // OUT DX,AL (1000_DCE5 / 0x1DCE5)
    Cpu.Out8(DX, AL);
    State.IncCycles();
    // XOR BX,BX (1000_DCE6 / 0x1DCE6)
    BX = 0;
    State.IncCycles();
    // MOV CX,BX (1000_DCE8 / 0x1DCE8)
    CX = BX;
    State.IncCycles();
    // MOV DI,0x800 (1000_DCEA / 0x1DCEA)
    DI = 0x800;
    State.IncCycles();
    label_1000_DCED_1DCED:
    // IN AL,DX (1000_DCED / 0x1DCED)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // MOV AH,AL (1000_DCEE / 0x1DCEE)
    AH = AL;
    State.IncCycles();
    // SHR AH,1 (1000_DCF0 / 0x1DCF0)
    AH >>= 0x1;
    State.IncCycles();
    // AND AX,0x101 (1000_DCF2 / 0x1DCF2)
    // AX &= 0x101;
    AX = Alu.And16(AX, 0x101);
    State.IncCycles();
    // JZ 0x1000:dd09 (1000_DCF5 / 0x1DCF5)
    if(ZeroFlag) {
      goto label_1000_DD09_1DD09;
    }
    State.IncCycles();
    // ADD CL,AL (1000_DCF7 / 0x1DCF7)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    State.IncCycles();
    // ADC CH,0x0 (1000_DCF9 / 0x1DCF9)
    CH = Alu.Adc8(CH, 0x0);
    State.IncCycles();
    // ADD BL,AH (1000_DCFC / 0x1DCFC)
    // BL += AH;
    BL = Alu.Add8(BL, AH);
    State.IncCycles();
    // ADC BH,0x0 (1000_DCFE / 0x1DCFE)
    BH = Alu.Adc8(BH, 0x0);
    State.IncCycles();
    // DEC DI (1000_DD01 / 0x1DD01)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // JNZ 0x1000:dced (1000_DD02 / 0x1DD02)
    if(!ZeroFlag) {
      goto label_1000_DCED_1DCED;
    }
    State.IncCycles();
    // AND byte ptr [0x2942],0x7f (1000_DD04 / 0x1DD04)
    // UInt8[DS, 0x2942] &= 0x7F;
    UInt8[DS, 0x2942] = Alu.And8(UInt8[DS, 0x2942], 0x7F);
    State.IncCycles();
    label_1000_DD09_1DD09:
    // IN AL,DX (1000_DD09 / 0x1DD09)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // POPF  (1000_DD0A / 0x1DD0A)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // MOV DX,CX (1000_DD0B / 0x1DD0B)
    DX = CX;
    State.IncCycles();
    // NOT AL (1000_DD0D / 0x1DD0D)
    AL = (byte)~AL;
    State.IncCycles();
    // RET  (1000_DD0F / 0x1DD0F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_DD10_01DD10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DD10_1DD10:
    // CALL 0x1000:dce0 (1000_DD10 / 0x1DD10)
    NearCall(cs1, 0xDD13, read_game_port_ida_1000_DCE0_1DCE0);
    State.IncCycles();
    // MOV AH,AL (1000_DD13 / 0x1DD13)
    AH = AL;
    State.IncCycles();
    // XOR AL,AL (1000_DD15 / 0x1DD15)
    AL = 0;
    State.IncCycles();
    // TEST AH,0x30 (1000_DD17 / 0x1DD17)
    Alu.And8(AH, 0x30);
    State.IncCycles();
    // JZ 0x1000:dd1e (1000_DD1A / 0x1DD1A)
    if(ZeroFlag) {
      goto label_1000_DD1E_1DD1E;
    }
    State.IncCycles();
    // NOT AL (1000_DD1C / 0x1DD1C)
    AL = (byte)~AL;
    State.IncCycles();
    label_1000_DD1E_1DD1E:
    // MOV [0xcee6],AL (1000_DD1E / 0x1DD1E)
    UInt8[DS, 0xCEE6] = AL;
    State.IncCycles();
    // MOV AX,0xff (1000_DD21 / 0x1DD21)
    AX = 0xFF;
    State.IncCycles();
    // CMP DX,word ptr [0x39ab] (1000_DD24 / 0x1DD24)
    Alu.Sub16(DX, UInt16[DS, 0x39AB]);
    State.IncCycles();
    // JA 0x1000:dd2e (1000_DD28 / 0x1DD28)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_DD2E_1DD2E;
    }
    State.IncCycles();
    // XCHG AL,AH (1000_DD2A / 0x1DD2A)
    byte tmp_1000_DD2A = AL;
    AL = AH;
    AH = tmp_1000_DD2A;
    State.IncCycles();
    // JMP 0x1000:dd36 (1000_DD2C / 0x1DD2C)
    goto label_1000_DD36_1DD36;
    State.IncCycles();
    label_1000_DD2E_1DD2E:
    // CMP DX,word ptr [0x39ad] (1000_DD2E / 0x1DD2E)
    Alu.Sub16(DX, UInt16[DS, 0x39AD]);
    State.IncCycles();
    // JNC 0x1000:dd36 (1000_DD32 / 0x1DD32)
    if(!CarryFlag) {
      goto label_1000_DD36_1DD36;
    }
    State.IncCycles();
    // XOR AX,AX (1000_DD34 / 0x1DD34)
    AX = 0;
    State.IncCycles();
    label_1000_DD36_1DD36:
    // MOV [0xcee1],AL (1000_DD36 / 0x1DD36)
    UInt8[DS, 0xCEE1] = AL;
    State.IncCycles();
    // MOV byte ptr [0xcedf],AH (1000_DD39 / 0x1DD39)
    UInt8[DS, 0xCEDF] = AH;
    State.IncCycles();
    // MOV AX,0xff (1000_DD3D / 0x1DD3D)
    AX = 0xFF;
    State.IncCycles();
    // CMP BX,word ptr [0x39af] (1000_DD40 / 0x1DD40)
    Alu.Sub16(BX, UInt16[DS, 0x39AF]);
    State.IncCycles();
    // JA 0x1000:dd4a (1000_DD44 / 0x1DD44)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_DD4A_1DD4A;
    }
    State.IncCycles();
    // XCHG AH,AL (1000_DD46 / 0x1DD46)
    byte tmp_1000_DD46 = AH;
    AH = AL;
    AL = tmp_1000_DD46;
    State.IncCycles();
    // JMP 0x1000:dd52 (1000_DD48 / 0x1DD48)
    goto label_1000_DD52_1DD52;
    State.IncCycles();
    label_1000_DD4A_1DD4A:
    // CMP BX,word ptr [0x39b1] (1000_DD4A / 0x1DD4A)
    Alu.Sub16(BX, UInt16[DS, 0x39B1]);
    State.IncCycles();
    // JNC 0x1000:dd52 (1000_DD4E / 0x1DD4E)
    if(!CarryFlag) {
      goto label_1000_DD52_1DD52;
    }
    State.IncCycles();
    // XOR AX,AX (1000_DD50 / 0x1DD50)
    AX = 0;
    State.IncCycles();
    label_1000_DD52_1DD52:
    // MOV [0xcee4],AL (1000_DD52 / 0x1DD52)
    UInt8[DS, 0xCEE4] = AL;
    State.IncCycles();
    // MOV byte ptr [0xcedc],AH (1000_DD55 / 0x1DD55)
    UInt8[DS, 0xCEDC] = AH;
    State.IncCycles();
    // RET  (1000_DD59 / 0x1DD59)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DD5A_01DD5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DD5A_1DD5A:
    // XOR AL,AL (1000_DD5A / 0x1DD5A)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0xcee8],AL (1000_DD5C / 0x1DD5C)
    byte tmp_1000_DD5C = UInt8[DS, 0xCEE8];
    UInt8[DS, 0xCEE8] = AL;
    AL = tmp_1000_DD5C;
    State.IncCycles();
    // OR AL,AL (1000_DD60 / 0x1DD60)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // RET  (1000_DD62 / 0x1DD62)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DD63_01DD63(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DD63_1DD63:
    // CALL 0x1000:de7b (1000_DD63 / 0x1DD63)
    NearCall(cs1, 0xDD66, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    State.IncCycles();
    label_1000_DD66_1DD66:
    // CALL 0x1000:de54 (1000_DD66 / 0x1DD66)
    NearCall(cs1, 0xDD69, spice86_generated_label_call_target_1000_DE54_01DE54);
    State.IncCycles();
    label_1000_DD69_1DD69:
    // JZ 0x1000:ddae (1000_DD69 / 0x1DD69)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0xcee8],0x0 (1000_DD6B / 0x1DD6B)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x0);
    State.IncCycles();
    // JNZ 0x1000:ddae (1000_DD70 / 0x1DD70)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST byte ptr [0x2942],0x40 (1000_DD72 / 0x1DD72)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    State.IncCycles();
    // JNZ 0x1000:dd89 (1000_DD77 / 0x1DD77)
    if(!ZeroFlag) {
      goto label_1000_DD89_1DD89;
    }
    State.IncCycles();
    // MOV AX,0x3 (1000_DD79 / 0x1DD79)
    AX = 0x3;
    State.IncCycles();
    // INT 0x33 (1000_DD7C / 0x1DD7C)
    Interrupt(0x33);
    State.IncCycles();
    // XCHG SI,BX (1000_DD7E / 0x1DD7E)
    ushort tmp_1000_DD7E = SI;
    SI = BX;
    BX = tmp_1000_DD7E;
    State.IncCycles();
    // XOR BX,SI (1000_DD80 / 0x1DD80)
    BX ^= SI;
    State.IncCycles();
    // AND BX,SI (1000_DD82 / 0x1DD82)
    BX &= SI;
    State.IncCycles();
    // AND BL,0x7 (1000_DD84 / 0x1DD84)
    // BL &= 0x7;
    BL = Alu.And8(BL, 0x7);
    State.IncCycles();
    // JNZ 0x1000:ddae (1000_DD87 / 0x1DD87)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_DD89_1DD89:
    // TEST byte ptr [0x2942],0x80 (1000_DD89 / 0x1DD89)
    Alu.And8(UInt8[DS, 0x2942], 0x80);
    State.IncCycles();
    // JZ 0x1000:dd9e (1000_DD8E / 0x1DD8E)
    if(ZeroFlag) {
      goto label_1000_DD9E_1DD9E;
    }
    State.IncCycles();
    // PUSH DI (1000_DD90 / 0x1DD90)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:dce0 (1000_DD91 / 0x1DD91)
    NearCall(cs1, 0xDD94, read_game_port_ida_1000_DCE0_1DCE0);
    State.IncCycles();
    // POP DI (1000_DD94 / 0x1DD94)
    DI = Stack.Pop();
    State.IncCycles();
    // XCHG AX,DI (1000_DD95 / 0x1DD95)
    ushort tmp_1000_DD95 = AX;
    AX = DI;
    DI = tmp_1000_DD95;
    State.IncCycles();
    // XOR AX,DI (1000_DD96 / 0x1DD96)
    AX ^= DI;
    State.IncCycles();
    // AND AX,DI (1000_DD98 / 0x1DD98)
    AX &= DI;
    State.IncCycles();
    // AND AL,0x30 (1000_DD9A / 0x1DD9A)
    // AL &= 0x30;
    AL = Alu.And8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:ddae (1000_DD9C / 0x1DD9C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDAE_01DDAE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_DD9E_1DD9E:
    // PUSH SI (1000_DD9E / 0x1DD9E)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_DD9F / 0x1DD9F)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:e3cc (1000_DDA0 / 0x1DDA0)
    NearCall(cs1, 0xDDA3, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDA3_01DDA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDA3_01DDA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DDA3_1DDA3:
    // MOV [0x0],AX (1000_DDA3 / 0x1DDA3)
    UInt16[DS, 0x0] = AX;
    State.IncCycles();
    // CALL 0x1000:d9d2 (1000_DDA6 / 0x1DDA6)
    NearCall(cs1, 0xDDA9, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDA9_01DDA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDA9_01DDA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DDA9_1DDA9:
    // POP DI (1000_DDA9 / 0x1DDA9)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_DDAA / 0x1DDAA)
    SI = Stack.Pop();
    State.IncCycles();
    // OR AL,0x1 (1000_DDAB / 0x1DDAB)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    State.IncCycles();
    // RET  (1000_DDAD / 0x1DDAD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DDAE_01DDAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DDAE_1DDAE:
    // STC  (1000_DDAE / 0x1DDAE)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_DDAF / 0x1DDAF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DDB0_01DDB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DDB0_1DDB0:
    // CALL 0x1000:e270 (1000_DDB0 / 0x1DDB0)
    NearCall(cs1, 0xDDB3, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDB3_01DDB3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDB3_01DDB3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DDB3_1DDB3:
    // PUSH AX (1000_DDB3 / 0x1DDB3)
    Stack.Push(AX);
    State.IncCycles();
    // MOV byte ptr [0xcee8],0x0 (1000_DDB4 / 0x1DDB4)
    UInt8[DS, 0xCEE8] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_DDB9 / 0x1DDB9)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:ddc3 (1000_DDBE / 0x1DDBE)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDC3_01DDC3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:d64e (1000_DDC0 / 0x1DDC0)
    NearCall(cs1, 0xDDC3, spice86_generated_label_call_target_1000_D64E_01D64E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DDC3_01DDC3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DDC3_01DDC3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DDC3_1DDC3:
    // MOV SI,0xffff (1000_DDC3 / 0x1DDC3)
    SI = 0xFFFF;
    State.IncCycles();
    // MOV DI,SI (1000_DDC6 / 0x1DDC6)
    DI = SI;
    State.IncCycles();
    // POP CX (1000_DDC8 / 0x1DDC8)
    CX = Stack.Pop();
    State.IncCycles();
    // STI  (1000_DDC9 / 0x1DDC9)
    InterruptFlag = true;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDCA_01DDCA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_DDCA_01DDCA(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDDE7: goto label_1000_DDE7_1DDE7;break; // Target of external jump from 0x1DDD4, 0x1DE4C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_DDCA_1DDCA:
    // PUSH word ptr [0xce7a] (1000_DDCA / 0x1DDCA)
    Stack.Push(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // PUSH CX (1000_DDCE / 0x1DDCE)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:dd63 (1000_DDCF / 0x1DDCF)
    NearCall(cs1, 0xDDD2, spice86_generated_label_call_target_1000_DD63_01DD63);
    State.IncCycles();
    label_1000_DDD2_1DDD2:
    // POP CX (1000_DDD2 / 0x1DDD2)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_DDD3 / 0x1DDD3)
    AX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:dde7 (1000_DDD4 / 0x1DDD4)
    if(CarryFlag) {
      goto label_1000_DDE7_1DDE7;
    }
    State.IncCycles();
    // MOV BX,AX (1000_DDD6 / 0x1DDD6)
    BX = AX;
    State.IncCycles();
    label_1000_DDD8_1DDD8:
    // MOV AX,BX (1000_DDD8 / 0x1DDD8)
    AX = BX;
    State.IncCycles();
    // SUB AX,word ptr SS:[0xce7a] (1000_DDDA / 0x1DDDA)
    // AX -= UInt16[SS, 0xCE7A];
    AX = Alu.Sub16(AX, UInt16[SS, 0xCE7A]);
    State.IncCycles();
    // JZ 0x1000:ddd8 (1000_DDDF / 0x1DDDF)
    if(ZeroFlag) {
      goto label_1000_DDD8_1DDD8;
    }
    State.IncCycles();
    // ADD CX,AX (1000_DDE1 / 0x1DDE1)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    // JC 0x1000:ddca (1000_DDE3 / 0x1DDE3)
    if(CarryFlag) {
      goto label_1000_DDCA_1DDCA;
    }
    State.IncCycles();
    // OR AL,0x1 (1000_DDE5 / 0x1DDE5)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    State.IncCycles();
    label_1000_DDE7_1DDE7:
    // PUSHF  (1000_DDE7 / 0x1DDE7)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CALL 0x1000:de4e (1000_DDE8 / 0x1DDE8)
    NearCall(cs1, 0xDDEB, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    State.IncCycles();
    label_1000_DDEB_1DDEB:
    // POPF  (1000_DDEB / 0x1DDEB)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_DDEC / 0x1DDEC)
    NearCall(cs1, 0xDDEF, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_DDEF_1DDEF:
    // RET  (1000_DDEF / 0x1DDEF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DDF0_01DDF0(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDE07: goto label_1000_DE07_1DE07;break; // Target of external jump from 0x1DE11, 0x1DDF5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_DDF0_1DDF0:
    // CMP byte ptr [0xdbcd],0x0 (1000_DDF0 / 0x1DDF0)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    State.IncCycles();
    // JS 0x1000:de07 (1000_DDF5 / 0x1DDF5)
    if(SignFlag) {
      goto label_1000_DE07_1DE07;
    }
    State.IncCycles();
    // CALL 0x1000:aba3 (1000_DDF7 / 0x1DDF7)
    NearCall(cs1, 0xDDFA, check_res_file_open_ida_1000_ABA3_1ABA3);
    State.IncCycles();
    // JZ 0x1000:ddb0 (1000_DDFA / 0x1DDFA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DDB0_01DDB0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_DDFC_1DDFC:
    // CALL 0x1000:aba3 (1000_DDFC / 0x1DDFC)
    NearCall(cs1, 0xDDFF, check_res_file_open_ida_1000_ABA3_1ABA3);
    State.IncCycles();
    // JZ 0x1000:de07 (1000_DDFF / 0x1DDFF)
    if(ZeroFlag) {
      goto label_1000_DE07_1DE07;
    }
    State.IncCycles();
    // CALL 0x1000:dd63 (1000_DE01 / 0x1DE01)
    NearCall(cs1, 0xDE04, spice86_generated_label_call_target_1000_DD63_01DD63);
    State.IncCycles();
    // JNC 0x1000:ddfc (1000_DE04 / 0x1DE04)
    if(!CarryFlag) {
      goto label_1000_DDFC_1DDFC;
    }
    State.IncCycles();
    // RET  (1000_DE06 / 0x1DE06)
    return NearRet();
    State.IncCycles();
    label_1000_DE07_1DE07:
    // PUSH AX (1000_DE07 / 0x1DE07)
    Stack.Push(AX);
    State.IncCycles();
    // OR AL,0x1 (1000_DE08 / 0x1DE08)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    State.IncCycles();
    // POP AX (1000_DE0A / 0x1DE0A)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_DE0B / 0x1DE0B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE0C_01DE0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE0C_1DE0C:
    // CMP byte ptr [0xdbcd],0x0 (1000_DE0C / 0x1DE0C)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    State.IncCycles();
    // JNS 0x1000:de07 (1000_DE11 / 0x1DE11)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DDF0_01DDF0, 0x1DE07 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_DE13 / 0x1DE13)
    NearCall(cs1, 0xDE16, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DE16_01DE16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DE16_01DE16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE16_1DE16:
    // MOV byte ptr [0xcee8],0x0 (1000_DE16 / 0x1DE16)
    UInt8[DS, 0xCEE8] = 0x0;
    State.IncCycles();
    // MOV SI,0xffff (1000_DE1B / 0x1DE1B)
    SI = 0xFFFF;
    State.IncCycles();
    // MOV DI,SI (1000_DE1E / 0x1DE1E)
    DI = SI;
    State.IncCycles();
    label_1000_DE20_1DE20:
    // MOV AX,0x60 (1000_DE20 / 0x1DE20)
    AX = 0x60;
    State.IncCycles();
    // SUB AX,word ptr [0xdbd0] (1000_DE23 / 0x1DE23)
    AX -= UInt16[DS, 0xDBD0];
    State.IncCycles();
    // XOR AH,AH (1000_DE27 / 0x1DE27)
    AH = 0;
    State.IncCycles();
    // MOV DL,0x6 (1000_DE29 / 0x1DE29)
    DL = 0x6;
    State.IncCycles();
    // DIV DL (1000_DE2B / 0x1DE2B)
    Cpu.Div8(DL);
    State.IncCycles();
    // AND AL,0xf (1000_DE2D / 0x1DE2D)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // MOV DX,word ptr [0xdbce] (1000_DE2F / 0x1DE2F)
    DX = UInt16[DS, 0xDBCE];
    State.IncCycles();
    // SHL DX,1 (1000_DE33 / 0x1DE33)
    DX <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_DE35 / 0x1DE35)
    DX <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_DE37 / 0x1DE37)
    DX <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_DE39 / 0x1DE39)
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    State.IncCycles();
    // OR DL,AL (1000_DE3B / 0x1DE3B)
    DL |= AL;
    State.IncCycles();
    // CMP BX,DX (1000_DE3D / 0x1DE3D)
    Alu.Sub16(BX, DX);
    State.IncCycles();
    // JBE 0x1000:de4a (1000_DE3F / 0x1DE3F)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_DE4A_1DE4A;
    }
    State.IncCycles();
    // PUSH BX (1000_DE41 / 0x1DE41)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:dd63 (1000_DE42 / 0x1DE42)
    NearCall(cs1, 0xDE45, spice86_generated_label_call_target_1000_DD63_01DD63);
    State.IncCycles();
    // POP BX (1000_DE45 / 0x1DE45)
    BX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:dde7 (1000_DE46 / 0x1DE46)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDCA_01DDCA, 0x1DDE7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:de20 (1000_DE48 / 0x1DE48)
    goto label_1000_DE20_1DE20;
    State.IncCycles();
    label_1000_DE4A_1DE4A:
    // OR AL,0x1 (1000_DE4A / 0x1DE4A)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    State.IncCycles();
    // JMP 0x1000:dde7 (1000_DE4C / 0x1DE4C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DDCA_01DDCA, 0x1DDE7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE4E_01DE4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE4E_1DE4E:
    // MOV byte ptr [0xcee8],0x0 (1000_DE4E / 0x1DE4E)
    UInt8[DS, 0xCEE8] = 0x0;
    State.IncCycles();
    // RET  (1000_DE53 / 0x1DE53)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE54_01DE54(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE54_1DE54:
    // MOV byte ptr [0xcee9],0x0 (1000_DE54 / 0x1DE54)
    UInt8[DS, 0xCEE9] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0xcee8],0x1 (1000_DE59 / 0x1DE59)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x1);
    State.IncCycles();
    // JNZ 0x1000:de67 (1000_DE5E / 0x1DE5E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DE67 / 0x1DE67)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0xcee9],0x1 (1000_DE60 / 0x1DE60)
    UInt8[DS, 0xCEE9] = 0x1;
    State.IncCycles();
    // JMP 0x1000:de4e (1000_DE65 / 0x1DE65)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_DE67_1DE67:
    // RET  (1000_DE67 / 0x1DE67)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE68_01DE68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE68_1DE68:
    // CALL 0x1000:dd5a (1000_DE68 / 0x1DE68)
    NearCall(cs1, 0xDE6B, spice86_generated_label_call_target_1000_DD5A_01DD5A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DE6B_01DE6B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DE6B_01DE6B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE6B_1DE6B:
    // JNZ 0x1000:de68 (1000_DE6B / 0x1DE6B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE68_01DE68, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:f08e (1000_DE6D / 0x1DE6D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F08E_01F08E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DE7B_01DE7B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDE7A: break; // Instructions before entry targeted by 0x1DE80
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_DE7A_1DE7A:
    // RET  (1000_DE7A / 0x1DE7A)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_DE7B_1DE7B:
    // CMP byte ptr [0xce9a],0x0 (1000_DE7B / 0x1DE7B)
    Alu.Sub8(UInt8[DS, 0xCE9A], 0x0);
    State.IncCycles();
    // JZ 0x1000:de7a (1000_DE80 / 0x1DE80)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DE7A / 0x1DE7A)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xce80],0x0 (1000_DE82 / 0x1DE82)
    Alu.Sub8(UInt8[DS, 0xCE80], 0x0);
    State.IncCycles();
    // JZ 0x1000:de7a (1000_DE87 / 0x1DE87)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DE7A / 0x1DE7A)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_DE89 / 0x1DE89)
    NearCall(cs1, 0xDE8C, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DE8C_01DE8C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DE8C_01DE8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DE8C_1DE8C:
    // MOV AL,0x1 (1000_DE8C / 0x1DE8C)
    AL = 0x1;
    State.IncCycles();
    // XCHG byte ptr [0x2788],AL (1000_DE8E / 0x1DE8E)
    byte tmp_1000_DE8E = UInt8[DS, 0x2788];
    UInt8[DS, 0x2788] = AL;
    AL = tmp_1000_DE8E;
    State.IncCycles();
    // PUSH AX (1000_DE92 / 0x1DE92)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH word ptr [0xce7a] (1000_DE93 / 0x1DE93)
    Stack.Push(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_DE97 / 0x1DE97)
    NearCall(cs1, 0xDE9A, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_DE9A_1DE9A:
    // PUSH word ptr [0xdbda] (1000_DE9A / 0x1DE9A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_DE9E / 0x1DE9E)
    NearCall(cs1, 0xDEA1, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DEA1_01DEA1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DEA1_01DEA1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DEA1_1DEA1:
    // PUSH word ptr [0xdbd6] (1000_DEA1 / 0x1DEA1)
    Stack.Push(UInt16[DS, 0xDBD6]);
    State.IncCycles();
    // CALLF [0x38b9] (1000_DEA5 / 0x1DEA5)
    // Indirect call to [0x38b9], generating possible targets from emulator records
    uint targetAddress_1000_DEA5 = (uint)(UInt16[DS, 0x38BB] * 0x10 + UInt16[DS, 0x38B9] - cs1 * 0x10);
    switch(targetAddress_1000_DEA5) {
      case 0x235B3 : FarCall(cs1, 0xDEA9, spice86_generated_label_call_target_334B_0103_0335B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DEA5));
        break;
    }
    State.IncCycles();
    label_1000_DEA9_1DEA9:
    // MOV [0xdbd6],AX (1000_DEA9 / 0x1DEA9)
    UInt16[DS, 0xDBD6] = AX;
    State.IncCycles();
    // MOV SI,0x2945 (1000_DEAC / 0x1DEAC)
    SI = 0x2945;
    State.IncCycles();
    // CALL 0x1000:7b1b (1000_DEAF / 0x1DEAF)
    NearCall(cs1, 0xDEB2, spice86_generated_label_call_target_1000_7B1B_017B1B);
    State.IncCycles();
    label_1000_DEB2_1DEB2:
    // MOV CX,0xf1fe (1000_DEB2 / 0x1DEB2)
    CX = 0xF1FE;
    State.IncCycles();
    // MOV DX,0x82 (1000_DEB5 / 0x1DEB5)
    DX = 0x82;
    State.IncCycles();
    // MOV BX,0xa9 (1000_DEB8 / 0x1DEB8)
    BX = 0xA9;
    State.IncCycles();
    // MOV AX,0x115 (1000_DEBB / 0x1DEBB)
    AX = 0x115;
    State.IncCycles();
    // CALL 0x1000:d068 (1000_DEBE / 0x1DEBE)
    NearCall(cs1, 0xDEC1, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DEC1_01DEC1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DEC1_01DEC1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DEC1_1DEC1:
    // CALL 0x1000:d194 (1000_DEC1 / 0x1DEC1)
    NearCall(cs1, 0xDEC4, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    label_1000_DEC4_1DEC4:
    // CALL 0x1000:d075 (1000_DEC4 / 0x1DEC4)
    NearCall(cs1, 0xDEC7, spice86_generated_label_call_target_1000_D075_01D075);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DEC7_01DEC7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DEC7_01DEC7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DEC7_1DEC7:
    // MOV DX,0x60 (1000_DEC7 / 0x1DEC7)
    DX = 0x60;
    State.IncCycles();
    // MOV BX,0xb8 (1000_DECA / 0x1DECA)
    BX = 0xB8;
    State.IncCycles();
    // MOV AX,0x116 (1000_DECD / 0x1DECD)
    AX = 0x116;
    State.IncCycles();
    // MOV CX,0xf1f7 (1000_DED0 / 0x1DED0)
    CX = 0xF1F7;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_DED3 / 0x1DED3)
    NearCall(cs1, 0xDED6, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    label_1000_DED6_1DED6:
    // CMP byte ptr [0xce9a],0x0 (1000_DED6 / 0x1DED6)
    Alu.Sub8(UInt8[DS, 0xCE9A], 0x0);
    State.IncCycles();
    // JNZ 0x1000:ded6 (1000_DEDB / 0x1DEDB)
    if(!ZeroFlag) {
      goto label_1000_DED6_1DED6;
    }
    State.IncCycles();
    // CALL 0x1000:de68 (1000_DEDD / 0x1DEDD)
    NearCall(cs1, 0xDEE0, spice86_generated_label_call_target_1000_DE68_01DE68);
    State.IncCycles();
    label_1000_DEE0_1DEE0:
    // CALL 0x1000:dd5a (1000_DEE0 / 0x1DEE0)
    NearCall(cs1, 0xDEE3, spice86_generated_label_call_target_1000_DD5A_01DD5A);
    State.IncCycles();
    label_1000_DEE3_1DEE3:
    // JZ 0x1000:dee0 (1000_DEE3 / 0x1DEE3)
    if(ZeroFlag) {
      goto label_1000_DEE0_1DEE0;
    }
    State.IncCycles();
    // PUSH AX (1000_DEE5 / 0x1DEE5)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:de68 (1000_DEE6 / 0x1DEE6)
    NearCall(cs1, 0xDEE9, spice86_generated_label_call_target_1000_DE68_01DE68);
    State.IncCycles();
    label_1000_DEE9_1DEE9:
    // CALL 0x1000:df07 (1000_DEE9 / 0x1DEE9)
    NearCall(cs1, 0xDEEC, spice86_generated_label_call_target_1000_DF07_01DF07);
    State.IncCycles();
    label_1000_DEEC_1DEEC:
    // POP AX (1000_DEEC / 0x1DEEC)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AL (1000_DEED / 0x1DEED)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JZ 0x1000:dee0 (1000_DEEF / 0x1DEEF)
    if(ZeroFlag) {
      goto label_1000_DEE0_1DEE0;
    }
    State.IncCycles();
    // POP word ptr [0xdbd6] (1000_DEF1 / 0x1DEF1)
    UInt16[DS, 0xDBD6] = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_DEF5 / 0x1DEF5)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0xce7a] (1000_DEF9 / 0x1DEF9)
    UInt16[DS, 0xCE7A] = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_DEFD / 0x1DEFD)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x2788],AL (1000_DEFE / 0x1DEFE)
    UInt8[DS, 0x2788] = AL;
    State.IncCycles();
    // CALL 0x1000:e283 (1000_DF01 / 0x1DF01)
    NearCall(cs1, 0xDF04, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_DF04_1DF04:
    // XOR AX,AX (1000_DF04 / 0x1DF04)
    AX = 0;
    State.IncCycles();
    // RET  (1000_DF06 / 0x1DF06)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DF07_01DF07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DF07_1DF07:
    // PUSH word ptr [0x2784] (1000_DF07 / 0x1DF07)
    Stack.Push(UInt16[DS, 0x2784]);
    State.IncCycles();
    // MOV SI,0x1b48 (1000_DF0B / 0x1DF0B)
    SI = 0x1B48;
    State.IncCycles();
    // MOV CX,0x5 (1000_DF0E / 0x1DF0E)
    CX = 0x5;
    State.IncCycles();
    // CALL 0x1000:d1f2 (1000_DF11 / 0x1DF11)
    NearCall(cs1, 0xDF14, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DF14_01DF14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DF14_01DF14(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DF14_1DF14:
    // POP AX (1000_DF14 / 0x1DF14)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c13e (1000_DF15 / 0x1DF15)
    NearCall(cs1, 0xDF18, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_DF18_1DF18:
    // CALL 0x1000:d397 (1000_DF18 / 0x1DF18)
    NearCall(cs1, 0xDF1B, spice86_generated_label_call_target_1000_D397_01D397);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DF1B_01DF1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DF1B_01DF1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DF1B_1DF1B:
    // JMP 0x1000:dbec (1000_DF1B / 0x1DF1B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_DF1E_01DF1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DF1E_1DF1E:
    // CALL 0x1000:de7b (1000_DF1E / 0x1DF1E)
    NearCall(cs1, 0xDF21, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DF21_01DF21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_DF21_01DF21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DF21_1DF21:
    // XOR AL,AL (1000_DF21 / 0x1DF21)
    AL = 0;
    State.IncCycles();
    // TEST byte ptr [0x2942],0x40 (1000_DF23 / 0x1DF23)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    State.IncCycles();
    // JNZ 0x1000:df49 (1000_DF28 / 0x1DF28)
    if(!ZeroFlag) {
      goto label_1000_DF49_1DF49;
    }
    State.IncCycles();
    // MOV AX,0x3 (1000_DF2A / 0x1DF2A)
    AX = 0x3;
    State.IncCycles();
    // INT 0x33 (1000_DF2D / 0x1DF2D)
    Interrupt(0x33);
    State.IncCycles();
    // MOV AX,CX (1000_DF2F / 0x1DF2F)
    AX = CX;
    State.IncCycles();
    // MOV CX,word ptr [0x2580] (1000_DF31 / 0x1DF31)
    CX = UInt16[DS, 0x2580];
    State.IncCycles();
    // SHR AX,CL (1000_DF35 / 0x1DF35)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    State.IncCycles();
    // MOV CL,CH (1000_DF37 / 0x1DF37)
    CL = CH;
    State.IncCycles();
    // SHR DX,CL (1000_DF39 / 0x1DF39)
    // DX >>= CL;
    DX = Alu.Shr16(DX, CL);
    State.IncCycles();
    // MOV CX,AX (1000_DF3B / 0x1DF3B)
    CX = AX;
    State.IncCycles();
    // MOV AL,BL (1000_DF3D / 0x1DF3D)
    AL = BL;
    State.IncCycles();
    // AND AL,0x3 (1000_DF3F / 0x1DF3F)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    State.IncCycles();
    // MOV word ptr [0xdc36],CX (1000_DF41 / 0x1DF41)
    UInt16[DS, 0xDC36] = CX;
    State.IncCycles();
    // MOV word ptr [0xdc38],DX (1000_DF45 / 0x1DF45)
    UInt16[DS, 0xDC38] = DX;
    State.IncCycles();
    label_1000_DF49_1DF49:
    // MOV [0xdc34],AL (1000_DF49 / 0x1DF49)
    UInt8[DS, 0xDC34] = AL;
    State.IncCycles();
    // TEST byte ptr [0x2942],0x80 (1000_DF4C / 0x1DF4C)
    Alu.And8(UInt8[DS, 0x2942], 0x80);
    State.IncCycles();
    // JZ 0x1000:df56 (1000_DF51 / 0x1DF51)
    if(ZeroFlag) {
      goto label_1000_DF56_1DF56;
    }
    State.IncCycles();
    // CALL 0x1000:dd10 (1000_DF53 / 0x1DF53)
    NearCall(cs1, 0xDF56, not_observed_1000_DD10_01DD10);
    State.IncCycles();
    label_1000_DF56_1DF56:
    // MOV SI,0xcec8 (1000_DF56 / 0x1DF56)
    SI = 0xCEC8;
    State.IncCycles();
    // MOV DI,word ptr [0xdc48] (1000_DF59 / 0x1DF59)
    DI = UInt16[DS, 0xDC48];
    State.IncCycles();
    // XOR DX,DX (1000_DF5D / 0x1DF5D)
    DX = 0;
    State.IncCycles();
    // MOV BX,DX (1000_DF5F / 0x1DF5F)
    BX = DX;
    State.IncCycles();
    // MOV AX,DX (1000_DF61 / 0x1DF61)
    AX = DX;
    State.IncCycles();
    // MOV CX,0xd (1000_DF63 / 0x1DF63)
    CX = 0xD;
    State.IncCycles();
    label_1000_DF66_1DF66:
    // LODSB SI (1000_DF66 / 0x1DF66)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,byte ptr [SI + 0x12] (1000_DF67 / 0x1DF67)
    // AL |= UInt8[DS, (ushort)(SI + 0x12)];
    AL = Alu.Or8(AL, UInt8[DS, (ushort)(SI + 0x12)]);
    State.IncCycles();
    // JZ 0x1000:df74 (1000_DF6A / 0x1DF6A)
    if(ZeroFlag) {
      goto label_1000_DF74_1DF74;
    }
    State.IncCycles();
    // OR AH,byte ptr [DI] (1000_DF6C / 0x1DF6C)
    AH |= UInt8[DS, DI];
    State.IncCycles();
    // ADD DX,word ptr [DI + 0x2] (1000_DF6E / 0x1DF6E)
    DX += UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // ADD BX,word ptr [DI + 0x4] (1000_DF71 / 0x1DF71)
    BX += UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    label_1000_DF74_1DF74:
    // ADD DI,0x6 (1000_DF74 / 0x1DF74)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    State.IncCycles();
    // LOOP 0x1000:df66 (1000_DF77 / 0x1DF77)
    if(--CX != 0) {
      goto label_1000_DF66_1DF66;
    }
    State.IncCycles();
    // MOV AL,[0xceba] (1000_DF79 / 0x1DF79)
    AL = UInt8[DS, 0xCEBA];
    State.IncCycles();
    // OR AL,byte ptr [0xce9d] (1000_DF7C / 0x1DF7C)
    // AL |= UInt8[DS, 0xCE9D];
    AL = Alu.Or8(AL, UInt8[DS, 0xCE9D]);
    State.IncCycles();
    // OR AL,byte ptr [0xcee6] (1000_DF80 / 0x1DF80)
    AL |= UInt8[DS, 0xCEE6];
    State.IncCycles();
    // AND AL,0x1 (1000_DF84 / 0x1DF84)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    State.IncCycles();
    // MOV AH,AL (1000_DF86 / 0x1DF86)
    AH = AL;
    State.IncCycles();
    // XCHG byte ptr [0xdc57],AL (1000_DF88 / 0x1DF88)
    byte tmp_1000_DF88 = UInt8[DS, 0xDC57];
    UInt8[DS, 0xDC57] = AL;
    AL = tmp_1000_DF88;
    State.IncCycles();
    // NOT AL (1000_DF8C / 0x1DF8C)
    AL = (byte)~AL;
    State.IncCycles();
    // AND AL,byte ptr [0xdc34] (1000_DF8E / 0x1DF8E)
    // AL &= UInt8[DS, 0xDC34];
    AL = Alu.And8(AL, UInt8[DS, 0xDC34]);
    State.IncCycles();
    // OR AL,AH (1000_DF92 / 0x1DF92)
    // AL |= AH;
    AL = Alu.Or8(AL, AH);
    State.IncCycles();
    // MOV [0xdc34],AL (1000_DF94 / 0x1DF94)
    UInt8[DS, 0xDC34] = AL;
    State.IncCycles();
    // MOV AX,DX (1000_DF97 / 0x1DF97)
    AX = DX;
    State.IncCycles();
    // OR AX,BX (1000_DF99 / 0x1DF99)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    State.IncCycles();
    // JNZ 0x1000:dfb7 (1000_DF9B / 0x1DF9B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_DFB7_01DFB7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV [0xdc51],AX (1000_DF9D / 0x1DF9D)
    UInt16[DS, 0xDC51] = AX;
    State.IncCycles();
    // MOV [0xdc53],AX (1000_DFA0 / 0x1DFA0)
    UInt16[DS, 0xDC53] = AX;
    State.IncCycles();
    // MOV [0xdc55],AX (1000_DFA3 / 0x1DFA3)
    UInt16[DS, 0xDC55] = AX;
    State.IncCycles();
    label_1000_DFA6_1DFA6:
    // RET  (1000_DFA6 / 0x1DFA6)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_DFB7_01DFB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_DFB7_1DFB7:
    // CMP byte ptr [0xce9e],0xff (1000_DFB7 / 0x1DFB7)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:dfc1 (1000_DFBC / 0x1DFBC)
    if(!ZeroFlag) {
      goto label_1000_DFC1_1DFC1;
    }
    State.IncCycles();
    // JMP 0x1000:e1d1 (1000_DFBE / 0x1DFBE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_E1D1_01E1D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_DFC1_1DFC1:
    // MOV DI,0xdfa9 (1000_DFC1 / 0x1DFC1)
    DI = 0xDFA9;
    State.IncCycles();
    // OR DL,DL (1000_DFC4 / 0x1DFC4)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x1000:dfdb (1000_DFC6 / 0x1DFC6)
    if(ZeroFlag) {
      goto label_1000_DFDB_1DFDB;
    }
    State.IncCycles();
    // JNS 0x1000:dfcd (1000_DFC8 / 0x1DFC8)
    if(!SignFlag) {
      goto label_1000_DFCD_1DFCD;
    }
    State.IncCycles();
    // ADD DI,0x6 (1000_DFCA / 0x1DFCA)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    State.IncCycles();
    label_1000_DFCD_1DFCD:
    // OR BL,BL (1000_DFCD / 0x1DFCD)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JZ 0x1000:dfe7 (1000_DFCF / 0x1DFCF)
    if(ZeroFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    State.IncCycles();
    // LEA DI,[DI + -0x2] (1000_DFD1 / 0x1DFD1)
    DI = (ushort)(DI - 0x2);
    State.IncCycles();
    // JS 0x1000:dfe7 (1000_DFD4 / 0x1DFD4)
    if(SignFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    State.IncCycles();
    // ADD DI,0x4 (1000_DFD6 / 0x1DFD6)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    State.IncCycles();
    // JMP 0x1000:dfe7 (1000_DFD9 / 0x1DFD9)
    goto label_1000_DFE7_1DFE7;
    State.IncCycles();
    label_1000_DFDB_1DFDB:
    // MOV DI,0xdfb3 (1000_DFDB / 0x1DFDB)
    DI = 0xDFB3;
    State.IncCycles();
    // OR BL,BL (1000_DFDE / 0x1DFDE)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JZ 0x1000:dfa6 (1000_DFE0 / 0x1DFE0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_DFA6 / 0x1DFA6)
      return NearRet();
    }
    State.IncCycles();
    // JS 0x1000:dfe7 (1000_DFE2 / 0x1DFE2)
    if(SignFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    State.IncCycles();
    // ADD DI,0x2 (1000_DFE4 / 0x1DFE4)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    label_1000_DFE7_1DFE7:
    // MOV BX,word ptr CS:[DI] (1000_DFE7 / 0x1DFE7)
    BX = UInt16[cs1, DI];
    State.IncCycles();
    // SUB SP,0xa (1000_DFEA / 0x1DFEA)
    // SP -= 0xA;
    SP = Alu.Sub16(SP, 0xA);
    State.IncCycles();
    // MOV BP,SP (1000_DFED / 0x1DFED)
    BP = SP;
    State.IncCycles();
    // MOV word ptr [BP + 0x0],BX (1000_DFEF / 0x1DFEF)
    UInt16[SS, BP] = BX;
    State.IncCycles();
    // CALL 0x1000:de4e (1000_DFF2 / 0x1DFF2)
    NearCall(cs1, 0xDFF5, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    State.IncCycles();
    // MOV DX,word ptr [0xdc36] (1000_DFF5 / 0x1DFF5)
    DX = UInt16[DS, 0xDC36];
    State.IncCycles();
    // MOV BX,word ptr [0xdc38] (1000_DFF9 / 0x1DFF9)
    BX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // MOV DI,0x1ae4 (1000_DFFD / 0x1DFFD)
    DI = 0x1AE4;
    State.IncCycles();
    // MOV CX,word ptr [DI] (1000_E000 / 0x1E000)
    CX = UInt16[DS, DI];
    State.IncCycles();
    // MOV word ptr [BP + 0x2],0x8000 (1000_E002 / 0x1E002)
    UInt16[SS, (ushort)(BP + 0x2)] = 0x8000;
    State.IncCycles();
    // ADD DI,0x2 (1000_E007 / 0x1E007)
    DI += 0x2;
    State.IncCycles();
    label_1000_E00A_1E00A:
    // TEST byte ptr [DI + 0x8],0x80 (1000_E00A / 0x1E00A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x8)], 0x80);
    State.IncCycles();
    // JZ 0x1000:e02c (1000_E00E / 0x1E00E)
    if(ZeroFlag) {
      goto label_1000_E02C_1E02C;
    }
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_E010 / 0x1E010)
    NearCall(cs1, 0xE013, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    // JC 0x1000:e02c (1000_E013 / 0x1E013)
    if(CarryFlag) {
      goto label_1000_E02C_1E02C;
    }
    State.IncCycles();
    // CALL 0x1000:e159 (1000_E015 / 0x1E015)
    NearCall(cs1, 0xE018, not_observed_1000_E159_01E159);
    State.IncCycles();
    // CALL word ptr [BP + 0x0] (1000_E018 / 0x1E018)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E018 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E018) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E018));
        break;
    }
    State.IncCycles();
    // CMP AX,word ptr [BP + 0x2] (1000_E01B / 0x1E01B)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:e02c (1000_E01E / 0x1E01E)
    if(!CarryFlag) {
      goto label_1000_E02C_1E02C;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_E020 / 0x1E020)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // CALL 0x1000:e159 (1000_E023 / 0x1E023)
    NearCall(cs1, 0xE026, not_observed_1000_E159_01E159);
    State.IncCycles();
    // MOV word ptr [BP + 0x4],AX (1000_E026 / 0x1E026)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0x6],SI (1000_E029 / 0x1E029)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    State.IncCycles();
    label_1000_E02C_1E02C:
    // ADD DI,0xe (1000_E02C / 0x1E02C)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    State.IncCycles();
    // LOOP 0x1000:e00a (1000_E02F / 0x1E02F)
    if(--CX != 0) {
      goto label_1000_E00A_1E00A;
    }
    State.IncCycles();
    // CALL 0x1000:e068 (1000_E031 / 0x1E031)
    NearCall(cs1, 0xE034, not_observed_1000_E068_01E068);
    State.IncCycles();
    // CALL 0x1000:e0a2 (1000_E034 / 0x1E034)
    NearCall(cs1, 0xE037, not_observed_1000_E0A2_01E0A2);
    State.IncCycles();
    // CALL 0x1000:e0db (1000_E037 / 0x1E037)
    NearCall(cs1, 0xE03A, not_observed_1000_E0DB_01E0DB);
    State.IncCycles();
    // CALL 0x1000:e11c (1000_E03A / 0x1E03A)
    NearCall(cs1, 0xE03D, not_observed_1000_E11C_01E11C);
    State.IncCycles();
    // CMP word ptr [BP + 0x2],0x0 (1000_E03D / 0x1E03D)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], 0x0);
    State.IncCycles();
    // JS 0x1000:e064 (1000_E041 / 0x1E041)
    if(SignFlag) {
      goto label_1000_E064_1E064;
    }
    State.IncCycles();
    // MOV byte ptr [0xceba],0x0 (1000_E043 / 0x1E043)
    UInt8[DS, 0xCEBA] = 0x0;
    State.IncCycles();
    // OR byte ptr [0xce9d],0x0 (1000_E048 / 0x1E048)
    // UInt8[DS, 0xCE9D] |= 0x0;
    UInt8[DS, 0xCE9D] = Alu.Or8(UInt8[DS, 0xCE9D], 0x0);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x4] (1000_E04D / 0x1E04D)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV [0xdc4c],AX (1000_E050 / 0x1E050)
    UInt16[DS, 0xDC4C] = AX;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x6] (1000_E053 / 0x1E053)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // MOV [0xdc4e],AX (1000_E056 / 0x1E056)
    UInt16[DS, 0xDC4E] = AX;
    State.IncCycles();
    // MOV byte ptr [0xdc4b],0x64 (1000_E059 / 0x1E059)
    UInt8[DS, 0xDC4B] = 0x64;
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_E05E / 0x1E05E)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc4a],AL (1000_E061 / 0x1E061)
    UInt8[DS, 0xDC4A] = AL;
    State.IncCycles();
    label_1000_E064_1E064:
    // ADD SP,0xa (1000_E064 / 0x1E064)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    State.IncCycles();
    // RET  (1000_E067 / 0x1E067)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E068_01E068(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E068_1E068:
    // PUSH BP (1000_E068 / 0x1E068)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:d41b (1000_E069 / 0x1E069)
    NearCall(cs1, 0xE06C, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    // CMP BP,0x201a (1000_E06C / 0x1E06C)
    Alu.Sub16(BP, 0x201A);
    State.IncCycles();
    // POP BP (1000_E070 / 0x1E070)
    BP = Stack.Pop();
    State.IncCycles();
    // JNZ 0x1000:e0a1 (1000_E071 / 0x1E071)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0A1 / 0x1E0A1)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x28e9 (1000_E073 / 0x1E073)
    DI = 0x28E9;
    State.IncCycles();
    label_1000_E076_1E076:
    // MOV SI,word ptr [DI + 0x2] (1000_E076 / 0x1E076)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_E079 / 0x1E079)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // CMP AX,DX (1000_E07B / 0x1E07B)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JNZ 0x1000:e083 (1000_E07D / 0x1E07D)
    if(!ZeroFlag) {
      goto label_1000_E083_1E083;
    }
    State.IncCycles();
    // CMP SI,BX (1000_E07F / 0x1E07F)
    Alu.Sub16(SI, BX);
    State.IncCycles();
    // JZ 0x1000:e099 (1000_E081 / 0x1E081)
    if(ZeroFlag) {
      goto label_1000_E099_1E099;
    }
    State.IncCycles();
    label_1000_E083_1E083:
    // CALL word ptr [BP + 0x0] (1000_E083 / 0x1E083)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E083 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E083) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E083));
        break;
    }
    State.IncCycles();
    // CMP AX,word ptr [BP + 0x2] (1000_E086 / 0x1E086)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:e099 (1000_E089 / 0x1E089)
    if(!CarryFlag) {
      goto label_1000_E099_1E099;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_E08B / 0x1E08B)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_E08E / 0x1E08E)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // MOV word ptr [BP + 0x4],AX (1000_E090 / 0x1E090)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    State.IncCycles();
    // MOV SI,word ptr [DI + 0x2] (1000_E093 / 0x1E093)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV word ptr [BP + 0x6],SI (1000_E096 / 0x1E096)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    State.IncCycles();
    label_1000_E099_1E099:
    // ADD DI,0x4 (1000_E099 / 0x1E099)
    DI += 0x4;
    State.IncCycles();
    // CMP word ptr [DI],-0x1 (1000_E09C / 0x1E09C)
    Alu.Sub16(UInt16[DS, DI], 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:e076 (1000_E09F / 0x1E09F)
    if(!ZeroFlag) {
      goto label_1000_E076_1E076;
    }
    State.IncCycles();
    label_1000_E0A1_1E0A1:
    // RET  (1000_E0A1 / 0x1E0A1)
    return NearRet();
  }
  
}
