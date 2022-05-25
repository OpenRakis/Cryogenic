namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action not_observed_1000_21FA_0121FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_21FA_121FA:
    // MOV BX,0xa (1000_21FA / 0x121FA)
    BX = 0xA;
    State.IncCycles();
    // CALL 0x1000:e3df (1000_21FD / 0x121FD)
    NearCall(cs1, 0x2200, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    State.IncCycles();
    // ADD AL,0x2 (1000_2200 / 0x12200)
    AL += 0x2;
    State.IncCycles();
    // CMP byte ptr [0x2a],0x54 (1000_2202 / 0x12202)
    Alu.Sub8(UInt8[DS, 0x2A], 0x54);
    State.IncCycles();
    // JNC 0x1000:221c (1000_2207 / 0x12207)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_221C / 0x1221C)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0x3 (1000_2209 / 0x12209)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JZ 0x1000:21fa (1000_220B / 0x1220B)
    if(ZeroFlag) {
      goto label_1000_21FA_121FA;
    }
    State.IncCycles();
    // CMP byte ptr [0x2a],0x24 (1000_220D / 0x1220D)
    Alu.Sub8(UInt8[DS, 0x2A], 0x24);
    State.IncCycles();
    // JNC 0x1000:221c (1000_2212 / 0x12212)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_221C / 0x1221C)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0xb (1000_2214 / 0x12214)
    Alu.Sub8(AL, 0xB);
    State.IncCycles();
    // JZ 0x1000:21fa (1000_2216 / 0x12216)
    if(ZeroFlag) {
      goto label_1000_21FA_121FA;
    }
    State.IncCycles();
    // CMP AL,0x6 (1000_2218 / 0x12218)
    Alu.Sub8(AL, 0x6);
    State.IncCycles();
    // JZ 0x1000:21fa (1000_221A / 0x1221A)
    if(ZeroFlag) {
      goto label_1000_21FA_121FA;
    }
    State.IncCycles();
    label_1000_221C_1221C:
    // RET  (1000_221C / 0x1221C)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_221D_01221D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_221D_1221D:
    // PUSH CX (1000_221D / 0x1221D)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_221E / 0x1221E)
    Stack.Push(SI);
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_221F / 0x1221F)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // CALL 0x1000:5344 (1000_2221 / 0x12221)
    NearCall(cs1, 0x2224, not_observed_1000_5344_015344);
    State.IncCycles();
    // CALL 0x1000:40ae (1000_2224 / 0x12224)
    NearCall(cs1, 0x2227, spice86_generated_label_call_target_1000_40AE_0140AE);
    State.IncCycles();
    // POP SI (1000_2227 / 0x12227)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_2228 / 0x12228)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_2229 / 0x12229)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],BX (1000_222B / 0x1222B)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    State.IncCycles();
    // CMP BH,byte ptr [0x9] (1000_222E / 0x1222E)
    Alu.Sub8(BH, UInt8[DS, 0x9]);
    State.IncCycles();
    // JNZ 0x1000:2238 (1000_2232 / 0x12232)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2238 / 0x12238)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [SI + 0xf],0x4 (1000_2234 / 0x12234)
    // UInt8[DS, (ushort)(SI + 0xF)] |= 0x4;
    UInt8[DS, (ushort)(SI + 0xF)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0xF)], 0x4);
    State.IncCycles();
    label_1000_2238_12238:
    // RET  (1000_2238 / 0x12238)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2318_012318(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2318_12318:
    // MOV AL,byte ptr [DI] (1000_2318 / 0x12318)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // MOV SI,0x10c7 (1000_231A / 0x1231A)
    SI = 0x10C7;
    State.IncCycles();
    label_1000_231D_1231D:
    // ADD SI,0x11 (1000_231D / 0x1231D)
    SI += 0x11;
    State.IncCycles();
    // CMP AL,byte ptr [SI] (1000_2320 / 0x12320)
    Alu.Sub8(AL, UInt8[DS, SI]);
    State.IncCycles();
    // JNZ 0x1000:231d (1000_2322 / 0x12322)
    if(!ZeroFlag) {
      goto label_1000_231D_1231D;
    }
    State.IncCycles();
    // CALL 0x1000:235f (1000_2324 / 0x12324)
    NearCall(cs1, 0x2327, not_observed_1000_235F_01235F);
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_2327 / 0x12327)
    NearCall(cs1, 0x232A, spice86_generated_label_call_target_1000_1AC5_011AC5);
    State.IncCycles();
    // SUB AL,byte ptr [SI + 0x3] (1000_232A / 0x1232A)
    AL -= UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // TEST byte ptr [SI + 0x2],0x8 (1000_232D / 0x1232D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    State.IncCycles();
    // JNZ 0x1000:2339 (1000_2331 / 0x12331)
    if(!ZeroFlag) {
      goto label_1000_2339_12339;
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_2333 / 0x12333)
    AL = 0x1;
    State.IncCycles();
    // OR byte ptr [SI + 0x2],0x8 (1000_2335 / 0x12335)
    // UInt8[DS, (ushort)(SI + 0x2)] |= 0x8;
    UInt8[DS, (ushort)(SI + 0x2)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    State.IncCycles();
    label_1000_2339_12339:
    // MOV [0x1e],AL (1000_2339 / 0x12339)
    UInt8[DS, 0x1E] = AL;
    State.IncCycles();
    // MOV byte ptr [0x9d],0x0 (1000_233C / 0x1233C)
    UInt8[DS, 0x9D] = 0x0;
    State.IncCycles();
    // MOV AX,[0x0] (1000_2341 / 0x12341)
    AX = UInt16[DS, 0x0];
    State.IncCycles();
    // AND AX,0x7 (1000_2344 / 0x12344)
    AX &= 0x7;
    State.IncCycles();
    label_1000_2347_12347:
    // CMP AL,byte ptr [0x1141] (1000_2347 / 0x12347)
    Alu.Sub8(AL, UInt8[DS, 0x1141]);
    State.IncCycles();
    // JC 0x1000:2353 (1000_234B / 0x1234B)
    if(CarryFlag) {
      goto label_1000_2353_12353;
    }
    State.IncCycles();
    // SUB AL,byte ptr [0x1141] (1000_234D / 0x1234D)
    // AL -= UInt8[DS, 0x1141];
    AL = Alu.Sub8(AL, UInt8[DS, 0x1141]);
    State.IncCycles();
    // JMP 0x1000:2347 (1000_2351 / 0x12351)
    goto label_1000_2347_12347;
    State.IncCycles();
    label_1000_2353_12353:
    // ADD AX,0xe8 (1000_2353 / 0x12353)
    // AX += 0xE8;
    AX = Alu.Add16(AX, 0xE8);
    State.IncCycles();
    // MOV [0x11f1],AX (1000_2356 / 0x12356)
    UInt16[DS, 0x11F1] = AX;
    State.IncCycles();
    // MOV byte ptr [0x9f],0x0 (1000_2359 / 0x12359)
    UInt8[DS, 0x9F] = 0x0;
    State.IncCycles();
    // RET  (1000_235E / 0x1235E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_235F_01235F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_235F_1235F:
    // MOV word ptr [0x10b4],SI (1000_235F / 0x1235F)
    UInt16[DS, 0x10B4] = SI;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x2] (1000_2363 / 0x12363)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV [0x1c],AL (1000_2366 / 0x12366)
    UInt8[DS, 0x1C] = AL;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0xe] (1000_2369 / 0x12369)
    AX = UInt16[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV [0x20],AX (1000_236C / 0x1236C)
    UInt16[DS, 0x20] = AX;
    State.IncCycles();
    // MOV byte ptr [0x1f],0x0 (1000_236F / 0x1236F)
    UInt8[DS, 0x1F] = 0x0;
    State.IncCycles();
    // OR AX,AX (1000_2374 / 0x12374)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:2381 (1000_2376 / 0x12376)
    if(ZeroFlag) {
      goto label_1000_2381_12381;
    }
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_2378 / 0x12378)
    NearCall(cs1, 0x237B, spice86_generated_label_call_target_1000_1AC5_011AC5);
    State.IncCycles();
    // SUB AL,byte ptr [SI + 0x10] (1000_237B / 0x1237B)
    // AL -= UInt8[DS, (ushort)(SI + 0x10)];
    AL = Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x10)]);
    State.IncCycles();
    // MOV [0x1f],AL (1000_237E / 0x1237E)
    UInt8[DS, 0x1F] = AL;
    State.IncCycles();
    label_1000_2381_12381:
    // MOV AL,byte ptr [SI + 0x1] (1000_2381 / 0x12381)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // MOV [0x1d],AL (1000_2384 / 0x12384)
    UInt8[DS, 0x1D] = AL;
    State.IncCycles();
    // RET  (1000_2387 / 0x12387)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_24A3_0124A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_24A3_124A3:
    // CMP byte ptr [0x2a],0x10 (1000_24A3 / 0x124A3)
    Alu.Sub8(UInt8[DS, 0x2A], 0x10);
    State.IncCycles();
    // JNC 0x1000:24b0 (1000_24A8 / 0x124A8)
    if(!CarryFlag) {
      goto label_1000_24B0_124B0;
    }
    State.IncCycles();
    // OR byte ptr [0xff7],0x10 (1000_24AA / 0x124AA)
    // UInt8[DS, 0xFF7] |= 0x10;
    UInt8[DS, 0xFF7] = Alu.Or8(UInt8[DS, 0xFF7], 0x10);
    State.IncCycles();
    // RET  (1000_24AF / 0x124AF)
    return NearRet();
    State.IncCycles();
    label_1000_24B0_124B0:
    // CALL 0x1000:a1e8 (1000_24B0 / 0x124B0)
    NearCall(cs1, 0x24B3, spice86_generated_label_call_target_1000_A1E8_01A1E8);
    State.IncCycles();
    // MOV word ptr [0xc0],0x0 (1000_24B3 / 0x124B3)
    UInt16[DS, 0xC0] = 0x0;
    State.IncCycles();
    // OR byte ptr [0xbf],0x1 (1000_24B9 / 0x124B9)
    // UInt8[DS, 0xBF] |= 0x1;
    UInt8[DS, 0xBF] = Alu.Or8(UInt8[DS, 0xBF], 0x1);
    State.IncCycles();
    // CALL 0x1000:24d2 (1000_24BE / 0x124BE)
    NearCall(cs1, 0x24C1, not_observed_1000_24D2_0124D2);
    State.IncCycles();
    // ADD AH,0x7 (1000_24C1 / 0x124C1)
    // AH += 0x7;
    AH = Alu.Add8(AH, 0x7);
    State.IncCycles();
    // MOV AL,0xb (1000_24C4 / 0x124C4)
    AL = 0xB;
    State.IncCycles();
    // CMP AH,0xc (1000_24C6 / 0x124C6)
    Alu.Sub8(AH, 0xC);
    State.IncCycles();
    // JNZ 0x1000:24cf (1000_24C9 / 0x124C9)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:26da (1000_24CF / 0x124CF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // INC byte ptr [0x11bb] (1000_24CB / 0x124CB)
    UInt8[DS, 0x11BB] = Alu.Inc8(UInt8[DS, 0x11BB]);
    State.IncCycles();
    label_1000_24CF_124CF:
    // JMP 0x1000:26da (1000_24CF / 0x124CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_24D2_0124D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_24D2_124D2:
    // MOV AL,[0xbe] (1000_24D2 / 0x124D2)
    AL = UInt8[DS, 0xBE];
    State.IncCycles();
    // XOR CL,CL (1000_24D5 / 0x124D5)
    CL = 0;
    State.IncCycles();
    // XOR AH,AH (1000_24D7 / 0x124D7)
    AH = 0;
    State.IncCycles();
    // CMP AL,0x1 (1000_24D9 / 0x124D9)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // ADC AH,CL (1000_24DB / 0x124DB)
    AH = Alu.Adc8(AH, CL);
    State.IncCycles();
    // CMP AL,0x40 (1000_24DD / 0x124DD)
    Alu.Sub8(AL, 0x40);
    State.IncCycles();
    // ADC AH,CL (1000_24DF / 0x124DF)
    AH = Alu.Adc8(AH, CL);
    State.IncCycles();
    // CMP AL,0x80 (1000_24E1 / 0x124E1)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // ADC AH,CL (1000_24E3 / 0x124E3)
    AH = Alu.Adc8(AH, CL);
    State.IncCycles();
    // CMP AL,0x90 (1000_24E5 / 0x124E5)
    Alu.Sub8(AL, 0x90);
    State.IncCycles();
    // ADC AH,CL (1000_24E7 / 0x124E7)
    AH = Alu.Adc8(AH, CL);
    State.IncCycles();
    // CMP AL,0xff (1000_24E9 / 0x124E9)
    Alu.Sub8(AL, 0xFF);
    State.IncCycles();
    // ADC AH,CL (1000_24EB / 0x124EB)
    AH = Alu.Adc8(AH, CL);
    State.IncCycles();
    // RET  (1000_24ED / 0x124ED)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2524_012524(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2524_12524:
    // SUB word ptr [0xa0],AX (1000_2524 / 0x12524)
    UInt16[DS, 0xA0] -= AX;
    State.IncCycles();
    // ADD word ptr [0x1172],AX (1000_2528 / 0x12528)
    // UInt16[DS, 0x1172] += AX;
    UInt16[DS, 0x1172] = Alu.Add16(UInt16[DS, 0x1172], AX);
    State.IncCycles();
    // RET  (1000_252C / 0x1252C)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2566_012566(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2566_12566:
    // MOV SI,0x1008 (1000_2566 / 0x12566)
    SI = 0x1008;
    State.IncCycles();
    // PUSH AX (1000_2569 / 0x12569)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:40e6 (1000_256A / 0x1256A)
    NearCall(cs1, 0x256D, spice86_generated_label_call_target_1000_40E6_0140E6);
    State.IncCycles();
    // POP AX (1000_256D / 0x1256D)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV BX,AX (1000_256E / 0x1256E)
    BX = AX;
    State.IncCycles();
    // CALL 0x1000:2524 (1000_2570 / 0x12570)
    NearCall(cs1, 0x2573, not_observed_1000_2524_012524);
    State.IncCycles();
    // MOV AX,BX (1000_2573 / 0x12573)
    AX = BX;
    State.IncCycles();
    // XOR DX,DX (1000_2575 / 0x12575)
    DX = 0;
    State.IncCycles();
    // XCHG AH,AL (1000_2577 / 0x12577)
    byte tmp_1000_2577 = AH;
    AH = AL;
    AL = tmp_1000_2577;
    State.IncCycles();
    // XCHG DL,AL (1000_2579 / 0x12579)
    byte tmp_1000_2579 = DL;
    DL = AL;
    AL = tmp_1000_2579;
    State.IncCycles();
    // DIV word ptr [0xbc] (1000_257B / 0x1257B)
    Cpu.Div16(UInt16[DS, 0xBC]);
    State.IncCycles();
    // CMP AX,0x200 (1000_257F / 0x1257F)
    Alu.Sub16(AX, 0x200);
    State.IncCycles();
    // JC 0x1000:2587 (1000_2582 / 0x12582)
    if(CarryFlag) {
      goto label_1000_2587_12587;
    }
    State.IncCycles();
    // MOV AX,0x1ff (1000_2584 / 0x12584)
    AX = 0x1FF;
    State.IncCycles();
    label_1000_2587_12587:
    // SHR AX,1 (1000_2587 / 0x12587)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // JNZ 0x1000:258d (1000_2589 / 0x12589)
    if(!ZeroFlag) {
      goto label_1000_258D_1258D;
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_258B / 0x1258B)
    AL = 0x1;
    State.IncCycles();
    label_1000_258D_1258D:
    // MOV [0xbe],AL (1000_258D / 0x1258D)
    UInt8[DS, 0xBE] = AL;
    State.IncCycles();
    // MOV AH,0x40 (1000_2590 / 0x12590)
    AH = 0x40;
    State.IncCycles();
    // MOV BX,0x7 (1000_2592 / 0x12592)
    BX = 0x7;
    State.IncCycles();
    // CMP AL,0xc0 (1000_2595 / 0x12595)
    Alu.Sub8(AL, 0xC0);
    State.IncCycles();
    // JNC 0x1000:25b3 (1000_2597 / 0x12597)
    if(!CarryFlag) {
      goto label_1000_25B3_125B3;
    }
    State.IncCycles();
    // DEC BX (1000_2599 / 0x12599)
    BX--;
    State.IncCycles();
    // CMP AL,0x80 (1000_259A / 0x1259A)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JA 0x1000:25b3 (1000_259C / 0x1259C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_25B3_125B3;
    }
    State.IncCycles();
    // DEC BX (1000_259E / 0x1259E)
    BX--;
    State.IncCycles();
    // XOR AH,AH (1000_259F / 0x1259F)
    AH = 0;
    State.IncCycles();
    // CMP AL,0x80 (1000_25A1 / 0x125A1)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JZ 0x1000:25b3 (1000_25A3 / 0x125A3)
    if(ZeroFlag) {
      goto label_1000_25B3_125B3;
    }
    State.IncCycles();
    // DEC BX (1000_25A5 / 0x125A5)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // MOV AH,0x8 (1000_25A6 / 0x125A6)
    AH = 0x8;
    State.IncCycles();
    // TEST byte ptr [0xbf],AH (1000_25A8 / 0x125A8)
    Alu.And8(UInt8[DS, 0xBF], AH);
    State.IncCycles();
    // JZ 0x1000:25b3 (1000_25AC / 0x125AC)
    if(ZeroFlag) {
      goto label_1000_25B3_125B3;
    }
    State.IncCycles();
    // MOV byte ptr [0xbe],0x0 (1000_25AE / 0x125AE)
    UInt8[DS, 0xBE] = 0x0;
    State.IncCycles();
    label_1000_25B3_125B3:
    // OR AH,0x80 (1000_25B3 / 0x125B3)
    // AH |= 0x80;
    AH = Alu.Or8(AH, 0x80);
    State.IncCycles();
    // MOV byte ptr [0xbf],AH (1000_25B6 / 0x125B6)
    UInt8[DS, 0xBF] = AH;
    State.IncCycles();
    // MOV SI,0x118d (1000_25BA / 0x125BA)
    SI = 0x118D;
    State.IncCycles();
    // ADD word ptr [SI],BX (1000_25BD / 0x125BD)
    // UInt16[DS, SI] += BX;
    UInt16[DS, SI] = Alu.Add16(UInt16[DS, SI], BX);
    State.IncCycles();
    // MOV BL,byte ptr [0xc3] (1000_25BF / 0x125BF)
    BL = UInt8[DS, 0xC3];
    State.IncCycles();
    // SHR BL,1 (1000_25C3 / 0x125C3)
    BL >>= 0x1;
    State.IncCycles();
    // AND BX,0x3 (1000_25C5 / 0x125C5)
    // BX &= 0x3;
    BX = Alu.And16(BX, 0x3);
    State.IncCycles();
    // CALL 0x1000:e3b7 (1000_25C8 / 0x125C8)
    NearCall(cs1, 0x25CB, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    // ADD word ptr [SI],AX (1000_25CB / 0x125CB)
    // UInt16[DS, SI] += AX;
    UInt16[DS, SI] = Alu.Add16(UInt16[DS, SI], AX);
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_25CD / 0x125CD)
    NearCall(cs1, 0x25D0, spice86_generated_label_call_target_1000_1AC5_011AC5);
    State.IncCycles();
    // SUB AX,word ptr [SI] (1000_25D0 / 0x125D0)
    AX -= UInt16[DS, SI];
    State.IncCycles();
    // NEG AX (1000_25D2 / 0x125D2)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // MOV [0xcf],AL (1000_25D4 / 0x125D4)
    UInt8[DS, 0xCF] = AL;
    State.IncCycles();
    // MOV word ptr [0x1158],0x0 (1000_25D7 / 0x125D7)
    UInt16[DS, 0x1158] = 0x0;
    State.IncCycles();
    // CALL 0x1000:2806 (1000_25DD / 0x125DD)
    NearCall(cs1, 0x25E0, not_observed_1000_2806_012806);
    State.IncCycles();
    // CALL 0x1000:2795 (1000_25E0 / 0x125E0)
    NearCall(cs1, 0x25E3, not_observed_1000_2795_012795);
    State.IncCycles();
    // CALL 0x1000:c49a (1000_25E3 / 0x125E3)
    NearCall(cs1, 0x25E6, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    State.IncCycles();
    // MOV AX,0x2c (1000_25E6 / 0x125E6)
    AX = 0x2C;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_25E9 / 0x125E9)
    NearCall(cs1, 0x25EC, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_25EC / 0x125EC)
    NearCall(cs1, 0x25EF, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // MOV BP,0x2555 (1000_25EF / 0x125EF)
    BP = 0x2555;
    State.IncCycles();
    // MOV AL,0x8 (1000_25F2 / 0x125F2)
    AL = 0x8;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_25F4 / 0x125F4)
    NearCall(cs1, 0x25F7, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // MOV AX,0x64 (1000_25F7 / 0x125F7)
    AX = 0x64;
    State.IncCycles();
    // CALL 0x1000:ddb0 (1000_25FA / 0x125FA)
    NearCall(cs1, 0x25FD, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    State.IncCycles();
    // MOV CX,0x18 (1000_25FD / 0x125FD)
    CX = 0x18;
    State.IncCycles();
    // MOV BP,0xa44 (1000_2600 / 0x12600)
    BP = 0xA44;
    State.IncCycles();
    // MOV AL,0x6 (1000_2603 / 0x12603)
    AL = 0x6;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_2605 / 0x12605)
    NearCall(cs1, 0x2608, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // MOV CX,0x18 (1000_2608 / 0x12608)
    CX = 0x18;
    State.IncCycles();
    label_1000_260B_1260B:
    // PUSH CX (1000_260B / 0x1260B)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BP,0xa44 (1000_260C / 0x1260C)
    BP = 0xA44;
    State.IncCycles();
    // MOV AX,0xc (1000_260F / 0x1260F)
    AX = 0xC;
    State.IncCycles();
    // DEC CX (1000_2612 / 0x12612)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // CALL 0x1000:e353 (1000_2613 / 0x12613)
    NearCall(cs1, 0x2616, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    // POP CX (1000_2616 / 0x12616)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:260b (1000_2617 / 0x12617)
    if(--CX != 0) {
      goto label_1000_260B_1260B;
    }
    State.IncCycles();
    // MOV AX,0x27 (1000_2619 / 0x12619)
    AX = 0x27;
    State.IncCycles();
    // CALL 0x1000:ab4f (1000_261C / 0x1261C)
    NearCall(cs1, 0x261F, spice86_generated_label_call_target_1000_AB4F_01AB4F);
    State.IncCycles();
    // MOV SI,0x4c60 (1000_261F / 0x1261F)
    SI = 0x4C60;
    State.IncCycles();
    // MOV BP,0x15aa (1000_2622 / 0x12622)
    BP = 0x15AA;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd6] (1000_2625 / 0x12625)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALLF [0x3919] (1000_2629 / 0x12629)
    // Indirect call to [0x3919], generating possible targets from emulator records
    uint targetAddress_1000_2629 = (uint)(UInt16[DS, 0x391B] * 0x10 + UInt16[DS, 0x3919] - cs1 * 0x10);
    switch(targetAddress_1000_2629) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_2629));
        break;
    }
    State.IncCycles();
    // MOV AX,0xc8 (1000_262D / 0x1262D)
    AX = 0xC8;
    State.IncCycles();
    // CALL 0x1000:ddb0 (1000_2630 / 0x12630)
    NearCall(cs1, 0x2633, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    State.IncCycles();
    // CALL 0x1000:aba9 (1000_2633 / 0x12633)
    NearCall(cs1, 0x2636, spice86_generated_label_call_target_1000_ABA9_01ABA9);
    State.IncCycles();
    // MOV AL,0x1 (1000_2636 / 0x12636)
    AL = 0x1;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_2638 / 0x12638)
    NearCall(cs1, 0x263B, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    // MOV CX,0x1 (1000_263B / 0x1263B)
    CX = 0x1;
    State.IncCycles();
    label_1000_263E_1263E:
    // PUSH CX (1000_263E / 0x1263E)
    Stack.Push(CX);
    State.IncCycles();
    // MOV SI,0x15b2 (1000_263F / 0x1263F)
    SI = 0x15B2;
    State.IncCycles();
    label_1000_2642_12642:
    // PUSH SI (1000_2642 / 0x12642)
    Stack.Push(SI);
    State.IncCycles();
    // MOV BP,0x26ac (1000_2643 / 0x12643)
    BP = 0x26AC;
    State.IncCycles();
    // MOV AX,0xc (1000_2646 / 0x12646)
    AX = 0xC;
    State.IncCycles();
    // CALL 0x1000:e353 (1000_2649 / 0x12649)
    NearCall(cs1, 0x264C, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    // POP SI (1000_264C / 0x1264C)
    SI = Stack.Pop();
    State.IncCycles();
    // CMP SI,0x161e (1000_264D / 0x1264D)
    Alu.Sub16(SI, 0x161E);
    State.IncCycles();
    // JNZ 0x1000:2656 (1000_2651 / 0x12651)
    if(!ZeroFlag) {
      goto label_1000_2656_12656;
    }
    State.IncCycles();
    // CALL 0x1000:ac30 (1000_2653 / 0x12653)
    NearCall(cs1, 0x2656, spice86_generated_label_call_target_1000_AC30_01AC30);
    State.IncCycles();
    label_1000_2656_12656:
    // ADD SI,0x6 (1000_2656 / 0x12656)
    SI += 0x6;
    State.IncCycles();
    // CMP byte ptr [SI],0xff (1000_2659 / 0x12659)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:2642 (1000_265C / 0x1265C)
    if(!ZeroFlag) {
      goto label_1000_2642_12642;
    }
    State.IncCycles();
    // POP CX (1000_265E / 0x1265E)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:263e (1000_265F / 0x1265F)
    if(--CX != 0) {
      goto label_1000_263E_1263E;
    }
    State.IncCycles();
    // CALL 0x1000:26ac (1000_2661 / 0x12661)
    NearCall(cs1, 0x2664, not_observed_1000_26AC_0126AC);
    State.IncCycles();
    // XOR CX,CX (1000_2664 / 0x12664)
    CX = 0;
    State.IncCycles();
    label_1000_2666_12666:
    // INC CX (1000_2666 / 0x12666)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // PUSH CX (1000_2667 / 0x12667)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BP,0xa44 (1000_2668 / 0x12668)
    BP = 0xA44;
    State.IncCycles();
    // MOV AX,0xc (1000_266B / 0x1266B)
    AX = 0xC;
    State.IncCycles();
    // CALL 0x1000:e353 (1000_266E / 0x1266E)
    NearCall(cs1, 0x2671, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    // POP CX (1000_2671 / 0x12671)
    CX = Stack.Pop();
    State.IncCycles();
    // CMP CX,0x19 (1000_2672 / 0x12672)
    Alu.Sub16(CX, 0x19);
    State.IncCycles();
    // JC 0x1000:2666 (1000_2675 / 0x12675)
    if(CarryFlag) {
      goto label_1000_2666_12666;
    }
    State.IncCycles();
    // MOV byte ptr [0x47a9],0x1 (1000_2677 / 0x12677)
    UInt8[DS, 0x47A9] = 0x1;
    State.IncCycles();
    // MOV BP,0x2db1 (1000_267C / 0x1267C)
    BP = 0x2DB1;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_267F / 0x1267F)
    NearCall(cs1, 0x2682, spice86_generated_label_call_target_1000_C097_01C097);
    State.IncCycles();
    // MOV AX,0x2c (1000_2682 / 0x12682)
    AX = 0x2C;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_2685 / 0x12685)
    NearCall(cs1, 0x2688, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV AL,0x6 (1000_2688 / 0x12688)
    AL = 0x6;
    State.IncCycles();
    // MOV BP,0x2555 (1000_268A / 0x1268A)
    BP = 0x2555;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_268D / 0x1268D)
    NearCall(cs1, 0x2690, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // MOV BP,0x2db1 (1000_2690 / 0x12690)
    BP = 0x2DB1;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_2693 / 0x12693)
    NearCall(cs1, 0x2696, spice86_generated_label_call_target_1000_C097_01C097);
    State.IncCycles();
    // MOV byte ptr [0x47a9],0x0 (1000_2696 / 0x12696)
    UInt8[DS, 0x47A9] = 0x0;
    State.IncCycles();
    // MOV BP,0x26a6 (1000_269B / 0x1269B)
    BP = 0x26A6;
    State.IncCycles();
    // MOV AL,0x8 (1000_269E / 0x1269E)
    AL = 0x8;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_26A0 / 0x126A0)
    NearCall(cs1, 0x26A3, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // JMP 0x1000:2773 (1000_26A3 / 0x126A3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2773_012773, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_26AC_0126AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_26AC_126AC:
    // PUSH SI (1000_26AC / 0x126AC)
    Stack.Push(SI);
    State.IncCycles();
    // MOV BP,0x15aa (1000_26AD / 0x126AD)
    BP = 0x15AA;
    State.IncCycles();
    // MOV SI,0x4c60 (1000_26B0 / 0x126B0)
    SI = 0x4C60;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd6] (1000_26B3 / 0x126B3)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALLF [0x391d] (1000_26B7 / 0x126B7)
    // Indirect call to [0x391d], generating possible targets from emulator records
    uint targetAddress_1000_26B7 = (uint)(UInt16[DS, 0x391F] * 0x10 + UInt16[DS, 0x391D] - cs1 * 0x10);
    switch(targetAddress_1000_26B7) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_26B7));
        break;
    }
    State.IncCycles();
    // POP SI (1000_26BB / 0x126BB)
    SI = Stack.Pop();
    State.IncCycles();
    // LODSW SI (1000_26BC / 0x126BC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_26BD / 0x126BD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x1000:26cb (1000_26BF / 0x126BF)
    if(SignFlag) {
      goto label_1000_26CB_126CB;
    }
    State.IncCycles();
    // MOV BX,AX (1000_26C1 / 0x126C1)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_26C3 / 0x126C3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_26C4 / 0x126C4)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_26C6 / 0x126C6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AX,BX (1000_26C7 / 0x126C7)
    ushort tmp_1000_26C7 = AX;
    AX = BX;
    BX = tmp_1000_26C7;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_26C8 / 0x126C8)
    NearCall(cs1, 0x26CB, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_26CB_126CB:
    // MOV DX,0x7e (1000_26CB / 0x126CB)
    DX = 0x7E;
    State.IncCycles();
    // MOV BX,0x4c (1000_26CE / 0x126CE)
    BX = 0x4C;
    State.IncCycles();
    // MOV BP,0xc2 (1000_26D1 / 0x126D1)
    BP = 0xC2;
    State.IncCycles();
    // MOV AX,0x4c (1000_26D4 / 0x126D4)
    AX = 0x4C;
    State.IncCycles();
    // JMP 0x1000:c526 (1000_26D7 / 0x126D7)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0x1C526 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_26DA_0126DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_26DA_126DA:
    // CALL 0x1000:e270 (1000_26DA / 0x126DA)
    NearCall(cs1, 0x26DD, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // MOV CL,byte ptr [0xc8] (1000_26DD / 0x126DD)
    CL = UInt8[DS, 0xC8];
    State.IncCycles();
    // XOR CH,CH (1000_26E1 / 0x126E1)
    CH = 0;
    State.IncCycles();
    // JCXZ 0x1000:26f1 (1000_26E3 / 0x126E3)
    if(CX == 0) {
      goto label_1000_26F1_126F1;
    }
    State.IncCycles();
    // MOV SI,0x1179 (1000_26E5 / 0x126E5)
    SI = 0x1179;
    State.IncCycles();
    label_1000_26E8_126E8:
    // CMP AX,word ptr [SI] (1000_26E8 / 0x126E8)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JZ 0x1000:272b (1000_26EA / 0x126EA)
    if(ZeroFlag) {
      goto label_1000_272B_1272B;
    }
    State.IncCycles();
    // ADD SI,0x2 (1000_26EC / 0x126EC)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // LOOP 0x1000:26e8 (1000_26EF / 0x126EF)
    if(--CX != 0) {
      goto label_1000_26E8_126E8;
    }
    State.IncCycles();
    label_1000_26F1_126F1:
    // MOV CL,byte ptr [0xc8] (1000_26F1 / 0x126F1)
    CL = UInt8[DS, 0xC8];
    State.IncCycles();
    // MOV SI,0x1179 (1000_26F5 / 0x126F5)
    SI = 0x1179;
    State.IncCycles();
    // CMP CL,0xa (1000_26F8 / 0x126F8)
    Alu.Sub8(CL, 0xA);
    State.IncCycles();
    // JC 0x1000:2707 (1000_26FB / 0x126FB)
    if(CarryFlag) {
      goto label_1000_2707_12707;
    }
    State.IncCycles();
    // PUSH AX (1000_26FD / 0x126FD)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:272f (1000_26FE / 0x126FE)
    NearCall(cs1, 0x2701, not_observed_1000_272F_01272F);
    State.IncCycles();
    // MOV CL,0x9 (1000_2701 / 0x12701)
    CL = 0x9;
    State.IncCycles();
    // MOV SI,0x1179 (1000_2703 / 0x12703)
    SI = 0x1179;
    State.IncCycles();
    // POP AX (1000_2706 / 0x12706)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_2707_12707:
    // ADD CL,CL (1000_2707 / 0x12707)
    CL += CL;
    State.IncCycles();
    // XOR CH,CH (1000_2709 / 0x12709)
    CH = 0;
    State.IncCycles();
    // ADD SI,CX (1000_270B / 0x1270B)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // MOV word ptr [SI],AX (1000_270D / 0x1270D)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    // INC byte ptr [0xc8] (1000_270F / 0x1270F)
    UInt8[DS, 0xC8]++;
    State.IncCycles();
    // INC byte ptr [0xc9] (1000_2713 / 0x12713)
    UInt8[DS, 0xC9]++;
    State.IncCycles();
    // CMP byte ptr [0x2a],0x38 (1000_2717 / 0x12717)
    Alu.Sub8(UInt8[DS, 0x2A], 0x38);
    State.IncCycles();
    // JC 0x1000:272b (1000_271C / 0x1271C)
    if(CarryFlag) {
      goto label_1000_272B_1272B;
    }
    State.IncCycles();
    // CMP byte ptr [0xb],0x8 (1000_271E / 0x1271E)
    Alu.Sub8(UInt8[DS, 0xB], 0x8);
    State.IncCycles();
    // JZ 0x1000:272b (1000_2723 / 0x12723)
    if(ZeroFlag) {
      goto label_1000_272B_1272B;
    }
    State.IncCycles();
    // MOV AX,0x201 (1000_2725 / 0x12725)
    AX = 0x201;
    State.IncCycles();
    // CALL 0x1000:29ee (1000_2728 / 0x12728)
    NearCall(cs1, 0x272B, not_observed_1000_29EE_0129EE);
    State.IncCycles();
    label_1000_272B_1272B:
    // CALL 0x1000:e283 (1000_272B / 0x1272B)
    NearCall(cs1, 0x272E, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // RET  (1000_272E / 0x1272E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_272F_01272F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_272F_1272F:
    // MOV CL,byte ptr [0xc8] (1000_272F / 0x1272F)
    CL = UInt8[DS, 0xC8];
    State.IncCycles();
    // XOR CH,CH (1000_2733 / 0x12733)
    CH = 0;
    State.IncCycles();
    // JCXZ 0x1000:274d (1000_2735 / 0x12735)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_274D / 0x1274D)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x1179 (1000_2737 / 0x12737)
    SI = 0x1179;
    State.IncCycles();
    // DEC byte ptr [0xc8] (1000_273A / 0x1273A)
    UInt8[DS, 0xC8] = Alu.Dec8(UInt8[DS, 0xC8]);
    State.IncCycles();
    // MOV DI,SI (1000_273E / 0x1273E)
    DI = SI;
    State.IncCycles();
    // ADD SI,0x2 (1000_2740 / 0x12740)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // PUSH DS (1000_2743 / 0x12743)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_2744 / 0x12744)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x9 (1000_2745 / 0x12745)
    CX = 0x9;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_2748 / 0x12748)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XOR AX,AX (1000_274A / 0x1274A)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_274C / 0x1274C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    label_1000_274D_1274D:
    // RET  (1000_274D / 0x1274D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_274E_01274E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_274E_1274E:
    // CALL 0x1000:c08e (1000_274E / 0x1274E)
    NearCall(cs1, 0x2751, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // MOV AX,0x15 (1000_2751 / 0x12751)
    AX = 0x15;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_2754 / 0x12754)
    NearCall(cs1, 0x2757, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV SI,0x14c8 (1000_2757 / 0x12757)
    SI = 0x14C8;
    State.IncCycles();
    // CALL 0x1000:c21b (1000_275A / 0x1275A)
    NearCall(cs1, 0x275D, spice86_generated_label_call_target_1000_C21B_01C21B);
    State.IncCycles();
    // MOV AL,0x1 (1000_275D / 0x1275D)
    AL = 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_275F_01275F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_275F_01275F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_275F_1275F:
    // CALL 0x1000:c08e (1000_275F / 0x1275F)
    NearCall(cs1, 0x2762, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // AND AX,0x7 (1000_2762 / 0x12762)
    AX &= 0x7;
    State.IncCycles();
    // ADD AL,0xb (1000_2765 / 0x12765)
    // AL += 0xB;
    AL = Alu.Add8(AL, 0xB);
    State.IncCycles();
    // MOV BX,0x56 (1000_2767 / 0x12767)
    BX = 0x56;
    State.IncCycles();
    // MOV DX,0x64 (1000_276A / 0x1276A)
    DX = 0x64;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_276D / 0x1276D)
    NearCall(cs1, 0x2770, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    // JMP 0x1000:c07c (1000_2770 / 0x12770)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2773_012773(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2773_12773:
    // MOV AX,0x15 (1000_2773 / 0x12773)
    AX = 0x15;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_2776 / 0x12776)
    NearCall(cs1, 0x2779, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV AL,0x9 (1000_2779 / 0x12779)
    AL = 0x9;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_277B / 0x1277B)
    NearCall(cs1, 0x277E, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    // MOV word ptr [0xd816],0x4 (1000_277E / 0x1277E)
    UInt16[DS, 0xD816] = 0x4;
    State.IncCycles();
    label_1000_2784_12784:
    // MOV BP,0x27b6 (1000_2784 / 0x12784)
    BP = 0x27B6;
    State.IncCycles();
    // MOV AX,0x9 (1000_2787 / 0x12787)
    AX = 0x9;
    State.IncCycles();
    // CALL 0x1000:e353 (1000_278A / 0x1278A)
    NearCall(cs1, 0x278D, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    // DEC word ptr [0xd816] (1000_278D / 0x1278D)
    UInt16[DS, 0xD816] = Alu.Dec16(UInt16[DS, 0xD816]);
    State.IncCycles();
    // JNS 0x1000:2784 (1000_2791 / 0x12791)
    if(!SignFlag) {
      goto label_1000_2784_12784;
    }
    State.IncCycles();
    // JMP 0x1000:274e (1000_2793 / 0x12793)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_274E_01274E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2795_012795(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2795_12795:
    // MOV AX,0x15 (1000_2795 / 0x12795)
    AX = 0x15;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_2798 / 0x12798)
    NearCall(cs1, 0x279B, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV word ptr [0xd816],0x0 (1000_279B / 0x1279B)
    UInt16[DS, 0xD816] = 0x0;
    State.IncCycles();
    label_1000_27A1_127A1:
    // MOV BP,0x27b6 (1000_27A1 / 0x127A1)
    BP = 0x27B6;
    State.IncCycles();
    // MOV AX,0x9 (1000_27A4 / 0x127A4)
    AX = 0x9;
    State.IncCycles();
    // CALL 0x1000:e353 (1000_27A7 / 0x127A7)
    NearCall(cs1, 0x27AA, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    // INC word ptr [0xd816] (1000_27AA / 0x127AA)
    UInt16[DS, 0xD816]++;
    State.IncCycles();
    // CMP word ptr [0xd816],0xd (1000_27AE / 0x127AE)
    Alu.Sub16(UInt16[DS, 0xD816], 0xD);
    State.IncCycles();
    // JC 0x1000:27a1 (1000_27B3 / 0x127B3)
    if(CarryFlag) {
      goto label_1000_27A1_127A1;
    }
    State.IncCycles();
    // RET  (1000_27B5 / 0x127B5)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_27C9_0127C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_27C9_127C9:
    // CALL 0x1000:c08e (1000_27C9 / 0x127C9)
    NearCall(cs1, 0x27CC, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // MOV BX,0x67 (1000_27CC / 0x127CC)
    BX = 0x67;
    State.IncCycles();
    label_1000_27CF_127CF:
    // PUSH BX (1000_27CF / 0x127CF)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,0xf (1000_27D0 / 0x127D0)
    BX = 0xF;
    State.IncCycles();
    label_1000_27D3_127D3:
    // CALL 0x1000:e3b7 (1000_27D3 / 0x127D3)
    NearCall(cs1, 0x27D6, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    // CMP AL,DL (1000_27D6 / 0x127D6)
    Alu.Sub8(AL, DL);
    State.IncCycles();
    // JZ 0x1000:27d3 (1000_27D8 / 0x127D8)
    if(ZeroFlag) {
      goto label_1000_27D3_127D3;
    }
    State.IncCycles();
    // MOV DL,AL (1000_27DA / 0x127DA)
    DL = AL;
    State.IncCycles();
    // ADD AX,0x17 (1000_27DC / 0x127DC)
    // AX += 0x17;
    AX = Alu.Add16(AX, 0x17);
    State.IncCycles();
    // POP BX (1000_27DF / 0x127DF)
    BX = Stack.Pop();
    State.IncCycles();
    // PUSH DX (1000_27E0 / 0x127E0)
    Stack.Push(DX);
    State.IncCycles();
    // MOV DX,0xa3 (1000_27E1 / 0x127E1)
    DX = 0xA3;
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_27E4 / 0x127E4)
    NearCall(cs1, 0x27E7, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    State.IncCycles();
    // POP DX (1000_27E7 / 0x127E7)
    DX = Stack.Pop();
    State.IncCycles();
    // ADD BX,0x3 (1000_27E8 / 0x127E8)
    BX += 0x3;
    State.IncCycles();
    // CMP BX,0x70 (1000_27EB / 0x127EB)
    Alu.Sub16(BX, 0x70);
    State.IncCycles();
    // JBE 0x1000:27cf (1000_27EE / 0x127EE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_27CF_127CF;
    }
    State.IncCycles();
    // MOV SI,0x14ce (1000_27F0 / 0x127F0)
    SI = 0x14CE;
    State.IncCycles();
    // MOV AX,[0xd816] (1000_27F3 / 0x127F3)
    AX = UInt16[DS, 0xD816];
    State.IncCycles();
    // AND AX,0x3 (1000_27F6 / 0x127F6)
    AX &= 0x3;
    State.IncCycles();
    // ADD AL,0x13 (1000_27F9 / 0x127F9)
    // AL += 0x13;
    AL = Alu.Add8(AL, 0x13);
    State.IncCycles();
    // MOV byte ptr [SI],AL (1000_27FB / 0x127FB)
    UInt8[DS, SI] = AL;
    State.IncCycles();
    // MOV byte ptr [SI + 0x6],AL (1000_27FD / 0x127FD)
    UInt8[DS, (ushort)(SI + 0x6)] = AL;
    State.IncCycles();
    // CALL 0x1000:c21b (1000_2800 / 0x12800)
    NearCall(cs1, 0x2803, spice86_generated_label_call_target_1000_C21B_01C21B);
    State.IncCycles();
    // JMP 0x1000:c07c (1000_2803 / 0x12803)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2806_012806(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2806_12806:
    // CALL 0x1000:274e (1000_2806 / 0x12806)
    NearCall(cs1, 0x2809, not_observed_1000_274E_01274E);
    State.IncCycles();
    // MOV AL,0x2 (1000_2809 / 0x12809)
    AL = 0x2;
    State.IncCycles();
    // CALL 0x1000:275f (1000_280B / 0x1280B)
    NearCall(cs1, 0x280E, not_observed_1000_275F_01275F);
    State.IncCycles();
    // MOV CX,0x14 (1000_280E / 0x1280E)
    CX = 0x14;
    State.IncCycles();
    // CALL 0x1000:281c (1000_2811 / 0x12811)
    NearCall(cs1, 0x2814, not_observed_1000_281C_01281C);
    State.IncCycles();
    // CALL 0x1000:aba9 (1000_2814 / 0x12814)
    NearCall(cs1, 0x2817, spice86_generated_label_call_target_1000_ABA9_01ABA9);
    State.IncCycles();
    // MOV AL,0x1 (1000_2817 / 0x12817)
    AL = 0x1;
    State.IncCycles();
    // JMP 0x1000:275f (1000_2819 / 0x12819)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_275F_01275F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_281C_01281C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_281C_1281C:
    // MOV AX,0x15 (1000_281C / 0x1281C)
    AX = 0x15;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_281F / 0x1281F)
    NearCall(cs1, 0x2822, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV word ptr [0xd816],0x0 (1000_2822 / 0x12822)
    UInt16[DS, 0xD816] = 0x0;
    State.IncCycles();
    label_1000_2828_12828:
    // PUSH CX (1000_2828 / 0x12828)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:27c9 (1000_2829 / 0x12829)
    NearCall(cs1, 0x282C, not_observed_1000_27C9_0127C9);
    State.IncCycles();
    // MOV AX,0x9 (1000_282C / 0x1282C)
    AX = 0x9;
    State.IncCycles();
    // CALL 0x1000:e3a0 (1000_282F / 0x1282F)
    NearCall(cs1, 0x2832, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    State.IncCycles();
    // INC word ptr [0xd816] (1000_2832 / 0x12832)
    UInt16[DS, 0xD816] = Alu.Inc16(UInt16[DS, 0xD816]);
    State.IncCycles();
    // POP CX (1000_2836 / 0x12836)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:2828 (1000_2837 / 0x12837)
    if(--CX != 0) {
      goto label_1000_2828_12828;
    }
    State.IncCycles();
    // RET  (1000_2839 / 0x12839)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_28B5_0128B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_28B5_128B5:
    // MOV AX,0x15 (1000_28B5 / 0x128B5)
    AX = 0x15;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_28B8 / 0x128B8)
    NearCall(cs1, 0x28BB, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV AL,0xa (1000_28BB / 0x128BB)
    AL = 0xA;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_28BD / 0x128BD)
    NearCall(cs1, 0x28C0, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    // MOV AL,[0x47a9] (1000_28C0 / 0x128C0)
    AL = UInt8[DS, 0x47A9];
    State.IncCycles();
    // XOR AH,AH (1000_28C3 / 0x128C3)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_28C5 / 0x128C5)
    SI = AX;
    State.IncCycles();
    // SHL SI,1 (1000_28C7 / 0x128C7)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x225d] (1000_28C9 / 0x128C9)
    DX = UInt16[DS, (ushort)(SI + 0x225D)];
    State.IncCycles();
    // XOR BX,BX (1000_28CD / 0x128CD)
    BX = 0;
    State.IncCycles();
    // XCHG DH,BL (1000_28CF / 0x128CF)
    byte tmp_1000_28CF = DH;
    DH = BL;
    BL = tmp_1000_28CF;
    State.IncCycles();
    // ADD AX,0x1e (1000_28D1 / 0x128D1)
    AX += 0x1E;
    State.IncCycles();
    // SHL SI,1 (1000_28D4 / 0x128D4)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV word ptr [SI + 0x47f8],DX (1000_28D6 / 0x128D6)
    UInt16[DS, (ushort)(SI + 0x47F8)] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x47fa],BX (1000_28DA / 0x128DA)
    UInt16[DS, (ushort)(SI + 0x47FA)] = BX;
    State.IncCycles();
    // JMP 0x1000:c22f (1000_28DE / 0x128DE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_28E1_0128E1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_28E1_128E1:
    // CMP byte ptr [0x24],0xc (1000_28E1 / 0x128E1)
    Alu.Sub8(UInt8[DS, 0x24], 0xC);
    State.IncCycles();
    // JNZ 0x1000:28eb (1000_28E6 / 0x128E6)
    if(!ZeroFlag) {
      goto label_1000_28EB_128EB;
    }
    State.IncCycles();
    // CALL 0x1000:215f (1000_28E8 / 0x128E8)
    NearCall(cs1, 0x28EB, not_observed_1000_215F_01215F);
    State.IncCycles();
    label_1000_28EB_128EB:
    // CMP byte ptr [0x47a9],0x0 (1000_28EB / 0x128EB)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    State.IncCycles();
    // JZ 0x1000:290a (1000_28F0 / 0x128F0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_290A / 0x1290A)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:c49a (1000_28F2 / 0x128F2)
    NearCall(cs1, 0x28F5, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    State.IncCycles();
    // MOV byte ptr [0x47a6],0xff (1000_28F5 / 0x128F5)
    UInt8[DS, 0x47A6] = 0xFF;
    State.IncCycles();
    // MOV AL,0x8 (1000_28FA / 0x128FA)
    AL = 0x8;
    State.IncCycles();
    // MOV BP,0x2dd3 (1000_28FC / 0x128FC)
    BP = 0x2DD3;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_28FF / 0x128FF)
    NearCall(cs1, 0x2902, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // MOV byte ptr [0x47a9],0x0 (1000_2902 / 0x12902)
    UInt8[DS, 0x47A9] = 0x0;
    State.IncCycles();
    // CALL 0x1000:2773 (1000_2907 / 0x12907)
    NearCall(cs1, 0x290A, not_observed_1000_2773_012773);
    State.IncCycles();
    label_1000_290A_1290A:
    // RET  (1000_290A / 0x1290A)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2992_012992(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2992_12992:
    // RET  (1000_2992 / 0x12992)
    return NearRet();
    State.IncCycles();
    label_1000_2993_12993:
    // MOV AL,0x6 (1000_2993 / 0x12993)
    AL = 0x6;
    State.IncCycles();
    // JMP 0x1000:2999 (1000_2995 / 0x12995)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2999_012999, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2999_012999(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2999_12999:
    // MOV BL,byte ptr [0xc9] (1000_2999 / 0x12999)
    BL = UInt8[DS, 0xC9];
    State.IncCycles();
    // MOV byte ptr [0xeb],BL (1000_299D / 0x1299D)
    UInt8[DS, 0xEB] = BL;
    State.IncCycles();
    // CMP byte ptr [0x47a9],0x0 (1000_29A1 / 0x129A1)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    State.IncCycles();
    // JZ 0x1000:2992 (1000_29A6 / 0x129A6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2992 / 0x12992)
      return NearRet();
    }
    State.IncCycles();
    // PUSH AX (1000_29A8 / 0x129A8)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:97cf (1000_29A9 / 0x129A9)
    NearCall(cs1, 0x29AC, spice86_generated_label_call_target_1000_97CF_0197CF);
    State.IncCycles();
    // CALL 0x1000:98f5 (1000_29AC / 0x129AC)
    NearCall(cs1, 0x29AF, spice86_generated_label_call_target_1000_98F5_0198F5);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_29AF / 0x129AF)
    NearCall(cs1, 0x29B2, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:28b5 (1000_29B2 / 0x129B2)
    NearCall(cs1, 0x29B5, not_observed_1000_28B5_0128B5);
    State.IncCycles();
    // CALL 0x1000:28e1 (1000_29B5 / 0x129B5)
    NearCall(cs1, 0x29B8, not_observed_1000_28E1_0128E1);
    State.IncCycles();
    // MOV byte ptr [0x24],0x0 (1000_29B8 / 0x129B8)
    UInt8[DS, 0x24] = 0x0;
    State.IncCycles();
    // POP AX (1000_29BD / 0x129BD)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x23],AL (1000_29BE / 0x129BE)
    UInt8[DS, 0x23] = AL;
    State.IncCycles();
    // CALL 0x1000:d316 (1000_29C1 / 0x129C1)
    NearCall(cs1, 0x29C4, spice86_generated_label_call_target_1000_D316_01D316);
    State.IncCycles();
    // CALL 0x1000:2eb2 (1000_29C4 / 0x129C4)
    NearCall(cs1, 0x29C7, spice86_generated_label_call_target_1000_2EB2_012EB2);
    State.IncCycles();
    // CALL 0x1000:2dd3 (1000_29C7 / 0x129C7)
    NearCall(cs1, 0x29CA, spice86_generated_label_ret_target_1000_2DD3_012DD3);
    State.IncCycles();
    // CMP byte ptr [0x47a7],0x0 (1000_29CA / 0x129CA)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2992 (1000_29CF / 0x129CF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2992 / 0x12992)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:d280 (1000_29D1 / 0x129D1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_29EE_0129EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_29EE_129EE:
    // XOR DI,DI (1000_29EE / 0x129EE)
    DI = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_29F0_0129F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_29F0_0129F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_29F0_129F0:
    // TEST byte ptr [0xa],0x1 (1000_29F0 / 0x129F0)
    Alu.And8(UInt8[DS, 0xA], 0x1);
    State.IncCycles();
    // JZ 0x1000:2a33 (1000_29F5 / 0x129F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2A33 / 0x12A33)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x1190 (1000_29F7 / 0x129F7)
    SI = 0x1190;
    State.IncCycles();
    // MOV CL,byte ptr [SI] (1000_29FA / 0x129FA)
    CL = UInt8[DS, SI];
    State.IncCycles();
    // XOR CH,CH (1000_29FC / 0x129FC)
    CH = 0;
    State.IncCycles();
    // JCXZ 0x1000:2a14 (1000_29FE / 0x129FE)
    if(CX == 0) {
      goto label_1000_2A14_12A14;
    }
    State.IncCycles();
    // INC SI (1000_2A00 / 0x12A00)
    SI++;
    State.IncCycles();
    label_1000_2A01_12A01:
    // CMP AX,word ptr [SI] (1000_2A01 / 0x12A01)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JNZ 0x1000:2a0a (1000_2A03 / 0x12A03)
    if(!ZeroFlag) {
      goto label_1000_2A0A_12A0A;
    }
    State.IncCycles();
    // CMP DI,word ptr [SI + 0x2] (1000_2A05 / 0x12A05)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JZ 0x1000:2a33 (1000_2A08 / 0x12A08)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2A33 / 0x12A33)
      return NearRet();
    }
    State.IncCycles();
    label_1000_2A0A_12A0A:
    // ADD SI,0x4 (1000_2A0A / 0x12A0A)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:2a01 (1000_2A0D / 0x12A0D)
    if(--CX != 0) {
      goto label_1000_2A01_12A01;
    }
    State.IncCycles();
    // MOV SI,0x1190 (1000_2A0F / 0x12A0F)
    SI = 0x1190;
    State.IncCycles();
    // MOV CL,byte ptr [SI] (1000_2A12 / 0x12A12)
    CL = UInt8[DS, SI];
    State.IncCycles();
    label_1000_2A14_12A14:
    // CMP CX,0xa (1000_2A14 / 0x12A14)
    Alu.Sub16(CX, 0xA);
    State.IncCycles();
    // JC 0x1000:2a25 (1000_2A17 / 0x12A17)
    if(CarryFlag) {
      goto label_1000_2A25_12A25;
    }
    State.IncCycles();
    // PUSH AX (1000_2A19 / 0x12A19)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_2A1A / 0x12A1A)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_2A1B / 0x12A1B)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:2a34 (1000_2A1C / 0x12A1C)
    NearCall(cs1, 0x2A1F, not_observed_1000_2A34_012A34);
    State.IncCycles();
    // POP DI (1000_2A1F / 0x12A1F)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_2A20 / 0x12A20)
    SI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_2A21 / 0x12A21)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x9 (1000_2A22 / 0x12A22)
    CX = 0x9;
    State.IncCycles();
    label_1000_2A25_12A25:
    // INC byte ptr [SI] (1000_2A25 / 0x12A25)
    UInt8[DS, SI]++;
    State.IncCycles();
    // INC SI (1000_2A27 / 0x12A27)
    SI++;
    State.IncCycles();
    // ADD CX,CX (1000_2A28 / 0x12A28)
    CX += CX;
    State.IncCycles();
    // ADD CX,CX (1000_2A2A / 0x12A2A)
    CX += CX;
    State.IncCycles();
    // ADD SI,CX (1000_2A2C / 0x12A2C)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    State.IncCycles();
    // MOV word ptr [SI],AX (1000_2A2E / 0x12A2E)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],DI (1000_2A30 / 0x12A30)
    UInt16[DS, (ushort)(SI + 0x2)] = DI;
    State.IncCycles();
    label_1000_2A33_12A33:
    // RET  (1000_2A33 / 0x12A33)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2A34_012A34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2A34_12A34:
    // MOV SI,0x1190 (1000_2A34 / 0x12A34)
    SI = 0x1190;
    State.IncCycles();
    // DEC byte ptr [SI] (1000_2A37 / 0x12A37)
    UInt8[DS, SI] = Alu.Dec8(UInt8[DS, SI]);
    State.IncCycles();
    // JNZ 0x1000:2a3f (1000_2A39 / 0x12A39)
    if(!ZeroFlag) {
      goto label_1000_2A3F_12A3F;
    }
    State.IncCycles();
    // MOV byte ptr [SI + -0x1],0x0 (1000_2A3B / 0x12A3B)
    UInt8[DS, (ushort)(SI - 0x1)] = 0x0;
    State.IncCycles();
    label_1000_2A3F_12A3F:
    // INC SI (1000_2A3F / 0x12A3F)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV DI,SI (1000_2A40 / 0x12A40)
    DI = SI;
    State.IncCycles();
    // ADD SI,0x4 (1000_2A42 / 0x12A42)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // PUSH DS (1000_2A45 / 0x12A45)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_2A46 / 0x12A46)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x12 (1000_2A47 / 0x12A47)
    CX = 0x12;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_2A4A / 0x12A4A)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // XOR AX,AX (1000_2A4C / 0x12A4C)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_2A4E / 0x12A4E)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_2A4F / 0x12A4F)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // RET  (1000_2A50 / 0x12A50)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2A51_012A51(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2A51_12A51:
    // MOV SI,0x1190 (1000_2A51 / 0x12A51)
    SI = 0x1190;
    State.IncCycles();
    // MOV DL,AL (1000_2A54 / 0x12A54)
    DL = AL;
    State.IncCycles();
    // MOV BX,DI (1000_2A56 / 0x12A56)
    BX = DI;
    State.IncCycles();
    // XOR CX,CX (1000_2A58 / 0x12A58)
    CX = 0;
    State.IncCycles();
    // XOR BP,BP (1000_2A5A / 0x12A5A)
    BP = 0;
    State.IncCycles();
    // LODSB SI (1000_2A5C / 0x12A5C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV CL,AL (1000_2A5D / 0x12A5D)
    CL = AL;
    State.IncCycles();
    // JCXZ 0x1000:2aae (1000_2A5F / 0x12A5F)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2AAE / 0x12AAE)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,SI (1000_2A61 / 0x12A61)
    DI = SI;
    State.IncCycles();
    // PUSH DS (1000_2A63 / 0x12A63)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_2A64 / 0x12A64)
    ES = Stack.Pop();
    State.IncCycles();
    label_1000_2A65_12A65:
    // LODSW SI (1000_2A65 / 0x12A65)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AH,DL (1000_2A66 / 0x12A66)
    Alu.Sub8(AH, DL);
    State.IncCycles();
    // JNZ 0x1000:2a78 (1000_2A68 / 0x12A68)
    if(!ZeroFlag) {
      goto label_1000_2A78_12A78;
    }
    State.IncCycles();
    // CMP DL,0xf (1000_2A6A / 0x12A6A)
    Alu.Sub8(DL, 0xF);
    State.IncCycles();
    // JNZ 0x1000:2a73 (1000_2A6D / 0x12A6D)
    if(!ZeroFlag) {
      goto label_1000_2A73_12A73;
    }
    State.IncCycles();
    // CMP BX,word ptr [SI] (1000_2A6F / 0x12A6F)
    Alu.Sub16(BX, UInt16[DS, SI]);
    State.IncCycles();
    // JNZ 0x1000:2a78 (1000_2A71 / 0x12A71)
    if(!ZeroFlag) {
      goto label_1000_2A78_12A78;
    }
    State.IncCycles();
    label_1000_2A73_12A73:
    // ADD SI,0x2 (1000_2A73 / 0x12A73)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // JMP 0x1000:2a7b (1000_2A76 / 0x12A76)
    goto label_1000_2A7B_12A7B;
    State.IncCycles();
    label_1000_2A78_12A78:
    // STOSW ES:DI (1000_2A78 / 0x12A78)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2A79 / 0x12A79)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // INC BP (1000_2A7A / 0x12A7A)
    BP = Alu.Inc16(BP);
    State.IncCycles();
    label_1000_2A7B_12A7B:
    // LOOP 0x1000:2a65 (1000_2A7B / 0x12A7B)
    if(--CX != 0) {
      goto label_1000_2A65_12A65;
    }
    State.IncCycles();
    // JMP 0x1000:2a9e (1000_2A7D / 0x12A7D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2A9E_012A9E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2A9E_012A9E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x2AAE: goto label_1000_2AAE_12AAE;break; // Target of external jump from 0x12A5F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_2A9E_12A9E:
    // MOV CX,BP (1000_2A9E / 0x12A9E)
    CX = BP;
    State.IncCycles();
    // MOV CH,CL (1000_2AA0 / 0x12AA0)
    CH = CL;
    State.IncCycles();
    // XCHG byte ptr [0x1190],CL (1000_2AA2 / 0x12AA2)
    byte tmp_1000_2AA2 = UInt8[DS, 0x1190];
    UInt8[DS, 0x1190] = CL;
    CL = tmp_1000_2AA2;
    State.IncCycles();
    // CMP CL,CH (1000_2AA6 / 0x12AA6)
    Alu.Sub8(CL, CH);
    State.IncCycles();
    // JZ 0x1000:2aae (1000_2AA8 / 0x12AA8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2AAE / 0x12AAE)
      return NearRet();
    }
    State.IncCycles();
    // XOR AX,AX (1000_2AAA / 0x12AAA)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_2AAC / 0x12AAC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_2AAD / 0x12AAD)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    label_1000_2AAE_12AAE:
    // RET  (1000_2AAE / 0x12AAE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2AAF_012AAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2AAF_12AAF:
    // PUSH SI (1000_2AAF / 0x12AAF)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x1190 (1000_2AB0 / 0x12AB0)
    SI = 0x1190;
    State.IncCycles();
    // XOR CX,CX (1000_2AB3 / 0x12AB3)
    CX = 0;
    State.IncCycles();
    // MOV CL,byte ptr [SI] (1000_2AB5 / 0x12AB5)
    CL = UInt8[DS, SI];
    State.IncCycles();
    // JCXZ 0x1000:2acd (1000_2AB7 / 0x12AB7)
    if(CX == 0) {
      goto label_1000_2ACD_12ACD;
    }
    State.IncCycles();
    // INC SI (1000_2AB9 / 0x12AB9)
    SI++;
    State.IncCycles();
    label_1000_2ABA_12ABA:
    // CMP AL,byte ptr [SI + 0x1] (1000_2ABA / 0x12ABA)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x1)]);
    State.IncCycles();
    // JNZ 0x1000:2ac8 (1000_2ABD / 0x12ABD)
    if(!ZeroFlag) {
      goto label_1000_2AC8_12AC8;
    }
    State.IncCycles();
    // CMP AL,0xf (1000_2ABF / 0x12ABF)
    Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JNZ 0x1000:2ad0 (1000_2AC1 / 0x12AC1)
    if(!ZeroFlag) {
      goto label_1000_2AD0_12AD0;
    }
    State.IncCycles();
    // CMP DI,word ptr [SI + 0x2] (1000_2AC3 / 0x12AC3)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JZ 0x1000:2ad0 (1000_2AC6 / 0x12AC6)
    if(ZeroFlag) {
      goto label_1000_2AD0_12AD0;
    }
    State.IncCycles();
    label_1000_2AC8_12AC8:
    // ADD SI,0x4 (1000_2AC8 / 0x12AC8)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:2aba (1000_2ACB / 0x12ACB)
    if(--CX != 0) {
      goto label_1000_2ABA_12ABA;
    }
    State.IncCycles();
    label_1000_2ACD_12ACD:
    // POP SI (1000_2ACD / 0x12ACD)
    SI = Stack.Pop();
    State.IncCycles();
    // CLC  (1000_2ACE / 0x12ACE)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_2ACF / 0x12ACF)
    return NearRet();
    State.IncCycles();
    label_1000_2AD0_12AD0:
    // MOV AX,word ptr [SI] (1000_2AD0 / 0x12AD0)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x2] (1000_2AD2 / 0x12AD2)
    DI = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // POP SI (1000_2AD5 / 0x12AD5)
    SI = Stack.Pop();
    State.IncCycles();
    // STC  (1000_2AD6 / 0x12AD6)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_2AD7 / 0x12AD7)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2AD8_012AD8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2AD8_12AD8:
    // PUSH AX (1000_2AD8 / 0x12AD8)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,[0x1191] (1000_2AD9 / 0x12AD9)
    AX = UInt16[DS, 0x1191];
    State.IncCycles();
    // MOV BX,word ptr [0x12] (1000_2ADC / 0x12ADC)
    BX = UInt16[DS, 0x12];
    State.IncCycles();
    // MOV CL,AH (1000_2AE0 / 0x12AE0)
    CL = AH;
    State.IncCycles();
    // SHR BX,CL (1000_2AE2 / 0x12AE2)
    BX >>= CL;
    State.IncCycles();
    // SHR BX,1 (1000_2AE4 / 0x12AE4)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    // JNC 0x1000:2af7 (1000_2AE6 / 0x12AE6)
    if(!CarryFlag) {
      goto label_1000_2AF7_12AF7;
    }
    State.IncCycles();
    // MOV DI,word ptr [0x1193] (1000_2AE8 / 0x12AE8)
    DI = UInt16[DS, 0x1193];
    State.IncCycles();
    // CMP CL,0xf (1000_2AEC / 0x12AEC)
    Alu.Sub8(CL, 0xF);
    State.IncCycles();
    // JNZ 0x1000:2afa (1000_2AEF / 0x12AEF)
    if(!ZeroFlag) {
      goto label_1000_2AFA_12AFA;
    }
    State.IncCycles();
    // CMP DI,word ptr [0x114e] (1000_2AF1 / 0x12AF1)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JZ 0x1000:2afa (1000_2AF5 / 0x12AF5)
    if(ZeroFlag) {
      goto label_1000_2AFA_12AFA;
    }
    State.IncCycles();
    label_1000_2AF7_12AF7:
    // POP AX (1000_2AF7 / 0x12AF7)
    AX = Stack.Pop();
    State.IncCycles();
    // CLC  (1000_2AF8 / 0x12AF8)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_2AF9 / 0x12AF9)
    return NearRet();
    State.IncCycles();
    label_1000_2AFA_12AFA:
    // ADD SP,0x2 (1000_2AFA / 0x12AFA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_2AFD / 0x12AFD)
    NearCall(cs1, 0x2B00, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_2B00_012B00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2B00_012B00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2B00_12B00:
    // PUSH word ptr [0x11ce] (1000_2B00 / 0x12B00)
    Stack.Push(UInt16[DS, 0x11CE]);
    State.IncCycles();
    // OR DI,DI (1000_2B04 / 0x12B04)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:2b0d (1000_2B06 / 0x12B06)
    if(ZeroFlag) {
      goto label_1000_2B0D_12B0D;
    }
    State.IncCycles();
    // PUSH AX (1000_2B08 / 0x12B08)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:331e (1000_2B09 / 0x12B09)
    NearCall(cs1, 0x2B0C, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    // POP AX (1000_2B0C / 0x12B0C)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_2B0D_12B0D:
    // MOV [0xea],AL (1000_2B0D / 0x12B0D)
    UInt8[DS, 0xEA] = AL;
    State.IncCycles();
    // MOV AL,AH (1000_2B10 / 0x12B10)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_2B12 / 0x12B12)
    AH = 0;
    State.IncCycles();
    // CALL 0x1000:96d8 (1000_2B14 / 0x12B14)
    NearCall(cs1, 0x2B17, spice86_generated_label_call_target_1000_96D8_0196D8);
    State.IncCycles();
    // CALL 0x1000:9945 (1000_2B17 / 0x12B17)
    NearCall(cs1, 0x2B1A, not_observed_1000_9945_019945);
    State.IncCycles();
    // MOV byte ptr [0xea],0xff (1000_2B1A / 0x12B1A)
    UInt8[DS, 0xEA] = 0xFF;
    State.IncCycles();
    // MOV AL,0x1 (1000_2B1F / 0x12B1F)
    AL = 0x1;
    State.IncCycles();
    // CALL 0x1000:9ef1 (1000_2B21 / 0x12B21)
    NearCall(cs1, 0x2B24, not_observed_1000_9EF1_019EF1);
    State.IncCycles();
    // POP DI (1000_2B24 / 0x12B24)
    DI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:331e (1000_2B25 / 0x12B25)
    NearCall(cs1, 0x2B28, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    // STC  (1000_2B28 / 0x12B28)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_2B29 / 0x12B29)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2B2A_012B2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2B2A_12B2A:
    // MOV AL,[0x46d9] (1000_2B2A / 0x12B2A)
    AL = UInt8[DS, 0x46D9];
    State.IncCycles();
    // OR AL,byte ptr [0x4774] (1000_2B2D / 0x12B2D)
    // AL |= UInt8[DS, 0x4774];
    AL = Alu.Or8(AL, UInt8[DS, 0x4774]);
    State.IncCycles();
    // OR AL,byte ptr [0x11c9] (1000_2B31 / 0x12B31)
    // AL |= UInt8[DS, 0x11C9];
    AL = Alu.Or8(AL, UInt8[DS, 0x11C9]);
    State.IncCycles();
    // JNZ 0x1000:2b8f (1000_2B35 / 0x12B35)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:d41b (1000_2B37 / 0x12B37)
    NearCall(cs1, 0x2B3A, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    label_1000_2B3A_12B3A:
    // CMP BP,0x1f0e (1000_2B3A / 0x12B3A)
    Alu.Sub16(BP, 0x1F0E);
    State.IncCycles();
    // JNZ 0x1000:2b8f (1000_2B3E / 0x12B3E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xfb],0x0 (1000_2B40 / 0x12B40)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    State.IncCycles();
    // JS 0x1000:2b8f (1000_2B45 / 0x12B45)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_2B47 / 0x12B47)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // CMP byte ptr [0x2a],0x14 (1000_2B4A / 0x12B4A)
    Alu.Sub8(UInt8[DS, 0x2A], 0x14);
    State.IncCycles();
    // JC 0x1000:2b8f (1000_2B4F / 0x12B4F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // JZ 0x1000:2ba1 (1000_2B51 / 0x12B51)
    if(ZeroFlag) {
      goto label_1000_2BA1_12BA1;
    }
    State.IncCycles();
    // CMP byte ptr [0x1190],0x0 (1000_2B53 / 0x12B53)
    Alu.Sub8(UInt8[DS, 0x1190], 0x0);
    State.IncCycles();
    // JZ 0x1000:2b8f (1000_2B58 / 0x12B58)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // SUB AX,word ptr [0xdc5a] (1000_2B5A / 0x12B5A)
    AX -= UInt16[DS, 0xDC5A];
    State.IncCycles();
    // CMP AX,0x32 (1000_2B5E / 0x12B5E)
    Alu.Sub16(AX, 0x32);
    State.IncCycles();
    // JC 0x1000:2b8f (1000_2B61 / 0x12B61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:2ad8 (1000_2B63 / 0x12B63)
    NearCall(cs1, 0x2B66, not_observed_1000_2AD8_012AD8);
    State.IncCycles();
    // JNC 0x1000:2b70 (1000_2B66 / 0x12B66)
    if(!CarryFlag) {
      goto label_1000_2B70_12B70;
    }
    State.IncCycles();
    // MOV byte ptr [0x23],0x0 (1000_2B68 / 0x12B68)
    UInt8[DS, 0x23] = 0x0;
    State.IncCycles();
    // JMP 0x1000:3542 (1000_2B6D / 0x12B6D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3530_013530, 0x13542 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2B70_12B70:
    // CMP byte ptr [0x2b],0x0 (1000_2B70 / 0x12B70)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2bd2 (1000_2B75 / 0x12B75)
    if(!ZeroFlag) {
      goto label_1000_2BD2_12BD2;
    }
    State.IncCycles();
    // MOV BL,0x28 (1000_2B77 / 0x12B77)
    BL = 0x28;
    State.IncCycles();
    // CMP AX,0x96 (1000_2B79 / 0x12B79)
    Alu.Sub16(AX, 0x96);
    State.IncCycles();
    // JC 0x1000:2b90 (1000_2B7C / 0x12B7C)
    if(CarryFlag) {
      goto label_1000_2B90_12B90;
    }
    State.IncCycles();
    // CMP AX,0xfa (1000_2B7E / 0x12B7E)
    Alu.Sub16(AX, 0xFA);
    State.IncCycles();
    // JC 0x1000:2b8f (1000_2B81 / 0x12B81)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // CMP AX,0x15e (1000_2B83 / 0x12B83)
    Alu.Sub16(AX, 0x15E);
    State.IncCycles();
    // MOV BL,0x26 (1000_2B86 / 0x12B86)
    BL = 0x26;
    State.IncCycles();
    // JC 0x1000:2b90 (1000_2B88 / 0x12B88)
    if(CarryFlag) {
      goto label_1000_2B90_12B90;
    }
    State.IncCycles();
    // CMP AX,0x1c2 (1000_2B8A / 0x12B8A)
    Alu.Sub16(AX, 0x1C2);
    State.IncCycles();
    // JNC 0x1000:2bd2 (1000_2B8D / 0x12B8D)
    if(!CarryFlag) {
      goto label_1000_2BD2_12BD2;
    }
    State.IncCycles();
    label_1000_2B8F_12B8F:
    // RET  (1000_2B8F / 0x12B8F)
    return NearRet();
    State.IncCycles();
    label_1000_2B90_12B90:
    // PUSH BX (1000_2B90 / 0x12B90)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_2B91 / 0x12B91)
    NearCall(cs1, 0x2B94, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:c49a (1000_2B94 / 0x12B94)
    NearCall(cs1, 0x2B97, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    State.IncCycles();
    // POP AX (1000_2B97 / 0x12B97)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV BP,0xf66 (1000_2B98 / 0x12B98)
    BP = 0xF66;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_2B9B / 0x12B9B)
    NearCall(cs1, 0x2B9E, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // JMP 0x1000:dbec (1000_2B9E / 0x12B9E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2BA1_12BA1:
    // CMP word ptr [0x10],0x0 (1000_2BA1 / 0x12BA1)
    Alu.Sub16(UInt16[DS, 0x10], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2b8f (1000_2BA6 / 0x12BA6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x8],0xff (1000_2BA8 / 0x12BA8)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:2b8f (1000_2BAD / 0x12BAD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // SUB AX,word ptr [0xdc5a] (1000_2BAF / 0x12BAF)
    AX -= UInt16[DS, 0xDC5A];
    State.IncCycles();
    // CMP AX,0x3e8 (1000_2BB3 / 0x12BB3)
    Alu.Sub16(AX, 0x3E8);
    State.IncCycles();
    // JC 0x1000:2b8f (1000_2BB6 / 0x12BB6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    State.IncCycles();
    // ADD word ptr [0xdc5a],0x3b6 (1000_2BB8 / 0x12BB8)
    // UInt16[DS, 0xDC5A] += 0x3B6;
    UInt16[DS, 0xDC5A] = Alu.Add16(UInt16[DS, 0xDC5A], 0x3B6);
    State.IncCycles();
    // CALL 0x1000:1071 (1000_2BBE / 0x12BBE)
    NearCall(cs1, 0x2BC1, not_observed_1000_1071_011071);
    State.IncCycles();
    // CALL 0x1000:b17a (1000_2BC1 / 0x12BC1)
    NearCall(cs1, 0x2BC4, spice86_generated_label_call_target_1000_B17A_01B17A);
    State.IncCycles();
    label_1000_2BC4_12BC4:
    // CALL 0x1000:2b2a (1000_2BC4 / 0x12BC4)
    NearCall(cs1, 0x2BC7, spice86_generated_label_call_target_1000_2B2A_012B2A);
    State.IncCycles();
    // CMP byte ptr [0xea],0xff (1000_2BC7 / 0x12BC7)
    Alu.Sub8(UInt8[DS, 0xEA], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:2bc4 (1000_2BCC / 0x12BCC)
    if(!ZeroFlag) {
      goto label_1000_2BC4_12BC4;
    }
    State.IncCycles();
    // RET  (1000_2BCE / 0x12BCE)
    return NearRet();
    State.IncCycles();
    label_1000_2BCF_12BCF:
    // JMP 0x1000:2a34 (1000_2BCF / 0x12BCF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2A34_012A34, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2BD2_12BD2:
    // CALL 0x1000:dbb2 (1000_2BD2 / 0x12BD2)
    NearCall(cs1, 0x2BD5, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:ad5e (1000_2BD5 / 0x12BD5)
    NearCall(cs1, 0x2BD8, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    State.IncCycles();
    // MOV DI,word ptr [0x1193] (1000_2BD8 / 0x12BD8)
    DI = UInt16[DS, 0x1193];
    State.IncCycles();
    // OR DI,DI (1000_2BDC / 0x12BDC)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:2bf4 (1000_2BDE / 0x12BDE)
    if(ZeroFlag) {
      goto label_1000_2BF4_12BF4;
    }
    State.IncCycles();
    // MOV AX,DI (1000_2BE0 / 0x12BE0)
    AX = DI;
    State.IncCycles();
    // SUB AX,0x100 (1000_2BE2 / 0x12BE2)
    AX -= 0x100;
    State.IncCycles();
    // CMP AX,0x7aa (1000_2BE5 / 0x12BE5)
    Alu.Sub16(AX, 0x7AA);
    State.IncCycles();
    // JC 0x1000:2bf1 (1000_2BE8 / 0x12BE8)
    if(CarryFlag) {
      goto label_1000_2BF1_12BF1;
    }
    State.IncCycles();
    // MOV byte ptr [0x1193],0x0 (1000_2BEA / 0x12BEA)
    UInt8[DS, 0x1193] = 0x0;
    State.IncCycles();
    // JMP 0x1000:2bf4 (1000_2BEF / 0x12BEF)
    goto label_1000_2BF4_12BF4;
    State.IncCycles();
    label_1000_2BF1_12BF1:
    // CALL 0x1000:331e (1000_2BF1 / 0x12BF1)
    NearCall(cs1, 0x2BF4, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    label_1000_2BF4_12BF4:
    // MOV AX,[0x1191] (1000_2BF4 / 0x12BF4)
    AX = UInt16[DS, 0x1191];
    State.IncCycles();
    // MOV [0xea],AL (1000_2BF7 / 0x12BF7)
    UInt8[DS, 0xEA] = AL;
    State.IncCycles();
    // CMP AL,0x1 (1000_2BFA / 0x12BFA)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:2c01 (1000_2BFC / 0x12BFC)
    if(!ZeroFlag) {
      goto label_1000_2C01_12C01;
    }
    State.IncCycles();
    // MOV [0xeb],AL (1000_2BFE / 0x12BFE)
    UInt8[DS, 0xEB] = AL;
    State.IncCycles();
    label_1000_2C01_12C01:
    // MOV AL,AH (1000_2C01 / 0x12C01)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_2C03 / 0x12C03)
    AH = 0;
    State.IncCycles();
    // MOV DI,word ptr [0x1193] (1000_2C05 / 0x12C05)
    DI = UInt16[DS, 0x1193];
    State.IncCycles();
    // CMP AX,0x10 (1000_2C09 / 0x12C09)
    Alu.Sub16(AX, 0x10);
    State.IncCycles();
    // JNC 0x1000:2bcf (1000_2C0C / 0x12C0C)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:2a34 (1000_2BCF / 0x12BCF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_2A34_012A34, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AL,0xe (1000_2C0E / 0x12C0E)
    Alu.Sub8(AL, 0xE);
    State.IncCycles();
    // JNZ 0x1000:2c16 (1000_2C10 / 0x12C10)
    if(!ZeroFlag) {
      goto label_1000_2C16_12C16;
    }
    State.IncCycles();
    // OR DI,DI (1000_2C12 / 0x12C12)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:2bcf (1000_2C14 / 0x12C14)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:2a34 (1000_2BCF / 0x12BCF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_2A34_012A34, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_2C16_12C16:
    // MOV [0x47c4],AX (1000_2C16 / 0x12C16)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // OR DI,DI (1000_2C19 / 0x12C19)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:2c47 (1000_2C1B / 0x12C1B)
    if(ZeroFlag) {
      goto label_1000_2C47_12C47;
    }
    State.IncCycles();
    // CALL 0x1000:331e (1000_2C1D / 0x12C1D)
    NearCall(cs1, 0x2C20, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    // CALL 0x1000:2e98 (1000_2C20 / 0x12C20)
    NearCall(cs1, 0x2C23, spice86_generated_label_call_target_1000_2E98_012E98);
    State.IncCycles();
    // CMP word ptr [0x47c4],0xe (1000_2C23 / 0x12C23)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xE);
    State.IncCycles();
    // JC 0x1000:2c47 (1000_2C28 / 0x12C28)
    if(CarryFlag) {
      goto label_1000_2C47_12C47;
    }
    State.IncCycles();
    // MOV AL,0x3 (1000_2C2A / 0x12C2A)
    AL = 0x3;
    State.IncCycles();
    // CMP byte ptr [0xea],0xe (1000_2C2C / 0x12C2C)
    Alu.Sub8(UInt8[DS, 0xEA], 0xE);
    State.IncCycles();
    // JZ 0x1000:2c3a (1000_2C31 / 0x12C31)
    if(ZeroFlag) {
      goto label_1000_2C3A_12C3A;
    }
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_2C33 / 0x12C33)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    // OR AL,AL (1000_2C36 / 0x12C36)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:2c47 (1000_2C38 / 0x12C38)
    if(ZeroFlag) {
      goto label_1000_2C47_12C47;
    }
    State.IncCycles();
    label_1000_2C3A_12C3A:
    // CALL 0x1000:6906 (1000_2C3A / 0x12C3A)
    NearCall(cs1, 0x2C3D, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    // MOV word ptr [0x47c4],0xe (1000_2C3D / 0x12C3D)
    UInt16[DS, 0x47C4] = 0xE;
    State.IncCycles();
    // MOV word ptr [0x4756],SI (1000_2C43 / 0x12C43)
    UInt16[DS, 0x4756] = SI;
    State.IncCycles();
    label_1000_2C47_12C47:
    // CALL 0x1000:2c92 (1000_2C47 / 0x12C47)
    NearCall(cs1, 0x2C4A, not_observed_1000_2C92_012C92);
    State.IncCycles();
    // MOV AL,0x1 (1000_2C4A / 0x12C4A)
    AL = 0x1;
    State.IncCycles();
    // CALL 0x1000:9ef1 (1000_2C4C / 0x12C4C)
    NearCall(cs1, 0x2C4F, not_observed_1000_9EF1_019EF1);
    State.IncCycles();
    // CALL 0x1000:2a34 (1000_2C4F / 0x12C4F)
    NearCall(cs1, 0x2C52, not_observed_1000_2A34_012A34);
    State.IncCycles();
    // XOR AX,AX (1000_2C52 / 0x12C52)
    AX = 0;
    State.IncCycles();
    // MOV [0x1f0f],AL (1000_2C54 / 0x12C54)
    UInt8[DS, 0x1F0F] = AL;
    State.IncCycles();
    // MOV [0x1f10],AX (1000_2C57 / 0x12C57)
    UInt16[DS, 0x1F10] = AX;
    State.IncCycles();
    // CALL 0x1000:d397 (1000_2C5A / 0x12C5A)
    NearCall(cs1, 0x2C5D, spice86_generated_label_call_target_1000_D397_01D397);
    State.IncCycles();
    // CALL 0x1000:b2b9 (1000_2C5D / 0x12C5D)
    NearCall(cs1, 0x2C60, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    State.IncCycles();
    // MOV AX,0xbb8 (1000_2C60 / 0x12C60)
    AX = 0xBB8;
    State.IncCycles();
    // CALL 0x1000:ddb0 (1000_2C63 / 0x12C63)
    NearCall(cs1, 0x2C66, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    State.IncCycles();
    // CALL 0x1000:b2b3 (1000_2C66 / 0x12C66)
    NearCall(cs1, 0x2C69, spice86_generated_label_call_target_1000_B2B3_01B2B3);
    State.IncCycles();
    // MOV SI,0x2cc7 (1000_2C69 / 0x12C69)
    SI = 0x2CC7;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_2C6C / 0x12C6C)
    NearCall(cs1, 0x2C6F, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    State.IncCycles();
    // CALL 0x1000:98e6 (1000_2C6F / 0x12C6F)
    NearCall(cs1, 0x2C72, spice86_generated_label_call_target_1000_98E6_0198E6);
    State.IncCycles();
    // XOR AX,AX (1000_2C72 / 0x12C72)
    AX = 0;
    State.IncCycles();
    // MOV [0x479e],AX (1000_2C74 / 0x12C74)
    UInt16[DS, 0x479E] = AX;
    State.IncCycles();
    // MOV [0x4540],AX (1000_2C77 / 0x12C77)
    UInt16[DS, 0x4540] = AX;
    State.IncCycles();
    // MOV byte ptr [0xea],0xff (1000_2C7A / 0x12C7A)
    UInt8[DS, 0xEA] = 0xFF;
    State.IncCycles();
    // MOV byte ptr [0xe8],0xa (1000_2C7F / 0x12C7F)
    UInt8[DS, 0xE8] = 0xA;
    State.IncCycles();
    // MOV word ptr [0xdc30],0x0 (1000_2C84 / 0x12C84)
    UInt16[DS, 0xDC30] = 0x0;
    State.IncCycles();
    // MOV AL,0x6 (1000_2C8A / 0x12C8A)
    AL = 0x6;
    State.IncCycles();
    // CALL 0x1000:189a (1000_2C8C / 0x12C8C)
    NearCall(cs1, 0x2C8F, spice86_generated_label_call_target_1000_189A_01189A);
    State.IncCycles();
    // JMP 0x1000:c412 (1000_2C8F / 0x12C8F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C412_01C412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2C92_012C92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2C92_12C92:
    // MOV AL,0x6 (1000_2C92 / 0x12C92)
    AL = 0x6;
    State.IncCycles();
    // MOV BP,0x2c9a (1000_2C94 / 0x12C94)
    BP = 0x2C9A;
    State.IncCycles();
    // JMP 0x1000:c108 (1000_2C97 / 0x12C97)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C108_01C108, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2D74_012D74(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2D74_12D74:
    // MOV SI,word ptr [0x114e] (1000_2D74 / 0x12D74)
    SI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CMP SI,0x100 (1000_2D78 / 0x12D78)
    Alu.Sub16(SI, 0x100);
    State.IncCycles();
    // JC 0x1000:2db0 (1000_2D7C / 0x12D7C)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    State.IncCycles();
    // XOR AX,AX (1000_2D7E / 0x12D7E)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:5e4f (1000_2D80 / 0x12D80)
    NearCall(cs1, 0x2D83, spice86_generated_label_call_target_1000_5E4F_015E4F);
    State.IncCycles();
    label_1000_2D83_12D83:
    // CMP AX,0x2 (1000_2D83 / 0x12D83)
    Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // JNC 0x1000:2d8f (1000_2D86 / 0x12D86)
    if(!CarryFlag) {
      goto label_1000_2D8F_12D8F;
    }
    State.IncCycles();
    // TEST byte ptr [0x4732],0x1 (1000_2D88 / 0x12D88)
    Alu.And8(UInt8[DS, 0x4732], 0x1);
    State.IncCycles();
    // JNZ 0x1000:2db0 (1000_2D8D / 0x12D8D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    State.IncCycles();
    label_1000_2D8F_12D8F:
    // CMP AX,0x4 (1000_2D8F / 0x12D8F)
    Alu.Sub16(AX, 0x4);
    State.IncCycles();
    // JA 0x1000:2db0 (1000_2D92 / 0x12D92)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    State.IncCycles();
    // JNZ 0x1000:2d97 (1000_2D94 / 0x12D94)
    if(!ZeroFlag) {
      goto label_1000_2D97_12D97;
    }
    State.IncCycles();
    // DEC AX (1000_2D96 / 0x12D96)
    AX--;
    State.IncCycles();
    label_1000_2D97_12D97:
    // CMP byte ptr [0x144c],AL (1000_2D97 / 0x12D97)
    Alu.Sub8(UInt8[DS, 0x144C], AL);
    State.IncCycles();
    // JZ 0x1000:2db0 (1000_2D9B / 0x12D9B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0x144c],AL (1000_2D9D / 0x12D9D)
    UInt8[DS, 0x144C] = AL;
    State.IncCycles();
    // ADD AX,0xa1 (1000_2DA0 / 0x12DA0)
    // AX += 0xA1;
    AX = Alu.Add16(AX, 0xA1);
    State.IncCycles();
    // PUSH DS (1000_2DA3 / 0x12DA3)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_2DA4 / 0x12DA4)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0xbc6e (1000_2DA5 / 0x12DA5)
    DI = 0xBC6E;
    State.IncCycles();
    // MOV SI,AX (1000_2DA8 / 0x12DA8)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_2DAA / 0x12DAA)
    NearCall(cs1, 0x2DAD, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2DAD_012DAD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2DAD_012DAD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DAD_12DAD:
    // CALL 0x1000:0098 (1000_2DAD / 0x12DAD)
    NearCall(cs1, 0x2DB0, spice86_generated_label_call_target_1000_0098_010098);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2DB0_012DB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2DB0_012DB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DB0_12DB0:
    // RET  (1000_2DB0 / 0x12DB0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2DB1_012DB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DB1_12DB1:
    // MOV BP,0xd717 (1000_2DB1 / 0x12DB1)
    BP = 0xD717;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_2DB4 / 0x12DB4)
    NearCall(cs1, 0x2DB7, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2DB7_012DB7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2DB7_012DB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DB7_12DB7:
    // CALL 0x1000:d95b (1000_2DB7 / 0x12DB7)
    NearCall(cs1, 0x2DBA, spice86_generated_label_call_target_1000_D95B_01D95B);
    State.IncCycles();
    label_1000_2DBA_12DBA:
    // MOV byte ptr [0x47a6],0xff (1000_2DBA / 0x12DBA)
    UInt8[DS, 0x47A6] = 0xFF;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2DBF_012DBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2DBF_012DBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DBF_12DBF:
    // CALL 0x1000:2d74 (1000_2DBF / 0x12DBF)
    NearCall(cs1, 0x2DC2, spice86_generated_label_call_target_1000_2D74_012D74);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2DC2_012DC2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2DC2_012DC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DC2_12DC2:
    // XOR AX,AX (1000_2DC2 / 0x12DC2)
    AX = 0;
    State.IncCycles();
    // MOV [0xdce6],AL (1000_2DC4 / 0x12DC4)
    UInt8[DS, 0xDCE6] = AL;
    State.IncCycles();
    // MOV [0x47a4],AL (1000_2DC7 / 0x12DC7)
    UInt8[DS, 0x47A4] = AL;
    State.IncCycles();
    // MOV [0x47aa],AX (1000_2DCA / 0x12DCA)
    UInt16[DS, 0x47AA] = AX;
    State.IncCycles();
    // MOV BP,0x2eb2 (1000_2DCD / 0x12DCD)
    BP = 0x2EB2;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_2DD0 / 0x12DD0)
    NearCall(cs1, 0x2DD3, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2DD3_012DD3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2DD3_012DD3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2DD3_12DD3:
    // CMP byte ptr [0x2b],0x0 (1000_2DD3 / 0x12DD3)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JZ 0x1000:2dfb (1000_2DD8 / 0x12DD8)
    if(ZeroFlag) {
      goto label_1000_2DFB_12DFB;
    }
    State.IncCycles();
    // MOV byte ptr [0x4732],0x0 (1000_2DDA / 0x12DDA)
    UInt8[DS, 0x4732] = 0x0;
    State.IncCycles();
    // CALL 0x1000:2d74 (1000_2DDF / 0x12DDF)
    NearCall(cs1, 0x2DE2, spice86_generated_label_call_target_1000_2D74_012D74);
    State.IncCycles();
    // OR byte ptr [0x11bc],0x1 (1000_2DE2 / 0x12DE2)
    // UInt8[DS, 0x11BC] |= 0x1;
    UInt8[DS, 0x11BC] = Alu.Or8(UInt8[DS, 0x11BC], 0x1);
    State.IncCycles();
    // MOV byte ptr [0x46df],0x0 (1000_2DE7 / 0x12DE7)
    UInt8[DS, 0x46DF] = 0x0;
    State.IncCycles();
    // CALL 0x1000:0acd (1000_2DEC / 0x12DEC)
    NearCall(cs1, 0x2DEF, not_observed_1000_0ACD_010ACD);
    State.IncCycles();
    // CALL 0x1000:1797 (1000_2DEF / 0x12DEF)
    NearCall(cs1, 0x2DF2, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    // CALL 0x1000:c4cd (1000_2DF2 / 0x12DF2)
    NearCall(cs1, 0x2DF5, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_2DF5 / 0x12DF5)
    NearCall(cs1, 0x2DF8, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // JMP 0x1000:17e6 (1000_2DF8 / 0x12DF8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2DFB_12DFB:
    // TEST byte ptr [0x4732],0x1 (1000_2DFB / 0x12DFB)
    Alu.And8(UInt8[DS, 0x4732], 0x1);
    State.IncCycles();
    // JZ 0x1000:2e05 (1000_2E00 / 0x12E00)
    if(ZeroFlag) {
      goto label_1000_2E05_12E05;
    }
    State.IncCycles();
    // CALL 0x1000:488a (1000_2E02 / 0x12E02)
    NearCall(cs1, 0x2E05, not_observed_1000_488A_01488A);
    State.IncCycles();
    label_1000_2E05_12E05:
    // XOR AX,AX (1000_2E05 / 0x12E05)
    AX = 0;
    State.IncCycles();
    // MOV [0x14],AX (1000_2E07 / 0x12E07)
    UInt16[DS, 0x14] = AX;
    State.IncCycles();
    // MOV [0x46df],AL (1000_2E0A / 0x12E0A)
    UInt8[DS, 0x46DF] = AL;
    State.IncCycles();
    // CALL 0x1000:c07c (1000_2E0D / 0x12E0D)
    NearCall(cs1, 0x2E10, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_2E10_12E10:
    // CALL 0x1000:5ba0 (1000_2E10 / 0x12E10)
    NearCall(cs1, 0x2E13, spice86_generated_label_call_target_1000_5BA0_015BA0);
    State.IncCycles();
    label_1000_2E13_12E13:
    // CALL 0x1000:37b2 (1000_2E13 / 0x12E13)
    NearCall(cs1, 0x2E16, spice86_generated_label_call_target_1000_37B2_0137B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E16_012E16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2E16_012E16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2E16_12E16:
    // TEST byte ptr [0x11c9],0x3 (1000_2E16 / 0x12E16)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JNZ 0x1000:2e20 (1000_2E1B / 0x12E1B)
    if(!ZeroFlag) {
      goto label_1000_2E20_12E20;
    }
    State.IncCycles();
    // CALL 0x1000:c412 (1000_2E1D / 0x12E1D)
    NearCall(cs1, 0x2E20, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    label_1000_2E20_12E20:
    // CALL 0x1000:ad5e (1000_2E20 / 0x12E20)
    NearCall(cs1, 0x2E23, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E23_012E23, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2E23_012E23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2E23_12E23:
    // CALL 0x1000:1834 (1000_2E23 / 0x12E23)
    NearCall(cs1, 0x2E26, spice86_generated_label_call_target_1000_1834_011834);
    State.IncCycles();
    label_1000_2E26_12E26:
    // CALL 0x1000:1797 (1000_2E26 / 0x12E26)
    NearCall(cs1, 0x2E29, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    label_1000_2E29_12E29:
    // MOV AL,[0x46df] (1000_2E29 / 0x12E29)
    AL = UInt8[DS, 0x46DF];
    State.IncCycles();
    // MOV AH,AL (1000_2E2C / 0x12E2C)
    AH = AL;
    State.IncCycles();
    // XCHG byte ptr [0x46e0],AL (1000_2E2E / 0x12E2E)
    byte tmp_1000_2E2E = UInt8[DS, 0x46E0];
    UInt8[DS, 0x46E0] = AL;
    AL = tmp_1000_2E2E;
    State.IncCycles();
    // CMP AL,AH (1000_2E32 / 0x12E32)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JZ 0x1000:2e4c (1000_2E34 / 0x12E34)
    if(ZeroFlag) {
      goto label_1000_2E4C_12E4C;
    }
    State.IncCycles();
    // MOV AX,[0xdbd6] (1000_2E36 / 0x12E36)
    AX = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CMP AX,word ptr [0xdbd8] (1000_2E39 / 0x12E39)
    Alu.Sub16(AX, UInt16[DS, 0xDBD8]);
    State.IncCycles();
    // JZ 0x1000:2e52 (1000_2E3D / 0x12E3D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,0x10 (1000_2E3F / 0x12E3F)
    AL = 0x10;
    State.IncCycles();
    // MOV BP,0xf66 (1000_2E41 / 0x12E41)
    BP = 0xF66;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_2E44 / 0x12E44)
    NearCall(cs1, 0x2E47, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    label_1000_2E47_12E47:
    // CALL 0x1000:ae04 (1000_2E47 / 0x12E47)
    NearCall(cs1, 0x2E4A, spice86_generated_label_call_target_1000_AE04_01AE04);
    State.IncCycles();
    label_1000_2E4A_12E4A:
    // JMP 0x1000:2e52 (1000_2E4A / 0x12E4A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2E4C_12E4C:
    // CALL 0x1000:c0f4 (1000_2E4C / 0x12E4C)
    NearCall(cs1, 0x2E4F, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    label_1000_2E4F_12E4F:
    // CALL 0x1000:c4cd (1000_2E4F / 0x12E4F)
    NearCall(cs1, 0x2E52, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2E52_012E52(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2E52_12E52:
    // CALL 0x1000:35ad (1000_2E52 / 0x12E52)
    NearCall(cs1, 0x2E55, spice86_generated_label_call_target_1000_35AD_0135AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E55_012E55, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2E55_012E55(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2E55_12E55:
    // MOV AX,[0xce7a] (1000_2E55 / 0x12E55)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0xdc5a],AX (1000_2E58 / 0x12E58)
    UInt16[DS, 0xDC5A] = AX;
    State.IncCycles();
    // CMP byte ptr [0x47a7],0x0 (1000_2E5B / 0x12E5B)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2e97 (1000_2E60 / 0x12E60)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,[0x4735] (1000_2E62 / 0x12E62)
    AL = UInt8[DS, 0x4735];
    State.IncCycles();
    // OR AL,AL (1000_2E65 / 0x12E65)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:2e6c (1000_2E67 / 0x12E67)
    if(!SignFlag) {
      goto label_1000_2E6C_12E6C;
    }
    State.IncCycles();
    // JMP 0x1000:3723 (1000_2E69 / 0x12E69)
    throw FailAsUntested("Would have been a goto but label label_1000_3723_13723 does not exist because no instruction was found there that belongs to a function.");
    State.IncCycles();
    label_1000_2E6C_12E6C:
    // CMP byte ptr [0x8],0xff (1000_2E6C / 0x12E6C)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    State.IncCycles();
    // JZ 0x1000:2e7d (1000_2E71 / 0x12E71)
    if(ZeroFlag) {
      goto label_1000_2E7D_12E7D;
    }
    State.IncCycles();
    // CMP byte ptr [0x4774],0x0 (1000_2E73 / 0x12E73)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2e97 (1000_2E78 / 0x12E78)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:17e6 (1000_2E7A / 0x12E7A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2E7D_12E7D:
    // CMP byte ptr [0x11c9],0x0 (1000_2E7D / 0x12E7D)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2e97 (1000_2E82 / 0x12E82)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47aa] (1000_2E84 / 0x12E84)
    SI = UInt16[DS, 0x47AA];
    State.IncCycles();
    // OR SI,SI (1000_2E88 / 0x12E88)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:2e97 (1000_2E8A / 0x12E8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    State.IncCycles();
    // XOR AX,AX (1000_2E8C / 0x12E8C)
    AX = 0;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0xe] (1000_2E8E / 0x12E8E)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV [0x47c4],AX (1000_2E91 / 0x12E91)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // CALL 0x1000:978e (1000_2E94 / 0x12E94)
    NearCall(cs1, 0x2E97, spice86_generated_label_call_target_1000_978E_01978E);
    State.IncCycles();
    label_1000_2E97_12E97:
    // RET  (1000_2E97 / 0x12E97)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2E98_012E98(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2E98_12E98:
    // MOV word ptr [0x47e6],DI (1000_2E98 / 0x12E98)
    UInt16[DS, 0x47E6] = DI;
    State.IncCycles();
    // XOR AH,AH (1000_2E9C / 0x12E9C)
    AH = 0;
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_2E9E / 0x12E9E)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // ADD AX,0x0 (1000_2EA0 / 0x12EA0)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    State.IncCycles();
    // MOV [0x11ed],AX (1000_2EA3 / 0x12EA3)
    UInt16[DS, 0x11ED] = AX;
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x1] (1000_2EA6 / 0x12EA6)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    State.IncCycles();
    // XOR AH,AH (1000_2EA9 / 0x12EA9)
    AH = 0;
    State.IncCycles();
    // ADD AX,0xc (1000_2EAB / 0x12EAB)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    State.IncCycles();
    // MOV [0x11ef],AX (1000_2EAE / 0x12EAE)
    UInt16[DS, 0x11EF] = AX;
    State.IncCycles();
    // RET  (1000_2EB1 / 0x12EB1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2EB2_012EB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2EB2_12EB2:
    // CMP byte ptr [0x4774],0x0 (1000_2EB2 / 0x12EB2)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JZ 0x1000:2ec9 (1000_2EB7 / 0x12EB7)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_2EC9_012EC9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:301a (1000_2EB9 / 0x12EB9)
    NearCall(cs1, 0x2EBC, spice86_label_1000_301A_1301A);
    State.IncCycles();
    // CALL 0x1000:98e6 (1000_2EBC / 0x12EBC)
    NearCall(cs1, 0x2EBF, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_2EBF_012EBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2EBF_012EBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2EBF_12EBF:
    // MOV BP,word ptr [0x2220] (1000_2EBF / 0x12EBF)
    BP = UInt16[DS, 0x2220];
    State.IncCycles();
    // MOV BX,0xf66 (1000_2EC3 / 0x12EC3)
    BX = 0xF66;
    State.IncCycles();
    // JMP 0x1000:d338 (1000_2EC6 / 0x12EC6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D338_01D338, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_2EC9_012EC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2EC9_12EC9:
    // MOV DI,word ptr [0x114e] (1000_2EC9 / 0x12EC9)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:2e98 (1000_2ECD / 0x12ECD)
    NearCall(cs1, 0x2ED0, spice86_generated_label_call_target_1000_2E98_012E98);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2ED0_012ED0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2ED0_012ED0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2ED0_12ED0:
    // CALL 0x1000:2efb (1000_2ED0 / 0x12ED0)
    NearCall(cs1, 0x2ED3, spice86_generated_label_call_target_1000_2EFB_012EFB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2ED3_012ED3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2ED3_012ED3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2ED3_12ED3:
    // CMP byte ptr [0x11c9],0x0 (1000_2ED3 / 0x12ED3)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:2edd (1000_2ED8 / 0x12ED8)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2EDD_012EDD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:3090 (1000_2EDA / 0x12EDA)
    NearCall(cs1, 0x2EDD, spice86_generated_label_call_target_1000_3090_013090);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2EDD_012EDD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2EDD_012EDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2EDD_12EDD:
    // MOV AX,[0xdc38] (1000_2EDD / 0x12EDD)
    AX = UInt16[DS, 0xDC38];
    State.IncCycles();
    // CMP AX,0x74 (1000_2EE0 / 0x12EE0)
    Alu.Sub16(AX, 0x74);
    State.IncCycles();
    // JC 0x1000:2eec (1000_2EE3 / 0x12EE3)
    if(CarryFlag) {
      goto label_1000_2EEC_12EEC;
    }
    State.IncCycles();
    // MOV AX,0xdbec (1000_2EE5 / 0x12EE5)
    AX = 0xDBEC;
    State.IncCycles();
    // PUSH AX (1000_2EE8 / 0x12EE8)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_2EE9 / 0x12EE9)
    NearCall(cs1, 0x2EEC, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_2EEC_12EEC:
    // CALL 0x1000:2ffb (1000_2EEC / 0x12EEC)
    NearCall(cs1, 0x2EEF, spice86_generated_label_call_target_1000_2FFB_012FFB);
    State.IncCycles();
    label_1000_2EEF_12EEF:
    // CALL 0x1000:d763 (1000_2EEF / 0x12EEF)
    NearCall(cs1, 0x2EF2, spice86_generated_label_ret_target_1000_D763_01D763);
    State.IncCycles();
    label_1000_2EF2_12EF2:
    // MOV BP,0x1f0e (1000_2EF2 / 0x12EF2)
    BP = 0x1F0E;
    State.IncCycles();
    // MOV BX,0xf66 (1000_2EF5 / 0x12EF5)
    BX = 0xF66;
    State.IncCycles();
    // JMP 0x1000:d338 (1000_2EF8 / 0x12EF8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D338_01D338, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2EFB_012EFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2EFB_12EFB:
    // PUSH DS (1000_2EFB / 0x12EFB)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_2EFC / 0x12EFC)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x1f0f (1000_2EFD / 0x12EFD)
    DI = 0x1F0F;
    State.IncCycles();
    // XOR AL,AL (1000_2F00 / 0x12F00)
    AL = 0;
    State.IncCycles();
    // STOSB ES:DI (1000_2F02 / 0x12F02)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_2F03 / 0x12F03)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_2F07 / 0x12F07)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // CMP BL,0x80 (1000_2F0B / 0x12F0B)
    Alu.Sub8(BL, 0x80);
    State.IncCycles();
    // JZ 0x1000:2f13 (1000_2F0E / 0x12F0E)
    if(ZeroFlag) {
      goto label_1000_2F13_12F13;
    }
    State.IncCycles();
    // JMP 0x1000:2faa (1000_2F10 / 0x12F10)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FAA_012FAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2F13_12F13:
    // MOV SI,0x220c (1000_2F13 / 0x12F13)
    SI = 0x220C;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F16 / 0x12F16)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F17 / 0x12F17)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP DL,0x1 (1000_2F18 / 0x12F18)
    Alu.Sub8(DL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:2f58 (1000_2F1B / 0x12F1B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2F58_012F58, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x2b],0x0 (1000_2F1D / 0x12F1D)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JZ 0x1000:2f3d (1000_2F22 / 0x12F22)
    if(ZeroFlag) {
      goto label_1000_2F3D_12F3D;
    }
    State.IncCycles();
    // MOV SI,0x2218 (1000_2F24 / 0x12F24)
    SI = 0x2218;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F27 / 0x12F27)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F28 / 0x12F28)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F29 / 0x12F29)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F2A / 0x12F2A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV SI,0x2214 (1000_2F2B / 0x12F2B)
    SI = 0x2214;
    State.IncCycles();
    // LODSW SI (1000_2F2E / 0x12F2E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP byte ptr [0x2a],0x4f (1000_2F2F / 0x12F2F)
    Alu.Sub8(UInt8[DS, 0x2A], 0x4F);
    State.IncCycles();
    // SBB AH,AH (1000_2F34 / 0x12F34)
    AH = Alu.Sbb8(AH, AH);
    State.IncCycles();
    // AND AH,0x40 (1000_2F36 / 0x12F36)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    State.IncCycles();
    // STOSW ES:DI (1000_2F39 / 0x12F39)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F3A / 0x12F3A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JMP 0x1000:2fa3 (1000_2F3B / 0x12F3B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_2F3D_12F3D:
    // PUSH DI (1000_2F3D / 0x12F3D)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_2F3E / 0x12F3E)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_2F42 / 0x12F42)
    NearCall(cs1, 0x2F45, spice86_generated_label_call_target_1000_7F27_017F27);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2F45_012F45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2F45_012F45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2F45_12F45:
    // POP DI (1000_2F45 / 0x12F45)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x21dc (1000_2F46 / 0x12F46)
    SI = 0x21DC;
    State.IncCycles();
    // LODSW SI (1000_2F49 / 0x12F49)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP byte ptr [0x46ff],0x1 (1000_2F4A / 0x12F4A)
    Alu.Sub8(UInt8[DS, 0x46FF], 0x1);
    State.IncCycles();
    // SBB AH,AH (1000_2F4F / 0x12F4F)
    AH = Alu.Sbb8(AH, AH);
    State.IncCycles();
    // AND AH,0x40 (1000_2F51 / 0x12F51)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    State.IncCycles();
    // STOSW ES:DI (1000_2F54 / 0x12F54)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F55 / 0x12F55)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JMP 0x1000:2fa3 (1000_2F56 / 0x12F56)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_2F58_012F58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2F58_12F58:
    // CMP BH,0x1 (1000_2F58 / 0x12F58)
    Alu.Sub8(BH, 0x1);
    State.IncCycles();
    // JNZ 0x1000:2fa3 (1000_2F5B / 0x12F5B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP DL,0x8 (1000_2F5D / 0x12F5D)
    Alu.Sub8(DL, 0x8);
    State.IncCycles();
    // JNZ 0x1000:2f99 (1000_2F60 / 0x12F60)
    if(!ZeroFlag) {
      goto label_1000_2F99_12F99;
    }
    State.IncCycles();
    // CMP byte ptr [0xc8],0x0 (1000_2F62 / 0x12F62)
    Alu.Sub8(UInt8[DS, 0xC8], 0x0);
    State.IncCycles();
    // JZ 0x1000:2fa3 (1000_2F67 / 0x12F67)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x21e8 (1000_2F69 / 0x12F69)
    SI = 0x21E8;
    State.IncCycles();
    // LODSW SI (1000_2F6C / 0x12F6C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CL,byte ptr [0xc9] (1000_2F6D / 0x12F6D)
    CL = UInt8[DS, 0xC9];
    State.IncCycles();
    // MOV CH,0x27 (1000_2F71 / 0x12F71)
    CH = 0x27;
    State.IncCycles();
    // CMP CL,0x1 (1000_2F73 / 0x12F73)
    Alu.Sub8(CL, 0x1);
    State.IncCycles();
    // SBB AH,AH (1000_2F76 / 0x12F76)
    AH = Alu.Sbb8(AH, AH);
    State.IncCycles();
    // ADD CH,AH (1000_2F78 / 0x12F78)
    CH += AH;
    State.IncCycles();
    // CMP byte ptr [0x47a9],0x0 (1000_2F7A / 0x12F7A)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    State.IncCycles();
    // JZ 0x1000:2f83 (1000_2F7F / 0x12F7F)
    if(ZeroFlag) {
      goto label_1000_2F83_12F83;
    }
    State.IncCycles();
    // MOV CH,0x28 (1000_2F81 / 0x12F81)
    CH = 0x28;
    State.IncCycles();
    label_1000_2F83_12F83:
    // MOV byte ptr [0x1248],CH (1000_2F83 / 0x12F83)
    UInt8[DS, 0x1248] = CH;
    State.IncCycles();
    // AND AH,0x40 (1000_2F87 / 0x12F87)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    State.IncCycles();
    // STOSW ES:DI (1000_2F8A / 0x12F8A)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F8B / 0x12F8B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_2F8C / 0x12F8C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP CL,byte ptr [0xc8] (1000_2F8D / 0x12F8D)
    Alu.Sub8(CL, UInt8[DS, 0xC8]);
    State.IncCycles();
    // CMC  (1000_2F91 / 0x12F91)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // SBB AH,AH (1000_2F92 / 0x12F92)
    AH = Alu.Sbb8(AH, AH);
    State.IncCycles();
    // AND AH,0x40 (1000_2F94 / 0x12F94)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    State.IncCycles();
    // STOSW ES:DI (1000_2F97 / 0x12F97)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2F98 / 0x12F98)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    label_1000_2F99_12F99:
    // CMP DL,0x9 (1000_2F99 / 0x12F99)
    Alu.Sub8(DL, 0x9);
    State.IncCycles();
    // JNZ 0x1000:2fa3 (1000_2F9C / 0x12F9C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x21f0 (1000_2F9E / 0x12F9E)
    SI = 0x21F0;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FA1 / 0x12FA1)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FA2 / 0x12FA2)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_2FA3_012FA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2FA3_12FA3:
    // MOV SI,0x21f4 (1000_2FA3 / 0x12FA3)
    SI = 0x21F4;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FA6 / 0x12FA6)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FA7 / 0x12FA7)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JMP 0x1000:2ff7 (1000_2FA8 / 0x12FA8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FF7_012FF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_2FAA_012FAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2FAA_12FAA:
    // TEST byte ptr [0x11c9],0x3 (1000_2FAA / 0x12FAA)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JNZ 0x1000:2fd7 (1000_2FAF / 0x12FAF)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FD7_012FD7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x220c (1000_2FB1 / 0x12FB1)
    SI = 0x220C;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FB4 / 0x12FB4)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FB5 / 0x12FB5)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV SI,0x2214 (1000_2FB6 / 0x12FB6)
    SI = 0x2214;
    State.IncCycles();
    // LODSW SI (1000_2FB9 / 0x12FB9)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP byte ptr [0x2a],0x4f (1000_2FBA / 0x12FBA)
    Alu.Sub8(UInt8[DS, 0x2A], 0x4F);
    State.IncCycles();
    // SBB AH,AH (1000_2FBF / 0x12FBF)
    AH = Alu.Sbb8(AH, AH);
    State.IncCycles();
    // AND AH,0x40 (1000_2FC1 / 0x12FC1)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    State.IncCycles();
    // STOSW ES:DI (1000_2FC4 / 0x12FC4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FC5 / 0x12FC5)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CALL 0x1000:1ae0 (1000_2FC6 / 0x12FC6)
    NearCall(cs1, 0x2FC9, spice86_generated_label_call_target_1000_1AE0_011AE0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2FC9_012FC9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_2FC9_012FC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2FC9_12FC9:
    // MOV SI,0x21e0 (1000_2FC9 / 0x12FC9)
    SI = 0x21E0;
    State.IncCycles();
    // CMP AL,0xb (1000_2FCC / 0x12FCC)
    Alu.Sub8(AL, 0xB);
    State.IncCycles();
    // JC 0x1000:2fd3 (1000_2FCE / 0x12FCE)
    if(CarryFlag) {
      goto label_1000_2FD3_12FD3;
    }
    State.IncCycles();
    // ADD SI,0x4 (1000_2FD0 / 0x12FD0)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    label_1000_2FD3_12FD3:
    // MOVSW ES:DI,SI (1000_2FD3 / 0x12FD3)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FD4 / 0x12FD4)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JMP 0x1000:2fa3 (1000_2FD5 / 0x12FD5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_2FD7_012FD7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2FD7_12FD7:
    // MOV SI,0x21fc (1000_2FD7 / 0x12FD7)
    SI = 0x21FC;
    State.IncCycles();
    // CMP byte ptr [0x11cb],0x0 (1000_2FDA / 0x12FDA)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    State.IncCycles();
    // JZ 0x1000:2ff0 (1000_2FDF / 0x12FDF)
    if(ZeroFlag) {
      goto label_1000_2FF0_12FF0;
    }
    State.IncCycles();
    // MOV SI,0x2200 (1000_2FE1 / 0x12FE1)
    SI = 0x2200;
    State.IncCycles();
    // CMP byte ptr [0x2a],0x32 (1000_2FE4 / 0x12FE4)
    Alu.Sub8(UInt8[DS, 0x2A], 0x32);
    State.IncCycles();
    // JC 0x1000:2ff0 (1000_2FE9 / 0x12FE9)
    if(CarryFlag) {
      goto label_1000_2FF0_12FF0;
    }
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FEB / 0x12FEB)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FEC / 0x12FEC)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV SI,0x2204 (1000_2FED / 0x12FED)
    SI = 0x2204;
    State.IncCycles();
    label_1000_2FF0_12FF0:
    // MOVSW ES:DI,SI (1000_2FF0 / 0x12FF0)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FF1 / 0x12FF1)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV SI,0x21f8 (1000_2FF2 / 0x12FF2)
    SI = 0x21F8;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FF5 / 0x12FF5)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_2FF6 / 0x12FF6)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FF7_012FF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_2FF7_012FF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2FF7_12FF7:
    // XOR AX,AX (1000_2FF7 / 0x12FF7)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_2FF9 / 0x12FF9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // RET  (1000_2FFA / 0x12FFA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2FFB_012FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_2FFB_12FFB:
    // CMP byte ptr [0x2b],0x0 (1000_2FFB / 0x12FFB)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JNZ 0x1000:301a (1000_3000 / 0x13000)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_301A_1301A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // TEST byte ptr [0x11c9],0x3 (1000_3002 / 0x13002)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JZ 0x1000:3020 (1000_3007 / 0x13007)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_3020_013020, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x11ca],0x0 (1000_3009 / 0x13009)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:301a (1000_300E / 0x1300E)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_301A_1301A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x1d72 (1000_3010 / 0x13010)
    SI = 0x1D72;
    State.IncCycles();
    // CMP byte ptr [0x11cb],0x0 (1000_3013 / 0x13013)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:301d (1000_3018 / 0x13018)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d72b (1000_301D / 0x1301D)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_label_1000_301A_1301A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_label_1000_301A_1301A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x301D: goto label_1000_301D_1301D;break; // Target of external jump from 0x13018
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_301A_1301A:
    // MOV SI,0x1d1e (1000_301A / 0x1301A)
    SI = 0x1D1E;
    State.IncCycles();
    label_1000_301D_1301D:
    // JMP 0x1000:d72b (1000_301D / 0x1301D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_3020_013020(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3020_13020:
    // MOV BX,word ptr [0x6] (1000_3020 / 0x13020)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP BL,0x80 (1000_3024 / 0x13024)
    Alu.Sub8(BL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:3073 (1000_3027 / 0x13027)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3073_013073, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_3029 / 0x13029)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // CMP DH,0x21 (1000_302D / 0x1302D)
    Alu.Sub8(DH, 0x21);
    State.IncCycles();
    // JZ 0x1000:3073 (1000_3030 / 0x13030)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3073_013073, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:3efe (1000_3032 / 0x13032)
    NearCall(cs1, 0x3035, spice86_generated_label_call_target_1000_3EFE_013EFE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3035_013035, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3035_013035(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3035_13035:
    // INC SI (1000_3035 / 0x13035)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV DI,0x1b96 (1000_3036 / 0x13036)
    DI = 0x1B96;
    State.IncCycles();
    // MOV AL,0x20 (1000_3039 / 0x13039)
    AL = 0x20;
    State.IncCycles();
    // CMP word ptr [0x114e],0x100 (1000_303B / 0x1303B)
    Alu.Sub16(UInt16[DS, 0x114E], 0x100);
    State.IncCycles();
    // JNZ 0x1000:3045 (1000_3041 / 0x13041)
    if(!ZeroFlag) {
      goto label_1000_3045_13045;
    }
    State.IncCycles();
    // MOV AL,0x80 (1000_3043 / 0x13043)
    AL = 0x80;
    State.IncCycles();
    label_1000_3045_13045:
    // MOV BX,0x21 (1000_3045 / 0x13045)
    BX = 0x21;
    State.IncCycles();
    // CMP DL,0x1 (1000_3048 / 0x13048)
    Alu.Sub8(DL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:3050 (1000_304B / 0x1304B)
    if(!ZeroFlag) {
      goto label_1000_3050_13050;
    }
    State.IncCycles();
    // INC BX (1000_304D / 0x1304D)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // MOV AL,0x20 (1000_304E / 0x1304E)
    AL = 0x20;
    State.IncCycles();
    label_1000_3050_13050:
    // MOV word ptr [DI + 0x2],BX (1000_3050 / 0x13050)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    State.IncCycles();
    // MOV byte ptr [DI + 0x46],AL (1000_3053 / 0x13053)
    UInt8[DS, (ushort)(DI + 0x46)] = AL;
    State.IncCycles();
    // MOV [0x1cc4],AL (1000_3056 / 0x13056)
    UInt8[DS, 0x1CC4] = AL;
    State.IncCycles();
    // MOV CX,0x4 (1000_3059 / 0x13059)
    CX = 0x4;
    State.IncCycles();
    label_1000_305C_1305C:
    // LODSB SI (1000_305C / 0x1305C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // ADD DI,0xe (1000_305D / 0x1305D)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    State.IncCycles();
    // MOV AH,0x20 (1000_3060 / 0x13060)
    AH = 0x20;
    State.IncCycles();
    // OR AL,AL (1000_3062 / 0x13062)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:306c (1000_3064 / 0x13064)
    if(ZeroFlag) {
      goto label_1000_306C_1306C;
    }
    State.IncCycles();
    // CMP AL,0xfb (1000_3066 / 0x13066)
    Alu.Sub8(AL, 0xFB);
    State.IncCycles();
    // JL 0x1000:306c (1000_3068 / 0x13068)
    if(SignFlag != OverflowFlag) {
      goto label_1000_306C_1306C;
    }
    State.IncCycles();
    // MOV AH,0x80 (1000_306A / 0x1306A)
    AH = 0x80;
    State.IncCycles();
    label_1000_306C_1306C:
    // MOV byte ptr [DI],AH (1000_306C / 0x1306C)
    UInt8[DS, DI] = AH;
    State.IncCycles();
    // LOOP 0x1000:305c (1000_306E / 0x1306E)
    if(--CX != 0) {
      goto label_1000_305C_1305C;
    }
    State.IncCycles();
    // JMP 0x1000:d735 (1000_3070 / 0x13070)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D735_01D735, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3073_013073(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3073_13073:
    // MOV DI,0x1b98 (1000_3073 / 0x13073)
    DI = 0x1B98;
    State.IncCycles();
    // MOV word ptr [DI],0x23 (1000_3076 / 0x13076)
    UInt16[DS, DI] = 0x23;
    State.IncCycles();
    // MOV BX,0x1d (1000_307A / 0x1307A)
    BX = 0x1D;
    State.IncCycles();
    // MOV CX,0x4 (1000_307D / 0x1307D)
    CX = 0x4;
    State.IncCycles();
    label_1000_3080_13080:
    // ADD DI,0xe (1000_3080 / 0x13080)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    State.IncCycles();
    // MOV word ptr [DI],BX (1000_3083 / 0x13083)
    UInt16[DS, DI] = BX;
    State.IncCycles();
    // MOV word ptr [DI + -0x2],0x80 (1000_3085 / 0x13085)
    UInt16[DS, (ushort)(DI - 0x2)] = 0x80;
    State.IncCycles();
    // INC BX (1000_308A / 0x1308A)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // LOOP 0x1000:3080 (1000_308B / 0x1308B)
    if(--CX != 0) {
      goto label_1000_3080_13080;
    }
    State.IncCycles();
    // JMP 0x1000:d735 (1000_308D / 0x1308D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D735_01D735, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3090_013090(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3090_13090:
    // CALL 0x1000:98e6 (1000_3090 / 0x13090)
    NearCall(cs1, 0x3093, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3093_013093, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3093_013093(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3093_13093:
    // CALL 0x1000:3127 (1000_3093 / 0x13093)
    NearCall(cs1, 0x3096, spice86_generated_label_call_target_1000_3127_013127);
    State.IncCycles();
    label_1000_3096_13096:
    // MOV DI,0x1f0c (1000_3096 / 0x13096)
    DI = 0x1F0C;
    State.IncCycles();
    label_1000_3099_13099:
    // ADD DI,0x4 (1000_3099 / 0x13099)
    DI += 0x4;
    State.IncCycles();
    // CMP word ptr [DI],0x0 (1000_309C / 0x1309C)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    State.IncCycles();
    // JNZ 0x1000:3099 (1000_309F / 0x1309F)
    if(!ZeroFlag) {
      goto label_1000_3099_13099;
    }
    State.IncCycles();
    // MOV word ptr [0x12],0x0 (1000_30A1 / 0x130A1)
    UInt16[DS, 0x12] = 0x0;
    State.IncCycles();
    // PUSH DS (1000_30A7 / 0x130A7)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_30A8 / 0x130A8)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV BP,0x30b9 (1000_30A9 / 0x130A9)
    BP = 0x30B9;
    State.IncCycles();
    // CALL 0x1000:36ee (1000_30AC / 0x130AC)
    NearCall(cs1, 0x30AF, spice86_generated_label_call_target_1000_36EE_0136EE);
    State.IncCycles();
    label_1000_30AF_130AF:
    // MOV BP,0x3120 (1000_30AF / 0x130AF)
    BP = 0x3120;
    State.IncCycles();
    // CALL 0x1000:36ee (1000_30B2 / 0x130B2)
    NearCall(cs1, 0x30B5, spice86_generated_label_call_target_1000_36EE_0136EE);
    State.IncCycles();
    label_1000_30B5_130B5:
    // XOR AX,AX (1000_30B5 / 0x130B5)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_30B7 / 0x130B7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // RET  (1000_30B8 / 0x130B8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_30B9_0130B9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x30CA: goto label_1000_30CA_130CA;break; // Target of external jump from 0x130C4, 0x13124
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_30B9_130B9:
    // TEST byte ptr [SI + 0xf],0x40 (1000_30B9 / 0x130B9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:311f (1000_30BD / 0x130BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x47aa],0x0 (1000_30BF / 0x130BF)
    Alu.Sub16(UInt16[DS, 0x47AA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:30ca (1000_30C4 / 0x130C4)
    if(!ZeroFlag) {
      goto label_1000_30CA_130CA;
    }
    State.IncCycles();
    // MOV word ptr [0x47aa],SI (1000_30C6 / 0x130C6)
    UInt16[DS, 0x47AA] = SI;
    State.IncCycles();
    label_1000_30CA_130CA:
    // MOV AL,byte ptr [SI + 0xe] (1000_30CA / 0x130CA)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV CL,AL (1000_30CD / 0x130CD)
    CL = AL;
    State.IncCycles();
    // XOR AH,AH (1000_30CF / 0x130CF)
    AH = 0;
    State.IncCycles();
    // ADD AX,0x78 (1000_30D1 / 0x130D1)
    // AX += 0x78;
    AX = Alu.Add16(AX, 0x78);
    State.IncCycles();
    // STOSW ES:DI (1000_30D4 / 0x130D4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,0x1 (1000_30D5 / 0x130D5)
    AX = 0x1;
    State.IncCycles();
    // SHL AX,CL (1000_30D8 / 0x130D8)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    State.IncCycles();
    // OR word ptr [0x12],AX (1000_30DA / 0x130DA)
    // UInt16[DS, 0x12] |= AX;
    UInt16[DS, 0x12] = Alu.Or16(UInt16[DS, 0x12], AX);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x4] (1000_30DE / 0x130DE)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // STOSW ES:DI (1000_30E1 / 0x130E1)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP CL,0xf (1000_30E2 / 0x130E2)
    Alu.Sub8(CL, 0xF);
    State.IncCycles();
    // JNZ 0x1000:311f (1000_30E5 / 0x130E5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x476a] (1000_30E7 / 0x130E7)
    CL = UInt8[DS, 0x476A];
    State.IncCycles();
    // XOR CH,CH (1000_30EB / 0x130EB)
    CH = 0;
    State.IncCycles();
    // DEC CX (1000_30ED / 0x130ED)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JLE 0x1000:30fe (1000_30EE / 0x130EE)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_30FE_130FE;
    }
    State.IncCycles();
    // PUSH SI (1000_30F0 / 0x130F0)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,AX (1000_30F1 / 0x130F1)
    SI = AX;
    State.IncCycles();
    // MOV AX,0x87 (1000_30F3 / 0x130F3)
    AX = 0x87;
    State.IncCycles();
    label_1000_30F6_130F6:
    // INC AX (1000_30F6 / 0x130F6)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // STOSW ES:DI (1000_30F7 / 0x130F7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // XCHG AX,SI (1000_30F8 / 0x130F8)
    ushort tmp_1000_30F8 = AX;
    AX = SI;
    SI = tmp_1000_30F8;
    State.IncCycles();
    // STOSW ES:DI (1000_30F9 / 0x130F9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // XCHG AX,SI (1000_30FA / 0x130FA)
    ushort tmp_1000_30FA = AX;
    AX = SI;
    SI = tmp_1000_30FA;
    State.IncCycles();
    // LOOP 0x1000:30f6 (1000_30FB / 0x130FB)
    if(--CX != 0) {
      goto label_1000_30F6_130F6;
    }
    State.IncCycles();
    // POP SI (1000_30FD / 0x130FD)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_30FE_130FE:
    // CMP byte ptr [0x2a],0x5 (1000_30FE / 0x130FE)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5);
    State.IncCycles();
    // JC 0x1000:311f (1000_3103 / 0x13103)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,[0x476b] (1000_3105 / 0x13105)
    AL = UInt8[DS, 0x476B];
    State.IncCycles();
    // OR AL,AL (1000_3108 / 0x13108)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:311f (1000_310A / 0x1310A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    State.IncCycles();
    // PUSH DI (1000_310C / 0x1310C)
    Stack.Push(DI);
    State.IncCycles();
    // DEC AL (1000_310D / 0x1310D)
    AL--;
    State.IncCycles();
    // SUB AL,byte ptr [0x476a] (1000_310F / 0x1310F)
    // AL -= UInt8[DS, 0x476A];
    AL = Alu.Sub8(AL, UInt8[DS, 0x476A]);
    State.IncCycles();
    // CBW  (1000_3113 / 0x13113)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SHL AX,1 (1000_3114 / 0x13114)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3116 / 0x13116)
    AX <<= 0x1;
    State.IncCycles();
    // ADD DI,AX (1000_3118 / 0x13118)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV word ptr [DI],0x8f (1000_311A / 0x1311A)
    UInt16[DS, DI] = 0x8F;
    State.IncCycles();
    // POP DI (1000_311E / 0x1311E)
    DI = Stack.Pop();
    State.IncCycles();
    label_1000_311F_1311F:
    // RET  (1000_311F / 0x1311F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3120_013120(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3120_13120:
    // TEST byte ptr [SI + 0xf],0x40 (1000_3120 / 0x13120)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:30ca (1000_3124 / 0x13124)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_30B9_0130B9, 0x130CA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_3126 / 0x13126)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3127_013127(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3127_13127:
    // MOV byte ptr [0x476b],0x0 (1000_3127 / 0x13127)
    UInt8[DS, 0x476B] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x476a],0x0 (1000_312C / 0x1312C)
    UInt8[DS, 0x476A] = 0x0;
    State.IncCycles();
    // MOV AX,0x7f80 (1000_3131 / 0x13131)
    AX = 0x7F80;
    State.IncCycles();
    // MOV [0x10ca],AX (1000_3134 / 0x13134)
    UInt16[DS, 0x10CA] = AX;
    State.IncCycles();
    // MOV [0x10ba],AX (1000_3137 / 0x13137)
    UInt16[DS, 0x10BA] = AX;
    State.IncCycles();
    // MOV [0x10aa],AX (1000_313A / 0x1313A)
    UInt16[DS, 0x10AA] = AX;
    State.IncCycles();
    // MOV [0x109a],AX (1000_313D / 0x1313D)
    UInt16[DS, 0x109A] = AX;
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_3140 / 0x13140)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP BL,0x80 (1000_3144 / 0x13144)
    Alu.Sub8(BL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:316d (1000_3147 / 0x13147)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_316D / 0x1316D)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_3149 / 0x13149)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_314D / 0x1314D)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV BP,0x316e (1000_3151 / 0x13151)
    BP = 0x316E;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_3154 / 0x13154)
    NearCall(cs1, 0x3157, spice86_generated_label_call_target_1000_6603_016603);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3157_013157, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3157_013157(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x316D: goto label_1000_316D_1316D;break; // Target of external jump from 0x13192, 0x13147
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_3157_13157:
    // CMP byte ptr [DI + 0x8],0x21 (1000_3157 / 0x13157)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x21);
    State.IncCycles();
    // JNZ 0x1000:316a (1000_315B / 0x1315B)
    if(!ZeroFlag) {
      goto label_1000_316A_1316A;
    }
    State.IncCycles();
    // MOV word ptr [0x10a8],DX (1000_315D / 0x1315D)
    UInt16[DS, 0x10A8] = DX;
    State.IncCycles();
    // MOV word ptr [0x10aa],BX (1000_3161 / 0x13161)
    UInt16[DS, 0x10AA] = BX;
    State.IncCycles();
    // PUSH DI (1000_3165 / 0x13165)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:2318 (1000_3166 / 0x13166)
    NearCall(cs1, 0x3169, not_observed_1000_2318_012318);
    State.IncCycles();
    // POP DI (1000_3169 / 0x13169)
    DI = Stack.Pop();
    State.IncCycles();
    label_1000_316A_1316A:
    // CALL 0x1000:331e (1000_316A / 0x1316A)
    NearCall(cs1, 0x316D, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    label_1000_316D_1316D:
    // RET  (1000_316D / 0x1316D)
    return NearRet();
  }
  
}
