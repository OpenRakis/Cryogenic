namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_4406_014406(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4406_14406:
    // CALL 0x1000:c43e (1000_4406 / 0x14406)
    NearCall(cs1, 0x4409, spice86_generated_label_call_target_1000_C43E_01C43E);
    label_1000_4409_14409:
    // CALL 0x1000:c4dd (1000_4409 / 0x14409)
    NearCall(cs1, 0x440C, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_440C_1440C:
    // JMP 0x1000:c0f4 (1000_440C / 0x1440C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_440F_01440F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_440F_1440F:
    // CALL 0x1000:4abe (1000_440F / 0x1440F)
    NearCall(cs1, 0x4412, spice86_generated_label_call_target_1000_4ABE_014ABE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4412_014412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4412_014412(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4412_14412:
    // JMP 0x1000:c0f4 (1000_4412 / 0x14412)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4415_014415(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4429_014429, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4429_014429(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4429_14429:
    // MOV SI,0x44ab (1000_4429 / 0x14429)
    SI = 0x44AB;
    // CALL 0x1000:da5f (1000_442C / 0x1442C)
    NearCall(cs1, 0x442F, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_442F_01442F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_442F_01442F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_442F_1442F:
    // CALL 0x1000:469b (1000_442F / 0x1442F)
    NearCall(cs1, 0x4432, spice86_generated_label_call_target_1000_469B_01469B);
    label_1000_4432_14432:
    // CALL 0x1000:5ba0 (1000_4432 / 0x14432)
    NearCall(cs1, 0x4435, spice86_generated_label_call_target_1000_5BA0_015BA0);
    label_1000_4435_14435:
    // CALL 0x1000:43e3 (1000_4435 / 0x14435)
    NearCall(cs1, 0x4438, spice86_generated_label_call_target_1000_43E3_0143E3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4438_014438, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4438_014438(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AC4_014AC4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:49d4 (1000_4457 / 0x14457)
    NearCall(cs1, 0x445A, not_observed_1000_49D4_0149D4);
    label_1000_445A_1445A:
    // JMP 0x1000:4ac4 (1000_445A / 0x1445A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AC4_014AC4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_445D_01445D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_445D_1445D:
    // MOV SI,0x44ab (1000_445D / 0x1445D)
    SI = 0x44AB;
    // CALL 0x1000:da5f (1000_4460 / 0x14460)
    NearCall(cs1, 0x4463, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4463_014463, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4463_014463(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4463_14463:
    // CALL 0x1000:407e (1000_4463 / 0x14463)
    NearCall(cs1, 0x4466, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4466_014466, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4466_014466(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_447B_01447B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_447B_01447B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_44AB_0144AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_44AB_144AB:
    // INC byte ptr [0x4751] (1000_44AB / 0x144AB)
    UInt8[DS, 0x4751] = Alu.Inc8(UInt8[DS, 0x4751]);
    // PUSH word ptr [0xdbda] (1000_44AF / 0x144AF)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_44B3 / 0x144B3)
    NearCall(cs1, 0x44B6, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_44B6_0144B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_44B6_0144B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // SHR BL,1 (1000_44F5 / 0x144F5)
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
  
  public virtual Action spice86_generated_label_call_target_1000_450E_01450E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_451A_01451A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_451A_01451A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_453D_01453D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_453D_01453D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_453D_1453D:
    // POP DI (1000_453D / 0x1453D)
    DI = Stack.Pop();
    // MOV CX,0x9 (1000_453E / 0x1453E)
    CX = 0x9;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4541_014541, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4541_014541(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4703_014703, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_456C_01456C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    AX--;
    // SHL AL,1 (1000_4576 / 0x14576)
    AL <<= 0x1;
    // SHL AL,1 (1000_4578 / 0x14578)
    AL <<= 0x1;
    // SHL AL,1 (1000_457A / 0x1457A)
    AL <<= 0x1;
    // SHL AL,1 (1000_457C / 0x1457C)
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
  
  public virtual Action spice86_generated_label_call_target_1000_4586_014586(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4586_14586:
    // CALL 0x1000:5d1d (1000_4586 / 0x14586)
    NearCall(cs1, 0x4589, spice86_generated_label_call_target_1000_5D1D_015D1D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4589_014589, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4589_014589(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4589_14589:
    // MOV DI,0x0 (1000_4589 / 0x14589)
    DI = 0x0;
    // JNC 0x1000:45d3 (1000_458C / 0x1458C)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0x145D3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0x145D3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0x145D3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45B7_0145B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_45B7_0145B7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x45D3: goto label_1000_45D3_145D3;break; // Target of external jump from 0x145C4, 0x14596, 0x1458C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
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
    // ROL AL,1 (1000_45C6 / 0x145C6)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,1 (1000_45C8 / 0x145C8)
    AL = Alu.Rol8(AL, 0x1);
    // ROL AL,1 (1000_45CA / 0x145CA)
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
  
  public virtual Action spice86_generated_label_call_target_1000_45DE_0145DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_45DE_145DE:
    // PUSH word ptr [0xdbda] (1000_45DE / 0x145DE)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_45E2 / 0x145E2)
    NearCall(cs1, 0x45E5, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45E5_0145E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_45E5_0145E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_45E5_145E5:
    // CALL 0x1000:dbb2 (1000_45E5 / 0x145E5)
    NearCall(cs1, 0x45E8, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_45E8_145E8:
    // CALL 0x1000:d075 (1000_45E8 / 0x145E8)
    NearCall(cs1, 0x45EB, spice86_generated_label_call_target_1000_D075_01D075);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_45EB_0145EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_45EB_0145EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_462A_01462A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:469b (1000_4604 / 0x14604)
    NearCall(cs1, 0x4607, spice86_generated_label_call_target_1000_469B_01469B);
    label_1000_4607_14607:
    // CMP DI,-0x10 (1000_4607 / 0x14607)
    Alu.Sub16(DI, 0xFFF0);
    // JC 0x1000:4636 (1000_460A / 0x1460A)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4636_014636, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0x14641 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4620_014620, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4620_014620(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0x14641 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_462A_01462A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_462A_1462A:
    // CALL 0x1000:4658 (1000_462A / 0x1462A)
    NearCall(cs1, 0x462D, spice86_generated_label_call_target_1000_4658_014658);
    label_1000_462D_1462D:
    // MOV word ptr [0xdbe4],CX (1000_462D / 0x1462D)
    UInt16[DS, 0xDBE4] = CX;
    // CALL 0x1000:d04e (1000_4631 / 0x14631)
    NearCall(cs1, 0x4634, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4634_014634, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4634_014634(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4634_14634:
    // JMP 0x1000:4641 (1000_4634 / 0x14634)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0x14641 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4636_014636(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4636_14636:
    // PUSH CX (1000_4636 / 0x14636)
    Stack.Push(CX);
    // CALL 0x1000:629d (1000_4637 / 0x14637)
    NearCall(cs1, 0x463A, spice86_generated_label_call_target_1000_629D_01629D);
    label_1000_463A_1463A:
    // CALL 0x1000:d05f (1000_463A / 0x1463A)
    NearCall(cs1, 0x463D, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_463D_01463D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_463D_01463D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4641: goto label_1000_4641_14641;break; // Target of external jump from 0x14634, 0x14618, 0x14628, 0x1464F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_4658_014658(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4662_014662, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4662_014662(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4697_014697, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4697_014697(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4697_14697:
    // CALL 0x1000:e283 (1000_4697 / 0x14697)
    NearCall(cs1, 0x469A, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_469A_1469A:
    // RET  (1000_469A / 0x1469A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_469B_01469B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46AB_0146AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46AB_0146AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_46AB_146AB:
    // MOV SI,0x46b5 (1000_46AB / 0x146AB)
    SI = 0x46B5;
    // CALL 0x1000:da5f (1000_46AE / 0x146AE)
    NearCall(cs1, 0x46B1, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46B1_0146B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46B1_0146B1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x46B4: goto label_1000_46B4_146B4;break; // Target of external jump from 0x146A0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_46B1_146B1:
    // CALL 0x1000:e283 (1000_46B1 / 0x146B1)
    NearCall(cs1, 0x46B4, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_46B4_146B4:
    // RET  (1000_46B4 / 0x146B4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_46B5_0146B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46CA_0146CA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46CA_0146CA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_46CA_146CA:
    // PUSH word ptr [0xdbda] (1000_46CA / 0x146CA)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_46CE / 0x146CE)
    NearCall(cs1, 0x46D1, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46D1_0146D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46D1_0146D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_46D1_146D1:
    // MOV DX,word ptr [0x4743] (1000_46D1 / 0x146D1)
    DX = UInt16[DS, 0x4743];
    // MOV BX,word ptr [0x4745] (1000_46D5 / 0x146D5)
    BX = UInt16[DS, 0x4745];
    // CALL 0x1000:d04e (1000_46D9 / 0x146D9)
    NearCall(cs1, 0x46DC, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46DC_0146DC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46DC_0146DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_46EB_0146EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_46EB_0146EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_46B5_0146B5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_4702_14702:
    // RET  (1000_4702 / 0x14702)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4703_014703(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // SHR AL,1 (1000_470D / 0x1470D)
    AL >>= 0x1;
    // SHR AL,1 (1000_470F / 0x1470F)
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_472A_01472A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_472A_01472A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4757_014757, 0x1478F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4757_014757, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4757_014757(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x478F: goto label_1000_478F_1478F;break; // Target of external jump from 0x14730
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
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
    label_1000_4792_14792:
    // JMP 0x1000:c0f4 (1000_4792 / 0x14792)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4795_014795(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_47CE_0147CE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:98af (1000_47A0 / 0x147A0)
    NearCall(cs1, 0x47A3, not_observed_1000_98AF_0198AF);
    // MOV byte ptr [0xcee8],0x0 (1000_47A3 / 0x147A3)
    UInt8[DS, 0xCEE8] = 0x0;
    // MOV AL,0x50 (1000_47A8 / 0x147A8)
    AL = 0x50;
    // CALL 0x1000:121f (1000_47AA / 0x147AA)
    NearCall(cs1, 0x47AD, spice86_generated_label_jump_target_1000_121F_01121F);
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
    NearCall(cs1, 0x47C5, not_observed_1000_491C_01491C);
    // MOV byte ptr [0x227d],0x0 (1000_47C5 / 0x147C5)
    UInt8[DS, 0x227D] = 0x0;
    // JMP 0x1000:ac14 (1000_47CA / 0x147CA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AC14_01AC14, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_47CD_0147CD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_47CD_147CD:
    // RET  (1000_47CD / 0x147CD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_47CE_0147CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_47CE_147CE:
    // CALL 0x1000:ce53 (1000_47CE / 0x147CE)
    NearCall(cs1, 0x47D1, spice86_generated_label_call_target_1000_CE53_01CE53);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_47D1_0147D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_47D1_0147D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_47D1_147D1:
    // XOR AL,AL (1000_47D1 / 0x147D1)
    AL = 0;
    // XCHG byte ptr [0x4732],AL (1000_47D3 / 0x147D3)
    byte tmp_1000_47D3 = UInt8[DS, 0x4732];
    UInt8[DS, 0x4732] = AL;
    AL = tmp_1000_47D3;
    // SHL AL,1 (1000_47D7 / 0x147D7)
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_47DE_0147DE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_47DE_0147DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_47DE_147DE:
    // MOV byte ptr [0x4731],0xff (1000_47DE / 0x147DE)
    UInt8[DS, 0x4731] = 0xFF;
    // CALL 0x1000:c07c (1000_47E3 / 0x147E3)
    NearCall(cs1, 0x47E6, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_47E6_147E6:
    // CALL 0x1000:37b2 (1000_47E6 / 0x147E6)
    NearCall(cs1, 0x47E9, spice86_generated_label_call_target_1000_37B2_0137B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_47E9_0147E9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_47E9_0147E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_47FB_0147FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_47FB_0147FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_4821_014821(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_482E_01482E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_482E_01482E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // SAR AX,1 (1000_4859 / 0x14859)
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
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4877_014877, 0x1487B - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,[0x4731] (1000_486B / 0x1486B)
    AL = UInt8[DS, 0x4731];
    // PUSH AX (1000_486E / 0x1486E)
    Stack.Push(AX);
    // MOV byte ptr [0x4731],0x0 (1000_486F / 0x1486F)
    UInt8[DS, 0x4731] = 0x0;
    // CALL 0x1000:3a73 (1000_4874 / 0x14874)
    NearCall(cs1, 0x4877, spice86_generated_label_call_target_1000_3A73_013A73);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4877_014877, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4877_014877(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action not_observed_1000_488A_01488A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_488A_1488A:
    // MOV AX,0x6 (1000_488A / 0x1488A)
    AX = 0x6;
    // MOV SI,word ptr [0x114e] (1000_488D / 0x1488D)
    SI = UInt16[DS, 0x114E];
    // CALL 0x1000:5e4f (1000_4891 / 0x14891)
    NearCall(cs1, 0x4894, spice86_generated_label_call_target_1000_5E4F_015E4F);
    // CMP AL,0x8 (1000_4894 / 0x14894)
    Alu.Sub8(AL, 0x8);
    // JNC 0x1000:48e5 (1000_4896 / 0x14896)
    if(!CarryFlag) {
      goto label_1000_48E5_148E5;
    }
    // MOV BX,AX (1000_4898 / 0x14898)
    BX = AX;
    // CALL 0x1000:dbb2 (1000_489A / 0x1489A)
    NearCall(cs1, 0x489D, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // MOV byte ptr [0x4728],0x80 (1000_489D / 0x1489D)
    UInt8[DS, 0x4728] = 0x80;
    label_1000_48A2_148A2:
    // PUSH BX (1000_48A2 / 0x148A2)
    Stack.Push(BX);
    // CALL 0x1000:ca60 (1000_48A3 / 0x148A3)
    NearCall(cs1, 0x48A6, spice86_generated_label_call_target_1000_CA60_01CA60);
    // XOR AX,AX (1000_48A6 / 0x148A6)
    AX = 0;
    // CALL 0x1000:4ec6 (1000_48A8 / 0x148A8)
    NearCall(cs1, 0x48AB, spice86_generated_label_call_target_1000_4EC6_014EC6);
    // POP BX (1000_48AB / 0x148AB)
    BX = Stack.Pop();
    // CMP word ptr [0xdc00],0x2 (1000_48AC / 0x148AC)
    Alu.Sub16(UInt16[DS, 0xDC00], 0x2);
    // JNZ 0x1000:48a2 (1000_48B2 / 0x148B2)
    if(!ZeroFlag) {
      goto label_1000_48A2_148A2;
    }
    // MOV AX,0x3c (1000_48B4 / 0x148B4)
    AX = 0x3C;
    // CMP BX,0x6 (1000_48B7 / 0x148B7)
    Alu.Sub16(BX, 0x6);
    // JZ 0x1000:48c0 (1000_48BB / 0x148BB)
    if(ZeroFlag) {
      goto label_1000_48C0_148C0;
    }
    // MOV AX,0x16 (1000_48BD / 0x148BD)
    AX = 0x16;
    label_1000_48C0_148C0:
    // CMP AX,word ptr [0xdbea] (1000_48C0 / 0x148C0)
    Alu.Sub16(AX, UInt16[DS, 0xDBEA]);
    // JNZ 0x1000:48a2 (1000_48C4 / 0x148C4)
    if(!ZeroFlag) {
      goto label_1000_48A2_148A2;
    }
    // CALL 0x1000:ce4b (1000_48C6 / 0x148C6)
    NearCall(cs1, 0x48C9, not_observed_1000_CE4B_01CE4B);
    label_1000_48C9_148C9:
    // CALL 0x1000:ca60 (1000_48C9 / 0x148C9)
    NearCall(cs1, 0x48CC, spice86_generated_label_call_target_1000_CA60_01CA60);
    // CALL 0x1000:cc85 (1000_48CC / 0x148CC)
    NearCall(cs1, 0x48CF, spice86_generated_label_call_target_1000_CC85_01CC85);
    // JZ 0x1000:48c9 (1000_48CF / 0x148CF)
    if(ZeroFlag) {
      goto label_1000_48C9_148C9;
    }
    label_1000_48D1_148D1:
    // DEC byte ptr [0x46e0] (1000_48D1 / 0x148D1)
    UInt8[DS, 0x46E0] = Alu.Dec8(UInt8[DS, 0x46E0]);
    label_1000_48D5_148D5:
    // MOV byte ptr [0x4732],0x0 (1000_48D5 / 0x148D5)
    UInt8[DS, 0x4732] = 0x0;
    // JMP 0x1000:2d74 (1000_48DA / 0x148DA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2D74_012D74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_48DD_148DD:
    // MOV BP,0xc4cd (1000_48DD / 0x148DD)
    BP = 0xC4CD;
    // CALL 0x1000:c8fb (1000_48E0 / 0x148E0)
    NearCall(cs1, 0x48E3, not_observed_1000_C8FB_01C8FB);
    // JMP 0x1000:48d1 (1000_48E3 / 0x148E3)
    goto label_1000_48D1_148D1;
    label_1000_48E5_148E5:
    // CMP AL,0x9 (1000_48E5 / 0x148E5)
    Alu.Sub8(AL, 0x9);
    // JZ 0x1000:48dd (1000_48E7 / 0x148E7)
    if(ZeroFlag) {
      goto label_1000_48DD_148DD;
    }
    // MOV byte ptr [0x4731],0xff (1000_48E9 / 0x148E9)
    UInt8[DS, 0x4731] = 0xFF;
    // CALL 0x1000:c07c (1000_48EE / 0x148EE)
    NearCall(cs1, 0x48F1, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:5ba0 (1000_48F1 / 0x148F1)
    NearCall(cs1, 0x48F4, spice86_generated_label_call_target_1000_5BA0_015BA0);
    // CALL 0x1000:37b2 (1000_48F4 / 0x148F4)
    NearCall(cs1, 0x48F7, spice86_generated_label_call_target_1000_37B2_0137B2);
    // CALL 0x1000:c0f4 (1000_48F7 / 0x148F7)
    NearCall(cs1, 0x48FA, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // CALL 0x1000:c412 (1000_48FA / 0x148FA)
    NearCall(cs1, 0x48FD, spice86_generated_label_call_target_1000_C412_01C412);
    // MOV byte ptr [0x4731],0x1f (1000_48FD / 0x148FD)
    UInt8[DS, 0x4731] = 0x1F;
    // MOV AL,0x7 (1000_4902 / 0x14902)
    AL = 0x7;
    // CALL 0x1000:ab15 (1000_4904 / 0x14904)
    NearCall(cs1, 0x4907, spice86_generated_label_call_target_1000_AB15_01AB15);
    // MOV CL,0xff (1000_4907 / 0x14907)
    CL = 0xFF;
    // CALL 0x1000:47fb (1000_4909 / 0x14909)
    NearCall(cs1, 0x490C, spice86_generated_label_jump_target_1000_47FB_0147FB);
    // MOV byte ptr [0x4731],0x0 (1000_490C / 0x1490C)
    UInt8[DS, 0x4731] = 0x0;
    // JMP 0x1000:48d5 (1000_4911 / 0x14911)
    goto label_1000_48D5_148D5;
  }
  
  public virtual Action not_observed_1000_491C_01491C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_491C_1491C:
    // CALL 0x1000:c08e (1000_491C / 0x1491C)
    NearCall(cs1, 0x491F, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:c0f4 (1000_491F / 0x1491F)
    NearCall(cs1, 0x4922, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // MOV AL,0x8 (1000_4922 / 0x14922)
    AL = 0x8;
    // CALL 0x1000:ab15 (1000_4924 / 0x14924)
    NearCall(cs1, 0x4927, spice86_generated_label_call_target_1000_AB15_01AB15);
    // CALL 0x1000:ae04 (1000_4927 / 0x14927)
    NearCall(cs1, 0x492A, spice86_generated_label_call_target_1000_AE04_01AE04);
    label_1000_492A_1492A:
    // CALL 0x1000:c9e8 (1000_492A / 0x1492A)
    NearCall(cs1, 0x492D, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    // JZ 0x1000:4934 (1000_492D / 0x1492D)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:c07c (1000_4934 / 0x14934)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:4937 (1000_492F / 0x1492F)
    NearCall(cs1, 0x4932, not_observed_1000_4937_014937);
    // JZ 0x1000:492a (1000_4932 / 0x14932)
    if(ZeroFlag) {
      goto label_1000_492A_1492A;
    }
    label_1000_4934_14934:
    // JMP 0x1000:c07c (1000_4934 / 0x14934)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_4937_014937(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4937_14937:
    // MOV AX,[0xdbe8] (1000_4937 / 0x14937)
    AX = UInt16[DS, 0xDBE8];
    // CMP AL,0xb (1000_493A / 0x1493A)
    Alu.Sub8(AL, 0xB);
    // JNZ 0x1000:4941 (1000_493C / 0x1493C)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:cc85 (1000_4941 / 0x14941)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CC85_01CC85, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:ac30 (1000_493E / 0x1493E)
    NearCall(cs1, 0x4941, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_4941_14941:
    // JMP 0x1000:cc85 (1000_4941 / 0x14941)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CC85_01CC85, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4944_014944(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4944_14944:
    // CALL 0x1000:50be (1000_4944 / 0x14944)
    NearCall(cs1, 0x4947, spice86_generated_label_call_target_1000_50BE_0150BE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4947_014947, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4947_014947(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4947_14947:
    // CMP DI,-0x10 (1000_4947 / 0x14947)
    Alu.Sub16(DI, 0xFFF0);
    // JC 0x1000:4965 (1000_494A / 0x1494A)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4965_014965, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC byte ptr [0x11cb] (1000_494C / 0x1494C)
    UInt8[DS, 0x11CB] = Alu.Dec8(UInt8[DS, 0x11CB]);
    // CALL 0x1000:b5f9 (1000_4950 / 0x14950)
    NearCall(cs1, 0x4953, spice86_generated_label_call_target_1000_B5F9_01B5F9);
    label_1000_4953_14953:
    // MOV CX,BX (1000_4953 / 0x14953)
    CX = BX;
    // MOV DI,DX (1000_4955 / 0x14955)
    DI = DX;
    // CALL 0x1000:407e (1000_4957 / 0x14957)
    NearCall(cs1, 0x495A, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_495A_01495A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_495A_01495A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_495A_1495A:
    // CALL 0x1000:5133 (1000_495A / 0x1495A)
    NearCall(cs1, 0x495D, spice86_generated_label_call_target_1000_5133_015133);
    label_1000_495D_1495D:
    // MOV DI,word ptr [0x1150] (1000_495D / 0x1495D)
    DI = UInt16[DS, 0x1150];
    // MOV CL,0x1 (1000_4961 / 0x14961)
    CL = 0x1;
    // JMP 0x1000:496a (1000_4963 / 0x14963)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_496A_01496A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4965_014965(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4965_14965:
    // CALL 0x1000:5124 (1000_4965 / 0x14965)
    NearCall(cs1, 0x4968, spice86_generated_label_call_target_1000_5124_015124);
    label_1000_4968_14968:
    // XOR CX,CX (1000_4968 / 0x14968)
    CX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_496A_01496A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_496A_01496A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_496A_1496A:
    // MOV word ptr [0x11c5],DI (1000_496A / 0x1496A)
    UInt16[DS, 0x11C5] = DI;
    // MOV byte ptr [0x11c8],CL (1000_496E / 0x1496E)
    UInt8[DS, 0x11C8] = CL;
    // MOV byte ptr [0x11c7],0x0 (1000_4972 / 0x14972)
    UInt8[DS, 0x11C7] = 0x0;
    // JMP 0x1000:5119 (1000_4977 / 0x14977)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5119_015119, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_497A_01497A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_497A_1497A:
    // CALL 0x1000:98e6 (1000_497A / 0x1497A)
    NearCall(cs1, 0x497D, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_497D_01497D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_497D_01497D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_497D_1497D:
    // MOV BP,0x212e (1000_497D / 0x1497D)
    BP = 0x212E;
    // MOV byte ptr [0x4728],0x1 (1000_4980 / 0x14980)
    UInt8[DS, 0x4728] = 0x1;
    // JMP 0x1000:430b (1000_4985 / 0x14985)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_42EF_0142EF, 0x1430B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4988_014988(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_49A0_0149A0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_49A0_0149A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_49A0_149A0:
    // CALL 0x1000:c085 (1000_49A0 / 0x149A0)
    NearCall(cs1, 0x49A3, spice86_generated_label_call_target_1000_C085_01C085);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_49A3_0149A3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_49A3_0149A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_49A3_149A3:
    // CALL 0x1000:5b93 (1000_49A3 / 0x149A3)
    NearCall(cs1, 0x49A6, spice86_generated_label_ret_target_1000_5B93_015B93);
    label_1000_49A6_149A6:
    // MOV byte ptr [0x46eb],0x1 (1000_49A6 / 0x149A6)
    UInt8[DS, 0x46EB] = 0x1;
    // CALL 0x1000:b6c3 (1000_49AB / 0x149AB)
    NearCall(cs1, 0x49AE, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_49AE_0149AE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_49AE_0149AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    BX--;
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
  
  public virtual Action not_observed_1000_49D4_0149D4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_49D4_149D4:
    // CALL 0x1000:4988 (1000_49D4 / 0x149D4)
    NearCall(cs1, 0x49D7, spice86_generated_label_call_target_1000_4988_014988);
    // JMP 0x1000:49e3 (1000_49D7 / 0x149D7)
    // JMP target is JMP, inlining.
    // JMP 0x1000:4a5a (1000_49E3 / 0x149E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4A5A_014A5A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_49D9_0149D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_49D9_149D9:
    // CMP byte ptr [0x46eb],0x0 (1000_49D9 / 0x149D9)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JS 0x1000:49e6 (1000_49DE / 0x149DE)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP word ptr [0x46ed] (1000_49E6 / 0x149E6)
      // Indirect jump to word ptr [0x46ed], generating possible targets from emulator records
      uint targetAddress_1000_49E6 = (uint)(UInt16[DS, 0x46ED]);
      switch(targetAddress_1000_49E6) {
        default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_49E6));
          break;
      }
    }
    // CALL 0x1000:49a0 (1000_49E0 / 0x149E0)
    NearCall(cs1, 0x49E3, not_observed_1000_49A0_0149A0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_49E3_0149E3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_49E3_0149E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_49E3_149E3:
    // JMP 0x1000:4a5a (1000_49E3 / 0x149E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4A5A_014A5A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_49E6_0149E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_49E6_149E6:
    // JMP word ptr [0x46ed] (1000_49E6 / 0x149E6)
    // Indirect jump to word ptr [0x46ed], generating possible targets from emulator records
    uint targetAddress_1000_49E6 = (uint)(UInt16[DS, 0x46ED]);
    switch(targetAddress_1000_49E6) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_49E6));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_49EA_0149EA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_49EA_0149EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_4A00_014A00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_4A1A_014A1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4A46_014A46, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4A46_014A46(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4A59: goto label_1000_4A59_14A59;break; // Target of external jump from 0x14A41
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_4A46_14A46:
    // JC 0x1000:4a59 (1000_4A46 / 0x14A46)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    // DEC BX (1000_4A48 / 0x14A48)
    BX--;
    // DEC DX (1000_4A49 / 0x14A49)
    DX = Alu.Dec16(DX);
    // CALL 0x1000:c137 (1000_4A4A / 0x14A4A)
    NearCall(cs1, 0x4A4D, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_4A4D_14A4D:
    // MOV AX,0x2f (1000_4A4D / 0x14A4D)
    AX = 0x2F;
    // CALL 0x1000:c085 (1000_4A50 / 0x14A50)
    NearCall(cs1, 0x4A53, spice86_generated_label_call_target_1000_C085_01C085);
    label_1000_4A53_14A53:
    // CALL 0x1000:c22f (1000_4A53 / 0x14A53)
    NearCall(cs1, 0x4A56, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_4A56_14A56:
    // CALL 0x1000:c07c (1000_4A56 / 0x14A56)
    NearCall(cs1, 0x4A59, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_4A59_14A59:
    // RET  (1000_4A59 / 0x14A59)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4A5A_014A5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4A5A_14A5A:
    // CALL 0x1000:c137 (1000_4A5A / 0x14A5A)
    NearCall(cs1, 0x4A5D, spice86_generated_label_call_target_1000_C137_01C137);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4A5D_014A5D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4A5D_014A5D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4A5D_14A5D:
    // PUSH word ptr [0xdbda] (1000_4A5D / 0x14A5D)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c085 (1000_4A61 / 0x14A61)
    NearCall(cs1, 0x4A64, spice86_generated_label_call_target_1000_C085_01C085);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4A64_014A64, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4A64_014A64(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4A64_14A64:
    // MOV SI,word ptr [0x149a] (1000_4A64 / 0x14A64)
    SI = UInt16[DS, 0x149A];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4A68_014A68, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4A68_014A68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    label_1000_4A78_14A78:
    // JC 0x1000:4a98 (1000_4A78 / 0x14A78)
    if(CarryFlag) {
      goto label_1000_4A98_14A98;
    }
    // DEC BX (1000_4A7A / 0x14A7A)
    BX--;
    // DEC DX (1000_4A7B / 0x14A7B)
    DX--;
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
  
  public virtual Action not_observed_1000_4AAD_014AAD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4AAD_14AAD:
    // XOR byte ptr [0x4728],0x80 (1000_4AAD / 0x14AAD)
    // UInt8[DS, 0x4728] ^= 0x80;
    UInt8[DS, 0x4728] = Alu.Xor8(UInt8[DS, 0x4728], 0x80);
    // JS 0x1000:4ab7 (1000_4AB2 / 0x14AB2)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_4AB7 / 0x14AB7)
      return NearRet();
    }
    // CALL 0x1000:49d4 (1000_4AB4 / 0x14AB4)
    NearCall(cs1, 0x4AB7, not_observed_1000_49D4_0149D4);
    label_1000_4AB7_14AB7:
    // RET  (1000_4AB7 / 0x14AB7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4AB8_014AB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4AB8_14AB8:
    // MOV byte ptr [0x4727],0xff (1000_4AB8 / 0x14AB8)
    UInt8[DS, 0x4727] = 0xFF;
    // RET  (1000_4ABD / 0x14ABD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4ABE_014ABE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4ABE_14ABE:
    // CALL 0x1000:37f4 (1000_4ABE / 0x14ABE)
    NearCall(cs1, 0x4AC1, spice86_generated_label_call_target_1000_37F4_0137F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AC1_014AC1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4AC1_014AC1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4AC1_14AC1:
    // CALL 0x1000:c4dd (1000_4AC1 / 0x14AC1)
    NearCall(cs1, 0x4AC4, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AC4_014AC4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4AC4_014AC4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4AC4_14AC4:
    // MOV byte ptr [0x11ca],0x0 (1000_4AC4 / 0x14AC4)
    UInt8[DS, 0x11CA] = 0x0;
    // RET  (1000_4AC9 / 0x14AC9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4ACA_014ACA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4ACA_14ACA:
    // MOV byte ptr [0x11ca],0x1 (1000_4ACA / 0x14ACA)
    UInt8[DS, 0x11CA] = 0x1;
    // RET  (1000_4ACF / 0x14ACF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4AD0_014AD0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4AD0_14AD0:
    // CALL 0x1000:4e8d (1000_4AD0 / 0x14AD0)
    NearCall(cs1, 0x4AD3, spice86_generated_label_call_target_1000_4E8D_014E8D);
    label_1000_4AD3_14AD3:
    // MOV AH,0xfc (1000_4AD3 / 0x14AD3)
    AH = 0xFC;
    // JMP 0x1000:4adc (1000_4AD5 / 0x14AD5)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4AD7_014AD7, 0x14ADC - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4AD7_014AD7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4ADC: goto label_1000_4ADC_14ADC;break; // Target of external jump from 0x14AD5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_4AD7_14AD7:
    // CALL 0x1000:4e8d (1000_4AD7 / 0x14AD7)
    NearCall(cs1, 0x4ADA, spice86_generated_label_call_target_1000_4E8D_014E8D);
    label_1000_4ADA_14ADA:
    // MOV AH,0x4 (1000_4ADA / 0x14ADA)
    AH = 0x4;
    label_1000_4ADC_14ADC:
    // SHR AL,1 (1000_4ADC / 0x14ADC)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNC 0x1000:4aea (1000_4ADE / 0x14ADE)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_4AEA / 0x14AEA)
      return NearRet();
    }
    // MOV byte ptr [0x11c8],0x1 (1000_4AE0 / 0x14AE0)
    UInt8[DS, 0x11C8] = 0x1;
    // MOV AL,AH (1000_4AE5 / 0x14AE5)
    AL = AH;
    // CALL 0x1000:5119 (1000_4AE7 / 0x14AE7)
    NearCall(cs1, 0x4AEA, spice86_generated_label_call_target_1000_5119_015119);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4AEA_014AEA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4AEA_014AEA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4AEA_14AEA:
    // RET  (1000_4AEA / 0x14AEA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4AEB_014AEB(int loadOffset) {
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
    NearCall(cs1, 0x4AF7, not_observed_1000_4D6C_014D6C);
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_4B16_014B16, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:4b2b (1000_4B04 / 0x14B04)
    NearCall(cs1, 0x4B07, spice86_generated_label_call_target_1000_4B2B_014B2B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4B07_014B07, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4B07_014B07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DBCA_01DBCA, 0x1DBE3 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_4B16_014B16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_4B2B_014B2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DBCA_01DBCA, 0)) {
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
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DBCA_01DBCA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4B3B_014B3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4B3B_14B3B:
    // INC word ptr [0x472b] (1000_4B3B / 0x14B3B)
    UInt16[DS, 0x472B]++;
    // TEST word ptr [0x472b],0xf (1000_4B3F / 0x14B3F)
    Alu.And16(UInt16[DS, 0x472B], 0xF);
    // JNZ 0x1000:4b4d (1000_4B45 / 0x14B45)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4B4D_014B4D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,0x1 (1000_4B47 / 0x14B47)
    CX = 0x1;
    // CALL 0x1000:0fd9 (1000_4B4A / 0x14B4A)
    NearCall(cs1, 0x4B4D, spice86_generated_label_call_target_1000_0FD9_010FD9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4B4D_014B4D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4B4D_014B4D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action not_observed_1000_4B5F_014B5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4B5F_14B5F:
    // MOV SI,0x1470 (1000_4B5F / 0x14B5F)
    SI = 0x1470;
    // MOV AX,DX (1000_4B62 / 0x14B62)
    AX = DX;
    // ADD AX,word ptr [0x487a] (1000_4B64 / 0x14B64)
    AX += UInt16[DS, 0x487A];
    // CMP DX,word ptr [SI] (1000_4B68 / 0x14B68)
    Alu.Sub16(DX, UInt16[DS, SI]);
    // JGE 0x1000:4b6e (1000_4B6A / 0x14B6A)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4B6E_14B6E;
    }
    // MOV DX,word ptr [SI] (1000_4B6C / 0x14B6C)
    DX = UInt16[DS, SI];
    label_1000_4B6E_14B6E:
    // CMP DX,word ptr [SI + 0x4] (1000_4B6E / 0x14B6E)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JLE 0x1000:4b76 (1000_4B71 / 0x14B71)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4B76_14B76;
    }
    // MOV DX,word ptr [SI + 0x4] (1000_4B73 / 0x14B73)
    DX = UInt16[DS, (ushort)(SI + 0x4)];
    label_1000_4B76_14B76:
    // MOV word ptr [0x4860],DX (1000_4B76 / 0x14B76)
    UInt16[DS, 0x4860] = DX;
    // CMP AX,word ptr [SI] (1000_4B7A / 0x14B7A)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JGE 0x1000:4b80 (1000_4B7C / 0x14B7C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4B80_14B80;
    }
    // MOV AX,word ptr [SI] (1000_4B7E / 0x14B7E)
    AX = UInt16[DS, SI];
    label_1000_4B80_14B80:
    // CMP AX,word ptr [SI + 0x4] (1000_4B80 / 0x14B80)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JLE 0x1000:4b88 (1000_4B83 / 0x14B83)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4B88_14B88;
    }
    // MOV AX,word ptr [SI + 0x4] (1000_4B85 / 0x14B85)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    label_1000_4B88_14B88:
    // MOV [0x4864],AX (1000_4B88 / 0x14B88)
    UInt16[DS, 0x4864] = AX;
    // MOV AX,BX (1000_4B8B / 0x14B8B)
    AX = BX;
    // ADD AX,word ptr [0x487c] (1000_4B8D / 0x14B8D)
    AX += UInt16[DS, 0x487C];
    // CMP BX,word ptr [SI + 0x2] (1000_4B91 / 0x14B91)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JGE 0x1000:4b99 (1000_4B94 / 0x14B94)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4B99_14B99;
    }
    // MOV BX,word ptr [SI + 0x2] (1000_4B96 / 0x14B96)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    label_1000_4B99_14B99:
    // CMP BX,word ptr [SI + 0x6] (1000_4B99 / 0x14B99)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JLE 0x1000:4ba1 (1000_4B9C / 0x14B9C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4BA1_14BA1;
    }
    // MOV BX,word ptr [SI + 0x6] (1000_4B9E / 0x14B9E)
    BX = UInt16[DS, (ushort)(SI + 0x6)];
    label_1000_4BA1_14BA1:
    // MOV word ptr [0x4862],BX (1000_4BA1 / 0x14BA1)
    UInt16[DS, 0x4862] = BX;
    // CMP AX,word ptr [SI + 0x2] (1000_4BA5 / 0x14BA5)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JGE 0x1000:4bad (1000_4BA8 / 0x14BA8)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4BAD_14BAD;
    }
    // MOV AX,word ptr [SI + 0x2] (1000_4BAA / 0x14BAA)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    label_1000_4BAD_14BAD:
    // CMP AX,word ptr [SI + 0x6] (1000_4BAD / 0x14BAD)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JLE 0x1000:4bb5 (1000_4BB0 / 0x14BB0)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4BB5_14BB5;
    }
    // MOV AX,word ptr [SI + 0x6] (1000_4BB2 / 0x14BB2)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    label_1000_4BB5_14BB5:
    // MOV [0x4866],AX (1000_4BB5 / 0x14BB5)
    UInt16[DS, 0x4866] = AX;
    // RET  (1000_4BB8 / 0x14BB8)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4BDF_014BDF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4BDF_14BDF:
    // MOV AX,[0x485e] (1000_4BDF / 0x14BDF)
    AX = UInt16[DS, 0x485E];
    // CALL 0x1000:c13e (1000_4BE2 / 0x14BE2)
    NearCall(cs1, 0x4BE5, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV AX,[0x4878] (1000_4BE5 / 0x14BE5)
    AX = UInt16[DS, 0x4878];
    // XOR AH,AH (1000_4BE8 / 0x14BE8)
    AH = 0;
    // ADD AX,word ptr [0x4874] (1000_4BEA / 0x14BEA)
    // AX += UInt16[DS, 0x4874];
    AX = Alu.Add16(AX, UInt16[DS, 0x4874]);
    // MOV [0x4878],AX (1000_4BEE / 0x14BEE)
    UInt16[DS, 0x4878] = AX;
    // MOV AL,AH (1000_4BF1 / 0x14BF1)
    AL = AH;
    // CBW  (1000_4BF3 / 0x14BF3)
    AX = (ushort)((short)((sbyte)AL));
    // ADD word ptr [0x4870],AX (1000_4BF4 / 0x14BF4)
    // UInt16[DS, 0x4870] += AX;
    UInt16[DS, 0x4870] = Alu.Add16(UInt16[DS, 0x4870], AX);
    // MOV AX,[0x4876] (1000_4BF8 / 0x14BF8)
    AX = UInt16[DS, 0x4876];
    // XOR AH,AH (1000_4BFB / 0x14BFB)
    AH = 0;
    // ADD AX,word ptr [0x4872] (1000_4BFD / 0x14BFD)
    // AX += UInt16[DS, 0x4872];
    AX = Alu.Add16(AX, UInt16[DS, 0x4872]);
    // MOV [0x4876],AX (1000_4C01 / 0x14C01)
    UInt16[DS, 0x4876] = AX;
    // MOV AL,AH (1000_4C04 / 0x14C04)
    AL = AH;
    // CBW  (1000_4C06 / 0x14C06)
    AX = (ushort)((short)((sbyte)AL));
    // ADD word ptr [0x486e],AX (1000_4C07 / 0x14C07)
    // UInt16[DS, 0x486E] += AX;
    UInt16[DS, 0x486E] = Alu.Add16(UInt16[DS, 0x486E], AX);
    // MOV DX,word ptr [0x486e] (1000_4C0B / 0x14C0B)
    DX = UInt16[DS, 0x486E];
    // MOV BX,word ptr [0x4870] (1000_4C0F / 0x14C0F)
    BX = UInt16[DS, 0x4870];
    // CALL 0x1000:4b5f (1000_4C13 / 0x14C13)
    NearCall(cs1, 0x4C16, not_observed_1000_4B5F_014B5F);
    // MOV SI,word ptr [0x486a] (1000_4C16 / 0x14C16)
    SI = UInt16[DS, 0x486A];
    // MOV DS,word ptr SS:[0xdbb2] (1000_4C1A / 0x14C1A)
    DS = UInt16[SS, 0xDBB2];
    // CMP byte ptr [SI],0xff (1000_4C1F / 0x14C1F)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:4c29 (1000_4C22 / 0x14C22)
    if(!ZeroFlag) {
      goto label_1000_4C29_14C29;
    }
    // MOV SI,word ptr SS:[0x4868] (1000_4C24 / 0x14C24)
    SI = UInt16[SS, 0x4868];
    label_1000_4C29_14C29:
    // LODSB SI (1000_4C29 / 0x14C29)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_4C2A / 0x14C2A)
    AH = 0;
    // OR AL,AL (1000_4C2C / 0x14C2C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:4c3e (1000_4C2E / 0x14C2E)
    if(ZeroFlag) {
      goto label_1000_4C3E_14C3E;
    }
    // CMP AL,0x1 (1000_4C30 / 0x14C30)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:4c37 (1000_4C32 / 0x14C32)
    if(!ZeroFlag) {
      goto label_1000_4C37_14C37;
    }
    // MOV AH,AL (1000_4C34 / 0x14C34)
    AH = AL;
    // LODSB SI (1000_4C36 / 0x14C36)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_4C37_14C37:
    // PUSH SI (1000_4C37 / 0x14C37)
    Stack.Push(SI);
    // CALL 0x1000:4c45 (1000_4C38 / 0x14C38)
    NearCall(cs1, 0x4C3B, not_observed_1000_4C45_014C45);
    // POP SI (1000_4C3B / 0x14C3B)
    SI = Stack.Pop();
    // JMP 0x1000:4c29 (1000_4C3C / 0x14C3C)
    goto label_1000_4C29_14C29;
    label_1000_4C3E_14C3E:
    // PUSH SS (1000_4C3E / 0x14C3E)
    Stack.Push(SS);
    // POP DS (1000_4C3F / 0x14C3F)
    DS = Stack.Pop();
    // MOV word ptr [0x486a],SI (1000_4C40 / 0x14C40)
    UInt16[DS, 0x486A] = SI;
    // RET  (1000_4C44 / 0x14C44)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4C45_014C45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4C45_14C45:
    // SUB AX,0x2 (1000_4C45 / 0x14C45)
    AX -= 0x2;
    // SHL AX,1 (1000_4C48 / 0x14C48)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_4C4A / 0x14C4A)
    BP = AX;
    // MOV SI,word ptr SS:[0x486c] (1000_4C4C / 0x14C4C)
    SI = UInt16[SS, 0x486C];
    // ADD SI,word ptr DS:[BP + SI] (1000_4C51 / 0x14C51)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    label_1000_4C54_14C54:
    // LODSB SI (1000_4C54 / 0x14C54)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_4C55 / 0x14C55)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:4c91 (1000_4C57 / 0x14C57)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4C91 / 0x14C91)
      return NearRet();
    }
    // XOR AH,AH (1000_4C59 / 0x14C59)
    AH = 0;
    // MOV BP,AX (1000_4C5B / 0x14C5B)
    BP = AX;
    // LODSB SI (1000_4C5D / 0x14C5D)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV DX,AX (1000_4C5E / 0x14C5E)
    DX = AX;
    // LODSB SI (1000_4C60 / 0x14C60)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_4C61 / 0x14C61)
    BX = AX;
    // ADD DX,word ptr SS:[0x486e] (1000_4C63 / 0x14C63)
    DX += UInt16[SS, 0x486E];
    // ADD BX,word ptr SS:[0x4870] (1000_4C68 / 0x14C68)
    // BX += UInt16[SS, 0x4870];
    BX = Alu.Add16(BX, UInt16[SS, 0x4870]);
    // PUSH SI (1000_4C6D / 0x14C6D)
    Stack.Push(SI);
    // DEC BP (1000_4C6E / 0x14C6E)
    BP = Alu.Dec16(BP);
    // MOV ES,word ptr SS:[0xdbda] (1000_4C6F / 0x14C6F)
    ES = UInt16[SS, 0xDBDA];
    // MOV SI,word ptr SS:[0xdbb0] (1000_4C74 / 0x14C74)
    SI = UInt16[SS, 0xDBB0];
    // SHL BP,1 (1000_4C79 / 0x14C79)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_4C7B / 0x14C7B)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_4C7E / 0x14C7E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_4C7F / 0x14C7F)
    DI = AX;
    // LODSW SI (1000_4C81 / 0x14C81)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_4C82 / 0x14C82)
    AH = 0;
    // MOV CX,AX (1000_4C84 / 0x14C84)
    CX = AX;
    // MOV BP,0x4860 (1000_4C86 / 0x14C86)
    BP = 0x4860;
    // CALLF [0x38cd] (1000_4C89 / 0x14C89)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_4C89 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_4C89) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4C89));
        break;
    }
    // POP SI (1000_4C8E / 0x14C8E)
    SI = Stack.Pop();
    // JMP 0x1000:4c54 (1000_4C8F / 0x14C8F)
    goto label_1000_4C54_14C54;
    label_1000_4C91_14C91:
    // RET  (1000_4C91 / 0x14C91)
    return NearRet();
  }
  
  public virtual Action split_1000_4C92_014C92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4C92_14C92:
    // PUSH DS (1000_4C92 / 0x14C92)
    Stack.Push(DS);
    // PUSH AX (1000_4C93 / 0x14C93)
    Stack.Push(AX);
    // XOR AH,AH (1000_4C94 / 0x14C94)
    AH = 0;
    // MOV [0x485e],AX (1000_4C96 / 0x14C96)
    UInt16[DS, 0x485E] = AX;
    // MOV word ptr [0x486e],DX (1000_4C99 / 0x14C99)
    UInt16[DS, 0x486E] = DX;
    // MOV word ptr [0x4870],BX (1000_4C9D / 0x14C9D)
    UInt16[DS, 0x4870] = BX;
    // MOV word ptr [0x4872],BP (1000_4CA1 / 0x14CA1)
    UInt16[DS, 0x4872] = BP;
    // MOV word ptr [0x4874],CX (1000_4CA5 / 0x14CA5)
    UInt16[DS, 0x4874] = CX;
    // MOV word ptr [0x4876],0x0 (1000_4CA9 / 0x14CA9)
    UInt16[DS, 0x4876] = 0x0;
    // MOV word ptr [0x4878],0x0 (1000_4CAF / 0x14CAF)
    UInt16[DS, 0x4878] = 0x0;
    // CALL 0x1000:c13e (1000_4CB5 / 0x14CB5)
    NearCall(cs1, 0x4CB8, spice86_generated_label_call_target_1000_C13E_01C13E);
    // PUSH DS (1000_4CB8 / 0x14CB8)
    Stack.Push(DS);
    // POP ES (1000_4CB9 / 0x14CB9)
    ES = Stack.Pop();
    // LDS SI,[0xdbb0] (1000_4CBA / 0x14CBA)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV BX,word ptr [SI] (1000_4CBE / 0x14CBE)
    BX = UInt16[DS, SI];
    // ADD SI,word ptr [BX + SI + -0x2] (1000_4CC0 / 0x14CC0)
    // SI += UInt16[DS, (ushort)(BX + SI - 0x2)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BX + SI - 0x2)]);
    // MOV DI,0x4860 (1000_4CC3 / 0x14CC3)
    DI = 0x4860;
    // ADD SI,0x4 (1000_4CC6 / 0x14CC6)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LODSW SI (1000_4CC9 / 0x14CC9)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_4CCA / 0x14CCA)
    DX = AX;
    // LODSW SI (1000_4CCC / 0x14CCC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_4CCD / 0x14CCD)
    BX = AX;
    // LODSW SI (1000_4CCF / 0x14CCF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB AX,DX (1000_4CD0 / 0x14CD0)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    // MOV SS:[0x487a],AX (1000_4CD2 / 0x14CD2)
    UInt16[SS, 0x487A] = AX;
    // LODSW SI (1000_4CD6 / 0x14CD6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // SUB AX,BX (1000_4CD7 / 0x14CD7)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // MOV SS:[0x487c],AX (1000_4CD9 / 0x14CD9)
    UInt16[SS, 0x487C] = AX;
    // MOV AX,SI (1000_4CDD / 0x14CDD)
    AX = SI;
    // ADD AX,0x2 (1000_4CDF / 0x14CDF)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // MOV SS:[0x486c],AX (1000_4CE2 / 0x14CE2)
    UInt16[SS, 0x486C] = AX;
    // ADD SI,word ptr [SI] (1000_4CE6 / 0x14CE6)
    // SI += UInt16[DS, SI];
    SI = Alu.Add16(SI, UInt16[DS, SI]);
    // POP AX (1000_4CE8 / 0x14CE8)
    AX = Stack.Pop();
    // MOV AL,AH (1000_4CE9 / 0x14CE9)
    AL = AH;
    // XOR AH,AH (1000_4CEB / 0x14CEB)
    AH = 0;
    // SHL AX,1 (1000_4CED / 0x14CED)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_4CEF / 0x14CEF)
    BP = AX;
    // ADD SI,word ptr DS:[BP + SI] (1000_4CF1 / 0x14CF1)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // MOV word ptr SS:[0x4868],SI (1000_4CF4 / 0x14CF4)
    UInt16[SS, 0x4868] = SI;
    // MOV word ptr SS:[0x486a],SI (1000_4CF9 / 0x14CF9)
    UInt16[SS, 0x486A] = SI;
    // POP DS (1000_4CFE / 0x14CFE)
    DS = Stack.Pop();
    // RET  (1000_4CFF / 0x14CFF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4D00_014D00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_jump_target_1000_4D06_014D06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    NearCall(cs1, 0x4D37, not_observed_1000_4D57_014D57);
    // CALL 0x1000:4bdf (1000_4D37 / 0x14D37)
    NearCall(cs1, 0x4D3A, not_observed_1000_4BDF_014BDF);
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
    NearCall(cs1, 0x4D4D, not_observed_1000_4D57_014D57);
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
  
  public virtual Action not_observed_1000_4D57_014D57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4D57_14D57:
    // MOV AL,0x31 (1000_4D57 / 0x14D57)
    AL = 0x31;
    // MOV DX,0x5 (1000_4D59 / 0x14D59)
    DX = 0x5;
    // SHL BH,1 (1000_4D5C / 0x14D5C)
    BH <<= 0x1;
    // SHL BH,1 (1000_4D5E / 0x14D5E)
    BH <<= 0x1;
    // ADD DL,BH (1000_4D60 / 0x14D60)
    // DL += BH;
    DL = Alu.Add8(DL, BH);
    // MOV BX,0x29 (1000_4D62 / 0x14D62)
    BX = 0x29;
    // XOR BP,BP (1000_4D65 / 0x14D65)
    BP = 0;
    // XOR CX,CX (1000_4D67 / 0x14D67)
    CX = 0;
    // JMP 0x1000:4c92 (1000_4D69 / 0x14D69)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_4C92_014C92, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_4D6C_014D6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4D6C_14D6C:
    // MOV SI,word ptr [0xaa6e] (1000_4D6C / 0x14D6C)
    SI = UInt16[DS, 0xAA6E];
    // CMP byte ptr CS:[SI],0xff (1000_4D70 / 0x14D70)
    Alu.Sub8(UInt8[cs1, SI], 0xFF);
    // JNZ 0x1000:4d82 (1000_4D74 / 0x14D74)
    if(!ZeroFlag) {
      goto label_1000_4D82_14D82;
    }
    // MOV SI,word ptr CS:[0x167] (1000_4D76 / 0x14D76)
    SI = UInt16[cs1, 0x167];
    // ADD SI,word ptr CS:[SI] (1000_4D7B / 0x14D7B)
    // SI += UInt16[cs1, SI];
    SI = Alu.Add16(SI, UInt16[cs1, SI]);
    // MOV word ptr [0xaa6e],SI (1000_4D7E / 0x14D7E)
    UInt16[DS, 0xAA6E] = SI;
    label_1000_4D82_14D82:
    // PUSH CS (1000_4D82 / 0x14D82)
    Stack.Push(cs1);
    // POP DS (1000_4D83 / 0x14D83)
    DS = Stack.Pop();
    label_1000_4D84_14D84:
    // LODSB SI (1000_4D84 / 0x14D84)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_4D85 / 0x14D85)
    AH = 0;
    // OR AL,AL (1000_4D87 / 0x14D87)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:4d99 (1000_4D89 / 0x14D89)
    if(ZeroFlag) {
      goto label_1000_4D99_14D99;
    }
    // CMP AL,0x1 (1000_4D8B / 0x14D8B)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:4d92 (1000_4D8D / 0x14D8D)
    if(!ZeroFlag) {
      goto label_1000_4D92_14D92;
    }
    // MOV AH,AL (1000_4D8F / 0x14D8F)
    AH = AL;
    // LODSB SI (1000_4D91 / 0x14D91)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    label_1000_4D92_14D92:
    // PUSH SI (1000_4D92 / 0x14D92)
    Stack.Push(SI);
    // CALL 0x1000:4da0 (1000_4D93 / 0x14D93)
    NearCall(cs1, 0x4D96, not_observed_1000_4DA0_014DA0);
    // POP SI (1000_4D96 / 0x14D96)
    SI = Stack.Pop();
    // JMP 0x1000:4d84 (1000_4D97 / 0x14D97)
    goto label_1000_4D84_14D84;
    label_1000_4D99_14D99:
    // PUSH SS (1000_4D99 / 0x14D99)
    Stack.Push(SS);
    // POP DS (1000_4D9A / 0x14D9A)
    DS = Stack.Pop();
    // MOV word ptr [0xaa6e],SI (1000_4D9B / 0x14D9B)
    UInt16[DS, 0xAA6E] = SI;
    // RET  (1000_4D9F / 0x14D9F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4DA0_014DA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4DA0_14DA0:
    // SUB AX,0x2 (1000_4DA0 / 0x14DA0)
    AX -= 0x2;
    // SHL AX,1 (1000_4DA3 / 0x14DA3)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV BP,AX (1000_4DA5 / 0x14DA5)
    BP = AX;
    // MOV SI,0x169 (1000_4DA7 / 0x14DA7)
    SI = 0x169;
    // ADD SI,word ptr CS:[BP + SI] (1000_4DAA / 0x14DAA)
    // SI += UInt16[cs1, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[cs1, (ushort)(BP + SI)]);
    label_1000_4DAD_14DAD:
    // LODSB SI (1000_4DAD / 0x14DAD)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_4DAE / 0x14DAE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:4dec (1000_4DB0 / 0x14DB0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4DEC / 0x14DEC)
      return NearRet();
    }
    // XOR AH,AH (1000_4DB2 / 0x14DB2)
    AH = 0;
    // MOV BP,AX (1000_4DB4 / 0x14DB4)
    BP = AX;
    // LODSB SI (1000_4DB6 / 0x14DB6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV DX,AX (1000_4DB7 / 0x14DB7)
    DX = AX;
    // LODSB SI (1000_4DB9 / 0x14DB9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_4DBA / 0x14DBA)
    BX = AX;
    // ADD DX,word ptr SS:[0xaa66] (1000_4DBC / 0x14DBC)
    DX += UInt16[SS, 0xAA66];
    // ADD BX,word ptr SS:[0xaa68] (1000_4DC1 / 0x14DC1)
    // BX += UInt16[SS, 0xAA68];
    BX = Alu.Add16(BX, UInt16[SS, 0xAA68]);
    // PUSH SI (1000_4DC6 / 0x14DC6)
    Stack.Push(SI);
    // PUSH DS (1000_4DC7 / 0x14DC7)
    Stack.Push(DS);
    // DEC BP (1000_4DC8 / 0x14DC8)
    BP = Alu.Dec16(BP);
    // MOV ES,word ptr SS:[0xdbda] (1000_4DC9 / 0x14DC9)
    ES = UInt16[SS, 0xDBDA];
    // LDS SI,SS:[0xdbb0] (1000_4DCE / 0x14DCE)
    DS = UInt16[SS, 0xDBB2];
    SI = UInt16[SS, 0xDBB0];
    // SHL BP,1 (1000_4DD3 / 0x14DD3)
    BP <<= 0x1;
    // ADD SI,word ptr DS:[BP + SI] (1000_4DD5 / 0x14DD5)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    // LODSW SI (1000_4DD8 / 0x14DD8)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_4DD9 / 0x14DD9)
    DI = AX;
    // LODSW SI (1000_4DDB / 0x14DDB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XOR AH,AH (1000_4DDC / 0x14DDC)
    AH = 0;
    // MOV CX,AX (1000_4DDE / 0x14DDE)
    CX = AX;
    // MOV BP,0xaa66 (1000_4DE0 / 0x14DE0)
    BP = 0xAA66;
    // CALLF [0x38cd] (1000_4DE3 / 0x14DE3)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_4DE3 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_4DE3) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4DE3));
        break;
    }
    // POP DS (1000_4DE8 / 0x14DE8)
    DS = Stack.Pop();
    // POP SI (1000_4DE9 / 0x14DE9)
    SI = Stack.Pop();
    // JMP 0x1000:4dad (1000_4DEA / 0x14DEA)
    goto label_1000_4DAD_14DAD;
    label_1000_4DEC_14DEC:
    // RET  (1000_4DEC / 0x14DEC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4DED_014DED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4DED_14DED:
    // XOR CX,CX (1000_4DED / 0x14DED)
    CX = 0;
    // MOV BP,0x4e04 (1000_4DEF / 0x14DEF)
    BP = 0x4E04;
    // PUSH SI (1000_4DF2 / 0x14DF2)
    Stack.Push(SI);
    // CALL 0x1000:661d (1000_4DF3 / 0x14DF3)
    NearCall(cs1, 0x4DF6, spice86_generated_label_call_target_1000_661D_01661D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4DF6_014DF6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4DF6_014DF6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4DF6_14DF6:
    // MOV CH,byte ptr [DI + 0x14] (1000_4DF6 / 0x14DF6)
    CH = UInt8[DS, (ushort)(DI + 0x14)];
    // MOV word ptr [0x4733],CX (1000_4DF9 / 0x14DF9)
    UInt16[DS, 0x4733] = CX;
    // PUSH ES (1000_4DFD / 0x14DFD)
    Stack.Push(ES);
    // CALL 0x1000:7f27 (1000_4DFE / 0x14DFE)
    NearCall(cs1, 0x4E01, spice86_generated_label_call_target_1000_7F27_017F27);
    label_1000_4E01_14E01:
    // POP ES (1000_4E01 / 0x14E01)
    ES = Stack.Pop();
    // POP SI (1000_4E02 / 0x14E02)
    SI = Stack.Pop();
    // RET  (1000_4E03 / 0x14E03)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4E04_014E04(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4E04_14E04:
    // CMP byte ptr [SI + 0x3],0x0 (1000_4E04 / 0x14E04)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x0);
    // JNZ 0x1000:4e11 (1000_4E08 / 0x14E08)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_4E11 / 0x14E11)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x19],0x80 (1000_4E0A / 0x14E0A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x80);
    // JZ 0x1000:4e11 (1000_4E0E / 0x14E0E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_4E11 / 0x14E11)
      return NearRet();
    }
    // INC CX (1000_4E10 / 0x14E10)
    CX = Alu.Inc16(CX);
    label_1000_4E11_14E11:
    // RET  (1000_4E11 / 0x14E11)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4E12_014E12(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4E12_14E12:
    // MOV word ptr [0x4733],0x0 (1000_4E12 / 0x14E12)
    UInt16[DS, 0x4733] = 0x0;
    // CALL 0x1000:407e (1000_4E18 / 0x14E18)
    NearCall(cs1, 0x4E1B, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4E1B_014E1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4E1B_014E1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    label_1000_4E58_14E58:
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
    NearCall(cs1, 0x4E76, spice86_generated_label_call_target_1000_4DED_014DED);
    label_1000_4E76_14E76:
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
  
  public virtual Action spice86_generated_label_call_target_1000_4E8D_014E8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4E8D_14E8D:
    // RET  (1000_4E8D / 0x14E8D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4E8E_014E8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // SHR AL,1 (1000_4EC4 / 0x14EC4)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4EC6_014EC6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4EC6_014EC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_4F0C_014F0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F27_014F27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4F27_014F27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4F27_14F27:
    // MOV AX,[0xce7a] (1000_4F27 / 0x14F27)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,word ptr [0x4729] (1000_4F2A / 0x14F2A)
    AX -= UInt16[DS, 0x4729];
    // CMP AX,0x300 (1000_4F2E / 0x14F2E)
    Alu.Sub16(AX, 0x300);
    // JNC 0x1000:4f34 (1000_4F31 / 0x14F31)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4F34_014F34, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4F33_014F33, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
