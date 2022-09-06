namespace Cryogenic.Overrides;

using Spice86.Core.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_4795_014795(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4795_14795:
    // CMP byte ptr [0x46eb],0x0 (1000_4795 / 0x14795)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:47cd (1000_479A / 0x1479A)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_47CD / 0x147CD)
      return NearRet();
    }
    State.IncCycles();
    // CMP AL,0x4 (1000_479C / 0x1479C)
    Alu.Sub8(AL, 0x4);
    State.IncCycles();
    // JZ 0x1000:47ce (1000_479E / 0x1479E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_47CE_0147CE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:98af (1000_47A0 / 0x147A0)
    NearCall(cs1, 0x47A3, not_observed_1000_98AF_0198AF);
    State.IncCycles();
    // MOV byte ptr [0xcee8],0x0 (1000_47A3 / 0x147A3)
    UInt8[DS, 0xCEE8] = 0x0;
    State.IncCycles();
    // MOV AL,0x50 (1000_47A8 / 0x147A8)
    AL = 0x50;
    State.IncCycles();
    // CALL 0x1000:121f (1000_47AA / 0x147AA)
    NearCall(cs1, 0x47AD, spice86_generated_label_jump_target_1000_121F_01121F);
    State.IncCycles();
    // MOV byte ptr [0xe8],0x0 (1000_47AD / 0x147AD)
    UInt8[DS, 0xE8] = 0x0;
    State.IncCycles();
    // CALL 0x1000:1797 (1000_47B2 / 0x147B2)
    NearCall(cs1, 0x47B5, spice86_generated_label_call_target_1000_1797_011797);
    State.IncCycles();
    // MOV AL,0x10 (1000_47B5 / 0x147B5)
    AL = 0x10;
    State.IncCycles();
    // MOV BP,0x4913 (1000_47B7 / 0x147B7)
    BP = 0x4913;
    State.IncCycles();
    // CALL 0x1000:c108 (1000_47BA / 0x147BA)
    NearCall(cs1, 0x47BD, spice86_generated_label_call_target_1000_C108_01C108);
    State.IncCycles();
    // MOV byte ptr [0x227d],0x1 (1000_47BD / 0x147BD)
    UInt8[DS, 0x227D] = 0x1;
    State.IncCycles();
    // CALL 0x1000:491c (1000_47C2 / 0x147C2)
    NearCall(cs1, 0x47C5, not_observed_1000_491C_01491C);
    State.IncCycles();
    // MOV byte ptr [0x227d],0x0 (1000_47C5 / 0x147C5)
    UInt8[DS, 0x227D] = 0x0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_47CD_147CD:
    // RET  (1000_47CD / 0x147CD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_47CE_0147CE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_47D1_147D1:
    // XOR AL,AL (1000_47D1 / 0x147D1)
    AL = 0;
    State.IncCycles();
    // XCHG byte ptr [0x4732],AL (1000_47D3 / 0x147D3)
    byte tmp_1000_47D3 = UInt8[DS, 0x4732];
    UInt8[DS, 0x4732] = AL;
    AL = tmp_1000_47D3;
    State.IncCycles();
    // SHL AL,1 (1000_47D7 / 0x147D7)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:47cd (1000_47D9 / 0x147D9)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_47CD / 0x147CD)
      return NearRet();
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_47DE_147DE:
    // MOV byte ptr [0x4731],0xff (1000_47DE / 0x147DE)
    UInt8[DS, 0x4731] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:c07c (1000_47E3 / 0x147E3)
    NearCall(cs1, 0x47E6, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_47E9_147E9:
    // CALL 0x1000:c412 (1000_47E9 / 0x147E9)
    NearCall(cs1, 0x47EC, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    label_1000_47EC_147EC:
    // CALL 0x1000:5ba0 (1000_47EC / 0x147EC)
    NearCall(cs1, 0x47EF, spice86_generated_label_call_target_1000_5BA0_015BA0);
    State.IncCycles();
    label_1000_47EF_147EF:
    // MOV byte ptr [0x4731],0x0 (1000_47EF / 0x147EF)
    UInt8[DS, 0x4731] = 0x0;
    State.IncCycles();
    // MOV AL,0x6 (1000_47F4 / 0x147F4)
    AL = 0x6;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_47F6 / 0x147F6)
    NearCall(cs1, 0x47F9, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_47FB_147FB:
    // MOV BP,0x4821 (1000_47FB / 0x147FB)
    BP = 0x4821;
    State.IncCycles();
    // MOV AX,0x14 (1000_47FE / 0x147FE)
    AX = 0x14;
    State.IncCycles();
    // CALL 0x1000:e353 (1000_4801 / 0x14801)
    NearCall(cs1, 0x4804, spice86_generated_label_call_target_1000_E353_01E353);
    State.IncCycles();
    label_1000_4804_14804:
    // ADD byte ptr [0x4731],CL (1000_4804 / 0x14804)
    // UInt8[DS, 0x4731] += CL;
    UInt8[DS, 0x4731] = Alu.Add8(UInt8[DS, 0x4731], CL);
    State.IncCycles();
    // MOV AL,[0x4731] (1000_4808 / 0x14808)
    AL = UInt8[DS, 0x4731];
    State.IncCycles();
    // CMP AL,0x1a (1000_480B / 0x1480B)
    Alu.Sub8(AL, 0x1A);
    State.IncCycles();
    // JNZ 0x1000:4816 (1000_480D / 0x1480D)
    if(!ZeroFlag) {
      goto label_1000_4816_14816;
    }
    State.IncCycles();
    // OR CL,CL (1000_480F / 0x1480F)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // JS 0x1000:4816 (1000_4811 / 0x14811)
    if(SignFlag) {
      goto label_1000_4816_14816;
    }
    State.IncCycles();
    // CALL 0x1000:ac30 (1000_4813 / 0x14813)
    NearCall(cs1, 0x4816, spice86_generated_label_call_target_1000_AC30_01AC30);
    State.IncCycles();
    label_1000_4816_14816:
    // CALL 0x1000:ae04 (1000_4816 / 0x14816)
    NearCall(cs1, 0x4819, spice86_generated_label_call_target_1000_AE04_01AE04);
    State.IncCycles();
    label_1000_4819_14819:
    // CMP byte ptr [0x4731],0x21 (1000_4819 / 0x14819)
    Alu.Sub8(UInt8[DS, 0x4731], 0x21);
    State.IncCycles();
    // JC 0x1000:47fb (1000_481E / 0x1481E)
    if(CarryFlag) {
      goto label_1000_47FB_147FB;
    }
    State.IncCycles();
    // RET  (1000_4820 / 0x14820)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4821_014821(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4821_14821:
    // PUSH CX (1000_4821 / 0x14821)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:c43e (1000_4822 / 0x14822)
    NearCall(cs1, 0x4825, spice86_generated_label_call_target_1000_C43E_01C43E);
    State.IncCycles();
    label_1000_4825_14825:
    // MOV AX,0x2a (1000_4825 / 0x14825)
    AX = 0x2A;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_4828 / 0x14828)
    NearCall(cs1, 0x482B, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_482E_1482E:
    // CALL 0x1000:c07c (1000_482E / 0x1482E)
    NearCall(cs1, 0x4831, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_4831_14831:
    // CALL 0x1000:3a95 (1000_4831 / 0x14831)
    NearCall(cs1, 0x4834, spice86_generated_label_call_target_1000_3A95_013A95);
    State.IncCycles();
    label_1000_4834_14834:
    // MOV AL,[0x4731] (1000_4834 / 0x14834)
    AL = UInt8[DS, 0x4731];
    State.IncCycles();
    // CMP AL,0xd (1000_4837 / 0x14837)
    Alu.Sub8(AL, 0xD);
    State.IncCycles();
    // JNZ 0x1000:4840 (1000_4839 / 0x14839)
    if(!ZeroFlag) {
      goto label_1000_4840_14840;
    }
    State.IncCycles();
    // PUSH AX (1000_483B / 0x1483B)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:ac30 (1000_483C / 0x1483C)
    NearCall(cs1, 0x483F, spice86_generated_label_call_target_1000_AC30_01AC30);
    State.IncCycles();
    label_1000_483F_1483F:
    // POP AX (1000_483F / 0x1483F)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_4840_14840:
    // SUB AL,0xe (1000_4840 / 0x14840)
    // AL -= 0xE;
    AL = Alu.Sub8(AL, 0xE);
    State.IncCycles();
    // JBE 0x1000:485d (1000_4842 / 0x14842)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_485D_1485D;
    }
    State.IncCycles();
    // POP CX (1000_4844 / 0x14844)
    CX = Stack.Pop();
    State.IncCycles();
    // PUSH CX (1000_4845 / 0x14845)
    Stack.Push(CX);
    State.IncCycles();
    // OR CL,CL (1000_4846 / 0x14846)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    State.IncCycles();
    // MOV CX,0x5 (1000_4848 / 0x14848)
    CX = 0x5;
    State.IncCycles();
    // JNS 0x1000:484f (1000_484B / 0x1484B)
    if(!SignFlag) {
      goto label_1000_484F_1484F;
    }
    State.IncCycles();
    // NEG CX (1000_484D / 0x1484D)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_1000_484F_1484F:
    // MOV AH,AL (1000_484F / 0x1484F)
    AH = AL;
    State.IncCycles();
    label_1000_4851_14851:
    // SUB DX,CX (1000_4851 / 0x14851)
    DX -= CX;
    State.IncCycles();
    // DEC AH (1000_4853 / 0x14853)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // JNZ 0x1000:4851 (1000_4855 / 0x14855)
    if(!ZeroFlag) {
      goto label_1000_4851_14851;
    }
    State.IncCycles();
    // MUL AL (1000_4857 / 0x14857)
    Cpu.Mul8(AL);
    State.IncCycles();
    // SAR AX,1 (1000_4859 / 0x14859)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // SUB BX,AX (1000_485B / 0x1485B)
    // BX -= AX;
    BX = Alu.Sub16(BX, AX);
    State.IncCycles();
    label_1000_485D_1485D:
    // CALL 0x1000:3aa9 (1000_485D / 0x1485D)
    NearCall(cs1, 0x4860, spice86_generated_label_call_target_1000_3AA9_013AA9);
    State.IncCycles();
    label_1000_4860_14860:
    // CALL 0x1000:3a95 (1000_4860 / 0x14860)
    NearCall(cs1, 0x4863, spice86_generated_label_call_target_1000_3A95_013A95);
    State.IncCycles();
    label_1000_4863_14863:
    // MOV CL,byte ptr [0x46ff] (1000_4863 / 0x14863)
    CL = UInt8[DS, 0x46FF];
    State.IncCycles();
    // XOR CH,CH (1000_4867 / 0x14867)
    CH = 0;
    State.IncCycles();
    // JCXZ 0x1000:487b (1000_4869 / 0x14869)
    if(CX == 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4877_014877, 0x1487B - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AL,[0x4731] (1000_486B / 0x1486B)
    AL = UInt8[DS, 0x4731];
    State.IncCycles();
    // PUSH AX (1000_486E / 0x1486E)
    Stack.Push(AX);
    State.IncCycles();
    // MOV byte ptr [0x4731],0x0 (1000_486F / 0x1486F)
    UInt8[DS, 0x4731] = 0x0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4877_14877:
    // POP AX (1000_4877 / 0x14877)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x4731],AL (1000_4878 / 0x14878)
    UInt8[DS, 0x4731] = AL;
    State.IncCycles();
    label_1000_487B_1487B:
    // CALL 0x1000:c4dd (1000_487B / 0x1487B)
    NearCall(cs1, 0x487E, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_487E_1487E:
    // CMP byte ptr [0x46d7],0x0 (1000_487E / 0x1487E)
    Alu.Sub8(UInt8[DS, 0x46D7], 0x0);
    State.IncCycles();
    // JZ 0x1000:4888 (1000_4883 / 0x14883)
    if(ZeroFlag) {
      goto label_1000_4888_14888;
    }
    State.IncCycles();
    // CALL 0x1000:3916 (1000_4885 / 0x14885)
    NearCall(cs1, 0x4888, spice86_generated_label_call_target_1000_3916_013916);
    State.IncCycles();
    label_1000_4888_14888:
    // POP CX (1000_4888 / 0x14888)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_4889 / 0x14889)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_488A_01488A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_488A_1488A:
    // MOV AX,0x6 (1000_488A / 0x1488A)
    AX = 0x6;
    State.IncCycles();
    // MOV SI,word ptr [0x114e] (1000_488D / 0x1488D)
    SI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:5e4f (1000_4891 / 0x14891)
    NearCall(cs1, 0x4894, spice86_generated_label_call_target_1000_5E4F_015E4F);
    State.IncCycles();
    // CMP AL,0x8 (1000_4894 / 0x14894)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JNC 0x1000:48e5 (1000_4896 / 0x14896)
    if(!CarryFlag) {
      goto label_1000_48E5_148E5;
    }
    State.IncCycles();
    // MOV BX,AX (1000_4898 / 0x14898)
    BX = AX;
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_489A / 0x1489A)
    NearCall(cs1, 0x489D, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // MOV byte ptr [0x4728],0x80 (1000_489D / 0x1489D)
    UInt8[DS, 0x4728] = 0x80;
    State.IncCycles();
    label_1000_48A2_148A2:
    // PUSH BX (1000_48A2 / 0x148A2)
    Stack.Push(BX);
    State.IncCycles();
    // CALL 0x1000:ca60 (1000_48A3 / 0x148A3)
    NearCall(cs1, 0x48A6, spice86_generated_label_call_target_1000_CA60_01CA60);
    State.IncCycles();
    // XOR AX,AX (1000_48A6 / 0x148A6)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:4ec6 (1000_48A8 / 0x148A8)
    NearCall(cs1, 0x48AB, spice86_generated_label_call_target_1000_4EC6_014EC6);
    State.IncCycles();
    // POP BX (1000_48AB / 0x148AB)
    BX = Stack.Pop();
    State.IncCycles();
    // CMP word ptr [0xdc00],0x2 (1000_48AC / 0x148AC)
    Alu.Sub16(UInt16[DS, 0xDC00], 0x2);
    State.IncCycles();
    // JNZ 0x1000:48a2 (1000_48B2 / 0x148B2)
    if(!ZeroFlag) {
      goto label_1000_48A2_148A2;
    }
    State.IncCycles();
    // MOV AX,0x3c (1000_48B4 / 0x148B4)
    AX = 0x3C;
    State.IncCycles();
    // CMP BX,0x6 (1000_48B7 / 0x148B7)
    Alu.Sub16(BX, 0x6);
    State.IncCycles();
    // JZ 0x1000:48c0 (1000_48BB / 0x148BB)
    if(ZeroFlag) {
      goto label_1000_48C0_148C0;
    }
    State.IncCycles();
    // MOV AX,0x16 (1000_48BD / 0x148BD)
    AX = 0x16;
    State.IncCycles();
    label_1000_48C0_148C0:
    // CMP AX,word ptr [0xdbea] (1000_48C0 / 0x148C0)
    Alu.Sub16(AX, UInt16[DS, 0xDBEA]);
    State.IncCycles();
    // JNZ 0x1000:48a2 (1000_48C4 / 0x148C4)
    if(!ZeroFlag) {
      goto label_1000_48A2_148A2;
    }
    State.IncCycles();
    // CALL 0x1000:ce4b (1000_48C6 / 0x148C6)
    NearCall(cs1, 0x48C9, not_observed_1000_CE4B_01CE4B);
    State.IncCycles();
    label_1000_48C9_148C9:
    // CALL 0x1000:ca60 (1000_48C9 / 0x148C9)
    NearCall(cs1, 0x48CC, spice86_generated_label_call_target_1000_CA60_01CA60);
    State.IncCycles();
    // CALL 0x1000:cc85 (1000_48CC / 0x148CC)
    NearCall(cs1, 0x48CF, spice86_generated_label_call_target_1000_CC85_01CC85);
    State.IncCycles();
    // JZ 0x1000:48c9 (1000_48CF / 0x148CF)
    if(ZeroFlag) {
      goto label_1000_48C9_148C9;
    }
    State.IncCycles();
    label_1000_48D1_148D1:
    // DEC byte ptr [0x46e0] (1000_48D1 / 0x148D1)
    UInt8[DS, 0x46E0] = Alu.Dec8(UInt8[DS, 0x46E0]);
    State.IncCycles();
    label_1000_48D5_148D5:
    // MOV byte ptr [0x4732],0x0 (1000_48D5 / 0x148D5)
    UInt8[DS, 0x4732] = 0x0;
    State.IncCycles();
    // JMP 0x1000:2d74 (1000_48DA / 0x148DA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2D74_012D74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_48DD_148DD:
    // MOV BP,0xc4cd (1000_48DD / 0x148DD)
    BP = 0xC4CD;
    State.IncCycles();
    // CALL 0x1000:c8fb (1000_48E0 / 0x148E0)
    NearCall(cs1, 0x48E3, not_observed_1000_C8FB_01C8FB);
    State.IncCycles();
    // JMP 0x1000:48d1 (1000_48E3 / 0x148E3)
    goto label_1000_48D1_148D1;
    State.IncCycles();
    label_1000_48E5_148E5:
    // CMP AL,0x9 (1000_48E5 / 0x148E5)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JZ 0x1000:48dd (1000_48E7 / 0x148E7)
    if(ZeroFlag) {
      goto label_1000_48DD_148DD;
    }
    State.IncCycles();
    // MOV byte ptr [0x4731],0xff (1000_48E9 / 0x148E9)
    UInt8[DS, 0x4731] = 0xFF;
    State.IncCycles();
    // CALL 0x1000:c07c (1000_48EE / 0x148EE)
    NearCall(cs1, 0x48F1, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    // CALL 0x1000:5ba0 (1000_48F1 / 0x148F1)
    NearCall(cs1, 0x48F4, spice86_generated_label_call_target_1000_5BA0_015BA0);
    State.IncCycles();
    // CALL 0x1000:37b2 (1000_48F4 / 0x148F4)
    NearCall(cs1, 0x48F7, spice86_generated_label_call_target_1000_37B2_0137B2);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_48F7 / 0x148F7)
    NearCall(cs1, 0x48FA, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // CALL 0x1000:c412 (1000_48FA / 0x148FA)
    NearCall(cs1, 0x48FD, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    // MOV byte ptr [0x4731],0x1f (1000_48FD / 0x148FD)
    UInt8[DS, 0x4731] = 0x1F;
    State.IncCycles();
    // MOV AL,0x7 (1000_4902 / 0x14902)
    AL = 0x7;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_4904 / 0x14904)
    NearCall(cs1, 0x4907, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    // MOV CL,0xff (1000_4907 / 0x14907)
    CL = 0xFF;
    State.IncCycles();
    // CALL 0x1000:47fb (1000_4909 / 0x14909)
    NearCall(cs1, 0x490C, spice86_generated_label_jump_target_1000_47FB_0147FB);
    State.IncCycles();
    // MOV byte ptr [0x4731],0x0 (1000_490C / 0x1490C)
    UInt8[DS, 0x4731] = 0x0;
    State.IncCycles();
    // JMP 0x1000:48d5 (1000_4911 / 0x14911)
    goto label_1000_48D5_148D5;
  }
  
  public virtual Action not_observed_1000_491C_01491C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_491C_1491C:
    // CALL 0x1000:c08e (1000_491C / 0x1491C)
    NearCall(cs1, 0x491F, spice86_generated_label_call_target_1000_C08E_01C08E);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_491F / 0x1491F)
    NearCall(cs1, 0x4922, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // MOV AL,0x8 (1000_4922 / 0x14922)
    AL = 0x8;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_4924 / 0x14924)
    NearCall(cs1, 0x4927, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    // CALL 0x1000:ae04 (1000_4927 / 0x14927)
    NearCall(cs1, 0x492A, spice86_generated_label_call_target_1000_AE04_01AE04);
    State.IncCycles();
    label_1000_492A_1492A:
    // CALL 0x1000:c9e8 (1000_492A / 0x1492A)
    NearCall(cs1, 0x492D, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    State.IncCycles();
    // JZ 0x1000:4934 (1000_492D / 0x1492D)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:c07c (1000_4934 / 0x14934)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:4937 (1000_492F / 0x1492F)
    NearCall(cs1, 0x4932, not_observed_1000_4937_014937);
    State.IncCycles();
    // JZ 0x1000:492a (1000_4932 / 0x14932)
    if(ZeroFlag) {
      goto label_1000_492A_1492A;
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4937_14937:
    // MOV AX,[0xdbe8] (1000_4937 / 0x14937)
    AX = UInt16[DS, 0xDBE8];
    State.IncCycles();
    // CMP AL,0xb (1000_493A / 0x1493A)
    Alu.Sub8(AL, 0xB);
    State.IncCycles();
    // JNZ 0x1000:4941 (1000_493C / 0x1493C)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:cc85 (1000_4941 / 0x14941)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CC85_01CC85, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CALL 0x1000:ac30 (1000_493E / 0x1493E)
    NearCall(cs1, 0x4941, spice86_generated_label_call_target_1000_AC30_01AC30);
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4947_14947:
    // CMP DI,-0x10 (1000_4947 / 0x14947)
    Alu.Sub16(DI, 0xFFF0);
    State.IncCycles();
    // JC 0x1000:4965 (1000_494A / 0x1494A)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_4965_014965, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC byte ptr [0x11cb] (1000_494C / 0x1494C)
    UInt8[DS, 0x11CB] = Alu.Dec8(UInt8[DS, 0x11CB]);
    State.IncCycles();
    // CALL 0x1000:b5f9 (1000_4950 / 0x14950)
    NearCall(cs1, 0x4953, spice86_generated_label_call_target_1000_B5F9_01B5F9);
    State.IncCycles();
    label_1000_4953_14953:
    // MOV CX,BX (1000_4953 / 0x14953)
    CX = BX;
    State.IncCycles();
    // MOV DI,DX (1000_4955 / 0x14955)
    DI = DX;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_495A_1495A:
    // CALL 0x1000:5133 (1000_495A / 0x1495A)
    NearCall(cs1, 0x495D, spice86_generated_label_call_target_1000_5133_015133);
    State.IncCycles();
    label_1000_495D_1495D:
    // MOV DI,word ptr [0x1150] (1000_495D / 0x1495D)
    DI = UInt16[DS, 0x1150];
    State.IncCycles();
    // MOV CL,0x1 (1000_4961 / 0x14961)
    CL = 0x1;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4965_14965:
    // CALL 0x1000:5124 (1000_4965 / 0x14965)
    NearCall(cs1, 0x4968, spice86_generated_label_call_target_1000_5124_015124);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_496A_1496A:
    // MOV word ptr [0x11c5],DI (1000_496A / 0x1496A)
    UInt16[DS, 0x11C5] = DI;
    State.IncCycles();
    // MOV byte ptr [0x11c8],CL (1000_496E / 0x1496E)
    UInt8[DS, 0x11C8] = CL;
    State.IncCycles();
    // MOV byte ptr [0x11c7],0x0 (1000_4972 / 0x14972)
    UInt8[DS, 0x11C7] = 0x0;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_497D_1497D:
    // MOV BP,0x212e (1000_497D / 0x1497D)
    BP = 0x212E;
    State.IncCycles();
    // MOV byte ptr [0x4728],0x1 (1000_4980 / 0x14980)
    UInt8[DS, 0x4728] = 0x1;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4988_14988:
    // MOV word ptr [0x46fc],0x0 (1000_4988 / 0x14988)
    UInt16[DS, 0x46FC] = 0x0;
    State.IncCycles();
    // CALL 0x1000:5b5d (1000_498E / 0x1498E)
    NearCall(cs1, 0x4991, spice86_generated_label_call_target_1000_5B5D_015B5D);
    State.IncCycles();
    label_1000_4991_14991:
    // MOV SI,0x148a (1000_4991 / 0x14991)
    SI = 0x148A;
    State.IncCycles();
    // MOV DI,0x46e3 (1000_4994 / 0x14994)
    DI = 0x46E3;
    State.IncCycles();
    // CALL 0x1000:5b99 (1000_4997 / 0x14997)
    NearCall(cs1, 0x499A, spice86_generated_label_call_target_1000_5B99_015B99);
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_49A3_149A3:
    // CALL 0x1000:5b93 (1000_49A3 / 0x149A3)
    NearCall(cs1, 0x49A6, spice86_generated_label_ret_target_1000_5B93_015B93);
    State.IncCycles();
    label_1000_49A6_149A6:
    // MOV byte ptr [0x46eb],0x1 (1000_49A6 / 0x149A6)
    UInt8[DS, 0x46EB] = 0x1;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_49AE_149AE:
    // CALL 0x1000:5b69 (1000_49AE / 0x149AE)
    NearCall(cs1, 0x49B1, spice86_generated_label_call_target_1000_5B69_015B69);
    State.IncCycles();
    label_1000_49B1_149B1:
    // CALL 0x1000:c137 (1000_49B1 / 0x149B1)
    NearCall(cs1, 0x49B4, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_49B4_149B4:
    // CALL 0x1000:5dce (1000_49B4 / 0x149B4)
    NearCall(cs1, 0x49B7, spice86_generated_label_call_target_1000_5DCE_015DCE);
    State.IncCycles();
    label_1000_49B7_149B7:
    // MOV SI,word ptr [0x11c5] (1000_49B7 / 0x149B7)
    SI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // OR SI,SI (1000_49BB / 0x149BB)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    State.IncCycles();
    // JZ 0x1000:49cc (1000_49BD / 0x149BD)
    if(ZeroFlag) {
      goto label_1000_49CC_149CC;
    }
    State.IncCycles();
    // CALL 0x1000:62c9 (1000_49BF / 0x149BF)
    NearCall(cs1, 0x49C2, spice86_generated_label_call_target_1000_62C9_0162C9);
    State.IncCycles();
    label_1000_49C2_149C2:
    // JC 0x1000:49cc (1000_49C2 / 0x149C2)
    if(CarryFlag) {
      goto label_1000_49CC_149CC;
    }
    State.IncCycles();
    // DEC BX (1000_49C4 / 0x149C4)
    BX--;
    State.IncCycles();
    // DEC DX (1000_49C5 / 0x149C5)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // MOV AX,0x2e (1000_49C6 / 0x149C6)
    AX = 0x2E;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_49C9 / 0x149C9)
    NearCall(cs1, 0x49CC, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_49CC_149CC:
    // MOV byte ptr [0x46eb],0x0 (1000_49CC / 0x149CC)
    UInt8[DS, 0x46EB] = 0x0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_49D4_149D4:
    // CALL 0x1000:4988 (1000_49D4 / 0x149D4)
    NearCall(cs1, 0x49D7, spice86_generated_label_call_target_1000_4988_014988);
    State.IncCycles();
    // JMP 0x1000:49e3 (1000_49D7 / 0x149D7)
    // JMP target is JMP, inlining.
    State.IncCycles();
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
    State.IncCycles();
    label_1000_49D9_149D9:
    // CMP byte ptr [0x46eb],0x0 (1000_49D9 / 0x149D9)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JS 0x1000:49e6 (1000_49DE / 0x149DE)
    if(SignFlag) {
      // JS target is JMP, inlining.
      State.IncCycles();
      // JMP word ptr [0x46ed] (1000_49E6 / 0x149E6)
      // Indirect jump to word ptr [0x46ed], generating possible targets from emulator records
      uint targetAddress_1000_49E6 = (uint)(UInt16[DS, 0x46ED]);
      switch(targetAddress_1000_49E6) {
        default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_49E6));
          break;
      }
    }
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_49EA_149EA:
    // MOV byte ptr [0x4728],0x0 (1000_49EA / 0x149EA)
    UInt8[DS, 0x4728] = 0x0;
    State.IncCycles();
    // PUSH CS (1000_49EF / 0x149EF)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_49F0 / 0x149F0)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,0xe40c (1000_49F1 / 0x149F1)
    DI = 0xE40C;
    State.IncCycles();
    // MOV AX,0x800 (1000_49F4 / 0x149F4)
    AX = 0x800;
    State.IncCycles();
    label_1000_49F7_149F7:
    // STOSW ES:DI (1000_49F7 / 0x149F7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // STOSW ES:DI (1000_49F8 / 0x149F8)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP DI,0xe85c (1000_49F9 / 0x149F9)
    Alu.Sub16(DI, 0xE85C);
    State.IncCycles();
    // JC 0x1000:49f7 (1000_49FD / 0x149FD)
    if(CarryFlag) {
      goto label_1000_49F7_149F7;
    }
    State.IncCycles();
    // RET  (1000_49FF / 0x149FF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4A00_014A00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4A00_14A00:
    // PUSH CS (1000_4A00 / 0x14A00)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_4A01 / 0x14A01)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV DI,word ptr [0x149a] (1000_4A02 / 0x14A02)
    DI = UInt16[DS, 0x149A];
    State.IncCycles();
    // MOV AX,DX (1000_4A06 / 0x14A06)
    AX = DX;
    State.IncCycles();
    // STOSW ES:DI (1000_4A08 / 0x14A08)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AX,BX (1000_4A09 / 0x14A09)
    AX = BX;
    State.IncCycles();
    // STOSW ES:DI (1000_4A0B / 0x14A0B)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP DI,0xe85c (1000_4A0C / 0x14A0C)
    Alu.Sub16(DI, 0xE85C);
    State.IncCycles();
    // JC 0x1000:4a15 (1000_4A10 / 0x14A10)
    if(CarryFlag) {
      goto label_1000_4A15_14A15;
    }
    State.IncCycles();
    // MOV DI,0xe40c (1000_4A12 / 0x14A12)
    DI = 0xE40C;
    State.IncCycles();
    label_1000_4A15_14A15:
    // MOV word ptr [0x149a],DI (1000_4A15 / 0x14A15)
    UInt16[DS, 0x149A] = DI;
    State.IncCycles();
    // RET  (1000_4A19 / 0x14A19)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4A1A_014A1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4A1A_14A1A:
    // CMP byte ptr [0x4728],0x0 (1000_4A1A / 0x14A1A)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    State.IncCycles();
    // JS 0x1000:4a59 (1000_4A1F / 0x14A1F)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x148a (1000_4A21 / 0x14A21)
    SI = 0x148A;
    State.IncCycles();
    // CALL 0x1000:db74 (1000_4A24 / 0x14A24)
    NearCall(cs1, 0x4A27, spice86_generated_label_call_target_1000_DB74_01DB74);
    State.IncCycles();
    label_1000_4A27_14A27:
    // MOV SI,word ptr [0x149a] (1000_4A27 / 0x14A27)
    SI = UInt16[DS, 0x149A];
    State.IncCycles();
    // CMP SI,0xe40c (1000_4A2B / 0x14A2B)
    Alu.Sub16(SI, 0xE40C);
    State.IncCycles();
    // JNZ 0x1000:4a34 (1000_4A2F / 0x14A2F)
    if(!ZeroFlag) {
      goto label_1000_4A34_14A34;
    }
    State.IncCycles();
    // MOV SI,0xe85c (1000_4A31 / 0x14A31)
    SI = 0xE85C;
    State.IncCycles();
    label_1000_4A34_14A34:
    // SUB SI,0x4 (1000_4A34 / 0x14A34)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    State.IncCycles();
    // LODSW CS:SI (1000_4A37 / 0x14A37)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_4A39 / 0x14A39)
    DX = AX;
    State.IncCycles();
    // LODSW CS:SI (1000_4A3B / 0x14A3B)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_4A3D / 0x14A3D)
    BX = AX;
    State.IncCycles();
    // DEC AH (1000_4A3F / 0x14A3F)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // JNS 0x1000:4a59 (1000_4A41 / 0x14A41)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4A46_14A46:
    // JC 0x1000:4a59 (1000_4A46 / 0x14A46)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4A59 / 0x14A59)
      return NearRet();
    }
    State.IncCycles();
    // DEC BX (1000_4A48 / 0x14A48)
    BX--;
    State.IncCycles();
    // DEC DX (1000_4A49 / 0x14A49)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // CALL 0x1000:c137 (1000_4A4A / 0x14A4A)
    NearCall(cs1, 0x4A4D, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_4A4D_14A4D:
    // MOV AX,0x2f (1000_4A4D / 0x14A4D)
    AX = 0x2F;
    State.IncCycles();
    // CALL 0x1000:c085 (1000_4A50 / 0x14A50)
    NearCall(cs1, 0x4A53, spice86_generated_label_call_target_1000_C085_01C085);
    State.IncCycles();
    label_1000_4A53_14A53:
    // CALL 0x1000:c22f (1000_4A53 / 0x14A53)
    NearCall(cs1, 0x4A56, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_4A56_14A56:
    // CALL 0x1000:c07c (1000_4A56 / 0x14A56)
    NearCall(cs1, 0x4A59, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_4A59_14A59:
    // RET  (1000_4A59 / 0x14A59)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4A5A_014A5A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4A5D_14A5D:
    // PUSH word ptr [0xdbda] (1000_4A5D / 0x14A5D)
    Stack.Push(UInt16[DS, 0xDBDA]);
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4A68_14A68:
    // LODSW CS:SI (1000_4A68 / 0x14A68)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_4A6A / 0x14A6A)
    DX = AX;
    State.IncCycles();
    // LODSW CS:SI (1000_4A6C / 0x14A6C)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_4A6E / 0x14A6E)
    BX = AX;
    State.IncCycles();
    // DEC AH (1000_4A70 / 0x14A70)
    AH = Alu.Dec8(AH);
    State.IncCycles();
    // JNS 0x1000:4a99 (1000_4A72 / 0x14A72)
    if(!SignFlag) {
      goto label_1000_4A99_14A99;
    }
    State.IncCycles();
    // PUSH SI (1000_4A74 / 0x14A74)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:62d6 (1000_4A75 / 0x14A75)
    NearCall(cs1, 0x4A78, spice86_generated_label_call_target_1000_62D6_0162D6);
    State.IncCycles();
    label_1000_4A78_14A78:
    // JC 0x1000:4a98 (1000_4A78 / 0x14A78)
    if(CarryFlag) {
      goto label_1000_4A98_14A98;
    }
    State.IncCycles();
    // DEC BX (1000_4A7A / 0x14A7A)
    BX--;
    State.IncCycles();
    // DEC DX (1000_4A7B / 0x14A7B)
    DX--;
    State.IncCycles();
    // CMP DX,0xcc (1000_4A7C / 0x14A7C)
    Alu.Sub16(DX, 0xCC);
    State.IncCycles();
    // JL 0x1000:4a98 (1000_4A80 / 0x14A80)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    State.IncCycles();
    // CMP BX,0x4 (1000_4A82 / 0x14A82)
    Alu.Sub16(BX, 0x4);
    State.IncCycles();
    // JL 0x1000:4a98 (1000_4A85 / 0x14A85)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    State.IncCycles();
    // CMP DX,0x13a (1000_4A87 / 0x14A87)
    Alu.Sub16(DX, 0x13A);
    State.IncCycles();
    // JGE 0x1000:4a98 (1000_4A8B / 0x14A8B)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    State.IncCycles();
    // CMP BX,0x3a (1000_4A8D / 0x14A8D)
    Alu.Sub16(BX, 0x3A);
    State.IncCycles();
    // JGE 0x1000:4a98 (1000_4A90 / 0x14A90)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4A98_14A98;
    }
    State.IncCycles();
    // MOV AX,0x2f (1000_4A92 / 0x14A92)
    AX = 0x2F;
    State.IncCycles();
    // CALL 0x1000:c22f (1000_4A95 / 0x14A95)
    NearCall(cs1, 0x4A98, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_4A98_14A98:
    // POP SI (1000_4A98 / 0x14A98)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_4A99_14A99:
    // CMP SI,0xe85c (1000_4A99 / 0x14A99)
    Alu.Sub16(SI, 0xE85C);
    State.IncCycles();
    // JC 0x1000:4aa2 (1000_4A9D / 0x14A9D)
    if(CarryFlag) {
      goto label_1000_4AA2_14AA2;
    }
    State.IncCycles();
    // MOV SI,0xe40c (1000_4A9F / 0x14A9F)
    SI = 0xE40C;
    State.IncCycles();
    label_1000_4AA2_14AA2:
    // CMP SI,word ptr [0x149a] (1000_4AA2 / 0x14AA2)
    Alu.Sub16(SI, UInt16[DS, 0x149A]);
    State.IncCycles();
    // JNZ 0x1000:4a68 (1000_4AA6 / 0x14AA6)
    if(!ZeroFlag) {
      goto label_1000_4A68_14A68;
    }
    State.IncCycles();
    // POP word ptr [0xdbda] (1000_4AA8 / 0x14AA8)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    State.IncCycles();
    // RET  (1000_4AAC / 0x14AAC)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4AAD_014AAD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4AAD_14AAD:
    // XOR byte ptr [0x4728],0x80 (1000_4AAD / 0x14AAD)
    // UInt8[DS, 0x4728] ^= 0x80;
    UInt8[DS, 0x4728] = Alu.Xor8(UInt8[DS, 0x4728], 0x80);
    State.IncCycles();
    // JS 0x1000:4ab7 (1000_4AB2 / 0x14AB2)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4AB7 / 0x14AB7)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:49d4 (1000_4AB4 / 0x14AB4)
    NearCall(cs1, 0x4AB7, not_observed_1000_49D4_0149D4);
    State.IncCycles();
    label_1000_4AB7_14AB7:
    // RET  (1000_4AB7 / 0x14AB7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4AB8_014AB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4AB8_14AB8:
    // MOV byte ptr [0x4727],0xff (1000_4AB8 / 0x14AB8)
    UInt8[DS, 0x4727] = 0xFF;
    State.IncCycles();
    // RET  (1000_4ABD / 0x14ABD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4ABE_014ABE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4AC4_14AC4:
    // MOV byte ptr [0x11ca],0x0 (1000_4AC4 / 0x14AC4)
    UInt8[DS, 0x11CA] = 0x0;
    State.IncCycles();
    // RET  (1000_4AC9 / 0x14AC9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4ACA_014ACA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4ACA_14ACA:
    // MOV byte ptr [0x11ca],0x1 (1000_4ACA / 0x14ACA)
    UInt8[DS, 0x11CA] = 0x1;
    State.IncCycles();
    // RET  (1000_4ACF / 0x14ACF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4AD0_014AD0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4AD0_14AD0:
    // CALL 0x1000:4e8d (1000_4AD0 / 0x14AD0)
    NearCall(cs1, 0x4AD3, spice86_generated_label_call_target_1000_4E8D_014E8D);
    State.IncCycles();
    label_1000_4AD3_14AD3:
    // MOV AH,0xfc (1000_4AD3 / 0x14AD3)
    AH = 0xFC;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4AD7_14AD7:
    // CALL 0x1000:4e8d (1000_4AD7 / 0x14AD7)
    NearCall(cs1, 0x4ADA, spice86_generated_label_call_target_1000_4E8D_014E8D);
    State.IncCycles();
    label_1000_4ADA_14ADA:
    // MOV AH,0x4 (1000_4ADA / 0x14ADA)
    AH = 0x4;
    State.IncCycles();
    label_1000_4ADC_14ADC:
    // SHR AL,1 (1000_4ADC / 0x14ADC)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:4aea (1000_4ADE / 0x14ADE)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4AEA / 0x14AEA)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x11c8],0x1 (1000_4AE0 / 0x14AE0)
    UInt8[DS, 0x11C8] = 0x1;
    State.IncCycles();
    // MOV AL,AH (1000_4AE5 / 0x14AE5)
    AL = AH;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4AEB_14AEB:
    // MOV AX,0x39 (1000_4AEB / 0x14AEB)
    AX = 0x39;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_4AEE / 0x14AEE)
    NearCall(cs1, 0x4AF1, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // CALL 0x1000:c07c (1000_4AF1 / 0x14AF1)
    NearCall(cs1, 0x4AF4, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    // CALL 0x1000:4d6c (1000_4AF4 / 0x14AF4)
    NearCall(cs1, 0x4AF7, not_observed_1000_4D6C_014D6C);
    State.IncCycles();
    // CALL 0x1000:4b2b (1000_4AF7 / 0x14AF7)
    NearCall(cs1, 0x4AFA, spice86_generated_label_call_target_1000_4B2B_014B2B);
    State.IncCycles();
    // JMP 0x1000:c4dd (1000_4AFA / 0x14AFA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4DD_01C4DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_4AFD_14AFD:
    // CMP byte ptr [0x227d],0x0 (1000_4AFD / 0x14AFD)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:4b16 (1000_4B02 / 0x14B02)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_4B16_014B16, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4B07_14B07:
    // MOV ES,word ptr [0xdbd8] (1000_4B07 / 0x14B07)
    ES = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // MOV SI,word ptr [0xdbd6] (1000_4B0B / 0x14B0B)
    SI = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CALLF [0x38fd] (1000_4B0F / 0x14B0F)
    // Indirect call to [0x38fd], generating possible targets from emulator records
    uint targetAddress_1000_4B0F = (uint)(UInt16[DS, 0x38FF] * 0x10 + UInt16[DS, 0x38FD] - cs1 * 0x10);
    switch(targetAddress_1000_4B0F) {
      case 0x235E6 : FarCall(cs1, 0x4B13, spice86_generated_label_call_target_334B_0136_0335E6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4B0F));
        break;
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4B16_14B16:
    // MOV AX,[0xdbd8] (1000_4B16 / 0x14B16)
    AX = UInt16[DS, 0xDBD8];
    State.IncCycles();
    // MOV SI,word ptr [0xdbd6] (1000_4B19 / 0x14B19)
    SI = UInt16[DS, 0xDBD6];
    State.IncCycles();
    // CMP AX,SI (1000_4B1D / 0x14B1D)
    Alu.Sub16(AX, SI);
    State.IncCycles();
    // JZ 0x1000:4b2a (1000_4B1F / 0x14B1F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4B2A / 0x14B2A)
      return NearRet();
    }
    State.IncCycles();
    // ADD AX,0x1e0 (1000_4B21 / 0x14B21)
    // AX += 0x1E0;
    AX = Alu.Add16(AX, 0x1E0);
    State.IncCycles();
    // MOV ES,AX (1000_4B24 / 0x14B24)
    ES = AX;
    State.IncCycles();
    // CALLF [0x38fd] (1000_4B26 / 0x14B26)
    // Indirect call to [0x38fd], generating possible targets from emulator records
    uint targetAddress_1000_4B26 = (uint)(UInt16[DS, 0x38FF] * 0x10 + UInt16[DS, 0x38FD] - cs1 * 0x10);
    switch(targetAddress_1000_4B26) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4B26));
        break;
    }
    State.IncCycles();
    label_1000_4B2A_14B2A:
    // RET  (1000_4B2A / 0x14B2A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4B2B_014B2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4B2B_14B2B:
    // CMP byte ptr [0x4728],0x0 (1000_4B2B / 0x14B2B)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    State.IncCycles();
    // JS 0x1000:4b38 (1000_4B30 / 0x14B30)
    if(SignFlag) {
      // JS target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:dbca (1000_4B38 / 0x14B38)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_DBCA_01DBCA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV SI,0x1492 (1000_4B32 / 0x14B32)
    SI = 0x1492;
    State.IncCycles();
    // CALL 0x1000:c46f (1000_4B35 / 0x14B35)
    NearCall(cs1, 0x4B38, spice86_generated_label_call_target_1000_C46F_01C46F);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4B3B_14B3B:
    // INC word ptr [0x472b] (1000_4B3B / 0x14B3B)
    UInt16[DS, 0x472B]++;
    State.IncCycles();
    // TEST word ptr [0x472b],0xf (1000_4B3F / 0x14B3F)
    Alu.And16(UInt16[DS, 0x472B], 0xF);
    State.IncCycles();
    // JNZ 0x1000:4b4d (1000_4B45 / 0x14B45)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4B4D_014B4D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x1 (1000_4B47 / 0x14B47)
    CX = 0x1;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4B4D_14B4D:
    // CALL 0x1000:407e (1000_4B4D / 0x14B4D)
    NearCall(cs1, 0x4B50, spice86_generated_label_call_target_1000_407E_01407E);
    State.IncCycles();
    label_1000_4B50_14B50:
    // CALL 0x1000:5206 (1000_4B50 / 0x14B50)
    NearCall(cs1, 0x4B53, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4B53_14B53:
    // CALL 0x1000:40c3 (1000_4B53 / 0x14B53)
    NearCall(cs1, 0x4B56, spice86_generated_label_call_target_1000_40C3_0140C3);
    State.IncCycles();
    label_1000_4B56_14B56:
    // MOV word ptr [0x4],DX (1000_4B56 / 0x14B56)
    UInt16[DS, 0x4] = DX;
    State.IncCycles();
    // MOV word ptr [0x6],BX (1000_4B5A / 0x14B5A)
    UInt16[DS, 0x6] = BX;
    State.IncCycles();
    // RET  (1000_4B5E / 0x14B5E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4B5F_014B5F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4B5F_14B5F:
    // MOV SI,0x1470 (1000_4B5F / 0x14B5F)
    SI = 0x1470;
    State.IncCycles();
    // MOV AX,DX (1000_4B62 / 0x14B62)
    AX = DX;
    State.IncCycles();
    // ADD AX,word ptr [0x487a] (1000_4B64 / 0x14B64)
    AX += UInt16[DS, 0x487A];
    State.IncCycles();
    // CMP DX,word ptr [SI] (1000_4B68 / 0x14B68)
    Alu.Sub16(DX, UInt16[DS, SI]);
    State.IncCycles();
    // JGE 0x1000:4b6e (1000_4B6A / 0x14B6A)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4B6E_14B6E;
    }
    State.IncCycles();
    // MOV DX,word ptr [SI] (1000_4B6C / 0x14B6C)
    DX = UInt16[DS, SI];
    State.IncCycles();
    label_1000_4B6E_14B6E:
    // CMP DX,word ptr [SI + 0x4] (1000_4B6E / 0x14B6E)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JLE 0x1000:4b76 (1000_4B71 / 0x14B71)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4B76_14B76;
    }
    State.IncCycles();
    // MOV DX,word ptr [SI + 0x4] (1000_4B73 / 0x14B73)
    DX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    label_1000_4B76_14B76:
    // MOV word ptr [0x4860],DX (1000_4B76 / 0x14B76)
    UInt16[DS, 0x4860] = DX;
    State.IncCycles();
    // CMP AX,word ptr [SI] (1000_4B7A / 0x14B7A)
    Alu.Sub16(AX, UInt16[DS, SI]);
    State.IncCycles();
    // JGE 0x1000:4b80 (1000_4B7C / 0x14B7C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4B80_14B80;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_4B7E / 0x14B7E)
    AX = UInt16[DS, SI];
    State.IncCycles();
    label_1000_4B80_14B80:
    // CMP AX,word ptr [SI + 0x4] (1000_4B80 / 0x14B80)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    State.IncCycles();
    // JLE 0x1000:4b88 (1000_4B83 / 0x14B83)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4B88_14B88;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x4] (1000_4B85 / 0x14B85)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    label_1000_4B88_14B88:
    // MOV [0x4864],AX (1000_4B88 / 0x14B88)
    UInt16[DS, 0x4864] = AX;
    State.IncCycles();
    // MOV AX,BX (1000_4B8B / 0x14B8B)
    AX = BX;
    State.IncCycles();
    // ADD AX,word ptr [0x487c] (1000_4B8D / 0x14B8D)
    AX += UInt16[DS, 0x487C];
    State.IncCycles();
    // CMP BX,word ptr [SI + 0x2] (1000_4B91 / 0x14B91)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JGE 0x1000:4b99 (1000_4B94 / 0x14B94)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4B99_14B99;
    }
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x2] (1000_4B96 / 0x14B96)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    label_1000_4B99_14B99:
    // CMP BX,word ptr [SI + 0x6] (1000_4B99 / 0x14B99)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JLE 0x1000:4ba1 (1000_4B9C / 0x14B9C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4BA1_14BA1;
    }
    State.IncCycles();
    // MOV BX,word ptr [SI + 0x6] (1000_4B9E / 0x14B9E)
    BX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    label_1000_4BA1_14BA1:
    // MOV word ptr [0x4862],BX (1000_4BA1 / 0x14BA1)
    UInt16[DS, 0x4862] = BX;
    State.IncCycles();
    // CMP AX,word ptr [SI + 0x2] (1000_4BA5 / 0x14BA5)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JGE 0x1000:4bad (1000_4BA8 / 0x14BA8)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4BAD_14BAD;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_4BAA / 0x14BAA)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    label_1000_4BAD_14BAD:
    // CMP AX,word ptr [SI + 0x6] (1000_4BAD / 0x14BAD)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JLE 0x1000:4bb5 (1000_4BB0 / 0x14BB0)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4BB5_14BB5;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x6] (1000_4BB2 / 0x14BB2)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    State.IncCycles();
    label_1000_4BB5_14BB5:
    // MOV [0x4866],AX (1000_4BB5 / 0x14BB5)
    UInt16[DS, 0x4866] = AX;
    State.IncCycles();
    // RET  (1000_4BB8 / 0x14BB8)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4BDF_014BDF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4BDF_14BDF:
    // MOV AX,[0x485e] (1000_4BDF / 0x14BDF)
    AX = UInt16[DS, 0x485E];
    State.IncCycles();
    // CALL 0x1000:c13e (1000_4BE2 / 0x14BE2)
    NearCall(cs1, 0x4BE5, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // MOV AX,[0x4878] (1000_4BE5 / 0x14BE5)
    AX = UInt16[DS, 0x4878];
    State.IncCycles();
    // XOR AH,AH (1000_4BE8 / 0x14BE8)
    AH = 0;
    State.IncCycles();
    // ADD AX,word ptr [0x4874] (1000_4BEA / 0x14BEA)
    // AX += UInt16[DS, 0x4874];
    AX = Alu.Add16(AX, UInt16[DS, 0x4874]);
    State.IncCycles();
    // MOV [0x4878],AX (1000_4BEE / 0x14BEE)
    UInt16[DS, 0x4878] = AX;
    State.IncCycles();
    // MOV AL,AH (1000_4BF1 / 0x14BF1)
    AL = AH;
    State.IncCycles();
    // CBW  (1000_4BF3 / 0x14BF3)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD word ptr [0x4870],AX (1000_4BF4 / 0x14BF4)
    // UInt16[DS, 0x4870] += AX;
    UInt16[DS, 0x4870] = Alu.Add16(UInt16[DS, 0x4870], AX);
    State.IncCycles();
    // MOV AX,[0x4876] (1000_4BF8 / 0x14BF8)
    AX = UInt16[DS, 0x4876];
    State.IncCycles();
    // XOR AH,AH (1000_4BFB / 0x14BFB)
    AH = 0;
    State.IncCycles();
    // ADD AX,word ptr [0x4872] (1000_4BFD / 0x14BFD)
    // AX += UInt16[DS, 0x4872];
    AX = Alu.Add16(AX, UInt16[DS, 0x4872]);
    State.IncCycles();
    // MOV [0x4876],AX (1000_4C01 / 0x14C01)
    UInt16[DS, 0x4876] = AX;
    State.IncCycles();
    // MOV AL,AH (1000_4C04 / 0x14C04)
    AL = AH;
    State.IncCycles();
    // CBW  (1000_4C06 / 0x14C06)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // ADD word ptr [0x486e],AX (1000_4C07 / 0x14C07)
    // UInt16[DS, 0x486E] += AX;
    UInt16[DS, 0x486E] = Alu.Add16(UInt16[DS, 0x486E], AX);
    State.IncCycles();
    // MOV DX,word ptr [0x486e] (1000_4C0B / 0x14C0B)
    DX = UInt16[DS, 0x486E];
    State.IncCycles();
    // MOV BX,word ptr [0x4870] (1000_4C0F / 0x14C0F)
    BX = UInt16[DS, 0x4870];
    State.IncCycles();
    // CALL 0x1000:4b5f (1000_4C13 / 0x14C13)
    NearCall(cs1, 0x4C16, not_observed_1000_4B5F_014B5F);
    State.IncCycles();
    // MOV SI,word ptr [0x486a] (1000_4C16 / 0x14C16)
    SI = UInt16[DS, 0x486A];
    State.IncCycles();
    // MOV DS,word ptr SS:[0xdbb2] (1000_4C1A / 0x14C1A)
    DS = UInt16[SS, 0xDBB2];
    State.IncCycles();
    // CMP byte ptr [SI],0xff (1000_4C1F / 0x14C1F)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:4c29 (1000_4C22 / 0x14C22)
    if(!ZeroFlag) {
      goto label_1000_4C29_14C29;
    }
    State.IncCycles();
    // MOV SI,word ptr SS:[0x4868] (1000_4C24 / 0x14C24)
    SI = UInt16[SS, 0x4868];
    State.IncCycles();
    label_1000_4C29_14C29:
    // LODSB SI (1000_4C29 / 0x14C29)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_4C2A / 0x14C2A)
    AH = 0;
    State.IncCycles();
    // OR AL,AL (1000_4C2C / 0x14C2C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:4c3e (1000_4C2E / 0x14C2E)
    if(ZeroFlag) {
      goto label_1000_4C3E_14C3E;
    }
    State.IncCycles();
    // CMP AL,0x1 (1000_4C30 / 0x14C30)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:4c37 (1000_4C32 / 0x14C32)
    if(!ZeroFlag) {
      goto label_1000_4C37_14C37;
    }
    State.IncCycles();
    // MOV AH,AL (1000_4C34 / 0x14C34)
    AH = AL;
    State.IncCycles();
    // LODSB SI (1000_4C36 / 0x14C36)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_4C37_14C37:
    // PUSH SI (1000_4C37 / 0x14C37)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:4c45 (1000_4C38 / 0x14C38)
    NearCall(cs1, 0x4C3B, not_observed_1000_4C45_014C45);
    State.IncCycles();
    // POP SI (1000_4C3B / 0x14C3B)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4c29 (1000_4C3C / 0x14C3C)
    goto label_1000_4C29_14C29;
    State.IncCycles();
    label_1000_4C3E_14C3E:
    // PUSH SS (1000_4C3E / 0x14C3E)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_4C3F / 0x14C3F)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0x486a],SI (1000_4C40 / 0x14C40)
    UInt16[DS, 0x486A] = SI;
    State.IncCycles();
    // RET  (1000_4C44 / 0x14C44)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4C45_014C45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4C45_14C45:
    // SUB AX,0x2 (1000_4C45 / 0x14C45)
    AX -= 0x2;
    State.IncCycles();
    // SHL AX,1 (1000_4C48 / 0x14C48)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_4C4A / 0x14C4A)
    BP = AX;
    State.IncCycles();
    // MOV SI,word ptr SS:[0x486c] (1000_4C4C / 0x14C4C)
    SI = UInt16[SS, 0x486C];
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_4C51 / 0x14C51)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    label_1000_4C54_14C54:
    // LODSB SI (1000_4C54 / 0x14C54)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_4C55 / 0x14C55)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:4c91 (1000_4C57 / 0x14C57)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4C91 / 0x14C91)
      return NearRet();
    }
    State.IncCycles();
    // XOR AH,AH (1000_4C59 / 0x14C59)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_4C5B / 0x14C5B)
    BP = AX;
    State.IncCycles();
    // LODSB SI (1000_4C5D / 0x14C5D)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV DX,AX (1000_4C5E / 0x14C5E)
    DX = AX;
    State.IncCycles();
    // LODSB SI (1000_4C60 / 0x14C60)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV BX,AX (1000_4C61 / 0x14C61)
    BX = AX;
    State.IncCycles();
    // ADD DX,word ptr SS:[0x486e] (1000_4C63 / 0x14C63)
    DX += UInt16[SS, 0x486E];
    State.IncCycles();
    // ADD BX,word ptr SS:[0x4870] (1000_4C68 / 0x14C68)
    // BX += UInt16[SS, 0x4870];
    BX = Alu.Add16(BX, UInt16[SS, 0x4870]);
    State.IncCycles();
    // PUSH SI (1000_4C6D / 0x14C6D)
    Stack.Push(SI);
    State.IncCycles();
    // DEC BP (1000_4C6E / 0x14C6E)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // MOV ES,word ptr SS:[0xdbda] (1000_4C6F / 0x14C6F)
    ES = UInt16[SS, 0xDBDA];
    State.IncCycles();
    // MOV SI,word ptr SS:[0xdbb0] (1000_4C74 / 0x14C74)
    SI = UInt16[SS, 0xDBB0];
    State.IncCycles();
    // SHL BP,1 (1000_4C79 / 0x14C79)
    BP <<= 0x1;
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_4C7B / 0x14C7B)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // LODSW SI (1000_4C7E / 0x14C7E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_4C7F / 0x14C7F)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_4C81 / 0x14C81)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XOR AH,AH (1000_4C82 / 0x14C82)
    AH = 0;
    State.IncCycles();
    // MOV CX,AX (1000_4C84 / 0x14C84)
    CX = AX;
    State.IncCycles();
    // MOV BP,0x4860 (1000_4C86 / 0x14C86)
    BP = 0x4860;
    State.IncCycles();
    // CALLF [0x38cd] (1000_4C89 / 0x14C89)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_4C89 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_4C89) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4C89));
        break;
    }
    State.IncCycles();
    // POP SI (1000_4C8E / 0x14C8E)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4c54 (1000_4C8F / 0x14C8F)
    goto label_1000_4C54_14C54;
    State.IncCycles();
    label_1000_4C91_14C91:
    // RET  (1000_4C91 / 0x14C91)
    return NearRet();
  }
  
  public virtual Action split_1000_4C92_014C92(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4C92_14C92:
    // PUSH DS (1000_4C92 / 0x14C92)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH AX (1000_4C93 / 0x14C93)
    Stack.Push(AX);
    State.IncCycles();
    // XOR AH,AH (1000_4C94 / 0x14C94)
    AH = 0;
    State.IncCycles();
    // MOV [0x485e],AX (1000_4C96 / 0x14C96)
    UInt16[DS, 0x485E] = AX;
    State.IncCycles();
    // MOV word ptr [0x486e],DX (1000_4C99 / 0x14C99)
    UInt16[DS, 0x486E] = DX;
    State.IncCycles();
    // MOV word ptr [0x4870],BX (1000_4C9D / 0x14C9D)
    UInt16[DS, 0x4870] = BX;
    State.IncCycles();
    // MOV word ptr [0x4872],BP (1000_4CA1 / 0x14CA1)
    UInt16[DS, 0x4872] = BP;
    State.IncCycles();
    // MOV word ptr [0x4874],CX (1000_4CA5 / 0x14CA5)
    UInt16[DS, 0x4874] = CX;
    State.IncCycles();
    // MOV word ptr [0x4876],0x0 (1000_4CA9 / 0x14CA9)
    UInt16[DS, 0x4876] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x4878],0x0 (1000_4CAF / 0x14CAF)
    UInt16[DS, 0x4878] = 0x0;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_4CB5 / 0x14CB5)
    NearCall(cs1, 0x4CB8, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    // PUSH DS (1000_4CB8 / 0x14CB8)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_4CB9 / 0x14CB9)
    ES = Stack.Pop();
    State.IncCycles();
    // LDS SI,[0xdbb0] (1000_4CBA / 0x14CBA)
    DS = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    State.IncCycles();
    // MOV BX,word ptr [SI] (1000_4CBE / 0x14CBE)
    BX = UInt16[DS, SI];
    State.IncCycles();
    // ADD SI,word ptr [BX + SI + -0x2] (1000_4CC0 / 0x14CC0)
    // SI += UInt16[DS, (ushort)(BX + SI - 0x2)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BX + SI - 0x2)]);
    State.IncCycles();
    // MOV DI,0x4860 (1000_4CC3 / 0x14CC3)
    DI = 0x4860;
    State.IncCycles();
    // ADD SI,0x4 (1000_4CC6 / 0x14CC6)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LODSW SI (1000_4CC9 / 0x14CC9)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_4CCA / 0x14CCA)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_4CCC / 0x14CCC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_4CCD / 0x14CCD)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_4CCF / 0x14CCF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB AX,DX (1000_4CD0 / 0x14CD0)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    State.IncCycles();
    // MOV SS:[0x487a],AX (1000_4CD2 / 0x14CD2)
    UInt16[SS, 0x487A] = AX;
    State.IncCycles();
    // LODSW SI (1000_4CD6 / 0x14CD6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // SUB AX,BX (1000_4CD7 / 0x14CD7)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    State.IncCycles();
    // MOV SS:[0x487c],AX (1000_4CD9 / 0x14CD9)
    UInt16[SS, 0x487C] = AX;
    State.IncCycles();
    // MOV AX,SI (1000_4CDD / 0x14CDD)
    AX = SI;
    State.IncCycles();
    // ADD AX,0x2 (1000_4CDF / 0x14CDF)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    // MOV SS:[0x486c],AX (1000_4CE2 / 0x14CE2)
    UInt16[SS, 0x486C] = AX;
    State.IncCycles();
    // ADD SI,word ptr [SI] (1000_4CE6 / 0x14CE6)
    // SI += UInt16[DS, SI];
    SI = Alu.Add16(SI, UInt16[DS, SI]);
    State.IncCycles();
    // POP AX (1000_4CE8 / 0x14CE8)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV AL,AH (1000_4CE9 / 0x14CE9)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_4CEB / 0x14CEB)
    AH = 0;
    State.IncCycles();
    // SHL AX,1 (1000_4CED / 0x14CED)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_4CEF / 0x14CEF)
    BP = AX;
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_4CF1 / 0x14CF1)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // MOV word ptr SS:[0x4868],SI (1000_4CF4 / 0x14CF4)
    UInt16[SS, 0x4868] = SI;
    State.IncCycles();
    // MOV word ptr SS:[0x486a],SI (1000_4CF9 / 0x14CF9)
    UInt16[SS, 0x486A] = SI;
    State.IncCycles();
    // POP DS (1000_4CFE / 0x14CFE)
    DS = Stack.Pop();
    State.IncCycles();
    // RET  (1000_4CFF / 0x14CFF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4D00_014D00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4D00_14D00:
    // MOV SI,0x4bb9 (1000_4D00 / 0x14D00)
    SI = 0x4BB9;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4D06_14D06:
    // MOV byte ptr [0xf6],0x0 (1000_4D06 / 0x14D06)
    UInt8[DS, 0xF6] = 0x0;
    State.IncCycles();
    // MOV DI,word ptr [0x1150] (1000_4D0B / 0x14D0B)
    DI = UInt16[DS, 0x1150];
    State.IncCycles();
    // MOV DX,word ptr [DI + 0x2] (1000_4D0F / 0x14D0F)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // CMP DX,word ptr [0x4] (1000_4D12 / 0x14D12)
    Alu.Sub16(DX, UInt16[DS, 0x4]);
    State.IncCycles();
    // JNZ 0x1000:4d56 (1000_4D16 / 0x14D16)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x4733] (1000_4D18 / 0x14D18)
    AX = UInt16[DS, 0x4733];
    State.IncCycles();
    // OR AH,AH (1000_4D1B / 0x14D1B)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x1000:4d56 (1000_4D1D / 0x14D1D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_4D1F / 0x14D1F)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP BL,byte ptr [DI + 0x4] (1000_4D23 / 0x14D23)
    Alu.Sub8(BL, UInt8[DS, (ushort)(DI + 0x4)]);
    State.IncCycles();
    // JNZ 0x1000:4d56 (1000_4D26 / 0x14D26)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    State.IncCycles();
    // CMP BH,AH (1000_4D28 / 0x14D28)
    Alu.Sub8(BH, AH);
    State.IncCycles();
    // JA 0x1000:4d56 (1000_4D2A / 0x14D2A)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    State.IncCycles();
    // PUSH AX (1000_4D2C / 0x14D2C)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH BX (1000_4D2D / 0x14D2D)
    Stack.Push(BX);
    State.IncCycles();
    // INC byte ptr [0xf6] (1000_4D2E / 0x14D2E)
    UInt8[DS, 0xF6] = Alu.Inc8(UInt8[DS, 0xF6]);
    State.IncCycles();
    // MOV AH,0x1 (1000_4D32 / 0x14D32)
    AH = 0x1;
    State.IncCycles();
    // CALL 0x1000:4d57 (1000_4D34 / 0x14D34)
    NearCall(cs1, 0x4D37, not_observed_1000_4D57_014D57);
    State.IncCycles();
    // CALL 0x1000:4bdf (1000_4D37 / 0x14D37)
    NearCall(cs1, 0x4D3A, not_observed_1000_4BDF_014BDF);
    State.IncCycles();
    // CALL 0x1000:c412 (1000_4D3A / 0x14D3A)
    NearCall(cs1, 0x4D3D, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    // POP BX (1000_4D3D / 0x14D3D)
    BX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_4D3E / 0x14D3E)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP BH,AL (1000_4D3F / 0x14D3F)
    Alu.Sub8(BH, AL);
    State.IncCycles();
    // JA 0x1000:4d56 (1000_4D41 / 0x14D41)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4D56 / 0x14D56)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,0x5 (1000_4D43 / 0x14D43)
    AL = 0x5;
    State.IncCycles();
    // CALL 0x1000:ab15 (1000_4D45 / 0x14D45)
    NearCall(cs1, 0x4D48, spice86_generated_label_call_target_1000_AB15_01AB15);
    State.IncCycles();
    // XOR AH,AH (1000_4D48 / 0x14D48)
    AH = 0;
    State.IncCycles();
    // CALL 0x1000:4d57 (1000_4D4A / 0x14D4A)
    NearCall(cs1, 0x4D4D, not_observed_1000_4D57_014D57);
    State.IncCycles();
    // MOV SI,0x4bb9 (1000_4D4D / 0x14D4D)
    SI = 0x4BB9;
    State.IncCycles();
    // MOV BP,0x10 (1000_4D50 / 0x14D50)
    BP = 0x10;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_4D53 / 0x14D53)
    NearCall(cs1, 0x4D56, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    label_1000_4D56_14D56:
    // RET  (1000_4D56 / 0x14D56)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4D57_014D57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4D57_14D57:
    // MOV AL,0x31 (1000_4D57 / 0x14D57)
    AL = 0x31;
    State.IncCycles();
    // MOV DX,0x5 (1000_4D59 / 0x14D59)
    DX = 0x5;
    State.IncCycles();
    // SHL BH,1 (1000_4D5C / 0x14D5C)
    BH <<= 0x1;
    State.IncCycles();
    // SHL BH,1 (1000_4D5E / 0x14D5E)
    BH <<= 0x1;
    State.IncCycles();
    // ADD DL,BH (1000_4D60 / 0x14D60)
    // DL += BH;
    DL = Alu.Add8(DL, BH);
    State.IncCycles();
    // MOV BX,0x29 (1000_4D62 / 0x14D62)
    BX = 0x29;
    State.IncCycles();
    // XOR BP,BP (1000_4D65 / 0x14D65)
    BP = 0;
    State.IncCycles();
    // XOR CX,CX (1000_4D67 / 0x14D67)
    CX = 0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4D6C_14D6C:
    // MOV SI,word ptr [0xaa6e] (1000_4D6C / 0x14D6C)
    SI = UInt16[DS, 0xAA6E];
    State.IncCycles();
    // CMP byte ptr CS:[SI],0xff (1000_4D70 / 0x14D70)
    Alu.Sub8(UInt8[cs1, SI], 0xFF);
    State.IncCycles();
    // JNZ 0x1000:4d82 (1000_4D74 / 0x14D74)
    if(!ZeroFlag) {
      goto label_1000_4D82_14D82;
    }
    State.IncCycles();
    // MOV SI,word ptr CS:[0x167] (1000_4D76 / 0x14D76)
    SI = UInt16[cs1, 0x167];
    State.IncCycles();
    // ADD SI,word ptr CS:[SI] (1000_4D7B / 0x14D7B)
    // SI += UInt16[cs1, SI];
    SI = Alu.Add16(SI, UInt16[cs1, SI]);
    State.IncCycles();
    // MOV word ptr [0xaa6e],SI (1000_4D7E / 0x14D7E)
    UInt16[DS, 0xAA6E] = SI;
    State.IncCycles();
    label_1000_4D82_14D82:
    // PUSH CS (1000_4D82 / 0x14D82)
    Stack.Push(cs1);
    State.IncCycles();
    // POP DS (1000_4D83 / 0x14D83)
    DS = Stack.Pop();
    State.IncCycles();
    label_1000_4D84_14D84:
    // LODSB SI (1000_4D84 / 0x14D84)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_4D85 / 0x14D85)
    AH = 0;
    State.IncCycles();
    // OR AL,AL (1000_4D87 / 0x14D87)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:4d99 (1000_4D89 / 0x14D89)
    if(ZeroFlag) {
      goto label_1000_4D99_14D99;
    }
    State.IncCycles();
    // CMP AL,0x1 (1000_4D8B / 0x14D8B)
    Alu.Sub8(AL, 0x1);
    State.IncCycles();
    // JNZ 0x1000:4d92 (1000_4D8D / 0x14D8D)
    if(!ZeroFlag) {
      goto label_1000_4D92_14D92;
    }
    State.IncCycles();
    // MOV AH,AL (1000_4D8F / 0x14D8F)
    AH = AL;
    State.IncCycles();
    // LODSB SI (1000_4D91 / 0x14D91)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_4D92_14D92:
    // PUSH SI (1000_4D92 / 0x14D92)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:4da0 (1000_4D93 / 0x14D93)
    NearCall(cs1, 0x4D96, not_observed_1000_4DA0_014DA0);
    State.IncCycles();
    // POP SI (1000_4D96 / 0x14D96)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4d84 (1000_4D97 / 0x14D97)
    goto label_1000_4D84_14D84;
    State.IncCycles();
    label_1000_4D99_14D99:
    // PUSH SS (1000_4D99 / 0x14D99)
    Stack.Push(SS);
    State.IncCycles();
    // POP DS (1000_4D9A / 0x14D9A)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV word ptr [0xaa6e],SI (1000_4D9B / 0x14D9B)
    UInt16[DS, 0xAA6E] = SI;
    State.IncCycles();
    // RET  (1000_4D9F / 0x14D9F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_4DA0_014DA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4DA0_14DA0:
    // SUB AX,0x2 (1000_4DA0 / 0x14DA0)
    AX -= 0x2;
    State.IncCycles();
    // SHL AX,1 (1000_4DA3 / 0x14DA3)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV BP,AX (1000_4DA5 / 0x14DA5)
    BP = AX;
    State.IncCycles();
    // MOV SI,0x169 (1000_4DA7 / 0x14DA7)
    SI = 0x169;
    State.IncCycles();
    // ADD SI,word ptr CS:[BP + SI] (1000_4DAA / 0x14DAA)
    // SI += UInt16[cs1, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[cs1, (ushort)(BP + SI)]);
    State.IncCycles();
    label_1000_4DAD_14DAD:
    // LODSB SI (1000_4DAD / 0x14DAD)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // OR AL,AL (1000_4DAE / 0x14DAE)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:4dec (1000_4DB0 / 0x14DB0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4DEC / 0x14DEC)
      return NearRet();
    }
    State.IncCycles();
    // XOR AH,AH (1000_4DB2 / 0x14DB2)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_4DB4 / 0x14DB4)
    BP = AX;
    State.IncCycles();
    // LODSB SI (1000_4DB6 / 0x14DB6)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV DX,AX (1000_4DB7 / 0x14DB7)
    DX = AX;
    State.IncCycles();
    // LODSB SI (1000_4DB9 / 0x14DB9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV BX,AX (1000_4DBA / 0x14DBA)
    BX = AX;
    State.IncCycles();
    // ADD DX,word ptr SS:[0xaa66] (1000_4DBC / 0x14DBC)
    DX += UInt16[SS, 0xAA66];
    State.IncCycles();
    // ADD BX,word ptr SS:[0xaa68] (1000_4DC1 / 0x14DC1)
    // BX += UInt16[SS, 0xAA68];
    BX = Alu.Add16(BX, UInt16[SS, 0xAA68]);
    State.IncCycles();
    // PUSH SI (1000_4DC6 / 0x14DC6)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_4DC7 / 0x14DC7)
    Stack.Push(DS);
    State.IncCycles();
    // DEC BP (1000_4DC8 / 0x14DC8)
    BP = Alu.Dec16(BP);
    State.IncCycles();
    // MOV ES,word ptr SS:[0xdbda] (1000_4DC9 / 0x14DC9)
    ES = UInt16[SS, 0xDBDA];
    State.IncCycles();
    // LDS SI,SS:[0xdbb0] (1000_4DCE / 0x14DCE)
    DS = UInt16[SS, 0xDBB2];
    SI = UInt16[SS, 0xDBB0];
    State.IncCycles();
    // SHL BP,1 (1000_4DD3 / 0x14DD3)
    BP <<= 0x1;
    State.IncCycles();
    // ADD SI,word ptr DS:[BP + SI] (1000_4DD5 / 0x14DD5)
    // SI += UInt16[DS, (ushort)(BP + SI)];
    SI = Alu.Add16(SI, UInt16[DS, (ushort)(BP + SI)]);
    State.IncCycles();
    // LODSW SI (1000_4DD8 / 0x14DD8)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_4DD9 / 0x14DD9)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_4DDB / 0x14DDB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XOR AH,AH (1000_4DDC / 0x14DDC)
    AH = 0;
    State.IncCycles();
    // MOV CX,AX (1000_4DDE / 0x14DDE)
    CX = AX;
    State.IncCycles();
    // MOV BP,0xaa66 (1000_4DE0 / 0x14DE0)
    BP = 0xAA66;
    State.IncCycles();
    // CALLF [0x38cd] (1000_4DE3 / 0x14DE3)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_4DE3 = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_4DE3) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_4DE3));
        break;
    }
    State.IncCycles();
    // POP DS (1000_4DE8 / 0x14DE8)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_4DE9 / 0x14DE9)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4dad (1000_4DEA / 0x14DEA)
    goto label_1000_4DAD_14DAD;
    State.IncCycles();
    label_1000_4DEC_14DEC:
    // RET  (1000_4DEC / 0x14DEC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4DED_014DED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4DED_14DED:
    // XOR CX,CX (1000_4DED / 0x14DED)
    CX = 0;
    State.IncCycles();
    // MOV BP,0x4e04 (1000_4DEF / 0x14DEF)
    BP = 0x4E04;
    State.IncCycles();
    // PUSH SI (1000_4DF2 / 0x14DF2)
    Stack.Push(SI);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4DF6_14DF6:
    // MOV CH,byte ptr [DI + 0x14] (1000_4DF6 / 0x14DF6)
    CH = UInt8[DS, (ushort)(DI + 0x14)];
    State.IncCycles();
    // MOV word ptr [0x4733],CX (1000_4DF9 / 0x14DF9)
    UInt16[DS, 0x4733] = CX;
    State.IncCycles();
    // PUSH ES (1000_4DFD / 0x14DFD)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:7f27 (1000_4DFE / 0x14DFE)
    NearCall(cs1, 0x4E01, spice86_generated_label_call_target_1000_7F27_017F27);
    State.IncCycles();
    label_1000_4E01_14E01:
    // POP ES (1000_4E01 / 0x14E01)
    ES = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_4E02 / 0x14E02)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_4E03 / 0x14E03)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4E04_014E04(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4E04_14E04:
    // CMP byte ptr [SI + 0x3],0x0 (1000_4E04 / 0x14E04)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x0);
    State.IncCycles();
    // JNZ 0x1000:4e11 (1000_4E08 / 0x14E08)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4E11 / 0x14E11)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x19],0x80 (1000_4E0A / 0x14E0A)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x19)], 0x80);
    State.IncCycles();
    // JZ 0x1000:4e11 (1000_4E0E / 0x14E0E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4E11 / 0x14E11)
      return NearRet();
    }
    State.IncCycles();
    // INC CX (1000_4E10 / 0x14E10)
    CX = Alu.Inc16(CX);
    State.IncCycles();
    label_1000_4E11_14E11:
    // RET  (1000_4E11 / 0x14E11)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4E12_014E12(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4E12_14E12:
    // MOV word ptr [0x4733],0x0 (1000_4E12 / 0x14E12)
    UInt16[DS, 0x4733] = 0x0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4E1B_14E1B:
    // CALL 0x1000:b532 (1000_4E1B / 0x14E1B)
    NearCall(cs1, 0x4E1E, spice86_generated_label_call_target_1000_B532_01B532);
    State.IncCycles();
    label_1000_4E1E_14E1E:
    // PUSH AX (1000_4E1E / 0x14E1E)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:4ec6 (1000_4E1F / 0x14E1F)
    NearCall(cs1, 0x4E22, spice86_generated_label_call_target_1000_4EC6_014EC6);
    State.IncCycles();
    label_1000_4E22_14E22:
    // MOV word ptr [0x196a],0x0 (1000_4E22 / 0x14E22)
    UInt16[DS, 0x196A] = 0x0;
    State.IncCycles();
    // POP AX (1000_4E28 / 0x14E28)
    AX = Stack.Pop();
    State.IncCycles();
    // TEST AL,0x40 (1000_4E29 / 0x14E29)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:4e78 (1000_4E2B / 0x14E2B)
    if(ZeroFlag) {
      goto label_1000_4E78_14E78;
    }
    State.IncCycles();
    // CALL 0x1000:409a (1000_4E2D / 0x14E2D)
    NearCall(cs1, 0x4E30, spice86_generated_label_call_target_1000_409A_01409A);
    State.IncCycles();
    label_1000_4E30_14E30:
    // JNZ 0x1000:4e78 (1000_4E30 / 0x14E30)
    if(!ZeroFlag) {
      goto label_1000_4E78_14E78;
    }
    State.IncCycles();
    // CMP byte ptr [0x6],0x80 (1000_4E32 / 0x14E32)
    Alu.Sub8(UInt8[DS, 0x6], 0x80);
    State.IncCycles();
    // JZ 0x1000:4e78 (1000_4E37 / 0x14E37)
    if(ZeroFlag) {
      goto label_1000_4E78_14E78;
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x2] (1000_4E39 / 0x14E39)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    State.IncCycles();
    // SUB AX,DX (1000_4E3C / 0x14E3C)
    AX -= DX;
    State.IncCycles();
    // ADD AX,0x4 (1000_4E3E / 0x14E3E)
    AX += 0x4;
    State.IncCycles();
    // CMP AX,0x8 (1000_4E41 / 0x14E41)
    Alu.Sub16(AX, 0x8);
    State.IncCycles();
    // JNC 0x1000:4e78 (1000_4E44 / 0x14E44)
    if(!CarryFlag) {
      goto label_1000_4E78_14E78;
    }
    State.IncCycles();
    // MOV [0x1968],AX (1000_4E46 / 0x14E46)
    UInt16[DS, 0x1968] = AX;
    State.IncCycles();
    // INC AX (1000_4E49 / 0x14E49)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0x1964],AX (1000_4E4A / 0x14E4A)
    UInt16[DS, 0x1964] = AX;
    State.IncCycles();
    // SUB AX,0x2 (1000_4E4D / 0x14E4D)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // MOV [0x1960],AX (1000_4E50 / 0x14E50)
    UInt16[DS, 0x1960] = AX;
    State.IncCycles();
    // XOR AX,AX (1000_4E53 / 0x14E53)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:5e4f (1000_4E55 / 0x14E55)
    NearCall(cs1, 0x4E58, spice86_generated_label_call_target_1000_5E4F_015E4F);
    State.IncCycles();
    label_1000_4E58_14E58:
    // MOV BX,0x196d (1000_4E58 / 0x14E58)
    BX = 0x196D;
    State.IncCycles();
    // XLAT BX (1000_4E5B / 0x14E5B)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // CMP AL,0x13 (1000_4E5C / 0x14E5C)
    Alu.Sub8(AL, 0x13);
    State.IncCycles();
    // JC 0x1000:4e6e (1000_4E5E / 0x14E5E)
    if(CarryFlag) {
      goto label_1000_4E6E_14E6E;
    }
    State.IncCycles();
    // SUB CL,0x28 (1000_4E60 / 0x14E60)
    CL -= 0x28;
    State.IncCycles();
    // AND CL,0xfb (1000_4E63 / 0x14E63)
    CL &= 0xFB;
    State.IncCycles();
    // ADD AL,CL (1000_4E66 / 0x14E66)
    AL += CL;
    State.IncCycles();
    // CMP AL,0x17 (1000_4E68 / 0x14E68)
    Alu.Sub8(AL, 0x17);
    State.IncCycles();
    // JC 0x1000:4e6e (1000_4E6A / 0x14E6A)
    if(CarryFlag) {
      goto label_1000_4E6E_14E6E;
    }
    State.IncCycles();
    // MOV AL,0x17 (1000_4E6C / 0x14E6C)
    AL = 0x17;
    State.IncCycles();
    label_1000_4E6E_14E6E:
    // MOV [0x196a],AX (1000_4E6E / 0x14E6E)
    UInt16[DS, 0x196A] = AX;
    State.IncCycles();
    // XCHG DI,SI (1000_4E71 / 0x14E71)
    ushort tmp_1000_4E71 = DI;
    DI = SI;
    SI = tmp_1000_4E71;
    State.IncCycles();
    // CALL 0x1000:4ded (1000_4E73 / 0x14E73)
    NearCall(cs1, 0x4E76, spice86_generated_label_call_target_1000_4DED_014DED);
    State.IncCycles();
    label_1000_4E76_14E76:
    // XCHG DI,SI (1000_4E76 / 0x14E76)
    ushort tmp_1000_4E76 = DI;
    DI = SI;
    SI = tmp_1000_4E76;
    State.IncCycles();
    label_1000_4E78_14E78:
    // MOV AX,[0x196a] (1000_4E78 / 0x14E78)
    AX = UInt16[DS, 0x196A];
    State.IncCycles();
    // OR AX,AX (1000_4E7B / 0x14E7B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:4e8c (1000_4E7D / 0x14E7D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4E8C / 0x14E8C)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,word ptr [0x4733] (1000_4E7F / 0x14E7F)
    CX = UInt16[DS, 0x4733];
    State.IncCycles();
    // MOV CL,byte ptr [0x46ff] (1000_4E83 / 0x14E83)
    CL = UInt8[DS, 0x46FF];
    State.IncCycles();
    // XOR CH,CH (1000_4E87 / 0x14E87)
    CH = 0;
    State.IncCycles();
    // JCXZ 0x1000:4e8c (1000_4E89 / 0x14E89)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4E8C / 0x14E8C)
      return NearRet();
    }
    State.IncCycles();
    // NOP  (1000_4E8B / 0x14E8B)
    
    State.IncCycles();
    label_1000_4E8C_14E8C:
    // RET  (1000_4E8C / 0x14E8C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4E8D_014E8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4E8D_14E8D:
    // RET  (1000_4E8D / 0x14E8D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4E8E_014E8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4E8E_14E8E:
    // MOV DX,word ptr [0x4] (1000_4E8E / 0x14E8E)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_4E92 / 0x14E92)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // PUSH word ptr [0x11cc] (1000_4E96 / 0x14E96)
    Stack.Push(UInt16[DS, 0x11CC]);
    State.IncCycles();
    // CALL 0x1000:5206 (1000_4E9A / 0x14E9A)
    NearCall(cs1, 0x4E9D, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4E9D_14E9D:
    // CALL 0x1000:5206 (1000_4E9D / 0x14E9D)
    NearCall(cs1, 0x4EA0, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4EA0_14EA0:
    // CALL 0x1000:5206 (1000_4EA0 / 0x14EA0)
    NearCall(cs1, 0x4EA3, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4EA3_14EA3:
    // CALL 0x1000:5206 (1000_4EA3 / 0x14EA3)
    NearCall(cs1, 0x4EA6, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4EA6_14EA6:
    // CALL 0x1000:5206 (1000_4EA6 / 0x14EA6)
    NearCall(cs1, 0x4EA9, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4EA9_14EA9:
    // CALL 0x1000:5206 (1000_4EA9 / 0x14EA9)
    NearCall(cs1, 0x4EAC, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4EAC_14EAC:
    // CALL 0x1000:b532 (1000_4EAC / 0x14EAC)
    NearCall(cs1, 0x4EAF, spice86_generated_label_call_target_1000_B532_01B532);
    State.IncCycles();
    label_1000_4EAF_14EAF:
    // PUSH AX (1000_4EAF / 0x14EAF)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:5206 (1000_4EB0 / 0x14EB0)
    NearCall(cs1, 0x4EB3, spice86_generated_label_call_target_1000_5206_015206);
    State.IncCycles();
    label_1000_4EB3_14EB3:
    // POP AX (1000_4EB3 / 0x14EB3)
    AX = Stack.Pop();
    State.IncCycles();
    // POP word ptr [0x11cc] (1000_4EB4 / 0x14EB4)
    UInt16[DS, 0x11CC] = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_4EB8 / 0x14EB8)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:b532 (1000_4EB9 / 0x14EB9)
    NearCall(cs1, 0x4EBC, spice86_generated_label_call_target_1000_B532_01B532);
    State.IncCycles();
    label_1000_4EBC_14EBC:
    // PUSH AX (1000_4EBC / 0x14EBC)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:41e1 (1000_4EBD / 0x14EBD)
    NearCall(cs1, 0x4EC0, spice86_generated_label_call_target_1000_41E1_0141E1);
    State.IncCycles();
    label_1000_4EC0_14EC0:
    // POP AX (1000_4EC0 / 0x14EC0)
    AX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_4EC1 / 0x14EC1)
    BX = Stack.Pop();
    State.IncCycles();
    // ADD AL,BL (1000_4EC2 / 0x14EC2)
    AL += BL;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4EC6_14EC6:
    // PUSH BX (1000_4EC6 / 0x14EC6)
    Stack.Push(BX);
    State.IncCycles();
    // MOV BX,word ptr [0x487e] (1000_4EC7 / 0x14EC7)
    BX = UInt16[DS, 0x487E];
    State.IncCycles();
    // CMP BX,0x2 (1000_4ECB / 0x14ECB)
    Alu.Sub16(BX, 0x2);
    State.IncCycles();
    // JC 0x1000:4eed (1000_4ECE / 0x14ECE)
    if(CarryFlag) {
      goto label_1000_4EED_14EED;
    }
    State.IncCycles();
    // AND AL,0xf (1000_4ED0 / 0x14ED0)
    AL &= 0xF;
    State.IncCycles();
    // CMP AL,0x8 (1000_4ED2 / 0x14ED2)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // MOV AX,[0xdc00] (1000_4ED4 / 0x14ED4)
    AX = UInt16[DS, 0xDC00];
    State.IncCycles();
    // JNC 0x1000:4ef3 (1000_4ED7 / 0x14ED7)
    if(!CarryFlag) {
      goto label_1000_4EF3_14EF3;
    }
    State.IncCycles();
    // CMP AX,0x2 (1000_4ED9 / 0x14ED9)
    Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // JBE 0x1000:4eed (1000_4EDC / 0x14EDC)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4EED_14EED;
    }
    State.IncCycles();
    // MOV BX,0x5 (1000_4EDE / 0x14EDE)
    BX = 0x5;
    State.IncCycles();
    // CMP AX,0x4 (1000_4EE1 / 0x14EE1)
    Alu.Sub16(AX, 0x4);
    State.IncCycles();
    // JBE 0x1000:4eed (1000_4EE4 / 0x14EE4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4EED_14EED;
    }
    State.IncCycles();
    // MOV BX,0x2 (1000_4EE6 / 0x14EE6)
    BX = 0x2;
    State.IncCycles();
    // MOV word ptr [0x487e],BX (1000_4EE9 / 0x14EE9)
    UInt16[DS, 0x487E] = BX;
    State.IncCycles();
    label_1000_4EED_14EED:
    // MOV word ptr [0xdc02],BX (1000_4EED / 0x14EED)
    UInt16[DS, 0xDC02] = BX;
    State.IncCycles();
    // POP BX (1000_4EF1 / 0x14EF1)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_4EF2 / 0x14EF2)
    return NearRet();
    State.IncCycles();
    label_1000_4EF3_14EF3:
    // MOV BX,0x3 (1000_4EF3 / 0x14EF3)
    BX = 0x3;
    State.IncCycles();
    // CMP AX,0x2 (1000_4EF6 / 0x14EF6)
    Alu.Sub16(AX, 0x2);
    State.IncCycles();
    // JBE 0x1000:4f03 (1000_4EF9 / 0x14EF9)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4F03_14F03;
    }
    State.IncCycles();
    // CMP AX,0x5 (1000_4EFB / 0x14EFB)
    Alu.Sub16(AX, 0x5);
    State.IncCycles();
    // JZ 0x1000:4f03 (1000_4EFE / 0x14EFE)
    if(ZeroFlag) {
      goto label_1000_4F03_14F03;
    }
    State.IncCycles();
    // MOV BX,0x4 (1000_4F00 / 0x14F00)
    BX = 0x4;
    State.IncCycles();
    label_1000_4F03_14F03:
    // MOV word ptr [0xdc02],BX (1000_4F03 / 0x14F03)
    UInt16[DS, 0xDC02] = BX;
    State.IncCycles();
    // POP BX (1000_4F07 / 0x14F07)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_4F08 / 0x14F08)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_4F0C_014F0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4F0C_14F0C:
    // CMP byte ptr [0x4727],0x0 (1000_4F0C / 0x14F0C)
    Alu.Sub8(UInt8[DS, 0x4727], 0x0);
    State.IncCycles();
    // JZ 0x1000:4f33 (1000_4F11 / 0x14F11)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x11ca],0x0 (1000_4F13 / 0x14F13)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:4f33 (1000_4F18 / 0x14F18)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    State.IncCycles();
    // MOV word ptr [0x1c06],0x80 (1000_4F1A / 0x14F1A)
    UInt16[DS, 0x1C06] = 0x80;
    State.IncCycles();
    // MOV AX,0xdbec (1000_4F20 / 0x14F20)
    AX = 0xDBEC;
    State.IncCycles();
    // PUSH AX (1000_4F23 / 0x14F23)
    Stack.Push(AX);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_4F27_14F27:
    // MOV AX,[0xce7a] (1000_4F27 / 0x14F27)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,word ptr [0x4729] (1000_4F2A / 0x14F2A)
    AX -= UInt16[DS, 0x4729];
    State.IncCycles();
    // CMP AX,0x300 (1000_4F2E / 0x14F2E)
    Alu.Sub16(AX, 0x300);
    State.IncCycles();
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
  
  public virtual Action spice86_generated_label_jump_target_1000_4F33_014F33(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4F33_14F33:
    // RET  (1000_4F33 / 0x14F33)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4F34_014F34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4F34_14F34:
    // MOV AX,[0xce7a] (1000_4F34 / 0x14F34)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // MOV [0x4729],AX (1000_4F37 / 0x14F37)
    UInt16[DS, 0x4729] = AX;
    State.IncCycles();
    // CALL 0x1000:4b3b (1000_4F3A / 0x14F3A)
    NearCall(cs1, 0x4F3D, spice86_generated_label_call_target_1000_4B3B_014B3B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F3D_014F3D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_4F3D_014F3D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x4FC3: goto label_1000_4FC3_14FC3;break; // Target of external jump from 0x1503A
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_4F3D_14F3D:
    // CALL 0x1000:4a1a (1000_4F3D / 0x14F3D)
    NearCall(cs1, 0x4F40, spice86_generated_label_call_target_1000_4A1A_014A1A);
    State.IncCycles();
    label_1000_4F40_14F40:
    // CALL 0x1000:407e (1000_4F40 / 0x14F40)
    NearCall(cs1, 0x4F43, spice86_generated_label_call_target_1000_407E_01407E);
    State.IncCycles();
    label_1000_4F43_14F43:
    // CALL 0x1000:4a00 (1000_4F43 / 0x14F43)
    NearCall(cs1, 0x4F46, spice86_generated_label_call_target_1000_4A00_014A00);
    State.IncCycles();
    label_1000_4F46_14F46:
    // CALL 0x1000:b58b (1000_4F46 / 0x14F46)
    NearCall(cs1, 0x4F49, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    label_1000_4F49_14F49:
    // MOV SI,word ptr [0x11c5] (1000_4F49 / 0x14F49)
    SI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // CMP DI,word ptr [SI + 0x6] (1000_4F4D / 0x14F4D)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JZ 0x1000:4fb0 (1000_4F50 / 0x14F50)
    if(ZeroFlag) {
      goto label_1000_4FB0_14FB0;
    }
    State.IncCycles();
    // CALL 0x1000:2e52 (1000_4F52 / 0x14F52)
    NearCall(cs1, 0x4F55, spice86_generated_label_ret_target_1000_2E52_012E52);
    State.IncCycles();
    label_1000_4F55_14F55:
    // CMP byte ptr [0x47a7],0x0 (1000_4F55 / 0x14F55)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    State.IncCycles();
    // JNZ 0x1000:4f33 (1000_4F5A / 0x14F5A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_4F33 / 0x14F33)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x4728],0x0 (1000_4F5C / 0x14F5C)
    Alu.Sub8(UInt8[DS, 0x4728], 0x0);
    State.IncCycles();
    // JS 0x1000:4fad (1000_4F61 / 0x14F61)
    if(SignFlag) {
      // JS target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JZ 0x1000:4f70 (1000_4F63 / 0x14F63)
    if(ZeroFlag) {
      goto label_1000_4F70_14F70;
    }
    State.IncCycles();
    // MOV byte ptr [0x4728],0x0 (1000_4F65 / 0x14F65)
    UInt8[DS, 0x4728] = 0x0;
    State.IncCycles();
    // CALL 0x1000:5b5d (1000_4F6A / 0x14F6A)
    NearCall(cs1, 0x4F6D, spice86_generated_label_call_target_1000_5B5D_015B5D);
    State.IncCycles();
    // CALL 0x1000:49d9 (1000_4F6D / 0x14F6D)
    NearCall(cs1, 0x4F70, not_observed_1000_49D9_0149D9);
    State.IncCycles();
    label_1000_4F70_14F70:
    // CALL 0x1000:407e (1000_4F70 / 0x14F70)
    NearCall(cs1, 0x4F73, spice86_generated_label_call_target_1000_407E_01407E);
    State.IncCycles();
    label_1000_4F73_14F73:
    // CALL 0x1000:62d6 (1000_4F73 / 0x14F73)
    NearCall(cs1, 0x4F76, spice86_generated_label_call_target_1000_62D6_0162D6);
    State.IncCycles();
    label_1000_4F76_14F76:
    // JC 0x1000:4fad (1000_4F76 / 0x14F76)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP DX,0xd6 (1000_4F78 / 0x14F78)
    Alu.Sub16(DX, 0xD6);
    State.IncCycles();
    // JL 0x1000:4f8e (1000_4F7C / 0x14F7C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    State.IncCycles();
    // CMP BX,0xa (1000_4F7E / 0x14F7E)
    Alu.Sub16(BX, 0xA);
    State.IncCycles();
    // JL 0x1000:4f8e (1000_4F81 / 0x14F81)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    State.IncCycles();
    // CMP DX,0x132 (1000_4F83 / 0x14F83)
    Alu.Sub16(DX, 0x132);
    State.IncCycles();
    // JGE 0x1000:4f8e (1000_4F87 / 0x14F87)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4F8E_14F8E;
    }
    State.IncCycles();
    // CMP BX,0x36 (1000_4F89 / 0x14F89)
    Alu.Sub16(BX, 0x36);
    State.IncCycles();
    // JL 0x1000:4f95 (1000_4F8C / 0x14F8C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4F95_14F95;
    }
    State.IncCycles();
    label_1000_4F8E_14F8E:
    // MOV byte ptr [0x4728],0x1 (1000_4F8E / 0x14F8E)
    UInt8[DS, 0x4728] = 0x1;
    State.IncCycles();
    // JMP 0x1000:4fad (1000_4F93 / 0x14F93)
    // JMP target is JMP, inlining.
    State.IncCycles();
    // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_4F95_14F95:
    // CMP byte ptr [0x11ca],0x0 (1000_4F95 / 0x14F95)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    State.IncCycles();
    // JNZ 0x1000:4fad (1000_4F9A / 0x14F9A)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC BX (1000_4F9C / 0x14F9C)
    BX--;
    State.IncCycles();
    // DEC DX (1000_4F9D / 0x14F9D)
    DX = Alu.Dec16(DX);
    State.IncCycles();
    // CALL 0x1000:c137 (1000_4F9E / 0x14F9E)
    NearCall(cs1, 0x4FA1, spice86_generated_label_call_target_1000_C137_01C137);
    State.IncCycles();
    label_1000_4FA1_14FA1:
    // MOV AX,0x30 (1000_4FA1 / 0x14FA1)
    AX = 0x30;
    State.IncCycles();
    // CALL 0x1000:c085 (1000_4FA4 / 0x14FA4)
    NearCall(cs1, 0x4FA7, spice86_generated_label_call_target_1000_C085_01C085);
    State.IncCycles();
    label_1000_4FA7_14FA7:
    // CALL 0x1000:c22f (1000_4FA7 / 0x14FA7)
    NearCall(cs1, 0x4FAA, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_4FAA_14FAA:
    // CALL 0x1000:c07c (1000_4FAA / 0x14FAA)
    NearCall(cs1, 0x4FAD, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_4FAD_14FAD:
    // JMP 0x1000:4e8e (1000_4FAD / 0x14FAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4E8E_014E8E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_4FB0_14FB0:
    // MOV word ptr [0x1c06],0x0 (1000_4FB0 / 0x14FB0)
    UInt16[DS, 0x1C06] = 0x0;
    State.IncCycles();
    // MOV AL,[0x11c9] (1000_4FB6 / 0x14FB6)
    AL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // AND AL,0x1 (1000_4FB9 / 0x14FB9)
    // AL &= 0x1;
    AL = Alu.And8(AL, 0x1);
    State.IncCycles();
    // MOV [0x4732],AL (1000_4FBB / 0x14FBB)
    UInt8[DS, 0x4732] = AL;
    State.IncCycles();
    // JNZ 0x1000:4fc3 (1000_4FBE / 0x14FBE)
    if(!ZeroFlag) {
      goto label_1000_4FC3_14FC3;
    }
    State.IncCycles();
    // CALL 0x1000:ca01 (1000_4FC0 / 0x14FC0)
    NearCall(cs1, 0x4FC3, spice86_generated_label_call_target_1000_CA01_01CA01);
    State.IncCycles();
    label_1000_4FC3_14FC3:
    // CALL 0x1000:e3cc (1000_4FC3 / 0x14FC3)
    NearCall(cs1, 0x4FC6, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    State.IncCycles();
    label_1000_4FC6_14FC6:
    // MOV [0xc5],AL (1000_4FC6 / 0x14FC6)
    UInt8[DS, 0xC5] = AL;
    State.IncCycles();
    // XOR AL,AL (1000_4FC9 / 0x14FC9)
    AL = 0;
    State.IncCycles();
    // MOV [0x4727],AL (1000_4FCB / 0x14FCB)
    UInt8[DS, 0x4727] = AL;
    State.IncCycles();
    // XCHG byte ptr [0x11c9],AL (1000_4FCE / 0x14FCE)
    byte tmp_1000_4FCE = UInt8[DS, 0x11C9];
    UInt8[DS, 0x11C9] = AL;
    AL = tmp_1000_4FCE;
    State.IncCycles();
    // AND AL,0x3 (1000_4FD2 / 0x14FD2)
    AL &= 0x3;
    State.IncCycles();
    // DEC AL (1000_4FD4 / 0x14FD4)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x1000:4fdf (1000_4FD6 / 0x14FD6)
    if(!ZeroFlag) {
      goto label_1000_4FDF_14FDF;
    }
    State.IncCycles();
    // MOV DI,word ptr [0x11c5] (1000_4FD8 / 0x14FD8)
    DI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // INC byte ptr [DI + 0x15] (1000_4FDC / 0x14FDC)
    UInt8[DS, (ushort)(DI + 0x15)] = Alu.Inc8(UInt8[DS, (ushort)(DI + 0x15)]);
    State.IncCycles();
    label_1000_4FDF_14FDF:
    // CALL 0x1000:4ac4 (1000_4FDF / 0x14FDF)
    NearCall(cs1, 0x4FE2, spice86_generated_label_ret_target_1000_4AC4_014AC4);
    State.IncCycles();
    label_1000_4FE2_14FE2:
    // CALL 0x1000:dbb2 (1000_4FE2 / 0x14FE2)
    NearCall(cs1, 0x4FE5, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_4FE5_14FE5:
    // CALL 0x1000:d717 (1000_4FE5 / 0x14FE5)
    NearCall(cs1, 0x4FE8, spice86_generated_label_call_target_1000_D717_01D717);
    State.IncCycles();
    label_1000_4FE8_14FE8:
    // MOV DI,word ptr [0x11c5] (1000_4FE8 / 0x14FE8)
    DI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // MOV BX,word ptr [DI + 0x4] (1000_4FEC / 0x14FEC)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // MOV DX,word ptr [DI + 0x2] (1000_4FEF / 0x14FEF)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV word ptr [0x11c5],0x0 (1000_4FF2 / 0x14FF2)
    UInt16[DS, 0x11C5] = 0x0;
    State.IncCycles();
    // JMP 0x1000:4002 (1000_4FF8 / 0x14FF8)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3F2B_013F2B, 0x14002 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_4FFB_014FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_4FFB_14FFB:
    // MOV word ptr [0x1c06],0x0 (1000_4FFB / 0x14FFB)
    UInt16[DS, 0x1C06] = 0x0;
    State.IncCycles();
    // CALL 0x1000:ca01 (1000_5001 / 0x15001)
    NearCall(cs1, 0x5004, spice86_generated_label_call_target_1000_CA01_01CA01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5004_015004, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5004_015004(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x500C: goto label_1000_500C_1500C;break; // Target of external jump from 0x1502D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_5004_15004:
    // MOV byte ptr [0x11c8],0x0 (1000_5004 / 0x15004)
    UInt8[DS, 0x11C8] = 0x0;
    State.IncCycles();
    // MOV CX,0xc8 (1000_5009 / 0x15009)
    CX = 0xC8;
    State.IncCycles();
    label_1000_500C_1500C:
    // PUSH CX (1000_500C / 0x1500C)
    Stack.Push(CX);
    State.IncCycles();
    // CALL 0x1000:4b3b (1000_500D / 0x1500D)
    NearCall(cs1, 0x5010, spice86_generated_label_call_target_1000_4B3B_014B3B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5010_015010, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5010_015010(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5010_15010:
    // CALL 0x1000:407e (1000_5010 / 0x15010)
    NearCall(cs1, 0x5013, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5013_015013, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5013_015013(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5013_15013:
    // CALL 0x1000:b58b (1000_5013 / 0x15013)
    NearCall(cs1, 0x5016, spice86_generated_label_call_target_1000_B58B_01B58B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5016_015016, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5016_015016(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5016_15016:
    // MOV SI,word ptr [0x11c5] (1000_5016 / 0x15016)
    SI = UInt16[DS, 0x11C5];
    State.IncCycles();
    // CMP DI,word ptr [SI + 0x6] (1000_501A / 0x1501A)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x6)]);
    State.IncCycles();
    // JZ 0x1000:5039 (1000_501D / 0x1501D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_5039_015039, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr [0x23],0x0 (1000_501F / 0x1501F)
    UInt8[DS, 0x23] = 0x0;
    State.IncCycles();
    // CALL 0x1000:4182 (1000_5024 / 0x15024)
    NearCall(cs1, 0x5027, spice86_generated_label_call_target_1000_4182_014182);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5027_015027, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5027_015027(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5027_15027:
    // CMP byte ptr [0x23],0x0 (1000_5027 / 0x15027)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    State.IncCycles();
    // POP CX (1000_502C / 0x1502C)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOPZ 0x1000:500c (1000_502D / 0x1502D)
    if(--CX != 0 && ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5004_015004, 0x1500C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // JZ 0x1000:4fc3 (1000_502F / 0x1502F)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F3D_014F3D, 0x14FC3 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD byte ptr [0x4726],0x20 (1000_5031 / 0x15031)
    // UInt8[DS, 0x4726] += 0x20;
    UInt8[DS, 0x4726] = Alu.Add8(UInt8[DS, 0x4726], 0x20);
    State.IncCycles();
    // JMP 0x1000:2e52 (1000_5036 / 0x15036)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_5039_015039(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5039_15039:
    // POP CX (1000_5039 / 0x15039)
    CX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4fc3 (1000_503A / 0x1503A)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_4F3D_014F3D, 0x14FC3 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_503C_01503C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_503C_1503C:
    // MOV byte ptr [0xfd],0x0 (1000_503C / 0x1503C)
    UInt8[DS, 0xFD] = 0x0;
    State.IncCycles();
    // MOV byte ptr [0x2b],0x0 (1000_5041 / 0x15041)
    UInt8[DS, 0x2B] = 0x0;
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x2 (1000_5046 / 0x15046)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    State.IncCycles();
    // JNZ 0x1000:5058 (1000_504A / 0x1504A)
    if(!ZeroFlag) {
      goto label_1000_5058_15058;
    }
    State.IncCycles();
    // CALL 0x1000:5d36 (1000_504C / 0x1504C)
    NearCall(cs1, 0x504F, spice86_generated_label_call_target_1000_5D36_015D36);
    State.IncCycles();
    label_1000_504F_1504F:
    // JC 0x1000:5081 (1000_504F / 0x1504F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5081 / 0x15081)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:5098 (1000_5051 / 0x15051)
    NearCall(cs1, 0x5054, not_observed_1000_5098_015098);
    State.IncCycles();
    // OR DX,DX (1000_5054 / 0x15054)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:507a (1000_5056 / 0x15056)
    if(ZeroFlag) {
      goto label_1000_507A_1507A;
    }
    State.IncCycles();
    label_1000_5058_15058:
    // INC byte ptr [0x2b] (1000_5058 / 0x15058)
    UInt8[DS, 0x2B] = Alu.Inc8(UInt8[DS, 0x2B]);
    State.IncCycles();
    // CALL 0x1000:6144 (1000_505C / 0x1505C)
    NearCall(cs1, 0x505F, not_observed_1000_6144_016144);
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x8] (1000_505F / 0x1505F)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    State.IncCycles();
    // MOV AH,0x2f (1000_5062 / 0x15062)
    AH = 0x2F;
    State.IncCycles();
    // CMP AL,0x20 (1000_5064 / 0x15064)
    Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // JC 0x1000:5075 (1000_5066 / 0x15066)
    if(CarryFlag) {
      goto label_1000_5075_15075;
    }
    State.IncCycles();
    // INC AH (1000_5068 / 0x15068)
    AH++;
    State.IncCycles();
    // CMP AL,0x30 (1000_506A / 0x1506A)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JZ 0x1000:5075 (1000_506C / 0x1506C)
    if(ZeroFlag) {
      goto label_1000_5075_15075;
    }
    State.IncCycles();
    // SUB AL,0x28 (1000_506E / 0x1506E)
    // AL -= 0x28;
    AL = Alu.Sub8(AL, 0x28);
    State.IncCycles();
    // JC 0x1000:5075 (1000_5070 / 0x15070)
    if(CarryFlag) {
      goto label_1000_5075_15075;
    }
    State.IncCycles();
    // ADD AH,0x3 (1000_5072 / 0x15072)
    // AH += 0x3;
    AH = Alu.Add8(AH, 0x3);
    State.IncCycles();
    label_1000_5075_15075:
    // MOV byte ptr [0x11dd],AH (1000_5075 / 0x15075)
    UInt8[DS, 0x11DD] = AH;
    State.IncCycles();
    // RET  (1000_5079 / 0x15079)
    return NearRet();
    State.IncCycles();
    label_1000_507A_1507A:
    // JCXZ 0x1000:5081 (1000_507A / 0x1507A)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_5081 / 0x15081)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x46d9],0x4 (1000_507C / 0x1507C)
    UInt8[DS, 0x46D9] = 0x4;
    State.IncCycles();
    label_1000_5081_15081:
    // RET  (1000_5081 / 0x15081)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_5098_015098(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5098_15098:
    // MOV BP,0x5082 (1000_5098 / 0x15098)
    BP = 0x5082;
    State.IncCycles();
    // XOR CX,CX (1000_509B / 0x1509B)
    CX = 0;
    State.IncCycles();
    // XOR DX,DX (1000_509D / 0x1509D)
    DX = 0;
    State.IncCycles();
    // JMP 0x1000:6603 (1000_509F / 0x1509F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_6603_016603, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_50A5_0150A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50A5_150A5:
    // MOV AX,[0xdc00] (1000_50A5 / 0x150A5)
    AX = UInt16[DS, 0xDC00];
    State.IncCycles();
    // CALL 0x1000:ca1b (1000_50A8 / 0x150A8)
    NearCall(cs1, 0x50AB, spice86_generated_label_call_target_1000_CA1B_01CA1B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50AB_0150AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50AB_0150AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50AB_150AB:
    // MOV DI,word ptr [0x1150] (1000_50AB / 0x150AB)
    DI = UInt16[DS, 0x1150];
    State.IncCycles();
    // CALL 0x1000:407e (1000_50AF / 0x150AF)
    NearCall(cs1, 0x50B2, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50B2_0150B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50B2_0150B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50B2_150B2:
    // CALL 0x1000:4965 (1000_50B2 / 0x150B2)
    NearCall(cs1, 0x50B5, spice86_generated_label_call_target_1000_4965_014965);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50B5_0150B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50B5_0150B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50B5_150B5:
    // CALL 0x1000:4ac4 (1000_50B5 / 0x150B5)
    NearCall(cs1, 0x50B8, spice86_generated_label_ret_target_1000_4AC4_014AC4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50B8_0150B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50B8_0150B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50B8_150B8:
    // CALL 0x1000:50be (1000_50B8 / 0x150B8)
    NearCall(cs1, 0x50BB, spice86_generated_label_call_target_1000_50BE_0150BE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50BB_0150BB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50BB_0150BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50BB_150BB:
    // JMP 0x1000:2eb2 (1000_50BB / 0x150BB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2EB2_012EB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_50BE_0150BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50BE_150BE:
    // MOV byte ptr [0x11cb],0x0 (1000_50BE / 0x150BE)
    UInt8[DS, 0x11CB] = 0x0;
    State.IncCycles();
    // RET  (1000_50C3 / 0x150C3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_50DB_0150DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50DB_150DB:
    // MOV word ptr [0x487e],0x2 (1000_50DB / 0x150DB)
    UInt16[DS, 0x487E] = 0x2;
    State.IncCycles();
    // MOV byte ptr [0x473e],0x1 (1000_50E1 / 0x150E1)
    UInt8[DS, 0x473E] = 0x1;
    State.IncCycles();
    // MOV AL,0x4 (1000_50E6 / 0x150E6)
    AL = 0x4;
    State.IncCycles();
    // JMP 0x1000:50ef (1000_50E8 / 0x150E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_50EF_0150EF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_50EF_0150EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50EF_150EF:
    // MOV DI,word ptr [0x46f8] (1000_50EF / 0x150EF)
    DI = UInt16[DS, 0x46F8];
    State.IncCycles();
    // PUSH DI (1000_50F3 / 0x150F3)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH AX (1000_50F4 / 0x150F4)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:d2bd (1000_50F5 / 0x150F5)
    NearCall(cs1, 0x50F8, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50F8_0150F8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50F8_0150F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50F8_150F8:
    // CALL 0x1000:49ea (1000_50F8 / 0x150F8)
    NearCall(cs1, 0x50FB, spice86_generated_label_call_target_1000_49EA_0149EA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_50FB_0150FB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_50FB_0150FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_50FB_150FB:
    // MOV DX,word ptr [0x4] (1000_50FB / 0x150FB)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_50FF / 0x150FF)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // POP AX (1000_5103 / 0x15103)
    AX = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_5104 / 0x15104)
    Stack.Push(AX);
    State.IncCycles();
    // CMP AL,0x4 (1000_5105 / 0x15105)
    Alu.Sub8(AL, 0x4);
    State.IncCycles();
    // JNZ 0x1000:510b (1000_5107 / 0x15107)
    if(!ZeroFlag) {
      goto label_1000_510B_1510B;
    }
    State.IncCycles();
    // MOV DL,0x1 (1000_5109 / 0x15109)
    DL = 0x1;
    State.IncCycles();
    label_1000_510B_1510B:
    // CALL 0x1000:4057 (1000_510B / 0x1510B)
    NearCall(cs1, 0x510E, spice86_generated_label_ret_target_1000_4057_014057);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_510E_01510E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_510E_01510E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_510E_1510E:
    // CALL 0x1000:186b (1000_510E / 0x1510E)
    NearCall(cs1, 0x5111, spice86_generated_label_ret_target_1000_186B_01186B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5111_015111, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5111_015111(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5111_15111:
    // POP AX (1000_5111 / 0x15111)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV [0x11c9],AL (1000_5112 / 0x15112)
    UInt8[DS, 0x11C9] = AL;
    State.IncCycles();
    // POP DI (1000_5115 / 0x15115)
    DI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:4703 (1000_5116 / 0x15116)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4703_014703, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5119_015119(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5119_15119:
    // ADD byte ptr [0x11c7],AL (1000_5119 / 0x15119)
    // UInt8[DS, 0x11C7] += AL;
    UInt8[DS, 0x11C7] = Alu.Add8(UInt8[DS, 0x11C7], AL);
    State.IncCycles();
    // MOV word ptr [0x11cc],0x80 (1000_511D / 0x1511D)
    UInt16[DS, 0x11CC] = 0x80;
    State.IncCycles();
    // RET  (1000_5123 / 0x15123)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5124_015124(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5124_15124:
    // PUSH DI (1000_5124 / 0x15124)
    Stack.Push(DI);
    State.IncCycles();
    // CALL 0x1000:407e (1000_5125 / 0x15125)
    NearCall(cs1, 0x5128, spice86_generated_label_call_target_1000_407E_01407E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_5128_015128, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_5128_015128(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5128_15128:
    // MOV CX,word ptr [DI + 0x4] (1000_5128 / 0x15128)
    CX = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // MOV DI,word ptr [DI + 0x2] (1000_512B / 0x1512B)
    DI = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // CALL 0x1000:5133 (1000_512E / 0x1512E)
    NearCall(cs1, 0x5131, spice86_generated_label_call_target_1000_5133_015133);
    State.IncCycles();
    label_1000_5131_15131:
    // POP DI (1000_5131 / 0x15131)
    DI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_5132 / 0x15132)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_5133_015133(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_5133_15133:
    // SUB BX,CX (1000_5133 / 0x15133)
    BX -= CX;
    State.IncCycles();
    // NEG BX (1000_5135 / 0x15135)
    BX = Alu.Sub16(0, BX);
    State.IncCycles();
    // SUB DX,DI (1000_5137 / 0x15137)
    DX -= DI;
    State.IncCycles();
    // NEG DX (1000_5139 / 0x15139)
    DX = Alu.Sub16(0, DX);
    State.IncCycles();
    // CMP BX,-0x80 (1000_513B / 0x1513B)
    Alu.Sub16(BX, 0xFF80);
    State.IncCycles();
    // JL 0x1000:5146 (1000_513E / 0x1513E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5146_15146;
    }
    State.IncCycles();
    // CMP BX,0x80 (1000_5140 / 0x15140)
    Alu.Sub16(BX, 0x80);
    State.IncCycles();
    // JL 0x1000:514a (1000_5144 / 0x15144)
    if(SignFlag != OverflowFlag) {
      goto label_1000_514A_1514A;
    }
    State.IncCycles();
    label_1000_5146_15146:
    // SAR BX,1 (1000_5146 / 0x15146)
    BX = Alu.Sar16(BX, 0x1);
    State.IncCycles();
    // SAR DX,1 (1000_5148 / 0x15148)
    DX = Alu.Sar16(DX, 0x1);
    State.IncCycles();
    label_1000_514A_1514A:
    // MOV BH,BL (1000_514A / 0x1514A)
    BH = BL;
    State.IncCycles();
    // XOR BL,BL (1000_514C / 0x1514C)
    BL = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_514E_01514E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_514E_01514E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_514E_1514E:
    // OR BX,BX (1000_514E / 0x1514E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // MOV AX,BX (1000_5150 / 0x15150)
    AX = BX;
    State.IncCycles();
    // JNS 0x1000:5156 (1000_5152 / 0x15152)
    if(!SignFlag) {
      goto label_1000_5156_15156;
    }
    State.IncCycles();
    // NEG AX (1000_5154 / 0x15154)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_5156_15156:
    // OR DX,DX (1000_5156 / 0x15156)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // MOV DI,DX (1000_5158 / 0x15158)
    DI = DX;
    State.IncCycles();
    // MOV CX,DX (1000_515A / 0x1515A)
    CX = DX;
    State.IncCycles();
    // JNS 0x1000:5160 (1000_515C / 0x1515C)
    if(!SignFlag) {
      goto label_1000_5160_15160;
    }
    State.IncCycles();
    // NEG CX (1000_515E / 0x1515E)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    label_1000_5160_15160:
    // CMP CX,AX (1000_5160 / 0x15160)
    Alu.Sub16(CX, AX);
    State.IncCycles();
    // JC 0x1000:5180 (1000_5162 / 0x15162)
    if(CarryFlag) {
      goto label_1000_5180_15180;
    }
    State.IncCycles();
    // CMP CX,0x1 (1000_5164 / 0x15164)
    Alu.Sub16(CX, 0x1);
    State.IncCycles();
    // JC 0x1000:517f (1000_5167 / 0x15167)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_517F / 0x1517F)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x20 (1000_5169 / 0x15169)
    AX = 0x20;
    State.IncCycles();
    // MOV CX,DX (1000_516C / 0x1516C)
    CX = DX;
    State.IncCycles();
    // IMUL BX (1000_516E / 0x1516E)
    Cpu.IMul16(BX);
    State.IncCycles();
    // IDIV CX (1000_5170 / 0x15170)
    Cpu.IDiv16(CX);
    State.IncCycles();
    // MOV DX,DI (1000_5172 / 0x15172)
    DX = DI;
    State.IncCycles();
    // OR CX,CX (1000_5174 / 0x15174)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    State.IncCycles();
    // JS 0x1000:517c (1000_5176 / 0x15176)
    if(SignFlag) {
      goto label_1000_517C_1517C;
    }
    State.IncCycles();
    // ADD AL,0x40 (1000_5178 / 0x15178)
    // AL += 0x40;
    AL = Alu.Add8(AL, 0x40);
    State.IncCycles();
    // CLC  (1000_517A / 0x1517A)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_517B / 0x1517B)
    return NearRet();
    State.IncCycles();
    label_1000_517C_1517C:
    // ADD AL,0xc0 (1000_517C / 0x1517C)
    // AL += 0xC0;
    AL = Alu.Add8(AL, 0xC0);
    State.IncCycles();
    // CLC  (1000_517E / 0x1517E)
    CarryFlag = false;
    State.IncCycles();
    label_1000_517F_1517F:
    // RET  (1000_517F / 0x1517F)
    return NearRet();
    State.IncCycles();
    label_1000_5180_15180:
    // CMP AX,0x1 (1000_5180 / 0x15180)
    Alu.Sub16(AX, 0x1);
    State.IncCycles();
    // JC 0x1000:517f (1000_5183 / 0x15183)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_517F / 0x1517F)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x20 (1000_5185 / 0x15185)
    AX = 0x20;
    State.IncCycles();
    // IMUL DX (1000_5188 / 0x15188)
    Cpu.IMul16(DX);
    State.IncCycles();
    // IDIV BX (1000_518A / 0x1518A)
    Cpu.IDiv16(BX);
    State.IncCycles();
    // MOV DX,DI (1000_518C / 0x1518C)
    DX = DI;
    State.IncCycles();
    // OR BX,BX (1000_518E / 0x1518E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JS 0x1000:5194 (1000_5190 / 0x15190)
    if(SignFlag) {
      goto label_1000_5194_15194;
    }
    State.IncCycles();
    // SUB AL,0x80 (1000_5192 / 0x15192)
    AL -= 0x80;
    State.IncCycles();
    label_1000_5194_15194:
    // NEG AL (1000_5194 / 0x15194)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    // CLC  (1000_5196 / 0x15196)
    CarryFlag = false;
    State.IncCycles();
    // RET  (1000_5197 / 0x15197)
    return NearRet();
  }
  
}
