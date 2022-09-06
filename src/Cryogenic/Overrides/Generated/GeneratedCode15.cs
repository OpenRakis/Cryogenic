namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_B126_01B126(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B126_1B126:
    // PUSH SI (1000_B126 / 0x1B126)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,AX (1000_B127 / 0x1B127)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_B129 / 0x1B129)
    NearCall(cs1, 0xB12C, spice86_generated_label_call_target_1000_CF70_01CF70);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B12C_01B12C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B12C_01B12C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B12C_1B12C:
    // MOV DI,word ptr [0x47bc] (1000_B12C / 0x1B12C)
    DI = UInt16[DS, 0x47BC];
    State.IncCycles();
    // PUSH DI (1000_B130 / 0x1B130)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:88f1 (1000_B131 / 0x1B131)
    NearCall(cs1, 0xB134, spice86_generated_label_call_target_1000_88F1_0188F1);
    State.IncCycles();
    label_1000_B134_1B134:
    // POP DI (1000_B134 / 0x1B134)
    DI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [SI],0x20 (1000_B135 / 0x1B135)
    Alu.Sub8(UInt8[DS, SI], 0x20);
    State.IncCycles();
    // JZ 0x1000:b141 (1000_B138 / 0x1B138)
    if(ZeroFlag) {
      goto label_1000_B141_1B141;
    }
    State.IncCycles();
    // CALL 0x1000:8944 (1000_B13A / 0x1B13A)
    NearCall(cs1, 0xB13D, spice86_generated_label_call_target_1000_8944_018944);
    State.IncCycles();
    label_1000_B13D_1B13D:
    // DEC DI (1000_B13D / 0x1B13D)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // MOV AL,0x20 (1000_B13E / 0x1B13E)
    AL = 0x20;
    State.IncCycles();
    // STOSB ES:DI (1000_B140 / 0x1B140)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_1000_B141_1B141:
    // MOV word ptr [0x47bc],DI (1000_B141 / 0x1B141)
    UInt16[DS, 0x47BC] = DI;
    State.IncCycles();
    // POP SI (1000_B145 / 0x1B145)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_B146 / 0x1B146)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B147_01B147(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B147_1B147:
    // MOV SI,0xa8 (1000_B147 / 0x1B147)
    SI = 0xA8;
    State.IncCycles();
    // MOV DX,0x2 (1000_B14A / 0x1B14A)
    DX = 0x2;
    State.IncCycles();
    // MOV CX,0x1 (1000_B14D / 0x1B14D)
    CX = 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B150_01B150, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B150_01B150(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B150_1B150:
    // XOR DI,DI (1000_B150 / 0x1B150)
    DI = 0;
    State.IncCycles();
    label_1000_B152_1B152:
    // ADD SI,DX (1000_B152 / 0x1B152)
    // SI += DX;
    SI = Alu.Add16(SI, DX);
    State.IncCycles();
    // OR DX,0x2 (1000_B154 / 0x1B154)
    // DX |= 0x2;
    DX = Alu.Or16(DX, 0x2);
    State.IncCycles();
    // MOV BP,word ptr CS:[SI] (1000_B157 / 0x1B157)
    BP = UInt16[cs1, SI];
    State.IncCycles();
    // AND BP,0x7ff (1000_B15A / 0x1B15A)
    // BP &= 0x7FF;
    BP = Alu.And16(BP, 0x7FF);
    State.IncCycles();
    // JZ 0x1000:b177 (1000_B15E / 0x1B15E)
    if(ZeroFlag) {
      goto label_1000_B177_1B177;
    }
    State.IncCycles();
    // SHL BP,1 (1000_B160 / 0x1B160)
    BP <<= 0x1;
    State.IncCycles();
    // SHL BP,1 (1000_B162 / 0x1B162)
    BP <<= 0x1;
    State.IncCycles();
    // ADD BP,0xaa78 (1000_B164 / 0x1B164)
    // BP += 0xAA78;
    BP = Alu.Add16(BP, 0xAA78);
    State.IncCycles();
    // MOV AL,byte ptr [BP + 0x2] (1000_B168 / 0x1B168)
    AL = UInt8[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // AND AL,BL (1000_B16B / 0x1B16B)
    // AL &= BL;
    AL = Alu.And8(AL, BL);
    State.IncCycles();
    // JZ 0x1000:b173 (1000_B16D / 0x1B16D)
    if(ZeroFlag) {
      goto label_1000_B173_1B173;
    }
    State.IncCycles();
    // CMP AL,BH (1000_B16F / 0x1B16F)
    Alu.Sub8(AL, BH);
    State.IncCycles();
    // JNZ 0x1000:b152 (1000_B171 / 0x1B171)
    if(!ZeroFlag) {
      goto label_1000_B152_1B152;
    }
    State.IncCycles();
    label_1000_B173_1B173:
    // MOV DI,SI (1000_B173 / 0x1B173)
    DI = SI;
    State.IncCycles();
    // LOOP 0x1000:b152 (1000_B175 / 0x1B175)
    if(--CX != 0) {
      goto label_1000_B152_1B152;
    }
    State.IncCycles();
    label_1000_B177_1B177:
    // OR DI,DI (1000_B177 / 0x1B177)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // RET  (1000_B179 / 0x1B179)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B17A_01B17A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B17A_1B17A:
    // MOV AL,[0xc6] (1000_B17A / 0x1B17A)
    AL = UInt8[DS, 0xC6];
    State.IncCycles();
    // PUSH AX (1000_B17D / 0x1B17D)
    Stack.Push(AX);
    State.IncCycles();
    // OR AL,0x80 (1000_B17E / 0x1B17E)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    State.IncCycles();
    // MOV [0xc6],AL (1000_B180 / 0x1B180)
    UInt8[DS, 0xC6] = AL;
    State.IncCycles();
    // CALL 0x1000:96b5 (1000_B183 / 0x1B183)
    NearCall(cs1, 0xB186, spice86_generated_label_call_target_1000_96B5_0196B5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B186_01B186, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B186_01B186(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B186_1B186:
    // POP AX (1000_B186 / 0x1B186)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0xc6],AL (1000_B187 / 0x1B187)
    UInt8[DS, 0xC6] = AL;
    State.IncCycles();
    // RET  (1000_B18A / 0x1B18A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B18B_01B18B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B18B_1B18B:
    // CALL 0x1000:adbe (1000_B18B / 0x1B18B)
    NearCall(cs1, 0xB18E, spice86_generated_label_call_target_1000_ADBE_01ADBE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B18E_01B18E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B18E_01B18E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B18E_1B18E:
    // MOV byte ptr [0x2788],0x0 (1000_B18E / 0x1B18E)
    UInt8[DS, 0x2788] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0xc6],0x0 (1000_B193 / 0x1B193)
    UInt8[DS, 0xC6] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x1c30],0x0 (1000_B198 / 0x1B198)
    UInt8[DS, 0x1C30] = 0x0;
    State.IncCycles();
    // CALL 0x1000:ca01 (1000_B19D / 0x1B19D)
    NearCall(cs1, 0xB1A0, spice86_generated_label_call_target_1000_CA01_01CA01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B1A0_01B1A0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B1A0_01B1A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1A0_1B1A0:
    // CALL 0x1000:0a3e (1000_B1A0 / 0x1B1A0)
    NearCall(cs1, 0xB1A3, spice86_generated_label_call_target_1000_0A3E_010A3E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B1A3_01B1A3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B1A3_01B1A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1A3_1B1A3:
    // CALL 0x1000:9901 (1000_B1A3 / 0x1B1A3)
    NearCall(cs1, 0xB1A6, spice86_generated_label_call_target_1000_9901_019901);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B1A6_01B1A6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B1A6_01B1A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1A6_1B1A6:
    // MOV AX,0x26 (1000_B1A6 / 0x1B1A6)
    AX = 0x26;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_B1A9 / 0x1B1A9)
    NearCall(cs1, 0xB1AC, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B1AC_01B1AC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B1AC_01B1AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1AC_1B1AC:
    // JMP 0x1000:1877 (1000_B1AC / 0x1B1AC)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_186B_01186B, 0x11877 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B1AF_01B1AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1AF_1B1AF:
    // PUSH DX (1000_B1AF / 0x1B1AF)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_B1B0 / 0x1B1B0)
    NearCall(cs1, 0xB1B3, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B1B3_01B1B3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B1B3_01B1B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1B3_1B1B3:
    // CALL 0x1000:c137 (1000_B1B3 / 0x1B1B3)
    NearCall(cs1, 0xB1B6, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_B1B6_1B1B6:
    // MOV AX,0xb (1000_B1B6 / 0x1B1B6)
    AX = 0xB;
    State.IncCycles();
    // OR DX,DX (1000_B1B9 / 0x1B1B9)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JS 0x1000:b1be (1000_B1BB / 0x1B1BB)
    if(SignFlag) {
      goto label_1000_B1BE_1B1BE;
    }
    State.IncCycles();
    // DEC AX (1000_B1BD / 0x1B1BD)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    label_1000_B1BE_1B1BE:
    // MOV BX,0x9e (1000_B1BE / 0x1B1BE)
    BX = 0x9E;
    State.IncCycles();
    // MOV DX,0x1b (1000_B1C1 / 0x1B1C1)
    DX = 0x1B;
    State.IncCycles();
    // PUSH AX (1000_B1C4 / 0x1B1C4)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_B1C5 / 0x1B1C5)
    NearCall(cs1, 0xB1C8, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    State.IncCycles();
    label_1000_B1C8_1B1C8:
    // MOV AX,0xa (1000_B1C8 / 0x1B1C8)
    AX = 0xA;
    State.IncCycles();
    // CALL 0x1000:e387 (1000_B1CB / 0x1B1CB)
    NearCall(cs1, 0xB1CE, spice86_generated_label_call_target_1000_E387_01E387);
    State.IncCycles();
    label_1000_B1CE_1B1CE:
    // POP AX (1000_B1CE / 0x1B1CE)
    AX = Stack.Pop();
    State.IncCycles();
    // INC AX (1000_B1CF / 0x1B1CF)
    AX++;
    State.IncCycles();
    // CMP AX,0xb (1000_B1D0 / 0x1B1D0)
    Alu.Sub16(AX, 0xB);
    State.IncCycles();
    // JZ 0x1000:b1d8 (1000_B1D3 / 0x1B1D3)
    if(ZeroFlag) {
      goto label_1000_B1D8_1B1D8;
    }
    State.IncCycles();
    // SUB AX,0x2 (1000_B1D5 / 0x1B1D5)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    State.IncCycles();
    label_1000_B1D8_1B1D8:
    // CALL 0x1000:c22f (1000_B1D8 / 0x1B1D8)
    NearCall(cs1, 0xB1DB, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_B1DB_1B1DB:
    // MOV AX,0xa (1000_B1DB / 0x1B1DB)
    AX = 0xA;
    State.IncCycles();
    // CALL 0x1000:e387 (1000_B1DE / 0x1B1DE)
    NearCall(cs1, 0xB1E1, spice86_generated_label_call_target_1000_E387_01E387);
    State.IncCycles();
    label_1000_B1E1_1B1E1:
    // MOV SI,0x1af4 (1000_B1E1 / 0x1B1E1)
    SI = 0x1AF4;
    State.IncCycles();
    // MOV CX,0x1 (1000_B1E4 / 0x1B1E4)
    CX = 0x1;
    State.IncCycles();
    // CALL 0x1000:d1f2 (1000_B1E7 / 0x1B1E7)
    NearCall(cs1, 0xB1EA, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    State.IncCycles();
    label_1000_B1EA_1B1EA:
    // POP DX (1000_B1EA / 0x1B1EA)
    DX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c07c (1000_B1EB / 0x1B1EB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B1EE_01B1EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B1EE_1B1EE:
    // CALLF [0x3959] (1000_B1EE / 0x1B1EE)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_B1EE = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_B1EE) {
      case 0x2362B : FarCall(cs1, 0xB1F2, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B1EE));
        break;
    }
    State.IncCycles();
    label_1000_B1F2_1B1F2:
    // CALL 0x1000:aeb7 (1000_B1F2 / 0x1B1F2)
    NearCall(cs1, 0xB1F5, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    State.IncCycles();
    label_1000_B1F5_1B1F5:
    // MOV byte ptr [0xdc2b],0x1 (1000_B1F5 / 0x1B1F5)
    UInt8[DS, 0xDC2B] = 0x1;
    State.IncCycles();
    // MOV AL,0x34 (1000_B1FA / 0x1B1FA)
    AL = 0x34;
    State.IncCycles();
    // MOV BP,0xb236 (1000_B1FC / 0x1B1FC)
    BP = 0xB236;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_B1FF / 0x1B1FF)
    NearCall(cs1, 0xB202, spice86_generated_label_call_target_1000_C108_01C108);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B202_01B202, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B202_01B202(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B202_1B202:
    // CALL 0x1000:c08e (1000_B202 / 0x1B202)
    NearCall(cs1, 0xB205, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    label_1000_B205_1B205:
    // MOV byte ptr [0xce80],0x0 (1000_B205 / 0x1B205)
    UInt8[DS, 0xCE80] = 0x0;
    State.IncCycles();
    // CALL 0x1000:de4e (1000_B20A / 0x1B20A)
    NearCall(cs1, 0xB20D, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    State.IncCycles();
    label_1000_B20D_1B20D:
    // CALL 0x1000:c9e8 (1000_B20D / 0x1B20D)
    NearCall(cs1, 0xB210, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    State.IncCycles();
    label_1000_B210_1B210:
    // JC 0x1000:b217 (1000_B210 / 0x1B210)
    if(CarryFlag) {
      goto label_1000_B217_1B217;
    }
    State.IncCycles();
    // CALL 0x1000:cc85 (1000_B212 / 0x1B212)
    NearCall(cs1, 0xB215, spice86_generated_label_call_target_1000_CC85_01CC85);
    State.IncCycles();
    label_1000_B215_1B215:
    // JZ 0x1000:b20d (1000_B215 / 0x1B215)
    if(ZeroFlag) {
      goto label_1000_B20D_1B20D;
    }
    State.IncCycles();
    label_1000_B217_1B217:
    // CALL 0x1000:ca01 (1000_B217 / 0x1B217)
    NearCall(cs1, 0xB21A, spice86_generated_label_call_target_1000_CA01_01CA01);
    State.IncCycles();
    label_1000_B21A_1B21A:
    // INC byte ptr [0xce80] (1000_B21A / 0x1B21A)
    UInt8[DS, 0xCE80] = Alu.Inc8(UInt8[DS, 0xCE80]);
    State.IncCycles();
    // CALL 0x1000:ac14 (1000_B21E / 0x1B21E)
    NearCall(cs1, 0xB221, spice86_generated_label_call_target_1000_AC14_01AC14);
    State.IncCycles();
    label_1000_B221_1B221:
    // CALL 0x1000:c07c (1000_B221 / 0x1B221)
    NearCall(cs1, 0xB224, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_B224_1B224:
    // CALLF [0x3969] (1000_B224 / 0x1B224)
    // Indirect call to [0x3969], generating possible targets from emulator records
    uint targetAddress_1000_B224 = (uint)(UInt16[DS, 0x396B] * 0x10 + UInt16[DS, 0x3969] - cs1 * 0x10);
    switch(targetAddress_1000_B224) {
      case 0x23637 : FarCall(cs1, 0xB228, spice86_generated_label_call_target_334B_0187_033637); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B224));
        break;
    }
    State.IncCycles();
    label_1000_B228_1B228:
    // MOV AL,0x34 (1000_B228 / 0x1B228)
    AL = 0x34;
    State.IncCycles();
    // MOV BP,0xb23f (1000_B22A / 0x1B22A)
    BP = 0xB23F;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_B22D / 0x1B22D)
    NearCall(cs1, 0xB230, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    label_1000_B230_1B230:
    // CALL 0x1000:c412 (1000_B230 / 0x1B230)
    NearCall(cs1, 0xB233, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    label_1000_B233_1B233:
    // JMP 0x1000:abc6 (1000_B233 / 0x1B233)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_ABC6_01ABC6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B236_01B236(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B236_1B236:
    // CALL 0x1000:c0ad (1000_B236 / 0x1B236)
    NearCall(cs1, 0xB239, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B239_01B239, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B239_01B239(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B239_1B239:
    // MOV AX,[0x243e] (1000_B239 / 0x1B239)
    AX = UInt16[DS, 0x243E];
    State.IncCycles();
    // JMP 0x1000:ca1b (1000_B23C / 0x1B23C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B23F_01B23F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B23F_1B23F:
    // CALL 0x1000:c0ad (1000_B23F / 0x1B23F)
    NearCall(cs1, 0xB242, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B242_01B242, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B242_01B242(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B242_1B242:
    // MOV CX,0x12 (1000_B242 / 0x1B242)
    CX = 0x12;
    State.IncCycles();
    // MOV SI,0x1ae6 (1000_B245 / 0x1B245)
    SI = 0x1AE6;
    State.IncCycles();
    // CALL 0x1000:d1f2 (1000_B248 / 0x1B248)
    NearCall(cs1, 0xB24B, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B24B_01B24B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B24B_01B24B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B24B_1B24B:
    // CALL 0x1000:d397 (1000_B24B / 0x1B24B)
    NearCall(cs1, 0xB24E, spice86_generated_label_call_target_1000_D397_01D397);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B24E_01B24E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B24E_01B24E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B24E_1B24E:
    // CALL 0x1000:b039 (1000_B24E / 0x1B24E)
    NearCall(cs1, 0xB251, spice86_generated_label_call_target_1000_B039_01B039);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B251_01B251, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B251_01B251(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B251_1B251:
    // JMP 0x1000:9901 (1000_B251 / 0x1B251)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_9901_019901, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B254_01B254(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B254_1B254:
    // PUSH AX (1000_B254 / 0x1B254)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_B255 / 0x1B255)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_B256 / 0x1B256)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_B257 / 0x1B257)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x2426 (1000_B258 / 0x1B258)
    DI = 0x2426;
    State.IncCycles();
    // MOV CX,0xc (1000_B25B / 0x1B25B)
    CX = 0xC;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASW ES:DI (1000_B25E / 0x1B25E)
      Alu.Sub16(AX, UInt16[ES, DI]);
      DI = (ushort)(DI + Direction16);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // MOV AX,0x0 (1000_B260 / 0x1B260)
    AX = 0x0;
    State.IncCycles();
    // JNZ 0x1000:b26a (1000_B263 / 0x1B263)
    if(!ZeroFlag) {
      goto label_1000_B26A_1B26A;
    }
    State.IncCycles();
    // MOV AX,0x24 (1000_B265 / 0x1B265)
    AX = 0x24;
    State.IncCycles();
    // SUB AX,CX (1000_B268 / 0x1B268)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    label_1000_B26A_1B26A:
    // MOV [0x243e],AX (1000_B26A / 0x1B26A)
    UInt16[DS, 0x243E] = AX;
    State.IncCycles();
    // POP SI (1000_B26D / 0x1B26D)
    SI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_B26E / 0x1B26E)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_B26F / 0x1B26F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_B270_01B270(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B270_1B270:
    // MOV SI,0x242a (1000_B270 / 0x1B270)
    SI = 0x242A;
    State.IncCycles();
    // MOV DI,word ptr [0x11bd] (1000_B273 / 0x1B273)
    DI = UInt16[DS, 0x11BD];
    State.IncCycles();
    // PUSH CS (1000_B277 / 0x1B277)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_B278 / 0x1B278)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0xa (1000_B279 / 0x1B279)
    CX = 0xA;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_B27C / 0x1B27C)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOV word ptr [0x11bd],DI (1000_B27E / 0x1B27E)
    UInt16[DS, 0x11BD] = DI;
    State.IncCycles();
    // XOR AX,AX (1000_B282 / 0x1B282)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_B284 / 0x1B284)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV byte ptr CS:[0xb270],0xc3 (1000_B285 / 0x1B285)
    UInt8[cs1, 0xB270] = 0xC3;
    State.IncCycles();
    // RET  (1000_B28B / 0x1B28B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B28C_01B28C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B28C_1B28C:
    // MOV BP,0x207a (1000_B28C / 0x1B28C)
    BP = 0x207A;
    State.IncCycles();
    // CALL 0x1000:b2aa (1000_B28F / 0x1B28F)
    NearCall(cs1, 0xB292, spice86_generated_label_call_target_1000_B2AA_01B2AA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B292_01B292, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B292_01B292(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B292_1B292:
    // MOV CX,0x8000 (1000_B292 / 0x1B292)
    CX = 0x8000;
    State.IncCycles();
    // MOV SI,0x207c (1000_B295 / 0x1B295)
    SI = 0x207C;
    State.IncCycles();
    // CALL 0x1000:b30f (1000_B298 / 0x1B298)
    NearCall(cs1, 0xB29B, spice86_generated_label_call_target_1000_B30F_01B30F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B29B_01B29B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B29B_01B29B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B29B_1B29B:
    // JMP 0x1000:d397 (1000_B29B / 0x1B29B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D397_01D397, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B2AA_01B2AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2AA_1B2AA:
    // CALL 0x1000:b2b9 (1000_B2AA / 0x1B2AA)
    NearCall(cs1, 0xB2AD, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B2AD_01B2AD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B2AD_01B2AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2AD_1B2AD:
    // MOV BX,0xb2b3 (1000_B2AD / 0x1B2AD)
    BX = 0xB2B3;
    State.IncCycles();
    // JMP 0x1000:d323 (1000_B2B0 / 0x1B2B0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B2B3_01B2B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2B3_1B2B3:
    // DEC byte ptr [0x2788] (1000_B2B3 / 0x1B2B3)
    UInt8[DS, 0x2788] = Alu.Dec8(UInt8[DS, 0x2788]);
    State.IncCycles();
    // JNS 0x1000:b2bd (1000_B2B7 / 0x1B2B7)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
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
  
  public virtual Action spice86_generated_label_call_target_1000_B2B9_01B2B9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xB2BD: goto label_1000_B2BD_1B2BD;break; // Target of external jump from 0x1B2B7
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_B2B9_1B2B9:
    // INC byte ptr [0x2788] (1000_B2B9 / 0x1B2B9)
    UInt8[DS, 0x2788] = Alu.Inc8(UInt8[DS, 0x2788]);
    State.IncCycles();
    label_1000_B2BD_1B2BD:
    // RET  (1000_B2BD / 0x1B2BD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B2BE_01B2BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2BE_1B2BE:
    // MOV byte ptr [0x2788],0x0 (1000_B2BE / 0x1B2BE)
    UInt8[DS, 0x2788] = 0x0;
    State.IncCycles();
    // RET  (1000_B2C3 / 0x1B2C3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B2C4_01B2C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2C4_1B2C4:
    // CMP byte ptr [0x38af],0x32 (1000_B2C4 / 0x1B2C4)
    Alu.Sub8(UInt8[DS, 0x38AF], 0x32);
    State.IncCycles();
    // JA 0x1000:b30e (1000_B2C9 / 0x1B2C9)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_B30E / 0x1B30E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_B2CB / 0x1B2CB)
    AX = UInt16[DS, SI];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B2CD_01B2CD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B2CD_01B2CD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2CD_1B2CD:
    // CALL 0x1000:e270 (1000_B2CD / 0x1B2CD)
    NearCall(cs1, 0xB2D0, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B2D0_01B2D0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B2D0_01B2D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2D0_1B2D0:
    // PUSH ES (1000_B2D0 / 0x1B2D0)
    Stack.Push(ES);
    State.IncCycles();
    // AND AX,0xfff (1000_B2D1 / 0x1B2D1)
    // AX &= 0xFFF;
    AX = Alu.And16(AX, 0xFFF);
    State.IncCycles();
    // MOV SI,AX (1000_B2D4 / 0x1B2D4)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_B2D6 / 0x1B2D6)
    NearCall(cs1, 0xB2D9, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_B2D9_1B2D9:
    // CALL 0x1000:d03c (1000_B2D9 / 0x1B2D9)
    NearCall(cs1, 0xB2DC, spice86_generated_label_call_target_1000_D03C_01D03C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B2DC_01B2DC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B2DC_01B2DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B2DC_1B2DC:
    // CALL 0x1000:d03c (1000_B2DC / 0x1B2DC)
    NearCall(cs1, 0xB2DF, spice86_generated_label_call_target_1000_D03C_01D03C);
    State.IncCycles();
    label_1000_B2DF_1B2DF:
    // MOV AX,[0xd816] (1000_B2DF / 0x1B2DF)
    AX = UInt16[DS, 0xD816];
    State.IncCycles();
    // PUSH AX (1000_B2E2 / 0x1B2E2)
    Stack.Push(AX);
    State.IncCycles();
    // ADD AX,0x3 (1000_B2E3 / 0x1B2E3)
    AX += 0x3;
    State.IncCycles();
    // SHR AX,1 (1000_B2E6 / 0x1B2E6)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_B2E8 / 0x1B2E8)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_B2EA / 0x1B2EA)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_B2EC / 0x1B2EC)
    AX >>= 0x1;
    State.IncCycles();
    // INC AX (1000_B2EE / 0x1B2EE)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // CALL 0x1000:e2e3 (1000_B2EF / 0x1B2EF)
    NearCall(cs1, 0xB2F2, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    State.IncCycles();
    label_1000_B2F2_1B2F2:
    // LEA DI,[SI + 0x3] (1000_B2F2 / 0x1B2F2)
    DI = (ushort)(SI + 0x3);
    State.IncCycles();
    // MOV SI,0x117 (1000_B2F5 / 0x1B2F5)
    SI = 0x117;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_B2F8 / 0x1B2F8)
    NearCall(cs1, 0xB2FB, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_B2FB_1B2FB:
    // POP AX (1000_B2FB / 0x1B2FB)
    AX = Stack.Pop();
    State.IncCycles();
    // AND AL,0xf (1000_B2FC / 0x1B2FC)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // MOV AH,0xa (1000_B2FE / 0x1B2FE)
    AH = 0xA;
    State.IncCycles();
    // MUL AH (1000_B300 / 0x1B300)
    Cpu.Mul8(AH);
    State.IncCycles();
    // ADD SI,AX (1000_B302 / 0x1B302)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV CX,0xa (1000_B304 / 0x1B304)
    CX = 0xA;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,ES:SI (1000_B307 / 0x1B307)
      UInt8[ES, DI] = UInt8[ES, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP ES (1000_B30A / 0x1B30A)
    ES = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_B30B / 0x1B30B)
    NearCall(cs1, 0xB30E, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_B30E_1B30E:
    // RET  (1000_B30E / 0x1B30E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B30F_01B30F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B30F_1B30F:
    // MOV DI,0x38a8 (1000_B30F / 0x1B30F)
    DI = 0x38A8;
    State.IncCycles();
    // MOV byte ptr [DI + 0x7],0x31 (1000_B312 / 0x1B312)
    UInt8[DS, (ushort)(DI + 0x7)] = 0x31;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B316_01B316, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B316_01B316(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B316_1B316:
    // MOV DX,DI (1000_B316 / 0x1B316)
    DX = DI;
    State.IncCycles();
    // CALL 0x1000:f2fc (1000_B318 / 0x1B318)
    NearCall(cs1, 0xB31B, spice86_generated_label_call_target_1000_F2FC_01F2FC);
    State.IncCycles();
    label_1000_B31B_1B31B:
    // MOV AX,0x3d00 (1000_B31B / 0x1B31B)
    AX = 0x3D00;
    State.IncCycles();
    // INT 0x21 (1000_B31E / 0x1B31E)
    Interrupt(0x21);
    State.IncCycles();
    // JC 0x1000:b33c (1000_B320 / 0x1B320)
    if(CarryFlag) {
      goto label_1000_B33C_1B33C;
    }
    State.IncCycles();
    // MOV BX,AX (1000_B322 / 0x1B322)
    BX = AX;
    State.IncCycles();
    // MOV DX,0xd816 (1000_B324 / 0x1B324)
    DX = 0xD816;
    State.IncCycles();
    // PUSH CX (1000_B327 / 0x1B327)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,0x2 (1000_B328 / 0x1B328)
    CX = 0x2;
    State.IncCycles();
    // MOV AH,0x3f (1000_B32B / 0x1B32B)
    AH = 0x3F;
    State.IncCycles();
    // INT 0x21 (1000_B32D / 0x1B32D)
    Interrupt(0x21);
    State.IncCycles();
    // CMP AX,CX (1000_B32F / 0x1B32F)
    Alu.Sub16(AX, CX);
    State.IncCycles();
    // POP CX (1000_B331 / 0x1B331)
    CX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:b33c (1000_B332 / 0x1B332)
    if(CarryFlag) {
      goto label_1000_B33C_1B33C;
    }
    State.IncCycles();
    // MOV AH,0x3e (1000_B334 / 0x1B334)
    AH = 0x3E;
    State.IncCycles();
    // INT 0x21 (1000_B336 / 0x1B336)
    Interrupt(0x21);
    State.IncCycles();
    // CALL 0x1000:b2c4 (1000_B338 / 0x1B338)
    NearCall(cs1, 0xB33B, spice86_generated_label_call_target_1000_B2C4_01B2C4);
    State.IncCycles();
    label_1000_B33B_1B33B:
    // CLC  (1000_B33B / 0x1B33B)
    CarryFlag = false;
    State.IncCycles();
    label_1000_B33C_1B33C:
    // SBB AX,AX (1000_B33C / 0x1B33C)
    AX = Alu.Sbb16(AX, AX);
    State.IncCycles();
    // CMP CH,0x80 (1000_B33E / 0x1B33E)
    Alu.Sub8(CH, 0x80);
    State.IncCycles();
    // JNZ 0x1000:b345 (1000_B341 / 0x1B341)
    if(!ZeroFlag) {
      goto label_1000_B345_1B345;
    }
    State.IncCycles();
    // NOT AX (1000_B343 / 0x1B343)
    AX = (ushort)~AX;
    State.IncCycles();
    label_1000_B345_1B345:
    // AND AX,CX (1000_B345 / 0x1B345)
    AX &= CX;
    State.IncCycles();
    // AND word ptr [SI],0x3fff (1000_B347 / 0x1B347)
    // UInt16[DS, SI] &= 0x3FFF;
    UInt16[DS, SI] = Alu.And16(UInt16[DS, SI], 0x3FFF);
    State.IncCycles();
    // OR word ptr [SI],AX (1000_B34B / 0x1B34B)
    UInt16[DS, SI] |= AX;
    State.IncCycles();
    // ADD SI,0x4 (1000_B34D / 0x1B34D)
    SI += 0x4;
    State.IncCycles();
    // INC byte ptr [DI + 0x7] (1000_B350 / 0x1B350)
    UInt8[DS, (ushort)(DI + 0x7)]++;
    State.IncCycles();
    // CMP word ptr [SI],0xa3 (1000_B353 / 0x1B353)
    Alu.Sub16(UInt16[DS, SI], 0xA3);
    State.IncCycles();
    // JNZ 0x1000:b316 (1000_B357 / 0x1B357)
    if(!ZeroFlag) {
      goto label_1000_B316_1B316;
    }
    State.IncCycles();
    // RET  (1000_B359 / 0x1B359)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B35A_01B35A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B35A_1B35A:
    // MOV BX,word ptr [0x2] (1000_B35A / 0x1B35A)
    BX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV word ptr [0xd816],BX (1000_B35E / 0x1B35E)
    UInt16[DS, 0xD816] = BX;
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_B362 / 0x1B362)
    NearCall(cs1, 0xB365, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B365_01B365, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B365_01B365(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B365_1B365:
    // CALL 0x1000:b2cd (1000_B365 / 0x1B365)
    NearCall(cs1, 0xB368, spice86_generated_label_call_target_1000_B2CD_01B2CD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B368_01B368, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B368_01B368(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B368_1B368:
    // PUSH CX (1000_B368 / 0x1B368)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:d48a (1000_B369 / 0x1B369)
    NearCall(cs1, 0xB36C, spice86_generated_label_call_target_1000_D48A_01D48A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B36C_01B36C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B36C_01B36C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B36C_1B36C:
    // POP CX (1000_B36C / 0x1B36C)
    CX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:b389 (1000_B36D / 0x1B36D)
    NearCall(cs1, 0xB370, spice86_generated_label_call_target_1000_B389_01B389);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B370_01B370, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B370_01B370(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B370_1B370:
    // PUSHF  (1000_B370 / 0x1B370)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // MOV AX,0x113 (1000_B371 / 0x1B371)
    AX = 0x113;
    State.IncCycles();
    // ADC AL,0x0 (1000_B374 / 0x1B374)
    AL = Alu.Adc8(AL, 0x0);
    State.IncCycles();
    // MOV CX,0x4 (1000_B376 / 0x1B376)
    CX = 0x4;
    State.IncCycles();
    // CALL 0x1000:d48a (1000_B379 / 0x1B379)
    NearCall(cs1, 0xB37C, spice86_generated_label_call_target_1000_D48A_01D48A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B37C_01B37C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B37C_01B37C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B37C_1B37C:
    // MOV AX,0x12c (1000_B37C / 0x1B37C)
    AX = 0x12C;
    State.IncCycles();
    // CALL 0x1000:ddb0 (1000_B37F / 0x1B37F)
    NearCall(cs1, 0xB382, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B382_01B382, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B382_01B382(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B382_1B382:
    // POPF  (1000_B382 / 0x1B382)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:b388 (1000_B383 / 0x1B383)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_B388 / 0x1B388)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:d2e2 (1000_B385 / 0x1B385)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_B388_1B388:
    // RET  (1000_B388 / 0x1B388)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B389_01B389(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B389_1B389:
    // ADD CL,0x31 (1000_B389 / 0x1B389)
    // CL += 0x31;
    CL = Alu.Add8(CL, 0x31);
    State.IncCycles();
    // MOV byte ptr [0x38af],CL (1000_B38C / 0x1B38C)
    UInt8[DS, 0x38AF] = CL;
    State.IncCycles();
    // CALL 0x1000:b427 (1000_B390 / 0x1B390)
    NearCall(cs1, 0xB393, spice86_generated_label_call_target_1000_B427_01B427);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B393_01B393, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B393_01B393(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B393_1B393:
    // MOV AX,[0x2] (1000_B393 / 0x1B393)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // PUSH DS (1000_B396 / 0x1B396)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_B397 / 0x1B397)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_B398 / 0x1B398)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,DI (1000_B399 / 0x1B399)
    SI = DI;
    State.IncCycles();
    // XOR DI,DI (1000_B39B / 0x1B39B)
    DI = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_B39D / 0x1B39D)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CALL 0x1000:b4ea (1000_B39E / 0x1B39E)
    NearCall(cs1, 0xB3A1, spice86_generated_label_call_target_1000_B4EA_01B4EA);
    State.IncCycles();
    label_1000_B3A1_1B3A1:
    // POP DS (1000_B3A1 / 0x1B3A1)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV DX,0x38a8 (1000_B3A2 / 0x1B3A2)
    DX = 0x38A8;
    State.IncCycles();
    // CALL 0x1000:f2fc (1000_B3A5 / 0x1B3A5)
    NearCall(cs1, 0xB3A8, spice86_generated_label_call_target_1000_F2FC_01F2FC);
    State.IncCycles();
    label_1000_B3A8_1B3A8:
    // XOR DI,DI (1000_B3A8 / 0x1B3A8)
    DI = 0;
    State.IncCycles();
    // ADD CX,0x2 (1000_B3AA / 0x1B3AA)
    // CX += 0x2;
    CX = Alu.Add16(CX, 0x2);
    State.IncCycles();
    // JMP 0x1000:f27c (1000_B3AD / 0x1B3AD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_F27C_01F27C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B427_01B427(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B427_1B427:
    // MOV CX,0x578 (1000_B427 / 0x1B427)
    CX = 0x578;
    State.IncCycles();
    // CALL 0x1000:f11c (1000_B42A / 0x1B42A)
    NearCall(cs1, 0xB42D, spice86_generated_label_call_target_1000_F11C_01F11C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B42D_01B42D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B42D_01B42D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B42D_1B42D:
    // MOV DI,0x100 (1000_B42D / 0x1B42D)
    DI = 0x100;
    State.IncCycles();
    // PUSH DI (1000_B430 / 0x1B430)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_B431 / 0x1B431)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH DS (1000_B432 / 0x1B432)
    Stack.Push(DS);
    State.IncCycles();
    // LDS SI,[0xdcfe] (1000_B433 / 0x1B433)
    DS = UInt16[DS, 0xDD00];
    SI = UInt16[DS, 0xDCFE];
    State.IncCycles();
    // XOR SI,SI (1000_B437 / 0x1B437)
    SI = 0;
    State.IncCycles();
    // MOV CX,0xc5fc (1000_B439 / 0x1B439)
    CX = 0xC5FC;
    State.IncCycles();
    // SHR CX,1 (1000_B43C / 0x1B43C)
    CX >>= 0x1;
    State.IncCycles();
    // SHR CX,1 (1000_B43E / 0x1B43E)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    label_1000_B440_1B440:
    // MOV AH,0x3 (1000_B440 / 0x1B440)
    AH = 0x3;
    State.IncCycles();
    label_1000_B442_1B442:
    // LODSB SI (1000_B442 / 0x1B442)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // SHL AL,1 (1000_B443 / 0x1B443)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AL,1 (1000_B445 / 0x1B445)
    AL <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_B447 / 0x1B447)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_B449 / 0x1B449)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JNC 0x1000:b442 (1000_B44B / 0x1B44B)
    if(!CarryFlag) {
      goto label_1000_B442_1B442;
    }
    State.IncCycles();
    // MOV AL,AH (1000_B44D / 0x1B44D)
    AL = AH;
    State.IncCycles();
    // STOSB ES:DI (1000_B44F / 0x1B44F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x1000:b440 (1000_B450 / 0x1B450)
    if(--CX != 0) {
      goto label_1000_B440_1B440;
    }
    State.IncCycles();
    // PUSH CS (1000_B452 / 0x1B452)
    Stack.Push(cs1);
    State.IncCycles();
    // POP DS (1000_B453 / 0x1B453)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0xaa (1000_B454 / 0x1B454)
    SI = 0xAA;
    State.IncCycles();
    // MOV CX,0xa2 (1000_B457 / 0x1B457)
    CX = 0xA2;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B45A / 0x1B45A)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DS (1000_B45C / 0x1B45C)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0xaa76 (1000_B45D / 0x1B45D)
    SI = 0xAA76;
    State.IncCycles();
    // MOV CX,0x11f8 (1000_B460 / 0x1B460)
    CX = 0x11F8;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B463 / 0x1B463)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV SI,0x0 (1000_B465 / 0x1B465)
    SI = 0x0;
    State.IncCycles();
    // MOV CX,0x1261 (1000_B468 / 0x1B468)
    CX = 0x1261;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B46B / 0x1B46B)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP ES (1000_B46D / 0x1B46D)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_B46E / 0x1B46E)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x567a (1000_B46F / 0x1B46F)
    CX = 0x567A;
    State.IncCycles();
    // RET  (1000_B472 / 0x1B472)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B4EA_01B4EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B4EA_1B4EA:
    // MOV DL,0xf7 (1000_B4EA / 0x1B4EA)
    DL = 0xF7;
    State.IncCycles();
    // PUSH DI (1000_B4EC / 0x1B4EC)
    Stack.Push(DI);
    State.IncCycles();
    // ADD DI,0x4 (1000_B4ED / 0x1B4ED)
    DI += 0x4;
    State.IncCycles();
    label_1000_B4F0_1B4F0:
    // XOR DH,DH (1000_B4F0 / 0x1B4F0)
    DH = 0;
    State.IncCycles();
    label_1000_B4F2_1B4F2:
    // LODSB SI (1000_B4F2 / 0x1B4F2)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // INC DH (1000_B4F3 / 0x1B4F3)
    DH++;
    State.IncCycles();
    // CMP AL,byte ptr [SI] (1000_B4F5 / 0x1B4F5)
    Alu.Sub8(AL, UInt8[DS, SI]);
    State.IncCycles();
    // JNZ 0x1000:b504 (1000_B4F7 / 0x1B4F7)
    if(!ZeroFlag) {
      goto label_1000_B504_1B504;
    }
    State.IncCycles();
    // CMP DH,0xff (1000_B4F9 / 0x1B4F9)
    Alu.Sub8(DH, 0xFF);
    State.IncCycles();
    // JZ 0x1000:b504 (1000_B4FC / 0x1B4FC)
    if(ZeroFlag) {
      goto label_1000_B504_1B504;
    }
    State.IncCycles();
    // DEC CX (1000_B4FE / 0x1B4FE)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // OR CX,CX (1000_B4FF / 0x1B4FF)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JNZ 0x1000:b4f2 (1000_B501 / 0x1B501)
    if(!ZeroFlag) {
      goto label_1000_B4F2_1B4F2;
    }
    State.IncCycles();
    // INC CX (1000_B503 / 0x1B503)
    CX++;
    State.IncCycles();
    label_1000_B504_1B504:
    // CMP AL,DL (1000_B504 / 0x1B504)
    Alu.Sub8(AL, DL);
    State.IncCycles();
    // JZ 0x1000:b512 (1000_B506 / 0x1B506)
    if(ZeroFlag) {
      goto label_1000_B512_1B512;
    }
    State.IncCycles();
    // CMP DH,0x1 (1000_B508 / 0x1B508)
    Alu.Sub8(DH, 0x1);
    State.IncCycles();
    // JZ 0x1000:b51c (1000_B50B / 0x1B50B)
    if(ZeroFlag) {
      goto label_1000_B51C_1B51C;
    }
    State.IncCycles();
    // CMP DH,0x2 (1000_B50D / 0x1B50D)
    Alu.Sub8(DH, 0x2);
    State.IncCycles();
    // JZ 0x1000:b52f (1000_B510 / 0x1B510)
    if(ZeroFlag) {
      goto label_1000_B52F_1B52F;
    }
    State.IncCycles();
    label_1000_B512_1B512:
    // MOV AH,AL (1000_B512 / 0x1B512)
    AH = AL;
    State.IncCycles();
    // MOV AL,DL (1000_B514 / 0x1B514)
    AL = DL;
    State.IncCycles();
    // STOSB ES:DI (1000_B516 / 0x1B516)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,DH (1000_B517 / 0x1B517)
    AL = DH;
    State.IncCycles();
    // STOSB ES:DI (1000_B519 / 0x1B519)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // MOV AL,AH (1000_B51A / 0x1B51A)
    AL = AH;
    State.IncCycles();
    label_1000_B51C_1B51C:
    // STOSB ES:DI (1000_B51C / 0x1B51C)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x1000:b4f0 (1000_B51D / 0x1B51D)
    if(--CX != 0) {
      goto label_1000_B4F0_1B4F0;
    }
    State.IncCycles();
    // MOV CX,DI (1000_B51F / 0x1B51F)
    CX = DI;
    State.IncCycles();
    // XOR AX,AX (1000_B521 / 0x1B521)
    AX = 0;
    State.IncCycles();
    // STOSW ES:DI (1000_B523 / 0x1B523)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // POP DI (1000_B524 / 0x1B524)
    DI = Stack.Pop();
    State.IncCycles();
    // SUB CX,DI (1000_B525 / 0x1B525)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    State.IncCycles();
    // MOV word ptr ES:[DI],DX (1000_B527 / 0x1B527)
    UInt16[ES, DI] = DX;
    State.IncCycles();
    // MOV word ptr ES:[DI + 0x2],CX (1000_B52A / 0x1B52A)
    UInt16[ES, (ushort)(DI + 0x2)] = CX;
    State.IncCycles();
    // RET  (1000_B52E / 0x1B52E)
    return NearRet();
    State.IncCycles();
    label_1000_B52F_1B52F:
    // STOSB ES:DI (1000_B52F / 0x1B52F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // JMP 0x1000:b51c (1000_B530 / 0x1B530)
    goto label_1000_B51C_1B51C;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B532_01B532(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B532_1B532:
    // PUSH DX (1000_B532 / 0x1B532)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:b58b (1000_B533 / 0x1B533)
    NearCall(cs1, 0xB536, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    label_1000_B536_1B536:
    // POP DX (1000_B536 / 0x1B536)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV AL,byte ptr ES:[DI] (1000_B537 / 0x1B537)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // RET  (1000_B53A / 0x1B53A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B53B_01B53B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B53B_1B53B:
    // PUSH BX (1000_B53B / 0x1B53B)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_B53C / 0x1B53C)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_B53D / 0x1B53D)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH AX (1000_B53E / 0x1B53E)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:b58b (1000_B53F / 0x1B53F)
    NearCall(cs1, 0xB542, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    label_1000_B542_1B542:
    // POP AX (1000_B542 / 0x1B542)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV CX,AX (1000_B543 / 0x1B543)
    CX = AX;
    State.IncCycles();
    // SHR AX,1 (1000_B545 / 0x1B545)
    AX >>= 0x1;
    State.IncCycles();
    // SUB DI,AX (1000_B547 / 0x1B547)
    DI -= AX;
    State.IncCycles();
    // SUB DX,AX (1000_B549 / 0x1B549)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    State.IncCycles();
    // JNC 0x1000:b551 (1000_B54B / 0x1B54B)
    if(!CarryFlag) {
      goto label_1000_B551_1B551;
    }
    State.IncCycles();
    // ADD DX,BP (1000_B54D / 0x1B54D)
    DX += BP;
    State.IncCycles();
    // ADD DI,BP (1000_B54F / 0x1B54F)
    // DI += BP;
    DI = Alu.Add16(DI, BP);
    State.IncCycles();
    label_1000_B551_1B551:
    // MOV AL,byte ptr ES:[DI] (1000_B551 / 0x1B551)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // MOV byte ptr [SI],AL (1000_B554 / 0x1B554)
    UInt8[DS, SI] = AL;
    State.IncCycles();
    // MOV word ptr [SI + 0x1],DI (1000_B556 / 0x1B556)
    UInt16[DS, (ushort)(SI + 0x1)] = DI;
    State.IncCycles();
    // ADD SI,0x3 (1000_B559 / 0x1B559)
    SI += 0x3;
    State.IncCycles();
    // INC DI (1000_B55C / 0x1B55C)
    DI++;
    State.IncCycles();
    // INC DX (1000_B55D / 0x1B55D)
    DX++;
    State.IncCycles();
    // CMP DX,BP (1000_B55E / 0x1B55E)
    Alu.Sub16(DX, BP);
    State.IncCycles();
    // JC 0x1000:b566 (1000_B560 / 0x1B560)
    if(CarryFlag) {
      goto label_1000_B566_1B566;
    }
    State.IncCycles();
    // SUB DX,BP (1000_B562 / 0x1B562)
    DX -= BP;
    State.IncCycles();
    // SUB DI,BP (1000_B564 / 0x1B564)
    // DI -= BP;
    DI = Alu.Sub16(DI, BP);
    State.IncCycles();
    label_1000_B566_1B566:
    // LOOP 0x1000:b551 (1000_B566 / 0x1B566)
    if(--CX != 0) {
      goto label_1000_B551_1B551;
    }
    State.IncCycles();
    // POP DX (1000_B568 / 0x1B568)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_B569 / 0x1B569)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_B56A / 0x1B56A)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_B56B / 0x1B56B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B56C_01B56C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B56C_1B56C:
    // PUSH CX (1000_B56C / 0x1B56C)
    Stack.Push(CX);
    State.IncCycles();
    // MOV SI,CX (1000_B56D / 0x1B56D)
    SI = CX;
    State.IncCycles();
    // SHR SI,1 (1000_B56F / 0x1B56F)
    SI >>= 0x1;
    State.IncCycles();
    // SUB BX,SI (1000_B571 / 0x1B571)
    BX -= SI;
    State.IncCycles();
    // CMP BX,-0x62 (1000_B573 / 0x1B573)
    Alu.Sub16(BX, 0xFF9E);
    State.IncCycles();
    // JGE 0x1000:b57b (1000_B576 / 0x1B576)
    if(SignFlag == OverflowFlag) {
      goto label_1000_B57B_1B57B;
    }
    State.IncCycles();
    // MOV BX,0xff9e (1000_B578 / 0x1B578)
    BX = 0xFF9E;
    State.IncCycles();
    label_1000_B57B_1B57B:
    // MOV SI,0x9e68 (1000_B57B / 0x1B57B)
    SI = 0x9E68;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B57E_01B57E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B57E_01B57E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B57E_1B57E:
    // PUSH AX (1000_B57E / 0x1B57E)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:b53b (1000_B57F / 0x1B57F)
    NearCall(cs1, 0xB582, spice86_generated_label_call_target_1000_B53B_01B53B);
    State.IncCycles();
    label_1000_B582_1B582:
    // POP AX (1000_B582 / 0x1B582)
    AX = Stack.Pop();
    State.IncCycles();
    // INC BX (1000_B583 / 0x1B583)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // LOOP 0x1000:b57e (1000_B584 / 0x1B584)
    if(--CX != 0) {
      goto label_1000_B57E_1B57E;
    }
    State.IncCycles();
    // MOV SI,0x9e68 (1000_B586 / 0x1B586)
    SI = 0x9E68;
    State.IncCycles();
    // POP CX (1000_B589 / 0x1B589)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_B58A / 0x1B58A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B58B_01B58B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B58B_1B58B:
    // CALL 0x1000:b5a0 (1000_B58B / 0x1B58B)
    NearCall(cs1, 0xB58E, spice86_generated_label_call_target_1000_B5A0_01B5A0);
    State.IncCycles();
    label_1000_B58E_1B58E:
    // LES DI,[0xdcfe] (1000_B58E / 0x1B58E)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    State.IncCycles();
    // ADD DI,AX (1000_B592 / 0x1B592)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // MOV AX,BP (1000_B594 / 0x1B594)
    AX = BP;
    State.IncCycles();
    // MUL DX (1000_B596 / 0x1B596)
    Cpu.Mul16(DX);
    State.IncCycles();
    // SHL AX,1 (1000_B598 / 0x1B598)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // ADC DX,0x0 (1000_B59A / 0x1B59A)
    DX = Alu.Adc16(DX, 0x0);
    State.IncCycles();
    // ADD DI,DX (1000_B59D / 0x1B59D)
    // DI += DX;
    DI = Alu.Add16(DI, DX);
    State.IncCycles();
    // RET  (1000_B59F / 0x1B59F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B5A0_01B5A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B5A0_1B5A0:
    // PUSH BX (1000_B5A0 / 0x1B5A0)
    Stack.Push(BX);
    State.IncCycles();
    // SHL BX,1 (1000_B5A1 / 0x1B5A1)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_B5A3 / 0x1B5A3)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_B5A5 / 0x1B5A5)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // JNS 0x1000:b5b9 (1000_B5A7 / 0x1B5A7)
    if(!SignFlag) {
      goto label_1000_B5B9_1B5B9;
    }
    State.IncCycles();
    // NEG BX (1000_B5A9 / 0x1B5A9)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // MOV AX,word ptr [BX + 0x4948] (1000_B5AB / 0x1B5AB)
    AX = UInt16[DS, (ushort)(BX + 0x4948)];
    State.IncCycles();
    // NEG AX (1000_B5AF / 0x1B5AF)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // MOV BP,word ptr [BX + 0x494a] (1000_B5B1 / 0x1B5B1)
    BP = UInt16[DS, (ushort)(BX + 0x494A)];
    State.IncCycles();
    // SHL BP,1 (1000_B5B5 / 0x1B5B5)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // POP BX (1000_B5B7 / 0x1B5B7)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_B5B8 / 0x1B5B8)
    return NearRet();
    State.IncCycles();
    label_1000_B5B9_1B5B9:
    // MOV AX,word ptr [BX + 0x4948] (1000_B5B9 / 0x1B5B9)
    AX = UInt16[DS, (ushort)(BX + 0x4948)];
    State.IncCycles();
    // MOV BP,word ptr [BX + 0x494a] (1000_B5BD / 0x1B5BD)
    BP = UInt16[DS, (ushort)(BX + 0x494A)];
    State.IncCycles();
    // SHL BP,1 (1000_B5C1 / 0x1B5C1)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // POP BX (1000_B5C3 / 0x1B5C3)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_B5C4 / 0x1B5C4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B5C5_01B5C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B5C5_1B5C5:
    // CALL 0x1000:b58b (1000_B5C5 / 0x1B5C5)
    NearCall(cs1, 0xB5C8, spice86_generated_label_call_target_1000_B58B_01B58B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B5C8_01B5C8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B5C8_01B5C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B5C8_1B5C8:
    // XOR AX,AX (1000_B5C8 / 0x1B5C8)
    AX = 0;
    State.IncCycles();
    // DIV BP (1000_B5CA / 0x1B5CA)
    Cpu.Div16(BP);
    State.IncCycles();
    // MOV DX,AX (1000_B5CC / 0x1B5CC)
    DX = AX;
    State.IncCycles();
    // RET  (1000_B5CE / 0x1B5CE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B5CF_01B5CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B5CF_1B5CF:
    // OR AH,AH (1000_B5CF / 0x1B5CF)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x1000:b5f5 (1000_B5D1 / 0x1B5D1)
    if(ZeroFlag) {
      goto label_1000_B5F5_1B5F5;
    }
    State.IncCycles();
    // JS 0x1000:b5e6 (1000_B5D3 / 0x1B5D3)
    if(SignFlag) {
      goto label_1000_B5E6_1B5E6;
    }
    State.IncCycles();
    // ADD BH,AH (1000_B5D5 / 0x1B5D5)
    // BH += AH;
    BH = Alu.Add8(BH, AH);
    State.IncCycles();
    // JNC 0x1000:b5f5 (1000_B5D7 / 0x1B5D7)
    if(!CarryFlag) {
      goto label_1000_B5F5_1B5F5;
    }
    State.IncCycles();
    // INC BL (1000_B5D9 / 0x1B5D9)
    BL++;
    State.IncCycles();
    // CMP BL,0x62 (1000_B5DB / 0x1B5DB)
    Alu.Sub8(BL, 0x62);
    State.IncCycles();
    // JL 0x1000:b5f5 (1000_B5DE / 0x1B5DE)
    if(SignFlag != OverflowFlag) {
      goto label_1000_B5F5_1B5F5;
    }
    State.IncCycles();
    // DEC BL (1000_B5E0 / 0x1B5E0)
    BL--;
    State.IncCycles();
    // SUB BH,AH (1000_B5E2 / 0x1B5E2)
    // BH -= AH;
    BH = Alu.Sub8(BH, AH);
    State.IncCycles();
    // JMP 0x1000:b5f5 (1000_B5E4 / 0x1B5E4)
    goto label_1000_B5F5_1B5F5;
    State.IncCycles();
    label_1000_B5E6_1B5E6:
    // ADD BH,AH (1000_B5E6 / 0x1B5E6)
    // BH += AH;
    BH = Alu.Add8(BH, AH);
    State.IncCycles();
    // JC 0x1000:b5f5 (1000_B5E8 / 0x1B5E8)
    if(CarryFlag) {
      goto label_1000_B5F5_1B5F5;
    }
    State.IncCycles();
    // DEC BL (1000_B5EA / 0x1B5EA)
    BL--;
    State.IncCycles();
    // CMP BL,0x9e (1000_B5EC / 0x1B5EC)
    Alu.Sub8(BL, 0x9E);
    State.IncCycles();
    // JG 0x1000:b5f5 (1000_B5EF / 0x1B5EF)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_B5F5_1B5F5;
    }
    State.IncCycles();
    // INC BL (1000_B5F1 / 0x1B5F1)
    BL++;
    State.IncCycles();
    // SUB BH,AH (1000_B5F3 / 0x1B5F3)
    // BH -= AH;
    BH = Alu.Sub8(BH, AH);
    State.IncCycles();
    label_1000_B5F5_1B5F5:
    // CBW  (1000_B5F5 / 0x1B5F5)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD DX,AX (1000_B5F6 / 0x1B5F6)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // RET  (1000_B5F8 / 0x1B5F8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B5F9_01B5F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B5F9_1B5F9:
    // SUB DX,word ptr [0xdcf6] (1000_B5F9 / 0x1B5F9)
    DX -= UInt16[DS, 0xDCF6];
    State.IncCycles();
    // SUB BX,word ptr [0xdcf8] (1000_B5FD / 0x1B5FD)
    BX -= UInt16[DS, 0xDCF8];
    State.IncCycles();
    // XOR CX,CX (1000_B601 / 0x1B601)
    CX = 0;
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x80 (1000_B603 / 0x1B603)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    State.IncCycles();
    // JZ 0x1000:b60c (1000_B608 / 0x1B608)
    if(ZeroFlag) {
      goto label_1000_B60C_1B60C;
    }
    State.IncCycles();
    // MOV CL,0x2 (1000_B60A / 0x1B60A)
    CL = 0x2;
    State.IncCycles();
    label_1000_B60C_1B60C:
    // SAR BX,CL (1000_B60C / 0x1B60C)
    BX = Alu.Sar16(BX, CL);
    State.IncCycles();
    // ADD BX,word ptr [0x197e] (1000_B60E / 0x1B60E)
    // BX += UInt16[DS, 0x197E];
    BX = Alu.Add16(BX, UInt16[DS, 0x197E]);
    State.IncCycles();
    // MOV AX,BX (1000_B612 / 0x1B612)
    AX = BX;
    State.IncCycles();
    // JNS 0x1000:b618 (1000_B614 / 0x1B614)
    if(!SignFlag) {
      goto label_1000_B618_1B618;
    }
    State.IncCycles();
    // NEG AX (1000_B616 / 0x1B616)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_B618_1B618:
    // SHL AX,1 (1000_B618 / 0x1B618)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_B61A / 0x1B61A)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_B61C / 0x1B61C)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV SI,0x4948 (1000_B61E / 0x1B61E)
    SI = 0x4948;
    State.IncCycles();
    // ADD SI,AX (1000_B621 / 0x1B621)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // JCXZ 0x1000:b62c (1000_B623 / 0x1B623)
    if(CX == 0) {
      goto label_1000_B62C_1B62C;
    }
    State.IncCycles();
    // SAR DX,CL (1000_B625 / 0x1B625)
    DX = Alu.Sar16(DX, CL);
    State.IncCycles();
    // ADD DX,word ptr [SI + 0x4] (1000_B627 / 0x1B627)
    // DX += UInt16[DS, (ushort)(SI + 0x4)];
    DX = Alu.Add16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JMP 0x1000:b63e (1000_B62A / 0x1B62A)
    goto label_1000_B63E_1B63E;
    State.IncCycles();
    label_1000_B62C_1B62C:
    // ADD DX,word ptr [SI + 0x6] (1000_B62C / 0x1B62C)
    // DX += UInt16[DS, (ushort)(SI + 0x6)];
    DX = Alu.Add16(DX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // MOV CX,word ptr [SI + 0x2] (1000_B62F / 0x1B62F)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SHL CX,1 (1000_B632 / 0x1B632)
    CX <<= 0x1;
    State.IncCycles();
    // CMP DX,CX (1000_B634 / 0x1B634)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JC 0x1000:b640 (1000_B636 / 0x1B636)
    if(CarryFlag) {
      goto label_1000_B640_1B640;
    }
    State.IncCycles();
    // JS 0x1000:b63e (1000_B638 / 0x1B638)
    if(SignFlag) {
      goto label_1000_B63E_1B63E;
    }
    State.IncCycles();
    // SUB DX,CX (1000_B63A / 0x1B63A)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    State.IncCycles();
    // JMP 0x1000:b640 (1000_B63C / 0x1B63C)
    goto label_1000_B640_1B640;
    State.IncCycles();
    label_1000_B63E_1B63E:
    // ADD DX,CX (1000_B63E / 0x1B63E)
    DX += CX;
    State.IncCycles();
    label_1000_B640_1B640:
    // XOR AX,AX (1000_B640 / 0x1B640)
    AX = 0;
    State.IncCycles();
    // DIV CX (1000_B642 / 0x1B642)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV DX,AX (1000_B644 / 0x1B644)
    DX = AX;
    State.IncCycles();
    // RET  (1000_B646 / 0x1B646)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B647_01B647(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B647_1B647:
    // XOR CX,CX (1000_B647 / 0x1B647)
    CX = 0;
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x80 (1000_B649 / 0x1B649)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    State.IncCycles();
    // JZ 0x1000:b652 (1000_B64E / 0x1B64E)
    if(ZeroFlag) {
      goto label_1000_B652_1B652;
    }
    State.IncCycles();
    // MOV CL,0x2 (1000_B650 / 0x1B650)
    CL = 0x2;
    State.IncCycles();
    label_1000_B652_1B652:
    // MOV BP,BX (1000_B652 / 0x1B652)
    BP = BX;
    State.IncCycles();
    // SUB BX,word ptr [0x197e] (1000_B654 / 0x1B654)
    BX -= UInt16[DS, 0x197E];
    State.IncCycles();
    // SHL BX,CL (1000_B658 / 0x1B658)
    BX <<= CL;
    State.IncCycles();
    // ADD BX,word ptr [0xdcf8] (1000_B65A / 0x1B65A)
    BX += UInt16[DS, 0xDCF8];
    State.IncCycles();
    // SHL BP,1 (1000_B65E / 0x1B65E)
    BP <<= 0x1;
    State.IncCycles();
    // SHL BP,1 (1000_B660 / 0x1B660)
    BP <<= 0x1;
    State.IncCycles();
    // SHL BP,1 (1000_B662 / 0x1B662)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // JNS 0x1000:b668 (1000_B664 / 0x1B664)
    if(!SignFlag) {
      goto label_1000_B668_1B668;
    }
    State.IncCycles();
    // NEG BP (1000_B666 / 0x1B666)
    BP = Alu.Sub16(0, BP);
    State.IncCycles();
    label_1000_B668_1B668:
    // MOV BP,word ptr [BP + 0x494a] (1000_B668 / 0x1B668)
    BP = UInt16[SS, (ushort)(BP + 0x494A)];
    State.IncCycles();
    // ADD BP,BP (1000_B66C / 0x1B66C)
    BP += BP;
    State.IncCycles();
    // SUB DX,word ptr [0x197c] (1000_B66E / 0x1B66E)
    // DX -= UInt16[DS, 0x197C];
    DX = Alu.Sub16(DX, UInt16[DS, 0x197C]);
    State.IncCycles();
    // MOV AX,DX (1000_B672 / 0x1B672)
    AX = DX;
    State.IncCycles();
    // IMUL BP (1000_B674 / 0x1B674)
    Cpu.IMul16(BP);
    State.IncCycles();
    // JCXZ 0x1000:b67e (1000_B676 / 0x1B676)
    if(CX == 0) {
      goto label_1000_B67E_1B67E;
    }
    State.IncCycles();
    label_1000_B678_1B678:
    // SHL AX,1 (1000_B678 / 0x1B678)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // RCL DX,1 (1000_B67A / 0x1B67A)
    DX = Alu.Rcl16(DX, 0x1);
    State.IncCycles();
    // LOOP 0x1000:b678 (1000_B67C / 0x1B67C)
    if(--CX != 0) {
      goto label_1000_B678_1B678;
    }
    State.IncCycles();
    label_1000_B67E_1B67E:
    // ADD DX,word ptr [0xdcf6] (1000_B67E / 0x1B67E)
    // DX += UInt16[DS, 0xDCF6];
    DX = Alu.Add16(DX, UInt16[DS, 0xDCF6]);
    State.IncCycles();
    // RET  (1000_B682 / 0x1B682)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_B69A_01B69A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B69A_1B69A:
    // MOV AX,[0x197c] (1000_B69A / 0x1B69A)
    AX = UInt16[DS, 0x197C];
    State.IncCycles();
    // XCHG word ptr [0x1980],AX (1000_B69D / 0x1B69D)
    ushort tmp_1000_B69D = UInt16[DS, 0x1980];
    UInt16[DS, 0x1980] = AX;
    AX = tmp_1000_B69D;
    State.IncCycles();
    // MOV [0x197c],AX (1000_B6A1 / 0x1B6A1)
    UInt16[DS, 0x197C] = AX;
    State.IncCycles();
    // MOV AX,[0x197e] (1000_B6A4 / 0x1B6A4)
    AX = UInt16[DS, 0x197E];
    State.IncCycles();
    // XCHG word ptr [0x1982],AX (1000_B6A7 / 0x1B6A7)
    ushort tmp_1000_B6A7 = UInt16[DS, 0x1982];
    UInt16[DS, 0x1982] = AX;
    AX = tmp_1000_B6A7;
    State.IncCycles();
    // MOV [0x197e],AX (1000_B6AB / 0x1B6AB)
    UInt16[DS, 0x197E] = AX;
    State.IncCycles();
    // MOV AX,[0xdcf6] (1000_B6AE / 0x1B6AE)
    AX = UInt16[DS, 0xDCF6];
    State.IncCycles();
    // XCHG word ptr [0xdcfa],AX (1000_B6B1 / 0x1B6B1)
    ushort tmp_1000_B6B1 = UInt16[DS, 0xDCFA];
    UInt16[DS, 0xDCFA] = AX;
    AX = tmp_1000_B6B1;
    State.IncCycles();
    // MOV [0xdcf6],AX (1000_B6B5 / 0x1B6B5)
    UInt16[DS, 0xDCF6] = AX;
    State.IncCycles();
    // MOV AX,[0xdcf8] (1000_B6B8 / 0x1B6B8)
    AX = UInt16[DS, 0xDCF8];
    State.IncCycles();
    // XCHG word ptr [0xdcfc],AX (1000_B6BB / 0x1B6BB)
    ushort tmp_1000_B6BB = UInt16[DS, 0xDCFC];
    UInt16[DS, 0xDCFC] = AX;
    AX = tmp_1000_B6BB;
    State.IncCycles();
    // MOV [0xdcf8],AX (1000_B6BF / 0x1B6BF)
    UInt16[DS, 0xDCF8] = AX;
    State.IncCycles();
    // RET  (1000_B6C2 / 0x1B6C2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B6C3_01B6C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B6C3_1B6C3:
    // TEST byte ptr [0x46eb],0x80 (1000_B6C3 / 0x1B6C3)
    Alu.And8(UInt8[DS, 0x46EB], 0x80);
    State.IncCycles();
    // JZ 0x1000:b714 (1000_B6C8 / 0x1B6C8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_B714_01B714, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH DS (1000_B6CA / 0x1B6CA)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_B6CB / 0x1B6CB)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0xdcf6],0xa0 (1000_B6CC / 0x1B6CC)
    UInt16[DS, 0xDCF6] = 0xA0;
    State.IncCycles();
    // MOV word ptr [0xdcf8],0x4c (1000_B6D2 / 0x1B6D2)
    UInt16[DS, 0xDCF8] = 0x4C;
    State.IncCycles();
    // MOV CX,0x12 (1000_B6D8 / 0x1B6D8)
    CX = 0x12;
    State.IncCycles();
    // MOV BX,0x4b (1000_B6DB / 0x1B6DB)
    BX = 0x4B;
    State.IncCycles();
    // MOV AX,[0x197e] (1000_B6DE / 0x1B6DE)
    AX = UInt16[DS, 0x197E];
    State.IncCycles();
    // OR AX,AX (1000_B6E1 / 0x1B6E1)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // MOV DX,AX (1000_B6E3 / 0x1B6E3)
    DX = AX;
    State.IncCycles();
    // JNS 0x1000:b6e9 (1000_B6E5 / 0x1B6E5)
    if(!SignFlag) {
      goto label_1000_B6E9_1B6E9;
    }
    State.IncCycles();
    // NEG AX (1000_B6E7 / 0x1B6E7)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_B6E9_1B6E9:
    // CMP AX,BX (1000_B6E9 / 0x1B6E9)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JC 0x1000:b6f8 (1000_B6EB / 0x1B6EB)
    if(CarryFlag) {
      goto label_1000_B6F8_1B6F8;
    }
    State.IncCycles();
    // MOV AX,BX (1000_B6ED / 0x1B6ED)
    AX = BX;
    State.IncCycles();
    // OR DX,DX (1000_B6EF / 0x1B6EF)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNS 0x1000:b6f5 (1000_B6F1 / 0x1B6F1)
    if(!SignFlag) {
      goto label_1000_B6F5_1B6F5;
    }
    State.IncCycles();
    // NEG AX (1000_B6F3 / 0x1B6F3)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_B6F5_1B6F5:
    // MOV [0x197e],AX (1000_B6F5 / 0x1B6F5)
    UInt16[DS, 0x197E] = AX;
    State.IncCycles();
    label_1000_B6F8_1B6F8:
    // MOV BP,0x4948 (1000_B6F8 / 0x1B6F8)
    BP = 0x4948;
    State.IncCycles();
    // MOV DX,word ptr [0x197c] (1000_B6FB / 0x1B6FB)
    DX = UInt16[DS, 0x197C];
    State.IncCycles();
    // MOV AX,[0x197e] (1000_B6FF / 0x1B6FF)
    AX = UInt16[DS, 0x197E];
    State.IncCycles();
    // SUB AX,CX (1000_B702 / 0x1B702)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // LES DI,[0xdcfe] (1000_B704 / 0x1B704)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    State.IncCycles();
    // MOV SI,0x4c60 (1000_B708 / 0x1B708)
    SI = 0x4C60;
    State.IncCycles();
    // MOV BX,word ptr [0xdbda] (1000_B70B / 0x1B70B)
    BX = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // CALLF [0x3929] (1000_B70F / 0x1B70F)
    // Indirect call to [0x3929], generating possible targets from emulator records
    uint targetAddress_1000_B70F = (uint)(UInt16[DS, 0x392B] * 0x10 + UInt16[DS, 0x3929] - cs1 * 0x10);
    switch(targetAddress_1000_B70F) {
      case 0x23607 : FarCall(cs1, 0xB713, spice86_generated_label_call_target_334B_0157_033607); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B70F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B713_01B713, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B713_01B713(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B713_1B713:
    // RET  (1000_B713 / 0x1B713)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B714_01B714(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B714_1B714:
    // MOV DI,0x4c60 (1000_B714 / 0x1B714)
    DI = 0x4C60;
    State.IncCycles();
    // MOV AX,[0x46e7] (1000_B717 / 0x1B717)
    AX = UInt16[DS, 0x46E7];
    State.IncCycles();
    // SUB AX,word ptr [0x46e3] (1000_B71A / 0x1B71A)
    // AX -= UInt16[DS, 0x46E3];
    AX = Alu.Sub16(AX, UInt16[DS, 0x46E3]);
    State.IncCycles();
    // MOV DX,AX (1000_B71E / 0x1B71E)
    DX = AX;
    State.IncCycles();
    // SHR DX,1 (1000_B720 / 0x1B720)
    DX >>= 0x1;
    State.IncCycles();
    // ADD DX,word ptr [0x46e3] (1000_B722 / 0x1B722)
    // DX += UInt16[DS, 0x46E3];
    DX = Alu.Add16(DX, UInt16[DS, 0x46E3]);
    State.IncCycles();
    // MOV word ptr [0xdcf6],DX (1000_B726 / 0x1B726)
    UInt16[DS, 0xDCF6] = DX;
    State.IncCycles();
    // MOV [0xdcf2],AX (1000_B72A / 0x1B72A)
    UInt16[DS, 0xDCF2] = AX;
    State.IncCycles();
    // MOV AX,[0x46e9] (1000_B72D / 0x1B72D)
    AX = UInt16[DS, 0x46E9];
    State.IncCycles();
    // SUB AX,word ptr [0x46e5] (1000_B730 / 0x1B730)
    AX -= UInt16[DS, 0x46E5];
    State.IncCycles();
    // DEC AX (1000_B734 / 0x1B734)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // MOV BX,AX (1000_B735 / 0x1B735)
    BX = AX;
    State.IncCycles();
    // SHR BX,1 (1000_B737 / 0x1B737)
    BX >>= 0x1;
    State.IncCycles();
    // ADD BX,word ptr [0x46e5] (1000_B739 / 0x1B739)
    // BX += UInt16[DS, 0x46E5];
    BX = Alu.Add16(BX, UInt16[DS, 0x46E5]);
    State.IncCycles();
    // MOV word ptr [0xdcf8],BX (1000_B73D / 0x1B73D)
    UInt16[DS, 0xDCF8] = BX;
    State.IncCycles();
    // INC AX (1000_B741 / 0x1B741)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0xdcf4],AX (1000_B742 / 0x1B742)
    UInt16[DS, 0xDCF4] = AX;
    State.IncCycles();
    // DEC AX (1000_B745 / 0x1B745)
    AX--;
    State.IncCycles();
    // SHR AX,1 (1000_B746 / 0x1B746)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV CX,AX (1000_B748 / 0x1B748)
    CX = AX;
    State.IncCycles();
    // MOV BX,0x56 (1000_B74A / 0x1B74A)
    BX = 0x56;
    State.IncCycles();
    // SUB BX,AX (1000_B74D / 0x1B74D)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    // MOV AX,[0x197e] (1000_B74F / 0x1B74F)
    AX = UInt16[DS, 0x197E];
    State.IncCycles();
    // OR AX,AX (1000_B752 / 0x1B752)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // MOV DX,AX (1000_B754 / 0x1B754)
    DX = AX;
    State.IncCycles();
    // JNS 0x1000:b75a (1000_B756 / 0x1B756)
    if(!SignFlag) {
      goto label_1000_B75A_1B75A;
    }
    State.IncCycles();
    // NEG AX (1000_B758 / 0x1B758)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_B75A_1B75A:
    // CMP AX,BX (1000_B75A / 0x1B75A)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JC 0x1000:b769 (1000_B75C / 0x1B75C)
    if(CarryFlag) {
      goto label_1000_B769_1B769;
    }
    State.IncCycles();
    // MOV AX,BX (1000_B75E / 0x1B75E)
    AX = BX;
    State.IncCycles();
    // OR DX,DX (1000_B760 / 0x1B760)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNS 0x1000:b766 (1000_B762 / 0x1B762)
    if(!SignFlag) {
      goto label_1000_B766_1B766;
    }
    State.IncCycles();
    // NEG AX (1000_B764 / 0x1B764)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_B766_1B766:
    // MOV [0x197e],AX (1000_B766 / 0x1B766)
    UInt16[DS, 0x197E] = AX;
    State.IncCycles();
    label_1000_B769_1B769:
    // MOV BP,0x4948 (1000_B769 / 0x1B769)
    BP = 0x4948;
    State.IncCycles();
    // MOV DX,word ptr [0x197c] (1000_B76C / 0x1B76C)
    DX = UInt16[DS, 0x197C];
    State.IncCycles();
    // MOV AX,[0x197e] (1000_B770 / 0x1B770)
    AX = UInt16[DS, 0x197E];
    State.IncCycles();
    // SUB AX,CX (1000_B773 / 0x1B773)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // PUSH AX (1000_B775 / 0x1B775)
    Stack.Push(AX);
    State.IncCycles();
    // MOV CX,word ptr [0xdcf4] (1000_B776 / 0x1B776)
    CX = UInt16[DS, 0xDCF4];
    State.IncCycles();
    // SHL AX,1 (1000_B77A / 0x1B77A)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_B77C / 0x1B77C)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_B77E / 0x1B77E)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JNS 0x1000:b79c (1000_B780 / 0x1B780)
    if(!SignFlag) {
      goto label_1000_B79C_1B79C;
    }
    State.IncCycles();
    // NEG AX (1000_B782 / 0x1B782)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // ADD BP,AX (1000_B784 / 0x1B784)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    label_1000_B786_1B786:
    // PUSH CX (1000_B786 / 0x1B786)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (1000_B787 / 0x1B787)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (1000_B78A / 0x1B78A)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // NEG CX (1000_B78D / 0x1B78D)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // JZ 0x1000:b7a5 (1000_B78F / 0x1B78F)
    if(ZeroFlag) {
      goto label_1000_B7A5_1B7A5;
    }
    State.IncCycles();
    // CALL 0x1000:b7d2 (1000_B791 / 0x1B791)
    NearCall(cs1, 0xB794, spice86_generated_label_call_target_1000_B7D2_01B7D2);
    State.IncCycles();
    label_1000_B794_1B794:
    // SUB BP,0x8 (1000_B794 / 0x1B794)
    // BP -= 0x8;
    BP = Alu.Sub16(BP, 0x8);
    State.IncCycles();
    // POP CX (1000_B797 / 0x1B797)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:b786 (1000_B798 / 0x1B798)
    if(--CX != 0) {
      goto label_1000_B786_1B786;
    }
    State.IncCycles();
    // JMP 0x1000:b7ae (1000_B79A / 0x1B79A)
    goto label_1000_B7AE_1B7AE;
    State.IncCycles();
    label_1000_B79C_1B79C:
    // ADD BP,AX (1000_B79C / 0x1B79C)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    State.IncCycles();
    label_1000_B79E_1B79E:
    // PUSH CX (1000_B79E / 0x1B79E)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (1000_B79F / 0x1B79F)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x2] (1000_B7A2 / 0x1B7A2)
    BX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    label_1000_B7A5_1B7A5:
    // CALL 0x1000:b7d2 (1000_B7A5 / 0x1B7A5)
    NearCall(cs1, 0xB7A8, spice86_generated_label_call_target_1000_B7D2_01B7D2);
    State.IncCycles();
    label_1000_B7A8_1B7A8:
    // ADD BP,0x8 (1000_B7A8 / 0x1B7A8)
    // BP += 0x8;
    BP = Alu.Add16(BP, 0x8);
    State.IncCycles();
    // POP CX (1000_B7AB / 0x1B7AB)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:b79e (1000_B7AC / 0x1B7AC)
    if(--CX != 0) {
      goto label_1000_B79E_1B79E;
    }
    State.IncCycles();
    label_1000_B7AE_1B7AE:
    // MOV ES,word ptr [0xdbda] (1000_B7AE / 0x1B7AE)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV DI,word ptr [0xdcf2] (1000_B7B2 / 0x1B7B2)
    DI = UInt16[DS, 0xDCF2];
    State.IncCycles();
    // MOV CX,word ptr [0xdcf4] (1000_B7B6 / 0x1B7B6)
    CX = UInt16[DS, 0xDCF4];
    State.IncCycles();
    // MOV DX,word ptr [0x46e3] (1000_B7BA / 0x1B7BA)
    DX = UInt16[DS, 0x46E3];
    State.IncCycles();
    // MOV BX,word ptr [0x46e5] (1000_B7BE / 0x1B7BE)
    BX = UInt16[DS, 0x46E5];
    State.IncCycles();
    // MOV SI,0x4c60 (1000_B7C2 / 0x1B7C2)
    SI = 0x4C60;
    State.IncCycles();
    // POP AX (1000_B7C5 / 0x1B7C5)
    AX = Stack.Pop();
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x40 (1000_B7C6 / 0x1B7C6)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    State.IncCycles();
    // JNZ 0x1000:b7d1 (1000_B7CB / 0x1B7CB)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_B7D1 / 0x1B7D1)
      return NearRet();
    }
    State.IncCycles();
    // CALLF [0x390d] (1000_B7CD / 0x1B7CD)
    // Indirect call to [0x390d], generating possible targets from emulator records
    uint targetAddress_1000_B7CD = (uint)(UInt16[DS, 0x390F] * 0x10 + UInt16[DS, 0x390D] - cs1 * 0x10);
    switch(targetAddress_1000_B7CD) {
      case 0x235F2 : FarCall(cs1, 0xB7D1, spice86_generated_label_call_target_334B_0142_0335F2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B7CD));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B7D1_01B7D1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B7D1_01B7D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B7D1_1B7D1:
    // RET  (1000_B7D1 / 0x1B7D1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B7D2_01B7D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B7D2_1B7D2:
    // PUSH DX (1000_B7D2 / 0x1B7D2)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DI (1000_B7D3 / 0x1B7D3)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_B7D4 / 0x1B7D4)
    Stack.Push(DS);
    State.IncCycles();
    // LDS SI,[0xdcfe] (1000_B7D5 / 0x1B7D5)
    DS = UInt16[DS, 0xDD00];
    SI = UInt16[DS, 0xDCFE];
    State.IncCycles();
    // PUSH SS (1000_B7D9 / 0x1B7D9)
    Stack.Push(SS);
    State.IncCycles();
    // POP ES (1000_B7DA / 0x1B7DA)
    ES = Stack.Pop();
    State.IncCycles();
    // ADD SI,CX (1000_B7DB / 0x1B7DB)
    SI += CX;
    State.IncCycles();
    // ADD BX,BX (1000_B7DD / 0x1B7DD)
    // BX += BX;
    BX = Alu.Add16(BX, BX);
    State.IncCycles();
    // MOV AX,DX (1000_B7DF / 0x1B7DF)
    AX = DX;
    State.IncCycles();
    // MUL BX (1000_B7E1 / 0x1B7E1)
    Cpu.Mul16(BX);
    State.IncCycles();
    // MOV word ptr [BP + 0x6],DX (1000_B7E3 / 0x1B7E3)
    UInt16[SS, (ushort)(BP + 0x6)] = DX;
    State.IncCycles();
    // MOV AX,DX (1000_B7E6 / 0x1B7E6)
    AX = DX;
    State.IncCycles();
    // MOV DX,word ptr SS:[0xdcf2] (1000_B7E8 / 0x1B7E8)
    DX = UInt16[SS, 0xDCF2];
    State.IncCycles();
    // CMP BX,DX (1000_B7ED / 0x1B7ED)
    Alu.Sub16(BX, DX);
    State.IncCycles();
    // JNC 0x1000:b7fb (1000_B7EF / 0x1B7EF)
    if(!CarryFlag) {
      goto label_1000_B7FB_1B7FB;
    }
    State.IncCycles();
    // MOV CX,DX (1000_B7F1 / 0x1B7F1)
    CX = DX;
    State.IncCycles();
    // SUB CX,BX (1000_B7F3 / 0x1B7F3)
    CX -= BX;
    State.IncCycles();
    // SHR CX,1 (1000_B7F5 / 0x1B7F5)
    CX >>= 0x1;
    State.IncCycles();
    // ADD DI,CX (1000_B7F7 / 0x1B7F7)
    // DI += CX;
    DI = Alu.Add16(DI, CX);
    State.IncCycles();
    // MOV DX,BX (1000_B7F9 / 0x1B7F9)
    DX = BX;
    State.IncCycles();
    label_1000_B7FB_1B7FB:
    // MOV CX,DX (1000_B7FB / 0x1B7FB)
    CX = DX;
    State.IncCycles();
    // SHR CX,1 (1000_B7FD / 0x1B7FD)
    CX >>= 0x1;
    State.IncCycles();
    // SUB AX,CX (1000_B7FF / 0x1B7FF)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // JNS 0x1000:b805 (1000_B801 / 0x1B801)
    if(!SignFlag) {
      goto label_1000_B805_1B805;
    }
    State.IncCycles();
    // ADD AX,BX (1000_B803 / 0x1B803)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    State.IncCycles();
    label_1000_B805_1B805:
    // MOV CX,DX (1000_B805 / 0x1B805)
    CX = DX;
    State.IncCycles();
    // SUB BX,AX (1000_B807 / 0x1B807)
    BX -= AX;
    State.IncCycles();
    // SUB CX,BX (1000_B809 / 0x1B809)
    // CX -= BX;
    CX = Alu.Sub16(CX, BX);
    State.IncCycles();
    // JNS 0x1000:b813 (1000_B80B / 0x1B80B)
    if(!SignFlag) {
      goto label_1000_B813_1B813;
    }
    State.IncCycles();
    // ADD CX,BX (1000_B80D / 0x1B80D)
    CX += BX;
    State.IncCycles();
    // ADD SI,AX (1000_B80F / 0x1B80F)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // JMP 0x1000:b81d (1000_B811 / 0x1B811)
    goto label_1000_B81D_1B81D;
    State.IncCycles();
    label_1000_B813_1B813:
    // XCHG CX,BX (1000_B813 / 0x1B813)
    ushort tmp_1000_B813 = CX;
    CX = BX;
    BX = tmp_1000_B813;
    State.IncCycles();
    // PUSH SI (1000_B815 / 0x1B815)
    Stack.Push(SI);
    State.IncCycles();
    // ADD SI,AX (1000_B816 / 0x1B816)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B818 / 0x1B818)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP SI (1000_B81A / 0x1B81A)
    SI = Stack.Pop();
    State.IncCycles();
    // XCHG CX,BX (1000_B81B / 0x1B81B)
    ushort tmp_1000_B81B = CX;
    CX = BX;
    BX = tmp_1000_B81B;
    State.IncCycles();
    label_1000_B81D_1B81D:
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_B81D / 0x1B81D)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DS (1000_B81F / 0x1B81F)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_B820 / 0x1B820)
    DI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_B821 / 0x1B821)
    DX = Stack.Pop();
    State.IncCycles();
    // ADD DI,0xc8 (1000_B822 / 0x1B822)
    // DI += 0xC8;
    DI = Alu.Add16(DI, 0xC8);
    State.IncCycles();
    // RET  (1000_B826 / 0x1B826)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B827_01B827(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B827_1B827:
    // MOV byte ptr [0xdd02],0x0 (1000_B827 / 0x1B827)
    UInt8[DS, 0xDD02] = 0x0;
    State.IncCycles();
    // CALL 0x1000:b84a (1000_B82C / 0x1B82C)
    NearCall(cs1, 0xB82F, spice86_generated_label_call_target_1000_B84A_01B84A);
    State.IncCycles();
    label_1000_B82F_1B82F:
    // MOV word ptr [0xdd0f],0x0 (1000_B82F / 0x1B82F)
    UInt16[DS, 0xDD0F] = 0x0;
    State.IncCycles();
    // CALL 0x1000:b87e (1000_B835 / 0x1B835)
    NearCall(cs1, 0xB838, spice86_generated_label_call_target_1000_B87E_01B87E);
    State.IncCycles();
    label_1000_B838_1B838:
    // CALL 0x1000:1797 (1000_B838 / 0x1B838)
    NearCall(cs1, 0xB83B, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    label_1000_B83B_1B83B:
    // CALL 0x1000:b941 (1000_B83B / 0x1B83B)
    NearCall(cs1, 0xB83E, spice86_generated_label_call_target_1000_B941_01B941);
    State.IncCycles();
    label_1000_B83E_1B83E:
    // CALL 0x1000:d7b2 (1000_B83E / 0x1B83E)
    NearCall(cs1, 0xB841, spice86_generated_label_call_target_1000_D7B2_01D7B2);
    State.IncCycles();
    label_1000_B841_1B841:
    // MOV SI,0x1dc6 (1000_B841 / 0x1B841)
    SI = 0x1DC6;
    State.IncCycles();
    // CALL 0x1000:d72b (1000_B844 / 0x1B844)
    NearCall(cs1, 0xB847, spice86_generated_label_call_target_1000_D72B_01D72B);
    State.IncCycles();
    label_1000_B847_1B847:
    // JMP 0x1000:ad5e (1000_B847 / 0x1B847)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_AD5E_01AD5E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B84A_01B84A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B84A_1B84A:
    // CALL 0x1000:c07c (1000_B84A / 0x1B84A)
    NearCall(cs1, 0xB84D, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_B84D_1B84D:
    // MOV ES,word ptr [0xdbda] (1000_B84D / 0x1B84D)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV SI,0x1470 (1000_B851 / 0x1B851)
    SI = 0x1470;
    State.IncCycles();
    // MOV AL,0xf0 (1000_B854 / 0x1B854)
    AL = 0xF0;
    State.IncCycles();
    // CALLF [0x38dd] (1000_B856 / 0x1B856)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_B856 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_B856) {
      case 0x235CE : FarCall(cs1, 0xB85A, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B856));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B85A_01B85A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B85A_01B85A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B85A_1B85A:
    // MOV AX,0x1 (1000_B85A / 0x1B85A)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_B85D / 0x1B85D)
    NearCall(cs1, 0xB860, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_B860_1B860:
    // MOV DX,0x5b (1000_B860 / 0x1B860)
    DX = 0x5B;
    State.IncCycles();
    // MOV BX,0x14 (1000_B863 / 0x1B863)
    BX = 0x14;
    State.IncCycles();
    // MOV AX,0x2 (1000_B866 / 0x1B866)
    AX = 0x2;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_B869 / 0x1B869)
    NearCall(cs1, 0xB86C, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_B86C_1B86C:
    // MOV SI,0x2448 (1000_B86C / 0x1B86C)
    SI = 0x2448;
    State.IncCycles();
    // CALL 0x1000:daaa (1000_B86F / 0x1B86F)
    NearCall(cs1, 0xB872, spice86_generated_label_call_target_1000_DAAA_01DAAA);
    State.IncCycles();
    label_1000_B872_1B872:
    // MOV SI,0x2440 (1000_B872 / 0x1B872)
    SI = 0x2440;
    State.IncCycles();
    // MOV DI,0xd834 (1000_B875 / 0x1B875)
    DI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_B878 / 0x1B878)
    NearCall(cs1, 0xB87B, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
    label_1000_B87B_1B87B:
    // JMP 0x1000:b977 (1000_B87B / 0x1B87B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B977_01B977, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B87E_01B87E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B87E_1B87E:
    // CALL 0x1000:5ba8 (1000_B87E / 0x1B87E)
    NearCall(cs1, 0xB881, spice86_generated_label_call_target_1000_5BA8_015BA8);
    State.IncCycles();
    label_1000_B881_1B881:
    // MOV AX,0x1 (1000_B881 / 0x1B881)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_B884 / 0x1B884)
    NearCall(cs1, 0xB887, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_B887_1B887:
    // MOV DX,word ptr [0xdd0f] (1000_B887 / 0x1B887)
    DX = UInt16[DS, 0xDD0F];
    State.IncCycles();
    // XOR BX,BX (1000_B88B / 0x1B88B)
    BX = 0;
    State.IncCycles();
    // XOR AX,AX (1000_B88D / 0x1B88D)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:c305 (1000_B88F / 0x1B88F)
    NearCall(cs1, 0xB892, spice86_generated_label_call_target_1000_C305_01C305);
    State.IncCycles();
    label_1000_B892_1B892:
    // SUB DX,0xd6 (1000_B892 / 0x1B892)
    DX -= 0xD6;
    State.IncCycles();
    // NEG DX (1000_B896 / 0x1B896)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // MOV AX,0x1 (1000_B898 / 0x1B898)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:c30d (1000_B89B / 0x1B89B)
    NearCall(cs1, 0xB89E, spice86_generated_label_call_target_1000_C30D_01C30D);
    State.IncCycles();
    label_1000_B89E_1B89E:
    // MOV SI,0x2440 (1000_B89E / 0x1B89E)
    SI = 0x2440;
    State.IncCycles();
    // MOV DI,0xd834 (1000_B8A1 / 0x1B8A1)
    DI = 0xD834;
    State.IncCycles();
    // JMP 0x1000:5b99 (1000_B8A4 / 0x1B8A4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5B99_015B99, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B8A7_01B8A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B8A7_1B8A7:
    // PUSH DS (1000_B8A7 / 0x1B8A7)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_B8A8 / 0x1B8A8)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x4c60 (1000_B8A9 / 0x1B8A9)
    DI = 0x4C60;
    State.IncCycles();
    // MOV SI,0x92 (1000_B8AC / 0x1B8AC)
    SI = 0x92;
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_B8AF / 0x1B8AF)
    NearCall(cs1, 0xB8B2, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    State.IncCycles();
    label_1000_B8B2_1B8B2:
    // MOV DX,word ptr [0x197c] (1000_B8B2 / 0x1B8B2)
    DX = UInt16[DS, 0x197C];
    State.IncCycles();
    // MOV BX,word ptr [0x197e] (1000_B8B6 / 0x1B8B6)
    BX = UInt16[DS, 0x197E];
    State.IncCycles();
    // CALL 0x1000:ba75 (1000_B8BA / 0x1B8BA)
    NearCall(cs1, 0xB8BD, spice86_generated_label_call_target_1000_BA75_01BA75);
    State.IncCycles();
    label_1000_B8BD_1B8BD:
    // MOV AX,0x1 (1000_B8BD / 0x1B8BD)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_B8C0 / 0x1B8C0)
    NearCall(cs1, 0xB8C3, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_B8C3_1B8C3:
    // JMP 0x1000:c0f4 (1000_B8C3 / 0x1B8C3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0F4_01C0F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B8C6_01B8C6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B8C6_1B8C6:
    // CALL 0x1000:d2bd (1000_B8C6 / 0x1B8C6)
    NearCall(cs1, 0xB8C9, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B8C9_01B8C9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B8C9_01B8C9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xB8EA: goto label_1000_B8EA_1B8EA;break; // Target of external jump from 0x102F5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_B8C9_1B8C9:
    // CALL 0x1000:5adf (1000_B8C9 / 0x1B8C9)
    NearCall(cs1, 0xB8CC, spice86_generated_label_call_target_1000_5ADF_015ADF);
    State.IncCycles();
    label_1000_B8CC_1B8CC:
    // CALL 0x1000:b8a7 (1000_B8CC / 0x1B8CC)
    NearCall(cs1, 0xB8CF, spice86_generated_label_call_target_1000_B8A7_01B8A7);
    State.IncCycles();
    label_1000_B8CF_1B8CF:
    // INC byte ptr [0xdd03] (1000_B8CF / 0x1B8CF)
    UInt8[DS, 0xDD03]++;
    State.IncCycles();
    // XOR AL,AL (1000_B8D3 / 0x1B8D3)
    AL = 0;
    State.IncCycles();
    // MOV DX,0xffff (1000_B8D5 / 0x1B8D5)
    DX = 0xFFFF;
    State.IncCycles();
    // MOV BP,0xb827 (1000_B8D8 / 0x1B8D8)
    BP = 0xB827;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_B8DB / 0x1B8DB)
    NearCall(cs1, 0xB8DE, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    label_1000_B8DE_1B8DE:
    // CALL 0x1000:ae04 (1000_B8DE / 0x1B8DE)
    NearCall(cs1, 0xB8E1, spice86_generated_label_call_target_1000_AE04_01AE04);
    State.IncCycles();
    label_1000_B8E1_1B8E1:
    // MOV AX,0x2562 (1000_B8E1 / 0x1B8E1)
    AX = 0x2562;
    State.IncCycles();
    // CALL 0x1000:d95e (1000_B8E4 / 0x1B8E4)
    NearCall(cs1, 0xB8E7, spice86_generated_label_call_target_1000_D95E_01D95E);
    State.IncCycles();
    label_1000_B8E7_1B8E7:
    // CALL 0x1000:17e6 (1000_B8E7 / 0x1B8E7)
    NearCall(cs1, 0xB8EA, spice86_generated_label_call_target_1000_17E6_0117E6);
    State.IncCycles();
    label_1000_B8EA_1B8EA:
    // MOV SI,0xb9ae (1000_B8EA / 0x1B8EA)
    SI = 0xB9AE;
    State.IncCycles();
    // MOV BP,0x1 (1000_B8ED / 0x1B8ED)
    BP = 0x1;
    State.IncCycles();
    // JMP 0x1000:da25 (1000_B8F0 / 0x1B8F0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA25_01DA25, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B8F3_01B8F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B8F3_1B8F3:
    // CALL 0x1000:b84a (1000_B8F3 / 0x1B8F3)
    NearCall(cs1, 0xB8F6, spice86_generated_label_call_target_1000_B84A_01B84A);
    State.IncCycles();
    label_1000_B8F6_1B8F6:
    // MOV BP,0xbe1d (1000_B8F6 / 0x1B8F6)
    BP = 0xBE1D;
    State.IncCycles();
    // CALL 0x1000:c097 (1000_B8F9 / 0x1B8F9)
    NearCall(cs1, 0xB8FC, spice86_generated_label_call_target_1000_C097_01C097);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B8FC_01B8FC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B8FC_01B8FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B8FC_1B8FC:
    // CALL 0x1000:c474 (1000_B8FC / 0x1B8FC)
    NearCall(cs1, 0xB8FF, spice86_generated_label_call_target_1000_C474_01C474);
    State.IncCycles();
    label_1000_B8FF_1B8FF:
    // CALL 0x1000:c43e (1000_B8FF / 0x1B8FF)
    NearCall(cs1, 0xB902, spice86_generated_label_call_target_1000_C43E_01C43E);
    State.IncCycles();
    label_1000_B902_1B902:
    // CALL 0x1000:b87e (1000_B902 / 0x1B902)
    NearCall(cs1, 0xB905, spice86_generated_label_call_target_1000_B87E_01B87E);
    State.IncCycles();
    label_1000_B905_1B905:
    // CALL 0x1000:c4dd (1000_B905 / 0x1B905)
    NearCall(cs1, 0xB908, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_B908_1B908:
    // SUB word ptr [0xdd0f],0x10 (1000_B908 / 0x1B908)
    UInt16[DS, 0xDD0F] -= 0x10;
    State.IncCycles();
    // CMP word ptr [0xdd0f],-0x6a (1000_B90D / 0x1B90D)
    Alu.Sub16(UInt16[DS, 0xDD0F], 0xFF96);
    State.IncCycles();
    // JG 0x1000:b8ff (1000_B912 / 0x1B912)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_B8FF_1B8FF;
    }
    State.IncCycles();
    // RET  (1000_B914 / 0x1B914)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B915_01B915(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B915_1B915:
    // CALL 0x1000:b93b (1000_B915 / 0x1B915)
    NearCall(cs1, 0xB918, spice86_generated_label_ret_target_1000_B93B_01B93B);
    State.IncCycles();
    label_1000_B918_1B918:
    // CALL 0x1000:c08e (1000_B918 / 0x1B918)
    NearCall(cs1, 0xB91B, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B91B_01B91B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B91B_01B91B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B91B_1B91B:
    // ADD word ptr [0xdd0f],0x10 (1000_B91B / 0x1B91B)
    // UInt16[DS, 0xDD0F] += 0x10;
    UInt16[DS, 0xDD0F] = Alu.Add16(UInt16[DS, 0xDD0F], 0x10);
    State.IncCycles();
    // CALL 0x1000:b87e (1000_B920 / 0x1B920)
    NearCall(cs1, 0xB923, spice86_generated_label_call_target_1000_B87E_01B87E);
    State.IncCycles();
    label_1000_B923_1B923:
    // CMP word ptr [0xdd0f],0x0 (1000_B923 / 0x1B923)
    Alu.Sub16(UInt16[DS, 0xDD0F], 0x0);
    State.IncCycles();
    // JNZ 0x1000:b91b (1000_B928 / 0x1B928)
    if(!ZeroFlag) {
      goto label_1000_B91B_1B91B;
    }
    State.IncCycles();
    // CALL 0x1000:c07c (1000_B92A / 0x1B92A)
    NearCall(cs1, 0xB92D, spice86_generated_label_call_target_1000_C07C_01C07C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B92D_01B92D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B92D_01B92D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B92D_1B92D:
    // JMP 0x1000:b87e (1000_B92D / 0x1B92D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B87E_01B87E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B930_01B930(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B930_1B930:
    // MOV byte ptr [0xdd03],0x0 (1000_B930 / 0x1B930)
    UInt8[DS, 0xDD03] = 0x0;
    State.IncCycles();
    // MOV SI,0xb9ae (1000_B935 / 0x1B935)
    SI = 0xB9AE;
    State.IncCycles();
    // CALL 0x1000:da5f (1000_B938 / 0x1B938)
    NearCall(cs1, 0xB93B, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B93B_01B93B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B93B_01B93B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B93B_1B93B:
    // MOV SI,0xbe57 (1000_B93B / 0x1B93B)
    SI = 0xBE57;
    State.IncCycles();
    // JMP 0x1000:da5f (1000_B93E / 0x1B93E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B941_01B941(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B941_1B941:
    // MOV BP,0x204a (1000_B941 / 0x1B941)
    BP = 0x204A;
    State.IncCycles();
    // MOV AX,0xb1 (1000_B944 / 0x1B944)
    AX = 0xB1;
    State.IncCycles();
    // MOV BX,0xb96b (1000_B947 / 0x1B947)
    BX = 0xB96B;
    State.IncCycles();
    // CMP byte ptr [0xdd02],0x0 (1000_B94A / 0x1B94A)
    Alu.Sub8(UInt8[DS, 0xDD02], 0x0);
    State.IncCycles();
    // JZ 0x1000:b955 (1000_B94F / 0x1B94F)
    if(ZeroFlag) {
      goto label_1000_B955_1B955;
    }
    State.IncCycles();
    // INC AX (1000_B951 / 0x1B951)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV BX,0xb961 (1000_B952 / 0x1B952)
    BX = 0xB961;
    State.IncCycles();
    label_1000_B955_1B955:
    // MOV word ptr [BP + 0x6],AX (1000_B955 / 0x1B955)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0x8],BX (1000_B958 / 0x1B958)
    UInt16[SS, (ushort)(BP + 0x8)] = BX;
    State.IncCycles();
    // MOV BX,0xd917 (1000_B95B / 0x1B95B)
    BX = 0xD917;
    State.IncCycles();
    // JMP 0x1000:d338 (1000_B95E / 0x1B95E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D338_01D338, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B961_01B961(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B961_1B961:
    // CALL 0x1000:b915 (1000_B961 / 0x1B961)
    NearCall(cs1, 0xB964, spice86_generated_label_call_target_1000_B915_01B915);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B964_01B964, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B964_01B964(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B964_1B964:
    // MOV byte ptr [0xdd02],0x0 (1000_B964 / 0x1B964)
    UInt8[DS, 0xDD02] = 0x0;
    State.IncCycles();
    // JMP 0x1000:b972 (1000_B969 / 0x1B969)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_B972_01B972, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_B96B_01B96B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B96B_1B96B:
    // CALL 0x1000:b8f3 (1000_B96B / 0x1B96B)
    NearCall(cs1, 0xB96E, spice86_generated_label_call_target_1000_B8F3_01B8F3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B96E_01B96E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B96E_01B96E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B96E_1B96E:
    // DEC byte ptr [0xdd02] (1000_B96E / 0x1B96E)
    UInt8[DS, 0xDD02] = Alu.Dec8(UInt8[DS, 0xDD02]);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_B972_01B972, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_B972_01B972(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B972_1B972:
    // CALL 0x1000:b98b (1000_B972 / 0x1B972)
    NearCall(cs1, 0xB975, spice86_generated_label_call_target_1000_B98B_01B98B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B975_01B975, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B975_01B975(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B975_1B975:
    // JMP 0x1000:b941 (1000_B975 / 0x1B975)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B941_01B941, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B977_01B977(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B977_1B977:
    // MOV BP,0x4948 (1000_B977 / 0x1B977)
    BP = 0x4948;
    State.IncCycles();
    // MOV ES,word ptr [0xdbd6] (1000_B97A / 0x1B97A)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // MOV AL,[0xdd02] (1000_B97E / 0x1B97E)
    AL = UInt8[DS, 0xDD02];
    State.IncCycles();
    // LDS SI,[0xdcfe] (1000_B981 / 0x1B981)
    DS = UInt16[DS, 0xDD00];
    SI = UInt16[DS, 0xDCFE];
    State.IncCycles();
    // CALLF [0x3911] (1000_B985 / 0x1B985)
    // Indirect call to [0x3911], generating possible targets from emulator records
    uint targetAddress_1000_B985 = (uint)(UInt16[SS, 0x3913] * 0x10 + UInt16[SS, 0x3911] - cs1 * 0x10);
    switch(targetAddress_1000_B985) {
      case 0x235F5 : FarCall(cs1, 0xB98A, spice86_generated_label_call_target_334B_0145_0335F5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B985));
        break;
    }
    State.IncCycles();
    label_1000_B98A_1B98A:
    // RET  (1000_B98A / 0x1B98A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B98B_01B98B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B98B_1B98B:
    // CALL 0x1000:b977 (1000_B98B / 0x1B98B)
    NearCall(cs1, 0xB98E, spice86_generated_label_call_target_1000_B977_01B977);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B98E_01B98E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B98E_01B98E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B98E_1B98E:
    // CALL 0x1000:baf2 (1000_B98E / 0x1B98E)
    NearCall(cs1, 0xB991, spice86_generated_label_call_target_1000_BAF2_01BAF2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B991_01B991, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B991_01B991(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B991_1B991:
    // PUSH BX (1000_B991 / 0x1B991)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_B992 / 0x1B992)
    Stack.Push(DX);
    State.IncCycles();
    // MOV SI,0xd834 (1000_B993 / 0x1B993)
    SI = 0xD834;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_B996 / 0x1B996)
    NearCall(cs1, 0xB999, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    label_1000_B999_1B999:
    // CALL 0x1000:c4ed (1000_B999 / 0x1B999)
    NearCall(cs1, 0xB99C, spice86_generated_label_call_target_1000_C4ED_01C4ED);
    State.IncCycles();
    label_1000_B99C_1B99C:
    // POP DX (1000_B99C / 0x1B99C)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_B99D / 0x1B99D)
    BX = Stack.Pop();
    State.IncCycles();
    // OR DX,DX (1000_B99E / 0x1B99E)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:b9a5 (1000_B9A0 / 0x1B9A0)
    if(ZeroFlag) {
      goto label_1000_B9A5_1B9A5;
    }
    State.IncCycles();
    // CALL 0x1000:bc0c (1000_B9A2 / 0x1B9A2)
    NearCall(cs1, 0xB9A5, spice86_generated_label_call_target_1000_BC0C_01BC0C);
    State.IncCycles();
    label_1000_B9A5_1B9A5:
    // CALL 0x1000:db67 (1000_B9A5 / 0x1B9A5)
    NearCall(cs1, 0xB9A8, spice86_generated_label_call_target_1000_DB67_01DB67);
    State.IncCycles();
    label_1000_B9A8_1B9A8:
    // MOV AX,0x1 (1000_B9A8 / 0x1B9A8)
    AX = 0x1;
    State.IncCycles();
    // JMP 0x1000:b9e0 (1000_B9AB / 0x1B9AB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B9E0_01B9E0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B9AE_01B9AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B9AE_1B9AE:
    // MOV ES,word ptr [0xdbd6] (1000_B9AE / 0x1B9AE)
    ES = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALLF [0x3915] (1000_B9B2 / 0x1B9B2)
    // Indirect call to [0x3915], generating possible targets from emulator records
    uint targetAddress_1000_B9B2 = (uint)(UInt16[DS, 0x3917] * 0x10 + UInt16[DS, 0x3915] - cs1 * 0x10);
    switch(targetAddress_1000_B9B2) {
      case 0x235F8 : FarCall(cs1, 0xB9B6, spice86_generated_label_call_target_334B_0148_0335F8); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_B9B2));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B9B6_01B9B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_B9B6_01B9B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B9B6_1B9B6:
    // JC 0x1000:b98e (1000_B9B6 / 0x1B9B6)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_B98E_01B98E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_B9B8 / 0x1B9B8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B9D3_01B9D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B9D3_1B9D3:
    // SHR AX,1 (1000_B9D3 / 0x1B9D3)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV AX,0x20 (1000_B9D5 / 0x1B9D5)
    AX = 0x20;
    State.IncCycles();
    // JNC 0x1000:b9df (1000_B9D8 / 0x1B9D8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_B9DF / 0x1B9DF)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:b9e0 (1000_B9DA / 0x1B9DA)
    NearCall(cs1, 0xB9DD, spice86_generated_label_call_target_1000_B9E0_01B9E0);
    State.IncCycles();
    label_1000_B9DD_1B9DD:
    // JMP 0x1000:b98b (1000_B9DD / 0x1B9DD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_B98B_01B98B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_B9DF_1B9DF:
    // RET  (1000_B9DF / 0x1B9DF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_B9E0_01B9E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B9E0_1B9E0:
    // MOV SI,0x494c (1000_B9E0 / 0x1B9E0)
    SI = 0x494C;
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_B9E3 / 0x1B9E3)
    DX = UInt16[DS, SI];
    State.IncCycles();
    // MOV CX,0x18e (1000_B9E5 / 0x1B9E5)
    CX = 0x18E;
    State.IncCycles();
    // ADD DX,AX (1000_B9E8 / 0x1B9E8)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // JNS 0x1000:b9ee (1000_B9EA / 0x1B9EA)
    if(!SignFlag) {
      goto label_1000_B9EE_1B9EE;
    }
    State.IncCycles();
    // ADD DX,CX (1000_B9EC / 0x1B9EC)
    DX += CX;
    State.IncCycles();
    label_1000_B9EE_1B9EE:
    // CMP DX,CX (1000_B9EE / 0x1B9EE)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JS 0x1000:b9f4 (1000_B9F0 / 0x1B9F0)
    if(SignFlag) {
      goto label_1000_B9F4_1B9F4;
    }
    State.IncCycles();
    // SUB DX,CX (1000_B9F2 / 0x1B9F2)
    // DX -= CX;
    DX = Alu.Sub16(DX, CX);
    State.IncCycles();
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
  
  public virtual Action spice86_generated_label_call_target_1000_B9F6_01B9F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_B9F6_1B9F6:
    // MOV AX,0x8000 (1000_B9F6 / 0x1B9F6)
    AX = 0x8000;
    State.IncCycles();
    // MOV CX,0x18e (1000_B9F9 / 0x1B9F9)
    CX = 0x18E;
    State.IncCycles();
    // DIV CX (1000_B9FC / 0x1B9FC)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV CX,0x62 (1000_B9FE / 0x1B9FE)
    CX = 0x62;
    State.IncCycles();
    // MOV BX,AX (1000_BA01 / 0x1BA01)
    BX = AX;
    State.IncCycles();
    label_1000_BA03_1BA03:
    // ADD SI,0x6 (1000_BA03 / 0x1BA03)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    State.IncCycles();
    // LODSW SI (1000_BA06 / 0x1BA06)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MUL BX (1000_BA07 / 0x1BA07)
    Cpu.Mul16(BX);
    State.IncCycles();
    // ADD AX,AX (1000_BA09 / 0x1BA09)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    // ADC DX,DX (1000_BA0B / 0x1BA0B)
    DX = Alu.Adc16(DX, DX);
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_BA0D / 0x1BA0D)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],AX (1000_BA0F / 0x1BA0F)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    State.IncCycles();
    // LOOP 0x1000:ba03 (1000_BA12 / 0x1BA12)
    if(--CX != 0) {
      goto label_1000_BA03_1BA03;
    }
    State.IncCycles();
    // RET  (1000_BA14 / 0x1BA14)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_BA2D_01BA2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_BA2D_1BA2D:
    // PUSH DS (1000_BA2D / 0x1BA2D)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_BA2E / 0x1BA2E)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x8b77 (1000_BA2F / 0x1BA2F)
    DI = 0x8B77;
    State.IncCycles();
    // MOV BX,0x62 (1000_BA32 / 0x1BA32)
    BX = 0x62;
    State.IncCycles();
    // MOV CX,0xc4 (1000_BA35 / 0x1BA35)
    CX = 0xC4;
    State.IncCycles();
    // MOV AX,[0x2460] (1000_BA38 / 0x1BA38)
    AX = UInt16[DS, 0x2460];
    State.IncCycles();
    // ADD AX,BX (1000_BA3B / 0x1BA3B)
    AX += BX;
    State.IncCycles();
    // CMP AX,BX (1000_BA3D / 0x1BA3D)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JLE 0x1000:ba55 (1000_BA3F / 0x1BA3F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_BA55_1BA55;
    }
    State.IncCycles();
    // NEG BX (1000_BA41 / 0x1BA41)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // ADD AL,BL (1000_BA43 / 0x1BA43)
    AL += BL;
    State.IncCycles();
    // ADD AL,BL (1000_BA45 / 0x1BA45)
    AL += BL;
    State.IncCycles();
    label_1000_BA47_1BA47:
    // DEC AL (1000_BA47 / 0x1BA47)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // STOSW ES:DI (1000_BA49 / 0x1BA49)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP AL,BL (1000_BA4A / 0x1BA4A)
    Alu.Sub8(AL, BL);
    State.IncCycles();
    // JLE 0x1000:ba50 (1000_BA4C / 0x1BA4C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_BA50_1BA50;
    }
    State.IncCycles();
    // LOOP 0x1000:ba47 (1000_BA4E / 0x1BA4E)
    if(--CX != 0) {
      goto label_1000_BA47_1BA47;
    }
    State.IncCycles();
    label_1000_BA50_1BA50:
    // NEG BX (1000_BA50 / 0x1BA50)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // MOV AX,BX (1000_BA52 / 0x1BA52)
    AX = BX;
    State.IncCycles();
    // DEC CX (1000_BA54 / 0x1BA54)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    label_1000_BA55_1BA55:
    // STOSW ES:DI (1000_BA55 / 0x1BA55)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // DEC AL (1000_BA56 / 0x1BA56)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JS 0x1000:ba5c (1000_BA58 / 0x1BA58)
    if(SignFlag) {
      goto label_1000_BA5C_1BA5C;
    }
    State.IncCycles();
    // LOOP 0x1000:ba55 (1000_BA5A / 0x1BA5A)
    if(--CX != 0) {
      goto label_1000_BA55_1BA55;
    }
    State.IncCycles();
    label_1000_BA5C_1BA5C:
    // DEC CX (1000_BA5C / 0x1BA5C)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JLE 0x1000:ba74 (1000_BA5D / 0x1BA5D)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_BA74 / 0x1BA74)
      return NearRet();
    }
    State.IncCycles();
    // NEG AX (1000_BA5F / 0x1BA5F)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_BA61_1BA61:
    // STOSW ES:DI (1000_BA61 / 0x1BA61)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // INC AL (1000_BA62 / 0x1BA62)
    AL++;
    State.IncCycles();
    // CMP AL,BL (1000_BA64 / 0x1BA64)
    Alu.Sub8(AL, BL);
    State.IncCycles();
    // JG 0x1000:ba6a (1000_BA66 / 0x1BA66)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_BA6A_1BA6A;
    }
    State.IncCycles();
    // LOOP 0x1000:ba61 (1000_BA68 / 0x1BA68)
    if(--CX != 0) {
      goto label_1000_BA61_1BA61;
    }
    State.IncCycles();
    label_1000_BA6A_1BA6A:
    // DEC CX (1000_BA6A / 0x1BA6A)
    CX = Alu.Dec16(CX);
    State.IncCycles();
    // JLE 0x1000:ba74 (1000_BA6B / 0x1BA6B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_BA74 / 0x1BA74)
      return NearRet();
    }
    State.IncCycles();
    // NEG AL (1000_BA6D / 0x1BA6D)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    label_1000_BA6F_1BA6F:
    // INC AL (1000_BA6F / 0x1BA6F)
    AL = Alu.Inc8(AL);
    State.IncCycles();
    // STOSW ES:DI (1000_BA71 / 0x1BA71)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // LOOP 0x1000:ba6f (1000_BA72 / 0x1BA72)
    if(--CX != 0) {
      goto label_1000_BA6F_1BA6F;
    }
    State.IncCycles();
    label_1000_BA74_1BA74:
    // RET  (1000_BA74 / 0x1BA74)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BA75_01BA75(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_BA75_1BA75:
    // MOV SI,0x494c (1000_BA75 / 0x1BA75)
    SI = 0x494C;
    State.IncCycles();
    // MOV AX,0x18e (1000_BA78 / 0x1BA78)
    AX = 0x18E;
    State.IncCycles();
    // MUL DX (1000_BA7B / 0x1BA7B)
    Cpu.Mul16(DX);
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_BA7D / 0x1BA7D)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],0x0 (1000_BA7F / 0x1BA7F)
    UInt16[DS, (ushort)(SI + 0x2)] = 0x0;
    State.IncCycles();
    // MOV AX,BX (1000_BA84 / 0x1BA84)
    AX = BX;
    State.IncCycles();
    // CMP AX,0x20 (1000_BA86 / 0x1BA86)
    Alu.Sub16(AX, 0x20);
    State.IncCycles();
    // JNC 0x1000:ba8e (1000_BA89 / 0x1BA89)
    if(!CarryFlag) {
      goto label_1000_BA8E_1BA8E;
    }
    State.IncCycles();
    // MOV AX,0x20 (1000_BA8B / 0x1BA8B)
    AX = 0x20;
    State.IncCycles();
    label_1000_BA8E_1BA8E:
    // CMP AX,0xffe0 (1000_BA8E / 0x1BA8E)
    Alu.Sub16(AX, 0xFFE0);
    State.IncCycles();
    // JC 0x1000:ba96 (1000_BA91 / 0x1BA91)
    if(CarryFlag) {
      goto label_1000_BA96_1BA96;
    }
    State.IncCycles();
    // MOV AX,0xffe0 (1000_BA93 / 0x1BA93)
    AX = 0xFFE0;
    State.IncCycles();
    label_1000_BA96_1BA96:
    // MOV [0x2460],AX (1000_BA96 / 0x1BA96)
    UInt16[DS, 0x2460] = AX;
    State.IncCycles();
    // CALL 0x1000:b9f6 (1000_BA99 / 0x1BA99)
    NearCall(cs1, 0xBA9C, spice86_generated_label_call_target_1000_B9F6_01B9F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BA9C_01BA9C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BA9C_01BA9C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_BA9C_1BA9C:
    // JMP 0x1000:ba2d (1000_BA9C / 0x1BA9C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_BA2D_01BA2D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BAF2_01BAF2(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xBAF1: break; // Instructions before entry targeted by 0x1BAF9
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_BAF1_1BAF1:
    // RET  (1000_BAF1 / 0x1BAF1)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_BAF2_1BAF2:
    // XOR DX,DX (1000_BAF2 / 0x1BAF2)
    DX = 0;
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_BAF4 / 0x1BAF4)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:baf1 (1000_BAF9 / 0x1BAF9)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_BAF1 / 0x1BAF1)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:407e (1000_BAFB / 0x1BAFB)
    NearCall(cs1, 0xBAFE, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BAFE_01BAFE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BAFE_01BAFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_BAFE_1BAFE:
    // SUB SP,0xa (1000_BAFE / 0x1BAFE)
    // SP -= 0xA;
    SP = Alu.Sub16(SP, 0xA);
    State.IncCycles();
    // MOV BP,SP (1000_BB01 / 0x1BB01)
    BP = SP;
    State.IncCycles();
    // MOV word ptr [BP + 0x0],0x0 (1000_BB03 / 0x1BB03)
    UInt16[SS, BP] = 0x0;
    State.IncCycles();
    // SHL BX,1 (1000_BB08 / 0x1BB08)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_BB0A / 0x1BB0A)
    BX <<= 0x1;
    State.IncCycles();
    // SHL BX,1 (1000_BB0C / 0x1BB0C)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // JNS 0x1000:bb16 (1000_BB0E / 0x1BB0E)
    if(!SignFlag) {
      goto label_1000_BB16_1BB16;
    }
    State.IncCycles();
    // MOV byte ptr [BP + 0x1],0xff (1000_BB10 / 0x1BB10)
    UInt8[SS, (ushort)(BP + 0x1)] = 0xFF;
    State.IncCycles();
    // NEG BX (1000_BB14 / 0x1BB14)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_BB16_1BB16:
    // MOV CX,word ptr [BX + 0x494a] (1000_BB16 / 0x1BB16)
    CX = UInt16[DS, (ushort)(BX + 0x494A)];
    State.IncCycles();
    // MOV AX,CX (1000_BB1A / 0x1BB1A)
    AX = CX;
    State.IncCycles();
    // ADD AX,AX (1000_BB1C / 0x1BB1C)
    AX += AX;
    State.IncCycles();
    // MUL DX (1000_BB1E / 0x1BB1E)
    Cpu.Mul16(DX);
    State.IncCycles();
    // ADD AX,AX (1000_BB20 / 0x1BB20)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    // ADC DX,0x0 (1000_BB22 / 0x1BB22)
    DX = Alu.Adc16(DX, 0x0);
    State.IncCycles();
    // XOR AX,AX (1000_BB25 / 0x1BB25)
    AX = 0;
    State.IncCycles();
    // SUB DX,word ptr [BX + 0x494c] (1000_BB27 / 0x1BB27)
    // DX -= UInt16[DS, (ushort)(BX + 0x494C)];
    DX = Alu.Sub16(DX, UInt16[DS, (ushort)(BX + 0x494C)]);
    State.IncCycles();
    // JNS 0x1000:bb31 (1000_BB2B / 0x1BB2B)
    if(!SignFlag) {
      goto label_1000_BB31_1BB31;
    }
    State.IncCycles();
    // NEG DX (1000_BB2D / 0x1BB2D)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // NOT AX (1000_BB2F / 0x1BB2F)
    AX = (ushort)~AX;
    State.IncCycles();
    label_1000_BB31_1BB31:
    // CMP DX,CX (1000_BB31 / 0x1BB31)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JC 0x1000:bb3d (1000_BB33 / 0x1BB33)
    if(CarryFlag) {
      goto label_1000_BB3D_1BB3D;
    }
    State.IncCycles();
    // SUB DX,CX (1000_BB35 / 0x1BB35)
    DX -= CX;
    State.IncCycles();
    // SUB DX,CX (1000_BB37 / 0x1BB37)
    DX -= CX;
    State.IncCycles();
    // NEG DX (1000_BB39 / 0x1BB39)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // NOT AX (1000_BB3B / 0x1BB3B)
    AX = (ushort)~AX;
    State.IncCycles();
    label_1000_BB3D_1BB3D:
    // SHR CX,1 (1000_BB3D / 0x1BB3D)
    CX >>= 0x1;
    State.IncCycles();
    // CMP DX,CX (1000_BB3F / 0x1BB3F)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JC 0x1000:bb4d (1000_BB41 / 0x1BB41)
    if(CarryFlag) {
      goto label_1000_BB4D_1BB4D;
    }
    State.IncCycles();
    // MOV byte ptr [BP + 0x0],0x80 (1000_BB43 / 0x1BB43)
    UInt8[SS, BP] = 0x80;
    State.IncCycles();
    // SUB DX,CX (1000_BB47 / 0x1BB47)
    DX -= CX;
    State.IncCycles();
    // SUB DX,CX (1000_BB49 / 0x1BB49)
    DX -= CX;
    State.IncCycles();
    // NEG DX (1000_BB4B / 0x1BB4B)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_1000_BB4D_1BB4D:
    // MOV byte ptr [BP + 0x4],AL (1000_BB4D / 0x1BB4D)
    UInt8[SS, (ushort)(BP + 0x4)] = AL;
    State.IncCycles();
    // SHR BX,1 (1000_BB50 / 0x1BB50)
    BX >>= 0x1;
    State.IncCycles();
    // SHR BX,1 (1000_BB52 / 0x1BB52)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    State.IncCycles();
    // PUSH DS (1000_BB54 / 0x1BB54)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_BB55 / 0x1BB55)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x593a (1000_BB56 / 0x1BB56)
    DI = 0x593A;
    State.IncCycles();
    // MOV AX,BX (1000_BB59 / 0x1BB59)
    AX = BX;
    State.IncCycles();
    // MOV CX,0x64 (1000_BB5B / 0x1BB5B)
    CX = 0x64;
    State.IncCycles();
    // XOR BX,BX (1000_BB5E / 0x1BB5E)
    BX = 0;
    State.IncCycles();
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
    State.IncCycles();
    // JNZ 0x1000:bb7a (1000_BB62 / 0x1BB62)
    if(!ZeroFlag) {
      goto label_1000_BB7A_1BB7A;
    }
    State.IncCycles();
    // INC CX (1000_BB64 / 0x1BB64)
    CX++;
    State.IncCycles();
    // CMP DL,byte ptr [DI + 0x63] (1000_BB65 / 0x1BB65)
    Alu.Sub8(DL, UInt8[DS, (ushort)(DI + 0x63)]);
    State.IncCycles();
    // JBE 0x1000:bb7d (1000_BB68 / 0x1BB68)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_BB7D_1BB7D;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],CX (1000_BB6A / 0x1BB6A)
    UInt16[SS, (ushort)(BP + 0x2)] = CX;
    State.IncCycles();
    // INC BX (1000_BB6D / 0x1BB6D)
    BX++;
    State.IncCycles();
    // ADD DI,0xc7 (1000_BB6E / 0x1BB6E)
    DI += 0xC7;
    State.IncCycles();
    // CMP DI,0x8b3b (1000_BB72 / 0x1BB72)
    Alu.Sub16(DI, 0x8B3B);
    State.IncCycles();
    // JC 0x1000:bb60 (1000_BB76 / 0x1BB76)
    if(CarryFlag) {
      goto label_1000_BB60_1BB60;
    }
    State.IncCycles();
    // JMP 0x1000:bbe6 (1000_BB78 / 0x1BB78)
    goto label_1000_BBE6_1BBE6;
    State.IncCycles();
    label_1000_BB7A_1BB7A:
    // MOV CX,word ptr [BP + 0x2] (1000_BB7A / 0x1BB7A)
    CX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    label_1000_BB7D_1BB7D:
    // MOV AX,0x64 (1000_BB7D / 0x1BB7D)
    AX = 0x64;
    State.IncCycles();
    // SUB AX,CX (1000_BB80 / 0x1BB80)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    State.IncCycles();
    // MOV word ptr [BP + 0x2],BX (1000_BB82 / 0x1BB82)
    UInt16[SS, (ushort)(BP + 0x2)] = BX;
    State.IncCycles();
    // MOV CX,word ptr [BP + 0x0] (1000_BB85 / 0x1BB85)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // MOV AH,CH (1000_BB88 / 0x1BB88)
    AH = CH;
    State.IncCycles();
    // OR CL,CL (1000_BB8A / 0x1BB8A)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JNS 0x1000:bb90 (1000_BB8C / 0x1BB8C)
    if(!SignFlag) {
      goto label_1000_BB90_1BB90;
    }
    State.IncCycles();
    // NEG AL (1000_BB8E / 0x1BB8E)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    label_1000_BB90_1BB90:
    // MOV DI,0x8bbb (1000_BB90 / 0x1BB90)
    DI = 0x8BBB;
    State.IncCycles();
    // MOV CX,0x80 (1000_BB93 / 0x1BB93)
    CX = 0x80;
    State.IncCycles();
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
    State.IncCycles();
    // JNZ 0x1000:bbe6 (1000_BB98 / 0x1BB98)
    if(!ZeroFlag) {
      goto label_1000_BBE6_1BBE6;
    }
    State.IncCycles();
    // XOR AL,AL (1000_BB9A / 0x1BB9A)
    AL = 0;
    State.IncCycles();
    // SUB DI,0x8c3d (1000_BB9C / 0x1BB9C)
    // DI -= 0x8C3D;
    DI = Alu.Sub16(DI, 0x8C3D);
    State.IncCycles();
    // JNS 0x1000:bba6 (1000_BBA0 / 0x1BBA0)
    if(!SignFlag) {
      goto label_1000_BBA6_1BBA6;
    }
    State.IncCycles();
    // NEG DI (1000_BBA2 / 0x1BBA2)
    DI = Alu.Sub16(0, DI);
    State.IncCycles();
    // NOT AL (1000_BBA4 / 0x1BBA4)
    AL = (byte)~AL;
    State.IncCycles();
    label_1000_BBA6_1BBA6:
    // MOV byte ptr [BP + 0x5],AL (1000_BBA6 / 0x1BBA6)
    UInt8[SS, (ushort)(BP + 0x5)] = AL;
    State.IncCycles();
    // MOV BX,0x36 (1000_BBA9 / 0x1BBA9)
    BX = 0x36;
    State.IncCycles();
    // MOV AX,DI (1000_BBAC / 0x1BBAC)
    AX = DI;
    State.IncCycles();
    // SHR AX,1 (1000_BBAE / 0x1BBAE)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV SI,0x4c60 (1000_BBB0 / 0x1BBB0)
    SI = 0x4C60;
    State.IncCycles();
    // MOV DX,word ptr [BP + 0x2] (1000_BBB3 / 0x1BBB3)
    DX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // MOV CL,AL (1000_BBB6 / 0x1BBB6)
    CL = AL;
    State.IncCycles();
    // MOV CH,0xff (1000_BBB8 / 0x1BBB8)
    CH = 0xFF;
    State.IncCycles();
    // XOR AX,AX (1000_BBBA / 0x1BBBA)
    AX = 0;
    State.IncCycles();
    label_1000_BBBC_1BBBC:
    // LODSB SI (1000_BBBC / 0x1BBBC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // INC AL (1000_BBBD / 0x1BBBD)
    AL = Alu.Inc8(AL);
    State.IncCycles();
    // JZ 0x1000:bbe1 (1000_BBBF / 0x1BBBF)
    if(ZeroFlag) {
      goto label_1000_BBE1_1BBE1;
    }
    State.IncCycles();
    // NEG AL (1000_BBC1 / 0x1BBC1)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    // CMP AL,DL (1000_BBC3 / 0x1BBC3)
    Alu.Sub8(AL, DL);
    State.IncCycles();
    // JBE 0x1000:bbe1 (1000_BBC5 / 0x1BBC5)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_BBE1_1BBE1;
    }
    State.IncCycles();
    // MOV DI,SI (1000_BBC7 / 0x1BBC7)
    DI = SI;
    State.IncCycles();
    // ADD SI,AX (1000_BBC9 / 0x1BBC9)
    SI += AX;
    State.IncCycles();
    // ADD DI,DX (1000_BBCB / 0x1BBCB)
    // DI += DX;
    DI = Alu.Add16(DI, DX);
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_BBCD / 0x1BBCD)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // SUB AL,CL (1000_BBCF / 0x1BBCF)
    AL -= CL;
    State.IncCycles();
    // CMP AL,CH (1000_BBD1 / 0x1BBD1)
    Alu.Sub8(AL, CH);
    State.IncCycles();
    // JNC 0x1000:bbde (1000_BBD3 / 0x1BBD3)
    if(!CarryFlag) {
      goto label_1000_BBDE_1BBDE;
    }
    State.IncCycles();
    // MOV CH,AL (1000_BBD5 / 0x1BBD5)
    CH = AL;
    State.IncCycles();
    // MOV word ptr [BP + 0x6],BX (1000_BBD7 / 0x1BBD7)
    UInt16[SS, (ushort)(BP + 0x6)] = BX;
    State.IncCycles();
    // OR AL,AL (1000_BBDA / 0x1BBDA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:bbec (1000_BBDC / 0x1BBDC)
    if(ZeroFlag) {
      goto label_1000_BBEC_1BBEC;
    }
    State.IncCycles();
    label_1000_BBDE_1BBDE:
    // DEC BX (1000_BBDE / 0x1BBDE)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // JNZ 0x1000:bbbc (1000_BBDF / 0x1BBDF)
    if(!ZeroFlag) {
      goto label_1000_BBBC_1BBBC;
    }
    State.IncCycles();
    label_1000_BBE1_1BBE1:
    // CMP CH,0x2 (1000_BBE1 / 0x1BBE1)
    Alu.Sub8(CH, 0x2);
    State.IncCycles();
    // JBE 0x1000:bbec (1000_BBE4 / 0x1BBE4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_BBEC_1BBEC;
    }
    State.IncCycles();
    label_1000_BBE6_1BBE6:
    // ADD SP,0xa (1000_BBE6 / 0x1BBE6)
    SP += 0xA;
    State.IncCycles();
    // XOR DX,DX (1000_BBE9 / 0x1BBE9)
    DX = 0;
    State.IncCycles();
    // RET  (1000_BBEB / 0x1BBEB)
    return NearRet();
    State.IncCycles();
    label_1000_BBEC_1BBEC:
    // MOV AX,word ptr [BP + 0x4] (1000_BBEC / 0x1BBEC)
    AX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // MOV BX,word ptr [BP + 0x6] (1000_BBEF / 0x1BBEF)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    State.IncCycles();
    // SUB BX,0x36 (1000_BBF2 / 0x1BBF2)
    // BX -= 0x36;
    BX = Alu.Sub16(BX, 0x36);
    State.IncCycles();
    // OR AH,AH (1000_BBF5 / 0x1BBF5)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x1000:bbfb (1000_BBF7 / 0x1BBF7)
    if(ZeroFlag) {
      goto label_1000_BBFB_1BBFB;
    }
    State.IncCycles();
    // NEG BX (1000_BBF9 / 0x1BBF9)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_BBFB_1BBFB:
    // ADD BX,0x4f (1000_BBFB / 0x1BBFB)
    // BX += 0x4F;
    BX = Alu.Add16(BX, 0x4F);
    State.IncCycles();
    // OR AL,AL (1000_BBFE / 0x1BBFE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:bc04 (1000_BC00 / 0x1BC00)
    if(ZeroFlag) {
      goto label_1000_BC04_1BC04;
    }
    State.IncCycles();
    // NEG DX (1000_BC02 / 0x1BC02)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    label_1000_BC04_1BC04:
    // ADD DX,0xa0 (1000_BC04 / 0x1BC04)
    DX += 0xA0;
    State.IncCycles();
    // ADD SP,0xa (1000_BC08 / 0x1BC08)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    State.IncCycles();
    // RET  (1000_BC0B / 0x1BC0B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_BC0C_01BC0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_BC0C_1BC0C:
    // CALL 0x1000:c08e (1000_BC0C / 0x1BC0C)
    NearCall(cs1, 0xBC0F, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_BC0F_01BC0F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_BC0F_01BC0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_BC0F_1BC0F:
    // CALL 0x1000:c137 (1000_BC0F / 0x1BC0F)
    NearCall(cs1, 0xBC12, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_BC12_1BC12:
    // MOV AX,0x36 (1000_BC12 / 0x1BC12)
    AX = 0x36;
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_BC15 / 0x1BC15)
    NearCall(cs1, 0xBC18, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    label_1000_BC18_1BC18:
    // SUB BL,byte ptr ES:[SI + 0x2] (1000_BC18 / 0x1BC18)
    // BL -= UInt8[ES, (ushort)(SI + 0x2)];
    BL = Alu.Sub8(BL, UInt8[ES, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JMP 0x1000:c22f (1000_BC1C / 0x1BC1C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
