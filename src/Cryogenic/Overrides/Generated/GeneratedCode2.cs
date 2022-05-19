namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public virtual Action spice86_generated_label_call_target_1000_181E_01181E(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x181D: break; // Instructions before entry targeted by 0x11823, 0x117F2, 0x11848, 0x1180F
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
  
  public virtual Action spice86_generated_label_call_target_1000_1834_011834(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_1843_011843(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_1860_011860(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_186B_01186B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_186B_01186B(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1877: goto label_1000_1877_11877;break; // Target of external jump from 0x11872, 0x1B1AC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
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
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_5A1A_015A1A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1877_11877:
    // CALL 0x1000:d2bd (1000_1877 / 0x11877)
    NearCall(cs1, 0x187A, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_187A_01187A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_187A_01187A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_189A_01189A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_189A_01189A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_18AB_0118AB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_18AB_0118AB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_18BA_0118BA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_18D8_0118D8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_18D8_0118D8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_18EE_0118EE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_18EE_118EE:
    // CALL 0x1000:d41b (1000_18EE / 0x118EE)
    NearCall(cs1, 0x18F1, spice86_generated_label_call_target_1000_D41B_01D41B);
    label_1000_18F1_118F1:
    // CMP BP,0x2012 (1000_18F1 / 0x118F1)
    Alu.Sub16(BP, 0x2012);
    // JNZ 0x1000:18fa (1000_18F5 / 0x118F5)
    if(!ZeroFlag) {
      goto label_1000_18FA_118FA;
    }
    // JMP 0x1000:d2e2 (1000_18F7 / 0x118F7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_D2E2_01D2E2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_18FA_118FA:
    // MOV AX,[0x4] (1000_18FA / 0x118FA)
    AX = UInt16[DS, 0x4];
    // CMP AH,0x20 (1000_18FD / 0x118FD)
    Alu.Sub8(AH, 0x20);
    // JNZ 0x1000:1947 (1000_1900 / 0x11900)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1947 / 0x11947)
      return NearRet();
    }
    // CMP AL,0x1 (1000_1902 / 0x11902)
    Alu.Sub8(AL, 0x1);
    // JZ 0x1000:1947 (1000_1904 / 0x11904)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1947 / 0x11947)
      return NearRet();
    }
    // MOV AX,0x1aba (1000_1906 / 0x11906)
    AX = 0x1ABA;
    // CALL 0x1000:d95e (1000_1909 / 0x11909)
    NearCall(cs1, 0x190C, spice86_generated_label_call_target_1000_D95E_01D95E);
    label_1000_190C_1190C:
    // CALL 0x1000:d2bd (1000_190C / 0x1190C)
    NearCall(cs1, 0x190F, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_190F_01190F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_190F_01190F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_190F_1190F:
    // CALL 0x1000:c07c (1000_190F / 0x1190F)
    NearCall(cs1, 0x1912, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_1912_11912:
    // MOV SI,0x143c (1000_1912 / 0x11912)
    SI = 0x143C;
    // MOV AL,0xf1 (1000_1915 / 0x11915)
    AL = 0xF1;
    // MOV ES,word ptr [0xdbda] (1000_1917 / 0x11917)
    ES = UInt16[DS, 0xDBDA];
    // CALLF [0x38dd] (1000_191B / 0x1191B)
    // Indirect call to [0x38dd], generating possible targets from emulator records
    uint targetAddress_1000_191B = (uint)(UInt16[DS, 0x38DF] * 0x10 + UInt16[DS, 0x38DD] - cs1 * 0x10);
    switch(targetAddress_1000_191B) {
      case 0x235CE : FarCall(cs1, 0x191F, spice86_generated_label_call_target_334B_011E_0335CE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_191B));
        break;
    }
    label_1000_191F_1191F:
    // MOV SI,0x1444 (1000_191F / 0x1191F)
    SI = 0x1444;
    // MOV AL,0xf7 (1000_1922 / 0x11922)
    AL = 0xF7;
    // CALL 0x1000:5b6e (1000_1924 / 0x11924)
    NearCall(cs1, 0x1927, spice86_generated_label_call_target_1000_5B6E_015B6E);
    label_1000_1927_11927:
    // MOV AX,0x21 (1000_1927 / 0x11927)
    AX = 0x21;
    // CALL 0x1000:c13e (1000_192A / 0x1192A)
    NearCall(cs1, 0x192D, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_192D_1192D:
    // MOV SI,0x120b (1000_192D / 0x1192D)
    SI = 0x120B;
    // CALL 0x1000:c21b (1000_1930 / 0x11930)
    NearCall(cs1, 0x1933, spice86_generated_label_call_target_1000_C21B_01C21B);
    label_1000_1933_11933:
    // CALL 0x1000:1948 (1000_1933 / 0x11933)
    NearCall(cs1, 0x1936, spice86_generated_label_call_target_1000_1948_011948);
    label_1000_1936_11936:
    // MOV SI,0x143c (1000_1936 / 0x11936)
    SI = 0x143C;
    // MOV AL,0x10 (1000_1939 / 0x11939)
    AL = 0x10;
    // CALL 0x1000:c0d5 (1000_193B / 0x1193B)
    NearCall(cs1, 0x193E, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    label_1000_193E_1193E:
    // MOV BP,0x2012 (1000_193E / 0x1193E)
    BP = 0x2012;
    // MOV BX,0x19fc (1000_1941 / 0x11941)
    BX = 0x19FC;
    // JMP 0x1000:d323 (1000_1944 / 0x11944)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D323_01D323, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_1947_011947(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1947_11947:
    // RET  (1000_1947 / 0x11947)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1948_011948(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1948_11948:
    // SUB SP,0x24 (1000_1948 / 0x11948)
    // SP -= 0x24;
    SP = Alu.Sub16(SP, 0x24);
    // MOV DI,SP (1000_194B / 0x1194B)
    DI = SP;
    // PUSH SS (1000_194D / 0x1194D)
    Stack.Push(SS);
    // POP ES (1000_194E / 0x1194E)
    ES = Stack.Pop();
    // MOV CX,0x24 (1000_194F / 0x1194F)
    CX = 0x24;
    // XOR AX,AX (1000_1952 / 0x11952)
    AX = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_1954 / 0x11954)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV SI,0xfd8 (1000_1956 / 0x11956)
    SI = 0xFD8;
    // MOV DI,SP (1000_1959 / 0x11959)
    DI = SP;
    // MOV CX,0x10 (1000_195B / 0x1195B)
    CX = 0x10;
    // MOV DH,byte ptr [0x7] (1000_195E / 0x1195E)
    DH = UInt8[DS, 0x7];
    label_1000_1962_11962:
    // CMP DH,byte ptr [SI + 0x3] (1000_1962 / 0x11962)
    Alu.Sub8(DH, UInt8[DS, (ushort)(SI + 0x3)]);
    // JNZ 0x1000:1980 (1000_1965 / 0x11965)
    if(!ZeroFlag) {
      goto label_1000_1980_11980;
    }
    // MOV AL,byte ptr [SI + 0xe] (1000_1967 / 0x11967)
    AL = UInt8[DS, (ushort)(SI + 0xE)];
    // CALL 0x1000:127c (1000_196A / 0x1196A)
    NearCall(cs1, 0x196D, spice86_generated_label_call_target_1000_127C_01127C);
    label_1000_196D_1196D:
    // JC 0x1000:1980 (1000_196D / 0x1196D)
    if(CarryFlag) {
      goto label_1000_1980_11980;
    }
    // MOV BX,word ptr [SI] (1000_196F / 0x1196F)
    BX = UInt16[DS, SI];
    // DEC BL (1000_1971 / 0x11971)
    BL--;
    // XOR BH,BH (1000_1973 / 0x11973)
    BH = 0;
    // TEST byte ptr [SI + 0xf],0x40 (1000_1975 / 0x11975)
    Alu.And8(UInt8[DS, (ushort)(SI + 0xF)], 0x40);
    // JZ 0x1000:197e (1000_1979 / 0x11979)
    if(ZeroFlag) {
      goto label_1000_197E_1197E;
    }
    // ADD BX,0xc (1000_197B / 0x1197B)
    BX += 0xC;
    label_1000_197E_1197E:
    // INC byte ptr [BX + DI] (1000_197E / 0x1197E)
    UInt8[DS, (ushort)(BX + DI)]++;
    label_1000_1980_11980:
    // ADD SI,0x10 (1000_1980 / 0x11980)
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // LOOP 0x1000:1962 (1000_1983 / 0x11983)
    if(--CX != 0) {
      goto label_1000_1962_11962;
    }
    // MOV BX,word ptr [0x4] (1000_1985 / 0x11985)
    BX = UInt16[DS, 0x4];
    // XOR BH,BH (1000_1989 / 0x11989)
    BH = 0;
    // CMP BL,0xc (1000_198B / 0x1198B)
    Alu.Sub8(BL, 0xC);
    // JA 0x1000:1995 (1000_198E / 0x1198E)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_1995_11995;
    }
    // ADD BL,0x17 (1000_1990 / 0x11990)
    BL += 0x17;
    // INC byte ptr [BX + DI] (1000_1993 / 0x11993)
    UInt8[DS, (ushort)(BX + DI)] = Alu.Inc8(UInt8[DS, (ushort)(BX + DI)]);
    label_1000_1995_11995:
    // MOV CX,0xb (1000_1995 / 0x11995)
    CX = 0xB;
    // INC DI (1000_1998 / 0x11998)
    DI = Alu.Inc16(DI);
    // MOV SI,0x1426 (1000_1999 / 0x11999)
    SI = 0x1426;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_199C_01199C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_199C_01199C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_199C_1199C:
    // MOV DX,word ptr [0x120d] (1000_199C / 0x1199C)
    DX = UInt16[DS, 0x120D];
    // MOV BX,word ptr [0x120f] (1000_19A0 / 0x119A0)
    BX = UInt16[DS, 0x120F];
    // LODSB SI (1000_19A4 / 0x119A4)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // XOR AH,AH (1000_19A5 / 0x119A5)
    AH = 0;
    // ADD DX,AX (1000_19A7 / 0x119A7)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // LODSB SI (1000_19A9 / 0x119A9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // ADD BX,AX (1000_19AA / 0x119AA)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // PUSH CX (1000_19AC / 0x119AC)
    Stack.Push(CX);
    // PUSH SI (1000_19AD / 0x119AD)
    Stack.Push(SI);
    // PUSH DI (1000_19AE / 0x119AE)
    Stack.Push(DI);
    // ADD BX,0x2 (1000_19AF / 0x119AF)
    BX += 0x2;
    // ADD DX,0x3 (1000_19B2 / 0x119B2)
    // DX += 0x3;
    DX = Alu.Add16(DX, 0x3);
    // MOV CL,byte ptr [DI] (1000_19B5 / 0x119B5)
    CL = UInt8[DS, DI];
    // CALL 0x1000:19df (1000_19B7 / 0x119B7)
    NearCall(cs1, 0x19BA, spice86_generated_label_call_target_1000_19DF_0119DF);
    label_1000_19BA_119BA:
    // ADD BX,0x7 (1000_19BA / 0x119BA)
    // BX += 0x7;
    BX = Alu.Add16(BX, 0x7);
    // MOV CL,byte ptr [DI + 0xc] (1000_19BD / 0x119BD)
    CL = UInt8[DS, (ushort)(DI + 0xC)];
    // CALL 0x1000:19df (1000_19C0 / 0x119C0)
    NearCall(cs1, 0x19C3, spice86_generated_label_call_target_1000_19DF_0119DF);
    label_1000_19C3_119C3:
    // SUB BX,0x4 (1000_19C3 / 0x119C3)
    BX -= 0x4;
    // ADD DX,0x9 (1000_19C6 / 0x119C6)
    DX += 0x9;
    // CMP byte ptr [DI + 0x18],0x0 (1000_19C9 / 0x119C9)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x18)], 0x0);
    // JZ 0x1000:19d5 (1000_19CD / 0x119CD)
    if(ZeroFlag) {
      goto label_1000_19D5_119D5;
    }
    // MOV AX,0x1 (1000_19CF / 0x119CF)
    AX = 0x1;
    // CALL 0x1000:c22f (1000_19D2 / 0x119D2)
    NearCall(cs1, 0x19D5, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_19D5_119D5:
    // POP DI (1000_19D5 / 0x119D5)
    DI = Stack.Pop();
    // POP SI (1000_19D6 / 0x119D6)
    SI = Stack.Pop();
    // POP CX (1000_19D7 / 0x119D7)
    CX = Stack.Pop();
    // INC DI (1000_19D8 / 0x119D8)
    DI = Alu.Inc16(DI);
    // LOOP 0x1000:199c (1000_19D9 / 0x119D9)
    if(--CX != 0) {
      goto label_1000_199C_1199C;
    }
    // ADD SP,0x24 (1000_19DB / 0x119DB)
    // SP += 0x24;
    SP = Alu.Add16(SP, 0x24);
    // RET  (1000_19DE / 0x119DE)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_19DF_0119DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_19DF_119DF:
    // XOR CH,CH (1000_19DF / 0x119DF)
    CH = 0;
    // JCXZ 0x1000:19fb (1000_19E1 / 0x119E1)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_19FB / 0x119FB)
      return NearRet();
    }
    // PUSH DX (1000_19E3 / 0x119E3)
    Stack.Push(DX);
    // PUSH DI (1000_19E4 / 0x119E4)
    Stack.Push(DI);
    // CMP CL,0x5 (1000_19E5 / 0x119E5)
    Alu.Sub8(CL, 0x5);
    // JBE 0x1000:19ec (1000_19E8 / 0x119E8)
    if(CarryFlag || ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_19EC_0119EC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CL,0x5 (1000_19EA / 0x119EA)
    CL = 0x5;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_19EC_0119EC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_19EC_0119EC(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x19FB: goto label_1000_19FB_119FB;break; // Target of external jump from 0x119E1
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_19EC_119EC:
    // PUSH CX (1000_19EC / 0x119EC)
    Stack.Push(CX);
    // MOV AX,0x2 (1000_19ED / 0x119ED)
    AX = 0x2;
    // CALL 0x1000:c2fd (1000_19F0 / 0x119F0)
    NearCall(cs1, 0x19F3, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    label_1000_19F3_119F3:
    // POP CX (1000_19F3 / 0x119F3)
    CX = Stack.Pop();
    // ADD DX,0x4 (1000_19F4 / 0x119F4)
    // DX += 0x4;
    DX = Alu.Add16(DX, 0x4);
    // LOOP 0x1000:19ec (1000_19F7 / 0x119F7)
    if(--CX != 0) {
      goto label_1000_19EC_119EC;
    }
    // POP DI (1000_19F9 / 0x119F9)
    DI = Stack.Pop();
    // POP DX (1000_19FA / 0x119FA)
    DX = Stack.Pop();
    label_1000_19FB_119FB:
    // RET  (1000_19FB / 0x119FB)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_19FC_0119FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_19FC_119FC:
    // CALL 0x1000:daa3 (1000_19FC / 0x119FC)
    NearCall(cs1, 0x19FF, spice86_generated_label_call_target_1000_DAA3_01DAA3);
    label_1000_19FF_119FF:
    // MOV SI,0x143c (1000_19FF / 0x119FF)
    SI = 0x143C;
    // PUSH SI (1000_1A02 / 0x11A02)
    Stack.Push(SI);
    // CALL 0x1000:c446 (1000_1A03 / 0x11A03)
    NearCall(cs1, 0x1A06, spice86_generated_label_call_target_1000_C446_01C446);
    label_1000_1A06_11A06:
    // POP SI (1000_1A06 / 0x11A06)
    SI = Stack.Pop();
    // MOV AL,0x12 (1000_1A07 / 0x11A07)
    AL = 0x12;
    // CALL 0x1000:c0d5 (1000_1A09 / 0x11A09)
    NearCall(cs1, 0x1A0C, spice86_generated_label_call_target_1000_C0D5_01C0D5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A0C_011A0C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A0C_011A0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1A0C_11A0C:
    // JMP 0x1000:d95b (1000_1A0C / 0x11A0C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_D95B_01D95B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1A0F_011A0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A20_011A20, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A20_011A20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1A20_11A20:
    // MOV SI,0x1af4 (1000_1A20 / 0x11A20)
    SI = 0x1AF4;
    // CALL 0x1000:d200 (1000_1A23 / 0x11A23)
    NearCall(cs1, 0x1A26, spice86_generated_label_call_target_1000_D200_01D200);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A26_011A26, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A26_011A26(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1A26_11A26:
    // CALL 0x1000:1a34 (1000_1A26 / 0x11A26)
    NearCall(cs1, 0x1A29, spice86_generated_label_call_target_1000_1A34_011A34);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A29_011A29, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A29_011A29(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1A33: goto label_1000_1A33_11A33;break; // Target of external jump from 0x11A14, 0x11A39
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_1A34_011A34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A42_011A42, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A42_011A42(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1A42_11A42:
    // MOV AX,[0x2] (1000_1A42 / 0x11A42)
    AX = UInt16[DS, 0x2];
    // AND AX,0xf (1000_1A45 / 0x11A45)
    AX &= 0xF;
    // SHL AX,1 (1000_1A48 / 0x11A48)
    AX <<= 0x1;
    // SHL AX,1 (1000_1A4A / 0x11A4A)
    AX <<= 0x1;
    // SHL AX,1 (1000_1A4C / 0x11A4C)
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A62_011A62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A62_011A62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1A90_011A90, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1A90_011A90(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_1A9B_011A9B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1AAB_011AAB, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1AAB_011AAB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
      case 0x235C2 : FarCall(cs1, 0x1AC2, spice86_generated_label_call_target_334B_0112_0335C2); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_1ABD));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1AC2_011AC2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1AC2_011AC2(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1AC4: goto label_1000_1AC4_11AC4;break; // Target of external jump from 0x11AA5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
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
  
  public virtual Action spice86_generated_label_call_target_1000_1AC5_011AC5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1AC5_11AC5:
    // MOV AX,[0x2] (1000_1AC5 / 0x11AC5)
    AX = UInt16[DS, 0x2];
    // SHR AX,1 (1000_1AC8 / 0x11AC8)
    AX >>= 0x1;
    // SHR AX,1 (1000_1ACA / 0x11ACA)
    AX >>= 0x1;
    // SHR AX,1 (1000_1ACC / 0x11ACC)
    AX >>= 0x1;
    // SHR AX,1 (1000_1ACE / 0x11ACE)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_1AD0 / 0x11AD0)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1AD1_011AD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1AD1_11AD1:
    // MOV AX,[0x2] (1000_1AD1 / 0x11AD1)
    AX = UInt16[DS, 0x2];
    // ADD AX,0x3 (1000_1AD4 / 0x11AD4)
    AX += 0x3;
    // SHR AX,1 (1000_1AD7 / 0x11AD7)
    AX >>= 0x1;
    // SHR AX,1 (1000_1AD9 / 0x11AD9)
    AX >>= 0x1;
    // SHR AX,1 (1000_1ADB / 0x11ADB)
    AX >>= 0x1;
    // SHR AX,1 (1000_1ADD / 0x11ADD)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // RET  (1000_1ADF / 0x11ADF)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1AE0_011AE0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_1AE7_011AE7(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B0C: goto label_1000_1B0C_11B0C;break; // Target of external jump from 0x11B04, 0x11AF7, 0x11B17, 0x11B28, 0x11AEE
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
    NearCall(cs1, 0x1B0C, not_observed_1000_C868_01C868);
    label_1000_1B0C_11B0C:
    // RET  (1000_1B0C / 0x11B0C)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1B0D_011B0D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_ret_target_1000_1B23_011B23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    AL--;
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1B43_011B43, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1B43_011B43(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1B5E_011B5E, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:1c46 (1000_1B5B / 0x11B5B)
    NearCall(cs1, 0x1B5E, spice86_generated_label_call_target_1000_1C46_011C46);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1B5E_011B5E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1B5E_011B5E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1B5E_11B5E:
    // CMP byte ptr [0xc2],0x7 (1000_1B5E / 0x11B5E)
    Alu.Sub8(UInt8[DS, 0xC2], 0x7);
    // JNC 0x1000:1bb2 (1000_1B63 / 0x11B63)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
    // SHL AX,1 (1000_1B79 / 0x11B79)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV SI,AX (1000_1B7B / 0x11B7B)
    SI = AX;
    // CALL word ptr CS:[SI + 0x1db3] (1000_1B7D / 0x11B7D)
    // Indirect call to word ptr CS:[SI + 0x1db3], generating possible targets from emulator records
    uint targetAddress_1000_1B7D = (uint)(UInt16[cs1, (ushort)(SI + 0x1DB3)]);
    switch(targetAddress_1000_1B7D) {
      case 0x1DD4 : NearCall(cs1, 0x1B82, spice86_generated_label_call_target_1000_1DD4_011DD4); break;
      case 0x1DD7 : NearCall(cs1, 0x1B82, spice86_generated_label_call_target_1000_1DD7_011DD7); break;
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x46ec],0x0 (1000_1B97 / 0x11B97)
    Alu.Sub8(UInt8[DS, 0x46EC], 0x0);
    // JZ 0x1000:1ba1 (1000_1B9C / 0x11B9C)
    if(ZeroFlag) {
      goto label_1000_1BA1_11BA1;
    }
    // CALL 0x1000:5d6d (1000_1B9E / 0x11B9E)
    NearCall(cs1, 0x1BA1, not_observed_1000_5D6D_015D6D);
    label_1000_1BA1_11BA1:
    // MOV DI,word ptr [0x114e] (1000_1BA1 / 0x11BA1)
    DI = UInt16[DS, 0x114E];
    // OR DI,DI (1000_1BA5 / 0x11BA5)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JZ 0x1000:1bb2 (1000_1BA7 / 0x11BA7)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x473b],0x0 (1000_1BA9 / 0x11BA9)
    Alu.Sub8(UInt8[DS, 0x473B], 0x0);
    // JS 0x1000:1bd2 (1000_1BAE / 0x11BAE)
    if(SignFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_1BB8_011BB8, 0x11BD2 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // JA 0x1000:1bb8 (1000_1BB0 / 0x11BB0)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_1BB8_011BB8, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_label_1000_1BB2_11BB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1BB2_11BB2:
    // MOV byte ptr [0x473b],0x0 (1000_1BB2 / 0x11BB2)
    UInt8[DS, 0x473B] = 0x0;
    // RET  (1000_1BB7 / 0x11BB7)
    return NearRet();
  }
  
  public virtual Action split_1000_1BB8_011BB8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1BB8_11BB8:
    // CMP byte ptr [0xfb],0x0 (1000_1BB8 / 0x11BB8)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:1bb2 (1000_1BBD / 0x11BBD)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x46da],0x0 (1000_1BBF / 0x11BBF)
    Alu.Sub8(UInt8[DS, 0x46DA], 0x0);
    // JNZ 0x1000:1bb2 (1000_1BC4 / 0x11BC4)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:dbb2 (1000_1BC6 / 0x11BC6)
    NearCall(cs1, 0x1BC9, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // CALL 0x1000:1bb2 (1000_1BC9 / 0x11BC9)
    NearCall(cs1, 0x1BCC, spice86_label_1000_1BB2_11BB2);
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
    NearCall(cs1, 0x1BD5, spice86_label_1000_1BB2_11BB2);
    // CMP byte ptr [0xfb],0x0 (1000_1BD5 / 0x11BD5)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:1be9 (1000_1BDA / 0x11BDA)
    if(SignFlag) {
      // JS target is JMP, inlining.
      // JMP 0x1000:5d6d (1000_1BE9 / 0x11BE9)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_5D6D_015D6D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [0x46da],0x0 (1000_1BDC / 0x11BDC)
    Alu.Sub8(UInt8[DS, 0x46DA], 0x0);
    // JNZ 0x1000:1bb2 (1000_1BE1 / 0x11BE1)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_label_1000_1BB2_11BB2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:d2bd (1000_1BE3 / 0x11BE3)
    NearCall(cs1, 0x1BE6, spice86_generated_label_call_target_1000_D2BD_01D2BD);
    // JMP 0x1000:0fa7 (1000_1BE6 / 0x11BE6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_0FA7_010FA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1BE9_11BE9:
    // JMP 0x1000:5d6d (1000_1BE9 / 0x11BE9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5D6D_015D6D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1BEC_011BEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_1C18_011C18(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1C18_11C18:
    // CMP byte ptr [0x46eb],0x0 (1000_1C18 / 0x11C18)
    Alu.Sub8(UInt8[DS, 0x46EB], 0x0);
    // JNS 0x1000:1c39 (1000_1C1D / 0x11C1D)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_1C39_011C39, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:c13b (1000_1C1F / 0x11C1F)
    NearCall(cs1, 0x1C22, spice86_generated_label_call_target_1000_C13B_01C13B);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1C22_011C22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1C22_011C22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1C22_11C22:
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
    NearCall(cs1, 0x1C2D, not_observed_1000_78E9_0178E9);
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
    NearCall(cs1, 0x1C38, spice86_generated_label_call_target_1000_600E_01600E);
    label_1000_1C38_11C38:
    // RET  (1000_1C38 / 0x11C38)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_1C39_011C39(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    NearCall(cs1, 0x1C45, spice86_generated_label_call_target_1000_BDBB_01BDBB);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1C45_011C45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1C45_011C45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1C45_11C45:
    // RET  (1000_1C45 / 0x11C45)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1C46_011C46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1C62_011C62, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1C62_011C62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1C62_11C62:
    // MOV AL,[0xd5] (1000_1C62 / 0x11C62)
    AL = UInt8[DS, 0xD5];
    // INC AL (1000_1C65 / 0x11C65)
    AL++;
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1CA3_011CA3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1CA3_011CA3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1CA3_11CA3:
    // CALL 0x1000:bf26 (1000_1CA3 / 0x11CA3)
    NearCall(cs1, 0x1CA6, spice86_generated_label_call_target_1000_BF26_01BF26);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1CA6_011CA6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1CA6_011CA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    // ROL BX,1 (1000_1CC3 / 0x11CC3)
    BX = Alu.Rol16(BX, 0x1);
    // ROL BX,1 (1000_1CC5 / 0x11CC5)
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
  
  public virtual Action spice86_generated_label_call_target_1000_1CDA_011CDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // SHR AL,1 (1000_1CEA / 0x11CEA)
    AL >>= 0x1;
    // SHR AL,1 (1000_1CEC / 0x11CEC)
    AL >>= 0x1;
    // SHR AL,1 (1000_1CEE / 0x11CEE)
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
    // SHR BX,1 (1000_1CFE / 0x11CFE)
    BX >>= 0x1;
    // SHR BX,1 (1000_1D00 / 0x11D00)
    BX >>= 0x1;
    // SHR BX,1 (1000_1D02 / 0x11D02)
    BX >>= 0x1;
    // SHR BX,1 (1000_1D04 / 0x11D04)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // CALL 0x1000:e3df (1000_1D06 / 0x11D06)
    NearCall(cs1, 0x1D09, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1D09_011D09, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1D09_011D09(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1D09_11D09:
    // ADD CX,AX (1000_1D09 / 0x11D09)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // MOV word ptr [0xa8],CX (1000_1D0B / 0x11D0B)
    UInt16[DS, 0xA8] = CX;
    // RET  (1000_1D0F / 0x11D0F)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_1D10_011D10(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1D10_11D10:
    // ROL word ptr [0x0],1 (1000_1D10 / 0x11D10)
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
    AL--;
    // CMP AL,0xc7 (1000_1D24 / 0x11D24)
    Alu.Sub8(AL, 0xC7);
    // JNC 0x1000:1d2b (1000_1D26 / 0x11D26)
    if(!CarryFlag) {
      goto label_1000_1D2B_11D2B;
    }
    // INC byte ptr [SI + 0x1a] (1000_1D28 / 0x11D28)
    UInt8[DS, (ushort)(SI + 0x1A)]++;
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
  
  public virtual Action spice86_generated_label_call_target_1000_1D66_011D66(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_1D9F_011D9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    NearCall(cs1, 0x1DB2, not_observed_1000_1EDA_011EDA);
    label_1000_1DB2_11DB2:
    // RET  (1000_1DB2 / 0x11DB2)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1DD3_011DD3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1DD3_11DD3:
    // RET  (1000_1DD3 / 0x11DD3)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1DD4_011DD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1DD4_11DD4:
    // JMP 0x1000:20a4 (1000_1DD4 / 0x11DD4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_20A4_0120A4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1DD7_011DD7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1DD7_11DD7:
    // JMP 0x1000:1f64 (1000_1DD7 / 0x11DD7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_1F64_011F64, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1DDA_011DDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    NearCall(cs1, 0x1DFD, not_observed_1000_29EE_0129EE);
    label_1000_1DFD_11DFD:
    // RET  (1000_1DFD / 0x11DFD)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1DFE_011DFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
  
  public virtual Action spice86_generated_label_call_target_1000_1E01_011E01(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1E01_11E01:
    // CMP byte ptr [0x2a],0x5d (1000_1E01 / 0x11E01)
    Alu.Sub8(UInt8[DS, 0x2A], 0x5D);
    // JNZ 0x1000:1e3e (1000_1E06 / 0x11E06)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_1E24_011E24, 0x11E3E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CMP byte ptr [SI + 0xe],0x7 (1000_1E08 / 0x11E08)
    Alu.Sub8(UInt8[DS, (ushort)(SI + 0xE)], 0x7);
    // JNZ 0x1000:1e3e (1000_1E0C / 0x11E0C)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_1E24_011E24, 0x11E3E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV BX,word ptr [SI + 0x2] (1000_1E0E / 0x11E0E)
    BX = UInt16[DS, (ushort)(SI + 0x2)];
    // CMP BL,0x80 (1000_1E11 / 0x11E11)
    Alu.Sub8(BL, 0x80);
    // JNZ 0x1000:1e3e (1000_1E14 / 0x11E14)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_1E24_011E24, 0x11E3E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV byte ptr [SI],0x2 (1000_1E16 / 0x11E16)
    UInt8[DS, SI] = 0x2;
    // JNZ 0x1000:1e3e (1000_1E19 / 0x11E19)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(not_observed_1000_1E24_011E24, 0x11E3E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
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
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_1E24_011E24, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_1E24_011E24(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1E3E: goto label_1000_1E3E_11E3E;break; // Target of external jump from 0x11E06
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
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
  
  public virtual Action spice86_generated_label_call_target_1000_1E43_011E43(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1E43_11E43:
    // CALL 0x1000:1ac5 (1000_1E43 / 0x11E43)
    NearCall(cs1, 0x1E46, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_1E46_011E46, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_ret_target_1000_1E46_011E46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
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
    NearCall(cs1, 0x1E7A, spice86_generated_label_call_target_1000_661D_01661D);
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
    NearCall(cs1, 0x1E9C, spice86_generated_label_call_target_1000_661D_01661D);
    // MOV AL,0x8 (1000_1E9C / 0x11E9C)
    AL = 0x8;
    // JMP 0x1000:71b2 (1000_1E9E / 0x11E9E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_71B2_0171B2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_1EA8_011EA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1EA8_11EA8:
    // RET  (1000_1EA8 / 0x11EA8)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_1EBE_011EBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1EBE_11EBE:
    // TEST word ptr [SI + 0x12],0x800 (1000_1EBE / 0x11EBE)
    Alu.And16(UInt16[DS, (ushort)(SI + 0x12)], 0x800);
    // JZ 0x1000:1ed9 (1000_1EC3 / 0x11EC3)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_1ED9 / 0x11ED9)
      return NearRet();
    }
    // MOV AL,[0x2a] (1000_1EC5 / 0x11EC5)
    AL = UInt8[DS, 0x2A];
    // SUB AL,0x60 (1000_1EC8 / 0x11EC8)
    AL -= 0x60;
    // CMP AL,0x4 (1000_1ECA / 0x11ECA)
    Alu.Sub8(AL, 0x4);
    // JNC 0x1000:1ed9 (1000_1ECC / 0x11ECC)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_1ED9 / 0x11ED9)
      return NearRet();
    }
    // CALL 0x1000:e270 (1000_1ECE / 0x11ECE)
    NearCall(cs1, 0x1ED1, spice86_generated_label_call_target_1000_E270_01E270);
    // MOV AL,0x64 (1000_1ED1 / 0x11ED1)
    AL = 0x64;
    // CALL 0x1000:121f (1000_1ED3 / 0x11ED3)
    NearCall(cs1, 0x1ED6, spice86_generated_label_jump_target_1000_121F_01121F);
    // CALL 0x1000:e283 (1000_1ED6 / 0x11ED6)
    NearCall(cs1, 0x1ED9, spice86_generated_label_call_target_1000_E283_01E283);
    label_1000_1ED9_11ED9:
    // RET  (1000_1ED9 / 0x11ED9)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_1EDA_011EDA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1EDA_11EDA:
    // ADD byte ptr [0xf9],0x8 (1000_1EDA / 0x11EDA)
    // UInt8[DS, 0xF9] += 0x8;
    UInt8[DS, 0xF9] = Alu.Add8(UInt8[DS, 0xF9], 0x8);
    // JNZ 0x1000:1f12 (1000_1EDF / 0x11EDF)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_1F12 / 0x11F12)
      return NearRet();
    }
    // PUSH CX (1000_1EE1 / 0x11EE1)
    Stack.Push(CX);
    // PUSH SI (1000_1EE2 / 0x11EE2)
    Stack.Push(SI);
    // MOV BP,0x1eb1 (1000_1EE3 / 0x11EE3)
    BP = 0x1EB1;
    // CALL 0x1000:6603 (1000_1EE6 / 0x11EE6)
    NearCall(cs1, 0x1EE9, spice86_generated_label_call_target_1000_6603_016603);
    // MOV AX,0x709 (1000_1EE9 / 0x11EE9)
    AX = 0x709;
    // CALL 0x1000:29f0 (1000_1EEC / 0x11EEC)
    NearCall(cs1, 0x1EEF, not_observed_1000_29F0_0129F0);
    // DEC byte ptr [0xf8] (1000_1EEF / 0x11EEF)
    UInt8[DS, 0xF8] = Alu.Dec8(UInt8[DS, 0xF8]);
    // MOV DI,0x100 (1000_1EF3 / 0x11EF3)
    DI = 0x100;
    label_1000_1EF6_11EF6:
    // CALL 0x1000:1e24 (1000_1EF6 / 0x11EF6)
    NearCall(cs1, 0x1EF9, not_observed_1000_1E24_011E24);
    // JC 0x1000:1f05 (1000_1EF9 / 0x11EF9)
    if(CarryFlag) {
      goto label_1000_1F05_11F05;
    }
    // ADD DI,0x1c (1000_1EFB / 0x11EFB)
    DI += 0x1C;
    // CMP byte ptr [DI],0xff (1000_1EFE / 0x11EFE)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:1ef6 (1000_1F01 / 0x11F01)
    if(!ZeroFlag) {
      goto label_1000_1EF6_11EF6;
    }
    // XOR DI,DI (1000_1F03 / 0x11F03)
    DI = 0;
    label_1000_1F05_11F05:
    // MOV word ptr [0x11db],DI (1000_1F05 / 0x11F05)
    UInt16[DS, 0x11DB] = DI;
    // OR DI,DI (1000_1F09 / 0x11F09)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // JNZ 0x1000:1f10 (1000_1F0B / 0x11F0B)
    if(!ZeroFlag) {
      goto label_1000_1F10_11F10;
    }
    // CALL 0x1000:11cb (1000_1F0D / 0x11F0D)
    NearCall(cs1, 0x1F10, not_observed_1000_11CB_0111CB);
    label_1000_1F10_11F10:
    // POP SI (1000_1F10 / 0x11F10)
    SI = Stack.Pop();
    // POP CX (1000_1F11 / 0x11F11)
    CX = Stack.Pop();
    label_1000_1F12_11F12:
    // RET  (1000_1F12 / 0x11F12)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_1F64_011F64(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    // ROL word ptr [0x0],1 (1000_1F8B / 0x11F8B)
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
    NearCall(cs1, 0x1F95, not_observed_1000_2017_012017);
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
    NearCall(cs1, 0x1FBC, not_observed_1000_84A6_0184A6);
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
    NearCall(cs1, 0x1FC6, not_observed_1000_8357_018357);
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
    NearCall(cs1, 0x1FD2, not_observed_1000_83FD_0183FD);
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
    NearCall(cs1, 0x1FF8, not_observed_1000_71B2_0171B2);
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
      if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
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
    NearCall(cs1, 0x2013, not_observed_1000_6144_016144);
    label_1000_2013_12013:
    // RET  (1000_2013 / 0x12013)
    return NearRet();
    label_1000_2014_12014:
    // JMP 0x1000:5d50 (1000_2014 / 0x12014)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_5D50_015D50, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2017_012017(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2017_12017:
    // MOV DI,0x100 (1000_2017 / 0x12017)
    DI = 0x100;
    // MOV word ptr [0xd816],0x0 (1000_201A / 0x1201A)
    UInt16[DS, 0xD816] = 0x0;
    // MOV BX,0x64 (1000_2020 / 0x12020)
    BX = 0x64;
    label_1000_2023_12023:
    // CMP byte ptr [DI + 0x8],0x20 (1000_2023 / 0x12023)
    Alu.Sub8(UInt8[DS, (ushort)(DI + 0x8)], 0x20);
    // JNC 0x1000:207d (1000_2027 / 0x12027)
    if(!CarryFlag) {
      goto label_1000_207D_1207D;
    }
    // TEST byte ptr [DI + 0xa],0x82 (1000_2029 / 0x12029)
    Alu.And8(UInt8[DS, (ushort)(DI + 0xA)], 0x82);
    // JNZ 0x1000:207d (1000_202D / 0x1202D)
    if(!ZeroFlag) {
      goto label_1000_207D_1207D;
    }
    // CMP BX,word ptr [DI + 0x4] (1000_202F / 0x1202F)
    Alu.Sub16(BX, UInt16[DS, (ushort)(DI + 0x4)]);
    // JLE 0x1000:207d (1000_2032 / 0x12032)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_207D_1207D;
    }
    // CALL 0x1000:1e24 (1000_2034 / 0x12034)
    NearCall(cs1, 0x2037, not_observed_1000_1E24_011E24);
    // JC 0x1000:207d (1000_2037 / 0x12037)
    if(CarryFlag) {
      goto label_1000_207D_1207D;
    }
    // PUSH BX (1000_2039 / 0x12039)
    Stack.Push(BX);
    // CALL 0x1000:331e (1000_203A / 0x1203A)
    NearCall(cs1, 0x203D, spice86_generated_label_call_target_1000_331E_01331E);
    // POP BX (1000_203D / 0x1203D)
    BX = Stack.Pop();
    // MOV AL,[0x60] (1000_203E / 0x1203E)
    AL = UInt8[DS, 0x60];
    // SUB AL,byte ptr [0x63] (1000_2041 / 0x12041)
    // AL -= UInt8[DS, 0x63];
    AL = Alu.Sub8(AL, UInt8[DS, 0x63]);
    // JZ 0x1000:207d (1000_2045 / 0x12045)
    if(ZeroFlag) {
      goto label_1000_207D_1207D;
    }
    // MOV BP,word ptr [0xe4] (1000_2047 / 0x12047)
    BP = UInt16[DS, 0xE4];
    // CMP word ptr [0xe2],0x1e (1000_204B / 0x1204B)
    Alu.Sub16(UInt16[DS, 0xE2], 0x1E);
    // JC 0x1000:205d (1000_2050 / 0x12050)
    if(CarryFlag) {
      goto label_1000_205D_1205D;
    }
    // CMP word ptr [0xdc],0x1e (1000_2052 / 0x12052)
    Alu.Sub16(UInt16[DS, 0xDC], 0x1E);
    // JNC 0x1000:207d (1000_2057 / 0x12057)
    if(!CarryFlag) {
      goto label_1000_207D_1207D;
    }
    // MOV BP,word ptr [0xde] (1000_2059 / 0x12059)
    BP = UInt16[DS, 0xDE];
    label_1000_205D_1205D:
    // CMP BP,0x11c (1000_205D / 0x1205D)
    Alu.Sub16(BP, 0x11C);
    // JZ 0x1000:207d (1000_2061 / 0x12061)
    if(ZeroFlag) {
      goto label_1000_207D_1207D;
    }
    // PUSH DI (1000_2063 / 0x12063)
    Stack.Push(DI);
    // MOV DI,BP (1000_2064 / 0x12064)
    DI = BP;
    // CALL 0x1000:5098 (1000_2066 / 0x12066)
    NearCall(cs1, 0x2069, not_observed_1000_5098_015098);
    // MOV BP,DI (1000_2069 / 0x12069)
    BP = DI;
    // POP DI (1000_206B / 0x1206B)
    DI = Stack.Pop();
    // JCXZ 0x1000:207d (1000_206C / 0x1206C)
    if(CX == 0) {
      goto label_1000_207D_1207D;
    }
    // OR DX,DX (1000_206E / 0x1206E)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JNZ 0x1000:207d (1000_2070 / 0x12070)
    if(!ZeroFlag) {
      goto label_1000_207D_1207D;
    }
    // MOV BX,word ptr [DI + 0x4] (1000_2072 / 0x12072)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // MOV word ptr [0xd816],DI (1000_2075 / 0x12075)
    UInt16[DS, 0xD816] = DI;
    // MOV word ptr [0xd818],BP (1000_2079 / 0x12079)
    UInt16[DS, 0xD818] = BP;
    label_1000_207D_1207D:
    // ADD DI,0x1c (1000_207D / 0x1207D)
    DI += 0x1C;
    // CMP byte ptr [DI],0x8 (1000_2080 / 0x12080)
    Alu.Sub8(UInt8[DS, DI], 0x8);
    // JC 0x1000:2023 (1000_2083 / 0x12083)
    if(CarryFlag) {
      goto label_1000_2023_12023;
    }
    // MOV BP,word ptr [0xd818] (1000_2085 / 0x12085)
    BP = UInt16[DS, 0xD818];
    // MOV DI,word ptr [0xd816] (1000_2089 / 0x12089)
    DI = UInt16[DS, 0xD816];
    // OR DI,DI (1000_208D / 0x1208D)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    // RET  (1000_208F / 0x1208F)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2090_012090(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2090_12090:
    // CALL 0x1000:1ac5 (1000_2090 / 0x12090)
    NearCall(cs1, 0x2093, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // MOV [0x118d],AX (1000_2093 / 0x12093)
    UInt16[DS, 0x118D] = AX;
    // JMP 0x1000:20d2 (1000_2096 / 0x12096)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_20A4_0120A4, 0x120D2 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_20A4_0120A4(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x2098: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
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
    entry:
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
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_215F_01215F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
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
    // SHL AL,1 (1000_20FF / 0x120FF)
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
      if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
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
    if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_215F_01215F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // SHL AL,1 (1000_213C / 0x1213C)
    AL <<= 0x1;
    // SHL AL,1 (1000_213E / 0x1213E)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // MOV BL,AL (1000_2140 / 0x12140)
    BL = AL;
    // CALL 0x1000:24d2 (1000_2142 / 0x12142)
    NearCall(cs1, 0x2145, not_observed_1000_24D2_0124D2);
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
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_215F_01215F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AH,AL (1000_2158 / 0x12158)
    AH = AL;
    // MOV AL,0xb (1000_215A / 0x1215A)
    AL = 0xB;
    // JMP 0x1000:26da (1000_215C / 0x1215C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_215F_01215F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_215F_1215F:
    // MOV byte ptr [0x46d9],0x7 (1000_215F / 0x1215F)
    UInt8[DS, 0x46D9] = 0x7;
    // RET  (1000_2164 / 0x12164)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_call_target_1000_2170_012170(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    UInt8[DS, SI]++;
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
    NearCall(cs1, 0x21EA, not_observed_1000_21FA_0121FA);
    // MOV byte ptr [SI],AL (1000_21EA / 0x121EA)
    UInt8[DS, SI] = AL;
    // JMP 0x1000:21f1 (1000_21EC / 0x121EC)
    goto label_1000_21F1_121F1;
    label_1000_21EE_121EE:
    // CALL 0x1000:221d (1000_21EE / 0x121EE)
    NearCall(cs1, 0x21F1, not_observed_1000_221D_01221D);
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
  
  public virtual Action not_observed_1000_21FA_0121FA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_21FA_121FA:
    // MOV BX,0xa (1000_21FA / 0x121FA)
    BX = 0xA;
    // CALL 0x1000:e3df (1000_21FD / 0x121FD)
    NearCall(cs1, 0x2200, spice86_generated_label_call_target_1000_E3DF_01E3DF);
    // ADD AL,0x2 (1000_2200 / 0x12200)
    AL += 0x2;
    // CMP byte ptr [0x2a],0x54 (1000_2202 / 0x12202)
    Alu.Sub8(UInt8[DS, 0x2A], 0x54);
    // JNC 0x1000:221c (1000_2207 / 0x12207)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_221C / 0x1221C)
      return NearRet();
    }
    // CMP AL,0x3 (1000_2209 / 0x12209)
    Alu.Sub8(AL, 0x3);
    // JZ 0x1000:21fa (1000_220B / 0x1220B)
    if(ZeroFlag) {
      goto label_1000_21FA_121FA;
    }
    // CMP byte ptr [0x2a],0x24 (1000_220D / 0x1220D)
    Alu.Sub8(UInt8[DS, 0x2A], 0x24);
    // JNC 0x1000:221c (1000_2212 / 0x12212)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_221C / 0x1221C)
      return NearRet();
    }
    // CMP AL,0xb (1000_2214 / 0x12214)
    Alu.Sub8(AL, 0xB);
    // JZ 0x1000:21fa (1000_2216 / 0x12216)
    if(ZeroFlag) {
      goto label_1000_21FA_121FA;
    }
    // CMP AL,0x6 (1000_2218 / 0x12218)
    Alu.Sub8(AL, 0x6);
    // JZ 0x1000:21fa (1000_221A / 0x1221A)
    if(ZeroFlag) {
      goto label_1000_21FA_121FA;
    }
    label_1000_221C_1221C:
    // RET  (1000_221C / 0x1221C)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_221D_01221D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_221D_1221D:
    // PUSH CX (1000_221D / 0x1221D)
    Stack.Push(CX);
    // PUSH SI (1000_221E / 0x1221E)
    Stack.Push(SI);
    // MOV DX,word ptr [SI] (1000_221F / 0x1221F)
    DX = UInt16[DS, SI];
    // CALL 0x1000:5344 (1000_2221 / 0x12221)
    NearCall(cs1, 0x2224, not_observed_1000_5344_015344);
    // CALL 0x1000:40ae (1000_2224 / 0x12224)
    NearCall(cs1, 0x2227, spice86_generated_label_call_target_1000_40AE_0140AE);
    // POP SI (1000_2227 / 0x12227)
    SI = Stack.Pop();
    // POP CX (1000_2228 / 0x12228)
    CX = Stack.Pop();
    // MOV word ptr [SI],DX (1000_2229 / 0x12229)
    UInt16[DS, SI] = DX;
    // MOV word ptr [SI + 0x2],BX (1000_222B / 0x1222B)
    UInt16[DS, (ushort)(SI + 0x2)] = BX;
    // CMP BH,byte ptr [0x9] (1000_222E / 0x1222E)
    Alu.Sub8(BH, UInt8[DS, 0x9]);
    // JNZ 0x1000:2238 (1000_2232 / 0x12232)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_2238 / 0x12238)
      return NearRet();
    }
    // OR byte ptr [SI + 0xf],0x4 (1000_2234 / 0x12234)
    // UInt8[DS, (ushort)(SI + 0xF)] |= 0x4;
    UInt8[DS, (ushort)(SI + 0xF)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0xF)], 0x4);
    label_1000_2238_12238:
    // RET  (1000_2238 / 0x12238)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2318_012318(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2318_12318:
    // MOV AL,byte ptr [DI] (1000_2318 / 0x12318)
    AL = UInt8[DS, DI];
    // MOV SI,0x10c7 (1000_231A / 0x1231A)
    SI = 0x10C7;
    label_1000_231D_1231D:
    // ADD SI,0x11 (1000_231D / 0x1231D)
    SI += 0x11;
    // CMP AL,byte ptr [SI] (1000_2320 / 0x12320)
    Alu.Sub8(AL, UInt8[DS, SI]);
    // JNZ 0x1000:231d (1000_2322 / 0x12322)
    if(!ZeroFlag) {
      goto label_1000_231D_1231D;
    }
    // CALL 0x1000:235f (1000_2324 / 0x12324)
    NearCall(cs1, 0x2327, not_observed_1000_235F_01235F);
    // CALL 0x1000:1ac5 (1000_2327 / 0x12327)
    NearCall(cs1, 0x232A, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // SUB AL,byte ptr [SI + 0x3] (1000_232A / 0x1232A)
    AL -= UInt8[DS, (ushort)(SI + 0x3)];
    // TEST byte ptr [SI + 0x2],0x8 (1000_232D / 0x1232D)
    Alu.And8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    // JNZ 0x1000:2339 (1000_2331 / 0x12331)
    if(!ZeroFlag) {
      goto label_1000_2339_12339;
    }
    // MOV AL,0x1 (1000_2333 / 0x12333)
    AL = 0x1;
    // OR byte ptr [SI + 0x2],0x8 (1000_2335 / 0x12335)
    // UInt8[DS, (ushort)(SI + 0x2)] |= 0x8;
    UInt8[DS, (ushort)(SI + 0x2)] = Alu.Or8(UInt8[DS, (ushort)(SI + 0x2)], 0x8);
    label_1000_2339_12339:
    // MOV [0x1e],AL (1000_2339 / 0x12339)
    UInt8[DS, 0x1E] = AL;
    // MOV byte ptr [0x9d],0x0 (1000_233C / 0x1233C)
    UInt8[DS, 0x9D] = 0x0;
    // MOV AX,[0x0] (1000_2341 / 0x12341)
    AX = UInt16[DS, 0x0];
    // AND AX,0x7 (1000_2344 / 0x12344)
    AX &= 0x7;
    label_1000_2347_12347:
    // CMP AL,byte ptr [0x1141] (1000_2347 / 0x12347)
    Alu.Sub8(AL, UInt8[DS, 0x1141]);
    // JC 0x1000:2353 (1000_234B / 0x1234B)
    if(CarryFlag) {
      goto label_1000_2353_12353;
    }
    // SUB AL,byte ptr [0x1141] (1000_234D / 0x1234D)
    // AL -= UInt8[DS, 0x1141];
    AL = Alu.Sub8(AL, UInt8[DS, 0x1141]);
    // JMP 0x1000:2347 (1000_2351 / 0x12351)
    goto label_1000_2347_12347;
    label_1000_2353_12353:
    // ADD AX,0xe8 (1000_2353 / 0x12353)
    // AX += 0xE8;
    AX = Alu.Add16(AX, 0xE8);
    // MOV [0x11f1],AX (1000_2356 / 0x12356)
    UInt16[DS, 0x11F1] = AX;
    // MOV byte ptr [0x9f],0x0 (1000_2359 / 0x12359)
    UInt8[DS, 0x9F] = 0x0;
    // RET  (1000_235E / 0x1235E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_235F_01235F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_235F_1235F:
    // MOV word ptr [0x10b4],SI (1000_235F / 0x1235F)
    UInt16[DS, 0x10B4] = SI;
    // MOV AL,byte ptr [SI + 0x2] (1000_2363 / 0x12363)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    // MOV [0x1c],AL (1000_2366 / 0x12366)
    UInt8[DS, 0x1C] = AL;
    // MOV AX,word ptr [SI + 0xe] (1000_2369 / 0x12369)
    AX = UInt16[DS, (ushort)(SI + 0xE)];
    // MOV [0x20],AX (1000_236C / 0x1236C)
    UInt16[DS, 0x20] = AX;
    // MOV byte ptr [0x1f],0x0 (1000_236F / 0x1236F)
    UInt8[DS, 0x1F] = 0x0;
    // OR AX,AX (1000_2374 / 0x12374)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:2381 (1000_2376 / 0x12376)
    if(ZeroFlag) {
      goto label_1000_2381_12381;
    }
    // CALL 0x1000:1ac5 (1000_2378 / 0x12378)
    NearCall(cs1, 0x237B, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // SUB AL,byte ptr [SI + 0x10] (1000_237B / 0x1237B)
    // AL -= UInt8[DS, (ushort)(SI + 0x10)];
    AL = Alu.Sub8(AL, UInt8[DS, (ushort)(SI + 0x10)]);
    // MOV [0x1f],AL (1000_237E / 0x1237E)
    UInt8[DS, 0x1F] = AL;
    label_1000_2381_12381:
    // MOV AL,byte ptr [SI + 0x1] (1000_2381 / 0x12381)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    // MOV [0x1d],AL (1000_2384 / 0x12384)
    UInt8[DS, 0x1D] = AL;
    // RET  (1000_2387 / 0x12387)
    return NearRet();
  }
  
  public virtual Action spice86_generated_label_jump_target_1000_24A3_0124A3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_24A3_124A3:
    // CMP byte ptr [0x2a],0x10 (1000_24A3 / 0x124A3)
    Alu.Sub8(UInt8[DS, 0x2A], 0x10);
    // JNC 0x1000:24b0 (1000_24A8 / 0x124A8)
    if(!CarryFlag) {
      goto label_1000_24B0_124B0;
    }
    // OR byte ptr [0xff7],0x10 (1000_24AA / 0x124AA)
    // UInt8[DS, 0xFF7] |= 0x10;
    UInt8[DS, 0xFF7] = Alu.Or8(UInt8[DS, 0xFF7], 0x10);
    // RET  (1000_24AF / 0x124AF)
    return NearRet();
    label_1000_24B0_124B0:
    // CALL 0x1000:a1e8 (1000_24B0 / 0x124B0)
    NearCall(cs1, 0x24B3, spice86_generated_label_call_target_1000_A1E8_01A1E8);
    // MOV word ptr [0xc0],0x0 (1000_24B3 / 0x124B3)
    UInt16[DS, 0xC0] = 0x0;
    // OR byte ptr [0xbf],0x1 (1000_24B9 / 0x124B9)
    // UInt8[DS, 0xBF] |= 0x1;
    UInt8[DS, 0xBF] = Alu.Or8(UInt8[DS, 0xBF], 0x1);
    // CALL 0x1000:24d2 (1000_24BE / 0x124BE)
    NearCall(cs1, 0x24C1, not_observed_1000_24D2_0124D2);
    // ADD AH,0x7 (1000_24C1 / 0x124C1)
    // AH += 0x7;
    AH = Alu.Add8(AH, 0x7);
    // MOV AL,0xb (1000_24C4 / 0x124C4)
    AL = 0xB;
    // CMP AH,0xc (1000_24C6 / 0x124C6)
    Alu.Sub8(AH, 0xC);
    // JNZ 0x1000:24cf (1000_24C9 / 0x124C9)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      // JMP 0x1000:26da (1000_24CF / 0x124CF)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // INC byte ptr [0x11bb] (1000_24CB / 0x124CB)
    UInt8[DS, 0x11BB] = Alu.Inc8(UInt8[DS, 0x11BB]);
    label_1000_24CF_124CF:
    // JMP 0x1000:26da (1000_24CF / 0x124CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_26DA_0126DA, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_24D2_0124D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_24D2_124D2:
    // MOV AL,[0xbe] (1000_24D2 / 0x124D2)
    AL = UInt8[DS, 0xBE];
    // XOR CL,CL (1000_24D5 / 0x124D5)
    CL = 0;
    // XOR AH,AH (1000_24D7 / 0x124D7)
    AH = 0;
    // CMP AL,0x1 (1000_24D9 / 0x124D9)
    Alu.Sub8(AL, 0x1);
    // ADC AH,CL (1000_24DB / 0x124DB)
    AH = Alu.Adc8(AH, CL);
    // CMP AL,0x40 (1000_24DD / 0x124DD)
    Alu.Sub8(AL, 0x40);
    // ADC AH,CL (1000_24DF / 0x124DF)
    AH = Alu.Adc8(AH, CL);
    // CMP AL,0x80 (1000_24E1 / 0x124E1)
    Alu.Sub8(AL, 0x80);
    // ADC AH,CL (1000_24E3 / 0x124E3)
    AH = Alu.Adc8(AH, CL);
    // CMP AL,0x90 (1000_24E5 / 0x124E5)
    Alu.Sub8(AL, 0x90);
    // ADC AH,CL (1000_24E7 / 0x124E7)
    AH = Alu.Adc8(AH, CL);
    // CMP AL,0xff (1000_24E9 / 0x124E9)
    Alu.Sub8(AL, 0xFF);
    // ADC AH,CL (1000_24EB / 0x124EB)
    AH = Alu.Adc8(AH, CL);
    // RET  (1000_24ED / 0x124ED)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2524_012524(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2524_12524:
    // SUB word ptr [0xa0],AX (1000_2524 / 0x12524)
    UInt16[DS, 0xA0] -= AX;
    // ADD word ptr [0x1172],AX (1000_2528 / 0x12528)
    // UInt16[DS, 0x1172] += AX;
    UInt16[DS, 0x1172] = Alu.Add16(UInt16[DS, 0x1172], AX);
    // RET  (1000_252C / 0x1252C)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_2566_012566(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2566_12566:
    // MOV SI,0x1008 (1000_2566 / 0x12566)
    SI = 0x1008;
    // PUSH AX (1000_2569 / 0x12569)
    Stack.Push(AX);
    // CALL 0x1000:40e6 (1000_256A / 0x1256A)
    NearCall(cs1, 0x256D, spice86_generated_label_call_target_1000_40E6_0140E6);
    // POP AX (1000_256D / 0x1256D)
    AX = Stack.Pop();
    // MOV BX,AX (1000_256E / 0x1256E)
    BX = AX;
    // CALL 0x1000:2524 (1000_2570 / 0x12570)
    NearCall(cs1, 0x2573, not_observed_1000_2524_012524);
    // MOV AX,BX (1000_2573 / 0x12573)
    AX = BX;
    // XOR DX,DX (1000_2575 / 0x12575)
    DX = 0;
    // XCHG AH,AL (1000_2577 / 0x12577)
    byte tmp_1000_2577 = AH;
    AH = AL;
    AL = tmp_1000_2577;
    // XCHG DL,AL (1000_2579 / 0x12579)
    byte tmp_1000_2579 = DL;
    DL = AL;
    AL = tmp_1000_2579;
    // DIV word ptr [0xbc] (1000_257B / 0x1257B)
    Cpu.Div16(UInt16[DS, 0xBC]);
    // CMP AX,0x200 (1000_257F / 0x1257F)
    Alu.Sub16(AX, 0x200);
    // JC 0x1000:2587 (1000_2582 / 0x12582)
    if(CarryFlag) {
      goto label_1000_2587_12587;
    }
    // MOV AX,0x1ff (1000_2584 / 0x12584)
    AX = 0x1FF;
    label_1000_2587_12587:
    // SHR AX,1 (1000_2587 / 0x12587)
    // AX >>= 0x1;
    AX = Alu.Shr16(AX, 0x1);
    // JNZ 0x1000:258d (1000_2589 / 0x12589)
    if(!ZeroFlag) {
      goto label_1000_258D_1258D;
    }
    // MOV AL,0x1 (1000_258B / 0x1258B)
    AL = 0x1;
    label_1000_258D_1258D:
    // MOV [0xbe],AL (1000_258D / 0x1258D)
    UInt8[DS, 0xBE] = AL;
    // MOV AH,0x40 (1000_2590 / 0x12590)
    AH = 0x40;
    // MOV BX,0x7 (1000_2592 / 0x12592)
    BX = 0x7;
    // CMP AL,0xc0 (1000_2595 / 0x12595)
    Alu.Sub8(AL, 0xC0);
    // JNC 0x1000:25b3 (1000_2597 / 0x12597)
    if(!CarryFlag) {
      goto label_1000_25B3_125B3;
    }
    // DEC BX (1000_2599 / 0x12599)
    BX--;
    // CMP AL,0x80 (1000_259A / 0x1259A)
    Alu.Sub8(AL, 0x80);
    // JA 0x1000:25b3 (1000_259C / 0x1259C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_25B3_125B3;
    }
    // DEC BX (1000_259E / 0x1259E)
    BX--;
    // XOR AH,AH (1000_259F / 0x1259F)
    AH = 0;
    // CMP AL,0x80 (1000_25A1 / 0x125A1)
    Alu.Sub8(AL, 0x80);
    // JZ 0x1000:25b3 (1000_25A3 / 0x125A3)
    if(ZeroFlag) {
      goto label_1000_25B3_125B3;
    }
    // DEC BX (1000_25A5 / 0x125A5)
    BX = Alu.Dec16(BX);
    // MOV AH,0x8 (1000_25A6 / 0x125A6)
    AH = 0x8;
    // TEST byte ptr [0xbf],AH (1000_25A8 / 0x125A8)
    Alu.And8(UInt8[DS, 0xBF], AH);
    // JZ 0x1000:25b3 (1000_25AC / 0x125AC)
    if(ZeroFlag) {
      goto label_1000_25B3_125B3;
    }
    // MOV byte ptr [0xbe],0x0 (1000_25AE / 0x125AE)
    UInt8[DS, 0xBE] = 0x0;
    label_1000_25B3_125B3:
    // OR AH,0x80 (1000_25B3 / 0x125B3)
    // AH |= 0x80;
    AH = Alu.Or8(AH, 0x80);
    // MOV byte ptr [0xbf],AH (1000_25B6 / 0x125B6)
    UInt8[DS, 0xBF] = AH;
    // MOV SI,0x118d (1000_25BA / 0x125BA)
    SI = 0x118D;
    // ADD word ptr [SI],BX (1000_25BD / 0x125BD)
    // UInt16[DS, SI] += BX;
    UInt16[DS, SI] = Alu.Add16(UInt16[DS, SI], BX);
    // MOV BL,byte ptr [0xc3] (1000_25BF / 0x125BF)
    BL = UInt8[DS, 0xC3];
    // SHR BL,1 (1000_25C3 / 0x125C3)
    BL >>= 0x1;
    // AND BX,0x3 (1000_25C5 / 0x125C5)
    // BX &= 0x3;
    BX = Alu.And16(BX, 0x3);
    // CALL 0x1000:e3b7 (1000_25C8 / 0x125C8)
    NearCall(cs1, 0x25CB, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // ADD word ptr [SI],AX (1000_25CB / 0x125CB)
    // UInt16[DS, SI] += AX;
    UInt16[DS, SI] = Alu.Add16(UInt16[DS, SI], AX);
    // CALL 0x1000:1ac5 (1000_25CD / 0x125CD)
    NearCall(cs1, 0x25D0, spice86_generated_label_call_target_1000_1AC5_011AC5);
    // SUB AX,word ptr [SI] (1000_25D0 / 0x125D0)
    AX -= UInt16[DS, SI];
    // NEG AX (1000_25D2 / 0x125D2)
    AX = Alu.Sub16(0, AX);
    // MOV [0xcf],AL (1000_25D4 / 0x125D4)
    UInt8[DS, 0xCF] = AL;
    // MOV word ptr [0x1158],0x0 (1000_25D7 / 0x125D7)
    UInt16[DS, 0x1158] = 0x0;
    // CALL 0x1000:2806 (1000_25DD / 0x125DD)
    NearCall(cs1, 0x25E0, not_observed_1000_2806_012806);
    // CALL 0x1000:2795 (1000_25E0 / 0x125E0)
    NearCall(cs1, 0x25E3, not_observed_1000_2795_012795);
    // CALL 0x1000:c49a (1000_25E3 / 0x125E3)
    NearCall(cs1, 0x25E6, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A);
    // MOV AX,0x2c (1000_25E6 / 0x125E6)
    AX = 0x2C;
    // CALL 0x1000:c13e (1000_25E9 / 0x125E9)
    NearCall(cs1, 0x25EC, spice86_generated_label_call_target_1000_C13E_01C13E);
    // CALL 0x1000:c0f4 (1000_25EC / 0x125EC)
    NearCall(cs1, 0x25EF, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    // MOV BP,0x2555 (1000_25EF / 0x125EF)
    BP = 0x2555;
    // MOV AL,0x8 (1000_25F2 / 0x125F2)
    AL = 0x8;
    // CALL 0x1000:c108 (1000_25F4 / 0x125F4)
    NearCall(cs1, 0x25F7, spice86_generated_label_call_target_1000_C108_01C108);
    // MOV AX,0x64 (1000_25F7 / 0x125F7)
    AX = 0x64;
    // CALL 0x1000:ddb0 (1000_25FA / 0x125FA)
    NearCall(cs1, 0x25FD, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    // MOV CX,0x18 (1000_25FD / 0x125FD)
    CX = 0x18;
    // MOV BP,0xa44 (1000_2600 / 0x12600)
    BP = 0xA44;
    // MOV AL,0x6 (1000_2603 / 0x12603)
    AL = 0x6;
    // CALL 0x1000:c108 (1000_2605 / 0x12605)
    NearCall(cs1, 0x2608, spice86_generated_label_call_target_1000_C108_01C108);
    // MOV CX,0x18 (1000_2608 / 0x12608)
    CX = 0x18;
    label_1000_260B_1260B:
    // PUSH CX (1000_260B / 0x1260B)
    Stack.Push(CX);
    // MOV BP,0xa44 (1000_260C / 0x1260C)
    BP = 0xA44;
    // MOV AX,0xc (1000_260F / 0x1260F)
    AX = 0xC;
    // DEC CX (1000_2612 / 0x12612)
    CX = Alu.Dec16(CX);
    // CALL 0x1000:e353 (1000_2613 / 0x12613)
    NearCall(cs1, 0x2616, spice86_generated_label_call_target_1000_E353_01E353);
    // POP CX (1000_2616 / 0x12616)
    CX = Stack.Pop();
    // LOOP 0x1000:260b (1000_2617 / 0x12617)
    if(--CX != 0) {
      goto label_1000_260B_1260B;
    }
    // MOV AX,0x27 (1000_2619 / 0x12619)
    AX = 0x27;
    // CALL 0x1000:ab4f (1000_261C / 0x1261C)
    NearCall(cs1, 0x261F, spice86_generated_label_call_target_1000_AB4F_01AB4F);
    // MOV SI,0x4c60 (1000_261F / 0x1261F)
    SI = 0x4C60;
    // MOV BP,0x15aa (1000_2622 / 0x12622)
    BP = 0x15AA;
    // MOV ES,word ptr [0xdbd6] (1000_2625 / 0x12625)
    ES = UInt16[DS, 0xDBD6];
    // CALLF [0x3919] (1000_2629 / 0x12629)
    // Indirect call to [0x3919], generating possible targets from emulator records
    uint targetAddress_1000_2629 = (uint)(UInt16[DS, 0x391B] * 0x10 + UInt16[DS, 0x3919] - cs1 * 0x10);
    switch(targetAddress_1000_2629) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_2629));
        break;
    }
    // MOV AX,0xc8 (1000_262D / 0x1262D)
    AX = 0xC8;
    // CALL 0x1000:ddb0 (1000_2630 / 0x12630)
    NearCall(cs1, 0x2633, spice86_generated_label_call_target_1000_DDB0_01DDB0);
    // CALL 0x1000:aba9 (1000_2633 / 0x12633)
    NearCall(cs1, 0x2636, spice86_generated_label_call_target_1000_ABA9_01ABA9);
    // MOV AL,0x1 (1000_2636 / 0x12636)
    AL = 0x1;
    // CALL 0x1000:ab15 (1000_2638 / 0x12638)
    NearCall(cs1, 0x263B, spice86_generated_label_call_target_1000_AB15_01AB15);
    // MOV CX,0x1 (1000_263B / 0x1263B)
    CX = 0x1;
    label_1000_263E_1263E:
    // PUSH CX (1000_263E / 0x1263E)
    Stack.Push(CX);
    // MOV SI,0x15b2 (1000_263F / 0x1263F)
    SI = 0x15B2;
    label_1000_2642_12642:
    // PUSH SI (1000_2642 / 0x12642)
    Stack.Push(SI);
    // MOV BP,0x26ac (1000_2643 / 0x12643)
    BP = 0x26AC;
    // MOV AX,0xc (1000_2646 / 0x12646)
    AX = 0xC;
    // CALL 0x1000:e353 (1000_2649 / 0x12649)
    NearCall(cs1, 0x264C, spice86_generated_label_call_target_1000_E353_01E353);
    // POP SI (1000_264C / 0x1264C)
    SI = Stack.Pop();
    // CMP SI,0x161e (1000_264D / 0x1264D)
    Alu.Sub16(SI, 0x161E);
    // JNZ 0x1000:2656 (1000_2651 / 0x12651)
    if(!ZeroFlag) {
      goto label_1000_2656_12656;
    }
    // CALL 0x1000:ac30 (1000_2653 / 0x12653)
    NearCall(cs1, 0x2656, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_2656_12656:
    // ADD SI,0x6 (1000_2656 / 0x12656)
    SI += 0x6;
    // CMP byte ptr [SI],0xff (1000_2659 / 0x12659)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:2642 (1000_265C / 0x1265C)
    if(!ZeroFlag) {
      goto label_1000_2642_12642;
    }
    // POP CX (1000_265E / 0x1265E)
    CX = Stack.Pop();
    // LOOP 0x1000:263e (1000_265F / 0x1265F)
    if(--CX != 0) {
      goto label_1000_263E_1263E;
    }
    // CALL 0x1000:26ac (1000_2661 / 0x12661)
    NearCall(cs1, 0x2664, not_observed_1000_26AC_0126AC);
    // XOR CX,CX (1000_2664 / 0x12664)
    CX = 0;
    label_1000_2666_12666:
    // INC CX (1000_2666 / 0x12666)
    CX = Alu.Inc16(CX);
    // PUSH CX (1000_2667 / 0x12667)
    Stack.Push(CX);
    // MOV BP,0xa44 (1000_2668 / 0x12668)
    BP = 0xA44;
    // MOV AX,0xc (1000_266B / 0x1266B)
    AX = 0xC;
    // CALL 0x1000:e353 (1000_266E / 0x1266E)
    NearCall(cs1, 0x2671, spice86_generated_label_call_target_1000_E353_01E353);
    // POP CX (1000_2671 / 0x12671)
    CX = Stack.Pop();
    // CMP CX,0x19 (1000_2672 / 0x12672)
    Alu.Sub16(CX, 0x19);
    // JC 0x1000:2666 (1000_2675 / 0x12675)
    if(CarryFlag) {
      goto label_1000_2666_12666;
    }
    // MOV byte ptr [0x47a9],0x1 (1000_2677 / 0x12677)
    UInt8[DS, 0x47A9] = 0x1;
    // MOV BP,0x2db1 (1000_267C / 0x1267C)
    BP = 0x2DB1;
    // CALL 0x1000:c097 (1000_267F / 0x1267F)
    NearCall(cs1, 0x2682, spice86_generated_label_call_target_1000_C097_01C097);
    // MOV AX,0x2c (1000_2682 / 0x12682)
    AX = 0x2C;
    // CALL 0x1000:c13e (1000_2685 / 0x12685)
    NearCall(cs1, 0x2688, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV AL,0x6 (1000_2688 / 0x12688)
    AL = 0x6;
    // MOV BP,0x2555 (1000_268A / 0x1268A)
    BP = 0x2555;
    // CALL 0x1000:c108 (1000_268D / 0x1268D)
    NearCall(cs1, 0x2690, spice86_generated_label_call_target_1000_C108_01C108);
    // MOV BP,0x2db1 (1000_2690 / 0x12690)
    BP = 0x2DB1;
    // CALL 0x1000:c097 (1000_2693 / 0x12693)
    NearCall(cs1, 0x2696, spice86_generated_label_call_target_1000_C097_01C097);
    // MOV byte ptr [0x47a9],0x0 (1000_2696 / 0x12696)
    UInt8[DS, 0x47A9] = 0x0;
    // MOV BP,0x26a6 (1000_269B / 0x1269B)
    BP = 0x26A6;
    // MOV AL,0x8 (1000_269E / 0x1269E)
    AL = 0x8;
    // CALL 0x1000:c108 (1000_26A0 / 0x126A0)
    NearCall(cs1, 0x26A3, spice86_generated_label_call_target_1000_C108_01C108);
    // JMP 0x1000:2773 (1000_26A3 / 0x126A3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_2773_012773, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_26AC_0126AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_26AC_126AC:
    // PUSH SI (1000_26AC / 0x126AC)
    Stack.Push(SI);
    // MOV BP,0x15aa (1000_26AD / 0x126AD)
    BP = 0x15AA;
    // MOV SI,0x4c60 (1000_26B0 / 0x126B0)
    SI = 0x4C60;
    // MOV ES,word ptr [0xdbd6] (1000_26B3 / 0x126B3)
    ES = UInt16[DS, 0xDBD6];
    // CALLF [0x391d] (1000_26B7 / 0x126B7)
    // Indirect call to [0x391d], generating possible targets from emulator records
    uint targetAddress_1000_26B7 = (uint)(UInt16[DS, 0x391F] * 0x10 + UInt16[DS, 0x391D] - cs1 * 0x10);
    switch(targetAddress_1000_26B7) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_26B7));
        break;
    }
    // POP SI (1000_26BB / 0x126BB)
    SI = Stack.Pop();
    // LODSW SI (1000_26BC / 0x126BC)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_26BD / 0x126BD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:26cb (1000_26BF / 0x126BF)
    if(SignFlag) {
      goto label_1000_26CB_126CB;
    }
    // MOV BX,AX (1000_26C1 / 0x126C1)
    BX = AX;
    // LODSW SI (1000_26C3 / 0x126C3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,AX (1000_26C4 / 0x126C4)
    DX = AX;
    // LODSW SI (1000_26C6 / 0x126C6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,BX (1000_26C7 / 0x126C7)
    ushort tmp_1000_26C7 = AX;
    AX = BX;
    BX = tmp_1000_26C7;
    // CALL 0x1000:c22f (1000_26C8 / 0x126C8)
    NearCall(cs1, 0x26CB, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_26CB_126CB:
    // MOV DX,0x7e (1000_26CB / 0x126CB)
    DX = 0x7E;
    // MOV BX,0x4c (1000_26CE / 0x126CE)
    BX = 0x4C;
    // MOV BP,0xc2 (1000_26D1 / 0x126D1)
    BP = 0xC2;
    // MOV AX,0x4c (1000_26D4 / 0x126D4)
    AX = 0x4C;
    // JMP 0x1000:c526 (1000_26D7 / 0x126D7)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C51E_01C51E, 0x1C526 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_26DA_0126DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
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
    NearCall(cs1, 0x2701, not_observed_1000_272F_01272F);
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
    UInt8[DS, 0xC8]++;
    // INC byte ptr [0xc9] (1000_2713 / 0x12713)
    UInt8[DS, 0xC9]++;
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
    NearCall(cs1, 0x272B, not_observed_1000_29EE_0129EE);
    label_1000_272B_1272B:
    // CALL 0x1000:e283 (1000_272B / 0x1272B)
    NearCall(cs1, 0x272E, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_272E / 0x1272E)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_272F_01272F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_272F_1272F:
    // MOV CL,byte ptr [0xc8] (1000_272F / 0x1272F)
    CL = UInt8[DS, 0xC8];
    // XOR CH,CH (1000_2733 / 0x12733)
    CH = 0;
    // JCXZ 0x1000:274d (1000_2735 / 0x12735)
    if(CX == 0) {
      // JCXZ target is RET, inlining.
      // RET  (1000_274D / 0x1274D)
      return NearRet();
    }
    // MOV SI,0x1179 (1000_2737 / 0x12737)
    SI = 0x1179;
    // DEC byte ptr [0xc8] (1000_273A / 0x1273A)
    UInt8[DS, 0xC8] = Alu.Dec8(UInt8[DS, 0xC8]);
    // MOV DI,SI (1000_273E / 0x1273E)
    DI = SI;
    // ADD SI,0x2 (1000_2740 / 0x12740)
    // SI += 0x2;
    SI = Alu.Add16(SI, 0x2);
    // PUSH DS (1000_2743 / 0x12743)
    Stack.Push(DS);
    // POP ES (1000_2744 / 0x12744)
    ES = Stack.Pop();
    // MOV CX,0x9 (1000_2745 / 0x12745)
    CX = 0x9;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_2748 / 0x12748)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // XOR AX,AX (1000_274A / 0x1274A)
    AX = 0;
    // STOSW ES:DI (1000_274C / 0x1274C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    label_1000_274D_1274D:
    // RET  (1000_274D / 0x1274D)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_274E_01274E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_274E_1274E:
    // CALL 0x1000:c08e (1000_274E / 0x1274E)
    NearCall(cs1, 0x2751, spice86_generated_label_call_target_1000_C08E_01C08E);
    // MOV AX,0x15 (1000_2751 / 0x12751)
    AX = 0x15;
    // CALL 0x1000:c13e (1000_2754 / 0x12754)
    NearCall(cs1, 0x2757, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV SI,0x14c8 (1000_2757 / 0x12757)
    SI = 0x14C8;
    // CALL 0x1000:c21b (1000_275A / 0x1275A)
    NearCall(cs1, 0x275D, spice86_generated_label_call_target_1000_C21B_01C21B);
    // MOV AL,0x1 (1000_275D / 0x1275D)
    AL = 0x1;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(not_observed_1000_275F_01275F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_275F_01275F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_275F_1275F:
    // CALL 0x1000:c08e (1000_275F / 0x1275F)
    NearCall(cs1, 0x2762, spice86_generated_label_call_target_1000_C08E_01C08E);
    // AND AX,0x7 (1000_2762 / 0x12762)
    AX &= 0x7;
    // ADD AL,0xb (1000_2765 / 0x12765)
    // AL += 0xB;
    AL = Alu.Add8(AL, 0xB);
    // MOV BX,0x56 (1000_2767 / 0x12767)
    BX = 0x56;
    // MOV DX,0x64 (1000_276A / 0x1276A)
    DX = 0x64;
    // CALL 0x1000:c22f (1000_276D / 0x1276D)
    NearCall(cs1, 0x2770, spice86_generated_label_call_target_1000_C22F_01C22F);
    // JMP 0x1000:c07c (1000_2770 / 0x12770)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2773_012773(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2773_12773:
    // MOV AX,0x15 (1000_2773 / 0x12773)
    AX = 0x15;
    // CALL 0x1000:c13e (1000_2776 / 0x12776)
    NearCall(cs1, 0x2779, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV AL,0x9 (1000_2779 / 0x12779)
    AL = 0x9;
    // CALL 0x1000:ab15 (1000_277B / 0x1277B)
    NearCall(cs1, 0x277E, spice86_generated_label_call_target_1000_AB15_01AB15);
    // MOV word ptr [0xd816],0x4 (1000_277E / 0x1277E)
    UInt16[DS, 0xD816] = 0x4;
    label_1000_2784_12784:
    // MOV BP,0x27b6 (1000_2784 / 0x12784)
    BP = 0x27B6;
    // MOV AX,0x9 (1000_2787 / 0x12787)
    AX = 0x9;
    // CALL 0x1000:e353 (1000_278A / 0x1278A)
    NearCall(cs1, 0x278D, spice86_generated_label_call_target_1000_E353_01E353);
    // DEC word ptr [0xd816] (1000_278D / 0x1278D)
    UInt16[DS, 0xD816] = Alu.Dec16(UInt16[DS, 0xD816]);
    // JNS 0x1000:2784 (1000_2791 / 0x12791)
    if(!SignFlag) {
      goto label_1000_2784_12784;
    }
    // JMP 0x1000:274e (1000_2793 / 0x12793)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_274E_01274E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2795_012795(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2795_12795:
    // MOV AX,0x15 (1000_2795 / 0x12795)
    AX = 0x15;
    // CALL 0x1000:c13e (1000_2798 / 0x12798)
    NearCall(cs1, 0x279B, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV word ptr [0xd816],0x0 (1000_279B / 0x1279B)
    UInt16[DS, 0xD816] = 0x0;
    label_1000_27A1_127A1:
    // MOV BP,0x27b6 (1000_27A1 / 0x127A1)
    BP = 0x27B6;
    // MOV AX,0x9 (1000_27A4 / 0x127A4)
    AX = 0x9;
    // CALL 0x1000:e353 (1000_27A7 / 0x127A7)
    NearCall(cs1, 0x27AA, spice86_generated_label_call_target_1000_E353_01E353);
    // INC word ptr [0xd816] (1000_27AA / 0x127AA)
    UInt16[DS, 0xD816]++;
    // CMP word ptr [0xd816],0xd (1000_27AE / 0x127AE)
    Alu.Sub16(UInt16[DS, 0xD816], 0xD);
    // JC 0x1000:27a1 (1000_27B3 / 0x127B3)
    if(CarryFlag) {
      goto label_1000_27A1_127A1;
    }
    // RET  (1000_27B5 / 0x127B5)
    return NearRet();
  }
  
  public virtual Action not_observed_1000_27C9_0127C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_27C9_127C9:
    // CALL 0x1000:c08e (1000_27C9 / 0x127C9)
    NearCall(cs1, 0x27CC, spice86_generated_label_call_target_1000_C08E_01C08E);
    // MOV BX,0x67 (1000_27CC / 0x127CC)
    BX = 0x67;
    label_1000_27CF_127CF:
    // PUSH BX (1000_27CF / 0x127CF)
    Stack.Push(BX);
    // MOV BX,0xf (1000_27D0 / 0x127D0)
    BX = 0xF;
    label_1000_27D3_127D3:
    // CALL 0x1000:e3b7 (1000_27D3 / 0x127D3)
    NearCall(cs1, 0x27D6, spice86_generated_label_call_target_1000_E3B7_01E3B7);
    // CMP AL,DL (1000_27D6 / 0x127D6)
    Alu.Sub8(AL, DL);
    // JZ 0x1000:27d3 (1000_27D8 / 0x127D8)
    if(ZeroFlag) {
      goto label_1000_27D3_127D3;
    }
    // MOV DL,AL (1000_27DA / 0x127DA)
    DL = AL;
    // ADD AX,0x17 (1000_27DC / 0x127DC)
    // AX += 0x17;
    AX = Alu.Add16(AX, 0x17);
    // POP BX (1000_27DF / 0x127DF)
    BX = Stack.Pop();
    // PUSH DX (1000_27E0 / 0x127E0)
    Stack.Push(DX);
    // MOV DX,0xa3 (1000_27E1 / 0x127E1)
    DX = 0xA3;
    // CALL 0x1000:c2fd (1000_27E4 / 0x127E4)
    NearCall(cs1, 0x27E7, spice86_generated_label_call_target_1000_C2FD_01C2FD);
    // POP DX (1000_27E7 / 0x127E7)
    DX = Stack.Pop();
    // ADD BX,0x3 (1000_27E8 / 0x127E8)
    BX += 0x3;
    // CMP BX,0x70 (1000_27EB / 0x127EB)
    Alu.Sub16(BX, 0x70);
    // JBE 0x1000:27cf (1000_27EE / 0x127EE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_27CF_127CF;
    }
    // MOV SI,0x14ce (1000_27F0 / 0x127F0)
    SI = 0x14CE;
    // MOV AX,[0xd816] (1000_27F3 / 0x127F3)
    AX = UInt16[DS, 0xD816];
    // AND AX,0x3 (1000_27F6 / 0x127F6)
    AX &= 0x3;
    // ADD AL,0x13 (1000_27F9 / 0x127F9)
    // AL += 0x13;
    AL = Alu.Add8(AL, 0x13);
    // MOV byte ptr [SI],AL (1000_27FB / 0x127FB)
    UInt8[DS, SI] = AL;
    // MOV byte ptr [SI + 0x6],AL (1000_27FD / 0x127FD)
    UInt8[DS, (ushort)(SI + 0x6)] = AL;
    // CALL 0x1000:c21b (1000_2800 / 0x12800)
    NearCall(cs1, 0x2803, spice86_generated_label_call_target_1000_C21B_01C21B);
    // JMP 0x1000:c07c (1000_2803 / 0x12803)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C07C_01C07C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_2806_012806(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2806_12806:
    // CALL 0x1000:274e (1000_2806 / 0x12806)
    NearCall(cs1, 0x2809, not_observed_1000_274E_01274E);
    // MOV AL,0x2 (1000_2809 / 0x12809)
    AL = 0x2;
    // CALL 0x1000:275f (1000_280B / 0x1280B)
    NearCall(cs1, 0x280E, not_observed_1000_275F_01275F);
    // MOV CX,0x14 (1000_280E / 0x1280E)
    CX = 0x14;
    // CALL 0x1000:281c (1000_2811 / 0x12811)
    NearCall(cs1, 0x2814, not_observed_1000_281C_01281C);
    // CALL 0x1000:aba9 (1000_2814 / 0x12814)
    NearCall(cs1, 0x2817, spice86_generated_label_call_target_1000_ABA9_01ABA9);
    // MOV AL,0x1 (1000_2817 / 0x12817)
    AL = 0x1;
    // JMP 0x1000:275f (1000_2819 / 0x12819)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(not_observed_1000_275F_01275F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action not_observed_1000_281C_01281C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_281C_1281C:
    // MOV AX,0x15 (1000_281C / 0x1281C)
    AX = 0x15;
    // CALL 0x1000:c13e (1000_281F / 0x1281F)
    NearCall(cs1, 0x2822, spice86_generated_label_call_target_1000_C13E_01C13E);
    // MOV word ptr [0xd816],0x0 (1000_2822 / 0x12822)
    UInt16[DS, 0xD816] = 0x0;
    label_1000_2828_12828:
    // PUSH CX (1000_2828 / 0x12828)
    Stack.Push(CX);
    // CALL 0x1000:27c9 (1000_2829 / 0x12829)
    NearCall(cs1, 0x282C, not_observed_1000_27C9_0127C9);
    // MOV AX,0x9 (1000_282C / 0x1282C)
    AX = 0x9;
    // CALL 0x1000:e3a0 (1000_282F / 0x1282F)
    NearCall(cs1, 0x2832, spice86_generated_label_call_target_1000_E3A0_01E3A0);
    // INC word ptr [0xd816] (1000_2832 / 0x12832)
    UInt16[DS, 0xD816] = Alu.Inc16(UInt16[DS, 0xD816]);
    // POP CX (1000_2836 / 0x12836)
    CX = Stack.Pop();
    // LOOP 0x1000:2828 (1000_2837 / 0x12837)
    if(--CX != 0) {
      goto label_1000_2828_12828;
    }
    // RET  (1000_2839 / 0x12839)
    return NearRet();
  }
  
}
