namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_334B_2343_0357F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2343_357F3:
    // PUSH DX (334B_2343 / 0x357F3)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BP (334B_2344 / 0x357F4)
    Stack.Push(BP);
    State.IncCycles();
    // MOV BH,0x4 (334B_2345 / 0x357F5)
    BH = 0x4;
    State.IncCycles();
    // MOV BP,0xf0f (334B_2347 / 0x357F7)
    BP = 0xF0F;
    State.IncCycles();
    // MOV DX,0x1010 (334B_234A / 0x357FA)
    DX = 0x1010;
    State.IncCycles();
    label_334B_234D_357FD:
    // PUSH CX (334B_234D / 0x357FD)
    Stack.Push(CX);
    State.IncCycles();
    // SHR CX,1 (334B_234E / 0x357FE)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // JNC 0x3000:5810 (334B_2350 / 0x35800)
    if(!CarryFlag) {
      goto label_334B_2360_35810;
    }
    State.IncCycles();
    // LODSB SI (334B_2352 / 0x35802)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SHR AL,1 (334B_2353 / 0x35803)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_2355 / 0x35805)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_2357 / 0x35807)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (334B_2359 / 0x35809)
    AL >>= 0x1;
    State.IncCycles();
    // AND AX,BP (334B_235B / 0x3580B)
    AX &= BP;
    State.IncCycles();
    // ADD AL,DL (334B_235D / 0x3580D)
    // AL += DL;
    AL = Alu.Add8(AL, DL);
    State.IncCycles();
    // STOSB ES:DI (334B_235F / 0x3580F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_334B_2360_35810:
    // LODSW SI (334B_2360 / 0x35810)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SHR AX,1 (334B_2361 / 0x35811)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_2363 / 0x35813)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_2365 / 0x35815)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (334B_2367 / 0x35817)
    AX >>= 0x1;
    State.IncCycles();
    // AND AX,BP (334B_2369 / 0x35819)
    AX &= BP;
    State.IncCycles();
    // ADD AX,DX (334B_236B / 0x3581B)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // STOSW ES:DI (334B_236D / 0x3581D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LOOP 0x3000:5810 (334B_236E / 0x3581E)
    if(--CX != 0) {
      goto label_334B_2360_35810;
    }
    State.IncCycles();
    // POP CX (334B_2370 / 0x35820)
    CX = Stack.Pop();
    State.IncCycles();
    // SUB DI,CX (334B_2371 / 0x35821)
    DI -= CX;
    State.IncCycles();
    // SUB SI,CX (334B_2373 / 0x35823)
    SI -= CX;
    State.IncCycles();
    // ADD DI,0x140 (334B_2375 / 0x35825)
    DI += 0x140;
    State.IncCycles();
    // ADD SI,0x190 (334B_2379 / 0x35829)
    SI += 0x190;
    State.IncCycles();
    // DEC BH (334B_237D / 0x3582D)
    BH = Alu.Dec8(BH);
    State.IncCycles();
    // JNZ 0x3000:57fd (334B_237F / 0x3582F)
    if(!ZeroFlag) {
      goto label_334B_234D_357FD;
    }
    State.IncCycles();
    // POP BP (334B_2381 / 0x35831)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_2382 / 0x35832)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (334B_2383 / 0x35833)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2396_035846(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2396_35846:
    // XOR DX,DX (334B_2396 / 0x35846)
    DX = 0;
    State.IncCycles();
    // OR AX,AX (334B_2398 / 0x35848)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x3000:584e (334B_239A / 0x3584A)
    if(!SignFlag) {
      goto label_334B_239E_3584E;
    }
    State.IncCycles();
    // NEG AX (334B_239C / 0x3584C)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_334B_239E_3584E:
    // SUB AX,0x46 (334B_239E / 0x3584E)
    // AX -= 0x46;
    AX = Alu.Sub16(AX, 0x46);
    State.IncCycles();
    // JC 0x3000:587b (334B_23A1 / 0x35851)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (334B_23CB / 0x3587B)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,0x2384 (334B_23A3 / 0x35853)
    BX = 0x2384;
    State.IncCycles();
    // XLAT CS:BX (334B_23A6 / 0x35856)
    AL = UInt8[cs2, (ushort)(BX + AL)];
    State.IncCycles();
    // XOR AH,AH (334B_23A8 / 0x35858)
    AH = 0;
    State.IncCycles();
    // MOV DX,AX (334B_23AA / 0x3585A)
    DX = AX;
    State.IncCycles();
    // XOR AL,AL (334B_23AC / 0x3585C)
    AL = 0;
    State.IncCycles();
    // ADD SI,DX (334B_23AE / 0x3585E)
    SI += DX;
    State.IncCycles();
    // SUB CX,DX (334B_23B0 / 0x35860)
    CX -= DX;
    State.IncCycles();
    // SUB CX,DX (334B_23B2 / 0x35862)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    State.IncCycles();
    // JC 0x3000:587c (334B_23B4 / 0x35864)
    if(CarryFlag) {
      goto label_334B_23CC_3587C;
    }
    State.IncCycles();
    // PUSH DX (334B_23B6 / 0x35866)
    Stack.Push(DX);
    State.IncCycles();
    // XCHG DX,CX (334B_23B7 / 0x35867)
    ushort tmp_334B_23B7 = DX;
    DX = CX;
    CX = tmp_334B_23B7;
    State.IncCycles();
    // SUB CX,0x4 (334B_23B9 / 0x35869)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    State.IncCycles();
    // JC 0x3000:5874 (334B_23BC / 0x3586C)
    if(CarryFlag) {
      goto label_334B_23C4_35874;
    }
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_23BE / 0x3586E)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV AX,0x191c (334B_23C0 / 0x35870)
    AX = 0x191C;
    State.IncCycles();
    // STOSW ES:DI (334B_23C3 / 0x35873)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    label_334B_23C4_35874:
    // MOV AX,0x1718 (334B_23C4 / 0x35874)
    AX = 0x1718;
    State.IncCycles();
    // STOSW ES:DI (334B_23C7 / 0x35877)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV CX,DX (334B_23C8 / 0x35878)
    CX = DX;
    State.IncCycles();
    // POP DX (334B_23CA / 0x3587A)
    DX = Stack.Pop();
    State.IncCycles();
    label_334B_23CB_3587B:
    // RET  (334B_23CB / 0x3587B)
    return NearRet();
    State.IncCycles();
    label_334B_23CC_3587C:
    // ADD CX,DX (334B_23CC / 0x3587C)
    CX += DX;
    State.IncCycles();
    // ADD CX,DX (334B_23CE / 0x3587E)
    // CX += DX;
    CX = Alu.Add16(CX, DX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_23D0 / 0x35880)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // XOR CX,CX (334B_23D2 / 0x35882)
    CX = 0;
    State.IncCycles();
    // XOR DX,DX (334B_23D4 / 0x35884)
    DX = 0;
    State.IncCycles();
    // RET  (334B_23D6 / 0x35886)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_23D7_035887(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_23D7_35887:
    // JCXZ 0x3000:589a (334B_23D7 / 0x35887)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (334B_23EA / 0x3589A)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x1817 (334B_23D9 / 0x35889)
    AX = 0x1817;
    State.IncCycles();
    // STOSW ES:DI (334B_23DC / 0x3588C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // SUB CX,0x4 (334B_23DD / 0x3588D)
    // CX -= 0x4;
    CX = Alu.Sub16(CX, 0x4);
    State.IncCycles();
    // JC 0x3000:589a (334B_23E0 / 0x35890)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (334B_23EA / 0x3589A)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x1c19 (334B_23E2 / 0x35892)
    AX = 0x1C19;
    State.IncCycles();
    // STOSW ES:DI (334B_23E5 / 0x35895)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // XOR AL,AL (334B_23E6 / 0x35896)
    AL = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (334B_23E8 / 0x35898)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    label_334B_23EA_3589A:
    // RET  (334B_23EA / 0x3589A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_23EB_03589B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_23EB_3589B:
    // PUSH DI (334B_23EB / 0x3589B)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,CX (334B_23EC / 0x3589C)
    DI = CX;
    State.IncCycles();
    // DEC DI (334B_23EE / 0x3589E)
    DI--;
    State.IncCycles();
    // ADD BX,DI (334B_23EF / 0x3589F)
    BX += DI;
    State.IncCycles();
    // ADD AX,DI (334B_23F1 / 0x358A1)
    // AX += DI;
    AX = Alu.Add16(AX, DI);
    State.IncCycles();
    // PUSH AX (334B_23F3 / 0x358A3)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DX (334B_23F4 / 0x358A4)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,0xc8 (334B_23F5 / 0x358A5)
    AX = 0xC8;
    State.IncCycles();
    // MUL DI (334B_23F8 / 0x358A8)
    Cpu.Mul16(DI);
    State.IncCycles();
    // ADD SI,AX (334B_23FA / 0x358AA)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // POP DX (334B_23FC / 0x358AC)
    DX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_23FD / 0x358AD)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_23FE / 0x358AE)
    NearCall(cs2, 0x2401, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2401_0358B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2401_0358B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2401_358B1:
    // POP DX (334B_2401 / 0x358B1)
    DX = Stack.Pop();
    State.IncCycles();
    // XCHG DX,CX (334B_2402 / 0x358B2)
    ushort tmp_334B_2402 = DX;
    DX = CX;
    CX = tmp_334B_2402;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2404_0358B4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2404_0358B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2404_358B4:
    // CALL 0x3000:58c3 (334B_2404 / 0x358B4)
    NearCall(cs2, 0x2407, spice86_generated_label_call_target_334B_2413_0358C3);
    State.IncCycles();
    label_334B_2407_358B7:
    // SUB SI,0xc8 (334B_2407 / 0x358B7)
    SI -= 0xC8;
    State.IncCycles();
    // SUB DI,0x140 (334B_240B / 0x358BB)
    DI -= 0x140;
    State.IncCycles();
    // DEC DX (334B_240F / 0x358BF)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:58b4 (334B_2410 / 0x358C0)
    if(!ZeroFlag) {
      goto label_334B_2404_358B4;
    }
    State.IncCycles();
    // RETF  (334B_2412 / 0x358C2)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2413_0358C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2413_358C3:
    // PUSH AX (334B_2413 / 0x358C3)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (334B_2414 / 0x358C4)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_2415 / 0x358C5)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_2416 / 0x358C6)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_2417 / 0x358C7)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:5846 (334B_2418 / 0x358C8)
    NearCall(cs2, 0x241B, spice86_generated_label_call_target_334B_2396_035846);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_241B_0358CB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_241B_0358CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_241B_358CB:
    // PUSH DX (334B_241B / 0x358CB)
    Stack.Push(DX);
    State.IncCycles();
    // MOV BP,0xf0f (334B_241C / 0x358CC)
    BP = 0xF0F;
    State.IncCycles();
    // MOV DX,0x1010 (334B_241F / 0x358CF)
    DX = 0x1010;
    State.IncCycles();
    // SHR CX,1 (334B_2422 / 0x358D2)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // JNC 0x3000:58dc (334B_2424 / 0x358D4)
    if(!CarryFlag) {
      goto label_334B_242C_358DC;
    }
    State.IncCycles();
    // LODSB SI (334B_2426 / 0x358D6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // AND AX,BP (334B_2427 / 0x358D7)
    AX &= BP;
    State.IncCycles();
    // ADD AL,DL (334B_2429 / 0x358D9)
    // AL += DL;
    AL = Alu.Add8(AL, DL);
    State.IncCycles();
    // STOSB ES:DI (334B_242B / 0x358DB)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_334B_242C_358DC:
    // JCXZ 0x3000:58e6 (334B_242C / 0x358DC)
    if(CX == 0) {
      goto label_334B_2436_358E6;
    }
    State.IncCycles();
    label_334B_242E_358DE:
    // LODSW SI (334B_242E / 0x358DE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // AND AX,BP (334B_242F / 0x358DF)
    AX &= BP;
    State.IncCycles();
    // ADD AX,DX (334B_2431 / 0x358E1)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // STOSW ES:DI (334B_2433 / 0x358E3)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LOOP 0x3000:58de (334B_2434 / 0x358E4)
    if(--CX != 0) {
      goto label_334B_242E_358DE;
    }
    State.IncCycles();
    label_334B_2436_358E6:
    // POP CX (334B_2436 / 0x358E6)
    CX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:5887 (334B_2437 / 0x358E7)
    NearCall(cs2, 0x243A, spice86_generated_label_call_target_334B_23D7_035887);
    State.IncCycles();
    label_334B_243A_358EA:
    // POP DI (334B_243A / 0x358EA)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_243B / 0x358EB)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_243C / 0x358EC)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_243D / 0x358ED)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_243E / 0x358EE)
    AX = Stack.Pop();
    State.IncCycles();
    // DEC AX (334B_243F / 0x358EF)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // RET  (334B_2440 / 0x358F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_253D_0359ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_253D_359ED:
    // CMP byte ptr CS:[0x1a1],0x0 (334B_253D / 0x359ED)
    Alu.Sub8(UInt8[cs2, 0x1A1], 0x0);
    State.IncCycles();
    // JZ 0x3000:5a14 (334B_2543 / 0x359F3)
    if(ZeroFlag) {
      goto label_334B_2564_35A14;
    }
    State.IncCycles();
    label_334B_2545_359F5:
    // MOV AX,word ptr [BP + 0x0] (334B_2545 / 0x359F5)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,BX (334B_2548 / 0x359F8)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x5 (334B_254A / 0x359FA)
    Alu.Sub16(AX, 0x5);
    State.IncCycles();
    // JC 0x3000:59f5 (334B_254D / 0x359FD)
    if(CarryFlag) {
      goto label_334B_2545_359F5;
    }
    State.IncCycles();
    label_334B_254F_359FF:
    // PUSH DX (334B_254F / 0x359FF)
    Stack.Push(DX);
    State.IncCycles();
    // MOV DX,word ptr CS:[0x19f] (334B_2550 / 0x35A00)
    DX = UInt16[cs2, 0x19F];
    State.IncCycles();
    label_334B_2555_35A05:
    // IN AL,DX (334B_2555 / 0x35A05)
    AL = Cpu.In8(DX);
    State.IncCycles();
    // AND AL,0x8 (334B_2556 / 0x35A06)
    AL &= 0x8;
    State.IncCycles();
    // CMP AL,byte ptr CS:[0x1a2] (334B_2558 / 0x35A08)
    Alu.Sub8(AL, UInt8[cs2, 0x1A2]);
    State.IncCycles();
    // JNZ 0x3000:5a05 (334B_255D / 0x35A0D)
    if(!ZeroFlag) {
      goto label_334B_2555_35A05;
    }
    State.IncCycles();
    // POP DX (334B_255F / 0x35A0F)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_2560 / 0x35A10)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // RET  (334B_2563 / 0x35A13)
    return NearRet();
    State.IncCycles();
    label_334B_2564_35A14:
    // MOV AX,word ptr [BP + 0x0] (334B_2564 / 0x35A14)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,BX (334B_2567 / 0x35A17)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x6 (334B_2569 / 0x35A19)
    Alu.Sub16(AX, 0x6);
    State.IncCycles();
    // JC 0x3000:5a14 (334B_256C / 0x35A1C)
    if(CarryFlag) {
      goto label_334B_2564_35A14;
    }
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_256E / 0x35A1E)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // RET  (334B_2571 / 0x35A21)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2572_035A22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2572_35A22:
    // CMP byte ptr CS:[0x1a1],0x0 (334B_2572 / 0x35A22)
    Alu.Sub8(UInt8[cs2, 0x1A1], 0x0);
    State.IncCycles();
    // JNZ 0x3000:59ff (334B_2578 / 0x35A28)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_253D_0359ED, 0x359FF - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_334B_257A_35A2A:
    // MOV AX,word ptr [BP + 0x0] (334B_257A / 0x35A2A)
    AX = UInt16[SS, BP];
    State.IncCycles();
    // SUB AX,BX (334B_257D / 0x35A2D)
    AX -= BX;
    State.IncCycles();
    // CMP AX,0x3 (334B_257F / 0x35A2F)
    Alu.Sub16(AX, 0x3);
    State.IncCycles();
    // JC 0x3000:5a2a (334B_2582 / 0x35A32)
    if(CarryFlag) {
      goto label_334B_257A_35A2A;
    }
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_2584 / 0x35A34)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // RET  (334B_2587 / 0x35A37)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2596_035A46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2596_35A46:
    // PUSH DS (334B_2596 / 0x35A46)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_2597 / 0x35A47)
    Stack.Push(ES);
    State.IncCycles();
    // MOV DS,word ptr CS:[0x2539] (334B_2598 / 0x35A48)
    DS = UInt16[cs2, 0x2539];
    State.IncCycles();
    // MOV ES,word ptr CS:[0x2535] (334B_259D / 0x35A4D)
    ES = UInt16[cs2, 0x2535];
    State.IncCycles();
    // PUSH CS (334B_25A2 / 0x35A52)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:502c (334B_25A3 / 0x35A53)
    NearCall(cs2, 0x25A6, spice86_generated_label_call_target_334B_1B7C_03502C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_25A6_035A56, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_25A6_035A56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_25A6_35A56:
    // POP ES (334B_25A6 / 0x35A56)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_25A7 / 0x35A57)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (334B_25A8 / 0x35A58)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_25E7_035A97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_25E7_35A97:
    // MOV word ptr CS:[0x2768],0x8 (334B_25E7 / 0x35A97)
    UInt16[cs2, 0x2768] = 0x8;
    State.IncCycles();
    // MOV word ptr CS:[0x276a],0x1 (334B_25EE / 0x35A9E)
    UInt16[cs2, 0x276A] = 0x1;
    State.IncCycles();
    // MOV word ptr CS:[0x2535],SI (334B_25F5 / 0x35AA5)
    UInt16[cs2, 0x2535] = SI;
    State.IncCycles();
    // MOV word ptr CS:[0x2537],DS (334B_25FA / 0x35AAA)
    UInt16[cs2, 0x2537] = DS;
    State.IncCycles();
    // MOV word ptr CS:[0x2539],ES (334B_25FF / 0x35AAF)
    UInt16[cs2, 0x2539] = ES;
    State.IncCycles();
    // MOV CX,0x98 (334B_2604 / 0x35AB4)
    CX = 0x98;
    State.IncCycles();
    // AND AX,0xfe (334B_2607 / 0x35AB7)
    AX &= 0xFE;
    State.IncCycles();
    label_334B_260A_35ABA:
    // CMP AX,0x3e (334B_260A / 0x35ABA)
    Alu.Sub16(AX, 0x3E);
    State.IncCycles();
    // JC 0x3000:5ac4 (334B_260D / 0x35ABD)
    if(CarryFlag) {
      goto label_334B_2614_35AC4;
    }
    State.IncCycles();
    // SUB AX,0x3e (334B_260F / 0x35ABF)
    // AX -= 0x3E;
    AX = Alu.Sub16(AX, 0x3E);
    State.IncCycles();
    // JMP 0x3000:5aba (334B_2612 / 0x35AC2)
    goto label_334B_260A_35ABA;
    State.IncCycles();
    label_334B_2614_35AC4:
    // MOV BX,AX (334B_2614 / 0x35AC4)
    BX = AX;
    State.IncCycles();
    // JMP word ptr CS:[BX + 0x25a9] (334B_2616 / 0x35AC6)
    // Indirect jump to word ptr CS:[BX + 0x25a9], generating possible targets from emulator records
    uint targetAddress_334B_2616 = (uint)(cs2 * 0x10 + UInt16[cs2, (ushort)(BX + 0x25A9)] - cs1 * 0x10);
    switch(targetAddress_334B_2616) {
      case 0x25BDE : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_272E_035BDE, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26270 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2DC0_036270, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x25C07 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2757_035C07, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26273 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2DC3_036273, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x265E0 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3130_0365E0, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x25F81 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2AD1_035F81, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x2617A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2CCA_03617A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x25F18 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2A68_035F18, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_2616));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_call_target_334B_261D_035ACD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_261D_35ACD:
    // CMP byte ptr [0x1a1],0x0 (334B_261D / 0x35ACD)
    Alu.Sub8(UInt8[DS, 0x1A1], 0x0);
    State.IncCycles();
    // JNZ 0x3000:5ad7 (334B_2622 / 0x35AD2)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (334B_2627 / 0x35AD7)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x3000:5a22 (334B_2624 / 0x35AD4)
    NearCall(cs2, 0x2627, spice86_generated_label_call_target_334B_2572_035A22);
    State.IncCycles();
    label_334B_2627_35AD7:
    // RET  (334B_2627 / 0x35AD7)
    return NearRet();
  }
  
  public virtual Action split_334B_264D_035AFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_264D_35AFD:
    // MOV DS,word ptr CS:[0x2537] (334B_264D / 0x35AFD)
    DS = UInt16[cs2, 0x2537];
    State.IncCycles();
    // MOV ES,word ptr CS:[0x2539] (334B_2652 / 0x35B02)
    ES = UInt16[cs2, 0x2539];
    State.IncCycles();
    // PUSH CS (334B_2657 / 0x35B07)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:502c (334B_2658 / 0x35B08)
    NearCall(cs2, 0x265B, spice86_generated_label_call_target_334B_1B7C_03502C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_265B_035B0B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_265B_035B0B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25B11: goto label_334B_2661_35B11;break; // Target of external jump from 0x35B59
      case 0x25B0F: goto label_334B_265F_35B0F;break; // Target of external jump from 0x35B5D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_265B_35B0B:
    // PUSH CS (334B_265B / 0x35B0B)
    Stack.Push(cs2);
    State.IncCycles();
    // PUSH CS (334B_265C / 0x35B0C)
    Stack.Push(cs2);
    State.IncCycles();
    // POP DS (334B_265D / 0x35B0D)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (334B_265E / 0x35B0E)
    ES = Stack.Pop();
    State.IncCycles();
    label_334B_265F_35B0F:
    // XOR BX,BX (334B_265F / 0x35B0F)
    BX = 0;
    State.IncCycles();
    label_334B_2661_35B11:
    // PUSH BX (334B_2661 / 0x35B11)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_2662 / 0x35B12)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_2663 / 0x35B13)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_2664 / 0x35B14)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // MOV DI,0x5bf (334B_2667 / 0x35B17)
    DI = 0x5BF;
    State.IncCycles();
    // ADD DI,BX (334B_266A / 0x35B1A)
    // DI += BX;
    DI = Alu.Add16(DI, BX);
    State.IncCycles();
    // LEA SI,[DI + 0xfd00] (334B_266C / 0x35B1C)
    SI = (ushort)(DI + 0xFD00);
    State.IncCycles();
    // PUSH BX (334B_2670 / 0x35B20)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_2671 / 0x35B21)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (334B_2672 / 0x35B22)
    Stack.Push(DI);
    State.IncCycles();
    label_334B_2673_35B23:
    // LODSB SI (334B_2673 / 0x35B23)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SUB AL,byte ptr [DI] (334B_2674 / 0x35B24)
    // AL -= UInt8[DS, DI];
    AL = Alu.Sub8(AL, UInt8[DS, DI]);
    State.IncCycles();
    // JZ 0x3000:5b40 (334B_2676 / 0x35B26)
    if(ZeroFlag) {
      goto label_334B_2690_35B40;
    }
    State.IncCycles();
    // MOV BL,AL (334B_2678 / 0x35B28)
    BL = AL;
    State.IncCycles();
    // XOR AH,AH (334B_267A / 0x35B2A)
    AH = 0;
    State.IncCycles();
    // DIV DH (334B_267C / 0x35B2C)
    Cpu.Div8(DH);
    State.IncCycles();
    // XCHG AH,AL (334B_267E / 0x35B2E)
    byte tmp_334B_267E = AH;
    AH = AL;
    AL = tmp_334B_267E;
    State.IncCycles();
    // INC AH (334B_2680 / 0x35B30)
    AH = Alu.Inc8(AH);
    State.IncCycles();
    // OR AL,AL (334B_2682 / 0x35B32)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x3000:5b3a (334B_2684 / 0x35B34)
    if(!ZeroFlag) {
      goto label_334B_268A_35B3A;
    }
    State.IncCycles();
    // DEC AH (334B_2686 / 0x35B36)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // MOV AL,DH (334B_2688 / 0x35B38)
    AL = DH;
    State.IncCycles();
    label_334B_268A_35B3A:
    // CMP AH,DL (334B_268A / 0x35B3A)
    Alu.Sub8(AH, DL);
    State.IncCycles();
    // JC 0x3000:5b40 (334B_268C / 0x35B3C)
    if(CarryFlag) {
      goto label_334B_2690_35B40;
    }
    State.IncCycles();
    // ADD byte ptr [DI],AL (334B_268E / 0x35B3E)
    UInt8[DS, DI] += AL;
    State.IncCycles();
    label_334B_2690_35B40:
    // INC DI (334B_2690 / 0x35B40)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x3000:5b23 (334B_2691 / 0x35B41)
    if(--CX != 0) {
      goto label_334B_2673_35B23;
    }
    State.IncCycles();
    // POP DX (334B_2693 / 0x35B43)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_2694 / 0x35B44)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_2695 / 0x35B45)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:3ed1 (334B_2696 / 0x35B46)
    NearCall(cs2, 0x2699, spice86_generated_label_call_target_334B_0A21_033ED1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2699_035B49, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2699_035B49(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2699_35B49:
    // CALL 0x3000:4018 (334B_2699 / 0x35B49)
    NearCall(cs2, 0x269C, spice86_generated_label_call_target_334B_0B68_034018);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_269C_035B4C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_269C_035B4C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_269C_35B4C:
    // POP BX (334B_269C / 0x35B4C)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:5acd (334B_269D / 0x35B4D)
    NearCall(cs2, 0x26A0, spice86_generated_label_call_target_334B_261D_035ACD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_26A0_035B50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_26A0_035B50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_26A0_35B50:
    // POP DX (334B_26A0 / 0x35B50)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_26A1 / 0x35B51)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_26A2 / 0x35B52)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD BX,CX (334B_26A3 / 0x35B53)
    BX += CX;
    State.IncCycles();
    // CMP BX,0x2fd (334B_26A5 / 0x35B55)
    Alu.Sub16(BX, 0x2FD);
    State.IncCycles();
    // JC 0x3000:5b11 (334B_26A9 / 0x35B59)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_265B_035B0B, 0x35B11 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC DL (334B_26AB / 0x35B5B)
    DL = Alu.Dec8(DL);
    State.IncCycles();
    // JNZ 0x3000:5b0f (334B_26AD / 0x35B5D)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_265B_035B0B, 0x35B0F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RETF  (334B_26AF / 0x35B5F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_26E3_035B93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_26E3_35B93:
    // MOV CS:[0x261b],AX (334B_26E3 / 0x35B93)
    UInt16[cs2, 0x261B] = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_26E7_035B97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_26E7_035B97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_26E7_35B97:
    // XOR BX,BX (334B_26E7 / 0x35B97)
    BX = 0;
    State.IncCycles();
    label_334B_26E9_35B99:
    // PUSH BX (334B_26E9 / 0x35B99)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (334B_26EA / 0x35B9A)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_26EB / 0x35B9B)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // MOV SI,0x5bf (334B_26EE / 0x35B9E)
    SI = 0x5BF;
    State.IncCycles();
    // ADD SI,BX (334B_26F1 / 0x35BA1)
    SI += BX;
    State.IncCycles();
    // ADD SI,BX (334B_26F3 / 0x35BA3)
    SI += BX;
    State.IncCycles();
    // ADD SI,BX (334B_26F5 / 0x35BA5)
    // SI += BX;
    SI = Alu.Add16(SI, BX);
    State.IncCycles();
    // MOV DI,SI (334B_26F7 / 0x35BA7)
    DI = SI;
    State.IncCycles();
    // MOV AX,CS:[0x261b] (334B_26F9 / 0x35BA9)
    AX = UInt16[cs2, 0x261B];
    State.IncCycles();
    // PUSH AX (334B_26FD / 0x35BAD)
    Stack.Push(AX);
    State.IncCycles();
    // MOV CX,AX (334B_26FE / 0x35BAE)
    CX = AX;
    State.IncCycles();
    // ADD CX,CX (334B_2700 / 0x35BB0)
    CX += CX;
    State.IncCycles();
    // ADD CX,AX (334B_2702 / 0x35BB2)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    label_334B_2704_35BB4:
    // MOV AL,byte ptr [SI] (334B_2704 / 0x35BB4)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // SUB AL,DH (334B_2706 / 0x35BB6)
    // AL -= DH;
    AL = Alu.Sub8(AL, DH);
    State.IncCycles();
    // JNS 0x3000:5bbc (334B_2708 / 0x35BB8)
    if(!SignFlag) {
      goto label_334B_270C_35BBC;
    }
    State.IncCycles();
    // XOR AL,AL (334B_270A / 0x35BBA)
    AL = 0;
    State.IncCycles();
    label_334B_270C_35BBC:
    // MOV byte ptr [SI],AL (334B_270C / 0x35BBC)
    UInt8[DS, SI] = AL;
    State.IncCycles();
    // INC SI (334B_270E / 0x35BBE)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // LOOP 0x3000:5bb4 (334B_270F / 0x35BBF)
    if(--CX != 0) {
      goto label_334B_2704_35BB4;
    }
    State.IncCycles();
    // POP CX (334B_2711 / 0x35BC1)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV DX,DI (334B_2712 / 0x35BC2)
    DX = DI;
    State.IncCycles();
    // CALL 0x3000:4018 (334B_2714 / 0x35BC4)
    NearCall(cs2, 0x2717, spice86_generated_label_call_target_334B_0B68_034018);
    State.IncCycles();
    label_334B_2717_35BC7:
    // POP BX (334B_2717 / 0x35BC7)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:5acd (334B_2718 / 0x35BC8)
    NearCall(cs2, 0x271B, spice86_generated_label_call_target_334B_261D_035ACD);
    State.IncCycles();
    label_334B_271B_35BCB:
    // POP DX (334B_271B / 0x35BCB)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_271C / 0x35BCC)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV AX,CS:[0x261b] (334B_271D / 0x35BCD)
    AX = UInt16[cs2, 0x261B];
    State.IncCycles();
    // ADD BX,AX (334B_2721 / 0x35BD1)
    BX += AX;
    State.IncCycles();
    // CMP BX,0xff (334B_2723 / 0x35BD3)
    Alu.Sub16(BX, 0xFF);
    State.IncCycles();
    // JC 0x3000:5b99 (334B_2727 / 0x35BD7)
    if(CarryFlag) {
      goto label_334B_26E9_35B99;
    }
    State.IncCycles();
    // DEC DL (334B_2729 / 0x35BD9)
    DL = Alu.Dec8(DL);
    State.IncCycles();
    // JNZ 0x3000:5b97 (334B_272B / 0x35BDB)
    if(!ZeroFlag) {
      goto label_334B_26E7_35B97;
    }
    State.IncCycles();
    // RET  (334B_272D / 0x35BDD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_272E_035BDE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_272E_35BDE:
    // PUSH CS (334B_272E / 0x35BDE)
    Stack.Push(cs2);
    State.IncCycles();
    // PUSH CS (334B_272F / 0x35BDF)
    Stack.Push(cs2);
    State.IncCycles();
    // POP DS (334B_2730 / 0x35BE0)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (334B_2731 / 0x35BE1)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x5c2 (334B_2732 / 0x35BE2)
    SI = 0x5C2;
    State.IncCycles();
    // MOV DI,0x2c2 (334B_2735 / 0x35BE5)
    DI = 0x2C2;
    State.IncCycles();
    // MOV CX,0x17d (334B_2738 / 0x35BE8)
    CX = 0x17D;
    State.IncCycles();
    label_334B_273B_35BEB:
    // MOV AX,word ptr [DI] (334B_273B / 0x35BEB)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // XCHG word ptr [SI],AX (334B_273D / 0x35BED)
    ushort tmp_334B_273D = UInt16[DS, SI];
    UInt16[DS, SI] = AX;
    AX = tmp_334B_273D;
    State.IncCycles();
    // STOSW ES:DI (334B_273F / 0x35BEF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD SI,0x2 (334B_2740 / 0x35BF0)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // LOOP 0x3000:5beb (334B_2743 / 0x35BF3)
    if(--CX != 0) {
      goto label_334B_273B_35BEB;
    }
    State.IncCycles();
    // MOV AX,0x55 (334B_2745 / 0x35BF5)
    AX = 0x55;
    State.IncCycles();
    // MOV DX,0x316 (334B_2748 / 0x35BF8)
    DX = 0x316;
    State.IncCycles();
    // CALL 0x3000:5b93 (334B_274B / 0x35BFB)
    NearCall(cs2, 0x274E, spice86_generated_label_call_target_334B_26E3_035B93);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_274E_035BFE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_274E_035BFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_274E_35BFE:
    // MOV CX,0xff (334B_274E / 0x35BFE)
    CX = 0xFF;
    State.IncCycles();
    // MOV DX,0x316 (334B_2751 / 0x35C01)
    DX = 0x316;
    State.IncCycles();
    // JMP 0x3000:5afd (334B_2754 / 0x35C04)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_334B_264D_035AFD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2757_035C07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2757_35C07:
    // PUSH CS (334B_2757 / 0x35C07)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:3fbc (334B_2758 / 0x35C08)
    NearCall(cs2, 0x275B, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_275B_035C0B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_275B_035C0B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_275B_35C0B:
    // MOV DI,word ptr CS:[0x1a3] (334B_275B / 0x35C0B)
    DI = UInt16[cs2, 0x1A3];
    State.IncCycles();
    // MOV SI,DI (334B_2760 / 0x35C10)
    SI = DI;
    State.IncCycles();
    // MOV CX,0x5f00 (334B_2762 / 0x35C12)
    CX = 0x5F00;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2765 / 0x35C15)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // RETF  (334B_2767 / 0x35C17)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2A68_035F18(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2A68_35F18:
    // MOV BX,0x4a (334B_2A68 / 0x35F18)
    BX = 0x4A;
    State.IncCycles();
    // MOV DX,0x9c (334B_2A6B / 0x35F1B)
    DX = 0x9C;
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_2A6E / 0x35F1E)
    NearCall(cs2, 0x2A71, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A71_035F21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A71_035F21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2A71_35F21:
    // MOV DX,0x1 (334B_2A71 / 0x35F21)
    DX = 0x1;
    State.IncCycles();
    // MOV AX,0xfb08 (334B_2A74 / 0x35F24)
    AX = 0xFB08;
    State.IncCycles();
    // CALL 0x3000:5f60 (334B_2A77 / 0x35F27)
    NearCall(cs2, 0x2A7A, spice86_generated_label_call_target_334B_2AB0_035F60);
    State.IncCycles();
    label_334B_2A7A_35F2A:
    // INC DX (334B_2A7A / 0x35F2A)
    DX++;
    State.IncCycles();
    // XOR AX,AX (334B_2A7B / 0x35F2B)
    AX = 0;
    State.IncCycles();
    // CALL 0x3000:5f60 (334B_2A7D / 0x35F2D)
    NearCall(cs2, 0x2A80, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A80_035F30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A80_035F30(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25F33: goto label_334B_2A83_35F33;break; // Target of external jump from 0x35F5D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_2A80_35F30:
    // MOV DX,0x2 (334B_2A80 / 0x35F30)
    DX = 0x2;
    State.IncCycles();
    label_334B_2A83_35F33:
    // MOV AX,0xfaf8 (334B_2A83 / 0x35F33)
    AX = 0xFAF8;
    State.IncCycles();
    // ADD DI,AX (334B_2A86 / 0x35F36)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // CALL 0x3000:5f60 (334B_2A88 / 0x35F38)
    NearCall(cs2, 0x2A8B, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A8B_035F3B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A8B_035F3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2A8B_35F3B:
    // SUB DI,0x4f8 (334B_2A8B / 0x35F3B)
    // DI -= 0x4F8;
    DI = Alu.Sub16(DI, 0x4F8);
    State.IncCycles();
    // MOV AX,0xf600 (334B_2A8F / 0x35F3F)
    AX = 0xF600;
    State.IncCycles();
    // CALL 0x3000:5f60 (334B_2A92 / 0x35F42)
    NearCall(cs2, 0x2A95, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A95_035F45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2A95_035F45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2A95_35F45:
    // ADD DI,0x508 (334B_2A95 / 0x35F45)
    DI += 0x508;
    State.IncCycles();
    // INC DX (334B_2A99 / 0x35F49)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // MOV AX,0xfb08 (334B_2A9A / 0x35F4A)
    AX = 0xFB08;
    State.IncCycles();
    // CALL 0x3000:5f60 (334B_2A9D / 0x35F4D)
    NearCall(cs2, 0x2AA0, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AA0_035F50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AA0_035F50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2AA0_35F50:
    // ADD DI,0x4f8 (334B_2AA0 / 0x35F50)
    DI += 0x4F8;
    State.IncCycles();
    // XOR AX,AX (334B_2AA4 / 0x35F54)
    AX = 0;
    State.IncCycles();
    // CALL 0x3000:5f60 (334B_2AA6 / 0x35F56)
    NearCall(cs2, 0x2AA9, spice86_generated_label_call_target_334B_2AB0_035F60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AA9_035F59, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AA9_035F59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2AA9_35F59:
    // INC DX (334B_2AA9 / 0x35F59)
    DX++;
    State.IncCycles();
    // CMP DX,0x26 (334B_2AAA / 0x35F5A)
    Alu.Sub16(DX, 0x26);
    State.IncCycles();
    // JC 0x3000:5f33 (334B_2AAD / 0x35F5D)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2A80_035F30, 0x35F33 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RETF  (334B_2AAF / 0x35F5F)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2AB0_035F60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2AB0_35F60:
    // PUSH word ptr [BP + 0x0] (334B_2AB0 / 0x35F60)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // MOV BX,DX (334B_2AB3 / 0x35F63)
    BX = DX;
    State.IncCycles();
    label_334B_2AB5_35F65:
    // MOV CX,0x4 (334B_2AB5 / 0x35F65)
    CX = 0x4;
    State.IncCycles();
    label_334B_2AB8_35F68:
    // MOV SI,DI (334B_2AB8 / 0x35F68)
    SI = DI;
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2ABA / 0x35F6A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2ABB / 0x35F6B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2ABC / 0x35F6C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2ABD / 0x35F6D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0x138 (334B_2ABE / 0x35F6E)
    // DI += 0x138;
    DI = Alu.Add16(DI, 0x138);
    State.IncCycles();
    // LOOP 0x3000:5f68 (334B_2AC2 / 0x35F72)
    if(--CX != 0) {
      goto label_334B_2AB8_35F68;
    }
    State.IncCycles();
    // ADD DI,AX (334B_2AC4 / 0x35F74)
    DI += AX;
    State.IncCycles();
    // DEC BX (334B_2AC6 / 0x35F76)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:5f65 (334B_2AC7 / 0x35F77)
    if(!ZeroFlag) {
      goto label_334B_2AB5_35F65;
    }
    State.IncCycles();
    // POP AX (334B_2AC9 / 0x35F79)
    AX = Stack.Pop();
    State.IncCycles();
    label_334B_2ACA_35F7A:
    // CMP AX,word ptr [BP + 0x0] (334B_2ACA / 0x35F7A)
    Alu.Sub16(AX, UInt16[SS, BP]);
    State.IncCycles();
    // JZ 0x3000:5f7a (334B_2ACD / 0x35F7D)
    if(ZeroFlag) {
      goto label_334B_2ACA_35F7A;
    }
    State.IncCycles();
    // RET  (334B_2ACF / 0x35F7F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2AD1_035F81(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2AD1_35F81:
    // PUSH CS (334B_2AD1 / 0x35F81)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:3fbc (334B_2AD2 / 0x35F82)
    NearCall(cs2, 0x2AD5, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AD5_035F85, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AD5_035F85(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2AD5_35F85:
    // OR DX,DX (334B_2AD5 / 0x35F85)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JS 0x3000:5fca (334B_2AD7 / 0x35F87)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_2B1A_035FCA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH CX (334B_2AD9 / 0x35F89)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DS (334B_2ADA / 0x35F8A)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,word ptr CS:[0x2539] (334B_2ADB / 0x35F8B)
    DS = UInt16[cs2, 0x2539];
    State.IncCycles();
    // CALL 0x3000:6102 (334B_2AE0 / 0x35F90)
    NearCall(cs2, 0x2AE3, spice86_generated_label_call_target_334B_2C52_036102);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AE3_035F93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2AE3_035F93(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25F97: goto label_334B_2AE7_35F97;break; // Target of external jump from 0x35FC7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_2AE3_35F93:
    // POP DS (334B_2AE3 / 0x35F93)
    DS = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_2AE4 / 0x35F94)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV BX,CX (334B_2AE5 / 0x35F95)
    BX = CX;
    State.IncCycles();
    label_334B_2AE7_35F97:
    // MOV DX,0x140 (334B_2AE7 / 0x35F97)
    DX = 0x140;
    State.IncCycles();
    // SUB BX,0x8 (334B_2AEA / 0x35F9A)
    // BX -= 0x8;
    BX = Alu.Sub16(BX, 0x8);
    State.IncCycles();
    // PUSH BX (334B_2AED / 0x35F9D)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_2AEE / 0x35F9E)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // JNS 0x3000:5fa7 (334B_2AF1 / 0x35FA1)
    if(!SignFlag) {
      goto label_334B_2AF7_35FA7;
    }
    State.IncCycles();
    // ADD DX,BX (334B_2AF3 / 0x35FA3)
    DX += BX;
    State.IncCycles();
    // XOR BX,BX (334B_2AF5 / 0x35FA5)
    BX = 0;
    State.IncCycles();
    label_334B_2AF7_35FA7:
    // MOV AX,word ptr [BP + 0x0] (334B_2AF7 / 0x35FA7)
    AX = UInt16[SS, BP];
    State.IncCycles();
    label_334B_2AFA_35FAA:
    // CMP AX,word ptr [BP + 0x0] (334B_2AFA / 0x35FAA)
    Alu.Sub16(AX, UInt16[SS, BP]);
    State.IncCycles();
    // JZ 0x3000:5faa (334B_2AFD / 0x35FAD)
    if(ZeroFlag) {
      goto label_334B_2AFA_35FAA;
    }
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_2AFF / 0x35FAF)
    NearCall(cs2, 0x2B02, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B02_035FB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B02_035FB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B02_35FB2:
    // PUSH BX (334B_2B02 / 0x35FB2)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (334B_2B03 / 0x35FB3)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (334B_2B04 / 0x35FB4)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:605c (334B_2B05 / 0x35FB5)
    NearCall(cs2, 0x2B08, spice86_generated_label_call_target_334B_2BAC_03605C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B08_035FB8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B08_035FB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B08_35FB8:
    // POP DI (334B_2B08 / 0x35FB8)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_2B09 / 0x35FB9)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_2B0A / 0x35FBA)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:6006 (334B_2B0B / 0x35FBB)
    NearCall(cs2, 0x2B0E, spice86_generated_label_call_target_334B_2B56_036006);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B0E_035FBE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B0E_035FBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B0E_35FBE:
    // POP BX (334B_2B0E / 0x35FBE)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:5a22 (334B_2B0F / 0x35FBF)
    NearCall(cs2, 0x2B12, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B12_035FC2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B12_035FC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B12_35FC2:
    // POP BX (334B_2B12 / 0x35FC2)
    BX = Stack.Pop();
    State.IncCycles();
    // CMP BX,0xfec8 (334B_2B13 / 0x35FC3)
    Alu.Sub16(BX, 0xFEC8);
    State.IncCycles();
    // JG 0x3000:5f97 (334B_2B17 / 0x35FC7)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2AE3_035F93, 0x35F97 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RETF  (334B_2B19 / 0x35FC9)
    return FarRet();
  }
  
  public virtual Action split_334B_2B1A_035FCA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B1A_35FCA:
    // PUSH CX (334B_2B1A / 0x35FCA)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DS (334B_2B1B / 0x35FCB)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,word ptr CS:[0x2537] (334B_2B1C / 0x35FCC)
    DS = UInt16[cs2, 0x2537];
    State.IncCycles();
    // CALL 0x3000:6102 (334B_2B21 / 0x35FD1)
    NearCall(cs2, 0x2B24, spice86_generated_label_call_target_334B_2C52_036102);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B24_035FD4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B24_035FD4(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x25FD9: goto label_334B_2B29_35FD9;break; // Target of external jump from 0x36003
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_2B24_35FD4:
    // POP DS (334B_2B24 / 0x35FD4)
    DS = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_2B25 / 0x35FD5)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV BX,0xfec8 (334B_2B26 / 0x35FD6)
    BX = 0xFEC8;
    State.IncCycles();
    label_334B_2B29_35FD9:
    // MOV DX,0x140 (334B_2B29 / 0x35FD9)
    DX = 0x140;
    State.IncCycles();
    // PUSH BX (334B_2B2C / 0x35FDC)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_2B2D / 0x35FDD)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // OR BX,BX (334B_2B30 / 0x35FE0)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNS 0x3000:5fe8 (334B_2B32 / 0x35FE2)
    if(!SignFlag) {
      goto label_334B_2B38_35FE8;
    }
    State.IncCycles();
    // ADD DX,BX (334B_2B34 / 0x35FE4)
    DX += BX;
    State.IncCycles();
    // XOR BX,BX (334B_2B36 / 0x35FE6)
    BX = 0;
    State.IncCycles();
    label_334B_2B38_35FE8:
    // CALL 0x3000:40c0 (334B_2B38 / 0x35FE8)
    NearCall(cs2, 0x2B3B, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B3B_035FEB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B3B_035FEB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B3B_35FEB:
    // PUSH BX (334B_2B3B / 0x35FEB)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (334B_2B3C / 0x35FEC)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (334B_2B3D / 0x35FED)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x3000:60b2 (334B_2B3E / 0x35FEE)
    NearCall(cs2, 0x2B41, spice86_generated_label_call_target_334B_2C02_0360B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B41_035FF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B41_035FF1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B41_35FF1:
    // POP DI (334B_2B41 / 0x35FF1)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_2B42 / 0x35FF2)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_2B43 / 0x35FF3)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:6006 (334B_2B44 / 0x35FF4)
    NearCall(cs2, 0x2B47, spice86_generated_label_call_target_334B_2B56_036006);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B47_035FF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B47_035FF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B47_35FF7:
    // POP BX (334B_2B47 / 0x35FF7)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:5a22 (334B_2B48 / 0x35FF8)
    NearCall(cs2, 0x2B4B, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B4B_035FFB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2B4B_035FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B4B_35FFB:
    // POP BX (334B_2B4B / 0x35FFB)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD BX,0x8 (334B_2B4C / 0x35FFC)
    BX += 0x8;
    State.IncCycles();
    // CMP BX,0x98 (334B_2B4F / 0x35FFF)
    Alu.Sub16(BX, 0x98);
    State.IncCycles();
    // JL 0x3000:5fd9 (334B_2B53 / 0x36003)
    if(SignFlag != OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2B24_035FD4, 0x35FD9 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RETF  (334B_2B55 / 0x36005)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2B56_036006(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2B56_36006:
    // PUSH DX (334B_2B56 / 0x36006)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,0xc8 (334B_2B57 / 0x36007)
    AX = 0xC8;
    State.IncCycles();
    // NEG DX (334B_2B5A / 0x3600A)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // ADD DX,0x140 (334B_2B5C / 0x3600C)
    DX += 0x140;
    State.IncCycles();
    // INC DX (334B_2B60 / 0x36010)
    DX++;
    State.IncCycles();
    // MUL DX (334B_2B61 / 0x36011)
    Cpu.Mul16(DX);
    State.IncCycles();
    // MOV SI,AX (334B_2B63 / 0x36013)
    SI = AX;
    State.IncCycles();
    // MOV AX,0x98 (334B_2B65 / 0x36015)
    AX = 0x98;
    State.IncCycles();
    // SUB SI,AX (334B_2B68 / 0x36018)
    // SI -= AX;
    SI = Alu.Sub16(SI, AX);
    State.IncCycles();
    // POP DX (334B_2B6A / 0x3601A)
    DX = Stack.Pop();
    State.IncCycles();
    // CMP DX,AX (334B_2B6B / 0x3601B)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JNC 0x3000:6023 (334B_2B6D / 0x3601D)
    if(!CarryFlag) {
      goto label_334B_2B73_36023;
    }
    State.IncCycles();
    // ADD SI,AX (334B_2B6F / 0x3601F)
    SI += AX;
    State.IncCycles();
    // SUB SI,DX (334B_2B71 / 0x36021)
    SI -= DX;
    State.IncCycles();
    label_334B_2B73_36023:
    // SUB AX,BX (334B_2B73 / 0x36023)
    AX -= BX;
    State.IncCycles();
    // CMP AX,DX (334B_2B75 / 0x36025)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JC 0x3000:602b (334B_2B77 / 0x36027)
    if(CarryFlag) {
      goto label_334B_2B7B_3602B;
    }
    State.IncCycles();
    // MOV AX,DX (334B_2B79 / 0x36029)
    AX = DX;
    State.IncCycles();
    label_334B_2B7B_3602B:
    // MOV DS,word ptr CS:[0x2535] (334B_2B7B / 0x3602B)
    DS = UInt16[cs2, 0x2535];
    State.IncCycles();
    // SUB DI,AX (334B_2B80 / 0x36030)
    // DI -= AX;
    DI = Alu.Sub16(DI, AX);
    State.IncCycles();
    label_334B_2B82_36032:
    // MOV CX,AX (334B_2B82 / 0x36032)
    CX = AX;
    State.IncCycles();
    // SHR CX,1 (334B_2B84 / 0x36034)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2B86 / 0x36036)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB SI,AX (334B_2B88 / 0x36038)
    SI -= AX;
    State.IncCycles();
    // SUB DI,AX (334B_2B8A / 0x3603A)
    DI -= AX;
    State.IncCycles();
    // ADD SI,0xc8 (334B_2B8C / 0x3603C)
    SI += 0xC8;
    State.IncCycles();
    // ADD DI,0x140 (334B_2B90 / 0x36040)
    DI += 0x140;
    State.IncCycles();
    // DEC AX (334B_2B94 / 0x36044)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV CX,AX (334B_2B95 / 0x36045)
    CX = AX;
    State.IncCycles();
    // SHR CX,1 (334B_2B97 / 0x36047)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2B99 / 0x36049)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOVSB ES:DI,SI (334B_2B9B / 0x3604B)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // SUB SI,AX (334B_2B9C / 0x3604C)
    SI -= AX;
    State.IncCycles();
    // SUB DI,AX (334B_2B9E / 0x3604E)
    DI -= AX;
    State.IncCycles();
    // ADD SI,0xc8 (334B_2BA0 / 0x36050)
    SI += 0xC8;
    State.IncCycles();
    // ADD DI,0x140 (334B_2BA4 / 0x36054)
    DI += 0x140;
    State.IncCycles();
    // DEC AX (334B_2BA8 / 0x36058)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JG 0x3000:6032 (334B_2BA9 / 0x36059)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_334B_2B82_36032;
    }
    State.IncCycles();
    // RET  (334B_2BAB / 0x3605B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2BAC_03605C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2BAC_3605C:
    // MOV DS,word ptr CS:[0x2537] (334B_2BAC / 0x3605C)
    DS = UInt16[cs2, 0x2537];
    State.IncCycles();
    // MOV AX,0x98 (334B_2BB1 / 0x36061)
    AX = 0x98;
    State.IncCycles();
    // SUB AX,BX (334B_2BB4 / 0x36064)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // MOV BX,DX (334B_2BB6 / 0x36066)
    BX = DX;
    State.IncCycles();
    // SUB BX,AX (334B_2BB8 / 0x36068)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // JNS 0x3000:606e (334B_2BBA / 0x3606A)
    if(!SignFlag) {
      goto label_334B_2BBE_3606E;
    }
    State.IncCycles();
    // ADD AX,BX (334B_2BBC / 0x3606C)
    AX += BX;
    State.IncCycles();
    label_334B_2BBE_3606E:
    // CMP DX,0x138 (334B_2BBE / 0x3606E)
    Alu.Sub16(DX, 0x138);
    State.IncCycles();
    // JBE 0x3000:608d (334B_2BC2 / 0x36072)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_2BDD_3608D;
    }
    State.IncCycles();
    // XOR DX,DX (334B_2BC4 / 0x36074)
    DX = 0;
    State.IncCycles();
    label_334B_2BC6_36076:
    // MOV CX,DX (334B_2BC6 / 0x36076)
    CX = DX;
    State.IncCycles();
    // MOV SI,DI (334B_2BC8 / 0x36078)
    SI = DI;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_2BCA / 0x3607A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // SUB DI,DX (334B_2BCC / 0x3607C)
    DI -= DX;
    State.IncCycles();
    // ADD DI,0x13f (334B_2BCE / 0x3607E)
    DI += 0x13F;
    State.IncCycles();
    // INC DX (334B_2BD2 / 0x36082)
    DX++;
    State.IncCycles();
    // CMP DX,0x8 (334B_2BD3 / 0x36083)
    Alu.Sub16(DX, 0x8);
    State.IncCycles();
    // JC 0x3000:6076 (334B_2BD6 / 0x36086)
    if(CarryFlag) {
      goto label_334B_2BC6_36076;
    }
    State.IncCycles();
    // SUB AX,0x8 (334B_2BD8 / 0x36088)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    State.IncCycles();
    // JBE 0x3000:60b1 (334B_2BDB / 0x3608B)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (334B_2C01 / 0x360B1)
      return NearRet();
    }
    State.IncCycles();
    label_334B_2BDD_3608D:
    // MOV SI,DI (334B_2BDD / 0x3608D)
    SI = DI;
    State.IncCycles();
    // MOV CX,0x4 (334B_2BDF / 0x3608F)
    CX = 0x4;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2BE2 / 0x36092)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DI,0x137 (334B_2BE4 / 0x36094)
    DI += 0x137;
    State.IncCycles();
    // DEC AX (334B_2BE8 / 0x36098)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:608d (334B_2BE9 / 0x36099)
    if(!ZeroFlag) {
      goto label_334B_2BDD_3608D;
    }
    State.IncCycles();
    // OR BX,BX (334B_2BEB / 0x3609B)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JGE 0x3000:60b1 (334B_2BED / 0x3609D)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      State.IncCycles();
      // RET  (334B_2C01 / 0x360B1)
      return NearRet();
    }
    State.IncCycles();
    // MOV DX,0x8 (334B_2BEF / 0x3609F)
    DX = 0x8;
    State.IncCycles();
    label_334B_2BF2_360A2:
    // MOV CX,DX (334B_2BF2 / 0x360A2)
    CX = DX;
    State.IncCycles();
    // MOV SI,DI (334B_2BF4 / 0x360A4)
    SI = DI;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (334B_2BF6 / 0x360A6)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // SUB DI,DX (334B_2BF8 / 0x360A8)
    DI -= DX;
    State.IncCycles();
    // ADD DI,0x140 (334B_2BFA / 0x360AA)
    DI += 0x140;
    State.IncCycles();
    // DEC DX (334B_2BFE / 0x360AE)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:60a2 (334B_2BFF / 0x360AF)
    if(!ZeroFlag) {
      goto label_334B_2BF2_360A2;
    }
    State.IncCycles();
    label_334B_2C01_360B1:
    // RET  (334B_2C01 / 0x360B1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2C02_0360B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2C02_360B2:
    // MOV DS,word ptr CS:[0x2537] (334B_2C02 / 0x360B2)
    DS = UInt16[cs2, 0x2537];
    State.IncCycles();
    // MOV AX,0x98 (334B_2C07 / 0x360B7)
    AX = 0x98;
    State.IncCycles();
    // ADD AX,0x8 (334B_2C0A / 0x360BA)
    AX += 0x8;
    State.IncCycles();
    // CMP DI,AX (334B_2C0D / 0x360BD)
    Alu.Sub16(DI, AX);
    State.IncCycles();
    // JC 0x3000:6101 (334B_2C0F / 0x360BF)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (334B_2C51 / 0x36101)
      return NearRet();
    }
    State.IncCycles();
    // OR BX,BX (334B_2C11 / 0x360C1)
    BX |= BX;
    State.IncCycles();
    // SUB AX,0x8 (334B_2C13 / 0x360C3)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    State.IncCycles();
    // OR BX,BX (334B_2C16 / 0x360C6)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JLE 0x3000:60ee (334B_2C18 / 0x360C8)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_334B_2C3E_360EE;
    }
    State.IncCycles();
    // ADD AX,0x8 (334B_2C1A / 0x360CA)
    AX += 0x8;
    State.IncCycles();
    // SUB AX,BX (334B_2C1D / 0x360CD)
    AX -= BX;
    State.IncCycles();
    // SUB DI,AX (334B_2C1F / 0x360CF)
    DI -= AX;
    State.IncCycles();
    // SUB DI,0xa00 (334B_2C21 / 0x360D1)
    // DI -= 0xA00;
    DI = Alu.Sub16(DI, 0xA00);
    State.IncCycles();
    // MOV DX,0x8 (334B_2C25 / 0x360D5)
    DX = 0x8;
    State.IncCycles();
    label_334B_2C28_360D8:
    // MOV CX,AX (334B_2C28 / 0x360D8)
    CX = AX;
    State.IncCycles();
    // SHR CX,1 (334B_2C2A / 0x360DA)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // MOV SI,DI (334B_2C2C / 0x360DC)
    SI = DI;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2C2E / 0x360DE)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB DI,AX (334B_2C30 / 0x360E0)
    DI -= AX;
    State.IncCycles();
    // ADD DI,0x140 (334B_2C32 / 0x360E2)
    DI += 0x140;
    State.IncCycles();
    // DEC DX (334B_2C36 / 0x360E6)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:60d8 (334B_2C37 / 0x360E7)
    if(!ZeroFlag) {
      goto label_334B_2C28_360D8;
    }
    State.IncCycles();
    // SUB AX,0x8 (334B_2C39 / 0x360E9)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    State.IncCycles();
    // JMP 0x3000:60f3 (334B_2C3C / 0x360EC)
    goto label_334B_2C43_360F3;
    State.IncCycles();
    label_334B_2C3E_360EE:
    // SUB DI,AX (334B_2C3E / 0x360EE)
    DI -= AX;
    State.IncCycles();
    // SUB DI,0x8 (334B_2C40 / 0x360F0)
    // DI -= 0x8;
    DI = Alu.Sub16(DI, 0x8);
    State.IncCycles();
    label_334B_2C43_360F3:
    // MOV SI,DI (334B_2C43 / 0x360F3)
    SI = DI;
    State.IncCycles();
    // MOV CX,0x4 (334B_2C45 / 0x360F5)
    CX = 0x4;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2C48 / 0x360F8)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DI,0x138 (334B_2C4A / 0x360FA)
    DI += 0x138;
    State.IncCycles();
    // DEC AX (334B_2C4E / 0x360FE)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNZ 0x3000:60f3 (334B_2C4F / 0x360FF)
    if(!ZeroFlag) {
      goto label_334B_2C43_360F3;
    }
    State.IncCycles();
    label_334B_2C51_36101:
    // RET  (334B_2C51 / 0x36101)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_2C52_036102(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2C52_36102:
    // PUSH ES (334B_2C52 / 0x36102)
    Stack.Push(ES);
    State.IncCycles();
    // MOV ES,word ptr CS:[0x2535] (334B_2C53 / 0x36103)
    ES = UInt16[cs2, 0x2535];
    State.IncCycles();
    // MOV SI,0xf9ff (334B_2C58 / 0x36108)
    SI = 0xF9FF;
    State.IncCycles();
    // XOR DI,DI (334B_2C5B / 0x3610B)
    DI = 0;
    State.IncCycles();
    // MOV DX,0x140 (334B_2C5D / 0x3610D)
    DX = 0x140;
    State.IncCycles();
    // MOV BX,0x6062 (334B_2C60 / 0x36110)
    BX = 0x6062;
    State.IncCycles();
    label_334B_2C63_36113:
    // PUSH SI (334B_2C63 / 0x36113)
    Stack.Push(SI);
    State.IncCycles();
    // MOV CX,0x32 (334B_2C64 / 0x36114)
    CX = 0x32;
    State.IncCycles();
    label_334B_2C67_36117:
    // MOV AH,byte ptr [SI + 0xfec0] (334B_2C67 / 0x36117)
    AH = UInt8[DS, (ushort)(SI + 0xFEC0)];
    State.IncCycles();
    // CMP AH,BH (334B_2C6B / 0x3611B)
    Alu.Sub8(AH, BH);
    State.IncCycles();
    // JC 0x3000:6126 (334B_2C6D / 0x3611D)
    if(CarryFlag) {
      goto label_334B_2C76_36126;
    }
    State.IncCycles();
    // CMP AH,BL (334B_2C6F / 0x3611F)
    Alu.Sub8(AH, BL);
    State.IncCycles();
    // JNC 0x3000:6126 (334B_2C71 / 0x36121)
    if(!CarryFlag) {
      goto label_334B_2C76_36126;
    }
    State.IncCycles();
    // ADD AH,0x2 (334B_2C73 / 0x36123)
    // AH += 0x2;
    AH = Alu.Add8(AH, 0x2);
    State.IncCycles();
    label_334B_2C76_36126:
    // MOV AL,byte ptr [SI] (334B_2C76 / 0x36126)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CMP AL,BH (334B_2C78 / 0x36128)
    Alu.Sub8(AL, BH);
    State.IncCycles();
    // JC 0x3000:6132 (334B_2C7A / 0x3612A)
    if(CarryFlag) {
      goto label_334B_2C82_36132;
    }
    State.IncCycles();
    // CMP AL,BL (334B_2C7C / 0x3612C)
    Alu.Sub8(AL, BL);
    State.IncCycles();
    // JNC 0x3000:6132 (334B_2C7E / 0x3612E)
    if(!CarryFlag) {
      goto label_334B_2C82_36132;
    }
    State.IncCycles();
    // ADD AL,0x2 (334B_2C80 / 0x36130)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    State.IncCycles();
    label_334B_2C82_36132:
    // STOSW ES:DI (334B_2C82 / 0x36132)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AH,byte ptr [SI + 0xfc40] (334B_2C83 / 0x36133)
    AH = UInt8[DS, (ushort)(SI + 0xFC40)];
    State.IncCycles();
    // CMP AH,BH (334B_2C87 / 0x36137)
    Alu.Sub8(AH, BH);
    State.IncCycles();
    // JC 0x3000:6142 (334B_2C89 / 0x36139)
    if(CarryFlag) {
      goto label_334B_2C92_36142;
    }
    State.IncCycles();
    // CMP AH,BL (334B_2C8B / 0x3613B)
    Alu.Sub8(AH, BL);
    State.IncCycles();
    // JNC 0x3000:6142 (334B_2C8D / 0x3613D)
    if(!CarryFlag) {
      goto label_334B_2C92_36142;
    }
    State.IncCycles();
    // ADD AH,0x2 (334B_2C8F / 0x3613F)
    // AH += 0x2;
    AH = Alu.Add8(AH, 0x2);
    State.IncCycles();
    label_334B_2C92_36142:
    // MOV AL,byte ptr [SI + 0xfd80] (334B_2C92 / 0x36142)
    AL = UInt8[DS, (ushort)(SI + 0xFD80)];
    State.IncCycles();
    // CMP AL,BH (334B_2C96 / 0x36146)
    Alu.Sub8(AL, BH);
    State.IncCycles();
    // JC 0x3000:6150 (334B_2C98 / 0x36148)
    if(CarryFlag) {
      goto label_334B_2CA0_36150;
    }
    State.IncCycles();
    // CMP AL,BL (334B_2C9A / 0x3614A)
    Alu.Sub8(AL, BL);
    State.IncCycles();
    // JNC 0x3000:6150 (334B_2C9C / 0x3614C)
    if(!CarryFlag) {
      goto label_334B_2CA0_36150;
    }
    State.IncCycles();
    // ADD AL,0x2 (334B_2C9E / 0x3614E)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    State.IncCycles();
    label_334B_2CA0_36150:
    // STOSW ES:DI (334B_2CA0 / 0x36150)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // SUB SI,0x500 (334B_2CA1 / 0x36151)
    // SI -= 0x500;
    SI = Alu.Sub16(SI, 0x500);
    State.IncCycles();
    // LOOP 0x3000:6117 (334B_2CA5 / 0x36155)
    if(--CX != 0) {
      goto label_334B_2C67_36117;
    }
    State.IncCycles();
    // POP SI (334B_2CA7 / 0x36157)
    SI = Stack.Pop();
    State.IncCycles();
    // DEC SI (334B_2CA8 / 0x36158)
    SI--;
    State.IncCycles();
    // DEC DX (334B_2CA9 / 0x36159)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:6113 (334B_2CAA / 0x3615A)
    if(!ZeroFlag) {
      goto label_334B_2C63_36113;
    }
    State.IncCycles();
    // PUSH DS (334B_2CAC / 0x3615C)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_2CAD / 0x3615D)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_2CAE / 0x3615E)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x62a0 (334B_2CAF / 0x3615F)
    DI = 0x62A0;
    State.IncCycles();
    // MOV DX,0x44 (334B_2CB2 / 0x36162)
    DX = 0x44;
    State.IncCycles();
    label_334B_2CB5_36165:
    // LEA SI,[DI + 0xd5d0] (334B_2CB5 / 0x36165)
    SI = (ushort)(DI + 0xD5D0);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2CB9 / 0x36169)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2CBA / 0x3616A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2CBB / 0x3616B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (334B_2CBC / 0x3616C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD DI,0xc0 (334B_2CBD / 0x3616D)
    DI += 0xC0;
    State.IncCycles();
    // DEC DX (334B_2CC1 / 0x36171)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:6165 (334B_2CC2 / 0x36172)
    if(!ZeroFlag) {
      goto label_334B_2CB5_36165;
    }
    State.IncCycles();
    // POP DS (334B_2CC4 / 0x36174)
    DS = Stack.Pop();
    State.IncCycles();
    // POP ES (334B_2CC5 / 0x36175)
    ES = Stack.Pop();
    State.IncCycles();
    // RET  (334B_2CC6 / 0x36176)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2CCA_03617A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2CCA_3617A:
    // OR DL,DL (334B_2CCA / 0x3617A)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JS 0x3000:61ae (334B_2CCC / 0x3617C)
    if(SignFlag) {
      goto label_334B_2CFE_361AE;
    }
    State.IncCycles();
    // MOV AX,0x140 (334B_2CCE / 0x3617E)
    AX = 0x140;
    State.IncCycles();
    // MUL CX (334B_2CD1 / 0x36181)
    Cpu.Mul16(CX);
    State.IncCycles();
    // MOV DX,AX (334B_2CD3 / 0x36183)
    DX = AX;
    State.IncCycles();
    // MOV SI,DX (334B_2CD5 / 0x36185)
    SI = DX;
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_2CD7 / 0x36187)
    BX = UInt16[SS, BP];
    State.IncCycles();
    label_334B_2CDA_3618A:
    // XOR DI,DI (334B_2CDA / 0x3618A)
    DI = 0;
    State.IncCycles();
    // MOV CX,DX (334B_2CDC / 0x3618C)
    CX = DX;
    State.IncCycles();
    // SUB CX,SI (334B_2CDE / 0x3618E)
    // CX -= SI;
    CX = Alu.Sub16(CX, SI);
    State.IncCycles();
    // JZ 0x3000:6198 (334B_2CE0 / 0x36190)
    if(ZeroFlag) {
      goto label_334B_2CE8_36198;
    }
    State.IncCycles();
    // PUSH SI (334B_2CE2 / 0x36192)
    Stack.Push(SI);
    State.IncCycles();
    // SHR CX,1 (334B_2CE3 / 0x36193)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2CE5 / 0x36195)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP SI (334B_2CE7 / 0x36197)
    SI = Stack.Pop();
    State.IncCycles();
    label_334B_2CE8_36198:
    // MOV CX,0x500 (334B_2CE8 / 0x36198)
    CX = 0x500;
    State.IncCycles();
    // MOV AX,0x707 (334B_2CEB / 0x3619B)
    AX = 0x707;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_2CEE / 0x3619E)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB SI,0xa00 (334B_2CF0 / 0x361A0)
    // SI -= 0xA00;
    SI = Alu.Sub16(SI, 0xA00);
    State.IncCycles();
    // CALL 0x3000:59ed (334B_2CF4 / 0x361A4)
    NearCall(cs2, 0x2CF7, spice86_generated_label_call_target_334B_253D_0359ED);
    State.IncCycles();
    // CMP SI,0xa00 (334B_2CF7 / 0x361A7)
    Alu.Sub16(SI, 0xA00);
    State.IncCycles();
    // JA 0x3000:618a (334B_2CFB / 0x361AB)
    if(!CarryFlag && !ZeroFlag) {
      goto label_334B_2CDA_3618A;
    }
    State.IncCycles();
    // RETF  (334B_2CFD / 0x361AD)
    return FarRet();
    State.IncCycles();
    label_334B_2CFE_361AE:
    // CALL 0x3000:5a46 (334B_2CFE / 0x361AE)
    NearCall(cs2, 0x2D01, spice86_generated_label_call_target_334B_2596_035A46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2D01_0361B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2D01_0361B1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x261BE: goto label_334B_2D0E_361BE;break; // Target of external jump from 0x361EF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_2D01_361B1:
    // MOV AX,0x140 (334B_2D01 / 0x361B1)
    AX = 0x140;
    State.IncCycles();
    // MUL CX (334B_2D04 / 0x361B4)
    Cpu.Mul16(CX);
    State.IncCycles();
    // MOV DX,AX (334B_2D06 / 0x361B6)
    DX = AX;
    State.IncCycles();
    // MOV SI,0xa00 (334B_2D08 / 0x361B8)
    SI = 0xA00;
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x0] (334B_2D0B / 0x361BB)
    BX = UInt16[SS, BP];
    State.IncCycles();
    label_334B_2D0E_361BE:
    // PUSH SI (334B_2D0E / 0x361BE)
    Stack.Push(SI);
    State.IncCycles();
    // XOR DI,DI (334B_2D0F / 0x361BF)
    DI = 0;
    State.IncCycles();
    // MOV CX,DX (334B_2D11 / 0x361C1)
    CX = DX;
    State.IncCycles();
    // SUB CX,SI (334B_2D13 / 0x361C3)
    // CX -= SI;
    CX = Alu.Sub16(CX, SI);
    State.IncCycles();
    // MOV AX,DS (334B_2D15 / 0x361C5)
    AX = DS;
    State.IncCycles();
    // MOV DS,word ptr CS:[0x2535] (334B_2D17 / 0x361C7)
    DS = UInt16[cs2, 0x2535];
    State.IncCycles();
    // SHR CX,1 (334B_2D1C / 0x361CC)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2D1E / 0x361CE)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOV DS,AX (334B_2D20 / 0x361D0)
    DS = AX;
    State.IncCycles();
    // MOV CX,0x500 (334B_2D22 / 0x361D2)
    CX = 0x500;
    State.IncCycles();
    // MOV AX,0x707 (334B_2D25 / 0x361D5)
    AX = 0x707;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_2D28 / 0x361D8)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // CMP DI,DX (334B_2D2A / 0x361DA)
    Alu.Sub16(DI, DX);
    State.IncCycles();
    // JNC 0x3000:61e5 (334B_2D2C / 0x361DC)
    if(!CarryFlag) {
      goto label_334B_2D35_361E5;
    }
    State.IncCycles();
    // MOV CX,0x500 (334B_2D2E / 0x361DE)
    CX = 0x500;
    State.IncCycles();
    // MOV SI,DI (334B_2D31 / 0x361E1)
    SI = DI;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_2D33 / 0x361E3)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    label_334B_2D35_361E5:
    // POP SI (334B_2D35 / 0x361E5)
    SI = Stack.Pop();
    State.IncCycles();
    // ADD SI,0xa00 (334B_2D36 / 0x361E6)
    // SI += 0xA00;
    SI = Alu.Add16(SI, 0xA00);
    State.IncCycles();
    // CALL 0x3000:59ed (334B_2D3A / 0x361EA)
    NearCall(cs2, 0x2D3D, spice86_generated_label_call_target_334B_253D_0359ED);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2D3D_0361ED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2D3D_0361ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2D3D_361ED:
    // CMP SI,DX (334B_2D3D / 0x361ED)
    Alu.Sub16(SI, DX);
    State.IncCycles();
    // JBE 0x3000:61be (334B_2D3F / 0x361EF)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2D01_0361B1, 0x361BE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RETF  (334B_2D41 / 0x361F1)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2DC0_036270(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2DC0_36270:
    // MOV CX,0xc8 (334B_2DC0 / 0x36270)
    CX = 0xC8;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2DC3_036273, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_2DC3_036273(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x2627D: goto label_334B_2DCD_3627D;break; // Target of external jump from 0x362A5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_2DC3_36273:
    // MOV BX,word ptr [BP + 0x0] (334B_2DC3 / 0x36273)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // MOV SI,0x2fd7 (334B_2DC6 / 0x36276)
    SI = 0x2FD7;
    State.IncCycles();
    // SHR CX,1 (334B_2DC9 / 0x36279)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (334B_2DCB / 0x3627B)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    label_334B_2DCD_3627D:
    // LODSW CS:SI (334B_2DCD / 0x3627D)
    AX = UInt16[cs2, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (334B_2DCF / 0x3627F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x3000:62a7 (334B_2DD1 / 0x36281)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_2DF7_0362A7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH CX (334B_2DD3 / 0x36283)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_2DD4 / 0x36284)
    Stack.Push(SI);
    State.IncCycles();
    // ADD AX,word ptr CS:[0x1a3] (334B_2DD5 / 0x36285)
    // AX += UInt16[cs2, 0x1A3];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1A3]);
    State.IncCycles();
    // MOV DI,AX (334B_2DDA / 0x3628A)
    DI = AX;
    State.IncCycles();
    // XOR AX,AX (334B_2DDC / 0x3628C)
    AX = 0;
    State.IncCycles();
    label_334B_2DDE_3628E:
    // PUSH DI (334B_2DDE / 0x3628E)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DX,0x50 (334B_2DDF / 0x3628F)
    DX = 0x50;
    State.IncCycles();
    label_334B_2DE2_36292:
    // STOSB ES:DI (334B_2DE2 / 0x36292)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DI,0x3 (334B_2DE3 / 0x36293)
    DI += 0x3;
    State.IncCycles();
    // DEC DX (334B_2DE6 / 0x36296)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:6292 (334B_2DE7 / 0x36297)
    if(!ZeroFlag) {
      goto label_334B_2DE2_36292;
    }
    State.IncCycles();
    // POP DI (334B_2DE9 / 0x36299)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x500 (334B_2DEA / 0x3629A)
    // DI += 0x500;
    DI = Alu.Add16(DI, 0x500);
    State.IncCycles();
    // LOOP 0x3000:628e (334B_2DEE / 0x3629E)
    if(--CX != 0) {
      goto label_334B_2DDE_3628E;
    }
    State.IncCycles();
    // CALL 0x3000:5a22 (334B_2DF0 / 0x362A0)
    NearCall(cs2, 0x2DF3, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2DF3_0362A3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2DF3_0362A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2DF3_362A3:
    // POP SI (334B_2DF3 / 0x362A3)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_2DF4 / 0x362A4)
    CX = Stack.Pop();
    State.IncCycles();
    // JMP 0x3000:627d (334B_2DF5 / 0x362A5)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_2DC3_036273, 0x3627D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_2DF7_0362A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2DF7_362A7:
    // PUSH CS (334B_2DF7 / 0x362A7)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:3fbc (334B_2DF8 / 0x362A8)
    NearCall(cs2, 0x2DFB, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2DFB_0362AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2DFB_0362AB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x262B1: goto label_334B_2E01_362B1;break; // Target of external jump from 0x362D9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_2DFB_362AB:
    // MOV BX,word ptr [BP + 0x0] (334B_2DFB / 0x362AB)
    BX = UInt16[SS, BP];
    State.IncCycles();
    // MOV SI,0x2fd7 (334B_2DFE / 0x362AE)
    SI = 0x2FD7;
    State.IncCycles();
    label_334B_2E01_362B1:
    // LODSW CS:SI (334B_2E01 / 0x362B1)
    AX = UInt16[cs2, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (334B_2E03 / 0x362B3)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x3000:62db (334B_2E05 / 0x362B5)
    if(SignFlag) {
      // JS target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_2E2B / 0x362DB)
      return FarRet();
    }
    State.IncCycles();
    // PUSH CX (334B_2E07 / 0x362B7)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_2E08 / 0x362B8)
    Stack.Push(SI);
    State.IncCycles();
    // ADD AX,word ptr CS:[0x1a3] (334B_2E09 / 0x362B9)
    // AX += UInt16[cs2, 0x1A3];
    AX = Alu.Add16(AX, UInt16[cs2, 0x1A3]);
    State.IncCycles();
    // MOV DI,AX (334B_2E0E / 0x362BE)
    DI = AX;
    State.IncCycles();
    label_334B_2E10_362C0:
    // PUSH DI (334B_2E10 / 0x362C0)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DX,0x50 (334B_2E11 / 0x362C1)
    DX = 0x50;
    State.IncCycles();
    label_334B_2E14_362C4:
    // MOV SI,DI (334B_2E14 / 0x362C4)
    SI = DI;
    State.IncCycles();
    // MOVSB ES:DI,SI (334B_2E16 / 0x362C6)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD DI,0x3 (334B_2E17 / 0x362C7)
    DI += 0x3;
    State.IncCycles();
    // DEC DX (334B_2E1A / 0x362CA)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:62c4 (334B_2E1B / 0x362CB)
    if(!ZeroFlag) {
      goto label_334B_2E14_362C4;
    }
    State.IncCycles();
    // POP DI (334B_2E1D / 0x362CD)
    DI = Stack.Pop();
    State.IncCycles();
    // ADD DI,0x500 (334B_2E1E / 0x362CE)
    // DI += 0x500;
    DI = Alu.Add16(DI, 0x500);
    State.IncCycles();
    // LOOP 0x3000:62c0 (334B_2E22 / 0x362D2)
    if(--CX != 0) {
      goto label_334B_2E10_362C0;
    }
    State.IncCycles();
    // CALL 0x3000:5a22 (334B_2E24 / 0x362D4)
    NearCall(cs2, 0x2E27, spice86_generated_label_call_target_334B_2572_035A22);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2E27_0362D7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_2E27_0362D7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2E27_362D7:
    // POP SI (334B_2E27 / 0x362D7)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_2E28 / 0x362D8)
    CX = Stack.Pop();
    State.IncCycles();
    // JMP 0x3000:62b1 (334B_2E29 / 0x362D9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_2DFB_0362AB, 0x362B1 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_2E2B_0362DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_2E2B_362DB:
    // RETF  (334B_2E2B / 0x362DB)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_311A_0365CA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_311A_365CA:
    // MOV DI,word ptr CS:[0x3118] (334B_311A / 0x365CA)
    DI = UInt16[cs2, 0x3118];
    State.IncCycles();
    // XOR AX,AX (334B_311F / 0x365CF)
    AX = 0;
    State.IncCycles();
    // MOV CX,0x12c0 (334B_3121 / 0x365D1)
    CX = 0x12C0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_3124 / 0x365D4)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOV DS,word ptr CS:[0x2537] (334B_3126 / 0x365D6)
    DS = UInt16[cs2, 0x2537];
    State.IncCycles();
    // PUSH CS (334B_312B / 0x365DB)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:3fbc (334B_312C / 0x365DC)
    NearCall(cs2, 0x312F, spice86_generated_label_call_target_334B_0B0C_033FBC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_312F_0365DF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_312F_0365DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_312F_365DF:
    // RET  (334B_312F / 0x365DF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3130_0365E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3130_365E0:
    // CALL 0x3000:5a46 (334B_3130 / 0x365E0)
    NearCall(cs2, 0x3133, spice86_generated_label_call_target_334B_2596_035A46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3133_0365E3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3133_0365E3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x265FA: goto label_334B_314A_365FA;break; // Target of external jump from 0x3661A
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_3133_365E3:
    // MOV DS,word ptr CS:[0x2535] (334B_3133 / 0x365E3)
    DS = UInt16[cs2, 0x2535];
    State.IncCycles();
    // MOV AX,CS:[0x1a3] (334B_3138 / 0x365E8)
    AX = UInt16[cs2, 0x1A3];
    State.IncCycles();
    // MOV CS:[0x3118],AX (334B_313C / 0x365EC)
    UInt16[cs2, 0x3118] = AX;
    State.IncCycles();
    // OR DL,DL (334B_3140 / 0x365F0)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // MOV CX,0x101 (334B_3142 / 0x365F2)
    CX = 0x101;
    State.IncCycles();
    // JS 0x3000:65fa (334B_3145 / 0x365F5)
    if(SignFlag) {
      goto label_334B_314A_365FA;
    }
    State.IncCycles();
    // MOV CX,0xff11 (334B_3147 / 0x365F7)
    CX = 0xFF11;
    State.IncCycles();
    label_334B_314A_365FA:
    // PUSH word ptr [BP + 0x0] (334B_314A / 0x365FA)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    // PUSH CX (334B_314D / 0x365FD)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH BP (334B_314E / 0x365FE)
    Stack.Push(BP);
    State.IncCycles();
    // XOR CH,CH (334B_314F / 0x365FF)
    CH = 0;
    State.IncCycles();
    // MOV BX,CX (334B_3151 / 0x36601)
    BX = CX;
    State.IncCycles();
    // SHL BX,1 (334B_3153 / 0x36603)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV AX,word ptr CS:[BX + 0x30f0] (334B_3155 / 0x36605)
    AX = UInt16[cs2, (ushort)(BX + 0x30F0)];
    State.IncCycles();
    // CALL 0x3000:661d (334B_315A / 0x3660A)
    NearCall(cs2, 0x315D, spice86_generated_label_call_target_334B_316D_03661D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_315D_03660D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_315D_03660D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_315D_3660D:
    // POP BP (334B_315D / 0x3660D)
    BP = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_315E / 0x3660E)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_315F / 0x3660F)
    BX = Stack.Pop();
    State.IncCycles();
    // CALL 0x3000:59ed (334B_3160 / 0x36610)
    NearCall(cs2, 0x3163, spice86_generated_label_call_target_334B_253D_0359ED);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3163_036613, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3163_036613(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3163_36613:
    // ADD CL,CH (334B_3163 / 0x36613)
    // CL += CH;
    CL = Alu.Add8(CL, CH);
    State.IncCycles();
    // JZ 0x3000:661c (334B_3165 / 0x36615)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_316C / 0x3661C)
      return FarRet();
    }
    State.IncCycles();
    // CMP CL,0x11 (334B_3167 / 0x36617)
    Alu.Sub8(CL, 0x11);
    State.IncCycles();
    // JC 0x3000:65fa (334B_316A / 0x3661A)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3133_0365E3, 0x365FA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_334B_316C_3661C:
    // RETF  (334B_316C / 0x3661C)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_316D_03661D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_316D_3661D:
    // CMP CL,0x9 (334B_316D / 0x3661D)
    Alu.Sub8(CL, 0x9);
    State.IncCycles();
    // JZ 0x3000:65ca (334B_3170 / 0x36620)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_311A_0365CA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CS:[0x3114],AX (334B_3172 / 0x36622)
    UInt16[cs2, 0x3114] = AX;
    State.IncCycles();
    // MOV DI,0x5dc0 (334B_3176 / 0x36626)
    DI = 0x5DC0;
    State.IncCycles();
    // ADD DI,word ptr CS:[0x1a3] (334B_3179 / 0x36629)
    // DI += UInt16[cs2, 0x1A3];
    DI = Alu.Add16(DI, UInt16[cs2, 0x1A3]);
    State.IncCycles();
    // LEA BP,[DI + 0x140] (334B_317E / 0x3662E)
    BP = (ushort)(DI + 0x140);
    State.IncCycles();
    // MOV SI,DI (334B_3182 / 0x36632)
    SI = DI;
    State.IncCycles();
    // MOV BX,BP (334B_3184 / 0x36634)
    BX = BP;
    State.IncCycles();
    // MOV DX,0x4c (334B_3186 / 0x36636)
    DX = 0x4C;
    State.IncCycles();
    // JMP 0x3000:6643 (334B_3189 / 0x36639)
    goto label_334B_3193_36643;
    State.IncCycles();
    label_334B_318B_3663B:
    // SUB SI,0x280 (334B_318B / 0x3663B)
    SI -= 0x280;
    State.IncCycles();
    // SUB DI,0x280 (334B_318F / 0x3663F)
    DI -= 0x280;
    State.IncCycles();
    label_334B_3193_36643:
    // DEC DX (334B_3193 / 0x36643)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JS 0x3000:6675 (334B_3194 / 0x36644)
    if(SignFlag) {
      goto label_334B_31C5_36675;
    }
    State.IncCycles();
    // MOV CX,0xa0 (334B_3196 / 0x36646)
    CX = 0xA0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3199 / 0x36649)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG BP,DI (334B_319B / 0x3664B)
    ushort tmp_334B_319B = BP;
    BP = DI;
    DI = tmp_334B_319B;
    State.IncCycles();
    // XCHG BX,SI (334B_319D / 0x3664D)
    ushort tmp_334B_319D = BX;
    BX = SI;
    SI = tmp_334B_319D;
    State.IncCycles();
    // MOV CX,0xa0 (334B_319F / 0x3664F)
    CX = 0xA0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_31A2 / 0x36652)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG BP,DI (334B_31A4 / 0x36654)
    ushort tmp_334B_31A4 = BP;
    BP = DI;
    DI = tmp_334B_31A4;
    State.IncCycles();
    // XCHG BX,SI (334B_31A6 / 0x36656)
    ushort tmp_334B_31A6 = BX;
    BX = SI;
    SI = tmp_334B_31A6;
    State.IncCycles();
    // DEC AL (334B_31A8 / 0x36658)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x3000:663b (334B_31AA / 0x3665A)
    if(!ZeroFlag) {
      goto label_334B_318B_3663B;
    }
    State.IncCycles();
    // MOV CX,0x140 (334B_31AC / 0x3665C)
    CX = 0x140;
    State.IncCycles();
    // SUB DL,AH (334B_31AF / 0x3665F)
    // DL -= AH;
    DL = Alu.Sub8(DL, AH);
    State.IncCycles();
    // JBE 0x3000:6671 (334B_31B1 / 0x36661)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_31C1_36671;
    }
    State.IncCycles();
    label_334B_31B3_36663:
    // SUB SI,CX (334B_31B3 / 0x36663)
    SI -= CX;
    State.IncCycles();
    // ADD BX,CX (334B_31B5 / 0x36665)
    BX += CX;
    State.IncCycles();
    // DEC AH (334B_31B7 / 0x36667)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // JNZ 0x3000:6663 (334B_31B9 / 0x36669)
    if(!ZeroFlag) {
      goto label_334B_31B3_36663;
    }
    State.IncCycles();
    // MOV AX,CS:[0x3114] (334B_31BB / 0x3666B)
    AX = UInt16[cs2, 0x3114];
    State.IncCycles();
    // JMP 0x3000:663b (334B_31BF / 0x3666F)
    goto label_334B_318B_3663B;
    State.IncCycles();
    label_334B_31C1_36671:
    // SUB DI,0x280 (334B_31C1 / 0x36671)
    // DI -= 0x280;
    DI = Alu.Sub16(DI, 0x280);
    State.IncCycles();
    label_334B_31C5_36675:
    // MOV BX,DI (334B_31C5 / 0x36675)
    BX = DI;
    State.IncCycles();
    // XCHG word ptr CS:[0x3118],BX (334B_31C7 / 0x36677)
    ushort tmp_334B_31C7 = UInt16[cs2, 0x3118];
    UInt16[cs2, 0x3118] = BX;
    BX = tmp_334B_31C7;
    State.IncCycles();
    // XOR AX,AX (334B_31CC / 0x3667C)
    AX = 0;
    State.IncCycles();
    label_334B_31CE_3667E:
    // CMP BX,DI (334B_31CE / 0x3667E)
    Alu.Sub16(BX, DI);
    State.IncCycles();
    // JG 0x3000:6695 (334B_31D0 / 0x36680)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (334B_31E5 / 0x36695)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0xa0 (334B_31D2 / 0x36682)
    CX = 0xA0;
    State.IncCycles();
    // XCHG DI,BP (334B_31D5 / 0x36685)
    ushort tmp_334B_31D5 = DI;
    DI = BP;
    BP = tmp_334B_31D5;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_31D7 / 0x36687)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG DI,BP (334B_31D9 / 0x36689)
    ushort tmp_334B_31D9 = DI;
    DI = BP;
    BP = tmp_334B_31D9;
    State.IncCycles();
    // MOV CL,0xa0 (334B_31DB / 0x3668B)
    CL = 0xA0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_31DD / 0x3668D)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB DI,0x280 (334B_31DF / 0x3668F)
    // DI -= 0x280;
    DI = Alu.Sub16(DI, 0x280);
    State.IncCycles();
    // JMP 0x3000:667e (334B_31E3 / 0x36693)
    goto label_334B_31CE_3667E;
    State.IncCycles();
    label_334B_31E5_36695:
    // RET  (334B_31E5 / 0x36695)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3200_0366B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3200_366B0:
    // MOV word ptr CS:[0x2535],SI (334B_3200 / 0x366B0)
    UInt16[cs2, 0x2535] = SI;
    State.IncCycles();
    // MOV word ptr CS:[0x2537],DS (334B_3205 / 0x366B5)
    UInt16[cs2, 0x2537] = DS;
    State.IncCycles();
    // MOV word ptr CS:[0x2539],ES (334B_320A / 0x366BA)
    UInt16[cs2, 0x2539] = ES;
    State.IncCycles();
    // AND AX,0xfe (334B_320F / 0x366BF)
    AX &= 0xFE;
    State.IncCycles();
    label_334B_3212_366C2:
    // CMP AX,0x1a (334B_3212 / 0x366C2)
    Alu.Sub16(AX, 0x1A);
    State.IncCycles();
    // JC 0x3000:66cc (334B_3215 / 0x366C5)
    if(CarryFlag) {
      goto label_334B_321C_366CC;
    }
    State.IncCycles();
    // SUB AX,0x1a (334B_3217 / 0x366C7)
    // AX -= 0x1A;
    AX = Alu.Sub16(AX, 0x1A);
    State.IncCycles();
    // JMP 0x3000:66c2 (334B_321A / 0x366CA)
    goto label_334B_3212_366C2;
    State.IncCycles();
    label_334B_321C_366CC:
    // MOV BX,AX (334B_321C / 0x366CC)
    BX = AX;
    State.IncCycles();
    // JMP word ptr CS:[BX + 0x31e6] (334B_321E / 0x366CE)
    // Indirect jump to word ptr CS:[BX + 0x31e6], generating possible targets from emulator records
    uint targetAddress_334B_321E = (uint)(cs2 * 0x10 + UInt16[cs2, (ushort)(BX + 0x31E6)] - cs1 * 0x10);
    switch(targetAddress_334B_321E) {
      case 0x2687A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_33CA_03687A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x268D9 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3429_0368D9, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26832 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3382_036832, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26AB2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3602_036AB2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26CF1 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3841_036CF1, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26D88 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_38D8_036D88, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26E6B : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_39BB_036E6B, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x26A31 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3581_036A31, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_334B_321E));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3280_036730(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3280_36730:
    // MOV DI,0xc71c (334B_3280 / 0x36730)
    DI = 0xC71C;
    State.IncCycles();
    // MOV DX,0x10 (334B_3283 / 0x36733)
    DX = 0x10;
    State.IncCycles();
    // MOV AX,0xfefe (334B_3286 / 0x36736)
    AX = 0xFEFE;
    State.IncCycles();
    label_334B_3289_36739:
    // MOV CX,0x44 (334B_3289 / 0x36739)
    CX = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_328C / 0x3673C)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DI,0xb8 (334B_328E / 0x3673E)
    DI += 0xB8;
    State.IncCycles();
    // DEC DX (334B_3292 / 0x36742)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:6739 (334B_3293 / 0x36743)
    if(!ZeroFlag) {
      goto label_334B_3289_36739;
    }
    State.IncCycles();
    // MOV DX,0x8 (334B_3295 / 0x36745)
    DX = 0x8;
    State.IncCycles();
    // MOV AX,0xf208 (334B_3298 / 0x36748)
    AX = 0xF208;
    State.IncCycles();
    label_334B_329B_3674B:
    // MOV CX,0x44 (334B_329B / 0x3674B)
    CX = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_329E / 0x3674E)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DI,0xb8 (334B_32A0 / 0x36750)
    // DI += 0xB8;
    DI = Alu.Add16(DI, 0xB8);
    State.IncCycles();
    // XCHG AH,AL (334B_32A4 / 0x36754)
    byte tmp_334B_32A4 = AH;
    AH = AL;
    AL = tmp_334B_32A4;
    State.IncCycles();
    // DEC DX (334B_32A6 / 0x36756)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:674b (334B_32A7 / 0x36757)
    if(!ZeroFlag) {
      goto label_334B_329B_3674B;
    }
    State.IncCycles();
    // MOV DX,0x10 (334B_32A9 / 0x36759)
    DX = 0x10;
    State.IncCycles();
    // MOV AX,0xfefe (334B_32AC / 0x3675C)
    AX = 0xFEFE;
    State.IncCycles();
    label_334B_32AF_3675F:
    // MOV CX,0x44 (334B_32AF / 0x3675F)
    CX = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_32B2 / 0x36762)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DI,0xb8 (334B_32B4 / 0x36764)
    DI += 0xB8;
    State.IncCycles();
    // DEC DX (334B_32B8 / 0x36768)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:675f (334B_32B9 / 0x36769)
    if(!ZeroFlag) {
      goto label_334B_32AF_3675F;
    }
    State.IncCycles();
    // MOV DS,word ptr CS:[0x2537] (334B_32BB / 0x3676B)
    DS = UInt16[cs2, 0x2537];
    State.IncCycles();
    // RET  (334B_32C0 / 0x36770)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_32C1_036771(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_32C1_36771:
    // CMP CL,0x9 (334B_32C1 / 0x36771)
    Alu.Sub8(CL, 0x9);
    State.IncCycles();
    // JZ 0x3000:6730 (334B_32C4 / 0x36774)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_334B_3280_036730, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr CS:[0x3116],CX (334B_32C6 / 0x36776)
    UInt16[cs2, 0x3116] = CX;
    State.IncCycles();
    // MOV CS:[0x3114],AX (334B_32CB / 0x3677B)
    UInt16[cs2, 0x3114] = AX;
    State.IncCycles();
    // MOV DI,0xe01c (334B_32CF / 0x3677F)
    DI = 0xE01C;
    State.IncCycles();
    // LEA BP,[DI + 0xfec0] (334B_32D2 / 0x36782)
    BP = (ushort)(DI + 0xFEC0);
    State.IncCycles();
    // MOV CX,0x44 (334B_32D6 / 0x36786)
    CX = 0x44;
    State.IncCycles();
    // MOV SI,DI (334B_32D9 / 0x36789)
    SI = DI;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_32DB / 0x3678B)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // ADD DI,0xb8 (334B_32DD / 0x3678D)
    // DI += 0xB8;
    DI = Alu.Add16(DI, 0xB8);
    State.IncCycles();
    // MOV SI,DI (334B_32E1 / 0x36791)
    SI = DI;
    State.IncCycles();
    // MOV BX,BP (334B_32E3 / 0x36793)
    BX = BP;
    State.IncCycles();
    // MOV DX,0x14 (334B_32E5 / 0x36795)
    DX = 0x14;
    State.IncCycles();
    // JMP 0x3000:67aa (334B_32E8 / 0x36798)
    goto label_334B_32FA_367AA;
    State.IncCycles();
    label_334B_32EA_3679A:
    // SUB SI,0x1c8 (334B_32EA / 0x3679A)
    SI -= 0x1C8;
    State.IncCycles();
    // SUB DI,0x1c8 (334B_32EE / 0x3679E)
    DI -= 0x1C8;
    State.IncCycles();
    // ADD BX,0xb8 (334B_32F2 / 0x367A2)
    BX += 0xB8;
    State.IncCycles();
    // ADD BP,0xb8 (334B_32F6 / 0x367A6)
    BP += 0xB8;
    State.IncCycles();
    label_334B_32FA_367AA:
    // DEC DX (334B_32FA / 0x367AA)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JS 0x3000:67e0 (334B_32FB / 0x367AB)
    if(SignFlag) {
      goto label_334B_3330_367E0;
    }
    State.IncCycles();
    // MOV CX,0x44 (334B_32FD / 0x367AD)
    CX = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3300 / 0x367B0)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG BP,DI (334B_3302 / 0x367B2)
    ushort tmp_334B_3302 = BP;
    BP = DI;
    DI = tmp_334B_3302;
    State.IncCycles();
    // XCHG BX,SI (334B_3304 / 0x367B4)
    ushort tmp_334B_3304 = BX;
    BX = SI;
    SI = tmp_334B_3304;
    State.IncCycles();
    // MOV CX,0x44 (334B_3306 / 0x367B6)
    CX = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3309 / 0x367B9)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG BP,DI (334B_330B / 0x367BB)
    ushort tmp_334B_330B = BP;
    BP = DI;
    DI = tmp_334B_330B;
    State.IncCycles();
    // XCHG BX,SI (334B_330D / 0x367BD)
    ushort tmp_334B_330D = BX;
    BX = SI;
    SI = tmp_334B_330D;
    State.IncCycles();
    // DEC AL (334B_330F / 0x367BF)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x3000:679a (334B_3311 / 0x367C1)
    if(!ZeroFlag) {
      goto label_334B_32EA_3679A;
    }
    State.IncCycles();
    // MOV CX,0x140 (334B_3313 / 0x367C3)
    CX = 0x140;
    State.IncCycles();
    // SUB DL,AH (334B_3316 / 0x367C6)
    // DL -= AH;
    DL = Alu.Sub8(DL, AH);
    State.IncCycles();
    // JBE 0x3000:67d8 (334B_3318 / 0x367C8)
    if(CarryFlag || ZeroFlag) {
      goto label_334B_3328_367D8;
    }
    State.IncCycles();
    label_334B_331A_367CA:
    // SUB SI,CX (334B_331A / 0x367CA)
    SI -= CX;
    State.IncCycles();
    // ADD BX,CX (334B_331C / 0x367CC)
    BX += CX;
    State.IncCycles();
    // DEC AH (334B_331E / 0x367CE)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // JNZ 0x3000:67ca (334B_3320 / 0x367D0)
    if(!ZeroFlag) {
      goto label_334B_331A_367CA;
    }
    State.IncCycles();
    // MOV AX,CS:[0x3114] (334B_3322 / 0x367D2)
    AX = UInt16[cs2, 0x3114];
    State.IncCycles();
    // JMP 0x3000:679a (334B_3326 / 0x367D6)
    goto label_334B_32EA_3679A;
    State.IncCycles();
    label_334B_3328_367D8:
    // SUB DI,0x1c8 (334B_3328 / 0x367D8)
    DI -= 0x1C8;
    State.IncCycles();
    // ADD BP,0xb8 (334B_332C / 0x367DC)
    // BP += 0xB8;
    BP = Alu.Add16(BP, 0xB8);
    State.IncCycles();
    label_334B_3330_367E0:
    // MOV BX,0xfefe (334B_3330 / 0x367E0)
    BX = 0xFEFE;
    State.IncCycles();
    // MOV AX,0xf208 (334B_3333 / 0x367E3)
    AX = 0xF208;
    State.IncCycles();
    // MOV DX,word ptr CS:[0x3116] (334B_3336 / 0x367E6)
    DX = UInt16[cs2, 0x3116];
    State.IncCycles();
    // CMP DX,0x9 (334B_333B / 0x367EB)
    Alu.Sub16(DX, 0x9);
    State.IncCycles();
    // JC 0x3000:67f6 (334B_333E / 0x367EE)
    if(CarryFlag) {
      goto label_334B_3346_367F6;
    }
    State.IncCycles();
    // SUB DX,0x12 (334B_3340 / 0x367F0)
    DX -= 0x12;
    State.IncCycles();
    // NEG DX (334B_3343 / 0x367F3)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // XCHG AX,BX (334B_3345 / 0x367F5)
    ushort tmp_334B_3345 = AX;
    AX = BX;
    BX = tmp_334B_3345;
    State.IncCycles();
    label_334B_3346_367F6:
    // MOV CX,0x44 (334B_3346 / 0x367F6)
    CX = 0x44;
    State.IncCycles();
    // XCHG AX,BX (334B_3349 / 0x367F9)
    ushort tmp_334B_3349 = AX;
    AX = BX;
    BX = tmp_334B_3349;
    State.IncCycles();
    // XCHG DI,BP (334B_334A / 0x367FA)
    ushort tmp_334B_334A = DI;
    DI = BP;
    BP = tmp_334B_334A;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_334C / 0x367FC)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG AX,BX (334B_334E / 0x367FE)
    ushort tmp_334B_334E = AX;
    AX = BX;
    BX = tmp_334B_334E;
    State.IncCycles();
    // XCHG DI,BP (334B_334F / 0x367FF)
    ushort tmp_334B_334F = DI;
    DI = BP;
    BP = tmp_334B_334F;
    State.IncCycles();
    // MOV CL,0x44 (334B_3351 / 0x36801)
    CL = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_3353 / 0x36803)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG AH,AL (334B_3355 / 0x36805)
    byte tmp_334B_3355 = AH;
    AH = AL;
    AL = tmp_334B_3355;
    State.IncCycles();
    // XCHG BH,BL (334B_3357 / 0x36807)
    byte tmp_334B_3357 = BH;
    BH = BL;
    BL = tmp_334B_3357;
    State.IncCycles();
    // SUB DI,0x1c8 (334B_3359 / 0x36809)
    DI -= 0x1C8;
    State.IncCycles();
    // ADD BP,0xb8 (334B_335D / 0x3680D)
    BP += 0xB8;
    State.IncCycles();
    // DEC DX (334B_3361 / 0x36811)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JNZ 0x3000:67f6 (334B_3362 / 0x36812)
    if(!ZeroFlag) {
      goto label_334B_3346_367F6;
    }
    State.IncCycles();
    // MOV AX,0xfefe (334B_3364 / 0x36814)
    AX = 0xFEFE;
    State.IncCycles();
    label_334B_3367_36817:
    // MOV CL,0x44 (334B_3367 / 0x36817)
    CL = 0x44;
    State.IncCycles();
    // XCHG DI,BP (334B_3369 / 0x36819)
    ushort tmp_334B_3369 = DI;
    DI = BP;
    BP = tmp_334B_3369;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_336B / 0x3681B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XCHG DI,BP (334B_336D / 0x3681D)
    ushort tmp_334B_336D = DI;
    DI = BP;
    BP = tmp_334B_336D;
    State.IncCycles();
    // MOV CL,0x44 (334B_336F / 0x3681F)
    CL = 0x44;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (334B_3371 / 0x36821)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB DI,0x1c8 (334B_3373 / 0x36823)
    DI -= 0x1C8;
    State.IncCycles();
    // ADD BP,0xb8 (334B_3377 / 0x36827)
    BP += 0xB8;
    State.IncCycles();
    // CMP DI,0xc6c0 (334B_337B / 0x3682B)
    Alu.Sub16(DI, 0xC6C0);
    State.IncCycles();
    // JNC 0x3000:6817 (334B_337F / 0x3682F)
    if(!CarryFlag) {
      goto label_334B_3367_36817;
    }
    State.IncCycles();
    // RET  (334B_3381 / 0x36831)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3382_036832(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3382_36832:
    // CMP CX,0x11 (334B_3382 / 0x36832)
    Alu.Sub16(CX, 0x11);
    State.IncCycles();
    // JNZ 0x3000:6853 (334B_3385 / 0x36835)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_334B_33A3_036853, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH CX (334B_3387 / 0x36837)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (334B_3388 / 0x36838)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (334B_3389 / 0x36839)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_338A / 0x3683A)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH ES (334B_338B / 0x3683B)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH SI (334B_338C / 0x3683C)
    Stack.Push(SI);
    State.IncCycles();
    // POP ES (334B_338D / 0x3683D)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_338E / 0x3683E)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV DX,0x5c (334B_338F / 0x3683F)
    DX = 0x5C;
    State.IncCycles();
    // MOV BX,0x9f (334B_3392 / 0x36842)
    BX = 0x9F;
    State.IncCycles();
    // MOV BP,0x88 (334B_3395 / 0x36845)
    BP = 0x88;
    State.IncCycles();
    // MOV AX,0x29 (334B_3398 / 0x36848)
    AX = 0x29;
    State.IncCycles();
    // PUSH CS (334B_339B / 0x3684B)
    Stack.Push(cs2);
    State.IncCycles();
    // CALL 0x3000:503e (334B_339C / 0x3684C)
    NearCall(cs2, 0x339F, spice86_generated_label_call_target_334B_1B8E_03503E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_339F_03684F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_339F_03684F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_339F_3684F:
    // POP ES (334B_339F / 0x3684F)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (334B_33A0 / 0x36850)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_33A1 / 0x36851)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_33A2 / 0x36852)
    CX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_334B_33A3_036853, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_33A3_036853(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_33A3_36853:
    // CMP CL,0x9 (334B_33A3 / 0x36853)
    Alu.Sub8(CL, 0x9);
    State.IncCycles();
    // JC 0x3000:685a (334B_33A6 / 0x36856)
    if(CarryFlag) {
      goto label_334B_33AA_3685A;
    }
    State.IncCycles();
    // PUSH SI (334B_33A8 / 0x36858)
    Stack.Push(SI);
    State.IncCycles();
    // POP DS (334B_33A9 / 0x36859)
    DS = Stack.Pop();
    State.IncCycles();
    label_334B_33AA_3685A:
    // PUSH CX (334B_33AA / 0x3685A)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BX,CX (334B_33AB / 0x3685B)
    BX = CX;
    State.IncCycles();
    // SHL BX,1 (334B_33AD / 0x3685D)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV AX,word ptr CS:[BX + 0x30f0] (334B_33AF / 0x3685F)
    AX = UInt16[cs2, (ushort)(BX + 0x30F0)];
    State.IncCycles();
    // CALL 0x3000:6771 (334B_33B4 / 0x36864)
    NearCall(cs2, 0x33B7, spice86_generated_label_call_target_334B_32C1_036771);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_33B7_036867, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_33B7_036867(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_33B7_36867:
    // POP CX (334B_33B7 / 0x36867)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x3000:6879 (334B_33B8 / 0x36868)
    if(--CX != 0) {
      // LOOP target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_33C9 / 0x36879)
      return FarRet();
    }
    State.IncCycles();
    // MOV DX,0x5c (334B_33BA / 0x3686A)
    DX = 0x5C;
    State.IncCycles();
    // MOV BX,0x9f (334B_33BD / 0x3686D)
    BX = 0x9F;
    State.IncCycles();
    // MOV BP,0x88 (334B_33C0 / 0x36870)
    BP = 0x88;
    State.IncCycles();
    // MOV AX,0x29 (334B_33C3 / 0x36873)
    AX = 0x29;
    State.IncCycles();
    // JMP 0x3000:503e (334B_33C6 / 0x36876)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_334B_33C9_36879:
    // RETF  (334B_33C9 / 0x36879)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_33CA_03687A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_33CA_3687A:
    // MOV BP,SI (334B_33CA / 0x3687A)
    BP = SI;
    State.IncCycles();
    // PUSH BP (334B_33CC / 0x3687C)
    Stack.Push(BP);
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x0] (334B_33CD / 0x3687D)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (334B_33D0 / 0x36880)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // SUB BX,0x2 (334B_33D3 / 0x36883)
    // BX -= 0x2;
    BX = Alu.Sub16(BX, 0x2);
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_33D6 / 0x36886)
    NearCall(cs2, 0x33D9, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_33D9_036889, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_33D9_036889(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_33D9_36889:
    // MOV SI,DI (334B_33D9 / 0x36889)
    SI = DI;
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x0] (334B_33DB / 0x3688B)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_33DE / 0x3688E)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_33E1 / 0x36891)
    NearCall(cs2, 0x33E4, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_33E4_036894, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_33E4_036894(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_33E4_36894:
    // MOV DX,word ptr [BP + 0x4] (334B_33E4 / 0x36894)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // SUB DX,word ptr [BP + 0x0] (334B_33E7 / 0x36897)
    DX -= UInt16[SS, BP];
    State.IncCycles();
    // SHR DX,1 (334B_33EA / 0x3689A)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    State.IncCycles();
    // MOV BX,0x2 (334B_33EC / 0x3689C)
    BX = 0x2;
    State.IncCycles();
    label_334B_33EF_3689F:
    // PUSH BX (334B_33EF / 0x3689F)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH SI (334B_33F0 / 0x368A0)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_33F1 / 0x368A1)
    Stack.Push(DI);
    State.IncCycles();
    // MOV AX,DX (334B_33F2 / 0x368A2)
    AX = DX;
    State.IncCycles();
    // ADD AX,AX (334B_33F4 / 0x368A4)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    label_334B_33F6_368A6:
    // MOV CX,DX (334B_33F6 / 0x368A6)
    CX = DX;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_33F8 / 0x368A8)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB SI,AX (334B_33FA / 0x368AA)
    SI -= AX;
    State.IncCycles();
    // SUB DI,AX (334B_33FC / 0x368AC)
    DI -= AX;
    State.IncCycles();
    // ADD DI,0x140 (334B_33FE / 0x368AE)
    DI += 0x140;
    State.IncCycles();
    // ADD SI,0x140 (334B_3402 / 0x368B2)
    SI += 0x140;
    State.IncCycles();
    // DEC BX (334B_3406 / 0x368B6)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:68a6 (334B_3407 / 0x368B7)
    if(!ZeroFlag) {
      goto label_334B_33F6_368A6;
    }
    State.IncCycles();
    // POP DI (334B_3409 / 0x368B9)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_340A / 0x368BA)
    SI = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_340B / 0x368BB)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD BX,0x2 (334B_340C / 0x368BC)
    BX += 0x2;
    State.IncCycles();
    // SUB SI,0x280 (334B_340F / 0x368BF)
    // SI -= 0x280;
    SI = Alu.Sub16(SI, 0x280);
    State.IncCycles();
    // JNC 0x3000:689f (334B_3413 / 0x368C3)
    if(!CarryFlag) {
      goto label_334B_33EF_3689F;
    }
    State.IncCycles();
    // POP BP (334B_3415 / 0x368C5)
    BP = Stack.Pop();
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x0] (334B_3416 / 0x368C6)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_3419 / 0x368C9)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x6] (334B_341C / 0x368CC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // MOV BP,word ptr [BP + 0x4] (334B_341F / 0x368CF)
    BP = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // SUB BP,DX (334B_3422 / 0x368D2)
    BP -= DX;
    State.IncCycles();
    // SUB AX,BX (334B_3424 / 0x368D4)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JMP 0x3000:503e (334B_3426 / 0x368D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_334B_1B8E_03503E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3429_0368D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3429_368D9:
    // MOV BP,SI (334B_3429 / 0x368D9)
    BP = SI;
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x0] (334B_342B / 0x368DB)
    DX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (334B_342E / 0x368DE)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_3431 / 0x368E1)
    NearCall(cs2, 0x3434, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3434_0368E4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_3434_0368E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3434_368E4:
    // MOV DX,word ptr [BP + 0x4] (334B_3434 / 0x368E4)
    DX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // SUB DX,word ptr [BP + 0x0] (334B_3437 / 0x368E7)
    DX -= UInt16[SS, BP];
    State.IncCycles();
    // SHR DX,1 (334B_343A / 0x368EA)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (334B_343C / 0x368EC)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // SUB BX,word ptr [BP + 0x2] (334B_343F / 0x368EF)
    BX -= UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // SUB BX,0x6 (334B_3442 / 0x368F2)
    // BX -= 0x6;
    BX = Alu.Sub16(BX, 0x6);
    State.IncCycles();
    label_334B_3445_368F5:
    // PUSH BX (334B_3445 / 0x368F5)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DI (334B_3446 / 0x368F6)
    Stack.Push(DI);
    State.IncCycles();
    // MOV AX,DX (334B_3447 / 0x368F7)
    AX = DX;
    State.IncCycles();
    // ADD AX,AX (334B_3449 / 0x368F9)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    // OR BX,BX (334B_344B / 0x368FB)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x3000:6914 (334B_344D / 0x368FD)
    if(ZeroFlag) {
      goto label_334B_3464_36914;
    }
    State.IncCycles();
    // PUSH DS (334B_344F / 0x368FF)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (334B_3450 / 0x36900)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (334B_3451 / 0x36901)
    DS = Stack.Pop();
    State.IncCycles();
    label_334B_3452_36902:
    // MOV CX,DX (334B_3452 / 0x36902)
    CX = DX;
    State.IncCycles();
    // LEA SI,[DI + 0x780] (334B_3454 / 0x36904)
    SI = (ushort)(DI + 0x780);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_3458 / 0x36908)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB DI,AX (334B_345A / 0x3690A)
    DI -= AX;
    State.IncCycles();
    // ADD DI,0x140 (334B_345C / 0x3690C)
    DI += 0x140;
    State.IncCycles();
    // DEC BX (334B_3460 / 0x36910)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:6902 (334B_3461 / 0x36911)
    if(!ZeroFlag) {
      goto label_334B_3452_36902;
    }
    State.IncCycles();
    // POP DS (334B_3463 / 0x36913)
    DS = Stack.Pop();
    State.IncCycles();
    label_334B_3464_36914:
    // MOV BX,0x6 (334B_3464 / 0x36914)
    BX = 0x6;
    State.IncCycles();
    label_334B_3467_36917:
    // MOV CX,DX (334B_3467 / 0x36917)
    CX = DX;
    State.IncCycles();
    // MOV SI,DI (334B_3469 / 0x36919)
    SI = DI;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (334B_346B / 0x3691B)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // SUB DI,AX (334B_346D / 0x3691D)
    DI -= AX;
    State.IncCycles();
    // ADD DI,0x140 (334B_346F / 0x3691F)
    DI += 0x140;
    State.IncCycles();
    // DEC BX (334B_3473 / 0x36923)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:6917 (334B_3474 / 0x36924)
    if(!ZeroFlag) {
      goto label_334B_3467_36917;
    }
    State.IncCycles();
    // POP DI (334B_3476 / 0x36926)
    DI = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_3477 / 0x36927)
    BX = Stack.Pop();
    State.IncCycles();
    // SUB BX,0x6 (334B_3478 / 0x36928)
    // BX -= 0x6;
    BX = Alu.Sub16(BX, 0x6);
    State.IncCycles();
    // JNC 0x3000:68f5 (334B_347B / 0x3692B)
    if(!CarryFlag) {
      goto label_334B_3445_368F5;
    }
    State.IncCycles();
    // CMP BX,-0x6 (334B_347D / 0x3692D)
    Alu.Sub16(BX, 0xFFFA);
    State.IncCycles();
    // MOV BX,0x0 (334B_3480 / 0x36930)
    BX = 0x0;
    State.IncCycles();
    // JNZ 0x3000:68f5 (334B_3483 / 0x36933)
    if(!ZeroFlag) {
      goto label_334B_3445_368F5;
    }
    State.IncCycles();
    // RETF  (334B_3485 / 0x36935)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3581_036A31(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3581_36A31:
    // MOV DX,word ptr SS:[SI] (334B_3581 / 0x36A31)
    DX = UInt16[SS, SI];
    State.IncCycles();
    // MOV BX,word ptr SS:[SI + 0x2] (334B_3584 / 0x36A34)
    BX = UInt16[SS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // CALL 0x3000:40c0 (334B_3588 / 0x36A38)
    NearCall(cs2, 0x358B, spice86_generated_label_call_target_334B_0C10_0340C0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_358B_036A3B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_358B_036A3B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x26A56: goto label_334B_35A6_36A56;break; // Target of external jump from 0x36A74
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_334B_358B_36A3B:
    // MOV DX,word ptr SS:[SI + 0x4] (334B_358B / 0x36A3B)
    DX = UInt16[SS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // SUB DX,word ptr SS:[SI] (334B_358F / 0x36A3F)
    DX -= UInt16[SS, SI];
    State.IncCycles();
    // SHR DX,1 (334B_3592 / 0x36A42)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    State.IncCycles();
    // MOV BX,word ptr SS:[SI + 0x6] (334B_3594 / 0x36A44)
    BX = UInt16[SS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // SUB BX,word ptr SS:[SI + 0x2] (334B_3598 / 0x36A48)
    BX -= UInt16[SS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SHR BX,1 (334B_359C / 0x36A4C)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    // JZ 0x3000:6a77 (334B_359E / 0x36A4E)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      State.IncCycles();
      // RETF  (334B_35C7 / 0x36A77)
      return FarRet();
    }
    State.IncCycles();
    // PUSH word ptr [BP + 0x0] (334B_35A0 / 0x36A50)
    Stack.Push(UInt16[SS, BP]);
    State.IncCycles();
    label_334B_35A3_36A53:
    // MOV SI,0x2fb7 (334B_35A3 / 0x36A53)
    SI = 0x2FB7;
    State.IncCycles();
    label_334B_35A6_36A56:
    // LODSW CS:SI (334B_35A6 / 0x36A56)
    AX = UInt16[cs2, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (334B_35A8 / 0x36A58)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x3000:6a53 (334B_35AA / 0x36A5A)
    if(SignFlag) {
      goto label_334B_35A3_36A53;
    }
    State.IncCycles();
    // PUSH BX (334B_35AC / 0x36A5C)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (334B_35AD / 0x36A5D)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (334B_35AE / 0x36A5E)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (334B_35AF / 0x36A5F)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_35B0 / 0x36A60)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (334B_35B1 / 0x36A61)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x3000:6a78 (334B_35B2 / 0x36A62)
    NearCall(cs2, 0x35B5, spice86_generated_label_call_target_334B_35C8_036A78);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_35B5_036A65, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_334B_35B5_036A65(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_35B5_36A65:
    // POP BP (334B_35B5 / 0x36A65)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (334B_35B6 / 0x36A66)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_35B7 / 0x36A67)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (334B_35B8 / 0x36A68)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (334B_35B9 / 0x36A69)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (334B_35BA / 0x36A6A)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (334B_35BB / 0x36A6B)
    AX = Stack.Pop();
    State.IncCycles();
    // PUSH AX (334B_35BC / 0x36A6C)
    Stack.Push(AX);
    State.IncCycles();
    // SUB AX,word ptr [BP + 0x0] (334B_35BD / 0x36A6D)
    AX -= UInt16[SS, BP];
    State.IncCycles();
    // NEG AX (334B_35C0 / 0x36A70)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // CMP AX,CX (334B_35C2 / 0x36A72)
    Alu.Sub16(AX, CX);
    State.IncCycles();
    // JC 0x3000:6a56 (334B_35C4 / 0x36A74)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_358B_036A3B, 0x36A56 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // POP AX (334B_35C6 / 0x36A76)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_334B_35C7_036A77, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_334B_35C7_036A77(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_35C7_36A77:
    // RETF  (334B_35C7 / 0x36A77)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_334B_35C8_036A78(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_35C8_36A78:
    // MOV SI,DI (334B_35C8 / 0x36A78)
    SI = DI;
    State.IncCycles();
    // ADD SI,AX (334B_35CA / 0x36A7A)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    label_334B_35CC_36A7C:
    // PUSH SI (334B_35CC / 0x36A7C)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (334B_35CD / 0x36A7D)
    Stack.Push(DI);
    State.IncCycles();
    // MOV CX,DX (334B_35CE / 0x36A7E)
    CX = DX;
    State.IncCycles();
    label_334B_35D0_36A80:
    // LODSB SI (334B_35D0 / 0x36A80)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // INC SI (334B_35D1 / 0x36A81)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV AH,AL (334B_35D2 / 0x36A82)
    AH = AL;
    State.IncCycles();
    // MOV word ptr ES:[DI + 0x140],AX (334B_35D4 / 0x36A84)
    UInt16[ES, (ushort)(DI + 0x140)] = AX;
    State.IncCycles();
    // STOSW ES:DI (334B_35D9 / 0x36A89)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LOOP 0x3000:6a80 (334B_35DA / 0x36A8A)
    if(--CX != 0) {
      goto label_334B_35D0_36A80;
    }
    State.IncCycles();
    // POP DI (334B_35DC / 0x36A8C)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (334B_35DD / 0x36A8D)
    SI = Stack.Pop();
    State.IncCycles();
    // ADD SI,0x280 (334B_35DE / 0x36A8E)
    SI += 0x280;
    State.IncCycles();
    // ADD DI,0x280 (334B_35E2 / 0x36A92)
    DI += 0x280;
    State.IncCycles();
    // DEC BX (334B_35E6 / 0x36A96)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x3000:6a7c (334B_35E7 / 0x36A97)
    if(!ZeroFlag) {
      goto label_334B_35CC_36A7C;
    }
    State.IncCycles();
    // RET  (334B_35E9 / 0x36A99)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_334B_3602_036AB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_334B_3602_36AB2:
    // PUSH DS (334B_3602 / 0x36AB2)
    Stack.Push(DS);
    State.IncCycles();
    // LODSW SI (334B_3603 / 0x36AB3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (334B_3604 / 0x36AB4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x3000:6aba (334B_3606 / 0x36AB6)
    if(!SignFlag) {
      goto label_334B_360A_36ABA;
    }
    State.IncCycles();
    // XOR AX,AX (334B_3608 / 0x36AB8)
    AX = 0;
    State.IncCycles();
    label_334B_360A_36ABA:
    // CMP AX,0x12c (334B_360A / 0x36ABA)
    Alu.Sub16(AX, 0x12C);
    State.IncCycles();
    // JC 0x3000:6ac2 (334B_360D / 0x36ABD)
    if(CarryFlag) {
      goto label_334B_3612_36AC2;
    }
    State.IncCycles();
    // MOV AX,0x12c (334B_360F / 0x36ABF)
    AX = 0x12C;
    State.IncCycles();
    label_334B_3612_36AC2:
    // MOV CS:[0x35f2],AX (334B_3612 / 0x36AC2)
    UInt16[cs2, 0x35F2] = AX;
    State.IncCycles();
    // PUSH AX (334B_3616 / 0x36AC6)
    Stack.Push(AX);
    State.IncCycles();
    // LODSW SI (334B_3617 / 0x36AC7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (334B_3618 / 0x36AC8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x3000:6ace (334B_361A / 0x36ACA)
    if(!SignFlag) {
      goto label_334B_361E_36ACE;
    }
    State.IncCycles();
    // XOR AX,AX (334B_361C / 0x36ACC)
    AX = 0;
    State.IncCycles();
    label_334B_361E_36ACE:
    // MOV CS:[0x35f4],AX (334B_361E / 0x36ACE)
    UInt16[cs2, 0x35F4] = AX;
    State.IncCycles();
    // PUSH AX (334B_3622 / 0x36AD2)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x3000:6b60 (334B_3623 / 0x36AD3)
    NearCall(cs2, 0x3626, spice86_generated_label_call_target_334B_36B0_036B60);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_334B_3626_036AD6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
