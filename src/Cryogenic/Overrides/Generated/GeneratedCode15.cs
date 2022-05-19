namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_ret_target_1000_C6A9_01C6A9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C6A9_1C6A9:
    // ADD SP,0x8 (1000_C6A9 / 0x1C6A9)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    label_1000_C6AC_1C6AC:
    // RET  (1000_C6AC / 0x1C6AC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C6AD_01C6AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C6AD_1C6AD:
    // CALL 0x1000:c13b (1000_C6AD / 0x1C6AD)
    NearCall(cs1, 0xC6B0, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C6B0_01C6B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C6B0_01C6B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C6B0_1C6B0:
    // CMP byte ptr [0xdc46],0x0 (1000_C6B0 / 0x1C6B0)
    Alu.Sub8(UInt8[DS, 0xDC46], 0x0);
    // JS 0x1000:c6e4 (1000_C6B5 / 0x1C6B5)
    if(SignFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // MOV AX,[0xdc44] (1000_C6B7 / 0x1C6B7)
    AX = UInt16[DS, 0xDC44];
    // CMP AX,word ptr [SI + 0x6] (1000_C6BA / 0x1C6BA)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x6)]);
    // JGE 0x1000:c6e4 (1000_C6BD / 0x1C6BD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // ADD AX,0x10 (1000_C6BF / 0x1C6BF)
    AX += 0x10;
    // CMP AX,word ptr [SI + 0x2] (1000_C6C2 / 0x1C6C2)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JLE 0x1000:c6e4 (1000_C6C5 / 0x1C6C5)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // MOV AX,[0xdc42] (1000_C6C7 / 0x1C6C7)
    AX = UInt16[DS, 0xDC42];
    // CMP AX,word ptr [SI + 0x4] (1000_C6CA / 0x1C6CA)
    Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0x4)]);
    // JGE 0x1000:c6e4 (1000_C6CD / 0x1C6CD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // ADD AX,0x10 (1000_C6CF / 0x1C6CF)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    // MOV BX,word ptr [SI] (1000_C6D2 / 0x1C6D2)
    BX = UInt16[DS, SI];
    // AND BH,0xf (1000_C6D4 / 0x1C6D4)
    BH &= 0xF;
    // CMP AX,BX (1000_C6D7 / 0x1C6D7)
    Alu.Sub16(AX, BX);
    // JLE 0x1000:c6e4 (1000_C6D9 / 0x1C6D9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C6E4_1C6E4;
    }
    // MOV AX,0xdbec (1000_C6DB / 0x1C6DB)
    AX = 0xDBEC;
    // PUSH AX (1000_C6DE / 0x1C6DE)
    Stack.Push(AX);
    // PUSH SI (1000_C6DF / 0x1C6DF)
    Stack.Push(SI);
    // CALL 0x1000:dbb2 (1000_C6E0 / 0x1C6E0)
    NearCall(cs1, 0xC6E3, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_C6E3_1C6E3:
    // POP SI (1000_C6E3 / 0x1C6E3)
    SI = Stack.Pop();
    label_1000_C6E4_1C6E4:
    // MOV AX,DS (1000_C6E4 / 0x1C6E4)
    AX = DS;
    // MOV ES,AX (1000_C6E6 / 0x1C6E6)
    ES = AX;
    // MOV DI,0xd834 (1000_C6E8 / 0x1C6E8)
    DI = 0xD834;
    // MOV BX,0x8 (1000_C6EB / 0x1C6EB)
    BX = 0x8;
    // LODSW SI (1000_C6EE / 0x1C6EE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C6EF / 0x1C6EF)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JGE 0x1000:c6f5 (1000_C6F1 / 0x1C6F1)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6F5_1C6F5;
    }
    // MOV AX,word ptr [BX + DI] (1000_C6F3 / 0x1C6F3)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C6F5_1C6F5:
    // STOSW ES:DI (1000_C6F5 / 0x1C6F5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_C6F6 / 0x1C6F6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C6F7 / 0x1C6F7)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JGE 0x1000:c6fd (1000_C6F9 / 0x1C6F9)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C6FD_1C6FD;
    }
    // MOV AX,word ptr [BX + DI] (1000_C6FB / 0x1C6FB)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C6FD_1C6FD:
    // STOSW ES:DI (1000_C6FD / 0x1C6FD)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_C6FE / 0x1C6FE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C6FF / 0x1C6FF)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JLE 0x1000:c705 (1000_C701 / 0x1C701)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C705_1C705;
    }
    // MOV AX,word ptr [BX + DI] (1000_C703 / 0x1C703)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C705_1C705:
    // CMP AX,word ptr [DI + -0x4] (1000_C705 / 0x1C705)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI - 0x4)]);
    // JLE 0x1000:c6ac (1000_C708 / 0x1C708)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_C6AC / 0x1C6AC)
      return NearRet();
    }
    // STOSW ES:DI (1000_C70A / 0x1C70A)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LODSW SI (1000_C70B / 0x1C70B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [BX + DI] (1000_C70C / 0x1C70C)
    Alu.Sub16(AX, UInt16[DS, (ushort)(BX + DI)]);
    // JLE 0x1000:c712 (1000_C70E / 0x1C70E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C712_1C712;
    }
    // MOV AX,word ptr [BX + DI] (1000_C710 / 0x1C710)
    AX = UInt16[DS, (ushort)(BX + DI)];
    label_1000_C712_1C712:
    // CMP AX,word ptr [DI + -0x4] (1000_C712 / 0x1C712)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI - 0x4)]);
    // JLE 0x1000:c6ac (1000_C715 / 0x1C715)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_C6AC / 0x1C6AC)
      return NearRet();
    }
    // STOSW ES:DI (1000_C717 / 0x1C717)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CALL 0x1000:c443 (1000_C718 / 0x1C718)
    NearCall(cs1, 0xC71B, spice86_generated_label_call_target_1000_C443_01C443);
    label_1000_C71B_1C71B:
    // SUB SP,0x200 (1000_C71B / 0x1C71B)
    // SP -= 0x200;
    SP = Alu.Sub16(SP, 0x200);
    // MOV DI,SP (1000_C71F / 0x1C71F)
    DI = SP;
    // MOV CX,word ptr [0x3cbe] (1000_C721 / 0x1C721)
    CX = UInt16[DS, 0x3CBE];
    // JCXZ 0x1000:c780 (1000_C725 / 0x1C725)
    if(CX == 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C763_01C763, 0x1C780 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0xd834 (1000_C727 / 0x1C727)
    SI = 0xD834;
    // LODSW SI (1000_C72A / 0x1C72A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_C72B / 0x1C72B)
    DX = AX;
    // LODSW SI (1000_C72D / 0x1C72D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_C72E / 0x1C72E)
    BX = AX;
    // LODSW SI (1000_C730 / 0x1C730)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BP,AX (1000_C731 / 0x1C731)
    BP = AX;
    // MOV AX,word ptr [SI] (1000_C733 / 0x1C733)
    AX = UInt16[DS, SI];
    // MOV SI,0x3cc0 (1000_C735 / 0x1C735)
    SI = 0x3CC0;
    label_1000_C738_1C738:
    // CMP byte ptr [SI + 0xc],0x0 (1000_C738 / 0x1C738)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0xC)], 0x0);
    // JS 0x1000:c756 (1000_C73C / 0x1C73C)
    if(SignFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI],BP (1000_C73E / 0x1C73E)
    Alu.Sub16(UInt16[DS, SI], BP);
    // JGE 0x1000:c756 (1000_C740 / 0x1C740)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI + 0x2],AX (1000_C742 / 0x1C742)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], AX);
    // JGE 0x1000:c756 (1000_C745 / 0x1C745)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI + 0x4],DX (1000_C747 / 0x1C747)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], DX);
    // JLE 0x1000:c756 (1000_C74A / 0x1C74A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // CMP word ptr [SI + 0x6],BX (1000_C74C / 0x1C74C)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x6)], BX);
    // JLE 0x1000:c756 (1000_C74F / 0x1C74F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_C756_1C756;
    }
    // MOV word ptr [DI],SI (1000_C751 / 0x1C751)
    UInt16[DS, DI] = SI;
    // ADD DI,0x2 (1000_C753 / 0x1C753)
    DI += 0x2;
    label_1000_C756_1C756:
    // ADD SI,0x11 (1000_C756 / 0x1C756)
    // SI += 0x11;
    SI = Alu.Add16(SI, 0x11);
    // LOOP 0x1000:c738 (1000_C759 / 0x1C759)
    if(--CX != 0) {
      goto label_1000_C738_1C738;
    }
    // MOV CX,DI (1000_C75B / 0x1C75B)
    CX = DI;
    // SUB CX,SP (1000_C75D / 0x1C75D)
    CX -= SP;
    // SHR CX,1 (1000_C75F / 0x1C75F)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // JZ 0x1000:c780 (1000_C761 / 0x1C761)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C763_01C763, 0x1C780 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_C763_01C763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_C763_01C763(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC780: goto label_1000_C780_1C780;break; // Target of external jump from 0x1C761, 0x1C725
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C763_1C763:
    // MOV SI,SP (1000_C763 / 0x1C763)
    SI = SP;
    // PUSH CX (1000_C765 / 0x1C765)
    Stack.Push(CX);
    // CALL word ptr [0x2786] (1000_C766 / 0x1C766)
    // Indirect call to word ptr [0x2786], generating possible targets from emulator records
    uint targetAddress_1000_C766 = (uint)(UInt16[DS, 0x2786]);
    switch(targetAddress_1000_C766) {
      case 0xC835 : NearCall(cs1, 0xC76A, spice86_generated_label_call_target_1000_C835_01C835); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C766));
        break;
    }
    label_1000_C76A_1C76A:
    // JS 0x1000:c77f (1000_C76A / 0x1C76A)
    if(SignFlag) {
      goto label_1000_C77F_1C77F;
    }
    // XOR SI,SI (1000_C76C / 0x1C76C)
    SI = 0;
    // XCHG word ptr [BX + -0x2],SI (1000_C76E / 0x1C76E)
    ushort tmp_1000_C76E = UInt16[DS, (ushort)(BX - 0x2)];
    UInt16[DS, (ushort)(BX - 0x2)] = SI;
    SI = tmp_1000_C76E;
    // MOV AX,word ptr [SI + 0x8] (1000_C771 / 0x1C771)
    AX = UInt16[DS, (ushort)(SI + 0x8)];
    // MOV DX,word ptr [SI] (1000_C774 / 0x1C774)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C776 / 0x1C776)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL 0x1000:c30d (1000_C779 / 0x1C779)
    NearCall(cs1, 0xC77C, spice86_generated_label_call_target_1000_C30D_01C30D);
    label_1000_C77C_1C77C:
    // POP CX (1000_C77C / 0x1C77C)
    CX = Stack.Pop();
    // JMP 0x1000:c763 (1000_C77D / 0x1C77D)
    goto label_1000_C763_1C763;
    label_1000_C77F_1C77F:
    // POP CX (1000_C77F / 0x1C77F)
    CX = Stack.Pop();
    label_1000_C780_1C780:
    // CMP byte ptr [0x227d],0x0 (1000_C780 / 0x1C780)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:c7a2 (1000_C785 / 0x1C785)
    if(!ZeroFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CMP word ptr [0xd83a],0x89 (1000_C787 / 0x1C787)
    Alu.Sub16(UInt16[DS, 0xD83A], 0x89);
    // JL 0x1000:c7a2 (1000_C78D / 0x1C78D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CMP word ptr [0xd838],0x7e (1000_C78F / 0x1C78F)
    Alu.Sub16(UInt16[DS, 0xD838], 0x7E);
    // JL 0x1000:c7a2 (1000_C795 / 0x1C795)
    if(SignFlag != OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CMP word ptr [0xd834],0xc2 (1000_C797 / 0x1C797)
    Alu.Sub16(UInt16[DS, 0xD834], 0xC2);
    // JGE 0x1000:c7a2 (1000_C79D / 0x1C79D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_C7A2_1C7A2;
    }
    // CALL 0x1000:1797 (1000_C79F / 0x1C79F)
    NearCall(cs1, 0xC7A2, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_C7A2_1C7A2:
    // MOV SI,word ptr [0xdbe0] (1000_C7A2 / 0x1C7A2)
    SI = UInt16[DS, 0xDBE0];
    // OR SI,SI (1000_C7A6 / 0x1C7A6)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:c7be (1000_C7A8 / 0x1C7A8)
    if(ZeroFlag) {
      goto label_1000_C7BE_1C7BE;
    }
    // MOV DI,0xd834 (1000_C7AA / 0x1C7AA)
    DI = 0xD834;
    // CALL 0x1000:c7d4 (1000_C7AD / 0x1C7AD)
    NearCall(cs1, 0xC7B0, spice86_generated_label_call_target_1000_C7D4_01C7D4);
    label_1000_C7B0_1C7B0:
    // MOV SI,word ptr [0xdbe2] (1000_C7B0 / 0x1C7B0)
    SI = UInt16[DS, 0xDBE2];
    // OR SI,SI (1000_C7B4 / 0x1C7B4)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:c7be (1000_C7B6 / 0x1C7B6)
    if(ZeroFlag) {
      goto label_1000_C7BE_1C7BE;
    }
    // MOV DI,0xd834 (1000_C7B8 / 0x1C7B8)
    DI = 0xD834;
    // CALL 0x1000:c7d4 (1000_C7BB / 0x1C7BB)
    NearCall(cs1, 0xC7BE, spice86_generated_label_call_target_1000_C7D4_01C7D4);
    label_1000_C7BE_1C7BE:
    // MOV SI,0xd834 (1000_C7BE / 0x1C7BE)
    SI = 0xD834;
    // MOV DX,word ptr [SI] (1000_C7C1 / 0x1C7C1)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_C7C3 / 0x1C7C3)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BP,word ptr [SI + 0x4] (1000_C7C6 / 0x1C7C6)
    BP = UInt16[DS, (ushort)(SI + 0x4)];
    // MOV AX,word ptr [SI + 0x6] (1000_C7C9 / 0x1C7C9)
    AX = UInt16[DS, (ushort)(SI + 0x6)];
    // CALL 0x1000:c51e (1000_C7CC / 0x1C7CC)
    NearCall(cs1, 0xC7CF, spice86_generated_label_call_target_1000_C51E_01C51E);
    label_1000_C7CF_1C7CF:
    // ADD SP,0x200 (1000_C7CF / 0x1C7CF)
    // SP += 0x200;
    SP = Alu.Add16(SP, 0x200);
    // RET  (1000_C7D3 / 0x1C7D3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C7D4_01C7D4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C7D4_1C7D4:
    // LODSW SI (1000_C7D4 / 0x1C7D4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [DI + 0x4] (1000_C7D5 / 0x1C7D5)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JGE 0x1000:c826 (1000_C7D8 / 0x1C7D8)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    // MOV DX,AX (1000_C7DA / 0x1C7DA)
    DX = AX;
    // LODSW SI (1000_C7DC / 0x1C7DC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [DI + 0x6] (1000_C7DD / 0x1C7DD)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JGE 0x1000:c826 (1000_C7E0 / 0x1C7E0)
    if(SignFlag == OverflowFlag) {
      // JGE target is RET, inlining.
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    // MOV BX,AX (1000_C7E2 / 0x1C7E2)
    BX = AX;
    // LODSW SI (1000_C7E4 / 0x1C7E4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [DI] (1000_C7E5 / 0x1C7E5)
    Alu.Sub16(AX, UInt16[DS, DI]);
    // JLE 0x1000:c826 (1000_C7E7 / 0x1C7E7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    // MOV BP,AX (1000_C7E9 / 0x1C7E9)
    BP = AX;
    // LODSW SI (1000_C7EB / 0x1C7EB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [DI + 0x2] (1000_C7EC / 0x1C7EC)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JLE 0x1000:c826 (1000_C7EF / 0x1C7EF)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    // CMP DX,word ptr [DI] (1000_C7F1 / 0x1C7F1)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JNC 0x1000:c7f7 (1000_C7F3 / 0x1C7F3)
    if(!CarryFlag) {
      goto label_1000_C7F7_1C7F7;
    }
    // MOV DX,word ptr [DI] (1000_C7F5 / 0x1C7F5)
    DX = UInt16[DS, DI];
    label_1000_C7F7_1C7F7:
    // CMP BP,word ptr [DI + 0x4] (1000_C7F7 / 0x1C7F7)
    Alu.Sub16(BP, UInt16[DS, (ushort)(DI + 0x4)]);
    // JC 0x1000:c7ff (1000_C7FA / 0x1C7FA)
    if(CarryFlag) {
      goto label_1000_C7FF_1C7FF;
    }
    // MOV BP,word ptr [DI + 0x4] (1000_C7FC / 0x1C7FC)
    BP = UInt16[DS, (ushort)(DI + 0x4)];
    label_1000_C7FF_1C7FF:
    // CMP BX,word ptr [DI + 0x2] (1000_C7FF / 0x1C7FF)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JNC 0x1000:c807 (1000_C802 / 0x1C802)
    if(!CarryFlag) {
      goto label_1000_C807_1C807;
    }
    // MOV BX,word ptr [DI + 0x2] (1000_C804 / 0x1C804)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    label_1000_C807_1C807:
    // CMP AX,word ptr [DI + 0x6] (1000_C807 / 0x1C807)
    Alu.Sub16(AX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JC 0x1000:c80f (1000_C80A / 0x1C80A)
    if(CarryFlag) {
      goto label_1000_C80F_1C80F;
    }
    // MOV AX,word ptr [DI + 0x6] (1000_C80C / 0x1C80C)
    AX = UInt16[DS, (ushort)(DI + 0x6)];
    label_1000_C80F_1C80F:
    // SUB BP,DX (1000_C80F / 0x1C80F)
    // BP -= DX;
    BP = Alu.Sub16(BP, DX);
    // JBE 0x1000:c826 (1000_C811 / 0x1C811)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    // SUB AX,BX (1000_C813 / 0x1C813)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JBE 0x1000:c826 (1000_C815 / 0x1C815)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_C826 / 0x1C826)
      return NearRet();
    }
    // MOV ES,word ptr [0xdbd6] (1000_C817 / 0x1C817)
    ES = UInt16[DS, 0xDBD6];
    // MOV DS,word ptr [0xdbd8] (1000_C81B / 0x1C81B)
    DS = UInt16[DS, 0xDBD8];
    // CALLF [0x38f5] (1000_C81F / 0x1C81F)
    // Indirect call to [0x38f5], generating possible targets from emulator records
    uint targetAddress_1000_C81F = (uint)(UInt16[SS, 0x38F7] * 0x10 + UInt16[SS, 0x38F5] - cs1 * 0x10);
    switch(targetAddress_1000_C81F) {
      case 0x235E0 : FarCall(cs1, 0xC824, spice86_generated_label_call_target_334B_0130_0335E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C81F));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C824_01C824, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C824_01C824(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xC826: goto label_1000_C826_1C826;break; // Target of external jump from 0x1C7E0, 0x1C7EF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C824_1C824:
    // PUSH SS (1000_C824 / 0x1C824)
    Stack.Push(SS);
    // POP DS (1000_C825 / 0x1C825)
    DS = Stack.Pop();
    label_1000_C826_1C826:
    // RET  (1000_C826 / 0x1C826)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C835_01C835(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C835_1C835:
    // MOV DX,0xffff (1000_C835 / 0x1C835)
    DX = 0xFFFF;
    label_1000_C838_1C838:
    // LODSW SI (1000_C838 / 0x1C838)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_C839 / 0x1C839)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:c856 (1000_C83B / 0x1C83B)
    if(ZeroFlag) {
      goto label_1000_C856_1C856;
    }
    // MOV DI,AX (1000_C83D / 0x1C83D)
    DI = AX;
    // MOV AX,word ptr [DI + 0x4] (1000_C83F / 0x1C83F)
    AX = UInt16[DS, (ushort)(DI + 0x4)];
    // ADD AX,word ptr [DI + 0x6] (1000_C842 / 0x1C842)
    AX += UInt16[DS, (ushort)(DI + 0x6)];
    // TEST byte ptr [DI + 0xc],0x40 (1000_C845 / 0x1C845)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0x40);
    // JZ 0x1000:c84e (1000_C849 / 0x1C849)
    if(ZeroFlag) {
      goto label_1000_C84E_1C84E;
    }
    // MOV AX,0x7fff (1000_C84B / 0x1C84B)
    AX = 0x7FFF;
    label_1000_C84E_1C84E:
    // CMP AX,DX (1000_C84E / 0x1C84E)
    Alu.Sub16(AX, DX);
    // JA 0x1000:c856 (1000_C850 / 0x1C850)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_C856_1C856;
    }
    // MOV DX,AX (1000_C852 / 0x1C852)
    DX = AX;
    // MOV BX,SI (1000_C854 / 0x1C854)
    BX = SI;
    label_1000_C856_1C856:
    // LOOP 0x1000:c838 (1000_C856 / 0x1C856)
    if(--CX != 0) {
      goto label_1000_C838_1C838;
    }
    // OR DX,DX (1000_C858 / 0x1C858)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // RET  (1000_C85A / 0x1C85A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C85B_01C85B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C85B_1C85B:
    // MOV AX,[0xce7a] (1000_C85B / 0x1C85B)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0x476e],AX (1000_C85E / 0x1C85E)
    UInt16[DS, 0x476E] = AX;
    // MOV word ptr [0x4772],0x1770 (1000_C861 / 0x1C861)
    UInt16[DS, 0x4772] = 0x1770;
    // RET  (1000_C867 / 0x1C867)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_C868_01C868(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C868_1C868:
    // CALL 0x1000:abcc (1000_C868 / 0x1C868)
    NearCall(cs1, 0xC86B, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    // JNZ 0x1000:c8c0 (1000_C86B / 0x1C86B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_C8C0 / 0x1C8C0)
      return NearRet();
    }
    // MOV SI,word ptr [0x22a6] (1000_C86D / 0x1C86D)
    SI = UInt16[DS, 0x22A6];
    // CMP SI,0x11 (1000_C871 / 0x1C871)
    Alu.Sub16(SI, 0x11);
    // JNC 0x1000:c8c0 (1000_C875 / 0x1C875)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_C8C0 / 0x1C8C0)
      return NearRet();
    }
    // SHL SI,1 (1000_C877 / 0x1C877)
    SI <<= 0x1;
    // SHL SI,1 (1000_C879 / 0x1C879)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV DX,word ptr [SI + 0x27b6] (1000_C87B / 0x1C87B)
    DX = UInt16[DS, (ushort)(SI + 0x27B6)];
    // MOV BX,word ptr [SI + 0x27b8] (1000_C87F / 0x1C87F)
    BX = UInt16[DS, (ushort)(SI + 0x27B8)];
    // MOV AX,BX (1000_C883 / 0x1C883)
    AX = BX;
    // OR AX,DX (1000_C885 / 0x1C885)
    // AX |= DX;
    AX = Alu.Or16(AX, DX);
    // JZ 0x1000:c8c0 (1000_C887 / 0x1C887)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_C8C0 / 0x1C8C0)
      return NearRet();
    }
    // MOV SI,0x2792 (1000_C889 / 0x1C889)
    SI = 0x2792;
    // CMP byte ptr [0x227d],0x0 (1000_C88C / 0x1C88C)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:c8a3 (1000_C891 / 0x1C891)
    if(!ZeroFlag) {
      goto label_1000_C8A3_1C8A3;
    }
    // PUSH BX (1000_C893 / 0x1C893)
    Stack.Push(BX);
    // MOV BX,0x1 (1000_C894 / 0x1C894)
    BX = 0x1;
    // CALL 0x1000:e3b7 (1000_C897 / 0x1C897)
    NearCall(cs1, 0xC89A, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // POP BX (1000_C89A / 0x1C89A)
    BX = Stack.Pop();
    // MOV SI,0x2789 (1000_C89B / 0x1C89B)
    SI = 0x2789;
    // JZ 0x1000:c8a3 (1000_C89E / 0x1C89E)
    if(ZeroFlag) {
      goto label_1000_C8A3_1C8A3;
    }
    // MOV SI,0x278e (1000_C8A0 / 0x1C8A0)
    SI = 0x278E;
    label_1000_C8A3_1C8A3:
    // LODSB SI (1000_C8A3 / 0x1C8A3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_C8A4 / 0x1C8A4)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:c8bd (1000_C8A6 / 0x1C8A6)
    if(ZeroFlag) {
      goto label_1000_C8BD_1C8BD;
    }
    // JNS 0x1000:c8b2 (1000_C8A8 / 0x1C8A8)
    if(!SignFlag) {
      goto label_1000_C8B2_1C8B2;
    }
    // MOV AX,0x12c (1000_C8AA / 0x1C8AA)
    AX = 0x12C;
    // CALL 0x1000:e387 (1000_C8AD / 0x1C8AD)
    NearCall(cs1, 0xC8B0, spice86_generated_label_call_target_1000_E387_01E387);
    // JMP 0x1000:c8a3 (1000_C8B0 / 0x1C8B0)
    goto label_1000_C8A3_1C8A3;
    label_1000_C8B2_1C8B2:
    // PUSH SI (1000_C8B2 / 0x1C8B2)
    Stack.Push(SI);
    // XOR AH,AH (1000_C8B3 / 0x1C8B3)
    AH = 0;
    // MOV BP,AX (1000_C8B5 / 0x1C8B5)
    BP = AX;
    // CALL 0x1000:c8c1 (1000_C8B7 / 0x1C8B7)
    NearCall(cs1, 0xC8BA, not_observed_1000_C8C1_01C8C1);
    // POP SI (1000_C8BA / 0x1C8BA)
    SI = Stack.Pop();
    // JMP 0x1000:c8a3 (1000_C8BB / 0x1C8BB)
    goto label_1000_C8A3_1C8A3;
    label_1000_C8BD_1C8BD:
    // CALL 0x1000:c4dd (1000_C8BD / 0x1C8BD)
    NearCall(cs1, 0xC8C0, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    label_1000_C8C0_1C8C0:
    // RET  (1000_C8C0 / 0x1C8C0)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_C8C1_01C8C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C8C1_1C8C1:
    // PUSH BX (1000_C8C1 / 0x1C8C1)
    Stack.Push(BX);
    // PUSH DX (1000_C8C2 / 0x1C8C2)
    Stack.Push(DX);
    // PUSH word ptr [0xce7a] (1000_C8C3 / 0x1C8C3)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // MOV SI,BP (1000_C8C7 / 0x1C8C7)
    SI = BP;
    // SHL SI,1 (1000_C8C9 / 0x1C8C9)
    SI <<= 0x1;
    // SHL SI,1 (1000_C8CB / 0x1C8CB)
    SI <<= 0x1;
    // SUB DX,word ptr [SI + 0x2796] (1000_C8CD / 0x1C8CD)
    // DX -= UInt16[DS, (ushort)(SI + 0x2796)];
    DX = Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x2796)]);
    // JNC 0x1000:c8d5 (1000_C8D1 / 0x1C8D1)
    if(!CarryFlag) {
      goto label_1000_C8D5_1C8D5;
    }
    // XOR DX,DX (1000_C8D3 / 0x1C8D3)
    DX = 0;
    label_1000_C8D5_1C8D5:
    // SUB BX,word ptr [SI + 0x2798] (1000_C8D5 / 0x1C8D5)
    // BX -= UInt16[DS, (ushort)(SI + 0x2798)];
    BX = Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2798)]);
    // JNC 0x1000:c8dd (1000_C8D9 / 0x1C8D9)
    if(!CarryFlag) {
      goto label_1000_C8DD_1C8DD;
    }
    // XOR BX,BX (1000_C8DB / 0x1C8DB)
    BX = 0;
    label_1000_C8DD_1C8DD:
    // PUSH DS (1000_C8DD / 0x1C8DD)
    Stack.Push(DS);
    // MOV ES,word ptr [0xdbd8] (1000_C8DE / 0x1C8DE)
    ES = UInt16[DS, 0xDBD8];
    // MOV DS,word ptr [0xdbd6] (1000_C8E2 / 0x1C8E2)
    DS = UInt16[DS, 0xDBD6];
    // CALLF [0x3949] (1000_C8E6 / 0x1C8E6)
    // Indirect call to [0x3949], generating possible targets from emulator records
    uint targetAddress_1000_C8E6 = (uint)(UInt16[SS, 0x394B] * 0x10 + UInt16[SS, 0x3949] - cs1 * 0x10);
    switch(targetAddress_1000_C8E6) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C8E6));
        break;
    }
    // POP DS (1000_C8EB / 0x1C8EB)
    DS = Stack.Pop();
    // POP BX (1000_C8EC / 0x1C8EC)
    BX = Stack.Pop();
    label_1000_C8ED_1C8ED:
    // MOV AX,[0xce7a] (1000_C8ED / 0x1C8ED)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,BX (1000_C8F0 / 0x1C8F0)
    AX -= BX;
    // CMP AL,byte ptr [0xdbe6] (1000_C8F2 / 0x1C8F2)
    Alu.Sub8(AL, UInt8[DS, 0xDBE6]);
    // JC 0x1000:c8ed (1000_C8F6 / 0x1C8F6)
    if(CarryFlag) {
      goto label_1000_C8ED_1C8ED;
    }
    // POP DX (1000_C8F8 / 0x1C8F8)
    DX = Stack.Pop();
    // POP BX (1000_C8F9 / 0x1C8F9)
    BX = Stack.Pop();
    // RET  (1000_C8FA / 0x1C8FA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_C8FB_01C8FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C8FB_1C8FB:
    // CALL 0x1000:c07c (1000_C8FB / 0x1C8FB)
    NearCall(cs1, 0xC8FE, spice86_generated_label_call_target_1000_C07C_01C07C);
    // PUSH BP (1000_C8FE / 0x1C8FE)
    Stack.Push(BP);
    // CALL 0x1000:ca1b (1000_C8FF / 0x1C8FF)
    NearCall(cs1, 0xC902, spice86_generated_label_call_target_1000_CA1B_01CA1B);
    // CALL 0x1000:c4dd (1000_C902 / 0x1C902)
    NearCall(cs1, 0xC905, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    // CALL 0x1000:c0f4 (1000_C905 / 0x1C905)
    NearCall(cs1, 0xC908, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // POP BP (1000_C908 / 0x1C908)
    BP = Stack.Pop();
    // CALL BP (1000_C909 / 0x1C909)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_C909 = (uint)(BP);
    switch(targetAddress_1000_C909) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_C909));
        break;
    }
    label_1000_C90B_1C90B:
    // CALL 0x1000:c9f4 (1000_C90B / 0x1C90B)
    NearCall(cs1, 0xC90E, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    // JZ 0x1000:c90b (1000_C90E / 0x1C90E)
    if(ZeroFlag) {
      goto label_1000_C90B_1C90B;
    }
    // CALL 0x1000:c4dd (1000_C910 / 0x1C910)
    NearCall(cs1, 0xC913, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    // CALL 0x1000:ace6 (1000_C913 / 0x1C913)
    NearCall(cs1, 0xC916, spice86_generated_label_call_target_1000_ACE6_01ACE6);
    // CALL 0x1000:cc85 (1000_C916 / 0x1C916)
    NearCall(cs1, 0xC919, spice86_generated_label_call_target_1000_CC85_01CC85);
    // JZ 0x1000:c90b (1000_C919 / 0x1C919)
    if(ZeroFlag) {
      goto label_1000_C90B_1C90B;
    }
    // CALL 0x1000:c412 (1000_C91B / 0x1C91B)
    NearCall(cs1, 0xC91E, spice86_generated_label_call_target_1000_C412_01C412);
    // JMP 0x1000:ca01 (1000_C91E / 0x1C91E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C921_01C921(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C921_1C921:
    // MOV BX,0x33a3 (1000_C921 / 0x1C921)
    BX = 0x33A3;
    // ADD BX,AX (1000_C924 / 0x1C924)
    BX += AX;
    // ADD BX,AX (1000_C926 / 0x1C926)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // MOV BX,word ptr [BX] (1000_C928 / 0x1C928)
    BX = UInt16[DS, BX];
    // RET  (1000_C92A / 0x1C92A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C92B_01C92B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C92B_1C92B:
    // MOV [0xdc00],AX (1000_C92B / 0x1C92B)
    UInt16[DS, 0xDC00] = AX;
    // CALL 0x1000:ca01 (1000_C92E / 0x1C92E)
    NearCall(cs1, 0xC931, spice86_generated_label_call_target_1000_CA01_01CA01);
    label_1000_C931_1C931:
    // CALL 0x1000:ce1a (1000_C931 / 0x1C931)
    NearCall(cs1, 0xC934, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    label_1000_C934_1C934:
    // MOV byte ptr [0xdbe7],0x0 (1000_C934 / 0x1C934)
    UInt8[DS, 0xDBE7] = 0x0;
    // CALL 0x1000:ce01 (1000_C939 / 0x1C939)
    NearCall(cs1, 0xC93C, spice86_generated_label_call_target_1000_CE01_01CE01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C93C_01C93C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C93C_01C93C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C93C_1C93C:
    // MOV AX,[0xdc00] (1000_C93C / 0x1C93C)
    AX = UInt16[DS, 0xDC00];
    // MOV [0xdc02],AX (1000_C93F / 0x1C93F)
    UInt16[DS, 0xDC02] = AX;
    // CALL 0x1000:c921 (1000_C942 / 0x1C942)
    NearCall(cs1, 0xC945, spice86_generated_label_call_target_1000_C921_01C921);
    label_1000_C945_1C945:
    // MOV AX,word ptr [BX] (1000_C945 / 0x1C945)
    AX = UInt16[DS, BX];
    // MOV [0xdbfe],AX (1000_C947 / 0x1C947)
    UInt16[DS, 0xDBFE] = AX;
    // LEA DX,[BX + 0x2] (1000_C94A / 0x1C94A)
    DX = (ushort)(BX + 0x2);
    // CALL 0x1000:f229 (1000_C94D / 0x1C94D)
    NearCall(cs1, 0xC950, spice86_generated_label_call_target_1000_F229_01F229);
    label_1000_C950_1C950:
    // MOV word ptr [0x35a6],BX (1000_C950 / 0x1C950)
    UInt16[DS, 0x35A6] = BX;
    // MOV [0xdc04],AX (1000_C954 / 0x1C954)
    UInt16[DS, 0xDC04] = AX;
    // MOV word ptr [0xdc06],DX (1000_C957 / 0x1C957)
    UInt16[DS, 0xDC06] = DX;
    // MOV word ptr [0xdc08],CX (1000_C95B / 0x1C95B)
    UInt16[DS, 0xDC08] = CX;
    // MOV word ptr [0xdc0a],BP (1000_C95F / 0x1C95F)
    UInt16[DS, 0xDC0A] = BP;
    // PUSH word ptr [0xdc1a] (1000_C963 / 0x1C963)
    Stack.Push(UInt16[DS, 0xDC1A]);
    // PUSH word ptr [0xdc0c] (1000_C967 / 0x1C967)
    Stack.Push(UInt16[DS, 0xDC0C]);
    // CALL 0x1000:cd8f (1000_C96B / 0x1C96B)
    NearCall(cs1, 0xC96E, spice86_generated_label_call_target_1000_CD8F_01CD8F);
    label_1000_C96E_1C96E:
    // JC 0x1000:c988 (1000_C96E / 0x1C96E)
    if(CarryFlag) {
      goto label_1000_C988_1C988;
    }
    // ADD SI,AX (1000_C970 / 0x1C970)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // JC 0x1000:c97a (1000_C972 / 0x1C972)
    if(CarryFlag) {
      goto label_1000_C97A_1C97A;
    }
    // CMP SI,word ptr [0xce74] (1000_C974 / 0x1C974)
    Alu.Sub16(SI, UInt16[DS, 0xCE74]);
    // JBE 0x1000:c980 (1000_C978 / 0x1C978)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C980_1C980;
    }
    label_1000_C97A_1C97A:
    // MOV word ptr [0xdc0c],0x0 (1000_C97A / 0x1C97A)
    UInt16[DS, 0xDC0C] = 0x0;
    label_1000_C980_1C980:
    // SUB AX,0x2 (1000_C980 / 0x1C980)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    // MOV CX,AX (1000_C983 / 0x1C983)
    CX = AX;
    // CALL 0x1000:cdbf (1000_C985 / 0x1C985)
    NearCall(cs1, 0xC988, spice86_generated_label_call_target_1000_CDBF_01CDBF);
    label_1000_C988_1C988:
    // POP word ptr [0xdc0c] (1000_C988 / 0x1C988)
    UInt16[DS, 0xDC0C] = Stack.Pop();
    // POP word ptr [0xdc1a] (1000_C98C / 0x1C98C)
    UInt16[DS, 0xDC1A] = Stack.Pop();
    // JC 0x1000:c9e7 (1000_C990 / 0x1C990)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_C9E7 / 0x1C9E7)
      return NearRet();
    }
    // LES SI,[0xdc0c] (1000_C992 / 0x1C992)
    ES = UInt16[DS, 0xDC0E];
    SI = UInt16[DS, 0xDC0C];
    // LODSW ES:SI (1000_C996 / 0x1C996)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // ADD AX,SI (1000_C998 / 0x1C998)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    // JC 0x1000:c9a2 (1000_C99A / 0x1C99A)
    if(CarryFlag) {
      goto label_1000_C9A2_1C9A2;
    }
    // CMP AX,word ptr [0xce74] (1000_C99C / 0x1C99C)
    Alu.Sub16(AX, UInt16[DS, 0xCE74]);
    // JBE 0x1000:c9a4 (1000_C9A0 / 0x1C9A0)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_C9A4_1C9A4;
    }
    label_1000_C9A2_1C9A2:
    // XOR SI,SI (1000_C9A2 / 0x1C9A2)
    SI = 0;
    label_1000_C9A4_1C9A4:
    // MOV byte ptr [0xdbb4],0xff (1000_C9A4 / 0x1C9A4)
    UInt8[DS, 0xDBB4] = 0xFF;
    // CALL 0x1000:c1ba (1000_C9A9 / 0x1C9A9)
    NearCall(cs1, 0xC9AC, spice86_generated_label_call_target_1000_C1BA_01C1BA);
    label_1000_C9AC_1C9AC:
    // DEC SI (1000_C9AC / 0x1C9AC)
    SI--;
    label_1000_C9AD_1C9AD:
    // INC SI (1000_C9AD / 0x1C9AD)
    SI++;
    // CMP byte ptr ES:[SI],0xff (1000_C9AE / 0x1C9AE)
    Alu.Sub8(UInt8[ES, SI], 0xFF);
    // JZ 0x1000:c9ad (1000_C9B2 / 0x1C9B2)
    if(ZeroFlag) {
      goto label_1000_C9AD_1C9AD;
    }
    // XOR BX,BX (1000_C9B4 / 0x1C9B4)
    BX = 0;
    // TEST byte ptr [0xdbfe],0x4 (1000_C9B6 / 0x1C9B6)
    Alu.And8(UInt8[DS, 0xDBFE], 0x4);
    // JZ 0x1000:c9bf (1000_C9BB / 0x1C9BB)
    if(ZeroFlag) {
      goto label_1000_C9BF_1C9BF;
    }
    // MOV BL,0x10 (1000_C9BD / 0x1C9BD)
    BL = 0x10;
    label_1000_C9BF_1C9BF:
    // MOV CX,word ptr ES:[BX + SI] (1000_C9BF / 0x1C9BF)
    CX = UInt16[ES, (ushort)(BX + SI)];
    // MOV BX,word ptr ES:[BX + SI + 0x2] (1000_C9C2 / 0x1C9C2)
    BX = UInt16[ES, (ushort)(BX + SI + 0x2)];
    // MOV AX,[0xdc04] (1000_C9C6 / 0x1C9C6)
    AX = UInt16[DS, 0xDC04];
    // ADD AX,CX (1000_C9C9 / 0x1C9C9)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // MOV [0xdbf6],AX (1000_C9CB / 0x1C9CB)
    UInt16[DS, 0xDBF6] = AX;
    // MOV AX,[0xdc06] (1000_C9CE / 0x1C9CE)
    AX = UInt16[DS, 0xDC06];
    // ADC AX,BX (1000_C9D1 / 0x1C9D1)
    AX = Alu.Adc16(AX, BX);
    // MOV [0xdbf8],AX (1000_C9D3 / 0x1C9D3)
    UInt16[DS, 0xDBF8] = AX;
    // MOV AX,[0xdc08] (1000_C9D6 / 0x1C9D6)
    AX = UInt16[DS, 0xDC08];
    // SUB AX,CX (1000_C9D9 / 0x1C9D9)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // MOV [0xdbfa],AX (1000_C9DB / 0x1C9DB)
    UInt16[DS, 0xDBFA] = AX;
    // MOV AX,[0xdc0a] (1000_C9DE / 0x1C9DE)
    AX = UInt16[DS, 0xDC0A];
    // SBB AX,BX (1000_C9E1 / 0x1C9E1)
    AX = Alu.Sbb16(AX, BX);
    // MOV [0xdbfc],AX (1000_C9E3 / 0x1C9E3)
    UInt16[DS, 0xDBFC] = AX;
    // CLC  (1000_C9E6 / 0x1C9E6)
    CarryFlag = false;
    label_1000_C9E7_1C9E7:
    // RET  (1000_C9E7 / 0x1C9E7)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C9E8_01C9E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C9E8_1C9E8:
    // CALL 0x1000:ca60 (1000_C9E8 / 0x1C9E8)
    NearCall(cs1, 0xC9EB, spice86_generated_label_call_target_1000_CA60_01CA60);
    label_1000_C9EB_1C9EB:
    // CALL 0x1000:dd63 (1000_C9EB / 0x1C9EB)
    NearCall(cs1, 0xC9EE, spice86_generated_label_call_target_1000_DD63_01DD63);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_C9EE_01C9EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_C9EE_01C9EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C9EE_1C9EE:
    // JC 0x1000:c9f1 (1000_C9EE / 0x1C9EE)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      // JMP 0x1000:de4e (1000_C9F1 / 0x1C9F1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_C9F0 / 0x1C9F0)
    return NearRet();
    label_1000_C9F1_1C9F1:
    // JMP 0x1000:de4e (1000_C9F1 / 0x1C9F1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DE4E_01DE4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_C9F4_01C9F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C9F4_1C9F4:
    // PUSH word ptr [0xdbe8] (1000_C9F4 / 0x1C9F4)
    Stack.Push(UInt16[DS, 0xDBE8]);
    // CALL 0x1000:ca60 (1000_C9F8 / 0x1C9F8)
    NearCall(cs1, 0xC9FB, spice86_generated_label_call_target_1000_CA60_01CA60);
    label_1000_C9FB_1C9FB:
    // POP AX (1000_C9FB / 0x1C9FB)
    AX = Stack.Pop();
    // CMP AX,word ptr [0xdbe8] (1000_C9FC / 0x1C9FC)
    Alu.Sub16(AX, UInt16[DS, 0xDBE8]);
    // RET  (1000_CA00 / 0x1CA00)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA01_01CA01(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA01_1CA01:
    // XOR BX,BX (1000_CA01 / 0x1CA01)
    BX = 0;
    // XCHG word ptr [0x35a6],BX (1000_CA03 / 0x1CA03)
    ushort tmp_1000_CA03 = UInt16[DS, 0x35A6];
    UInt16[DS, 0x35A6] = BX;
    BX = tmp_1000_CA03;
    // OR BX,BX (1000_CA07 / 0x1CA07)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:ca18 (1000_CA09 / 0x1CA09)
    if(ZeroFlag) {
      goto label_1000_CA18_1CA18;
    }
    // CALL 0x1000:ce01 (1000_CA0B / 0x1CA0B)
    NearCall(cs1, 0xCA0E, spice86_generated_label_call_target_1000_CE01_01CE01);
    label_1000_CA0E_1CA0E:
    // CMP BX,word ptr [0xdbba] (1000_CA0E / 0x1CA0E)
    Alu.Sub16(BX, UInt16[DS, 0xDBBA]);
    // JZ 0x1000:ca18 (1000_CA12 / 0x1CA12)
    if(ZeroFlag) {
      goto label_1000_CA18_1CA18;
    }
    // MOV AH,0x3e (1000_CA14 / 0x1CA14)
    AH = 0x3E;
    // INT 0x21 (1000_CA16 / 0x1CA16)
    Interrupt(0x21);
    label_1000_CA18_1CA18:
    // XOR CX,CX (1000_CA18 / 0x1CA18)
    CX = 0;
    // RET  (1000_CA1A / 0x1CA1A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA1B_01CA1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA1B_1CA1B:
    // CALL 0x1000:c92b (1000_CA1B / 0x1CA1B)
    NearCall(cs1, 0xCA1E, spice86_generated_label_call_target_1000_C92B_01C92B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA1E_01CA1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA1E_01CA1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA1E_1CA1E:
    // JC 0x1000:ca01 (1000_CA1E / 0x1CA1E)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:cda0 (1000_CA20 / 0x1CA20)
    NearCall(cs1, 0xCA23, spice86_generated_label_call_target_1000_CDA0_01CDA0);
    label_1000_CA23_1CA23:
    // JC 0x1000:ca01 (1000_CA23 / 0x1CA23)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [0xdce6],0x0 (1000_CA25 / 0x1CA25)
    UInt8[DS, 0xDCE6] = 0x0;
    // LES SI,[0xdc10] (1000_CA2A / 0x1CA2A)
    ES = UInt16[DS, 0xDC12];
    SI = UInt16[DS, 0xDC10];
    // LODSW ES:SI (1000_CA2E / 0x1CA2E)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BP,word ptr [0xdbde] (1000_CA30 / 0x1CA30)
    BP = UInt16[DS, 0xDBDE];
    // CALL 0x1000:ccf4 (1000_CA34 / 0x1CA34)
    NearCall(cs1, 0xCA37, spice86_generated_label_call_target_1000_CCF4_01CCF4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA37_01CA37, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA37_01CA37(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA37_1CA37:
    // CALL 0x1000:aa0f (1000_CA37 / 0x1CA37)
    NearCall(cs1, 0xCA3A, spice86_generated_label_call_target_1000_AA0F_01AA0F);
    label_1000_CA3A_1CA3A:
    // CALL 0x1000:cc96 (1000_CA3A / 0x1CA3A)
    NearCall(cs1, 0xCA3D, spice86_generated_label_call_target_1000_CC96_01CC96);
    label_1000_CA3D_1CA3D:
    // CALL 0x1000:ce1a (1000_CA3D / 0x1CA3D)
    NearCall(cs1, 0xCA40, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    label_1000_CA40_1CA40:
    // INC word ptr [0xdbe8] (1000_CA40 / 0x1CA40)
    UInt16[DS, 0xDBE8]++;
    // INC word ptr [0xdbea] (1000_CA44 / 0x1CA44)
    UInt16[DS, 0xDBEA]++;
    // TEST byte ptr [0xdbfe],0x40 (1000_CA48 / 0x1CA48)
    Alu.And8(UInt8[DS, 0xDBFE], 0x40);
    // JNZ 0x1000:ca59 (1000_CA4D / 0x1CA4D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA59_01CA59, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,0x32 (1000_CA4F / 0x1CA4F)
    CX = 0x32;
    label_1000_CA52_1CA52:
    // PUSH CX (1000_CA52 / 0x1CA52)
    Stack.Push(CX);
    // CALL 0x1000:cb1a (1000_CA53 / 0x1CA53)
    NearCall(cs1, 0xCA56, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    label_1000_CA56_1CA56:
    // POP CX (1000_CA56 / 0x1CA56)
    CX = Stack.Pop();
    // LOOP 0x1000:ca52 (1000_CA57 / 0x1CA57)
    if(--CX != 0) {
      goto label_1000_CA52_1CA52;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA59_01CA59, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA59_01CA59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA59_1CA59:
    // MOV AX,[0xce7a] (1000_CA59 / 0x1CA59)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc22],AX (1000_CA5C / 0x1CA5C)
    UInt16[DS, 0xDC22] = AX;
    // RET  (1000_CA5F / 0x1CA5F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CA60_01CA60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA60_1CA60:
    // CMP word ptr [0x35a6],0x0 (1000_CA60 / 0x1CA60)
    Alu.Sub16(UInt16[DS, 0x35A6], 0x0);
    // JZ 0x1000:ca9a (1000_CA65 / 0x1CA65)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA9A_01CA9A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0xdbfe],0x0 (1000_CA67 / 0x1CA67)
    Alu.Sub8(UInt8[DS, 0xDBFE], 0x0);
    // JNS 0x1000:ca71 (1000_CA6C / 0x1CA6C)
    if(!SignFlag) {
      goto label_1000_CA71_1CA71;
    }
    // CALL 0x1000:ca8f (1000_CA6E / 0x1CA6E)
    NearCall(cs1, 0xCA71, spice86_generated_label_ret_target_1000_CA8F_01CA8F);
    label_1000_CA71_1CA71:
    // CALL 0x1000:caa0 (1000_CA71 / 0x1CA71)
    NearCall(cs1, 0xCA74, spice86_generated_label_call_target_1000_CAA0_01CAA0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA74_01CA74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA74_01CA74(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA74_1CA74:
    // JNC 0x1000:ca7b (1000_CA74 / 0x1CA74)
    if(!CarryFlag) {
      goto label_1000_CA7B_1CA7B;
    }
    // CALL 0x1000:cb1a (1000_CA76 / 0x1CA76)
    NearCall(cs1, 0xCA79, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    label_1000_CA79_1CA79:
    // JMP 0x1000:ca60 (1000_CA79 / 0x1CA79)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA60_01CA60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_CA7B_1CA7B:
    // CALL 0x1000:cad4 (1000_CA7B / 0x1CA7B)
    NearCall(cs1, 0xCA7E, spice86_generated_label_call_target_1000_CAD4_01CAD4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA7E_01CA7E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA7E_01CA7E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA7E_1CA7E:
    // JC 0x1000:ca8f (1000_CA7E / 0x1CA7E)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA8F_01CA8F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0xdc1e] (1000_CA80 / 0x1CA80)
    AX = UInt16[DS, 0xDC1E];
    // INC AX (1000_CA83 / 0x1CA83)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:ca89 (1000_CA84 / 0x1CA84)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA89_01CA89, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:ce3b (1000_CA86 / 0x1CA86)
    NearCall(cs1, 0xCA89, spice86_generated_label_call_target_1000_CE3B_01CE3B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA89_01CA89, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA89_01CA89(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA89_1CA89:
    // CALL 0x1000:cc96 (1000_CA89 / 0x1CA89)
    NearCall(cs1, 0xCA8C, spice86_generated_label_call_target_1000_CC96_01CC96);
    label_1000_CA8C_1CA8C:
    // CALL 0x1000:cc4e (1000_CA8C / 0x1CA8C)
    NearCall(cs1, 0xCA8F, spice86_generated_label_call_target_1000_CC4E_01CC4E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA8F_01CA8F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA8F_01CA8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA8F_1CA8F:
    // MOV AL,[0xdbfe] (1000_CA8F / 0x1CA8F)
    AL = UInt8[DS, 0xDBFE];
    // AND AL,0x80 (1000_CA92 / 0x1CA92)
    // AL &= 0x80;
    AL = Alu.And8(AL, 0x80);
    // MOV [0xdbb5],AL (1000_CA94 / 0x1CA94)
    UInt8[DS, 0xDBB5] = AL;
    // CALL 0x1000:cb1a (1000_CA97 / 0x1CA97)
    NearCall(cs1, 0xCA9A, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CA9A_01CA9A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CA9A_01CA9A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA9A_1CA9A:
    // MOV byte ptr [0xdbb5],0x0 (1000_CA9A / 0x1CA9A)
    UInt8[DS, 0xDBB5] = 0x0;
    // RET  (1000_CA9F / 0x1CA9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CAA0_01CAA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CAA0_1CAA0:
    // CMP word ptr [0xdc16],0x0 (1000_CAA0 / 0x1CAA0)
    Alu.Sub16(UInt16[DS, 0xDC16], 0x0);
    // JA 0x1000:cad3 (1000_CAA5 / 0x1CAA5)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_CAD3 / 0x1CAD3)
      return NearRet();
    }
    // MOV CX,word ptr [0xdc1a] (1000_CAA7 / 0x1CAA7)
    CX = UInt16[DS, 0xDC1A];
    // STC  (1000_CAAB / 0x1CAAB)
    CarryFlag = true;
    // JCXZ 0x1000:cad3 (1000_CAAC / 0x1CAAC)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_CAD3 / 0x1CAD3)
      return NearRet();
    }
    // LES SI,[0xdc10] (1000_CAAE / 0x1CAAE)
    ES = UInt16[DS, 0xDC12];
    SI = UInt16[DS, 0xDC10];
    // LODSW ES:SI (1000_CAB2 / 0x1CAB2)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // CMP word ptr ES:[SI],0x6d6d (1000_CAB4 / 0x1CAB4)
    Alu.Sub16(UInt16[ES, SI], 0x6D6D);
    // JZ 0x1000:cabf (1000_CAB9 / 0x1CAB9)
    if(ZeroFlag) {
      goto label_1000_CABF_1CABF;
    }
    // CMP CX,AX (1000_CABB / 0x1CABB)
    Alu.Sub16(CX, AX);
    // JC 0x1000:cad3 (1000_CABD / 0x1CABD)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CAD3 / 0x1CAD3)
      return NearRet();
    }
    label_1000_CABF_1CABF:
    // MOV BP,word ptr [0xdbd6] (1000_CABF / 0x1CABF)
    BP = UInt16[DS, 0xDBD6];
    // TEST byte ptr [0xdbfe],0x40 (1000_CAC3 / 0x1CAC3)
    Alu.And8(UInt8[DS, 0xDBFE], 0x40);
    // JZ 0x1000:cace (1000_CAC8 / 0x1CAC8)
    if(ZeroFlag) {
      goto label_1000_CACE_1CACE;
    }
    // MOV BP,word ptr [0xdc32] (1000_CACA / 0x1CACA)
    BP = UInt16[DS, 0xDC32];
    label_1000_CACE_1CACE:
    // CALL 0x1000:ccf4 (1000_CACE / 0x1CACE)
    NearCall(cs1, 0xCAD1, spice86_generated_label_call_target_1000_CCF4_01CCF4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CAD1_01CAD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CAD1_01CAD1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCAD3: goto label_1000_CAD3_1CAD3;break; // Target of external jump from 0x1CAA5, 0x1CABD, 0x1CAAC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_CAD1_1CAD1:
    // XOR AX,AX (1000_CAD1 / 0x1CAD1)
    AX = 0;
    label_1000_CAD3_1CAD3:
    // RET  (1000_CAD3 / 0x1CAD3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CAD4_01CAD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CAD4_1CAD4:
    // MOV AX,[0xdc1c] (1000_CAD4 / 0x1CAD4)
    AX = UInt16[DS, 0xDC1C];
    // INC AX (1000_CAD7 / 0x1CAD7)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:caf0 (1000_CAD8 / 0x1CAD8)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_CAF0_01CAF0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0xce7a] (1000_CADA / 0x1CADA)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,word ptr [0xdc22] (1000_CADD / 0x1CADD)
    // AX -= UInt16[DS, 0xDC22];
    AX = Alu.Sub16(AX, UInt16[DS, 0xDC22]);
    // OR AH,AH (1000_CAE1 / 0x1CAE1)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JNZ 0x1000:caeb (1000_CAE3 / 0x1CAE3)
    if(!ZeroFlag) {
      goto label_1000_CAEB_1CAEB;
    }
    // CMP AL,byte ptr [0xdbff] (1000_CAE5 / 0x1CAE5)
    Alu.Sub8(AL, UInt8[DS, 0xDBFF]);
    // JC 0x1000:caef (1000_CAE9 / 0x1CAE9)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CAEF / 0x1CAEF)
      return NearRet();
    }
    label_1000_CAEB_1CAEB:
    // CALL 0x1000:ca59 (1000_CAEB / 0x1CAEB)
    NearCall(cs1, 0xCAEE, spice86_generated_label_call_target_1000_CA59_01CA59);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CAEE_01CAEE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CAEE_01CAEE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCAEF: goto label_1000_CAEF_1CAEF;break; // Target of external jump from 0x1CAE9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_CAEE_1CAEE:
    // CLC  (1000_CAEE / 0x1CAEE)
    CarryFlag = false;
    label_1000_CAEF_1CAEF:
    // RET  (1000_CAEF / 0x1CAEF)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_CAF0_01CAF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CAF0_1CAF0:
    // MOV SI,word ptr [0x3824] (1000_CAF0 / 0x1CAF0)
    SI = UInt16[DS, 0x3824];
    // CMP byte ptr [SI + 0x6],0x1 (1000_CAF4 / 0x1CAF4)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x6)], 0x1);
    // CMC  (1000_CAF8 / 0x1CAF8)
    CarryFlag = !CarryFlag;
    // JC 0x1000:caef (1000_CAF9 / 0x1CAF9)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CAEF / 0x1CAEF)
      return NearRet();
    }
    // CALL 0x1000:a9f4 (1000_CAFB / 0x1CAFB)
    NearCall(cs1, 0xCAFE, not_observed_1000_A9F4_01A9F4);
    // CLC  (1000_CAFE / 0x1CAFE)
    CarryFlag = false;
    // RET  (1000_CAFF / 0x1CAFF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CB00_01CB00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CB00_1CB00:
    // MOV AX,[0xdbea] (1000_CB00 / 0x1CB00)
    AX = UInt16[DS, 0xDBEA];
    // CMP AX,word ptr [0xdbee] (1000_CB03 / 0x1CB03)
    Alu.Sub16(AX, UInt16[DS, 0xDBEE]);
    // JZ 0x1000:cb61 (1000_CB07 / 0x1CB07)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB61_01CB61, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0xdc08] (1000_CB09 / 0x1CB09)
    AX = UInt16[DS, 0xDC08];
    // OR AX,word ptr [0xdc0a] (1000_CB0C / 0x1CB0C)
    // AX |= UInt16[DS, 0xDC0A];
    AX = Alu.Or16(AX, UInt16[DS, 0xDC0A]);
    // JZ 0x1000:cb61 (1000_CB10 / 0x1CB10)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB61_01CB61, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:cd8f (1000_CB12 / 0x1CB12)
    NearCall(cs1, 0xCB15, spice86_generated_label_call_target_1000_CD8F_01CD8F);
    label_1000_CB15_1CB15:
    // JC 0x1000:cb44 (1000_CB15 / 0x1CB15)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    // CALL 0x1000:cc0c (1000_CB17 / 0x1CB17)
    NearCall(cs1, 0xCB1A, spice86_generated_label_call_target_1000_CC0C_01CC0C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CB1A_01CB1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CB1A_01CB1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CB1A_1CB1A:
    // MOV CX,word ptr [0xdc20] (1000_CB1A / 0x1CB1A)
    CX = UInt16[DS, 0xDC20];
    // JCXZ 0x1000:cb00 (1000_CB1E / 0x1CB1E)
    if(CX == 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB00_01CB00, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0xdbfe],0x0 (1000_CB20 / 0x1CB20)
    Alu.Sub8(UInt8[DS, 0xDBFE], 0x0);
    // JS 0x1000:cb38 (1000_CB25 / 0x1CB25)
    if(SignFlag) {
      goto label_1000_CB38_1CB38;
    }
    // MOV AX,[0xdc04] (1000_CB27 / 0x1CB27)
    AX = UInt16[DS, 0xDC04];
    // NEG AX (1000_CB2A / 0x1CB2A)
    AX = Alu.Sub16(0, AX);
    // AND AX,0x7ff (1000_CB2C / 0x1CB2C)
    AX &= 0x7FF;
    // ADD AH,0x8 (1000_CB2F / 0x1CB2F)
    AH += 0x8;
    // CMP AX,CX (1000_CB32 / 0x1CB32)
    Alu.Sub16(AX, CX);
    // JNC 0x1000:cb38 (1000_CB34 / 0x1CB34)
    if(!CarryFlag) {
      goto label_1000_CB38_1CB38;
    }
    // MOV CX,AX (1000_CB36 / 0x1CB36)
    CX = AX;
    label_1000_CB38_1CB38:
    // CALL 0x1000:cc2b (1000_CB38 / 0x1CB38)
    NearCall(cs1, 0xCB3B, spice86_generated_label_call_target_1000_CC2B_01CC2B);
    label_1000_CB3B_1CB3B:
    // JC 0x1000:cb44 (1000_CB3B / 0x1CB3B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    // SUB word ptr [0xdc20],CX (1000_CB3D / 0x1CB3D)
    // UInt16[DS, 0xDC20] -= CX;
    UInt16[DS, 0xDC20] = Alu.Sub16(UInt16[DS, 0xDC20], CX);
    // JMP 0x1000:cdbf (1000_CB41 / 0x1CB41)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CDBF_01CDBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CB44_01CB44(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCB4C: goto label_1000_CB4C_1CB4C;break; // Target of external jump from 0x1CB66
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_CB44_1CB44:
    // RET  (1000_CB44 / 0x1CB44)
    return NearRet();
    label_1000_CB45_1CB45:
    // MOV [0xdc00],AX (1000_CB45 / 0x1CB45)
    UInt16[DS, 0xDC00] = AX;
    // CALL 0x1000:c93c (1000_CB48 / 0x1CB48)
    NearCall(cs1, 0xCB4B, spice86_generated_label_ret_target_1000_C93C_01C93C);
    // RET  (1000_CB4B / 0x1CB4B)
    return NearRet();
    label_1000_CB4C_1CB4C:
    // OR byte ptr [0xdbe7],0x1 (1000_CB4C / 0x1CB4C)
    UInt8[DS, 0xDBE7] |= 0x1;
    // CMP word ptr [0xdc1a],0x0 (1000_CB51 / 0x1CB51)
    Alu.Sub16(UInt16[DS, 0xDC1A], 0x0);
    // JNZ 0x1000:cb60 (1000_CB56 / 0x1CB56)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_CB60 / 0x1CB60)
      return NearRet();
    }
    // OR byte ptr [0xdbe7],0x2 (1000_CB58 / 0x1CB58)
    // UInt8[DS, 0xDBE7] |= 0x2;
    UInt8[DS, 0xDBE7] = Alu.Or8(UInt8[DS, 0xDBE7], 0x2);
    // CALL 0x1000:ca01 (1000_CB5D / 0x1CB5D)
    NearCall(cs1, 0xCB60, spice86_generated_label_call_target_1000_CA01_01CA01);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CB60_01CB60, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CB60_01CB60(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CB60_1CB60:
    // RET  (1000_CB60 / 0x1CB60)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CB61_01CB61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CB61_1CB61:
    // TEST byte ptr [0xdbfe],0x1 (1000_CB61 / 0x1CB61)
    Alu.And8(UInt8[DS, 0xDBFE], 0x1);
    // JZ 0x1000:cb4c (1000_CB66 / 0x1CB66)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB44_01CB44, 0x1CB4C - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,0x1000 (1000_CB68 / 0x1CB68)
    CX = 0x1000;
    // CALL 0x1000:cc2b (1000_CB6B / 0x1CB6B)
    NearCall(cs1, 0xCB6E, spice86_generated_label_call_target_1000_CC2B_01CC2B);
    label_1000_CB6E_1CB6E:
    // JC 0x1000:cb44 (1000_CB6E / 0x1CB6E)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    // MOV AX,[0xdbea] (1000_CB70 / 0x1CB70)
    AX = UInt16[DS, 0xDBEA];
    // CALL 0x1000:ce07 (1000_CB73 / 0x1CB73)
    NearCall(cs1, 0xCB76, spice86_generated_label_call_target_1000_CE07_01CE07);
    label_1000_CB76_1CB76:
    // MOV [0xdbec],AX (1000_CB76 / 0x1CB76)
    UInt16[DS, 0xDBEC] = AX;
    // CALL 0x1000:ca9a (1000_CB79 / 0x1CB79)
    NearCall(cs1, 0xCB7C, spice86_generated_label_ret_target_1000_CA9A_01CA9A);
    label_1000_CB7C_1CB7C:
    // MOV AX,[0xdc02] (1000_CB7C / 0x1CB7C)
    AX = UInt16[DS, 0xDC02];
    // CMP AX,word ptr [0xdc00] (1000_CB7F / 0x1CB7F)
    Alu.Sub16(AX, UInt16[DS, 0xDC00]);
    // JZ 0x1000:cba0 (1000_CB83 / 0x1CB83)
    if(ZeroFlag) {
      goto label_1000_CBA0_1CBA0;
    }
    // CALL 0x1000:c921 (1000_CB85 / 0x1CB85)
    NearCall(cs1, 0xCB88, spice86_generated_label_call_target_1000_C921_01C921);
    // TEST byte ptr [BX],0x8 (1000_CB88 / 0x1CB88)
    Alu.And8(UInt8[DS, BX], 0x8);
    // JZ 0x1000:cb45 (1000_CB8B / 0x1CB8B)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB44_01CB44, 0x1CB45 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP word ptr [BX + -0x6],0x0 (1000_CB8D / 0x1CB8D)
    Alu.Sub16(UInt16[DS, (ushort)(BX - 0x6)], 0x0);
    // JZ 0x1000:cb45 (1000_CB91 / 0x1CB91)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB44_01CB44, 0x1CB45 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV [0xdc00],AX (1000_CB93 / 0x1CB93)
    UInt16[DS, 0xDC00] = AX;
    // LEA SI,[BX + -0x8] (1000_CB96 / 0x1CB96)
    SI = (ushort)(BX - 0x8);
    // MOV DI,0xdbf6 (1000_CB99 / 0x1CB99)
    DI = 0xDBF6;
    // CALL 0x1000:5b99 (1000_CB9C / 0x1CB9C)
    NearCall(cs1, 0xCB9F, spice86_generated_label_call_target_1000_5B99_015B99);
    // MOVSB ES:DI,SI (1000_CB9F / 0x1CB9F)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    label_1000_CBA0_1CBA0:
    // MOV AX,[0xdbfa] (1000_CBA0 / 0x1CBA0)
    AX = UInt16[DS, 0xDBFA];
    // MOV [0xdc08],AX (1000_CBA3 / 0x1CBA3)
    UInt16[DS, 0xDC08] = AX;
    // MOV AX,[0xdbfc] (1000_CBA6 / 0x1CBA6)
    AX = UInt16[DS, 0xDBFC];
    // MOV [0xdc0a],AX (1000_CBA9 / 0x1CBA9)
    UInt16[DS, 0xDC0A] = AX;
    // MOV AX,[0xdbf6] (1000_CBAC / 0x1CBAC)
    AX = UInt16[DS, 0xDBF6];
    // MOV [0xdc04],AX (1000_CBAF / 0x1CBAF)
    UInt16[DS, 0xDC04] = AX;
    // MOV AX,[0xdbf8] (1000_CBB2 / 0x1CBB2)
    AX = UInt16[DS, 0xDBF8];
    // MOV [0xdc06],AX (1000_CBB5 / 0x1CBB5)
    UInt16[DS, 0xDC06] = AX;
    // TEST byte ptr [0xdbfe],0x4 (1000_CBB8 / 0x1CBB8)
    Alu.And8(UInt8[DS, 0xDBFE], 0x4);
    // JZ 0x1000:cc09 (1000_CBBD / 0x1CBBD)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:cb00 (1000_CC09 / 0x1CC09)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB00_01CB00, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0xdc00] (1000_CBBF / 0x1CBBF)
    AX = UInt16[DS, 0xDC00];
    // ADD AX,0x61 (1000_CBC2 / 0x1CBC2)
    // AX += 0x61;
    AX = Alu.Add16(AX, 0x61);
    // CALL 0x1000:c13e (1000_CBC5 / 0x1CBC5)
    NearCall(cs1, 0xCBC8, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV BP,word ptr [0xdbb0] (1000_CBC8 / 0x1CBC8)
    BP = UInt16[DS, 0xDBB0];
    // MOV CX,0x4 (1000_CBCC / 0x1CBCC)
    CX = 0x4;
    label_1000_CBCF_1CBCF:
    // LES DI,[0xdc0c] (1000_CBCF / 0x1CBCF)
    ES = UInt16[DS, 0xDC0E];
    DI = UInt16[DS, 0xDC0C];
    // MOV AX,0x2 (1000_CBD3 / 0x1CBD3)
    AX = 0x2;
    // CALL 0x1000:cdf7 (1000_CBD6 / 0x1CBD6)
    NearCall(cs1, 0xCBD9, not_observed_1000_CDF7_01CDF7);
    // MOV AX,0xa (1000_CBD9 / 0x1CBD9)
    AX = 0xA;
    // STOSW ES:DI (1000_CBDC / 0x1CBDC)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV SI,DI (1000_CBDD / 0x1CBDD)
    SI = DI;
    // CALL 0x1000:cc0c (1000_CBDF / 0x1CBDF)
    NearCall(cs1, 0xCBE2, spice86_generated_label_call_target_1000_CC0C_01CC0C);
    // MOV ES,word ptr [0xdbb2] (1000_CBE2 / 0x1CBE2)
    ES = UInt16[DS, 0xDBB2];
    // PUSH word ptr ES:[BP + 0x0] (1000_CBE6 / 0x1CBE6)
    Stack.Push(UInt16[ES, BP]);
    // PUSH ES (1000_CBEA / 0x1CBEA)
    Stack.Push(ES);
    // LES DI,[0xdc0c] (1000_CBEB / 0x1CBEB)
    ES = UInt16[DS, 0xDC0E];
    DI = UInt16[DS, 0xDC0C];
    // MOV AX,0x6d6d (1000_CBEF / 0x1CBEF)
    AX = 0x6D6D;
    // STOSW ES:DI (1000_CBF2 / 0x1CBF2)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AX,BP (1000_CBF3 / 0x1CBF3)
    AX = BP;
    // STOSW ES:DI (1000_CBF5 / 0x1CBF5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // POP AX (1000_CBF6 / 0x1CBF6)
    AX = Stack.Pop();
    // STOSW ES:DI (1000_CBF7 / 0x1CBF7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // POP AX (1000_CBF8 / 0x1CBF8)
    AX = Stack.Pop();
    // STOSW ES:DI (1000_CBF9 / 0x1CBF9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD BP,AX (1000_CBFA / 0x1CBFA)
    // BP += AX;
    BP = Alu.Add16(BP, AX);
    // MOV AX,0x8 (1000_CBFC / 0x1CBFC)
    AX = 0x8;
    // CALL 0x1000:cdf7 (1000_CBFF / 0x1CBFF)
    NearCall(cs1, 0xCC02, not_observed_1000_CDF7_01CDF7);
    // LOOP 0x1000:cbcf (1000_CC02 / 0x1CC02)
    if(--CX != 0) {
      goto label_1000_CBCF_1CBCF;
    }
    // MOV byte ptr [0xdbb5],0x80 (1000_CC04 / 0x1CC04)
    UInt8[DS, 0xDBB5] = 0x80;
    label_1000_CC09_1CC09:
    // JMP 0x1000:cb00 (1000_CC09 / 0x1CC09)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CB00_01CB00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC0C_01CC0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CC0C_1CC0C:
    // ADD SI,AX (1000_CC0C / 0x1CC0C)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // JC 0x1000:cc16 (1000_CC0E / 0x1CC0E)
    if(CarryFlag) {
      goto label_1000_CC16_1CC16;
    }
    // CMP SI,word ptr [0xce74] (1000_CC10 / 0x1CC10)
    Alu.Sub16(SI, UInt16[DS, 0xCE74]);
    // JBE 0x1000:cc20 (1000_CC14 / 0x1CC14)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CC20_1CC20;
    }
    label_1000_CC16_1CC16:
    // XOR CX,CX (1000_CC16 / 0x1CC16)
    CX = 0;
    // XCHG word ptr [0xdc0c],CX (1000_CC18 / 0x1CC18)
    ushort tmp_1000_CC18 = UInt16[DS, 0xDC0C];
    UInt16[DS, 0xDC0C] = CX;
    CX = tmp_1000_CC18;
    // MOV word ptr [0xdc18],CX (1000_CC1C / 0x1CC1C)
    UInt16[DS, 0xDC18] = CX;
    label_1000_CC20_1CC20:
    // SUB AX,0x2 (1000_CC20 / 0x1CC20)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    // MOV [0xdc20],AX (1000_CC23 / 0x1CC23)
    UInt16[DS, 0xDC20] = AX;
    // INC word ptr [0xdbea] (1000_CC26 / 0x1CC26)
    UInt16[DS, 0xDBEA] = Alu.Inc16(UInt16[DS, 0xDBEA]);
    // RET  (1000_CC2A / 0x1CC2A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC2B_01CC2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CC2B_1CC2B:
    // MOV AX,[0xdc0c] (1000_CC2B / 0x1CC2B)
    AX = UInt16[DS, 0xDC0C];
    // MOV BX,word ptr [0xdc10] (1000_CC2E / 0x1CC2E)
    BX = UInt16[DS, 0xDC10];
    // CMP AX,BX (1000_CC32 / 0x1CC32)
    Alu.Sub16(AX, BX);
    // JNC 0x1000:cc3f (1000_CC34 / 0x1CC34)
    if(!CarryFlag) {
      goto label_1000_CC3F_1CC3F;
    }
    // ADD AX,CX (1000_CC36 / 0x1CC36)
    AX += CX;
    // ADD AX,0x12 (1000_CC38 / 0x1CC38)
    AX += 0x12;
    // CMP BX,AX (1000_CC3B / 0x1CC3B)
    Alu.Sub16(BX, AX);
    // JC 0x1000:cc4d (1000_CC3D / 0x1CC3D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CC4D / 0x1CC4D)
      return NearRet();
    }
    label_1000_CC3F_1CC3F:
    // MOV AX,[0xdc1a] (1000_CC3F / 0x1CC3F)
    AX = UInt16[DS, 0xDC1A];
    // ADD AX,0xa (1000_CC42 / 0x1CC42)
    AX += 0xA;
    // ADD AX,CX (1000_CC45 / 0x1CC45)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    // JC 0x1000:cc4d (1000_CC47 / 0x1CC47)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CC4D / 0x1CC4D)
      return NearRet();
    }
    // CMP word ptr [0xdc18],AX (1000_CC49 / 0x1CC49)
    Alu.Sub16(UInt16[DS, 0xDC18], AX);
    label_1000_CC4D_1CC4D:
    // RET  (1000_CC4D / 0x1CC4D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC4E_01CC4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CC4E_1CC4E:
    // LES SI,[0xdc10] (1000_CC4E / 0x1CC4E)
    ES = UInt16[DS, 0xDC12];
    SI = UInt16[DS, 0xDC10];
    // LODSW ES:SI (1000_CC52 / 0x1CC52)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // SUB word ptr [0xdc1a],AX (1000_CC54 / 0x1CC54)
    UInt16[DS, 0xDC1A] -= AX;
    // ADD SI,AX (1000_CC58 / 0x1CC58)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // JC 0x1000:cc62 (1000_CC5A / 0x1CC5A)
    if(CarryFlag) {
      goto label_1000_CC62_1CC62;
    }
    // CMP SI,word ptr [0xce74] (1000_CC5C / 0x1CC5C)
    Alu.Sub16(SI, UInt16[DS, 0xCE74]);
    // JBE 0x1000:cc6a (1000_CC60 / 0x1CC60)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CC6A_1CC6A;
    }
    label_1000_CC62_1CC62:
    // SUB AX,0x2 (1000_CC62 / 0x1CC62)
    // AX -= 0x2;
    AX = Alu.Sub16(AX, 0x2);
    // MOV [0xdc10],AX (1000_CC65 / 0x1CC65)
    UInt16[DS, 0xDC10] = AX;
    // XOR AX,AX (1000_CC68 / 0x1CC68)
    AX = 0;
    label_1000_CC6A_1CC6A:
    // ADD word ptr [0xdc10],AX (1000_CC6A / 0x1CC6A)
    // UInt16[DS, 0xDC10] += AX;
    UInt16[DS, 0xDC10] = Alu.Add16(UInt16[DS, 0xDC10], AX);
    // MOV AX,[0xdbe8] (1000_CC6E / 0x1CC6E)
    AX = UInt16[DS, 0xDBE8];
    // INC AX (1000_CC71 / 0x1CC71)
    AX++;
    // CMP AX,word ptr [0xdbec] (1000_CC72 / 0x1CC72)
    Alu.Sub16(AX, UInt16[DS, 0xDBEC]);
    // JBE 0x1000:cc81 (1000_CC76 / 0x1CC76)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CC81_1CC81;
    }
    // MOV AX,0x1 (1000_CC78 / 0x1CC78)
    AX = 0x1;
    // MOV word ptr [0xdbec],0xffff (1000_CC7B / 0x1CC7B)
    UInt16[DS, 0xDBEC] = 0xFFFF;
    label_1000_CC81_1CC81:
    // MOV [0xdbe8],AX (1000_CC81 / 0x1CC81)
    UInt16[DS, 0xDBE8] = AX;
    // RET  (1000_CC84 / 0x1CC84)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC85_01CC85(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CC85_1CC85:
    // CMP byte ptr [0xdbe7],0x0 (1000_CC85 / 0x1CC85)
    Alu.Sub8(UInt8[DS, 0xDBE7], 0x0);
    // JZ 0x1000:cc91 (1000_CC8A / 0x1CC8A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_CC91 / 0x1CC91)
      return NearRet();
    }
    // CMP byte ptr [0xdbe7],0x1 (1000_CC8C / 0x1CC8C)
    Alu.Sub8(UInt8[DS, 0xDBE7], 0x1);
    label_1000_CC91_1CC91:
    // RET  (1000_CC91 / 0x1CC91)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CC96_01CC96(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CC96_1CC96:
    // MOV AX,[0x38fb] (1000_CC96 / 0x1CC96)
    AX = UInt16[DS, 0x38FB];
    // MOV CS:[0xcc94],AX (1000_CC99 / 0x1CC99)
    UInt16[cs1, 0xCC94] = AX;
    // XOR BP,BP (1000_CC9D / 0x1CC9D)
    BP = 0;
    // XCHG word ptr [0xdc16],BP (1000_CC9F / 0x1CC9F)
    ushort tmp_1000_CC9F = UInt16[DS, 0xDC16];
    UInt16[DS, 0xDC16] = BP;
    BP = tmp_1000_CC9F;
    // OR BP,BP (1000_CCA3 / 0x1CCA3)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    // JZ 0x1000:cc4d (1000_CCA5 / 0x1CCA5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_CC4D / 0x1CC4D)
      return NearRet();
    }
    // MOV SI,word ptr [0xdc14] (1000_CCA7 / 0x1CCA7)
    SI = UInt16[DS, 0xDC14];
    // MOV AL,[0xdbfe] (1000_CCAB / 0x1CCAB)
    AL = UInt8[DS, 0xDBFE];
    // TEST AL,0x30 (1000_CCAE / 0x1CCAE)
    Alu.And8(AL, 0x30);
    // JNZ 0x1000:ccea (1000_CCB0 / 0x1CCB0)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CCEA_01CCEA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // PUSH DS (1000_CCB2 / 0x1CCB2)
    Stack.Push(DS);
    // TEST word ptr [0xdc24],0x400 (1000_CCB3 / 0x1CCB3)
    Alu.And16(UInt16[DS, 0xDC24], 0x400);
    // JNZ 0x1000:cce1 (1000_CCB9 / 0x1CCB9)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE1_01CCE1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV ES,word ptr [0xdbda] (1000_CCBB / 0x1CCBB)
    ES = UInt16[DS, 0xDBDA];
    // MOV BX,word ptr [0xdc00] (1000_CCBF / 0x1CCBF)
    BX = UInt16[DS, 0xDC00];
    // MOV DS,BP (1000_CCC3 / 0x1CCC3)
    DS = BP;
    // LODSW SI (1000_CCC5 / 0x1CCC5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // AND AH,0xf9 (1000_CCC6 / 0x1CCC6)
    // AH &= 0xF9;
    AH = Alu.And8(AH, 0xF9);
    // MOV DI,AX (1000_CCC9 / 0x1CCC9)
    DI = AX;
    // LODSW SI (1000_CCCB / 0x1CCCB)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_CCCC / 0x1CCCC)
    CX = AX;
    // OR CL,CL (1000_CCCE / 0x1CCCE)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JZ 0x1000:cce1 (1000_CCD0 / 0x1CCD0)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE1_01CCE1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // LODSW SI (1000_CCD2 / 0x1CCD2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_CCD3 / 0x1CCD3)
    DX = AX;
    // LODSW SI (1000_CCD5 / 0x1CCD5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,BX (1000_CCD6 / 0x1CCD6)
    ushort tmp_1000_CCD6 = AX;
    AX = BX;
    BX = tmp_1000_CCD6;
    // CMP AX,0x19 (1000_CCD7 / 0x1CCD7)
    Alu.Sub16(AX, 0x19);
    // JNC 0x1000:cce3 (1000_CCDA / 0x1CCDA)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CCE3_01CCE3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALLF [0x38c9] (1000_CCDC / 0x1CCDC)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_CCDC = (uint)(UInt16[SS, 0x38CB] * 0x10 + UInt16[SS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_CCDC) {
      case 0x235BF : FarCall(cs1, 0xCCE1, spice86_generated_label_call_target_334B_010F_0335BF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CCDC));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE1_01CCE1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CCE1_01CCE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CCE1_1CCE1:
    // POP DS (1000_CCE1 / 0x1CCE1)
    DS = Stack.Pop();
    // RET  (1000_CCE2 / 0x1CCE2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CCE3_01CCE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CCE3_1CCE3:
    // CALLF [0xcc92] (1000_CCE3 / 0x1CCE3)
    // Indirect call to [0xcc92], generating possible targets from emulator records
    uint targetAddress_1000_CCE3 = (uint)(UInt16[cs1, 0xCC94] * 0x10 + UInt16[cs1, 0xCC92]);
    switch(targetAddress_1000_CCE3) {
      case 0x235E3 : FarCall(cs1, 0xCCE8, spice86_generated_label_call_target_334B_0133_0335E3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CCE3));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CCE8_01CCE8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CCE8_01CCE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CCE8_1CCE8:
    // POP DS (1000_CCE8 / 0x1CCE8)
    DS = Stack.Pop();
    // RET  (1000_CCE9 / 0x1CCE9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CCEA_01CCEA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CCEA_1CCEA:
    // TEST AL,0x20 (1000_CCEA / 0x1CCEA)
    Alu.And8(AL, 0x20);
    // JNZ 0x1000:ccf1 (1000_CCEC / 0x1CCEC)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:4aeb (1000_CCF1 / 0x1CCF1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_4AEB_014AEB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:4afd (1000_CCEE / 0x1CCEE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(not_observed_1000_4AEB_014AEB, 0x14AFD - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_CCF1_1CCF1:
    // JMP 0x1000:4aeb (1000_CCF1 / 0x1CCF1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_4AEB_014AEB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CCF4_01CCF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CCF4_1CCF4:
    // MOV word ptr [0xdc1c],0xffff (1000_CCF4 / 0x1CCF4)
    UInt16[DS, 0xDC1C] = 0xFFFF;
    // MOV word ptr [0xdc1e],0xffff (1000_CCFA / 0x1CCFA)
    UInt16[DS, 0xDC1E] = 0xFFFF;
    // ADD AX,SI (1000_CD00 / 0x1CD00)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    // JC 0x1000:cd0a (1000_CD02 / 0x1CD02)
    if(CarryFlag) {
      goto label_1000_CD0A_1CD0A;
    }
    // CMP AX,word ptr [0xce74] (1000_CD04 / 0x1CD04)
    Alu.Sub16(AX, UInt16[DS, 0xCE74]);
    // JBE 0x1000:cd0c (1000_CD08 / 0x1CD08)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CD0C_1CD0C;
    }
    label_1000_CD0A_1CD0A:
    // XOR SI,SI (1000_CD0A / 0x1CD0A)
    SI = 0;
    label_1000_CD0C_1CD0C:
    // LODSW ES:SI (1000_CD0C / 0x1CD0C)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,0x6473 (1000_CD0E / 0x1CD0E)
    Alu.Sub16(AX, 0x6473);
    // JNZ 0x1000:cd25 (1000_CD11 / 0x1CD11)
    if(!ZeroFlag) {
      goto label_1000_CD25_1CD25;
    }
    // CALL 0x1000:ae2f (1000_CD13 / 0x1CD13)
    NearCall(cs1, 0xCD16, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    label_1000_CD16_1CD16:
    // JZ 0x1000:cd1c (1000_CD16 / 0x1CD16)
    if(ZeroFlag) {
      goto label_1000_CD1C_1CD1C;
    }
    // MOV word ptr [0xdc1c],SI (1000_CD18 / 0x1CD18)
    UInt16[DS, 0xDC1C] = SI;
    label_1000_CD1C_1CD1C:
    // LODSW ES:SI (1000_CD1C / 0x1CD1C)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // SUB AX,0x4 (1000_CD1E / 0x1CD1E)
    AX -= 0x4;
    // ADD SI,AX (1000_CD21 / 0x1CD21)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // LODSW ES:SI (1000_CD23 / 0x1CD23)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    label_1000_CD25_1CD25:
    // CMP AX,0x6c70 (1000_CD25 / 0x1CD25)
    Alu.Sub16(AX, 0x6C70);
    // JNZ 0x1000:cd37 (1000_CD28 / 0x1CD28)
    if(!ZeroFlag) {
      goto label_1000_CD37_1CD37;
    }
    // LODSW ES:SI (1000_CD2A / 0x1CD2A)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // MOV word ptr [0xdc1e],SI (1000_CD2C / 0x1CD2C)
    UInt16[DS, 0xDC1E] = SI;
    // SUB AX,0x4 (1000_CD30 / 0x1CD30)
    AX -= 0x4;
    // ADD SI,AX (1000_CD33 / 0x1CD33)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // JMP 0x1000:cd0c (1000_CD35 / 0x1CD35)
    goto label_1000_CD0C_1CD0C;
    label_1000_CD37_1CD37:
    // CMP AX,0x6d6d (1000_CD37 / 0x1CD37)
    Alu.Sub16(AX, 0x6D6D);
    // JNZ 0x1000:cd4e (1000_CD3A / 0x1CD3A)
    if(!ZeroFlag) {
      goto label_1000_CD4E_1CD4E;
    }
    // MOV BX,word ptr ES:[SI + 0x4] (1000_CD3C / 0x1CD3C)
    BX = UInt16[ES, (ushort)(SI + 0x4)];
    // LES SI,ES:[SI] (1000_CD40 / 0x1CD40)
    ES = UInt16[ES, (ushort)(SI + 2)];
    SI = UInt16[ES, SI];
    // LODSW ES:SI (1000_CD43 / 0x1CD43)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,BX (1000_CD45 / 0x1CD45)
    Alu.Sub16(AX, BX);
    // LODSW ES:SI (1000_CD47 / 0x1CD47)
    AX = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    // JZ 0x1000:cd4e (1000_CD49 / 0x1CD49)
    if(ZeroFlag) {
      goto label_1000_CD4E_1CD4E;
    }
    // JMP 0x1000:cc4e (1000_CD4B / 0x1CD4B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CC4E_01CC4E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_CD4E_1CD4E:
    // PUSH DS (1000_CD4E / 0x1CD4E)
    Stack.Push(DS);
    // PUSH ES (1000_CD4F / 0x1CD4F)
    Stack.Push(ES);
    // MOV ES,BP (1000_CD50 / 0x1CD50)
    ES = BP;
    // XOR DI,DI (1000_CD52 / 0x1CD52)
    DI = 0;
    // TEST AH,0x4 (1000_CD54 / 0x1CD54)
    Alu.And8(AH, 0x4);
    // JZ 0x1000:cd5d (1000_CD57 / 0x1CD57)
    if(ZeroFlag) {
      goto label_1000_CD5D_1CD5D;
    }
    // MOV ES,word ptr [0xdbda] (1000_CD59 / 0x1CD59)
    ES = UInt16[DS, 0xDBDA];
    label_1000_CD5D_1CD5D:
    // MOV word ptr [0xdc16],ES (1000_CD5D / 0x1CD5D)
    UInt16[DS, 0xDC16] = ES;
    // MOV word ptr [0xdc14],DI (1000_CD61 / 0x1CD61)
    UInt16[DS, 0xDC14] = DI;
    // MOV [0xdc24],AX (1000_CD65 / 0x1CD65)
    UInt16[DS, 0xDC24] = AX;
    // POP DS (1000_CD68 / 0x1CD68)
    DS = Stack.Pop();
    // MOV CX,AX (1000_CD69 / 0x1CD69)
    CX = AX;
    // LODSW SI (1000_CD6B / 0x1CD6B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,CX (1000_CD6C / 0x1CD6C)
    ushort tmp_1000_CD6C = AX;
    AX = CX;
    CX = tmp_1000_CD6C;
    // TEST AH,0x4 (1000_CD6D / 0x1CD6D)
    Alu.And8(AH, 0x4);
    // JNZ 0x1000:cd7c (1000_CD70 / 0x1CD70)
    if(!ZeroFlag) {
      goto label_1000_CD7C_1CD7C;
    }
    // STOSW ES:DI (1000_CD72 / 0x1CD72)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // XCHG AX,CX (1000_CD73 / 0x1CD73)
    ushort tmp_1000_CD73 = AX;
    AX = CX;
    CX = tmp_1000_CD73;
    // STOSW ES:DI (1000_CD74 / 0x1CD74)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // JCXZ 0x1000:cd7f (1000_CD75 / 0x1CD75)
    if(CX == 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CD7F_01CD7F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // TEST CH,0x2 (1000_CD77 / 0x1CD77)
    Alu.And8(CH, 0x2);
    // JZ 0x1000:cd81 (1000_CD7A / 0x1CD7A)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CD81_01CD81, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_CD7C_1CD7C:
    // CALL 0x1000:f403 (1000_CD7C / 0x1CD7C)
    NearCall(cs1, 0xCD7F, spice86_generated_label_call_target_1000_F403_01F403);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CD7F_01CD7F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CD7F_01CD7F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CD7F_1CD7F:
    // POP DS (1000_CD7F / 0x1CD7F)
    DS = Stack.Pop();
    // RET  (1000_CD80 / 0x1CD80)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CD81_01CD81(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CD81_1CD81:
    // SUB SI,0x4 (1000_CD81 / 0x1CD81)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    // MOV AX,DS (1000_CD84 / 0x1CD84)
    AX = DS;
    // POP DS (1000_CD86 / 0x1CD86)
    DS = Stack.Pop();
    // MOV word ptr [0xdc14],SI (1000_CD87 / 0x1CD87)
    UInt16[DS, 0xDC14] = SI;
    // MOV [0xdc16],AX (1000_CD8B / 0x1CD8B)
    UInt16[DS, 0xDC16] = AX;
    // RET  (1000_CD8E / 0x1CD8E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CD8F_01CD8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CD8F_1CD8F:
    // MOV CX,0x2 (1000_CD8F / 0x1CD8F)
    CX = 0x2;
    // CALL 0x1000:cdbf (1000_CD92 / 0x1CD92)
    NearCall(cs1, 0xCD95, spice86_generated_label_call_target_1000_CDBF_01CDBF);
    label_1000_CD95_1CD95:
    // JC 0x1000:cd9f (1000_CD95 / 0x1CD95)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CD9F / 0x1CD9F)
      return NearRet();
    }
    // LES SI,[0xdc0c] (1000_CD97 / 0x1CD97)
    ES = UInt16[DS, 0xDC0E];
    SI = UInt16[DS, 0xDC0C];
    // MOV AX,word ptr ES:[SI + -0x2] (1000_CD9B / 0x1CD9B)
    AX = UInt16[ES, (ushort)(SI - 0x2)];
    label_1000_CD9F_1CD9F:
    // RET  (1000_CD9F / 0x1CD9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CDA0_01CDA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CDA0_1CDA0:
    // CALL 0x1000:ce1a (1000_CDA0 / 0x1CDA0)
    NearCall(cs1, 0xCDA3, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    label_1000_CDA3_1CDA3:
    // CALL 0x1000:cd8f (1000_CDA3 / 0x1CDA3)
    NearCall(cs1, 0xCDA6, spice86_generated_label_call_target_1000_CD8F_01CD8F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CDA6_01CDA6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CDA6_01CDA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CDA6_1CDA6:
    // JC 0x1000:ce00 (1000_CDA6 / 0x1CDA6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CE00 / 0x1CE00)
      return NearRet();
    }
    // MOV DI,word ptr [0xce74] (1000_CDA8 / 0x1CDA8)
    DI = UInt16[DS, 0xCE74];
    // SUB DI,AX (1000_CDAC / 0x1CDAC)
    DI -= AX;
    // SUB DI,0x2 (1000_CDAE / 0x1CDAE)
    // DI -= 0x2;
    DI = Alu.Sub16(DI, 0x2);
    // MOV word ptr [0xdc10],DI (1000_CDB1 / 0x1CDB1)
    UInt16[DS, 0xDC10] = DI;
    // STOSW ES:DI (1000_CDB5 / 0x1CDB5)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV word ptr [0xdc0c],DI (1000_CDB6 / 0x1CDB6)
    UInt16[DS, 0xDC0C] = DI;
    // MOV CX,AX (1000_CDBA / 0x1CDBA)
    CX = AX;
    // SUB CX,0x2 (1000_CDBC / 0x1CDBC)
    // CX -= 0x2;
    CX = Alu.Sub16(CX, 0x2);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CDBF_01CDBF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CDBF_01CDBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CDBF_1CDBF:
    // MOV BX,word ptr [0x35a6] (1000_CDBF / 0x1CDBF)
    BX = UInt16[DS, 0x35A6];
    // CMP BX,0x1 (1000_CDC3 / 0x1CDC3)
    Alu.Sub16(BX, 0x1);
    // JC 0x1000:ce00 (1000_CDC6 / 0x1CDC6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CE00 / 0x1CE00)
      return NearRet();
    }
    label_1000_CDC8_1CDC8:
    // PUSH CX (1000_CDC8 / 0x1CDC8)
    Stack.Push(CX);
    // MOV CX,word ptr [0xdc06] (1000_CDC9 / 0x1CDC9)
    CX = UInt16[DS, 0xDC06];
    // MOV DX,word ptr [0xdc04] (1000_CDCD / 0x1CDCD)
    DX = UInt16[DS, 0xDC04];
    // MOV AX,0x4200 (1000_CDD1 / 0x1CDD1)
    AX = 0x4200;
    // INT 0x21 (1000_CDD4 / 0x1CDD4)
    Interrupt(0x21);
    // POP CX (1000_CDD6 / 0x1CDD6)
    CX = Stack.Pop();
    // PUSH DS (1000_CDD7 / 0x1CDD7)
    Stack.Push(DS);
    // LDS DX,[0xdc0c] (1000_CDD8 / 0x1CDD8)
    DS = UInt16[DS, 0xDC0E];
    DX = UInt16[DS, 0xDC0C];
    // MOV AH,0x3f (1000_CDDC / 0x1CDDC)
    AH = 0x3F;
    // INT 0x21 (1000_CDDE / 0x1CDDE)
    Interrupt(0x21);
    // POP DS (1000_CDE0 / 0x1CDE0)
    DS = Stack.Pop();
    // CMP AX,CX (1000_CDE1 / 0x1CDE1)
    Alu.Sub16(AX, CX);
    // JC 0x1000:cdc8 (1000_CDE3 / 0x1CDE3)
    if(CarryFlag) {
      goto label_1000_CDC8_1CDC8;
    }
    // SUB word ptr [0xdc08],AX (1000_CDE5 / 0x1CDE5)
    // UInt16[DS, 0xDC08] -= AX;
    UInt16[DS, 0xDC08] = Alu.Sub16(UInt16[DS, 0xDC08], AX);
    // SBB word ptr [0xdc0a],0x0 (1000_CDE9 / 0x1CDE9)
    UInt16[DS, 0xDC0A] = Alu.Sbb16(UInt16[DS, 0xDC0A], 0x0);
    // ADD word ptr [0xdc04],AX (1000_CDEE / 0x1CDEE)
    // UInt16[DS, 0xDC04] += AX;
    UInt16[DS, 0xDC04] = Alu.Add16(UInt16[DS, 0xDC04], AX);
    // ADC word ptr [0xdc06],0x0 (1000_CDF2 / 0x1CDF2)
    UInt16[DS, 0xDC06] = Alu.Adc16(UInt16[DS, 0xDC06], 0x0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_CDF7_01CDF7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_CDF7_01CDF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CDF7_1CDF7:
    // ADD word ptr [0xdc0c],AX (1000_CDF7 / 0x1CDF7)
    UInt16[DS, 0xDC0C] += AX;
    // ADD word ptr [0xdc1a],AX (1000_CDFB / 0x1CDFB)
    // UInt16[DS, 0xDC1A] += AX;
    UInt16[DS, 0xDC1A] = Alu.Add16(UInt16[DS, 0xDC1A], AX);
    // CLC  (1000_CDFF / 0x1CDFF)
    CarryFlag = false;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_CE00_01CE00, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_CE00_01CE00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE00_1CE00:
    // RET  (1000_CE00 / 0x1CE00)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE01_01CE01(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE01_1CE01:
    // MOV word ptr [0xdbe8],0x0 (1000_CE01 / 0x1CE01)
    UInt16[DS, 0xDBE8] = 0x0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CE07_01CE07, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE07_01CE07(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE07_1CE07:
    // MOV word ptr [0xdbea],0x0 (1000_CE07 / 0x1CE07)
    UInt16[DS, 0xDBEA] = 0x0;
    // MOV word ptr [0xdbec],0xffff (1000_CE0D / 0x1CE0D)
    UInt16[DS, 0xDBEC] = 0xFFFF;
    // MOV word ptr [0xdbee],0xffff (1000_CE13 / 0x1CE13)
    UInt16[DS, 0xDBEE] = 0xFFFF;
    // RET  (1000_CE19 / 0x1CE19)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE1A_01CE1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE1A_1CE1A:
    // MOV AX,[0xdbde] (1000_CE1A / 0x1CE1A)
    AX = UInt16[DS, 0xDBDE];
    // MOV [0xdc0e],AX (1000_CE1D / 0x1CE1D)
    UInt16[DS, 0xDC0E] = AX;
    // MOV [0xdc12],AX (1000_CE20 / 0x1CE20)
    UInt16[DS, 0xDC12] = AX;
    // XOR AX,AX (1000_CE23 / 0x1CE23)
    AX = 0;
    // MOV [0xdc0c],AX (1000_CE25 / 0x1CE25)
    UInt16[DS, 0xDC0C] = AX;
    // MOV [0xdc10],AX (1000_CE28 / 0x1CE28)
    UInt16[DS, 0xDC10] = AX;
    // MOV [0xdc1a],AX (1000_CE2B / 0x1CE2B)
    UInt16[DS, 0xDC1A] = AX;
    // MOV [0xdc20],AX (1000_CE2E / 0x1CE2E)
    UInt16[DS, 0xDC20] = AX;
    // MOV [0xdc16],AX (1000_CE31 / 0x1CE31)
    UInt16[DS, 0xDC16] = AX;
    // MOV AX,[0xce74] (1000_CE34 / 0x1CE34)
    AX = UInt16[DS, 0xCE74];
    // MOV [0xdc18],AX (1000_CE37 / 0x1CE37)
    UInt16[DS, 0xDC18] = AX;
    // RET  (1000_CE3A / 0x1CE3A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE3B_01CE3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE3B_1CE3B:
    // LES SI,[0xdc0c] (1000_CE3B / 0x1CE3B)
    ES = UInt16[DS, 0xDC0E];
    SI = UInt16[DS, 0xDC0C];
    // MOV SI,word ptr [0xdc1e] (1000_CE3F / 0x1CE3F)
    SI = UInt16[DS, 0xDC1E];
    // CALL 0x1000:c1ba (1000_CE43 / 0x1CE43)
    NearCall(cs1, 0xCE46, spice86_generated_label_call_target_1000_C1BA_01C1BA);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CE46_01CE46, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CE46_01CE46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE46_1CE46:
    // CALLF [0x3935] (1000_CE46 / 0x1CE46)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_CE46 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_CE46) {
      case 0x23610 : FarCall(cs1, 0xCE4A, spice86_generated_label_call_target_334B_0160_033610); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CE46));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CE4A_01CE4A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CE4A_01CE4A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE4A_1CE4A:
    // RET  (1000_CE4A / 0x1CE4A)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_CE4B_01CE4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE4B_1CE4B:
    // MOV word ptr [0xdc02],BX (1000_CE4B / 0x1CE4B)
    UInt16[DS, 0xDC02] = BX;
    // MOV [0xdbee],AX (1000_CE4F / 0x1CE4F)
    UInt16[DS, 0xDBEE] = AX;
    // RET  (1000_CE52 / 0x1CE52)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE53_01CE53(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE53_1CE53:
    // TEST byte ptr [0x3403],0x4 (1000_CE53 / 0x1CE53)
    Alu.And8(UInt8[DS, 0x3403], 0x4);
    // JZ 0x1000:ce6b (1000_CE58 / 0x1CE58)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_CE6B / 0x1CE6B)
      return NearRet();
    }
    // MOV AX,0x2 (1000_CE5A / 0x1CE5A)
    AX = 0x2;
    label_1000_CE5D_1CE5D:
    // PUSH AX (1000_CE5D / 0x1CE5D)
    Stack.Push(AX);
    // ADD AX,0x61 (1000_CE5E / 0x1CE5E)
    // AX += 0x61;
    AX = Alu.Add16(AX, 0x61);
    // CALL 0x1000:c13e (1000_CE61 / 0x1CE61)
    NearCall(cs1, 0xCE64, spice86_generated_label_call_target_1000_C13E_01C13E);
    // POP AX (1000_CE64 / 0x1CE64)
    AX = Stack.Pop();
    // INC AX (1000_CE65 / 0x1CE65)
    AX++;
    // CMP AX,0x8 (1000_CE66 / 0x1CE66)
    Alu.Sub16(AX, 0x8);
    // JC 0x1000:ce5d (1000_CE69 / 0x1CE69)
    if(CarryFlag) {
      goto label_1000_CE5D_1CE5D;
    }
    label_1000_CE6B_1CE6B:
    // RET  (1000_CE6B / 0x1CE6B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CE6C_01CE6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE6C_1CE6C:
    // TEST byte ptr [0x2943],0x2 (1000_CE6C / 0x1CE6C)
    Alu.And8(UInt8[DS, 0x2943], 0x2);
    // JNZ 0x1000:ce7b (1000_CE71 / 0x1CE71)
    if(!ZeroFlag) {
      goto label_1000_CE7B_1CE7B;
    }
    // CMP word ptr [0x39a9],0x15e (1000_CE73 / 0x1CE73)
    Alu.Sub16(UInt16[DS, 0x39A9], 0x15E);
    // JNC 0x1000:ce8a (1000_CE79 / 0x1CE79)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CE7E_01CE7E, 0x1CE8A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_CE7B_1CE7B:
    // MOV AX,0x2 (1000_CE7B / 0x1CE7B)
    AX = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CE7E_01CE7E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CE7E_01CE7E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE7E_1CE7E:
    // CALL 0x1000:c921 (1000_CE7E / 0x1CE7E)
    NearCall(cs1, 0xCE81, spice86_generated_label_call_target_1000_C921_01C921);
    label_1000_CE81_1CE81:
    // AND byte ptr [BX],0xfb (1000_CE81 / 0x1CE81)
    UInt8[DS, BX] &= 0xFB;
    // INC AX (1000_CE84 / 0x1CE84)
    AX++;
    // CMP AX,0x9 (1000_CE85 / 0x1CE85)
    Alu.Sub16(AX, 0x9);
    // JC 0x1000:ce7e (1000_CE88 / 0x1CE88)
    if(CarryFlag) {
      goto label_1000_CE7E_1CE7E;
    }
    label_1000_CE8A_1CE8A:
    // TEST byte ptr [0x2943],0x3 (1000_CE8A / 0x1CE8A)
    Alu.And8(UInt8[DS, 0x2943], 0x3);
    // JZ 0x1000:ce9f (1000_CE8F / 0x1CE8F)
    if(ZeroFlag) {
      goto label_1000_CE9F_1CE9F;
    }
    // XOR AX,AX (1000_CE91 / 0x1CE91)
    AX = 0;
    label_1000_CE93_1CE93:
    // CALL 0x1000:c921 (1000_CE93 / 0x1CE93)
    NearCall(cs1, 0xCE96, spice86_generated_label_call_target_1000_C921_01C921);
    // AND byte ptr [BX],0x7f (1000_CE96 / 0x1CE96)
    UInt8[DS, BX] &= 0x7F;
    // INC AX (1000_CE99 / 0x1CE99)
    AX++;
    // CMP AX,0x25 (1000_CE9A / 0x1CE9A)
    Alu.Sub16(AX, 0x25);
    // JC 0x1000:ce93 (1000_CE9D / 0x1CE9D)
    if(CarryFlag) {
      goto label_1000_CE93_1CE93;
    }
    label_1000_CE9F_1CE9F:
    // MOV AX,0x2 (1000_CE9F / 0x1CE9F)
    AX = 0x2;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CEA2_01CEA2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CEA2_01CEA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEA2_1CEA2:
    // PUSH AX (1000_CEA2 / 0x1CEA2)
    Stack.Push(AX);
    // CALL 0x1000:ceb0 (1000_CEA3 / 0x1CEA3)
    NearCall(cs1, 0xCEA6, spice86_generated_label_call_target_1000_CEB0_01CEB0);
    label_1000_CEA6_1CEA6:
    // POP AX (1000_CEA6 / 0x1CEA6)
    AX = Stack.Pop();
    // INC AX (1000_CEA7 / 0x1CEA7)
    AX++;
    // CMP AX,0x8 (1000_CEA8 / 0x1CEA8)
    Alu.Sub16(AX, 0x8);
    // JC 0x1000:cea2 (1000_CEAB / 0x1CEAB)
    if(CarryFlag) {
      goto label_1000_CEA2_1CEA2;
    }
    // JMP 0x1000:ca01 (1000_CEAD / 0x1CEAD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA01_01CA01, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CEB0_01CEB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEB0_1CEB0:
    // CALL 0x1000:c921 (1000_CEB0 / 0x1CEB0)
    NearCall(cs1, 0xCEB3, spice86_generated_label_call_target_1000_C921_01C921);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEB3_01CEB3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEB3_01CEB3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEB3_1CEB3:
    // PUSH BX (1000_CEB3 / 0x1CEB3)
    Stack.Push(BX);
    // CALL 0x1000:c92b (1000_CEB4 / 0x1CEB4)
    NearCall(cs1, 0xCEB7, spice86_generated_label_call_target_1000_C92B_01C92B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEB7_01CEB7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEB7_01CEB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEB7_1CEB7:
    // POP DI (1000_CEB7 / 0x1CEB7)
    DI = Stack.Pop();
    // JC 0x1000:cec8 (1000_CEB8 / 0x1CEB8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CEC8 / 0x1CEC8)
      return NearRet();
    }
    // TEST byte ptr [DI],0x8 (1000_CEBA / 0x1CEBA)
    Alu.And8(UInt8[DS, DI], 0x8);
    // JZ 0x1000:cec8 (1000_CEBD / 0x1CEBD)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_CEC8 / 0x1CEC8)
      return NearRet();
    }
    // SUB DI,0x8 (1000_CEBF / 0x1CEBF)
    // DI -= 0x8;
    DI = Alu.Sub16(DI, 0x8);
    // MOV SI,0xdbf6 (1000_CEC2 / 0x1CEC2)
    SI = 0xDBF6;
    // CALL 0x1000:5b99 (1000_CEC5 / 0x1CEC5)
    NearCall(cs1, 0xCEC8, spice86_generated_label_call_target_1000_5B99_015B99);
    label_1000_CEC8_1CEC8:
    // RET  (1000_CEC8 / 0x1CEC8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CEC9_01CEC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEC9_1CEC9:
    // PUSHF  (1000_CEC9 / 0x1CEC9)
    Stack.Push(FlagRegister);
    // PUSH BX (1000_CECA / 0x1CECA)
    Stack.Push(BX);
    // PUSH CX (1000_CECB / 0x1CECB)
    Stack.Push(CX);
    // PUSH DX (1000_CECC / 0x1CECC)
    Stack.Push(DX);
    // PUSH SI (1000_CECD / 0x1CECD)
    Stack.Push(SI);
    // PUSH DI (1000_CECE / 0x1CECE)
    Stack.Push(DI);
    // PUSH BP (1000_CECF / 0x1CECF)
    Stack.Push(BP);
    // PUSH ES (1000_CED0 / 0x1CED0)
    Stack.Push(ES);
    // XOR AX,AX (1000_CED1 / 0x1CED1)
    AX = 0;
    // XCHG byte ptr [0xdbb5],AL (1000_CED3 / 0x1CED3)
    byte tmp_1000_CED3 = UInt8[DS, 0xDBB5];
    UInt8[DS, 0xDBB5] = AL;
    AL = tmp_1000_CED3;
    // STI  (1000_CED7 / 0x1CED7)
    InterruptFlag = true;
    // PUSH AX (1000_CED8 / 0x1CED8)
    Stack.Push(AX);
    // CALL 0x1000:caa0 (1000_CED9 / 0x1CED9)
    NearCall(cs1, 0xCEDC, spice86_generated_label_call_target_1000_CAA0_01CAA0);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEDC_01CEDC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEDC_01CEDC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEDC_1CEDC:
    // JBE 0x1000:ceef (1000_CEDC / 0x1CEDC)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEE7_01CEE7, 0x1CEEF - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,[0xdc1e] (1000_CEDE / 0x1CEDE)
    AX = UInt16[DS, 0xDC1E];
    // INC AX (1000_CEE1 / 0x1CEE1)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:ceef (1000_CEE2 / 0x1CEE2)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEE7_01CEE7, 0x1CEEF - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:cad4 (1000_CEE4 / 0x1CEE4)
    NearCall(cs1, 0xCEE7, spice86_generated_label_call_target_1000_CAD4_01CAD4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CEE7_01CEE7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CEE7_01CEE7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCEEF: goto label_1000_CEEF_1CEEF;break; // Target of external jump from 0x1CEDC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_CEE7_1CEE7:
    // JC 0x1000:ceef (1000_CEE7 / 0x1CEE7)
    if(CarryFlag) {
      goto label_1000_CEEF_1CEEF;
    }
    // CALL 0x1000:cc96 (1000_CEE9 / 0x1CEE9)
    NearCall(cs1, 0xCEEC, spice86_generated_label_call_target_1000_CC96_01CC96);
    label_1000_CEEC_1CEEC:
    // CALL 0x1000:cc4e (1000_CEEC / 0x1CEEC)
    NearCall(cs1, 0xCEEF, spice86_generated_label_call_target_1000_CC4E_01CC4E);
    label_1000_CEEF_1CEEF:
    // POP AX (1000_CEEF / 0x1CEEF)
    AX = Stack.Pop();
    // MOV [0xdbb5],AL (1000_CEF0 / 0x1CEF0)
    UInt8[DS, 0xDBB5] = AL;
    // POP ES (1000_CEF3 / 0x1CEF3)
    ES = Stack.Pop();
    // POP BP (1000_CEF4 / 0x1CEF4)
    BP = Stack.Pop();
    // POP DI (1000_CEF5 / 0x1CEF5)
    DI = Stack.Pop();
    // POP SI (1000_CEF6 / 0x1CEF6)
    SI = Stack.Pop();
    // POP DX (1000_CEF7 / 0x1CEF7)
    DX = Stack.Pop();
    // POP CX (1000_CEF8 / 0x1CEF8)
    CX = Stack.Pop();
    // POP BX (1000_CEF9 / 0x1CEF9)
    BX = Stack.Pop();
    // POPF  (1000_CEFA / 0x1CEFA)
    FlagRegister = Stack.Pop();
    // RET  (1000_CEFB / 0x1CEFB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CEFC_01CEFC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEFC_1CEFC:
    // MOV AX,0x69 (1000_CEFC / 0x1CEFC)
    AX = 0x69;
    // ADD AL,byte ptr [0xceeb] (1000_CEFF / 0x1CEFF)
    // AL += UInt8[DS, 0xCEEB];
    AL = Alu.Add8(AL, UInt8[DS, 0xCEEB]);
    // CALL 0x1000:c13e (1000_CF03 / 0x1CF03)
    NearCall(cs1, 0xCF06, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF06_01CF06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF06_01CF06(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF06_1CF06:
    // MOV word ptr [0x3622],0x35a8 (1000_CF06 / 0x1CF06)
    UInt16[DS, 0x3622] = 0x35A8;
    // XOR AX,AX (1000_CF0C / 0x1CF0C)
    AX = 0;
    // CALLF [0x3939] (1000_CF0E / 0x1CF0E)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_CF0E = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_CF0E) {
      case 0x23613 : FarCall(cs1, 0xCF12, spice86_generated_label_call_target_334B_0163_033613); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CF0E));
        break;
    }
    label_1000_CF12_1CF12:
    // CALL 0x1000:c0ad (1000_CF12 / 0x1CF12)
    NearCall(cs1, 0xCF15, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF15_01CF15, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF15_01CF15(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF15_1CF15:
    // MOV AX,0x19 (1000_CF15 / 0x1CF15)
    AX = 0x19;
    // JMP 0x1000:ca1b (1000_CF18 / 0x1CF18)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CF1B_01CF1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF1B_1CF1B:
    // PUSH word ptr [0xdbda] (1000_CF1B / 0x1CF1B)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_CF1F / 0x1CF1F)
    NearCall(cs1, 0xCF22, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF22_01CF22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF22_01CF22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF22_1CF22:
    // MOV SI,word ptr [0x3622] (1000_CF22 / 0x1CF22)
    SI = UInt16[DS, 0x3622];
    // LODSW SI (1000_CF26 / 0x1CF26)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // CMP AX,word ptr [0xdbe8] (1000_CF27 / 0x1CF27)
    Alu.Sub16(AX, UInt16[DS, 0xDBE8]);
    // JA 0x1000:cf30 (1000_CF2B / 0x1CF2B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_CF30_1CF30;
    }
    // CALL 0x1000:cf4b (1000_CF2D / 0x1CF2D)
    NearCall(cs1, 0xCF30, spice86_generated_label_call_target_1000_CF4B_01CF4B);
    label_1000_CF30_1CF30:
    // CALL 0x1000:c9e8 (1000_CF30 / 0x1CF30)
    NearCall(cs1, 0xCF33, spice86_generated_label_call_target_1000_C9E8_01C9E8);
    label_1000_CF33_1CF33:
    // JC 0x1000:cf3b (1000_CF33 / 0x1CF33)
    if(CarryFlag) {
      goto label_1000_CF3B_1CF3B;
    }
    // CALL 0x1000:cc85 (1000_CF35 / 0x1CF35)
    NearCall(cs1, 0xCF38, spice86_generated_label_call_target_1000_CC85_01CC85);
    label_1000_CF38_1CF38:
    // JZ 0x1000:cf22 (1000_CF38 / 0x1CF38)
    if(ZeroFlag) {
      goto label_1000_CF22_1CF22;
    }
    // CLC  (1000_CF3A / 0x1CF3A)
    CarryFlag = false;
    label_1000_CF3B_1CF3B:
    // PUSHF  (1000_CF3B / 0x1CF3B)
    Stack.Push(FlagRegister);
    // CALL 0x1000:ca01 (1000_CF3C / 0x1CF3C)
    NearCall(cs1, 0xCF3F, spice86_generated_label_call_target_1000_CA01_01CA01);
    label_1000_CF3F_1CF3F:
    // CALL 0x1000:ac14 (1000_CF3F / 0x1CF3F)
    NearCall(cs1, 0xCF42, spice86_generated_label_call_target_1000_AC14_01AC14);
    label_1000_CF42_1CF42:
    // CALL 0x1000:ad57 (1000_CF42 / 0x1CF42)
    NearCall(cs1, 0xCF45, spice86_generated_label_call_target_1000_AD57_01AD57);
    label_1000_CF45_1CF45:
    // POPF  (1000_CF45 / 0x1CF45)
    FlagRegister = Stack.Pop();
    // POP word ptr [0xdbda] (1000_CF46 / 0x1CF46)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_CF4A / 0x1CF4A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CF4B_01CF4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF4B_1CF4B:
    // MOV AX,SI (1000_CF4B / 0x1CF4B)
    AX = SI;
    // MOV [0x3622],AX (1000_CF4D / 0x1CF4D)
    UInt16[DS, 0x3622] = AX;
    // SUB AX,0x35a8 (1000_CF50 / 0x1CF50)
    AX -= 0x35A8;
    // SHR AX,1 (1000_CF53 / 0x1CF53)
    AX >>= 0x1;
    // SHR AX,1 (1000_CF55 / 0x1CF55)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // JNC 0x1000:cf61 (1000_CF57 / 0x1CF57)
    if(!CarryFlag) {
      goto label_1000_CF61_1CF61;
    }
    // MOV BX,0xbe (1000_CF59 / 0x1CF59)
    BX = 0xBE;
    // XOR DX,DX (1000_CF5C / 0x1CF5C)
    DX = 0;
    // JMP 0x1000:c22f (1000_CF5E / 0x1CF5E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C22F_01C22F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_CF61_1CF61:
    // MOV DI,0xed80 (1000_CF61 / 0x1CF61)
    DI = 0xED80;
    // MOV ES,word ptr [0xdbd8] (1000_CF64 / 0x1CF64)
    ES = UInt16[DS, 0xDBD8];
    // XOR AX,AX (1000_CF68 / 0x1CF68)
    AX = 0;
    // MOV CX,0xb40 (1000_CF6A / 0x1CF6A)
    CX = 0xB40;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_CF6D / 0x1CF6D)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // RET  (1000_CF6F / 0x1CF6F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CF70_01CF70(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF70_1CF70:
    // PUSH BX (1000_CF70 / 0x1CF70)
    Stack.Push(BX);
    // DEC SI (1000_CF71 / 0x1CF71)
    SI--;
    // TEST SI,0x800 (1000_CF72 / 0x1CF72)
    Alu.And16(SI, 0x800);
    // JZ 0x1000:cf95 (1000_CF76 / 0x1CF76)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_CF95_01CF95, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:d00f (1000_CF78 / 0x1CF78)
    NearCall(cs1, 0xCF7B, spice86_generated_label_call_target_1000_D00F_01D00F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CF7B_01CF7B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CF7B_01CF7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF7B_1CF7B:
    // LES BX,[0x47b0] (1000_CF7B / 0x1CF7B)
    ES = UInt16[DS, 0x47B2];
    BX = UInt16[DS, 0x47B0];
    // AND SI,0x7ff (1000_CF7F / 0x1CF7F)
    SI &= 0x7FF;
    // SHL SI,1 (1000_CF83 / 0x1CF83)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV SI,word ptr ES:[BX + SI] (1000_CF85 / 0x1CF85)
    SI = UInt16[ES, (ushort)(BX + SI)];
    // MOV BX,word ptr ES:[BX] (1000_CF88 / 0x1CF88)
    BX = UInt16[ES, BX];
    // MOV BX,word ptr ES:[BX + -0x2] (1000_CF8B / 0x1CF8B)
    BX = UInt16[ES, (ushort)(BX - 0x2)];
    // MOV word ptr [0x47b4],BX (1000_CF8F / 0x1CF8F)
    UInt16[DS, 0x47B4] = BX;
    // POP BX (1000_CF93 / 0x1CF93)
    BX = Stack.Pop();
    // RET  (1000_CF94 / 0x1CF94)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_CF95_01CF95(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CF95_1CF95:
    // SHL SI,1 (1000_CF95 / 0x1CF95)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // LES BX,[0x47ac] (1000_CF97 / 0x1CF97)
    ES = UInt16[DS, 0x47AE];
    BX = UInt16[DS, 0x47AC];
    // MOV SI,word ptr ES:[BX + SI] (1000_CF9B / 0x1CF9B)
    SI = UInt16[ES, (ushort)(BX + SI)];
    // POP BX (1000_CF9E / 0x1CF9E)
    BX = Stack.Pop();
    // RET  (1000_CF9F / 0x1CF9F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CFA0_01CFA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CFA0_1CFA0:
    // CALL 0x1000:ae2f (1000_CFA0 / 0x1CFA0)
    NearCall(cs1, 0xCFA3, spice86_generated_label_call_target_1000_AE2F_01AE2F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CFA3_01CFA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CFA3_01CFA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CFA3_1CFA3:
    // JZ 0x1000:cfb8 (1000_CFA3 / 0x1CFA3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_CFB8 / 0x1CFB8)
      return NearRet();
    }
    // MOV AL,[0xceeb] (1000_CFA5 / 0x1CFA5)
    AL = UInt8[DS, 0xCEEB];
    // OR AL,AL (1000_CFA8 / 0x1CFA8)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:cfb0 (1000_CFAA / 0x1CFAA)
    if(ZeroFlag) {
      goto label_1000_CFB0_1CFB0;
    }
    // CMP AL,0x3 (1000_CFAC / 0x1CFAC)
    Alu.Sub8(AL, 0x3);
    // JNZ 0x1000:cfb8 (1000_CFAE / 0x1CFAE)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_CFB8 / 0x1CFB8)
      return NearRet();
    }
    label_1000_CFB0_1CFB0:
    // MOV AL,0x2 (1000_CFB0 / 0x1CFB0)
    AL = 0x2;
    // MOV [0x28e7],AL (1000_CFB2 / 0x1CFB2)
    UInt8[DS, 0x28E7] = AL;
    // MOV [0x28e8],AL (1000_CFB5 / 0x1CFB5)
    UInt8[DS, 0x28E8] = AL;
    label_1000_CFB8_1CFB8:
    // RET  (1000_CFB8 / 0x1CFB8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CFB9_01CFB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CFB9_1CFB9:
    // XOR BX,BX (1000_CFB9 / 0x1CFB9)
    BX = 0;
    // MOV DI,0xd7f4 (1000_CFBB / 0x1CFBB)
    DI = 0xD7F4;
    // PUSH DS (1000_CFBE / 0x1CFBE)
    Stack.Push(DS);
    // POP ES (1000_CFBF / 0x1CFBF)
    ES = Stack.Pop();
    label_1000_CFC0_1CFC0:
    // MOV SI,word ptr [BX + 0xaa76] (1000_CFC0 / 0x1CFC0)
    SI = UInt16[DS, (ushort)(BX + 0xAA76)];
    // CMP word ptr [SI],-0x1 (1000_CFC4 / 0x1CFC4)
    Alu.Sub16(UInt16[DS, SI], 0xFFFF);
    // JNZ 0x1000:cfce (1000_CFC7 / 0x1CFC7)
    if(!ZeroFlag) {
      goto label_1000_CFCE_1CFCE;
    }
    // ADD BX,0x2 (1000_CFC9 / 0x1CFC9)
    // BX += 0x2;
    BX = Alu.Add16(BX, 0x2);
    // JMP 0x1000:cfc0 (1000_CFCC / 0x1CFCC)
    goto label_1000_CFC0_1CFC0;
    label_1000_CFCE_1CFCE:
    // MOV AX,word ptr [SI + 0x2] (1000_CFCE / 0x1CFCE)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // XCHG AH,AL (1000_CFD1 / 0x1CFD1)
    byte tmp_1000_CFD1 = AH;
    AH = AL;
    AL = tmp_1000_CFD1;
    // AND AX,0x3ff (1000_CFD3 / 0x1CFD3)
    AX &= 0x3FF;
    // DEC AX (1000_CFD6 / 0x1CFD6)
    AX = Alu.Dec16(AX);
    // STOSW ES:DI (1000_CFD7 / 0x1CFD7)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // AND BX,0xfff0 (1000_CFD8 / 0x1CFD8)
    BX &= 0xFFF0;
    // ADD BX,0x10 (1000_CFDB / 0x1CFDB)
    BX += 0x10;
    // CMP BX,0x110 (1000_CFDE / 0x1CFDE)
    Alu.Sub16(BX, 0x110);
    // JC 0x1000:cfc0 (1000_CFE2 / 0x1CFE2)
    if(CarryFlag) {
      goto label_1000_CFC0_1CFC0;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CFE4_01CFE4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_CFE4_01CFE4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CFE4_1CFE4:
    // MOV AL,[0xceeb] (1000_CFE4 / 0x1CFE4)
    AL = UInt8[DS, 0xCEEB];
    // MOV SI,0xbb (1000_CFE7 / 0x1CFE7)
    SI = 0xBB;
    // CMP AL,0x6 (1000_CFEA / 0x1CFEA)
    Alu.Sub8(AL, 0x6);
    // JNZ 0x1000:cff1 (1000_CFEC / 0x1CFEC)
    if(!ZeroFlag) {
      goto label_1000_CFF1_1CFF1;
    }
    // MOV SI,0xc7 (1000_CFEE / 0x1CFEE)
    SI = 0xC7;
    label_1000_CFF1_1CFF1:
    // MOV DI,0xceec (1000_CFF1 / 0x1CFF1)
    DI = 0xCEEC;
    // PUSH DS (1000_CFF4 / 0x1CFF4)
    Stack.Push(DS);
    // POP ES (1000_CFF5 / 0x1CFF5)
    ES = Stack.Pop();
    // CALL 0x1000:f0b9 (1000_CFF6 / 0x1CFF6)
    NearCall(cs1, 0xCFF9, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_CFF9_01CFF9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_CFF9_01CFF9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CFF9_1CFF9:
    // MOV AL,0xc0 (1000_CFF9 / 0x1CFF9)
    AL = 0xC0;
    // ADD AL,byte ptr [0xceeb] (1000_CFFB / 0x1CFFB)
    AL += UInt8[DS, 0xCEEB];
    // XOR AH,AH (1000_CFFF / 0x1CFFF)
    AH = 0;
    // MOV SI,AX (1000_D001 / 0x1D001)
    SI = AX;
    // LES DI,[0x47ac] (1000_D003 / 0x1D003)
    ES = UInt16[DS, 0x47AE];
    DI = UInt16[DS, 0x47AC];
    // CALL 0x1000:f0b9 (1000_D007 / 0x1D007)
    NearCall(cs1, 0xD00A, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_D00A_1D00A:
    // CALL 0x1000:0098 (1000_D00A / 0x1D00A)
    NearCall(cs1, 0xD00D, spice86_generated_label_call_target_1000_0098_010098);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D00D_01D00D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D00D_01D00D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D00D_1D00D:
    // JMP 0x1000:d01a (1000_D00D / 0x1D00D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D00F_01D00F, 0x1D01A - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D00F_01D00F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD01A: goto label_1000_D01A_1D01A;break; // Target of external jump from 0x1D00D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D00F_1D00F:
    // MOV AX,[0x477c] (1000_D00F / 0x1D00F)
    AX = UInt16[DS, 0x477C];
    // CMP AX,word ptr [0xaad6] (1000_D012 / 0x1D012)
    Alu.Sub16(AX, UInt16[DS, 0xAAD6]);
    // MOV AL,0x93 (1000_D016 / 0x1D016)
    AL = 0x93;
    // JC 0x1000:d01c (1000_D018 / 0x1D018)
    if(CarryFlag) {
      goto label_1000_D01C_1D01C;
    }
    label_1000_D01A_1D01A:
    // MOV AL,0x9a (1000_D01A / 0x1D01A)
    AL = 0x9A;
    label_1000_D01C_1D01C:
    // ADD AL,byte ptr [0xceeb] (1000_D01C / 0x1D01C)
    AL += UInt8[DS, 0xCEEB];
    // CMP AL,byte ptr [0x477e] (1000_D020 / 0x1D020)
    Alu.Sub8(AL, UInt8[DS, 0x477E]);
    // JZ 0x1000:d03b (1000_D024 / 0x1D024)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D03B / 0x1D03B)
      return NearRet();
    }
    // PUSH SI (1000_D026 / 0x1D026)
    Stack.Push(SI);
    // MOV [0x477e],AL (1000_D027 / 0x1D027)
    UInt8[DS, 0x477E] = AL;
    // XOR AH,AH (1000_D02A / 0x1D02A)
    AH = 0;
    // MOV SI,AX (1000_D02C / 0x1D02C)
    SI = AX;
    // LES DI,[0x47b0] (1000_D02E / 0x1D02E)
    ES = UInt16[DS, 0x47B2];
    DI = UInt16[DS, 0x47B0];
    // CALL 0x1000:f0b9 (1000_D032 / 0x1D032)
    NearCall(cs1, 0xD035, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_D035_1D035:
    // PUSH CX (1000_D035 / 0x1D035)
    Stack.Push(CX);
    // CALL 0x1000:0098 (1000_D036 / 0x1D036)
    NearCall(cs1, 0xD039, spice86_generated_label_call_target_1000_0098_010098);
    label_1000_D039_1D039:
    // POP CX (1000_D039 / 0x1D039)
    CX = Stack.Pop();
    // POP SI (1000_D03A / 0x1D03A)
    SI = Stack.Pop();
    label_1000_D03B_1D03B:
    // RET  (1000_D03B / 0x1D03B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D03C_01D03C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D03C_1D03C:
    // LODSB ES:SI (1000_D03C / 0x1D03C)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // SUB AL,0x30 (1000_D03E / 0x1D03E)
    AL -= 0x30;
    // CMP AL,0x9 (1000_D040 / 0x1D040)
    Alu.Sub8(AL, 0x9);
    // JA 0x1000:d03c (1000_D042 / 0x1D042)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_D03C_1D03C;
    }
    label_1000_D044_1D044:
    // LODSB ES:SI (1000_D044 / 0x1D044)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // SUB AL,0x30 (1000_D046 / 0x1D046)
    AL -= 0x30;
    // CMP AL,0x9 (1000_D048 / 0x1D048)
    Alu.Sub8(AL, 0x9);
    // JBE 0x1000:d044 (1000_D04A / 0x1D04A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D044_1D044;
    }
    // DEC SI (1000_D04C / 0x1D04C)
    SI = Alu.Dec16(SI);
    // RET  (1000_D04D / 0x1D04D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D04E_01D04E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D04E_1D04E:
    // MOV word ptr [0xd82c],DX (1000_D04E / 0x1D04E)
    UInt16[DS, 0xD82C] = DX;
    // MOV word ptr [0xd82e],BX (1000_D052 / 0x1D052)
    UInt16[DS, 0xD82E] = BX;
    // MOV word ptr [0xd830],DX (1000_D056 / 0x1D056)
    UInt16[DS, 0xD830] = DX;
    // MOV word ptr [0xd832],BX (1000_D05A / 0x1D05A)
    UInt16[DS, 0xD832] = BX;
    // RET  (1000_D05E / 0x1D05E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D05F_01D05F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D05F_1D05F:
    // MOV DX,word ptr [0xd82c] (1000_D05F / 0x1D05F)
    DX = UInt16[DS, 0xD82C];
    // MOV BX,word ptr [0xd82e] (1000_D063 / 0x1D063)
    BX = UInt16[DS, 0xD82E];
    // RET  (1000_D067 / 0x1D067)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D068_01D068(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D068_1D068:
    // MOV word ptr [0x2518],0xd096 (1000_D068 / 0x1D068)
    UInt16[DS, 0x2518] = 0xD096;
    // MOV word ptr [0x47a0],0xceec (1000_D06E / 0x1D06E)
    UInt16[DS, 0x47A0] = 0xCEEC;
    // RET  (1000_D074 / 0x1D074)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D075_01D075(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D075_1D075:
    // MOV word ptr [0x2518],0xd12f (1000_D075 / 0x1D075)
    UInt16[DS, 0x2518] = 0xD12F;
    // MOV word ptr [0x47a0],0xcf6c (1000_D07B / 0x1D07B)
    UInt16[DS, 0x47A0] = 0xCF6C;
    // RET  (1000_D081 / 0x1D081)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D082_01D082(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D082_1D082:
    // MOV word ptr [0x2518],0xd0ff (1000_D082 / 0x1D082)
    UInt16[DS, 0x2518] = 0xD0FF;
    // MOV word ptr [0x47a0],0xceec (1000_D088 / 0x1D088)
    UInt16[DS, 0x47A0] = 0xCEEC;
    // RET  (1000_D08E / 0x1D08E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D096_01D096(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D096_1D096:
    // PUSH AX (1000_D096 / 0x1D096)
    Stack.Push(AX);
    // PUSH BX (1000_D097 / 0x1D097)
    Stack.Push(BX);
    // PUSH CX (1000_D098 / 0x1D098)
    Stack.Push(CX);
    // PUSH DX (1000_D099 / 0x1D099)
    Stack.Push(DX);
    // PUSH SI (1000_D09A / 0x1D09A)
    Stack.Push(SI);
    // PUSH DI (1000_D09B / 0x1D09B)
    Stack.Push(DI);
    // PUSH BP (1000_D09C / 0x1D09C)
    Stack.Push(BP);
    // PUSH ES (1000_D09D / 0x1D09D)
    Stack.Push(ES);
    // XOR AH,AH (1000_D09E / 0x1D09E)
    AH = 0;
    // MOV SI,AX (1000_D0A0 / 0x1D0A0)
    SI = AX;
    // SHL SI,1 (1000_D0A2 / 0x1D0A2)
    SI <<= 0x1;
    // SHL SI,1 (1000_D0A4 / 0x1D0A4)
    SI <<= 0x1;
    // SHL SI,1 (1000_D0A6 / 0x1D0A6)
    SI <<= 0x1;
    // ADD SI,AX (1000_D0A8 / 0x1D0A8)
    SI += AX;
    // ADD SI,word ptr [0x2514] (1000_D0AA / 0x1D0AA)
    // SI += UInt16[DS, 0x2514];
    SI = Alu.Add16(SI, UInt16[DS, 0x2514]);
    // MOV BX,0xceec (1000_D0AE / 0x1D0AE)
    BX = 0xCEEC;
    // XLAT BX (1000_D0B1 / 0x1D0B1)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // CALL 0x1000:d05f (1000_D0B2 / 0x1D0B2)
    NearCall(cs1, 0xD0B5, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D0B5_01D0B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D0B5_01D0B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D0B5_1D0B5:
    // ADD word ptr [0xd82c],AX (1000_D0B5 / 0x1D0B5)
    // UInt16[DS, 0xD82C] += AX;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], AX);
    // MOV CL,AL (1000_D0B9 / 0x1D0B9)
    CL = AL;
    // MOV CH,0x9 (1000_D0BB / 0x1D0BB)
    CH = 0x9;
    // MOV AX,[0xdbe4] (1000_D0BD / 0x1D0BD)
    AX = UInt16[DS, 0xDBE4];
    // MOV ES,word ptr [0xdbda] (1000_D0C0 / 0x1D0C0)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38d1] (1000_D0C4 / 0x1D0C4)
    // Indirect call to [0x38d1], generating possible targets from emulator records
    uint targetAddress_1000_D0C4 = (uint)(UInt16[DS, 0x38D3] * 0x10 + UInt16[DS, 0x38D1] - cs1 * 0x10);
    switch(targetAddress_1000_D0C4) {
      case 0x235C5 : FarCall(cs1, 0xD0C8, spice86_generated_label_call_target_334B_0115_0335C5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D0C4));
        break;
    }
    label_1000_D0C8_1D0C8:
    // POP ES (1000_D0C8 / 0x1D0C8)
    ES = Stack.Pop();
    // POP BP (1000_D0C9 / 0x1D0C9)
    BP = Stack.Pop();
    // POP DI (1000_D0CA / 0x1D0CA)
    DI = Stack.Pop();
    // POP SI (1000_D0CB / 0x1D0CB)
    SI = Stack.Pop();
    // POP DX (1000_D0CC / 0x1D0CC)
    DX = Stack.Pop();
    // POP CX (1000_D0CD / 0x1D0CD)
    CX = Stack.Pop();
    // POP BX (1000_D0CE / 0x1D0CE)
    BX = Stack.Pop();
    // POP AX (1000_D0CF / 0x1D0CF)
    AX = Stack.Pop();
    // RET  (1000_D0D0 / 0x1D0D0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D0E3_01D0E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D0E3_1D0E3:
    // PUSH CX (1000_D0E3 / 0x1D0E3)
    Stack.Push(CX);
    // PUSH DI (1000_D0E4 / 0x1D0E4)
    Stack.Push(DI);
    // PUSH ES (1000_D0E5 / 0x1D0E5)
    Stack.Push(ES);
    // PUSH CS (1000_D0E6 / 0x1D0E6)
    Stack.Push(cs1);
    // POP ES (1000_D0E7 / 0x1D0E7)
    ES = Stack.Pop();
    // MOV DI,0xd0d1 (1000_D0E8 / 0x1D0E8)
    DI = 0xD0D1;
    // MOV CX,0x9 (1000_D0EB / 0x1D0EB)
    CX = 0x9;
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_D0EE / 0x1D0EE)
      Alu.Sub8(AL, UInt8[ES, DI]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    // POP ES (1000_D0F0 / 0x1D0F0)
    ES = Stack.Pop();
    // STC  (1000_D0F1 / 0x1D0F1)
    CarryFlag = true;
    // JNZ 0x1000:d0fc (1000_D0F2 / 0x1D0F2)
    if(!ZeroFlag) {
      goto label_1000_D0FC_1D0FC;
    }
    // MOV AL,byte ptr CS:[DI + 0x8] (1000_D0F4 / 0x1D0F4)
    AL = UInt8[cs1, (ushort)(DI + 0x8)];
    // MOV AH,0xd (1000_D0F8 / 0x1D0F8)
    AH = 0xD;
    // SUB AH,CL (1000_D0FA / 0x1D0FA)
    // AH -= CL;
    AH = Alu.Sub8(AH, CL);
    label_1000_D0FC_1D0FC:
    // POP DI (1000_D0FC / 0x1D0FC)
    DI = Stack.Pop();
    // POP CX (1000_D0FD / 0x1D0FD)
    CX = Stack.Pop();
    // RET  (1000_D0FE / 0x1D0FE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D0FF_01D0FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D0FF_1D0FF:
    // CALL 0x1000:d068 (1000_D0FF / 0x1D0FF)
    NearCall(cs1, 0xD102, spice86_generated_label_call_target_1000_D068_01D068);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D102_01D102, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D102_01D102(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D102_1D102:
    // CALL 0x1000:d0e3 (1000_D102 / 0x1D102)
    NearCall(cs1, 0xD105, spice86_generated_label_call_target_1000_D0E3_01D0E3);
    label_1000_D105_1D105:
    // JC 0x1000:d096 (1000_D105 / 0x1D105)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D096_01D096, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:e270 (1000_D107 / 0x1D107)
    NearCall(cs1, 0xD10A, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_D10A_1D10A:
    // PUSH ES (1000_D10A / 0x1D10A)
    Stack.Push(ES);
    // PUSH AX (1000_D10B / 0x1D10B)
    Stack.Push(AX);
    // MOV AX,0x32 (1000_D10C / 0x1D10C)
    AX = 0x32;
    // CALL 0x1000:c13e (1000_D10F / 0x1D10F)
    NearCall(cs1, 0xD112, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_D112_1D112:
    // CALL 0x1000:d05f (1000_D112 / 0x1D112)
    NearCall(cs1, 0xD115, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D115_01D115, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D115_01D115(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D115_1D115:
    // POP AX (1000_D115 / 0x1D115)
    AX = Stack.Pop();
    // MOV CL,AH (1000_D116 / 0x1D116)
    CL = AH;
    // XOR AH,AH (1000_D118 / 0x1D118)
    AH = 0;
    // ADD word ptr [0xd82c],AX (1000_D11A / 0x1D11A)
    // UInt16[DS, 0xD82C] += AX;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], AX);
    // MOV AL,CL (1000_D11E / 0x1D11E)
    AL = CL;
    // SUB BX,0x13 (1000_D120 / 0x1D120)
    // BX -= 0x13;
    BX = Alu.Sub16(BX, 0x13);
    // JNC 0x1000:d127 (1000_D123 / 0x1D123)
    if(!CarryFlag) {
      goto label_1000_D127_1D127;
    }
    // XOR BX,BX (1000_D125 / 0x1D125)
    BX = 0;
    label_1000_D127_1D127:
    // CALL 0x1000:c22f (1000_D127 / 0x1D127)
    NearCall(cs1, 0xD12A, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_D12A_1D12A:
    // POP ES (1000_D12A / 0x1D12A)
    ES = Stack.Pop();
    // CALL 0x1000:e283 (1000_D12B / 0x1D12B)
    NearCall(cs1, 0xD12E, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_D12E_1D12E:
    // RET  (1000_D12E / 0x1D12E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D12F_01D12F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D12F_1D12F:
    // PUSH AX (1000_D12F / 0x1D12F)
    Stack.Push(AX);
    // PUSH BX (1000_D130 / 0x1D130)
    Stack.Push(BX);
    // PUSH CX (1000_D131 / 0x1D131)
    Stack.Push(CX);
    // PUSH DX (1000_D132 / 0x1D132)
    Stack.Push(DX);
    // PUSH SI (1000_D133 / 0x1D133)
    Stack.Push(SI);
    // PUSH DI (1000_D134 / 0x1D134)
    Stack.Push(DI);
    // PUSH BP (1000_D135 / 0x1D135)
    Stack.Push(BP);
    // PUSH ES (1000_D136 / 0x1D136)
    Stack.Push(ES);
    // XOR AH,AH (1000_D137 / 0x1D137)
    AH = 0;
    // MOV SI,AX (1000_D139 / 0x1D139)
    SI = AX;
    // SHL SI,1 (1000_D13B / 0x1D13B)
    SI <<= 0x1;
    // SHL SI,1 (1000_D13D / 0x1D13D)
    SI <<= 0x1;
    // SHL SI,1 (1000_D13F / 0x1D13F)
    SI <<= 0x1;
    // SUB SI,AX (1000_D141 / 0x1D141)
    SI -= AX;
    // ADD SI,word ptr [0x2516] (1000_D143 / 0x1D143)
    // SI += UInt16[DS, 0x2516];
    SI = Alu.Add16(SI, UInt16[DS, 0x2516]);
    // MOV BX,0xcf6c (1000_D147 / 0x1D147)
    BX = 0xCF6C;
    // XLAT BX (1000_D14A / 0x1D14A)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // CALL 0x1000:d05f (1000_D14B / 0x1D14B)
    NearCall(cs1, 0xD14E, spice86_generated_label_call_target_1000_D05F_01D05F);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D14E_01D14E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D14E_01D14E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D14E_1D14E:
    // ADD word ptr [0xd82c],AX (1000_D14E / 0x1D14E)
    // UInt16[DS, 0xD82C] += AX;
    UInt16[DS, 0xD82C] = Alu.Add16(UInt16[DS, 0xD82C], AX);
    // MOV CL,AL (1000_D152 / 0x1D152)
    CL = AL;
    // MOV CH,0x7 (1000_D154 / 0x1D154)
    CH = 0x7;
    // MOV AX,[0xdbe4] (1000_D156 / 0x1D156)
    AX = UInt16[DS, 0xDBE4];
    // MOV ES,word ptr [0xdbda] (1000_D159 / 0x1D159)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38d1] (1000_D15D / 0x1D15D)
    // Indirect call to [0x38d1], generating possible targets from emulator records
    uint targetAddress_1000_D15D = (uint)(UInt16[DS, 0x38D3] * 0x10 + UInt16[DS, 0x38D1] - cs1 * 0x10);
    switch(targetAddress_1000_D15D) {
      case 0x235C5 : FarCall(cs1, 0xD161, spice86_generated_label_call_target_334B_0115_0335C5); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D15D));
        break;
    }
    label_1000_D161_1D161:
    // POP ES (1000_D161 / 0x1D161)
    ES = Stack.Pop();
    // POP BP (1000_D162 / 0x1D162)
    BP = Stack.Pop();
    // POP DI (1000_D163 / 0x1D163)
    DI = Stack.Pop();
    // POP SI (1000_D164 / 0x1D164)
    SI = Stack.Pop();
    // POP DX (1000_D165 / 0x1D165)
    DX = Stack.Pop();
    // POP CX (1000_D166 / 0x1D166)
    CX = Stack.Pop();
    // POP BX (1000_D167 / 0x1D167)
    BX = Stack.Pop();
    // POP AX (1000_D168 / 0x1D168)
    AX = Stack.Pop();
    // RET  (1000_D169 / 0x1D169)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D194_01D194(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D194_1D194:
    // MOV word ptr [0xdbe4],CX (1000_D194 / 0x1D194)
    UInt16[DS, 0xDBE4] = CX;
    // CALL 0x1000:d04e (1000_D198 / 0x1D198)
    NearCall(cs1, 0xD19B, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D19B_01D19B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D19B_01D19B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD1A5: goto label_1000_D1A5_1D1A5;break; // Target of external jump from 0x1D1AA, 0x1D1BF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D19B_1D19B:
    // PUSH SI (1000_D19B / 0x1D19B)
    Stack.Push(SI);
    // MOV SI,AX (1000_D19C / 0x1D19C)
    SI = AX;
    // CALL 0x1000:cf70 (1000_D19E / 0x1D19E)
    NearCall(cs1, 0xD1A1, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_D1A1_1D1A1:
    // CALL 0x1000:d1bb (1000_D1A1 / 0x1D1A1)
    NearCall(cs1, 0xD1A4, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    label_1000_D1A4_1D1A4:
    // POP SI (1000_D1A4 / 0x1D1A4)
    SI = Stack.Pop();
    label_1000_D1A5_1D1A5:
    // RET  (1000_D1A5 / 0x1D1A5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1A6_01D1A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1A6_1D1A6:
    // LODSW SI (1000_D1A6 / 0x1D1A6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_D1A7 / 0x1D1A7)
    CX = AX;
    // INC AX (1000_D1A9 / 0x1D1A9)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:d1a5 (1000_D1AA / 0x1D1AA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D1A5 / 0x1D1A5)
      return NearRet();
    }
    // LODSW SI (1000_D1AC / 0x1D1AC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_D1AD / 0x1D1AD)
    DX = AX;
    // LODSW SI (1000_D1AF / 0x1D1AF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_D1B0 / 0x1D1B0)
    BX = AX;
    // LODSW SI (1000_D1B2 / 0x1D1B2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,CX (1000_D1B3 / 0x1D1B3)
    ushort tmp_1000_D1B3 = AX;
    AX = CX;
    CX = tmp_1000_D1B3;
    // PUSH SI (1000_D1B4 / 0x1D1B4)
    Stack.Push(SI);
    // CALL 0x1000:d194 (1000_D1B5 / 0x1D1B5)
    NearCall(cs1, 0xD1B8, spice86_generated_label_call_target_1000_D194_01D194);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D1B8_01D1B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_D1B8_01D1B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1B8_1D1B8:
    // POP SI (1000_D1B8 / 0x1D1B8)
    SI = Stack.Pop();
    // JMP 0x1000:d1a6 (1000_D1B9 / 0x1D1B9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1A6_01D1A6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_D1BB_01D1BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1BB_1D1BB:
    // LODSB ES:SI (1000_D1BB / 0x1D1BB)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_D1BD / 0x1D1BD)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:d1a5 (1000_D1BF / 0x1D1BF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D1A5 / 0x1D1A5)
      return NearRet();
    }
    // CMP AL,0xd (1000_D1C1 / 0x1D1C1)
    Alu.Sub8(AL, 0xD);
    // JZ 0x1000:d1d1 (1000_D1C3 / 0x1D1C3)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D1D1_01D1D1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // OR AL,AL (1000_D1C5 / 0x1D1C5)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNS 0x1000:d1cb (1000_D1C7 / 0x1D1C7)
    if(!SignFlag) {
      goto label_1000_D1CB_1D1CB;
    }
    // MOV AL,0x40 (1000_D1C9 / 0x1D1C9)
    AL = 0x40;
    label_1000_D1CB_1D1CB:
    // CALL word ptr [0x2518] (1000_D1CB / 0x1D1CB)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_D1CB = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_D1CB) {
      case 0xD12F : NearCall(cs1, 0xD1CF, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      case 0xD096 : NearCall(cs1, 0xD1CF, spice86_generated_label_call_target_1000_D096_01D096); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D1CB));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D1CF_01D1CF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
