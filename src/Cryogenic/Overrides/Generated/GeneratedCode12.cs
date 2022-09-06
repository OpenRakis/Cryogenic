namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_9197_019197(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9197_19197:
    // MOV AX,[0x47c4] (1000_9197 / 0x19197)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AX,0xffff (1000_919A / 0x1919A)
    Alu.Sub16(AX, 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:91a0 (1000_919D / 0x1919D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_91A0_0191A0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_919F / 0x1919F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_91A0_0191A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_91A0_191A0:
    // MOV word ptr [0xf0],0x0 (1000_91A0 / 0x191A0)
    UInt16[DS, 0xF0] = 0x0;
    State.IncCycles();
    // CMP AX,0xc (1000_91A6 / 0x191A6)
    Alu.Sub16(AX, 0xC);
    State.IncCycles();
    // JNZ 0x1000:91b8 (1000_91A9 / 0x191A9)
    if(!ZeroFlag) {
      goto label_1000_91B8_191B8;
    }
    State.IncCycles();
    // TEST byte ptr [0x10a7],0x10 (1000_91AB / 0x191AB)
    Alu.And8(UInt8[DS, 0x10A7], 0x10);
    State.IncCycles();
    // JZ 0x1000:91b8 (1000_91B0 / 0x191B0)
    if(ZeroFlag) {
      goto label_1000_91B8_191B8;
    }
    State.IncCycles();
    // MOV word ptr [0xf0],0xa (1000_91B2 / 0x191B2)
    UInt16[DS, 0xF0] = 0xA;
    State.IncCycles();
    label_1000_91B8_191B8:
    // CALL 0x1000:9123 (1000_91B8 / 0x191B8)
    NearCall(cs1, 0x91BB, spice86_generated_label_call_target_1000_9123_019123);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_91BB_0191BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_91BB_0191BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_91BB_191BB:
    // CMP AX,word ptr [0x22a6] (1000_91BB / 0x191BB)
    Alu.Sub16(AX, UInt16[DS, 0x22A6]);
    State.IncCycles();
    // JZ 0x1000:920f (1000_91BF / 0x191BF)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_920F_01920F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH AX (1000_91C1 / 0x191C1)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:98b2 (1000_91C2 / 0x191C2)
    NearCall(cs1, 0x91C5, spice86_generated_label_call_target_1000_98B2_0198B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_91C5_0191C5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_91C5_0191C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_91C5_191C5:
    // POP AX (1000_91C5 / 0x191C5)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x22a6],AX (1000_91C6 / 0x191C6)
    UInt16[DS, 0x22A6] = AX;
    State.IncCycles();
    // MOV SI,AX (1000_91C9 / 0x191C9)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:920f (1000_91CB / 0x191CB)
    NearCall(cs1, 0x91CE, spice86_generated_label_call_target_1000_920F_01920F);
    State.IncCycles();
    label_1000_91CE_191CE:
    // MOV AL,byte ptr [SI + 0x22a8] (1000_91CE / 0x191CE)
    AL = UInt8[DS, (ushort)(SI + 0x22A8)];
    State.IncCycles();
    // XOR AH,AH (1000_91D2 / 0x191D2)
    AH = 0;
    State.IncCycles();
    // MOV [0x2224],AX (1000_91D4 / 0x191D4)
    UInt16[DS, 0x2224] = AX;
    State.IncCycles();
    // MOV [0x222c],AX (1000_91D7 / 0x191D7)
    UInt16[DS, 0x222C] = AX;
    State.IncCycles();
    // MOV [0x2234],AX (1000_91DA / 0x191DA)
    UInt16[DS, 0x2234] = AX;
    State.IncCycles();
    // PUSH DS (1000_91DD / 0x191DD)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH DS (1000_91DE / 0x191DE)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_91DF / 0x191DF)
    ES = Stack.Pop();
    State.IncCycles();
    // LDS SI,[0xdbb0] (1000_91E0 / 0x191E0)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // MOV BX,word ptr [SI] (1000_91E4 / 0x191E4)
    BX = UInt16[DS, SI];
    State.IncCycles();
    // ADD SI,word ptr [BX + SI + -0x2] (1000_91E6 / 0x191E6)
    SI += UInt16[DS, (ushort)(BX + SI - 0x2)];
    State.IncCycles();
    // ADD SI,0x4 (1000_91E9 / 0x191E9)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // MOV DI,0x1bf0 (1000_91EC / 0x191EC)
    DI = 0x1BF0;
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_91EF / 0x191EF)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_91F0 / 0x191F0)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_91F1 / 0x191F1)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_91F2 / 0x191F2)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,SI (1000_91F3 / 0x191F3)
    AX = SI;
    State.IncCycles();
    // ADD AX,0x2 (1000_91F5 / 0x191F5)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    // MOV SS:[0x47cc],AX (1000_91F8 / 0x191F8)
    UInt16[SS, 0x47CC] = AX;
    State.IncCycles();
    // ADD SI,word ptr [SI] (1000_91FC / 0x191FC)
    // SI += UInt16[DS, SI];
    SI = Alu.Add16(SI, UInt16[DS, SI]);
    State.IncCycles();
    // MOV BX,word ptr [SI] (1000_91FE / 0x191FE)
    BX = UInt16[DS, SI];
    State.IncCycles();
    // MOV DI,SI (1000_9200 / 0x19200)
    DI = SI;
    State.IncCycles();
    // ADD DI,word ptr [BX + SI + -0x2] (1000_9202 / 0x19202)
    // DI += UInt16[DS, (ushort)(BX + SI - 0x2)];
    DI = Alu.Add16(DI, UInt16[DS, (ushort)(BX + SI - 0x2)]);
    State.IncCycles();
    // POP DS (1000_9205 / 0x19205)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0x47ca],SI (1000_9206 / 0x19206)
    UInt16[DS, 0x47CA] = SI;
    State.IncCycles();
    // MOV word ptr [0x47d2],DI (1000_920A / 0x1920A)
    UInt16[DS, 0x47D2] = DI;
    State.IncCycles();
    // RET  (1000_920E / 0x1920E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_920F_01920F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_920F_1920F:
    // ADD AX,0x2 (1000_920F / 0x1920F)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    // JMP 0x1000:c13e (1000_9212 / 0x19212)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9215_019215(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9281: goto label_1000_9281_19281;break; // Target of external jump from 0x19251, 0x192E3, 0x192D2, 0x19268, 0x192DA, 0x1924C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9215_19215:
    // CALL 0x1000:d41b (1000_9215 / 0x19215)
    NearCall(cs1, 0x9218, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    label_1000_9218_19218:
    // CMP BP,0x1f0e (1000_9218 / 0x19218)
    Alu.Sub16(BP, 0x1F0E);
    State.IncCycles();
    // JNZ 0x1000:9248 (1000_921C / 0x1921C)
    if(!ZeroFlag) {
      goto label_1000_9248_19248;
    }
    State.IncCycles();
    // CMP byte ptr [0x11c9],0x0 (1000_921E / 0x1921E)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9281 (1000_9223 / 0x19223)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:9285 (1000_9225 / 0x19225)
    NearCall(cs1, 0x9228, spice86_generated_label_call_target_1000_9285_019285);
    State.IncCycles();
    label_1000_9228_19228:
    // JNC 0x1000:9263 (1000_9228 / 0x19228)
    if(!CarryFlag) {
      goto label_1000_9263_19263;
    }
    State.IncCycles();
    // CMP CL,0x2f (1000_922A / 0x1922A)
    Alu.Sub8(CL, 0x2F);
    State.IncCycles();
    // JZ 0x1000:9282 (1000_922D / 0x1922D)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:42e9 (1000_9282 / 0x19282)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_42E9_0142E9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP CL,0xf (1000_922F / 0x1922F)
    Alu.Sub8(CL, 0xF);
    State.IncCycles();
    // JNC 0x1000:9240 (1000_9232 / 0x19232)
    if(!CarryFlag) {
      goto label_1000_9240_19240;
    }
    State.IncCycles();
    label_1000_9234_19234:
    // MOV AL,0x10 (1000_9234 / 0x19234)
    AL = 0x10;
    State.IncCycles();
    // MUL CL (1000_9236 / 0x19236)
    Cpu.Mul8(CL);
    State.IncCycles();
    // ADD AX,0xfd8 (1000_9238 / 0x19238)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    State.IncCycles();
    // MOV SI,AX (1000_923B / 0x1923B)
    SI = AX;
    State.IncCycles();
    // JMP word ptr [SI + 0x4] (1000_923D / 0x1923D)
    // Indirect jump to word ptr [SI + 0x4], generating possible targets from emulator records
    uint targetAddress_1000_923D = (uint)(UInt16[DS, (ushort)(SI + 0x4)]);
    switch(targetAddress_1000_923D) {
      case 0x92F2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_92F2_0192F2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9373 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9373_019373, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9306 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9306_019306, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9301 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9301_019301, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x92F7 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_92F7_0192F7, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_923D));
        break;
    }
    State.IncCycles();
    label_1000_9240_19240:
    // SUB CL,0xf (1000_9240 / 0x19240)
    // CL -= 0xF;
    CL = Alu.Sub8(CL, 0xF);
    State.IncCycles();
    // MOV AL,CL (1000_9243 / 0x19243)
    AL = CL;
    State.IncCycles();
    // JMP 0x1000:9381 (1000_9245 / 0x19245)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9381_019381, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9248_19248:
    // CMP BP,0x1f7e (1000_9248 / 0x19248)
    Alu.Sub16(BP, 0x1F7E);
    State.IncCycles();
    // JNZ 0x1000:9281 (1000_924C / 0x1924C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:92c9 (1000_924E / 0x1924E)
    NearCall(cs1, 0x9251, spice86_generated_label_call_target_1000_92C9_0192C9);
    State.IncCycles();
    label_1000_9251_19251:
    // JNC 0x1000:9281 (1000_9251 / 0x19251)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // CMP CX,word ptr [0x47c4] (1000_9253 / 0x19253)
    Alu.Sub16(CX, UInt16[DS, 0x47C4]);
    State.IncCycles();
    // JNZ 0x1000:925c (1000_9257 / 0x19257)
    if(!ZeroFlag) {
      goto label_1000_925C_1925C;
    }
    State.IncCycles();
    // JMP 0x1000:945b (1000_9259 / 0x19259)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_945B_01945B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_925C_1925C:
    // PUSH CX (1000_925C / 0x1925C)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:d2bd (1000_925D / 0x1925D)
    NearCall(cs1, 0x9260, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    State.IncCycles();
    // POP CX (1000_9260 / 0x19260)
    CX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:9234 (1000_9261 / 0x19261)
    goto label_1000_9234_19234;
    State.IncCycles();
    label_1000_9263_19263:
    // CMP byte ptr [0xb],0x1 (1000_9263 / 0x19263)
    Alu.Sub8(UInt8[DS, 0xB], 0x1);
    State.IncCycles();
    // JNZ 0x1000:9281 (1000_9268 / 0x19268)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // CMP BX,0x98 (1000_926A / 0x1926A)
    Alu.Sub16(BX, 0x98);
    State.IncCycles();
    // JNC 0x1000:9281 (1000_926E / 0x1926E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x8],0x21 (1000_9270 / 0x19270)
    Alu.Sub8(UInt8[DS, 0x8], 0x21);
    State.IncCycles();
    // JZ 0x1000:9281 (1000_9275 / 0x19275)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x2b],0x0 (1000_9277 / 0x19277)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9281 (1000_927C / 0x1927C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:3f15 (1000_927E / 0x1927E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3F15_013F15, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9281_19281:
    // RET  (1000_9281 / 0x19281)
    return NearRet();
    State.IncCycles();
    label_1000_9282_19282:
    // JMP 0x1000:42e9 (1000_9282 / 0x19282)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_42E9_0142E9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9285_019285(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9285_19285:
    // CMP BX,0x98 (1000_9285 / 0x19285)
    Alu.Sub16(BX, 0x98);
    State.IncCycles();
    // JNC 0x1000:92c9 (1000_9289 / 0x19289)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_92C9_0192C9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x47f8 (1000_928B / 0x1928B)
    SI = 0x47F8;
    State.IncCycles();
    // MOV CX,0x17 (1000_928E / 0x1928E)
    CX = 0x17;
    State.IncCycles();
    label_1000_9291_19291:
    // LODSW SI (1000_9291 / 0x19291)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_9292 / 0x19292)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_9294 / 0x19294)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BP,AX (1000_9295 / 0x19295)
    BP = AX;
    State.IncCycles();
    // OR DI,DI (1000_9297 / 0x19297)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JS 0x1000:92a9 (1000_9299 / 0x19299)
    if(SignFlag) {
      goto label_1000_92A9_192A9;
    }
    State.IncCycles();
    // SUB DI,DX (1000_929B / 0x1929B)
    DI -= DX;
    State.IncCycles();
    // CMP DI,-0x20 (1000_929D / 0x1929D)
    Alu.Sub16(DI, 0xFFE0);
    State.IncCycles();
    // JC 0x1000:92a9 (1000_92A0 / 0x192A0)
    if(CarryFlag) {
      goto label_1000_92A9_192A9;
    }
    State.IncCycles();
    // SUB BP,BX (1000_92A2 / 0x192A2)
    BP -= BX;
    State.IncCycles();
    // CMP BP,-0x50 (1000_92A4 / 0x192A4)
    Alu.Sub16(BP, 0xFFB0);
    State.IncCycles();
    // JNC 0x1000:92eb (1000_92A7 / 0x192A7)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_92EB_0192EB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_92A9_192A9:
    // LOOP 0x1000:9291 (1000_92A9 / 0x192A9)
    if(--CX != 0) {
      goto label_1000_9291_19291;
    }
    State.IncCycles();
    // MOV AX,[0x472d] (1000_92AB / 0x192AB)
    AX = UInt16[DS, 0x472D];
    State.IncCycles();
    // OR AX,AX (1000_92AE / 0x192AE)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:92c8 (1000_92B0 / 0x192B0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_92C8 / 0x192C8)
      return NearRet();
    }
    State.IncCycles();
    // SUB AX,DX (1000_92B2 / 0x192B2)
    AX -= DX;
    State.IncCycles();
    // CMP AX,0xffb2 (1000_92B4 / 0x192B4)
    Alu.Sub16(AX, 0xFFB2);
    State.IncCycles();
    // CMC  (1000_92B7 / 0x192B7)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // JNC 0x1000:92c8 (1000_92B8 / 0x192B8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_92C8 / 0x192C8)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,BX (1000_92BA / 0x192BA)
    AX = BX;
    State.IncCycles();
    // SUB AX,word ptr [0x472f] (1000_92BC / 0x192BC)
    AX -= UInt16[DS, 0x472F];
    State.IncCycles();
    // CMP AX,0x3c (1000_92C0 / 0x192C0)
    Alu.Sub16(AX, 0x3C);
    State.IncCycles();
    // JNC 0x1000:92c8 (1000_92C3 / 0x192C3)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_92C8 / 0x192C8)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0x2f (1000_92C5 / 0x192C5)
    CX = 0x2F;
    State.IncCycles();
    label_1000_92C8_192C8:
    // RET  (1000_92C8 / 0x192C8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_92C9_0192C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_92C9_192C9:
    // XOR CX,CX (1000_92C9 / 0x192C9)
    CX = 0;
    State.IncCycles();
    // MOV CL,byte ptr [0x1152] (1000_92CB / 0x192CB)
    CL = UInt8[DS, 0x1152];
    State.IncCycles();
    // CMP CL,0xff (1000_92CF / 0x192CF)
    Alu.Sub8(CL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:9281 (1000_92D2 / 0x192D2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x1c0c (1000_92D4 / 0x192D4)
    DI = 0x1C0C;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_92D7 / 0x192D7)
    NearCall(cs1, 0x92DA, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_92DA_192DA:
    // JC 0x1000:9281 (1000_92DA / 0x192DA)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x1153] (1000_92DC / 0x192DC)
    CL = UInt8[DS, 0x1153];
    State.IncCycles();
    // CMP CL,0xff (1000_92E0 / 0x192E0)
    Alu.Sub8(CL, 0xFF);
    State.IncCycles();
    // JZ 0x1000:9281 (1000_92E3 / 0x192E3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9281 / 0x19281)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x1c1a (1000_92E5 / 0x192E5)
    DI = 0x1C1A;
    State.IncCycles();
    // JMP 0x1000:d6fe (1000_92E8 / 0x192E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D6FE_01D6FE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_92EB_0192EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_92EB_192EB:
    // SUB CX,0x17 (1000_92EB / 0x192EB)
    CX -= 0x17;
    State.IncCycles();
    // NEG CX (1000_92EE / 0x192EE)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // STC  (1000_92F0 / 0x192F0)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_92F1 / 0x192F1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_92F2_0192F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_92F2_192F2:
    // XOR AL,AL (1000_92F2 / 0x192F2)
    AL = 0;
    State.IncCycles();
    // JMP 0x1000:93aa (1000_92F4 / 0x192F4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_92F7_0192F7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_92F7_192F7:
    // MOV AL,0x1 (1000_92F7 / 0x192F7)
    AL = 0x1;
    State.IncCycles();
    // JMP 0x1000:93aa (1000_92F9 / 0x192F9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9301_019301(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9301_19301:
    // MOV AL,0x3 (1000_9301 / 0x19301)
    AL = 0x3;
    State.IncCycles();
    // JMP 0x1000:93aa (1000_9303 / 0x19303)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9306_019306(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9306_19306:
    // MOV AL,0x4 (1000_9306 / 0x19306)
    AL = 0x4;
    State.IncCycles();
    // JMP 0x1000:93aa (1000_9308 / 0x19308)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9373_019373(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9373_19373:
    // MOV SI,word ptr [0x4756] (1000_9373 / 0x19373)
    SI = UInt16[DS, 0x4756];
    State.IncCycles();
    // CALL 0x1000:31f6 (1000_9377 / 0x19377)
    NearCall(cs1, 0x937A, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_937A_01937A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_937A_01937A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_937A_1937A:
    // MOV AL,0xe (1000_937A / 0x1937A)
    AL = 0xE;
    State.IncCycles();
    // JMP 0x1000:93aa (1000_937C / 0x1937C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9381_019381(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9381_19381:
    // CMP AL,0x9 (1000_9381 / 0x19381)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JC 0x1000:9387 (1000_9383 / 0x19383)
    if(CarryFlag) {
      goto label_1000_9387_19387;
    }
    State.IncCycles();
    // XOR AX,AX (1000_9385 / 0x19385)
    AX = 0;
    State.IncCycles();
    label_1000_9387_19387:
    // CMP AL,0x8 (1000_9387 / 0x19387)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNZ 0x1000:9394 (1000_9389 / 0x19389)
    if(!ZeroFlag) {
      goto label_1000_9394_19394;
    }
    State.IncCycles();
    // MOV AL,[0x476b] (1000_938B / 0x1938B)
    AL = UInt8[DS, 0x476B];
    State.IncCycles();
    // DEC AL (1000_938E / 0x1938E)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNS 0x1000:9394 (1000_9390 / 0x19390)
    if(!SignFlag) {
      goto label_1000_9394_19394;
    }
    State.IncCycles();
    // XOR AX,AX (1000_9392 / 0x19392)
    AX = 0;
    State.IncCycles();
    label_1000_9394_19394:
    // MOV [0x476c],AL (1000_9394 / 0x19394)
    UInt8[DS, 0x476C] = AL;
    State.IncCycles();
    // MOV SI,0x4758 (1000_9397 / 0x19397)
    SI = 0x4758;
    State.IncCycles();
    // XOR AH,AH (1000_939A / 0x1939A)
    AH = 0;
    State.IncCycles();
    // ADD AX,AX (1000_939C / 0x1939C)
    AX += AX;
    State.IncCycles();
    // ADD SI,AX (1000_939E / 0x1939E)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV SI,word ptr [SI] (1000_93A0 / 0x193A0)
    SI = UInt16[DS, SI];
    State.IncCycles();
    // CALL 0x1000:1ebe (1000_93A2 / 0x193A2)
    NearCall(cs1, 0x93A5, spice86_generated_label_call_target_1000_1EBE_011EBE);
    State.IncCycles();
    label_1000_93A5_193A5:
    // CALL 0x1000:31f6 (1000_93A5 / 0x193A5)
    NearCall(cs1, 0x93A8, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_93A8_0193A8(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x93AA: goto label_1000_93AA_193AA;break; // Target of external jump from 0x19303, 0x192F4, 0x192F9, 0x19308, 0x1937C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_93A8_193A8:
    // MOV AL,0xf (1000_93A8 / 0x193A8)
    AL = 0xF;
    State.IncCycles();
    label_1000_93AA_193AA:
    // XOR AH,AH (1000_93AA / 0x193AA)
    AH = 0;
    State.IncCycles();
    // MOV word ptr [0x47e1],0x0 (1000_93AC / 0x193AC)
    UInt16[DS, 0x47E1] = 0x0;
    State.IncCycles();
    // PUSH AX (1000_93B2 / 0x193B2)
    Stack.Push(AX);
    State.IncCycles();
    // MOV [0x47c4],AX (1000_93B3 / 0x193B3)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // CALL 0x1000:91a0 (1000_93B6 / 0x193B6)
    NearCall(cs1, 0x93B9, spice86_generated_label_call_target_1000_91A0_0191A0);
    State.IncCycles();
    label_1000_93B9_193B9:
    // CALL 0x1000:3af9 (1000_93B9 / 0x193B9)
    NearCall(cs1, 0x93BC, spice86_generated_label_call_target_1000_3AF9_013AF9);
    State.IncCycles();
    label_1000_93BC_193BC:
    // CALL 0x1000:9197 (1000_93BC / 0x193BC)
    NearCall(cs1, 0x93BF, spice86_generated_label_call_target_1000_9197_019197);
    State.IncCycles();
    label_1000_93BF_193BF:
    // CALL 0x1000:9908 (1000_93BF / 0x193BF)
    NearCall(cs1, 0x93C2, spice86_generated_label_call_target_1000_9908_019908);
    State.IncCycles();
    label_1000_93C2_193C2:
    // MOV SI,word ptr [0x47c8] (1000_93C2 / 0x193C2)
    SI = UInt16[DS, 0x47C8];
    State.IncCycles();
    // MOV word ptr [0x4540],0x0 (1000_93C6 / 0x193C6)
    UInt16[DS, 0x4540] = 0x0;
    State.IncCycles();
    // CALL 0x1000:9bac (1000_93CC / 0x193CC)
    NearCall(cs1, 0x93CF, spice86_generated_label_call_target_1000_9BAC_019BAC);
    State.IncCycles();
    label_1000_93CF_193CF:
    // CALL 0x1000:1834 (1000_93CF / 0x193CF)
    NearCall(cs1, 0x93D2, spice86_generated_label_call_target_1000_1834_011834);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93D2_0193D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_93D2_0193D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_93D2_193D2:
    // CALL 0x1000:c0f4 (1000_93D2 / 0x193D2)
    NearCall(cs1, 0x93D5, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93D5_0193D5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_93D5_0193D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_93D5_193D5:
    // CALL 0x1000:c4dd (1000_93D5 / 0x193D5)
    NearCall(cs1, 0x93D8, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_93D8_193D8:
    // POP AX (1000_93D8 / 0x193D8)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:93df (1000_93D9 / 0x193D9)
    NearCall(cs1, 0x93DC, spice86_generated_label_call_target_1000_93DF_0193DF);
    State.IncCycles();
    label_1000_93DC_193DC:
    // JMP 0x1000:9472 (1000_93DC / 0x193DC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9472_019472, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_93DF_0193DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_93DF_193DF:
    // MOV CL,AL (1000_93DF / 0x193DF)
    CL = AL;
    State.IncCycles();
    // SHL AL,1 (1000_93E1 / 0x193E1)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_93E3 / 0x193E3)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_93E5 / 0x193E5)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // MOV [0x47be],AX (1000_93E7 / 0x193E7)
    UInt16[DS, 0x47BE] = AX;
    State.IncCycles();
    // MOV AX,0x1 (1000_93EA / 0x193EA)
    AX = 0x1;
    State.IncCycles();
    // SHL AX,CL (1000_93ED / 0x193ED)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    State.IncCycles();
    // OR word ptr [0xe],AX (1000_93EF / 0x193EF)
    // UInt16[DS, 0xE] |= AX;
    UInt16[DS, 0xE] = Alu.Or16(UInt16[DS, 0xE], AX);
    State.IncCycles();
    // OR word ptr [0x14],AX (1000_93F3 / 0x193F3)
    // UInt16[DS, 0x14] |= AX;
    UInt16[DS, 0x14] = Alu.Or16(UInt16[DS, 0x14], AX);
    State.IncCycles();
    // MOV AL,0x10 (1000_93F7 / 0x193F7)
    AL = 0x10;
    State.IncCycles();
    // MUL CL (1000_93F9 / 0x193F9)
    Cpu.Mul8(CL);
    State.IncCycles();
    // ADD AX,0xfd8 (1000_93FB / 0x193FB)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    State.IncCycles();
    // MOV [0x47a2],AX (1000_93FE / 0x193FE)
    UInt16[DS, 0x47A2] = AX;
    State.IncCycles();
    // MOV SI,AX (1000_9401 / 0x19401)
    SI = AX;
    State.IncCycles();
    // MOV word ptr [0x47ba],0x0 (1000_9403 / 0x19403)
    UInt16[DS, 0x47BA] = 0x0;
    State.IncCycles();
    // CALL 0x1000:90bd (1000_9409 / 0x19409)
    NearCall(cs1, 0x940C, spice86_generated_label_call_target_1000_90BD_0190BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_940C_01940C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_940C_01940C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_940C_1940C:
    // MOV word ptr [0x47b6],0x0 (1000_940C / 0x1940C)
    UInt16[DS, 0x47B6] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x47c2],0x80 (1000_9412 / 0x19412)
    UInt8[DS, 0x47C2] = 0x80;
    State.IncCycles();
    // MOV byte ptr [0x19],0x0 (1000_9417 / 0x19417)
    UInt8[DS, 0x19] = 0x0;
    State.IncCycles();
    // RET  (1000_941C / 0x1941C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_941D_01941D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_941D_1941D:
    // CMP byte ptr [0x47a9],0x0 (1000_941D / 0x1941D)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    State.IncCycles();
    // JZ 0x1000:9427 (1000_9422 / 0x19422)
    if(ZeroFlag) {
      goto label_1000_9427_19427;
    }
    State.IncCycles();
    // JMP 0x1000:2993 (1000_9424 / 0x19424)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2992_012992, 0x12993 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9427_19427:
    // CALL 0x1000:d41b (1000_9427 / 0x19427)
    NearCall(cs1, 0x942A, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    label_1000_942A_1942A:
    // CMP BP,0x20c2 (1000_942A / 0x1942A)
    Alu.Sub16(BP, 0x20C2);
    State.IncCycles();
    // JNZ 0x1000:9436 (1000_942E / 0x1942E)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9436_019436, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:d2ea (1000_9430 / 0x19430)
    NearCall(cs1, 0x9433, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9433_019433, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9433_019433(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9433_19433:
    // JMP 0x1000:0eb9 (1000_9433 / 0x19433)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_0EB9_010EB9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9436_019436(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9436_19436:
    // TEST byte ptr [0x11c9],0x3 (1000_9436 / 0x19436)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JZ 0x1000:9447 (1000_943B / 0x1943B)
    if(ZeroFlag) {
      goto label_1000_9447_19447;
    }
    State.IncCycles();
    // CMP byte ptr [0x11ca],0x0 (1000_943D / 0x1943D)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9447 (1000_9442 / 0x19442)
    if(!ZeroFlag) {
      goto label_1000_9447_19447;
    }
    State.IncCycles();
    // JMP 0x1000:4aad (1000_9444 / 0x19444)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_4AAD_014AAD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9447_19447:
    // CMP word ptr [0x479e],0x0 (1000_9447 / 0x19447)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9458 (1000_944C / 0x1944C)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d2e2 (1000_9458 / 0x19458)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH BX (1000_944E / 0x1944E)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_944F / 0x1944F)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:2db1 (1000_9450 / 0x19450)
    NearCall(cs1, 0x9453, spice86_generated_label_call_target_1000_2DB1_012DB1);
    State.IncCycles();
    // POP DX (1000_9453 / 0x19453)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_9454 / 0x19454)
    BX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:9215 (1000_9455 / 0x19455)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9215_019215, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9458_19458:
    // JMP 0x1000:d2e2 (1000_9458 / 0x19458)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_945B_01945B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_945B_1945B:
    // CMP word ptr [0x479e],0x0 (1000_945B / 0x1945B)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9468 (1000_9460 / 0x19460)
    if(!ZeroFlag) {
      goto label_1000_9468_19468;
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_9462 / 0x19462)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // JMP 0x1000:93aa (1000_9465 / 0x19465)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_93A8_0193A8, 0x193AA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9468_19468:
    // CALL 0x1000:d41b (1000_9468 / 0x19468)
    NearCall(cs1, 0x946B, spice86_generated_label_call_target_1000_D41B_01D41B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_946B_01946B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_946B_01946B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_946B_1946B:
    // CMP BP,0x1ffe (1000_946B / 0x1946B)
    Alu.Sub16(BP, 0x1FFE);
    State.IncCycles();
    // JNZ 0x1000:9472 (1000_946F / 0x1946F)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9472_019472, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_9471 / 0x19471)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9472_019472(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9472_19472:
    // CALL 0x1000:9f40 (1000_9472 / 0x19472)
    NearCall(cs1, 0x9475, spice86_generated_label_call_target_1000_9F40_019F40);
    State.IncCycles();
    label_1000_9475_19475:
    // MOV byte ptr [0x226d],0xa (1000_9475 / 0x19475)
    UInt8[DS, 0x226D] = 0xA;
    State.IncCycles();
    // MOV byte ptr [0x1b],0x0 (1000_947A / 0x1947A)
    UInt8[DS, 0x1B] = 0x0;
    State.IncCycles();
    // CMP word ptr [0x47b6],0x0 (1000_947F / 0x1947F)
    Alu.Sub16(UInt16[DS, 0x47B6], 0x0);
    State.IncCycles();
    // JNZ 0x1000:94dd (1000_9484 / 0x19484)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_94DD_0194DD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47ba] (1000_9486 / 0x19486)
    SI = UInt16[DS, 0x47BA];
    State.IncCycles();
    // OR SI,SI (1000_948A / 0x1948A)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JNZ 0x1000:949a (1000_948C / 0x1948C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9492_019492, 0x1949A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47be] (1000_948E / 0x1948E)
    SI = UInt16[DS, 0x47BE];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9492_019492, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9492_019492(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x94A5: goto label_1000_94A5_194A5;break; // Target of external jump from 0x194F1
      case 0x949A: goto label_1000_949A_1949A;break; // Target of external jump from 0x1948C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9492_19492:
    // MOV AX,SI (1000_9492 / 0x19492)
    AX = SI;
    State.IncCycles();
    // SHL SI,1 (1000_9494 / 0x19494)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr [SI + 0xaa76] (1000_9496 / 0x19496)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    State.IncCycles();
    label_1000_949A_1949A:
    // CMP SI,-0x1 (1000_949A / 0x1949A)
    Alu.Sub16(SI, 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:94b9 (1000_949D / 0x1949D)
    if(ZeroFlag) {
      goto label_1000_94B9_194B9;
    }
    State.IncCycles();
    // CALL 0x1000:9b49 (1000_949F / 0x1949F)
    NearCall(cs1, 0x94A2, spice86_generated_label_call_target_1000_9B49_019B49);
    State.IncCycles();
    label_1000_94A2_194A2:
    // CALL 0x1000:9f9e (1000_94A2 / 0x194A2)
    NearCall(cs1, 0x94A5, spice86_generated_label_call_target_1000_9F9E_019F9E);
    State.IncCycles();
    label_1000_94A5_194A5:
    // MOV word ptr [0x47ba],SI (1000_94A5 / 0x194A5)
    UInt16[DS, 0x47BA] = SI;
    State.IncCycles();
    // JNC 0x1000:94da (1000_94A9 / 0x194A9)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d280 (1000_94DA / 0x194DA)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,[0x47be] (1000_94AB / 0x194AB)
    AX = UInt16[DS, 0x47BE];
    State.IncCycles();
    // INC AX (1000_94AE / 0x194AE)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0x47be],AX (1000_94AF / 0x194AF)
    UInt16[DS, 0x47BE] = AX;
    State.IncCycles();
    // MOV SI,AX (1000_94B2 / 0x194B2)
    SI = AX;
    State.IncCycles();
    // AND AX,0x3 (1000_94B4 / 0x194B4)
    // AX &= 0x3;
    AX = Alu.And16(AX, 0x3);
    State.IncCycles();
    // JNZ 0x1000:9492 (1000_94B7 / 0x194B7)
    if(!ZeroFlag) {
      goto label_1000_9492_19492;
    }
    State.IncCycles();
    label_1000_94B9_194B9:
    // CMP word ptr [0x47c4],0xd (1000_94B9 / 0x194B9)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xD);
    State.IncCycles();
    // JZ 0x1000:94c3 (1000_94BE / 0x194BE)
    if(ZeroFlag) {
      goto label_1000_94C3_194C3;
    }
    State.IncCycles();
    // JMP 0x1000:d2e2 (1000_94C0 / 0x194C0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_94C3_194C3:
    // CMP SI,-0x1 (1000_94C3 / 0x194C3)
    Alu.Sub16(SI, 0xFFFF);
    State.IncCycles();
    // JNZ 0x1000:94cc (1000_94C6 / 0x194C6)
    if(!ZeroFlag) {
      goto label_1000_94CC_194CC;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47be] (1000_94C8 / 0x194C8)
    SI = UInt16[DS, 0x47BE];
    State.IncCycles();
    label_1000_94CC_194CC:
    // AND SI,0xfff8 (1000_94CC / 0x194CC)
    // SI &= 0xFFF8;
    SI = Alu.And16(SI, 0xFFF8);
    State.IncCycles();
    // MOV word ptr [0x47be],SI (1000_94CF / 0x194CF)
    UInt16[DS, 0x47BE] = SI;
    State.IncCycles();
    // MOV byte ptr [0x47c2],0x20 (1000_94D3 / 0x194D3)
    UInt8[DS, 0x47C2] = 0x20;
    State.IncCycles();
    // JMP 0x1000:9492 (1000_94D8 / 0x194D8)
    goto label_1000_9492_19492;
    State.IncCycles();
    label_1000_94DA_194DA:
    // JMP 0x1000:d280 (1000_94DA / 0x194DA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_94DD_0194DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_94DD_194DD:
    // LDS SI,[0x47b6] (1000_94DD / 0x194DD)
    DS = UInt16[DS, 0x47B8];
    SI = UInt16[DS, 0x47B6];
    State.IncCycles();
    // CALL 0x1000:88d2 (1000_94E1 / 0x194E1)
    NearCall(cs1, 0x94E4, spice86_generated_label_ret_target_1000_88D2_0188D2);
    State.IncCycles();
    label_1000_94E4_194E4:
    // MOV SI,word ptr [0x47ba] (1000_94E4 / 0x194E4)
    SI = UInt16[DS, 0x47BA];
    State.IncCycles();
    // ADD word ptr [0x4780],0x1000 (1000_94E8 / 0x194E8)
    // UInt16[DS, 0x4780] += 0x1000;
    UInt16[DS, 0x4780] = Alu.Add16(UInt16[DS, 0x4780], 0x1000);
    State.IncCycles();
    // CALL 0x1000:a03f (1000_94EE / 0x194EE)
    NearCall(cs1, 0x94F1, spice86_generated_label_call_target_1000_A03F_01A03F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_94F1_0194F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_94F1_0194F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_94F1_194F1:
    // JMP 0x1000:94a5 (1000_94F1 / 0x194F1)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9492_019492, 0x194A5 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_94F3_0194F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_94F3_194F3:
    // CMP word ptr [0x47c4],0x10 (1000_94F3 / 0x194F3)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x10);
    State.IncCycles();
    // JNC 0x1000:9532 (1000_94F8 / 0x194F8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    State.IncCycles();
    // PUSH SI (1000_94FA / 0x194FA)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,word ptr [0x47a2] (1000_94FB / 0x194FB)
    SI = UInt16[DS, 0x47A2];
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0xf] (1000_94FF / 0x194FF)
    AL = UInt8[DS, (ushort)(SI + 0xF)];
    State.IncCycles();
    // MOV [0x18],AL (1000_9502 / 0x19502)
    UInt8[DS, 0x18] = AL;
    State.IncCycles();
    // TEST AL,0x40 (1000_9505 / 0x19505)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x8] (1000_9507 / 0x19507)
    AX = UInt16[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // JNZ 0x1000:950f (1000_950A / 0x1950A)
    if(!ZeroFlag) {
      goto label_1000_950F_1950F;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0xa] (1000_950C / 0x1950C)
    AX = UInt16[DS, (ushort)(SI + 0xA)];
    State.IncCycles();
    label_1000_950F_1950F:
    // SUB AX,word ptr [0x2] (1000_950F / 0x1950F)
    AX -= UInt16[DS, 0x2];
    State.IncCycles();
    // NEG AX (1000_9513 / 0x19513)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // MOV [0x16],AX (1000_9515 / 0x19515)
    UInt16[DS, 0x16] = AX;
    State.IncCycles();
    // POP SI (1000_9518 / 0x19518)
    SI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [0x2a],0x64 (1000_9519 / 0x19519)
    Alu.Sub8(UInt8[DS, 0x2A], 0x64);
    State.IncCycles();
    // JNC 0x1000:9532 (1000_951E / 0x1951E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x47c4],0x9 (1000_9520 / 0x19520)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x9);
    State.IncCycles();
    // JNC 0x1000:9532 (1000_9525 / 0x19525)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [0x11db] (1000_9527 / 0x19527)
    DI = UInt16[DS, 0x11DB];
    State.IncCycles();
    // OR DI,DI (1000_952B / 0x1952B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:9532 (1000_952D / 0x1952D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9532 / 0x19532)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:2e98 (1000_952F / 0x1952F)
    NearCall(cs1, 0x9532, spice86_generated_label_call_target_1000_2E98_012E98);
    State.IncCycles();
    label_1000_9532_19532:
    // RET  (1000_9532 / 0x19532)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_9556_019556(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9556_19556:
    // AND byte ptr [SI + 0xf],0xbf (1000_9556 / 0x19556)
    // UInt8[DS, (ushort)(SI + 0xF)] &= 0xBF;
    UInt8[DS, (ushort)(SI + 0xF)] = Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0xBF);
    State.IncCycles();
    // MOV BX,0x2 (1000_955A / 0x1955A)
    BX = 0x2;
    State.IncCycles();
    // CALL 0x1000:956d (1000_955D / 0x1955D)
    NearCall(cs1, 0x9560, spice86_generated_label_call_target_1000_956D_01956D);
    State.IncCycles();
    // MOV CL,byte ptr [SI + 0xe] (1000_9560 / 0x19560)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV AX,0xfffe (1000_9563 / 0x19563)
    AX = 0xFFFE;
    State.IncCycles();
    // ROL AX,CL (1000_9566 / 0x19566)
    AX = Alu.Rol16(AX, CL);
    State.IncCycles();
    // AND word ptr [0x10],AX (1000_9568 / 0x19568)
    // UInt16[DS, 0x10] &= AX;
    UInt16[DS, 0x10] = Alu.And16(UInt16[DS, 0x10], AX);
    State.IncCycles();
    // RET  (1000_956C / 0x1956C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_956D_01956D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_956D_1956D:
    // MOV BP,BX (1000_956D / 0x1956D)
    BP = BX;
    State.IncCycles();
    // XOR BP,0x2 (1000_956F / 0x1956F)
    // BP ^= 0x2;
    BP = Alu.Xor16(BP, 0x2);
    State.IncCycles();
    // MOV AX,[0x2] (1000_9572 / 0x19572)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // SUB AX,word ptr [BP + SI + 0x8] (1000_9575 / 0x19575)
    AX -= UInt16[SS, (ushort)(BP + SI + 0x8)];
    State.IncCycles();
    // CMP AX,0x2 (1000_9578 / 0x19578)
    Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // JC 0x1000:9583 (1000_957B / 0x1957B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9583 / 0x19583)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x2] (1000_957D / 0x1957D)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV word ptr [BX + SI + 0x8],AX (1000_9580 / 0x19580)
    UInt16[DS, (ushort)(BX + SI + 0x8)] = AX;
    State.IncCycles();
    label_1000_9583_19583:
    // RET  (1000_9583 / 0x19583)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_95C1_0195C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_95C1_195C1:
    // MOV AX,0x64 (1000_95C1 / 0x195C1)
    AX = 0x64;
    State.IncCycles();
    // CMP word ptr [0xac],0x3e8 (1000_95C4 / 0x195C4)
    Alu.Sub16(UInt16[DS, 0xAC], 0x3E8);
    State.IncCycles();
    // JC 0x1000:95de (1000_95CA / 0x195CA)
    if(CarryFlag) {
      goto label_1000_95DE_195DE;
    }
    State.IncCycles();
    // SUB AL,byte ptr [0x29] (1000_95CC / 0x195CC)
    // AL -= UInt8[DS, 0x29];
    AL = Alu.Sub8(AL, UInt8[DS, 0x29]);
    State.IncCycles();
    // JC 0x1000:95de (1000_95D0 / 0x195D0)
    if(CarryFlag) {
      goto label_1000_95DE_195DE;
    }
    State.IncCycles();
    // SHR AL,1 (1000_95D2 / 0x195D2)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_95D4 / 0x195D4)
    AL >>= 0x1;
    State.IncCycles();
    // CMP AL,byte ptr [0x36] (1000_95D6 / 0x195D6)
    Alu.Sub8(AL, UInt8[DS, 0x36]);
    State.IncCycles();
    // JBE 0x1000:95de (1000_95DA / 0x195DA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_95DE_195DE;
    }
    State.IncCycles();
    // MOV AH,0x2 (1000_95DC / 0x195DC)
    AH = 0x2;
    State.IncCycles();
    label_1000_95DE_195DE:
    // MOV byte ptr [0x23],AH (1000_95DE / 0x195DE)
    UInt8[DS, 0x23] = AH;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_95E2_0195E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_95E2_0195E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_95E2_195E2:
    // CALL 0x1000:a1c4 (1000_95E2 / 0x195E2)
    NearCall(cs1, 0x95E5, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95E5_0195E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95E5_0195E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_95E5_195E5:
    // MOV AX,0x5 (1000_95E5 / 0x195E5)
    AX = 0x5;
    State.IncCycles();
    // CALL 0x1000:9f31 (1000_95E8 / 0x195E8)
    NearCall(cs1, 0x95EB, spice86_generated_label_call_target_1000_9F31_019F31);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95EB_0195EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95EB_0195EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_95EB_195EB:
    // CALL 0x1000:9f8b (1000_95EB / 0x195EB)
    NearCall(cs1, 0x95EE, spice86_generated_label_call_target_1000_9F8B_019F8B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95EE_0195EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95EE_0195EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_95EE_195EE:
    // INC byte ptr [0x1b] (1000_95EE / 0x195EE)
    UInt8[DS, 0x1B] = Alu.Inc8(UInt8[DS, 0x1B]);
    State.IncCycles();
    // MOV byte ptr [0x23],0x0 (1000_95F2 / 0x195F2)
    UInt8[DS, 0x23] = 0x0;
    State.IncCycles();
    // CALL 0x1000:a1e2 (1000_95F7 / 0x195F7)
    NearCall(cs1, 0x95FA, spice86_generated_label_call_target_1000_A1E2_01A1E2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_95FA_0195FA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_95FA_0195FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_95FA_195FA:
    // JNZ 0x1000:961a (1000_95FA / 0x195FA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47a2] (1000_95FC / 0x195FC)
    SI = UInt16[DS, 0x47A2];
    State.IncCycles();
    // MOV CL,byte ptr [SI + 0xe] (1000_9600 / 0x19600)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // CMP CL,0xe (1000_9603 / 0x19603)
    Alu.Sub8(CL, 0xE);
    State.IncCycles();
    // JZ 0x1000:961b (1000_9606 / 0x19606)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_961B_01961B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR byte ptr [SI + 0xf],0x40 (1000_9608 / 0x19608)
    UInt8[DS, (ushort)(SI + 0xF)] |= 0x40;
    State.IncCycles();
    // XOR BX,BX (1000_960C / 0x1960C)
    BX = 0;
    State.IncCycles();
    // CALL 0x1000:956d (1000_960E / 0x1960E)
    NearCall(cs1, 0x9611, spice86_generated_label_call_target_1000_956D_01956D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9611_019611, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9611_019611(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9611_19611:
    // MOV AX,0x1 (1000_9611 / 0x19611)
    AX = 0x1;
    State.IncCycles();
    // SHL AX,CL (1000_9614 / 0x19614)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    State.IncCycles();
    // OR word ptr [0x10],AX (1000_9616 / 0x19616)
    // UInt16[DS, 0x10] |= AX;
    UInt16[DS, 0x10] = Alu.Or16(UInt16[DS, 0x10], AX);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_961A_01961A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_961A_01961A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_961A_1961A:
    // RET  (1000_961A / 0x1961A)
    return NearRet();
  }
  
  public virtual Action split_1000_961B_01961B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_961B_1961B:
    // MOV SI,word ptr [0x4756] (1000_961B / 0x1961B)
    SI = UInt16[DS, 0x4756];
    State.IncCycles();
    // PUSH SI (1000_961F / 0x1961F)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:66ce (1000_9620 / 0x19620)
    NearCall(cs1, 0x9623, spice86_generated_label_call_target_1000_66CE_0166CE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9623_019623, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9623_019623(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9623_19623:
    // CALL 0x1000:2efb (1000_9623 / 0x19623)
    NearCall(cs1, 0x9626, spice86_generated_label_call_target_1000_2EFB_012EFB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9626_019626, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9626_019626(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9626_19626:
    // CALL 0x1000:3093 (1000_9626 / 0x19626)
    NearCall(cs1, 0x9629, spice86_generated_label_ret_target_1000_3093_013093);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9629_019629, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9629_019629(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9629_19629:
    // POP SI (1000_9629 / 0x19629)
    SI = Stack.Pop();
    State.IncCycles();
    // CMP SI,0x8e0 (1000_962A / 0x1962A)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JNZ 0x1000:9639 (1000_962E / 0x1962E)
    if(!ZeroFlag) {
      goto label_1000_9639_19639;
    }
    State.IncCycles();
    // ADD byte ptr [SI + 0x15],0x18 (1000_9630 / 0x19630)
    UInt8[DS, (ushort)(SI + 0x15)] += 0x18;
    State.IncCycles();
    // ADD byte ptr [0x36],0x18 (1000_9634 / 0x19634)
    // UInt8[DS, 0x36] += 0x18;
    UInt8[DS, 0x36] = Alu.Add8(UInt8[DS, 0x36], 0x18);
    State.IncCycles();
    label_1000_9639_19639:
    // MOV AX,SI (1000_9639 / 0x19639)
    AX = SI;
    State.IncCycles();
    // MOV CX,0x8 (1000_963B / 0x1963B)
    CX = 0x8;
    State.IncCycles();
    // PUSH DS (1000_963E / 0x1963E)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_963F / 0x1963F)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x4758 (1000_9640 / 0x19640)
    DI = 0x4758;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASW ES:DI (1000_9643 / 0x19643)
      Alu.Sub16(AX, UInt16[ES, DI]);
      DI = (ushort)(DI + Direction16);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // MOV AL,0x7 (1000_9645 / 0x19645)
    AL = 0x7;
    State.IncCycles();
    // SUB AL,CL (1000_9647 / 0x19647)
    // AL -= CL;
    AL = Alu.Sub8(AL, CL);
    State.IncCycles();
    // MOV [0x476c],AL (1000_9649 / 0x19649)
    UInt8[DS, 0x476C] = AL;
    State.IncCycles();
    // MOV SI,0x10c8 (1000_964C / 0x1964C)
    SI = 0x10C8;
    State.IncCycles();
    // CALL 0x1000:90bd (1000_964F / 0x1964F)
    NearCall(cs1, 0x9652, spice86_generated_label_call_target_1000_90BD_0190BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9652_019652, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9652_019652(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9652_19652:
    // JMP 0x1000:d280 (1000_9652 / 0x19652)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9655_019655(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9655_19655:
    // MOV CL,byte ptr [SI + 0xe] (1000_9655 / 0x19655)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV DI,0x1153 (1000_9658 / 0x19658)
    DI = 0x1153;
    State.IncCycles();
    // MOV AL,0xff (1000_965B / 0x1965B)
    AL = 0xFF;
    State.IncCycles();
    // CMP byte ptr [DI],CL (1000_965D / 0x1965D)
    Alu.Sub8(UInt8[DS, DI], CL);
    State.IncCycles();
    // JZ 0x1000:9669 (1000_965F / 0x1965F)
    if(ZeroFlag) {
      goto label_1000_9669_19669;
    }
    State.IncCycles();
    // DEC DI (1000_9661 / 0x19661)
    DI--;
    State.IncCycles();
    // CMP byte ptr [DI],CL (1000_9662 / 0x19662)
    Alu.Sub8(UInt8[DS, DI], CL);
    State.IncCycles();
    // JNZ 0x1000:961a (1000_9664 / 0x19664)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    State.IncCycles();
    // XCHG byte ptr [DI + 0x1],AL (1000_9666 / 0x19666)
    byte tmp_1000_9666 = UInt8[DS, (ushort)(DI + 0x1)];
    UInt8[DS, (ushort)(DI + 0x1)] = AL;
    AL = tmp_1000_9666;
    State.IncCycles();
    label_1000_9669_19669:
    // MOV byte ptr [DI],AL (1000_9669 / 0x19669)
    UInt8[DS, DI] = AL;
    State.IncCycles();
    // MOV byte ptr [DI + 0x10d0],0x0 (1000_966B / 0x1966B)
    UInt8[DS, (ushort)(DI + 0x10D0)] = 0x0;
    State.IncCycles();
    // JMP 0x1000:d763 (1000_9670 / 0x19670)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9673_019673(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9673_19673:
    // MOV CL,byte ptr [SI + 0xe] (1000_9673 / 0x19673)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV DI,0x1152 (1000_9676 / 0x19676)
    DI = 0x1152;
    State.IncCycles();
    // CMP byte ptr [DI],CL (1000_9679 / 0x19679)
    Alu.Sub8(UInt8[DS, DI], CL);
    State.IncCycles();
    // JZ 0x1000:961a (1000_967B / 0x1967B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI],0xff (1000_967D / 0x1967D)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    State.IncCycles();
    // JZ 0x1000:96ab (1000_9680 / 0x19680)
    if(ZeroFlag) {
      goto label_1000_96AB_196AB;
    }
    State.IncCycles();
    // INC DI (1000_9682 / 0x19682)
    DI++;
    State.IncCycles();
    // CMP byte ptr [DI],CL (1000_9683 / 0x19683)
    Alu.Sub8(UInt8[DS, DI], CL);
    State.IncCycles();
    // JZ 0x1000:961a (1000_9685 / 0x19685)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_961A / 0x1961A)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI],0xff (1000_9687 / 0x19687)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    State.IncCycles();
    // JZ 0x1000:96ab (1000_968A / 0x1968A)
    if(ZeroFlag) {
      goto label_1000_96AB_196AB;
    }
    State.IncCycles();
    // DEC DI (1000_968C / 0x1968C)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // PUSH CX (1000_968D / 0x1968D)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CL,byte ptr [DI] (1000_968E / 0x1968E)
    CL = UInt8[DS, DI];
    State.IncCycles();
    // MOV AL,0x10 (1000_9690 / 0x19690)
    AL = 0x10;
    State.IncCycles();
    // MUL CL (1000_9692 / 0x19692)
    Cpu.Mul8(CL);
    State.IncCycles();
    // ADD AX,0xfd8 (1000_9694 / 0x19694)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    State.IncCycles();
    // MOV SI,AX (1000_9697 / 0x19697)
    SI = AX;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0xe] (1000_9699 / 0x19699)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // ADD AL,0x64 (1000_969C / 0x1969C)
    // AL += 0x64;
    AL = Alu.Add8(AL, 0x64);
    State.IncCycles();
    // MOV [0x23],AL (1000_969E / 0x1969E)
    UInt8[DS, 0x23] = AL;
    State.IncCycles();
    // CALL 0x1000:9556 (1000_96A1 / 0x196A1)
    NearCall(cs1, 0x96A4, not_observed_1000_9556_019556);
    State.IncCycles();
    // POP CX (1000_96A4 / 0x196A4)
    CX = Stack.Pop();
    State.IncCycles();
    // INC DI (1000_96A5 / 0x196A5)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_96A6 / 0x196A6)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // MOV byte ptr [DI + -0x1],AL (1000_96A8 / 0x196A8)
    UInt8[DS, (ushort)(DI - 0x1)] = AL;
    State.IncCycles();
    label_1000_96AB_196AB:
    // MOV byte ptr [DI],CL (1000_96AB / 0x196AB)
    UInt8[DS, DI] = CL;
    State.IncCycles();
    // MOV byte ptr [DI + 0x10d0],0x10 (1000_96AD / 0x196AD)
    UInt8[DS, (ushort)(DI + 0x10D0)] = 0x10;
    State.IncCycles();
    // JMP 0x1000:d763 (1000_96B2 / 0x196B2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_96B5_0196B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_96B5_196B5:
    // PUSH word ptr [0x47c4] (1000_96B5 / 0x196B5)
    Stack.Push(UInt16[DS, 0x47C4]);
    State.IncCycles();
    // PUSH word ptr [0x47c2] (1000_96B9 / 0x196B9)
    Stack.Push(UInt16[DS, 0x47C2]);
    State.IncCycles();
    // MOV word ptr [0x47c4],0x10 (1000_96BD / 0x196BD)
    UInt16[DS, 0x47C4] = 0x10;
    State.IncCycles();
    // MOV byte ptr [0x47c2],0x80 (1000_96C3 / 0x196C3)
    UInt8[DS, 0x47C2] = 0x80;
    State.IncCycles();
    // MOV SI,word ptr [0xab84] (1000_96C8 / 0x196C8)
    SI = UInt16[DS, 0xAB84];
    State.IncCycles();
    // CALL 0x1000:9f9e (1000_96CC / 0x196CC)
    NearCall(cs1, 0x96CF, spice86_generated_label_call_target_1000_9F9E_019F9E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_96CF_0196CF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_96CF_0196CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_96CF_196CF:
    // POP word ptr [0x47c2] (1000_96CF / 0x196CF)
    UInt16[DS, 0x47C2] = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0x47c4] (1000_96D3 / 0x196D3)
    UInt16[DS, 0x47C4] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_96D7 / 0x196D7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_96D8_0196D8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_96D8_196D8:
    // MOV [0x47c4],AX (1000_96D8 / 0x196D8)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // INC byte ptr [0x47dc] (1000_96DB / 0x196DB)
    UInt8[DS, 0x47DC] = Alu.Inc8(UInt8[DS, 0x47DC]);
    State.IncCycles();
    // MOV AX,0x10 (1000_96DF / 0x196DF)
    AX = 0x10;
    State.IncCycles();
    // CALL 0x1000:9702 (1000_96E2 / 0x196E2)
    NearCall(cs1, 0x96E5, spice86_generated_label_call_target_1000_9702_019702);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_96E5_0196E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_96E5_0196E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_96E5_196E5:
    // MOV word ptr [0x1bea],0x0 (1000_96E5 / 0x196E5)
    UInt16[DS, 0x1BEA] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x47dc],0x0 (1000_96EB / 0x196EB)
    UInt8[DS, 0x47DC] = 0x0;
    State.IncCycles();
    // RET  (1000_96F0 / 0x196F0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_96F1_0196F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_96F1_196F1:
    // MOV [0x47c4],AX (1000_96F1 / 0x196F1)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // CMP AL,0xe (1000_96F4 / 0x196F4)
    Alu.Sub8(AL, 0xE);
    State.IncCycles();
    // JNZ 0x1000:9702 (1000_96F6 / 0x196F6)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9702_019702, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x4756] (1000_96F8 / 0x196F8)
    SI = UInt16[DS, 0x4756];
    State.IncCycles();
    // CALL 0x1000:31f6 (1000_96FC / 0x196FC)
    NearCall(cs1, 0x96FF, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_96FF_0196FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_96FF_0196FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_96FF_196FF:
    // MOV AX,0xe (1000_96FF / 0x196FF)
    AX = 0xE;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9702_019702, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9702_019702(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9702_19702:
    // SHL AX,1 (1000_9702 / 0x19702)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_9704 / 0x19704)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_9706 / 0x19706)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // OR AX,0x4 (1000_9708 / 0x19708)
    // AX |= 0x4;
    AX = Alu.Or16(AX, 0x4);
    State.IncCycles();
    // MOV SI,AX (1000_970B / 0x1970B)
    SI = AX;
    State.IncCycles();
    // SHL SI,1 (1000_970D / 0x1970D)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV SI,word ptr [SI + 0xaa76] (1000_970F / 0x1970F)
    SI = UInt16[DS, (ushort)(SI + 0xAA76)];
    State.IncCycles();
    // CALL 0x1000:9f40 (1000_9713 / 0x19713)
    NearCall(cs1, 0x9716, spice86_generated_label_call_target_1000_9F40_019F40);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9716_019716, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9716_019716(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9716_19716:
    // JMP 0x1000:9f8b (1000_9716 / 0x19716)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9F8B_019F8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9719_019719(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9719_19719:
    // CMP byte ptr [0x4c],0x0 (1000_9719 / 0x19719)
    Alu.Sub8(UInt8[DS, 0x4C], 0x0);
    State.IncCycles();
    // JS 0x1000:972c (1000_971E / 0x1971E)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_972C_01972C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x46ef] (1000_9720 / 0x19720)
    SI = UInt16[DS, 0x46EF];
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_9724 / 0x19724)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV AL,0xf (1000_9727 / 0x19727)
    AL = 0xF;
    State.IncCycles();
    // CALL 0x1000:2a51 (1000_9729 / 0x19729)
    NearCall(cs1, 0x972C, spice86_generated_label_call_target_1000_2A51_012A51);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_972C_01972C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_972C_01972C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_972C_1972C:
    // CALL 0x1000:9f82 (1000_972C / 0x1972C)
    NearCall(cs1, 0x972F, spice86_generated_label_call_target_1000_9F82_019F82);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_972F_01972F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_972F_01972F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_972F_1972F:
    // MOV word ptr [0x47c4],0xf (1000_972F / 0x1972F)
    UInt16[DS, 0x47C4] = 0xF;
    State.IncCycles();
    // MOV word ptr [0x47a2],0x10c8 (1000_9735 / 0x19735)
    UInt16[DS, 0x47A2] = 0x10C8;
    State.IncCycles();
    // CALL 0x1000:a1c4 (1000_973B / 0x1973B)
    NearCall(cs1, 0x973E, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    State.IncCycles();
    label_1000_973E_1973E:
    // MOV SI,word ptr [0x47ba] (1000_973E / 0x1973E)
    SI = UInt16[DS, 0x47BA];
    State.IncCycles();
    // INC SI (1000_9742 / 0x19742)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // JZ 0x1000:9748 (1000_9743 / 0x19743)
    if(ZeroFlag) {
      goto label_1000_9748_19748;
    }
    State.IncCycles();
    // DEC SI (1000_9745 / 0x19745)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // JNZ 0x1000:974c (1000_9746 / 0x19746)
    if(!ZeroFlag) {
      goto label_1000_974C_1974C;
    }
    State.IncCycles();
    label_1000_9748_19748:
    // MOV SI,word ptr [0xab6a] (1000_9748 / 0x19748)
    SI = UInt16[DS, 0xAB6A];
    State.IncCycles();
    label_1000_974C_1974C:
    // MOV byte ptr [0x47c2],0x20 (1000_974C / 0x1974C)
    UInt8[DS, 0x47C2] = 0x20;
    State.IncCycles();
    // CALL 0x1000:9f9e (1000_9751 / 0x19751)
    NearCall(cs1, 0x9754, spice86_generated_label_call_target_1000_9F9E_019F9E);
    State.IncCycles();
    label_1000_9754_19754:
    // MOV word ptr [0x47ba],SI (1000_9754 / 0x19754)
    UInt16[DS, 0x47BA] = SI;
    State.IncCycles();
    // JNC 0x1000:9760 (1000_9758 / 0x19758)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9760 / 0x19760)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [0x47ba],0x0 (1000_975A / 0x1975A)
    UInt16[DS, 0x47BA] = 0x0;
    State.IncCycles();
    label_1000_9760_19760:
    // RET  (1000_9760 / 0x19760)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_978E_01978E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_978E_1978E:
    // CALL 0x1000:4aca (1000_978E / 0x1978E)
    NearCall(cs1, 0x9791, spice86_generated_label_call_target_1000_4ACA_014ACA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9791_019791, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9791_019791(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9791_19791:
    // MOV AX,[0x47c4] (1000_9791 / 0x19791)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AX,0xffff (1000_9794 / 0x19794)
    Alu.Sub16(AX, 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:97ce (1000_9797 / 0x19797)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_97CE / 0x197CE)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:91a0 (1000_9799 / 0x19799)
    NearCall(cs1, 0x979C, spice86_generated_label_call_target_1000_91A0_0191A0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_979C_01979C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_979C_01979C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_979C_1979C:
    // CALL 0x1000:9908 (1000_979C / 0x1979C)
    NearCall(cs1, 0x979F, spice86_generated_label_call_target_1000_9908_019908);
    State.IncCycles();
    label_1000_979F_1979F:
    // CMP word ptr [0x479e],0x0 (1000_979F / 0x1979F)
    Alu.Sub16(UInt16[DS, 0x479E], 0x0);
    State.IncCycles();
    // JZ 0x1000:97ac (1000_97A4 / 0x197A4)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97AC_0197AC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x1be2 (1000_97A6 / 0x197A6)
    SI = 0x1BE2;
    State.IncCycles();
    // CALL 0x1000:c477 (1000_97A9 / 0x197A9)
    NearCall(cs1, 0x97AC, spice86_generated_label_call_target_1000_C477_01C477);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97AC_0197AC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97AC_0197AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_97AC_197AC:
    // MOV SI,word ptr [0x47c8] (1000_97AC / 0x197AC)
    SI = UInt16[DS, 0x47C8];
    State.IncCycles();
    // OR SI,SI (1000_97B0 / 0x197B0)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:97c8 (1000_97B2 / 0x197B2)
    if(ZeroFlag) {
      goto label_1000_97C8_197C8;
    }
    State.IncCycles();
    // MOV word ptr [0x4540],0x0 (1000_97B4 / 0x197B4)
    UInt16[DS, 0x4540] = 0x0;
    State.IncCycles();
    // CALL 0x1000:9bac (1000_97BA / 0x197BA)
    NearCall(cs1, 0x97BD, spice86_generated_label_call_target_1000_9BAC_019BAC);
    State.IncCycles();
    label_1000_97BD_197BD:
    // CMP word ptr [0x479e],0x223c (1000_97BD / 0x197BD)
    Alu.Sub16(UInt16[DS, 0x479E], 0x223C);
    State.IncCycles();
    // JNZ 0x1000:97c8 (1000_97C3 / 0x197C3)
    if(!ZeroFlag) {
      goto label_1000_97C8_197C8;
    }
    State.IncCycles();
    // CALL 0x1000:9025 (1000_97C5 / 0x197C5)
    NearCall(cs1, 0x97C8, spice86_generated_label_call_target_1000_9025_019025);
    State.IncCycles();
    label_1000_97C8_197C8:
    // CALL 0x1000:c0f4 (1000_97C8 / 0x197C8)
    NearCall(cs1, 0x97CB, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97CB_0197CB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97CB_0197CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_97CB_197CB:
    // JMP 0x1000:c4dd (1000_97CB / 0x197CB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_97CE_0197CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_97CE_197CE:
    // RET  (1000_97CE / 0x197CE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_97CF_0197CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_97CF_197CF:
    // CALL 0x1000:a7a5 (1000_97CF / 0x197CF)
    NearCall(cs1, 0x97D2, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97D2_0197D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97D2_0197D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_97D2_197D2:
    // CMP word ptr [0x47c4],-0x1 (1000_97D2 / 0x197D2)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:97ce (1000_97D7 / 0x197D7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_97CE / 0x197CE)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47a2] (1000_97D9 / 0x197D9)
    SI = UInt16[DS, 0x47A2];
    State.IncCycles();
    // OR byte ptr [SI + 0xf],0x20 (1000_97DD / 0x197DD)
    UInt8[DS, (ushort)(SI + 0xF)] |= 0x20;
    State.IncCycles();
    // AND byte ptr [SI + 0xf],0xfb (1000_97E1 / 0x197E1)
    // UInt8[DS, (ushort)(SI + 0xF)] &= 0xFB;
    UInt8[DS, (ushort)(SI + 0xF)] = Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0xFB);
    State.IncCycles();
    // MOV word ptr [0x47e1],0x0 (1000_97E5 / 0x197E5)
    UInt16[DS, 0x47E1] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x11c9],0x0 (1000_97EB / 0x197EB)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JZ 0x1000:980c (1000_97F0 / 0x197F0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_980C_01980C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:8c8a (1000_97F2 / 0x197F2)
    NearCall(cs1, 0x97F5, spice86_generated_label_call_target_1000_8C8A_018C8A);
    State.IncCycles();
    label_1000_97F5_197F5:
    // MOV BP,0x98b2 (1000_97F5 / 0x197F5)
    BP = 0x98B2;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_97F8 / 0x197F8)
    NearCall(cs1, 0x97FB, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_97FB_0197FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_97FB_0197FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_97FB_197FB:
    // XOR AL,AL (1000_97FB / 0x197FB)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0x11ca],AL (1000_97FD / 0x197FD)
    byte tmp_1000_97FD = UInt8[DS, 0x11CA];
    UInt8[DS, 0x11CA] = AL;
    AL = tmp_1000_97FD;
    State.IncCycles();
    // PUSH AX (1000_9801 / 0x19801)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:2ffb (1000_9802 / 0x19802)
    NearCall(cs1, 0x9805, spice86_generated_label_call_target_1000_2FFB_012FFB);
    State.IncCycles();
    label_1000_9805_19805:
    // POP AX (1000_9805 / 0x19805)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x11ca],AL (1000_9806 / 0x19806)
    UInt8[DS, 0x11CA] = AL;
    State.IncCycles();
    // JMP 0x1000:4abe (1000_9809 / 0x19809)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4ABE_014ABE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_980C_01980C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_980C_1980C:
    // CALL 0x1000:8c8a (1000_980C / 0x1980C)
    NearCall(cs1, 0x980F, spice86_generated_label_call_target_1000_8C8A_018C8A);
    State.IncCycles();
    label_1000_980F_1980F:
    // CMP byte ptr [0x47a4],0x0 (1000_980F / 0x1980F)
    Alu.Sub8(UInt8[DS, 0x47A4], 0x0);
    State.IncCycles();
    // MOV SI,word ptr [0x47a2] (1000_9814 / 0x19814)
    SI = UInt16[DS, 0x47A2];
    State.IncCycles();
    // JS 0x1000:9849 (1000_9818 / 0x19818)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9849_019849, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x2b],0x0 (1000_981A / 0x1981A)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JZ 0x1000:9825 (1000_981F / 0x1981F)
    if(ZeroFlag) {
      goto label_1000_9825_19825;
    }
    State.IncCycles();
    // MOV AX,0x9840 (1000_9821 / 0x19821)
    AX = 0x9840;
    State.IncCycles();
    // PUSH AX (1000_9824 / 0x19824)
    Stack.Push(AX);
    State.IncCycles();
    label_1000_9825_19825:
    // TEST byte ptr [SI + 0xf],0x40 (1000_9825 / 0x19825)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    State.IncCycles();
    // JZ 0x1000:982e (1000_9829 / 0x19829)
    if(ZeroFlag) {
      goto label_1000_982E_1982E;
    }
    State.IncCycles();
    // JMP 0x1000:9673 (1000_982B / 0x1982B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9673_019673, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_982E_1982E:
    // CALL 0x1000:9655 (1000_982E / 0x1982E)
    NearCall(cs1, 0x9831, not_observed_1000_9655_019655);
    State.IncCycles();
    // CMP byte ptr [0x2b],0x0 (1000_9831 / 0x19831)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JNZ 0x1000:983f (1000_9836 / 0x19836)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_983F / 0x1983F)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [0x47a4],0x1 (1000_9838 / 0x19838)
    Alu.And8(UInt8[DS, 0x47A4], 0x1);
    State.IncCycles();
    // JZ 0x1000:9879 (1000_983D / 0x1983D)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9849_019849, 0x19879 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_983F_1983F:
    // RET  (1000_983F / 0x1983F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9849_019849(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9849_19849:
    // MOV word ptr [0x1c06],0x0 (1000_9849 / 0x19849)
    UInt16[DS, 0x1C06] = 0x0;
    State.IncCycles();
    // TEST byte ptr [SI + 0xf],0x40 (1000_984F / 0x1984F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    State.IncCycles();
    // JZ 0x1000:9858 (1000_9853 / 0x19853)
    if(ZeroFlag) {
      goto label_1000_9858_19858;
    }
    State.IncCycles();
    // CALL 0x1000:9673 (1000_9855 / 0x19855)
    NearCall(cs1, 0x9858, spice86_generated_label_call_target_1000_9673_019673);
    State.IncCycles();
    label_1000_9858_19858:
    // XOR AX,AX (1000_9858 / 0x19858)
    AX = 0;
    State.IncCycles();
    // MOV [0x4540],AX (1000_985A / 0x1985A)
    UInt16[DS, 0x4540] = AX;
    State.IncCycles();
    // MOV [0x479e],AX (1000_985D / 0x1985D)
    UInt16[DS, 0x479E] = AX;
    State.IncCycles();
    // AND byte ptr [0x47d1],0x3f (1000_9860 / 0x19860)
    // UInt8[DS, 0x47D1] &= 0x3F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x3F);
    State.IncCycles();
    // MOV [0x47c8],AX (1000_9865 / 0x19865)
    UInt16[DS, 0x47C8] = AX;
    State.IncCycles();
    // AND byte ptr [0x47a4],0x7f (1000_9868 / 0x19868)
    // UInt8[DS, 0x47A4] &= 0x7F;
    UInt8[DS, 0x47A4] = Alu.And8(UInt8[DS, 0x47A4], 0x7F);
    State.IncCycles();
    // CALL 0x1000:9b8b (1000_986D / 0x1986D)
    NearCall(cs1, 0x9870, spice86_generated_label_call_target_1000_9B8B_019B8B);
    State.IncCycles();
    label_1000_9870_19870:
    // MOV AL,[0x23] (1000_9870 / 0x19870)
    AL = UInt8[DS, 0x23];
    State.IncCycles();
    // SUB AL,0x64 (1000_9873 / 0x19873)
    AL -= 0x64;
    State.IncCycles();
    // CMP AL,0x10 (1000_9875 / 0x19875)
    Alu.Sub8(AL, 0x10);
    State.IncCycles();
    // JC 0x1000:9898 (1000_9877 / 0x19877)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_9898_019898, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_9879_19879:
    // CALL 0x1000:2efb (1000_9879 / 0x19879)
    NearCall(cs1, 0x987C, spice86_generated_label_call_target_1000_2EFB_012EFB);
    State.IncCycles();
    label_1000_987C_1987C:
    // CMP byte ptr [0x11c9],0x0 (1000_987C / 0x1987C)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9886 (1000_9881 / 0x19881)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9886_019886, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:3090 (1000_9883 / 0x19883)
    NearCall(cs1, 0x9886, spice86_generated_label_call_target_1000_3090_013090);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9886_019886, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9886_019886(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9886_19886:
    // CALL 0x1000:37b2 (1000_9886 / 0x19886)
    NearCall(cs1, 0x9889, spice86_generated_label_call_target_1000_37B2_0137B2);
    State.IncCycles();
    label_1000_9889_19889:
    // CALL 0x1000:c412 (1000_9889 / 0x19889)
    NearCall(cs1, 0x988C, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    label_1000_988C_1988C:
    // CALL 0x1000:c0f4 (1000_988C / 0x1988C)
    NearCall(cs1, 0x988F, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    label_1000_988F_1988F:
    // CALL 0x1000:1834 (1000_988F / 0x1988F)
    NearCall(cs1, 0x9892, spice86_generated_label_call_target_1000_1834_011834);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9892_019892, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9892_019892(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9892_19892:
    // CALL 0x1000:c4dd (1000_9892 / 0x19892)
    NearCall(cs1, 0x9895, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_9895_19895:
    // JMP 0x1000:17e6 (1000_9895 / 0x19895)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9898_019898(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9898_19898:
    // MOV BP,0x37b2 (1000_9898 / 0x19898)
    BP = 0x37B2;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_989B / 0x1989B)
    NearCall(cs1, 0x989E, spice86_generated_label_call_target_1000_C097_01C097);
    State.IncCycles();
    // CALL 0x1000:36d3 (1000_989E / 0x1989E)
    NearCall(cs1, 0x98A1, spice86_generated_label_call_target_1000_36D3_0136D3);
    State.IncCycles();
    // MOV AX,0xc8 (1000_98A1 / 0x198A1)
    AX = 0xC8;
    State.IncCycles();
    // CALL 0x1000:e3a0 (1000_98A4 / 0x198A4)
    NearCall(cs1, 0x98A7, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    State.IncCycles();
    // MOV word ptr [0x1c06],0x0 (1000_98A7 / 0x198A7)
    UInt16[DS, 0x1C06] = 0x0;
    State.IncCycles();
    // JMP 0x1000:9858 (1000_98AD / 0x198AD)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9849_019849, 0x19858 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_98AF_0198AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_98AF_198AF:
    // CALL 0x1000:8c8a (1000_98AF / 0x198AF)
    NearCall(cs1, 0x98B2, spice86_generated_label_call_target_1000_8C8A_018C8A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_98B2_0198B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_98B2_0198B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_98B2_198B2:
    // CMP byte ptr [0x47c3],0x0 (1000_98B2 / 0x198B2)
    Alu.Sub8(UInt8[DS, 0x47C3], 0x0);
    State.IncCycles();
    // JNZ 0x1000:98e5 (1000_98B7 / 0x198B7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_98E5 / 0x198E5)
      return NearRet();
    }
    State.IncCycles();
    // XOR AX,AX (1000_98B9 / 0x198B9)
    AX = 0;
    State.IncCycles();
    // MOV [0x4540],AX (1000_98BB / 0x198BB)
    UInt16[DS, 0x4540] = AX;
    State.IncCycles();
    // AND byte ptr [0x47d1],0x3f (1000_98BE / 0x198BE)
    // UInt8[DS, 0x47D1] &= 0x3F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x3F);
    State.IncCycles();
    // XCHG word ptr [0x47c8],AX (1000_98C3 / 0x198C3)
    ushort tmp_1000_98C3 = UInt16[DS, 0x47C8];
    UInt16[DS, 0x47C8] = AX;
    AX = tmp_1000_98C3;
    State.IncCycles();
    // OR AX,AX (1000_98C7 / 0x198C7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:98e5 (1000_98C9 / 0x198C9)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_98E5 / 0x198E5)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x1bf0 (1000_98CB / 0x198CB)
    SI = 0x1BF0;
    State.IncCycles();
    // MOV word ptr [SI + 0x8],0x0 (1000_98CE / 0x198CE)
    UInt16[DS, (ushort)(SI + 0x8)] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x1c06],0x0 (1000_98D3 / 0x198D3)
    UInt16[DS, 0x1C06] = 0x0;
    State.IncCycles();
    // CALL 0x1000:c446 (1000_98D9 / 0x198D9)
    NearCall(cs1, 0x98DC, spice86_generated_label_call_target_1000_C446_01C446);
    State.IncCycles();
    label_1000_98DC_198DC:
    // MOV SI,0x1bf0 (1000_98DC / 0x198DC)
    SI = 0x1BF0;
    State.IncCycles();
    // CALL 0x1000:c4f0 (1000_98DF / 0x198DF)
    NearCall(cs1, 0x98E2, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    State.IncCycles();
    label_1000_98E2_198E2:
    // JMP 0x1000:9b8b (1000_98E2 / 0x198E2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9B8B_019B8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_98E5_198E5:
    // RET  (1000_98E5 / 0x198E5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_98E6_0198E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_98E6_198E6:
    // CALL 0x1000:98f5 (1000_98E6 / 0x198E6)
    NearCall(cs1, 0x98E9, spice86_generated_label_call_target_1000_98F5_0198F5);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_98F5_0198F5, 0x198E9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_98F5_0198F5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x98E9: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_98E9_198E9:
    // MOV [0x47c8],AX (1000_98E9 / 0x198E9)
    UInt16[DS, 0x47C8] = AX;
    State.IncCycles();
    // MOV [0x47aa],AX (1000_98EC / 0x198EC)
    UInt16[DS, 0x47AA] = AX;
    State.IncCycles();
    // MOV [0x479e],AX (1000_98EF / 0x198EF)
    UInt16[DS, 0x479E] = AX;
    State.IncCycles();
    // JMP 0x1000:9b8b (1000_98F2 / 0x198F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9B8B_019B8B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    entry:
    State.IncCycles();
    label_1000_98F5_198F5:
    // XOR AX,AX (1000_98F5 / 0x198F5)
    AX = 0;
    State.IncCycles();
    // MOV [0x1c06],AX (1000_98F7 / 0x198F7)
    UInt16[DS, 0x1C06] = AX;
    State.IncCycles();
    // MOV [0x1bf8],AX (1000_98FA / 0x198FA)
    UInt16[DS, 0x1BF8] = AX;
    State.IncCycles();
    // MOV [0x1bea],AX (1000_98FD / 0x198FD)
    UInt16[DS, 0x1BEA] = AX;
    State.IncCycles();
    // RET  (1000_9900 / 0x19900)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9901_019901(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9901_19901:
    // MOV word ptr [0x479e],0x0 (1000_9901 / 0x19901)
    UInt16[DS, 0x479E] = 0x0;
    State.IncCycles();
    // RET  (1000_9907 / 0x19907)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9908_019908(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9908_19908:
    // MOV SI,word ptr [0x47ca] (1000_9908 / 0x19908)
    SI = UInt16[DS, 0x47CA];
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_990C / 0x1990C)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    // CALL 0x1000:994f (1000_9910 / 0x19910)
    NearCall(cs1, 0x9913, spice86_generated_label_call_target_1000_994F_01994F);
    State.IncCycles();
    label_1000_9913_19913:
    // MOV byte ptr [0x47d1],0xc0 (1000_9913 / 0x19913)
    UInt8[DS, 0x47D1] = 0xC0;
    State.IncCycles();
    // MOV AL,[0x478c] (1000_9918 / 0x19918)
    AL = UInt8[DS, 0x478C];
    State.IncCycles();
    // XOR AH,AH (1000_991B / 0x1991B)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_991D / 0x1991D)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_991F / 0x1991F)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV [0x47ce],AX (1000_9921 / 0x19921)
    UInt16[DS, 0x47CE] = AX;
    State.IncCycles();
    // ADD SI,word ptr ES:[BP + SI] (1000_9924 / 0x19924)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    State.IncCycles();
    // CALL 0x1000:996c (1000_9927 / 0x19927)
    NearCall(cs1, 0x992A, spice86_generated_label_call_target_1000_996C_01996C);
    State.IncCycles();
    label_1000_992A_1992A:
    // MOV word ptr [0x47c8],SI (1000_992A / 0x1992A)
    UInt16[DS, 0x47C8] = SI;
    State.IncCycles();
    // XCHG word ptr [0x47c6],SI (1000_992E / 0x1992E)
    ushort tmp_1000_992E = UInt16[DS, 0x47C6];
    UInt16[DS, 0x47C6] = SI;
    SI = tmp_1000_992E;
    State.IncCycles();
    // OR SI,SI (1000_9932 / 0x19932)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JNZ 0x1000:994e (1000_9934 / 0x19934)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_994E / 0x1994E)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0xea],0x0 (1000_9936 / 0x19936)
    Alu.Sub8(UInt8[DS, 0xEA], 0x0);
    State.IncCycles();
    // JG 0x1000:994e (1000_993B / 0x1993B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      State.IncCycles();
      // RET  (1000_994E / 0x1994E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_993D / 0x1993D)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CALL 0x1000:127c (1000_9940 / 0x19940)
    NearCall(cs1, 0x9943, spice86_generated_label_call_target_1000_127C_01127C);
    State.IncCycles();
    label_1000_9943_19943:
    // JC 0x1000:994e (1000_9943 / 0x19943)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_994E / 0x1994E)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_9945_019945, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_9945_019945(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x994E: goto label_1000_994E_1994E;break; // Target of external jump from 0x19934
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9945_19945:
    // MOV SI,0x99be (1000_9945 / 0x19945)
    SI = 0x99BE;
    State.IncCycles();
    // MOV BP,0x10 (1000_9948 / 0x19948)
    BP = 0x10;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_994B / 0x1994B)
    NearCall(cs1, 0x994E, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    label_1000_994E_1994E:
    // RET  (1000_994E / 0x1994E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_994F_01994F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_994F_1994F:
    // MOV AL,[0x47d0] (1000_994F / 0x1994F)
    AL = UInt8[DS, 0x47D0];
    State.IncCycles();
    // OR AL,AL (1000_9952 / 0x19952)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:9963 (1000_9954 / 0x19954)
    if(!ZeroFlag) {
      goto label_1000_9963_19963;
    }
    State.IncCycles();
    // MOV BX,0x6 (1000_9956 / 0x19956)
    BX = 0x6;
    State.IncCycles();
    // CALL 0x1000:e3b7 (1000_9959 / 0x19959)
    NearCall(cs1, 0x995C, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    label_1000_995C_1995C:
    // MOV BP,AX (1000_995C / 0x1995C)
    BP = AX;
    State.IncCycles();
    // ADD BP,word ptr [0xf0] (1000_995E / 0x1995E)
    // BP += UInt16[DS, 0xF0];
    BP = Alu.Add16(BP, UInt16[DS, 0xF0]);
    State.IncCycles();
    // RET  (1000_9962 / 0x19962)
    return NearRet();
    State.IncCycles();
    label_1000_9963_19963:
    // DEC AL (1000_9963 / 0x19963)
    AL--;
    State.IncCycles();
    // XOR AH,AH (1000_9965 / 0x19965)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_9967 / 0x19967)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_9969 / 0x19969)
    BP = AX;
    State.IncCycles();
    // RET  (1000_996B / 0x1996B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_996C_01996C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_996C_1996C:
    // CMP byte ptr [0x47d0],0x0 (1000_996C / 0x1996C)
    Alu.Sub8(UInt8[DS, 0x47D0], 0x0);
    State.IncCycles();
    // JZ 0x1000:9981 (1000_9971 / 0x19971)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9981 / 0x19981)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0x20 (1000_9973 / 0x19973)
    CX = 0x20;
    State.IncCycles();
    // PUSH ES (1000_9976 / 0x19976)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_9977 / 0x19977)
    DS = Stack.Pop();
    State.IncCycles();
    label_1000_9978_19978:
    // LODSB SI (1000_9978 / 0x19978)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_9979 / 0x19979)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:9978 (1000_997B / 0x1997B)
    if(!ZeroFlag) {
      goto label_1000_9978_19978;
    }
    State.IncCycles();
    // LOOP 0x1000:9978 (1000_997D / 0x1997D)
    if(--CX != 0) {
      goto label_1000_9978_19978;
    }
    State.IncCycles();
    // PUSH SS (1000_997F / 0x1997F)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_9980 / 0x19980)
    DS = Stack.Pop();
    State.IncCycles();
    label_1000_9981_19981:
    // RET  (1000_9981 / 0x19981)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9985_019985(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9982: break; // Instructions before entry targeted by 0x1998B
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_9982_19982:
    // CALL 0x1000:99be (1000_9982 / 0x19982)
    NearCall(cs1, 0x9985, spice86_generated_label_call_target_1000_99BE_0199BE);
    entry:
    State.IncCycles();
    label_1000_9985_19985:
    // TEST word ptr [0x47ce],0x7 (1000_9985 / 0x19985)
    Alu.And16(UInt16[DS, 0x47CE], 0x7);
    State.IncCycles();
    // JNZ 0x1000:9982 (1000_998B / 0x1998B)
    if(!ZeroFlag) {
      goto label_1000_9982_19982;
    }
    State.IncCycles();
    // RET  (1000_998D / 0x1998D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_998E_01998E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_998E_1998E:
    // MOV DI,0x4c60 (1000_998E / 0x1998E)
    DI = 0x4C60;
    State.IncCycles();
    // MOV SI,0x1bf0 (1000_9991 / 0x19991)
    SI = 0x1BF0;
    State.IncCycles();
    // MOV CX,0x4 (1000_9994 / 0x19994)
    CX = 0x4;
    State.IncCycles();
    // CALL 0x1000:99b2 (1000_9997 / 0x19997)
    NearCall(cs1, 0x999A, not_observed_1000_99B2_0199B2);
    State.IncCycles();
    // MOV SI,0x22a6 (1000_999A / 0x1999A)
    SI = 0x22A6;
    State.IncCycles();
    // MOV CX,0x1 (1000_999D / 0x1999D)
    CX = 0x1;
    State.IncCycles();
    // CALL 0x1000:99b2 (1000_99A0 / 0x199A0)
    NearCall(cs1, 0x99A3, not_observed_1000_99B2_0199B2);
    State.IncCycles();
    // MOV SI,0x4540 (1000_99A3 / 0x199A3)
    SI = 0x4540;
    State.IncCycles();
    // MOV CX,0xc9 (1000_99A6 / 0x199A6)
    CX = 0xC9;
    State.IncCycles();
    // CALL 0x1000:99b2 (1000_99A9 / 0x199A9)
    NearCall(cs1, 0x99AC, not_observed_1000_99B2_0199B2);
    State.IncCycles();
    // MOV SI,0x47c4 (1000_99AC / 0x199AC)
    SI = 0x47C4;
    State.IncCycles();
    // MOV CX,0x7 (1000_99AF / 0x199AF)
    CX = 0x7;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_99B2_0199B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_99B2_0199B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_99B2_199B2:
    // LODSW SI (1000_99B2 / 0x199B2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG word ptr [DI],AX (1000_99B3 / 0x199B3)
    ushort tmp_1000_99B3 = UInt16[DS, DI];
    UInt16[DS, DI] = AX;
    AX = tmp_1000_99B3;
    State.IncCycles();
    // MOV word ptr [SI + -0x2],AX (1000_99B5 / 0x199B5)
    UInt16[DS, (ushort)(SI - 0x2)] = AX;
    State.IncCycles();
    // ADD DI,0x2 (1000_99B8 / 0x199B8)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    State.IncCycles();
    // LOOP 0x1000:99b2 (1000_99BB / 0x199BB)
    if(--CX != 0) {
      goto label_1000_99B2_199B2;
    }
    State.IncCycles();
    // RET  (1000_99BD / 0x199BD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_99BE_0199BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_99BE_199BE:
    // CMP byte ptr [0x47c3],0x0 (1000_99BE / 0x199BE)
    Alu.Sub8(UInt8[DS, 0x47C3], 0x0);
    State.IncCycles();
    // JZ 0x1000:99da (1000_99C3 / 0x199C3)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_99DA_199DA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:998e (1000_99C5 / 0x199C5)
    NearCall(cs1, 0x99C8, not_observed_1000_998E_01998E);
    State.IncCycles();
    // MOV AX,0x7 (1000_99C8 / 0x199C8)
    AX = 0x7;
    State.IncCycles();
    // CALL 0x1000:920f (1000_99CB / 0x199CB)
    NearCall(cs1, 0x99CE, spice86_generated_label_call_target_1000_920F_01920F);
    State.IncCycles();
    // CALL 0x1000:99da (1000_99CE / 0x199CE)
    NearCall(cs1, 0x99D1, spice86_label_1000_99DA_199DA);
    State.IncCycles();
    // CALL 0x1000:998e (1000_99D1 / 0x199D1)
    NearCall(cs1, 0x99D4, not_observed_1000_998E_01998E);
    State.IncCycles();
    // MOV AX,0x2d (1000_99D4 / 0x199D4)
    AX = 0x2D;
    State.IncCycles();
    // CALL 0x1000:920f (1000_99D7 / 0x199D7)
    NearCall(cs1, 0x99DA, spice86_generated_label_call_target_1000_920F_01920F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_label_1000_99DA_199DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_label_1000_99DA_199DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_99DA_199DA:
    // CALL 0x1000:9197 (1000_99DA / 0x199DA)
    NearCall(cs1, 0x99DD, spice86_generated_label_call_target_1000_9197_019197);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_99DD_0199DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_99DD_0199DD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x99F0: goto label_1000_99F0_199F0;break; // Target of external jump from 0x19A39
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_99DD_199DD:
    // MOV AL,[0x47d1] (1000_99DD / 0x199DD)
    AL = UInt8[DS, 0x47D1];
    State.IncCycles();
    // OR AL,AL (1000_99E0 / 0x199E0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:9a1c (1000_99E2 / 0x199E2)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9A1C / 0x19A1C)
      return NearRet();
    }
    State.IncCycles();
    // TEST AL,0x10 (1000_99E4 / 0x199E4)
    Alu.And8(AL, 0x10);
    State.IncCycles();
    // JNZ 0x1000:9a40 (1000_99E6 / 0x199E6)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9A1D_019A1D, 0x19A40 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47c6] (1000_99E8 / 0x199E8)
    SI = UInt16[DS, 0x47C6];
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_99EC / 0x199EC)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    label_1000_99F0_199F0:
    // CMP byte ptr ES:[SI],0xff (1000_99F0 / 0x199F0)
    Alu.Sub8(UInt8[ES, SI], 0xFF);
    State.IncCycles();
    // JZ 0x1000:9a1d (1000_99F4 / 0x199F4)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9A1D_019A1D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_99F6_0199F6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9A1C: goto label_1000_9A1C_19A1C;break; // Target of external jump from 0x19A59, 0x19A0B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_99F6_199F6:
    // DEC word ptr [0x47ce] (1000_99F6 / 0x199F6)
    UInt16[DS, 0x47CE] = Alu.Dec16(UInt16[DS, 0x47CE]);
    State.IncCycles();
    // MOV word ptr [0x47c8],SI (1000_99FA / 0x199FA)
    UInt16[DS, 0x47C8] = SI;
    State.IncCycles();
    // CALL 0x1000:9bb1 (1000_99FE / 0x199FE)
    NearCall(cs1, 0x9A01, spice86_generated_label_call_target_1000_9BB1_019BB1);
    State.IncCycles();
    label_1000_9A01_19A01:
    // MOV word ptr [0x47c6],SI (1000_9A01 / 0x19A01)
    UInt16[DS, 0x47C6] = SI;
    State.IncCycles();
    // CMP word ptr [0xd834],0x13f (1000_9A05 / 0x19A05)
    Alu.Sub16(UInt16[DS, 0xD834], 0x13F);
    State.IncCycles();
    // JZ 0x1000:9a1c (1000_9A0B / 0x19A0B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9A1C / 0x19A1C)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:908c (1000_9A0D / 0x19A0D)
    NearCall(cs1, 0x9A10, spice86_generated_label_call_target_1000_908C_01908C);
    State.IncCycles();
    label_1000_9A10_19A10:
    // MOV SI,0xd834 (1000_9A10 / 0x19A10)
    SI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_9A13 / 0x19A13)
    NearCall(cs1, 0x9A16, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    label_1000_9A16_19A16:
    // CALL 0x1000:c4f0 (1000_9A16 / 0x19A16)
    NearCall(cs1, 0x9A19, spice86_generated_label_call_target_1000_C4F0_01C4F0);
    State.IncCycles();
    label_1000_9A19_19A19:
    // JMP 0x1000:db67 (1000_9A19 / 0x19A19)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DB67_01DB67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9A1C_19A1C:
    // RET  (1000_9A1C / 0x19A1C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_9A1D_019A1D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9A40: goto label_1000_9A40_19A40;break; // Target of external jump from 0x199E6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9A1D_19A1D:
    // CMP word ptr [0x47ce],0x0 (1000_9A1D / 0x19A1D)
    Alu.Sub16(UInt16[DS, 0x47CE], 0x0);
    State.IncCycles();
    // JS 0x1000:9a3b (1000_9A22 / 0x19A22)
    if(SignFlag) {
      goto label_1000_9A3B_19A3B;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x47ca] (1000_9A24 / 0x19A24)
    SI = UInt16[DS, 0x47CA];
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_9A28 / 0x19A28)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    // CALL 0x1000:994f (1000_9A2C / 0x19A2C)
    NearCall(cs1, 0x9A2F, spice86_generated_label_call_target_1000_994F_01994F);
    State.IncCycles();
    label_1000_9A2F_19A2F:
    // ADD SI,word ptr ES:[BP + SI] (1000_9A2F / 0x19A2F)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    State.IncCycles();
    // CALL 0x1000:996c (1000_9A32 / 0x19A32)
    NearCall(cs1, 0x9A35, spice86_generated_label_call_target_1000_996C_01996C);
    State.IncCycles();
    label_1000_9A35_19A35:
    // MOV word ptr [0x47c6],SI (1000_9A35 / 0x19A35)
    UInt16[DS, 0x47C6] = SI;
    State.IncCycles();
    // JMP 0x1000:99f0 (1000_9A39 / 0x19A39)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_99DD_0199DD, 0x199F0 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9A3B_19A3B:
    // OR byte ptr [0x47d1],0x10 (1000_9A3B / 0x19A3B)
    // UInt8[DS, 0x47D1] |= 0x10;
    UInt8[DS, 0x47D1] = Alu.Or8(UInt8[DS, 0x47D1], 0x10);
    State.IncCycles();
    label_1000_9A40_19A40:
    // MOV SI,word ptr [0x47c6] (1000_9A40 / 0x19A40)
    SI = UInt16[DS, 0x47C6];
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_9A44 / 0x19A44)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    // CMP word ptr [0x47ce],0x0 (1000_9A48 / 0x19A48)
    Alu.Sub16(UInt16[DS, 0x47CE], 0x0);
    State.IncCycles();
    // JG 0x1000:99f6 (1000_9A4D / 0x19A4D)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:9ab4 (1000_9A4F / 0x19A4F)
    NearCall(cs1, 0x9A52, spice86_generated_label_call_target_1000_9AB4_019AB4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9A52_019A52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9A52_019A52(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9A52_19A52:
    // JC 0x1000:99f6 (1000_9A52 / 0x19A52)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:9a7b (1000_9A54 / 0x19A54)
    NearCall(cs1, 0x9A57, spice86_generated_label_call_target_1000_9A7B_019A7B);
    State.IncCycles();
    label_1000_9A57_19A57:
    // OR AH,AH (1000_9A57 / 0x19A57)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JNZ 0x1000:9a1c (1000_9A59 / 0x19A59)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9A1C / 0x19A1C)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:9a60 (1000_9A5B / 0x19A5B)
    NearCall(cs1, 0x9A5E, spice86_generated_label_call_target_1000_9A60_019A60);
    State.IncCycles();
    label_1000_9A5E_19A5E:
    // JMP 0x1000:99f6 (1000_9A5E / 0x19A5E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_99F6_0199F6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9A60_019A60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9A60_19A60:
    // OR AL,AL (1000_9A60 / 0x19A60)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:9a74 (1000_9A62 / 0x19A62)
    if(ZeroFlag) {
      goto label_1000_9A74_19A74;
    }
    State.IncCycles();
    // MOV BX,AX (1000_9A64 / 0x19A64)
    BX = AX;
    State.IncCycles();
    // XOR AL,AL (1000_9A66 / 0x19A66)
    AL = 0;
    State.IncCycles();
    // MOV CX,0xffff (1000_9A68 / 0x19A68)
    CX = 0xFFFF;
    State.IncCycles();
    // MOV DI,SI (1000_9A6B / 0x19A6B)
    DI = SI;
    State.IncCycles();
    label_1000_9A6D_19A6D:
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_9A6D / 0x19A6D)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // DEC BX (1000_9A6F / 0x19A6F)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x1000:9a6d (1000_9A70 / 0x19A70)
    if(!ZeroFlag) {
      goto label_1000_9A6D_19A6D;
    }
    State.IncCycles();
    // MOV SI,DI (1000_9A72 / 0x19A72)
    SI = DI;
    State.IncCycles();
    label_1000_9A74_19A74:
    // MOV word ptr [0x47ce],0x8 (1000_9A74 / 0x19A74)
    UInt16[DS, 0x47CE] = 0x8;
    State.IncCycles();
    // RET  (1000_9A7A / 0x19A7A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9A7B_019A7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9A7B_19A7B:
    // MOV AL,[0x47d0] (1000_9A7B / 0x19A7B)
    AL = UInt8[DS, 0x47D0];
    State.IncCycles();
    // MOV BX,0xf18 (1000_9A7E / 0x19A7E)
    BX = 0xF18;
    State.IncCycles();
    // OR AL,AL (1000_9A81 / 0x19A81)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:9a9a (1000_9A83 / 0x19A83)
    if(!ZeroFlag) {
      goto label_1000_9A9A_19A9A;
    }
    State.IncCycles();
    // MOV AL,0x5 (1000_9A85 / 0x19A85)
    AL = 0x5;
    State.IncCycles();
    // MOV BX,0xf38 (1000_9A87 / 0x19A87)
    BX = 0xF38;
    State.IncCycles();
    // CMP word ptr [0x47c4],0x7 (1000_9A8A / 0x19A8A)
    Alu.Sub16(UInt16[DS, 0x47C4], 0x7);
    State.IncCycles();
    // JNZ 0x1000:9a9a (1000_9A8F / 0x19A8F)
    if(!ZeroFlag) {
      goto label_1000_9A9A_19A9A;
    }
    State.IncCycles();
    // CMP byte ptr [0x2a],0xc8 (1000_9A91 / 0x19A91)
    Alu.Sub8(UInt8[DS, 0x2A], 0xC8);
    State.IncCycles();
    // JC 0x1000:9a9a (1000_9A96 / 0x19A96)
    if(CarryFlag) {
      goto label_1000_9A9A_19A9A;
    }
    State.IncCycles();
    // INC AL (1000_9A98 / 0x19A98)
    AL++;
    State.IncCycles();
    label_1000_9A9A_19A9A:
    // DEC AL (1000_9A9A / 0x19A9A)
    AL--;
    State.IncCycles();
    // XOR AH,AH (1000_9A9C / 0x19A9C)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_9A9E / 0x19A9E)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_9AA0 / 0x19AA0)
    BP = AX;
    State.IncCycles();
    // ADD BP,word ptr [0xf0] (1000_9AA2 / 0x19AA2)
    // BP += UInt16[DS, 0xF0];
    BP = Alu.Add16(BP, UInt16[DS, 0xF0]);
    State.IncCycles();
    // MOV SI,word ptr [0x47ca] (1000_9AA6 / 0x19AA6)
    SI = UInt16[DS, 0x47CA];
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_9AAA / 0x19AAA)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    // ADD SI,word ptr ES:[BP + SI] (1000_9AAE / 0x19AAE)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    State.IncCycles();
    // JMP 0x1000:e3b7 (1000_9AB1 / 0x19AB1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E3B7_01E3B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9AB4_019AB4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9AB4_19AB4:
    // MOV AL,[0x47e1] (1000_9AB4 / 0x19AB4)
    AL = UInt8[DS, 0x47E1];
    State.IncCycles();
    // OR AL,AL (1000_9AB7 / 0x19AB7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:9b08 (1000_9AB9 / 0x19AB9)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9B08 / 0x19B08)
      return NearRet();
    }
    State.IncCycles();
    // JS 0x1000:9adb (1000_9ABB / 0x19ABB)
    if(SignFlag) {
      goto label_1000_9ADB_19ADB;
    }
    State.IncCycles();
    // OR byte ptr [0x47e1],0x80 (1000_9ABD / 0x19ABD)
    // UInt8[DS, 0x47E1] |= 0x80;
    UInt8[DS, 0x47E1] = Alu.Or8(UInt8[DS, 0x47E1], 0x80);
    State.IncCycles();
    // CALL 0x1000:9b09 (1000_9AC2 / 0x19AC2)
    NearCall(cs1, 0x9AC5, spice86_generated_label_call_target_1000_9B09_019B09);
    State.IncCycles();
    label_1000_9AC5_19AC5:
    // MOV AL,[0x47e2] (1000_9AC5 / 0x19AC5)
    AL = UInt8[DS, 0x47E2];
    State.IncCycles();
    // XOR AH,AH (1000_9AC8 / 0x19AC8)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_9ACA / 0x19ACA)
    BP = AX;
    State.IncCycles();
    // MOV SI,word ptr [0x47ca] (1000_9ACC / 0x19ACC)
    SI = UInt16[DS, 0x47CA];
    State.IncCycles();
    // ADD SI,word ptr ES:[BP + SI] (1000_9AD0 / 0x19AD0)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    State.IncCycles();
    // MOV word ptr [0x47ce],0x14 (1000_9AD3 / 0x19AD3)
    UInt16[DS, 0x47CE] = 0x14;
    State.IncCycles();
    // STC  (1000_9AD9 / 0x19AD9)
    CarryFlag = true;
    State.IncCycles();
    // RET  (1000_9ADA / 0x19ADA)
    return NearRet();
    State.IncCycles();
    label_1000_9ADB_19ADB:
    // SHR AL,1 (1000_9ADB / 0x19ADB)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:9b08 (1000_9ADD / 0x19ADD)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9B08 / 0x19B08)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x47e1],0x80 (1000_9ADF / 0x19ADF)
    UInt8[DS, 0x47E1] = 0x80;
    State.IncCycles();
    // CALL 0x1000:d075 (1000_9AE4 / 0x19AE4)
    NearCall(cs1, 0x9AE7, spice86_generated_label_call_target_1000_D075_01D075);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9AE7_019AE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9AE7_019AE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9AE7_19AE7:
    // MOV SI,word ptr [0x47e4] (1000_9AE7 / 0x19AE7)
    SI = UInt16[DS, 0x47E4];
    State.IncCycles();
    // CMP word ptr [SI],0x38 (1000_9AEB / 0x19AEB)
    Alu.Sub16(UInt16[DS, SI], 0x38);
    State.IncCycles();
    // JNC 0x1000:9b08 (1000_9AEE / 0x19AEE)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9B08 / 0x19B08)
      return NearRet();
    }
    State.IncCycles();
    // LODSW SI (1000_9AF0 / 0x19AF0)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_9AF1 / 0x19AF1)
    CX = AX;
    State.IncCycles();
    // LODSW SI (1000_9AF3 / 0x19AF3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_9AF4 / 0x19AF4)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_9AF6 / 0x19AF6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_9AF7 / 0x19AF7)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_9AF9 / 0x19AF9)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AX,CX (1000_9AFA / 0x19AFA)
    ushort tmp_1000_9AFA = AX;
    AX = CX;
    CX = tmp_1000_9AFA;
    State.IncCycles();
    // CALL 0x1000:8865 (1000_9AFB / 0x19AFB)
    NearCall(cs1, 0x9AFE, spice86_generated_label_call_target_1000_8865_018865);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9AFE_019AFE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9AFE_019AFE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9B08: goto label_1000_9B08_19B08;break; // Target of external jump from 0x19AB9, 0x19ADD
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_9AFE_19AFE:
    // CALL 0x1000:d068 (1000_9AFE / 0x19AFE)
    NearCall(cs1, 0x9B01, spice86_generated_label_call_target_1000_D068_01D068);
    State.IncCycles();
    label_1000_9B01_19B01:
    // CALL 0x1000:dbb2 (1000_9B01 / 0x19B01)
    NearCall(cs1, 0x9B04, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_9B04_19B04:
    // CALL 0x1000:c4dd (1000_9B04 / 0x19B04)
    NearCall(cs1, 0x9B07, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_9B07_19B07:
    // CLC  (1000_9B07 / 0x19B07)
    CarryFlag = false;
    State.IncCycles();
    label_1000_9B08_19B08:
    // RET  (1000_9B08 / 0x19B08)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9B09_019B09(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9B09_19B09:
    // MOV SI,word ptr [0x47e4] (1000_9B09 / 0x19B09)
    SI = UInt16[DS, 0x47E4];
    State.IncCycles();
    // CMP word ptr [SI],0x38 (1000_9B0D / 0x19B0D)
    Alu.Sub16(UInt16[DS, SI], 0x38);
    State.IncCycles();
    // JC 0x1000:9b48 (1000_9B10 / 0x19B10)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9B48 / 0x19B48)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x20] (1000_9B12 / 0x19B12)
    AX = UInt16[DS, 0x20];
    State.IncCycles();
    // JZ 0x1000:9b1c (1000_9B15 / 0x19B15)
    if(ZeroFlag) {
      goto label_1000_9B1C_19B1C;
    }
    State.IncCycles();
    // MOV AL,[0x9d] (1000_9B17 / 0x19B17)
    AL = UInt8[DS, 0x9D];
    State.IncCycles();
    // XOR AH,AH (1000_9B1A / 0x19B1A)
    AH = 0;
    State.IncCycles();
    label_1000_9B1C_19B1C:
    // CALL 0x1000:8a23 (1000_9B1C / 0x19B1C)
    NearCall(cs1, 0x9B1F, spice86_generated_label_call_target_1000_8A23_018A23);
    State.IncCycles();
    // MOV CX,AX (1000_9B1F / 0x19B1F)
    CX = AX;
    State.IncCycles();
    // LES SI,[0xdbb0] (1000_9B21 / 0x19B21)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // MOV DI,SI (1000_9B25 / 0x19B25)
    DI = SI;
    State.IncCycles();
    // MOV BP,0x5 (1000_9B27 / 0x19B27)
    BP = 0x5;
    State.IncCycles();
    label_1000_9B2A_19B2A:
    // AND BX,0xf (1000_9B2A / 0x19B2A)
    // BX &= 0xF;
    BX = Alu.And16(BX, 0xF);
    State.IncCycles();
    // JZ 0x1000:9b32 (1000_9B2D / 0x19B2D)
    if(ZeroFlag) {
      goto label_1000_9B32_19B32;
    }
    State.IncCycles();
    // MOV BP,0x6 (1000_9B2F / 0x19B2F)
    BP = 0x6;
    State.IncCycles();
    label_1000_9B32_19B32:
    // ADD BX,BP (1000_9B32 / 0x19B32)
    BX += BP;
    State.IncCycles();
    // SHL BX,1 (1000_9B34 / 0x19B34)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV AX,word ptr ES:[BX + SI] (1000_9B36 / 0x19B36)
    AX = UInt16[ES, (ushort)(BX + SI)];
    State.IncCycles();
    // STOSW ES:DI (1000_9B39 / 0x19B39)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV BL,DH (1000_9B3A / 0x19B3A)
    BL = DH;
    State.IncCycles();
    // MOV DH,DL (1000_9B3C / 0x19B3C)
    DH = DL;
    State.IncCycles();
    // MOV DL,CH (1000_9B3E / 0x19B3E)
    DL = CH;
    State.IncCycles();
    // MOV CH,CL (1000_9B40 / 0x19B40)
    CH = CL;
    State.IncCycles();
    // MOV CL,0xff (1000_9B42 / 0x19B42)
    CL = 0xFF;
    State.IncCycles();
    // CMP BL,CL (1000_9B44 / 0x19B44)
    Alu.Sub8(BL, CL);
    State.IncCycles();
    // JNZ 0x1000:9b2a (1000_9B46 / 0x19B46)
    if(!ZeroFlag) {
      goto label_1000_9B2A_19B2A;
    }
    State.IncCycles();
    label_1000_9B48_19B48:
    // RET  (1000_9B48 / 0x19B48)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9B49_019B49(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9B49_19B49:
    // MOV AX,[0x47e1] (1000_9B49 / 0x19B49)
    AX = UInt16[DS, 0x47E1];
    State.IncCycles();
    // CMP AL,0x80 (1000_9B4C / 0x19B4C)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:9b84 (1000_9B4E / 0x19B4E)
    if(!ZeroFlag) {
      goto label_1000_9B84_19B84;
    }
    State.IncCycles();
    // PUSH SI (1000_9B50 / 0x19B50)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH AX (1000_9B51 / 0x19B51)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:9197 (1000_9B52 / 0x19B52)
    NearCall(cs1, 0x9B55, spice86_generated_label_call_target_1000_9197_019197);
    State.IncCycles();
    // POP AX (1000_9B55 / 0x19B55)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV AL,AH (1000_9B56 / 0x19B56)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_9B58 / 0x19B58)
    AH = 0;
    State.IncCycles();
    // INC AX (1000_9B5A / 0x19B5A)
    AX++;
    State.IncCycles();
    // INC AX (1000_9B5B / 0x19B5B)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV BP,AX (1000_9B5C / 0x19B5C)
    BP = AX;
    State.IncCycles();
    // MOV SI,word ptr [0x47ca] (1000_9B5E / 0x19B5E)
    SI = UInt16[DS, 0x47CA];
    State.IncCycles();
    // MOV ES,word ptr [0xdbb2] (1000_9B62 / 0x19B62)
    ES = UInt16[DS, 0xDBB2];
    State.IncCycles();
    // ADD SI,word ptr ES:[BP + SI] (1000_9B66 / 0x19B66)
    // SI += UInt16[ES, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[ES, (ushort)(BP + SI)]);
    State.IncCycles();
    // MOV byte ptr [0x47e1],0x81 (1000_9B69 / 0x19B69)
    UInt8[DS, 0x47E1] = 0x81;
    State.IncCycles();
    label_1000_9B6E_19B6E:
    // PUSH ES (1000_9B6E / 0x19B6E)
    Stack.Push(ES);
    State.IncCycles();
    // MOV BP,0x99f6 (1000_9B6F / 0x19B6F)
    BP = 0x99F6;
    State.IncCycles();
    // MOV AX,0xc (1000_9B72 / 0x19B72)
    AX = 0xC;
    State.IncCycles();
    // CALL 0x1000:e353 (1000_9B75 / 0x19B75)
    NearCall(cs1, 0x9B78, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    // POP ES (1000_9B78 / 0x19B78)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV SI,word ptr [0x47c6] (1000_9B79 / 0x19B79)
    SI = UInt16[DS, 0x47C6];
    State.IncCycles();
    // CMP byte ptr ES:[SI],0xff (1000_9B7D / 0x19B7D)
    Alu.Sub8(UInt8[ES, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:9b6e (1000_9B81 / 0x19B81)
    if(!ZeroFlag) {
      goto label_1000_9B6E_19B6E;
    }
    State.IncCycles();
    // POP SI (1000_9B83 / 0x19B83)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_9B84_19B84:
    // MOV word ptr [0x47e1],0x0 (1000_9B84 / 0x19B84)
    UInt16[DS, 0x47E1] = 0x0;
    State.IncCycles();
    // RET  (1000_9B8A / 0x19B8A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9B8B_019B8B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9B8B_19B8B:
    // CALL 0x1000:a7a5 (1000_9B8B / 0x19B8B)
    NearCall(cs1, 0x9B8E, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9B8E_019B8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9B8E_019B8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9B8E_19B8E:
    // XOR AX,AX (1000_9B8E / 0x19B8E)
    AX = 0;
    State.IncCycles();
    // MOV byte ptr [0x47c3],0x0 (1000_9B90 / 0x19B90)
    UInt8[DS, 0x47C3] = 0x0;
    State.IncCycles();
    // MOV [0x47ce],AX (1000_9B95 / 0x19B95)
    UInt16[DS, 0x47CE] = AX;
    State.IncCycles();
    // AND byte ptr [0x47d1],0x7f (1000_9B98 / 0x19B98)
    // UInt8[DS, 0x47D1] &= 0x7F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x7F);
    State.IncCycles();
    // XCHG word ptr [0x47c6],AX (1000_9B9D / 0x19B9D)
    ushort tmp_1000_9B9D = UInt16[DS, 0x47C6];
    UInt16[DS, 0x47C6] = AX;
    AX = tmp_1000_9B9D;
    State.IncCycles();
    // OR AX,AX (1000_9BA1 / 0x19BA1)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:9bab (1000_9BA3 / 0x19BA3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_9BAB / 0x19BAB)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x99be (1000_9BA5 / 0x19BA5)
    SI = 0x99BE;
    State.IncCycles();
    // JMP 0x1000:da5f (1000_9BA8 / 0x19BA8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_9BAB_19BAB:
    // RET  (1000_9BAB / 0x19BAB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9BAC_019BAC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BAC_19BAC:
    // PUSH SI (1000_9BAC / 0x19BAC)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:9197 (1000_9BAD / 0x19BAD)
    NearCall(cs1, 0x9BB0, spice86_generated_label_call_target_1000_9197_019197);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BB0_019BB0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_9BB0_019BB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BB0_19BB0:
    // POP SI (1000_9BB0 / 0x19BB0)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9BB1_019BB1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_9BB1_019BB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_9BB1_19BB1:
    // CALL 0x1000:9bee (1000_9BB1 / 0x19BB1)
    NearCall(cs1, 0x9BB4, spice86_generated_label_call_target_1000_9BEE_019BEE);
    State.IncCycles();
    label_1000_9BB4_19BB4:
    // PUSH SI (1000_9BB4 / 0x19BB4)
    Stack.Push(SI);
    State.IncCycles();
    // CMP word ptr [0x4540],0x0 (1000_9BB5 / 0x19BB5)
    Alu.Sub16(UInt16[DS, 0x4540], 0x0);
    State.IncCycles();
    // JNZ 0x1000:9bcc (1000_9BBA / 0x19BBA)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_9BCC_019BCC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x1bf0 (1000_9BBC / 0x19BBC)
    SI = 0x1BF0;
    State.IncCycles();
    // MOV DI,0xd834 (1000_9BBF / 0x19BBF)
    DI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_9BC2 / 0x19BC2)
    NearCall(cs1, 0x9BC5, spice86_generated_label_call_target_1000_5B99_015B99);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_9BC5_019BC5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
