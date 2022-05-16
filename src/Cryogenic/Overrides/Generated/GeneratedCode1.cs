namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_1803_011803(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1803_11803:
    // CMP byte ptr [0x28e7],0x0 (1000_1803 / 0x11803)
    Alu.Sub8(UInt8[DS, 0x28E7], 0x0);
    // JNZ 0x1000:181d (1000_1808 / 0x11808)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // CMP byte ptr [0xe8],0x0 (1000_180A / 0x1180A)
    Alu.Sub8(UInt8[DS, 0xE8], 0x0);
    // JZ 0x1000:181d (1000_180F / 0x1180F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // MOV byte ptr [0xce66],0x1 (1000_1811 / 0x11811)
    UInt8[DS, 0xCE66] = 0x1;
    // CALL 0x1000:181e (1000_1816 / 0x11816)
    NearCall(cs1, 0x1819, spice86_generated_label_call_target_1000_181E_01181E);
    label_1000_1819_11819:
    // DEC byte ptr [0xce66] (1000_1819 / 0x11819)
    UInt8[DS, 0xCE66] = Alu.Dec8(UInt8[DS, 0xCE66]);
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_181E_01181E, 0x1181D - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_181E_01181E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x181D: break; // Instructions before entry targeted by 0x11823, 0x117F2, 0x11848
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_181D_1181D:
    // RET  (1000_181D / 0x1181D)
    return NearRet();
    entry:
    label_1000_181E_1181E:
    // CMP byte ptr [0xe8],0x0 (1000_181E / 0x1181E)
    Alu.Sub8(UInt8[DS, 0xE8], 0x0);
    // JZ 0x1000:181d (1000_1823 / 0x11823)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // DEC byte ptr [0xe8] (1000_1825 / 0x11825)
    UInt8[DS, 0xE8] = Alu.Dec8(UInt8[DS, 0xE8]);
    // CALL 0x1000:17be (1000_1829 / 0x11829)
    NearCall(cs1, 0x182C, spice86_generated_label_call_target_1000_17BE_0117BE);
    label_1000_182C_1182C:
    // MOV AX,0x8 (1000_182C / 0x1182C)
    AX = 0x8;
    // CALL 0x1000:e387 (1000_182F / 0x1182F)
    NearCall(cs1, 0x1832, spice86_generated_label_call_target_1000_E387_01E387);
    label_1000_1832_11832:
    // JMP 0x1000:181e (1000_1832 / 0x11832)
    goto label_1000_181E_1181E;
  }
  
  public Action spice86_generated_label_call_target_1000_1834_011834(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1834_11834:
    // MOV SI,0xcd9e (1000_1834 / 0x11834)
    SI = 0xCD9E;
    // MOV BP,0x1e76 (1000_1837 / 0x11837)
    BP = 0x1E76;
    // MOV ES,word ptr [0xdbd6] (1000_183A / 0x1183A)
    ES = UInt16[DS, 0xDBD6];
    // CALLF [0x3919] (1000_183E / 0x1183E)
    // Indirect call to [0x3919], generating possible targets from emulator records
    uint targetAddress_1000_183E = (uint)(UInt16[DS, 0x391B] * 0x10 + UInt16[DS, 0x3919] - cs1 * 0x10);
    switch(targetAddress_1000_183E) {
      case 0x235FB : FarCall(cs1, 0x1842, spice86_generated_label_call_target_334B_014B_0335FB); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_183E));
        break;
    }
    label_1000_1842_11842:
    // RET  (1000_1842 / 0x11842)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1843_011843(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1843_11843:
    // CMP byte ptr [0xe8],0x0 (1000_1843 / 0x11843)
    Alu.Sub8(UInt8[DS, 0xE8], 0x0);
    // JZ 0x1000:181d (1000_1848 / 0x11848)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // MOV byte ptr [0xe8],0x9 (1000_184A / 0x1184A)
    UInt8[DS, 0xE8] = 0x9;
    // CALL 0x1000:17be (1000_184F / 0x1184F)
    NearCall(cs1, 0x1852, spice86_generated_label_call_target_1000_17BE_0117BE);
    // MOV AX,0x8 (1000_1852 / 0x11852)
    AX = 0x8;
    // CALL 0x1000:e387 (1000_1855 / 0x11855)
    NearCall(cs1, 0x1858, spice86_generated_label_call_target_1000_E387_01E387);
    // MOV byte ptr [0xe8],0x8 (1000_1858 / 0x11858)
    UInt8[DS, 0xE8] = 0x8;
    // JMP 0x1000:17be (1000_185D / 0x1185D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17BE_0117BE, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_1860_011860(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x186B: goto label_1000_186B_1186B;break; // Target of external jump from 0x1D451
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_1860_11860:
    // CMP byte ptr [0x11c9],0x0 (1000_1860 / 0x11860)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JZ 0x1000:1868 (1000_1865 / 0x11865)
    if(ZeroFlag) {
      goto label_1000_1868_11868;
    }
    // RET  (1000_1867 / 0x11867)
    return NearRet();
    label_1000_1868_11868:
    // CALL 0x1000:1843 (1000_1868 / 0x11868)
    NearCall(cs1, 0x186B, spice86_generated_label_call_target_1000_1843_011843);
    label_1000_186B_1186B:
    // CALL 0x1000:daa3 (1000_186B / 0x1186B)
    NearCall(cs1, 0x186E, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    label_1000_186E_1186E:
    // NEG byte ptr [0xfb] (1000_186E / 0x1186E)
    UInt8[DS, 0xFB] = Alu.Sub8(0, UInt8[DS, 0xFB]);
    // JNS 0x1000:1877 (1000_1872 / 0x11872)
    if(!SignFlag) {
      goto label_1000_1877_11877;
    }
    // JMP 0x1000:5a1a (1000_1874 / 0x11874)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5A1A_015A1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1877_11877:
    // CALL 0x1000:d2bd (1000_1877 / 0x11877)
    NearCall(cs1, 0x187A, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    label_1000_187A_1187A:
    // CALL 0x1000:5adf (1000_187A / 0x1187A)
    NearCall(cs1, 0x187D, spice86_generated_label_call_target_1000_5ADF_015ADF);
    label_1000_187D_1187D:
    // MOV AL,[0x28e8] (1000_187D / 0x1187D)
    AL = UInt8[DS, 0x28E8];
    // MOV [0x28e7],AL (1000_1880 / 0x11880)
    UInt8[DS, 0x28E7] = AL;
    // CALL 0x1000:b930 (1000_1883 / 0x11883)
    NearCall(cs1, 0x1886, spice86_generated_label_call_target_1000_B930_01B930);
    label_1000_1886_11886:
    // MOV word ptr [0x1c14],0x80 (1000_1886 / 0x11886)
    UInt16[DS, 0x1C14] = 0x80;
    // MOV word ptr [0x1c22],0x80 (1000_188C / 0x1188C)
    UInt16[DS, 0x1C22] = 0x80;
    // MOV BP,0xd75a (1000_1892 / 0x11892)
    BP = 0xD75A;
    // CALL 0x1000:c097 (1000_1895 / 0x11895)
    NearCall(cs1, 0x1898, spice86_generated_label_call_target_1000_C097_01C097);
    label_1000_1898_11898:
    // MOV AL,0x34 (1000_1898 / 0x11898)
    AL = 0x34;
    label_1000_189A_1189A:
    // MOV BP,0x2db1 (1000_189A / 0x1189A)
    BP = 0x2DB1;
    // CMP byte ptr [0x46d9],0x0 (1000_189D / 0x1189D)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JZ 0x1000:18a6 (1000_18A2 / 0x118A2)
    if(ZeroFlag) {
      goto label_1000_18A6_118A6;
    }
    // JMP BP (1000_18A4 / 0x118A4)
    // Indirect jump to BP, generating possible targets from emulator records
    uint targetAddress_1000_18A4 = (uint)(BP);
    switch(targetAddress_1000_18A4) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_18A4));
        break;
    }
    label_1000_18A6_118A6:
    // XOR DX,DX (1000_18A6 / 0x118A6)
    DX = 0;
    // CALL 0x1000:c108 (1000_18A8 / 0x118A8)
    NearCall(cs1, 0x18AB, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_18AB_118AB:
    // CALL 0x1000:c07c (1000_18AB / 0x118AB)
    NearCall(cs1, 0x18AE, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_18AE_118AE:
    // CALL 0x1000:ae04 (1000_18AE / 0x118AE)
    NearCall(cs1, 0x18B1, spice86_generated_label_call_target_1000_AE04_01AE04);
    label_1000_18B1_118B1:
    // MOV AX,[0xce7a] (1000_18B1 / 0x118B1)
    AX = UInt16[DS, 0xCE7A];
    // MOV [0xdc5a],AX (1000_18B4 / 0x118B4)
    UInt16[DS, 0xDC5A] = AX;
    // JMP 0x1000:17e6 (1000_18B7 / 0x118B7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_17E6_0117E6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_18BA_0118BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_18BA_118BA:
    // MOV word ptr [0x1c06],0x0 (1000_18BA / 0x118BA)
    UInt16[DS, 0x1C06] = 0x0;
    // MOV word ptr [0x1c14],0x0 (1000_18C0 / 0x118C0)
    UInt16[DS, 0x1C14] = 0x0;
    // MOV word ptr [0x1c22],0x0 (1000_18C6 / 0x118C6)
    UInt16[DS, 0x1C22] = 0x0;
    // CALL 0x1000:39e6 (1000_18CC / 0x118CC)
    NearCall(cs1, 0x18CF, spice86_generated_label_call_target_1000_39E6_0139E6);
    label_1000_18CF_118CF:
    // CALL 0x1000:ac30 (1000_18CF / 0x118CF)
    NearCall(cs1, 0x18D2, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_18D2_118D2:
    // CALL 0x1000:4d00 (1000_18D2 / 0x118D2)
    NearCall(cs1, 0x18D5, spice86_generated_label_call_target_1000_4D00_014D00);
    label_1000_18D5_118D5:
    // CALL 0x1000:d2bd (1000_18D5 / 0x118D5)
    NearCall(cs1, 0x18D8, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    label_1000_18D8_118D8:
    // CALL 0x1000:4aca (1000_18D8 / 0x118D8)
    NearCall(cs1, 0x18DB, spice86_generated_label_call_target_1000_4ACA_014ACA);
    label_1000_18DB_118DB:
    // CALL 0x1000:98e6 (1000_18DB / 0x118DB)
    NearCall(cs1, 0x18DE, spice86_generated_label_call_target_1000_98E6_0198E6);
    label_1000_18DE_118DE:
    // MOV byte ptr [0x46df],0x0 (1000_18DE / 0x118DE)
    UInt8[DS, 0x46DF] = 0x0;
    // CMP byte ptr [0x2b],0x0 (1000_18E3 / 0x118E3)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:18ed (1000_18E8 / 0x118E8)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_18ED / 0x118ED)
      return NearRet();
    }
    // CALL 0x1000:0b21 (1000_18EA / 0x118EA)
    NearCall(cs1, 0x18ED, spice86_generated_label_call_target_1000_0B21_010B21);
    label_1000_18ED_118ED:
    // RET  (1000_18ED / 0x118ED)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1A0F_011A0F(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1A33: goto label_1000_1A33_11A33;break; // Target of external jump from 0x11A39
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_1A0F_11A0F:
    // CMP word ptr [0x1afe],0x0 (1000_1A0F / 0x11A0F)
    Alu.Sub16(UInt16[DS, 0x1AFE], 0x0);
    // JNZ 0x1000:1a33 (1000_1A14 / 0x11A14)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1A33 / 0x11A33)
      return NearRet();
    }
    // CALL 0x1000:dbb2 (1000_1A16 / 0x11A16)
    NearCall(cs1, 0x1A19, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    label_1000_1A19_11A19:
    // PUSH word ptr [0x2784] (1000_1A19 / 0x11A19)
    Stack.Push(UInt16[DS, 0x2784]);
    // CALL 0x1000:c137 (1000_1A1D / 0x11A1D)
    NearCall(cs1, 0x1A20, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_1A20_11A20:
    // MOV SI,0x1af4 (1000_1A20 / 0x11A20)
    SI = 0x1AF4;
    // CALL 0x1000:d200 (1000_1A23 / 0x11A23)
    NearCall(cs1, 0x1A26, spice86_generated_label_call_target_1000_D200_01D200);
    label_1000_1A26_11A26:
    // CALL 0x1000:1a34 (1000_1A26 / 0x11A26)
    NearCall(cs1, 0x1A29, spice86_generated_label_call_target_1000_1A34_011A34);
    label_1000_1A29_11A29:
    // MOV SI,0x1f06 (1000_1A29 / 0x11A29)
    SI = 0x1F06;
    // CALL 0x1000:c4aa (1000_1A2C / 0x11A2C)
    NearCall(cs1, 0x1A2F, spice86_generated_label_call_target_1000_C4AA_01C4AA);
    label_1000_1A2F_11A2F:
    // POP AX (1000_1A2F / 0x11A2F)
    AX = Stack.Pop();
    // CALL 0x1000:c13e (1000_1A30 / 0x11A30)
    NearCall(cs1, 0x1A33, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_1A33_11A33:
    // RET  (1000_1A33 / 0x11A33)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1A34_011A34(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1A34_11A34:
    // CMP word ptr [0x1afe],0x0 (1000_1A34 / 0x11A34)
    Alu.Sub16(UInt16[DS, 0x1AFE], 0x0);
    // JNZ 0x1000:1a33 (1000_1A39 / 0x11A39)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1A33 / 0x11A33)
      return NearRet();
    }
    // PUSH word ptr [0xdbda] (1000_1A3B / 0x11A3B)
    Stack.Push(UInt16[DS, 0xDBDA]);
    // CALL 0x1000:c08e (1000_1A3F / 0x11A3F)
    NearCall(cs1, 0x1A42, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_1A42_11A42:
    // MOV AX,[0x2] (1000_1A42 / 0x11A42)
    AX = UInt16[DS, 0x2];
    // AND AX,0xf (1000_1A45 / 0x11A45)
    AX &= 0xF;
    
    // SHL AX,0x1 (1000_1A48 / 0x11A48)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_1A4A / 0x11A4A)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_1A4C / 0x11A4C)
    AX <<= 0x1;
    
    // ADD AX,0x1e7e (1000_1A4E / 0x11A4E)
    // AX += 0x1E7E;
    AX = Alu.Add16(AX, 0x1E7E);
    // MOV SI,AX (1000_1A51 / 0x11A51)
    SI = AX;
    // MOV AX,0x4a (1000_1A53 / 0x11A53)
    AX = 0x4A;
    // CALL 0x1000:1a9b (1000_1A56 / 0x11A56)
    NearCall(cs1, 0x1A59, spice86_generated_label_call_target_1000_1A9B_011A9B);
    label_1000_1A59_11A59:
    // MOV AX,0x4b (1000_1A59 / 0x11A59)
    AX = 0x4B;
    // CALL 0x1000:1a9b (1000_1A5C / 0x11A5C)
    NearCall(cs1, 0x1A5F, spice86_generated_label_call_target_1000_1A9B_011A9B);
    label_1000_1A5F_11A5F:
    // CALL 0x1000:d075 (1000_1A5F / 0x11A5F)
    NearCall(cs1, 0x1A62, spice86_generated_label_call_target_1000_D075_01D075);
    label_1000_1A62_11A62:
    // MOV word ptr [0xdbe4],0xf1fa (1000_1A62 / 0x11A62)
    UInt16[DS, 0xDBE4] = 0xF1FA;
    // CALL 0x1000:1ad1 (1000_1A68 / 0x11A68)
    NearCall(cs1, 0x1A6B, spice86_generated_label_call_target_1000_1AD1_011AD1);
    label_1000_1A6B_11A6B:
    // MOV BX,0x16d (1000_1A6B / 0x11A6B)
    BX = 0x16D;
    // ADD AX,BX (1000_1A6E / 0x11A6E)
    AX += BX;
    
    label_1000_1A70_11A70:
    // SUB AX,BX (1000_1A70 / 0x11A70)
    AX -= BX;
    
    // CMP AX,BX (1000_1A72 / 0x11A72)
    Alu.Sub16(AX, BX);
    // JNC 0x1000:1a70 (1000_1A74 / 0x11A74)
    if(!CarryFlag) {
      goto label_1000_1A70_11A70;
    }
    // INC AX (1000_1A76 / 0x11A76)
    AX = Alu.Inc16(AX);
    // MOV DX,0xb (1000_1A77 / 0x11A77)
    DX = 0xB;
    // MOV BX,0xbe (1000_1A7A / 0x11A7A)
    BX = 0xBE;
    // CMP AX,0x64 (1000_1A7D / 0x11A7D)
    Alu.Sub16(AX, 0x64);
    // JNC 0x1000:1a8d (1000_1A80 / 0x11A80)
    if(!CarryFlag) {
      goto label_1000_1A8D_11A8D;
    }
    // SUB DL,0x2 (1000_1A82 / 0x11A82)
    DL -= 0x2;
    
    // CMP AX,0xa (1000_1A85 / 0x11A85)
    Alu.Sub16(AX, 0xA);
    // JNC 0x1000:1a8d (1000_1A88 / 0x11A88)
    if(!CarryFlag) {
      goto label_1000_1A8D_11A8D;
    }
    // SUB DL,0x2 (1000_1A8A / 0x11A8A)
    // DL -= 0x2;
    DL = Alu.Sub8(DL, 0x2);
    label_1000_1A8D_11A8D:
    // CALL 0x1000:e290 (1000_1A8D / 0x11A8D)
    NearCall(cs1, 0x1A90, spice86_generated_label_call_target_1000_E290_01E290);
    label_1000_1A90_11A90:
    // MOV AL,0x20 (1000_1A90 / 0x11A90)
    AL = 0x20;
    // CALL word ptr [0x2518] (1000_1A92 / 0x11A92)
    // Indirect call to word ptr [0x2518], generating possible targets from emulator records
    uint targetAddress_1000_1A92 = (uint)(UInt16[DS, 0x2518]);
    switch(targetAddress_1000_1A92) {
      case 0xD12F : NearCall(cs1, 0x1A96, spice86_generated_label_call_target_1000_D12F_01D12F); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_1A92));
        break;
    }
    label_1000_1A96_11A96:
    // POP word ptr [0xdbda] (1000_1A96 / 0x11A96)
    UInt16[DS, 0xDBDA] = Stack.Pop();
    // RET  (1000_1A9A / 0x11A9A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1A9B_011A9B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1A9B_11A9B:
    // PUSH AX (1000_1A9B / 0x11A9B)
    Stack.Push(AX);
    // LODSW SI (1000_1A9C / 0x11A9C)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_1A9D / 0x11A9D)
    DX = AX;
    // LODSW SI (1000_1A9F / 0x11A9F)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV BX,AX (1000_1AA0 / 0x11AA0)
    BX = AX;
    // POP AX (1000_1AA2 / 0x11AA2)
    AX = Stack.Pop();
    // OR DX,DX (1000_1AA3 / 0x11AA3)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:1ac4 (1000_1AA5 / 0x11AA5)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1AC4 / 0x11AC4)
      return NearRet();
    }
    // PUSH SI (1000_1AA7 / 0x11AA7)
    Stack.Push(SI);
    // CALL 0x1000:c1f4 (1000_1AA8 / 0x11AA8)
    NearCall(cs1, 0x1AAB, spice86_generated_label_call_target_1000_C1F4_01C1F4);
    label_1000_1AAB_11AAB:
    // PUSH DS (1000_1AAB / 0x11AAB)
    Stack.Push(DS);
    // PUSH ES (1000_1AAC / 0x11AAC)
    Stack.Push(ES);
    // MOV ES,word ptr [0xdbd8] (1000_1AAD / 0x11AAD)
    ES = UInt16[DS, 0xDBD8];
    // POP DS (1000_1AB1 / 0x11AB1)
    DS = Stack.Pop();
    // LODSW SI (1000_1AB2 / 0x11AB2)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_1AB3 / 0x11AB3)
    DI = AX;
    // LODSW SI (1000_1AB5 / 0x11AB5)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,AX (1000_1AB6 / 0x11AB6)
    CX = AX;
    // XOR CH,CH (1000_1AB8 / 0x11AB8)
    CH = 0;
    // MOV BP,0x1efe (1000_1ABA / 0x11ABA)
    BP = 0x1EFE;
    // CALLF [0x38cd] (1000_1ABD / 0x11ABD)
    // Indirect call to [0x38cd], generating possible targets from emulator records
    uint targetAddress_1000_1ABD = (uint)(UInt16[SS, 0x38CF] * 0x10 + UInt16[SS, 0x38CD] - cs1 * 0x10);
    switch(targetAddress_1000_1ABD) {
      case 0x235C2 : throw FailAsUntested("Could not find a valid function at address 334B_0112 / 0x335C2");
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_1ABD));
        break;
    }
    label_1000_1AC2_11AC2:
    // POP DS (1000_1AC2 / 0x11AC2)
    DS = Stack.Pop();
    // POP SI (1000_1AC3 / 0x11AC3)
    SI = Stack.Pop();
    label_1000_1AC4_11AC4:
    // RET  (1000_1AC4 / 0x11AC4)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1AC5_011AC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1AC5_11AC5:
    // MOV AX,[0x2] (1000_1AC5 / 0x11AC5)
    AX = UInt16[DS, 0x2];
    // SHR AX,0x1 (1000_1AC8 / 0x11AC8)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_1ACA / 0x11ACA)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_1ACC / 0x11ACC)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_1ACE / 0x11ACE)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_1AD0 / 0x11AD0)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1AD1_011AD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1AD1_11AD1:
    // MOV AX,[0x2] (1000_1AD1 / 0x11AD1)
    AX = UInt16[DS, 0x2];
    // ADD AX,0x3 (1000_1AD4 / 0x11AD4)
    AX += 0x3;
    
    // SHR AX,0x1 (1000_1AD7 / 0x11AD7)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_1AD9 / 0x11AD9)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_1ADB / 0x11ADB)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_1ADD / 0x11ADD)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_1ADF / 0x11ADF)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1AE0_011AE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1AE0_11AE0:
    // MOV AX,[0x2] (1000_1AE0 / 0x11AE0)
    AX = UInt16[DS, 0x2];
    // AND AX,0xf (1000_1AE3 / 0x11AE3)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    // RET  (1000_1AE6 / 0x11AE6)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1AE7_011AE7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B0C: goto label_1000_1B0C_11B0C;break; // Target of external jump from 0x11B04, 0x11B17, 0x11AF7, 0x11B28, 0x11AEE
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_1AE7_11AE7:
    // CALL 0x1000:d41b (1000_1AE7 / 0x11AE7)
    NearCall(cs1, 0x1AEA, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_1AEA_11AEA:
    // CMP BP,0x1f7e (1000_1AEA / 0x11AEA)
    Alu.Sub16(BP, 0x1F7E);
    // JNZ 0x1000:1b0c (1000_1AEE / 0x11AEE)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // MOV AX,[0xce7a] (1000_1AF0 / 0x11AF0)
    AX = UInt16[DS, 0xCE7A];
    // CMP AX,word ptr [0x4770] (1000_1AF3 / 0x11AF3)
    Alu.Sub16(AX, UInt16[DS, 0x4770]);
    // JZ 0x1000:1b0c (1000_1AF7 / 0x11AF7)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // MOV [0x4770],AX (1000_1AF9 / 0x11AF9)
    UInt16[DS, 0x4770] = AX;
    // SUB AX,word ptr [0x476e] (1000_1AFC / 0x11AFC)
    AX -= UInt16[DS, 0x476E];
    
    // CMP AX,word ptr [0x4772] (1000_1B00 / 0x11B00)
    Alu.Sub16(AX, UInt16[DS, 0x4772]);
    // JC 0x1000:1b0c (1000_1B04 / 0x11B04)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // CALL 0x1000:c85b (1000_1B06 / 0x11B06)
    NearCall(cs1, 0x1B09, spice86_generated_label_call_target_1000_C85B_01C85B);
    // CALL 0x1000:c868 (1000_1B09 / 0x11B09)
    throw FailAsUntested("Could not find a valid function at address 1000_C868 / 0x1C868");
    label_1000_1B0C_11B0C:
    // RET  (1000_1B0C / 0x11B0C)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1B0D_011B0D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1B0D_11B0D:
    // CALL 0x1000:abcc (1000_1B0D / 0x11B0D)
    NearCall(cs1, 0x1B10, spice86_generated_label_call_target_1000_ABCC_01ABCC);
    label_1000_1B10_11B10:
    // JNZ 0x1000:1b0c (1000_1B10 / 0x11B10)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // CMP byte ptr [0x2788],0x0 (1000_1B12 / 0x11B12)
    Alu.Sub8(UInt8[DS, 0x2788], 0x0);
    // JNZ 0x1000:1b0c (1000_1B17 / 0x11B17)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // CMP byte ptr [0x2a],0xc8 (1000_1B19 / 0x11B19)
    Alu.Sub8(UInt8[DS, 0x2A], 0xC8);
    // JNC 0x1000:1b0c (1000_1B1E / 0x11B1E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // CALL 0x1000:2b2a (1000_1B20 / 0x11B20)
    NearCall(cs1, 0x1B23, spice86_generated_label_call_target_1000_2B2A_012B2A);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1B23_011B23, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_ret_target_1000_1B23_011B23(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1B23_11B23:
    // CMP byte ptr [0x46dd],0x0 (1000_1B23 / 0x11B23)
    Alu.Sub8(UInt8[DS, 0x46DD], 0x0);
    // JZ 0x1000:1b0c (1000_1B28 / 0x11B28)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1B0C / 0x11B0C)
      return NearRet();
    }
    // MOV byte ptr [0x46dd],0x0 (1000_1B2A / 0x11B2A)
    UInt8[DS, 0x46DD] = 0x0;
    // MOV AL,[0xf4] (1000_1B2F / 0x11B2F)
    AL = UInt8[DS, 0xF4];
    // DEC AL (1000_1B32 / 0x11B32)
    AL = Alu.Dec8(AL);
    // CMP AL,0x10 (1000_1B34 / 0x11B34)
    Alu.Sub8(AL, 0x10);
    // JGE 0x1000:1b3d (1000_1B36 / 0x11B36)
    if(SignFlag == OverflowFlag) {
      goto label_1000_1B3D_11B3D;
    }
    // XOR AL,AL (1000_1B38 / 0x11B38)
    AL = 0;
    // MOV [0xf5],AL (1000_1B3A / 0x11B3A)
    UInt8[DS, 0xF5] = AL;
    label_1000_1B3D_11B3D:
    // MOV [0xf4],AL (1000_1B3D / 0x11B3D)
    UInt8[DS, 0xF4] = AL;
    // CALL 0x1000:1a0f (1000_1B40 / 0x11B40)
    NearCall(cs1, 0x1B43, spice86_generated_label_call_target_1000_1A0F_011A0F);
    label_1000_1B43_11B43:
    // CALL 0x1000:38e1 (1000_1B43 / 0x11B43)
    NearCall(cs1, 0x1B46, spice86_generated_label_call_target_1000_38E1_0138E1);
    label_1000_1B46_11B46:
    // MOV AX,[0x2] (1000_1B46 / 0x11B46)
    AX = UInt16[DS, 0x2];
    // MOV CX,AX (1000_1B49 / 0x11B49)
    CX = AX;
    // XCHG word ptr [0x1174],AX (1000_1B4B / 0x11B4B)
    ushort tmp_1000_1B4B = UInt16[DS, 0x1174];
    UInt16[DS, 0x1174] = AX;
    AX = tmp_1000_1B4B;
    // AND AL,0xf0 (1000_1B4F / 0x11B4F)
    AL &= 0xF0;
    
    // AND CL,0xf0 (1000_1B51 / 0x11B51)
    CL &= 0xF0;
    
    // SUB AL,CL (1000_1B54 / 0x11B54)
    // AL -= CL;
    AL = Alu.Sub8(AL, CL);
    // MOV [0x46de],AL (1000_1B56 / 0x11B56)
    UInt8[DS, 0x46DE] = AL;
    // JZ 0x1000:1b5e (1000_1B59 / 0x11B59)
    if(ZeroFlag) {
      goto label_1000_1B5E_11B5E;
    }
    // CALL 0x1000:1c46 (1000_1B5B / 0x11B5B)
    NearCall(cs1, 0x1B5E, spice86_generated_label_call_target_1000_1C46_011C46);
    label_1000_1B5E_11B5E:
    // CMP byte ptr [0xc2],0x7 (1000_1B5E / 0x11B5E)
    Alu.Sub8(UInt8[DS, 0xC2], 0x7);
    // JNC 0x1000:1bb2 (1000_1B63 / 0x11B63)
    if(!CarryFlag) {
      goto label_1000_1BB2_11BB2;
    }
    // CALL 0x1000:1d9f (1000_1B65 / 0x11B65)
    NearCall(cs1, 0x1B68, spice86_generated_label_call_target_1000_1D9F_011D9F);
    label_1000_1B68_11B68:
    // PUSH word ptr [0x11f7] (1000_1B68 / 0x11B68)
    Stack.Push(UInt16[DS, 0x11F7]);
    // PUSH word ptr [0x11ce] (1000_1B6C / 0x11B6C)
    Stack.Push(UInt16[DS, 0x11CE]);
    // CALL 0x1000:6c6f (1000_1B70 / 0x11B70)
    NearCall(cs1, 0x1B73, spice86_generated_label_call_target_1000_6C6F_016C6F);
    label_1000_1B73_11B73:
    // CALL 0x1000:63f0 (1000_1B73 / 0x11B73)
    NearCall(cs1, 0x1B76, spice86_generated_label_call_target_1000_63F0_0163F0);
    label_1000_1B76_11B76:
    // CALL 0x1000:1ae0 (1000_1B76 / 0x11B76)
    NearCall(cs1, 0x1B79, spice86_generated_label_call_target_1000_1AE0_011AE0);
    label_1000_1B79_11B79:
    // SHL AX,0x1 (1000_1B79 / 0x11B79)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV SI,AX (1000_1B7B / 0x11B7B)
    SI = AX;
    // CALL word ptr CS:[SI + 0x1db3] (1000_1B7D / 0x11B7D)
    // Indirect call to word ptr CS:[SI + 0x1db3], generating possible targets from emulator records
    uint targetAddress_1000_1B7D = (uint)(UInt16[cs1, (ushort)(SI + 0x1DB3)]);
    switch(targetAddress_1000_1B7D) {
      case 0x1DD4 : throw FailAsUntested("Could not find a valid function at address 1000_1DD4 / 0x11DD4");
      case 0x1DD7 : throw FailAsUntested("Could not find a valid function at address 1000_1DD7 / 0x11DD7");
      case 0x1DD3 : NearCall(cs1, 0x1B82, spice86_generated_label_call_target_1000_1DD3_011DD3); break;
      case 0x1DDA : NearCall(cs1, 0x1B82, spice86_generated_label_call_target_1000_1DDA_011DDA); break;
      case 0x1DFE : NearCall(cs1, 0x1B82, spice86_generated_label_call_target_1000_1DFE_011DFE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_1B7D));
        break;
    }
    label_1000_1B82_11B82:
    // CALL 0x1000:1c18 (1000_1B82 / 0x11B82)
    NearCall(cs1, 0x1B85, spice86_generated_label_call_target_1000_1C18_011C18);
    label_1000_1B85_11B85:
    // POP DI (1000_1B85 / 0x11B85)
    DI = Stack.Pop();
    // CALL 0x1000:331e (1000_1B86 / 0x11B86)
    NearCall(cs1, 0x1B89, spice86_generated_label_call_target_1000_331E_01331E);
    label_1000_1B89_11B89:
    // POP word ptr [0x11f7] (1000_1B89 / 0x11B89)
    UInt16[DS, 0x11F7] = Stack.Pop();
    // CALL 0x1000:1bec (1000_1B8D / 0x11B8D)
    NearCall(cs1, 0x1B90, spice86_generated_label_call_target_1000_1BEC_011BEC);
    label_1000_1B90_11B90:
    // CMP byte ptr [0x46d9],0x0 (1000_1B90 / 0x11B90)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JNZ 0x1000:1bb2 (1000_1B95 / 0x11B95)
    if(!ZeroFlag) {
      goto label_1000_1BB2_11BB2;
    }
    // CMP byte ptr [0x46ec],0x0 (1000_1B97 / 0x11B97)
    Alu.Sub8(UInt8[DS, 0x46EC], 0x0);
    // JZ 0x1000:1ba1 (1000_1B9C / 0x11B9C)
    if(ZeroFlag) {
      goto label_1000_1BA1_11BA1;
    }
    // CALL 0x1000:5d6d (1000_1B9E / 0x11B9E)
    NearCall(cs1, 0x1BA1, split_1000_5D6D_015D6D);
    label_1000_1BA1_11BA1:
    // MOV DI,word ptr [0x114e] (1000_1BA1 / 0x11BA1)
    DI = UInt16[DS, 0x114E];
    // OR DI,DI (1000_1BA5 / 0x11BA5)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:1bb2 (1000_1BA7 / 0x11BA7)
    if(ZeroFlag) {
      goto label_1000_1BB2_11BB2;
    }
    // CMP byte ptr [0x473b],0x0 (1000_1BA9 / 0x11BA9)
    Alu.Sub8(UInt8[DS, 0x473B], 0x0);
    // JS 0x1000:1bd2 (1000_1BAE / 0x11BAE)
    if(SignFlag) {
      goto label_1000_1BD2_11BD2;
    }
    // JA 0x1000:1bb8 (1000_1BB0 / 0x11BB0)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_1BB8_11BB8;
    }
    label_1000_1BB2_11BB2:
    // MOV byte ptr [0x473b],0x0 (1000_1BB2 / 0x11BB2)
    UInt8[DS, 0x473B] = 0x0;
    // RET  (1000_1BB7 / 0x11BB7)
    return NearRet();
    label_1000_1BB8_11BB8:
    // CMP byte ptr [0xfb],0x0 (1000_1BB8 / 0x11BB8)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:1bb2 (1000_1BBD / 0x11BBD)
    if(SignFlag) {
      goto label_1000_1BB2_11BB2;
    }
    // CMP byte ptr [0x46da],0x0 (1000_1BBF / 0x11BBF)
    Alu.Sub8(UInt8[DS, 0x46DA], 0x0);
    // JNZ 0x1000:1bb2 (1000_1BC4 / 0x11BC4)
    if(!ZeroFlag) {
      goto label_1000_1BB2_11BB2;
    }
    // CALL 0x1000:dbb2 (1000_1BC6 / 0x11BC6)
    NearCall(cs1, 0x1BC9, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:1bb2 (1000_1BC9 / 0x11BC9)
    throw FailAsUntested("Could not find a valid function at address 1000_1BB2 / 0x11BB2");
    // CALL 0x1000:0b21 (1000_1BCC / 0x11BCC)
    NearCall(cs1, 0x1BCF, spice86_generated_label_call_target_1000_0B21_010B21);
    // JMP 0x1000:2db1 (1000_1BCF / 0x11BCF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2DB1_012DB1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1BD2_11BD2:
    // CALL 0x1000:1bb2 (1000_1BD2 / 0x11BD2)
    throw FailAsUntested("Could not find a valid function at address 1000_1BB2 / 0x11BB2");
    // CMP byte ptr [0xfb],0x0 (1000_1BD5 / 0x11BD5)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:1be9 (1000_1BDA / 0x11BDA)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:5d6d (1000_1BE9 / 0x11BE9)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_5D6D_015D6D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x46da],0x0 (1000_1BDC / 0x11BDC)
    Alu.Sub8(UInt8[DS, 0x46DA], 0x0);
    // JNZ 0x1000:1bb2 (1000_1BE1 / 0x11BE1)
    if(!ZeroFlag) {
      goto label_1000_1BB2_11BB2;
    }
    // CALL 0x1000:d2bd (1000_1BE3 / 0x11BE3)
    NearCall(cs1, 0x1BE6, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // JMP 0x1000:0fa7 (1000_1BE6 / 0x11BE6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_0FA7_010FA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1BE9_11BE9:
    // JMP 0x1000:5d6d (1000_1BE9 / 0x11BE9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D6D_015D6D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_1BEC_011BEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1BEC_11BEC:
    // CMP byte ptr [0x2b],0x0 (1000_1BEC / 0x11BEC)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JZ 0x1000:1c17 (1000_1BF1 / 0x11BF1)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1C17 / 0x11C17)
      return NearRet();
    }
    // MOV DI,word ptr [0x114e] (1000_1BF3 / 0x11BF3)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:503c (1000_1BF7 / 0x11BF7)
    NearCall(cs1, 0x1BFA, spice86_generated_label_call_target_1000_503C_01503C);
    // CMP byte ptr [0x46d9],0x0 (1000_1BFA / 0x11BFA)
    Alu.Sub8(UInt8[DS, 0x46D9], 0x0);
    // JZ 0x1000:1c06 (1000_1BFF / 0x11BFF)
    if(ZeroFlag) {
      goto label_1000_1C06_11C06;
    }
    // MOV byte ptr [0x46d9],0x6 (1000_1C01 / 0x11C01)
    UInt8[DS, 0x46D9] = 0x6;
    label_1000_1C06_11C06:
    // CMP byte ptr [0x2b],0x0 (1000_1C06 / 0x11C06)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:1c17 (1000_1C0B / 0x11C0B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1C17 / 0x11C17)
      return NearRet();
    }
    // PUSH DI (1000_1C0D / 0x11C0D)
    Stack.Push(DI);
    // CALL 0x1000:0b21 (1000_1C0E / 0x11C0E)
    NearCall(cs1, 0x1C11, spice86_generated_label_call_target_1000_0B21_010B21);
    // POP DI (1000_1C11 / 0x11C11)
    DI = Stack.Pop();
    // OR byte ptr [0x473b],0x1 (1000_1C12 / 0x11C12)
    // UInt8[DS, 0x473B] |= 0x1;
    UInt8[DS, 0x473B] = Alu.Or8(UInt8[DS, 0x473B], 0x1);
    label_1000_1C17_11C17:
    // RET  (1000_1C17 / 0x11C17)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1C18_011C18(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1C18_11C18:
    // CMP byte ptr [0x46eb],0x0 (1000_1C18 / 0x11C18)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:1c39 (1000_1C1D / 0x11C1D)
    if(!SignFlag) {
      goto label_1000_1C39_11C39;
    }
    // CALL 0x1000:c13b (1000_1C1F / 0x11C1F)
    NearCall(cs1, 0x1C22, spice86_generated_label_call_target_1000_C13B_01C13B);
    // MOV SI,word ptr [0x46fa] (1000_1C22 / 0x11C22)
    SI = UInt16[DS, 0x46FA];
    // OR SI,SI (1000_1C26 / 0x11C26)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:1c2d (1000_1C28 / 0x11C28)
    if(ZeroFlag) {
      goto label_1000_1C2D_11C2D;
    }
    // CALL 0x1000:78e9 (1000_1C2A / 0x11C2A)
    throw FailAsUntested("Could not find a valid function at address 1000_78E9 / 0x178E9");
    label_1000_1C2D_11C2D:
    // MOV DI,word ptr [0x46f8] (1000_1C2D / 0x11C2D)
    DI = UInt16[DS, 0x46F8];
    // OR DI,DI (1000_1C31 / 0x11C31)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:1c38 (1000_1C33 / 0x11C33)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1C38 / 0x11C38)
      return NearRet();
    }
    // CALL 0x1000:600e (1000_1C35 / 0x11C35)
    throw FailAsUntested("Could not find a valid function at address 1000_600E / 0x1600E");
    label_1000_1C38_11C38:
    // RET  (1000_1C38 / 0x11C38)
    return NearRet();
    label_1000_1C39_11C39:
    // JNZ 0x1000:1c45 (1000_1C39 / 0x11C39)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1C45 / 0x11C45)
      return NearRet();
    }
    // CMP byte ptr [0xfb],0x0 (1000_1C3B / 0x11C3B)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JNS 0x1000:1c45 (1000_1C40 / 0x11C40)
    if(!SignFlag) {
      // JNS target is RET, inlining.
      // RET  (1000_1C45 / 0x11C45)
      return NearRet();
    }
    // CALL 0x1000:bdbb (1000_1C42 / 0x11C42)
    throw FailAsUntested("Could not find a valid function at address 1000_BDBB / 0x1BDBB");
    label_1000_1C45_11C45:
    // RET  (1000_1C45 / 0x11C45)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1C46_011C46(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1C46_11C46:
    // MOV AL,[0x2a] (1000_1C46 / 0x11C46)
    AL = UInt8[DS, 0x2A];
    // MOV AH,AL (1000_1C49 / 0x11C49)
    AH = AL;
    // XCHG byte ptr [0xfe],AL (1000_1C4B / 0x11C4B)
    byte tmp_1000_1C4B = UInt8[DS, 0xFE];
    UInt8[DS, 0xFE] = AL;
    AL = tmp_1000_1C4B;
    // CMP AL,AH (1000_1C4F / 0x11C4F)
    Alu.Sub8(AL, AH);
    // JZ 0x1000:1c58 (1000_1C51 / 0x11C51)
    if(ZeroFlag) {
      goto label_1000_1C58_11C58;
    }
    // MOV byte ptr [0xff],0x0 (1000_1C53 / 0x11C53)
    UInt8[DS, 0xFF] = 0x0;
    label_1000_1C58_11C58:
    // INC byte ptr [0xff] (1000_1C58 / 0x11C58)
    UInt8[DS, 0xFF] = Alu.Inc8(UInt8[DS, 0xFF]);
    // CALL 0x1000:1d66 (1000_1C5C / 0x11C5C)
    NearCall(cs1, 0x1C5F, spice86_generated_label_call_target_1000_1D66_011D66);
    label_1000_1C5F_11C5F:
    // CALL 0x1000:1e43 (1000_1C5F / 0x11C5F)
    NearCall(cs1, 0x1C62, spice86_generated_label_call_target_1000_1E43_011E43);
    label_1000_1C62_11C62:
    // MOV AL,[0xd5] (1000_1C62 / 0x11C62)
    AL = UInt8[DS, 0xD5];
    // INC AL (1000_1C65 / 0x11C65)
    AL = Alu.Inc8(AL);
    // CMP AL,0x2 (1000_1C67 / 0x11C67)
    Alu.Sub8(AL, 0x2);
    // JC 0x1000:1c6e (1000_1C69 / 0x11C69)
    if(CarryFlag) {
      goto label_1000_1C6E_11C6E;
    }
    // MOV [0xd5],AL (1000_1C6B / 0x11C6B)
    UInt8[DS, 0xD5] = AL;
    label_1000_1C6E_11C6E:
    // XOR AX,AX (1000_1C6E / 0x11C6E)
    AX = 0;
    // XCHG word ptr [0x1172],AX (1000_1C70 / 0x11C70)
    ushort tmp_1000_1C70 = UInt16[DS, 0x1172];
    UInt16[DS, 0x1172] = AX;
    AX = tmp_1000_1C70;
    // MOV BX,word ptr [0xa0] (1000_1C74 / 0x11C74)
    BX = UInt16[DS, 0xA0];
    // ADD AX,BX (1000_1C78 / 0x11C78)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    // XCHG word ptr [0x1170],BX (1000_1C7A / 0x11C7A)
    ushort tmp_1000_1C7A = UInt16[DS, 0x1170];
    UInt16[DS, 0x1170] = BX;
    BX = tmp_1000_1C7A;
    // SUB AX,BX (1000_1C7E / 0x11C7E)
    // AX -= BX;
    AX = Alu.Sub16(AX, BX);
    // JNC 0x1000:1c84 (1000_1C80 / 0x11C80)
    if(!CarryFlag) {
      goto label_1000_1C84_11C84;
    }
    // XOR AX,AX (1000_1C82 / 0x11C82)
    AX = 0;
    label_1000_1C84_11C84:
    // MOV [0xa6],AX (1000_1C84 / 0x11C84)
    UInt16[DS, 0xA6] = AX;
    // XCHG word ptr [0xae],AX (1000_1C87 / 0x11C87)
    ushort tmp_1000_1C87 = UInt16[DS, 0xAE];
    UInt16[DS, 0xAE] = AX;
    AX = tmp_1000_1C87;
    // XOR BX,BX (1000_1C8B / 0x11C8B)
    BX = 0;
    // SUB AX,word ptr [0xa6] (1000_1C8D / 0x11C8D)
    // AX -= UInt16[DS, 0xA6];
    AX = Alu.Sub16(AX, UInt16[DS, 0xA6]);
    // JNC 0x1000:1c96 (1000_1C91 / 0x11C91)
    if(!CarryFlag) {
      goto label_1000_1C96_11C96;
    }
    // NEG AX (1000_1C93 / 0x11C93)
    AX = Alu.Sub16(0, AX);
    // XCHG AX,BX (1000_1C95 / 0x11C95)
    ushort tmp_1000_1C95 = AX;
    AX = BX;
    BX = tmp_1000_1C95;
    label_1000_1C96_11C96:
    // MOV [0xb2],AX (1000_1C96 / 0x11C96)
    UInt16[DS, 0xB2] = AX;
    // MOV word ptr [0xb0],BX (1000_1C99 / 0x11C99)
    UInt16[DS, 0xB0] = BX;
    // CALL 0x1000:1cda (1000_1C9D / 0x11C9D)
    NearCall(cs1, 0x1CA0, spice86_generated_label_call_target_1000_1CDA_011CDA);
    label_1000_1CA0_11CA0:
    // CALL 0x1000:c02e (1000_1CA0 / 0x11CA0)
    NearCall(cs1, 0x1CA3, spice86_generated_label_call_target_1000_C02E_01C02E);
    label_1000_1CA3_11CA3:
    // CALL 0x1000:bf26 (1000_1CA3 / 0x11CA3)
    NearCall(cs1, 0x1CA6, spice86_generated_label_call_target_1000_BF26_01BF26);
    label_1000_1CA6_11CA6:
    // CALL 0x1000:e3cc (1000_1CA6 / 0x11CA6)
    NearCall(cs1, 0x1CA9, spice86_generated_label_call_target_1000_E3CC_01E3CC);
    label_1000_1CA9_11CA9:
    // MOV BX,AX (1000_1CA9 / 0x11CA9)
    BX = AX;
    // MOV SI,0x10d8 (1000_1CAB / 0x11CAB)
    SI = 0x10D8;
    label_1000_1CAE_11CAE:
    // TEST byte ptr [SI + 0x2],0x8 (1000_1CAE / 0x11CAE)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    // JZ 0x1000:1cd1 (1000_1CB2 / 0x11CB2)
    if(ZeroFlag) {
      goto label_1000_1CD1_11CD1;
    }
    // MOV BP,0x4 (1000_1CB4 / 0x11CB4)
    BP = 0x4;
    label_1000_1CB7_11CB7:
    // CMP byte ptr [BP + SI + 0x4],0x0 (1000_1CB7 / 0x11CB7)
    Alu.Sub8(UInt8[SS, (ushort)(BP + SI + 0x4)], 0x0);
    // JNZ 0x1000:1cce (1000_1CBB / 0x11CBB)
    if(!ZeroFlag) {
      goto label_1000_1CCE_11CCE;
    }
    // CMP byte ptr [BP + SI + 0x9],0x0 (1000_1CBD / 0x11CBD)
    Alu.Sub8(UInt8[SS, (ushort)(BP + SI + 0x9)], 0x0);
    // JNS 0x1000:1cce (1000_1CC1 / 0x11CC1)
    if(!SignFlag) {
      goto label_1000_1CCE_11CCE;
    }
    // ROL BX,0x1 (1000_1CC3 / 0x11CC3)
    BX = Alu.Rol16(BX, 0x1);
    // ROL BX,0x1 (1000_1CC5 / 0x11CC5)
    BX = Alu.Rol16(BX, 0x1);
    // MOV AL,BL (1000_1CC7 / 0x11CC7)
    AL = BL;
    // AND AL,0x3 (1000_1CC9 / 0x11CC9)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    // MOV byte ptr [BP + SI + 0x4],AL (1000_1CCB / 0x11CCB)
    UInt8[SS, (ushort)(BP + SI + 0x4)] = AL;
    label_1000_1CCE_11CCE:
    // DEC BP (1000_1CCE / 0x11CCE)
    BP = Alu.Dec16(BP);
    // JNS 0x1000:1cb7 (1000_1CCF / 0x11CCF)
    if(!SignFlag) {
      goto label_1000_1CB7_11CB7;
    }
    label_1000_1CD1_11CD1:
    // ADD SI,0x11 (1000_1CD1 / 0x11CD1)
    SI += 0x11;
    
    // CMP byte ptr [SI],0x14 (1000_1CD4 / 0x11CD4)
    Alu.Sub8(UInt8[DS, SI], 0x14);
    // JC 0x1000:1cae (1000_1CD7 / 0x11CD7)
    if(CarryFlag) {
      goto label_1000_1CAE_11CAE;
    }
    // RET  (1000_1CD9 / 0x11CD9)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1CDA_011CDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1CDA_11CDA:
    // MOV DI,0x100 (1000_1CDA / 0x11CDA)
    DI = 0x100;
    // XOR CX,CX (1000_1CDD / 0x11CDD)
    CX = 0;
    // XOR DX,DX (1000_1CDF / 0x11CDF)
    DX = 0;
    label_1000_1CE1_11CE1:
    // CALL 0x1000:5d36 (1000_1CE1 / 0x11CE1)
    NearCall(cs1, 0x1CE4, spice86_generated_label_call_target_1000_5D36_015D36);
    label_1000_1CE4_11CE4:
    // JC 0x1000:1cf4 (1000_1CE4 / 0x11CE4)
    if(CarryFlag) {
      goto label_1000_1CF4_11CF4;
    }
    // INC DX (1000_1CE6 / 0x11CE6)
    DX = Alu.Inc16(DX);
    // MOV AL,byte ptr [DI + 0x12] (1000_1CE7 / 0x11CE7)
    AL = UInt8[DS, (ushort)(DI + 0x12)];
    // SHR AL,0x1 (1000_1CEA / 0x11CEA)
    AL >>= 0x1;
    
    // SHR AL,0x1 (1000_1CEC / 0x11CEC)
    AL >>= 0x1;
    
    // SHR AL,0x1 (1000_1CEE / 0x11CEE)
    AL >>= 0x1;
    
    // XOR AH,AH (1000_1CF0 / 0x11CF0)
    AH = 0;
    // ADD CX,AX (1000_1CF2 / 0x11CF2)
    CX += AX;
    
    label_1000_1CF4_11CF4:
    // ADD DI,0x1c (1000_1CF4 / 0x11CF4)
    DI += 0x1C;
    
    // CMP byte ptr [DI],0xff (1000_1CF7 / 0x11CF7)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:1ce1 (1000_1CFA / 0x11CFA)
    if(!ZeroFlag) {
      goto label_1000_1CE1_11CE1;
    }
    // MOV BX,CX (1000_1CFC / 0x11CFC)
    BX = CX;
    // SHR BX,0x1 (1000_1CFE / 0x11CFE)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_1D00 / 0x11D00)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_1D02 / 0x11D02)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_1D04 / 0x11D04)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // CALL 0x1000:e3df (1000_1D06 / 0x11D06)
    NearCall(cs1, 0x1D09, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    label_1000_1D09_11D09:
    // ADD CX,AX (1000_1D09 / 0x11D09)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // MOV word ptr [0xa8],CX (1000_1D0B / 0x11D0B)
    UInt16[DS, 0xA8] = CX;
    // RET  (1000_1D0F / 0x11D0F)
    return NearRet();
  }
  
  public Action spice86_generated_label_jump_target_1000_1D10_011D10(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1D10_11D10:
    // ROL word ptr [0x0],0x1 (1000_1D10 / 0x11D10)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // JNC 0x1000:1d34 (1000_1D14 / 0x11D14)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_1D34 / 0x11D34)
      return NearRet();
    }
    // MOV SI,0x8aa (1000_1D16 / 0x11D16)
    SI = 0x8AA;
    label_1000_1D19_11D19:
    // TEST byte ptr [SI + 0x10],0x80 (1000_1D19 / 0x11D19)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JZ 0x1000:1d2b (1000_1D1D / 0x11D1D)
    if(ZeroFlag) {
      goto label_1000_1D2B_11D2B;
    }
    // MOV AL,byte ptr [SI + 0x1a] (1000_1D1F / 0x11D1F)
    AL = UInt8[DS, (ushort)(SI + 0x1A)];
    // DEC AL (1000_1D22 / 0x11D22)
    AL = Alu.Dec8(AL);
    // CMP AL,0xc7 (1000_1D24 / 0x11D24)
    Alu.Sub8(AL, 0xC7);
    // JNC 0x1000:1d2b (1000_1D26 / 0x11D26)
    if(!CarryFlag) {
      goto label_1000_1D2B_11D2B;
    }
    // INC byte ptr [SI + 0x1a] (1000_1D28 / 0x11D28)
    UInt8[DS, (ushort)(SI + 0x1A)] = Alu.Inc8(UInt8[DS, (ushort)(SI + 0x1A)]);
    label_1000_1D2B_11D2B:
    // ADD SI,0x1b (1000_1D2B / 0x11D2B)
    SI += 0x1B;
    
    // CMP SI,0xfa0 (1000_1D2E / 0x11D2E)
    Alu.Sub16(SI, 0xFA0);
    // JC 0x1000:1d19 (1000_1D32 / 0x11D32)
    if(CarryFlag) {
      goto label_1000_1D19_11D19;
    }
    label_1000_1D34_11D34:
    // RET  (1000_1D34 / 0x11D34)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1D66_011D66(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1D66_11D66:
    // MOV SI,0xfd8 (1000_1D66 / 0x11D66)
    SI = 0xFD8;
    // MOV CX,0xc (1000_1D69 / 0x11D69)
    CX = 0xC;
    label_1000_1D6C_11D6C:
    // MOV AX,word ptr [SI + 0x2] (1000_1D6C / 0x11D6C)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // CMP AL,0x80 (1000_1D6F / 0x11D6F)
    Alu.Sub8(AL, 0x80);
    // JNZ 0x1000:1d99 (1000_1D71 / 0x11D71)
    if(!ZeroFlag) {
      goto label_1000_1D99_11D99;
    }
    // CMP AH,0xff (1000_1D73 / 0x11D73)
    Alu.Sub8(AH, 0xFF);
    // JZ 0x1000:1d99 (1000_1D76 / 0x11D76)
    if(ZeroFlag) {
      goto label_1000_1D99_11D99;
    }
    // MOV AL,0x1c (1000_1D78 / 0x11D78)
    AL = 0x1C;
    // MUL AH (1000_1D7A / 0x11D7A)
    Cpu.Mul8(AH);
    // ADD AX,0xe4 (1000_1D7C / 0x11D7C)
    // AX += 0xE4;
    AX = Alu.Add16(AX, 0xE4);
    // MOV DI,AX (1000_1D7F / 0x11D7F)
    DI = AX;
    // MOV AX,word ptr [SI] (1000_1D81 / 0x11D81)
    AX = UInt16[DS, SI];
    // MOV BL,byte ptr [DI + 0x8] (1000_1D83 / 0x11D83)
    BL = UInt8[DS, (ushort)(DI + 0x8)];
    // CMP AH,BL (1000_1D86 / 0x11D86)
    Alu.Sub8(AH, BL);
    // JNZ 0x1000:1d93 (1000_1D88 / 0x11D88)
    if(!ZeroFlag) {
      goto label_1000_1D93_11D93;
    }
    // XOR BH,BH (1000_1D8A / 0x11D8A)
    BH = 0;
    // CMP AL,byte ptr CS:[BX + 0x1d35] (1000_1D8C / 0x11D8C)
    Alu.Sub8(AL, UInt8[cs1, (ushort)(BX + 0x1D35)]);
    // JBE 0x1000:1d99 (1000_1D91 / 0x11D91)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_1D99_11D99;
    }
    label_1000_1D93_11D93:
    // MOV AH,BL (1000_1D93 / 0x11D93)
    AH = BL;
    // MOV AL,0x1 (1000_1D95 / 0x11D95)
    AL = 0x1;
    // MOV word ptr [SI],AX (1000_1D97 / 0x11D97)
    UInt16[DS, SI] = AX;
    label_1000_1D99_11D99:
    // ADD SI,0x10 (1000_1D99 / 0x11D99)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:1d6c (1000_1D9C / 0x11D9C)
    if(--CX != 0) {
      goto label_1000_1D6C_11D6C;
    }
    // RET  (1000_1D9E / 0x11D9E)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1D9F_011D9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1D9F_11D9F:
    // TEST word ptr [0x12],0x80 (1000_1D9F / 0x11D9F)
    Alu.And16(UInt16[DS, 0x12], 0x80);
    // JNZ 0x1000:1db2 (1000_1DA5 / 0x11DA5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1DB2 / 0x11DB2)
      return NearRet();
    }
    // MOV SI,0x1048 (1000_1DA7 / 0x11DA7)
    SI = 0x1048;
    // CALL 0x1000:1e01 (1000_1DAA / 0x11DAA)
    NearCall(cs1, 0x1DAD, spice86_generated_label_call_target_1000_1E01_011E01);
    label_1000_1DAD_11DAD:
    // JNC 0x1000:1db2 (1000_1DAD / 0x11DAD)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_1DB2 / 0x11DB2)
      return NearRet();
    }
    // CALL 0x1000:1eda (1000_1DAF / 0x11DAF)
    throw FailAsUntested("Could not find a valid function at address 1000_1EDA / 0x11EDA");
    label_1000_1DB2_11DB2:
    // RET  (1000_1DB2 / 0x11DB2)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1DD3_011DD3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1DD3_11DD3:
    // RET  (1000_1DD3 / 0x11DD3)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1DDA_011DDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1DDA_11DDA:
    // TEST byte ptr [0xbf],0x10 (1000_1DDA / 0x11DDA)
    Alu.And8(UInt8[DS, 0xBF], 0x10);
    // JZ 0x1000:1dfd (1000_1DDF / 0x11DDF)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1DFD / 0x11DFD)
      return NearRet();
    }
    // TEST word ptr [0x10],0x8 (1000_1DE1 / 0x11DE1)
    Alu.And16(UInt16[DS, 0x10], 0x8);
    // JNZ 0x1000:1dfd (1000_1DE7 / 0x11DE7)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1DFD / 0x11DFD)
      return NearRet();
    }
    // CMP byte ptr [0xb],0x8 (1000_1DE9 / 0x11DE9)
    Alu.Sub8(UInt8[DS, 0xB], 0x8);
    // JZ 0x1000:1dfd (1000_1DEE / 0x11DEE)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1DFD / 0x11DFD)
      return NearRet();
    }
    // CMP byte ptr [0xc2],0x0 (1000_1DF0 / 0x11DF0)
    Alu.Sub8(UInt8[DS, 0xC2], 0x0);
    // JNZ 0x1000:1dfd (1000_1DF5 / 0x11DF5)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1DFD / 0x11DFD)
      return NearRet();
    }
    // MOV AX,0x30b (1000_1DF7 / 0x11DF7)
    AX = 0x30B;
    // CALL 0x1000:29ee (1000_1DFA / 0x11DFA)
    throw FailAsUntested("Could not find a valid function at address 1000_29EE / 0x129EE");
    label_1000_1DFD_11DFD:
    // RET  (1000_1DFD / 0x11DFD)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1DFE_011DFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1DFE_11DFE:
    // JMP 0x1000:1d10 (1000_1DFE / 0x11DFE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_1D10_011D10, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_1E01_011E01(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1E01_11E01:
    // CMP byte ptr [0x2a],0x5d (1000_1E01 / 0x11E01)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5D);
    // JNZ 0x1000:1e3e (1000_1E06 / 0x11E06)
    if(!ZeroFlag) {
      goto label_1000_1E3E_11E3E;
    }
    // CMP byte ptr [SI + 0xe],0x7 (1000_1E08 / 0x11E08)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0xE)], 0x7);
    // JNZ 0x1000:1e3e (1000_1E0C / 0x11E0C)
    if(!ZeroFlag) {
      goto label_1000_1E3E_11E3E;
    }
    // MOV BX,word ptr [SI + 0x2] (1000_1E0E / 0x11E0E)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // CMP BL,0x80 (1000_1E11 / 0x11E11)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:1e3e (1000_1E14 / 0x11E14)
    if(!ZeroFlag) {
      goto label_1000_1E3E_11E3E;
    }
    // MOV byte ptr [SI],0x2 (1000_1E16 / 0x11E16)
    UInt8[DS, SI] = 0x2;
    // JNZ 0x1000:1e3e (1000_1E19 / 0x11E19)
    if(!ZeroFlag) {
      goto label_1000_1E3E_11E3E;
    }
    // MOV AL,0x1c (1000_1E1B / 0x11E1B)
    AL = 0x1C;
    // MUL BH (1000_1E1D / 0x11E1D)
    Cpu.Mul8(BH);
    // ADD AX,0xe4 (1000_1E1F / 0x11E1F)
    // AX += 0xE4;
    AX = Alu.Add16(AX, 0xE4);
    // MOV DI,AX (1000_1E22 / 0x11E22)
    DI = AX;
    label_1000_1E24_11E24:
    // MOV AL,byte ptr [DI + 0x9] (1000_1E24 / 0x11E24)
    AL = UInt8[DS, (ushort)(DI + 0x9)];
    // OR AL,AL (1000_1E27 / 0x11E27)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:1e3e (1000_1E29 / 0x11E29)
    if(ZeroFlag) {
      goto label_1000_1E3E_11E3E;
    }
    // PUSH SI (1000_1E2B / 0x11E2B)
    Stack.Push(SI);
    label_1000_1E2C_11E2C:
    // CALL 0x1000:6906 (1000_1E2C / 0x11E2C)
    NearCall(cs1, 0x1E2F, spice86_generated_label_call_target_1000_6906_016906);
    // TEST word ptr [SI + 0x12],0x400 (1000_1E2F / 0x11E2F)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x400);
    // JNZ 0x1000:1e40 (1000_1E34 / 0x11E34)
    if(!ZeroFlag) {
      goto label_1000_1E40_11E40;
    }
    // MOV AL,byte ptr [SI + 0x1] (1000_1E36 / 0x11E36)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // OR AL,AL (1000_1E39 / 0x11E39)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:1e2c (1000_1E3B / 0x11E3B)
    if(!ZeroFlag) {
      goto label_1000_1E2C_11E2C;
    }
    // POP SI (1000_1E3D / 0x11E3D)
    SI = Stack.Pop();
    label_1000_1E3E_11E3E:
    // CLC  (1000_1E3E / 0x11E3E)
    CarryFlag = false;
    // RET  (1000_1E3F / 0x11E3F)
    return NearRet();
    label_1000_1E40_11E40:
    // POP SI (1000_1E40 / 0x11E40)
    SI = Stack.Pop();
    // STC  (1000_1E41 / 0x11E41)
    CarryFlag = true;
    // RET  (1000_1E42 / 0x11E42)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_1E43_011E43(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1E43_11E43:
    // CALL 0x1000:1ac5 (1000_1E43 / 0x11E43)
    NearCall(cs1, 0x1E46, spice86_generated_label_call_target_1000_1AC5_011AC5);
    label_1000_1E46_11E46:
    // CMP AX,word ptr [0x1156] (1000_1E46 / 0x11E46)
    Alu.Sub16(AX, UInt16[DS, 0x1156]);
    // JC 0x1000:1ea8 (1000_1E4A / 0x11E4A)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_1EA8 / 0x11EA8)
      return NearRet();
    }
    // CMP byte ptr [0x2a],0x5c (1000_1E4C / 0x11E4C)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5C);
    // JNZ 0x1000:1ea8 (1000_1E51 / 0x11E51)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1EA8 / 0x11EA8)
      return NearRet();
    }
    // CMP word ptr [0x114e],0x7c8 (1000_1E53 / 0x11E53)
    Alu.Sub16(UInt16[DS, 0x114E], 0x7C8);
    // JZ 0x1000:1ea8 (1000_1E59 / 0x11E59)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1EA8 / 0x11EA8)
      return NearRet();
    }
    // MOV DI,0x100 (1000_1E5B / 0x11E5B)
    DI = 0x100;
    // XOR CX,CX (1000_1E5E / 0x11E5E)
    CX = 0;
    label_1000_1E60_11E60:
    // CMP byte ptr [DI + 0x8],0x28 (1000_1E60 / 0x11E60)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x28);
    // JNC 0x1000:1e82 (1000_1E64 / 0x11E64)
    if(!CarryFlag) {
      goto label_1000_1E82_11E82;
    }
    // TEST byte ptr [DI + 0xa],0x80 (1000_1E66 / 0x11E66)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x80);
    // JNZ 0x1000:1e82 (1000_1E6A / 0x11E6A)
    if(!ZeroFlag) {
      goto label_1000_1E82_11E82;
    }
    // CMP DI,0x2c0 (1000_1E6C / 0x11E6C)
    Alu.Sub16(DI, 0x2C0);
    // JZ 0x1000:1e82 (1000_1E70 / 0x11E70)
    if(ZeroFlag) {
      goto label_1000_1E82_11E82;
    }
    // XOR DX,DX (1000_1E72 / 0x11E72)
    DX = 0;
    // MOV BP,0x1ea1 (1000_1E74 / 0x11E74)
    BP = 0x1EA1;
    // CALL 0x1000:661d (1000_1E77 / 0x11E77)
    throw FailAsUntested("Could not find a valid function at address 1000_661D / 0x1661D");
    // CMP DX,CX (1000_1E7A / 0x11E7A)
    Alu.Sub16(DX, CX);
    // JBE 0x1000:1e82 (1000_1E7C / 0x11E7C)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_1E82_11E82;
    }
    // MOV CX,DX (1000_1E7E / 0x11E7E)
    CX = DX;
    // MOV BX,DI (1000_1E80 / 0x11E80)
    BX = DI;
    label_1000_1E82_11E82:
    // ADD DI,0x1c (1000_1E82 / 0x11E82)
    DI += 0x1C;
    
    // CMP byte ptr [DI],0xff (1000_1E85 / 0x11E85)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:1e60 (1000_1E88 / 0x11E88)
    if(!ZeroFlag) {
      goto label_1000_1E60_11E60;
    }
    // JCXZ 0x1000:1ea8 (1000_1E8A / 0x11E8A)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_1EA8 / 0x11EA8)
      return NearRet();
    }
    // MOV DI,BX (1000_1E8C / 0x11E8C)
    DI = BX;
    // MOV word ptr [0x11db],DI (1000_1E8E / 0x11E8E)
    UInt16[DS, 0x11DB] = DI;
    // INC byte ptr [0xf8] (1000_1E92 / 0x11E92)
    UInt8[DS, 0xF8] = Alu.Inc8(UInt8[DS, 0xF8]);
    // MOV BP,0x1ea9 (1000_1E96 / 0x11E96)
    BP = 0x1EA9;
    // CALL 0x1000:661d (1000_1E99 / 0x11E99)
    throw FailAsUntested("Could not find a valid function at address 1000_661D / 0x1661D");
    // MOV AL,0x8 (1000_1E9C / 0x11E9C)
    AL = 0x8;
    // JMP 0x1000:71b2 (1000_1E9E / 0x11E9E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_1EA8_011EA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1EA8_11EA8:
    // RET  (1000_1EA8 / 0x11EA8)
    return NearRet();
  }
  
  public Action spice86_generated_label_jump_target_1000_1F64_011F64(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1F64_11F64:
    // CMP byte ptr [0x2a],0x3c (1000_1F64 / 0x11F64)
    Alu.Sub8(UInt8[DS, 0x2A], 0x3C);
    // JNC 0x1000:1f79 (1000_1F69 / 0x11F69)
    if(!CarryFlag) {
      goto label_1000_1F79_11F79;
    }
    // MOV AX,[0x2] (1000_1F6B / 0x11F6B)
    AX = UInt16[DS, 0x2];
    // SUB AX,word ptr [0x1154] (1000_1F6E / 0x11F6E)
    // AX -= UInt16[DS, 0x1154];
    AX = Alu.Sub16(AX, UInt16[DS, 0x1154]);
    // JC 0x1000:1f91 (1000_1F72 / 0x11F72)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_1F91 / 0x11F91)
      return NearRet();
    }
    // CMP AX,0x70 (1000_1F74 / 0x11F74)
    Alu.Sub16(AX, 0x70);
    // JC 0x1000:1f91 (1000_1F77 / 0x11F77)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_1F91 / 0x11F91)
      return NearRet();
    }
    label_1000_1F79_11F79:
    // TEST word ptr [0x2],0x10 (1000_1F79 / 0x11F79)
    Alu.And16(UInt16[DS, 0x2], 0x10);
    // JNZ 0x1000:1f91 (1000_1F7F / 0x11F7F)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1F91 / 0x11F91)
      return NearRet();
    }
    // XOR AL,AL (1000_1F81 / 0x11F81)
    AL = 0;
    // XCHG byte ptr [0x11bc],AL (1000_1F83 / 0x11F83)
    byte tmp_1000_1F83 = UInt8[DS, 0x11BC];
    UInt8[DS, 0x11BC] = AL;
    AL = tmp_1000_1F83;
    // OR AL,AL (1000_1F87 / 0x11F87)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:1f91 (1000_1F89 / 0x11F89)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1F91 / 0x11F91)
      return NearRet();
    }
    // ROL word ptr [0x0],0x1 (1000_1F8B / 0x11F8B)
    UInt16[DS, 0x0] = Alu.Rol16(UInt16[DS, 0x0], 0x1);
    // JC 0x1000:1f92 (1000_1F8F / 0x11F8F)
    if(CarryFlag) {
      goto label_1000_1F92_11F92;
    }
    label_1000_1F91_11F91:
    // RET  (1000_1F91 / 0x11F91)
    return NearRet();
    label_1000_1F92_11F92:
    // CALL 0x1000:2017 (1000_1F92 / 0x11F92)
    throw FailAsUntested("Could not find a valid function at address 1000_2017 / 0x12017");
    // JZ 0x1000:2013 (1000_1F95 / 0x11F95)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_2013 / 0x12013)
      return NearRet();
    }
    // INC byte ptr [0xc4] (1000_1F97 / 0x11F97)
    UInt8[DS, 0xC4] = Alu.Inc8(UInt8[DS, 0xC4]);
    // MOV CX,0x2 (1000_1F9B / 0x11F9B)
    CX = 0x2;
    label_1000_1F9E_11F9E:
    // MOV AL,byte ptr [BP + 0x9] (1000_1F9E / 0x11F9E)
    AL = UInt8[SS, (ushort)(BP + 0x9)];
    label_1000_1FA1_11FA1:
    // OR AL,AL (1000_1FA1 / 0x11FA1)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:1fcb (1000_1FA3 / 0x11FA3)
    if(ZeroFlag) {
      goto label_1000_1FCB_11FCB;
    }
    // CALL 0x1000:6906 (1000_1FA5 / 0x11FA5)
    NearCall(cs1, 0x1FA8, spice86_generated_label_call_target_1000_6906_016906);
    // MOV AL,byte ptr [SI + 0x1] (1000_1FA8 / 0x11FA8)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // TEST byte ptr [SI + 0x10],0x80 (1000_1FAB / 0x11FAB)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0x80);
    // JZ 0x1000:1fa1 (1000_1FAF / 0x11FAF)
    if(ZeroFlag) {
      goto label_1000_1FA1_11FA1;
    }
    // PUSH CX (1000_1FB1 / 0x11FB1)
    Stack.Push(CX);
    // PUSH BP (1000_1FB2 / 0x11FB2)
    Stack.Push(BP);
    // PUSH SI (1000_1FB3 / 0x11FB3)
    Stack.Push(SI);
    // PUSH DI (1000_1FB4 / 0x11FB4)
    Stack.Push(DI);
    // MOV byte ptr [SI + 0x3],0x8d (1000_1FB5 / 0x11FB5)
    UInt8[DS, (ushort)(SI + 0x3)] = 0x8D;
    // CALL 0x1000:84a6 (1000_1FB9 / 0x11FB9)
    throw FailAsUntested("Could not find a valid function at address 1000_84A6 / 0x184A6");
    // POP DI (1000_1FBC / 0x11FBC)
    DI = Stack.Pop();
    // POP SI (1000_1FBD / 0x11FBD)
    SI = Stack.Pop();
    // AND byte ptr [SI + 0x10],0xef (1000_1FBE / 0x11FBE)
    // UInt8[DS, (ushort)(SI + 0x10)] &= 0xEF;
    UInt8[DS, (ushort)(SI + 0x10)] = Alu.And8(UInt8[DS, (ushort)(SI + 0x10)], 0xEF);
    // PUSH DI (1000_1FC2 / 0x11FC2)
    Stack.Push(DI);
    // CALL 0x1000:8357 (1000_1FC3 / 0x11FC3)
    throw FailAsUntested("Could not find a valid function at address 1000_8357 / 0x18357");
    // POP DI (1000_1FC6 / 0x11FC6)
    DI = Stack.Pop();
    // POP BP (1000_1FC7 / 0x11FC7)
    BP = Stack.Pop();
    // POP CX (1000_1FC8 / 0x11FC8)
    CX = Stack.Pop();
    // LOOP 0x1000:1f9e (1000_1FC9 / 0x11FC9)
    if(--CX != 0) {
      goto label_1000_1F9E_11F9E;
    }
    label_1000_1FCB_11FCB:
    // OR byte ptr [DI + 0xa],0x2 (1000_1FCB / 0x11FCB)
    // UInt8[DS, (ushort)(DI + 0xA)] |= 0x2;
    UInt8[DS, (ushort)(DI + 0xA)] = Alu.Or8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // CALL 0x1000:83fd (1000_1FCF / 0x11FCF)
    throw FailAsUntested("Could not find a valid function at address 1000_83FD / 0x183FD");
    // CALL 0x1000:40ae (1000_1FD2 / 0x11FD2)
    NearCall(cs1, 0x1FD5, spice86_generated_label_call_target_1000_40AE_0140AE);
    // MOV SI,0xfd8 (1000_1FD5 / 0x11FD5)
    SI = 0xFD8;
    // MOV CX,0x9 (1000_1FD8 / 0x11FD8)
    CX = 0x9;
    label_1000_1FDB_11FDB:
    // CMP BX,word ptr [SI + 0x2] (1000_1FDB / 0x11FDB)
    Alu.Sub16(BX, UInt16[DS, (ushort)(SI + 0x2)]);
    // JNZ 0x1000:1fe2 (1000_1FDE / 0x11FDE)
    if(!ZeroFlag) {
      goto label_1000_1FE2_11FE2;
    }
    // MOV word ptr [SI],DX (1000_1FE0 / 0x11FE0)
    UInt16[DS, SI] = DX;
    label_1000_1FE2_11FE2:
    // ADD SI,0x10 (1000_1FE2 / 0x11FE2)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:1fdb (1000_1FE5 / 0x11FE5)
    if(--CX != 0) {
      goto label_1000_1FDB_11FDB;
    }
    // MOV AL,0xc (1000_1FE7 / 0x11FE7)
    AL = 0xC;
    // MOV SI,0x8e0 (1000_1FE9 / 0x11FE9)
    SI = 0x8E0;
    // CMP DI,word ptr [SI + 0x4] (1000_1FEC / 0x11FEC)
    Alu.Sub16(DI, UInt16[DS, (ushort)(SI + 0x4)]);
    // JNZ 0x1000:1ff3 (1000_1FEF / 0x11FEF)
    if(!ZeroFlag) {
      goto label_1000_1FF3_11FF3;
    }
    // INC AL (1000_1FF1 / 0x11FF1)
    AL = Alu.Inc8(AL);
    label_1000_1FF3_11FF3:
    // PUSH BX (1000_1FF3 / 0x11FF3)
    Stack.Push(BX);
    // PUSH DX (1000_1FF4 / 0x11FF4)
    Stack.Push(DX);
    // CALL 0x1000:71b2 (1000_1FF5 / 0x11FF5)
    NearCall(cs1, 0x1FF8, split_1000_71B2_0171B2);
    // POP DX (1000_1FF8 / 0x11FF8)
    DX = Stack.Pop();
    // POP BX (1000_1FF9 / 0x11FF9)
    BX = Stack.Pop();
    // CMP BX,word ptr [0x6] (1000_1FFA / 0x11FFA)
    Alu.Sub16(BX, UInt16[DS, 0x6]);
    // JNZ 0x1000:2014 (1000_1FFE / 0x11FFE)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:5d50 (1000_2014 / 0x12014)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_5D50_015D50, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV word ptr [0x4],DX (1000_2000 / 0x12000)
    UInt16[DS, 0x4] = DX;
    // MOV AL,DL (1000_2004 / 0x12004)
    AL = DL;
    // MOV [0xb],AL (1000_2006 / 0x12006)
    UInt8[DS, 0xB] = AL;
    // OR byte ptr [0x473b],AL (1000_2009 / 0x12009)
    // UInt8[DS, 0x473B] |= AL;
    UInt8[DS, 0x473B] = Alu.Or8(UInt8[DS, 0x473B], AL);
    // MOV [0x2b],AL (1000_200D / 0x1200D)
    UInt8[DS, 0x2B] = AL;
    // CALL 0x1000:6144 (1000_2010 / 0x12010)
    throw FailAsUntested("Could not find a valid function at address 1000_6144 / 0x16144");
    label_1000_2013_12013:
    // RET  (1000_2013 / 0x12013)
    return NearRet();
    label_1000_2014_12014:
    // JMP 0x1000:5d50 (1000_2014 / 0x12014)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_2098_012098(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2098_12098:
    // SUB AX,word ptr [0x118d] (1000_2098 / 0x12098)
    // AX -= UInt16[DS, 0x118D];
    AX = Alu.Sub16(AX, UInt16[DS, 0x118D]);
    // JZ 0x1000:20d1 (1000_209C / 0x1209C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_20D1 / 0x120D1)
      return NearRet();
    }
    // NEG AX (1000_209E / 0x1209E)
    AX = Alu.Sub16(0, AX);
    // MOV [0xcf],AL (1000_20A0 / 0x120A0)
    UInt8[DS, 0xCF] = AL;
    // RET  (1000_20A3 / 0x120A3)
    return NearRet();
    label_1000_20A4_120A4:
    // TEST byte ptr [0xbf],0x80 (1000_20A4 / 0x120A4)
    Alu.And8(UInt8[DS, 0xBF], 0x80);
    // JZ 0x1000:20d1 (1000_20A9 / 0x120A9)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_20D1 / 0x120D1)
      return NearRet();
    }
    // CALL 0x1000:1ac5 (1000_20AB / 0x120AB)
    NearCall(cs1, 0x20AE, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // CMP byte ptr [0xc2],0x0 (1000_20AE / 0x120AE)
    Alu.Sub8(UInt8[DS, 0xC2], 0x0);
    // JNZ 0x1000:2098 (1000_20B3 / 0x120B3)
    if(!ZeroFlag) {
      goto label_1000_2098_12098;
    }
    // TEST byte ptr [0xbf],0x10 (1000_20B5 / 0x120B5)
    Alu.And8(UInt8[DS, 0xBF], 0x10);
    // JNZ 0x1000:2131 (1000_20BA / 0x120BA)
    if(!ZeroFlag) {
      goto label_1000_2131_12131;
    }
    // CMP byte ptr [0x11bb],0x0 (1000_20BC / 0x120BC)
    Alu.Sub8(UInt8[DS, 0x11BB], 0x0);
    // JZ 0x1000:20c6 (1000_20C1 / 0x120C1)
    if(ZeroFlag) {
      goto label_1000_20C6_120C6;
    }
    // JMP 0x1000:215f (1000_20C3 / 0x120C3)
    goto label_1000_215F_1215F;
    label_1000_20C6_120C6:
    // SUB AX,word ptr [0x118d] (1000_20C6 / 0x120C6)
    // AX -= UInt16[DS, 0x118D];
    AX = Alu.Sub16(AX, UInt16[DS, 0x118D]);
    // JZ 0x1000:20d2 (1000_20CA / 0x120CA)
    if(ZeroFlag) {
      goto label_1000_20D2_120D2;
    }
    // NEG AX (1000_20CC / 0x120CC)
    AX = Alu.Sub16(0, AX);
    // MOV [0xcf],AL (1000_20CE / 0x120CE)
    UInt8[DS, 0xCF] = AL;
    label_1000_20D1_120D1:
    // RET  (1000_20D1 / 0x120D1)
    return NearRet();
    label_1000_20D2_120D2:
    // MOV AL,[0xc3] (1000_20D2 / 0x120D2)
    AL = UInt8[DS, 0xC3];
    // INC byte ptr [0xc3] (1000_20D5 / 0x120D5)
    UInt8[DS, 0xC3] = Alu.Inc8(UInt8[DS, 0xC3]);
    // MOV BX,0x96 (1000_20D9 / 0x120D9)
    BX = 0x96;
    // MUL BX (1000_20DC / 0x120DC)
    Cpu.Mul16(BX);
    // OR DX,DX (1000_20DE / 0x120DE)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNZ 0x1000:2111 (1000_20E0 / 0x120E0)
    if(!ZeroFlag) {
      goto label_1000_2111_12111;
    }
    // ADD AX,0x64 (1000_20E2 / 0x120E2)
    // AX += 0x64;
    AX = Alu.Add16(AX, 0x64);
    // JC 0x1000:2111 (1000_20E5 / 0x120E5)
    if(CarryFlag) {
      goto label_1000_2111_12111;
    }
    // MOV CX,AX (1000_20E7 / 0x120E7)
    CX = AX;
    // MOV BX,0x3f (1000_20E9 / 0x120E9)
    BX = 0x3F;
    // CALL 0x1000:e3b7 (1000_20EC / 0x120EC)
    NearCall(cs1, 0x20EF, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // ADD AX,0xe0 (1000_20EF / 0x120EF)
    AX += 0xE0;
    
    // MUL CX (1000_20F2 / 0x120F2)
    Cpu.Mul16(CX);
    // OR DH,DH (1000_20F4 / 0x120F4)
    // DH |= DH;
    DH = Alu.Or8(DH, DH);
    // JNZ 0x1000:2111 (1000_20F6 / 0x120F6)
    if(!ZeroFlag) {
      goto label_1000_2111_12111;
    }
    // MOV DH,DL (1000_20F8 / 0x120F8)
    DH = DL;
    // MOV DL,AH (1000_20FA / 0x120FA)
    DL = AH;
    // MOV AL,[0xbe] (1000_20FC / 0x120FC)
    AL = UInt8[DS, 0xBE];
    // SHL AL,0x1 (1000_20FF / 0x120FF)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // JC 0x1000:2114 (1000_2101 / 0x12101)
    if(CarryFlag) {
      goto label_1000_2114_12114;
    }
    // NOT AL (1000_2103 / 0x12103)
    AL = (byte)~AL;
    // MOV AH,0x1 (1000_2105 / 0x12105)
    AH = 0x1;
    // MUL DX (1000_2107 / 0x12107)
    Cpu.Mul16(DX);
    // XCHG DH,DL (1000_2109 / 0x12109)
    byte tmp_1000_2109 = DH;
    DH = DL;
    DL = tmp_1000_2109;
    // XCHG AH,DL (1000_210B / 0x1210B)
    byte tmp_1000_210B = AH;
    AH = DL;
    DL = tmp_1000_210B;
    // OR AH,AH (1000_210D / 0x1210D)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:2114 (1000_210F / 0x1210F)
    if(ZeroFlag) {
      goto label_1000_2114_12114;
    }
    label_1000_2111_12111:
    // MOV DX,0xffff (1000_2111 / 0x12111)
    DX = 0xFFFF;
    label_1000_2114_12114:
    // MOV word ptr [0xbc],DX (1000_2114 / 0x12114)
    UInt16[DS, 0xBC] = DX;
    // MOV byte ptr [0xcf],0x0 (1000_2118 / 0x12118)
    UInt8[DS, 0xCF] = 0x0;
    // OR byte ptr [0xbf],0x90 (1000_211D / 0x1211D)
    // UInt8[DS, 0xBF] |= 0x90;
    UInt8[DS, 0xBF] = Alu.Or8(UInt8[DS, 0xBF], 0x90);
    // MOV AX,0x20b (1000_2122 / 0x12122)
    AX = 0x20B;
    // CMP byte ptr [0xbe],0x0 (1000_2125 / 0x12125)
    Alu.Sub8(UInt8[DS, 0xBE], 0x0);
    // JS 0x1000:212e (1000_212A / 0x1212A)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:26da (1000_212E / 0x1212E)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_26DA_0126DA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // INC AH (1000_212C / 0x1212C)
    AH = Alu.Inc8(AH);
    label_1000_212E_1212E:
    // JMP 0x1000:26da (1000_212E / 0x1212E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_26DA_0126DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_2131_12131:
    // SUB AX,word ptr [0x118d] (1000_2131 / 0x12131)
    // AX -= UInt16[DS, 0x118D];
    AX = Alu.Sub16(AX, UInt16[DS, 0x118D]);
    // JZ 0x1000:20d1 (1000_2135 / 0x12135)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_20D1 / 0x120D1)
      return NearRet();
    }
    // CMP AX,0x4 (1000_2137 / 0x12137)
    Alu.Sub16(AX, 0x4);
    // JNC 0x1000:215f (1000_213A / 0x1213A)
    if(!CarryFlag) {
      goto label_1000_215F_1215F;
    }
    // SHL AL,0x1 (1000_213C / 0x1213C)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_213E / 0x1213E)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // MOV BL,AL (1000_2140 / 0x12140)
    BL = AL;
    // CALL 0x1000:24d2 (1000_2142 / 0x12142)
    throw FailAsUntested("Could not find a valid function at address 1000_24D2 / 0x124D2");
    // MOV AL,AH (1000_2145 / 0x12145)
    AL = AH;
    // CMP AL,0x3 (1000_2147 / 0x12147)
    Alu.Sub8(AL, 0x3);
    // JC 0x1000:214d (1000_2149 / 0x12149)
    if(CarryFlag) {
      goto label_1000_214D_1214D;
    }
    // MOV AL,0x2 (1000_214B / 0x1214B)
    AL = 0x2;
    label_1000_214D_1214D:
    // ADD AL,BL (1000_214D / 0x1214D)
    // AL += BL;
    AL = Alu.Add8(AL, BL);
    // MOV BX,0x2161 (1000_214F / 0x1214F)
    BX = 0x2161;
    // XLAT CS:BX (1000_2152 / 0x12152)
    AL = UInt8[cs1, (ushort)(BX + AL)];
    // OR AL,AL (1000_2154 / 0x12154)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:215f (1000_2156 / 0x12156)
    if(ZeroFlag) {
      goto label_1000_215F_1215F;
    }
    // MOV AH,AL (1000_2158 / 0x12158)
    AH = AL;
    // MOV AL,0xb (1000_215A / 0x1215A)
    AL = 0xB;
    // JMP 0x1000:26da (1000_215C / 0x1215C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_26DA_0126DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_215F_1215F:
    // MOV byte ptr [0x46d9],0x7 (1000_215F / 0x1215F)
    UInt8[DS, 0x46D9] = 0x7;
    // RET  (1000_2164 / 0x12164)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_2170_012170(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2170_12170:
    // CALL 0x1000:e270 (1000_2170 / 0x12170)
    NearCall(cs1, 0x2173, spice86_generated_label_call_target_1000_E270_01E270);
    label_1000_2173_12173:
    // MOV SI,0xfd8 (1000_2173 / 0x12173)
    SI = 0xFD8;
    // MOV CX,0x9 (1000_2176 / 0x12176)
    CX = 0x9;
    label_1000_2179_12179:
    // TEST byte ptr [SI + 0xf],0x40 (1000_2179 / 0x12179)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JNZ 0x1000:21f1 (1000_217D / 0x1217D)
    if(!ZeroFlag) {
      goto label_1000_21F1_121F1;
    }
    // MOV DX,word ptr [SI] (1000_217F / 0x1217F)
    DX = UInt16[DS, SI];
    // MOV BX,word ptr [SI + 0x2] (1000_2181 / 0x12181)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // CMP SI,0x1008 (1000_2184 / 0x12184)
    Alu.Sub16(SI, 0x1008);
    // JNZ 0x1000:2194 (1000_2188 / 0x12188)
    if(!ZeroFlag) {
      goto label_1000_2194_12194;
    }
    // CMP BX,0x180 (1000_218A / 0x1218A)
    Alu.Sub16(BX, 0x180);
    // JNZ 0x1000:2194 (1000_218E / 0x1218E)
    if(!ZeroFlag) {
      goto label_1000_2194_12194;
    }
    // MOV DL,0x4 (1000_2190 / 0x12190)
    DL = 0x4;
    // MOV word ptr [SI],DX (1000_2192 / 0x12192)
    UInt16[DS, SI] = DX;
    label_1000_2194_12194:
    // CMP BL,0x80 (1000_2194 / 0x12194)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:21ee (1000_2197 / 0x12197)
    if(!ZeroFlag) {
      goto label_1000_21EE_121EE;
    }
    // CMP DL,0x1 (1000_2199 / 0x12199)
    Alu.Sub8(DL, 0x1);
    // JNZ 0x1000:21dc (1000_219C / 0x1219C)
    if(!ZeroFlag) {
      goto label_1000_21DC_121DC;
    }
    // CMP DH,0x21 (1000_219E / 0x1219E)
    Alu.Sub8(DH, 0x21);
    // JNC 0x1000:21f1 (1000_21A1 / 0x121A1)
    if(!CarryFlag) {
      goto label_1000_21F1_121F1;
    }
    // CMP BH,byte ptr [0x9] (1000_21A3 / 0x121A3)
    Alu.Sub8(BH, UInt8[DS, 0x9]);
    // JZ 0x1000:21f1 (1000_21A7 / 0x121A7)
    if(ZeroFlag) {
      goto label_1000_21F1_121F1;
    }
    // MOV AL,0x1c (1000_21A9 / 0x121A9)
    AL = 0x1C;
    // MUL BH (1000_21AB / 0x121AB)
    Cpu.Mul8(BH);
    // ADD AX,0xe4 (1000_21AD / 0x121AD)
    // AX += 0xE4;
    AX = Alu.Add16(AX, 0xE4);
    // MOV DI,AX (1000_21B0 / 0x121B0)
    DI = AX;
    // TEST byte ptr [DI + 0xa],0x2 (1000_21B2 / 0x121B2)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x2);
    // JNZ 0x1000:21f1 (1000_21B6 / 0x121B6)
    if(!ZeroFlag) {
      goto label_1000_21F1_121F1;
    }
    // INC byte ptr [SI] (1000_21B8 / 0x121B8)
    UInt8[DS, SI] = Alu.Inc8(UInt8[DS, SI]);
    // CMP BH,0x1 (1000_21BA / 0x121BA)
    Alu.Sub8(BH, 0x1);
    // JNZ 0x1000:21f1 (1000_21BD / 0x121BD)
    if(!ZeroFlag) {
      goto label_1000_21F1_121F1;
    }
    // MOV BX,0x144d (1000_21BF / 0x121BF)
    BX = 0x144D;
    // MOV AL,byte ptr [SI + 0xe] (1000_21C2 / 0x121C2)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // XLAT BX (1000_21C5 / 0x121C5)
    AL = UInt8[DS, (ushort)(BX + AL)];
    // MOV byte ptr [SI],AL (1000_21C6 / 0x121C6)
    UInt8[DS, SI] = AL;
    // AND byte ptr [SI + 0xf],0xfb (1000_21C8 / 0x121C8)
    UInt8[DS, (ushort)(SI + 0xF)] &= 0xFB;
    
    // CMP AL,0x6 (1000_21CC / 0x121CC)
    Alu.Sub8(AL, 0x6);
    // JNZ 0x1000:21f1 (1000_21CE / 0x121CE)
    if(!ZeroFlag) {
      goto label_1000_21F1_121F1;
    }
    // CMP byte ptr [0x2a],0x24 (1000_21D0 / 0x121D0)
    Alu.Sub8(UInt8[DS, 0x2A], 0x24);
    // JNC 0x1000:21f1 (1000_21D5 / 0x121D5)
    if(!CarryFlag) {
      goto label_1000_21F1_121F1;
    }
    // MOV byte ptr [SI],0xa (1000_21D7 / 0x121D7)
    UInt8[DS, SI] = 0xA;
    // JMP 0x1000:21f1 (1000_21DA / 0x121DA)
    goto label_1000_21F1_121F1;
    label_1000_21DC_121DC:
    // CMP SI,0x1028 (1000_21DC / 0x121DC)
    Alu.Sub16(SI, 0x1028);
    // JC 0x1000:21f1 (1000_21E0 / 0x121E0)
    if(CarryFlag) {
      goto label_1000_21F1_121F1;
    }
    // CMP BH,0x1 (1000_21E2 / 0x121E2)
    Alu.Sub8(BH, 0x1);
    // JNZ 0x1000:21f1 (1000_21E5 / 0x121E5)
    if(!ZeroFlag) {
      goto label_1000_21F1_121F1;
    }
    // CALL 0x1000:21fa (1000_21E7 / 0x121E7)
    throw FailAsUntested("Could not find a valid function at address 1000_21FA / 0x121FA");
    // MOV byte ptr [SI],AL (1000_21EA / 0x121EA)
    UInt8[DS, SI] = AL;
    // JMP 0x1000:21f1 (1000_21EC / 0x121EC)
    goto label_1000_21F1_121F1;
    label_1000_21EE_121EE:
    // CALL 0x1000:221d (1000_21EE / 0x121EE)
    throw FailAsUntested("Could not find a valid function at address 1000_221D / 0x1221D");
    label_1000_21F1_121F1:
    // ADD SI,0x10 (1000_21F1 / 0x121F1)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:2179 (1000_21F4 / 0x121F4)
    if(--CX != 0) {
      goto label_1000_2179_12179;
    }
    // CALL 0x1000:e283 (1000_21F6 / 0x121F6)
    NearCall(cs1, 0x21F9, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_21F9_121F9:
    // RET  (1000_21F9 / 0x121F9)
    return NearRet();
  }
  
  public Action split_1000_26DA_0126DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_26DA_126DA:
    // CALL 0x1000:e270 (1000_26DA / 0x126DA)
    NearCall(cs1, 0x26DD, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV CL,byte ptr [0xc8] (1000_26DD / 0x126DD)
    CL = UInt8[DS, 0xC8];
    // XOR CH,CH (1000_26E1 / 0x126E1)
    CH = 0;
    // JCXZ 0x1000:26f1 (1000_26E3 / 0x126E3)
    if(CX == 0) {
      goto label_1000_26F1_126F1;
    }
    // MOV SI,0x1179 (1000_26E5 / 0x126E5)
    SI = 0x1179;
    label_1000_26E8_126E8:
    // CMP AX,word ptr [SI] (1000_26E8 / 0x126E8)
    Alu.Sub16(AX, UInt16[DS, SI]);
    // JZ 0x1000:272b (1000_26EA / 0x126EA)
    if(ZeroFlag) {
      goto label_1000_272B_1272B;
    }
    // ADD SI,0x2 (1000_26EC / 0x126EC)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // LOOP 0x1000:26e8 (1000_26EF / 0x126EF)
    if(--CX != 0) {
      goto label_1000_26E8_126E8;
    }
    label_1000_26F1_126F1:
    // MOV CL,byte ptr [0xc8] (1000_26F1 / 0x126F1)
    CL = UInt8[DS, 0xC8];
    // MOV SI,0x1179 (1000_26F5 / 0x126F5)
    SI = 0x1179;
    // CMP CL,0xa (1000_26F8 / 0x126F8)
    Alu.Sub8(CL, 0xA);
    // JC 0x1000:2707 (1000_26FB / 0x126FB)
    if(CarryFlag) {
      goto label_1000_2707_12707;
    }
    // PUSH AX (1000_26FD / 0x126FD)
    Stack.Push(AX);
    // CALL 0x1000:272f (1000_26FE / 0x126FE)
    throw FailAsUntested("Could not find a valid function at address 1000_272F / 0x1272F");
    // MOV CL,0x9 (1000_2701 / 0x12701)
    CL = 0x9;
    // MOV SI,0x1179 (1000_2703 / 0x12703)
    SI = 0x1179;
    // POP AX (1000_2706 / 0x12706)
    AX = Stack.Pop();
    label_1000_2707_12707:
    // ADD CL,CL (1000_2707 / 0x12707)
    CL += CL;
    
    // XOR CH,CH (1000_2709 / 0x12709)
    CH = 0;
    // ADD SI,CX (1000_270B / 0x1270B)
    // SI += CX;
    SI = Alu.Add16(SI, CX);
    // MOV word ptr [SI],AX (1000_270D / 0x1270D)
    UInt16[DS, SI] = AX;
    // INC byte ptr [0xc8] (1000_270F / 0x1270F)
    UInt8[DS, 0xC8] = Alu.Inc8(UInt8[DS, 0xC8]);
    // INC byte ptr [0xc9] (1000_2713 / 0x12713)
    UInt8[DS, 0xC9] = Alu.Inc8(UInt8[DS, 0xC9]);
    // CMP byte ptr [0x2a],0x38 (1000_2717 / 0x12717)
    Alu.Sub8(UInt8[DS, 0x2A], 0x38);
    // JC 0x1000:272b (1000_271C / 0x1271C)
    if(CarryFlag) {
      goto label_1000_272B_1272B;
    }
    // CMP byte ptr [0xb],0x8 (1000_271E / 0x1271E)
    Alu.Sub8(UInt8[DS, 0xB], 0x8);
    // JZ 0x1000:272b (1000_2723 / 0x12723)
    if(ZeroFlag) {
      goto label_1000_272B_1272B;
    }
    // MOV AX,0x201 (1000_2725 / 0x12725)
    AX = 0x201;
    // CALL 0x1000:29ee (1000_2728 / 0x12728)
    throw FailAsUntested("Could not find a valid function at address 1000_29EE / 0x129EE");
    label_1000_272B_1272B:
    // CALL 0x1000:e283 (1000_272B / 0x1272B)
    NearCall(cs1, 0x272E, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_272E / 0x1272E)
    return NearRet();
  }
  
  public Action split_1000_2A34_012A34(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_2AAF_012AAF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    SI = Alu.Inc16(SI);
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
  
  public Action spice86_generated_label_call_target_1000_2B2A_012B2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    throw FailAsUntested("Could not find a valid function at address 1000_2AD8 / 0x12AD8");
    // JNC 0x1000:2b70 (1000_2B66 / 0x12B66)
    if(!CarryFlag) {
      goto label_1000_2B70_12B70;
    }
    // MOV byte ptr [0x23],0x0 (1000_2B68 / 0x12B68)
    UInt8[DS, 0x23] = 0x0;
    // JMP 0x1000:3542 (1000_2B6D / 0x12B6D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_3520_013520, 0x13542 - cs1 * 0x10)) {
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
    throw FailAsUntested("Could not find a valid function at address 1000_1071 / 0x11071");
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
    if(JumpDispatcher.Jump(split_1000_2A34_012A34, 0)) {
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
      if(JumpDispatcher.Jump(split_1000_2A34_012A34, 0)) {
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
      if(JumpDispatcher.Jump(split_1000_2A34_012A34, 0)) {
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
    throw FailAsUntested("Could not find a valid function at address 1000_2C92 / 0x12C92");
    // MOV AL,0x1 (1000_2C4A / 0x12C4A)
    AL = 0x1;
    // CALL 0x1000:9ef1 (1000_2C4C / 0x12C4C)
    throw FailAsUntested("Could not find a valid function at address 1000_9EF1 / 0x19EF1");
    // CALL 0x1000:2a34 (1000_2C4F / 0x12C4F)
    NearCall(cs1, 0x2C52, split_1000_2A34_012A34);
    // XOR AX,AX (1000_2C52 / 0x12C52)
    AX = 0;
    // MOV [0x1f0f],AL (1000_2C54 / 0x12C54)
    UInt8[DS, 0x1F0F] = AL;
    // MOV [0x1f10],AX (1000_2C57 / 0x12C57)
    UInt16[DS, 0x1F10] = AX;
    // CALL 0x1000:d397 (1000_2C5A / 0x12C5A)
    throw FailAsUntested("Could not find a valid function at address 1000_D397 / 0x1D397");
    // CALL 0x1000:b2b9 (1000_2C5D / 0x12C5D)
    NearCall(cs1, 0x2C60, spice86_generated_label_call_target_1000_B2B9_01B2B9);
    // MOV AX,0xbb8 (1000_2C60 / 0x12C60)
    AX = 0xBB8;
    // CALL 0x1000:ddb0 (1000_2C63 / 0x12C63)
    throw FailAsUntested("Could not find a valid function at address 1000_DDB0 / 0x1DDB0");
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
    throw FailAsUntested("Could not find a valid function at address 1000_189A / 0x1189A");
    // JMP 0x1000:c412 (1000_2C8F / 0x12C8F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C412_01C412, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_2D74_012D74(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AX = Alu.Dec16(AX);
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
    label_1000_2DAD_12DAD:
    // CALL 0x1000:0098 (1000_2DAD / 0x12DAD)
    NearCall(cs1, 0x2DB0, spice86_generated_label_call_target_1000_0098_010098);
    label_1000_2DB0_12DB0:
    // RET  (1000_2DB0 / 0x12DB0)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_2DB1_012DB1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2DB1_12DB1:
    // MOV BP,0xd717 (1000_2DB1 / 0x12DB1)
    BP = 0xD717;
    // CALL 0x1000:c097 (1000_2DB4 / 0x12DB4)
    NearCall(cs1, 0x2DB7, spice86_generated_label_call_target_1000_C097_01C097);
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
  
  public Action spice86_generated_label_call_target_1000_2DBF_012DBF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2DBF_12DBF:
    // CALL 0x1000:2d74 (1000_2DBF / 0x12DBF)
    NearCall(cs1, 0x2DC2, spice86_generated_label_call_target_1000_2D74_012D74);
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
    throw FailAsUntested("Could not find a valid function at address 1000_0ACD / 0x10ACD");
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
    throw FailAsUntested("Could not find a valid function at address 1000_488A / 0x1488A");
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
  
  public Action spice86_generated_label_ret_target_1000_2E52_012E52(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2E52_12E52:
    // CALL 0x1000:35ad (1000_2E52 / 0x12E52)
    NearCall(cs1, 0x2E55, spice86_generated_label_call_target_1000_35AD_0135AD);
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_3722_013722, 0x13723 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
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
  
  public Action spice86_generated_label_call_target_1000_2E98_012E98(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_2EB2_012EB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2EB2_12EB2:
    // CMP byte ptr [0x4774],0x0 (1000_2EB2 / 0x12EB2)
    Alu.Sub8(UInt8[DS, 0x4774], 0x0);
    // JZ 0x1000:2ec9 (1000_2EB7 / 0x12EB7)
    if(ZeroFlag) {
      goto label_1000_2EC9_12EC9;
    }
    // CALL 0x1000:301a (1000_2EB9 / 0x12EB9)
    throw FailAsUntested("Could not find a valid function at address 1000_301A / 0x1301A");
    // CALL 0x1000:98e6 (1000_2EBC / 0x12EBC)
    NearCall(cs1, 0x2EBF, spice86_generated_label_call_target_1000_98E6_0198E6);
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
    label_1000_2EC9_12EC9:
    // MOV DI,word ptr [0x114e] (1000_2EC9 / 0x12EC9)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:2e98 (1000_2ECD / 0x12ECD)
    NearCall(cs1, 0x2ED0, spice86_generated_label_call_target_1000_2E98_012E98);
    label_1000_2ED0_12ED0:
    // CALL 0x1000:2efb (1000_2ED0 / 0x12ED0)
    NearCall(cs1, 0x2ED3, spice86_generated_label_call_target_1000_2EFB_012EFB);
    label_1000_2ED3_12ED3:
    // CMP byte ptr [0x11c9],0x0 (1000_2ED3 / 0x12ED3)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:2edd (1000_2ED8 / 0x12ED8)
    if(!ZeroFlag) {
      goto label_1000_2EDD_12EDD;
    }
    // CALL 0x1000:3090 (1000_2EDA / 0x12EDA)
    NearCall(cs1, 0x2EDD, spice86_generated_label_call_target_1000_3090_013090);
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
  
  public Action spice86_generated_label_call_target_1000_2EFB_012EFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    goto label_1000_2FAA_12FAA;
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
      goto label_1000_2F58_12F58;
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
    goto label_1000_2FA3_12FA3;
    label_1000_2F3D_12F3D:
    // PUSH DI (1000_2F3D / 0x12F3D)
    Stack.Push(DI);
    // MOV DI,word ptr [0x114e] (1000_2F3E / 0x12F3E)
    DI = UInt16[DS, 0x114E];
    // CALL 0x1000:7f27 (1000_2F42 / 0x12F42)
    NearCall(cs1, 0x2F45, spice86_generated_label_call_target_1000_7F27_017F27);
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
    goto label_1000_2FA3_12FA3;
    label_1000_2F58_12F58:
    // CMP BH,0x1 (1000_2F58 / 0x12F58)
    Alu.Sub8(BH, 0x1);
    // JNZ 0x1000:2fa3 (1000_2F5B / 0x12F5B)
    if(!ZeroFlag) {
      goto label_1000_2FA3_12FA3;
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
      goto label_1000_2FA3_12FA3;
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
      goto label_1000_2FA3_12FA3;
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
    goto label_1000_2FF7_12FF7;
    label_1000_2FAA_12FAA:
    // TEST byte ptr [0x11c9],0x3 (1000_2FAA / 0x12FAA)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JNZ 0x1000:2fd7 (1000_2FAF / 0x12FAF)
    if(!ZeroFlag) {
      goto label_1000_2FD7_12FD7;
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
    goto label_1000_2FA3_12FA3;
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
    label_1000_2FF7_12FF7:
    // XOR AX,AX (1000_2FF7 / 0x12FF7)
    AX = 0;
    // STOSW ES:DI (1000_2FF9 / 0x12FF9)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // RET  (1000_2FFA / 0x12FFA)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_2FFB_012FFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_2FFB_12FFB:
    // CMP byte ptr [0x2b],0x0 (1000_2FFB / 0x12FFB)
    Alu.Sub8(UInt8[DS, 0x2B], 0x0);
    // JNZ 0x1000:301a (1000_3000 / 0x13000)
    if(!ZeroFlag) {
      goto label_1000_301A_1301A;
    }
    // TEST byte ptr [0x11c9],0x3 (1000_3002 / 0x13002)
    Alu.And8(UInt8[DS, 0x11C9], 0x3);
    // JZ 0x1000:3020 (1000_3007 / 0x13007)
    if(ZeroFlag) {
      goto label_1000_3020_13020;
    }
    // CMP byte ptr [0x11ca],0x0 (1000_3009 / 0x13009)
    Alu.Sub8(UInt8[DS, 0x11CA], 0x0);
    // JNZ 0x1000:301a (1000_300E / 0x1300E)
    if(!ZeroFlag) {
      goto label_1000_301A_1301A;
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
    label_1000_3020_13020:
    // MOV BX,word ptr [0x6] (1000_3020 / 0x13020)
    BX = UInt16[DS, 0x6];
    // CMP BL,0x80 (1000_3024 / 0x13024)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:3073 (1000_3027 / 0x13027)
    if(!ZeroFlag) {
      goto label_1000_3073_13073;
    }
    // MOV DX,word ptr [0x4] (1000_3029 / 0x13029)
    DX = UInt16[DS, 0x4];
    // CMP DH,0x21 (1000_302D / 0x1302D)
    Alu.Sub8(DH, 0x21);
    // JZ 0x1000:3073 (1000_3030 / 0x13030)
    if(ZeroFlag) {
      goto label_1000_3073_13073;
    }
    // CALL 0x1000:3efe (1000_3032 / 0x13032)
    NearCall(cs1, 0x3035, spice86_generated_label_call_target_1000_3EFE_013EFE);
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0x1D735 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
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
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D72B_01D72B, 0x1D735 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_3090_013090(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_3090_13090:
    // CALL 0x1000:98e6 (1000_3090 / 0x13090)
    NearCall(cs1, 0x3093, spice86_generated_label_call_target_1000_98E6_0198E6);
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
  
  public Action spice86_generated_label_call_target_1000_30B9_0130B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
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
    AL = Alu.Dec8(AL);
    // SUB AL,byte ptr [0x476a] (1000_310F / 0x1310F)
    // AL -= UInt8[DS, 0x476A];
    AL = Alu.Sub8(AL, UInt8[DS, 0x476A]);
    // CBW  (1000_3113 / 0x13113)
    AX = (ushort)((short)((sbyte)AL));
    // SHL AX,0x1 (1000_3114 / 0x13114)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_3116 / 0x13116)
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
  
  public Action spice86_generated_label_call_target_1000_3120_013120(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
  
  public Action spice86_generated_label_call_target_1000_3127_013127(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x316D: goto label_1000_316D_1316D;break; // Target of external jump from 0x13192
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
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
    throw FailAsUntested("Could not find a valid function at address 1000_2318 / 0x12318");
    // POP DI (1000_3169 / 0x13169)
    DI = Stack.Pop();
    label_1000_316A_1316A:
    // CALL 0x1000:331e (1000_316A / 0x1316A)
    NearCall(cs1, 0x316D, spice86_generated_label_call_target_1000_331E_01331E);
    label_1000_316D_1316D:
    // RET  (1000_316D / 0x1316D)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_316E_01316E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    AH = Alu.Dec8(AH);
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
    UInt8[DS, 0x476A] = Alu.Inc8(UInt8[DS, 0x476A]);
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
    AX = Alu.Dec16(AX);
    label_1000_31C3_131C3:
    // SHL AX,0x1 (1000_31C3 / 0x131C3)
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
  
  public Action spice86_generated_label_call_target_1000_331E_01331E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // RCL AL,0x1 (1000_336E / 0x1336E)
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
  
  public Action spice86_generated_label_call_target_1000_3385_013385(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    throw FailAsUntested("Could not find a valid function at address 1000_33AD / 0x133AD");
    // MOV SI,0x1028 (1000_33A4 / 0x133A4)
    SI = 0x1028;
    // CALL 0x1000:33ad (1000_33A7 / 0x133A7)
    throw FailAsUntested("Could not find a valid function at address 1000_33AD / 0x133AD");
    // MOV SI,0x1048 (1000_33AA / 0x133AA)
    SI = 0x1048;
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
  
  public Action spice86_generated_label_call_target_1000_33BE_0133BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    label_1000_33D2_133D2:
    // CALL 0x1000:33d9 (1000_33D2 / 0x133D2)
    NearCall(cs1, 0x33D5, spice86_generated_label_call_target_1000_33D9_0133D9);
    label_1000_33D5_133D5:
    // MOV [0x9c],AL (1000_33D5 / 0x133D5)
    UInt8[DS, 0x9C] = AL;
    // RET  (1000_33D8 / 0x133D8)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_33D9_0133D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
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
    // SHR AX,0x1 (1000_33F6 / 0x133F6)
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
  
}
