namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

  public Action spice86_generated_label_call_target_1000_E675_01E675(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0xE674: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_E674_1E674:
    // RET  (1000_E674 / 0x1E674)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    return NearRet();
    entry:
    label_1000_E675_1E675:
    // MOV DX,0x37f2 (1000_E675 / 0x1E675)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    DX = 0x37F2;
    // CALL 0x1000:f1fb (1000_E678 / 0x1E678)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE67B, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    label_1000_E67B_1E67B:
    // JC 0x1000:e692 (1000_E67B / 0x1E67B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E692_1E692;
    }
    // LES DI,[0x39b7] (1000_E67D / 0x1E67D)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    // CALL 0x1000:f260 (1000_E681 / 0x1E681)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE684, read_ffff_to_esdi_and_close_ida_1000_F260_1F260);
    // CMP word ptr ES:[DI],0xc089 (1000_E684 / 0x1E684)
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(UInt16[ES, DI], 0xC089);
    // JNZ 0x1000:e692 (1000_E689 / 0x1E689)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(!ZeroFlag) {
      goto label_1000_E692_1E692;
    }
    // MOV DX,0x31ff (1000_E68B / 0x1E68B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX = 0x31FF;
    // CALLF [0x39b7] (1000_E68E / 0x1E68E)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // Indirect call to [0x39b7], generating possible targets from emulator records
    uint targetAddress_1000_E68E = (uint)(UInt16[DS, 0x39B9] * 0x10 + UInt16[DS, 0x39B7] - cs1 * 0x10);
    switch(targetAddress_1000_E68E) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E68E));
        break;
    }
    label_1000_E692_1E692:
    // MOV SI,0x37f7 (1000_E692 / 0x1E692)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    SI = 0x37F7;
    // INC byte ptr [SI] (1000_E695 / 0x1E695)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, SI] = Alu.Inc8(UInt8[DS, SI]);
    // CMP byte ptr [SI],0x39 (1000_E697 / 0x1E697)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(UInt8[DS, SI], 0x39);
    // JBE 0x1000:e675 (1000_E69A / 0x1E69A)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag || ZeroFlag) {
      goto label_1000_E675_1E675;
    }
    // MOV DX,0x37e9 (1000_E69C / 0x1E69C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    DX = 0x37E9;
    // MOV AX,0x3d00 (1000_E69F / 0x1E69F)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x3D00;
    // INT 0x21 (1000_E6A2 / 0x1E6A2)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    Interrupt(0x21);
    // JC 0x1000:e674 (1000_E6A4 / 0x1E6A4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_E674 / 0x1E674)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      return NearRet();
    }
    // MOV [0xdbba],AX (1000_E6A6 / 0x1E6A6)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBBA] = AX;
    // CALL 0x1000:e741 (1000_E6A9 / 0x1E6A9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE6AC, spice86_generated_label_call_target_1000_E741_01E741);
    label_1000_E6AC_1E6AC:
    // MOV SI,DI (1000_E6AC / 0x1E6AC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    SI = DI;
    // MOV BP,ES (1000_E6AE / 0x1E6AE)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    BP = ES;
    // LES DI,[0x39b7] (1000_E6B0 / 0x1E6B0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    // MOV word ptr [0xdbbc],DI (1000_E6B4 / 0x1E6B4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBBC] = DI;
    // MOV word ptr [0xdbbe],ES (1000_E6B8 / 0x1E6B8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBBE] = ES;
    // MOV AX,0x145 (1000_E6BC / 0x1E6BC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = 0x145;
    // STOSW ES:DI (1000_E6BF / 0x1E6BF)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV CX,0x14d (1000_E6C0 / 0x1E6C0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    CX = 0x14D;
    // MOV AL,0xff (1000_E6C3 / 0x1E6C3)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AL = 0xFF;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_E6C5 / 0x1E6C5)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // MOV word ptr [0xd820],DI (1000_E6C7 / 0x1E6C7)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xD820] = DI;
    // PUSH DS (1000_E6CB / 0x1E6CB)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(DS);
    // MOV DS,BP (1000_E6CC / 0x1E6CC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    DS = BP;
    // LODSW SI (1000_E6CE / 0x1E6CE)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    label_1000_E6CF_1E6CF:
    // PUSH SI (1000_E6CF / 0x1E6CF)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(SI);
    // CALL 0x1000:f314 (1000_E6D0 / 0x1E6D0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE6D3, spice86_generated_label_call_target_1000_F314_01F314);
    label_1000_E6D3_1E6D3:
    // POP SI (1000_E6D3 / 0x1E6D3)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    SI = Stack.Pop();
    // JC 0x1000:e702 (1000_E6D4 / 0x1E6D4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag) {
      goto label_1000_E702_1E702;
    }
    // CALL 0x1000:f3a7 (1000_E6D6 / 0x1E6D6)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE6D9, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    label_1000_E6D9_1E6D9:
    // JZ 0x1000:e6f9 (1000_E6D9 / 0x1E6D9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      goto label_1000_E6F9_1E6F9;
    }
    // PUSH AX (1000_E6DB / 0x1E6DB)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(AX);
    // PUSH DX (1000_E6DC / 0x1E6DC)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    Stack.Push(DX);
    // PUSH SI (1000_E6DD / 0x1E6DD)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    Stack.Push(SI);
    // PUSH DI (1000_E6DE / 0x1E6DE)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(DI);
    // MOV CX,word ptr SS:[0xd820] (1000_E6DF / 0x1E6DF)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 3, 4 modified by those instruction(s): 1000_49F8_149F8
    CX = UInt16[SS, 0xD820];
    // MOV SI,CX (1000_E6E4 / 0x1E6E4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    SI = CX;
    // SUB CX,DI (1000_E6E6 / 0x1E6E6)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    CX -= DI;
    
    // SUB SI,0x2 (1000_E6E8 / 0x1E6E8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    // SI -= 0x2;
    SI = Alu.Sub16(SI, 0x2);
    // LEA DI,[SI + 0xa] (1000_E6EB / 0x1E6EB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DI = (ushort)(SI + 0xA);
    // SHR CX,0x1 (1000_E6EE / 0x1E6EE)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // STD  (1000_E6F0 / 0x1E6F0)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    DirectionFlag = true;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,ES:SI (1000_E6F1 / 0x1E6F1)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
      UInt16[ES, DI] = UInt16[ES, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // CLD  (1000_E6F4 / 0x1E6F4)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    DirectionFlag = false;
    // POP DI (1000_E6F5 / 0x1E6F5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    DI = Stack.Pop();
    // POP SI (1000_E6F6 / 0x1E6F6)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    SI = Stack.Pop();
    // POP DX (1000_E6F7 / 0x1E6F7)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX = Stack.Pop();
    // POP AX (1000_E6F8 / 0x1E6F8)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    AX = Stack.Pop();
    label_1000_E6F9_1E6F9:
    // CALL 0x1000:e75b (1000_E6F9 / 0x1E6F9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE6FC, spice86_generated_label_call_target_1000_E75B_01E75B);
    label_1000_E6FC_1E6FC:
    // ADD word ptr SS:[0xd820],0xa (1000_E6FC / 0x1E6FC)
    // Instruction bytes at index 0, 1, 4, 5 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[SS, 0xD820] += 0xA;
    
    label_1000_E702_1E702:
    // ADD SI,0x19 (1000_E702 / 0x1E702)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    SI += 0x19;
    
    // CMP byte ptr [SI],0x0 (1000_E705 / 0x1E705)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub8(UInt8[DS, SI], 0x0);
    // JNZ 0x1000:e6cf (1000_E708 / 0x1E708)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(!ZeroFlag) {
      goto label_1000_E6CF_1E6CF;
    }
    // POP DS (1000_E70A / 0x1E70A)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DS = Stack.Pop();
    // MOV SI,0x145 (1000_E70B / 0x1E70B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    SI = 0x145;
    // MOV AX,[0xd820] (1000_E70E / 0x1E70E)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0xD820];
    // SUB AX,SI (1000_E711 / 0x1E711)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    AX -= SI;
    
    // XOR DX,DX (1000_E713 / 0x1E713)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX = 0;
    // MOV CX,0x280 (1000_E715 / 0x1E715)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    CX = 0x280;
    // DIV CX (1000_E718 / 0x1E718)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    Cpu.Div16(CX);
    // MOV DX,0xa (1000_E71A / 0x1E71A)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    DX = 0xA;
    // MUL DX (1000_E71D / 0x1E71D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    Cpu.Mul16(DX);
    // MOV DX,AX (1000_E71F / 0x1E71F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX = AX;
    // LES DI,SS:[0xdbbc] (1000_E721 / 0x1E721)
    // Instruction bytes at index 0, 3, 4 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    ES = UInt16[SS, 0xDBBE];
    DI = UInt16[SS, 0xDBBC];
    // ADD DI,0x2 (1000_E726 / 0x1E726)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    DI += 0x2;
    
    label_1000_E729_1E729:
    // ADD SI,DX (1000_E729 / 0x1E729)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    // SI += DX;
    SI = Alu.Add16(SI, DX);
    // PUSH SI (1000_E72B / 0x1E72B)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(SI);
    // MOVSW ES:DI,ES:SI (1000_E72C / 0x1E72C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    UInt16[ES, DI] = UInt16[ES, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSB ES:DI,ES:SI (1000_E72E / 0x1E72E)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt8[ES, DI] = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // POP SI (1000_E730 / 0x1E730)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    SI = Stack.Pop();
    // MOV AX,SI (1000_E731 / 0x1E731)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    AX = SI;
    // STOSW ES:DI (1000_E733 / 0x1E733)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // CMP DI,0x140 (1000_E734 / 0x1E734)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(DI, 0x140);
    // JC 0x1000:e729 (1000_E738 / 0x1E738)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag) {
      goto label_1000_E729_1E729;
    }
    // MOV CX,word ptr [0xd820] (1000_E73A / 0x1E73A)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    CX = UInt16[DS, 0xD820];
    // JMP 0x1000:f0ff (1000_E73E / 0x1E73E)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_E741_01E741(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E741_1E741:
    // XOR AX,AX (1000_E741 / 0x1E741)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    AX = 0;
    // XOR DX,DX (1000_E743 / 0x1E743)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DX = 0;
    // CALL 0x1000:f2d6 (1000_E745 / 0x1E745)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE748, spice86_generated_label_call_target_1000_F2D6_01F2D6);
    label_1000_E748_1E748:
    // MOV AX,[0x39b9] (1000_E748 / 0x1E748)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x39B9];
    // ADD AX,0x800 (1000_E74B / 0x1E74B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // AX += 0x800;
    AX = Alu.Add16(AX, 0x800);
    // MOV ES,AX (1000_E74E / 0x1E74E)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    ES = AX;
    // XOR DI,DI (1000_E750 / 0x1E750)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    DI = 0;
    // MOV CX,0xffff (1000_E752 / 0x1E752)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    CX = 0xFFFF;
    // CALL 0x1000:f2ea (1000_E755 / 0x1E755)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE758, spice86_generated_label_call_target_1000_F2EA_01F2EA);
    label_1000_E758_1E758:
    // JC 0x1000:e741 (1000_E758 / 0x1E758)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(CarryFlag) {
      goto label_1000_E741_1E741;
    }
    // RET  (1000_E75A / 0x1E75A)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E75B_01E75B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E75B_1E75B:
    // PUSH SI (1000_E75B / 0x1E75B)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(SI);
    // STOSW ES:DI (1000_E75C / 0x1E75C)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // MOV AL,DL (1000_E75D / 0x1E75D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    AL = DL;
    // STOSB ES:DI (1000_E75F / 0x1E75F)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt8[ES, DI] = AL;
    DI = (ushort)(DI + Direction8);
    // ADD SI,0x10 (1000_E760 / 0x1E760)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    // SI += 0x10;
    SI = Alu.Add16(SI, 0x10);
    // MOVSW ES:DI,SI (1000_E763 / 0x1E763)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSB ES:DI,SI (1000_E764 / 0x1E764)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    UInt8[ES, DI] = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    // INC SI (1000_E765 / 0x1E765)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    SI = Alu.Inc16(SI);
    // MOVSW ES:DI,SI (1000_E766 / 0x1E766)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // MOVSW ES:DI,SI (1000_E767 / 0x1E767)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[ES, DI] = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    // POP SI (1000_E768 / 0x1E768)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    SI = Stack.Pop();
    // RET  (1000_E769 / 0x1E769)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E76A_01E76A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E76A_1E76A:
    // MOV AL,[0x2944] (1000_E76A / 0x1E76A)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AL = UInt8[DS, 0x2944];
    // MOV CL,0x4 (1000_E76D / 0x1E76D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    CL = 0x4;
    // SHR AL,CL (1000_E76F / 0x1E76F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AL >>= CL;
    
    // ADD AL,0x7 (1000_E771 / 0x1E771)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    AL += 0x7;
    
    // XOR AH,AH (1000_E773 / 0x1E773)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AH = 0;
    // MOV SI,0x398b (1000_E775 / 0x1E775)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    SI = 0x398B;
    // MOV CX,0x8 (1000_E778 / 0x1E778)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    CX = 0x8;
    // CALL 0x1000:e57b (1000_E77B / 0x1E77B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE77E, spice86_generated_label_call_target_1000_E57B_01E57B);
    label_1000_E77E_1E77E:
    // MOV AX,[0x39b5] (1000_E77E / 0x1E77E)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x39B5];
    // CALLF [0x3989] (1000_E781 / 0x1E781)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // Indirect call to [0x3989], generating possible targets from emulator records
    uint targetAddress_1000_E781 = (uint)(UInt16[DS, 0x398B] * 0x10 + UInt16[DS, 0x3989] - cs1 * 0x10);
    switch(targetAddress_1000_E781) {
      case 0x46450 : FarCall(cs1, 0xE785, spice86_generated_label_call_target_5635_0100_056450); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E781));
        break;
    }
    label_1000_E785_1E785:
    // MOV word ptr [0xdbc8],BX (1000_E785 / 0x1E785)
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBC8] = BX;
    // CALL 0x1000:a637 (1000_E789 / 0x1E789)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE78C, spice86_generated_label_call_target_1000_A637_01A637);
    label_1000_E78C_1E78C:
    // CALL 0x1000:ae54 (1000_E78C / 0x1E78C)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE78F, spice86_generated_label_call_target_1000_AE54_01AE54);
    label_1000_E78F_1E78F:
    // CALL 0x1000:e851 (1000_E78F / 0x1E78F)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE792, spice86_generated_label_call_target_1000_E851_01E851);
    label_1000_E792_1E792:
    // JC 0x1000:e7bc (1000_E792 / 0x1E792)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E7BC_1E7BC;
    }
    // TEST byte ptr [0x2944],0xf0 (1000_E794 / 0x1E794)
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    Alu.And8(UInt8[DS, 0x2944], 0xF0);
    // JZ 0x1000:e7b9 (1000_E799 / 0x1E799)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [0x2944],0xf (1000_E79B / 0x1E79B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 3, 4 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0x2944] &= 0xF;
    
    // XOR AX,AX (1000_E7A0 / 0x1E7A0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    AX = 0;
    // MOV [0x3813],AX (1000_E7A2 / 0x1E7A2)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0x3813] = AX;
    // MOV [0xdbc8],AL (1000_E7A5 / 0x1E7A5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0xDBC8] = AL;
    // MOV AX,[0x398b] (1000_E7A8 / 0x1E7A8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x398B];
    // ADD AX,0x10 (1000_E7AB / 0x1E7AB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    // MOV [0x39b9],AX (1000_E7AE / 0x1E7AE)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0x39B9] = AX;
    // MOV word ptr [0x3cbc],0x3624 (1000_E7B1 / 0x1E7B1)
    // Instruction bytes at index 0, 3, 4 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2, 5 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0x3CBC] = 0x3624;
    // JMP 0x1000:e76a (1000_E7B7 / 0x1E7B7)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    goto label_1000_E76A_1E76A;
    label_1000_E7B9_1E7B9:
    // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_F131_01F131, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_E7BC_1E7BC:
    // MOV AX,[0x3813] (1000_E7BC / 0x1E7BC)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x3813];
    // MOV [0x381b],AX (1000_E7BF / 0x1E7BF)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0x381B] = AX;
    // CALL 0x1000:a87e (1000_E7C2 / 0x1E7C2)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE7C5, spice86_generated_label_call_target_1000_A87E_01A87E);
    label_1000_E7C5_1E7C5:
    // MOV AL,[0x2944] (1000_E7C5 / 0x1E7C5)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    AL = UInt8[DS, 0x2944];
    // AND AX,0xf (1000_E7C8 / 0x1E7C8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX &= 0xF;
    
    // ADD AX,0x2 (1000_E7CB / 0x1E7CB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    // AX += 0x2;
    AX = Alu.Add16(AX, 0x2);
    // MOV SI,0x396f (1000_E7CE / 0x1E7CE)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    SI = 0x396F;
    // MOV CX,0x7 (1000_E7D1 / 0x1E7D1)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    CX = 0x7;
    // CALL 0x1000:e57b (1000_E7D4 / 0x1E7D4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE7D7, spice86_generated_label_call_target_1000_E57B_01E57B);
    label_1000_E7D7_1E7D7:
    // MOV BP,0x3349 (1000_E7D7 / 0x1E7D7)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    BP = 0x3349;
    // MOV CX,0xa (1000_E7DA / 0x1E7DA)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    CX = 0xA;
    // MOV AX,[0x39b3] (1000_E7DD / 0x1E7DD)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x39B3];
    // CALLF [0x396d] (1000_E7E0 / 0x1E7E0)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    // Indirect call to [0x396d], generating possible targets from emulator records
    uint targetAddress_1000_E7E0 = (uint)(UInt16[DS, 0x396F] * 0x10 + UInt16[DS, 0x396D] - cs1 * 0x10);
    switch(targetAddress_1000_E7E0) {
      case 0x464E0 : FarCall(cs1, 0xE7E4, spice86_generated_label_call_target_563E_0100_0564E0); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_E7E0));
        break;
    }
    label_1000_E7E4_1E7E4:
    // OR word ptr [0xdbc8],BX (1000_E7E4 / 0x1E7E4)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    // UInt16[DS, 0xDBC8] |= BX;
    UInt16[DS, 0xDBC8] = Alu.Or16(UInt16[DS, 0xDBC8], BX);
    // CALL 0x1000:a650 (1000_E7E8 / 0x1E7E8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE7EB, spice86_generated_label_call_target_1000_A650_01A650);
    label_1000_E7EB_1E7EB:
    // CALL 0x1000:ae3f (1000_E7EB / 0x1E7EB)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE7EE, spice86_generated_label_call_target_1000_AE3F_01AE3F);
    label_1000_E7EE_1E7EE:
    // CALL 0x1000:e851 (1000_E7EE / 0x1E7EE)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE7F1, spice86_generated_label_call_target_1000_E851_01E851);
    label_1000_E7F1_1E7F1:
    // JC 0x1000:e818 (1000_E7F1 / 0x1E7F1)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E818_1E818;
    }
    // TEST byte ptr [0x2944],0xf (1000_E7F3 / 0x1E7F3)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 3, 4 modified by those instruction(s): 1000_49F8_149F8
    Alu.And8(UInt8[DS, 0x2944], 0xF);
    // JZ 0x1000:e7b9 (1000_E7F8 / 0x1E7F8)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      // JMP 0x1000:f131 (1000_E7B9 / 0x1E7B9)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // AND byte ptr [0x2944],0xf0 (1000_E7FA / 0x1E7FA)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0x2944] &= 0xF0;
    
    // XOR AX,AX (1000_E7FF / 0x1E7FF)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = 0;
    // MOV [0xdbb8],AX (1000_E801 / 0x1E801)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0xDBB8] = AX;
    // MOV [0xdbc9],AL (1000_E804 / 0x1E804)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    UInt8[DS, 0xDBC9] = AL;
    // MOV AX,[0x396f] (1000_E807 / 0x1E807)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x396F];
    // ADD AX,0x10 (1000_E80A / 0x1E80A)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    // AX += 0x10;
    AX = Alu.Add16(AX, 0x10);
    // MOV [0x39b9],AX (1000_E80D / 0x1E80D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0x39B9] = AX;
    // MOV word ptr [0x3cbc],0x364b (1000_E810 / 0x1E810)
    // Instruction bytes at index 0, 1, 4, 5 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    UInt16[DS, 0x3CBC] = 0x364B;
    // JMP 0x1000:e7c5 (1000_E816 / 0x1E816)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    goto label_1000_E7C5_1E7C5;
    label_1000_E818_1E818:
    // CALL 0x1000:ae28 (1000_E818 / 0x1E818)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE81B, spice86_generated_label_call_target_1000_AE28_01AE28);
    label_1000_E81B_1E81B:
    // JZ 0x1000:e825 (1000_E81B / 0x1E81B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E825 / 0x1E825)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      return NearRet();
    }
    // CALL 0x1000:e826 (1000_E81D / 0x1E81D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE820, spice86_generated_label_call_target_1000_E826_01E826);
    label_1000_E820_1E820:
    // AND byte ptr [0x2943],0xef (1000_E820 / 0x1E820)
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F8_149F8
    // UInt8[DS, 0x2943] &= 0xEF;
    UInt8[DS, 0x2943] = Alu.And8(UInt8[DS, 0x2943], 0xEF);
    label_1000_E825_1E825:
    // RET  (1000_E825 / 0x1E825)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E826_01E826(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E826_1E826:
    // CMP word ptr [0xdbba],0x0 (1000_E826 / 0x1E826)
    // Instruction bytes at index 2, 3 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1, 4 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(UInt16[DS, 0xDBBA], 0x0);
    // JZ 0x1000:e850 (1000_E82B / 0x1E82B)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E850 / 0x1E850)
      // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
      return NearRet();
    }
    // CALL 0x1000:e741 (1000_E82D / 0x1E82D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE830, spice86_generated_label_call_target_1000_E741_01E741);
    label_1000_E830_1E830:
    // PUSH DS (1000_E830 / 0x1E830)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    Stack.Push(DS);
    // MOV SI,DI (1000_E831 / 0x1E831)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    SI = DI;
    // PUSH ES (1000_E833 / 0x1E833)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(ES);
    // POP DS (1000_E834 / 0x1E834)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    DS = Stack.Pop();
    // LODSW SI (1000_E835 / 0x1E835)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV CX,0xfa (1000_E836 / 0x1E836)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    CX = 0xFA;
    label_1000_E839_1E839:
    // PUSH CX (1000_E839 / 0x1E839)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    Stack.Push(CX);
    // PUSH SI (1000_E83A / 0x1E83A)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    Stack.Push(SI);
    // CALL 0x1000:f314 (1000_E83B / 0x1E83B)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE83E, spice86_generated_label_call_target_1000_F314_01F314);
    label_1000_E83E_1E83E:
    // POP SI (1000_E83E / 0x1E83E)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    SI = Stack.Pop();
    // JC 0x1000:e849 (1000_E83F / 0x1E83F)
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    if(CarryFlag) {
      goto label_1000_E849_1E849;
    }
    // CALL 0x1000:f3a7 (1000_E841 / 0x1E841)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE844, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    label_1000_E844_1E844:
    // JNZ 0x1000:e849 (1000_E844 / 0x1E844)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    if(!ZeroFlag) {
      goto label_1000_E849_1E849;
    }
    // CALL 0x1000:e75b (1000_E846 / 0x1E846)
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F8_149F8
    NearCall(cs1, 0xE849, spice86_generated_label_call_target_1000_E75B_01E75B);
    label_1000_E849_1E849:
    // ADD SI,0x19 (1000_E849 / 0x1E849)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    // SI += 0x19;
    SI = Alu.Add16(SI, 0x19);
    // POP CX (1000_E84C / 0x1E84C)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    CX = Stack.Pop();
    // LOOP 0x1000:e839 (1000_E84D / 0x1E84D)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1 modified by those instruction(s): 1000_49F8_149F8
    if(--CX != 0) {
      goto label_1000_E839_1E839;
    }
    // POP DS (1000_E84F / 0x1E84F)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    DS = Stack.Pop();
    label_1000_E850_1E850:
    // RET  (1000_E850 / 0x1E850)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E851_01E851(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E851_1E851:
    // MOV AX,[0x39b9] (1000_E851 / 0x1E851)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F8_149F8
    AX = UInt16[DS, 0x39B9];
    // ADD AX,0x2f13 (1000_E854 / 0x1E854)
    // Instruction bytes at index 0, 1 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 2 modified by those instruction(s): 1000_49F8_149F8
    AX += 0x2F13;
    
    // CMP AX,word ptr [0xce68] (1000_E857 / 0x1E857)
    // Instruction bytes at index 1, 2 modified by those instruction(s): 1000_49F7_149F7
    // Instruction bytes at index 0, 3 modified by those instruction(s): 1000_49F8_149F8
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    // RET  (1000_E85B / 0x1E85B)
    // Instruction bytes at index 0 modified by those instruction(s): 1000_49F8_149F8
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E85C_01E85C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E85C_1E85C:
    // CLI  (1000_E85C / 0x1E85C)
    InterruptFlag = false;
    // CALL 0x1000:e913 (1000_E85D / 0x1E85D)
    NearCall(cs1, 0xE860, spice86_generated_label_call_target_1000_E913_01E913);
    label_1000_E860_1E860:
    // XOR AX,AX (1000_E860 / 0x1E860)
    AX = 0;
    // MOV ES,AX (1000_E862 / 0x1E862)
    ES = AX;
    // MOV DI,0x20 (1000_E864 / 0x1E864)
    DI = 0x20;
    // MOV word ptr ES:[DI],0xe8b8 (1000_E867 / 0x1E867)
    UInt16[ES, DI] = 0xE8B8;
    // PUSHF  (1000_E86C / 0x1E86C)
    Stack.Push(FlagRegister);
    // STI  (1000_E86D / 0x1E86D)
    InterruptFlag = true;
    label_1000_E86E_1E86E:
    CheckExternalEvents(cs1, 0xE874);
    // CMP byte ptr CS:[0xe8d4],0x0 (1000_E86E / 0x1E86E)
    Alu.Sub8(UInt8[cs1, 0xE8D4], 0x0);
    // JZ 0x1000:e86e (1000_E874 / 0x1E874)
    if(ZeroFlag) {
      goto label_1000_E86E_1E86E;
    }
    // POPF  (1000_E876 / 0x1E876)
    FlagRegister = Stack.Pop();
    // MOV word ptr ES:[DI],0xef6a (1000_E877 / 0x1E877)
    UInt16[ES, DI] = 0xEF6A;
    // MOV AX,CS:[0xe8d2] (1000_E87C / 0x1E87C)
    AX = UInt16[cs1, 0xE8D2];
    // OR AH,AH (1000_E880 / 0x1E880)
    // AH |= AH;
    AH = Alu.Or8(AH, AH);
    // JZ 0x1000:e8a5 (1000_E882 / 0x1E882)
    if(ZeroFlag) {
      goto label_1000_E8A5_1E8A5;
    }
    // OR AL,AL (1000_E884 / 0x1E884)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:e8a5 (1000_E886 / 0x1E886)
    if(ZeroFlag) {
      goto label_1000_E8A5_1E8A5;
    }
    // XOR DX,DX (1000_E888 / 0x1E888)
    DX = 0;
    // MOV CX,0x1745 (1000_E88A / 0x1E88A)
    CX = 0x1745;
    // DIV CX (1000_E88D / 0x1E88D)
    Cpu.Div16(CX);
    // SHL DX,0x1 (1000_E88F / 0x1E88F)
    DX <<= 0x1;
    
    // CMP DX,CX (1000_E891 / 0x1E891)
    Alu.Sub16(DX, CX);
    // JC 0x1000:e896 (1000_E893 / 0x1E893)
    if(CarryFlag) {
      goto label_1000_E896_1E896;
    }
    // INC AX (1000_E895 / 0x1E895)
    AX = Alu.Inc16(AX);
    label_1000_E896_1E896:
    // DEC AX (1000_E896 / 0x1E896)
    AX = Alu.Dec16(AX);
    // JNS 0x1000:e89a (1000_E897 / 0x1E897)
    if(!SignFlag) {
      goto label_1000_E89A_1E89A;
    }
    // INC AX (1000_E899 / 0x1E899)
    AX = Alu.Inc16(AX);
    label_1000_E89A_1E89A:
    // CMP AX,0xa (1000_E89A / 0x1E89A)
    Alu.Sub16(AX, 0xA);
    // JC 0x1000:e8a1 (1000_E89D / 0x1E89D)
    if(CarryFlag) {
      goto label_1000_E8A1_1E8A1;
    }
    // MOV AL,0xa (1000_E89F / 0x1E89F)
    AL = 0xA;
    label_1000_E8A1_1E8A1:
    // MOV CS:[0xefd9],AL (1000_E8A1 / 0x1E8A1)
    UInt8[cs1, 0xEFD9] = AL;
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
  
  public Action spice86_generated_label_call_target_1000_E8A8_01E8A8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E8A8_1E8A8:
    // PUSHF  (1000_E8A8 / 0x1E8A8)
    Stack.Push(FlagRegister);
    // PUSH AX (1000_E8A9 / 0x1E8A9)
    Stack.Push(AX);
    // CLI  (1000_E8AA / 0x1E8AA)
    InterruptFlag = false;
    // MOV AL,0x36 (1000_E8AB / 0x1E8AB)
    AL = 0x36;
    // OUT 0x43,AL (1000_E8AD / 0x1E8AD)
    Cpu.Out8(0x43, AL);
    // POP AX (1000_E8AF / 0x1E8AF)
    AX = Stack.Pop();
    // OUT 0x40,AL (1000_E8B0 / 0x1E8B0)
    Cpu.Out8(0x40, AL);
    // MOV AL,AH (1000_E8B2 / 0x1E8B2)
    AL = AH;
    // OUT 0x40,AL (1000_E8B4 / 0x1E8B4)
    Cpu.Out8(0x40, AL);
    // POPF  (1000_E8B6 / 0x1E8B6)
    FlagRegister = Stack.Pop();
    // RET  (1000_E8B7 / 0x1E8B7)
    return NearRet();
  }
  
  public Action get_pit_timer_value_ida_1000_E8B8_1E8B8(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E8B8_1E8B8:
    // PUSH AX (1000_E8B8 / 0x1E8B8)
    Stack.Push(AX);
    // MOV AL,0x36 (1000_E8B9 / 0x1E8B9)
    AL = 0x36;
    // OUT 0x43,AL (1000_E8BB / 0x1E8BB)
    Cpu.Out8(0x43, AL);
    // IN AL,0x40 (1000_E8BD / 0x1E8BD)
    AL = Cpu.In8(0x40);
    // MOV AH,AL (1000_E8BF / 0x1E8BF)
    AH = AL;
    // IN AL,0x40 (1000_E8C1 / 0x1E8C1)
    AL = Cpu.In8(0x40);
    // XCHG AL,AH (1000_E8C3 / 0x1E8C3)
    byte tmp_1000_E8C3 = AL;
    AL = AH;
    AH = tmp_1000_E8C3;
    // MOV CS:[0xe8d2],AX (1000_E8C5 / 0x1E8C5)
    UInt16[cs1, 0xE8D2] = AX;
    // INC byte ptr CS:[0xe8d4] (1000_E8C9 / 0x1E8C9)
    UInt8[cs1, 0xE8D4] = Alu.Inc8(UInt8[cs1, 0xE8D4]);
    // POP AX (1000_E8CE / 0x1E8CE)
    AX = Stack.Pop();
    // JMP 0x1000:ef6a (1000_E8CF / 0x1E8CF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_EF6A_01EF6A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_E8D5_01E8D5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E8D5_1E8D5:
    // CMP word ptr CS:[0xee8a],0x0 (1000_E8D5 / 0x1E8D5)
    Alu.Sub16(UInt16[cs1, 0xEE8A], 0x0);
    // JZ 0x1000:e8e2 (1000_E8DB / 0x1E8DB)
    if(ZeroFlag) {
      goto label_1000_E8E2_1E8E2;
    }
    // MOV AH,0xa (1000_E8DD / 0x1E8DD)
    AH = 0xA;
    // CALL 0x1000:ef2b (1000_E8DF / 0x1E8DF)
    NearCall(cs1, 0xE8E2, call_xms_func_on_block_ida_1000_EF2B_1EF2B);
    label_1000_E8E2_1E8E2:
    // CMP word ptr CS:[0xed3a],0x0 (1000_E8E2 / 0x1E8E2)
    Alu.Sub16(UInt16[cs1, 0xED3A], 0x0);
    // JZ 0x1000:e8ef (1000_E8E8 / 0x1E8E8)
    if(ZeroFlag) {
      goto label_1000_E8EF_1E8EF;
    }
    // MOV AH,0x45 (1000_E8EA / 0x1E8EA)
    AH = 0x45;
    // CALL 0x1000:ed40 (1000_E8EC / 0x1E8EC)
    NearCall(cs1, 0xE8EF, get_ems_emm_handle_ida_1000_ED40_1ED40);
    label_1000_E8EF_1E8EF:
    // MOV DX,word ptr CS:[0xed3e] (1000_E8EF / 0x1E8EF)
    DX = UInt16[cs1, 0xED3E];
    // OR DX,DX (1000_E8F4 / 0x1E8F4)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:e8fd (1000_E8F6 / 0x1E8F6)
    if(ZeroFlag) {
      goto label_1000_E8FD_1E8FD;
    }
    // MOV AH,0x45 (1000_E8F8 / 0x1E8F8)
    AH = 0x45;
    // CALL 0x1000:ed45 (1000_E8FA / 0x1E8FA)
    NearCall(cs1, 0xE8FD, call_ems_func_ida_1000_ED45_1ED45);
    label_1000_E8FD_1E8FD:
    // XOR AX,AX (1000_E8FD / 0x1E8FD)
    AX = 0;
    // CALL 0x1000:e8a8 (1000_E8FF / 0x1E8FF)
    NearCall(cs1, 0xE902, spice86_generated_label_call_target_1000_E8A8_01E8A8);
    label_1000_E902_1E902:
    // MOV DL,byte ptr [0x2941] (1000_E902 / 0x1E902)
    DL = UInt8[DS, 0x2941];
    // MOV AX,0x3301 (1000_E906 / 0x1E906)
    AX = 0x3301;
    // INT 0x21 (1000_E909 / 0x1E909)
    Interrupt(0x21);
    // CMP byte ptr [0xce73],0x0 (1000_E90B / 0x1E90B)
    Alu.Sub8(UInt8[DS, 0xCE73], 0x0);
    // JNZ 0x1000:e913 (1000_E910 / 0x1E910)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_E913_01E913, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_E912 / 0x1E912)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E913_01E913(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E913_1E913:
    // XOR byte ptr [0xce73],0xff (1000_E913 / 0x1E913)
    // UInt8[DS, 0xCE73] ^= 0xFF;
    UInt8[DS, 0xCE73] = Alu.Xor8(UInt8[DS, 0xCE73], 0xFF);
    // MOV SI,0x2913 (1000_E918 / 0x1E918)
    SI = 0x2913;
    // PUSHF  (1000_E91B / 0x1E91B)
    Stack.Push(FlagRegister);
    // CLI  (1000_E91C / 0x1E91C)
    InterruptFlag = false;
    // LODSW SI (1000_E91D / 0x1E91D)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    label_1000_E91E_1E91E:
    // MOV DI,AX (1000_E91E / 0x1E91E)
    DI = AX;
    // LODSW SI (1000_E920 / 0x1E920)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AX,DI (1000_E921 / 0x1E921)
    ushort tmp_1000_E921 = AX;
    AX = DI;
    DI = tmp_1000_E921;
    // PUSH SI (1000_E922 / 0x1E922)
    Stack.Push(SI);
    // MOV SI,AX (1000_E923 / 0x1E923)
    SI = AX;
    // SHL SI,0x1 (1000_E925 / 0x1E925)
    SI <<= 0x1;
    
    // SHL SI,0x1 (1000_E927 / 0x1E927)
    SI <<= 0x1;
    
    // XOR AX,AX (1000_E929 / 0x1E929)
    AX = 0;
    // MOV ES,AX (1000_E92B / 0x1E92B)
    ES = AX;
    // MOV AX,word ptr CS:[DI] (1000_E92D / 0x1E92D)
    AX = UInt16[cs1, DI];
    // XCHG word ptr ES:[SI],AX (1000_E930 / 0x1E930)
    ushort tmp_1000_E930 = UInt16[ES, SI];
    UInt16[ES, SI] = AX;
    AX = tmp_1000_E930;
    // MOV word ptr CS:[DI],AX (1000_E933 / 0x1E933)
    UInt16[cs1, DI] = AX;
    // MOV AX,word ptr CS:[DI + 0x2] (1000_E936 / 0x1E936)
    AX = UInt16[cs1, (ushort)(DI + 0x2)];
    // XCHG word ptr ES:[SI + 0x2],AX (1000_E93A / 0x1E93A)
    ushort tmp_1000_E93A = UInt16[ES, (ushort)(SI + 0x2)];
    UInt16[ES, (ushort)(SI + 0x2)] = AX;
    AX = tmp_1000_E93A;
    // MOV word ptr CS:[DI + 0x2],AX (1000_E93E / 0x1E93E)
    UInt16[cs1, (ushort)(DI + 0x2)] = AX;
    // POP SI (1000_E942 / 0x1E942)
    SI = Stack.Pop();
    // LODSW SI (1000_E943 / 0x1E943)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR AX,AX (1000_E944 / 0x1E944)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JNS 0x1000:e91e (1000_E946 / 0x1E946)
    if(!SignFlag) {
      goto label_1000_E91E_1E91E;
    }
    // POPF  (1000_E948 / 0x1E948)
    FlagRegister = Stack.Pop();
    // RET  (1000_E949 / 0x1E949)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_E97A_01E97A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E97A_1E97A:
    // MOV AX,0x3533 (1000_E97A / 0x1E97A)
    AX = 0x3533;
    // INT 0x21 (1000_E97D / 0x1E97D)
    Interrupt(0x21);
    // MOV AX,ES (1000_E97F / 0x1E97F)
    AX = ES;
    // OR AX,BX (1000_E981 / 0x1E981)
    // AX |= BX;
    AX = Alu.Or16(AX, BX);
    // JZ 0x1000:e9f3 (1000_E983 / 0x1E983)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    // MOV AX,0x0 (1000_E985 / 0x1E985)
    AX = 0x0;
    // INT 0x33 (1000_E988 / 0x1E988)
    Interrupt(0x33);
    // INC AX (1000_E98A / 0x1E98A)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:e9f3 (1000_E98B / 0x1E98B)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    // XOR CX,CX (1000_E98D / 0x1E98D)
    CX = 0;
    // XOR DX,DX (1000_E98F / 0x1E98F)
    DX = 0;
    // MOV AX,0x4 (1000_E991 / 0x1E991)
    AX = 0x4;
    // INT 0x33 (1000_E994 / 0x1E994)
    Interrupt(0x33);
    label_1000_E996_1E996:
    // INC byte ptr [0x2580] (1000_E996 / 0x1E996)
    UInt8[DS, 0x2580] = Alu.Inc8(UInt8[DS, 0x2580]);
    // JS 0x1000:e9b3 (1000_E99A / 0x1E99A)
    if(SignFlag) {
      goto label_1000_E9B3_1E9B3;
    }
    // MOV CL,byte ptr [0x2580] (1000_E99C / 0x1E99C)
    CL = UInt8[DS, 0x2580];
    // MOV AX,0x1 (1000_E9A0 / 0x1E9A0)
    AX = 0x1;
    // SHL AX,CL (1000_E9A3 / 0x1E9A3)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    // MOV CX,AX (1000_E9A5 / 0x1E9A5)
    CX = AX;
    // MOV AX,0x4 (1000_E9A7 / 0x1E9A7)
    AX = 0x4;
    // INT 0x33 (1000_E9AA / 0x1E9AA)
    Interrupt(0x33);
    // MOV AX,0x3 (1000_E9AC / 0x1E9AC)
    AX = 0x3;
    // INT 0x33 (1000_E9AF / 0x1E9AF)
    Interrupt(0x33);
    // JCXZ 0x1000:e996 (1000_E9B1 / 0x1E9B1)
    if(CX == 0) {
      goto label_1000_E996_1E996;
    }
    label_1000_E9B3_1E9B3:
    // INC byte ptr [0x2581] (1000_E9B3 / 0x1E9B3)
    UInt8[DS, 0x2581] = Alu.Inc8(UInt8[DS, 0x2581]);
    // JS 0x1000:e9d0 (1000_E9B7 / 0x1E9B7)
    if(SignFlag) {
      goto label_1000_E9D0_1E9D0;
    }
    // MOV CL,byte ptr [0x2581] (1000_E9B9 / 0x1E9B9)
    CL = UInt8[DS, 0x2581];
    // MOV DX,0x1 (1000_E9BD / 0x1E9BD)
    DX = 0x1;
    // SHL DX,CL (1000_E9C0 / 0x1E9C0)
    // DX <<= CL;
    DX = Alu.Shl16(DX, CL);
    // MOV AX,0x4 (1000_E9C2 / 0x1E9C2)
    AX = 0x4;
    // INT 0x33 (1000_E9C5 / 0x1E9C5)
    Interrupt(0x33);
    // MOV AX,0x3 (1000_E9C7 / 0x1E9C7)
    AX = 0x3;
    // INT 0x33 (1000_E9CA / 0x1E9CA)
    Interrupt(0x33);
    // OR DX,DX (1000_E9CC / 0x1E9CC)
    // DX |= DX;
    DX = Alu.Or16(DX, DX);
    // JZ 0x1000:e9b3 (1000_E9CE / 0x1E9CE)
    if(ZeroFlag) {
      goto label_1000_E9B3_1E9B3;
    }
    label_1000_E9D0_1E9D0:
    // MOV AX,0x10 (1000_E9D0 / 0x1E9D0)
    AX = 0x10;
    // MOV DX,AX (1000_E9D3 / 0x1E9D3)
    DX = AX;
    // AND word ptr [0x2580],0x7f7f (1000_E9D5 / 0x1E9D5)
    // UInt16[DS, 0x2580] &= 0x7F7F;
    UInt16[DS, 0x2580] = Alu.And16(UInt16[DS, 0x2580], 0x7F7F);
    // MOV CX,word ptr [0x2580] (1000_E9DB / 0x1E9DB)
    CX = UInt16[DS, 0x2580];
    // SHR AX,CL (1000_E9DF / 0x1E9DF)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV CL,CH (1000_E9E1 / 0x1E9E1)
    CL = CH;
    // SHR DX,CL (1000_E9E3 / 0x1E9E3)
    // DX >>= CL;
    DX = Alu.Shr16(DX, CL);
    // MOV CX,AX (1000_E9E5 / 0x1E9E5)
    CX = AX;
    // MOV AX,0xf (1000_E9E7 / 0x1E9E7)
    AX = 0xF;
    // PUSH DX (1000_E9EA / 0x1E9EA)
    Stack.Push(DX);
    // INT 0x33 (1000_E9EB / 0x1E9EB)
    Interrupt(0x33);
    // POP DX (1000_E9ED / 0x1E9ED)
    DX = Stack.Pop();
    // MOV AX,0x13 (1000_E9EE / 0x1E9EE)
    AX = 0x13;
    // INT 0x33 (1000_E9F1 / 0x1E9F1)
    Interrupt(0x33);
    label_1000_E9F3_1E9F3:
    // RET  (1000_E9F3 / 0x1E9F3)
    return NearRet();
  }
  
  public Action mouse_func_uncalled_ida_1000_E9F4_1E9F4(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_E9F4_1E9F4:
    // PUSH AX (1000_E9F4 / 0x1E9F4)
    Stack.Push(AX);
    // PUSH DS (1000_E9F5 / 0x1E9F5)
    Stack.Push(DS);
    // MOV DS,word ptr CS:[0xea30] (1000_E9F6 / 0x1E9F6)
    DS = UInt16[cs1, 0xEA30];
    // MOV word ptr [0xdc36],CX (1000_E9FB / 0x1E9FB)
    UInt16[DS, 0xDC36] = CX;
    // MOV word ptr [0xdc38],DX (1000_E9FF / 0x1E9FF)
    UInt16[DS, 0xDC38] = DX;
    // SHR AL,0x1 (1000_EA03 / 0x1EA03)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JZ 0x1000:ea2d (1000_EA05 / 0x1EA05)
    if(ZeroFlag) {
      goto label_1000_EA2D_1EA2D;
    }
    // PUSH CX (1000_EA07 / 0x1EA07)
    Stack.Push(CX);
    // MOV CL,byte ptr [0xdc34] (1000_EA08 / 0x1EA08)
    CL = UInt8[DS, 0xDC34];
    // SHR AL,0x1 (1000_EA0C / 0x1EA0C)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNC 0x1000:ea13 (1000_EA0E / 0x1EA0E)
    if(!CarryFlag) {
      goto label_1000_EA13_1EA13;
    }
    // OR CL,0x1 (1000_EA10 / 0x1EA10)
    CL |= 0x1;
    
    label_1000_EA13_1EA13:
    // SHR AL,0x1 (1000_EA13 / 0x1EA13)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNC 0x1000:ea1a (1000_EA15 / 0x1EA15)
    if(!CarryFlag) {
      goto label_1000_EA1A_1EA1A;
    }
    // AND CL,0xfe (1000_EA17 / 0x1EA17)
    CL &= 0xFE;
    
    label_1000_EA1A_1EA1A:
    // SHR AL,0x1 (1000_EA1A / 0x1EA1A)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNC 0x1000:ea21 (1000_EA1C / 0x1EA1C)
    if(!CarryFlag) {
      goto label_1000_EA21_1EA21;
    }
    // OR CL,0x2 (1000_EA1E / 0x1EA1E)
    CL |= 0x2;
    
    label_1000_EA21_1EA21:
    // SHR AL,0x1 (1000_EA21 / 0x1EA21)
    // AL >>= 0x1;
    AL = Alu.Shr8(AL, 0x1);
    // JNC 0x1000:ea28 (1000_EA23 / 0x1EA23)
    if(!CarryFlag) {
      goto label_1000_EA28_1EA28;
    }
    // AND CL,0xfd (1000_EA25 / 0x1EA25)
    // CL &= 0xFD;
    CL = Alu.And8(CL, 0xFD);
    label_1000_EA28_1EA28:
    // MOV byte ptr [0xdc34],CL (1000_EA28 / 0x1EA28)
    UInt8[DS, 0xDC34] = CL;
    // POP CX (1000_EA2C / 0x1EA2C)
    CX = Stack.Pop();
    label_1000_EA2D_1EA2D:
    // POP DS (1000_EA2D / 0x1EA2D)
    DS = Stack.Pop();
    // POP AX (1000_EA2E / 0x1EA2E)
    AX = Stack.Pop();
    // RETF  (1000_EA2F / 0x1EA2F)
    return FarRet();
  }
  
  public Action initialize_joystick_ida_1000_EA32_1EA32(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EA32_1EA32:
    // MOV SI,0x39ab (1000_EA32 / 0x1EA32)
    SI = 0x39AB;
    // XOR BX,BX (1000_EA35 / 0x1EA35)
    BX = 0;
    // MOV CX,0x4 (1000_EA37 / 0x1EA37)
    CX = 0x4;
    label_1000_EA3A_1EA3A:
    // LODSW SI (1000_EA3A / 0x1EA3A)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // OR BX,AX (1000_EA3B / 0x1EA3B)
    // BX |= AX;
    BX = Alu.Or16(BX, AX);
    // LOOP 0x1000:ea3a (1000_EA3D / 0x1EA3D)
    if(--CX != 0) {
      goto label_1000_EA3A_1EA3A;
    }
    // OR BX,BX (1000_EA3F / 0x1EA3F)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JNZ 0x1000:ea74 (1000_EA41 / 0x1EA41)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_EA74 / 0x1EA74)
      return NearRet();
    }
    // CALL 0x1000:dce0 (1000_EA43 / 0x1EA43)
    NearCall(cs1, 0xEA46, read_game_port_ida_1000_DCE0_1DCE0);
    // MOV AX,DX (1000_EA46 / 0x1EA46)
    AX = DX;
    // SUB AX,0x4 (1000_EA48 / 0x1EA48)
    AX -= 0x4;
    
    // CMP AH,0x4 (1000_EA4B / 0x1EA4B)
    Alu.Sub8(AH, 0x4);
    // JNC 0x1000:e9f3 (1000_EA4E / 0x1EA4E)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    // MOV AX,BX (1000_EA50 / 0x1EA50)
    AX = BX;
    // SUB AX,0x4 (1000_EA52 / 0x1EA52)
    AX -= 0x4;
    
    // CMP AH,0x4 (1000_EA55 / 0x1EA55)
    Alu.Sub8(AH, 0x4);
    // JNC 0x1000:e9f3 (1000_EA58 / 0x1EA58)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_E9F3 / 0x1E9F3)
      return NearRet();
    }
    // MOV AX,DX (1000_EA5A / 0x1EA5A)
    AX = DX;
    // SHR AX,0x1 (1000_EA5C / 0x1EA5C)
    AX >>= 0x1;
    
    // ADD DX,AX (1000_EA5E / 0x1EA5E)
    // DX += AX;
    DX = Alu.Add16(DX, AX);
    // MOV SI,0x39ab (1000_EA60 / 0x1EA60)
    SI = 0x39AB;
    // MOV word ptr [SI],AX (1000_EA63 / 0x1EA63)
    UInt16[DS, SI] = AX;
    // MOV word ptr [SI + 0x2],DX (1000_EA65 / 0x1EA65)
    UInt16[DS, (ushort)(SI + 0x2)] = DX;
    // MOV AX,BX (1000_EA68 / 0x1EA68)
    AX = BX;
    // SHR AX,0x1 (1000_EA6A / 0x1EA6A)
    AX >>= 0x1;
    
    // ADD BX,AX (1000_EA6C / 0x1EA6C)
    // BX += AX;
    BX = Alu.Add16(BX, AX);
    // MOV word ptr [SI + 0x4],AX (1000_EA6E / 0x1EA6E)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    // MOV word ptr [SI + 0x6],BX (1000_EA71 / 0x1EA71)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    label_1000_EA74_1EA74:
    // RET  (1000_EA74 / 0x1EA74)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_EA7B_01EA7B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EA7B_1EA7B:
    // TEST byte ptr [0x2943],0x80 (1000_EA7B / 0x1EA7B)
    Alu.And8(UInt8[DS, 0x2943], 0x80);
    // JZ 0x1000:ea85 (1000_EA80 / 0x1EA80)
    if(ZeroFlag) {
      goto label_1000_EA85_1EA85;
    }
    // CALL 0x1000:eea0 (1000_EA82 / 0x1EA82)
    NearCall(cs1, 0xEA85, initialize_himem_sys_ida_1000_EEA0_1EEA0);
    label_1000_EA85_1EA85:
    // TEST byte ptr [0x2943],0x48 (1000_EA85 / 0x1EA85)
    Alu.And8(UInt8[DS, 0x2943], 0x48);
    // JZ 0x1000:ea8f (1000_EA8A / 0x1EA8A)
    if(ZeroFlag) {
      goto label_1000_EA8F_1EA8F;
    }
    // CALL 0x1000:ed4c (1000_EA8C / 0x1EA8C)
    throw FailAsUntested("Could not find a valid function at address 1000_ED4C / 0x1ED4C");
    label_1000_EA8F_1EA8F:
    // TEST byte ptr [0x2943],0xe8 (1000_EA8F / 0x1EA8F)
    Alu.And8(UInt8[DS, 0x2943], 0xE8);
    // JZ 0x1000:eab6 (1000_EA94 / 0x1EA94)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_EAB6 / 0x1EAB6)
      return NearRet();
    }
    // MOV DI,0xce6a (1000_EA96 / 0x1EA96)
    DI = 0xCE6A;
    // MOV CX,word ptr [0x39a9] (1000_EA99 / 0x1EA99)
    CX = UInt16[DS, 0x39A9];
    // MOV AX,0xb9 (1000_EA9D / 0x1EA9D)
    AX = 0xB9;
    // MOV [0xce70],AL (1000_EAA0 / 0x1EAA0)
    UInt8[DS, 0xCE70] = AL;
    // ADD CX,AX (1000_EAA3 / 0x1EAA3)
    CX += AX;
    
    // ADD CX,AX (1000_EAA5 / 0x1EAA5)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    // PUSH CX (1000_EAA7 / 0x1EAA7)
    Stack.Push(CX);
    // SHL CX,0x1 (1000_EAA8 / 0x1EAA8)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    // CALL 0x1000:f0f6 (1000_EAAA / 0x1EAAA)
    NearCall(cs1, 0xEAAD, spice86_generated_label_call_target_1000_F0F6_01F0F6);
    // LES DI,[0xce6a] (1000_EAAD / 0x1EAAD)
    ES = UInt16[DS, 0xCE6C];
    DI = UInt16[DS, 0xCE6A];
    // POP CX (1000_EAB1 / 0x1EAB1)
    CX = Stack.Pop();
    // XOR AX,AX (1000_EAB2 / 0x1EAB2)
    AX = 0;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_EAB4 / 0x1EAB4)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    label_1000_EAB6_1EAB6:
    // RET  (1000_EAB6 / 0x1EAB6)
    return NearRet();
  }
  
  public Action memory_func_qq_ida_1000_EAB7_1EAB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EAB7_1EAB7:
    // CALL 0x1000:e270 (1000_EAB7 / 0x1EAB7)
    NearCall(cs1, 0xEABA, spice86_generated_label_call_target_1000_E270_01E270);
    // PUSH DS (1000_EABA / 0x1EABA)
    Stack.Push(DS);
    // PUSH ES (1000_EABB / 0x1EABB)
    Stack.Push(ES);
    // SUB SP,0x6 (1000_EABC / 0x1EABC)
    // SP -= 0x6;
    SP = Alu.Sub16(SP, 0x6);
    // MOV BP,SP (1000_EABF / 0x1EABF)
    BP = SP;
    // MOV [0xce6e],AX (1000_EAC1 / 0x1EAC1)
    UInt16[DS, 0xCE6E] = AX;
    // PUSH DI (1000_EAC4 / 0x1EAC4)
    Stack.Push(DI);
    // PUSH ES (1000_EAC5 / 0x1EAC5)
    Stack.Push(ES);
    // LES DI,[0xce6a] (1000_EAC6 / 0x1EAC6)
    ES = UInt16[DS, 0xCE6C];
    DI = UInt16[DS, 0xCE6A];
    // MOV SI,AX (1000_EACA / 0x1EACA)
    SI = AX;
    // MOV AX,[0x39a9] (1000_EACC / 0x1EACC)
    AX = UInt16[DS, 0x39A9];
    // SHL AX,0x1 (1000_EACF / 0x1EACF)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // MOV word ptr [BP + 0x0],AX (1000_EAD1 / 0x1EAD1)
    UInt16[SS, BP] = AX;
    // SHL SI,0x1 (1000_EAD4 / 0x1EAD4)
    SI <<= 0x1;
    
    // ADD SI,AX (1000_EAD6 / 0x1EAD6)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // MOV DX,SI (1000_EAD8 / 0x1EAD8)
    DX = SI;
    // MOV AX,CS:[0xea75] (1000_EADA / 0x1EADA)
    AX = UInt16[cs1, 0xEA75];
    // INC AX (1000_EADE / 0x1EADE)
    AX = Alu.Inc16(AX);
    // MOV word ptr ES:[SI + 0x172],AX (1000_EADF / 0x1EADF)
    UInt16[ES, (ushort)(SI + 0x172)] = AX;
    // MOV CS:[0xea75],AX (1000_EAE4 / 0x1EAE4)
    UInt16[cs1, 0xEA75] = AX;
    // MOV word ptr [BP + 0x2],CX (1000_EAE8 / 0x1EAE8)
    UInt16[SS, (ushort)(BP + 0x2)] = CX;
    // POP DS (1000_EAEB / 0x1EAEB)
    DS = Stack.Pop();
    // POP SI (1000_EAEC / 0x1EAEC)
    SI = Stack.Pop();
    label_1000_EAED_1EAED:
    // CMP DI,word ptr [BP + 0x0] (1000_EAED / 0x1EAED)
    Alu.Sub16(DI, UInt16[SS, BP]);
    // JC 0x1000:eaf4 (1000_EAF0 / 0x1EAF0)
    if(CarryFlag) {
      goto label_1000_EAF4_1EAF4;
    }
    label_1000_EAF2_1EAF2:
    // XOR DI,DI (1000_EAF2 / 0x1EAF2)
    DI = 0;
    label_1000_EAF4_1EAF4:
    // MOV CX,word ptr [BP + 0x0] (1000_EAF4 / 0x1EAF4)
    CX = UInt16[SS, BP];
    // SUB CX,DI (1000_EAF7 / 0x1EAF7)
    CX -= DI;
    
    // SHR CX,0x1 (1000_EAF9 / 0x1EAF9)
    CX >>= 0x1;
    
    // XOR AX,AX (1000_EAFB / 0x1EAFB)
    AX = 0;
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
    // JZ 0x1000:eb08 (1000_EAFF / 0x1EAFF)
    if(ZeroFlag) {
      goto label_1000_EB08_1EB08;
    }
    // CALL 0x1000:eb74 (1000_EB01 / 0x1EB01)
    throw FailAsUntested("Could not find a valid function at address 1000_EB74 / 0x1EB74");
    // JC 0x1000:eaf2 (1000_EB04 / 0x1EB04)
    if(CarryFlag) {
      goto label_1000_EAF2_1EAF2;
    }
    // JMP 0x1000:eb60 (1000_EB06 / 0x1EB06)
    goto label_1000_EB60_1EB60;
    label_1000_EB08_1EB08:
    // SUB DI,0x2 (1000_EB08 / 0x1EB08)
    DI -= 0x2;
    
    // XOR CX,CX (1000_EB0B / 0x1EB0B)
    CX = 0;
    // MOV BX,DI (1000_EB0D / 0x1EB0D)
    BX = DI;
    // SHR BX,0x1 (1000_EB0F / 0x1EB0F)
    BX >>= 0x1;
    
    // INC BX (1000_EB11 / 0x1EB11)
    BX = Alu.Inc16(BX);
    // MOV word ptr [BP + 0x4],BX (1000_EB12 / 0x1EB12)
    UInt16[SS, (ushort)(BP + 0x4)] = BX;
    // JMP 0x1000:eb28 (1000_EB15 / 0x1EB15)
    goto label_1000_EB28_1EB28;
    label_1000_EB17_1EB17:
    // MOV DI,DX (1000_EB17 / 0x1EB17)
    DI = DX;
    // ADD DI,0x2 (1000_EB19 / 0x1EB19)
    DI += 0x2;
    
    // CMP DI,word ptr [BP + 0x0] (1000_EB1C / 0x1EB1C)
    Alu.Sub16(DI, UInt16[SS, BP]);
    // JNC 0x1000:eb3f (1000_EB1F / 0x1EB1F)
    if(!CarryFlag) {
      goto label_1000_EB3F_1EB3F;
    }
    // CMP word ptr ES:[DI],0x0 (1000_EB21 / 0x1EB21)
    Alu.Sub16(UInt16[ES, DI], 0x0);
    // JNZ 0x1000:eb3f (1000_EB25 / 0x1EB25)
    if(!ZeroFlag) {
      goto label_1000_EB3F_1EB3F;
    }
    // INC BX (1000_EB27 / 0x1EB27)
    BX = Alu.Inc16(BX);
    label_1000_EB28_1EB28:
    // XCHG DX,DI (1000_EB28 / 0x1EB28)
    ushort tmp_1000_EB28 = DX;
    DX = DI;
    DI = tmp_1000_EB28;
    // MOV word ptr ES:[DI],BX (1000_EB2A / 0x1EB2A)
    UInt16[ES, DI] = BX;
    // MOV AX,0x400 (1000_EB2D / 0x1EB2D)
    AX = 0x400;
    // ADD CX,AX (1000_EB30 / 0x1EB30)
    CX += AX;
    
    // SUB word ptr [BP + 0x2],AX (1000_EB32 / 0x1EB32)
    // UInt16[SS, (ushort)(BP + 0x2)] -= AX;
    UInt16[SS, (ushort)(BP + 0x2)] = Alu.Sub16(UInt16[SS, (ushort)(BP + 0x2)], AX);
    // JA 0x1000:eb17 (1000_EB35 / 0x1EB35)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_EB17_1EB17;
    }
    // MOV DI,DX (1000_EB37 / 0x1EB37)
    DI = DX;
    // MOV AX,word ptr [BP + 0x2] (1000_EB39 / 0x1EB39)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    // STOSW ES:DI (1000_EB3C / 0x1EB3C)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD CX,AX (1000_EB3D / 0x1EB3D)
    // CX += AX;
    CX = Alu.Add16(CX, AX);
    label_1000_EB3F_1EB3F:
    // MOV BX,word ptr [BP + 0x4] (1000_EB3F / 0x1EB3F)
    BX = UInt16[SS, (ushort)(BP + 0x4)];
    // PUSH DX (1000_EB42 / 0x1EB42)
    Stack.Push(DX);
    // CALL 0x1000:ec59 (1000_EB43 / 0x1EB43)
    NearCall(cs1, 0xEB46, call_memory_func_1_ida_1000_EC59_1EC59);
    // POP DX (1000_EB46 / 0x1EB46)
    DX = Stack.Pop();
    // MOV DI,DX (1000_EB47 / 0x1EB47)
    DI = DX;
    // OR word ptr ES:[DI],0x8000 (1000_EB49 / 0x1EB49)
    // UInt16[ES, DI] |= 0x8000;
    UInt16[ES, DI] = Alu.Or16(UInt16[ES, DI], 0x8000);
    // MOV AX,word ptr [BP + 0x2] (1000_EB4E / 0x1EB4E)
    AX = UInt16[SS, (ushort)(BP + 0x2)];
    // DEC AX (1000_EB51 / 0x1EB51)
    AX = Alu.Dec16(AX);
    // CMP AX,0xfc00 (1000_EB52 / 0x1EB52)
    Alu.Sub16(AX, 0xFC00);
    // JBE 0x1000:eaed (1000_EB55 / 0x1EB55)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_EAED_1EAED;
    }
    label_1000_EB57_1EB57:
    // ADD SP,0x6 (1000_EB57 / 0x1EB57)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    // POP ES (1000_EB5A / 0x1EB5A)
    ES = Stack.Pop();
    // POP DS (1000_EB5B / 0x1EB5B)
    DS = Stack.Pop();
    // CALL 0x1000:e283 (1000_EB5C / 0x1EB5C)
    NearCall(cs1, 0xEB5F, spice86_generated_label_call_target_1000_E283_01E283);
    // RET  (1000_EB5F / 0x1EB5F)
    return NearRet();
    label_1000_EB60_1EB60:
    // MOV SI,word ptr [BP + 0x0] (1000_EB60 / 0x1EB60)
    SI = UInt16[SS, BP];
    // MOV AX,0xffff (1000_EB63 / 0x1EB63)
    AX = 0xFFFF;
    // XCHG word ptr SS:[0xce6e],AX (1000_EB66 / 0x1EB66)
    ushort tmp_1000_EB66 = UInt16[SS, 0xCE6E];
    UInt16[SS, 0xCE6E] = AX;
    AX = tmp_1000_EB66;
    // ADD SI,AX (1000_EB6B / 0x1EB6B)
    SI += AX;
    
    // ADD SI,AX (1000_EB6D / 0x1EB6D)
    // SI += AX;
    SI = Alu.Add16(SI, AX);
    // CALL 0x1000:ebaa (1000_EB6F / 0x1EB6F)
    throw FailAsUntested("Could not find a valid function at address 1000_EBAA / 0x1EBAA");
    // JMP 0x1000:eb57 (1000_EB72 / 0x1EB72)
    goto label_1000_EB57_1EB57;
  }
  
  public Action call_memory_func_2_ida_1000_EC46_1EC46(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EC46_1EC46:
    // PUSH CX (1000_EC46 / 0x1EC46)
    Stack.Push(CX);
    // PUSH DI (1000_EC47 / 0x1EC47)
    Stack.Push(DI);
    // PUSH DS (1000_EC48 / 0x1EC48)
    Stack.Push(DS);
    // PUSH ES (1000_EC49 / 0x1EC49)
    Stack.Push(ES);
    // DEC BX (1000_EC4A / 0x1EC4A)
    BX = Alu.Dec16(BX);
    // CALL word ptr CS:[0xea79] (1000_EC4B / 0x1EC4B)
    // Indirect call to word ptr CS:[0xea79], generating possible targets from emulator records
    uint targetAddress_1000_EC4B = (uint)(UInt16[cs1, 0xEA79]);
    switch(targetAddress_1000_EC4B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EC4B));
        break;
    }
    // POP ES (1000_EC50 / 0x1EC50)
    ES = Stack.Pop();
    // POP DS (1000_EC51 / 0x1EC51)
    DS = Stack.Pop();
    // POP DI (1000_EC52 / 0x1EC52)
    DI = Stack.Pop();
    // POP CX (1000_EC53 / 0x1EC53)
    CX = Stack.Pop();
    // PUSHF  (1000_EC54 / 0x1EC54)
    Stack.Push(FlagRegister);
    // ADD DI,CX (1000_EC55 / 0x1EC55)
    DI += CX;
    
    // POPF  (1000_EC57 / 0x1EC57)
    FlagRegister = Stack.Pop();
    // RET  (1000_EC58 / 0x1EC58)
    return NearRet();
  }
  
  public Action call_memory_func_1_ida_1000_EC59_1EC59(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EC59_1EC59:
    // PUSH SI (1000_EC59 / 0x1EC59)
    Stack.Push(SI);
    // PUSH DS (1000_EC5A / 0x1EC5A)
    Stack.Push(DS);
    // PUSH ES (1000_EC5B / 0x1EC5B)
    Stack.Push(ES);
    // PUSH CX (1000_EC5C / 0x1EC5C)
    Stack.Push(CX);
    // DEC BX (1000_EC5D / 0x1EC5D)
    BX = Alu.Dec16(BX);
    // CALL word ptr CS:[0xea77] (1000_EC5E / 0x1EC5E)
    // Indirect call to word ptr CS:[0xea77], generating possible targets from emulator records
    uint targetAddress_1000_EC5E = (uint)(UInt16[cs1, 0xEA77]);
    switch(targetAddress_1000_EC5E) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EC5E));
        break;
    }
    // POP AX (1000_EC63 / 0x1EC63)
    AX = Stack.Pop();
    // POP ES (1000_EC64 / 0x1EC64)
    ES = Stack.Pop();
    // POP DS (1000_EC65 / 0x1EC65)
    DS = Stack.Pop();
    // POP SI (1000_EC66 / 0x1EC66)
    SI = Stack.Pop();
    // PUSHF  (1000_EC67 / 0x1EC67)
    Stack.Push(FlagRegister);
    // ADD SI,AX (1000_EC68 / 0x1EC68)
    SI += AX;
    
    // POPF  (1000_EC6A / 0x1EC6A)
    FlagRegister = Stack.Pop();
    // RET  (1000_EC6B / 0x1EC6B)
    return NearRet();
  }
  
  public Action xms_memory_func_1_ida_1000_EC9C_1EC9C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EC9C_1EC9C:
    // MOV DI,0xec6c (1000_EC9C / 0x1EC9C)
    DI = 0xEC6C;
    // INC CX (1000_EC9F / 0x1EC9F)
    CX = Alu.Inc16(CX);
    // SHR CX,0x1 (1000_ECA0 / 0x1ECA0)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // PUSH CX (1000_ECA2 / 0x1ECA2)
    Stack.Push(CX);
    // SHL CX,0x1 (1000_ECA3 / 0x1ECA3)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    // MOV word ptr CS:[DI + 0x10],CX (1000_ECA5 / 0x1ECA5)
    UInt16[cs1, (ushort)(DI + 0x10)] = CX;
    // MOV word ptr CS:[DI + 0x18],CX (1000_ECA9 / 0x1ECA9)
    UInt16[cs1, (ushort)(DI + 0x18)] = CX;
    // MOV AX,DS (1000_ECAD / 0x1ECAD)
    AX = DS;
    // XOR DX,DX (1000_ECAF / 0x1ECAF)
    DX = 0;
    // MOV CX,0x4 (1000_ECB1 / 0x1ECB1)
    CX = 0x4;
    label_1000_ECB4_1ECB4:
    // SHL AX,0x1 (1000_ECB4 / 0x1ECB4)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // RCL DX,0x1 (1000_ECB6 / 0x1ECB6)
    DX = Alu.Rcl16(DX, 0x1);
    // LOOP 0x1000:ecb4 (1000_ECB8 / 0x1ECB8)
    if(--CX != 0) {
      goto label_1000_ECB4_1ECB4;
    }
    // ADD AX,SI (1000_ECBA / 0x1ECBA)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    // ADC DX,0x0 (1000_ECBC / 0x1ECBC)
    DX = Alu.Adc16(DX, 0x0);
    // MOV word ptr CS:[DI + 0x12],AX (1000_ECBF / 0x1ECBF)
    UInt16[cs1, (ushort)(DI + 0x12)] = AX;
    // MOV DH,0x92 (1000_ECC3 / 0x1ECC3)
    DH = 0x92;
    // MOV word ptr CS:[DI + 0x14],DX (1000_ECC5 / 0x1ECC5)
    UInt16[cs1, (ushort)(DI + 0x14)] = DX;
    // XOR DL,DL (1000_ECC9 / 0x1ECC9)
    DL = 0;
    // XCHG BH,BL (1000_ECCB / 0x1ECCB)
    byte tmp_1000_ECCB = BH;
    BH = BL;
    BL = tmp_1000_ECCB;
    // XCHG DL,BL (1000_ECCD / 0x1ECCD)
    byte tmp_1000_ECCD = DL;
    DL = BL;
    BL = tmp_1000_ECCD;
    // SHL BX,0x1 (1000_ECCF / 0x1ECCF)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // RCL DL,0x1 (1000_ECD1 / 0x1ECD1)
    DL = Alu.Rcl8(DL, 0x1);
    // SHL BX,0x1 (1000_ECD3 / 0x1ECD3)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // RCL DL,0x1 (1000_ECD5 / 0x1ECD5)
    DL = Alu.Rcl8(DL, 0x1);
    // ADD DL,0x10 (1000_ECD7 / 0x1ECD7)
    // DL += 0x10;
    DL = Alu.Add8(DL, 0x10);
    // MOV word ptr CS:[DI + 0x1a],BX (1000_ECDA / 0x1ECDA)
    UInt16[cs1, (ushort)(DI + 0x1A)] = BX;
    // MOV word ptr CS:[DI + 0x1c],DX (1000_ECDE / 0x1ECDE)
    UInt16[cs1, (ushort)(DI + 0x1C)] = DX;
    // MOV SI,DI (1000_ECE2 / 0x1ECE2)
    SI = DI;
    // PUSH CS (1000_ECE4 / 0x1ECE4)
    Stack.Push(cs1);
    // POP ES (1000_ECE5 / 0x1ECE5)
    ES = Stack.Pop();
    // POP CX (1000_ECE6 / 0x1ECE6)
    CX = Stack.Pop();
    // MOV AH,0x87 (1000_ECE7 / 0x1ECE7)
    AH = 0x87;
    // INT 0x15 (1000_ECE9 / 0x1ECE9)
    Interrupt(0x15);
    // RET  (1000_ECEB / 0x1ECEB)
    return NearRet();
  }
  
  public Action xms_memory_func_1_ida_1000_ECEC_1ECEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ECEC_1ECEC:
    // MOV SI,0xec6c (1000_ECEC / 0x1ECEC)
    SI = 0xEC6C;
    // INC CX (1000_ECEF / 0x1ECEF)
    CX = Alu.Inc16(CX);
    // SHR CX,0x1 (1000_ECF0 / 0x1ECF0)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // PUSH CX (1000_ECF2 / 0x1ECF2)
    Stack.Push(CX);
    // SHL CX,0x1 (1000_ECF3 / 0x1ECF3)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    // MOV word ptr CS:[SI + 0x10],CX (1000_ECF5 / 0x1ECF5)
    UInt16[cs1, (ushort)(SI + 0x10)] = CX;
    // MOV word ptr CS:[SI + 0x18],CX (1000_ECF9 / 0x1ECF9)
    UInt16[cs1, (ushort)(SI + 0x18)] = CX;
    // MOV AX,ES (1000_ECFD / 0x1ECFD)
    AX = ES;
    // XOR DX,DX (1000_ECFF / 0x1ECFF)
    DX = 0;
    // MOV CX,0x4 (1000_ED01 / 0x1ED01)
    CX = 0x4;
    label_1000_ED04_1ED04:
    // SHL AX,0x1 (1000_ED04 / 0x1ED04)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // RCL DX,0x1 (1000_ED06 / 0x1ED06)
    DX = Alu.Rcl16(DX, 0x1);
    // LOOP 0x1000:ed04 (1000_ED08 / 0x1ED08)
    if(--CX != 0) {
      goto label_1000_ED04_1ED04;
    }
    // ADD AX,DI (1000_ED0A / 0x1ED0A)
    // AX += DI;
    AX = Alu.Add16(AX, DI);
    // ADC DX,0x0 (1000_ED0C / 0x1ED0C)
    DX = Alu.Adc16(DX, 0x0);
    // MOV word ptr CS:[SI + 0x1a],AX (1000_ED0F / 0x1ED0F)
    UInt16[cs1, (ushort)(SI + 0x1A)] = AX;
    // MOV DH,0x92 (1000_ED13 / 0x1ED13)
    DH = 0x92;
    // MOV word ptr CS:[SI + 0x1c],DX (1000_ED15 / 0x1ED15)
    UInt16[cs1, (ushort)(SI + 0x1C)] = DX;
    // XOR DL,DL (1000_ED19 / 0x1ED19)
    DL = 0;
    // XCHG BH,BL (1000_ED1B / 0x1ED1B)
    byte tmp_1000_ED1B = BH;
    BH = BL;
    BL = tmp_1000_ED1B;
    // XCHG DL,BL (1000_ED1D / 0x1ED1D)
    byte tmp_1000_ED1D = DL;
    DL = BL;
    BL = tmp_1000_ED1D;
    // SHL BX,0x1 (1000_ED1F / 0x1ED1F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // RCL DL,0x1 (1000_ED21 / 0x1ED21)
    DL = Alu.Rcl8(DL, 0x1);
    // SHL BX,0x1 (1000_ED23 / 0x1ED23)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // RCL DL,0x1 (1000_ED25 / 0x1ED25)
    DL = Alu.Rcl8(DL, 0x1);
    // ADD DL,0x10 (1000_ED27 / 0x1ED27)
    // DL += 0x10;
    DL = Alu.Add8(DL, 0x10);
    // MOV word ptr CS:[SI + 0x12],BX (1000_ED2A / 0x1ED2A)
    UInt16[cs1, (ushort)(SI + 0x12)] = BX;
    // MOV word ptr CS:[SI + 0x14],DX (1000_ED2E / 0x1ED2E)
    UInt16[cs1, (ushort)(SI + 0x14)] = DX;
    // PUSH CS (1000_ED32 / 0x1ED32)
    Stack.Push(cs1);
    // POP ES (1000_ED33 / 0x1ED33)
    ES = Stack.Pop();
    // POP CX (1000_ED34 / 0x1ED34)
    CX = Stack.Pop();
    // MOV AH,0x87 (1000_ED35 / 0x1ED35)
    AH = 0x87;
    // INT 0x15 (1000_ED37 / 0x1ED37)
    Interrupt(0x15);
    // RET  (1000_ED39 / 0x1ED39)
    return NearRet();
  }
  
  public Action get_ems_emm_handle_ida_1000_ED40_1ED40(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ED40_1ED40:
    // MOV DX,word ptr CS:[0xed3a] (1000_ED40 / 0x1ED40)
    DX = UInt16[cs1, 0xED3A];
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(call_ems_func_ida_1000_ED45_1ED45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action call_ems_func_ida_1000_ED45_1ED45(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_ED45_1ED45:
    // INT 0x67 (1000_ED45 / 0x1ED45)
    Interrupt(0x67);
    // CMP AH,0x80 (1000_ED47 / 0x1ED47)
    Alu.Sub8(AH, 0x80);
    // CMC  (1000_ED4A / 0x1ED4A)
    CarryFlag = !CarryFlag;
    // RET  (1000_ED4B / 0x1ED4B)
    return NearRet();
  }
  
  public Action map_ems_for_midi_audio_ida_1000_EDB9_1EDB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EDB9_1EDB9:
    // TEST byte ptr [0x2944],0xf (1000_EDB9 / 0x1EDB9)
    Alu.And8(UInt8[DS, 0x2944], 0xF);
    // JZ 0x1000:edfc (1000_EDBE / 0x1EDBE)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_EDFC / 0x1EDFC)
      return NearRet();
    }
    // MOV BX,0x3 (1000_EDC0 / 0x1EDC0)
    BX = 0x3;
    // MOV AH,0x43 (1000_EDC3 / 0x1EDC3)
    AH = 0x43;
    // CALL 0x1000:ed45 (1000_EDC5 / 0x1EDC5)
    NearCall(cs1, 0xEDC8, call_ems_func_ida_1000_ED45_1ED45);
    // JC 0x1000:edfc (1000_EDC8 / 0x1EDC8)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_EDFC / 0x1EDFC)
      return NearRet();
    }
    // MOV word ptr CS:[0xed3e],DX (1000_EDCA / 0x1EDCA)
    UInt16[cs1, 0xED3E] = DX;
    // MOV AX,0x4401 (1000_EDCF / 0x1EDCF)
    AX = 0x4401;
    // XOR BX,BX (1000_EDD2 / 0x1EDD2)
    BX = 0;
    // CALL 0x1000:ed45 (1000_EDD4 / 0x1EDD4)
    NearCall(cs1, 0xEDD7, call_ems_func_ida_1000_ED45_1ED45);
    // JC 0x1000:edfd (1000_EDD7 / 0x1EDD7)
    if(CarryFlag) {
      goto label_1000_EDFD_1EDFD;
    }
    // MOV AX,0x4402 (1000_EDD9 / 0x1EDD9)
    AX = 0x4402;
    // MOV BX,0x1 (1000_EDDC / 0x1EDDC)
    BX = 0x1;
    // CALL 0x1000:ed45 (1000_EDDF / 0x1EDDF)
    NearCall(cs1, 0xEDE2, call_ems_func_ida_1000_ED45_1ED45);
    // JC 0x1000:edfd (1000_EDE2 / 0x1EDE2)
    if(CarryFlag) {
      goto label_1000_EDFD_1EDFD;
    }
    // MOV AX,0x4403 (1000_EDE4 / 0x1EDE4)
    AX = 0x4403;
    // MOV BX,0x2 (1000_EDE7 / 0x1EDE7)
    BX = 0x2;
    // CALL 0x1000:ed45 (1000_EDEA / 0x1EDEA)
    NearCall(cs1, 0xEDED, call_ems_func_ida_1000_ED45_1ED45);
    // JC 0x1000:edfd (1000_EDED / 0x1EDED)
    if(CarryFlag) {
      goto label_1000_EDFD_1EDFD;
    }
    // MOV AX,CS:[0xed3c] (1000_EDEF / 0x1EDEF)
    AX = UInt16[cs1, 0xED3C];
    // MOV [0xdbb8],AX (1000_EDF3 / 0x1EDF3)
    UInt16[DS, 0xDBB8] = AX;
    // MOV word ptr [0xdbb6],0x4000 (1000_EDF6 / 0x1EDF6)
    UInt16[DS, 0xDBB6] = 0x4000;
    label_1000_EDFC_1EDFC:
    // RET  (1000_EDFC / 0x1EDFC)
    return NearRet();
    label_1000_EDFD_1EDFD:
    // MOV AH,0x45 (1000_EDFD / 0x1EDFD)
    AH = 0x45;
    // JMP 0x1000:ed45 (1000_EDFF / 0x1EDFF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(call_ems_func_ida_1000_ED45_1ED45, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action ems_memory_func_2_ida_1000_EE02_1EE02(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EE02_1EE02:
    // MOV AX,BX (1000_EE02 / 0x1EE02)
    AX = BX;
    // SHL AX,0x1 (1000_EE04 / 0x1EE04)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_EE06 / 0x1EE06)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // XCHG AH,AL (1000_EE08 / 0x1EE08)
    byte tmp_1000_EE08 = AH;
    AH = AL;
    AL = tmp_1000_EE08;
    // AND AX,0x3c00 (1000_EE0A / 0x1EE0A)
    // AX &= 0x3C00;
    AX = Alu.And16(AX, 0x3C00);
    // MOV DI,AX (1000_EE0D / 0x1EE0D)
    DI = AX;
    // SHR BX,0x1 (1000_EE0F / 0x1EE0F)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_EE11 / 0x1EE11)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_EE13 / 0x1EE13)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_EE15 / 0x1EE15)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    label_1000_EE17_1EE17:
    // MOV AX,0x4400 (1000_EE17 / 0x1EE17)
    AX = 0x4400;
    // CALL 0x1000:ed40 (1000_EE1A / 0x1EE1A)
    NearCall(cs1, 0xEE1D, get_ems_emm_handle_ida_1000_ED40_1ED40);
    // JC 0x1000:ee45 (1000_EE1D / 0x1EE1D)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_EE45 / 0x1EE45)
      return NearRet();
    }
    // MOV ES,word ptr CS:[0xed3c] (1000_EE1F / 0x1EE1F)
    ES = UInt16[cs1, 0xED3C];
    // MOV DX,CX (1000_EE24 / 0x1EE24)
    DX = CX;
    // MOV CX,0x4000 (1000_EE26 / 0x1EE26)
    CX = 0x4000;
    // SUB CX,DI (1000_EE29 / 0x1EE29)
    CX -= DI;
    
    // CMP CX,DX (1000_EE2B / 0x1EE2B)
    Alu.Sub16(CX, DX);
    // JC 0x1000:ee31 (1000_EE2D / 0x1EE2D)
    if(CarryFlag) {
      goto label_1000_EE31_1EE31;
    }
    // MOV CX,DX (1000_EE2F / 0x1EE2F)
    CX = DX;
    label_1000_EE31_1EE31:
    // SUB DX,CX (1000_EE31 / 0x1EE31)
    DX -= CX;
    
    // SHR CX,0x1 (1000_EE33 / 0x1EE33)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_EE35 / 0x1EE35)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADC CL,CL (1000_EE37 / 0x1EE37)
    CL = Alu.Adc8(CL, CL);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_EE39 / 0x1EE39)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // MOV CX,DX (1000_EE3B / 0x1EE3B)
    CX = DX;
    // JCXZ 0x1000:ee44 (1000_EE3D / 0x1EE3D)
    if(CX == 0) {
      goto label_1000_EE44_1EE44;
    }
    // INC BX (1000_EE3F / 0x1EE3F)
    BX = Alu.Inc16(BX);
    // XOR DI,DI (1000_EE40 / 0x1EE40)
    DI = 0;
    // JMP 0x1000:ee17 (1000_EE42 / 0x1EE42)
    goto label_1000_EE17_1EE17;
    label_1000_EE44_1EE44:
    // CLC  (1000_EE44 / 0x1EE44)
    CarryFlag = false;
    label_1000_EE45_1EE45:
    // RET  (1000_EE45 / 0x1EE45)
    return NearRet();
  }
  
  public Action ems_memory_func_1_ida_1000_EE46_1EE46(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EE46_1EE46:
    // MOV AX,BX (1000_EE46 / 0x1EE46)
    AX = BX;
    // SHL AX,0x1 (1000_EE48 / 0x1EE48)
    AX <<= 0x1;
    
    // SHL AX,0x1 (1000_EE4A / 0x1EE4A)
    // AX <<= 0x1;
    AX = Alu.Shl16(AX, 0x1);
    // XCHG AH,AL (1000_EE4C / 0x1EE4C)
    byte tmp_1000_EE4C = AH;
    AH = AL;
    AL = tmp_1000_EE4C;
    // AND AX,0x3c00 (1000_EE4E / 0x1EE4E)
    // AX &= 0x3C00;
    AX = Alu.And16(AX, 0x3C00);
    // MOV SI,AX (1000_EE51 / 0x1EE51)
    SI = AX;
    // SHR BX,0x1 (1000_EE53 / 0x1EE53)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_EE55 / 0x1EE55)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_EE57 / 0x1EE57)
    BX >>= 0x1;
    
    // SHR BX,0x1 (1000_EE59 / 0x1EE59)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    label_1000_EE5B_1EE5B:
    // MOV AX,0x4400 (1000_EE5B / 0x1EE5B)
    AX = 0x4400;
    // CALL 0x1000:ed40 (1000_EE5E / 0x1EE5E)
    NearCall(cs1, 0xEE61, get_ems_emm_handle_ida_1000_ED40_1ED40);
    // JC 0x1000:ee45 (1000_EE61 / 0x1EE61)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_EE45 / 0x1EE45)
      return NearRet();
    }
    // MOV DS,word ptr CS:[0xed3c] (1000_EE63 / 0x1EE63)
    DS = UInt16[cs1, 0xED3C];
    // MOV DX,CX (1000_EE68 / 0x1EE68)
    DX = CX;
    // MOV CX,0x4000 (1000_EE6A / 0x1EE6A)
    CX = 0x4000;
    // SUB CX,SI (1000_EE6D / 0x1EE6D)
    CX -= SI;
    
    // CMP CX,DX (1000_EE6F / 0x1EE6F)
    Alu.Sub16(CX, DX);
    // JC 0x1000:ee75 (1000_EE71 / 0x1EE71)
    if(CarryFlag) {
      goto label_1000_EE75_1EE75;
    }
    // MOV CX,DX (1000_EE73 / 0x1EE73)
    CX = DX;
    label_1000_EE75_1EE75:
    // SUB DX,CX (1000_EE75 / 0x1EE75)
    DX -= CX;
    
    // SHR CX,0x1 (1000_EE77 / 0x1EE77)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_EE79 / 0x1EE79)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // ADC CL,CL (1000_EE7B / 0x1EE7B)
    CL = Alu.Adc8(CL, CL);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_EE7D / 0x1EE7D)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // MOV CX,DX (1000_EE7F / 0x1EE7F)
    CX = DX;
    // JCXZ 0x1000:ee88 (1000_EE81 / 0x1EE81)
    if(CX == 0) {
      goto label_1000_EE88_1EE88;
    }
    // INC BX (1000_EE83 / 0x1EE83)
    BX = Alu.Inc16(BX);
    // XOR SI,SI (1000_EE84 / 0x1EE84)
    SI = 0;
    // JMP 0x1000:ee5b (1000_EE86 / 0x1EE86)
    goto label_1000_EE5B_1EE5B;
    label_1000_EE88_1EE88:
    // CLC  (1000_EE88 / 0x1EE88)
    CarryFlag = false;
    // RET  (1000_EE89 / 0x1EE89)
    return NearRet();
  }
  
  public Action initialize_himem_sys_ida_1000_EEA0_1EEA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EEA0_1EEA0:
    // MOV AX,0x4310 (1000_EEA0 / 0x1EEA0)
    AX = 0x4310;
    // INT 0x2f (1000_EEA3 / 0x1EEA3)
    Interrupt(0x2f);
    // MOV word ptr CS:[0xee8c],BX (1000_EEA5 / 0x1EEA5)
    UInt16[cs1, 0xEE8C] = BX;
    // MOV word ptr CS:[0xee8e],ES (1000_EEAA / 0x1EEAA)
    UInt16[cs1, 0xEE8E] = ES;
    // MOV AH,0x8 (1000_EEAF / 0x1EEAF)
    AH = 0x8;
    // CALL 0x1000:ef22 (1000_EEB1 / 0x1EEB1)
    NearCall(cs1, 0xEEB4, call_xms_driver_func_ida_1000_EF22_1EF22);
    // CMP AX,0x3f (1000_EEB4 / 0x1EEB4)
    Alu.Sub16(AX, 0x3F);
    // JC 0x1000:eee3 (1000_EEB7 / 0x1EEB7)
    if(CarryFlag) {
      goto label_1000_EEE3_1EEE3;
    }
    // CMP AX,0x800 (1000_EEB9 / 0x1EEB9)
    Alu.Sub16(AX, 0x800);
    // JC 0x1000:eec1 (1000_EEBC / 0x1EEBC)
    if(CarryFlag) {
      goto label_1000_EEC1_1EEC1;
    }
    // MOV AX,0x800 (1000_EEBE / 0x1EEBE)
    AX = 0x800;
    label_1000_EEC1_1EEC1:
    // MOV [0x39a9],AX (1000_EEC1 / 0x1EEC1)
    UInt16[DS, 0x39A9] = AX;
    // MOV DX,AX (1000_EEC4 / 0x1EEC4)
    DX = AX;
    // MOV AH,0x9 (1000_EEC6 / 0x1EEC6)
    AH = 0x9;
    // CALL 0x1000:ef22 (1000_EEC8 / 0x1EEC8)
    NearCall(cs1, 0xEECB, call_xms_driver_func_ida_1000_EF22_1EF22);
    // JC 0x1000:eee3 (1000_EECB / 0x1EECB)
    if(CarryFlag) {
      goto label_1000_EEE3_1EEE3;
    }
    // MOV word ptr CS:[0xee8a],DX (1000_EECD / 0x1EECD)
    UInt16[cs1, 0xEE8A] = DX;
    // MOV SI,0xef32 (1000_EED2 / 0x1EED2)
    SI = 0xEF32;
    // MOV DI,0xeee9 (1000_EED5 / 0x1EED5)
    DI = 0xEEE9;
    // MOV word ptr CS:[0xea77],DI (1000_EED8 / 0x1EED8)
    UInt16[cs1, 0xEA77] = DI;
    // MOV word ptr CS:[0xea79],SI (1000_EEDD / 0x1EEDD)
    UInt16[cs1, 0xEA79] = SI;
    // RET  (1000_EEE2 / 0x1EEE2)
    return NearRet();
    label_1000_EEE3_1EEE3:
    // AND byte ptr [0x2943],0x7f (1000_EEE3 / 0x1EEE3)
    // UInt8[DS, 0x2943] &= 0x7F;
    UInt8[DS, 0x2943] = Alu.And8(UInt8[DS, 0x2943], 0x7F);
    // RET  (1000_EEE8 / 0x1EEE8)
    return NearRet();
  }
  
  public Action call_xms_driver_func_ida_1000_EF22_1EF22(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EF22_1EF22:
    // CALLF [0xee8c] (1000_EF22 / 0x1EF22)
    // Indirect call to [0xee8c], generating possible targets from emulator records
    uint targetAddress_1000_EF22 = (uint)(UInt16[cs1, 0xEE8E] * 0x10 + UInt16[cs1, 0xEE8C]);
    switch(targetAddress_1000_EF22) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EF22));
        break;
    }
    // CMP AX,0x1 (1000_EF27 / 0x1EF27)
    Alu.Sub16(AX, 0x1);
    // RET  (1000_EF2A / 0x1EF2A)
    return NearRet();
  }
  
  public Action call_xms_func_on_block_ida_1000_EF2B_1EF2B(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EF2B_1EF2B:
    // MOV DX,word ptr CS:[0xee8a] (1000_EF2B / 0x1EF2B)
    DX = UInt16[cs1, 0xEE8A];
    // JMP 0x1000:ef22 (1000_EF30 / 0x1EF30)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(call_xms_driver_func_ida_1000_EF22_1EF22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action xms_move_memory_ida_1000_EF32_1EF32(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EF32_1EF32:
    // PUSH CS (1000_EF32 / 0x1EF32)
    Stack.Push(cs1);
    // POP DS (1000_EF33 / 0x1EF33)
    DS = Stack.Pop();
    // MOV SI,0xee90 (1000_EF34 / 0x1EF34)
    SI = 0xEE90;
    // INC CX (1000_EF37 / 0x1EF37)
    CX = Alu.Inc16(CX);
    // AND CL,0xfe (1000_EF38 / 0x1EF38)
    // CL &= 0xFE;
    CL = Alu.And8(CL, 0xFE);
    // MOV word ptr [SI],CX (1000_EF3B / 0x1EF3B)
    UInt16[DS, SI] = CX;
    // XOR AX,AX (1000_EF3D / 0x1EF3D)
    AX = 0;
    // MOV word ptr [SI + 0x2],AX (1000_EF3F / 0x1EF3F)
    UInt16[DS, (ushort)(SI + 0x2)] = AX;
    // MOV word ptr [SI + 0xa],AX (1000_EF42 / 0x1EF42)
    UInt16[DS, (ushort)(SI + 0xA)] = AX;
    // MOV word ptr [SI + 0xc],DI (1000_EF45 / 0x1EF45)
    UInt16[DS, (ushort)(SI + 0xC)] = DI;
    // MOV word ptr [SI + 0xe],ES (1000_EF48 / 0x1EF48)
    UInt16[DS, (ushort)(SI + 0xE)] = ES;
    // MOV AX,CS:[0xee8a] (1000_EF4B / 0x1EF4B)
    AX = UInt16[cs1, 0xEE8A];
    // MOV word ptr [SI + 0x4],AX (1000_EF4F / 0x1EF4F)
    UInt16[DS, (ushort)(SI + 0x4)] = AX;
    // XOR DX,DX (1000_EF52 / 0x1EF52)
    DX = 0;
    // XCHG BH,BL (1000_EF54 / 0x1EF54)
    byte tmp_1000_EF54 = BH;
    BH = BL;
    BL = tmp_1000_EF54;
    // XCHG DL,BL (1000_EF56 / 0x1EF56)
    byte tmp_1000_EF56 = DL;
    DL = BL;
    BL = tmp_1000_EF56;
    // SHL BX,0x1 (1000_EF58 / 0x1EF58)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // RCL DL,0x1 (1000_EF5A / 0x1EF5A)
    DL = Alu.Rcl8(DL, 0x1);
    // SHL BX,0x1 (1000_EF5C / 0x1EF5C)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // RCL DL,0x1 (1000_EF5E / 0x1EF5E)
    DL = Alu.Rcl8(DL, 0x1);
    // MOV word ptr [SI + 0x6],BX (1000_EF60 / 0x1EF60)
    UInt16[DS, (ushort)(SI + 0x6)] = BX;
    // MOV word ptr [SI + 0x8],DX (1000_EF63 / 0x1EF63)
    UInt16[DS, (ushort)(SI + 0x8)] = DX;
    // MOV AH,0xb (1000_EF66 / 0x1EF66)
    AH = 0xB;
    // JMP 0x1000:ef22 (1000_EF68 / 0x1EF68)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(call_xms_driver_func_ida_1000_EF22_1EF22, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_jump_target_1000_EF6A_01EF6A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EF6A_1EF6A:
    // PUSH AX (1000_EF6A / 0x1EF6A)
    Stack.Push(AX);
    // PUSH DS (1000_EF6B / 0x1EF6B)
    Stack.Push(DS);
    // PUSH ES (1000_EF6C / 0x1EF6C)
    Stack.Push(ES);
    // MOV AX,0x1f4b (1000_EF6D / 0x1EF6D)
    AX = 0x1F4B;
    // MOV DS,AX (1000_EF70 / 0x1EF70)
    DS = AX;
    // CLD  (1000_EF72 / 0x1EF72)
    DirectionFlag = false;
    // CMP byte ptr [0xceea],0x0 (1000_EF73 / 0x1EF73)
    Alu.Sub8(UInt8[DS, 0xCEEA], 0x0);
    // JG 0x1000:efa2 (1000_EF78 / 0x1EF78)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_EFA2_1EFA2;
    }
    // INC word ptr [0xce7a] (1000_EF7A / 0x1EF7A)
    UInt16[DS, 0xCE7A] = Alu.Inc16(UInt16[DS, 0xCE7A]);
    // JNZ 0x1000:ef84 (1000_EF7E / 0x1EF7E)
    if(!ZeroFlag) {
      goto label_1000_EF84_1EF84;
    }
    // INC word ptr [0xce7c] (1000_EF80 / 0x1EF80)
    UInt16[DS, 0xCE7C] = Alu.Inc16(UInt16[DS, 0xCE7C]);
    label_1000_EF84_1EF84:
    // CMP byte ptr [0x2788],0x0 (1000_EF84 / 0x1EF84)
    Alu.Sub8(UInt8[DS, 0x2788], 0x0);
    // JNZ 0x1000:ef9f (1000_EF89 / 0x1EF89)
    if(!ZeroFlag) {
      goto label_1000_EF9F_1EF9F;
    }
    // DEC word ptr [0x46db] (1000_EF8B / 0x1EF8B)
    UInt16[DS, 0x46DB] = Alu.Dec16(UInt16[DS, 0x46DB]);
    // JNS 0x1000:ef9f (1000_EF8F / 0x1EF8F)
    if(!SignFlag) {
      goto label_1000_EF9F_1EF9F;
    }
    // MOV AX,[0x146e] (1000_EF91 / 0x1EF91)
    AX = UInt16[DS, 0x146E];
    // MOV [0x46db],AX (1000_EF94 / 0x1EF94)
    UInt16[DS, 0x46DB] = AX;
    // INC word ptr [0x2] (1000_EF97 / 0x1EF97)
    UInt16[DS, 0x2] = Alu.Inc16(UInt16[DS, 0x2]);
    // INC byte ptr [0x46dd] (1000_EF9B / 0x1EF9B)
    UInt8[DS, 0x46DD] = Alu.Inc8(UInt8[DS, 0x46DD]);
    label_1000_EF9F_1EF9F:
    // CALL 0x1000:efba (1000_EF9F / 0x1EF9F)
    NearCall(cs1, 0xEFA2, spice86_generated_label_call_target_1000_EFBA_01EFBA);
    label_1000_EFA2_1EFA2:
    // POP ES (1000_EFA2 / 0x1EFA2)
    ES = Stack.Pop();
    // DEC byte ptr [0xce72] (1000_EFA3 / 0x1EFA3)
    UInt8[DS, 0xCE72] = Alu.Dec8(UInt8[DS, 0xCE72]);
    // JS 0x1000:efd5 (1000_EFA7 / 0x1EFA7)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_EFD5_01EFD5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AL,0x20 (1000_EFA9 / 0x1EFA9)
    AL = 0x20;
    // OUT 0x20,AL (1000_EFAB / 0x1EFAB)
    Cpu.Out8(0x20, AL);
    // CMP byte ptr [0xdbb5],0x0 (1000_EFAD / 0x1EFAD)
    Alu.Sub8(UInt8[DS, 0xDBB5], 0x0);
    // JZ 0x1000:efb7 (1000_EFB2 / 0x1EFB2)
    if(ZeroFlag) {
      goto label_1000_EFB7_1EFB7;
    }
    // CALL 0x1000:cec9 (1000_EFB4 / 0x1EFB4)
    NearCall(cs1, 0xEFB7, spice86_generated_label_call_target_1000_CEC9_01CEC9);
    label_1000_EFB7_1EFB7:
    // POP DS (1000_EFB7 / 0x1EFB7)
    DS = Stack.Pop();
    // POP AX (1000_EFB8 / 0x1EFB8)
    AX = Stack.Pop();
    // IRET  (1000_EFB9 / 0x1EFB9)
    return InterruptRet();
  }
  
  public Action spice86_generated_label_call_target_1000_EFBA_01EFBA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EFBA_1EFBA:
    // PUSH BX (1000_EFBA / 0x1EFBA)
    Stack.Push(BX);
    // TEST byte ptr [0x2943],0x10 (1000_EFBB / 0x1EFBB)
    Alu.And8(UInt8[DS, 0x2943], 0x10);
    // JNZ 0x1000:efd3 (1000_EFC0 / 0x1EFC0)
    if(!ZeroFlag) {
      goto label_1000_EFD3_1EFD3;
    }
    // PUSH CX (1000_EFC2 / 0x1EFC2)
    Stack.Push(CX);
    // CALLF [0x3981] (1000_EFC3 / 0x1EFC3)
    // Indirect call to [0x3981], generating possible targets from emulator records
    uint targetAddress_1000_EFC3 = (uint)(UInt16[DS, 0x3983] * 0x10 + UInt16[DS, 0x3981] - cs1 * 0x10);
    switch(targetAddress_1000_EFC3) {
      case 0x464EF : FarCall(cs1, 0xEFC7, spice86_generated_label_call_target_563E_010F_0564EF); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_EFC3));
        break;
    }
    label_1000_EFC7_1EFC7:
    // MOV [0xdbcd],AL (1000_EFC7 / 0x1EFC7)
    UInt8[DS, 0xDBCD] = AL;
    // MOV word ptr [0xdbce],BX (1000_EFCA / 0x1EFCA)
    UInt16[DS, 0xDBCE] = BX;
    // MOV word ptr [0xdbd0],CX (1000_EFCE / 0x1EFCE)
    UInt16[DS, 0xDBD0] = CX;
    // POP CX (1000_EFD2 / 0x1EFD2)
    CX = Stack.Pop();
    label_1000_EFD3_1EFD3:
    // POP BX (1000_EFD3 / 0x1EFD3)
    BX = Stack.Pop();
    // RET  (1000_EFD4 / 0x1EFD4)
    return NearRet();
  }
  
  public Action split_1000_EFD5_01EFD5(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EFD5_1EFD5:
    // MOV byte ptr [0xce72],0xa (1000_EFD5 / 0x1EFD5)
    UInt8[DS, 0xCE72] = 0xA;
    // POP DS (1000_EFDA / 0x1EFDA)
    DS = Stack.Pop();
    // POP AX (1000_EFDB / 0x1EFDB)
    AX = Stack.Pop();
    // JMPF 0xf000:0000 (1000_EFDC / 0x1EFDC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_F000_0000_0F0000, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_EFE1_01EFE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EFE1_1EFE1:
    // CALL 0x1000:f08e (1000_EFE1 / 0x1EFE1)
    NearCall(cs1, 0xEFE4, clear_keyboard_array_ida_1000_F08E_1F08E);
    // JMP 0x1000:f031 (1000_EFE4 / 0x1EFE4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(interrupt_handler_0x9_1000_EFE7_1EFE7, 0x1F031 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action interrupt_handler_0x9_1000_EFE7_1EFE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_EFE7_1EFE7:
    // PUSH AX (1000_EFE7 / 0x1EFE7)
    Stack.Push(AX);
    // PUSH CX (1000_EFE8 / 0x1EFE8)
    Stack.Push(CX);
    // PUSH DI (1000_EFE9 / 0x1EFE9)
    Stack.Push(DI);
    // PUSH DS (1000_EFEA / 0x1EFEA)
    Stack.Push(DS);
    // MOV AX,0x1f4b (1000_EFEB / 0x1EFEB)
    AX = 0x1F4B;
    // MOV DS,AX (1000_EFEE / 0x1EFEE)
    DS = AX;
    // CLD  (1000_EFF0 / 0x1EFF0)
    DirectionFlag = false;
    // IN AL,0x60 (1000_EFF1 / 0x1EFF1)
    AL = Cpu.In8(0x60);
    // CMP AL,0xff (1000_EFF3 / 0x1EFF3)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:efe1 (1000_EFF5 / 0x1EFF5)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_EFE1_01EFE1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV DI,AX (1000_EFF7 / 0x1EFF7)
    DI = AX;
    // AND DI,0x7f (1000_EFF9 / 0x1EFF9)
    DI &= 0x7F;
    
    // CMP DI,0x5a (1000_EFFC / 0x1EFFC)
    Alu.Sub16(DI, 0x5A);
    // JNC 0x1000:f031 (1000_EFFF / 0x1EFFF)
    if(!CarryFlag) {
      goto label_1000_F031_1F031;
    }
    // ADD DI,0xce81 (1000_F001 / 0x1F001)
    // DI += 0xCE81;
    DI = Alu.Add16(DI, 0xCE81);
    // CBW  (1000_F005 / 0x1F005)
    AX = (ushort)((short)((sbyte)AL));
    // NOT AH (1000_F006 / 0x1F006)
    AH = (byte)~AH;
    // XCHG AH,AL (1000_F008 / 0x1F008)
    byte tmp_1000_F008 = AH;
    AH = AL;
    AL = tmp_1000_F008;
    // MOV byte ptr [DI],AL (1000_F00A / 0x1F00A)
    UInt8[DS, DI] = AL;
    // OR AL,AL (1000_F00C / 0x1F00C)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:f031 (1000_F00E / 0x1F00E)
    if(ZeroFlag) {
      goto label_1000_F031_1F031;
    }
    // MOV AL,AH (1000_F010 / 0x1F010)
    AL = AH;
    // MOV [0xcee8],AL (1000_F012 / 0x1F012)
    UInt8[DS, 0xCEE8] = AL;
    // CMP AL,0x53 (1000_F015 / 0x1F015)
    Alu.Sub8(AL, 0x53);
    // JNZ 0x1000:f026 (1000_F017 / 0x1F017)
    if(!ZeroFlag) {
      goto label_1000_F026_1F026;
    }
    // MOV AL,[0xceb9] (1000_F019 / 0x1F019)
    AL = UInt8[DS, 0xCEB9];
    // ADD AL,byte ptr [0xce9e] (1000_F01C / 0x1F01C)
    AL += UInt8[DS, 0xCE9E];
    
    // CMP AL,0xfe (1000_F020 / 0x1F020)
    Alu.Sub8(AL, 0xFE);
    // JZ 0x1000:f052 (1000_F022 / 0x1F022)
    if(ZeroFlag) {
      // JZ target is JMPF, inlining.
      // JMPF 0xf000:fff0 (1000_F052 / 0x1F052)
      throw FailAsUntested("Would have been a goto but label label_F000_FFF0_FFFF0 does not exist because no instruction was found there that belongs to a function.");
    }
    // MOV AL,0x53 (1000_F024 / 0x1F024)
    AL = 0x53;
    label_1000_F026_1F026:
    // CMP AL,0x2e (1000_F026 / 0x1F026)
    Alu.Sub8(AL, 0x2E);
    // JNZ 0x1000:f031 (1000_F028 / 0x1F028)
    if(!ZeroFlag) {
      goto label_1000_F031_1F031;
    }
    // CMP byte ptr [0xce9e],0xff (1000_F02A / 0x1F02A)
    Alu.Sub8(UInt8[DS, 0xCE9E], 0xFF);
    // JZ 0x1000:f057 (1000_F02F / 0x1F02F)
    if(ZeroFlag) {
      goto label_1000_F057_1F057;
    }
    label_1000_F031_1F031:
    // CMP AL,0x70 (1000_F031 / 0x1F031)
    Alu.Sub8(AL, 0x70);
    // JNC 0x1000:f049 (1000_F033 / 0x1F033)
    if(!CarryFlag) {
      goto label_1000_F049_1F049;
    }
    // IN AL,0x61 (1000_F035 / 0x1F035)
    AL = Cpu.In8(0x61);
    // OR AL,0x80 (1000_F037 / 0x1F037)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    // OUT 0x61,AL (1000_F039 / 0x1F039)
    Cpu.Out8(0x61, AL);
    // AND AL,0x7f (1000_F03B / 0x1F03B)
    // AL &= 0x7F;
    AL = Alu.And8(AL, 0x7F);
    // OUT 0x61,AL (1000_F03D / 0x1F03D)
    Cpu.Out8(0x61, AL);
    // MOV AL,0x20 (1000_F03F / 0x1F03F)
    AL = 0x20;
    // CLI  (1000_F041 / 0x1F041)
    InterruptFlag = false;
    // OUT 0x20,AL (1000_F042 / 0x1F042)
    Cpu.Out8(0x20, AL);
    // POP DS (1000_F044 / 0x1F044)
    DS = Stack.Pop();
    // POP DI (1000_F045 / 0x1F045)
    DI = Stack.Pop();
    // POP CX (1000_F046 / 0x1F046)
    CX = Stack.Pop();
    // POP AX (1000_F047 / 0x1F047)
    AX = Stack.Pop();
    // IRET  (1000_F048 / 0x1F048)
    return InterruptRet();
    label_1000_F049_1F049:
    // POP DS (1000_F049 / 0x1F049)
    DS = Stack.Pop();
    // POP DI (1000_F04A / 0x1F04A)
    DI = Stack.Pop();
    // POP CX (1000_F04B / 0x1F04B)
    CX = Stack.Pop();
    // POP AX (1000_F04C / 0x1F04C)
    AX = Stack.Pop();
    // JMPF 0xf000:0004 (1000_F04D / 0x1F04D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(provided_interrupt_handler_0x9_F000_0004_F0004, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_F052_1F052:
    // JMPF 0xf000:fff0 (1000_F052 / 0x1F052)
    throw FailAsUntested("Would have been a goto but label label_F000_FFF0_FFFF0 does not exist because no instruction was found there that belongs to a function.");
    label_1000_F057_1F057:
    // CALL 0x1000:f05c (1000_F057 / 0x1F057)
    NearCall(cs1, 0xF05A, reset_keyboard_ida_1000_F05C_1F05C);
    // JMP 0x1000:f031 (1000_F05A / 0x1F05A)
    goto label_1000_F031_1F031;
  }
  
  public Action reset_keyboard_ida_1000_F05C_1F05C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F05C_1F05C:
    // CMP byte ptr [0xceea],0x0 (1000_F05C / 0x1F05C)
    Alu.Sub8(UInt8[DS, 0xCEEA], 0x0);
    // JNZ 0x1000:f08d (1000_F061 / 0x1F061)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_F08D / 0x1F08D)
      return NearRet();
    }
    // PUSH BX (1000_F063 / 0x1F063)
    Stack.Push(BX);
    // PUSH ES (1000_F064 / 0x1F064)
    Stack.Push(ES);
    // MOV AH,0x34 (1000_F065 / 0x1F065)
    AH = 0x34;
    // INT 0x21 (1000_F067 / 0x1F067)
    Interrupt(0x21);
    // MOV AL,byte ptr ES:[BX] (1000_F069 / 0x1F069)
    AL = UInt8[ES, BX];
    // POP ES (1000_F06C / 0x1F06C)
    ES = Stack.Pop();
    // POP BX (1000_F06D / 0x1F06D)
    BX = Stack.Pop();
    // OR AL,AL (1000_F06E / 0x1F06E)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:f08d (1000_F070 / 0x1F070)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_F08D / 0x1F08D)
      return NearRet();
    }
    // INC byte ptr [0xceea] (1000_F072 / 0x1F072)
    UInt8[DS, 0xCEEA] = Alu.Inc8(UInt8[DS, 0xCEEA]);
    // IN AL,0x61 (1000_F076 / 0x1F076)
    AL = Cpu.In8(0x61);
    // OR AL,0x80 (1000_F078 / 0x1F078)
    // AL |= 0x80;
    AL = Alu.Or8(AL, 0x80);
    // OUT 0x61,AL (1000_F07A / 0x1F07A)
    Cpu.Out8(0x61, AL);
    // AND AL,0x7c (1000_F07C / 0x1F07C)
    // AL &= 0x7C;
    AL = Alu.And8(AL, 0x7C);
    // OUT 0x61,AL (1000_F07E / 0x1F07E)
    Cpu.Out8(0x61, AL);
    // MOV AL,0x20 (1000_F080 / 0x1F080)
    AL = 0x20;
    // CLI  (1000_F082 / 0x1F082)
    InterruptFlag = false;
    // OUT 0x20,AL (1000_F083 / 0x1F083)
    Cpu.Out8(0x20, AL);
    // PUSH DS (1000_F085 / 0x1F085)
    Stack.Push(DS);
    // POP SS (1000_F086 / 0x1F086)
    SS = Stack.Pop();
    // MOV SP,0x3cbc (1000_F087 / 0x1F087)
    SP = 0x3CBC;
    // JMP 0x1000:003a (1000_F08A / 0x1F08A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_F08D_1F08D:
    // RET  (1000_F08D / 0x1F08D)
    return NearRet();
  }
  
  public Action clear_keyboard_array_ida_1000_F08E_1F08E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F08E_1F08E:
    // PUSH ES (1000_F08E / 0x1F08E)
    Stack.Push(ES);
    // PUSH DS (1000_F08F / 0x1F08F)
    Stack.Push(DS);
    // POP ES (1000_F090 / 0x1F090)
    ES = Stack.Pop();
    // XOR AX,AX (1000_F091 / 0x1F091)
    AX = 0;
    // MOV [0xcee8],AL (1000_F093 / 0x1F093)
    UInt8[DS, 0xCEE8] = AL;
    // MOV DI,0xce81 (1000_F096 / 0x1F096)
    DI = 0xCE81;
    // MOV CX,0x67 (1000_F099 / 0x1F099)
    CX = 0x67;
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_F09C / 0x1F09C)
      UInt8[ES, DI] = AL;
      DI = (ushort)(DI + Direction8);
    }
    // POP ES (1000_F09E / 0x1F09E)
    ES = Stack.Pop();
    // RET  (1000_F09F / 0x1F09F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F0A0_01F0A0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F0A0_1F0A0:
    // PUSH DI (1000_F0A0 / 0x1F0A0)
    Stack.Push(DI);
    // PUSH ES (1000_F0A1 / 0x1F0A1)
    Stack.Push(ES);
    // INC byte ptr [0xce71] (1000_F0A2 / 0x1F0A2)
    UInt8[DS, 0xCE71] = Alu.Inc8(UInt8[DS, 0xCE71]);
    // PUSH DS (1000_F0A6 / 0x1F0A6)
    Stack.Push(DS);
    // POP ES (1000_F0A7 / 0x1F0A7)
    ES = Stack.Pop();
    // MOV DI,0x4c60 (1000_F0A8 / 0x1F0A8)
    DI = 0x4C60;
    // CALL 0x1000:f0b9 (1000_F0AB / 0x1F0AB)
    NearCall(cs1, 0xF0AE, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_F0AE_1F0AE:
    // DEC byte ptr [0xce71] (1000_F0AE / 0x1F0AE)
    UInt8[DS, 0xCE71] = Alu.Dec8(UInt8[DS, 0xCE71]);
    // MOV SI,DI (1000_F0B2 / 0x1F0B2)
    SI = DI;
    // POP ES (1000_F0B4 / 0x1F0B4)
    ES = Stack.Pop();
    // POP DI (1000_F0B5 / 0x1F0B5)
    DI = Stack.Pop();
    // JMP 0x1000:f403 (1000_F0B6 / 0x1F0B6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F403_01F403, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_F0B9_01F0B9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F0B9_1F0B9:
    // MOV word ptr [0xce78],SI (1000_F0B9 / 0x1F0B9)
    UInt16[DS, 0xCE78] = SI;
    // SHL SI,0x1 (1000_F0BD / 0x1F0BD)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    // MOV SI,word ptr [SI + 0x31ff] (1000_F0BF / 0x1F0BF)
    SI = UInt16[DS, (ushort)(SI + 0x31FF)];
    // LODSW SI (1000_F0C3 / 0x1F0C3)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DX,SI (1000_F0C4 / 0x1F0C4)
    DX = SI;
    // OR AX,AX (1000_F0C6 / 0x1F0C6)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:f0d6 (1000_F0C8 / 0x1F0C8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0D6_01F0D6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV CX,AX (1000_F0CA / 0x1F0CA)
    CX = AX;
    // PUSH DX (1000_F0CC / 0x1F0CC)
    Stack.Push(DX);
    // CALL 0x1000:f11c (1000_F0CD / 0x1F0CD)
    NearCall(cs1, 0xF0D0, spice86_generated_label_call_target_1000_F11C_01F11C);
    label_1000_F0D0_1F0D0:
    // POP DX (1000_F0D0 / 0x1F0D0)
    DX = Stack.Pop();
    // CALL 0x1000:f0d6 (1000_F0D1 / 0x1F0D1)
    NearCall(cs1, 0xF0D4, spice86_generated_label_call_target_1000_F0D6_01F0D6);
    label_1000_F0D4_1F0D4:
    // JMP 0x1000:f0ff (1000_F0D4 / 0x1F0D4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_F0D6_01F0D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F0D6_1F0D6:
    // MOV AX,[0xce78] (1000_F0D6 / 0x1F0D6)
    AX = UInt16[DS, 0xCE78];
    // CMP AL,byte ptr [0xce70] (1000_F0D9 / 0x1F0D9)
    Alu.Sub8(AL, UInt8[DS, 0xCE70]);
    // JNC 0x1000:f0e4 (1000_F0DD / 0x1F0DD)
    if(!CarryFlag) {
      goto label_1000_F0E4_1F0E4;
    }
    // CALL 0x1000:ebe3 (1000_F0DF / 0x1F0DF)
    throw FailAsUntested("Could not find a valid function at address 1000_EBE3 / 0x1EBE3");
    // JC 0x1000:f0f3 (1000_F0E2 / 0x1F0E2)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      // JMP 0x1000:f3d3 (1000_F0F3 / 0x1F0F3)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F3D3_01F3D3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_F0E4_1F0E4:
    // CALL 0x1000:f244 (1000_F0E4 / 0x1F0E4)
    NearCall(cs1, 0xF0E7, spice86_generated_label_call_target_1000_F244_01F244);
    label_1000_F0E7_1F0E7:
    // MOV AX,[0xce78] (1000_F0E7 / 0x1F0E7)
    AX = UInt16[DS, 0xCE78];
    // CMP AL,byte ptr [0xce70] (1000_F0EA / 0x1F0EA)
    Alu.Sub8(AL, UInt8[DS, 0xCE70]);
    // JNC 0x1000:f0f3 (1000_F0EE / 0x1F0EE)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      // JMP 0x1000:f3d3 (1000_F0F3 / 0x1F0F3)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F3D3_01F3D3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:eab7 (1000_F0F0 / 0x1F0F0)
    NearCall(cs1, 0xF0F3, memory_func_qq_ida_1000_EAB7_1EAB7);
    label_1000_F0F3_1F0F3:
    // JMP 0x1000:f3d3 (1000_F0F3 / 0x1F0F3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_F3D3_01F3D3, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_F0F6_01F0F6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F0F6_1F0F6:
    // LES SI,[0x39b7] (1000_F0F6 / 0x1F0F6)
    ES = UInt16[DS, 0x39B9];
    SI = UInt16[DS, 0x39B7];
    // MOV word ptr [DI],SI (1000_F0FA / 0x1F0FA)
    UInt16[DS, DI] = SI;
    // MOV word ptr [DI + 0x2],ES (1000_F0FC / 0x1F0FC)
    UInt16[DS, (ushort)(DI + 0x2)] = ES;
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F0FF_01F0FF, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_F0FF_01F0FF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F0FF_1F0FF:
    // MOV AX,CX (1000_F0FF / 0x1F0FF)
    AX = CX;
    // ADD AX,0xf (1000_F101 / 0x1F101)
    // AX += 0xF;
    AX = Alu.Add16(AX, 0xF);
    // RCR AX,0x1 (1000_F104 / 0x1F104)
    AX = Alu.Rcr16(AX, 0x1);
    // SHR AX,0x1 (1000_F106 / 0x1F106)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_F108 / 0x1F108)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_F10A / 0x1F10A)
    AX >>= 0x1;
    
    // ADD word ptr [0x39b9],AX (1000_F10C / 0x1F10C)
    // UInt16[DS, 0x39B9] += AX;
    UInt16[DS, 0x39B9] = Alu.Add16(UInt16[DS, 0x39B9], AX);
    // PUSH AX (1000_F110 / 0x1F110)
    Stack.Push(AX);
    // MOV AX,[0x39b9] (1000_F111 / 0x1F111)
    AX = UInt16[DS, 0x39B9];
    // CMP AX,word ptr [0xce68] (1000_F114 / 0x1F114)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    // POP AX (1000_F118 / 0x1F118)
    AX = Stack.Pop();
    // JA 0x1000:f131 (1000_F119 / 0x1F119)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F131_01F131, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // RET  (1000_F11B / 0x1F11B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F11C_01F11C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F11C_1F11C:
    // LES DI,[0x39b7] (1000_F11C / 0x1F11C)
    ES = UInt16[DS, 0x39B9];
    DI = UInt16[DS, 0x39B7];
    // MOV AX,ES (1000_F120 / 0x1F120)
    AX = ES;
    // ADD AX,CX (1000_F122 / 0x1F122)
    AX += CX;
    
    // CMP AX,word ptr [0xce68] (1000_F124 / 0x1F124)
    Alu.Sub16(AX, UInt16[DS, 0xCE68]);
    // JNC 0x1000:f12b (1000_F128 / 0x1F128)
    if(!CarryFlag) {
      goto label_1000_F12B_1F12B;
    }
    // RET  (1000_F12A / 0x1F12A)
    return NearRet();
    label_1000_F12B_1F12B:
    // CALL 0x1000:f13f (1000_F12B / 0x1F12B)
    NearCall(cs1, 0xF12E, spice86_generated_label_call_target_1000_F13F_01F13F);
    label_1000_F12E_1F12E:
    // JMP 0x1000:f11c (1000_F12E / 0x1F12E)
    goto label_1000_F11C_1F11C;
  }
  
  public Action split_1000_F130_01F130(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F130_1F130:
    // POP CX (1000_F130 / 0x1F130)
    CX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(split_1000_F131_01F131, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action split_1000_F131_01F131(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F131_1F131:
    // MOV AX,0x1f4b (1000_F131 / 0x1F131)
    AX = 0x1F4B;
    // MOV DS,AX (1000_F134 / 0x1F134)
    DS = AX;
    // MOV word ptr [0x3cbc],0x368d (1000_F136 / 0x1F136)
    UInt16[DS, 0x3CBC] = 0x368D;
    // JMP 0x1000:003a (1000_F13C / 0x1F13C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_F13F_01F13F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F13F_1F13F:
    // PUSH CX (1000_F13F / 0x1F13F)
    Stack.Push(CX);
    // MOV BP,word ptr [0x2] (1000_F140 / 0x1F140)
    BP = UInt16[DS, 0x2];
    // MOV SI,0xd844 (1000_F144 / 0x1F144)
    SI = 0xD844;
    // MOV DI,0xda8c (1000_F147 / 0x1F147)
    DI = 0xDA8C;
    // MOV CX,0x91 (1000_F14A / 0x1F14A)
    CX = 0x91;
    // XOR DX,DX (1000_F14D / 0x1F14D)
    DX = 0;
    // MOV BX,DX (1000_F14F / 0x1F14F)
    BX = DX;
    label_1000_F151_1F151:
    // ADD DI,0x2 (1000_F151 / 0x1F151)
    DI += 0x2;
    
    // ADD SI,0x4 (1000_F154 / 0x1F154)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // MOV AX,word ptr [SI + 0x2] (1000_F157 / 0x1F157)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    // OR AX,AX (1000_F15A / 0x1F15A)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:f16a (1000_F15C / 0x1F15C)
    if(ZeroFlag) {
      goto label_1000_F16A_1F16A;
    }
    // MOV AX,BP (1000_F15E / 0x1F15E)
    AX = BP;
    // SUB AX,word ptr [DI] (1000_F160 / 0x1F160)
    AX -= UInt16[DS, DI];
    
    // CMP AX,DX (1000_F162 / 0x1F162)
    Alu.Sub16(AX, DX);
    // JC 0x1000:f16a (1000_F164 / 0x1F164)
    if(CarryFlag) {
      goto label_1000_F16A_1F16A;
    }
    // MOV DX,AX (1000_F166 / 0x1F166)
    DX = AX;
    // MOV BX,SI (1000_F168 / 0x1F168)
    BX = SI;
    label_1000_F16A_1F16A:
    // LOOP 0x1000:f151 (1000_F16A / 0x1F16A)
    if(--CX != 0) {
      goto label_1000_F151_1F151;
    }
    // OR BX,BX (1000_F16C / 0x1F16C)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JZ 0x1000:f130 (1000_F16E / 0x1F16E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F130_01F130, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // MOV AX,BX (1000_F170 / 0x1F170)
    AX = BX;
    // SUB AX,0xd844 (1000_F172 / 0x1F172)
    AX -= 0xD844;
    
    // SHR AX,0x1 (1000_F175 / 0x1F175)
    AX >>= 0x1;
    
    // SHR AX,0x1 (1000_F177 / 0x1F177)
    AX >>= 0x1;
    
    // CMP AX,word ptr [0x2784] (1000_F179 / 0x1F179)
    Alu.Sub16(AX, UInt16[DS, 0x2784]);
    // JNZ 0x1000:f185 (1000_F17D / 0x1F17D)
    if(!ZeroFlag) {
      goto label_1000_F185_1F185;
    }
    // MOV word ptr [0x2784],0xffff (1000_F17F / 0x1F17F)
    UInt16[DS, 0x2784] = 0xFFFF;
    label_1000_F185_1F185:
    // XOR DX,DX (1000_F185 / 0x1F185)
    DX = 0;
    // XCHG word ptr [BX + 0x2],DX (1000_F187 / 0x1F187)
    ushort tmp_1000_F187 = UInt16[DS, (ushort)(BX + 0x2)];
    UInt16[DS, (ushort)(BX + 0x2)] = DX;
    DX = tmp_1000_F187;
    // MOV SI,0xd84a (1000_F18A / 0x1F18A)
    SI = 0xD84A;
    // MOV CX,0x91 (1000_F18D / 0x1F18D)
    CX = 0x91;
    // MOV BX,0x8000 (1000_F190 / 0x1F190)
    BX = 0x8000;
    label_1000_F193_1F193:
    // LODSW SI (1000_F193 / 0x1F193)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // ADD SI,0x2 (1000_F194 / 0x1F194)
    SI += 0x2;
    
    // SUB AX,DX (1000_F197 / 0x1F197)
    // AX -= DX;
    AX = Alu.Sub16(AX, DX);
    // JC 0x1000:f1a1 (1000_F199 / 0x1F199)
    if(CarryFlag) {
      goto label_1000_F1A1_1F1A1;
    }
    // CMP AX,BX (1000_F19B / 0x1F19B)
    Alu.Sub16(AX, BX);
    // JNC 0x1000:f1a1 (1000_F19D / 0x1F19D)
    if(!CarryFlag) {
      goto label_1000_F1A1_1F1A1;
    }
    // MOV BX,AX (1000_F19F / 0x1F19F)
    BX = AX;
    label_1000_F1A1_1F1A1:
    // LOOP 0x1000:f193 (1000_F1A1 / 0x1F1A1)
    if(--CX != 0) {
      goto label_1000_F193_1F193;
    }
    // OR BX,BX (1000_F1A3 / 0x1F1A3)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    // JS 0x1000:f1f5 (1000_F1A5 / 0x1F1A5)
    if(SignFlag) {
      goto label_1000_F1F5_1F1F5;
    }
    // MOV SI,0xd846 (1000_F1A7 / 0x1F1A7)
    SI = 0xD846;
    // MOV CX,0x91 (1000_F1AA / 0x1F1AA)
    CX = 0x91;
    label_1000_F1AD_1F1AD:
    // ADD SI,0x4 (1000_F1AD / 0x1F1AD)
    SI += 0x4;
    
    // CMP word ptr [SI],DX (1000_F1B0 / 0x1F1B0)
    Alu.Sub16(UInt16[DS, SI], DX);
    // JC 0x1000:f1b6 (1000_F1B2 / 0x1F1B2)
    if(CarryFlag) {
      goto label_1000_F1B6_1F1B6;
    }
    // SUB word ptr [SI],BX (1000_F1B4 / 0x1F1B4)
    // UInt16[DS, SI] -= BX;
    UInt16[DS, SI] = Alu.Sub16(UInt16[DS, SI], BX);
    label_1000_F1B6_1F1B6:
    // LOOP 0x1000:f1ad (1000_F1B6 / 0x1F1B6)
    if(--CX != 0) {
      goto label_1000_F1AD_1F1AD;
    }
    // MOV SI,0xdbb2 (1000_F1B8 / 0x1F1B8)
    SI = 0xDBB2;
    // CMP word ptr [SI],DX (1000_F1BB / 0x1F1BB)
    Alu.Sub16(UInt16[DS, SI], DX);
    // JC 0x1000:f1c1 (1000_F1BD / 0x1F1BD)
    if(CarryFlag) {
      goto label_1000_F1C1_1F1C1;
    }
    // SUB word ptr [SI],BX (1000_F1BF / 0x1F1BF)
    // UInt16[DS, SI] -= BX;
    UInt16[DS, SI] = Alu.Sub16(UInt16[DS, SI], BX);
    label_1000_F1C1_1F1C1:
    // MOV ES,DX (1000_F1C1 / 0x1F1C1)
    ES = DX;
    // ADD DX,BX (1000_F1C3 / 0x1F1C3)
    // DX += BX;
    DX = Alu.Add16(DX, BX);
    // MOV DS,DX (1000_F1C5 / 0x1F1C5)
    DS = DX;
    // XOR SI,SI (1000_F1C7 / 0x1F1C7)
    SI = 0;
    // MOV DI,SI (1000_F1C9 / 0x1F1C9)
    DI = SI;
    // MOV AX,SS:[0x39b9] (1000_F1CB / 0x1F1CB)
    AX = UInt16[SS, 0x39B9];
    // SUB AX,DX (1000_F1CF / 0x1F1CF)
    AX -= DX;
    
    // CMP AX,0x1000 (1000_F1D1 / 0x1F1D1)
    Alu.Sub16(AX, 0x1000);
    // JBE 0x1000:f1e3 (1000_F1D4 / 0x1F1D4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_F1E3_1F1E3;
    }
    // MOV CX,0x8000 (1000_F1D6 / 0x1F1D6)
    CX = 0x8000;
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_F1D9 / 0x1F1D9)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // MOV DX,ES (1000_F1DB / 0x1F1DB)
    DX = ES;
    // ADD DX,0x1000 (1000_F1DD / 0x1F1DD)
    // DX += 0x1000;
    DX = Alu.Add16(DX, 0x1000);
    // JMP 0x1000:f1c1 (1000_F1E1 / 0x1F1E1)
    goto label_1000_F1C1_1F1C1;
    label_1000_F1E3_1F1E3:
    // MOV CX,AX (1000_F1E3 / 0x1F1E3)
    CX = AX;
    // SHL CX,0x1 (1000_F1E5 / 0x1F1E5)
    CX <<= 0x1;
    
    // SHL CX,0x1 (1000_F1E7 / 0x1F1E7)
    CX <<= 0x1;
    
    // SHL CX,0x1 (1000_F1E9 / 0x1F1E9)
    // CX <<= 0x1;
    CX = Alu.Shl16(CX, 0x1);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_F1EB / 0x1F1EB)
      UInt16[ES, DI] = UInt16[DS, SI];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    // PUSH SS (1000_F1ED / 0x1F1ED)
    Stack.Push(SS);
    // POP DS (1000_F1EE / 0x1F1EE)
    DS = Stack.Pop();
    // SUB word ptr [0x39b9],BX (1000_F1EF / 0x1F1EF)
    // UInt16[DS, 0x39B9] -= BX;
    UInt16[DS, 0x39B9] = Alu.Sub16(UInt16[DS, 0x39B9], BX);
    // POP CX (1000_F1F3 / 0x1F1F3)
    CX = Stack.Pop();
    // RET  (1000_F1F4 / 0x1F1F4)
    return NearRet();
    label_1000_F1F5_1F1F5:
    // MOV word ptr [0x39b9],DX (1000_F1F5 / 0x1F1F5)
    UInt16[DS, 0x39B9] = DX;
    // POP CX (1000_F1F9 / 0x1F1F9)
    CX = Stack.Pop();
    // RET  (1000_F1FA / 0x1F1FA)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F1FB_01F1FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F1FB_1F1FB:
    // PUSH DX (1000_F1FB / 0x1F1FB)
    Stack.Push(DX);
    // CALL 0x1000:f2a7 (1000_F1FC / 0x1F1FC)
    NearCall(cs1, 0xF1FF, spice86_generated_label_call_target_1000_F2A7_01F2A7);
    label_1000_F1FF_1F1FF:
    // POP SI (1000_F1FF / 0x1F1FF)
    SI = Stack.Pop();
    // JNC 0x1000:f228 (1000_F200 / 0x1F200)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      // RET  (1000_F228 / 0x1F228)
      return NearRet();
    }
    // MOV DX,SI (1000_F202 / 0x1F202)
    DX = SI;
    label_1000_F204_1F204:
    // PUSH DX (1000_F204 / 0x1F204)
    Stack.Push(DX);
    // CALL 0x1000:f2fc (1000_F205 / 0x1F205)
    NearCall(cs1, 0xF208, spice86_generated_label_call_target_1000_F2FC_01F2FC);
    label_1000_F208_1F208:
    // MOV AX,0x3d00 (1000_F208 / 0x1F208)
    AX = 0x3D00;
    // INT 0x21 (1000_F20B / 0x1F20B)
    Interrupt(0x21);
    // POP DX (1000_F20D / 0x1F20D)
    DX = Stack.Pop();
    // JC 0x1000:f228 (1000_F20E / 0x1F20E)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_F228 / 0x1F228)
      return NearRet();
    }
    // MOV BX,AX (1000_F210 / 0x1F210)
    BX = AX;
    // XOR CX,CX (1000_F212 / 0x1F212)
    CX = 0;
    // MOV DX,CX (1000_F214 / 0x1F214)
    DX = CX;
    // MOV AX,0x4202 (1000_F216 / 0x1F216)
    AX = 0x4202;
    // INT 0x21 (1000_F219 / 0x1F219)
    Interrupt(0x21);
    // PUSH AX (1000_F21B / 0x1F21B)
    Stack.Push(AX);
    // PUSH DX (1000_F21C / 0x1F21C)
    Stack.Push(DX);
    // XOR CX,CX (1000_F21D / 0x1F21D)
    CX = 0;
    // MOV DX,CX (1000_F21F / 0x1F21F)
    DX = CX;
    // MOV AX,0x4200 (1000_F221 / 0x1F221)
    AX = 0x4200;
    // INT 0x21 (1000_F224 / 0x1F224)
    Interrupt(0x21);
    // POP BP (1000_F226 / 0x1F226)
    BP = Stack.Pop();
    // POP CX (1000_F227 / 0x1F227)
    CX = Stack.Pop();
    label_1000_F228_1F228:
    // RET  (1000_F228 / 0x1F228)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F229_01F229(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F229_1F229:
    // CALL 0x1000:f1fb (1000_F229 / 0x1F229)
    NearCall(cs1, 0xF22C, spice86_generated_label_call_target_1000_F1FB_01F1FB);
    label_1000_F22C_1F22C:
    // JC 0x1000:f22f (1000_F22C / 0x1F22C)
    if(CarryFlag) {
      goto label_1000_F22F_1F22F;
    }
    // RET  (1000_F22E / 0x1F22E)
    return NearRet();
    label_1000_F22F_1F22F:
    // MOV SI,DX (1000_F22F / 0x1F22F)
    SI = DX;
    // MOV DI,0x36c4 (1000_F231 / 0x1F231)
    DI = 0x36C4;
    // MOV CX,0xc (1000_F234 / 0x1F234)
    CX = 0xC;
    // PUSH DS (1000_F237 / 0x1F237)
    Stack.Push(DS);
    // POP ES (1000_F238 / 0x1F238)
    ES = Stack.Pop();
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_F239 / 0x1F239)
      UInt8[ES, DI] = UInt8[DS, SI];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    // MOV word ptr [0x3cbc],0x36b4 (1000_F23B / 0x1F23B)
    UInt16[DS, 0x3CBC] = 0x36B4;
    // JMP 0x1000:003a (1000_F241 / 0x1F241)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_F244_01F244(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F244_1F244:
    // PUSH DX (1000_F244 / 0x1F244)
    Stack.Push(DX);
    // CALL 0x1000:f229 (1000_F245 / 0x1F245)
    NearCall(cs1, 0xF248, spice86_generated_label_call_target_1000_F229_01F229);
    label_1000_F248_1F248:
    // POP DX (1000_F248 / 0x1F248)
    DX = Stack.Pop();
    // CMP BX,word ptr [0xdbba] (1000_F249 / 0x1F249)
    Alu.Sub16(BX, UInt16[DS, 0xDBBA]);
    // JNZ 0x1000:f260 (1000_F24D / 0x1F24D)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(read_ffff_to_esdi_and_close_ida_1000_F260_1F260, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // CALL 0x1000:f2ea (1000_F24F / 0x1F24F)
    NearCall(cs1, 0xF252, spice86_generated_label_call_target_1000_F2EA_01F2EA);
    label_1000_F252_1F252:
    // JC 0x1000:f244 (1000_F252 / 0x1F252)
    if(CarryFlag) {
      goto label_1000_F244_1F244;
    }
    // RET  (1000_F254 / 0x1F254)
    return NearRet();
  }
  
  public Action open_nonres_file_ida_1000_F255_1F255(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F255_1F255:
    // PUSH DX (1000_F255 / 0x1F255)
    Stack.Push(DX);
    // PUSH DI (1000_F256 / 0x1F256)
    Stack.Push(DI);
    // PUSH ES (1000_F257 / 0x1F257)
    Stack.Push(ES);
    // CALL 0x1000:f204 (1000_F258 / 0x1F258)
    throw FailAsUntested("Could not find a valid function at address 1000_F204 / 0x1F204");
    // JC 0x1000:f22f (1000_F25B / 0x1F25B)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_F229_01F229, 0x1F22F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // POP ES (1000_F25D / 0x1F25D)
    ES = Stack.Pop();
    // POP DI (1000_F25E / 0x1F25E)
    DI = Stack.Pop();
    // POP DX (1000_F25F / 0x1F25F)
    DX = Stack.Pop();
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(read_ffff_to_esdi_and_close_ida_1000_F260_1F260, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action read_ffff_to_esdi_and_close_ida_1000_F260_1F260(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F260_1F260:
    // PUSH DX (1000_F260 / 0x1F260)
    Stack.Push(DX);
    // PUSH DI (1000_F261 / 0x1F261)
    Stack.Push(DI);
    // PUSH ES (1000_F262 / 0x1F262)
    Stack.Push(ES);
    // PUSH DS (1000_F263 / 0x1F263)
    Stack.Push(DS);
    // PUSH ES (1000_F264 / 0x1F264)
    Stack.Push(ES);
    // POP DS (1000_F265 / 0x1F265)
    DS = Stack.Pop();
    // MOV CX,0xffff (1000_F266 / 0x1F266)
    CX = 0xFFFF;
    // MOV DX,DI (1000_F269 / 0x1F269)
    DX = DI;
    // MOV AH,0x3f (1000_F26B / 0x1F26B)
    AH = 0x3F;
    // INT 0x21 (1000_F26D / 0x1F26D)
    Interrupt(0x21);
    // POP DS (1000_F26F / 0x1F26F)
    DS = Stack.Pop();
    // MOV CX,AX (1000_F270 / 0x1F270)
    CX = AX;
    // PUSHF  (1000_F272 / 0x1F272)
    Stack.Push(FlagRegister);
    // MOV AH,0x3e (1000_F273 / 0x1F273)
    AH = 0x3E;
    // INT 0x21 (1000_F275 / 0x1F275)
    Interrupt(0x21);
    // POPF  (1000_F277 / 0x1F277)
    FlagRegister = Stack.Pop();
    // POP ES (1000_F278 / 0x1F278)
    ES = Stack.Pop();
    // POP DI (1000_F279 / 0x1F279)
    DI = Stack.Pop();
    // POP DX (1000_F27A / 0x1F27A)
    DX = Stack.Pop();
    // RET  (1000_F27B / 0x1F27B)
    return NearRet();
  }
  
  public Action split_1000_F27C_01F27C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F27C_1F27C:
    // PUSH CX (1000_F27C / 0x1F27C)
    Stack.Push(CX);
    // MOV AH,0x3c (1000_F27D / 0x1F27D)
    AH = 0x3C;
    // XOR CX,CX (1000_F27F / 0x1F27F)
    CX = 0;
    // INT 0x21 (1000_F281 / 0x1F281)
    Interrupt(0x21);
    // POP CX (1000_F283 / 0x1F283)
    CX = Stack.Pop();
    // JC 0x1000:f29a (1000_F284 / 0x1F284)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_F29A / 0x1F29A)
      return NearRet();
    }
    // MOV BX,AX (1000_F286 / 0x1F286)
    BX = AX;
    // PUSH DS (1000_F288 / 0x1F288)
    Stack.Push(DS);
    // PUSH ES (1000_F289 / 0x1F289)
    Stack.Push(ES);
    // POP DS (1000_F28A / 0x1F28A)
    DS = Stack.Pop();
    // MOV DX,DI (1000_F28B / 0x1F28B)
    DX = DI;
    // MOV AH,0x40 (1000_F28D / 0x1F28D)
    AH = 0x40;
    // INT 0x21 (1000_F28F / 0x1F28F)
    Interrupt(0x21);
    // POP DS (1000_F291 / 0x1F291)
    DS = Stack.Pop();
    // SUB AX,CX (1000_F292 / 0x1F292)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    // PUSHF  (1000_F294 / 0x1F294)
    Stack.Push(FlagRegister);
    // MOV AH,0x3e (1000_F295 / 0x1F295)
    AH = 0x3E;
    // INT 0x21 (1000_F297 / 0x1F297)
    Interrupt(0x21);
    // POPF  (1000_F299 / 0x1F299)
    FlagRegister = Stack.Pop();
    label_1000_F29A_1F29A:
    // RET  (1000_F29A / 0x1F29A)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F2A7_01F2A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F2A7_1F2A7:
    // PUSH DI (1000_F2A7 / 0x1F2A7)
    Stack.Push(DI);
    // PUSH ES (1000_F2A8 / 0x1F2A8)
    Stack.Push(ES);
    // CMP word ptr [0xdbba],0x1 (1000_F2A9 / 0x1F2A9)
    Alu.Sub16(UInt16[DS, 0xDBBA], 0x1);
    // JC 0x1000:f2d3 (1000_F2AE / 0x1F2AE)
    if(CarryFlag) {
      goto label_1000_F2D3_1F2D3;
    }
    // MOV SI,DX (1000_F2B0 / 0x1F2B0)
    SI = DX;
    // CALL 0x1000:f314 (1000_F2B2 / 0x1F2B2)
    NearCall(cs1, 0xF2B5, spice86_generated_label_call_target_1000_F314_01F314);
    label_1000_F2B5_1F2B5:
    // JC 0x1000:f2d3 (1000_F2B5 / 0x1F2B5)
    if(CarryFlag) {
      goto label_1000_F2D3_1F2D3;
    }
    // CALL 0x1000:f3a7 (1000_F2B7 / 0x1F2B7)
    NearCall(cs1, 0xF2BA, spice86_generated_label_call_target_1000_F3A7_01F3A7);
    label_1000_F2BA_1F2BA:
    // JC 0x1000:f2d3 (1000_F2BA / 0x1F2BA)
    if(CarryFlag) {
      goto label_1000_F2D3_1F2D3;
    }
    // XOR CX,CX (1000_F2BC / 0x1F2BC)
    CX = 0;
    // MOV CL,byte ptr ES:[DI + 0x5] (1000_F2BE / 0x1F2BE)
    CL = UInt8[ES, (ushort)(DI + 0x5)];
    // MOV BP,CX (1000_F2C2 / 0x1F2C2)
    BP = CX;
    // MOV CX,word ptr ES:[DI + 0x3] (1000_F2C4 / 0x1F2C4)
    CX = UInt16[ES, (ushort)(DI + 0x3)];
    // MOV AX,word ptr ES:[DI + 0x6] (1000_F2C8 / 0x1F2C8)
    AX = UInt16[ES, (ushort)(DI + 0x6)];
    // MOV DX,word ptr ES:[DI + 0x8] (1000_F2CC / 0x1F2CC)
    DX = UInt16[ES, (ushort)(DI + 0x8)];
    // CALL 0x1000:f2d6 (1000_F2D0 / 0x1F2D0)
    NearCall(cs1, 0xF2D3, spice86_generated_label_call_target_1000_F2D6_01F2D6);
    label_1000_F2D3_1F2D3:
    // POP ES (1000_F2D3 / 0x1F2D3)
    ES = Stack.Pop();
    // POP DI (1000_F2D4 / 0x1F2D4)
    DI = Stack.Pop();
    // RET  (1000_F2D5 / 0x1F2D5)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F2D6_01F2D6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F2D6_1F2D6:
    // PUSH CX (1000_F2D6 / 0x1F2D6)
    Stack.Push(CX);
    // MOV BX,word ptr SS:[0xdbba] (1000_F2D7 / 0x1F2D7)
    BX = UInt16[SS, 0xDBBA];
    // MOV CX,DX (1000_F2DC / 0x1F2DC)
    CX = DX;
    // MOV DX,AX (1000_F2DE / 0x1F2DE)
    DX = AX;
    // MOV AX,0x4200 (1000_F2E0 / 0x1F2E0)
    AX = 0x4200;
    // INT 0x21 (1000_F2E3 / 0x1F2E3)
    Interrupt(0x21);
    // POP CX (1000_F2E5 / 0x1F2E5)
    CX = Stack.Pop();
    // RET  (1000_F2E6 / 0x1F2E6)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F2EA_01F2EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F2EA_1F2EA:
    // PUSH DS (1000_F2EA / 0x1F2EA)
    Stack.Push(DS);
    // PUSH ES (1000_F2EB / 0x1F2EB)
    Stack.Push(ES);
    // POP DS (1000_F2EC / 0x1F2EC)
    DS = Stack.Pop();
    // MOV BX,word ptr SS:[0xdbba] (1000_F2ED / 0x1F2ED)
    BX = UInt16[SS, 0xDBBA];
    // MOV DX,DI (1000_F2F2 / 0x1F2F2)
    DX = DI;
    // MOV AH,0x3f (1000_F2F4 / 0x1F2F4)
    AH = 0x3F;
    // INT 0x21 (1000_F2F6 / 0x1F2F6)
    Interrupt(0x21);
    // CMP AX,CX (1000_F2F8 / 0x1F2F8)
    Alu.Sub16(AX, CX);
    // POP DS (1000_F2FA / 0x1F2FA)
    DS = Stack.Pop();
    // RET  (1000_F2FB / 0x1F2FB)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F2FC_01F2FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F2FC_1F2FC:
    // PUSH SI (1000_F2FC / 0x1F2FC)
    Stack.Push(SI);
    // PUSH DI (1000_F2FD / 0x1F2FD)
    Stack.Push(DI);
    // MOV SI,DX (1000_F2FE / 0x1F2FE)
    SI = DX;
    // MOV DI,word ptr [0x38a6] (1000_F300 / 0x1F300)
    DI = UInt16[DS, 0x38A6];
    label_1000_F304_1F304:
    // MOV AL,byte ptr [SI] (1000_F304 / 0x1F304)
    AL = UInt8[DS, SI];
    // INC SI (1000_F306 / 0x1F306)
    SI = Alu.Inc16(SI);
    // MOV byte ptr [DI],AL (1000_F307 / 0x1F307)
    UInt8[DS, DI] = AL;
    // INC DI (1000_F309 / 0x1F309)
    DI = Alu.Inc16(DI);
    // OR AL,AL (1000_F30A / 0x1F30A)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JNZ 0x1000:f304 (1000_F30C / 0x1F30C)
    if(!ZeroFlag) {
      goto label_1000_F304_1F304;
    }
    // POP DI (1000_F30E / 0x1F30E)
    DI = Stack.Pop();
    // POP SI (1000_F30F / 0x1F30F)
    SI = Stack.Pop();
    // MOV DX,0x3826 (1000_F310 / 0x1F310)
    DX = 0x3826;
    // RET  (1000_F313 / 0x1F313)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F314_01F314(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F314_1F314:
    // PUSH SS (1000_F314 / 0x1F314)
    Stack.Push(SS);
    // POP ES (1000_F315 / 0x1F315)
    ES = Stack.Pop();
    // CMP word ptr [SI + 0x2],0x505c (1000_F316 / 0x1F316)
    Alu.Sub16(UInt16[DS, (ushort)(SI + 0x2)], 0x505C);
    // JZ 0x1000:f36c (1000_F31B / 0x1F31B)
    if(ZeroFlag) {
      goto label_1000_F36C_1F36C;
    }
    // PUSH SI (1000_F31D / 0x1F31D)
    Stack.Push(SI);
    // MOV CX,0x10 (1000_F31E / 0x1F31E)
    CX = 0x10;
    // MOV DX,CX (1000_F321 / 0x1F321)
    DX = CX;
    label_1000_F323_1F323:
    // LODSB SI (1000_F323 / 0x1F323)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_F324 / 0x1F324)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // LOOPNZ 0x1000:f323 (1000_F326 / 0x1F326)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_F323_1F323;
    }
    // JNZ 0x1000:f32b (1000_F328 / 0x1F328)
    if(!ZeroFlag) {
      goto label_1000_F32B_1F32B;
    }
    // INC CX (1000_F32A / 0x1F32A)
    CX = Alu.Inc16(CX);
    label_1000_F32B_1F32B:
    // SUB CX,0x10 (1000_F32B / 0x1F32B)
    CX -= 0x10;
    
    // NEG CX (1000_F32E / 0x1F32E)
    CX = Alu.Sub16(0, CX);
    // POP SI (1000_F330 / 0x1F330)
    SI = Stack.Pop();
    // XOR DX,DX (1000_F331 / 0x1F331)
    DX = 0;
    // MOV AX,[0xce78] (1000_F333 / 0x1F333)
    AX = UInt16[DS, 0xCE78];
    // MOV DI,AX (1000_F336 / 0x1F336)
    DI = AX;
    // SHL DI,0x1 (1000_F338 / 0x1F338)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    // MOV DI,word ptr [DI + 0x31ff] (1000_F33A / 0x1F33A)
    DI = UInt16[DS, (ushort)(DI + 0x31FF)];
    // ADD DI,0x2 (1000_F33E / 0x1F33E)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // PUSH CX (1000_F341 / 0x1F341)
    Stack.Push(CX);
    // PUSH SI (1000_F342 / 0x1F342)
    Stack.Push(SI);
    // REPE
    while (CX != 0) {
      CX--;
      // CMPSB ES:DI,SI (1000_F343 / 0x1F343)
      Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    // POP SI (1000_F345 / 0x1F345)
    SI = Stack.Pop();
    // POP CX (1000_F346 / 0x1F346)
    CX = Stack.Pop();
    // JZ 0x1000:f3a5 (1000_F347 / 0x1F347)
    if(ZeroFlag) {
      goto label_1000_F3A5_1F3A5;
    }
    // MOV BX,0x31ff (1000_F349 / 0x1F349)
    BX = 0x31FF;
    // MOV BP,0xf7 (1000_F34C / 0x1F34C)
    BP = 0xF7;
    label_1000_F34F_1F34F:
    // MOV DI,word ptr ES:[BX] (1000_F34F / 0x1F34F)
    DI = UInt16[ES, BX];
    // MOV AX,BX (1000_F352 / 0x1F352)
    AX = BX;
    // SUB AX,0x31ff (1000_F354 / 0x1F354)
    AX -= 0x31FF;
    
    // SHR AX,0x1 (1000_F357 / 0x1F357)
    AX >>= 0x1;
    
    // ADD BX,0x2 (1000_F359 / 0x1F359)
    BX += 0x2;
    
    // ADD DI,0x2 (1000_F35C / 0x1F35C)
    // DI += 0x2;
    DI = Alu.Add16(DI, 0x2);
    // PUSH CX (1000_F35F / 0x1F35F)
    Stack.Push(CX);
    // PUSH SI (1000_F360 / 0x1F360)
    Stack.Push(SI);
    // REPE
    while (CX != 0) {
      CX--;
      // CMPSB ES:DI,SI (1000_F361 / 0x1F361)
      Alu.Sub8(UInt8[DS, SI], UInt8[ES, DI]);
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != true) {
        break;
      }
    }
    // POP SI (1000_F363 / 0x1F363)
    SI = Stack.Pop();
    // POP CX (1000_F364 / 0x1F364)
    CX = Stack.Pop();
    // JZ 0x1000:f3a5 (1000_F365 / 0x1F365)
    if(ZeroFlag) {
      goto label_1000_F3A5_1F3A5;
    }
    // DEC BP (1000_F367 / 0x1F367)
    BP = Alu.Dec16(BP);
    // JNZ 0x1000:f34f (1000_F368 / 0x1F368)
    if(!ZeroFlag) {
      goto label_1000_F34F_1F34F;
    }
    // STC  (1000_F36A / 0x1F36A)
    CarryFlag = true;
    // RET  (1000_F36B / 0x1F36B)
    return NearRet();
    label_1000_F36C_1F36C:
    // ADD SI,0x4 (1000_F36C / 0x1F36C)
    // SI += 0x4;
    SI = Alu.Add16(SI, 0x4);
    // LODSB SI (1000_F36F / 0x1F36F)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // SUB AL,0x40 (1000_F370 / 0x1F370)
    // AL -= 0x40;
    AL = Alu.Sub8(AL, 0x40);
    // MOV DL,AL (1000_F372 / 0x1F372)
    DL = AL;
    // XOR BX,BX (1000_F374 / 0x1F374)
    BX = 0;
    // MOV CX,0x3 (1000_F376 / 0x1F376)
    CX = 0x3;
    label_1000_F379_1F379:
    // LODSB SI (1000_F379 / 0x1F379)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0x41 (1000_F37A / 0x1F37A)
    Alu.Sub8(AL, 0x41);
    // JC 0x1000:f380 (1000_F37C / 0x1F37C)
    if(CarryFlag) {
      goto label_1000_F380_1F380;
    }
    // SUB AL,0x7 (1000_F37E / 0x1F37E)
    AL -= 0x7;
    
    label_1000_F380_1F380:
    // AND AL,0xf (1000_F380 / 0x1F380)
    AL &= 0xF;
    
    // SHL BX,0x1 (1000_F382 / 0x1F382)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_F384 / 0x1F384)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_F386 / 0x1F386)
    BX <<= 0x1;
    
    // SHL BX,0x1 (1000_F388 / 0x1F388)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // OR BL,AL (1000_F38A / 0x1F38A)
    // BL |= AL;
    BL = Alu.Or8(BL, AL);
    // LOOP 0x1000:f379 (1000_F38C / 0x1F38C)
    if(--CX != 0) {
      goto label_1000_F379_1F379;
    }
    // LODSB SI (1000_F38E / 0x1F38E)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0x4f (1000_F38F / 0x1F38F)
    Alu.Sub8(AL, 0x4F);
    // CMC  (1000_F391 / 0x1F391)
    CarryFlag = !CarryFlag;
    // RCL DL,0x1 (1000_F392 / 0x1F392)
    DL = Alu.Rcl8(DL, 0x1);
    // LODSB SI (1000_F394 / 0x1F394)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // SUB AL,0x41 (1000_F395 / 0x1F395)
    // AL -= 0x41;
    AL = Alu.Sub8(AL, 0x41);
    // JC 0x1000:f3a3 (1000_F397 / 0x1F397)
    if(CarryFlag) {
      goto label_1000_F3A3_1F3A3;
    }
    // SHL AL,0x1 (1000_F399 / 0x1F399)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_F39B / 0x1F39B)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_F39D / 0x1F39D)
    AL <<= 0x1;
    
    // SHL AL,0x1 (1000_F39F / 0x1F39F)
    // AL <<= 0x1;
    AL = Alu.Shl8(AL, 0x1);
    // OR BH,AL (1000_F3A1 / 0x1F3A1)
    // BH |= AL;
    BH = Alu.Or8(BH, AL);
    label_1000_F3A3_1F3A3:
    // MOV AX,BX (1000_F3A3 / 0x1F3A3)
    AX = BX;
    label_1000_F3A5_1F3A5:
    // CLC  (1000_F3A5 / 0x1F3A5)
    CarryFlag = false;
    // RET  (1000_F3A6 / 0x1F3A6)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_F3A7_01F3A7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F3A7_1F3A7:
    // LES DI,SS:[0xdbbc] (1000_F3A7 / 0x1F3A7)
    ES = UInt16[SS, 0xDBBE];
    DI = UInt16[SS, 0xDBBC];
    // SUB DI,0x5 (1000_F3AC / 0x1F3AC)
    DI -= 0x5;
    
    label_1000_F3AF_1F3AF:
    // ADD DI,0x5 (1000_F3AF / 0x1F3AF)
    DI += 0x5;
    
    // CMP DL,byte ptr ES:[DI + 0x4] (1000_F3B2 / 0x1F3B2)
    Alu.Sub8(DL, UInt8[ES, (ushort)(DI + 0x4)]);
    // JNZ 0x1000:f3bc (1000_F3B6 / 0x1F3B6)
    if(!ZeroFlag) {
      goto label_1000_F3BC_1F3BC;
    }
    // CMP AX,word ptr ES:[DI + 0x2] (1000_F3B8 / 0x1F3B8)
    Alu.Sub16(AX, UInt16[ES, (ushort)(DI + 0x2)]);
    label_1000_F3BC_1F3BC:
    // JA 0x1000:f3af (1000_F3BC / 0x1F3BC)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_F3AF_1F3AF;
    }
    // MOV DI,word ptr ES:[DI] (1000_F3BE / 0x1F3BE)
    DI = UInt16[ES, DI];
    // SUB DI,0xa (1000_F3C1 / 0x1F3C1)
    DI -= 0xA;
    
    label_1000_F3C4_1F3C4:
    // ADD DI,0xa (1000_F3C4 / 0x1F3C4)
    DI += 0xA;
    
    // CMP DL,byte ptr ES:[DI + 0x2] (1000_F3C7 / 0x1F3C7)
    Alu.Sub8(DL, UInt8[ES, (ushort)(DI + 0x2)]);
    // JNZ 0x1000:f3d0 (1000_F3CB / 0x1F3CB)
    if(!ZeroFlag) {
      goto label_1000_F3D0_1F3D0;
    }
    // CMP AX,word ptr ES:[DI] (1000_F3CD / 0x1F3CD)
    Alu.Sub16(AX, UInt16[ES, DI]);
    label_1000_F3D0_1F3D0:
    // JA 0x1000:f3c4 (1000_F3D0 / 0x1F3D0)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_F3C4_1F3C4;
    }
    // RET  (1000_F3D2 / 0x1F3D2)
    return NearRet();
  }
  
  public Action split_1000_F3D3_01F3D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_F3D3_1F3D3:
    // CMP byte ptr [0xce71],0x0 (1000_F3D3 / 0x1F3D3)
    Alu.Sub8(UInt8[DS, 0xCE71], 0x0);
    // JNZ 0x1000:f402 (1000_F3D8 / 0x1F3D8)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_F402 / 0x1F402)
      return NearRet();
    }
    // PUSH CX (1000_F3DA / 0x1F3DA)
    Stack.Push(CX);
    // PUSH DI (1000_F3DB / 0x1F3DB)
    Stack.Push(DI);
    // PUSH DS (1000_F3DC / 0x1F3DC)
    Stack.Push(DS);
    // PUSH ES (1000_F3DD / 0x1F3DD)
    Stack.Push(ES);
    // POP DS (1000_F3DE / 0x1F3DE)
    DS = Stack.Pop();
    // MOV DX,DI (1000_F3DF / 0x1F3DF)
    DX = DI;
    // ADD DX,CX (1000_F3E1 / 0x1F3E1)
    // DX += CX;
    DX = Alu.Add16(DX, CX);
    // MOV CX,0x6 (1000_F3E3 / 0x1F3E3)
    CX = 0x6;
    // MOV SI,DI (1000_F3E6 / 0x1F3E6)
    SI = DI;
    // XOR AX,AX (1000_F3E8 / 0x1F3E8)
    AX = 0;
    label_1000_F3EA_1F3EA:
    // LODSB SI (1000_F3EA / 0x1F3EA)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // ADD AH,AL (1000_F3EB / 0x1F3EB)
    // AH += AL;
    AH = Alu.Add8(AH, AL);
    // LOOP 0x1000:f3ea (1000_F3ED / 0x1F3ED)
    if(--CX != 0) {
      goto label_1000_F3EA_1F3EA;
    }
    // CMP AH,0xab (1000_F3EF / 0x1F3EF)
    Alu.Sub8(AH, 0xAB);
    // JNZ 0x1000:f3fe (1000_F3F2 / 0x1F3F2)
    if(!ZeroFlag) {
      goto label_1000_F3FE_1F3FE;
    }
    // MOV SI,DI (1000_F3F4 / 0x1F3F4)
    SI = DI;
    // LODSW SI (1000_F3F6 / 0x1F3F6)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // MOV DI,AX (1000_F3F7 / 0x1F3F7)
    DI = AX;
    // LODSB SI (1000_F3F9 / 0x1F3F9)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_F3FA / 0x1F3FA)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:f40d (1000_F3FC / 0x1F3FC)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_F40D_01F40D, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_F3FE_1F3FE:
    // STC  (1000_F3FE / 0x1F3FE)
    CarryFlag = true;
    // POP DS (1000_F3FF / 0x1F3FF)
    DS = Stack.Pop();
    // POP DI (1000_F400 / 0x1F400)
    DI = Stack.Pop();
    // POP CX (1000_F401 / 0x1F401)
    CX = Stack.Pop();
    label_1000_F402_1F402:
    // RET  (1000_F402 / 0x1F402)
    return NearRet();
  }
  
}
