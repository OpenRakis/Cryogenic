namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_563E_010F_0564EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    label_563E_0182_56562:
    // XOR AX,0x1310 (563E_0182 / 0x56562)
    AX ^= 0x1310;
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
    label_563E_0188_56568:
    // AND AL,0x0 (563E_0188 / 0x56568)
    AL &= 0x0;
    // XOR AX,0x3d00 (563E_018A / 0x5656A)
    AX ^= 0x3D00;
    // ADD byte ptr [BX + SI + 0x0],DH (563E_018D / 0x5656D)
    UInt8[DS, (ushort)(BX + SI)] += DH;
    // IMUL AX,word ptr [BX + SI],0x7d (563E_0190 / 0x56570)
    Cpu.IMul16(AX);
    // ADD byte ptr [BP + SI],DL (563E_0193 / 0x56573)
    UInt8[SS, (ushort)(BP + SI)] += DL;
    // ADD word ptr [BX + SI + 0x2b01],SI (563E_0195 / 0x56575)
    UInt16[DS, (ushort)(BX + SI + 0x2B01)] += SI;
    // ADD word ptr [BP + DI + 0x60aa],SI (563E_0199 / 0x56579)
    // UInt16[SS, (ushort)(BP + DI + 0x60AA)] += SI;
    UInt16[SS, (ushort)(BP + DI + 0x60AA)] = Alu.Add16(UInt16[SS, (ushort)(BP + DI + 0x60AA)], SI);
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
    // ADD AL,0x60 (563E_01A0 / 0x56580)
    // AL += 0x60;
    AL = Alu.Add8(AL, 0x60);
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
    // Instruction bytes at index 0 modified by those instruction(s): 56823
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified. Possible opcodes: 60, 7. Opcode offset:0");
    // POP ES (563E_01A3 / 0x56583)
    ES = Stack.Pop();
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
    // DEC BP (563E_01A5 / 0x56585)
    BP--;
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
    label_563E_01A8_56588:
    // PUSH SS (563E_01A8 / 0x56588)
    Stack.Push(SS);
    // POP ES (563E_01A9 / 0x56589)
    ES = Stack.Pop();
    // MOV SI,BP (563E_01AA / 0x5658A)
    SI = BP;
    label_563E_01AC_5658C:
    // LODSW ES:SI (563E_01AC / 0x5658C)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // ADD AX,0x2 (563E_01AE / 0x5658E)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // MOV DI,AX (563E_01B1 / 0x56591)
    DI = AX;
    // PUSH CX (563E_01B3 / 0x56593)
    Stack.Push(CX);
    // MOV CX,0x9 (563E_01B4 / 0x56594)
    CX = 0x9;
    // MOV AL,0x2e (563E_01B7 / 0x56597)
    AL = 0x2E;
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
    // POP CX (563E_01BB / 0x5659B)
    CX = Stack.Pop();
    // JNZ 0x5000:65a8 (563E_01BC / 0x5659C)
    if(!ZeroFlag) {
      goto label_563E_01C8_565A8;
    }
    // MOV AX,CS:[0x1a5] (563E_01BE / 0x5659E)
    AX = UInt16[cs4, 0x1A5];
    // STOSW ES:DI (563E_01C2 / 0x565A2)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,CS:[0x1a7] (563E_01C3 / 0x565A3)
    AL = UInt8[cs4, 0x1A7];
    // STOSB ES:DI (563E_01C7 / 0x565A7)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    label_563E_01C8_565A8:
    // LOOP 0x5000:658c (563E_01C8 / 0x565A8)
    if(--CX != 0) {
      goto label_563E_01AC_5658C;
    }
    // RET  (563E_01CA / 0x565AA)
    return NearRet();
  }
  
  public virtual Action not_observed_563E_01CB_0565AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_01CB_565AB:
    // OR AX,AX (563E_01CB / 0x565AB)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x5000:65b3 (563E_01CD / 0x565AD)
    if(ZeroFlag) {
      goto label_563E_01D3_565B3;
    }
    // MOV CS:[0x125],AX (563E_01CF / 0x565AF)
    UInt16[cs4, 0x125] = AX;
    label_563E_01D3_565B3:
    // CALL 0x5000:6588 (563E_01D3 / 0x565B3)
    NearCall(cs4, 0x1D6, not_observed_563E_01A8_056588);
    // CALL 0x5000:6939 (563E_01D6 / 0x565B6)
    NearCall(cs4, 0x1D9, not_observed_563E_0559_056939);
    // PUSH CS (563E_01D9 / 0x565B9)
    Stack.Push(cs4);
    // CALL 0x5000:65c1 (563E_01DA / 0x565BA)
    NearCall(cs4, 0x1DD, not_observed_563E_01E1_0565C1);
    // MOV BX,0x500 (563E_01DD / 0x565BD)
    BX = 0x500;
    // RETF  (563E_01E0 / 0x565C0)
    return FarRet();
  }
  
  public virtual Action not_observed_563E_01E1_0565C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_01E1_565C1:
    // PUSHF  (563E_01E1 / 0x565C1)
    Stack.Push(FlagRegister);
    // CLI  (563E_01E2 / 0x565C2)
    InterruptFlag = false;
    // CALL 0x5000:690f (563E_01E3 / 0x565C3)
    NearCall(cs4, 0x1E6, spice86_generated_label_call_target_563E_052F_05690F);
    // XOR AX,AX (563E_01E6 / 0x565C6)
    AX = 0;
    // MOV CS:[0x139],AL (563E_01E8 / 0x565C8)
    UInt8[cs4, 0x139] = AL;
    // POPF  (563E_01EC / 0x565CC)
    FlagRegister = Stack.Pop();
    // RETF  (563E_01ED / 0x565CD)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_01EE_0565CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_01EE_565CE:
    // PUSH BX (563E_01EE / 0x565CE)
    Stack.Push(BX);
    // MOV BX,0xffff (563E_01EF / 0x565CF)
    BX = 0xFFFF;
    // CMP AX,0x60 (563E_01F2 / 0x565D2)
    Alu.Sub16(AX, 0x60);
    // JC 0x5000:65f1 (563E_01F5 / 0x565D5)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    // MOV BX,0xaaaa (563E_01F7 / 0x565D7)
    BX = 0xAAAA;
    // CMP AX,0xc0 (563E_01FA / 0x565DA)
    Alu.Sub16(AX, 0xC0);
    // JC 0x5000:65f1 (563E_01FD / 0x565DD)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    // MOV BX,0x8888 (563E_01FF / 0x565DF)
    BX = 0x8888;
    // CMP AX,0x180 (563E_0202 / 0x565E2)
    Alu.Sub16(AX, 0x180);
    // JC 0x5000:65f1 (563E_0205 / 0x565E5)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    // MOV BX,0x8080 (563E_0207 / 0x565E7)
    BX = 0x8080;
    // CMP AX,0x300 (563E_020A / 0x565EA)
    Alu.Sub16(AX, 0x300);
    // JC 0x5000:65f1 (563E_020D / 0x565ED)
    if(CarryFlag) {
      goto label_563E_0211_565F1;
    }
    // XOR BL,BL (563E_020F / 0x565EF)
    BL = 0;
    label_563E_0211_565F1:
    // MOV word ptr CS:[0x13b],BX (563E_0211 / 0x565F1)
    UInt16[cs4, 0x13B] = BX;
    // POP BX (563E_0216 / 0x565F6)
    BX = Stack.Pop();
    // MOV byte ptr CS:[0x13e],BL (563E_0217 / 0x565F7)
    UInt8[cs4, 0x13E] = BL;
    // MOV AL,CS:[0x139] (563E_021C / 0x565FC)
    AL = UInt8[cs4, 0x139];
    // OR AL,AL (563E_0220 / 0x56600)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x5000:660a (563E_0222 / 0x56602)
    if(!SignFlag) {
      // JNS target is RETF, inlining.
      // RETF  (563E_022A / 0x5660A)
      return FarRet();
    }
    // OR AL,0x40 (563E_0224 / 0x56604)
    // AL |= 0x40;
    AL = Alu.Or8(AL, 0x40);
    // MOV CS:[0x139],AL (563E_0226 / 0x56606)
    UInt8[cs4, 0x139] = AL;
    label_563E_022A_5660A:
    // RETF  (563E_022A / 0x5660A)
    return FarRet();
  }
  
  public virtual Action not_observed_563E_022B_05660B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_022B_5660B:
    // MOV CS:[0x13f],AL (563E_022B / 0x5660B)
    UInt8[cs4, 0x13F] = AL;
    // MOV CS:[0x13e],AL (563E_022F / 0x5660F)
    UInt8[cs4, 0x13E] = AL;
    // MOV word ptr CS:[0x13b],0xffff (563E_0233 / 0x56613)
    UInt16[cs4, 0x13B] = 0xFFFF;
    // RETF  (563E_023A / 0x5661A)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_023B_05661B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_023B_5661B:
    // MOV byte ptr CS:[0x13a],0x1 (563E_023B / 0x5661B)
    UInt8[cs4, 0x13A] = 0x1;
    // MOV AL,CS:[0x139] (563E_0241 / 0x56621)
    AL = UInt8[cs4, 0x139];
    // RETF  (563E_0245 / 0x56625)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_0250_056630(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0250_56630:
    // PUSH DS (563E_0250 / 0x56630)
    Stack.Push(DS);
    // PUSH CS (563E_0251 / 0x56631)
    Stack.Push(cs4);
    // POP DS (563E_0252 / 0x56632)
    DS = Stack.Pop();
    // MOV [0x13a],AL (563E_0253 / 0x56633)
    UInt8[DS, 0x13A] = AL;
    // MOV AX,word ptr ES:[SI] (563E_0256 / 0x56636)
    AX = UInt16[ES, SI];
    // MOV DI,0x246 (563E_0259 / 0x56639)
    DI = 0x246;
    // MOV word ptr [DI],SI (563E_025C / 0x5663C)
    UInt16[DS, DI] = SI;
    // MOV word ptr [DI + 0x2],ES (563E_025E / 0x5663E)
    UInt16[DS, (ushort)(DI + 0x2)] = ES;
    // MOV word ptr [DI + 0x4],AX (563E_0261 / 0x56641)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    // MOV AX,word ptr ES:[SI + 0x4000] (563E_0264 / 0x56644)
    AX = UInt16[ES, (ushort)(SI + 0x4000)];
    // MOV word ptr [DI + 0x6],AX (563E_0269 / 0x56649)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    // MOV AX,word ptr ES:[SI + 0x8000] (563E_026C / 0x5664C)
    AX = UInt16[ES, (ushort)(SI + 0x8000)];
    // MOV word ptr [DI + 0x8],AX (563E_0271 / 0x56651)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    // ADD SI,0x2 (563E_0274 / 0x56654)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // MOV word ptr [0x115],SI (563E_0277 / 0x56657)
    UInt16[DS, 0x115] = SI;
    // MOV word ptr [0x117],ES (563E_027B / 0x5665B)
    UInt16[DS, 0x117] = ES;
    // SUB SI,0x2 (563E_027F / 0x5665F)
    SI -= 0x2;
    // ADD SI,word ptr ES:[SI] (563E_0282 / 0x56662)
    // SI += UInt16[ES, SI];
    SI = Alu.Add16(SI, UInt16[ES, SI]);
    // MOV word ptr [0x119],SI (563E_0285 / 0x56665)
    UInt16[DS, 0x119] = SI;
    // MOV word ptr [0x11b],ES (563E_0289 / 0x56669)
    UInt16[DS, 0x11B] = ES;
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
    label_563E_0293_56673:
    // MOV AL,[0x13f] (563E_0293 / 0x56673)
    AL = UInt8[DS, 0x13F];
    // MOV [0x13d],AL (563E_0296 / 0x56676)
    UInt8[DS, 0x13D] = AL;
    // MOV [0x13e],AL (563E_0299 / 0x56679)
    UInt8[DS, 0x13E] = AL;
    // XOR AX,AX (563E_029C / 0x5667C)
    AX = 0;
    // MOV [0x11d],AX (563E_029E / 0x5667E)
    UInt16[DS, 0x11D] = AX;
    // MOV [0x123],AX (563E_02A1 / 0x56681)
    UInt16[DS, 0x123] = AX;
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
    label_563E_02A7_56687:
    // MOV AL,0x80 (563E_02A7 / 0x56687)
    AL = 0x80;
    // MOV [0x139],AL (563E_02A9 / 0x56689)
    UInt8[DS, 0x139] = AL;
    // POP DS (563E_02AC / 0x5668C)
    DS = Stack.Pop();
    // RETF  (563E_02AD / 0x5668D)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_02AE_05668E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_02AE_5668E:
    // PUSH DS (563E_02AE / 0x5668E)
    Stack.Push(DS);
    // PUSH DS (563E_02AF / 0x5668F)
    Stack.Push(DS);
    // POP ES (563E_02B0 / 0x56690)
    ES = Stack.Pop();
    // MOV word ptr [0x140],0x0 (563E_02B1 / 0x56691)
    UInt16[DS, 0x140] = 0x0;
    // LDS SI,[0x115] (563E_02B7 / 0x56697)
    DS = UInt16[DS, 0x117];
    SI = UInt16[DS, 0x115];
    // MOV BP,SI (563E_02BB / 0x5669B)
    BP = SI;
    // MOV DI,0x166 (563E_02BD / 0x5669D)
    DI = 0x166;
    // MOV CX,0x9 (563E_02C0 / 0x566A0)
    CX = 0x9;
    label_563E_02C3_566A3:
    // LODSW SI (563E_02C3 / 0x566A3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (563E_02C4 / 0x566A4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x5000:66af (563E_02C6 / 0x566A6)
    if(ZeroFlag) {
      goto label_563E_02CF_566AF;
    }
    // INC word ptr CS:[0x140] (563E_02C8 / 0x566A8)
    UInt16[cs4, 0x140]++;
    // ADD AX,BP (563E_02CD / 0x566AD)
    // AX += BP;
    AX = Alu.Add16(AX, BP);
    label_563E_02CF_566AF:
    // STOSW ES:DI (563E_02CF / 0x566AF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x5000:66a3 (563E_02D0 / 0x566B0)
    if(--CX != 0) {
      goto label_563E_02C3_566A3;
    }
    // MOV DI,0x19c (563E_02D2 / 0x566B2)
    DI = 0x19C;
    // MOV CL,0x9 (563E_02D5 / 0x566B5)
    CL = 0x9;
    // MOV AL,0x60 (563E_02D7 / 0x566B7)
    AL = 0x60;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (563E_02D9 / 0x566B9)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // POP DS (563E_02DB / 0x566BB)
    DS = Stack.Pop();
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
    label_563E_02E0_566C0:
    // MOV word ptr [0x11f],0x1 (563E_02E0 / 0x566C0)
    UInt16[DS, 0x11F] = 0x1;
    // MOV word ptr [0x121],0x60 (563E_02E6 / 0x566C6)
    UInt16[DS, 0x121] = 0x60;
    // MOV CX,0x9 (563E_02EC / 0x566CC)
    CX = 0x9;
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
    label_563E_02F2_566D2:
    // MOV SI,word ptr [DI + 0x24] (563E_02F2 / 0x566D2)
    SI = UInt16[DS, (ushort)(DI + 0x24)];
    // MOV word ptr [DI + 0x12],SI (563E_02F5 / 0x566D5)
    UInt16[DS, (ushort)(DI + 0x12)] = SI;
    // MOV word ptr [DI],0xffff (563E_02F8 / 0x566D8)
    UInt16[DS, DI] = 0xFFFF;
    // OR SI,SI (563E_02FC / 0x566DC)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x5000:66e9 (563E_02FE / 0x566DE)
    if(ZeroFlag) {
      goto label_563E_0309_566E9;
    }
    // MOV AX,CX (563E_0300 / 0x566E0)
    AX = CX;
    // CALL 0x5000:687b (563E_0302 / 0x566E2)
    NearCall(cs4, 0x305, spice86_generated_label_call_target_563E_049B_05687B);
    label_563E_0305_566E5:
    // INC word ptr [DI] (563E_0305 / 0x566E5)
    UInt16[DS, DI] = Alu.Inc16(UInt16[DS, DI]);
    // MOV CX,AX (563E_0307 / 0x566E7)
    CX = AX;
    label_563E_0309_566E9:
    // ADD DI,0x2 (563E_0309 / 0x566E9)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // LOOP 0x5000:66d2 (563E_030C / 0x566EC)
    if(--CX != 0) {
      goto label_563E_02F2_566D2;
    }
    // RET  (563E_030E / 0x566EE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_030F_0566EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_030F_566EF:
    // PUSH DS (563E_030F / 0x566EF)
    Stack.Push(DS);
    // MOV AX,CS (563E_0310 / 0x566F0)
    AX = cs4;
    // MOV DS,AX (563E_0312 / 0x566F2)
    DS = AX;
    // MOV AL,[0x139] (563E_0314 / 0x566F4)
    AL = UInt8[DS, 0x139];
    // OR AL,AL (563E_0317 / 0x566F7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x5000:671c (563E_0319 / 0x566F9)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_032E_05670E, 0x5671C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC byte ptr [0x11e] (563E_031B / 0x566FB)
    UInt8[DS, 0x11E] = Alu.Dec8(UInt8[DS, 0x11E]);
    // JNS 0x5000:6713 (563E_031F / 0x566FF)
    if(!SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_563E_032E_05670E, 0x56713 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x5000:6729 (563E_0321 / 0x56701)
    NearCall(cs4, 0x324, spice86_generated_label_call_target_563E_0349_056729);
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
    // PUSH DX (563E_0326 / 0x56706)
    Stack.Push(DX);
    // PUSH SI (563E_0327 / 0x56707)
    Stack.Push(SI);
    // PUSH DI (563E_0328 / 0x56708)
    Stack.Push(DI);
    // PUSH BP (563E_0329 / 0x56709)
    Stack.Push(BP);
    // PUSH ES (563E_032A / 0x5670A)
    Stack.Push(ES);
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
    label_563E_032E_5670E:
    // POP ES (563E_032E / 0x5670E)
    ES = Stack.Pop();
    // POP BP (563E_032F / 0x5670F)
    BP = Stack.Pop();
    // POP DI (563E_0330 / 0x56710)
    DI = Stack.Pop();
    // POP SI (563E_0331 / 0x56711)
    SI = Stack.Pop();
    // POP DX (563E_0332 / 0x56712)
    DX = Stack.Pop();
    label_563E_0333_56713:
    // ROL word ptr [0x13b],1 (563E_0333 / 0x56713)
    UInt16[DS, 0x13B] = Alu.Rol16(UInt16[DS, 0x13B], 0x1);
    // JNC 0x5000:671c (563E_0337 / 0x56717)
    if(!CarryFlag) {
      goto label_563E_033C_5671C;
    }
    // CALL 0x5000:68b7 (563E_0339 / 0x56719)
    NearCall(cs4, 0x33C, spice86_generated_label_call_target_563E_04D7_0568B7);
    label_563E_033C_5671C:
    // MOV AL,[0x139] (563E_033C / 0x5671C)
    AL = UInt8[DS, 0x139];
    // MOV BX,word ptr [0x11f] (563E_033F / 0x5671F)
    BX = UInt16[DS, 0x11F];
    // MOV CX,word ptr [0x121] (563E_0343 / 0x56723)
    CX = UInt16[DS, 0x121];
    // POP DS (563E_0347 / 0x56727)
    DS = Stack.Pop();
    // RETF  (563E_0348 / 0x56728)
    return FarRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0349_056729(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0349_56729:
    // PUSH SI (563E_0349 / 0x56729)
    Stack.Push(SI);
    // PUSH ES (563E_034A / 0x5672A)
    Stack.Push(ES);
    // LES SI,[0x246] (563E_034B / 0x5672B)
    ES = UInt16[DS, 0x248];
    SI = UInt16[DS, 0x246];
    // MOV AX,word ptr ES:[SI] (563E_034F / 0x5672F)
    AX = UInt16[ES, SI];
    // CMP word ptr [0x24a],AX (563E_0352 / 0x56732)
    Alu.Sub16(UInt16[DS, 0x24A], AX);
    // JNZ 0x5000:674c (563E_0356 / 0x56736)
    if(!ZeroFlag) {
      goto label_563E_036C_5674C;
    }
    // MOV AX,word ptr ES:[SI + 0x4000] (563E_0358 / 0x56738)
    AX = UInt16[ES, (ushort)(SI + 0x4000)];
    // CMP word ptr [0x24c],AX (563E_035D / 0x5673D)
    Alu.Sub16(UInt16[DS, 0x24C], AX);
    // JNZ 0x5000:674c (563E_0361 / 0x56741)
    if(!ZeroFlag) {
      goto label_563E_036C_5674C;
    }
    // MOV AX,word ptr ES:[SI + 0x8000] (563E_0363 / 0x56743)
    AX = UInt16[ES, (ushort)(SI + 0x8000)];
    // CMP word ptr [0x24e],AX (563E_0368 / 0x56748)
    Alu.Sub16(UInt16[DS, 0x24E], AX);
    label_563E_036C_5674C:
    // POP ES (563E_036C / 0x5674C)
    ES = Stack.Pop();
    // POP SI (563E_036D / 0x5674D)
    SI = Stack.Pop();
    // RET  (563E_036E / 0x5674E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_036F_05674F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_036F_5674F:
    // LES BX,[0x115] (563E_036F / 0x5674F)
    ES = UInt16[DS, 0x117];
    BX = UInt16[DS, 0x115];
    // MOV AX,word ptr ES:[BX + 0x30] (563E_0373 / 0x56753)
    AX = UInt16[ES, (ushort)(BX + 0x30)];
    // ADD word ptr [0x11d],AX (563E_0377 / 0x56757)
    // UInt16[DS, 0x11D] += AX;
    UInt16[DS, 0x11D] = Alu.Add16(UInt16[DS, 0x11D], AX);
    // MOV DI,0x142 (563E_037B / 0x5675B)
    DI = 0x142;
    // CALL 0x5000:67a7 (563E_037E / 0x5675E)
    NearCall(cs4, 0x381, spice86_generated_label_call_target_563E_03C7_0567A7);
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
    label_563E_0385_56765:
    // DEC word ptr [DI] (563E_0385 / 0x56765)
    UInt16[DS, DI] = Alu.Dec16(UInt16[DS, DI]);
    // JNZ 0x5000:6792 (563E_0387 / 0x56767)
    if(!ZeroFlag) {
      goto label_563E_03B2_56792;
    }
    label_563E_0389_56769:
    // MOV SI,word ptr [DI + 0x12] (563E_0389 / 0x56769)
    SI = UInt16[DS, (ushort)(DI + 0x12)];
    // OR SI,SI (563E_038C / 0x5676C)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x5000:6792 (563E_038E / 0x5676E)
    if(ZeroFlag) {
      goto label_563E_03B2_56792;
    }
    // PUSH CX (563E_0390 / 0x56770)
    Stack.Push(CX);
    // PUSH DI (563E_0391 / 0x56771)
    Stack.Push(DI);
    // LODSW ES:SI (563E_0392 / 0x56772)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,DI (563E_0394 / 0x56774)
    DX = DI;
    // SUB DX,0x142 (563E_0396 / 0x56776)
    DX -= 0x142;
    // SHR DX,1 (563E_039A / 0x5677A)
    // DX >>= 0x1;
    DX = Alu.Shr16(DX, 0x1);
    // MOV BX,AX (563E_039C / 0x5677C)
    BX = AX;
    // AND BX,0x70 (563E_039E / 0x5677E)
    BX &= 0x70;
    // SHR BX,1 (563E_03A1 / 0x56781)
    BX >>= 0x1;
    // SHR BX,1 (563E_03A3 / 0x56783)
    BX >>= 0x1;
    // SHR BX,1 (563E_03A5 / 0x56785)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
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
    label_563E_03AB_5678B:
    // POP DI (563E_03AB / 0x5678B)
    DI = Stack.Pop();
    // POP CX (563E_03AC / 0x5678C)
    CX = Stack.Pop();
    // CMP word ptr [DI],0x0 (563E_03AD / 0x5678D)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    // JZ 0x5000:6769 (563E_03B0 / 0x56790)
    if(ZeroFlag) {
      goto label_563E_0389_56769;
    }
    label_563E_03B2_56792:
    // ADD DI,0x2 (563E_03B2 / 0x56792)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // LOOP 0x5000:6765 (563E_03B5 / 0x56795)
    if(--CX != 0) {
      goto label_563E_0385_56765;
    }
    // DEC byte ptr [0x121] (563E_03B7 / 0x56797)
    UInt8[DS, 0x121] = Alu.Dec8(UInt8[DS, 0x121]);
    // JNZ 0x5000:67a6 (563E_03BB / 0x5679B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (563E_03C6 / 0x567A6)
      return NearRet();
    }
    // MOV byte ptr [0x121],0x60 (563E_03BD / 0x5679D)
    UInt8[DS, 0x121] = 0x60;
    // INC word ptr [0x11f] (563E_03C2 / 0x567A2)
    UInt16[DS, 0x11F] = Alu.Inc16(UInt16[DS, 0x11F]);
    label_563E_03C6_567A6:
    // RET  (563E_03C6 / 0x567A6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_03C7_0567A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_03C7_567A7:
    // CMP word ptr [0x123],0x0 (563E_03C7 / 0x567A7)
    Alu.Sub16(UInt16[DS, 0x123], 0x0);
    // JNZ 0x5000:67d8 (563E_03CC / 0x567AC)
    if(!ZeroFlag) {
      goto label_563E_03F8_567D8;
    }
    // MOV AX,word ptr ES:[BX + 0x2a] (563E_03CE / 0x567AE)
    AX = UInt16[ES, (ushort)(BX + 0x2A)];
    // CMP AX,word ptr [0x11f] (563E_03D2 / 0x567B2)
    Alu.Sub16(AX, UInt16[DS, 0x11F]);
    // JNZ 0x5000:67d7 (563E_03D6 / 0x567B6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (563E_03F7 / 0x567D7)
      return NearRet();
    }
    // CMP word ptr [0x121],0x60 (563E_03D8 / 0x567B8)
    Alu.Sub16(UInt16[DS, 0x121], 0x60);
    // JNZ 0x5000:67d7 (563E_03DD / 0x567BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (563E_03F7 / 0x567D7)
      return NearRet();
    }
    // PUSH DI (563E_03DF / 0x567BF)
    Stack.Push(DI);
    // PUSH ES (563E_03E0 / 0x567C0)
    Stack.Push(ES);
    // MOV SI,DI (563E_03E1 / 0x567C1)
    SI = DI;
    // ADD DI,0x36 (563E_03E3 / 0x567C3)
    // DI += 0x36;
    DI = Alu.Add16(DI, 0x36);
    // PUSH DS (563E_03E6 / 0x567C6)
    Stack.Push(DS);
    // POP ES (563E_03E7 / 0x567C7)
    ES = Stack.Pop();
    // MOV CX,0x12 (563E_03E8 / 0x567C8)
    CX = 0x12;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (563E_03EB / 0x567CB)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // POP ES (563E_03ED / 0x567CD)
    ES = Stack.Pop();
    // POP DI (563E_03EE / 0x567CE)
    DI = Stack.Pop();
    // MOV AX,word ptr ES:[BX + 0x2e] (563E_03EF / 0x567CF)
    AX = UInt16[ES, (ushort)(BX + 0x2E)];
    // DEC AX (563E_03F3 / 0x567D3)
    AX = Alu.Dec16(AX);
    // MOV [0x123],AX (563E_03F4 / 0x567D4)
    UInt16[DS, 0x123] = AX;
    label_563E_03F7_567D7:
    // RET  (563E_03F7 / 0x567D7)
    return NearRet();
    label_563E_03F8_567D8:
    // MOV AX,word ptr ES:[BX + 0x2c] (563E_03F8 / 0x567D8)
    AX = UInt16[ES, (ushort)(BX + 0x2C)];
    // CMP AX,word ptr [0x11f] (563E_03FC / 0x567DC)
    Alu.Sub16(AX, UInt16[DS, 0x11F]);
    // JNZ 0x5000:67d7 (563E_0400 / 0x567E0)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (563E_03F7 / 0x567D7)
      return NearRet();
    }
    // DEC word ptr [0x123] (563E_0402 / 0x567E2)
    UInt16[DS, 0x123] = Alu.Dec16(UInt16[DS, 0x123]);
    // PUSH DI (563E_0406 / 0x567E6)
    Stack.Push(DI);
    // PUSH ES (563E_0407 / 0x567E7)
    Stack.Push(ES);
    // LEA SI,[DI + 0x36] (563E_0408 / 0x567E8)
    SI = (ushort)(DI + 0x36);
    // PUSH DS (563E_040B / 0x567EB)
    Stack.Push(DS);
    // POP ES (563E_040C / 0x567EC)
    ES = Stack.Pop();
    // MOV CX,0x12 (563E_040D / 0x567ED)
    CX = 0x12;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (563E_0410 / 0x567F0)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // POP ES (563E_0412 / 0x567F2)
    ES = Stack.Pop();
    // POP DI (563E_0413 / 0x567F3)
    DI = Stack.Pop();
    // MOV AX,word ptr ES:[BX + 0x2a] (563E_0414 / 0x567F4)
    AX = UInt16[ES, (ushort)(BX + 0x2A)];
    // MOV [0x11f],AX (563E_0418 / 0x567F8)
    UInt16[DS, 0x11F] = AX;
    // RET  (563E_041B / 0x567FB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_041C_0567FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    label_563E_0422_56802:
    // CALL 0x5000:687b (563E_0422 / 0x56802)
    NearCall(cs4, 0x425, spice86_generated_label_call_target_563E_049B_05687B);
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
    label_563E_0428_56808:
    // MOV CL,byte ptr ES:[SI] (563E_0428 / 0x56808)
    CL = UInt8[ES, SI];
    // INC SI (563E_042B / 0x5680B)
    SI = Alu.Inc16(SI);
    // CALL 0x5000:687b (563E_042C / 0x5680C)
    NearCall(cs4, 0x42F, spice86_generated_label_call_target_563E_049B_05687B);
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
    label_563E_0432_56812:
    // MOV CL,byte ptr ES:[SI] (563E_0432 / 0x56812)
    CL = UInt8[ES, SI];
    // INC SI (563E_0435 / 0x56815)
    SI = Alu.Inc16(SI);
    // CALL 0x5000:687b (563E_0436 / 0x56816)
    NearCall(cs4, 0x439, spice86_generated_label_call_target_563E_049B_05687B);
    label_563E_0439_56819:
    // CMP AH,0x7 (563E_0439 / 0x56819)
    Alu.Sub8(AH, 0x7);
    // JNZ 0x5000:6830 (563E_043C / 0x5681C)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x5000:6986 (563E_0450 / 0x56830)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_563E_05A6_056986, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BX,AX (563E_043E / 0x5681E)
    BX = AX;
    // AND BX,0xf (563E_0440 / 0x56820)
    // BX &= 0xF;
    BX = Alu.And16(BX, 0xF);
    // MOV byte ptr [BX + 0x19c],CL (563E_0443 / 0x56823)
    UInt8[DS, (ushort)(BX + 0x19C)] = CL;
    // PUSH AX (563E_0447 / 0x56827)
    Stack.Push(AX);
    // MOV AL,[0x13d] (563E_0448 / 0x56828)
    AL = UInt8[DS, 0x13D];
    // MUL CL (563E_044B / 0x5682B)
    Cpu.Mul8(CL);
    // MOV CL,AH (563E_044D / 0x5682D)
    CL = AH;
    // POP AX (563E_044F / 0x5682F)
    AX = Stack.Pop();
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
    label_563E_045D_5683D:
    // CMP AL,0xff (563E_045D / 0x5683D)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x5000:6842 (563E_045F / 0x5683F)
    if(ZeroFlag) {
      goto label_563E_0462_56842;
    }
    // NOP  (563E_0461 / 0x56841)
    
    label_563E_0462_56842:
    // MOV word ptr [DI],0xffff (563E_0462 / 0x56842)
    UInt16[DS, DI] = 0xFFFF;
    // SUB byte ptr [DI + 0x12],0x2 (563E_0466 / 0x56846)
    // UInt8[DS, (ushort)(DI + 0x12)] -= 0x2;
    UInt8[DS, (ushort)(DI + 0x12)] = Alu.Sub8(UInt8[DS, (ushort)(DI + 0x12)], 0x2);
    // OR DX,DX (563E_046A / 0x5684A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNZ 0x5000:6869 (563E_046C / 0x5684C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (563E_0489 / 0x56869)
      return NearRet();
    }
    // DEC byte ptr [0x13a] (563E_046E / 0x5684E)
    UInt8[DS, 0x13A] = Alu.Dec8(UInt8[DS, 0x13A]);
    // JZ 0x5000:686a (563E_0472 / 0x56852)
    if(ZeroFlag) {
      goto label_563E_048A_5686A;
    }
    // JNS 0x5000:685a (563E_0474 / 0x56854)
    if(!SignFlag) {
      goto label_563E_047A_5685A;
    }
    // INC byte ptr [0x13a] (563E_0476 / 0x56856)
    UInt8[DS, 0x13A] = Alu.Inc8(UInt8[DS, 0x13A]);
    label_563E_047A_5685A:
    // CALL 0x5000:66c0 (563E_047A / 0x5685A)
    NearCall(cs4, 0x47D, not_observed_563E_02E0_0566C0);
    // LES BX,[0x115] (563E_047D / 0x5685D)
    ES = UInt16[DS, 0x117];
    BX = UInt16[DS, 0x115];
    // MOV DI,0x142 (563E_0481 / 0x56861)
    DI = 0x142;
    // CALL 0x5000:67a7 (563E_0484 / 0x56864)
    NearCall(cs4, 0x487, spice86_generated_label_call_target_563E_03C7_0567A7);
    // DEC word ptr [DI] (563E_0487 / 0x56867)
    UInt16[DS, DI] = Alu.Dec16(UInt16[DS, DI]);
    label_563E_0489_56869:
    // RET  (563E_0489 / 0x56869)
    return NearRet();
    label_563E_048A_5686A:
    // MOV AX,0xffff (563E_048A / 0x5686A)
    AX = 0xFFFF;
    // PUSH ES (563E_048D / 0x5686D)
    Stack.Push(ES);
    // PUSH DS (563E_048E / 0x5686E)
    Stack.Push(DS);
    // POP ES (563E_048F / 0x5686F)
    ES = Stack.Pop();
    // MOV CX,0x9 (563E_0490 / 0x56870)
    CX = 0x9;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (563E_0493 / 0x56873)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // POP ES (563E_0495 / 0x56875)
    ES = Stack.Pop();
    // PUSH CS (563E_0496 / 0x56876)
    Stack.Push(cs4);
    // CALL 0x5000:65c1 (563E_0497 / 0x56877)
    NearCall(cs4, 0x49A, not_observed_563E_01E1_0565C1);
    // RET  (563E_049A / 0x5687A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_049B_05687B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_049B_5687B:
    // PUSH AX (563E_049B / 0x5687B)
    Stack.Push(AX);
    // PUSH CX (563E_049C / 0x5687C)
    Stack.Push(CX);
    // XOR AX,AX (563E_049D / 0x5687D)
    AX = 0;
    // LODSB ES:SI (563E_049F / 0x5687F)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (563E_04A1 / 0x56881)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x5000:68af (563E_04A3 / 0x56883)
    if(!SignFlag) {
      goto label_563E_04CF_568AF;
    }
    // XOR CX,CX (563E_04A5 / 0x56885)
    CX = 0;
    label_563E_04A7_56887:
    // MOV CH,CL (563E_04A7 / 0x56887)
    CH = CL;
    // MOV CL,AH (563E_04A9 / 0x56889)
    CL = AH;
    // MOV AH,AL (563E_04AB / 0x5688B)
    AH = AL;
    // LODSB ES:SI (563E_04AD / 0x5688D)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (563E_04AF / 0x5688F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JS 0x5000:6887 (563E_04B1 / 0x56891)
    if(SignFlag) {
      goto label_563E_04A7_56887;
    }
    // AND AX,0x7f7f (563E_04B3 / 0x56893)
    AX &= 0x7F7F;
    // AND CX,0x7f7f (563E_04B6 / 0x56896)
    CX &= 0x7F7F;
    // SHL CL,1 (563E_04BA / 0x5689A)
    CL <<= 0x1;
    // SHR CX,1 (563E_04BC / 0x5689C)
    CX >>= 0x1;
    // SHL AL,1 (563E_04BE / 0x5689E)
    AL <<= 0x1;
    // SHL AX,1 (563E_04C0 / 0x568A0)
    AX <<= 0x1;
    // SHR CX,1 (563E_04C2 / 0x568A2)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // RCR AX,1 (563E_04C4 / 0x568A4)
    AX = Alu.Rcr16(AX, 0x1);
    // SHR CX,1 (563E_04C6 / 0x568A6)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // RCR AX,1 (563E_04C8 / 0x568A8)
    AX = Alu.Rcr16(AX, 0x1);
    // JCXZ 0x5000:68af (563E_04CA / 0x568AA)
    if(CX == 0) {
      goto label_563E_04CF_568AF;
    }
    // MOV AX,0xffff (563E_04CC / 0x568AC)
    AX = 0xFFFF;
    label_563E_04CF_568AF:
    // MOV word ptr [DI],AX (563E_04CF / 0x568AF)
    UInt16[DS, DI] = AX;
    // MOV word ptr [DI + 0x12],SI (563E_04D1 / 0x568B1)
    UInt16[DS, (ushort)(DI + 0x12)] = SI;
    // POP CX (563E_04D4 / 0x568B4)
    CX = Stack.Pop();
    // POP AX (563E_04D5 / 0x568B5)
    AX = Stack.Pop();
    // RET  (563E_04D6 / 0x568B6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_04D7_0568B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_04D7_568B7:
    // MOV AL,[0x13d] (563E_04D7 / 0x568B7)
    AL = UInt8[DS, 0x13D];
    // SUB AL,byte ptr [0x13e] (563E_04DA / 0x568BA)
    // AL -= UInt8[DS, 0x13E];
    AL = Alu.Sub8(AL, UInt8[DS, 0x13E]);
    // JNZ 0x5000:68cc (563E_04DE / 0x568BE)
    if(!ZeroFlag) {
      goto label_563E_04EC_568CC;
    }
    // MOV word ptr [0x13b],0x1 (563E_04E0 / 0x568C0)
    UInt16[DS, 0x13B] = 0x1;
    // AND byte ptr [0x139],0xbf (563E_04E6 / 0x568C6)
    // UInt8[DS, 0x139] &= 0xBF;
    UInt8[DS, 0x139] = Alu.And8(UInt8[DS, 0x139], 0xBF);
    // RET  (563E_04EB / 0x568CB)
    return NearRet();
    label_563E_04EC_568CC:
    // PUSH DX (563E_04EC / 0x568CC)
    Stack.Push(DX);
    // PUSH SI (563E_04ED / 0x568CD)
    Stack.Push(SI);
    // PUSH DI (563E_04EE / 0x568CE)
    Stack.Push(DI);
    // PUSH BP (563E_04EF / 0x568CF)
    Stack.Push(BP);
    // PUSH ES (563E_04F0 / 0x568D0)
    Stack.Push(ES);
    // JC 0x5000:68db (563E_04F1 / 0x568D1)
    if(CarryFlag) {
      goto label_563E_04FB_568DB;
    }
    // CMP AL,0x3 (563E_04F3 / 0x568D3)
    Alu.Sub8(AL, 0x3);
    // JC 0x5000:68e1 (563E_04F5 / 0x568D5)
    if(CarryFlag) {
      goto label_563E_0501_568E1;
    }
    // MOV AL,0x3 (563E_04F7 / 0x568D7)
    AL = 0x3;
    // JMP 0x5000:68e1 (563E_04F9 / 0x568D9)
    goto label_563E_0501_568E1;
    label_563E_04FB_568DB:
    // CMP AL,0xfd (563E_04FB / 0x568DB)
    Alu.Sub8(AL, 0xFD);
    // JNC 0x5000:68e1 (563E_04FD / 0x568DD)
    if(!CarryFlag) {
      goto label_563E_0501_568E1;
    }
    // MOV AL,0xfd (563E_04FF / 0x568DF)
    AL = 0xFD;
    label_563E_0501_568E1:
    // SUB byte ptr [0x13d],AL (563E_0501 / 0x568E1)
    // UInt8[DS, 0x13D] -= AL;
    UInt8[DS, 0x13D] = Alu.Sub8(UInt8[DS, 0x13D], AL);
    // MOV BL,byte ptr [0x13d] (563E_0505 / 0x568E5)
    BL = UInt8[DS, 0x13D];
    // MOV SI,0x19c (563E_0509 / 0x568E9)
    SI = 0x19C;
    // MOV DX,0x7b0 (563E_050C / 0x568EC)
    DX = 0x7B0;
    label_563E_050F_568EF:
    // LODSB SI (563E_050F / 0x568EF)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MUL BL (563E_0510 / 0x568F0)
    Cpu.Mul8(BL);
    // MOV CL,AH (563E_0512 / 0x568F2)
    CL = AH;
    // MOV AX,DX (563E_0514 / 0x568F4)
    AX = DX;
    // CALL 0x5000:6986 (563E_0516 / 0x568F6)
    NearCall(cs4, 0x519, spice86_generated_label_call_target_563E_05A6_056986);
    label_563E_0519_568F9:
    // INC DX (563E_0519 / 0x568F9)
    DX++;
    // CMP DL,0xba (563E_051A / 0x568FA)
    Alu.Sub8(DL, 0xBA);
    // JC 0x5000:68ef (563E_051D / 0x568FD)
    if(CarryFlag) {
      goto label_563E_050F_568EF;
    }
    // OR BL,BL (563E_051F / 0x568FF)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    // JNZ 0x5000:6909 (563E_0521 / 0x56901)
    if(!ZeroFlag) {
      goto label_563E_0529_56909;
    }
    // MOV byte ptr CS:[0x139],0x0 (563E_0523 / 0x56903)
    UInt8[cs4, 0x139] = 0x0;
    label_563E_0529_56909:
    // POP ES (563E_0529 / 0x56909)
    ES = Stack.Pop();
    // POP BP (563E_052A / 0x5690A)
    BP = Stack.Pop();
    // POP DI (563E_052B / 0x5690B)
    DI = Stack.Pop();
    // POP SI (563E_052C / 0x5690C)
    SI = Stack.Pop();
    // POP DX (563E_052D / 0x5690D)
    DX = Stack.Pop();
    // RET  (563E_052E / 0x5690E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_052F_05690F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_052F_5690F:
    // MOV word ptr CS:[0x127],0x50 (563E_052F / 0x5690F)
    UInt16[cs4, 0x127] = 0x50;
    // XOR DX,DX (563E_0536 / 0x56916)
    DX = 0;
    label_563E_0538_56918:
    // MOV AX,0x7bb0 (563E_0538 / 0x56918)
    AX = 0x7BB0;
    // OR AL,DL (563E_053B / 0x5691B)
    AL |= DL;
    // XOR CL,CL (563E_053D / 0x5691D)
    CL = 0;
    // CALL 0x5000:6986 (563E_053F / 0x5691F)
    NearCall(cs4, 0x542, spice86_generated_label_call_target_563E_05A6_056986);
    label_563E_0542_56922:
    // MOV AX,0xe0 (563E_0542 / 0x56922)
    AX = 0xE0;
    // OR AL,DL (563E_0545 / 0x56925)
    // AL |= DL;
    AL = Alu.Or8(AL, DL);
    // MOV CL,0x40 (563E_0547 / 0x56927)
    CL = 0x40;
    // CALL 0x5000:6986 (563E_0549 / 0x56929)
    NearCall(cs4, 0x54C, spice86_generated_label_call_target_563E_05A6_056986);
    label_563E_054C_5692C:
    // INC DX (563E_054C / 0x5692C)
    DX++;
    // CMP DX,0xa (563E_054D / 0x5692D)
    Alu.Sub16(DX, 0xA);
    // JC 0x5000:6918 (563E_0550 / 0x56930)
    if(CarryFlag) {
      goto label_563E_0538_56918;
    }
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
    label_563E_0559_56939:
    // MOV BL,0xff (563E_0559 / 0x56939)
    BL = 0xFF;
    // CALL 0x5000:6944 (563E_055B / 0x5693B)
    NearCall(cs4, 0x55E, spice86_generated_label_call_target_563E_0564_056944);
    label_563E_055E_5693E:
    // MOV BL,0x3f (563E_055E / 0x5693E)
    BL = 0x3F;
    // CALL 0x5000:6944 (563E_0560 / 0x56940)
    NearCall(cs4, 0x563, spice86_generated_label_call_target_563E_0564_056944);
    label_563E_0563_56943:
    // RET  (563E_0563 / 0x56943)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_0564_056944(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0564_56944:
    // PUSH CX (563E_0564 / 0x56944)
    Stack.Push(CX);
    // PUSH DX (563E_0565 / 0x56945)
    Stack.Push(DX);
    // PUSHF  (563E_0566 / 0x56946)
    Stack.Push(FlagRegister);
    // CLI  (563E_0567 / 0x56947)
    InterruptFlag = false;
    // MOV DX,word ptr CS:[0x125] (563E_0568 / 0x56948)
    DX = UInt16[cs4, 0x125];
    // INC DX (563E_056D / 0x5694D)
    DX++;
    // XOR CX,CX (563E_056E / 0x5694E)
    CX = 0;
    label_563E_0570_56950:
    // IN AL,DX (563E_0570 / 0x56950)
    AL = Cpu.In8(DX);
    // TEST AL,0x40 (563E_0571 / 0x56951)
    Alu.And8(AL, 0x40);
    // LOOPNZ 0x5000:6950 (563E_0573 / 0x56953)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_0570_56950;
    }
    // MOV AL,BL (563E_0575 / 0x56955)
    AL = BL;
    // OUT DX,AL (563E_0577 / 0x56957)
    Cpu.Out8(DX, AL);
    // MOV CX,0x64 (563E_0578 / 0x56958)
    CX = 0x64;
    label_563E_057B_5695B:
    // IN AL,DX (563E_057B / 0x5695B)
    AL = Cpu.In8(DX);
    // TEST AL,0x80 (563E_057C / 0x5695C)
    Alu.And8(AL, 0x80);
    // LOOPNZ 0x5000:695b (563E_057E / 0x5695E)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_057B_5695B;
    }
    // INC CX (563E_0580 / 0x56960)
    CX++;
    // DEC DX (563E_0581 / 0x56961)
    DX = Alu.Dec16(DX);
    // IN AL,DX (563E_0582 / 0x56962)
    AL = Cpu.In8(DX);
    // INC DX (563E_0583 / 0x56963)
    DX++;
    // CMP AL,0xfe (563E_0584 / 0x56964)
    Alu.Sub8(AL, 0xFE);
    // LOOPNZ 0x5000:695b (563E_0586 / 0x56966)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_057B_5695B;
    }
    // MOV CX,0x4e20 (563E_0588 / 0x56968)
    CX = 0x4E20;
    label_563E_058B_5696B:
    // IN AL,DX (563E_058B / 0x5696B)
    AL = Cpu.In8(DX);
    // LOOP 0x5000:696b (563E_058C / 0x5696C)
    if(--CX != 0) {
      goto label_563E_058B_5696B;
    }
    // POPF  (563E_058E / 0x5696E)
    FlagRegister = Stack.Pop();
    // POP DX (563E_058F / 0x5696F)
    DX = Stack.Pop();
    // POP CX (563E_0590 / 0x56970)
    CX = Stack.Pop();
    // RET  (563E_0591 / 0x56971)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_563E_0592_056972(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_0592_56972:
    // PUSH BX (563E_0592 / 0x56972)
    Stack.Push(BX);
    // PUSH CX (563E_0593 / 0x56973)
    Stack.Push(CX);
    // PUSH DX (563E_0594 / 0x56974)
    Stack.Push(DX);
    // PUSHF  (563E_0595 / 0x56975)
    Stack.Push(FlagRegister);
    // MOV BX,AX (563E_0596 / 0x56976)
    BX = AX;
    // CLI  (563E_0598 / 0x56978)
    InterruptFlag = false;
    // CALL 0x5000:699f (563E_0599 / 0x56979)
    NearCall(cs4, 0x59C, spice86_generated_label_call_target_563E_05BF_05699F);
    label_563E_059C_5697C:
    // MOV BL,BH (563E_059C / 0x5697C)
    BL = BH;
    // CALL 0x5000:699f (563E_059E / 0x5697E)
    NearCall(cs4, 0x5A1, spice86_generated_label_call_target_563E_05BF_05699F);
    label_563E_05A1_56981:
    // POPF  (563E_05A1 / 0x56981)
    FlagRegister = Stack.Pop();
    // POP DX (563E_05A2 / 0x56982)
    DX = Stack.Pop();
    // POP CX (563E_05A3 / 0x56983)
    CX = Stack.Pop();
    // POP BX (563E_05A4 / 0x56984)
    BX = Stack.Pop();
    // RET  (563E_05A5 / 0x56985)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_563E_05A6_056986(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_563E_05A6_56986:
    // PUSH BX (563E_05A6 / 0x56986)
    Stack.Push(BX);
    // PUSH CX (563E_05A7 / 0x56987)
    Stack.Push(CX);
    // PUSH DX (563E_05A8 / 0x56988)
    Stack.Push(DX);
    // PUSHF  (563E_05A9 / 0x56989)
    Stack.Push(FlagRegister);
    // MOV BX,AX (563E_05AA / 0x5698A)
    BX = AX;
    // PUSH CX (563E_05AC / 0x5698C)
    Stack.Push(CX);
    // CLI  (563E_05AD / 0x5698D)
    InterruptFlag = false;
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
    label_563E_05B1_56991:
    // MOV BL,BH (563E_05B1 / 0x56991)
    BL = BH;
    // CALL 0x5000:699f (563E_05B3 / 0x56993)
    NearCall(cs4, 0x5B6, spice86_generated_label_call_target_563E_05BF_05699F);
    label_563E_05B6_56996:
    // POP BX (563E_05B6 / 0x56996)
    BX = Stack.Pop();
    // CALL 0x5000:699f (563E_05B7 / 0x56997)
    NearCall(cs4, 0x5BA, spice86_generated_label_call_target_563E_05BF_05699F);
    label_563E_05BA_5699A:
    // POPF  (563E_05BA / 0x5699A)
    FlagRegister = Stack.Pop();
    // POP DX (563E_05BB / 0x5699B)
    DX = Stack.Pop();
    // POP CX (563E_05BC / 0x5699C)
    CX = Stack.Pop();
    // POP BX (563E_05BD / 0x5699D)
    BX = Stack.Pop();
    // RET  (563E_05BE / 0x5699E)
    return NearRet();
    entry:
    label_563E_05BF_5699F:
    // MOV DX,word ptr CS:[0x125] (563E_05BF / 0x5699F)
    DX = UInt16[cs4, 0x125];
    // INC DX (563E_05C4 / 0x569A4)
    DX = Alu.Inc16(DX);
    // MOV CX,0xff (563E_05C5 / 0x569A5)
    CX = 0xFF;
    label_563E_05C8_569A8:
    // IN AL,DX (563E_05C8 / 0x569A8)
    AL = Cpu.In8(DX);
    // TEST AL,0x40 (563E_05C9 / 0x569A9)
    Alu.And8(AL, 0x40);
    // LOOPNZ 0x5000:69a8 (563E_05CB / 0x569AB)
    if(--CX != 0 && !ZeroFlag) {
      goto label_563E_05C8_569A8;
    }
    // DEC DX (563E_05CD / 0x569AD)
    DX = Alu.Dec16(DX);
    // MOV AL,BL (563E_05CE / 0x569AE)
    AL = BL;
    // OUT DX,AL (563E_05D0 / 0x569B0)
    Cpu.Out8(DX, AL);
    // INC DX (563E_05D1 / 0x569B1)
    DX = Alu.Inc16(DX);
    // MOV CX,word ptr CS:[0x127] (563E_05D2 / 0x569B2)
    CX = UInt16[cs4, 0x127];
    label_563E_05D7_569B7:
    // IN AL,DX (563E_05D7 / 0x569B7)
    AL = Cpu.In8(DX);
    // LOOP 0x5000:69b7 (563E_05D8 / 0x569B8)
    if(--CX != 0) {
      goto label_563E_05D7_569B7;
    }
    // RET  (563E_05DA / 0x569BA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_F000_0000_0F0000(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0000_F0000:
    // NOP  (F000_0000 / 0xF0000)
    
    // INT 0x8 (F000_0001 / 0xF0001)
    Interrupt(0x8);
    // IRET  (F000_0003 / 0xF0003)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x9_F000_0004_F0004(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0004_F0004:
    // NOP  (F000_0004 / 0xF0004)
    
    // INT 0x9 (F000_0005 / 0xF0005)
    Interrupt(0x9);
    // IRET  (F000_0007 / 0xF0007)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x10_F000_0008_F0008(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0008_F0008:
    // NOP  (F000_0008 / 0xF0008)
    
    // INT 0x10 (F000_0009 / 0xF0009)
    Interrupt(0x10);
    // IRET  (F000_000B / 0xF000B)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x11_F000_000C_F000C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_000C_F000C:
    // NOP  (F000_000C / 0xF000C)
    
    // INT 0x11 (F000_000D / 0xF000D)
    Interrupt(0x11);
    // IRET  (F000_000F / 0xF000F)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x15_F000_0010_F0010(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0010_F0010:
    // NOP  (F000_0010 / 0xF0010)
    
    // INT 0x15 (F000_0011 / 0xF0011)
    Interrupt(0x15);
    // IRET  (F000_0013 / 0xF0013)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x16_F000_0014_F0014(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0014_F0014:
    // NOP  (F000_0014 / 0xF0014)
    
    // INT 0x16 (F000_0015 / 0xF0015)
    Interrupt(0x16);
    // IRET  (F000_0017 / 0xF0017)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x1A_F000_0018_F0018(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0018_F0018:
    // NOP  (F000_0018 / 0xF0018)
    
    // INT 0x1a (F000_0019 / 0xF0019)
    Interrupt(0x1a);
    // IRET  (F000_001B / 0xF001B)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x20_F000_001C_F001C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_001C_F001C:
    // NOP  (F000_001C / 0xF001C)
    
    // INT 0x20 (F000_001D / 0xF001D)
    Interrupt(0x20);
    // IRET  (F000_001F / 0xF001F)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x21_F000_0020_F0020(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0020_F0020:
    // NOP  (F000_0020 / 0xF0020)
    
    // INT 0x21 (F000_0021 / 0xF0021)
    Interrupt(0x21);
    // IRET  (F000_0023 / 0xF0023)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_0x33_F000_0024_F0024(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0024_F0024:
    // NOP  (F000_0024 / 0xF0024)
    
    // INT 0x33 (F000_0025 / 0xF0025)
    Interrupt(0x33);
    // IRET  (F000_0027 / 0xF0027)
    return InterruptRet();
  }
  
}
