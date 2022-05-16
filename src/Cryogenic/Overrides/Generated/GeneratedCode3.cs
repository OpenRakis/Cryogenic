namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_4415_014415(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4415_14415:
    // XOR AL,AL (1000_4415 / 0x14415)
    AL = 0;
    // XCHG byte ptr [0x46eb],AL (1000_4417 / 0x14417)
    byte tmp_1000_4417 = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_4417;
    // OR AL,AL (1000_441B / 0x1441B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:4420 (1000_441D / 0x1441D)
    if(!ZeroFlag) {
      goto label_1000_4420_14420;
    }
    // RET  (1000_441F / 0x1441F)
    return NearRet();
    label_1000_4420_14420:
    // MOV word ptr [0xa5c0],0x0 (1000_4420 / 0x14420)
    UInt16[DS, 0xA5C0] = 0x0;
    // CALL 0x1000:daa3 (1000_4426 / 0x14426)
    NearCall(cs1, 0x4429, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    label_1000_4429_14429:
    // MOV SI,0x44ab (1000_4429 / 0x14429)
    SI = 0x44AB;
    // CALL 0x1000:da5f (1000_442C / 0x1442C)
    NearCall(cs1, 0x442F, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_442F_1442F:
    // CALL 0x1000:469b (1000_442F / 0x1442F)
    NearCall(cs1, 0x4432, spice86_generated_label_call_target_1000_469B_01469B);
    label_1000_4432_14432:
    // CALL 0x1000:5ba0 (1000_4432 / 0x14432)
    NearCall(cs1, 0x4435, spice86_generated_label_call_target_1000_5BA0_015BA0);
    label_1000_4435_14435:
    // CALL 0x1000:43e3 (1000_4435 / 0x14435)
    NearCall(cs1, 0x4438, spice86_generated_label_call_target_1000_43E3_0143E3);
    label_1000_4438_14438:
    // CALL 0x1000:c0f4 (1000_4438 / 0x14438)
    NearCall(cs1, 0x443B, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    label_1000_443B_1443B:
    // CMP word ptr [0x11c5],0x0 (1000_443B / 0x1443B)
    Alu.Sub16(UInt16[DS, 0x11C5], 0x0);
    // JNZ 0x1000:4447 (1000_4440 / 0x14440)
    if(!ZeroFlag) {
      goto label_1000_4447_14447;
    }
    // MOV byte ptr [0x11c9],0x0 (1000_4442 / 0x14442)
    UInt8[DS, 0x11C9] = 0x0;
    label_1000_4447_14447:
    // CALL 0x1000:d95b (1000_4447 / 0x14447)
    NearCall(cs1, 0x444A, spice86_generated_label_call_target_1000_D95B_01D95B);
    label_1000_444A_1444A:
    // CALL 0x1000:d717 (1000_444A / 0x1444A)
    NearCall(cs1, 0x444D, spice86_generated_label_call_target_1000_D717_01D717);
    label_1000_444D_1444D:
    // CALL 0x1000:2ffb (1000_444D / 0x1444D)
    NearCall(cs1, 0x4450, spice86_generated_label_call_target_1000_2FFB_012FFB);
    label_1000_4450_14450:
    // CMP byte ptr [0x4728],0x0 (1000_4450 / 0x14450)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    // JLE 0x1000:445a (1000_4455 / 0x14455)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is JMP, inlining.
      // JMP 0x1000:4ac4 (1000_445A / 0x1445A)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4AC4_014AC4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:49d4 (1000_4457 / 0x14457)
    throw FailAsUntested("Could not find a valid function at address 1000_49D4 / 0x149D4");
    label_1000_445A_1445A:
    // JMP 0x1000:4ac4 (1000_445A / 0x1445A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4AC4_014AC4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_445D_01445D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_445D_1445D:
    // MOV SI,0x44ab (1000_445D / 0x1445D)
    SI = 0x44AB;
    // CALL 0x1000:da5f (1000_4460 / 0x14460)
    NearCall(cs1, 0x4463, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_4463_14463:
    // CALL 0x1000:407e (1000_4463 / 0x14463)
    NearCall(cs1, 0x4466, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4466_14466:
    // CALL 0x1000:62d6 (1000_4466 / 0x14466)
    NearCall(cs1, 0x4469, spice86_generated_label_call_target_1000_62D6_0162D6);
    label_1000_4469_14469:
    // JNC 0x1000:4472 (1000_4469 / 0x14469)
    if(!CarryFlag) {
      goto label_1000_4472_14472;
    }
    // MOV word ptr [0x4749],0x0 (1000_446B / 0x1446B)
    UInt16[DS, 0x4749] = 0x0;
    // RET  (1000_4471 / 0x14471)
    return NearRet();
    label_1000_4472_14472:
    // CALL 0x1000:c137 (1000_4472 / 0x14472)
    NearCall(cs1, 0x4475, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_4475_14475:
    // MOV AX,0x4c (1000_4475 / 0x14475)
    AX = 0x4C;
    // CALL 0x1000:c1f4 (1000_4478 / 0x14478)
    NearCall(cs1, 0x447B, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_447B_1447B:
    // LODSW ES:SI (1000_447B / 0x1447B)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // AND AH,0xf (1000_447D / 0x1447D)
    // AH &= 0xF;
    AH = Alu.And8(AH, 0xF);
    // MOV BP,AX (1000_4480 / 0x14480)
    BP = AX;
    // LODSW ES:SI (1000_4482 / 0x14482)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_4484 / 0x14484)
    AH = 0;
    // SUB BX,AX (1000_4486 / 0x14486)
    BX -= AX;
    
    // SUB DX,0xd (1000_4488 / 0x14488)
    DX -= 0xD;
    
    // ADD BP,DX (1000_448B / 0x1448B)
    BP += DX;
    
    // ADD AX,BX (1000_448D / 0x1448D)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    // MOV DI,0x4749 (1000_448F / 0x1448F)
    DI = 0x4749;
    // MOV word ptr [DI],DX (1000_4492 / 0x14492)
    UInt16[DS, DI] = DX;
    // MOV word ptr [DI + 0x2],BX (1000_4494 / 0x14494)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    // MOV word ptr [DI + 0x4],BP (1000_4497 / 0x14497)
    UInt16[DS, (ushort)(DI + 0x4)] = BP;
    // MOV word ptr [DI + 0x6],AX (1000_449A / 0x1449A)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    // MOV SI,0x44ab (1000_449D / 0x1449D)
    SI = 0x44AB;
    // MOV BP,0x12c (1000_44A0 / 0x144A0)
    BP = 0x12C;
    // CALL 0x1000:da25 (1000_44A3 / 0x144A3)
    NearCall(cs1, 0x44A6, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_44A6_144A6:
    // MOV byte ptr [0x4751],0x0 (1000_44A6 / 0x144A6)
    UInt8[DS, 0x4751] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_44AB_0144AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_44AB_0144AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_44AB_144AB:
    // INC byte ptr [0x4751] (1000_44AB / 0x144AB)
    UInt8[DS, 0x4751] = Alu.Inc8(UInt8[DS, 0x4751]);
    // PUSH word ptr [0xdbda] (1000_44AF / 0x144AF)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_44B3 / 0x144B3)
    NearCall(cs1, 0x44B6, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_44B6_144B6:
    // CALL 0x1000:5b93 (1000_44B6 / 0x144B6)
    NearCall(cs1, 0x44B9, spice86_generated_label_ret_target_1000_5B93_015B93);
    label_1000_44B9_144B9:
    // CALL 0x1000:c137 (1000_44B9 / 0x144B9)
    NearCall(cs1, 0x44BC, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_44BC_144BC:
    // MOV SI,0x4749 (1000_44BC / 0x144BC)
    SI = 0x4749;
    // CALL 0x1000:db74 (1000_44BF / 0x144BF)
    NearCall(cs1, 0x44C2, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_44C2_144C2:
    // MOV DX,word ptr [SI] (1000_44C2 / 0x144C2)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_44C4 / 0x144C4)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_44C7 / 0x144C7)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_44CA / 0x144CA)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV SI,0xd834 (1000_44CD / 0x144CD)
    SI = 0xD834;
    // CMP BP,word ptr [SI + 0x4] (1000_44D0 / 0x144D0)
    Alu.Sub16(BP, UInt16[DS, (ushort)(SI + 0x4)]);
    // JC 0x1000:44d8 (1000_44D3 / 0x144D3)
    if(CarryFlag) {
      goto label_1000_44D8_144D8;
    }
    // MOV BP,word ptr [SI + 0x4] (1000_44D5 / 0x144D5)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    label_1000_44D8_144D8:
    // CMP AX,word ptr [SI + 0x6] (1000_44D8 / 0x144D8)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JC 0x1000:44e0 (1000_44DB / 0x144DB)
    if(CarryFlag) {
      goto label_1000_44E0_144E0;
    }
    // MOV AX,word ptr [SI + 0x6] (1000_44DD / 0x144DD)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    label_1000_44E0_144E0:
    // CMP DX,word ptr [SI] (1000_44E0 / 0x144E0)
    Alu.Sub16(DX, UInt16[DS, SI]);
    // JNC 0x1000:44e6 (1000_44E2 / 0x144E2)
    if(!CarryFlag) {
      goto label_1000_44E6_144E6;
    }
    // MOV DX,word ptr [SI] (1000_44E4 / 0x144E4)
    DX = UInt16[DS, SI];
    label_1000_44E6_144E6:
    // CMP BX,word ptr [SI + 0x2] (1000_44E6 / 0x144E6)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNC 0x1000:44ee (1000_44E9 / 0x144E9)
    if(!CarryFlag) {
      goto label_1000_44EE_144EE;
    }
    // MOV BX,word ptr [SI + 0x2] (1000_44EB / 0x144EB)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    label_1000_44EE_144EE:
    // CALL 0x1000:c4fb (1000_44EE / 0x144EE)
    NearCall(cs1, 0x44F1, spice86_generated_label_call_target_1000_C4FB_01C4FB);
    label_1000_44F1_144F1:
    // MOV BL,byte ptr [0x4751] (1000_44F1 / 0x144F1)
    BL = UInt8[DS, 0x4751];
    // SHR BL,0x1 (1000_44F5 / 0x144F5)
    // BL >>= 0x1;
    BL = Alu.Shr8(BL, 0x1);
    // JNC 0x1000:4507 (1000_44F7 / 0x144F7)
    if(!CarryFlag) {
      goto label_1000_4507_14507;
    }
    // MOV AX,0x4c (1000_44F9 / 0x144F9)
    AX = 0x4C;
    // MOV DX,word ptr [0x4749] (1000_44FC / 0x144FC)
    DX = UInt16[DS, 0x4749];
    // MOV BX,word ptr [0x474b] (1000_4500 / 0x14500)
    BX = UInt16[DS, 0x474B];
    // CALL 0x1000:c30d (1000_4504 / 0x14504)
    NearCall(cs1, 0x4507, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_4507_14507:
    // POP word ptr [0xdbda] (1000_4507 / 0x14507)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // JMP 0x1000:db67 (1000_450B / 0x1450B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_450E_01450E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_450E_1450E:
    // TEST byte ptr [0x11c9],0xf (1000_450E / 0x1450E)
    Alu.And8(UInt8[DS, 0x11C9], 0xF);
    // JZ 0x1000:4533 (1000_4513 / 0x14513)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4533 / 0x14533)
      return NearRet();
    }
    // PUSH BX (1000_4515 / 0x14515)
    Stack.Push(BX);
    // PUSH DX (1000_4516 / 0x14516)
    Stack.Push(DX);
    // CALL 0x1000:4586 (1000_4517 / 0x14517)
    NearCall(cs1, 0x451A, spice86_generated_label_call_target_1000_4586_014586);
    label_1000_451A_1451A:
    // POP DX (1000_451A / 0x1451A)
    DX = Stack.Pop();
    // POP BX (1000_451B / 0x1451B)
    BX = Stack.Pop();
    // MOV DI,word ptr [0x46fc] (1000_451C / 0x1451C)
    DI = UInt16[DS, 0x46FC];
    // OR DI,DI (1000_4520 / 0x14520)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:4533 (1000_4522 / 0x14522)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4533 / 0x14533)
      return NearRet();
    }
    // JS 0x1000:4534 (1000_4524 / 0x14524)
    if(SignFlag) {
      goto label_1000_4534_14534;
    }
    // TEST byte ptr [0x11c9],0x3 (1000_4526 / 0x14526)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JNZ 0x1000:4534 (1000_452B / 0x1452B)
    if(!ZeroFlag) {
      goto label_1000_4534_14534;
    }
    // CMP DI,word ptr [0x114e] (1000_452D / 0x1452D)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JNZ 0x1000:4534 (1000_4531 / 0x14531)
    if(!ZeroFlag) {
      goto label_1000_4534_14534;
    }
    label_1000_4533_14533:
    // RET  (1000_4533 / 0x14533)
    return NearRet();
    label_1000_4534_14534:
    // PUSH BX (1000_4534 / 0x14534)
    Stack.Push(BX);
    // PUSH DX (1000_4535 / 0x14535)
    Stack.Push(DX);
    // PUSH DI (1000_4536 / 0x14536)
    Stack.Push(DI);
    // CALL 0x1000:456c (1000_4537 / 0x14537)
    NearCall(cs1, 0x453A, spice86_generated_label_call_target_1000_456C_01456C);
    label_1000_453A_1453A:
    // CALL 0x1000:ab45 (1000_453A / 0x1453A)
    NearCall(cs1, 0x453D, spice86_generated_label_call_target_1000_AB45_01AB45);
    label_1000_453D_1453D:
    // POP DI (1000_453D / 0x1453D)
    DI = Stack.Pop();
    // MOV CX,0x9 (1000_453E / 0x1453E)
    CX = 0x9;
    label_1000_4541_14541:
    // PUSH CX (1000_4541 / 0x14541)
    Stack.Push(CX);
    // PUSH DI (1000_4542 / 0x14542)
    Stack.Push(DI);
    // MOV AX,0x14 (1000_4543 / 0x14543)
    AX = 0x14;
    // CALL 0x1000:e3a0 (1000_4546 / 0x14546)
    NearCall(cs1, 0x4549, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    label_1000_4549_14549:
    // PUSH DI (1000_4549 / 0x14549)
    Stack.Push(DI);
    // XOR DI,DI (1000_454A / 0x1454A)
    DI = 0;
    // CALL 0x1000:45de (1000_454C / 0x1454C)
    NearCall(cs1, 0x454F, spice86_generated_label_call_target_1000_45DE_0145DE);
    label_1000_454F_1454F:
    // POP DI (1000_454F / 0x1454F)
    DI = Stack.Pop();
    // MOV AX,0xa (1000_4550 / 0x14550)
    AX = 0xA;
    // CALL 0x1000:e3a0 (1000_4553 / 0x14553)
    NearCall(cs1, 0x4556, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    label_1000_4556_14556:
    // CALL 0x1000:45de (1000_4556 / 0x14556)
    NearCall(cs1, 0x4559, spice86_generated_label_call_target_1000_45DE_0145DE);
    label_1000_4559_14559:
    // POP DI (1000_4559 / 0x14559)
    DI = Stack.Pop();
    // POP CX (1000_455A / 0x1455A)
    CX = Stack.Pop();
    // LOOP 0x1000:4541 (1000_455B / 0x1455B)
    if(--CX != 0) {
      goto label_1000_4541_14541;
    }
    // PUSH DI (1000_455D / 0x1455D)
    Stack.Push(DI);
    // CALL 0x1000:aba9 (1000_455E / 0x1455E)
    NearCall(cs1, 0x4561, spice86_generated_label_call_target_1000_ABA9_01ABA9);
    label_1000_4561_14561:
    // POP DI (1000_4561 / 0x14561)
    DI = Stack.Pop();
    // POP DX (1000_4562 / 0x14562)
    DX = Stack.Pop();
    // POP BX (1000_4563 / 0x14563)
    BX = Stack.Pop();
    // MOV byte ptr [0x4732],0x80 (1000_4564 / 0x14564)
    UInt8[DS, 0x4732] = 0x80;
    // JMP 0x1000:4703 (1000_4569 / 0x14569)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_4703_014703, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_456C_01456C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_456C_1456C:
    // MOV AX,DI (1000_456C / 0x1456C)
    AX = DI;
    // CMP AH,0xff (1000_456E / 0x1456E)
    Alu.Sub8(AH, 0xFF);
    // JZ 0x1000:4582 (1000_4571 / 0x14571)
    if(ZeroFlag) {
      goto label_1000_4582_14582;
    }
    // MOV AX,word ptr [DI] (1000_4573 / 0x14573)
    AX = UInt16[DS, DI];
    // DEC AX (1000_4575 / 0x14575)
    AX = Alu.Dec16(AX);
    // SHL AL,0x1 (1000_4576 / 0x14576)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_4578 / 0x14578)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_457A / 0x1457A)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_457C / 0x1457C)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // OR AL,AH (1000_457E / 0x1457E)
    AL |= AH;
    
    // XOR AH,AH (1000_4580 / 0x14580)
    AH = 0;
    label_1000_4582_14582:
    // ADD AX,0x2bc (1000_4582 / 0x14582)
    // AX += 0x2BC;
    AX = Alu.Add16(AX, 0x2BC);
    // RET  (1000_4585 / 0x14585)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4586_014586(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4586_14586:
    // CALL 0x1000:5d1d (1000_4586 / 0x14586)
    NearCall(cs1, 0x4589, spice86_generated_label_call_target_1000_5D1D_015D1D);
    label_1000_4589_14589:
    // MOV DI,0x0 (1000_4589 / 0x14589)
    DI = 0x0;
    // JNC 0x1000:45d3 (1000_458C / 0x1458C)
    if(!CarryFlag) {
      goto label_1000_45D3_145D3;
    }
    // MOV AL,0xff (1000_458E / 0x1458E)
    AL = 0xFF;
    // CALL 0x1000:5e6d (1000_4590 / 0x14590)
    NearCall(cs1, 0x4593, spice86_generated_label_call_target_1000_5E6D_015E6D);
    label_1000_4593_14593:
    // CMP AX,0x9 (1000_4593 / 0x14593)
    Alu.Sub16(AX, 0x9);
    // JC 0x1000:45d3 (1000_4596 / 0x14596)
    if(CarryFlag) {
      goto label_1000_45D3_145D3;
    }
    // MOV DI,0xffff (1000_4598 / 0x14598)
    DI = 0xFFFF;
    // MOV DX,word ptr [0x4749] (1000_459B / 0x1459B)
    DX = UInt16[DS, 0x4749];
    // OR DX,DX (1000_459F / 0x1459F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:45d3 (1000_45A1 / 0x145A1)
    if(ZeroFlag) {
      goto label_1000_45D3_145D3;
    }
    // ADD DX,0xb (1000_45A3 / 0x145A3)
    DX += 0xB;
    
    // SUB DX,word ptr [0xdc36] (1000_45A6 / 0x145A6)
    DX -= UInt16[DS, 0xDC36];
    
    // NEG DX (1000_45AA / 0x145AA)
    DX = Alu.Sub16(0, DX);
    // MOV BX,word ptr [0xdc38] (1000_45AC / 0x145AC)
    BX = UInt16[DS, 0xDC38];
    // SUB BX,word ptr [0x474f] (1000_45B0 / 0x145B0)
    // BX -= UInt16[DS, 0x474F];
    BX = Alu.Sub16(BX, UInt16[DS, 0x474F]);
    // CALL 0x1000:514e (1000_45B4 / 0x145B4)
    NearCall(cs1, 0x45B7, spice86_generated_label_call_target_1000_514E_01514E);
    label_1000_45B7_145B7:
    // ADD AL,0x3 (1000_45B7 / 0x145B7)
    // AL += 0x3;
    AL = Alu.Add8(AL, 0x3);
    // MOV AH,AL (1000_45B9 / 0x145B9)
    AH = AL;
    // AND AH,0x1f (1000_45BB / 0x145BB)
    AH &= 0x1F;
    
    // CMP AH,0x6 (1000_45BE / 0x145BE)
    Alu.Sub8(AH, 0x6);
    // MOV DI,0xffff (1000_45C1 / 0x145C1)
    DI = 0xFFFF;
    // JNC 0x1000:45d3 (1000_45C4 / 0x145C4)
    if(!CarryFlag) {
      goto label_1000_45D3_145D3;
    }
    // ROL AL,0x1 (1000_45C6 / 0x145C6)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,0x1 (1000_45C8 / 0x145C8)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,0x1 (1000_45CA / 0x145CA)
    AL = Alu.Rol8(AL, 0x1);
    // AND AL,0x7 (1000_45CC / 0x145CC)
    // AL &= 0x7;
    AL = Alu.And8(AL, 0x7);
    // OR AX,0xfff0 (1000_45CE / 0x145CE)
    // AX |= 0xFFF0;
    AX = Alu.Or16(AX, 0xFFF0);
    // MOV DI,AX (1000_45D1 / 0x145D1)
    DI = AX;
    label_1000_45D3_145D3:
    // MOV AX,DI (1000_45D3 / 0x145D3)
    AX = DI;
    // XCHG word ptr [0x46fc],AX (1000_45D5 / 0x145D5)
    ushort tmp_1000_45D5 = UInt16[DS, 0x46FC];
    UInt16[DS, 0x46FC] = AX;
    AX = tmp_1000_45D5;
    // CMP AX,DI (1000_45D9 / 0x145D9)
    Alu.Sub16(AX, DI);
    // JNZ 0x1000:45de (1000_45DB / 0x145DB)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_45DE_0145DE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_45DD / 0x145DD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_45DE_0145DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_45DE_145DE:
    // PUSH word ptr [0xdbda] (1000_45DE / 0x145DE)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_45E2 / 0x145E2)
    NearCall(cs1, 0x45E5, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_45E5_145E5:
    // CALL 0x1000:dbb2 (1000_45E5 / 0x145E5)
    NearCall(cs1, 0x45E8, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_45E8_145E8:
    // CALL 0x1000:d075 (1000_45E8 / 0x145E8)
    NearCall(cs1, 0x45EB, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_45EB_145EB:
    // MOV DX,0x55 (1000_45EB / 0x145EB)
    DX = 0x55;
    // MOV BX,0x22 (1000_45EE / 0x145EE)
    BX = 0x22;
    // MOV CX,0xf5fe (1000_45F1 / 0x145F1)
    CX = 0xF5FE;
    // CMP byte ptr [0x473e],0x0 (1000_45F4 / 0x145F4)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    // JZ 0x1000:4600 (1000_45F9 / 0x145F9)
    if(ZeroFlag) {
      goto label_1000_4600_14600;
    }
    // ADD BX,0x4 (1000_45FB / 0x145FB)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    // MOV CH,0x20 (1000_45FE / 0x145FE)
    CH = 0x20;
    label_1000_4600_14600:
    // OR DI,DI (1000_4600 / 0x14600)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:462a (1000_4602 / 0x14602)
    if(ZeroFlag) {
      goto label_1000_462A_1462A;
    }
    // CALL 0x1000:469b (1000_4604 / 0x14604)
    NearCall(cs1, 0x4607, spice86_generated_label_call_target_1000_469B_01469B);
    label_1000_4607_14607:
    // CMP DI,-0x10 (1000_4607 / 0x14607)
    Alu.Sub16(DI, 0xFFF0);
    // JC 0x1000:4636 (1000_460A / 0x1460A)
    if(CarryFlag) {
      goto label_1000_4636_14636;
    }
    // MOV AX,0xa4 (1000_460C / 0x1460C)
    AX = 0xA4;
    // CALL 0x1000:d194 (1000_460F / 0x1460F)
    NearCall(cs1, 0x4612, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_4612_14612:
    // SUB DI,-0x10 (1000_4612 / 0x14612)
    DI -= 0xFFF0;
    
    // CMP DI,0x8 (1000_4615 / 0x14615)
    Alu.Sub16(DI, 0x8);
    // JNC 0x1000:4641 (1000_4618 / 0x14618)
    if(!CarryFlag) {
      goto label_1000_4641_14641;
    }
    // MOV AL,0x20 (1000_461A / 0x1461A)
    AL = 0x20;
    // CALL word ptr [0x2518] (1000_461C / 0x1461C)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_461C = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_461C) {
      case 0xD12F : NearCall(cs1, 0x4620, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_461C));
        break;
    }
    label_1000_4620_14620:
    // MOV AX,DI (1000_4620 / 0x14620)
    AX = DI;
    // ADD AX,0xda (1000_4622 / 0x14622)
    // AX += 0xDA;
    AX = Alu.Add16(AX, 0xDA);
    // CALL 0x1000:d19b (1000_4625 / 0x14625)
    NearCall(cs1, 0x4628, spice86_generated_label_ret_target_1000_D19B_01D19B);
    label_1000_4628_14628:
    // JMP 0x1000:4641 (1000_4628 / 0x14628)
    goto label_1000_4641_14641;
    label_1000_462A_1462A:
    // CALL 0x1000:4658 (1000_462A / 0x1462A)
    NearCall(cs1, 0x462D, spice86_generated_label_call_target_1000_4658_014658);
    label_1000_462D_1462D:
    // MOV word ptr [0xdbe4],CX (1000_462D / 0x1462D)
    UInt16[DS, 0xDBE4] = CX;
    // CALL 0x1000:d04e (1000_4631 / 0x14631)
    NearCall(cs1, 0x4634, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_4634_14634:
    // JMP 0x1000:4641 (1000_4634 / 0x14634)
    goto label_1000_4641_14641;
    label_1000_4636_14636:
    // PUSH CX (1000_4636 / 0x14636)
    Stack.Push(CX);
    // CALL 0x1000:629d (1000_4637 / 0x14637)
    NearCall(cs1, 0x463A, spice86_generated_label_call_target_1000_629D_01629D);
    label_1000_463A_1463A:
    // CALL 0x1000:d05f (1000_463A / 0x1463A)
    NearCall(cs1, 0x463D, spice86_generated_label_call_target_1000_D05F_01D05F);
    label_1000_463D_1463D:
    // POP CX (1000_463D / 0x1463D)
    CX = Stack.Pop();
    // CALL 0x1000:62a6 (1000_463E / 0x1463E)
    NearCall(cs1, 0x4641, spice86_generated_label_call_target_1000_62A6_0162A6);
    label_1000_4641_14641:
    // CMP word ptr [0xd82c],0xed (1000_4641 / 0x14641)
    Alu.Sub16(UInt16[DS, 0xD82C], 0xED);
    // JA 0x1000:4651 (1000_4647 / 0x14647)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_4651_14651;
    }
    // MOV AL,0x20 (1000_4649 / 0x14649)
    AL = 0x20;
    // CALL word ptr [0x2518] (1000_464B / 0x1464B)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_464B = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_464B) {
      case 0xD12F : NearCall(cs1, 0x464F, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_464B));
        break;
    }
    label_1000_464F_1464F:
    // JMP 0x1000:4641 (1000_464F / 0x1464F)
    goto label_1000_4641_14641;
    label_1000_4651_14651:
    // POP word ptr [0xdbda] (1000_4651 / 0x14651)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // JMP 0x1000:dbec (1000_4655 / 0x14655)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_4658_014658(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4658_14658:
    // CMP word ptr [0x473f],0x0 (1000_4658 / 0x14658)
    Alu.Sub16(UInt16[DS, 0x473F], 0x0);
    // JNZ 0x1000:469a (1000_465D / 0x1465D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_469A / 0x1469A)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_465F / 0x1465F)
    NearCall(cs1, 0x4662, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_4662_14662:
    // MOV SI,0x57 (1000_4662 / 0x14662)
    SI = 0x57;
    // CALL 0x1000:cf70 (1000_4665 / 0x14665)
    NearCall(cs1, 0x4668, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_4668_14668:
    // MOV word ptr [0x4741],ES (1000_4668 / 0x14668)
    UInt16[DS, 0x4741] = ES;
    // MOV word ptr [0x473f],SI (1000_466C / 0x1466C)
    UInt16[DS, 0x473F] = SI;
    // MOV word ptr [0x4743],0x55 (1000_4670 / 0x14670)
    UInt16[DS, 0x4743] = 0x55;
    // MOV CX,0xf561 (1000_4676 / 0x14676)
    CX = 0xF561;
    // MOV AX,0x22 (1000_4679 / 0x14679)
    AX = 0x22;
    // CMP byte ptr [0x473e],0x0 (1000_467C / 0x1467C)
    Alu.Sub8(UInt8[DS, 0x473E], 0x0);
    // JZ 0x1000:4687 (1000_4681 / 0x14681)
    if(ZeroFlag) {
      goto label_1000_4687_14687;
    }
    // ADD AL,0x4 (1000_4683 / 0x14683)
    // AL += 0x4;
    AL = Alu.Add8(AL, 0x4);
    // MOV CH,0x20 (1000_4685 / 0x14685)
    CH = 0x20;
    label_1000_4687_14687:
    // MOV [0x4745],AX (1000_4687 / 0x14687)
    UInt16[DS, 0x4745] = AX;
    // MOV word ptr [0x4747],CX (1000_468A / 0x1468A)
    UInt16[DS, 0x4747] = CX;
    // MOV SI,0x46b5 (1000_468E / 0x1468E)
    SI = 0x46B5;
    // MOV BP,0x18 (1000_4691 / 0x14691)
    BP = 0x18;
    // CALL 0x1000:da25 (1000_4694 / 0x14694)
    NearCall(cs1, 0x4697, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_4697_14697:
    // CALL 0x1000:e283 (1000_4697 / 0x14697)
    NearCall(cs1, 0x469A, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_469A_1469A:
    // RET  (1000_469A / 0x1469A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_469B_01469B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_469B_1469B:
    // CMP word ptr [0x473f],0x0 (1000_469B / 0x1469B)
    Alu.Sub16(UInt16[DS, 0x473F], 0x0);
    // JZ 0x1000:46b4 (1000_46A0 / 0x146A0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_46B4 / 0x146B4)
      return NearRet();
    }
    // MOV word ptr [0x473f],0x0 (1000_46A2 / 0x146A2)
    UInt16[DS, 0x473F] = 0x0;
    // CALL 0x1000:e270 (1000_46A8 / 0x146A8)
    NearCall(cs1, 0x46AB, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_46AB_146AB:
    // MOV SI,0x46b5 (1000_46AB / 0x146AB)
    SI = 0x46B5;
    // CALL 0x1000:da5f (1000_46AE / 0x146AE)
    NearCall(cs1, 0x46B1, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_46B1_146B1:
    // CALL 0x1000:e283 (1000_46B1 / 0x146B1)
    NearCall(cs1, 0x46B4, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_46B4_146B4:
    // RET  (1000_46B4 / 0x146B4)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_46B5_0146B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_46B5_146B5:
    // LES SI,[0x473f] (1000_46B5 / 0x146B5)
    ES = UInt16[DS, 0x4741];
    SI = UInt16[DS, 0x473F];
    // MOV AL,byte ptr ES:[SI] (1000_46B9 / 0x146B9)
    AL = UInt8[ES, SI];
    // OR AL,AL (1000_46BC / 0x146BC)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x1000:4702 (1000_46BE / 0x146BE)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_4702 / 0x14702)
      return NearRet();
    }
    // INC word ptr [0x473f] (1000_46C0 / 0x146C0)
    UInt16[DS, 0x473F] = Alu.Inc16(UInt16[DS, 0x473F]);
    // MOV SI,0x14a4 (1000_46C4 / 0x146C4)
    SI = 0x14A4;
    // CALL 0x1000:db74 (1000_46C7 / 0x146C7)
    NearCall(cs1, 0x46CA, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_46CA_146CA:
    // PUSH word ptr [0xdbda] (1000_46CA / 0x146CA)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_46CE / 0x146CE)
    NearCall(cs1, 0x46D1, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_46D1_146D1:
    // MOV DX,word ptr [0x4743] (1000_46D1 / 0x146D1)
    DX = UInt16[DS, 0x4743];
    // MOV BX,word ptr [0x4745] (1000_46D5 / 0x146D5)
    BX = UInt16[DS, 0x4745];
    // CALL 0x1000:d04e (1000_46D9 / 0x146D9)
    NearCall(cs1, 0x46DC, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_46DC_146DC:
    // MOV CX,word ptr [0x4747] (1000_46DC / 0x146DC)
    CX = UInt16[DS, 0x4747];
    // MOV word ptr [0xdbe4],CX (1000_46E0 / 0x146E0)
    UInt16[DS, 0xDBE4] = CX;
    // CALL 0x1000:d075 (1000_46E4 / 0x146E4)
    NearCall(cs1, 0x46E7, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_46E7_146E7:
    // PUSH AX (1000_46E7 / 0x146E7)
    Stack.Push(AX);
    // CALL 0x1000:d12f (1000_46E8 / 0x146E8)
    NearCall(cs1, 0x46EB, spice86_generated_label_call_target_1000_D12F_01D12F);
    label_1000_46EB_146EB:
    // CALL 0x1000:d05f (1000_46EB / 0x146EB)
    NearCall(cs1, 0x46EE, spice86_generated_label_call_target_1000_D05F_01D05F);
    label_1000_46EE_146EE:
    // MOV word ptr [0x4743],DX (1000_46EE / 0x146EE)
    UInt16[DS, 0x4743] = DX;
    // MOV word ptr [0x4745],BX (1000_46F2 / 0x146F2)
    UInt16[DS, 0x4745] = BX;
    // POP AX (1000_46F6 / 0x146F6)
    AX = Stack.Pop();
    // POP word ptr [0xdbda] (1000_46F7 / 0x146F7)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // CALL 0x1000:db67 (1000_46FB / 0x146FB)
    NearCall(cs1, 0x46FE, spice86_generated_label_call_target_1000_DB67_01DB67);
    label_1000_46FE_146FE:
    // CMP AL,0x20 (1000_46FE / 0x146FE)
    Alu.Sub8(AL, 0x20);
    // JZ 0x1000:46b5 (1000_4700 / 0x14700)
    if(ZeroFlag) {
      goto label_1000_46B5_146B5;
    }
    label_1000_4702_14702:
    // RET  (1000_4702 / 0x14702)
    return NearRet();
  }
  
  public Action split_1000_4703_014703(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4703_14703:
    // CALL 0x1000:4944 (1000_4703 / 0x14703)
    NearCall(cs1, 0x4706, spice86_generated_label_call_target_1000_4944_014944);
    label_1000_4706_14706:
    // CALL 0x1000:38e1 (1000_4706 / 0x14706)
    NearCall(cs1, 0x4709, spice86_generated_label_call_target_1000_38E1_0138E1);
    label_1000_4709_14709:
    // MOV AL,[0x11c9] (1000_4709 / 0x14709)
    AL = UInt8[DS, 0x11C9];
    // PUSH AX (1000_470C / 0x1470C)
    Stack.Push(AX);
    // SHR AL,0x1 (1000_470D / 0x1470D)
    AL >>= 0x1;
    
    // SHR AL,0x1 (1000_470F / 0x1470F)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // OR byte ptr [0x11c9],AL (1000_4711 / 0x14711)
    // UInt8[DS, 0x11C9] |= AL;
    UInt8[DS, 0x11C9] = Alu.Or8(UInt8[DS, 0x11C9], AL);
    // CALL 0x1000:ad5e (1000_4715 / 0x14715)
    NearCall(cs1, 0x4718, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    label_1000_4718_14718:
    // CMP byte ptr [0x2b],0x0 (1000_4718 / 0x14718)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:4727 (1000_471D / 0x1471D)
    if(ZeroFlag) {
      goto label_1000_4727_14727;
    }
    // MOV byte ptr [0x2b],0x0 (1000_471F / 0x1471F)
    UInt8[DS, 0x2B] = 0x0;
    // CALL 0x1000:0b21 (1000_4724 / 0x14724)
    NearCall(cs1, 0x4727, spice86_generated_label_call_target_1000_0B21_010B21);
    label_1000_4727_14727:
    // CALL 0x1000:d2ea (1000_4727 / 0x14727)
    NearCall(cs1, 0x472A, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    label_1000_472A_1472A:
    // CALL 0x1000:4d00 (1000_472A / 0x1472A)
    NearCall(cs1, 0x472D, spice86_generated_label_call_target_1000_4D00_014D00);
    label_1000_472D_1472D:
    // POP AX (1000_472D / 0x1472D)
    AX = Stack.Pop();
    // TEST AL,0x3 (1000_472E / 0x1472E)
    Alu.And8(AL, 0x3);
    // JNZ 0x1000:478f (1000_4730 / 0x14730)
    if(!ZeroFlag) {
      goto label_1000_478F_1478F;
    }
    // MOV word ptr [0x472b],0x0 (1000_4732 / 0x14732)
    UInt16[DS, 0x472B] = 0x0;
    // PUSH AX (1000_4738 / 0x14738)
    Stack.Push(AX);
    // CALL 0x1000:41c5 (1000_4739 / 0x14739)
    NearCall(cs1, 0x473C, spice86_generated_label_call_target_1000_41C5_0141C5);
    label_1000_473C_1473C:
    // MOV AL,[0x11c9] (1000_473C / 0x1473C)
    AL = UInt8[DS, 0x11C9];
    // AND AL,0x3 (1000_473F / 0x1473F)
    AL &= 0x3;
    
    // DEC AL (1000_4741 / 0x14741)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:4748 (1000_4743 / 0x14743)
    if(!ZeroFlag) {
      goto label_1000_4748_14748;
    }
    // CALL 0x1000:181e (1000_4745 / 0x14745)
    NearCall(cs1, 0x4748, spice86_generated_label_call_target_1000_181E_01181E);
    label_1000_4748_14748:
    // CALL 0x1000:c474 (1000_4748 / 0x14748)
    NearCall(cs1, 0x474B, spice86_generated_label_call_target_1000_C474_01C474);
    label_1000_474B_1474B:
    // CALL 0x1000:40d5 (1000_474B / 0x1474B)
    NearCall(cs1, 0x474E, spice86_generated_label_call_target_1000_40D5_0140D5);
    label_1000_474E_1474E:
    // POP AX (1000_474E / 0x1474E)
    AX = Stack.Pop();
    // MOV BL,byte ptr [0x11c7] (1000_474F / 0x1474F)
    BL = UInt8[DS, 0x11C7];
    // PUSH BX (1000_4753 / 0x14753)
    Stack.Push(BX);
    // CALL 0x1000:4795 (1000_4754 / 0x14754)
    NearCall(cs1, 0x4757, spice86_generated_label_call_target_1000_4795_014795);
    label_1000_4757_14757:
    // POP AX (1000_4757 / 0x14757)
    AX = Stack.Pop();
    // MOV [0x11c7],AL (1000_4758 / 0x14758)
    UInt8[DS, 0x11C7] = AL;
    // MOV byte ptr [0x8],0xff (1000_475B / 0x1475B)
    UInt8[DS, 0x8] = 0xFF;
    // CALL 0x1000:4b3b (1000_4760 / 0x14760)
    NearCall(cs1, 0x4763, spice86_generated_label_call_target_1000_4B3B_014B3B);
    label_1000_4763_14763:
    // MOV word ptr [0x114e],0x0 (1000_4763 / 0x14763)
    UInt16[DS, 0x114E] = 0x0;
    // MOV word ptr [0x4729],0x0 (1000_4769 / 0x14769)
    UInt16[DS, 0x4729] = 0x0;
    // CMP byte ptr [0x46eb],0x0 (1000_476F / 0x1476F)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:4779 (1000_4774 / 0x14774)
    if(SignFlag) {
      goto label_1000_4779_14779;
    }
    // CALL 0x1000:2dbf (1000_4776 / 0x14776)
    NearCall(cs1, 0x4779, spice86_generated_label_call_target_1000_2DBF_012DBF);
    label_1000_4779_14779:
    // CALL 0x1000:4ab8 (1000_4779 / 0x14779)
    NearCall(cs1, 0x477C, spice86_generated_label_call_target_1000_4AB8_014AB8);
    label_1000_477C_1477C:
    // MOV AL,[0x11c9] (1000_477C / 0x1477C)
    AL = UInt8[DS, 0x11C9];
    // AND AL,0x3 (1000_477F / 0x1477F)
    AL &= 0x3;
    
    // DEC AL (1000_4781 / 0x14781)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:478f (1000_4783 / 0x14783)
    if(!ZeroFlag) {
      goto label_1000_478F_1478F;
    }
    // MOV DI,word ptr [0x1150] (1000_4785 / 0x14785)
    DI = UInt16[DS, 0x1150];
    // DEC byte ptr [DI + 0x15] (1000_4789 / 0x14789)
    UInt8[DS, (ushort)(DI + 0x15)] = Alu.Dec8(UInt8[DS, (ushort)(DI + 0x15)]);
    // JMP 0x1000:ac14 (1000_478C / 0x1478C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AC14_01AC14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_478F_1478F:
    // CALL 0x1000:2eb2 (1000_478F / 0x1478F)
    NearCall(cs1, 0x4792, spice86_generated_label_call_target_1000_2EB2_012EB2);
    // JMP 0x1000:c0f4 (1000_4792 / 0x14792)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_4795_014795(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4795_14795:
    // CMP byte ptr [0x46eb],0x0 (1000_4795 / 0x14795)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:47cd (1000_479A / 0x1479A)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_47CD / 0x147CD)
      return NearRet();
    }
    // CMP AL,0x4 (1000_479C / 0x1479C)
    Alu.Sub8(AL, 0x4);
    // JZ 0x1000:47ce (1000_479E / 0x1479E)
    if(ZeroFlag) {
      goto label_1000_47CE_147CE;
    }
    // CALL 0x1000:98af (1000_47A0 / 0x147A0)
    throw FailAsUntested("Could not find a valid function at address 1000_98AF / 0x198AF");
    // MOV byte ptr [0xcee8],0x0 (1000_47A3 / 0x147A3)
    UInt8[DS, 0xCEE8] = 0x0;
    // MOV AL,0x50 (1000_47A8 / 0x147A8)
    AL = 0x50;
    // CALL 0x1000:121f (1000_47AA / 0x147AA)
    NearCall(cs1, 0x47AD, split_1000_121F_01121F);
    // MOV byte ptr [0xe8],0x0 (1000_47AD / 0x147AD)
    UInt8[DS, 0xE8] = 0x0;
    // CALL 0x1000:1797 (1000_47B2 / 0x147B2)
    NearCall(cs1, 0x47B5, spice86_generated_label_call_target_1000_1797_011797);
    // MOV AL,0x10 (1000_47B5 / 0x147B5)
    AL = 0x10;
    // MOV BP,0x4913 (1000_47B7 / 0x147B7)
    BP = 0x4913;
    // CALL 0x1000:c108 (1000_47BA / 0x147BA)
    NearCall(cs1, 0x47BD, spice86_generated_label_call_target_1000_C108_01C108);
    // MOV byte ptr [0x227d],0x1 (1000_47BD / 0x147BD)
    UInt8[DS, 0x227D] = 0x1;
    // CALL 0x1000:491c (1000_47C2 / 0x147C2)
    throw FailAsUntested("Could not find a valid function at address 1000_491C / 0x1491C");
    // MOV byte ptr [0x227d],0x0 (1000_47C5 / 0x147C5)
    UInt8[DS, 0x227D] = 0x0;
    // JMP 0x1000:ac14 (1000_47CA / 0x147CA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AC14_01AC14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_47CD_147CD:
    // RET  (1000_47CD / 0x147CD)
    return NearRet();
    label_1000_47CE_147CE:
    // CALL 0x1000:ce53 (1000_47CE / 0x147CE)
    NearCall(cs1, 0x47D1, spice86_generated_label_call_target_1000_CE53_01CE53);
    label_1000_47D1_147D1:
    // XOR AL,AL (1000_47D1 / 0x147D1)
    AL = 0;
    // XCHG byte ptr [0x4732],AL (1000_47D3 / 0x147D3)
    byte tmp_1000_47D3 = UInt8[DS, 0x4732];
    UInt8[DS, 0x4732] = AL;
    AL = tmp_1000_47D3;
    // SHL AL,0x1 (1000_47D7 / 0x147D7)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JNC 0x1000:47cd (1000_47D9 / 0x147D9)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_47CD / 0x147CD)
      return NearRet();
    }
    // CALL 0x1000:181e (1000_47DB / 0x147DB)
    NearCall(cs1, 0x47DE, spice86_generated_label_call_target_1000_181E_01181E);
    label_1000_47DE_147DE:
    // MOV byte ptr [0x4731],0xff (1000_47DE / 0x147DE)
    UInt8[DS, 0x4731] = 0xFF;
    // CALL 0x1000:c07c (1000_47E3 / 0x147E3)
    NearCall(cs1, 0x47E6, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_47E6_147E6:
    // CALL 0x1000:37b2 (1000_47E6 / 0x147E6)
    NearCall(cs1, 0x47E9, spice86_generated_label_call_target_1000_37B2_0137B2);
    label_1000_47E9_147E9:
    // CALL 0x1000:c412 (1000_47E9 / 0x147E9)
    NearCall(cs1, 0x47EC, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_47EC_147EC:
    // CALL 0x1000:5ba0 (1000_47EC / 0x147EC)
    NearCall(cs1, 0x47EF, spice86_generated_label_call_target_1000_5BA0_015BA0);
    label_1000_47EF_147EF:
    // MOV byte ptr [0x4731],0x0 (1000_47EF / 0x147EF)
    UInt8[DS, 0x4731] = 0x0;
    // MOV AL,0x6 (1000_47F4 / 0x147F4)
    AL = 0x6;
    // CALL 0x1000:ab15 (1000_47F6 / 0x147F6)
    NearCall(cs1, 0x47F9, spice86_generated_label_call_target_1000_AB15_01AB15);
    label_1000_47F9_147F9:
    // MOV CL,0x1 (1000_47F9 / 0x147F9)
    CL = 0x1;
    label_1000_47FB_147FB:
    // MOV BP,0x4821 (1000_47FB / 0x147FB)
    BP = 0x4821;
    // MOV AX,0x14 (1000_47FE / 0x147FE)
    AX = 0x14;
    // CALL 0x1000:e353 (1000_4801 / 0x14801)
    NearCall(cs1, 0x4804, spice86_generated_label_call_target_1000_E353_01E353);
    label_1000_4804_14804:
    // ADD byte ptr [0x4731],CL (1000_4804 / 0x14804)
    // UInt8[DS, 0x4731] += CL;
    UInt8[DS, 0x4731] = Alu.Add8(UInt8[DS, 0x4731], CL);
    // MOV AL,[0x4731] (1000_4808 / 0x14808)
    AL = UInt8[DS, 0x4731];
    // CMP AL,0x1a (1000_480B / 0x1480B)
    Alu.Sub8(AL, 0x1A);
    // JNZ 0x1000:4816 (1000_480D / 0x1480D)
    if(!ZeroFlag) {
      goto label_1000_4816_14816;
    }
    // OR CL,CL (1000_480F / 0x1480F)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JS 0x1000:4816 (1000_4811 / 0x14811)
    if(SignFlag) {
      goto label_1000_4816_14816;
    }
    // CALL 0x1000:ac30 (1000_4813 / 0x14813)
    NearCall(cs1, 0x4816, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_4816_14816:
    // CALL 0x1000:ae04 (1000_4816 / 0x14816)
    NearCall(cs1, 0x4819, spice86_generated_label_call_target_1000_AE04_01AE04);
    label_1000_4819_14819:
    // CMP byte ptr [0x4731],0x21 (1000_4819 / 0x14819)
    Alu.Sub8(UInt8[DS, 0x4731], 0x21);
    // JC 0x1000:47fb (1000_481E / 0x1481E)
    if(CarryFlag) {
      goto label_1000_47FB_147FB;
    }
    // RET  (1000_4820 / 0x14820)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4821_014821(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4821_14821:
    // PUSH CX (1000_4821 / 0x14821)
    Stack.Push(CX);
    // CALL 0x1000:c43e (1000_4822 / 0x14822)
    NearCall(cs1, 0x4825, spice86_generated_label_call_target_1000_C43E_01C43E);
    label_1000_4825_14825:
    // MOV AX,0x2a (1000_4825 / 0x14825)
    AX = 0x2A;
    // CALL 0x1000:c13e (1000_4828 / 0x14828)
    NearCall(cs1, 0x482B, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_482B_1482B:
    // CALL 0x1000:c0f4 (1000_482B / 0x1482B)
    NearCall(cs1, 0x482E, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    label_1000_482E_1482E:
    // CALL 0x1000:c07c (1000_482E / 0x1482E)
    NearCall(cs1, 0x4831, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_4831_14831:
    // CALL 0x1000:3a95 (1000_4831 / 0x14831)
    NearCall(cs1, 0x4834, spice86_generated_label_call_target_1000_3A95_013A95);
    label_1000_4834_14834:
    // MOV AL,[0x4731] (1000_4834 / 0x14834)
    AL = UInt8[DS, 0x4731];
    // CMP AL,0xd (1000_4837 / 0x14837)
    Alu.Sub8(AL, 0xD);
    // JNZ 0x1000:4840 (1000_4839 / 0x14839)
    if(!ZeroFlag) {
      goto label_1000_4840_14840;
    }
    // PUSH AX (1000_483B / 0x1483B)
    Stack.Push(AX);
    // CALL 0x1000:ac30 (1000_483C / 0x1483C)
    NearCall(cs1, 0x483F, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_483F_1483F:
    // POP AX (1000_483F / 0x1483F)
    AX = Stack.Pop();
    label_1000_4840_14840:
    // SUB AL,0xe (1000_4840 / 0x14840)
    // AL -= 0xE;
    AL = Alu.Sub8(AL, 0xE);
    // JBE 0x1000:485d (1000_4842 / 0x14842)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_485D_1485D;
    }
    // POP CX (1000_4844 / 0x14844)
    CX = Stack.Pop();
    // PUSH CX (1000_4845 / 0x14845)
    Stack.Push(CX);
    // OR CL,CL (1000_4846 / 0x14846)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // MOV CX,0x5 (1000_4848 / 0x14848)
    CX = 0x5;
    // JNS 0x1000:484f (1000_484B / 0x1484B)
    if(!SignFlag) {
      goto label_1000_484F_1484F;
    }
    // NEG CX (1000_484D / 0x1484D)
    CX = Alu.Sub16(0, CX);
    label_1000_484F_1484F:
    // MOV AH,AL (1000_484F / 0x1484F)
    AH = AL;
    label_1000_4851_14851:
    // SUB DX,CX (1000_4851 / 0x14851)
    DX -= CX;
    
    // DEC AH (1000_4853 / 0x14853)
    AH = Alu.Dec8(AH);
    // JNZ 0x1000:4851 (1000_4855 / 0x14855)
    if(!ZeroFlag) {
      goto label_1000_4851_14851;
    }
    // MUL AL (1000_4857 / 0x14857)
    Cpu.Mul8(AL);
    // SAR AX,0x1 (1000_4859 / 0x14859)
    AX = Alu.Sar16(AX, 0x1);
    // SUB BX,AX (1000_485B / 0x1485B)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    label_1000_485D_1485D:
    // CALL 0x1000:3aa9 (1000_485D / 0x1485D)
    NearCall(cs1, 0x4860, spice86_generated_label_call_target_1000_3AA9_013AA9);
    label_1000_4860_14860:
    // CALL 0x1000:3a95 (1000_4860 / 0x14860)
    NearCall(cs1, 0x4863, spice86_generated_label_call_target_1000_3A95_013A95);
    label_1000_4863_14863:
    // MOV CL,byte ptr [0x46ff] (1000_4863 / 0x14863)
    CL = UInt8[DS, 0x46FF];
    // XOR CH,CH (1000_4867 / 0x14867)
    CH = 0;
    // JCXZ 0x1000:487b (1000_4869 / 0x14869)
    if(CX == 0) {
      goto label_1000_487B_1487B;
    }
    // MOV AL,[0x4731] (1000_486B / 0x1486B)
    AL = UInt8[DS, 0x4731];
    // PUSH AX (1000_486E / 0x1486E)
    Stack.Push(AX);
    // MOV byte ptr [0x4731],0x0 (1000_486F / 0x1486F)
    UInt8[DS, 0x4731] = 0x0;
    // CALL 0x1000:3a73 (1000_4874 / 0x14874)
    NearCall(cs1, 0x4877, spice86_generated_label_call_target_1000_3A73_013A73);
    label_1000_4877_14877:
    // POP AX (1000_4877 / 0x14877)
    AX = Stack.Pop();
    // MOV [0x4731],AL (1000_4878 / 0x14878)
    UInt8[DS, 0x4731] = AL;
    label_1000_487B_1487B:
    // CALL 0x1000:c4dd (1000_487B / 0x1487B)
    NearCall(cs1, 0x487E, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_487E_1487E:
    // CMP byte ptr [0x46d7],0x0 (1000_487E / 0x1487E)
    Alu.Sub8(UInt8[DS, 0x46D7], 0x0);
    // JZ 0x1000:4888 (1000_4883 / 0x14883)
    if(ZeroFlag) {
      goto label_1000_4888_14888;
    }
    // CALL 0x1000:3916 (1000_4885 / 0x14885)
    NearCall(cs1, 0x4888, spice86_generated_label_call_target_1000_3916_013916);
    label_1000_4888_14888:
    // POP CX (1000_4888 / 0x14888)
    CX = Stack.Pop();
    // RET  (1000_4889 / 0x14889)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4944_014944(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4944_14944:
    // CALL 0x1000:50be (1000_4944 / 0x14944)
    NearCall(cs1, 0x4947, spice86_generated_label_call_target_1000_50BE_0150BE);
    label_1000_4947_14947:
    // CMP DI,-0x10 (1000_4947 / 0x14947)
    Alu.Sub16(DI, 0xFFF0);
    // JC 0x1000:4965 (1000_494A / 0x1494A)
    if(CarryFlag) {
      goto label_1000_4965_14965;
    }
    // DEC byte ptr [0x11cb] (1000_494C / 0x1494C)
    UInt8[DS, 0x11CB] = Alu.Dec8(UInt8[DS, 0x11CB]);
    // CALL 0x1000:b5f9 (1000_4950 / 0x14950)
    throw FailAsUntested("Could not find a valid function at address 1000_B5F9 / 0x1B5F9");
    // MOV CX,BX (1000_4953 / 0x14953)
    CX = BX;
    // MOV DI,DX (1000_4955 / 0x14955)
    DI = DX;
    // CALL 0x1000:407e (1000_4957 / 0x14957)
    NearCall(cs1, 0x495A, spice86_generated_label_call_target_1000_407E_01407E);
    // CALL 0x1000:5133 (1000_495A / 0x1495A)
    NearCall(cs1, 0x495D, spice86_generated_label_call_target_1000_5133_015133);
    // MOV DI,word ptr [0x1150] (1000_495D / 0x1495D)
    DI = UInt16[DS, 0x1150];
    // MOV CL,0x1 (1000_4961 / 0x14961)
    CL = 0x1;
    // JMP 0x1000:496a (1000_4963 / 0x14963)
    goto label_1000_496A_1496A;
    label_1000_4965_14965:
    // CALL 0x1000:5124 (1000_4965 / 0x14965)
    NearCall(cs1, 0x4968, spice86_generated_label_call_target_1000_5124_015124);
    label_1000_4968_14968:
    // XOR CX,CX (1000_4968 / 0x14968)
    CX = 0;
    label_1000_496A_1496A:
    // MOV word ptr [0x11c5],DI (1000_496A / 0x1496A)
    UInt16[DS, 0x11C5] = DI;
    // MOV byte ptr [0x11c8],CL (1000_496E / 0x1496E)
    UInt8[DS, 0x11C8] = CL;
    // MOV byte ptr [0x11c7],0x0 (1000_4972 / 0x14972)
    UInt8[DS, 0x11C7] = 0x0;
    // JMP 0x1000:5119 (1000_4977 / 0x14977)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5119_015119, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_4988_014988(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4988_14988:
    // MOV word ptr [0x46fc],0x0 (1000_4988 / 0x14988)
    UInt16[DS, 0x46FC] = 0x0;
    // CALL 0x1000:5b5d (1000_498E / 0x1498E)
    NearCall(cs1, 0x4991, spice86_generated_label_call_target_1000_5B5D_015B5D);
    label_1000_4991_14991:
    // MOV SI,0x148a (1000_4991 / 0x14991)
    SI = 0x148A;
    // MOV DI,0x46e3 (1000_4994 / 0x14994)
    DI = 0x46E3;
    // CALL 0x1000:5b99 (1000_4997 / 0x14997)
    NearCall(cs1, 0x499A, spice86_generated_label_call_target_1000_5B99_015B99);
    label_1000_499A_1499A:
    // MOV word ptr [0x46ed],0x49a0 (1000_499A / 0x1499A)
    UInt16[DS, 0x46ED] = 0x49A0;
    label_1000_49A0_149A0:
    // CALL 0x1000:c085 (1000_49A0 / 0x149A0)
    NearCall(cs1, 0x49A3, spice86_generated_label_call_target_1000_C085_01C085);
    label_1000_49A3_149A3:
    // CALL 0x1000:5b93 (1000_49A3 / 0x149A3)
    NearCall(cs1, 0x49A6, spice86_generated_label_ret_target_1000_5B93_015B93);
    label_1000_49A6_149A6:
    // MOV byte ptr [0x46eb],0x1 (1000_49A6 / 0x149A6)
    UInt8[DS, 0x46EB] = 0x1;
    // CALL 0x1000:b6c3 (1000_49AB / 0x149AB)
    NearCall(cs1, 0x49AE, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    label_1000_49AE_149AE:
    // CALL 0x1000:5b69 (1000_49AE / 0x149AE)
    NearCall(cs1, 0x49B1, spice86_generated_label_call_target_1000_5B69_015B69);
    label_1000_49B1_149B1:
    // CALL 0x1000:c137 (1000_49B1 / 0x149B1)
    NearCall(cs1, 0x49B4, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_49B4_149B4:
    // CALL 0x1000:5dce (1000_49B4 / 0x149B4)
    NearCall(cs1, 0x49B7, spice86_generated_label_call_target_1000_5DCE_015DCE);
    label_1000_49B7_149B7:
    // MOV SI,word ptr [0x11c5] (1000_49B7 / 0x149B7)
    SI = UInt16[DS, 0x11C5];
    // OR SI,SI (1000_49BB / 0x149BB)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:49cc (1000_49BD / 0x149BD)
    if(ZeroFlag) {
      goto label_1000_49CC_149CC;
    }
    // CALL 0x1000:62c9 (1000_49BF / 0x149BF)
    NearCall(cs1, 0x49C2, spice86_generated_label_call_target_1000_62C9_0162C9);
    label_1000_49C2_149C2:
    // JC 0x1000:49cc (1000_49C2 / 0x149C2)
    if(CarryFlag) {
      goto label_1000_49CC_149CC;
    }
    // DEC BX (1000_49C4 / 0x149C4)
    BX = Alu.Dec16(BX);
    // DEC DX (1000_49C5 / 0x149C5)
    DX = Alu.Dec16(DX);
    // MOV AX,0x2e (1000_49C6 / 0x149C6)
    AX = 0x2E;
    // CALL 0x1000:c22f (1000_49C9 / 0x149C9)
    NearCall(cs1, 0x49CC, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_49CC_149CC:
    // MOV byte ptr [0x46eb],0x0 (1000_49CC / 0x149CC)
    UInt8[DS, 0x46EB] = 0x0;
    // JMP 0x1000:c07c (1000_49D1 / 0x149D1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_49EA_0149EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_49EA_149EA:
    // MOV byte ptr [0x4728],0x0 (1000_49EA / 0x149EA)
    UInt8[DS, 0x4728] = 0x0;
    // PUSH CS (1000_49EF / 0x149EF)
    Stack.Push(cs1);
    // POP ES (1000_49F0 / 0x149F0)
    ES = Stack.Pop();
    // MOV DI,0xe40c (1000_49F1 / 0x149F1)
    DI = 0xE40C;
    // MOV AX,0x800 (1000_49F4 / 0x149F4)
    AX = 0x800;
    label_1000_49F7_149F7:
    // STOSW ES:DI (1000_49F7 / 0x149F7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_49F8 / 0x149F8)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP DI,0xe85c (1000_49F9 / 0x149F9)
    Alu.Sub16(DI, 0xE85C);
    // JC 0x1000:49f7 (1000_49FD / 0x149FD)
    if(CarryFlag) {
      goto label_1000_49F7_149F7;
    }
    // RET  (1000_49FF / 0x149FF)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4A00_014A00(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4A00_14A00:
    // PUSH CS (1000_4A00 / 0x14A00)
    Stack.Push(cs1);
    // POP ES (1000_4A01 / 0x14A01)
    ES = Stack.Pop();
    // MOV DI,word ptr [0x149a] (1000_4A02 / 0x14A02)
    DI = UInt16[DS, 0x149A];
    // MOV AX,DX (1000_4A06 / 0x14A06)
    AX = DX;
    // STOSW ES:DI (1000_4A08 / 0x14A08)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AX,BX (1000_4A09 / 0x14A09)
    AX = BX;
    // STOSW ES:DI (1000_4A0B / 0x14A0B)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP DI,0xe85c (1000_4A0C / 0x14A0C)
    Alu.Sub16(DI, 0xE85C);
    // JC 0x1000:4a15 (1000_4A10 / 0x14A10)
    if(CarryFlag) {
      goto label_1000_4A15_14A15;
    }
    // MOV DI,0xe40c (1000_4A12 / 0x14A12)
    DI = 0xE40C;
    label_1000_4A15_14A15:
    // MOV word ptr [0x149a],DI (1000_4A15 / 0x14A15)
    UInt16[DS, 0x149A] = DI;
    // RET  (1000_4A19 / 0x14A19)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4A1A_014A1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4A1A_14A1A:
    // CMP byte ptr [0x4728],0x0 (1000_4A1A / 0x14A1A)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    // JS 0x1000:4a59 (1000_4A1F / 0x14A1F)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    // MOV SI,0x148a (1000_4A21 / 0x14A21)
    SI = 0x148A;
    // CALL 0x1000:db74 (1000_4A24 / 0x14A24)
    NearCall(cs1, 0x4A27, spice86_generated_label_call_target_1000_DB74_01DB74);
    label_1000_4A27_14A27:
    // MOV SI,word ptr [0x149a] (1000_4A27 / 0x14A27)
    SI = UInt16[DS, 0x149A];
    // CMP SI,0xe40c (1000_4A2B / 0x14A2B)
    Alu.Sub16(SI, 0xE40C);
    // JNZ 0x1000:4a34 (1000_4A2F / 0x14A2F)
    if(!ZeroFlag) {
      goto label_1000_4A34_14A34;
    }
    // MOV SI,0xe85c (1000_4A31 / 0x14A31)
    SI = 0xE85C;
    label_1000_4A34_14A34:
    // SUB SI,0x4 (1000_4A34 / 0x14A34)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    // LODSW CS:SI (1000_4A37 / 0x14A37)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_4A39 / 0x14A39)
    DX = AX;
    // LODSW CS:SI (1000_4A3B / 0x14A3B)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_4A3D / 0x14A3D)
    BX = AX;
    // DEC AH (1000_4A3F / 0x14A3F)
    AH = Alu.Dec8(AH);
    // JNS 0x1000:4a59 (1000_4A41 / 0x14A41)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    // CALL 0x1000:62d6 (1000_4A43 / 0x14A43)
    NearCall(cs1, 0x4A46, spice86_generated_label_call_target_1000_62D6_0162D6);
    // JC 0x1000:4a59 (1000_4A46 / 0x14A46)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    // DEC BX (1000_4A48 / 0x14A48)
    BX = Alu.Dec16(BX);
    // DEC DX (1000_4A49 / 0x14A49)
    DX = Alu.Dec16(DX);
    // CALL 0x1000:c137 (1000_4A4A / 0x14A4A)
    NearCall(cs1, 0x4A4D, spice86_generated_label_call_target_1000_C137_01C137);
    // MOV AX,0x2f (1000_4A4D / 0x14A4D)
    AX = 0x2F;
    // CALL 0x1000:c085 (1000_4A50 / 0x14A50)
    NearCall(cs1, 0x4A53, spice86_generated_label_call_target_1000_C085_01C085);
    // CALL 0x1000:c22f (1000_4A53 / 0x14A53)
    NearCall(cs1, 0x4A56, spice86_generated_label_call_target_1000_C22F_01C22F);
    // CALL 0x1000:c07c (1000_4A56 / 0x14A56)
    NearCall(cs1, 0x4A59, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_4A59_14A59:
    // RET  (1000_4A59 / 0x14A59)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4A5A_014A5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4A5A_14A5A:
    // CALL 0x1000:c137 (1000_4A5A / 0x14A5A)
    NearCall(cs1, 0x4A5D, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_4A5D_14A5D:
    // PUSH word ptr [0xdbda] (1000_4A5D / 0x14A5D)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c085 (1000_4A61 / 0x14A61)
    NearCall(cs1, 0x4A64, spice86_generated_label_call_target_1000_C085_01C085);
    label_1000_4A64_14A64:
    // MOV SI,word ptr [0x149a] (1000_4A64 / 0x14A64)
    SI = UInt16[DS, 0x149A];
    label_1000_4A68_14A68:
    // LODSW CS:SI (1000_4A68 / 0x14A68)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_4A6A / 0x14A6A)
    DX = AX;
    // LODSW CS:SI (1000_4A6C / 0x14A6C)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_4A6E / 0x14A6E)
    BX = AX;
    // DEC AH (1000_4A70 / 0x14A70)
    AH = Alu.Dec8(AH);
    // JNS 0x1000:4a99 (1000_4A72 / 0x14A72)
    if(!SignFlag) {
      goto label_1000_4A99_14A99;
    }
    // PUSH SI (1000_4A74 / 0x14A74)
    Stack.Push(SI);
    // CALL 0x1000:62d6 (1000_4A75 / 0x14A75)
    NearCall(cs1, 0x4A78, spice86_generated_label_call_target_1000_62D6_0162D6);
    // JC 0x1000:4a98 (1000_4A78 / 0x14A78)
    if(CarryFlag) {
      goto label_1000_4A98_14A98;
    }
    // DEC BX (1000_4A7A / 0x14A7A)
    BX = Alu.Dec16(BX);
    // DEC DX (1000_4A7B / 0x14A7B)
    DX = Alu.Dec16(DX);
    // CMP DX,0xcc (1000_4A7C / 0x14A7C)
    Alu.Sub16(DX, 0xCC);
    // JL 0x1000:4a98 (1000_4A80 / 0x14A80)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    // CMP BX,0x4 (1000_4A82 / 0x14A82)
    Alu.Sub16(BX, 0x4);
    // JL 0x1000:4a98 (1000_4A85 / 0x14A85)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    // CMP DX,0x13a (1000_4A87 / 0x14A87)
    Alu.Sub16(DX, 0x13A);
    // JGE 0x1000:4a98 (1000_4A8B / 0x14A8B)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    // CMP BX,0x3a (1000_4A8D / 0x14A8D)
    Alu.Sub16(BX, 0x3A);
    // JGE 0x1000:4a98 (1000_4A90 / 0x14A90)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    // MOV AX,0x2f (1000_4A92 / 0x14A92)
    AX = 0x2F;
    // CALL 0x1000:c22f (1000_4A95 / 0x14A95)
    NearCall(cs1, 0x4A98, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_4A98_14A98:
    // POP SI (1000_4A98 / 0x14A98)
    SI = Stack.Pop();
    label_1000_4A99_14A99:
    // CMP SI,0xe85c (1000_4A99 / 0x14A99)
    Alu.Sub16(SI, 0xE85C);
    // JC 0x1000:4aa2 (1000_4A9D / 0x14A9D)
    if(CarryFlag) {
      goto label_1000_4AA2_14AA2;
    }
    // MOV SI,0xe40c (1000_4A9F / 0x14A9F)
    SI = 0xE40C;
    label_1000_4AA2_14AA2:
    // CMP SI,word ptr [0x149a] (1000_4AA2 / 0x14AA2)
    Alu.Sub16(SI, UInt16[DS, 0x149A]);
    // JNZ 0x1000:4a68 (1000_4AA6 / 0x14AA6)
    if(!ZeroFlag) {
      goto label_1000_4A68_14A68;
    }
    // POP word ptr [0xdbda] (1000_4AA8 / 0x14AA8)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_4AAC / 0x14AAC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4AB8_014AB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4AB8_14AB8:
    // MOV byte ptr [0x4727],0xff (1000_4AB8 / 0x14AB8)
    UInt8[DS, 0x4727] = 0xFF;
    // RET  (1000_4ABD / 0x14ABD)
    return NearRet();
  }
  
  public Action split_1000_4ABE_014ABE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4ABE_14ABE:
    // CALL 0x1000:37f4 (1000_4ABE / 0x14ABE)
    NearCall(cs1, 0x4AC1, split_1000_37F4_0137F4);
    // CALL 0x1000:c4dd (1000_4AC1 / 0x14AC1)
    NearCall(cs1, 0x4AC4, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4AC4_014AC4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_4AC4_014AC4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4AC4_14AC4:
    // MOV byte ptr [0x11ca],0x0 (1000_4AC4 / 0x14AC4)
    UInt8[DS, 0x11CA] = 0x0;
    // RET  (1000_4AC9 / 0x14AC9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4ACA_014ACA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4ACA_14ACA:
    // MOV byte ptr [0x11ca],0x1 (1000_4ACA / 0x14ACA)
    UInt8[DS, 0x11CA] = 0x1;
    // RET  (1000_4ACF / 0x14ACF)
    return NearRet();
  }
  
  public Action split_1000_4AEB_014AEB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4AFD: goto label_1000_4AFD_14AFD;break; // Target of external jump from 0x1CCEE
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_4AEB_14AEB:
    // MOV AX,0x39 (1000_4AEB / 0x14AEB)
    AX = 0x39;
    // CALL 0x1000:c13e (1000_4AEE / 0x14AEE)
    NearCall(cs1, 0x4AF1, spice86_generated_label_call_target_1000_C13E_01C13E);
    // CALL 0x1000:c07c (1000_4AF1 / 0x14AF1)
    NearCall(cs1, 0x4AF4, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:4d6c (1000_4AF4 / 0x14AF4)
    throw FailAsUntested("Could not find a valid function at address 1000_4D6C / 0x14D6C");
    // CALL 0x1000:4b2b (1000_4AF7 / 0x14AF7)
    NearCall(cs1, 0x4AFA, spice86_generated_label_call_target_1000_4B2B_014B2B);
    // JMP 0x1000:c4dd (1000_4AFA / 0x14AFA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_4AFD_14AFD:
    // CMP byte ptr [0x227d],0x0 (1000_4AFD / 0x14AFD)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:4b16 (1000_4B02 / 0x14B02)
    if(!ZeroFlag) {
      goto label_1000_4B16_14B16;
    }
    // CALL 0x1000:4b2b (1000_4B04 / 0x14B04)
    NearCall(cs1, 0x4B07, spice86_generated_label_call_target_1000_4B2B_014B2B);
    label_1000_4B07_14B07:
    // MOV ES,word ptr [0xdbd8] (1000_4B07 / 0x14B07)
    ES = UInt16[DS, 0xDBD8];
    // MOV SI,word ptr [0xdbd6] (1000_4B0B / 0x14B0B)
    SI = UInt16[DS, 0xDBD6];
    // CALLF [0x38fd] (1000_4B0F / 0x14B0F)
    // Indirect call to [0x38fd], generating possible targets from emulator records
    uint targetAddress_1000_4B0F = (uint)(UInt16[DS, 0x38FF] * 0x10 + UInt16[DS, 0x38FD] - cs1 * 0x10);
    switch(targetAddress_1000_4B0F) {
      case 0x235E6 : FarCall(cs1, 0x4B13, spice86_generated_label_call_target_334B_0136_0335E6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4B0F));
        break;
    }
    label_1000_4B13_14B13:
    // JMP 0x1000:dbe3 (1000_4B13 / 0x14B13)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_DBE3_01DBE3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_4B16_14B16:
    // MOV AX,[0xdbd8] (1000_4B16 / 0x14B16)
    AX = UInt16[DS, 0xDBD8];
    // MOV SI,word ptr [0xdbd6] (1000_4B19 / 0x14B19)
    SI = UInt16[DS, 0xDBD6];
    // CMP AX,SI (1000_4B1D / 0x14B1D)
    Alu.Sub16(AX, SI);
    // JZ 0x1000:4b2a (1000_4B1F / 0x14B1F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4B2A / 0x14B2A)
      return NearRet();
    }
    // ADD AX,0x1e0 (1000_4B21 / 0x14B21)
    // AX += 0x1E0;
    AX = Alu.Add16(AX, 0x1E0);
    // MOV ES,AX (1000_4B24 / 0x14B24)
    ES = AX;
    // CALLF [0x38fd] (1000_4B26 / 0x14B26)
    // Indirect call to [0x38fd], generating possible targets from emulator records
    uint targetAddress_1000_4B26 = (uint)(UInt16[DS, 0x38FF] * 0x10 + UInt16[DS, 0x38FD] - cs1 * 0x10);
    switch(targetAddress_1000_4B26) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4B26));
        break;
    }
    label_1000_4B2A_14B2A:
    // RET  (1000_4B2A / 0x14B2A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4B2B_014B2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4B2B_14B2B:
    // CMP byte ptr [0x4728],0x0 (1000_4B2B / 0x14B2B)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    // JS 0x1000:4b38 (1000_4B30 / 0x14B30)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:dbca (1000_4B38 / 0x14B38)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_DBCA_01DBCA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1492 (1000_4B32 / 0x14B32)
    SI = 0x1492;
    // CALL 0x1000:c46f (1000_4B35 / 0x14B35)
    NearCall(cs1, 0x4B38, spice86_generated_label_call_target_1000_C46F_01C46F);
    label_1000_4B38_14B38:
    // JMP 0x1000:dbca (1000_4B38 / 0x14B38)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_DBCA_01DBCA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_4B3B_014B3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4B3B_14B3B:
    // INC word ptr [0x472b] (1000_4B3B / 0x14B3B)
    UInt16[DS, 0x472B] = Alu.Inc16(UInt16[DS, 0x472B]);
    // TEST word ptr [0x472b],0xf (1000_4B3F / 0x14B3F)
    Alu.And16(UInt16[DS, 0x472B], 0xF);
    // JNZ 0x1000:4b4d (1000_4B45 / 0x14B45)
    if(!ZeroFlag) {
      goto label_1000_4B4D_14B4D;
    }
    // MOV CX,0x1 (1000_4B47 / 0x14B47)
    CX = 0x1;
    // CALL 0x1000:0fd9 (1000_4B4A / 0x14B4A)
    NearCall(cs1, 0x4B4D, spice86_generated_label_call_target_1000_0FD9_010FD9);
    label_1000_4B4D_14B4D:
    // CALL 0x1000:407e (1000_4B4D / 0x14B4D)
    NearCall(cs1, 0x4B50, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4B50_14B50:
    // CALL 0x1000:5206 (1000_4B50 / 0x14B50)
    NearCall(cs1, 0x4B53, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4B53_14B53:
    // CALL 0x1000:40c3 (1000_4B53 / 0x14B53)
    NearCall(cs1, 0x4B56, spice86_generated_label_call_target_1000_40C3_0140C3);
    label_1000_4B56_14B56:
    // MOV word ptr [0x4],DX (1000_4B56 / 0x14B56)
    UInt16[DS, 0x4] = DX;
    // MOV word ptr [0x6],BX (1000_4B5A / 0x14B5A)
    UInt16[DS, 0x6] = BX;
    // RET  (1000_4B5E / 0x14B5E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4D00_014D00(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4D00_14D00:
    // MOV SI,0x4bb9 (1000_4D00 / 0x14D00)
    SI = 0x4BB9;
    // JMP 0x1000:da5f (1000_4D03 / 0x14D03)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_4D06_014D06(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4D06_14D06:
    // MOV byte ptr [0xf6],0x0 (1000_4D06 / 0x14D06)
    UInt8[DS, 0xF6] = 0x0;
    // MOV DI,word ptr [0x1150] (1000_4D0B / 0x14D0B)
    DI = UInt16[DS, 0x1150];
    // MOV DX,word ptr [DI + 0x2] (1000_4D0F / 0x14D0F)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // CMP DX,word ptr [0x4] (1000_4D12 / 0x14D12)
    Alu.Sub16(DX, UInt16[DS, 0x4]);
    // JNZ 0x1000:4d56 (1000_4D16 / 0x14D16)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    // MOV AX,[0x4733] (1000_4D18 / 0x14D18)
    AX = UInt16[DS, 0x4733];
    // OR AH,AH (1000_4D1B / 0x14D1B)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:4d56 (1000_4D1D / 0x14D1D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    // MOV BX,word ptr [0x6] (1000_4D1F / 0x14D1F)
    BX = UInt16[DS, 0x6];
    // CMP BL,byte ptr [DI + 0x4] (1000_4D23 / 0x14D23)
    Alu.Sub8(BL, UInt8[DS, (ushort)(DI + 0x4)]);
    // JNZ 0x1000:4d56 (1000_4D26 / 0x14D26)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    // CMP BH,AH (1000_4D28 / 0x14D28)
    Alu.Sub8(BH, AH);
    // JA 0x1000:4d56 (1000_4D2A / 0x14D2A)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    // PUSH AX (1000_4D2C / 0x14D2C)
    Stack.Push(AX);
    // PUSH BX (1000_4D2D / 0x14D2D)
    Stack.Push(BX);
    // INC byte ptr [0xf6] (1000_4D2E / 0x14D2E)
    UInt8[DS, 0xF6] = Alu.Inc8(UInt8[DS, 0xF6]);
    // MOV AH,0x1 (1000_4D32 / 0x14D32)
    AH = 0x1;
    // CALL 0x1000:4d57 (1000_4D34 / 0x14D34)
    throw FailAsUntested("Could not find a valid function at address 1000_4D57 / 0x14D57");
    // CALL 0x1000:4bdf (1000_4D37 / 0x14D37)
    throw FailAsUntested("Could not find a valid function at address 1000_4BDF / 0x14BDF");
    // CALL 0x1000:c412 (1000_4D3A / 0x14D3A)
    NearCall(cs1, 0x4D3D, spice86_generated_label_call_target_1000_C412_01C412);
    // POP BX (1000_4D3D / 0x14D3D)
    BX = Stack.Pop();
    // POP AX (1000_4D3E / 0x14D3E)
    AX = Stack.Pop();
    // CMP BH,AL (1000_4D3F / 0x14D3F)
    Alu.Sub8(BH, AL);
    // JA 0x1000:4d56 (1000_4D41 / 0x14D41)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    // MOV AL,0x5 (1000_4D43 / 0x14D43)
    AL = 0x5;
    // CALL 0x1000:ab15 (1000_4D45 / 0x14D45)
    NearCall(cs1, 0x4D48, spice86_generated_label_call_target_1000_AB15_01AB15);
    // XOR AH,AH (1000_4D48 / 0x14D48)
    AH = 0;
    // CALL 0x1000:4d57 (1000_4D4A / 0x14D4A)
    throw FailAsUntested("Could not find a valid function at address 1000_4D57 / 0x14D57");
    // MOV SI,0x4bb9 (1000_4D4D / 0x14D4D)
    SI = 0x4BB9;
    // MOV BP,0x10 (1000_4D50 / 0x14D50)
    BP = 0x10;
    // CALL 0x1000:da25 (1000_4D53 / 0x14D53)
    NearCall(cs1, 0x4D56, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_4D56_14D56:
    // RET  (1000_4D56 / 0x14D56)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4E12_014E12(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4E12_14E12:
    // MOV word ptr [0x4733],0x0 (1000_4E12 / 0x14E12)
    UInt16[DS, 0x4733] = 0x0;
    // CALL 0x1000:407e (1000_4E18 / 0x14E18)
    NearCall(cs1, 0x4E1B, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4E1B_14E1B:
    // CALL 0x1000:b532 (1000_4E1B / 0x14E1B)
    NearCall(cs1, 0x4E1E, spice86_generated_label_call_target_1000_B532_01B532);
    label_1000_4E1E_14E1E:
    // PUSH AX (1000_4E1E / 0x14E1E)
    Stack.Push(AX);
    // CALL 0x1000:4ec6 (1000_4E1F / 0x14E1F)
    NearCall(cs1, 0x4E22, spice86_generated_label_call_target_1000_4EC6_014EC6);
    label_1000_4E22_14E22:
    // MOV word ptr [0x196a],0x0 (1000_4E22 / 0x14E22)
    UInt16[DS, 0x196A] = 0x0;
    // POP AX (1000_4E28 / 0x14E28)
    AX = Stack.Pop();
    // TEST AL,0x40 (1000_4E29 / 0x14E29)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:4e78 (1000_4E2B / 0x14E2B)
    if(ZeroFlag) {
      goto label_1000_4E78_14E78;
    }
    // CALL 0x1000:409a (1000_4E2D / 0x14E2D)
    NearCall(cs1, 0x4E30, spice86_generated_label_call_target_1000_409A_01409A);
    label_1000_4E30_14E30:
    // JNZ 0x1000:4e78 (1000_4E30 / 0x14E30)
    if(!ZeroFlag) {
      goto label_1000_4E78_14E78;
    }
    // CMP byte ptr [0x6],0x80 (1000_4E32 / 0x14E32)
    Alu.Sub8(UInt8[DS, 0x6], 0x80);
    // JZ 0x1000:4e78 (1000_4E37 / 0x14E37)
    if(ZeroFlag) {
      goto label_1000_4E78_14E78;
    }
    // MOV AX,word ptr [SI + 0x2] (1000_4E39 / 0x14E39)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB AX,DX (1000_4E3C / 0x14E3C)
    AX -= DX;
    
    // ADD AX,0x4 (1000_4E3E / 0x14E3E)
    AX += 0x4;
    
    // CMP AX,0x8 (1000_4E41 / 0x14E41)
    Alu.Sub16(AX, 0x8);
    // JNC 0x1000:4e78 (1000_4E44 / 0x14E44)
    if(!CarryFlag) {
      goto label_1000_4E78_14E78;
    }
    // MOV [0x1968],AX (1000_4E46 / 0x14E46)
    UInt16[DS, 0x1968] = AX;
    // INC AX (1000_4E49 / 0x14E49)
    AX = Alu.Inc16(AX);
    // MOV [0x1964],AX (1000_4E4A / 0x14E4A)
    UInt16[DS, 0x1964] = AX;
    // SUB AX,0x2 (1000_4E4D / 0x14E4D)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    // MOV [0x1960],AX (1000_4E50 / 0x14E50)
    UInt16[DS, 0x1960] = AX;
    // XOR AX,AX (1000_4E53 / 0x14E53)
    AX = 0;
    // CALL 0x1000:5e4f (1000_4E55 / 0x14E55)
    NearCall(cs1, 0x4E58, spice86_generated_label_call_target_1000_5E4F_015E4F);
    // MOV BX,0x196d (1000_4E58 / 0x14E58)
    BX = 0x196D;
    // XLAT BX (1000_4E5B / 0x14E5B)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // CMP AL,0x13 (1000_4E5C / 0x14E5C)
    Alu.Sub8(AL, 0x13);
    // JC 0x1000:4e6e (1000_4E5E / 0x14E5E)
    if(CarryFlag) {
      goto label_1000_4E6E_14E6E;
    }
    // SUB CL,0x28 (1000_4E60 / 0x14E60)
    CL -= 0x28;
    
    // AND CL,0xfb (1000_4E63 / 0x14E63)
    CL &= 0xFB;
    
    // ADD AL,CL (1000_4E66 / 0x14E66)
    AL += CL;
    
    // CMP AL,0x17 (1000_4E68 / 0x14E68)
    Alu.Sub8(AL, 0x17);
    // JC 0x1000:4e6e (1000_4E6A / 0x14E6A)
    if(CarryFlag) {
      goto label_1000_4E6E_14E6E;
    }
    // MOV AL,0x17 (1000_4E6C / 0x14E6C)
    AL = 0x17;
    label_1000_4E6E_14E6E:
    // MOV [0x196a],AX (1000_4E6E / 0x14E6E)
    UInt16[DS, 0x196A] = AX;
    // XCHG DI,SI (1000_4E71 / 0x14E71)
    ushort tmp_1000_4E71 = DI;
    DI = SI;
    SI = tmp_1000_4E71;
    // CALL 0x1000:4ded (1000_4E73 / 0x14E73)
    throw FailAsUntested("Could not find a valid function at address 1000_4DED / 0x14DED");
    // XCHG DI,SI (1000_4E76 / 0x14E76)
    ushort tmp_1000_4E76 = DI;
    DI = SI;
    SI = tmp_1000_4E76;
    label_1000_4E78_14E78:
    // MOV AX,[0x196a] (1000_4E78 / 0x14E78)
    AX = UInt16[DS, 0x196A];
    // OR AX,AX (1000_4E7B / 0x14E7B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:4e8c (1000_4E7D / 0x14E7D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4E8C / 0x14E8C)
      return NearRet();
    }
    // MOV CX,word ptr [0x4733] (1000_4E7F / 0x14E7F)
    CX = UInt16[DS, 0x4733];
    // MOV CL,byte ptr [0x46ff] (1000_4E83 / 0x14E83)
    CL = UInt8[DS, 0x46FF];
    // XOR CH,CH (1000_4E87 / 0x14E87)
    CH = 0;
    // JCXZ 0x1000:4e8c (1000_4E89 / 0x14E89)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_4E8C / 0x14E8C)
      return NearRet();
    }
    // NOP  (1000_4E8B / 0x14E8B)
    
    label_1000_4E8C_14E8C:
    // RET  (1000_4E8C / 0x14E8C)
    return NearRet();
  }
  
  public Action split_1000_4E8E_014E8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4E8E_14E8E:
    // MOV DX,word ptr [0x4] (1000_4E8E / 0x14E8E)
    DX = UInt16[DS, 0x4];
    // MOV BX,word ptr [0x6] (1000_4E92 / 0x14E92)
    BX = UInt16[DS, 0x6];
    // PUSH word ptr [0x11cc] (1000_4E96 / 0x14E96)
    Stack.Push(UInt16[DS, 0x11CC]);
    // CALL 0x1000:5206 (1000_4E9A / 0x14E9A)
    NearCall(cs1, 0x4E9D, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4E9D_14E9D:
    // CALL 0x1000:5206 (1000_4E9D / 0x14E9D)
    NearCall(cs1, 0x4EA0, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4EA0_14EA0:
    // CALL 0x1000:5206 (1000_4EA0 / 0x14EA0)
    NearCall(cs1, 0x4EA3, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4EA3_14EA3:
    // CALL 0x1000:5206 (1000_4EA3 / 0x14EA3)
    NearCall(cs1, 0x4EA6, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4EA6_14EA6:
    // CALL 0x1000:5206 (1000_4EA6 / 0x14EA6)
    NearCall(cs1, 0x4EA9, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4EA9_14EA9:
    // CALL 0x1000:5206 (1000_4EA9 / 0x14EA9)
    NearCall(cs1, 0x4EAC, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4EAC_14EAC:
    // CALL 0x1000:b532 (1000_4EAC / 0x14EAC)
    NearCall(cs1, 0x4EAF, spice86_generated_label_call_target_1000_B532_01B532);
    label_1000_4EAF_14EAF:
    // PUSH AX (1000_4EAF / 0x14EAF)
    Stack.Push(AX);
    // CALL 0x1000:5206 (1000_4EB0 / 0x14EB0)
    NearCall(cs1, 0x4EB3, spice86_generated_label_call_target_1000_5206_015206);
    label_1000_4EB3_14EB3:
    // POP AX (1000_4EB3 / 0x14EB3)
    AX = Stack.Pop();
    // POP word ptr [0x11cc] (1000_4EB4 / 0x14EB4)
    UInt16[DS, 0x11CC] = Stack.Pop();
    // PUSH AX (1000_4EB8 / 0x14EB8)
    Stack.Push(AX);
    // CALL 0x1000:b532 (1000_4EB9 / 0x14EB9)
    NearCall(cs1, 0x4EBC, spice86_generated_label_call_target_1000_B532_01B532);
    label_1000_4EBC_14EBC:
    // PUSH AX (1000_4EBC / 0x14EBC)
    Stack.Push(AX);
    // CALL 0x1000:41e1 (1000_4EBD / 0x14EBD)
    NearCall(cs1, 0x4EC0, spice86_generated_label_call_target_1000_41E1_0141E1);
    label_1000_4EC0_14EC0:
    // POP AX (1000_4EC0 / 0x14EC0)
    AX = Stack.Pop();
    // POP BX (1000_4EC1 / 0x14EC1)
    BX = Stack.Pop();
    // ADD AL,BL (1000_4EC2 / 0x14EC2)
    AL += BL;
    
    // SHR AL,0x1 (1000_4EC4 / 0x14EC4)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4EC6_014EC6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_4EC6_014EC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4EC6_14EC6:
    // PUSH BX (1000_4EC6 / 0x14EC6)
    Stack.Push(BX);
    // MOV BX,word ptr [0x487e] (1000_4EC7 / 0x14EC7)
    BX = UInt16[DS, 0x487E];
    // CMP BX,0x2 (1000_4ECB / 0x14ECB)
    Alu.Sub16(BX, 0x2);
    // JC 0x1000:4eed (1000_4ECE / 0x14ECE)
    if(CarryFlag) {
      goto label_1000_4EED_14EED;
    }
    // AND AL,0xf (1000_4ED0 / 0x14ED0)
    AL &= 0xF;
    
    // CMP AL,0x8 (1000_4ED2 / 0x14ED2)
    Alu.Sub8(AL, 0x8);
    // MOV AX,[0xdc00] (1000_4ED4 / 0x14ED4)
    AX = UInt16[DS, 0xDC00];
    // JNC 0x1000:4ef3 (1000_4ED7 / 0x14ED7)
    if(!CarryFlag) {
      goto label_1000_4EF3_14EF3;
    }
    // CMP AX,0x2 (1000_4ED9 / 0x14ED9)
    Alu.Sub16(AX, 0x2);
    // JBE 0x1000:4eed (1000_4EDC / 0x14EDC)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4EED_14EED;
    }
    // MOV BX,0x5 (1000_4EDE / 0x14EDE)
    BX = 0x5;
    // CMP AX,0x4 (1000_4EE1 / 0x14EE1)
    Alu.Sub16(AX, 0x4);
    // JBE 0x1000:4eed (1000_4EE4 / 0x14EE4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4EED_14EED;
    }
    // MOV BX,0x2 (1000_4EE6 / 0x14EE6)
    BX = 0x2;
    // MOV word ptr [0x487e],BX (1000_4EE9 / 0x14EE9)
    UInt16[DS, 0x487E] = BX;
    label_1000_4EED_14EED:
    // MOV word ptr [0xdc02],BX (1000_4EED / 0x14EED)
    UInt16[DS, 0xDC02] = BX;
    // POP BX (1000_4EF1 / 0x14EF1)
    BX = Stack.Pop();
    // RET  (1000_4EF2 / 0x14EF2)
    return NearRet();
    label_1000_4EF3_14EF3:
    // MOV BX,0x3 (1000_4EF3 / 0x14EF3)
    BX = 0x3;
    // CMP AX,0x2 (1000_4EF6 / 0x14EF6)
    Alu.Sub16(AX, 0x2);
    // JBE 0x1000:4f03 (1000_4EF9 / 0x14EF9)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4F03_14F03;
    }
    // CMP AX,0x5 (1000_4EFB / 0x14EFB)
    Alu.Sub16(AX, 0x5);
    // JZ 0x1000:4f03 (1000_4EFE / 0x14EFE)
    if(ZeroFlag) {
      goto label_1000_4F03_14F03;
    }
    // MOV BX,0x4 (1000_4F00 / 0x14F00)
    BX = 0x4;
    label_1000_4F03_14F03:
    // MOV word ptr [0xdc02],BX (1000_4F03 / 0x14F03)
    UInt16[DS, 0xDC02] = BX;
    // POP BX (1000_4F07 / 0x14F07)
    BX = Stack.Pop();
    // RET  (1000_4F08 / 0x14F08)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_4F0C_014F0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_4F0C_14F0C:
    // CMP byte ptr [0x4727],0x0 (1000_4F0C / 0x14F0C)
    Alu.Sub8(UInt8[DS, 0x4727], 0x0);
    // JZ 0x1000:4f33 (1000_4F11 / 0x14F11)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    // CMP byte ptr [0x11ca],0x0 (1000_4F13 / 0x14F13)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    // JNZ 0x1000:4f33 (1000_4F18 / 0x14F18)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    // MOV word ptr [0x1c06],0x80 (1000_4F1A / 0x14F1A)
    UInt16[DS, 0x1C06] = 0x80;
    // MOV AX,0xdbec (1000_4F20 / 0x14F20)
    AX = 0xDBEC;
    // PUSH AX (1000_4F23 / 0x14F23)
    Stack.Push(AX);
    // CALL 0x1000:ca60 (1000_4F24 / 0x14F24)
    NearCall(cs1, 0x4F27, spice86_generated_label_call_target_1000_CA60_01CA60);
    label_1000_4F27_14F27:
    // MOV AX,[0xce7a] (1000_4F27 / 0x14F27)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,word ptr [0x4729] (1000_4F2A / 0x14F2A)
    AX -= UInt16[DS, 0x4729];
    
    // CMP AX,0x300 (1000_4F2E / 0x14F2E)
    Alu.Sub16(AX, 0x300);
    // JNC 0x1000:4f34 (1000_4F31 / 0x14F31)
    if(!CarryFlag) {
      goto label_1000_4F34_14F34;
    }
    label_1000_4F33_14F33:
    // RET  (1000_4F33 / 0x14F33)
    return NearRet();
    label_1000_4F34_14F34:
    // MOV AX,[0xce7a] (1000_4F34 / 0x14F34)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0x4729],AX (1000_4F37 / 0x14F37)
    UInt16[DS, 0x4729] = AX;
    // CALL 0x1000:4b3b (1000_4F3A / 0x14F3A)
    NearCall(cs1, 0x4F3D, spice86_generated_label_call_target_1000_4B3B_014B3B);
    label_1000_4F3D_14F3D:
    // CALL 0x1000:4a1a (1000_4F3D / 0x14F3D)
    NearCall(cs1, 0x4F40, spice86_generated_label_call_target_1000_4A1A_014A1A);
    label_1000_4F40_14F40:
    // CALL 0x1000:407e (1000_4F40 / 0x14F40)
    NearCall(cs1, 0x4F43, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4F43_14F43:
    // CALL 0x1000:4a00 (1000_4F43 / 0x14F43)
    NearCall(cs1, 0x4F46, spice86_generated_label_call_target_1000_4A00_014A00);
    label_1000_4F46_14F46:
    // CALL 0x1000:b58b (1000_4F46 / 0x14F46)
    NearCall(cs1, 0x4F49, spice86_generated_label_call_target_1000_B58B_01B58B);
    label_1000_4F49_14F49:
    // MOV SI,word ptr [0x11c5] (1000_4F49 / 0x14F49)
    SI = UInt16[DS, 0x11C5];
    // CMP DI,word ptr [SI + 0x6] (1000_4F4D / 0x14F4D)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    // JZ 0x1000:4fb0 (1000_4F50 / 0x14F50)
    if(ZeroFlag) {
      goto label_1000_4FB0_14FB0;
    }
    // CALL 0x1000:2e52 (1000_4F52 / 0x14F52)
    NearCall(cs1, 0x4F55, spice86_generated_label_ret_target_1000_2E52_012E52);
    label_1000_4F55_14F55:
    // CMP byte ptr [0x47a7],0x0 (1000_4F55 / 0x14F55)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    // JNZ 0x1000:4f33 (1000_4F5A / 0x14F5A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    // CMP byte ptr [0x4728],0x0 (1000_4F5C / 0x14F5C)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    // JS 0x1000:4fad (1000_4F61 / 0x14F61)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JZ 0x1000:4f70 (1000_4F63 / 0x14F63)
    if(ZeroFlag) {
      goto label_1000_4F70_14F70;
    }
    // MOV byte ptr [0x4728],0x0 (1000_4F65 / 0x14F65)
    UInt8[DS, 0x4728] = 0x0;
    // CALL 0x1000:5b5d (1000_4F6A / 0x14F6A)
    NearCall(cs1, 0x4F6D, spice86_generated_label_call_target_1000_5B5D_015B5D);
    // CALL 0x1000:49d9 (1000_4F6D / 0x14F6D)
    throw FailAsUntested("Could not find a valid function at address 1000_49D9 / 0x149D9");
    label_1000_4F70_14F70:
    // CALL 0x1000:407e (1000_4F70 / 0x14F70)
    NearCall(cs1, 0x4F73, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_4F73_14F73:
    // CALL 0x1000:62d6 (1000_4F73 / 0x14F73)
    NearCall(cs1, 0x4F76, spice86_generated_label_call_target_1000_62D6_0162D6);
    label_1000_4F76_14F76:
    // JC 0x1000:4fad (1000_4F76 / 0x14F76)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP DX,0xd6 (1000_4F78 / 0x14F78)
    Alu.Sub16(DX, 0xD6);
    // JL 0x1000:4f8e (1000_4F7C / 0x14F7C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    // CMP BX,0xa (1000_4F7E / 0x14F7E)
    Alu.Sub16(BX, 0xA);
    // JL 0x1000:4f8e (1000_4F81 / 0x14F81)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    // CMP DX,0x132 (1000_4F83 / 0x14F83)
    Alu.Sub16(DX, 0x132);
    // JGE 0x1000:4f8e (1000_4F87 / 0x14F87)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    // CMP BX,0x36 (1000_4F89 / 0x14F89)
    Alu.Sub16(BX, 0x36);
    // JL 0x1000:4f95 (1000_4F8C / 0x14F8C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F95_14F95;
    }
    label_1000_4F8E_14F8E:
    // MOV byte ptr [0x4728],0x1 (1000_4F8E / 0x14F8E)
    UInt8[DS, 0x4728] = 0x1;
    // JMP 0x1000:4fad (1000_4F93 / 0x14F93)
    // JMP target is JMP, inlining.
    // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_4E8E_014E8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_4F95_14F95:
    // CMP byte ptr [0x11ca],0x0 (1000_4F95 / 0x14F95)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    // JNZ 0x1000:4fad (1000_4F9A / 0x14F9A)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC BX (1000_4F9C / 0x14F9C)
    BX = Alu.Dec16(BX);
    // DEC DX (1000_4F9D / 0x14F9D)
    DX = Alu.Dec16(DX);
    // CALL 0x1000:c137 (1000_4F9E / 0x14F9E)
    NearCall(cs1, 0x4FA1, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_4FA1_14FA1:
    // MOV AX,0x30 (1000_4FA1 / 0x14FA1)
    AX = 0x30;
    // CALL 0x1000:c085 (1000_4FA4 / 0x14FA4)
    NearCall(cs1, 0x4FA7, spice86_generated_label_call_target_1000_C085_01C085);
    label_1000_4FA7_14FA7:
    // CALL 0x1000:c22f (1000_4FA7 / 0x14FA7)
    NearCall(cs1, 0x4FAA, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_4FAA_14FAA:
    // CALL 0x1000:c07c (1000_4FAA / 0x14FAA)
    NearCall(cs1, 0x4FAD, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_4FAD_14FAD:
    // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_4E8E_014E8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_4FB0_14FB0:
    // MOV word ptr [0x1c06],0x0 (1000_4FB0 / 0x14FB0)
    UInt16[DS, 0x1C06] = 0x0;
    // MOV AL,[0x11c9] (1000_4FB6 / 0x14FB6)
    AL = UInt8[DS, 0x11C9];
    // AND AL,0x1 (1000_4FB9 / 0x14FB9)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    // MOV [0x4732],AL (1000_4FBB / 0x14FBB)
    UInt8[DS, 0x4732] = AL;
    // JNZ 0x1000:4fc3 (1000_4FBE / 0x14FBE)
    if(!ZeroFlag) {
      goto label_1000_4FC3_14FC3;
    }
    // CALL 0x1000:ca01 (1000_4FC0 / 0x14FC0)
    NearCall(cs1, 0x4FC3, spice86_generated_label_call_target_1000_CA01_01CA01);
    label_1000_4FC3_14FC3:
    // CALL 0x1000:e3cc (1000_4FC3 / 0x14FC3)
    NearCall(cs1, 0x4FC6, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    label_1000_4FC6_14FC6:
    // MOV [0xc5],AL (1000_4FC6 / 0x14FC6)
    UInt8[DS, 0xC5] = AL;
    // XOR AL,AL (1000_4FC9 / 0x14FC9)
    AL = 0;
    // MOV [0x4727],AL (1000_4FCB / 0x14FCB)
    UInt8[DS, 0x4727] = AL;
    // XCHG byte ptr [0x11c9],AL (1000_4FCE / 0x14FCE)
    byte tmp_1000_4FCE = UInt8[DS, 0x11C9];
    UInt8[DS, 0x11C9] = AL;
    AL = tmp_1000_4FCE;
    // AND AL,0x3 (1000_4FD2 / 0x14FD2)
    AL &= 0x3;
    
    // DEC AL (1000_4FD4 / 0x14FD4)
    AL = Alu.Dec8(AL);
    // JNZ 0x1000:4fdf (1000_4FD6 / 0x14FD6)
    if(!ZeroFlag) {
      goto label_1000_4FDF_14FDF;
    }
    // MOV DI,word ptr [0x11c5] (1000_4FD8 / 0x14FD8)
    DI = UInt16[DS, 0x11C5];
    // INC byte ptr [DI + 0x15] (1000_4FDC / 0x14FDC)
    UInt8[DS, (ushort)(DI + 0x15)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0x15)]);
    label_1000_4FDF_14FDF:
    // CALL 0x1000:4ac4 (1000_4FDF / 0x14FDF)
    NearCall(cs1, 0x4FE2, spice86_generated_label_call_target_1000_4AC4_014AC4);
    label_1000_4FE2_14FE2:
    // CALL 0x1000:dbb2 (1000_4FE2 / 0x14FE2)
    NearCall(cs1, 0x4FE5, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_4FE5_14FE5:
    // CALL 0x1000:d717 (1000_4FE5 / 0x14FE5)
    NearCall(cs1, 0x4FE8, spice86_generated_label_call_target_1000_D717_01D717);
    label_1000_4FE8_14FE8:
    // MOV DI,word ptr [0x11c5] (1000_4FE8 / 0x14FE8)
    DI = UInt16[DS, 0x11C5];
    // MOV BX,word ptr [DI + 0x4] (1000_4FEC / 0x14FEC)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DX,word ptr [DI + 0x2] (1000_4FEF / 0x14FEF)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV word ptr [0x11c5],0x0 (1000_4FF2 / 0x14FF2)
    UInt16[DS, 0x11C5] = 0x0;
    // JMP 0x1000:4002 (1000_4FF8 / 0x14FF8)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_3F27_013F27, 0x14002 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_503C_01503C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_503C_1503C:
    // MOV byte ptr [0xfd],0x0 (1000_503C / 0x1503C)
    UInt8[DS, 0xFD] = 0x0;
    // MOV byte ptr [0x2b],0x0 (1000_5041 / 0x15041)
    UInt8[DS, 0x2B] = 0x0;
    // TEST byte ptr [DI + 0xa],0x2 (1000_5046 / 0x15046)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:5058 (1000_504A / 0x1504A)
    if(!ZeroFlag) {
      goto label_1000_5058_15058;
    }
    // CALL 0x1000:5d36 (1000_504C / 0x1504C)
    NearCall(cs1, 0x504F, spice86_generated_label_call_target_1000_5D36_015D36);
    label_1000_504F_1504F:
    // JC 0x1000:5081 (1000_504F / 0x1504F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5081 / 0x15081)
      return NearRet();
    }
    // CALL 0x1000:5098 (1000_5051 / 0x15051)
    throw FailAsUntested("Could not find a valid function at address 1000_5098 / 0x15098");
    // OR DX,DX (1000_5054 / 0x15054)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:507a (1000_5056 / 0x15056)
    if(ZeroFlag) {
      goto label_1000_507A_1507A;
    }
    label_1000_5058_15058:
    // INC byte ptr [0x2b] (1000_5058 / 0x15058)
    UInt8[DS, 0x2B] = Alu.Inc8(UInt8[DS, 0x2B]);
    // CALL 0x1000:6144 (1000_505C / 0x1505C)
    throw FailAsUntested("Could not find a valid function at address 1000_6144 / 0x16144");
    // MOV AL,byte ptr [DI + 0x8] (1000_505F / 0x1505F)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    // MOV AH,0x2f (1000_5062 / 0x15062)
    AH = 0x2F;
    // CMP AL,0x20 (1000_5064 / 0x15064)
    Alu.Sub8(AL, 0x20);
    // JC 0x1000:5075 (1000_5066 / 0x15066)
    if(CarryFlag) {
      goto label_1000_5075_15075;
    }
    // INC AH (1000_5068 / 0x15068)
    AH = Alu.Inc8(AH);
    // CMP AL,0x30 (1000_506A / 0x1506A)
    Alu.Sub8(AL, 0x30);
    // JZ 0x1000:5075 (1000_506C / 0x1506C)
    if(ZeroFlag) {
      goto label_1000_5075_15075;
    }
    // SUB AL,0x28 (1000_506E / 0x1506E)
    // AL -= 0x28;
    AL = Alu.Sub8(AL, 0x28);
    // JC 0x1000:5075 (1000_5070 / 0x15070)
    if(CarryFlag) {
      goto label_1000_5075_15075;
    }
    // ADD AH,0x3 (1000_5072 / 0x15072)
    // AH += 0x3;
    AH = Alu.Add8(AH, 0x3);
    label_1000_5075_15075:
    // MOV byte ptr [0x11dd],AH (1000_5075 / 0x15075)
    UInt8[DS, 0x11DD] = AH;
    // RET  (1000_5079 / 0x15079)
    return NearRet();
    label_1000_507A_1507A:
    // JCXZ 0x1000:5081 (1000_507A / 0x1507A)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_5081 / 0x15081)
      return NearRet();
    }
    // MOV byte ptr [0x46d9],0x4 (1000_507C / 0x1507C)
    UInt8[DS, 0x46D9] = 0x4;
    label_1000_5081_15081:
    // RET  (1000_5081 / 0x15081)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_50BE_0150BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_50BE_150BE:
    // MOV byte ptr [0x11cb],0x0 (1000_50BE / 0x150BE)
    UInt8[DS, 0x11CB] = 0x0;
    // RET  (1000_50C3 / 0x150C3)
    return NearRet();
  }
  
  public Action split_1000_5119_015119(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5119_15119:
    // ADD byte ptr [0x11c7],AL (1000_5119 / 0x15119)
    // UInt8[DS, 0x11C7] += AL;
    UInt8[DS, 0x11C7] = Alu.Add8(UInt8[DS, 0x11C7], AL);
    // MOV word ptr [0x11cc],0x80 (1000_511D / 0x1511D)
    UInt16[DS, 0x11CC] = 0x80;
    // RET  (1000_5123 / 0x15123)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5124_015124(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5124_15124:
    // PUSH DI (1000_5124 / 0x15124)
    Stack.Push(DI);
    // CALL 0x1000:407e (1000_5125 / 0x15125)
    NearCall(cs1, 0x5128, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_5128_15128:
    // MOV CX,word ptr [DI + 0x4] (1000_5128 / 0x15128)
    CX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DI,word ptr [DI + 0x2] (1000_512B / 0x1512B)
    DI = UInt16[DS, (ushort)(DI + 0x2)];
    // CALL 0x1000:5133 (1000_512E / 0x1512E)
    NearCall(cs1, 0x5131, spice86_generated_label_call_target_1000_5133_015133);
    label_1000_5131_15131:
    // POP DI (1000_5131 / 0x15131)
    DI = Stack.Pop();
    // RET  (1000_5132 / 0x15132)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5133_015133(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5133_15133:
    // SUB BX,CX (1000_5133 / 0x15133)
    BX -= CX;
    
    // NEG BX (1000_5135 / 0x15135)
    BX = Alu.Sub16(0, BX);
    // SUB DX,DI (1000_5137 / 0x15137)
    DX -= DI;
    
    // NEG DX (1000_5139 / 0x15139)
    DX = Alu.Sub16(0, DX);
    // CMP BX,-0x80 (1000_513B / 0x1513B)
    Alu.Sub16(BX, 0xFF80);
    // JL 0x1000:5146 (1000_513E / 0x1513E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5146_15146;
    }
    // CMP BX,0x80 (1000_5140 / 0x15140)
    Alu.Sub16(BX, 0x80);
    // JL 0x1000:514a (1000_5144 / 0x15144)
    if(SignFlag != OverflowFlag) {
      goto label_1000_514A_1514A;
    }
    label_1000_5146_15146:
    // SAR BX,0x1 (1000_5146 / 0x15146)
    BX = Alu.Sar16(BX, 0x1);
    // SAR DX,0x1 (1000_5148 / 0x15148)
    DX = Alu.Sar16(DX, 0x1);
    label_1000_514A_1514A:
    // MOV BH,BL (1000_514A / 0x1514A)
    BH = BL;
    // XOR BL,BL (1000_514C / 0x1514C)
    BL = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_514E_01514E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_514E_01514E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_514E_1514E:
    // OR BX,BX (1000_514E / 0x1514E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // MOV AX,BX (1000_5150 / 0x15150)
    AX = BX;
    // JNS 0x1000:5156 (1000_5152 / 0x15152)
    if(!SignFlag) {
      goto label_1000_5156_15156;
    }
    // NEG AX (1000_5154 / 0x15154)
    AX = Alu.Sub16(0, AX);
    label_1000_5156_15156:
    // OR DX,DX (1000_5156 / 0x15156)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // MOV DI,DX (1000_5158 / 0x15158)
    DI = DX;
    // MOV CX,DX (1000_515A / 0x1515A)
    CX = DX;
    // JNS 0x1000:5160 (1000_515C / 0x1515C)
    if(!SignFlag) {
      goto label_1000_5160_15160;
    }
    // NEG CX (1000_515E / 0x1515E)
    CX = Alu.Sub16(0, CX);
    label_1000_5160_15160:
    // CMP CX,AX (1000_5160 / 0x15160)
    Alu.Sub16(CX, AX);
    // JC 0x1000:5180 (1000_5162 / 0x15162)
    if(CarryFlag) {
      goto label_1000_5180_15180;
    }
    // CMP CX,0x1 (1000_5164 / 0x15164)
    Alu.Sub16(CX, 0x1);
    // JC 0x1000:517f (1000_5167 / 0x15167)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_517F / 0x1517F)
      return NearRet();
    }
    // MOV AX,0x20 (1000_5169 / 0x15169)
    AX = 0x20;
    // MOV CX,DX (1000_516C / 0x1516C)
    CX = DX;
    // IMUL BX (1000_516E / 0x1516E)
    Cpu.IMul16(BX);
    // IDIV CX (1000_5170 / 0x15170)
    Cpu.IDiv16(CX);
    // MOV DX,DI (1000_5172 / 0x15172)
    DX = DI;
    // OR CX,CX (1000_5174 / 0x15174)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JS 0x1000:517c (1000_5176 / 0x15176)
    if(SignFlag) {
      goto label_1000_517C_1517C;
    }
    // ADD AL,0x40 (1000_5178 / 0x15178)
    // AL += 0x40;
    AL = Alu.Add8(AL, 0x40);
    // CLC  (1000_517A / 0x1517A)
    CarryFlag = false;
    // RET  (1000_517B / 0x1517B)
    return NearRet();
    label_1000_517C_1517C:
    // ADD AL,0xc0 (1000_517C / 0x1517C)
    // AL += 0xC0;
    AL = Alu.Add8(AL, 0xC0);
    // CLC  (1000_517E / 0x1517E)
    CarryFlag = false;
    label_1000_517F_1517F:
    // RET  (1000_517F / 0x1517F)
    return NearRet();
    label_1000_5180_15180:
    // CMP AX,0x1 (1000_5180 / 0x15180)
    Alu.Sub16(AX, 0x1);
    // JC 0x1000:517f (1000_5183 / 0x15183)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_517F / 0x1517F)
      return NearRet();
    }
    // MOV AX,0x20 (1000_5185 / 0x15185)
    AX = 0x20;
    // IMUL DX (1000_5188 / 0x15188)
    Cpu.IMul16(DX);
    // IDIV BX (1000_518A / 0x1518A)
    Cpu.IDiv16(BX);
    // MOV DX,DI (1000_518C / 0x1518C)
    DX = DI;
    // OR BX,BX (1000_518E / 0x1518E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JS 0x1000:5194 (1000_5190 / 0x15190)
    if(SignFlag) {
      goto label_1000_5194_15194;
    }
    // SUB AL,0x80 (1000_5192 / 0x15192)
    AL -= 0x80;
    
    label_1000_5194_15194:
    // NEG AL (1000_5194 / 0x15194)
    AL = Alu.Sub8(0, AL);
    // CLC  (1000_5196 / 0x15196)
    CarryFlag = false;
    // RET  (1000_5197 / 0x15197)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5198_015198(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5198_15198:
    // MOV BX,AX (1000_5198 / 0x15198)
    BX = AX;
    // ADD BL,0x20 (1000_519A / 0x1519A)
    // BL += 0x20;
    BL = Alu.Add8(BL, 0x20);
    // MOV BH,BL (1000_519D / 0x1519D)
    BH = BL;
    // AND BH,0x7f (1000_519F / 0x1519F)
    BH &= 0x7F;
    
    // CMP BH,0x40 (1000_51A2 / 0x151A2)
    Alu.Sub8(BH, 0x40);
    // JC 0x1000:51ba (1000_51A5 / 0x151A5)
    if(CarryFlag) {
      goto label_1000_51BA_151BA;
    }
    // MOV DX,0x20 (1000_51A7 / 0x151A7)
    DX = 0x20;
    // SUB AL,0x40 (1000_51AA / 0x151AA)
    // AL -= 0x40;
    AL = Alu.Sub8(AL, 0x40);
    // OR BL,BL (1000_51AC / 0x151AC)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JNS 0x1000:51b6 (1000_51AE / 0x151AE)
    if(!SignFlag) {
      goto label_1000_51B6_151B6;
    }
    // NEG DX (1000_51B0 / 0x151B0)
    DX = Alu.Sub16(0, DX);
    // SUB AL,0x80 (1000_51B2 / 0x151B2)
    AL -= 0x80;
    
    // NEG AL (1000_51B4 / 0x151B4)
    AL = Alu.Sub8(0, AL);
    label_1000_51B6_151B6:
    // CBW  (1000_51B6 / 0x151B6)
    AX = (ushort)((short)((sbyte)AL));
    // MOV BX,AX (1000_51B7 / 0x151B7)
    BX = AX;
    // RET  (1000_51B9 / 0x151B9)
    return NearRet();
    label_1000_51BA_151BA:
    // OR BL,BL (1000_51BA / 0x151BA)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // MOV BX,0xffe0 (1000_51BC / 0x151BC)
    BX = 0xFFE0;
    // JNS 0x1000:51c7 (1000_51BF / 0x151BF)
    if(!SignFlag) {
      goto label_1000_51C7_151C7;
    }
    // SUB AL,0x80 (1000_51C1 / 0x151C1)
    AL -= 0x80;
    
    // NEG AL (1000_51C3 / 0x151C3)
    AL = Alu.Sub8(0, AL);
    // NEG BX (1000_51C5 / 0x151C5)
    BX = Alu.Sub16(0, BX);
    label_1000_51C7_151C7:
    // CBW  (1000_51C7 / 0x151C7)
    AX = (ushort)((short)((sbyte)AL));
    // MOV DX,AX (1000_51C8 / 0x151C8)
    DX = AX;
    // RET  (1000_51CA / 0x151CA)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_51CB_0151CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_51CB_151CB:
    // CMP byte ptr [0x11cb],0x0 (1000_51CB / 0x151CB)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    // JNZ 0x1000:51d9 (1000_51D0 / 0x151D0)
    if(!ZeroFlag) {
      goto label_1000_51D9_151D9;
    }
    // CMP byte ptr [0x11c8],0x0 (1000_51D2 / 0x151D2)
    Alu.Sub8(UInt8[DS, 0x11C8], 0x0);
    // JZ 0x1000:51f5 (1000_51D7 / 0x151D7)
    if(ZeroFlag) {
      goto label_1000_51F5_151F5;
    }
    label_1000_51D9_151D9:
    // CMP BX,-0x4d (1000_51D9 / 0x151D9)
    Alu.Sub16(BX, 0xFFB3);
    // JL 0x1000:51e3 (1000_51DC / 0x151DC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_51E3_151E3;
    }
    // CMP BX,0x4d (1000_51DE / 0x151DE)
    Alu.Sub16(BX, 0x4D);
    // JLE 0x1000:5205 (1000_51E1 / 0x151E1)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    label_1000_51E3_151E3:
    // MOV AL,[0x11c7] (1000_51E3 / 0x151E3)
    AL = UInt8[DS, 0x11C7];
    // MOV AH,AL (1000_51E6 / 0x151E6)
    AH = AL;
    // SUB AH,0x40 (1000_51E8 / 0x151E8)
    AH -= 0x40;
    
    // XOR AH,BH (1000_51EB / 0x151EB)
    // AH ^= BH;
    AH = Alu.Xor8(AH, BH);
    // JS 0x1000:5205 (1000_51ED / 0x151ED)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    // AND AL,0x80 (1000_51EF / 0x151EF)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    // OR AL,0x40 (1000_51F1 / 0x151F1)
    // AL |= 0x40;
    AL = Alu.Or8(AL, 0x40);
    // JMP 0x1000:5202 (1000_51F3 / 0x151F3)
    goto label_1000_5202_15202;
    label_1000_51F5_151F5:
    // MOV DI,word ptr [0x11c5] (1000_51F5 / 0x151F5)
    DI = UInt16[DS, 0x11C5];
    // PUSH BX (1000_51F9 / 0x151F9)
    Stack.Push(BX);
    // PUSH DX (1000_51FA / 0x151FA)
    Stack.Push(DX);
    // CALL 0x1000:5124 (1000_51FB / 0x151FB)
    NearCall(cs1, 0x51FE, spice86_generated_label_call_target_1000_5124_015124);
    label_1000_51FE_151FE:
    // POP DX (1000_51FE / 0x151FE)
    DX = Stack.Pop();
    // POP BX (1000_51FF / 0x151FF)
    BX = Stack.Pop();
    // JC 0x1000:5205 (1000_5200 / 0x15200)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    label_1000_5202_15202:
    // MOV [0x11c7],AL (1000_5202 / 0x15202)
    UInt8[DS, 0x11C7] = AL;
    label_1000_5205_15205:
    // RET  (1000_5205 / 0x15205)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5206_015206(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5206_15206:
    // CALL 0x1000:51cb (1000_5206 / 0x15206)
    NearCall(cs1, 0x5209, spice86_generated_label_call_target_1000_51CB_0151CB);
    label_1000_5209_15209:
    // MOV AL,[0x11c7] (1000_5209 / 0x15209)
    AL = UInt8[DS, 0x11C7];
    // PUSH DX (1000_520C / 0x1520C)
    Stack.Push(DX);
    // PUSH BX (1000_520D / 0x1520D)
    Stack.Push(BX);
    // SHL BX,0x1 (1000_520E / 0x1520E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // JNS 0x1000:5214 (1000_5210 / 0x15210)
    if(!SignFlag) {
      goto label_1000_5214_15214;
    }
    // NEG BX (1000_5212 / 0x15212)
    BX = Alu.Sub16(0, BX);
    label_1000_5214_15214:
    // MOV BP,word ptr [BX + 0x4880] (1000_5214 / 0x15214)
    BP = UInt16[DS, (ushort)(BX + 0x4880)];
    // CALL 0x1000:5198 (1000_5218 / 0x15218)
    NearCall(cs1, 0x521B, spice86_generated_label_call_target_1000_5198_015198);
    label_1000_521B_1521B:
    // MOV CX,0x20 (1000_521B / 0x1521B)
    CX = 0x20;
    // MOV AX,BP (1000_521E / 0x1521E)
    AX = BP;
    // IMUL DX (1000_5220 / 0x15220)
    Cpu.IMul16(DX);
    // IDIV CX (1000_5222 / 0x15222)
    Cpu.IDiv16(CX);
    // XCHG AX,BX (1000_5224 / 0x15224)
    ushort tmp_1000_5224 = AX;
    AX = BX;
    BX = tmp_1000_5224;
    // IMUL BP (1000_5225 / 0x15225)
    Cpu.IMul16(BP);
    // IDIV CX (1000_5227 / 0x15227)
    Cpu.IDiv16(CX);
    // MOV DX,BX (1000_5229 / 0x15229)
    DX = BX;
    // MOV BX,AX (1000_522B / 0x1522B)
    BX = AX;
    // OR AX,AX (1000_522D / 0x1522D)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:5233 (1000_522F / 0x1522F)
    if(!SignFlag) {
      goto label_1000_5233_15233;
    }
    // NEG AX (1000_5231 / 0x15231)
    AX = Alu.Sub16(0, AX);
    label_1000_5233_15233:
    // ADD AX,word ptr [0x11cc] (1000_5233 / 0x15233)
    AX += UInt16[DS, 0x11CC];
    
    // CMP AH,0x1 (1000_5237 / 0x15237)
    Alu.Sub8(AH, 0x1);
    // JBE 0x1000:524e (1000_523A / 0x1523A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_524E_1524E;
    }
    // MOV CX,AX (1000_523C / 0x1523C)
    CX = AX;
    // MOV AX,DX (1000_523E / 0x1523E)
    AX = DX;
    // CWD  (1000_5240 / 0x15240)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    // MOV DL,AH (1000_5241 / 0x15241)
    DL = AH;
    // MOV AH,AL (1000_5243 / 0x15243)
    AH = AL;
    // XOR AL,AL (1000_5245 / 0x15245)
    AL = 0;
    // IDIV CX (1000_5247 / 0x15247)
    Cpu.IDiv16(CX);
    // MOV DX,AX (1000_5249 / 0x15249)
    DX = AX;
    // MOV AX,0x100 (1000_524B / 0x1524B)
    AX = 0x100;
    label_1000_524E_1524E:
    // MOV [0x11cc],AL (1000_524E / 0x1524E)
    UInt8[DS, 0x11CC] = AL;
    // MOV AL,AH (1000_5251 / 0x15251)
    AL = AH;
    // CBW  (1000_5253 / 0x15253)
    AX = (ushort)((short)((sbyte)AL));
    // OR BX,BX (1000_5254 / 0x15254)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNS 0x1000:525a (1000_5256 / 0x15256)
    if(!SignFlag) {
      goto label_1000_525A_1525A;
    }
    // NEG AX (1000_5258 / 0x15258)
    AX = Alu.Sub16(0, AX);
    label_1000_525A_1525A:
    // POP BX (1000_525A / 0x1525A)
    BX = Stack.Pop();
    // ADD BX,AX (1000_525B / 0x1525B)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // POP AX (1000_525D / 0x1525D)
    AX = Stack.Pop();
    // ADD DX,AX (1000_525E / 0x1525E)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // MOV AX,BX (1000_5260 / 0x15260)
    AX = BX;
    // ADD AX,0x60 (1000_5262 / 0x15262)
    AX += 0x60;
    
    // CMP AX,0xc0 (1000_5265 / 0x15265)
    Alu.Sub16(AX, 0xC0);
    // JC 0x1000:5273 (1000_5268 / 0x15268)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5273 / 0x15273)
      return NearRet();
    }
    // ADD byte ptr [0x11c7],0x80 (1000_526A / 0x1526A)
    UInt8[DS, 0x11C7] += 0x80;
    
    // ADD DX,0x8000 (1000_526F / 0x1526F)
    // DX += 0x8000;
    DX = Alu.Add16(DX, 0x8000);
    label_1000_5273_15273:
    // RET  (1000_5273 / 0x15273)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5274_015274(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5274_15274:
    // MOV DX,word ptr [DI + 0x2] (1000_5274 / 0x15274)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_5277 / 0x15277)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // PUSH SI (1000_527A / 0x1527A)
    Stack.Push(SI);
    // MOV AX,0xffff (1000_527B / 0x1527B)
    AX = 0xFFFF;
    // MOV [0xca],AX (1000_527E / 0x1527E)
    UInt16[DS, 0xCA] = AX;
    // MOV [0xd0],AX (1000_5281 / 0x15281)
    UInt16[DS, 0xD0] = AX;
    // MOV [0xd6],AX (1000_5284 / 0x15284)
    UInt16[DS, 0xD6] = AX;
    // MOV [0xdc],AX (1000_5287 / 0x15287)
    UInt16[DS, 0xDC] = AX;
    // MOV [0xe2],AX (1000_528A / 0x1528A)
    UInt16[DS, 0xE2] = AX;
    // MOV SI,0x100 (1000_528D / 0x1528D)
    SI = 0x100;
    label_1000_5290_15290:
    // CMP word ptr [SI],-0x1 (1000_5290 / 0x15290)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JZ 0x1000:52fb (1000_5293 / 0x15293)
    if(ZeroFlag) {
      goto label_1000_52FB_152FB;
    }
    // CMP SI,DI (1000_5295 / 0x15295)
    Alu.Sub16(SI, DI);
    // JZ 0x1000:52f6 (1000_5297 / 0x15297)
    if(ZeroFlag) {
      goto label_1000_52F6_152F6;
    }
    // MOV CX,word ptr [SI + 0x2] (1000_5299 / 0x15299)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    // SUB CX,DX (1000_529C / 0x1529C)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    // JNS 0x1000:52a2 (1000_529E / 0x1529E)
    if(!SignFlag) {
      goto label_1000_52A2_152A2;
    }
    // NEG CX (1000_52A0 / 0x152A0)
    CX = Alu.Sub16(0, CX);
    label_1000_52A2_152A2:
    // MOV AX,word ptr [SI + 0x4] (1000_52A2 / 0x152A2)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // SUB AX,BX (1000_52A5 / 0x152A5)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JNS 0x1000:52ab (1000_52A7 / 0x152A7)
    if(!SignFlag) {
      goto label_1000_52AB_152AB;
    }
    // NEG AX (1000_52A9 / 0x152A9)
    AX = Alu.Sub16(0, AX);
    label_1000_52AB_152AB:
    // MOV CL,CH (1000_52AB / 0x152AB)
    CL = CH;
    // XOR CH,CH (1000_52AD / 0x152AD)
    CH = 0;
    // CMP CL,AL (1000_52AF / 0x152AF)
    Alu.Sub8(CL, AL);
    // JNC 0x1000:52b5 (1000_52B1 / 0x152B1)
    if(!CarryFlag) {
      goto label_1000_52B5_152B5;
    }
    // MOV CX,AX (1000_52B3 / 0x152B3)
    CX = AX;
    label_1000_52B5_152B5:
    // CMP byte ptr [SI + 0x8],0x28 (1000_52B5 / 0x152B5)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x8)], 0x28);
    // JC 0x1000:52c9 (1000_52B9 / 0x152B9)
    if(CarryFlag) {
      goto label_1000_52C9_152C9;
    }
    // MOV BP,0xe2 (1000_52BB / 0x152BB)
    BP = 0xE2;
    // TEST byte ptr [SI + 0xa],0x80 (1000_52BE / 0x152BE)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JNZ 0x1000:52dd (1000_52C2 / 0x152C2)
    if(!ZeroFlag) {
      goto label_1000_52DD_152DD;
    }
    // MOV BP,0xdc (1000_52C4 / 0x152C4)
    BP = 0xDC;
    // JMP 0x1000:52dd (1000_52C7 / 0x152C7)
    goto label_1000_52DD_152DD;
    label_1000_52C9_152C9:
    // MOV BP,0xd0 (1000_52C9 / 0x152C9)
    BP = 0xD0;
    // TEST byte ptr [SI + 0xa],0x80 (1000_52CC / 0x152CC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JZ 0x1000:52dd (1000_52D0 / 0x152D0)
    if(ZeroFlag) {
      goto label_1000_52DD_152DD;
    }
    // MOV AL,[0x2a] (1000_52D2 / 0x152D2)
    AL = UInt8[DS, 0x2A];
    // CMP AL,byte ptr [SI + 0xb] (1000_52D5 / 0x152D5)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    // JC 0x1000:52f6 (1000_52D8 / 0x152D8)
    if(CarryFlag) {
      goto label_1000_52F6_152F6;
    }
    // MOV BP,0xd6 (1000_52DA / 0x152DA)
    BP = 0xD6;
    label_1000_52DD_152DD:
    // CMP CX,word ptr [BP + 0x0] (1000_52DD / 0x152DD)
    Alu.Sub16(CX, UInt16[SS, BP]);
    // JNC 0x1000:52e8 (1000_52E0 / 0x152E0)
    if(!CarryFlag) {
      goto label_1000_52E8_152E8;
    }
    // MOV word ptr [BP + 0x0],CX (1000_52E2 / 0x152E2)
    UInt16[SS, BP] = CX;
    // MOV word ptr [BP + 0x2],SI (1000_52E5 / 0x152E5)
    UInt16[SS, (ushort)(BP + 0x2)] = SI;
    label_1000_52E8_152E8:
    // CMP CX,word ptr [0xca] (1000_52E8 / 0x152E8)
    Alu.Sub16(CX, UInt16[DS, 0xCA]);
    // JNC 0x1000:52f6 (1000_52EC / 0x152EC)
    if(!CarryFlag) {
      goto label_1000_52F6_152F6;
    }
    // MOV word ptr [0xca],CX (1000_52EE / 0x152EE)
    UInt16[DS, 0xCA] = CX;
    // MOV word ptr [0xcc],SI (1000_52F2 / 0x152F2)
    UInt16[DS, 0xCC] = SI;
    label_1000_52F6_152F6:
    // ADD SI,0x1c (1000_52F6 / 0x152F6)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    // JMP 0x1000:5290 (1000_52F9 / 0x152F9)
    goto label_1000_5290_15290;
    label_1000_52FB_152FB:
    // PUSH DI (1000_52FB / 0x152FB)
    Stack.Push(DI);
    // MOV BP,0xde (1000_52FC / 0x152FC)
    BP = 0xDE;
    // CALL 0x1000:5323 (1000_52FF / 0x152FF)
    NearCall(cs1, 0x5302, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_5302_15302:
    // MOV BP,0xe4 (1000_5302 / 0x15302)
    BP = 0xE4;
    // CALL 0x1000:5323 (1000_5305 / 0x15305)
    NearCall(cs1, 0x5308, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_5308_15308:
    // MOV BP,0xd8 (1000_5308 / 0x15308)
    BP = 0xD8;
    // CALL 0x1000:5323 (1000_530B / 0x1530B)
    NearCall(cs1, 0x530E, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_530E_1530E:
    // ADD AX,0xda (1000_530E / 0x1530E)
    // AX += 0xDA;
    AX = Alu.Add16(AX, 0xDA);
    // MOV [0x11fd],AX (1000_5311 / 0x15311)
    UInt16[DS, 0x11FD] = AX;
    // MOV BP,0xcc (1000_5314 / 0x15314)
    BP = 0xCC;
    // CALL 0x1000:5323 (1000_5317 / 0x15317)
    NearCall(cs1, 0x531A, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_531A_1531A:
    // MOV BP,0xd2 (1000_531A / 0x1531A)
    BP = 0xD2;
    // CALL 0x1000:5323 (1000_531D / 0x1531D)
    NearCall(cs1, 0x5320, spice86_generated_label_call_target_1000_5323_015323);
    label_1000_5320_15320:
    // POP DI (1000_5320 / 0x15320)
    DI = Stack.Pop();
    // POP SI (1000_5321 / 0x15321)
    SI = Stack.Pop();
    // RET  (1000_5322 / 0x15322)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5323_015323(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5323_15323:
    // PUSH BX (1000_5323 / 0x15323)
    Stack.Push(BX);
    // PUSH DX (1000_5324 / 0x15324)
    Stack.Push(DX);
    // MOV DI,word ptr [BP + 0x0] (1000_5325 / 0x15325)
    DI = UInt16[SS, BP];
    // MOV CX,word ptr [DI + 0x4] (1000_5328 / 0x15328)
    CX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV DI,word ptr [DI + 0x2] (1000_532B / 0x1532B)
    DI = UInt16[DS, (ushort)(DI + 0x2)];
    // PUSH BP (1000_532E / 0x1532E)
    Stack.Push(BP);
    // CALL 0x1000:5133 (1000_532F / 0x1532F)
    NearCall(cs1, 0x5332, spice86_generated_label_call_target_1000_5133_015133);
    label_1000_5332_15332:
    // POP BP (1000_5332 / 0x15332)
    BP = Stack.Pop();
    // ADD AL,0x10 (1000_5333 / 0x15333)
    AL += 0x10;
    
    // ROL AL,0x1 (1000_5335 / 0x15335)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,0x1 (1000_5337 / 0x15337)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,0x1 (1000_5339 / 0x15339)
    AL = Alu.Rol8(AL, 0x1);
    // AND AX,0x7 (1000_533B / 0x1533B)
    // AX &= 0x7;
    AX = Alu.And16(AX, 0x7);
    // MOV byte ptr [BP + 0x2],AL (1000_533E / 0x1533E)
    UInt8[SS, (ushort)(BP + 0x2)] = AL;
    // POP DX (1000_5341 / 0x15341)
    DX = Stack.Pop();
    // POP BX (1000_5342 / 0x15342)
    BX = Stack.Pop();
    // RET  (1000_5343 / 0x15343)
    return NearRet();
  }
  
  public Action split_1000_5575_015575(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5575_15575:
    // MOV SI,0x4710 (1000_5575 / 0x15575)
    SI = 0x4710;
    // JMP 0x1000:daaa (1000_5578 / 0x15578)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAAA_01DAAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action map_func_ida_1000_55DD_155DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_55DD_155DD:
    // PUSH DS (1000_55DD / 0x155DD)
    Stack.Push(DS);
    // OR AL,AL (1000_55DE / 0x155DE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:5603 (1000_55E0 / 0x155E0)
    if(ZeroFlag) {
      goto label_1000_5603_15603;
    }
    // LES DI,[0xdbb0] (1000_55E2 / 0x155E2)
    ES = UInt16[DS, 0xDBB2];
    DI = UInt16[DS, 0xDBB0];
    // MOV DS,word ptr [0xdd00] (1000_55E6 / 0x155E6)
    DS = UInt16[DS, 0xDD00];
    // MOV CX,0xc5f9 (1000_55EA / 0x155EA)
    CX = 0xC5F9;
    label_1000_55ED_155ED:
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_55ED / 0x155ED)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    // JNZ 0x1000:5603 (1000_55EF / 0x155EF)
    if(!ZeroFlag) {
      goto label_1000_5603_15603;
    }
    // MOV AH,byte ptr [DI + -0x1] (1000_55F1 / 0x155F1)
    AH = UInt8[DS, (ushort)(DI - 0x1)];
    // AND AH,0x30 (1000_55F4 / 0x155F4)
    AH &= 0x30;
    
    // CMP AH,0x30 (1000_55F7 / 0x155F7)
    Alu.Sub8(AH, 0x30);
    // JNZ 0x1000:5600 (1000_55FA / 0x155FA)
    if(!ZeroFlag) {
      goto label_1000_5600_15600;
    }
    // AND byte ptr [DI + -0x1],0xef (1000_55FC / 0x155FC)
    UInt8[DS, (ushort)(DI - 0x1)] &= 0xEF;
    
    label_1000_5600_15600:
    // INC CX (1000_5600 / 0x15600)
    CX = Alu.Inc16(CX);
    // LOOP 0x1000:55ed (1000_5601 / 0x15601)
    if(--CX != 0) {
      goto label_1000_55ED_155ED;
    }
    label_1000_5603_15603:
    // POP DS (1000_5603 / 0x15603)
    DS = Stack.Pop();
    // RET  (1000_5604 / 0x15604)
    return NearRet();
  }
  
  public Action split_1000_5982_015982(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5982_15982:
    // CALL 0x1000:e270 (1000_5982 / 0x15982)
    NearCall(cs1, 0x5985, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV DX,word ptr [0x11c1] (1000_5985 / 0x15985)
    DX = UInt16[DS, 0x11C1];
    // MOV BX,word ptr [0x11c3] (1000_5989 / 0x15989)
    BX = UInt16[DS, 0x11C3];
    // MOV SI,0xaa (1000_598D / 0x1598D)
    SI = 0xAA;
    // MOV CX,0x6c (1000_5990 / 0x15990)
    CX = 0x6C;
    // MOV ES,word ptr [0xdbd8] (1000_5993 / 0x15993)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x3961] (1000_5997 / 0x15997)
    // Indirect call to [0x3961], generating possible targets from emulator records
    uint targetAddress_1000_5997 = (uint)(UInt16[DS, 0x3963] * 0x10 + UInt16[DS, 0x3961] - cs1 * 0x10);
    switch(targetAddress_1000_5997) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5997));
        break;
    }
    // CALL 0x1000:e283 (1000_599B / 0x1599B)
    NearCall(cs1, 0x599E, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_599E / 0x1599E)
    return NearRet();
    label_1000_599F_1599F:
    // XOR AL,AL (1000_599F / 0x1599F)
    AL = 0;
    // XCHG byte ptr [0x4723],AL (1000_59A1 / 0x159A1)
    byte tmp_1000_59A1 = UInt8[DS, 0x4723];
    UInt8[DS, 0x4723] = AL;
    AL = tmp_1000_59A1;
    // OR AL,AL (1000_59A5 / 0x159A5)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:5a02 (1000_59A7 / 0x159A7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5A02 / 0x15A02)
      return NearRet();
    }
    // CALL 0x1000:557b (1000_59A9 / 0x159A9)
    throw FailAsUntested("Could not find a valid function at address 1000_557B / 0x1557B");
    // CMP DX,word ptr [0x11c1] (1000_59AC / 0x159AC)
    Alu.Sub16(DX, UInt16[DS, 0x11C1]);
    // JNZ 0x1000:59b8 (1000_59B0 / 0x159B0)
    if(!ZeroFlag) {
      goto label_1000_59B8_159B8;
    }
    // CMP BX,word ptr [0x11c3] (1000_59B2 / 0x159B2)
    Alu.Sub16(BX, UInt16[DS, 0x11C3]);
    // JZ 0x1000:5982 (1000_59B6 / 0x159B6)
    if(ZeroFlag) {
      goto label_1000_5982_15982;
    }
    label_1000_59B8_159B8:
    // MOV word ptr [0xdbe0],0x0 (1000_59B8 / 0x159B8)
    UInt16[DS, 0xDBE0] = 0x0;
    // JMP 0x1000:5b10 (1000_59BE / 0x159BE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5B10_015B10, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_5A02_015A02(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5A02_15A02:
    // RET  (1000_5A02 / 0x15A02)
    return NearRet();
  }
  
  public Action split_1000_5A1A_015A1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5A1A_15A1A:
    // MOV byte ptr [0x28e7],0x1 (1000_5A1A / 0x15A1A)
    UInt8[DS, 0x28E7] = 0x1;
    // CALL 0x1000:18ba (1000_5A1F / 0x15A1F)
    NearCall(cs1, 0x5A22, spice86_generated_label_call_target_1000_18BA_0118BA);
    label_1000_5A22_15A22:
    // CALL 0x1000:5b5d (1000_5A22 / 0x15A22)
    NearCall(cs1, 0x5A25, spice86_generated_label_call_target_1000_5B5D_015B5D);
    label_1000_5A25_15A25:
    // MOV BP,0x5a56 (1000_5A25 / 0x15A25)
    BP = 0x5A56;
    // MOV AL,0x34 (1000_5A28 / 0x15A28)
    AL = 0x34;
    // MOV DX,0xffff (1000_5A2A / 0x15A2A)
    DX = 0xFFFF;
    // CALL 0x1000:c108 (1000_5A2D / 0x15A2D)
    NearCall(cs1, 0x5A30, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_5A30_15A30:
    // CMP byte ptr [0x46f3],0x0 (1000_5A30 / 0x15A30)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x0);
    // JNZ 0x1000:5a3a (1000_5A35 / 0x15A35)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:17e6 (1000_5A3A / 0x15A3A)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:5bb0 (1000_5A37 / 0x15A37)
    NearCall(cs1, 0x5A3A, spice86_generated_label_call_target_1000_5BB0_015BB0);
    label_1000_5A3A_15A3A:
    // JMP 0x1000:17e6 (1000_5A3A / 0x15A3A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5A56_015A56(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5A56_15A56:
    // CMP byte ptr [0x46eb],0x0 (1000_5A56 / 0x15A56)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:5a9a (1000_5A5B / 0x15A5B)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5A9A_015A9A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:d2bd (1000_5A5D / 0x15A5D)
    NearCall(cs1, 0x5A60, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    label_1000_5A60_15A60:
    // CALL 0x1000:4aca (1000_5A60 / 0x15A60)
    NearCall(cs1, 0x5A63, spice86_generated_label_call_target_1000_4ACA_014ACA);
    label_1000_5A63_15A63:
    // CALL 0x1000:b930 (1000_5A63 / 0x15A63)
    NearCall(cs1, 0x5A66, spice86_generated_label_call_target_1000_B930_01B930);
    label_1000_5A66_15A66:
    // MOV SI,0x6b34 (1000_5A66 / 0x15A66)
    SI = 0x6B34;
    // MOV BP,0xf (1000_5A69 / 0x15A69)
    BP = 0xF;
    // CALL 0x1000:da25 (1000_5A6C / 0x15A6C)
    NearCall(cs1, 0x5A6F, spice86_generated_label_call_target_1000_DA25_01DA25);
    label_1000_5A6F_15A6F:
    // MOV SI,0x1482 (1000_5A6F / 0x15A6F)
    SI = 0x1482;
    // MOV DI,0x46e3 (1000_5A72 / 0x15A72)
    DI = 0x46E3;
    // CALL 0x1000:5b99 (1000_5A75 / 0x15A75)
    NearCall(cs1, 0x5A78, spice86_generated_label_call_target_1000_5B99_015B99);
    label_1000_5A78_15A78:
    // CALL 0x1000:5b69 (1000_5A78 / 0x15A78)
    NearCall(cs1, 0x5A7B, spice86_generated_label_call_target_1000_5B69_015B69);
    label_1000_5A7B_15A7B:
    // CALL 0x1000:1797 (1000_5A7B / 0x15A7B)
    NearCall(cs1, 0x5A7E, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_5A7E_15A7E:
    // MOV byte ptr [0x46eb],0x80 (1000_5A7E / 0x15A7E)
    UInt8[DS, 0x46EB] = 0x80;
    // CALL 0x1000:ad5e (1000_5A83 / 0x15A83)
    NearCall(cs1, 0x5A86, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    label_1000_5A86_15A86:
    // MOV word ptr [0x2786],0xc835 (1000_5A86 / 0x15A86)
    UInt16[DS, 0x2786] = 0xC835;
    // MOV AX,0x5a9a (1000_5A8C / 0x15A8C)
    AX = 0x5A9A;
    // MOV [0x46ed],AX (1000_5A8F / 0x15A8F)
    UInt16[DS, 0x46ED] = AX;
    // CALL AX (1000_5A92 / 0x15A92)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_5A92 = (uint)(AX);
    switch(targetAddress_1000_5A92) {
      case 0x5A9A : NearCall(cs1, 0x5A94, spice86_generated_label_call_target_1000_5A9A_015A9A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5A92));
        break;
    }
    label_1000_5A94_15A94:
    // CALL 0x1000:d792 (1000_5A94 / 0x15A94)
    NearCall(cs1, 0x5A97, spice86_generated_label_call_target_1000_D792_01D792);
    label_1000_5A97_15A97:
    // JMP 0x1000:d712 (1000_5A97 / 0x15A97)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D712_01D712, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5A9A_015A9A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5A9A_15A9A:
    // CALL 0x1000:c07c (1000_5A9A / 0x15A9A)
    NearCall(cs1, 0x5A9D, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_5A9D_15A9D:
    // CALL 0x1000:5b8d (1000_5A9D / 0x15A9D)
    NearCall(cs1, 0x5AA0, spice86_generated_label_call_target_1000_5B8D_015B8D);
    label_1000_5AA0_15AA0:
    // MOV AL,0x80 (1000_5AA0 / 0x15AA0)
    AL = 0x80;
    // XCHG byte ptr [0x46eb],AL (1000_5AA2 / 0x15AA2)
    byte tmp_1000_5AA2 = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_5AA2;
    // PUSH AX (1000_5AA6 / 0x15AA6)
    Stack.Push(AX);
    // CALL 0x1000:b6c3 (1000_5AA7 / 0x15AA7)
    NearCall(cs1, 0x5AAA, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    label_1000_5AAA_15AAA:
    // CALL 0x1000:c13b (1000_5AAA / 0x15AAA)
    NearCall(cs1, 0x5AAD, spice86_generated_label_call_target_1000_C13B_01C13B);
    label_1000_5AAD_15AAD:
    // CALL 0x1000:5dce (1000_5AAD / 0x15AAD)
    NearCall(cs1, 0x5AB0, spice86_generated_label_call_target_1000_5DCE_015DCE);
    label_1000_5AB0_15AB0:
    // CALL 0x1000:6314 (1000_5AB0 / 0x15AB0)
    NearCall(cs1, 0x5AB3, spice86_generated_label_call_target_1000_6314_016314);
    label_1000_5AB3_15AB3:
    // CALL 0x1000:c412 (1000_5AB3 / 0x15AB3)
    NearCall(cs1, 0x5AB6, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_5AB6_15AB6:
    // MOV word ptr [0x3cbe],0x0 (1000_5AB6 / 0x15AB6)
    UInt16[DS, 0x3CBE] = 0x0;
    // CALL 0x1000:6715 (1000_5ABC / 0x15ABC)
    NearCall(cs1, 0x5ABF, spice86_generated_label_call_target_1000_6715_016715);
    label_1000_5ABF_15ABF:
    // MOV SI,0x46e3 (1000_5ABF / 0x15ABF)
    SI = 0x46E3;
    // CALL 0x1000:c6ad (1000_5AC2 / 0x15AC2)
    NearCall(cs1, 0x5AC5, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    label_1000_5AC5_15AC5:
    // CALL 0x1000:878c (1000_5AC5 / 0x15AC5)
    NearCall(cs1, 0x5AC8, spice86_generated_label_call_target_1000_878C_01878C);
    label_1000_5AC8_15AC8:
    // POP AX (1000_5AC8 / 0x15AC8)
    AX = Stack.Pop();
    // MOV [0x46eb],AL (1000_5AC9 / 0x15AC9)
    UInt8[DS, 0x46EB] = AL;
    // AND AL,0x40 (1000_5ACC / 0x15ACC)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    // JZ 0x1000:5ad3 (1000_5ACE / 0x15ACE)
    if(ZeroFlag) {
      goto label_1000_5AD3_15AD3;
    }
    // CALL 0x1000:5406 (1000_5AD0 / 0x15AD0)
    throw FailAsUntested("Could not find a valid function at address 1000_5406 / 0x15406");
    label_1000_5AD3_15AD3:
    // MOV AX,0x1a9e (1000_5AD3 / 0x15AD3)
    AX = 0x1A9E;
    // CALL 0x1000:d95e (1000_5AD6 / 0x15AD6)
    NearCall(cs1, 0x5AD9, spice86_generated_label_call_target_1000_D95E_01D95E);
    label_1000_5AD9_15AD9:
    // MOV SI,0x46e3 (1000_5AD9 / 0x15AD9)
    SI = 0x46E3;
    // JMP 0x1000:daaa (1000_5ADC / 0x15ADC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAAA_01DAAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5ADF_015ADF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5ADF_15ADF:
    // CALL 0x1000:7b36 (1000_5ADF / 0x15ADF)
    NearCall(cs1, 0x5AE2, spice86_generated_label_call_target_1000_7B36_017B36);
    label_1000_5AE2_15AE2:
    // XOR AX,AX (1000_5AE2 / 0x15AE2)
    AX = 0;
    // MOV [0x46eb],AL (1000_5AE4 / 0x15AE4)
    UInt8[DS, 0x46EB] = AL;
    // MOV [0x46f3],AL (1000_5AE7 / 0x15AE7)
    UInt8[DS, 0x46F3] = AL;
    // MOV [0x3cbe],AX (1000_5AEA / 0x15AEA)
    UInt16[DS, 0x3CBE] = AX;
    // MOV [0xa5c0],AX (1000_5AED / 0x15AED)
    UInt16[DS, 0xA5C0] = AX;
    // MOV [0xdbe0],AX (1000_5AF0 / 0x15AF0)
    UInt16[DS, 0xDBE0] = AX;
    // MOV [0xdbe2],AX (1000_5AF3 / 0x15AF3)
    UInt16[DS, 0xDBE2] = AX;
    // MOV [0x1954],AX (1000_5AF6 / 0x15AF6)
    UInt16[DS, 0x1954] = AX;
    // MOV word ptr [0x2786],0xc827 (1000_5AF9 / 0x15AF9)
    UInt16[DS, 0x2786] = 0xC827;
    // MOV SI,0x6b34 (1000_5AFF / 0x15AFF)
    SI = 0x6B34;
    // JMP 0x1000:da5f (1000_5B02 / 0x15B02)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_5B10_015B10(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B10_15B10:
    // CALL 0x1000:8850 (1000_5B10 / 0x15B10)
    throw FailAsUntested("Could not find a valid function at address 1000_8850 / 0x18850");
    // TEST byte ptr [0x46eb],0x40 (1000_5B13 / 0x15B13)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    // JZ 0x1000:5b1d (1000_5B18 / 0x15B18)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5B1D / 0x15B1D)
      return NearRet();
    }
    // JMP 0x1000:5575 (1000_5B1A / 0x15B1A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5575_015575, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5B1D_15B1D:
    // RET  (1000_5B1D / 0x15B1D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5B5D_015B5D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B5D_15B5D:
    // CALL 0x1000:407e (1000_5B5D / 0x15B5D)
    NearCall(cs1, 0x5B60, spice86_generated_label_call_target_1000_407E_01407E);
    label_1000_5B60_15B60:
    // MOV word ptr [0x197e],BX (1000_5B60 / 0x15B60)
    UInt16[DS, 0x197E] = BX;
    // MOV word ptr [0x197c],DX (1000_5B64 / 0x15B64)
    UInt16[DS, 0x197C] = DX;
    // RET  (1000_5B68 / 0x15B68)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5B69_015B69(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B69_15B69:
    // MOV SI,0x46e3 (1000_5B69 / 0x15B69)
    SI = 0x46E3;
    // MOV AL,0xfc (1000_5B6C / 0x15B6C)
    AL = 0xFC;
    // MOV DX,word ptr [SI] (1000_5B6E / 0x15B6E)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_5B70 / 0x15B70)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV DI,word ptr [SI + 0x4] (1000_5B73 / 0x15B73)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV CX,word ptr [SI + 0x6] (1000_5B76 / 0x15B76)
    CX = UInt16[DS, (ushort)(SI + 0x6)];
    // MOV BP,0x4 (1000_5B79 / 0x15B79)
    BP = 0x4;
    label_1000_5B7C_15B7C:
    // PUSH AX (1000_5B7C / 0x15B7C)
    Stack.Push(AX);
    // PUSH BP (1000_5B7D / 0x15B7D)
    Stack.Push(BP);
    // DEC DX (1000_5B7E / 0x15B7E)
    DX = Alu.Dec16(DX);
    // DEC BX (1000_5B7F / 0x15B7F)
    BX = Alu.Dec16(BX);
    // CALL 0x1000:c560 (1000_5B80 / 0x15B80)
    NearCall(cs1, 0x5B83, spice86_generated_label_call_target_1000_C560_01C560);
    label_1000_5B83_15B83:
    // POP BP (1000_5B83 / 0x15B83)
    BP = Stack.Pop();
    // POP AX (1000_5B84 / 0x15B84)
    AX = Stack.Pop();
    // INC DI (1000_5B85 / 0x15B85)
    DI = Alu.Inc16(DI);
    // INC CX (1000_5B86 / 0x15B86)
    CX = Alu.Inc16(CX);
    // SUB AL,0x2 (1000_5B87 / 0x15B87)
    AL -= 0x2;
    
    // DEC BP (1000_5B89 / 0x15B89)
    BP = Alu.Dec16(BP);
    // JNZ 0x1000:5b7c (1000_5B8A / 0x15B8A)
    if(!ZeroFlag) {
      goto label_1000_5B7C_15B7C;
    }
    // RET  (1000_5B8C / 0x15B8C)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5B8D_015B8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B8D_15B8D:
    // MOV DI,0xd83c (1000_5B8D / 0x15B8D)
    DI = 0xD83C;
    // CALL 0x1000:5b96 (1000_5B90 / 0x15B90)
    NearCall(cs1, 0x5B93, spice86_generated_label_call_target_1000_5B96_015B96);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B93_015B93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_ret_target_1000_5B93_015B93(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B93_15B93:
    // MOV DI,0xd834 (1000_5B93 / 0x15B93)
    DI = 0xD834;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B96_015B96, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5B96_015B96(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B96_15B96:
    // MOV SI,0x46e3 (1000_5B96 / 0x15B96)
    SI = 0x46E3;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5B99_015B99(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5B99_15B99:
    // PUSH DS (1000_5B99 / 0x15B99)
    Stack.Push(DS);
    // POP ES (1000_5B9A / 0x15B9A)
    ES = Stack.Pop();
    // MOVSW ES:DI,SI (1000_5B9B / 0x15B9B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_5B9C / 0x15B9C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_5B9D / 0x15B9D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_5B9E / 0x15B9E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // RET  (1000_5B9F / 0x15B9F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5BA0_015BA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5BA0_15BA0:
    // MOV SI,0x1470 (1000_5BA0 / 0x15BA0)
    SI = 0x1470;
    // MOV DI,0xd83c (1000_5BA3 / 0x15BA3)
    DI = 0xD83C;
    // JMP 0x1000:5b99 (1000_5BA6 / 0x15BA6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5BA8_015BA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5BA8_15BA8:
    // MOV SI,0x1470 (1000_5BA8 / 0x15BA8)
    SI = 0x1470;
    // MOV DI,0xd834 (1000_5BAB / 0x15BAB)
    DI = 0xD834;
    // JMP 0x1000:5b99 (1000_5BAE / 0x15BAE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5BB0_015BB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5BB0_15BB0:
    // CALL 0x1000:c08e (1000_5BB0 / 0x15BB0)
    NearCall(cs1, 0x5BB3, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_5BB3_15BB3:
    // MOV SI,0x194a (1000_5BB3 / 0x15BB3)
    SI = 0x194A;
    // MOV word ptr [0xdbe0],SI (1000_5BB6 / 0x15BB6)
    UInt16[DS, 0xDBE0] = SI;
    // CALL 0x1000:7b1b (1000_5BBA / 0x15BBA)
    NearCall(cs1, 0x5BBD, spice86_generated_label_call_target_1000_7B1B_017B1B);
    label_1000_5BBD_15BBD:
    // CALL 0x1000:d068 (1000_5BBD / 0x15BBD)
    NearCall(cs1, 0x5BC0, spice86_generated_label_call_target_1000_D068_01D068);
    label_1000_5BC0_15BC0:
    // MOV SI,0xe2 (1000_5BC0 / 0x15BC0)
    SI = 0xE2;
    // CALL 0x1000:cf70 (1000_5BC3 / 0x15BC3)
    NearCall(cs1, 0x5BC6, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_5BC6_15BC6:
    // CALL 0x1000:d03c (1000_5BC6 / 0x15BC6)
    NearCall(cs1, 0x5BC9, spice86_generated_label_call_target_1000_D03C_01D03C);
    label_1000_5BC9_15BC9:
    // MOV AL,[0x28] (1000_5BC9 / 0x15BC9)
    AL = UInt8[DS, 0x28];
    // XOR AH,AH (1000_5BCC / 0x15BCC)
    AH = 0;
    // CALL 0x1000:e2e3 (1000_5BCE / 0x15BCE)
    NearCall(cs1, 0x5BD1, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    label_1000_5BD1_15BD1:
    // MOV DX,word ptr [0x194a] (1000_5BD1 / 0x15BD1)
    DX = UInt16[DS, 0x194A];
    // MOV BX,word ptr [0x194c] (1000_5BD5 / 0x15BD5)
    BX = UInt16[DS, 0x194C];
    // ADD DX,0xa (1000_5BD9 / 0x15BD9)
    DX += 0xA;
    
    // ADD BX,0x8 (1000_5BDC / 0x15BDC)
    // BX += 0x8;
    BX = Alu.Add16(BX, 0x8);
    // MOV CX,0xf0 (1000_5BDF / 0x15BDF)
    CX = 0xF0;
    // MOV AX,0xe2 (1000_5BE2 / 0x15BE2)
    AX = 0xE2;
    // CALL 0x1000:d194 (1000_5BE5 / 0x15BE5)
    NearCall(cs1, 0x5BE8, spice86_generated_label_call_target_1000_D194_01D194);
    label_1000_5BE8_15BE8:
    // JMP 0x1000:c07c (1000_5BE8 / 0x15BE8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_5C03_015C03(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5C03_15C03:
    // MOV DI,word ptr [0xdbe0] (1000_5C03 / 0x15C03)
    DI = UInt16[DS, 0xDBE0];
    // CMP DI,0x194a (1000_5C07 / 0x15C07)
    Alu.Sub16(DI, 0x194A);
    // JNZ 0x1000:5c22 (1000_5C0B / 0x15C0B)
    if(!ZeroFlag) {
      goto label_1000_5C22_15C22;
    }
    // MOV AX,[0xce7a] (1000_5C0D / 0x15C0D)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,word ptr [0xdc5a] (1000_5C10 / 0x15C10)
    AX -= UInt16[DS, 0xDC5A];
    
    // CMP AX,0x3e8 (1000_5C14 / 0x15C14)
    Alu.Sub16(AX, 0x3E8);
    // JC 0x1000:5c22 (1000_5C17 / 0x15C17)
    if(CarryFlag) {
      goto label_1000_5C22_15C22;
    }
    // CALL 0x1000:dbb2 (1000_5C19 / 0x15C19)
    NearCall(cs1, 0x5C1C, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:5beb (1000_5C1C / 0x15C1C)
    throw FailAsUntested("Could not find a valid function at address 1000_5BEB / 0x15BEB");
    // JMP 0x1000:dbec (1000_5C1F / 0x15C1F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5C22_15C22:
    // CMP DI,0x4710 (1000_5C22 / 0x15C22)
    Alu.Sub16(DI, 0x4710);
    // JZ 0x1000:5c32 (1000_5C26 / 0x15C26)
    if(ZeroFlag) {
      goto label_1000_5C32_15C32;
    }
    // MOV DI,word ptr [0xdbe2] (1000_5C28 / 0x15C28)
    DI = UInt16[DS, 0xDBE2];
    // CMP DI,0x4710 (1000_5C2C / 0x15C2C)
    Alu.Sub16(DI, 0x4710);
    // JNZ 0x1000:5c75 (1000_5C30 / 0x15C30)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_5C75 / 0x15C75)
      return NearRet();
    }
    label_1000_5C32_15C32:
    // CALL 0x1000:d6fe (1000_5C32 / 0x15C32)
    NearCall(cs1, 0x5C35, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JNC 0x1000:5c4b (1000_5C35 / 0x15C35)
    if(!CarryFlag) {
      goto label_1000_5C4B_15C4B;
    }
    // MOV byte ptr [0x46eb],0x40 (1000_5C37 / 0x15C37)
    UInt8[DS, 0x46EB] = 0x40;
    // MOV AL,0xff (1000_5C3C / 0x15C3C)
    AL = 0xFF;
    // CALL 0x1000:5e6d (1000_5C3E / 0x15C3E)
    NearCall(cs1, 0x5C41, spice86_generated_label_call_target_1000_5E6D_015E6D);
    // MOV byte ptr [0x46eb],0xc0 (1000_5C41 / 0x15C41)
    UInt8[DS, 0x46EB] = 0xC0;
    // CMP AX,0x9 (1000_5C46 / 0x15C46)
    Alu.Sub16(AX, 0x9);
    // JC 0x1000:5c4d (1000_5C49 / 0x15C49)
    if(CarryFlag) {
      goto label_1000_5C4D_15C4D;
    }
    label_1000_5C4B_15C4B:
    // XOR DI,DI (1000_5C4B / 0x15C4B)
    DI = 0;
    label_1000_5C4D_15C4D:
    // MOV AX,DI (1000_5C4D / 0x15C4D)
    AX = DI;
    // XCHG word ptr [0x46fc],AX (1000_5C4F / 0x15C4F)
    ushort tmp_1000_5C4F = UInt16[DS, 0x46FC];
    UInt16[DS, 0x46FC] = AX;
    AX = tmp_1000_5C4F;
    // CMP AX,DI (1000_5C53 / 0x15C53)
    Alu.Sub16(AX, DI);
    // JZ 0x1000:5c6e (1000_5C55 / 0x15C55)
    if(ZeroFlag) {
      goto label_1000_5C6E_15C6E;
    }
    // PUSH BX (1000_5C57 / 0x15C57)
    Stack.Push(BX);
    // PUSH DX (1000_5C58 / 0x15C58)
    Stack.Push(DX);
    // PUSH DI (1000_5C59 / 0x15C59)
    Stack.Push(DI);
    // PUSH word ptr [0xdbda] (1000_5C5A / 0x15C5A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:dbb2 (1000_5C5E / 0x15C5E)
    NearCall(cs1, 0x5C61, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:c08e (1000_5C61 / 0x15C61)
    NearCall(cs1, 0x5C64, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:5692 (1000_5C64 / 0x15C64)
    throw FailAsUntested("Could not find a valid function at address 1000_5692 / 0x15692");
    // POP word ptr [0xdbda] (1000_5C67 / 0x15C67)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // POP DI (1000_5C6B / 0x15C6B)
    DI = Stack.Pop();
    // POP DX (1000_5C6C / 0x15C6C)
    DX = Stack.Pop();
    // POP BX (1000_5C6D / 0x15C6D)
    BX = Stack.Pop();
    label_1000_5C6E_15C6E:
    // OR DI,DI (1000_5C6E / 0x15C6E)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:5c75 (1000_5C70 / 0x15C70)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_5C75 / 0x15C75)
      return NearRet();
    }
    // CALL 0x1000:5746 (1000_5C72 / 0x15C72)
    throw FailAsUntested("Could not find a valid function at address 1000_5746 / 0x15746");
    label_1000_5C75_15C75:
    // RET  (1000_5C75 / 0x15C75)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5D1D_015D1D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5D1D_15D1D:
    // CMP DX,word ptr [0x46e3] (1000_5D1D / 0x15D1D)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    // CMC  (1000_5D21 / 0x15D21)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:5d35 (1000_5D22 / 0x15D22)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    // CMP DX,word ptr [0x46e7] (1000_5D24 / 0x15D24)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    // JNC 0x1000:5d35 (1000_5D28 / 0x15D28)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e5] (1000_5D2A / 0x15D2A)
    Alu.Sub16(BX, UInt16[DS, 0x46E5]);
    // CMC  (1000_5D2E / 0x15D2E)
    CarryFlag = !CarryFlag;
    // JNC 0x1000:5d35 (1000_5D2F / 0x15D2F)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    // CMP BX,word ptr [0x46e9] (1000_5D31 / 0x15D31)
    Alu.Sub16(BX, UInt16[DS, 0x46E9]);
    label_1000_5D35_15D35:
    // RET  (1000_5D35 / 0x15D35)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5D36_015D36(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5D36_15D36:
    // CMP byte ptr [DI + 0x8],0x28 (1000_5D36 / 0x15D36)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JC 0x1000:5d43 (1000_5D3A / 0x15D3A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_5D43 / 0x15D43)
      return NearRet();
    }
    // TEST byte ptr [DI + 0xa],0x8 (1000_5D3C / 0x15D3C)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    // JZ 0x1000:5d43 (1000_5D40 / 0x15D40)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5D43 / 0x15D43)
      return NearRet();
    }
    // STC  (1000_5D42 / 0x15D42)
    CarryFlag = true;
    label_1000_5D43_15D43:
    // RET  (1000_5D43 / 0x15D43)
    return NearRet();
  }
  
  public Action split_1000_5D50_015D50(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5D50_15D50:
    // PUSH SI (1000_5D50 / 0x15D50)
    Stack.Push(SI);
    // PUSH DI (1000_5D51 / 0x15D51)
    Stack.Push(DI);
    // TEST byte ptr [DI + 0xa],0x80 (1000_5D52 / 0x15D52)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    // JNZ 0x1000:5d6a (1000_5D56 / 0x15D56)
    if(!ZeroFlag) {
      goto label_1000_5D6A_15D6A;
    }
    // CMP byte ptr [0x46eb],0x0 (1000_5D58 / 0x15D58)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JZ 0x1000:5d6a (1000_5D5D / 0x15D5D)
    if(ZeroFlag) {
      goto label_1000_5D6A_15D6A;
    }
    // MOV SI,DI (1000_5D5F / 0x15D5F)
    SI = DI;
    // CALL 0x1000:62c9 (1000_5D61 / 0x15D61)
    NearCall(cs1, 0x5D64, spice86_generated_label_call_target_1000_62C9_0162C9);
    // JC 0x1000:5d6a (1000_5D64 / 0x15D64)
    if(CarryFlag) {
      goto label_1000_5D6A_15D6A;
    }
    // INC byte ptr [0x46ec] (1000_5D66 / 0x15D66)
    UInt8[DS, 0x46EC] = Alu.Inc8(UInt8[DS, 0x46EC]);
    label_1000_5D6A_15D6A:
    // POP DI (1000_5D6A / 0x15D6A)
    DI = Stack.Pop();
    // POP SI (1000_5D6B / 0x15D6B)
    SI = Stack.Pop();
    // RET  (1000_5D6C / 0x15D6C)
    return NearRet();
  }
  
  public Action split_1000_5D6D_015D6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5D6D_15D6D:
    // MOV byte ptr [0x46ec],0x0 (1000_5D6D / 0x15D6D)
    UInt8[DS, 0x46EC] = 0x0;
    // CMP byte ptr [0x46eb],0x0 (1000_5D72 / 0x15D72)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:5d82 (1000_5D77 / 0x15D77)
    if(SignFlag) {
      goto label_1000_5D82_15D82;
    }
    // JZ 0x1000:5dcd (1000_5D79 / 0x15D79)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_5DCD / 0x15DCD)
      return NearRet();
    }
    // CALL 0x1000:dbb2 (1000_5D7B / 0x15D7B)
    NearCall(cs1, 0x5D7E, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // JMP word ptr [0x46ed] (1000_5D7E / 0x15D7E)
    // Indirect jump to word ptr [0x46ed], generating possible targets from emulator records
    uint targetAddress_1000_5D7E = (uint)(UInt16[DS, 0x46ED]);
    switch(targetAddress_1000_5D7E) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5D7E));
        break;
    }
    label_1000_5D82_15D82:
    // CALL 0x1000:c07c (1000_5D82 / 0x15D82)
    NearCall(cs1, 0x5D85, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:dbb2 (1000_5D85 / 0x15D85)
    NearCall(cs1, 0x5D88, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:5b8d (1000_5D88 / 0x15D88)
    NearCall(cs1, 0x5D8B, spice86_generated_label_call_target_1000_5B8D_015B8D);
    // MOV AL,0x80 (1000_5D8B / 0x15D8B)
    AL = 0x80;
    // XCHG byte ptr [0x46eb],AL (1000_5D8D / 0x15D8D)
    byte tmp_1000_5D8D = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_5D8D;
    // PUSH AX (1000_5D91 / 0x15D91)
    Stack.Push(AX);
    // PUSH word ptr [0x46ef] (1000_5D92 / 0x15D92)
    Stack.Push(UInt16[DS, 0x46EF]);
    // CALL 0x1000:b6c3 (1000_5D96 / 0x15D96)
    NearCall(cs1, 0x5D99, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    // CALL 0x1000:c13b (1000_5D99 / 0x15D99)
    NearCall(cs1, 0x5D9C, spice86_generated_label_call_target_1000_C13B_01C13B);
    // CALL 0x1000:5dce (1000_5D9C / 0x15D9C)
    NearCall(cs1, 0x5D9F, spice86_generated_label_call_target_1000_5DCE_015DCE);
    // CALL 0x1000:6314 (1000_5D9F / 0x15D9F)
    NearCall(cs1, 0x5DA2, spice86_generated_label_call_target_1000_6314_016314);
    // CALL 0x1000:c412 (1000_5DA2 / 0x15DA2)
    NearCall(cs1, 0x5DA5, spice86_generated_label_call_target_1000_C412_01C412);
    // MOV word ptr [0x3cbe],0x0 (1000_5DA5 / 0x15DA5)
    UInt16[DS, 0x3CBE] = 0x0;
    // CALL 0x1000:6715 (1000_5DAB / 0x15DAB)
    NearCall(cs1, 0x5DAE, spice86_generated_label_call_target_1000_6715_016715);
    // MOV SI,0x46e3 (1000_5DAE / 0x15DAE)
    SI = 0x46E3;
    // CALL 0x1000:c6ad (1000_5DB1 / 0x15DB1)
    NearCall(cs1, 0x5DB4, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // POP SI (1000_5DB4 / 0x15DB4)
    SI = Stack.Pop();
    // OR SI,SI (1000_5DB5 / 0x15DB5)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:5dbc (1000_5DB7 / 0x15DB7)
    if(ZeroFlag) {
      goto label_1000_5DBC_15DBC;
    }
    // CALL 0x1000:697c (1000_5DB9 / 0x15DB9)
    throw FailAsUntested("Could not find a valid function at address 1000_697C / 0x1697C");
    label_1000_5DBC_15DBC:
    // CALL 0x1000:1c18 (1000_5DBC / 0x15DBC)
    NearCall(cs1, 0x5DBF, spice86_generated_label_call_target_1000_1C18_011C18);
    // POP AX (1000_5DBF / 0x15DBF)
    AX = Stack.Pop();
    // MOV [0x46eb],AL (1000_5DC0 / 0x15DC0)
    UInt8[DS, 0x46EB] = AL;
    // AND AL,0x40 (1000_5DC3 / 0x15DC3)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    // JZ 0x1000:5dca (1000_5DC5 / 0x15DC5)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:c13b (1000_5DCA / 0x15DCA)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:542f (1000_5DC7 / 0x15DC7)
    throw FailAsUntested("Could not find a valid function at address 1000_542F / 0x1542F");
    label_1000_5DCA_15DCA:
    // JMP 0x1000:c13b (1000_5DCA / 0x15DCA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_5DCD_15DCD:
    // RET  (1000_5DCD / 0x15DCD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_5DCE_015DCE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_5DCE_15DCE:
    // MOV AL,[0x46eb] (1000_5DCE / 0x15DCE)
    AL = UInt8[DS, 0x46EB];
    // OR AL,AL (1000_5DD1 / 0x15DD1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:5dda (1000_5DD3 / 0x15DD3)
    if(!SignFlag) {
      goto label_1000_5DDA_15DDA;
    }
    // PUSH AX (1000_5DD5 / 0x15DD5)
    Stack.Push(AX);
    // CALL 0x1000:633b (1000_5DD6 / 0x15DD6)
    NearCall(cs1, 0x5DD9, spice86_generated_label_call_target_1000_633B_01633B);
    label_1000_5DD9_15DD9:
    // POP AX (1000_5DD9 / 0x15DD9)
    AX = Stack.Pop();
    label_1000_5DDA_15DDA:
    // MOV DI,0xa5c0 (1000_5DDA / 0x15DDA)
    DI = 0xA5C0;
    // AND AL,0x40 (1000_5DDD / 0x15DDD)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    // JZ 0x1000:5df1 (1000_5DDF / 0x15DDF)
    if(ZeroFlag) {
      goto label_1000_5DF1_15DF1;
    }
    // SUB DI,0x6 (1000_5DE1 / 0x15DE1)
    DI -= 0x6;
    
    label_1000_5DE4_15DE4:
    // ADD DI,0x6 (1000_5DE4 / 0x15DE4)
    DI += 0x6;
    
    // CMP word ptr [DI],0x0 (1000_5DE7 / 0x15DE7)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    // JZ 0x1000:5df1 (1000_5DEA / 0x15DEA)
    if(ZeroFlag) {
      goto label_1000_5DF1_15DF1;
    }
    // TEST byte ptr [DI + 0x5],AL (1000_5DEC / 0x15DEC)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x5)], AL);
    // JZ 0x1000:5de4 (1000_5DEF / 0x15DEF)
    if(ZeroFlag) {
      goto label_1000_5DE4_15DE4;
    }
    label_1000_5DF1_15DF1:
    // MOV SI,0x100 (1000_5DF1 / 0x15DF1)
    SI = 0x100;
    label_1000_5DF4_15DF4:
    // CMP word ptr [SI],-0x1 (1000_5DF4 / 0x15DF4)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JZ 0x1000:5e3d (1000_5DF7 / 0x15DF7)
    if(ZeroFlag) {
      goto label_1000_5E3D_15E3D;
    }
    // TEST byte ptr [SI + 0xa],0x80 (1000_5DF9 / 0x15DF9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    // JNZ 0x1000:5e38 (1000_5DFD / 0x15DFD)
    if(!ZeroFlag) {
      goto label_1000_5E38_15E38;
    }
    // CALL 0x1000:62c9 (1000_5DFF / 0x15DFF)
    NearCall(cs1, 0x5E02, spice86_generated_label_call_target_1000_62C9_0162C9);
    label_1000_5E02_15E02:
    // JC 0x1000:5e38 (1000_5E02 / 0x15E02)
    if(CarryFlag) {
      goto label_1000_5E38_15E38;
    }
    // MOV word ptr [DI],SI (1000_5E04 / 0x15E04)
    UInt16[DS, DI] = SI;
    // MOV word ptr [DI + 0x2],DX (1000_5E06 / 0x15E06)
    UInt16[DS, (ushort)(DI + 0x2)] = DX;
    // MOV BH,byte ptr [0x46eb] (1000_5E09 / 0x15E09)
    BH = UInt8[DS, 0x46EB];
    // MOV word ptr [DI + 0x4],BX (1000_5E0D / 0x15E0D)
    UInt16[DS, (ushort)(DI + 0x4)] = BX;
    // XOR BH,BH (1000_5E10 / 0x15E10)
    BH = 0;
    // CALL 0x1000:5e42 (1000_5E12 / 0x15E12)
    NearCall(cs1, 0x5E15, spice86_generated_label_call_target_1000_5E42_015E42);
    label_1000_5E15_15E15:
    // CMP CL,0x20 (1000_5E15 / 0x15E15)
    Alu.Sub8(CL, 0x20);
    // JNC 0x1000:5e2e (1000_5E18 / 0x15E18)
    if(!CarryFlag) {
      goto label_1000_5E2E_15E2E;
    }
    // PUSH AX (1000_5E1A / 0x15E1A)
    Stack.Push(AX);
    // PUSH BX (1000_5E1B / 0x15E1B)
    Stack.Push(BX);
    // PUSH DX (1000_5E1C / 0x15E1C)
    Stack.Push(DX);
    // PUSH SI (1000_5E1D / 0x15E1D)
    Stack.Push(SI);
    // CALL 0x1000:7c8f (1000_5E1E / 0x15E1E)
    NearCall(cs1, 0x5E21, spice86_generated_label_call_target_1000_7C8F_017C8F);
    label_1000_5E21_15E21:
    // CMP AX,word ptr [0x1176] (1000_5E21 / 0x15E21)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    // POP SI (1000_5E25 / 0x15E25)
    SI = Stack.Pop();
    // POP DX (1000_5E26 / 0x15E26)
    DX = Stack.Pop();
    // POP BX (1000_5E27 / 0x15E27)
    BX = Stack.Pop();
    // POP AX (1000_5E28 / 0x15E28)
    AX = Stack.Pop();
    // JBE 0x1000:5e2e (1000_5E29 / 0x15E29)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5E2E_15E2E;
    }
    // ADD AX,0x5 (1000_5E2B / 0x15E2B)
    // AX += 0x5;
    AX = Alu.Add16(AX, 0x5);
    label_1000_5E2E_15E2E:
    // PUSH SI (1000_5E2E / 0x15E2E)
    Stack.Push(SI);
    // PUSH DI (1000_5E2F / 0x15E2F)
    Stack.Push(DI);
    // CALL 0x1000:c343 (1000_5E30 / 0x15E30)
    NearCall(cs1, 0x5E33, spice86_generated_label_call_target_1000_C343_01C343);
    label_1000_5E33_15E33:
    // POP DI (1000_5E33 / 0x15E33)
    DI = Stack.Pop();
    // POP SI (1000_5E34 / 0x15E34)
    SI = Stack.Pop();
    // ADD DI,0x6 (1000_5E35 / 0x15E35)
    DI += 0x6;
    
    label_1000_5E38_15E38:
    // ADD SI,0x1c (1000_5E38 / 0x15E38)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    // JMP 0x1000:5df4 (1000_5E3B / 0x15E3B)
    goto label_1000_5DF4_15DF4;
    label_1000_5E3D_15E3D:
    // MOV word ptr [DI],0x0 (1000_5E3D / 0x15E3D)
    UInt16[DS, DI] = 0x0;
    // RET  (1000_5E41 / 0x15E41)
    return NearRet();
  }
  
}
