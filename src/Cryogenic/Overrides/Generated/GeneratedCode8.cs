namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_C92B_01C92B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_ret_target_1000_C93C_01C93C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    SI = Alu.Dec16(SI);
    label_1000_C9AD_1C9AD:
    // INC SI (1000_C9AD / 0x1C9AD)
    SI = Alu.Inc16(SI);
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
  
  public Action hnm_do_frame_skippable_ida_1000_C9E8_1C9E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_C9E8_1C9E8:
    // CALL 0x1000:ca60 (1000_C9E8 / 0x1C9E8)
    NearCall(cs1, 0xC9EB, spice86_generated_label_call_target_1000_CA60_01CA60);
    // CALL 0x1000:dd63 (1000_C9EB / 0x1C9EB)
    NearCall(cs1, 0xC9EE, spice86_generated_label_call_target_1000_DD63_01DD63);
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
  
  public Action spice86_generated_label_call_target_1000_C9F4_01C9F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CA01_01CA01(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CA1B_01CA1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CA1B_1CA1B:
    // CALL 0x1000:c92b (1000_CA1B / 0x1CA1B)
    NearCall(cs1, 0xCA1E, spice86_generated_label_call_target_1000_C92B_01C92B);
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
    UInt16[DS, 0xDBE8] = Alu.Inc16(UInt16[DS, 0xDBE8]);
    // INC word ptr [0xdbea] (1000_CA44 / 0x1CA44)
    UInt16[DS, 0xDBEA] = Alu.Inc16(UInt16[DS, 0xDBEA]);
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
  
  public Action spice86_generated_label_call_target_1000_CA59_01CA59(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CA60_01CA60(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CA60_1CA60:
    // CMP word ptr [0x35a6],0x0 (1000_CA60 / 0x1CA60)
    Alu.Sub16(UInt16[DS, 0x35A6], 0x0);
    // JZ 0x1000:ca9a (1000_CA65 / 0x1CA65)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_CA9A_01CA9A, 0)) {
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
    label_1000_CA74_1CA74:
    // JNC 0x1000:ca7b (1000_CA74 / 0x1CA74)
    if(!CarryFlag) {
      goto label_1000_CA7B_1CA7B;
    }
    // CALL 0x1000:cb1a (1000_CA76 / 0x1CA76)
    NearCall(cs1, 0xCA79, spice86_generated_label_ret_target_1000_CB1A_01CB1A);
    // JMP 0x1000:ca60 (1000_CA79 / 0x1CA79)
    goto label_1000_CA60_1CA60;
    label_1000_CA7B_1CA7B:
    // CALL 0x1000:cad4 (1000_CA7B / 0x1CA7B)
    NearCall(cs1, 0xCA7E, spice86_generated_label_call_target_1000_CAD4_01CAD4);
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
      goto label_1000_CA89_1CA89;
    }
    // CALL 0x1000:ce3b (1000_CA86 / 0x1CA86)
    NearCall(cs1, 0xCA89, hnm_handle_pal_chunk_ida_1000_CE3B_1CE3B);
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
  
  public Action spice86_generated_label_ret_target_1000_CA8F_01CA8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    if(JumpDispatcher.Jump(split_1000_CA9A_01CA9A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_CA9A_01CA9A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CA9A_1CA9A:
    // MOV byte ptr [0xdbb5],0x0 (1000_CA9A / 0x1CA9A)
    UInt8[DS, 0xDBB5] = 0x0;
    // RET  (1000_CA9F / 0x1CA9F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_CAA0_01CAA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_CAD1_1CAD1:
    // XOR AX,AX (1000_CAD1 / 0x1CAD1)
    AX = 0;
    label_1000_CAD3_1CAD3:
    // RET  (1000_CAD3 / 0x1CAD3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_CAD4_01CAD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CAD4_1CAD4:
    // MOV AX,[0xdc1c] (1000_CAD4 / 0x1CAD4)
    AX = UInt16[DS, 0xDC1C];
    // INC AX (1000_CAD7 / 0x1CAD7)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:caf0 (1000_CAD8 / 0x1CAD8)
    if(!ZeroFlag) {
      goto label_1000_CAF0_1CAF0;
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
    label_1000_CAEE_1CAEE:
    // CLC  (1000_CAEE / 0x1CAEE)
    CarryFlag = false;
    label_1000_CAEF_1CAEF:
    // RET  (1000_CAEF / 0x1CAEF)
    return NearRet();
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
    throw FailAsUntested("Could not find a valid function at address 1000_A9F4 / 0x1A9F4");
    // CLC  (1000_CAFE / 0x1CAFE)
    CarryFlag = false;
    // RET  (1000_CAFF / 0x1CAFF)
    return NearRet();
  }
  
  public Action spice86_generated_label_ret_target_1000_CB1A_01CB1A(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xCB00: break; // Instructions before entry targeted by 0x1CB1E
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_CB00_1CB00:
    // MOV AX,[0xdbea] (1000_CB00 / 0x1CB00)
    AX = UInt16[DS, 0xDBEA];
    // CMP AX,word ptr [0xdbee] (1000_CB03 / 0x1CB03)
    Alu.Sub16(AX, UInt16[DS, 0xDBEE]);
    // JZ 0x1000:cb61 (1000_CB07 / 0x1CB07)
    if(ZeroFlag) {
      goto label_1000_CB61_1CB61;
    }
    // MOV AX,[0xdc08] (1000_CB09 / 0x1CB09)
    AX = UInt16[DS, 0xDC08];
    // OR AX,word ptr [0xdc0a] (1000_CB0C / 0x1CB0C)
    // AX |= UInt16[DS, 0xDC0A];
    AX = Alu.Or16(AX, UInt16[DS, 0xDC0A]);
    // JZ 0x1000:cb61 (1000_CB10 / 0x1CB10)
    if(ZeroFlag) {
      goto label_1000_CB61_1CB61;
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
    entry:
    label_1000_CB1A_1CB1A:
    // MOV CX,word ptr [0xdc20] (1000_CB1A / 0x1CB1A)
    CX = UInt16[DS, 0xDC20];
    // JCXZ 0x1000:cb00 (1000_CB1E / 0x1CB1E)
    if(CX == 0) {
      goto label_1000_CB00_1CB00;
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
    label_1000_CB60_1CB60:
    // RET  (1000_CB60 / 0x1CB60)
    return NearRet();
    label_1000_CB61_1CB61:
    // TEST byte ptr [0xdbfe],0x1 (1000_CB61 / 0x1CB61)
    Alu.And8(UInt8[DS, 0xDBFE], 0x1);
    // JZ 0x1000:cb4c (1000_CB66 / 0x1CB66)
    if(ZeroFlag) {
      goto label_1000_CB4C_1CB4C;
    }
    // MOV CX,0x1000 (1000_CB68 / 0x1CB68)
    CX = 0x1000;
    // CALL 0x1000:cc2b (1000_CB6B / 0x1CB6B)
    NearCall(cs1, 0xCB6E, spice86_generated_label_call_target_1000_CC2B_01CC2B);
    // JC 0x1000:cb44 (1000_CB6E / 0x1CB6E)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_CB44 / 0x1CB44)
      return NearRet();
    }
    // MOV AX,[0xdbea] (1000_CB70 / 0x1CB70)
    AX = UInt16[DS, 0xDBEA];
    // CALL 0x1000:ce07 (1000_CB73 / 0x1CB73)
    throw FailAsUntested("Could not find a valid function at address 1000_CE07 / 0x1CE07");
    // MOV [0xdbec],AX (1000_CB76 / 0x1CB76)
    UInt16[DS, 0xDBEC] = AX;
    // CALL 0x1000:ca9a (1000_CB79 / 0x1CB79)
    NearCall(cs1, 0xCB7C, split_1000_CA9A_01CA9A);
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
      goto label_1000_CB45_1CB45;
    }
    // CMP word ptr [BX + -0x6],0x0 (1000_CB8D / 0x1CB8D)
    Alu.Sub16(UInt16[DS, (ushort)(BX - 0x6)], 0x0);
    // JZ 0x1000:cb45 (1000_CB91 / 0x1CB91)
    if(ZeroFlag) {
      goto label_1000_CB45_1CB45;
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
      goto label_1000_CB00_1CB00;
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
    throw FailAsUntested("Could not find a valid function at address 1000_CDF7 / 0x1CDF7");
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
    throw FailAsUntested("Could not find a valid function at address 1000_CDF7 / 0x1CDF7");
    // LOOP 0x1000:cbcf (1000_CC02 / 0x1CC02)
    if(--CX != 0) {
      goto label_1000_CBCF_1CBCF;
    }
    // MOV byte ptr [0xdbb5],0x80 (1000_CC04 / 0x1CC04)
    UInt8[DS, 0xDBB5] = 0x80;
    label_1000_CC09_1CC09:
    // JMP 0x1000:cb00 (1000_CC09 / 0x1CC09)
    goto label_1000_CB00_1CB00;
  }
  
  public Action spice86_generated_label_call_target_1000_CC0C_01CC0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CC2B_01CC2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CC4E_01CC4E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AX = Alu.Inc16(AX);
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
  
  public Action spice86_generated_label_call_target_1000_CC85_01CC85(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CC96_01CC96(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_CCEA_1CCEA;
    }
    // PUSH DS (1000_CCB2 / 0x1CCB2)
    Stack.Push(DS);
    // TEST word ptr [0xdc24],0x400 (1000_CCB3 / 0x1CCB3)
    Alu.And16(UInt16[DS, 0xDC24], 0x400);
    // JNZ 0x1000:cce1 (1000_CCB9 / 0x1CCB9)
    if(!ZeroFlag) {
      goto label_1000_CCE1_1CCE1;
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
      goto label_1000_CCE1_1CCE1;
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
      goto label_1000_CCE3_1CCE3;
    }
    // CALLF [0x38c9] (1000_CCDC / 0x1CCDC)
    // Indirect call to [0x38c9], generating possible targets from emulator records
    uint targetAddress_1000_CCDC = (uint)(UInt16[SS, 0x38CB] * 0x10 + UInt16[SS, 0x38C9] - cs1 * 0x10);
    switch(targetAddress_1000_CCDC) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CCDC));
        break;
    }
    label_1000_CCE1_1CCE1:
    // POP DS (1000_CCE1 / 0x1CCE1)
    DS = Stack.Pop();
    // RET  (1000_CCE2 / 0x1CCE2)
    return NearRet();
    label_1000_CCE3_1CCE3:
    // CALLF [0xcc92] (1000_CCE3 / 0x1CCE3)
    // Indirect call to [0xcc92], generating possible targets from emulator records
    uint targetAddress_1000_CCE3 = (uint)(UInt16[cs1, 0xCC94] * 0x10 + UInt16[cs1, 0xCC92]);
    switch(targetAddress_1000_CCE3) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CCE3));
        break;
    }
    // POP DS (1000_CCE8 / 0x1CCE8)
    DS = Stack.Pop();
    // RET  (1000_CCE9 / 0x1CCE9)
    return NearRet();
    label_1000_CCEA_1CCEA:
    // TEST AL,0x20 (1000_CCEA / 0x1CCEA)
    Alu.And8(AL, 0x20);
    // JNZ 0x1000:ccf1 (1000_CCEC / 0x1CCEC)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:4aeb (1000_CCF1 / 0x1CCF1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_4AEB_014AEB, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JMP 0x1000:4afd (1000_CCEE / 0x1CCEE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_4AEB_014AEB, 0x14AFD - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_CCF1_1CCF1:
    // JMP 0x1000:4aeb (1000_CCF1 / 0x1CCF1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_4AEB_014AEB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_CCF4_01CCF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_CD7F_1CD7F;
    }
    // TEST CH,0x2 (1000_CD77 / 0x1CD77)
    Alu.And8(CH, 0x2);
    // JZ 0x1000:cd81 (1000_CD7A / 0x1CD7A)
    if(ZeroFlag) {
      goto label_1000_CD81_1CD81;
    }
    label_1000_CD7C_1CD7C:
    // CALL 0x1000:f403 (1000_CD7C / 0x1CD7C)
    NearCall(cs1, 0xCD7F, spice86_generated_label_call_target_1000_F403_01F403);
    label_1000_CD7F_1CD7F:
    // POP DS (1000_CD7F / 0x1CD7F)
    DS = Stack.Pop();
    // RET  (1000_CD80 / 0x1CD80)
    return NearRet();
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
  
  public Action spice86_generated_label_call_target_1000_CD8F_01CD8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_CDA0_01CDA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CDA0_1CDA0:
    // CALL 0x1000:ce1a (1000_CDA0 / 0x1CDA0)
    NearCall(cs1, 0xCDA3, spice86_generated_label_call_target_1000_CE1A_01CE1A);
    label_1000_CDA3_1CDA3:
    // CALL 0x1000:cd8f (1000_CDA3 / 0x1CDA3)
    NearCall(cs1, 0xCDA6, spice86_generated_label_call_target_1000_CD8F_01CD8F);
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
  
  public Action spice86_generated_label_call_target_1000_CDBF_01CDBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_CDF7_1CDF7:
    // ADD word ptr [0xdc0c],AX (1000_CDF7 / 0x1CDF7)
    UInt16[DS, 0xDC0C] += AX;
    
    // ADD word ptr [0xdc1a],AX (1000_CDFB / 0x1CDFB)
    // UInt16[DS, 0xDC1A] += AX;
    UInt16[DS, 0xDC1A] = Alu.Add16(UInt16[DS, 0xDC1A], AX);
    // CLC  (1000_CDFF / 0x1CDFF)
    CarryFlag = false;
    label_1000_CE00_1CE00:
    // RET  (1000_CE00 / 0x1CE00)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_CE01_01CE01(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CE01_1CE01:
    // MOV word ptr [0xdbe8],0x0 (1000_CE01 / 0x1CE01)
    UInt16[DS, 0xDBE8] = 0x0;
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
  
  public Action spice86_generated_label_call_target_1000_CE1A_01CE1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action hnm_handle_pal_chunk_ida_1000_CE3B_1CE3B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // CALLF [0x3935] (1000_CE46 / 0x1CE46)
    // Indirect call to [0x3935], generating possible targets from emulator records
    uint targetAddress_1000_CE46 = (uint)(UInt16[DS, 0x3937] * 0x10 + UInt16[DS, 0x3935] - cs1 * 0x10);
    switch(targetAddress_1000_CE46) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CE46));
        break;
    }
    // RET  (1000_CE4A / 0x1CE4A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_CE53_01CE53(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AX = Alu.Inc16(AX);
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
  
  public Action spice86_generated_label_call_target_1000_CE6C_01CE6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_CE8A_1CE8A;
    }
    label_1000_CE7B_1CE7B:
    // MOV AX,0x2 (1000_CE7B / 0x1CE7B)
    AX = 0x2;
    label_1000_CE7E_1CE7E:
    // CALL 0x1000:c921 (1000_CE7E / 0x1CE7E)
    NearCall(cs1, 0xCE81, spice86_generated_label_call_target_1000_C921_01C921);
    label_1000_CE81_1CE81:
    // AND byte ptr [BX],0xfb (1000_CE81 / 0x1CE81)
    UInt8[DS, BX] &= 0xFB;
    
    // INC AX (1000_CE84 / 0x1CE84)
    AX = Alu.Inc16(AX);
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
    AX = Alu.Inc16(AX);
    // CMP AX,0x25 (1000_CE9A / 0x1CE9A)
    Alu.Sub16(AX, 0x25);
    // JC 0x1000:ce93 (1000_CE9D / 0x1CE9D)
    if(CarryFlag) {
      goto label_1000_CE93_1CE93;
    }
    label_1000_CE9F_1CE9F:
    // MOV AX,0x2 (1000_CE9F / 0x1CE9F)
    AX = 0x2;
    label_1000_CEA2_1CEA2:
    // PUSH AX (1000_CEA2 / 0x1CEA2)
    Stack.Push(AX);
    // CALL 0x1000:ceb0 (1000_CEA3 / 0x1CEA3)
    NearCall(cs1, 0xCEA6, spice86_generated_label_call_target_1000_CEB0_01CEB0);
    label_1000_CEA6_1CEA6:
    // POP AX (1000_CEA6 / 0x1CEA6)
    AX = Stack.Pop();
    // INC AX (1000_CEA7 / 0x1CEA7)
    AX = Alu.Inc16(AX);
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
  
  public Action spice86_generated_label_call_target_1000_CEB0_01CEB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CEB0_1CEB0:
    // CALL 0x1000:c921 (1000_CEB0 / 0x1CEB0)
    NearCall(cs1, 0xCEB3, spice86_generated_label_call_target_1000_C921_01C921);
    label_1000_CEB3_1CEB3:
    // PUSH BX (1000_CEB3 / 0x1CEB3)
    Stack.Push(BX);
    // CALL 0x1000:c92b (1000_CEB4 / 0x1CEB4)
    NearCall(cs1, 0xCEB7, spice86_generated_label_call_target_1000_C92B_01C92B);
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
  
  public Action spice86_generated_label_call_target_1000_CEC9_01CEC9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_CEDC_1CEDC:
    // JBE 0x1000:ceef (1000_CEDC / 0x1CEDC)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_CEEF_1CEEF;
    }
    // MOV AX,[0xdc1e] (1000_CEDE / 0x1CEDE)
    AX = UInt16[DS, 0xDC1E];
    // INC AX (1000_CEE1 / 0x1CEE1)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:ceef (1000_CEE2 / 0x1CEE2)
    if(!ZeroFlag) {
      goto label_1000_CEEF_1CEEF;
    }
    // CALL 0x1000:cad4 (1000_CEE4 / 0x1CEE4)
    NearCall(cs1, 0xCEE7, spice86_generated_label_call_target_1000_CAD4_01CAD4);
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
  
  public Action load_IRULn_HSQ_ida_1000_CEFC_1CEFC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // MOV word ptr [0x3622],0x35a8 (1000_CF06 / 0x1CF06)
    UInt16[DS, 0x3622] = 0x35A8;
    // XOR AX,AX (1000_CF0C / 0x1CF0C)
    AX = 0;
    // CALLF [0x3939] (1000_CF0E / 0x1CF0E)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_CF0E = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_CF0E) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CF0E));
        break;
    }
    // CALL 0x1000:c0ad (1000_CF12 / 0x1CF12)
    NearCall(cs1, 0xCF15, spice86_generated_label_call_target_1000_C0AD_01C0AD);
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
  
  public Action play_IRULx_HSQ_ida_1000_CF1B_1CF1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CF1B_1CF1B:
    // PUSH word ptr [0xdbda] (1000_CF1B / 0x1CF1B)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_CF1F / 0x1CF1F)
    NearCall(cs1, 0xCF22, spice86_generated_label_call_target_1000_C08E_01C08E);
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
    NearCall(cs1, 0xCF30, IRULx_draw_or_clear_subtitle_ida_1000_CF4B_1CF4B);
    label_1000_CF30_1CF30:
    // CALL 0x1000:c9e8 (1000_CF30 / 0x1CF30)
    NearCall(cs1, 0xCF33, hnm_do_frame_skippable_ida_1000_C9E8_1C9E8);
    // JC 0x1000:cf3b (1000_CF33 / 0x1CF33)
    if(CarryFlag) {
      goto label_1000_CF3B_1CF3B;
    }
    // CALL 0x1000:cc85 (1000_CF35 / 0x1CF35)
    NearCall(cs1, 0xCF38, spice86_generated_label_call_target_1000_CC85_01CC85);
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
    // CALL 0x1000:ac14 (1000_CF3F / 0x1CF3F)
    NearCall(cs1, 0xCF42, spice86_generated_label_call_target_1000_AC14_01AC14);
    // CALL 0x1000:ad57 (1000_CF42 / 0x1CF42)
    NearCall(cs1, 0xCF45, spice86_generated_label_call_target_1000_AD57_01AD57);
    // POPF  (1000_CF45 / 0x1CF45)
    FlagRegister = Stack.Pop();
    // POP word ptr [0xdbda] (1000_CF46 / 0x1CF46)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_CF4A / 0x1CF4A)
    return NearRet();
  }
  
  public Action IRULx_draw_or_clear_subtitle_ida_1000_CF4B_1CF4B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CF4B_1CF4B:
    // MOV AX,SI (1000_CF4B / 0x1CF4B)
    AX = SI;
    // MOV [0x3622],AX (1000_CF4D / 0x1CF4D)
    UInt16[DS, 0x3622] = AX;
    // SUB AX,0x35a8 (1000_CF50 / 0x1CF50)
    AX -= 0x35A8;
    
    // SHR AX,0x1 (1000_CF53 / 0x1CF53)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_CF55 / 0x1CF55)
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
  
  public Action spice86_generated_label_call_target_1000_CF70_01CF70(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CF70_1CF70:
    // PUSH BX (1000_CF70 / 0x1CF70)
    Stack.Push(BX);
    // DEC SI (1000_CF71 / 0x1CF71)
    SI = Alu.Dec16(SI);
    // TEST SI,0x800 (1000_CF72 / 0x1CF72)
    Alu.And16(SI, 0x800);
    // JZ 0x1000:cf95 (1000_CF76 / 0x1CF76)
    if(ZeroFlag) {
      goto label_1000_CF95_1CF95;
    }
    // CALL 0x1000:d00f (1000_CF78 / 0x1CF78)
    NearCall(cs1, 0xCF7B, spice86_generated_label_call_target_1000_D00F_01D00F);
    label_1000_CF7B_1CF7B:
    // LES BX,[0x47b0] (1000_CF7B / 0x1CF7B)
    ES = UInt16[DS, 0x47B2];
    BX = UInt16[DS, 0x47B0];
    // AND SI,0x7ff (1000_CF7F / 0x1CF7F)
    SI &= 0x7FF;
    
    // SHL SI,0x1 (1000_CF83 / 0x1CF83)
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
    label_1000_CF95_1CF95:
    // SHL SI,0x1 (1000_CF95 / 0x1CF95)
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
  
  public Action spice86_generated_label_call_target_1000_CFA0_01CFA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_CFA0_1CFA0:
    // CALL 0x1000:ae2f (1000_CFA0 / 0x1CFA0)
    NearCall(cs1, 0xCFA3, spice86_generated_label_call_target_1000_AE2F_01AE2F);
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
  
  public Action spice86_generated_label_call_target_1000_CFB9_01CFB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_D00D_1D00D:
    // JMP 0x1000:d01a (1000_D00D / 0x1D00D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D00F_01D00F, 0x1D01A - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D00F_01D00F(int loadOffset) {
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
  
  public Action spice86_generated_label_call_target_1000_D03C_01D03C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D04E_01D04E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D05F_01D05F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D068_01D068(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D075_01D075(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action SetFontToBook_1000_D082_1D082(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_D096_01D096(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHL SI,0x1 (1000_D0A2 / 0x1D0A2)
    SI <<= 0x1;
    
    // SHL SI,0x1 (1000_D0A4 / 0x1D0A4)
    SI <<= 0x1;
    
    // SHL SI,0x1 (1000_D0A6 / 0x1D0A6)
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
  
  public Action spice86_generated_label_call_target_1000_D12F_01D12F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHL SI,0x1 (1000_D13B / 0x1D13B)
    SI <<= 0x1;
    
    // SHL SI,0x1 (1000_D13D / 0x1D13D)
    SI <<= 0x1;
    
    // SHL SI,0x1 (1000_D13F / 0x1D13F)
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
  
  public Action spice86_generated_label_call_target_1000_D194_01D194(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_ret_target_1000_D19B_01D19B(int loadOffset) {
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
  
  public Action spice86_generated_label_call_target_1000_D1A6_01D1A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_D1B8_1D1B8:
    // POP SI (1000_D1B8 / 0x1D1B8)
    SI = Stack.Pop();
    // JMP 0x1000:d1a6 (1000_D1B9 / 0x1D1B9)
    goto label_1000_D1A6_1D1A6;
  }
  
  public Action spice86_generated_label_call_target_1000_D1BB_01D1BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
      goto label_1000_D1D1_1D1D1;
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
    label_1000_D1CF_1D1CF:
    // JMP 0x1000:d1bb (1000_D1CF / 0x1D1CF)
    goto label_1000_D1BB_1D1BB;
    label_1000_D1D1_1D1D1:
    // MOV AX,[0xd830] (1000_D1D1 / 0x1D1D1)
    AX = UInt16[DS, 0xD830];
    // MOV [0xd82c],AX (1000_D1D4 / 0x1D1D4)
    UInt16[DS, 0xD82C] = AX;
    // MOV AX,0xa (1000_D1D7 / 0x1D1D7)
    AX = 0xA;
    // CMP word ptr [0x2518],0xd12f (1000_D1DA / 0x1D1DA)
    Alu.Sub16(UInt16[DS, 0x2518], 0xD12F);
    // JNZ 0x1000:d1e5 (1000_D1E0 / 0x1D1E0)
    if(!ZeroFlag) {
      goto label_1000_D1E5_1D1E5;
    }
    // MOV AX,0x7 (1000_D1E2 / 0x1D1E2)
    AX = 0x7;
    label_1000_D1E5_1D1E5:
    // ADD word ptr [0xd832],AX (1000_D1E5 / 0x1D1E5)
    UInt16[DS, 0xD832] += AX;
    
    // ADD word ptr [0xd82e],AX (1000_D1E9 / 0x1D1E9)
    // UInt16[DS, 0xD82E] += AX;
    UInt16[DS, 0xD82E] = Alu.Add16(UInt16[DS, 0xD82E], AX);
    // JMP 0x1000:d1bb (1000_D1ED / 0x1D1ED)
    goto label_1000_D1BB_1D1BB;
  }
  
  public Action spice86_generated_label_call_target_1000_D1EF_01D1EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D1EF_1D1EF:
    // LODSW SI (1000_D1EF / 0x1D1EF)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_D1F0 / 0x1D1F0)
    CX = AX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D1F2_01D1F2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D1F2_01D1F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D1F2_1D1F2:
    // CALL 0x1000:c137 (1000_D1F2 / 0x1D1F2)
    NearCall(cs1, 0xD1F5, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_D1F5_1D1F5:
    // PUSH CX (1000_D1F5 / 0x1D1F5)
    Stack.Push(CX);
    // CALL 0x1000:d200 (1000_D1F6 / 0x1D1F6)
    NearCall(cs1, 0xD1F9, spice86_generated_label_call_target_1000_D200_01D200);
    label_1000_D1F9_1D1F9:
    // POP CX (1000_D1F9 / 0x1D1F9)
    CX = Stack.Pop();
    // ADD SI,0xe (1000_D1FA / 0x1D1FA)
    // SI += 0xE;
    SI = Alu.Add16(SI, 0xE);
    // LOOP 0x1000:d1f5 (1000_D1FD / 0x1D1FD)
    if(--CX != 0) {
      goto label_1000_D1F5_1D1F5;
    }
    // RET  (1000_D1FF / 0x1D1FF)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D200_01D200(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D200_1D200:
    // PUSH word ptr [0xdbda] (1000_D200 / 0x1D200)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_D204 / 0x1D204)
    NearCall(cs1, 0xD207, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_D207_1D207:
    // PUSH SI (1000_D207 / 0x1D207)
    Stack.Push(SI);
    // TEST byte ptr [SI + 0x8],0x40 (1000_D208 / 0x1D208)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x8)], 0x40);
    // JZ 0x1000:d218 (1000_D20C / 0x1D20C)
    if(ZeroFlag) {
      goto label_1000_D218_1D218;
    }
    // MOV ES,word ptr [0xdbda] (1000_D20E / 0x1D20E)
    ES = UInt16[DS, 0xDBDA];
    // PUSH SI (1000_D212 / 0x1D212)
    Stack.Push(SI);
    // CALLF [0x38d9] (1000_D213 / 0x1D213)
    // Indirect call to [0x38d9], generating possible targets from emulator records
    uint targetAddress_1000_D213 = (uint)(UInt16[DS, 0x38DB] * 0x10 + UInt16[DS, 0x38D9] - cs1 * 0x10);
    switch(targetAddress_1000_D213) {
      case 0x235CB : FarCall(cs1, 0xD217, spice86_generated_label_call_target_334B_011B_0335CB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D213));
        break;
    }
    label_1000_D217_1D217:
    // POP SI (1000_D217 / 0x1D217)
    SI = Stack.Pop();
    label_1000_D218_1D218:
    // TEST byte ptr [SI + 0x8],0x20 (1000_D218 / 0x1D218)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x8)], 0x20);
    // JNZ 0x1000:d233 (1000_D21C / 0x1D21C)
    if(!ZeroFlag) {
      goto label_1000_D233_1D233;
    }
    // LODSW SI (1000_D21E / 0x1D21E)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_D21F / 0x1D21F)
    DX = AX;
    // LODSW SI (1000_D221 / 0x1D221)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_D222 / 0x1D222)
    BX = AX;
    // LODSW SI (1000_D224 / 0x1D224)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_D225 / 0x1D225)
    DI = AX;
    // LODSW SI (1000_D227 / 0x1D227)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_D228 / 0x1D228)
    CX = AX;
    // LODSW SI (1000_D22A / 0x1D22A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // LODSW SI (1000_D22B / 0x1D22B)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // INC AX (1000_D22C / 0x1D22C)
    AX = Alu.Inc16(AX);
    // JZ 0x1000:d233 (1000_D22D / 0x1D22D)
    if(ZeroFlag) {
      goto label_1000_D233_1D233;
    }
    // DEC AX (1000_D22F / 0x1D22F)
    AX = Alu.Dec16(AX);
    // CALL 0x1000:c22f (1000_D230 / 0x1D230)
    NearCall(cs1, 0xD233, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_D233_1D233:
    // POP SI (1000_D233 / 0x1D233)
    SI = Stack.Pop();
    // POP word ptr [0xdbda] (1000_D234 / 0x1D234)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_D238 / 0x1D238)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D239_01D239(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D239_1D239:
    // MOV CH,0x2 (1000_D239 / 0x1D239)
    CH = 0x2;
    // JMP 0x1000:d23f (1000_D23B / 0x1D23B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D23D_01D23D, 0x1D23F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D23D_01D23D(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xD23F: goto label_1000_D23F_1D23F;break; // Target of external jump from 0x1D23B
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D23D_1D23D:
    // XOR CX,CX (1000_D23D / 0x1D23D)
    CX = 0;
    label_1000_D23F_1D23F:
    // MOV SI,0x1af4 (1000_D23F / 0x1D23F)
    SI = 0x1AF4;
    // MOV AX,word ptr [SI + 0xa] (1000_D242 / 0x1D242)
    AX = UInt16[DS, (ushort)(SI + 0xA)];
    // SUB AX,0x0 (1000_D245 / 0x1D245)
    // AX -= 0x0;
    AX = Alu.Sub16(AX, 0x0);
    // MOV CL,0x3 (1000_D248 / 0x1D248)
    CL = 0x3;
    // DIV CL (1000_D24A / 0x1D24A)
    Cpu.Div8(CL);
    // CMP CH,AH (1000_D24C / 0x1D24C)
    Alu.Sub8(CH, AH);
    // JZ 0x1000:d27f (1000_D24E / 0x1D24E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D27F / 0x1D27F)
      return NearRet();
    }
    // MOV AX,0x1 (1000_D250 / 0x1D250)
    AX = 0x1;
    // JNC 0x1000:d257 (1000_D253 / 0x1D253)
    if(!CarryFlag) {
      goto label_1000_D257_1D257;
    }
    // NEG AX (1000_D255 / 0x1D255)
    AX = Alu.Sub16(0, AX);
    label_1000_D257_1D257:
    // PUSH AX (1000_D257 / 0x1D257)
    Stack.Push(AX);
    // PUSH SI (1000_D258 / 0x1D258)
    Stack.Push(SI);
    // ADD word ptr [SI + 0xa],AX (1000_D259 / 0x1D259)
    UInt16[DS, (ushort)(SI + 0xA)] += AX;
    
    // ADD word ptr [SI + 0x18],AX (1000_D25C / 0x1D25C)
    // UInt16[DS, (ushort)(SI + 0x18)] += AX;
    UInt16[DS, (ushort)(SI + 0x18)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x18)], AX);
    // MOV CX,0x2 (1000_D25F / 0x1D25F)
    CX = 0x2;
    // CALL 0x1000:d1f2 (1000_D262 / 0x1D262)
    NearCall(cs1, 0xD265, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    label_1000_D265_1D265:
    // CALL 0x1000:1a34 (1000_D265 / 0x1D265)
    NearCall(cs1, 0xD268, spice86_generated_label_call_target_1000_1A34_011A34);
    label_1000_D268_1D268:
    // MOV AX,0xa (1000_D268 / 0x1D268)
    AX = 0xA;
    // CALL 0x1000:e387 (1000_D26B / 0x1D26B)
    NearCall(cs1, 0xD26E, spice86_generated_label_call_target_1000_E387_01E387);
    label_1000_D26E_1D26E:
    // POP SI (1000_D26E / 0x1D26E)
    SI = Stack.Pop();
    // POP AX (1000_D26F / 0x1D26F)
    AX = Stack.Pop();
    // ADD word ptr [SI + 0xa],AX (1000_D270 / 0x1D270)
    UInt16[DS, (ushort)(SI + 0xA)] += AX;
    
    // ADD word ptr [SI + 0x18],AX (1000_D273 / 0x1D273)
    // UInt16[DS, (ushort)(SI + 0x18)] += AX;
    UInt16[DS, (ushort)(SI + 0x18)] = Alu.Add16(UInt16[DS, (ushort)(SI + 0x18)], AX);
    // MOV CX,0x2 (1000_D276 / 0x1D276)
    CX = 0x2;
    // CALL 0x1000:d1f2 (1000_D279 / 0x1D279)
    NearCall(cs1, 0xD27C, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    label_1000_D27C_1D27C:
    // CALL 0x1000:1a34 (1000_D27C / 0x1D27C)
    NearCall(cs1, 0xD27F, spice86_generated_label_call_target_1000_1A34_011A34);
    label_1000_D27F_1D27F:
    // RET  (1000_D27F / 0x1D27F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D280_01D280(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D280_1D280:
    // CMP byte ptr [0xdce6],0x0 (1000_D280 / 0x1D280)
    Alu.Sub8(UInt8[DS, 0xDCE6], 0x0);
    // JLE 0x1000:d2bc (1000_D285 / 0x1D285)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      // JLE target is RET, inlining.
      // RET  (1000_D2BC / 0x1D2BC)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_D287 / 0x1D287)
    NearCall(cs1, 0xD28A, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_D28A_1D28A:
    // MOV byte ptr [0xdce6],0x0 (1000_D28A / 0x1D28A)
    UInt8[DS, 0xDCE6] = 0x0;
    // CALL 0x1000:d239 (1000_D28F / 0x1D28F)
    NearCall(cs1, 0xD292, spice86_generated_label_call_target_1000_D239_01D239);
    label_1000_D292_1D292:
    // MOV CX,0x11 (1000_D292 / 0x1D292)
    CX = 0x11;
    label_1000_D295_1D295:
    // PUSH CX (1000_D295 / 0x1D295)
    Stack.Push(CX);
    // PUSH word ptr [0xce7a] (1000_D296 / 0x1D296)
    Stack.Push(UInt16[DS, 0xCE7A]);
    // MOV SI,word ptr [0xdbde] (1000_D29A / 0x1D29A)
    SI = UInt16[DS, 0xDBDE];
    // MOV AL,0x18 (1000_D29E / 0x1D29E)
    AL = 0x18;
    // CALL 0x1000:c0d5 (1000_D2A0 / 0x1D2A0)
    NearCall(cs1, 0xD2A3, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    label_1000_D2A3_1D2A3:
    // POP BX (1000_D2A3 / 0x1D2A3)
    BX = Stack.Pop();
    label_1000_D2A4_1D2A4:
    // PUSH BX (1000_D2A4 / 0x1D2A4)
    Stack.Push(BX);
    // CALL 0x1000:a7c2 (1000_D2A5 / 0x1D2A5)
    NearCall(cs1, 0xD2A8, spice86_generated_label_call_target_1000_A7C2_01A7C2);
    label_1000_D2A8_1D2A8:
    // POP BX (1000_D2A8 / 0x1D2A8)
    BX = Stack.Pop();
    // MOV AX,[0xce7a] (1000_D2A9 / 0x1D2A9)
    AX = UInt16[DS, 0xCE7A];
    // SUB AX,BX (1000_D2AC / 0x1D2AC)
    AX -= BX;
    
    // CMP AX,0x6 (1000_D2AE / 0x1D2AE)
    Alu.Sub16(AX, 0x6);
    // JC 0x1000:d2a4 (1000_D2B1 / 0x1D2B1)
    if(CarryFlag) {
      goto label_1000_D2A4_1D2A4;
    }
    // POP CX (1000_D2B3 / 0x1D2B3)
    CX = Stack.Pop();
    // LOOP 0x1000:d295 (1000_D2B4 / 0x1D2B4)
    if(--CX != 0) {
      goto label_1000_D295_1D295;
    }
    // CALL 0x1000:d23d (1000_D2B6 / 0x1D2B6)
    NearCall(cs1, 0xD2B9, spice86_generated_label_call_target_1000_D23D_01D23D);
    label_1000_D2B9_1D2B9:
    // CALL 0x1000:e283 (1000_D2B9 / 0x1D2B9)
    NearCall(cs1, 0xD2BC, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_D2BC_1D2BC:
    // RET  (1000_D2BC / 0x1D2BC)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D2BD_01D2BD(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D2BD_1D2BD:
    // MOV AL,[0xdce6] (1000_D2BD / 0x1D2BD)
    AL = UInt8[DS, 0xDCE6];
    // PUSH AX (1000_D2C0 / 0x1D2C0)
    Stack.Push(AX);
    label_1000_D2C1_1D2C1:
    // MOV byte ptr [0xdce6],0x80 (1000_D2C1 / 0x1D2C1)
    UInt8[DS, 0xDCE6] = 0x80;
    // MOV SI,word ptr [0x21da] (1000_D2C6 / 0x1D2C6)
    SI = UInt16[DS, 0x21DA];
    // MOV SI,word ptr [SI] (1000_D2CA / 0x1D2CA)
    SI = UInt16[DS, SI];
    // LODSB SI (1000_D2CC / 0x1D2CC)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_D2CD / 0x1D2CD)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:d2da (1000_D2CF / 0x1D2CF)
    if(ZeroFlag) {
      goto label_1000_D2DA_1D2DA;
    }
    // AND AL,0xf (1000_D2D1 / 0x1D2D1)
    // AL &= 0xF;
    AL = Alu.And8(AL, 0xF);
    // JZ 0x1000:d2da (1000_D2D3 / 0x1D2D3)
    if(ZeroFlag) {
      goto label_1000_D2DA_1D2DA;
    }
    // CALL 0x1000:d2ea (1000_D2D5 / 0x1D2D5)
    NearCall(cs1, 0xD2D8, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    // JMP 0x1000:d2c1 (1000_D2D8 / 0x1D2D8)
    goto label_1000_D2C1_1D2C1;
    label_1000_D2DA_1D2DA:
    // POP AX (1000_D2DA / 0x1D2DA)
    AX = Stack.Pop();
    // MOV [0xdce6],AL (1000_D2DB / 0x1D2DB)
    UInt8[DS, 0xDCE6] = AL;
    // RET  (1000_D2DE / 0x1D2DE)
    return NearRet();
  }
  
  public Action split_1000_D2E2_01D2E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D2E2_1D2E2:
    // CALL 0x1000:d316 (1000_D2E2 / 0x1D2E2)
    NearCall(cs1, 0xD2E5, spice86_generated_label_call_target_1000_D316_01D316);
    label_1000_D2E5_1D2E5:
    // CALL 0x1000:d2ea (1000_D2E5 / 0x1D2E5)
    NearCall(cs1, 0xD2E8, spice86_generated_label_call_target_1000_D2EA_01D2EA);
    label_1000_D2E8_1D2E8:
    // JMP 0x1000:d280 (1000_D2E8 / 0x1D2E8)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D2EA_01D2EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D2EA_1D2EA:
    // MOV SI,word ptr [0x21da] (1000_D2EA / 0x1D2EA)
    SI = UInt16[DS, 0x21DA];
    // MOV DI,word ptr [SI] (1000_D2EE / 0x1D2EE)
    DI = UInt16[DS, SI];
    // MOV AL,byte ptr [DI] (1000_D2F0 / 0x1D2F0)
    AL = UInt8[DS, DI];
    // AND AL,0xf (1000_D2F2 / 0x1D2F2)
    AL &= 0xF;
    
    // CMP AL,0xf (1000_D2F4 / 0x1D2F4)
    Alu.Sub8(AL, 0xF);
    // JZ 0x1000:d315 (1000_D2F6 / 0x1D2F6)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D315 / 0x1D315)
      return NearRet();
    }
    // MOV AX,word ptr [SI + 0x2] (1000_D2F8 / 0x1D2F8)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL AX (1000_D2FB / 0x1D2FB)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_D2FB = (uint)(AX);
    switch(targetAddress_1000_D2FB) {
      case 0xA541 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_A541_01A541); break;
      case 0xB2B3 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_B2B3_01B2B3); break;
      case 0x97CF : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_97CF_0197CF); break;
      case 0x4415 : NearCall(cs1, 0xD2FD, spice86_generated_label_call_target_1000_4415_014415); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D2FB));
        break;
    }
    label_1000_D2FD_1D2FD:
    // MOV SI,word ptr [0x21da] (1000_D2FD / 0x1D2FD)
    SI = UInt16[DS, 0x21DA];
    // CMP SI,0x21be (1000_D301 / 0x1D301)
    Alu.Sub16(SI, 0x21BE);
    // JZ 0x1000:d315 (1000_D305 / 0x1D305)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D315 / 0x1D315)
      return NearRet();
    }
    // SUB SI,0x4 (1000_D307 / 0x1D307)
    // SI -= 0x4;
    SI = Alu.Sub16(SI, 0x4);
    // MOV word ptr [0x21da],SI (1000_D30A / 0x1D30A)
    UInt16[DS, 0x21DA] = SI;
    // MOV BP,word ptr [SI] (1000_D30E / 0x1D30E)
    BP = UInt16[DS, SI];
    // MOV CL,0xff (1000_D310 / 0x1D310)
    CL = 0xFF;
    // CALL 0x1000:d36d (1000_D312 / 0x1D312)
    NearCall(cs1, 0xD315, spice86_generated_label_call_target_1000_D36D_01D36D);
    label_1000_D315_1D315:
    // RET  (1000_D315 / 0x1D315)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D316_01D316(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D316_1D316:
    // CMP word ptr [0x35a6],0x0 (1000_D316 / 0x1D316)
    Alu.Sub16(UInt16[DS, 0x35A6], 0x0);
    // JNZ 0x1000:d322 (1000_D31B / 0x1D31B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_D322 / 0x1D322)
      return NearRet();
    }
    // OR byte ptr [0xdce6],0x1 (1000_D31D / 0x1D31D)
    // UInt8[DS, 0xDCE6] |= 0x1;
    UInt8[DS, 0xDCE6] = Alu.Or8(UInt8[DS, 0xDCE6], 0x1);
    label_1000_D322_1D322:
    // RET  (1000_D322 / 0x1D322)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D323_01D323(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D323_1D323:
    // CALL 0x1000:d316 (1000_D323 / 0x1D323)
    NearCall(cs1, 0xD326, spice86_generated_label_call_target_1000_D316_01D316);
    label_1000_D326_1D326:
    // CALL 0x1000:d338 (1000_D326 / 0x1D326)
    NearCall(cs1, 0xD329, spice86_generated_label_call_target_1000_D338_01D338);
    label_1000_D329_1D329:
    // CALL 0x1000:d280 (1000_D329 / 0x1D329)
    NearCall(cs1, 0xD32C, spice86_generated_label_call_target_1000_D280_01D280);
    label_1000_D32C_1D32C:
    // JMP 0x1000:d410 (1000_D32C / 0x1D32C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_D32F_01D32F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D32F_1D32F:
    // CALL 0x1000:d316 (1000_D32F / 0x1D32F)
    NearCall(cs1, 0xD332, spice86_generated_label_call_target_1000_D316_01D316);
    label_1000_D332_1D332:
    // CALL 0x1000:d33a (1000_D332 / 0x1D332)
    NearCall(cs1, 0xD335, spice86_generated_label_call_target_1000_D33A_01D33A);
    label_1000_D335_1D335:
    // JMP 0x1000:d280 (1000_D335 / 0x1D335)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D280_01D280, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D338_01D338(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D338_1D338:
    // MOV CL,0xff (1000_D338 / 0x1D338)
    CL = 0xFF;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D33A_01D33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D33A_01D33A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D33A_1D33A:
    // MOV SI,word ptr [0x21da] (1000_D33A / 0x1D33A)
    SI = UInt16[DS, 0x21DA];
    // MOV DI,word ptr [SI] (1000_D33E / 0x1D33E)
    DI = UInt16[DS, SI];
    // MOV AL,byte ptr [BP + 0x0] (1000_D340 / 0x1D340)
    AL = UInt8[SS, BP];
    // CMP AL,byte ptr [DI] (1000_D343 / 0x1D343)
    Alu.Sub8(AL, UInt8[DS, DI]);
    // JZ 0x1000:d368 (1000_D345 / 0x1D345)
    if(ZeroFlag) {
      goto label_1000_D368_1D368;
    }
    // JC 0x1000:d35b (1000_D347 / 0x1D347)
    if(CarryFlag) {
      goto label_1000_D35B_1D35B;
    }
    // PUSH BP (1000_D349 / 0x1D349)
    Stack.Push(BP);
    // PUSH BX (1000_D34A / 0x1D34A)
    Stack.Push(BX);
    // PUSH CX (1000_D34B / 0x1D34B)
    Stack.Push(CX);
    // MOV AX,word ptr [SI + 0x2] (1000_D34C / 0x1D34C)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // CALL AX (1000_D34F / 0x1D34F)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_D34F = (uint)(AX);
    switch(targetAddress_1000_D34F) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D34F));
        break;
    }
    // SUB word ptr [0x21da],0x4 (1000_D351 / 0x1D351)
    // UInt16[DS, 0x21DA] -= 0x4;
    UInt16[DS, 0x21DA] = Alu.Sub16(UInt16[DS, 0x21DA], 0x4);
    // POP CX (1000_D356 / 0x1D356)
    CX = Stack.Pop();
    // POP BX (1000_D357 / 0x1D357)
    BX = Stack.Pop();
    // POP BP (1000_D358 / 0x1D358)
    BP = Stack.Pop();
    // JMP 0x1000:d33a (1000_D359 / 0x1D359)
    goto label_1000_D33A_1D33A;
    label_1000_D35B_1D35B:
    // CMP SI,0x21d6 (1000_D35B / 0x1D35B)
    Alu.Sub16(SI, 0x21D6);
    // JZ 0x1000:d368 (1000_D35F / 0x1D35F)
    if(ZeroFlag) {
      goto label_1000_D368_1D368;
    }
    // ADD SI,0x4 (1000_D361 / 0x1D361)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // MOV word ptr [0x21da],SI (1000_D364 / 0x1D364)
    UInt16[DS, 0x21DA] = SI;
    label_1000_D368_1D368:
    // MOV word ptr [SI],BP (1000_D368 / 0x1D368)
    UInt16[DS, SI] = BP;
    // MOV word ptr [SI + 0x2],BX (1000_D36A / 0x1D36A)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D36D_01D36D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D36D_01D36D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D36D_1D36D:
    // MOV SI,word ptr [0x21da] (1000_D36D / 0x1D36D)
    SI = UInt16[DS, 0x21DA];
    // MOV word ptr [SI],BP (1000_D371 / 0x1D371)
    UInt16[DS, SI] = BP;
    // MOV SI,BP (1000_D373 / 0x1D373)
    SI = BP;
    // ADD BP,0x2 (1000_D375 / 0x1D375)
    BP += 0x2;
    
    label_1000_D378_1D378:
    // CMP word ptr [BP + 0x0],0x0 (1000_D378 / 0x1D378)
    Alu.Sub16(UInt16[SS, BP], 0x0);
    // JZ 0x1000:d388 (1000_D37C / 0x1D37C)
    if(ZeroFlag) {
      goto label_1000_D388_1D388;
    }
    // AND word ptr [BP + 0x0],0x7fff (1000_D37E / 0x1D37E)
    UInt16[SS, BP] &= 0x7FFF;
    
    // ADD BP,0x4 (1000_D383 / 0x1D383)
    // BP += 0x4;
    BP = Alu.Add16(BP, 0x4);
    // JMP 0x1000:d378 (1000_D386 / 0x1D386)
    goto label_1000_D378_1D378;
    label_1000_D388_1D388:
    // CMP CX,0x5 (1000_D388 / 0x1D388)
    Alu.Sub16(CX, 0x5);
    // JNC 0x1000:d397 (1000_D38B / 0x1D38B)
    if(!CarryFlag) {
      goto label_1000_D397_1D397;
    }
    // SHL CX,0x1 (1000_D38D / 0x1D38D)
    CX <<= 0x1;
    
    // SHL CX,0x1 (1000_D38F / 0x1D38F)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    // MOV BX,CX (1000_D391 / 0x1D391)
    BX = CX;
    // OR byte ptr [BX + SI + 0x3],0x80 (1000_D393 / 0x1D393)
    // UInt8[DS, (ushort)(BX + SI + 0x3)] |= 0x80;
    UInt8[DS, (ushort)(BX + SI + 0x3)] = Alu.Or8(UInt8[DS, (ushort)(BX + SI + 0x3)], 0x80);
    label_1000_D397_1D397:
    // MOV byte ptr [0xdce7],0xff (1000_D397 / 0x1D397)
    UInt8[DS, 0xDCE7] = 0xFF;
    // MOV SI,word ptr [0x21da] (1000_D39C / 0x1D39C)
    SI = UInt16[DS, 0x21DA];
    // MOV SI,word ptr [SI] (1000_D3A0 / 0x1D3A0)
    SI = UInt16[DS, SI];
    // INC SI (1000_D3A2 / 0x1D3A2)
    SI = Alu.Inc16(SI);
    // LODSB SI (1000_D3A3 / 0x1D3A3)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // MOV [0xdce4],AL (1000_D3A4 / 0x1D3A4)
    UInt8[DS, 0xDCE4] = AL;
    // CBW  (1000_D3A7 / 0x1D3A7)
    AX = (ushort)((short)((sbyte)AL));
    // ADD SI,AX (1000_D3A8 / 0x1D3A8)
    SI += AX;
    
    // XOR CX,CX (1000_D3AA / 0x1D3AA)
    CX = 0;
    // MOV byte ptr [0xdce8],CL (1000_D3AC / 0x1D3AC)
    UInt8[DS, 0xDCE8] = CL;
    // MOV byte ptr [0xdce5],0xff (1000_D3B0 / 0x1D3B0)
    UInt8[DS, 0xDCE5] = 0xFF;
    label_1000_D3B5_1D3B5:
    // MOV AX,word ptr [SI] (1000_D3B5 / 0x1D3B5)
    AX = UInt16[DS, SI];
    // OR AX,AX (1000_D3B7 / 0x1D3B7)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:d3ef (1000_D3B9 / 0x1D3B9)
    if(ZeroFlag) {
      goto label_1000_D3EF_1D3EF;
    }
    // CMP CL,0x4 (1000_D3BB / 0x1D3BB)
    Alu.Sub8(CL, 0x4);
    // JC 0x1000:d3d9 (1000_D3BE / 0x1D3BE)
    if(CarryFlag) {
      goto label_1000_D3D9_1D3D9;
    }
    // CMP byte ptr [0xdce4],0x0 (1000_D3C0 / 0x1D3C0)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    // JNZ 0x1000:d3cd (1000_D3C5 / 0x1D3C5)
    if(!ZeroFlag) {
      goto label_1000_D3CD_1D3CD;
    }
    // CMP word ptr [SI + 0x4],0x0 (1000_D3C7 / 0x1D3C7)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x4)], 0x0);
    // JZ 0x1000:d3d9 (1000_D3CB / 0x1D3CB)
    if(ZeroFlag) {
      goto label_1000_D3D9_1D3D9;
    }
    label_1000_D3CD_1D3CD:
    // OR byte ptr [0xdce4],0x80 (1000_D3CD / 0x1D3CD)
    // UInt8[DS, 0xDCE4] |= 0x80;
    UInt8[DS, 0xDCE4] = Alu.Or8(UInt8[DS, 0xDCE4], 0x80);
    // MOV AX,0xa0 (1000_D3D2 / 0x1D3D2)
    AX = 0xA0;
    // MOV byte ptr [0xdce5],CL (1000_D3D5 / 0x1D3D5)
    UInt8[DS, 0xDCE5] = CL;
    label_1000_D3D9_1D3D9:
    // ADD SI,0x4 (1000_D3D9 / 0x1D3D9)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // PUSH CX (1000_D3DC / 0x1D3DC)
    Stack.Push(CX);
    // PUSH SI (1000_D3DD / 0x1D3DD)
    Stack.Push(SI);
    // INC byte ptr [0xdce8] (1000_D3DE / 0x1D3DE)
    UInt8[DS, 0xDCE8] = Alu.Inc8(UInt8[DS, 0xDCE8]);
    // CALL 0x1000:d48a (1000_D3E2 / 0x1D3E2)
    NearCall(cs1, 0xD3E5, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D3E5_1D3E5:
    // POP SI (1000_D3E5 / 0x1D3E5)
    SI = Stack.Pop();
    // POP CX (1000_D3E6 / 0x1D3E6)
    CX = Stack.Pop();
    // INC CX (1000_D3E7 / 0x1D3E7)
    CX = Alu.Inc16(CX);
    // CMP CL,0x5 (1000_D3E8 / 0x1D3E8)
    Alu.Sub8(CL, 0x5);
    // JC 0x1000:d3b5 (1000_D3EB / 0x1D3EB)
    if(CarryFlag) {
      goto label_1000_D3B5_1D3B5;
    }
    // JMP 0x1000:d410 (1000_D3ED / 0x1D3ED)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D3EF_1D3EF:
    // CMP byte ptr [0xdce4],0x0 (1000_D3EF / 0x1D3EF)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    // JZ 0x1000:d403 (1000_D3F4 / 0x1D3F4)
    if(ZeroFlag) {
      goto label_1000_D403_1D403;
    }
    // MOV AX,0xa0 (1000_D3F6 / 0x1D3F6)
    AX = 0xA0;
    // MOV byte ptr [0xdce5],CL (1000_D3F9 / 0x1D3F9)
    UInt8[DS, 0xDCE5] = CL;
    // INC byte ptr [0xdce8] (1000_D3FD / 0x1D3FD)
    UInt8[DS, 0xDCE8] = Alu.Inc8(UInt8[DS, 0xDCE8]);
    // JMP 0x1000:d405 (1000_D401 / 0x1D401)
    goto label_1000_D405_1D405;
    label_1000_D403_1D403:
    // XOR AX,AX (1000_D403 / 0x1D403)
    AX = 0;
    label_1000_D405_1D405:
    // PUSH CX (1000_D405 / 0x1D405)
    Stack.Push(CX);
    // CALL 0x1000:d48a (1000_D406 / 0x1D406)
    NearCall(cs1, 0xD409, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D409_1D409:
    // POP CX (1000_D409 / 0x1D409)
    CX = Stack.Pop();
    // INC CX (1000_D40A / 0x1D40A)
    CX = Alu.Inc16(CX);
    // CMP CL,0x5 (1000_D40B / 0x1D40B)
    Alu.Sub8(CL, 0x5);
    // JC 0x1000:d403 (1000_D40E / 0x1D40E)
    if(CarryFlag) {
      goto label_1000_D403_1D403;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_D410_01D410, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_D410_01D410(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D410_1D410:
    // MOV DX,word ptr [0xdc36] (1000_D410 / 0x1D410)
    DX = UInt16[DS, 0xDC36];
    // MOV BX,word ptr [0xdc38] (1000_D414 / 0x1D414)
    BX = UInt16[DS, 0xDC38];
    // JMP 0x1000:d50f (1000_D418 / 0x1D418)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D50F_01D50F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D41B_01D41B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D41B_1D41B:
    // MOV BP,word ptr [0x21da] (1000_D41B / 0x1D41B)
    BP = UInt16[DS, 0x21DA];
    // MOV BP,word ptr [BP + 0x0] (1000_D41F / 0x1D41F)
    BP = UInt16[SS, BP];
    // RET  (1000_D422 / 0x1D422)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D42F_01D42F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D42F_1D42F:
    // MOV CX,0x4 (1000_D42F / 0x1D42F)
    CX = 0x4;
    // JMP 0x1000:d445 (1000_D432 / 0x1D432)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D434_01D434(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D434_1D434:
    // MOV CX,0x3 (1000_D434 / 0x1D434)
    CX = 0x3;
    // JMP 0x1000:d445 (1000_D437 / 0x1D437)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D439_01D439(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D439_1D439:
    // MOV CX,0x2 (1000_D439 / 0x1D439)
    CX = 0x2;
    // JMP 0x1000:d445 (1000_D43C / 0x1D43C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D43E_01D43E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D43E_1D43E:
    // MOV CX,0x1 (1000_D43E / 0x1D43E)
    CX = 0x1;
    // JMP 0x1000:d445 (1000_D441 / 0x1D441)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D443_01D443(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D443_1D443:
    // XOR CX,CX (1000_D443 / 0x1D443)
    CX = 0;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_D445_01D445, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_D445_01D445(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D445_1D445:
    // CALL 0x1000:d454 (1000_D445 / 0x1D445)
    NearCall(cs1, 0xD448, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D448_1D448:
    // OR BX,BX (1000_D448 / 0x1D448)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:d453 (1000_D44A / 0x1D44A)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D453 / 0x1D453)
      return NearRet();
    }
    // TEST AH,0x40 (1000_D44C / 0x1D44C)
    Alu.And8(AH, 0x40);
    // JNZ 0x1000:d453 (1000_D44F / 0x1D44F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_D453 / 0x1D453)
      return NearRet();
    }
    // JMP BX (1000_D451 / 0x1D451)
    // Indirect jump to BX, generating possible targets from emulator records
    uint targetAddress_1000_D451 = (uint)(BX);
    switch(targetAddress_1000_D451) {
      case 0xA3F0 : throw FailAsUntested("Would have been a goto but label label_1000_A3F0_1A3F0 does not exist because no instruction was found there that belongs to a function.");
      case 0xD2E2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_1000_D2E2_01D2E2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x186B : {
        // Jump converted to non entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_1860_011860, 0x1186B - cs1 * 0x10)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0xB29E : throw FailAsUntested("Would have been a goto but label label_1000_B29E_1B29E does not exist because no instruction was found there that belongs to a function.");
      case 0xB96B : throw FailAsUntested("Would have been a goto but label label_1000_B96B_1B96B does not exist because no instruction was found there that belongs to a function.");
      case 0xBC81 : throw FailAsUntested("Would have been a goto but label label_1000_BC81_1BC81 does not exist because no instruction was found there that belongs to a function.");
      case 0x92F2 : throw FailAsUntested("Would have been a goto but label label_1000_92F2_192F2 does not exist because no instruction was found there that belongs to a function.");
      case 0x42E9 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_1000_42E9_0142E9, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x4FFB : throw FailAsUntested("Would have been a goto but label label_1000_4FFB_14FFB does not exist because no instruction was found there that belongs to a function.");
      case 0xE3E : throw FailAsUntested("Would have been a goto but label label_1000_0E3E_10E3E does not exist because no instruction was found there that belongs to a function.");
      case 0x3A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D451));
        break;
    }
    label_1000_D453_1D453:
    // RET  (1000_D453 / 0x1D453)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D454_01D454(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D454_1D454:
    // MOV SI,word ptr [0x21da] (1000_D454 / 0x1D454)
    SI = UInt16[DS, 0x21DA];
    // MOV SI,word ptr [SI] (1000_D458 / 0x1D458)
    SI = UInt16[DS, SI];
    // INC SI (1000_D45A / 0x1D45A)
    SI = Alu.Inc16(SI);
    // XOR CH,CH (1000_D45B / 0x1D45B)
    CH = 0;
    // CMP CL,byte ptr [0xdce5] (1000_D45D / 0x1D45D)
    Alu.Sub8(CL, UInt8[DS, 0xDCE5]);
    // JZ 0x1000:d475 (1000_D461 / 0x1D461)
    if(ZeroFlag) {
      goto label_1000_D475_1D475;
    }
    // LODSB SI (1000_D463 / 0x1D463)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CBW  (1000_D464 / 0x1D464)
    AX = (ushort)((short)((sbyte)AL));
    // ADD SI,AX (1000_D465 / 0x1D465)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AX,CX (1000_D467 / 0x1D467)
    AX = CX;
    // SHL AX,0x1 (1000_D469 / 0x1D469)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_D46B / 0x1D46B)
    AX <<= 0x1;
    
    // ADD SI,AX (1000_D46D / 0x1D46D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV AX,word ptr [SI] (1000_D46F / 0x1D46F)
    AX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_D471 / 0x1D471)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // RET  (1000_D474 / 0x1D474)
    return NearRet();
    label_1000_D475_1D475:
    // MOV AX,0xa0 (1000_D475 / 0x1D475)
    AX = 0xA0;
    // MOV BX,0xd423 (1000_D478 / 0x1D478)
    BX = 0xD423;
    // CMP byte ptr [0xdce4],0x0 (1000_D47B / 0x1D47B)
    Alu.Sub8(UInt8[DS, 0xDCE4], 0x0);
    // JS 0x1000:d489 (1000_D480 / 0x1D480)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_D489 / 0x1D489)
      return NearRet();
    }
    // MOV BX,0xd429 (1000_D482 / 0x1D482)
    BX = 0xD429;
    // JG 0x1000:d489 (1000_D485 / 0x1D485)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      // JG target is RET, inlining.
      // RET  (1000_D489 / 0x1D489)
      return NearRet();
    }
    // XOR BX,BX (1000_D487 / 0x1D487)
    BX = 0;
    label_1000_D489_1D489:
    // RET  (1000_D489 / 0x1D489)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D48A_01D48A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D48A_1D48A:
    // PUSH word ptr [0xdbda] (1000_D48A / 0x1D48A)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_D48E / 0x1D48E)
    NearCall(cs1, 0xD491, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_D491_1D491:
    // CMP byte ptr [0xdce6],0x0 (1000_D491 / 0x1D491)
    Alu.Sub8(UInt8[DS, 0xDCE6], 0x0);
    // JLE 0x1000:d49b (1000_D496 / 0x1D496)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_D49B_1D49B;
    }
    // CALL 0x1000:c07c (1000_D498 / 0x1D498)
    NearCall(cs1, 0xD49B, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_D49B_1D49B:
    // CALL 0x1000:d075 (1000_D49B / 0x1D49B)
    NearCall(cs1, 0xD49E, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_D49E_1D49E:
    // MOV SI,AX (1000_D49E / 0x1D49E)
    SI = AX;
    // MOV AL,0xe (1000_D4A0 / 0x1D4A0)
    AL = 0xE;
    // MUL CL (1000_D4A2 / 0x1D4A2)
    Cpu.Mul8(CL);
    // MOV DI,AX (1000_D4A4 / 0x1D4A4)
    DI = AX;
    // ADD DI,0x1b48 (1000_D4A6 / 0x1D4A6)
    // DI += 0x1B48;
    DI = Alu.Add16(DI, 0x1B48);
    // MOV BX,word ptr [DI + 0x2] (1000_D4AA / 0x1D4AA)
    BX = UInt16[DS, (ushort)(DI + 0x2)];
    // INC BX (1000_D4AD / 0x1D4AD)
    BX = Alu.Inc16(BX);
    // MOV DX,0x5d (1000_D4AE / 0x1D4AE)
    DX = 0x5D;
    // CALL 0x1000:d04e (1000_D4B1 / 0x1D4B1)
    NearCall(cs1, 0xD4B4, spice86_generated_label_call_target_1000_D04E_01D04E);
    label_1000_D4B4_1D4B4:
    // MOV byte ptr [0xdbe5],0xf3 (1000_D4B4 / 0x1D4B4)
    UInt8[DS, 0xDBE5] = 0xF3;
    // AND byte ptr [DI + 0x8],0x7f (1000_D4B9 / 0x1D4B9)
    // UInt8[DS, (ushort)(DI + 0x8)] &= 0x7F;
    UInt8[DS, (ushort)(DI + 0x8)] = Alu.And8(UInt8[DS, (ushort)(DI + 0x8)], 0x7F);
    // MOV AX,SI (1000_D4BD / 0x1D4BD)
    AX = SI;
    // AND SI,0x3fff (1000_D4BF / 0x1D4BF)
    // SI &= 0x3FFF;
    SI = Alu.And16(SI, 0x3FFF);
    // JZ 0x1000:d4e9 (1000_D4C3 / 0x1D4C3)
    if(ZeroFlag) {
      goto label_1000_D4E9_1D4E9;
    }
    // MOV AL,0xf5 (1000_D4C5 / 0x1D4C5)
    AL = 0xF5;
    // TEST AH,0x40 (1000_D4C7 / 0x1D4C7)
    Alu.And8(AH, 0x40);
    // JNZ 0x1000:d4da (1000_D4CA / 0x1D4CA)
    if(!ZeroFlag) {
      goto label_1000_D4DA_1D4DA;
    }
    // OR byte ptr [DI + 0x8],0x80 (1000_D4CC / 0x1D4CC)
    // UInt8[DS, (ushort)(DI + 0x8)] |= 0x80;
    UInt8[DS, (ushort)(DI + 0x8)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0x8)], 0x80);
    // MOV AL,0xfa (1000_D4D0 / 0x1D4D0)
    AL = 0xFA;
    // OR AH,AH (1000_D4D2 / 0x1D4D2)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JNS 0x1000:d4da (1000_D4D4 / 0x1D4D4)
    if(!SignFlag) {
      goto label_1000_D4DA_1D4DA;
    }
    // XCHG byte ptr [0xdbe5],AL (1000_D4D6 / 0x1D4D6)
    byte tmp_1000_D4D6 = UInt8[DS, 0xDBE5];
    UInt8[DS, 0xDBE5] = AL;
    AL = tmp_1000_D4D6;
    label_1000_D4DA_1D4DA:
    // MOV [0xdbe4],AL (1000_D4DA / 0x1D4DA)
    UInt8[DS, 0xDBE4] = AL;
    // CALL 0x1000:cf70 (1000_D4DD / 0x1D4DD)
    NearCall(cs1, 0xD4E0, spice86_generated_label_call_target_1000_CF70_01CF70);
    label_1000_D4E0_1D4E0:
    // MOV AL,0x20 (1000_D4E0 / 0x1D4E0)
    AL = 0x20;
    // CALL word ptr [0x2518] (1000_D4E2 / 0x1D4E2)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_D4E2 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_D4E2) {
      case 0xD12F : NearCall(cs1, 0xD4E6, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D4E2));
        break;
    }
    label_1000_D4E6_1D4E6:
    // CALL 0x1000:d1bb (1000_D4E6 / 0x1D4E6)
    NearCall(cs1, 0xD4E9, spice86_generated_label_call_target_1000_D1BB_01D1BB);
    label_1000_D4E9_1D4E9:
    // CALL 0x1000:d05f (1000_D4E9 / 0x1D4E9)
    NearCall(cs1, 0xD4EC, spice86_generated_label_call_target_1000_D05F_01D05F);
    label_1000_D4EC_1D4EC:
    // MOV SI,0xdce9 (1000_D4EC / 0x1D4EC)
    SI = 0xDCE9;
    // MOV word ptr [SI],DX (1000_D4EF / 0x1D4EF)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_D4F1 / 0x1D4F1)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // MOV word ptr [SI + 0x4],0xe3 (1000_D4F4 / 0x1D4F4)
    UInt16[DS, (ushort)(SI + 0x4)] = 0xE3;
    // ADD BX,0x7 (1000_D4F9 / 0x1D4F9)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    // MOV word ptr [SI + 0x6],BX (1000_D4FC / 0x1D4FC)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV AL,[0xdbe5] (1000_D4FF / 0x1D4FF)
    AL = UInt8[DS, 0xDBE5];
    // MOV ES,word ptr [0xdbda] (1000_D502 / 0x1D502)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38dd] (1000_D506 / 0x1D506)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_D506 = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_D506) {
      case 0x235CE : FarCall(cs1, 0xD50A, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D506));
        break;
    }
    label_1000_D50A_1D50A:
    // POP word ptr [0xdbda] (1000_D50A / 0x1D50A)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_D50E / 0x1D50E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D50F_01D50F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D50F_1D50F:
    // PUSH BX (1000_D50F / 0x1D50F)
    Stack.Push(BX);
    // PUSH CX (1000_D510 / 0x1D510)
    Stack.Push(CX);
    // PUSH DX (1000_D511 / 0x1D511)
    Stack.Push(DX);
    // PUSH SI (1000_D512 / 0x1D512)
    Stack.Push(SI);
    // PUSH DI (1000_D513 / 0x1D513)
    Stack.Push(DI);
    // PUSH BP (1000_D514 / 0x1D514)
    Stack.Push(BP);
    // CMP byte ptr [0x4774],0x0 (1000_D515 / 0x1D515)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:d523 (1000_D51A / 0x1D51A)
    if(ZeroFlag) {
      goto label_1000_D523_1D523;
    }
    // MOV CL,byte ptr [0x4775] (1000_D51C / 0x1D51C)
    CL = UInt8[DS, 0x4775];
    // JMP 0x1000:d5dd (1000_D520 / 0x1D520)
    goto label_1000_D5DD_1D5DD;
    label_1000_D523_1D523:
    // CALL 0x1000:d41b (1000_D523 / 0x1D523)
    NearCall(cs1, 0xD526, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_D526_1D526:
    // CMP BP,0x1f0e (1000_D526 / 0x1D526)
    Alu.Sub16(BP, 0x1F0E);
    // JNZ 0x1000:d575 (1000_D52A / 0x1D52A)
    if(!ZeroFlag) {
      goto label_1000_D575_1D575;
    }
    // CMP byte ptr [0x11c9],0x0 (1000_D52C / 0x1D52C)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:d575 (1000_D531 / 0x1D531)
    if(!ZeroFlag) {
      goto label_1000_D575_1D575;
    }
    // MOV DI,0x1bf0 (1000_D533 / 0x1D533)
    DI = 0x1BF0;
    // CMP byte ptr [DI + 0x8],0x0 (1000_D536 / 0x1D536)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    // JNS 0x1000:d545 (1000_D53A / 0x1D53A)
    if(!SignFlag) {
      goto label_1000_D545_1D545;
    }
    // CALL 0x1000:d6fe (1000_D53C / 0x1D53C)
    NearCall(cs1, 0xD53F, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // MOV CX,word ptr [0x47c4] (1000_D53F / 0x1D53F)
    CX = UInt16[DS, 0x47C4];
    // JC 0x1000:d55d (1000_D543 / 0x1D543)
    if(CarryFlag) {
      goto label_1000_D55D_1D55D;
    }
    label_1000_D545_1D545:
    // PUSH BP (1000_D545 / 0x1D545)
    Stack.Push(BP);
    // CALL 0x1000:9285 (1000_D546 / 0x1D546)
    NearCall(cs1, 0xD549, spice86_generated_label_call_target_1000_9285_019285);
    label_1000_D549_1D549:
    // POP BP (1000_D549 / 0x1D549)
    BP = Stack.Pop();
    // JNC 0x1000:d575 (1000_D54A / 0x1D54A)
    if(!CarryFlag) {
      goto label_1000_D575_1D575;
    }
    // MOV AL,CL (1000_D54C / 0x1D54C)
    AL = CL;
    // SUB AL,0xf (1000_D54E / 0x1D54E)
    // AL -= 0xF;
    AL = Alu.Sub8(AL, 0xF);
    // JC 0x1000:d55d (1000_D550 / 0x1D550)
    if(CarryFlag) {
      goto label_1000_D55D_1D55D;
    }
    // INC AL (1000_D552 / 0x1D552)
    AL = Alu.Inc8(AL);
    // CMP AL,byte ptr [0x476b] (1000_D554 / 0x1D554)
    Alu.Sub8(AL, UInt8[DS, 0x476B]);
    // JNZ 0x1000:d55d (1000_D558 / 0x1D558)
    if(!ZeroFlag) {
      goto label_1000_D55D_1D55D;
    }
    // MOV CX,0x17 (1000_D55A / 0x1D55A)
    CX = 0x17;
    label_1000_D55D_1D55D:
    // MOV BP,CX (1000_D55D / 0x1D55D)
    BP = CX;
    // ADD BP,0x78 (1000_D55F / 0x1D55F)
    BP += 0x78;
    
    // XOR CX,CX (1000_D563 / 0x1D563)
    CX = 0;
    label_1000_D565_1D565:
    // CALL 0x1000:d454 (1000_D565 / 0x1D565)
    NearCall(cs1, 0xD568, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D568_1D568:
    // CMP AX,BP (1000_D568 / 0x1D568)
    Alu.Sub16(AX, BP);
    // JZ 0x1000:d5dd (1000_D56A / 0x1D56A)
    if(ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // INC CX (1000_D56C / 0x1D56C)
    CX = Alu.Inc16(CX);
    // CMP CL,byte ptr [0xdce8] (1000_D56D / 0x1D56D)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    // JC 0x1000:d565 (1000_D571 / 0x1D571)
    if(CarryFlag) {
      goto label_1000_D565_1D565;
    }
    // JMP 0x1000:d5db (1000_D573 / 0x1D573)
    goto label_1000_D5DB_1D5DB;
    label_1000_D575_1D575:
    // CMP BP,0x1f7e (1000_D575 / 0x1D575)
    Alu.Sub16(BP, 0x1F7E);
    // JNZ 0x1000:d5b1 (1000_D579 / 0x1D579)
    if(!ZeroFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    // MOV DI,0x1be2 (1000_D57B / 0x1D57B)
    DI = 0x1BE2;
    // CMP byte ptr [DI + 0x8],0x0 (1000_D57E / 0x1D57E)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    // JNS 0x1000:d593 (1000_D582 / 0x1D582)
    if(!SignFlag) {
      goto label_1000_D593_1D593;
    }
    // XOR CX,CX (1000_D584 / 0x1D584)
    CX = 0;
    // CALL 0x1000:d6fe (1000_D586 / 0x1D586)
    NearCall(cs1, 0xD589, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D589_1D589:
    // JC 0x1000:d5dd (1000_D589 / 0x1D589)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // MOV DI,0x1bf0 (1000_D58B / 0x1D58B)
    DI = 0x1BF0;
    // CALL 0x1000:d6fe (1000_D58E / 0x1D58E)
    NearCall(cs1, 0xD591, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D591_1D591:
    // JC 0x1000:d5dd (1000_D591 / 0x1D591)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    label_1000_D593_1D593:
    // CMP byte ptr [0x1bf8],0x0 (1000_D593 / 0x1D593)
    Alu.Sub8(UInt8[DS, 0x1BF8], 0x0);
    // JNS 0x1000:d5b1 (1000_D598 / 0x1D598)
    if(!SignFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    // MOV DI,0x1bfe (1000_D59A / 0x1D59A)
    DI = 0x1BFE;
    // CALL 0x1000:d6fe (1000_D59D / 0x1D59D)
    NearCall(cs1, 0xD5A0, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    label_1000_D5A0_1D5A0:
    // MOV CL,0x3 (1000_D5A0 / 0x1D5A0)
    CL = 0x3;
    // JC 0x1000:d5dd (1000_D5A2 / 0x1D5A2)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // CALL 0x1000:92c9 (1000_D5A4 / 0x1D5A4)
    NearCall(cs1, 0xD5A7, spice86_generated_label_call_target_1000_92C9_0192C9);
    label_1000_D5A7_1D5A7:
    // JNC 0x1000:d5b1 (1000_D5A7 / 0x1D5A7)
    if(!CarryFlag) {
      goto label_1000_D5B1_1D5B1;
    }
    // CMP CX,word ptr [0x47c4] (1000_D5A9 / 0x1D5A9)
    Alu.Sub16(CX, UInt16[DS, 0x47C4]);
    // MOV CL,0x2 (1000_D5AD / 0x1D5AD)
    CL = 0x2;
    // JZ 0x1000:d5dd (1000_D5AF / 0x1D5AF)
    if(ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    label_1000_D5B1_1D5B1:
    // CMP BX,0x98 (1000_D5B1 / 0x1D5B1)
    Alu.Sub16(BX, 0x98);
    // JC 0x1000:d5db (1000_D5B5 / 0x1D5B5)
    if(CarryFlag) {
      goto label_1000_D5DB_1D5DB;
    }
    // MOV CL,0xff (1000_D5B7 / 0x1D5B7)
    CL = 0xFF;
    // MOV DI,0x1b48 (1000_D5B9 / 0x1D5B9)
    DI = 0x1B48;
    // CMP DX,word ptr [DI] (1000_D5BC / 0x1D5BC)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JC 0x1000:d5dd (1000_D5BE / 0x1D5BE)
    if(CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_D5C0 / 0x1D5C0)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JNC 0x1000:d5dd (1000_D5C3 / 0x1D5C3)
    if(!CarryFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // XOR CX,CX (1000_D5C5 / 0x1D5C5)
    CX = 0;
    label_1000_D5C7_1D5C7:
    // CMP BX,word ptr [DI + 0x2] (1000_D5C7 / 0x1D5C7)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JBE 0x1000:d5db (1000_D5CA / 0x1D5CA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D5DB_1D5DB;
    }
    // CMP BX,word ptr [DI + 0x6] (1000_D5CC / 0x1D5CC)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // JBE 0x1000:d5dd (1000_D5CF / 0x1D5CF)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D5DD_1D5DD;
    }
    // ADD DI,0xe (1000_D5D1 / 0x1D5D1)
    DI += 0xE;
    
    // INC CX (1000_D5D4 / 0x1D5D4)
    CX = Alu.Inc16(CX);
    // CMP CL,byte ptr [0xdce8] (1000_D5D5 / 0x1D5D5)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    // JC 0x1000:d5c7 (1000_D5D9 / 0x1D5D9)
    if(CarryFlag) {
      goto label_1000_D5C7_1D5C7;
    }
    label_1000_D5DB_1D5DB:
    // MOV CL,0xff (1000_D5DB / 0x1D5DB)
    CL = 0xFF;
    label_1000_D5DD_1D5DD:
    // MOV AL,CL (1000_D5DD / 0x1D5DD)
    AL = CL;
    // XCHG byte ptr [0xdce7],CL (1000_D5DF / 0x1D5DF)
    byte tmp_1000_D5DF = UInt8[DS, 0xDCE7];
    UInt8[DS, 0xDCE7] = CL;
    CL = tmp_1000_D5DF;
    // CMP AL,CL (1000_D5E3 / 0x1D5E3)
    Alu.Sub8(AL, CL);
    // JZ 0x1000:d610 (1000_D5E5 / 0x1D5E5)
    if(ZeroFlag) {
      goto label_1000_D610_1D610;
    }
    // CALL 0x1000:dbb2 (1000_D5E7 / 0x1D5E7)
    NearCall(cs1, 0xD5EA, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_D5EA_1D5EA:
    // OR CL,CL (1000_D5EA / 0x1D5EA)
    // CL |= CL;
    CL = Alu.Or8(CL, CL);
    // JS 0x1000:d5fc (1000_D5EC / 0x1D5EC)
    if(SignFlag) {
      goto label_1000_D5FC_1D5FC;
    }
    // CMP CL,byte ptr [0xdce8] (1000_D5EE / 0x1D5EE)
    Alu.Sub8(CL, UInt8[DS, 0xDCE8]);
    // JNC 0x1000:d5fc (1000_D5F2 / 0x1D5F2)
    if(!CarryFlag) {
      goto label_1000_D5FC_1D5FC;
    }
    // PUSH AX (1000_D5F4 / 0x1D5F4)
    Stack.Push(AX);
    // CALL 0x1000:d454 (1000_D5F5 / 0x1D5F5)
    NearCall(cs1, 0xD5F8, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D5F8_1D5F8:
    // CALL 0x1000:d48a (1000_D5F8 / 0x1D5F8)
    NearCall(cs1, 0xD5FB, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D5FB_1D5FB:
    // POP AX (1000_D5FB / 0x1D5FB)
    AX = Stack.Pop();
    label_1000_D5FC_1D5FC:
    // CMP AL,byte ptr [0xdce8] (1000_D5FC / 0x1D5FC)
    Alu.Sub8(AL, UInt8[DS, 0xDCE8]);
    // JNC 0x1000:d60d (1000_D600 / 0x1D600)
    if(!CarryFlag) {
      goto label_1000_D60D_1D60D;
    }
    // MOV CX,AX (1000_D602 / 0x1D602)
    CX = AX;
    // CALL 0x1000:d454 (1000_D604 / 0x1D604)
    NearCall(cs1, 0xD607, spice86_generated_label_call_target_1000_D454_01D454);
    label_1000_D607_1D607:
    // OR AH,0x80 (1000_D607 / 0x1D607)
    // AH |= 0x80;
    AH = Alu.Or8(AH, 0x80);
    // CALL 0x1000:d48a (1000_D60A / 0x1D60A)
    NearCall(cs1, 0xD60D, spice86_generated_label_call_target_1000_D48A_01D48A);
    label_1000_D60D_1D60D:
    // CALL 0x1000:dbec (1000_D60D / 0x1D60D)
    NearCall(cs1, 0xD610, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    label_1000_D610_1D610:
    // POP BP (1000_D610 / 0x1D610)
    BP = Stack.Pop();
    // POP DI (1000_D611 / 0x1D611)
    DI = Stack.Pop();
    // POP SI (1000_D612 / 0x1D612)
    SI = Stack.Pop();
    // POP DX (1000_D613 / 0x1D613)
    DX = Stack.Pop();
    // POP CX (1000_D614 / 0x1D614)
    CX = Stack.Pop();
    // POP BX (1000_D615 / 0x1D615)
    BX = Stack.Pop();
    // RET  (1000_D616 / 0x1D616)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D61D_01D61D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D61D_1D61D:
    // PUSH AX (1000_D61D / 0x1D61D)
    Stack.Push(AX);
    // MOV AX,0x9f (1000_D61E / 0x1D61E)
    AX = 0x9F;
    label_1000_D621_1D621:
    // CALL 0x1000:e270 (1000_D621 / 0x1D621)
    NearCall(cs1, 0xD624, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_D624_1D624:
    // CALL 0x1000:d41b (1000_D624 / 0x1D624)
    NearCall(cs1, 0xD627, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_D627_1D627:
    // MOV SI,0x1f7e (1000_D627 / 0x1D627)
    SI = 0x1F7E;
    // CMP word ptr [SI + 0x2],AX (1000_D62A / 0x1D62A)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], AX);
    // MOV word ptr [SI + 0x2],AX (1000_D62D / 0x1D62D)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // JZ 0x1000:d649 (1000_D630 / 0x1D630)
    if(ZeroFlag) {
      goto label_1000_D649_1D649;
    }
    // CMP BP,SI (1000_D632 / 0x1D632)
    Alu.Sub16(BP, SI);
    // JNZ 0x1000:d649 (1000_D634 / 0x1D634)
    if(!ZeroFlag) {
      goto label_1000_D649_1D649;
    }
    // CALL 0x1000:dbb2 (1000_D636 / 0x1D636)
    NearCall(cs1, 0xD639, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // XOR CX,CX (1000_D639 / 0x1D639)
    CX = 0;
    // CALL 0x1000:d454 (1000_D63B / 0x1D63B)
    NearCall(cs1, 0xD63E, spice86_generated_label_call_target_1000_D454_01D454);
    // CALL 0x1000:d48a (1000_D63E / 0x1D63E)
    NearCall(cs1, 0xD641, spice86_generated_label_call_target_1000_D48A_01D48A);
    // MOV byte ptr [0xdce7],0xff (1000_D641 / 0x1D641)
    UInt8[DS, 0xDCE7] = 0xFF;
    // CALL 0x1000:dbec (1000_D646 / 0x1D646)
    NearCall(cs1, 0xD649, spice86_generated_label_ret_target_1000_DBEC_01DBEC);
    label_1000_D649_1D649:
    // CALL 0x1000:e283 (1000_D649 / 0x1D649)
    NearCall(cs1, 0xD64C, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_D64C_1D64C:
    // POP AX (1000_D64C / 0x1D64C)
    AX = Stack.Pop();
    // RET  (1000_D64D / 0x1D64D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D65A_01D65A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D65A_1D65A:
    // TEST byte ptr [DI + 0x9],0x20 (1000_D65A / 0x1D65A)
    Alu.And8(UInt8[DS, (ushort)(DI + 0x9)], 0x20);
    // JZ 0x1000:d676 (1000_D65E / 0x1D65E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D676 / 0x1D676)
      return NearRet();
    }
    // MOV word ptr [0xdc60],DI (1000_D660 / 0x1D660)
    UInt16[DS, 0xDC60] = DI;
    // INC word ptr [DI + 0xa] (1000_D664 / 0x1D664)
    UInt16[DS, (ushort)(DI + 0xA)] = Alu.Inc16(UInt16[DS, (ushort)(DI + 0xA)]);
    // PUSH SI (1000_D667 / 0x1D667)
    Stack.Push(SI);
    // PUSH DI (1000_D668 / 0x1D668)
    Stack.Push(DI);
    // MOV SI,DI (1000_D669 / 0x1D669)
    SI = DI;
    // MOV CX,0x1 (1000_D66B / 0x1D66B)
    CX = 0x1;
    // CALL 0x1000:d1f2 (1000_D66E / 0x1D66E)
    NearCall(cs1, 0xD671, spice86_generated_label_call_target_1000_D1F2_01D1F2);
    // POP DI (1000_D671 / 0x1D671)
    DI = Stack.Pop();
    // POP SI (1000_D672 / 0x1D672)
    SI = Stack.Pop();
    // DEC word ptr [DI + 0xa] (1000_D673 / 0x1D673)
    UInt16[DS, (ushort)(DI + 0xA)] = Alu.Dec16(UInt16[DS, (ushort)(DI + 0xA)]);
    label_1000_D676_1D676:
    // RET  (1000_D676 / 0x1D676)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D694_01D694(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D694_1D694:
    // MOV AX,[0x2582] (1000_D694 / 0x1D694)
    AX = UInt16[DS, 0x2582];
    // MOV DI,0x1b9c (1000_D697 / 0x1D697)
    DI = 0x1B9C;
    // CMP AX,0x260c (1000_D69A / 0x1D69A)
    Alu.Sub16(AX, 0x260C);
    // JZ 0x1000:d6b5 (1000_D69D / 0x1D69D)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    // ADD DI,0xe (1000_D69F / 0x1D69F)
    DI += 0xE;
    
    // CMP AX,0x2650 (1000_D6A2 / 0x1D6A2)
    Alu.Sub16(AX, 0x2650);
    // JZ 0x1000:d6b5 (1000_D6A5 / 0x1D6A5)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    // ADD DI,0xe (1000_D6A7 / 0x1D6A7)
    DI += 0xE;
    
    // CMP AX,0x2694 (1000_D6AA / 0x1D6AA)
    Alu.Sub16(AX, 0x2694);
    // JZ 0x1000:d6b5 (1000_D6AD / 0x1D6AD)
    if(ZeroFlag) {
      goto label_1000_D6B5_1D6B5;
    }
    // ADD DI,0xe (1000_D6AF / 0x1D6AF)
    DI += 0xE;
    
    // CMP AX,0x26d8 (1000_D6B2 / 0x1D6B2)
    Alu.Sub16(AX, 0x26D8);
    label_1000_D6B5_1D6B5:
    // STC  (1000_D6B5 / 0x1D6B5)
    CarryFlag = true;
    // RET  (1000_D6B6 / 0x1D6B6)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D6B7_01D6B7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D6B7_1D6B7:
    // CALL 0x1000:d694 (1000_D6B7 / 0x1D6B7)
    NearCall(cs1, 0xD6BA, spice86_generated_label_call_target_1000_D694_01D694);
    label_1000_D6BA_1D6BA:
    // JZ 0x1000:d6fd (1000_D6BA / 0x1D6BA)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_D6FD / 0x1D6FD)
      return NearRet();
    }
    // MOV DI,0x1ae4 (1000_D6BC / 0x1D6BC)
    DI = 0x1AE4;
    // MOV CX,word ptr [DI] (1000_D6BF / 0x1D6BF)
    CX = UInt16[DS, DI];
    // ADD DI,0x2 (1000_D6C1 / 0x1D6C1)
    DI += 0x2;
    
    // CMP word ptr [0x2570],0x1ad6 (1000_D6C4 / 0x1D6C4)
    Alu.Sub16(UInt16[DS, 0x2570], 0x1AD6);
    // JNZ 0x1000:d6cf (1000_D6CA / 0x1D6CA)
    if(!ZeroFlag) {
      goto label_1000_D6CF_1D6CF;
    }
    // SUB CX,0x5 (1000_D6CC / 0x1D6CC)
    CX -= 0x5;
    
    label_1000_D6CF_1D6CF:
    // CMP byte ptr [0x46d9],0x0 (1000_D6CF / 0x1D6CF)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JZ 0x1000:d6dc (1000_D6D4 / 0x1D6D4)
    if(ZeroFlag) {
      goto label_1000_D6DC_1D6DC;
    }
    // MOV CX,0x5 (1000_D6D6 / 0x1D6D6)
    CX = 0x5;
    // MOV DI,0x1b48 (1000_D6D9 / 0x1D6D9)
    DI = 0x1B48;
    label_1000_D6DC_1D6DC:
    // CMP byte ptr [DI + 0x8],0x0 (1000_D6DC / 0x1D6DC)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x0);
    // JNS 0x1000:d6f7 (1000_D6E0 / 0x1D6E0)
    if(!SignFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // CMP DX,word ptr [DI] (1000_D6E2 / 0x1D6E2)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JBE 0x1000:d6f7 (1000_D6E4 / 0x1D6E4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_D6E6 / 0x1D6E6)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JNC 0x1000:d6f7 (1000_D6E9 / 0x1D6E9)
    if(!CarryFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // CMP BX,word ptr [DI + 0x2] (1000_D6EB / 0x1D6EB)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JBE 0x1000:d6f7 (1000_D6EE / 0x1D6EE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D6F7_1D6F7;
    }
    // DEC BX (1000_D6F0 / 0x1D6F0)
    BX = Alu.Dec16(BX);
    // CMP BX,word ptr [DI + 0x6] (1000_D6F1 / 0x1D6F1)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // INC BX (1000_D6F4 / 0x1D6F4)
    BX = Alu.Inc16(BX);
    // JC 0x1000:d6fd (1000_D6F5 / 0x1D6F5)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_D6FD / 0x1D6FD)
      return NearRet();
    }
    label_1000_D6F7_1D6F7:
    // ADD DI,0xe (1000_D6F7 / 0x1D6F7)
    // DI += 0xE;
    DI = Alu.Add16(DI, 0xE);
    // LOOP 0x1000:d6dc (1000_D6FA / 0x1D6FA)
    if(--CX != 0) {
      goto label_1000_D6DC_1D6DC;
    }
    // CLC  (1000_D6FC / 0x1D6FC)
    CarryFlag = false;
    label_1000_D6FD_1D6FD:
    // RET  (1000_D6FD / 0x1D6FD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_D6FE_01D6FE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D6FE_1D6FE:
    // CMP DX,word ptr [DI] (1000_D6FE / 0x1D6FE)
    Alu.Sub16(DX, UInt16[DS, DI]);
    // JBE 0x1000:d710 (1000_D700 / 0x1D700)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D710_1D710;
    }
    // CMP DX,word ptr [DI + 0x4] (1000_D702 / 0x1D702)
    Alu.Sub16(DX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JNC 0x1000:d710 (1000_D705 / 0x1D705)
    if(!CarryFlag) {
      goto label_1000_D710_1D710;
    }
    // CMP BX,word ptr [DI + 0x2] (1000_D707 / 0x1D707)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x2)]);
    // JBE 0x1000:d710 (1000_D70A / 0x1D70A)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D710_1D710;
    }
    // CMP BX,word ptr [DI + 0x6] (1000_D70C / 0x1D70C)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x6)]);
    // RET  (1000_D70F / 0x1D70F)
    return NearRet();
    label_1000_D710_1D710:
    // CLC  (1000_D710 / 0x1D710)
    CarryFlag = false;
    // RET  (1000_D711 / 0x1D711)
    return NearRet();
  }
  
  public Action split_1000_D712_01D712(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D712_1D712:
    // MOV SI,0x1cca (1000_D712 / 0x1D712)
    SI = 0x1CCA;
    // JMP 0x1000:d72b (1000_D715 / 0x1D715)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_D717_01D717(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_D717_1D717:
    // CMP byte ptr [0x46eb],0x0 (1000_D717 / 0x1D717)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNZ 0x1000:d712 (1000_D71C / 0x1D71C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D712_01D712, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1c76 (1000_D71E / 0x1D71E)
    SI = 0x1C76;
    // TEST byte ptr [0x11c9],0x3 (1000_D721 / 0x1D721)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JZ 0x1000:d72b (1000_D726 / 0x1D726)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV SI,0x1d72 (1000_D728 / 0x1D728)
    SI = 0x1D72;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
