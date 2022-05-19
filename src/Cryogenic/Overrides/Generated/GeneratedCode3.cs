namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action not_observed_1000_28B5_0128B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_28B5_128B5:
    // MOV AX,0x15 (1000_28B5 / 0x128B5)
    AX = 0x15;
    // CALL 0x1000:c13e (1000_28B8 / 0x128B8)
    NearCall(cs1, 0x28BB, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV AL,0xa (1000_28BB / 0x128BB)
    AL = 0xA;
    // CALL 0x1000:ab15 (1000_28BD / 0x128BD)
    NearCall(cs1, 0x28C0, spice86_generated_label_call_target_1000_AB15_01AB15);
    // MOV AL,[0x47a9] (1000_28C0 / 0x128C0)
    AL = UInt8[DS, 0x47A9];
    // XOR AH,AH (1000_28C3 / 0x128C3)
    AH = 0;
    // MOV SI,AX (1000_28C5 / 0x128C5)
    SI = AX;
    // SHL SI,1 (1000_28C7 / 0x128C7)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV DX,word ptr [SI + 0x225d] (1000_28C9 / 0x128C9)
    DX = UInt16[DS, (ushort)(SI + 0x225D)];
    // XOR BX,BX (1000_28CD / 0x128CD)
    BX = 0;
    // XCHG DH,BL (1000_28CF / 0x128CF)
    byte tmp_1000_28CF = DH;
    DH = BL;
    BL = tmp_1000_28CF;
    // ADD AX,0x1e (1000_28D1 / 0x128D1)
    AX += 0x1E;
    // SHL SI,1 (1000_28D4 / 0x128D4)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV word ptr [SI + 0x47f8],DX (1000_28D6 / 0x128D6)
    UInt16[DS, (ushort)(SI + 0x47F8)] = DX;
    // MOV word ptr [SI + 0x47fa],BX (1000_28DA / 0x128DA)
    UInt16[DS, (ushort)(SI + 0x47FA)] = BX;
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
    label_1000_28E1_128E1:
    // CMP byte ptr [0x24],0xc (1000_28E1 / 0x128E1)
    Alu.Sub8(UInt8[DS, 0x24], 0xC);
    // JNZ 0x1000:28eb (1000_28E6 / 0x128E6)
    if(!ZeroFlag) {
      goto label_1000_28EB_128EB;
    }
    // CALL 0x1000:215f (1000_28E8 / 0x128E8)
    NearCall(cs1, 0x28EB, not_observed_1000_215F_01215F);
    label_1000_28EB_128EB:
    // CMP byte ptr [0x47a9],0x0 (1000_28EB / 0x128EB)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    // JZ 0x1000:290a (1000_28F0 / 0x128F0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_290A / 0x1290A)
      return NearRet();
    }
    // CALL 0x1000:c49a (1000_28F2 / 0x128F2)
    NearCall(cs1, 0x28F5, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    // MOV byte ptr [0x47a6],0xff (1000_28F5 / 0x128F5)
    UInt8[DS, 0x47A6] = 0xFF;
    // MOV AL,0x8 (1000_28FA / 0x128FA)
    AL = 0x8;
    // MOV BP,0x2dd3 (1000_28FC / 0x128FC)
    BP = 0x2DD3;
    // CALL 0x1000:c108 (1000_28FF / 0x128FF)
    NearCall(cs1, 0x2902, spice86_generated_label_call_target_1000_C108_01C108);
    // MOV byte ptr [0x47a9],0x0 (1000_2902 / 0x12902)
    UInt8[DS, 0x47A9] = 0x0;
    // CALL 0x1000:2773 (1000_2907 / 0x12907)
    NearCall(cs1, 0x290A, not_observed_1000_2773_012773);
    label_1000_290A_1290A:
    // RET  (1000_290A / 0x1290A)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2992_012992(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2992_12992:
    // RET  (1000_2992 / 0x12992)
    return NearRet();
    label_1000_2993_12993:
    // MOV AL,0x6 (1000_2993 / 0x12993)
    AL = 0x6;
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
    label_1000_2999_12999:
    // MOV BL,byte ptr [0xc9] (1000_2999 / 0x12999)
    BL = UInt8[DS, 0xC9];
    // MOV byte ptr [0xeb],BL (1000_299D / 0x1299D)
    UInt8[DS, 0xEB] = BL;
    // CMP byte ptr [0x47a9],0x0 (1000_29A1 / 0x129A1)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    // JZ 0x1000:2992 (1000_29A6 / 0x129A6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2992 / 0x12992)
      return NearRet();
    }
    // PUSH AX (1000_29A8 / 0x129A8)
    Stack.Push(AX);
    // CALL 0x1000:97cf (1000_29A9 / 0x129A9)
    NearCall(cs1, 0x29AC, spice86_generated_label_call_target_1000_97CF_0197CF);
    // CALL 0x1000:98f5 (1000_29AC / 0x129AC)
    NearCall(cs1, 0x29AF, spice86_generated_label_call_target_1000_98F5_0198F5);
    // CALL 0x1000:c08e (1000_29AF / 0x129AF)
    NearCall(cs1, 0x29B2, spice86_generated_label_call_target_1000_C08E_01C08E);
    // CALL 0x1000:28b5 (1000_29B2 / 0x129B2)
    NearCall(cs1, 0x29B5, not_observed_1000_28B5_0128B5);
    // CALL 0x1000:28e1 (1000_29B5 / 0x129B5)
    NearCall(cs1, 0x29B8, not_observed_1000_28E1_0128E1);
    // MOV byte ptr [0x24],0x0 (1000_29B8 / 0x129B8)
    UInt8[DS, 0x24] = 0x0;
    // POP AX (1000_29BD / 0x129BD)
    AX = Stack.Pop();
    // MOV [0x23],AL (1000_29BE / 0x129BE)
    UInt8[DS, 0x23] = AL;
    // CALL 0x1000:d316 (1000_29C1 / 0x129C1)
    NearCall(cs1, 0x29C4, spice86_generated_label_call_target_1000_D316_01D316);
    // CALL 0x1000:2eb2 (1000_29C4 / 0x129C4)
    NearCall(cs1, 0x29C7, spice86_generated_label_call_target_1000_2EB2_012EB2);
    // CALL 0x1000:2dd3 (1000_29C7 / 0x129C7)
    NearCall(cs1, 0x29CA, spice86_generated_label_ret_target_1000_2DD3_012DD3);
    // CMP byte ptr [0x47a7],0x0 (1000_29CA / 0x129CA)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    // JNZ 0x1000:2992 (1000_29CF / 0x129CF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2992 / 0x12992)
      return NearRet();
    }
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
    label_1000_29F0_129F0:
    // TEST byte ptr [0xa],0x1 (1000_29F0 / 0x129F0)
    Alu.And8(UInt8[DS, 0xA], 0x1);
    // JZ 0x1000:2a33 (1000_29F5 / 0x129F5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2A33 / 0x12A33)
      return NearRet();
    }
    // MOV SI,0x1190 (1000_29F7 / 0x129F7)
    SI = 0x1190;
    // MOV CL,byte ptr [SI] (1000_29FA / 0x129FA)
    CL = UInt8[DS, SI];
    // XOR CH,CH (1000_29FC / 0x129FC)
    CH = 0;
    // JCXZ 0x1000:2a14 (1000_29FE / 0x129FE)
    if(CX == 0) {
      goto label_1000_2A14_12A14;
    }
    // INC SI (1000_2A00 / 0x12A00)
    SI++;
    label_1000_2A01_12A01:
    // CMP AX,word ptr [SI] (1000_2A01 / 0x12A01)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JNZ 0x1000:2a0a (1000_2A03 / 0x12A03)
    if(!ZeroFlag) {
      goto label_1000_2A0A_12A0A;
    }
    // CMP DI,word ptr [SI + 0x2] (1000_2A05 / 0x12A05)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x2)]);
    // JZ 0x1000:2a33 (1000_2A08 / 0x12A08)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2A33 / 0x12A33)
      return NearRet();
    }
    label_1000_2A0A_12A0A:
    // ADD SI,0x4 (1000_2A0A / 0x12A0A)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LOOP 0x1000:2a01 (1000_2A0D / 0x12A0D)
    if(--CX != 0) {
      goto label_1000_2A01_12A01;
    }
    // MOV SI,0x1190 (1000_2A0F / 0x12A0F)
    SI = 0x1190;
    // MOV CL,byte ptr [SI] (1000_2A12 / 0x12A12)
    CL = UInt8[DS, SI];
    label_1000_2A14_12A14:
    // CMP CX,0xa (1000_2A14 / 0x12A14)
    Alu.Sub16(CX, 0xA);
    // JC 0x1000:2a25 (1000_2A17 / 0x12A17)
    if(CarryFlag) {
      goto label_1000_2A25_12A25;
    }
    // PUSH AX (1000_2A19 / 0x12A19)
    Stack.Push(AX);
    // PUSH SI (1000_2A1A / 0x12A1A)
    Stack.Push(SI);
    // PUSH DI (1000_2A1B / 0x12A1B)
    Stack.Push(DI);
    // CALL 0x1000:2a34 (1000_2A1C / 0x12A1C)
    NearCall(cs1, 0x2A1F, not_observed_1000_2A34_012A34);
    // POP DI (1000_2A1F / 0x12A1F)
    DI = Stack.Pop();
    // POP SI (1000_2A20 / 0x12A20)
    SI = Stack.Pop();
    // POP AX (1000_2A21 / 0x12A21)
    AX = Stack.Pop();
    // MOV CX,0x9 (1000_2A22 / 0x12A22)
    CX = 0x9;
    label_1000_2A25_12A25:
    // INC byte ptr [SI] (1000_2A25 / 0x12A25)
    UInt8[DS, SI]++;
    // INC SI (1000_2A27 / 0x12A27)
    SI++;
    // ADD CX,CX (1000_2A28 / 0x12A28)
    CX += CX;
    // ADD CX,CX (1000_2A2A / 0x12A2A)
    CX += CX;
    // ADD SI,CX (1000_2A2C / 0x12A2C)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    // MOV word ptr [SI],AX (1000_2A2E / 0x12A2E)
    UInt16[DS, SI] = AX;
    // MOV word ptr [SI + 0x2],DI (1000_2A30 / 0x12A30)
    UInt16[DS, (ushort)(SI + 0x2)] = DI;
    label_1000_2A33_12A33:
    // RET  (1000_2A33 / 0x12A33)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2A34_012A34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2A34_12A34:
    // MOV SI,0x1190 (1000_2A34 / 0x12A34)
    SI = 0x1190;
    // DEC byte ptr [SI] (1000_2A37 / 0x12A37)
    UInt8[DS, SI] = Alu.Dec8(UInt8[DS, SI]);
    // JNZ 0x1000:2a3f (1000_2A39 / 0x12A39)
    if(!ZeroFlag) {
      goto label_1000_2A3F_12A3F;
    }
    // MOV byte ptr [SI + -0x1],0x0 (1000_2A3B / 0x12A3B)
    UInt8[DS, (ushort)(SI - 0x1)] = 0x0;
    label_1000_2A3F_12A3F:
    // INC SI (1000_2A3F / 0x12A3F)
    SI = Alu.Inc16(SI);
    // MOV DI,SI (1000_2A40 / 0x12A40)
    DI = SI;
    // ADD SI,0x4 (1000_2A42 / 0x12A42)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // PUSH DS (1000_2A45 / 0x12A45)
    Stack.Push(DS);
    // POP ES (1000_2A46 / 0x12A46)
    ES = Stack.Pop();
    // MOV CX,0x12 (1000_2A47 / 0x12A47)
    CX = 0x12;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_2A4A / 0x12A4A)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // XOR AX,AX (1000_2A4C / 0x12A4C)
    AX = 0;
    // STOSW ES:DI (1000_2A4E / 0x12A4E)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_2A4F / 0x12A4F)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // RET  (1000_2A50 / 0x12A50)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2A51_012A51(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2A51_12A51:
    // MOV SI,0x1190 (1000_2A51 / 0x12A51)
    SI = 0x1190;
    // MOV DL,AL (1000_2A54 / 0x12A54)
    DL = AL;
    // MOV BX,DI (1000_2A56 / 0x12A56)
    BX = DI;
    // XOR CX,CX (1000_2A58 / 0x12A58)
    CX = 0;
    // XOR BP,BP (1000_2A5A / 0x12A5A)
    BP = 0;
    // LODSB SI (1000_2A5C / 0x12A5C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV CL,AL (1000_2A5D / 0x12A5D)
    CL = AL;
    // JCXZ 0x1000:2aae (1000_2A5F / 0x12A5F)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_2AAE / 0x12AAE)
      return NearRet();
    }
    // MOV DI,SI (1000_2A61 / 0x12A61)
    DI = SI;
    // PUSH DS (1000_2A63 / 0x12A63)
    Stack.Push(DS);
    // POP ES (1000_2A64 / 0x12A64)
    ES = Stack.Pop();
    label_1000_2A65_12A65:
    // LODSW SI (1000_2A65 / 0x12A65)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AH,DL (1000_2A66 / 0x12A66)
    Alu.Sub8(AH, DL);
    // JNZ 0x1000:2a78 (1000_2A68 / 0x12A68)
    if(!ZeroFlag) {
      goto label_1000_2A78_12A78;
    }
    // CMP DL,0xf (1000_2A6A / 0x12A6A)
    Alu.Sub8(DL, 0xF);
    // JNZ 0x1000:2a73 (1000_2A6D / 0x12A6D)
    if(!ZeroFlag) {
      goto label_1000_2A73_12A73;
    }
    // CMP BX,word ptr [SI] (1000_2A6F / 0x12A6F)
    Alu.Sub16(BX, UInt16[DS, SI]);
    // JNZ 0x1000:2a78 (1000_2A71 / 0x12A71)
    if(!ZeroFlag) {
      goto label_1000_2A78_12A78;
    }
    label_1000_2A73_12A73:
    // ADD SI,0x2 (1000_2A73 / 0x12A73)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // JMP 0x1000:2a7b (1000_2A76 / 0x12A76)
    goto label_1000_2A7B_12A7B;
    label_1000_2A78_12A78:
    // STOSW ES:DI (1000_2A78 / 0x12A78)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2A79 / 0x12A79)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // INC BP (1000_2A7A / 0x12A7A)
    BP = Alu.Inc16(BP);
    label_1000_2A7B_12A7B:
    // LOOP 0x1000:2a65 (1000_2A7B / 0x12A7B)
    if(--CX != 0) {
      goto label_1000_2A65_12A65;
    }
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
    label_1000_2A9E_12A9E:
    // MOV CX,BP (1000_2A9E / 0x12A9E)
    CX = BP;
    // MOV CH,CL (1000_2AA0 / 0x12AA0)
    CH = CL;
    // XCHG byte ptr [0x1190],CL (1000_2AA2 / 0x12AA2)
    byte tmp_1000_2AA2 = UInt8[DS, 0x1190];
    UInt8[DS, 0x1190] = CL;
    CL = tmp_1000_2AA2;
    // CMP CL,CH (1000_2AA6 / 0x12AA6)
    Alu.Sub8(CL, CH);
    // JZ 0x1000:2aae (1000_2AA8 / 0x12AA8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2AAE / 0x12AAE)
      return NearRet();
    }
    // XOR AX,AX (1000_2AAA / 0x12AAA)
    AX = 0;
    // STOSW ES:DI (1000_2AAC / 0x12AAC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // STOSW ES:DI (1000_2AAD / 0x12AAD)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    label_1000_2AAE_12AAE:
    // RET  (1000_2AAE / 0x12AAE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2AAF_012AAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2AAF_12AAF:
    // PUSH SI (1000_2AAF / 0x12AAF)
    Stack.Push(SI);
    // MOV SI,0x1190 (1000_2AB0 / 0x12AB0)
    SI = 0x1190;
    // XOR CX,CX (1000_2AB3 / 0x12AB3)
    CX = 0;
    // MOV CL,byte ptr [SI] (1000_2AB5 / 0x12AB5)
    CL = UInt8[DS, SI];
    // JCXZ 0x1000:2acd (1000_2AB7 / 0x12AB7)
    if(CX == 0) {
      goto label_1000_2ACD_12ACD;
    }
    // INC SI (1000_2AB9 / 0x12AB9)
    SI++;
    label_1000_2ABA_12ABA:
    // CMP AL,byte ptr [SI + 0x1] (1000_2ABA / 0x12ABA)
    Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x1)]);
    // JNZ 0x1000:2ac8 (1000_2ABD / 0x12ABD)
    if(!ZeroFlag) {
      goto label_1000_2AC8_12AC8;
    }
    // CMP AL,0xf (1000_2ABF / 0x12ABF)
    Alu.Sub8(AL, 0xF);
    // JNZ 0x1000:2ad0 (1000_2AC1 / 0x12AC1)
    if(!ZeroFlag) {
      goto label_1000_2AD0_12AD0;
    }
    // CMP DI,word ptr [SI + 0x2] (1000_2AC3 / 0x12AC3)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x2)]);
    // JZ 0x1000:2ad0 (1000_2AC6 / 0x12AC6)
    if(ZeroFlag) {
      goto label_1000_2AD0_12AD0;
    }
    label_1000_2AC8_12AC8:
    // ADD SI,0x4 (1000_2AC8 / 0x12AC8)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LOOP 0x1000:2aba (1000_2ACB / 0x12ACB)
    if(--CX != 0) {
      goto label_1000_2ABA_12ABA;
    }
    label_1000_2ACD_12ACD:
    // POP SI (1000_2ACD / 0x12ACD)
    SI = Stack.Pop();
    // CLC  (1000_2ACE / 0x12ACE)
    CarryFlag = false;
    // RET  (1000_2ACF / 0x12ACF)
    return NearRet();
    label_1000_2AD0_12AD0:
    // MOV AX,word ptr [SI] (1000_2AD0 / 0x12AD0)
    AX = UInt16[DS, SI];
    // MOV DI,word ptr [SI + 0x2] (1000_2AD2 / 0x12AD2)
    DI = UInt16[DS, (ushort)(SI + 0x2)];
    // POP SI (1000_2AD5 / 0x12AD5)
    SI = Stack.Pop();
    // STC  (1000_2AD6 / 0x12AD6)
    CarryFlag = true;
    // RET  (1000_2AD7 / 0x12AD7)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2AD8_012AD8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2AD8_12AD8:
    // PUSH AX (1000_2AD8 / 0x12AD8)
    Stack.Push(AX);
    // MOV AX,[0x1191] (1000_2AD9 / 0x12AD9)
    AX = UInt16[DS, 0x1191];
    // MOV BX,word ptr [0x12] (1000_2ADC / 0x12ADC)
    BX = UInt16[DS, 0x12];
    // MOV CL,AH (1000_2AE0 / 0x12AE0)
    CL = AH;
    // SHR BX,CL (1000_2AE2 / 0x12AE2)
    BX >>= CL;
    // SHR BX,1 (1000_2AE4 / 0x12AE4)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // JNC 0x1000:2af7 (1000_2AE6 / 0x12AE6)
    if(!CarryFlag) {
      goto label_1000_2AF7_12AF7;
    }
    // MOV DI,word ptr [0x1193] (1000_2AE8 / 0x12AE8)
    DI = UInt16[DS, 0x1193];
    // CMP CL,0xf (1000_2AEC / 0x12AEC)
    Alu.Sub8(CL, 0xF);
    // JNZ 0x1000:2afa (1000_2AEF / 0x12AEF)
    if(!ZeroFlag) {
      goto label_1000_2AFA_12AFA;
    }
    // CMP DI,word ptr [0x114e] (1000_2AF1 / 0x12AF1)
    Alu.Sub16(DI, UInt16[DS, 0x114E]);
    // JZ 0x1000:2afa (1000_2AF5 / 0x12AF5)
    if(ZeroFlag) {
      goto label_1000_2AFA_12AFA;
    }
    label_1000_2AF7_12AF7:
    // POP AX (1000_2AF7 / 0x12AF7)
    AX = Stack.Pop();
    // CLC  (1000_2AF8 / 0x12AF8)
    CarryFlag = false;
    // RET  (1000_2AF9 / 0x12AF9)
    return NearRet();
    label_1000_2AFA_12AFA:
    // ADD SP,0x2 (1000_2AFA / 0x12AFA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
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
    label_1000_2B00_12B00:
    // PUSH word ptr [0x11ce] (1000_2B00 / 0x12B00)
    Stack.Push(UInt16[DS, 0x11CE]);
    // OR DI,DI (1000_2B04 / 0x12B04)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:2b0d (1000_2B06 / 0x12B06)
    if(ZeroFlag) {
      goto label_1000_2B0D_12B0D;
    }
    // PUSH AX (1000_2B08 / 0x12B08)
    Stack.Push(AX);
    // CALL 0x1000:331e (1000_2B09 / 0x12B09)
    NearCall(cs1, 0x2B0C, spice86_generated_label_call_target_1000_331E_01331E);
    // POP AX (1000_2B0C / 0x12B0C)
    AX = Stack.Pop();
    label_1000_2B0D_12B0D:
    // MOV [0xea],AL (1000_2B0D / 0x12B0D)
    UInt8[DS, 0xEA] = AL;
    // MOV AL,AH (1000_2B10 / 0x12B10)
    AL = AH;
    // XOR AH,AH (1000_2B12 / 0x12B12)
    AH = 0;
    // CALL 0x1000:96d8 (1000_2B14 / 0x12B14)
    NearCall(cs1, 0x2B17, spice86_generated_label_call_target_1000_96D8_0196D8);
    // CALL 0x1000:9945 (1000_2B17 / 0x12B17)
    NearCall(cs1, 0x2B1A, not_observed_1000_9945_019945);
    // MOV byte ptr [0xea],0xff (1000_2B1A / 0x12B1A)
    UInt8[DS, 0xEA] = 0xFF;
    // MOV AL,0x1 (1000_2B1F / 0x12B1F)
    AL = 0x1;
    // CALL 0x1000:9ef1 (1000_2B21 / 0x12B21)
    NearCall(cs1, 0x2B24, not_observed_1000_9EF1_019EF1);
    // POP DI (1000_2B24 / 0x12B24)
    DI = Stack.Pop();
    // CALL 0x1000:331e (1000_2B25 / 0x12B25)
    NearCall(cs1, 0x2B28, spice86_generated_label_call_target_1000_331E_01331E);
    // STC  (1000_2B28 / 0x12B28)
    CarryFlag = true;
    // RET  (1000_2B29 / 0x12B29)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2B2A_012B2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2B2A_12B2A:
    // MOV AL,[0x46d9] (1000_2B2A / 0x12B2A)
    AL = UInt8[DS, 0x46D9];
    // OR AL,byte ptr [0x4774] (1000_2B2D / 0x12B2D)
    // AL |= UInt8[DS, 0x4774];
    AL = Alu.Or8(AL, UInt8[DS, 0x4774]);
    // OR AL,byte ptr [0x11c9] (1000_2B31 / 0x12B31)
    // AL |= UInt8[DS, 0x11C9];
    AL = Alu.Or8(AL, UInt8[DS, 0x11C9]);
    // JNZ 0x1000:2b8f (1000_2B35 / 0x12B35)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // CALL 0x1000:d41b (1000_2B37 / 0x12B37)
    NearCall(cs1, 0x2B3A, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_2B3A_12B3A:
    // CMP BP,0x1f0e (1000_2B3A / 0x12B3A)
    Alu.Sub16(BP, 0x1F0E);
    // JNZ 0x1000:2b8f (1000_2B3E / 0x12B3E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // CMP byte ptr [0xfb],0x0 (1000_2B40 / 0x12B40)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:2b8f (1000_2B45 / 0x12B45)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // MOV AX,[0xce7a] (1000_2B47 / 0x12B47)
    AX = UInt16[DS, 0xCE7A];
    // CMP byte ptr [0x2a],0x14 (1000_2B4A / 0x12B4A)
    Alu.Sub8(UInt8[DS, 0x2A], 0x14);
    // JC 0x1000:2b8f (1000_2B4F / 0x12B4F)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // JZ 0x1000:2ba1 (1000_2B51 / 0x12B51)
    if(ZeroFlag) {
      goto label_1000_2BA1_12BA1;
    }
    // CMP byte ptr [0x1190],0x0 (1000_2B53 / 0x12B53)
    Alu.Sub8(UInt8[DS, 0x1190], 0x0);
    // JZ 0x1000:2b8f (1000_2B58 / 0x12B58)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // SUB AX,word ptr [0xdc5a] (1000_2B5A / 0x12B5A)
    AX -= UInt16[DS, 0xDC5A];
    // CMP AX,0x32 (1000_2B5E / 0x12B5E)
    Alu.Sub16(AX, 0x32);
    // JC 0x1000:2b8f (1000_2B61 / 0x12B61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // CALL 0x1000:2ad8 (1000_2B63 / 0x12B63)
    NearCall(cs1, 0x2B66, not_observed_1000_2AD8_012AD8);
    // JNC 0x1000:2b70 (1000_2B66 / 0x12B66)
    if(!CarryFlag) {
      goto label_1000_2B70_12B70;
    }
    // MOV byte ptr [0x23],0x0 (1000_2B68 / 0x12B68)
    UInt8[DS, 0x23] = 0x0;
    // JMP 0x1000:3542 (1000_2B6D / 0x12B6D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3530_013530, 0x13542 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2B70_12B70:
    // CMP byte ptr [0x2b],0x0 (1000_2B70 / 0x12B70)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:2bd2 (1000_2B75 / 0x12B75)
    if(!ZeroFlag) {
      goto label_1000_2BD2_12BD2;
    }
    // MOV BL,0x28 (1000_2B77 / 0x12B77)
    BL = 0x28;
    // CMP AX,0x96 (1000_2B79 / 0x12B79)
    Alu.Sub16(AX, 0x96);
    // JC 0x1000:2b90 (1000_2B7C / 0x12B7C)
    if(CarryFlag) {
      goto label_1000_2B90_12B90;
    }
    // CMP AX,0xfa (1000_2B7E / 0x12B7E)
    Alu.Sub16(AX, 0xFA);
    // JC 0x1000:2b8f (1000_2B81 / 0x12B81)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // CMP AX,0x15e (1000_2B83 / 0x12B83)
    Alu.Sub16(AX, 0x15E);
    // MOV BL,0x26 (1000_2B86 / 0x12B86)
    BL = 0x26;
    // JC 0x1000:2b90 (1000_2B88 / 0x12B88)
    if(CarryFlag) {
      goto label_1000_2B90_12B90;
    }
    // CMP AX,0x1c2 (1000_2B8A / 0x12B8A)
    Alu.Sub16(AX, 0x1C2);
    // JNC 0x1000:2bd2 (1000_2B8D / 0x12B8D)
    if(!CarryFlag) {
      goto label_1000_2BD2_12BD2;
    }
    label_1000_2B8F_12B8F:
    // RET  (1000_2B8F / 0x12B8F)
    return NearRet();
    label_1000_2B90_12B90:
    // PUSH BX (1000_2B90 / 0x12B90)
    Stack.Push(BX);
    // CALL 0x1000:dbb2 (1000_2B91 / 0x12B91)
    NearCall(cs1, 0x2B94, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:c49a (1000_2B94 / 0x12B94)
    NearCall(cs1, 0x2B97, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    // POP AX (1000_2B97 / 0x12B97)
    AX = Stack.Pop();
    // MOV BP,0xf66 (1000_2B98 / 0x12B98)
    BP = 0xF66;
    // CALL 0x1000:c108 (1000_2B9B / 0x12B9B)
    NearCall(cs1, 0x2B9E, spice86_generated_label_call_target_1000_C108_01C108);
    // JMP 0x1000:dbec (1000_2B9E / 0x12B9E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_DBEC_01DBEC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2BA1_12BA1:
    // CMP word ptr [0x10],0x0 (1000_2BA1 / 0x12BA1)
    Alu.Sub16(UInt16[DS, 0x10], 0x0);
    // JNZ 0x1000:2b8f (1000_2BA6 / 0x12BA6)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // CMP byte ptr [0x8],0xff (1000_2BA8 / 0x12BA8)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    // JNZ 0x1000:2b8f (1000_2BAD / 0x12BAD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // SUB AX,word ptr [0xdc5a] (1000_2BAF / 0x12BAF)
    AX -= UInt16[DS, 0xDC5A];
    // CMP AX,0x3e8 (1000_2BB3 / 0x12BB3)
    Alu.Sub16(AX, 0x3E8);
    // JC 0x1000:2b8f (1000_2BB6 / 0x12BB6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_2B8F / 0x12B8F)
      return NearRet();
    }
    // ADD word ptr [0xdc5a],0x3b6 (1000_2BB8 / 0x12BB8)
    // UInt16[DS, 0xDC5A] += 0x3B6;
    UInt16[DS, 0xDC5A] = Alu.Add16(UInt16[DS, 0xDC5A], 0x3B6);
    // CALL 0x1000:1071 (1000_2BBE / 0x12BBE)
    NearCall(cs1, 0x2BC1, not_observed_1000_1071_011071);
    // CALL 0x1000:b17a (1000_2BC1 / 0x12BC1)
    NearCall(cs1, 0x2BC4, spice86_generated_label_call_target_1000_B17A_01B17A);
    label_1000_2BC4_12BC4:
    // CALL 0x1000:2b2a (1000_2BC4 / 0x12BC4)
    NearCall(cs1, 0x2BC7, spice86_generated_label_call_target_1000_2B2A_012B2A);
    // CMP byte ptr [0xea],0xff (1000_2BC7 / 0x12BC7)
    Alu.Sub8(UInt8[DS, 0xEA], 0xFF);
    // JNZ 0x1000:2bc4 (1000_2BCC / 0x12BCC)
    if(!ZeroFlag) {
      goto label_1000_2BC4_12BC4;
    }
    // RET  (1000_2BCE / 0x12BCE)
    return NearRet();
    label_1000_2BCF_12BCF:
    // JMP 0x1000:2a34 (1000_2BCF / 0x12BCF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2A34_012A34, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2BD2_12BD2:
    // CALL 0x1000:dbb2 (1000_2BD2 / 0x12BD2)
    NearCall(cs1, 0x2BD5, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:ad5e (1000_2BD5 / 0x12BD5)
    NearCall(cs1, 0x2BD8, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    // MOV DI,word ptr [0x1193] (1000_2BD8 / 0x12BD8)
    DI = UInt16[DS, 0x1193];
    // OR DI,DI (1000_2BDC / 0x12BDC)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:2bf4 (1000_2BDE / 0x12BDE)
    if(ZeroFlag) {
      goto label_1000_2BF4_12BF4;
    }
    // MOV AX,DI (1000_2BE0 / 0x12BE0)
    AX = DI;
    // SUB AX,0x100 (1000_2BE2 / 0x12BE2)
    AX -= 0x100;
    // CMP AX,0x7aa (1000_2BE5 / 0x12BE5)
    Alu.Sub16(AX, 0x7AA);
    // JC 0x1000:2bf1 (1000_2BE8 / 0x12BE8)
    if(CarryFlag) {
      goto label_1000_2BF1_12BF1;
    }
    // MOV byte ptr [0x1193],0x0 (1000_2BEA / 0x12BEA)
    UInt8[DS, 0x1193] = 0x0;
    // JMP 0x1000:2bf4 (1000_2BEF / 0x12BEF)
    goto label_1000_2BF4_12BF4;
    label_1000_2BF1_12BF1:
    // CALL 0x1000:331e (1000_2BF1 / 0x12BF1)
    NearCall(cs1, 0x2BF4, spice86_generated_label_call_target_1000_331E_01331E);
    label_1000_2BF4_12BF4:
    // MOV AX,[0x1191] (1000_2BF4 / 0x12BF4)
    AX = UInt16[DS, 0x1191];
    // MOV [0xea],AL (1000_2BF7 / 0x12BF7)
    UInt8[DS, 0xEA] = AL;
    // CMP AL,0x1 (1000_2BFA / 0x12BFA)
    Alu.Sub8(AL, 0x1);
    // JNZ 0x1000:2c01 (1000_2BFC / 0x12BFC)
    if(!ZeroFlag) {
      goto label_1000_2C01_12C01;
    }
    // MOV [0xeb],AL (1000_2BFE / 0x12BFE)
    UInt8[DS, 0xEB] = AL;
    label_1000_2C01_12C01:
    // MOV AL,AH (1000_2C01 / 0x12C01)
    AL = AH;
    // XOR AH,AH (1000_2C03 / 0x12C03)
    AH = 0;
    // MOV DI,word ptr [0x1193] (1000_2C05 / 0x12C05)
    DI = UInt16[DS, 0x1193];
    // CMP AX,0x10 (1000_2C09 / 0x12C09)
    Alu.Sub16(AX, 0x10);
    // JNC 0x1000:2bcf (1000_2C0C / 0x12C0C)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      // JMP 0x1000:2a34 (1000_2BCF / 0x12BCF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_2A34_012A34, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP AL,0xe (1000_2C0E / 0x12C0E)
    Alu.Sub8(AL, 0xE);
    // JNZ 0x1000:2c16 (1000_2C10 / 0x12C10)
    if(!ZeroFlag) {
      goto label_1000_2C16_12C16;
    }
    // OR DI,DI (1000_2C12 / 0x12C12)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:2bcf (1000_2C14 / 0x12C14)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:2a34 (1000_2BCF / 0x12BCF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_2A34_012A34, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_2C16_12C16:
    // MOV [0x47c4],AX (1000_2C16 / 0x12C16)
    UInt16[DS, 0x47C4] = AX;
    // OR DI,DI (1000_2C19 / 0x12C19)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:2c47 (1000_2C1B / 0x12C1B)
    if(ZeroFlag) {
      goto label_1000_2C47_12C47;
    }
    // CALL 0x1000:331e (1000_2C1D / 0x12C1D)
    NearCall(cs1, 0x2C20, spice86_generated_label_call_target_1000_331E_01331E);
    // CALL 0x1000:2e98 (1000_2C20 / 0x12C20)
    NearCall(cs1, 0x2C23, spice86_generated_label_call_target_1000_2E98_012E98);
    // CMP word ptr [0x47c4],0xe (1000_2C23 / 0x12C23)
    Alu.Sub16(UInt16[DS, 0x47C4], 0xE);
    // JC 0x1000:2c47 (1000_2C28 / 0x12C28)
    if(CarryFlag) {
      goto label_1000_2C47_12C47;
    }
    // MOV AL,0x3 (1000_2C2A / 0x12C2A)
    AL = 0x3;
    // CMP byte ptr [0xea],0xe (1000_2C2C / 0x12C2C)
    Alu.Sub8(UInt8[DS, 0xEA], 0xE);
    // JZ 0x1000:2c3a (1000_2C31 / 0x12C31)
    if(ZeroFlag) {
      goto label_1000_2C3A_12C3A;
    }
    // MOV AL,byte ptr [DI + 0x9] (1000_2C33 / 0x12C33)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // OR AL,AL (1000_2C36 / 0x12C36)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:2c47 (1000_2C38 / 0x12C38)
    if(ZeroFlag) {
      goto label_1000_2C47_12C47;
    }
    label_1000_2C3A_12C3A:
    // CALL 0x1000:6906 (1000_2C3A / 0x12C3A)
    NearCall(cs1, 0x2C3D, spice86_generated_label_call_target_1000_6906_016906);
    // MOV word ptr [0x47c4],0xe (1000_2C3D / 0x12C3D)
    UInt16[DS, 0x47C4] = 0xE;
    // MOV word ptr [0x4756],SI (1000_2C43 / 0x12C43)
    UInt16[DS, 0x4756] = SI;
    label_1000_2C47_12C47:
    // CALL 0x1000:2c92 (1000_2C47 / 0x12C47)
    NearCall(cs1, 0x2C4A, not_observed_1000_2C92_012C92);
    // MOV AL,0x1 (1000_2C4A / 0x12C4A)
    AL = 0x1;
    // CALL 0x1000:9ef1 (1000_2C4C / 0x12C4C)
    NearCall(cs1, 0x2C4F, not_observed_1000_9EF1_019EF1);
    // CALL 0x1000:2a34 (1000_2C4F / 0x12C4F)
    NearCall(cs1, 0x2C52, not_observed_1000_2A34_012A34);
    // XOR AX,AX (1000_2C52 / 0x12C52)
    AX = 0;
    // MOV [0x1f0f],AL (1000_2C54 / 0x12C54)
    UInt8[DS, 0x1F0F] = AL;
    // MOV [0x1f10],AX (1000_2C57 / 0x12C57)
    UInt16[DS, 0x1F10] = AX;
    // CALL 0x1000:d397 (1000_2C5A / 0x12C5A)
    NearCall(cs1, 0x2C5D, spice86_generated_label_call_target_1000_D397_01D397);
    // CALL 0x1000:b2b9 (1000_2C5D / 0x12C5D)
    NearCall(cs1, 0x2C60, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    // MOV AX,0xbb8 (1000_2C60 / 0x12C60)
    AX = 0xBB8;
    // CALL 0x1000:ddb0 (1000_2C63 / 0x12C63)
    NearCall(cs1, 0x2C66, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    // CALL 0x1000:b2b3 (1000_2C66 / 0x12C66)
    NearCall(cs1, 0x2C69, spice86_generated_label_call_target_1000_B2B3_01B2B3);
    // MOV SI,0x2cc7 (1000_2C69 / 0x12C69)
    SI = 0x2CC7;
    // CALL 0x1000:da5f (1000_2C6C / 0x12C6C)
    NearCall(cs1, 0x2C6F, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // CALL 0x1000:98e6 (1000_2C6F / 0x12C6F)
    NearCall(cs1, 0x2C72, spice86_generated_label_call_target_1000_98E6_0198E6);
    // XOR AX,AX (1000_2C72 / 0x12C72)
    AX = 0;
    // MOV [0x479e],AX (1000_2C74 / 0x12C74)
    UInt16[DS, 0x479E] = AX;
    // MOV [0x4540],AX (1000_2C77 / 0x12C77)
    UInt16[DS, 0x4540] = AX;
    // MOV byte ptr [0xea],0xff (1000_2C7A / 0x12C7A)
    UInt8[DS, 0xEA] = 0xFF;
    // MOV byte ptr [0xe8],0xa (1000_2C7F / 0x12C7F)
    UInt8[DS, 0xE8] = 0xA;
    // MOV word ptr [0xdc30],0x0 (1000_2C84 / 0x12C84)
    UInt16[DS, 0xDC30] = 0x0;
    // MOV AL,0x6 (1000_2C8A / 0x12C8A)
    AL = 0x6;
    // CALL 0x1000:189a (1000_2C8C / 0x12C8C)
    NearCall(cs1, 0x2C8F, spice86_generated_label_call_target_1000_189A_01189A);
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
    label_1000_2C92_12C92:
    // MOV AL,0x6 (1000_2C92 / 0x12C92)
    AL = 0x6;
    // MOV BP,0x2c9a (1000_2C94 / 0x12C94)
    BP = 0x2C9A;
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
    label_1000_2D74_12D74:
    // MOV SI,word ptr [0x114e] (1000_2D74 / 0x12D74)
    SI = UInt16[DS, 0x114E];
    // CMP SI,0x100 (1000_2D78 / 0x12D78)
    Alu.Sub16(SI, 0x100);
    // JC 0x1000:2db0 (1000_2D7C / 0x12D7C)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    // XOR AX,AX (1000_2D7E / 0x12D7E)
    AX = 0;
    // CALL 0x1000:5e4f (1000_2D80 / 0x12D80)
    NearCall(cs1, 0x2D83, spice86_generated_label_call_target_1000_5E4F_015E4F);
    label_1000_2D83_12D83:
    // CMP AX,0x2 (1000_2D83 / 0x12D83)
    Alu.Sub16(AX, 0x2);
    // JNC 0x1000:2d8f (1000_2D86 / 0x12D86)
    if(!CarryFlag) {
      goto label_1000_2D8F_12D8F;
    }
    // TEST byte ptr [0x4732],0x1 (1000_2D88 / 0x12D88)
    Alu.And8(UInt8[DS, 0x4732], 0x1);
    // JNZ 0x1000:2db0 (1000_2D8D / 0x12D8D)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    label_1000_2D8F_12D8F:
    // CMP AX,0x4 (1000_2D8F / 0x12D8F)
    Alu.Sub16(AX, 0x4);
    // JA 0x1000:2db0 (1000_2D92 / 0x12D92)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    // JNZ 0x1000:2d97 (1000_2D94 / 0x12D94)
    if(!ZeroFlag) {
      goto label_1000_2D97_12D97;
    }
    // DEC AX (1000_2D96 / 0x12D96)
    AX--;
    label_1000_2D97_12D97:
    // CMP byte ptr [0x144c],AL (1000_2D97 / 0x12D97)
    Alu.Sub8(UInt8[DS, 0x144C], AL);
    // JZ 0x1000:2db0 (1000_2D9B / 0x12D9B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2DB0 / 0x12DB0)
      return NearRet();
    }
    // MOV [0x144c],AL (1000_2D9D / 0x12D9D)
    UInt8[DS, 0x144C] = AL;
    // ADD AX,0xa1 (1000_2DA0 / 0x12DA0)
    // AX += 0xA1;
    AX = Alu.Add16(AX, 0xA1);
    // PUSH DS (1000_2DA3 / 0x12DA3)
    Stack.Push(DS);
    // POP ES (1000_2DA4 / 0x12DA4)
    ES = Stack.Pop();
    // MOV DI,0xbc6e (1000_2DA5 / 0x12DA5)
    DI = 0xBC6E;
    // MOV SI,AX (1000_2DA8 / 0x12DA8)
    SI = AX;
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
    label_1000_2DB0_12DB0:
    // RET  (1000_2DB0 / 0x12DB0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2DB1_012DB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2DB1_12DB1:
    // MOV BP,0xd717 (1000_2DB1 / 0x12DB1)
    BP = 0xD717;
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
    label_1000_2DB7_12DB7:
    // CALL 0x1000:d95b (1000_2DB7 / 0x12DB7)
    NearCall(cs1, 0x2DBA, spice86_generated_label_call_target_1000_D95B_01D95B);
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
    label_1000_2DC2_12DC2:
    // XOR AX,AX (1000_2DC2 / 0x12DC2)
    AX = 0;
    // MOV [0xdce6],AL (1000_2DC4 / 0x12DC4)
    UInt8[DS, 0xDCE6] = AL;
    // MOV [0x47a4],AL (1000_2DC7 / 0x12DC7)
    UInt8[DS, 0x47A4] = AL;
    // MOV [0x47aa],AX (1000_2DCA / 0x12DCA)
    UInt16[DS, 0x47AA] = AX;
    // MOV BP,0x2eb2 (1000_2DCD / 0x12DCD)
    BP = 0x2EB2;
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
    label_1000_2DD3_12DD3:
    // CMP byte ptr [0x2b],0x0 (1000_2DD3 / 0x12DD3)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:2dfb (1000_2DD8 / 0x12DD8)
    if(ZeroFlag) {
      goto label_1000_2DFB_12DFB;
    }
    // MOV byte ptr [0x4732],0x0 (1000_2DDA / 0x12DDA)
    UInt8[DS, 0x4732] = 0x0;
    // CALL 0x1000:2d74 (1000_2DDF / 0x12DDF)
    NearCall(cs1, 0x2DE2, spice86_generated_label_call_target_1000_2D74_012D74);
    // OR byte ptr [0x11bc],0x1 (1000_2DE2 / 0x12DE2)
    // UInt8[DS, 0x11BC] |= 0x1;
    UInt8[DS, 0x11BC] = Alu.Or8(UInt8[DS, 0x11BC], 0x1);
    // MOV byte ptr [0x46df],0x0 (1000_2DE7 / 0x12DE7)
    UInt8[DS, 0x46DF] = 0x0;
    // CALL 0x1000:0acd (1000_2DEC / 0x12DEC)
    NearCall(cs1, 0x2DEF, not_observed_1000_0ACD_010ACD);
    // CALL 0x1000:1797 (1000_2DEF / 0x12DEF)
    NearCall(cs1, 0x2DF2, spice86_generated_label_call_target_1000_1797_011797);
    // CALL 0x1000:c4cd (1000_2DF2 / 0x12DF2)
    NearCall(cs1, 0x2DF5, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    // CALL 0x1000:c0f4 (1000_2DF5 / 0x12DF5)
    NearCall(cs1, 0x2DF8, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // JMP 0x1000:17e6 (1000_2DF8 / 0x12DF8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2DFB_12DFB:
    // TEST byte ptr [0x4732],0x1 (1000_2DFB / 0x12DFB)
    Alu.And8(UInt8[DS, 0x4732], 0x1);
    // JZ 0x1000:2e05 (1000_2E00 / 0x12E00)
    if(ZeroFlag) {
      goto label_1000_2E05_12E05;
    }
    // CALL 0x1000:488a (1000_2E02 / 0x12E02)
    NearCall(cs1, 0x2E05, not_observed_1000_488A_01488A);
    label_1000_2E05_12E05:
    // XOR AX,AX (1000_2E05 / 0x12E05)
    AX = 0;
    // MOV [0x14],AX (1000_2E07 / 0x12E07)
    UInt16[DS, 0x14] = AX;
    // MOV [0x46df],AL (1000_2E0A / 0x12E0A)
    UInt8[DS, 0x46DF] = AL;
    // CALL 0x1000:c07c (1000_2E0D / 0x12E0D)
    NearCall(cs1, 0x2E10, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_2E10_12E10:
    // CALL 0x1000:5ba0 (1000_2E10 / 0x12E10)
    NearCall(cs1, 0x2E13, spice86_generated_label_call_target_1000_5BA0_015BA0);
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
    label_1000_2E16_12E16:
    // TEST byte ptr [0x11c9],0x3 (1000_2E16 / 0x12E16)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JNZ 0x1000:2e20 (1000_2E1B / 0x12E1B)
    if(!ZeroFlag) {
      goto label_1000_2E20_12E20;
    }
    // CALL 0x1000:c412 (1000_2E1D / 0x12E1D)
    NearCall(cs1, 0x2E20, spice86_generated_label_call_target_1000_C412_01C412);
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
    label_1000_2E23_12E23:
    // CALL 0x1000:1834 (1000_2E23 / 0x12E23)
    NearCall(cs1, 0x2E26, spice86_generated_label_call_target_1000_1834_011834);
    label_1000_2E26_12E26:
    // CALL 0x1000:1797 (1000_2E26 / 0x12E26)
    NearCall(cs1, 0x2E29, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_2E29_12E29:
    // MOV AL,[0x46df] (1000_2E29 / 0x12E29)
    AL = UInt8[DS, 0x46DF];
    // MOV AH,AL (1000_2E2C / 0x12E2C)
    AH = AL;
    // XCHG byte ptr [0x46e0],AL (1000_2E2E / 0x12E2E)
    byte tmp_1000_2E2E = UInt8[DS, 0x46E0];
    UInt8[DS, 0x46E0] = AL;
    AL = tmp_1000_2E2E;
    // CMP AL,AH (1000_2E32 / 0x12E32)
    Alu.Sub8(AL, AH);
    // JZ 0x1000:2e4c (1000_2E34 / 0x12E34)
    if(ZeroFlag) {
      goto label_1000_2E4C_12E4C;
    }
    // MOV AX,[0xdbd6] (1000_2E36 / 0x12E36)
    AX = UInt16[DS, 0xDBD6];
    // CMP AX,word ptr [0xdbd8] (1000_2E39 / 0x12E39)
    Alu.Sub16(AX, UInt16[DS, 0xDBD8]);
    // JZ 0x1000:2e52 (1000_2E3D / 0x12E3D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,0x10 (1000_2E3F / 0x12E3F)
    AL = 0x10;
    // MOV BP,0xf66 (1000_2E41 / 0x12E41)
    BP = 0xF66;
    // CALL 0x1000:c108 (1000_2E44 / 0x12E44)
    NearCall(cs1, 0x2E47, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_2E47_12E47:
    // CALL 0x1000:ae04 (1000_2E47 / 0x12E47)
    NearCall(cs1, 0x2E4A, spice86_generated_label_call_target_1000_AE04_01AE04);
    label_1000_2E4A_12E4A:
    // JMP 0x1000:2e52 (1000_2E4A / 0x12E4A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2E52_012E52, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2E4C_12E4C:
    // CALL 0x1000:c0f4 (1000_2E4C / 0x12E4C)
    NearCall(cs1, 0x2E4F, spice86_generated_label_call_target_1000_C0F4_01C0F4);
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
    label_1000_2E55_12E55:
    // MOV AX,[0xce7a] (1000_2E55 / 0x12E55)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc5a],AX (1000_2E58 / 0x12E58)
    UInt16[DS, 0xDC5A] = AX;
    // CMP byte ptr [0x47a7],0x0 (1000_2E5B / 0x12E5B)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    // JNZ 0x1000:2e97 (1000_2E60 / 0x12E60)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    // MOV AL,[0x4735] (1000_2E62 / 0x12E62)
    AL = UInt8[DS, 0x4735];
    // OR AL,AL (1000_2E65 / 0x12E65)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:2e6c (1000_2E67 / 0x12E67)
    if(!SignFlag) {
      goto label_1000_2E6C_12E6C;
    }
    // JMP 0x1000:3723 (1000_2E69 / 0x12E69)
    throw FailAsUntested("Would have been a goto but label label_1000_3723_13723 does not exist because no instruction was found there that belongs to a function.");
    label_1000_2E6C_12E6C:
    // CMP byte ptr [0x8],0xff (1000_2E6C / 0x12E6C)
    Alu.Sub8(UInt8[DS, 0x8], 0xFF);
    // JZ 0x1000:2e7d (1000_2E71 / 0x12E71)
    if(ZeroFlag) {
      goto label_1000_2E7D_12E7D;
    }
    // CMP byte ptr [0x4774],0x0 (1000_2E73 / 0x12E73)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JNZ 0x1000:2e97 (1000_2E78 / 0x12E78)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    // JMP 0x1000:17e6 (1000_2E7A / 0x12E7A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2E7D_12E7D:
    // CMP byte ptr [0x11c9],0x0 (1000_2E7D / 0x12E7D)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:2e97 (1000_2E82 / 0x12E82)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    // MOV SI,word ptr [0x47aa] (1000_2E84 / 0x12E84)
    SI = UInt16[DS, 0x47AA];
    // OR SI,SI (1000_2E88 / 0x12E88)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:2e97 (1000_2E8A / 0x12E8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2E97 / 0x12E97)
      return NearRet();
    }
    // XOR AX,AX (1000_2E8C / 0x12E8C)
    AX = 0;
    // MOV AL,byte ptr [SI + 0xe] (1000_2E8E / 0x12E8E)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // MOV [0x47c4],AX (1000_2E91 / 0x12E91)
    UInt16[DS, 0x47C4] = AX;
    // CALL 0x1000:978e (1000_2E94 / 0x12E94)
    NearCall(cs1, 0x2E97, spice86_generated_label_call_target_1000_978E_01978E);
    label_1000_2E97_12E97:
    // RET  (1000_2E97 / 0x12E97)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2E98_012E98(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2E98_12E98:
    // MOV word ptr [0x47e6],DI (1000_2E98 / 0x12E98)
    UInt16[DS, 0x47E6] = DI;
    // XOR AH,AH (1000_2E9C / 0x12E9C)
    AH = 0;
    // MOV AL,byte ptr [DI] (1000_2E9E / 0x12E9E)
    AL = UInt8[DS, DI];
    // ADD AX,0x0 (1000_2EA0 / 0x12EA0)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    // MOV [0x11ed],AX (1000_2EA3 / 0x12EA3)
    UInt16[DS, 0x11ED] = AX;
    // MOV AL,byte ptr [DI + 0x1] (1000_2EA6 / 0x12EA6)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    // XOR AH,AH (1000_2EA9 / 0x12EA9)
    AH = 0;
    // ADD AX,0xc (1000_2EAB / 0x12EAB)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    // MOV [0x11ef],AX (1000_2EAE / 0x12EAE)
    UInt16[DS, 0x11EF] = AX;
    // RET  (1000_2EB1 / 0x12EB1)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2EB2_012EB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2EB2_12EB2:
    // CMP byte ptr [0x4774],0x0 (1000_2EB2 / 0x12EB2)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:2ec9 (1000_2EB7 / 0x12EB7)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_2EC9_012EC9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:301a (1000_2EB9 / 0x12EB9)
    NearCall(cs1, 0x2EBC, spice86_label_1000_301A_1301A);
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
    label_1000_2EBF_12EBF:
    // MOV BP,word ptr [0x2220] (1000_2EBF / 0x12EBF)
    BP = UInt16[DS, 0x2220];
    // MOV BX,0xf66 (1000_2EC3 / 0x12EC3)
    BX = 0xF66;
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
    label_1000_2EC9_12EC9:
    // MOV DI,word ptr [0x114e] (1000_2EC9 / 0x12EC9)
    DI = UInt16[DS, 0x114E];
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
    label_1000_2ED3_12ED3:
    // CMP byte ptr [0x11c9],0x0 (1000_2ED3 / 0x12ED3)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:2edd (1000_2ED8 / 0x12ED8)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_2EDD_012EDD, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
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
    label_1000_2EDD_12EDD:
    // MOV AX,[0xdc38] (1000_2EDD / 0x12EDD)
    AX = UInt16[DS, 0xDC38];
    // CMP AX,0x74 (1000_2EE0 / 0x12EE0)
    Alu.Sub16(AX, 0x74);
    // JC 0x1000:2eec (1000_2EE3 / 0x12EE3)
    if(CarryFlag) {
      goto label_1000_2EEC_12EEC;
    }
    // MOV AX,0xdbec (1000_2EE5 / 0x12EE5)
    AX = 0xDBEC;
    // PUSH AX (1000_2EE8 / 0x12EE8)
    Stack.Push(AX);
    // CALL 0x1000:dbb2 (1000_2EE9 / 0x12EE9)
    NearCall(cs1, 0x2EEC, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_2EEC_12EEC:
    // CALL 0x1000:2ffb (1000_2EEC / 0x12EEC)
    NearCall(cs1, 0x2EEF, spice86_generated_label_call_target_1000_2FFB_012FFB);
    label_1000_2EEF_12EEF:
    // CALL 0x1000:d763 (1000_2EEF / 0x12EEF)
    NearCall(cs1, 0x2EF2, spice86_generated_label_ret_target_1000_D763_01D763);
    label_1000_2EF2_12EF2:
    // MOV BP,0x1f0e (1000_2EF2 / 0x12EF2)
    BP = 0x1F0E;
    // MOV BX,0xf66 (1000_2EF5 / 0x12EF5)
    BX = 0xF66;
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
    label_1000_2EFB_12EFB:
    // PUSH DS (1000_2EFB / 0x12EFB)
    Stack.Push(DS);
    // POP ES (1000_2EFC / 0x12EFC)
    ES = Stack.Pop();
    // MOV DI,0x1f0f (1000_2EFD / 0x12EFD)
    DI = 0x1F0F;
    // XOR AL,AL (1000_2F00 / 0x12F00)
    AL = 0;
    // STOSB ES:DI (1000_2F02 / 0x12F02)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // MOV BX,word ptr [0x6] (1000_2F03 / 0x12F03)
    BX = UInt16[DS, 0x6];
    // MOV DX,word ptr [0x4] (1000_2F07 / 0x12F07)
    DX = UInt16[DS, 0x4];
    // CMP BL,0x80 (1000_2F0B / 0x12F0B)
    Alu.Sub8(BL, 0x80);
    // JZ 0x1000:2f13 (1000_2F0E / 0x12F0E)
    if(ZeroFlag) {
      goto label_1000_2F13_12F13;
    }
    // JMP 0x1000:2faa (1000_2F10 / 0x12F10)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FAA_012FAA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2F13_12F13:
    // MOV SI,0x220c (1000_2F13 / 0x12F13)
    SI = 0x220C;
    // MOVSW ES:DI,SI (1000_2F16 / 0x12F16)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F17 / 0x12F17)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // CMP DL,0x1 (1000_2F18 / 0x12F18)
    Alu.Sub8(DL, 0x1);
    // JNZ 0x1000:2f58 (1000_2F1B / 0x12F1B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2F58_012F58, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x2b],0x0 (1000_2F1D / 0x12F1D)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:2f3d (1000_2F22 / 0x12F22)
    if(ZeroFlag) {
      goto label_1000_2F3D_12F3D;
    }
    // MOV SI,0x2218 (1000_2F24 / 0x12F24)
    SI = 0x2218;
    // MOVSW ES:DI,SI (1000_2F27 / 0x12F27)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F28 / 0x12F28)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F29 / 0x12F29)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F2A / 0x12F2A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOV SI,0x2214 (1000_2F2B / 0x12F2B)
    SI = 0x2214;
    // LODSW SI (1000_2F2E / 0x12F2E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP byte ptr [0x2a],0x4f (1000_2F2F / 0x12F2F)
    Alu.Sub8(UInt8[DS, 0x2A], 0x4F);
    // SBB AH,AH (1000_2F34 / 0x12F34)
    AH = Alu.Sbb8(AH, AH);
    // AND AH,0x40 (1000_2F36 / 0x12F36)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    // STOSW ES:DI (1000_2F39 / 0x12F39)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F3A / 0x12F3A)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // JMP 0x1000:2fa3 (1000_2F3B / 0x12F3B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2F3D_12F3D:
    // PUSH DI (1000_2F3D / 0x12F3D)
    Stack.Push(DI);
    // MOV DI,word ptr [0x114e] (1000_2F3E / 0x12F3E)
    DI = UInt16[DS, 0x114E];
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
    label_1000_2F45_12F45:
    // POP DI (1000_2F45 / 0x12F45)
    DI = Stack.Pop();
    // MOV SI,0x21dc (1000_2F46 / 0x12F46)
    SI = 0x21DC;
    // LODSW SI (1000_2F49 / 0x12F49)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP byte ptr [0x46ff],0x1 (1000_2F4A / 0x12F4A)
    Alu.Sub8(UInt8[DS, 0x46FF], 0x1);
    // SBB AH,AH (1000_2F4F / 0x12F4F)
    AH = Alu.Sbb8(AH, AH);
    // AND AH,0x40 (1000_2F51 / 0x12F51)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    // STOSW ES:DI (1000_2F54 / 0x12F54)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F55 / 0x12F55)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
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
    label_1000_2F58_12F58:
    // CMP BH,0x1 (1000_2F58 / 0x12F58)
    Alu.Sub8(BH, 0x1);
    // JNZ 0x1000:2fa3 (1000_2F5B / 0x12F5B)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP DL,0x8 (1000_2F5D / 0x12F5D)
    Alu.Sub8(DL, 0x8);
    // JNZ 0x1000:2f99 (1000_2F60 / 0x12F60)
    if(!ZeroFlag) {
      goto label_1000_2F99_12F99;
    }
    // CMP byte ptr [0xc8],0x0 (1000_2F62 / 0x12F62)
    Alu.Sub8(UInt8[DS, 0xC8], 0x0);
    // JZ 0x1000:2fa3 (1000_2F67 / 0x12F67)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x21e8 (1000_2F69 / 0x12F69)
    SI = 0x21E8;
    // LODSW SI (1000_2F6C / 0x12F6C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CL,byte ptr [0xc9] (1000_2F6D / 0x12F6D)
    CL = UInt8[DS, 0xC9];
    // MOV CH,0x27 (1000_2F71 / 0x12F71)
    CH = 0x27;
    // CMP CL,0x1 (1000_2F73 / 0x12F73)
    Alu.Sub8(CL, 0x1);
    // SBB AH,AH (1000_2F76 / 0x12F76)
    AH = Alu.Sbb8(AH, AH);
    // ADD CH,AH (1000_2F78 / 0x12F78)
    CH += AH;
    // CMP byte ptr [0x47a9],0x0 (1000_2F7A / 0x12F7A)
    Alu.Sub8(UInt8[DS, 0x47A9], 0x0);
    // JZ 0x1000:2f83 (1000_2F7F / 0x12F7F)
    if(ZeroFlag) {
      goto label_1000_2F83_12F83;
    }
    // MOV CH,0x28 (1000_2F81 / 0x12F81)
    CH = 0x28;
    label_1000_2F83_12F83:
    // MOV byte ptr [0x1248],CH (1000_2F83 / 0x12F83)
    UInt8[DS, 0x1248] = CH;
    // AND AH,0x40 (1000_2F87 / 0x12F87)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    // STOSW ES:DI (1000_2F8A / 0x12F8A)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F8B / 0x12F8B)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_2F8C / 0x12F8C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP CL,byte ptr [0xc8] (1000_2F8D / 0x12F8D)
    Alu.Sub8(CL, UInt8[DS, 0xC8]);
    // CMC  (1000_2F91 / 0x12F91)
    CarryFlag = !CarryFlag;
    // SBB AH,AH (1000_2F92 / 0x12F92)
    AH = Alu.Sbb8(AH, AH);
    // AND AH,0x40 (1000_2F94 / 0x12F94)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    // STOSW ES:DI (1000_2F97 / 0x12F97)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2F98 / 0x12F98)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    label_1000_2F99_12F99:
    // CMP DL,0x9 (1000_2F99 / 0x12F99)
    Alu.Sub8(DL, 0x9);
    // JNZ 0x1000:2fa3 (1000_2F9C / 0x12F9C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FA3_012FA3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x21f0 (1000_2F9E / 0x12F9E)
    SI = 0x21F0;
    // MOVSW ES:DI,SI (1000_2FA1 / 0x12FA1)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
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
    label_1000_2FA3_12FA3:
    // MOV SI,0x21f4 (1000_2FA3 / 0x12FA3)
    SI = 0x21F4;
    // MOVSW ES:DI,SI (1000_2FA6 / 0x12FA6)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2FA7 / 0x12FA7)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
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
    label_1000_2FAA_12FAA:
    // TEST byte ptr [0x11c9],0x3 (1000_2FAA / 0x12FAA)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JNZ 0x1000:2fd7 (1000_2FAF / 0x12FAF)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_2FD7_012FD7, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x220c (1000_2FB1 / 0x12FB1)
    SI = 0x220C;
    // MOVSW ES:DI,SI (1000_2FB4 / 0x12FB4)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2FB5 / 0x12FB5)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOV SI,0x2214 (1000_2FB6 / 0x12FB6)
    SI = 0x2214;
    // LODSW SI (1000_2FB9 / 0x12FB9)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP byte ptr [0x2a],0x4f (1000_2FBA / 0x12FBA)
    Alu.Sub8(UInt8[DS, 0x2A], 0x4F);
    // SBB AH,AH (1000_2FBF / 0x12FBF)
    AH = Alu.Sbb8(AH, AH);
    // AND AH,0x40 (1000_2FC1 / 0x12FC1)
    // AH &= 0x40;
    AH = Alu.And8(AH, 0x40);
    // STOSW ES:DI (1000_2FC4 / 0x12FC4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2FC5 / 0x12FC5)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
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
    label_1000_2FC9_12FC9:
    // MOV SI,0x21e0 (1000_2FC9 / 0x12FC9)
    SI = 0x21E0;
    // CMP AL,0xb (1000_2FCC / 0x12FCC)
    Alu.Sub8(AL, 0xB);
    // JC 0x1000:2fd3 (1000_2FCE / 0x12FCE)
    if(CarryFlag) {
      goto label_1000_2FD3_12FD3;
    }
    // ADD SI,0x4 (1000_2FD0 / 0x12FD0)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    label_1000_2FD3_12FD3:
    // MOVSW ES:DI,SI (1000_2FD3 / 0x12FD3)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2FD4 / 0x12FD4)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
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
    label_1000_2FD7_12FD7:
    // MOV SI,0x21fc (1000_2FD7 / 0x12FD7)
    SI = 0x21FC;
    // CMP byte ptr [0x11cb],0x0 (1000_2FDA / 0x12FDA)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    // JZ 0x1000:2ff0 (1000_2FDF / 0x12FDF)
    if(ZeroFlag) {
      goto label_1000_2FF0_12FF0;
    }
    // MOV SI,0x2200 (1000_2FE1 / 0x12FE1)
    SI = 0x2200;
    // CMP byte ptr [0x2a],0x32 (1000_2FE4 / 0x12FE4)
    Alu.Sub8(UInt8[DS, 0x2A], 0x32);
    // JC 0x1000:2ff0 (1000_2FE9 / 0x12FE9)
    if(CarryFlag) {
      goto label_1000_2FF0_12FF0;
    }
    // MOVSW ES:DI,SI (1000_2FEB / 0x12FEB)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2FEC / 0x12FEC)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOV SI,0x2204 (1000_2FED / 0x12FED)
    SI = 0x2204;
    label_1000_2FF0_12FF0:
    // MOVSW ES:DI,SI (1000_2FF0 / 0x12FF0)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_2FF1 / 0x12FF1)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOV SI,0x21f8 (1000_2FF2 / 0x12FF2)
    SI = 0x21F8;
    // MOVSW ES:DI,SI (1000_2FF5 / 0x12FF5)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
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
    label_1000_2FF7_12FF7:
    // XOR AX,AX (1000_2FF7 / 0x12FF7)
    AX = 0;
    // STOSW ES:DI (1000_2FF9 / 0x12FF9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // RET  (1000_2FFA / 0x12FFA)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2FFB_012FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2FFB_12FFB:
    // CMP byte ptr [0x2b],0x0 (1000_2FFB / 0x12FFB)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:301a (1000_3000 / 0x13000)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_301A_1301A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // TEST byte ptr [0x11c9],0x3 (1000_3002 / 0x13002)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JZ 0x1000:3020 (1000_3007 / 0x13007)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_3020_013020, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x11ca],0x0 (1000_3009 / 0x13009)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    // JNZ 0x1000:301a (1000_300E / 0x1300E)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_301A_1301A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1d72 (1000_3010 / 0x13010)
    SI = 0x1D72;
    // CMP byte ptr [0x11cb],0x0 (1000_3013 / 0x13013)
    Alu.Sub8(UInt8[DS, 0x11CB], 0x0);
    // JNZ 0x1000:301d (1000_3018 / 0x13018)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
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
    label_1000_301A_1301A:
    // MOV SI,0x1d1e (1000_301A / 0x1301A)
    SI = 0x1D1E;
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
    label_1000_3020_13020:
    // MOV BX,word ptr [0x6] (1000_3020 / 0x13020)
    BX = UInt16[DS, 0x6];
    // CMP BL,0x80 (1000_3024 / 0x13024)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:3073 (1000_3027 / 0x13027)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3073_013073, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV DX,word ptr [0x4] (1000_3029 / 0x13029)
    DX = UInt16[DS, 0x4];
    // CMP DH,0x21 (1000_302D / 0x1302D)
    Alu.Sub8(DH, 0x21);
    // JZ 0x1000:3073 (1000_3030 / 0x13030)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3073_013073, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
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
    label_1000_3035_13035:
    // INC SI (1000_3035 / 0x13035)
    SI = Alu.Inc16(SI);
    // MOV DI,0x1b96 (1000_3036 / 0x13036)
    DI = 0x1B96;
    // MOV AL,0x20 (1000_3039 / 0x13039)
    AL = 0x20;
    // CMP word ptr [0x114e],0x100 (1000_303B / 0x1303B)
    Alu.Sub16(UInt16[DS, 0x114E], 0x100);
    // JNZ 0x1000:3045 (1000_3041 / 0x13041)
    if(!ZeroFlag) {
      goto label_1000_3045_13045;
    }
    // MOV AL,0x80 (1000_3043 / 0x13043)
    AL = 0x80;
    label_1000_3045_13045:
    // MOV BX,0x21 (1000_3045 / 0x13045)
    BX = 0x21;
    // CMP DL,0x1 (1000_3048 / 0x13048)
    Alu.Sub8(DL, 0x1);
    // JNZ 0x1000:3050 (1000_304B / 0x1304B)
    if(!ZeroFlag) {
      goto label_1000_3050_13050;
    }
    // INC BX (1000_304D / 0x1304D)
    BX = Alu.Inc16(BX);
    // MOV AL,0x20 (1000_304E / 0x1304E)
    AL = 0x20;
    label_1000_3050_13050:
    // MOV word ptr [DI + 0x2],BX (1000_3050 / 0x13050)
    UInt16[DS, (ushort)(DI + 0x2)] = BX;
    // MOV byte ptr [DI + 0x46],AL (1000_3053 / 0x13053)
    UInt8[DS, (ushort)(DI + 0x46)] = AL;
    // MOV [0x1cc4],AL (1000_3056 / 0x13056)
    UInt8[DS, 0x1CC4] = AL;
    // MOV CX,0x4 (1000_3059 / 0x13059)
    CX = 0x4;
    label_1000_305C_1305C:
    // LODSB SI (1000_305C / 0x1305C)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // ADD DI,0xe (1000_305D / 0x1305D)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    // MOV AH,0x20 (1000_3060 / 0x13060)
    AH = 0x20;
    // OR AL,AL (1000_3062 / 0x13062)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:306c (1000_3064 / 0x13064)
    if(ZeroFlag) {
      goto label_1000_306C_1306C;
    }
    // CMP AL,0xfb (1000_3066 / 0x13066)
    Alu.Sub8(AL, 0xFB);
    // JL 0x1000:306c (1000_3068 / 0x13068)
    if(SignFlag != OverflowFlag) {
      goto label_1000_306C_1306C;
    }
    // MOV AH,0x80 (1000_306A / 0x1306A)
    AH = 0x80;
    label_1000_306C_1306C:
    // MOV byte ptr [DI],AH (1000_306C / 0x1306C)
    UInt8[DS, DI] = AH;
    // LOOP 0x1000:305c (1000_306E / 0x1306E)
    if(--CX != 0) {
      goto label_1000_305C_1305C;
    }
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
    label_1000_3073_13073:
    // MOV DI,0x1b98 (1000_3073 / 0x13073)
    DI = 0x1B98;
    // MOV word ptr [DI],0x23 (1000_3076 / 0x13076)
    UInt16[DS, DI] = 0x23;
    // MOV BX,0x1d (1000_307A / 0x1307A)
    BX = 0x1D;
    // MOV CX,0x4 (1000_307D / 0x1307D)
    CX = 0x4;
    label_1000_3080_13080:
    // ADD DI,0xe (1000_3080 / 0x13080)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    // MOV word ptr [DI],BX (1000_3083 / 0x13083)
    UInt16[DS, DI] = BX;
    // MOV word ptr [DI + -0x2],0x80 (1000_3085 / 0x13085)
    UInt16[DS, (ushort)(DI - 0x2)] = 0x80;
    // INC BX (1000_308A / 0x1308A)
    BX = Alu.Inc16(BX);
    // LOOP 0x1000:3080 (1000_308B / 0x1308B)
    if(--CX != 0) {
      goto label_1000_3080_13080;
    }
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
    label_1000_3093_13093:
    // CALL 0x1000:3127 (1000_3093 / 0x13093)
    NearCall(cs1, 0x3096, spice86_generated_label_call_target_1000_3127_013127);
    label_1000_3096_13096:
    // MOV DI,0x1f0c (1000_3096 / 0x13096)
    DI = 0x1F0C;
    label_1000_3099_13099:
    // ADD DI,0x4 (1000_3099 / 0x13099)
    DI += 0x4;
    // CMP word ptr [DI],0x0 (1000_309C / 0x1309C)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    // JNZ 0x1000:3099 (1000_309F / 0x1309F)
    if(!ZeroFlag) {
      goto label_1000_3099_13099;
    }
    // MOV word ptr [0x12],0x0 (1000_30A1 / 0x130A1)
    UInt16[DS, 0x12] = 0x0;
    // PUSH DS (1000_30A7 / 0x130A7)
    Stack.Push(DS);
    // POP ES (1000_30A8 / 0x130A8)
    ES = Stack.Pop();
    // MOV BP,0x30b9 (1000_30A9 / 0x130A9)
    BP = 0x30B9;
    // CALL 0x1000:36ee (1000_30AC / 0x130AC)
    NearCall(cs1, 0x30AF, spice86_generated_label_call_target_1000_36EE_0136EE);
    label_1000_30AF_130AF:
    // MOV BP,0x3120 (1000_30AF / 0x130AF)
    BP = 0x3120;
    // CALL 0x1000:36ee (1000_30B2 / 0x130B2)
    NearCall(cs1, 0x30B5, spice86_generated_label_call_target_1000_36EE_0136EE);
    label_1000_30B5_130B5:
    // XOR AX,AX (1000_30B5 / 0x130B5)
    AX = 0;
    // STOSW ES:DI (1000_30B7 / 0x130B7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
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
    label_1000_30B9_130B9:
    // TEST byte ptr [SI + 0xf],0x40 (1000_30B9 / 0x130B9)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JNZ 0x1000:311f (1000_30BD / 0x130BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    // CMP word ptr [0x47aa],0x0 (1000_30BF / 0x130BF)
    Alu.Sub16(UInt16[DS, 0x47AA], 0x0);
    // JNZ 0x1000:30ca (1000_30C4 / 0x130C4)
    if(!ZeroFlag) {
      goto label_1000_30CA_130CA;
    }
    // MOV word ptr [0x47aa],SI (1000_30C6 / 0x130C6)
    UInt16[DS, 0x47AA] = SI;
    label_1000_30CA_130CA:
    // MOV AL,byte ptr [SI + 0xe] (1000_30CA / 0x130CA)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // MOV CL,AL (1000_30CD / 0x130CD)
    CL = AL;
    // XOR AH,AH (1000_30CF / 0x130CF)
    AH = 0;
    // ADD AX,0x78 (1000_30D1 / 0x130D1)
    // AX += 0x78;
    AX = Alu.Add16(AX, 0x78);
    // STOSW ES:DI (1000_30D4 / 0x130D4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AX,0x1 (1000_30D5 / 0x130D5)
    AX = 0x1;
    // SHL AX,CL (1000_30D8 / 0x130D8)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    // OR word ptr [0x12],AX (1000_30DA / 0x130DA)
    // UInt16[DS, 0x12] |= AX;
    UInt16[DS, 0x12] = Alu.Or16(UInt16[DS, 0x12], AX);
    // MOV AX,word ptr [SI + 0x4] (1000_30DE / 0x130DE)
    AX = UInt16[DS, (ushort)(SI + 0x4)];
    // STOSW ES:DI (1000_30E1 / 0x130E1)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP CL,0xf (1000_30E2 / 0x130E2)
    Alu.Sub8(CL, 0xF);
    // JNZ 0x1000:311f (1000_30E5 / 0x130E5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    // MOV CL,byte ptr [0x476a] (1000_30E7 / 0x130E7)
    CL = UInt8[DS, 0x476A];
    // XOR CH,CH (1000_30EB / 0x130EB)
    CH = 0;
    // DEC CX (1000_30ED / 0x130ED)
    CX = Alu.Dec16(CX);
    // JLE 0x1000:30fe (1000_30EE / 0x130EE)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_30FE_130FE;
    }
    // PUSH SI (1000_30F0 / 0x130F0)
    Stack.Push(SI);
    // MOV SI,AX (1000_30F1 / 0x130F1)
    SI = AX;
    // MOV AX,0x87 (1000_30F3 / 0x130F3)
    AX = 0x87;
    label_1000_30F6_130F6:
    // INC AX (1000_30F6 / 0x130F6)
    AX = Alu.Inc16(AX);
    // STOSW ES:DI (1000_30F7 / 0x130F7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // XCHG AX,SI (1000_30F8 / 0x130F8)
    ushort tmp_1000_30F8 = AX;
    AX = SI;
    SI = tmp_1000_30F8;
    // STOSW ES:DI (1000_30F9 / 0x130F9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // XCHG AX,SI (1000_30FA / 0x130FA)
    ushort tmp_1000_30FA = AX;
    AX = SI;
    SI = tmp_1000_30FA;
    // LOOP 0x1000:30f6 (1000_30FB / 0x130FB)
    if(--CX != 0) {
      goto label_1000_30F6_130F6;
    }
    // POP SI (1000_30FD / 0x130FD)
    SI = Stack.Pop();
    label_1000_30FE_130FE:
    // CMP byte ptr [0x2a],0x5 (1000_30FE / 0x130FE)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5);
    // JC 0x1000:311f (1000_3103 / 0x13103)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    // MOV AL,[0x476b] (1000_3105 / 0x13105)
    AL = UInt8[DS, 0x476B];
    // OR AL,AL (1000_3108 / 0x13108)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:311f (1000_310A / 0x1310A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_311F / 0x1311F)
      return NearRet();
    }
    // PUSH DI (1000_310C / 0x1310C)
    Stack.Push(DI);
    // DEC AL (1000_310D / 0x1310D)
    AL--;
    // SUB AL,byte ptr [0x476a] (1000_310F / 0x1310F)
    // AL -= UInt8[DS, 0x476A];
    AL = Alu.Sub8(AL, UInt8[DS, 0x476A]);
    // CBW  (1000_3113 / 0x13113)
    AX = (ushort)((short)((sbyte)AL));
    // SHL AX,1 (1000_3114 / 0x13114)
    AX <<= 0x1;
    // SHL AX,1 (1000_3116 / 0x13116)
    AX <<= 0x1;
    // ADD DI,AX (1000_3118 / 0x13118)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // MOV word ptr [DI],0x8f (1000_311A / 0x1311A)
    UInt16[DS, DI] = 0x8F;
    // POP DI (1000_311E / 0x1311E)
    DI = Stack.Pop();
    label_1000_311F_1311F:
    // RET  (1000_311F / 0x1311F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3120_013120(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3120_13120:
    // TEST byte ptr [SI + 0xf],0x40 (1000_3120 / 0x13120)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JNZ 0x1000:30ca (1000_3124 / 0x13124)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_30B9_0130B9, 0x130CA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_3126 / 0x13126)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3127_013127(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3127_13127:
    // MOV byte ptr [0x476b],0x0 (1000_3127 / 0x13127)
    UInt8[DS, 0x476B] = 0x0;
    // MOV byte ptr [0x476a],0x0 (1000_312C / 0x1312C)
    UInt8[DS, 0x476A] = 0x0;
    // MOV AX,0x7f80 (1000_3131 / 0x13131)
    AX = 0x7F80;
    // MOV [0x10ca],AX (1000_3134 / 0x13134)
    UInt16[DS, 0x10CA] = AX;
    // MOV [0x10ba],AX (1000_3137 / 0x13137)
    UInt16[DS, 0x10BA] = AX;
    // MOV [0x10aa],AX (1000_313A / 0x1313A)
    UInt16[DS, 0x10AA] = AX;
    // MOV [0x109a],AX (1000_313D / 0x1313D)
    UInt16[DS, 0x109A] = AX;
    // MOV BX,word ptr [0x6] (1000_3140 / 0x13140)
    BX = UInt16[DS, 0x6];
    // CMP BL,0x80 (1000_3144 / 0x13144)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:316d (1000_3147 / 0x13147)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_316D / 0x1316D)
      return NearRet();
    }
    // MOV DI,word ptr [0x114e] (1000_3149 / 0x13149)
    DI = UInt16[DS, 0x114E];
    // MOV DX,word ptr [0x4] (1000_314D / 0x1314D)
    DX = UInt16[DS, 0x4];
    // MOV BP,0x316e (1000_3151 / 0x13151)
    BP = 0x316E;
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
    label_1000_3157_13157:
    // CMP byte ptr [DI + 0x8],0x21 (1000_3157 / 0x13157)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x21);
    // JNZ 0x1000:316a (1000_315B / 0x1315B)
    if(!ZeroFlag) {
      goto label_1000_316A_1316A;
    }
    // MOV word ptr [0x10a8],DX (1000_315D / 0x1315D)
    UInt16[DS, 0x10A8] = DX;
    // MOV word ptr [0x10aa],BX (1000_3161 / 0x13161)
    UInt16[DS, 0x10AA] = BX;
    // PUSH DI (1000_3165 / 0x13165)
    Stack.Push(DI);
    // CALL 0x1000:2318 (1000_3166 / 0x13166)
    NearCall(cs1, 0x3169, not_observed_1000_2318_012318);
    // POP DI (1000_3169 / 0x13169)
    DI = Stack.Pop();
    label_1000_316A_1316A:
    // CALL 0x1000:331e (1000_316A / 0x1316A)
    NearCall(cs1, 0x316D, spice86_generated_label_call_target_1000_331E_01331E);
    label_1000_316D_1316D:
    // RET  (1000_316D / 0x1316D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_316E_01316E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_316E_1316E:
    // MOV AL,byte ptr [SI + 0x3] (1000_316E / 0x1316E)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // MOV AH,0x2 (1000_3171 / 0x13171)
    AH = 0x2;
    // TEST AL,0x20 (1000_3173 / 0x13173)
    Alu.And8(AL, 0x20);
    // JZ 0x1000:3181 (1000_3175 / 0x13175)
    if(ZeroFlag) {
      goto label_1000_3181_13181;
    }
    // CMP byte ptr [DI + 0x8],0x28 (1000_3177 / 0x13177)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JC 0x1000:3190 (1000_317B / 0x1317B)
    if(CarryFlag) {
      goto label_1000_3190_13190;
    }
    // INC AH (1000_317D / 0x1317D)
    AH = Alu.Inc8(AH);
    // JMP 0x1000:3190 (1000_317F / 0x1317F)
    goto label_1000_3190_13190;
    label_1000_3181_13181:
    // TEST byte ptr [SI + 0x10],0x80 (1000_3181 / 0x13181)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:316d (1000_3185 / 0x13185)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_316D / 0x1316D)
      return NearRet();
    }
    // CMP byte ptr [0x2b],0x0 (1000_3187 / 0x13187)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:3190 (1000_318C / 0x1318C)
    if(ZeroFlag) {
      goto label_1000_3190_13190;
    }
    // DEC AH (1000_318E / 0x1318E)
    AH--;
    label_1000_3190_13190:
    // CMP AH,DL (1000_3190 / 0x13190)
    Alu.Sub8(AH, DL);
    // JNZ 0x1000:316d (1000_3192 / 0x13192)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_316D / 0x1316D)
      return NearRet();
    }
    // TEST byte ptr [SI + 0x10],0x80 (1000_3194 / 0x13194)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:31c9 (1000_3198 / 0x13198)
    if(!ZeroFlag) {
      goto label_1000_31C9_131C9;
    }
    // MOV BP,0x10b8 (1000_319A / 0x1319A)
    BP = 0x10B8;
    // MOV DI,0x4756 (1000_319D / 0x1319D)
    DI = 0x4756;
    // CMP AL,0x80 (1000_31A0 / 0x131A0)
    Alu.Sub8(AL, 0x80);
    // JNC 0x1000:31ed (1000_31A2 / 0x131A2)
    if(!CarryFlag) {
      goto label_1000_31ED_131ED;
    }
    // MOV BP,0x10c8 (1000_31A4 / 0x131A4)
    BP = 0x10C8;
    // MOV DI,0x4758 (1000_31A7 / 0x131A7)
    DI = 0x4758;
    // AND byte ptr [0x476a],0x7 (1000_31AA / 0x131AA)
    // UInt8[DS, 0x476A] &= 0x7;
    UInt8[DS, 0x476A] = Alu.And8(UInt8[DS, 0x476A], 0x7);
    // MOV AL,[0x476a] (1000_31AF / 0x131AF)
    AL = UInt8[DS, 0x476A];
    // INC byte ptr [0x476a] (1000_31B2 / 0x131B2)
    UInt8[DS, 0x476A]++;
    // XOR AH,AH (1000_31B6 / 0x131B6)
    AH = 0;
    // CMP SI,0x8e0 (1000_31B8 / 0x131B8)
    Alu.Sub16(SI, 0x8E0);
    // JNZ 0x1000:31c3 (1000_31BC / 0x131BC)
    if(!ZeroFlag) {
      goto label_1000_31C3_131C3;
    }
    // INC AX (1000_31BE / 0x131BE)
    AX = Alu.Inc16(AX);
    // MOV [0x476b],AL (1000_31BF / 0x131BF)
    UInt8[DS, 0x476B] = AL;
    // DEC AX (1000_31C2 / 0x131C2)
    AX--;
    label_1000_31C3_131C3:
    // SHL AX,1 (1000_31C3 / 0x131C3)
    AX <<= 0x1;
    // ADD DI,AX (1000_31C5 / 0x131C5)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    // JMP 0x1000:31ed (1000_31C7 / 0x131C7)
    goto label_1000_31ED_131ED;
    label_1000_31C9_131C9:
    // MOV BP,0x1098 (1000_31C9 / 0x131C9)
    BP = 0x1098;
    // MOV DI,0x4768 (1000_31CC / 0x131CC)
    DI = 0x4768;
    // MOV AL,byte ptr [SI + 0x3] (1000_31CF / 0x131CF)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // AND AL,0x10 (1000_31D2 / 0x131D2)
    AL &= 0x10;
    // AND byte ptr [BP + 0xf],0xef (1000_31D4 / 0x131D4)
    // UInt8[SS, (ushort)(BP + 0xF)] &= 0xEF;
    UInt8[SS, (ushort)(BP + 0xF)] = Alu.And8(UInt8[SS, (ushort)(BP + 0xF)], 0xEF);
    // OR byte ptr [BP + 0xf],AL (1000_31D8 / 0x131D8)
    // UInt8[SS, (ushort)(BP + 0xF)] |= AL;
    UInt8[SS, (ushort)(BP + 0xF)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xF)], AL);
    // MOV word ptr [0xee],0x0 (1000_31DB / 0x131DB)
    UInt16[DS, 0xEE] = 0x0;
    // OR AL,AL (1000_31E1 / 0x131E1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // MOV AL,0xff (1000_31E3 / 0x131E3)
    AL = 0xFF;
    // JNZ 0x1000:31ea (1000_31E5 / 0x131E5)
    if(!ZeroFlag) {
      goto label_1000_31EA_131EA;
    }
    // MOV AL,byte ptr [SI + 0x15] (1000_31E7 / 0x131E7)
    AL = UInt8[DS, (ushort)(SI + 0x15)];
    label_1000_31EA_131EA:
    // MOV [0xed],AL (1000_31EA / 0x131EA)
    UInt8[DS, 0xED] = AL;
    label_1000_31ED_131ED:
    // MOV word ptr [DI],SI (1000_31ED / 0x131ED)
    UInt16[DS, DI] = SI;
    // MOV word ptr [BP + 0x0],DX (1000_31EF / 0x131EF)
    UInt16[SS, BP] = DX;
    // MOV word ptr [BP + 0x2],BX (1000_31F2 / 0x131F2)
    UInt16[SS, (ushort)(BP + 0x2)] = BX;
    // RET  (1000_31F5 / 0x131F5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_31F6_0131F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_31F6_131F6:
    // CALL 0x1000:e270 (1000_31F6 / 0x131F6)
    NearCall(cs1, 0x31F9, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_31F9_131F9:
    // MOV DI,word ptr [SI + 0x4] (1000_31F9 / 0x131F9)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV word ptr [0x2c],DI (1000_31FC / 0x131FC)
    UInt16[DS, 0x2C] = DI;
    // MOV AL,byte ptr [SI] (1000_3200 / 0x13200)
    AL = UInt8[DS, SI];
    // MOV [0x2e],AL (1000_3202 / 0x13202)
    UInt8[DS, 0x2E] = AL;
    // MOV AL,byte ptr [SI + 0x3] (1000_3205 / 0x13205)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // MOV [0x30],AL (1000_3208 / 0x13208)
    UInt8[DS, 0x30] = AL;
    // AND AX,0xf (1000_320B / 0x1320B)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV [0x2f],AL (1000_320E / 0x1320E)
    UInt8[DS, 0x2F] = AL;
    // ADD AX,0x18 (1000_3211 / 0x13211)
    // AX += 0x18;
    AX = Alu.Add16(AX, 0x18);
    // MOV [0x11f3],AX (1000_3214 / 0x13214)
    UInt16[DS, 0x11F3] = AX;
    // CALL 0x1000:32c7 (1000_3217 / 0x13217)
    NearCall(cs1, 0x321A, spice86_generated_label_call_target_1000_32C7_0132C7);
    label_1000_321A_1321A:
    // CALL 0x1000:329d (1000_321A / 0x1321A)
    NearCall(cs1, 0x321D, spice86_generated_label_call_target_1000_329D_01329D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_321D_01321D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_321D_01321D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_321D_1321D:
    // MOV [0x48],AX (1000_321D / 0x1321D)
    UInt16[DS, 0x48] = AX;
    // MOV AX,word ptr [SI + 0x10] (1000_3220 / 0x13220)
    AX = UInt16[DS, (ushort)(SI + 0x10)];
    // MOV [0x32],AX (1000_3223 / 0x13223)
    UInt16[DS, 0x32] = AX;
    // MOV AX,word ptr [SI + 0x12] (1000_3226 / 0x13226)
    AX = UInt16[DS, (ushort)(SI + 0x12)];
    // MOV [0x34],AX (1000_3229 / 0x13229)
    UInt16[DS, 0x34] = AX;
    // AND AX,0xf (1000_322C / 0x1322C)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV [0x31],AL (1000_322F / 0x1322F)
    UInt8[DS, 0x31] = AL;
    // ADD AX,0x0 (1000_3232 / 0x13232)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    // MOV [0x11ff],AX (1000_3235 / 0x13235)
    UInt16[DS, 0x11FF] = AX;
    // CALL 0x1000:6efd (1000_3238 / 0x13238)
    NearCall(cs1, 0x323B, spice86_generated_label_call_target_1000_6EFD_016EFD);
    label_1000_323B_1323B:
    // MOV [0x36],AL (1000_323B / 0x1323B)
    UInt8[DS, 0x36] = AL;
    // MOV AL,byte ptr [SI + 0x16] (1000_323E / 0x1323E)
    AL = UInt8[DS, (ushort)(SI + 0x16)];
    // MOV [0x38],AL (1000_3241 / 0x13241)
    UInt8[DS, 0x38] = AL;
    // CALL 0x1000:3310 (1000_3244 / 0x13244)
    NearCall(cs1, 0x3247, spice86_generated_label_call_target_1000_3310_013310);
    label_1000_3247_13247:
    // MOV [0x11f7],AX (1000_3247 / 0x13247)
    UInt16[DS, 0x11F7] = AX;
    // MOV AL,byte ptr [SI + 0x17] (1000_324A / 0x1324A)
    AL = UInt8[DS, (ushort)(SI + 0x17)];
    // MOV [0x39],AL (1000_324D / 0x1324D)
    UInt8[DS, 0x39] = AL;
    // CALL 0x1000:3310 (1000_3250 / 0x13250)
    NearCall(cs1, 0x3253, spice86_generated_label_call_target_1000_3310_013310);
    label_1000_3253_13253:
    // MOV [0x11f9],AX (1000_3253 / 0x13253)
    UInt16[DS, 0x11F9] = AX;
    // MOV AL,byte ptr [SI + 0x18] (1000_3256 / 0x13256)
    AL = UInt8[DS, (ushort)(SI + 0x18)];
    // MOV [0x3a],AL (1000_3259 / 0x13259)
    UInt8[DS, 0x3A] = AL;
    // CALL 0x1000:3310 (1000_325C / 0x1325C)
    NearCall(cs1, 0x325F, spice86_generated_label_call_target_1000_3310_013310);
    label_1000_325F_1325F:
    // MOV [0x11fb],AX (1000_325F / 0x1325F)
    UInt16[DS, 0x11FB] = AX;
    // MOV AX,word ptr [SI + 0xc] (1000_3262 / 0x13262)
    AX = UInt16[DS, (ushort)(SI + 0xC)];
    // MOV [0x44],AX (1000_3265 / 0x13265)
    UInt16[DS, 0x44] = AX;
    // MOV AX,word ptr [SI + 0xe] (1000_3268 / 0x13268)
    AX = UInt16[DS, (ushort)(SI + 0xE)];
    // MOV [0x46],AX (1000_326B / 0x1326B)
    UInt16[DS, 0x46] = AX;
    // XOR AH,AH (1000_326E / 0x1326E)
    AH = 0;
    // ADD AX,0xe8 (1000_3270 / 0x13270)
    // AX += 0xE8;
    AX = Alu.Add16(AX, 0xE8);
    // MOV [0x11f1],AX (1000_3273 / 0x13273)
    UInt16[DS, 0x11F1] = AX;
    // CALL 0x1000:693b (1000_3276 / 0x13276)
    NearCall(cs1, 0x3279, spice86_generated_label_call_target_1000_693B_01693B);
    label_1000_3279_13279:
    // MOV BP,AX (1000_3279 / 0x13279)
    BP = AX;
    // MOV AL,byte ptr [BP + SI + 0x16] (1000_327B / 0x1327B)
    AL = UInt8[SS, (ushort)(BP + SI + 0x16)];
    // MOV [0x37],AL (1000_327E / 0x1327E)
    UInt8[DS, 0x37] = AL;
    // MOV AL,byte ptr [SI + 0x19] (1000_3281 / 0x13281)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    // MOV [0x3b],AL (1000_3284 / 0x13284)
    UInt8[DS, 0x3B] = AL;
    // MOV AL,byte ptr [SI + 0x1a] (1000_3287 / 0x13287)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    // MOV [0x3c],AL (1000_328A / 0x1328A)
    UInt8[DS, 0x3C] = AL;
    // CALL 0x1000:1ac5 (1000_328D / 0x1328D)
    NearCall(cs1, 0x3290, spice86_generated_label_call_target_1000_1AC5_011AC5);
    label_1000_3290_13290:
    // SUB AL,byte ptr [SI + 0x14] (1000_3290 / 0x13290)
    // AL -= UInt8[DS, (ushort)(SI + 0x14)];
    AL = Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x14)]);
    // MOV [0x40],AL (1000_3293 / 0x13293)
    UInt8[DS, 0x40] = AL;
    // CALL 0x1000:331e (1000_3296 / 0x13296)
    NearCall(cs1, 0x3299, spice86_generated_label_call_target_1000_331E_01331E);
    label_1000_3299_13299:
    // CALL 0x1000:e283 (1000_3299 / 0x13299)
    NearCall(cs1, 0x329C, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_329C_1329C:
    // RET  (1000_329C / 0x1329C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_329D_01329D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_329D_1329D:
    // CMP byte ptr [SI + 0x3],0x0 (1000_329D / 0x1329D)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x0);
    // JZ 0x1000:32aa (1000_32A1 / 0x132A1)
    if(ZeroFlag) {
      goto label_1000_32AA_132AA;
    }
    // XOR AX,AX (1000_32A3 / 0x132A3)
    AX = 0;
    // AND word ptr [SI + 0x10],0xfff3 (1000_32A5 / 0x132A5)
    // UInt16[DS, (ushort)(SI + 0x10)] &= 0xFFF3;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0xFFF3);
    // RET  (1000_32A9 / 0x132A9)
    return NearRet();
    label_1000_32AA_132AA:
    // MOV AX,[0x42] (1000_32AA / 0x132AA)
    AX = UInt16[DS, 0x42];
    // OR AX,AX (1000_32AD / 0x132AD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:32c1 (1000_32AF / 0x132AF)
    if(ZeroFlag) {
      goto label_1000_32C1_132C1;
    }
    // MOV CX,AX (1000_32B1 / 0x132B1)
    CX = AX;
    // MOV AX,word ptr [SI + 0xe] (1000_32B3 / 0x132B3)
    AX = UInt16[DS, (ushort)(SI + 0xE)];
    // XOR DX,DX (1000_32B6 / 0x132B6)
    DX = 0;
    // DIV CX (1000_32B8 / 0x132B8)
    Cpu.Div16(CX);
    // SHL DX,1 (1000_32BA / 0x132BA)
    DX <<= 0x1;
    // CMP CX,DX (1000_32BC / 0x132BC)
    Alu.Sub16(CX, DX);
    // ADC AX,0x0 (1000_32BE / 0x132BE)
    AX = Alu.Adc16(AX, 0x0);
    label_1000_32C1_132C1:
    // MOV [0x4a],AX (1000_32C1 / 0x132C1)
    UInt16[DS, 0x4A] = AX;
    // JMP 0x1000:708a (1000_32C4 / 0x132C4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_708A_01708A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_32C7_0132C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_32C7_132C7:
    // MOV AX,[0x2] (1000_32C7 / 0x132C7)
    AX = UInt16[DS, 0x2];
    // SUB AX,word ptr [SI + 0xa] (1000_32CA / 0x132CA)
    // AX -= UInt16[DS, (ushort)(SI + 0xA)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0xA)]);
    // MOV [0x42],AX (1000_32CD / 0x132CD)
    UInt16[DS, 0x42] = AX;
    // MOV DX,AX (1000_32D0 / 0x132D0)
    DX = AX;
    // MOV CL,0x4 (1000_32D2 / 0x132D2)
    CL = 0x4;
    // SHR AX,CL (1000_32D4 / 0x132D4)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV [0x41],AL (1000_32D6 / 0x132D6)
    UInt8[DS, 0x41] = AL;
    // MOV AX,0x74 (1000_32D9 / 0x132D9)
    AX = 0x74;
    // TEST byte ptr [SI + 0x3],0x10 (1000_32DC / 0x132DC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x10);
    // JNZ 0x1000:330c (1000_32E0 / 0x132E0)
    if(!ZeroFlag) {
      goto label_1000_330C_1330C;
    }
    // MOV AX,0x70 (1000_32E2 / 0x132E2)
    AX = 0x70;
    // CMP DX,0x3 (1000_32E5 / 0x132E5)
    Alu.Sub16(DX, 0x3);
    // JC 0x1000:330c (1000_32E8 / 0x132E8)
    if(CarryFlag) {
      goto label_1000_330C_1330C;
    }
    // INC AX (1000_32EA / 0x132EA)
    AX++;
    // CMP DX,0x10 (1000_32EB / 0x132EB)
    Alu.Sub16(DX, 0x10);
    // JC 0x1000:330c (1000_32EE / 0x132EE)
    if(CarryFlag) {
      goto label_1000_330C_1330C;
    }
    // INC AX (1000_32F0 / 0x132F0)
    AX++;
    // CMP DX,0x20 (1000_32F1 / 0x132F1)
    Alu.Sub16(DX, 0x20);
    // JC 0x1000:330c (1000_32F4 / 0x132F4)
    if(CarryFlag) {
      goto label_1000_330C_1330C;
    }
    // INC AX (1000_32F6 / 0x132F6)
    AX = Alu.Inc16(AX);
    // PUSH AX (1000_32F7 / 0x132F7)
    Stack.Push(AX);
    // PUSH SI (1000_32F8 / 0x132F8)
    Stack.Push(SI);
    // MOV SI,AX (1000_32F9 / 0x132F9)
    SI = AX;
    // CALL 0x1000:cf70 (1000_32FB / 0x132FB)
    NearCall(cs1, 0x32FE, spice86_generated_label_call_target_1000_CF70_01CF70);
    // CALL 0x1000:d03c (1000_32FE / 0x132FE)
    NearCall(cs1, 0x3301, spice86_generated_label_call_target_1000_D03C_01D03C);
    // MOV AX,DX (1000_3301 / 0x13301)
    AX = DX;
    // MOV CL,0x4 (1000_3303 / 0x13303)
    CL = 0x4;
    // SHR AX,CL (1000_3305 / 0x13305)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // CALL 0x1000:e2e3 (1000_3307 / 0x13307)
    NearCall(cs1, 0x330A, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    // POP SI (1000_330A / 0x1330A)
    SI = Stack.Pop();
    // POP AX (1000_330B / 0x1330B)
    AX = Stack.Pop();
    label_1000_330C_1330C:
    // MOV [0x11f5],AX (1000_330C / 0x1330C)
    UInt16[DS, 0x11F5] = AX;
    // RET  (1000_330F / 0x1330F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3310_013310(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3310_13310:
    // XOR AH,AH (1000_3310 / 0x13310)
    AH = 0;
    // SHR AX,1 (1000_3312 / 0x13312)
    AX >>= 0x1;
    // SHR AX,1 (1000_3314 / 0x13314)
    AX >>= 0x1;
    // SHR AX,1 (1000_3316 / 0x13316)
    AX >>= 0x1;
    // SHR AX,1 (1000_3318 / 0x13318)
    AX >>= 0x1;
    // ADD AX,0xd1 (1000_331A / 0x1331A)
    // AX += 0xD1;
    AX = Alu.Add16(AX, 0xD1);
    // RET  (1000_331D / 0x1331D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_331E_01331E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_331E_1331E:
    // MOV word ptr [0x11ce],DI (1000_331E / 0x1331E)
    UInt16[DS, 0x11CE] = DI;
    // PUSH SI (1000_3322 / 0x13322)
    Stack.Push(SI);
    // PUSH DI (1000_3323 / 0x13323)
    Stack.Push(DI);
    // MOV AH,byte ptr [DI] (1000_3324 / 0x13324)
    AH = UInt8[DS, DI];
    // MOV AL,byte ptr [DI + 0x1] (1000_3326 / 0x13326)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    // MOV [0x4e],AX (1000_3329 / 0x13329)
    UInt16[DS, 0x4E] = AX;
    // MOV BX,0x1141 (1000_332C / 0x1332C)
    BX = 0x1141;
    // XLAT BX (1000_332F / 0x1332F)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // MOV [0x50],AL (1000_3330 / 0x13330)
    UInt8[DS, 0x50] = AL;
    // MOV AL,byte ptr [DI + 0xa] (1000_3333 / 0x13333)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    // MOV [0x51],AL (1000_3336 / 0x13336)
    UInt8[DS, 0x51] = AL;
    // MOV AL,byte ptr [DI + 0x12] (1000_3339 / 0x13339)
    AL = UInt8[DS, (ushort)(DI + 0x12)];
    // MOV [0x52],AL (1000_333C / 0x1333C)
    UInt8[DS, 0x52] = AL;
    // MOV AL,byte ptr [DI + 0x1b] (1000_333F / 0x1333F)
    AL = UInt8[DS, (ushort)(DI + 0x1B)];
    // MOV [0x54],AL (1000_3342 / 0x13342)
    UInt8[DS, 0x54] = AL;
    // MOV AL,byte ptr [DI + 0x8] (1000_3345 / 0x13345)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    // MOV [0x4d],AL (1000_3348 / 0x13348)
    UInt8[DS, 0x4D] = AL;
    // PUSH DS (1000_334B / 0x1334B)
    Stack.Push(DS);
    // POP ES (1000_334C / 0x1334C)
    ES = Stack.Pop();
    // PUSH DI (1000_334D / 0x1334D)
    Stack.Push(DI);
    // LEA SI,[DI + 0x14] (1000_334E / 0x1334E)
    SI = (ushort)(DI + 0x14);
    // MOV DI,0x55 (1000_3351 / 0x13351)
    DI = 0x55;
    // MOV CX,0x7 (1000_3354 / 0x13354)
    CX = 0x7;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_3357 / 0x13357)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // POP DI (1000_3359 / 0x13359)
    DI = Stack.Pop();
    // CALL 0x1000:33be (1000_335A / 0x1335A)
    NearCall(cs1, 0x335D, spice86_generated_label_call_target_1000_33BE_0133BE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_335D_01335D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_335D_01335D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_335D_1335D:
    // CALL 0x1000:34a5 (1000_335D / 0x1335D)
    NearCall(cs1, 0x3360, spice86_generated_label_call_target_1000_34A5_0134A5);
    label_1000_3360_13360:
    // CALL 0x1000:7f27 (1000_3360 / 0x13360)
    NearCall(cs1, 0x3363, spice86_generated_label_call_target_1000_7F27_017F27);
    label_1000_3363_13363:
    // MOV DI,0x46fe (1000_3363 / 0x13363)
    DI = 0x46FE;
    // MOV AL,0xff (1000_3366 / 0x13366)
    AL = 0xFF;
    // MOV CX,0x7 (1000_3368 / 0x13368)
    CX = 0x7;
    label_1000_336B_1336B:
    // CMP byte ptr [DI],0x1 (1000_336B / 0x1336B)
    Alu.Sub8(UInt8[DS, DI], 0x1);
    // RCL AL,1 (1000_336E / 0x1336E)
    AL = Alu.Rcl8(AL, 0x1);
    // INC DI (1000_3370 / 0x13370)
    DI = Alu.Inc16(DI);
    // LOOP 0x1000:336b (1000_3371 / 0x13371)
    if(--CX != 0) {
      goto label_1000_336B_1336B;
    }
    // NOT AL (1000_3373 / 0x13373)
    AL = (byte)~AL;
    // MOV CL,0x1 (1000_3375 / 0x13375)
    CL = 0x1;
    // SHL AL,CL (1000_3377 / 0x13377)
    // AL <<= CL;
    AL = Alu.Shl8(AL, CL);
    // MOV [0x53],AL (1000_3379 / 0x13379)
    UInt8[DS, 0x53] = AL;
    // POP DI (1000_337C / 0x1337C)
    DI = Stack.Pop();
    // CALL 0x1000:3385 (1000_337D / 0x1337D)
    NearCall(cs1, 0x3380, spice86_generated_label_call_target_1000_3385_013385);
    label_1000_3380_13380:
    // CALL 0x1000:5274 (1000_3380 / 0x13380)
    NearCall(cs1, 0x3383, spice86_generated_label_call_target_1000_5274_015274);
    label_1000_3383_13383:
    // POP SI (1000_3383 / 0x13383)
    SI = Stack.Pop();
    // RET  (1000_3384 / 0x13384)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3385_013385(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3385_13385:
    // MOV byte ptr [0xf7],0x0 (1000_3385 / 0x13385)
    UInt8[DS, 0xF7] = 0x0;
    // CMP DI,word ptr [0x1150] (1000_338A / 0x1338A)
    Alu.Sub16(DI, UInt16[DS, 0x1150]);
    // JZ 0x1000:33bd (1000_338E / 0x1338E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_33BD / 0x133BD)
      return NearRet();
    }
    // MOV AX,DI (1000_3390 / 0x13390)
    AX = DI;
    // SUB AX,0x100 (1000_3392 / 0x13392)
    // AX -= 0x100;
    AX = Alu.Sub16(AX, 0x100);
    // MOV BL,0x1c (1000_3395 / 0x13395)
    BL = 0x1C;
    // DIV BL (1000_3397 / 0x13397)
    Cpu.Div8(BL);
    // INC AX (1000_3399 / 0x13399)
    AX = Alu.Inc16(AX);
    // MOV BH,AL (1000_339A / 0x1339A)
    BH = AL;
    // MOV BL,0x80 (1000_339C / 0x1339C)
    BL = 0x80;
    // MOV SI,0x1018 (1000_339E / 0x1339E)
    SI = 0x1018;
    // CALL 0x1000:33ad (1000_33A1 / 0x133A1)
    NearCall(cs1, 0x33A4, not_observed_1000_33AD_0133AD);
    // MOV SI,0x1028 (1000_33A4 / 0x133A4)
    SI = 0x1028;
    // CALL 0x1000:33ad (1000_33A7 / 0x133A7)
    NearCall(cs1, 0x33AA, not_observed_1000_33AD_0133AD);
    // MOV SI,0x1048 (1000_33AA / 0x133AA)
    SI = 0x1048;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_33AD_0133AD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_33AD_0133AD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x33BD: goto label_1000_33BD_133BD;break; // Target of external jump from 0x1338E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_33AD_133AD:
    // CMP BX,word ptr [SI + 0x2] (1000_33AD / 0x133AD)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:33bd (1000_33B0 / 0x133B0)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_33BD / 0x133BD)
      return NearRet();
    }
    // MOV CL,byte ptr [SI + 0xe] (1000_33B2 / 0x133B2)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    // MOV AL,0x1 (1000_33B5 / 0x133B5)
    AL = 0x1;
    // SHL AL,CL (1000_33B7 / 0x133B7)
    // AL <<= CL;
    AL = Alu.Shl8(AL, CL);
    // OR byte ptr [0xf7],AL (1000_33B9 / 0x133B9)
    // UInt8[DS, 0xF7] |= AL;
    UInt8[DS, 0xF7] = Alu.Or8(UInt8[DS, 0xF7], AL);
    label_1000_33BD_133BD:
    // RET  (1000_33BD / 0x133BD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_33BE_0133BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_33BE_133BE:
    // XOR AX,AX (1000_33BE / 0x133BE)
    AX = 0;
    // MOV [0x94],AX (1000_33C0 / 0x133C0)
    UInt16[DS, 0x94] = AX;
    // MOV [0x96],AX (1000_33C3 / 0x133C3)
    UInt16[DS, 0x96] = AX;
    // MOV [0x5c],AX (1000_33C6 / 0x133C6)
    UInt16[DS, 0x5C] = AX;
    // MOV [0x5e],AX (1000_33C9 / 0x133C9)
    UInt16[DS, 0x5E] = AX;
    // MOV BP,0x3406 (1000_33CC / 0x133CC)
    BP = 0x3406;
    // CALL 0x1000:6603 (1000_33CF / 0x133CF)
    NearCall(cs1, 0x33D2, spice86_generated_label_call_target_1000_6603_016603);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_33D2_0133D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_33D2_0133D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_33D2_133D2:
    // CALL 0x1000:33d9 (1000_33D2 / 0x133D2)
    NearCall(cs1, 0x33D5, spice86_generated_label_call_target_1000_33D9_0133D9);
    label_1000_33D5_133D5:
    // MOV [0x9c],AL (1000_33D5 / 0x133D5)
    UInt8[DS, 0x9C] = AL;
    // RET  (1000_33D8 / 0x133D8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_33D9_0133D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_33D9_133D9:
    // MOV AX,[0x96] (1000_33D9 / 0x133D9)
    AX = UInt16[DS, 0x96];
    // MOV DX,word ptr [0x94] (1000_33DC / 0x133DC)
    DX = UInt16[DS, 0x94];
    // CMP AX,DX (1000_33E0 / 0x133E0)
    Alu.Sub16(AX, DX);
    // PUSHF  (1000_33E2 / 0x133E2)
    Stack.Push(FlagRegister);
    // JNC 0x1000:33e6 (1000_33E3 / 0x133E3)
    if(!CarryFlag) {
      goto label_1000_33E6_133E6;
    }
    // XCHG AX,DX (1000_33E5 / 0x133E5)
    ushort tmp_1000_33E5 = AX;
    AX = DX;
    DX = tmp_1000_33E5;
    label_1000_33E6_133E6:
    // MOV CX,DX (1000_33E6 / 0x133E6)
    CX = DX;
    // JCXZ 0x1000:33fd (1000_33E8 / 0x133E8)
    if(CX == 0) {
      goto label_1000_33FD_133FD;
    }
    // XOR DX,DX (1000_33EA / 0x133EA)
    DX = 0;
    // XCHG DL,AH (1000_33EC / 0x133EC)
    byte tmp_1000_33EC = DL;
    DL = AH;
    AH = tmp_1000_33EC;
    // XCHG AH,AL (1000_33EE / 0x133EE)
    byte tmp_1000_33EE = AH;
    AH = AL;
    AL = tmp_1000_33EE;
    // CMP DX,CX (1000_33F0 / 0x133F0)
    Alu.Sub16(DX, CX);
    // JNC 0x1000:33fd (1000_33F2 / 0x133F2)
    if(!CarryFlag) {
      goto label_1000_33FD_133FD;
    }
    // DIV CX (1000_33F4 / 0x133F4)
    Cpu.Div16(CX);
    // SHR AX,1 (1000_33F6 / 0x133F6)
    AX >>= 0x1;
    // CMP AX,0xfc (1000_33F8 / 0x133F8)
    Alu.Sub16(AX, 0xFC);
    // JC 0x1000:3400 (1000_33FB / 0x133FB)
    if(CarryFlag) {
      goto label_1000_3400_13400;
    }
    label_1000_33FD_133FD:
    // MOV AX,0xfc (1000_33FD / 0x133FD)
    AX = 0xFC;
    label_1000_3400_13400:
    // POPF  (1000_3400 / 0x13400)
    FlagRegister = Stack.Pop();
    // JNC 0x1000:3405 (1000_3401 / 0x13401)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_3405 / 0x13405)
      return NearRet();
    }
    // NEG AL (1000_3403 / 0x13403)
    AL = Alu.Sub8(0, AL);
    label_1000_3405_13405:
    // RET  (1000_3405 / 0x13405)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3406_013406(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3406_13406:
    // TEST byte ptr [SI + 0x3],0x20 (1000_3406 / 0x13406)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JNZ 0x1000:342c (1000_340A / 0x1340A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_342C / 0x1342C)
      return NearRet();
    }
    // CALL 0x1000:342d (1000_340C / 0x1340C)
    NearCall(cs1, 0x340F, spice86_generated_label_call_target_1000_342D_01342D);
    label_1000_340F_1340F:
    // TEST byte ptr [SI + 0x10],0x80 (1000_340F / 0x1340F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:3428 (1000_3413 / 0x13413)
    if(!ZeroFlag) {
      goto label_1000_3428_13428;
    }
    // ADD word ptr [0x96],AX (1000_3415 / 0x13415)
    // UInt16[DS, 0x96] += AX;
    UInt16[DS, 0x96] = Alu.Add16(UInt16[DS, 0x96], AX);
    // MOV AX,word ptr [SI + 0x10] (1000_3419 / 0x13419)
    AX = UInt16[DS, (ushort)(SI + 0x10)];
    // OR word ptr [0x5c],AX (1000_341C / 0x1341C)
    // UInt16[DS, 0x5C] |= AX;
    UInt16[DS, 0x5C] = Alu.Or16(UInt16[DS, 0x5C], AX);
    // MOV AX,word ptr [SI + 0x12] (1000_3420 / 0x13420)
    AX = UInt16[DS, (ushort)(SI + 0x12)];
    // OR word ptr [0x5e],AX (1000_3423 / 0x13423)
    // UInt16[DS, 0x5E] |= AX;
    UInt16[DS, 0x5E] = Alu.Or16(UInt16[DS, 0x5E], AX);
    // RET  (1000_3427 / 0x13427)
    return NearRet();
    label_1000_3428_13428:
    // ADD word ptr [0x94],AX (1000_3428 / 0x13428)
    // UInt16[DS, 0x94] += AX;
    UInt16[DS, 0x94] = Alu.Add16(UInt16[DS, 0x94], AX);
    label_1000_342C_1342C:
    // RET  (1000_342C / 0x1342C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_342D_01342D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_342D_1342D:
    // CALL 0x1000:6efd (1000_342D / 0x1342D)
    NearCall(cs1, 0x3430, spice86_generated_label_call_target_1000_6EFD_016EFD);
    label_1000_3430_13430:
    // XOR AH,AH (1000_3430 / 0x13430)
    AH = 0;
    // ADD AL,AL (1000_3432 / 0x13432)
    AL += AL;
    // ADD AL,byte ptr [SI + 0x17] (1000_3434 / 0x13434)
    // AL += UInt8[DS, (ushort)(SI + 0x17)];
    AL = Alu.Add8(AL, UInt8[DS, (ushort)(SI + 0x17)]);
    // JNC 0x1000:343b (1000_3437 / 0x13437)
    if(!CarryFlag) {
      goto label_1000_343B_1343B;
    }
    // MOV AL,0xff (1000_3439 / 0x13439)
    AL = 0xFF;
    label_1000_343B_1343B:
    // MUL byte ptr [SI + 0x1a] (1000_343B / 0x1343B)
    Cpu.Mul8(UInt8[DS, (ushort)(SI + 0x1A)]);
    // SHR AX,1 (1000_343E / 0x1343E)
    AX >>= 0x1;
    // SHR AX,1 (1000_3440 / 0x13440)
    AX >>= 0x1;
    // SHR AX,1 (1000_3442 / 0x13442)
    AX >>= 0x1;
    // SHR AX,1 (1000_3444 / 0x13444)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // MOV DX,AX (1000_3446 / 0x13446)
    DX = AX;
    // MOV BL,byte ptr [SI + 0x19] (1000_3448 / 0x13448)
    BL = UInt8[DS, (ushort)(SI + 0x19)];
    // SHL BL,1 (1000_344B / 0x1344B)
    BL <<= 0x1;
    // SHL BL,1 (1000_344D / 0x1344D)
    BL <<= 0x1;
    // SHL DX,1 (1000_344F / 0x1344F)
    DX <<= 0x1;
    // SHL BL,1 (1000_3451 / 0x13451)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    // JNC 0x1000:3459 (1000_3453 / 0x13453)
    if(!CarryFlag) {
      goto label_1000_3459_13459;
    }
    // ADD AX,DX (1000_3455 / 0x13455)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // JC 0x1000:3477 (1000_3457 / 0x13457)
    if(CarryFlag) {
      goto label_1000_3477_13477;
    }
    label_1000_3459_13459:
    // SHL DX,1 (1000_3459 / 0x13459)
    DX <<= 0x1;
    // SHL BL,1 (1000_345B / 0x1345B)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    // JNC 0x1000:3463 (1000_345D / 0x1345D)
    if(!CarryFlag) {
      goto label_1000_3463_13463;
    }
    // ADD AX,DX (1000_345F / 0x1345F)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // JC 0x1000:3477 (1000_3461 / 0x13461)
    if(CarryFlag) {
      goto label_1000_3477_13477;
    }
    label_1000_3463_13463:
    // SHL DX,1 (1000_3463 / 0x13463)
    DX <<= 0x1;
    // SHL BL,1 (1000_3465 / 0x13465)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    // JNC 0x1000:346d (1000_3467 / 0x13467)
    if(!CarryFlag) {
      goto label_1000_346D_1346D;
    }
    // ADD AX,DX (1000_3469 / 0x13469)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // JC 0x1000:3477 (1000_346B / 0x1346B)
    if(CarryFlag) {
      goto label_1000_3477_13477;
    }
    label_1000_346D_1346D:
    // SHL DX,1 (1000_346D / 0x1346D)
    DX <<= 0x1;
    // SHL BL,1 (1000_346F / 0x1346F)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    // JNC 0x1000:347a (1000_3471 / 0x13471)
    if(!CarryFlag) {
      goto label_1000_347A_1347A;
    }
    // ADD AX,DX (1000_3473 / 0x13473)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    // JNC 0x1000:347a (1000_3475 / 0x13475)
    if(!CarryFlag) {
      goto label_1000_347A_1347A;
    }
    label_1000_3477_13477:
    // MOV AX,0xffff (1000_3477 / 0x13477)
    AX = 0xFFFF;
    label_1000_347A_1347A:
    // MOV AL,AH (1000_347A / 0x1347A)
    AL = AH;
    // XOR AH,AH (1000_347C / 0x1347C)
    AH = 0;
    // OR AX,AX (1000_347E / 0x1347E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNZ 0x1000:3489 (1000_3480 / 0x13480)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_3489 / 0x13489)
      return NearRet();
    }
    // CMP byte ptr [SI + 0x1a],0x1 (1000_3482 / 0x13482)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x1);
    // CMC  (1000_3486 / 0x13486)
    CarryFlag = !CarryFlag;
    // ADC AL,AH (1000_3487 / 0x13487)
    AL = Alu.Adc8(AL, AH);
    label_1000_3489_13489:
    // RET  (1000_3489 / 0x13489)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_34A5_0134A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_34A5_134A5:
    // PUSH SI (1000_34A5 / 0x134A5)
    Stack.Push(SI);
    // PUSH DS (1000_34A6 / 0x134A6)
    Stack.Push(DS);
    // POP ES (1000_34A7 / 0x134A7)
    ES = Stack.Pop();
    // PUSH DI (1000_34A8 / 0x134A8)
    Stack.Push(DI);
    // MOV DI,0x60 (1000_34A9 / 0x134A9)
    DI = 0x60;
    // MOV CX,0x33 (1000_34AC / 0x134AC)
    CX = 0x33;
    // XOR AL,AL (1000_34AF / 0x134AF)
    AL = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_34B1 / 0x134B1)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // POP DI (1000_34B3 / 0x134B3)
    DI = Stack.Pop();
    // MOV BP,0x34d0 (1000_34B4 / 0x134B4)
    BP = 0x34D0;
    // CALL 0x1000:6639 (1000_34B7 / 0x134B7)
    NearCall(cs1, 0x34BA, spice86_generated_label_call_target_1000_6639_016639);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_34BA_0134BA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_34BA_0134BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_34BA_134BA:
    // MOV AL,[0x60] (1000_34BA / 0x134BA)
    AL = UInt8[DS, 0x60];
    // ADD AL,byte ptr [0x7e] (1000_34BD / 0x134BD)
    // AL += UInt8[DS, 0x7E];
    AL = Alu.Add8(AL, UInt8[DS, 0x7E]);
    // MOV [0x91],AL (1000_34C1 / 0x134C1)
    UInt8[DS, 0x91] = AL;
    // MOV AL,[0x61] (1000_34C4 / 0x134C4)
    AL = UInt8[DS, 0x61];
    // ADD AL,byte ptr [0x7f] (1000_34C7 / 0x134C7)
    // AL += UInt8[DS, 0x7F];
    AL = Alu.Add8(AL, UInt8[DS, 0x7F]);
    // MOV [0x92],AL (1000_34CB / 0x134CB)
    UInt8[DS, 0x92] = AL;
    // POP SI (1000_34CE / 0x134CE)
    SI = Stack.Pop();
    // RET  (1000_34CF / 0x134CF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_34D0_0134D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_34D0_134D0:
    // TEST byte ptr [SI + 0x3],0x20 (1000_34D0 / 0x134D0)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    // JNZ 0x1000:351a (1000_34D4 / 0x134D4)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_351A / 0x1351A)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0x3] (1000_34D6 / 0x134D6)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    // MOV DX,0x61 (1000_34D9 / 0x134D9)
    DX = 0x61;
    // TEST AL,0x40 (1000_34DC / 0x134DC)
    Alu.And8(AL, 0x40);
    // JZ 0x1000:34e3 (1000_34DE / 0x134DE)
    if(ZeroFlag) {
      goto label_1000_34E3_134E3;
    }
    // MOV DX,0x7f (1000_34E0 / 0x134E0)
    DX = 0x7F;
    label_1000_34E3_134E3:
    // MOV BX,DX (1000_34E3 / 0x134E3)
    BX = DX;
    // TEST byte ptr [SI + 0x10],0x80 (1000_34E5 / 0x134E5)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JNZ 0x1000:34f0 (1000_34E9 / 0x134E9)
    if(!ZeroFlag) {
      goto label_1000_34F0_134F0;
    }
    // DEC BX (1000_34EB / 0x134EB)
    BX--;
    // CMP AL,0x80 (1000_34EC / 0x134EC)
    Alu.Sub8(AL, 0x80);
    // JZ 0x1000:351b (1000_34EE / 0x134EE)
    if(ZeroFlag) {
      goto label_1000_351B_1351B;
    }
    label_1000_34F0_134F0:
    // INC byte ptr [BX] (1000_34F0 / 0x134F0)
    UInt8[DS, BX] = Alu.Inc8(UInt8[DS, BX]);
    // MOV AH,AL (1000_34F2 / 0x134F2)
    AH = AL;
    // AND AX,0x30f (1000_34F4 / 0x134F4)
    AX &= 0x30F;
    // CMP AH,0x3 (1000_34F7 / 0x134F7)
    Alu.Sub8(AH, 0x3);
    // JNZ 0x1000:34fe (1000_34FA / 0x134FA)
    if(!ZeroFlag) {
      goto label_1000_34FE_134FE;
    }
    // AND AL,0xfc (1000_34FC / 0x134FC)
    AL &= 0xFC;
    label_1000_34FE_134FE:
    // XOR AH,AH (1000_34FE / 0x134FE)
    AH = 0;
    // MOV BX,DX (1000_3500 / 0x13500)
    BX = DX;
    // ADD BX,AX (1000_3502 / 0x13502)
    BX += AX;
    // INC byte ptr [BX + 0x1] (1000_3504 / 0x13504)
    UInt8[DS, (ushort)(BX + 0x1)]++;
    // CMP BX,0x7f (1000_3507 / 0x13507)
    Alu.Sub16(BX, 0x7F);
    // JNC 0x1000:351a (1000_350B / 0x1350B)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_351A / 0x1351A)
      return NearRet();
    }
    // MOV AX,word ptr [SI + 0x12] (1000_350D / 0x1350D)
    AX = UInt16[DS, (ushort)(SI + 0x12)];
    // AND AX,0xf (1000_3510 / 0x13510)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // MOV BX,0x71 (1000_3513 / 0x13513)
    BX = 0x71;
    // ADD BX,AX (1000_3516 / 0x13516)
    BX += AX;
    // INC byte ptr [BX] (1000_3518 / 0x13518)
    UInt8[DS, BX] = Alu.Inc8(UInt8[DS, BX]);
    label_1000_351A_1351A:
    // RET  (1000_351A / 0x1351A)
    return NearRet();
    label_1000_351B_1351B:
    // INC byte ptr [0x90] (1000_351B / 0x1351B)
    UInt8[DS, 0x90] = Alu.Inc8(UInt8[DS, 0x90]);
    // RET  (1000_351F / 0x1351F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3520_013520(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3520_13520:
    // CMP byte ptr [0x47a7],0x0 (1000_3520 / 0x13520)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    // JNZ 0x1000:351a (1000_3525 / 0x13525)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_351A / 0x1351A)
      return NearRet();
    }
    // MOV AL,byte ptr [SI + 0xe] (1000_3527 / 0x13527)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // XOR AH,AH (1000_352A / 0x1352A)
    AH = 0;
    // PUSH SI (1000_352C / 0x1352C)
    Stack.Push(SI);
    // CALL 0x1000:96f1 (1000_352D / 0x1352D)
    NearCall(cs1, 0x3530, spice86_generated_label_call_target_1000_96F1_0196F1);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3530_013530, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3530_013530(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3530_13530:
    // POP SI (1000_3530 / 0x13530)
    SI = Stack.Pop();
    // JNC 0x1000:3542 (1000_3531 / 0x13531)
    if(!CarryFlag) {
      goto label_1000_3542_13542;
    }
    // MOV AX,[0x47c4] (1000_3533 / 0x13533)
    AX = UInt16[DS, 0x47C4];
    // MOV DI,word ptr [0x114e] (1000_3536 / 0x13536)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:2aaf (1000_353A / 0x1353A)
    NearCall(cs1, 0x353D, spice86_generated_label_call_target_1000_2AAF_012AAF);
    label_1000_353D_1353D:
    // JNC 0x1000:35ac (1000_353D / 0x1353D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    // CALL 0x1000:2b00 (1000_353F / 0x1353F)
    NearCall(cs1, 0x3542, not_observed_1000_2B00_012B00);
    label_1000_3542_13542:
    // MOV AX,[0x47c4] (1000_3542 / 0x13542)
    AX = UInt16[DS, 0x47C4];
    // MOV DI,word ptr [0x114e] (1000_3545 / 0x13545)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:2a51 (1000_3549 / 0x13549)
    NearCall(cs1, 0x354C, spice86_generated_label_call_target_1000_2A51_012A51);
    // MOV byte ptr [0xe7],0x0 (1000_354C / 0x1354C)
    UInt8[DS, 0xE7] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3551_013551, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3551_013551(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3551_13551:
    // INC byte ptr [0x47a7] (1000_3551 / 0x13551)
    UInt8[DS, 0x47A7]++;
    // CMP byte ptr [0x23],0x3 (1000_3555 / 0x13555)
    Alu.Sub8(UInt8[DS, 0x23], 0x3);
    // JNZ 0x1000:3572 (1000_355A / 0x1355A)
    if(!ZeroFlag) {
      goto label_1000_3572_13572;
    }
    // MOV BP,0x1f92 (1000_355C / 0x1355C)
    BP = 0x1F92;
    // MOV BX,0x97cf (1000_355F / 0x1355F)
    BX = 0x97CF;
    // CALL 0x1000:d323 (1000_3562 / 0x13562)
    NearCall(cs1, 0x3565, spice86_generated_label_call_target_1000_D323_01D323);
    label_1000_3565_13565:
    // MOV word ptr [0x1bea],0x0 (1000_3565 / 0x13565)
    UInt16[DS, 0x1BEA] = 0x0;
    // MOV word ptr [0x1bf8],0x0 (1000_356B / 0x1356B)
    UInt16[DS, 0x1BF8] = 0x0;
    // RET  (1000_3571 / 0x13571)
    return NearRet();
    label_1000_3572_13572:
    // CMP byte ptr [0x23],0x4 (1000_3572 / 0x13572)
    Alu.Sub8(UInt8[DS, 0x23], 0x4);
    // JNZ 0x1000:3595 (1000_3577 / 0x13577)
    if(!ZeroFlag) {
      goto label_1000_3595_13595;
    }
    // MOV BP,0x1f9e (1000_3579 / 0x13579)
    BP = 0x1F9E;
    // AND byte ptr [BP + 0xb],0xbf (1000_357C / 0x1357C)
    // UInt8[SS, (ushort)(BP + 0xB)] &= 0xBF;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.And8(UInt8[SS, (ushort)(BP + 0xB)], 0xBF);
    // MOV BX,0x97cf (1000_3580 / 0x13580)
    BX = 0x97CF;
    // CALL 0x1000:d323 (1000_3583 / 0x13583)
    NearCall(cs1, 0x3586, spice86_generated_label_call_target_1000_D323_01D323);
    // MOV word ptr [0x1bea],0x0 (1000_3586 / 0x13586)
    UInt16[DS, 0x1BEA] = 0x0;
    // MOV word ptr [0x1bf8],0x0 (1000_358C / 0x1358C)
    UInt16[DS, 0x1BF8] = 0x0;
    // JMP 0x1000:2ffb (1000_3592 / 0x13592)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2FFB_012FFB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_3595_13595:
    // CMP byte ptr [0x4774],0x0 (1000_3595 / 0x13595)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JNZ 0x1000:35ac (1000_359A / 0x1359A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    // CMP byte ptr [0x23],0x64 (1000_359C / 0x1359C)
    Alu.Sub8(UInt8[DS, 0x23], 0x64);
    // JNC 0x1000:35ac (1000_35A1 / 0x135A1)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    // MOV AX,[0x47c4] (1000_35A3 / 0x135A3)
    AX = UInt16[DS, 0x47C4];
    // CALL 0x1000:93df (1000_35A6 / 0x135A6)
    NearCall(cs1, 0x35A9, spice86_generated_label_call_target_1000_93DF_0193DF);
    // CALL 0x1000:d280 (1000_35A9 / 0x135A9)
    NearCall(cs1, 0x35AC, spice86_generated_label_call_target_1000_D280_01D280);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_35AC_0135AC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_35AC_0135AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_35AC_135AC:
    // RET  (1000_35AC / 0x135AC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_35AD_0135AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_35AD_135AD:
    // CMP byte ptr [0x11c9],0x0 (1000_35AD / 0x135AD)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:35e9 (1000_35B2 / 0x135B2)
    if(!ZeroFlag) {
      goto label_1000_35E9_135E9;
    }
    // XOR AX,AX (1000_35B4 / 0x135B4)
    AX = 0;
    // MOV [0x1a],AL (1000_35B6 / 0x135B6)
    UInt8[DS, 0x1A] = AL;
    // MOV [0x47a7],AL (1000_35B9 / 0x135B9)
    UInt8[DS, 0x47A7] = AL;
    // XCHG byte ptr [0x47a6],AL (1000_35BC / 0x135BC)
    byte tmp_1000_35BC = UInt8[DS, 0x47A6];
    UInt8[DS, 0x47A6] = AL;
    AL = tmp_1000_35BC;
    // OR AL,AL (1000_35C0 / 0x135C0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:35ac (1000_35C2 / 0x135C2)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    // INC byte ptr [0x1a] (1000_35C4 / 0x135C4)
    UInt8[DS, 0x1A]++;
    // CMP byte ptr [0xb],0x8 (1000_35C8 / 0x135C8)
    Alu.Sub8(UInt8[DS, 0xB], 0x8);
    // JNZ 0x1000:35e3 (1000_35CD / 0x135CD)
    if(!ZeroFlag) {
      goto label_1000_35E3_135E3;
    }
    // MOV AX,[0xc0] (1000_35CF / 0x135CF)
    AX = UInt16[DS, 0xC0];
    // AND AX,word ptr [0x1158] (1000_35D2 / 0x135D2)
    // AX &= UInt16[DS, 0x1158];
    AX = Alu.And16(AX, UInt16[DS, 0x1158]);
    // JZ 0x1000:35e3 (1000_35D6 / 0x135D6)
    if(ZeroFlag) {
      goto label_1000_35E3_135E3;
    }
    // TEST word ptr [0x12],0x8 (1000_35D8 / 0x135D8)
    Alu.And16(UInt16[DS, 0x12], 0x8);
    // JZ 0x1000:35e3 (1000_35DE / 0x135DE)
    if(ZeroFlag) {
      goto label_1000_35E3_135E3;
    }
    // CALL 0x1000:2566 (1000_35E0 / 0x135E0)
    NearCall(cs1, 0x35E3, not_observed_1000_2566_012566);
    label_1000_35E3_135E3:
    // MOV BP,0x3520 (1000_35E3 / 0x135E3)
    BP = 0x3520;
    // JMP 0x1000:36ee (1000_35E6 / 0x135E6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_36EE_0136EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_35E9_135E9:
    // XOR AX,AX (1000_35E9 / 0x135E9)
    AX = 0;
    // MOV [0x1a],AL (1000_35EB / 0x135EB)
    UInt8[DS, 0x1A] = AL;
    // MOV [0x47a7],AL (1000_35EE / 0x135EE)
    UInt8[DS, 0x47A7] = AL;
    // MOV [0x23],AL (1000_35F1 / 0x135F1)
    UInt8[DS, 0x23] = AL;
    // XCHG byte ptr [0x47a6],AL (1000_35F4 / 0x135F4)
    byte tmp_1000_35F4 = UInt8[DS, 0x47A6];
    UInt8[DS, 0x47A6] = AL;
    AL = tmp_1000_35F4;
    // OR AL,AL (1000_35F8 / 0x135F8)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:35ac (1000_35FA / 0x135FA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    // CMP word ptr [0x1152],-0x1 (1000_35FC / 0x135FC)
    Alu.Sub16(UInt16[DS, 0x1152], 0xFFFF);
    // JZ 0x1000:3637 (1000_3601 / 0x13601)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3637_013637, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:40f9 (1000_3603 / 0x13603)
    NearCall(cs1, 0x3606, spice86_generated_label_call_target_1000_40F9_0140F9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3606_013606, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3606_013606(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3636: goto label_1000_3636_13636;break; // Target of external jump from 0x1363F, 0x1360E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_3606_13606:
    // CALL 0x1000:4182 (1000_3606 / 0x13606)
    NearCall(cs1, 0x3609, spice86_generated_label_call_target_1000_4182_014182);
    label_1000_3609_13609:
    // CMP byte ptr [0x23],0x0 (1000_3609 / 0x13609)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    // JZ 0x1000:3636 (1000_360E / 0x1360E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    // CALL 0x1000:366f (1000_3610 / 0x13610)
    NearCall(cs1, 0x3613, spice86_generated_label_call_target_1000_366F_01366F);
    label_1000_3613_13613:
    // JS 0x1000:3636 (1000_3613 / 0x13613)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    // CALL 0x1000:dbb2 (1000_3615 / 0x13615)
    NearCall(cs1, 0x3618, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_3618_13618:
    // CALL 0x1000:368b (1000_3618 / 0x13618)
    NearCall(cs1, 0x361B, spice86_generated_label_call_target_1000_368B_01368B);
    label_1000_361B_1361B:
    // PUSH AX (1000_361B / 0x1361B)
    Stack.Push(AX);
    // MOV AX,0x4b (1000_361C / 0x1361C)
    AX = 0x4B;
    // CALL 0x1000:e387 (1000_361F / 0x1361F)
    NearCall(cs1, 0x3622, spice86_generated_label_call_target_1000_E387_01E387);
    label_1000_3622_13622:
    // POP AX (1000_3622 / 0x13622)
    AX = Stack.Pop();
    // PUSH AX (1000_3623 / 0x13623)
    Stack.Push(AX);
    // CALL 0x1000:96d8 (1000_3624 / 0x13624)
    NearCall(cs1, 0x3627, spice86_generated_label_call_target_1000_96D8_0196D8);
    label_1000_3627_13627:
    // POP AX (1000_3627 / 0x13627)
    AX = Stack.Pop();
    // JC 0x1000:3636 (1000_3628 / 0x13628)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    // MOV CL,0x10 (1000_362A / 0x1362A)
    CL = 0x10;
    // MUL CL (1000_362C / 0x1362C)
    Cpu.Mul8(CL);
    // ADD AX,0xfd8 (1000_362E / 0x1362E)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    // MOV SI,AX (1000_3631 / 0x13631)
    SI = AX;
    // CALL 0x1000:3551 (1000_3633 / 0x13633)
    NearCall(cs1, 0x3636, spice86_generated_label_call_target_1000_3551_013551);
    label_1000_3636_13636:
    // RET  (1000_3636 / 0x13636)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3637_013637(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3637_13637:
    // CALL 0x1000:4182 (1000_3637 / 0x13637)
    NearCall(cs1, 0x363A, spice86_generated_label_call_target_1000_4182_014182);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_363A_01363A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_363A_01363A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_363A_1363A:
    // CMP byte ptr [0x23],0x0 (1000_363A / 0x1363A)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    // JZ 0x1000:3636 (1000_363F / 0x1363F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    // CALL 0x1000:dbb2 (1000_3641 / 0x13641)
    NearCall(cs1, 0x3644, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:439f (1000_3644 / 0x13644)
    NearCall(cs1, 0x3647, spice86_generated_label_call_target_1000_439F_01439F);
    // MOV CX,0x200c (1000_3647 / 0x13647)
    CX = 0x200C;
    // MOV DX,0x66 (1000_364A / 0x1364A)
    DX = 0x66;
    // MOV BX,0x4e (1000_364D / 0x1364D)
    BX = 0x4E;
    // MOV AX,0xbf (1000_3650 / 0x13650)
    AX = 0xBF;
    // CALL 0x1000:d194 (1000_3653 / 0x13653)
    NearCall(cs1, 0x3656, spice86_generated_label_call_target_1000_D194_01D194);
    // CALL 0x1000:c0f4 (1000_3656 / 0x13656)
    NearCall(cs1, 0x3659, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // CALL 0x1000:c4dd (1000_3659 / 0x13659)
    NearCall(cs1, 0x365C, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    // CALL 0x1000:4aca (1000_365C / 0x1365C)
    NearCall(cs1, 0x365F, spice86_generated_label_call_target_1000_4ACA_014ACA);
    // MOV BP,0x1f9e (1000_365F / 0x1365F)
    BP = 0x1F9E;
    // OR byte ptr [BP + 0xb],0x40 (1000_3662 / 0x13662)
    // UInt8[SS, (ushort)(BP + 0xB)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xB)], 0x40);
    // MOV BX,0x4abe (1000_3666 / 0x13666)
    BX = 0x4ABE;
    // CALL 0x1000:d323 (1000_3669 / 0x13669)
    NearCall(cs1, 0x366C, spice86_generated_label_call_target_1000_D323_01D323);
    // JMP 0x1000:2ffb (1000_366C / 0x1366C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2FFB_012FFB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_366F_01366F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_366F_1366F:
    // MOV AX,[0x1152] (1000_366F / 0x1366F)
    AX = UInt16[DS, 0x1152];
    // CMP AX,0xffff (1000_3672 / 0x13672)
    Alu.Sub16(AX, 0xFFFF);
    // JZ 0x1000:3688 (1000_3675 / 0x13675)
    if(ZeroFlag) {
      goto label_1000_3688_13688;
    }
    // CMP AH,0xff (1000_3677 / 0x13677)
    Alu.Sub8(AH, 0xFF);
    // JZ 0x1000:3686 (1000_367A / 0x1367A)
    if(ZeroFlag) {
      goto label_1000_3686_13686;
    }
    // TEST word ptr [0x0],0x80 (1000_367C / 0x1367C)
    Alu.And16(UInt16[DS, 0x0], 0x80);
    // JNZ 0x1000:3686 (1000_3682 / 0x13682)
    if(!ZeroFlag) {
      goto label_1000_3686_13686;
    }
    // XCHG AH,AL (1000_3684 / 0x13684)
    byte tmp_1000_3684 = AH;
    AH = AL;
    AL = tmp_1000_3684;
    label_1000_3686_13686:
    // XOR AH,AH (1000_3686 / 0x13686)
    AH = 0;
    label_1000_3688_13688:
    // OR AX,AX (1000_3688 / 0x13688)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // RET  (1000_368A / 0x1368A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_368B_01368B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_368B_1368B:
    // CALL 0x1000:e270 (1000_368B / 0x1368B)
    NearCall(cs1, 0x368E, spice86_generated_label_call_target_1000_E270_01E270);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_368E_01368E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_368E_01368E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_368E_1368E:
    // OR byte ptr [0x4728],0x1 (1000_368E / 0x1368E)
    // UInt8[DS, 0x4728] |= 0x1;
    UInt8[DS, 0x4728] = Alu.Or8(UInt8[DS, 0x4728], 0x1);
    // MOV BL,byte ptr [0x11c9] (1000_3693 / 0x13693)
    BL = UInt8[DS, 0x11C9];
    // AND BL,0x3 (1000_3697 / 0x13697)
    BL &= 0x3;
    // CMP BL,0x2 (1000_369A / 0x1369A)
    Alu.Sub8(BL, 0x2);
    // JZ 0x1000:36cb (1000_369D / 0x1369D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_36CB_0136CB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // DEC BL (1000_369F / 0x1369F)
    BL = Alu.Dec8(BL);
    // JNZ 0x1000:36c7 (1000_36A1 / 0x136A1)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_36B6_0136B6, 0x136C7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [0x473e],0x1 (1000_36A3 / 0x136A3)
    UInt8[DS, 0x473E] = 0x1;
    // MOV byte ptr [0x47a4],0x1 (1000_36A8 / 0x136A8)
    UInt8[DS, 0x47A4] = 0x1;
    // PUSH AX (1000_36AD / 0x136AD)
    Stack.Push(AX);
    // MOV AL,0x34 (1000_36AE / 0x136AE)
    AL = 0x34;
    // CALL 0x1000:c2f2 (1000_36B0 / 0x136B0)
    NearCall(cs1, 0x36B3, spice86_generated_label_call_target_1000_C2F2_01C2F2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_36B3_0136B3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_36B3_0136B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36B3_136B3:
    // CALL 0x1000:c0f4 (1000_36B3 / 0x136B3)
    NearCall(cs1, 0x36B6, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_36B6_0136B6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_36B6_0136B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36B6_136B6:
    // CALL 0x1000:c412 (1000_36B6 / 0x136B6)
    NearCall(cs1, 0x36B9, spice86_generated_label_call_target_1000_C412_01C412);
    label_1000_36B9_136B9:
    // POP AX (1000_36B9 / 0x136B9)
    AX = Stack.Pop();
    // OR AX,AX (1000_36BA / 0x136BA)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:36c4 (1000_36BC / 0x136BC)
    if(SignFlag) {
      goto label_1000_36C4_136C4;
    }
    // MOV [0x47c4],AX (1000_36BE / 0x136BE)
    UInt16[DS, 0x47C4] = AX;
    // CALL 0x1000:978e (1000_36C1 / 0x136C1)
    NearCall(cs1, 0x36C4, spice86_generated_label_call_target_1000_978E_01978E);
    label_1000_36C4_136C4:
    // CALL 0x1000:c4dd (1000_36C4 / 0x136C4)
    NearCall(cs1, 0x36C7, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_36C7_136C7:
    // CALL 0x1000:e283 (1000_36C7 / 0x136C7)
    NearCall(cs1, 0x36CA, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_36CA_136CA:
    // RET  (1000_36CA / 0x136CA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_36CB_0136CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36CB_136CB:
    // CALL 0x1000:4aeb (1000_36CB / 0x136CB)
    NearCall(cs1, 0x36CE, not_observed_1000_4AEB_014AEB);
    // CALL 0x1000:c474 (1000_36CE / 0x136CE)
    NearCall(cs1, 0x36D1, spice86_generated_label_call_target_1000_C474_01C474);
    // JMP 0x1000:36c7 (1000_36D1 / 0x136D1)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_36B6_0136B6, 0x136C7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_36D3_0136D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36D3_136D3:
    // CMP byte ptr [0x23],0x0 (1000_36D3 / 0x136D3)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    // JZ 0x1000:36ed (1000_36D8 / 0x136D8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_36ED / 0x136ED)
      return NearRet();
    }
    // CALL 0x1000:98b2 (1000_36DA / 0x136DA)
    NearCall(cs1, 0x36DD, spice86_generated_label_call_target_1000_98B2_0198B2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_36DD_0136DD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_36DD_0136DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36DD_136DD:
    // MOV byte ptr [0x47a7],0x0 (1000_36DD / 0x136DD)
    UInt8[DS, 0x47A7] = 0x0;
    // MOV BP,0x3520 (1000_36E2 / 0x136E2)
    BP = 0x3520;
    // CALL 0x1000:36ee (1000_36E5 / 0x136E5)
    NearCall(cs1, 0x36E8, spice86_generated_label_call_target_1000_36EE_0136EE);
    label_1000_36E8_136E8:
    // MOV byte ptr [0x23],0x0 (1000_36E8 / 0x136E8)
    UInt8[DS, 0x23] = 0x0;
    label_1000_36ED_136ED:
    // RET  (1000_36ED / 0x136ED)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_36EE_0136EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36EE_136EE:
    // PUSH BX (1000_36EE / 0x136EE)
    Stack.Push(BX);
    // PUSH DX (1000_36EF / 0x136EF)
    Stack.Push(DX);
    // MOV SI,0xfd8 (1000_36F0 / 0x136F0)
    SI = 0xFD8;
    // MOV CX,0x10 (1000_36F3 / 0x136F3)
    CX = 0x10;
    // MOV BX,word ptr [0x6] (1000_36F6 / 0x136F6)
    BX = UInt16[DS, 0x6];
    // MOV DX,word ptr [0x4] (1000_36FA / 0x136FA)
    DX = UInt16[DS, 0x4];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_36FE_0136FE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
