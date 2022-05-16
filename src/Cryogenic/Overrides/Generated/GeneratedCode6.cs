namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_A44C_01A44C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A44C_1A44C:
    // MOV AL,[0x28e7] (1000_A44C / 0x1A44C)
    AL = UInt8[DS, 0x28E7];
    // ADD AL,0x8 (1000_A44F / 0x1A44F)
    // AL += 0x8;
    AL = Alu.Add8(AL, 0x8);
    // JMP 0x1000:a435 (1000_A451 / 0x1A451)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A42C_01A42C, 0x1A435 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A453_01A453(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A453_1A453:
    // SUB DX,word ptr [0x2886] (1000_A453 / 0x1A453)
    DX -= UInt16[DS, 0x2886];
    
    // SUB BX,word ptr [0x2888] (1000_A457 / 0x1A457)
    // BX -= UInt16[DS, 0x2888];
    BX = Alu.Sub16(BX, UInt16[DS, 0x2888]);
    // RET  (1000_A45B / 0x1A45B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A45C_01A45C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A45C_1A45C:
    // ADD DX,word ptr [0x2886] (1000_A45C / 0x1A45C)
    DX += UInt16[DS, 0x2886];
    
    // ADD BX,word ptr [0x2888] (1000_A460 / 0x1A460)
    // BX += UInt16[DS, 0x2888];
    BX = Alu.Add16(BX, UInt16[DS, 0x2888]);
    // RET  (1000_A464 / 0x1A464)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A465_01A465(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A465_1A465:
    // PUSH AX (1000_A465 / 0x1A465)
    Stack.Push(AX);
    // MOV DX,word ptr [0x28c7] (1000_A466 / 0x1A466)
    DX = UInt16[DS, 0x28C7];
    // MOV BX,0x28dc (1000_A46A / 0x1A46A)
    BX = 0x28DC;
    // XLAT BX (1000_A46D / 0x1A46D)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // MOV BL,0x7 (1000_A46E / 0x1A46E)
    BL = 0x7;
    // MUL BL (1000_A470 / 0x1A470)
    Cpu.Mul8(BL);
    // MOV BX,AX (1000_A472 / 0x1A472)
    BX = AX;
    // ADD BX,word ptr [0x28c9] (1000_A474 / 0x1A474)
    // BX += UInt16[DS, 0x28C9];
    BX = Alu.Add16(BX, UInt16[DS, 0x28C9]);
    // CALL 0x1000:a45c (1000_A478 / 0x1A478)
    NearCall(cs1, 0xA47B, spice86_generated_label_call_target_1000_A45C_01A45C);
    label_1000_A47B_1A47B:
    // POP AX (1000_A47B / 0x1A47B)
    AX = Stack.Pop();
    // RET  (1000_A47C / 0x1A47C)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A47D_01A47D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A47D_1A47D:
    // TEST word ptr [0xdbc8],0x8 (1000_A47D / 0x1A47D)
    Alu.And16(UInt16[DS, 0xDBC8], 0x8);
    // JZ 0x1000:a48b (1000_A483 / 0x1A483)
    if(ZeroFlag) {
      goto label_1000_A48B_1A48B;
    }
    // MOV SI,0x28a6 (1000_A485 / 0x1A485)
    SI = 0x28A6;
    // CALL 0x1000:a49c (1000_A488 / 0x1A488)
    throw FailAsUntested("Could not find a valid function at address 1000_A49C / 0x1A49C");
    label_1000_A48B_1A48B:
    // TEST word ptr [0xdbc8],0x800 (1000_A48B / 0x1A48B)
    Alu.And16(UInt16[DS, 0xDBC8], 0x800);
    // JZ 0x1000:a4c5 (1000_A491 / 0x1A491)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A4C5 / 0x1A4C5)
      return NearRet();
    }
    // MOV SI,0x28ae (1000_A493 / 0x1A493)
    SI = 0x28AE;
    // CALL 0x1000:a49c (1000_A496 / 0x1A496)
    throw FailAsUntested("Could not find a valid function at address 1000_A49C / 0x1A49C");
    // MOV SI,0x28b6 (1000_A499 / 0x1A499)
    SI = 0x28B6;
    label_1000_A49C_1A49C:
    // PUSH word ptr [0xdbda] (1000_A49C / 0x1A49C)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_A4A0 / 0x1A4A0)
    NearCall(cs1, 0xA4A3, spice86_generated_label_call_target_1000_C08E_01C08E);
    // MOV AX,0x55 (1000_A4A3 / 0x1A4A3)
    AX = 0x55;
    // CALL 0x1000:c13e (1000_A4A6 / 0x1A4A6)
    NearCall(cs1, 0xA4A9, spice86_generated_label_call_target_1000_C13E_01C13E);
    // LODSB SI (1000_A4A9 / 0x1A4A9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // AAM 0xa (1000_A4AA / 0x1A4AA)
    Cpu.Aam(0xA);
    // MOV AL,AH (1000_A4AC / 0x1A4AC)
    AL = AH;
    // XOR AH,AH (1000_A4AE / 0x1A4AE)
    AH = 0;
    // ADD AL,0x3 (1000_A4B0 / 0x1A4B0)
    // AL += 0x3;
    AL = Alu.Add8(AL, 0x3);
    // MOV byte ptr [SI],0x1 (1000_A4B2 / 0x1A4B2)
    UInt8[DS, SI] = 0x1;
    // INC SI (1000_A4B5 / 0x1A4B5)
    SI = Alu.Inc16(SI);
    // MOV DX,word ptr [SI] (1000_A4B6 / 0x1A4B6)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_A4B8 / 0x1A4B8)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL 0x1000:a45c (1000_A4BB / 0x1A4BB)
    NearCall(cs1, 0xA4BE, spice86_generated_label_call_target_1000_A45C_01A45C);
    // CALL 0x1000:c22f (1000_A4BE / 0x1A4BE)
    NearCall(cs1, 0xA4C1, spice86_generated_label_call_target_1000_C22F_01C22F);
    // POP word ptr [0xdbda] (1000_A4C1 / 0x1A4C1)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    label_1000_A4C5_1A4C5:
    // RET  (1000_A4C5 / 0x1A4C5)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A4C6_01A4C6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A4C6_1A4C6:
    // CALL 0x1000:ae2f (1000_A4C6 / 0x1A4C6)
    NearCall(cs1, 0xA4C9, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_A4C9_1A4C9:
    // JZ 0x1000:a4de (1000_A4C9 / 0x1A4C9)
    if(ZeroFlag) {
      goto label_1000_A4DE_1A4DE;
    }
    // MOV SI,0x288e (1000_A4CB / 0x1A4CB)
    SI = 0x288E;
    // CALL 0x1000:a502 (1000_A4CE / 0x1A4CE)
    NearCall(cs1, 0xA4D1, spice86_generated_label_call_target_1000_A502_01A502);
    // TEST word ptr [0xdbc8],0x4 (1000_A4D1 / 0x1A4D1)
    Alu.And16(UInt16[DS, 0xDBC8], 0x4);
    // JNZ 0x1000:a4de (1000_A4D7 / 0x1A4D7)
    if(!ZeroFlag) {
      goto label_1000_A4DE_1A4DE;
    }
    // MOV byte ptr [0x288f],0x0 (1000_A4D9 / 0x1A4D9)
    UInt8[DS, 0x288F] = 0x0;
    label_1000_A4DE_1A4DE:
    // CALL 0x1000:ae28 (1000_A4DE / 0x1A4DE)
    NearCall(cs1, 0xA4E1, spice86_generated_label_call_target_1000_AE28_01AE28);
    label_1000_A4E1_1A4E1:
    // JZ 0x1000:a540 (1000_A4E1 / 0x1A4E1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A540 / 0x1A540)
      return NearRet();
    }
    // MOV SI,0x2896 (1000_A4E3 / 0x1A4E3)
    SI = 0x2896;
    // CALL 0x1000:a502 (1000_A4E6 / 0x1A4E6)
    NearCall(cs1, 0xA4E9, spice86_generated_label_call_target_1000_A502_01A502);
    label_1000_A4E9_1A4E9:
    // MOV SI,0x289e (1000_A4E9 / 0x1A4E9)
    SI = 0x289E;
    // CALL 0x1000:a502 (1000_A4EC / 0x1A4EC)
    NearCall(cs1, 0xA4EF, spice86_generated_label_call_target_1000_A502_01A502);
    label_1000_A4EF_1A4EF:
    // TEST word ptr [0xdbc8],0x400 (1000_A4EF / 0x1A4EF)
    Alu.And16(UInt16[DS, 0xDBC8], 0x400);
    // JNZ 0x1000:a540 (1000_A4F5 / 0x1A4F5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A540 / 0x1A540)
      return NearRet();
    }
    // MOV byte ptr [0x2897],0x0 (1000_A4F7 / 0x1A4F7)
    UInt8[DS, 0x2897] = 0x0;
    // MOV byte ptr [0x289f],0x0 (1000_A4FC / 0x1A4FC)
    UInt8[DS, 0x289F] = 0x0;
    // RET  (1000_A501 / 0x1A501)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A502_01A502(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A502_1A502:
    // PUSH word ptr [0xdbda] (1000_A502 / 0x1A502)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_A506 / 0x1A506)
    NearCall(cs1, 0xA509, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_A509_1A509:
    // PUSH SI (1000_A509 / 0x1A509)
    Stack.Push(SI);
    // MOV AX,0x55 (1000_A50A / 0x1A50A)
    AX = 0x55;
    // CALL 0x1000:c13e (1000_A50D / 0x1A50D)
    NearCall(cs1, 0xA510, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_A510_1A510:
    // MOV DX,word ptr [SI + 0x2] (1000_A510 / 0x1A510)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,0x22 (1000_A513 / 0x1A513)
    BX = 0x22;
    // CALL 0x1000:a45c (1000_A516 / 0x1A516)
    NearCall(cs1, 0xA519, spice86_generated_label_call_target_1000_A45C_01A45C);
    label_1000_A519_1A519:
    // MOV AX,0x1 (1000_A519 / 0x1A519)
    AX = 0x1;
    // CALL 0x1000:c2fd (1000_A51C / 0x1A51C)
    NearCall(cs1, 0xA51F, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_A51F_1A51F:
    // POP SI (1000_A51F / 0x1A51F)
    SI = Stack.Pop();
    // LODSB SI (1000_A520 / 0x1A520)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV byte ptr [SI],0x1 (1000_A521 / 0x1A521)
    UInt8[DS, SI] = 0x1;
    // NOT AX (1000_A524 / 0x1A524)
    AX = (ushort)~AX;
    // SHR AL,0x1 (1000_A526 / 0x1A526)
    AL >>= 0x1;
    
    // SHR AL,0x1 (1000_A528 / 0x1A528)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // CBW  (1000_A52A / 0x1A52A)
    AX = (ushort)((short)((sbyte)AL));
    // ADD AX,BX (1000_A52B / 0x1A52B)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    // MOV BX,AX (1000_A52D / 0x1A52D)
    BX = AX;
    // SUB AX,word ptr [0x2888] (1000_A52F / 0x1A52F)
    // AX -= UInt16[DS, 0x2888];
    AX = Alu.Sub16(AX, UInt16[DS, 0x2888]);
    // MOV word ptr [SI + 0x3],AX (1000_A533 / 0x1A533)
    UInt16[DS, (ushort)(SI + 0x3)] = AX;
    // MOV AX,0x2 (1000_A536 / 0x1A536)
    AX = 0x2;
    // CALL 0x1000:c22f (1000_A539 / 0x1A539)
    NearCall(cs1, 0xA53C, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_A53C_1A53C:
    // POP word ptr [0xdbda] (1000_A53C / 0x1A53C)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_A540_01A540, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_A540_01A540(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A540_1A540:
    // RET  (1000_A540 / 0x1A540)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A541_01A541(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A541_1A541:
    // MOV AL,[0x28e7] (1000_A541 / 0x1A541)
    AL = UInt8[DS, 0x28E7];
    // MOV [0x28e8],AL (1000_A544 / 0x1A544)
    UInt8[DS, 0x28E8] = AL;
    // CALL 0x1000:daa3 (1000_A547 / 0x1A547)
    NearCall(cs1, 0xA54A, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    label_1000_A54A_1A54A:
    // CALL 0x1000:d95b (1000_A54A / 0x1A54A)
    NearCall(cs1, 0xA54D, spice86_generated_label_call_target_1000_D95B_01D95B);
    label_1000_A54D_1A54D:
    // MOV SI,0x2886 (1000_A54D / 0x1A54D)
    SI = 0x2886;
    // JMP 0x1000:c4f0 (1000_A550 / 0x1A550)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_A553_01A553(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A553_1A553:
    // CALL 0x1000:ae2f (1000_A553 / 0x1A553)
    NearCall(cs1, 0xA556, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    // JZ 0x1000:a540 (1000_A556 / 0x1A556)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A540 / 0x1A540)
      return NearRet();
    }
    // MOV AX,0x4 (1000_A558 / 0x1A558)
    AX = 0x4;
    // MOV BX,0x5 (1000_A55B / 0x1A55B)
    BX = 0x5;
    // CALL 0x1000:a8bc (1000_A55E / 0x1A55E)
    NearCall(cs1, 0xA561, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    // CALL 0x1000:a83f (1000_A561 / 0x1A561)
    NearCall(cs1, 0xA564, spice86_generated_label_call_target_1000_A83F_01A83F);
    // CALL 0x1000:ade0 (1000_A564 / 0x1A564)
    throw FailAsUntested("Could not find a valid function at address 1000_ADE0 / 0x1ADE0");
    // MOV byte ptr [0xdc2b],0x1 (1000_A567 / 0x1A567)
    UInt8[DS, 0xDC2B] = 0x1;
    // MOV SI,0x3811 (1000_A56C / 0x1A56C)
    SI = 0x3811;
    // CALLF [0x3991] (1000_A56F / 0x1A56F)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_A56F = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_A56F) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A56F));
        break;
    }
    // JMP 0x1000:aba9 (1000_A573 / 0x1A573)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ABA9_01ABA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A576_1A576:
    // MOV DI,0x2886 (1000_A576 / 0x1A576)
    DI = 0x2886;
    // CALL 0x1000:d6fe (1000_A579 / 0x1A579)
    NearCall(cs1, 0xA57C, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_A57C_1A57C:
    // JC 0x1000:a581 (1000_A57C / 0x1A57C)
    if(CarryFlag) {
      goto label_1000_A581_1A581;
    }
    // JMP 0x1000:d2e2 (1000_A57E / 0x1A57E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A581_1A581:
    // CALL 0x1000:a453 (1000_A581 / 0x1A581)
    NearCall(cs1, 0xA584, spice86_generated_label_call_target_1000_A453_01A453);
    label_1000_A584_1A584:
    // MOV DI,0x28bf (1000_A584 / 0x1A584)
    DI = 0x28BF;
    // CALL 0x1000:d6fe (1000_A587 / 0x1A587)
    NearCall(cs1, 0xA58A, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_A58A_1A58A:
    // JC 0x1000:a553 (1000_A58A / 0x1A58A)
    if(CarryFlag) {
      goto label_1000_A553_1A553;
    }
    // MOV DI,0x28c7 (1000_A58C / 0x1A58C)
    DI = 0x28C7;
    // CALL 0x1000:d6fe (1000_A58F / 0x1A58F)
    NearCall(cs1, 0xA592, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_A592_1A592:
    // JC 0x1000:a5b0 (1000_A592 / 0x1A592)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A5B0_01A5B0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A594_01A594, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A594_01A594(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A594_1A594:
    // CALL 0x1000:a672 (1000_A594 / 0x1A594)
    NearCall(cs1, 0xA597, spice86_generated_label_call_target_1000_A672_01A672);
    label_1000_A597_1A597:
    // JNC 0x1000:a59f (1000_A597 / 0x1A597)
    if(!CarryFlag) {
      goto label_1000_A59F_1A59F;
    }
    // MOV byte ptr [0x28be],0x1 (1000_A599 / 0x1A599)
    UInt8[DS, 0x28BE] = 0x1;
    // RET  (1000_A59E / 0x1A59E)
    return NearRet();
    label_1000_A59F_1A59F:
    // CALL 0x1000:a69f (1000_A59F / 0x1A59F)
    NearCall(cs1, 0xA5A2, spice86_generated_label_call_target_1000_A69F_01A69F);
    label_1000_A5A2_1A5A2:
    // JNC 0x1000:a5aa (1000_A5A2 / 0x1A5A2)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A5AA_01A5AA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [0x28be],0x2 (1000_A5A4 / 0x1A5A4)
    UInt8[DS, 0x28BE] = 0x2;
    // RET  (1000_A5A9 / 0x1A5A9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A5AA_01A5AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A5AA_1A5AA:
    // MOV byte ptr [0x28be],0x0 (1000_A5AA / 0x1A5AA)
    UInt8[DS, 0x28BE] = 0x0;
    // RET  (1000_A5AF / 0x1A5AF)
    return NearRet();
  }
  
  public Action split_1000_A5B0_01A5B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A5B0_1A5B0:
    // SUB BX,word ptr [DI + 0x2] (1000_A5B0 / 0x1A5B0)
    // BX -= UInt16[DS, (ushort)(DI + 0x2)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // MOV AX,BX (1000_A5B3 / 0x1A5B3)
    AX = BX;
    // MOV BL,0x7 (1000_A5B5 / 0x1A5B5)
    BL = 0x7;
    // DIV BL (1000_A5B7 / 0x1A5B7)
    Cpu.Div8(BL);
    // MOV BX,0x28cf (1000_A5B9 / 0x1A5B9)
    BX = 0x28CF;
    // XLAT BX (1000_A5BC / 0x1A5BC)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // CMP AL,0x7 (1000_A5BD / 0x1A5BD)
    Alu.Sub8(AL, 0x7);
    // JC 0x1000:a5ca (1000_A5BF / 0x1A5BF)
    if(CarryFlag) {
      goto label_1000_A5CA_1A5CA;
    }
    // JZ 0x1000:a5de (1000_A5C1 / 0x1A5C1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A5DE / 0x1A5DE)
      return NearRet();
    }
    // SUB AL,0x8 (1000_A5C3 / 0x1A5C3)
    // AL -= 0x8;
    AL = Alu.Sub8(AL, 0x8);
    // MOV [0x28e7],AL (1000_A5C5 / 0x1A5C5)
    UInt8[DS, 0x28E7] = AL;
    // JMP 0x1000:a5db (1000_A5C8 / 0x1A5C8)
    // JMP target is JMP, inlining.
    // JMP 0x1000:a3f9 (1000_A5DB / 0x1A5DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_A3F9_01A3F9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A5CA_1A5CA:
    // CMP AL,byte ptr [0xceeb] (1000_A5CA / 0x1A5CA)
    Alu.Sub8(AL, UInt8[DS, 0xCEEB]);
    // JZ 0x1000:a5de (1000_A5CE / 0x1A5CE)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A5DE / 0x1A5DE)
      return NearRet();
    }
    // AND byte ptr [0x28e7],0xfd (1000_A5D0 / 0x1A5D0)
    // UInt8[DS, 0x28E7] &= 0xFD;
    UInt8[DS, 0x28E7] = Alu.And8(UInt8[DS, 0x28E7], 0xFD);
    // MOV [0xceeb],AL (1000_A5D5 / 0x1A5D5)
    UInt8[DS, 0xCEEB] = AL;
    // CALL 0x1000:cfe4 (1000_A5D8 / 0x1A5D8)
    throw FailAsUntested("Could not find a valid function at address 1000_CFE4 / 0x1CFE4");
    label_1000_A5DB_1A5DB:
    // JMP 0x1000:a3f9 (1000_A5DB / 0x1A5DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_A3F9_01A3F9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A5DE_1A5DE:
    // RET  (1000_A5DE / 0x1A5DE)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A5DF_01A5DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A5DF_1A5DF:
    // CALL 0x1000:a453 (1000_A5DF / 0x1A5DF)
    NearCall(cs1, 0xA5E2, spice86_generated_label_call_target_1000_A453_01A453);
    label_1000_A5E2_1A5E2:
    // SUB BX,CX (1000_A5E2 / 0x1A5E2)
    // BX -= CX;
    BX = Alu.Sub16(BX, CX);
    // CALL 0x1000:a594 (1000_A5E4 / 0x1A5E4)
    NearCall(cs1, 0xA5E7, spice86_generated_label_call_target_1000_A594_01A594);
    label_1000_A5E7_1A5E7:
    // CMP byte ptr [0x28be],0x1 (1000_A5E7 / 0x1A5E7)
    Alu.Sub8(UInt8[DS, 0x28BE], 0x1);
    // JZ 0x1000:a61a (1000_A5EC / 0x1A5EC)
    if(ZeroFlag) {
      goto label_1000_A61A_1A61A;
    }
    // CMP byte ptr [0x28be],0x2 (1000_A5EE / 0x1A5EE)
    Alu.Sub8(UInt8[DS, 0x28BE], 0x2);
    // JNZ 0x1000:a619 (1000_A5F3 / 0x1A5F3)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A619 / 0x1A619)
      return NearRet();
    }
    // CMP AX,0x6 (1000_A5F5 / 0x1A5F5)
    Alu.Sub16(AX, 0x6);
    // JNC 0x1000:a5fc (1000_A5F8 / 0x1A5F8)
    if(!CarryFlag) {
      goto label_1000_A5FC_1A5FC;
    }
    // NEG CX (1000_A5FA / 0x1A5FA)
    CX = Alu.Sub16(0, CX);
    label_1000_A5FC_1A5FC:
    // CMP BP,0x5 (1000_A5FC / 0x1A5FC)
    Alu.Sub16(BP, 0x5);
    // JC 0x1000:a603 (1000_A5FF / 0x1A5FF)
    if(CarryFlag) {
      goto label_1000_A603_1A603;
    }
    // NEG DI (1000_A601 / 0x1A601)
    DI = Alu.Sub16(0, DI);
    label_1000_A603_1A603:
    // MOV AL,0xa (1000_A603 / 0x1A603)
    AL = 0xA;
    // ADD CX,DI (1000_A605 / 0x1A605)
    // CX += DI;
    CX = Alu.Add16(CX, DI);
    // JNS 0x1000:a60b (1000_A607 / 0x1A607)
    if(!SignFlag) {
      goto label_1000_A60B_1A60B;
    }
    // NEG AL (1000_A609 / 0x1A609)
    AL = Alu.Sub8(0, AL);
    label_1000_A60B_1A60B:
    // ADD AL,byte ptr [SI] (1000_A60B / 0x1A60B)
    AL += UInt8[DS, SI];
    
    // CMP AL,0xf1 (1000_A60D / 0x1A60D)
    Alu.Sub8(AL, 0xF1);
    // JNC 0x1000:a619 (1000_A60F / 0x1A60F)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A619 / 0x1A619)
      return NearRet();
    }
    // MOV byte ptr [SI],AL (1000_A611 / 0x1A611)
    UInt8[DS, SI] = AL;
    // PUSH word ptr [SI + 0x6] (1000_A613 / 0x1A613)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x6)]);
    // JMP 0x1000:a49c (1000_A616 / 0x1A616)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A47D_01A47D, 0x1A49C - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A619_1A619:
    // RET  (1000_A619 / 0x1A619)
    return NearRet();
    label_1000_A61A_1A61A:
    // JCXZ 0x1000:a619 (1000_A61A / 0x1A61A)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_A619 / 0x1A619)
      return NearRet();
    }
    // MOV AX,word ptr [SI + 0x4] (1000_A61C / 0x1A61C)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // ADD AX,CX (1000_A61F / 0x1A61F)
    AX += CX;
    
    // SUB AX,0x22 (1000_A621 / 0x1A621)
    AX -= 0x22;
    
    // CMP AX,0x40 (1000_A624 / 0x1A624)
    Alu.Sub16(AX, 0x40);
    // JNC 0x1000:a619 (1000_A627 / 0x1A627)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A619 / 0x1A619)
      return NearRet();
    }
    // SHL AX,0x1 (1000_A629 / 0x1A629)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_A62B / 0x1A62B)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // NOT AX (1000_A62D / 0x1A62D)
    AX = (ushort)~AX;
    // MOV byte ptr [SI],AL (1000_A62F / 0x1A62F)
    UInt8[DS, SI] = AL;
    // PUSH word ptr [SI + 0x6] (1000_A631 / 0x1A631)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x6)]);
    // JMP 0x1000:a502 (1000_A634 / 0x1A634)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A502_01A502, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A637_01A637(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A637_1A637:
    // TEST word ptr [0xdbc8],0x4 (1000_A637 / 0x1A637)
    Alu.And16(UInt16[DS, 0xDBC8], 0x4);
    // JNZ 0x1000:a644 (1000_A63D / 0x1A63D)
    if(!ZeroFlag) {
      goto label_1000_A644_1A644;
    }
    // MOV byte ptr [0x288e],0xff (1000_A63F / 0x1A63F)
    UInt8[DS, 0x288E] = 0xFF;
    label_1000_A644_1A644:
    // MOV AL,[0x288e] (1000_A644 / 0x1A644)
    AL = UInt8[DS, 0x288E];
    // MOV AH,byte ptr [0x28a6] (1000_A647 / 0x1A647)
    AH = UInt8[DS, 0x28A6];
    // CALLF [0x39a5] (1000_A64B / 0x1A64B)
    // Indirect call to [0x39a5], generating possible targets from emulator records
    uint targetAddress_1000_A64B = (uint)(UInt16[DS, 0x39A7] * 0x10 + UInt16[DS, 0x39A5] - cs1 * 0x10);
    switch(targetAddress_1000_A64B) {
      case 0x46465 : FarCall(cs1, 0xA64F, spice86_generated_label_call_target_5635_0115_056465); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A64B));
        break;
    }
    label_1000_A64F_1A64F:
    // RET  (1000_A64F / 0x1A64F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A650_01A650(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A650_1A650:
    // TEST word ptr [0xdbc8],0x400 (1000_A650 / 0x1A650)
    Alu.And16(UInt16[DS, 0xDBC8], 0x400);
    // JNZ 0x1000:a660 (1000_A656 / 0x1A656)
    if(!ZeroFlag) {
      goto label_1000_A660_1A660;
    }
    // MOV AL,0xff (1000_A658 / 0x1A658)
    AL = 0xFF;
    // MOV [0x2896],AL (1000_A65A / 0x1A65A)
    UInt8[DS, 0x2896] = AL;
    // MOV [0x289e],AL (1000_A65D / 0x1A65D)
    UInt8[DS, 0x289E] = AL;
    label_1000_A660_1A660:
    // MOV AH,byte ptr [0x28ae] (1000_A660 / 0x1A660)
    AH = UInt8[DS, 0x28AE];
    // MOV AL,[0x2896] (1000_A664 / 0x1A664)
    AL = UInt8[DS, 0x2896];
    // CMP AL,0x4 (1000_A667 / 0x1A667)
    Alu.Sub8(AL, 0x4);
    // JNC 0x1000:a66d (1000_A669 / 0x1A669)
    if(!CarryFlag) {
      goto label_1000_A66D_1A66D;
    }
    // MOV AL,0x4 (1000_A66B / 0x1A66B)
    AL = 0x4;
    label_1000_A66D_1A66D:
    // CALLF [0x3985] (1000_A66D / 0x1A66D)
    // Indirect call to [0x3985], generating possible targets from emulator records
    uint targetAddress_1000_A66D = (uint)(UInt16[DS, 0x3987] * 0x10 + UInt16[DS, 0x3985] - cs1 * 0x10);
    switch(targetAddress_1000_A66D) {
      case 0x464F2 : FarCall(cs1, 0xA671, spice86_generated_label_call_target_563E_0112_0564F2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A66D));
        break;
    }
    label_1000_A671_1A671:
    // RET  (1000_A671 / 0x1A671)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A672_01A672(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A672_1A672:
    // MOV SI,0x288e (1000_A672 / 0x1A672)
    SI = 0x288E;
    // CALL 0x1000:a685 (1000_A675 / 0x1A675)
    NearCall(cs1, 0xA678, spice86_generated_label_call_target_1000_A685_01A685);
    label_1000_A678_1A678:
    // JC 0x1000:a69e (1000_A678 / 0x1A678)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    // MOV SI,0x2896 (1000_A67A / 0x1A67A)
    SI = 0x2896;
    // CALL 0x1000:a685 (1000_A67D / 0x1A67D)
    NearCall(cs1, 0xA680, spice86_generated_label_call_target_1000_A685_01A685);
    label_1000_A680_1A680:
    // JC 0x1000:a69e (1000_A680 / 0x1A680)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    // MOV SI,0x289e (1000_A682 / 0x1A682)
    SI = 0x289E;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A685_01A685, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A685_01A685(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A685_1A685:
    // CMP byte ptr [SI + 0x1],0x1 (1000_A685 / 0x1A685)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1)], 0x1);
    // CMC  (1000_A689 / 0x1A689)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:a69e (1000_A68A / 0x1A68A)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    // MOV AX,DX (1000_A68C / 0x1A68C)
    AX = DX;
    // SUB AX,word ptr [SI + 0x2] (1000_A68E / 0x1A68E)
    // AX -= UInt16[DS, (ushort)(SI + 0x2)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    // MOV BP,BX (1000_A691 / 0x1A691)
    BP = BX;
    // SUB BP,word ptr [SI + 0x4] (1000_A693 / 0x1A693)
    BP -= UInt16[DS, (ushort)(SI + 0x4)];
    
    // CMP AX,0x16 (1000_A696 / 0x1A696)
    Alu.Sub16(AX, 0x16);
    // JNC 0x1000:a69e (1000_A699 / 0x1A699)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A69E / 0x1A69E)
      return NearRet();
    }
    // CMP BP,0x5 (1000_A69B / 0x1A69B)
    Alu.Sub16(BP, 0x5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_A69E_01A69E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_A69E_01A69E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A69E_1A69E:
    // RET  (1000_A69E / 0x1A69E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A69F_01A69F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A69F_1A69F:
    // MOV SI,0x28a6 (1000_A69F / 0x1A69F)
    SI = 0x28A6;
    // CALL 0x1000:a6b2 (1000_A6A2 / 0x1A6A2)
    NearCall(cs1, 0xA6A5, spice86_generated_label_call_target_1000_A6B2_01A6B2);
    label_1000_A6A5_1A6A5:
    // JC 0x1000:a6cb (1000_A6A5 / 0x1A6A5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    // MOV SI,0x28ae (1000_A6A7 / 0x1A6A7)
    SI = 0x28AE;
    // CALL 0x1000:a6b2 (1000_A6AA / 0x1A6AA)
    NearCall(cs1, 0xA6AD, spice86_generated_label_call_target_1000_A6B2_01A6B2);
    label_1000_A6AD_1A6AD:
    // JC 0x1000:a6cb (1000_A6AD / 0x1A6AD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    // MOV SI,0x28b6 (1000_A6AF / 0x1A6AF)
    SI = 0x28B6;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A6B2_01A6B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A6B2_01A6B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A6B2_1A6B2:
    // CMP byte ptr [SI + 0x1],0x1 (1000_A6B2 / 0x1A6B2)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1)], 0x1);
    // CMC  (1000_A6B6 / 0x1A6B6)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:a6cb (1000_A6B7 / 0x1A6B7)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    // MOV AX,DX (1000_A6B9 / 0x1A6B9)
    AX = DX;
    // SUB AX,word ptr [SI + 0x2] (1000_A6BB / 0x1A6BB)
    // AX -= UInt16[DS, (ushort)(SI + 0x2)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    // MOV BP,BX (1000_A6BE / 0x1A6BE)
    BP = BX;
    // SUB BP,word ptr [SI + 0x4] (1000_A6C0 / 0x1A6C0)
    BP -= UInt16[DS, (ushort)(SI + 0x4)];
    
    // CMP AX,0xd (1000_A6C3 / 0x1A6C3)
    Alu.Sub16(AX, 0xD);
    // JNC 0x1000:a6cb (1000_A6C6 / 0x1A6C6)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A6CB / 0x1A6CB)
      return NearRet();
    }
    // CMP BP,0xb (1000_A6C8 / 0x1A6C8)
    Alu.Sub16(BP, 0xB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_A6CB_01A6CB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_A6CB_01A6CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A6CB_1A6CB:
    // RET  (1000_A6CB / 0x1A6CB)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A6CC_01A6CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A6CC_1A6CC:
    // CMP BX,-0x1 (1000_A6CC / 0x1A6CC)
    Alu.Sub16(BX, 0xFFFF);
    // JNZ 0x1000:a6e6 (1000_A6CF / 0x1A6CF)
    if(!ZeroFlag) {
      goto label_1000_A6E6_1A6E6;
    }
    // MOV AX,0xfff (1000_A6D1 / 0x1A6D1)
    AX = 0xFFF;
    // XOR byte ptr CS:[0xa6d3],0x10 (1000_A6D4 / 0x1A6D4)
    // UInt8[cs1, 0xA6D3] ^= 0x10;
    UInt8[cs1, 0xA6D3] = Alu.Xor8(UInt8[cs1, 0xA6D3], 0x10);
    // MOV BX,word ptr [0x22a6] (1000_A6DA / 0x1A6DA)
    BX = UInt16[DS, 0x22A6];
    // CALL 0x1000:a8bc (1000_A6DE / 0x1A6DE)
    NearCall(cs1, 0xA6E1, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    // CALL 0x1000:a7a5 (1000_A6E1 / 0x1A6E1)
    NearCall(cs1, 0xA6E4, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // JMP 0x1000:a740 (1000_A6E4 / 0x1A6E4)
    goto label_1000_A740_1A740;
    label_1000_A6E6_1A6E6:
    // PUSH BX (1000_A6E6 / 0x1A6E6)
    Stack.Push(BX);
    // CMP BL,0xe (1000_A6E7 / 0x1A6E7)
    Alu.Sub8(BL, 0xE);
    // JC 0x1000:a6ee (1000_A6EA / 0x1A6EA)
    if(CarryFlag) {
      goto label_1000_A6EE_1A6EE;
    }
    // MOV BL,0xe (1000_A6EC / 0x1A6EC)
    BL = 0xE;
    label_1000_A6EE_1A6EE:
    // AND AH,0xf3 (1000_A6EE / 0x1A6EE)
    AH &= 0xF3;
    
    // CMP byte ptr [0x47dc],0x0 (1000_A6F1 / 0x1A6F1)
    Alu.Sub8(UInt8[DS, 0x47DC], 0x0);
    // JZ 0x1000:a701 (1000_A6F6 / 0x1A6F6)
    if(ZeroFlag) {
      goto label_1000_A701_1A701;
    }
    // SUB AX,word ptr [0xd814] (1000_A6F8 / 0x1A6F8)
    AX -= UInt16[DS, 0xD814];
    
    // ADD AX,0x3e7 (1000_A6FC / 0x1A6FC)
    // AX += 0x3E7;
    AX = Alu.Add16(AX, 0x3E7);
    // JMP 0x1000:a710 (1000_A6FF / 0x1A6FF)
    goto label_1000_A710_1A710;
    label_1000_A701_1A701:
    // CMP byte ptr [0x227d],0x0 (1000_A701 / 0x1A701)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:a710 (1000_A706 / 0x1A706)
    if(!ZeroFlag) {
      goto label_1000_A710_1A710;
    }
    // SHL BX,0x1 (1000_A708 / 0x1A708)
    BX <<= 0x1;
    
    // SUB AX,word ptr [BX + 0xd7f4] (1000_A70A / 0x1A70A)
    AX -= UInt16[DS, (ushort)(BX + 0xD7F4)];
    
    // SHR BX,0x1 (1000_A70E / 0x1A70E)
    BX >>= 0x1;
    
    label_1000_A710_1A710:
    // CMP BL,0xe (1000_A710 / 0x1A710)
    Alu.Sub8(BL, 0xE);
    // JNZ 0x1000:a727 (1000_A713 / 0x1A713)
    if(!ZeroFlag) {
      goto label_1000_A727_1A727;
    }
    // MOV CX,AX (1000_A715 / 0x1A715)
    CX = AX;
    // AND CL,0xfe (1000_A717 / 0x1A717)
    CL &= 0xFE;
    
    // CMP CL,0x2c (1000_A71A / 0x1A71A)
    Alu.Sub8(CL, 0x2C);
    // JNZ 0x1000:a727 (1000_A71D / 0x1A71D)
    if(!ZeroFlag) {
      goto label_1000_A727_1A727;
    }
    // POP CX (1000_A71F / 0x1A71F)
    CX = Stack.Pop();
    // MOV CL,0xc (1000_A720 / 0x1A720)
    CL = 0xC;
    // MOV word ptr [0x47c4],CX (1000_A722 / 0x1A722)
    UInt16[DS, 0x47C4] = CX;
    // PUSH CX (1000_A726 / 0x1A726)
    Stack.Push(CX);
    label_1000_A727_1A727:
    // CALL 0x1000:a8bc (1000_A727 / 0x1A727)
    NearCall(cs1, 0xA72A, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    label_1000_A72A_1A72A:
    // CALL 0x1000:a7a5 (1000_A72A / 0x1A72A)
    NearCall(cs1, 0xA72D, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    label_1000_A72D_1A72D:
    // POP AX (1000_A72D / 0x1A72D)
    AX = Stack.Pop();
    // CALL 0x1000:9123 (1000_A72E / 0x1A72E)
    NearCall(cs1, 0xA731, spice86_generated_label_call_target_1000_9123_019123);
    label_1000_A731_1A731:
    // SHL AX,0x1 (1000_A731 / 0x1A731)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_A733 / 0x1A733)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_A735 / 0x1A735)
    AX <<= 0x1;
    
    // ADD AX,0x27fa (1000_A737 / 0x1A737)
    // AX += 0x27FA;
    AX = Alu.Add16(AX, 0x27FA);
    // MOV SI,AX (1000_A73A / 0x1A73A)
    SI = AX;
    // MOV word ptr [0xdc28],SI (1000_A73C / 0x1A73C)
    UInt16[DS, 0xDC28] = SI;
    label_1000_A740_1A740:
    // MOV byte ptr [0xdc2a],0xff (1000_A740 / 0x1A740)
    UInt8[DS, 0xDC2A] = 0xFF;
    // CALL 0x1000:a83f (1000_A745 / 0x1A745)
    NearCall(cs1, 0xA748, spice86_generated_label_call_target_1000_A83F_01A83F);
    label_1000_A748_1A748:
    // JC 0x1000:a754 (1000_A748 / 0x1A748)
    if(CarryFlag) {
      goto label_1000_A754_1A754;
    }
    // XOR byte ptr [0x37e2],0x6 (1000_A74A / 0x1A74A)
    // UInt8[DS, 0x37E2] ^= 0x6;
    UInt8[DS, 0x37E2] = Alu.Xor8(UInt8[DS, 0x37E2], 0x6);
    // CALL 0x1000:a83f (1000_A74F / 0x1A74F)
    NearCall(cs1, 0xA752, spice86_generated_label_call_target_1000_A83F_01A83F);
    label_1000_A752_1A752:
    // JNC 0x1000:a75b (1000_A752 / 0x1A752)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A75B / 0x1A75B)
      return NearRet();
    }
    label_1000_A754_1A754:
    // CALL 0x1000:ade0 (1000_A754 / 0x1A754)
    throw FailAsUntested("Could not find a valid function at address 1000_ADE0 / 0x1ADE0");
    // CALL 0x1000:d617 (1000_A757 / 0x1A757)
    throw FailAsUntested("Could not find a valid function at address 1000_D617 / 0x1D617");
    // STC  (1000_A75A / 0x1A75A)
    CarryFlag = true;
    label_1000_A75B_1A75B:
    // RET  (1000_A75B / 0x1A75B)
    return NearRet();
  }
  
  public Action split_1000_A75C_01A75C(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xA788: goto label_1000_A788_1A788;break; // Target of external jump from 0x1A7C5, 0x1A7B7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A75C_1A75C:
    // CALL 0x1000:9197 (1000_A75C / 0x1A75C)
    NearCall(cs1, 0xA75F, spice86_generated_label_call_target_1000_9197_019197);
    // MOV BP,0x0 (1000_A75F / 0x1A75F)
    BP = 0x0;
    // MOV SI,0xa7c2 (1000_A762 / 0x1A762)
    SI = 0xA7C2;
    // CALL 0x1000:da25 (1000_A765 / 0x1A765)
    NearCall(cs1, 0xA768, spice86_generated_label_call_target_1000_DA25_01DA25);
    // MOV byte ptr [0xdc2b],0x1 (1000_A768 / 0x1A768)
    UInt8[DS, 0xDC2B] = 0x1;
    // MOV SI,0x3811 (1000_A76D / 0x1A76D)
    SI = 0x3811;
    // CALLF [0x3991] (1000_A770 / 0x1A770)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_A770 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_A770) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A770));
        break;
    }
    // MOV AX,[0xce7a] (1000_A774 / 0x1A774)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc2c],AX (1000_A777 / 0x1A777)
    UInt16[DS, 0xDC2C] = AX;
    // MOV word ptr [0xdc2e],0x8000 (1000_A77A / 0x1A77A)
    UInt16[DS, 0xDC2E] = 0x8000;
    // CALL 0x1000:a814 (1000_A780 / 0x1A780)
    throw FailAsUntested("Could not find a valid function at address 1000_A814 / 0x1A814");
    // JNC 0x1000:a788 (1000_A783 / 0x1A783)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    // CALL 0x1000:a82e (1000_A785 / 0x1A785)
    throw FailAsUntested("Could not find a valid function at address 1000_A82E / 0x1A82E");
    label_1000_A788_1A788:
    // RET  (1000_A788 / 0x1A788)
    return NearRet();
  }
  
  public Action split_1000_A789_01A789(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A789_1A789:
    // XOR AX,AX (1000_A789 / 0x1A789)
    AX = 0;
    // XCHG word ptr [0xdc30],AX (1000_A78B / 0x1A78B)
    ushort tmp_1000_A78B = UInt16[DS, 0xDC30];
    UInt16[DS, 0xDC30] = AX;
    AX = tmp_1000_A78B;
    // OR AX,AX (1000_A78F / 0x1A78F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:a7a5 (1000_A791 / 0x1A791)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A7A5_01A7A5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH AX (1000_A793 / 0x1A793)
    Stack.Push(AX);
    // CALL 0x1000:a7a5 (1000_A794 / 0x1A794)
    NearCall(cs1, 0xA797, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // POP AX (1000_A797 / 0x1A797)
    AX = Stack.Pop();
    // ADD AX,word ptr [0xd810] (1000_A798 / 0x1A798)
    // AX += UInt16[DS, 0xD810];
    AX = Alu.Add16(AX, UInt16[DS, 0xD810]);
    // MOV BL,0xe (1000_A79C / 0x1A79C)
    BL = 0xE;
    // CALL 0x1000:a6cc (1000_A79E / 0x1A79E)
    NearCall(cs1, 0xA7A1, spice86_generated_label_call_target_1000_A6CC_01A6CC);
    // JNC 0x1000:a788 (1000_A7A1 / 0x1A7A1)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    // JMP 0x1000:a75c (1000_A7A3 / 0x1A7A3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_A75C_01A75C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A7A5_01A7A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A7A5_1A7A5:
    // MOV SI,0xa7c2 (1000_A7A5 / 0x1A7A5)
    SI = 0xA7C2;
    // CALL 0x1000:da5f (1000_A7A8 / 0x1A7A8)
    NearCall(cs1, 0xA7AB, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_A7AB_1A7AB:
    // MOV word ptr [0xdc26],0x0 (1000_A7AB / 0x1A7AB)
    UInt16[DS, 0xDC26] = 0x0;
    // CALL 0x1000:d61d (1000_A7B1 / 0x1A7B1)
    NearCall(cs1, 0xA7B4, spice86_generated_label_call_target_1000_D61D_01D61D);
    label_1000_A7B4_1A7B4:
    // CALL 0x1000:abcc (1000_A7B4 / 0x1A7B4)
    NearCall(cs1, 0xA7B7, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_A7B7_1A7B7:
    // JZ 0x1000:a788 (1000_A7B7 / 0x1A7B7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    // CALL 0x1000:abc6 (1000_A7B9 / 0x1A7B9)
    throw FailAsUntested("Could not find a valid function at address 1000_ABC6 / 0x1ABC6");
    // CALL 0x1000:a9a1 (1000_A7BC / 0x1A7BC)
    NearCall(cs1, 0xA7BF, spice86_generated_label_call_target_1000_A9A1_01A9A1);
    // JMP 0x1000:aded (1000_A7BF / 0x1A7BF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_ADED_01ADED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A7C2_01A7C2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A7C2_1A7C2:
    // CALL 0x1000:abcc (1000_A7C2 / 0x1A7C2)
    NearCall(cs1, 0xA7C5, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_A7C5_1A7C5:
    // JZ 0x1000:a788 (1000_A7C5 / 0x1A7C5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A788 / 0x1A788)
      return NearRet();
    }
    // CMP word ptr [0xdc26],0x0 (1000_A7C7 / 0x1A7C7)
    Alu.Sub16(UInt16[DS, 0xDC26], 0x0);
    // JNZ 0x1000:a7d5 (1000_A7CC / 0x1A7CC)
    if(!ZeroFlag) {
      goto label_1000_A7D5_1A7D5;
    }
    // CALL 0x1000:a9e7 (1000_A7CE / 0x1A7CE)
    NearCall(cs1, 0xA7D1, pcm_test_audio_done_ida_1000_A9E7_1A9E7);
    // JNZ 0x1000:a789 (1000_A7D1 / 0x1A7D1)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A789_01A789, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:a811 (1000_A7D3 / 0x1A7D3)
    // JMP target is JMP, inlining.
    // JMP 0x1000:a9b9 (1000_A811 / 0x1A811)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_A9B9_01A9B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A7D5_1A7D5:
    // MOV DX,word ptr [0xce7a] (1000_A7D5 / 0x1A7D5)
    DX = UInt16[DS, 0xCE7A];
    // XOR DI,DI (1000_A7D9 / 0x1A7D9)
    DI = 0;
    // MOV BX,word ptr [0xdc2c] (1000_A7DB / 0x1A7DB)
    BX = UInt16[DS, 0xDC2C];
    // MOV BP,word ptr [0xdc2e] (1000_A7DF / 0x1A7DF)
    BP = UInt16[DS, 0xDC2E];
    // MOV CX,word ptr [0x2882] (1000_A7E3 / 0x1A7E3)
    CX = UInt16[DS, 0x2882];
    // MOV SI,word ptr [0x2884] (1000_A7E7 / 0x1A7E7)
    SI = UInt16[DS, 0x2884];
    // ADD BP,SI (1000_A7EB / 0x1A7EB)
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    // ADC BX,CX (1000_A7ED / 0x1A7ED)
    BX = Alu.Adc16(BX, CX);
    // SUB DX,BX (1000_A7EF / 0x1A7EF)
    // DX -= BX;
    DX = Alu.Sub16(DX, BX);
    // JS 0x1000:a811 (1000_A7F1 / 0x1A7F1)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:a9b9 (1000_A811 / 0x1A811)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A9B9_01A9B9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_A7F3_1A7F3:
    // PUSH DI (1000_A7F3 / 0x1A7F3)
    Stack.Push(DI);
    // CALL 0x1000:a814 (1000_A7F4 / 0x1A7F4)
    throw FailAsUntested("Could not find a valid function at address 1000_A814 / 0x1A814");
    // POP DI (1000_A7F7 / 0x1A7F7)
    DI = Stack.Pop();
    // JNC 0x1000:a789 (1000_A7F8 / 0x1A7F8)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A789_01A789, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // SUB DI,SI (1000_A7FA / 0x1A7FA)
    // DI -= SI;
    DI = Alu.Sub16(DI, SI);
    // SBB DX,CX (1000_A7FC / 0x1A7FC)
    DX = Alu.Sbb16(DX, CX);
    // JC 0x1000:a806 (1000_A7FE / 0x1A7FE)
    if(CarryFlag) {
      goto label_1000_A806_1A806;
    }
    // ADD BP,SI (1000_A800 / 0x1A800)
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    // ADC BX,CX (1000_A802 / 0x1A802)
    BX = Alu.Adc16(BX, CX);
    // JMP 0x1000:a7f3 (1000_A804 / 0x1A804)
    goto label_1000_A7F3_1A7F3;
    label_1000_A806_1A806:
    // MOV word ptr [0xdc2c],BX (1000_A806 / 0x1A806)
    UInt16[DS, 0xDC2C] = BX;
    // MOV word ptr [0xdc2e],BP (1000_A80A / 0x1A80A)
    UInt16[DS, 0xDC2E] = BP;
    // CALL 0x1000:a82e (1000_A80E / 0x1A80E)
    throw FailAsUntested("Could not find a valid function at address 1000_A82E / 0x1A82E");
    label_1000_A811_1A811:
    // JMP 0x1000:a9b9 (1000_A811 / 0x1A811)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_A9B9_01A9B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A83F_01A83F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A83F_1A83F:
    // MOV word ptr [0xdc26],0x0 (1000_A83F / 0x1A83F)
    UInt16[DS, 0xDC26] = 0x0;
    // CALL 0x1000:ae2f (1000_A845 / 0x1A845)
    NearCall(cs1, 0xA848, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_A848_1A848:
    // JZ 0x1000:a87d (1000_A848 / 0x1A848)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A87D / 0x1A87D)
      return NearRet();
    }
    // CALL 0x1000:ac14 (1000_A84A / 0x1A84A)
    NearCall(cs1, 0xA84D, spice86_generated_label_call_target_1000_AC14_01AC14);
    // CALL 0x1000:a90b (1000_A84D / 0x1A84D)
    NearCall(cs1, 0xA850, open_res_file_ida_1000_A90B_1A90B);
    // CMC  (1000_A850 / 0x1A850)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:a87d (1000_A851 / 0x1A851)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_A87D / 0x1A87D)
      return NearRet();
    }
    // LES DI,[0x3811] (1000_A853 / 0x1A853)
    ES = UInt16[DS, 0x3813];
    DI = UInt16[DS, 0x3811];
    // ADD DI,0x1a (1000_A857 / 0x1A857)
    DI += 0x1A;
    
    // CMP byte ptr ES:[DI],0x5 (1000_A85A / 0x1A85A)
    Alu.Sub8(UInt8[ES, DI], 0x5);
    // JNZ 0x1000:a871 (1000_A85E / 0x1A85E)
    if(!ZeroFlag) {
      goto label_1000_A871_1A871;
    }
    // MOV CX,word ptr ES:[DI + 0x1] (1000_A860 / 0x1A860)
    CX = UInt16[ES, (ushort)(DI + 0x1)];
    // ADD DI,0x4 (1000_A864 / 0x1A864)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    // MOV AX,DI (1000_A867 / 0x1A867)
    AX = DI;
    // ADD AX,0x2 (1000_A869 / 0x1A869)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // MOV [0xdc26],AX (1000_A86C / 0x1A86C)
    UInt16[DS, 0xDC26] = AX;
    // ADD DI,CX (1000_A86F / 0x1A86F)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    label_1000_A871_1A871:
    // MOV word ptr [0x3811],DI (1000_A871 / 0x1A871)
    UInt16[DS, 0x3811] = DI;
    // SUB word ptr [0x3815],DI (1000_A875 / 0x1A875)
    // UInt16[DS, 0x3815] -= DI;
    UInt16[DS, 0x3815] = Alu.Sub16(UInt16[DS, 0x3815], DI);
    // CALL 0x1000:a9b9 (1000_A879 / 0x1A879)
    NearCall(cs1, 0xA87C, split_1000_A9B9_01A9B9);
    // STC  (1000_A87C / 0x1A87C)
    CarryFlag = true;
    label_1000_A87D_1A87D:
    // RET  (1000_A87D / 0x1A87D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A87E_01A87E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A87E_1A87E:
    // PUSHF  (1000_A87E / 0x1A87E)
    Stack.Push(FlagRegister);
    // STI  (1000_A87F / 0x1A87F)
    InterruptFlag = true;
    // CALL 0x1000:ae2f (1000_A880 / 0x1A880)
    NearCall(cs1, 0xA883, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_A883_1A883:
    // JZ 0x1000:a8af (1000_A883 / 0x1A883)
    if(ZeroFlag) {
      goto label_1000_A8AF_1A8AF;
    }
    // CALL 0x1000:ac14 (1000_A885 / 0x1A885)
    NearCall(cs1, 0xA888, spice86_generated_label_call_target_1000_AC14_01AC14);
    // MOV AL,0xb (1000_A888 / 0x1A888)
    AL = 0xB;
    // CALL 0x1000:abe9 (1000_A88A / 0x1A88A)
    NearCall(cs1, 0xA88D, open_voc_resource_ida_1000_ABE9_1ABE9);
    // MOV SI,0x3811 (1000_A88D / 0x1A88D)
    SI = 0x3811;
    // CALLF [0x3991] (1000_A890 / 0x1A890)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_A890 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_A890) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A890));
        break;
    }
    // PUSH word ptr [0xce7a] (1000_A894 / 0x1A894)
    Stack.Push(UInt16[DS, 0xCE7A]);
    label_1000_A898_1A898:
    // CALL 0x1000:a9e7 (1000_A898 / 0x1A898)
    NearCall(cs1, 0xA89B, pcm_test_audio_done_ida_1000_A9E7_1A9E7);
    // JZ 0x1000:a898 (1000_A89B / 0x1A89B)
    if(ZeroFlag) {
      goto label_1000_A898_1A898;
    }
    // MOV AX,[0xce7a] (1000_A89D / 0x1A89D)
    AX = UInt16[DS, 0xCE7A];
    // POP BX (1000_A8A0 / 0x1A8A0)
    BX = Stack.Pop();
    // SUB AX,BX (1000_A8A1 / 0x1A8A1)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // MOV CX,0x800 (1000_A8A3 / 0x1A8A3)
    CX = 0x800;
    // MUL CX (1000_A8A6 / 0x1A8A6)
    Cpu.Mul16(CX);
    // MOV word ptr [0x2882],DX (1000_A8A8 / 0x1A8A8)
    UInt16[DS, 0x2882] = DX;
    // MOV [0x2884],AX (1000_A8AC / 0x1A8AC)
    UInt16[DS, 0x2884] = AX;
    label_1000_A8AF_1A8AF:
    // POPF  (1000_A8AF / 0x1A8AF)
    FlagRegister = Stack.Pop();
    // RET  (1000_A8B0 / 0x1A8B0)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A8B1_01A8B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A8B1_1A8B1:
    // AND AL,0xf (1000_A8B1 / 0x1A8B1)
    AL &= 0xF;
    
    // ADD AL,0x30 (1000_A8B3 / 0x1A8B3)
    AL += 0x30;
    
    // CMP AL,0x39 (1000_A8B5 / 0x1A8B5)
    Alu.Sub8(AL, 0x39);
    // JBE 0x1000:a8bb (1000_A8B7 / 0x1A8B7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_A8BB / 0x1A8BB)
      return NearRet();
    }
    // ADD AL,0x7 (1000_A8B9 / 0x1A8B9)
    // AL += 0x7;
    AL = Alu.Add8(AL, 0x7);
    label_1000_A8BB_1A8BB:
    // RET  (1000_A8BB / 0x1A8BB)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_A8BC_01A8BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A8BC_1A8BC:
    // MOV DI,0x37db (1000_A8BC / 0x1A8BC)
    DI = 0x37DB;
    // PUSH DS (1000_A8BF / 0x1A8BF)
    Stack.Push(DS);
    // POP ES (1000_A8C0 / 0x1A8C0)
    ES = Stack.Pop();
    // PUSH AX (1000_A8C1 / 0x1A8C1)
    Stack.Push(AX);
    // MOV AL,BL (1000_A8C2 / 0x1A8C2)
    AL = BL;
    // ADD AL,0x41 (1000_A8C4 / 0x1A8C4)
    // AL += 0x41;
    AL = Alu.Add8(AL, 0x41);
    // STOSB ES:DI (1000_A8C6 / 0x1A8C6)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // INC DI (1000_A8C7 / 0x1A8C7)
    DI = Alu.Inc16(DI);
    // INC DI (1000_A8C8 / 0x1A8C8)
    DI = Alu.Inc16(DI);
    // STOSB ES:DI (1000_A8C9 / 0x1A8C9)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // POP BX (1000_A8CA / 0x1A8CA)
    BX = Stack.Pop();
    // MOV CL,0x4 (1000_A8CB / 0x1A8CB)
    CL = 0x4;
    // MOV AL,BH (1000_A8CD / 0x1A8CD)
    AL = BH;
    // CALL 0x1000:a8b1 (1000_A8CF / 0x1A8CF)
    NearCall(cs1, 0xA8D2, spice86_generated_label_call_target_1000_A8B1_01A8B1);
    label_1000_A8D2_1A8D2:
    // STOSB ES:DI (1000_A8D2 / 0x1A8D2)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,BL (1000_A8D3 / 0x1A8D3)
    AL = BL;
    // SHR AL,CL (1000_A8D5 / 0x1A8D5)
    // AL >>= CL;
    AL = Alu.Shr8(AL, CL);
    // CALL 0x1000:a8b1 (1000_A8D7 / 0x1A8D7)
    NearCall(cs1, 0xA8DA, spice86_generated_label_call_target_1000_A8B1_01A8B1);
    label_1000_A8DA_1A8DA:
    // STOSB ES:DI (1000_A8DA / 0x1A8DA)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,BL (1000_A8DB / 0x1A8DB)
    AL = BL;
    // CALL 0x1000:a8b1 (1000_A8DD / 0x1A8DD)
    NearCall(cs1, 0xA8E0, spice86_generated_label_call_target_1000_A8B1_01A8B1);
    label_1000_A8E0_1A8E0:
    // STOSB ES:DI (1000_A8E0 / 0x1A8E0)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,0x4f (1000_A8E1 / 0x1A8E1)
    AL = 0x4F;
    // CMP byte ptr [0xea],0x0 (1000_A8E3 / 0x1A8E3)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    // JG 0x1000:a8fa (1000_A8E8 / 0x1A8E8)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_A8FA_1A8FA;
    }
    // CMP byte ptr [0x6],0x80 (1000_A8EA / 0x1A8EA)
    Alu.Sub8(UInt8[DS, 0x6], 0x80);
    // JNZ 0x1000:a8fa (1000_A8EF / 0x1A8EF)
    if(!ZeroFlag) {
      goto label_1000_A8FA_1A8FA;
    }
    // CMP byte ptr [0x4],0x1 (1000_A8F1 / 0x1A8F1)
    Alu.Sub8(UInt8[DS, 0x4], 0x1);
    // JZ 0x1000:a8fa (1000_A8F6 / 0x1A8F6)
    if(ZeroFlag) {
      goto label_1000_A8FA_1A8FA;
    }
    // MOV AL,0x49 (1000_A8F8 / 0x1A8F8)
    AL = 0x49;
    label_1000_A8FA_1A8FA:
    // STOSB ES:DI (1000_A8FA / 0x1A8FA)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,0x20 (1000_A8FB / 0x1A8FB)
    AL = 0x20;
    // SHR BH,CL (1000_A8FD / 0x1A8FD)
    // BH >>= CL;
    BH = Alu.Shr8(BH, CL);
    // OR BH,byte ptr [0x47e0] (1000_A8FF / 0x1A8FF)
    // BH |= UInt8[DS, 0x47E0];
    BH = Alu.Or8(BH, UInt8[DS, 0x47E0]);
    // JZ 0x1000:a909 (1000_A903 / 0x1A903)
    if(ZeroFlag) {
      goto label_1000_A909_1A909;
    }
    // MOV AL,BH (1000_A905 / 0x1A905)
    AL = BH;
    // ADD AL,0x41 (1000_A907 / 0x1A907)
    // AL += 0x41;
    AL = Alu.Add8(AL, 0x41);
    label_1000_A909_1A909:
    // STOSB ES:DI (1000_A909 / 0x1A909)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_1000_A90A_1A90A:
    // RET  (1000_A90A / 0x1A90A)
    return NearRet();
  }
  
  public Action open_res_file_ida_1000_A90B_1A90B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A90B_1A90B:
    // MOV DX,0x37da (1000_A90B / 0x1A90B)
    DX = 0x37DA;
    // XOR AX,AX (1000_A90E / 0x1A90E)
    AX = 0;
    // MOV [0x3811],AX (1000_A910 / 0x1A910)
    UInt16[DS, 0x3811] = AX;
    // MOV [0x3817],AX (1000_A913 / 0x1A913)
    UInt16[DS, 0x3817] = AX;
    // MOV [0x381f],AX (1000_A916 / 0x1A916)
    UInt16[DS, 0x381F] = AX;
    // MOV [0x3823],AL (1000_A919 / 0x1A919)
    UInt8[DS, 0x3823] = AL;
    // CALL 0x1000:f1fb (1000_A91C / 0x1A91C)
    NearCall(cs1, 0xA91F, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    // JC 0x1000:a90a (1000_A91F / 0x1A91F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A90A / 0x1A90A)
      return NearRet();
    }
    // MOV word ptr [0x3821],BX (1000_A921 / 0x1A921)
    UInt16[DS, 0x3821] = BX;
    // SUB CX,0x1 (1000_A925 / 0x1A925)
    // CX -= 0x1;
    CX = Alu.Sub16(CX, 0x1);
    // SBB BP,0x0 (1000_A928 / 0x1A928)
    BP = Alu.Sbb16(BP, 0x0);
    // MOV word ptr [0xdbc4],CX (1000_A92B / 0x1A92B)
    UInt16[DS, 0xDBC4] = CX;
    // MOV word ptr [0xdbc6],BP (1000_A92F / 0x1A92F)
    UInt16[DS, 0xDBC6] = BP;
    // MOV [0xdbc0],AX (1000_A933 / 0x1A933)
    UInt16[DS, 0xDBC0] = AX;
    // MOV word ptr [0xdbc2],DX (1000_A936 / 0x1A936)
    UInt16[DS, 0xDBC2] = DX;
    // MOV SI,0x3811 (1000_A93A / 0x1A93A)
    SI = 0x3811;
    // LES DX,[SI] (1000_A93D / 0x1A93D)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DX = UInt16[DS, SI];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(read_audio_file_ida_1000_A93F_1A93F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action read_audio_file_ida_1000_A93F_1A93F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A93F_1A93F:
    // PUSH DX (1000_A93F / 0x1A93F)
    Stack.Push(DX);
    // MOV DX,word ptr [0xdbc0] (1000_A940 / 0x1A940)
    DX = UInt16[DS, 0xDBC0];
    // MOV CX,word ptr [0xdbc2] (1000_A944 / 0x1A944)
    CX = UInt16[DS, 0xDBC2];
    // MOV AX,0x4200 (1000_A948 / 0x1A948)
    AX = 0x4200;
    // INT 0x21 (1000_A94B / 0x1A94B)
    Interrupt(0x21);
    // POP DX (1000_A94D / 0x1A94D)
    DX = Stack.Pop();
    // PUSH SI (1000_A94E / 0x1A94E)
    Stack.Push(SI);
    // PUSH DS (1000_A94F / 0x1A94F)
    Stack.Push(DS);
    // MOV CX,0x2000 (1000_A950 / 0x1A950)
    CX = 0x2000;
    // MOV AX,[0xdbc4] (1000_A953 / 0x1A953)
    AX = UInt16[DS, 0xDBC4];
    // SUB word ptr [0xdbc4],CX (1000_A956 / 0x1A956)
    // UInt16[DS, 0xDBC4] -= CX;
    UInt16[DS, 0xDBC4] = Alu.Sub16(UInt16[DS, 0xDBC4], CX);
    // SBB word ptr [0xdbc6],0x0 (1000_A95A / 0x1A95A)
    UInt16[DS, 0xDBC6] = Alu.Sbb16(UInt16[DS, 0xDBC6], 0x0);
    // JNC 0x1000:a964 (1000_A95F / 0x1A95F)
    if(!CarryFlag) {
      goto label_1000_A964_1A964;
    }
    // MOV CX,AX (1000_A961 / 0x1A961)
    CX = AX;
    // INC CX (1000_A963 / 0x1A963)
    CX = Alu.Inc16(CX);
    label_1000_A964_1A964:
    // PUSH ES (1000_A964 / 0x1A964)
    Stack.Push(ES);
    // POP DS (1000_A965 / 0x1A965)
    DS = Stack.Pop();
    // MOV AH,0x3f (1000_A966 / 0x1A966)
    AH = 0x3F;
    // INT 0x21 (1000_A968 / 0x1A968)
    Interrupt(0x21);
    // POP DS (1000_A96A / 0x1A96A)
    DS = Stack.Pop();
    // POP SI (1000_A96B / 0x1A96B)
    SI = Stack.Pop();
    // MOV word ptr [SI + 0x4],AX (1000_A96C / 0x1A96C)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    // JC 0x1000:a9b8 (1000_A96F / 0x1A96F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A9B8 / 0x1A9B8)
      return NearRet();
    }
    // ADD word ptr [0xdbc0],AX (1000_A971 / 0x1A971)
    // UInt16[DS, 0xDBC0] += AX;
    UInt16[DS, 0xDBC0] = Alu.Add16(UInt16[DS, 0xDBC0], AX);
    // ADC word ptr [0xdbc2],0x0 (1000_A975 / 0x1A975)
    UInt16[DS, 0xDBC2] = Alu.Adc16(UInt16[DS, 0xDBC2], 0x0);
    // MOV byte ptr [0x376a],0xff (1000_A97A / 0x1A97A)
    UInt8[DS, 0x376A] = 0xFF;
    // MOV byte ptr [SI + 0x6],0x1 (1000_A97F / 0x1A97F)
    UInt8[DS, (ushort)(SI + 0x6)] = 0x1;
    // MOV BL,byte ptr [0x3823] (1000_A983 / 0x1A983)
    BL = UInt8[DS, 0x3823];
    // CMP BL,0x3f (1000_A987 / 0x1A987)
    Alu.Sub8(BL, 0x3F);
    // JNC 0x1000:a992 (1000_A98A / 0x1A98A)
    if(!CarryFlag) {
      goto label_1000_A992_1A992;
    }
    // INC byte ptr [0x3823] (1000_A98C / 0x1A98C)
    UInt8[DS, 0x3823] = Alu.Inc8(UInt8[DS, 0x3823]);
    // INC BL (1000_A990 / 0x1A990)
    BL = Alu.Inc8(BL);
    label_1000_A992_1A992:
    // MOV byte ptr [SI + 0x7],BL (1000_A992 / 0x1A992)
    UInt8[DS, (ushort)(SI + 0x7)] = BL;
    // CMP word ptr [0xdbc6],0x0 (1000_A995 / 0x1A995)
    Alu.Sub16(UInt16[DS, 0xDBC6], 0x0);
    // CLC  (1000_A99A / 0x1A99A)
    CarryFlag = false;
    // JNS 0x1000:a9b8 (1000_A99B / 0x1A99B)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_A9B8 / 0x1A9B8)
      return NearRet();
    }
    // OR byte ptr [SI + 0x7],0x80 (1000_A99D / 0x1A99D)
    UInt8[DS, (ushort)(SI + 0x7)] |= 0x80;
    
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_A9A1_01A9A1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_A9A1_01A9A1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A9A1_1A9A1:
    // XOR BX,BX (1000_A9A1 / 0x1A9A1)
    BX = 0;
    // XCHG word ptr [0x3821],BX (1000_A9A3 / 0x1A9A3)
    ushort tmp_1000_A9A3 = UInt16[DS, 0x3821];
    UInt16[DS, 0x3821] = BX;
    BX = tmp_1000_A9A3;
    // OR BX,BX (1000_A9A7 / 0x1A9A7)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:a9b7 (1000_A9A9 / 0x1A9A9)
    if(ZeroFlag) {
      goto label_1000_A9B7_1A9B7;
    }
    // CMP BX,word ptr [0xdbba] (1000_A9AB / 0x1A9AB)
    Alu.Sub16(BX, UInt16[DS, 0xDBBA]);
    // JZ 0x1000:a9b7 (1000_A9AF / 0x1A9AF)
    if(ZeroFlag) {
      goto label_1000_A9B7_1A9B7;
    }
    // PUSH AX (1000_A9B1 / 0x1A9B1)
    Stack.Push(AX);
    // MOV AH,0x3e (1000_A9B2 / 0x1A9B2)
    AH = 0x3E;
    // INT 0x21 (1000_A9B4 / 0x1A9B4)
    Interrupt(0x21);
    // POP AX (1000_A9B6 / 0x1A9B6)
    AX = Stack.Pop();
    label_1000_A9B7_1A9B7:
    // CLC  (1000_A9B7 / 0x1A9B7)
    CarryFlag = false;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_A9B8_01A9B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_A9B8_01A9B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A9B8_1A9B8:
    // RET  (1000_A9B8 / 0x1A9B8)
    return NearRet();
  }
  
  public Action split_1000_A9B9_01A9B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A9B9_1A9B9:
    // CALL 0x1000:aba3 (1000_A9B9 / 0x1A9B9)
    NearCall(cs1, 0xA9BC, check_res_file_open_ida_1000_ABA3_1ABA3);
    // JZ 0x1000:a9e6 (1000_A9BC / 0x1A9BC)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A9E6 / 0x1A9E6)
      return NearRet();
    }
    // MOV SI,0x3811 (1000_A9BE / 0x1A9BE)
    SI = 0x3811;
    // CMP byte ptr [0x3817],0x0 (1000_A9C1 / 0x1A9C1)
    Alu.Sub8(UInt8[DS, 0x3817], 0x0);
    // JZ 0x1000:a9d2 (1000_A9C6 / 0x1A9C6)
    if(ZeroFlag) {
      goto label_1000_A9D2_1A9D2;
    }
    // CMP byte ptr [0x381f],0x0 (1000_A9C8 / 0x1A9C8)
    Alu.Sub8(UInt8[DS, 0x381F], 0x0);
    // JNZ 0x1000:a9e6 (1000_A9CD / 0x1A9CD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_A9E6 / 0x1A9E6)
      return NearRet();
    }
    // MOV SI,0x3819 (1000_A9CF / 0x1A9CF)
    SI = 0x3819;
    label_1000_A9D2_1A9D2:
    // MOV BX,word ptr [0x3821] (1000_A9D2 / 0x1A9D2)
    BX = UInt16[DS, 0x3821];
    // LES DX,[SI] (1000_A9D6 / 0x1A9D6)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DX = UInt16[DS, SI];
    // ADD DX,0x6 (1000_A9D8 / 0x1A9D8)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    // PUSH SI (1000_A9DB / 0x1A9DB)
    Stack.Push(SI);
    // CALL 0x1000:a93f (1000_A9DC / 0x1A9DC)
    NearCall(cs1, 0xA9DF, read_audio_file_ida_1000_A93F_1A93F);
    // POP SI (1000_A9DF / 0x1A9DF)
    SI = Stack.Pop();
    // JC 0x1000:a9e6 (1000_A9E0 / 0x1A9E0)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_A9E6 / 0x1A9E6)
      return NearRet();
    }
    // CALLF [0x39a1] (1000_A9E2 / 0x1A9E2)
    // Indirect call to [0x39a1], generating possible targets from emulator records
    uint targetAddress_1000_A9E2 = (uint)(UInt16[DS, 0x39A3] * 0x10 + UInt16[DS, 0x39A1] - cs1 * 0x10);
    switch(targetAddress_1000_A9E2) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_A9E2));
        break;
    }
    label_1000_A9E6_1A9E6:
    // RET  (1000_A9E6 / 0x1A9E6)
    return NearRet();
  }
  
  public Action pcm_test_audio_done_ida_1000_A9E7_1A9E7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_A9E7_1A9E7:
    // CMP byte ptr [0x3817],0x3 (1000_A9E7 / 0x1A9E7)
    Alu.Sub8(UInt8[DS, 0x3817], 0x3);
    // JZ 0x1000:a9f3 (1000_A9EC / 0x1A9EC)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_A9F3 / 0x1A9F3)
      return NearRet();
    }
    // CMP byte ptr [0x381f],0x3 (1000_A9EE / 0x1A9EE)
    Alu.Sub8(UInt8[DS, 0x381F], 0x3);
    label_1000_A9F3_1A9F3:
    // RET  (1000_A9F3 / 0x1A9F3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AA0F_01AA0F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xAA0E: break; // Instructions before entry targeted by 0x1AA13
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_AA0E_1AA0E:
    // RET  (1000_AA0E / 0x1AA0E)
    return NearRet();
    entry:
    label_1000_AA0F_1AA0F:
    // MOV AX,[0xdc1c] (1000_AA0F / 0x1AA0F)
    AX = UInt16[DS, 0xDC1C];
    // INC AX (1000_AA12 / 0x1AA12)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:aa0e (1000_AA13 / 0x1AA13)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AA0E / 0x1AA0E)
      return NearRet();
    }
    // MOV byte ptr [0x376a],0xff (1000_AA15 / 0x1AA15)
    UInt8[DS, 0x376A] = 0xFF;
    // CALL 0x1000:ac14 (1000_AA1A / 0x1AA1A)
    NearCall(cs1, 0xAA1D, spice86_generated_label_call_target_1000_AC14_01AC14);
    // XOR AX,AX (1000_AA1D / 0x1AA1D)
    AX = 0;
    // MOV [0x3811],AX (1000_AA1F / 0x1AA1F)
    UInt16[DS, 0x3811] = AX;
    // MOV [0x3817],AX (1000_AA22 / 0x1AA22)
    UInt16[DS, 0x3817] = AX;
    // MOV [0x381f],AX (1000_AA25 / 0x1AA25)
    UInt16[DS, 0x381F] = AX;
    // MOV SI,0x3811 (1000_AA28 / 0x1AA28)
    SI = 0x3811;
    // LES DI,[SI] (1000_AA2B / 0x1AA2B)
    ES = UInt16[DS, (ushort)(SI + 2)];
    DI = UInt16[DS, SI];
    // CALL 0x1000:aa70 (1000_AA2D / 0x1AA2D)
    NearCall(cs1, 0xAA30, transfer_sd_block_qq_ida_1000_AA70_1AA70);
    // SUB word ptr [0x3815],0x20 (1000_AA30 / 0x1AA30)
    // UInt16[DS, 0x3815] -= 0x20;
    UInt16[DS, 0x3815] = Alu.Sub16(UInt16[DS, 0x3815], 0x20);
    // MOV CX,word ptr [0x3815] (1000_AA35 / 0x1AA35)
    CX = UInt16[DS, 0x3815];
    // MOV word ptr [0x381d],CX (1000_AA39 / 0x1AA39)
    UInt16[DS, 0x381D] = CX;
    // ADD CX,0x6 (1000_AA3D / 0x1AA3D)
    // CX += 0x6;
    CX = Alu.Add16(CX, 0x6);
    // MOV SI,0x1a (1000_AA40 / 0x1AA40)
    SI = 0x1A;
    // XOR DI,DI (1000_AA43 / 0x1AA43)
    DI = 0;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,ES:SI (1000_AA45 / 0x1AA45)
      UInt8[ES, DI] = UInt8[ES, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // LES DI,[0x3819] (1000_AA48 / 0x1AA48)
    ES = UInt16[DS, 0x381B];
    DI = UInt16[DS, 0x3819];
    // MOV CX,word ptr [0x3815] (1000_AA4C / 0x1AA4C)
    CX = UInt16[DS, 0x3815];
    // PUSH DS (1000_AA50 / 0x1AA50)
    Stack.Push(DS);
    // LDS SI,[0x3811] (1000_AA51 / 0x1AA51)
    DS = UInt16[DS, 0x3813];
    SI = UInt16[DS, 0x3811];
    // MOVSW ES:DI,SI (1000_AA55 / 0x1AA55)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_AA56 / 0x1AA56)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_AA57 / 0x1AA57)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOV AL,0x80 (1000_AA58 / 0x1AA58)
    AL = 0x80;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_AA5A / 0x1AA5A)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // POP DS (1000_AA5C / 0x1AA5C)
    DS = Stack.Pop();
    // MOV SI,0x3819 (1000_AA5D / 0x1AA5D)
    SI = 0x3819;
    // MOV word ptr [0x3824],SI (1000_AA60 / 0x1AA60)
    UInt16[DS, 0x3824] = SI;
    // CALLF [0x3991] (1000_AA64 / 0x1AA64)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_AA64 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_AA64) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AA64));
        break;
    }
    // MOV SI,0x3811 (1000_AA68 / 0x1AA68)
    SI = 0x3811;
    // CALLF [0x39a1] (1000_AA6B / 0x1AA6B)
    // Indirect call to [0x39a1], generating possible targets from emulator records
    uint targetAddress_1000_AA6B = (uint)(UInt16[DS, 0x39A3] * 0x10 + UInt16[DS, 0x39A1] - cs1 * 0x10);
    switch(targetAddress_1000_AA6B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AA6B));
        break;
    }
    // RET  (1000_AA6F / 0x1AA6F)
    return NearRet();
  }
  
  public Action transfer_sd_block_qq_ida_1000_AA70_1AA70(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AA70_1AA70:
    // PUSH SI (1000_AA70 / 0x1AA70)
    Stack.Push(SI);
    // PUSH DS (1000_AA71 / 0x1AA71)
    Stack.Push(DS);
    // MOV SI,word ptr [0xdc1c] (1000_AA72 / 0x1AA72)
    SI = UInt16[DS, 0xDC1C];
    // MOV DS,word ptr [0xdbde] (1000_AA76 / 0x1AA76)
    DS = UInt16[DS, 0xDBDE];
    // LODSW SI (1000_AA7A / 0x1AA7A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB AX,0x4 (1000_AA7B / 0x1AA7B)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    // MOV CX,AX (1000_AA7E / 0x1AA7E)
    CX = AX;
    // SHR CX,0x1 (1000_AA80 / 0x1AA80)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_AA82 / 0x1AA82)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADC CL,CL (1000_AA84 / 0x1AA84)
    CL = Alu.Adc8(CL, CL);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_AA86 / 0x1AA86)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP DS (1000_AA88 / 0x1AA88)
    DS = Stack.Pop();
    // POP SI (1000_AA89 / 0x1AA89)
    SI = Stack.Pop();
    // MOV word ptr [SI + 0x4],AX (1000_AA8A / 0x1AA8A)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    // MOV byte ptr [SI + 0x6],0x1 (1000_AA8D / 0x1AA8D)
    UInt8[DS, (ushort)(SI + 0x6)] = 0x1;
    // MOV byte ptr [SI + 0x7],0x41 (1000_AA91 / 0x1AA91)
    UInt8[DS, (ushort)(SI + 0x7)] = 0x41;
    // RET  (1000_AA95 / 0x1AA95)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AA96_01AA96(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AA96_1AA96:
    // XOR AX,AX (1000_AA96 / 0x1AA96)
    AX = 0;
    // CMP byte ptr [0x4774],AH (1000_AA98 / 0x1AA98)
    Alu.Sub8(UInt8[DS, 0x4774], AH);
    // JZ 0x1000:aaa7 (1000_AA9C / 0x1AA9C)
    if(ZeroFlag) {
      goto label_1000_AAA7_1AAA7;
    }
    // CMP byte ptr [0x2a],0x48 (1000_AA9E / 0x1AA9E)
    Alu.Sub8(UInt8[DS, 0x2A], 0x48);
    // JNZ 0x1000:ab14 (1000_AAA3 / 0x1AAA3)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // JMP 0x1000:ab12 (1000_AAA5 / 0x1AAA5)
    goto label_1000_AB12_1AB12;
    label_1000_AAA7_1AAA7:
    // MOV AL,0xd (1000_AAA7 / 0x1AAA7)
    AL = 0xD;
    // CMP byte ptr [0x46d9],AH (1000_AAA9 / 0x1AAA9)
    Alu.Sub8(UInt8[DS, 0x46D9], AH);
    // JNZ 0x1000:ab14 (1000_AAAD / 0x1AAAD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // MOV AL,0x1 (1000_AAAF / 0x1AAAF)
    AL = 0x1;
    // CMP byte ptr [0xdd03],AH (1000_AAB1 / 0x1AAB1)
    Alu.Sub8(UInt8[DS, 0xDD03], AH);
    // JNZ 0x1000:ab14 (1000_AAB5 / 0x1AAB5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // INC AX (1000_AAB7 / 0x1AAB7)
    AX = Alu.Inc16(AX);
    // CMP byte ptr [0xfb],AH (1000_AAB8 / 0x1AAB8)
    Alu.Sub8(UInt8[DS, 0xFB], AH);
    // JS 0x1000:ab14 (1000_AABC / 0x1AABC)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // INC AX (1000_AABE / 0x1AABE)
    AX = Alu.Inc16(AX);
    // CMP byte ptr [0xc6],AH (1000_AABF / 0x1AABF)
    Alu.Sub8(UInt8[DS, 0xC6], AH);
    // JNZ 0x1000:ab14 (1000_AAC3 / 0x1AAC3)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // INC AX (1000_AAC5 / 0x1AAC5)
    AX = Alu.Inc16(AX);
    // CMP byte ptr [0xea],AH (1000_AAC6 / 0x1AAC6)
    Alu.Sub8(UInt8[DS, 0xEA], AH);
    // JG 0x1000:ab14 (1000_AACA / 0x1AACA)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // INC AX (1000_AACC / 0x1AACC)
    AX = Alu.Inc16(AX);
    // MOV DX,word ptr [0x4] (1000_AACD / 0x1AACD)
    DX = UInt16[DS, 0x4];
    // MOV BX,word ptr [0x6] (1000_AAD1 / 0x1AAD1)
    BX = UInt16[DS, 0x6];
    // CMP BL,0x80 (1000_AAD5 / 0x1AAD5)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:aadf (1000_AAD8 / 0x1AAD8)
    if(!ZeroFlag) {
      goto label_1000_AADF_1AADF;
    }
    // CMP DL,0x1 (1000_AADA / 0x1AADA)
    Alu.Sub8(DL, 0x1);
    // JNZ 0x1000:aaef (1000_AADD / 0x1AADD)
    if(!ZeroFlag) {
      goto label_1000_AAEF_1AAEF;
    }
    label_1000_AADF_1AADF:
    // MOV BL,byte ptr [0x11c9] (1000_AADF / 0x1AADF)
    BL = UInt8[DS, 0x11C9];
    // AND BL,0x3 (1000_AAE3 / 0x1AAE3)
    // BL &= 0x3;
    BL = Alu.And8(BL, 0x3);
    // JZ 0x1000:ab14 (1000_AAE6 / 0x1AAE6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // INC AX (1000_AAE8 / 0x1AAE8)
    AX = Alu.Inc16(AX);
    // DEC BL (1000_AAE9 / 0x1AAE9)
    BL = Alu.Dec8(BL);
    // JZ 0x1000:ab14 (1000_AAEB / 0x1AAEB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // INC AX (1000_AAED / 0x1AAED)
    AX = Alu.Inc16(AX);
    // RET  (1000_AAEE / 0x1AAEE)
    return NearRet();
    label_1000_AAEF_1AAEF:
    // CMP DH,0x20 (1000_AAEF / 0x1AAEF)
    Alu.Sub8(DH, 0x20);
    // JNC 0x1000:ab08 (1000_AAF2 / 0x1AAF2)
    if(!CarryFlag) {
      goto label_1000_AB08_1AB08;
    }
    // MOV AL,0x9 (1000_AAF4 / 0x1AAF4)
    AL = 0x9;
    // CMP DH,0x7 (1000_AAF6 / 0x1AAF6)
    Alu.Sub8(DH, 0x7);
    // SBB AL,0x0 (1000_AAF9 / 0x1AAF9)
    AL = Alu.Sbb8(AL, 0x0);
    // CMP byte ptr [0x2a],0x48 (1000_AAFB / 0x1AAFB)
    Alu.Sub8(UInt8[DS, 0x2A], 0x48);
    // JC 0x1000:ab14 (1000_AB00 / 0x1AB00)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // SHR BL,0x1 (1000_AB02 / 0x1AB02)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    // JC 0x1000:ab14 (1000_AB04 / 0x1AB04)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // JMP 0x1000:ab12 (1000_AB06 / 0x1AB06)
    goto label_1000_AB12_1AB12;
    label_1000_AB08_1AB08:
    // MOV AL,0xc (1000_AB08 / 0x1AB08)
    AL = 0xC;
    // JNZ 0x1000:ab14 (1000_AB0A / 0x1AB0A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    // DEC AX (1000_AB0C / 0x1AB0C)
    AX = Alu.Dec16(AX);
    // CMP DL,0x3 (1000_AB0D / 0x1AB0D)
    Alu.Sub8(DL, 0x3);
    // JNZ 0x1000:ab14 (1000_AB10 / 0x1AB10)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB14 / 0x1AB14)
      return NearRet();
    }
    label_1000_AB12_1AB12:
    // MOV AL,0xa (1000_AB12 / 0x1AB12)
    AL = 0xA;
    label_1000_AB14_1AB14:
    // RET  (1000_AB14 / 0x1AB14)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AB15_01AB15(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xAB44: goto label_1000_AB44_1AB44;break; // Target of external jump from 0x1AB67, 0x1AB48, 0x1AB1D, 0x1ABAC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_AB15_1AB15:
    // CALL 0x1000:abcc (1000_AB15 / 0x1AB15)
    NearCall(cs1, 0xAB18, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_AB18_1AB18:
    // JNZ 0x1000:ab44 (1000_AB18 / 0x1AB18)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    // CALL 0x1000:ae2f (1000_AB1A / 0x1AB1A)
    NearCall(cs1, 0xAB1D, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_AB1D_1AB1D:
    // JZ 0x1000:ab44 (1000_AB1D / 0x1AB1D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    // PUSH ES (1000_AB1F / 0x1AB1F)
    Stack.Push(ES);
    // CALL 0x1000:e270 (1000_AB20 / 0x1AB20)
    NearCall(cs1, 0xAB23, spice86_generated_label_call_target_1000_E270_01E270);
    // CMP AL,byte ptr [0x376a] (1000_AB23 / 0x1AB23)
    Alu.Sub8(AL, UInt8[DS, 0x376A]);
    // JZ 0x1000:ab35 (1000_AB27 / 0x1AB27)
    if(ZeroFlag) {
      goto label_1000_AB35_1AB35;
    }
    // CALL 0x1000:ac14 (1000_AB29 / 0x1AB29)
    NearCall(cs1, 0xAB2C, spice86_generated_label_call_target_1000_AC14_01AC14);
    // OR AL,AL (1000_AB2C / 0x1AB2C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:ab40 (1000_AB2E / 0x1AB2E)
    if(ZeroFlag) {
      goto label_1000_AB40_1AB40;
    }
    // CALL 0x1000:abe9 (1000_AB30 / 0x1AB30)
    NearCall(cs1, 0xAB33, open_voc_resource_ida_1000_ABE9_1ABE9);
    // JMP 0x1000:ab39 (1000_AB33 / 0x1AB33)
    goto label_1000_AB39_1AB39;
    label_1000_AB35_1AB35:
    // LES DI,[0x3811] (1000_AB35 / 0x1AB35)
    ES = UInt16[DS, 0x3813];
    DI = UInt16[DS, 0x3811];
    label_1000_AB39_1AB39:
    // MOV SI,0x3811 (1000_AB39 / 0x1AB39)
    SI = 0x3811;
    // CALLF [0x3991] (1000_AB3C / 0x1AB3C)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_AB3C = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_AB3C) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AB3C));
        break;
    }
    label_1000_AB40_1AB40:
    // CALL 0x1000:e283 (1000_AB40 / 0x1AB40)
    NearCall(cs1, 0xAB43, spice86_generated_label_call_target_1000_E283_01E283);
    // POP ES (1000_AB43 / 0x1AB43)
    ES = Stack.Pop();
    label_1000_AB44_1AB44:
    // RET  (1000_AB44 / 0x1AB44)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AB45_01AB45(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AB45_1AB45:
    // CALL 0x1000:ae2f (1000_AB45 / 0x1AB45)
    NearCall(cs1, 0xAB48, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_AB48_1AB48:
    // JZ 0x1000:ab44 (1000_AB48 / 0x1AB48)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    // PUSH AX (1000_AB4A / 0x1AB4A)
    Stack.Push(AX);
    // CALL 0x1000:ade0 (1000_AB4B / 0x1AB4B)
    throw FailAsUntested("Could not find a valid function at address 1000_ADE0 / 0x1ADE0");
    // POP AX (1000_AB4E / 0x1AB4E)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AB4F_01AB4F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_AB4F_01AB4F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AB4F_1AB4F:
    // MOV byte ptr [0x47e0],0x0 (1000_AB4F / 0x1AB4F)
    UInt8[DS, 0x47E0] = 0x0;
    // MOV BX,0x19 (1000_AB54 / 0x1AB54)
    BX = 0x19;
    // CALL 0x1000:a8bc (1000_AB57 / 0x1AB57)
    NearCall(cs1, 0xAB5A, spice86_generated_label_call_target_1000_A8BC_01A8BC);
    label_1000_AB5A_1AB5A:
    // MOV byte ptr [0x37e2],0x49 (1000_AB5A / 0x1AB5A)
    UInt8[DS, 0x37E2] = 0x49;
    // CALL 0x1000:abcc (1000_AB5F / 0x1AB5F)
    NearCall(cs1, 0xAB62, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_AB62_1AB62:
    // JNZ 0x1000:ab44 (1000_AB62 / 0x1AB62)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    // CALL 0x1000:ae2f (1000_AB64 / 0x1AB64)
    NearCall(cs1, 0xAB67, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_AB67_1AB67:
    // JZ 0x1000:ab44 (1000_AB67 / 0x1AB67)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    // PUSH ES (1000_AB69 / 0x1AB69)
    Stack.Push(ES);
    // CALL 0x1000:e270 (1000_AB6A / 0x1AB6A)
    NearCall(cs1, 0xAB6D, spice86_generated_label_call_target_1000_E270_01E270);
    // CALL 0x1000:ac14 (1000_AB6D / 0x1AB6D)
    NearCall(cs1, 0xAB70, spice86_generated_label_call_target_1000_AC14_01AC14);
    // CALL 0x1000:a90b (1000_AB70 / 0x1AB70)
    NearCall(cs1, 0xAB73, open_res_file_ida_1000_A90B_1A90B);
    // JC 0x1000:ab8d (1000_AB73 / 0x1AB73)
    if(CarryFlag) {
      goto label_1000_AB8D_1AB8D;
    }
    // ADD word ptr [0x3811],0x1a (1000_AB75 / 0x1AB75)
    // UInt16[DS, 0x3811] += 0x1A;
    UInt16[DS, 0x3811] = Alu.Add16(UInt16[DS, 0x3811], 0x1A);
    // CALL 0x1000:a9b9 (1000_AB7A / 0x1AB7A)
    NearCall(cs1, 0xAB7D, split_1000_A9B9_01A9B9);
    // MOV SI,0xab92 (1000_AB7D / 0x1AB7D)
    SI = 0xAB92;
    // MOV BP,0x1 (1000_AB80 / 0x1AB80)
    BP = 0x1;
    // CALL 0x1000:da25 (1000_AB83 / 0x1AB83)
    NearCall(cs1, 0xAB86, spice86_generated_label_call_target_1000_DA25_01DA25);
    // MOV SI,0x3811 (1000_AB86 / 0x1AB86)
    SI = 0x3811;
    // CALLF [0x3991] (1000_AB89 / 0x1AB89)
    // Indirect call to [0x3991], generating possible targets from emulator records
    uint targetAddress_1000_AB89 = (uint)(UInt16[DS, 0x3993] * 0x10 + UInt16[DS, 0x3991] - cs1 * 0x10);
    switch(targetAddress_1000_AB89) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AB89));
        break;
    }
    label_1000_AB8D_1AB8D:
    // CALL 0x1000:e283 (1000_AB8D / 0x1AB8D)
    NearCall(cs1, 0xAB90, spice86_generated_label_call_target_1000_E283_01E283);
    // POP ES (1000_AB90 / 0x1AB90)
    ES = Stack.Pop();
    // RET  (1000_AB91 / 0x1AB91)
    return NearRet();
  }
  
  public Action check_res_file_open_ida_1000_ABA3_1ABA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ABA3_1ABA3:
    // CMP word ptr [0x3821],0x0 (1000_ABA3 / 0x1ABA3)
    Alu.Sub16(UInt16[DS, 0x3821], 0x0);
    // RET  (1000_ABA8 / 0x1ABA8)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_ABA9_01ABA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ABA9_1ABA9:
    // CALL 0x1000:ae2f (1000_ABA9 / 0x1ABA9)
    NearCall(cs1, 0xABAC, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_ABAC_1ABAC:
    // JZ 0x1000:ab44 (1000_ABAC / 0x1ABAC)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AB44 / 0x1AB44)
      return NearRet();
    }
    // MOV BX,word ptr [0xce7a] (1000_ABAE / 0x1ABAE)
    BX = UInt16[DS, 0xCE7A];
    label_1000_ABB2_1ABB2:
    // PUSH BX (1000_ABB2 / 0x1ABB2)
    Stack.Push(BX);
    // CALL 0x1000:ab92 (1000_ABB3 / 0x1ABB3)
    throw FailAsUntested("Could not find a valid function at address 1000_AB92 / 0x1AB92");
    // CALL 0x1000:aba3 (1000_ABB6 / 0x1ABB6)
    NearCall(cs1, 0xABB9, check_res_file_open_ida_1000_ABA3_1ABA3);
    // POP BX (1000_ABB9 / 0x1ABB9)
    BX = Stack.Pop();
    // JZ 0x1000:abc6 (1000_ABBA / 0x1ABBA)
    if(ZeroFlag) {
      goto label_1000_ABC6_1ABC6;
    }
    // MOV AX,[0xce7a] (1000_ABBC / 0x1ABBC)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,BX (1000_ABBF / 0x1ABBF)
    AX -= BX;
    
    // CMP AX,0x3e8 (1000_ABC1 / 0x1ABC1)
    Alu.Sub16(AX, 0x3E8);
    // JC 0x1000:abb2 (1000_ABC4 / 0x1ABC4)
    if(CarryFlag) {
      goto label_1000_ABB2_1ABB2;
    }
    label_1000_ABC6_1ABC6:
    // MOV byte ptr [0xdc2b],0x0 (1000_ABC6 / 0x1ABC6)
    UInt8[DS, 0xDC2B] = 0x0;
    // RET  (1000_ABCB / 0x1ABCB)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_ABCC_01ABCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ABCC_1ABCC:
    // CMP byte ptr [0xdc2b],0x0 (1000_ABCC / 0x1ABCC)
    Alu.Sub8(UInt8[DS, 0xDC2B], 0x0);
    // RET  (1000_ABD1 / 0x1ABD1)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_ABD5_01ABD5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xABD2: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_ABD2_1ABD2:
    // CALL 0x1000:a7c2 (1000_ABD2 / 0x1ABD2)
    NearCall(cs1, 0xABD5, spice86_generated_label_call_target_1000_A7C2_01A7C2);
    entry:
    label_1000_ABD5_1ABD5:
    // CALL 0x1000:abcc (1000_ABD5 / 0x1ABD5)
    NearCall(cs1, 0xABD8, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_ABD8_1ABD8:
    // JNZ 0x1000:abd2 (1000_ABD8 / 0x1ABD8)
    if(!ZeroFlag) {
      goto label_1000_ABD2_1ABD2;
    }
    // RET  (1000_ABDA / 0x1ABDA)
    return NearRet();
  }
  
  public Action open_voc_resource_ida_1000_ABE9_1ABE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ABE9_1ABE9:
    // MOV word ptr [0x3811],0x0 (1000_ABE9 / 0x1ABE9)
    UInt16[DS, 0x3811] = 0x0;
    // LES DI,[0x3811] (1000_ABEF / 0x1ABEF)
    ES = UInt16[DS, 0x3813];
    DI = UInt16[DS, 0x3811];
    // ADD word ptr [0x3811],0x1a (1000_ABF3 / 0x1ABF3)
    UInt16[DS, 0x3811] += 0x1A;
    
    // XOR AH,AH (1000_ABF8 / 0x1ABF8)
    AH = 0;
    // MOV SI,AX (1000_ABFA / 0x1ABFA)
    SI = AX;
    // ADD SI,0xae (1000_ABFC / 0x1ABFC)
    // SI += 0xAE;
    SI = Alu.Add16(SI, 0xAE);
    // MOV [0x376a],AL (1000_AC00 / 0x1AC00)
    UInt8[DS, 0x376A] = AL;
    // CALL 0x1000:f0b9 (1000_AC03 / 0x1AC03)
    NearCall(cs1, 0xAC06, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // SUB CX,0x1a (1000_AC06 / 0x1AC06)
    // CX -= 0x1A;
    CX = Alu.Sub16(CX, 0x1A);
    // MOV word ptr [0x3815],CX (1000_AC09 / 0x1AC09)
    UInt16[DS, 0x3815] = CX;
    // MOV word ptr [0x3817],0x8101 (1000_AC0D / 0x1AC0D)
    UInt16[DS, 0x3817] = 0x8101;
    // RET  (1000_AC13 / 0x1AC13)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AC14_01AC14(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AC14_1AC14:
    // PUSH AX (1000_AC14 / 0x1AC14)
    Stack.Push(AX);
    // PUSH BX (1000_AC15 / 0x1AC15)
    Stack.Push(BX);
    // PUSH CX (1000_AC16 / 0x1AC16)
    Stack.Push(CX);
    // PUSH SI (1000_AC17 / 0x1AC17)
    Stack.Push(SI);
    // PUSH DI (1000_AC18 / 0x1AC18)
    Stack.Push(DI);
    // PUSH BP (1000_AC19 / 0x1AC19)
    Stack.Push(BP);
    // PUSH ES (1000_AC1A / 0x1AC1A)
    Stack.Push(ES);
    // MOV SI,0xab92 (1000_AC1B / 0x1AC1B)
    SI = 0xAB92;
    // CALL 0x1000:da5f (1000_AC1E / 0x1AC1E)
    NearCall(cs1, 0xAC21, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_AC21_1AC21:
    // CALL 0x1000:a9a1 (1000_AC21 / 0x1AC21)
    NearCall(cs1, 0xAC24, spice86_generated_label_call_target_1000_A9A1_01A9A1);
    label_1000_AC24_1AC24:
    // CALLF [0x3995] (1000_AC24 / 0x1AC24)
    // Indirect call to [0x3995], generating possible targets from emulator records
    uint targetAddress_1000_AC24 = (uint)(UInt16[DS, 0x3997] * 0x10 + UInt16[DS, 0x3995] - cs1 * 0x10);
    switch(targetAddress_1000_AC24) {
      case 0x46459 : FarCall(cs1, 0xAC28, spice86_generated_label_call_target_5635_0109_056459); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AC24));
        break;
    }
    label_1000_AC28_1AC28:
    // POP ES (1000_AC28 / 0x1AC28)
    ES = Stack.Pop();
    // POP BP (1000_AC29 / 0x1AC29)
    BP = Stack.Pop();
    // POP DI (1000_AC2A / 0x1AC2A)
    DI = Stack.Pop();
    // POP SI (1000_AC2B / 0x1AC2B)
    SI = Stack.Pop();
    // POP CX (1000_AC2C / 0x1AC2C)
    CX = Stack.Pop();
    // POP BX (1000_AC2D / 0x1AC2D)
    BX = Stack.Pop();
    // POP AX (1000_AC2E / 0x1AC2E)
    AX = Stack.Pop();
    // RET  (1000_AC2F / 0x1AC2F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AC30_01AC30(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AC30_1AC30:
    // CALLF [0x3999] (1000_AC30 / 0x1AC30)
    // Indirect call to [0x3999], generating possible targets from emulator records
    uint targetAddress_1000_AC30 = (uint)(UInt16[DS, 0x399B] * 0x10 + UInt16[DS, 0x3999] - cs1 * 0x10);
    switch(targetAddress_1000_AC30) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AC30));
        break;
    }
    // RET  (1000_AC34 / 0x1AC34)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AC3A_01AC3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AC3A_1AC3A:
    // MOV BP,0x201a (1000_AC3A / 0x1AC3A)
    BP = 0x201A;
    // OR byte ptr [BP + 0x3],0x40 (1000_AC3D / 0x1AC3D)
    // UInt8[SS, (ushort)(BP + 0x3)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0x3)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0x3)], 0x40);
    // OR byte ptr [BP + 0x7],0x40 (1000_AC41 / 0x1AC41)
    // UInt8[SS, (ushort)(BP + 0x7)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0x7)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0x7)], 0x40);
    // OR byte ptr [BP + 0xb],0x40 (1000_AC45 / 0x1AC45)
    // UInt8[SS, (ushort)(BP + 0xB)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xB)], 0x40);
    // MOV CL,0xff (1000_AC49 / 0x1AC49)
    CL = 0xFF;
    // CALL 0x1000:ae28 (1000_AC4B / 0x1AC4B)
    NearCall(cs1, 0xAC4E, spice86_generated_label_call_target_1000_AE28_01AE28);
    label_1000_AC4E_1AC4E:
    // JZ 0x1000:ac6d (1000_AC4E / 0x1AC4E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AC6D / 0x1AC6D)
      return NearRet();
    }
    // AND byte ptr [BP + 0x3],0xbf (1000_AC50 / 0x1AC50)
    UInt8[SS, (ushort)(BP + 0x3)] &= 0xBF;
    
    // AND byte ptr [BP + 0x7],0xbf (1000_AC54 / 0x1AC54)
    UInt8[SS, (ushort)(BP + 0x7)] &= 0xBF;
    
    // AND byte ptr [BP + 0xb],0xbf (1000_AC58 / 0x1AC58)
    UInt8[SS, (ushort)(BP + 0xB)] &= 0xBF;
    
    // XOR CX,CX (1000_AC5C / 0x1AC5C)
    CX = 0;
    // TEST byte ptr [0x2943],0x10 (1000_AC5E / 0x1AC5E)
    Alu.And8(UInt8[DS, 0x2943], 0x10);
    // JNZ 0x1000:ac6d (1000_AC63 / 0x1AC63)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AC6D / 0x1AC6D)
      return NearRet();
    }
    // MOV CL,byte ptr [0x3810] (1000_AC65 / 0x1AC65)
    CL = UInt8[DS, 0x3810];
    // AND CL,0x1 (1000_AC69 / 0x1AC69)
    CL &= 0x1;
    
    // INC CX (1000_AC6C / 0x1AC6C)
    CX = Alu.Inc16(CX);
    label_1000_AC6D_1AC6D:
    // RET  (1000_AC6D / 0x1AC6D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_ACE6_01ACE6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ACE6_1ACE6:
    // CALL 0x1000:abcc (1000_ACE6 / 0x1ACE6)
    NearCall(cs1, 0xACE9, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_ACE9_1ACE9:
    // JNZ 0x1000:ad36 (1000_ACE9 / 0x1ACE9)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // TEST byte ptr [0x3810],0x1 (1000_ACEB / 0x1ACEB)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    // JZ 0x1000:ad37 (1000_ACF0 / 0x1ACF0)
    if(ZeroFlag) {
      goto label_1000_AD37_1AD37;
    }
    // CMP byte ptr [0x227d],0x0 (1000_ACF2 / 0x1ACF2)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:ad36 (1000_ACF7 / 0x1ACF7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // CMP byte ptr [0xdbcd],0x0 (1000_ACF9 / 0x1ACF9)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JS 0x1000:ad36 (1000_ACFE / 0x1ACFE)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // MOV AX,[0xdbd2] (1000_AD00 / 0x1AD00)
    AX = UInt16[DS, 0xDBD2];
    // OR AX,AX (1000_AD03 / 0x1AD03)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNZ 0x1000:ad0d (1000_AD05 / 0x1AD05)
    if(!ZeroFlag) {
      goto label_1000_AD0D_1AD0D;
    }
    // MOV AX,[0xce7a] (1000_AD07 / 0x1AD07)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdbd2],AX (1000_AD0A / 0x1AD0A)
    UInt16[DS, 0xDBD2] = AX;
    label_1000_AD0D_1AD0D:
    // SUB AX,word ptr [0xce7a] (1000_AD0D / 0x1AD0D)
    AX -= UInt16[DS, 0xCE7A];
    
    // NEG AX (1000_AD11 / 0x1AD11)
    AX = Alu.Sub16(0, AX);
    // CMP AX,0xc8 (1000_AD13 / 0x1AD13)
    Alu.Sub16(AX, 0xC8);
    // JC 0x1000:ad36 (1000_AD16 / 0x1AD16)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    label_1000_AD18_1AD18:
    // MOV SI,word ptr [0x380e] (1000_AD18 / 0x1AD18)
    SI = UInt16[DS, 0x380E];
    // LODSB SI (1000_AD1C / 0x1AD1C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_AD1D / 0x1AD1D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:ad30 (1000_AD1F / 0x1AD1F)
    if(!SignFlag) {
      goto label_1000_AD30_1AD30;
    }
    // MOV SI,0x37fa (1000_AD21 / 0x1AD21)
    SI = 0x37FA;
    // LODSB SI (1000_AD24 / 0x1AD24)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // TEST byte ptr [0x3810],0x2 (1000_AD25 / 0x1AD25)
    Alu.And8(UInt8[DS, 0x3810], 0x2);
    // JZ 0x1000:ad30 (1000_AD2A / 0x1AD2A)
    if(ZeroFlag) {
      goto label_1000_AD30_1AD30;
    }
    // CALL 0x1000:acbf (1000_AD2C / 0x1AD2C)
    throw FailAsUntested("Could not find a valid function at address 1000_ACBF / 0x1ACBF");
    // LODSB SI (1000_AD2F / 0x1AD2F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_AD30_1AD30:
    // MOV word ptr [0x380e],SI (1000_AD30 / 0x1AD30)
    UInt16[DS, 0x380E] = SI;
    // JMP 0x1000:ad95 (1000_AD34 / 0x1AD34)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_AD95_01AD95, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_AD36_1AD36:
    // RET  (1000_AD36 / 0x1AD36)
    return NearRet();
    label_1000_AD37_1AD37:
    // CALL 0x1000:aec6 (1000_AD37 / 0x1AD37)
    NearCall(cs1, 0xAD3A, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    label_1000_AD3A_1AD3A:
    // JC 0x1000:ad36 (1000_AD3A / 0x1AD3A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // CMP byte ptr [0xdbcd],0x0 (1000_AD3C / 0x1AD3C)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JS 0x1000:ad36 (1000_AD41 / 0x1AD41)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_AD36 / 0x1AD36)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD43_01AD43, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_AD43_01AD43(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AD43_1AD43:
    // MOV AL,[0xdbcc] (1000_AD43 / 0x1AD43)
    AL = UInt8[DS, 0xDBCC];
    // MOV byte ptr [0xdbcb],0x0 (1000_AD46 / 0x1AD46)
    UInt8[DS, 0xDBCB] = 0x0;
    // OR AL,AL (1000_AD4B / 0x1AD4B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:ad95 (1000_AD4D / 0x1AD4D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_AD95_01AD95, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_AD4F / 0x1AD4F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AD57_01AD57(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AD57_1AD57:
    // CALL 0x1000:aeb7 (1000_AD57 / 0x1AD57)
    NearCall(cs1, 0xAD5A, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_AD5A_1AD5A:
    // MOV AL,0x6 (1000_AD5A / 0x1AD5A)
    AL = 0x6;
    // JMP 0x1000:ad95 (1000_AD5C / 0x1AD5C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_AD95_01AD95, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_AD5E_01AD5E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AD5E_1AD5E:
    // CALL 0x1000:aec6 (1000_AD5E / 0x1AD5E)
    NearCall(cs1, 0xAD61, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    label_1000_AD61_1AD61:
    // JC 0x1000:ad74 (1000_AD61 / 0x1AD61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_AD74 / 0x1AD74)
      return NearRet();
    }
    // CALL 0x1000:aa96 (1000_AD63 / 0x1AD63)
    NearCall(cs1, 0xAD66, spice86_generated_label_call_target_1000_AA96_01AA96);
    label_1000_AD66_1AD66:
    // CMP byte ptr [0x3810],0x0 (1000_AD66 / 0x1AD66)
    Alu.Sub8(UInt8[DS, 0x3810], 0x0);
    // JZ 0x1000:ad75 (1000_AD6B / 0x1AD6B)
    if(ZeroFlag) {
      goto label_1000_AD75_1AD75;
    }
    // CMP byte ptr [0xdbcd],0x0 (1000_AD6D / 0x1AD6D)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JNS 0x1000:ad18 (1000_AD72 / 0x1AD72)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ACE6_01ACE6, 0x1AD18 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_AD74_1AD74:
    // RET  (1000_AD74 / 0x1AD74)
    return NearRet();
    label_1000_AD75_1AD75:
    // MOV BX,0x375c (1000_AD75 / 0x1AD75)
    BX = 0x375C;
    // XLAT BX (1000_AD78 / 0x1AD78)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // OR AL,AL (1000_AD79 / 0x1AD79)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:adbd (1000_AD7B / 0x1AD7B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // OR AL,AL (1000_AD7D / 0x1AD7D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:ad89 (1000_AD7F / 0x1AD7F)
    if(SignFlag) {
      goto label_1000_AD89_1AD89;
    }
    // MOV [0xdbcc],AL (1000_AD81 / 0x1AD81)
    UInt8[DS, 0xDBCC] = AL;
    // CALLF [0x3979] (1000_AD84 / 0x1AD84)
    // Indirect call to [0x3979], generating possible targets from emulator records
    uint targetAddress_1000_AD84 = (uint)(UInt16[DS, 0x397B] * 0x10 + UInt16[DS, 0x3979] - cs1 * 0x10);
    switch(targetAddress_1000_AD84) {
      case 0x464E9 : FarCall(cs1, 0xAD88, spice86_generated_label_call_target_563E_0109_0564E9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AD84));
        break;
    }
    label_1000_AD88_1AD88:
    // RET  (1000_AD88 / 0x1AD88)
    return NearRet();
    label_1000_AD89_1AD89:
    // AND AL,0x3f (1000_AD89 / 0x1AD89)
    // AL &= 0x3F;
    AL = Alu.And8(AL, 0x3F);
    // MOV [0xdbcc],AL (1000_AD8B / 0x1AD8B)
    UInt8[DS, 0xDBCC] = AL;
    // CMP AL,byte ptr [0xdbcb] (1000_AD8E / 0x1AD8E)
    Alu.Sub8(AL, UInt8[DS, 0xDBCB]);
    // JNZ 0x1000:adbe (1000_AD92 / 0x1AD92)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_ADBE_01ADBE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_AD94 / 0x1AD94)
    return NearRet();
  }
  
  public Action split_1000_AD95_01AD95(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xADBD: goto label_1000_ADBD_1ADBD;break; // Target of external jump from 0x1AE1C, 0x1ADCF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_AD95_1AD95:
    // XOR AH,AH (1000_AD95 / 0x1AD95)
    AH = 0;
    // CALL 0x1000:aec6 (1000_AD97 / 0x1AD97)
    NearCall(cs1, 0xAD9A, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    label_1000_AD9A_1AD9A:
    // JC 0x1000:adbd (1000_AD9A / 0x1AD9A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // CMP AL,byte ptr [0xdbcb] (1000_AD9C / 0x1AD9C)
    Alu.Sub8(AL, UInt8[DS, 0xDBCB]);
    // JZ 0x1000:adbd (1000_ADA0 / 0x1ADA0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // CALL 0x1000:ae62 (1000_ADA2 / 0x1ADA2)
    NearCall(cs1, 0xADA5, spice86_generated_label_call_target_1000_AE62_01AE62);
    label_1000_ADA5_1ADA5:
    // MOV [0xdbcb],AL (1000_ADA5 / 0x1ADA5)
    UInt8[DS, 0xDBCB] = AL;
    // LES SI,[0xdbb6] (1000_ADA8 / 0x1ADA8)
    ES = UInt16[DS, 0xDBB8];
    SI = UInt16[DS, 0xDBB6];
    // MOV AL,[0x3810] (1000_ADAC / 0x1ADAC)
    AL = UInt8[DS, 0x3810];
    // AND AL,0x1 (1000_ADAF / 0x1ADAF)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    // CALLF [0x3971] (1000_ADB1 / 0x1ADB1)
    // Indirect call to [0x3971], generating possible targets from emulator records
    uint targetAddress_1000_ADB1 = (uint)(UInt16[DS, 0x3973] * 0x10 + UInt16[DS, 0x3971] - cs1 * 0x10);
    switch(targetAddress_1000_ADB1) {
      case 0x464E3 : FarCall(cs1, 0xADB5, spice86_generated_label_call_target_563E_0103_0564E3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_ADB1));
        break;
    }
    label_1000_ADB5_1ADB5:
    // MOV [0xdbcd],AL (1000_ADB5 / 0x1ADB5)
    UInt8[DS, 0xDBCD] = AL;
    // XOR AX,AX (1000_ADB8 / 0x1ADB8)
    AX = 0;
    // MOV [0xdbd2],AX (1000_ADBA / 0x1ADBA)
    UInt16[DS, 0xDBD2] = AX;
    label_1000_ADBD_1ADBD:
    // RET  (1000_ADBD / 0x1ADBD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_ADBE_01ADBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ADBE_1ADBE:
    // CALL 0x1000:aec6 (1000_ADBE / 0x1ADBE)
    NearCall(cs1, 0xADC1, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    label_1000_ADC1_1ADC1:
    // JC 0x1000:adbd (1000_ADC1 / 0x1ADC1)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // TEST byte ptr [0x3810],0x1 (1000_ADC3 / 0x1ADC3)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    // JNZ 0x1000:adbd (1000_ADC8 / 0x1ADC8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // TEST byte ptr [0xdbcd],0x40 (1000_ADCA / 0x1ADCA)
    Alu.And8(UInt8[DS, 0xDBCD], 0x40);
    // JNZ 0x1000:adbd (1000_ADCF / 0x1ADCF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // PUSH BX (1000_ADD1 / 0x1ADD1)
    Stack.Push(BX);
    // MOV AX,0x12c (1000_ADD2 / 0x1ADD2)
    AX = 0x12C;
    // XOR BX,BX (1000_ADD5 / 0x1ADD5)
    BX = 0;
    // CALLF [0x397d] (1000_ADD7 / 0x1ADD7)
    // Indirect call to [0x397d], generating possible targets from emulator records
    uint targetAddress_1000_ADD7 = (uint)(UInt16[DS, 0x397F] * 0x10 + UInt16[DS, 0x397D] - cs1 * 0x10);
    switch(targetAddress_1000_ADD7) {
      case 0x464EC : FarCall(cs1, 0xADDB, spice86_generated_label_call_target_563E_010C_0564EC); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_ADD7));
        break;
    }
    label_1000_ADDB_1ADDB:
    // MOV [0xdbcd],AL (1000_ADDB / 0x1ADDB)
    UInt8[DS, 0xDBCD] = AL;
    // POP BX (1000_ADDE / 0x1ADDE)
    BX = Stack.Pop();
    // RET  (1000_ADDF / 0x1ADDF)
    return NearRet();
  }
  
  public Action split_1000_ADED_01ADED(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ADED_1ADED:
    // MOV AX,0x190 (1000_ADED / 0x1ADED)
    AX = 0x190;
    // MOV BL,byte ptr [0x2896] (1000_ADF0 / 0x1ADF0)
    BL = UInt8[DS, 0x2896];
    // MOV BH,byte ptr [0x28ae] (1000_ADF4 / 0x1ADF4)
    BH = UInt8[DS, 0x28AE];
    label_1000_ADF8_1ADF8:
    // CMP BL,0x4 (1000_ADF8 / 0x1ADF8)
    Alu.Sub8(BL, 0x4);
    // JNC 0x1000:adff (1000_ADFB / 0x1ADFB)
    if(!CarryFlag) {
      goto label_1000_ADFF_1ADFF;
    }
    // MOV BL,0x4 (1000_ADFD / 0x1ADFD)
    BL = 0x4;
    label_1000_ADFF_1ADFF:
    // CALLF [0x397d] (1000_ADFF / 0x1ADFF)
    // Indirect call to [0x397d], generating possible targets from emulator records
    uint targetAddress_1000_ADFF = (uint)(UInt16[DS, 0x397F] * 0x10 + UInt16[DS, 0x397D] - cs1 * 0x10);
    switch(targetAddress_1000_ADFF) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_ADFF));
        break;
    }
    // RET  (1000_AE03 / 0x1AE03)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AE04_01AE04(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AE04_1AE04:
    // CALL 0x1000:aec6 (1000_AE04 / 0x1AE04)
    NearCall(cs1, 0xAE07, spice86_generated_label_call_target_1000_AEC6_01AEC6);
    label_1000_AE07_1AE07:
    // JC 0x1000:adbd (1000_AE07 / 0x1AE07)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // TEST byte ptr [0x3810],0x1 (1000_AE09 / 0x1AE09)
    Alu.And8(UInt8[DS, 0x3810], 0x1);
    // JNZ 0x1000:adbd (1000_AE0E / 0x1AE0E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    // CMP byte ptr [0xdbcd],0x0 (1000_AE10 / 0x1AE10)
    Alu.Sub8(UInt8[DS, 0xDBCD], 0x0);
    // JNS 0x1000:ae1e (1000_AE15 / 0x1AE15)
    if(!SignFlag) {
      goto label_1000_AE1E_1AE1E;
    }
    // TEST byte ptr [0xdbcd],0x40 (1000_AE17 / 0x1AE17)
    Alu.And8(UInt8[DS, 0xDBCD], 0x40);
    // JZ 0x1000:adbd (1000_AE1C / 0x1AE1C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_ADBD / 0x1ADBD)
      return NearRet();
    }
    label_1000_AE1E_1AE1E:
    // CALL 0x1000:e270 (1000_AE1E / 0x1AE1E)
    NearCall(cs1, 0xAE21, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_AE21_1AE21:
    // CALL 0x1000:ad43 (1000_AE21 / 0x1AE21)
    NearCall(cs1, 0xAE24, spice86_generated_label_call_target_1000_AD43_01AD43);
    label_1000_AE24_1AE24:
    // CALL 0x1000:e283 (1000_AE24 / 0x1AE24)
    NearCall(cs1, 0xAE27, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_AE27_1AE27:
    // RET  (1000_AE27 / 0x1AE27)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AE28_01AE28(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AE28_1AE28:
    // TEST word ptr [0xdbc8],0x100 (1000_AE28 / 0x1AE28)
    Alu.And16(UInt16[DS, 0xDBC8], 0x100);
    // RET  (1000_AE2E / 0x1AE2E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AE2F_01AE2F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AE2F_1AE2F:
    // PUSH AX (1000_AE2F / 0x1AE2F)
    Stack.Push(AX);
    // PUSH DS (1000_AE30 / 0x1AE30)
    Stack.Push(DS);
    // MOV AX,0x1f4b (1000_AE31 / 0x1AE31)
    AX = 0x1F4B;
    // MOV DS,AX (1000_AE34 / 0x1AE34)
    DS = AX;
    // TEST word ptr [0xdbc8],0x1 (1000_AE36 / 0x1AE36)
    Alu.And16(UInt16[DS, 0xDBC8], 0x1);
    // POP DS (1000_AE3C / 0x1AE3C)
    DS = Stack.Pop();
    // POP AX (1000_AE3D / 0x1AE3D)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AE3F_01AE3F, 0x1AE3E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_AE3F_01AE3F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xAE3E: break; // Instructions before entry targeted by 0x1AE57
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_AE3E_1AE3E:
    // RET  (1000_AE3E / 0x1AE3E)
    return NearRet();
    entry:
    label_1000_AE3F_1AE3F:
    // CALL 0x1000:ae28 (1000_AE3F / 0x1AE3F)
    NearCall(cs1, 0xAE42, spice86_generated_label_call_target_1000_AE28_01AE28);
    label_1000_AE42_1AE42:
    // JZ 0x1000:ae3e (1000_AE42 / 0x1AE42)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AE3E / 0x1AE3E)
      return NearRet();
    }
    // MOV DI,0xdbb6 (1000_AE44 / 0x1AE44)
    DI = 0xDBB6;
    // MOV AX,word ptr [DI] (1000_AE47 / 0x1AE47)
    AX = UInt16[DS, DI];
    // OR AX,word ptr [DI + 0x2] (1000_AE49 / 0x1AE49)
    // AX |= UInt16[DS, (ushort)(DI + 0x2)];
    AX = Alu.Or16(AX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JNZ 0x1000:ae3e (1000_AE4C / 0x1AE4C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_AE3E / 0x1AE3E)
      return NearRet();
    }
    // MOV CX,0x9c40 (1000_AE4E / 0x1AE4E)
    CX = 0x9C40;
    // JMP 0x1000:f0f6 (1000_AE51 / 0x1AE51)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0F6_01F0F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_AE54_01AE54(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AE54_1AE54:
    // CALL 0x1000:ae2f (1000_AE54 / 0x1AE54)
    NearCall(cs1, 0xAE57, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_AE57_1AE57:
    // JZ 0x1000:ae3e (1000_AE57 / 0x1AE57)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AE3E / 0x1AE3E)
      return NearRet();
    }
    // MOV DI,0x3811 (1000_AE59 / 0x1AE59)
    DI = 0x3811;
    // MOV CX,0x4e20 (1000_AE5C / 0x1AE5C)
    CX = 0x4E20;
    // JMP 0x1000:f0f6 (1000_AE5F / 0x1AE5F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0F6_01F0F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_AE62_01AE62(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AE62_1AE62:
    // CMP AL,byte ptr [0xdbca] (1000_AE62 / 0x1AE62)
    Alu.Sub8(AL, UInt8[DS, 0xDBCA]);
    // JZ 0x1000:ae84 (1000_AE66 / 0x1AE66)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_AE84 / 0x1AE84)
      return NearRet();
    }
    // CALL 0x1000:aeb7 (1000_AE68 / 0x1AE68)
    NearCall(cs1, 0xAE6B, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_AE6B_1AE6B:
    // MOV [0xdbca],AL (1000_AE6B / 0x1AE6B)
    UInt8[DS, 0xDBCA] = AL;
    // PUSH AX (1000_AE6E / 0x1AE6E)
    Stack.Push(AX);
    // ADD AX,0xa4 (1000_AE6F / 0x1AE6F)
    // AX += 0xA4;
    AX = Alu.Add16(AX, 0xA4);
    // MOV SI,AX (1000_AE72 / 0x1AE72)
    SI = AX;
    // LES DI,[0xdbb6] (1000_AE74 / 0x1AE74)
    ES = UInt16[DS, 0xDBB8];
    DI = UInt16[DS, 0xDBB6];
    // MOV AX,ES (1000_AE78 / 0x1AE78)
    AX = ES;
    // CMP AX,word ptr [0xce68] (1000_AE7A / 0x1AE7A)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    // JNC 0x1000:ae85 (1000_AE7E / 0x1AE7E)
    if(!CarryFlag) {
      goto label_1000_AE85_1AE85;
    }
    // CALL 0x1000:f0b9 (1000_AE80 / 0x1AE80)
    NearCall(cs1, 0xAE83, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_AE83_1AE83:
    // POP AX (1000_AE83 / 0x1AE83)
    AX = Stack.Pop();
    label_1000_AE84_1AE84:
    // RET  (1000_AE84 / 0x1AE84)
    return NearRet();
    label_1000_AE85_1AE85:
    // PUSH word ptr [0x2784] (1000_AE85 / 0x1AE85)
    Stack.Push(UInt16[DS, 0x2784]);
    // PUSH SI (1000_AE89 / 0x1AE89)
    Stack.Push(SI);
    // MOV CX,0x2af (1000_AE8A / 0x1AE8A)
    CX = 0x2AF;
    // CALL 0x1000:f11c (1000_AE8D / 0x1AE8D)
    NearCall(cs1, 0xAE90, spice86_generated_label_call_target_1000_F11C_01F11C);
    // POP SI (1000_AE90 / 0x1AE90)
    SI = Stack.Pop();
    // INC byte ptr [0xce71] (1000_AE91 / 0x1AE91)
    UInt8[DS, 0xCE71] = Alu.Inc8(UInt8[DS, 0xCE71]);
    // CALL 0x1000:f0b9 (1000_AE95 / 0x1AE95)
    NearCall(cs1, 0xAE98, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // DEC byte ptr [0xce71] (1000_AE98 / 0x1AE98)
    UInt8[DS, 0xCE71] = Alu.Dec8(UInt8[DS, 0xCE71]);
    // PUSH DS (1000_AE9C / 0x1AE9C)
    Stack.Push(DS);
    // PUSH DI (1000_AE9D / 0x1AE9D)
    Stack.Push(DI);
    // PUSH ES (1000_AE9E / 0x1AE9E)
    Stack.Push(ES);
    // LES DI,[0xdbb6] (1000_AE9F / 0x1AE9F)
    ES = UInt16[DS, 0xDBB8];
    DI = UInt16[DS, 0xDBB6];
    // POP DS (1000_AEA3 / 0x1AEA3)
    DS = Stack.Pop();
    // POP SI (1000_AEA4 / 0x1AEA4)
    SI = Stack.Pop();
    // CALL 0x1000:f403 (1000_AEA5 / 0x1AEA5)
    NearCall(cs1, 0xAEA8, spice86_generated_label_call_target_1000_F403_01F403);
    // POP DS (1000_AEA8 / 0x1AEA8)
    DS = Stack.Pop();
    // POP AX (1000_AEA9 / 0x1AEA9)
    AX = Stack.Pop();
    // CALL 0x1000:c13e (1000_AEAA / 0x1AEAA)
    NearCall(cs1, 0xAEAD, spice86_generated_label_call_target_1000_C13E_01C13E);
    // POP AX (1000_AEAD / 0x1AEAD)
    AX = Stack.Pop();
    // RET  (1000_AEAE / 0x1AEAE)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AEB7_01AEB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AEB7_1AEB7:
    // PUSH AX (1000_AEB7 / 0x1AEB7)
    Stack.Push(AX);
    // MOV byte ptr [0xdbcb],0x0 (1000_AEB8 / 0x1AEB8)
    UInt8[DS, 0xDBCB] = 0x0;
    // CALLF [0x3975] (1000_AEBD / 0x1AEBD)
    // Indirect call to [0x3975], generating possible targets from emulator records
    uint targetAddress_1000_AEBD = (uint)(UInt16[DS, 0x3977] * 0x10 + UInt16[DS, 0x3975] - cs1 * 0x10);
    switch(targetAddress_1000_AEBD) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_AEBD));
        break;
    }
    // MOV [0xdbcd],AL (1000_AEC1 / 0x1AEC1)
    UInt8[DS, 0xDBCD] = AL;
    // POP AX (1000_AEC4 / 0x1AEC4)
    AX = Stack.Pop();
    // RET  (1000_AEC5 / 0x1AEC5)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_AEC6_01AEC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_AEC6_1AEC6:
    // TEST byte ptr [0x2943],0x10 (1000_AEC6 / 0x1AEC6)
    Alu.And8(UInt8[DS, 0x2943], 0x10);
    // JNZ 0x1000:aed4 (1000_AECB / 0x1AECB)
    if(!ZeroFlag) {
      goto label_1000_AED4_1AED4;
    }
    // CALL 0x1000:ae28 (1000_AECD / 0x1AECD)
    NearCall(cs1, 0xAED0, spice86_generated_label_call_target_1000_AE28_01AE28);
    // JZ 0x1000:aed4 (1000_AED0 / 0x1AED0)
    if(ZeroFlag) {
      goto label_1000_AED4_1AED4;
    }
    // CLC  (1000_AED2 / 0x1AED2)
    CarryFlag = false;
    // RET  (1000_AED3 / 0x1AED3)
    return NearRet();
    label_1000_AED4_1AED4:
    // STC  (1000_AED4 / 0x1AED4)
    CarryFlag = true;
    // RET  (1000_AED5 / 0x1AED5)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B17A_01B17A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B17A_1B17A:
    // MOV AL,[0xc6] (1000_B17A / 0x1B17A)
    AL = UInt8[DS, 0xC6];
    // PUSH AX (1000_B17D / 0x1B17D)
    Stack.Push(AX);
    // OR AL,0x80 (1000_B17E / 0x1B17E)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    // MOV [0xc6],AL (1000_B180 / 0x1B180)
    UInt8[DS, 0xC6] = AL;
    // CALL 0x1000:96b5 (1000_B183 / 0x1B183)
    NearCall(cs1, 0xB186, spice86_generated_label_call_target_1000_96B5_0196B5);
    label_1000_B186_1B186:
    // POP AX (1000_B186 / 0x1B186)
    AX = Stack.Pop();
    // MOV [0xc6],AL (1000_B187 / 0x1B187)
    UInt8[DS, 0xC6] = AL;
    // RET  (1000_B18A / 0x1B18A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B2B3_01B2B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B2B3_1B2B3:
    // DEC byte ptr [0x2788] (1000_B2B3 / 0x1B2B3)
    UInt8[DS, 0x2788] = Alu.Dec8(UInt8[DS, 0x2788]);
    // JNS 0x1000:b2bd (1000_B2B7 / 0x1B2B7)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_B2BD / 0x1B2BD)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B2B9_01B2B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B2B9_01B2B9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xB2BD: goto label_1000_B2BD_1B2BD;break; // Target of external jump from 0x1B2B7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B2B9_1B2B9:
    // INC byte ptr [0x2788] (1000_B2B9 / 0x1B2B9)
    UInt8[DS, 0x2788] = Alu.Inc8(UInt8[DS, 0x2788]);
    label_1000_B2BD_1B2BD:
    // RET  (1000_B2BD / 0x1B2BD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B2BE_01B2BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B2BE_1B2BE:
    // MOV byte ptr [0x2788],0x0 (1000_B2BE / 0x1B2BE)
    UInt8[DS, 0x2788] = 0x0;
    // RET  (1000_B2C3 / 0x1B2C3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B2C4_01B2C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B2C4_1B2C4:
    // CMP byte ptr [0x38af],0x32 (1000_B2C4 / 0x1B2C4)
    Alu.Sub8(UInt8[DS, 0x38AF], 0x32);
    // JA 0x1000:b30e (1000_B2C9 / 0x1B2C9)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_B30E / 0x1B30E)
      return NearRet();
    }
    // MOV AX,word ptr [SI] (1000_B2CB / 0x1B2CB)
    AX = UInt16[DS, SI];
    // CALL 0x1000:e270 (1000_B2CD / 0x1B2CD)
    NearCall(cs1, 0xB2D0, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_B2D0_1B2D0:
    // PUSH ES (1000_B2D0 / 0x1B2D0)
    Stack.Push(ES);
    // AND AX,0xfff (1000_B2D1 / 0x1B2D1)
    // AX &= 0xFFF;
    AX = Alu.And16(AX, 0xFFF);
    // MOV SI,AX (1000_B2D4 / 0x1B2D4)
    SI = AX;
    // CALL 0x1000:cf70 (1000_B2D6 / 0x1B2D6)
    NearCall(cs1, 0xB2D9, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_B2D9_1B2D9:
    // CALL 0x1000:d03c (1000_B2D9 / 0x1B2D9)
    NearCall(cs1, 0xB2DC, spice86_generated_label_call_target_1000_D03C_01D03C);
    label_1000_B2DC_1B2DC:
    // CALL 0x1000:d03c (1000_B2DC / 0x1B2DC)
    NearCall(cs1, 0xB2DF, spice86_generated_label_call_target_1000_D03C_01D03C);
    label_1000_B2DF_1B2DF:
    // MOV AX,[0xd816] (1000_B2DF / 0x1B2DF)
    AX = UInt16[DS, 0xD816];
    // PUSH AX (1000_B2E2 / 0x1B2E2)
    Stack.Push(AX);
    // ADD AX,0x3 (1000_B2E3 / 0x1B2E3)
    AX += 0x3;
    
    // SHR AX,0x1 (1000_B2E6 / 0x1B2E6)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_B2E8 / 0x1B2E8)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_B2EA / 0x1B2EA)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_B2EC / 0x1B2EC)
    AX >>= 0x1;
    
    // INC AX (1000_B2EE / 0x1B2EE)
    AX = Alu.Inc16(AX);
    // CALL 0x1000:e2e3 (1000_B2EF / 0x1B2EF)
    NearCall(cs1, 0xB2F2, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    label_1000_B2F2_1B2F2:
    // LEA DI,[SI + 0x3] (1000_B2F2 / 0x1B2F2)
    DI = (ushort)(SI + 0x3);
    // MOV SI,0x117 (1000_B2F5 / 0x1B2F5)
    SI = 0x117;
    // CALL 0x1000:cf70 (1000_B2F8 / 0x1B2F8)
    NearCall(cs1, 0xB2FB, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_B2FB_1B2FB:
    // POP AX (1000_B2FB / 0x1B2FB)
    AX = Stack.Pop();
    // AND AL,0xf (1000_B2FC / 0x1B2FC)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // MOV AH,0xa (1000_B2FE / 0x1B2FE)
    AH = 0xA;
    // MUL AH (1000_B300 / 0x1B300)
    Cpu.Mul8(AH);
    // ADD SI,AX (1000_B302 / 0x1B302)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV CX,0xa (1000_B304 / 0x1B304)
    CX = 0xA;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,ES:SI (1000_B307 / 0x1B307)
      UInt8[ES, DI] = UInt8[ES, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP ES (1000_B30A / 0x1B30A)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_B30B / 0x1B30B)
    NearCall(cs1, 0xB30E, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_B30E_1B30E:
    // RET  (1000_B30E / 0x1B30E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B30F_01B30F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B30F_1B30F:
    // MOV DI,0x38a8 (1000_B30F / 0x1B30F)
    DI = 0x38A8;
    // MOV byte ptr [DI + 0x7],0x31 (1000_B312 / 0x1B312)
    UInt8[DS, (ushort)(DI + 0x7)] = 0x31;
    label_1000_B316_1B316:
    // MOV DX,DI (1000_B316 / 0x1B316)
    DX = DI;
    // CALL 0x1000:f2fc (1000_B318 / 0x1B318)
    NearCall(cs1, 0xB31B, spice86_generated_label_call_target_1000_F2FC_01F2FC);
    label_1000_B31B_1B31B:
    // MOV AX,0x3d00 (1000_B31B / 0x1B31B)
    AX = 0x3D00;
    // INT 0x21 (1000_B31E / 0x1B31E)
    Interrupt(0x21);
    // JC 0x1000:b33c (1000_B320 / 0x1B320)
    if(CarryFlag) {
      goto label_1000_B33C_1B33C;
    }
    // MOV BX,AX (1000_B322 / 0x1B322)
    BX = AX;
    // MOV DX,0xd816 (1000_B324 / 0x1B324)
    DX = 0xD816;
    // PUSH CX (1000_B327 / 0x1B327)
    Stack.Push(CX);
    // MOV CX,0x2 (1000_B328 / 0x1B328)
    CX = 0x2;
    // MOV AH,0x3f (1000_B32B / 0x1B32B)
    AH = 0x3F;
    // INT 0x21 (1000_B32D / 0x1B32D)
    Interrupt(0x21);
    // CMP AX,CX (1000_B32F / 0x1B32F)
    Alu.Sub16(AX, CX);
    // POP CX (1000_B331 / 0x1B331)
    CX = Stack.Pop();
    // JC 0x1000:b33c (1000_B332 / 0x1B332)
    if(CarryFlag) {
      goto label_1000_B33C_1B33C;
    }
    // MOV AH,0x3e (1000_B334 / 0x1B334)
    AH = 0x3E;
    // INT 0x21 (1000_B336 / 0x1B336)
    Interrupt(0x21);
    // CALL 0x1000:b2c4 (1000_B338 / 0x1B338)
    NearCall(cs1, 0xB33B, spice86_generated_label_call_target_1000_B2C4_01B2C4);
    label_1000_B33B_1B33B:
    // CLC  (1000_B33B / 0x1B33B)
    CarryFlag = false;
    label_1000_B33C_1B33C:
    // SBB AX,AX (1000_B33C / 0x1B33C)
    AX = Alu.Sbb16(AX, AX);
    // CMP CH,0x80 (1000_B33E / 0x1B33E)
    Alu.Sub8(CH, 0x80);
    // JNZ 0x1000:b345 (1000_B341 / 0x1B341)
    if(!ZeroFlag) {
      goto label_1000_B345_1B345;
    }
    // NOT AX (1000_B343 / 0x1B343)
    AX = (ushort)~AX;
    label_1000_B345_1B345:
    // AND AX,CX (1000_B345 / 0x1B345)
    AX &= CX;
    
    // AND word ptr [SI],0x3fff (1000_B347 / 0x1B347)
    // UInt16[DS, SI] &= 0x3FFF;
    UInt16[DS, SI] = Alu.And16(UInt16[DS, SI], 0x3FFF);
    // OR word ptr [SI],AX (1000_B34B / 0x1B34B)
    UInt16[DS, SI] |= AX;
    
    // ADD SI,0x4 (1000_B34D / 0x1B34D)
    SI += 0x4;
    
    // INC byte ptr [DI + 0x7] (1000_B350 / 0x1B350)
    UInt8[DS, (ushort)(DI + 0x7)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0x7)]);
    // CMP word ptr [SI],0xa3 (1000_B353 / 0x1B353)
    Alu.Sub16(UInt16[DS, SI], 0xA3);
    // JNZ 0x1000:b316 (1000_B357 / 0x1B357)
    if(!ZeroFlag) {
      goto label_1000_B316_1B316;
    }
    // RET  (1000_B359 / 0x1B359)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B389_01B389(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B389_1B389:
    // ADD CL,0x31 (1000_B389 / 0x1B389)
    // CL += 0x31;
    CL = Alu.Add8(CL, 0x31);
    // MOV byte ptr [0x38af],CL (1000_B38C / 0x1B38C)
    UInt8[DS, 0x38AF] = CL;
    // CALL 0x1000:b427 (1000_B390 / 0x1B390)
    NearCall(cs1, 0xB393, spice86_generated_label_call_target_1000_B427_01B427);
    label_1000_B393_1B393:
    // MOV AX,[0x2] (1000_B393 / 0x1B393)
    AX = UInt16[DS, 0x2];
    // PUSH DS (1000_B396 / 0x1B396)
    Stack.Push(DS);
    // PUSH ES (1000_B397 / 0x1B397)
    Stack.Push(ES);
    // POP DS (1000_B398 / 0x1B398)
    DS = Stack.Pop();
    // MOV SI,DI (1000_B399 / 0x1B399)
    SI = DI;
    // XOR DI,DI (1000_B39B / 0x1B39B)
    DI = 0;
    // STOSW ES:DI (1000_B39D / 0x1B39D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CALL 0x1000:b4ea (1000_B39E / 0x1B39E)
    NearCall(cs1, 0xB3A1, spice86_generated_label_call_target_1000_B4EA_01B4EA);
    label_1000_B3A1_1B3A1:
    // POP DS (1000_B3A1 / 0x1B3A1)
    DS = Stack.Pop();
    // MOV DX,0x38a8 (1000_B3A2 / 0x1B3A2)
    DX = 0x38A8;
    // CALL 0x1000:f2fc (1000_B3A5 / 0x1B3A5)
    NearCall(cs1, 0xB3A8, spice86_generated_label_call_target_1000_F2FC_01F2FC);
    label_1000_B3A8_1B3A8:
    // XOR DI,DI (1000_B3A8 / 0x1B3A8)
    DI = 0;
    // ADD CX,0x2 (1000_B3AA / 0x1B3AA)
    // CX += 0x2;
    CX = Alu.Add16(CX, 0x2);
    // JMP 0x1000:f27c (1000_B3AD / 0x1B3AD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_F27C_01F27C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_B427_01B427(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B427_1B427:
    // MOV CX,0x578 (1000_B427 / 0x1B427)
    CX = 0x578;
    // CALL 0x1000:f11c (1000_B42A / 0x1B42A)
    NearCall(cs1, 0xB42D, spice86_generated_label_call_target_1000_F11C_01F11C);
    label_1000_B42D_1B42D:
    // MOV DI,0x100 (1000_B42D / 0x1B42D)
    DI = 0x100;
    // PUSH DI (1000_B430 / 0x1B430)
    Stack.Push(DI);
    // PUSH ES (1000_B431 / 0x1B431)
    Stack.Push(ES);
    // PUSH DS (1000_B432 / 0x1B432)
    Stack.Push(DS);
    // LDS SI,[0xdcfe] (1000_B433 / 0x1B433)
    DS = UInt16[DS, 0xDD00];
    SI = UInt16[DS, 0xDCFE];
    // XOR SI,SI (1000_B437 / 0x1B437)
    SI = 0;
    // MOV CX,0xc5fc (1000_B439 / 0x1B439)
    CX = 0xC5FC;
    // SHR CX,0x1 (1000_B43C / 0x1B43C)
    CX >>= 0x1;
    
    // SHR CX,0x1 (1000_B43E / 0x1B43E)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    label_1000_B440_1B440:
    // MOV AH,0x3 (1000_B440 / 0x1B440)
    AH = 0x3;
    label_1000_B442_1B442:
    // LODSB SI (1000_B442 / 0x1B442)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // SHL AL,0x1 (1000_B443 / 0x1B443)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_B445 / 0x1B445)
    AL <<= 0x1;
    
    // SHL AX,0x1 (1000_B447 / 0x1B447)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_B449 / 0x1B449)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // JNC 0x1000:b442 (1000_B44B / 0x1B44B)
    if(!CarryFlag) {
      goto label_1000_B442_1B442;
    }
    // MOV AL,AH (1000_B44D / 0x1B44D)
    AL = AH;
    // STOSB ES:DI (1000_B44F / 0x1B44F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x1000:b440 (1000_B450 / 0x1B450)
    if(--CX != 0) {
      goto label_1000_B440_1B440;
    }
    // PUSH CS (1000_B452 / 0x1B452)
    Stack.Push(cs1);
    // POP DS (1000_B453 / 0x1B453)
    DS = Stack.Pop();
    // MOV SI,0xaa (1000_B454 / 0x1B454)
    SI = 0xAA;
    // MOV CX,0xa2 (1000_B457 / 0x1B457)
    CX = 0xA2;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B45A / 0x1B45A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP DS (1000_B45C / 0x1B45C)
    DS = Stack.Pop();
    // MOV SI,0xaa76 (1000_B45D / 0x1B45D)
    SI = 0xAA76;
    // MOV CX,0x11f8 (1000_B460 / 0x1B460)
    CX = 0x11F8;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B463 / 0x1B463)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // MOV SI,0x0 (1000_B465 / 0x1B465)
    SI = 0x0;
    // MOV CX,0x1261 (1000_B468 / 0x1B468)
    CX = 0x1261;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B46B / 0x1B46B)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP ES (1000_B46D / 0x1B46D)
    ES = Stack.Pop();
    // POP DI (1000_B46E / 0x1B46E)
    DI = Stack.Pop();
    // MOV CX,0x567a (1000_B46F / 0x1B46F)
    CX = 0x567A;
    // RET  (1000_B472 / 0x1B472)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B4EA_01B4EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B4EA_1B4EA:
    // MOV DL,0xf7 (1000_B4EA / 0x1B4EA)
    DL = 0xF7;
    // PUSH DI (1000_B4EC / 0x1B4EC)
    Stack.Push(DI);
    // ADD DI,0x4 (1000_B4ED / 0x1B4ED)
    DI += 0x4;
    
    label_1000_B4F0_1B4F0:
    // XOR DH,DH (1000_B4F0 / 0x1B4F0)
    DH = 0;
    label_1000_B4F2_1B4F2:
    // LODSB SI (1000_B4F2 / 0x1B4F2)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // INC DH (1000_B4F3 / 0x1B4F3)
    DH = Alu.Inc8(DH);
    // CMP AL,byte ptr [SI] (1000_B4F5 / 0x1B4F5)
    Alu.Sub8(AL, UInt8[DS, SI]);
    // JNZ 0x1000:b504 (1000_B4F7 / 0x1B4F7)
    if(!ZeroFlag) {
      goto label_1000_B504_1B504;
    }
    // CMP DH,0xff (1000_B4F9 / 0x1B4F9)
    Alu.Sub8(DH, 0xFF);
    // JZ 0x1000:b504 (1000_B4FC / 0x1B4FC)
    if(ZeroFlag) {
      goto label_1000_B504_1B504;
    }
    // DEC CX (1000_B4FE / 0x1B4FE)
    CX = Alu.Dec16(CX);
    // OR CX,CX (1000_B4FF / 0x1B4FF)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JNZ 0x1000:b4f2 (1000_B501 / 0x1B501)
    if(!ZeroFlag) {
      goto label_1000_B4F2_1B4F2;
    }
    // INC CX (1000_B503 / 0x1B503)
    CX = Alu.Inc16(CX);
    label_1000_B504_1B504:
    // CMP AL,DL (1000_B504 / 0x1B504)
    Alu.Sub8(AL, DL);
    // JZ 0x1000:b512 (1000_B506 / 0x1B506)
    if(ZeroFlag) {
      goto label_1000_B512_1B512;
    }
    // CMP DH,0x1 (1000_B508 / 0x1B508)
    Alu.Sub8(DH, 0x1);
    // JZ 0x1000:b51c (1000_B50B / 0x1B50B)
    if(ZeroFlag) {
      goto label_1000_B51C_1B51C;
    }
    // CMP DH,0x2 (1000_B50D / 0x1B50D)
    Alu.Sub8(DH, 0x2);
    // JZ 0x1000:b52f (1000_B510 / 0x1B510)
    if(ZeroFlag) {
      goto label_1000_B52F_1B52F;
    }
    label_1000_B512_1B512:
    // MOV AH,AL (1000_B512 / 0x1B512)
    AH = AL;
    // MOV AL,DL (1000_B514 / 0x1B514)
    AL = DL;
    // STOSB ES:DI (1000_B516 / 0x1B516)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,DH (1000_B517 / 0x1B517)
    AL = DH;
    // STOSB ES:DI (1000_B519 / 0x1B519)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV AL,AH (1000_B51A / 0x1B51A)
    AL = AH;
    label_1000_B51C_1B51C:
    // STOSB ES:DI (1000_B51C / 0x1B51C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // LOOP 0x1000:b4f0 (1000_B51D / 0x1B51D)
    if(--CX != 0) {
      goto label_1000_B4F0_1B4F0;
    }
    // MOV CX,DI (1000_B51F / 0x1B51F)
    CX = DI;
    // XOR AX,AX (1000_B521 / 0x1B521)
    AX = 0;
    // STOSW ES:DI (1000_B523 / 0x1B523)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // POP DI (1000_B524 / 0x1B524)
    DI = Stack.Pop();
    // SUB CX,DI (1000_B525 / 0x1B525)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    // MOV word ptr ES:[DI],DX (1000_B527 / 0x1B527)
    UInt16[ES, DI] = DX;
    // MOV word ptr ES:[DI + 0x2],CX (1000_B52A / 0x1B52A)
    UInt16[ES, (ushort)(DI + 0x2)] = CX;
    // RET  (1000_B52E / 0x1B52E)
    return NearRet();
    label_1000_B52F_1B52F:
    // STOSB ES:DI (1000_B52F / 0x1B52F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // JMP 0x1000:b51c (1000_B530 / 0x1B530)
    goto label_1000_B51C_1B51C;
  }
  
  public Action spice86_generated_label_call_target_1000_B532_01B532(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B532_1B532:
    // PUSH DX (1000_B532 / 0x1B532)
    Stack.Push(DX);
    // CALL 0x1000:b58b (1000_B533 / 0x1B533)
    NearCall(cs1, 0xB536, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_B536_1B536:
    // POP DX (1000_B536 / 0x1B536)
    DX = Stack.Pop();
    // MOV AL,byte ptr ES:[DI] (1000_B537 / 0x1B537)
    AL = UInt8[ES, DI];
    // RET  (1000_B53A / 0x1B53A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B53B_01B53B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B53B_1B53B:
    // PUSH BX (1000_B53B / 0x1B53B)
    Stack.Push(BX);
    // PUSH CX (1000_B53C / 0x1B53C)
    Stack.Push(CX);
    // PUSH DX (1000_B53D / 0x1B53D)
    Stack.Push(DX);
    // PUSH AX (1000_B53E / 0x1B53E)
    Stack.Push(AX);
    // CALL 0x1000:b58b (1000_B53F / 0x1B53F)
    NearCall(cs1, 0xB542, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_B542_1B542:
    // POP AX (1000_B542 / 0x1B542)
    AX = Stack.Pop();
    // MOV CX,AX (1000_B543 / 0x1B543)
    CX = AX;
    // SHR AX,0x1 (1000_B545 / 0x1B545)
    AX >>= 0x1;
    
    // SUB DI,AX (1000_B547 / 0x1B547)
    DI -= AX;
    
    // SUB DX,AX (1000_B549 / 0x1B549)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    // JNC 0x1000:b551 (1000_B54B / 0x1B54B)
    if(!CarryFlag) {
      goto label_1000_B551_1B551;
    }
    // ADD DX,BP (1000_B54D / 0x1B54D)
    DX += BP;
    
    // ADD DI,BP (1000_B54F / 0x1B54F)
    // DI += BP;
    DI = Alu.Add16(DI, BP);
    label_1000_B551_1B551:
    // MOV AL,byte ptr ES:[DI] (1000_B551 / 0x1B551)
    AL = UInt8[ES, DI];
    // MOV byte ptr [SI],AL (1000_B554 / 0x1B554)
    UInt8[DS, SI] = AL;
    // MOV word ptr [SI + 0x1],DI (1000_B556 / 0x1B556)
    UInt16[DS, (ushort)(SI + 0x1)] = DI;
    // ADD SI,0x3 (1000_B559 / 0x1B559)
    SI += 0x3;
    
    // INC DI (1000_B55C / 0x1B55C)
    DI = Alu.Inc16(DI);
    // INC DX (1000_B55D / 0x1B55D)
    DX = Alu.Inc16(DX);
    // CMP DX,BP (1000_B55E / 0x1B55E)
    Alu.Sub16(DX, BP);
    // JC 0x1000:b566 (1000_B560 / 0x1B560)
    if(CarryFlag) {
      goto label_1000_B566_1B566;
    }
    // SUB DX,BP (1000_B562 / 0x1B562)
    DX -= BP;
    
    // SUB DI,BP (1000_B564 / 0x1B564)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    label_1000_B566_1B566:
    // LOOP 0x1000:b551 (1000_B566 / 0x1B566)
    if(--CX != 0) {
      goto label_1000_B551_1B551;
    }
    // POP DX (1000_B568 / 0x1B568)
    DX = Stack.Pop();
    // POP CX (1000_B569 / 0x1B569)
    CX = Stack.Pop();
    // POP BX (1000_B56A / 0x1B56A)
    BX = Stack.Pop();
    // RET  (1000_B56B / 0x1B56B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B56C_01B56C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B56C_1B56C:
    // PUSH CX (1000_B56C / 0x1B56C)
    Stack.Push(CX);
    // MOV SI,CX (1000_B56D / 0x1B56D)
    SI = CX;
    // SHR SI,0x1 (1000_B56F / 0x1B56F)
    SI >>= 0x1;
    
    // SUB BX,SI (1000_B571 / 0x1B571)
    BX -= SI;
    
    // CMP BX,-0x62 (1000_B573 / 0x1B573)
    Alu.Sub16(BX, 0xFF9E);
    // JGE 0x1000:b57b (1000_B576 / 0x1B576)
    if(SignFlag == OverflowFlag) {
      goto label_1000_B57B_1B57B;
    }
    // MOV BX,0xff9e (1000_B578 / 0x1B578)
    BX = 0xFF9E;
    label_1000_B57B_1B57B:
    // MOV SI,0x9e68 (1000_B57B / 0x1B57B)
    SI = 0x9E68;
    label_1000_B57E_1B57E:
    // PUSH AX (1000_B57E / 0x1B57E)
    Stack.Push(AX);
    // CALL 0x1000:b53b (1000_B57F / 0x1B57F)
    NearCall(cs1, 0xB582, spice86_generated_label_call_target_1000_B53B_01B53B);
    label_1000_B582_1B582:
    // POP AX (1000_B582 / 0x1B582)
    AX = Stack.Pop();
    // INC BX (1000_B583 / 0x1B583)
    BX = Alu.Inc16(BX);
    // LOOP 0x1000:b57e (1000_B584 / 0x1B584)
    if(--CX != 0) {
      goto label_1000_B57E_1B57E;
    }
    // MOV SI,0x9e68 (1000_B586 / 0x1B586)
    SI = 0x9E68;
    // POP CX (1000_B589 / 0x1B589)
    CX = Stack.Pop();
    // RET  (1000_B58A / 0x1B58A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B58B_01B58B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B58B_1B58B:
    // CALL 0x1000:b5a0 (1000_B58B / 0x1B58B)
    NearCall(cs1, 0xB58E, spice86_generated_label_call_target_1000_B5A0_01B5A0);
    label_1000_B58E_1B58E:
    // LES DI,[0xdcfe] (1000_B58E / 0x1B58E)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    // ADD DI,AX (1000_B592 / 0x1B592)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV AX,BP (1000_B594 / 0x1B594)
    AX = BP;
    // MUL DX (1000_B596 / 0x1B596)
    Cpu.Mul16(DX);
    // SHL AX,0x1 (1000_B598 / 0x1B598)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // ADC DX,0x0 (1000_B59A / 0x1B59A)
    DX = Alu.Adc16(DX, 0x0);
    // ADD DI,DX (1000_B59D / 0x1B59D)
    // DI += DX;
    DI = Alu.Add16(DI, DX);
    // RET  (1000_B59F / 0x1B59F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B5A0_01B5A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B5A0_1B5A0:
    // PUSH BX (1000_B5A0 / 0x1B5A0)
    Stack.Push(BX);
    // SHL BX,0x1 (1000_B5A1 / 0x1B5A1)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_B5A3 / 0x1B5A3)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_B5A5 / 0x1B5A5)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // JNS 0x1000:b5b9 (1000_B5A7 / 0x1B5A7)
    if(!SignFlag) {
      goto label_1000_B5B9_1B5B9;
    }
    // NEG BX (1000_B5A9 / 0x1B5A9)
    BX = Alu.Sub16(0, BX);
    // MOV AX,word ptr [BX + 0x4948] (1000_B5AB / 0x1B5AB)
    AX = UInt16[DS, (ushort)(BX + 0x4948)];
    // NEG AX (1000_B5AF / 0x1B5AF)
    AX = Alu.Sub16(0, AX);
    // MOV BP,word ptr [BX + 0x494a] (1000_B5B1 / 0x1B5B1)
    BP = UInt16[DS, (ushort)(BX + 0x494A)];
    // SHL BP,0x1 (1000_B5B5 / 0x1B5B5)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // POP BX (1000_B5B7 / 0x1B5B7)
    BX = Stack.Pop();
    // RET  (1000_B5B8 / 0x1B5B8)
    return NearRet();
    label_1000_B5B9_1B5B9:
    // MOV AX,word ptr [BX + 0x4948] (1000_B5B9 / 0x1B5B9)
    AX = UInt16[DS, (ushort)(BX + 0x4948)];
    // MOV BP,word ptr [BX + 0x494a] (1000_B5BD / 0x1B5BD)
    BP = UInt16[DS, (ushort)(BX + 0x494A)];
    // SHL BP,0x1 (1000_B5C1 / 0x1B5C1)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // POP BX (1000_B5C3 / 0x1B5C3)
    BX = Stack.Pop();
    // RET  (1000_B5C4 / 0x1B5C4)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B5C5_01B5C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B5C5_1B5C5:
    // CALL 0x1000:b58b (1000_B5C5 / 0x1B5C5)
    NearCall(cs1, 0xB5C8, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_B5C8_1B5C8:
    // XOR AX,AX (1000_B5C8 / 0x1B5C8)
    AX = 0;
    // DIV BP (1000_B5CA / 0x1B5CA)
    Cpu.Div16(BP);
    // MOV DX,AX (1000_B5CC / 0x1B5CC)
    DX = AX;
    // RET  (1000_B5CE / 0x1B5CE)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B647_01B647(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B647_1B647:
    // XOR CX,CX (1000_B647 / 0x1B647)
    CX = 0;
    // TEST byte ptr [0x46eb],0x80 (1000_B649 / 0x1B649)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    // JZ 0x1000:b652 (1000_B64E / 0x1B64E)
    if(ZeroFlag) {
      goto label_1000_B652_1B652;
    }
    // MOV CL,0x2 (1000_B650 / 0x1B650)
    CL = 0x2;
    label_1000_B652_1B652:
    // MOV BP,BX (1000_B652 / 0x1B652)
    BP = BX;
    // SUB BX,word ptr [0x197e] (1000_B654 / 0x1B654)
    BX -= UInt16[DS, 0x197E];
    
    // SHL BX,CL (1000_B658 / 0x1B658)
    BX <<= CL;
    
    // ADD BX,word ptr [0xdcf8] (1000_B65A / 0x1B65A)
    BX += UInt16[DS, 0xDCF8];
    
    // SHL BP,0x1 (1000_B65E / 0x1B65E)
    BP <<= 0x1;
    
    // SHL BP,0x1 (1000_B660 / 0x1B660)
    BP <<= 0x1;
    
    // SHL BP,0x1 (1000_B662 / 0x1B662)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    // JNS 0x1000:b668 (1000_B664 / 0x1B664)
    if(!SignFlag) {
      goto label_1000_B668_1B668;
    }
    // NEG BP (1000_B666 / 0x1B666)
    BP = Alu.Sub16(0, BP);
    label_1000_B668_1B668:
    // MOV BP,word ptr [BP + 0x494a] (1000_B668 / 0x1B668)
    BP = UInt16[SS, (ushort)(BP + 0x494A)];
    // ADD BP,BP (1000_B66C / 0x1B66C)
    BP += BP;
    
    // SUB DX,word ptr [0x197c] (1000_B66E / 0x1B66E)
    // DX -= UInt16[DS, 0x197C];
    DX = Alu.Sub16(DX, UInt16[DS, 0x197C]);
    // MOV AX,DX (1000_B672 / 0x1B672)
    AX = DX;
    // IMUL BP (1000_B674 / 0x1B674)
    Cpu.IMul16(BP);
    // JCXZ 0x1000:b67e (1000_B676 / 0x1B676)
    if(CX == 0) {
      goto label_1000_B67E_1B67E;
    }
    label_1000_B678_1B678:
    // SHL AX,0x1 (1000_B678 / 0x1B678)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // RCL DX,0x1 (1000_B67A / 0x1B67A)
    DX = Alu.Rcl16(DX, 0x1);
    // LOOP 0x1000:b678 (1000_B67C / 0x1B67C)
    if(--CX != 0) {
      goto label_1000_B678_1B678;
    }
    label_1000_B67E_1B67E:
    // ADD DX,word ptr [0xdcf6] (1000_B67E / 0x1B67E)
    // DX += UInt16[DS, 0xDCF6];
    DX = Alu.Add16(DX, UInt16[DS, 0xDCF6]);
    // RET  (1000_B682 / 0x1B682)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B683_01B683(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B683_1B683:
    // JS 0x1000:b68b (1000_B683 / 0x1B683)
    if(SignFlag) {
      goto label_1000_B68B_1B68B;
    }
    // SUB BP,DX (1000_B685 / 0x1B685)
    BP -= DX;
    
    // NEG BP (1000_B687 / 0x1B687)
    BP = Alu.Sub16(0, BP);
    // JMP 0x1000:b68f (1000_B689 / 0x1B689)
    goto label_1000_B68F_1B68F;
    label_1000_B68B_1B68B:
    // XCHG BP,DX (1000_B68B / 0x1B68B)
    ushort tmp_1000_B68B = BP;
    BP = DX;
    DX = tmp_1000_B68B;
    // ADD DX,BP (1000_B68D / 0x1B68D)
    // DX += BP;
    DX = Alu.Add16(DX, BP);
    label_1000_B68F_1B68F:
    // MOV CX,BP (1000_B68F / 0x1B68F)
    CX = BP;
    // NEG CX (1000_B691 / 0x1B691)
    CX = Alu.Sub16(0, CX);
    // CMP CX,DX (1000_B693 / 0x1B693)
    Alu.Sub16(CX, DX);
    // JNC 0x1000:b699 (1000_B695 / 0x1B695)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_B699 / 0x1B699)
      return NearRet();
    }
    // MOV DX,BP (1000_B697 / 0x1B697)
    DX = BP;
    label_1000_B699_1B699:
    // RET  (1000_B699 / 0x1B699)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_B6C3_01B6C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_B6C3_1B6C3:
    // TEST byte ptr [0x46eb],0x80 (1000_B6C3 / 0x1B6C3)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    // JZ 0x1000:b714 (1000_B6C8 / 0x1B6C8)
    if(ZeroFlag) {
      goto label_1000_B714_1B714;
    }
    // PUSH DS (1000_B6CA / 0x1B6CA)
    Stack.Push(DS);
    // POP ES (1000_B6CB / 0x1B6CB)
    ES = Stack.Pop();
    // MOV word ptr [0xdcf6],0xa0 (1000_B6CC / 0x1B6CC)
    UInt16[DS, 0xDCF6] = 0xA0;
    // MOV word ptr [0xdcf8],0x4c (1000_B6D2 / 0x1B6D2)
    UInt16[DS, 0xDCF8] = 0x4C;
    // MOV CX,0x12 (1000_B6D8 / 0x1B6D8)
    CX = 0x12;
    // MOV BX,0x4b (1000_B6DB / 0x1B6DB)
    BX = 0x4B;
    // MOV AX,[0x197e] (1000_B6DE / 0x1B6DE)
    AX = UInt16[DS, 0x197E];
    // OR AX,AX (1000_B6E1 / 0x1B6E1)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // MOV DX,AX (1000_B6E3 / 0x1B6E3)
    DX = AX;
    // JNS 0x1000:b6e9 (1000_B6E5 / 0x1B6E5)
    if(!SignFlag) {
      goto label_1000_B6E9_1B6E9;
    }
    // NEG AX (1000_B6E7 / 0x1B6E7)
    AX = Alu.Sub16(0, AX);
    label_1000_B6E9_1B6E9:
    // CMP AX,BX (1000_B6E9 / 0x1B6E9)
    Alu.Sub16(AX, BX);
    // JC 0x1000:b6f8 (1000_B6EB / 0x1B6EB)
    if(CarryFlag) {
      goto label_1000_B6F8_1B6F8;
    }
    // MOV AX,BX (1000_B6ED / 0x1B6ED)
    AX = BX;
    // OR DX,DX (1000_B6EF / 0x1B6EF)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNS 0x1000:b6f5 (1000_B6F1 / 0x1B6F1)
    if(!SignFlag) {
      goto label_1000_B6F5_1B6F5;
    }
    // NEG AX (1000_B6F3 / 0x1B6F3)
    AX = Alu.Sub16(0, AX);
    label_1000_B6F5_1B6F5:
    // MOV [0x197e],AX (1000_B6F5 / 0x1B6F5)
    UInt16[DS, 0x197E] = AX;
    label_1000_B6F8_1B6F8:
    // MOV BP,0x4948 (1000_B6F8 / 0x1B6F8)
    BP = 0x4948;
    // MOV DX,word ptr [0x197c] (1000_B6FB / 0x1B6FB)
    DX = UInt16[DS, 0x197C];
    // MOV AX,[0x197e] (1000_B6FF / 0x1B6FF)
    AX = UInt16[DS, 0x197E];
    // SUB AX,CX (1000_B702 / 0x1B702)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // LES DI,[0xdcfe] (1000_B704 / 0x1B704)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    // MOV SI,0x4c60 (1000_B708 / 0x1B708)
    SI = 0x4C60;
    // MOV BX,word ptr [0xdbda] (1000_B70B / 0x1B70B)
    BX = UInt16[DS, 0xDBDA];
    // CALLF [0x3929] (1000_B70F / 0x1B70F)
    // Indirect call to [0x3929], generating possible targets from emulator records
    uint targetAddress_1000_B70F = (uint)(UInt16[DS, 0x392B] * 0x10 + UInt16[DS, 0x3929] - cs1 * 0x10);
    switch(targetAddress_1000_B70F) {
      case 0x23607 : FarCall(cs1, 0xB713, spice86_generated_label_call_target_334B_0157_033607); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B70F));
        break;
    }
    label_1000_B713_1B713:
    // RET  (1000_B713 / 0x1B713)
    return NearRet();
    label_1000_B714_1B714:
    // MOV DI,0x4c60 (1000_B714 / 0x1B714)
    DI = 0x4C60;
    // MOV AX,[0x46e7] (1000_B717 / 0x1B717)
    AX = UInt16[DS, 0x46E7];
    // SUB AX,word ptr [0x46e3] (1000_B71A / 0x1B71A)
    // AX -= UInt16[DS, 0x46E3];
    AX = Alu.Sub16(AX, UInt16[DS, 0x46E3]);
    // MOV DX,AX (1000_B71E / 0x1B71E)
    DX = AX;
    // SHR DX,0x1 (1000_B720 / 0x1B720)
    DX >>= 0x1;
    
    // ADD DX,word ptr [0x46e3] (1000_B722 / 0x1B722)
    // DX += UInt16[DS, 0x46E3];
    DX = Alu.Add16(DX, UInt16[DS, 0x46E3]);
    // MOV word ptr [0xdcf6],DX (1000_B726 / 0x1B726)
    UInt16[DS, 0xDCF6] = DX;
    // MOV [0xdcf2],AX (1000_B72A / 0x1B72A)
    UInt16[DS, 0xDCF2] = AX;
    // MOV AX,[0x46e9] (1000_B72D / 0x1B72D)
    AX = UInt16[DS, 0x46E9];
    // SUB AX,word ptr [0x46e5] (1000_B730 / 0x1B730)
    AX -= UInt16[DS, 0x46E5];
    
    // DEC AX (1000_B734 / 0x1B734)
    AX = Alu.Dec16(AX);
    // MOV BX,AX (1000_B735 / 0x1B735)
    BX = AX;
    // SHR BX,0x1 (1000_B737 / 0x1B737)
    BX >>= 0x1;
    
    // ADD BX,word ptr [0x46e5] (1000_B739 / 0x1B739)
    // BX += UInt16[DS, 0x46E5];
    BX = Alu.Add16(BX, UInt16[DS, 0x46E5]);
    // MOV word ptr [0xdcf8],BX (1000_B73D / 0x1B73D)
    UInt16[DS, 0xDCF8] = BX;
    // INC AX (1000_B741 / 0x1B741)
    AX = Alu.Inc16(AX);
    // MOV [0xdcf4],AX (1000_B742 / 0x1B742)
    UInt16[DS, 0xDCF4] = AX;
    // DEC AX (1000_B745 / 0x1B745)
    AX = Alu.Dec16(AX);
    // SHR AX,0x1 (1000_B746 / 0x1B746)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV CX,AX (1000_B748 / 0x1B748)
    CX = AX;
    // MOV BX,0x56 (1000_B74A / 0x1B74A)
    BX = 0x56;
    // SUB BX,AX (1000_B74D / 0x1B74D)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    // MOV AX,[0x197e] (1000_B74F / 0x1B74F)
    AX = UInt16[DS, 0x197E];
    // OR AX,AX (1000_B752 / 0x1B752)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // MOV DX,AX (1000_B754 / 0x1B754)
    DX = AX;
    // JNS 0x1000:b75a (1000_B756 / 0x1B756)
    if(!SignFlag) {
      goto label_1000_B75A_1B75A;
    }
    // NEG AX (1000_B758 / 0x1B758)
    AX = Alu.Sub16(0, AX);
    label_1000_B75A_1B75A:
    // CMP AX,BX (1000_B75A / 0x1B75A)
    Alu.Sub16(AX, BX);
    // JC 0x1000:b769 (1000_B75C / 0x1B75C)
    if(CarryFlag) {
      goto label_1000_B769_1B769;
    }
    // MOV AX,BX (1000_B75E / 0x1B75E)
    AX = BX;
    // OR DX,DX (1000_B760 / 0x1B760)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNS 0x1000:b766 (1000_B762 / 0x1B762)
    if(!SignFlag) {
      goto label_1000_B766_1B766;
    }
    // NEG AX (1000_B764 / 0x1B764)
    AX = Alu.Sub16(0, AX);
    label_1000_B766_1B766:
    // MOV [0x197e],AX (1000_B766 / 0x1B766)
    UInt16[DS, 0x197E] = AX;
    label_1000_B769_1B769:
    // MOV BP,0x4948 (1000_B769 / 0x1B769)
    BP = 0x4948;
    // MOV DX,word ptr [0x197c] (1000_B76C / 0x1B76C)
    DX = UInt16[DS, 0x197C];
    // MOV AX,[0x197e] (1000_B770 / 0x1B770)
    AX = UInt16[DS, 0x197E];
    // SUB AX,CX (1000_B773 / 0x1B773)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // PUSH AX (1000_B775 / 0x1B775)
    Stack.Push(AX);
    // MOV CX,word ptr [0xdcf4] (1000_B776 / 0x1B776)
    CX = UInt16[DS, 0xDCF4];
    // SHL AX,0x1 (1000_B77A / 0x1B77A)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_B77C / 0x1B77C)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_B77E / 0x1B77E)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // JNS 0x1000:b79c (1000_B780 / 0x1B780)
    if(!SignFlag) {
      goto label_1000_B79C_1B79C;
    }
    // NEG AX (1000_B782 / 0x1B782)
    AX = Alu.Sub16(0, AX);
    // ADD BP,AX (1000_B784 / 0x1B784)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    label_1000_B786_1B786:
    // PUSH CX (1000_B786 / 0x1B786)
    Stack.Push(CX);
    // MOV CX,word ptr [BP + 0x0] (1000_B787 / 0x1B787)
    CX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (1000_B78A / 0x1B78A)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    // NEG CX (1000_B78D / 0x1B78D)
    CX = Alu.Sub16(0, CX);
    // JZ 0x1000:b7a5 (1000_B78F / 0x1B78F)
    if(ZeroFlag) {
      goto label_1000_B7A5_1B7A5;
    }
    // CALL 0x1000:b7d2 (1000_B791 / 0x1B791)
    NearCall(cs1, 0xB794, spice86_generated_label_call_target_1000_B7D2_01B7D2);
    label_1000_B794_1B794:
    // SUB BP,0x8 (1000_B794 / 0x1B794)
    // BP -= 0x8;
    BP = Alu.Sub16(BP, 0x8);
    // POP CX (1000_B797 / 0x1B797)
    CX = Stack.Pop();
    // LOOP 0x1000:b786 (1000_B798 / 0x1B798)
    if(--CX != 0) {
      goto label_1000_B786_1B786;
    }
    // JMP 0x1000:b7ae (1000_B79A / 0x1B79A)
    goto label_1000_B7AE_1B7AE;
    label_1000_B79C_1B79C:
    // ADD BP,AX (1000_B79C / 0x1B79C)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    label_1000_B79E_1B79E:
    // PUSH CX (1000_B79E / 0x1B79E)
    Stack.Push(CX);
    // MOV CX,word ptr [BP + 0x0] (1000_B79F / 0x1B79F)
    CX = UInt16[SS, BP];
    // MOV BX,word ptr [BP + 0x2] (1000_B7A2 / 0x1B7A2)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    label_1000_B7A5_1B7A5:
    // CALL 0x1000:b7d2 (1000_B7A5 / 0x1B7A5)
    NearCall(cs1, 0xB7A8, spice86_generated_label_call_target_1000_B7D2_01B7D2);
    label_1000_B7A8_1B7A8:
    // ADD BP,0x8 (1000_B7A8 / 0x1B7A8)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    // POP CX (1000_B7AB / 0x1B7AB)
    CX = Stack.Pop();
    // LOOP 0x1000:b79e (1000_B7AC / 0x1B7AC)
    if(--CX != 0) {
      goto label_1000_B79E_1B79E;
    }
    label_1000_B7AE_1B7AE:
    // MOV ES,word ptr [0xdbda] (1000_B7AE / 0x1B7AE)
    ES = UInt16[DS, 0xDBDA];
    // MOV DI,word ptr [0xdcf2] (1000_B7B2 / 0x1B7B2)
    DI = UInt16[DS, 0xDCF2];
    // MOV CX,word ptr [0xdcf4] (1000_B7B6 / 0x1B7B6)
    CX = UInt16[DS, 0xDCF4];
    // MOV DX,word ptr [0x46e3] (1000_B7BA / 0x1B7BA)
    DX = UInt16[DS, 0x46E3];
    // MOV BX,word ptr [0x46e5] (1000_B7BE / 0x1B7BE)
    BX = UInt16[DS, 0x46E5];
    // MOV SI,0x4c60 (1000_B7C2 / 0x1B7C2)
    SI = 0x4C60;
    // POP AX (1000_B7C5 / 0x1B7C5)
    AX = Stack.Pop();
    // TEST byte ptr [0x46eb],0x40 (1000_B7C6 / 0x1B7C6)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JNZ 0x1000:b7d1 (1000_B7CB / 0x1B7CB)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_B7D1 / 0x1B7D1)
      return NearRet();
    }
    // CALLF [0x390d] (1000_B7CD / 0x1B7CD)
    // Indirect call to [0x390d], generating possible targets from emulator records
    uint targetAddress_1000_B7CD = (uint)(UInt16[DS, 0x390F] * 0x10 + UInt16[DS, 0x390D] - cs1 * 0x10);
    switch(targetAddress_1000_B7CD) {
      case 0x235F2 : FarCall(cs1, 0xB7D1, spice86_generated_label_call_target_334B_0142_0335F2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B7CD));
        break;
    }
    label_1000_B7D1_1B7D1:
    // RET  (1000_B7D1 / 0x1B7D1)
    return NearRet();
  }
  
}
