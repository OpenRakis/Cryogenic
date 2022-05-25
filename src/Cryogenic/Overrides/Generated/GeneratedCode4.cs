namespace Cryogenic.Overrides;

using Spice86.Emulator.Function;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_316E_01316E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_316E_1316E:
    // MOV AL,byte ptr [SI + 0x3] (1000_316E / 0x1316E)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // MOV AH,0x2 (1000_3171 / 0x13171)
    AH = 0x2;
    State.IncCycles();
    // TEST AL,0x20 (1000_3173 / 0x13173)
    Alu.And8(AL, 0x20);
    State.IncCycles();
    // JZ 0x1000:3181 (1000_3175 / 0x13175)
    if(ZeroFlag) {
      goto label_1000_3181_13181;
    }
    State.IncCycles();
    // CMP byte ptr [DI + 0x8],0x28 (1000_3177 / 0x13177)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    State.IncCycles();
    // JC 0x1000:3190 (1000_317B / 0x1317B)
    if(CarryFlag) {
      goto label_1000_3190_13190;
    }
    State.IncCycles();
    // INC AH (1000_317D / 0x1317D)
    AH = Alu.Inc8(AH);
    State.IncCycles();
    // JMP 0x1000:3190 (1000_317F / 0x1317F)
    goto label_1000_3190_13190;
    State.IncCycles();
    label_1000_3181_13181:
    // TEST byte ptr [SI + 0x10],0x80 (1000_3181 / 0x13181)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:316d (1000_3185 / 0x13185)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_316D / 0x1316D)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x2b],0x0 (1000_3187 / 0x13187)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JZ 0x1000:3190 (1000_318C / 0x1318C)
    if(ZeroFlag) {
      goto label_1000_3190_13190;
    }
    State.IncCycles();
    // DEC AH (1000_318E / 0x1318E)
    AH--;
    State.IncCycles();
    label_1000_3190_13190:
    // CMP AH,DL (1000_3190 / 0x13190)
    Alu.Sub8(AH, DL);
    State.IncCycles();
    // JNZ 0x1000:316d (1000_3192 / 0x13192)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_316D / 0x1316D)
      return NearRet();
    }
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_3194 / 0x13194)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:31c9 (1000_3198 / 0x13198)
    if(!ZeroFlag) {
      goto label_1000_31C9_131C9;
    }
    State.IncCycles();
    // MOV BP,0x10b8 (1000_319A / 0x1319A)
    BP = 0x10B8;
    State.IncCycles();
    // MOV DI,0x4756 (1000_319D / 0x1319D)
    DI = 0x4756;
    State.IncCycles();
    // CMP AL,0x80 (1000_31A0 / 0x131A0)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JNC 0x1000:31ed (1000_31A2 / 0x131A2)
    if(!CarryFlag) {
      goto label_1000_31ED_131ED;
    }
    State.IncCycles();
    // MOV BP,0x10c8 (1000_31A4 / 0x131A4)
    BP = 0x10C8;
    State.IncCycles();
    // MOV DI,0x4758 (1000_31A7 / 0x131A7)
    DI = 0x4758;
    State.IncCycles();
    // AND byte ptr [0x476a],0x7 (1000_31AA / 0x131AA)
    // UInt8[DS, 0x476A] &= 0x7;
    UInt8[DS, 0x476A] = Alu.And8(UInt8[DS, 0x476A], 0x7);
    State.IncCycles();
    // MOV AL,[0x476a] (1000_31AF / 0x131AF)
    AL = UInt8[DS, 0x476A];
    State.IncCycles();
    // INC byte ptr [0x476a] (1000_31B2 / 0x131B2)
    UInt8[DS, 0x476A]++;
    State.IncCycles();
    // XOR AH,AH (1000_31B6 / 0x131B6)
    AH = 0;
    State.IncCycles();
    // CMP SI,0x8e0 (1000_31B8 / 0x131B8)
    Alu.Sub16(SI, 0x8E0);
    State.IncCycles();
    // JNZ 0x1000:31c3 (1000_31BC / 0x131BC)
    if(!ZeroFlag) {
      goto label_1000_31C3_131C3;
    }
    State.IncCycles();
    // INC AX (1000_31BE / 0x131BE)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV [0x476b],AL (1000_31BF / 0x131BF)
    UInt8[DS, 0x476B] = AL;
    State.IncCycles();
    // DEC AX (1000_31C2 / 0x131C2)
    AX--;
    State.IncCycles();
    label_1000_31C3_131C3:
    // SHL AX,1 (1000_31C3 / 0x131C3)
    AX <<= 0x1;
    State.IncCycles();
    // ADD DI,AX (1000_31C5 / 0x131C5)
    // DI += AX;
    DI = Alu.Add16(DI, AX);
    State.IncCycles();
    // JMP 0x1000:31ed (1000_31C7 / 0x131C7)
    goto label_1000_31ED_131ED;
    State.IncCycles();
    label_1000_31C9_131C9:
    // MOV BP,0x1098 (1000_31C9 / 0x131C9)
    BP = 0x1098;
    State.IncCycles();
    // MOV DI,0x4768 (1000_31CC / 0x131CC)
    DI = 0x4768;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_31CF / 0x131CF)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // AND AL,0x10 (1000_31D2 / 0x131D2)
    AL &= 0x10;
    State.IncCycles();
    // AND byte ptr [BP + 0xf],0xef (1000_31D4 / 0x131D4)
    // UInt8[SS, (ushort)(BP + 0xF)] &= 0xEF;
    UInt8[SS, (ushort)(BP + 0xF)] = Alu.And8(UInt8[SS, (ushort)(BP + 0xF)], 0xEF);
    State.IncCycles();
    // OR byte ptr [BP + 0xf],AL (1000_31D8 / 0x131D8)
    // UInt8[SS, (ushort)(BP + 0xF)] |= AL;
    UInt8[SS, (ushort)(BP + 0xF)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xF)], AL);
    State.IncCycles();
    // MOV word ptr [0xee],0x0 (1000_31DB / 0x131DB)
    UInt16[DS, 0xEE] = 0x0;
    State.IncCycles();
    // OR AL,AL (1000_31E1 / 0x131E1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // MOV AL,0xff (1000_31E3 / 0x131E3)
    AL = 0xFF;
    State.IncCycles();
    // JNZ 0x1000:31ea (1000_31E5 / 0x131E5)
    if(!ZeroFlag) {
      goto label_1000_31EA_131EA;
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x15] (1000_31E7 / 0x131E7)
    AL = UInt8[DS, (ushort)(SI + 0x15)];
    State.IncCycles();
    label_1000_31EA_131EA:
    // MOV [0xed],AL (1000_31EA / 0x131EA)
    UInt8[DS, 0xED] = AL;
    State.IncCycles();
    label_1000_31ED_131ED:
    // MOV word ptr [DI],SI (1000_31ED / 0x131ED)
    UInt16[DS, DI] = SI;
    State.IncCycles();
    // MOV word ptr [BP + 0x0],DX (1000_31EF / 0x131EF)
    UInt16[SS, BP] = DX;
    State.IncCycles();
    // MOV word ptr [BP + 0x2],BX (1000_31F2 / 0x131F2)
    UInt16[SS, (ushort)(BP + 0x2)] = BX;
    State.IncCycles();
    // RET  (1000_31F5 / 0x131F5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_31F6_0131F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_31F6_131F6:
    // CALL 0x1000:e270 (1000_31F6 / 0x131F6)
    NearCall(cs1, 0x31F9, spice86_generated_label_call_target_1000_E270_01E270);
    State.IncCycles();
    label_1000_31F9_131F9:
    // MOV DI,word ptr [SI + 0x4] (1000_31F9 / 0x131F9)
    DI = UInt16[DS, (ushort)(SI + 0x4)];
    State.IncCycles();
    // MOV word ptr [0x2c],DI (1000_31FC / 0x131FC)
    UInt16[DS, 0x2C] = DI;
    State.IncCycles();
    // MOV AL,byte ptr [SI] (1000_3200 / 0x13200)
    AL = UInt8[DS, SI];
    State.IncCycles();
    // MOV [0x2e],AL (1000_3202 / 0x13202)
    UInt8[DS, 0x2E] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_3205 / 0x13205)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // MOV [0x30],AL (1000_3208 / 0x13208)
    UInt8[DS, 0x30] = AL;
    State.IncCycles();
    // AND AX,0xf (1000_320B / 0x1320B)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // MOV [0x2f],AL (1000_320E / 0x1320E)
    UInt8[DS, 0x2F] = AL;
    State.IncCycles();
    // ADD AX,0x18 (1000_3211 / 0x13211)
    // AX += 0x18;
    AX = Alu.Add16(AX, 0x18);
    State.IncCycles();
    // MOV [0x11f3],AX (1000_3214 / 0x13214)
    UInt16[DS, 0x11F3] = AX;
    State.IncCycles();
    // CALL 0x1000:32c7 (1000_3217 / 0x13217)
    NearCall(cs1, 0x321A, spice86_generated_label_call_target_1000_32C7_0132C7);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_321D_1321D:
    // MOV [0x48],AX (1000_321D / 0x1321D)
    UInt16[DS, 0x48] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x10] (1000_3220 / 0x13220)
    AX = UInt16[DS, (ushort)(SI + 0x10)];
    State.IncCycles();
    // MOV [0x32],AX (1000_3223 / 0x13223)
    UInt16[DS, 0x32] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x12] (1000_3226 / 0x13226)
    AX = UInt16[DS, (ushort)(SI + 0x12)];
    State.IncCycles();
    // MOV [0x34],AX (1000_3229 / 0x13229)
    UInt16[DS, 0x34] = AX;
    State.IncCycles();
    // AND AX,0xf (1000_322C / 0x1322C)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // MOV [0x31],AL (1000_322F / 0x1322F)
    UInt8[DS, 0x31] = AL;
    State.IncCycles();
    // ADD AX,0x0 (1000_3232 / 0x13232)
    // AX += 0x0;
    AX = Alu.Add16(AX, 0x0);
    State.IncCycles();
    // MOV [0x11ff],AX (1000_3235 / 0x13235)
    UInt16[DS, 0x11FF] = AX;
    State.IncCycles();
    // CALL 0x1000:6efd (1000_3238 / 0x13238)
    NearCall(cs1, 0x323B, spice86_generated_label_call_target_1000_6EFD_016EFD);
    State.IncCycles();
    label_1000_323B_1323B:
    // MOV [0x36],AL (1000_323B / 0x1323B)
    UInt8[DS, 0x36] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x16] (1000_323E / 0x1323E)
    AL = UInt8[DS, (ushort)(SI + 0x16)];
    State.IncCycles();
    // MOV [0x38],AL (1000_3241 / 0x13241)
    UInt8[DS, 0x38] = AL;
    State.IncCycles();
    // CALL 0x1000:3310 (1000_3244 / 0x13244)
    NearCall(cs1, 0x3247, spice86_generated_label_call_target_1000_3310_013310);
    State.IncCycles();
    label_1000_3247_13247:
    // MOV [0x11f7],AX (1000_3247 / 0x13247)
    UInt16[DS, 0x11F7] = AX;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x17] (1000_324A / 0x1324A)
    AL = UInt8[DS, (ushort)(SI + 0x17)];
    State.IncCycles();
    // MOV [0x39],AL (1000_324D / 0x1324D)
    UInt8[DS, 0x39] = AL;
    State.IncCycles();
    // CALL 0x1000:3310 (1000_3250 / 0x13250)
    NearCall(cs1, 0x3253, spice86_generated_label_call_target_1000_3310_013310);
    State.IncCycles();
    label_1000_3253_13253:
    // MOV [0x11f9],AX (1000_3253 / 0x13253)
    UInt16[DS, 0x11F9] = AX;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x18] (1000_3256 / 0x13256)
    AL = UInt8[DS, (ushort)(SI + 0x18)];
    State.IncCycles();
    // MOV [0x3a],AL (1000_3259 / 0x13259)
    UInt8[DS, 0x3A] = AL;
    State.IncCycles();
    // CALL 0x1000:3310 (1000_325C / 0x1325C)
    NearCall(cs1, 0x325F, spice86_generated_label_call_target_1000_3310_013310);
    State.IncCycles();
    label_1000_325F_1325F:
    // MOV [0x11fb],AX (1000_325F / 0x1325F)
    UInt16[DS, 0x11FB] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0xc] (1000_3262 / 0x13262)
    AX = UInt16[DS, (ushort)(SI + 0xC)];
    State.IncCycles();
    // MOV [0x44],AX (1000_3265 / 0x13265)
    UInt16[DS, 0x44] = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0xe] (1000_3268 / 0x13268)
    AX = UInt16[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV [0x46],AX (1000_326B / 0x1326B)
    UInt16[DS, 0x46] = AX;
    State.IncCycles();
    // XOR AH,AH (1000_326E / 0x1326E)
    AH = 0;
    State.IncCycles();
    // ADD AX,0xe8 (1000_3270 / 0x13270)
    // AX += 0xE8;
    AX = Alu.Add16(AX, 0xE8);
    State.IncCycles();
    // MOV [0x11f1],AX (1000_3273 / 0x13273)
    UInt16[DS, 0x11F1] = AX;
    State.IncCycles();
    // CALL 0x1000:693b (1000_3276 / 0x13276)
    NearCall(cs1, 0x3279, spice86_generated_label_call_target_1000_693B_01693B);
    State.IncCycles();
    label_1000_3279_13279:
    // MOV BP,AX (1000_3279 / 0x13279)
    BP = AX;
    State.IncCycles();
    // MOV AL,byte ptr [BP + SI + 0x16] (1000_327B / 0x1327B)
    AL = UInt8[SS, (ushort)(BP + SI + 0x16)];
    State.IncCycles();
    // MOV [0x37],AL (1000_327E / 0x1327E)
    UInt8[DS, 0x37] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x19] (1000_3281 / 0x13281)
    AL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // MOV [0x3b],AL (1000_3284 / 0x13284)
    UInt8[DS, 0x3B] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x1a] (1000_3287 / 0x13287)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    State.IncCycles();
    // MOV [0x3c],AL (1000_328A / 0x1328A)
    UInt8[DS, 0x3C] = AL;
    State.IncCycles();
    // CALL 0x1000:1ac5 (1000_328D / 0x1328D)
    NearCall(cs1, 0x3290, spice86_generated_label_call_target_1000_1AC5_011AC5);
    State.IncCycles();
    label_1000_3290_13290:
    // SUB AL,byte ptr [SI + 0x14] (1000_3290 / 0x13290)
    // AL -= UInt8[DS, (ushort)(SI + 0x14)];
    AL = Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x14)]);
    State.IncCycles();
    // MOV [0x40],AL (1000_3293 / 0x13293)
    UInt8[DS, 0x40] = AL;
    State.IncCycles();
    // CALL 0x1000:331e (1000_3296 / 0x13296)
    NearCall(cs1, 0x3299, spice86_generated_label_call_target_1000_331E_01331E);
    State.IncCycles();
    label_1000_3299_13299:
    // CALL 0x1000:e283 (1000_3299 / 0x13299)
    NearCall(cs1, 0x329C, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_329C_1329C:
    // RET  (1000_329C / 0x1329C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_329D_01329D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_329D_1329D:
    // CMP byte ptr [SI + 0x3],0x0 (1000_329D / 0x1329D)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x3)], 0x0);
    State.IncCycles();
    // JZ 0x1000:32aa (1000_32A1 / 0x132A1)
    if(ZeroFlag) {
      goto label_1000_32AA_132AA;
    }
    State.IncCycles();
    // XOR AX,AX (1000_32A3 / 0x132A3)
    AX = 0;
    State.IncCycles();
    // AND word ptr [SI + 0x10],0xfff3 (1000_32A5 / 0x132A5)
    // UInt16[DS, (ushort)(SI + 0x10)] &= 0xFFF3;
    UInt16[DS, (ushort)(SI + 0x10)] = Alu.And16(UInt16[DS, (ushort)(SI + 0x10)], 0xFFF3);
    State.IncCycles();
    // RET  (1000_32A9 / 0x132A9)
    return NearRet();
    State.IncCycles();
    label_1000_32AA_132AA:
    // MOV AX,[0x42] (1000_32AA / 0x132AA)
    AX = UInt16[DS, 0x42];
    State.IncCycles();
    // OR AX,AX (1000_32AD / 0x132AD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JZ 0x1000:32c1 (1000_32AF / 0x132AF)
    if(ZeroFlag) {
      goto label_1000_32C1_132C1;
    }
    State.IncCycles();
    // MOV CX,AX (1000_32B1 / 0x132B1)
    CX = AX;
    State.IncCycles();
    // MOV AX,word ptr [SI + 0xe] (1000_32B3 / 0x132B3)
    AX = UInt16[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // XOR DX,DX (1000_32B6 / 0x132B6)
    DX = 0;
    State.IncCycles();
    // DIV CX (1000_32B8 / 0x132B8)
    Cpu.Div16(CX);
    State.IncCycles();
    // SHL DX,1 (1000_32BA / 0x132BA)
    DX <<= 0x1;
    State.IncCycles();
    // CMP CX,DX (1000_32BC / 0x132BC)
    Alu.Sub16(CX, DX);
    State.IncCycles();
    // ADC AX,0x0 (1000_32BE / 0x132BE)
    AX = Alu.Adc16(AX, 0x0);
    State.IncCycles();
    label_1000_32C1_132C1:
    // MOV [0x4a],AX (1000_32C1 / 0x132C1)
    UInt16[DS, 0x4A] = AX;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_32C7_132C7:
    // MOV AX,[0x2] (1000_32C7 / 0x132C7)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // SUB AX,word ptr [SI + 0xa] (1000_32CA / 0x132CA)
    // AX -= UInt16[DS, (ushort)(SI + 0xA)];
    AX = Alu.Sub16(AX, UInt16[DS, (ushort)(SI + 0xA)]);
    State.IncCycles();
    // MOV [0x42],AX (1000_32CD / 0x132CD)
    UInt16[DS, 0x42] = AX;
    State.IncCycles();
    // MOV DX,AX (1000_32D0 / 0x132D0)
    DX = AX;
    State.IncCycles();
    // MOV CL,0x4 (1000_32D2 / 0x132D2)
    CL = 0x4;
    State.IncCycles();
    // SHR AX,CL (1000_32D4 / 0x132D4)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    State.IncCycles();
    // MOV [0x41],AL (1000_32D6 / 0x132D6)
    UInt8[DS, 0x41] = AL;
    State.IncCycles();
    // MOV AX,0x74 (1000_32D9 / 0x132D9)
    AX = 0x74;
    State.IncCycles();
    // TEST byte ptr [SI + 0x3],0x10 (1000_32DC / 0x132DC)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x10);
    State.IncCycles();
    // JNZ 0x1000:330c (1000_32E0 / 0x132E0)
    if(!ZeroFlag) {
      goto label_1000_330C_1330C;
    }
    State.IncCycles();
    // MOV AX,0x70 (1000_32E2 / 0x132E2)
    AX = 0x70;
    State.IncCycles();
    // CMP DX,0x3 (1000_32E5 / 0x132E5)
    Alu.Sub16(DX, 0x3);
    State.IncCycles();
    // JC 0x1000:330c (1000_32E8 / 0x132E8)
    if(CarryFlag) {
      goto label_1000_330C_1330C;
    }
    State.IncCycles();
    // INC AX (1000_32EA / 0x132EA)
    AX++;
    State.IncCycles();
    // CMP DX,0x10 (1000_32EB / 0x132EB)
    Alu.Sub16(DX, 0x10);
    State.IncCycles();
    // JC 0x1000:330c (1000_32EE / 0x132EE)
    if(CarryFlag) {
      goto label_1000_330C_1330C;
    }
    State.IncCycles();
    // INC AX (1000_32F0 / 0x132F0)
    AX++;
    State.IncCycles();
    // CMP DX,0x20 (1000_32F1 / 0x132F1)
    Alu.Sub16(DX, 0x20);
    State.IncCycles();
    // JC 0x1000:330c (1000_32F4 / 0x132F4)
    if(CarryFlag) {
      goto label_1000_330C_1330C;
    }
    State.IncCycles();
    // INC AX (1000_32F6 / 0x132F6)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // PUSH AX (1000_32F7 / 0x132F7)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH SI (1000_32F8 / 0x132F8)
    Stack.Push(SI);
    State.IncCycles();
    // MOV SI,AX (1000_32F9 / 0x132F9)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:cf70 (1000_32FB / 0x132FB)
    NearCall(cs1, 0x32FE, spice86_generated_label_call_target_1000_CF70_01CF70);
    State.IncCycles();
    // CALL 0x1000:d03c (1000_32FE / 0x132FE)
    NearCall(cs1, 0x3301, spice86_generated_label_call_target_1000_D03C_01D03C);
    State.IncCycles();
    // MOV AX,DX (1000_3301 / 0x13301)
    AX = DX;
    State.IncCycles();
    // MOV CL,0x4 (1000_3303 / 0x13303)
    CL = 0x4;
    State.IncCycles();
    // SHR AX,CL (1000_3305 / 0x13305)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    State.IncCycles();
    // CALL 0x1000:e2e3 (1000_3307 / 0x13307)
    NearCall(cs1, 0x330A, spice86_generated_label_call_target_1000_E2E3_01E2E3);
    State.IncCycles();
    // POP SI (1000_330A / 0x1330A)
    SI = Stack.Pop();
    State.IncCycles();
    // POP AX (1000_330B / 0x1330B)
    AX = Stack.Pop();
    State.IncCycles();
    label_1000_330C_1330C:
    // MOV [0x11f5],AX (1000_330C / 0x1330C)
    UInt16[DS, 0x11F5] = AX;
    State.IncCycles();
    // RET  (1000_330F / 0x1330F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3310_013310(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3310_13310:
    // XOR AH,AH (1000_3310 / 0x13310)
    AH = 0;
    State.IncCycles();
    // SHR AX,1 (1000_3312 / 0x13312)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_3314 / 0x13314)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_3316 / 0x13316)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_3318 / 0x13318)
    AX >>= 0x1;
    State.IncCycles();
    // ADD AX,0xd1 (1000_331A / 0x1331A)
    // AX += 0xD1;
    AX = Alu.Add16(AX, 0xD1);
    State.IncCycles();
    // RET  (1000_331D / 0x1331D)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_331E_01331E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_331E_1331E:
    // MOV word ptr [0x11ce],DI (1000_331E / 0x1331E)
    UInt16[DS, 0x11CE] = DI;
    State.IncCycles();
    // PUSH SI (1000_3322 / 0x13322)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DI (1000_3323 / 0x13323)
    Stack.Push(DI);
    State.IncCycles();
    // MOV AH,byte ptr [DI] (1000_3324 / 0x13324)
    AH = UInt8[DS, DI];
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x1] (1000_3326 / 0x13326)
    AL = UInt8[DS, (ushort)(DI + 0x1)];
    State.IncCycles();
    // MOV [0x4e],AX (1000_3329 / 0x13329)
    UInt16[DS, 0x4E] = AX;
    State.IncCycles();
    // MOV BX,0x1141 (1000_332C / 0x1332C)
    BX = 0x1141;
    State.IncCycles();
    // XLAT BX (1000_332F / 0x1332F)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // MOV [0x50],AL (1000_3330 / 0x13330)
    UInt8[DS, 0x50] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0xa] (1000_3333 / 0x13333)
    AL = UInt8[DS, (ushort)(DI + 0xA)];
    State.IncCycles();
    // MOV [0x51],AL (1000_3336 / 0x13336)
    UInt8[DS, 0x51] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x12] (1000_3339 / 0x13339)
    AL = UInt8[DS, (ushort)(DI + 0x12)];
    State.IncCycles();
    // MOV [0x52],AL (1000_333C / 0x1333C)
    UInt8[DS, 0x52] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x1b] (1000_333F / 0x1333F)
    AL = UInt8[DS, (ushort)(DI + 0x1B)];
    State.IncCycles();
    // MOV [0x54],AL (1000_3342 / 0x13342)
    UInt8[DS, 0x54] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [DI + 0x8] (1000_3345 / 0x13345)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    State.IncCycles();
    // MOV [0x4d],AL (1000_3348 / 0x13348)
    UInt8[DS, 0x4D] = AL;
    State.IncCycles();
    // PUSH DS (1000_334B / 0x1334B)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_334C / 0x1334C)
    ES = Stack.Pop();
    State.IncCycles();
    // PUSH DI (1000_334D / 0x1334D)
    Stack.Push(DI);
    State.IncCycles();
    // LEA SI,[DI + 0x14] (1000_334E / 0x1334E)
    SI = (ushort)(DI + 0x14);
    State.IncCycles();
    // MOV DI,0x55 (1000_3351 / 0x13351)
    DI = 0x55;
    State.IncCycles();
    // MOV CX,0x7 (1000_3354 / 0x13354)
    CX = 0x7;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_3357 / 0x13357)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DI (1000_3359 / 0x13359)
    DI = Stack.Pop();
    State.IncCycles();
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
    State.IncCycles();
    label_1000_335D_1335D:
    // CALL 0x1000:34a5 (1000_335D / 0x1335D)
    NearCall(cs1, 0x3360, spice86_generated_label_call_target_1000_34A5_0134A5);
    State.IncCycles();
    label_1000_3360_13360:
    // CALL 0x1000:7f27 (1000_3360 / 0x13360)
    NearCall(cs1, 0x3363, spice86_generated_label_call_target_1000_7F27_017F27);
    State.IncCycles();
    label_1000_3363_13363:
    // MOV DI,0x46fe (1000_3363 / 0x13363)
    DI = 0x46FE;
    State.IncCycles();
    // MOV AL,0xff (1000_3366 / 0x13366)
    AL = 0xFF;
    State.IncCycles();
    // MOV CX,0x7 (1000_3368 / 0x13368)
    CX = 0x7;
    State.IncCycles();
    label_1000_336B_1336B:
    // CMP byte ptr [DI],0x1 (1000_336B / 0x1336B)
    Alu.Sub8(UInt8[DS, DI], 0x1);
    State.IncCycles();
    // RCL AL,1 (1000_336E / 0x1336E)
    AL = Alu.Rcl8(AL, 0x1);
    State.IncCycles();
    // INC DI (1000_3370 / 0x13370)
    DI = Alu.Inc16(DI);
    State.IncCycles();
    // LOOP 0x1000:336b (1000_3371 / 0x13371)
    if(--CX != 0) {
      goto label_1000_336B_1336B;
    }
    State.IncCycles();
    // NOT AL (1000_3373 / 0x13373)
    AL = (byte)~AL;
    State.IncCycles();
    // MOV CL,0x1 (1000_3375 / 0x13375)
    CL = 0x1;
    State.IncCycles();
    // SHL AL,CL (1000_3377 / 0x13377)
    // AL <<= CL;
    AL = Alu.Shl8(AL, CL);
    State.IncCycles();
    // MOV [0x53],AL (1000_3379 / 0x13379)
    UInt8[DS, 0x53] = AL;
    State.IncCycles();
    // POP DI (1000_337C / 0x1337C)
    DI = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:3385 (1000_337D / 0x1337D)
    NearCall(cs1, 0x3380, spice86_generated_label_call_target_1000_3385_013385);
    State.IncCycles();
    label_1000_3380_13380:
    // CALL 0x1000:5274 (1000_3380 / 0x13380)
    NearCall(cs1, 0x3383, spice86_generated_label_call_target_1000_5274_015274);
    State.IncCycles();
    label_1000_3383_13383:
    // POP SI (1000_3383 / 0x13383)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3384 / 0x13384)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3385_013385(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3385_13385:
    // MOV byte ptr [0xf7],0x0 (1000_3385 / 0x13385)
    UInt8[DS, 0xF7] = 0x0;
    State.IncCycles();
    // CMP DI,word ptr [0x1150] (1000_338A / 0x1338A)
    Alu.Sub16(DI, UInt16[DS, 0x1150]);
    State.IncCycles();
    // JZ 0x1000:33bd (1000_338E / 0x1338E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_33BD / 0x133BD)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,DI (1000_3390 / 0x13390)
    AX = DI;
    State.IncCycles();
    // SUB AX,0x100 (1000_3392 / 0x13392)
    // AX -= 0x100;
    AX = Alu.Sub16(AX, 0x100);
    State.IncCycles();
    // MOV BL,0x1c (1000_3395 / 0x13395)
    BL = 0x1C;
    State.IncCycles();
    // DIV BL (1000_3397 / 0x13397)
    Cpu.Div8(BL);
    State.IncCycles();
    // INC AX (1000_3399 / 0x13399)
    AX = Alu.Inc16(AX);
    State.IncCycles();
    // MOV BH,AL (1000_339A / 0x1339A)
    BH = AL;
    State.IncCycles();
    // MOV BL,0x80 (1000_339C / 0x1339C)
    BL = 0x80;
    State.IncCycles();
    // MOV SI,0x1018 (1000_339E / 0x1339E)
    SI = 0x1018;
    State.IncCycles();
    // CALL 0x1000:33ad (1000_33A1 / 0x133A1)
    NearCall(cs1, 0x33A4, not_observed_1000_33AD_0133AD);
    State.IncCycles();
    // MOV SI,0x1028 (1000_33A4 / 0x133A4)
    SI = 0x1028;
    State.IncCycles();
    // CALL 0x1000:33ad (1000_33A7 / 0x133A7)
    NearCall(cs1, 0x33AA, not_observed_1000_33AD_0133AD);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_33AD_133AD:
    // CMP BX,word ptr [SI + 0x2] (1000_33AD / 0x133AD)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:33bd (1000_33B0 / 0x133B0)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_33BD / 0x133BD)
      return NearRet();
    }
    State.IncCycles();
    // MOV CL,byte ptr [SI + 0xe] (1000_33B2 / 0x133B2)
    CL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // MOV AL,0x1 (1000_33B5 / 0x133B5)
    AL = 0x1;
    State.IncCycles();
    // SHL AL,CL (1000_33B7 / 0x133B7)
    // AL <<= CL;
    AL = Alu.Shl8(AL, CL);
    State.IncCycles();
    // OR byte ptr [0xf7],AL (1000_33B9 / 0x133B9)
    // UInt8[DS, 0xF7] |= AL;
    UInt8[DS, 0xF7] = Alu.Or8(UInt8[DS, 0xF7], AL);
    State.IncCycles();
    label_1000_33BD_133BD:
    // RET  (1000_33BD / 0x133BD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_33BE_0133BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_33BE_133BE:
    // XOR AX,AX (1000_33BE / 0x133BE)
    AX = 0;
    State.IncCycles();
    // MOV [0x94],AX (1000_33C0 / 0x133C0)
    UInt16[DS, 0x94] = AX;
    State.IncCycles();
    // MOV [0x96],AX (1000_33C3 / 0x133C3)
    UInt16[DS, 0x96] = AX;
    State.IncCycles();
    // MOV [0x5c],AX (1000_33C6 / 0x133C6)
    UInt16[DS, 0x5C] = AX;
    State.IncCycles();
    // MOV [0x5e],AX (1000_33C9 / 0x133C9)
    UInt16[DS, 0x5E] = AX;
    State.IncCycles();
    // MOV BP,0x3406 (1000_33CC / 0x133CC)
    BP = 0x3406;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_33D2_133D2:
    // CALL 0x1000:33d9 (1000_33D2 / 0x133D2)
    NearCall(cs1, 0x33D5, spice86_generated_label_call_target_1000_33D9_0133D9);
    State.IncCycles();
    label_1000_33D5_133D5:
    // MOV [0x9c],AL (1000_33D5 / 0x133D5)
    UInt8[DS, 0x9C] = AL;
    State.IncCycles();
    // RET  (1000_33D8 / 0x133D8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_33D9_0133D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_33D9_133D9:
    // MOV AX,[0x96] (1000_33D9 / 0x133D9)
    AX = UInt16[DS, 0x96];
    State.IncCycles();
    // MOV DX,word ptr [0x94] (1000_33DC / 0x133DC)
    DX = UInt16[DS, 0x94];
    State.IncCycles();
    // CMP AX,DX (1000_33E0 / 0x133E0)
    Alu.Sub16(AX, DX);
    State.IncCycles();
    // PUSHF  (1000_33E2 / 0x133E2)
    Stack.Push(FlagRegister);
    State.IncCycles();
    // JNC 0x1000:33e6 (1000_33E3 / 0x133E3)
    if(!CarryFlag) {
      goto label_1000_33E6_133E6;
    }
    State.IncCycles();
    // XCHG AX,DX (1000_33E5 / 0x133E5)
    ushort tmp_1000_33E5 = AX;
    AX = DX;
    DX = tmp_1000_33E5;
    State.IncCycles();
    label_1000_33E6_133E6:
    // MOV CX,DX (1000_33E6 / 0x133E6)
    CX = DX;
    State.IncCycles();
    // JCXZ 0x1000:33fd (1000_33E8 / 0x133E8)
    if(CX == 0) {
      goto label_1000_33FD_133FD;
    }
    State.IncCycles();
    // XOR DX,DX (1000_33EA / 0x133EA)
    DX = 0;
    State.IncCycles();
    // XCHG DL,AH (1000_33EC / 0x133EC)
    byte tmp_1000_33EC = DL;
    DL = AH;
    AH = tmp_1000_33EC;
    State.IncCycles();
    // XCHG AH,AL (1000_33EE / 0x133EE)
    byte tmp_1000_33EE = AH;
    AH = AL;
    AL = tmp_1000_33EE;
    State.IncCycles();
    // CMP DX,CX (1000_33F0 / 0x133F0)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JNC 0x1000:33fd (1000_33F2 / 0x133F2)
    if(!CarryFlag) {
      goto label_1000_33FD_133FD;
    }
    State.IncCycles();
    // DIV CX (1000_33F4 / 0x133F4)
    Cpu.Div16(CX);
    State.IncCycles();
    // SHR AX,1 (1000_33F6 / 0x133F6)
    AX >>= 0x1;
    State.IncCycles();
    // CMP AX,0xfc (1000_33F8 / 0x133F8)
    Alu.Sub16(AX, 0xFC);
    State.IncCycles();
    // JC 0x1000:3400 (1000_33FB / 0x133FB)
    if(CarryFlag) {
      goto label_1000_3400_13400;
    }
    State.IncCycles();
    label_1000_33FD_133FD:
    // MOV AX,0xfc (1000_33FD / 0x133FD)
    AX = 0xFC;
    State.IncCycles();
    label_1000_3400_13400:
    // POPF  (1000_3400 / 0x13400)
    FlagRegister = Stack.Pop();
    State.IncCycles();
    // JNC 0x1000:3405 (1000_3401 / 0x13401)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3405 / 0x13405)
      return NearRet();
    }
    State.IncCycles();
    // NEG AL (1000_3403 / 0x13403)
    AL = Alu.Sub8(0, AL);
    State.IncCycles();
    label_1000_3405_13405:
    // RET  (1000_3405 / 0x13405)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3406_013406(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3406_13406:
    // TEST byte ptr [SI + 0x3],0x20 (1000_3406 / 0x13406)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // JNZ 0x1000:342c (1000_340A / 0x1340A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_342C / 0x1342C)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:342d (1000_340C / 0x1340C)
    NearCall(cs1, 0x340F, spice86_generated_label_call_target_1000_342D_01342D);
    State.IncCycles();
    label_1000_340F_1340F:
    // TEST byte ptr [SI + 0x10],0x80 (1000_340F / 0x1340F)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:3428 (1000_3413 / 0x13413)
    if(!ZeroFlag) {
      goto label_1000_3428_13428;
    }
    State.IncCycles();
    // ADD word ptr [0x96],AX (1000_3415 / 0x13415)
    // UInt16[DS, 0x96] += AX;
    UInt16[DS, 0x96] = Alu.Add16(UInt16[DS, 0x96], AX);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x10] (1000_3419 / 0x13419)
    AX = UInt16[DS, (ushort)(SI + 0x10)];
    State.IncCycles();
    // OR word ptr [0x5c],AX (1000_341C / 0x1341C)
    // UInt16[DS, 0x5C] |= AX;
    UInt16[DS, 0x5C] = Alu.Or16(UInt16[DS, 0x5C], AX);
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x12] (1000_3420 / 0x13420)
    AX = UInt16[DS, (ushort)(SI + 0x12)];
    State.IncCycles();
    // OR word ptr [0x5e],AX (1000_3423 / 0x13423)
    // UInt16[DS, 0x5E] |= AX;
    UInt16[DS, 0x5E] = Alu.Or16(UInt16[DS, 0x5E], AX);
    State.IncCycles();
    // RET  (1000_3427 / 0x13427)
    return NearRet();
    State.IncCycles();
    label_1000_3428_13428:
    // ADD word ptr [0x94],AX (1000_3428 / 0x13428)
    // UInt16[DS, 0x94] += AX;
    UInt16[DS, 0x94] = Alu.Add16(UInt16[DS, 0x94], AX);
    State.IncCycles();
    label_1000_342C_1342C:
    // RET  (1000_342C / 0x1342C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_342D_01342D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_342D_1342D:
    // CALL 0x1000:6efd (1000_342D / 0x1342D)
    NearCall(cs1, 0x3430, spice86_generated_label_call_target_1000_6EFD_016EFD);
    State.IncCycles();
    label_1000_3430_13430:
    // XOR AH,AH (1000_3430 / 0x13430)
    AH = 0;
    State.IncCycles();
    // ADD AL,AL (1000_3432 / 0x13432)
    AL += AL;
    State.IncCycles();
    // ADD AL,byte ptr [SI + 0x17] (1000_3434 / 0x13434)
    // AL += UInt8[DS, (ushort)(SI + 0x17)];
    AL = Alu.Add8(AL, UInt8[DS, (ushort)(SI + 0x17)]);
    State.IncCycles();
    // JNC 0x1000:343b (1000_3437 / 0x13437)
    if(!CarryFlag) {
      goto label_1000_343B_1343B;
    }
    State.IncCycles();
    // MOV AL,0xff (1000_3439 / 0x13439)
    AL = 0xFF;
    State.IncCycles();
    label_1000_343B_1343B:
    // MUL byte ptr [SI + 0x1a] (1000_343B / 0x1343B)
    Cpu.Mul8(UInt8[DS, (ushort)(SI + 0x1A)]);
    State.IncCycles();
    // SHR AX,1 (1000_343E / 0x1343E)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_3440 / 0x13440)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_3442 / 0x13442)
    AX >>= 0x1;
    State.IncCycles();
    // SHR AX,1 (1000_3444 / 0x13444)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    State.IncCycles();
    // MOV DX,AX (1000_3446 / 0x13446)
    DX = AX;
    State.IncCycles();
    // MOV BL,byte ptr [SI + 0x19] (1000_3448 / 0x13448)
    BL = UInt8[DS, (ushort)(SI + 0x19)];
    State.IncCycles();
    // SHL BL,1 (1000_344B / 0x1344B)
    BL <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_344D / 0x1344D)
    BL <<= 0x1;
    State.IncCycles();
    // SHL DX,1 (1000_344F / 0x1344F)
    DX <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_3451 / 0x13451)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    State.IncCycles();
    // JNC 0x1000:3459 (1000_3453 / 0x13453)
    if(!CarryFlag) {
      goto label_1000_3459_13459;
    }
    State.IncCycles();
    // ADD AX,DX (1000_3455 / 0x13455)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // JC 0x1000:3477 (1000_3457 / 0x13457)
    if(CarryFlag) {
      goto label_1000_3477_13477;
    }
    State.IncCycles();
    label_1000_3459_13459:
    // SHL DX,1 (1000_3459 / 0x13459)
    DX <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_345B / 0x1345B)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    State.IncCycles();
    // JNC 0x1000:3463 (1000_345D / 0x1345D)
    if(!CarryFlag) {
      goto label_1000_3463_13463;
    }
    State.IncCycles();
    // ADD AX,DX (1000_345F / 0x1345F)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // JC 0x1000:3477 (1000_3461 / 0x13461)
    if(CarryFlag) {
      goto label_1000_3477_13477;
    }
    State.IncCycles();
    label_1000_3463_13463:
    // SHL DX,1 (1000_3463 / 0x13463)
    DX <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_3465 / 0x13465)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    State.IncCycles();
    // JNC 0x1000:346d (1000_3467 / 0x13467)
    if(!CarryFlag) {
      goto label_1000_346D_1346D;
    }
    State.IncCycles();
    // ADD AX,DX (1000_3469 / 0x13469)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // JC 0x1000:3477 (1000_346B / 0x1346B)
    if(CarryFlag) {
      goto label_1000_3477_13477;
    }
    State.IncCycles();
    label_1000_346D_1346D:
    // SHL DX,1 (1000_346D / 0x1346D)
    DX <<= 0x1;
    State.IncCycles();
    // SHL BL,1 (1000_346F / 0x1346F)
    // BL <<= 0x1;
    BL = Alu.Shl8(BL, 0x1);
    State.IncCycles();
    // JNC 0x1000:347a (1000_3471 / 0x13471)
    if(!CarryFlag) {
      goto label_1000_347A_1347A;
    }
    State.IncCycles();
    // ADD AX,DX (1000_3473 / 0x13473)
    // AX += DX;
    AX = Alu.Add16(AX, DX);
    State.IncCycles();
    // JNC 0x1000:347a (1000_3475 / 0x13475)
    if(!CarryFlag) {
      goto label_1000_347A_1347A;
    }
    State.IncCycles();
    label_1000_3477_13477:
    // MOV AX,0xffff (1000_3477 / 0x13477)
    AX = 0xFFFF;
    State.IncCycles();
    label_1000_347A_1347A:
    // MOV AL,AH (1000_347A / 0x1347A)
    AL = AH;
    State.IncCycles();
    // XOR AH,AH (1000_347C / 0x1347C)
    AH = 0;
    State.IncCycles();
    // OR AX,AX (1000_347E / 0x1347E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNZ 0x1000:3489 (1000_3480 / 0x13480)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3489 / 0x13489)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [SI + 0x1a],0x1 (1000_3482 / 0x13482)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0x1A)], 0x1);
    State.IncCycles();
    // CMC  (1000_3486 / 0x13486)
    CarryFlag = !CarryFlag;
    State.IncCycles();
    // ADC AL,AH (1000_3487 / 0x13487)
    AL = Alu.Adc8(AL, AH);
    State.IncCycles();
    label_1000_3489_13489:
    // RET  (1000_3489 / 0x13489)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_34A5_0134A5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_34A5_134A5:
    // PUSH SI (1000_34A5 / 0x134A5)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH DS (1000_34A6 / 0x134A6)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_34A7 / 0x134A7)
    ES = Stack.Pop();
    State.IncCycles();
    // PUSH DI (1000_34A8 / 0x134A8)
    Stack.Push(DI);
    State.IncCycles();
    // MOV DI,0x60 (1000_34A9 / 0x134A9)
    DI = 0x60;
    State.IncCycles();
    // MOV CX,0x33 (1000_34AC / 0x134AC)
    CX = 0x33;
    State.IncCycles();
    // XOR AL,AL (1000_34AF / 0x134AF)
    AL = 0;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_34B1 / 0x134B1)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    State.IncCycles();
    // POP DI (1000_34B3 / 0x134B3)
    DI = Stack.Pop();
    State.IncCycles();
    // MOV BP,0x34d0 (1000_34B4 / 0x134B4)
    BP = 0x34D0;
    State.IncCycles();
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
    State.IncCycles();
    label_1000_34BA_134BA:
    // MOV AL,[0x60] (1000_34BA / 0x134BA)
    AL = UInt8[DS, 0x60];
    State.IncCycles();
    // ADD AL,byte ptr [0x7e] (1000_34BD / 0x134BD)
    // AL += UInt8[DS, 0x7E];
    AL = Alu.Add8(AL, UInt8[DS, 0x7E]);
    State.IncCycles();
    // MOV [0x91],AL (1000_34C1 / 0x134C1)
    UInt8[DS, 0x91] = AL;
    State.IncCycles();
    // MOV AL,[0x61] (1000_34C4 / 0x134C4)
    AL = UInt8[DS, 0x61];
    State.IncCycles();
    // ADD AL,byte ptr [0x7f] (1000_34C7 / 0x134C7)
    // AL += UInt8[DS, 0x7F];
    AL = Alu.Add8(AL, UInt8[DS, 0x7F]);
    State.IncCycles();
    // MOV [0x92],AL (1000_34CB / 0x134CB)
    UInt8[DS, 0x92] = AL;
    State.IncCycles();
    // POP SI (1000_34CE / 0x134CE)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_34CF / 0x134CF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_34D0_0134D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_34D0_134D0:
    // TEST byte ptr [SI + 0x3],0x20 (1000_34D0 / 0x134D0)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x3)], 0x20);
    State.IncCycles();
    // JNZ 0x1000:351a (1000_34D4 / 0x134D4)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_351A / 0x1351A)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0x3] (1000_34D6 / 0x134D6)
    AL = UInt8[DS, (ushort)(SI + 0x3)];
    State.IncCycles();
    // MOV DX,0x61 (1000_34D9 / 0x134D9)
    DX = 0x61;
    State.IncCycles();
    // TEST AL,0x40 (1000_34DC / 0x134DC)
    Alu.And8(AL, 0x40);
    State.IncCycles();
    // JZ 0x1000:34e3 (1000_34DE / 0x134DE)
    if(ZeroFlag) {
      goto label_1000_34E3_134E3;
    }
    State.IncCycles();
    // MOV DX,0x7f (1000_34E0 / 0x134E0)
    DX = 0x7F;
    State.IncCycles();
    label_1000_34E3_134E3:
    // MOV BX,DX (1000_34E3 / 0x134E3)
    BX = DX;
    State.IncCycles();
    // TEST byte ptr [SI + 0x10],0x80 (1000_34E5 / 0x134E5)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    State.IncCycles();
    // JNZ 0x1000:34f0 (1000_34E9 / 0x134E9)
    if(!ZeroFlag) {
      goto label_1000_34F0_134F0;
    }
    State.IncCycles();
    // DEC BX (1000_34EB / 0x134EB)
    BX--;
    State.IncCycles();
    // CMP AL,0x80 (1000_34EC / 0x134EC)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // JZ 0x1000:351b (1000_34EE / 0x134EE)
    if(ZeroFlag) {
      goto label_1000_351B_1351B;
    }
    State.IncCycles();
    label_1000_34F0_134F0:
    // INC byte ptr [BX] (1000_34F0 / 0x134F0)
    UInt8[DS, BX] = Alu.Inc8(UInt8[DS, BX]);
    State.IncCycles();
    // MOV AH,AL (1000_34F2 / 0x134F2)
    AH = AL;
    State.IncCycles();
    // AND AX,0x30f (1000_34F4 / 0x134F4)
    AX &= 0x30F;
    State.IncCycles();
    // CMP AH,0x3 (1000_34F7 / 0x134F7)
    Alu.Sub8(AH, 0x3);
    State.IncCycles();
    // JNZ 0x1000:34fe (1000_34FA / 0x134FA)
    if(!ZeroFlag) {
      goto label_1000_34FE_134FE;
    }
    State.IncCycles();
    // AND AL,0xfc (1000_34FC / 0x134FC)
    AL &= 0xFC;
    State.IncCycles();
    label_1000_34FE_134FE:
    // XOR AH,AH (1000_34FE / 0x134FE)
    AH = 0;
    State.IncCycles();
    // MOV BX,DX (1000_3500 / 0x13500)
    BX = DX;
    State.IncCycles();
    // ADD BX,AX (1000_3502 / 0x13502)
    BX += AX;
    State.IncCycles();
    // INC byte ptr [BX + 0x1] (1000_3504 / 0x13504)
    UInt8[DS, (ushort)(BX + 0x1)]++;
    State.IncCycles();
    // CMP BX,0x7f (1000_3507 / 0x13507)
    Alu.Sub16(BX, 0x7F);
    State.IncCycles();
    // JNC 0x1000:351a (1000_350B / 0x1350B)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_351A / 0x1351A)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,word ptr [SI + 0x12] (1000_350D / 0x1350D)
    AX = UInt16[DS, (ushort)(SI + 0x12)];
    State.IncCycles();
    // AND AX,0xf (1000_3510 / 0x13510)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    State.IncCycles();
    // MOV BX,0x71 (1000_3513 / 0x13513)
    BX = 0x71;
    State.IncCycles();
    // ADD BX,AX (1000_3516 / 0x13516)
    BX += AX;
    State.IncCycles();
    // INC byte ptr [BX] (1000_3518 / 0x13518)
    UInt8[DS, BX] = Alu.Inc8(UInt8[DS, BX]);
    State.IncCycles();
    label_1000_351A_1351A:
    // RET  (1000_351A / 0x1351A)
    return NearRet();
    State.IncCycles();
    label_1000_351B_1351B:
    // INC byte ptr [0x90] (1000_351B / 0x1351B)
    UInt8[DS, 0x90] = Alu.Inc8(UInt8[DS, 0x90]);
    State.IncCycles();
    // RET  (1000_351F / 0x1351F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3520_013520(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3520_13520:
    // CMP byte ptr [0x47a7],0x0 (1000_3520 / 0x13520)
    Alu.Sub8(UInt8[DS, 0x47A7], 0x0);
    State.IncCycles();
    // JNZ 0x1000:351a (1000_3525 / 0x13525)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_351A / 0x1351A)
      return NearRet();
    }
    State.IncCycles();
    // MOV AL,byte ptr [SI + 0xe] (1000_3527 / 0x13527)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    State.IncCycles();
    // XOR AH,AH (1000_352A / 0x1352A)
    AH = 0;
    State.IncCycles();
    // PUSH SI (1000_352C / 0x1352C)
    Stack.Push(SI);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_3530_13530:
    // POP SI (1000_3530 / 0x13530)
    SI = Stack.Pop();
    State.IncCycles();
    // JNC 0x1000:3542 (1000_3531 / 0x13531)
    if(!CarryFlag) {
      goto label_1000_3542_13542;
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_3533 / 0x13533)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_3536 / 0x13536)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:2aaf (1000_353A / 0x1353A)
    NearCall(cs1, 0x353D, spice86_generated_label_call_target_1000_2AAF_012AAF);
    State.IncCycles();
    label_1000_353D_1353D:
    // JNC 0x1000:35ac (1000_353D / 0x1353D)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:2b00 (1000_353F / 0x1353F)
    NearCall(cs1, 0x3542, not_observed_1000_2B00_012B00);
    State.IncCycles();
    label_1000_3542_13542:
    // MOV AX,[0x47c4] (1000_3542 / 0x13542)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_3545 / 0x13545)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // CALL 0x1000:2a51 (1000_3549 / 0x13549)
    NearCall(cs1, 0x354C, spice86_generated_label_call_target_1000_2A51_012A51);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_3551_13551:
    // INC byte ptr [0x47a7] (1000_3551 / 0x13551)
    UInt8[DS, 0x47A7]++;
    State.IncCycles();
    // CMP byte ptr [0x23],0x3 (1000_3555 / 0x13555)
    Alu.Sub8(UInt8[DS, 0x23], 0x3);
    State.IncCycles();
    // JNZ 0x1000:3572 (1000_355A / 0x1355A)
    if(!ZeroFlag) {
      goto label_1000_3572_13572;
    }
    State.IncCycles();
    // MOV BP,0x1f92 (1000_355C / 0x1355C)
    BP = 0x1F92;
    State.IncCycles();
    // MOV BX,0x97cf (1000_355F / 0x1355F)
    BX = 0x97CF;
    State.IncCycles();
    // CALL 0x1000:d323 (1000_3562 / 0x13562)
    NearCall(cs1, 0x3565, spice86_generated_label_call_target_1000_D323_01D323);
    State.IncCycles();
    label_1000_3565_13565:
    // MOV word ptr [0x1bea],0x0 (1000_3565 / 0x13565)
    UInt16[DS, 0x1BEA] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x1bf8],0x0 (1000_356B / 0x1356B)
    UInt16[DS, 0x1BF8] = 0x0;
    State.IncCycles();
    // RET  (1000_3571 / 0x13571)
    return NearRet();
    State.IncCycles();
    label_1000_3572_13572:
    // CMP byte ptr [0x23],0x4 (1000_3572 / 0x13572)
    Alu.Sub8(UInt8[DS, 0x23], 0x4);
    State.IncCycles();
    // JNZ 0x1000:3595 (1000_3577 / 0x13577)
    if(!ZeroFlag) {
      goto label_1000_3595_13595;
    }
    State.IncCycles();
    // MOV BP,0x1f9e (1000_3579 / 0x13579)
    BP = 0x1F9E;
    State.IncCycles();
    // AND byte ptr [BP + 0xb],0xbf (1000_357C / 0x1357C)
    // UInt8[SS, (ushort)(BP + 0xB)] &= 0xBF;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.And8(UInt8[SS, (ushort)(BP + 0xB)], 0xBF);
    State.IncCycles();
    // MOV BX,0x97cf (1000_3580 / 0x13580)
    BX = 0x97CF;
    State.IncCycles();
    // CALL 0x1000:d323 (1000_3583 / 0x13583)
    NearCall(cs1, 0x3586, spice86_generated_label_call_target_1000_D323_01D323);
    State.IncCycles();
    // MOV word ptr [0x1bea],0x0 (1000_3586 / 0x13586)
    UInt16[DS, 0x1BEA] = 0x0;
    State.IncCycles();
    // MOV word ptr [0x1bf8],0x0 (1000_358C / 0x1358C)
    UInt16[DS, 0x1BF8] = 0x0;
    State.IncCycles();
    // JMP 0x1000:2ffb (1000_3592 / 0x13592)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2FFB_012FFB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_3595_13595:
    // CMP byte ptr [0x4774],0x0 (1000_3595 / 0x13595)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    State.IncCycles();
    // JNZ 0x1000:35ac (1000_359A / 0x1359A)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    State.IncCycles();
    // CMP byte ptr [0x23],0x64 (1000_359C / 0x1359C)
    Alu.Sub8(UInt8[DS, 0x23], 0x64);
    State.IncCycles();
    // JNC 0x1000:35ac (1000_35A1 / 0x135A1)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_35A3 / 0x135A3)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CALL 0x1000:93df (1000_35A6 / 0x135A6)
    NearCall(cs1, 0x35A9, spice86_generated_label_call_target_1000_93DF_0193DF);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_35AC_135AC:
    // RET  (1000_35AC / 0x135AC)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_35AD_0135AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_35AD_135AD:
    // CMP byte ptr [0x11c9],0x0 (1000_35AD / 0x135AD)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    State.IncCycles();
    // JNZ 0x1000:35e9 (1000_35B2 / 0x135B2)
    if(!ZeroFlag) {
      goto label_1000_35E9_135E9;
    }
    State.IncCycles();
    // XOR AX,AX (1000_35B4 / 0x135B4)
    AX = 0;
    State.IncCycles();
    // MOV [0x1a],AL (1000_35B6 / 0x135B6)
    UInt8[DS, 0x1A] = AL;
    State.IncCycles();
    // MOV [0x47a7],AL (1000_35B9 / 0x135B9)
    UInt8[DS, 0x47A7] = AL;
    State.IncCycles();
    // XCHG byte ptr [0x47a6],AL (1000_35BC / 0x135BC)
    byte tmp_1000_35BC = UInt8[DS, 0x47A6];
    UInt8[DS, 0x47A6] = AL;
    AL = tmp_1000_35BC;
    State.IncCycles();
    // OR AL,AL (1000_35C0 / 0x135C0)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:35ac (1000_35C2 / 0x135C2)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    State.IncCycles();
    // INC byte ptr [0x1a] (1000_35C4 / 0x135C4)
    UInt8[DS, 0x1A]++;
    State.IncCycles();
    // CMP byte ptr [0xb],0x8 (1000_35C8 / 0x135C8)
    Alu.Sub8(UInt8[DS, 0xB], 0x8);
    State.IncCycles();
    // JNZ 0x1000:35e3 (1000_35CD / 0x135CD)
    if(!ZeroFlag) {
      goto label_1000_35E3_135E3;
    }
    State.IncCycles();
    // MOV AX,[0xc0] (1000_35CF / 0x135CF)
    AX = UInt16[DS, 0xC0];
    State.IncCycles();
    // AND AX,word ptr [0x1158] (1000_35D2 / 0x135D2)
    // AX &= UInt16[DS, 0x1158];
    AX = Alu.And16(AX, UInt16[DS, 0x1158]);
    State.IncCycles();
    // JZ 0x1000:35e3 (1000_35D6 / 0x135D6)
    if(ZeroFlag) {
      goto label_1000_35E3_135E3;
    }
    State.IncCycles();
    // TEST word ptr [0x12],0x8 (1000_35D8 / 0x135D8)
    Alu.And16(UInt16[DS, 0x12], 0x8);
    State.IncCycles();
    // JZ 0x1000:35e3 (1000_35DE / 0x135DE)
    if(ZeroFlag) {
      goto label_1000_35E3_135E3;
    }
    State.IncCycles();
    // CALL 0x1000:2566 (1000_35E0 / 0x135E0)
    NearCall(cs1, 0x35E3, not_observed_1000_2566_012566);
    State.IncCycles();
    label_1000_35E3_135E3:
    // MOV BP,0x3520 (1000_35E3 / 0x135E3)
    BP = 0x3520;
    State.IncCycles();
    // JMP 0x1000:36ee (1000_35E6 / 0x135E6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_36EE_0136EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_35E9_135E9:
    // XOR AX,AX (1000_35E9 / 0x135E9)
    AX = 0;
    State.IncCycles();
    // MOV [0x1a],AL (1000_35EB / 0x135EB)
    UInt8[DS, 0x1A] = AL;
    State.IncCycles();
    // MOV [0x47a7],AL (1000_35EE / 0x135EE)
    UInt8[DS, 0x47A7] = AL;
    State.IncCycles();
    // MOV [0x23],AL (1000_35F1 / 0x135F1)
    UInt8[DS, 0x23] = AL;
    State.IncCycles();
    // XCHG byte ptr [0x47a6],AL (1000_35F4 / 0x135F4)
    byte tmp_1000_35F4 = UInt8[DS, 0x47A6];
    UInt8[DS, 0x47A6] = AL;
    AL = tmp_1000_35F4;
    State.IncCycles();
    // OR AL,AL (1000_35F8 / 0x135F8)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:35ac (1000_35FA / 0x135FA)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_35AC / 0x135AC)
      return NearRet();
    }
    State.IncCycles();
    // CMP word ptr [0x1152],-0x1 (1000_35FC / 0x135FC)
    Alu.Sub16(UInt16[DS, 0x1152], 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:3637 (1000_3601 / 0x13601)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3637_013637, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_3606_13606:
    // CALL 0x1000:4182 (1000_3606 / 0x13606)
    NearCall(cs1, 0x3609, spice86_generated_label_call_target_1000_4182_014182);
    State.IncCycles();
    label_1000_3609_13609:
    // CMP byte ptr [0x23],0x0 (1000_3609 / 0x13609)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    State.IncCycles();
    // JZ 0x1000:3636 (1000_360E / 0x1360E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:366f (1000_3610 / 0x13610)
    NearCall(cs1, 0x3613, spice86_generated_label_call_target_1000_366F_01366F);
    State.IncCycles();
    label_1000_3613_13613:
    // JS 0x1000:3636 (1000_3613 / 0x13613)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_3615 / 0x13615)
    NearCall(cs1, 0x3618, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    label_1000_3618_13618:
    // CALL 0x1000:368b (1000_3618 / 0x13618)
    NearCall(cs1, 0x361B, spice86_generated_label_call_target_1000_368B_01368B);
    State.IncCycles();
    label_1000_361B_1361B:
    // PUSH AX (1000_361B / 0x1361B)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AX,0x4b (1000_361C / 0x1361C)
    AX = 0x4B;
    State.IncCycles();
    // CALL 0x1000:e387 (1000_361F / 0x1361F)
    NearCall(cs1, 0x3622, spice86_generated_label_call_target_1000_E387_01E387);
    State.IncCycles();
    label_1000_3622_13622:
    // POP AX (1000_3622 / 0x13622)
    AX = Stack.Pop();
    State.IncCycles();
    // PUSH AX (1000_3623 / 0x13623)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:96d8 (1000_3624 / 0x13624)
    NearCall(cs1, 0x3627, spice86_generated_label_call_target_1000_96D8_0196D8);
    State.IncCycles();
    label_1000_3627_13627:
    // POP AX (1000_3627 / 0x13627)
    AX = Stack.Pop();
    State.IncCycles();
    // JC 0x1000:3636 (1000_3628 / 0x13628)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    State.IncCycles();
    // MOV CL,0x10 (1000_362A / 0x1362A)
    CL = 0x10;
    State.IncCycles();
    // MUL CL (1000_362C / 0x1362C)
    Cpu.Mul8(CL);
    State.IncCycles();
    // ADD AX,0xfd8 (1000_362E / 0x1362E)
    // AX += 0xFD8;
    AX = Alu.Add16(AX, 0xFD8);
    State.IncCycles();
    // MOV SI,AX (1000_3631 / 0x13631)
    SI = AX;
    State.IncCycles();
    // CALL 0x1000:3551 (1000_3633 / 0x13633)
    NearCall(cs1, 0x3636, spice86_generated_label_call_target_1000_3551_013551);
    State.IncCycles();
    label_1000_3636_13636:
    // RET  (1000_3636 / 0x13636)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3637_013637(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_363A_1363A:
    // CMP byte ptr [0x23],0x0 (1000_363A / 0x1363A)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    State.IncCycles();
    // JZ 0x1000:3636 (1000_363F / 0x1363F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3636 / 0x13636)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:dbb2 (1000_3641 / 0x13641)
    NearCall(cs1, 0x3644, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    State.IncCycles();
    // CALL 0x1000:439f (1000_3644 / 0x13644)
    NearCall(cs1, 0x3647, spice86_generated_label_call_target_1000_439F_01439F);
    State.IncCycles();
    // MOV CX,0x200c (1000_3647 / 0x13647)
    CX = 0x200C;
    State.IncCycles();
    // MOV DX,0x66 (1000_364A / 0x1364A)
    DX = 0x66;
    State.IncCycles();
    // MOV BX,0x4e (1000_364D / 0x1364D)
    BX = 0x4E;
    State.IncCycles();
    // MOV AX,0xbf (1000_3650 / 0x13650)
    AX = 0xBF;
    State.IncCycles();
    // CALL 0x1000:d194 (1000_3653 / 0x13653)
    NearCall(cs1, 0x3656, spice86_generated_label_call_target_1000_D194_01D194);
    State.IncCycles();
    // CALL 0x1000:c0f4 (1000_3656 / 0x13656)
    NearCall(cs1, 0x3659, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    State.IncCycles();
    // CALL 0x1000:c4dd (1000_3659 / 0x13659)
    NearCall(cs1, 0x365C, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    // CALL 0x1000:4aca (1000_365C / 0x1365C)
    NearCall(cs1, 0x365F, spice86_generated_label_call_target_1000_4ACA_014ACA);
    State.IncCycles();
    // MOV BP,0x1f9e (1000_365F / 0x1365F)
    BP = 0x1F9E;
    State.IncCycles();
    // OR byte ptr [BP + 0xb],0x40 (1000_3662 / 0x13662)
    // UInt8[SS, (ushort)(BP + 0xB)] |= 0x40;
    UInt8[SS, (ushort)(BP + 0xB)] = Alu.Or8(UInt8[SS, (ushort)(BP + 0xB)], 0x40);
    State.IncCycles();
    // MOV BX,0x4abe (1000_3666 / 0x13666)
    BX = 0x4ABE;
    State.IncCycles();
    // CALL 0x1000:d323 (1000_3669 / 0x13669)
    NearCall(cs1, 0x366C, spice86_generated_label_call_target_1000_D323_01D323);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_366F_1366F:
    // MOV AX,[0x1152] (1000_366F / 0x1366F)
    AX = UInt16[DS, 0x1152];
    State.IncCycles();
    // CMP AX,0xffff (1000_3672 / 0x13672)
    Alu.Sub16(AX, 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:3688 (1000_3675 / 0x13675)
    if(ZeroFlag) {
      goto label_1000_3688_13688;
    }
    State.IncCycles();
    // CMP AH,0xff (1000_3677 / 0x13677)
    Alu.Sub8(AH, 0xFF);
    State.IncCycles();
    // JZ 0x1000:3686 (1000_367A / 0x1367A)
    if(ZeroFlag) {
      goto label_1000_3686_13686;
    }
    State.IncCycles();
    // TEST word ptr [0x0],0x80 (1000_367C / 0x1367C)
    Alu.And16(UInt16[DS, 0x0], 0x80);
    State.IncCycles();
    // JNZ 0x1000:3686 (1000_3682 / 0x13682)
    if(!ZeroFlag) {
      goto label_1000_3686_13686;
    }
    State.IncCycles();
    // XCHG AH,AL (1000_3684 / 0x13684)
    byte tmp_1000_3684 = AH;
    AH = AL;
    AL = tmp_1000_3684;
    State.IncCycles();
    label_1000_3686_13686:
    // XOR AH,AH (1000_3686 / 0x13686)
    AH = 0;
    State.IncCycles();
    label_1000_3688_13688:
    // OR AX,AX (1000_3688 / 0x13688)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // RET  (1000_368A / 0x1368A)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_368B_01368B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_368E_1368E:
    // OR byte ptr [0x4728],0x1 (1000_368E / 0x1368E)
    // UInt8[DS, 0x4728] |= 0x1;
    UInt8[DS, 0x4728] = Alu.Or8(UInt8[DS, 0x4728], 0x1);
    State.IncCycles();
    // MOV BL,byte ptr [0x11c9] (1000_3693 / 0x13693)
    BL = UInt8[DS, 0x11C9];
    State.IncCycles();
    // AND BL,0x3 (1000_3697 / 0x13697)
    BL &= 0x3;
    State.IncCycles();
    // CMP BL,0x2 (1000_369A / 0x1369A)
    Alu.Sub8(BL, 0x2);
    State.IncCycles();
    // JZ 0x1000:36cb (1000_369D / 0x1369D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_36CB_0136CB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC BL (1000_369F / 0x1369F)
    BL = Alu.Dec8(BL);
    State.IncCycles();
    // JNZ 0x1000:36c7 (1000_36A1 / 0x136A1)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_36B6_0136B6, 0x136C7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV byte ptr [0x473e],0x1 (1000_36A3 / 0x136A3)
    UInt8[DS, 0x473E] = 0x1;
    State.IncCycles();
    // MOV byte ptr [0x47a4],0x1 (1000_36A8 / 0x136A8)
    UInt8[DS, 0x47A4] = 0x1;
    State.IncCycles();
    // PUSH AX (1000_36AD / 0x136AD)
    Stack.Push(AX);
    State.IncCycles();
    // MOV AL,0x34 (1000_36AE / 0x136AE)
    AL = 0x34;
    State.IncCycles();
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
    State.IncCycles();
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
    State.IncCycles();
    label_1000_36B6_136B6:
    // CALL 0x1000:c412 (1000_36B6 / 0x136B6)
    NearCall(cs1, 0x36B9, spice86_generated_label_call_target_1000_C412_01C412);
    State.IncCycles();
    label_1000_36B9_136B9:
    // POP AX (1000_36B9 / 0x136B9)
    AX = Stack.Pop();
    State.IncCycles();
    // OR AX,AX (1000_36BA / 0x136BA)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x1000:36c4 (1000_36BC / 0x136BC)
    if(SignFlag) {
      goto label_1000_36C4_136C4;
    }
    State.IncCycles();
    // MOV [0x47c4],AX (1000_36BE / 0x136BE)
    UInt16[DS, 0x47C4] = AX;
    State.IncCycles();
    // CALL 0x1000:978e (1000_36C1 / 0x136C1)
    NearCall(cs1, 0x36C4, spice86_generated_label_call_target_1000_978E_01978E);
    State.IncCycles();
    label_1000_36C4_136C4:
    // CALL 0x1000:c4dd (1000_36C4 / 0x136C4)
    NearCall(cs1, 0x36C7, spice86_generated_label_call_target_1000_C4DD_01C4DD);
    State.IncCycles();
    label_1000_36C7_136C7:
    // CALL 0x1000:e283 (1000_36C7 / 0x136C7)
    NearCall(cs1, 0x36CA, spice86_generated_label_call_target_1000_E283_01E283);
    State.IncCycles();
    label_1000_36CA_136CA:
    // RET  (1000_36CA / 0x136CA)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_36CB_0136CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_36CB_136CB:
    // CALL 0x1000:4aeb (1000_36CB / 0x136CB)
    NearCall(cs1, 0x36CE, not_observed_1000_4AEB_014AEB);
    State.IncCycles();
    // CALL 0x1000:c474 (1000_36CE / 0x136CE)
    NearCall(cs1, 0x36D1, spice86_generated_label_call_target_1000_C474_01C474);
    State.IncCycles();
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
    State.IncCycles();
    label_1000_36D3_136D3:
    // CMP byte ptr [0x23],0x0 (1000_36D3 / 0x136D3)
    Alu.Sub8(UInt8[DS, 0x23], 0x0);
    State.IncCycles();
    // JZ 0x1000:36ed (1000_36D8 / 0x136D8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_36ED / 0x136ED)
      return NearRet();
    }
    State.IncCycles();
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
    State.IncCycles();
    label_1000_36DD_136DD:
    // MOV byte ptr [0x47a7],0x0 (1000_36DD / 0x136DD)
    UInt8[DS, 0x47A7] = 0x0;
    State.IncCycles();
    // MOV BP,0x3520 (1000_36E2 / 0x136E2)
    BP = 0x3520;
    State.IncCycles();
    // CALL 0x1000:36ee (1000_36E5 / 0x136E5)
    NearCall(cs1, 0x36E8, spice86_generated_label_call_target_1000_36EE_0136EE);
    State.IncCycles();
    label_1000_36E8_136E8:
    // MOV byte ptr [0x23],0x0 (1000_36E8 / 0x136E8)
    UInt8[DS, 0x23] = 0x0;
    State.IncCycles();
    label_1000_36ED_136ED:
    // RET  (1000_36ED / 0x136ED)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_36EE_0136EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_36EE_136EE:
    // PUSH BX (1000_36EE / 0x136EE)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_36EF / 0x136EF)
    Stack.Push(DX);
    State.IncCycles();
    // MOV SI,0xfd8 (1000_36F0 / 0x136F0)
    SI = 0xFD8;
    State.IncCycles();
    // MOV CX,0x10 (1000_36F3 / 0x136F3)
    CX = 0x10;
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_36F6 / 0x136F6)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_36FA / 0x136FA)
    DX = UInt16[DS, 0x4];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_36FE_0136FE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_36FE_0136FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_36FE_136FE:
    // CMP BX,word ptr [SI + 0x2] (1000_36FE / 0x136FE)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:371b (1000_3701 / 0x13701)
    if(!ZeroFlag) {
      goto label_1000_371B_1371B;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI] (1000_3703 / 0x13703)
    Alu.Sub16(DX, UInt16[DS, SI]);
    State.IncCycles();
    // JNZ 0x1000:371b (1000_3705 / 0x13705)
    if(!ZeroFlag) {
      goto label_1000_371B_1371B;
    }
    State.IncCycles();
    // POP DX (1000_3707 / 0x13707)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3708 / 0x13708)
    BX = Stack.Pop();
    State.IncCycles();
    // PUSH BX (1000_3709 / 0x13709)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_370A / 0x1370A)
    Stack.Push(DX);
    State.IncCycles();
    // PUSH CX (1000_370B / 0x1370B)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH SI (1000_370C / 0x1370C)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH BP (1000_370D / 0x1370D)
    Stack.Push(BP);
    State.IncCycles();
    // CALL BP (1000_370E / 0x1370E)
    // Indirect call to BP, generating possible targets from emulator records
    uint targetAddress_1000_370E = (uint)(BP);
    switch(targetAddress_1000_370E) {
      case 0x30B9 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_30B9_0130B9); break;
      case 0x3120 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_3120_013120); break;
      case 0x3520 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_3520_013520); break;
      case 0x40C9 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_40C9_0140C9); break;
      case 0x40E6 : NearCall(cs1, 0x3710, spice86_generated_label_call_target_1000_40E6_0140E6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_370E));
        break;
    }
    State.IncCycles();
    label_1000_3710_13710:
    // POP BP (1000_3710 / 0x13710)
    BP = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_3711 / 0x13711)
    SI = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_3712 / 0x13712)
    CX = Stack.Pop();
    State.IncCycles();
    // MOV BX,word ptr [0x6] (1000_3713 / 0x13713)
    BX = UInt16[DS, 0x6];
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_3717 / 0x13717)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    label_1000_371B_1371B:
    // ADD SI,0x10 (1000_371B / 0x1371B)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    State.IncCycles();
    // LOOP 0x1000:36fe (1000_371E / 0x1371E)
    if(--CX != 0) {
      goto label_1000_36FE_136FE;
    }
    State.IncCycles();
    // POP DX (1000_3720 / 0x13720)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3721 / 0x13721)
    BX = Stack.Pop();
    State.IncCycles();
    label_1000_3722_13722:
    // RET  (1000_3722 / 0x13722)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_37B2_0137B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37B2_137B2:
    // CALL 0x1000:98e6 (1000_37B2 / 0x137B2)
    NearCall(cs1, 0x37B5, spice86_generated_label_call_target_1000_98E6_0198E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37B5_0137B5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37B5_0137B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37B5_137B5:
    // CALL 0x1000:4d00 (1000_37B5 / 0x137B5)
    NearCall(cs1, 0x37B8, spice86_generated_label_call_target_1000_4D00_014D00);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37B8_0137B8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37B8_0137B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37B8_137B8:
    // MOV word ptr [0x472d],0x0 (1000_37B8 / 0x137B8)
    UInt16[DS, 0x472D] = 0x0;
    State.IncCycles();
    // CALL 0x1000:5ba8 (1000_37BE / 0x137BE)
    NearCall(cs1, 0x37C1, spice86_generated_label_call_target_1000_5BA8_015BA8);
    State.IncCycles();
    label_1000_37C1_137C1:
    // CALL 0x1000:c432 (1000_37C1 / 0x137C1)
    NearCall(cs1, 0x37C4, spice86_generated_label_call_target_1000_C432_01C432);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37C4_0137C4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37C4_0137C4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37C4_137C4:
    // MOV AX,0xffff (1000_37C4 / 0x137C4)
    AX = 0xFFFF;
    State.IncCycles();
    // CMP byte ptr [0x8],AL (1000_37C7 / 0x137C7)
    Alu.Sub8(UInt8[DS, 0x8], AL);
    State.IncCycles();
    // JZ 0x1000:37d5 (1000_37CB / 0x137CB)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37D4_0137D4, 0x137D5 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_37CD / 0x137CD)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // CALL 0x1000:3efe (1000_37D1 / 0x137D1)
    NearCall(cs1, 0x37D4, spice86_generated_label_call_target_1000_3EFE_013EFE);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37D4_0137D4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37D4_0137D4(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x37D5: goto label_1000_37D5_137D5;break; // Target of external jump from 0x137CB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_37D4_137D4:
    // LODSB SI (1000_37D4 / 0x137D4)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    label_1000_37D5_137D5:
    // OR AX,AX (1000_37D5 / 0x137D5)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JS 0x1000:37dc (1000_37D7 / 0x137D7)
    if(SignFlag) {
      goto label_1000_37DC_137DC;
    }
    State.IncCycles();
    // JMP 0x1000:39ec (1000_37D9 / 0x137D9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_39EC_0139EC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_37DC_137DC:
    // CALL 0x1000:3ae9 (1000_37DC / 0x137DC)
    NearCall(cs1, 0x37DF, spice86_generated_label_call_target_1000_3AE9_013AE9);
    State.IncCycles();
    label_1000_37DF_137DF:
    // OR byte ptr [0x47a4],0x1 (1000_37DF / 0x137DF)
    UInt8[DS, 0x47A4] |= 0x1;
    State.IncCycles();
    // TEST byte ptr [0x11c9],0x3 (1000_37E4 / 0x137E4)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    State.IncCycles();
    // JNZ 0x1000:37f4 (1000_37E9 / 0x137E9)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_37F4_0137F4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_37EB_0137EB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_37EB_0137EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37EB_137EB:
    // CALL 0x1000:380c (1000_37EB / 0x137EB)
    NearCall(cs1, 0x37EE, spice86_generated_label_call_target_1000_380C_01380C);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37EE_0137EE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37EE_0137EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37EE_137EE:
    // CALL 0x1000:4e12 (1000_37EE / 0x137EE)
    NearCall(cs1, 0x37F1, spice86_generated_label_call_target_1000_4E12_014E12);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37F1_0137F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37F1_0137F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37F1_137F1:
    // JMP 0x1000:4d06 (1000_37F1 / 0x137F1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_4D06_014D06, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_37F4_0137F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37F4_137F4:
    // MOV byte ptr [0x4728],0x0 (1000_37F4 / 0x137F4)
    UInt8[DS, 0x4728] = 0x0;
    State.IncCycles();
    // CALL 0x1000:4988 (1000_37F9 / 0x137F9)
    NearCall(cs1, 0x37FC, spice86_generated_label_call_target_1000_4988_014988);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37FC_0137FC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37FC_0137FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37FC_137FC:
    // CALL 0x1000:4a5a (1000_37FC / 0x137FC)
    NearCall(cs1, 0x37FF, spice86_generated_label_call_target_1000_4A5A_014A5A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_37FF_0137FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_37FF_0137FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_37FF_137FF:
    // MOV AX,[0x487e] (1000_37FF / 0x137FF)
    AX = UInt16[DS, 0x487E];
    State.IncCycles();
    // CALL 0x1000:ca1b (1000_3802 / 0x13802)
    NearCall(cs1, 0x3805, spice86_generated_label_call_target_1000_CA1B_01CA1B);
    State.IncCycles();
    label_1000_3805_13805:
    // CALLF [0x3959] (1000_3805 / 0x13805)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_3805 = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_3805) {
      case 0x2362B : FarCall(cs1, 0x3809, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3805));
        break;
    }
    State.IncCycles();
    label_1000_3809_13809:
    // JMP 0x1000:388d (1000_3809 / 0x13809)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_388D_01388D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_380C_01380C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_380C_1380C:
    // MOV byte ptr [0x22e3],0x1 (1000_380C / 0x1380C)
    UInt8[DS, 0x22E3] = 0x1;
    State.IncCycles();
    // CALL 0x1000:388d (1000_3811 / 0x13811)
    NearCall(cs1, 0x3814, spice86_generated_label_ret_target_1000_388D_01388D);
    State.IncCycles();
    label_1000_3814_13814:
    // MOV SI,word ptr [0x1150] (1000_3814 / 0x13814)
    SI = UInt16[DS, 0x1150];
    State.IncCycles();
    // MOV AX,0x1972 (1000_3818 / 0x13818)
    AX = 0x1972;
    State.IncCycles();
    // CALL 0x1000:5e4f (1000_381B / 0x1381B)
    NearCall(cs1, 0x381E, spice86_generated_label_call_target_1000_5E4F_015E4F);
    State.IncCycles();
    label_1000_381E_1381E:
    // MOV BX,AX (1000_381E / 0x1381E)
    BX = AX;
    State.IncCycles();
    // MOV DX,word ptr [0x4] (1000_3820 / 0x13820)
    DX = UInt16[DS, 0x4];
    State.IncCycles();
    // MOV AX,[0x6] (1000_3824 / 0x13824)
    AX = UInt16[DS, 0x6];
    State.IncCycles();
    // CMP AL,0x80 (1000_3827 / 0x13827)
    Alu.Sub8(AL, 0x80);
    State.IncCycles();
    // MOV AL,0x0 (1000_3829 / 0x13829)
    AL = 0x0;
    State.IncCycles();
    // JZ 0x1000:3834 (1000_382B / 0x1382B)
    if(ZeroFlag) {
      goto label_1000_3834_13834;
    }
    State.IncCycles();
    // CMP DX,word ptr [SI + 0x2] (1000_382D / 0x1382D)
    Alu.Sub16(DX, UInt16[DS, (ushort)(SI + 0x2)]);
    State.IncCycles();
    // JNZ 0x1000:384a (1000_3830 / 0x13830)
    if(!ZeroFlag) {
      goto label_1000_384A_1384A;
    }
    State.IncCycles();
    // MOV AL,AH (1000_3832 / 0x13832)
    AL = AH;
    State.IncCycles();
    label_1000_3834_13834:
    // CMP AL,byte ptr [BX + 0x5] (1000_3834 / 0x13834)
    Alu.Sub8(AL, UInt8[DS, (ushort)(BX + 0x5)]);
    State.IncCycles();
    // JNC 0x1000:384a (1000_3837 / 0x13837)
    if(!CarryFlag) {
      goto label_1000_384A_1384A;
    }
    State.IncCycles();
    // ADD AL,byte ptr [BX] (1000_3839 / 0x13839)
    AL += UInt8[DS, BX];
    State.IncCycles();
    // CMP AL,0x7f (1000_383B / 0x1383B)
    Alu.Sub8(AL, 0x7F);
    State.IncCycles();
    // JNZ 0x1000:3847 (1000_383D / 0x1383D)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      State.IncCycles();
      // JMP 0x1000:c2f2 (1000_3847 / 0x13847)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV AH,byte ptr [SI] (1000_383F / 0x1383F)
    AH = UInt8[DS, SI];
    State.IncCycles();
    // SHR AH,1 (1000_3841 / 0x13841)
    AH >>= 0x1;
    State.IncCycles();
    // ADD AL,AH (1000_3843 / 0x13843)
    AL += AH;
    State.IncCycles();
    // SUB AL,0x5 (1000_3845 / 0x13845)
    // AL -= 0x5;
    AL = Alu.Sub8(AL, 0x5);
    State.IncCycles();
    label_1000_3847_13847:
    // JMP 0x1000:c2f2 (1000_3847 / 0x13847)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_384A_1384A:
    // MOV DI,word ptr [0x1150] (1000_384A / 0x1384A)
    DI = UInt16[DS, 0x1150];
    State.IncCycles();
    // TEST byte ptr [DI + 0xa],0x1 (1000_384E / 0x1384E)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x1);
    State.IncCycles();
    // JNZ 0x1000:3872 (1000_3852 / 0x13852)
    if(!ZeroFlag) {
      goto label_1000_3872_13872;
    }
    State.IncCycles();
    // CALL 0x1000:407e (1000_3854 / 0x13854)
    NearCall(cs1, 0x3857, spice86_generated_label_call_target_1000_407E_01407E);
    State.IncCycles();
    // CALL 0x1000:b58b (1000_3857 / 0x13857)
    NearCall(cs1, 0x385A, spice86_generated_label_call_target_1000_B58B_01B58B);
    State.IncCycles();
    // DEC DI (1000_385A / 0x1385A)
    DI = Alu.Dec16(DI);
    State.IncCycles();
    // MOV CX,0x4 (1000_385B / 0x1385B)
    CX = 0x4;
    State.IncCycles();
    label_1000_385E_1385E:
    // MOV AL,byte ptr ES:[DI] (1000_385E / 0x1385E)
    AL = UInt8[ES, DI];
    State.IncCycles();
    // INC DI (1000_3861 / 0x13861)
    DI++;
    State.IncCycles();
    // AND AL,0x30 (1000_3862 / 0x13862)
    AL &= 0x30;
    State.IncCycles();
    // CMP AL,0x10 (1000_3864 / 0x13864)
    Alu.Sub8(AL, 0x10);
    State.IncCycles();
    // JZ 0x1000:3872 (1000_3866 / 0x13866)
    if(ZeroFlag) {
      goto label_1000_3872_13872;
    }
    State.IncCycles();
    // LOOP 0x1000:385e (1000_3868 / 0x13868)
    if(--CX != 0) {
      goto label_1000_385E_1385E;
    }
    State.IncCycles();
    // MOV BX,0x13 (1000_386A / 0x1386A)
    BX = 0x13;
    State.IncCycles();
    // MOV CX,0x42 (1000_386D / 0x1386D)
    CX = 0x42;
    State.IncCycles();
    // JMP 0x1000:3878 (1000_3870 / 0x13870)
    goto label_1000_3878_13878;
    State.IncCycles();
    label_1000_3872_13872:
    // MOV BX,0xa (1000_3872 / 0x13872)
    BX = 0xA;
    State.IncCycles();
    // MOV CX,0x88 (1000_3875 / 0x13875)
    CX = 0x88;
    State.IncCycles();
    label_1000_3878_13878:
    // MOV AX,[0x6] (1000_3878 / 0x13878)
    AX = UInt16[DS, 0x6];
    State.IncCycles();
    // XCHG AH,AL (1000_387B / 0x1387B)
    byte tmp_1000_387B = AH;
    AH = AL;
    AL = tmp_1000_387B;
    State.IncCycles();
    // XOR AX,word ptr [0x4] (1000_387D / 0x1387D)
    AX ^= UInt16[DS, 0x4];
    State.IncCycles();
    // INC AX (1000_3881 / 0x13881)
    AX++;
    State.IncCycles();
    // XOR DX,DX (1000_3882 / 0x13882)
    DX = 0;
    State.IncCycles();
    // DIV BX (1000_3884 / 0x13884)
    Cpu.Div16(BX);
    State.IncCycles();
    // MOV AX,DX (1000_3886 / 0x13886)
    AX = DX;
    State.IncCycles();
    // ADD AX,CX (1000_3888 / 0x13888)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    State.IncCycles();
    // JMP 0x1000:c2f2 (1000_388A / 0x1388A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C2F2_01C2F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_388D_01388D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_388D_1388D:
    // MOV byte ptr [0x46df],0x1 (1000_388D / 0x1388D)
    UInt8[DS, 0x46DF] = 0x1;
    State.IncCycles();
    // CALL 0x1000:395c (1000_3892 / 0x13892)
    NearCall(cs1, 0x3895, spice86_generated_label_call_target_1000_395C_01395C);
    State.IncCycles();
    label_1000_3895_13895:
    // CMP byte ptr [0x46d7],0x0 (1000_3895 / 0x13895)
    Alu.Sub8(UInt8[DS, 0x46D7], 0x0);
    State.IncCycles();
    // JZ 0x1000:38ad (1000_389A / 0x1389A)
    if(ZeroFlag) {
      goto label_1000_38AD_138AD;
    }
    State.IncCycles();
    // CMP byte ptr [0x46d6],BL (1000_389C / 0x1389C)
    Alu.Sub8(UInt8[DS, 0x46D6], BL);
    State.IncCycles();
    // JZ 0x1000:38b3 (1000_38A0 / 0x138A0)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_38B3 / 0x138B3)
      return NearRet();
    }
    State.IncCycles();
    // MOV byte ptr [0x46d7],0x30 (1000_38A2 / 0x138A2)
    UInt8[DS, 0x46D7] = 0x30;
    State.IncCycles();
    // CALL 0x1000:3971 (1000_38A7 / 0x138A7)
    NearCall(cs1, 0x38AA, spice86_generated_label_call_target_1000_3971_013971);
    State.IncCycles();
    // JMP 0x1000:39b9 (1000_38AA / 0x138AA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_39B9_0139B9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_38AD_138AD:
    // CALL 0x1000:3971 (1000_38AD / 0x138AD)
    NearCall(cs1, 0x38B0, spice86_generated_label_call_target_1000_3971_013971);
    State.IncCycles();
    label_1000_38B0_138B0:
    // CALL 0x1000:398c (1000_38B0 / 0x138B0)
    NearCall(cs1, 0x38B3, spice86_generated_label_call_target_1000_398C_01398C);
    State.IncCycles();
    label_1000_38B3_138B3:
    // RET  (1000_38B3 / 0x138B3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_38B4_0138B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_38B4_138B4:
    // CALL 0x1000:388d (1000_38B4 / 0x138B4)
    NearCall(cs1, 0x38B7, spice86_generated_label_ret_target_1000_388D_01388D);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_38B7_0138B7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_38B7_0138B7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x38E0: goto label_1000_38E0_138E0;break; // Target of external jump from 0x138E6, 0x138EF, 0x138FF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_38B7_138B7:
    // MOV AX,0x28 (1000_38B7 / 0x138B7)
    AX = 0x28;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_38BA / 0x138BA)
    NearCall(cs1, 0x38BD, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_38BD_138BD:
    // XOR AX,AX (1000_38BD / 0x138BD)
    AX = 0;
    State.IncCycles();
    // MOV BP,0x14 (1000_38BF / 0x138BF)
    BP = 0x14;
    State.IncCycles();
    // XOR BX,BX (1000_38C2 / 0x138C2)
    BX = 0;
    State.IncCycles();
    // MOV CX,0x4 (1000_38C4 / 0x138C4)
    CX = 0x4;
    State.IncCycles();
    label_1000_38C7_138C7:
    // XOR DX,DX (1000_38C7 / 0x138C7)
    DX = 0;
    State.IncCycles();
    // PUSH CX (1000_38C9 / 0x138C9)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH BP (1000_38CA / 0x138CA)
    Stack.Push(BP);
    State.IncCycles();
    label_1000_38CB_138CB:
    // PUSH AX (1000_38CB / 0x138CB)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:c2fd (1000_38CC / 0x138CC)
    NearCall(cs1, 0x38CF, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    State.IncCycles();
    label_1000_38CF_138CF:
    // POP AX (1000_38CF / 0x138CF)
    AX = Stack.Pop();
    State.IncCycles();
    // ADD DX,0x28 (1000_38D0 / 0x138D0)
    DX += 0x28;
    State.IncCycles();
    // CMP DX,0x140 (1000_38D3 / 0x138D3)
    Alu.Sub16(DX, 0x140);
    State.IncCycles();
    // JC 0x1000:38cb (1000_38D7 / 0x138D7)
    if(CarryFlag) {
      goto label_1000_38CB_138CB;
    }
    State.IncCycles();
    // POP BP (1000_38D9 / 0x138D9)
    BP = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_38DA / 0x138DA)
    CX = Stack.Pop();
    State.IncCycles();
    // INC AX (1000_38DB / 0x138DB)
    AX++;
    State.IncCycles();
    // ADD BX,BP (1000_38DC / 0x138DC)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    State.IncCycles();
    // LOOP 0x1000:38c7 (1000_38DE / 0x138DE)
    if(--CX != 0) {
      goto label_1000_38C7_138C7;
    }
    State.IncCycles();
    label_1000_38E0_138E0:
    // RET  (1000_38E0 / 0x138E0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_38E1_0138E1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_38E1_138E1:
    // CMP byte ptr [0x46df],0x0 (1000_38E1 / 0x138E1)
    Alu.Sub8(UInt8[DS, 0x46DF], 0x0);
    State.IncCycles();
    // JZ 0x1000:38e0 (1000_38E6 / 0x138E6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_38E0 / 0x138E0)
      return NearRet();
    }
    State.IncCycles();
    // CALL 0x1000:395c (1000_38E8 / 0x138E8)
    NearCall(cs1, 0x38EB, spice86_generated_label_call_target_1000_395C_01395C);
    State.IncCycles();
    label_1000_38EB_138EB:
    // CMP byte ptr [0x46d6],BL (1000_38EB / 0x138EB)
    Alu.Sub8(UInt8[DS, 0x46D6], BL);
    State.IncCycles();
    // JZ 0x1000:38e0 (1000_38EF / 0x138EF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_38E0 / 0x138E0)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_38F1_0138F1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_38F1_0138F1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_38F1_138F1:
    // CALL 0x1000:3971 (1000_38F1 / 0x138F1)
    NearCall(cs1, 0x38F4, spice86_generated_label_call_target_1000_3971_013971);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_38F4_0138F4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_38F4_0138F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_38F4_138F4:
    // CALL 0x1000:39b9 (1000_38F4 / 0x138F4)
    NearCall(cs1, 0x38F7, spice86_generated_label_call_target_1000_39B9_0139B9);
    State.IncCycles();
    label_1000_38F7_138F7:
    // MOV AL,0x40 (1000_38F7 / 0x138F7)
    AL = 0x40;
    State.IncCycles();
    // XCHG byte ptr [0x46d7],AL (1000_38F9 / 0x138F9)
    byte tmp_1000_38F9 = UInt8[DS, 0x46D7];
    UInt8[DS, 0x46D7] = AL;
    AL = tmp_1000_38F9;
    State.IncCycles();
    // OR AL,AL (1000_38FD / 0x138FD)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    State.IncCycles();
    // JNZ 0x1000:38e0 (1000_38FF / 0x138FF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_38E0 / 0x138E0)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0x3916 (1000_3901 / 0x13901)
    SI = 0x3916;
    State.IncCycles();
    // MOV BP,0x10 (1000_3904 / 0x13904)
    BP = 0x10;
    State.IncCycles();
    // JMP 0x1000:da25 (1000_3907 / 0x13907)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA25_01DA25, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3916_013916(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3916_13916:
    // CMP byte ptr [0x46df],0x0 (1000_3916 / 0x13916)
    Alu.Sub8(UInt8[DS, 0x46DF], 0x0);
    State.IncCycles();
    // JZ 0x1000:3950 (1000_391B / 0x1391B)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3950_013950, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // MOV CX,0x1c5 (1000_391D / 0x1391D)
    CX = 0x1C5;
    State.IncCycles();
    // MOV BX,0xdb (1000_3920 / 0x13920)
    BX = 0xDB;
    State.IncCycles();
    // CMP byte ptr [0x22e3],0x0 (1000_3923 / 0x13923)
    Alu.Sub8(UInt8[DS, 0x22E3], 0x0);
    State.IncCycles();
    // JNZ 0x1000:3930 (1000_3928 / 0x13928)
    if(!ZeroFlag) {
      goto label_1000_3930_13930;
    }
    State.IncCycles();
    // MOV CX,0xf0 (1000_392A / 0x1392A)
    CX = 0xF0;
    State.IncCycles();
    // MOV BX,0x180 (1000_392D / 0x1392D)
    BX = 0x180;
    State.IncCycles();
    label_1000_3930_13930:
    // MOV AL,[0x46d7] (1000_3930 / 0x13930)
    AL = UInt8[DS, 0x46D7];
    State.IncCycles();
    // PUSH AX (1000_3933 / 0x13933)
    Stack.Push(AX);
    State.IncCycles();
    // CALLF [0x3951] (1000_3934 / 0x13934)
    // Indirect call to [0x3951], generating possible targets from emulator records
    uint targetAddress_1000_3934 = (uint)(UInt16[DS, 0x3953] * 0x10 + UInt16[DS, 0x3951] - cs1 * 0x10);
    switch(targetAddress_1000_3934) {
      case 0x23625 : FarCall(cs1, 0x3938, spice86_generated_label_call_target_334B_0175_033625); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3934));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3938_013938, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3938_013938(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3938_13938:
    // POP AX (1000_3938 / 0x13938)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_3939 / 0x13939)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:394a (1000_393E / 0x1393E)
    if(!ZeroFlag) {
      goto label_1000_394A_1394A;
    }
    State.IncCycles();
    // MOV CX,0x30 (1000_3940 / 0x13940)
    CX = 0x30;
    State.IncCycles();
    // MOV BX,0x2d0 (1000_3943 / 0x13943)
    BX = 0x2D0;
    State.IncCycles();
    // CALLF [0x3951] (1000_3946 / 0x13946)
    // Indirect call to [0x3951], generating possible targets from emulator records
    uint targetAddress_1000_3946 = (uint)(UInt16[DS, 0x3953] * 0x10 + UInt16[DS, 0x3951] - cs1 * 0x10);
    switch(targetAddress_1000_3946) {
      case 0x23625 : FarCall(cs1, 0x394A, spice86_generated_label_call_target_334B_0175_033625); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3946));
        break;
    }
    State.IncCycles();
    label_1000_394A_1394A:
    // DEC byte ptr [0x46d7] (1000_394A / 0x1394A)
    UInt8[DS, 0x46D7] = Alu.Dec8(UInt8[DS, 0x46D7]);
    State.IncCycles();
    // JNZ 0x1000:395b (1000_394E / 0x1394E)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_395B / 0x1395B)
      return NearRet();
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3950_013950, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3950_013950(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3950_13950:
    // MOV byte ptr [0x46d7],0x0 (1000_3950 / 0x13950)
    UInt8[DS, 0x46D7] = 0x0;
    State.IncCycles();
    // MOV SI,0x3916 (1000_3955 / 0x13955)
    SI = 0x3916;
    State.IncCycles();
    // JMP 0x1000:da5f (1000_3958 / 0x13958)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_395B_01395B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_395B_1395B:
    // RET  (1000_395B / 0x1395B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_395C_01395C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_395C_1395C:
    // MOV AX,[0x2] (1000_395C / 0x1395C)
    AX = UInt16[DS, 0x2];
    State.IncCycles();
    // MOV AH,AL (1000_395F / 0x1395F)
    AH = AL;
    State.IncCycles();
    // SHR AH,1 (1000_3961 / 0x13961)
    AH >>= 0x1;
    State.IncCycles();
    // SHR AH,1 (1000_3963 / 0x13963)
    AH >>= 0x1;
    State.IncCycles();
    // AND AX,0x1c0f (1000_3965 / 0x13965)
    // AX &= 0x1C0F;
    AX = Alu.And16(AX, 0x1C0F);
    State.IncCycles();
    // MOV BX,0x2280 (1000_3968 / 0x13968)
    BX = 0x2280;
    State.IncCycles();
    // XLAT BX (1000_396B / 0x1396B)
    AL = UInt8[DS, (ushort)(BX + AL)];
    State.IncCycles();
    // ADD AL,AH (1000_396C / 0x1396C)
    // AL += AH;
    AL = Alu.Add8(AL, AH);
    State.IncCycles();
    // MOV BL,AL (1000_396E / 0x1396E)
    BL = AL;
    State.IncCycles();
    // RET  (1000_3970 / 0x13970)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3971_013971(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3971_13971:
    // MOV AX,0x28 (1000_3971 / 0x13971)
    AX = 0x28;
    State.IncCycles();
    // ADD AL,byte ptr [0x22e3] (1000_3974 / 0x13974)
    // AL += UInt8[DS, 0x22E3];
    AL = Alu.Add8(AL, UInt8[DS, 0x22E3]);
    State.IncCycles();
    // MOV [0xdbb4],AL (1000_3978 / 0x13978)
    UInt8[DS, 0xDBB4] = AL;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_397B / 0x1397B)
    NearCall(cs1, 0x397E, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_397E_01397E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_397E_01397E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_397E_1397E:
    // MOV AL,BL (1000_397E / 0x1397E)
    AL = BL;
    State.IncCycles();
    // XOR AH,AH (1000_3980 / 0x13980)
    AH = 0;
    State.IncCycles();
    // MOV [0x46d6],AL (1000_3982 / 0x13982)
    UInt8[DS, 0x46D6] = AL;
    State.IncCycles();
    // CALL 0x1000:c1f4 (1000_3985 / 0x13985)
    NearCall(cs1, 0x3988, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    State.IncCycles();
    label_1000_3988_13988:
    // LEA DX,[SI + 0x6] (1000_3988 / 0x13988)
    DX = (ushort)(SI + 0x6);
    State.IncCycles();
    // RET  (1000_398B / 0x1398B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_398C_01398C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_398C_1398C:
    // MOV CX,0x1c5 (1000_398C / 0x1398C)
    CX = 0x1C5;
    State.IncCycles();
    // MOV BX,0xdb (1000_398F / 0x1398F)
    BX = 0xDB;
    State.IncCycles();
    // CMP byte ptr [0x22e3],0x0 (1000_3992 / 0x13992)
    Alu.Sub8(UInt8[DS, 0x22E3], 0x0);
    State.IncCycles();
    // JNZ 0x1000:399f (1000_3997 / 0x13997)
    if(!ZeroFlag) {
      goto label_1000_399F_1399F;
    }
    State.IncCycles();
    // MOV CX,0xf0 (1000_3999 / 0x13999)
    CX = 0xF0;
    State.IncCycles();
    // MOV BX,0x180 (1000_399C / 0x1399C)
    BX = 0x180;
    State.IncCycles();
    label_1000_399F_1399F:
    // PUSH CX (1000_399F / 0x1399F)
    Stack.Push(CX);
    State.IncCycles();
    // CALLF [0x38bd] (1000_39A0 / 0x139A0)
    // Indirect call to [0x38bd], generating possible targets from emulator records
    uint targetAddress_1000_39A0 = (uint)(UInt16[DS, 0x38BF] * 0x10 + UInt16[DS, 0x38BD] - cs1 * 0x10);
    switch(targetAddress_1000_39A0) {
      case 0x235B6 : FarCall(cs1, 0x39A4, spice86_generated_label_call_target_334B_0106_0335B6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39A0));
        break;
    }
    State.IncCycles();
    label_1000_39A4_139A4:
    // POP CX (1000_39A4 / 0x139A4)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD DX,CX (1000_39A5 / 0x139A5)
    DX += CX;
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_39A7 / 0x139A7)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:39b8 (1000_39AC / 0x139AC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_39B8 / 0x139B8)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0x30 (1000_39AE / 0x139AE)
    CX = 0x30;
    State.IncCycles();
    // MOV BX,0x2d0 (1000_39B1 / 0x139B1)
    BX = 0x2D0;
    State.IncCycles();
    // CALLF [0x38bd] (1000_39B4 / 0x139B4)
    // Indirect call to [0x38bd], generating possible targets from emulator records
    uint targetAddress_1000_39B4 = (uint)(UInt16[DS, 0x38BF] * 0x10 + UInt16[DS, 0x38BD] - cs1 * 0x10);
    switch(targetAddress_1000_39B4) {
      case 0x235B6 : FarCall(cs1, 0x39B8, spice86_generated_label_call_target_334B_0106_0335B6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39B4));
        break;
    }
    State.IncCycles();
    label_1000_39B8_139B8:
    // RET  (1000_39B8 / 0x139B8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_39B9_0139B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_39B9_139B9:
    // MOV CX,0x1c5 (1000_39B9 / 0x139B9)
    CX = 0x1C5;
    State.IncCycles();
    // MOV BX,0xdb (1000_39BC / 0x139BC)
    BX = 0xDB;
    State.IncCycles();
    // CMP byte ptr [0x22e3],0x0 (1000_39BF / 0x139BF)
    Alu.Sub8(UInt8[DS, 0x22E3], 0x0);
    State.IncCycles();
    // JNZ 0x1000:39cc (1000_39C4 / 0x139C4)
    if(!ZeroFlag) {
      goto label_1000_39CC_139CC;
    }
    State.IncCycles();
    // MOV CX,0xf0 (1000_39C6 / 0x139C6)
    CX = 0xF0;
    State.IncCycles();
    // MOV BX,0x180 (1000_39C9 / 0x139C9)
    BX = 0x180;
    State.IncCycles();
    label_1000_39CC_139CC:
    // PUSH CX (1000_39CC / 0x139CC)
    Stack.Push(CX);
    State.IncCycles();
    // CALLF [0x394d] (1000_39CD / 0x139CD)
    // Indirect call to [0x394d], generating possible targets from emulator records
    uint targetAddress_1000_39CD = (uint)(UInt16[DS, 0x394F] * 0x10 + UInt16[DS, 0x394D] - cs1 * 0x10);
    switch(targetAddress_1000_39CD) {
      case 0x23622 : FarCall(cs1, 0x39D1, spice86_generated_label_call_target_334B_0172_033622); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39CD));
        break;
    }
    State.IncCycles();
    label_1000_39D1_139D1:
    // POP CX (1000_39D1 / 0x139D1)
    CX = Stack.Pop();
    State.IncCycles();
    // ADD DX,CX (1000_39D2 / 0x139D2)
    DX += CX;
    State.IncCycles();
    // CMP byte ptr [0x227d],0x0 (1000_39D4 / 0x139D4)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    State.IncCycles();
    // JNZ 0x1000:39e5 (1000_39D9 / 0x139D9)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_39E5 / 0x139E5)
      return NearRet();
    }
    State.IncCycles();
    // MOV CX,0x30 (1000_39DB / 0x139DB)
    CX = 0x30;
    State.IncCycles();
    // MOV BX,0x2d0 (1000_39DE / 0x139DE)
    BX = 0x2D0;
    State.IncCycles();
    // CALLF [0x394d] (1000_39E1 / 0x139E1)
    // Indirect call to [0x394d], generating possible targets from emulator records
    uint targetAddress_1000_39E1 = (uint)(UInt16[DS, 0x394F] * 0x10 + UInt16[DS, 0x394D] - cs1 * 0x10);
    switch(targetAddress_1000_39E1) {
      case 0x23622 : FarCall(cs1, 0x39E5, spice86_generated_label_call_target_334B_0172_033622); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_39E1));
        break;
    }
    State.IncCycles();
    label_1000_39E5_139E5:
    // RET  (1000_39E5 / 0x139E5)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_39E6_0139E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_39E6_139E6:
    // MOV SI,0xc0b6 (1000_39E6 / 0x139E6)
    SI = 0xC0B6;
    State.IncCycles();
    // JMP 0x1000:da5f (1000_39E9 / 0x139E9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_39EC_0139EC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_39EC_139EC:
    // MOV byte ptr [0x22e3],0x1 (1000_39EC / 0x139EC)
    UInt8[DS, 0x22E3] = 0x1;
    State.IncCycles();
    // PUSH AX (1000_39F1 / 0x139F1)
    Stack.Push(AX);
    State.IncCycles();
    // CALL 0x1000:3ae9 (1000_39F2 / 0x139F2)
    NearCall(cs1, 0x39F5, spice86_generated_label_call_target_1000_3AE9_013AE9);
    State.IncCycles();
    label_1000_39F5_139F5:
    // MOV AX,[0x4] (1000_39F5 / 0x139F5)
    AX = UInt16[DS, 0x4];
    State.IncCycles();
    // CMP AX,0x2005 (1000_39F8 / 0x139F8)
    Alu.Sub16(AX, 0x2005);
    State.IncCycles();
    // JZ 0x1000:3a1d (1000_39FB / 0x139FB)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_3A18_013A18, 0x13A1D - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AX,0x1005 (1000_39FD / 0x139FD)
    Alu.Sub16(AX, 0x1005);
    State.IncCycles();
    // JZ 0x1000:3a18 (1000_3A00 / 0x13A00)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_3A18_013A18, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // DEC AL (1000_3A02 / 0x13A02)
    AL = Alu.Dec8(AL);
    State.IncCycles();
    // JNZ 0x1000:3a20 (1000_3A04 / 0x13A04)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A20_013A20, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP AH,0x21 (1000_3A06 / 0x13A06)
    Alu.Sub8(AH, 0x21);
    State.IncCycles();
    // JNZ 0x1000:3a13 (1000_3A09 / 0x13A09)
    if(!ZeroFlag) {
      goto label_1000_3A13_13A13;
    }
    State.IncCycles();
    // POP AX (1000_3A0B / 0x13A0B)
    AX = Stack.Pop();
    State.IncCycles();
    // MOV DI,word ptr [0x114e] (1000_3A0C / 0x13A0C)
    DI = UInt16[DS, 0x114E];
    State.IncCycles();
    // MOV AL,byte ptr [DI] (1000_3A10 / 0x13A10)
    AL = UInt8[DS, DI];
    State.IncCycles();
    // PUSH AX (1000_3A12 / 0x13A12)
    Stack.Push(AX);
    State.IncCycles();
    label_1000_3A13_13A13:
    // CALL 0x1000:37eb (1000_3A13 / 0x13A13)
    NearCall(cs1, 0x3A16, spice86_generated_label_call_target_1000_37EB_0137EB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A16_013A16, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3A16_013A16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3A16_13A16:
    // JMP 0x1000:3a20 (1000_3A16 / 0x13A16)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A20_013A20, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_3A18_013A18(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3A1D: goto label_1000_3A1D_13A1D;break; // Target of external jump from 0x139FB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_3A18_13A18:
    // MOV byte ptr [0x22e3],0x0 (1000_3A18 / 0x13A18)
    UInt8[DS, 0x22E3] = 0x0;
    State.IncCycles();
    label_1000_3A1D_13A1D:
    // CALL 0x1000:38b4 (1000_3A1D / 0x13A1D)
    NearCall(cs1, 0x3A20, spice86_generated_label_call_target_1000_38B4_0138B4);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A20_013A20, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3A20_013A20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3A20_13A20:
    // POP AX (1000_3A20 / 0x13A20)
    AX = Stack.Pop();
    State.IncCycles();
    // CALL 0x1000:3b59 (1000_3A21 / 0x13A21)
    NearCall(cs1, 0x3A24, spice86_generated_label_call_target_1000_3B59_013B59);
    State.IncCycles();
    label_1000_3A24_13A24:
    // CMP byte ptr [0x46df],0x0 (1000_3A24 / 0x13A24)
    Alu.Sub8(UInt8[DS, 0x46DF], 0x0);
    State.IncCycles();
    // JZ 0x1000:3a7c (1000_3A29 / 0x13A29)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3A7C_013A7C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x4],0x1 (1000_3A2B / 0x13A2B)
    Alu.Sub8(UInt8[DS, 0x4], 0x1);
    State.IncCycles();
    // JNZ 0x1000:3a7c (1000_3A30 / 0x13A30)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3A7C_013A7C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // CMP byte ptr [0x4731],0xff (1000_3A32 / 0x13A32)
    Alu.Sub8(UInt8[DS, 0x4731], 0xFF);
    State.IncCycles();
    // JZ 0x1000:3a7b (1000_3A37 / 0x13A37)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3A7B / 0x13A7B)
      return NearRet();
    }
    State.IncCycles();
    // MOV CL,byte ptr [0x46ff] (1000_3A39 / 0x13A39)
    CL = UInt8[DS, 0x46FF];
    State.IncCycles();
    // XOR CH,CH (1000_3A3D / 0x13A3D)
    CH = 0;
    State.IncCycles();
    // JCXZ 0x1000:3a7b (1000_3A3F / 0x13A3F)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3A7B / 0x13A7B)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x388d (1000_3A41 / 0x13A41)
    AX = 0x388D;
    State.IncCycles();
    // PUSH AX (1000_3A44 / 0x13A44)
    Stack.Push(AX);
    State.IncCycles();
    // MOV byte ptr [0x4731],0x0 (1000_3A45 / 0x13A45)
    UInt8[DS, 0x4731] = 0x0;
    State.IncCycles();
    // TEST byte ptr [0x47a4],0x81 (1000_3A4A / 0x13A4A)
    Alu.And8(UInt8[DS, 0x47A4], 0x81);
    State.IncCycles();
    // JNZ 0x1000:3a7b (1000_3A4F / 0x13A4F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3A7B / 0x13A7B)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,0x33 (1000_3A51 / 0x13A51)
    AX = 0x33;
    State.IncCycles();
    // CALL 0x1000:c13e (1000_3A54 / 0x13A54)
    NearCall(cs1, 0x3A57, spice86_generated_label_call_target_1000_C13E_01C13E);
    State.IncCycles();
    label_1000_3A57_13A57:
    // CALL 0x1000:3a95 (1000_3A57 / 0x13A57)
    NearCall(cs1, 0x3A5A, spice86_generated_label_call_target_1000_3A95_013A95);
    State.IncCycles();
    label_1000_3A5A_13A5A:
    // MOV AX,DX (1000_3A5A / 0x13A5A)
    AX = DX;
    State.IncCycles();
    // ADD AX,0xc (1000_3A5C / 0x13A5C)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    State.IncCycles();
    // MOV [0x472d],AX (1000_3A5F / 0x13A5F)
    UInt16[DS, 0x472D] = AX;
    State.IncCycles();
    // MOV AX,BX (1000_3A62 / 0x13A62)
    AX = BX;
    State.IncCycles();
    // ADD AX,0x8 (1000_3A64 / 0x13A64)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    State.IncCycles();
    // MOV [0x472f],AX (1000_3A67 / 0x13A67)
    UInt16[DS, 0x472F] = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_3A6A_013A6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_3A6A_013A6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3A6A_13A6A:
    // PUSH CX (1000_3A6A / 0x13A6A)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH BX (1000_3A6B / 0x13A6B)
    Stack.Push(BX);
    State.IncCycles();
    // PUSH DX (1000_3A6C / 0x13A6C)
    Stack.Push(DX);
    State.IncCycles();
    // CALL 0x1000:3aa9 (1000_3A6D / 0x13A6D)
    NearCall(cs1, 0x3A70, spice86_generated_label_call_target_1000_3AA9_013AA9);
    State.IncCycles();
    label_1000_3A70_13A70:
    // POP DX (1000_3A70 / 0x13A70)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3A71 / 0x13A71)
    BX = Stack.Pop();
    State.IncCycles();
    // POP CX (1000_3A72 / 0x13A72)
    CX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3A73_013A73, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3A73_013A73(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x3A7B: goto label_1000_3A7B_13A7B;break; // Target of external jump from 0x13A37
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    State.IncCycles();
    label_1000_3A73_13A73:
    // ADD DX,0x46 (1000_3A73 / 0x13A73)
    DX += 0x46;
    State.IncCycles();
    // ADD BX,0xa (1000_3A76 / 0x13A76)
    // BX += 0xA;
    BX = Alu.Add16(BX, 0xA);
    State.IncCycles();
    // LOOP 0x1000:3a6a (1000_3A79 / 0x13A79)
    if(--CX != 0) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_3A6A_013A6A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    label_1000_3A7B_13A7B:
    // RET  (1000_3A7B / 0x13A7B)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3A7C_013A7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3A7C_13A7C:
    // CALL 0x1000:39e6 (1000_3A7C / 0x13A7C)
    NearCall(cs1, 0x3A7F, spice86_generated_label_call_target_1000_39E6_0139E6);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3A7F_013A7F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3A7F_013A7F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3A7F_13A7F:
    // MOV AX,[0x4] (1000_3A7F / 0x13A7F)
    AX = UInt16[DS, 0x4];
    State.IncCycles();
    // CMP AL,0x4 (1000_3A82 / 0x13A82)
    Alu.Sub8(AL, 0x4);
    State.IncCycles();
    // JNZ 0x1000:3a94 (1000_3A84 / 0x13A84)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3A94 / 0x13A94)
      return NearRet();
    }
    State.IncCycles();
    // CMP AH,0x20 (1000_3A86 / 0x13A86)
    Alu.Sub8(AH, 0x20);
    State.IncCycles();
    // JNC 0x1000:3a94 (1000_3A89 / 0x13A89)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3A94 / 0x13A94)
      return NearRet();
    }
    State.IncCycles();
    // MOV SI,0xc0b6 (1000_3A8B / 0x13A8B)
    SI = 0xC0B6;
    State.IncCycles();
    // MOV BP,0xc (1000_3A8E / 0x13A8E)
    BP = 0xC;
    State.IncCycles();
    // CALL 0x1000:da25 (1000_3A91 / 0x13A91)
    NearCall(cs1, 0x3A94, spice86_generated_label_call_target_1000_DA25_01DA25);
    State.IncCycles();
    label_1000_3A94_13A94:
    // RET  (1000_3A94 / 0x13A94)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3A95_013A95(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3A95_13A95:
    // MOV DX,0x95 (1000_3A95 / 0x13A95)
    DX = 0x95;
    State.IncCycles();
    // MOV BX,0x39 (1000_3A98 / 0x13A98)
    BX = 0x39;
    State.IncCycles();
    // CMP byte ptr [0x5],0x20 (1000_3A9B / 0x13A9B)
    Alu.Sub8(UInt8[DS, 0x5], 0x20);
    State.IncCycles();
    // JC 0x1000:3aa8 (1000_3AA0 / 0x13AA0)
    if(CarryFlag) {
      // JC target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3AA8 / 0x13AA8)
      return NearRet();
    }
    State.IncCycles();
    // MOV DX,0xca (1000_3AA2 / 0x13AA2)
    DX = 0xCA;
    State.IncCycles();
    // MOV BX,0x49 (1000_3AA5 / 0x13AA5)
    BX = 0x49;
    State.IncCycles();
    label_1000_3AA8_13AA8:
    // RET  (1000_3AA8 / 0x13AA8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3AA9_013AA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3AA9_13AA9:
    // XOR AX,AX (1000_3AA9 / 0x13AA9)
    AX = 0;
    State.IncCycles();
    // CALL 0x1000:c305 (1000_3AAB / 0x13AAB)
    NearCall(cs1, 0x3AAE, spice86_generated_label_call_target_1000_C305_01C305);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3AAE_013AAE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3AAE_013AAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3AAE_13AAE:
    // ADD DX,0x6 (1000_3AAE / 0x13AAE)
    DX += 0x6;
    State.IncCycles();
    // ADD BX,0x1e (1000_3AB1 / 0x13AB1)
    // BX += 0x1E;
    BX = Alu.Add16(BX, 0x1E);
    State.IncCycles();
    // MOV AX,0x1 (1000_3AB4 / 0x13AB4)
    AX = 0x1;
    State.IncCycles();
    // CALL 0x1000:c305 (1000_3AB7 / 0x13AB7)
    NearCall(cs1, 0x3ABA, spice86_generated_label_call_target_1000_C305_01C305);
    State.IncCycles();
    label_1000_3ABA_13ABA:
    // SUB DX,0x2 (1000_3ABA / 0x13ABA)
    DX -= 0x2;
    State.IncCycles();
    // ADD BX,0x14 (1000_3ABD / 0x13ABD)
    // BX += 0x14;
    BX = Alu.Add16(BX, 0x14);
    State.IncCycles();
    // MOV AL,[0x4731] (1000_3AC0 / 0x13AC0)
    AL = UInt8[DS, 0x4731];
    State.IncCycles();
    // XOR AH,AH (1000_3AC3 / 0x13AC3)
    AH = 0;
    State.IncCycles();
    // PUSH AX (1000_3AC5 / 0x13AC5)
    Stack.Push(AX);
    State.IncCycles();
    // SUB AL,0xf (1000_3AC6 / 0x13AC6)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JNC 0x1000:3acc (1000_3AC8 / 0x13AC8)
    if(!CarryFlag) {
      goto label_1000_3ACC_13ACC;
    }
    State.IncCycles();
    // XOR AX,AX (1000_3ACA / 0x13ACA)
    AX = 0;
    State.IncCycles();
    label_1000_3ACC_13ACC:
    // CMP AL,0x5 (1000_3ACC / 0x13ACC)
    Alu.Sub8(AL, 0x5);
    State.IncCycles();
    // JBE 0x1000:3ad2 (1000_3ACE / 0x13ACE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_3AD2_13AD2;
    }
    State.IncCycles();
    // MOV AL,0x5 (1000_3AD0 / 0x13AD0)
    AL = 0x5;
    State.IncCycles();
    label_1000_3AD2_13AD2:
    // ADD AL,0x2 (1000_3AD2 / 0x13AD2)
    // AL += 0x2;
    AL = Alu.Add8(AL, 0x2);
    State.IncCycles();
    // CALL 0x1000:c305 (1000_3AD4 / 0x13AD4)
    NearCall(cs1, 0x3AD7, spice86_generated_label_call_target_1000_C305_01C305);
    State.IncCycles();
    label_1000_3AD7_13AD7:
    // SUB DX,0x55 (1000_3AD7 / 0x13AD7)
    DX -= 0x55;
    State.IncCycles();
    // SUB BX,0x35 (1000_3ADA / 0x13ADA)
    // BX -= 0x35;
    BX = Alu.Sub16(BX, 0x35);
    State.IncCycles();
    // POP AX (1000_3ADD / 0x13ADD)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP AL,0xe (1000_3ADE / 0x13ADE)
    Alu.Sub8(AL, 0xE);
    State.IncCycles();
    // JC 0x1000:3ae4 (1000_3AE0 / 0x13AE0)
    if(CarryFlag) {
      goto label_1000_3AE4_13AE4;
    }
    State.IncCycles();
    // MOV AL,0xe (1000_3AE2 / 0x13AE2)
    AL = 0xE;
    State.IncCycles();
    label_1000_3AE4_13AE4:
    // ADD AL,0x8 (1000_3AE4 / 0x13AE4)
    // AL += 0x8;
    AL = Alu.Add8(AL, 0x8);
    State.IncCycles();
    // JMP 0x1000:c30d (1000_3AE6 / 0x13AE6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C30D_01C30D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3AE9_013AE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3AE9_13AE9:
    // PUSH AX (1000_3AE9 / 0x13AE9)
    Stack.Push(AX);
    State.IncCycles();
    // PUSH DS (1000_3AEA / 0x13AEA)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_3AEB / 0x13AEB)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV CX,0x2e (1000_3AEC / 0x13AEC)
    CX = 0x2E;
    State.IncCycles();
    // MOV AX,0xffff (1000_3AEF / 0x13AEF)
    AX = 0xFFFF;
    State.IncCycles();
    // MOV DI,0x47f8 (1000_3AF2 / 0x13AF2)
    DI = 0x47F8;
    State.IncCycles();
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_3AF5 / 0x13AF5)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    State.IncCycles();
    // POP AX (1000_3AF7 / 0x13AF7)
    AX = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3AF8 / 0x13AF8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3AF9_013AF9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3AF9_13AF9:
    // CMP byte ptr [0x2b],0x0 (1000_3AF9 / 0x13AF9)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    State.IncCycles();
    // JZ 0x1000:3b03 (1000_3AFE / 0x13AFE)
    if(ZeroFlag) {
      goto label_1000_3B03_13B03;
    }
    State.IncCycles();
    // JMP 0x1000:c43e (1000_3B00 / 0x13B00)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C43E_01C43E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_3B03_13B03:
    // CMP byte ptr [0x47a4],0x0 (1000_3B03 / 0x13B03)
    Alu.Sub8(UInt8[DS, 0x47A4], 0x0);
    State.IncCycles();
    // JS 0x1000:3b58 (1000_3B08 / 0x13B08)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3B58 / 0x13B58)
      return NearRet();
    }
    State.IncCycles();
    // MOV AX,[0x47c4] (1000_3B0A / 0x13B0A)
    AX = UInt16[DS, 0x47C4];
    State.IncCycles();
    // CMP AL,0xf (1000_3B0D / 0x13B0D)
    Alu.Sub8(AL, 0xF);
    State.IncCycles();
    // JNZ 0x1000:3b15 (1000_3B0F / 0x13B0F)
    if(!ZeroFlag) {
      goto label_1000_3B15_13B15;
    }
    State.IncCycles();
    // ADD AL,byte ptr [0x476c] (1000_3B11 / 0x13B11)
    // AL += UInt8[DS, 0x476C];
    AL = Alu.Add8(AL, UInt8[DS, 0x476C]);
    State.IncCycles();
    label_1000_3B15_13B15:
    // MOV DI,AX (1000_3B15 / 0x13B15)
    DI = AX;
    State.IncCycles();
    // SHL DI,1 (1000_3B17 / 0x13B17)
    DI <<= 0x1;
    State.IncCycles();
    // SHL DI,1 (1000_3B19 / 0x13B19)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    State.IncCycles();
    // MOV DX,word ptr [DI + 0x47f8] (1000_3B1B / 0x13B1B)
    DX = UInt16[DS, (ushort)(DI + 0x47F8)];
    State.IncCycles();
    // OR DX,DX (1000_3B1F / 0x13B1F)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    State.IncCycles();
    // JS 0x1000:3b58 (1000_3B21 / 0x13B21)
    if(SignFlag) {
      // JS target is RET, inlining.
      State.IncCycles();
      // RET  (1000_3B58 / 0x13B58)
      return NearRet();
    }
    State.IncCycles();
    // PUSH word ptr [DI + 0x47fa] (1000_3B23 / 0x13B23)
    Stack.Push(UInt16[DS, (ushort)(DI + 0x47FA)]);
    State.IncCycles();
    // PUSH DX (1000_3B27 / 0x13B27)
    Stack.Push(DX);
    State.IncCycles();
    // OR byte ptr [0x47a4],0x80 (1000_3B28 / 0x13B28)
    // UInt8[DS, 0x47A4] |= 0x80;
    UInt8[DS, 0x47A4] = Alu.Or8(UInt8[DS, 0x47A4], 0x80);
    State.IncCycles();
    // CALL 0x1000:37b5 (1000_3B2D / 0x13B2D)
    NearCall(cs1, 0x3B30, spice86_generated_label_ret_target_1000_37B5_0137B5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B30_013B30, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3B30_013B30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3B30_13B30:
    // POP DX (1000_3B30 / 0x13B30)
    DX = Stack.Pop();
    State.IncCycles();
    // POP BX (1000_3B31 / 0x13B31)
    BX = Stack.Pop();
    State.IncCycles();
    // CMP DX,0xf0 (1000_3B32 / 0x13B32)
    Alu.Sub16(DX, 0xF0);
    State.IncCycles();
    // JC 0x1000:3b3b (1000_3B36 / 0x13B36)
    if(CarryFlag) {
      goto label_1000_3B3B_13B3B;
    }
    State.IncCycles();
    // MOV DX,0xf0 (1000_3B38 / 0x13B38)
    DX = 0xF0;
    State.IncCycles();
    label_1000_3B3B_13B3B:
    // CMP BX,0x71 (1000_3B3B / 0x13B3B)
    Alu.Sub16(BX, 0x71);
    State.IncCycles();
    // JC 0x1000:3b43 (1000_3B3E / 0x13B3E)
    if(CarryFlag) {
      goto label_1000_3B43_13B43;
    }
    State.IncCycles();
    // MOV BX,0x71 (1000_3B40 / 0x13B40)
    BX = 0x71;
    State.IncCycles();
    label_1000_3B43_13B43:
    // MOV ES,word ptr [0xdbde] (1000_3B43 / 0x13B43)
    ES = UInt16[DS, 0xDBDE];
    State.IncCycles();
    // PUSH DS (1000_3B47 / 0x13B47)
    Stack.Push(DS);
    State.IncCycles();
    // MOV DS,word ptr [0xdbda] (1000_3B48 / 0x13B48)
    DS = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // MOV BP,0x6 (1000_3B4C / 0x13B4C)
    BP = 0x6;
    State.IncCycles();
    // CALLF [0x3949] (1000_3B4F / 0x13B4F)
    // Indirect call to [0x3949], generating possible targets from emulator records
    uint targetAddress_1000_3B4F = (uint)(UInt16[SS, 0x394B] * 0x10 + UInt16[SS, 0x3949] - cs1 * 0x10);
    switch(targetAddress_1000_3B4F) {
      case 0x2361F : FarCall(cs1, 0x3B54, spice86_generated_label_call_target_334B_016F_03361F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3B4F));
        break;
    }
    State.IncCycles();
    label_1000_3B54_13B54:
    // POP DS (1000_3B54 / 0x13B54)
    DS = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:c43e (1000_3B55 / 0x13B55)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C43E_01C43E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_3B58_013B58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3B58_13B58:
    // RET  (1000_3B58 / 0x13B58)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3B59_013B59(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3B59_13B59:
    // SUB SP,0x18 (1000_3B59 / 0x13B59)
    // SP -= 0x18;
    SP = Alu.Sub16(SP, 0x18);
    State.IncCycles();
    // MOV word ptr [0x47f6],SP (1000_3B5C / 0x13B5C)
    UInt16[DS, 0x47F6] = SP;
    State.IncCycles();
    // XOR AH,AH (1000_3B60 / 0x13B60)
    AH = 0;
    State.IncCycles();
    // DEC AX (1000_3B62 / 0x13B62)
    AX = Alu.Dec16(AX);
    State.IncCycles();
    // PUSH AX (1000_3B63 / 0x13B63)
    Stack.Push(AX);
    State.IncCycles();
    // MOV CL,0x4 (1000_3B64 / 0x13B64)
    CL = 0x4;
    State.IncCycles();
    // SHR AX,CL (1000_3B66 / 0x13B66)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    State.IncCycles();
    // JZ 0x1000:3b70 (1000_3B68 / 0x13B68)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B70_013B70, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    State.IncCycles();
    // ADD AX,0x13 (1000_3B6A / 0x13B6A)
    // AX += 0x13;
    AX = Alu.Add16(AX, 0x13);
    State.IncCycles();
    // CALL 0x1000:c13e (1000_3B6D / 0x13B6D)
    NearCall(cs1, 0x3B70, spice86_generated_label_call_target_1000_C13E_01C13E);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B70_013B70, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3B70_013B70(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3B70_13B70:
    // POP AX (1000_3B70 / 0x13B70)
    AX = Stack.Pop();
    State.IncCycles();
    // AND AX,0xf (1000_3B71 / 0x13B71)
    AX &= 0xF;
    State.IncCycles();
    // SHL AX,1 (1000_3B74 / 0x13B74)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV SI,0xbc6e (1000_3B76 / 0x13B76)
    SI = 0xBC6E;
    State.IncCycles();
    // ADD SI,AX (1000_3B79 / 0x13B79)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    State.IncCycles();
    // MOV SI,word ptr [SI] (1000_3B7B / 0x13B7B)
    SI = UInt16[DS, SI];
    State.IncCycles();
    // CALL 0x1000:3d83 (1000_3B7D / 0x13B7D)
    NearCall(cs1, 0x3B80, spice86_generated_label_call_target_1000_3D83_013D83);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_3B80_013B80, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_3B80_013B80(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3B80_13B80:
    // LODSW SI (1000_3B80 / 0x13B80)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // CMP AX,0xffff (1000_3B81 / 0x13B81)
    Alu.Sub16(AX, 0xFFFF);
    State.IncCycles();
    // JZ 0x1000:3bb5 (1000_3B84 / 0x13B84)
    if(ZeroFlag) {
      goto label_1000_3BB5_13BB5;
    }
    State.IncCycles();
    // JS 0x1000:3bbf (1000_3B86 / 0x13B86)
    if(SignFlag) {
      goto label_1000_3BBF_13BBF;
    }
    State.IncCycles();
    // MOV DI,AX (1000_3B88 / 0x13B88)
    DI = AX;
    State.IncCycles();
    // SHR AH,1 (1000_3B8A / 0x13B8A)
    AH >>= 0x1;
    State.IncCycles();
    // AND AH,0x1 (1000_3B8C / 0x13B8C)
    // AH &= 0x1;
    AH = Alu.And8(AH, 0x1);
    State.IncCycles();
    // LODSB SI (1000_3B8F / 0x13B8F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // MOV DX,AX (1000_3B90 / 0x13B90)
    DX = AX;
    State.IncCycles();
    // LODSB SI (1000_3B92 / 0x13B92)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // XOR AH,AH (1000_3B93 / 0x13B93)
    AH = 0;
    State.IncCycles();
    // MOV BX,AX (1000_3B95 / 0x13B95)
    BX = AX;
    State.IncCycles();
    // LODSB SI (1000_3B97 / 0x13B97)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // PUSH SI (1000_3B98 / 0x13B98)
    Stack.Push(SI);
    State.IncCycles();
    // MOV CS:[0xc21a],AL (1000_3B99 / 0x13B99)
    UInt8[cs1, 0xC21A] = AL;
    State.IncCycles();
    // MOV AX,DI (1000_3B9D / 0x13B9D)
    AX = DI;
    State.IncCycles();
    // AND AX,0xfdff (1000_3B9F / 0x13B9F)
    AX &= 0xFDFF;
    State.IncCycles();
    // DEC AX (1000_3BA2 / 0x13BA2)
    AX--;
    State.IncCycles();
    // AND DI,0x1ff (1000_3BA3 / 0x13BA3)
    DI &= 0x1FF;
    State.IncCycles();
    // CMP DI,0x1 (1000_3BA7 / 0x13BA7)
    Alu.Sub16(DI, 0x1);
    State.IncCycles();
    // JNZ 0x1000:3baf (1000_3BAA / 0x13BAA)
    if(!ZeroFlag) {
      goto label_1000_3BAF_13BAF;
    }
    State.IncCycles();
    // JMP 0x1000:3d12 (1000_3BAC / 0x13BAC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_3D12_013D12, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    State.IncCycles();
    label_1000_3BAF_13BAF:
    // CALL 0x1000:c22f (1000_3BAF / 0x13BAF)
    NearCall(cs1, 0x3BB2, spice86_generated_label_call_target_1000_C22F_01C22F);
    State.IncCycles();
    label_1000_3BB2_13BB2:
    // POP SI (1000_3BB2 / 0x13BB2)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:3b80 (1000_3BB3 / 0x13BB3)
    goto label_1000_3B80_13B80;
    State.IncCycles();
    label_1000_3BB5_13BB5:
    // MOV byte ptr CS:[0xc21a],0x0 (1000_3BB5 / 0x13BB5)
    UInt8[cs1, 0xC21A] = 0x0;
    State.IncCycles();
    // ADD SP,0x18 (1000_3BBB / 0x13BBB)
    // SP += 0x18;
    SP = Alu.Add16(SP, 0x18);
    State.IncCycles();
    // RET  (1000_3BBE / 0x13BBE)
    return NearRet();
    State.IncCycles();
    label_1000_3BBF_13BBF:
    // CMP AH,0xc0 (1000_3BBF / 0x13BBF)
    Alu.Sub8(AH, 0xC0);
    State.IncCycles();
    // JZ 0x1000:3bc9 (1000_3BC2 / 0x13BC2)
    if(ZeroFlag) {
      goto label_1000_3BC9_13BC9;
    }
    State.IncCycles();
    // CALL 0x1000:3be9 (1000_3BC4 / 0x13BC4)
    NearCall(cs1, 0x3BC7, spice86_generated_label_call_target_1000_3BE9_013BE9);
    State.IncCycles();
    label_1000_3BC7_13BC7:
    // JMP 0x1000:3b80 (1000_3BC7 / 0x13BC7)
    goto label_1000_3B80_13B80;
    State.IncCycles();
    label_1000_3BC9_13BC9:
    // PUSH AX (1000_3BC9 / 0x13BC9)
    Stack.Push(AX);
    State.IncCycles();
    // MOV ES,word ptr [0xdbda] (1000_3BCA / 0x13BCA)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // LODSW SI (1000_3BCE / 0x13BCE)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_3BCF / 0x13BCF)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_3BD1 / 0x13BD1)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_3BD2 / 0x13BD2)
    BX = AX;
    State.IncCycles();
    // LODSW SI (1000_3BD4 / 0x13BD4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DI,AX (1000_3BD5 / 0x13BD5)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_3BD7 / 0x13BD7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_3BD8 / 0x13BD8)
    CX = AX;
    State.IncCycles();
    // POP AX (1000_3BDA / 0x13BDA)
    AX = Stack.Pop();
    State.IncCycles();
    // PUSH SI (1000_3BDB / 0x13BDB)
    Stack.Push(SI);
    State.IncCycles();
    // MOV BP,0xffff (1000_3BDC / 0x13BDC)
    BP = 0xFFFF;
    State.IncCycles();
    // MOV SI,0x1470 (1000_3BDF / 0x13BDF)
    SI = 0x1470;
    State.IncCycles();
    // CALLF [0x3901] (1000_3BE2 / 0x13BE2)
    // Indirect call to [0x3901], generating possible targets from emulator records
    uint targetAddress_1000_3BE2 = (uint)(UInt16[DS, 0x3903] * 0x10 + UInt16[DS, 0x3901] - cs1 * 0x10);
    switch(targetAddress_1000_3BE2) {
      case 0x235E9 : FarCall(cs1, 0x3BE6, spice86_generated_label_call_target_334B_0139_0335E9); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3BE2));
        break;
    }
    State.IncCycles();
    label_1000_3BE6_13BE6:
    // POP SI (1000_3BE6 / 0x13BE6)
    SI = Stack.Pop();
    State.IncCycles();
    // JMP 0x1000:3b80 (1000_3BE7 / 0x13BE7)
    goto label_1000_3B80_13B80;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_3BE9_013BE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    State.IncCycles();
    label_1000_3BE9_13BE9:
    // MOV word ptr [0x22d9],0x4c60 (1000_3BE9 / 0x13BE9)
    UInt16[DS, 0x22D9] = 0x4C60;
    State.IncCycles();
    // PUSH DS (1000_3BEF / 0x13BEF)
    Stack.Push(DS);
    State.IncCycles();
    // POP ES (1000_3BF0 / 0x13BF0)
    ES = Stack.Pop();
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x2] (1000_3BF1 / 0x13BF1)
    AL = UInt8[DS, (ushort)(SI - 0x2)];
    State.IncCycles();
    // MOV [0x47ed],AL (1000_3BF4 / 0x13BF4)
    UInt8[DS, 0x47ED] = AL;
    State.IncCycles();
    // MOV AL,byte ptr [SI + -0x1] (1000_3BF7 / 0x13BF7)
    AL = UInt8[DS, (ushort)(SI - 0x1)];
    State.IncCycles();
    // MOV [0x47ec],AL (1000_3BFA / 0x13BFA)
    UInt8[DS, 0x47EC] = AL;
    State.IncCycles();
    // LODSB SI (1000_3BFD / 0x13BFD)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CBW  (1000_3BFE / 0x13BFE)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SHL AX,1 (1000_3BFF / 0x13BFF)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3C01 / 0x13C01)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3C03 / 0x13C03)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3C05 / 0x13C05)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV [0x22db],AX (1000_3C07 / 0x13C07)
    UInt16[DS, 0x22DB] = AX;
    State.IncCycles();
    // LODSB SI (1000_3C0A / 0x13C0A)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    State.IncCycles();
    // CBW  (1000_3C0B / 0x13C0B)
    AX = (ushort)((short)((sbyte)AL));
    State.IncCycles();
    // SHL AX,1 (1000_3C0C / 0x13C0C)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3C0E / 0x13C0E)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3C10 / 0x13C10)
    AX <<= 0x1;
    State.IncCycles();
    // SHL AX,1 (1000_3C12 / 0x13C12)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    State.IncCycles();
    // MOV [0x22dd],AX (1000_3C14 / 0x13C14)
    UInt16[DS, 0x22DD] = AX;
    State.IncCycles();
    // LODSW SI (1000_3C17 / 0x13C17)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_3C18 / 0x13C18)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_3C1A / 0x13C1A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV BX,AX (1000_3C1B / 0x13C1B)
    BX = AX;
    State.IncCycles();
    // MOV word ptr [0x47ee],DX (1000_3C1D / 0x13C1D)
    UInt16[DS, 0x47EE] = DX;
    State.IncCycles();
    // MOV word ptr [0x47f0],BX (1000_3C21 / 0x13C21)
    UInt16[DS, 0x47F0] = BX;
    State.IncCycles();
    label_1000_3C25_13C25:
    // LODSW SI (1000_3C25 / 0x13C25)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // PUSH AX (1000_3C26 / 0x13C26)
    Stack.Push(AX);
    State.IncCycles();
    // AND AX,0x3fff (1000_3C27 / 0x13C27)
    // AX &= 0x3FFF;
    AX = Alu.And16(AX, 0x3FFF);
    State.IncCycles();
    // MOV DI,AX (1000_3C2A / 0x13C2A)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_3C2C / 0x13C2C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_3C2D / 0x13C2D)
    CX = AX;
    State.IncCycles();
    // CALL 0x1000:3e13 (1000_3C2F / 0x13C2F)
    NearCall(cs1, 0x3C32, spice86_generated_label_call_target_1000_3E13_013E13);
    State.IncCycles();
    label_1000_3C32_13C32:
    // MOV DX,DI (1000_3C32 / 0x13C32)
    DX = DI;
    State.IncCycles();
    // MOV BX,CX (1000_3C34 / 0x13C34)
    BX = CX;
    State.IncCycles();
    // POP AX (1000_3C36 / 0x13C36)
    AX = Stack.Pop();
    State.IncCycles();
    // TEST AX,0x4000 (1000_3C37 / 0x13C37)
    Alu.And16(AX, 0x4000);
    State.IncCycles();
    // JZ 0x1000:3c25 (1000_3C3A / 0x13C3A)
    if(ZeroFlag) {
      goto label_1000_3C25_13C25;
    }
    State.IncCycles();
    // MOV word ptr [0x47f2],DI (1000_3C3C / 0x13C3C)
    UInt16[DS, 0x47F2] = DI;
    State.IncCycles();
    // MOV word ptr [0x47f4],CX (1000_3C40 / 0x13C40)
    UInt16[DS, 0x47F4] = CX;
    State.IncCycles();
    // MOV DX,word ptr [0x47ee] (1000_3C44 / 0x13C44)
    DX = UInt16[DS, 0x47EE];
    State.IncCycles();
    // MOV BX,word ptr [0x47f0] (1000_3C48 / 0x13C48)
    BX = UInt16[DS, 0x47F0];
    State.IncCycles();
    // MOV word ptr [0x22d9],0x4c62 (1000_3C4C / 0x13C4C)
    UInt16[DS, 0x22D9] = 0x4C62;
    State.IncCycles();
    // TEST AX,0x8000 (1000_3C52 / 0x13C52)
    Alu.And16(AX, 0x8000);
    State.IncCycles();
    // JNZ 0x1000:3c71 (1000_3C55 / 0x13C55)
    if(!ZeroFlag) {
      goto label_1000_3C71_13C71;
    }
    State.IncCycles();
    label_1000_3C57_13C57:
    // LODSW SI (1000_3C57 / 0x13C57)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // PUSH AX (1000_3C58 / 0x13C58)
    Stack.Push(AX);
    State.IncCycles();
    // AND AX,0x3fff (1000_3C59 / 0x13C59)
    // AX &= 0x3FFF;
    AX = Alu.And16(AX, 0x3FFF);
    State.IncCycles();
    // MOV DI,AX (1000_3C5C / 0x13C5C)
    DI = AX;
    State.IncCycles();
    // LODSW SI (1000_3C5E / 0x13C5E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_3C5F / 0x13C5F)
    CX = AX;
    State.IncCycles();
    // CALL 0x1000:3e13 (1000_3C61 / 0x13C61)
    NearCall(cs1, 0x3C64, spice86_generated_label_call_target_1000_3E13_013E13);
    State.IncCycles();
    label_1000_3C64_13C64:
    // MOV DX,DI (1000_3C64 / 0x13C64)
    DX = DI;
    State.IncCycles();
    // MOV BX,CX (1000_3C66 / 0x13C66)
    BX = CX;
    State.IncCycles();
    // POP AX (1000_3C68 / 0x13C68)
    AX = Stack.Pop();
    State.IncCycles();
    // OR AX,AX (1000_3C69 / 0x13C69)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    State.IncCycles();
    // JNS 0x1000:3c57 (1000_3C6B / 0x13C6B)
    if(!SignFlag) {
      goto label_1000_3C57_13C57;
    }
    State.IncCycles();
    // MOV DX,DI (1000_3C6D / 0x13C6D)
    DX = DI;
    State.IncCycles();
    // MOV BX,CX (1000_3C6F / 0x13C6F)
    BX = CX;
    State.IncCycles();
    label_1000_3C71_13C71:
    // MOV DI,word ptr [0x47f2] (1000_3C71 / 0x13C71)
    DI = UInt16[DS, 0x47F2];
    State.IncCycles();
    // MOV CX,word ptr [0x47f4] (1000_3C75 / 0x13C75)
    CX = UInt16[DS, 0x47F4];
    State.IncCycles();
    // CALL 0x1000:3e13 (1000_3C79 / 0x13C79)
    NearCall(cs1, 0x3C7C, spice86_generated_label_call_target_1000_3E13_013E13);
    State.IncCycles();
    label_1000_3C7C_13C7C:
    // MOV ES,word ptr [0xdbda] (1000_3C7C / 0x13C7C)
    ES = UInt16[DS, 0xDBDA];
    State.IncCycles();
    // PUSH SI (1000_3C80 / 0x13C80)
    Stack.Push(SI);
    State.IncCycles();
    // MOV BX,word ptr [0x47f0] (1000_3C81 / 0x13C81)
    BX = UInt16[DS, 0x47F0];
    State.IncCycles();
    // MOV BP,word ptr [0x47f4] (1000_3C85 / 0x13C85)
    BP = UInt16[DS, 0x47F4];
    State.IncCycles();
    // SUB BP,BX (1000_3C89 / 0x13C89)
    // BP -= BX;
    BP = Alu.Sub16(BP, BX);
    State.IncCycles();
    // LEA SI,[0x4c60] (1000_3C8B / 0x13C8B)
    SI = 0x4C60;
    State.IncCycles();
    // MOV CX,BP (1000_3C8F / 0x13C8F)
    CX = BP;
    State.IncCycles();
    // MOV BP,0x0 (1000_3C91 / 0x13C91)
    BP = 0x0;
    State.IncCycles();
    // MOV AH,byte ptr [0x47ec] (1000_3C94 / 0x13C94)
    AH = UInt8[DS, 0x47EC];
    State.IncCycles();
    // AND AH,0x3e (1000_3C98 / 0x13C98)
    // AH &= 0x3E;
    AH = Alu.And8(AH, 0x3E);
    State.IncCycles();
    // JZ 0x1000:3ca0 (1000_3C9B / 0x13C9B)
    if(ZeroFlag) {
      goto label_1000_3CA0_13CA0;
    }
    State.IncCycles();
    // MOV BP,0x1 (1000_3C9D / 0x13C9D)
    BP = 0x1;
    State.IncCycles();
    label_1000_3CA0_13CA0:
    // MOV AL,0x2 (1000_3CA0 / 0x13CA0)
    AL = 0x2;
    State.IncCycles();
    // MOV [0x22df],AX (1000_3CA2 / 0x13CA2)
    UInt16[DS, 0x22DF] = AX;
    State.IncCycles();
    // MOV AH,byte ptr [0x47ed] (1000_3CA5 / 0x13CA5)
    AH = UInt8[DS, 0x47ED];
    State.IncCycles();
    // XOR AL,AL (1000_3CA9 / 0x13CA9)
    AL = 0;
    State.IncCycles();
    // TEST byte ptr [0x47ec],0x1 (1000_3CAB / 0x13CAB)
    Alu.And8(UInt8[DS, 0x47EC], 0x1);
    State.IncCycles();
    // JNZ 0x1000:3ce0 (1000_3CB0 / 0x13CB0)
    if(!ZeroFlag) {
      goto label_1000_3CE0_13CE0;
    }
    State.IncCycles();
    label_1000_3CB2_13CB2:
    // PUSH CX (1000_3CB2 / 0x13CB2)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH AX (1000_3CB3 / 0x13CB3)
    Stack.Push(AX);
    State.IncCycles();
    // LODSW SI (1000_3CB4 / 0x13CB4)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_3CB5 / 0x13CB5)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_3CB7 / 0x13CB7)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_3CB8 / 0x13CB8)
    CX = AX;
    State.IncCycles();
    // POP AX (1000_3CBA / 0x13CBA)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP DX,CX (1000_3CBB / 0x13CBB)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JC 0x1000:3cc1 (1000_3CBD / 0x13CBD)
    if(CarryFlag) {
      goto label_1000_3CC1_13CC1;
    }
    State.IncCycles();
    // XCHG CX,DX (1000_3CBF / 0x13CBF)
    ushort tmp_1000_3CBF = CX;
    CX = DX;
    DX = tmp_1000_3CBF;
    State.IncCycles();
    label_1000_3CC1_13CC1:
    // INC CX (1000_3CC1 / 0x13CC1)
    CX++;
    State.IncCycles();
    // SUB CX,DX (1000_3CC2 / 0x13CC2)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    State.IncCycles();
    // JZ 0x1000:3cd6 (1000_3CC4 / 0x13CC4)
    if(ZeroFlag) {
      goto label_1000_3CD6_13CD6;
    }
    State.IncCycles();
    // PUSH SI (1000_3CC6 / 0x13CC6)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH BX (1000_3CC7 / 0x13CC7)
    Stack.Push(BX);
    State.IncCycles();
    // MOV SI,word ptr [0x22df] (1000_3CC8 / 0x13CC8)
    SI = UInt16[DS, 0x22DF];
    State.IncCycles();
    // MOV DI,word ptr [0x22db] (1000_3CCC / 0x13CCC)
    DI = UInt16[DS, 0x22DB];
    State.IncCycles();
    // CALLF [0x3945] (1000_3CD0 / 0x13CD0)
    // Indirect call to [0x3945], generating possible targets from emulator records
    uint targetAddress_1000_3CD0 = (uint)(UInt16[DS, 0x3947] * 0x10 + UInt16[DS, 0x3945] - cs1 * 0x10);
    switch(targetAddress_1000_3CD0) {
      case 0x2361C : FarCall(cs1, 0x3CD4, spice86_generated_label_call_target_334B_016C_03361C); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3CD0));
        break;
    }
    State.IncCycles();
    label_1000_3CD4_13CD4:
    // POP BX (1000_3CD4 / 0x13CD4)
    BX = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_3CD5 / 0x13CD5)
    SI = Stack.Pop();
    State.IncCycles();
    label_1000_3CD6_13CD6:
    // ADD AX,word ptr [0x22dd] (1000_3CD6 / 0x13CD6)
    AX += UInt16[DS, 0x22DD];
    State.IncCycles();
    // INC BX (1000_3CDA / 0x13CDA)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // POP CX (1000_3CDB / 0x13CDB)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:3cb2 (1000_3CDC / 0x13CDC)
    if(--CX != 0) {
      goto label_1000_3CB2_13CB2;
    }
    State.IncCycles();
    // POP SI (1000_3CDE / 0x13CDE)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3CDF / 0x13CDF)
    return NearRet();
    State.IncCycles();
    label_1000_3CE0_13CE0:
    // PUSH CX (1000_3CE0 / 0x13CE0)
    Stack.Push(CX);
    State.IncCycles();
    // PUSH AX (1000_3CE1 / 0x13CE1)
    Stack.Push(AX);
    State.IncCycles();
    // LODSW SI (1000_3CE2 / 0x13CE2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV DX,AX (1000_3CE3 / 0x13CE3)
    DX = AX;
    State.IncCycles();
    // LODSW SI (1000_3CE5 / 0x13CE5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    State.IncCycles();
    // MOV CX,AX (1000_3CE6 / 0x13CE6)
    CX = AX;
    State.IncCycles();
    // POP AX (1000_3CE8 / 0x13CE8)
    AX = Stack.Pop();
    State.IncCycles();
    // CMP DX,CX (1000_3CE9 / 0x13CE9)
    Alu.Sub16(DX, CX);
    State.IncCycles();
    // JNC 0x1000:3cef (1000_3CEB / 0x13CEB)
    if(!CarryFlag) {
      goto label_1000_3CEF_13CEF;
    }
    State.IncCycles();
    // XCHG CX,DX (1000_3CED / 0x13CED)
    ushort tmp_1000_3CED = CX;
    CX = DX;
    DX = tmp_1000_3CED;
    State.IncCycles();
    label_1000_3CEF_13CEF:
    // DEC CX (1000_3CEF / 0x13CEF)
    CX--;
    State.IncCycles();
    // SUB CX,DX (1000_3CF0 / 0x13CF0)
    // CX -= DX;
    CX = Alu.Sub16(CX, DX);
    State.IncCycles();
    // JZ 0x1000:3d08 (1000_3CF2 / 0x13CF2)
    if(ZeroFlag) {
      goto label_1000_3D08_13D08;
    }
    State.IncCycles();
    // NEG CX (1000_3CF4 / 0x13CF4)
    CX = Alu.Sub16(0, CX);
    State.IncCycles();
    // PUSH SI (1000_3CF6 / 0x13CF6)
    Stack.Push(SI);
    State.IncCycles();
    // PUSH BX (1000_3CF7 / 0x13CF7)
    Stack.Push(BX);
    State.IncCycles();
    // MOV SI,word ptr [0x22df] (1000_3CF8 / 0x13CF8)
    SI = UInt16[DS, 0x22DF];
    State.IncCycles();
    // MOV DI,word ptr [0x22db] (1000_3CFC / 0x13CFC)
    DI = UInt16[DS, 0x22DB];
    State.IncCycles();
    // STD  (1000_3D00 / 0x13D00)
    DirectionFlag = true;
    State.IncCycles();
    // CALLF [0x3945] (1000_3D01 / 0x13D01)
    // Indirect call to [0x3945], generating possible targets from emulator records
    uint targetAddress_1000_3D01 = (uint)(UInt16[DS, 0x3947] * 0x10 + UInt16[DS, 0x3945] - cs1 * 0x10);
    switch(targetAddress_1000_3D01) {
      case 0x2361C : FarCall(cs1, 0x3D05, spice86_generated_label_call_target_334B_016C_03361C); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3D01));
        break;
    }
    State.IncCycles();
    label_1000_3D05_13D05:
    // POP BX (1000_3D05 / 0x13D05)
    BX = Stack.Pop();
    State.IncCycles();
    // POP SI (1000_3D06 / 0x13D06)
    SI = Stack.Pop();
    State.IncCycles();
    // CLD  (1000_3D07 / 0x13D07)
    DirectionFlag = false;
    State.IncCycles();
    label_1000_3D08_13D08:
    // ADD AX,word ptr [0x22dd] (1000_3D08 / 0x13D08)
    AX += UInt16[DS, 0x22DD];
    State.IncCycles();
    // INC BX (1000_3D0C / 0x13D0C)
    BX = Alu.Inc16(BX);
    State.IncCycles();
    // POP CX (1000_3D0D / 0x13D0D)
    CX = Stack.Pop();
    State.IncCycles();
    // LOOP 0x1000:3ce0 (1000_3D0E / 0x13D0E)
    if(--CX != 0) {
      goto label_1000_3CE0_13CE0;
    }
    State.IncCycles();
    // POP SI (1000_3D10 / 0x13D10)
    SI = Stack.Pop();
    State.IncCycles();
    // RET  (1000_3D11 / 0x13D11)
    return NearRet();
  }
  
}
