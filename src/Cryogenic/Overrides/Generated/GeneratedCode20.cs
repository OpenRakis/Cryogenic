namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action not_observed_1000_E0A2_01E0A2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E0A2_1E0A2:
    // CMP byte ptr [0x46eb],0x0 (1000_E0A2 / 0x1E0A2)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JNS 0x1000:e0da (1000_E0A7 / 0x1E0A7)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x3cbe (1000_E0A9 / 0x1E0A9)
    DI = 0x3CBE;
    State.IncCycles();
    // MOV CX,word ptr [DI] (1000_E0AC / 0x1E0AC)
    CX = UInt16[DS, DI];
    State.IncCycles();
    // JCXZ 0x1000:e0da (1000_E0AE / 0x1E0AE)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    State.IncCycles();
    // ADD DI,0x2 (1000_E0B0 / 0x1E0B0)
    DI += 0x2;
    State.IncCycles();
    label_1000_E0B3_1E0B3:
    // TEST byte ptr [DI + 0xc],0xc0 (1000_E0B3 / 0x1E0B3)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xC)], 0xC0);
    State.IncCycles();
    // JNZ 0x1000:e0d5 (1000_E0B7 / 0x1E0B7)
    if(!ZeroFlag) {
      goto label_1000_E0D5_1E0D5;
    }
    State.IncCycles();
    // CALL 0x1000:d6fe (1000_E0B9 / 0x1E0B9)
    NearCall(cs1, 0xE0BC, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    State.IncCycles();
    // JC 0x1000:e0d5 (1000_E0BC / 0x1E0BC)
    if(CarryFlag) {
      goto label_1000_E0D5_1E0D5;
    }
    State.IncCycles();
    // CALL 0x1000:e159 (1000_E0BE / 0x1E0BE)
    NearCall(cs1, 0xE0C1, not_observed_1000_E159_01E159);
    State.IncCycles();
    // CALL word ptr [BP + 0x0] (1000_E0C1 / 0x1E0C1)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E0C1 = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E0C1) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E0C1));
        break;
    }
    State.IncCycles();
    // CMP AX,word ptr [BP + 0x2] (1000_E0C4 / 0x1E0C4)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:e0d5 (1000_E0C7 / 0x1E0C7)
    if(!CarryFlag) {
      goto label_1000_E0D5_1E0D5;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_E0C9 / 0x1E0C9)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // CALL 0x1000:e159 (1000_E0CC / 0x1E0CC)
    NearCall(cs1, 0xE0CF, not_observed_1000_E159_01E159);
    State.IncCycles();
    // MOV word ptr [BP + 0x4],AX (1000_E0CF / 0x1E0CF)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0x6],SI (1000_E0D2 / 0x1E0D2)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    State.IncCycles();
    label_1000_E0D5_1E0D5:
    // ADD DI,0x11 (1000_E0D5 / 0x1E0D5)
    // DI += 0x11;
    DI = Alu.Add16(DI, 0x11);
    State.IncCycles();
    // LOOP 0x1000:e0b3 (1000_E0D8 / 0x1E0D8)
    if(--CX != 0) {
      goto label_1000_E0B3_1E0B3;
    }
    State.IncCycles();
    label_1000_E0DA_1E0DA:
    // RET  (1000_E0DA / 0x1E0DA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E0DB_01E0DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E0DB_1E0DB:
    // CMP byte ptr [0x46eb],0x0 (1000_E0DB / 0x1E0DB)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    State.IncCycles();
    // JZ 0x1000:e0da (1000_E0E0 / 0x1E0E0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0xa5c0 (1000_E0E2 / 0x1E0E2)
    DI = 0xA5C0;
    State.IncCycles();
    label_1000_E0E5_1E0E5:
    // CMP word ptr [DI],0x0 (1000_E0E5 / 0x1E0E5)
    Alu.Sub16(UInt16[DS, DI], 0x0);
    State.IncCycles();
    // JZ 0x1000:e0da (1000_E0E8 / 0x1E0E8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,word ptr [DI + 0x4] (1000_E0EA / 0x1E0EA)
    SI = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // AND SI,0xff (1000_E0ED / 0x1E0ED)
    // SI &= 0xFF;
    SI = Alu.And16(SI, 0xFF);
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x2] (1000_E0F1 / 0x1E0F1)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // CMP AX,DX (1000_E0F4 / 0x1E0F4)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JNZ 0x1000:e0fc (1000_E0F6 / 0x1E0F6)
    if(!ZeroFlag) {
      goto label_1000_E0FC_1E0FC;
    }
    State.IncCycles();
    // CMP SI,BX (1000_E0F8 / 0x1E0F8)
    Alu.Sub16(SI, BX);
    State.IncCycles();
    // JZ 0x1000:e117 (1000_E0FA / 0x1E0FA)
    if(ZeroFlag) {
      goto label_1000_E117_1E117;
    }
    State.IncCycles();
    label_1000_E0FC_1E0FC:
    // CALL word ptr [BP + 0x0] (1000_E0FC / 0x1E0FC)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E0FC = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E0FC) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E0FC));
        break;
    }
    State.IncCycles();
    // CMP AX,word ptr [BP + 0x2] (1000_E0FF / 0x1E0FF)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:e117 (1000_E102 / 0x1E102)
    if(!CarryFlag) {
      goto label_1000_E117_1E117;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_E104 / 0x1E104)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // MOV AX,word ptr [DI + 0x2] (1000_E107 / 0x1E107)
    AX = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV word ptr [BP + 0x4],AX (1000_E10A / 0x1E10A)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    State.IncCycles();
    // MOV SI,word ptr [DI + 0x4] (1000_E10D / 0x1E10D)
    SI = UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // AND SI,0xff (1000_E110 / 0x1E110)
    // SI &= 0xFF;
    SI = Alu.And16(SI, 0xFF);
    State.IncCycles();
    // MOV word ptr [BP + 0x6],SI (1000_E114 / 0x1E114)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    State.IncCycles();
    label_1000_E117_1E117:
    // ADD DI,0x6 (1000_E117 / 0x1E117)
    // DI += 0x6;
    DI = Alu.Add16(DI, 0x6);
    State.IncCycles();
    // JMP 0x1000:e0e5 (1000_E11A / 0x1E11A)
    goto label_1000_E0E5_1E0E5;
  }
  
  public virtual Action not_observed_1000_E11C_01E11C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E11C_1E11C:
    // TEST byte ptr [0x46eb],0x1 (1000_E11C / 0x1E11C)
    Alu.And8(UInt8[DS, 0x46EB], 0x1);
    State.IncCycles();
    // JZ 0x1000:e0da (1000_E121 / 0x1E121)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x4749],0x0 (1000_E123 / 0x1E123)
    Alu.Sub16(UInt16[DS, 0x4749], 0x0);
    State.IncCycles();
    // JZ 0x1000:e0da (1000_E128 / 0x1E128)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E0DA / 0x1E0DA)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0x2462 (1000_E12A / 0x1E12A)
    DI = 0x2462;
    State.IncCycles();
    // MOV CX,0x8 (1000_E12D / 0x1E12D)
    CX = 0x8;
    State.IncCycles();
    label_1000_E130_1E130:
    // MOV AX,word ptr [DI] (1000_E130 / 0x1E130)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // MOV SI,word ptr [DI + 0x2] (1000_E132 / 0x1E132)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // CMP AX,DX (1000_E135 / 0x1E135)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JNZ 0x1000:e13d (1000_E137 / 0x1E137)
    if(!ZeroFlag) {
      goto label_1000_E13D_1E13D;
    }
    State.IncCycles();
    // CMP SI,BX (1000_E139 / 0x1E139)
    Alu.Sub16(SI, BX);
    State.IncCycles();
    // JZ 0x1000:e153 (1000_E13B / 0x1E13B)
    if(ZeroFlag) {
      goto label_1000_E153_1E153;
    }
    State.IncCycles();
    label_1000_E13D_1E13D:
    // CALL word ptr [BP + 0x0] (1000_E13D / 0x1E13D)
    // Indirect call to word ptr [BP + 0x0], generating possible targets from emulator records
    uint targetAddress_1000_E13D = (uint)(UInt16[SS, BP]);
    switch(targetAddress_1000_E13D) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E13D));
        break;
    }
    State.IncCycles();
    // CMP AX,word ptr [BP + 0x2] (1000_E140 / 0x1E140)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x2)]);
    State.IncCycles();
    // JNC 0x1000:e153 (1000_E143 / 0x1E143)
    if(!CarryFlag) {
      goto label_1000_E153_1E153;
    }
    State.IncCycles();
    // MOV word ptr [BP + 0x2],AX (1000_E145 / 0x1E145)
    UInt16[SS, (ushort)(BP + 0x2)] = AX;
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_E148 / 0x1E148)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // MOV SI,word ptr [DI + 0x2] (1000_E14A / 0x1E14A)
    SI = UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // MOV word ptr [BP + 0x4],AX (1000_E14D / 0x1E14D)
    UInt16[SS, (ushort)(BP + 0x4)] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0x6],SI (1000_E150 / 0x1E150)
    UInt16[SS, (ushort)(BP + 0x6)] = SI;
    State.IncCycles();
    label_1000_E153_1E153:
    // ADD DI,0x4 (1000_E153 / 0x1E153)
    // DI += 0x4;
    DI = Alu.Add16(DI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:e130 (1000_E156 / 0x1E156)
    if(--CX != 0) {
      goto label_1000_E130_1E130;
    }
    State.IncCycles();
    // RET  (1000_E158 / 0x1E158)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E159_01E159(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E159_1E159:
    // MOV SI,word ptr [DI + 0x6] (1000_E159 / 0x1E159)
    SI = UInt16[DS, (ushort)(DI + 0x6)];
    State.IncCycles();
    // MOV AX,SI (1000_E15C / 0x1E15C)
    AX = SI;
    State.IncCycles();
    // SUB AX,word ptr [DI + 0x2] (1000_E15E / 0x1E15E)
    AX -= UInt16[DS, (ushort)(DI + 0x2)];
    State.IncCycles();
    // SHR AX,1 (1000_E161 / 0x1E161)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_E163 / 0x1E163)
    AX >>= 0x1;
    State.IncCycles();
    // SUB SI,AX (1000_E165 / 0x1E165)
    // SI -= AX;
    SI = Alu.Sub16(SI, AX);
    State.IncCycles();
    // MOV AX,word ptr [DI] (1000_E167 / 0x1E167)
    AX = UInt16[DS, DI];
    State.IncCycles();
    // ADD AX,word ptr [DI + 0x4] (1000_E169 / 0x1E169)
    AX += UInt16[DS, (ushort)(DI + 0x4)];
    State.IncCycles();
    // SHR AX,1 (1000_E16C / 0x1E16C)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // RET  (1000_E16E / 0x1E16E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_E1D1_01E1D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E1D1_1E1D1:
    // OR DL,DL (1000_E1D1 / 0x1E1D1)
    // DL |= DL;
    DL = Alu.Or8(DL, DL);
    State.IncCycles();
    // JZ 0x1000:e1f3 (1000_E1D3 / 0x1E1D3)
    if(ZeroFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    State.IncCycles();
    // MOV AX,[0xdc51] (1000_E1D5 / 0x1E1D5)
    AX = UInt16[DS, 0xDC51];
    State.IncCycles();
    // OR AX,AX (1000_E1D8 / 0x1E1D8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x1000:e1de (1000_E1DA / 0x1E1DA)
    if(!SignFlag) {
      goto label_1000_E1DE_1E1DE;
    }
    State.IncCycles();
    // NEG AX (1000_E1DC / 0x1E1DC)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_E1DE_1E1DE:
    // CMP AX,0x4 (1000_E1DE / 0x1E1DE)
    Alu.Sub16(AX, 0x4);
    State.IncCycles();
    // JC 0x1000:e1f3 (1000_E1E1 / 0x1E1E1)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    State.IncCycles();
    // ADD DL,DL (1000_E1E3 / 0x1E1E3)
    DL += DL;
    State.IncCycles();
    // CMP AX,0xc (1000_E1E5 / 0x1E1E5)
    Alu.Sub16(AX, 0xC);
    State.IncCycles();
    // JC 0x1000:e1f3 (1000_E1E8 / 0x1E1E8)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    State.IncCycles();
    // ADD DL,DL (1000_E1EA / 0x1E1EA)
    DL += DL;
    State.IncCycles();
    // CMP AX,0x24 (1000_E1EC / 0x1E1EC)
    Alu.Sub16(AX, 0x24);
    State.IncCycles();
    // JC 0x1000:e1f3 (1000_E1EF / 0x1E1EF)
    if(CarryFlag) {
      goto label_1000_E1F3_1E1F3;
    }
    State.IncCycles();
    // ADD DL,DL (1000_E1F1 / 0x1E1F1)
    // DL += DL;
    DL = Alu.Add8(DL, DL);
    State.IncCycles();
    label_1000_E1F3_1E1F3:
    // OR BL,BL (1000_E1F3 / 0x1E1F3)
    // BL |= BL;
    BL = Alu.Or8(BL, BL);
    State.IncCycles();
    // JZ 0x1000:e213 (1000_E1F5 / 0x1E1F5)
    if(ZeroFlag) {
      goto label_1000_E213_1E213;
    }
    State.IncCycles();
    // MOV AX,[0xdc53] (1000_E1F7 / 0x1E1F7)
    AX = UInt16[DS, 0xDC53];
    State.IncCycles();
    // JNS 0x1000:e1fe (1000_E1FA / 0x1E1FA)
    if(!SignFlag) {
      goto label_1000_E1FE_1E1FE;
    }
    State.IncCycles();
    // NEG AX (1000_E1FC / 0x1E1FC)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    label_1000_E1FE_1E1FE:
    // CMP AX,0x3 (1000_E1FE / 0x1E1FE)
    Alu.Sub16(AX, 0x3);
    State.IncCycles();
    // JC 0x1000:e213 (1000_E201 / 0x1E201)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    State.IncCycles();
    // ADD BL,BL (1000_E203 / 0x1E203)
    BL += BL;
    State.IncCycles();
    // CMP AX,0xa (1000_E205 / 0x1E205)
    Alu.Sub16(AX, 0xA);
    State.IncCycles();
    // JC 0x1000:e213 (1000_E208 / 0x1E208)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    State.IncCycles();
    // ADD BL,BL (1000_E20A / 0x1E20A)
    BL += BL;
    State.IncCycles();
    // CMP AX,0x1c (1000_E20C / 0x1E20C)
    Alu.Sub16(AX, 0x1C);
    State.IncCycles();
    // JC 0x1000:e213 (1000_E20F / 0x1E20F)
    if(CarryFlag) {
      goto label_1000_E213_1E213;
    }
    State.IncCycles();
    // ADD BL,BL (1000_E211 / 0x1E211)
    // BL += BL;
    BL = Alu.Add8(BL, BL);
    State.IncCycles();
    label_1000_E213_1E213:
    // MOV AL,[0xce7a] (1000_E213 / 0x1E213)
    AL = UInt8[DS, 0xCE7A];
    State.IncCycles();
    // MOV AH,AL (1000_E216 / 0x1E216)
    AH = AL;
    State.IncCycles();
    // XCHG byte ptr [0xdc50],AH (1000_E218 / 0x1E218)
    byte tmp_1000_E218 = UInt8[DS, 0xDC50];
    UInt8[DS, 0xDC50] = AH;
    AH = tmp_1000_E218;
    State.IncCycles();
    // SUB AL,AH (1000_E21C / 0x1E21C)
    AL -= AH;
    State.IncCycles();
    // CMP AL,0x8 (1000_E21E / 0x1E21E)
    Alu.Sub8(AL, 0x8);
    State.IncCycles();
    // JC 0x1000:e224 (1000_E220 / 0x1E220)
    if(CarryFlag) {
      goto label_1000_E224_1E224;
    }
    State.IncCycles();
    // MOV AL,0x8 (1000_E222 / 0x1E222)
    AL = 0x8;
    State.IncCycles();
    label_1000_E224_1E224:
    // MOV CL,AL (1000_E224 / 0x1E224)
    CL = AL;
    State.IncCycles();
    // MOV SI,0xdc55 (1000_E226 / 0x1E226)
    SI = 0xDC55;
    State.IncCycles();
    // MOV AL,DL (1000_E229 / 0x1E229)
    AL = DL;
    State.IncCycles();
    // CALL 0x1000:e243 (1000_E22B / 0x1E22B)
    NearCall(cs1, 0xE22E, not_observed_1000_E243_01E243);
    State.IncCycles();
    // MOV DX,AX (1000_E22E / 0x1E22E)
    DX = AX;
    State.IncCycles();
    // ADD word ptr [0xdc51],AX (1000_E230 / 0x1E230)
    UInt16[DS, 0xDC51] += AX;
    State.IncCycles();
    // INC SI (1000_E234 / 0x1E234)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOV AL,BL (1000_E235 / 0x1E235)
    AL = BL;
    State.IncCycles();
    // CALL 0x1000:e243 (1000_E237 / 0x1E237)
    NearCall(cs1, 0xE23A, not_observed_1000_E243_01E243);
    State.IncCycles();
    // MOV BX,AX (1000_E23A / 0x1E23A)
    BX = AX;
    State.IncCycles();
    // ADD word ptr [0xdc53],AX (1000_E23C / 0x1E23C)
    // UInt16[DS, 0xDC53] += AX;
    UInt16[DS, 0xDC53] = Alu.Add16(UInt16[DS, 0xDC53], AX);
    State.IncCycles();
    // JMP 0x1000:daaf (1000_E240 / 0x1E240)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_DAAF_01DAAF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_E243_01E243(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E243_1E243:
    // IMUL CL (1000_E243 / 0x1E243)
    Cpu.IMul8(CL);
    State.IncCycles();
    // OR AX,AX (1000_E245 / 0x1E245)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x1000:e25a (1000_E247 / 0x1E247)
    if(SignFlag) {
      goto label_1000_E25A_1E25A;
    }
    State.IncCycles();
    // ADD AL,byte ptr [SI] (1000_E249 / 0x1E249)
    // AL += UInt8[DS, SI];
    AL = Alu.Add8(AL, UInt8[DS, SI]);
    State.IncCycles();
    // MOV CH,AL (1000_E24B / 0x1E24B)
    CH = AL;
    State.IncCycles();
    // AND CH,0x7 (1000_E24D / 0x1E24D)
    // CH &= 0x7;
    CH = Alu.And8(CH, 0x7);
    State.IncCycles();
    // MOV byte ptr [SI],CH (1000_E250 / 0x1E250)
    UInt8[DS, SI] = CH;
    State.IncCycles();
    // CBW  (1000_E252 / 0x1E252)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SHR AX,1 (1000_E253 / 0x1E253)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_E255 / 0x1E255)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_E257 / 0x1E257)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // RET  (1000_E259 / 0x1E259)
    return NearRet();
    State.IncCycles();
    label_1000_E25A_1E25A:
    // NEG AX (1000_E25A / 0x1E25A)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // ADD AL,byte ptr [SI] (1000_E25C / 0x1E25C)
    // AL += UInt8[DS, SI];
    AL = Alu.Add8(AL, UInt8[DS, SI]);
    State.IncCycles();
    // MOV CH,AL (1000_E25E / 0x1E25E)
    CH = AL;
    State.IncCycles();
    // AND CH,0x7 (1000_E260 / 0x1E260)
    // CH &= 0x7;
    CH = Alu.And8(CH, 0x7);
    State.IncCycles();
    // MOV byte ptr [SI],CH (1000_E263 / 0x1E263)
    UInt8[DS, SI] = CH;
    State.IncCycles();
    // CBW  (1000_E265 / 0x1E265)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SHR AX,1 (1000_E266 / 0x1E266)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_E268 / 0x1E268)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_E26A / 0x1E26A)
    AX >>= 0x1;
    State.IncCycles();
    // NEG AX (1000_E26C / 0x1E26C)
    AX = Alu.Sub16(0, AX);
    State.IncCycles();
    // RET  (1000_E26E / 0x1E26E)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E26F_01E26F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E26F_1E26F:
    // RET  (1000_E26F / 0x1E26F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E270_01E270(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E270_1E270:
    // PUSH BX (1000_E270 / 0x1E270)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_E271 / 0x1E271)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_E272 / 0x1E272)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_E273 / 0x1E273)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_E274 / 0x1E274)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_E275 / 0x1E275)
    Stack.Push(BP);
    State.IncCycles();
    // MOV BP,SP (1000_E276 / 0x1E276)
    BP = SP;
    State.IncCycles();
    // XCHG word ptr [BP + 0xc],AX (1000_E278 / 0x1E278)
    ushort tmp_1000_E278 = UInt16[SS, (ushort)(BP + 0xC)];
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    AX = tmp_1000_E278;
    State.IncCycles();
    // PUSH AX (1000_E27B / 0x1E27B)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0xc] (1000_E27C / 0x1E27C)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    State.IncCycles();
    // MOV BP,word ptr [BP + 0x0] (1000_E27F / 0x1E27F)
    BP = UInt16[SS, BP];
    State.IncCycles();
    // RET  (1000_E282 / 0x1E282)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E283_01E283(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E283_1E283:
    // POP AX (1000_E283 / 0x1E283)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV BP,SP (1000_E284 / 0x1E284)
    BP = SP;
    State.IncCycles();
    // XCHG word ptr [BP + 0xc],AX (1000_E286 / 0x1E286)
    ushort tmp_1000_E286 = UInt16[SS, (ushort)(BP + 0xC)];
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    AX = tmp_1000_E286;
    State.IncCycles();
    // POP BP (1000_E289 / 0x1E289)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_E28A / 0x1E28A)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_E28B / 0x1E28B)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_E28C / 0x1E28C)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_E28D / 0x1E28D)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_E28E / 0x1E28E)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E28F / 0x1E28F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E290_01E290(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E290_1E290:
    // CALL 0x1000:d04e (1000_E290 / 0x1E290)
    NearCall(cs1, 0xE293, spice86_generated_label_call_target_1000_D04E_01D04E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E293_01E293, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E293_01E293(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E293_1E293:
    // JMP 0x1000:e297 (1000_E293 / 0x1E293)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_E297_01E297, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_E295_01E295(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E295_1E295:
    // XOR AH,AH (1000_E295 / 0x1E295)
    AH = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_E297_01E297, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_E297_01E297(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E297_1E297:
    // PUSH CX (1000_E297 / 0x1E297)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,0x64 (1000_E298 / 0x1E298)
    CX = 0x64;
    State.IncCycles();
    // DIV CL (1000_E29B / 0x1E29B)
    Cpu.Div8(CL);
    State.IncCycles();
    // ADD AL,0x30 (1000_E29D / 0x1E29D)
    AL += 0x30;
    State.IncCycles();
    // CMP AL,0x30 (1000_E29F / 0x1E29F)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:e2a7 (1000_E2A1 / 0x1E2A1)
    if(!ZeroFlag) {
      goto label_1000_E2A7_1E2A7;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_E2A3 / 0x1E2A3)
    AL = 0x20;
    State.IncCycles();
    // DEC CH (1000_E2A5 / 0x1E2A5)
    CH = Alu.Dec8(CH);
    State.IncCycles();
    label_1000_E2A7_1E2A7:
    // CALL word ptr [0x2518] (1000_E2A7 / 0x1E2A7)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2A7 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2A7) {
      case 0xD12F : NearCall(cs1, 0xE2AB, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2A7));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E2AB_01E2AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E2AB_01E2AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E2AB_1E2AB:
    // MOV AL,AH (1000_E2AB / 0x1E2AB)
    AL = AH;
    State.IncCycles();
    // AAM 0xa (1000_E2AD / 0x1E2AD)
    Cpu.Aam(0xA);
    State.IncCycles();
    // XCHG AH,AL (1000_E2AF / 0x1E2AF)
    byte tmp_1000_E2AF = AH;
    AH = AL;
    AL = tmp_1000_E2AF;
    State.IncCycles();
    // ADD AX,0x3030 (1000_E2B1 / 0x1E2B1)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    State.IncCycles();
    // OR CH,CH (1000_E2B4 / 0x1E2B4)
    // CH |= CH;
    CH = Alu.Or8(CH, CH);
    State.IncCycles();
    // JZ 0x1000:e2be (1000_E2B6 / 0x1E2B6)
    if(ZeroFlag) {
      goto label_1000_E2BE_1E2BE;
    }
    State.IncCycles();
    // CMP AL,0x30 (1000_E2B8 / 0x1E2B8)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:e2be (1000_E2BA / 0x1E2BA)
    if(!ZeroFlag) {
      goto label_1000_E2BE_1E2BE;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_E2BC / 0x1E2BC)
    AL = 0x20;
    State.IncCycles();
    label_1000_E2BE_1E2BE:
    // CALL word ptr [0x2518] (1000_E2BE / 0x1E2BE)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2BE = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2BE) {
      case 0xD12F : NearCall(cs1, 0xE2C2, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2BE));
        break;
    }
    State.IncCycles();
    label_1000_E2C2_1E2C2:
    // MOV AL,AH (1000_E2C2 / 0x1E2C2)
    AL = AH;
    State.IncCycles();
    // CALL word ptr [0x2518] (1000_E2C4 / 0x1E2C4)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_E2C4 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_E2C4) {
      case 0xD12F : NearCall(cs1, 0xE2C8, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E2C4));
        break;
    }
    State.IncCycles();
    label_1000_E2C8_1E2C8:
    // POP CX (1000_E2C8 / 0x1E2C8)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E2C9 / 0x1E2C9)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E2DB_01E2DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E2DB_1E2DB:
    // PUSH AX (1000_E2DB / 0x1E2DB)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_E2DC / 0x1E2DC)
    NearCall(cs1, 0xE2DF, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    label_1000_E2DF_1E2DF:
    // CALL 0x1000:d03c (1000_E2DF / 0x1E2DF)
    NearCall(cs1, 0xE2E2, spice86_generated_label_call_target_1000_D03C_01D03C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E2E2_01E2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E2E2_01E2E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E2E2_1E2E2:
    // POP AX (1000_E2E2 / 0x1E2E2)
    AX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E2E3_01E2E3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xE2F6: goto label_1000_E2F6_1E2F6;break; // Target of external jump from 0x1E351
      case 0xE2FE: goto label_1000_E2FE_1E2FE;break; // Target of external jump from 0x1E2F8, 0x1E34E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_E2E3_1E2E3:
    // PUSH BX (1000_E2E3 / 0x1E2E3)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_E2E4 / 0x1E2E4)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,0x64 (1000_E2E5 / 0x1E2E5)
    CX = 0x64;
    State.IncCycles();
    // MOV BX,CX (1000_E2E8 / 0x1E2E8)
    BX = CX;
    State.IncCycles();
    // CMP AX,0x3e8 (1000_E2EA / 0x1E2EA)
    Alu.Sub16(AX, 0x3E8);
    State.IncCycles();
    // JC 0x1000:e2f2 (1000_E2ED / 0x1E2ED)
    if(CarryFlag) {
      goto label_1000_E2F2_1E2F2;
    }
    State.IncCycles();
    // MOV AX,0x3e7 (1000_E2EF / 0x1E2EF)
    AX = 0x3E7;
    State.IncCycles();
    label_1000_E2F2_1E2F2:
    // DIV CL (1000_E2F2 / 0x1E2F2)
    Cpu.Div8(CL);
    State.IncCycles();
    // ADD AL,0x30 (1000_E2F4 / 0x1E2F4)
    AL += 0x30;
    State.IncCycles();
    label_1000_E2F6_1E2F6:
    // CMP AL,0x30 (1000_E2F6 / 0x1E2F6)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:e2fe (1000_E2F8 / 0x1E2F8)
    if(!ZeroFlag) {
      goto label_1000_E2FE_1E2FE;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_E2FA / 0x1E2FA)
    AL = 0x20;
    State.IncCycles();
    // XOR BX,BX (1000_E2FC / 0x1E2FC)
    BX = 0;
    State.IncCycles();
    label_1000_E2FE_1E2FE:
    // MOV byte ptr ES:[SI + -0x3],AL (1000_E2FE / 0x1E2FE)
    UInt8[ES, (ushort)(SI - 0x3)] = AL;
    State.IncCycles();
    // MOV AL,AH (1000_E302 / 0x1E302)
    AL = AH;
    State.IncCycles();
    // AAM 0xa (1000_E304 / 0x1E304)
    Cpu.Aam(0xA);
    State.IncCycles();
    // XCHG AH,AL (1000_E306 / 0x1E306)
    byte tmp_1000_E306 = AH;
    AH = AL;
    AL = tmp_1000_E306;
    State.IncCycles();
    // ADD AX,0x3030 (1000_E308 / 0x1E308)
    // AX += 0x3030;
    AX = Alu.Add16(AX, 0x3030);
    State.IncCycles();
    // OR BX,BX (1000_E30B / 0x1E30B)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNZ 0x1000:e315 (1000_E30D / 0x1E30D)
    if(!ZeroFlag) {
      goto label_1000_E315_1E315;
    }
    State.IncCycles();
    // CMP AL,0x30 (1000_E30F / 0x1E30F)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:e315 (1000_E311 / 0x1E311)
    if(!ZeroFlag) {
      goto label_1000_E315_1E315;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_E313 / 0x1E313)
    AL = 0x20;
    State.IncCycles();
    label_1000_E315_1E315:
    // MOV word ptr ES:[SI + -0x2],AX (1000_E315 / 0x1E315)
    UInt16[ES, (ushort)(SI - 0x2)] = AX;
    State.IncCycles();
    // POP CX (1000_E319 / 0x1E319)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_E31A / 0x1E31A)
    BX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E31B / 0x1E31B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E31C_01E31C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E31C_1E31C:
    // PUSH BX (1000_E31C / 0x1E31C)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_E31D / 0x1E31D)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,0x3e8 (1000_E31E / 0x1E31E)
    CX = 0x3E8;
    State.IncCycles();
    // MOV BX,CX (1000_E321 / 0x1E321)
    BX = CX;
    State.IncCycles();
    // XOR DX,DX (1000_E323 / 0x1E323)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_E325 / 0x1E325)
    Cpu.Div16(CX);
    State.IncCycles();
    // AAM 0xa (1000_E327 / 0x1E327)
    Cpu.Aam(0xA);
    State.IncCycles();
    // XCHG AH,AL (1000_E329 / 0x1E329)
    byte tmp_1000_E329 = AH;
    AH = AL;
    AL = tmp_1000_E329;
    State.IncCycles();
    // ADD AX,0x3030 (1000_E32B / 0x1E32B)
    AX += 0x3030;
    State.IncCycles();
    // CMP AL,0x30 (1000_E32E / 0x1E32E)
    Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JNZ 0x1000:e33d (1000_E330 / 0x1E330)
    if(!ZeroFlag) {
      goto label_1000_E33D_1E33D;
    }
    State.IncCycles();
    // MOV AL,0x20 (1000_E332 / 0x1E332)
    AL = 0x20;
    State.IncCycles();
    // CMP AH,0x30 (1000_E334 / 0x1E334)
    Alu.Sub8(AH, 0x30);
    State.IncCycles();
    // JNZ 0x1000:e33d (1000_E337 / 0x1E337)
    if(!ZeroFlag) {
      goto label_1000_E33D_1E33D;
    }
    State.IncCycles();
    // MOV AH,AL (1000_E339 / 0x1E339)
    AH = AL;
    State.IncCycles();
    // XOR BX,BX (1000_E33B / 0x1E33B)
    BX = 0;
    State.IncCycles();
    label_1000_E33D_1E33D:
    // MOV word ptr ES:[SI + -0x5],AX (1000_E33D / 0x1E33D)
    UInt16[ES, (ushort)(SI - 0x5)] = AX;
    State.IncCycles();
    // MOV AX,DX (1000_E341 / 0x1E341)
    AX = DX;
    State.IncCycles();
    // XOR DX,DX (1000_E343 / 0x1E343)
    DX = 0;
    State.IncCycles();
    // MOV CX,0x64 (1000_E345 / 0x1E345)
    CX = 0x64;
    State.IncCycles();
    // DIV CL (1000_E348 / 0x1E348)
    Cpu.Div8(CL);
    State.IncCycles();
    // ADD AL,0x30 (1000_E34A / 0x1E34A)
    // AL += 0x30;
    AL = Alu.Add8(AL, 0x30);
    State.IncCycles();
    // OR BX,BX (1000_E34C / 0x1E34C)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNZ 0x1000:e2fe (1000_E34E / 0x1E34E)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0x1E2FE - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // INC BX (1000_E350 / 0x1E350)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // JMP 0x1000:e2f6 (1000_E351 / 0x1E351)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E2E3_01E2E3, 0x1E2F6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E353_01E353(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E353_1E353:
    // PUSH AX (1000_E353 / 0x1E353)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH word ptr [0xce7a] (1000_E354 / 0x1E354)
    Stack.Push(UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // CALL BP (1000_E358 / 0x1E358)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_E358 = (uint)(BP);
    switch(targetAddress_1000_E358) {
      case 0x4821 : NearCall(cs1, 0xE35A, spice86_generated_label_call_target_1000_4821_014821); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E358));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E35A_01E35A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E35A_01E35A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E35A_1E35A:
    // POP BX (1000_E35A / 0x1E35A)
    BX = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_E35B / 0x1E35B)
    BP = Stack.Pop();
    State.IncCycles();
    label_1000_E35C_1E35C:
    // CMP byte ptr [0x227d],0x0 (1000_E35C / 0x1E35C)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JZ 0x1000:e378 (1000_E361 / 0x1E361)
    if(ZeroFlag) {
      goto label_1000_E378_1E378;
    }
    State.IncCycles();
    // PUSH BX (1000_E363 / 0x1E363)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH CX (1000_E364 / 0x1E364)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_E365 / 0x1E365)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_E366 / 0x1E366)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_E367 / 0x1E367)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH BP (1000_E368 / 0x1E368)
    Stack.Push(BP);
    State.IncCycles();
    // PUSH ES (1000_E369 / 0x1E369)
    Stack.Push(ES);
    State.IncCycles();
    // CALL 0x1000:dd63 (1000_E36A / 0x1E36A)
    NearCall(cs1, 0xE36D, spice86_generated_label_call_target_1000_DD63_01DD63);
    State.IncCycles();
    // POP ES (1000_E36D / 0x1E36D)
    ES = Stack.Pop();
    State.IncCycles();
    // POP BP (1000_E36E / 0x1E36E)
    BP = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_E36F / 0x1E36F)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_E370 / 0x1E370)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_E371 / 0x1E371)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_E372 / 0x1E372)
    CX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_E373 / 0x1E373)
    BX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:e386 (1000_E374 / 0x1E374)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E386 / 0x1E386)
      return NearRet();
    }
    State.IncCycles();
    // JMP 0x1000:e37b (1000_E376 / 0x1E376)
    goto label_1000_E37B_1E37B;
    State.IncCycles();
    label_1000_E378_1E378:
    // CALL 0x1000:de7b (1000_E378 / 0x1E378)
    NearCall(cs1, 0xE37B, spice86_generated_label_call_target_1000_DE7B_01DE7B);
    State.IncCycles();
    label_1000_E37B_1E37B:
    // MOV AX,[0xce7a] (1000_E37B / 0x1E37B)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    // SUB AX,BX (1000_E37E / 0x1E37E)
    AX -= BX;
    State.IncCycles();
    // CMP AX,BP (1000_E380 / 0x1E380)
    Alu.Sub16(AX, BP);
    State.IncCycles();
    // JC 0x1000:e35c (1000_E382 / 0x1E382)
    if(CarryFlag) {
      goto label_1000_E35C_1E35C;
    }
    State.IncCycles();
    // OR AL,0x1 (1000_E384 / 0x1E384)
    // AL |= 0x1;
    AL = Alu.Or8(AL, 0x1);
    State.IncCycles();
    label_1000_E386_1E386:
    // RET  (1000_E386 / 0x1E386)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E387_01E387(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E387_1E387:
    // PUSH AX (1000_E387 / 0x1E387)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH CX (1000_E388 / 0x1E388)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CX,AX (1000_E389 / 0x1E389)
    CX = AX;
    State.IncCycles();
    // JCXZ 0x1000:e39d (1000_E38B / 0x1E38B)
    if(CX == 0) {
      goto label_1000_E39D_1E39D;
    }
    State.IncCycles();
    // PUSHF  (1000_E38D / 0x1E38D)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // STI  (1000_E38E / 0x1E38E)
    InterruptFlag = true;
    State.IncCycles();
    label_1000_E38F_1E38F:
    // MOV AX,SS:[0xce7a] (1000_E38F / 0x1E38F)
    AX = UInt16[SS, 0xCE7A];
    State.IncCycles();
    label_1000_E393_1E393:
    // CMP AX,word ptr SS:[0xce7a] (1000_E393 / 0x1E393)
    Alu.Sub16(AX, UInt16[SS, 0xCE7A]);
    State.IncCycles();
    // JZ 0x1000:e393 (1000_E398 / 0x1E398)
    if(ZeroFlag) {
      goto label_1000_E393_1E393;
    }
    State.IncCycles();
    // LOOP 0x1000:e38f (1000_E39A / 0x1E39A)
    if(--CX != 0) {
      goto label_1000_E38F_1E38F;
    }
    State.IncCycles();
    // POPF  (1000_E39C / 0x1E39C)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    label_1000_E39D_1E39D:
    // POP CX (1000_E39D / 0x1E39D)
    CX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_E39E / 0x1E39E)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E39F / 0x1E39F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3A0_01E3A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E3A0_1E3A0:
    // MOV CX,AX (1000_E3A0 / 0x1E3A0)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_E3A2_01E3A2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_E3A2_01E3A2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E3A2_1E3A2:
    // MOV AX,[0xce7a] (1000_E3A2 / 0x1E3A2)
    AX = UInt16[DS, 0xCE7A];
    State.IncCycles();
    label_1000_E3A5_1E3A5:
    // CMP AX,word ptr [0xce7a] (1000_E3A5 / 0x1E3A5)
    Alu.Sub16(AX, UInt16[DS, 0xCE7A]);
    State.IncCycles();
    // JZ 0x1000:e3a5 (1000_E3A9 / 0x1E3A9)
    if(ZeroFlag) {
      goto label_1000_E3A5_1E3A5;
    }
    State.IncCycles();
    // CALL 0x1000:e270 (1000_E3AB / 0x1E3AB)
    NearCall(cs1, 0xE3AE, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_E3AE_1E3AE:
    // CALL 0x1000:d9d2 (1000_E3AE / 0x1E3AE)
    NearCall(cs1, 0xE3B1, spice86_generated_label_call_target_1000_D9D2_01D9D2);
    State.IncCycles();
    label_1000_E3B1_1E3B1:
    // CALL 0x1000:e283 (1000_E3B1 / 0x1E3B1)
    NearCall(cs1, 0xE3B4, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_E3B4_1E3B4:
    // LOOP 0x1000:e3a2 (1000_E3B4 / 0x1E3B4)
    if(--CX != 0) {
      goto label_1000_E3A2_1E3A2;
    }
    State.IncCycles();
    // RET  (1000_E3B6 / 0x1E3B6)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3B7_01E3B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E3B7_1E3B7:
    // PUSH DX (1000_E3B7 / 0x1E3B7)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,[0xd824] (1000_E3B8 / 0x1E3B8)
    AX = UInt16[DS, 0xD824];
    State.IncCycles();
    // MOV DX,0xe56d (1000_E3BB / 0x1E3BB)
    DX = 0xE56D;
    State.IncCycles();
    // MUL DX (1000_E3BE / 0x1E3BE)
    Cpu.Mul16(DX);
    State.IncCycles();
    // INC AX (1000_E3C0 / 0x1E3C0)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0xd824],AX (1000_E3C1 / 0x1E3C1)
    UInt16[DS, 0xD824] = AX;
    State.IncCycles();
    // MOV AL,AH (1000_E3C4 / 0x1E3C4)
    AL = AH;
    State.IncCycles();
    // MOV AH,DL (1000_E3C6 / 0x1E3C6)
    AH = DL;
    State.IncCycles();
    // AND AX,BX (1000_E3C8 / 0x1E3C8)
    // AX &= BX;
    AX = Alu.And16(AX, BX);
    State.IncCycles();
    // POP DX (1000_E3CA / 0x1E3CA)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E3CB / 0x1E3CB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3CC_01E3CC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E3CC_1E3CC:
    // PUSH DX (1000_E3CC / 0x1E3CC)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,[0xd826] (1000_E3CD / 0x1E3CD)
    AX = UInt16[DS, 0xD826];
    State.IncCycles();
    // MOV DX,0xcbd1 (1000_E3D0 / 0x1E3D0)
    DX = 0xCBD1;
    State.IncCycles();
    // MUL DX (1000_E3D3 / 0x1E3D3)
    Cpu.Mul16(DX);
    State.IncCycles();
    // INC AX (1000_E3D5 / 0x1E3D5)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0xd826],AX (1000_E3D6 / 0x1E3D6)
    UInt16[DS, 0xD826] = AX;
    State.IncCycles();
    // MOV AL,AH (1000_E3D9 / 0x1E3D9)
    AL = AH;
    State.IncCycles();
    // MOV AH,DL (1000_E3DB / 0x1E3DB)
    AH = DL;
    State.IncCycles();
    // POP DX (1000_E3DD / 0x1E3DD)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E3DE / 0x1E3DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E3DF_01E3DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E3DF_1E3DF:
    // PUSH CX (1000_E3DF / 0x1E3DF)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DX (1000_E3E0 / 0x1E3E0)
    Stack.Push(DX);
    State.IncCycles();
    // MOV AX,BX (1000_E3E1 / 0x1E3E1)
    AX = BX;
    State.IncCycles();
    // OR AX,AX (1000_E3E3 / 0x1E3E3)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:e408 (1000_E3E5 / 0x1E3E5)
    if(ZeroFlag) {
      goto label_1000_E408_1E408;
    }
    State.IncCycles();
    // MOV CX,0xffff (1000_E3E7 / 0x1E3E7)
    CX = 0xFFFF;
    State.IncCycles();
    label_1000_E3EA_1E3EA:
    // SHL CX,1 (1000_E3EA / 0x1E3EA)
    CX <<= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_E3EC / 0x1E3EC)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // JNZ 0x1000:e3ea (1000_E3EE / 0x1E3EE)
    if(!ZeroFlag) {
      goto label_1000_E3EA_1E3EA;
    }
    State.IncCycles();
    // NOT CX (1000_E3F0 / 0x1E3F0)
    CX = (ushort)~CX;
    State.IncCycles();
    label_1000_E3F2_1E3F2:
    // MOV AX,[0xd828] (1000_E3F2 / 0x1E3F2)
    AX = UInt16[DS, 0xD828];
    State.IncCycles();
    // MOV DX,0xcbd1 (1000_E3F5 / 0x1E3F5)
    DX = 0xCBD1;
    State.IncCycles();
    // MUL DX (1000_E3F8 / 0x1E3F8)
    Cpu.Mul16(DX);
    State.IncCycles();
    // INC AX (1000_E3FA / 0x1E3FA)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0xd828],AX (1000_E3FB / 0x1E3FB)
    UInt16[DS, 0xD828] = AX;
    State.IncCycles();
    // MOV AL,AH (1000_E3FE / 0x1E3FE)
    AL = AH;
    State.IncCycles();
    // MOV AH,DL (1000_E400 / 0x1E400)
    AH = DL;
    State.IncCycles();
    // AND AX,CX (1000_E402 / 0x1E402)
    AX &= CX;
    State.IncCycles();
    // CMP AX,BX (1000_E404 / 0x1E404)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JA 0x1000:e3f2 (1000_E406 / 0x1E406)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E3F2_1E3F2;
    }
    State.IncCycles();
    label_1000_E408_1E408:
    // POP DX (1000_E408 / 0x1E408)
    DX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_E409 / 0x1E409)
    CX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E40A / 0x1E40A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E4AD_01E4AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E4AD_1E4AD:
    // MOV SI,0x80 (1000_E4AD / 0x1E4AD)
    SI = 0x80;
    State.IncCycles();
    // LODSB SI (1000_E4B0 / 0x1E4B0)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_E4B1 / 0x1E4B1)
    AH = 0;
    State.IncCycles();
    // MOV BP,AX (1000_E4B3 / 0x1E4B3)
    BP = AX;
    State.IncCycles();
    // ADD BP,SI (1000_E4B5 / 0x1E4B5)
    // BP += SI;
    BP = Alu.Add16(BP, SI);
    State.IncCycles();
    label_1000_E4B7_1E4B7:
    // PUSH CS (1000_E4B7 / 0x1E4B7)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_E4B8 / 0x1E4B8)
    ES = Stack.Pop();
    State.IncCycles();
    label_1000_E4B9_1E4B9:
    // CALL 0x1000:e56b (1000_E4B9 / 0x1E4B9)
    NearCall(cs1, 0xE4BC, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    label_1000_E4BC_1E4BC:
    // JC 0x1000:e4e5 (1000_E4BC / 0x1E4BC)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E4E5 / 0x1E4E5)
      return NearRet();
    }
    State.IncCycles();
    // JZ 0x1000:e4b9 (1000_E4BE / 0x1E4BE)
    if(ZeroFlag) {
      goto label_1000_E4B9_1E4B9;
    }
    State.IncCycles();
    // MOV DL,AL (1000_E4C0 / 0x1E4C0)
    DL = AL;
    State.IncCycles();
    // CALL 0x1000:e56b (1000_E4C2 / 0x1E4C2)
    NearCall(cs1, 0xE4C5, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    label_1000_E4C5_1E4C5:
    // JBE 0x1000:e542 (1000_E4C5 / 0x1E4C5)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    State.IncCycles();
    // MOV AH,AL (1000_E4C7 / 0x1E4C7)
    AH = AL;
    State.IncCycles();
    // CALL 0x1000:e56b (1000_E4C9 / 0x1E4C9)
    NearCall(cs1, 0xE4CC, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    label_1000_E4CC_1E4CC:
    // JBE 0x1000:e542 (1000_E4CC / 0x1E4CC)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    State.IncCycles();
    // XCHG DL,AL (1000_E4CE / 0x1E4CE)
    byte tmp_1000_E4CE = DL;
    DL = AL;
    AL = tmp_1000_E4CE;
    State.IncCycles();
    // MOV DI,0xe40c (1000_E4D0 / 0x1E4D0)
    DI = 0xE40C;
    State.IncCycles();
    // MOV CX,0x17 (1000_E4D3 / 0x1E4D3)
    CX = 0x17;
    State.IncCycles();
    label_1000_E4D6_1E4D6:
    // SCASW ES:DI (1000_E4D6 / 0x1E4D6)
    Alu.Sub16(AX, UInt16[ES, DI]);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // JNZ 0x1000:e4de (1000_E4D7 / 0x1E4D7)
    if(!ZeroFlag) {
      goto label_1000_E4DE_1E4DE;
    }
    State.IncCycles();
    // CMP DL,byte ptr ES:[DI] (1000_E4D9 / 0x1E4D9)
    Alu.Sub8(DL, UInt8[ES, DI]);
    State.IncCycles();
    // JZ 0x1000:e4e6 (1000_E4DC / 0x1E4DC)
    if(ZeroFlag) {
      goto label_1000_E4E6_1E4E6;
    }
    State.IncCycles();
    label_1000_E4DE_1E4DE:
    // ADD DI,0x5 (1000_E4DE / 0x1E4DE)
    // DI += 0x5;
    DI = Alu.Add16(DI, 0x5);
    State.IncCycles();
    // LOOP 0x1000:e4d6 (1000_E4E1 / 0x1E4E1)
    if(--CX != 0) {
      goto label_1000_E4D6_1E4D6;
    }
    State.IncCycles();
    // JMP 0x1000:e542 (1000_E4E3 / 0x1E4E3)
    goto label_1000_E542_1E542;
    State.IncCycles();
    label_1000_E4E5_1E4E5:
    // RET  (1000_E4E5 / 0x1E4E5)
    return NearRet();
    State.IncCycles();
    label_1000_E4E6_1E4E6:
    // MOV AX,0x1f4b (1000_E4E6 / 0x1E4E6)
    AX = 0x1F4B;
    State.IncCycles();
    // MOV ES,AX (1000_E4E9 / 0x1E4E9)
    ES = AX;
    State.IncCycles();
    // MOV BL,byte ptr CS:[DI + 0x1] (1000_E4EB / 0x1E4EB)
    BL = UInt8[cs1, (ushort)(DI + 0x1)];
    State.IncCycles();
    // XOR BH,BH (1000_E4EF / 0x1E4EF)
    BH = 0;
    State.IncCycles();
    // ADD BX,0x2942 (1000_E4F1 / 0x1E4F1)
    // BX += 0x2942;
    BX = Alu.Add16(BX, 0x2942);
    State.IncCycles();
    // MOV AL,byte ptr CS:[DI + 0x2] (1000_E4F5 / 0x1E4F5)
    AL = UInt8[cs1, (ushort)(DI + 0x2)];
    State.IncCycles();
    // OR byte ptr ES:[BX],AL (1000_E4F9 / 0x1E4F9)
    // UInt8[ES, BX] |= AL;
    UInt8[ES, BX] = Alu.Or8(UInt8[ES, BX], AL);
    State.IncCycles();
    // MOV BX,word ptr CS:[DI + 0x3] (1000_E4FC / 0x1E4FC)
    BX = UInt16[cs1, (ushort)(DI + 0x3)];
    State.IncCycles();
    // OR BX,BX (1000_E500 / 0x1E500)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:e542 (1000_E502 / 0x1E502)
    if(ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    State.IncCycles();
    // CALL 0x1000:e56b (1000_E504 / 0x1E504)
    NearCall(cs1, 0xE507, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    label_1000_E507_1E507:
    // JC 0x1000:e4e5 (1000_E507 / 0x1E507)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E4E5 / 0x1E4E5)
      return NearRet();
    }
    State.IncCycles();
    // JZ 0x1000:e542 (1000_E509 / 0x1E509)
    if(ZeroFlag) {
      goto label_1000_E542_1E542;
    }
    State.IncCycles();
    // DEC SI (1000_E50B / 0x1E50B)
    SI--;
    State.IncCycles();
    // CMP BX,0x3826 (1000_E50C / 0x1E50C)
    Alu.Sub16(BX, 0x3826);
    State.IncCycles();
    // JZ 0x1000:e54d (1000_E510 / 0x1E510)
    if(ZeroFlag) {
      goto label_1000_E54D_1E54D;
    }
    State.IncCycles();
    label_1000_E512_1E512:
    // XOR DX,DX (1000_E512 / 0x1E512)
    DX = 0;
    State.IncCycles();
    label_1000_E514_1E514:
    // CALL 0x1000:e56b (1000_E514 / 0x1E514)
    NearCall(cs1, 0xE517, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    label_1000_E517_1E517:
    // MOV AH,AL (1000_E517 / 0x1E517)
    AH = AL;
    State.IncCycles();
    // JBE 0x1000:e537 (1000_E519 / 0x1E519)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E537_1E537;
    }
    State.IncCycles();
    // SUB AL,0x30 (1000_E51B / 0x1E51B)
    // AL -= 0x30;
    AL = Alu.Sub8(AL, 0x30);
    State.IncCycles();
    // JC 0x1000:e537 (1000_E51D / 0x1E51D)
    if(CarryFlag) {
      goto label_1000_E537_1E537;
    }
    State.IncCycles();
    // CMP AL,0x9 (1000_E51F / 0x1E51F)
    Alu.Sub8(AL, 0x9);
    State.IncCycles();
    // JBE 0x1000:e52b (1000_E521 / 0x1E521)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E52B_1E52B;
    }
    State.IncCycles();
    // SUB AL,0x7 (1000_E523 / 0x1E523)
    // AL -= 0x7;
    AL = Alu.Sub8(AL, 0x7);
    State.IncCycles();
    // JC 0x1000:e537 (1000_E525 / 0x1E525)
    if(CarryFlag) {
      goto label_1000_E537_1E537;
    }
    State.IncCycles();
    // CMP AL,0xf (1000_E527 / 0x1E527)
    Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JA 0x1000:e537 (1000_E529 / 0x1E529)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E537_1E537;
    }
    State.IncCycles();
    label_1000_E52B_1E52B:
    // SHL DX,1 (1000_E52B / 0x1E52B)
    DX <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_E52D / 0x1E52D)
    DX <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_E52F / 0x1E52F)
    DX <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_E531 / 0x1E531)
    // DX <<= 0x1;
    DX = Alu.Shl16(DX, 0x1);
    State.IncCycles();
    // OR DL,AL (1000_E533 / 0x1E533)
    // DL |= AL;
    DL = Alu.Or8(DL, AL);
    State.IncCycles();
    // JMP 0x1000:e514 (1000_E535 / 0x1E535)
    goto label_1000_E514_1E514;
    State.IncCycles();
    label_1000_E537_1E537:
    // MOV word ptr ES:[BX],DX (1000_E537 / 0x1E537)
    UInt16[ES, BX] = DX;
    State.IncCycles();
    // ADD BX,0x2 (1000_E53A / 0x1E53A)
    BX += 0x2;
    State.IncCycles();
    // CMP AH,0x20 (1000_E53D / 0x1E53D)
    Alu.Sub8(AH, 0x20);
    State.IncCycles();
    // JA 0x1000:e512 (1000_E540 / 0x1E540)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_E512_1E512;
    }
    State.IncCycles();
    label_1000_E542_1E542:
    // DEC SI (1000_E542 / 0x1E542)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    label_1000_E543_1E543:
    // CALL 0x1000:e56b (1000_E543 / 0x1E543)
    NearCall(cs1, 0xE546, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    label_1000_E546_1E546:
    // JC 0x1000:e4e5 (1000_E546 / 0x1E546)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E4E5 / 0x1E4E5)
      return NearRet();
    }
    State.IncCycles();
    // JNZ 0x1000:e543 (1000_E548 / 0x1E548)
    if(!ZeroFlag) {
      goto label_1000_E543_1E543;
    }
    State.IncCycles();
    // JMP 0x1000:e4b7 (1000_E54A / 0x1E54A)
    goto label_1000_E4B7_1E4B7;
    State.IncCycles();
    label_1000_E54D_1E54D:
    // MOV DI,BX (1000_E54D / 0x1E54D)
    DI = BX;
    State.IncCycles();
    label_1000_E54F_1E54F:
    // CALL 0x1000:e56b (1000_E54F / 0x1E54F)
    NearCall(cs1, 0xE552, spice86_generated_label_call_target_1000_E56B_01E56B);
    State.IncCycles();
    // JBE 0x1000:e55b (1000_E552 / 0x1E552)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E55B_1E55B;
    }
    State.IncCycles();
    // STOSB ES:DI (1000_E554 / 0x1E554)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // CMP DI,0x3898 (1000_E555 / 0x1E555)
    Alu.Sub16(DI, 0x3898);
    State.IncCycles();
    // JC 0x1000:e54f (1000_E559 / 0x1E559)
    if(CarryFlag) {
      goto label_1000_E54F_1E54F;
    }
    State.IncCycles();
    label_1000_E55B_1E55B:
    // MOV AL,0x5c (1000_E55B / 0x1E55B)
    AL = 0x5C;
    State.IncCycles();
    // CMP byte ptr ES:[DI + -0x1],AL (1000_E55D / 0x1E55D)
    Alu.Sub8(UInt8[ES, (ushort)(DI - 0x1)], AL);
    State.IncCycles();
    // JZ 0x1000:e564 (1000_E561 / 0x1E561)
    if(ZeroFlag) {
      goto label_1000_E564_1E564;
    }
    State.IncCycles();
    // STOSB ES:DI (1000_E563 / 0x1E563)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    label_1000_E564_1E564:
    // MOV word ptr ES:[0x38a6],DI (1000_E564 / 0x1E564)
    UInt16[ES, 0x38A6] = DI;
    State.IncCycles();
    // JMP 0x1000:e542 (1000_E569 / 0x1E569)
    goto label_1000_E542_1E542;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E56B_01E56B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E56B_1E56B:
    // MOV AL,0xd (1000_E56B / 0x1E56B)
    AL = 0xD;
    State.IncCycles();
    // CMP SI,BP (1000_E56D / 0x1E56D)
    Alu.Sub16(SI, BP);
    State.IncCycles();
    // JNC 0x1000:e578 (1000_E56F / 0x1E56F)
    if(!CarryFlag) {
      goto label_1000_E578_1E578;
    }
    State.IncCycles();
    // LODSB SI (1000_E571 / 0x1E571)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CMP AL,0x61 (1000_E572 / 0x1E572)
    Alu.Sub8(AL, 0x61);
    State.IncCycles();
    // JC 0x1000:e578 (1000_E574 / 0x1E574)
    if(CarryFlag) {
      goto label_1000_E578_1E578;
    }
    State.IncCycles();
    // AND AL,0xdf (1000_E576 / 0x1E576)
    AL &= 0xDF;
    State.IncCycles();
    label_1000_E578_1E578:
    // CMP AL,0x20 (1000_E578 / 0x1E578)
    Alu.Sub8(AL, 0x20);
    State.IncCycles();
    // RET  (1000_E57A / 0x1E57A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E57B_01E57B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E57B_1E57B:
    // PUSH CX (1000_E57B / 0x1E57B)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_E57C / 0x1E57C)
    Stack.Push(SI);
    State.IncCycles();
    // ADD AX,0xc8 (1000_E57D / 0x1E57D)
    // AX += 0xC8;
    AX = Alu.Add16(AX, 0xC8);
    State.IncCycles();
    // MOV SI,AX (1000_E580 / 0x1E580)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:f0b9 (1000_E582 / 0x1E582)
    NearCall(cs1, 0xE585, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E585_01E585, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E585_01E585(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E585_1E585:
    // POP SI (1000_E585 / 0x1E585)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_E586 / 0x1E586)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV AX,ES (1000_E587 / 0x1E587)
    AX = ES;
    State.IncCycles();
    // SUB AX,0x10 (1000_E589 / 0x1E589)
    // AX -= 0x10;
    AX = Alu.Sub16(AX, 0x10);
    State.IncCycles();
    label_1000_E58C_1E58C:
    // MOV word ptr [SI],AX (1000_E58C / 0x1E58C)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    // ADD SI,0x4 (1000_E58E / 0x1E58E)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    State.IncCycles();
    // LOOP 0x1000:e58c (1000_E591 / 0x1E591)
    if(--CX != 0) {
      goto label_1000_E58C_1E58C;
    }
    State.IncCycles();
    // RET  (1000_E593 / 0x1E593)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E594_01E594(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E594_1E594:
    // MOV AX,0x1f4b (1000_E594 / 0x1E594)
    AX = 0x1F4B;
    State.IncCycles();
    // MOV ES,AX (1000_E597 / 0x1E597)
    ES = AX;
    State.IncCycles();
    // MOV CX,0xdd1d (1000_E599 / 0x1E599)
    CX = 0xDD1D;
    State.IncCycles();
    // MOV DI,0x3cbc (1000_E59C / 0x1E59C)
    DI = 0x3CBC;
    State.IncCycles();
    // SUB CX,DI (1000_E59F / 0x1E59F)
    // CX -= DI;
    CX = Alu.Sub16(CX, DI);
    State.IncCycles();
    // CLD  (1000_E5A1 / 0x1E5A1)
    DirectionFlag = false;
    State.IncCycles();
    // XOR AX,AX (1000_E5A2 / 0x1E5A2)
    AX = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_E5A4 / 0x1E5A4)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV AX,[0x2] (1000_E5A6 / 0x1E5A6)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // PUSH ES (1000_E5A9 / 0x1E5A9)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_E5AA / 0x1E5AA)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV [0xce68],AX (1000_E5AB / 0x1E5AB)
    UInt16[DS, 0xCE68] = AX;
    State.IncCycles();
    // MOV CX,0xdd1d (1000_E5AE / 0x1E5AE)
    CX = 0xDD1D;
    State.IncCycles();
    // CALL 0x1000:f0ff (1000_E5B1 / 0x1E5B1)
    NearCall(cs1, 0xE5B4, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E5B4_01E5B4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E5B4_01E5B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E5B4_1E5B4:
    // MOV AX,0x4c6f (1000_E5B4 / 0x1E5B4)
    AX = 0x4C6F;
    State.IncCycles();
    // MOV CL,0x4 (1000_E5B7 / 0x1E5B7)
    CL = 0x4;
    State.IncCycles();
    // SHR AX,CL (1000_E5B9 / 0x1E5B9)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    State.IncCycles();
    // MOV CX,DS (1000_E5BB / 0x1E5BB)
    CX = DS;
    State.IncCycles();
    // ADD AX,CX (1000_E5BD / 0x1E5BD)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // MOV [0xdc32],AX (1000_E5BF / 0x1E5BF)
    UInt16[DS, 0xDC32] = AX;
    State.IncCycles();
    // MOV AH,0x19 (1000_E5C2 / 0x1E5C2)
    AH = 0x19;
    State.IncCycles();
    // INT 0x21 (1000_E5C4 / 0x1E5C4)
    Interrupt(0x21);
    State.IncCycles();
    // MOV [0xce76],AL (1000_E5C6 / 0x1E5C6)
    UInt8[DS, 0xCE76] = AL;
    State.IncCycles();
    // MOV [0xce77],AL (1000_E5C9 / 0x1E5C9)
    UInt8[DS, 0xCE77] = AL;
    State.IncCycles();
    // MOV AX,0x3301 (1000_E5CC / 0x1E5CC)
    AX = 0x3301;
    State.IncCycles();
    // INT 0x21 (1000_E5CF / 0x1E5CF)
    Interrupt(0x21);
    State.IncCycles();
    // MOV byte ptr [0x2941],DL (1000_E5D1 / 0x1E5D1)
    UInt8[DS, 0x2941] = DL;
    State.IncCycles();
    // MOV AX,0x3301 (1000_E5D5 / 0x1E5D5)
    AX = 0x3301;
    State.IncCycles();
    // XOR DX,DX (1000_E5D8 / 0x1E5D8)
    DX = 0;
    State.IncCycles();
    // INT 0x21 (1000_E5DA / 0x1E5DA)
    Interrupt(0x21);
    State.IncCycles();
    // CALL 0x1000:e675 (1000_E5DC / 0x1E5DC)
    NearCall(cs1, 0xE5DF, spice86_generated_label_call_target_1000_E675_01E675);
    State.IncCycles();
    label_1000_E5DF_1E5DF:
    // MOV AL,[0x2942] (1000_E5DF / 0x1E5DF)
    AL = UInt8[DS, 0x2942];
    State.IncCycles();
    // AND AX,0x1 (1000_E5E2 / 0x1E5E2)
    // AX &= 0x1;
    AX = Alu.And16(AX, 0x1);
    State.IncCycles();
    // MOV SI,0x38b7 (1000_E5E5 / 0x1E5E5)
    SI = 0x38B7;
    State.IncCycles();
    // MOV CX,0x2e (1000_E5E8 / 0x1E5E8)
    CX = 0x2E;
    State.IncCycles();
    // CALL 0x1000:e57b (1000_E5EB / 0x1E5EB)
    NearCall(cs1, 0xE5EE, spice86_generated_label_call_target_1000_E57B_01E57B);
    State.IncCycles();
    label_1000_E5EE_1E5EE:
    // CALLF [0x38b9] (1000_E5EE / 0x1E5EE)
    // Indirect call to [0x38b9], generating possible targets from emulator records
    uint targetAddress_1000_E5EE = (uint)(UInt16[DS, 0x38BB] * 0x10 + UInt16[DS, 0x38B9] - cs1 * 0x10);
    switch(targetAddress_1000_E5EE) {
      case 0x235B3 : FarCall(cs1, 0xE5F2, spice86_generated_label_call_target_334B_0103_0335B3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E5EE));
        break;
    }
    State.IncCycles();
    label_1000_E5F2_1E5F2:
    // MOV [0xdbd8],AX (1000_E5F2 / 0x1E5F2)
    UInt16[DS, 0xDBD8] = AX;
    State.IncCycles();
    // CALL 0x1000:c08e (1000_E5F5 / 0x1E5F5)
    NearCall(cs1, 0xE5F8, spice86_generated_label_call_target_1000_C08E_01C08E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E5F8_01E5F8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E5F8_01E5F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E5F8_1E5F8:
    // MOV word ptr [0xce74],CX (1000_E5F8 / 0x1E5F8)
    UInt16[DS, 0xCE74] = CX;
    State.IncCycles();
    // MOV DI,0xdbdc (1000_E5FC / 0x1E5FC)
    DI = 0xDBDC;
    State.IncCycles();
    // CALL 0x1000:f0f6 (1000_E5FF / 0x1E5FF)
    NearCall(cs1, 0xE602, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    State.IncCycles();
    label_1000_E602_1E602:
    // MOV word ptr [0xdbd6],BP (1000_E602 / 0x1E602)
    UInt16[DS, 0xDBD6] = BP;
    State.IncCycles();
    // OR BP,BP (1000_E606 / 0x1E606)
    // BP |= BP;
    BP = Alu.Or16(BP, BP);
    State.IncCycles();
    // JNZ 0x1000:e610 (1000_E608 / 0x1E608)
    if(!ZeroFlag) {
      goto label_1000_E610_1E610;
    }
    State.IncCycles();
    // MOV DI,0xdbd4 (1000_E60A / 0x1E60A)
    DI = 0xDBD4;
    State.IncCycles();
    // CALL 0x1000:f0f6 (1000_E60D / 0x1E60D)
    NearCall(cs1, 0xE610, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    State.IncCycles();
    label_1000_E610_1E610:
    // CALLF [0x38b5] (1000_E610 / 0x1E610)
    // Indirect call to [0x38b5], generating possible targets from emulator records
    uint targetAddress_1000_E610 = (uint)(UInt16[DS, 0x38B7] * 0x10 + UInt16[DS, 0x38B5] - cs1 * 0x10);
    switch(targetAddress_1000_E610) {
      case 0x235B0 : FarCall(cs1, 0xE614, spice86_generated_label_call_target_334B_0100_0335B0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E610));
        break;
    }
    State.IncCycles();
    label_1000_E614_1E614:
    // MOV AL,[0x2942] (1000_E614 / 0x1E614)
    AL = UInt8[DS, 0x2942];
    State.IncCycles();
    // PUSH AX (1000_E617 / 0x1E617)
    Stack.Push(AX);
    State.IncCycles();
    // SHR AL,1 (1000_E618 / 0x1E618)
    AL >>= 0x1;
    State.IncCycles();
    // SHR AL,1 (1000_E61A / 0x1E61A)
    AL >>= 0x1;
    State.IncCycles();
    // AND AL,0x7 (1000_E61C / 0x1E61C)
    // AL &= 0x7;
    AL = Alu.And8(AL, 0x7);
    State.IncCycles();
    // MOV [0xceeb],AL (1000_E61E / 0x1E61E)
    UInt8[DS, 0xCEEB] = AL;
    State.IncCycles();
    // POP AX (1000_E621 / 0x1E621)
    AX = Stack.Pop();
    State.IncCycles();
    // OR AL,AL (1000_E622 / 0x1E622)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNS 0x1000:e62b (1000_E624 / 0x1E624)
    if(!SignFlag) {
      goto label_1000_E62B_1E62B;
    }
    State.IncCycles();
    // PUSH AX (1000_E626 / 0x1E626)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:ea32 (1000_E627 / 0x1E627)
    NearCall(cs1, 0xE62A, initialize_joystick_ida_1000_EA32_1EA32);
    State.IncCycles();
    // POP AX (1000_E62A / 0x1E62A)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_E62B_1E62B:
    // TEST AL,0x40 (1000_E62B / 0x1E62B)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JNZ 0x1000:e632 (1000_E62D / 0x1E62D)
    if(!ZeroFlag) {
      goto label_1000_E632_1E632;
    }
    State.IncCycles();
    // CALL 0x1000:e97a (1000_E62F / 0x1E62F)
    NearCall(cs1, 0xE632, spice86_generated_label_call_target_1000_E97A_01E97A);
    State.IncCycles();
    label_1000_E632_1E632:
    // CALL 0x1000:e85c (1000_E632 / 0x1E632)
    NearCall(cs1, 0xE635, spice86_generated_label_call_target_1000_E85C_01E85C);
    State.IncCycles();
    label_1000_E635_1E635:
    // CALL 0x1000:ea7b (1000_E635 / 0x1E635)
    NearCall(cs1, 0xE638, spice86_generated_label_call_target_1000_EA7B_01EA7B);
    State.IncCycles();
    label_1000_E638_1E638:
    // MOV AL,[0x2942] (1000_E638 / 0x1E638)
    AL = UInt8[DS, 0x2942];
    State.IncCycles();
    // AND AL,0x2 (1000_E63B / 0x1E63B)
    // AL &= 0x2;
    AL = Alu.And8(AL, 0x2);
    State.IncCycles();
    // MOV BP,0xce7a (1000_E63D / 0x1E63D)
    BP = 0xCE7A;
    State.IncCycles();
    // CALLF [0x3925] (1000_E640 / 0x1E640)
    // Indirect call to [0x3925], generating possible targets from emulator records
    uint targetAddress_1000_E640 = (uint)(UInt16[DS, 0x3927] * 0x10 + UInt16[DS, 0x3925] - cs1 * 0x10);
    switch(targetAddress_1000_E640) {
      case 0x23604 : FarCall(cs1, 0xE644, spice86_generated_label_call_target_334B_0154_033604); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E640));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E644_01E644, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E644_01E644(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E644_1E644:
    // MOV word ptr [0xdc48],0x271c (1000_E644 / 0x1E644)
    UInt16[DS, 0xDC48] = 0x271C;
    State.IncCycles();
    // MOV byte ptr [0xdc46],0xff (1000_E64A / 0x1E64A)
    UInt8[DS, 0xDC46] = 0xFF;
    State.IncCycles();
    // XOR AX,AX (1000_E64F / 0x1E64F)
    AX = 0;
    State.IncCycles();
    // MOV BX,0xc7 (1000_E651 / 0x1E651)
    BX = 0xC7;
    State.IncCycles();
    // XOR CX,CX (1000_E654 / 0x1E654)
    CX = 0;
    State.IncCycles();
    // MOV DX,0x13f (1000_E656 / 0x1E656)
    DX = 0x13F;
    State.IncCycles();
    // CALL 0x1000:db14 (1000_E659 / 0x1E659)
    NearCall(cs1, 0xE65C, spice86_generated_label_call_target_1000_DB14_01DB14);
    State.IncCycles();
    label_1000_E65C_1E65C:
    // MOV BX,0xab (1000_E65C / 0x1E65C)
    BX = 0xAB;
    State.IncCycles();
    // MOV DX,0xed (1000_E65F / 0x1E65F)
    DX = 0xED;
    State.IncCycles();
    // CALL 0x1000:db03 (1000_E662 / 0x1E662)
    NearCall(cs1, 0xE665, spice86_generated_label_call_target_1000_DB03_01DB03);
    State.IncCycles();
    label_1000_E665_1E665:
    // CALL 0x1000:e76a (1000_E665 / 0x1E665)
    NearCall(cs1, 0xE668, spice86_generated_label_call_target_1000_E76A_01E76A);
    State.IncCycles();
    label_1000_E668_1E668:
    // CALL 0x1000:ce6c (1000_E668 / 0x1E668)
    NearCall(cs1, 0xE66B, spice86_generated_label_call_target_1000_CE6C_01CE6C);
    State.IncCycles();
    label_1000_E66B_1E66B:
    // CALL 0x1000:c07c (1000_E66B / 0x1E66B)
    NearCall(cs1, 0xE66E, spice86_generated_label_call_target_1000_C07C_01C07C);
    State.IncCycles();
    label_1000_E66E_1E66E:
    // CALL 0x1000:c0ad (1000_E66E / 0x1E66E)
    NearCall(cs1, 0xE671, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    State.IncCycles();
    label_1000_E671_1E671:
    // JMP 0x1000:c412 (1000_E671 / 0x1E671)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C412_01C412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_E674_01E674(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E674_1E674:
    // RET  (1000_E674 / 0x1E674)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E675_01E675(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E675_1E675:
    // MOV DX,0x37f2 (1000_E675 / 0x1E675)
    DX = 0x37F2;
    State.IncCycles();
    // CALL 0x1000:f1fb (1000_E678 / 0x1E678)
    NearCall(cs1, 0xE67B, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E67B_01E67B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E67B_01E67B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E67B_1E67B:
    // JC 0x1000:e692 (1000_E67B / 0x1E67B)
    if(CarryFlag) {
      goto label_1000_E692_1E692;
    }
    State.IncCycles();
    // LES DI,[0x39b7] (1000_E67D / 0x1E67D)
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    State.IncCycles();
    // CALL 0x1000:f260 (1000_E681 / 0x1E681)
    NearCall(cs1, 0xE684, read_ffff_to_esdi_and_close_ida_1000_F260_1F260);
    State.IncCycles();
    // CMP word ptr ES:[DI],0xc089 (1000_E684 / 0x1E684)
    Alu.Sub16(UInt16[ES, DI], 0xC089);
    State.IncCycles();
    // JNZ 0x1000:e692 (1000_E689 / 0x1E689)
    if(!ZeroFlag) {
      goto label_1000_E692_1E692;
    }
    State.IncCycles();
    // MOV DX,0x31ff (1000_E68B / 0x1E68B)
    DX = 0x31FF;
    State.IncCycles();
    // CALLF [0x39b7] (1000_E68E / 0x1E68E)
    // Indirect call to [0x39b7], generating possible targets from emulator records
    uint targetAddress_1000_E68E = (uint)(UInt16[DS, 0x39B9] * 0x10 + UInt16[DS, 0x39B7] - cs1 * 0x10);
    switch(targetAddress_1000_E68E) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E68E));
        break;
    }
    State.IncCycles();
    label_1000_E692_1E692:
    // MOV SI,0x37f7 (1000_E692 / 0x1E692)
    SI = 0x37F7;
    State.IncCycles();
    // INC byte ptr [SI] (1000_E695 / 0x1E695)
    UInt8[DS, SI]++;
    State.IncCycles();
    // CMP byte ptr [SI],0x39 (1000_E697 / 0x1E697)
    Alu.Sub8(UInt8[DS, SI], 0x39);
    State.IncCycles();
    // JBE 0x1000:e675 (1000_E69A / 0x1E69A)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E675_01E675, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DX,0x37e9 (1000_E69C / 0x1E69C)
    DX = 0x37E9;
    State.IncCycles();
    // MOV AX,0x3d00 (1000_E69F / 0x1E69F)
    AX = 0x3D00;
    State.IncCycles();
    // INT 0x21 (1000_E6A2 / 0x1E6A2)
    Interrupt(0x21);
    State.IncCycles();
    // JC 0x1000:e674 (1000_E6A4 / 0x1E6A4)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E674 / 0x1E674)
      return NearRet();
    }
    State.IncCycles();
    // MOV [0xdbba],AX (1000_E6A6 / 0x1E6A6)
    UInt16[DS, 0xDBBA] = AX;
    State.IncCycles();
    // CALL 0x1000:e741 (1000_E6A9 / 0x1E6A9)
    NearCall(cs1, 0xE6AC, spice86_generated_label_call_target_1000_E741_01E741);
    State.IncCycles();
    label_1000_E6AC_1E6AC:
    // MOV SI,DI (1000_E6AC / 0x1E6AC)
    SI = DI;
    State.IncCycles();
    // MOV BP,ES (1000_E6AE / 0x1E6AE)
    BP = ES;
    State.IncCycles();
    // LES DI,[0x39b7] (1000_E6B0 / 0x1E6B0)
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    State.IncCycles();
    // MOV word ptr [0xdbbc],DI (1000_E6B4 / 0x1E6B4)
    UInt16[DS, 0xDBBC] = DI;
    State.IncCycles();
    // MOV word ptr [0xdbbe],ES (1000_E6B8 / 0x1E6B8)
    UInt16[DS, 0xDBBE] = ES;
    State.IncCycles();
    // MOV AX,0x145 (1000_E6BC / 0x1E6BC)
    AX = 0x145;
    State.IncCycles();
    // STOSW ES:DI (1000_E6BF / 0x1E6BF)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV CX,0x14d (1000_E6C0 / 0x1E6C0)
    CX = 0x14D;
    State.IncCycles();
    // MOV AL,0xff (1000_E6C3 / 0x1E6C3)
    AL = 0xFF;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_E6C5 / 0x1E6C5)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // MOV word ptr [0xd820],DI (1000_E6C7 / 0x1E6C7)
    UInt16[DS, 0xD820] = DI;
    State.IncCycles();
    // PUSH DS (1000_E6CB / 0x1E6CB)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,BP (1000_E6CC / 0x1E6CC)
    DS = BP;
    State.IncCycles();
    // LODSW SI (1000_E6CE / 0x1E6CE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    label_1000_E6CF_1E6CF:
    // PUSH SI (1000_E6CF / 0x1E6CF)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:f314 (1000_E6D0 / 0x1E6D0)
    NearCall(cs1, 0xE6D3, spice86_generated_label_call_target_1000_F314_01F314);
    State.IncCycles();
    label_1000_E6D3_1E6D3:
    // POP SI (1000_E6D3 / 0x1E6D3)
    SI = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:e702 (1000_E6D4 / 0x1E6D4)
    if(CarryFlag) {
      goto label_1000_E702_1E702;
    }
    State.IncCycles();
    // CALL 0x1000:f3a7 (1000_E6D6 / 0x1E6D6)
    NearCall(cs1, 0xE6D9, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    State.IncCycles();
    label_1000_E6D9_1E6D9:
    // JZ 0x1000:e6f9 (1000_E6D9 / 0x1E6D9)
    if(ZeroFlag) {
      goto label_1000_E6F9_1E6F9;
    }
    State.IncCycles();
    // PUSH AX (1000_E6DB / 0x1E6DB)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DX (1000_E6DC / 0x1E6DC)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_E6DD / 0x1E6DD)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_E6DE / 0x1E6DE)
    Stack.Push(DI);
    State.IncCycles();
    // MOV CX,word ptr SS:[0xd820] (1000_E6DF / 0x1E6DF)
    CX = UInt16[SS, 0xD820];
    State.IncCycles();
    // MOV SI,CX (1000_E6E4 / 0x1E6E4)
    SI = CX;
    State.IncCycles();
    // SUB CX,DI (1000_E6E6 / 0x1E6E6)
    CX -= DI;
    State.IncCycles();
    // SUB SI,0x2 (1000_E6E8 / 0x1E6E8)
    // SI -= 0x2;
    SI = Alu.Sub16(SI, 0x2);
    State.IncCycles();
    // LEA DI,[SI + 0xa] (1000_E6EB / 0x1E6EB)
    DI = (ushort)(SI + 0xA);
    State.IncCycles();
    // SHR CX,1 (1000_E6EE / 0x1E6EE)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // STD  (1000_E6F0 / 0x1E6F0)
    DirectionFlag = true;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,ES:SI (1000_E6F1 / 0x1E6F1)
      UInt16[ES, DI] = UInt16[ES, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // CLD  (1000_E6F4 / 0x1E6F4)
    DirectionFlag = false;
    State.IncCycles();
    // POP DI (1000_E6F5 / 0x1E6F5)
    DI = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_E6F6 / 0x1E6F6)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_E6F7 / 0x1E6F7)
    DX = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_E6F8 / 0x1E6F8)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_E6F9_1E6F9:
    // CALL 0x1000:e75b (1000_E6F9 / 0x1E6F9)
    NearCall(cs1, 0xE6FC, spice86_generated_label_call_target_1000_E75B_01E75B);
    State.IncCycles();
    label_1000_E6FC_1E6FC:
    // ADD word ptr SS:[0xd820],0xa (1000_E6FC / 0x1E6FC)
    UInt16[SS, 0xD820] += 0xA;
    State.IncCycles();
    label_1000_E702_1E702:
    // ADD SI,0x19 (1000_E702 / 0x1E702)
    SI += 0x19;
    State.IncCycles();
    // CMP byte ptr [SI],0x0 (1000_E705 / 0x1E705)
    Alu.Sub8(UInt8[DS, SI], 0x0);
    State.IncCycles();
    // JNZ 0x1000:e6cf (1000_E708 / 0x1E708)
    if(!ZeroFlag) {
      goto label_1000_E6CF_1E6CF;
    }
    State.IncCycles();
    // POP DS (1000_E70A / 0x1E70A)
    DS = Stack.Pop();
    State.IncCycles();
    // MOV SI,0x145 (1000_E70B / 0x1E70B)
    SI = 0x145;
    State.IncCycles();
    // MOV AX,[0xd820] (1000_E70E / 0x1E70E)
    AX = UInt16[DS, 0xD820];
    State.IncCycles();
    // SUB AX,SI (1000_E711 / 0x1E711)
    AX -= SI;
    State.IncCycles();
    // XOR DX,DX (1000_E713 / 0x1E713)
    DX = 0;
    State.IncCycles();
    // MOV CX,0x280 (1000_E715 / 0x1E715)
    CX = 0x280;
    State.IncCycles();
    // DIV CX (1000_E718 / 0x1E718)
    Cpu.Div16(CX);
    State.IncCycles();
    // MOV DX,0xa (1000_E71A / 0x1E71A)
    DX = 0xA;
    State.IncCycles();
    // MUL DX (1000_E71D / 0x1E71D)
    Cpu.Mul16(DX);
    State.IncCycles();
    // MOV DX,AX (1000_E71F / 0x1E71F)
    DX = AX;
    State.IncCycles();
    // LES DI,SS:[0xdbbc] (1000_E721 / 0x1E721)
    ES = UInt16[SS, 0xDBBE];
    DI = UInt16[SS, 0xDBBC];
    State.IncCycles();
    // ADD DI,0x2 (1000_E726 / 0x1E726)
    DI += 0x2;
    State.IncCycles();
    label_1000_E729_1E729:
    // ADD SI,DX (1000_E729 / 0x1E729)
    // SI += DX;
    SI = Alu.Add16(SI, DX);
    State.IncCycles();
    // PUSH SI (1000_E72B / 0x1E72B)
    Stack.Push(SI);
    State.IncCycles();
    // MOVSW ES:DI,ES:SI (1000_E72C / 0x1E72C)
    UInt16[ES, DI] = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSB ES:DI,ES:SI (1000_E72E / 0x1E72E)
    UInt8[ES, DI] = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // POP SI (1000_E730 / 0x1E730)
    SI = Stack.Pop();
    State.IncCycles();
    // MOV AX,SI (1000_E731 / 0x1E731)
    AX = SI;
    State.IncCycles();
    // STOSW ES:DI (1000_E733 / 0x1E733)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // CMP DI,0x140 (1000_E734 / 0x1E734)
    Alu.Sub16(DI, 0x140);
    State.IncCycles();
    // JC 0x1000:e729 (1000_E738 / 0x1E738)
    if(CarryFlag) {
      goto label_1000_E729_1E729;
    }
    State.IncCycles();
    // MOV CX,word ptr [0xd820] (1000_E73A / 0x1E73A)
    CX = UInt16[DS, 0xD820];
    State.IncCycles();
    // JMP 0x1000:f0ff (1000_E73E / 0x1E73E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E741_01E741(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E741_1E741:
    // XOR AX,AX (1000_E741 / 0x1E741)
    AX = 0;
    State.IncCycles();
    // XOR DX,DX (1000_E743 / 0x1E743)
    DX = 0;
    State.IncCycles();
    // CALL 0x1000:f2d6 (1000_E745 / 0x1E745)
    NearCall(cs1, 0xE748, spice86_generated_label_call_target_1000_F2D6_01F2D6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E748_01E748, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E748_01E748(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E748_1E748:
    // MOV AX,[0x39b9] (1000_E748 / 0x1E748)
    AX = UInt16[DS, 0x39B9];
    State.IncCycles();
    // ADD AX,0x800 (1000_E74B / 0x1E74B)
    // AX += 0x800;
    AX = Alu.Add16(AX, 0x800);
    State.IncCycles();
    // MOV ES,AX (1000_E74E / 0x1E74E)
    ES = AX;
    State.IncCycles();
    // XOR DI,DI (1000_E750 / 0x1E750)
    DI = 0;
    State.IncCycles();
    // MOV CX,0xffff (1000_E752 / 0x1E752)
    CX = 0xFFFF;
    State.IncCycles();
    // CALL 0x1000:f2ea (1000_E755 / 0x1E755)
    NearCall(cs1, 0xE758, spice86_generated_label_call_target_1000_F2EA_01F2EA);
    State.IncCycles();
    label_1000_E758_1E758:
    // JC 0x1000:e741 (1000_E758 / 0x1E758)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E741_01E741, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_E75A / 0x1E75A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E75B_01E75B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E75B_1E75B:
    // PUSH SI (1000_E75B / 0x1E75B)
    Stack.Push(SI);
    State.IncCycles();
    // STOSW ES:DI (1000_E75C / 0x1E75C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOV AL,DL (1000_E75D / 0x1E75D)
    AL = DL;
    State.IncCycles();
    // STOSB ES:DI (1000_E75F / 0x1E75F)
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // ADD SI,0x10 (1000_E760 / 0x1E760)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_E763 / 0x1E763)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSB ES:DI,SI (1000_E764 / 0x1E764)
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    State.IncCycles();
    // INC SI (1000_E765 / 0x1E765)
    SI = Alu.Inc16(SI);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_E766 / 0x1E766)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // MOVSW ES:DI,SI (1000_E767 / 0x1E767)
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // POP SI (1000_E768 / 0x1E768)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E769 / 0x1E769)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E76A_01E76A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E76A_1E76A:
    // MOV AL,[0x2944] (1000_E76A / 0x1E76A)
    AL = UInt8[DS, 0x2944];
    State.IncCycles();
    // MOV CL,0x4 (1000_E76D / 0x1E76D)
    CL = 0x4;
    State.IncCycles();
    // SHR AL,CL (1000_E76F / 0x1E76F)
    AL >>= CL;
    State.IncCycles();
    // ADD AL,0x7 (1000_E771 / 0x1E771)
    AL += 0x7;
    State.IncCycles();
    // XOR AH,AH (1000_E773 / 0x1E773)
    AH = 0;
    State.IncCycles();
    // MOV SI,0x398b (1000_E775 / 0x1E775)
    SI = 0x398B;
    State.IncCycles();
    // MOV CX,0x8 (1000_E778 / 0x1E778)
    CX = 0x8;
    State.IncCycles();
    // CALL 0x1000:e57b (1000_E77B / 0x1E77B)
    NearCall(cs1, 0xE77E, spice86_generated_label_call_target_1000_E57B_01E57B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E77E_01E77E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E77E_01E77E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E77E_1E77E:
    // MOV AX,[0x39b5] (1000_E77E / 0x1E77E)
    AX = UInt16[DS, 0x39B5];
    State.IncCycles();
    // CALLF [0x3989] (1000_E781 / 0x1E781)
    // Indirect call to [0x3989], generating possible targets from emulator records
    uint targetAddress_1000_E781 = (uint)(UInt16[DS, 0x398B] * 0x10 + UInt16[DS, 0x3989] - cs1 * 0x10);
    switch(targetAddress_1000_E781) {
      case 0x46450 : FarCall(cs1, 0xE785, spice86_generated_label_call_target_5635_0100_056450); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E781));
        break;
    }
    State.IncCycles();
    label_1000_E785_1E785:
    // MOV word ptr [0xdbc8],BX (1000_E785 / 0x1E785)
    UInt16[DS, 0xDBC8] = BX;
    State.IncCycles();
    // CALL 0x1000:a637 (1000_E789 / 0x1E789)
    NearCall(cs1, 0xE78C, spice86_generated_label_call_target_1000_A637_01A637);
    State.IncCycles();
    label_1000_E78C_1E78C:
    // CALL 0x1000:ae54 (1000_E78C / 0x1E78C)
    NearCall(cs1, 0xE78F, spice86_generated_label_call_target_1000_AE54_01AE54);
    State.IncCycles();
    label_1000_E78F_1E78F:
    // CALL 0x1000:e851 (1000_E78F / 0x1E78F)
    NearCall(cs1, 0xE792, spice86_generated_label_call_target_1000_E851_01E851);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E792_01E792, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E792_01E792(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E792_1E792:
    // JC 0x1000:e7bc (1000_E792 / 0x1E792)
    if(CarryFlag) {
      goto label_1000_E7BC_1E7BC;
    }
    State.IncCycles();
    // TEST byte ptr [0x2944],0xf0 (1000_E794 / 0x1E794)
    Alu.And8(UInt8[DS, 0x2944], 0xF0);
    State.IncCycles();
    // JZ 0x1000:e7b9 (1000_E799 / 0x1E799)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // AND byte ptr [0x2944],0xf (1000_E79B / 0x1E79B)
    UInt8[DS, 0x2944] &= 0xF;
    State.IncCycles();
    // XOR AX,AX (1000_E7A0 / 0x1E7A0)
    AX = 0;
    State.IncCycles();
    // MOV [0x3813],AX (1000_E7A2 / 0x1E7A2)
    UInt16[DS, 0x3813] = AX;
    State.IncCycles();
    // MOV [0xdbc8],AL (1000_E7A5 / 0x1E7A5)
    UInt8[DS, 0xDBC8] = AL;
    State.IncCycles();
    // MOV AX,[0x398b] (1000_E7A8 / 0x1E7A8)
    AX = UInt16[DS, 0x398B];
    State.IncCycles();
    // ADD AX,0x10 (1000_E7AB / 0x1E7AB)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    State.IncCycles();
    // MOV [0x39b9],AX (1000_E7AE / 0x1E7AE)
    UInt16[DS, 0x39B9] = AX;
    State.IncCycles();
    // MOV word ptr [0x3cbc],0x3624 (1000_E7B1 / 0x1E7B1)
    UInt16[DS, 0x3CBC] = 0x3624;
    State.IncCycles();
    // JMP 0x1000:e76a (1000_E7B7 / 0x1E7B7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E76A_01E76A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_E7B9_1E7B9:
    // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_E7BC_1E7BC:
    // MOV AX,[0x3813] (1000_E7BC / 0x1E7BC)
    AX = UInt16[DS, 0x3813];
    State.IncCycles();
    // MOV [0x381b],AX (1000_E7BF / 0x1E7BF)
    UInt16[DS, 0x381B] = AX;
    State.IncCycles();
    // CALL 0x1000:a87e (1000_E7C2 / 0x1E7C2)
    NearCall(cs1, 0xE7C5, spice86_generated_label_call_target_1000_A87E_01A87E);
    State.IncCycles();
    label_1000_E7C5_1E7C5:
    // MOV AL,[0x2944] (1000_E7C5 / 0x1E7C5)
    AL = UInt8[DS, 0x2944];
    State.IncCycles();
    // AND AX,0xf (1000_E7C8 / 0x1E7C8)
    AX &= 0xF;
    State.IncCycles();
    // ADD AX,0x2 (1000_E7CB / 0x1E7CB)
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    State.IncCycles();
    // MOV SI,0x396f (1000_E7CE / 0x1E7CE)
    SI = 0x396F;
    State.IncCycles();
    // MOV CX,0x7 (1000_E7D1 / 0x1E7D1)
    CX = 0x7;
    State.IncCycles();
    // CALL 0x1000:e57b (1000_E7D4 / 0x1E7D4)
    NearCall(cs1, 0xE7D7, spice86_generated_label_call_target_1000_E57B_01E57B);
    State.IncCycles();
    label_1000_E7D7_1E7D7:
    // MOV BP,0x3349 (1000_E7D7 / 0x1E7D7)
    BP = 0x3349;
    State.IncCycles();
    // MOV CX,0xa (1000_E7DA / 0x1E7DA)
    CX = 0xA;
    State.IncCycles();
    // MOV AX,[0x39b3] (1000_E7DD / 0x1E7DD)
    AX = UInt16[DS, 0x39B3];
    State.IncCycles();
    // CALLF [0x396d] (1000_E7E0 / 0x1E7E0)
    // Indirect call to [0x396d], generating possible targets from emulator records
    uint targetAddress_1000_E7E0 = (uint)(UInt16[DS, 0x396F] * 0x10 + UInt16[DS, 0x396D] - cs1 * 0x10);
    switch(targetAddress_1000_E7E0) {
      case 0x464E0 : FarCall(cs1, 0xE7E4, spice86_generated_label_call_target_563E_0100_0564E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E7E0));
        break;
    }
    State.IncCycles();
    label_1000_E7E4_1E7E4:
    // OR word ptr [0xdbc8],BX (1000_E7E4 / 0x1E7E4)
    // UInt16[DS, 0xDBC8] |= BX;
    UInt16[DS, 0xDBC8] = Alu.Or16(UInt16[DS, 0xDBC8], BX);
    State.IncCycles();
    // CALL 0x1000:a650 (1000_E7E8 / 0x1E7E8)
    NearCall(cs1, 0xE7EB, spice86_generated_label_call_target_1000_A650_01A650);
    State.IncCycles();
    label_1000_E7EB_1E7EB:
    // CALL 0x1000:ae3f (1000_E7EB / 0x1E7EB)
    NearCall(cs1, 0xE7EE, spice86_generated_label_call_target_1000_AE3F_01AE3F);
    State.IncCycles();
    label_1000_E7EE_1E7EE:
    // CALL 0x1000:e851 (1000_E7EE / 0x1E7EE)
    NearCall(cs1, 0xE7F1, spice86_generated_label_call_target_1000_E851_01E851);
    State.IncCycles();
    label_1000_E7F1_1E7F1:
    // JC 0x1000:e818 (1000_E7F1 / 0x1E7F1)
    if(CarryFlag) {
      goto label_1000_E818_1E818;
    }
    State.IncCycles();
    // TEST byte ptr [0x2944],0xf (1000_E7F3 / 0x1E7F3)
    Alu.And8(UInt8[DS, 0x2944], 0xF);
    State.IncCycles();
    // JZ 0x1000:e7b9 (1000_E7F8 / 0x1E7F8)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // AND byte ptr [0x2944],0xf0 (1000_E7FA / 0x1E7FA)
    UInt8[DS, 0x2944] &= 0xF0;
    State.IncCycles();
    // XOR AX,AX (1000_E7FF / 0x1E7FF)
    AX = 0;
    State.IncCycles();
    // MOV [0xdbb8],AX (1000_E801 / 0x1E801)
    UInt16[DS, 0xDBB8] = AX;
    State.IncCycles();
    // MOV [0xdbc9],AL (1000_E804 / 0x1E804)
    UInt8[DS, 0xDBC9] = AL;
    State.IncCycles();
    // MOV AX,[0x396f] (1000_E807 / 0x1E807)
    AX = UInt16[DS, 0x396F];
    State.IncCycles();
    // ADD AX,0x10 (1000_E80A / 0x1E80A)
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    State.IncCycles();
    // MOV [0x39b9],AX (1000_E80D / 0x1E80D)
    UInt16[DS, 0x39B9] = AX;
    State.IncCycles();
    // MOV word ptr [0x3cbc],0x364b (1000_E810 / 0x1E810)
    UInt16[DS, 0x3CBC] = 0x364B;
    State.IncCycles();
    // JMP 0x1000:e7c5 (1000_E816 / 0x1E816)
    goto label_1000_E7C5_1E7C5;
    State.IncCycles();
    label_1000_E818_1E818:
    // CALL 0x1000:ae28 (1000_E818 / 0x1E818)
    NearCall(cs1, 0xE81B, spice86_generated_label_call_target_1000_AE28_01AE28);
    State.IncCycles();
    label_1000_E81B_1E81B:
    // JZ 0x1000:e825 (1000_E81B / 0x1E81B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E825 / 0x1E825)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e826 (1000_E81D / 0x1E81D)
    NearCall(cs1, 0xE820, spice86_generated_label_call_target_1000_E826_01E826);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E826_01E826, 0x1E820 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E826_01E826(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xE820: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    State.IncCycles();
    label_1000_E820_1E820:
    // AND byte ptr [0x2943],0xef (1000_E820 / 0x1E820)
    // UInt8[DS, 0x2943] &= 0xEF;
    UInt8[DS, 0x2943] = Alu.And8(UInt8[DS, 0x2943], 0xEF);
    State.IncCycles();
    label_1000_E825_1E825:
    // RET  (1000_E825 / 0x1E825)
    return NearRet();
    entry:
    State.IncCycles();
    label_1000_E826_1E826:
    // CMP word ptr [0xdbba],0x0 (1000_E826 / 0x1E826)
    Alu.Sub16(UInt16[DS, 0xDBBA], 0x0);
    State.IncCycles();
    // JZ 0x1000:e850 (1000_E82B / 0x1E82B)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E850 / 0x1E850)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:e741 (1000_E82D / 0x1E82D)
    NearCall(cs1, 0xE830, spice86_generated_label_call_target_1000_E741_01E741);
    State.IncCycles();
    label_1000_E830_1E830:
    // PUSH DS (1000_E830 / 0x1E830)
    Stack.Push(DS);
    State.IncCycles();
    // MOV SI,DI (1000_E831 / 0x1E831)
    SI = DI;
    State.IncCycles();
    // PUSH ES (1000_E833 / 0x1E833)
    Stack.Push(ES);
    State.IncCycles();
    // POP DS (1000_E834 / 0x1E834)
    DS = Stack.Pop();
    State.IncCycles();
    // LODSW SI (1000_E835 / 0x1E835)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,0xfa (1000_E836 / 0x1E836)
    CX = 0xFA;
    State.IncCycles();
    label_1000_E839_1E839:
    // PUSH CX (1000_E839 / 0x1E839)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_E83A / 0x1E83A)
    Stack.Push(SI);
    State.IncCycles();
    // CALL 0x1000:f314 (1000_E83B / 0x1E83B)
    NearCall(cs1, 0xE83E, spice86_generated_label_call_target_1000_F314_01F314);
    State.IncCycles();
    label_1000_E83E_1E83E:
    // POP SI (1000_E83E / 0x1E83E)
    SI = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:e849 (1000_E83F / 0x1E83F)
    if(CarryFlag) {
      goto label_1000_E849_1E849;
    }
    State.IncCycles();
    // CALL 0x1000:f3a7 (1000_E841 / 0x1E841)
    NearCall(cs1, 0xE844, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    State.IncCycles();
    label_1000_E844_1E844:
    // JNZ 0x1000:e849 (1000_E844 / 0x1E844)
    if(!ZeroFlag) {
      goto label_1000_E849_1E849;
    }
    State.IncCycles();
    // CALL 0x1000:e75b (1000_E846 / 0x1E846)
    NearCall(cs1, 0xE849, spice86_generated_label_call_target_1000_E75B_01E75B);
    State.IncCycles();
    label_1000_E849_1E849:
    // ADD SI,0x19 (1000_E849 / 0x1E849)
    // SI += 0x19;
    SI = Alu.Add16(SI, 0x19);
    State.IncCycles();
    // POP CX (1000_E84C / 0x1E84C)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:e839 (1000_E84D / 0x1E84D)
    if(--CX != 0) {
      goto label_1000_E839_1E839;
    }
    State.IncCycles();
    // POP DS (1000_E84F / 0x1E84F)
    DS = Stack.Pop();
    State.IncCycles();
    label_1000_E850_1E850:
    // RET  (1000_E850 / 0x1E850)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E851_01E851(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E851_1E851:
    // MOV AX,[0x39b9] (1000_E851 / 0x1E851)
    AX = UInt16[DS, 0x39B9];
    State.IncCycles();
    // ADD AX,0x2f13 (1000_E854 / 0x1E854)
    AX += 0x2F13;
    State.IncCycles();
    // CMP AX,word ptr [0xce68] (1000_E857 / 0x1E857)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    State.IncCycles();
    // RET  (1000_E85B / 0x1E85B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E85C_01E85C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E85C_1E85C:
    // CLI  (1000_E85C / 0x1E85C)
    InterruptFlag = false;
    State.IncCycles();
    // CALL 0x1000:e913 (1000_E85D / 0x1E85D)
    NearCall(cs1, 0xE860, spice86_generated_label_call_target_1000_E913_01E913);
    State.IncCycles();
    label_1000_E860_1E860:
    // XOR AX,AX (1000_E860 / 0x1E860)
    AX = 0;
    State.IncCycles();
    // MOV ES,AX (1000_E862 / 0x1E862)
    ES = AX;
    State.IncCycles();
    // MOV DI,0x20 (1000_E864 / 0x1E864)
    DI = 0x20;
    State.IncCycles();
    // MOV word ptr ES:[DI],0xe8b8 (1000_E867 / 0x1E867)
    UInt16[ES, DI] = 0xE8B8;
    State.IncCycles();
    // PUSHF  (1000_E86C / 0x1E86C)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // STI  (1000_E86D / 0x1E86D)
    InterruptFlag = true;
    State.IncCycles();
    label_1000_E86E_1E86E:
    CheckExternalEvents(cs1, 0xE874);
    // CMP byte ptr CS:[0xe8d4],0x0 (1000_E86E / 0x1E86E)
    Alu.Sub8(UInt8[cs1, 0xE8D4], 0x0);
    State.IncCycles();
    // JZ 0x1000:e86e (1000_E874 / 0x1E874)
    if(ZeroFlag) {
      goto label_1000_E86E_1E86E;
    }
    State.IncCycles();
    // POPF  (1000_E876 / 0x1E876)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // MOV word ptr ES:[DI],0xef6a (1000_E877 / 0x1E877)
    UInt16[ES, DI] = 0xEF6A;
    State.IncCycles();
    // MOV AX,CS:[0xe8d2] (1000_E87C / 0x1E87C)
    AX = UInt16[cs1, 0xE8D2];
    State.IncCycles();
    // OR AH,AH (1000_E880 / 0x1E880)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    State.IncCycles();
    // JZ 0x1000:e8a5 (1000_E882 / 0x1E882)
    if(ZeroFlag) {
      goto label_1000_E8A5_1E8A5;
    }
    State.IncCycles();
    // OR AL,AL (1000_E884 / 0x1E884)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JZ 0x1000:e8a5 (1000_E886 / 0x1E886)
    if(ZeroFlag) {
      goto label_1000_E8A5_1E8A5;
    }
    State.IncCycles();
    // XOR DX,DX (1000_E888 / 0x1E888)
    DX = 0;
    State.IncCycles();
    // MOV CX,0x1745 (1000_E88A / 0x1E88A)
    CX = 0x1745;
    State.IncCycles();
    // DIV CX (1000_E88D / 0x1E88D)
    Cpu.Div16(CX);
    State.IncCycles();
    // SHL DX,1 (1000_E88F / 0x1E88F)
    DX <<= 0x1;
    State.IncCycles();
    // CMP DX,CX (1000_E891 / 0x1E891)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JC 0x1000:e896 (1000_E893 / 0x1E893)
    if(CarryFlag) {
      goto label_1000_E896_1E896;
    }
    State.IncCycles();
    // INC AX (1000_E895 / 0x1E895)
    AX++;
    State.IncCycles();
    label_1000_E896_1E896:
    // DEC AX (1000_E896 / 0x1E896)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // JNS 0x1000:e89a (1000_E897 / 0x1E897)
    if(!SignFlag) {
      goto label_1000_E89A_1E89A;
    }
    State.IncCycles();
    // INC AX (1000_E899 / 0x1E899)
    AX++;
    State.IncCycles();
    label_1000_E89A_1E89A:
    // CMP AX,0xa (1000_E89A / 0x1E89A)
    Alu.Sub16(AX, 0xA);
    State.IncCycles();
    // JC 0x1000:e8a1 (1000_E89D / 0x1E89D)
    if(CarryFlag) {
      goto label_1000_E8A1_1E8A1;
    }
    State.IncCycles();
    // MOV AL,0xa (1000_E89F / 0x1E89F)
    AL = 0xA;
    State.IncCycles();
    label_1000_E8A1_1E8A1:
    // MOV CS:[0xefd9],AL (1000_E8A1 / 0x1E8A1)
    UInt8[cs1, 0xEFD9] = AL;
    State.IncCycles();
    label_1000_E8A5_1E8A5:
    // MOV AX,0x1745 (1000_E8A5 / 0x1E8A5)
    AX = 0x1745;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E8A8_01E8A8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E8A8_01E8A8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E8A8_1E8A8:
    // PUSHF  (1000_E8A8 / 0x1E8A8)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // PUSH AX (1000_E8A9 / 0x1E8A9)
    Stack.Push(AX);
    State.IncCycles();
    // CLI  (1000_E8AA / 0x1E8AA)
    InterruptFlag = false;
    State.IncCycles();
    // MOV AL,0x36 (1000_E8AB / 0x1E8AB)
    AL = 0x36;
    State.IncCycles();
    // OUT 0x43,AL (1000_E8AD / 0x1E8AD)
    Cpu.Out8(0x43, AL);
    State.IncCycles();
    // POP AX (1000_E8AF / 0x1E8AF)
    AX = Stack.Pop();
    State.IncCycles();
    // OUT 0x40,AL (1000_E8B0 / 0x1E8B0)
    Cpu.Out8(0x40, AL);
    State.IncCycles();
    // MOV AL,AH (1000_E8B2 / 0x1E8B2)
    AL = AH;
    State.IncCycles();
    // OUT 0x40,AL (1000_E8B4 / 0x1E8B4)
    Cpu.Out8(0x40, AL);
    State.IncCycles();
    // POPF  (1000_E8B6 / 0x1E8B6)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E8B7 / 0x1E8B7)
    return NearRet();
  }
  
  public virtual Action get_pit_timer_value_ida_1000_E8B8_1E8B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E8B8_1E8B8:
    // PUSH AX (1000_E8B8 / 0x1E8B8)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AL,0x36 (1000_E8B9 / 0x1E8B9)
    AL = 0x36;
    State.IncCycles();
    // OUT 0x43,AL (1000_E8BB / 0x1E8BB)
    Cpu.Out8(0x43, AL);
    State.IncCycles();
    // IN AL,0x40 (1000_E8BD / 0x1E8BD)
    AL = Cpu.In8(0x40);
    State.IncCycles();
    // MOV AH,AL (1000_E8BF / 0x1E8BF)
    AH = AL;
    State.IncCycles();
    // IN AL,0x40 (1000_E8C1 / 0x1E8C1)
    AL = Cpu.In8(0x40);
    State.IncCycles();
    // XCHG AL,AH (1000_E8C3 / 0x1E8C3)
    byte tmp_1000_E8C3 = AL;
    AL = AH;
    AH = tmp_1000_E8C3;
    State.IncCycles();
    // MOV CS:[0xe8d2],AX (1000_E8C5 / 0x1E8C5)
    UInt16[cs1, 0xE8D2] = AX;
    State.IncCycles();
    // INC byte ptr CS:[0xe8d4] (1000_E8C9 / 0x1E8C9)
    UInt8[cs1, 0xE8D4] = Alu.Inc8(UInt8[cs1, 0xE8D4]);
    State.IncCycles();
    // POP AX (1000_E8CE / 0x1E8CE)
    AX = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:ef6a (1000_E8CF / 0x1E8CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_EF6A_01EF6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E8D5_01E8D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E8D5_1E8D5:
    // CMP word ptr CS:[0xee8a],0x0 (1000_E8D5 / 0x1E8D5)
    Alu.Sub16(UInt16[cs1, 0xEE8A], 0x0);
    State.IncCycles();
    // JZ 0x1000:e8e2 (1000_E8DB / 0x1E8DB)
    if(ZeroFlag) {
      goto label_1000_E8E2_1E8E2;
    }
    State.IncCycles();
    // MOV AH,0xa (1000_E8DD / 0x1E8DD)
    AH = 0xA;
    State.IncCycles();
    // CALL 0x1000:ef2b (1000_E8DF / 0x1E8DF)
    NearCall(cs1, 0xE8E2, call_xms_func_on_block_ida_1000_EF2B_1EF2B);
    State.IncCycles();
    label_1000_E8E2_1E8E2:
    // CMP word ptr CS:[0xed3a],0x0 (1000_E8E2 / 0x1E8E2)
    Alu.Sub16(UInt16[cs1, 0xED3A], 0x0);
    State.IncCycles();
    // JZ 0x1000:e8ef (1000_E8E8 / 0x1E8E8)
    if(ZeroFlag) {
      goto label_1000_E8EF_1E8EF;
    }
    State.IncCycles();
    // MOV AH,0x45 (1000_E8EA / 0x1E8EA)
    AH = 0x45;
    State.IncCycles();
    // CALL 0x1000:ed40 (1000_E8EC / 0x1E8EC)
    NearCall(cs1, 0xE8EF, get_ems_emm_handle_ida_1000_ED40_1ED40);
    State.IncCycles();
    label_1000_E8EF_1E8EF:
    // MOV DX,word ptr CS:[0xed3e] (1000_E8EF / 0x1E8EF)
    DX = UInt16[cs1, 0xED3E];
    State.IncCycles();
    // OR DX,DX (1000_E8F4 / 0x1E8F4)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:e8fd (1000_E8F6 / 0x1E8F6)
    if(ZeroFlag) {
      goto label_1000_E8FD_1E8FD;
    }
    State.IncCycles();
    // MOV AH,0x45 (1000_E8F8 / 0x1E8F8)
    AH = 0x45;
    State.IncCycles();
    // CALL 0x1000:ed45 (1000_E8FA / 0x1E8FA)
    NearCall(cs1, 0xE8FD, call_ems_func_ida_1000_ED45_1ED45);
    State.IncCycles();
    label_1000_E8FD_1E8FD:
    // XOR AX,AX (1000_E8FD / 0x1E8FD)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:e8a8 (1000_E8FF / 0x1E8FF)
    NearCall(cs1, 0xE902, spice86_generated_label_call_target_1000_E8A8_01E8A8);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_E902_01E902, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_E902_01E902(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E902_1E902:
    // MOV DL,byte ptr [0x2941] (1000_E902 / 0x1E902)
    DL = UInt8[DS, 0x2941];
    State.IncCycles();
    // MOV AX,0x3301 (1000_E906 / 0x1E906)
    AX = 0x3301;
    State.IncCycles();
    // INT 0x21 (1000_E909 / 0x1E909)
    Interrupt(0x21);
    State.IncCycles();
    // CMP byte ptr [0xce73],0x0 (1000_E90B / 0x1E90B)
    Alu.Sub8(UInt8[DS, 0xCE73], 0x0);
    State.IncCycles();
    // JNZ 0x1000:e913 (1000_E910 / 0x1E910)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E913_01E913, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // RET  (1000_E912 / 0x1E912)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E913_01E913(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E913_1E913:
    // XOR byte ptr [0xce73],0xff (1000_E913 / 0x1E913)
    // UInt8[DS, 0xCE73] ^= 0xFF;
    UInt8[DS, 0xCE73] = Alu.Xor8(UInt8[DS, 0xCE73], 0xFF);
    State.IncCycles();
    // MOV SI,0x2913 (1000_E918 / 0x1E918)
    SI = 0x2913;
    State.IncCycles();
    // PUSHF  (1000_E91B / 0x1E91B)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // CLI  (1000_E91C / 0x1E91C)
    InterruptFlag = false;
    State.IncCycles();
    // LODSW SI (1000_E91D / 0x1E91D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    label_1000_E91E_1E91E:
    // MOV DI,AX (1000_E91E / 0x1E91E)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_E920 / 0x1E920)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // XCHG AX,DI (1000_E921 / 0x1E921)
    ushort tmp_1000_E921 = AX;
    AX = DI;
    DI = tmp_1000_E921;
    State.IncCycles();
    // PUSH SI (1000_E922 / 0x1E922)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,AX (1000_E923 / 0x1E923)
    SI = AX;
    State.IncCycles();
    // SHL SI,1 (1000_E925 / 0x1E925)
    SI <<= 0x1;
    State.IncCycles();
    // SHL SI,1 (1000_E927 / 0x1E927)
    SI <<= 0x1;
    State.IncCycles();
    // XOR AX,AX (1000_E929 / 0x1E929)
    AX = 0;
    State.IncCycles();
    // MOV ES,AX (1000_E92B / 0x1E92B)
    ES = AX;
    State.IncCycles();
    // MOV AX,word ptr CS:[DI] (1000_E92D / 0x1E92D)
    AX = UInt16[cs1, DI];
    State.IncCycles();
    // XCHG word ptr ES:[SI],AX (1000_E930 / 0x1E930)
    ushort tmp_1000_E930 = UInt16[ES, SI];
    UInt16[ES, SI] = AX;
    AX = tmp_1000_E930;
    State.IncCycles();
    // MOV word ptr CS:[DI],AX (1000_E933 / 0x1E933)
    UInt16[cs1, DI] = AX;
    State.IncCycles();
    // MOV AX,word ptr CS:[DI + 0x2] (1000_E936 / 0x1E936)
    AX = UInt16[cs1, (ushort)(DI + 0x2)];
    State.IncCycles();
    // XCHG word ptr ES:[SI + 0x2],AX (1000_E93A / 0x1E93A)
    ushort tmp_1000_E93A = UInt16[ES, (ushort)(SI + 0x2)];
    UInt16[ES, (ushort)(SI + 0x2)] = AX;
    AX = tmp_1000_E93A;
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x2],AX (1000_E93E / 0x1E93E)
    UInt16[cs1, (ushort)(DI + 0x2)] = AX;
    State.IncCycles();
    // POP SI (1000_E942 / 0x1E942)
    SI = Stack.Pop();
    State.IncCycles();
    // LODSW SI (1000_E943 / 0x1E943)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR AX,AX (1000_E944 / 0x1E944)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x1000:e91e (1000_E946 / 0x1E946)
    if(!SignFlag) {
      goto label_1000_E91E_1E91E;
    }
    State.IncCycles();
    // POPF  (1000_E948 / 0x1E948)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_E949 / 0x1E949)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_E97A_01E97A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E97A_1E97A:
    // MOV AX,0x3533 (1000_E97A / 0x1E97A)
    AX = 0x3533;
    State.IncCycles();
    // INT 0x21 (1000_E97D / 0x1E97D)
    Interrupt(0x21);
    State.IncCycles();
    // MOV AX,ES (1000_E97F / 0x1E97F)
    AX = ES;
    State.IncCycles();
    // OR AX,BX (1000_E981 / 0x1E981)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    State.IncCycles();
    // JZ 0x1000:e9f3 (1000_E983 / 0x1E983)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x0 (1000_E985 / 0x1E985)
    AX = 0x0;
    State.IncCycles();
    // INT 0x33 (1000_E988 / 0x1E988)
    Interrupt(0x33);
    State.IncCycles();
    // INC AX (1000_E98A / 0x1E98A)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // JNZ 0x1000:e9f3 (1000_E98B / 0x1E98B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    State.IncCycles();
    // XOR CX,CX (1000_E98D / 0x1E98D)
    CX = 0;
    State.IncCycles();
    // XOR DX,DX (1000_E98F / 0x1E98F)
    DX = 0;
    State.IncCycles();
    // MOV AX,0x4 (1000_E991 / 0x1E991)
    AX = 0x4;
    State.IncCycles();
    // INT 0x33 (1000_E994 / 0x1E994)
    Interrupt(0x33);
    State.IncCycles();
    label_1000_E996_1E996:
    // INC byte ptr [0x2580] (1000_E996 / 0x1E996)
    UInt8[DS, 0x2580] = Alu.Inc8(UInt8[DS, 0x2580]);
    State.IncCycles();
    // JS 0x1000:e9b3 (1000_E99A / 0x1E99A)
    if(SignFlag) {
      goto label_1000_E9B3_1E9B3;
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x2580] (1000_E99C / 0x1E99C)
    CL = UInt8[DS, 0x2580];
    State.IncCycles();
    // MOV AX,0x1 (1000_E9A0 / 0x1E9A0)
    AX = 0x1;
    State.IncCycles();
    // SHL AX,CL (1000_E9A3 / 0x1E9A3)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    State.IncCycles();
    // MOV CX,AX (1000_E9A5 / 0x1E9A5)
    CX = AX;
    State.IncCycles();
    // MOV AX,0x4 (1000_E9A7 / 0x1E9A7)
    AX = 0x4;
    State.IncCycles();
    // INT 0x33 (1000_E9AA / 0x1E9AA)
    Interrupt(0x33);
    State.IncCycles();
    // MOV AX,0x3 (1000_E9AC / 0x1E9AC)
    AX = 0x3;
    State.IncCycles();
    // INT 0x33 (1000_E9AF / 0x1E9AF)
    Interrupt(0x33);
    State.IncCycles();
    // JCXZ 0x1000:e996 (1000_E9B1 / 0x1E9B1)
    if(CX == 0) {
      goto label_1000_E996_1E996;
    }
    State.IncCycles();
    label_1000_E9B3_1E9B3:
    // INC byte ptr [0x2581] (1000_E9B3 / 0x1E9B3)
    UInt8[DS, 0x2581] = Alu.Inc8(UInt8[DS, 0x2581]);
    State.IncCycles();
    // JS 0x1000:e9d0 (1000_E9B7 / 0x1E9B7)
    if(SignFlag) {
      goto label_1000_E9D0_1E9D0;
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x2581] (1000_E9B9 / 0x1E9B9)
    CL = UInt8[DS, 0x2581];
    State.IncCycles();
    // MOV DX,0x1 (1000_E9BD / 0x1E9BD)
    DX = 0x1;
    State.IncCycles();
    // SHL DX,CL (1000_E9C0 / 0x1E9C0)
    // DX <<= CL;
    DX = Alu.Shl16(DX, CL);
    State.IncCycles();
    // MOV AX,0x4 (1000_E9C2 / 0x1E9C2)
    AX = 0x4;
    State.IncCycles();
    // INT 0x33 (1000_E9C5 / 0x1E9C5)
    Interrupt(0x33);
    State.IncCycles();
    // MOV AX,0x3 (1000_E9C7 / 0x1E9C7)
    AX = 0x3;
    State.IncCycles();
    // INT 0x33 (1000_E9CA / 0x1E9CA)
    Interrupt(0x33);
    State.IncCycles();
    // OR DX,DX (1000_E9CC / 0x1E9CC)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JZ 0x1000:e9b3 (1000_E9CE / 0x1E9CE)
    if(ZeroFlag) {
      goto label_1000_E9B3_1E9B3;
    }
    State.IncCycles();
    label_1000_E9D0_1E9D0:
    // MOV AX,0x10 (1000_E9D0 / 0x1E9D0)
    AX = 0x10;
    State.IncCycles();
    // MOV DX,AX (1000_E9D3 / 0x1E9D3)
    DX = AX;
    State.IncCycles();
    // AND word ptr [0x2580],0x7f7f (1000_E9D5 / 0x1E9D5)
    // UInt16[DS, 0x2580] &= 0x7F7F;
    UInt16[DS, 0x2580] = Alu.And16(UInt16[DS, 0x2580], 0x7F7F);
    State.IncCycles();
    // MOV CX,word ptr [0x2580] (1000_E9DB / 0x1E9DB)
    CX = UInt16[DS, 0x2580];
    State.IncCycles();
    // SHR AX,CL (1000_E9DF / 0x1E9DF)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    State.IncCycles();
    // MOV CL,CH (1000_E9E1 / 0x1E9E1)
    CL = CH;
    State.IncCycles();
    // SHR DX,CL (1000_E9E3 / 0x1E9E3)
    // DX >>= CL;
    DX = Alu.Shr16(DX, CL);
    State.IncCycles();
    // MOV CX,AX (1000_E9E5 / 0x1E9E5)
    CX = AX;
    State.IncCycles();
    // MOV AX,0xf (1000_E9E7 / 0x1E9E7)
    AX = 0xF;
    State.IncCycles();
    // PUSH DX (1000_E9EA / 0x1E9EA)
    Stack.Push(DX);
    State.IncCycles();
    // INT 0x33 (1000_E9EB / 0x1E9EB)
    Interrupt(0x33);
    State.IncCycles();
    // POP DX (1000_E9ED / 0x1E9ED)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV AX,0x13 (1000_E9EE / 0x1E9EE)
    AX = 0x13;
    State.IncCycles();
    // INT 0x33 (1000_E9F1 / 0x1E9F1)
    Interrupt(0x33);
    State.IncCycles();
    label_1000_E9F3_1E9F3:
    // RET  (1000_E9F3 / 0x1E9F3)
    return NearRet();
  }
  
  public virtual Action mouse_func_uncalled_ida_1000_E9F4_1E9F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_E9F4_1E9F4:
    // PUSH AX (1000_E9F4 / 0x1E9F4)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DS (1000_E9F5 / 0x1E9F5)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,word ptr CS:[0xea30] (1000_E9F6 / 0x1E9F6)
    DS = UInt16[cs1, 0xEA30];
    State.IncCycles();
    // MOV word ptr [0xdc36],CX (1000_E9FB / 0x1E9FB)
    UInt16[DS, 0xDC36] = CX;
    State.IncCycles();
    // MOV word ptr [0xdc38],DX (1000_E9FF / 0x1E9FF)
    UInt16[DS, 0xDC38] = DX;
    State.IncCycles();
    // SHR AL,1 (1000_EA03 / 0x1EA03)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JZ 0x1000:ea2d (1000_EA05 / 0x1EA05)
    if(ZeroFlag) {
      goto label_1000_EA2D_1EA2D;
    }
    State.IncCycles();
    // PUSH CX (1000_EA07 / 0x1EA07)
    Stack.Push(CX);
    State.IncCycles();
    // MOV CL,byte ptr [0xdc34] (1000_EA08 / 0x1EA08)
    CL = UInt8[DS, 0xDC34];
    State.IncCycles();
    // SHR AL,1 (1000_EA0C / 0x1EA0C)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:ea13 (1000_EA0E / 0x1EA0E)
    if(!CarryFlag) {
      goto label_1000_EA13_1EA13;
    }
    State.IncCycles();
    // OR CL,0x1 (1000_EA10 / 0x1EA10)
    CL |= 0x1;
    State.IncCycles();
    label_1000_EA13_1EA13:
    // SHR AL,1 (1000_EA13 / 0x1EA13)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:ea1a (1000_EA15 / 0x1EA15)
    if(!CarryFlag) {
      goto label_1000_EA1A_1EA1A;
    }
    State.IncCycles();
    // AND CL,0xfe (1000_EA17 / 0x1EA17)
    CL &= 0xFE;
    State.IncCycles();
    label_1000_EA1A_1EA1A:
    // SHR AL,1 (1000_EA1A / 0x1EA1A)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:ea21 (1000_EA1C / 0x1EA1C)
    if(!CarryFlag) {
      goto label_1000_EA21_1EA21;
    }
    State.IncCycles();
    // OR CL,0x2 (1000_EA1E / 0x1EA1E)
    CL |= 0x2;
    State.IncCycles();
    label_1000_EA21_1EA21:
    // SHR AL,1 (1000_EA21 / 0x1EA21)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    State.IncCycles();
    // JNC 0x1000:ea28 (1000_EA23 / 0x1EA23)
    if(!CarryFlag) {
      goto label_1000_EA28_1EA28;
    }
    State.IncCycles();
    // AND CL,0xfd (1000_EA25 / 0x1EA25)
    // CL &= 0xFD;
    CL = Alu.And8(CL, 0xFD);
    State.IncCycles();
    label_1000_EA28_1EA28:
    // MOV byte ptr [0xdc34],CL (1000_EA28 / 0x1EA28)
    UInt8[DS, 0xDC34] = CL;
    State.IncCycles();
    // POP CX (1000_EA2C / 0x1EA2C)
    CX = Stack.Pop();
    State.IncCycles();
    label_1000_EA2D_1EA2D:
    // POP DS (1000_EA2D / 0x1EA2D)
    DS = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_EA2E / 0x1EA2E)
    AX = Stack.Pop();
    State.IncCycles();
    // RETF  (1000_EA2F / 0x1EA2F)
    return FarRet();
  }
  
  public virtual Action initialize_joystick_ida_1000_EA32_1EA32(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EA32_1EA32:
    // MOV SI,0x39ab (1000_EA32 / 0x1EA32)
    SI = 0x39AB;
    State.IncCycles();
    // XOR BX,BX (1000_EA35 / 0x1EA35)
    BX = 0;
    State.IncCycles();
    // MOV CX,0x4 (1000_EA37 / 0x1EA37)
    CX = 0x4;
    State.IncCycles();
    label_1000_EA3A_1EA3A:
    // LODSW SI (1000_EA3A / 0x1EA3A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // OR BX,AX (1000_EA3B / 0x1EA3B)
    // BX |= AX;
    BX = Alu.Or16(BX, AX);
    State.IncCycles();
    // LOOP 0x1000:ea3a (1000_EA3D / 0x1EA3D)
    if(--CX != 0) {
      goto label_1000_EA3A_1EA3A;
    }
    State.IncCycles();
    // OR BX,BX (1000_EA3F / 0x1EA3F)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JNZ 0x1000:ea74 (1000_EA41 / 0x1EA41)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_EA74 / 0x1EA74)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:dce0 (1000_EA43 / 0x1EA43)
    NearCall(cs1, 0xEA46, read_game_port_ida_1000_DCE0_1DCE0);
    State.IncCycles();
    // MOV AX,DX (1000_EA46 / 0x1EA46)
    AX = DX;
    State.IncCycles();
    // SUB AX,0x4 (1000_EA48 / 0x1EA48)
    AX -= 0x4;
    State.IncCycles();
    // CMP AH,0x4 (1000_EA4B / 0x1EA4B)
    Alu.Sub8(AH, 0x4);
    State.IncCycles();
    // JNC 0x1000:e9f3 (1000_EA4E / 0x1EA4E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,BX (1000_EA50 / 0x1EA50)
    AX = BX;
    State.IncCycles();
    // SUB AX,0x4 (1000_EA52 / 0x1EA52)
    AX -= 0x4;
    State.IncCycles();
    // CMP AH,0x4 (1000_EA55 / 0x1EA55)
    Alu.Sub8(AH, 0x4);
    State.IncCycles();
    // JNC 0x1000:e9f3 (1000_EA58 / 0x1EA58)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,DX (1000_EA5A / 0x1EA5A)
    AX = DX;
    State.IncCycles();
    // SHR AX,1 (1000_EA5C / 0x1EA5C)
    AX >>= 0x1;
    State.IncCycles();
    // ADD DX,AX (1000_EA5E / 0x1EA5E)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    State.IncCycles();
    // MOV SI,0x39ab (1000_EA60 / 0x1EA60)
    SI = 0x39AB;
    State.IncCycles();
    // MOV word ptr [SI],AX (1000_EA63 / 0x1EA63)
    UInt16[DS, SI] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0x2],DX (1000_EA65 / 0x1EA65)
    UInt16[DS, (ushort)(SI + 0x2)] = DX;
    State.IncCycles();
    // MOV AX,BX (1000_EA68 / 0x1EA68)
    AX = BX;
    State.IncCycles();
    // SHR AX,1 (1000_EA6A / 0x1EA6A)
    AX >>= 0x1;
    State.IncCycles();
    // ADD BX,AX (1000_EA6C / 0x1EA6C)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    State.IncCycles();
    // MOV word ptr [SI + 0x4],AX (1000_EA6E / 0x1EA6E)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    State.IncCycles();
    // MOV word ptr [SI + 0x6],BX (1000_EA71 / 0x1EA71)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    State.IncCycles();
    label_1000_EA74_1EA74:
    // RET  (1000_EA74 / 0x1EA74)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_EA7B_01EA7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EA7B_1EA7B:
    // TEST byte ptr [0x2943],0x80 (1000_EA7B / 0x1EA7B)
    Alu.And8(UInt8[DS, 0x2943], 0x80);
    State.IncCycles();
    // JZ 0x1000:ea85 (1000_EA80 / 0x1EA80)
    if(ZeroFlag) {
      goto label_1000_EA85_1EA85;
    }
    State.IncCycles();
    // CALL 0x1000:eea0 (1000_EA82 / 0x1EA82)
    NearCall(cs1, 0xEA85, initialize_himem_sys_ida_1000_EEA0_1EEA0);
    State.IncCycles();
    label_1000_EA85_1EA85:
    // TEST byte ptr [0x2943],0x48 (1000_EA85 / 0x1EA85)
    Alu.And8(UInt8[DS, 0x2943], 0x48);
    State.IncCycles();
    // JZ 0x1000:ea8f (1000_EA8A / 0x1EA8A)
    if(ZeroFlag) {
      goto label_1000_EA8F_1EA8F;
    }
    State.IncCycles();
    // CALL 0x1000:ed4c (1000_EA8C / 0x1EA8C)
    NearCall(cs1, 0xEA8F, not_observed_1000_ED4C_01ED4C);
    State.IncCycles();
    label_1000_EA8F_1EA8F:
    // TEST byte ptr [0x2943],0xe8 (1000_EA8F / 0x1EA8F)
    Alu.And8(UInt8[DS, 0x2943], 0xE8);
    State.IncCycles();
    // JZ 0x1000:eab6 (1000_EA94 / 0x1EA94)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_EAB6 / 0x1EAB6)
      return NearRet();
    }
    State.IncCycles();
    // MOV DI,0xce6a (1000_EA96 / 0x1EA96)
    DI = 0xCE6A;
    State.IncCycles();
    // MOV CX,word ptr [0x39a9] (1000_EA99 / 0x1EA99)
    CX = UInt16[DS, 0x39A9];
    State.IncCycles();
    // MOV AX,0xb9 (1000_EA9D / 0x1EA9D)
    AX = 0xB9;
    State.IncCycles();
    // MOV [0xce70],AL (1000_EAA0 / 0x1EAA0)
    UInt8[DS, 0xCE70] = AL;
    State.IncCycles();
    // ADD CX,AX (1000_EAA3 / 0x1EAA3)
    CX += AX;
    State.IncCycles();
    // ADD CX,AX (1000_EAA5 / 0x1EAA5)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    // PUSH CX (1000_EAA7 / 0x1EAA7)
    Stack.Push(CX);
    State.IncCycles();
    // SHL CX,1 (1000_EAA8 / 0x1EAA8)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    State.IncCycles();
    // CALL 0x1000:f0f6 (1000_EAAA / 0x1EAAA)
    NearCall(cs1, 0xEAAD, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    State.IncCycles();
    // LES DI,[0xce6a] (1000_EAAD / 0x1EAAD)
    ES = UInt16[DS, 0xCE6C];
    DI = UInt16[DS, 0xCE6A];
    State.IncCycles();
    // POP CX (1000_EAB1 / 0x1EAB1)
    CX = Stack.Pop();
    State.IncCycles();
    // XOR AX,AX (1000_EAB2 / 0x1EAB2)
    AX = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_EAB4 / 0x1EAB4)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    label_1000_EAB6_1EAB6:
    // RET  (1000_EAB6 / 0x1EAB6)
    return NearRet();
  }
  
  public virtual Action memory_func_qq_ida_1000_EAB7_1EAB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EAB7_1EAB7:
    // CALL 0x1000:e270 (1000_EAB7 / 0x1EAB7)
    NearCall(cs1, 0xEABA, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    // PUSH DS (1000_EABA / 0x1EABA)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_EABB / 0x1EABB)
    Stack.Push(ES);
    State.IncCycles();
    // SUB SP,0x6 (1000_EABC / 0x1EABC)
    // SP -= 0x6;
    SP = Alu.Sub16(SP, 0x6);
    State.IncCycles();
    // MOV BP,SP (1000_EABF / 0x1EABF)
    BP = SP;
    State.IncCycles();
    // MOV [0xce6e],AX (1000_EAC1 / 0x1EAC1)
    UInt16[DS, 0xCE6E] = AX;
    State.IncCycles();
    // PUSH DI (1000_EAC4 / 0x1EAC4)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_EAC5 / 0x1EAC5)
    Stack.Push(ES);
    State.IncCycles();
    // LES DI,[0xce6a] (1000_EAC6 / 0x1EAC6)
    ES = UInt16[DS, 0xCE6C];
    DI = UInt16[DS, 0xCE6A];
    State.IncCycles();
    // MOV SI,AX (1000_EACA / 0x1EACA)
    SI = AX;
    State.IncCycles();
    // MOV AX,[0x39a9] (1000_EACC / 0x1EACC)
    AX = UInt16[DS, 0x39A9];
    State.IncCycles();
    // SHL AX,1 (1000_EACF / 0x1EACF)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV word ptr [BP + 0x0],AX (1000_EAD1 / 0x1EAD1)
    UInt16[SS, BP] = AX;
    State.IncCycles();
    // SHL SI,1 (1000_EAD4 / 0x1EAD4)
    SI <<= 0x1;
    State.IncCycles();
    // ADD SI,AX (1000_EAD6 / 0x1EAD6)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV DX,SI (1000_EAD8 / 0x1EAD8)
    DX = SI;
    State.IncCycles();
    // MOV AX,CS:[0xea75] (1000_EADA / 0x1EADA)
    AX = UInt16[cs1, 0xEA75];
    State.IncCycles();
    // INC AX (1000_EADE / 0x1EADE)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV word ptr ES:[SI + 0x172],AX (1000_EADF / 0x1EADF)
    UInt16[ES, (ushort)(SI + 0x172)] = AX;
    State.IncCycles();
    // MOV CS:[0xea75],AX (1000_EAE4 / 0x1EAE4)
    UInt16[cs1, 0xEA75] = AX;
    State.IncCycles();
    // MOV word ptr [BP + 0x2],CX (1000_EAE8 / 0x1EAE8)
    UInt16[SS, (ushort)(BP + 0x2)] = CX;
    State.IncCycles();
    // POP DS (1000_EAEB / 0x1EAEB)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_EAEC / 0x1EAEC)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_EAED_1EAED:
    // CMP DI,word ptr [BP + 0x0] (1000_EAED / 0x1EAED)
    Alu.Sub16(DI, UInt16[SS, BP]);
    State.IncCycles();
    // JC 0x1000:eaf4 (1000_EAF0 / 0x1EAF0)
    if(CarryFlag) {
      goto label_1000_EAF4_1EAF4;
    }
    State.IncCycles();
    label_1000_EAF2_1EAF2:
    // XOR DI,DI (1000_EAF2 / 0x1EAF2)
    DI = 0;
    State.IncCycles();
    label_1000_EAF4_1EAF4:
    // MOV CX,word ptr [BP + 0x0] (1000_EAF4 / 0x1EAF4)
    CX = UInt16[SS, BP];
    State.IncCycles();
    // SUB CX,DI (1000_EAF7 / 0x1EAF7)
    CX -= DI;
    State.IncCycles();
    // SHR CX,1 (1000_EAF9 / 0x1EAF9)
    CX >>= 0x1;
    State.IncCycles();
    // XOR AX,AX (1000_EAFB / 0x1EAFB)
    AX = 0;
    State.IncCycles();
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASW ES:DI (1000_EAFD / 0x1EAFD)
      Alu.Sub16(AX, UInt16[ES, DI]);
      DI = (ushort)(DI + Direction16);
      if(ZeroFlag != false) {
        break;
      }
    }
    State.IncCycles();
    // JZ 0x1000:eb08 (1000_EAFF / 0x1EAFF)
    if(ZeroFlag) {
      goto label_1000_EB08_1EB08;
    }
    State.IncCycles();
    // CALL 0x1000:eb74 (1000_EB01 / 0x1EB01)
    NearCall(cs1, 0xEB04, not_observed_1000_EB74_01EB74);
    State.IncCycles();
    // JC 0x1000:eaf2 (1000_EB04 / 0x1EB04)
    if(CarryFlag) {
      goto label_1000_EAF2_1EAF2;
    }
    State.IncCycles();
    // JMP 0x1000:eb60 (1000_EB06 / 0x1EB06)
    goto label_1000_EB60_1EB60;
    State.IncCycles();
    label_1000_EB08_1EB08:
    // SUB DI,0x2 (1000_EB08 / 0x1EB08)
    DI -= 0x2;
    State.IncCycles();
    // XOR CX,CX (1000_EB0B / 0x1EB0B)
    CX = 0;
    State.IncCycles();
    // MOV BX,DI (1000_EB0D / 0x1EB0D)
    BX = DI;
    State.IncCycles();
    // SHR BX,1 (1000_EB0F / 0x1EB0F)
    BX >>= 0x1;
    State.IncCycles();
    // INC BX (1000_EB11 / 0x1EB11)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // MOV word ptr [BP + 0x4],BX (1000_EB12 / 0x1EB12)
    UInt16[SS, (ushort)(BP + 0x4)] = BX;
    State.IncCycles();
    // JMP 0x1000:eb28 (1000_EB15 / 0x1EB15)
    goto label_1000_EB28_1EB28;
    State.IncCycles();
    label_1000_EB17_1EB17:
    // MOV DI,DX (1000_EB17 / 0x1EB17)
    DI = DX;
    State.IncCycles();
    // ADD DI,0x2 (1000_EB19 / 0x1EB19)
    DI += 0x2;
    State.IncCycles();
    // CMP DI,word ptr [BP + 0x0] (1000_EB1C / 0x1EB1C)
    Alu.Sub16(DI, UInt16[SS, BP]);
    State.IncCycles();
    // JNC 0x1000:eb3f (1000_EB1F / 0x1EB1F)
    if(!CarryFlag) {
      goto label_1000_EB3F_1EB3F;
    }
    State.IncCycles();
    // CMP word ptr ES:[DI],0x0 (1000_EB21 / 0x1EB21)
    Alu.Sub16(UInt16[ES, DI], 0x0);
    State.IncCycles();
    // JNZ 0x1000:eb3f (1000_EB25 / 0x1EB25)
    if(!ZeroFlag) {
      goto label_1000_EB3F_1EB3F;
    }
    State.IncCycles();
    // INC BX (1000_EB27 / 0x1EB27)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    label_1000_EB28_1EB28:
    // XCHG DX,DI (1000_EB28 / 0x1EB28)
    ushort tmp_1000_EB28 = DX;
    DX = DI;
    DI = tmp_1000_EB28;
    State.IncCycles();
    // MOV word ptr ES:[DI],BX (1000_EB2A / 0x1EB2A)
    UInt16[ES, DI] = BX;
    State.IncCycles();
    // MOV AX,0x400 (1000_EB2D / 0x1EB2D)
    AX = 0x400;
    State.IncCycles();
    // ADD CX,AX (1000_EB30 / 0x1EB30)
    CX += AX;
    State.IncCycles();
    // SUB word ptr [BP + 0x2],AX (1000_EB32 / 0x1EB32)
    // UInt16[SS, (ushort)(BP + 0x2)] -= AX;
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], AX);
    State.IncCycles();
    // JA 0x1000:eb17 (1000_EB35 / 0x1EB35)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_EB17_1EB17;
    }
    State.IncCycles();
    // MOV DI,DX (1000_EB37 / 0x1EB37)
    DI = DX;
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (1000_EB39 / 0x1EB39)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // STOSW ES:DI (1000_EB3C / 0x1EB3C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    State.IncCycles();
    // ADD CX,AX (1000_EB3D / 0x1EB3D)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    label_1000_EB3F_1EB3F:
    // MOV BX,word ptr [BP + 0x4] (1000_EB3F / 0x1EB3F)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    State.IncCycles();
    // PUSH DX (1000_EB42 / 0x1EB42)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:ec59 (1000_EB43 / 0x1EB43)
    NearCall(cs1, 0xEB46, call_memory_func_1_ida_1000_EC59_1EC59);
    State.IncCycles();
    // POP DX (1000_EB46 / 0x1EB46)
    DX = Stack.Pop();
    State.IncCycles();
    // MOV DI,DX (1000_EB47 / 0x1EB47)
    DI = DX;
    State.IncCycles();
    // OR word ptr ES:[DI],0x8000 (1000_EB49 / 0x1EB49)
    // UInt16[ES, DI] |= 0x8000;
    UInt16[ES, DI] = Alu.Or16(UInt16[ES, DI], 0x8000);
    State.IncCycles();
    // MOV AX,word ptr [BP + 0x2] (1000_EB4E / 0x1EB4E)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    State.IncCycles();
    // DEC AX (1000_EB51 / 0x1EB51)
    AX--;
    State.IncCycles();
    // CMP AX,0xfc00 (1000_EB52 / 0x1EB52)
    Alu.Sub16(AX, 0xFC00);
    State.IncCycles();
    // JBE 0x1000:eaed (1000_EB55 / 0x1EB55)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_EAED_1EAED;
    }
    State.IncCycles();
    label_1000_EB57_1EB57:
    // ADD SP,0x6 (1000_EB57 / 0x1EB57)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    State.IncCycles();
    // POP ES (1000_EB5A / 0x1EB5A)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (1000_EB5B / 0x1EB5B)
    DS = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:e283 (1000_EB5C / 0x1EB5C)
    NearCall(cs1, 0xEB5F, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    // RET  (1000_EB5F / 0x1EB5F)
    return NearRet();
    State.IncCycles();
    label_1000_EB60_1EB60:
    // MOV SI,word ptr [BP + 0x0] (1000_EB60 / 0x1EB60)
    SI = UInt16[SS, BP];
    State.IncCycles();
    // MOV AX,0xffff (1000_EB63 / 0x1EB63)
    AX = 0xFFFF;
    State.IncCycles();
    // XCHG word ptr SS:[0xce6e],AX (1000_EB66 / 0x1EB66)
    ushort tmp_1000_EB66 = UInt16[SS, 0xCE6E];
    UInt16[SS, 0xCE6E] = AX;
    AX = tmp_1000_EB66;
    State.IncCycles();
    // ADD SI,AX (1000_EB6B / 0x1EB6B)
    SI += AX;
    State.IncCycles();
    // ADD SI,AX (1000_EB6D / 0x1EB6D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // CALL 0x1000:ebaa (1000_EB6F / 0x1EB6F)
    NearCall(cs1, 0xEB72, not_observed_1000_EBAA_01EBAA);
    State.IncCycles();
    // JMP 0x1000:eb57 (1000_EB72 / 0x1EB72)
    goto label_1000_EB57_1EB57;
  }
  
  public virtual Action not_observed_1000_EB74_01EB74(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EB74_1EB74:
    // PUSH DX (1000_EB74 / 0x1EB74)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH SI (1000_EB75 / 0x1EB75)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,word ptr [BP + 0x0] (1000_EB76 / 0x1EB76)
    SI = UInt16[SS, BP];
    State.IncCycles();
    // MOV CX,0xb9 (1000_EB79 / 0x1EB79)
    CX = 0xB9;
    State.IncCycles();
    // MOV DX,word ptr CS:[0xea75] (1000_EB7C / 0x1EB7C)
    DX = UInt16[cs1, 0xEA75];
    State.IncCycles();
    // XOR BX,BX (1000_EB81 / 0x1EB81)
    BX = 0;
    State.IncCycles();
    label_1000_EB83_1EB83:
    // MOV AX,word ptr ES:[SI] (1000_EB83 / 0x1EB83)
    AX = UInt16[ES, SI];
    State.IncCycles();
    // OR AX,AX (1000_EB86 / 0x1EB86)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:eb99 (1000_EB88 / 0x1EB88)
    if(ZeroFlag) {
      goto label_1000_EB99_1EB99;
    }
    State.IncCycles();
    // MOV AX,DX (1000_EB8A / 0x1EB8A)
    AX = DX;
    State.IncCycles();
    // SUB AX,word ptr ES:[SI + 0x172] (1000_EB8C / 0x1EB8C)
    AX -= UInt16[ES, (ushort)(SI + 0x172)];
    State.IncCycles();
    // CMP AX,BX (1000_EB91 / 0x1EB91)
    Alu.Sub16(AX, BX);
    State.IncCycles();
    // JC 0x1000:eb99 (1000_EB93 / 0x1EB93)
    if(CarryFlag) {
      goto label_1000_EB99_1EB99;
    }
    State.IncCycles();
    // MOV DI,SI (1000_EB95 / 0x1EB95)
    DI = SI;
    State.IncCycles();
    // MOV BX,AX (1000_EB97 / 0x1EB97)
    BX = AX;
    State.IncCycles();
    label_1000_EB99_1EB99:
    // ADD SI,0x2 (1000_EB99 / 0x1EB99)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    State.IncCycles();
    // LOOP 0x1000:eb83 (1000_EB9C / 0x1EB9C)
    if(--CX != 0) {
      goto label_1000_EB83_1EB83;
    }
    State.IncCycles();
    // OR BX,BX (1000_EB9E / 0x1EB9E)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    State.IncCycles();
    // JZ 0x1000:eba7 (1000_EBA0 / 0x1EBA0)
    if(ZeroFlag) {
      goto label_1000_EBA7_1EBA7;
    }
    State.IncCycles();
    // MOV SI,DI (1000_EBA2 / 0x1EBA2)
    SI = DI;
    State.IncCycles();
    // CALL 0x1000:ebaa (1000_EBA4 / 0x1EBA4)
    NearCall(cs1, 0xEBA7, not_observed_1000_EBAA_01EBAA);
    State.IncCycles();
    label_1000_EBA7_1EBA7:
    // POP SI (1000_EBA7 / 0x1EBA7)
    SI = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_EBA8 / 0x1EBA8)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_EBA9 / 0x1EBA9)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_EBAA_01EBAA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EBAA_1EBAA:
    // XOR BX,BX (1000_EBAA / 0x1EBAA)
    BX = 0;
    State.IncCycles();
    // XCHG word ptr ES:[SI],BX (1000_EBAC / 0x1EBAC)
    ushort tmp_1000_EBAC = UInt16[ES, SI];
    UInt16[ES, SI] = BX;
    BX = tmp_1000_EBAC;
    State.IncCycles();
    // SHL BX,1 (1000_EBAF / 0x1EBAF)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // MOV SI,BX (1000_EBB1 / 0x1EBB1)
    SI = BX;
    State.IncCycles();
    // DEC SI (1000_EBB3 / 0x1EBB3)
    SI--;
    State.IncCycles();
    // DEC SI (1000_EBB4 / 0x1EBB4)
    SI = Alu.Dec16(SI);
    State.IncCycles();
    // JNC 0x1000:ebaa (1000_EBB5 / 0x1EBB5)
    if(!CarryFlag) {
      goto label_1000_EBAA_1EBAA;
    }
    State.IncCycles();
    // RET  (1000_EBB7 / 0x1EBB7)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_EBE3_01EBE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EBE3_1EBE3:
    // PUSH DX (1000_EBE3 / 0x1EBE3)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH DS (1000_EBE4 / 0x1EBE4)
    Stack.Push(DS);
    State.IncCycles();
    // MOV SI,word ptr [0x39a9] (1000_EBE5 / 0x1EBE5)
    SI = UInt16[DS, 0x39A9];
    State.IncCycles();
    // MOV DS,word ptr [0xce6c] (1000_EBE9 / 0x1EBE9)
    DS = UInt16[DS, 0xCE6C];
    State.IncCycles();
    // ADD SI,AX (1000_EBED / 0x1EBED)
    SI += AX;
    State.IncCycles();
    // SHL SI,1 (1000_EBEF / 0x1EBEF)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_EBF1 / 0x1EBF1)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // OR AX,AX (1000_EBF3 / 0x1EBF3)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:ec43 (1000_EBF5 / 0x1EBF5)
    if(ZeroFlag) {
      goto label_1000_EC43_1EC43;
    }
    State.IncCycles();
    // MOV BX,AX (1000_EBF7 / 0x1EBF7)
    BX = AX;
    State.IncCycles();
    // MOV AX,CS:[0xea75] (1000_EBF9 / 0x1EBF9)
    AX = UInt16[cs1, 0xEA75];
    State.IncCycles();
    // INC AX (1000_EBFD / 0x1EBFD)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV word ptr [SI + 0x172],AX (1000_EBFE / 0x1EBFE)
    UInt16[DS, (ushort)(SI + 0x172)] = AX;
    State.IncCycles();
    // MOV CS:[0xea75],AX (1000_EC02 / 0x1EC02)
    UInt16[cs1, 0xEA75] = AX;
    State.IncCycles();
    // MOV AX,BX (1000_EC06 / 0x1EC06)
    AX = BX;
    State.IncCycles();
    // PUSH DI (1000_EC08 / 0x1EC08)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH ES (1000_EC09 / 0x1EC09)
    Stack.Push(ES);
    State.IncCycles();
    label_1000_EC0A_1EC0A:
    // MOV BX,AX (1000_EC0A / 0x1EC0A)
    BX = AX;
    State.IncCycles();
    // MOV DX,AX (1000_EC0C / 0x1EC0C)
    DX = AX;
    State.IncCycles();
    // XOR CX,CX (1000_EC0E / 0x1EC0E)
    CX = 0;
    State.IncCycles();
    label_1000_EC10_1EC10:
    // ADD CX,0x400 (1000_EC10 / 0x1EC10)
    CX += 0x400;
    State.IncCycles();
    // SHL AX,1 (1000_EC14 / 0x1EC14)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JC 0x1000:ec33 (1000_EC16 / 0x1EC16)
    if(CarryFlag) {
      goto label_1000_EC33_1EC33;
    }
    State.IncCycles();
    // MOV SI,AX (1000_EC18 / 0x1EC18)
    SI = AX;
    State.IncCycles();
    // SUB SI,0x2 (1000_EC1A / 0x1EC1A)
    SI -= 0x2;
    State.IncCycles();
    // INC DX (1000_EC1D / 0x1EC1D)
    DX = Alu.Inc16(DX);
    State.IncCycles();
    // MOV AX,word ptr [SI] (1000_EC1E / 0x1EC1E)
    AX = UInt16[DS, SI];
    State.IncCycles();
    // CMP AX,DX (1000_EC20 / 0x1EC20)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // JZ 0x1000:ec10 (1000_EC22 / 0x1EC22)
    if(ZeroFlag) {
      goto label_1000_EC10_1EC10;
    }
    State.IncCycles();
    // SHL AX,1 (1000_EC24 / 0x1EC24)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // JC 0x1000:ec33 (1000_EC26 / 0x1EC26)
    if(CarryFlag) {
      goto label_1000_EC33_1EC33;
    }
    State.IncCycles();
    // SHR AX,1 (1000_EC28 / 0x1EC28)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // PUSH AX (1000_EC2A / 0x1EC2A)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:ec46 (1000_EC2B / 0x1EC2B)
    NearCall(cs1, 0xEC2E, call_memory_func_2_ida_1000_EC46_1EC46);
    State.IncCycles();
    // POP AX (1000_EC2E / 0x1EC2E)
    AX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:ec3a (1000_EC2F / 0x1EC2F)
    if(CarryFlag) {
      goto label_1000_EC3A_1EC3A;
    }
    State.IncCycles();
    // JMP 0x1000:ec0a (1000_EC31 / 0x1EC31)
    goto label_1000_EC0A_1EC0A;
    State.IncCycles();
    label_1000_EC33_1EC33:
    // SAR AX,1 (1000_EC33 / 0x1EC33)
    AX = Alu.Sar16(AX, 0x1);
    State.IncCycles();
    // ADD CX,AX (1000_EC35 / 0x1EC35)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    State.IncCycles();
    // CALL 0x1000:ec46 (1000_EC37 / 0x1EC37)
    NearCall(cs1, 0xEC3A, call_memory_func_2_ida_1000_EC46_1EC46);
    State.IncCycles();
    label_1000_EC3A_1EC3A:
    // MOV CX,DI (1000_EC3A / 0x1EC3A)
    CX = DI;
    State.IncCycles();
    // POP ES (1000_EC3C / 0x1EC3C)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_EC3D / 0x1EC3D)
    DI = Stack.Pop();
    State.IncCycles();
    // PUSHF  (1000_EC3E / 0x1EC3E)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // SUB CX,DI (1000_EC3F / 0x1EC3F)
    CX -= DI;
    State.IncCycles();
    // POPF  (1000_EC41 / 0x1EC41)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // CMC  (1000_EC42 / 0x1EC42)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    label_1000_EC43_1EC43:
    // POP DS (1000_EC43 / 0x1EC43)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DX (1000_EC44 / 0x1EC44)
    DX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_EC45 / 0x1EC45)
    return NearRet();
  }
  
  public virtual Action call_memory_func_2_ida_1000_EC46_1EC46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EC46_1EC46:
    // PUSH CX (1000_EC46 / 0x1EC46)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH DI (1000_EC47 / 0x1EC47)
    Stack.Push(DI);
    State.IncCycles();
    // PUSH DS (1000_EC48 / 0x1EC48)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_EC49 / 0x1EC49)
    Stack.Push(ES);
    State.IncCycles();
    // DEC BX (1000_EC4A / 0x1EC4A)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // CALL word ptr CS:[0xea79] (1000_EC4B / 0x1EC4B)
    // Indirect call to word ptr CS:[0xea79], generating possible targets from emulator records
    uint targetAddress_1000_EC4B = (uint)(UInt16[cs1, 0xEA79]);
    switch(targetAddress_1000_EC4B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EC4B));
        break;
    }
    State.IncCycles();
    // POP ES (1000_EC50 / 0x1EC50)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (1000_EC51 / 0x1EC51)
    DS = Stack.Pop();
    State.IncCycles();
    // POP DI (1000_EC52 / 0x1EC52)
    DI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_EC53 / 0x1EC53)
    CX = Stack.Pop();
    State.IncCycles();
    // PUSHF  (1000_EC54 / 0x1EC54)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // ADD DI,CX (1000_EC55 / 0x1EC55)
    DI += CX;
    State.IncCycles();
    // POPF  (1000_EC57 / 0x1EC57)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_EC58 / 0x1EC58)
    return NearRet();
  }
  
  public virtual Action call_memory_func_1_ida_1000_EC59_1EC59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EC59_1EC59:
    // PUSH SI (1000_EC59 / 0x1EC59)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_EC5A / 0x1EC5A)
    Stack.Push(DS);
    State.IncCycles();
    // PUSH ES (1000_EC5B / 0x1EC5B)
    Stack.Push(ES);
    State.IncCycles();
    // PUSH CX (1000_EC5C / 0x1EC5C)
    Stack.Push(CX);
    State.IncCycles();
    // DEC BX (1000_EC5D / 0x1EC5D)
    BX = Alu.Dec16(BX);
    State.IncCycles();
    // CALL word ptr CS:[0xea77] (1000_EC5E / 0x1EC5E)
    // Indirect call to word ptr CS:[0xea77], generating possible targets from emulator records
    uint targetAddress_1000_EC5E = (uint)(UInt16[cs1, 0xEA77]);
    switch(targetAddress_1000_EC5E) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EC5E));
        break;
    }
    State.IncCycles();
    // POP AX (1000_EC63 / 0x1EC63)
    AX = Stack.Pop();
    State.IncCycles();
    // POP ES (1000_EC64 / 0x1EC64)
    ES = Stack.Pop();
    State.IncCycles();
    // POP DS (1000_EC65 / 0x1EC65)
    DS = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_EC66 / 0x1EC66)
    SI = Stack.Pop();
    State.IncCycles();
    // PUSHF  (1000_EC67 / 0x1EC67)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // ADD SI,AX (1000_EC68 / 0x1EC68)
    SI += AX;
    State.IncCycles();
    // POPF  (1000_EC6A / 0x1EC6A)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // RET  (1000_EC6B / 0x1EC6B)
    return NearRet();
  }
  
  public virtual Action xms_memory_func_1_ida_1000_EC9C_1EC9C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_EC9C_1EC9C:
    // MOV DI,0xec6c (1000_EC9C / 0x1EC9C)
    DI = 0xEC6C;
    State.IncCycles();
    // INC CX (1000_EC9F / 0x1EC9F)
    CX++;
    State.IncCycles();
    // SHR CX,1 (1000_ECA0 / 0x1ECA0)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // PUSH CX (1000_ECA2 / 0x1ECA2)
    Stack.Push(CX);
    State.IncCycles();
    // SHL CX,1 (1000_ECA3 / 0x1ECA3)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x10],CX (1000_ECA5 / 0x1ECA5)
    UInt16[cs1, (ushort)(DI + 0x10)] = CX;
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x18],CX (1000_ECA9 / 0x1ECA9)
    UInt16[cs1, (ushort)(DI + 0x18)] = CX;
    State.IncCycles();
    // MOV AX,DS (1000_ECAD / 0x1ECAD)
    AX = DS;
    State.IncCycles();
    // XOR DX,DX (1000_ECAF / 0x1ECAF)
    DX = 0;
    State.IncCycles();
    // MOV CX,0x4 (1000_ECB1 / 0x1ECB1)
    CX = 0x4;
    State.IncCycles();
    label_1000_ECB4_1ECB4:
    // SHL AX,1 (1000_ECB4 / 0x1ECB4)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // RCL DX,1 (1000_ECB6 / 0x1ECB6)
    DX = Alu.Rcl16(DX, 0x1);
    State.IncCycles();
    // LOOP 0x1000:ecb4 (1000_ECB8 / 0x1ECB8)
    if(--CX != 0) {
      goto label_1000_ECB4_1ECB4;
    }
    State.IncCycles();
    // ADD AX,SI (1000_ECBA / 0x1ECBA)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    State.IncCycles();
    // ADC DX,0x0 (1000_ECBC / 0x1ECBC)
    DX = Alu.Adc16(DX, 0x0);
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x12],AX (1000_ECBF / 0x1ECBF)
    UInt16[cs1, (ushort)(DI + 0x12)] = AX;
    State.IncCycles();
    // MOV DH,0x92 (1000_ECC3 / 0x1ECC3)
    DH = 0x92;
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x14],DX (1000_ECC5 / 0x1ECC5)
    UInt16[cs1, (ushort)(DI + 0x14)] = DX;
    State.IncCycles();
    // XOR DL,DL (1000_ECC9 / 0x1ECC9)
    DL = 0;
    State.IncCycles();
    // XCHG BH,BL (1000_ECCB / 0x1ECCB)
    byte tmp_1000_ECCB = BH;
    BH = BL;
    BL = tmp_1000_ECCB;
    State.IncCycles();
    // XCHG DL,BL (1000_ECCD / 0x1ECCD)
    byte tmp_1000_ECCD = DL;
    DL = BL;
    BL = tmp_1000_ECCD;
    State.IncCycles();
    // SHL BX,1 (1000_ECCF / 0x1ECCF)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // RCL DL,1 (1000_ECD1 / 0x1ECD1)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // SHL BX,1 (1000_ECD3 / 0x1ECD3)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // RCL DL,1 (1000_ECD5 / 0x1ECD5)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // ADD DL,0x10 (1000_ECD7 / 0x1ECD7)
    // DL += 0x10;
    DL = Alu.Add8(DL, 0x10);
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x1a],BX (1000_ECDA / 0x1ECDA)
    UInt16[cs1, (ushort)(DI + 0x1A)] = BX;
    State.IncCycles();
    // MOV word ptr CS:[DI + 0x1c],DX (1000_ECDE / 0x1ECDE)
    UInt16[cs1, (ushort)(DI + 0x1C)] = DX;
    State.IncCycles();
    // MOV SI,DI (1000_ECE2 / 0x1ECE2)
    SI = DI;
    State.IncCycles();
    // PUSH CS (1000_ECE4 / 0x1ECE4)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_ECE5 / 0x1ECE5)
    ES = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_ECE6 / 0x1ECE6)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV AH,0x87 (1000_ECE7 / 0x1ECE7)
    AH = 0x87;
    State.IncCycles();
    // INT 0x15 (1000_ECE9 / 0x1ECE9)
    Interrupt(0x15);
    State.IncCycles();
    // RET  (1000_ECEB / 0x1ECEB)
    return NearRet();
  }
  
  public virtual Action xms_memory_func_1_ida_1000_ECEC_1ECEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_ECEC_1ECEC:
    // MOV SI,0xec6c (1000_ECEC / 0x1ECEC)
    SI = 0xEC6C;
    State.IncCycles();
    // INC CX (1000_ECEF / 0x1ECEF)
    CX++;
    State.IncCycles();
    // SHR CX,1 (1000_ECF0 / 0x1ECF0)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    State.IncCycles();
    // PUSH CX (1000_ECF2 / 0x1ECF2)
    Stack.Push(CX);
    State.IncCycles();
    // SHL CX,1 (1000_ECF3 / 0x1ECF3)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x10],CX (1000_ECF5 / 0x1ECF5)
    UInt16[cs1, (ushort)(SI + 0x10)] = CX;
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x18],CX (1000_ECF9 / 0x1ECF9)
    UInt16[cs1, (ushort)(SI + 0x18)] = CX;
    State.IncCycles();
    // MOV AX,ES (1000_ECFD / 0x1ECFD)
    AX = ES;
    State.IncCycles();
    // XOR DX,DX (1000_ECFF / 0x1ECFF)
    DX = 0;
    State.IncCycles();
    // MOV CX,0x4 (1000_ED01 / 0x1ED01)
    CX = 0x4;
    State.IncCycles();
    label_1000_ED04_1ED04:
    // SHL AX,1 (1000_ED04 / 0x1ED04)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // RCL DX,1 (1000_ED06 / 0x1ED06)
    DX = Alu.Rcl16(DX, 0x1);
    State.IncCycles();
    // LOOP 0x1000:ed04 (1000_ED08 / 0x1ED08)
    if(--CX != 0) {
      goto label_1000_ED04_1ED04;
    }
    State.IncCycles();
    // ADD AX,DI (1000_ED0A / 0x1ED0A)
    // AX += DI;
    AX = Alu.Add16(AX, DI);
    State.IncCycles();
    // ADC DX,0x0 (1000_ED0C / 0x1ED0C)
    DX = Alu.Adc16(DX, 0x0);
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x1a],AX (1000_ED0F / 0x1ED0F)
    UInt16[cs1, (ushort)(SI + 0x1A)] = AX;
    State.IncCycles();
    // MOV DH,0x92 (1000_ED13 / 0x1ED13)
    DH = 0x92;
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x1c],DX (1000_ED15 / 0x1ED15)
    UInt16[cs1, (ushort)(SI + 0x1C)] = DX;
    State.IncCycles();
    // XOR DL,DL (1000_ED19 / 0x1ED19)
    DL = 0;
    State.IncCycles();
    // XCHG BH,BL (1000_ED1B / 0x1ED1B)
    byte tmp_1000_ED1B = BH;
    BH = BL;
    BL = tmp_1000_ED1B;
    State.IncCycles();
    // XCHG DL,BL (1000_ED1D / 0x1ED1D)
    byte tmp_1000_ED1D = DL;
    DL = BL;
    BL = tmp_1000_ED1D;
    State.IncCycles();
    // SHL BX,1 (1000_ED1F / 0x1ED1F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // RCL DL,1 (1000_ED21 / 0x1ED21)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // SHL BX,1 (1000_ED23 / 0x1ED23)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    State.IncCycles();
    // RCL DL,1 (1000_ED25 / 0x1ED25)
    DL = Alu.Rcl8(DL, 0x1);
    State.IncCycles();
    // ADD DL,0x10 (1000_ED27 / 0x1ED27)
    // DL += 0x10;
    DL = Alu.Add8(DL, 0x10);
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x12],BX (1000_ED2A / 0x1ED2A)
    UInt16[cs1, (ushort)(SI + 0x12)] = BX;
    State.IncCycles();
    // MOV word ptr CS:[SI + 0x14],DX (1000_ED2E / 0x1ED2E)
    UInt16[cs1, (ushort)(SI + 0x14)] = DX;
    State.IncCycles();
    // PUSH CS (1000_ED32 / 0x1ED32)
    Stack.Push(cs1);
    State.IncCycles();
    // POP ES (1000_ED33 / 0x1ED33)
    ES = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_ED34 / 0x1ED34)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV AH,0x87 (1000_ED35 / 0x1ED35)
    AH = 0x87;
    State.IncCycles();
    // INT 0x15 (1000_ED37 / 0x1ED37)
    Interrupt(0x15);
    State.IncCycles();
    // RET  (1000_ED39 / 0x1ED39)
    return NearRet();
  }
  
}
