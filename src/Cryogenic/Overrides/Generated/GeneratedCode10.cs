namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_jump_target_1000_79DB_0179DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_79DB_179DB:
    // JMP 0x1000:c07c (1000_79DB / 0x179DB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_79DE_0179DE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_79DE_179DE:
    // XOR AX,AX (1000_79DE / 0x179DE)
    AX = 0;
    State.IncCycles();
    // XCHG word ptr [0x46fa],AX (1000_79E0 / 0x179E0)
    ushort tmp_1000_79E0 = UInt16[DS, 0x46FA];
    UInt16[DS, 0x46FA] = AX;
    AX = tmp_1000_79E0;
    State.IncCycles();
    // OR AX,AX (1000_79E4 / 0x179E4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:79db (1000_79E6 / 0x179E6)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:c07c (1000_79DB / 0x179DB)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x18df (1000_79E8 / 0x179E8)
    SI = 0x18DF;
    State.IncCycles();
    // JMP 0x1000:5f9f (1000_79EB / 0x179EB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5F9F_015F9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_79EE_0179EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_79EE_179EE:
    // MOV word ptr [0x46ef],SI (1000_79EE / 0x179EE)
    UInt16[DS, 0x46EF] = SI;
    State.IncCycles();
    // CALL 0x1000:6917 (1000_79F2 / 0x179F2)
    NearCall(cs1, 0x79F5, spice86_generated_label_call_target_1000_6917_016917);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_79F5_0179F5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_79F5_0179F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_79F5_179F5:
    // MOV SI,0x18e9 (1000_79F5 / 0x179F5)
    SI = 0x18E9;
    State.IncCycles();
    // JNZ 0x1000:7a1e (1000_79F8 / 0x179F8)
    if(!ZeroFlag) {
      goto label_1000_7A1E_17A1E;
    }
    State.IncCycles();
    // MOV AX,0x1e (1000_79FA / 0x179FA)
    AX = 0x1E;
    State.IncCycles();
    // MOV BX,0x5 (1000_79FD / 0x179FD)
    BX = 0x5;
    State.IncCycles();
    // CMP word ptr [DI + 0x2],0x4c (1000_7A00 / 0x17A00)
    Alu.Sub16(UInt16[DS, (ushort)(DI + 0x2)], 0x4C);
    State.IncCycles();
    // JGE 0x1000:7a0c (1000_7A04 / 0x17A04)
    if(SignFlag == OverflowFlag) {
      goto label_1000_7A0C_17A0C;
    }
    State.IncCycles();
    // MOV AX,0xe (1000_7A06 / 0x17A06)
    AX = 0xE;
    State.IncCycles();
    // MOV BX,0x50 (1000_7A09 / 0x17A09)
    BX = 0x50;
    State.IncCycles();
    label_1000_7A0C_17A0C:
    // MOV word ptr [SI + 0x2],BX (1000_7A0C / 0x17A0C)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    State.IncCycles();
    // ADD BX,0x43 (1000_7A0F / 0x17A0F)
    // BX += 0x43;
    BX = Alu.Add16(BX, 0x43);
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_7A12 / 0x17A12)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    // MOV word ptr [0x4710],0x5c (1000_7A15 / 0x17A15)
    UInt16[DS, 0x4710] = 0x5C;
    State.IncCycles();
    // MOV [0x4712],AX (1000_7A1B / 0x17A1B)
    UInt16[DS, 0x4712] = AX;
    State.IncCycles();
    label_1000_7A1E_17A1E:
    // MOV word ptr [0xdbe0],SI (1000_7A1E / 0x17A1E)
    UInt16[DS, 0xDBE0] = SI;
    State.IncCycles();
    // MOV AL,0x2 (1000_7A22 / 0x17A22)
    AL = 0x2;
    State.IncCycles();
    // CALL 0x1000:7b0f (1000_7A24 / 0x17A24)
    NearCall(cs1, 0x7A27, spice86_generated_label_call_target_1000_7B0F_017B0F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7A27_017A27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7A27_017A27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7A27_17A27:
    // MOV DI,0x18e9 (1000_7A27 / 0x17A27)
    DI = 0x18E9;
    State.IncCycles();
    // MOV SI,0x18f3 (1000_7A2A / 0x17A2A)
    SI = 0x18F3;
    State.IncCycles();
    // MOV DX,word ptr [DI] (1000_7A2D / 0x17A2D)
    DX = UInt16[DS, DI];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x2] (1000_7A2F / 0x17A2F)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV AX,DX (1000_7A32 / 0x17A32)
    AX = DX;
    State.IncCycles();
    // ADD AX,0x49 (1000_7A34 / 0x17A34)
    // AX += 0x49;
    AX = Alu.Add16(AX, 0x49);
    State.IncCycles();
    // MOV [0x2244],AX (1000_7A37 / 0x17A37)
    UInt16[DS, 0x2244] = AX;
    State.IncCycles();
    // ADD BX,0x3 (1000_7A3A / 0x17A3A)
    // BX += 0x3;
    BX = Alu.Add16(BX, 0x3);
    State.IncCycles();
    // MOV word ptr [0x2246],BX (1000_7A3D / 0x17A3D)
    UInt16[DS, 0x2246] = BX;
    State.IncCycles();
    // XOR AX,AX (1000_7A41 / 0x17A41)
    AX = 0;
    State.IncCycles();
    // MOV [0x4784],AX (1000_7A43 / 0x17A43)
    UInt16[DS, 0x4784] = AX;
    State.IncCycles();
    // MOV word ptr [0x4786],0x5 (1000_7A46 / 0x17A46)
    UInt16[DS, 0x4786] = 0x5;
    State.IncCycles();
    // MOV [0x4788],AX (1000_7A4C / 0x17A4C)
    UInt16[DS, 0x4788] = AX;
    State.IncCycles();
    // INC AX (1000_7A4F / 0x17A4F)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0x478a],AX (1000_7A50 / 0x17A50)
    UInt16[DS, 0x478A] = AX;
    State.IncCycles();
    // ADD DX,0x4 (1000_7A53 / 0x17A53)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_7A56 / 0x17A56)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],BX (1000_7A58 / 0x17A58)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    State.IncCycles();
    // ADD DX,0x3d (1000_7A5B / 0x17A5B)
    DX += 0x3D;
    State.IncCycles();
    // ADD BX,0x3d (1000_7A5E / 0x17A5E)
    // BX += 0x3D;
    BX = Alu.Add16(BX, 0x3D);
    State.IncCycles();
    // MOV word ptr [SI + 0x4],DX (1000_7A61 / 0x17A61)
    UInt16[DS, (ushort)(SI + 0x4)] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_7A64 / 0x17A64)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    // CALL 0x1000:7b1b (1000_7A67 / 0x17A67)
    NearCall(cs1, 0x7A6A, spice86_generated_label_call_target_1000_7B1B_017B1B);
    State.IncCycles();
    label_1000_7A6A_17A6A:
    // MOV SI,word ptr [0x46ef] (1000_7A6A / 0x17A6A)
    SI = UInt16[DS, 0x46EF];
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x20 (1000_7A6E / 0x17A6E)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // JZ 0x1000:7a96 (1000_7A72 / 0x17A72)
    if(ZeroFlag) {
      goto label_1000_7A96_17A96;
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_7A74 / 0x17A74)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x2 (1000_7A77 / 0x17A77)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JNZ 0x1000:7a82 (1000_7A7B / 0x17A7B)
    if(!ZeroFlag) {
      goto label_1000_7A82_17A82;
    }
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_7A7D / 0x17A7D)
    NearCall(cs1, 0x7A80, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    // JC 0x1000:7a96 (1000_7A80 / 0x17A80)
    if(CarryFlag) {
      goto label_1000_7A96_17A96;
    }
    State.IncCycles();
    label_1000_7A82_17A82:
    // MOV AX,0xc (1000_7A82 / 0x17A82)
    AX = 0xC;
    State.IncCycles();
    // MOV [0x47c4],AX (1000_7A85 / 0x17A85)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // CALL 0x1000:91a0 (1000_7A88 / 0x17A88)
    NearCall(cs1, 0x7A8B, spice86_generated_label_call_target_1000_91A0_0191A0);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_7A8B / 0x17A8B)
    NearCall(cs1, 0x7A8E, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // MOV AX,0xc (1000_7A8E / 0x17A8E)
    AX = 0xC;
    State.IncCycles();
    // MOV BP,0x0 (1000_7A91 / 0x17A91)
    BP = 0x0;
    State.IncCycles();
    // JMP 0x1000:7ac1 (1000_7A94 / 0x17A94)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7AAB_017AAB, 0x17AC1 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_7A96_17A96:
    // MOV AX,0xf (1000_7A96 / 0x17A96)
    AX = 0xF;
    State.IncCycles();
    // MOV [0x47c4],AX (1000_7A99 / 0x17A99)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // MOV word ptr [0x4758],SI (1000_7A9C / 0x17A9C)
    UInt16[DS, 0x4758] = SI;
    State.IncCycles();
    // MOV byte ptr [0x476c],0x0 (1000_7AA0 / 0x17AA0)
    UInt8[DS, 0x476C] = 0x0;
    State.IncCycles();
    // CALL 0x1000:91a0 (1000_7AA5 / 0x17AA5)
    NearCall(cs1, 0x7AA8, spice86_generated_label_call_target_1000_91A0_0191A0);
    State.IncCycles();
    label_1000_7AA8_17AA8:
    // CALL 0x1000:c0f4 (1000_7AA8 / 0x17AA8)
    NearCall(cs1, 0x7AAB, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7AAB_017AAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7AAB_017AAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7AAB_17AAB:
    // MOV AX,[0x22a6] (1000_7AAB / 0x17AAB)
    AX = UInt16[DS, 0x22A6];
    State.IncCycles();
    // SUB AX,0xe (1000_7AAE / 0x17AAE)
    AX -= 0xE;
    State.IncCycles();
    // SHL AX,1 (1000_7AB1 / 0x17AB1)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_7AB3 / 0x17AB3)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BL,byte ptr [0x47d0] (1000_7AB5 / 0x17AB5)
    BL = UInt8[DS, 0x47D0];
    State.IncCycles();
    // DEC BL (1000_7AB9 / 0x17AB9)
    BL--;
    State.IncCycles();
    // XOR BH,BH (1000_7ABB / 0x17ABB)
    BH = 0;
    State.IncCycles();
    // SHL BX,1 (1000_7ABD / 0x17ABD)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV BP,BX (1000_7ABF / 0x17ABF)
    BP = BX;
    State.IncCycles();
    label_1000_7AC1_17AC1:
    // MOV SI,0x22b9 (1000_7AC1 / 0x17AC1)
    SI = 0x22B9;
    State.IncCycles();
    // ADD SI,AX (1000_7AC4 / 0x17AC4)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // LODSW SI (1000_7AC6 / 0x17AC6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV [0x46d2],AX (1000_7AC7 / 0x17AC7)
    UInt16[DS, 0x46D2] = AX;
    State.IncCycles();
    // LODSW SI (1000_7ACA / 0x17ACA)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV [0x46d4],AX (1000_7ACB / 0x17ACB)
    UInt16[DS, 0x46D4] = AX;
    State.IncCycles();
    // PUSH DS (1000_7ACE / 0x17ACE)
    Stack.Push(DS);
    State.IncCycles();
    // MOV SI,word ptr SS:[0x47ca] (1000_7ACF / 0x17ACF)
    SI = UInt16[SS, 0x47CA];
    State.IncCycles();
    // MOV DS,word ptr SS:[0xdbb2] (1000_7AD4 / 0x17AD4)
    DS = UInt16[SS, 0xDBB2];
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_7AD9 / 0x17AD9)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // MOV DX,word ptr SS:[0x18f3] (1000_7ADC / 0x17ADC)
    DX = UInt16[SS, 0x18F3];
    State.IncCycles();
    // MOV BX,word ptr SS:[0x18f5] (1000_7AE1 / 0x17AE1)
    BX = UInt16[SS, 0x18F5];
    State.IncCycles();
    // INC BX (1000_7AE6 / 0x17AE6)
    BX++;
    State.IncCycles();
    // INC DX (1000_7AE7 / 0x17AE7)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // MOV word ptr SS:[0x47d4],DX (1000_7AE8 / 0x17AE8)
    UInt16[SS, 0x47D4] = DX;
    State.IncCycles();
    // MOV word ptr SS:[0x47d6],BX (1000_7AED / 0x17AED)
    UInt16[SS, 0x47D6] = BX;
    State.IncCycles();
    // ADD DX,0x3b (1000_7AF2 / 0x17AF2)
    DX += 0x3B;
    State.IncCycles();
    // ADD BX,0x3b (1000_7AF5 / 0x17AF5)
    // BX += 0x3B;
    BX = Alu.Add16(BX, 0x3B);
    State.IncCycles();
    // MOV word ptr SS:[0x47d8],DX (1000_7AF8 / 0x17AF8)
    UInt16[SS, 0x47D8] = DX;
    State.IncCycles();
    // MOV word ptr SS:[0x47da],BX (1000_7AFD / 0x17AFD)
    UInt16[SS, 0x47DA] = BX;
    State.IncCycles();
    // CALL 0x1000:9d6a (1000_7B02 / 0x17B02)
    NearCall(cs1, 0x7B05, spice86_generated_label_call_target_1000_9D6A_019D6A);
    State.IncCycles();
    label_1000_7B05_17B05:
    // POP DS (1000_7B05 / 0x17B05)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x47d4 (1000_7B06 / 0x17B06)
    SI = 0x47D4;
    State.IncCycles();
    // CALL 0x1000:c4aa (1000_7B09 / 0x17B09)
    NearCall(cs1, 0x7B0C, spice86_generated_label_call_target_1000_C4AA_01C4AA);
    State.IncCycles();
    label_1000_7B0C_17B0C:
    // JMP 0x1000:c13b (1000_7B0C / 0x17B0C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B0F_017B0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B0F_17B0F:
    // MOV byte ptr [0x46d8],0x0 (1000_7B0F / 0x17B0F)
    UInt8[DS, 0x46D8] = 0x0;
    State.IncCycles();
    // PUSH SI (1000_7B14 / 0x17B14)
    Stack.Push(SI);
    State.IncCycles();
    // XCHG DI,SI (1000_7B15 / 0x17B15)
    ushort tmp_1000_7B15 = DI;
    DI = SI;
    SI = tmp_1000_7B15;
    State.IncCycles();
    // CALL 0x1000:c0e8 (1000_7B17 / 0x17B17)
    NearCall(cs1, 0x7B1A, spice86_generated_label_call_target_1000_C0E8_01C0E8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B1A_017B1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B1A_017B1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B1A_17B1A:
    // POP SI (1000_7B1A / 0x17B1A)
    SI = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7B1B_017B1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B1B_017B1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B1B_17B1B:
    // MOV ES,word ptr [0xdbda] (1000_7B1B / 0x17B1B)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x9] (1000_7B1F / 0x17B1F)
    AL = UInt8[DS, (ushort)(SI + 0x9)];
    State.IncCycles();
    // PUSH SI (1000_7B22 / 0x17B22)
    Stack.Push(SI);
    State.IncCycles();
    // CALLF [0x38dd] (1000_7B23 / 0x17B23)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_7B23 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_7B23) {
      case 0x235CE : FarCall(cs1, 0x7B27, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_7B23));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B27_017B27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B27_017B27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B27_17B27:
    // POP SI (1000_7B27 / 0x17B27)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c551 (1000_7B28 / 0x17B28)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C551_01C551, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B2B_017B2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B2B_17B2B:
    // CMP byte ptr [0x46d8],0x0 (1000_7B2B / 0x17B2B)
    Alu.Sub8(UInt8[DS, 0x46D8], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7b35 (1000_7B30 / 0x17B30)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7B35 / 0x17B35)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:c0e8 (1000_7B32 / 0x17B32)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C0E8_01C0E8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_7B35_17B35:
    // RET  (1000_7B35 / 0x17B35)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B36_017B36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B36_17B36:
    // PUSH SI (1000_7B36 / 0x17B36)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_7B37 / 0x17B37)
    Stack.Push(DI);
    State.IncCycles();
    // MOV byte ptr [0x46d8],0x1 (1000_7B38 / 0x17B38)
    UInt8[DS, 0x46D8] = 0x1;
    State.IncCycles();
    // MOV byte ptr [0xdce6],0x80 (1000_7B3D / 0x17B3D)
    UInt8[DS, 0xDCE6] = 0x80;
    State.IncCycles();
    // CALL 0x1000:8770 (1000_7B42 / 0x17B42)
    NearCall(cs1, 0x7B45, spice86_generated_label_call_target_1000_8770_018770);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B45_017B45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B45_017B45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B45_17B45:
    // CALL 0x1000:5f79 (1000_7B45 / 0x17B45)
    NearCall(cs1, 0x7B48, spice86_generated_label_call_target_1000_5F79_015F79);
    State.IncCycles();
    label_1000_7B48_17B48:
    // CALL 0x1000:79de (1000_7B48 / 0x17B48)
    NearCall(cs1, 0x7B4B, spice86_generated_label_call_target_1000_79DE_0179DE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B4B_017B4B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B4B_017B4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B4B_17B4B:
    // MOV byte ptr [0xdce6],0x0 (1000_7B4B / 0x17B4B)
    UInt8[DS, 0xDCE6] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x46f4],0x0 (1000_7B50 / 0x17B50)
    UInt8[DS, 0x46F4] = 0x0;
    State.IncCycles();
    // POP DI (1000_7B55 / 0x17B55)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_7B56 / 0x17B56)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7B57 / 0x17B57)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7B58_017B58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B58_17B58:
    // MOV word ptr [0x1bea],0x0 (1000_7B58 / 0x17B58)
    UInt16[DS, 0x1BEA] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x46f4],0x0 (1000_7B5E / 0x17B5E)
    UInt8[DS, 0x46F4] = 0x0;
    State.IncCycles();
    // XOR SI,SI (1000_7B63 / 0x17B63)
    SI = 0;
    State.IncCycles();
    // MOV byte ptr [0x4c],0x0 (1000_7B65 / 0x17B65)
    UInt8[DS, 0x4C] = 0x0;
    State.IncCycles();
    // XCHG word ptr [0x46ef],SI (1000_7B6A / 0x17B6A)
    ushort tmp_1000_7B6A = UInt16[DS, 0x46EF];
    UInt16[DS, 0x46EF] = SI;
    SI = tmp_1000_7B6A;
    State.IncCycles();
    // OR SI,SI (1000_7B6E / 0x17B6E)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:7ba2 (1000_7B70 / 0x17B70)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7BA2 / 0x17BA2)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x4c],0x0 (1000_7B72 / 0x17B72)
    Alu.Sub8(UInt8[DS, 0x4C], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7b8c (1000_7B77 / 0x17B77)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B89_017B89, 0x17B8C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:1ebe (1000_7B79 / 0x17B79)
    NearCall(cs1, 0x7B7C, spice86_generated_label_call_target_1000_1EBE_011EBE);
    State.IncCycles();
    label_1000_7B7C_17B7C:
    // AND word ptr [SI + 0x10],0x3f0 (1000_7B7C / 0x17B7C)
    UInt16[DS, (ushort)(SI + 0x10)] &= 0x3F0;
    State.IncCycles();
    // AND word ptr [SI + 0x12],0xe5ff (1000_7B81 / 0x17B81)
    // UInt16[DS, (ushort)(SI + 0x12)] &= 0xE5FF;
    UInt16[DS, (ushort)(SI + 0x12)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0xE5FF);
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_7B86 / 0x17B86)
    NearCall(cs1, 0x7B89, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B89_017B89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B89_017B89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7B89_17B89:
    // MOV byte ptr [SI + 0x14],AL (1000_7B89 / 0x17B89)
    UInt8[DS, (ushort)(SI + 0x14)] = AL;
    State.IncCycles();
    label_1000_7B8C_17B8C:
    // CALL 0x1000:a7a5 (1000_7B8C / 0x17B8C)
    NearCall(cs1, 0x7B8F, spice86_generated_label_call_target_1000_A7A5_01A7A5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7B8F_017B8F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7B8F_017B8F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x7BA2: goto label_1000_7BA2_17BA2;break; // Target of external jump from 0x17B70
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_7B8F_17B8F:
    // MOV SI,0x18e9 (1000_7B8F / 0x17B8F)
    SI = 0x18E9;
    State.IncCycles();
    // XOR AX,AX (1000_7B92 / 0x17B92)
    AX = 0;
    State.IncCycles();
    // MOV [0xdbe0],AX (1000_7B94 / 0x17B94)
    UInt16[DS, 0xDBE0] = AX;
    State.IncCycles();
    // MOV [0x47ba],AX (1000_7B97 / 0x17B97)
    UInt16[DS, 0x47BA] = AX;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_7B9A / 0x17B9A)
    NearCall(cs1, 0x7B9D, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    State.IncCycles();
    label_1000_7B9D_17B9D:
    // MOV AL,0x4 (1000_7B9D / 0x17B9D)
    AL = 0x4;
    State.IncCycles();
    // CALL 0x1000:7b2b (1000_7B9F / 0x17B9F)
    NearCall(cs1, 0x7BA2, spice86_generated_label_call_target_1000_7B2B_017B2B);
    State.IncCycles();
    label_1000_7BA2_17BA2:
    // RET  (1000_7BA2 / 0x17BA2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7BA3_017BA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BA3_17BA3:
    // CALL 0x1000:c08e (1000_7BA3 / 0x17BA3)
    NearCall(cs1, 0x7BA6, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BA6_017BA6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BA6_017BA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BA6_17BA6:
    // CMP SI,word ptr [0x46ef] (1000_7BA6 / 0x17BA6)
    Alu.Sub16(SI, UInt16[DS, 0x46EF]);
    State.IncCycles();
    // JZ 0x1000:7bb8 (1000_7BAA / 0x17BAA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7BB8 / 0x17BB8)
      return NearRet();
    }
    State.IncCycles();
    // PUSH SI (1000_7BAC / 0x17BAC)
    Stack.Push(SI);
    State.IncCycles();
    // MOV word ptr [0x46f1],SI (1000_7BAD / 0x17BAD)
    UInt16[DS, 0x46F1] = SI;
    State.IncCycles();
    // CALL 0x1000:79ee (1000_7BB1 / 0x17BB1)
    NearCall(cs1, 0x7BB4, spice86_generated_label_call_target_1000_79EE_0179EE);
    State.IncCycles();
    label_1000_7BB4_17BB4:
    // CALL 0x1000:9f40 (1000_7BB4 / 0x17BB4)
    NearCall(cs1, 0x7BB7, spice86_generated_label_call_target_1000_9F40_019F40);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BB7_017BB7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BB7_017BB7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x7BB8: goto label_1000_7BB8_17BB8;break; // Target of external jump from 0x17BAA
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_7BB7_17BB7:
    // POP SI (1000_7BB7 / 0x17BB7)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_7BB8_17BB8:
    // RET  (1000_7BB8 / 0x17BB8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7BB9_017BB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BB9_17BB9:
    // PUSH AX (1000_7BB9 / 0x17BB9)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:31f6 (1000_7BBA / 0x17BBA)
    NearCall(cs1, 0x7BBD, spice86_generated_label_call_target_1000_31F6_0131F6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BBD_017BBD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BBD_017BBD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BBD_17BBD:
    // POP AX (1000_7BBD / 0x17BBD)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0x46f1],SI (1000_7BBE / 0x17BBE)
    UInt16[DS, 0x46F1] = SI;
    State.IncCycles();
    // MOV [0x23],AL (1000_7BC2 / 0x17BC2)
    UInt8[DS, 0x23] = AL;
    State.IncCycles();
    // MOV word ptr [0x47ba],0x0 (1000_7BC5 / 0x17BC5)
    UInt16[DS, 0x47BA] = 0x0;
    State.IncCycles();
    // CALL 0x1000:c08e (1000_7BCB / 0x17BCB)
    NearCall(cs1, 0x7BCE, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BCE_017BCE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BCE_017BCE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BCE_17BCE:
    // MOV AX,0xf (1000_7BCE / 0x17BCE)
    AX = 0xF;
    State.IncCycles();
    // CALL 0x1000:96f1 (1000_7BD1 / 0x17BD1)
    NearCall(cs1, 0x7BD4, spice86_generated_label_call_target_1000_96F1_0196F1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7BD4_017BD4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7BD4_017BD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BD4_17BD4:
    // JC 0x1000:7bd9 (1000_7BD4 / 0x17BD4)
    if(CarryFlag) {
      goto label_1000_7BD9_17BD9;
    }
    State.IncCycles();
    // CALL 0x1000:9efd (1000_7BD6 / 0x17BD6)
    NearCall(cs1, 0x7BD9, spice86_generated_label_call_target_1000_9EFD_019EFD);
    State.IncCycles();
    label_1000_7BD9_17BD9:
    // MOV SI,word ptr [0x46f1] (1000_7BD9 / 0x17BD9)
    SI = UInt16[DS, 0x46F1];
    State.IncCycles();
    // JMP 0x1000:7c56 (1000_7BDD / 0x17BDD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C56_017C56, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7BE0_017BE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7BE0_17BE0:
    // CMP SI,word ptr [0x46ef] (1000_7BE0 / 0x17BE0)
    Alu.Sub16(SI, UInt16[DS, 0x46EF]);
    State.IncCycles();
    // JZ 0x1000:7be7 (1000_7BE4 / 0x17BE4)
    if(ZeroFlag) {
      goto label_1000_7BE7_17BE7;
    }
    State.IncCycles();
    // RET  (1000_7BE6 / 0x17BE6)
    return NearRet();
    State.IncCycles();
    label_1000_7BE7_17BE7:
    // MOV word ptr [0x47ba],0x0 (1000_7BE7 / 0x17BE7)
    UInt16[DS, 0x47BA] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x46f4],0x0 (1000_7BED / 0x17BED)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    State.IncCycles();
    // JZ 0x1000:7bfe (1000_7BF2 / 0x17BF2)
    if(ZeroFlag) {
      goto label_1000_7BFE_17BFE;
    }
    State.IncCycles();
    // CMP byte ptr [0x46f5],0x0 (1000_7BF4 / 0x17BF4)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    State.IncCycles();
    // JZ 0x1000:7bfe (1000_7BF9 / 0x17BF9)
    if(ZeroFlag) {
      goto label_1000_7BFE_17BFE;
    }
    State.IncCycles();
    // JMP 0x1000:7e97 (1000_7BFB / 0x17BFB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E97_017E97, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_7BFE_17BFE:
    // MOV SI,word ptr [0x46ef] (1000_7BFE / 0x17BFE)
    SI = UInt16[DS, 0x46EF];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7C02_017C02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7C02_017C02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C02_17C02:
    // CALL 0x1000:7ba3 (1000_7C02 / 0x17C02)
    NearCall(cs1, 0x7C05, spice86_generated_label_call_target_1000_7BA3_017BA3);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C05_017C05, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C05_017C05(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C05_17C05:
    // CALL 0x1000:31f6 (1000_7C05 / 0x17C05)
    NearCall(cs1, 0x7C08, spice86_generated_label_call_target_1000_31F6_0131F6);
    State.IncCycles();
    label_1000_7C08_17C08:
    // MOV DI,word ptr [SI + 0x4] (1000_7C08 / 0x17C08)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL 0x1000:2e98 (1000_7C0B / 0x17C0B)
    NearCall(cs1, 0x7C0E, spice86_generated_label_call_target_1000_2E98_012E98);
    State.IncCycles();
    label_1000_7C0E_17C0E:
    // CALL 0x1000:7c63 (1000_7C0E / 0x17C0E)
    NearCall(cs1, 0x7C11, spice86_generated_label_call_target_1000_7C63_017C63);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C11_017C11, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C11_017C11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C11_17C11:
    // CMP AX,word ptr [0x1176] (1000_7C11 / 0x17C11)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    State.IncCycles();
    // JBE 0x1000:7c2d (1000_7C15 / 0x17C15)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C2D_017C2D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr [0x4c],0xff (1000_7C17 / 0x17C17)
    UInt8[DS, 0x4C] = 0xFF;
    State.IncCycles();
    // MOV DI,word ptr [0x4752] (1000_7C1C / 0x17C1C)
    DI = UInt16[DS, 0x4752];
    State.IncCycles();
    // OR DI,DI (1000_7C20 / 0x17C20)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:7c2d (1000_7C22 / 0x17C22)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C2D_017C2D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AX,0x1916 (1000_7C24 / 0x17C24)
    AX = 0x1916;
    State.IncCycles();
    // MOV word ptr [DI + 0xd],AX (1000_7C27 / 0x17C27)
    UInt16[DS, (ushort)(DI + 0xD)] = AX;
    State.IncCycles();
    // MOV word ptr [DI + 0xf],AX (1000_7C2A / 0x17C2A)
    UInt16[DS, (ushort)(DI + 0xF)] = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C2D_017C2D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7C2D_017C2D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C2D_17C2D:
    // CALL 0x1000:9719 (1000_7C2D / 0x17C2D)
    NearCall(cs1, 0x7C30, spice86_generated_label_call_target_1000_9719_019719);
    State.IncCycles();
    label_1000_7C30_17C30:
    // MOV SI,word ptr [0x46ef] (1000_7C30 / 0x17C30)
    SI = UInt16[DS, 0x46EF];
    State.IncCycles();
    // JC 0x1000:7c2d (1000_7C34 / 0x17C34)
    if(CarryFlag) {
      goto label_1000_7C2D_17C2D;
    }
    State.IncCycles();
    // PUSH SI (1000_7C36 / 0x17C36)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:9efd (1000_7C37 / 0x17C37)
    NearCall(cs1, 0x7C3A, spice86_generated_label_call_target_1000_9EFD_019EFD);
    State.IncCycles();
    label_1000_7C3A_17C3A:
    // POP SI (1000_7C3A / 0x17C3A)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [0x46f4],0x0 (1000_7C3B / 0x17C3B)
    UInt8[DS, 0x46F4] = 0x0;
    State.IncCycles();
    // CMP byte ptr [0x47a5],0x80 (1000_7C40 / 0x17C40)
    Alu.Sub8(UInt8[DS, 0x47A5], 0x80);
    State.IncCycles();
    // JNZ 0x1000:7c56 (1000_7C45 / 0x17C45)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C56_017C56, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // INC byte ptr [0x46f4] (1000_7C47 / 0x17C47)
    UInt8[DS, 0x46F4] = Alu.Inc8(UInt8[DS, 0x46F4]);
    State.IncCycles();
    // CALL 0x1000:7efb (1000_7C4B / 0x17C4B)
    NearCall(cs1, 0x7C4E, spice86_generated_label_call_target_1000_7EFB_017EFB);
    State.IncCycles();
    label_1000_7C4E_17C4E:
    // PUSH SI (1000_7C4E / 0x17C4E)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:7e1e (1000_7C4F / 0x17C4F)
    NearCall(cs1, 0x7C52, spice86_generated_label_call_target_1000_7E1E_017E1E);
    State.IncCycles();
    label_1000_7C52_17C52:
    // POP SI (1000_7C52 / 0x17C52)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:7c56 (1000_7C53 / 0x17C53)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7C56_017C56, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7C56_017C56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C56_17C56:
    // CMP byte ptr [0x46eb],0x0 (1000_7C56 / 0x17C56)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNS 0x1000:7c60 (1000_7C5B / 0x17C5B)
    if(!SignFlag) {
      // JNS target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:c07c (1000_7C60 / 0x17C60)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:9901 (1000_7C5D / 0x17C5D)
    NearCall(cs1, 0x7C60, spice86_generated_label_call_target_1000_9901_019901);
    State.IncCycles();
    label_1000_7C60_17C60:
    // JMP 0x1000:c07c (1000_7C60 / 0x17C60)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7C63_017C63(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C63_17C63:
    // PUSH SI (1000_7C63 / 0x17C63)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:407e (1000_7C64 / 0x17C64)
    NearCall(cs1, 0x7C67, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C67_017C67, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C67_017C67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C67_17C67:
    // POP SI (1000_7C67 / 0x17C67)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV BP,BX (1000_7C68 / 0x17C68)
    BP = BX;
    State.IncCycles();
    // SHL BP,1 (1000_7C6A / 0x17C6A)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // JNS 0x1000:7c70 (1000_7C6C / 0x17C6C)
    if(!SignFlag) {
      goto label_1000_7C70_17C70;
    }
    State.IncCycles();
    // NEG BP (1000_7C6E / 0x17C6E)
    BP = Alu.Sub16(0, BP);
    State.IncCycles();
    label_1000_7C70_17C70:
    // MOV BP,word ptr [BP + 0x4880] (1000_7C70 / 0x17C70)
    BP = UInt16[SS, (ushort)(BP + 0x4880)];
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_7C74 / 0x17C74)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // SUB AX,DX (1000_7C77 / 0x17C77)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JNS 0x1000:7c7d (1000_7C79 / 0x17C79)
    if(!SignFlag) {
      goto label_1000_7C7D_17C7D;
    }
    State.IncCycles();
    // NEG AX (1000_7C7B / 0x17C7B)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_7C7D_17C7D:
    // XOR DX,DX (1000_7C7D / 0x17C7D)
    DX = 0;
    State.IncCycles();
    // DIV BP (1000_7C7F / 0x17C7F)
    Cpu.Div16(BP);
    State.IncCycles();
    // SUB BX,word ptr [SI + 0x8] (1000_7C81 / 0x17C81)
    // BX -= UInt16[DS, (ushort)(SI + 0x8)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x8)]);
    State.IncCycles();
    // JNS 0x1000:7c88 (1000_7C84 / 0x17C84)
    if(!SignFlag) {
      goto label_1000_7C88_17C88;
    }
    State.IncCycles();
    // NEG BX (1000_7C86 / 0x17C86)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_7C88_17C88:
    // CMP AX,BX (1000_7C88 / 0x17C88)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JNC 0x1000:7c8e (1000_7C8A / 0x17C8A)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7C8E / 0x17C8E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,BX (1000_7C8C / 0x17C8C)
    AX = BX;
    State.IncCycles();
    label_1000_7C8E_17C8E:
    // RET  (1000_7C8E / 0x17C8E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7C8F_017C8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C8F_17C8F:
    // PUSH SI (1000_7C8F / 0x17C8F)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:407e (1000_7C90 / 0x17C90)
    NearCall(cs1, 0x7C93, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7C93_017C93, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7C93_017C93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7C93_17C93:
    // POP SI (1000_7C93 / 0x17C93)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV BP,BX (1000_7C94 / 0x17C94)
    BP = BX;
    State.IncCycles();
    // SHL BP,1 (1000_7C96 / 0x17C96)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // JNS 0x1000:7c9c (1000_7C98 / 0x17C98)
    if(!SignFlag) {
      goto label_1000_7C9C_17C9C;
    }
    State.IncCycles();
    // NEG BP (1000_7C9A / 0x17C9A)
    BP = Alu.Sub16(0, BP);
    State.IncCycles();
    label_1000_7C9C_17C9C:
    // MOV BP,word ptr [BP + 0x4880] (1000_7C9C / 0x17C9C)
    BP = UInt16[SS, (ushort)(BP + 0x4880)];
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_7CA0 / 0x17CA0)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SUB AX,DX (1000_7CA3 / 0x17CA3)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // JNS 0x1000:7ca9 (1000_7CA5 / 0x17CA5)
    if(!SignFlag) {
      goto label_1000_7CA9_17CA9;
    }
    State.IncCycles();
    // NEG AX (1000_7CA7 / 0x17CA7)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_7CA9_17CA9:
    // XOR DX,DX (1000_7CA9 / 0x17CA9)
    DX = 0;
    State.IncCycles();
    // DIV BP (1000_7CAB / 0x17CAB)
    Cpu.Div16(BP);
    State.IncCycles();
    // SUB BX,word ptr [SI + 0x4] (1000_7CAD / 0x17CAD)
    // BX -= UInt16[DS, (ushort)(SI + 0x4)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JNS 0x1000:7cb4 (1000_7CB0 / 0x17CB0)
    if(!SignFlag) {
      goto label_1000_7CB4_17CB4;
    }
    State.IncCycles();
    // NEG BX (1000_7CB2 / 0x17CB2)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_7CB4_17CB4:
    // CMP AX,BX (1000_7CB4 / 0x17CB4)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JNC 0x1000:7cba (1000_7CB6 / 0x17CB6)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7CBA / 0x17CBA)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,BX (1000_7CB8 / 0x17CB8)
    AX = BX;
    State.IncCycles();
    label_1000_7CBA_17CBA:
    // RET  (1000_7CBA / 0x17CBA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7CBB_017CBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CBB_17CBB:
    // MOV byte ptr [0x46f5],0x1 (1000_7CBB / 0x17CBB)
    UInt8[DS, 0x46F5] = 0x1;
    State.IncCycles();
    // MOV BP,0x2012 (1000_7CC0 / 0x17CC0)
    BP = 0x2012;
    State.IncCycles();
    // MOV BX,0x7d68 (1000_7CC3 / 0x17CC3)
    BX = 0x7D68;
    State.IncCycles();
    // CALL 0x1000:d323 (1000_7CC6 / 0x17CC6)
    NearCall(cs1, 0x7CC9, spice86_generated_label_call_target_1000_D323_01D323);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CC9_017CC9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CC9_017CC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CC9_17CC9:
    // CALL 0x1000:c13b (1000_7CC9 / 0x17CC9)
    NearCall(cs1, 0x7CCC, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CCC_017CCC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CCC_017CCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CCC_17CCC:
    // CMP byte ptr [0x46f4],0x0 (1000_7CCC / 0x17CCC)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7cf1 (1000_7CD1 / 0x17CD1)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,word ptr [0x46ef] (1000_7CD3 / 0x17CD3)
    SI = UInt16[DS, 0x46EF];
    State.IncCycles();
    // CALL 0x1000:7be0 (1000_7CD7 / 0x17CD7)
    NearCall(cs1, 0x7CDA, spice86_generated_label_call_target_1000_7BE0_017BE0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CDA_017CDA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CDA_017CDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CDA_17CDA:
    // CALL 0x1000:7c02 (1000_7CDA / 0x17CDA)
    NearCall(cs1, 0x7CDD, spice86_generated_label_call_target_1000_7C02_017C02);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CDD_017CDD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CDD_017CDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CDD_17CDD:
    // CMP byte ptr [0x46f4],0x0 (1000_7CDD / 0x17CDD)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7cf1 (1000_7CE2 / 0x17CE2)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:7c02 (1000_7CE4 / 0x17CE4)
    NearCall(cs1, 0x7CE7, spice86_generated_label_call_target_1000_7C02_017C02);
    State.IncCycles();
    // CMP byte ptr [0x46f4],0x0 (1000_7CE7 / 0x17CE7)
    Alu.Sub8(UInt8[DS, 0x46F4], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7cf1 (1000_7CEC / 0x17CEC)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:7c02 (1000_7CEE / 0x17CEE)
    NearCall(cs1, 0x7CF1, spice86_generated_label_call_target_1000_7C02_017C02);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_7CF1_017CF1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_7CF1_017CF1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CF1_17CF1:
    // CALL 0x1000:7dd9 (1000_7CF1 / 0x17CF1)
    NearCall(cs1, 0x7CF4, spice86_generated_label_call_target_1000_7DD9_017DD9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CF4_017CF4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CF4_017CF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CF4_17CF4:
    // CALL 0x1000:68eb (1000_7CF4 / 0x17CF4)
    NearCall(cs1, 0x7CF7, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7CF7_017CF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7CF7_017CF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7CF7_17CF7:
    // MOV AL,byte ptr [SI + 0x19] (1000_7CF7 / 0x17CF7)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // MOV [0x3d],AL (1000_7CFA / 0x17CFA)
    UInt8[DS, 0x3D] = AL;
    State.IncCycles();
    // CALL 0x1000:7efb (1000_7CFD / 0x17CFD)
    NearCall(cs1, 0x7D00, spice86_generated_label_call_target_1000_7EFB_017EFB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D00_017D00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D00_017D00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D00_17D00:
    // MOV DI,word ptr [SI + 0x4] (1000_7D00 / 0x17D00)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_7D03 / 0x17D03)
    NearCall(cs1, 0x7D06, spice86_generated_label_call_target_1000_7F27_017F27);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D06_017D06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D06_017D06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D06_17D06:
    // MOV word ptr [0x1bea],0x0 (1000_7D06 / 0x17D06)
    UInt16[DS, 0x1BEA] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7D0C_017D0C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7D0C_017D0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D0C_17D0C:
    // CALL 0x1000:c08e (1000_7D0C / 0x17D0C)
    NearCall(cs1, 0x7D0F, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D0F_017D0F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D0F_017D0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D0F_17D0F:
    // MOV SI,0x1936 (1000_7D0F / 0x17D0F)
    SI = 0x1936;
    State.IncCycles();
    // CALL 0x1000:7b1b (1000_7D12 / 0x17D12)
    NearCall(cs1, 0x7D15, spice86_generated_label_call_target_1000_7B1B_017B1B);
    State.IncCycles();
    label_1000_7D15_17D15:
    // MOV SI,0x1940 (1000_7D15 / 0x17D15)
    SI = 0x1940;
    State.IncCycles();
    // CALL 0x1000:7b1b (1000_7D18 / 0x17D18)
    NearCall(cs1, 0x7D1B, spice86_generated_label_call_target_1000_7B1B_017B1B);
    State.IncCycles();
    label_1000_7D1B_17D1B:
    // CALL 0x1000:7e1e (1000_7D1B / 0x17D1B)
    NearCall(cs1, 0x7D1E, spice86_generated_label_call_target_1000_7E1E_017E1E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D1E_017D1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D1E_017D1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D1E_17D1E:
    // PUSH DS (1000_7D1E / 0x17D1E)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_7D1F / 0x17D1F)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x4c60 (1000_7D20 / 0x17D20)
    SI = 0x4C60;
    State.IncCycles();
    // MOV DI,0x4c7c (1000_7D23 / 0x17D23)
    DI = 0x4C7C;
    State.IncCycles();
    // MOV CX,0xe (1000_7D26 / 0x17D26)
    CX = 0xE;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_7D29 / 0x17D29)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOV BX,word ptr [0x1942] (1000_7D2B / 0x17D2B)
    BX = UInt16[DS, 0x1942];
    State.IncCycles();
    // ADD BX,0x4 (1000_7D2F / 0x17D2F)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    State.IncCycles();
    // MOV DX,word ptr [0x1940] (1000_7D32 / 0x17D32)
    DX = UInt16[DS, 0x1940];
    State.IncCycles();
    // ADD DX,0x50 (1000_7D36 / 0x17D36)
    // DX += 0x50;
    DX = Alu.Add16(DX, 0x50);
    State.IncCycles();
    // MOV SI,0x46fe (1000_7D39 / 0x17D39)
    SI = 0x46FE;
    State.IncCycles();
    // MOV BP,word ptr [0x1946] (1000_7D3C / 0x17D3C)
    BP = UInt16[DS, 0x1946];
    State.IncCycles();
    // MOV CX,word ptr [0x1948] (1000_7D40 / 0x17D40)
    CX = UInt16[DS, 0x1948];
    State.IncCycles();
    // MOV word ptr [0xdbe4],CX (1000_7D44 / 0x17D44)
    UInt16[DS, 0xDBE4] = CX;
    State.IncCycles();
    // CALL 0x1000:7e3d (1000_7D48 / 0x17D48)
    NearCall(cs1, 0x7D4B, spice86_generated_label_call_target_1000_7E3D_017E3D);
    State.IncCycles();
    label_1000_7D4B_17D4B:
    // MOV CX,word ptr [0x1948] (1000_7D4B / 0x17D4B)
    CX = UInt16[DS, 0x1948];
    State.IncCycles();
    // MOV DX,word ptr [0x1940] (1000_7D4F / 0x17D4F)
    DX = UInt16[DS, 0x1940];
    State.IncCycles();
    // ADD DX,0x8 (1000_7D53 / 0x17D53)
    // DX += 0x8;
    DX = Alu.Add16(DX, 0x8);
    State.IncCycles();
    // MOV AX,0x6f (1000_7D56 / 0x17D56)
    AX = 0x6F;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_7D59 / 0x17D59)
    NearCall(cs1, 0x7D5C, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    label_1000_7D5C_17D5C:
    // CALL 0x1000:e270 (1000_7D5C / 0x17D5C)
    NearCall(cs1, 0x7D5F, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_7D5F_17D5F:
    // CALL 0x1000:d280 (1000_7D5F / 0x17D5F)
    NearCall(cs1, 0x7D62, spice86_generated_label_call_target_1000_D280_01D280);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D62_017D62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D62_017D62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D62_17D62:
    // CALL 0x1000:e283 (1000_7D62 / 0x17D62)
    NearCall(cs1, 0x7D65, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_7D65_17D65:
    // JMP 0x1000:c07c (1000_7D65 / 0x17D65)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7D68_017D68(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D68_17D68:
    // MOV byte ptr [0x46f5],0x0 (1000_7D68 / 0x17D68)
    UInt8[DS, 0x46F5] = 0x0;
    State.IncCycles();
    // XOR SI,SI (1000_7D6D / 0x17D6D)
    SI = 0;
    State.IncCycles();
    // MOV word ptr [0xdbe2],0x0 (1000_7D6F / 0x17D6F)
    UInt16[DS, 0xDBE2] = 0x0;
    State.IncCycles();
    // MOV SI,0x1940 (1000_7D75 / 0x17D75)
    SI = 0x1940;
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_7D78 / 0x17D78)
    NearCall(cs1, 0x7D7B, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7D7B_017D7B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7D7B_017D7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7D7B_17D7B:
    // CALL 0x1000:68eb (1000_7D7B / 0x17D7B)
    NearCall(cs1, 0x7D7E, spice86_generated_label_call_target_1000_68EB_0168EB);
    State.IncCycles();
    label_1000_7D7E_17D7E:
    // CALL 0x1000:7f11 (1000_7D7E / 0x17D7E)
    NearCall(cs1, 0x7D81, spice86_generated_label_call_target_1000_7F11_017F11);
    State.IncCycles();
    label_1000_7D81_17D81:
    // CALL 0x1000:8461 (1000_7D81 / 0x17D81)
    NearCall(cs1, 0x7D84, spice86_generated_label_call_target_1000_8461_018461);
    State.IncCycles();
    label_1000_7D84_17D84:
    // MOV AH,byte ptr [SI + 0x19] (1000_7D84 / 0x17D84)
    AH = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // MOV AL,[0x3d] (1000_7D87 / 0x17D87)
    AL = UInt8[DS, 0x3D];
    State.IncCycles();
    // MOV BL,AL (1000_7D8A / 0x17D8A)
    BL = AL;
    State.IncCycles();
    // XOR BL,AH (1000_7D8C / 0x17D8C)
    BL ^= AH;
    State.IncCycles();
    // AND AH,BL (1000_7D8E / 0x17D8E)
    // AH &= BL;
    AH = Alu.And8(AH, BL);
    State.IncCycles();
    // MOV byte ptr [0x3d],AH (1000_7D90 / 0x17D90)
    UInt8[DS, 0x3D] = AH;
    State.IncCycles();
    // AND AL,BL (1000_7D94 / 0x17D94)
    // AL &= BL;
    AL = Alu.And8(AL, BL);
    State.IncCycles();
    // MOV [0x3e],AL (1000_7D96 / 0x17D96)
    UInt8[DS, 0x3E] = AL;
    State.IncCycles();
    // MOV byte ptr [0x3f],0x0 (1000_7D99 / 0x17D99)
    UInt8[DS, 0x3F] = 0x0;
    State.IncCycles();
    // TEST AH,0x40 (1000_7D9E / 0x17D9E)
    Alu.And8(AH, 0x40);
    State.IncCycles();
    // JZ 0x1000:7db1 (1000_7DA1 / 0x17DA1)
    if(ZeroFlag) {
      goto label_1000_7DB1_17DB1;
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_7DA3 / 0x17DA3)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP DI,word ptr [0x1150] (1000_7DA6 / 0x17DA6)
    Alu.Sub16(DI, UInt16[DS, 0x1150]);
    State.IncCycles();
    // JNZ 0x1000:7db1 (1000_7DAA / 0x17DAA)
    if(!ZeroFlag) {
      goto label_1000_7DB1_17DB1;
    }
    State.IncCycles();
    // MOV byte ptr [0x3f],0x40 (1000_7DAC / 0x17DAC)
    UInt8[DS, 0x3F] = 0x40;
    State.IncCycles();
    label_1000_7DB1_17DB1:
    // MOV AL,byte ptr [SI + 0x3] (1000_7DB1 / 0x17DB1)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_7DB4 / 0x17DB4)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,0x8 (1000_7DB6 / 0x17DB6)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNZ 0x1000:7dbd (1000_7DB8 / 0x17DB8)
    if(!ZeroFlag) {
      goto label_1000_7DBD_17DBD;
    }
    State.IncCycles();
    // CALL 0x1000:6c15 (1000_7DBA / 0x17DBA)
    NearCall(cs1, 0x7DBD, spice86_generated_label_call_target_1000_6C15_016C15);
    State.IncCycles();
    label_1000_7DBD_17DBD:
    // MOV AL,0xc (1000_7DBD / 0x17DBD)
    AL = 0xC;
    State.IncCycles();
    // CALL 0x1000:7bb9 (1000_7DBF / 0x17DBF)
    NearCall(cs1, 0x7DC2, spice86_generated_label_call_target_1000_7BB9_017BB9);
    State.IncCycles();
    label_1000_7DC2_17DC2:
    // MOV byte ptr [0x46f4],0x0 (1000_7DC2 / 0x17DC2)
    UInt8[DS, 0x46F4] = 0x0;
    State.IncCycles();
    // CMP word ptr [0x1bea],0x0 (1000_7DC7 / 0x17DC7)
    Alu.Sub16(UInt16[DS, 0x1BEA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7dd8 (1000_7DCC / 0x17DCC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7DD8 / 0x17DD8)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [0x46ef] (1000_7DCE / 0x17DCE)
    SI = UInt16[DS, 0x46EF];
    State.IncCycles();
    // CALL 0x1000:7be0 (1000_7DD2 / 0x17DD2)
    NearCall(cs1, 0x7DD5, spice86_generated_label_call_target_1000_7BE0_017BE0);
    State.IncCycles();
    // CALL 0x1000:7c02 (1000_7DD5 / 0x17DD5)
    NearCall(cs1, 0x7DD8, spice86_generated_label_call_target_1000_7C02_017C02);
    State.IncCycles();
    label_1000_7DD8_17DD8:
    // RET  (1000_7DD8 / 0x17DD8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7DD9_017DD9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7DD9_17DD9:
    // MOV SI,0x18e9 (1000_7DD9 / 0x17DD9)
    SI = 0x18E9;
    State.IncCycles();
    // MOV DI,0x1936 (1000_7DDC / 0x17DDC)
    DI = 0x1936;
    State.IncCycles();
    // MOV BP,0x1940 (1000_7DDF / 0x17DDF)
    BP = 0x1940;
    State.IncCycles();
    // MOV word ptr [0xdbe2],BP (1000_7DE2 / 0x17DE2)
    UInt16[DS, 0xDBE2] = BP;
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_7DE6 / 0x17DE6)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // ADD AX,0x30 (1000_7DE8 / 0x17DE8)
    // AX += 0x30;
    AX = Alu.Add16(AX, 0x30);
    State.IncCycles();
    // MOV word ptr [BP + 0x0],AX (1000_7DEB / 0x17DEB)
    UInt16[SS, BP] = AX;
    State.IncCycles();
    // ADD AX,0x4d (1000_7DEE / 0x17DEE)
    // AX += 0x4D;
    AX = Alu.Add16(AX, 0x4D);
    State.IncCycles();
    // MOV word ptr [DI],AX (1000_7DF1 / 0x17DF1)
    UInt16[DS, DI] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x4] (1000_7DF3 / 0x17DF3)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV word ptr [DI + 0x4],AX (1000_7DF6 / 0x17DF6)
    UInt16[DS, (ushort)(DI + 0x4)] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0x4],AX (1000_7DF9 / 0x17DF9)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_7DFC / 0x17DFC)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // ADD AX,0x2b (1000_7DFF / 0x17DFF)
    // AX += 0x2B;
    AX = Alu.Add16(AX, 0x2B);
    State.IncCycles();
    // MOV word ptr [DI + 0x2],AX (1000_7E02 / 0x17E02)
    UInt16[DS, (ushort)(DI + 0x2)] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_7E05 / 0x17E05)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV word ptr [DI + 0x6],AX (1000_7E08 / 0x17E08)
    UInt16[DS, (ushort)(DI + 0x6)] = AX;
    State.IncCycles();
    // INC AX (1000_7E0B / 0x17E0B)
    AX++;
    State.IncCycles();
    // CMP AX,0x70 (1000_7E0C / 0x17E0C)
    Alu.Sub16(AX, 0x70);
    State.IncCycles();
    // JC 0x1000:7e14 (1000_7E0F / 0x17E0F)
    if(CarryFlag) {
      goto label_1000_7E14_17E14;
    }
    State.IncCycles();
    // SUB AX,0x6d (1000_7E11 / 0x17E11)
    // AX -= 0x6D;
    AX = Alu.Sub16(AX, 0x6D);
    State.IncCycles();
    label_1000_7E14_17E14:
    // MOV word ptr [BP + 0x2],AX (1000_7E14 / 0x17E14)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // ADD AX,0x28 (1000_7E17 / 0x17E17)
    // AX += 0x28;
    AX = Alu.Add16(AX, 0x28);
    State.IncCycles();
    // MOV word ptr [BP + 0x6],AX (1000_7E1A / 0x17E1A)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    State.IncCycles();
    // RET  (1000_7E1D / 0x17E1D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7E1E_017E1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E1E_17E1E:
    // CALL 0x1000:d068 (1000_7E1E / 0x17E1E)
    NearCall(cs1, 0x7E21, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7E21_017E21, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7E21_017E21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E21_17E21:
    // MOV SI,0x4705 (1000_7E21 / 0x17E21)
    SI = 0x4705;
    State.IncCycles();
    // MOV DX,word ptr [0x18e9] (1000_7E24 / 0x17E24)
    DX = UInt16[DS, 0x18E9];
    State.IncCycles();
    // MOV BX,word ptr [0x18eb] (1000_7E28 / 0x17E28)
    BX = UInt16[DS, 0x18EB];
    State.IncCycles();
    // ADD DX,0x80 (1000_7E2C / 0x17E2C)
    DX += 0x80;
    State.IncCycles();
    // ADD BX,0x2d (1000_7E30 / 0x17E30)
    // BX += 0x2D;
    BX = Alu.Add16(BX, 0x2D);
    State.IncCycles();
    // MOV BP,word ptr [0x18ef] (1000_7E33 / 0x17E33)
    BP = UInt16[DS, 0x18EF];
    State.IncCycles();
    // MOV word ptr [0xdbe4],0xf0 (1000_7E37 / 0x17E37)
    UInt16[DS, 0xDBE4] = 0xF0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_7E3D_017E3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7E3D_017E3D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E3D_17E3D:
    // CALL 0x1000:c13b (1000_7E3D / 0x17E3D)
    NearCall(cs1, 0x7E40, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7E40_017E40, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7E40_017E40(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E40_17E40:
    // PUSH DI (1000_7E40 / 0x17E40)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_7E41 / 0x17E41)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_7E42 / 0x17E42)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x4c60 (1000_7E43 / 0x17E43)
    DI = 0x4C60;
    State.IncCycles();
    // MOV CX,0xe (1000_7E46 / 0x17E46)
    CX = 0xE;
    State.IncCycles();
    // XOR AX,AX (1000_7E49 / 0x17E49)
    AX = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_7E4B / 0x17E4B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // MOV DI,SI (1000_7E4D / 0x17E4D)
    DI = SI;
    State.IncCycles();
    // MOV CX,0x7 (1000_7E4F / 0x17E4F)
    CX = 0x7;
    State.IncCycles();
    // XOR AL,AL (1000_7E52 / 0x17E52)
    AL = 0;
    State.IncCycles();
    // REPE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_7E54 / 0x17E54)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    State.IncCycles();
    // JNZ 0x1000:7e69 (1000_7E56 / 0x17E56)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E69_017E69, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD BX,0x5 (1000_7E58 / 0x17E58)
    BX += 0x5;
    State.IncCycles();
    // ADD DX,0xc (1000_7E5B / 0x17E5B)
    // DX += 0xC;
    DX = Alu.Add16(DX, 0xC);
    State.IncCycles();
    // CALL 0x1000:d04e (1000_7E5E / 0x17E5E)
    NearCall(cs1, 0x7E61, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7E61_017E61, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7E61_017E61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E61_17E61:
    // MOV AX,0x69 (1000_7E61 / 0x17E61)
    AX = 0x69;
    State.IncCycles();
    // CALL 0x1000:d19b (1000_7E64 / 0x17E64)
    NearCall(cs1, 0x7E67, spice86_generated_label_ret_target_1000_D19B_01D19B);
    State.IncCycles();
    label_1000_7E67_17E67:
    // POP DI (1000_7E67 / 0x17E67)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7E68 / 0x17E68)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7E69_017E69(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E69_17E69:
    // XOR DI,DI (1000_7E69 / 0x17E69)
    DI = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7E6B_017E6B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7E6B_017E6B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E6B_17E6B:
    // MOV AL,byte ptr [SI] (1000_7E6B / 0x17E6B)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // OR AL,AL (1000_7E6D / 0x17E6D)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:7e8e (1000_7E6F / 0x17E6F)
    if(ZeroFlag) {
      goto label_1000_7E8E_17E8E;
    }
    State.IncCycles();
    // MOV CL,AL (1000_7E71 / 0x17E71)
    CL = AL;
    State.IncCycles();
    // PUSH SI (1000_7E73 / 0x17E73)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_7E74 / 0x17E74)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_7E75 / 0x17E75)
    Stack.Push(BP);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x192f] (1000_7E76 / 0x17E76)
    AL = UInt8[DS, (ushort)(DI + 0x192F)];
    State.IncCycles();
    // XOR AH,AH (1000_7E7A / 0x17E7A)
    AH = 0;
    State.IncCycles();
    // SHL DI,1 (1000_7E7C / 0x17E7C)
    DI <<= 0x1;
    State.IncCycles();
    // SHL DI,1 (1000_7E7E / 0x17E7E)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV word ptr [DI + 0x4c60],DX (1000_7E80 / 0x17E80)
    UInt16[DS, (ushort)(DI + 0x4C60)] = DX;
    State.IncCycles();
    // CALL 0x1000:61d3 (1000_7E84 / 0x17E84)
    NearCall(cs1, 0x7E87, spice86_generated_label_call_target_1000_61D3_0161D3);
    State.IncCycles();
    label_1000_7E87_17E87:
    // MOV word ptr [DI + 0x4c62],DX (1000_7E87 / 0x17E87)
    UInt16[DS, (ushort)(DI + 0x4C62)] = DX;
    State.IncCycles();
    // POP BP (1000_7E8B / 0x17E8B)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_7E8C / 0x17E8C)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_7E8D / 0x17E8D)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_7E8E_17E8E:
    // INC SI (1000_7E8E / 0x17E8E)
    SI++;
    State.IncCycles();
    // INC DI (1000_7E8F / 0x17E8F)
    DI++;
    State.IncCycles();
    // CMP DI,0x7 (1000_7E90 / 0x17E90)
    Alu.Sub16(DI, 0x7);
    State.IncCycles();
    // JC 0x1000:7e6b (1000_7E93 / 0x17E93)
    if(CarryFlag) {
      goto label_1000_7E6B_17E6B;
    }
    State.IncCycles();
    // POP DI (1000_7E95 / 0x17E95)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7E96 / 0x17E96)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7E97_017E97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7E97_17E97:
    // CMP byte ptr [0x46f5],0x0 (1000_7E97 / 0x17E97)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    State.IncCycles();
    // JZ 0x1000:7ee1 (1000_7E9C / 0x17E9C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x1936 (1000_7E9E / 0x17E9E)
    DI = 0x1936;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_7EA1 / 0x17EA1)
    NearCall(cs1, 0x7EA4, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_7EA4_17EA4:
    // JNC 0x1000:7ee1 (1000_7EA4 / 0x17EA4)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x4c7c (1000_7EA6 / 0x17EA6)
    SI = 0x4C7C;
    State.IncCycles();
    // CALL 0x1000:7ee2 (1000_7EA9 / 0x17EA9)
    NearCall(cs1, 0x7EAC, spice86_generated_label_call_target_1000_7EE2_017EE2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7EAC_017EAC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7EAC_017EAC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7EAC_17EAC:
    // JNC 0x1000:7ee1 (1000_7EAC / 0x17EAC)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // DEC byte ptr [DI + 0x4705] (1000_7EAE / 0x17EAE)
    UInt8[DS, (ushort)(DI + 0x4705)]--;
    State.IncCycles();
    // INC byte ptr [DI + 0x46fe] (1000_7EB2 / 0x17EB2)
    UInt8[DS, (ushort)(DI + 0x46FE)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0x46FE)]);
    State.IncCycles();
    // JMP 0x1000:7ede (1000_7EB6 / 0x17EB6)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7ECD_017ECD, 0x17EDE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7EB8_017EB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7EB8_17EB8:
    // CMP byte ptr [0x46f5],0x0 (1000_7EB8 / 0x17EB8)
    Alu.Sub8(UInt8[DS, 0x46F5], 0x0);
    State.IncCycles();
    // JZ 0x1000:7ee1 (1000_7EBD / 0x17EBD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x1940 (1000_7EBF / 0x17EBF)
    DI = 0x1940;
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_7EC2 / 0x17EC2)
    NearCall(cs1, 0x7EC5, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    label_1000_7EC5_17EC5:
    // JNC 0x1000:7ee1 (1000_7EC5 / 0x17EC5)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x4c60 (1000_7EC7 / 0x17EC7)
    SI = 0x4C60;
    State.IncCycles();
    // CALL 0x1000:7ee2 (1000_7ECA / 0x17ECA)
    NearCall(cs1, 0x7ECD, spice86_generated_label_call_target_1000_7EE2_017EE2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7ECD_017ECD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7ECD_017ECD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x7EE1: goto label_1000_7EE1_17EE1;break; // Target of external jump from 0x17EEF
      case 0x7EDE: goto label_1000_7EDE_17EDE;break; // Target of external jump from 0x17EB6
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_7ECD_17ECD:
    // JNC 0x1000:7ee1 (1000_7ECD / 0x17ECD)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x4705],0x0 (1000_7ECF / 0x17ECF)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x4705)], 0x0);
    State.IncCycles();
    // JNZ 0x1000:7ee1 (1000_7ED4 / 0x17ED4)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [DI + 0x4705] (1000_7ED6 / 0x17ED6)
    UInt8[DS, (ushort)(DI + 0x4705)]++;
    State.IncCycles();
    // DEC byte ptr [DI + 0x46fe] (1000_7EDA / 0x17EDA)
    UInt8[DS, (ushort)(DI + 0x46FE)] = Alu.Dec8(UInt8[DS, (ushort)(DI + 0x46FE)]);
    State.IncCycles();
    label_1000_7EDE_17EDE:
    // CALL 0x1000:7d0c (1000_7EDE / 0x17EDE)
    NearCall(cs1, 0x7EE1, spice86_generated_label_call_target_1000_7D0C_017D0C);
    State.IncCycles();
    label_1000_7EE1_17EE1:
    // RET  (1000_7EE1 / 0x17EE1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7EE2_017EE2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7EE2_17EE2:
    // XOR DI,DI (1000_7EE2 / 0x17EE2)
    DI = 0;
    State.IncCycles();
    label_1000_7EE4_17EE4:
    // LODSW SI (1000_7EE4 / 0x17EE4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_7EE5 / 0x17EE5)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:7ef1 (1000_7EE7 / 0x17EE7)
    if(ZeroFlag) {
      goto label_1000_7EF1_17EF1;
    }
    State.IncCycles();
    // CMP DX,AX (1000_7EE9 / 0x17EE9)
    Alu.Sub16(DX, AX);
    State.IncCycles();
    // JC 0x1000:7ef1 (1000_7EEB / 0x17EEB)
    if(CarryFlag) {
      goto label_1000_7EF1_17EF1;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI] (1000_7EED / 0x17EED)
    Alu.Sub16(DX, UInt16[DS, SI]);
    State.IncCycles();
    // JC 0x1000:7ee1 (1000_7EEF / 0x17EEF)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7EE1 / 0x17EE1)
      return NearRet();
    }
    State.IncCycles();
    label_1000_7EF1_17EF1:
    // ADD SI,0x2 (1000_7EF1 / 0x17EF1)
    SI += 0x2;
    State.IncCycles();
    // INC DI (1000_7EF4 / 0x17EF4)
    DI++;
    State.IncCycles();
    // CMP DI,0x7 (1000_7EF5 / 0x17EF5)
    Alu.Sub16(DI, 0x7);
    State.IncCycles();
    // JC 0x1000:7ee4 (1000_7EF8 / 0x17EF8)
    if(CarryFlag) {
      goto label_1000_7EE4_17EE4;
    }
    State.IncCycles();
    // RET  (1000_7EFA / 0x17EFA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7EFB_017EFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7EFB_17EFB:
    // PUSH DI (1000_7EFB / 0x17EFB)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_7EFC / 0x17EFC)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_7EFD / 0x17EFD)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0x4705 (1000_7EFE / 0x17EFE)
    DI = 0x4705;
    State.IncCycles();
    // MOV AH,byte ptr [SI + 0x19] (1000_7F01 / 0x17F01)
    AH = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    label_1000_7F04_17F04:
    // XOR AL,AL (1000_7F04 / 0x17F04)
    AL = 0;
    State.IncCycles();
    // ROL AX,1 (1000_7F06 / 0x17F06)
    AX = Alu.Rol16(AX, 0x1);
    State.IncCycles();
    // STOSB ES:DI (1000_7F08 / 0x17F08)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,0x470c (1000_7F09 / 0x17F09)
    Alu.Sub16(DI, 0x470C);
    State.IncCycles();
    // JC 0x1000:7f04 (1000_7F0D / 0x17F0D)
    if(CarryFlag) {
      goto label_1000_7F04_17F04;
    }
    State.IncCycles();
    // POP DI (1000_7F0F / 0x17F0F)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7F10 / 0x17F10)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7F11_017F11(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7F11_17F11:
    // PUSH SI (1000_7F11 / 0x17F11)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x470b (1000_7F12 / 0x17F12)
    SI = 0x470B;
    State.IncCycles();
    // STD  (1000_7F15 / 0x17F15)
    DirectionFlag = true;
    State.IncCycles();
    // XOR AX,AX (1000_7F16 / 0x17F16)
    AX = 0;
    State.IncCycles();
    label_1000_7F18_17F18:
    // LODSB SI (1000_7F18 / 0x17F18)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // ROR AX,1 (1000_7F19 / 0x17F19)
    AX = Alu.Ror16(AX, 0x1);
    State.IncCycles();
    // CMP SI,0x4705 (1000_7F1B / 0x17F1B)
    Alu.Sub16(SI, 0x4705);
    State.IncCycles();
    // JNC 0x1000:7f18 (1000_7F1F / 0x17F1F)
    if(!CarryFlag) {
      goto label_1000_7F18_17F18;
    }
    State.IncCycles();
    // POP SI (1000_7F21 / 0x17F21)
    SI = Stack.Pop();
    State.IncCycles();
    // CLD  (1000_7F22 / 0x17F22)
    DirectionFlag = false;
    State.IncCycles();
    // MOV byte ptr [SI + 0x19],AH (1000_7F23 / 0x17F23)
    UInt8[DS, (ushort)(SI + 0x19)] = AH;
    State.IncCycles();
    // RET  (1000_7F26 / 0x17F26)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7F27_017F27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7F27_17F27:
    // MOV BX,0x46fe (1000_7F27 / 0x17F27)
    BX = 0x46FE;
    State.IncCycles();
    // PUSH DI (1000_7F2A / 0x17F2A)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_7F2B / 0x17F2B)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_7F2C / 0x17F2C)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_7F2D / 0x17F2D)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    // LEA SI,[DI + 0x14] (1000_7F30 / 0x17F30)
    SI = (ushort)(DI + 0x14);
    State.IncCycles();
    // MOV DI,BX (1000_7F33 / 0x17F33)
    DI = BX;
    State.IncCycles();
    // MOV CX,0x7 (1000_7F35 / 0x17F35)
    CX = 0x7;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_7F38 / 0x17F38)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_7F3A_017F3A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_7F3A_017F3A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7F3A_17F3A:
    // OR AL,AL (1000_7F3A / 0x17F3A)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:7f5d (1000_7F3C / 0x17F3C)
    if(ZeroFlag) {
      goto label_1000_7F5D_17F5D;
    }
    State.IncCycles();
    // CALL 0x1000:6906 (1000_7F3E / 0x17F3E)
    NearCall(cs1, 0x7F41, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    label_1000_7F41_17F41:
    // MOV AL,byte ptr [SI + 0x19] (1000_7F41 / 0x17F41)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // MOV DI,BX (1000_7F44 / 0x17F44)
    DI = BX;
    State.IncCycles();
    // SHL AL,1 (1000_7F46 / 0x17F46)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:7f51 (1000_7F48 / 0x17F48)
    if(!CarryFlag) {
      goto label_1000_7F51_17F51;
    }
    State.IncCycles();
    label_1000_7F4A_17F4A:
    // SUB byte ptr [DI],0x1 (1000_7F4A / 0x17F4A)
    // UInt8[DS, DI] -= 0x1;
    UInt8[DS, DI] = Alu.Sub8(UInt8[DS, DI], 0x1);
    State.IncCycles();
    // JNC 0x1000:7f51 (1000_7F4D / 0x17F4D)
    if(!CarryFlag) {
      goto label_1000_7F51_17F51;
    }
    State.IncCycles();
    // INC byte ptr [DI] (1000_7F4F / 0x17F4F)
    UInt8[DS, DI]++;
    State.IncCycles();
    label_1000_7F51_17F51:
    // INC DI (1000_7F51 / 0x17F51)
    DI++;
    State.IncCycles();
    // SHL AL,1 (1000_7F52 / 0x17F52)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JC 0x1000:7f4a (1000_7F54 / 0x17F54)
    if(CarryFlag) {
      goto label_1000_7F4A_17F4A;
    }
    State.IncCycles();
    // JNZ 0x1000:7f51 (1000_7F56 / 0x17F56)
    if(!ZeroFlag) {
      goto label_1000_7F51_17F51;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1] (1000_7F58 / 0x17F58)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // JMP 0x1000:7f3a (1000_7F5B / 0x17F5B)
    goto label_1000_7F3A_17F3A;
    State.IncCycles();
    label_1000_7F5D_17F5D:
    // POP DI (1000_7F5D / 0x17F5D)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7F5E / 0x17F5E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_7F5F_017F5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7F5F_17F5F:
    // MOV AL,byte ptr [SI + 0x19] (1000_7F5F / 0x17F5F)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // PUSH DI (1000_7F62 / 0x17F62)
    Stack.Push(DI);
    State.IncCycles();
    // ADD DI,0x14 (1000_7F63 / 0x17F63)
    DI += 0x14;
    State.IncCycles();
    // SHL AL,1 (1000_7F66 / 0x17F66)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:7f6c (1000_7F68 / 0x17F68)
    if(!CarryFlag) {
      goto label_1000_7F6C_17F6C;
    }
    State.IncCycles();
    label_1000_7F6A_17F6A:
    // INC byte ptr [DI] (1000_7F6A / 0x17F6A)
    UInt8[DS, DI]++;
    State.IncCycles();
    label_1000_7F6C_17F6C:
    // INC DI (1000_7F6C / 0x17F6C)
    DI++;
    State.IncCycles();
    // SHL AL,1 (1000_7F6D / 0x17F6D)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JC 0x1000:7f6a (1000_7F6F / 0x17F6F)
    if(CarryFlag) {
      goto label_1000_7F6A_17F6A;
    }
    State.IncCycles();
    // JNZ 0x1000:7f6c (1000_7F71 / 0x17F71)
    if(!ZeroFlag) {
      goto label_1000_7F6C_17F6C;
    }
    State.IncCycles();
    // POP DI (1000_7F73 / 0x17F73)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7F74 / 0x17F74)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_7F75_017F75(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7F75_17F75:
    // MOV AL,byte ptr [SI + 0x19] (1000_7F75 / 0x17F75)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // PUSH DI (1000_7F78 / 0x17F78)
    Stack.Push(DI);
    State.IncCycles();
    // ADD DI,0x14 (1000_7F79 / 0x17F79)
    DI += 0x14;
    State.IncCycles();
    // SHL AL,1 (1000_7F7C / 0x17F7C)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:7f87 (1000_7F7E / 0x17F7E)
    if(!CarryFlag) {
      goto label_1000_7F87_17F87;
    }
    State.IncCycles();
    label_1000_7F80_17F80:
    // SUB byte ptr [DI],0x1 (1000_7F80 / 0x17F80)
    // UInt8[DS, DI] -= 0x1;
    UInt8[DS, DI] = Alu.Sub8(UInt8[DS, DI], 0x1);
    State.IncCycles();
    // JNC 0x1000:7f87 (1000_7F83 / 0x17F83)
    if(!CarryFlag) {
      goto label_1000_7F87_17F87;
    }
    State.IncCycles();
    // INC byte ptr [DI] (1000_7F85 / 0x17F85)
    UInt8[DS, DI]++;
    State.IncCycles();
    label_1000_7F87_17F87:
    // INC DI (1000_7F87 / 0x17F87)
    DI++;
    State.IncCycles();
    // SHL AL,1 (1000_7F88 / 0x17F88)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JC 0x1000:7f80 (1000_7F8A / 0x17F8A)
    if(CarryFlag) {
      goto label_1000_7F80_17F80;
    }
    State.IncCycles();
    // JNZ 0x1000:7f87 (1000_7F8C / 0x17F8C)
    if(!ZeroFlag) {
      goto label_1000_7F87_17F87;
    }
    State.IncCycles();
    // POP DI (1000_7F8E / 0x17F8E)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_7F8F / 0x17F8F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_80DF_0180DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_80DF_180DF:
    // PUSH AX (1000_80DF / 0x180DF)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:c08e (1000_80E0 / 0x180E0)
    NearCall(cs1, 0x80E3, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:8fd1 (1000_80E3 / 0x180E3)
    NearCall(cs1, 0x80E6, spice86_label_1000_8FD1_18FD1);
    State.IncCycles();
    // POP BX (1000_80E6 / 0x180E6)
    BX = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x2244 (1000_80E7 / 0x180E7)
    SI = 0x2244;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_80EA / 0x180EA)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // PUSH AX (1000_80ED / 0x180ED)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH word ptr [SI + 0x6] (1000_80EE / 0x180EE)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // PUSH BX (1000_80F1 / 0x180F1)
    Stack.Push(BX);
    State.IncCycles();
    // CMP AX,0x32 (1000_80F2 / 0x180F2)
    Alu.Sub16(AX, 0x32);
    State.IncCycles();
    // JC 0x1000:80fa (1000_80F5 / 0x180F5)
    if(CarryFlag) {
      goto label_1000_80FA_180FA;
    }
    State.IncCycles();
    // ADD AX,0x26 (1000_80F7 / 0x180F7)
    // AX += 0x26;
    AX = Alu.Add16(AX, 0x26);
    State.IncCycles();
    label_1000_80FA_180FA:
    // MOV word ptr [SI + 0x2],AX (1000_80FA / 0x180FA)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0x6],0x19 (1000_80FD / 0x180FD)
    UInt16[DS, (ushort)(SI + 0x6)] = 0x19;
    State.IncCycles();
    // CALL 0x1000:9f82 (1000_8102 / 0x18102)
    NearCall(cs1, 0x8105, spice86_generated_label_call_target_1000_9F82_019F82);
    State.IncCycles();
    // POP AX (1000_8105 / 0x18105)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:88af (1000_8106 / 0x18106)
    NearCall(cs1, 0x8109, spice86_generated_label_call_target_1000_88AF_0188AF);
    State.IncCycles();
    // CMP byte ptr [0x4774],0x0 (1000_8109 / 0x18109)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JNZ 0x1000:811e (1000_810E / 0x1810E)
    if(!ZeroFlag) {
      goto label_1000_811E_1811E;
    }
    State.IncCycles();
    // MOV AX,0x10a (1000_8110 / 0x18110)
    AX = 0x10A;
    State.IncCycles();
    // ADD AX,word ptr [0xd810] (1000_8113 / 0x18113)
    AX += UInt16[DS, 0xD810];
    State.IncCycles();
    // ADD word ptr [0x4780],AX (1000_8117 / 0x18117)
    // UInt16[DS, 0x4780] += AX;
    UInt16[DS, 0x4780] = Alu.Add16(UInt16[DS, 0x4780], AX);
    State.IncCycles();
    // CALL 0x1000:9efd (1000_811B / 0x1811B)
    NearCall(cs1, 0x811E, spice86_generated_label_call_target_1000_9EFD_019EFD);
    State.IncCycles();
    label_1000_811E_1811E:
    // POP word ptr [0x224a] (1000_811E / 0x1811E)
    UInt16[DS, 0x224A] = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0x2246] (1000_8122 / 0x18122)
    UInt16[DS, 0x2246] = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:c07c (1000_8126 / 0x18126)
    NearCall(cs1, 0x8129, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    // MOV word ptr [0x4720],0x18f3 (1000_8129 / 0x18129)
    UInt16[DS, 0x4720] = 0x18F3;
    State.IncCycles();
    // MOV byte ptr [0x4722],0x0 (1000_812F / 0x1812F)
    UInt8[DS, 0x4722] = 0x0;
    State.IncCycles();
    // CALL 0x1000:541f (1000_8134 / 0x18134)
    NearCall(cs1, 0x8137, not_observed_1000_541F_01541F);
    State.IncCycles();
    // MOV word ptr [0x1bea],0x0 (1000_8137 / 0x18137)
    UInt16[DS, 0x1BEA] = 0x0;
    State.IncCycles();
    // RET  (1000_813D / 0x1813D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_813E_01813E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_813E_1813E:
    // SUB SP,0x30 (1000_813E / 0x1813E)
    // SP -= 0x30;
    SP = Alu.Sub16(SP, 0x30);
    State.IncCycles();
    // MOV DI,SP (1000_8141 / 0x18141)
    DI = SP;
    State.IncCycles();
    // CALL 0x1000:68eb (1000_8143 / 0x18143)
    NearCall(cs1, 0x8146, spice86_generated_label_call_target_1000_68EB_0168EB);
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x6] (1000_8146 / 0x18146)
    DX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x8] (1000_8149 / 0x18149)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // CALL 0x1000:81d7 (1000_814C / 0x1814C)
    NearCall(cs1, 0x814F, not_observed_1000_81D7_0181D7);
    State.IncCycles();
    // CMP SI,0x8e0 (1000_814F / 0x1814F)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JNZ 0x1000:816a (1000_8153 / 0x18153)
    if(!ZeroFlag) {
      goto label_1000_816A_1816A;
    }
    State.IncCycles();
    // MOV SI,0x4718 (1000_8155 / 0x18155)
    SI = 0x4718;
    State.IncCycles();
    label_1000_8158_18158:
    // LODSW SI (1000_8158 / 0x18158)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_8159 / 0x18159)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:8176 (1000_815B / 0x1815B)
    if(ZeroFlag) {
      goto label_1000_8176_18176;
    }
    State.IncCycles();
    // MOV BX,AX (1000_815D / 0x1815D)
    BX = AX;
    State.IncCycles();
    // MOV DX,word ptr [BX + 0x2] (1000_815F / 0x1815F)
    DX = UInt16[DS, (ushort)(BX + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [BX + 0x4] (1000_8162 / 0x18162)
    BX = UInt16[DS, (ushort)(BX + 0x4)];
    State.IncCycles();
    // CALL 0x1000:81d7 (1000_8165 / 0x18165)
    NearCall(cs1, 0x8168, not_observed_1000_81D7_0181D7);
    State.IncCycles();
    // JMP 0x1000:8158 (1000_8168 / 0x18168)
    goto label_1000_8158_18158;
    State.IncCycles();
    label_1000_816A_1816A:
    // MOV BX,word ptr [SI + 0x4] (1000_816A / 0x1816A)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV DX,word ptr [BX + 0x2] (1000_816D / 0x1816D)
    DX = UInt16[DS, (ushort)(BX + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [BX + 0x4] (1000_8170 / 0x18170)
    BX = UInt16[DS, (ushort)(BX + 0x4)];
    State.IncCycles();
    // CALL 0x1000:81d7 (1000_8173 / 0x18173)
    NearCall(cs1, 0x8176, not_observed_1000_81D7_0181D7);
    State.IncCycles();
    label_1000_8176_18176:
    // MOV SI,SP (1000_8176 / 0x18176)
    SI = SP;
    State.IncCycles();
    label_1000_8178_18178:
    // LODSW SI (1000_8178 / 0x18178)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_8179 / 0x18179)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_817B / 0x1817B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_817C / 0x1817C)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_817E / 0x1817E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,word ptr [SI] (1000_817F / 0x1817F)
    DI = UInt16[DS, SI];
    State.IncCycles();
    // CMP DI,0x8000 (1000_8181 / 0x18181)
    Alu.Sub16(DI, 0x8000);
    State.IncCycles();
    // JZ 0x1000:81d3 (1000_8185 / 0x18185)
    if(ZeroFlag) {
      goto label_1000_81D3_181D3;
    }
    State.IncCycles();
    // PUSH SI (1000_8187 / 0x18187)
    Stack.Push(SI);
    State.IncCycles();
    // MOV CX,word ptr [SI + 0x2] (1000_8188 / 0x18188)
    CX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SUB AX,word ptr [SI + 0x4] (1000_818B / 0x1818B)
    // AX -= UInt16[DS, (ushort)(SI + 0x4)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // MOV SI,DX (1000_818E / 0x1818E)
    SI = DX;
    State.IncCycles();
    // SUB SI,DI (1000_8190 / 0x18190)
    SI -= DI;
    State.IncCycles();
    // XOR AX,SI (1000_8192 / 0x18192)
    // AX ^= SI;
    AX = Alu.Xor16(AX, SI);
    State.IncCycles();
    // JNS 0x1000:81c0 (1000_8194 / 0x18194)
    if(!SignFlag) {
      goto label_1000_81C0_181C0;
    }
    State.IncCycles();
    // MOV AX,SI (1000_8196 / 0x18196)
    AX = SI;
    State.IncCycles();
    // OR AX,AX (1000_8198 / 0x18198)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x1000:819e (1000_819A / 0x1819A)
    if(!SignFlag) {
      goto label_1000_819E_1819E;
    }
    State.IncCycles();
    // NEG AX (1000_819C / 0x1819C)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_819E_1819E:
    // CMP AX,0x50 (1000_819E / 0x1819E)
    Alu.Sub16(AX, 0x50);
    State.IncCycles();
    // JC 0x1000:81c0 (1000_81A1 / 0x181A1)
    if(CarryFlag) {
      goto label_1000_81C0_181C0;
    }
    State.IncCycles();
    // CMP DX,word ptr [0x46e3] (1000_81A3 / 0x181A3)
    Alu.Sub16(DX, UInt16[DS, 0x46E3]);
    State.IncCycles();
    // JL 0x1000:81b5 (1000_81A7 / 0x181A7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_81B5_181B5;
    }
    State.IncCycles();
    // CMP DX,word ptr [0x46e7] (1000_81A9 / 0x181A9)
    Alu.Sub16(DX, UInt16[DS, 0x46E7]);
    State.IncCycles();
    // JGE 0x1000:81b5 (1000_81AD / 0x181AD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_81B5_181B5;
    }
    State.IncCycles();
    // XCHG DI,DX (1000_81AF / 0x181AF)
    ushort tmp_1000_81AF = DI;
    DI = DX;
    DX = tmp_1000_81AF;
    State.IncCycles();
    // XCHG CX,BX (1000_81B1 / 0x181B1)
    ushort tmp_1000_81B1 = CX;
    CX = BX;
    BX = tmp_1000_81B1;
    State.IncCycles();
    // NEG SI (1000_81B3 / 0x181B3)
    SI = Alu.Sub16(0, SI);
    State.IncCycles();
    label_1000_81B5_181B5:
    // MOV AX,0x190 (1000_81B5 / 0x181B5)
    AX = 0x190;
    State.IncCycles();
    // OR SI,SI (1000_81B8 / 0x181B8)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JS 0x1000:81be (1000_81BA / 0x181BA)
    if(SignFlag) {
      goto label_1000_81BE_181BE;
    }
    State.IncCycles();
    // NEG AX (1000_81BC / 0x181BC)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_81BE_181BE:
    // ADD DX,AX (1000_81BE / 0x181BE)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    label_1000_81C0_181C0:
    // MOV ES,word ptr [0xdbda] (1000_81C0 / 0x181C0)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV AL,0xc (1000_81C4 / 0x181C4)
    AL = 0xC;
    State.IncCycles();
    // MOV BP,0x5555 (1000_81C6 / 0x181C6)
    BP = 0x5555;
    State.IncCycles();
    // MOV SI,0x46e3 (1000_81C9 / 0x181C9)
    SI = 0x46E3;
    State.IncCycles();
    // CALLF [0x3901] (1000_81CC / 0x181CC)
    // Indirect call to [0x3901], generating possible targets from emulator records
    uint targetAddress_1000_81CC = (uint)(UInt16[DS, 0x3903] * 0x10 + UInt16[DS, 0x3901] - cs1 * 0x10);
    switch(targetAddress_1000_81CC) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_81CC));
        break;
    }
    State.IncCycles();
    // POP SI (1000_81D0 / 0x181D0)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:8178 (1000_81D1 / 0x181D1)
    goto label_1000_8178_18178;
    State.IncCycles();
    label_1000_81D3_181D3:
    // ADD SP,0x30 (1000_81D3 / 0x181D3)
    // SP += 0x30;
    SP = Alu.Add16(SP, 0x30);
    State.IncCycles();
    // RET  (1000_81D6 / 0x181D6)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_81D7_0181D7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_81D7_181D7:
    // MOV word ptr [DI + 0x4],DX (1000_81D7 / 0x181D7)
    UInt16[DS, (ushort)(DI + 0x4)] = DX;
    State.IncCycles();
    // PUSH DI (1000_81DA / 0x181DA)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:b647 (1000_81DB / 0x181DB)
    NearCall(cs1, 0x81DE, spice86_generated_label_call_target_1000_B647_01B647);
    State.IncCycles();
    // POP DI (1000_81DE / 0x181DE)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [DI],DX (1000_81DF / 0x181DF)
    UInt16[DS, DI] = DX;
    State.IncCycles();
    // MOV word ptr [DI + 0x2],BX (1000_81E1 / 0x181E1)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    State.IncCycles();
    // ADD DI,0x6 (1000_81E4 / 0x181E4)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    State.IncCycles();
    // MOV word ptr [DI],0x8000 (1000_81E7 / 0x181E7)
    UInt16[DS, DI] = 0x8000;
    State.IncCycles();
    // RET  (1000_81EB / 0x181EB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_82A0_0182A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_82A0_182A0:
    // CALL 0x1000:d41b (1000_82A0 / 0x182A0)
    NearCall(cs1, 0x82A3, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    label_1000_82A3_182A3:
    // CMP BP,0x212e (1000_82A3 / 0x182A3)
    Alu.Sub16(BP, 0x212E);
    State.IncCycles();
    // JZ 0x1000:82ad (1000_82A7 / 0x182A7)
    if(ZeroFlag) {
      goto label_1000_82AD_182AD;
    }
    State.IncCycles();
    // CMP BP,0x2136 (1000_82A9 / 0x182A9)
    Alu.Sub16(BP, 0x2136);
    State.IncCycles();
    label_1000_82AD_182AD:
    // JNZ 0x1000:82b6 (1000_82AD / 0x182AD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_82B6 / 0x182B6)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,[0x46eb] (1000_82AF / 0x182AF)
    AL = UInt8[DS, 0x46EB];
    State.IncCycles();
    // NOT AL (1000_82B2 / 0x182B2)
    AL = (byte)~AL;
    State.IncCycles();
    // TEST AL,0x40 (1000_82B4 / 0x182B4)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    label_1000_82B6_182B6:
    // RET  (1000_82B6 / 0x182B6)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8308_018308(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8308_18308:
    // MOV CX,0x4 (1000_8308 / 0x18308)
    CX = 0x4;
    State.IncCycles();
    // TEST byte ptr [SI + 0x19],0x40 (1000_830B / 0x1830B)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x40);
    State.IncCycles();
    // JZ 0x1000:8313 (1000_830F / 0x1830F)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_8313_018313, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CL,0x8 (1000_8311 / 0x18311)
    CL = 0x8;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_8313_018313, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_8313_018313(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8313_18313:
    // PUSH CX (1000_8313 / 0x18313)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:8604 (1000_8314 / 0x18314)
    NearCall(cs1, 0x8317, not_observed_1000_8604_018604);
    State.IncCycles();
    // POP CX (1000_8317 / 0x18317)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV AX,BX (1000_8318 / 0x18318)
    AX = BX;
    State.IncCycles();
    // OR AX,DX (1000_831A / 0x1831A)
    // AX |= DX;
    AX = Alu.Or16(AX, DX);
    State.IncCycles();
    // JZ 0x1000:8357 (1000_831C / 0x1831C)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_8357_018357, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD word ptr [SI + 0x6],DX (1000_831E / 0x1831E)
    UInt16[DS, (ushort)(SI + 0x6)] += DX;
    State.IncCycles();
    // ADD word ptr [SI + 0x8],BX (1000_8321 / 0x18321)
    // UInt16[DS, (ushort)(SI + 0x8)] += BX;
    UInt16[DS, (ushort)(SI + 0x8)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x8)], BX);
    State.IncCycles();
    // LOOP 0x1000:8313 (1000_8324 / 0x18324)
    if(--CX != 0) {
      goto label_1000_8313_18313;
    }
    State.IncCycles();
    // CALL 0x1000:686e (1000_8326 / 0x18326)
    NearCall(cs1, 0x8329, spice86_generated_label_call_target_1000_686E_01686E);
    State.IncCycles();
    // JC 0x1000:8333 (1000_8329 / 0x18329)
    if(CarryFlag) {
      goto label_1000_8333_18333;
    }
    State.IncCycles();
    // CALL 0x1000:6917 (1000_832B / 0x1832B)
    NearCall(cs1, 0x832E, spice86_generated_label_call_target_1000_6917_016917);
    State.IncCycles();
    // JNZ 0x1000:833c (1000_832E / 0x1832E)
    if(!ZeroFlag) {
      goto label_1000_833C_1833C;
    }
    State.IncCycles();
    // JMP 0x1000:c653 (1000_8330 / 0x18330)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C653_01C653, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_8333_18333:
    // CALL 0x1000:6917 (1000_8333 / 0x18333)
    NearCall(cs1, 0x8336, spice86_generated_label_call_target_1000_6917_016917);
    State.IncCycles();
    // JNZ 0x1000:833b (1000_8336 / 0x18336)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_833B / 0x1833B)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:c58a (1000_8338 / 0x18338)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C58A_01C58A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_833B_1833B:
    // RET  (1000_833B / 0x1833B)
    return NearRet();
    State.IncCycles();
    label_1000_833C_1833C:
    // CALL 0x1000:6827 (1000_833C / 0x1833C)
    NearCall(cs1, 0x833F, not_observed_1000_6827_016827);
    State.IncCycles();
    // CALL 0x1000:c5cf (1000_833F / 0x1833F)
    NearCall(cs1, 0x8342, spice86_generated_label_call_target_1000_C5CF_01C5CF);
    State.IncCycles();
    // MOV SI,DI (1000_8342 / 0x18342)
    SI = DI;
    State.IncCycles();
    // JMP 0x1000:c6ad (1000_8344 / 0x18344)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C6AD_01C6AD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_8347_018347(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8347_18347:
    // PUSH SI (1000_8347 / 0x18347)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_8348 / 0x18348)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,0x11d3 (1000_8349 / 0x18349)
    DI = 0x11D3;
    State.IncCycles();
    // LEA SI,[DI + 0x2] (1000_834C / 0x1834C)
    SI = (ushort)(DI + 0x2);
    State.IncCycles();
    // PUSH DS (1000_834F / 0x1834F)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_8350 / 0x18350)
    ES = Stack.Pop();
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_8351 / 0x18351)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_8352 / 0x18352)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_8353 / 0x18353)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // POP DI (1000_8354 / 0x18354)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_8355 / 0x18355)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8356 / 0x18356)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8357_018357(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8357_18357:
    // CMP SI,0x8e0 (1000_8357 / 0x18357)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JNZ 0x1000:8368 (1000_835B / 0x1835B)
    if(!ZeroFlag) {
      goto label_1000_8368_18368;
    }
    State.IncCycles();
    // MOV AX,[0x11d3] (1000_835D / 0x1835D)
    AX = UInt16[DS, 0x11D3];
    State.IncCycles();
    // CMP AX,word ptr [SI + 0x4] (1000_8360 / 0x18360)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JNZ 0x1000:8368 (1000_8363 / 0x18363)
    if(!ZeroFlag) {
      goto label_1000_8368_18368;
    }
    State.IncCycles();
    // CALL 0x1000:8347 (1000_8365 / 0x18365)
    NearCall(cs1, 0x8368, not_observed_1000_8347_018347);
    State.IncCycles();
    label_1000_8368_18368:
    // MOV AL,byte ptr [SI + 0x3] (1000_8368 / 0x18368)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_836B / 0x1836B)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_836D / 0x1836D)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV DX,word ptr [DI + 0x2] (1000_8370 / 0x18370)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x4] (1000_8373 / 0x18373)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // MOV word ptr [SI + 0x6],DX (1000_8376 / 0x18376)
    UInt16[DS, (ushort)(SI + 0x6)] = DX;
    State.IncCycles();
    // MOV word ptr [SI + 0x8],BX (1000_8379 / 0x18379)
    UInt16[DS, (ushort)(SI + 0x8)] = BX;
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x2 (1000_837C / 0x1837C)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JNZ 0x1000:8387 (1000_8380 / 0x18380)
    if(!ZeroFlag) {
      goto label_1000_8387_18387;
    }
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_8382 / 0x18382)
    NearCall(cs1, 0x8385, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    // JC 0x1000:83a7 (1000_8385 / 0x18385)
    if(CarryFlag) {
      goto label_1000_83A7_183A7;
    }
    State.IncCycles();
    label_1000_8387_18387:
    // PUSH AX (1000_8387 / 0x18387)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:83bc (1000_8388 / 0x18388)
    NearCall(cs1, 0x838B, not_observed_1000_83BC_0183BC);
    State.IncCycles();
    // POP AX (1000_838B / 0x1838B)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP AL,0x5 (1000_838C / 0x1838C)
    Alu.Sub8(AL, 0x5);
    State.IncCycles();
    // JZ 0x1000:839a (1000_838E / 0x1838E)
    if(ZeroFlag) {
      goto label_1000_839A_1839A;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_8390 / 0x18390)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CMP AL,byte ptr [DI + 0x9] (1000_8392 / 0x18392)
    Alu.Sub8(AL, UInt8[DS, (ushort)(DI + 0x9)]);
    State.IncCycles();
    // JNZ 0x1000:83fd (1000_8395 / 0x18395)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_83FD_0183FD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JMP 0x1000:7429 (1000_8397 / 0x18397)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_7429_017429, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_839A_1839A:
    // TEST byte ptr [DI + 0xa],0x80 (1000_839A / 0x1839A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    State.IncCycles();
    // JZ 0x1000:83fd (1000_839E / 0x1839E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_83FD_0183FD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // AND byte ptr [DI + 0xa],0x7f (1000_83A0 / 0x183A0)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x7F);
    State.IncCycles();
    // JMP 0x1000:5d44 (1000_83A4 / 0x183A4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D44_015D44, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_83A7_183A7:
    // CMP AL,0x5 (1000_83A7 / 0x183A7)
    Alu.Sub8(AL, 0x5);
    State.IncCycles();
    // JC 0x1000:83b6 (1000_83A9 / 0x183A9)
    if(CarryFlag) {
      goto label_1000_83B6_183B6;
    }
    State.IncCycles();
    // CMP AL,0x6 (1000_83AB / 0x183AB)
    Alu.Sub8(AL, 0x6);
    State.IncCycles();
    // JA 0x1000:83b6 (1000_83AD / 0x183AD)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_83B6_183B6;
    }
    State.IncCycles();
    // PUSH DI (1000_83AF / 0x183AF)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:6ac5 (1000_83B0 / 0x183B0)
    NearCall(cs1, 0x83B3, not_observed_1000_6AC5_016AC5);
    State.IncCycles();
    // POP DI (1000_83B3 / 0x183B3)
    DI = Stack.Pop();
    State.IncCycles();
    // XOR AL,AL (1000_83B4 / 0x183B4)
    AL = 0;
    State.IncCycles();
    label_1000_83B6_183B6:
    // AND AL,0x3 (1000_83B6 / 0x183B6)
    AL &= 0x3;
    State.IncCycles();
    // CMP AL,0x3 (1000_83B8 / 0x183B8)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JZ 0x1000:841f (1000_83BA / 0x183BA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_841F_01841F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_83BC_0183BC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_83BC_0183BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_83BC_183BC:
    // CALL 0x1000:851f (1000_83BC / 0x183BC)
    NearCall(cs1, 0x83BF, not_observed_1000_851F_01851F);
    State.IncCycles();
    // AND byte ptr [SI + 0x3],0xbf (1000_83BF / 0x183BF)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0xBF;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xBF);
    State.IncCycles();
    // CALL 0x1000:85cc (1000_83C3 / 0x183C3)
    NearCall(cs1, 0x83C6, not_observed_1000_85CC_0185CC);
    State.IncCycles();
    // CALL 0x1000:7f5f (1000_83C6 / 0x183C6)
    NearCall(cs1, 0x83C9, not_observed_1000_7F5F_017F5F);
    State.IncCycles();
    // MOV CL,byte ptr [SI + 0x3] (1000_83C9 / 0x183C9)
    CL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // OR CL,CL (1000_83CC / 0x183CC)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JS 0x1000:83fc (1000_83CE / 0x183CE)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    State.IncCycles();
    // AND CL,0xf (1000_83D0 / 0x183D0)
    // CL &= 0xF;
    CL = Alu.And8(CL, 0xF);
    State.IncCycles();
    // CALL 0x1000:6ad4 (1000_83D3 / 0x183D3)
    NearCall(cs1, 0x83D6, not_observed_1000_6AD4_016AD4);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_83D6 / 0x183D6)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP DI,word ptr [0x114e] (1000_83D9 / 0x183D9)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JNZ 0x1000:83fc (1000_83DD / 0x183DD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:d41b (1000_83DF / 0x183DF)
    NearCall(cs1, 0x83E2, spice86_generated_label_call_target_1000_D41B_01D41B);
    State.IncCycles();
    // CMP BP,0x1f0e (1000_83E2 / 0x183E2)
    Alu.Sub16(BP, 0x1F0E);
    State.IncCycles();
    // JNZ 0x1000:83fc (1000_83E6 / 0x183E6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_83E8 / 0x183E8)
    AL = 0x1;
    State.IncCycles();
    // CMP byte ptr [0x2b],0x1 (1000_83EA / 0x183EA)
    Alu.Sub8(UInt8[DS, 0x2B], 0x1);
    State.IncCycles();
    // ADC AL,0x0 (1000_83EF / 0x183EF)
    AL = Alu.Adc8(AL, 0x0);
    State.IncCycles();
    // CMP byte ptr [0xb],AL (1000_83F1 / 0x183F1)
    Alu.Sub8(UInt8[DS, 0xB], AL);
    State.IncCycles();
    // JNZ 0x1000:83fc (1000_83F5 / 0x183F5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_83FC / 0x183FC)
      return NearRet();
    }
    State.IncCycles();
    // OR byte ptr [0x473b],0x1 (1000_83F7 / 0x183F7)
    // UInt8[DS, 0x473B] |= 0x1;
    UInt8[DS, 0x473B] = Alu.Or8(UInt8[DS, 0x473B], 0x1);
    State.IncCycles();
    label_1000_83FC_183FC:
    // RET  (1000_83FC / 0x183FC)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_83FD_0183FD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_83FD_183FD:
    // MOV BP,0x8403 (1000_83FD / 0x183FD)
    BP = 0x8403;
    State.IncCycles();
    // JMP 0x1000:661d (1000_8400 / 0x18400)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_661D_01661D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_841F_01841F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_841F_1841F:
    // MOV DI,word ptr [SI + 0x4] (1000_841F / 0x1841F)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP DI,word ptr [SI + 0xc] (1000_8422 / 0x18422)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0xC)]);
    State.IncCycles();
    // JZ 0x1000:844d (1000_8425 / 0x18425)
    if(ZeroFlag) {
      goto label_1000_844D_1844D;
    }
    State.IncCycles();
    // PUSH SI (1000_8427 / 0x18427)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_8428 / 0x18428)
    NearCall(cs1, 0x842B, spice86_generated_label_call_target_1000_7F27_017F27);
    State.IncCycles();
    // POP SI (1000_842B / 0x1842B)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV BX,word ptr [SI + 0xe] (1000_842C / 0x1842C)
    BX = UInt16[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV CX,BX (1000_842F / 0x1842F)
    CX = BX;
    State.IncCycles();
    // XOR BH,BH (1000_8431 / 0x18431)
    BH = 0;
    State.IncCycles();
    // CMP byte ptr [BX + 0x46fe],0x0 (1000_8433 / 0x18433)
    Alu.Sub8(UInt8[DS, (ushort)(BX + 0x46FE)], 0x0);
    State.IncCycles();
    // JZ 0x1000:8442 (1000_8438 / 0x18438)
    if(ZeroFlag) {
      goto label_1000_8442_18442;
    }
    State.IncCycles();
    // DEC byte ptr [BX + DI + 0x14] (1000_843A / 0x1843A)
    UInt8[DS, (ushort)(BX + DI + 0x14)] = Alu.Dec8(UInt8[DS, (ushort)(BX + DI + 0x14)]);
    State.IncCycles();
    // OR byte ptr [SI + 0x19],CH (1000_843D / 0x1843D)
    UInt8[DS, (ushort)(SI + 0x19)] |= CH;
    State.IncCycles();
    // XOR CH,CH (1000_8440 / 0x18440)
    CH = 0;
    State.IncCycles();
    label_1000_8442_18442:
    // MOV word ptr [SI + 0xe],CX (1000_8442 / 0x18442)
    UInt16[DS, (ushort)(SI + 0xE)] = CX;
    State.IncCycles();
    // MOV DI,word ptr [SI + 0xc] (1000_8445 / 0x18445)
    DI = UInt16[DS, (ushort)(SI + 0xC)];
    State.IncCycles();
    // MOV word ptr [SI + 0x4],DI (1000_8448 / 0x18448)
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    State.IncCycles();
    // JMP 0x1000:8461 (1000_844B / 0x1844B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8461_018461, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_844D_1844D:
    // AND byte ptr [SI + 0x3],0xfc (1000_844D / 0x1844D)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0xFC;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xFC);
    State.IncCycles();
    // JMP 0x1000:83bc (1000_8451 / 0x18451)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_83BC_0183BC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_8461_018461(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8461_18461:
    // CALL 0x1000:6917 (1000_8461 / 0x18461)
    NearCall(cs1, 0x8464, spice86_generated_label_call_target_1000_6917_016917);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_8464_018464, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_8464_018464(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8464_18464:
    // JZ 0x1000:8467 (1000_8464 / 0x18464)
    if(ZeroFlag) {
      goto label_1000_8467_18467;
    }
    State.IncCycles();
    // RET  (1000_8466 / 0x18466)
    return NearRet();
    State.IncCycles();
    label_1000_8467_18467:
    // PUSH SI (1000_8467 / 0x18467)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:c58a (1000_8468 / 0x18468)
    NearCall(cs1, 0x846B, spice86_generated_label_call_target_1000_C58A_01C58A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_846B_01846B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_846B_01846B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_846B_1846B:
    // POP SI (1000_846B / 0x1846B)
    SI = Stack.Pop();
    State.IncCycles();
    // PUSH SI (1000_846C / 0x1846C)
    Stack.Push(SI);
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_846D / 0x1846D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:847b (1000_8471 / 0x18471)
    if(!ZeroFlag) {
      goto label_1000_847B_1847B;
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_8473 / 0x18473)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL 0x1000:5ed0 (1000_8476 / 0x18476)
    NearCall(cs1, 0x8479, spice86_generated_label_call_target_1000_5ED0_015ED0);
    State.IncCycles();
    label_1000_8479_18479:
    // JNZ 0x1000:848b (1000_8479 / 0x18479)
    if(!ZeroFlag) {
      goto label_1000_848B_1848B;
    }
    State.IncCycles();
    label_1000_847B_1847B:
    // MOV AL,byte ptr [SI] (1000_847B / 0x1847B)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CALL 0x1000:6757 (1000_847D / 0x1847D)
    NearCall(cs1, 0x8480, spice86_generated_label_call_target_1000_6757_016757);
    State.IncCycles();
    label_1000_8480_18480:
    // JC 0x1000:848b (1000_8480 / 0x18480)
    if(CarryFlag) {
      goto label_1000_848B_1848B;
    }
    State.IncCycles();
    // MOV SI,DI (1000_8482 / 0x18482)
    SI = DI;
    State.IncCycles();
    // PUSH DI (1000_8484 / 0x18484)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:c6ad (1000_8485 / 0x18485)
    NearCall(cs1, 0x8488, spice86_generated_label_call_target_1000_C6AD_01C6AD);
    State.IncCycles();
    label_1000_8488_18488:
    // POP DI (1000_8488 / 0x18488)
    DI = Stack.Pop();
    State.IncCycles();
    label_1000_8489_18489:
    // POP SI (1000_8489 / 0x18489)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_848A / 0x1848A)
    return NearRet();
    State.IncCycles();
    label_1000_848B_1848B:
    // XOR DI,DI (1000_848B / 0x1848B)
    DI = 0;
    State.IncCycles();
    // JMP 0x1000:8489 (1000_848D / 0x1848D)
    goto label_1000_8489_18489;
  }
  
  public virtual Action not_observed_1000_848F_01848F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_848F_1848F:
    // MOV DI,word ptr [0x11d3] (1000_848F / 0x1848F)
    DI = UInt16[DS, 0x11D3];
    State.IncCycles();
    // CMP word ptr [SI + 0x4],DI (1000_8493 / 0x18493)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], DI);
    State.IncCycles();
    // JNZ 0x1000:84a3 (1000_8496 / 0x18496)
    if(!ZeroFlag) {
      goto label_1000_84A3_184A3;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_8498 / 0x18498)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:84a3 (1000_849C / 0x1849C)
    if(!ZeroFlag) {
      goto label_1000_84A3_184A3;
    }
    State.IncCycles();
    // CALL 0x1000:8347 (1000_849E / 0x1849E)
    NearCall(cs1, 0x84A1, not_observed_1000_8347_018347);
    State.IncCycles();
    // JMP 0x1000:848f (1000_84A1 / 0x184A1)
    goto label_1000_848F_1848F;
    State.IncCycles();
    label_1000_84A3_184A3:
    // OR DI,DI (1000_84A3 / 0x184A3)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // RET  (1000_84A5 / 0x184A5)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_84A6_0184A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_84A6_184A6:
    // CMP SI,0x8e0 (1000_84A6 / 0x184A6)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JNZ 0x1000:84b2 (1000_84AA / 0x184AA)
    if(!ZeroFlag) {
      goto label_1000_84B2_184B2;
    }
    State.IncCycles();
    // CALL 0x1000:848f (1000_84AC / 0x184AC)
    NearCall(cs1, 0x84AF, not_observed_1000_848F_01848F);
    State.IncCycles();
    // JNZ 0x1000:84b2 (1000_84AF / 0x184AF)
    if(!ZeroFlag) {
      goto label_1000_84B2_184B2;
    }
    State.IncCycles();
    // RET  (1000_84B1 / 0x184B1)
    return NearRet();
    State.IncCycles();
    label_1000_84B2_184B2:
    // TEST byte ptr [SI + 0x3],0x40 (1000_84B2 / 0x184B2)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JZ 0x1000:84ca (1000_84B6 / 0x184B6)
    if(ZeroFlag) {
      goto label_1000_84CA_184CA;
    }
    State.IncCycles();
    // MOV word ptr [SI + 0x4],DI (1000_84B8 / 0x184B8)
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    State.IncCycles();
    // MOV AL,0x3 (1000_84BB / 0x184BB)
    AL = 0x3;
    State.IncCycles();
    // AND AL,byte ptr [SI + 0x3] (1000_84BD / 0x184BD)
    AL &= UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // CMP AL,0x3 (1000_84C0 / 0x184C0)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:84c8 (1000_84C2 / 0x184C2)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:8461 (1000_84C8 / 0x184C8)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8461_018461, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // AND byte ptr [SI + 0x3],0xfc (1000_84C4 / 0x184C4)
    // UInt8[DS, (ushort)(SI + 0x3)] &= 0xFC;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xFC);
    State.IncCycles();
    label_1000_84C8_184C8:
    // JMP 0x1000:8461 (1000_84C8 / 0x184C8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_8461_018461, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_84CA_184CA:
    // CALL 0x1000:6ebf (1000_84CA / 0x184CA)
    NearCall(cs1, 0x84CD, not_observed_1000_6EBF_016EBF);
    State.IncCycles();
    // PUSH DI (1000_84CD / 0x184CD)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:858c (1000_84CE / 0x184CE)
    NearCall(cs1, 0x84D1, not_observed_1000_858C_01858C);
    State.IncCycles();
    // POP DI (1000_84D1 / 0x184D1)
    DI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [SI + 0x3],0x6 (1000_84D2 / 0x184D2)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x6);
    State.IncCycles();
    // JNZ 0x1000:8501 (1000_84D6 / 0x184D6)
    if(!ZeroFlag) {
      goto label_1000_8501_18501;
    }
    State.IncCycles();
    // PUSH DI (1000_84D8 / 0x184D8)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_84D9 / 0x184D9)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x2 (1000_84DC / 0x184DC)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JZ 0x1000:84ef (1000_84E0 / 0x184E0)
    if(ZeroFlag) {
      goto label_1000_84EF_184EF;
    }
    State.IncCycles();
    // CALL 0x1000:5098 (1000_84E2 / 0x184E2)
    NearCall(cs1, 0x84E5, not_observed_1000_5098_015098);
    State.IncCycles();
    // JCXZ 0x1000:84ef (1000_84E5 / 0x184E5)
    if(CX == 0) {
      goto label_1000_84EF_184EF;
    }
    State.IncCycles();
    // DEC DX (1000_84E7 / 0x184E7)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // JG 0x1000:84ef (1000_84E8 / 0x184E8)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_84EF_184EF;
    }
    State.IncCycles();
    // PUSH SI (1000_84EA / 0x184EA)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:74b6 (1000_84EB / 0x184EB)
    NearCall(cs1, 0x84EE, not_observed_1000_74B6_0174B6);
    State.IncCycles();
    // POP SI (1000_84EE / 0x184EE)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_84EF_184EF:
    // POP DI (1000_84EF / 0x184EF)
    DI = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x28 (1000_84F0 / 0x184F0)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    State.IncCycles();
    // JNC 0x1000:8501 (1000_84F4 / 0x184F4)
    if(!CarryFlag) {
      goto label_1000_8501_18501;
    }
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x2 (1000_84F6 / 0x184F6)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JNZ 0x1000:851e (1000_84FA / 0x184FA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_851E / 0x1851E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,0x3 (1000_84FC / 0x184FC)
    AL = 0x3;
    State.IncCycles();
    // CALL 0x1000:6f93 (1000_84FE / 0x184FE)
    NearCall(cs1, 0x8501, not_observed_1000_6F93_016F93);
    State.IncCycles();
    label_1000_8501_18501:
    // XCHG word ptr [SI + 0x4],DI (1000_8501 / 0x18501)
    ushort tmp_1000_8501 = UInt16[DS, (ushort)(SI + 0x4)];
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    DI = tmp_1000_8501;
    State.IncCycles();
    // OR byte ptr [SI + 0x3],0x40 (1000_8504 / 0x18504)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x40;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // MOV byte ptr [SI + 0x2],0x0 (1000_8508 / 0x18508)
    UInt8[DS, (ushort)(SI + 0x2)] = 0x0;
    State.IncCycles();
    // CALL 0x1000:7f75 (1000_850C / 0x1850C)
    NearCall(cs1, 0x850F, not_observed_1000_7F75_017F75);
    State.IncCycles();
    // CALL 0x1000:8461 (1000_850F / 0x1850F)
    NearCall(cs1, 0x8512, spice86_generated_label_call_target_1000_8461_018461);
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x10 (1000_8512 / 0x18512)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x10);
    State.IncCycles();
    // JNZ 0x1000:851e (1000_8516 / 0x18516)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_851E / 0x1851E)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0x7 (1000_8518 / 0x18518)
    CX = 0x7;
    State.IncCycles();
    // JMP 0x1000:8313 (1000_851B / 0x1851B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8313_018313, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_851E_1851E:
    // RET  (1000_851E / 0x1851E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_851F_01851F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_851F_1851F:
    // MOV AH,byte ptr [SI] (1000_851F / 0x1851F)
    AH = UInt8[DS, SI];
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_8521 / 0x18521)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    // OR AL,AL (1000_8524 / 0x18524)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:8540 (1000_8526 / 0x18526)
    if(!ZeroFlag) {
      goto label_1000_8540_18540;
    }
    State.IncCycles();
    // MOV byte ptr [DI + 0x9],AH (1000_8528 / 0x18528)
    UInt8[DS, (ushort)(DI + 0x9)] = AH;
    State.IncCycles();
    // MOV CX,0x1 (1000_852B / 0x1852B)
    CX = 0x1;
    State.IncCycles();
    // MOV byte ptr [SI + 0x2],CL (1000_852E / 0x1852E)
    UInt8[DS, (ushort)(SI + 0x2)] = CL;
    State.IncCycles();
    // TEST word ptr [SI + 0x10],0x80 (1000_8531 / 0x18531)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JZ 0x1000:853f (1000_8536 / 0x18536)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_853F / 0x1853F)
      return NearRet();
    }
    State.IncCycles();
    // ADD byte ptr [SI + 0x2],0x8 (1000_8538 / 0x18538)
    UInt8[DS, (ushort)(SI + 0x2)] += 0x8;
    State.IncCycles();
    // ADD CL,0x8 (1000_853C / 0x1853C)
    // CL += 0x8;
    CL = Alu.Add8(CL, 0x8);
    State.IncCycles();
    label_1000_853F_1853F:
    // RET  (1000_853F / 0x1853F)
    return NearRet();
    State.IncCycles();
    label_1000_8540_18540:
    // PUSH DI (1000_8540 / 0x18540)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_8541 / 0x18541)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_8542 / 0x18542)
    ES = Stack.Pop();
    State.IncCycles();
    // SUB SP,0x1e (1000_8543 / 0x18543)
    // SP -= 0x1E;
    SP = Alu.Sub16(SP, 0x1E);
    State.IncCycles();
    // MOV DI,SP (1000_8546 / 0x18546)
    DI = SP;
    State.IncCycles();
    // MOV CX,0x1e (1000_8548 / 0x18548)
    CX = 0x1E;
    State.IncCycles();
    // PUSH AX (1000_854B / 0x1854B)
    Stack.Push(AX);
    State.IncCycles();
    // XOR AL,AL (1000_854C / 0x1854C)
    AL = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_854E / 0x1854E)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP AX (1000_8550 / 0x18550)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV DI,SP (1000_8551 / 0x18551)
    DI = SP;
    State.IncCycles();
    // PUSH SI (1000_8553 / 0x18553)
    Stack.Push(SI);
    State.IncCycles();
    // XOR BX,BX (1000_8554 / 0x18554)
    BX = 0;
    State.IncCycles();
    label_1000_8556_18556:
    // CALL 0x1000:6906 (1000_8556 / 0x18556)
    NearCall(cs1, 0x8559, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    // MOV BL,byte ptr [SI + 0x2] (1000_8559 / 0x18559)
    BL = UInt8[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // MOV byte ptr [BX + DI + -0x1],0xff (1000_855C / 0x1855C)
    UInt8[DS, (ushort)(BX + DI - 0x1)] = 0xFF;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1] (1000_8560 / 0x18560)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // OR AL,AL (1000_8563 / 0x18563)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:8556 (1000_8565 / 0x18565)
    if(!ZeroFlag) {
      goto label_1000_8556_18556;
    }
    State.IncCycles();
    // MOV byte ptr [SI + 0x1],AH (1000_8567 / 0x18567)
    UInt8[DS, (ushort)(SI + 0x1)] = AH;
    State.IncCycles();
    // MOV CX,0x1e (1000_856A / 0x1856A)
    CX = 0x1E;
    State.IncCycles();
    // POP SI (1000_856D / 0x1856D)
    SI = Stack.Pop();
    State.IncCycles();
    // TEST word ptr [SI + 0x10],0x80 (1000_856E / 0x1856E)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JZ 0x1000:857b (1000_8573 / 0x18573)
    if(ZeroFlag) {
      goto label_1000_857B_1857B;
    }
    State.IncCycles();
    // SUB CX,0x8 (1000_8575 / 0x18575)
    CX -= 0x8;
    State.IncCycles();
    // ADD DI,0x8 (1000_8578 / 0x18578)
    DI += 0x8;
    State.IncCycles();
    label_1000_857B_1857B:
    // XOR AL,AL (1000_857B / 0x1857B)
    AL = 0;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_857D / 0x1857D)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // SUB CX,0x1e (1000_857F / 0x1857F)
    CX -= 0x1E;
    State.IncCycles();
    // NEG CX (1000_8582 / 0x18582)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // ADD SP,0x1e (1000_8584 / 0x18584)
    // SP += 0x1E;
    SP = Alu.Add16(SP, 0x1E);
    State.IncCycles();
    // POP DI (1000_8587 / 0x18587)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [SI + 0x2],CL (1000_8588 / 0x18588)
    UInt8[DS, (ushort)(SI + 0x2)] = CL;
    State.IncCycles();
    // RET  (1000_858B / 0x1858B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_858C_01858C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_858C_1858C:
    // MOV BP,SI (1000_858C / 0x1858C)
    BP = SI;
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_858E / 0x1858E)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_8590 / 0x18590)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // PUSH DI (1000_8593 / 0x18593)
    Stack.Push(DI);
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_8594 / 0x18594)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:85ba (1000_8598 / 0x18598)
    if(!ZeroFlag) {
      goto label_1000_85BA_185BA;
    }
    State.IncCycles();
    // CMP AL,byte ptr [DI + 0x9] (1000_859A / 0x1859A)
    Alu.Sub8(AL, UInt8[DS, (ushort)(DI + 0x9)]);
    State.IncCycles();
    // JZ 0x1000:85c2 (1000_859D / 0x1859D)
    if(ZeroFlag) {
      goto label_1000_85C2_185C2;
    }
    State.IncCycles();
    // MOV CL,AL (1000_859F / 0x1859F)
    CL = AL;
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_85A1 / 0x185A1)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    label_1000_85A4_185A4:
    // CALL 0x1000:6906 (1000_85A4 / 0x185A4)
    NearCall(cs1, 0x85A7, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1] (1000_85A7 / 0x185A7)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // MOV DI,SI (1000_85AA / 0x185AA)
    DI = SI;
    State.IncCycles();
    // OR AL,AL (1000_85AC / 0x185AC)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:85ba (1000_85AE / 0x185AE)
    if(ZeroFlag) {
      goto label_1000_85BA_185BA;
    }
    State.IncCycles();
    // CMP AL,CL (1000_85B0 / 0x185B0)
    Alu.Sub8(AL, CL);
    State.IncCycles();
    // JNZ 0x1000:85a4 (1000_85B2 / 0x185B2)
    if(!ZeroFlag) {
      goto label_1000_85A4_185A4;
    }
    State.IncCycles();
    // MOV AH,byte ptr [BP + 0x1] (1000_85B4 / 0x185B4)
    AH = UInt8[SS, (ushort)(BP + 0x1)];
    State.IncCycles();
    // MOV byte ptr [SI + 0x1],AH (1000_85B7 / 0x185B7)
    UInt8[DS, (ushort)(SI + 0x1)] = AH;
    State.IncCycles();
    label_1000_85BA_185BA:
    // MOV SI,BP (1000_85BA / 0x185BA)
    SI = BP;
    State.IncCycles();
    // MOV byte ptr [SI + 0x1],0x0 (1000_85BC / 0x185BC)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x0;
    State.IncCycles();
    // POP DI (1000_85C0 / 0x185C0)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_85C1 / 0x185C1)
    return NearRet();
    State.IncCycles();
    label_1000_85C2_185C2:
    // XOR AH,AH (1000_85C2 / 0x185C2)
    AH = 0;
    State.IncCycles();
    // XCHG byte ptr [SI + 0x1],AH (1000_85C4 / 0x185C4)
    byte tmp_1000_85C4 = UInt8[DS, (ushort)(SI + 0x1)];
    UInt8[DS, (ushort)(SI + 0x1)] = AH;
    AH = tmp_1000_85C4;
    State.IncCycles();
    // POP DI (1000_85C7 / 0x185C7)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV byte ptr [DI + 0x9],AH (1000_85C8 / 0x185C8)
    UInt8[DS, (ushort)(DI + 0x9)] = AH;
    State.IncCycles();
    // RET  (1000_85CB / 0x185CB)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_85CC_0185CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_85CC_185CC:
    // TEST word ptr [SI + 0x10],0x80 (1000_85CC / 0x185CC)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:8603 (1000_85D1 / 0x185D1)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8603 / 0x18603)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x2],0x8 (1000_85D3 / 0x185D3)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    State.IncCycles();
    // JBE 0x1000:8603 (1000_85D7 / 0x185D7)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_8603 / 0x18603)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:858c (1000_85D9 / 0x185D9)
    NearCall(cs1, 0x85DC, not_observed_1000_858C_01858C);
    State.IncCycles();
    // PUSH SI (1000_85DC / 0x185DC)
    Stack.Push(SI);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x9] (1000_85DD / 0x185DD)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    State.IncCycles();
    label_1000_85E0_185E0:
    // OR AL,AL (1000_85E0 / 0x185E0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:85ff (1000_85E2 / 0x185E2)
    if(ZeroFlag) {
      goto label_1000_85FF_185FF;
    }
    State.IncCycles();
    // CALL 0x1000:6906 (1000_85E4 / 0x185E4)
    NearCall(cs1, 0x85E7, spice86_generated_label_call_target_1000_6906_016906);
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1] (1000_85E7 / 0x185E7)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_85EA / 0x185EA)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:85e0 (1000_85EE / 0x185EE)
    if(!ZeroFlag) {
      goto label_1000_85E0_185E0;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x20 (1000_85F0 / 0x185F0)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // JZ 0x1000:85e0 (1000_85F4 / 0x185F4)
    if(ZeroFlag) {
      goto label_1000_85E0_185E0;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_85F6 / 0x185F6)
    NearCall(cs1, 0x85F9, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // CALL 0x1000:66b1 (1000_85F9 / 0x185F9)
    NearCall(cs1, 0x85FC, not_observed_1000_66B1_0166B1);
    State.IncCycles();
    // CALL 0x1000:e283 (1000_85FC / 0x185FC)
    NearCall(cs1, 0x85FF, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_85FF_185FF:
    // POP SI (1000_85FF / 0x185FF)
    SI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:851f (1000_8600 / 0x18600)
    NearCall(cs1, 0x8603, not_observed_1000_851F_01851F);
    State.IncCycles();
    label_1000_8603_18603:
    // RET  (1000_8603 / 0x18603)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_8604_018604(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_8604_18604:
    // PUSH SI (1000_8604 / 0x18604)
    Stack.Push(SI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_8605 / 0x18605)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV DX,word ptr [DI + 0x2] (1000_8608 / 0x18608)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x8] (1000_860B / 0x1860B)
    BX = UInt16[DS, (ushort)(SI + 0x8)];
    State.IncCycles();
    // MOV BP,BX (1000_860E / 0x1860E)
    BP = BX;
    State.IncCycles();
    // SHL BP,1 (1000_8610 / 0x18610)
    // BP <<= 0x1;
    BP = Alu.Shl16(BP, 0x1);
    State.IncCycles();
    // JNS 0x1000:8616 (1000_8612 / 0x18612)
    if(!SignFlag) {
      goto label_1000_8616_18616;
    }
    State.IncCycles();
    // NEG BP (1000_8614 / 0x18614)
    BP = Alu.Sub16(0, BP);
    State.IncCycles();
    label_1000_8616_18616:
    // MOV BP,word ptr [BP + 0x4880] (1000_8616 / 0x18616)
    BP = UInt16[SS, (ushort)(BP + 0x4880)];
    State.IncCycles();
    // SUB BX,word ptr [DI + 0x4] (1000_861A / 0x1861A)
    BX -= UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // NEG BX (1000_861D / 0x1861D)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // MOV DI,0x1 (1000_861F / 0x1861F)
    DI = 0x1;
    State.IncCycles();
    // JNS 0x1000:8628 (1000_8622 / 0x18622)
    if(!SignFlag) {
      goto label_1000_8628_18628;
    }
    State.IncCycles();
    // NEG DI (1000_8624 / 0x18624)
    DI = Alu.Sub16(0, DI);
    State.IncCycles();
    // NEG BX (1000_8626 / 0x18626)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    label_1000_8628_18628:
    // SUB DX,word ptr [SI + 0x6] (1000_8628 / 0x18628)
    // DX -= UInt16[DS, (ushort)(SI + 0x6)];
    DX = Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // MOV AX,DX (1000_862B / 0x1862B)
    AX = DX;
    State.IncCycles();
    // JNS 0x1000:8631 (1000_862D / 0x1862D)
    if(!SignFlag) {
      goto label_1000_8631_18631;
    }
    State.IncCycles();
    // NEG AX (1000_862F / 0x1862F)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_8631_18631:
    // MOV SI,DX (1000_8631 / 0x18631)
    SI = DX;
    State.IncCycles();
    // XOR DX,DX (1000_8633 / 0x18633)
    DX = 0;
    State.IncCycles();
    // DIV BP (1000_8635 / 0x18635)
    Cpu.Div16(BP);
    State.IncCycles();
    // MOV DX,SI (1000_8637 / 0x18637)
    DX = SI;
    State.IncCycles();
    // XCHG DI,BX (1000_8639 / 0x18639)
    ushort tmp_1000_8639 = DI;
    DI = BX;
    BX = tmp_1000_8639;
    State.IncCycles();
    // CMP AX,DI (1000_863B / 0x1863B)
    Alu.Sub16(AX, DI);
    State.IncCycles();
    // JC 0x1000:8666 (1000_863D / 0x1863D)
    if(CarryFlag) {
      goto label_1000_8666_18666;
    }
    State.IncCycles();
    // CMP AX,0x7 (1000_863F / 0x1863F)
    Alu.Sub16(AX, 0x7);
    State.IncCycles();
    // JC 0x1000:8660 (1000_8642 / 0x18642)
    if(CarryFlag) {
      goto label_1000_8660_18660;
    }
    State.IncCycles();
    // OR DI,DI (1000_8644 / 0x18644)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JNZ 0x1000:864a (1000_8646 / 0x18646)
    if(!ZeroFlag) {
      goto label_1000_864A_1864A;
    }
    State.IncCycles();
    // XOR BX,BX (1000_8648 / 0x18648)
    BX = 0;
    State.IncCycles();
    label_1000_864A_1864A:
    // OR DX,DX (1000_864A / 0x1864A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNS 0x1000:8650 (1000_864C / 0x1864C)
    if(!SignFlag) {
      goto label_1000_8650_18650;
    }
    State.IncCycles();
    // NEG BP (1000_864E / 0x1864E)
    BP = Alu.Sub16(0, BP);
    State.IncCycles();
    label_1000_8650_18650:
    // SHR AX,1 (1000_8650 / 0x18650)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // JZ 0x1000:865e (1000_8652 / 0x18652)
    if(ZeroFlag) {
      goto label_1000_865E_1865E;
    }
    State.IncCycles();
    // MOV DX,BP (1000_8654 / 0x18654)
    DX = BP;
    State.IncCycles();
    // ROL word ptr [0x0],1 (1000_8656 / 0x18656)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    State.IncCycles();
    // JC 0x1000:865e (1000_865A / 0x1865A)
    if(CarryFlag) {
      goto label_1000_865E_1865E;
    }
    State.IncCycles();
    // XOR BX,BX (1000_865C / 0x1865C)
    BX = 0;
    State.IncCycles();
    label_1000_865E_1865E:
    // POP SI (1000_865E / 0x1865E)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_865F / 0x1865F)
    return NearRet();
    State.IncCycles();
    label_1000_8660_18660:
    // XOR BX,BX (1000_8660 / 0x18660)
    BX = 0;
    State.IncCycles();
    // XOR DX,DX (1000_8662 / 0x18662)
    DX = 0;
    State.IncCycles();
    // POP SI (1000_8664 / 0x18664)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8665 / 0x18665)
    return NearRet();
    State.IncCycles();
    label_1000_8666_18666:
    // CMP DI,0x7 (1000_8666 / 0x18666)
    Alu.Sub16(DI, 0x7);
    State.IncCycles();
    // JC 0x1000:8660 (1000_8669 / 0x18669)
    if(CarryFlag) {
      goto label_1000_8660_18660;
    }
    State.IncCycles();
    // OR AX,AX (1000_866B / 0x1866B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:865e (1000_866D / 0x1866D)
    if(ZeroFlag) {
      goto label_1000_865E_1865E;
    }
    State.IncCycles();
    // OR DX,DX (1000_866F / 0x1866F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNS 0x1000:8675 (1000_8671 / 0x18671)
    if(!SignFlag) {
      goto label_1000_8675_18675;
    }
    State.IncCycles();
    // NEG BP (1000_8673 / 0x18673)
    BP = Alu.Sub16(0, BP);
    State.IncCycles();
    label_1000_8675_18675:
    // SHR DI,1 (1000_8675 / 0x18675)
    // DI >>= 0x1;
    DI = Alu.Shr16(DI, 0x1);
    State.IncCycles();
    // JZ 0x1000:865e (1000_8677 / 0x18677)
    if(ZeroFlag) {
      goto label_1000_865E_1865E;
    }
    State.IncCycles();
    // MOV DX,BP (1000_8679 / 0x18679)
    DX = BP;
    State.IncCycles();
    // ROL word ptr [0x0],1 (1000_867B / 0x1867B)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    State.IncCycles();
    // JC 0x1000:865e (1000_867F / 0x1867F)
    if(CarryFlag) {
      goto label_1000_865E_1865E;
    }
    State.IncCycles();
    // XOR DX,DX (1000_8681 / 0x18681)
    DX = 0;
    State.IncCycles();
    // POP SI (1000_8683 / 0x18683)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_8684 / 0x18684)
    return NearRet();
  }
  
}
