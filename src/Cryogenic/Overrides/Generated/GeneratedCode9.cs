namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_68EB_0168EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_68EB_168EB:
    // MOV AL,[0x1954] (1000_68EB / 0x168EB)
    AL = UInt8[DS, 0x1954];
    State.IncCycles();
    // CMP byte ptr [0x46eb],0x80 (1000_68EE / 0x168EE)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x80);
    State.IncCycles();
    // JNC 0x1000:6906 (1000_68F3 / 0x168F3)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6906_016906, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,[0x476c] (1000_68F5 / 0x168F5)
    AL = UInt8[DS, 0x476C];
    State.IncCycles();
    // XOR AH,AH (1000_68F8 / 0x168F8)
    AH = 0;
    State.IncCycles();
    // ADD AX,AX (1000_68FA / 0x168FA)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    State.IncCycles();
    // MOV SI,AX (1000_68FC / 0x168FC)
    SI = AX;
    State.IncCycles();
    // MOV SI,word ptr [SI + 0x4758] (1000_68FE / 0x168FE)
    SI = UInt16[DS, (ushort)(SI + 0x4758)];
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_6902 / 0x16902)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // JMP 0x1000:6912 (1000_6904 / 0x16904)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6912_016912, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6906_016906(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6906_16906:
    // MOV SI,AX (1000_6906 / 0x16906)
    SI = AX;
    State.IncCycles();
    // DEC AL (1000_6908 / 0x16908)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // MOV AH,0x1b (1000_690A / 0x1690A)
    AH = 0x1B;
    State.IncCycles();
    // MUL AH (1000_690C / 0x1690C)
    Cpu.Mul8(AH);
    State.IncCycles();
    // ADD AX,0x8aa (1000_690E / 0x1690E)
    // AX += 0x8AA;
    AX = Alu.Add16(AX, 0x8AA);
    State.IncCycles();
    // XCHG AX,SI (1000_6911 / 0x16911)
    ushort tmp_1000_6911 = AX;
    AX = SI;
    SI = tmp_1000_6911;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6912_016912, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6912_016912(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6912_16912:
    // CMP byte ptr [SI + 0x3],0x80 (1000_6912 / 0x16912)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x80);
    State.IncCycles();
    // RET  (1000_6916 / 0x16916)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6917_016917(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6917_16917:
    // CMP byte ptr [0x46eb],0x0 (1000_6917 / 0x16917)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // MOV DI,0x3caf (1000_691C / 0x1691C)
    DI = 0x3CAF;
    State.IncCycles();
    // JNS 0x1000:6938 (1000_691F / 0x1691F)
    if(!SignFlag) {
      goto label_1000_6938_16938;
    }
    State.IncCycles();
    // MOV CX,word ptr [0x3cbe] (1000_6921 / 0x16921)
    CX = UInt16[DS, 0x3CBE];
    State.IncCycles();
    label_1000_6925_16925:
    // JCXZ 0x1000:6938 (1000_6925 / 0x16925)
    if(CX == 0) {
      goto label_1000_6938_16938;
    }
    State.IncCycles();
    label_1000_6927_16927:
    // ADD DI,0x11 (1000_6927 / 0x16927)
    DI += 0x11;
    State.IncCycles();
    // CMP word ptr [DI + 0xa],SI (1000_692A / 0x1692A)
    Alu.Sub16(UInt16[DS, (ushort)(DI + 0xA)], SI);
    State.IncCycles();
    // LOOPNZ 0x1000:6927 (1000_692D / 0x1692D)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_6927_16927;
    }
    State.IncCycles();
    // JNZ 0x1000:6937 (1000_692F / 0x1692F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6937 / 0x16937)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [DI + 0xc],0x40 (1000_6931 / 0x16931)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:6925 (1000_6935 / 0x16935)
    if(!ZeroFlag) {
      goto label_1000_6925_16925;
    }
    State.IncCycles();
    label_1000_6937_16937:
    // RET  (1000_6937 / 0x16937)
    return NearRet();
    State.IncCycles();
    label_1000_6938_16938:
    // OR DI,DI (1000_6938 / 0x16938)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // RET  (1000_693A / 0x1693A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_693B_01693B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_693B_1693B:
    // MOV AL,byte ptr [SI + 0x3] (1000_693B / 0x1693B)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AX,0xf (1000_693E / 0x1693E)
    AX &= 0xF;
    State.IncCycles();
    // SHR AX,1 (1000_6941 / 0x16941)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_6943 / 0x16943)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // RET  (1000_6945 / 0x16945)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6946_016946(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6946_16946:
    // MOV SI,0x3cbe (1000_6946 / 0x16946)
    SI = 0x3CBE;
    State.IncCycles();
    // LODSW SI (1000_6949 / 0x16949)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_694A / 0x1694A)
    CX = AX;
    State.IncCycles();
    // JCXZ 0x1000:6972 (1000_694C / 0x1694C)
    if(CX == 0) {
      goto label_1000_6972_16972;
    }
    State.IncCycles();
    // MOV AL,0x11 (1000_694E / 0x1694E)
    AL = 0x11;
    State.IncCycles();
    // MUL CL (1000_6950 / 0x16950)
    Cpu.Mul8(CL);
    State.IncCycles();
    // ADD SI,AX (1000_6952 / 0x16952)
    SI += AX;
    State.IncCycles();
    label_1000_6954_16954:
    // SUB SI,0x11 (1000_6954 / 0x16954)
    SI -= 0x11;
    State.IncCycles();
    // CMP word ptr [SI],DX (1000_6957 / 0x16957)
    Alu.Sub16(UInt16[DS, SI], DX);
    State.IncCycles();
    // JGE 0x1000:6970 (1000_6959 / 0x16959)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6970_16970;
    }
    State.IncCycles();
    // CMP word ptr [SI + 0x2],BX (1000_695B / 0x1695B)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], BX);
    State.IncCycles();
    // JGE 0x1000:6970 (1000_695E / 0x1695E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6970_16970;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI + 0x4] (1000_6960 / 0x16960)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JGE 0x1000:6970 (1000_6963 / 0x16963)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6970_16970;
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0xc],0x40 (1000_6965 / 0x16965)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xC)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:6970 (1000_6969 / 0x16969)
    if(!ZeroFlag) {
      goto label_1000_6970_16970;
    }
    State.IncCycles();
    // CMP BX,word ptr [SI + 0x6] (1000_696B / 0x1696B)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JL 0x1000:6974 (1000_696E / 0x1696E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_6974_16974;
    }
    State.IncCycles();
    label_1000_6970_16970:
    // LOOP 0x1000:6954 (1000_6970 / 0x16970)
    if(--CX != 0) {
      goto label_1000_6954_16954;
    }
    State.IncCycles();
    label_1000_6972_16972:
    // CLC  (1000_6972 / 0x16972)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_6973 / 0x16973)
    return NearRet();
    State.IncCycles();
    label_1000_6974_16974:
    // MOV DI,word ptr [SI + 0xa] (1000_6974 / 0x16974)
    DI = UInt16[DS, (ushort)(SI + 0xA)];
    State.IncCycles();
    // CMP byte ptr [DI + 0x3],0x80 (1000_6977 / 0x16977)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x3)], 0x80);
    State.IncCycles();
    // RET  (1000_697B / 0x1697B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_697C_01697C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_697C_1697C:
    // CALL 0x1000:6917 (1000_697C / 0x1697C)
    NearCall(cs1, 0x697F, spice86_generated_label_call_target_1000_6917_016917);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_697F_01697F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_697F_01697F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_697F_1697F:
    // JNZ 0x1000:69a2 (1000_697F / 0x1697F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_69A2 / 0x169A2)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_6981 / 0x16981)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:698f (1000_6985 / 0x16985)
    if(!ZeroFlag) {
      goto label_1000_698F_1698F;
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6987 / 0x16987)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL 0x1000:5ed0 (1000_698A / 0x1698A)
    NearCall(cs1, 0x698D, spice86_generated_label_call_target_1000_5ED0_015ED0);
    State.IncCycles();
    label_1000_698D_1698D:
    // JNZ 0x1000:69a2 (1000_698D / 0x1698D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_69A2 / 0x169A2)
      return NearRet();
    }
    State.IncCycles();
    label_1000_698F_1698F:
    // CALL 0x1000:686e (1000_698F / 0x1698F)
    NearCall(cs1, 0x6992, spice86_generated_label_call_target_1000_686E_01686E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6992_016992, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6992_016992(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6992_16992:
    // JC 0x1000:69a2 (1000_6992 / 0x16992)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_69A2 / 0x169A2)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x18fd (1000_6994 / 0x16994)
    BP = 0x18FD;
    State.IncCycles();
    // CALL 0x1000:c5cf (1000_6997 / 0x16997)
    NearCall(cs1, 0x699A, spice86_generated_label_call_target_1000_C5CF_01C5CF);
    State.IncCycles();
    label_1000_699A_1699A:
    // OR byte ptr [DI + 0xc],0x40 (1000_699A / 0x1699A)
    // UInt8[DS, (ushort)(DI + 0xC)] |= 0x40;
    UInt8[DS, (ushort)(DI + 0xC)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xC)], 0x40);
    State.IncCycles();
    // MOV word ptr [0x4752],DI (1000_699E / 0x1699E)
    UInt16[DS, 0x4752] = DI;
    State.IncCycles();
    label_1000_69A2_169A2:
    // RET  (1000_69A2 / 0x169A2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_69A3_0169A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_69A3_169A3:
    // PUSH DI (1000_69A3 / 0x169A3)
    Stack.Push(DI);
    State.IncCycles();
    // XOR DI,DI (1000_69A4 / 0x169A4)
    DI = 0;
    State.IncCycles();
    // XCHG word ptr [0x4752],DI (1000_69A6 / 0x169A6)
    ushort tmp_1000_69A6 = UInt16[DS, 0x4752];
    UInt16[DS, 0x4752] = DI;
    DI = tmp_1000_69A6;
    State.IncCycles();
    // OR DI,DI (1000_69AA / 0x169AA)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:69b1 (1000_69AC / 0x169AC)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_69B1_0169B1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:c58a (1000_69AE / 0x169AE)
    NearCall(cs1, 0x69B1, spice86_generated_label_call_target_1000_C58A_01C58A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_69B1_0169B1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_69B1_0169B1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_69B1_169B1:
    // POP DI (1000_69B1 / 0x169B1)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_69B2 / 0x169B2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_69B3_0169B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_69B3_169B3:
    // CALL 0x1000:68eb (1000_69B3 / 0x169B3)
    NearCall(cs1, 0x69B6, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_69B6_0169B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_69B6_0169B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_69B6_169B6:
    // MOV BP,0x215a (1000_69B6 / 0x169B6)
    BP = 0x215A;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_69B9 / 0x169B9)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_69BC / 0x169BC)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,0x2 (1000_69BE / 0x169BE)
    Alu.Sub8(AL, 0x2);
    State.IncCycles();
    // JZ 0x1000:6a07 (1000_69C0 / 0x169C0)
    if(ZeroFlag) {
      goto label_1000_6A07_16A07;
    }
    State.IncCycles();
    // CALL 0x1000:693b (1000_69C2 / 0x169C2)
    NearCall(cs1, 0x69C5, spice86_generated_label_call_target_1000_693B_01693B);
    State.IncCycles();
    // MOV BP,0x216e (1000_69C5 / 0x169C5)
    BP = 0x216E;
    State.IncCycles();
    // CMP AX,0x1 (1000_69C8 / 0x169C8)
    Alu.Sub16(AX, 0x1);
    State.IncCycles();
    // JC 0x1000:69f6 (1000_69CB / 0x169CB)
    if(CarryFlag) {
      goto label_1000_69F6_169F6;
    }
    State.IncCycles();
    // MOV BP,0x21a6 (1000_69CD / 0x169CD)
    BP = 0x21A6;
    State.IncCycles();
    // JNZ 0x1000:69f6 (1000_69D0 / 0x169D0)
    if(!ZeroFlag) {
      goto label_1000_69F6_169F6;
    }
    State.IncCycles();
    // MOV BP,0x2182 (1000_69D2 / 0x169D2)
    BP = 0x2182;
    State.IncCycles();
    // AND word ptr [0x2188],0xbfff (1000_69D5 / 0x169D5)
    UInt16[DS, 0x2188] &= 0xBFFF;
    State.IncCycles();
    // CMP word ptr [0xe2],0x1e (1000_69DB / 0x169DB)
    Alu.Sub16(UInt16[DS, 0xE2], 0x1E);
    State.IncCycles();
    // JC 0x1000:69e8 (1000_69E0 / 0x169E0)
    if(CarryFlag) {
      goto label_1000_69E8_169E8;
    }
    State.IncCycles();
    // OR word ptr [0x2188],0x4000 (1000_69E2 / 0x169E2)
    // UInt16[DS, 0x2188] |= 0x4000;
    UInt16[DS, 0x2188] = Alu.Or16(UInt16[DS, 0x2188], 0x4000);
    State.IncCycles();
    label_1000_69E8_169E8:
    // MOV AL,byte ptr [SI + 0x3] (1000_69E8 / 0x169E8)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_69EB / 0x169EB)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,0x5 (1000_69ED / 0x169ED)
    Alu.Sub8(AL, 0x5);
    State.IncCycles();
    // JNZ 0x1000:69f6 (1000_69EF / 0x169EF)
    if(!ZeroFlag) {
      goto label_1000_69F6_169F6;
    }
    State.IncCycles();
    // MOV BP,0x219a (1000_69F1 / 0x169F1)
    BP = 0x219A;
    State.IncCycles();
    // JMP 0x1000:6a25 (1000_69F4 / 0x169F4)
    goto label_1000_6A25_16A25;
    State.IncCycles();
    label_1000_69F6_169F6:
    // AND word ptr [BP + 0x2],0xbfff (1000_69F6 / 0x169F6)
    UInt16[SS, (ushort)(BP + 0x2)] &= 0xBFFF;
    State.IncCycles();
    // CMP byte ptr [0x2a],0x10 (1000_69FB / 0x169FB)
    Alu.Sub8(UInt8[DS, 0x2A], 0x10);
    State.IncCycles();
    // JNC 0x1000:6a07 (1000_6A00 / 0x16A00)
    if(!CarryFlag) {
      goto label_1000_6A07_16A07;
    }
    State.IncCycles();
    // OR word ptr [BP + 0x2],0x4000 (1000_6A02 / 0x16A02)
    // UInt16[SS, (ushort)(BP + 0x2)] |= 0x4000;
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Or16(UInt16[SS, (ushort)(BP + 0x2)], 0x4000);
    State.IncCycles();
    label_1000_6A07_16A07:
    // LEA BX,[BP + -0x2] (1000_6A07 / 0x16A07)
    BX = (ushort)(BP - 0x2);
    State.IncCycles();
    label_1000_6A0A_16A0A:
    // ADD BX,0x4 (1000_6A0A / 0x16A0A)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    State.IncCycles();
    // MOV AX,word ptr [BX] (1000_6A0D / 0x16A0D)
    AX = UInt16[DS, BX];
    State.IncCycles();
    // AND AX,0xfff (1000_6A0F / 0x16A0F)
    // AX &= 0xFFF;
    AX = Alu.And16(AX, 0xFFF);
    State.IncCycles();
    // JZ 0x1000:6a25 (1000_6A12 / 0x16A12)
    if(ZeroFlag) {
      goto label_1000_6A25_16A25;
    }
    State.IncCycles();
    // CMP AX,0x77 (1000_6A14 / 0x16A14)
    Alu.Sub16(AX, 0x77);
    State.IncCycles();
    // JNZ 0x1000:6a0a (1000_6A17 / 0x16A17)
    if(!ZeroFlag) {
      goto label_1000_6A0A_16A0A;
    }
    State.IncCycles();
    // TEST byte ptr [0xa],0x20 (1000_6A19 / 0x16A19)
    Alu.And8(UInt8[DS, 0xA], 0x20);
    State.IncCycles();
    // JNZ 0x1000:6a23 (1000_6A1E / 0x16A1E)
    if(!ZeroFlag) {
      goto label_1000_6A23_16A23;
    }
    State.IncCycles();
    // OR AX,0x4000 (1000_6A20 / 0x16A20)
    // AX |= 0x4000;
    AX = Alu.Or16(AX, 0x4000);
    State.IncCycles();
    label_1000_6A23_16A23:
    // MOV word ptr [BX],AX (1000_6A23 / 0x16A23)
    UInt16[DS, BX] = AX;
    State.IncCycles();
    label_1000_6A25_16A25:
    // MOV BX,0xf66 (1000_6A25 / 0x16A25)
    BX = 0xF66;
    State.IncCycles();
    // JMP 0x1000:d323 (1000_6A28 / 0x16A28)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6A71_016A71(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6A71_16A71:
    // CALL 0x1000:68eb (1000_6A71 / 0x16A71)
    NearCall(cs1, 0x6A74, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6A74_016A74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6A74_016A74(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6A74_16A74:
    // XOR CL,CL (1000_6A74 / 0x16A74)
    CL = 0;
    State.IncCycles();
    // CMP SI,0x8e0 (1000_6A76 / 0x16A76)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JNZ 0x1000:6a89 (1000_6A7A / 0x16A7A)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_6A89_16A89, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // INC CX (1000_6A7C / 0x16A7C)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    // CALL 0x1000:6a89 (1000_6A7D / 0x16A7D)
    NearCall(cs1, 0x6A80, spice86_label_1000_6A89_16A89);
    State.IncCycles();
    // JMP 0x1000:2ebf (1000_6A80 / 0x16A80)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2EBF_012EBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6A83_016A83(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6A83_16A83:
    // MOV CL,0x4 (1000_6A83 / 0x16A83)
    CL = 0x4;
    State.IncCycles();
    // JMP 0x1000:6a89 (1000_6A85 / 0x16A85)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_label_1000_6A89_16A89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_label_1000_6A89_16A89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6A89_16A89:
    // CALL 0x1000:68eb (1000_6A89 / 0x16A89)
    NearCall(cs1, 0x6A8C, spice86_generated_label_call_target_1000_68EB_0168EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6A8C_016A8C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6A8C_016A8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6A8C_16A8C:
    // MOV AL,byte ptr [SI + 0x3] (1000_6A8C / 0x16A8C)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_6A8F / 0x16A8F)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,CL (1000_6A91 / 0x16A91)
    Alu.Sub8(AL, CL);
    State.IncCycles();
    // JZ 0x1000:6ab5 (1000_6A93 / 0x16A93)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // PUSH word ptr [SI + 0x3] (1000_6A95 / 0x16A95)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x3)]);
    State.IncCycles();
    // PUSH SI (1000_6A98 / 0x16A98)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH word ptr [SI + 0x12] (1000_6A99 / 0x16A99)
    Stack.Push(UInt16[DS, (ushort)(SI + 0x12)]);
    State.IncCycles();
    // CALL 0x1000:6acb (1000_6A9C / 0x16A9C)
    NearCall(cs1, 0x6A9F, spice86_generated_label_call_target_1000_6ACB_016ACB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6A9F_016A9F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6A9F_016A9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6A9F_16A9F:
    // CALL 0x1000:a1c4 (1000_6A9F / 0x16A9F)
    NearCall(cs1, 0x6AA2, spice86_generated_label_call_target_1000_A1C4_01A1C4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AA2_016AA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AA2_016AA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AA2_16AA2:
    // MOV AL,0xa (1000_6AA2 / 0x16AA2)
    AL = 0xA;
    State.IncCycles();
    // CALL 0x1000:7bb9 (1000_6AA4 / 0x16AA4)
    NearCall(cs1, 0x6AA7, spice86_generated_label_call_target_1000_7BB9_017BB9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AA7_016AA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AA7_016AA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AA7_16AA7:
    // CALL 0x1000:a1e2 (1000_6AA7 / 0x16AA7)
    NearCall(cs1, 0x6AAA, spice86_generated_label_call_target_1000_A1E2_01A1E2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AAA_016AAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AAA_016AAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AAA_16AAA:
    // POP AX (1000_6AAA / 0x16AAA)
    AX = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_6AAB / 0x16AAB)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_6AAC / 0x16AAC)
    CX = Stack.Pop();
    State.IncCycles();
    // JZ 0x1000:6ab8 (1000_6AAD / 0x16AAD)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_6AB8_016AB8, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV word ptr [SI + 0x12],AX (1000_6AAF / 0x16AAF)
    UInt16[DS, (ushort)(SI + 0x12)] = AX;
    State.IncCycles();
    // CALL 0x1000:6acb (1000_6AB2 / 0x16AB2)
    NearCall(cs1, 0x6AB5, spice86_generated_label_call_target_1000_6ACB_016ACB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6AB5_016AB5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6AB5_016AB5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AB5_16AB5:
    // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_6AB8_016AB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AB8_16AB8:
    // CALL 0x1000:693b (1000_6AB8 / 0x16AB8)
    NearCall(cs1, 0x6ABB, spice86_generated_label_call_target_1000_693B_01693B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6ABB_016ABB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6ABB_016ABB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6ABB_16ABB:
    // OR AL,AL (1000_6ABB / 0x16ABB)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:6ab5 (1000_6ABD / 0x16ABD)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // AND byte ptr [SI + 0x19],0x7f (1000_6ABF / 0x16ABF)
    // UInt8[DS, (ushort)(SI + 0x19)] &= 0x7F;
    UInt8[DS, (ushort)(SI + 0x19)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x7F);
    State.IncCycles();
    // JMP 0x1000:6ab5 (1000_6AC3 / 0x16AC3)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x1000:d2e2 (1000_6AB5 / 0x16AB5)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6AC5_016AC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AC5_16AC5:
    // MOV CL,byte ptr [SI + 0x3] (1000_6AC5 / 0x16AC5)
    CL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND CL,0xfc (1000_6AC8 / 0x16AC8)
    // CL &= 0xFC;
    CL = Alu.And8(CL, 0xFC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6ACB_016ACB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6ACB_016ACB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6ACB_16ACB:
    // MOV AL,byte ptr [SI + 0x3] (1000_6ACB / 0x16ACB)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_6ACE / 0x16ACE)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,CL (1000_6AD0 / 0x16AD0)
    Alu.Sub8(AL, CL);
    State.IncCycles();
    // JZ 0x1000:6b24 (1000_6AD2 / 0x16AD2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6B24 / 0x16B24)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_6AD4_016AD4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6AD4_016AD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6AD4_16AD4:
    // MOV DI,word ptr [SI + 0x4] (1000_6AD4 / 0x16AD4)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP CL,0x8 (1000_6AD7 / 0x16AD7)
    Alu.Sub8(CL, 0x8);
    State.IncCycles();
    // JNZ 0x1000:6aea (1000_6ADA / 0x16ADA)
    if(!ZeroFlag) {
      goto label_1000_6AEA_16AEA;
    }
    State.IncCycles();
    // CMP DI,0x7c8 (1000_6ADC / 0x16ADC)
    Alu.Sub16(DI, 0x7C8);
    State.IncCycles();
    // JNZ 0x1000:6aea (1000_6AE0 / 0x16AE0)
    if(!ZeroFlag) {
      goto label_1000_6AEA_16AEA;
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x1a],0x0 (1000_6AE2 / 0x16AE2)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x1A)], 0x0);
    State.IncCycles();
    // JNZ 0x1000:6aea (1000_6AE6 / 0x16AE6)
    if(!ZeroFlag) {
      goto label_1000_6AEA_16AEA;
    }
    State.IncCycles();
    // MOV CL,0xa (1000_6AE8 / 0x16AE8)
    CL = 0xA;
    State.IncCycles();
    label_1000_6AEA_16AEA:
    // MOV byte ptr [SI + 0x3],CL (1000_6AEA / 0x16AEA)
    UInt8[DS, (ushort)(SI + 0x3)] = CL;
    State.IncCycles();
    // AND byte ptr [SI + 0x12],0xcf (1000_6AED / 0x16AED)
    UInt8[DS, (ushort)(SI + 0x12)] &= 0xCF;
    State.IncCycles();
    // AND word ptr [SI + 0x10],0xfeff (1000_6AF1 / 0x16AF1)
    // UInt16[DS, (ushort)(SI + 0x10)] &= 0xFEFF;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0xFEFF);
    State.IncCycles();
    // CALL 0x1000:6c15 (1000_6AF6 / 0x16AF6)
    NearCall(cs1, 0x6AF9, spice86_generated_label_call_target_1000_6C15_016C15);
    State.IncCycles();
    label_1000_6AF9_16AF9:
    // JC 0x1000:6b00 (1000_6AF9 / 0x16AF9)
    if(CarryFlag) {
      goto label_1000_6B00_16B00;
    }
    State.IncCycles();
    // OR word ptr [SI + 0x10],0x100 (1000_6AFB / 0x16AFB)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x100;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x100);
    State.IncCycles();
    label_1000_6B00_16B00:
    // CALL 0x1000:8461 (1000_6B00 / 0x16B00)
    NearCall(cs1, 0x6B03, spice86_generated_label_call_target_1000_8461_018461);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6B03_016B03, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6B03_016B03(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6B03_16B03:
    // CALL 0x1000:6b25 (1000_6B03 / 0x16B03)
    NearCall(cs1, 0x6B06, spice86_generated_label_call_target_1000_6B25_016B25);
    State.IncCycles();
    label_1000_6B06_16B06:
    // CMP byte ptr [SI + 0x3],0x2 (1000_6B06 / 0x16B06)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x2);
    State.IncCycles();
    // JZ 0x1000:6b19 (1000_6B0A / 0x16B0A)
    if(ZeroFlag) {
      goto label_1000_6B19_16B19;
    }
    State.IncCycles();
    // CALL 0x1000:693b (1000_6B0C / 0x16B0C)
    NearCall(cs1, 0x6B0F, spice86_generated_label_call_target_1000_693B_01693B);
    State.IncCycles();
    label_1000_6B0F_16B0F:
    // MOV CL,AL (1000_6B0F / 0x16B0F)
    CL = AL;
    State.IncCycles();
    // MOV AX,0x2000 (1000_6B11 / 0x16B11)
    AX = 0x2000;
    State.IncCycles();
    // SHL AX,CL (1000_6B14 / 0x16B14)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    State.IncCycles();
    // OR word ptr [SI + 0x12],AX (1000_6B16 / 0x16B16)
    // UInt16[DS, (ushort)(SI + 0x12)] |= AX;
    UInt16[DS, (ushort)(SI + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x12)], AX);
    State.IncCycles();
    label_1000_6B19_16B19:
    // MOV AL,byte ptr [SI] (1000_6B19 / 0x16B19)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CMP AL,byte ptr [0x1954] (1000_6B1B / 0x16B1B)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    State.IncCycles();
    // JNZ 0x1000:6b24 (1000_6B1F / 0x16B1F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6B24 / 0x16B24)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:7847 (1000_6B21 / 0x16B21)
    NearCall(cs1, 0x6B24, spice86_generated_label_call_target_1000_7847_017847);
    State.IncCycles();
    label_1000_6B24_16B24:
    // RET  (1000_6B24 / 0x16B24)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6B25_016B25(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6B25_16B25:
    // MOV AX,[0x2] (1000_6B25 / 0x16B25)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV word ptr [SI + 0xa],AX (1000_6B28 / 0x16B28)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    State.IncCycles();
    // XOR AX,AX (1000_6B2B / 0x16B2B)
    AX = 0;
    State.IncCycles();
    // MOV word ptr [SI + 0xc],AX (1000_6B2D / 0x16B2D)
    UInt16[DS, (ushort)(SI + 0xC)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0xe],AX (1000_6B30 / 0x16B30)
    UInt16[DS, (ushort)(SI + 0xE)] = AX;
    State.IncCycles();
    // RET  (1000_6B33 / 0x16B33)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6B34_016B34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6B34_16B34:
    // INC byte ptr [0x46f6] (1000_6B34 / 0x16B34)
    UInt8[DS, 0x46F6] = Alu.Inc8(UInt8[DS, 0x46F6]);
    State.IncCycles();
    // MOV AL,[0x46f6] (1000_6B38 / 0x16B38)
    AL = UInt8[DS, 0x46F6];
    State.IncCycles();
    // AND AL,0x3 (1000_6B3B / 0x16B3B)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    State.IncCycles();
    // JZ 0x1000:6b4b (1000_6B3D / 0x16B3D)
    if(ZeroFlag) {
      goto label_1000_6B4B_16B4B;
    }
    State.IncCycles();
    // MOV CX,0x1 (1000_6B3F / 0x16B3F)
    CX = 0x1;
    State.IncCycles();
    // MOV DI,word ptr [0x4752] (1000_6B42 / 0x16B42)
    DI = UInt16[DS, 0x4752];
    State.IncCycles();
    // OR DI,DI (1000_6B46 / 0x16B46)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JNZ 0x1000:6b55 (1000_6B48 / 0x16B48)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6B55_016B55, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_6B4A / 0x16B4A)
    return NearRet();
    State.IncCycles();
    label_1000_6B4B_16B4B:
    // MOV SI,0x3cbe (1000_6B4B / 0x16B4B)
    SI = 0x3CBE;
    State.IncCycles();
    // LODSW SI (1000_6B4E / 0x16B4E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_6B4F / 0x16B4F)
    CX = AX;
    State.IncCycles();
    // JCXZ 0x1000:6b89 (1000_6B51 / 0x16B51)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6B89 / 0x16B89)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,SI (1000_6B53 / 0x16B53)
    DI = SI;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6B55_016B55, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6B55_016B55(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x6B89: goto label_1000_6B89_16B89;break; // Target of external jump from 0x16B51
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_6B55_16B55:
    // TEST byte ptr [DI + 0xc],0x1 (1000_6B55 / 0x16B55)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x1);
    State.IncCycles();
    // JZ 0x1000:6b84 (1000_6B59 / 0x16B59)
    if(ZeroFlag) {
      goto label_1000_6B84_16B84;
    }
    State.IncCycles();
    // MOV SI,word ptr [DI + 0xd] (1000_6B5B / 0x16B5B)
    SI = UInt16[DS, (ushort)(DI + 0xD)];
    State.IncCycles();
    // LODSB SI (1000_6B5E / 0x16B5E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_6B5F / 0x16B5F)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:6b6d (1000_6B61 / 0x16B61)
    if(!ZeroFlag) {
      goto label_1000_6B6D_16B6D;
    }
    State.IncCycles();
    // MOV SI,word ptr [DI + 0xf] (1000_6B63 / 0x16B63)
    SI = UInt16[DS, (ushort)(DI + 0xF)];
    State.IncCycles();
    // LODSB SI (1000_6B66 / 0x16B66)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // TEST byte ptr [DI + 0xc],0x2 (1000_6B67 / 0x16B67)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x2);
    State.IncCycles();
    // JNZ 0x1000:6b84 (1000_6B6B / 0x16B6B)
    if(!ZeroFlag) {
      goto label_1000_6B84_16B84;
    }
    State.IncCycles();
    label_1000_6B6D_16B6D:
    // XOR AH,AH (1000_6B6D / 0x16B6D)
    AH = 0;
    State.IncCycles();
    // MOV word ptr [DI + 0x8],AX (1000_6B6F / 0x16B6F)
    UInt16[DS, (ushort)(DI + 0x8)] = AX;
    State.IncCycles();
    // LODSB SI (1000_6B72 / 0x16B72)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CBW  (1000_6B73 / 0x16B73)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV DX,AX (1000_6B74 / 0x16B74)
    DX = AX;
    State.IncCycles();
    // LODSB SI (1000_6B76 / 0x16B76)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CBW  (1000_6B77 / 0x16B77)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // MOV BX,AX (1000_6B78 / 0x16B78)
    BX = AX;
    State.IncCycles();
    // MOV word ptr [DI + 0xd],SI (1000_6B7A / 0x16B7A)
    UInt16[DS, (ushort)(DI + 0xD)] = SI;
    State.IncCycles();
    // PUSH CX (1000_6B7D / 0x16B7D)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_6B7E / 0x16B7E)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:c661 (1000_6B7F / 0x16B7F)
    NearCall(cs1, 0x6B82, spice86_generated_label_call_target_1000_C661_01C661);
    State.IncCycles();
    label_1000_6B82_16B82:
    // POP DI (1000_6B82 / 0x16B82)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_6B83 / 0x16B83)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_6B84_16B84:
    // ADD DI,0x11 (1000_6B84 / 0x16B84)
    // DI += 0x11;
    DI = Alu.Add16(DI, 0x11);
    State.IncCycles();
    // LOOP 0x1000:6b55 (1000_6B87 / 0x16B87)
    if(--CX != 0) {
      goto label_1000_6B55_16B55;
    }
    State.IncCycles();
    label_1000_6B89_16B89:
    // RET  (1000_6B89 / 0x16B89)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6B96_016B96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6B96_16B96:
    // TEST word ptr [SI + 0x10],0x200 (1000_6B96 / 0x16B96)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    State.IncCycles();
    // STC  (1000_6B9B / 0x16B9B)
    CarryFlag = true;
    State.IncCycles();
    // JNZ 0x1000:6bb6 (1000_6B9C / 0x16B9C)
    if(!ZeroFlag) {
      goto label_1000_6BB6_16BB6;
    }
    State.IncCycles();
    // TEST word ptr [SI + 0x12],0x30 (1000_6B9E / 0x16B9E)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x30);
    State.IncCycles();
    // STC  (1000_6BA3 / 0x16BA3)
    CarryFlag = true;
    State.IncCycles();
    // JNZ 0x1000:6bb6 (1000_6BA4 / 0x16BA4)
    if(!ZeroFlag) {
      goto label_1000_6BB6_16BB6;
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x12],0x1 (1000_6BA6 / 0x16BA6)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x12)], 0x1);
    State.IncCycles();
    // JC 0x1000:6bb6 (1000_6BAA / 0x16BAA)
    if(CarryFlag) {
      goto label_1000_6BB6_16BB6;
    }
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0xa] (1000_6BAC / 0x16BAC)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    State.IncCycles();
    // XOR AL,0x40 (1000_6BAF / 0x16BAF)
    AL ^= 0x40;
    State.IncCycles();
    // AND AL,0x41 (1000_6BB1 / 0x16BB1)
    // AL &= 0x41;
    AL = Alu.And8(AL, 0x41);
    State.IncCycles();
    // JZ 0x1000:6bb6 (1000_6BB3 / 0x16BB3)
    if(ZeroFlag) {
      goto label_1000_6BB6_16BB6;
    }
    State.IncCycles();
    // STC  (1000_6BB5 / 0x16BB5)
    CarryFlag = true;
    State.IncCycles();
    label_1000_6BB6_16BB6:
    // PUSHF  (1000_6BB6 / 0x16BB6)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // SBB AH,AH (1000_6BB7 / 0x16BB7)
    AH = Alu.Sbb8(AH, AH);
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_6BB9 / 0x16BB9)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AX,0x1010 (1000_6BBC / 0x16BBC)
    AX &= 0x1010;
    State.IncCycles();
    // CMP AL,AH (1000_6BBF / 0x16BBF)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JZ 0x1000:6bd5 (1000_6BC1 / 0x16BC1)
    if(ZeroFlag) {
      goto label_1000_6BD5_16BD5;
    }
    State.IncCycles();
    // XOR byte ptr [SI + 0x3],0x10 (1000_6BC3 / 0x16BC3)
    // UInt8[DS, (ushort)(SI + 0x3)] ^= 0x10;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Xor8(UInt8[DS, (ushort)(SI + 0x3)], 0x10);
    State.IncCycles();
    // PUSH AX (1000_6BC7 / 0x16BC7)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DI (1000_6BC8 / 0x16BC8)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:8461 (1000_6BC9 / 0x16BC9)
    NearCall(cs1, 0x6BCC, spice86_generated_label_call_target_1000_8461_018461);
    State.IncCycles();
    // POP DI (1000_6BCC / 0x16BCC)
    DI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_6BCD / 0x16BCD)
    AX = Stack.Pop();
    State.IncCycles();
    // TEST AL,0x10 (1000_6BCE / 0x16BCE)
    Alu.And8(AL, 0x10);
    State.IncCycles();
    // JZ 0x1000:6bd5 (1000_6BD0 / 0x16BD0)
    if(ZeroFlag) {
      goto label_1000_6BD5_16BD5;
    }
    State.IncCycles();
    // CALL 0x1000:6b25 (1000_6BD2 / 0x16BD2)
    NearCall(cs1, 0x6BD5, spice86_generated_label_call_target_1000_6B25_016B25);
    State.IncCycles();
    label_1000_6BD5_16BD5:
    // POPF  (1000_6BD5 / 0x16BD5)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6BD6 / 0x16BD6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6C15_016C15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6C15_16C15:
    // MOV DI,word ptr [SI + 0x4] (1000_6C15 / 0x16C15)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV BL,byte ptr [SI + 0x3] (1000_6C18 / 0x16C18)
    BL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND BX,0xf (1000_6C1B / 0x16C1B)
    BX &= 0xF;
    State.IncCycles();
    // SHL BX,1 (1000_6C1E / 0x16C1E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // CLC  (1000_6C20 / 0x16C20)
    CarryFlag = false;
    State.IncCycles();
    // JMP word ptr CS:[BX + 0x6bf5] (1000_6C21 / 0x16C21)
    // Indirect jump to word ptr CS:[BX + 0x6bf5], generating possible targets from emulator records
    uint targetAddress_1000_6C21 = (uint)(UInt16[cs1, (ushort)(BX + 0x6BF5)]);
    switch(targetAddress_1000_6C21) {
      case 0xF66 : {
        // JMP target is RET, inlining.
        State.IncCycles();
        // RET  (1000_0F66 / 0x10F66)
        return NearRet();
      }
      case 0x6B96 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6B96_016B96, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6C21));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6C46_016C46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6C46_16C46:
    // MOV AL,[0x2a] (1000_6C46 / 0x16C46)
    AL = UInt8[DS, 0x2A];
    State.IncCycles();
    // SUB AL,0x2d (1000_6C49 / 0x16C49)
    AL -= 0x2D;
    State.IncCycles();
    // CMP AL,0x3 (1000_6C4B / 0x16C4B)
    Alu.Sub8(AL, 0x3);
    State.IncCycles();
    // JNC 0x1000:6c6e (1000_6C4D / 0x16C4D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    State.IncCycles();
    // TEST word ptr [0x10],0x10 (1000_6C4F / 0x16C4F)
    Alu.And16(UInt16[DS, 0x10], 0x10);
    State.IncCycles();
    // JNZ 0x1000:6c6e (1000_6C55 / 0x16C55)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [0x473c] (1000_6C57 / 0x16C57)
    DI = UInt16[DS, 0x473C];
    State.IncCycles();
    // OR DI,DI (1000_6C5B / 0x16C5B)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    State.IncCycles();
    // JZ 0x1000:6c6e (1000_6C5D / 0x16C5D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:331e (1000_6C5F / 0x16C5F)
    NearCall(cs1, 0x6C62, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    // CMP byte ptr [0x66],0x0 (1000_6C62 / 0x16C62)
    Alu.Sub8(UInt8[DS, 0x66], 0x0);
    State.IncCycles();
    // JZ 0x1000:6c6e (1000_6C67 / 0x16C67)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6C6E / 0x16C6E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,0x30 (1000_6C69 / 0x16C69)
    AL = 0x30;
    State.IncCycles();
    // JMP 0x1000:121f (1000_6C6B / 0x16C6B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_121F_01121F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_6C6E_16C6E:
    // RET  (1000_6C6E / 0x16C6E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6C6F_016C6F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6C6F_16C6F:
    // XOR SI,SI (1000_6C6F / 0x16C6F)
    SI = 0;
    State.IncCycles();
    // MOV AX,[0x101a] (1000_6C71 / 0x16C71)
    AX = UInt16[DS, 0x101A];
    State.IncCycles();
    // CMP AL,0x80 (1000_6C74 / 0x16C74)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JNZ 0x1000:6c83 (1000_6C76 / 0x16C76)
    if(!ZeroFlag) {
      goto label_1000_6C83_16C83;
    }
    State.IncCycles();
    // MOV AL,0x1c (1000_6C78 / 0x16C78)
    AL = 0x1C;
    State.IncCycles();
    // DEC AH (1000_6C7A / 0x16C7A)
    AH--;
    State.IncCycles();
    // MUL AH (1000_6C7C / 0x16C7C)
    Cpu.Mul8(AH);
    State.IncCycles();
    // ADD AX,0x100 (1000_6C7E / 0x16C7E)
    // AX += 0x100;
    AX = Alu.Add16(AX, 0x100);
    State.IncCycles();
    // MOV SI,AX (1000_6C81 / 0x16C81)
    SI = AX;
    State.IncCycles();
    label_1000_6C83_16C83:
    // MOV word ptr [0x473c],SI (1000_6C83 / 0x16C83)
    UInt16[DS, 0x473C] = SI;
    State.IncCycles();
    // CALL 0x1000:6c46 (1000_6C87 / 0x16C87)
    NearCall(cs1, 0x6C8A, spice86_generated_label_call_target_1000_6C46_016C46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6C8A_016C8A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6C8A_016C8A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6C8A_16C8A:
    // MOV byte ptr [0x4737],0x0 (1000_6C8A / 0x16C8A)
    UInt8[DS, 0x4737] = 0x0;
    State.IncCycles();
    // MOV SI,0x8aa (1000_6C8F / 0x16C8F)
    SI = 0x8AA;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_6C92_016C92, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_6C92_016C92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6C92_16C92:
    // TEST word ptr [SI + 0x12],0x430 (1000_6C92 / 0x16C92)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x430);
    State.IncCycles();
    // JNZ 0x1000:6cd3 (1000_6C97 / 0x16C97)
    if(!ZeroFlag) {
      goto label_1000_6CD3_16CD3;
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x1a],0x14 (1000_6C99 / 0x16C99)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x14);
    State.IncCycles();
    // JNC 0x1000:6ca4 (1000_6C9D / 0x16C9D)
    if(!CarryFlag) {
      goto label_1000_6CA4_16CA4;
    }
    State.IncCycles();
    // CALL 0x1000:6d19 (1000_6C9F / 0x16C9F)
    NearCall(cs1, 0x6CA2, spice86_generated_label_call_target_1000_6D19_016D19);
    State.IncCycles();
    label_1000_6CA2_16CA2:
    // JC 0x1000:6cc3 (1000_6CA2 / 0x16CA2)
    if(CarryFlag) {
      goto label_1000_6CC3_16CC3;
    }
    State.IncCycles();
    label_1000_6CA4_16CA4:
    // MOV AL,byte ptr [SI + 0x3] (1000_6CA4 / 0x16CA4)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // TEST AL,0xa0 (1000_6CA7 / 0x16CA7)
    Alu.And8(AL, 0xA0);
    State.IncCycles();
    // JNZ 0x1000:6cc3 (1000_6CA9 / 0x16CA9)
    if(!ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    State.IncCycles();
    // TEST AL,0x40 (1000_6CAB / 0x16CAB)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JNZ 0x1000:6ced (1000_6CAD / 0x16CAD)
    if(!ZeroFlag) {
      goto label_1000_6CED_16CED;
    }
    State.IncCycles();
    // AND AX,0xf (1000_6CAF / 0x16CAF)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // MOV BX,AX (1000_6CB2 / 0x16CB2)
    BX = AX;
    State.IncCycles();
    // SHL BX,1 (1000_6CB4 / 0x16CB4)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // PUSH SI (1000_6CB6 / 0x16CB6)
    Stack.Push(SI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6CB7 / 0x16CB7)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CALL word ptr CS:[BX + 0x6c26] (1000_6CBA / 0x16CBA)
    // Indirect call to word ptr CS:[BX + 0x6c26], generating possible targets from emulator records
    uint targetAddress_1000_6CBA = (uint)(UInt16[cs1, (ushort)(BX + 0x6C26)]);
    switch(targetAddress_1000_6CBA) {
      case 0xF66 : NearCall(cs1, 0x6CBF, spice86_generated_label_call_target_1000_0F66_010F66); break;
      case 0x6FE5 : NearCall(cs1, 0x6CBF, spice86_generated_label_call_target_1000_6FE5_016FE5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_6CBA));
        break;
    }
    State.IncCycles();
    label_1000_6CBF_16CBF:
    // POP SI (1000_6CBF / 0x16CBF)
    SI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:6d7b (1000_6CC0 / 0x16CC0)
    NearCall(cs1, 0x6CC3, spice86_generated_label_call_target_1000_6D7B_016D7B);
    State.IncCycles();
    label_1000_6CC3_16CC3:
    // ADD SI,0x1b (1000_6CC3 / 0x16CC3)
    SI += 0x1B;
    State.IncCycles();
    // CMP SI,0xfbb (1000_6CC6 / 0x16CC6)
    Alu.Sub16(SI, 0xFBB);
    State.IncCycles();
    // JC 0x1000:6c92 (1000_6CCA / 0x16CCA)
    if(CarryFlag) {
      goto label_1000_6C92_16C92;
    }
    State.IncCycles();
    // MOV AL,[0x4737] (1000_6CCC / 0x16CCC)
    AL = UInt8[DS, 0x4737];
    State.IncCycles();
    // MOV [0xfa],AL (1000_6CCF / 0x16CCF)
    UInt8[DS, 0xFA] = AL;
    State.IncCycles();
    // RET  (1000_6CD2 / 0x16CD2)
    return NearRet();
    State.IncCycles();
    label_1000_6CD3_16CD3:
    // TEST byte ptr [SI + 0x3],0x40 (1000_6CD3 / 0x16CD3)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:6ced (1000_6CD7 / 0x16CD7)
    if(!ZeroFlag) {
      goto label_1000_6CED_16CED;
    }
    State.IncCycles();
    // CMP byte ptr [0xfa],0x0 (1000_6CD9 / 0x16CD9)
    Alu.Sub8(UInt8[DS, 0xFA], 0x0);
    State.IncCycles();
    // JZ 0x1000:6cc3 (1000_6CDE / 0x16CDE)
    if(ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    State.IncCycles();
    // AND byte ptr [SI + 0x12],0xcf (1000_6CE0 / 0x16CE0)
    UInt8[DS, (ushort)(SI + 0x12)] &= 0xCF;
    State.IncCycles();
    // TEST word ptr [SI + 0x12],0x400 (1000_6CE4 / 0x16CE4)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x400);
    State.IncCycles();
    // JNZ 0x1000:6cc3 (1000_6CE9 / 0x16CE9)
    if(!ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    State.IncCycles();
    // JMP 0x1000:6c92 (1000_6CEB / 0x16CEB)
    goto label_1000_6C92_16C92;
    State.IncCycles();
    label_1000_6CED_16CED:
    // MOV AL,byte ptr [SI] (1000_6CED / 0x16CED)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CMP AL,byte ptr [0x1954] (1000_6CEF / 0x16CEF)
    Alu.Sub8(AL, UInt8[DS, 0x1954]);
    State.IncCycles();
    // JZ 0x1000:6cc3 (1000_6CF3 / 0x16CF3)
    if(ZeroFlag) {
      goto label_1000_6CC3_16CC3;
    }
    State.IncCycles();
    // PUSH SI (1000_6CF5 / 0x16CF5)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:8308 (1000_6CF6 / 0x16CF6)
    NearCall(cs1, 0x6CF9, not_observed_1000_8308_018308);
    State.IncCycles();
    // POP SI (1000_6CF9 / 0x16CF9)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:6cc3 (1000_6CFA / 0x16CFA)
    goto label_1000_6CC3_16CC3;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6CFC_016CFC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6CFC_16CFC:
    // CMP byte ptr [DI + 0x8],0x20 (1000_6CFC / 0x16CFC)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x20);
    State.IncCycles();
    // JNC 0x1000:6d18 (1000_6D00 / 0x16D00)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D18 / 0x16D18)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0xb],0xc (1000_6D02 / 0x16D02)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0xB)], 0xC);
    State.IncCycles();
    // JNC 0x1000:6d18 (1000_6D06 / 0x16D06)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D18 / 0x16D18)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x1 (1000_6D08 / 0x16D08)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x1);
    State.IncCycles();
    // JNZ 0x1000:6d18 (1000_6D0C / 0x16D0C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D18 / 0x16D18)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [DI + 0xb] (1000_6D0E / 0x16D0E)
    UInt8[DS, (ushort)(DI + 0xB)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0xB)]);
    State.IncCycles();
    // PUSH SI (1000_6D11 / 0x16D11)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_6D12 / 0x16D12)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:644e (1000_6D13 / 0x16D13)
    NearCall(cs1, 0x6D16, spice86_generated_label_call_target_1000_644E_01644E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6D16_016D16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6D16_016D16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6D16_16D16:
    // POP DI (1000_6D16 / 0x16D16)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_6D17 / 0x16D17)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_6D18_16D18:
    // RET  (1000_6D18 / 0x16D18)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6D19_016D19(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6D19_16D19:
    // TEST byte ptr [SI + 0x3],0xe3 (1000_6D19 / 0x16D19)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xE3);
    State.IncCycles();
    // JNZ 0x1000:6d5e (1000_6D1D / 0x16D1D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_6D1F / 0x16D1F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:6d5e (1000_6D23 / 0x16D23)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    State.IncCycles();
    // CMP SI,0x8e0 (1000_6D25 / 0x16D25)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JZ 0x1000:6d5e (1000_6D29 / 0x16D29)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6D2B / 0x16D2B)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // XOR BX,BX (1000_6D2E / 0x16D2E)
    BX = 0;
    State.IncCycles();
    // MOV CL,byte ptr [SI + 0x1a] (1000_6D30 / 0x16D30)
    CL = UInt8[DS, (ushort)(SI + 0x1A)];
    State.IncCycles();
    // NOT CL (1000_6D33 / 0x16D33)
    CL = (byte)~CL;
    State.IncCycles();
    // MOV DX,SI (1000_6D35 / 0x16D35)
    DX = SI;
    State.IncCycles();
    // MOV BP,0x6d5f (1000_6D37 / 0x16D37)
    BP = 0x6D5F;
    State.IncCycles();
    // CALL 0x1000:661d (1000_6D3A / 0x16D3A)
    NearCall(cs1, 0x6D3D, spice86_generated_label_call_target_1000_661D_01661D);
    State.IncCycles();
    // OR BX,BX (1000_6D3D / 0x16D3D)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:6d5e (1000_6D3F / 0x16D3F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6D5E / 0x16D5E)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1a] (1000_6D41 / 0x16D41)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    State.IncCycles();
    // ADD byte ptr [BX + 0x1a],AL (1000_6D44 / 0x16D44)
    // UInt8[DS, (ushort)(BX + 0x1A)] += AL;
    UInt8[DS, (ushort)(BX + 0x1A)] = Alu.Add8(UInt8[DS, (ushort)(BX + 0x1A)], AL);
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x19] (1000_6D47 / 0x16D47)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // MOV AH,AL (1000_6D4A / 0x16D4A)
    AH = AL;
    State.IncCycles();
    // AND AL,byte ptr [BX + 0x19] (1000_6D4C / 0x16D4C)
    // AL &= UInt8[DS, (ushort)(BX + 0x19)];
    AL = Alu.And8(AL, UInt8[DS, (ushort)(BX + 0x19)]);
    State.IncCycles();
    // MOV byte ptr [SI + 0x19],AL (1000_6D4F / 0x16D4F)
    UInt8[DS, (ushort)(SI + 0x19)] = AL;
    State.IncCycles();
    // OR byte ptr [BX + 0x19],AH (1000_6D52 / 0x16D52)
    // UInt8[DS, (ushort)(BX + 0x19)] |= AH;
    UInt8[DS, (ushort)(BX + 0x19)] = Alu.Or8(UInt8[DS, (ushort)(BX + 0x19)], AH);
    State.IncCycles();
    // OR word ptr [BX + 0x12],0x200 (1000_6D55 / 0x16D55)
    // UInt16[DS, (ushort)(BX + 0x12)] |= 0x200;
    UInt16[DS, (ushort)(BX + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(BX + 0x12)], 0x200);
    State.IncCycles();
    // CALL 0x1000:66b1 (1000_6D5A / 0x16D5A)
    NearCall(cs1, 0x6D5D, not_observed_1000_66B1_0166B1);
    State.IncCycles();
    // STC  (1000_6D5D / 0x16D5D)
    CarryFlag = true;
    State.IncCycles();
    label_1000_6D5E_16D5E:
    // RET  (1000_6D5E / 0x16D5E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6D7B_016D7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6D7B_16D7B:
    // TEST word ptr [0x2],0x3f (1000_6D7B / 0x16D7B)
    Alu.And16(UInt16[DS, 0x2], 0x3F);
    State.IncCycles();
    // JZ 0x1000:6d84 (1000_6D81 / 0x16D81)
    if(ZeroFlag) {
      goto label_1000_6D84_16D84;
    }
    State.IncCycles();
    // RET  (1000_6D83 / 0x16D83)
    return NearRet();
    State.IncCycles();
    label_1000_6D84_16D84:
    // CALL 0x1000:693b (1000_6D84 / 0x16D84)
    NearCall(cs1, 0x6D87, spice86_generated_label_call_target_1000_693B_01693B);
    State.IncCycles();
    // MOV CL,AL (1000_6D87 / 0x16D87)
    CL = AL;
    State.IncCycles();
    // MOV AX,0xc000 (1000_6D89 / 0x16D89)
    AX = 0xC000;
    State.IncCycles();
    // ROL AX,CL (1000_6D8C / 0x16D8C)
    AX = Alu.Rol16(AX, CL);
    State.IncCycles();
    // AND AX,word ptr [SI + 0x12] (1000_6D8E / 0x16D8E)
    // AX &= UInt16[DS, (ushort)(SI + 0x12)];
    AX = Alu.And16(AX, UInt16[DS, (ushort)(SI + 0x12)]);
    State.IncCycles();
    // JZ 0x1000:6dba (1000_6D91 / 0x16D91)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6DBA / 0x16DBA)
      return NearRet();
    }
    State.IncCycles();
    // SHL AX,1 (1000_6D93 / 0x16D93)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JNC 0x1000:6da0 (1000_6D95 / 0x16D95)
    if(!CarryFlag) {
      goto label_1000_6DA0_16DA0;
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x18],0x0 (1000_6D97 / 0x16D97)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x18)], 0x0);
    State.IncCycles();
    // JZ 0x1000:6da0 (1000_6D9B / 0x16D9B)
    if(ZeroFlag) {
      goto label_1000_6DA0_16DA0;
    }
    State.IncCycles();
    // DEC byte ptr [SI + 0x18] (1000_6D9D / 0x16D9D)
    UInt8[DS, (ushort)(SI + 0x18)]--;
    State.IncCycles();
    label_1000_6DA0_16DA0:
    // SHL AX,1 (1000_6DA0 / 0x16DA0)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JNC 0x1000:6dad (1000_6DA2 / 0x16DA2)
    if(!CarryFlag) {
      goto label_1000_6DAD_16DAD;
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x17],0x0 (1000_6DA4 / 0x16DA4)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x17)], 0x0);
    State.IncCycles();
    // JZ 0x1000:6dad (1000_6DA8 / 0x16DA8)
    if(ZeroFlag) {
      goto label_1000_6DAD_16DAD;
    }
    State.IncCycles();
    // DEC byte ptr [SI + 0x17] (1000_6DAA / 0x16DAA)
    UInt8[DS, (ushort)(SI + 0x17)]--;
    State.IncCycles();
    label_1000_6DAD_16DAD:
    // SHL AX,1 (1000_6DAD / 0x16DAD)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JNC 0x1000:6dba (1000_6DAF / 0x16DAF)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6DBA / 0x16DBA)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x16],0x0 (1000_6DB1 / 0x16DB1)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x16)], 0x0);
    State.IncCycles();
    // JZ 0x1000:6dba (1000_6DB5 / 0x16DB5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6DBA / 0x16DBA)
      return NearRet();
    }
    State.IncCycles();
    // DEC byte ptr [SI + 0x16] (1000_6DB7 / 0x16DB7)
    UInt8[DS, (ushort)(SI + 0x16)] = Alu.Dec8(UInt8[DS, (ushort)(SI + 0x16)]);
    State.IncCycles();
    label_1000_6DBA_16DBA:
    // RET  (1000_6DBA / 0x16DBA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6DBB_016DBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6DBB_16DBB:
    // PUSH SI (1000_6DBB / 0x16DBB)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:40ae (1000_6DBC / 0x16DBC)
    NearCall(cs1, 0x6DBF, spice86_generated_label_call_target_1000_40AE_0140AE);
    State.IncCycles();
    // MOV SI,0xfd8 (1000_6DBF / 0x16DBF)
    SI = 0xFD8;
    State.IncCycles();
    // MOV CX,0xc (1000_6DC2 / 0x16DC2)
    CX = 0xC;
    State.IncCycles();
    label_1000_6DC5_16DC5:
    // CMP BX,word ptr [SI + 0x2] (1000_6DC5 / 0x16DC5)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:6dd6 (1000_6DC8 / 0x16DC8)
    if(!ZeroFlag) {
      goto label_1000_6DD6_16DD6;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_6DCA / 0x16DCA)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // MOV AH,DH (1000_6DCC / 0x16DCC)
    AH = DH;
    State.IncCycles();
    // CMP AL,0x1 (1000_6DCE / 0x16DCE)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:6dd4 (1000_6DD0 / 0x16DD0)
    if(ZeroFlag) {
      goto label_1000_6DD4_16DD4;
    }
    State.IncCycles();
    // MOV AL,0x2 (1000_6DD2 / 0x16DD2)
    AL = 0x2;
    State.IncCycles();
    label_1000_6DD4_16DD4:
    // MOV word ptr [SI],AX (1000_6DD4 / 0x16DD4)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    label_1000_6DD6_16DD6:
    // ADD SI,0x10 (1000_6DD6 / 0x16DD6)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    State.IncCycles();
    // LOOP 0x1000:6dc5 (1000_6DD9 / 0x16DD9)
    if(--CX != 0) {
      goto label_1000_6DC5_16DC5;
    }
    State.IncCycles();
    // CMP BX,word ptr [0x6] (1000_6DDB / 0x16DDB)
    Alu.Sub16(BX, UInt16[DS, 0x6]);
    State.IncCycles();
    // JNZ 0x1000:6dfb (1000_6DDF / 0x16DDF)
    if(!ZeroFlag) {
      goto label_1000_6DFB_16DFB;
    }
    State.IncCycles();
    // OR byte ptr [0x473b],0x80 (1000_6DE1 / 0x16DE1)
    // UInt8[DS, 0x473B] |= 0x80;
    UInt8[DS, 0x473B] = Alu.Or8(UInt8[DS, 0x473B], 0x80);
    State.IncCycles();
    // MOV AX,[0x4] (1000_6DE6 / 0x16DE6)
    AX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV AH,DH (1000_6DE9 / 0x16DE9)
    AH = DH;
    State.IncCycles();
    // CMP AL,0x1 (1000_6DEB / 0x16DEB)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:6df1 (1000_6DED / 0x16DED)
    if(ZeroFlag) {
      goto label_1000_6DF1_16DF1;
    }
    State.IncCycles();
    // MOV AL,0x2 (1000_6DEF / 0x16DEF)
    AL = 0x2;
    State.IncCycles();
    label_1000_6DF1_16DF1:
    // MOV [0x4],AX (1000_6DF1 / 0x16DF1)
    UInt16[DS, 0x4] = AX;
    State.IncCycles();
    // MOV [0xb],AL (1000_6DF4 / 0x16DF4)
    UInt8[DS, 0xB] = AL;
    State.IncCycles();
    // MOV byte ptr [0x8],AH (1000_6DF7 / 0x16DF7)
    UInt8[DS, 0x8] = AH;
    State.IncCycles();
    label_1000_6DFB_16DFB:
    // POP SI (1000_6DFB / 0x16DFB)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV BP,0x6e0f (1000_6DFC / 0x16DFC)
    BP = 0x6E0F;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_6DFF / 0x16DFF)
    NearCall(cs1, 0x6E02, spice86_generated_label_call_target_1000_6603_016603);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_6E02_016E02, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_6E02_016E02(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6E02_16E02:
    // XOR CX,CX (1000_6E02 / 0x16E02)
    CX = 0;
    State.IncCycles();
    // MOV BP,0x764d (1000_6E04 / 0x16E04)
    BP = 0x764D;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_6E07 / 0x16E07)
    NearCall(cs1, 0x6E0A, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // OR CX,CX (1000_6E0A / 0x16E0A)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JNZ 0x1000:6e02 (1000_6E0C / 0x16E0C)
    if(!ZeroFlag) {
      goto label_1000_6E02_16E02;
    }
    State.IncCycles();
    // RET  (1000_6E0E / 0x16E0E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6E20_016E20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6E20_16E20:
    // CMP byte ptr [0x46de],0x0 (1000_6E20 / 0x16E20)
    Alu.Sub8(UInt8[DS, 0x46DE], 0x0);
    State.IncCycles();
    // JNZ 0x1000:6e28 (1000_6E25 / 0x16E25)
    if(!ZeroFlag) {
      goto label_1000_6E28_16E28;
    }
    State.IncCycles();
    // RET  (1000_6E27 / 0x16E27)
    return NearRet();
    State.IncCycles();
    label_1000_6E28_16E28:
    // TEST byte ptr [DI + 0xa],0x8 (1000_6E28 / 0x16E28)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    State.IncCycles();
    // JZ 0x1000:6e4b (1000_6E2C / 0x16E2C)
    if(ZeroFlag) {
      goto label_1000_6E4B_16E4B;
    }
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_6E2E / 0x16E2E)
    NearCall(cs1, 0x6E31, spice86_generated_label_call_target_1000_1AC5_011AC5);
    State.IncCycles();
    // SUB AL,byte ptr [DI + 0xb] (1000_6E31 / 0x16E31)
    AL -= UInt8[DS, (ushort)(DI + 0xB)];
    State.IncCycles();
    // CMP AL,0xfe (1000_6E34 / 0x16E34)
    Alu.Sub8(AL, 0xFE);
    State.IncCycles();
    // JNC 0x1000:6e81 (1000_6E36 / 0x16E36)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6E81 / 0x16E81)
      return NearRet();
    }
    State.IncCycles();
    // AND byte ptr [DI + 0xa],0xf7 (1000_6E38 / 0x16E38)
    UInt8[DS, (ushort)(DI + 0xA)] &= 0xF7;
    State.IncCycles();
    // AND byte ptr [DI + 0x8],0x7 (1000_6E3C / 0x16E3C)
    UInt8[DS, (ushort)(DI + 0x8)] &= 0x7;
    State.IncCycles();
    // INC byte ptr [0x27] (1000_6E40 / 0x16E40)
    UInt8[DS, 0x27] = Alu.Inc8(UInt8[DS, 0x27]);
    State.IncCycles();
    // CALL 0x1000:6dbb (1000_6E44 / 0x16E44)
    NearCall(cs1, 0x6E47, not_observed_1000_6DBB_016DBB);
    State.IncCycles();
    // MOV byte ptr [DI + 0xb],0x5 (1000_6E47 / 0x16E47)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x5;
    State.IncCycles();
    label_1000_6E4B_16E4B:
    // CALL 0x1000:6cfc (1000_6E4B / 0x16E4B)
    NearCall(cs1, 0x6E4E, spice86_generated_label_call_target_1000_6CFC_016CFC);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6E4E_016E4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6E4E_016E4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6E4E_16E4E:
    // CALL 0x1000:1ac5 (1000_6E4E / 0x16E4E)
    NearCall(cs1, 0x6E51, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6E51_016E51, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6E51_016E51(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6E51_16E51:
    // SUB AL,byte ptr [SI + 0x14] (1000_6E51 / 0x16E51)
    AL -= UInt8[DS, (ushort)(SI + 0x14)];
    State.IncCycles();
    // CMP AL,0x8 (1000_6E54 / 0x16E54)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JBE 0x1000:6e5d (1000_6E56 / 0x16E56)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6E5D_16E5D;
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_6E58 / 0x16E58)
    AL = 0x1;
    State.IncCycles();
    // CALL 0x1000:6f93 (1000_6E5A / 0x16E5A)
    NearCall(cs1, 0x6E5D, not_observed_1000_6F93_016F93);
    State.IncCycles();
    label_1000_6E5D_16E5D:
    // MOV AL,byte ptr [SI] (1000_6E5D / 0x16E5D)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // CMP AL,byte ptr [DI + 0x9] (1000_6E5F / 0x16E5F)
    Alu.Sub8(AL, UInt8[DS, (ushort)(DI + 0x9)]);
    State.IncCycles();
    // JNZ 0x1000:6e81 (1000_6E62 / 0x16E62)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6E81 / 0x16E81)
      return NearRet();
    }
    State.IncCycles();
    // XOR DX,DX (1000_6E64 / 0x16E64)
    DX = 0;
    State.IncCycles();
    // MOV BP,0x6e82 (1000_6E66 / 0x16E66)
    BP = 0x6E82;
    State.IncCycles();
    // CALL 0x1000:661d (1000_6E69 / 0x16E69)
    NearCall(cs1, 0x6E6C, spice86_generated_label_call_target_1000_661D_01661D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6E6C_016E6C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6E6C_016E6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6E6C_16E6C:
    // CMP DL,0x3 (1000_6E6C / 0x16E6C)
    Alu.Sub8(DL, 0x3);
    State.IncCycles();
    // JNZ 0x1000:6e81 (1000_6E6F / 0x16E6F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6E81 / 0x16E81)
      return NearRet();
    }
    State.IncCycles();
    // MOV BP,0x6ea8 (1000_6E71 / 0x16E71)
    BP = 0x6EA8;
    State.IncCycles();
    // CALL 0x1000:661d (1000_6E74 / 0x16E74)
    NearCall(cs1, 0x6E77, spice86_generated_label_call_target_1000_661D_01661D);
    State.IncCycles();
    // MOV AX,0x302 (1000_6E77 / 0x16E77)
    AX = 0x302;
    State.IncCycles();
    // PUSH SI (1000_6E7A / 0x16E7A)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_6E7B / 0x16E7B)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:29f0 (1000_6E7C / 0x16E7C)
    NearCall(cs1, 0x6E7F, not_observed_1000_29F0_0129F0);
    State.IncCycles();
    // POP DI (1000_6E7F / 0x16E7F)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_6E80 / 0x16E80)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_6E81_16E81:
    // RET  (1000_6E81 / 0x16E81)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6E82_016E82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6E82_16E82:
    // CMP DI,word ptr [0x114e] (1000_6E82 / 0x16E82)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JZ 0x1000:6ea7 (1000_6E86 / 0x16E86)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x21 (1000_6E88 / 0x16E88)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x21);
    State.IncCycles();
    // JNC 0x1000:6ea7 (1000_6E8C / 0x16E8C)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x15],0x28 (1000_6E8E / 0x16E8E)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], 0x28);
    State.IncCycles();
    // JNC 0x1000:6ea7 (1000_6E92 / 0x16E92)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_6E94 / 0x16E94)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0x2f (1000_6E97 / 0x16E97)
    // AL &= 0x2F;
    AL = Alu.And8(AL, 0x2F);
    State.IncCycles();
    // JNZ 0x1000:6ea7 (1000_6E99 / 0x16E99)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6EA7 / 0x16EA7)
      return NearRet();
    }
    State.IncCycles();
    // MOV DH,0x1 (1000_6E9B / 0x16E9B)
    DH = 0x1;
    State.IncCycles();
    // TEST byte ptr [SI + 0x12],0x80 (1000_6E9D / 0x16E9D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x12)], 0x80);
    State.IncCycles();
    // JZ 0x1000:6ea5 (1000_6EA1 / 0x16EA1)
    if(ZeroFlag) {
      goto label_1000_6EA5_16EA5;
    }
    State.IncCycles();
    // SHL DH,1 (1000_6EA3 / 0x16EA3)
    // DH <<= 0x1;
    DH = Alu.Shl8(DH, 0x1);
    State.IncCycles();
    label_1000_6EA5_16EA5:
    // OR DL,DH (1000_6EA5 / 0x16EA5)
    // DL |= DH;
    DL = Alu.Or8(DL, DH);
    State.IncCycles();
    label_1000_6EA7_16EA7:
    // RET  (1000_6EA7 / 0x16EA7)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6EBF_016EBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6EBF_16EBF:
    // PUSH DI (1000_6EBF / 0x16EBF)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6EC0 / 0x16EC0)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV BP,0x6ecb (1000_6EC3 / 0x16EC3)
    BP = 0x6ECB;
    State.IncCycles();
    // CALL 0x1000:661d (1000_6EC6 / 0x16EC6)
    NearCall(cs1, 0x6EC9, spice86_generated_label_call_target_1000_661D_01661D);
    State.IncCycles();
    // POP DI (1000_6EC9 / 0x16EC9)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6ECA / 0x16ECA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6EDD_016EDD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6EDD_16EDD:
    // MOV DL,byte ptr [BX + SI + 0x16] (1000_6EDD / 0x16EDD)
    DL = UInt8[DS, (ushort)(BX + SI + 0x16)];
    State.IncCycles();
    // ADD AL,DL (1000_6EE0 / 0x16EE0)
    AL += DL;
    State.IncCycles();
    // CMP AL,0x5f (1000_6EE2 / 0x16EE2)
    Alu.Sub8(AL, 0x5F);
    State.IncCycles();
    // JBE 0x1000:6ee8 (1000_6EE4 / 0x16EE4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6EE8_16EE8;
    }
    State.IncCycles();
    // MOV AL,0x5f (1000_6EE6 / 0x16EE6)
    AL = 0x5F;
    State.IncCycles();
    label_1000_6EE8_16EE8:
    // MOV byte ptr [BX + SI + 0x16],AL (1000_6EE8 / 0x16EE8)
    UInt8[DS, (ushort)(BX + SI + 0x16)] = AL;
    State.IncCycles();
    // XOR AL,DL (1000_6EEB / 0x16EEB)
    AL ^= DL;
    State.IncCycles();
    // AND AL,0xf0 (1000_6EED / 0x16EED)
    // AL &= 0xF0;
    AL = Alu.And8(AL, 0xF0);
    State.IncCycles();
    // JZ 0x1000:6efc (1000_6EEF / 0x16EEF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6EFC / 0x16EFC)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x10] (1000_6EF1 / 0x16EF1)
    AX = UInt16[DS, (ushort)(SI + 0x10)];
    State.IncCycles();
    // AND AL,0xfc (1000_6EF4 / 0x16EF4)
    AL &= 0xFC;
    State.IncCycles();
    // INC BX (1000_6EF6 / 0x16EF6)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // OR AL,BL (1000_6EF7 / 0x16EF7)
    // AL |= BL;
    AL = Alu.Or8(AL, BL);
    State.IncCycles();
    // MOV word ptr [SI + 0x10],AX (1000_6EF9 / 0x16EF9)
    UInt16[DS, (ushort)(SI + 0x10)] = AX;
    State.IncCycles();
    label_1000_6EFC_16EFC:
    // RET  (1000_6EFC / 0x16EFC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6EFD_016EFD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6EFD_16EFD:
    // MOV AH,byte ptr [SI + 0x3] (1000_6EFD / 0x16EFD)
    AH = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AH,0xf (1000_6F00 / 0x16F00)
    // AH &= 0xF;
    AH = Alu.And8(AH, 0xF);
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x15] (1000_6F03 / 0x16F03)
    AL = UInt8[DS, (ushort)(SI + 0x15)];
    State.IncCycles();
    // CMP byte ptr [0xfa],0x0 (1000_6F06 / 0x16F06)
    Alu.Sub8(UInt8[DS, 0xFA], 0x0);
    State.IncCycles();
    // JZ 0x1000:6f0f (1000_6F0B / 0x16F0B)
    if(ZeroFlag) {
      goto label_1000_6F0F_16F0F;
    }
    State.IncCycles();
    // ADD AL,0x14 (1000_6F0D / 0x16F0D)
    AL += 0x14;
    State.IncCycles();
    label_1000_6F0F_16F0F:
    // CMP AH,0x6 (1000_6F0F / 0x16F0F)
    Alu.Sub8(AH, 0x6);
    State.IncCycles();
    // JNZ 0x1000:6f23 (1000_6F12 / 0x16F12)
    if(!ZeroFlag) {
      goto label_1000_6F23_16F23;
    }
    State.IncCycles();
    // PUSH DI (1000_6F14 / 0x16F14)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_6F15 / 0x16F15)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // CMP DI,word ptr [0x114e] (1000_6F18 / 0x16F18)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // POP DI (1000_6F1C / 0x16F1C)
    DI = Stack.Pop();
    State.IncCycles();
    // JNZ 0x1000:6f31 (1000_6F1D / 0x16F1D)
    if(!ZeroFlag) {
      goto label_1000_6F31_16F31;
    }
    State.IncCycles();
    // ADD AL,0x1e (1000_6F1F / 0x16F1F)
    // AL += 0x1E;
    AL = Alu.Add8(AL, 0x1E);
    State.IncCycles();
    // JMP 0x1000:6f2b (1000_6F21 / 0x16F21)
    goto label_1000_6F2B_16F2B;
    State.IncCycles();
    label_1000_6F23_16F23:
    // AND AH,0xfe (1000_6F23 / 0x16F23)
    AH &= 0xFE;
    State.IncCycles();
    // CMP AH,0x8 (1000_6F26 / 0x16F26)
    Alu.Sub8(AH, 0x8);
    State.IncCycles();
    // JZ 0x1000:6f2f (1000_6F29 / 0x16F29)
    if(ZeroFlag) {
      goto label_1000_6F2F_16F2F;
    }
    State.IncCycles();
    label_1000_6F2B_16F2B:
    // CMP AL,0x64 (1000_6F2B / 0x16F2B)
    Alu.Sub8(AL, 0x64);
    State.IncCycles();
    // JC 0x1000:6f31 (1000_6F2D / 0x16F2D)
    if(CarryFlag) {
      goto label_1000_6F31_16F31;
    }
    State.IncCycles();
    label_1000_6F2F_16F2F:
    // MOV AL,0x64 (1000_6F2F / 0x16F2F)
    AL = 0x64;
    State.IncCycles();
    label_1000_6F31_16F31:
    // CMP byte ptr [0x2a],0x64 (1000_6F31 / 0x16F31)
    Alu.Sub8(UInt8[DS, 0x2A], 0x64);
    State.IncCycles();
    // JC 0x1000:6f47 (1000_6F36 / 0x16F36)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x2a],0x68 (1000_6F38 / 0x16F38)
    Alu.Sub8(UInt8[DS, 0x2A], 0x68);
    State.IncCycles();
    // JNC 0x1000:6f47 (1000_6F3D / 0x16F3D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    State.IncCycles();
    // SUB AL,0x28 (1000_6F3F / 0x16F3F)
    AL -= 0x28;
    State.IncCycles();
    // CMP AL,0xa (1000_6F41 / 0x16F41)
    Alu.Sub8(AL, 0xA);
    State.IncCycles();
    // JGE 0x1000:6f47 (1000_6F43 / 0x16F43)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6F47 / 0x16F47)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,0xa (1000_6F45 / 0x16F45)
    AL = 0xA;
    State.IncCycles();
    label_1000_6F47_16F47:
    // RET  (1000_6F47 / 0x16F47)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6F56_016F56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6F56_16F56:
    // PUSH SI (1000_6F56 / 0x16F56)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x8aa (1000_6F57 / 0x16F57)
    SI = 0x8AA;
    State.IncCycles();
    label_1000_6F5A_16F5A:
    // TEST byte ptr [SI + 0x3],0xa0 (1000_6F5A / 0x16F5A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xA0);
    State.IncCycles();
    // JNZ 0x1000:6f6d (1000_6F5E / 0x16F5E)
    if(!ZeroFlag) {
      goto label_1000_6F6D_16F6D;
    }
    State.IncCycles();
    // ADD byte ptr [SI + 0x15],AL (1000_6F60 / 0x16F60)
    UInt8[DS, (ushort)(SI + 0x15)] += AL;
    State.IncCycles();
    // CMP byte ptr [SI + 0x15],0x64 (1000_6F63 / 0x16F63)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], 0x64);
    State.IncCycles();
    // JBE 0x1000:6f6d (1000_6F67 / 0x16F67)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6F6D_16F6D;
    }
    State.IncCycles();
    // MOV byte ptr [SI + 0x15],0x64 (1000_6F69 / 0x16F69)
    UInt8[DS, (ushort)(SI + 0x15)] = 0x64;
    State.IncCycles();
    label_1000_6F6D_16F6D:
    // ADD SI,0x1b (1000_6F6D / 0x16F6D)
    SI += 0x1B;
    State.IncCycles();
    // CMP SI,0xfbb (1000_6F70 / 0x16F70)
    Alu.Sub16(SI, 0xFBB);
    State.IncCycles();
    // JC 0x1000:6f5a (1000_6F74 / 0x16F74)
    if(CarryFlag) {
      goto label_1000_6F5A_16F5A;
    }
    State.IncCycles();
    // POP SI (1000_6F76 / 0x16F76)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6F77 / 0x16F77)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6F78_016F78(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6F78_16F78:
    // MOV AH,byte ptr [0x29] (1000_6F78 / 0x16F78)
    AH = UInt8[DS, 0x29];
    State.IncCycles();
    // ADD AL,AH (1000_6F7C / 0x16F7C)
    AL += AH;
    State.IncCycles();
    // CMP AL,0xc8 (1000_6F7E / 0x16F7E)
    Alu.Sub8(AL, 0xC8);
    State.IncCycles();
    // JBE 0x1000:6f84 (1000_6F80 / 0x16F80)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_6F84_16F84;
    }
    State.IncCycles();
    // MOV AL,0xc8 (1000_6F82 / 0x16F82)
    AL = 0xC8;
    State.IncCycles();
    label_1000_6F84_16F84:
    // MOV [0x29],AL (1000_6F84 / 0x16F84)
    UInt8[DS, 0x29] = AL;
    State.IncCycles();
    // AND AX,0xfcfc (1000_6F87 / 0x16F87)
    AX &= 0xFCFC;
    State.IncCycles();
    // SUB AL,AH (1000_6F8A / 0x16F8A)
    AL -= AH;
    State.IncCycles();
    // SHR AL,1 (1000_6F8C / 0x16F8C)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_6F8E / 0x16F8E)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:6f56 (1000_6F90 / 0x16F90)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_6F56_016F56, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_6F92 / 0x16F92)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6F93_016F93(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6F93_16F93:
    // SUB byte ptr [SI + 0x15],AL (1000_6F93 / 0x16F93)
    // UInt8[DS, (ushort)(SI + 0x15)] -= AL;
    UInt8[DS, (ushort)(SI + 0x15)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], AL);
    State.IncCycles();
    // JNC 0x1000:6f9c (1000_6F96 / 0x16F96)
    if(!CarryFlag) {
      goto label_1000_6F9C_16F9C;
    }
    State.IncCycles();
    // MOV byte ptr [SI + 0x15],0x0 (1000_6F98 / 0x16F98)
    UInt8[DS, (ushort)(SI + 0x15)] = 0x0;
    State.IncCycles();
    label_1000_6F9C_16F9C:
    // CMP byte ptr [SI + 0x15],0x5 (1000_6F9C / 0x16F9C)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x15)], 0x5);
    State.IncCycles();
    // JNC 0x1000:6faf (1000_6FA0 / 0x16FA0)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_6FAF / 0x16FAF)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [SI + 0x15],0x4 (1000_6FA2 / 0x16FA2)
    UInt8[DS, (ushort)(SI + 0x15)] = 0x4;
    State.IncCycles();
    // PUSH AX (1000_6FA6 / 0x16FA6)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:7085 (1000_6FA7 / 0x16FA7)
    NearCall(cs1, 0x6FAA, not_observed_1000_7085_017085);
    State.IncCycles();
    // OR word ptr [SI + 0x12],0x20 (1000_6FAA / 0x16FAA)
    // UInt16[DS, (ushort)(SI + 0x12)] |= 0x20;
    UInt16[DS, (ushort)(SI + 0x12)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x12)], 0x20);
    State.IncCycles();
    // POP AX (1000_6FAE / 0x16FAE)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_6FAF_16FAF:
    // RET  (1000_6FAF / 0x16FAF)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_6FB0_016FB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6FB0_16FB0:
    // MOV AH,AL (1000_6FB0 / 0x16FB0)
    AH = AL;
    State.IncCycles();
    // MOV AL,[0x29] (1000_6FB2 / 0x16FB2)
    AL = UInt8[DS, 0x29];
    State.IncCycles();
    // SUB AL,AH (1000_6FB5 / 0x16FB5)
    // AL -= AH;
    AL = Alu.Sub8(AL, AH);
    State.IncCycles();
    // JA 0x1000:6fbb (1000_6FB7 / 0x16FB7)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_6FBB_16FBB;
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_6FB9 / 0x16FB9)
    AL = 0x1;
    State.IncCycles();
    label_1000_6FBB_16FBB:
    // MOV AH,AL (1000_6FBB / 0x16FBB)
    AH = AL;
    State.IncCycles();
    // XCHG byte ptr [0x29],AL (1000_6FBD / 0x16FBD)
    byte tmp_1000_6FBD = UInt8[DS, 0x29];
    UInt8[DS, 0x29] = AL;
    AL = tmp_1000_6FBD;
    State.IncCycles();
    // AND AX,0xfcfc (1000_6FC1 / 0x16FC1)
    AX &= 0xFCFC;
    State.IncCycles();
    // SUB AL,AH (1000_6FC4 / 0x16FC4)
    AL -= AH;
    State.IncCycles();
    // SHR AL,1 (1000_6FC6 / 0x16FC6)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_6FC8 / 0x16FC8)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:6fcd (1000_6FCA / 0x16FCA)
    if(!ZeroFlag) {
      goto label_1000_6FCD_16FCD;
    }
    State.IncCycles();
    // RET  (1000_6FCC / 0x16FCC)
    return NearRet();
    State.IncCycles();
    label_1000_6FCD_16FCD:
    // PUSH SI (1000_6FCD / 0x16FCD)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,0x8aa (1000_6FCE / 0x16FCE)
    SI = 0x8AA;
    State.IncCycles();
    label_1000_6FD1_16FD1:
    // TEST byte ptr [SI + 0x3],0xa0 (1000_6FD1 / 0x16FD1)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0xA0);
    State.IncCycles();
    // JNZ 0x1000:6fda (1000_6FD5 / 0x16FD5)
    if(!ZeroFlag) {
      goto label_1000_6FDA_16FDA;
    }
    State.IncCycles();
    // CALL 0x1000:6f93 (1000_6FD7 / 0x16FD7)
    NearCall(cs1, 0x6FDA, not_observed_1000_6F93_016F93);
    State.IncCycles();
    label_1000_6FDA_16FDA:
    // ADD SI,0x1b (1000_6FDA / 0x16FDA)
    SI += 0x1B;
    State.IncCycles();
    // CMP SI,0xfbb (1000_6FDD / 0x16FDD)
    Alu.Sub16(SI, 0xFBB);
    State.IncCycles();
    // JC 0x1000:6fd1 (1000_6FE1 / 0x16FE1)
    if(CarryFlag) {
      goto label_1000_6FD1_16FD1;
    }
    State.IncCycles();
    // POP SI (1000_6FE3 / 0x16FE3)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_6FE4 / 0x16FE4)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_6FE5_016FE5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6FE5_16FE5:
    // CALL 0x1000:6e20 (1000_6FE5 / 0x16FE5)
    NearCall(cs1, 0x6FE8, spice86_generated_label_call_target_1000_6E20_016E20);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6FE8_016FE8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_6FE8_016FE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_6FE8_16FE8:
    // TEST word ptr [SI + 0x10],0x200 (1000_6FE8 / 0x16FE8)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    State.IncCycles();
    // JNZ 0x1000:705c (1000_6FED / 0x16FED)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_705C_01705C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:6b96 (1000_6FEF / 0x16FEF)
    NearCall(cs1, 0x6FF2, spice86_generated_label_call_target_1000_6B96_016B96);
    State.IncCycles();
    label_1000_6FF2_16FF2:
    // JNC 0x1000:6ff7 (1000_6FF2 / 0x16FF2)
    if(!CarryFlag) {
      goto label_1000_6FF7_16FF7;
    }
    State.IncCycles();
    // JMP 0x1000:707b (1000_6FF4 / 0x16FF4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_705C_01705C, 0x1707B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_6FF7_16FF7:
    // CALL 0x1000:714c (1000_6FF7 / 0x16FF7)
    NearCall(cs1, 0x6FFA, spice86_generated_label_call_target_1000_714C_01714C);
    State.IncCycles();
    label_1000_6FFA_16FFA:
    // OR word ptr [SI + 0x10],0x100 (1000_6FFA / 0x16FFA)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x100;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x100);
    State.IncCycles();
    // CALL 0x1000:708a (1000_6FFF / 0x16FFF)
    NearCall(cs1, 0x7002, spice86_generated_label_call_target_1000_708A_01708A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_7002_017002, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_7002_017002(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7002_17002:
    // PUSH AX (1000_7002 / 0x17002)
    Stack.Push(AX);
    State.IncCycles();
    // MOV DX,word ptr [SI + 0xe] (1000_7003 / 0x17003)
    DX = UInt16[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // ADD AX,DX (1000_7006 / 0x17006)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // MOV word ptr [SI + 0xe],AX (1000_7008 / 0x17008)
    UInt16[DS, (ushort)(SI + 0xE)] = AX;
    State.IncCycles();
    // XOR AX,DX (1000_700B / 0x1700B)
    AX ^= DX;
    State.IncCycles();
    // AND AX,0xff80 (1000_700D / 0x1700D)
    // AX &= 0xFF80;
    AX = Alu.And16(AX, 0xFF80);
    State.IncCycles();
    // JZ 0x1000:7019 (1000_7010 / 0x17010)
    if(ZeroFlag) {
      goto label_1000_7019_17019;
    }
    State.IncCycles();
    // MOV AL,0x1 (1000_7012 / 0x17012)
    AL = 0x1;
    State.IncCycles();
    // XOR BX,BX (1000_7014 / 0x17014)
    BX = 0;
    State.IncCycles();
    // CALL 0x1000:6edd (1000_7016 / 0x17016)
    NearCall(cs1, 0x7019, not_observed_1000_6EDD_016EDD);
    State.IncCycles();
    label_1000_7019_17019:
    // POP AX (1000_7019 / 0x17019)
    AX = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_701A / 0x1701A)
    Stack.Push(AX);
    State.IncCycles();
    // ADD AX,word ptr [0x46e1] (1000_701B / 0x1701B)
    AX += UInt16[DS, 0x46E1];
    State.IncCycles();
    // XOR DX,DX (1000_701F / 0x1701F)
    DX = 0;
    State.IncCycles();
    // MOV CX,0xa (1000_7021 / 0x17021)
    CX = 0xA;
    State.IncCycles();
    // DIV CX (1000_7024 / 0x17024)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV word ptr [0x46e1],DX (1000_7026 / 0x17026)
    UInt16[DS, 0x46E1] = DX;
    State.IncCycles();
    // ADD word ptr [0xa0],AX (1000_702A / 0x1702A)
    // UInt16[DS, 0xA0] += AX;
    UInt16[DS, 0xA0] = Alu.Add16(UInt16[DS, 0xA0], AX);
    State.IncCycles();
    // POP AX (1000_702E / 0x1702E)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD AL,byte ptr [DI + 0x13] (1000_702F / 0x1702F)
    // AL += UInt8[DS, (ushort)(DI + 0x13)];
    AL = Alu.Add8(AL, UInt8[DS, (ushort)(DI + 0x13)]);
    State.IncCycles();
    // ADC AH,0x0 (1000_7032 / 0x17032)
    AH = Alu.Adc8(AH, 0x0);
    State.IncCycles();
    // MOV CL,byte ptr [DI + 0x11] (1000_7035 / 0x17035)
    CL = UInt8[DS, (ushort)(DI + 0x11)];
    State.IncCycles();
    // DIV CL (1000_7038 / 0x17038)
    Cpu.Div8(CL);
    State.IncCycles();
    // MOV byte ptr [DI + 0x13],AH (1000_703A / 0x1703A)
    UInt8[DS, (ushort)(DI + 0x13)] = AH;
    State.IncCycles();
    // MOV AH,byte ptr [DI + 0x12] (1000_703D / 0x1703D)
    AH = UInt8[DS, (ushort)(DI + 0x12)];
    State.IncCycles();
    // AND AH,0xf (1000_7040 / 0x17040)
    AH &= 0xF;
    State.IncCycles();
    // CMP AL,AH (1000_7043 / 0x17043)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JBE 0x1000:7052 (1000_7045 / 0x17045)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_7052_17052;
    }
    State.IncCycles();
    // TEST byte ptr [0x46eb],0x40 (1000_7047 / 0x17047)
    Alu.And8(UInt8[DS, 0x46EB], 0x40);
    State.IncCycles();
    // JZ 0x1000:7052 (1000_704C / 0x1704C)
    if(ZeroFlag) {
      goto label_1000_7052_17052;
    }
    State.IncCycles();
    // INC byte ptr [0x46ec] (1000_704E / 0x1704E)
    UInt8[DS, 0x46EC]++;
    State.IncCycles();
    label_1000_7052_17052:
    // SUB byte ptr [DI + 0x12],AL (1000_7052 / 0x17052)
    // UInt8[DS, (ushort)(DI + 0x12)] -= AL;
    UInt8[DS, (ushort)(DI + 0x12)] = Alu.Sub8(UInt8[DS, (ushort)(DI + 0x12)], AL);
    State.IncCycles();
    // JNC 0x1000:705b (1000_7055 / 0x17055)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_705B / 0x1705B)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [DI + 0x12],0x0 (1000_7057 / 0x17057)
    UInt8[DS, (ushort)(DI + 0x12)] = 0x0;
    State.IncCycles();
    label_1000_705B_1705B:
    // RET  (1000_705B / 0x1705B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_705C_01705C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_705C_1705C:
    // MOV AX,[0x2] (1000_705C / 0x1705C)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV AH,byte ptr [SI] (1000_705F / 0x1705F)
    AH = UInt8[DS, SI];
    State.IncCycles();
    // AND AX,0xf0f (1000_7061 / 0x17061)
    AX &= 0xF0F;
    State.IncCycles();
    // CMP AL,AH (1000_7064 / 0x17064)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JNZ 0x1000:7074 (1000_7066 / 0x17066)
    if(!ZeroFlag) {
      goto label_1000_7074_17074;
    }
    State.IncCycles();
    // AND word ptr [SI + 0x10],0xfdff (1000_7068 / 0x17068)
    // UInt16[DS, (ushort)(SI + 0x10)] &= 0xFDFF;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0xFDFF);
    State.IncCycles();
    // CALL 0x1000:6b96 (1000_706D / 0x1706D)
    NearCall(cs1, 0x7070, spice86_generated_label_call_target_1000_6B96_016B96);
    State.IncCycles();
    // JC 0x1000:705b (1000_7070 / 0x17070)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_705B / 0x1705B)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:6ffa (1000_7072 / 0x17072)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_6FE8_016FE8, 0x16FFA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_7074_17074:
    // MOV word ptr [SI + 0xc],0x0 (1000_7074 / 0x17074)
    UInt16[DS, (ushort)(SI + 0xC)] = 0x0;
    State.IncCycles();
    // JMP 0x1000:7085 (1000_7079 / 0x17079)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_7085_017085, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_707B_1707B:
    // MOV word ptr [SI + 0xc],0x0 (1000_707B / 0x1707B)
    UInt16[DS, (ushort)(SI + 0xC)] = 0x0;
    State.IncCycles();
    // MOV word ptr [SI + 0xe],0x0 (1000_7080 / 0x17080)
    UInt16[DS, (ushort)(SI + 0xE)] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_7085_017085, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_7085_017085(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7085_17085:
    // OR byte ptr [SI + 0x3],0x10 (1000_7085 / 0x17085)
    // UInt8[DS, (ushort)(SI + 0x3)] |= 0x10;
    UInt8[DS, (ushort)(SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x3)], 0x10);
    State.IncCycles();
    // RET  (1000_7089 / 0x17089)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_708A_01708A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_708A_1708A:
    // CALL 0x1000:6efd (1000_708A / 0x1708A)
    NearCall(cs1, 0x708D, spice86_generated_label_call_target_1000_6EFD_016EFD);
    State.IncCycles();
    label_1000_708D_1708D:
    // MOV AH,byte ptr [SI + 0x16] (1000_708D / 0x1708D)
    AH = UInt8[DS, (ushort)(SI + 0x16)];
    State.IncCycles();
    // AND AH,0xf0 (1000_7090 / 0x17090)
    AH &= 0xF0;
    State.IncCycles();
    // ADD AL,AH (1000_7093 / 0x17093)
    AL += AH;
    State.IncCycles();
    // MUL byte ptr [SI + 0x1a] (1000_7095 / 0x17095)
    Cpu.Mul8(UInt8[DS, (ushort)(SI + 0x1A)]);
    State.IncCycles();
    // TEST byte ptr [SI + 0x19],0x80 (1000_7098 / 0x17098)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:70a2 (1000_709C / 0x1709C)
    if(!ZeroFlag) {
      goto label_1000_70A2_170A2;
    }
    State.IncCycles();
    // SHR AX,1 (1000_709E / 0x1709E)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_70A0 / 0x170A0)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    label_1000_70A2_170A2:
    // MOV AL,byte ptr [DI + 0x12] (1000_70A2 / 0x170A2)
    AL = UInt8[DS, (ushort)(DI + 0x12)];
    State.IncCycles();
    // AND AL,0xf0 (1000_70A5 / 0x170A5)
    AL &= 0xF0;
    State.IncCycles();
    // INC AX (1000_70A7 / 0x170A7)
    AX++;
    State.IncCycles();
    // MUL AH (1000_70A8 / 0x170A8)
    Cpu.Mul8(AH);
    State.IncCycles();
    // XCHG AH,AL (1000_70AA / 0x170AA)
    byte tmp_1000_70AA = AH;
    AH = AL;
    AL = tmp_1000_70AA;
    State.IncCycles();
    // ROL AX,1 (1000_70AC / 0x170AC)
    AX = Alu.Rol16(AX, 0x1);
    State.IncCycles();
    // AND AH,0x1 (1000_70AE / 0x170AE)
    // AH &= 0x1;
    AH = Alu.And8(AH, 0x1);
    State.IncCycles();
    // MOV DX,AX (1000_70B1 / 0x170B1)
    DX = AX;
    State.IncCycles();
    // XCHG word ptr [SI + 0xc],DX (1000_70B3 / 0x170B3)
    ushort tmp_1000_70B3 = UInt16[DS, (ushort)(SI + 0xC)];
    UInt16[DS, (ushort)(SI + 0xC)] = DX;
    DX = tmp_1000_70B3;
    State.IncCycles();
    // SUB DX,AX (1000_70B6 / 0x170B6)
    // DX -= AX;
    DX = Alu.Sub16(DX, AX);
    State.IncCycles();
    // JZ 0x1000:70cb (1000_70B8 / 0x170B8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_70CB / 0x170CB)
      return NearRet();
    }
    State.IncCycles();
    // MOV BL,0x8 (1000_70BA / 0x170BA)
    BL = 0x8;
    State.IncCycles();
    // JC 0x1000:70c0 (1000_70BC / 0x170BC)
    if(CarryFlag) {
      goto label_1000_70C0_170C0;
    }
    State.IncCycles();
    // MOV BL,0x4 (1000_70BE / 0x170BE)
    BL = 0x4;
    State.IncCycles();
    label_1000_70C0_170C0:
    // MOV CX,word ptr [SI + 0x10] (1000_70C0 / 0x170C0)
    CX = UInt16[DS, (ushort)(SI + 0x10)];
    State.IncCycles();
    // AND CL,0xf3 (1000_70C3 / 0x170C3)
    // CL &= 0xF3;
    CL = Alu.And8(CL, 0xF3);
    State.IncCycles();
    // OR CL,BL (1000_70C6 / 0x170C6)
    // CL |= BL;
    CL = Alu.Or8(CL, BL);
    State.IncCycles();
    // MOV word ptr [SI + 0x10],CX (1000_70C8 / 0x170C8)
    UInt16[DS, (ushort)(SI + 0x10)] = CX;
    State.IncCycles();
    label_1000_70CB_170CB:
    // RET  (1000_70CB / 0x170CB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_714C_01714C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_714C_1714C:
    // TEST byte ptr [0xa],0x1 (1000_714C / 0x1714C)
    Alu.And8(UInt8[DS, 0xA], 0x1);
    State.IncCycles();
    // JZ 0x1000:71bb (1000_7151 / 0x17151)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x19],0x80 (1000_7153 / 0x17153)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x80);
    State.IncCycles();
    // JZ 0x1000:71bb (1000_7157 / 0x17157)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x2] (1000_7159 / 0x17159)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV AH,byte ptr [SI] (1000_715C / 0x1715C)
    AH = UInt8[DS, SI];
    State.IncCycles();
    // AND AX,0xf0f (1000_715E / 0x1715E)
    AX &= 0xF0F;
    State.IncCycles();
    // CMP AL,AH (1000_7161 / 0x17161)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JNZ 0x1000:71bb (1000_7163 / 0x17163)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:71bc (1000_7165 / 0x17165)
    NearCall(cs1, 0x7168, not_observed_1000_71BC_0171BC);
    State.IncCycles();
    // CALL 0x1000:e3cc (1000_7168 / 0x17168)
    NearCall(cs1, 0x716B, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_716B / 0x1716B)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // MOV BX,0x1141 (1000_716D / 0x1716D)
    BX = 0x1141;
    State.IncCycles();
    // XLAT BX (1000_7170 / 0x17170)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // CMP AL,AH (1000_7171 / 0x17171)
    Alu.Sub8(AL, AH);
    State.IncCycles();
    // JC 0x1000:71bb (1000_7173 / 0x17173)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // OR word ptr [SI + 0x10],0x4000 (1000_7175 / 0x17175)
    UInt16[DS, (ushort)(SI + 0x10)] |= 0x4000;
    State.IncCycles();
    // TEST byte ptr [SI + 0x19],0x40 (1000_717A / 0x1717A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:71bb (1000_717E / 0x1717E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // AND AH,0x3 (1000_7180 / 0x17180)
    // AH &= 0x3;
    AH = Alu.And8(AH, 0x3);
    State.IncCycles();
    // JZ 0x1000:71bb (1000_7183 / 0x17183)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // CMP AH,0x2 (1000_7185 / 0x17185)
    Alu.Sub8(AH, 0x2);
    State.IncCycles();
    // JA 0x1000:71a4 (1000_7188 / 0x17188)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_71A4_0171A4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JZ 0x1000:719c (1000_718A / 0x1718A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_719C_01719C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // OR word ptr [SI + 0x10],0x2000 (1000_718C / 0x1718C)
    UInt16[DS, (ushort)(SI + 0x10)] |= 0x2000;
    State.IncCycles();
    // SUB byte ptr [SI + 0x1a],0x2 (1000_7191 / 0x17191)
    // UInt8[DS, (ushort)(SI + 0x1A)] -= 0x2;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x2);
    State.IncCycles();
    // JA 0x1000:71bb (1000_7195 / 0x17195)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71BB / 0x171BB)
      return NearRet();
    }
    State.IncCycles();
    // ADD byte ptr [SI + 0x1a],0x2 (1000_7197 / 0x17197)
    // UInt8[DS, (ushort)(SI + 0x1A)] += 0x2;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Add8(UInt8[DS, (ushort)(SI + 0x1A)], 0x2);
    State.IncCycles();
    // RET  (1000_719B / 0x1719B)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_719C_01719C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_719C_1719C:
    // OR word ptr [SI + 0x10],0x200 (1000_719C / 0x1719C)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x200;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    State.IncCycles();
    // JMP 0x1000:7085 (1000_71A1 / 0x171A1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_7085_017085, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_71A4_0171A4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_71A4_171A4:
    // OR word ptr [SI + 0x10],0x1000 (1000_71A4 / 0x171A4)
    UInt16[DS, (ushort)(SI + 0x10)] |= 0x1000;
    State.IncCycles();
    // AND byte ptr [SI + 0x19],0x7f (1000_71A9 / 0x171A9)
    UInt8[DS, (ushort)(SI + 0x19)] &= 0x7F;
    State.IncCycles();
    // DEC byte ptr [DI + 0x14] (1000_71AD / 0x171AD)
    UInt8[DS, (ushort)(DI + 0x14)] = Alu.Dec8(UInt8[DS, (ushort)(DI + 0x14)]);
    State.IncCycles();
    // MOV AL,0x6 (1000_71B0 / 0x171B0)
    AL = 0x6;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_71B2_0171B2(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x71BB: goto label_1000_71BB_171BB;break; // Target of external jump from 0x17151
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_71B2_171B2:
    // MOV AH,0xf (1000_71B2 / 0x171B2)
    AH = 0xF;
    State.IncCycles();
    // PUSH SI (1000_71B4 / 0x171B4)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_71B5 / 0x171B5)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:29f0 (1000_71B6 / 0x171B6)
    NearCall(cs1, 0x71B9, not_observed_1000_29F0_0129F0);
    State.IncCycles();
    // POP DI (1000_71B9 / 0x171B9)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_71BA / 0x171BA)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_71BB_171BB:
    // RET  (1000_71BB / 0x171BB)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_71BC_0171BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_71BC_171BC:
    // CMP byte ptr [0x2a],0x35 (1000_71BC / 0x171BC)
    Alu.Sub8(UInt8[DS, 0x2A], 0x35);
    State.IncCycles();
    // JC 0x1000:71ee (1000_71C1 / 0x171C1)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71EE / 0x171EE)
      return NearRet();
    }
    State.IncCycles();
    // TEST word ptr [SI + 0x12],0x40 (1000_71C3 / 0x171C3)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x40);
    State.IncCycles();
    // JZ 0x1000:71ee (1000_71C8 / 0x171C8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71EE / 0x171EE)
      return NearRet();
    }
    State.IncCycles();
    // ROL word ptr [0x0],1 (1000_71CA / 0x171CA)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    State.IncCycles();
    // ROL word ptr [0x0],1 (1000_71CE / 0x171CE)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    State.IncCycles();
    // ROL word ptr [0x0],1 (1000_71D2 / 0x171D2)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    State.IncCycles();
    // TEST word ptr [0x0],0x7 (1000_71D6 / 0x171D6)
    Alu.And16(UInt16[DS, 0x0], 0x7);
    State.IncCycles();
    // JNZ 0x1000:71ee (1000_71DC / 0x171DC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_71EE / 0x171EE)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:719c (1000_71DE / 0x171DE)
    NearCall(cs1, 0x71E1, not_observed_1000_719C_01719C);
    State.IncCycles();
    // OR word ptr [SI + 0x10],0x8000 (1000_71E1 / 0x171E1)
    // UInt16[DS, (ushort)(SI + 0x10)] |= 0x8000;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.Or16(UInt16[DS, (ushort)(SI + 0x10)], 0x8000);
    State.IncCycles();
    // OR byte ptr [DI + 0xa],0x4 (1000_71E6 / 0x171E6)
    // UInt8[DS, (ushort)(DI + 0xA)] |= 0x4;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xA)], 0x4);
    State.IncCycles();
    // MOV AL,0x3 (1000_71EA / 0x171EA)
    AL = 0x3;
    State.IncCycles();
    // JMP 0x1000:71b2 (1000_71EC / 0x171EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_71EE_171EE:
    // RET  (1000_71EE / 0x171EE)
    return NearRet();
  }
  
  public virtual Action map_func_ida_1000_739E_1739E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_739E_1739E:
    // OR byte ptr [0x11bc],0x1 (1000_739E / 0x1739E)
    UInt8[DS, 0x11BC] |= 0x1;
    State.IncCycles();
    // CMP DI,0x11c (1000_73A3 / 0x173A3)
    Alu.Sub16(DI, 0x11C);
    State.IncCycles();
    // JNZ 0x1000:73d9 (1000_73A7 / 0x173A7)
    if(!ZeroFlag) {
      goto label_1000_73D9_173D9;
    }
    State.IncCycles();
    // INC byte ptr [0xc2] (1000_73A9 / 0x173A9)
    UInt8[DS, 0xC2] = Alu.Inc8(UInt8[DS, 0xC2]);
    State.IncCycles();
    // MOV BP,0x7399 (1000_73AD / 0x173AD)
    BP = 0x7399;
    State.IncCycles();
    // CALL 0x1000:661d (1000_73B0 / 0x173B0)
    NearCall(cs1, 0x73B3, spice86_generated_label_call_target_1000_661D_01661D);
    State.IncCycles();
    // CALL 0x1000:6e02 (1000_73B3 / 0x173B3)
    NearCall(cs1, 0x73B6, not_observed_1000_6E02_016E02);
    State.IncCycles();
    // LES DI,[0xdcfe] (1000_73B6 / 0x173B6)
    ES = UInt16[DS, 0xDD00];
    DI = UInt16[DS, 0xDCFE];
    State.IncCycles();
    // XOR DI,DI (1000_73BA / 0x173BA)
    DI = 0;
    State.IncCycles();
    // MOV CX,0xc5f9 (1000_73BC / 0x173BC)
    CX = 0xC5F9;
    State.IncCycles();
    label_1000_73BF_173BF:
    // MOV AL,byte ptr ES:[DI] (1000_73BF / 0x173BF)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // MOV AH,AL (1000_73C2 / 0x173C2)
    AH = AL;
    State.IncCycles();
    // AND AH,0x30 (1000_73C4 / 0x173C4)
    AH &= 0x30;
    State.IncCycles();
    // CMP AH,0x30 (1000_73C7 / 0x173C7)
    Alu.Sub8(AH, 0x30);
    State.IncCycles();
    // JNZ 0x1000:73ce (1000_73CA / 0x173CA)
    if(!ZeroFlag) {
      goto label_1000_73CE_173CE;
    }
    State.IncCycles();
    // AND AL,0xef (1000_73CC / 0x173CC)
    // AL &= 0xEF;
    AL = Alu.And8(AL, 0xEF);
    State.IncCycles();
    label_1000_73CE_173CE:
    // STOSB ES:DI (1000_73CE / 0x173CE)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // LOOP 0x1000:73bf (1000_73CF / 0x173CF)
    if(--CX != 0) {
      goto label_1000_73BF_173BF;
    }
    State.IncCycles();
    // MOV AL,0xa (1000_73D1 / 0x173D1)
    AL = 0xA;
    State.IncCycles();
    // MOV DI,0x11c (1000_73D3 / 0x173D3)
    DI = 0x11C;
    State.IncCycles();
    // JMP 0x1000:71b2 (1000_73D6 / 0x173D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_73D9_173D9:
    // CALL 0x1000:33be (1000_73D9 / 0x173D9)
    NearCall(cs1, 0x73DC, spice86_generated_label_call_target_1000_33BE_0133BE);
    State.IncCycles();
    // CMP word ptr [0x94],0x0 (1000_73DC / 0x173DC)
    Alu.Sub16(UInt16[DS, 0x94], 0x0);
    State.IncCycles();
    // JZ 0x1000:7429 (1000_73E1 / 0x173E1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_7429_017429, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:e3cc (1000_73E3 / 0x173E3)
    NearCall(cs1, 0x73E6, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    State.IncCycles();
    // CMP AL,byte ptr [0x9c] (1000_73E6 / 0x173E6)
    Alu.Sub8(AL, UInt8[DS, 0x9C]);
    State.IncCycles();
    // JC 0x1000:73ef (1000_73EA / 0x173EA)
    if(CarryFlag) {
      goto label_1000_73EF_173EF;
    }
    State.IncCycles();
    // JMP 0x1000:751d (1000_73EC / 0x173EC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_751D_01751D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_73EF_173EF:
    // CALL 0x1000:5098 (1000_73EF / 0x173EF)
    NearCall(cs1, 0x73F2, not_observed_1000_5098_015098);
    State.IncCycles();
    // PUSH CX (1000_73F2 / 0x173F2)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:342d (1000_73F3 / 0x173F3)
    NearCall(cs1, 0x73F6, spice86_generated_label_call_target_1000_342D_01342D);
    State.IncCycles();
    // POP CX (1000_73F6 / 0x173F6)
    CX = Stack.Pop();
    State.IncCycles();
    // JCXZ 0x1000:73fd (1000_73F7 / 0x173F7)
    if(CX == 0) {
      goto label_1000_73FD_173FD;
    }
    State.IncCycles();
    // XOR DX,DX (1000_73F9 / 0x173F9)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_73FB / 0x173FB)
    Cpu.Div16(CX);
    State.IncCycles();
    label_1000_73FD_173FD:
    // MOV DL,AL (1000_73FD / 0x173FD)
    DL = AL;
    State.IncCycles();
    // INC DL (1000_73FF / 0x173FF)
    DL = Alu.Inc8(DL);
    State.IncCycles();
    // JNZ 0x1000:7405 (1000_7401 / 0x17401)
    if(!ZeroFlag) {
      goto label_1000_7405_17405;
    }
    State.IncCycles();
    // DEC DL (1000_7403 / 0x17403)
    DL--;
    State.IncCycles();
    label_1000_7405_17405:
    // XOR DH,DH (1000_7405 / 0x17405)
    DH = 0;
    State.IncCycles();
    // XOR CX,CX (1000_7407 / 0x17407)
    CX = 0;
    State.IncCycles();
    // XOR BX,BX (1000_7409 / 0x17409)
    BX = 0;
    State.IncCycles();
    // MOV BP,0x7552 (1000_740B / 0x1740B)
    BP = 0x7552;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_740E / 0x1740E)
    NearCall(cs1, 0x7411, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // ADD word ptr [SI + 0xc],CX (1000_7411 / 0x17411)
    // UInt16[DS, (ushort)(SI + 0xC)] += CX;
    UInt16[DS, (ushort)(SI + 0xC)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0xC)], CX);
    State.IncCycles();
    // OR BX,BX (1000_7414 / 0x17414)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:7429 (1000_7416 / 0x17416)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_7429_017429, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_7418 / 0x17418)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_7429_017429(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7429_17429:
    // CMP DI,word ptr [0x114e] (1000_7429 / 0x17429)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JZ 0x1000:7434 (1000_742D / 0x1742D)
    if(ZeroFlag) {
      goto label_1000_7434_17434;
    }
    State.IncCycles();
    // MOV AL,0x7 (1000_742F / 0x1742F)
    AL = 0x7;
    State.IncCycles();
    // CALL 0x1000:71b2 (1000_7431 / 0x17431)
    NearCall(cs1, 0x7434, not_observed_1000_71B2_0171B2);
    State.IncCycles();
    label_1000_7434_17434:
    // CMP byte ptr [DI + 0x8],0x28 (1000_7434 / 0x17434)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    State.IncCycles();
    // JNC 0x1000:7443 (1000_7438 / 0x17438)
    if(!CarryFlag) {
      goto label_1000_7443_17443;
    }
    State.IncCycles();
    // AND byte ptr [DI + 0xa],0xfd (1000_743A / 0x1743A)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0xFD;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0xFD);
    State.IncCycles();
    // MOV BP,0x75af (1000_743E / 0x1743E)
    BP = 0x75AF;
    State.IncCycles();
    // JMP 0x1000:7479 (1000_7441 / 0x17441)
    goto label_1000_7479_17479;
    State.IncCycles();
    label_1000_7443_17443:
    // PUSH SI (1000_7443 / 0x17443)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_7444 / 0x17444)
    Stack.Push(DI);
    State.IncCycles();
    // MOV byte ptr [DI + 0xb],0x5 (1000_7445 / 0x17445)
    UInt8[DS, (ushort)(DI + 0xB)] = 0x5;
    State.IncCycles();
    // CALL 0x1000:644e (1000_7449 / 0x17449)
    NearCall(cs1, 0x744C, spice86_generated_label_call_target_1000_644E_01644E);
    State.IncCycles();
    // POP DI (1000_744C / 0x1744C)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_744D / 0x1744D)
    SI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_744E / 0x1744E)
    NearCall(cs1, 0x7451, spice86_generated_label_call_target_1000_1AC5_011AC5);
    State.IncCycles();
    // ADD AL,0x2 (1000_7451 / 0x17451)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    State.IncCycles();
    // MOV byte ptr [DI + 0xb],AL (1000_7453 / 0x17453)
    UInt8[DS, (ushort)(DI + 0xB)] = AL;
    State.IncCycles();
    // MOV AL,0x4 (1000_7456 / 0x17456)
    AL = 0x4;
    State.IncCycles();
    // CALL 0x1000:6f78 (1000_7458 / 0x17458)
    NearCall(cs1, 0x745B, spice86_generated_label_call_target_1000_6F78_016F78);
    State.IncCycles();
    // MOV AL,0x1 (1000_745B / 0x1745B)
    AL = 0x1;
    State.IncCycles();
    // CALL 0x1000:6f56 (1000_745D / 0x1745D)
    NearCall(cs1, 0x7460, not_observed_1000_6F56_016F56);
    State.IncCycles();
    // OR byte ptr [DI + 0xa],0x8 (1000_7460 / 0x17460)
    // UInt8[DS, (ushort)(DI + 0xA)] |= 0x8;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    State.IncCycles();
    // PUSH CX (1000_7464 / 0x17464)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CL,byte ptr [DI] (1000_7465 / 0x17465)
    CL = UInt8[DS, DI];
    State.IncCycles();
    // MOV AX,0x8000 (1000_7467 / 0x17467)
    AX = 0x8000;
    State.IncCycles();
    // ROL AX,CL (1000_746A / 0x1746A)
    AX = Alu.Rol16(AX, CL);
    State.IncCycles();
    // MOV [0x115a],AX (1000_746C / 0x1746C)
    UInt16[DS, 0x115A] = AX;
    State.IncCycles();
    // POP CX (1000_746F / 0x1746F)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV BP,0x75af (1000_7470 / 0x17470)
    BP = 0x75AF;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_7473 / 0x17473)
    NearCall(cs1, 0x7476, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // MOV BP,0x75ea (1000_7476 / 0x17476)
    BP = 0x75EA;
    State.IncCycles();
    label_1000_7479_17479:
    // CALL 0x1000:6603 (1000_7479 / 0x17479)
    NearCall(cs1, 0x747C, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // XOR DX,DX (1000_747C / 0x1747C)
    DX = 0;
    State.IncCycles();
    // TEST word ptr [0x0],0x3 (1000_747E / 0x1747E)
    Alu.And16(UInt16[DS, 0x0], 0x3);
    State.IncCycles();
    // JNZ 0x1000:7487 (1000_7484 / 0x17484)
    if(!ZeroFlag) {
      goto label_1000_7487_17487;
    }
    State.IncCycles();
    // INC DX (1000_7486 / 0x17486)
    DX++;
    State.IncCycles();
    label_1000_7487_17487:
    // XOR CX,CX (1000_7487 / 0x17487)
    CX = 0;
    State.IncCycles();
    // MOV BP,0x762a (1000_7489 / 0x17489)
    BP = 0x762A;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_748C / 0x1748C)
    NearCall(cs1, 0x748F, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // CMP CX,DX (1000_748F / 0x1748F)
    Alu.Sub16(CX, DX);
    State.IncCycles();
    // JA 0x1000:7487 (1000_7491 / 0x17491)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_7487_17487;
    }
    State.IncCycles();
    // PUSH SI (1000_7493 / 0x17493)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_7494 / 0x17494)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:1cda (1000_7495 / 0x17495)
    NearCall(cs1, 0x7498, spice86_generated_label_call_target_1000_1CDA_011CDA);
    State.IncCycles();
    // CMP DL,0x1 (1000_7498 / 0x17498)
    Alu.Sub8(DL, 0x1);
    State.IncCycles();
    // JA 0x1000:74b1 (1000_749B / 0x1749B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_74B1_174B1;
    }
    State.IncCycles();
    // MOV byte ptr [0xc2],0x1 (1000_749D / 0x1749D)
    UInt8[DS, 0xC2] = 0x1;
    State.IncCycles();
    // AND byte ptr [0xff7],0xfd (1000_74A2 / 0x174A2)
    UInt8[DS, 0xFF7] &= 0xFD;
    State.IncCycles();
    // AND byte ptr [0x1007],0xfd (1000_74A7 / 0x174A7)
    // UInt8[DS, 0x1007] &= 0xFD;
    UInt8[DS, 0x1007] = Alu.And8(UInt8[DS, 0x1007], 0xFD);
    State.IncCycles();
    // POP DI (1000_74AC / 0x174AC)
    DI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:765e (1000_74AD / 0x174AD)
    NearCall(cs1, 0x74B0, not_observed_1000_765E_01765E);
    State.IncCycles();
    // PUSH DI (1000_74B0 / 0x174B0)
    Stack.Push(DI);
    State.IncCycles();
    label_1000_74B1_174B1:
    // POP DI (1000_74B1 / 0x174B1)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_74B2 / 0x174B2)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:5d50 (1000_74B3 / 0x174B3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_74B6_0174B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_74B6_174B6:
    // AND byte ptr [DI + 0xa],0xfd (1000_74B6 / 0x174B6)
    UInt8[DS, (ushort)(DI + 0xA)] &= 0xFD;
    State.IncCycles();
    // CMP DI,word ptr [0x114e] (1000_74BA / 0x174BA)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    State.IncCycles();
    // JZ 0x1000:7500 (1000_74BE / 0x174BE)
    if(ZeroFlag) {
      goto label_1000_7500_17500;
    }
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x8] (1000_74C0 / 0x174C0)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    State.IncCycles();
    // CMP AL,0x28 (1000_74C3 / 0x174C3)
    Alu.Sub8(AL, 0x28);
    State.IncCycles();
    // JNC 0x1000:74eb (1000_74C5 / 0x174C5)
    if(!CarryFlag) {
      goto label_1000_74EB_174EB;
    }
    State.IncCycles();
    // AND AL,0x7 (1000_74C7 / 0x174C7)
    AL &= 0x7;
    State.IncCycles();
    // ADD AL,0x28 (1000_74C9 / 0x174C9)
    // AL += 0x28;
    AL = Alu.Add8(AL, 0x28);
    State.IncCycles();
    // MOV byte ptr [DI + 0x8],AL (1000_74CB / 0x174CB)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    State.IncCycles();
    // DEC byte ptr [0x27] (1000_74CE / 0x174CE)
    UInt8[DS, 0x27] = Alu.Dec8(UInt8[DS, 0x27]);
    State.IncCycles();
    // PUSH SI (1000_74D2 / 0x174D2)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:40ae (1000_74D3 / 0x174D3)
    NearCall(cs1, 0x74D6, spice86_generated_label_call_target_1000_40AE_0140AE);
    State.IncCycles();
    // MOV DL,0x3 (1000_74D6 / 0x174D6)
    DL = 0x3;
    State.IncCycles();
    // MOV SI,0xfd8 (1000_74D8 / 0x174D8)
    SI = 0xFD8;
    State.IncCycles();
    // MOV CX,0x9 (1000_74DB / 0x174DB)
    CX = 0x9;
    State.IncCycles();
    label_1000_74DE_174DE:
    // CMP BX,word ptr [SI + 0x2] (1000_74DE / 0x174DE)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:74e5 (1000_74E1 / 0x174E1)
    if(!ZeroFlag) {
      goto label_1000_74E5_174E5;
    }
    State.IncCycles();
    // MOV word ptr [SI],DX (1000_74E3 / 0x174E3)
    UInt16[DS, SI] = DX;
    State.IncCycles();
    label_1000_74E5_174E5:
    // ADD SI,0x10 (1000_74E5 / 0x174E5)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    State.IncCycles();
    // LOOP 0x1000:74de (1000_74E8 / 0x174E8)
    if(--CX != 0) {
      goto label_1000_74DE_174DE;
    }
    State.IncCycles();
    // POP SI (1000_74EA / 0x174EA)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_74EB_174EB:
    // MOV BP,0x7506 (1000_74EB / 0x174EB)
    BP = 0x7506;
    State.IncCycles();
    // CALL 0x1000:6603 (1000_74EE / 0x174EE)
    NearCall(cs1, 0x74F1, spice86_generated_label_call_target_1000_6603_016603);
    State.IncCycles();
    // PUSH DI (1000_74F1 / 0x174F1)
    Stack.Push(DI);
    State.IncCycles();
    // MOV CX,0x5 (1000_74F2 / 0x174F2)
    CX = 0x5;
    State.IncCycles();
    // CALL 0x1000:6447 (1000_74F5 / 0x174F5)
    NearCall(cs1, 0x74F8, not_observed_1000_6447_016447);
    State.IncCycles();
    // POP DI (1000_74F8 / 0x174F8)
    DI = Stack.Pop();
    State.IncCycles();
    // AND byte ptr [DI + 0xa],0xf6 (1000_74F9 / 0x174F9)
    // UInt8[DS, (ushort)(DI + 0xA)] &= 0xF6;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0xF6);
    State.IncCycles();
    // JMP 0x1000:5d44 (1000_74FD / 0x174FD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D44_015D44, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_7500_17500:
    // MOV byte ptr [0x46d9],0x6 (1000_7500 / 0x17500)
    UInt8[DS, 0x46D9] = 0x6;
    State.IncCycles();
    // RET  (1000_7505 / 0x17505)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_751D_01751D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_751D_1751D:
    // MOV AX,[0x94] (1000_751D / 0x1751D)
    AX = UInt16[DS, 0x94];
    State.IncCycles();
    // XOR DX,DX (1000_7520 / 0x17520)
    DX = 0;
    State.IncCycles();
    // XOR CX,CX (1000_7522 / 0x17522)
    CX = 0;
    State.IncCycles();
    // MOV CL,byte ptr [0x60] (1000_7524 / 0x17524)
    CL = UInt8[DS, 0x60];
    State.IncCycles();
    // JCXZ 0x1000:752c (1000_7528 / 0x17528)
    if(CX == 0) {
      goto label_1000_752C_1752C;
    }
    State.IncCycles();
    // DIV CX (1000_752A / 0x1752A)
    Cpu.Div16(CX);
    State.IncCycles();
    label_1000_752C_1752C:
    // MOV DX,AX (1000_752C / 0x1752C)
    DX = AX;
    State.IncCycles();
    // CALL 0x1000:758d (1000_752E / 0x1752E)
    NearCall(cs1, 0x7531, not_observed_1000_758D_01758D);
    State.IncCycles();
    // ADD word ptr [SI + 0xe],AX (1000_7531 / 0x17531)
    UInt16[DS, (ushort)(SI + 0xE)] += AX;
    State.IncCycles();
    // SUB byte ptr [SI + 0x1a],AL (1000_7534 / 0x17534)
    // UInt8[DS, (ushort)(SI + 0x1A)] -= AL;
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], AL);
    State.IncCycles();
    // JA 0x1000:7551 (1000_7537 / 0x17537)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7551 / 0x17551)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,0x7f (1000_7539 / 0x17539)
    BX = 0x7F;
    State.IncCycles();
    // CALL 0x1000:e3b7 (1000_753C / 0x1753C)
    NearCall(cs1, 0x753F, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    State.IncCycles();
    // ADD AL,0x1e (1000_753F / 0x1753F)
    // AL += 0x1E;
    AL = Alu.Add8(AL, 0x1E);
    State.IncCycles();
    // MOV byte ptr [SI + 0x1a],AL (1000_7541 / 0x17541)
    UInt8[DS, (ushort)(SI + 0x1A)] = AL;
    State.IncCycles();
    // CALL 0x1000:668f (1000_7544 / 0x17544)
    NearCall(cs1, 0x7547, not_observed_1000_668F_01668F);
    State.IncCycles();
    // CALL 0x1000:5098 (1000_7547 / 0x17547)
    NearCall(cs1, 0x754A, not_observed_1000_5098_015098);
    State.IncCycles();
    // OR DX,DX (1000_754A / 0x1754A)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JNZ 0x1000:7551 (1000_754C / 0x1754C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_7551 / 0x17551)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:74b6 (1000_754E / 0x1754E)
    NearCall(cs1, 0x7551, not_observed_1000_74B6_0174B6);
    State.IncCycles();
    label_1000_7551_17551:
    // RET  (1000_7551 / 0x17551)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_758D_01758D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_758D_1758D:
    // PUSH DX (1000_758D / 0x1758D)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,DX (1000_758E / 0x1758E)
    AX = DX;
    State.IncCycles();
    // MOV DX,0xff (1000_7590 / 0x17590)
    DX = 0xFF;
    State.IncCycles();
    // SUB DL,byte ptr [SI + 0x17] (1000_7593 / 0x17593)
    DL -= UInt8[DS, (ushort)(SI + 0x17)];
    State.IncCycles();
    // SUB DL,byte ptr [SI + 0x17] (1000_7596 / 0x17596)
    DL -= UInt8[DS, (ushort)(SI + 0x17)];
    State.IncCycles();
    // MUL DX (1000_7599 / 0x17599)
    Cpu.Mul16(DX);
    State.IncCycles();
    // MOV AL,AH (1000_759B / 0x1759B)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_759D / 0x1759D)
    AH = 0;
    State.IncCycles();
    // OR DX,DX (1000_759F / 0x1759F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:75a5 (1000_75A1 / 0x175A1)
    if(ZeroFlag) {
      goto label_1000_75A5_175A5;
    }
    State.IncCycles();
    // MOV AL,0xff (1000_75A3 / 0x175A3)
    AL = 0xFF;
    State.IncCycles();
    label_1000_75A5_175A5:
    // POP DX (1000_75A5 / 0x175A5)
    DX = Stack.Pop();
    State.IncCycles();
    // CMP AL,byte ptr [SI + 0x1a] (1000_75A6 / 0x175A6)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x1A)]);
    State.IncCycles();
    // JBE 0x1000:75ae (1000_75A9 / 0x175A9)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      State.IncCycles();
      // RET  (1000_75AE / 0x175AE)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1a] (1000_75AB / 0x175AB)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    State.IncCycles();
    label_1000_75AE_175AE:
    // RET  (1000_75AE / 0x175AE)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_765E_01765E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_765E_1765E:
    // CALL 0x1000:e270 (1000_765E / 0x1765E)
    NearCall(cs1, 0x7661, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // MOV SI,0x100 (1000_7661 / 0x17661)
    SI = 0x100;
    State.IncCycles();
    // XOR CX,CX (1000_7664 / 0x17664)
    CX = 0;
    State.IncCycles();
    label_1000_7666_17666:
    // ADD CL,byte ptr [SI + 0x19] (1000_7666 / 0x17666)
    CL += UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // ADD SI,0x1c (1000_7669 / 0x17669)
    SI += 0x1C;
    State.IncCycles();
    // CMP byte ptr [SI],0xff (1000_766C / 0x1766C)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:7666 (1000_766F / 0x1766F)
    if(!ZeroFlag) {
      goto label_1000_7666_17666;
    }
    State.IncCycles();
    // SUB CL,0xa (1000_7671 / 0x17671)
    // CL -= 0xA;
    CL = Alu.Sub8(CL, 0xA);
    State.IncCycles();
    // JC 0x1000:7679 (1000_7674 / 0x17674)
    if(CarryFlag) {
      goto label_1000_7679_17679;
    }
    State.IncCycles();
    // ADD byte ptr [DI + 0x19],CL (1000_7676 / 0x17676)
    // UInt8[DS, (ushort)(DI + 0x19)] += CL;
    UInt8[DS, (ushort)(DI + 0x19)] = Alu.Add8(UInt8[DS, (ushort)(DI + 0x19)], CL);
    State.IncCycles();
    label_1000_7679_17679:
    // CALL 0x1000:e283 (1000_7679 / 0x17679)
    NearCall(cs1, 0x767C, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // RET  (1000_767C / 0x1767C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_780A_01780A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_780A_1780A:
    // CALL 0x1000:7c63 (1000_780A / 0x1780A)
    NearCall(cs1, 0x780D, spice86_generated_label_call_target_1000_7C63_017C63);
    State.IncCycles();
    label_1000_780D_1780D:
    // MOV BP,0x2122 (1000_780D / 0x1780D)
    BP = 0x2122;
    State.IncCycles();
    // CMP AX,word ptr [0x1176] (1000_7810 / 0x17810)
    Alu.Sub16(AX, UInt16[DS, 0x1176]);
    State.IncCycles();
    // JA 0x1000:783e (1000_7814 / 0x17814)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_7816 / 0x17816)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // TEST AL,0x20 (1000_7819 / 0x17819)
    Alu.And8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:7821 (1000_781B / 0x1781B)
    if(ZeroFlag) {
      goto label_1000_7821_17821;
    }
    State.IncCycles();
    // CMP AL,0x22 (1000_781D / 0x1781D)
    Alu.Sub8(AL, 0x22);
    State.IncCycles();
    // JNZ 0x1000:783e (1000_781F / 0x1781F)
    if(!ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    State.IncCycles();
    label_1000_7821_17821:
    // MOV BP,0x214a (1000_7821 / 0x17821)
    BP = 0x214A;
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x40 (1000_7824 / 0x17824)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x40);
    State.IncCycles();
    // JNZ 0x1000:783e (1000_7828 / 0x17828)
    if(!ZeroFlag) {
      goto label_1000_783E_1783E;
    }
    State.IncCycles();
    // MOV BP,0x210a (1000_782A / 0x1782A)
    BP = 0x210A;
    State.IncCycles();
    // MOV AX,0x52 (1000_782D / 0x1782D)
    AX = 0x52;
    State.IncCycles();
    // CMP byte ptr [0x46f3],0x1 (1000_7830 / 0x17830)
    Alu.Sub8(UInt8[DS, 0x46F3], 0x1);
    State.IncCycles();
    // ADC AX,0x0 (1000_7835 / 0x17835)
    AX = Alu.Adc16(AX, 0x0);
    State.IncCycles();
    // MOV word ptr [BP + 0x12],AX (1000_7838 / 0x17838)
    UInt16[SS, (ushort)(BP + 0x12)] = AX;
    State.IncCycles();
    // CALL 0x1000:7847 (1000_783B / 0x1783B)
    NearCall(cs1, 0x783E, spice86_generated_label_call_target_1000_7847_017847);
    State.IncCycles();
    label_1000_783E_1783E:
    // MOV BX,0x8751 (1000_783E / 0x1783E)
    BX = 0x8751;
    State.IncCycles();
    // CALL 0x1000:d323 (1000_7841 / 0x17841)
    NearCall(cs1, 0x7844, spice86_generated_label_call_target_1000_D323_01D323);
    State.IncCycles();
    label_1000_7844_17844:
    // JMP 0x1000:c13b (1000_7844 / 0x17844)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13B_01C13B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_7847_017847(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_7847_17847:
    // MOV word ptr [0x2110],0x404f (1000_7847 / 0x17847)
    UInt16[DS, 0x2110] = 0x404F;
    State.IncCycles();
    // OR byte ptr [0x2115],0x40 (1000_784D / 0x1784D)
    // UInt8[DS, 0x2115] |= 0x40;
    UInt8[DS, 0x2115] = Alu.Or8(UInt8[DS, 0x2115], 0x40);
    State.IncCycles();
    // OR byte ptr [0x2119],0x40 (1000_7852 / 0x17852)
    UInt8[DS, 0x2119] |= 0x40;
    State.IncCycles();
    // TEST word ptr [SI + 0x12],0x400 (1000_7857 / 0x17857)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x400);
    State.IncCycles();
    // JNZ 0x1000:78bb (1000_785C / 0x1785C)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_785E / 0x1785E)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0xf (1000_7861 / 0x17861)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,0x1 (1000_7863 / 0x17863)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:786c (1000_7865 / 0x17865)
    if(ZeroFlag) {
      goto label_1000_786C_1786C;
    }
    State.IncCycles();
    // AND byte ptr [0x2111],0xbf (1000_7867 / 0x17867)
    UInt8[DS, 0x2111] &= 0xBF;
    State.IncCycles();
    label_1000_786C_1786C:
    // CMP AL,0x2 (1000_786C / 0x1786C)
    Alu.Sub8(AL, 0x2);
    State.IncCycles();
    // JNZ 0x1000:7876 (1000_786E / 0x1786E)
    if(!ZeroFlag) {
      goto label_1000_7876_17876;
    }
    State.IncCycles();
    // MOV byte ptr [0x2110],0x56 (1000_7870 / 0x17870)
    UInt8[DS, 0x2110] = 0x56;
    State.IncCycles();
    // RET  (1000_7875 / 0x17875)
    return NearRet();
    State.IncCycles();
    label_1000_7876_17876:
    // CMP byte ptr [0x2a],0x5 (1000_7876 / 0x17876)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5);
    State.IncCycles();
    // JC 0x1000:7882 (1000_787B / 0x1787B)
    if(CarryFlag) {
      goto label_1000_7882_17882;
    }
    State.IncCycles();
    // AND byte ptr [0x2119],0xbf (1000_787D / 0x1787D)
    UInt8[DS, 0x2119] &= 0xBF;
    State.IncCycles();
    label_1000_7882_17882:
    // CMP byte ptr [0x2a],0x4 (1000_7882 / 0x17882)
    Alu.Sub8(UInt8[DS, 0x2A], 0x4);
    State.IncCycles();
    // JC 0x1000:78bb (1000_7887 / 0x17887)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    State.IncCycles();
    // TEST word ptr [SI + 0x10],0x200 (1000_7889 / 0x17889)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0x200);
    State.IncCycles();
    // JNZ 0x1000:78bb (1000_788E / 0x1788E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,word ptr [SI + 0x4] (1000_7890 / 0x17890)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x8 (1000_7893 / 0x17893)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x8);
    State.IncCycles();
    // JNZ 0x1000:789f (1000_7897 / 0x17897)
    if(!ZeroFlag) {
      goto label_1000_789F_1789F;
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x28 (1000_7899 / 0x17899)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    State.IncCycles();
    // JNC 0x1000:78bb (1000_789D / 0x1789D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    State.IncCycles();
    label_1000_789F_1789F:
    // PUSH SI (1000_789F / 0x1789F)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_78A0 / 0x178A0)
    NearCall(cs1, 0x78A3, spice86_generated_label_call_target_1000_7F27_017F27);
    State.IncCycles();
    label_1000_78A3_178A3:
    // MOV SI,0x46fe (1000_78A3 / 0x178A3)
    SI = 0x46FE;
    State.IncCycles();
    // MOV CX,0x7 (1000_78A6 / 0x178A6)
    CX = 0x7;
    State.IncCycles();
    // XOR AL,AL (1000_78A9 / 0x178A9)
    AL = 0;
    State.IncCycles();
    label_1000_78AB_178AB:
    // OR AL,byte ptr [SI] (1000_78AB / 0x178AB)
    AL |= UInt8[DS, SI];
    State.IncCycles();
    // INC SI (1000_78AD / 0x178AD)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // LOOP 0x1000:78ab (1000_78AE / 0x178AE)
    if(--CX != 0) {
      goto label_1000_78AB_178AB;
    }
    State.IncCycles();
    // POP SI (1000_78B0 / 0x178B0)
    SI = Stack.Pop();
    State.IncCycles();
    // OR AL,byte ptr [SI + 0x19] (1000_78B1 / 0x178B1)
    // AL |= UInt8[DS, (ushort)(SI + 0x19)];
    AL = Alu.Or8(AL, UInt8[DS, (ushort)(SI + 0x19)]);
    State.IncCycles();
    // JZ 0x1000:78bb (1000_78B4 / 0x178B4)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_78BB / 0x178BB)
      return NearRet();
    }
    State.IncCycles();
    // AND byte ptr [0x2115],0xbf (1000_78B6 / 0x178B6)
    // UInt8[DS, 0x2115] &= 0xBF;
    UInt8[DS, 0x2115] = Alu.And8(UInt8[DS, 0x2115], 0xBF);
    State.IncCycles();
    label_1000_78BB_178BB:
    // RET  (1000_78BB / 0x178BB)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_78E9_0178E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_78E9_178E9:
    // CALL 0x1000:6917 (1000_78E9 / 0x178E9)
    NearCall(cs1, 0x78EC, spice86_generated_label_call_target_1000_6917_016917);
    State.IncCycles();
    // JZ 0x1000:78f1 (1000_78EC / 0x178EC)
    if(ZeroFlag) {
      goto label_1000_78F1_178F1;
    }
    State.IncCycles();
    // JMP 0x1000:79de (1000_78EE / 0x178EE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_79DE_0179DE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_78F1_178F1:
    // CALL 0x1000:c08e (1000_78F1 / 0x178F1)
    NearCall(cs1, 0x78F4, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:31f6 (1000_78F4 / 0x178F4)
    NearCall(cs1, 0x78F7, spice86_generated_label_call_target_1000_31F6_0131F6);
    State.IncCycles();
    // ADD word ptr [0x11f3],0xc (1000_78F7 / 0x178F7)
    // UInt16[DS, 0x11F3] += 0xC;
    UInt16[DS, 0x11F3] = Alu.Add16(UInt16[DS, 0x11F3], 0xC);
    State.IncCycles();
    // MOV SI,0x18df (1000_78FC / 0x178FC)
    SI = 0x18DF;
    State.IncCycles();
    // CALL 0x1000:7b1b (1000_78FF / 0x178FF)
    NearCall(cs1, 0x7902, spice86_generated_label_call_target_1000_7B1B_017B1B);
    State.IncCycles();
    // CALL 0x1000:d075 (1000_7902 / 0x17902)
    NearCall(cs1, 0x7905, spice86_generated_label_call_target_1000_D075_01D075);
    State.IncCycles();
    // MOV CL,0x9a (1000_7905 / 0x17905)
    CL = 0x9A;
    State.IncCycles();
    // MOV CH,byte ptr [0x18e8] (1000_7907 / 0x17907)
    CH = UInt8[DS, 0x18E8];
    State.IncCycles();
    // MOV DX,word ptr [0x18df] (1000_790B / 0x1790B)
    DX = UInt16[DS, 0x18DF];
    State.IncCycles();
    // MOV BX,word ptr [0x18e1] (1000_790F / 0x1790F)
    BX = UInt16[DS, 0x18E1];
    State.IncCycles();
    // ADD DX,0xc (1000_7913 / 0x17913)
    DX += 0xC;
    State.IncCycles();
    // ADD BX,0x4 (1000_7916 / 0x17916)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    State.IncCycles();
    // MOV AX,0x3a (1000_7919 / 0x17919)
    AX = 0x3A;
    State.IncCycles();
    // TEST byte ptr [0x30],0x40 (1000_791C / 0x1791C)
    Alu.And8(UInt8[DS, 0x30], 0x40);
    State.IncCycles();
    // JZ 0x1000:7924 (1000_7921 / 0x17921)
    if(ZeroFlag) {
      goto label_1000_7924_17924;
    }
    State.IncCycles();
    // INC AX (1000_7923 / 0x17923)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    label_1000_7924_17924:
    // CALL 0x1000:8865 (1000_7924 / 0x17924)
    NearCall(cs1, 0x7927, spice86_generated_label_call_target_1000_8865_018865);
    State.IncCycles();
    // MOV CL,0x96 (1000_7927 / 0x17927)
    CL = 0x96;
    State.IncCycles();
    // SUB DX,0x8 (1000_7929 / 0x17929)
    DX -= 0x8;
    State.IncCycles();
    // ADD BX,0x9 (1000_792C / 0x1792C)
    // BX += 0x9;
    BX = Alu.Add16(BX, 0x9);
    State.IncCycles();
    // MOV DI,word ptr [0x2c] (1000_792F / 0x1792F)
    DI = UInt16[DS, 0x2C];
    State.IncCycles();
    // CALL 0x1000:62a6 (1000_7933 / 0x17933)
    NearCall(cs1, 0x7936, spice86_generated_label_call_target_1000_62A6_0162A6);
    State.IncCycles();
    // MOV CL,0x9a (1000_7936 / 0x17936)
    CL = 0x9A;
    State.IncCycles();
    // ADD BX,0xa (1000_7938 / 0x17938)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    State.IncCycles();
    // MOV AL,[0x30] (1000_793B / 0x1793B)
    AL = UInt8[DS, 0x30];
    State.IncCycles();
    // TEST AL,0x20 (1000_793E / 0x1793E)
    Alu.And8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:794c (1000_7940 / 0x17940)
    if(ZeroFlag) {
      goto label_1000_794C_1794C;
    }
    State.IncCycles();
    // CMP AL,0x22 (1000_7942 / 0x17942)
    Alu.Sub8(AL, 0x22);
    State.IncCycles();
    // MOV AX,0x41 (1000_7944 / 0x17944)
    AX = 0x41;
    State.IncCycles();
    // JNZ 0x1000:79b6 (1000_7947 / 0x17947)
    if(!ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // INC AX (1000_7949 / 0x17949)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JMP 0x1000:79b6 (1000_794A / 0x1794A)
    goto label_1000_79B6_179B6;
    State.IncCycles();
    label_1000_794C_1794C:
    // MOV AX,0x3c (1000_794C / 0x1794C)
    AX = 0x3C;
    State.IncCycles();
    // CALL 0x1000:8865 (1000_794F / 0x1794F)
    NearCall(cs1, 0x7952, spice86_generated_label_call_target_1000_8865_018865);
    State.IncCycles();
    // ADD BX,0xf (1000_7952 / 0x17952)
    BX += 0xF;
    State.IncCycles();
    // CMP byte ptr [0x30],0x2 (1000_7955 / 0x17955)
    Alu.Sub8(UInt8[DS, 0x30], 0x2);
    State.IncCycles();
    // JZ 0x1000:79bc (1000_795A / 0x1795A)
    if(ZeroFlag) {
      goto label_1000_79BC_179BC;
    }
    State.IncCycles();
    // MOV AL,[0x2f] (1000_795C / 0x1795C)
    AL = UInt8[DS, 0x2F];
    State.IncCycles();
    // SHR AL,1 (1000_795F / 0x1795F)
    AL >>= 0x1;
    State.IncCycles();
    // AND AX,0x6 (1000_7961 / 0x17961)
    AX &= 0x6;
    State.IncCycles();
    // ADD AX,0x11f7 (1000_7964 / 0x17964)
    // AX += 0x11F7;
    AX = Alu.Add16(AX, 0x11F7);
    State.IncCycles();
    // MOV SI,AX (1000_7967 / 0x17967)
    SI = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_7969 / 0x17969)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // CALL 0x1000:d194 (1000_796B / 0x1796B)
    NearCall(cs1, 0x796E, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // ADD BX,0xa (1000_796E / 0x1796E)
    BX += 0xA;
    State.IncCycles();
    // TEST byte ptr [0x30],0x40 (1000_7971 / 0x17971)
    Alu.And8(UInt8[DS, 0x30], 0x40);
    State.IncCycles();
    // JNZ 0x1000:79bc (1000_7976 / 0x17976)
    if(!ZeroFlag) {
      goto label_1000_79BC_179BC;
    }
    State.IncCycles();
    // MOV AX,0x3f (1000_7978 / 0x17978)
    AX = 0x3F;
    State.IncCycles();
    // TEST word ptr [0x32],0x200 (1000_797B / 0x1797B)
    Alu.And16(UInt16[DS, 0x32], 0x200);
    State.IncCycles();
    // JNZ 0x1000:79b6 (1000_7981 / 0x17981)
    if(!ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // MOV AX,0x40 (1000_7983 / 0x17983)
    AX = 0x40;
    State.IncCycles();
    // TEST word ptr [0x32],0x100 (1000_7986 / 0x17986)
    Alu.And16(UInt16[DS, 0x32], 0x100);
    State.IncCycles();
    // JZ 0x1000:79b6 (1000_798C / 0x1798C)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // TEST word ptr [0x34],0x30 (1000_798E / 0x1798E)
    Alu.And16(UInt16[DS, 0x34], 0x30);
    State.IncCycles();
    // JNZ 0x1000:79b6 (1000_7994 / 0x17994)
    if(!ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // MOV AX,0x3d (1000_7996 / 0x17996)
    AX = 0x3D;
    State.IncCycles();
    // CMP byte ptr [0x30],0x0 (1000_7999 / 0x17999)
    Alu.Sub8(UInt8[DS, 0x30], 0x0);
    State.IncCycles();
    // JZ 0x1000:79b6 (1000_799E / 0x1799E)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // MOV AX,0x43 (1000_79A0 / 0x179A0)
    AX = 0x43;
    State.IncCycles();
    // CMP byte ptr [0x2f],0x1 (1000_79A3 / 0x179A3)
    Alu.Sub8(UInt8[DS, 0x2F], 0x1);
    State.IncCycles();
    // JZ 0x1000:79b6 (1000_79A8 / 0x179A8)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // MOV AX,0x3e (1000_79AA / 0x179AA)
    AX = 0x3E;
    State.IncCycles();
    // CMP byte ptr [0x30],0x6 (1000_79AD / 0x179AD)
    Alu.Sub8(UInt8[DS, 0x30], 0x6);
    State.IncCycles();
    // JZ 0x1000:79b6 (1000_79B2 / 0x179B2)
    if(ZeroFlag) {
      goto label_1000_79B6_179B6;
    }
    State.IncCycles();
    // JMP 0x1000:79bc (1000_79B4 / 0x179B4)
    goto label_1000_79BC_179BC;
    State.IncCycles();
    label_1000_79B6_179B6:
    // CALL 0x1000:8865 (1000_79B6 / 0x179B6)
    NearCall(cs1, 0x79B9, spice86_generated_label_call_target_1000_8865_018865);
    State.IncCycles();
    // ADD BX,0x11 (1000_79B9 / 0x179B9)
    BX += 0x11;
    State.IncCycles();
    label_1000_79BC_179BC:
    // ADD BX,0x4 (1000_79BC / 0x179BC)
    // BX += 0x4;
    BX = Alu.Add16(BX, 0x4);
    State.IncCycles();
    // MOV AX,0x6e (1000_79BF / 0x179BF)
    AX = 0x6E;
    State.IncCycles();
    // MOV CL,0x96 (1000_79C2 / 0x179C2)
    CL = 0x96;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_79C4 / 0x179C4)
    NearCall(cs1, 0x79C7, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // ADD BX,0x8 (1000_79C7 / 0x179C7)
    // BX += 0x8;
    BX = Alu.Add16(BX, 0x8);
    State.IncCycles();
    // MOV SI,word ptr [0x46fa] (1000_79CA / 0x179CA)
    SI = UInt16[DS, 0x46FA];
    State.IncCycles();
    // CALL 0x1000:7efb (1000_79CE / 0x179CE)
    NearCall(cs1, 0x79D1, spice86_generated_label_call_target_1000_7EFB_017EFB);
    State.IncCycles();
    // MOV SI,0x4705 (1000_79D1 / 0x179D1)
    SI = 0x4705;
    State.IncCycles();
    // MOV BP,word ptr [0x18e5] (1000_79D4 / 0x179D4)
    BP = UInt16[DS, 0x18E5];
    State.IncCycles();
    // CALL 0x1000:7e3d (1000_79D8 / 0x179D8)
    NearCall(cs1, 0x79DB, spice86_generated_label_call_target_1000_7E3D_017E3D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_79DB_0179DB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
