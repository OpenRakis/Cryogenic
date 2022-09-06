namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_5198_015198(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5198_15198:
    // MOV BX,AX (1000_5198 / 0x15198)
    BX = AX;
    State.IncCycles();
    // ADD BL,0x20 (1000_519A / 0x1519A)
    // BL += 0x20;
    BL = Alu.Add8(BL, 0x20);
    State.IncCycles();
    // MOV BH,BL (1000_519D / 0x1519D)
    BH = BL;
    State.IncCycles();
    // AND BH,0x7f (1000_519F / 0x1519F)
    BH &= 0x7F;
    State.IncCycles();
    // CMP BH,0x40 (1000_51A2 / 0x151A2)
    Alu.Sub8(BH, 0x40);
    State.IncCycles();
    // JC 0x1000:51ba (1000_51A5 / 0x151A5)
    if(CarryFlag) {
      goto label_1000_51BA_151BA;
    }
    State.IncCycles();
    // MOV DX,0x20 (1000_51A7 / 0x151A7)
    DX = 0x20;
    State.IncCycles();
    // SUB AL,0x40 (1000_51AA / 0x151AA)
    // AL -= 0x40;
    AL = Alu.Sub8(AL, 0x40);
    State.IncCycles();
    // OR BL,BL (1000_51AC / 0x151AC)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JNS 0x1000:51b6 (1000_51AE / 0x151AE)
    if(!SignFlag) {
      goto label_1000_51B6_151B6;
    }
    State.IncCycles();
    // NEG DX (1000_51B0 / 0x151B0)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // SUB AL,0x80 (1000_51B2 / 0x151B2)
    AL -= 0x80;
    State.IncCycles();
    // NEG AL (1000_51B4 / 0x151B4)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    label_1000_51B6_151B6:
    // CBW  (1000_51B6 / 0x151B6)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV BX,AX (1000_51B7 / 0x151B7)
    BX = AX;
    State.IncCycles();
    // RET  (1000_51B9 / 0x151B9)
    return NearRet();
    State.IncCycles();
    label_1000_51BA_151BA:
    // OR BL,BL (1000_51BA / 0x151BA)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // MOV BX,0xffe0 (1000_51BC / 0x151BC)
    BX = 0xFFE0;
    State.IncCycles();
    // JNS 0x1000:51c7 (1000_51BF / 0x151BF)
    if(!SignFlag) {
      goto label_1000_51C7_151C7;
    }
    State.IncCycles();
    // SUB AL,0x80 (1000_51C1 / 0x151C1)
    AL -= 0x80;
    State.IncCycles();
    // NEG AL (1000_51C3 / 0x151C3)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    // NEG BX (1000_51C5 / 0x151C5)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_51C7_151C7:
    // CBW  (1000_51C7 / 0x151C7)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV DX,AX (1000_51C8 / 0x151C8)
    DX = AX;
    State.IncCycles();
    // RET  (1000_51CA / 0x151CA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_51CB_0151CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_51CB_151CB:
    // CMP byte ptr [0x11cb],0x0 (1000_51CB / 0x151CB)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    State.IncCycles();
    // JNZ 0x1000:51d9 (1000_51D0 / 0x151D0)
    if(!ZeroFlag) {
      goto label_1000_51D9_151D9;
    }
    State.IncCycles();
    // CMP byte ptr [0x11c8],0x0 (1000_51D2 / 0x151D2)
    Alu.Sub8(UInt8[DS, 0x11C8], 0x0);
    State.IncCycles();
    // JZ 0x1000:51f5 (1000_51D7 / 0x151D7)
    if(ZeroFlag) {
      goto label_1000_51F5_151F5;
    }
    State.IncCycles();
    label_1000_51D9_151D9:
    // CMP BX,-0x4d (1000_51D9 / 0x151D9)
    Alu.Sub16(BX, 0xFFB3);
    State.IncCycles();
    // JL 0x1000:51e3 (1000_51DC / 0x151DC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_51E3_151E3;
    }
    State.IncCycles();
    // CMP BX,0x4d (1000_51DE / 0x151DE)
    Alu.Sub16(BX, 0x4D);
    State.IncCycles();
    // JLE 0x1000:5205 (1000_51E1 / 0x151E1)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    State.IncCycles();
    label_1000_51E3_151E3:
    // MOV AL,[0x11c7] (1000_51E3 / 0x151E3)
    AL = UInt8[DS, 0x11C7];
    State.IncCycles();
    // MOV AH,AL (1000_51E6 / 0x151E6)
    AH = AL;
    State.IncCycles();
    // SUB AH,0x40 (1000_51E8 / 0x151E8)
    AH -= 0x40;
    State.IncCycles();
    // XOR AH,BH (1000_51EB / 0x151EB)
    // AH ^= BH;
    AH = Alu.Xor8(AH, BH);
    State.IncCycles();
    // JS 0x1000:5205 (1000_51ED / 0x151ED)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    State.IncCycles();
    // AND AL,0x80 (1000_51EF / 0x151EF)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    State.IncCycles();
    // OR AL,0x40 (1000_51F1 / 0x151F1)
    // AL |= 0x40;
    AL = Alu.Or8(AL, 0x40);
    State.IncCycles();
    // JMP 0x1000:5202 (1000_51F3 / 0x151F3)
    goto label_1000_5202_15202;
    State.IncCycles();
    label_1000_51F5_151F5:
    // MOV DI,word ptr [0x11c5] (1000_51F5 / 0x151F5)
    DI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // PUSH BX (1000_51F9 / 0x151F9)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_51FA / 0x151FA)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:5124 (1000_51FB / 0x151FB)
    NearCall(cs1, 0x51FE, spice86_generated_label_call_target_1000_5124_015124);
    State.IncCycles();
    label_1000_51FE_151FE:
    // POP DX (1000_51FE / 0x151FE)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_51FF / 0x151FF)
    BX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:5205 (1000_5200 / 0x15200)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5205 / 0x15205)
      return NearRet();
    }
    State.IncCycles();
    label_1000_5202_15202:
    // MOV [0x11c7],AL (1000_5202 / 0x15202)
    UInt8[DS, 0x11C7] = AL;
    State.IncCycles();
    label_1000_5205_15205:
    // RET  (1000_5205 / 0x15205)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5206_015206(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5206_15206:
    // CALL 0x1000:51cb (1000_5206 / 0x15206)
    NearCall(cs1, 0x5209, spice86_generated_label_call_target_1000_51CB_0151CB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5209_015209, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5209_015209(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5209_15209:
    // MOV AL,[0x11c7] (1000_5209 / 0x15209)
    AL = UInt8[DS, 0x11C7];
    State.IncCycles();
    // PUSH DX (1000_520C / 0x1520C)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BX (1000_520D / 0x1520D)
    Stack.Push(BX);
    State.IncCycles();
    // SHL BX,1 (1000_520E / 0x1520E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // JNS 0x1000:5214 (1000_5210 / 0x15210)
    if(!SignFlag) {
      goto label_1000_5214_15214;
    }
    State.IncCycles();
    // NEG BX (1000_5212 / 0x15212)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_5214_15214:
    // MOV BP,word ptr [BX + 0x4880] (1000_5214 / 0x15214)
    BP = UInt16[DS, (ushort)(BX + 0x4880)];
    State.IncCycles();
    // CALL 0x1000:5198 (1000_5218 / 0x15218)
    NearCall(cs1, 0x521B, spice86_generated_label_call_target_1000_5198_015198);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_521B_01521B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_521B_01521B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_521B_1521B:
    // MOV CX,0x20 (1000_521B / 0x1521B)
    CX = 0x20;
    State.IncCycles();
    // MOV AX,BP (1000_521E / 0x1521E)
    AX = BP;
    State.IncCycles();
    // IMUL DX (1000_5220 / 0x15220)
    Cpu.IMul16(DX);
    State.IncCycles();
    // IDIV CX (1000_5222 / 0x15222)
    Cpu.IDiv16(CX);
    State.IncCycles();
    // XCHG AX,BX (1000_5224 / 0x15224)
    ushort tmp_1000_5224 = AX;
    AX = BX;
    BX = tmp_1000_5224;
    State.IncCycles();
    // IMUL BP (1000_5225 / 0x15225)
    Cpu.IMul16(BP);
    State.IncCycles();
    // IDIV CX (1000_5227 / 0x15227)
    Cpu.IDiv16(CX);
    State.IncCycles();
    // MOV DX,BX (1000_5229 / 0x15229)
    DX = BX;
    State.IncCycles();
    // MOV BX,AX (1000_522B / 0x1522B)
    BX = AX;
    State.IncCycles();
    // OR AX,AX (1000_522D / 0x1522D)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x1000:5233 (1000_522F / 0x1522F)
    if(!SignFlag) {
      goto label_1000_5233_15233;
    }
    State.IncCycles();
    // NEG AX (1000_5231 / 0x15231)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_5233_15233:
    // ADD AX,word ptr [0x11cc] (1000_5233 / 0x15233)
    AX += UInt16[DS, 0x11CC];
    State.IncCycles();
    // CMP AH,0x1 (1000_5237 / 0x15237)
    Alu.Sub8(AH, 0x1);
    State.IncCycles();
    // JBE 0x1000:524e (1000_523A / 0x1523A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_524E_1524E;
    }
    State.IncCycles();
    // MOV CX,AX (1000_523C / 0x1523C)
    CX = AX;
    State.IncCycles();
    // MOV AX,DX (1000_523E / 0x1523E)
    AX = DX;
    State.IncCycles();
    // CWD  (1000_5240 / 0x15240)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    State.IncCycles();
    // MOV DL,AH (1000_5241 / 0x15241)
    DL = AH;
    State.IncCycles();
    // MOV AH,AL (1000_5243 / 0x15243)
    AH = AL;
    State.IncCycles();
    // XOR AL,AL (1000_5245 / 0x15245)
    AL = 0;
    State.IncCycles();
    // IDIV CX (1000_5247 / 0x15247)
    Cpu.IDiv16(CX);
    State.IncCycles();
    // MOV DX,AX (1000_5249 / 0x15249)
    DX = AX;
    State.IncCycles();
    // MOV AX,0x100 (1000_524B / 0x1524B)
    AX = 0x100;
    State.IncCycles();
    label_1000_524E_1524E:
    // MOV [0x11cc],AL (1000_524E / 0x1524E)
    UInt8[DS, 0x11CC] = AL;
    State.IncCycles();
    // MOV AL,AH (1000_5251 / 0x15251)
    AL = AH;
    State.IncCycles();
    // CBW  (1000_5253 / 0x15253)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // OR BX,BX (1000_5254 / 0x15254)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNS 0x1000:525a (1000_5256 / 0x15256)
    if(!SignFlag) {
      goto label_1000_525A_1525A;
    }
    State.IncCycles();
    // NEG AX (1000_5258 / 0x15258)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_525A_1525A:
    // POP BX (1000_525A / 0x1525A)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD BX,AX (1000_525B / 0x1525B)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // POP AX (1000_525D / 0x1525D)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD DX,AX (1000_525E / 0x1525E)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // MOV AX,BX (1000_5260 / 0x15260)
    AX = BX;
    State.IncCycles();
    // ADD AX,0x60 (1000_5262 / 0x15262)
    AX += 0x60;
    State.IncCycles();
    // CMP AX,0xc0 (1000_5265 / 0x15265)
    Alu.Sub16(AX, 0xC0);
    State.IncCycles();
    // JC 0x1000:5273 (1000_5268 / 0x15268)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5273 / 0x15273)
      return NearRet();
    }
    State.IncCycles();
    // ADD byte ptr [0x11c7],0x80 (1000_526A / 0x1526A)
    UInt8[DS, 0x11C7] += 0x80;
    State.IncCycles();
    // ADD DX,0x8000 (1000_526F / 0x1526F)
    // DX += 0x8000;
    DX = Alu.Add16(DX, 0x8000);
    State.IncCycles();
    label_1000_5273_15273:
    // RET  (1000_5273 / 0x15273)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5274_015274(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5274_15274:
    // MOV DX,word ptr [DI + 0x2] (1000_5274 / 0x15274)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x4] (1000_5277 / 0x15277)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // PUSH SI (1000_527A / 0x1527A)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AX,0xffff (1000_527B / 0x1527B)
    AX = 0xFFFF;
    State.IncCycles();
    // MOV [0xca],AX (1000_527E / 0x1527E)
    UInt16[DS, 0xCA] = AX;
    State.IncCycles();
    // MOV [0xd0],AX (1000_5281 / 0x15281)
    UInt16[DS, 0xD0] = AX;
    State.IncCycles();
    // MOV [0xd6],AX (1000_5284 / 0x15284)
    UInt16[DS, 0xD6] = AX;
    State.IncCycles();
    // MOV [0xdc],AX (1000_5287 / 0x15287)
    UInt16[DS, 0xDC] = AX;
    State.IncCycles();
    // MOV [0xe2],AX (1000_528A / 0x1528A)
    UInt16[DS, 0xE2] = AX;
    State.IncCycles();
    // MOV SI,0x100 (1000_528D / 0x1528D)
    SI = 0x100;
    State.IncCycles();
    label_1000_5290_15290:
    // CMP word ptr [SI],-0x1 (1000_5290 / 0x15290)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:52fb (1000_5293 / 0x15293)
    if(ZeroFlag) {
      goto label_1000_52FB_152FB;
    }
    State.IncCycles();
    // CMP SI,DI (1000_5295 / 0x15295)
    Alu.Sub16(SI, DI);
    State.IncCycles();
    // JZ 0x1000:52f6 (1000_5297 / 0x15297)
    if(ZeroFlag) {
      goto label_1000_52F6_152F6;
    }
    State.IncCycles();
    // MOV CX,word ptr [SI + 0x2] (1000_5299 / 0x15299)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SUB CX,DX (1000_529C / 0x1529C)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    State.IncCycles();
    // JNS 0x1000:52a2 (1000_529E / 0x1529E)
    if(!SignFlag) {
      goto label_1000_52A2_152A2;
    }
    State.IncCycles();
    // NEG CX (1000_52A0 / 0x152A0)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_1000_52A2_152A2:
    // MOV AX,word ptr [SI + 0x4] (1000_52A2 / 0x152A2)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // SUB AX,BX (1000_52A5 / 0x152A5)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JNS 0x1000:52ab (1000_52A7 / 0x152A7)
    if(!SignFlag) {
      goto label_1000_52AB_152AB;
    }
    State.IncCycles();
    // NEG AX (1000_52A9 / 0x152A9)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_52AB_152AB:
    // MOV CL,CH (1000_52AB / 0x152AB)
    CL = CH;
    State.IncCycles();
    // XOR CH,CH (1000_52AD / 0x152AD)
    CH = 0;
    State.IncCycles();
    // CMP CL,AL (1000_52AF / 0x152AF)
    Alu.Sub8(CL, AL);
    State.IncCycles();
    // JNC 0x1000:52b5 (1000_52B1 / 0x152B1)
    if(!CarryFlag) {
      goto label_1000_52B5_152B5;
    }
    State.IncCycles();
    // MOV CX,AX (1000_52B3 / 0x152B3)
    CX = AX;
    State.IncCycles();
    label_1000_52B5_152B5:
    // CMP byte ptr [SI + 0x8],0x28 (1000_52B5 / 0x152B5)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x8)], 0x28);
    State.IncCycles();
    // JC 0x1000:52c9 (1000_52B9 / 0x152B9)
    if(CarryFlag) {
      goto label_1000_52C9_152C9;
    }
    State.IncCycles();
    // MOV BP,0xe2 (1000_52BB / 0x152BB)
    BP = 0xE2;
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x80 (1000_52BE / 0x152BE)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:52dd (1000_52C2 / 0x152C2)
    if(!ZeroFlag) {
      goto label_1000_52DD_152DD;
    }
    State.IncCycles();
    // MOV BP,0xdc (1000_52C4 / 0x152C4)
    BP = 0xDC;
    State.IncCycles();
    // JMP 0x1000:52dd (1000_52C7 / 0x152C7)
    goto label_1000_52DD_152DD;
    State.IncCycles();
    label_1000_52C9_152C9:
    // MOV BP,0xd0 (1000_52C9 / 0x152C9)
    BP = 0xD0;
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x80 (1000_52CC / 0x152CC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    State.IncCycles();
    // JZ 0x1000:52dd (1000_52D0 / 0x152D0)
    if(ZeroFlag) {
      goto label_1000_52DD_152DD;
    }
    State.IncCycles();
    // MOV AL,[0x2a] (1000_52D2 / 0x152D2)
    AL = UInt8[DS, 0x2A];
    State.IncCycles();
    // CMP AL,byte ptr [SI + 0xb] (1000_52D5 / 0x152D5)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0xB)]);
    State.IncCycles();
    // JC 0x1000:52f6 (1000_52D8 / 0x152D8)
    if(CarryFlag) {
      goto label_1000_52F6_152F6;
    }
    State.IncCycles();
    // MOV BP,0xd6 (1000_52DA / 0x152DA)
    BP = 0xD6;
    State.IncCycles();
    label_1000_52DD_152DD:
    // CMP CX,word ptr [BP + 0x0] (1000_52DD / 0x152DD)
    Alu.Sub16(CX, UInt16[SS, BP]);
    State.IncCycles();
    // JNC 0x1000:52e8 (1000_52E0 / 0x152E0)
    if(!CarryFlag) {
      goto label_1000_52E8_152E8;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x0],CX (1000_52E2 / 0x152E2)
    UInt16[SS, BP] = CX;
    State.IncCycles();
    // MOV word ptr [BP + 0x2],SI (1000_52E5 / 0x152E5)
    UInt16[SS, (ushort)(BP + 0x2)] = SI;
    State.IncCycles();
    label_1000_52E8_152E8:
    // CMP CX,word ptr [0xca] (1000_52E8 / 0x152E8)
    Alu.Sub16(CX, UInt16[DS, 0xCA]);
    State.IncCycles();
    // JNC 0x1000:52f6 (1000_52EC / 0x152EC)
    if(!CarryFlag) {
      goto label_1000_52F6_152F6;
    }
    State.IncCycles();
    // MOV word ptr [0xca],CX (1000_52EE / 0x152EE)
    UInt16[DS, 0xCA] = CX;
    State.IncCycles();
    // MOV word ptr [0xcc],SI (1000_52F2 / 0x152F2)
    UInt16[DS, 0xCC] = SI;
    State.IncCycles();
    label_1000_52F6_152F6:
    // ADD SI,0x1c (1000_52F6 / 0x152F6)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    State.IncCycles();
    // JMP 0x1000:5290 (1000_52F9 / 0x152F9)
    goto label_1000_5290_15290;
    State.IncCycles();
    label_1000_52FB_152FB:
    // PUSH DI (1000_52FB / 0x152FB)
    Stack.Push(DI);
    State.IncCycles();
    // MOV BP,0xde (1000_52FC / 0x152FC)
    BP = 0xDE;
    State.IncCycles();
    // CALL 0x1000:5323 (1000_52FF / 0x152FF)
    NearCall(cs1, 0x5302, spice86_generated_label_call_target_1000_5323_015323);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5302_015302, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5302_015302(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5302_15302:
    // MOV BP,0xe4 (1000_5302 / 0x15302)
    BP = 0xE4;
    State.IncCycles();
    // CALL 0x1000:5323 (1000_5305 / 0x15305)
    NearCall(cs1, 0x5308, spice86_generated_label_call_target_1000_5323_015323);
    State.IncCycles();
    label_1000_5308_15308:
    // MOV BP,0xd8 (1000_5308 / 0x15308)
    BP = 0xD8;
    State.IncCycles();
    // CALL 0x1000:5323 (1000_530B / 0x1530B)
    NearCall(cs1, 0x530E, spice86_generated_label_call_target_1000_5323_015323);
    State.IncCycles();
    label_1000_530E_1530E:
    // ADD AX,0xda (1000_530E / 0x1530E)
    // AX += 0xDA;
    AX = Alu.Add16(AX, 0xDA);
    State.IncCycles();
    // MOV [0x11fd],AX (1000_5311 / 0x15311)
    UInt16[DS, 0x11FD] = AX;
    State.IncCycles();
    // MOV BP,0xcc (1000_5314 / 0x15314)
    BP = 0xCC;
    State.IncCycles();
    // CALL 0x1000:5323 (1000_5317 / 0x15317)
    NearCall(cs1, 0x531A, spice86_generated_label_call_target_1000_5323_015323);
    State.IncCycles();
    label_1000_531A_1531A:
    // MOV BP,0xd2 (1000_531A / 0x1531A)
    BP = 0xD2;
    State.IncCycles();
    // CALL 0x1000:5323 (1000_531D / 0x1531D)
    NearCall(cs1, 0x5320, spice86_generated_label_call_target_1000_5323_015323);
    State.IncCycles();
    label_1000_5320_15320:
    // POP DI (1000_5320 / 0x15320)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_5321 / 0x15321)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5322 / 0x15322)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5323_015323(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5323_15323:
    // PUSH BX (1000_5323 / 0x15323)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_5324 / 0x15324)
    Stack.Push(DX);
    State.IncCycles();
    // MOV DI,word ptr [BP + 0x0] (1000_5325 / 0x15325)
    DI = UInt16[SS, BP];
    State.IncCycles();
    // MOV CX,word ptr [DI + 0x4] (1000_5328 / 0x15328)
    CX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // MOV DI,word ptr [DI + 0x2] (1000_532B / 0x1532B)
    DI = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // PUSH BP (1000_532E / 0x1532E)
    Stack.Push(BP);
    State.IncCycles();
    // CALL 0x1000:5133 (1000_532F / 0x1532F)
    NearCall(cs1, 0x5332, spice86_generated_label_call_target_1000_5133_015133);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5332_015332, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5332_015332(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5332_15332:
    // POP BP (1000_5332 / 0x15332)
    BP = Stack.Pop();
    State.IncCycles();
    // ADD AL,0x10 (1000_5333 / 0x15333)
    AL += 0x10;
    State.IncCycles();
    // ROL AL,1 (1000_5335 / 0x15335)
    AL = Alu.Rol8(AL, 0x1);
    State.IncCycles();
    // ROL AL,1 (1000_5337 / 0x15337)
    AL = Alu.Rol8(AL, 0x1);
    State.IncCycles();
    // ROL AL,1 (1000_5339 / 0x15339)
    AL = Alu.Rol8(AL, 0x1);
    State.IncCycles();
    // AND AX,0x7 (1000_533B / 0x1533B)
    // AX &= 0x7;
    AX = Alu.And16(AX, 0x7);
    State.IncCycles();
    // MOV byte ptr [BP + 0x2],AL (1000_533E / 0x1533E)
    UInt8[SS, (ushort)(BP + 0x2)] = AL;
    State.IncCycles();
    // POP DX (1000_5341 / 0x15341)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_5342 / 0x15342)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5343 / 0x15343)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5344_015344(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5344_15344:
    // PUSH SI (1000_5344 / 0x15344)
    Stack.Push(SI);
    State.IncCycles();
    // MOV BP,0xffff (1000_5345 / 0x15345)
    BP = 0xFFFF;
    State.IncCycles();
    // MOV SI,0x100 (1000_5348 / 0x15348)
    SI = 0x100;
    State.IncCycles();
    label_1000_534B_1534B:
    // CMP word ptr [SI],-0x1 (1000_534B / 0x1534B)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:537f (1000_534E / 0x1534E)
    if(ZeroFlag) {
      goto label_1000_537F_1537F;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0xa],0x80 (1000_5350 / 0x15350)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xA)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:537a (1000_5354 / 0x15354)
    if(!ZeroFlag) {
      goto label_1000_537A_1537A;
    }
    State.IncCycles();
    // MOV CX,word ptr [SI + 0x2] (1000_5356 / 0x15356)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SUB CX,DX (1000_5359 / 0x15359)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    State.IncCycles();
    // JNS 0x1000:535f (1000_535B / 0x1535B)
    if(!SignFlag) {
      goto label_1000_535F_1535F;
    }
    State.IncCycles();
    // NEG CX (1000_535D / 0x1535D)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_1000_535F_1535F:
    // MOV AX,word ptr [SI + 0x4] (1000_535F / 0x1535F)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // SUB AX,BX (1000_5362 / 0x15362)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // JNS 0x1000:5368 (1000_5364 / 0x15364)
    if(!SignFlag) {
      goto label_1000_5368_15368;
    }
    State.IncCycles();
    // NEG AX (1000_5366 / 0x15366)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_5368_15368:
    // MOV CL,CH (1000_5368 / 0x15368)
    CL = CH;
    State.IncCycles();
    // XOR CH,CH (1000_536A / 0x1536A)
    CH = 0;
    State.IncCycles();
    // CMP CL,AL (1000_536C / 0x1536C)
    Alu.Sub8(CL, AL);
    State.IncCycles();
    // JNC 0x1000:5372 (1000_536E / 0x1536E)
    if(!CarryFlag) {
      goto label_1000_5372_15372;
    }
    State.IncCycles();
    // MOV CX,AX (1000_5370 / 0x15370)
    CX = AX;
    State.IncCycles();
    label_1000_5372_15372:
    // CMP CX,BP (1000_5372 / 0x15372)
    Alu.Sub16(CX, BP);
    State.IncCycles();
    // JNC 0x1000:537a (1000_5374 / 0x15374)
    if(!CarryFlag) {
      goto label_1000_537A_1537A;
    }
    State.IncCycles();
    // MOV BP,CX (1000_5376 / 0x15376)
    BP = CX;
    State.IncCycles();
    // MOV DI,SI (1000_5378 / 0x15378)
    DI = SI;
    State.IncCycles();
    label_1000_537A_1537A:
    // ADD SI,0x1c (1000_537A / 0x1537A)
    // SI += 0x1C;
    SI = Alu.Add16(SI, 0x1C);
    State.IncCycles();
    // JMP 0x1000:534b (1000_537D / 0x1537D)
    goto label_1000_534B_1534B;
    State.IncCycles();
    label_1000_537F_1537F:
    // POP SI (1000_537F / 0x1537F)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5380 / 0x15380)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5406_015406(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5406_15406:
    // MOV DX,word ptr [0x11c1] (1000_5406 / 0x15406)
    DX = UInt16[DS, 0x11C1];
    State.IncCycles();
    // MOV BX,word ptr [0x11c3] (1000_540A / 0x1540A)
    BX = UInt16[DS, 0x11C3];
    State.IncCycles();
    // MOV word ptr [0x4710],DX (1000_540E / 0x1540E)
    UInt16[DS, 0x4710] = DX;
    State.IncCycles();
    // MOV word ptr [0x4712],BX (1000_5412 / 0x15412)
    UInt16[DS, 0x4712] = BX;
    State.IncCycles();
    // CALL 0x1000:5beb (1000_5416 / 0x15416)
    NearCall(cs1, 0x5419, spice86_generated_label_call_target_1000_5BEB_015BEB);
    State.IncCycles();
    // CALL 0x1000:5f79 (1000_5419 / 0x15419)
    NearCall(cs1, 0x541C, spice86_generated_label_call_target_1000_5F79_015F79);
    State.IncCycles();
    // CALL 0x1000:79de (1000_541C / 0x1541C)
    NearCall(cs1, 0x541F, spice86_generated_label_call_target_1000_79DE_0179DE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_541F_01541F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_541F_01541F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_541F_1541F:
    // PUSH word ptr [0x197c] (1000_541F / 0x1541F)
    Stack.Push(UInt16[DS, 0x197C]);
    State.IncCycles();
    // PUSH word ptr [0x197e] (1000_5423 / 0x15423)
    Stack.Push(UInt16[DS, 0x197E]);
    State.IncCycles();
    // POP word ptr [0x1982] (1000_5427 / 0x15427)
    UInt16[DS, 0x1982] = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0x1980] (1000_542B / 0x1542B)
    UInt16[DS, 0x1980] = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_542F_01542F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_542F_01542F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_542F_1542F:
    // MOV word ptr [0x46fc],0x0 (1000_542F / 0x1542F)
    UInt16[DS, 0x46FC] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x479e],0x0 (1000_5435 / 0x15435)
    UInt16[DS, 0x479E] = 0x0;
    State.IncCycles();
    // CALL 0x1000:557b (1000_543B / 0x1543B)
    NearCall(cs1, 0x543E, not_observed_1000_557B_01557B);
    State.IncCycles();
    // MOV DI,0x46e3 (1000_543E / 0x1543E)
    DI = 0x46E3;
    State.IncCycles();
    // ADD DX,0x5 (1000_5441 / 0x15441)
    DX += 0x5;
    State.IncCycles();
    // ADD BX,0x7 (1000_5444 / 0x15444)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    State.IncCycles();
    // MOV word ptr [DI],DX (1000_5447 / 0x15447)
    UInt16[DS, DI] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],BX (1000_5449 / 0x15449)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    State.IncCycles();
    // ADD DX,0xa0 (1000_544C / 0x1544C)
    // DX += 0xA0;
    DX = Alu.Add16(DX, 0xA0);
    State.IncCycles();
    // MOV word ptr [DI + 0x4],DX (1000_5450 / 0x15450)
    UInt16[DS, (ushort)(DI + 0x4)] = DX;
    State.IncCycles();
    // ADD BX,0x59 (1000_5453 / 0x15453)
    // BX += 0x59;
    BX = Alu.Add16(BX, 0x59);
    State.IncCycles();
    // MOV word ptr [DI + 0x6],BX (1000_5456 / 0x15456)
    UInt16[DS, (ushort)(DI + 0x6)] = BX;
    State.IncCycles();
    // MOV SI,0x4710 (1000_5459 / 0x15459)
    SI = 0x4710;
    State.IncCycles();
    // ADD DX,0x5 (1000_545C / 0x1545C)
    // DX += 0x5;
    DX = Alu.Add16(DX, 0x5);
    State.IncCycles();
    // MOV word ptr [SI + 0x4],DX (1000_545F / 0x1545F)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    State.IncCycles();
    // ADD BX,0xc (1000_5462 / 0x15462)
    // BX += 0xC;
    BX = Alu.Add16(BX, 0xC);
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_5465 / 0x15465)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    // CALL 0x1000:c13b (1000_5468 / 0x15468)
    NearCall(cs1, 0x546B, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    // CALL 0x1000:557b (1000_546B / 0x1546B)
    NearCall(cs1, 0x546E, not_observed_1000_557B_01557B);
    State.IncCycles();
    // MOV AX,0x8d (1000_546E / 0x1546E)
    AX = 0x8D;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_5471 / 0x15471)
    NearCall(cs1, 0x5474, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    // CALL 0x1000:c07c (1000_5474 / 0x15474)
    NearCall(cs1, 0x5477, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    // CALL 0x1000:5b8d (1000_5477 / 0x15477)
    NearCall(cs1, 0x547A, spice86_generated_label_call_target_1000_5B8D_015B8D);
    State.IncCycles();
    // PUSH word ptr [0xdd00] (1000_547A / 0x1547A)
    Stack.Push(UInt16[DS, 0xDD00]);
    State.IncCycles();
    // MOV AX,0x3a (1000_547E / 0x1547E)
    AX = 0x3A;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_5481 / 0x15481)
    NearCall(cs1, 0x5484, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // CALL 0x1000:5584 (1000_5484 / 0x15484)
    NearCall(cs1, 0x5487, not_observed_1000_5584_015584);
    State.IncCycles();
    // PUSH word ptr [0xdbb2] (1000_5487 / 0x15487)
    Stack.Push(UInt16[DS, 0xDBB2]);
    State.IncCycles();
    // POP word ptr [0xdd00] (1000_548B / 0x1548B)
    UInt16[DS, 0xDD00] = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x46eb],0x40 (1000_548F / 0x1548F)
    UInt8[DS, 0x46EB] = 0x40;
    State.IncCycles();
    // CALL 0x1000:b69a (1000_5494 / 0x15494)
    NearCall(cs1, 0x5497, not_observed_1000_B69A_01B69A);
    State.IncCycles();
    // CALL 0x1000:b6c3 (1000_5497 / 0x15497)
    NearCall(cs1, 0x549A, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    State.IncCycles();
    // POP word ptr [0xdd00] (1000_549A / 0x1549A)
    UInt16[DS, 0xDD00] = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:58e4 (1000_549E / 0x1549E)
    NearCall(cs1, 0x54A1, not_observed_1000_58E4_0158E4);
    State.IncCycles();
    // CALL 0x1000:c137 (1000_54A1 / 0x154A1)
    NearCall(cs1, 0x54A4, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    // CALL 0x1000:5dce (1000_54A4 / 0x154A4)
    NearCall(cs1, 0x54A7, spice86_generated_label_call_target_1000_5DCE_015DCE);
    State.IncCycles();
    // CALL 0x1000:5605 (1000_54A7 / 0x154A7)
    NearCall(cs1, 0x54AA, not_observed_1000_5605_015605);
    State.IncCycles();
    // CALL 0x1000:563e (1000_54AA / 0x154AA)
    NearCall(cs1, 0x54AD, not_observed_1000_563E_01563E);
    State.IncCycles();
    // MOV word ptr [0x2772],0x5555 (1000_54AD / 0x154AD)
    UInt16[DS, 0x2772] = 0x5555;
    State.IncCycles();
    // MOV DX,word ptr [0x1980] (1000_54B3 / 0x154B3)
    DX = UInt16[DS, 0x1980];
    State.IncCycles();
    // MOV BX,word ptr [0x1982] (1000_54B7 / 0x154B7)
    BX = UInt16[DS, 0x1982];
    State.IncCycles();
    // CALL 0x1000:b647 (1000_54BB / 0x154BB)
    NearCall(cs1, 0x54BE, spice86_generated_label_call_target_1000_B647_01B647);
    State.IncCycles();
    // MOV CX,BX (1000_54BE / 0x154BE)
    CX = BX;
    State.IncCycles();
    // MOV DI,DX (1000_54C0 / 0x154C0)
    DI = DX;
    State.IncCycles();
    // SUB BX,0x14 (1000_54C2 / 0x154C2)
    BX -= 0x14;
    State.IncCycles();
    // ADD CX,0x13 (1000_54C5 / 0x154C5)
    CX += 0x13;
    State.IncCycles();
    // SUB DX,0x28 (1000_54C8 / 0x154C8)
    DX -= 0x28;
    State.IncCycles();
    // ADD DI,0x27 (1000_54CB / 0x154CB)
    // DI += 0x27;
    DI = Alu.Add16(DI, 0x27);
    State.IncCycles();
    // MOV AX,[0x4710] (1000_54CE / 0x154CE)
    AX = UInt16[DS, 0x4710];
    State.IncCycles();
    // ADD AX,0x5 (1000_54D1 / 0x154D1)
    AX += 0x5;
    State.IncCycles();
    // CMP DX,AX (1000_54D4 / 0x154D4)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JGE 0x1000:54da (1000_54D6 / 0x154D6)
    if(SignFlag == OverflowFlag) {
      goto label_1000_54DA_154DA;
    }
    State.IncCycles();
    // MOV DX,AX (1000_54D8 / 0x154D8)
    DX = AX;
    State.IncCycles();
    label_1000_54DA_154DA:
    // CMP DI,AX (1000_54DA / 0x154DA)
    Alu.Sub16(DI, AX);
    State.IncCycles();
    // JGE 0x1000:54e0 (1000_54DC / 0x154DC)
    if(SignFlag == OverflowFlag) {
      goto label_1000_54E0_154E0;
    }
    State.IncCycles();
    // MOV DI,AX (1000_54DE / 0x154DE)
    DI = AX;
    State.IncCycles();
    label_1000_54E0_154E0:
    // ADD AX,0x9f (1000_54E0 / 0x154E0)
    AX += 0x9F;
    State.IncCycles();
    // CMP DX,AX (1000_54E3 / 0x154E3)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JBE 0x1000:54e9 (1000_54E5 / 0x154E5)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_54E9_154E9;
    }
    State.IncCycles();
    // MOV DX,AX (1000_54E7 / 0x154E7)
    DX = AX;
    State.IncCycles();
    label_1000_54E9_154E9:
    // CMP DI,AX (1000_54E9 / 0x154E9)
    Alu.Sub16(DI, AX);
    State.IncCycles();
    // JBE 0x1000:54ef (1000_54EB / 0x154EB)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_54EF_154EF;
    }
    State.IncCycles();
    // MOV DI,AX (1000_54ED / 0x154ED)
    DI = AX;
    State.IncCycles();
    label_1000_54EF_154EF:
    // MOV AX,[0x4712] (1000_54EF / 0x154EF)
    AX = UInt16[DS, 0x4712];
    State.IncCycles();
    // ADD AX,0x7 (1000_54F2 / 0x154F2)
    AX += 0x7;
    State.IncCycles();
    // CMP BX,AX (1000_54F5 / 0x154F5)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JGE 0x1000:54fb (1000_54F7 / 0x154F7)
    if(SignFlag == OverflowFlag) {
      goto label_1000_54FB_154FB;
    }
    State.IncCycles();
    // MOV BX,AX (1000_54F9 / 0x154F9)
    BX = AX;
    State.IncCycles();
    label_1000_54FB_154FB:
    // CMP CX,AX (1000_54FB / 0x154FB)
    Alu.Sub16(CX, AX);
    State.IncCycles();
    // JGE 0x1000:5501 (1000_54FD / 0x154FD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5501_15501;
    }
    State.IncCycles();
    // MOV CX,AX (1000_54FF / 0x154FF)
    CX = AX;
    State.IncCycles();
    label_1000_5501_15501:
    // ADD AX,0x58 (1000_5501 / 0x15501)
    AX += 0x58;
    State.IncCycles();
    // CMP BX,AX (1000_5504 / 0x15504)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JBE 0x1000:550a (1000_5506 / 0x15506)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_550A_1550A;
    }
    State.IncCycles();
    // MOV BX,AX (1000_5508 / 0x15508)
    BX = AX;
    State.IncCycles();
    label_1000_550A_1550A:
    // CMP CX,AX (1000_550A / 0x1550A)
    Alu.Sub16(CX, AX);
    State.IncCycles();
    // JBE 0x1000:5510 (1000_550C / 0x1550C)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_5510_15510;
    }
    State.IncCycles();
    // MOV CX,AX (1000_550E / 0x1550E)
    CX = AX;
    State.IncCycles();
    label_1000_5510_15510:
    // CMP BX,CX (1000_5510 / 0x15510)
    Alu.Sub16(BX, CX);
    State.IncCycles();
    // JZ 0x1000:551d (1000_5512 / 0x15512)
    if(ZeroFlag) {
      goto label_1000_551D_1551D;
    }
    State.IncCycles();
    // CMP DX,DI (1000_5514 / 0x15514)
    Alu.Sub16(DX, DI);
    State.IncCycles();
    // JZ 0x1000:551d (1000_5516 / 0x15516)
    if(ZeroFlag) {
      goto label_1000_551D_1551D;
    }
    State.IncCycles();
    // MOV AL,0xfb (1000_5518 / 0x15518)
    AL = 0xFB;
    State.IncCycles();
    // CALL 0x1000:c560 (1000_551A / 0x1551A)
    NearCall(cs1, 0x551D, spice86_generated_label_call_target_1000_C560_01C560);
    State.IncCycles();
    label_1000_551D_1551D:
    // MOV word ptr [0x2772],0xffff (1000_551D / 0x1551D)
    UInt16[DS, 0x2772] = 0xFFFF;
    State.IncCycles();
    // MOV SI,0x4710 (1000_5523 / 0x15523)
    SI = 0x4710;
    State.IncCycles();
    // MOV DI,0xdbe0 (1000_5526 / 0x15526)
    DI = 0xDBE0;
    State.IncCycles();
    // CMP word ptr [DI],0x0 (1000_5529 / 0x15529)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    State.IncCycles();
    // JZ 0x1000:5535 (1000_552C / 0x1552C)
    if(ZeroFlag) {
      goto label_1000_5535_15535;
    }
    State.IncCycles();
    // CMP word ptr [DI],SI (1000_552E / 0x1552E)
    Alu.Sub16(UInt16[DS, DI], SI);
    State.IncCycles();
    // JZ 0x1000:5535 (1000_5530 / 0x15530)
    if(ZeroFlag) {
      goto label_1000_5535_15535;
    }
    State.IncCycles();
    // MOV DI,0xdbe2 (1000_5532 / 0x15532)
    DI = 0xDBE2;
    State.IncCycles();
    label_1000_5535_15535:
    // MOV word ptr [DI],SI (1000_5535 / 0x15535)
    UInt16[DS, DI] = SI;
    State.IncCycles();
    // CMP DI,0xdbe2 (1000_5537 / 0x15537)
    Alu.Sub16(DI, 0xDBE2);
    State.IncCycles();
    // PUSHF  (1000_553B / 0x1553B)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // XOR DI,DI (1000_553C / 0x1553C)
    DI = 0;
    State.IncCycles();
    // XCHG word ptr [0x4720],DI (1000_553E / 0x1553E)
    ushort tmp_1000_553E = UInt16[DS, 0x4720];
    UInt16[DS, 0x4720] = DI;
    DI = tmp_1000_553E;
    State.IncCycles();
    // OR DI,DI (1000_5542 / 0x15542)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:554d (1000_5544 / 0x15544)
    if(ZeroFlag) {
      goto label_1000_554D_1554D;
    }
    State.IncCycles();
    // XCHG DI,SI (1000_5546 / 0x15546)
    ushort tmp_1000_5546 = DI;
    DI = SI;
    SI = tmp_1000_5546;
    State.IncCycles();
    // MOV AL,0x6 (1000_5548 / 0x15548)
    AL = 0x6;
    State.IncCycles();
    // CALL 0x1000:c0e8 (1000_554A / 0x1554A)
    NearCall(cs1, 0x554D, spice86_generated_label_call_target_1000_C0E8_01C0E8);
    State.IncCycles();
    label_1000_554D_1554D:
    // POPF  (1000_554D / 0x1554D)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNZ 0x1000:5558 (1000_554E / 0x1554E)
    if(!ZeroFlag) {
      goto label_1000_5558_15558;
    }
    State.IncCycles();
    // CALL 0x1000:62f2 (1000_5550 / 0x15550)
    NearCall(cs1, 0x5553, not_observed_1000_62F2_0162F2);
    State.IncCycles();
    // CALL 0x1000:813e (1000_5553 / 0x15553)
    NearCall(cs1, 0x5556, not_observed_1000_813E_01813E);
    State.IncCycles();
    // JMP 0x1000:555b (1000_5556 / 0x15556)
    goto label_1000_555B_1555B;
    State.IncCycles();
    label_1000_5558_15558:
    // CALL 0x1000:6314 (1000_5558 / 0x15558)
    NearCall(cs1, 0x555B, spice86_generated_label_call_target_1000_6314_016314);
    State.IncCycles();
    label_1000_555B_1555B:
    // MOV SI,0x4710 (1000_555B / 0x1555B)
    SI = 0x4710;
    State.IncCycles();
    // CALL 0x1000:c4f0 (1000_555E / 0x1555E)
    NearCall(cs1, 0x5561, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    State.IncCycles();
    // CALL 0x1000:b69a (1000_5561 / 0x15561)
    NearCall(cs1, 0x5564, not_observed_1000_B69A_01B69A);
    State.IncCycles();
    // MOV byte ptr [0x46eb],0xc0 (1000_5564 / 0x15564)
    UInt8[DS, 0x46EB] = 0xC0;
    State.IncCycles();
    // MOV SI,0x1482 (1000_5569 / 0x15569)
    SI = 0x1482;
    State.IncCycles();
    // MOV DI,0x46e3 (1000_556C / 0x1556C)
    DI = 0x46E3;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_556F / 0x1556F)
    NearCall(cs1, 0x5572, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    // CALL 0x1000:5b8d (1000_5572 / 0x15572)
    NearCall(cs1, 0x5575, spice86_generated_label_call_target_1000_5B8D_015B8D);
    State.IncCycles();
    label_1000_5575_15575:
    // MOV SI,0x4710 (1000_5575 / 0x15575)
    SI = 0x4710;
    State.IncCycles();
    // JMP 0x1000:daaa (1000_5578 / 0x15578)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAAA_01DAAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_557B_01557B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_557B_1557B:
    // MOV DX,word ptr [0x4710] (1000_557B / 0x1557B)
    DX = UInt16[DS, 0x4710];
    State.IncCycles();
    // MOV BX,word ptr [0x4712] (1000_557F / 0x1557F)
    BX = UInt16[DS, 0x4712];
    State.IncCycles();
    // RET  (1000_5583 / 0x15583)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5584_015584(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5584_15584:
    // XOR AX,AX (1000_5584 / 0x15584)
    AX = 0;
    State.IncCycles();
    // XCHG word ptr [0x115a],AX (1000_5586 / 0x15586)
    ushort tmp_1000_5586 = UInt16[DS, 0x115A];
    UInt16[DS, 0x115A] = AX;
    AX = tmp_1000_5586;
    State.IncCycles();
    // OR AX,AX (1000_558A / 0x1558A)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:55bf (1000_558C / 0x1558C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_55BF / 0x155BF)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_558E / 0x1558E)
    NearCall(cs1, 0x5591, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // PUSH DS (1000_5591 / 0x15591)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_5592 / 0x15592)
    Stack.Push(ES);
    State.IncCycles();
    // MOV CL,0xc (1000_5593 / 0x15593)
    CL = 0xC;
    State.IncCycles();
    label_1000_5595_15595:
    // SHR AX,1 (1000_5595 / 0x15595)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // JNC 0x1000:55b8 (1000_5597 / 0x15597)
    if(!CarryFlag) {
      goto label_1000_55B8_155B8;
    }
    State.IncCycles();
    // PUSH AX (1000_5599 / 0x15599)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (1000_559A / 0x1559A)
    Stack.Push(CX);
    State.IncCycles();
    // MOV BL,0xd (1000_559B / 0x1559B)
    BL = 0xD;
    State.IncCycles();
    // SUB BL,CL (1000_559D / 0x1559D)
    // BL -= CL;
    BL = Alu.Sub8(BL, CL);
    State.IncCycles();
    // MOV DI,0x100 (1000_559F / 0x1559F)
    DI = 0x100;
    State.IncCycles();
    label_1000_55A2_155A2:
    // CMP byte ptr [DI],BL (1000_55A2 / 0x155A2)
    Alu.Sub8(UInt8[DS, DI], BL);
    State.IncCycles();
    // JNZ 0x1000:55ab (1000_55A4 / 0x155A4)
    if(!ZeroFlag) {
      goto label_1000_55AB_155AB;
    }
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_55A6 / 0x155A6)
    NearCall(cs1, 0x55A9, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    // JNC 0x1000:55b6 (1000_55A9 / 0x155A9)
    if(!CarryFlag) {
      goto label_1000_55B6_155B6;
    }
    State.IncCycles();
    label_1000_55AB_155AB:
    // ADD DI,0x1c (1000_55AB / 0x155AB)
    DI += 0x1C;
    State.IncCycles();
    // CMP byte ptr [DI],0xff (1000_55AE / 0x155AE)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:55a2 (1000_55B1 / 0x155B1)
    if(!ZeroFlag) {
      goto label_1000_55A2_155A2;
    }
    State.IncCycles();
    // CALL 0x1000:55c0 (1000_55B3 / 0x155B3)
    NearCall(cs1, 0x55B6, not_observed_1000_55C0_0155C0);
    State.IncCycles();
    label_1000_55B6_155B6:
    // POP CX (1000_55B6 / 0x155B6)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_55B7 / 0x155B7)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_55B8_155B8:
    // LOOP 0x1000:5595 (1000_55B8 / 0x155B8)
    if(--CX != 0) {
      goto label_1000_5595_15595;
    }
    State.IncCycles();
    // POP ES (1000_55BA / 0x155BA)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (1000_55BB / 0x155BB)
    DS = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_55BC / 0x155BC)
    NearCall(cs1, 0x55BF, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_55BF_155BF:
    // RET  (1000_55BF / 0x155BF)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_55C0_0155C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_55C0_155C0:
    // MOV SI,0x100 (1000_55C0 / 0x155C0)
    SI = 0x100;
    State.IncCycles();
    label_1000_55C3_155C3:
    // CMP byte ptr [SI],BL (1000_55C3 / 0x155C3)
    Alu.Sub8(UInt8[DS, SI], BL);
    State.IncCycles();
    // JNZ 0x1000:55cd (1000_55C5 / 0x155C5)
    if(!ZeroFlag) {
      goto label_1000_55CD_155CD;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x10] (1000_55C7 / 0x155C7)
    AL = UInt8[DS, (ushort)(SI + 0x10)];
    State.IncCycles();
    // CALL 0x1000:55dd (1000_55CA / 0x155CA)
    NearCall(cs1, 0x55CD, map_func_ida_1000_55DD_155DD);
    State.IncCycles();
    label_1000_55CD_155CD:
    // ADD SI,0x1c (1000_55CD / 0x155CD)
    SI += 0x1C;
    State.IncCycles();
    // CMP byte ptr [SI],0xff (1000_55D0 / 0x155D0)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:55c3 (1000_55D3 / 0x155D3)
    if(!ZeroFlag) {
      goto label_1000_55C3_155C3;
    }
    State.IncCycles();
    // MOV AL,0x42 (1000_55D5 / 0x155D5)
    AL = 0x42;
    State.IncCycles();
    // CMP BL,0x7 (1000_55D7 / 0x155D7)
    Alu.Sub8(BL, 0x7);
    State.IncCycles();
    // JZ 0x1000:55dd (1000_55DA / 0x155DA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(map_func_ida_1000_55DD_155DD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_55DC / 0x155DC)
    return NearRet();
  }
  
  public virtual Action map_func_ida_1000_55DD_155DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_55DD_155DD:
    // PUSH DS (1000_55DD / 0x155DD)
    Stack.Push(DS);
    State.IncCycles();
    // OR AL,AL (1000_55DE / 0x155DE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:5603 (1000_55E0 / 0x155E0)
    if(ZeroFlag) {
      goto label_1000_5603_15603;
    }
    State.IncCycles();
    // LES DI,[0xdbb0] (1000_55E2 / 0x155E2)
    ES = UInt16[DS, 0xDBB2];
    DI = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // MOV DS,word ptr [0xdd00] (1000_55E6 / 0x155E6)
    DS = UInt16[DS, 0xDD00];
    State.IncCycles();
    // MOV CX,0xc5f9 (1000_55EA / 0x155EA)
    CX = 0xC5F9;
    State.IncCycles();
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
    State.IncCycles();
    // JNZ 0x1000:5603 (1000_55EF / 0x155EF)
    if(!ZeroFlag) {
      goto label_1000_5603_15603;
    }
    State.IncCycles();
    // MOV AH,byte ptr [DI + -0x1] (1000_55F1 / 0x155F1)
    AH = UInt8[DS, (ushort)(DI - 0x1)];
    State.IncCycles();
    // AND AH,0x30 (1000_55F4 / 0x155F4)
    AH &= 0x30;
    State.IncCycles();
    // CMP AH,0x30 (1000_55F7 / 0x155F7)
    Alu.Sub8(AH, 0x30);
    State.IncCycles();
    // JNZ 0x1000:5600 (1000_55FA / 0x155FA)
    if(!ZeroFlag) {
      goto label_1000_5600_15600;
    }
    State.IncCycles();
    // AND byte ptr [DI + -0x1],0xef (1000_55FC / 0x155FC)
    UInt8[DS, (ushort)(DI - 0x1)] &= 0xEF;
    State.IncCycles();
    label_1000_5600_15600:
    // INC CX (1000_5600 / 0x15600)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // LOOP 0x1000:55ed (1000_5601 / 0x15601)
    if(--CX != 0) {
      goto label_1000_55ED_155ED;
    }
    State.IncCycles();
    label_1000_5603_15603:
    // POP DS (1000_5603 / 0x15603)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5604 / 0x15604)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5605_015605(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5605_15605:
    // SUB SP,0x8 (1000_5605 / 0x15605)
    // SP -= 0x8;
    SP = Alu.Sub16(SP, 0x8);
    State.IncCycles();
    // MOV SI,0x4710 (1000_5608 / 0x15608)
    SI = 0x4710;
    State.IncCycles();
    // MOV DI,SP (1000_560B / 0x1560B)
    DI = SP;
    State.IncCycles();
    // PUSH DS (1000_560D / 0x1560D)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_560E / 0x1560E)
    ES = Stack.Pop();
    State.IncCycles();
    // LODSW SI (1000_560F / 0x1560F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD AX,0x6 (1000_5610 / 0x15610)
    // AX += 0x6;
    AX = Alu.Add16(AX, 0x6);
    State.IncCycles();
    // STOSW ES:DI (1000_5613 / 0x15613)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_5614 / 0x15614)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // ADD AX,0x62 (1000_5615 / 0x15615)
    // AX += 0x62;
    AX = Alu.Add16(AX, 0x62);
    State.IncCycles();
    // STOSW ES:DI (1000_5618 / 0x15618)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_5619 / 0x15619)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB AX,0x6 (1000_561A / 0x1561A)
    // AX -= 0x6;
    AX = Alu.Sub16(AX, 0x6);
    State.IncCycles();
    // STOSW ES:DI (1000_561D / 0x1561D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LODSW SI (1000_561E / 0x1561E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB AX,0x2 (1000_561F / 0x1561F)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // STOSW ES:DI (1000_5622 / 0x15622)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LEA SI,[DI + -0x8] (1000_5623 / 0x15623)
    SI = (ushort)(DI - 0x8);
    State.IncCycles();
    // MOV AL,0xf5 (1000_5626 / 0x15626)
    AL = 0xF5;
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_5628 / 0x15628)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x38dd] (1000_562C / 0x1562C)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_562C = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_562C) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_562C));
        break;
    }
    State.IncCycles();
    // MOV byte ptr [0x4724],0xff (1000_5630 / 0x15630)
    UInt8[DS, 0x4724] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:d075 (1000_5635 / 0x15635)
    NearCall(cs1, 0x5638, spice86_generated_label_call_target_1000_D075_01D075);
    State.IncCycles();
    // ADD SP,0x8 (1000_5638 / 0x15638)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    State.IncCycles();
    // JMP 0x1000:557b (1000_563B / 0x1563B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_557B_01557B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_563E_01563E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_563E_1563E:
    // ADD BX,0x62 (1000_563E / 0x1563E)
    BX += 0x62;
    State.IncCycles();
    // ADD DX,0x6 (1000_5641 / 0x15641)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    State.IncCycles();
    // MOV CX,0xf5fe (1000_5644 / 0x15644)
    CX = 0xF5FE;
    State.IncCycles();
    // MOV byte ptr [0x4725],CL (1000_5647 / 0x15647)
    UInt8[DS, 0x4725] = CL;
    State.IncCycles();
    // CMP byte ptr [0x4722],0x0 (1000_564B / 0x1564B)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    State.IncCycles();
    // JNZ 0x1000:568c (1000_5650 / 0x15650)
    if(!ZeroFlag) {
      goto label_1000_568C_1568C;
    }
    State.IncCycles();
    // PUSH DX (1000_5652 / 0x15652)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,0x65 (1000_5653 / 0x15653)
    AX = 0x65;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_5656 / 0x15656)
    NearCall(cs1, 0x5659, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // POP AX (1000_5659 / 0x15659)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD AX,0x53 (1000_565A / 0x1565A)
    // AX += 0x53;
    AX = Alu.Add16(AX, 0x53);
    State.IncCycles();
    // MOV [0xd82c],AX (1000_565D / 0x1565D)
    UInt16[DS, 0xD82C] = AX;
    State.IncCycles();
    // MOV AL,0x2d (1000_5660 / 0x15660)
    AL = 0x2D;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_5662 / 0x15662)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_5662 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_5662) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5662));
        break;
    }
    State.IncCycles();
    // ADD word ptr [0xd82c],0x41 (1000_5666 / 0x15666)
    // UInt16[DS, 0xD82C] += 0x41;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], 0x41);
    State.IncCycles();
    // MOV AL,0x2b (1000_566B / 0x1566B)
    AL = 0x2B;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_566D / 0x1566D)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_566D = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_566D) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_566D));
        break;
    }
    State.IncCycles();
    // CALL 0x1000:c13b (1000_5671 / 0x15671)
    NearCall(cs1, 0x5674, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    // CALL 0x1000:557b (1000_5674 / 0x15674)
    NearCall(cs1, 0x5677, not_observed_1000_557B_01557B);
    State.IncCycles();
    // ADD DX,0x5f (1000_5677 / 0x15677)
    DX += 0x5F;
    State.IncCycles();
    // ADD BX,0x63 (1000_567A / 0x1567A)
    // BX += 0x63;
    BX = Alu.Add16(BX, 0x63);
    State.IncCycles();
    // MOV AX,0x80 (1000_567D / 0x1567D)
    AX = 0x80;
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_5680 / 0x15680)
    NearCall(cs1, 0x5683, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    State.IncCycles();
    // ADD DX,0x3c (1000_5683 / 0x15683)
    // DX += 0x3C;
    DX = Alu.Add16(DX, 0x3C);
    State.IncCycles();
    // MOV AX,0x81 (1000_5686 / 0x15686)
    AX = 0x81;
    State.IncCycles();
    // JMP 0x1000:c22f (1000_5689 / 0x15689)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_568C_1568C:
    // MOV AX,0x68 (1000_568C / 0x1568C)
    AX = 0x68;
    State.IncCycles();
    // JMP 0x1000:d194 (1000_568F / 0x1568F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5692_015692(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5692_15692:
    // PUSH DI (1000_5692 / 0x15692)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:5605 (1000_5693 / 0x15693)
    NearCall(cs1, 0x5696, not_observed_1000_5605_015605);
    State.IncCycles();
    // POP DI (1000_5696 / 0x15696)
    DI = Stack.Pop();
    State.IncCycles();
    // OR DI,DI (1000_5697 / 0x15697)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:563e (1000_5699 / 0x15699)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_563E_01563E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD BX,0x62 (1000_569B / 0x1569B)
    BX += 0x62;
    State.IncCycles();
    // ADD DX,0x6 (1000_569E / 0x1569E)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    State.IncCycles();
    // MOV CX,0xf5fe (1000_56A1 / 0x156A1)
    CX = 0xF5FE;
    State.IncCycles();
    // CALL 0x1000:629d (1000_56A4 / 0x156A4)
    NearCall(cs1, 0x56A7, spice86_generated_label_call_target_1000_629D_01629D);
    State.IncCycles();
    // CALL 0x1000:d05f (1000_56A7 / 0x156A7)
    NearCall(cs1, 0x56AA, spice86_generated_label_call_target_1000_D05F_01D05F);
    State.IncCycles();
    // MOV CX,0xf5fe (1000_56AA / 0x156AA)
    CX = 0xF5FE;
    State.IncCycles();
    // CALL 0x1000:62a6 (1000_56AD / 0x156AD)
    NearCall(cs1, 0x56B0, spice86_generated_label_call_target_1000_62A6_0162A6);
    State.IncCycles();
    // CMP DI,0x138 (1000_56B0 / 0x156B0)
    Alu.Sub16(DI, 0x138);
    State.IncCycles();
    // JC 0x1000:5719 (1000_56B4 / 0x156B4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5719 / 0x15719)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x21 (1000_56B6 / 0x156B6)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x21);
    State.IncCycles();
    // JZ 0x1000:5719 (1000_56BA / 0x156BA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5719 / 0x15719)
      return NearRet();
    }
    State.IncCycles();
    // XOR BX,BX (1000_56BC / 0x156BC)
    BX = 0;
    State.IncCycles();
    // XOR CX,CX (1000_56BE / 0x156BE)
    CX = 0;
    State.IncCycles();
    // MOV BP,0x5728 (1000_56C0 / 0x156C0)
    BP = 0x5728;
    State.IncCycles();
    // CALL 0x1000:6639 (1000_56C3 / 0x156C3)
    NearCall(cs1, 0x56C6, spice86_generated_label_call_target_1000_6639_016639);
    State.IncCycles();
    // MOV DX,word ptr [0x4710] (1000_56C6 / 0x156C6)
    DX = UInt16[DS, 0x4710];
    State.IncCycles();
    // ADD DX,0x71 (1000_56CA / 0x156CA)
    // DX += 0x71;
    DX = Alu.Add16(DX, 0x71);
    State.IncCycles();
    // MOV AX,CX (1000_56CD / 0x156CD)
    AX = CX;
    State.IncCycles();
    // OR AX,BX (1000_56CF / 0x156CF)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    State.IncCycles();
    // JZ 0x1000:571a (1000_56D1 / 0x156D1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_571A_01571A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:c13b (1000_56D3 / 0x156D3)
    NearCall(cs1, 0x56D6, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    // SUB byte ptr [0xdbe4],0x3 (1000_56D6 / 0x156D6)
    UInt8[DS, 0xDBE4] -= 0x3;
    State.IncCycles();
    // XOR AX,AX (1000_56DB / 0x156DB)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:56ed (1000_56DD / 0x156DD)
    NearCall(cs1, 0x56E0, not_observed_1000_56ED_0156ED);
    State.IncCycles();
    // MOV BL,CH (1000_56E0 / 0x156E0)
    BL = CH;
    State.IncCycles();
    // MOV AX,0x1 (1000_56E2 / 0x156E2)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:56ed (1000_56E5 / 0x156E5)
    NearCall(cs1, 0x56E8, not_observed_1000_56ED_0156ED);
    State.IncCycles();
    // MOV BL,CL (1000_56E8 / 0x156E8)
    BL = CL;
    State.IncCycles();
    // MOV AX,0x2 (1000_56EA / 0x156EA)
    AX = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_56ED_0156ED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_56ED_0156ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_56ED_156ED:
    // OR BL,BL (1000_56ED / 0x156ED)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JZ 0x1000:5719 (1000_56EF / 0x156EF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5719 / 0x15719)
      return NearRet();
    }
    State.IncCycles();
    // PUSH CX (1000_56F1 / 0x156F1)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_56F2 / 0x156F2)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH BX (1000_56F3 / 0x156F3)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,word ptr [0x4712] (1000_56F4 / 0x156F4)
    BX = UInt16[DS, 0x4712];
    State.IncCycles();
    // ADD BX,0x62 (1000_56F8 / 0x156F8)
    BX += 0x62;
    State.IncCycles();
    // ADD AX,0x82 (1000_56FB / 0x156FB)
    // AX += 0x82;
    AX = Alu.Add16(AX, 0x82);
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_56FE / 0x156FE)
    NearCall(cs1, 0x5701, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    State.IncCycles();
    // ADD DX,0x6 (1000_5701 / 0x15701)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    State.IncCycles();
    // CALL 0x1000:d04e (1000_5704 / 0x15704)
    NearCall(cs1, 0x5707, spice86_generated_label_call_target_1000_D04E_01D04E);
    State.IncCycles();
    // MOV AL,0x3a (1000_5707 / 0x15707)
    AL = 0x3A;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_5709 / 0x15709)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_5709 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_5709) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5709));
        break;
    }
    State.IncCycles();
    // POP AX (1000_570D / 0x1570D)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD AL,0x30 (1000_570E / 0x1570E)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_5710 / 0x15710)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_5710 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_5710) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5710));
        break;
    }
    State.IncCycles();
    // POP DX (1000_5714 / 0x15714)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_5715 / 0x15715)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD DX,0x12 (1000_5716 / 0x15716)
    // DX += 0x12;
    DX = Alu.Add16(DX, 0x12);
    State.IncCycles();
    label_1000_5719_15719:
    // RET  (1000_5719 / 0x15719)
    return NearRet();
  }
  
  public virtual Action split_1000_571A_01571A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_571A_1571A:
    // PUSH DX (1000_571A / 0x1571A)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:d05f (1000_571B / 0x1571B)
    NearCall(cs1, 0x571E, spice86_generated_label_call_target_1000_D05F_01D05F);
    State.IncCycles();
    // POP DX (1000_571E / 0x1571E)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV CX,0xf5fb (1000_571F / 0x1571F)
    CX = 0xF5FB;
    State.IncCycles();
    // MOV AX,0x66 (1000_5722 / 0x15722)
    AX = 0x66;
    State.IncCycles();
    // JMP 0x1000:d194 (1000_5725 / 0x15725)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D194_01D194, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5746_015746(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5746_15746:
    // MOV DI,0x4710 (1000_5746 / 0x15746)
    DI = 0x4710;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_5749 / 0x15749)
    NearCall(cs1, 0x574C, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    // JNC 0x1000:57b2 (1000_574C / 0x1574C)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_57B2_0157B2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0x4716] (1000_574E / 0x1574E)
    AX = UInt16[DS, 0x4716];
    State.IncCycles();
    // SUB AX,0xa (1000_5751 / 0x15751)
    AX -= 0xA;
    State.IncCycles();
    // CMP BX,AX (1000_5754 / 0x15754)
    Alu.Sub16(BX, AX);
    State.IncCycles();
    // JNC 0x1000:57ad (1000_5756 / 0x15756)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_57AD_0157AD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:57b2 (1000_5758 / 0x15758)
    NearCall(cs1, 0x575B, not_observed_1000_57B2_0157B2);
    State.IncCycles();
    // CMP byte ptr [0x4722],0x0 (1000_575B / 0x1575B)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    State.IncCycles();
    // JNZ 0x1000:578a (1000_5760 / 0x15760)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    State.IncCycles();
    // MOV ES,word ptr [0xdbd8] (1000_5762 / 0x15762)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // CALLF [0x3965] (1000_5766 / 0x15766)
    // Indirect call to [0x3965], generating possible targets from emulator records
    uint targetAddress_1000_5766 = (uint)(UInt16[DS, 0x3967] * 0x10 + UInt16[DS, 0x3965] - cs1 * 0x10);
    switch(targetAddress_1000_5766) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5766));
        break;
    }
    State.IncCycles();
    // SUB AL,0x50 (1000_576A / 0x1576A)
    AL -= 0x50;
    State.IncCycles();
    // CMP AL,0x10 (1000_576C / 0x1576C)
    Alu.Sub8(AL, 0x10);
    State.IncCycles();
    // JC 0x1000:5772 (1000_576E / 0x1576E)
    if(CarryFlag) {
      goto label_1000_5772_15772;
    }
    State.IncCycles();
    // MOV AL,0xff (1000_5770 / 0x15770)
    AL = 0xFF;
    State.IncCycles();
    label_1000_5772_15772:
    // MOV AH,AL (1000_5772 / 0x15772)
    AH = AL;
    State.IncCycles();
    // XCHG byte ptr [0x4724],AL (1000_5774 / 0x15774)
    byte tmp_1000_5774 = UInt8[DS, 0x4724];
    UInt8[DS, 0x4724] = AL;
    AL = tmp_1000_5774;
    State.IncCycles();
    // CMP AL,AH (1000_5778 / 0x15778)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JZ 0x1000:578a (1000_577A / 0x1577A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_577C / 0x1577C)
    NearCall(cs1, 0x577F, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:578b (1000_577F / 0x1577F)
    NearCall(cs1, 0x5782, not_observed_1000_578B_01578B);
    State.IncCycles();
    // MOV AL,AH (1000_5782 / 0x15782)
    AL = AH;
    State.IncCycles();
    // CALL 0x1000:578b (1000_5784 / 0x15784)
    NearCall(cs1, 0x5787, not_observed_1000_578B_01578B);
    State.IncCycles();
    // CALL 0x1000:dbec (1000_5787 / 0x15787)
    NearCall(cs1, 0x578A, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_578A_01578A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_578A_01578A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_578A_1578A:
    // RET  (1000_578A / 0x1578A)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_578B_01578B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_578B_1578B:
    // OR AL,AL (1000_578B / 0x1578B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JS 0x1000:578a (1000_578D / 0x1578D)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    State.IncCycles();
    // PUSH AX (1000_578F / 0x1578F)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:557b (1000_5790 / 0x15790)
    NearCall(cs1, 0x5793, not_observed_1000_557B_01557B);
    State.IncCycles();
    // ADD DX,0x5e (1000_5793 / 0x15793)
    DX += 0x5E;
    State.IncCycles();
    // ADD BX,0x62 (1000_5796 / 0x15796)
    BX += 0x62;
    State.IncCycles();
    // XOR AH,AH (1000_5799 / 0x15799)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_579B / 0x1579B)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_579D / 0x1579D)
    AX <<= 0x1;
    State.IncCycles();
    // ADD DX,AX (1000_579F / 0x1579F)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // MOV SI,0x5 (1000_57A1 / 0x157A1)
    SI = 0x5;
    State.IncCycles();
    // MOV CX,0x7 (1000_57A4 / 0x157A4)
    CX = 0x7;
    State.IncCycles();
    // CALLF [0x3961] (1000_57A7 / 0x157A7)
    // Indirect call to [0x3961], generating possible targets from emulator records
    uint targetAddress_1000_57A7 = (uint)(UInt16[DS, 0x3963] * 0x10 + UInt16[DS, 0x3961] - cs1 * 0x10);
    switch(targetAddress_1000_57A7) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_57A7));
        break;
    }
    State.IncCycles();
    // POP AX (1000_57AB / 0x157AB)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_57AC / 0x157AC)
    return NearRet();
  }
  
  public virtual Action split_1000_57AD_0157AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_57AD_157AD:
    // MOV CX,0xfef5 (1000_57AD / 0x157AD)
    CX = 0xFEF5;
    State.IncCycles();
    // JMP 0x1000:57b5 (1000_57B0 / 0x157B0)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_57B2_0157B2, 0x157B5 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_57B2_0157B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_57B2_157B2:
    // MOV CX,0xf5fe (1000_57B2 / 0x157B2)
    CX = 0xF5FE;
    State.IncCycles();
    label_1000_57B5_157B5:
    // MOV AL,CL (1000_57B5 / 0x157B5)
    AL = CL;
    State.IncCycles();
    // XCHG byte ptr [0x4725],AL (1000_57B7 / 0x157B7)
    byte tmp_1000_57B7 = UInt8[DS, 0x4725];
    UInt8[DS, 0x4725] = AL;
    AL = tmp_1000_57B7;
    State.IncCycles();
    // CMP AL,CL (1000_57BB / 0x157BB)
    Alu.Sub8(AL, CL);
    State.IncCycles();
    // JZ 0x1000:578a (1000_57BD / 0x157BD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_578A / 0x1578A)
      return NearRet();
    }
    State.IncCycles();
    // PUSH BX (1000_57BF / 0x157BF)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_57C0 / 0x157C0)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_57C1 / 0x157C1)
    NearCall(cs1, 0x57C4, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:557b (1000_57C4 / 0x157C4)
    NearCall(cs1, 0x57C7, not_observed_1000_557B_01557B);
    State.IncCycles();
    // ADD BX,0x62 (1000_57C7 / 0x157C7)
    BX += 0x62;
    State.IncCycles();
    // ADD DX,0x6 (1000_57CA / 0x157CA)
    // DX += 0x6;
    DX = Alu.Add16(DX, 0x6);
    State.IncCycles();
    // MOV AX,0x65 (1000_57CD / 0x157CD)
    AX = 0x65;
    State.IncCycles();
    // CMP byte ptr [0x4722],0x0 (1000_57D0 / 0x157D0)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    State.IncCycles();
    // JZ 0x1000:57da (1000_57D5 / 0x157D5)
    if(ZeroFlag) {
      goto label_1000_57DA_157DA;
    }
    State.IncCycles();
    // MOV AX,0x68 (1000_57D7 / 0x157D7)
    AX = 0x68;
    State.IncCycles();
    label_1000_57DA_157DA:
    // CALL 0x1000:dbb2 (1000_57DA / 0x157DA)
    NearCall(cs1, 0x57DD, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:d194 (1000_57DD / 0x157DD)
    NearCall(cs1, 0x57E0, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // POP DX (1000_57E0 / 0x157E0)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_57E1 / 0x157E1)
    BX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c07c (1000_57E2 / 0x157E2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_57E5_0157E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_57E5_157E5:
    // CALL 0x1000:e270 (1000_57E5 / 0x157E5)
    NearCall(cs1, 0x57E8, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // PUSH ES (1000_57E8 / 0x157E8)
    Stack.Push(ES);
    State.IncCycles();
    // MOV AX,0x3a (1000_57E9 / 0x157E9)
    AX = 0x3A;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_57EC / 0x157EC)
    NearCall(cs1, 0x57EF, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // PUSH DS (1000_57EF / 0x157EF)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_57F0 / 0x157F0)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,BP (1000_57F1 / 0x157F1)
    DI = BP;
    State.IncCycles();
    // MOV AL,0x70 (1000_57F3 / 0x157F3)
    AL = 0x70;
    State.IncCycles();
    // MOV CX,0x100 (1000_57F5 / 0x157F5)
    CX = 0x100;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_57F8 / 0x157F8)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // CMP byte ptr [0x4722],0x0 (1000_57FA / 0x157FA)
    Alu.Sub8(UInt8[DS, 0x4722], 0x0);
    State.IncCycles();
    // JNZ 0x1000:583f (1000_57FF / 0x157FF)
    if(!ZeroFlag) {
      goto label_1000_583F_1583F;
    }
    State.IncCycles();
    // MOV SI,0x100 (1000_5801 / 0x15801)
    SI = 0x100;
    State.IncCycles();
    // MOV DI,BP (1000_5804 / 0x15804)
    DI = BP;
    State.IncCycles();
    // XOR BX,BX (1000_5806 / 0x15806)
    BX = 0;
    State.IncCycles();
    label_1000_5808_15808:
    // MOV AL,byte ptr [SI + 0xa] (1000_5808 / 0x15808)
    AL = UInt8[DS, (ushort)(SI + 0xA)];
    State.IncCycles();
    // TEST AL,0x80 (1000_580B / 0x1580B)
    Alu.And8(AL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:5832 (1000_580D / 0x1580D)
    if(!ZeroFlag) {
      goto label_1000_5832_15832;
    }
    State.IncCycles();
    // MOV BL,byte ptr [SI + 0x10] (1000_580F / 0x1580F)
    BL = UInt8[DS, (ushort)(SI + 0x10)];
    State.IncCycles();
    // TEST AL,0x40 (1000_5812 / 0x15812)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // PUSHF  (1000_5814 / 0x15814)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV AL,0x75 (1000_5815 / 0x15815)
    AL = 0x75;
    State.IncCycles();
    // TEST byte ptr [0x2942],0x2 (1000_5817 / 0x15817)
    Alu.And8(UInt8[DS, 0x2942], 0x2);
    State.IncCycles();
    // JZ 0x1000:5820 (1000_581C / 0x1581C)
    if(ZeroFlag) {
      goto label_1000_5820_15820;
    }
    State.IncCycles();
    // MOV AL,0x78 (1000_581E / 0x1581E)
    AL = 0x78;
    State.IncCycles();
    label_1000_5820_15820:
    // POPF  (1000_5820 / 0x15820)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JZ 0x1000:5830 (1000_5821 / 0x15821)
    if(ZeroFlag) {
      goto label_1000_5830_15830;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x12] (1000_5823 / 0x15823)
    AL = UInt8[DS, (ushort)(SI + 0x12)];
    State.IncCycles();
    // SHR AL,1 (1000_5826 / 0x15826)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_5828 / 0x15828)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_582A / 0x1582A)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_582C / 0x1582C)
    AL >>= 0x1;
    State.IncCycles();
    // ADD AL,0x50 (1000_582E / 0x1582E)
    // AL += 0x50;
    AL = Alu.Add8(AL, 0x50);
    State.IncCycles();
    label_1000_5830_15830:
    // MOV byte ptr [BX + DI],AL (1000_5830 / 0x15830)
    UInt8[DS, (ushort)(BX + DI)] = AL;
    State.IncCycles();
    label_1000_5832_15832:
    // ADD SI,0x1c (1000_5832 / 0x15832)
    SI += 0x1C;
    State.IncCycles();
    // CMP byte ptr [SI],0xff (1000_5835 / 0x15835)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:5808 (1000_5838 / 0x15838)
    if(!ZeroFlag) {
      goto label_1000_5808_15808;
    }
    State.IncCycles();
    // POP ES (1000_583A / 0x1583A)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_583B / 0x1583B)
    NearCall(cs1, 0x583E, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // RET  (1000_583E / 0x1583E)
    return NearRet();
    State.IncCycles();
    label_1000_583F_1583F:
    // MOV DI,0x100 (1000_583F / 0x1583F)
    DI = 0x100;
    State.IncCycles();
    label_1000_5842_15842:
    // MOV AL,byte ptr [DI + 0xa] (1000_5842 / 0x15842)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    State.IncCycles();
    // TEST AL,0x80 (1000_5845 / 0x15845)
    Alu.And8(AL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:5861 (1000_5847 / 0x15847)
    if(!ZeroFlag) {
      goto label_1000_5861_15861;
    }
    State.IncCycles();
    // PUSH BP (1000_5849 / 0x15849)
    Stack.Push(BP);
    State.IncCycles();
    // XOR BX,BX (1000_584A / 0x1584A)
    BX = 0;
    State.IncCycles();
    // XOR CX,CX (1000_584C / 0x1584C)
    CX = 0;
    State.IncCycles();
    // MOV BP,0x5728 (1000_584E / 0x1584E)
    BP = 0x5728;
    State.IncCycles();
    // CALL 0x1000:6639 (1000_5851 / 0x15851)
    NearCall(cs1, 0x5854, spice86_generated_label_call_target_1000_6639_016639);
    State.IncCycles();
    // POP BP (1000_5854 / 0x15854)
    BP = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:586e (1000_5855 / 0x15855)
    NearCall(cs1, 0x5858, not_observed_1000_586E_01586E);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x10] (1000_5858 / 0x15858)
    AL = UInt8[DS, (ushort)(DI + 0x10)];
    State.IncCycles();
    // XOR AH,AH (1000_585B / 0x1585B)
    AH = 0;
    State.IncCycles();
    // MOV SI,AX (1000_585D / 0x1585D)
    SI = AX;
    State.IncCycles();
    // MOV byte ptr [BP + SI],BH (1000_585F / 0x1585F)
    UInt8[SS, (ushort)(BP + SI)] = BH;
    State.IncCycles();
    label_1000_5861_15861:
    // ADD DI,0x1c (1000_5861 / 0x15861)
    DI += 0x1C;
    State.IncCycles();
    // CMP byte ptr [DI],0xff (1000_5864 / 0x15864)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:5842 (1000_5867 / 0x15867)
    if(!ZeroFlag) {
      goto label_1000_5842_15842;
    }
    State.IncCycles();
    // POP ES (1000_5869 / 0x15869)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_586A / 0x1586A)
    NearCall(cs1, 0x586D, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // RET  (1000_586D / 0x1586D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_586E_01586E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_586E_1586E:
    // XOR AX,AX (1000_586E / 0x1586E)
    AX = 0;
    State.IncCycles();
    // OR BL,BL (1000_5870 / 0x15870)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JZ 0x1000:5876 (1000_5872 / 0x15872)
    if(ZeroFlag) {
      goto label_1000_5876_15876;
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_5874 / 0x15874)
    AL = 0x1;
    State.IncCycles();
    label_1000_5876_15876:
    // OR CH,CH (1000_5876 / 0x15876)
    // CH |= CH;
    CH = Alu.Or8(CH, CH);
    State.IncCycles();
    // JZ 0x1000:587c (1000_5878 / 0x15878)
    if(ZeroFlag) {
      goto label_1000_587C_1587C;
    }
    State.IncCycles();
    // ADD AL,0x2 (1000_587A / 0x1587A)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    State.IncCycles();
    label_1000_587C_1587C:
    // OR CL,CL (1000_587C / 0x1587C)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JZ 0x1000:5882 (1000_587E / 0x1587E)
    if(ZeroFlag) {
      goto label_1000_5882_15882;
    }
    State.IncCycles();
    // ADD AL,0x4 (1000_5880 / 0x15880)
    AL += 0x4;
    State.IncCycles();
    label_1000_5882_15882:
    // SHL AX,1 (1000_5882 / 0x15882)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV SI,AX (1000_5884 / 0x15884)
    SI = AX;
    State.IncCycles();
    // JMP word ptr CS:[SI + 0x588b] (1000_5886 / 0x15886)
    // Indirect jump to word ptr CS:[SI + 0x588b], generating possible targets from emulator records
    uint targetAddress_1000_5886 = (uint)(UInt16[cs1, (ushort)(SI + 0x588B)]);
    switch(targetAddress_1000_5886) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5886));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action not_observed_1000_58E4_0158E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_58E4_158E4:
    // SUB SP,0x100 (1000_58E4 / 0x158E4)
    // SP -= 0x100;
    SP = Alu.Sub16(SP, 0x100);
    State.IncCycles();
    // MOV BP,SP (1000_58E8 / 0x158E8)
    BP = SP;
    State.IncCycles();
    // CALL 0x1000:57e5 (1000_58EA / 0x158EA)
    NearCall(cs1, 0x58ED, not_observed_1000_57E5_0157E5);
    State.IncCycles();
    // MOV BH,byte ptr [0x4722] (1000_58ED / 0x158ED)
    BH = UInt8[DS, 0x4722];
    State.IncCycles();
    // CALLF [0x395d] (1000_58F1 / 0x158F1)
    // Indirect call to [0x395d], generating possible targets from emulator records
    uint targetAddress_1000_58F1 = (uint)(UInt16[DS, 0x395F] * 0x10 + UInt16[DS, 0x395D] - cs1 * 0x10);
    switch(targetAddress_1000_58F1) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_58F1));
        break;
    }
    State.IncCycles();
    // ADD SP,0x100 (1000_58F5 / 0x158F5)
    // SP += 0x100;
    SP = Alu.Add16(SP, 0x100);
    State.IncCycles();
    // RET  (1000_58F9 / 0x158F9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_58FA_0158FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_58FA_158FA:
    // TEST byte ptr [0x46eb],0x40 (1000_58FA / 0x158FA)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    State.IncCycles();
    // JZ 0x1000:5922 (1000_58FF / 0x158FF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5922 / 0x15922)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_5901 / 0x15901)
    NearCall(cs1, 0x5904, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // AND byte ptr [0x46eb],0xbf (1000_5904 / 0x15904)
    // UInt8[DS, 0x46EB] &= 0xBF;
    UInt8[DS, 0x46EB] = Alu.And8(UInt8[DS, 0x46EB], 0xBF);
    State.IncCycles();
    // MOV DI,0xdbe0 (1000_5909 / 0x15909)
    DI = 0xDBE0;
    State.IncCycles();
    // CMP word ptr [DI],0x4710 (1000_590C / 0x1590C)
    Alu.Sub16(UInt16[DS, DI], 0x4710);
    State.IncCycles();
    // JZ 0x1000:5915 (1000_5910 / 0x15910)
    if(ZeroFlag) {
      goto label_1000_5915_15915;
    }
    State.IncCycles();
    // MOV DI,0xdbe2 (1000_5912 / 0x15912)
    DI = 0xDBE2;
    State.IncCycles();
    label_1000_5915_15915:
    // XOR SI,SI (1000_5915 / 0x15915)
    SI = 0;
    State.IncCycles();
    // XCHG word ptr [DI],SI (1000_5917 / 0x15917)
    ushort tmp_1000_5917 = UInt16[DS, DI];
    UInt16[DS, DI] = SI;
    SI = tmp_1000_5917;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_5919 / 0x15919)
    NearCall(cs1, 0x591C, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    State.IncCycles();
    // CALL 0x1000:5ad9 (1000_591C / 0x1591C)
    NearCall(cs1, 0x591F, spice86_generated_label_ret_target_1000_5AD9_015AD9);
    State.IncCycles();
    // CALL 0x1000:e283 (1000_591F / 0x1591F)
    NearCall(cs1, 0x5922, spice86_generated_label_call_target_1000_E283_01E283);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5922_015922, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5922_015922(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5922_15922:
    // RET  (1000_5922 / 0x15922)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5982_015982(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5982_15982:
    // CALL 0x1000:e270 (1000_5982 / 0x15982)
    NearCall(cs1, 0x5985, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // MOV DX,word ptr [0x11c1] (1000_5985 / 0x15985)
    DX = UInt16[DS, 0x11C1];
    State.IncCycles();
    // MOV BX,word ptr [0x11c3] (1000_5989 / 0x15989)
    BX = UInt16[DS, 0x11C3];
    State.IncCycles();
    // MOV SI,0xaa (1000_598D / 0x1598D)
    SI = 0xAA;
    State.IncCycles();
    // MOV CX,0x6c (1000_5990 / 0x15990)
    CX = 0x6C;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd8] (1000_5993 / 0x15993)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // CALLF [0x3961] (1000_5997 / 0x15997)
    // Indirect call to [0x3961], generating possible targets from emulator records
    uint targetAddress_1000_5997 = (uint)(UInt16[DS, 0x3963] * 0x10 + UInt16[DS, 0x3961] - cs1 * 0x10);
    switch(targetAddress_1000_5997) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5997));
        break;
    }
    State.IncCycles();
    // CALL 0x1000:e283 (1000_599B / 0x1599B)
    NearCall(cs1, 0x599E, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_599E_1599E:
    // RET  (1000_599E / 0x1599E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_599F_01599F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_599F_1599F:
    // XOR AL,AL (1000_599F / 0x1599F)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0x4723],AL (1000_59A1 / 0x159A1)
    byte tmp_1000_59A1 = UInt8[DS, 0x4723];
    UInt8[DS, 0x4723] = AL;
    AL = tmp_1000_59A1;
    State.IncCycles();
    // OR AL,AL (1000_59A5 / 0x159A5)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:5a02 (1000_59A7 / 0x159A7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5A02 / 0x15A02)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:557b (1000_59A9 / 0x159A9)
    NearCall(cs1, 0x59AC, not_observed_1000_557B_01557B);
    State.IncCycles();
    // CMP DX,word ptr [0x11c1] (1000_59AC / 0x159AC)
    Alu.Sub16(DX, UInt16[DS, 0x11C1]);
    State.IncCycles();
    // JNZ 0x1000:59b8 (1000_59B0 / 0x159B0)
    if(!ZeroFlag) {
      goto label_1000_59B8_159B8;
    }
    State.IncCycles();
    // CMP BX,word ptr [0x11c3] (1000_59B2 / 0x159B2)
    Alu.Sub16(BX, UInt16[DS, 0x11C3]);
    State.IncCycles();
    // JZ 0x1000:5982 (1000_59B6 / 0x159B6)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_5982_015982, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_59B8_159B8:
    // MOV word ptr [0xdbe0],0x0 (1000_59B8 / 0x159B8)
    UInt16[DS, 0xDBE0] = 0x0;
    State.IncCycles();
    // JMP 0x1000:5b10 (1000_59BE / 0x159BE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B10_015B10, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_59C1_0159C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_59C1_159C1:
    // CMP byte ptr [0x4723],0x0 (1000_59C1 / 0x159C1)
    Alu.Sub8(UInt8[DS, 0x4723], 0x0);
    State.IncCycles();
    // JZ 0x1000:5a02 (1000_59C6 / 0x159C6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5A02 / 0x15A02)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,0x98 (1000_59C8 / 0x159C8)
    Alu.Sub16(BX, 0x98);
    State.IncCycles();
    // JNC 0x1000:599f (1000_59CC / 0x159CC)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_599F_01599F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:5982 (1000_59CE / 0x159CE)
    NearCall(cs1, 0x59D1, not_observed_1000_5982_015982);
    State.IncCycles();
    // MOV SI,0x11c1 (1000_59D1 / 0x159D1)
    SI = 0x11C1;
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_59D4 / 0x159D4)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // ADD AX,DI (1000_59D6 / 0x159D6)
    AX += DI;
    State.IncCycles();
    // SUB AX,0x5 (1000_59D8 / 0x159D8)
    AX -= 0x5;
    State.IncCycles();
    // CMP AX,0x8c (1000_59DB / 0x159DB)
    Alu.Sub16(AX, 0x8C);
    State.IncCycles();
    // JC 0x1000:59e7 (1000_59DE / 0x159DE)
    if(CarryFlag) {
      goto label_1000_59E7_159E7;
    }
    State.IncCycles();
    // JL 0x1000:59e5 (1000_59E0 / 0x159E0)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59E5_159E5;
    }
    State.IncCycles();
    // SUB AX,0x8c (1000_59E2 / 0x159E2)
    AX -= 0x8C;
    State.IncCycles();
    label_1000_59E5_159E5:
    // SUB DI,AX (1000_59E5 / 0x159E5)
    DI -= AX;
    State.IncCycles();
    label_1000_59E7_159E7:
    // ADD word ptr [SI],DI (1000_59E7 / 0x159E7)
    // UInt16[DS, SI] += DI;
    UInt16[DS, SI] = Alu.Add16(UInt16[DS, SI], DI);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_59E9 / 0x159E9)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // ADD AX,CX (1000_59EC / 0x159EC)
    AX += CX;
    State.IncCycles();
    // SUB AX,0x5 (1000_59EE / 0x159EE)
    AX -= 0x5;
    State.IncCycles();
    // CMP AX,0x18 (1000_59F1 / 0x159F1)
    Alu.Sub16(AX, 0x18);
    State.IncCycles();
    // JC 0x1000:59fd (1000_59F4 / 0x159F4)
    if(CarryFlag) {
      goto label_1000_59FD_159FD;
    }
    State.IncCycles();
    // JL 0x1000:59fb (1000_59F6 / 0x159F6)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59FB_159FB;
    }
    State.IncCycles();
    // SUB AX,0x18 (1000_59F8 / 0x159F8)
    AX -= 0x18;
    State.IncCycles();
    label_1000_59FB_159FB:
    // SUB CX,AX (1000_59FB / 0x159FB)
    CX -= AX;
    State.IncCycles();
    label_1000_59FD_159FD:
    // ADD word ptr [SI + 0x2],CX (1000_59FD / 0x159FD)
    // UInt16[DS, (ushort)(SI + 0x2)] += CX;
    UInt16[DS, (ushort)(SI + 0x2)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x2)], CX);
    State.IncCycles();
    // JMP 0x1000:5982 (1000_5A00 / 0x15A00)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5982_015982, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5A02_015A02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A02_15A02:
    // RET  (1000_5A02 / 0x15A02)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5A03_015A03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A03_15A03:
    // CALL 0x1000:8c8a (1000_5A03 / 0x15A03)
    NearCall(cs1, 0x5A06, spice86_generated_label_call_target_1000_8C8A_018C8A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A06_015A06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A06_015A06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A06_15A06:
    // INC byte ptr [0x46f3] (1000_5A06 / 0x15A06)
    UInt8[DS, 0x46F3] = Alu.Inc8(UInt8[DS, 0x46F3]);
    State.IncCycles();
    // CALL 0x1000:68eb (1000_5A0A / 0x15A0A)
    NearCall(cs1, 0x5A0D, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A0D_015A0D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A0D_015A0D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A0D_15A0D:
    // MOV [0x1954],AL (1000_5A0D / 0x15A0D)
    UInt8[DS, 0x1954] = AL;
    State.IncCycles();
    // NOT byte ptr [0xfb] (1000_5A10 / 0x15A10)
    UInt8[DS, 0xFB] = (byte)~UInt8[DS, 0xFB];
    State.IncCycles();
    // CALL 0x1000:5a1a (1000_5A14 / 0x15A14)
    NearCall(cs1, 0x5A17, spice86_generated_label_call_target_1000_5A1A_015A1A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A17_015A17, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A17_015A17(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A17_15A17:
    // JMP 0x1000:8685 (1000_5A17 / 0x15A17)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_8685_018685, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5A1A_015A1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A1A_15A1A:
    // MOV byte ptr [0x28e7],0x1 (1000_5A1A / 0x15A1A)
    UInt8[DS, 0x28E7] = 0x1;
    State.IncCycles();
    // CALL 0x1000:18ba (1000_5A1F / 0x15A1F)
    NearCall(cs1, 0x5A22, spice86_generated_label_call_target_1000_18BA_0118BA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A22_015A22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A22_015A22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A22_15A22:
    // CALL 0x1000:5b5d (1000_5A22 / 0x15A22)
    NearCall(cs1, 0x5A25, spice86_generated_label_call_target_1000_5B5D_015B5D);
    State.IncCycles();
    label_1000_5A25_15A25:
    // MOV BP,0x5a56 (1000_5A25 / 0x15A25)
    BP = 0x5A56;
    State.IncCycles();
    // MOV AL,0x34 (1000_5A28 / 0x15A28)
    AL = 0x34;
    State.IncCycles();
    // MOV DX,0xffff (1000_5A2A / 0x15A2A)
    DX = 0xFFFF;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_5A2D / 0x15A2D)
    NearCall(cs1, 0x5A30, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    label_1000_5A30_15A30:
    // CMP byte ptr [0x46f3],0x0 (1000_5A30 / 0x15A30)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x0);
    State.IncCycles();
    // JNZ 0x1000:5a3a (1000_5A35 / 0x15A35)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:17e6 (1000_5A3A / 0x15A3A)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:5bb0 (1000_5A37 / 0x15A37)
    NearCall(cs1, 0x5A3A, not_observed_1000_5BB0_015BB0);
    State.IncCycles();
    label_1000_5A3A_15A3A:
    // JMP 0x1000:17e6 (1000_5A3A / 0x15A3A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5A3D_015A3D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A3D_15A3D:
    // MOV byte ptr [0xfb],0xff (1000_5A3D / 0x15A3D)
    UInt8[DS, 0xFB] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:c13b (1000_5A42 / 0x15A42)
    NearCall(cs1, 0x5A45, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    label_1000_5A45_15A45:
    // CALLF [0x3935] (1000_5A45 / 0x15A45)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_5A45 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_5A45) {
      case 0x23610 : FarCall(cs1, 0x5A49, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5A45));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A49_015A49, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A49_015A49(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A49_15A49:
    // MOV BP,0x5a56 (1000_5A49 / 0x15A49)
    BP = 0x5A56;
    State.IncCycles();
    // MOV AL,0x2 (1000_5A4C / 0x15A4C)
    AL = 0x2;
    State.IncCycles();
    // XOR DX,DX (1000_5A4E / 0x15A4E)
    DX = 0;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_5A50 / 0x15A50)
    NearCall(cs1, 0x5A53, spice86_generated_label_call_target_1000_C108_01C108);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A53_015A53, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A53_015A53(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A53_15A53:
    // JMP 0x1000:ae04 (1000_5A53 / 0x15A53)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AE04_01AE04, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5A56_015A56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A56_15A56:
    // CMP byte ptr [0x46eb],0x0 (1000_5A56 / 0x15A56)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:5a9a (1000_5A5B / 0x15A5B)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5A9A_015A9A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:d2bd (1000_5A5D / 0x15A5D)
    NearCall(cs1, 0x5A60, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A60_015A60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A60_015A60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A60_15A60:
    // CALL 0x1000:4aca (1000_5A60 / 0x15A60)
    NearCall(cs1, 0x5A63, spice86_generated_label_call_target_1000_4ACA_014ACA);
    State.IncCycles();
    label_1000_5A63_15A63:
    // CALL 0x1000:b930 (1000_5A63 / 0x15A63)
    NearCall(cs1, 0x5A66, spice86_generated_label_call_target_1000_B930_01B930);
    State.IncCycles();
    label_1000_5A66_15A66:
    // MOV SI,0x6b34 (1000_5A66 / 0x15A66)
    SI = 0x6B34;
    State.IncCycles();
    // MOV BP,0xf (1000_5A69 / 0x15A69)
    BP = 0xF;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_5A6C / 0x15A6C)
    NearCall(cs1, 0x5A6F, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    label_1000_5A6F_15A6F:
    // MOV SI,0x1482 (1000_5A6F / 0x15A6F)
    SI = 0x1482;
    State.IncCycles();
    // MOV DI,0x46e3 (1000_5A72 / 0x15A72)
    DI = 0x46E3;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_5A75 / 0x15A75)
    NearCall(cs1, 0x5A78, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    label_1000_5A78_15A78:
    // CALL 0x1000:5b69 (1000_5A78 / 0x15A78)
    NearCall(cs1, 0x5A7B, spice86_generated_label_call_target_1000_5B69_015B69);
    State.IncCycles();
    label_1000_5A7B_15A7B:
    // CALL 0x1000:1797 (1000_5A7B / 0x15A7B)
    NearCall(cs1, 0x5A7E, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    label_1000_5A7E_15A7E:
    // MOV byte ptr [0x46eb],0x80 (1000_5A7E / 0x15A7E)
    UInt8[DS, 0x46EB] = 0x80;
    State.IncCycles();
    // CALL 0x1000:ad5e (1000_5A83 / 0x15A83)
    NearCall(cs1, 0x5A86, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    State.IncCycles();
    label_1000_5A86_15A86:
    // MOV word ptr [0x2786],0xc835 (1000_5A86 / 0x15A86)
    UInt16[DS, 0x2786] = 0xC835;
    State.IncCycles();
    // MOV AX,0x5a9a (1000_5A8C / 0x15A8C)
    AX = 0x5A9A;
    State.IncCycles();
    // MOV [0x46ed],AX (1000_5A8F / 0x15A8F)
    UInt16[DS, 0x46ED] = AX;
    State.IncCycles();
    // CALL AX (1000_5A92 / 0x15A92)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_5A92 = (uint)(AX);
    switch(targetAddress_1000_5A92) {
      case 0x5A9A : NearCall(cs1, 0x5A94, spice86_generated_label_call_target_1000_5A9A_015A9A); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5A92));
        break;
    }
    State.IncCycles();
    label_1000_5A94_15A94:
    // CALL 0x1000:d792 (1000_5A94 / 0x15A94)
    NearCall(cs1, 0x5A97, spice86_generated_label_call_target_1000_D792_01D792);
    State.IncCycles();
    label_1000_5A97_15A97:
    // JMP 0x1000:d712 (1000_5A97 / 0x15A97)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D712_01D712, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5A9A_015A9A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A9A_15A9A:
    // CALL 0x1000:c07c (1000_5A9A / 0x15A9A)
    NearCall(cs1, 0x5A9D, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5A9D_015A9D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5A9D_015A9D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5A9D_15A9D:
    // CALL 0x1000:5b8d (1000_5A9D / 0x15A9D)
    NearCall(cs1, 0x5AA0, spice86_generated_label_call_target_1000_5B8D_015B8D);
    State.IncCycles();
    label_1000_5AA0_15AA0:
    // MOV AL,0x80 (1000_5AA0 / 0x15AA0)
    AL = 0x80;
    State.IncCycles();
    // XCHG byte ptr [0x46eb],AL (1000_5AA2 / 0x15AA2)
    byte tmp_1000_5AA2 = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_5AA2;
    State.IncCycles();
    // PUSH AX (1000_5AA6 / 0x15AA6)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:b6c3 (1000_5AA7 / 0x15AA7)
    NearCall(cs1, 0x5AAA, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    State.IncCycles();
    label_1000_5AAA_15AAA:
    // CALL 0x1000:c13b (1000_5AAA / 0x15AAA)
    NearCall(cs1, 0x5AAD, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    label_1000_5AAD_15AAD:
    // CALL 0x1000:5dce (1000_5AAD / 0x15AAD)
    NearCall(cs1, 0x5AB0, spice86_generated_label_call_target_1000_5DCE_015DCE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AB0_015AB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AB0_015AB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5AB0_15AB0:
    // CALL 0x1000:6314 (1000_5AB0 / 0x15AB0)
    NearCall(cs1, 0x5AB3, spice86_generated_label_call_target_1000_6314_016314);
    State.IncCycles();
    label_1000_5AB3_15AB3:
    // CALL 0x1000:c412 (1000_5AB3 / 0x15AB3)
    NearCall(cs1, 0x5AB6, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    label_1000_5AB6_15AB6:
    // MOV word ptr [0x3cbe],0x0 (1000_5AB6 / 0x15AB6)
    UInt16[DS, 0x3CBE] = 0x0;
    State.IncCycles();
    // CALL 0x1000:6715 (1000_5ABC / 0x15ABC)
    NearCall(cs1, 0x5ABF, spice86_generated_label_call_target_1000_6715_016715);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5ABF_015ABF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5ABF_015ABF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5ABF_15ABF:
    // MOV SI,0x46e3 (1000_5ABF / 0x15ABF)
    SI = 0x46E3;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_5AC2 / 0x15AC2)
    NearCall(cs1, 0x5AC5, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AC5_015AC5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AC5_015AC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5AC5_15AC5:
    // CALL 0x1000:878c (1000_5AC5 / 0x15AC5)
    NearCall(cs1, 0x5AC8, spice86_generated_label_call_target_1000_878C_01878C);
    State.IncCycles();
    label_1000_5AC8_15AC8:
    // POP AX (1000_5AC8 / 0x15AC8)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x46eb],AL (1000_5AC9 / 0x15AC9)
    UInt8[DS, 0x46EB] = AL;
    State.IncCycles();
    // AND AL,0x40 (1000_5ACC / 0x15ACC)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:5ad3 (1000_5ACE / 0x15ACE)
    if(ZeroFlag) {
      goto label_1000_5AD3_15AD3;
    }
    State.IncCycles();
    // CALL 0x1000:5406 (1000_5AD0 / 0x15AD0)
    NearCall(cs1, 0x5AD3, not_observed_1000_5406_015406);
    State.IncCycles();
    label_1000_5AD3_15AD3:
    // MOV AX,0x1a9e (1000_5AD3 / 0x15AD3)
    AX = 0x1A9E;
    State.IncCycles();
    // CALL 0x1000:d95e (1000_5AD6 / 0x15AD6)
    NearCall(cs1, 0x5AD9, spice86_generated_label_call_target_1000_D95E_01D95E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AD9_015AD9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AD9_015AD9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5AD9_15AD9:
    // MOV SI,0x46e3 (1000_5AD9 / 0x15AD9)
    SI = 0x46E3;
    State.IncCycles();
    // JMP 0x1000:daaa (1000_5ADC / 0x15ADC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DAAA_01DAAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5ADF_015ADF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5ADF_15ADF:
    // CALL 0x1000:7b36 (1000_5ADF / 0x15ADF)
    NearCall(cs1, 0x5AE2, spice86_generated_label_call_target_1000_7B36_017B36);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5AE2_015AE2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5AE2_015AE2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5AE2_15AE2:
    // XOR AX,AX (1000_5AE2 / 0x15AE2)
    AX = 0;
    State.IncCycles();
    // MOV [0x46eb],AL (1000_5AE4 / 0x15AE4)
    UInt8[DS, 0x46EB] = AL;
    State.IncCycles();
    // MOV [0x46f3],AL (1000_5AE7 / 0x15AE7)
    UInt8[DS, 0x46F3] = AL;
    State.IncCycles();
    // MOV [0x3cbe],AX (1000_5AEA / 0x15AEA)
    UInt16[DS, 0x3CBE] = AX;
    State.IncCycles();
    // MOV [0xa5c0],AX (1000_5AED / 0x15AED)
    UInt16[DS, 0xA5C0] = AX;
    State.IncCycles();
    // MOV [0xdbe0],AX (1000_5AF0 / 0x15AF0)
    UInt16[DS, 0xDBE0] = AX;
    State.IncCycles();
    // MOV [0xdbe2],AX (1000_5AF3 / 0x15AF3)
    UInt16[DS, 0xDBE2] = AX;
    State.IncCycles();
    // MOV [0x1954],AX (1000_5AF6 / 0x15AF6)
    UInt16[DS, 0x1954] = AX;
    State.IncCycles();
    // MOV word ptr [0x2786],0xc827 (1000_5AF9 / 0x15AF9)
    UInt16[DS, 0x2786] = 0xC827;
    State.IncCycles();
    // MOV SI,0x6b34 (1000_5AFF / 0x15AFF)
    SI = 0x6B34;
    State.IncCycles();
    // JMP 0x1000:da5f (1000_5B02 / 0x15B02)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B05_015B05(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B05_15B05:
    // CALL 0x1000:82a0 (1000_5B05 / 0x15B05)
    NearCall(cs1, 0x5B08, spice86_generated_label_call_target_1000_82A0_0182A0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B08_015B08, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B08_015B08(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B08_15B08:
    // JNZ 0x1000:5b0d (1000_5B08 / 0x15B08)
    if(!ZeroFlag) {
      goto label_1000_5B0D_15B0D;
    }
    State.IncCycles();
    // JMP 0x1000:541f (1000_5B0A / 0x15B0A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_541F_01541F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5B0D_15B0D:
    // CALL 0x1000:5b5d (1000_5B0D / 0x15B0D)
    NearCall(cs1, 0x5B10, spice86_generated_label_call_target_1000_5B5D_015B5D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B10_015B10, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B10_015B10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B10_15B10:
    // CALL 0x1000:8850 (1000_5B10 / 0x15B10)
    NearCall(cs1, 0x5B13, spice86_generated_label_call_target_1000_8850_018850);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B13_015B13, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B13_015B13(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B13_15B13:
    // TEST byte ptr [0x46eb],0x40 (1000_5B13 / 0x15B13)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    State.IncCycles();
    // JZ 0x1000:5b1d (1000_5B18 / 0x15B18)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5B1D / 0x15B1D)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:5575 (1000_5B1A / 0x15B1A)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_542F_01542F, 0x15575 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5B1D_15B1D:
    // RET  (1000_5B1D / 0x15B1D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B5D_015B5D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B5D_15B5D:
    // CALL 0x1000:407e (1000_5B5D / 0x15B5D)
    NearCall(cs1, 0x5B60, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B60_015B60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B60_015B60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B60_15B60:
    // MOV word ptr [0x197e],BX (1000_5B60 / 0x15B60)
    UInt16[DS, 0x197E] = BX;
    State.IncCycles();
    // MOV word ptr [0x197c],DX (1000_5B64 / 0x15B64)
    UInt16[DS, 0x197C] = DX;
    State.IncCycles();
    // RET  (1000_5B68 / 0x15B68)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B69_015B69(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B69_15B69:
    // MOV SI,0x46e3 (1000_5B69 / 0x15B69)
    SI = 0x46E3;
    State.IncCycles();
    // MOV AL,0xfc (1000_5B6C / 0x15B6C)
    AL = 0xFC;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B6E_015B6E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B6E_015B6E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B6E_15B6E:
    // MOV DX,word ptr [SI] (1000_5B6E / 0x15B6E)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_5B70 / 0x15B70)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_5B73 / 0x15B73)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV CX,word ptr [SI + 0x6] (1000_5B76 / 0x15B76)
    CX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV BP,0x4 (1000_5B79 / 0x15B79)
    BP = 0x4;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5B7C_015B7C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_5B7C_015B7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B7C_15B7C:
    // PUSH AX (1000_5B7C / 0x15B7C)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BP (1000_5B7D / 0x15B7D)
    Stack.Push(BP);
    State.IncCycles();
    // DEC DX (1000_5B7E / 0x15B7E)
    DX--;
    State.IncCycles();
    // DEC BX (1000_5B7F / 0x15B7F)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // CALL 0x1000:c560 (1000_5B80 / 0x15B80)
    NearCall(cs1, 0x5B83, spice86_generated_label_call_target_1000_C560_01C560);
    State.IncCycles();
    label_1000_5B83_15B83:
    // POP BP (1000_5B83 / 0x15B83)
    BP = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_5B84 / 0x15B84)
    AX = Stack.Pop();
    State.IncCycles();
    // INC DI (1000_5B85 / 0x15B85)
    DI++;
    State.IncCycles();
    // INC CX (1000_5B86 / 0x15B86)
    CX++;
    State.IncCycles();
    // SUB AL,0x2 (1000_5B87 / 0x15B87)
    AL -= 0x2;
    State.IncCycles();
    // DEC BP (1000_5B89 / 0x15B89)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // JNZ 0x1000:5b7c (1000_5B8A / 0x15B8A)
    if(!ZeroFlag) {
      goto label_1000_5B7C_15B7C;
    }
    State.IncCycles();
    // RET  (1000_5B8C / 0x15B8C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5B8D_015B8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B8D_15B8D:
    // MOV DI,0xd83c (1000_5B8D / 0x15B8D)
    DI = 0xD83C;
    State.IncCycles();
    // CALL 0x1000:5b96 (1000_5B90 / 0x15B90)
    NearCall(cs1, 0x5B93, spice86_generated_label_call_target_1000_5B96_015B96);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5B93_015B93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5B93_015B93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
  
  public virtual Action spice86_generated_label_call_target_1000_5B96_015B96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
  
  public virtual Action spice86_generated_label_call_target_1000_5B99_015B99(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5B99_15B99:
    // PUSH DS (1000_5B99 / 0x15B99)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_5B9A / 0x15B9A)
    ES = Stack.Pop();
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_5B9B / 0x15B9B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_5B9C / 0x15B9C)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_5B9D / 0x15B9D)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_5B9E / 0x15B9E)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // RET  (1000_5B9F / 0x15B9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5BA0_015BA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5BA0_15BA0:
    // MOV SI,0x1470 (1000_5BA0 / 0x15BA0)
    SI = 0x1470;
    State.IncCycles();
    // MOV DI,0xd83c (1000_5BA3 / 0x15BA3)
    DI = 0xD83C;
    State.IncCycles();
    // JMP 0x1000:5b99 (1000_5BA6 / 0x15BA6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5BA8_015BA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5BA8_15BA8:
    // MOV SI,0x1470 (1000_5BA8 / 0x15BA8)
    SI = 0x1470;
    State.IncCycles();
    // MOV DI,0xd834 (1000_5BAB / 0x15BAB)
    DI = 0xD834;
    State.IncCycles();
    // JMP 0x1000:5b99 (1000_5BAE / 0x15BAE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5BB0_015BB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5BB0_15BB0:
    // CALL 0x1000:c08e (1000_5BB0 / 0x15BB0)
    NearCall(cs1, 0x5BB3, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // MOV SI,0x194a (1000_5BB3 / 0x15BB3)
    SI = 0x194A;
    State.IncCycles();
    // MOV word ptr [0xdbe0],SI (1000_5BB6 / 0x15BB6)
    UInt16[DS, 0xDBE0] = SI;
    State.IncCycles();
    // CALL 0x1000:7b1b (1000_5BBA / 0x15BBA)
    NearCall(cs1, 0x5BBD, spice86_generated_label_call_target_1000_7B1B_017B1B);
    State.IncCycles();
    // CALL 0x1000:d068 (1000_5BBD / 0x15BBD)
    NearCall(cs1, 0x5BC0, spice86_generated_label_call_target_1000_D068_01D068);
    State.IncCycles();
    // MOV SI,0xe2 (1000_5BC0 / 0x15BC0)
    SI = 0xE2;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_5BC3 / 0x15BC3)
    NearCall(cs1, 0x5BC6, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    // CALL 0x1000:d03c (1000_5BC6 / 0x15BC6)
    NearCall(cs1, 0x5BC9, spice86_generated_label_call_target_1000_D03C_01D03C);
    State.IncCycles();
    // MOV AL,[0x28] (1000_5BC9 / 0x15BC9)
    AL = UInt8[DS, 0x28];
    State.IncCycles();
    // XOR AH,AH (1000_5BCC / 0x15BCC)
    AH = 0;
    State.IncCycles();
    // CALL 0x1000:e2e3 (1000_5BCE / 0x15BCE)
    NearCall(cs1, 0x5BD1, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    State.IncCycles();
    // MOV DX,word ptr [0x194a] (1000_5BD1 / 0x15BD1)
    DX = UInt16[DS, 0x194A];
    State.IncCycles();
    // MOV BX,word ptr [0x194c] (1000_5BD5 / 0x15BD5)
    BX = UInt16[DS, 0x194C];
    State.IncCycles();
    // ADD DX,0xa (1000_5BD9 / 0x15BD9)
    DX += 0xA;
    State.IncCycles();
    // ADD BX,0x8 (1000_5BDC / 0x15BDC)
    // BX += 0x8;
    BX = Alu.Add16(BX, 0x8);
    State.IncCycles();
    // MOV CX,0xf0 (1000_5BDF / 0x15BDF)
    CX = 0xF0;
    State.IncCycles();
    // MOV AX,0xe2 (1000_5BE2 / 0x15BE2)
    AX = 0xE2;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_5BE5 / 0x15BE5)
    NearCall(cs1, 0x5BE8, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // JMP 0x1000:c07c (1000_5BE8 / 0x15BE8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5BEB_015BEB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5BEB_15BEB:
    // CMP word ptr [0xdbe0],0x194a (1000_5BEB / 0x15BEB)
    Alu.Sub16(UInt16[DS, 0xDBE0], 0x194A);
    State.IncCycles();
    // JNZ 0x1000:5c02 (1000_5BF1 / 0x15BF1)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5C02 / 0x15C02)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_5BF3 / 0x15BF3)
    NearCall(cs1, 0x5BF6, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // XOR SI,SI (1000_5BF6 / 0x15BF6)
    SI = 0;
    State.IncCycles();
    // XCHG word ptr [0xdbe0],SI (1000_5BF8 / 0x15BF8)
    ushort tmp_1000_5BF8 = UInt16[DS, 0xDBE0];
    UInt16[DS, 0xDBE0] = SI;
    SI = tmp_1000_5BF8;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_5BFC / 0x15BFC)
    NearCall(cs1, 0x5BFF, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    State.IncCycles();
    // CALL 0x1000:e283 (1000_5BFF / 0x15BFF)
    NearCall(cs1, 0x5C02, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_5C02_15C02:
    // RET  (1000_5C02 / 0x15C02)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5C03_015C03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5C03_15C03:
    // MOV DI,word ptr [0xdbe0] (1000_5C03 / 0x15C03)
    DI = UInt16[DS, 0xDBE0];
    State.IncCycles();
    // CMP DI,0x194a (1000_5C07 / 0x15C07)
    Alu.Sub16(DI, 0x194A);
    State.IncCycles();
    // JNZ 0x1000:5c22 (1000_5C0B / 0x15C0B)
    if(!ZeroFlag) {
      goto label_1000_5C22_15C22;
    }
    State.IncCycles();
    // MOV AX,[0xce7a] (1000_5C0D / 0x15C0D)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,word ptr [0xdc5a] (1000_5C10 / 0x15C10)
    AX -= UInt16[DS, 0xDC5A];
    State.IncCycles();
    // CMP AX,0x3e8 (1000_5C14 / 0x15C14)
    Alu.Sub16(AX, 0x3E8);
    State.IncCycles();
    // JC 0x1000:5c22 (1000_5C17 / 0x15C17)
    if(CarryFlag) {
      goto label_1000_5C22_15C22;
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_5C19 / 0x15C19)
    NearCall(cs1, 0x5C1C, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:5beb (1000_5C1C / 0x15C1C)
    NearCall(cs1, 0x5C1F, spice86_generated_label_call_target_1000_5BEB_015BEB);
    State.IncCycles();
    // JMP 0x1000:dbec (1000_5C1F / 0x15C1F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5C22_15C22:
    // CMP DI,0x4710 (1000_5C22 / 0x15C22)
    Alu.Sub16(DI, 0x4710);
    State.IncCycles();
    // JZ 0x1000:5c32 (1000_5C26 / 0x15C26)
    if(ZeroFlag) {
      goto label_1000_5C32_15C32;
    }
    State.IncCycles();
    // MOV DI,word ptr [0xdbe2] (1000_5C28 / 0x15C28)
    DI = UInt16[DS, 0xDBE2];
    State.IncCycles();
    // CMP DI,0x4710 (1000_5C2C / 0x15C2C)
    Alu.Sub16(DI, 0x4710);
    State.IncCycles();
    // JNZ 0x1000:5c75 (1000_5C30 / 0x15C30)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5C75 / 0x15C75)
      return NearRet();
    }
    State.IncCycles();
    label_1000_5C32_15C32:
    // CALL 0x1000:d6fe (1000_5C32 / 0x15C32)
    NearCall(cs1, 0x5C35, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    // JNC 0x1000:5c4b (1000_5C35 / 0x15C35)
    if(!CarryFlag) {
      goto label_1000_5C4B_15C4B;
    }
    State.IncCycles();
    // MOV byte ptr [0x46eb],0x40 (1000_5C37 / 0x15C37)
    UInt8[DS, 0x46EB] = 0x40;
    State.IncCycles();
    // MOV AL,0xff (1000_5C3C / 0x15C3C)
    AL = 0xFF;
    State.IncCycles();
    // CALL 0x1000:5e6d (1000_5C3E / 0x15C3E)
    NearCall(cs1, 0x5C41, spice86_generated_label_call_target_1000_5E6D_015E6D);
    State.IncCycles();
    // MOV byte ptr [0x46eb],0xc0 (1000_5C41 / 0x15C41)
    UInt8[DS, 0x46EB] = 0xC0;
    State.IncCycles();
    // CMP AX,0x9 (1000_5C46 / 0x15C46)
    Alu.Sub16(AX, 0x9);
    State.IncCycles();
    // JC 0x1000:5c4d (1000_5C49 / 0x15C49)
    if(CarryFlag) {
      goto label_1000_5C4D_15C4D;
    }
    State.IncCycles();
    label_1000_5C4B_15C4B:
    // XOR DI,DI (1000_5C4B / 0x15C4B)
    DI = 0;
    State.IncCycles();
    label_1000_5C4D_15C4D:
    // MOV AX,DI (1000_5C4D / 0x15C4D)
    AX = DI;
    State.IncCycles();
    // XCHG word ptr [0x46fc],AX (1000_5C4F / 0x15C4F)
    ushort tmp_1000_5C4F = UInt16[DS, 0x46FC];
    UInt16[DS, 0x46FC] = AX;
    AX = tmp_1000_5C4F;
    State.IncCycles();
    // CMP AX,DI (1000_5C53 / 0x15C53)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JZ 0x1000:5c6e (1000_5C55 / 0x15C55)
    if(ZeroFlag) {
      goto label_1000_5C6E_15C6E;
    }
    State.IncCycles();
    // PUSH BX (1000_5C57 / 0x15C57)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_5C58 / 0x15C58)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_5C59 / 0x15C59)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH word ptr [0xdbda] (1000_5C5A / 0x15C5A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_5C5E / 0x15C5E)
    NearCall(cs1, 0x5C61, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_5C61 / 0x15C61)
    NearCall(cs1, 0x5C64, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:5692 (1000_5C64 / 0x15C64)
    NearCall(cs1, 0x5C67, not_observed_1000_5692_015692);
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_5C67 / 0x15C67)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_5C6B / 0x15C6B)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_5C6C / 0x15C6C)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_5C6D / 0x15C6D)
    BX = Stack.Pop();
    State.IncCycles();
    label_1000_5C6E_15C6E:
    // OR DI,DI (1000_5C6E / 0x15C6E)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JNZ 0x1000:5c75 (1000_5C70 / 0x15C70)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5C75 / 0x15C75)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:5746 (1000_5C72 / 0x15C72)
    NearCall(cs1, 0x5C75, not_observed_1000_5746_015746);
    State.IncCycles();
    label_1000_5C75_15C75:
    // RET  (1000_5C75 / 0x15C75)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5C76_015C76(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5C76_15C76:
    // CALL 0x1000:5beb (1000_5C76 / 0x15C76)
    NearCall(cs1, 0x5C79, spice86_generated_label_call_target_1000_5BEB_015BEB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5C79_015C79, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5C79_015C79(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5C79_15C79:
    // CALL 0x1000:c13b (1000_5C79 / 0x15C79)
    NearCall(cs1, 0x5C7C, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5C7C_015C7C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5C7C_015C7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5C7C_15C7C:
    // MOV DI,word ptr [0xdbe0] (1000_5C7C / 0x15C7C)
    DI = UInt16[DS, 0xDBE0];
    State.IncCycles();
    // OR DI,DI (1000_5C80 / 0x15C80)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:5c95 (1000_5C82 / 0x15C82)
    if(ZeroFlag) {
      goto label_1000_5C95_15C95;
    }
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_5C84 / 0x15C84)
    NearCall(cs1, 0x5C87, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_5C87_15C87:
    // JNC 0x1000:5c95 (1000_5C87 / 0x15C87)
    if(!CarryFlag) {
      goto label_1000_5C95_15C95;
    }
    State.IncCycles();
    // CMP DI,0x4710 (1000_5C89 / 0x15C89)
    Alu.Sub16(DI, 0x4710);
    State.IncCycles();
    // JNZ 0x1000:5c92 (1000_5C8D / 0x15C8D)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:7e97 (1000_5C92 / 0x15C92)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E97_017E97, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:5923 (1000_5C8F / 0x15C8F)
    throw FailAsUntested("Would have been a goto but label label_1000_5923_15923 does not exist because no instruction was found there that belongs to a function.");
    State.IncCycles();
    label_1000_5C92_15C92:
    // JMP 0x1000:7e97 (1000_5C92 / 0x15C92)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E97_017E97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5C95_15C95:
    // MOV DI,word ptr [0xdbe2] (1000_5C95 / 0x15C95)
    DI = UInt16[DS, 0xDBE2];
    State.IncCycles();
    // OR DI,DI (1000_5C99 / 0x15C99)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:5ca5 (1000_5C9B / 0x15C9B)
    if(ZeroFlag) {
      goto label_1000_5CA5_15CA5;
    }
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_5C9D / 0x15C9D)
    NearCall(cs1, 0x5CA0, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_5CA0_15CA0:
    // JNC 0x1000:5ca5 (1000_5CA0 / 0x15CA0)
    if(!CarryFlag) {
      goto label_1000_5CA5_15CA5;
    }
    State.IncCycles();
    // JMP 0x1000:7eb8 (1000_5CA2 / 0x15CA2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7EB8_017EB8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5CA5_15CA5:
    // CMP byte ptr [0x46f5],0x0 (1000_5CA5 / 0x15CA5)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    State.IncCycles();
    // JZ 0x1000:5caf (1000_5CAA / 0x15CAA)
    if(ZeroFlag) {
      goto label_1000_5CAF_15CAF;
    }
    State.IncCycles();
    // JMP 0x1000:d2e2 (1000_5CAC / 0x15CAC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5CAF_15CAF:
    // CALL 0x1000:6946 (1000_5CAF / 0x15CAF)
    NearCall(cs1, 0x5CB2, spice86_generated_label_call_target_1000_6946_016946);
    State.IncCycles();
    label_1000_5CB2_15CB2:
    // JNC 0x1000:5cb7 (1000_5CB2 / 0x15CB2)
    if(!CarryFlag) {
      goto label_1000_5CB7_15CB7;
    }
    State.IncCycles();
    // JMP 0x1000:872c (1000_5CB4 / 0x15CB4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_872C_01872C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5CB7_15CB7:
    // MOV AL,0x31 (1000_5CB7 / 0x15CB7)
    AL = 0x31;
    State.IncCycles();
    // CALL 0x1000:5e6d (1000_5CB9 / 0x15CB9)
    NearCall(cs1, 0x5CBC, spice86_generated_label_call_target_1000_5E6D_015E6D);
    State.IncCycles();
    label_1000_5CBC_15CBC:
    // CMP AX,0x14 (1000_5CBC / 0x15CBC)
    Alu.Sub16(AX, 0x14);
    State.IncCycles();
    // JNC 0x1000:5cca (1000_5CBF / 0x15CBF)
    if(!CarryFlag) {
      goto label_1000_5CCA_15CCA;
    }
    State.IncCycles();
    // CMP DI,word ptr [0x46f8] (1000_5CC1 / 0x15CC1)
    Alu.Sub16(DI, UInt16[DS, 0x46F8]);
    State.IncCycles();
    // JZ 0x1000:5cca (1000_5CC5 / 0x15CC5)
    if(ZeroFlag) {
      goto label_1000_5CCA_15CCA;
    }
    State.IncCycles();
    // JMP 0x1000:5fb0 (1000_5CC7 / 0x15CC7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_5FB0_015FB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5CCA_15CCA:
    // CALL 0x1000:5f79 (1000_5CCA / 0x15CCA)
    NearCall(cs1, 0x5CCD, spice86_generated_label_call_target_1000_5F79_015F79);
    State.IncCycles();
    label_1000_5CCD_15CCD:
    // CALL 0x1000:79de (1000_5CCD / 0x15CCD)
    NearCall(cs1, 0x5CD0, spice86_generated_label_call_target_1000_79DE_0179DE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5CD0_015CD0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5CD0_015CD0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5CD0_15CD0:
    // CALL 0x1000:58fa (1000_5CD0 / 0x15CD0)
    NearCall(cs1, 0x5CD3, spice86_generated_label_call_target_1000_58FA_0158FA);
    State.IncCycles();
    label_1000_5CD3_15CD3:
    // CMP byte ptr [0x1954],0x0 (1000_5CD3 / 0x15CD3)
    Alu.Sub8(UInt8[DS, 0x1954], 0x0);
    State.IncCycles();
    // JZ 0x1000:5ce3 (1000_5CD8 / 0x15CD8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5CE3 / 0x15CE3)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:d316 (1000_5CDA / 0x15CDA)
    NearCall(cs1, 0x5CDD, spice86_generated_label_call_target_1000_D316_01D316);
    State.IncCycles();
    // CALL 0x1000:8763 (1000_5CDD / 0x15CDD)
    NearCall(cs1, 0x5CE0, spice86_generated_label_jump_target_1000_8763_018763);
    State.IncCycles();
    // CALL 0x1000:d280 (1000_5CE0 / 0x15CE0)
    NearCall(cs1, 0x5CE3, spice86_generated_label_call_target_1000_D280_01D280);
    State.IncCycles();
    label_1000_5CE3_15CE3:
    // RET  (1000_5CE3 / 0x15CE3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5D1D_015D1D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5D1D_15D1D:
    // CMP DX,word ptr [0x46e3] (1000_5D1D / 0x15D1D)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    State.IncCycles();
    // CMC  (1000_5D21 / 0x15D21)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JNC 0x1000:5d35 (1000_5D22 / 0x15D22)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    State.IncCycles();
    // CMP DX,word ptr [0x46e7] (1000_5D24 / 0x15D24)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    State.IncCycles();
    // JNC 0x1000:5d35 (1000_5D28 / 0x15D28)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,word ptr [0x46e5] (1000_5D2A / 0x15D2A)
    Alu.Sub16(BX, UInt16[DS, 0x46E5]);
    State.IncCycles();
    // CMC  (1000_5D2E / 0x15D2E)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JNC 0x1000:5d35 (1000_5D2F / 0x15D2F)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5D35 / 0x15D35)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,word ptr [0x46e9] (1000_5D31 / 0x15D31)
    Alu.Sub16(BX, UInt16[DS, 0x46E9]);
    State.IncCycles();
    label_1000_5D35_15D35:
    // RET  (1000_5D35 / 0x15D35)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5D36_015D36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5D36_15D36:
    // CMP byte ptr [DI + 0x8],0x28 (1000_5D36 / 0x15D36)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    State.IncCycles();
    // JC 0x1000:5d43 (1000_5D3A / 0x15D3A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5D43 / 0x15D43)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x8 (1000_5D3C / 0x15D3C)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    State.IncCycles();
    // JZ 0x1000:5d43 (1000_5D40 / 0x15D40)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5D43 / 0x15D43)
      return NearRet();
    }
    State.IncCycles();
    // STC  (1000_5D42 / 0x15D42)
    CarryFlag = true;
    State.IncCycles();
    label_1000_5D43_15D43:
    // RET  (1000_5D43 / 0x15D43)
    return NearRet();
  }
  
  public virtual Action split_1000_5D44_015D44(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5D44_15D44:
    // TEST byte ptr [0x11c9],0x3 (1000_5D44 / 0x15D44)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JZ 0x1000:5d50 (1000_5D49 / 0x15D49)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR byte ptr [0x4728],0x1 (1000_5D4B / 0x15D4B)
    // UInt8[DS, 0x4728] |= 0x1;
    UInt8[DS, 0x4728] = Alu.Or8(UInt8[DS, 0x4728], 0x1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_5D50_015D50(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5D50_15D50:
    // PUSH SI (1000_5D50 / 0x15D50)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_5D51 / 0x15D51)
    Stack.Push(DI);
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x80 (1000_5D52 / 0x15D52)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:5d6a (1000_5D56 / 0x15D56)
    if(!ZeroFlag) {
      goto label_1000_5D6A_15D6A;
    }
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_5D58 / 0x15D58)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JZ 0x1000:5d6a (1000_5D5D / 0x15D5D)
    if(ZeroFlag) {
      goto label_1000_5D6A_15D6A;
    }
    State.IncCycles();
    // MOV SI,DI (1000_5D5F / 0x15D5F)
    SI = DI;
    State.IncCycles();
    // CALL 0x1000:62c9 (1000_5D61 / 0x15D61)
    NearCall(cs1, 0x5D64, spice86_generated_label_call_target_1000_62C9_0162C9);
    State.IncCycles();
    // JC 0x1000:5d6a (1000_5D64 / 0x15D64)
    if(CarryFlag) {
      goto label_1000_5D6A_15D6A;
    }
    State.IncCycles();
    // INC byte ptr [0x46ec] (1000_5D66 / 0x15D66)
    UInt8[DS, 0x46EC] = Alu.Inc8(UInt8[DS, 0x46EC]);
    State.IncCycles();
    label_1000_5D6A_15D6A:
    // POP DI (1000_5D6A / 0x15D6A)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_5D6B / 0x15D6B)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5D6C / 0x15D6C)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5D6D_015D6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5D6D_15D6D:
    // MOV byte ptr [0x46ec],0x0 (1000_5D6D / 0x15D6D)
    UInt8[DS, 0x46EC] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x0 (1000_5D72 / 0x15D72)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:5d82 (1000_5D77 / 0x15D77)
    if(SignFlag) {
      goto label_1000_5D82_15D82;
    }
    State.IncCycles();
    // JZ 0x1000:5dcd (1000_5D79 / 0x15D79)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5DCD / 0x15DCD)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_5D7B / 0x15D7B)
    NearCall(cs1, 0x5D7E, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // JMP word ptr [0x46ed] (1000_5D7E / 0x15D7E)
    // Indirect jump to word ptr [0x46ed], generating possible targets from emulator records
    uint targetAddress_1000_5D7E = (uint)(UInt16[DS, 0x46ED]);
    switch(targetAddress_1000_5D7E) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_5D7E));
        break;
    }
    State.IncCycles();
    label_1000_5D82_15D82:
    // CALL 0x1000:c07c (1000_5D82 / 0x15D82)
    NearCall(cs1, 0x5D85, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_5D85 / 0x15D85)
    NearCall(cs1, 0x5D88, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:5b8d (1000_5D88 / 0x15D88)
    NearCall(cs1, 0x5D8B, spice86_generated_label_call_target_1000_5B8D_015B8D);
    State.IncCycles();
    // MOV AL,0x80 (1000_5D8B / 0x15D8B)
    AL = 0x80;
    State.IncCycles();
    // XCHG byte ptr [0x46eb],AL (1000_5D8D / 0x15D8D)
    byte tmp_1000_5D8D = UInt8[DS, 0x46EB];
    UInt8[DS, 0x46EB] = AL;
    AL = tmp_1000_5D8D;
    State.IncCycles();
    // PUSH AX (1000_5D91 / 0x15D91)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH word ptr [0x46ef] (1000_5D92 / 0x15D92)
    Stack.Push(UInt16[DS, 0x46EF]);
    State.IncCycles();
    // CALL 0x1000:b6c3 (1000_5D96 / 0x15D96)
    NearCall(cs1, 0x5D99, spice86_generated_label_call_target_1000_B6C3_01B6C3);
    State.IncCycles();
    // CALL 0x1000:c13b (1000_5D99 / 0x15D99)
    NearCall(cs1, 0x5D9C, spice86_generated_label_call_target_1000_C13B_01C13B);
    State.IncCycles();
    // CALL 0x1000:5dce (1000_5D9C / 0x15D9C)
    NearCall(cs1, 0x5D9F, spice86_generated_label_call_target_1000_5DCE_015DCE);
    State.IncCycles();
    // CALL 0x1000:6314 (1000_5D9F / 0x15D9F)
    NearCall(cs1, 0x5DA2, spice86_generated_label_call_target_1000_6314_016314);
    State.IncCycles();
    // CALL 0x1000:c412 (1000_5DA2 / 0x15DA2)
    NearCall(cs1, 0x5DA5, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    // MOV word ptr [0x3cbe],0x0 (1000_5DA5 / 0x15DA5)
    UInt16[DS, 0x3CBE] = 0x0;
    State.IncCycles();
    // CALL 0x1000:6715 (1000_5DAB / 0x15DAB)
    NearCall(cs1, 0x5DAE, spice86_generated_label_call_target_1000_6715_016715);
    State.IncCycles();
    // MOV SI,0x46e3 (1000_5DAE / 0x15DAE)
    SI = 0x46E3;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_5DB1 / 0x15DB1)
    NearCall(cs1, 0x5DB4, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    State.IncCycles();
    // POP SI (1000_5DB4 / 0x15DB4)
    SI = Stack.Pop();
    State.IncCycles();
    // OR SI,SI (1000_5DB5 / 0x15DB5)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:5dbc (1000_5DB7 / 0x15DB7)
    if(ZeroFlag) {
      goto label_1000_5DBC_15DBC;
    }
    State.IncCycles();
    // CALL 0x1000:697c (1000_5DB9 / 0x15DB9)
    NearCall(cs1, 0x5DBC, spice86_generated_label_call_target_1000_697C_01697C);
    State.IncCycles();
    label_1000_5DBC_15DBC:
    // CALL 0x1000:1c18 (1000_5DBC / 0x15DBC)
    NearCall(cs1, 0x5DBF, spice86_generated_label_call_target_1000_1C18_011C18);
    State.IncCycles();
    // POP AX (1000_5DBF / 0x15DBF)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x46eb],AL (1000_5DC0 / 0x15DC0)
    UInt8[DS, 0x46EB] = AL;
    State.IncCycles();
    // AND AL,0x40 (1000_5DC3 / 0x15DC3)
    // AL &= 0x40;
    AL = Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:5dca (1000_5DC5 / 0x15DC5)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:c13b (1000_5DCA / 0x15DCA)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:542f (1000_5DC7 / 0x15DC7)
    NearCall(cs1, 0x5DCA, not_observed_1000_542F_01542F);
    State.IncCycles();
    label_1000_5DCA_15DCA:
    // JMP 0x1000:c13b (1000_5DCA / 0x15DCA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_5DCD_15DCD:
    // RET  (1000_5DCD / 0x15DCD)
    return NearRet();
  }
  
}
