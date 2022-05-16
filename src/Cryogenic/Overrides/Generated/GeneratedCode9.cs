namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_D72B_01D72B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD735: goto label_1000_D735_1D735;break; // Target of external jump from 0x13070
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
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
  
  public Action spice86_generated_label_call_target_1000_D741_01D741(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_D759_1D759:
    // RET  (1000_D759 / 0x1D759)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D75A_01D75A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D75A_1D75A:
    // MOV SI,0x1c36 (1000_D75A / 0x1D75A)
    SI = 0x1C36;
    // CALL 0x1000:d795 (1000_D75D / 0x1D75D)
    NearCall(cs1, 0xD760, spice86_generated_label_call_target_1000_D795_01D795);
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
  
  public Action spice86_generated_label_ret_target_1000_D763_01D763(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D792_01D792(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D795_01D795(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D7B2_01D7B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D7B7_01D7B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D7B7_1D7B7:
    // MOV AX,[0xce7a] (1000_D7B7 / 0x1D7B7)
    AX = UInt16[DS, 0xCE7A];
    // SHL AX,0x1 (1000_D7BA / 0x1D7BA)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_D7BC / 0x1D7BC)
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
    AL = Alu.Dec8(AL);
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
    AH = Alu.Dec8(AH);
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
      goto label_1000_D810_1D810;
    }
    // PUSH word ptr [0x2784] (1000_D7FC / 0x1D7FC)
    Stack.Push(UInt16[DS, 0x2784]);
    // CALL 0x1000:c137 (1000_D800 / 0x1D800)
    NearCall(cs1, 0xD803, spice86_generated_label_call_target_1000_C137_01C137);
    // CALL 0x1000:dbb2 (1000_D803 / 0x1D803)
    NearCall(cs1, 0xD806, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:d763 (1000_D806 / 0x1D806)
    NearCall(cs1, 0xD809, spice86_generated_label_ret_target_1000_D763_01D763);
    // CALL 0x1000:dbec (1000_D809 / 0x1D809)
    NearCall(cs1, 0xD80C, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
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
  
  public Action spice86_generated_label_call_target_1000_D815_01D815(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD820: goto label_1000_D820_1D820;break; // Target of external jump from 0x1D891, 0x1D941, 0x1D914, 0x1D8D7, 0x1D958
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D815_1D815:
    // MOV AX,[0xce7a] (1000_D815 / 0x1D815)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc68],AX (1000_D818 / 0x1D818)
    UInt16[DS, 0xDC68] = AX;
    // MOV byte ptr [0xdc4b],0x0 (1000_D81B / 0x1D81B)
    UInt8[DS, 0xDC4B] = 0x0;
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
    throw FailAsUntested("Could not find a valid function at address 1000_B270 / 0x1B270");
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
    throw FailAsUntested("Could not find a valid function at address 1000_0D8E / 0x10D8E");
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
    throw FailAsUntested("Could not find a valid function at address 1000_D962 / 0x1D962");
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
      case 0x5C03 : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_5C03_015C03); break;
      case 0xBC1F : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_BC1F_01BC1F); break;
      case 0x4586 : NearCall(cs1, 0xD891, spice86_generated_label_call_target_1000_4586_014586); break;
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
    throw FailAsUntested("Could not find a valid function at address 1000_1707 / 0x11707");
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
    
    // SHR AX,0x1 (1000_D8B8 / 0x1D8B8)
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
      case 0xA5DF : NearCall(cs1, 0xD8D7, spice86_generated_label_call_target_1000_A5DF_01A5DF); break;
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
    // JMP 0x1000:d92b (1000_D8F2 / 0x1D8F2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D918_01D918, 0x1D92B - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_D918_01D918, 0x1D944 - cs1 * 0x10)) {
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
      if(JumpDispatcher.Jump(split_1000_D918_01D918, 0)) {
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
      case 0xA576 : throw FailAsUntested("Could not find a valid function at address 1000_A576 / 0x1A576");
      case 0x450E : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_450E_01450E); break;
      case 0xD917 : NearCall(cs1, 0xD914, spice86_generated_label_call_target_1000_D917_01D917); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D911));
        break;
    }
    label_1000_D914_1D914:
    // JMP 0x1000:d820 (1000_D914 / 0x1D914)
    goto label_1000_D820_1D820;
  }
  
  public Action spice86_generated_label_call_target_1000_D917_01D917(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D917_1D917:
    // RET  (1000_D917 / 0x1D917)
    return NearRet();
  }
  
  public Action split_1000_D918_01D918(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD944: goto label_1000_D944_1D944;break; // Target of external jump from 0x1D8FC
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
      case 0xD42F : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D42F_01D42F); break;
      case 0xD443 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D443_01D443); break;
      case 0xB8C6 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_B8C6_01B8C6); break;
      case 0xD439 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D439_01D439); break;
      case 0xD434 : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_D434_01D434); break;
      case 0x3F1F : NearCall(cs1, 0xD941, spice86_generated_label_call_target_1000_3F1F_013F1F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D93E));
        break;
    }
    label_1000_D941_1D941:
    // JMP 0x1000:d820 (1000_D941 / 0x1D941)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D815_01D815, 0x1D820 - cs1 * 0x10)) {
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
      case 0x599F : throw FailAsUntested("Could not find a valid function at address 1000_599F / 0x1599F");
      case 0xF66 : NearCall(cs1, 0xD958, spice86_generated_label_call_target_1000_0F66_010F66); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D955));
        break;
    }
    label_1000_D958_1D958:
    // JMP 0x1000:d820 (1000_D958 / 0x1D958)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D815_01D815, 0x1D820 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D95B_01D95B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D95E_01D95E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D95E_1D95E:
    // MOV [0x2570],AX (1000_D95E / 0x1D95E)
    UInt16[DS, 0x2570] = AX;
    // RET  (1000_D961 / 0x1D961)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D9D2_01D9D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D9D2_1D9D2:
    // CALL 0x1000:ace6 (1000_D9D2 / 0x1D9D2)
    NearCall(cs1, 0xD9D5, spice86_generated_label_call_target_1000_ACE6_01ACE6);
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
      case 0x6B34 : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_6B34_016B34); break;
      case 0xB9AE : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_B9AE_01B9AE); break;
      case 0xBE57 : NearCall(cs1, 0xDA1B, spice86_generated_label_ret_target_1000_BE57_01BE57); break;
      case 0x99BE : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_99BE_0199BE); break;
      case 0x46B5 : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_46B5_0146B5); break;
      case 0x44AB : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_44AB_0144AB); break;
      case 0x3916 : NearCall(cs1, 0xDA1B, spice86_generated_label_call_target_1000_3916_013916); break;
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
  
  public Action spice86_generated_label_call_target_1000_DA25_01DA25(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AX = Alu.Inc16(AX);
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
    AX = Alu.Dec16(AX);
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
  
  public Action spice86_generated_label_call_target_1000_DA53_01DA53(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DA5F_01DA5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Dec16(UInt16[SS, (ushort)(BP + 0x2)]);
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
  
  public Action spice86_generated_label_call_target_1000_DAA3_01DAA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DAA3_1DAA3:
    // MOV word ptr [0xdc58],0x0 (1000_DAA3 / 0x1DAA3)
    UInt16[DS, 0xDC58] = 0x0;
    // RET  (1000_DAA9 / 0x1DAA9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DAAA_01DAAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DAAA_1DAAA:
    // MOV word ptr [0xdc58],SI (1000_DAAA / 0x1DAAA)
    UInt16[DS, 0xDC58] = SI;
    // RET  (1000_DAAE / 0x1DAAE)
    return NearRet();
  }
  
  public Action split_1000_DAAF_01DAAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DAE3_01DAE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DB03_01DB03(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_DB11_1DB11:
    // JMP 0x1000:dbec (1000_DB11 / 0x1DB11)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_DB14_01DB14(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DB44_01DB44(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DB4C_01DB4C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DB67_01DB67(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_DB74_01DB74(int loadOffset) {
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
  
  public Action spice86_generated_label_call_target_1000_DBB2_01DBB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DBB2_1DBB2:
    // PUSH AX (1000_DBB2 / 0x1DBB2)
    Stack.Push(AX);
    // MOV AL,[0xdc46] (1000_DBB3 / 0x1DBB3)
    AL = UInt8[DS, 0xDC46];
    // DEC byte ptr [0xdc46] (1000_DBB6 / 0x1DBB6)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    // JS 0x1000:dbc0 (1000_DBBA / 0x1DBBA)
    if(SignFlag) {
      goto label_1000_DBC0_1DBC0;
    }
    // INC byte ptr [0xdc46] (1000_DBBC / 0x1DBBC)
    UInt8[DS, 0xDC46] = Alu.Inc8(UInt8[DS, 0xDC46]);
    label_1000_DBC0_1DBC0:
    // OR AL,AL (1000_DBC0 / 0x1DBC0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:dbc8 (1000_DBC2 / 0x1DBC2)
    if(SignFlag) {
      goto label_1000_DBC8_1DBC8;
    }
    // CALLF [0x38c5] (1000_DBC4 / 0x1DBC4)
    // Indirect call to [0x38c5], generating possible targets from emulator records
    uint targetAddress_1000_DBC4 = (uint)(UInt16[DS, 0x38C7] * 0x10 + UInt16[DS, 0x38C5] - cs1 * 0x10);
    switch(targetAddress_1000_DBC4) {
      case 0x235BC : FarCall(cs1, 0xDBC8, spice86_generated_label_call_target_334B_010C_0335BC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DBC4));
        break;
    }
    label_1000_DBC8_1DBC8:
    // POP AX (1000_DBC8 / 0x1DBC8)
    AX = Stack.Pop();
    // RET  (1000_DBC9 / 0x1DBC9)
    return NearRet();
  }
  
  public Action split_1000_DBCA_01DBCA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DBCA_1DBCA:
    // MOV AX,[0xdc44] (1000_DBCA / 0x1DBCA)
    AX = UInt16[DS, 0xDC44];
    // CMP AX,0x98 (1000_DBCD / 0x1DBCD)
    Alu.Sub16(AX, 0x98);
    // JNC 0x1000:dbe2 (1000_DBD0 / 0x1DBD0)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_DBE2 / 0x1DBE2)
      return NearRet();
    }
    // CMP AX,0x88 (1000_DBD2 / 0x1DBD2)
    Alu.Sub16(AX, 0x88);
    // JNC 0x1000:dbb2 (1000_DBD5 / 0x1DBD5)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DBB2_01DBB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC byte ptr [0xdc46] (1000_DBD7 / 0x1DBD7)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    // JS 0x1000:dbe2 (1000_DBDB / 0x1DBDB)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_DBE2 / 0x1DBE2)
      return NearRet();
    }
    // MOV byte ptr [0xdc46],0x80 (1000_DBDD / 0x1DBDD)
    UInt8[DS, 0xDC46] = 0x80;
    label_1000_DBE2_1DBE2:
    // RET  (1000_DBE2 / 0x1DBE2)
    return NearRet();
  }
  
  public Action split_1000_DBE3_01DBE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DBE3_1DBE3:
    // MOV AX,[0xdc44] (1000_DBE3 / 0x1DBE3)
    AX = UInt16[DS, 0xDC44];
    // CMP AX,0x98 (1000_DBE6 / 0x1DBE6)
    Alu.Sub16(AX, 0x98);
    // JC 0x1000:dbec (1000_DBE9 / 0x1DBE9)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_DBEB / 0x1DBEB)
    return NearRet();
  }
  
  public Action spice86_generated_label_ret_target_1000_DBEC_01DBEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DBEC_1DBEC:
    // INC byte ptr [0xdc46] (1000_DBEC / 0x1DBEC)
    UInt8[DS, 0xDC46] = Alu.Inc8(UInt8[DS, 0xDC46]);
    // JS 0x1000:dc1a (1000_DBF0 / 0x1DBF0)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_DC1A / 0x1DC1A)
      return NearRet();
    }
    // JNZ 0x1000:dc1b (1000_DBF2 / 0x1DBF2)
    if(!ZeroFlag) {
      goto label_1000_DC1B_1DC1B;
    }
    // PUSH AX (1000_DBF4 / 0x1DBF4)
    Stack.Push(AX);
    // PUSH BX (1000_DBF5 / 0x1DBF5)
    Stack.Push(BX);
    // PUSH CX (1000_DBF6 / 0x1DBF6)
    Stack.Push(CX);
    // PUSH DX (1000_DBF7 / 0x1DBF7)
    Stack.Push(DX);
    // PUSH SI (1000_DBF8 / 0x1DBF8)
    Stack.Push(SI);
    // PUSH DI (1000_DBF9 / 0x1DBF9)
    Stack.Push(DI);
    // PUSH BP (1000_DBFA / 0x1DBFA)
    Stack.Push(BP);
    // MOV DX,word ptr [0xdc36] (1000_DBFB / 0x1DBFB)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DBFF / 0x1DBFF)
    BX = UInt16[DS, 0xDC38];
    // MOV word ptr [0xdc42],DX (1000_DC03 / 0x1DC03)
    UInt16[DS, 0xDC42] = DX;
    // MOV word ptr [0xdc44],BX (1000_DC07 / 0x1DC07)
    UInt16[DS, 0xDC44] = BX;
    // MOV SI,word ptr [0x2582] (1000_DC0B / 0x1DC0B)
    SI = UInt16[DS, 0x2582];
    // CALLF [0x38c1] (1000_DC0F / 0x1DC0F)
    // Indirect call to [0x38c1], generating possible targets from emulator records
    uint targetAddress_1000_DC0F = (uint)(UInt16[DS, 0x38C3] * 0x10 + UInt16[DS, 0x38C1] - cs1 * 0x10);
    switch(targetAddress_1000_DC0F) {
      case 0x235B9 : FarCall(cs1, 0xDC13, spice86_generated_label_call_target_334B_0109_0335B9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC0F));
        break;
    }
    label_1000_DC13_1DC13:
    // POP BP (1000_DC13 / 0x1DC13)
    BP = Stack.Pop();
    // POP DI (1000_DC14 / 0x1DC14)
    DI = Stack.Pop();
    // POP SI (1000_DC15 / 0x1DC15)
    SI = Stack.Pop();
    // POP DX (1000_DC16 / 0x1DC16)
    DX = Stack.Pop();
    // POP CX (1000_DC17 / 0x1DC17)
    CX = Stack.Pop();
    // POP BX (1000_DC18 / 0x1DC18)
    BX = Stack.Pop();
    // POP AX (1000_DC19 / 0x1DC19)
    AX = Stack.Pop();
    label_1000_DC1A_1DC1A:
    // RET  (1000_DC1A / 0x1DC1A)
    return NearRet();
    label_1000_DC1B_1DC1B:
    // DEC byte ptr [0xdc46] (1000_DC1B / 0x1DC1B)
    UInt8[DS, 0xDC46] = Alu.Dec8(UInt8[DS, 0xDC46]);
    // RET  (1000_DC1F / 0x1DC1F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DC20_01DC20(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DC20_1DC20:
    // PUSH AX (1000_DC20 / 0x1DC20)
    Stack.Push(AX);
    // PUSH BX (1000_DC21 / 0x1DC21)
    Stack.Push(BX);
    // PUSH CX (1000_DC22 / 0x1DC22)
    Stack.Push(CX);
    // PUSH DX (1000_DC23 / 0x1DC23)
    Stack.Push(DX);
    // PUSH SI (1000_DC24 / 0x1DC24)
    Stack.Push(SI);
    // PUSH DI (1000_DC25 / 0x1DC25)
    Stack.Push(DI);
    // PUSH BP (1000_DC26 / 0x1DC26)
    Stack.Push(BP);
    // MOV DX,word ptr [0xdc36] (1000_DC27 / 0x1DC27)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DC2B / 0x1DC2B)
    BX = UInt16[DS, 0xDC38];
    // CALL 0x1000:dc6a (1000_DC2F / 0x1DC2F)
    NearCall(cs1, 0xDC32, spice86_generated_label_call_target_1000_DC6A_01DC6A);
    label_1000_DC32_1DC32:
    // MOV SI,BP (1000_DC32 / 0x1DC32)
    SI = BP;
    // XCHG word ptr [0x2582],BP (1000_DC34 / 0x1DC34)
    ushort tmp_1000_DC34 = UInt16[DS, 0x2582];
    UInt16[DS, 0x2582] = BP;
    BP = tmp_1000_DC34;
    // XOR AL,AL (1000_DC38 / 0x1DC38)
    AL = 0;
    // XCHG byte ptr [0xdc46],AL (1000_DC3A / 0x1DC3A)
    byte tmp_1000_DC3A = UInt8[DS, 0xDC46];
    UInt8[DS, 0xDC46] = AL;
    AL = tmp_1000_DC3A;
    // OR AL,AL (1000_DC3E / 0x1DC3E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:dc56 (1000_DC40 / 0x1DC40)
    if(SignFlag) {
      goto label_1000_DC56_1DC56;
    }
    // CMP DX,word ptr [0xdc42] (1000_DC42 / 0x1DC42)
    Alu.Sub16(DX, UInt16[DS, 0xDC42]);
    // JNZ 0x1000:dc52 (1000_DC46 / 0x1DC46)
    if(!ZeroFlag) {
      goto label_1000_DC52_1DC52;
    }
    // CMP BX,word ptr [0xdc44] (1000_DC48 / 0x1DC48)
    Alu.Sub16(BX, UInt16[DS, 0xDC44]);
    // JNZ 0x1000:dc52 (1000_DC4C / 0x1DC4C)
    if(!ZeroFlag) {
      goto label_1000_DC52_1DC52;
    }
    // CMP SI,BP (1000_DC4E / 0x1DC4E)
    Alu.Sub16(SI, BP);
    // JZ 0x1000:dc62 (1000_DC50 / 0x1DC50)
    if(ZeroFlag) {
      goto label_1000_DC62_1DC62;
    }
    label_1000_DC52_1DC52:
    // CALLF [0x38c5] (1000_DC52 / 0x1DC52)
    // Indirect call to [0x38c5], generating possible targets from emulator records
    uint targetAddress_1000_DC52 = (uint)(UInt16[DS, 0x38C7] * 0x10 + UInt16[DS, 0x38C5] - cs1 * 0x10);
    switch(targetAddress_1000_DC52) {
      case 0x235BC : FarCall(cs1, 0xDC56, spice86_generated_label_call_target_334B_010C_0335BC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC52));
        break;
    }
    label_1000_DC56_1DC56:
    // MOV word ptr [0xdc42],DX (1000_DC56 / 0x1DC56)
    UInt16[DS, 0xDC42] = DX;
    // MOV word ptr [0xdc44],BX (1000_DC5A / 0x1DC5A)
    UInt16[DS, 0xDC44] = BX;
    // CALLF [0x38c1] (1000_DC5E / 0x1DC5E)
    // Indirect call to [0x38c1], generating possible targets from emulator records
    uint targetAddress_1000_DC5E = (uint)(UInt16[DS, 0x38C3] * 0x10 + UInt16[DS, 0x38C1] - cs1 * 0x10);
    switch(targetAddress_1000_DC5E) {
      case 0x235B9 : FarCall(cs1, 0xDC62, spice86_generated_label_call_target_334B_0109_0335B9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DC5E));
        break;
    }
    label_1000_DC62_1DC62:
    // POP BP (1000_DC62 / 0x1DC62)
    BP = Stack.Pop();
    // POP DI (1000_DC63 / 0x1DC63)
    DI = Stack.Pop();
    // POP SI (1000_DC64 / 0x1DC64)
    SI = Stack.Pop();
    // POP DX (1000_DC65 / 0x1DC65)
    DX = Stack.Pop();
    // POP CX (1000_DC66 / 0x1DC66)
    CX = Stack.Pop();
    // POP BX (1000_DC67 / 0x1DC67)
    BX = Stack.Pop();
    // POP AX (1000_DC68 / 0x1DC68)
    AX = Stack.Pop();
    // RET  (1000_DC69 / 0x1DC69)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DC6A_01DC6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DC6A_1DC6A:
    // CMP byte ptr [0x28be],0x0 (1000_DC6A / 0x1DC6A)
    Alu.Sub8(UInt8[DS, 0x28BE], 0x0);
    // MOV BP,0x25c8 (1000_DC6F / 0x1DC6F)
    BP = 0x25C8;
    // JNZ 0x1000:dcdf (1000_DC72 / 0x1DC72)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV BP,0x2584 (1000_DC74 / 0x1DC74)
    BP = 0x2584;
    // CMP byte ptr [0x4723],0x0 (1000_DC77 / 0x1DC77)
    Alu.Sub8(UInt8[DS, 0x4723], 0x0);
    // JNZ 0x1000:dcdf (1000_DC7C / 0x1DC7C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV DI,word ptr [0xdc58] (1000_DC7E / 0x1DC7E)
    DI = UInt16[DS, 0xDC58];
    // OR DI,DI (1000_DC82 / 0x1DC82)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:dcdf (1000_DC84 / 0x1DC84)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // CMP BX,0x9b (1000_DC86 / 0x1DC86)
    Alu.Sub16(BX, 0x9B);
    // JGE 0x1000:dcdf (1000_DC8A / 0x1DC8A)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // CALL 0x1000:d6fe (1000_DC8C / 0x1DC8C)
    NearCall(cs1, 0xDC8F, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_DC8F_1DC8F:
    // MOV BP,0x25c8 (1000_DC8F / 0x1DC8F)
    BP = 0x25C8;
    // JC 0x1000:dcdf (1000_DC92 / 0x1DC92)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // CMP BX,word ptr [DI + 0x2] (1000_DC94 / 0x1DC94)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JL 0x1000:dcb9 (1000_DC97 / 0x1DC97)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DCB9_1DCB9;
    }
    // CMP BX,word ptr [DI + 0x6] (1000_DC99 / 0x1DC99)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JGE 0x1000:dcb9 (1000_DC9C / 0x1DC9C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DCB9_1DCB9;
    }
    // MOV BP,0x26d8 (1000_DC9E / 0x1DC9E)
    BP = 0x26D8;
    // MOV AX,word ptr [DI] (1000_DCA1 / 0x1DCA1)
    AX = UInt16[DS, DI];
    // SUB AX,DX (1000_DCA3 / 0x1DCA3)
    AX -= DX;
    
    // CMP AX,0x32 (1000_DCA5 / 0x1DCA5)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:dcdf (1000_DCA8 / 0x1DCA8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV BP,0x2650 (1000_DCAA / 0x1DCAA)
    BP = 0x2650;
    // MOV AX,DX (1000_DCAD / 0x1DCAD)
    AX = DX;
    // SUB AX,word ptr [DI + 0x4] (1000_DCAF / 0x1DCAF)
    AX -= UInt16[DS, (ushort)(DI + 0x4)];
    
    // CMP AX,0x32 (1000_DCB2 / 0x1DCB2)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:dcdf (1000_DCB5 / 0x1DCB5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // JMP 0x1000:dcdc (1000_DCB7 / 0x1DCB7)
    goto label_1000_DCDC_1DCDC;
    label_1000_DCB9_1DCB9:
    // CMP DX,word ptr [DI] (1000_DCB9 / 0x1DCB9)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JL 0x1000:dcdc (1000_DCBB / 0x1DCBB)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DCDC_1DCDC;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_DCBD / 0x1DCBD)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JGE 0x1000:dcdc (1000_DCC0 / 0x1DCC0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_DCDC_1DCDC;
    }
    // MOV BP,0x260c (1000_DCC2 / 0x1DCC2)
    BP = 0x260C;
    // MOV AX,word ptr [DI + 0x2] (1000_DCC5 / 0x1DCC5)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    // SUB AX,BX (1000_DCC8 / 0x1DCC8)
    AX -= BX;
    
    // CMP AX,0x19 (1000_DCCA / 0x1DCCA)
    Alu.Sub16(AX, 0x19);
    // JC 0x1000:dcdf (1000_DCCD / 0x1DCCD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    // MOV BP,0x2694 (1000_DCCF / 0x1DCCF)
    BP = 0x2694;
    // MOV AX,BX (1000_DCD2 / 0x1DCD2)
    AX = BX;
    // SUB AX,word ptr [DI + 0x6] (1000_DCD4 / 0x1DCD4)
    AX -= UInt16[DS, (ushort)(DI + 0x6)];
    
    // CMP AX,0x19 (1000_DCD7 / 0x1DCD7)
    Alu.Sub16(AX, 0x19);
    // JC 0x1000:dcdf (1000_DCDA / 0x1DCDA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_DCDF / 0x1DCDF)
      return NearRet();
    }
    label_1000_DCDC_1DCDC:
    // MOV BP,0x2584 (1000_DCDC / 0x1DCDC)
    BP = 0x2584;
    label_1000_DCDF_1DCDF:
    // RET  (1000_DCDF / 0x1DCDF)
    return NearRet();
  }
  
  public Action read_game_port_ida_1000_DCE0_1DCE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DCE0_1DCE0:
    // MOV DX,0x201 (1000_DCE0 / 0x1DCE0)
    DX = 0x201;
    // PUSHF  (1000_DCE3 / 0x1DCE3)
    Stack.Push(FlagRegister);
    // CLI  (1000_DCE4 / 0x1DCE4)
    InterruptFlag = false;
    // OUT DX,AL (1000_DCE5 / 0x1DCE5)
    Cpu.Out8(DX, AL);
    // XOR BX,BX (1000_DCE6 / 0x1DCE6)
    BX = 0;
    // MOV CX,BX (1000_DCE8 / 0x1DCE8)
    CX = BX;
    // MOV DI,0x800 (1000_DCEA / 0x1DCEA)
    DI = 0x800;
    label_1000_DCED_1DCED:
    // IN AL,DX (1000_DCED / 0x1DCED)
    AL = Cpu.In8(DX);
    // MOV AH,AL (1000_DCEE / 0x1DCEE)
    AH = AL;
    // SHR AH,0x1 (1000_DCF0 / 0x1DCF0)
    AH >>= 0x1;
    
    // AND AX,0x101 (1000_DCF2 / 0x1DCF2)
    // AX &= 0x101;
    AX = Alu.And16(AX, 0x101);
    // JZ 0x1000:dd09 (1000_DCF5 / 0x1DCF5)
    if(ZeroFlag) {
      goto label_1000_DD09_1DD09;
    }
    // ADD CL,AL (1000_DCF7 / 0x1DCF7)
    // CL += AL;
    CL = Alu.Add8(CL, AL);
    // ADC CH,0x0 (1000_DCF9 / 0x1DCF9)
    CH = Alu.Adc8(CH, 0x0);
    // ADD BL,AH (1000_DCFC / 0x1DCFC)
    // BL += AH;
    BL = Alu.Add8(BL, AH);
    // ADC BH,0x0 (1000_DCFE / 0x1DCFE)
    BH = Alu.Adc8(BH, 0x0);
    // DEC DI (1000_DD01 / 0x1DD01)
    DI = Alu.Dec16(DI);
    // JNZ 0x1000:dced (1000_DD02 / 0x1DD02)
    if(!ZeroFlag) {
      goto label_1000_DCED_1DCED;
    }
    // AND byte ptr [0x2942],0x7f (1000_DD04 / 0x1DD04)
    // UInt8[DS, 0x2942] &= 0x7F;
    UInt8[DS, 0x2942] = Alu.And8(UInt8[DS, 0x2942], 0x7F);
    label_1000_DD09_1DD09:
    // IN AL,DX (1000_DD09 / 0x1DD09)
    AL = Cpu.In8(DX);
    // POPF  (1000_DD0A / 0x1DD0A)
    FlagRegister = Stack.Pop();
    // MOV DX,CX (1000_DD0B / 0x1DD0B)
    DX = CX;
    // NOT AL (1000_DD0D / 0x1DD0D)
    AL = (byte)~AL;
    // RET  (1000_DD0F / 0x1DD0F)
    return NearRet();
  }
  
  public Action get_key_hit_ida_1000_DD5A_1DD5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DD5A_1DD5A:
    // XOR AL,AL (1000_DD5A / 0x1DD5A)
    AL = 0;
    // XCHG byte ptr [0xcee8],AL (1000_DD5C / 0x1DD5C)
    byte tmp_1000_DD5C = UInt8[DS, 0xCEE8];
    UInt8[DS, 0xCEE8] = AL;
    AL = tmp_1000_DD5C;
    // OR AL,AL (1000_DD60 / 0x1DD60)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // RET  (1000_DD62 / 0x1DD62)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DD63_01DD63(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DD63_1DD63:
    // CALL 0x1000:de7b (1000_DD63 / 0x1DD63)
    NearCall(cs1, 0xDD66, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    label_1000_DD66_1DD66:
    // CALL 0x1000:de54 (1000_DD66 / 0x1DD66)
    NearCall(cs1, 0xDD69, spice86_generated_label_call_target_1000_DE54_01DE54);
    label_1000_DD69_1DD69:
    // JZ 0x1000:ddae (1000_DD69 / 0x1DD69)
    if(ZeroFlag) {
      goto label_1000_DDAE_1DDAE;
    }
    // CMP byte ptr [0xcee8],0x0 (1000_DD6B / 0x1DD6B)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x0);
    // JNZ 0x1000:ddae (1000_DD70 / 0x1DD70)
    if(!ZeroFlag) {
      goto label_1000_DDAE_1DDAE;
    }
    // TEST byte ptr [0x2942],0x40 (1000_DD72 / 0x1DD72)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    // JNZ 0x1000:dd89 (1000_DD77 / 0x1DD77)
    if(!ZeroFlag) {
      goto label_1000_DD89_1DD89;
    }
    // MOV AX,0x3 (1000_DD79 / 0x1DD79)
    AX = 0x3;
    // INT 0x33 (1000_DD7C / 0x1DD7C)
    Interrupt(0x33);
    // XCHG SI,BX (1000_DD7E / 0x1DD7E)
    ushort tmp_1000_DD7E = SI;
    SI = BX;
    BX = tmp_1000_DD7E;
    // XOR BX,SI (1000_DD80 / 0x1DD80)
    BX ^= SI;
    
    // AND BX,SI (1000_DD82 / 0x1DD82)
    BX &= SI;
    
    // AND BL,0x7 (1000_DD84 / 0x1DD84)
    // BL &= 0x7;
    BL = Alu.And8(BL, 0x7);
    // JNZ 0x1000:ddae (1000_DD87 / 0x1DD87)
    if(!ZeroFlag) {
      goto label_1000_DDAE_1DDAE;
    }
    label_1000_DD89_1DD89:
    // TEST byte ptr [0x2942],0x80 (1000_DD89 / 0x1DD89)
    Alu.And8(UInt8[DS, 0x2942], 0x80);
    // JZ 0x1000:dd9e (1000_DD8E / 0x1DD8E)
    if(ZeroFlag) {
      goto label_1000_DD9E_1DD9E;
    }
    // PUSH DI (1000_DD90 / 0x1DD90)
    Stack.Push(DI);
    // CALL 0x1000:dce0 (1000_DD91 / 0x1DD91)
    NearCall(cs1, 0xDD94, read_game_port_ida_1000_DCE0_1DCE0);
    // POP DI (1000_DD94 / 0x1DD94)
    DI = Stack.Pop();
    // XCHG AX,DI (1000_DD95 / 0x1DD95)
    ushort tmp_1000_DD95 = AX;
    AX = DI;
    DI = tmp_1000_DD95;
    // XOR AX,DI (1000_DD96 / 0x1DD96)
    AX ^= DI;
    
    // AND AX,DI (1000_DD98 / 0x1DD98)
    AX &= DI;
    
    // AND AL,0x30 (1000_DD9A / 0x1DD9A)
    // AL &= 0x30;
    AL = Alu.And8(AL, 0x30);
    // JNZ 0x1000:ddae (1000_DD9C / 0x1DD9C)
    if(!ZeroFlag) {
      goto label_1000_DDAE_1DDAE;
    }
    label_1000_DD9E_1DD9E:
    // PUSH SI (1000_DD9E / 0x1DD9E)
    Stack.Push(SI);
    // PUSH DI (1000_DD9F / 0x1DD9F)
    Stack.Push(DI);
    // CALL 0x1000:e3cc (1000_DDA0 / 0x1DDA0)
    NearCall(cs1, 0xDDA3, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    label_1000_DDA3_1DDA3:
    // MOV [0x0],AX (1000_DDA3 / 0x1DDA3)
    UInt16[DS, 0x0] = AX;
    // CALL 0x1000:d9d2 (1000_DDA6 / 0x1DDA6)
    NearCall(cs1, 0xDDA9, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    label_1000_DDA9_1DDA9:
    // POP DI (1000_DDA9 / 0x1DDA9)
    DI = Stack.Pop();
    // POP SI (1000_DDAA / 0x1DDAA)
    SI = Stack.Pop();
    // OR AL,0x1 (1000_DDAB / 0x1DDAB)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // RET  (1000_DDAD / 0x1DDAD)
    return NearRet();
    label_1000_DDAE_1DDAE:
    // STC  (1000_DDAE / 0x1DDAE)
    CarryFlag = true;
    // RET  (1000_DDAF / 0x1DDAF)
    return NearRet();
  }
  
  public Action split_1000_DDE7_01DDE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DDE7_1DDE7:
    // PUSHF  (1000_DDE7 / 0x1DDE7)
    Stack.Push(FlagRegister);
    // CALL 0x1000:de4e (1000_DDE8 / 0x1DDE8)
    NearCall(cs1, 0xDDEB, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    label_1000_DDEB_1DDEB:
    // POPF  (1000_DDEB / 0x1DDEB)
    FlagRegister = Stack.Pop();
    // CALL 0x1000:e283 (1000_DDEC / 0x1DDEC)
    NearCall(cs1, 0xDDEF, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_DDEF_1DDEF:
    // RET  (1000_DDEF / 0x1DDEF)
    return NearRet();
  }
  
  public Action split_1000_DE07_01DE07(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DE07_1DE07:
    // PUSH AX (1000_DE07 / 0x1DE07)
    Stack.Push(AX);
    // OR AL,0x1 (1000_DE08 / 0x1DE08)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // POP AX (1000_DE0A / 0x1DE0A)
    AX = Stack.Pop();
    // RET  (1000_DE0B / 0x1DE0B)
    return NearRet();
    label_1000_DE0C_1DE0C:
    // CMP byte ptr [0xdbcd],0x0 (1000_DE0C / 0x1DE0C)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JNS 0x1000:de07 (1000_DE11 / 0x1DE11)
    if(!SignFlag) {
      goto label_1000_DE07_1DE07;
    }
    // CALL 0x1000:e270 (1000_DE13 / 0x1DE13)
    NearCall(cs1, 0xDE16, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_DE16_1DE16:
    // MOV byte ptr [0xcee8],0x0 (1000_DE16 / 0x1DE16)
    UInt8[DS, 0xCEE8] = 0x0;
    // MOV SI,0xffff (1000_DE1B / 0x1DE1B)
    SI = 0xFFFF;
    // MOV DI,SI (1000_DE1E / 0x1DE1E)
    DI = SI;
    label_1000_DE20_1DE20:
    // MOV AX,0x60 (1000_DE20 / 0x1DE20)
    AX = 0x60;
    // SUB AX,word ptr [0xdbd0] (1000_DE23 / 0x1DE23)
    AX -= UInt16[DS, 0xDBD0];
    
    // XOR AH,AH (1000_DE27 / 0x1DE27)
    AH = 0;
    // MOV DL,0x6 (1000_DE29 / 0x1DE29)
    DL = 0x6;
    // DIV DL (1000_DE2B / 0x1DE2B)
    Cpu.Div8(DL);
    // AND AL,0xf (1000_DE2D / 0x1DE2D)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // MOV DX,word ptr [0xdbce] (1000_DE2F / 0x1DE2F)
    DX = UInt16[DS, 0xDBCE];
    // SHL DX,0x1 (1000_DE33 / 0x1DE33)
    DX <<= 0x1;
    
    // SHL DX,0x1 (1000_DE35 / 0x1DE35)
    DX <<= 0x1;
    
    // SHL DX,0x1 (1000_DE37 / 0x1DE37)
    DX <<= 0x1;
    
    // SHL DX,0x1 (1000_DE39 / 0x1DE39)
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    // OR DL,AL (1000_DE3B / 0x1DE3B)
    DL |= AL;
    
    // CMP BX,DX (1000_DE3D / 0x1DE3D)
    Alu.Sub16(BX, DX);
    // JBE 0x1000:de4a (1000_DE3F / 0x1DE3F)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_DE4A_1DE4A;
    }
    // PUSH BX (1000_DE41 / 0x1DE41)
    Stack.Push(BX);
    // CALL 0x1000:dd63 (1000_DE42 / 0x1DE42)
    NearCall(cs1, 0xDE45, spice86_generated_label_call_target_1000_DD63_01DD63);
    // POP BX (1000_DE45 / 0x1DE45)
    BX = Stack.Pop();
    // JC 0x1000:dde7 (1000_DE46 / 0x1DE46)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_DDE7_01DDE7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:de20 (1000_DE48 / 0x1DE48)
    goto label_1000_DE20_1DE20;
    label_1000_DE4A_1DE4A:
    // OR AL,0x1 (1000_DE4A / 0x1DE4A)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    // JMP 0x1000:dde7 (1000_DE4C / 0x1DE4C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_DDE7_01DDE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_DE4E_01DE4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DE4E_1DE4E:
    // MOV byte ptr [0xcee8],0x0 (1000_DE4E / 0x1DE4E)
    UInt8[DS, 0xCEE8] = 0x0;
    // RET  (1000_DE53 / 0x1DE53)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DE54_01DE54(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DE54_1DE54:
    // MOV byte ptr [0xcee9],0x0 (1000_DE54 / 0x1DE54)
    UInt8[DS, 0xCEE9] = 0x0;
    // CMP byte ptr [0xcee8],0x1 (1000_DE59 / 0x1DE59)
    Alu.Sub8(UInt8[DS, 0xCEE8], 0x1);
    // JNZ 0x1000:de67 (1000_DE5E / 0x1DE5E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_DE67 / 0x1DE67)
      return NearRet();
    }
    // MOV byte ptr [0xcee9],0x1 (1000_DE60 / 0x1DE60)
    UInt8[DS, 0xCEE9] = 0x1;
    // JMP 0x1000:de4e (1000_DE65 / 0x1DE65)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_DE67_1DE67:
    // RET  (1000_DE67 / 0x1DE67)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DE7B_01DE7B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xDE7A: break; // Instructions before entry targeted by 0x1DE80
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_DE7A_1DE7A:
    // RET  (1000_DE7A / 0x1DE7A)
    return NearRet();
    entry:
    label_1000_DE7B_1DE7B:
    // CMP byte ptr [0xce9a],0x0 (1000_DE7B / 0x1DE7B)
    Alu.Sub8(UInt8[DS, 0xCE9A], 0x0);
    // JZ 0x1000:de7a (1000_DE80 / 0x1DE80)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DE7A / 0x1DE7A)
      return NearRet();
    }
    // CMP byte ptr [0xce80],0x0 (1000_DE82 / 0x1DE82)
    Alu.Sub8(UInt8[DS, 0xCE80], 0x0);
    // JZ 0x1000:de7a (1000_DE87 / 0x1DE87)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DE7A / 0x1DE7A)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_DE89 / 0x1DE89)
    NearCall(cs1, 0xDE8C, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV AL,0x1 (1000_DE8C / 0x1DE8C)
    AL = 0x1;
    // XCHG byte ptr [0x2788],AL (1000_DE8E / 0x1DE8E)
    byte tmp_1000_DE8E = UInt8[DS, 0x2788];
    UInt8[DS, 0x2788] = AL;
    AL = tmp_1000_DE8E;
    // PUSH AX (1000_DE92 / 0x1DE92)
    Stack.Push(AX);
    // PUSH word ptr [0xce7a] (1000_DE93 / 0x1DE93)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // CALL 0x1000:dbb2 (1000_DE97 / 0x1DE97)
    NearCall(cs1, 0xDE9A, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // PUSH word ptr [0xdbda] (1000_DE9A / 0x1DE9A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_DE9E / 0x1DE9E)
    NearCall(cs1, 0xDEA1, spice86_generated_label_call_target_1000_C08E_01C08E);
    // PUSH word ptr [0xdbd6] (1000_DEA1 / 0x1DEA1)
    Stack.Push(UInt16[DS, 0xDBD6]);
    // CALLF [0x38b9] (1000_DEA5 / 0x1DEA5)
    // Indirect call to [0x38b9], generating possible targets from emulator records
    uint targetAddress_1000_DEA5 = (uint)(UInt16[DS, 0x38BB] * 0x10 + UInt16[DS, 0x38B9] - cs1 * 0x10);
    switch(targetAddress_1000_DEA5) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_DEA5));
        break;
    }
    // MOV [0xdbd6],AX (1000_DEA9 / 0x1DEA9)
    UInt16[DS, 0xDBD6] = AX;
    // MOV SI,0x2945 (1000_DEAC / 0x1DEAC)
    SI = 0x2945;
    // CALL 0x1000:7b1b (1000_DEAF / 0x1DEAF)
    NearCall(cs1, 0xDEB2, spice86_generated_label_call_target_1000_7B1B_017B1B);
    // MOV CX,0xf1fe (1000_DEB2 / 0x1DEB2)
    CX = 0xF1FE;
    // MOV DX,0x82 (1000_DEB5 / 0x1DEB5)
    DX = 0x82;
    // MOV BX,0xa9 (1000_DEB8 / 0x1DEB8)
    BX = 0xA9;
    // MOV AX,0x115 (1000_DEBB / 0x1DEBB)
    AX = 0x115;
    // CALL 0x1000:d068 (1000_DEBE / 0x1DEBE)
    NearCall(cs1, 0xDEC1, spice86_generated_label_call_target_1000_D068_01D068);
    // CALL 0x1000:d194 (1000_DEC1 / 0x1DEC1)
    NearCall(cs1, 0xDEC4, spice86_generated_label_call_target_1000_D194_01D194);
    // CALL 0x1000:d075 (1000_DEC4 / 0x1DEC4)
    NearCall(cs1, 0xDEC7, spice86_generated_label_call_target_1000_D075_01D075);
    // MOV DX,0x60 (1000_DEC7 / 0x1DEC7)
    DX = 0x60;
    // MOV BX,0xb8 (1000_DECA / 0x1DECA)
    BX = 0xB8;
    // MOV AX,0x116 (1000_DECD / 0x1DECD)
    AX = 0x116;
    // MOV CX,0xf1f7 (1000_DED0 / 0x1DED0)
    CX = 0xF1F7;
    // CALL 0x1000:d194 (1000_DED3 / 0x1DED3)
    NearCall(cs1, 0xDED6, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_DED6_1DED6:
    // CMP byte ptr [0xce9a],0x0 (1000_DED6 / 0x1DED6)
    Alu.Sub8(UInt8[DS, 0xCE9A], 0x0);
    // JNZ 0x1000:ded6 (1000_DEDB / 0x1DEDB)
    if(!ZeroFlag) {
      goto label_1000_DED6_1DED6;
    }
    // CALL 0x1000:de68 (1000_DEDD / 0x1DEDD)
    throw FailAsUntested("Could not find a valid function at address 1000_DE68 / 0x1DE68");
    label_1000_DEE0_1DEE0:
    // CALL 0x1000:dd5a (1000_DEE0 / 0x1DEE0)
    NearCall(cs1, 0xDEE3, get_key_hit_ida_1000_DD5A_1DD5A);
    // JZ 0x1000:dee0 (1000_DEE3 / 0x1DEE3)
    if(ZeroFlag) {
      goto label_1000_DEE0_1DEE0;
    }
    // PUSH AX (1000_DEE5 / 0x1DEE5)
    Stack.Push(AX);
    // CALL 0x1000:de68 (1000_DEE6 / 0x1DEE6)
    throw FailAsUntested("Could not find a valid function at address 1000_DE68 / 0x1DE68");
    // CALL 0x1000:df07 (1000_DEE9 / 0x1DEE9)
    throw FailAsUntested("Could not find a valid function at address 1000_DF07 / 0x1DF07");
    // POP AX (1000_DEEC / 0x1DEEC)
    AX = Stack.Pop();
    // DEC AL (1000_DEED / 0x1DEED)
    AL = Alu.Dec8(AL);
    // JZ 0x1000:dee0 (1000_DEEF / 0x1DEEF)
    if(ZeroFlag) {
      goto label_1000_DEE0_1DEE0;
    }
    // POP word ptr [0xdbd6] (1000_DEF1 / 0x1DEF1)
    UInt16[DS, 0xDBD6] = Stack.Pop();
    // POP word ptr [0xdbda] (1000_DEF5 / 0x1DEF5)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // POP word ptr [0xce7a] (1000_DEF9 / 0x1DEF9)
    UInt16[DS, 0xCE7A] = Stack.Pop();
    // POP AX (1000_DEFD / 0x1DEFD)
    AX = Stack.Pop();
    // MOV [0x2788],AL (1000_DEFE / 0x1DEFE)
    UInt8[DS, 0x2788] = AL;
    // CALL 0x1000:e283 (1000_DF01 / 0x1DF01)
    NearCall(cs1, 0xDF04, spice86_generated_label_call_target_1000_E283_01E283);
    // XOR AX,AX (1000_DF04 / 0x1DF04)
    AX = 0;
    // RET  (1000_DF06 / 0x1DF06)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_DF1E_01DF1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DF1E_1DF1E:
    // CALL 0x1000:de7b (1000_DF1E / 0x1DF1E)
    NearCall(cs1, 0xDF21, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    label_1000_DF21_1DF21:
    // XOR AL,AL (1000_DF21 / 0x1DF21)
    AL = 0;
    // TEST byte ptr [0x2942],0x40 (1000_DF23 / 0x1DF23)
    Alu.And8(UInt8[DS, 0x2942], 0x40);
    // JNZ 0x1000:df49 (1000_DF28 / 0x1DF28)
    if(!ZeroFlag) {
      goto label_1000_DF49_1DF49;
    }
    // MOV AX,0x3 (1000_DF2A / 0x1DF2A)
    AX = 0x3;
    // INT 0x33 (1000_DF2D / 0x1DF2D)
    Interrupt(0x33);
    // MOV AX,CX (1000_DF2F / 0x1DF2F)
    AX = CX;
    // MOV CX,word ptr [0x2580] (1000_DF31 / 0x1DF31)
    CX = UInt16[DS, 0x2580];
    // SHR AX,CL (1000_DF35 / 0x1DF35)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV CL,CH (1000_DF37 / 0x1DF37)
    CL = CH;
    // SHR DX,CL (1000_DF39 / 0x1DF39)
    // DX >>= CL;
    DX = Alu.Shr16(DX, CL);
    // MOV CX,AX (1000_DF3B / 0x1DF3B)
    CX = AX;
    // MOV AL,BL (1000_DF3D / 0x1DF3D)
    AL = BL;
    // AND AL,0x3 (1000_DF3F / 0x1DF3F)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    // MOV word ptr [0xdc36],CX (1000_DF41 / 0x1DF41)
    UInt16[DS, 0xDC36] = CX;
    // MOV word ptr [0xdc38],DX (1000_DF45 / 0x1DF45)
    UInt16[DS, 0xDC38] = DX;
    label_1000_DF49_1DF49:
    // MOV [0xdc34],AL (1000_DF49 / 0x1DF49)
    UInt8[DS, 0xDC34] = AL;
    // TEST byte ptr [0x2942],0x80 (1000_DF4C / 0x1DF4C)
    Alu.And8(UInt8[DS, 0x2942], 0x80);
    // JZ 0x1000:df56 (1000_DF51 / 0x1DF51)
    if(ZeroFlag) {
      goto label_1000_DF56_1DF56;
    }
    // CALL 0x1000:dd10 (1000_DF53 / 0x1DF53)
    throw FailAsUntested("Could not find a valid function at address 1000_DD10 / 0x1DD10");
    label_1000_DF56_1DF56:
    // MOV SI,0xcec8 (1000_DF56 / 0x1DF56)
    SI = 0xCEC8;
    // MOV DI,word ptr [0xdc48] (1000_DF59 / 0x1DF59)
    DI = UInt16[DS, 0xDC48];
    // XOR DX,DX (1000_DF5D / 0x1DF5D)
    DX = 0;
    // MOV BX,DX (1000_DF5F / 0x1DF5F)
    BX = DX;
    // MOV AX,DX (1000_DF61 / 0x1DF61)
    AX = DX;
    // MOV CX,0xd (1000_DF63 / 0x1DF63)
    CX = 0xD;
    label_1000_DF66_1DF66:
    // LODSB SI (1000_DF66 / 0x1DF66)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,byte ptr [SI + 0x12] (1000_DF67 / 0x1DF67)
    // AL |= UInt8[DS, (ushort)(SI + 0x12)];
    AL = Alu.Or8(AL, UInt8[DS, (ushort)(SI + 0x12)]);
    // JZ 0x1000:df74 (1000_DF6A / 0x1DF6A)
    if(ZeroFlag) {
      goto label_1000_DF74_1DF74;
    }
    // OR AH,byte ptr [DI] (1000_DF6C / 0x1DF6C)
    AH |= UInt8[DS, DI];
    
    // ADD DX,word ptr [DI + 0x2] (1000_DF6E / 0x1DF6E)
    DX += UInt16[DS, (ushort)(DI + 0x2)];
    
    // ADD BX,word ptr [DI + 0x4] (1000_DF71 / 0x1DF71)
    BX += UInt16[DS, (ushort)(DI + 0x4)];
    
    label_1000_DF74_1DF74:
    // ADD DI,0x6 (1000_DF74 / 0x1DF74)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    // LOOP 0x1000:df66 (1000_DF77 / 0x1DF77)
    if(--CX != 0) {
      goto label_1000_DF66_1DF66;
    }
    // MOV AL,[0xceba] (1000_DF79 / 0x1DF79)
    AL = UInt8[DS, 0xCEBA];
    // OR AL,byte ptr [0xce9d] (1000_DF7C / 0x1DF7C)
    // AL |= UInt8[DS, 0xCE9D];
    AL = Alu.Or8(AL, UInt8[DS, 0xCE9D]);
    // OR AL,byte ptr [0xcee6] (1000_DF80 / 0x1DF80)
    AL |= UInt8[DS, 0xCEE6];
    
    // AND AL,0x1 (1000_DF84 / 0x1DF84)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    // MOV AH,AL (1000_DF86 / 0x1DF86)
    AH = AL;
    // XCHG byte ptr [0xdc57],AL (1000_DF88 / 0x1DF88)
    byte tmp_1000_DF88 = UInt8[DS, 0xDC57];
    UInt8[DS, 0xDC57] = AL;
    AL = tmp_1000_DF88;
    // NOT AL (1000_DF8C / 0x1DF8C)
    AL = (byte)~AL;
    // AND AL,byte ptr [0xdc34] (1000_DF8E / 0x1DF8E)
    // AL &= UInt8[DS, 0xDC34];
    AL = Alu.And8(AL, UInt8[DS, 0xDC34]);
    // OR AL,AH (1000_DF92 / 0x1DF92)
    // AL |= AH;
    AL = Alu.Or8(AL, AH);
    // MOV [0xdc34],AL (1000_DF94 / 0x1DF94)
    UInt8[DS, 0xDC34] = AL;
    // MOV AX,DX (1000_DF97 / 0x1DF97)
    AX = DX;
    // OR AX,BX (1000_DF99 / 0x1DF99)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    // JNZ 0x1000:dfb7 (1000_DF9B / 0x1DF9B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_DFB7_01DFB7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV [0xdc51],AX (1000_DF9D / 0x1DF9D)
    UInt16[DS, 0xDC51] = AX;
    // MOV [0xdc53],AX (1000_DFA0 / 0x1DFA0)
    UInt16[DS, 0xDC53] = AX;
    // MOV [0xdc55],AX (1000_DFA3 / 0x1DFA3)
    UInt16[DS, 0xDC55] = AX;
    label_1000_DFA6_1DFA6:
    // RET  (1000_DFA6 / 0x1DFA6)
    return NearRet();
  }
  
  public Action split_1000_DFB7_01DFB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_DFB7_1DFB7:
    // CMP byte ptr [0xce9e],0xff (1000_DFB7 / 0x1DFB7)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    // JNZ 0x1000:dfc1 (1000_DFBC / 0x1DFBC)
    if(!ZeroFlag) {
      goto label_1000_DFC1_1DFC1;
    }
    // JMP 0x1000:e1d1 (1000_DFBE / 0x1DFBE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_E1D1_01E1D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_DFC1_1DFC1:
    // MOV DI,0xdfa9 (1000_DFC1 / 0x1DFC1)
    DI = 0xDFA9;
    // OR DL,DL (1000_DFC4 / 0x1DFC4)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:dfdb (1000_DFC6 / 0x1DFC6)
    if(ZeroFlag) {
      goto label_1000_DFDB_1DFDB;
    }
    // JNS 0x1000:dfcd (1000_DFC8 / 0x1DFC8)
    if(!SignFlag) {
      goto label_1000_DFCD_1DFCD;
    }
    // ADD DI,0x6 (1000_DFCA / 0x1DFCA)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    label_1000_DFCD_1DFCD:
    // OR BL,BL (1000_DFCD / 0x1DFCD)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:dfe7 (1000_DFCF / 0x1DFCF)
    if(ZeroFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    // LEA DI,[DI + -0x2] (1000_DFD1 / 0x1DFD1)
    DI = (ushort)(DI - 0x2);
    // JS 0x1000:dfe7 (1000_DFD4 / 0x1DFD4)
    if(SignFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    // ADD DI,0x4 (1000_DFD6 / 0x1DFD6)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    // JMP 0x1000:dfe7 (1000_DFD9 / 0x1DFD9)
    goto label_1000_DFE7_1DFE7;
    label_1000_DFDB_1DFDB:
    // MOV DI,0xdfb3 (1000_DFDB / 0x1DFDB)
    DI = 0xDFB3;
    // OR BL,BL (1000_DFDE / 0x1DFDE)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:dfa6 (1000_DFE0 / 0x1DFE0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_DFA6 / 0x1DFA6)
      return NearRet();
    }
    // JS 0x1000:dfe7 (1000_DFE2 / 0x1DFE2)
    if(SignFlag) {
      goto label_1000_DFE7_1DFE7;
    }
    // ADD DI,0x2 (1000_DFE4 / 0x1DFE4)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    label_1000_DFE7_1DFE7:
    // MOV BX,word ptr CS:[DI] (1000_DFE7 / 0x1DFE7)
    BX = UInt16[cs1, DI];
    // SUB SP,0xa (1000_DFEA / 0x1DFEA)
    // SP -= 0xA;
    SP = Alu.Sub16(SP, 0xA);
    // MOV BP,SP (1000_DFED / 0x1DFED)
    BP = SP;
    // MOV word ptr [BP + 0x0],BX (1000_DFEF / 0x1DFEF)
    UInt16[SS, BP] = BX;
    // CALL 0x1000:de4e (1000_DFF2 / 0x1DFF2)
    NearCall(cs1, 0xDFF5, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    // MOV DX,word ptr [0xdc36] (1000_DFF5 / 0x1DFF5)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_DFF9 / 0x1DFF9)
    BX = UInt16[DS, 0xDC38];
    // MOV DI,0x1ae4 (1000_DFFD / 0x1DFFD)
    DI = 0x1AE4;
    // MOV CX,word ptr [DI] (1000_E000 / 0x1E000)
    CX = UInt16[DS, DI];
    // MOV word ptr [BP + 0x2],0x8000 (1000_E002 / 0x1E002)
    UInt16[SS, (ushort)(BP + 0x2)] = 0x8000;
    // ADD DI,0x2 (1000_E007 / 0x1E007)
    DI += 0x2;
    
    label_1000_E00A_1E00A:
    // TEST byte ptr [DI + 0x8],0x80 (1000_E00A / 0x1E00A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x8)], 0x80);
    // JZ 0x1000:e02c (1000_E00E / 0x1E00E)
    if(ZeroFlag) {
      goto label_1000_E02C_1E02C;
    }
    // CALL 0x1000:d6fe (1000_E010 / 0x1E010)
    NearCall(cs1, 0xE013, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JC 0x1000:e02c (1000_E013 / 0x1E013)
    if(CarryFlag) {
      goto label_1000_E02C_1E02C;
    }
    // CALL 0x1000:e159 (1000_E015 / 0x1E015)
    throw FailAsUntested("Could not find a valid function at address 1000_E159 / 0x1E159");
    // CALL word ptr [BP + 0x0] (1000_E018 / 0x1E018)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E018 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E018) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E018));
        break;
    }
    // CMP AX,word ptr [BP + 0x2] (1000_E01B / 0x1E01B)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    // JNC 0x1000:e02c (1000_E01E / 0x1E01E)
    if(!CarryFlag) {
      goto label_1000_E02C_1E02C;
    }
    // MOV word ptr [BP + 0x2],AX (1000_E020 / 0x1E020)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    // CALL 0x1000:e159 (1000_E023 / 0x1E023)
    throw FailAsUntested("Could not find a valid function at address 1000_E159 / 0x1E159");
    // MOV word ptr [BP + 0x4],AX (1000_E026 / 0x1E026)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    // MOV word ptr [BP + 0x6],SI (1000_E029 / 0x1E029)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    label_1000_E02C_1E02C:
    // ADD DI,0xe (1000_E02C / 0x1E02C)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    // LOOP 0x1000:e00a (1000_E02F / 0x1E02F)
    if(--CX != 0) {
      goto label_1000_E00A_1E00A;
    }
    // CALL 0x1000:e068 (1000_E031 / 0x1E031)
    throw FailAsUntested("Could not find a valid function at address 1000_E068 / 0x1E068");
    // CALL 0x1000:e0a2 (1000_E034 / 0x1E034)
    throw FailAsUntested("Could not find a valid function at address 1000_E0A2 / 0x1E0A2");
    // CALL 0x1000:e0db (1000_E037 / 0x1E037)
    throw FailAsUntested("Could not find a valid function at address 1000_E0DB / 0x1E0DB");
    // CALL 0x1000:e11c (1000_E03A / 0x1E03A)
    throw FailAsUntested("Could not find a valid function at address 1000_E11C / 0x1E11C");
    // CMP word ptr [BP + 0x2],0x0 (1000_E03D / 0x1E03D)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], 0x0);
    // JS 0x1000:e064 (1000_E041 / 0x1E041)
    if(SignFlag) {
      goto label_1000_E064_1E064;
    }
    // MOV byte ptr [0xceba],0x0 (1000_E043 / 0x1E043)
    UInt8[DS, 0xCEBA] = 0x0;
    // OR byte ptr [0xce9d],0x0 (1000_E048 / 0x1E048)
    // UInt8[DS, 0xCE9D] |= 0x0;
    UInt8[DS, 0xCE9D] = Alu.Or8(UInt8[DS, 0xCE9D], 0x0);
    // MOV AX,word ptr [BP + 0x4] (1000_E04D / 0x1E04D)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV [0xdc4c],AX (1000_E050 / 0x1E050)
    UInt16[DS, 0xDC4C] = AX;
    // MOV AX,word ptr [BP + 0x6] (1000_E053 / 0x1E053)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    // MOV [0xdc4e],AX (1000_E056 / 0x1E056)
    UInt16[DS, 0xDC4E] = AX;
    // MOV byte ptr [0xdc4b],0x64 (1000_E059 / 0x1E059)
    UInt8[DS, 0xDC4B] = 0x64;
    // MOV AX,[0xce7a] (1000_E05E / 0x1E05E)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc4a],AL (1000_E061 / 0x1E061)
    UInt8[DS, 0xDC4A] = AL;
    label_1000_E064_1E064:
    // ADD SP,0xa (1000_E064 / 0x1E064)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    // RET  (1000_E067 / 0x1E067)
    return NearRet();
  }
  
  public Action split_1000_E1D1_01E1D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E1D1_1E1D1:
    // OR DL,DL (1000_E1D1 / 0x1E1D1)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    // JZ 0x1000:e1f3 (1000_E1D3 / 0x1E1D3)
    if(ZeroFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // MOV AX,[0xdc51] (1000_E1D5 / 0x1E1D5)
    AX = UInt16[DS, 0xDC51];
    // OR AX,AX (1000_E1D8 / 0x1E1D8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:e1de (1000_E1DA / 0x1E1DA)
    if(!SignFlag) {
      goto label_1000_E1DE_1E1DE;
    }
    // NEG AX (1000_E1DC / 0x1E1DC)
    AX = Alu.Sub16(0, AX);
    label_1000_E1DE_1E1DE:
    // CMP AX,0x4 (1000_E1DE / 0x1E1DE)
    Alu.Sub16(AX, 0x4);
    // JC 0x1000:e1f3 (1000_E1E1 / 0x1E1E1)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // ADD DL,DL (1000_E1E3 / 0x1E1E3)
    DL += DL;
    
    // CMP AX,0xc (1000_E1E5 / 0x1E1E5)
    Alu.Sub16(AX, 0xC);
    // JC 0x1000:e1f3 (1000_E1E8 / 0x1E1E8)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // ADD DL,DL (1000_E1EA / 0x1E1EA)
    DL += DL;
    
    // CMP AX,0x24 (1000_E1EC / 0x1E1EC)
    Alu.Sub16(AX, 0x24);
    // JC 0x1000:e1f3 (1000_E1EF / 0x1E1EF)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    // ADD DL,DL (1000_E1F1 / 0x1E1F1)
    // DL += DL;
    DL = Alu.Add8(DL, DL);
    label_1000_E1F3_1E1F3:
    // OR BL,BL (1000_E1F3 / 0x1E1F3)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JZ 0x1000:e213 (1000_E1F5 / 0x1E1F5)
    if(ZeroFlag) {
      goto label_1000_E213_1E213;
    }
    // MOV AX,[0xdc53] (1000_E1F7 / 0x1E1F7)
    AX = UInt16[DS, 0xDC53];
    // JNS 0x1000:e1fe (1000_E1FA / 0x1E1FA)
    if(!SignFlag) {
      goto label_1000_E1FE_1E1FE;
    }
    // NEG AX (1000_E1FC / 0x1E1FC)
    AX = Alu.Sub16(0, AX);
    label_1000_E1FE_1E1FE:
    // CMP AX,0x3 (1000_E1FE / 0x1E1FE)
    Alu.Sub16(AX, 0x3);
    // JC 0x1000:e213 (1000_E201 / 0x1E201)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    // ADD BL,BL (1000_E203 / 0x1E203)
    BL += BL;
    
    // CMP AX,0xa (1000_E205 / 0x1E205)
    Alu.Sub16(AX, 0xA);
    // JC 0x1000:e213 (1000_E208 / 0x1E208)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    // ADD BL,BL (1000_E20A / 0x1E20A)
    BL += BL;
    
    // CMP AX,0x1c (1000_E20C / 0x1E20C)
    Alu.Sub16(AX, 0x1C);
    // JC 0x1000:e213 (1000_E20F / 0x1E20F)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    // ADD BL,BL (1000_E211 / 0x1E211)
    // BL += BL;
    BL = Alu.Add8(BL, BL);
    label_1000_E213_1E213:
    // MOV AL,[0xce7a] (1000_E213 / 0x1E213)
    AL = UInt8[DS, 0xCE7A];
    // MOV AH,AL (1000_E216 / 0x1E216)
    AH = AL;
    // XCHG byte ptr [0xdc50],AH (1000_E218 / 0x1E218)
    byte tmp_1000_E218 = UInt8[DS, 0xDC50];
    UInt8[DS, 0xDC50] = AH;
    AH = tmp_1000_E218;
    // SUB AL,AH (1000_E21C / 0x1E21C)
    AL -= AH;
    
    // CMP AL,0x8 (1000_E21E / 0x1E21E)
    Alu.Sub8(AL, 0x8);
    // JC 0x1000:e224 (1000_E220 / 0x1E220)
    if(CarryFlag) {
      goto label_1000_E224_1E224;
    }
    // MOV AL,0x8 (1000_E222 / 0x1E222)
    AL = 0x8;
    label_1000_E224_1E224:
    // MOV CL,AL (1000_E224 / 0x1E224)
    CL = AL;
    // MOV SI,0xdc55 (1000_E226 / 0x1E226)
    SI = 0xDC55;
    // MOV AL,DL (1000_E229 / 0x1E229)
    AL = DL;
    // CALL 0x1000:e243 (1000_E22B / 0x1E22B)
    throw FailAsUntested("Could not find a valid function at address 1000_E243 / 0x1E243");
    // MOV DX,AX (1000_E22E / 0x1E22E)
    DX = AX;
    // ADD word ptr [0xdc51],AX (1000_E230 / 0x1E230)
    UInt16[DS, 0xDC51] += AX;
    
    // INC SI (1000_E234 / 0x1E234)
    SI = Alu.Inc16(SI);
    // MOV AL,BL (1000_E235 / 0x1E235)
    AL = BL;
    // CALL 0x1000:e243 (1000_E237 / 0x1E237)
    throw FailAsUntested("Could not find a valid function at address 1000_E243 / 0x1E243");
    // MOV BX,AX (1000_E23A / 0x1E23A)
    BX = AX;
    // ADD word ptr [0xdc53],AX (1000_E23C / 0x1E23C)
    // UInt16[DS, 0xDC53] += AX;
    UInt16[DS, 0xDC53] = Alu.Add16(UInt16[DS, 0xDC53], AX);
    // JMP 0x1000:daaf (1000_E240 / 0x1E240)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_DAAF_01DAAF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_E26F_01E26F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E26F_1E26F:
    // RET  (1000_E26F / 0x1E26F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E270_01E270(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E270_1E270:
    // PUSH BX (1000_E270 / 0x1E270)
    Stack.Push(BX);
    // PUSH CX (1000_E271 / 0x1E271)
    Stack.Push(CX);
    // PUSH DX (1000_E272 / 0x1E272)
    Stack.Push(DX);
    // PUSH SI (1000_E273 / 0x1E273)
    Stack.Push(SI);
    // PUSH DI (1000_E274 / 0x1E274)
    Stack.Push(DI);
    // PUSH BP (1000_E275 / 0x1E275)
    Stack.Push(BP);
    // MOV BP,SP (1000_E276 / 0x1E276)
    BP = SP;
    // XCHG word ptr [BP + 0xc],AX (1000_E278 / 0x1E278)
    ushort tmp_1000_E278 = UInt16[SS, (ushort)(BP + 0xC)];
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    AX = tmp_1000_E278;
    // PUSH AX (1000_E27B / 0x1E27B)
    Stack.Push(AX);
    // MOV AX,word ptr [BP + 0xc] (1000_E27C / 0x1E27C)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    // MOV BP,word ptr [BP + 0x0] (1000_E27F / 0x1E27F)
    BP = UInt16[SS, BP];
    // RET  (1000_E282 / 0x1E282)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E283_01E283(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E283_1E283:
    // POP AX (1000_E283 / 0x1E283)
    AX = Stack.Pop();
    // MOV BP,SP (1000_E284 / 0x1E284)
    BP = SP;
    // XCHG word ptr [BP + 0xc],AX (1000_E286 / 0x1E286)
    ushort tmp_1000_E286 = UInt16[SS, (ushort)(BP + 0xC)];
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    AX = tmp_1000_E286;
    // POP BP (1000_E289 / 0x1E289)
    BP = Stack.Pop();
    // POP DI (1000_E28A / 0x1E28A)
    DI = Stack.Pop();
    // POP SI (1000_E28B / 0x1E28B)
    SI = Stack.Pop();
    // POP DX (1000_E28C / 0x1E28C)
    DX = Stack.Pop();
    // POP CX (1000_E28D / 0x1E28D)
    CX = Stack.Pop();
    // POP BX (1000_E28E / 0x1E28E)
    BX = Stack.Pop();
    // RET  (1000_E28F / 0x1E28F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E290_01E290(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E290_1E290:
    // CALL 0x1000:d04e (1000_E290 / 0x1E290)
    NearCall(cs1, 0xE293, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_E293_1E293:
    // JMP 0x1000:e297 (1000_E293 / 0x1E293)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_E297_01E297, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_E297_01E297(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E297_1E297:
    // PUSH CX (1000_E297 / 0x1E297)
    Stack.Push(CX);
    // MOV CX,0x64 (1000_E298 / 0x1E298)
    CX = 0x64;
    // DIV CL (1000_E29B / 0x1E29B)
    Cpu.Div8(CL);
    // ADD AL,0x30 (1000_E29D / 0x1E29D)
    AL += 0x30;
    
    // CMP AL,0x30 (1000_E29F / 0x1E29F)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e2a7 (1000_E2A1 / 0x1E2A1)
    if(!ZeroFlag) {
      goto label_1000_E2A7_1E2A7;
    }
    // MOV AL,0x20 (1000_E2A3 / 0x1E2A3)
    AL = 0x20;
    // DEC CH (1000_E2A5 / 0x1E2A5)
    CH = Alu.Dec8(CH);
    label_1000_E2A7_1E2A7:
    // CALL word ptr [0x2518] (1000_E2A7 / 0x1E2A7)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2A7 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2A7) {
      case 0xD12F : NearCall(cs1, 0xE2AB, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2A7));
        break;
    }
    label_1000_E2AB_1E2AB:
    // MOV AL,AH (1000_E2AB / 0x1E2AB)
    AL = AH;
    // AAM 0xa (1000_E2AD / 0x1E2AD)
    Cpu.Aam(0xA);
    // XCHG AH,AL (1000_E2AF / 0x1E2AF)
    byte tmp_1000_E2AF = AH;
    AH = AL;
    AL = tmp_1000_E2AF;
    // ADD AX,0x3030 (1000_E2B1 / 0x1E2B1)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    // OR CH,CH (1000_E2B4 / 0x1E2B4)
    // CH |= CH;
    CH = Alu.Or8(CH, CH);
    // JZ 0x1000:e2be (1000_E2B6 / 0x1E2B6)
    if(ZeroFlag) {
      goto label_1000_E2BE_1E2BE;
    }
    // CMP AL,0x30 (1000_E2B8 / 0x1E2B8)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e2be (1000_E2BA / 0x1E2BA)
    if(!ZeroFlag) {
      goto label_1000_E2BE_1E2BE;
    }
    // MOV AL,0x20 (1000_E2BC / 0x1E2BC)
    AL = 0x20;
    label_1000_E2BE_1E2BE:
    // CALL word ptr [0x2518] (1000_E2BE / 0x1E2BE)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2BE = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2BE) {
      case 0xD12F : NearCall(cs1, 0xE2C2, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2BE));
        break;
    }
    label_1000_E2C2_1E2C2:
    // MOV AL,AH (1000_E2C2 / 0x1E2C2)
    AL = AH;
    // CALL word ptr [0x2518] (1000_E2C4 / 0x1E2C4)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2C4 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2C4) {
      case 0xD12F : NearCall(cs1, 0xE2C8, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2C4));
        break;
    }
    label_1000_E2C8_1E2C8:
    // POP CX (1000_E2C8 / 0x1E2C8)
    CX = Stack.Pop();
    // RET  (1000_E2C9 / 0x1E2C9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E2DB_01E2DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E2DB_1E2DB:
    // PUSH AX (1000_E2DB / 0x1E2DB)
    Stack.Push(AX);
    // CALL 0x1000:cf70 (1000_E2DC / 0x1E2DC)
    NearCall(cs1, 0xE2DF, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_E2DF_1E2DF:
    // CALL 0x1000:d03c (1000_E2DF / 0x1E2DF)
    NearCall(cs1, 0xE2E2, spice86_generated_label_call_target_1000_D03C_01D03C);
    label_1000_E2E2_1E2E2:
    // POP AX (1000_E2E2 / 0x1E2E2)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_E2E3_01E2E3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xE2F6: goto label_1000_E2F6_1E2F6;break; // Target of external jump from 0x1E351
      case 0xE2FE: goto label_1000_E2FE_1E2FE;break; // Target of external jump from 0x1E2F8, 0x1E34E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_E2E3_1E2E3:
    // PUSH BX (1000_E2E3 / 0x1E2E3)
    Stack.Push(BX);
    // PUSH CX (1000_E2E4 / 0x1E2E4)
    Stack.Push(CX);
    // MOV CX,0x64 (1000_E2E5 / 0x1E2E5)
    CX = 0x64;
    // MOV BX,CX (1000_E2E8 / 0x1E2E8)
    BX = CX;
    // CMP AX,0x3e8 (1000_E2EA / 0x1E2EA)
    Alu.Sub16(AX, 0x3E8);
    // JC 0x1000:e2f2 (1000_E2ED / 0x1E2ED)
    if(CarryFlag) {
      goto label_1000_E2F2_1E2F2;
    }
    // MOV AX,0x3e7 (1000_E2EF / 0x1E2EF)
    AX = 0x3E7;
    label_1000_E2F2_1E2F2:
    // DIV CL (1000_E2F2 / 0x1E2F2)
    Cpu.Div8(CL);
    // ADD AL,0x30 (1000_E2F4 / 0x1E2F4)
    AL += 0x30;
    
    label_1000_E2F6_1E2F6:
    // CMP AL,0x30 (1000_E2F6 / 0x1E2F6)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e2fe (1000_E2F8 / 0x1E2F8)
    if(!ZeroFlag) {
      goto label_1000_E2FE_1E2FE;
    }
    // MOV AL,0x20 (1000_E2FA / 0x1E2FA)
    AL = 0x20;
    // XOR BX,BX (1000_E2FC / 0x1E2FC)
    BX = 0;
    label_1000_E2FE_1E2FE:
    // MOV byte ptr ES:[SI + -0x3],AL (1000_E2FE / 0x1E2FE)
    UInt8[ES, (ushort)(SI - 0x3)] = AL;
    // MOV AL,AH (1000_E302 / 0x1E302)
    AL = AH;
    // AAM 0xa (1000_E304 / 0x1E304)
    Cpu.Aam(0xA);
    // XCHG AH,AL (1000_E306 / 0x1E306)
    byte tmp_1000_E306 = AH;
    AH = AL;
    AL = tmp_1000_E306;
    // ADD AX,0x3030 (1000_E308 / 0x1E308)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    // OR BX,BX (1000_E30B / 0x1E30B)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNZ 0x1000:e315 (1000_E30D / 0x1E30D)
    if(!ZeroFlag) {
      goto label_1000_E315_1E315;
    }
    // CMP AL,0x30 (1000_E30F / 0x1E30F)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e315 (1000_E311 / 0x1E311)
    if(!ZeroFlag) {
      goto label_1000_E315_1E315;
    }
    // MOV AL,0x20 (1000_E313 / 0x1E313)
    AL = 0x20;
    label_1000_E315_1E315:
    // MOV word ptr ES:[SI + -0x2],AX (1000_E315 / 0x1E315)
    UInt16[ES, (ushort)(SI - 0x2)] = AX;
    // POP CX (1000_E319 / 0x1E319)
    CX = Stack.Pop();
    // POP BX (1000_E31A / 0x1E31A)
    BX = Stack.Pop();
    // RET  (1000_E31B / 0x1E31B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E31C_01E31C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E31C_1E31C:
    // PUSH BX (1000_E31C / 0x1E31C)
    Stack.Push(BX);
    // PUSH CX (1000_E31D / 0x1E31D)
    Stack.Push(CX);
    // MOV CX,0x3e8 (1000_E31E / 0x1E31E)
    CX = 0x3E8;
    // MOV BX,CX (1000_E321 / 0x1E321)
    BX = CX;
    // XOR DX,DX (1000_E323 / 0x1E323)
    DX = 0;
    // DIV CX (1000_E325 / 0x1E325)
    Cpu.Div16(CX);
    // AAM 0xa (1000_E327 / 0x1E327)
    Cpu.Aam(0xA);
    // XCHG AH,AL (1000_E329 / 0x1E329)
    byte tmp_1000_E329 = AH;
    AH = AL;
    AL = tmp_1000_E329;
    // ADD AX,0x3030 (1000_E32B / 0x1E32B)
    AX += 0x3030;
    
    // CMP AL,0x30 (1000_E32E / 0x1E32E)
    Alu.Sub8(AL, 0x30);
    // JNZ 0x1000:e33d (1000_E330 / 0x1E330)
    if(!ZeroFlag) {
      goto label_1000_E33D_1E33D;
    }
    // MOV AL,0x20 (1000_E332 / 0x1E332)
    AL = 0x20;
    // CMP AH,0x30 (1000_E334 / 0x1E334)
    Alu.Sub8(AH, 0x30);
    // JNZ 0x1000:e33d (1000_E337 / 0x1E337)
    if(!ZeroFlag) {
      goto label_1000_E33D_1E33D;
    }
    // MOV AH,AL (1000_E339 / 0x1E339)
    AH = AL;
    // XOR BX,BX (1000_E33B / 0x1E33B)
    BX = 0;
    label_1000_E33D_1E33D:
    // MOV word ptr ES:[SI + -0x5],AX (1000_E33D / 0x1E33D)
    UInt16[ES, (ushort)(SI - 0x5)] = AX;
    // MOV AX,DX (1000_E341 / 0x1E341)
    AX = DX;
    // XOR DX,DX (1000_E343 / 0x1E343)
    DX = 0;
    // MOV CX,0x64 (1000_E345 / 0x1E345)
    CX = 0x64;
    // DIV CL (1000_E348 / 0x1E348)
    Cpu.Div8(CL);
    // ADD AL,0x30 (1000_E34A / 0x1E34A)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    // OR BX,BX (1000_E34C / 0x1E34C)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNZ 0x1000:e2fe (1000_E34E / 0x1E34E)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0x1E2FE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // INC BX (1000_E350 / 0x1E350)
    BX = Alu.Inc16(BX);
    // JMP 0x1000:e2f6 (1000_E351 / 0x1E351)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0x1E2F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_E353_01E353(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E353_1E353:
    // PUSH AX (1000_E353 / 0x1E353)
    Stack.Push(AX);
    // PUSH word ptr [0xce7a] (1000_E354 / 0x1E354)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // CALL BP (1000_E358 / 0x1E358)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_E358 = (uint)(BP);
    switch(targetAddress_1000_E358) {
      case 0x4821 : NearCall(cs1, 0xE35A, spice86_generated_label_call_target_1000_4821_014821); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E358));
        break;
    }
    label_1000_E35A_1E35A:
    // POP BX (1000_E35A / 0x1E35A)
    BX = Stack.Pop();
    // POP BP (1000_E35B / 0x1E35B)
    BP = Stack.Pop();
    label_1000_E35C_1E35C:
    // CMP byte ptr [0x227d],0x0 (1000_E35C / 0x1E35C)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JZ 0x1000:e378 (1000_E361 / 0x1E361)
    if(ZeroFlag) {
      goto label_1000_E378_1E378;
    }
    // PUSH BX (1000_E363 / 0x1E363)
    Stack.Push(BX);
    // PUSH CX (1000_E364 / 0x1E364)
    Stack.Push(CX);
    // PUSH DX (1000_E365 / 0x1E365)
    Stack.Push(DX);
    // PUSH SI (1000_E366 / 0x1E366)
    Stack.Push(SI);
    // PUSH DI (1000_E367 / 0x1E367)
    Stack.Push(DI);
    // PUSH BP (1000_E368 / 0x1E368)
    Stack.Push(BP);
    // PUSH ES (1000_E369 / 0x1E369)
    Stack.Push(ES);
    // CALL 0x1000:dd63 (1000_E36A / 0x1E36A)
    NearCall(cs1, 0xE36D, spice86_generated_label_call_target_1000_DD63_01DD63);
    // POP ES (1000_E36D / 0x1E36D)
    ES = Stack.Pop();
    // POP BP (1000_E36E / 0x1E36E)
    BP = Stack.Pop();
    // POP DI (1000_E36F / 0x1E36F)
    DI = Stack.Pop();
    // POP SI (1000_E370 / 0x1E370)
    SI = Stack.Pop();
    // POP DX (1000_E371 / 0x1E371)
    DX = Stack.Pop();
    // POP CX (1000_E372 / 0x1E372)
    CX = Stack.Pop();
    // POP BX (1000_E373 / 0x1E373)
    BX = Stack.Pop();
    // JC 0x1000:e386 (1000_E374 / 0x1E374)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E386 / 0x1E386)
      return NearRet();
    }
    // JMP 0x1000:e37b (1000_E376 / 0x1E376)
    goto label_1000_E37B_1E37B;
    label_1000_E378_1E378:
    // CALL 0x1000:de7b (1000_E378 / 0x1E378)
    NearCall(cs1, 0xE37B, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    label_1000_E37B_1E37B:
    // MOV AX,[0xce7a] (1000_E37B / 0x1E37B)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,BX (1000_E37E / 0x1E37E)
    AX -= BX;
    
    // CMP AX,BP (1000_E380 / 0x1E380)
    Alu.Sub16(AX, BP);
    // JC 0x1000:e35c (1000_E382 / 0x1E382)
    if(CarryFlag) {
      goto label_1000_E35C_1E35C;
    }
    // OR AL,0x1 (1000_E384 / 0x1E384)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    label_1000_E386_1E386:
    // RET  (1000_E386 / 0x1E386)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E387_01E387(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E387_1E387:
    // PUSH AX (1000_E387 / 0x1E387)
    Stack.Push(AX);
    // PUSH CX (1000_E388 / 0x1E388)
    Stack.Push(CX);
    // MOV CX,AX (1000_E389 / 0x1E389)
    CX = AX;
    // JCXZ 0x1000:e39d (1000_E38B / 0x1E38B)
    if(CX == 0) {
      goto label_1000_E39D_1E39D;
    }
    // PUSHF  (1000_E38D / 0x1E38D)
    Stack.Push(FlagRegister);
    // STI  (1000_E38E / 0x1E38E)
    InterruptFlag = true;
    label_1000_E38F_1E38F:
    // MOV AX,SS:[0xce7a] (1000_E38F / 0x1E38F)
    AX = UInt16[SS, 0xCE7A];
    label_1000_E393_1E393:
    // CMP AX,word ptr SS:[0xce7a] (1000_E393 / 0x1E393)
    Alu.Sub16(AX, UInt16[SS, 0xCE7A]);
    // JZ 0x1000:e393 (1000_E398 / 0x1E398)
    if(ZeroFlag) {
      goto label_1000_E393_1E393;
    }
    // LOOP 0x1000:e38f (1000_E39A / 0x1E39A)
    if(--CX != 0) {
      goto label_1000_E38F_1E38F;
    }
    // POPF  (1000_E39C / 0x1E39C)
    FlagRegister = Stack.Pop();
    label_1000_E39D_1E39D:
    // POP CX (1000_E39D / 0x1E39D)
    CX = Stack.Pop();
    // POP AX (1000_E39E / 0x1E39E)
    AX = Stack.Pop();
    // RET  (1000_E39F / 0x1E39F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E3A0_01E3A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E3A0_1E3A0:
    // MOV CX,AX (1000_E3A0 / 0x1E3A0)
    CX = AX;
    label_1000_E3A2_1E3A2:
    // MOV AX,[0xce7a] (1000_E3A2 / 0x1E3A2)
    AX = UInt16[DS, 0xCE7A];
    label_1000_E3A5_1E3A5:
    // CMP AX,word ptr [0xce7a] (1000_E3A5 / 0x1E3A5)
    Alu.Sub16(AX, UInt16[DS, 0xCE7A]);
    // JZ 0x1000:e3a5 (1000_E3A9 / 0x1E3A9)
    if(ZeroFlag) {
      goto label_1000_E3A5_1E3A5;
    }
    // CALL 0x1000:e270 (1000_E3AB / 0x1E3AB)
    NearCall(cs1, 0xE3AE, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_E3AE_1E3AE:
    // CALL 0x1000:d9d2 (1000_E3AE / 0x1E3AE)
    NearCall(cs1, 0xE3B1, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    label_1000_E3B1_1E3B1:
    // CALL 0x1000:e283 (1000_E3B1 / 0x1E3B1)
    NearCall(cs1, 0xE3B4, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_E3B4_1E3B4:
    // LOOP 0x1000:e3a2 (1000_E3B4 / 0x1E3B4)
    if(--CX != 0) {
      goto label_1000_E3A2_1E3A2;
    }
    // RET  (1000_E3B6 / 0x1E3B6)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E3B7_01E3B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E3B7_1E3B7:
    // PUSH DX (1000_E3B7 / 0x1E3B7)
    Stack.Push(DX);
    // MOV AX,[0xd824] (1000_E3B8 / 0x1E3B8)
    AX = UInt16[DS, 0xD824];
    // MOV DX,0xe56d (1000_E3BB / 0x1E3BB)
    DX = 0xE56D;
    // MUL DX (1000_E3BE / 0x1E3BE)
    Cpu.Mul16(DX);
    // INC AX (1000_E3C0 / 0x1E3C0)
    AX = Alu.Inc16(AX);
    // MOV [0xd824],AX (1000_E3C1 / 0x1E3C1)
    UInt16[DS, 0xD824] = AX;
    // MOV AL,AH (1000_E3C4 / 0x1E3C4)
    AL = AH;
    // MOV AH,DL (1000_E3C6 / 0x1E3C6)
    AH = DL;
    // AND AX,BX (1000_E3C8 / 0x1E3C8)
    // AX &= BX;
    AX = Alu.And16(AX, BX);
    // POP DX (1000_E3CA / 0x1E3CA)
    DX = Stack.Pop();
    // RET  (1000_E3CB / 0x1E3CB)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E3CC_01E3CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E3CC_1E3CC:
    // PUSH DX (1000_E3CC / 0x1E3CC)
    Stack.Push(DX);
    // MOV AX,[0xd826] (1000_E3CD / 0x1E3CD)
    AX = UInt16[DS, 0xD826];
    // MOV DX,0xcbd1 (1000_E3D0 / 0x1E3D0)
    DX = 0xCBD1;
    // MUL DX (1000_E3D3 / 0x1E3D3)
    Cpu.Mul16(DX);
    // INC AX (1000_E3D5 / 0x1E3D5)
    AX = Alu.Inc16(AX);
    // MOV [0xd826],AX (1000_E3D6 / 0x1E3D6)
    UInt16[DS, 0xD826] = AX;
    // MOV AL,AH (1000_E3D9 / 0x1E3D9)
    AL = AH;
    // MOV AH,DL (1000_E3DB / 0x1E3DB)
    AH = DL;
    // POP DX (1000_E3DD / 0x1E3DD)
    DX = Stack.Pop();
    // RET  (1000_E3DE / 0x1E3DE)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E3DF_01E3DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E3DF_1E3DF:
    // PUSH CX (1000_E3DF / 0x1E3DF)
    Stack.Push(CX);
    // PUSH DX (1000_E3E0 / 0x1E3E0)
    Stack.Push(DX);
    // MOV AX,BX (1000_E3E1 / 0x1E3E1)
    AX = BX;
    // OR AX,AX (1000_E3E3 / 0x1E3E3)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:e408 (1000_E3E5 / 0x1E3E5)
    if(ZeroFlag) {
      goto label_1000_E408_1E408;
    }
    // MOV CX,0xffff (1000_E3E7 / 0x1E3E7)
    CX = 0xFFFF;
    label_1000_E3EA_1E3EA:
    // SHL CX,0x1 (1000_E3EA / 0x1E3EA)
    CX <<= 0x1;
    
    // SHR AX,0x1 (1000_E3EC / 0x1E3EC)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // JNZ 0x1000:e3ea (1000_E3EE / 0x1E3EE)
    if(!ZeroFlag) {
      goto label_1000_E3EA_1E3EA;
    }
    // NOT CX (1000_E3F0 / 0x1E3F0)
    CX = (ushort)~CX;
    label_1000_E3F2_1E3F2:
    // MOV AX,[0xd828] (1000_E3F2 / 0x1E3F2)
    AX = UInt16[DS, 0xD828];
    // MOV DX,0xcbd1 (1000_E3F5 / 0x1E3F5)
    DX = 0xCBD1;
    // MUL DX (1000_E3F8 / 0x1E3F8)
    Cpu.Mul16(DX);
    // INC AX (1000_E3FA / 0x1E3FA)
    AX = Alu.Inc16(AX);
    // MOV [0xd828],AX (1000_E3FB / 0x1E3FB)
    UInt16[DS, 0xD828] = AX;
    // MOV AL,AH (1000_E3FE / 0x1E3FE)
    AL = AH;
    // MOV AH,DL (1000_E400 / 0x1E400)
    AH = DL;
    // AND AX,CX (1000_E402 / 0x1E402)
    AX &= CX;
    
    // CMP AX,BX (1000_E404 / 0x1E404)
    Alu.Sub16(AX, BX);
    // JA 0x1000:e3f2 (1000_E406 / 0x1E406)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E3F2_1E3F2;
    }
    label_1000_E408_1E408:
    // POP DX (1000_E408 / 0x1E408)
    DX = Stack.Pop();
    // POP CX (1000_E409 / 0x1E409)
    CX = Stack.Pop();
    // RET  (1000_E40A / 0x1E40A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E4AD_01E4AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E4AD_1E4AD:
    // MOV SI,0x80 (1000_E4AD / 0x1E4AD)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    SI = 0x80;
    // LODSB SI (1000_E4B0 / 0x1E4B0)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_E4B1 / 0x1E4B1)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    AH = 0;
    // MOV BP,AX (1000_E4B3 / 0x1E4B3)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    BP = AX;
    // ADD BP,SI (1000_E4B5 / 0x1E4B5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    label_1000_E4B7_1E4B7:
    // PUSH CS (1000_E4B7 / 0x1E4B7)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(cs1);
    // POP ES (1000_E4B8 / 0x1E4B8)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    ES = Stack.Pop();
    label_1000_E4B9_1E4B9:
    // CALL 0x1000:e56b (1000_E4B9 / 0x1E4B9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE4BC, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E4BC_1E4BC:
    // JC 0x1000:e4e5 (1000_E4BC / 0x1E4BC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E4E5 / 0x1E4E5)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      return NearRet();
    }
    // JZ 0x1000:e4b9 (1000_E4BE / 0x1E4BE)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      goto label_1000_E4B9_1E4B9;
    }
    // MOV DL,AL (1000_E4C0 / 0x1E4C0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    DL = AL;
    // CALL 0x1000:e56b (1000_E4C2 / 0x1E4C2)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE4C5, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E4C5_1E4C5:
    // JBE 0x1000:e542 (1000_E4C5 / 0x1E4C5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // MOV AH,AL (1000_E4C7 / 0x1E4C7)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AH = AL;
    // CALL 0x1000:e56b (1000_E4C9 / 0x1E4C9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE4CC, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E4CC_1E4CC:
    // JBE 0x1000:e542 (1000_E4CC / 0x1E4CC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // XCHG DL,AL (1000_E4CE / 0x1E4CE)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    byte tmp_1000_E4CE = DL;
    DL = AL;
    AL = tmp_1000_E4CE;
    // MOV DI,0xe40c (1000_E4D0 / 0x1E4D0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    DI = 0xE40C;
    // MOV CX,0x17 (1000_E4D3 / 0x1E4D3)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    CX = 0x17;
    label_1000_E4D6_1E4D6:
    // SCASW ES:DI (1000_E4D6 / 0x1E4D6)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(AX, UInt16[ES, DI]);
    DI = (ushort)(DI + Direction16);
    // JNZ 0x1000:e4de (1000_E4D7 / 0x1E4D7)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(!ZeroFlag) {
      goto label_1000_E4DE_1E4DE;
    }
    // CMP DL,byte ptr ES:[DI] (1000_E4D9 / 0x1E4D9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(DL, UInt8[ES, DI]);
    // JZ 0x1000:e4e6 (1000_E4DC / 0x1E4DC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(ZeroFlag) {
      goto label_1000_E4E6_1E4E6;
    }
    label_1000_E4DE_1E4DE:
    // ADD DI,0x5 (1000_E4DE / 0x1E4DE)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // DI += 0x5;
    DI = Alu.Add16(DI, 0x5);
    // LOOP 0x1000:e4d6 (1000_E4E1 / 0x1E4E1)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(--CX != 0) {
      goto label_1000_E4D6_1E4D6;
    }
    // JMP 0x1000:e542 (1000_E4E3 / 0x1E4E3)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    goto label_1000_E542_1E542;
    label_1000_E4E5_1E4E5:
    // RET  (1000_E4E5 / 0x1E4E5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    return NearRet();
    label_1000_E4E6_1E4E6:
    // MOV AX,0x1f4b (1000_E4E6 / 0x1E4E6)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x1F4B;
    // MOV ES,AX (1000_E4E9 / 0x1E4E9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    ES = AX;
    // MOV BL,byte ptr CS:[DI + 0x1] (1000_E4EB / 0x1E4EB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F8_149F8
    BL = UInt8[cs1, (ushort)(DI + 0x1)];
    // XOR BH,BH (1000_E4EF / 0x1E4EF)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    BH = 0;
    // ADD BX,0x2942 (1000_E4F1 / 0x1E4F1)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // BX += 0x2942;
    BX = Alu.Add16(BX, 0x2942);
    // MOV AL,byte ptr CS:[DI + 0x2] (1000_E4F5 / 0x1E4F5)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    AL = UInt8[cs1, (ushort)(DI + 0x2)];
    // OR byte ptr ES:[BX],AL (1000_E4F9 / 0x1E4F9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // UInt8[ES, BX] |= AL;
    UInt8[ES, BX] = Alu.Or8(UInt8[ES, BX], AL);
    // MOV BX,word ptr CS:[DI + 0x3] (1000_E4FC / 0x1E4FC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    BX = UInt16[cs1, (ushort)(DI + 0x3)];
    // OR BX,BX (1000_E500 / 0x1E500)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:e542 (1000_E502 / 0x1E502)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // CALL 0x1000:e56b (1000_E504 / 0x1E504)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE507, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E507_1E507:
    // JC 0x1000:e4e5 (1000_E507 / 0x1E507)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E4E5 / 0x1E4E5)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      return NearRet();
    }
    // JZ 0x1000:e542 (1000_E509 / 0x1E509)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    // DEC SI (1000_E50B / 0x1E50B)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    SI = Alu.Dec16(SI);
    // CMP BX,0x3826 (1000_E50C / 0x1E50C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(BX, 0x3826);
    // JZ 0x1000:e54d (1000_E510 / 0x1E510)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(ZeroFlag) {
      goto label_1000_E54D_1E54D;
    }
    label_1000_E512_1E512:
    // XOR DX,DX (1000_E512 / 0x1E512)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    DX = 0;
    label_1000_E514_1E514:
    // CALL 0x1000:e56b (1000_E514 / 0x1E514)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE517, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E517_1E517:
    // MOV AH,AL (1000_E517 / 0x1E517)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AH = AL;
    // JBE 0x1000:e537 (1000_E519 / 0x1E519)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E537_1E537;
    }
    // SUB AL,0x30 (1000_E51B / 0x1E51B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // AL -= 0x30;
    AL = Alu.Sub8(AL, 0x30);
    // JC 0x1000:e537 (1000_E51D / 0x1E51D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E537_1E537;
    }
    // CMP AL,0x9 (1000_E51F / 0x1E51F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(AL, 0x9);
    // JBE 0x1000:e52b (1000_E521 / 0x1E521)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E52B_1E52B;
    }
    // SUB AL,0x7 (1000_E523 / 0x1E523)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // AL -= 0x7;
    AL = Alu.Sub8(AL, 0x7);
    // JC 0x1000:e537 (1000_E525 / 0x1E525)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E537_1E537;
    }
    // CMP AL,0xf (1000_E527 / 0x1E527)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(AL, 0xF);
    // JA 0x1000:e537 (1000_E529 / 0x1E529)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E537_1E537;
    }
    label_1000_E52B_1E52B:
    // SHL DX,0x1 (1000_E52B / 0x1E52B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX <<= 0x1;
    
    // SHL DX,0x1 (1000_E52D / 0x1E52D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    DX <<= 0x1;
    
    // SHL DX,0x1 (1000_E52F / 0x1E52F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX <<= 0x1;
    
    // SHL DX,0x1 (1000_E531 / 0x1E531)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    // OR DL,AL (1000_E533 / 0x1E533)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // DL |= AL;
    DL = Alu.Or8(DL, AL);
    // JMP 0x1000:e514 (1000_E535 / 0x1E535)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    goto label_1000_E514_1E514;
    label_1000_E537_1E537:
    // MOV word ptr ES:[BX],DX (1000_E537 / 0x1E537)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, BX] = DX;
    // ADD BX,0x2 (1000_E53A / 0x1E53A)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    BX += 0x2;
    
    // CMP AH,0x20 (1000_E53D / 0x1E53D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(AH, 0x20);
    // JA 0x1000:e512 (1000_E540 / 0x1E540)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E512_1E512;
    }
    label_1000_E542_1E542:
    // DEC SI (1000_E542 / 0x1E542)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    SI = Alu.Dec16(SI);
    label_1000_E543_1E543:
    // CALL 0x1000:e56b (1000_E543 / 0x1E543)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE546, spice86_generated_label_call_target_1000_E56B_01E56B);
    label_1000_E546_1E546:
    // JC 0x1000:e4e5 (1000_E546 / 0x1E546)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E4E5 / 0x1E4E5)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      return NearRet();
    }
    // JNZ 0x1000:e543 (1000_E548 / 0x1E548)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(!ZeroFlag) {
      goto label_1000_E543_1E543;
    }
    // JMP 0x1000:e4b7 (1000_E54A / 0x1E54A)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    goto label_1000_E4B7_1E4B7;
    label_1000_E54D_1E54D:
    // MOV DI,BX (1000_E54D / 0x1E54D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    DI = BX;
    label_1000_E54F_1E54F:
    // CALL 0x1000:e56b (1000_E54F / 0x1E54F)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE552, spice86_generated_label_call_target_1000_E56B_01E56B);
    // JBE 0x1000:e55b (1000_E552 / 0x1E552)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E55B_1E55B;
    }
    // STOSB ES:DI (1000_E554 / 0x1E554)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // CMP DI,0x3898 (1000_E555 / 0x1E555)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(DI, 0x3898);
    // JC 0x1000:e54f (1000_E559 / 0x1E559)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E54F_1E54F;
    }
    label_1000_E55B_1E55B:
    // MOV AL,0x5c (1000_E55B / 0x1E55B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AL = 0x5C;
    // CMP byte ptr ES:[DI + -0x1],AL (1000_E55D / 0x1E55D)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(UInt8[ES, (ushort)(DI - 0x1)], AL);
    // JZ 0x1000:e564 (1000_E561 / 0x1E561)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      goto label_1000_E564_1E564;
    }
    // STOSB ES:DI (1000_E563 / 0x1E563)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_1000_E564_1E564:
    // MOV word ptr ES:[0x38a6],DI (1000_E564 / 0x1E564)
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, 0x38A6] = DI;
    // JMP 0x1000:e542 (1000_E569 / 0x1E569)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    goto label_1000_E542_1E542;
  }
  
  public Action spice86_generated_label_call_target_1000_E56B_01E56B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E56B_1E56B:
    // MOV AL,0xd (1000_E56B / 0x1E56B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AL = 0xD;
    // CMP SI,BP (1000_E56D / 0x1E56D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(SI, BP);
    // JNC 0x1000:e578 (1000_E56F / 0x1E56F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(!CarryFlag) {
      goto label_1000_E578_1E578;
    }
    // LODSB SI (1000_E571 / 0x1E571)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0x61 (1000_E572 / 0x1E572)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(AL, 0x61);
    // JC 0x1000:e578 (1000_E574 / 0x1E574)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag) {
      goto label_1000_E578_1E578;
    }
    // AND AL,0xdf (1000_E576 / 0x1E576)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AL &= 0xDF;
    
    label_1000_E578_1E578:
    // CMP AL,0x20 (1000_E578 / 0x1E578)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    Alu.Sub8(AL, 0x20);
    // RET  (1000_E57A / 0x1E57A)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E57B_01E57B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E57B_1E57B:
    // PUSH CX (1000_E57B / 0x1E57B)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(CX);
    // PUSH SI (1000_E57C / 0x1E57C)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    Stack.Push(SI);
    // ADD AX,0xc8 (1000_E57D / 0x1E57D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // AX += 0xC8;
    AX = Alu.Add16(AX, 0xC8);
    // MOV SI,AX (1000_E580 / 0x1E580)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    SI = AX;
    // CALL 0x1000:f0b9 (1000_E582 / 0x1E582)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE585, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_E585_1E585:
    // POP SI (1000_E585 / 0x1E585)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    SI = Stack.Pop();
    // POP CX (1000_E586 / 0x1E586)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    CX = Stack.Pop();
    // MOV AX,ES (1000_E587 / 0x1E587)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = ES;
    // SUB AX,0x10 (1000_E589 / 0x1E589)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // AX -= 0x10;
    AX = Alu.Sub16(AX, 0x10);
    label_1000_E58C_1E58C:
    // MOV word ptr [SI],AX (1000_E58C / 0x1E58C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    UInt16[DS, SI] = AX;
    // ADD SI,0x4 (1000_E58E / 0x1E58E)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LOOP 0x1000:e58c (1000_E591 / 0x1E591)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(--CX != 0) {
      goto label_1000_E58C_1E58C;
    }
    // RET  (1000_E593 / 0x1E593)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E594_01E594(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E594_1E594:
    // MOV AX,0x1f4b (1000_E594 / 0x1E594)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x1F4B;
    // MOV ES,AX (1000_E597 / 0x1E597)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    ES = AX;
    // MOV CX,0xdd1d (1000_E599 / 0x1E599)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    CX = 0xDD1D;
    // MOV DI,0x3cbc (1000_E59C / 0x1E59C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    DI = 0x3CBC;
    // SUB CX,DI (1000_E59F / 0x1E59F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    // CLD  (1000_E5A1 / 0x1E5A1)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    DirectionFlag = false;
    // XOR AX,AX (1000_E5A2 / 0x1E5A2)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AX = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_E5A4 / 0x1E5A4)
      // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV AX,[0x2] (1000_E5A6 / 0x1E5A6)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x2];
    // PUSH ES (1000_E5A9 / 0x1E5A9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    Stack.Push(ES);
    // POP DS (1000_E5AA / 0x1E5AA)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DS = Stack.Pop();
    // MOV [0xce68],AX (1000_E5AB / 0x1E5AB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xCE68] = AX;
    // MOV CX,0xdd1d (1000_E5AE / 0x1E5AE)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    CX = 0xDD1D;
    // CALL 0x1000:f0ff (1000_E5B1 / 0x1E5B1)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE5B4, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    label_1000_E5B4_1E5B4:
    // MOV AX,0x4c6f (1000_E5B4 / 0x1E5B4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x4C6F;
    // MOV CL,0x4 (1000_E5B7 / 0x1E5B7)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    CL = 0x4;
    // SHR AX,CL (1000_E5B9 / 0x1E5B9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV CX,DS (1000_E5BB / 0x1E5BB)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    CX = DS;
    // ADD AX,CX (1000_E5BD / 0x1E5BD)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // MOV [0xdc32],AX (1000_E5BF / 0x1E5BF)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDC32] = AX;
    // MOV AH,0x19 (1000_E5C2 / 0x1E5C2)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AH = 0x19;
    // INT 0x21 (1000_E5C4 / 0x1E5C4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    Interrupt(0x21);
    // MOV [0xce76],AL (1000_E5C6 / 0x1E5C6)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0xCE76] = AL;
    // MOV [0xce77],AL (1000_E5C9 / 0x1E5C9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0xCE77] = AL;
    // MOV AX,0x3301 (1000_E5CC / 0x1E5CC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x3301;
    // INT 0x21 (1000_E5CF / 0x1E5CF)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Interrupt(0x21);
    // MOV byte ptr [0x2941],DL (1000_E5D1 / 0x1E5D1)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0x2941] = DL;
    // MOV AX,0x3301 (1000_E5D5 / 0x1E5D5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x3301;
    // XOR DX,DX (1000_E5D8 / 0x1E5D8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    DX = 0;
    // INT 0x21 (1000_E5DA / 0x1E5DA)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    Interrupt(0x21);
    // CALL 0x1000:e675 (1000_E5DC / 0x1E5DC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE5DF, spice86_generated_label_call_target_1000_E675_01E675);
    label_1000_E5DF_1E5DF:
    // MOV AL,[0x2942] (1000_E5DF / 0x1E5DF)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AL = UInt8[DS, 0x2942];
    // AND AX,0x1 (1000_E5E2 / 0x1E5E2)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // AX &= 0x1;
    AX = Alu.And16(AX, 0x1);
    // MOV SI,0x38b7 (1000_E5E5 / 0x1E5E5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    SI = 0x38B7;
    // MOV CX,0x2e (1000_E5E8 / 0x1E5E8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    CX = 0x2E;
    // CALL 0x1000:e57b (1000_E5EB / 0x1E5EB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE5EE, spice86_generated_label_call_target_1000_E57B_01E57B);
    label_1000_E5EE_1E5EE:
    // CALLF [0x38b9] (1000_E5EE / 0x1E5EE)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // Indirect call to [0x38b9], generating possible targets from emulator records
    uint targetAddress_1000_E5EE = (uint)(UInt16[DS, 0x38BB] * 0x10 + UInt16[DS, 0x38B9] - cs1 * 0x10);
    switch(targetAddress_1000_E5EE) {
      case 0x235B3 : FarCall(cs1, 0xE5F2, spice86_generated_label_call_target_334B_0103_0335B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E5EE));
        break;
    }
    label_1000_E5F2_1E5F2:
    // MOV [0xdbd8],AX (1000_E5F2 / 0x1E5F2)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBD8] = AX;
    // CALL 0x1000:c08e (1000_E5F5 / 0x1E5F5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE5F8, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_E5F8_1E5F8:
    // MOV word ptr [0xce74],CX (1000_E5F8 / 0x1E5F8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xCE74] = CX;
    // MOV DI,0xdbdc (1000_E5FC / 0x1E5FC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    DI = 0xDBDC;
    // CALL 0x1000:f0f6 (1000_E5FF / 0x1E5FF)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE602, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    label_1000_E602_1E602:
    // MOV word ptr [0xdbd6],BP (1000_E602 / 0x1E602)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBD6] = BP;
    // OR BP,BP (1000_E606 / 0x1E606)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JNZ 0x1000:e610 (1000_E608 / 0x1E608)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(!ZeroFlag) {
      goto label_1000_E610_1E610;
    }
    // MOV DI,0xdbd4 (1000_E60A / 0x1E60A)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    DI = 0xDBD4;
    // CALL 0x1000:f0f6 (1000_E60D / 0x1E60D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE610, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    label_1000_E610_1E610:
    // CALLF [0x38b5] (1000_E610 / 0x1E610)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    // Indirect call to [0x38b5], generating possible targets from emulator records
    uint targetAddress_1000_E610 = (uint)(UInt16[DS, 0x38B7] * 0x10 + UInt16[DS, 0x38B5] - cs1 * 0x10);
    switch(targetAddress_1000_E610) {
      case 0x235B0 : FarCall(cs1, 0xE614, spice86_generated_label_call_target_334B_0100_0335B0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E610));
        break;
    }
    label_1000_E614_1E614:
    // MOV AL,[0x2942] (1000_E614 / 0x1E614)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AL = UInt8[DS, 0x2942];
    // PUSH AX (1000_E617 / 0x1E617)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(AX);
    // SHR AL,0x1 (1000_E618 / 0x1E618)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    AL >>= 0x1;
    
    // SHR AL,0x1 (1000_E61A / 0x1E61A)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AL >>= 0x1;
    
    // AND AL,0x7 (1000_E61C / 0x1E61C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // AL &= 0x7;
    AL = Alu.And8(AL, 0x7);
    // MOV [0xceeb],AL (1000_E61E / 0x1E61E)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0xCEEB] = AL;
    // POP AX (1000_E621 / 0x1E621)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    AX = Stack.Pop();
    // OR AL,AL (1000_E622 / 0x1E622)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:e62b (1000_E624 / 0x1E624)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(!SignFlag) {
      goto label_1000_E62B_1E62B;
    }
    // PUSH AX (1000_E626 / 0x1E626)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(AX);
    // CALL 0x1000:ea32 (1000_E627 / 0x1E627)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE62A, initialize_joystick_ida_1000_EA32_1EA32);
    // POP AX (1000_E62A / 0x1E62A)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = Stack.Pop();
    label_1000_E62B_1E62B:
    // TEST AL,0x40 (1000_E62B / 0x1E62B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Alu.And8(AL, 0x40);
    // JNZ 0x1000:e632 (1000_E62D / 0x1E62D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(!ZeroFlag) {
      goto label_1000_E632_1E632;
    }
    // CALL 0x1000:e97a (1000_E62F / 0x1E62F)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE632, spice86_generated_label_call_target_1000_E97A_01E97A);
    label_1000_E632_1E632:
    // CALL 0x1000:e85c (1000_E632 / 0x1E632)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE635, spice86_generated_label_call_target_1000_E85C_01E85C);
    label_1000_E635_1E635:
    // CALL 0x1000:ea7b (1000_E635 / 0x1E635)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE638, spice86_generated_label_call_target_1000_EA7B_01EA7B);
    label_1000_E638_1E638:
    // MOV AL,[0x2942] (1000_E638 / 0x1E638)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AL = UInt8[DS, 0x2942];
    // AND AL,0x2 (1000_E63B / 0x1E63B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // AL &= 0x2;
    AL = Alu.And8(AL, 0x2);
    // MOV BP,0xce7a (1000_E63D / 0x1E63D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    BP = 0xCE7A;
    // CALLF [0x3925] (1000_E640 / 0x1E640)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    // Indirect call to [0x3925], generating possible targets from emulator records
    uint targetAddress_1000_E640 = (uint)(UInt16[DS, 0x3927] * 0x10 + UInt16[DS, 0x3925] - cs1 * 0x10);
    switch(targetAddress_1000_E640) {
      case 0x23604 : FarCall(cs1, 0xE644, spice86_generated_label_call_target_334B_0154_033604); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E640));
        break;
    }
    label_1000_E644_1E644:
    // MOV word ptr [0xdc48],0x271c (1000_E644 / 0x1E644)
    // Instruction bytes at index 0, 1, 4, 5 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDC48] = 0x271C;
    // MOV byte ptr [0xdc46],0xff (1000_E64A / 0x1E64A)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0xDC46] = 0xFF;
    // XOR AX,AX (1000_E64F / 0x1E64F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = 0;
    // MOV BX,0xc7 (1000_E651 / 0x1E651)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    BX = 0xC7;
    // XOR CX,CX (1000_E654 / 0x1E654)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    CX = 0;
    // MOV DX,0x13f (1000_E656 / 0x1E656)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    DX = 0x13F;
    // CALL 0x1000:db14 (1000_E659 / 0x1E659)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE65C, spice86_generated_label_call_target_1000_DB14_01DB14);
    label_1000_E65C_1E65C:
    // MOV BX,0xab (1000_E65C / 0x1E65C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    BX = 0xAB;
    // MOV DX,0xed (1000_E65F / 0x1E65F)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX = 0xED;
    // CALL 0x1000:db03 (1000_E662 / 0x1E662)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE665, spice86_generated_label_call_target_1000_DB03_01DB03);
    label_1000_E665_1E665:
    // CALL 0x1000:e76a (1000_E665 / 0x1E665)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE668, spice86_generated_label_call_target_1000_E76A_01E76A);
    label_1000_E668_1E668:
    // CALL 0x1000:ce6c (1000_E668 / 0x1E668)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE66B, spice86_generated_label_call_target_1000_CE6C_01CE6C);
    label_1000_E66B_1E66B:
    // CALL 0x1000:c07c (1000_E66B / 0x1E66B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE66E, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_E66E_1E66E:
    // CALL 0x1000:c0ad (1000_E66E / 0x1E66E)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE671, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    label_1000_E671_1E671:
    // JMP 0x1000:c412 (1000_E671 / 0x1E671)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C412_01C412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
