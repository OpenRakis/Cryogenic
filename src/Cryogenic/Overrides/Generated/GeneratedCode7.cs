namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_B7D2_01B7D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B7D2_1B7D2:
    // PUSH DX (1000_B7D2 / 0x1B7D2)
    Stack.Push(DX);
    // PUSH DI (1000_B7D3 / 0x1B7D3)
    Stack.Push(DI);
    // PUSH DS (1000_B7D4 / 0x1B7D4)
    Stack.Push(DS);
    // LDS SI,[0xdcfe] (1000_B7D5 / 0x1B7D5)
    DS = UInt16[DS, 0xDD00];
    SI = UInt16[DS, 0xDCFE];
    // PUSH SS (1000_B7D9 / 0x1B7D9)
    Stack.Push(SS);
    // POP ES (1000_B7DA / 0x1B7DA)
    ES = Stack.Pop();
    // ADD SI,CX (1000_B7DB / 0x1B7DB)
    SI += CX;
    
    // ADD BX,BX (1000_B7DD / 0x1B7DD)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    // MOV AX,DX (1000_B7DF / 0x1B7DF)
    AX = DX;
    // MUL BX (1000_B7E1 / 0x1B7E1)
    Cpu.Mul16(BX);
    // MOV word ptr [BP + 0x6],DX (1000_B7E3 / 0x1B7E3)
    UInt16[SS, (ushort)(BP + 0x6)] = DX;
    // MOV AX,DX (1000_B7E6 / 0x1B7E6)
    AX = DX;
    // MOV DX,word ptr SS:[0xdcf2] (1000_B7E8 / 0x1B7E8)
    DX = UInt16[SS, 0xDCF2];
    // CMP BX,DX (1000_B7ED / 0x1B7ED)
    Alu.Sub16(BX, DX);
    // JNC 0x1000:b7fb (1000_B7EF / 0x1B7EF)
    if(!CarryFlag) {
      goto label_1000_B7FB_1B7FB;
    }
    // MOV CX,DX (1000_B7F1 / 0x1B7F1)
    CX = DX;
    // SUB CX,BX (1000_B7F3 / 0x1B7F3)
    CX -= BX;
    
    // SHR CX,0x1 (1000_B7F5 / 0x1B7F5)
    CX >>= 0x1;
    
    // ADD DI,CX (1000_B7F7 / 0x1B7F7)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    // MOV DX,BX (1000_B7F9 / 0x1B7F9)
    DX = BX;
    label_1000_B7FB_1B7FB:
    // MOV CX,DX (1000_B7FB / 0x1B7FB)
    CX = DX;
    // SHR CX,0x1 (1000_B7FD / 0x1B7FD)
    CX >>= 0x1;
    
    // SUB AX,CX (1000_B7FF / 0x1B7FF)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // JNS 0x1000:b805 (1000_B801 / 0x1B801)
    if(!SignFlag) {
      goto label_1000_B805_1B805;
    }
    // ADD AX,BX (1000_B803 / 0x1B803)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    label_1000_B805_1B805:
    // MOV CX,DX (1000_B805 / 0x1B805)
    CX = DX;
    // SUB BX,AX (1000_B807 / 0x1B807)
    BX -= AX;
    
    // SUB CX,BX (1000_B809 / 0x1B809)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    // JNS 0x1000:b813 (1000_B80B / 0x1B80B)
    if(!SignFlag) {
      goto label_1000_B813_1B813;
    }
    // ADD CX,BX (1000_B80D / 0x1B80D)
    CX += BX;
    
    // ADD SI,AX (1000_B80F / 0x1B80F)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // JMP 0x1000:b81d (1000_B811 / 0x1B811)
    goto label_1000_B81D_1B81D;
    label_1000_B813_1B813:
    // XCHG CX,BX (1000_B813 / 0x1B813)
    ushort tmp_1000_B813 = CX;
    CX = BX;
    BX = tmp_1000_B813;
    // PUSH SI (1000_B815 / 0x1B815)
    Stack.Push(SI);
    // ADD SI,AX (1000_B816 / 0x1B816)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B818 / 0x1B818)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP SI (1000_B81A / 0x1B81A)
    SI = Stack.Pop();
    // XCHG CX,BX (1000_B81B / 0x1B81B)
    ushort tmp_1000_B81B = CX;
    CX = BX;
    BX = tmp_1000_B81B;
    label_1000_B81D_1B81D:
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B81D / 0x1B81D)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP DS (1000_B81F / 0x1B81F)
    DS = Stack.Pop();
    // POP DI (1000_B820 / 0x1B820)
    DI = Stack.Pop();
    // POP DX (1000_B821 / 0x1B821)
    DX = Stack.Pop();
    // ADD DI,0xc8 (1000_B822 / 0x1B822)
    // DI += 0xC8;
    DI = Alu.Add16(DI, 0xC8);
    // RET  (1000_B826 / 0x1B826)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B827_01B827(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B827_1B827:
    // MOV byte ptr [0xdd02],0x0 (1000_B827 / 0x1B827)
    UInt8[DS, 0xDD02] = 0x0;
    // CALL 0x1000:b84a (1000_B82C / 0x1B82C)
    NearCall(cs1, 0xB82F, spice86_generated_label_call_target_1000_B84A_01B84A);
    label_1000_B82F_1B82F:
    // MOV word ptr [0xdd0f],0x0 (1000_B82F / 0x1B82F)
    UInt16[DS, 0xDD0F] = 0x0;
    // CALL 0x1000:b87e (1000_B835 / 0x1B835)
    NearCall(cs1, 0xB838, spice86_generated_label_call_target_1000_B87E_01B87E);
    label_1000_B838_1B838:
    // CALL 0x1000:1797 (1000_B838 / 0x1B838)
    NearCall(cs1, 0xB83B, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_B83B_1B83B:
    // CALL 0x1000:b941 (1000_B83B / 0x1B83B)
    NearCall(cs1, 0xB83E, spice86_generated_label_call_target_1000_B941_01B941);
    label_1000_B83E_1B83E:
    // CALL 0x1000:d7b2 (1000_B83E / 0x1B83E)
    NearCall(cs1, 0xB841, spice86_generated_label_call_target_1000_D7B2_01D7B2);
    label_1000_B841_1B841:
    // MOV SI,0x1dc6 (1000_B841 / 0x1B841)
    SI = 0x1DC6;
    // CALL 0x1000:d72b (1000_B844 / 0x1B844)
    NearCall(cs1, 0xB847, spice86_generated_label_call_target_1000_D72B_01D72B);
    label_1000_B847_1B847:
    // JMP 0x1000:ad5e (1000_B847 / 0x1B847)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD5E_01AD5E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B84A_01B84A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B84A_1B84A:
    // CALL 0x1000:c07c (1000_B84A / 0x1B84A)
    NearCall(cs1, 0xB84D, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_B84D_1B84D:
    // MOV ES,word ptr [0xdbda] (1000_B84D / 0x1B84D)
    ES = UInt16[DS, 0xDBDA];
    // MOV SI,0x1470 (1000_B851 / 0x1B851)
    SI = 0x1470;
    // MOV AL,0xf0 (1000_B854 / 0x1B854)
    AL = 0xF0;
    // CALLF [0x38dd] (1000_B856 / 0x1B856)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_B856 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_B856) {
      case 0x235CE : FarCall(cs1, 0xB85A, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B856));
        break;
    }
    label_1000_B85A_1B85A:
    // MOV AX,0x1 (1000_B85A / 0x1B85A)
    AX = 0x1;
    // CALL 0x1000:c13e (1000_B85D / 0x1B85D)
    NearCall(cs1, 0xB860, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_B860_1B860:
    // MOV DX,0x5b (1000_B860 / 0x1B860)
    DX = 0x5B;
    // MOV BX,0x14 (1000_B863 / 0x1B863)
    BX = 0x14;
    // MOV AX,0x2 (1000_B866 / 0x1B866)
    AX = 0x2;
    // CALL 0x1000:c22f (1000_B869 / 0x1B869)
    NearCall(cs1, 0xB86C, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_B86C_1B86C:
    // MOV SI,0x2448 (1000_B86C / 0x1B86C)
    SI = 0x2448;
    // CALL 0x1000:daaa (1000_B86F / 0x1B86F)
    NearCall(cs1, 0xB872, spice86_generated_label_call_target_1000_DAAA_01DAAA);
    label_1000_B872_1B872:
    // MOV SI,0x2440 (1000_B872 / 0x1B872)
    SI = 0x2440;
    // MOV DI,0xd834 (1000_B875 / 0x1B875)
    DI = 0xD834;
    // CALL 0x1000:5b99 (1000_B878 / 0x1B878)
    NearCall(cs1, 0xB87B, spice86_generated_label_call_target_1000_5B99_015B99);
    label_1000_B87B_1B87B:
    // JMP 0x1000:b977 (1000_B87B / 0x1B87B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B977_01B977, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B87E_01B87E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B87E_1B87E:
    // CALL 0x1000:5ba8 (1000_B87E / 0x1B87E)
    NearCall(cs1, 0xB881, spice86_generated_label_call_target_1000_5BA8_015BA8);
    label_1000_B881_1B881:
    // MOV AX,0x1 (1000_B881 / 0x1B881)
    AX = 0x1;
    // CALL 0x1000:c13e (1000_B884 / 0x1B884)
    NearCall(cs1, 0xB887, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_B887_1B887:
    // MOV DX,word ptr [0xdd0f] (1000_B887 / 0x1B887)
    DX = UInt16[DS, 0xDD0F];
    // XOR BX,BX (1000_B88B / 0x1B88B)
    BX = 0;
    // XOR AX,AX (1000_B88D / 0x1B88D)
    AX = 0;
    // CALL 0x1000:c305 (1000_B88F / 0x1B88F)
    NearCall(cs1, 0xB892, spice86_generated_label_call_target_1000_C305_01C305);
    label_1000_B892_1B892:
    // SUB DX,0xd6 (1000_B892 / 0x1B892)
    DX -= 0xD6;
    
    // NEG DX (1000_B896 / 0x1B896)
    DX = Alu.Sub16(0, DX);
    // MOV AX,0x1 (1000_B898 / 0x1B898)
    AX = 0x1;
    // CALL 0x1000:c30d (1000_B89B / 0x1B89B)
    NearCall(cs1, 0xB89E, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_B89E_1B89E:
    // MOV SI,0x2440 (1000_B89E / 0x1B89E)
    SI = 0x2440;
    // MOV DI,0xd834 (1000_B8A1 / 0x1B8A1)
    DI = 0xD834;
    // JMP 0x1000:5b99 (1000_B8A4 / 0x1B8A4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B8A7_01B8A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B8A7_1B8A7:
    // PUSH DS (1000_B8A7 / 0x1B8A7)
    Stack.Push(DS);
    // POP ES (1000_B8A8 / 0x1B8A8)
    ES = Stack.Pop();
    // MOV DI,0x4c60 (1000_B8A9 / 0x1B8A9)
    DI = 0x4C60;
    // MOV SI,0x92 (1000_B8AC / 0x1B8AC)
    SI = 0x92;
    // CALL 0x1000:f0b9 (1000_B8AF / 0x1B8AF)
    NearCall(cs1, 0xB8B2, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_B8B2_1B8B2:
    // MOV DX,word ptr [0x197c] (1000_B8B2 / 0x1B8B2)
    DX = UInt16[DS, 0x197C];
    // MOV BX,word ptr [0x197e] (1000_B8B6 / 0x1B8B6)
    BX = UInt16[DS, 0x197E];
    // CALL 0x1000:ba75 (1000_B8BA / 0x1B8BA)
    NearCall(cs1, 0xB8BD, spice86_generated_label_call_target_1000_BA75_01BA75);
    label_1000_B8BD_1B8BD:
    // MOV AX,0x1 (1000_B8BD / 0x1B8BD)
    AX = 0x1;
    // CALL 0x1000:c13e (1000_B8C0 / 0x1B8C0)
    NearCall(cs1, 0xB8C3, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_B8C3_1B8C3:
    // JMP 0x1000:c0f4 (1000_B8C3 / 0x1B8C3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B8C6_01B8C6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B8C6_1B8C6:
    // CALL 0x1000:d2bd (1000_B8C6 / 0x1B8C6)
    NearCall(cs1, 0xB8C9, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    label_1000_B8C9_1B8C9:
    // CALL 0x1000:5adf (1000_B8C9 / 0x1B8C9)
    NearCall(cs1, 0xB8CC, spice86_generated_label_call_target_1000_5ADF_015ADF);
    label_1000_B8CC_1B8CC:
    // CALL 0x1000:b8a7 (1000_B8CC / 0x1B8CC)
    NearCall(cs1, 0xB8CF, spice86_generated_label_call_target_1000_B8A7_01B8A7);
    label_1000_B8CF_1B8CF:
    // INC byte ptr [0xdd03] (1000_B8CF / 0x1B8CF)
    UInt8[DS, 0xDD03] = Alu.Inc8(UInt8[DS, 0xDD03]);
    // XOR AL,AL (1000_B8D3 / 0x1B8D3)
    AL = 0;
    // MOV DX,0xffff (1000_B8D5 / 0x1B8D5)
    DX = 0xFFFF;
    // MOV BP,0xb827 (1000_B8D8 / 0x1B8D8)
    BP = 0xB827;
    // CALL 0x1000:c108 (1000_B8DB / 0x1B8DB)
    NearCall(cs1, 0xB8DE, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_B8DE_1B8DE:
    // CALL 0x1000:ae04 (1000_B8DE / 0x1B8DE)
    NearCall(cs1, 0xB8E1, spice86_generated_label_call_target_1000_AE04_01AE04);
    label_1000_B8E1_1B8E1:
    // MOV AX,0x2562 (1000_B8E1 / 0x1B8E1)
    AX = 0x2562;
    // CALL 0x1000:d95e (1000_B8E4 / 0x1B8E4)
    NearCall(cs1, 0xB8E7, spice86_generated_label_call_target_1000_D95E_01D95E);
    label_1000_B8E7_1B8E7:
    // CALL 0x1000:17e6 (1000_B8E7 / 0x1B8E7)
    NearCall(cs1, 0xB8EA, spice86_generated_label_call_target_1000_17E6_0117E6);
    label_1000_B8EA_1B8EA:
    // MOV SI,0xb9ae (1000_B8EA / 0x1B8EA)
    SI = 0xB9AE;
    // MOV BP,0x1 (1000_B8ED / 0x1B8ED)
    BP = 0x1;
    // JMP 0x1000:da25 (1000_B8F0 / 0x1B8F0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA25_01DA25, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B8F3_01B8F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B8F3_1B8F3:
    // CALL 0x1000:b84a (1000_B8F3 / 0x1B8F3)
    NearCall(cs1, 0xB8F6, spice86_generated_label_call_target_1000_B84A_01B84A);
    label_1000_B8F6_1B8F6:
    // MOV BP,0xbe1d (1000_B8F6 / 0x1B8F6)
    BP = 0xBE1D;
    // CALL 0x1000:c097 (1000_B8F9 / 0x1B8F9)
    NearCall(cs1, 0xB8FC, spice86_generated_label_call_target_1000_C097_01C097);
    label_1000_B8FC_1B8FC:
    // CALL 0x1000:c474 (1000_B8FC / 0x1B8FC)
    NearCall(cs1, 0xB8FF, spice86_generated_label_call_target_1000_C474_01C474);
    label_1000_B8FF_1B8FF:
    // CALL 0x1000:c43e (1000_B8FF / 0x1B8FF)
    NearCall(cs1, 0xB902, spice86_generated_label_call_target_1000_C43E_01C43E);
    label_1000_B902_1B902:
    // CALL 0x1000:b87e (1000_B902 / 0x1B902)
    NearCall(cs1, 0xB905, spice86_generated_label_call_target_1000_B87E_01B87E);
    label_1000_B905_1B905:
    // CALL 0x1000:c4dd (1000_B905 / 0x1B905)
    NearCall(cs1, 0xB908, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_B908_1B908:
    // SUB word ptr [0xdd0f],0x10 (1000_B908 / 0x1B908)
    UInt16[DS, 0xDD0F] -= 0x10;
    
    // CMP word ptr [0xdd0f],-0x6a (1000_B90D / 0x1B90D)
    Alu.Sub16(UInt16[DS, 0xDD0F], 0xFF96);
    // JG 0x1000:b8ff (1000_B912 / 0x1B912)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_B8FF_1B8FF;
    }
    // RET  (1000_B914 / 0x1B914)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B930_01B930(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B930_1B930:
    // MOV byte ptr [0xdd03],0x0 (1000_B930 / 0x1B930)
    UInt8[DS, 0xDD03] = 0x0;
    // MOV SI,0xb9ae (1000_B935 / 0x1B935)
    SI = 0xB9AE;
    // CALL 0x1000:da5f (1000_B938 / 0x1B938)
    NearCall(cs1, 0xB93B, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_B93B_1B93B:
    // MOV SI,0xbe57 (1000_B93B / 0x1B93B)
    SI = 0xBE57;
    // JMP 0x1000:da5f (1000_B93E / 0x1B93E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B941_01B941(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B941_1B941:
    // MOV BP,0x204a (1000_B941 / 0x1B941)
    BP = 0x204A;
    // MOV AX,0xb1 (1000_B944 / 0x1B944)
    AX = 0xB1;
    // MOV BX,0xb96b (1000_B947 / 0x1B947)
    BX = 0xB96B;
    // CMP byte ptr [0xdd02],0x0 (1000_B94A / 0x1B94A)
    Alu.Sub8(UInt8[DS, 0xDD02], 0x0);
    // JZ 0x1000:b955 (1000_B94F / 0x1B94F)
    if(ZeroFlag) {
      goto label_1000_B955_1B955;
    }
    // INC AX (1000_B951 / 0x1B951)
    AX = Alu.Inc16(AX);
    // MOV BX,0xb961 (1000_B952 / 0x1B952)
    BX = 0xB961;
    label_1000_B955_1B955:
    // MOV word ptr [BP + 0x6],AX (1000_B955 / 0x1B955)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    // MOV word ptr [BP + 0x8],BX (1000_B958 / 0x1B958)
    UInt16[SS, (ushort)(BP + 0x8)] = BX;
    // MOV BX,0xd917 (1000_B95B / 0x1B95B)
    BX = 0xD917;
    // JMP 0x1000:d338 (1000_B95E / 0x1B95E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D338_01D338, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B977_01B977(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B977_1B977:
    // MOV BP,0x4948 (1000_B977 / 0x1B977)
    BP = 0x4948;
    // MOV ES,word ptr [0xdbd6] (1000_B97A / 0x1B97A)
    ES = UInt16[DS, 0xDBD6];
    // MOV AL,[0xdd02] (1000_B97E / 0x1B97E)
    AL = UInt8[DS, 0xDD02];
    // LDS SI,[0xdcfe] (1000_B981 / 0x1B981)
    DS = UInt16[DS, 0xDD00];
    SI = UInt16[DS, 0xDCFE];
    // CALLF [0x3911] (1000_B985 / 0x1B985)
    // Indirect call to [0x3911], generating possible targets from emulator records
    uint targetAddress_1000_B985 = (uint)(UInt16[SS, 0x3913] * 0x10 + UInt16[SS, 0x3911] - cs1 * 0x10);
    switch(targetAddress_1000_B985) {
      case 0x235F5 : FarCall(cs1, 0xB98A, spice86_generated_label_call_target_334B_0145_0335F5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B985));
        break;
    }
    label_1000_B98A_1B98A:
    // RET  (1000_B98A / 0x1B98A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B98B_01B98B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xB98E: goto label_1000_B98E_1B98E;break; // Target of external jump from 0x1B9B6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B98B_1B98B:
    // CALL 0x1000:b977 (1000_B98B / 0x1B98B)
    NearCall(cs1, 0xB98E, spice86_generated_label_call_target_1000_B977_01B977);
    label_1000_B98E_1B98E:
    // CALL 0x1000:baf2 (1000_B98E / 0x1B98E)
    NearCall(cs1, 0xB991, spice86_generated_label_call_target_1000_BAF2_01BAF2);
    label_1000_B991_1B991:
    // PUSH BX (1000_B991 / 0x1B991)
    Stack.Push(BX);
    // PUSH DX (1000_B992 / 0x1B992)
    Stack.Push(DX);
    // MOV SI,0xd834 (1000_B993 / 0x1B993)
    SI = 0xD834;
    // CALL 0x1000:db74 (1000_B996 / 0x1B996)
    NearCall(cs1, 0xB999, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_B999_1B999:
    // CALL 0x1000:c4ed (1000_B999 / 0x1B999)
    NearCall(cs1, 0xB99C, spice86_generated_label_call_target_1000_C4ED_01C4ED);
    label_1000_B99C_1B99C:
    // POP DX (1000_B99C / 0x1B99C)
    DX = Stack.Pop();
    // POP BX (1000_B99D / 0x1B99D)
    BX = Stack.Pop();
    // OR DX,DX (1000_B99E / 0x1B99E)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:b9a5 (1000_B9A0 / 0x1B9A0)
    if(ZeroFlag) {
      goto label_1000_B9A5_1B9A5;
    }
    // CALL 0x1000:bc0c (1000_B9A2 / 0x1B9A2)
    NearCall(cs1, 0xB9A5, spice86_generated_label_call_target_1000_BC0C_01BC0C);
    label_1000_B9A5_1B9A5:
    // CALL 0x1000:db67 (1000_B9A5 / 0x1B9A5)
    NearCall(cs1, 0xB9A8, spice86_generated_label_call_target_1000_DB67_01DB67);
    label_1000_B9A8_1B9A8:
    // MOV AX,0x1 (1000_B9A8 / 0x1B9A8)
    AX = 0x1;
    // JMP 0x1000:b9e0 (1000_B9AB / 0x1B9AB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B9E0_01B9E0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B9AE_01B9AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B9AE_1B9AE:
    // MOV ES,word ptr [0xdbd6] (1000_B9AE / 0x1B9AE)
    ES = UInt16[DS, 0xDBD6];
    // CALLF [0x3915] (1000_B9B2 / 0x1B9B2)
    // Indirect call to [0x3915], generating possible targets from emulator records
    uint targetAddress_1000_B9B2 = (uint)(UInt16[DS, 0x3917] * 0x10 + UInt16[DS, 0x3915] - cs1 * 0x10);
    switch(targetAddress_1000_B9B2) {
      case 0x235F8 : throw FailAsUntested("Could not find a valid function at address 334B_0148 / 0x335F8");
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B9B2));
        break;
    }
    label_1000_B9B6_1B9B6:
    // JC 0x1000:b98e (1000_B9B6 / 0x1B9B6)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B98B_01B98B, 0x1B98E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_B9B8 / 0x1B9B8)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B9E0_01B9E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B9E0_1B9E0:
    // MOV SI,0x494c (1000_B9E0 / 0x1B9E0)
    SI = 0x494C;
    // MOV DX,word ptr [SI] (1000_B9E3 / 0x1B9E3)
    DX = UInt16[DS, SI];
    // MOV CX,0x18e (1000_B9E5 / 0x1B9E5)
    CX = 0x18E;
    // ADD DX,AX (1000_B9E8 / 0x1B9E8)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // JNS 0x1000:b9ee (1000_B9EA / 0x1B9EA)
    if(!SignFlag) {
      goto label_1000_B9EE_1B9EE;
    }
    // ADD DX,CX (1000_B9EC / 0x1B9EC)
    DX += CX;
    
    label_1000_B9EE_1B9EE:
    // CMP DX,CX (1000_B9EE / 0x1B9EE)
    Alu.Sub16(DX, CX);
    // JS 0x1000:b9f4 (1000_B9F0 / 0x1B9F0)
    if(SignFlag) {
      goto label_1000_B9F4_1B9F4;
    }
    // SUB DX,CX (1000_B9F2 / 0x1B9F2)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    label_1000_B9F4_1B9F4:
    // MOV word ptr [SI],DX (1000_B9F4 / 0x1B9F4)
    UInt16[DS, SI] = DX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B9F6_01B9F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B9F6_01B9F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B9F6_1B9F6:
    // MOV AX,0x8000 (1000_B9F6 / 0x1B9F6)
    AX = 0x8000;
    // MOV CX,0x18e (1000_B9F9 / 0x1B9F9)
    CX = 0x18E;
    // DIV CX (1000_B9FC / 0x1B9FC)
    Cpu.Div16(CX);
    // MOV CX,0x62 (1000_B9FE / 0x1B9FE)
    CX = 0x62;
    // MOV BX,AX (1000_BA01 / 0x1BA01)
    BX = AX;
    label_1000_BA03_1BA03:
    // ADD SI,0x6 (1000_BA03 / 0x1BA03)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    // LODSW SI (1000_BA06 / 0x1BA06)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MUL BX (1000_BA07 / 0x1BA07)
    Cpu.Mul16(BX);
    // ADD AX,AX (1000_BA09 / 0x1BA09)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // ADC DX,DX (1000_BA0B / 0x1BA0B)
    DX = Alu.Adc16(DX, DX);
    // MOV word ptr [SI],DX (1000_BA0D / 0x1BA0D)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],AX (1000_BA0F / 0x1BA0F)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // LOOP 0x1000:ba03 (1000_BA12 / 0x1BA12)
    if(--CX != 0) {
      goto label_1000_BA03_1BA03;
    }
    // RET  (1000_BA14 / 0x1BA14)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BA15_01BA15(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xBA2D: goto label_1000_BA2D_1BA2D;break; // Target of external jump from 0x1BA9C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_BA15_1BA15:
    // ADD AX,word ptr [0x2460] (1000_BA15 / 0x1BA15)
    // AX += UInt16[DS, 0x2460];
    AX = Alu.Add16(AX, UInt16[DS, 0x2460]);
    // MOV CX,0x62 (1000_BA19 / 0x1BA19)
    CX = 0x62;
    // CMP AX,CX (1000_BA1C / 0x1BA1C)
    Alu.Sub16(AX, CX);
    // JL 0x1000:ba22 (1000_BA1E / 0x1BA1E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_BA22_1BA22;
    }
    // MOV AX,CX (1000_BA20 / 0x1BA20)
    AX = CX;
    label_1000_BA22_1BA22:
    // NEG CX (1000_BA22 / 0x1BA22)
    CX = Alu.Sub16(0, CX);
    // CMP AX,CX (1000_BA24 / 0x1BA24)
    Alu.Sub16(AX, CX);
    // JG 0x1000:ba2a (1000_BA26 / 0x1BA26)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_BA2A_1BA2A;
    }
    // MOV AX,CX (1000_BA28 / 0x1BA28)
    AX = CX;
    label_1000_BA2A_1BA2A:
    // MOV [0x2460],AX (1000_BA2A / 0x1BA2A)
    UInt16[DS, 0x2460] = AX;
    label_1000_BA2D_1BA2D:
    // PUSH DS (1000_BA2D / 0x1BA2D)
    Stack.Push(DS);
    // POP ES (1000_BA2E / 0x1BA2E)
    ES = Stack.Pop();
    // MOV DI,0x8b77 (1000_BA2F / 0x1BA2F)
    DI = 0x8B77;
    // MOV BX,0x62 (1000_BA32 / 0x1BA32)
    BX = 0x62;
    // MOV CX,0xc4 (1000_BA35 / 0x1BA35)
    CX = 0xC4;
    // MOV AX,[0x2460] (1000_BA38 / 0x1BA38)
    AX = UInt16[DS, 0x2460];
    // ADD AX,BX (1000_BA3B / 0x1BA3B)
    AX += BX;
    
    // CMP AX,BX (1000_BA3D / 0x1BA3D)
    Alu.Sub16(AX, BX);
    // JLE 0x1000:ba55 (1000_BA3F / 0x1BA3F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_BA55_1BA55;
    }
    // NEG BX (1000_BA41 / 0x1BA41)
    BX = Alu.Sub16(0, BX);
    // ADD AL,BL (1000_BA43 / 0x1BA43)
    AL += BL;
    
    // ADD AL,BL (1000_BA45 / 0x1BA45)
    AL += BL;
    
    label_1000_BA47_1BA47:
    // DEC AL (1000_BA47 / 0x1BA47)
    AL = Alu.Dec8(AL);
    // STOSW ES:DI (1000_BA49 / 0x1BA49)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP AL,BL (1000_BA4A / 0x1BA4A)
    Alu.Sub8(AL, BL);
    // JLE 0x1000:ba50 (1000_BA4C / 0x1BA4C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_BA50_1BA50;
    }
    // LOOP 0x1000:ba47 (1000_BA4E / 0x1BA4E)
    if(--CX != 0) {
      goto label_1000_BA47_1BA47;
    }
    label_1000_BA50_1BA50:
    // NEG BX (1000_BA50 / 0x1BA50)
    BX = Alu.Sub16(0, BX);
    // MOV AX,BX (1000_BA52 / 0x1BA52)
    AX = BX;
    // DEC CX (1000_BA54 / 0x1BA54)
    CX = Alu.Dec16(CX);
    label_1000_BA55_1BA55:
    // STOSW ES:DI (1000_BA55 / 0x1BA55)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // DEC AL (1000_BA56 / 0x1BA56)
    AL = Alu.Dec8(AL);
    // JS 0x1000:ba5c (1000_BA58 / 0x1BA58)
    if(SignFlag) {
      goto label_1000_BA5C_1BA5C;
    }
    // LOOP 0x1000:ba55 (1000_BA5A / 0x1BA5A)
    if(--CX != 0) {
      goto label_1000_BA55_1BA55;
    }
    label_1000_BA5C_1BA5C:
    // DEC CX (1000_BA5C / 0x1BA5C)
    CX = Alu.Dec16(CX);
    // JLE 0x1000:ba74 (1000_BA5D / 0x1BA5D)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_BA74 / 0x1BA74)
      return NearRet();
    }
    // NEG AX (1000_BA5F / 0x1BA5F)
    AX = Alu.Sub16(0, AX);
    label_1000_BA61_1BA61:
    // STOSW ES:DI (1000_BA61 / 0x1BA61)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // INC AL (1000_BA62 / 0x1BA62)
    AL = Alu.Inc8(AL);
    // CMP AL,BL (1000_BA64 / 0x1BA64)
    Alu.Sub8(AL, BL);
    // JG 0x1000:ba6a (1000_BA66 / 0x1BA66)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_BA6A_1BA6A;
    }
    // LOOP 0x1000:ba61 (1000_BA68 / 0x1BA68)
    if(--CX != 0) {
      goto label_1000_BA61_1BA61;
    }
    label_1000_BA6A_1BA6A:
    // DEC CX (1000_BA6A / 0x1BA6A)
    CX = Alu.Dec16(CX);
    // JLE 0x1000:ba74 (1000_BA6B / 0x1BA6B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_BA74 / 0x1BA74)
      return NearRet();
    }
    // NEG AL (1000_BA6D / 0x1BA6D)
    AL = Alu.Sub8(0, AL);
    label_1000_BA6F_1BA6F:
    // INC AL (1000_BA6F / 0x1BA6F)
    AL = Alu.Inc8(AL);
    // STOSW ES:DI (1000_BA71 / 0x1BA71)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x1000:ba6f (1000_BA72 / 0x1BA72)
    if(--CX != 0) {
      goto label_1000_BA6F_1BA6F;
    }
    label_1000_BA74_1BA74:
    // RET  (1000_BA74 / 0x1BA74)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BA75_01BA75(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BA75_1BA75:
    // MOV SI,0x494c (1000_BA75 / 0x1BA75)
    SI = 0x494C;
    // MOV AX,0x18e (1000_BA78 / 0x1BA78)
    AX = 0x18E;
    // MUL DX (1000_BA7B / 0x1BA7B)
    Cpu.Mul16(DX);
    // MOV word ptr [SI],DX (1000_BA7D / 0x1BA7D)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],0x0 (1000_BA7F / 0x1BA7F)
    UInt16[DS, (ushort)(SI + 0x2)] = 0x0;
    // MOV AX,BX (1000_BA84 / 0x1BA84)
    AX = BX;
    // CMP AX,0x20 (1000_BA86 / 0x1BA86)
    Alu.Sub16(AX, 0x20);
    // JNC 0x1000:ba8e (1000_BA89 / 0x1BA89)
    if(!CarryFlag) {
      goto label_1000_BA8E_1BA8E;
    }
    // MOV AX,0x20 (1000_BA8B / 0x1BA8B)
    AX = 0x20;
    label_1000_BA8E_1BA8E:
    // CMP AX,0xffe0 (1000_BA8E / 0x1BA8E)
    Alu.Sub16(AX, 0xFFE0);
    // JC 0x1000:ba96 (1000_BA91 / 0x1BA91)
    if(CarryFlag) {
      goto label_1000_BA96_1BA96;
    }
    // MOV AX,0xffe0 (1000_BA93 / 0x1BA93)
    AX = 0xFFE0;
    label_1000_BA96_1BA96:
    // MOV [0x2460],AX (1000_BA96 / 0x1BA96)
    UInt16[DS, 0x2460] = AX;
    // CALL 0x1000:b9f6 (1000_BA99 / 0x1BA99)
    NearCall(cs1, 0xBA9C, spice86_generated_label_call_target_1000_B9F6_01B9F6);
    label_1000_BA9C_1BA9C:
    // JMP 0x1000:ba2d (1000_BA9C / 0x1BA9C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_BA15_01BA15, 0x1BA2D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_BA9E_01BA9E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BA9E_1BA9E:
    // CALL 0x1000:407e (1000_BA9E / 0x1BA9E)
    NearCall(cs1, 0xBAA1, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_BAA1_1BAA1:
    // MOV AX,0x18e (1000_BAA1 / 0x1BAA1)
    AX = 0x18E;
    // MUL DX (1000_BAA4 / 0x1BAA4)
    Cpu.Mul16(DX);
    // MOV BP,word ptr [0x494a] (1000_BAA6 / 0x1BAA6)
    BP = UInt16[DS, 0x494A];
    // ADD BP,BP (1000_BAAA / 0x1BAAA)
    BP += BP;
    
    // SUB DX,word ptr [0x494c] (1000_BAAC / 0x1BAAC)
    // DX -= UInt16[DS, 0x494C];
    DX = Alu.Sub16(DX, UInt16[DS, 0x494C]);
    // CALL 0x1000:b683 (1000_BAB0 / 0x1BAB0)
    NearCall(cs1, 0xBAB3, spice86_generated_label_call_target_1000_B683_01B683);
    label_1000_BAB3_1BAB3:
    // MOV CX,0x1 (1000_BAB3 / 0x1BAB3)
    CX = 0x1;
    // MOV AX,0x20 (1000_BAB6 / 0x1BAB6)
    AX = 0x20;
    // CMP DX,AX (1000_BAB9 / 0x1BAB9)
    Alu.Sub16(DX, AX);
    // JL 0x1000:bac0 (1000_BABB / 0x1BABB)
    if(SignFlag != OverflowFlag) {
      goto label_1000_BAC0_1BAC0;
    }
    // MOV DX,AX (1000_BABD / 0x1BABD)
    DX = AX;
    // INC CX (1000_BABF / 0x1BABF)
    CX = Alu.Inc16(CX);
    label_1000_BAC0_1BAC0:
    // NEG AX (1000_BAC0 / 0x1BAC0)
    AX = Alu.Sub16(0, AX);
    // CMP DX,AX (1000_BAC2 / 0x1BAC2)
    Alu.Sub16(DX, AX);
    // JG 0x1000:bac9 (1000_BAC4 / 0x1BAC4)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_BAC9_1BAC9;
    }
    // MOV DX,AX (1000_BAC6 / 0x1BAC6)
    DX = AX;
    // INC CX (1000_BAC8 / 0x1BAC8)
    CX = Alu.Inc16(CX);
    label_1000_BAC9_1BAC9:
    // SUB BX,word ptr [0x2460] (1000_BAC9 / 0x1BAC9)
    // BX -= UInt16[DS, 0x2460];
    BX = Alu.Sub16(BX, UInt16[DS, 0x2460]);
    // MOV AX,0x18 (1000_BACD / 0x1BACD)
    AX = 0x18;
    // CMP BX,AX (1000_BAD0 / 0x1BAD0)
    Alu.Sub16(BX, AX);
    // JL 0x1000:bad7 (1000_BAD2 / 0x1BAD2)
    if(SignFlag != OverflowFlag) {
      goto label_1000_BAD7_1BAD7;
    }
    // MOV BX,AX (1000_BAD4 / 0x1BAD4)
    BX = AX;
    // INC CX (1000_BAD6 / 0x1BAD6)
    CX = Alu.Inc16(CX);
    label_1000_BAD7_1BAD7:
    // NEG AX (1000_BAD7 / 0x1BAD7)
    AX = Alu.Sub16(0, AX);
    // CMP BX,AX (1000_BAD9 / 0x1BAD9)
    Alu.Sub16(BX, AX);
    // JG 0x1000:bae0 (1000_BADB / 0x1BADB)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_BAE0_1BAE0;
    }
    // MOV BX,AX (1000_BADD / 0x1BADD)
    BX = AX;
    // INC CX (1000_BADF / 0x1BADF)
    CX = Alu.Inc16(CX);
    label_1000_BAE0_1BAE0:
    // MOV AX,DX (1000_BAE0 / 0x1BAE0)
    AX = DX;
    // PUSH CX (1000_BAE2 / 0x1BAE2)
    Stack.Push(CX);
    // PUSH BX (1000_BAE3 / 0x1BAE3)
    Stack.Push(BX);
    // CALL 0x1000:b9e0 (1000_BAE4 / 0x1BAE4)
    NearCall(cs1, 0xBAE7, spice86_generated_label_call_target_1000_B9E0_01B9E0);
    label_1000_BAE7_1BAE7:
    // POP AX (1000_BAE7 / 0x1BAE7)
    AX = Stack.Pop();
    // CALL 0x1000:ba15 (1000_BAE8 / 0x1BAE8)
    NearCall(cs1, 0xBAEB, spice86_generated_label_call_target_1000_BA15_01BA15);
    label_1000_BAEB_1BAEB:
    // CALL 0x1000:b98b (1000_BAEB / 0x1BAEB)
    NearCall(cs1, 0xBAEE, spice86_generated_label_call_target_1000_B98B_01B98B);
    label_1000_BAEE_1BAEE:
    // POP CX (1000_BAEE / 0x1BAEE)
    CX = Stack.Pop();
    // LOOP 0x1000:ba9e (1000_BAEF / 0x1BAEF)
    if(--CX != 0) {
      goto label_1000_BA9E_1BA9E;
    }
    label_1000_BAF1_1BAF1:
    // RET  (1000_BAF1 / 0x1BAF1)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BAF2_01BAF2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BAF2_1BAF2:
    // XOR DX,DX (1000_BAF2 / 0x1BAF2)
    DX = 0;
    // CMP byte ptr [0x227d],0x0 (1000_BAF4 / 0x1BAF4)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:baf1 (1000_BAF9 / 0x1BAF9)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_BAF1 / 0x1BAF1)
      return NearRet();
    }
    // CALL 0x1000:407e (1000_BAFB / 0x1BAFB)
    NearCall(cs1, 0xBAFE, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_BAFE_1BAFE:
    // SUB SP,0xa (1000_BAFE / 0x1BAFE)
    // SP -= 0xA;
    SP = Alu.Sub16(SP, 0xA);
    // MOV BP,SP (1000_BB01 / 0x1BB01)
    BP = SP;
    // MOV word ptr [BP + 0x0],0x0 (1000_BB03 / 0x1BB03)
    UInt16[SS, BP] = 0x0;
    // SHL BX,0x1 (1000_BB08 / 0x1BB08)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_BB0A / 0x1BB0A)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_BB0C / 0x1BB0C)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // JNS 0x1000:bb16 (1000_BB0E / 0x1BB0E)
    if(!SignFlag) {
      goto label_1000_BB16_1BB16;
    }
    // MOV byte ptr [BP + 0x1],0xff (1000_BB10 / 0x1BB10)
    UInt8[SS, (ushort)(BP + 0x1)] = 0xFF;
    // NEG BX (1000_BB14 / 0x1BB14)
    BX = Alu.Sub16(0, BX);
    label_1000_BB16_1BB16:
    // MOV CX,word ptr [BX + 0x494a] (1000_BB16 / 0x1BB16)
    CX = UInt16[DS, (ushort)(BX + 0x494A)];
    // MOV AX,CX (1000_BB1A / 0x1BB1A)
    AX = CX;
    // ADD AX,AX (1000_BB1C / 0x1BB1C)
    AX += AX;
    
    // MUL DX (1000_BB1E / 0x1BB1E)
    Cpu.Mul16(DX);
    // ADD AX,AX (1000_BB20 / 0x1BB20)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // ADC DX,0x0 (1000_BB22 / 0x1BB22)
    DX = Alu.Adc16(DX, 0x0);
    // XOR AX,AX (1000_BB25 / 0x1BB25)
    AX = 0;
    // SUB DX,word ptr [BX + 0x494c] (1000_BB27 / 0x1BB27)
    // DX -= UInt16[DS, (ushort)(BX + 0x494C)];
    DX = Alu.Sub16(DX, UInt16[DS, (ushort)(BX + 0x494C)]);
    // JNS 0x1000:bb31 (1000_BB2B / 0x1BB2B)
    if(!SignFlag) {
      goto label_1000_BB31_1BB31;
    }
    // NEG DX (1000_BB2D / 0x1BB2D)
    DX = Alu.Sub16(0, DX);
    // NOT AX (1000_BB2F / 0x1BB2F)
    AX = (ushort)~AX;
    label_1000_BB31_1BB31:
    // CMP DX,CX (1000_BB31 / 0x1BB31)
    Alu.Sub16(DX, CX);
    // JC 0x1000:bb3d (1000_BB33 / 0x1BB33)
    if(CarryFlag) {
      goto label_1000_BB3D_1BB3D;
    }
    // SUB DX,CX (1000_BB35 / 0x1BB35)
    DX -= CX;
    
    // SUB DX,CX (1000_BB37 / 0x1BB37)
    DX -= CX;
    
    // NEG DX (1000_BB39 / 0x1BB39)
    DX = Alu.Sub16(0, DX);
    // NOT AX (1000_BB3B / 0x1BB3B)
    AX = (ushort)~AX;
    label_1000_BB3D_1BB3D:
    // SHR CX,0x1 (1000_BB3D / 0x1BB3D)
    CX >>= 0x1;
    
    // CMP DX,CX (1000_BB3F / 0x1BB3F)
    Alu.Sub16(DX, CX);
    // JC 0x1000:bb4d (1000_BB41 / 0x1BB41)
    if(CarryFlag) {
      goto label_1000_BB4D_1BB4D;
    }
    // MOV byte ptr [BP + 0x0],0x80 (1000_BB43 / 0x1BB43)
    UInt8[SS, BP] = 0x80;
    // SUB DX,CX (1000_BB47 / 0x1BB47)
    DX -= CX;
    
    // SUB DX,CX (1000_BB49 / 0x1BB49)
    DX -= CX;
    
    // NEG DX (1000_BB4B / 0x1BB4B)
    DX = Alu.Sub16(0, DX);
    label_1000_BB4D_1BB4D:
    // MOV byte ptr [BP + 0x4],AL (1000_BB4D / 0x1BB4D)
    UInt8[SS, (ushort)(BP + 0x4)] = AL;
    // SHR BX,0x1 (1000_BB50 / 0x1BB50)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_BB52 / 0x1BB52)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // PUSH DS (1000_BB54 / 0x1BB54)
    Stack.Push(DS);
    // POP ES (1000_BB55 / 0x1BB55)
    ES = Stack.Pop();
    // MOV DI,0x593a (1000_BB56 / 0x1BB56)
    DI = 0x593A;
    // MOV AX,BX (1000_BB59 / 0x1BB59)
    AX = BX;
    // MOV CX,0x64 (1000_BB5B / 0x1BB5B)
    CX = 0x64;
    // XOR BX,BX (1000_BB5E / 0x1BB5E)
    BX = 0;
    label_1000_BB60_1BB60:
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_BB60 / 0x1BB60)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    // JNZ 0x1000:bb7a (1000_BB62 / 0x1BB62)
    if(!ZeroFlag) {
      goto label_1000_BB7A_1BB7A;
    }
    // INC CX (1000_BB64 / 0x1BB64)
    CX = Alu.Inc16(CX);
    // CMP DL,byte ptr [DI + 0x63] (1000_BB65 / 0x1BB65)
    Alu.Sub8(DL, UInt8[DS, (ushort)(DI + 0x63)]);
    // JBE 0x1000:bb7d (1000_BB68 / 0x1BB68)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_BB7D_1BB7D;
    }
    // MOV word ptr [BP + 0x2],CX (1000_BB6A / 0x1BB6A)
    UInt16[SS, (ushort)(BP + 0x2)] = CX;
    // INC BX (1000_BB6D / 0x1BB6D)
    BX = Alu.Inc16(BX);
    // ADD DI,0xc7 (1000_BB6E / 0x1BB6E)
    DI += 0xC7;
    
    // CMP DI,0x8b3b (1000_BB72 / 0x1BB72)
    Alu.Sub16(DI, 0x8B3B);
    // JC 0x1000:bb60 (1000_BB76 / 0x1BB76)
    if(CarryFlag) {
      goto label_1000_BB60_1BB60;
    }
    // JMP 0x1000:bbe6 (1000_BB78 / 0x1BB78)
    goto label_1000_BBE6_1BBE6;
    label_1000_BB7A_1BB7A:
    // MOV CX,word ptr [BP + 0x2] (1000_BB7A / 0x1BB7A)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    label_1000_BB7D_1BB7D:
    // MOV AX,0x64 (1000_BB7D / 0x1BB7D)
    AX = 0x64;
    // SUB AX,CX (1000_BB80 / 0x1BB80)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // MOV word ptr [BP + 0x2],BX (1000_BB82 / 0x1BB82)
    UInt16[SS, (ushort)(BP + 0x2)] = BX;
    // MOV CX,word ptr [BP + 0x0] (1000_BB85 / 0x1BB85)
    CX = UInt16[SS, BP];
    // MOV AH,CH (1000_BB88 / 0x1BB88)
    AH = CH;
    // OR CL,CL (1000_BB8A / 0x1BB8A)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JNS 0x1000:bb90 (1000_BB8C / 0x1BB8C)
    if(!SignFlag) {
      goto label_1000_BB90_1BB90;
    }
    // NEG AL (1000_BB8E / 0x1BB8E)
    AL = Alu.Sub8(0, AL);
    label_1000_BB90_1BB90:
    // MOV DI,0x8bbb (1000_BB90 / 0x1BB90)
    DI = 0x8BBB;
    // MOV CX,0x80 (1000_BB93 / 0x1BB93)
    CX = 0x80;
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASW ES:DI (1000_BB96 / 0x1BB96)
      Alu.Sub16(AX, UInt16[ES, DI]);
      DI = (ushort)(DI + Direction16);
      if(ZeroFlag != false) {
        break;
      }
    }
    // JNZ 0x1000:bbe6 (1000_BB98 / 0x1BB98)
    if(!ZeroFlag) {
      goto label_1000_BBE6_1BBE6;
    }
    // XOR AL,AL (1000_BB9A / 0x1BB9A)
    AL = 0;
    // SUB DI,0x8c3d (1000_BB9C / 0x1BB9C)
    // DI -= 0x8C3D;
    DI = Alu.Sub16(DI, 0x8C3D);
    // JNS 0x1000:bba6 (1000_BBA0 / 0x1BBA0)
    if(!SignFlag) {
      goto label_1000_BBA6_1BBA6;
    }
    // NEG DI (1000_BBA2 / 0x1BBA2)
    DI = Alu.Sub16(0, DI);
    // NOT AL (1000_BBA4 / 0x1BBA4)
    AL = (byte)~AL;
    label_1000_BBA6_1BBA6:
    // MOV byte ptr [BP + 0x5],AL (1000_BBA6 / 0x1BBA6)
    UInt8[SS, (ushort)(BP + 0x5)] = AL;
    // MOV BX,0x36 (1000_BBA9 / 0x1BBA9)
    BX = 0x36;
    // MOV AX,DI (1000_BBAC / 0x1BBAC)
    AX = DI;
    // SHR AX,0x1 (1000_BBAE / 0x1BBAE)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV SI,0x4c60 (1000_BBB0 / 0x1BBB0)
    SI = 0x4C60;
    // MOV DX,word ptr [BP + 0x2] (1000_BBB3 / 0x1BBB3)
    DX = UInt16[SS, (ushort)(BP + 0x2)];
    // MOV CL,AL (1000_BBB6 / 0x1BBB6)
    CL = AL;
    // MOV CH,0xff (1000_BBB8 / 0x1BBB8)
    CH = 0xFF;
    // XOR AX,AX (1000_BBBA / 0x1BBBA)
    AX = 0;
    label_1000_BBBC_1BBBC:
    // LODSB SI (1000_BBBC / 0x1BBBC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // INC AL (1000_BBBD / 0x1BBBD)
    AL = Alu.Inc8(AL);
    // JZ 0x1000:bbe1 (1000_BBBF / 0x1BBBF)
    if(ZeroFlag) {
      goto label_1000_BBE1_1BBE1;
    }
    // NEG AL (1000_BBC1 / 0x1BBC1)
    AL = Alu.Sub8(0, AL);
    // CMP AL,DL (1000_BBC3 / 0x1BBC3)
    Alu.Sub8(AL, DL);
    // JBE 0x1000:bbe1 (1000_BBC5 / 0x1BBC5)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_BBE1_1BBE1;
    }
    // MOV DI,SI (1000_BBC7 / 0x1BBC7)
    DI = SI;
    // ADD SI,AX (1000_BBC9 / 0x1BBC9)
    SI += AX;
    
    // ADD DI,DX (1000_BBCB / 0x1BBCB)
    // DI += DX;
    DI = Alu.Add16(DI, DX);
    // MOV AL,byte ptr [DI] (1000_BBCD / 0x1BBCD)
    AL = UInt8[DS, DI];
    // SUB AL,CL (1000_BBCF / 0x1BBCF)
    AL -= CL;
    
    // CMP AL,CH (1000_BBD1 / 0x1BBD1)
    Alu.Sub8(AL, CH);
    // JNC 0x1000:bbde (1000_BBD3 / 0x1BBD3)
    if(!CarryFlag) {
      goto label_1000_BBDE_1BBDE;
    }
    // MOV CH,AL (1000_BBD5 / 0x1BBD5)
    CH = AL;
    // MOV word ptr [BP + 0x6],BX (1000_BBD7 / 0x1BBD7)
    UInt16[SS, (ushort)(BP + 0x6)] = BX;
    // OR AL,AL (1000_BBDA / 0x1BBDA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:bbec (1000_BBDC / 0x1BBDC)
    if(ZeroFlag) {
      goto label_1000_BBEC_1BBEC;
    }
    label_1000_BBDE_1BBDE:
    // DEC BX (1000_BBDE / 0x1BBDE)
    BX = Alu.Dec16(BX);
    // JNZ 0x1000:bbbc (1000_BBDF / 0x1BBDF)
    if(!ZeroFlag) {
      goto label_1000_BBBC_1BBBC;
    }
    label_1000_BBE1_1BBE1:
    // CMP CH,0x2 (1000_BBE1 / 0x1BBE1)
    Alu.Sub8(CH, 0x2);
    // JBE 0x1000:bbec (1000_BBE4 / 0x1BBE4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_BBEC_1BBEC;
    }
    label_1000_BBE6_1BBE6:
    // ADD SP,0xa (1000_BBE6 / 0x1BBE6)
    SP += 0xA;
    
    // XOR DX,DX (1000_BBE9 / 0x1BBE9)
    DX = 0;
    // RET  (1000_BBEB / 0x1BBEB)
    return NearRet();
    label_1000_BBEC_1BBEC:
    // MOV AX,word ptr [BP + 0x4] (1000_BBEC / 0x1BBEC)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV BX,word ptr [BP + 0x6] (1000_BBEF / 0x1BBEF)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // SUB BX,0x36 (1000_BBF2 / 0x1BBF2)
    // BX -= 0x36;
    BX = Alu.Sub16(BX, 0x36);
    // OR AH,AH (1000_BBF5 / 0x1BBF5)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:bbfb (1000_BBF7 / 0x1BBF7)
    if(ZeroFlag) {
      goto label_1000_BBFB_1BBFB;
    }
    // NEG BX (1000_BBF9 / 0x1BBF9)
    BX = Alu.Sub16(0, BX);
    label_1000_BBFB_1BBFB:
    // ADD BX,0x4f (1000_BBFB / 0x1BBFB)
    // BX += 0x4F;
    BX = Alu.Add16(BX, 0x4F);
    // OR AL,AL (1000_BBFE / 0x1BBFE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:bc04 (1000_BC00 / 0x1BC00)
    if(ZeroFlag) {
      goto label_1000_BC04_1BC04;
    }
    // NEG DX (1000_BC02 / 0x1BC02)
    DX = Alu.Sub16(0, DX);
    label_1000_BC04_1BC04:
    // ADD DX,0xa0 (1000_BC04 / 0x1BC04)
    DX += 0xA0;
    
    // ADD SP,0xa (1000_BC08 / 0x1BC08)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    // RET  (1000_BC0B / 0x1BC0B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BC0C_01BC0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BC0C_1BC0C:
    // CALL 0x1000:c08e (1000_BC0C / 0x1BC0C)
    NearCall(cs1, 0xBC0F, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_BC0F_1BC0F:
    // CALL 0x1000:c137 (1000_BC0F / 0x1BC0F)
    NearCall(cs1, 0xBC12, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_BC12_1BC12:
    // MOV AX,0x36 (1000_BC12 / 0x1BC12)
    AX = 0x36;
    // CALL 0x1000:c1f4 (1000_BC15 / 0x1BC15)
    NearCall(cs1, 0xBC18, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_BC18_1BC18:
    // SUB BL,byte ptr ES:[SI + 0x2] (1000_BC18 / 0x1BC18)
    // BL -= UInt8[ES, (ushort)(SI + 0x2)];
    BL = Alu.Sub8(BL, UInt8[ES, (ushort)(SI + 0x2)]);
    // JMP 0x1000:c22f (1000_BC1C / 0x1BC1C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_BC1F_01BC1F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BC1F_1BC1F:
    // CALL 0x1000:d41b (1000_BC1F / 0x1BC1F)
    NearCall(cs1, 0xBC22, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_BC22_1BC22:
    // CMP BP,0x204a (1000_BC22 / 0x1BC22)
    Alu.Sub16(BP, 0x204A);
    // JZ 0x1000:bc2c (1000_BC26 / 0x1BC26)
    if(ZeroFlag) {
      goto label_1000_BC2C_1BC2C;
    }
    // CMP BP,0x2062 (1000_BC28 / 0x1BC28)
    Alu.Sub16(BP, 0x2062);
    label_1000_BC2C_1BC2C:
    // JNZ 0x1000:bc4d (1000_BC2C / 0x1BC2C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_BC4D / 0x1BC4D)
      return NearRet();
    }
    // CALL 0x1000:bc4e (1000_BC2E / 0x1BC2E)
    NearCall(cs1, 0xBC31, spice86_generated_label_call_target_1000_BC4E_01BC4E);
    label_1000_BC31_1BC31:
    // JC 0x1000:bc3c (1000_BC31 / 0x1BC31)
    if(CarryFlag) {
      goto label_1000_BC3C_1BC3C;
    }
    // CMP BP,0x204a (1000_BC33 / 0x1BC33)
    Alu.Sub16(BP, 0x204A);
    // JZ 0x1000:bc4d (1000_BC37 / 0x1BC37)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_BC4D / 0x1BC4D)
      return NearRet();
    }
    // JMP 0x1000:b941 (1000_BC39 / 0x1BC39)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B941_01B941, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_BC3C_1BC3C:
    // CMP BP,0x2062 (1000_BC3C / 0x1BC3C)
    Alu.Sub16(BP, 0x2062);
    // JZ 0x1000:bc4d (1000_BC40 / 0x1BC40)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_BC4D / 0x1BC4D)
      return NearRet();
    }
    // MOV BP,0x2062 (1000_BC42 / 0x1BC42)
    BP = 0x2062;
    // MOV BX,0xd917 (1000_BC45 / 0x1BC45)
    BX = 0xD917;
    // XOR CX,CX (1000_BC48 / 0x1BC48)
    CX = 0;
    // JMP 0x1000:d33a (1000_BC4A / 0x1BC4A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D33A_01D33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_BC4D_1BC4D:
    // RET  (1000_BC4D / 0x1BC4D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BC4E_01BC4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BC4E_1BC4E:
    // SUB DX,0x60 (1000_BC4E / 0x1BC4E)
    // DX -= 0x60;
    DX = Alu.Sub16(DX, 0x60);
    // CMC  (1000_BC51 / 0x1BC51)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:bc63 (1000_BC52 / 0x1BC52)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_BC63 / 0x1BC63)
      return NearRet();
    }
    // CMP DX,0x80 (1000_BC54 / 0x1BC54)
    Alu.Sub16(DX, 0x80);
    // JNC 0x1000:bc63 (1000_BC58 / 0x1BC58)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_BC63 / 0x1BC63)
      return NearRet();
    }
    // SUB BX,0x19 (1000_BC5A / 0x1BC5A)
    // BX -= 0x19;
    BX = Alu.Sub16(BX, 0x19);
    // CMC  (1000_BC5D / 0x1BC5D)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:bc63 (1000_BC5E / 0x1BC5E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_BC63 / 0x1BC63)
      return NearRet();
    }
    // CMP BX,0x6d (1000_BC60 / 0x1BC60)
    Alu.Sub16(BX, 0x6D);
    label_1000_BC63_1BC63:
    // RET  (1000_BC63 / 0x1BC63)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BC99_01BC99(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BC99_1BC99:
    // MOV SI,0xdd06 (1000_BC99 / 0x1BC99)
    SI = 0xDD06;
    // MOV word ptr [SI],DX (1000_BC9C / 0x1BC9C)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_BC9E / 0x1BC9E)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // INC DX (1000_BCA1 / 0x1BCA1)
    DX = Alu.Inc16(DX);
    // INC DX (1000_BCA2 / 0x1BCA2)
    DX = Alu.Inc16(DX);
    // INC BX (1000_BCA3 / 0x1BCA3)
    BX = Alu.Inc16(BX);
    // MOV word ptr [SI + 0x4],DX (1000_BCA4 / 0x1BCA4)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    // MOV word ptr [SI + 0x6],BX (1000_BCA7 / 0x1BCA7)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV byte ptr [SI + 0x8],0x7 (1000_BCAA / 0x1BCAA)
    UInt8[DS, (ushort)(SI + 0x8)] = 0x7;
    // CALL 0x1000:c08e (1000_BCAE / 0x1BCAE)
    NearCall(cs1, 0xBCB1, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_BCB1_1BCB1:
    // MOV CX,0x8 (1000_BCB1 / 0x1BCB1)
    CX = 0x8;
    label_1000_BCB4_1BCB4:
    // PUSH CX (1000_BCB4 / 0x1BCB4)
    Stack.Push(CX);
    // MOV SI,0xdd06 (1000_BCB5 / 0x1BCB5)
    SI = 0xDD06;
    // MOV DI,0x2440 (1000_BCB8 / 0x1BCB8)
    DI = 0x2440;
    // MOV CX,0x2 (1000_BCBB / 0x1BCBB)
    CX = 0x2;
    // MOV DX,0xfffc (1000_BCBE / 0x1BCBE)
    DX = 0xFFFC;
    label_1000_BCC1_1BCC1:
    // MOV AX,word ptr [SI] (1000_BCC1 / 0x1BCC1)
    AX = UInt16[DS, SI];
    // ADD AX,DX (1000_BCC3 / 0x1BCC3)
    AX += DX;
    
    // CMP AX,word ptr [DI] (1000_BCC5 / 0x1BCC5)
    Alu.Sub16(AX, UInt16[DS, DI]);
    // JNC 0x1000:bccb (1000_BCC7 / 0x1BCC7)
    if(!CarryFlag) {
      goto label_1000_BCCB_1BCCB;
    }
    // MOV AX,word ptr [DI] (1000_BCC9 / 0x1BCC9)
    AX = UInt16[DS, DI];
    label_1000_BCCB_1BCCB:
    // MOV word ptr [SI],AX (1000_BCCB / 0x1BCCB)
    UInt16[DS, SI] = AX;
    // ADD DI,0x2 (1000_BCCD / 0x1BCCD)
    DI += 0x2;
    
    // ADD SI,0x2 (1000_BCD0 / 0x1BCD0)
    SI += 0x2;
    
    // SAR DX,0x1 (1000_BCD3 / 0x1BCD3)
    DX = Alu.Sar16(DX, 0x1);
    // LOOP 0x1000:bcc1 (1000_BCD5 / 0x1BCD5)
    if(--CX != 0) {
      goto label_1000_BCC1_1BCC1;
    }
    // MOV CX,0x2 (1000_BCD7 / 0x1BCD7)
    CX = 0x2;
    // MOV DX,0x4 (1000_BCDA / 0x1BCDA)
    DX = 0x4;
    label_1000_BCDD_1BCDD:
    // MOV AX,word ptr [SI] (1000_BCDD / 0x1BCDD)
    AX = UInt16[DS, SI];
    // ADD AX,DX (1000_BCDF / 0x1BCDF)
    AX += DX;
    
    // CMP AX,word ptr [DI] (1000_BCE1 / 0x1BCE1)
    Alu.Sub16(AX, UInt16[DS, DI]);
    // JC 0x1000:bce7 (1000_BCE3 / 0x1BCE3)
    if(CarryFlag) {
      goto label_1000_BCE7_1BCE7;
    }
    // MOV AX,word ptr [DI] (1000_BCE5 / 0x1BCE5)
    AX = UInt16[DS, DI];
    label_1000_BCE7_1BCE7:
    // MOV word ptr [SI],AX (1000_BCE7 / 0x1BCE7)
    UInt16[DS, SI] = AX;
    // ADD DI,0x2 (1000_BCE9 / 0x1BCE9)
    DI += 0x2;
    
    // ADD SI,0x2 (1000_BCEC / 0x1BCEC)
    SI += 0x2;
    
    // SAR DX,0x1 (1000_BCEF / 0x1BCEF)
    DX = Alu.Sar16(DX, 0x1);
    // LOOP 0x1000:bcdd (1000_BCF1 / 0x1BCF1)
    if(--CX != 0) {
      goto label_1000_BCDD_1BCDD;
    }
    // MOV SI,0xdd06 (1000_BCF3 / 0x1BCF3)
    SI = 0xDD06;
    // CALL 0x1000:c551 (1000_BCF6 / 0x1BCF6)
    NearCall(cs1, 0xBCF9, spice86_generated_label_call_target_1000_C551_01C551);
    label_1000_BCF9_1BCF9:
    // CALL 0x1000:bd00 (1000_BCF9 / 0x1BCF9)
    NearCall(cs1, 0xBCFC, spice86_generated_label_call_target_1000_BD00_01BD00);
    label_1000_BCFC_1BCFC:
    // POP CX (1000_BCFC / 0x1BCFC)
    CX = Stack.Pop();
    // LOOP 0x1000:bcb4 (1000_BCFD / 0x1BCFD)
    if(--CX != 0) {
      goto label_1000_BCB4_1BCB4;
    }
    // RET  (1000_BCFF / 0x1BCFF)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BD00_01BD00(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BD00_1BD00:
    // XOR AX,AX (1000_BD00 / 0x1BD00)
    AX = 0;
    // MOV CX,0xa (1000_BD02 / 0x1BD02)
    CX = 0xA;
    // MOV SI,0xdd06 (1000_BD05 / 0x1BD05)
    SI = 0xDD06;
    // INC word ptr [SI] (1000_BD08 / 0x1BD08)
    UInt16[DS, SI] = Alu.Inc16(UInt16[DS, SI]);
    // INC word ptr [SI + 0x2] (1000_BD0A / 0x1BD0A)
    UInt16[DS, (ushort)(SI + 0x2)] = Alu.Inc16(UInt16[DS, (ushort)(SI + 0x2)]);
    // DEC word ptr [SI + 0x4] (1000_BD0D / 0x1BD0D)
    UInt16[DS, (ushort)(SI + 0x4)] = Alu.Dec16(UInt16[DS, (ushort)(SI + 0x4)]);
    // DEC word ptr [SI + 0x6] (1000_BD10 / 0x1BD10)
    UInt16[DS, (ushort)(SI + 0x6)] = Alu.Dec16(UInt16[DS, (ushort)(SI + 0x6)]);
    // CALL 0x1000:c0d5 (1000_BD13 / 0x1BD13)
    NearCall(cs1, 0xBD16, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    label_1000_BD16_1BD16:
    // MOV SI,0xdd06 (1000_BD16 / 0x1BD16)
    SI = 0xDD06;
    // DEC word ptr [SI] (1000_BD19 / 0x1BD19)
    UInt16[DS, SI] = Alu.Dec16(UInt16[DS, SI]);
    // DEC word ptr [SI + 0x2] (1000_BD1B / 0x1BD1B)
    UInt16[DS, (ushort)(SI + 0x2)] = Alu.Dec16(UInt16[DS, (ushort)(SI + 0x2)]);
    // INC word ptr [SI + 0x4] (1000_BD1E / 0x1BD1E)
    UInt16[DS, (ushort)(SI + 0x4)] = Alu.Inc16(UInt16[DS, (ushort)(SI + 0x4)]);
    // INC word ptr [SI + 0x6] (1000_BD21 / 0x1BD21)
    UInt16[DS, (ushort)(SI + 0x6)] = Alu.Inc16(UInt16[DS, (ushort)(SI + 0x6)]);
    // RET  (1000_BD24 / 0x1BD24)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BDFA_01BDFA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BDFA_1BDFA:
    // MOV SI,0xc2 (1000_BDFA / 0x1BDFA)
    SI = 0xC2;
    // CALL 0x1000:1ad1 (1000_BDFD / 0x1BDFD)
    NearCall(cs1, 0xBE00, spice86_generated_label_call_target_1000_1AD1_011AD1);
    label_1000_BE00_1BE00:
    // INC AX (1000_BE00 / 0x1BE00)
    AX = Alu.Inc16(AX);
    // CALL 0x1000:e2db (1000_BE01 / 0x1BE01)
    NearCall(cs1, 0xBE04, spice86_generated_label_call_target_1000_E2DB_01E2DB);
    label_1000_BE04_1BE04:
    // CALL 0x1000:bfa7 (1000_BE04 / 0x1BE04)
    NearCall(cs1, 0xBE07, spice86_generated_label_call_target_1000_BFA7_01BFA7);
    label_1000_BE07_1BE07:
    // MOV AL,[0x29] (1000_BE07 / 0x1BE07)
    AL = UInt8[DS, 0x29];
    // XOR AH,AH (1000_BE0A / 0x1BE0A)
    AH = 0;
    // SHR AX,0x1 (1000_BE0C / 0x1BE0C)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV SI,0xc3 (1000_BE0E / 0x1BE0E)
    SI = 0xC3;
    // CALL 0x1000:e2db (1000_BE11 / 0x1BE11)
    NearCall(cs1, 0xBE14, spice86_generated_label_call_target_1000_E2DB_01E2DB);
    label_1000_BE14_1BE14:
    // CALL 0x1000:d068 (1000_BE14 / 0x1BE14)
    NearCall(cs1, 0xBE17, spice86_generated_label_call_target_1000_D068_01D068);
    label_1000_BE17_1BE17:
    // MOV SI,0x2482 (1000_BE17 / 0x1BE17)
    SI = 0x2482;
    // JMP 0x1000:d1a6 (1000_BE1A / 0x1BE1A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1A6_01D1A6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_BE1D_01BE1D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BE1D_1BE1D:
    // MOV AX,0x1 (1000_BE1D / 0x1BE1D)
    AX = 0x1;
    // CALL 0x1000:c13e (1000_BE20 / 0x1BE20)
    NearCall(cs1, 0xBE23, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_BE23_1BE23:
    // MOV SI,0x2506 (1000_BE23 / 0x1BE23)
    SI = 0x2506;
    // CALL 0x1000:c21b (1000_BE26 / 0x1BE26)
    NearCall(cs1, 0xBE29, spice86_generated_label_call_target_1000_C21B_01C21B);
    label_1000_BE29_1BE29:
    // CALL 0x1000:bed7 (1000_BE29 / 0x1BE29)
    NearCall(cs1, 0xBE2C, spice86_generated_label_call_target_1000_BED7_01BED7);
    label_1000_BE2C_1BE2C:
    // CALL 0x1000:bdfa (1000_BE2C / 0x1BE2C)
    NearCall(cs1, 0xBE2F, spice86_generated_label_call_target_1000_BDFA_01BDFA);
    label_1000_BE2F_1BE2F:
    // MOV SI,0xdd17 (1000_BE2F / 0x1BE2F)
    SI = 0xDD17;
    // XOR AX,AX (1000_BE32 / 0x1BE32)
    AX = 0;
    // MOV word ptr [SI],AX (1000_BE34 / 0x1BE34)
    UInt16[DS, SI] = AX;
    // MOV word ptr [SI + 0x2],AX (1000_BE36 / 0x1BE36)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // MOV word ptr [SI + 0x4],AX (1000_BE39 / 0x1BE39)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    // MOV AX,[0x2] (1000_BE3C / 0x1BE3C)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BE3F / 0x1BE3F)
    // AX &= 0xFFF0;
    AX = Alu.And16(AX, 0xFFF0);
    // MOV [0x115c],AX (1000_BE42 / 0x1BE42)
    UInt16[DS, 0x115C] = AX;
    // CALL 0x1000:d075 (1000_BE45 / 0x1BE45)
    NearCall(cs1, 0xBE48, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_BE48_1BE48:
    // MOV SI,0x2494 (1000_BE48 / 0x1BE48)
    SI = 0x2494;
    // CALL 0x1000:d1a6 (1000_BE4B / 0x1BE4B)
    NearCall(cs1, 0xBE4E, spice86_generated_label_call_target_1000_D1A6_01D1A6);
    label_1000_BE4E_1BE4E:
    // MOV SI,0xbe57 (1000_BE4E / 0x1BE4E)
    SI = 0xBE57;
    // MOV BP,0xc (1000_BE51 / 0x1BE51)
    BP = 0xC;
    // CALL 0x1000:da25 (1000_BE54 / 0x1BE54)
    NearCall(cs1, 0xBE57, spice86_generated_label_call_target_1000_DA25_01DA25);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BE57_01BE57, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_ret_target_1000_BE57_01BE57(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BE57_1BE57:
    // CALL 0x1000:c08e (1000_BE57 / 0x1BE57)
    NearCall(cs1, 0xBE5A, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_BE5A_1BE5A:
    // MOV SI,0x1470 (1000_BE5A / 0x1BE5A)
    SI = 0x1470;
    // CALL 0x1000:db74 (1000_BE5D / 0x1BE5D)
    NearCall(cs1, 0xBE60, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_BE60_1BE60:
    // CALL 0x1000:c137 (1000_BE60 / 0x1BE60)
    NearCall(cs1, 0xBE63, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_BE63_1BE63:
    // MOV SI,0xdd11 (1000_BE63 / 0x1BE63)
    SI = 0xDD11;
    // XOR BP,BP (1000_BE66 / 0x1BE66)
    BP = 0;
    label_1000_BE68_1BE68:
    // MOV CL,byte ptr [SI] (1000_BE68 / 0x1BE68)
    CL = UInt8[DS, SI];
    // SUB CL,byte ptr [SI + 0x6] (1000_BE6A / 0x1BE6A)
    // CL -= UInt8[DS, (ushort)(SI + 0x6)];
    CL = Alu.Sub8(CL, UInt8[DS, (ushort)(SI + 0x6)]);
    // JZ 0x1000:becd (1000_BE6D / 0x1BE6D)
    if(ZeroFlag) {
      goto label_1000_BECD_1BECD;
    }
    // MOV AL,0x1 (1000_BE6F / 0x1BE6F)
    AL = 0x1;
    // JNC 0x1000:be75 (1000_BE71 / 0x1BE71)
    if(!CarryFlag) {
      goto label_1000_BE75_1BE75;
    }
    // NEG AL (1000_BE73 / 0x1BE73)
    AL = Alu.Sub8(0, AL);
    label_1000_BE75_1BE75:
    // ADD byte ptr [SI + 0x6],AL (1000_BE75 / 0x1BE75)
    // UInt8[DS, (ushort)(SI + 0x6)] += AL;
    UInt8[DS, (ushort)(SI + 0x6)] = Alu.Add8(UInt8[DS, (ushort)(SI + 0x6)], AL);
    // MOV AL,byte ptr [SI + 0x6] (1000_BE78 / 0x1BE78)
    AL = UInt8[DS, (ushort)(SI + 0x6)];
    // CMP AL,0x1e (1000_BE7B / 0x1BE7B)
    Alu.Sub8(AL, 0x1E);
    // JC 0x1000:be81 (1000_BE7D / 0x1BE7D)
    if(CarryFlag) {
      goto label_1000_BE81_1BE81;
    }
    // MOV AL,0x1e (1000_BE7F / 0x1BE7F)
    AL = 0x1E;
    label_1000_BE81_1BE81:
    // MOV BX,BP (1000_BE81 / 0x1BE81)
    BX = BP;
    // SHL BX,0x1 (1000_BE83 / 0x1BE83)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_BE85 / 0x1BE85)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV DX,word ptr [BX + 0x24ee] (1000_BE87 / 0x1BE87)
    DX = UInt16[DS, (ushort)(BX + 0x24EE)];
    // MOV BX,word ptr [BX + 0x24f0] (1000_BE8B / 0x1BE8B)
    BX = UInt16[DS, (ushort)(BX + 0x24F0)];
    // XOR AH,AH (1000_BE8F / 0x1BE8F)
    AH = 0;
    // SUB BX,AX (1000_BE91 / 0x1BE91)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // PUSH SI (1000_BE93 / 0x1BE93)
    Stack.Push(SI);
    // PUSH BP (1000_BE94 / 0x1BE94)
    Stack.Push(BP);
    // MOV AX,0x37 (1000_BE95 / 0x1BE95)
    AX = 0x37;
    // SHR BP,0x1 (1000_BE98 / 0x1BE98)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // ADC AX,0x0 (1000_BE9A / 0x1BE9A)
    AX = Alu.Adc16(AX, 0x0);
    // CALL 0x1000:c2fd (1000_BE9D / 0x1BE9D)
    NearCall(cs1, 0xBEA0, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_BEA0_1BEA0:
    // SUB BX,0xa (1000_BEA0 / 0x1BEA0)
    // BX -= 0xA;
    BX = Alu.Sub16(BX, 0xA);
    // MOV AX,0x39 (1000_BEA3 / 0x1BEA3)
    AX = 0x39;
    // CALL 0x1000:c2fd (1000_BEA6 / 0x1BEA6)
    NearCall(cs1, 0xBEA9, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_BEA9_1BEA9:
    // POP BP (1000_BEA9 / 0x1BEA9)
    BP = Stack.Pop();
    // POP SI (1000_BEAA / 0x1BEAA)
    SI = Stack.Pop();
    // MOV AL,byte ptr [SI] (1000_BEAB / 0x1BEAB)
    AL = UInt8[DS, SI];
    // CMP AL,byte ptr [SI + 0x6] (1000_BEAD / 0x1BEAD)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x6)]);
    // JNZ 0x1000:becd (1000_BEB0 / 0x1BEB0)
    if(!ZeroFlag) {
      goto label_1000_BECD_1BECD;
    }
    // TEST BP,0x1 (1000_BEB2 / 0x1BEB2)
    Alu.And16(BP, 0x1);
    // MOV AX,0x3f (1000_BEB6 / 0x1BEB6)
    AX = 0x3F;
    // JZ 0x1000:bebd (1000_BEB9 / 0x1BEB9)
    if(ZeroFlag) {
      goto label_1000_BEBD_1BEBD;
    }
    // MOV AL,0x25 (1000_BEBB / 0x1BEBB)
    AL = 0x25;
    label_1000_BEBD_1BEBD:
    // MOV [0xdbe4],AX (1000_BEBD / 0x1BEBD)
    UInt16[DS, 0xDBE4] = AX;
    // ADD DX,0x4 (1000_BEC0 / 0x1BEC0)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // CALL 0x1000:d04e (1000_BEC3 / 0x1BEC3)
    NearCall(cs1, 0xBEC6, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_BEC6_1BEC6:
    // MOV AL,byte ptr [BP + 0x116a] (1000_BEC6 / 0x1BEC6)
    AL = UInt8[SS, (ushort)(BP + 0x116A)];
    // CALL 0x1000:d12f (1000_BECA / 0x1BECA)
    NearCall(cs1, 0xBECD, spice86_generated_label_call_target_1000_D12F_01D12F);
    label_1000_BECD_1BECD:
    // INC SI (1000_BECD / 0x1BECD)
    SI = Alu.Inc16(SI);
    // INC BP (1000_BECE / 0x1BECE)
    BP = Alu.Inc16(BP);
    // CMP BP,0x6 (1000_BECF / 0x1BECF)
    Alu.Sub16(BP, 0x6);
    // JC 0x1000:be68 (1000_BED2 / 0x1BED2)
    if(CarryFlag) {
      goto label_1000_BE68_1BE68;
    }
    // JMP 0x1000:c07c (1000_BED4 / 0x1BED4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_BED7_01BED7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BED7_1BED7:
    // MOV AX,[0x2] (1000_BED7 / 0x1BED7)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BEDA / 0x1BEDA)
    // AX &= 0xFFF0;
    AX = Alu.And16(AX, 0xFFF0);
    // MOV [0x115c],AX (1000_BEDD / 0x1BEDD)
    UInt16[DS, 0x115C] = AX;
    // CALL 0x1000:c02e (1000_BEE0 / 0x1BEE0)
    NearCall(cs1, 0xBEE3, spice86_generated_label_call_target_1000_C02E_01C02E);
    label_1000_BEE3_1BEE3:
    // CALL 0x1000:bf26 (1000_BEE3 / 0x1BEE3)
    NearCall(cs1, 0xBEE6, spice86_generated_label_call_target_1000_BF26_01BF26);
    label_1000_BEE6_1BEE6:
    // PUSH DS (1000_BEE6 / 0x1BEE6)
    Stack.Push(DS);
    // POP ES (1000_BEE7 / 0x1BEE7)
    ES = Stack.Pop();
    // MOV DI,0xdd11 (1000_BEE8 / 0x1BEE8)
    DI = 0xDD11;
    // MOV AX,[0xa4] (1000_BEEB / 0x1BEEB)
    AX = UInt16[DS, 0xA4];
    // SHR AX,0x1 (1000_BEEE / 0x1BEEE)
    AX >>= 0x1;
    
    // INC AX (1000_BEF0 / 0x1BEF0)
    AX = Alu.Inc16(AX);
    // STOSB ES:DI (1000_BEF1 / 0x1BEF1)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xa2] (1000_BEF2 / 0x1BEF2)
    AX = UInt16[DS, 0xA2];
    // SHR AX,0x1 (1000_BEF5 / 0x1BEF5)
    AX >>= 0x1;
    
    // INC AX (1000_BEF7 / 0x1BEF7)
    AX = Alu.Inc16(AX);
    // STOSB ES:DI (1000_BEF8 / 0x1BEF8)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xa8] (1000_BEF9 / 0x1BEF9)
    AX = UInt16[DS, 0xA8];
    // SHR AX,0x1 (1000_BEFC / 0x1BEFC)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_BEFE / 0x1BEFE)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_BF00 / 0x1BF00)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_BF02 / 0x1BF02)
    AX >>= 0x1;
    
    // INC AL (1000_BF04 / 0x1BF04)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF06 / 0x1BF06)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xa6] (1000_BF07 / 0x1BF07)
    AX = UInt16[DS, 0xA6];
    // SHR AX,0x1 (1000_BF0A / 0x1BF0A)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_BF0C / 0x1BF0C)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_BF0E / 0x1BF0E)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_BF10 / 0x1BF10)
    AX >>= 0x1;
    
    // INC AL (1000_BF12 / 0x1BF12)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF14 / 0x1BF14)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xac] (1000_BF15 / 0x1BF15)
    AX = UInt16[DS, 0xAC];
    // MOV AL,AH (1000_BF18 / 0x1BF18)
    AL = AH;
    // INC AL (1000_BF1A / 0x1BF1A)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF1C / 0x1BF1C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AX,[0xaa] (1000_BF1D / 0x1BF1D)
    AX = UInt16[DS, 0xAA];
    // MOV AL,AH (1000_BF20 / 0x1BF20)
    AL = AH;
    // INC AL (1000_BF22 / 0x1BF22)
    AL = Alu.Inc8(AL);
    // STOSB ES:DI (1000_BF24 / 0x1BF24)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // RET  (1000_BF25 / 0x1BF25)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BF26_01BF26(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BF26_1BF26:
    // MOV DI,0x115e (1000_BF26 / 0x1BF26)
    DI = 0x115E;
    // MOV BP,0x116a (1000_BF29 / 0x1BF29)
    BP = 0x116A;
    // MOV SI,0xc4 (1000_BF2C / 0x1BF2C)
    SI = 0xC4;
    // CALL 0x1000:cf70 (1000_BF2F / 0x1BF2F)
    NearCall(cs1, 0xBF32, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_BF32_1BF32:
    // MOV AX,[0xa4] (1000_BF32 / 0x1BF32)
    AX = UInt16[DS, 0xA4];
    // CALL 0x1000:bf73 (1000_BF35 / 0x1BF35)
    NearCall(cs1, 0xBF38, spice86_generated_label_call_target_1000_BF73_01BF73);
    label_1000_BF38_1BF38:
    // MOV AX,[0xa2] (1000_BF38 / 0x1BF38)
    AX = UInt16[DS, 0xA2];
    // CALL 0x1000:bf73 (1000_BF3B / 0x1BF3B)
    NearCall(cs1, 0xBF3E, spice86_generated_label_call_target_1000_BF73_01BF73);
    label_1000_BF3E_1BF3E:
    // MOV AX,[0xa8] (1000_BF3E / 0x1BF3E)
    AX = UInt16[DS, 0xA8];
    // CALL 0x1000:bf61 (1000_BF41 / 0x1BF41)
    NearCall(cs1, 0xBF44, spice86_generated_label_call_target_1000_BF61_01BF61);
    label_1000_BF44_1BF44:
    // MOV AX,[0xa6] (1000_BF44 / 0x1BF44)
    AX = UInt16[DS, 0xA6];
    // CALL 0x1000:bf61 (1000_BF47 / 0x1BF47)
    NearCall(cs1, 0xBF4A, spice86_generated_label_call_target_1000_BF61_01BF61);
    label_1000_BF4A_1BF4A:
    // MOV AX,[0xac] (1000_BF4A / 0x1BF4A)
    AX = UInt16[DS, 0xAC];
    // CALL 0x1000:bf61 (1000_BF4D / 0x1BF4D)
    NearCall(cs1, 0xBF50, spice86_generated_label_call_target_1000_BF61_01BF61);
    label_1000_BF50_1BF50:
    // MOV AX,[0xaa] (1000_BF50 / 0x1BF50)
    AX = UInt16[DS, 0xAA];
    // JMP 0x1000:bf61 (1000_BF53 / 0x1BF53)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_BF61_01BF61, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_BF61_01BF61(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BF61_1BF61:
    // PUSH DI (1000_BF61 / 0x1BF61)
    Stack.Push(DI);
    // PUSH AX (1000_BF62 / 0x1BF62)
    Stack.Push(AX);
    // CALL 0x1000:d03c (1000_BF63 / 0x1BF63)
    NearCall(cs1, 0xBF66, spice86_generated_label_call_target_1000_D03C_01D03C);
    label_1000_BF66_1BF66:
    // DEC SI (1000_BF66 / 0x1BF66)
    SI = Alu.Dec16(SI);
    // MOV byte ptr ES:[SI],0x30 (1000_BF67 / 0x1BF67)
    UInt8[ES, SI] = 0x30;
    // POP AX (1000_BF6B / 0x1BF6B)
    AX = Stack.Pop();
    // PUSH AX (1000_BF6C / 0x1BF6C)
    Stack.Push(AX);
    // CALL 0x1000:e31c (1000_BF6D / 0x1BF6D)
    NearCall(cs1, 0xBF70, spice86_generated_label_call_target_1000_E31C_01E31C);
    label_1000_BF70_1BF70:
    // INC SI (1000_BF70 / 0x1BF70)
    SI = Alu.Inc16(SI);
    // JMP 0x1000:bf7d (1000_BF71 / 0x1BF71)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_BF73_01BF73, 0x1BF7D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_BF73_01BF73(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xBF7D: goto label_1000_BF7D_1BF7D;break; // Target of external jump from 0x1BF71
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_BF73_1BF73:
    // PUSH DI (1000_BF73 / 0x1BF73)
    Stack.Push(DI);
    // PUSH AX (1000_BF74 / 0x1BF74)
    Stack.Push(AX);
    // CALL 0x1000:d03c (1000_BF75 / 0x1BF75)
    NearCall(cs1, 0xBF78, spice86_generated_label_call_target_1000_D03C_01D03C);
    label_1000_BF78_1BF78:
    // POP AX (1000_BF78 / 0x1BF78)
    AX = Stack.Pop();
    // PUSH AX (1000_BF79 / 0x1BF79)
    Stack.Push(AX);
    // CALL 0x1000:e2e3 (1000_BF7A / 0x1BF7A)
    NearCall(cs1, 0xBF7D, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    label_1000_BF7D_1BF7D:
    // POP AX (1000_BF7D / 0x1BF7D)
    AX = Stack.Pop();
    // POP DI (1000_BF7E / 0x1BF7E)
    DI = Stack.Pop();
    // MOV DX,AX (1000_BF7F / 0x1BF7F)
    DX = AX;
    // XCHG word ptr [DI],AX (1000_BF81 / 0x1BF81)
    ushort tmp_1000_BF81 = UInt16[DS, DI];
    UInt16[DS, DI] = AX;
    AX = tmp_1000_BF81;
    // CMP DX,AX (1000_BF83 / 0x1BF83)
    Alu.Sub16(DX, AX);
    // MOV AL,0x3 (1000_BF85 / 0x1BF85)
    AL = 0x3;
    // JNZ 0x1000:bf99 (1000_BF87 / 0x1BF87)
    if(!ZeroFlag) {
      goto label_1000_BF99_1BF99;
    }
    // MOV AX,[0x2] (1000_BF89 / 0x1BF89)
    AX = UInt16[DS, 0x2];
    // AND AX,0xfff0 (1000_BF8C / 0x1BF8C)
    AX &= 0xFFF0;
    
    // CMP word ptr [0x115c],AX (1000_BF8F / 0x1BF8F)
    Alu.Sub16(UInt16[DS, 0x115C], AX);
    // JZ 0x1000:bfa2 (1000_BF93 / 0x1BF93)
    if(ZeroFlag) {
      goto label_1000_BFA2_1BFA2;
    }
    // MOV AL,0x3 (1000_BF95 / 0x1BF95)
    AL = 0x3;
    // JMP 0x1000:bf9f (1000_BF97 / 0x1BF97)
    goto label_1000_BF9F_1BF9F;
    label_1000_BF99_1BF99:
    // MOV AL,0x2 (1000_BF99 / 0x1BF99)
    AL = 0x2;
    // JC 0x1000:bf9f (1000_BF9B / 0x1BF9B)
    if(CarryFlag) {
      goto label_1000_BF9F_1BF9F;
    }
    // DEC AL (1000_BF9D / 0x1BF9D)
    AL = Alu.Dec8(AL);
    label_1000_BF9F_1BF9F:
    // MOV byte ptr [BP + 0x0],AL (1000_BF9F / 0x1BF9F)
    UInt8[SS, BP] = AL;
    label_1000_BFA2_1BFA2:
    // ADD DI,0x2 (1000_BFA2 / 0x1BFA2)
    DI += 0x2;
    
    // INC BP (1000_BFA5 / 0x1BFA5)
    BP = Alu.Inc16(BP);
    // RET  (1000_BFA6 / 0x1BFA6)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BFA7_01BFA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BFA7_1BFA7:
    // MOV BL,byte ptr [0xceeb] (1000_BFA7 / 0x1BFA7)
    BL = UInt8[DS, 0xCEEB];
    // XOR BH,BH (1000_BFAB / 0x1BFAB)
    BH = 0;
    // SHL BX,0x1 (1000_BFAD / 0x1BFAD)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_BFAF / 0x1BFAF)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_BFB1 / 0x1BFB1)
    BX <<= 0x1;
    
    // ADD BX,0x251a (1000_BFB3 / 0x1BFB3)
    // BX += 0x251A;
    BX = Alu.Add16(BX, 0x251A);
    // MOV AX,word ptr ES:[SI + -0x2] (1000_BFB7 / 0x1BFB7)
    AX = UInt16[ES, (ushort)(SI - 0x2)];
    // XCHG AH,AL (1000_BFBB / 0x1BFBB)
    byte tmp_1000_BFBB = AH;
    AH = AL;
    AL = tmp_1000_BFBB;
    // AND AL,0xf (1000_BFBD / 0x1BFBD)
    AL &= 0xF;
    
    // CMP AH,0x31 (1000_BFBF / 0x1BFBF)
    Alu.Sub8(AH, 0x31);
    // JZ 0x1000:bfdd (1000_BFC2 / 0x1BFC2)
    if(ZeroFlag) {
      goto label_1000_BFDD_1BFDD;
    }
    // CMP AL,0x4 (1000_BFC4 / 0x1BFC4)
    Alu.Sub8(AL, 0x4);
    // JNC 0x1000:bfdd (1000_BFC6 / 0x1BFC6)
    if(!CarryFlag) {
      goto label_1000_BFDD_1BFDD;
    }
    // CMP AL,0x1 (1000_BFC8 / 0x1BFC8)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:bfd7 (1000_BFCA / 0x1BFCA)
    if(!ZeroFlag) {
      goto label_1000_BFD7_1BFD7;
    }
    // CMP BX,0x2522 (1000_BFCC / 0x1BFCC)
    Alu.Sub16(BX, 0x2522);
    // JNZ 0x1000:bfd7 (1000_BFD0 / 0x1BFD0)
    if(!ZeroFlag) {
      goto label_1000_BFD7_1BFD7;
    }
    // CMP AH,0x20 (1000_BFD2 / 0x1BFD2)
    Alu.Sub8(AH, 0x20);
    // JNZ 0x1000:bfdd (1000_BFD5 / 0x1BFD5)
    if(!ZeroFlag) {
      goto label_1000_BFDD_1BFDD;
    }
    label_1000_BFD7_1BFD7:
    // XOR AH,AH (1000_BFD7 / 0x1BFD7)
    AH = 0;
    // SHL AX,0x1 (1000_BFD9 / 0x1BFD9)
    AX <<= 0x1;
    
    // ADD BX,AX (1000_BFDB / 0x1BFDB)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    label_1000_BFDD_1BFDD:
    // MOV AX,word ptr [BX] (1000_BFDD / 0x1BFDD)
    AX = UInt16[DS, BX];
    // MOV word ptr ES:[SI],AX (1000_BFDF / 0x1BFDF)
    UInt16[ES, SI] = AX;
    // RET  (1000_BFE2 / 0x1BFE2)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_BFE3_01BFE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_BFE3_1BFE3:
    // PUSH DS (1000_BFE3 / 0x1BFE3)
    Stack.Push(DS);
    // XOR BX,BX (1000_BFE4 / 0x1BFE4)
    BX = 0;
    // XOR DX,DX (1000_BFE6 / 0x1BFE6)
    DX = 0;
    // MOV CX,0xc5f9 (1000_BFE8 / 0x1BFE8)
    CX = 0xC5F9;
    // XOR SI,SI (1000_BFEB / 0x1BFEB)
    SI = 0;
    // MOV DS,word ptr [0xdd00] (1000_BFED / 0x1BFED)
    DS = UInt16[DS, 0xDD00];
    label_1000_BFF1_1BFF1:
    // LODSB SI (1000_BFF1 / 0x1BFF1)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // AND AL,0x30 (1000_BFF2 / 0x1BFF2)
    // AL &= 0x30;
    AL = Alu.And8(AL, 0x30);
    // JZ 0x1000:bffc (1000_BFF4 / 0x1BFF4)
    if(ZeroFlag) {
      goto label_1000_BFFC_1BFFC;
    }
    // INC DX (1000_BFF6 / 0x1BFF6)
    DX = Alu.Inc16(DX);
    // CMP AL,0x30 (1000_BFF7 / 0x1BFF7)
    Alu.Sub8(AL, 0x30);
    // JZ 0x1000:bffc (1000_BFF9 / 0x1BFF9)
    if(ZeroFlag) {
      goto label_1000_BFFC_1BFFC;
    }
    // INC BX (1000_BFFB / 0x1BFFB)
    BX = Alu.Inc16(BX);
    label_1000_BFFC_1BFFC:
    // LOOP 0x1000:bff1 (1000_BFFC / 0x1BFFC)
    if(--CX != 0) {
      goto label_1000_BFF1_1BFF1;
    }
    // SUB DX,BX (1000_BFFE / 0x1BFFE)
    DX -= BX;
    
    // XOR AX,AX (1000_C000 / 0x1C000)
    AX = 0;
    // SUB SI,0x188 (1000_C002 / 0x1C002)
    SI -= 0x188;
    
    // INC SI (1000_C006 / 0x1C006)
    SI = Alu.Inc16(SI);
    // DIV SI (1000_C007 / 0x1C007)
    Cpu.Div16(SI);
    // MOV DX,0x64 (1000_C009 / 0x1C009)
    DX = 0x64;
    // MUL DX (1000_C00C / 0x1C00C)
    Cpu.Mul16(DX);
    // ADD AX,AX (1000_C00E / 0x1C00E)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // ADC DX,0x0 (1000_C010 / 0x1C010)
    DX = Alu.Adc16(DX, 0x0);
    // XCHG BX,DX (1000_C013 / 0x1C013)
    ushort tmp_1000_C013 = BX;
    BX = DX;
    DX = tmp_1000_C013;
    // XOR AX,AX (1000_C015 / 0x1C015)
    AX = 0;
    // DIV SI (1000_C017 / 0x1C017)
    Cpu.Div16(SI);
    // MOV DX,0x64 (1000_C019 / 0x1C019)
    DX = 0x64;
    // MUL DX (1000_C01C / 0x1C01C)
    Cpu.Mul16(DX);
    // ADD AX,AX (1000_C01E / 0x1C01E)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    // ADC DX,0x0 (1000_C020 / 0x1C020)
    DX = Alu.Adc16(DX, 0x0);
    // INC DX (1000_C023 / 0x1C023)
    DX = Alu.Inc16(DX);
    // POP DS (1000_C024 / 0x1C024)
    DS = Stack.Pop();
    // MOV word ptr [0xa2],DX (1000_C025 / 0x1C025)
    UInt16[DS, 0xA2] = DX;
    // MOV word ptr [0xa4],BX (1000_C029 / 0x1C029)
    UInt16[DS, 0xA4] = BX;
    // RET  (1000_C02D / 0x1C02D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C02E_01C02E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C02E_1C02E:
    // CALL 0x1000:bfe3 (1000_C02E / 0x1C02E)
    NearCall(cs1, 0xC031, spice86_generated_label_call_target_1000_BFE3_01BFE3);
    label_1000_C031_1C031:
    // MOV AX,[0xa0] (1000_C031 / 0x1C031)
    AX = UInt16[DS, 0xA0];
    // ADD AX,word ptr [0x1172] (1000_C034 / 0x1C034)
    AX += UInt16[DS, 0x1172];
    
    // SUB AX,word ptr [0x1170] (1000_C038 / 0x1C038)
    // AX -= UInt16[DS, 0x1170];
    AX = Alu.Sub16(AX, UInt16[DS, 0x1170]);
    // JNC 0x1000:c040 (1000_C03C / 0x1C03C)
    if(!CarryFlag) {
      goto label_1000_C040_1C040;
    }
    // XOR AX,AX (1000_C03E / 0x1C03E)
    AX = 0;
    label_1000_C040_1C040:
    // CMP AX,word ptr [0xa6] (1000_C040 / 0x1C040)
    Alu.Sub16(AX, UInt16[DS, 0xA6]);
    // JC 0x1000:c049 (1000_C044 / 0x1C044)
    if(CarryFlag) {
      goto label_1000_C049_1C049;
    }
    // MOV [0xa6],AX (1000_C046 / 0x1C046)
    UInt16[DS, 0xA6] = AX;
    label_1000_C049_1C049:
    // XOR AX,AX (1000_C049 / 0x1C049)
    AX = 0;
    // MOV [0xaa],AX (1000_C04B / 0x1C04B)
    UInt16[DS, 0xAA] = AX;
    // MOV [0xac],AX (1000_C04E / 0x1C04E)
    UInt16[DS, 0xAC] = AX;
    // MOV SI,0x8aa (1000_C051 / 0x1C051)
    SI = 0x8AA;
    label_1000_C054_1C054:
    // MOV AL,byte ptr [SI + 0x1a] (1000_C054 / 0x1C054)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    // TEST byte ptr [SI + 0x3],0x20 (1000_C057 / 0x1C057)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JNZ 0x1000:c073 (1000_C05B / 0x1C05B)
    if(!ZeroFlag) {
      goto label_1000_C073_1C073;
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_C05D / 0x1C05D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JZ 0x1000:c069 (1000_C061 / 0x1C061)
    if(ZeroFlag) {
      goto label_1000_C069_1C069;
    }
    // ADD word ptr [0xac],AX (1000_C063 / 0x1C063)
    // UInt16[DS, 0xAC] += AX;
    UInt16[DS, 0xAC] = Alu.Add16(UInt16[DS, 0xAC], AX);
    // JMP 0x1000:c073 (1000_C067 / 0x1C067)
    goto label_1000_C073_1C073;
    label_1000_C069_1C069:
    // TEST byte ptr [SI + 0x3],0x80 (1000_C069 / 0x1C069)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    // JNZ 0x1000:c073 (1000_C06D / 0x1C06D)
    if(!ZeroFlag) {
      goto label_1000_C073_1C073;
    }
    // ADD word ptr [0xaa],AX (1000_C06F / 0x1C06F)
    UInt16[DS, 0xAA] += AX;
    
    label_1000_C073_1C073:
    // ADD SI,0x1b (1000_C073 / 0x1C073)
    SI += 0x1B;
    
    // CMP byte ptr [SI],0x0 (1000_C076 / 0x1C076)
    Alu.Sub8(UInt8[DS, SI], 0x0);
    // JNZ 0x1000:c054 (1000_C079 / 0x1C079)
    if(!ZeroFlag) {
      goto label_1000_C054_1C054;
    }
    // RET  (1000_C07B / 0x1C07B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C07C_01C07C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C07C_1C07C:
    // PUSH word ptr [0xdbd6] (1000_C07C / 0x1C07C)
    Stack.Push(UInt16[DS, 0xDBD6]);
    // POP word ptr [0xdbda] (1000_C080 / 0x1C080)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_C084 / 0x1C084)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C085_01C085(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C085_1C085:
    // PUSH word ptr [0xdc32] (1000_C085 / 0x1C085)
    Stack.Push(UInt16[DS, 0xDC32]);
    // POP word ptr [0xdbda] (1000_C089 / 0x1C089)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_C08D / 0x1C08D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C08E_01C08E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C08E_1C08E:
    // PUSH word ptr [0xdbd8] (1000_C08E / 0x1C08E)
    Stack.Push(UInt16[DS, 0xDBD8]);
    // POP word ptr [0xdbda] (1000_C092 / 0x1C092)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_C096 / 0x1C096)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C097_01C097(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C097_1C097:
    // CALL 0x1000:c07c (1000_C097 / 0x1C097)
    NearCall(cs1, 0xC09A, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_C09A_1C09A:
    // PUSH word ptr [0xdbd8] (1000_C09A / 0x1C09A)
    Stack.Push(UInt16[DS, 0xDBD8]);
    // PUSH word ptr [0xdbd6] (1000_C09E / 0x1C09E)
    Stack.Push(UInt16[DS, 0xDBD6]);
    // POP word ptr [0xdbd8] (1000_C0A2 / 0x1C0A2)
    UInt16[DS, 0xDBD8] = Stack.Pop();
    // CALL BP (1000_C0A6 / 0x1C0A6)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_C0A6 = (uint)(BP);
    switch(targetAddress_1000_C0A6) {
      case 0x61C : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_061C_01061C); break;
      case 0xF66 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0xD1EF : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_D1EF_01D1EF); break;
      case 0xD75A : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_D75A_01D75A); break;
      case 0x2DB1 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_2DB1_012DB1); break;
      case 0xD717 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_D717_01D717); break;
      case 0x2EB2 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_2EB2_012EB2); break;
      case 0x5A56 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_5A56_015A56); break;
      case 0xB827 : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_B827_01B827); break;
      case 0xBE1D : NearCall(cs1, 0xC0A8, spice86_generated_label_call_target_1000_BE1D_01BE1D); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0A6));
        break;
    }
    label_1000_C0A8_1C0A8:
    // POP word ptr [0xdbd8] (1000_C0A8 / 0x1C0A8)
    UInt16[DS, 0xDBD8] = Stack.Pop();
    // RET  (1000_C0AC / 0x1C0AC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C0AD_01C0AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C0AD_1C0AD:
    // MOV ES,word ptr [0xdbda] (1000_C0AD / 0x1C0AD)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38d5] (1000_C0B1 / 0x1C0B1)
    // Indirect call to [0x38d5], generating possible targets from emulator records
    uint targetAddress_1000_C0B1 = (uint)(UInt16[DS, 0x38D7] * 0x10 + UInt16[DS, 0x38D5] - cs1 * 0x10);
    switch(targetAddress_1000_C0B1) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0B1));
        break;
    }
    // RET  (1000_C0B5 / 0x1C0B5)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C0D5_01C0D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C0D5_1C0D5:
    // PUSH DS (1000_C0D5 / 0x1C0D5)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C0D6 / 0x1C0D6)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C0DA / 0x1C0DA)
    DS = UInt16[DS, 0xDBD6];
    // MOV BP,0xce7a (1000_C0DE / 0x1C0DE)
    BP = 0xCE7A;
    // CALLF [0x392d] (1000_C0E1 / 0x1C0E1)
    // Indirect call to [0x392d], generating possible targets from emulator records
    uint targetAddress_1000_C0E1 = (uint)(UInt16[SS, 0x392F] * 0x10 + UInt16[SS, 0x392D] - cs1 * 0x10);
    switch(targetAddress_1000_C0E1) {
      case 0x2360A : FarCall(cs1, 0xC0E6, spice86_generated_label_call_target_334B_015A_03360A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0E1));
        break;
    }
    label_1000_C0E6_1C0E6:
    // POP DS (1000_C0E6 / 0x1C0E6)
    DS = Stack.Pop();
    // RET  (1000_C0E7 / 0x1C0E7)
    return NearRet();
  }
  
  public Action split_1000_C0E8_01C0E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C0E8_1C0E8:
    // MOV ES,word ptr [0xdbd8] (1000_C0E8 / 0x1C0E8)
    ES = UInt16[DS, 0xDBD8];
    // MOV BP,0xce7a (1000_C0EC / 0x1C0EC)
    BP = 0xCE7A;
    // CALLF [0x392d] (1000_C0EF / 0x1C0EF)
    // Indirect call to [0x392d], generating possible targets from emulator records
    uint targetAddress_1000_C0EF = (uint)(UInt16[DS, 0x392F] * 0x10 + UInt16[DS, 0x392D] - cs1 * 0x10);
    switch(targetAddress_1000_C0EF) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0EF));
        break;
    }
    // RET  (1000_C0F3 / 0x1C0F3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C0F4_01C0F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C0F4_1C0F4:
    // MOV AX,[0xdbd6] (1000_C0F4 / 0x1C0F4)
    AX = UInt16[DS, 0xDBD6];
    // CMP AX,word ptr [0xdbd8] (1000_C0F7 / 0x1C0F7)
    Alu.Sub16(AX, UInt16[DS, 0xDBD8]);
    // JZ 0x1000:c101 (1000_C0FB / 0x1C0FB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C101 / 0x1C101)
      return NearRet();
    }
    // CALLF [0x3935] (1000_C0FD / 0x1C0FD)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_C0FD = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_C0FD) {
      case 0x23610 : FarCall(cs1, 0xC101, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C0FD));
        break;
    }
    label_1000_C101_1C101:
    // RET  (1000_C101 / 0x1C101)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C108_01C108(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C108_1C108:
    // MOV byte ptr [0xdce6],0x80 (1000_C108 / 0x1C108)
    UInt8[DS, 0xDCE6] = 0x80;
    // PUSH AX (1000_C10D / 0x1C10D)
    Stack.Push(AX);
    // PUSH DX (1000_C10E / 0x1C10E)
    Stack.Push(DX);
    // CALL 0x1000:c097 (1000_C10F / 0x1C10F)
    NearCall(cs1, 0xC112, spice86_generated_label_call_target_1000_C097_01C097);
    label_1000_C112_1C112:
    // POP DX (1000_C112 / 0x1C112)
    DX = Stack.Pop();
    // POP AX (1000_C113 / 0x1C113)
    AX = Stack.Pop();
    // PUSH DS (1000_C114 / 0x1C114)
    Stack.Push(DS);
    // MOV SI,word ptr [0xdbde] (1000_C115 / 0x1C115)
    SI = UInt16[DS, 0xDBDE];
    // MOV ES,word ptr [0xdbd8] (1000_C119 / 0x1C119)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C11D / 0x1C11D)
    DS = UInt16[DS, 0xDBD6];
    // MOV BP,0xce7a (1000_C121 / 0x1C121)
    BP = 0xCE7A;
    // CALLF [0x3921] (1000_C124 / 0x1C124)
    // Indirect call to [0x3921], generating possible targets from emulator records
    uint targetAddress_1000_C124 = (uint)(UInt16[SS, 0x3923] * 0x10 + UInt16[SS, 0x3921] - cs1 * 0x10);
    switch(targetAddress_1000_C124) {
      case 0x23601 : FarCall(cs1, 0xC129, spice86_generated_label_call_target_334B_0151_033601); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C124));
        break;
    }
    label_1000_C129_1C129:
    // POP DS (1000_C129 / 0x1C129)
    DS = Stack.Pop();
    // CALL 0x1000:c4cd (1000_C12A / 0x1C12A)
    NearCall(cs1, 0xC12D, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    label_1000_C12D_1C12D:
    // CALLF [0x3935] (1000_C12D / 0x1C12D)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_C12D = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_C12D) {
      case 0x23610 : FarCall(cs1, 0xC131, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C12D));
        break;
    }
    label_1000_C131_1C131:
    // MOV byte ptr [0xdce6],0x0 (1000_C131 / 0x1C131)
    UInt8[DS, 0xDCE6] = 0x0;
    // RET  (1000_C136 / 0x1C136)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C137_01C137(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C137_1C137:
    // XOR AX,AX (1000_C137 / 0x1C137)
    AX = 0;
    // JMP 0x1000:c13e (1000_C139 / 0x1C139)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C13B_01C13B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C13B_1C13B:
    // MOV AX,0x25 (1000_C13B / 0x1C13B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_0B24_10B24
    AX = 0x25;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C13E_01C13E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC1A9: goto label_1000_C1A9_1C1A9;break; // Target of external jump from 0x1C1B5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C13E_1C13E:
    // OR AX,AX (1000_C13E / 0x1C13E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:c1a9 (1000_C140 / 0x1C140)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_C1A9 / 0x1C1A9)
      return NearRet();
    }
    // PUSH BX (1000_C142 / 0x1C142)
    Stack.Push(BX);
    // MOV BX,AX (1000_C143 / 0x1C143)
    BX = AX;
    // XCHG word ptr [0x2784],BX (1000_C145 / 0x1C145)
    ushort tmp_1000_C145 = UInt16[DS, 0x2784];
    UInt16[DS, 0x2784] = BX;
    BX = tmp_1000_C145;
    // CMP AX,BX (1000_C149 / 0x1C149)
    Alu.Sub16(AX, BX);
    // JZ 0x1000:c1a8 (1000_C14B / 0x1C14B)
    if(ZeroFlag) {
      goto label_1000_C1A8_1C1A8;
    }
    // PUSH SI (1000_C14D / 0x1C14D)
    Stack.Push(SI);
    // PUSH DI (1000_C14E / 0x1C14E)
    Stack.Push(DI);
    // SHL BX,0x1 (1000_C14F / 0x1C14F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // JS 0x1000:c15b (1000_C151 / 0x1C151)
    if(SignFlag) {
      goto label_1000_C15B_1C15B;
    }
    // MOV SI,word ptr [0xce7b] (1000_C153 / 0x1C153)
    SI = UInt16[DS, 0xCE7B];
    // MOV word ptr [BX + 0xda8c],SI (1000_C157 / 0x1C157)
    UInt16[DS, (ushort)(BX + 0xDA8C)] = SI;
    label_1000_C15B_1C15B:
    // MOV SI,AX (1000_C15B / 0x1C15B)
    SI = AX;
    // SHL SI,0x1 (1000_C15D / 0x1C15D)
    SI <<= 0x1;
    
    // SHL SI,0x1 (1000_C15F / 0x1C15F)
    SI <<= 0x1;
    
    // ADD SI,0xd844 (1000_C161 / 0x1C161)
    // SI += 0xD844;
    SI = Alu.Add16(SI, 0xD844);
    // LES DI,[SI] (1000_C165 / 0x1C165)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DI = UInt16[DS, SI];
    // MOV BX,ES (1000_C167 / 0x1C167)
    BX = ES;
    // OR BX,BX (1000_C169 / 0x1C169)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:c177 (1000_C16B / 0x1C16B)
    if(ZeroFlag) {
      goto label_1000_C177_1C177;
    }
    // CMP DI,0x2 (1000_C16D / 0x1C16D)
    Alu.Sub16(DI, 0x2);
    // JBE 0x1000:c19e (1000_C170 / 0x1C170)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C19E_1C19E;
    }
    // CALL 0x1000:c1aa (1000_C172 / 0x1C172)
    NearCall(cs1, 0xC175, spice86_generated_label_call_target_1000_C1AA_01C1AA);
    label_1000_C175_1C175:
    // JMP 0x1000:c19e (1000_C175 / 0x1C175)
    goto label_1000_C19E_1C19E;
    label_1000_C177_1C177:
    // PUSH CX (1000_C177 / 0x1C177)
    Stack.Push(CX);
    // PUSH DX (1000_C178 / 0x1C178)
    Stack.Push(DX);
    // PUSH BP (1000_C179 / 0x1C179)
    Stack.Push(BP);
    // PUSH SI (1000_C17A / 0x1C17A)
    Stack.Push(SI);
    // MOV SI,AX (1000_C17B / 0x1C17B)
    SI = AX;
    // CALL 0x1000:f0b9 (1000_C17D / 0x1C17D)
    NearCall(cs1, 0xC180, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_C180_1C180:
    // CMP word ptr ES:[DI],0x2 (1000_C180 / 0x1C180)
    Alu.Sub16(UInt16[ES, DI], 0x2);
    // JBE 0x1000:c189 (1000_C184 / 0x1C184)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C189_1C189;
    }
    // CALL 0x1000:c1aa (1000_C186 / 0x1C186)
    NearCall(cs1, 0xC189, spice86_generated_label_call_target_1000_C1AA_01C1AA);
    label_1000_C189_1C189:
    // POP SI (1000_C189 / 0x1C189)
    SI = Stack.Pop();
    // MOV DI,word ptr ES:[DI] (1000_C18A / 0x1C18A)
    DI = UInt16[ES, DI];
    // SUB CX,DI (1000_C18D / 0x1C18D)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    // MOV word ptr [SI],DI (1000_C18F / 0x1C18F)
    UInt16[DS, SI] = DI;
    // MOV word ptr [SI + 0x2],ES (1000_C191 / 0x1C191)
    UInt16[DS, (ushort)(SI + 0x2)] = ES;
    // MOV AX,[0x2784] (1000_C194 / 0x1C194)
    AX = UInt16[DS, 0x2784];
    // CALLF [0x3905] (1000_C197 / 0x1C197)
    // Indirect call to [0x3905], generating possible targets from emulator records
    uint targetAddress_1000_C197 = (uint)(UInt16[DS, 0x3907] * 0x10 + UInt16[DS, 0x3905] - cs1 * 0x10);
    switch(targetAddress_1000_C197) {
      case 0x235EC : FarCall(cs1, 0xC19B, spice86_generated_label_call_target_334B_013C_0335EC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C197));
        break;
    }
    label_1000_C19B_1C19B:
    // POP BP (1000_C19B / 0x1C19B)
    BP = Stack.Pop();
    // POP DX (1000_C19C / 0x1C19C)
    DX = Stack.Pop();
    // POP CX (1000_C19D / 0x1C19D)
    CX = Stack.Pop();
    label_1000_C19E_1C19E:
    // MOV word ptr [0xdbb0],DI (1000_C19E / 0x1C19E)
    UInt16[DS, 0xDBB0] = DI;
    // MOV word ptr [0xdbb2],ES (1000_C1A2 / 0x1C1A2)
    UInt16[DS, 0xDBB2] = ES;
    // POP DI (1000_C1A6 / 0x1C1A6)
    DI = Stack.Pop();
    // POP SI (1000_C1A7 / 0x1C1A7)
    SI = Stack.Pop();
    label_1000_C1A8_1C1A8:
    // POP BX (1000_C1A8 / 0x1C1A8)
    BX = Stack.Pop();
    label_1000_C1A9_1C1A9:
    // RET  (1000_C1A9 / 0x1C1A9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C1AA_01C1AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C1AA_1C1AA:
    // MOV AX,[0x2784] (1000_C1AA / 0x1C1AA)
    AX = UInt16[DS, 0x2784];
    // MOV AH,AL (1000_C1AD / 0x1C1AD)
    AH = AL;
    // XCHG byte ptr [0xdbb4],AL (1000_C1AF / 0x1C1AF)
    byte tmp_1000_C1AF = UInt8[DS, 0xDBB4];
    UInt8[DS, 0xDBB4] = AL;
    AL = tmp_1000_C1AF;
    // CMP AL,AH (1000_C1B3 / 0x1C1B3)
    Alu.Sub8(AL, AH);
    // JZ 0x1000:c1a9 (1000_C1B5 / 0x1C1B5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C1A9 / 0x1C1A9)
      return NearRet();
    }
    // MOV SI,0x2 (1000_C1B7 / 0x1C1B7)
    SI = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C1BA_01C1BA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C1BA_01C1BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C1BA_1C1BA:
    // PUSH CX (1000_C1BA / 0x1C1BA)
    Stack.Push(CX);
    // PUSH DX (1000_C1BB / 0x1C1BB)
    Stack.Push(DX);
    // PUSH DI (1000_C1BC / 0x1C1BC)
    Stack.Push(DI);
    label_1000_C1BD_1C1BD:
    // LODSW ES:SI (1000_C1BD / 0x1C1BD)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,0x100 (1000_C1BF / 0x1C1BF)
    Alu.Sub16(AX, 0x100);
    // JNZ 0x1000:c1c9 (1000_C1C2 / 0x1C1C2)
    if(!ZeroFlag) {
      goto label_1000_C1C9_1C1C9;
    }
    // ADD SI,0x3 (1000_C1C4 / 0x1C1C4)
    // SI += 0x3;
    SI = Alu.Add16(SI, 0x3);
    // JMP 0x1000:c1bd (1000_C1C7 / 0x1C1C7)
    goto label_1000_C1BD_1C1BD;
    label_1000_C1C9_1C1C9:
    // MOV BX,AX (1000_C1C9 / 0x1C1C9)
    BX = AX;
    // INC AX (1000_C1CB / 0x1C1CB)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:c1f0 (1000_C1CC / 0x1C1CC)
    if(ZeroFlag) {
      goto label_1000_C1F0_1C1F0;
    }
    // MOV CL,BH (1000_C1CE / 0x1C1CE)
    CL = BH;
    // XOR BH,BH (1000_C1D0 / 0x1C1D0)
    BH = 0;
    // AND CX,0xff (1000_C1D2 / 0x1C1D2)
    // CX &= 0xFF;
    CX = Alu.And16(CX, 0xFF);
    // JNZ 0x1000:c1da (1000_C1D6 / 0x1C1D6)
    if(!ZeroFlag) {
      goto label_1000_C1DA_1C1DA;
    }
    // INC CH (1000_C1D8 / 0x1C1D8)
    CH = Alu.Inc8(CH);
    label_1000_C1DA_1C1DA:
    // MOV AX,BX (1000_C1DA / 0x1C1DA)
    AX = BX;
    // ADD BX,BX (1000_C1DC / 0x1C1DC)
    BX += BX;
    
    // ADD BX,AX (1000_C1DE / 0x1C1DE)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // MOV AX,CX (1000_C1E0 / 0x1C1E0)
    AX = CX;
    // ADD CX,CX (1000_C1E2 / 0x1C1E2)
    CX += CX;
    
    // ADD CX,AX (1000_C1E4 / 0x1C1E4)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // MOV DX,SI (1000_C1E6 / 0x1C1E6)
    DX = SI;
    // ADD SI,CX (1000_C1E8 / 0x1C1E8)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    // CALLF [0x38bd] (1000_C1EA / 0x1C1EA)
    // Indirect call to [0x38bd], generating possible targets from emulator records
    uint targetAddress_1000_C1EA = (uint)(UInt16[DS, 0x38BF] * 0x10 + UInt16[DS, 0x38BD] - cs1 * 0x10);
    switch(targetAddress_1000_C1EA) {
      case 0x235B6 : FarCall(cs1, 0xC1EE, spice86_generated_label_call_target_334B_0106_0335B6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C1EA));
        break;
    }
    label_1000_C1EE_1C1EE:
    // JMP 0x1000:c1bd (1000_C1EE / 0x1C1EE)
    goto label_1000_C1BD_1C1BD;
    label_1000_C1F0_1C1F0:
    // POP DI (1000_C1F0 / 0x1C1F0)
    DI = Stack.Pop();
    // POP DX (1000_C1F1 / 0x1C1F1)
    DX = Stack.Pop();
    // POP CX (1000_C1F2 / 0x1C1F2)
    CX = Stack.Pop();
    // RET  (1000_C1F3 / 0x1C1F3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C1F4_01C1F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C1F4_1C1F4:
    // PUSH BX (1000_C1F4 / 0x1C1F4)
    Stack.Push(BX);
    // LES SI,[0xdbb0] (1000_C1F5 / 0x1C1F5)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BX,AX (1000_C1F9 / 0x1C1F9)
    BX = AX;
    // SHL BX,0x1 (1000_C1FB / 0x1C1FB)
    BX <<= 0x1;
    
    // ADD SI,word ptr ES:[BX + SI] (1000_C1FD / 0x1C1FD)
    // SI += UInt16[ES, (ushort)(BX + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BX + SI)]);
    // POP BX (1000_C200 / 0x1C200)
    BX = Stack.Pop();
    // RET  (1000_C201 / 0x1C201)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C21B_01C21B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C21B_1C21B:
    // LODSW SI (1000_C21B / 0x1C21B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,0xffff (1000_C21C / 0x1C21C)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:c26a (1000_C21F / 0x1C21F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C26A / 0x1C26A)
      return NearRet();
    }
    // MOV BX,AX (1000_C221 / 0x1C221)
    BX = AX;
    // LODSW SI (1000_C223 / 0x1C223)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_C224 / 0x1C224)
    DX = AX;
    // LODSW SI (1000_C226 / 0x1C226)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,BX (1000_C227 / 0x1C227)
    ushort tmp_1000_C227 = AX;
    AX = BX;
    BX = tmp_1000_C227;
    // PUSH SI (1000_C228 / 0x1C228)
    Stack.Push(SI);
    // CALL 0x1000:c22f (1000_C229 / 0x1C229)
    NearCall(cs1, 0xC22C, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_C22C_1C22C:
    // POP SI (1000_C22C / 0x1C22C)
    SI = Stack.Pop();
    // JMP 0x1000:c21b (1000_C22D / 0x1C22D)
    goto label_1000_C21B_1C21B;
  }
  
  public Action spice86_generated_label_call_target_1000_C22F_01C22F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C22F_1C22F:
    // MOV ES,word ptr [0xdbda] (1000_C22F / 0x1C22F)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_C233 / 0x1C233)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C237 / 0x1C237)
    BP = AX;
    // AND BP,0x1ff (1000_C239 / 0x1C239)
    BP &= 0x1FF;
    
    // SHL BP,0x1 (1000_C23D / 0x1C23D)
    BP <<= 0x1;
    
    // ADD SI,word ptr DS:[BP + SI] (1000_C23F / 0x1C23F)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // MOV CX,AX (1000_C242 / 0x1C242)
    CX = AX;
    // PUSH AX (1000_C244 / 0x1C244)
    Stack.Push(AX);
    // LODSW SI (1000_C245 / 0x1C245)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // AND CH,0x60 (1000_C246 / 0x1C246)
    // CH &= 0x60;
    CH = Alu.And8(CH, 0x60);
    // OR AH,CH (1000_C249 / 0x1C249)
    // AH |= CH;
    AH = Alu.Or8(AH, CH);
    // MOV DI,AX (1000_C24B / 0x1C24B)
    DI = AX;
    // LODSW SI (1000_C24D / 0x1C24D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_C24E / 0x1C24E)
    CX = AX;
    // CMP byte ptr CS:[0xc21a],0x0 (1000_C250 / 0x1C250)
    Alu.Sub8(UInt8[cs1, 0xC21A], 0x0);
    // JZ 0x1000:c25d (1000_C256 / 0x1C256)
    if(ZeroFlag) {
      goto label_1000_C25D_1C25D;
    }
    // MOV CH,byte ptr CS:[0xc21a] (1000_C258 / 0x1C258)
    CH = UInt8[cs1, 0xC21A];
    label_1000_C25D_1C25D:
    // POP AX (1000_C25D / 0x1C25D)
    AX = Stack.Pop();
    // AND AX,0x1c00 (1000_C25E / 0x1C25E)
    // AX &= 0x1C00;
    AX = Alu.And16(AX, 0x1C00);
    // JNZ 0x1000:c26b (1000_C261 / 0x1C261)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C26B_01C26B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALLF [0x38c9] (1000_C263 / 0x1C263)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_C263 = (uint)(UInt16[SS, 0x38CB] * 0x10 + UInt16[SS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_C263) {
      case 0x235BF : throw FailAsUntested("Could not find a valid function at address 334B_010F / 0x335BF");
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C263));
        break;
    }
    label_1000_C268_1C268:
    // PUSH SS (1000_C268 / 0x1C268)
    Stack.Push(SS);
    // POP DS (1000_C269 / 0x1C269)
    DS = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_C26A_01C26A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_C26A_01C26A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C26A_1C26A:
    // RET  (1000_C26A / 0x1C26A)
    return NearRet();
  }
  
  public Action split_1000_C26B_01C26B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C26B_1C26B:
    // XCHG AL,AH (1000_C26B / 0x1C26B)
    byte tmp_1000_C26B = AL;
    AL = AH;
    AH = tmp_1000_C26B;
    // MOV BP,AX (1000_C26D / 0x1C26D)
    BP = AX;
    // SHR BP,0x1 (1000_C26F / 0x1C26F)
    // BP >>= 0x1;
    BP = Alu.Shr16(BP, 0x1);
    // MOV BP,word ptr [BP + 0x2774] (1000_C271 / 0x1C271)
    BP = UInt16[SS, (ushort)(BP + 0x2774)];
    // MOV AX,DI (1000_C275 / 0x1C275)
    AX = DI;
    // AND AX,0x1ff (1000_C277 / 0x1C277)
    // AX &= 0x1FF;
    AX = Alu.And16(AX, 0x1FF);
    // PUSH DX (1000_C27A / 0x1C27A)
    Stack.Push(DX);
    // XCHG AL,AH (1000_C27B / 0x1C27B)
    byte tmp_1000_C27B = AL;
    AL = AH;
    AH = tmp_1000_C27B;
    // XOR DX,DX (1000_C27D / 0x1C27D)
    DX = 0;
    // DIV BP (1000_C27F / 0x1C27F)
    Cpu.Div16(BP);
    // POP DX (1000_C281 / 0x1C281)
    DX = Stack.Pop();
    // PUSH AX (1000_C282 / 0x1C282)
    Stack.Push(AX);
    // MOV AX,CX (1000_C283 / 0x1C283)
    AX = CX;
    // XOR AH,AH (1000_C285 / 0x1C285)
    AH = 0;
    // PUSH DX (1000_C287 / 0x1C287)
    Stack.Push(DX);
    // XCHG AL,AH (1000_C288 / 0x1C288)
    byte tmp_1000_C288 = AL;
    AL = AH;
    AH = tmp_1000_C288;
    // XOR DX,DX (1000_C28A / 0x1C28A)
    DX = 0;
    // DIV BP (1000_C28C / 0x1C28C)
    Cpu.Div16(BP);
    // POP DX (1000_C28E / 0x1C28E)
    DX = Stack.Pop();
    // MOV CL,AL (1000_C28F / 0x1C28F)
    CL = AL;
    // POP AX (1000_C291 / 0x1C291)
    AX = Stack.Pop();
    // OR DI,DI (1000_C292 / 0x1C292)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNS 0x1000:c299 (1000_C294 / 0x1C294)
    if(!SignFlag) {
      goto label_1000_C299_1C299;
    }
    // CALL 0x1000:c2a1 (1000_C296 / 0x1C296)
    NearCall(cs1, 0xC299, spice86_generated_label_call_target_1000_C2A1_01C2A1);
    label_1000_C299_1C299:
    // CALLF [0x3941] (1000_C299 / 0x1C299)
    // Indirect call to [0x3941], generating possible targets from emulator records
    uint targetAddress_1000_C299 = (uint)(UInt16[SS, 0x3943] * 0x10 + UInt16[SS, 0x3941] - cs1 * 0x10);
    switch(targetAddress_1000_C299) {
      case 0x23619 : FarCall(cs1, 0xC29E, spice86_generated_label_call_target_334B_0169_033619); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C299));
        break;
    }
    label_1000_C29E_1C29E:
    // PUSH SS (1000_C29E / 0x1C29E)
    Stack.Push(SS);
    // POP DS (1000_C29F / 0x1C29F)
    DS = Stack.Pop();
    // RET  (1000_C2A0 / 0x1C2A0)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C2A1_01C2A1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C2A1_1C2A1:
    // PUSH AX (1000_C2A1 / 0x1C2A1)
    Stack.Push(AX);
    // PUSH BX (1000_C2A2 / 0x1C2A2)
    Stack.Push(BX);
    // PUSH CX (1000_C2A3 / 0x1C2A3)
    Stack.Push(CX);
    // PUSH DI (1000_C2A4 / 0x1C2A4)
    Stack.Push(DI);
    // PUSH ES (1000_C2A5 / 0x1C2A5)
    Stack.Push(ES);
    // PUSH BP (1000_C2A6 / 0x1C2A6)
    Stack.Push(BP);
    // PUSH SS (1000_C2A7 / 0x1C2A7)
    Stack.Push(SS);
    // POP ES (1000_C2A8 / 0x1C2A8)
    ES = Stack.Pop();
    // MOV BP,DI (1000_C2A9 / 0x1C2A9)
    BP = DI;
    // MOV DI,0x4c60 (1000_C2AB / 0x1C2AB)
    DI = 0x4C60;
    // AND BP,0x1ff (1000_C2AE / 0x1C2AE)
    BP &= 0x1FF;
    
    // ADD BP,0x3 (1000_C2B2 / 0x1C2B2)
    BP += 0x3;
    
    // SHR BP,0x1 (1000_C2B5 / 0x1C2B5)
    BP >>= 0x1;
    
    // SHR BP,0x1 (1000_C2B7 / 0x1C2B7)
    BP >>= 0x1;
    
    // SHL BP,0x1 (1000_C2B9 / 0x1C2B9)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // MOV CX,word ptr [SI + -0x2] (1000_C2BB / 0x1C2BB)
    CX = UInt16[DS, (ushort)(SI - 0x2)];
    // XOR CH,CH (1000_C2BE / 0x1C2BE)
    CH = 0;
    label_1000_C2C0_1C2C0:
    // PUSH CX (1000_C2C0 / 0x1C2C0)
    Stack.Push(CX);
    // MOV BX,BP (1000_C2C1 / 0x1C2C1)
    BX = BP;
    label_1000_C2C3_1C2C3:
    // LODSB SI (1000_C2C3 / 0x1C2C3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST AL,0x80 (1000_C2C4 / 0x1C2C4)
    Alu.And8(AL, 0x80);
    // JNZ 0x1000:c2d6 (1000_C2C6 / 0x1C2C6)
    if(!ZeroFlag) {
      goto label_1000_C2D6_1C2D6;
    }
    // MOV CL,0x1 (1000_C2C8 / 0x1C2C8)
    CL = 0x1;
    // ADD CL,AL (1000_C2CA / 0x1C2CA)
    CL += AL;
    
    // XOR CH,CH (1000_C2CC / 0x1C2CC)
    CH = 0;
    // SUB BX,CX (1000_C2CE / 0x1C2CE)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_C2D0 / 0x1C2D0)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // JNZ 0x1000:c2c3 (1000_C2D2 / 0x1C2D2)
    if(!ZeroFlag) {
      goto label_1000_C2C3_1C2C3;
    }
    // JMP 0x1000:c2e3 (1000_C2D4 / 0x1C2D4)
    goto label_1000_C2E3_1C2E3;
    label_1000_C2D6_1C2D6:
    // MOV CL,0x1 (1000_C2D6 / 0x1C2D6)
    CL = 0x1;
    // SUB CL,AL (1000_C2D8 / 0x1C2D8)
    CL -= AL;
    
    // XOR CH,CH (1000_C2DA / 0x1C2DA)
    CH = 0;
    // SUB BX,CX (1000_C2DC / 0x1C2DC)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // LODSB SI (1000_C2DE / 0x1C2DE)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_C2DF / 0x1C2DF)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // JNZ 0x1000:c2c3 (1000_C2E1 / 0x1C2E1)
    if(!ZeroFlag) {
      goto label_1000_C2C3_1C2C3;
    }
    label_1000_C2E3_1C2E3:
    // POP CX (1000_C2E3 / 0x1C2E3)
    CX = Stack.Pop();
    // LOOP 0x1000:c2c0 (1000_C2E4 / 0x1C2E4)
    if(--CX != 0) {
      goto label_1000_C2C0_1C2C0;
    }
    // MOV SI,0x4c60 (1000_C2E6 / 0x1C2E6)
    SI = 0x4C60;
    // PUSH SS (1000_C2E9 / 0x1C2E9)
    Stack.Push(SS);
    // POP DS (1000_C2EA / 0x1C2EA)
    DS = Stack.Pop();
    // POP BP (1000_C2EB / 0x1C2EB)
    BP = Stack.Pop();
    // POP ES (1000_C2EC / 0x1C2EC)
    ES = Stack.Pop();
    // POP DI (1000_C2ED / 0x1C2ED)
    DI = Stack.Pop();
    // POP CX (1000_C2EE / 0x1C2EE)
    CX = Stack.Pop();
    // POP BX (1000_C2EF / 0x1C2EF)
    BX = Stack.Pop();
    // POP AX (1000_C2F0 / 0x1C2F0)
    AX = Stack.Pop();
    // RET  (1000_C2F1 / 0x1C2F1)
    return NearRet();
  }
  
  public Action split_1000_C2F2_01C2F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C2F2_1C2F2:
    // XOR AH,AH (1000_C2F2 / 0x1C2F2)
    AH = 0;
    // CALL 0x1000:c13e (1000_C2F4 / 0x1C2F4)
    NearCall(cs1, 0xC2F7, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_C2F7_1C2F7:
    // XOR AX,AX (1000_C2F7 / 0x1C2F7)
    AX = 0;
    // XOR BX,BX (1000_C2F9 / 0x1C2F9)
    BX = 0;
    // XOR DX,DX (1000_C2FB / 0x1C2FB)
    DX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2FD_01C2FD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C2FD_01C2FD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C2FD_1C2FD:
    // PUSH BX (1000_C2FD / 0x1C2FD)
    Stack.Push(BX);
    // PUSH DX (1000_C2FE / 0x1C2FE)
    Stack.Push(DX);
    // CALL 0x1000:c22f (1000_C2FF / 0x1C2FF)
    NearCall(cs1, 0xC302, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_C302_1C302:
    // POP DX (1000_C302 / 0x1C302)
    DX = Stack.Pop();
    // POP BX (1000_C303 / 0x1C303)
    BX = Stack.Pop();
    // RET  (1000_C304 / 0x1C304)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C305_01C305(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C305_1C305:
    // PUSH BX (1000_C305 / 0x1C305)
    Stack.Push(BX);
    // PUSH DX (1000_C306 / 0x1C306)
    Stack.Push(DX);
    // CALL 0x1000:c30d (1000_C307 / 0x1C307)
    NearCall(cs1, 0xC30A, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_C30A_1C30A:
    // POP DX (1000_C30A / 0x1C30A)
    DX = Stack.Pop();
    // POP BX (1000_C30B / 0x1C30B)
    BX = Stack.Pop();
    // RET  (1000_C30C / 0x1C30C)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C30D_01C30D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C30D_1C30D:
    // MOV ES,word ptr [0xdbda] (1000_C30D / 0x1C30D)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_C311 / 0x1C311)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C315 / 0x1C315)
    BP = AX;
    // SHL BP,0x1 (1000_C317 / 0x1C317)
    BP <<= 0x1;
    
    // ADD SI,word ptr DS:[BP + SI] (1000_C319 / 0x1C319)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_C31C / 0x1C31C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C31D / 0x1C31D)
    DI = AX;
    // LODSW SI (1000_C31F / 0x1C31F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_C320 / 0x1C320)
    AH = 0;
    // MOV CX,AX (1000_C322 / 0x1C322)
    CX = AX;
    // MOV BP,0xd834 (1000_C324 / 0x1C324)
    BP = 0xD834;
    // CALLF [0x38cd] (1000_C327 / 0x1C327)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_C327 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_C327) {
      case 0x235C2 : throw FailAsUntested("Could not find a valid function at address 334B_0112 / 0x335C2");
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C327));
        break;
    }
    label_1000_C32C_1C32C:
    // PUSH SS (1000_C32C / 0x1C32C)
    Stack.Push(SS);
    // POP DS (1000_C32D / 0x1C32D)
    DS = Stack.Pop();
    // RET  (1000_C32E / 0x1C32E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C343_01C343(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C343_1C343:
    // MOV ES,word ptr [0xdbda] (1000_C343 / 0x1C343)
    ES = UInt16[DS, 0xDBDA];
    // LDS SI,[0xdbb0] (1000_C347 / 0x1C347)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BP,AX (1000_C34B / 0x1C34B)
    BP = AX;
    // SHL BP,0x1 (1000_C34D / 0x1C34D)
    BP <<= 0x1;
    
    // ADD SI,word ptr DS:[BP + SI] (1000_C34F / 0x1C34F)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_C352 / 0x1C352)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C353 / 0x1C353)
    DI = AX;
    // AND AH,0xf (1000_C355 / 0x1C355)
    AH &= 0xF;
    
    // SHR AX,0x1 (1000_C358 / 0x1C358)
    AX >>= 0x1;
    
    // SUB DX,AX (1000_C35A / 0x1C35A)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // LODSW SI (1000_C35C / 0x1C35C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_C35D / 0x1C35D)
    AH = 0;
    // MOV CX,AX (1000_C35F / 0x1C35F)
    CX = AX;
    // SHR AX,0x1 (1000_C361 / 0x1C361)
    AX >>= 0x1;
    
    // SUB BX,AX (1000_C363 / 0x1C363)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // MOV BP,0xd834 (1000_C365 / 0x1C365)
    BP = 0xD834;
    // CALLF [0x38cd] (1000_C368 / 0x1C368)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_C368 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_C368) {
      case 0x235C2 : throw FailAsUntested("Could not find a valid function at address 334B_0112 / 0x335C2");
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C368));
        break;
    }
    label_1000_C36D_1C36D:
    // PUSH SS (1000_C36D / 0x1C36D)
    Stack.Push(SS);
    // POP DS (1000_C36E / 0x1C36E)
    DS = Stack.Pop();
    // RET  (1000_C36F / 0x1C36F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C412_01C412(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C412_1C412:
    // PUSH DS (1000_C412 / 0x1C412)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbde] (1000_C413 / 0x1C413)
    ES = UInt16[DS, 0xDBDE];
    // MOV DS,word ptr [0xdbda] (1000_C417 / 0x1C417)
    DS = UInt16[DS, 0xDBDA];
    // CALLF [0x38e1] (1000_C41B / 0x1C41B)
    // Indirect call to [0x38e1], generating possible targets from emulator records
    uint targetAddress_1000_C41B = (uint)(UInt16[SS, 0x38E3] * 0x10 + UInt16[SS, 0x38E1] - cs1 * 0x10);
    switch(targetAddress_1000_C41B) {
      case 0x235D1 : FarCall(cs1, 0xC420, spice86_generated_label_call_target_334B_0121_0335D1); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C41B));
        break;
    }
    label_1000_C420_1C420:
    // POP DS (1000_C420 / 0x1C420)
    DS = Stack.Pop();
    // RET  (1000_C421 / 0x1C421)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C432_01C432(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C432_1C432:
    // MOV SI,0x1470 (1000_C432 / 0x1C432)
    SI = 0x1470;
    // MOV ES,word ptr [0xdbda] (1000_C435 / 0x1C435)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38d9] (1000_C439 / 0x1C439)
    // Indirect call to [0x38d9], generating possible targets from emulator records
    uint targetAddress_1000_C439 = (uint)(UInt16[DS, 0x38DB] * 0x10 + UInt16[DS, 0x38D9] - cs1 * 0x10);
    switch(targetAddress_1000_C439) {
      case 0x235CB : FarCall(cs1, 0xC43D, spice86_generated_label_call_target_334B_011B_0335CB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C439));
        break;
    }
    label_1000_C43D_1C43D:
    // RET  (1000_C43D / 0x1C43D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C43E_01C43E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C43E_1C43E:
    // MOV SI,0x1470 (1000_C43E / 0x1C43E)
    SI = 0x1470;
    // JMP 0x1000:c446 (1000_C441 / 0x1C441)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C446_01C446, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C443_01C443(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C443_1C443:
    // MOV SI,0xd834 (1000_C443 / 0x1C443)
    SI = 0xD834;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C446_01C446, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C446_01C446(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC449: goto label_1000_C449_1C449;break; // Target of external jump from 0x1C472
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C446_1C446:
    // MOV AX,[0xdbde] (1000_C446 / 0x1C446)
    AX = UInt16[DS, 0xDBDE];
    label_1000_C449_1C449:
    // PUSH CX (1000_C449 / 0x1C449)
    Stack.Push(CX);
    // MOV CX,AX (1000_C44A / 0x1C44A)
    CX = AX;
    // MOV DX,word ptr [SI] (1000_C44C / 0x1C44C)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C44E / 0x1C44E)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C451 / 0x1C451)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C454 / 0x1C454)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB BP,DX (1000_C457 / 0x1C457)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c46d (1000_C459 / 0x1C459)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C46D_1C46D;
    }
    // SUB AX,BX (1000_C45B / 0x1C45B)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c46d (1000_C45D / 0x1C45D)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C46D_1C46D;
    }
    // MOV ES,word ptr [0xdbd6] (1000_C45F / 0x1C45F)
    ES = UInt16[DS, 0xDBD6];
    // PUSH SI (1000_C463 / 0x1C463)
    Stack.Push(SI);
    // PUSH DS (1000_C464 / 0x1C464)
    Stack.Push(DS);
    // MOV SI,CX (1000_C465 / 0x1C465)
    SI = CX;
    // CALLF [0x38ed] (1000_C467 / 0x1C467)
    // Indirect call to [0x38ed], generating possible targets from emulator records
    uint targetAddress_1000_C467 = (uint)(UInt16[DS, 0x38EF] * 0x10 + UInt16[DS, 0x38ED] - cs1 * 0x10);
    switch(targetAddress_1000_C467) {
      case 0x235DA : FarCall(cs1, 0xC46B, spice86_generated_label_call_target_334B_012A_0335DA); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C467));
        break;
    }
    label_1000_C46B_1C46B:
    // POP DS (1000_C46B / 0x1C46B)
    DS = Stack.Pop();
    // POP SI (1000_C46C / 0x1C46C)
    SI = Stack.Pop();
    label_1000_C46D_1C46D:
    // POP CX (1000_C46D / 0x1C46D)
    CX = Stack.Pop();
    // RET  (1000_C46E / 0x1C46E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C46F_01C46F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C46F_1C46F:
    // MOV AX,[0xdc32] (1000_C46F / 0x1C46F)
    AX = UInt16[DS, 0xDC32];
    // JMP 0x1000:c449 (1000_C472 / 0x1C472)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C446_01C446, 0x1C449 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C474_01C474(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C474_1C474:
    // MOV SI,0x1470 (1000_C474 / 0x1C474)
    SI = 0x1470;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C477_01C477, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C477_01C477(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C477_1C477:
    // MOV DX,word ptr [SI] (1000_C477 / 0x1C477)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C479 / 0x1C479)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C47C / 0x1C47C)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C47F / 0x1C47F)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB BP,DX (1000_C482 / 0x1C482)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c499 (1000_C484 / 0x1C484)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C499 / 0x1C499)
      return NearRet();
    }
    // SUB AX,BX (1000_C486 / 0x1C486)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c499 (1000_C488 / 0x1C488)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C499 / 0x1C499)
      return NearRet();
    }
    // MOV ES,word ptr [0xdbde] (1000_C48A / 0x1C48A)
    ES = UInt16[DS, 0xDBDE];
    // PUSH DS (1000_C48E / 0x1C48E)
    Stack.Push(DS);
    // MOV DS,word ptr [0xdbd6] (1000_C48F / 0x1C48F)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x38e5] (1000_C493 / 0x1C493)
    // Indirect call to [0x38e5], generating possible targets from emulator records
    uint targetAddress_1000_C493 = (uint)(UInt16[SS, 0x38E7] * 0x10 + UInt16[SS, 0x38E5] - cs1 * 0x10);
    switch(targetAddress_1000_C493) {
      case 0x235D4 : FarCall(cs1, 0xC498, spice86_generated_label_call_target_334B_0124_0335D4); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C493));
        break;
    }
    label_1000_C498_1C498:
    // POP DS (1000_C498 / 0x1C498)
    DS = Stack.Pop();
    label_1000_C499_1C499:
    // RET  (1000_C499 / 0x1C499)
    return NearRet();
  }
  
  public Action gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C49A_1C49A:
    // PUSH DS (1000_C49A / 0x1C49A)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd6] (1000_C49B / 0x1C49B)
    ES = UInt16[DS, 0xDBD6];
    // MOV DS,word ptr [0xdbd8] (1000_C49F / 0x1C49F)
    DS = UInt16[DS, 0xDBD8];
    // CALLF [0x38f1] (1000_C4A3 / 0x1C4A3)
    // Indirect call to [0x38f1], generating possible targets from emulator records
    uint targetAddress_1000_C4A3 = (uint)(UInt16[SS, 0x38F3] * 0x10 + UInt16[SS, 0x38F1] - cs1 * 0x10);
    switch(targetAddress_1000_C4A3) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C4A3));
        break;
    }
    // POP DS (1000_C4A8 / 0x1C4A8)
    DS = Stack.Pop();
    // RET  (1000_C4A9 / 0x1C4A9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C4AA_01C4AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C4AA_1C4AA:
    // MOV DX,word ptr [SI] (1000_C4AA / 0x1C4AA)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C4AC / 0x1C4AC)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C4AF / 0x1C4AF)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C4B2 / 0x1C4B2)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // SUB BP,DX (1000_C4B5 / 0x1C4B5)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c4cc (1000_C4B7 / 0x1C4B7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C4CC / 0x1C4CC)
      return NearRet();
    }
    // SUB AX,BX (1000_C4B9 / 0x1C4B9)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c4cc (1000_C4BB / 0x1C4BB)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C4CC / 0x1C4CC)
      return NearRet();
    }
    // PUSH DS (1000_C4BD / 0x1C4BD)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd6] (1000_C4BE / 0x1C4BE)
    ES = UInt16[DS, 0xDBD6];
    // MOV DS,word ptr [0xdbd8] (1000_C4C2 / 0x1C4C2)
    DS = UInt16[DS, 0xDBD8];
    // CALLF [0x38f5] (1000_C4C6 / 0x1C4C6)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C4C6 = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C4C6) {
      case 0x235E0 : FarCall(cs1, 0xC4CB, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C4C6));
        break;
    }
    label_1000_C4CB_1C4CB:
    // POP DS (1000_C4CB / 0x1C4CB)
    DS = Stack.Pop();
    label_1000_C4CC_1C4CC:
    // RET  (1000_C4CC / 0x1C4CC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C4CD_01C4CD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C4CD_1C4CD:
    // PUSH DS (1000_C4CD / 0x1C4CD)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C4CE / 0x1C4CE)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C4D2 / 0x1C4D2)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x38f1] (1000_C4D6 / 0x1C4D6)
    // Indirect call to [0x38f1], generating possible targets from emulator records
    uint targetAddress_1000_C4D6 = (uint)(UInt16[SS, 0x38F3] * 0x10 + UInt16[SS, 0x38F1] - cs1 * 0x10);
    switch(targetAddress_1000_C4D6) {
      case 0x235DD : FarCall(cs1, 0xC4DB, spice86_generated_label_call_target_334B_012D_0335DD); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C4D6));
        break;
    }
    label_1000_C4DB_1C4DB:
    // POP DS (1000_C4DB / 0x1C4DB)
    DS = Stack.Pop();
    // RET  (1000_C4DC / 0x1C4DC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C4DD_01C4DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C4DD_1C4DD:
    // MOV AX,[0xdc38] (1000_C4DD / 0x1C4DD)
    AX = UInt16[DS, 0xDC38];
    // CMP AX,0x98 (1000_C4E0 / 0x1C4E0)
    Alu.Sub16(AX, 0x98);
    // JNC 0x1000:c4e8 (1000_C4E3 / 0x1C4E3)
    if(!CarryFlag) {
      goto label_1000_C4E8_1C4E8;
    }
    // CALL 0x1000:dbb2 (1000_C4E5 / 0x1C4E5)
    NearCall(cs1, 0xC4E8, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_C4E8_1C4E8:
    // MOV SI,0x1470 (1000_C4E8 / 0x1C4E8)
    SI = 0x1470;
    // JMP 0x1000:c4f0 (1000_C4EB / 0x1C4EB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C4ED_01C4ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
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
  
  public Action spice86_generated_label_call_target_1000_C4F0_01C4F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C4F0_1C4F0:
    // MOV DX,word ptr [SI] (1000_C4F0 / 0x1C4F0)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C4F2 / 0x1C4F2)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C4F5 / 0x1C4F5)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C4F8 / 0x1C4F8)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4FB_01C4FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C4FB_01C4FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C4FB_1C4FB:
    // CMP byte ptr [0x227d],0x0 (1000_C4FB / 0x1C4FB)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:c51e (1000_C500 / 0x1C500)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AX,0x89 (1000_C502 / 0x1C502)
    Alu.Sub16(AX, 0x89);
    // JL 0x1000:c51e (1000_C505 / 0x1C505)
    if(SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP BP,0x7e (1000_C507 / 0x1C507)
    Alu.Sub16(BP, 0x7E);
    // JL 0x1000:c51e (1000_C50B / 0x1C50B)
    if(SignFlag != OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP DX,0xc2 (1000_C50D / 0x1C50D)
    Alu.Sub16(DX, 0xC2);
    // JGE 0x1000:c51e (1000_C511 / 0x1C511)
    if(SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_C513 / 0x1C513)
    Stack.Push(AX);
    // PUSH BX (1000_C514 / 0x1C514)
    Stack.Push(BX);
    // PUSH DX (1000_C515 / 0x1C515)
    Stack.Push(DX);
    // PUSH BP (1000_C516 / 0x1C516)
    Stack.Push(BP);
    // CALL 0x1000:1797 (1000_C517 / 0x1C517)
    NearCall(cs1, 0xC51A, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_C51A_1C51A:
    // POP BP (1000_C51A / 0x1C51A)
    BP = Stack.Pop();
    // POP DX (1000_C51B / 0x1C51B)
    DX = Stack.Pop();
    // POP BX (1000_C51C / 0x1C51C)
    BX = Stack.Pop();
    // POP AX (1000_C51D / 0x1C51D)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_C51E_01C51E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C51E_1C51E:
    // SUB BP,DX (1000_C51E / 0x1C51E)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c53d (1000_C520 / 0x1C520)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    // SUB AX,BX (1000_C522 / 0x1C522)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c53d (1000_C524 / 0x1C524)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    label_1000_C526_1C526:
    // CMP word ptr [0x2570],0x1ad6 (1000_C526 / 0x1C526)
    Alu.Sub16(UInt16[DS, 0x2570], 0x1AD6);
    // JZ 0x1000:c53d (1000_C52C / 0x1C52C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C53D / 0x1C53D)
      return NearRet();
    }
    // PUSH DS (1000_C52E / 0x1C52E)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C52F / 0x1C52F)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C533 / 0x1C533)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x38f5] (1000_C537 / 0x1C537)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C537 = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C537) {
      case 0x235E0 : FarCall(cs1, 0xC53C, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C537));
        break;
    }
    label_1000_C53C_1C53C:
    // POP DS (1000_C53C / 0x1C53C)
    DS = Stack.Pop();
    label_1000_C53D_1C53D:
    // RET  (1000_C53D / 0x1C53D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C53E_01C53E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C53E_1C53E:
    // MOV SI,0x276a (1000_C53E / 0x1C53E)
    SI = 0x276A;
    // MOV BP,word ptr [0x2772] (1000_C541 / 0x1C541)
    BP = UInt16[DS, 0x2772];
    // MOV AL,[0xdbe4] (1000_C545 / 0x1C545)
    AL = UInt8[DS, 0xDBE4];
    // MOV ES,word ptr [0xdbda] (1000_C548 / 0x1C548)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x3901] (1000_C54C / 0x1C54C)
    // Indirect call to [0x3901], generating possible targets from emulator records
    uint targetAddress_1000_C54C = (uint)(UInt16[DS, 0x3903] * 0x10 + UInt16[DS, 0x3901] - cs1 * 0x10);
    switch(targetAddress_1000_C54C) {
      case 0x235E9 : FarCall(cs1, 0xC550, spice86_generated_label_call_target_334B_0139_0335E9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C54C));
        break;
    }
    label_1000_C550_1C550:
    // RET  (1000_C550 / 0x1C550)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C551_01C551(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C551_1C551:
    // LODSW SI (1000_C551 / 0x1C551)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_C552 / 0x1C552)
    DX = AX;
    // LODSW SI (1000_C554 / 0x1C554)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_C555 / 0x1C555)
    BX = AX;
    // LODSW SI (1000_C557 / 0x1C557)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_C558 / 0x1C558)
    DI = AX;
    // DEC DI (1000_C55A / 0x1C55A)
    DI = Alu.Dec16(DI);
    // LODSW SI (1000_C55B / 0x1C55B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_C55C / 0x1C55C)
    CX = AX;
    // DEC CX (1000_C55E / 0x1C55E)
    CX = Alu.Dec16(CX);
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
  
  public Action spice86_generated_label_call_target_1000_C560_01C560(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C560_1C560:
    // MOV [0xdbe4],AL (1000_C560 / 0x1C560)
    UInt8[DS, 0xDBE4] = AL;
    // PUSH BX (1000_C563 / 0x1C563)
    Stack.Push(BX);
    // PUSH CX (1000_C564 / 0x1C564)
    Stack.Push(CX);
    // PUSH DX (1000_C565 / 0x1C565)
    Stack.Push(DX);
    // PUSH DI (1000_C566 / 0x1C566)
    Stack.Push(DI);
    // MOV CX,BX (1000_C567 / 0x1C567)
    CX = BX;
    // CALL 0x1000:c53e (1000_C569 / 0x1C569)
    NearCall(cs1, 0xC56C, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C56C_1C56C:
    // MOV BP,SP (1000_C56C / 0x1C56C)
    BP = SP;
    // MOV CX,word ptr [BP + 0x4] (1000_C56E / 0x1C56E)
    CX = UInt16[SS, (ushort)(BP + 0x4)];
    // MOV BX,CX (1000_C571 / 0x1C571)
    BX = CX;
    // CALL 0x1000:c53e (1000_C573 / 0x1C573)
    NearCall(cs1, 0xC576, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C576_1C576:
    // MOV BP,SP (1000_C576 / 0x1C576)
    BP = SP;
    // MOV DI,DX (1000_C578 / 0x1C578)
    DI = DX;
    // MOV BX,word ptr [BP + 0x6] (1000_C57A / 0x1C57A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    // CALL 0x1000:c53e (1000_C57D / 0x1C57D)
    NearCall(cs1, 0xC580, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C580_1C580:
    // POP DI (1000_C580 / 0x1C580)
    DI = Stack.Pop();
    // MOV DX,DI (1000_C581 / 0x1C581)
    DX = DI;
    // CALL 0x1000:c53e (1000_C583 / 0x1C583)
    NearCall(cs1, 0xC586, spice86_generated_label_call_target_1000_C53E_01C53E);
    label_1000_C586_1C586:
    // POP DX (1000_C586 / 0x1C586)
    DX = Stack.Pop();
    // POP CX (1000_C587 / 0x1C587)
    CX = Stack.Pop();
    // POP BX (1000_C588 / 0x1C588)
    BX = Stack.Pop();
    // RET  (1000_C589 / 0x1C589)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C6AD_01C6AD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC6AC: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_C6AC_1C6AC:
    // RET  (1000_C6AC / 0x1C6AC)
    return NearRet();
    entry:
    label_1000_C6AD_1C6AD:
    // CALL 0x1000:c13b (1000_C6AD / 0x1C6AD)
    NearCall(cs1, 0xC6B0, spice86_generated_label_call_target_1000_C13B_01C13B);
    label_1000_C6B0_1C6B0:
    // CMP byte ptr [0xdc46],0x0 (1000_C6B0 / 0x1C6B0)
    Alu.Sub8(UInt8[DS, 0xDC46], 0x0);
    // JS 0x1000:c6e4 (1000_C6B5 / 0x1C6B5)
    if(SignFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // MOV AX,[0xdc44] (1000_C6B7 / 0x1C6B7)
    AX = UInt16[DS, 0xDC44];
    // CMP AX,word ptr [SI + 0x6] (1000_C6BA / 0x1C6BA)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JGE 0x1000:c6e4 (1000_C6BD / 0x1C6BD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // ADD AX,0x10 (1000_C6BF / 0x1C6BF)
    AX += 0x10;
    
    // CMP AX,word ptr [SI + 0x2] (1000_C6C2 / 0x1C6C2)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JLE 0x1000:c6e4 (1000_C6C5 / 0x1C6C5)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // MOV AX,[0xdc42] (1000_C6C7 / 0x1C6C7)
    AX = UInt16[DS, 0xDC42];
    // CMP AX,word ptr [SI + 0x4] (1000_C6CA / 0x1C6CA)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JGE 0x1000:c6e4 (1000_C6CD / 0x1C6CD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // ADD AX,0x10 (1000_C6CF / 0x1C6CF)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    // MOV BX,word ptr [SI] (1000_C6D2 / 0x1C6D2)
    BX = UInt16[DS, SI];
    // AND BH,0xf (1000_C6D4 / 0x1C6D4)
    BH &= 0xF;
    
    // CMP AX,BX (1000_C6D7 / 0x1C6D7)
    Alu.Sub16(AX, BX);
    // JLE 0x1000:c6e4 (1000_C6D9 / 0x1C6D9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // MOV AX,0xdbec (1000_C6DB / 0x1C6DB)
    AX = 0xDBEC;
    // PUSH AX (1000_C6DE / 0x1C6DE)
    Stack.Push(AX);
    // PUSH SI (1000_C6DF / 0x1C6DF)
    Stack.Push(SI);
    // CALL 0x1000:dbb2 (1000_C6E0 / 0x1C6E0)
    NearCall(cs1, 0xC6E3, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // POP SI (1000_C6E3 / 0x1C6E3)
    SI = Stack.Pop();
    label_1000_C6E4_1C6E4:
    // MOV AX,DS (1000_C6E4 / 0x1C6E4)
    AX = DS;
    // MOV ES,AX (1000_C6E6 / 0x1C6E6)
    ES = AX;
    // MOV DI,0xd834 (1000_C6E8 / 0x1C6E8)
    DI = 0xD834;
    // MOV BX,0x8 (1000_C6EB / 0x1C6EB)
    BX = 0x8;
    // LODSW SI (1000_C6EE / 0x1C6EE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C6EF / 0x1C6EF)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JGE 0x1000:c6f5 (1000_C6F1 / 0x1C6F1)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6F5_1C6F5;
    }
    // MOV AX,word ptr [BX + DI] (1000_C6F3 / 0x1C6F3)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C6F5_1C6F5:
    // STOSW ES:DI (1000_C6F5 / 0x1C6F5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_C6F6 / 0x1C6F6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C6F7 / 0x1C6F7)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JGE 0x1000:c6fd (1000_C6F9 / 0x1C6F9)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6FD_1C6FD;
    }
    // MOV AX,word ptr [BX + DI] (1000_C6FB / 0x1C6FB)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C6FD_1C6FD:
    // STOSW ES:DI (1000_C6FD / 0x1C6FD)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_C6FE / 0x1C6FE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C6FF / 0x1C6FF)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JLE 0x1000:c705 (1000_C701 / 0x1C701)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C705_1C705;
    }
    // MOV AX,word ptr [BX + DI] (1000_C703 / 0x1C703)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C705_1C705:
    // CMP AX,word ptr [DI + -0x4] (1000_C705 / 0x1C705)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI - 0x4)]);
    // JLE 0x1000:c6ac (1000_C708 / 0x1C708)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_C6AC / 0x1C6AC)
      return NearRet();
    }
    // STOSW ES:DI (1000_C70A / 0x1C70A)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_C70B / 0x1C70B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C70C / 0x1C70C)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JLE 0x1000:c712 (1000_C70E / 0x1C70E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C712_1C712;
    }
    // MOV AX,word ptr [BX + DI] (1000_C710 / 0x1C710)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C712_1C712:
    // CMP AX,word ptr [DI + -0x4] (1000_C712 / 0x1C712)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI - 0x4)]);
    // JLE 0x1000:c6ac (1000_C715 / 0x1C715)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_C6AC / 0x1C6AC)
      return NearRet();
    }
    // STOSW ES:DI (1000_C717 / 0x1C717)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CALL 0x1000:c443 (1000_C718 / 0x1C718)
    NearCall(cs1, 0xC71B, spice86_generated_label_call_target_1000_C443_01C443);
    label_1000_C71B_1C71B:
    // SUB SP,0x200 (1000_C71B / 0x1C71B)
    // SP -= 0x200;
    SP = Alu.Sub16(SP, 0x200);
    // MOV DI,SP (1000_C71F / 0x1C71F)
    DI = SP;
    // MOV CX,word ptr [0x3cbe] (1000_C721 / 0x1C721)
    CX = UInt16[DS, 0x3CBE];
    // JCXZ 0x1000:c780 (1000_C725 / 0x1C725)
    if(CX == 0) {
      goto label_1000_C780_1C780;
    }
    // MOV SI,0xd834 (1000_C727 / 0x1C727)
    SI = 0xD834;
    // LODSW SI (1000_C72A / 0x1C72A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_C72B / 0x1C72B)
    DX = AX;
    // LODSW SI (1000_C72D / 0x1C72D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_C72E / 0x1C72E)
    BX = AX;
    // LODSW SI (1000_C730 / 0x1C730)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BP,AX (1000_C731 / 0x1C731)
    BP = AX;
    // MOV AX,word ptr [SI] (1000_C733 / 0x1C733)
    AX = UInt16[DS, SI];
    // MOV SI,0x3cc0 (1000_C735 / 0x1C735)
    SI = 0x3CC0;
    label_1000_C738_1C738:
    // CMP byte ptr [SI + 0xc],0x0 (1000_C738 / 0x1C738)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0xC)], 0x0);
    // JS 0x1000:c756 (1000_C73C / 0x1C73C)
    if(SignFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI],BP (1000_C73E / 0x1C73E)
    Alu.Sub16(UInt16[DS, SI], BP);
    // JGE 0x1000:c756 (1000_C740 / 0x1C740)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI + 0x2],AX (1000_C742 / 0x1C742)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], AX);
    // JGE 0x1000:c756 (1000_C745 / 0x1C745)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI + 0x4],DX (1000_C747 / 0x1C747)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], DX);
    // JLE 0x1000:c756 (1000_C74A / 0x1C74A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI + 0x6],BX (1000_C74C / 0x1C74C)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x6)], BX);
    // JLE 0x1000:c756 (1000_C74F / 0x1C74F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // MOV word ptr [DI],SI (1000_C751 / 0x1C751)
    UInt16[DS, DI] = SI;
    // ADD DI,0x2 (1000_C753 / 0x1C753)
    DI += 0x2;
    
    label_1000_C756_1C756:
    // ADD SI,0x11 (1000_C756 / 0x1C756)
    // SI += 0x11;
    SI = Alu.Add16(SI, 0x11);
    // LOOP 0x1000:c738 (1000_C759 / 0x1C759)
    if(--CX != 0) {
      goto label_1000_C738_1C738;
    }
    // MOV CX,DI (1000_C75B / 0x1C75B)
    CX = DI;
    // SUB CX,SP (1000_C75D / 0x1C75D)
    CX -= SP;
    
    // SHR CX,0x1 (1000_C75F / 0x1C75F)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // JZ 0x1000:c780 (1000_C761 / 0x1C761)
    if(ZeroFlag) {
      goto label_1000_C780_1C780;
    }
    label_1000_C763_1C763:
    // MOV SI,SP (1000_C763 / 0x1C763)
    SI = SP;
    // PUSH CX (1000_C765 / 0x1C765)
    Stack.Push(CX);
    // CALL word ptr [0x2786] (1000_C766 / 0x1C766)
    // Indirect call to word ptr [0x2786], generating possible targets from emulator records
    uint targetAddress_1000_C766 = (uint)(UInt16[DS, 0x2786]);
    switch(targetAddress_1000_C766) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C766));
        break;
    }
    // JS 0x1000:c77f (1000_C76A / 0x1C76A)
    if(SignFlag) {
      goto label_1000_C77F_1C77F;
    }
    // XOR SI,SI (1000_C76C / 0x1C76C)
    SI = 0;
    // XCHG word ptr [BX + -0x2],SI (1000_C76E / 0x1C76E)
    ushort tmp_1000_C76E = UInt16[DS, (ushort)(BX - 0x2)];
    UInt16[DS, (ushort)(BX - 0x2)] = SI;
    SI = tmp_1000_C76E;
    // MOV AX,word ptr [SI + 0x8] (1000_C771 / 0x1C771)
    AX = UInt16[DS, (ushort)(SI + 0x8)];
    // MOV DX,word ptr [SI] (1000_C774 / 0x1C774)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C776 / 0x1C776)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL 0x1000:c30d (1000_C779 / 0x1C779)
    NearCall(cs1, 0xC77C, spice86_generated_label_call_target_1000_C30D_01C30D);
    // POP CX (1000_C77C / 0x1C77C)
    CX = Stack.Pop();
    // JMP 0x1000:c763 (1000_C77D / 0x1C77D)
    goto label_1000_C763_1C763;
    label_1000_C77F_1C77F:
    // POP CX (1000_C77F / 0x1C77F)
    CX = Stack.Pop();
    label_1000_C780_1C780:
    // CMP byte ptr [0x227d],0x0 (1000_C780 / 0x1C780)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:c7a2 (1000_C785 / 0x1C785)
    if(!ZeroFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CMP word ptr [0xd83a],0x89 (1000_C787 / 0x1C787)
    Alu.Sub16(UInt16[DS, 0xD83A], 0x89);
    // JL 0x1000:c7a2 (1000_C78D / 0x1C78D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CMP word ptr [0xd838],0x7e (1000_C78F / 0x1C78F)
    Alu.Sub16(UInt16[DS, 0xD838], 0x7E);
    // JL 0x1000:c7a2 (1000_C795 / 0x1C795)
    if(SignFlag != OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CMP word ptr [0xd834],0xc2 (1000_C797 / 0x1C797)
    Alu.Sub16(UInt16[DS, 0xD834], 0xC2);
    // JGE 0x1000:c7a2 (1000_C79D / 0x1C79D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CALL 0x1000:1797 (1000_C79F / 0x1C79F)
    NearCall(cs1, 0xC7A2, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_C7A2_1C7A2:
    // MOV SI,word ptr [0xdbe0] (1000_C7A2 / 0x1C7A2)
    SI = UInt16[DS, 0xDBE0];
    // OR SI,SI (1000_C7A6 / 0x1C7A6)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:c7be (1000_C7A8 / 0x1C7A8)
    if(ZeroFlag) {
      goto label_1000_C7BE_1C7BE;
    }
    // MOV DI,0xd834 (1000_C7AA / 0x1C7AA)
    DI = 0xD834;
    // CALL 0x1000:c7d4 (1000_C7AD / 0x1C7AD)
    throw FailAsUntested("Could not find a valid function at address 1000_C7D4 / 0x1C7D4");
    // MOV SI,word ptr [0xdbe2] (1000_C7B0 / 0x1C7B0)
    SI = UInt16[DS, 0xDBE2];
    // OR SI,SI (1000_C7B4 / 0x1C7B4)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:c7be (1000_C7B6 / 0x1C7B6)
    if(ZeroFlag) {
      goto label_1000_C7BE_1C7BE;
    }
    // MOV DI,0xd834 (1000_C7B8 / 0x1C7B8)
    DI = 0xD834;
    // CALL 0x1000:c7d4 (1000_C7BB / 0x1C7BB)
    throw FailAsUntested("Could not find a valid function at address 1000_C7D4 / 0x1C7D4");
    label_1000_C7BE_1C7BE:
    // MOV SI,0xd834 (1000_C7BE / 0x1C7BE)
    SI = 0xD834;
    // MOV DX,word ptr [SI] (1000_C7C1 / 0x1C7C1)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C7C3 / 0x1C7C3)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C7C6 / 0x1C7C6)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C7C9 / 0x1C7C9)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // CALL 0x1000:c51e (1000_C7CC / 0x1C7CC)
    NearCall(cs1, 0xC7CF, spice86_generated_label_call_target_1000_C51E_01C51E);
    label_1000_C7CF_1C7CF:
    // ADD SP,0x200 (1000_C7CF / 0x1C7CF)
    // SP += 0x200;
    SP = Alu.Add16(SP, 0x200);
    // RET  (1000_C7D3 / 0x1C7D3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C85B_01C85B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C85B_1C85B:
    // MOV AX,[0xce7a] (1000_C85B / 0x1C85B)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0x476e],AX (1000_C85E / 0x1C85E)
    UInt16[DS, 0x476E] = AX;
    // MOV word ptr [0x4772],0x1770 (1000_C861 / 0x1C861)
    UInt16[DS, 0x4772] = 0x1770;
    // RET  (1000_C867 / 0x1C867)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_C921_01C921(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C921_1C921:
    // MOV BX,0x33a3 (1000_C921 / 0x1C921)
    BX = 0x33A3;
    // ADD BX,AX (1000_C924 / 0x1C924)
    BX += AX;
    
    // ADD BX,AX (1000_C926 / 0x1C926)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // MOV BX,word ptr [BX] (1000_C928 / 0x1C928)
    BX = UInt16[DS, BX];
    // RET  (1000_C92A / 0x1C92A)
    return NearRet();
  }
  
}
