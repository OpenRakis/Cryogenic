0800:0000 callback 0x0010
0800:0004 iret
0800:0005 iret
0800:0006 callback 8
0800:000A int 0x1C
0800:000C callback 0x0101
0800:0010 iret
0800:0080 callback 0x0021
0800:0084 iret
0800:00A8 callback 0x0033
0800:00AC iret
100D:0000 mov AX,0xDD1D
100D:0003 call near 0xE4AD
100D:0006 call near 0xE594
100D:0009 call near 0x00B0
100D:000C sti
100D:000D call near 0x0580
100D:003A cld
100D:003B xor AX,AX
100D:003D int 0x33
100D:003F mov AX,0x1F58
100D:0042 mov DS,AX
100D:0044 call near 0xE8D5
100D:0047 cmp word ptr DS:[0x3977],0
100D:004C je short 0x0056
100D:004E call far dword ptr DS:[0x3975]
100D:0052 call far dword ptr DS:[0x398D]
100D:0056 mov AX,3
100D:0059 int 0x10
100D:005B mov SI,word ptr DS:[0x3CBC]
100D:005F or SI,SI
100D:0061 je short 0x006E
100D:006E mov AX,0x0E0D
100D:0071 int 0x10
100D:0073 mov AX,0x0E0A
100D:0076 int 0x10
100D:0078 mov DL,0xFF
100D:007A mov AX,0x0C06
100D:007D int 0x21
100D:007F mov AH,0x4C
100D:0081 int 0x21
100D:0098 mov CX,word ptr ES:[DI]
100D:009B shr CX,1
100D:009D mov BX,DI
100D:009F mov AX,word ptr ES:[DI]
100D:00A2 add AX,BX
100D:00A4 stos word ptr ES:[DI],AX
100D:00A5 loop 0x009F
100D:00A7 ret near
100D:00B0 call near 0x00D1
100D:00B3 call near 0x0169
100D:00B6 call near 0xDA53
100D:00B9 call near 0xB17A
100D:00BC call near 0xB17A
100D:00BF xor AX,AX
100D:00C1 mov ES,AX
100D:00C3 mov AX,word ptr ES:[0x046C]
100D:00C7 mov word ptr DS:[0xD824],AX
100D:00CA mov word ptr DS:[0xD826],AX
100D:00CD mov word ptr DS:[0xD828],AX
100D:00D0 ret near
100D:00D1 push DS
100D:00D2 pop ES
100D:00D3 mov DI,0x4948
100D:00D6 mov SI,0x00BA
100D:00D9 call near 0xF0B9
100D:00DC mov CX,0x018C
100D:00DF mov SI,DI
100D:00E1 lods AX,word ptr DS:[SI]
100D:00E2 xchg AH,AL
100D:00E4 stos word ptr ES:[DI],AX
100D:00E5 loop 0x00E1
100D:00E7 mov DI,0x4880
100D:00EA mov CX,0x0063
100D:00ED mov SI,0x494A
100D:00F0 xor AX,AX
100D:00F2 mov DX,1
100D:00F5 mov BX,word ptr DS:[SI]
100D:00F7 shl BX,1
100D:00F9 div BX
100D:00FB cmp word ptr DS:[SI],DX
100D:00FD adc AX,0
100D:0100 stos word ptr ES:[DI],AX
100D:0101 add SI,8
100D:0104 loop 0x00F0
100D:0106 mov SI,0x00BF
100D:0109 call near 0xF0B9
100D:010C mov AX,DI
100D:010E add AX,0x62FC
100D:0111 mov word ptr DS:[0xDCFE],AX
100D:0114 mov word ptr DS:[0xDD00],ES
100D:0118 push DS
100D:0119 pop ES
100D:011A mov DI,0xAA76
100D:011D mov SI,0x00BD
100D:0120 call near 0xF0A0
100D:0123 call near 0x0098
100D:0126 mov SI,0x00BC
100D:0129 call near 0xF0B9
100D:012C mov word ptr DS:[0xAA72],DI
100D:0130 mov word ptr DS:[0xAA74],ES
100D:0134 call near 0x0098
100D:0137 les AX,word ptr DS:[0x39B7]
100D:013B mov word ptr DS:[0x47AC],AX
100D:013E mov word ptr DS:[0x47AE],ES
100D:0142 mov CX,0x1D4C
100D:0145 call near 0xF0FF
100D:0148 les AX,word ptr DS:[0x39B7]
100D:014C mov word ptr DS:[0x47B0],AX
100D:014F mov word ptr DS:[0x47B2],ES
100D:0153 mov CX,0xADD4
100D:0156 call near 0xF0FF
100D:0159 call near 0xCFB9
100D:015C jmp near 0xC137
100D:0169 mov AX,0x003A
100D:016C call near 0xC13E
100D:016F push DS
100D:0170 pop ES
100D:0171 mov DI,0x4C60
100D:0174 push DI
100D:0175 mov AX,7
100D:0178 mov CX,0x0100
100D:017B rep stos word ptr ES:[DI],AX
100D:017D pop DI
100D:017E les SI,word ptr DS:[0xDBB0]
100D:0182 mov CX,0xC5F9
100D:0185 lods AL,byte ptr ES:[SI]
100D:0187 mov BX,AX
100D:0189 shl BX,1
100D:018B inc word ptr DS:[BX+DI]
100D:018D loop 0x0185
100D:018F mov SI,0x0100
100D:0192 mov DX,word ptr DS:[SI+2]
100D:0195 mov BX,word ptr DS:[SI+4]
100D:0198 call near 0xB5C5
100D:019B mov word ptr DS:[SI+2],DX
100D:019E mov word ptr DS:[SI+6],DI
100D:01A1 or byte ptr ES:[DI],0x40
100D:01A5 mov ES,word ptr DS:[0xDBB2]
100D:01A9 mov AL,byte ptr ES:[DI]
100D:01AC mov byte ptr DS:[SI+0x10],AL
100D:01AF xor BX,BX
100D:01B1 mov BL,AL
100D:01B3 shl BX,1
100D:01B5 mov AX,word ptr DS:[BX+0x4C60]
100D:01B9 mov CL,4
100D:01BB shr AX,CL
100D:01BD mov byte ptr DS:[SI+0x11],AL
100D:01C0 add SI,0x001C
100D:01C3 cmp byte ptr DS:[SI],0xFF
100D:01C6 jne short 0x0192
100D:01C8 mov DI,0x0100
100D:01CB mov BP,0x01E0
100D:01CE mov DX,word ptr DS:[DI+2]
100D:01D1 mov BX,word ptr DS:[DI+4]
100D:01D4 call near 0x6603
100D:01D7 add DI,0x001C
100D:01DA cmp byte ptr DS:[DI],0xFF
100D:01DD jne short 0x01CB
100D:01DF ret near
100D:01E0 mov word ptr DS:[SI+4],DI
100D:01E3 mov word ptr DS:[SI+6],DX
100D:01E6 mov word ptr DS:[SI+8],BX
100D:01E9 mov AL,byte ptr DS:[DI]
100D:01EB mov AH,byte ptr DS:[SI+0x12]
100D:01EE and AX,0x700F
100D:01F1 cmp AL,3
100D:01F3 jbe short 0x0206
100D:01F5 xor AH,0x80
100D:01F8 cmp AL,5
100D:01FA jbe short 0x0206
100D:01FC xor AH,0x80
100D:01FF cmp AL,9
100D:0201 jbe short 0x0206
100D:0203 xor AH,0x80
100D:0206 or AL,AH
100D:0208 mov byte ptr DS:[SI+0x12],AL
100D:020B ret near
100D:0580 call near 0xDE54
100D:0583 je short 0x05FD
100D:0585 call far dword ptr DS:[0x3959]
100D:0589 call near 0xAEB7
100D:058C mov SI,0x0337
100D:058F call near 0x0945
100D:0592 mov AX,0x0018
100D:0595 call far dword ptr DS:[0x3939]
100D:0599 call near 0x093F
100D:059C mov BX,AX
100D:059E inc AX
100D:059F jne short 0x05A3
100D:05A3 call near 0xDE0C
100D:05A6 jb short 0x05FD
100D:05A8 call near 0x0911
100D:05AB call far dword ptr DS:[0x3959]
100D:05AF call near 0x093F
100D:05B2 mov BP,AX
100D:05B4 call near 0xC097
100D:061C call near 0xAD57
100D:061F mov AX,0x0015
100D:0622 jmp near 0xCA1B
100D:0911 call near 0x39E6
100D:0914 call near 0xB930
100D:0917 call near 0x0B21
100D:091A call near 0x9985
100D:091D call near 0x98E6
100D:0920 mov byte ptr DS:[0x22E3],1
100D:0925 mov byte ptr DS:[0x46D7],0
100D:092A mov SI,0x070C
100D:092D call near 0xDA5F
100D:0930 mov SI,0x3916
100D:0933 call near 0xDA5F
100D:0936 call near 0x0A3E
100D:0939 mov SI,0x0826
100D:093C jmp near 0xDA5F
100D:093F mov SI,word ptr DS:[0x4854]
100D:0943 lods AX,word ptr CS:[SI]
100D:0945 mov word ptr DS:[0x4854],SI
100D:0949 ret near
100D:0A3E mov SI,0x0A16
100D:0A41 jmp near 0xDA5F
100D:0B21 call near 0xAC30
100D:0B24 mov byte ptr CS:[0xC13C],0x25
100D:0B2A mov SI,0x0B45
100D:0B2D call near 0xDA5F
100D:0B30 cmp byte ptr DS:[0x227D],0
100D:0B35 jne short 0x0B3E
100D:0B3E mov word ptr DS:[0x3CBE],0
100D:0B44 ret near
100D:39E6 mov SI,0xC0B6
100D:39E9 jmp near 0xDA5F
100D:5B99 push DS
100D:5B9A pop ES
100D:5B9B movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9C movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9D movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9E movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9F ret near
100D:6603 push SI
100D:6604 mov AL,byte ptr DS:[DI+9]
100D:6607 or AL,AL
100D:6609 je short 0x661B
100D:660B call near 0x6906
100D:660E push SI
100D:660F push DI
100D:6610 push BP
100D:6611 call near BP
100D:6613 pop BP
100D:6614 pop DI
100D:6615 pop SI
100D:6616 mov AL,byte ptr DS:[SI+1]
100D:6619 jmp short 0x6607
100D:661B pop SI
100D:661C ret near
100D:6906 mov SI,AX
100D:6908 dec AL
100D:690A mov AH,0x1B
100D:690C mul AH
100D:690E add AX,0x08AA
100D:6911 xchg SI,AX
100D:6912 cmp byte ptr DS:[SI+3],0x80
100D:6916 ret near
100D:94F3 cmp word ptr DS:[0x47C4],0x0010
100D:94F8 jae short 0x9532
100D:9532 ret near
100D:96B5 push word ptr DS:[0x47C4]
100D:96B9 push word ptr DS:[0x47C2]
100D:96BD mov word ptr DS:[0x47C4],0x0010
100D:96C3 mov byte ptr DS:[0x47C2],0x80
100D:96C8 mov SI,word ptr DS:[0xAB84]
100D:96CC call near 0x9F9E
100D:96CF pop word ptr DS:[0x47C2]
100D:96D3 pop word ptr DS:[0x47C4]
100D:96D7 ret near
100D:98E6 call near 0x98F5
100D:98E9 mov word ptr DS:[0x47C8],AX
100D:98EC mov word ptr DS:[0x47AA],AX
100D:98EF mov word ptr DS:[0x479E],AX
100D:98F2 jmp near 0x9B8B
100D:98F5 xor AX,AX
100D:98F7 mov word ptr DS:[0x1C06],AX
100D:98FA mov word ptr DS:[0x1BF8],AX
100D:98FD mov word ptr DS:[0x1BEA],AX
100D:9900 ret near
100D:9985 test word ptr DS:[0x47CE],7
100D:998B jne short 0x9982
100D:998D ret near
100D:9B8B call near 0xA7A5
100D:9B8E xor AX,AX
100D:9B90 mov byte ptr DS:[0x47C3],0
100D:9B95 mov word ptr DS:[0x47CE],AX
100D:9B98 and byte ptr DS:[0x47D1],0x7F
100D:9B9D xchg AX,word ptr DS:[0x47C6]
100D:9BA1 or AX,AX
100D:9BA3 je short 0x9BAB
100D:9BAB ret near
100D:9F9E mov word ptr DS:[0x477C],SI
100D:9FA2 call near 0x94F3
100D:9FA5 mov word ptr DS:[0x47BC],0xA6B0
100D:9FAB mov AX,word ptr DS:[SI]
100D:9FAD cmp AX,0xFFFF
100D:9FB0 je short 0x9F9C
100D:9FB2 test AL,0x80
100D:9FB4 je short 0x9FC0
100D:9FB6 test AL,0x40
100D:9FB8 jne short 0x9FC0
100D:9FBA and AL,byte ptr DS:[0x47C2]
100D:9FBE jne short 0x9FD3
100D:9FC0 push SI
100D:9FC1 mov AL,AH
100D:9FC3 mov AH,byte ptr DS:[SI+2]
100D:9FC6 rol AH,1
100D:9FC8 rol AH,1
100D:9FCA and AH,3
100D:9FCD call near 0xA396
100D:9FD0 pop SI
100D:9FD1 jne short 0x9FD8
100D:9FD3 add SI,4
100D:9FD6 jmp short 0x9FAB
100D:9FD8 cmp byte ptr DS:[0x46EB],0
100D:9FDD jne short 0x9FF7
100D:9FDF mov AX,word ptr DS:[0x47C4]
100D:9FE2 cmp AX,0x0010
100D:9FE5 jae short 0x9FF7
100D:9FF7 push SI
100D:9FF8 lods AX,word ptr DS:[SI]
100D:9FF9 mov word ptr DS:[0x47DE],AX
100D:9FFC lods AX,word ptr DS:[SI]
100D:9FFD xchg AH,AL
100D:9FFF and AX,0x03FF
100D:A002 or AX,0x0800
100D:A005 mov DI,word ptr DS:[0x47BC]
100D:A009 cmp DI,0xA6B0
100D:A00D je short 0xA034
100D:A034 cmp byte ptr DS:[0x00C6],0
100D:A039 jne short 0xA03E
100D:A03E pop SI
100D:A03F call near 0xC85B
100D:A042 cmp word ptr DS:[0x47B6],0
100D:A047 jne short 0xA0AA
100D:A049 mov AL,byte ptr DS:[SI]
100D:A04B and AL,0x0F
100D:A04D je short 0xA05E
100D:A05E mov AL,byte ptr DS:[SI+2]
100D:A061 and AL,0x0C
100D:A063 je short 0xA092
100D:A065 test byte ptr DS:[SI],0x80
100D:A068 jne short 0xA092
100D:A06A mov AX,SI
100D:A06C sub AX,0xAA78
100D:A06F shr AX,1
100D:A071 shr AX,1
100D:A073 mov BL,byte ptr DS:[0x47C4]
100D:A077 shl BL,1
100D:A079 shl BL,1
100D:A07B shl BL,1
100D:A07D or AH,BL
100D:A07F mov BP,word ptr DS:[0x11BD]
100D:A083 mov word ptr CS:[BP],AX
100D:A087 mov word ptr CS:[BP+2],0
100D:A08D add word ptr DS:[0x11BD],2
100D:A092 mov byte ptr DS:[0x0019],0xFF
100D:A097 or byte ptr DS:[SI],0x80
100D:A09A add SI,4
100D:A09D xor AL,AL
100D:A09F xchg AL,byte ptr DS:[0x47A8]
100D:A0A3 or AL,AL
100D:A0A5 je short 0xA0AA
100D:A0AA cmp byte ptr DS:[0x46EB],0
100D:A0AF jne short 0xA0E2
100D:A0B1 cmp word ptr DS:[0x47C4],0x0010
100D:A0B6 jae short 0xA0E2
100D:A0E2 cmp byte ptr DS:[0x00FB],0
100D:A0E7 js short 0xA0EF
100D:A0EF clc
100D:A0F0 ret near
100D:A30B lods AL,byte ptr ES:[SI]
100D:A30D cmp AL,0x80
100D:A30F jae short 0xA32A
100D:A311 push BX
100D:A312 mov BL,byte ptr ES:[SI]
100D:A315 inc SI
100D:A316 xor BH,BH
100D:A318 cmp AL,1
100D:A31A je short 0xA322
100D:A322 mov AL,byte ptr DS:[BX]
100D:A326 xor AH,AH
100D:A328 pop BX
100D:A329 ret near
100D:A396 sub SP,0x0032
100D:A399 mov BP,SP
100D:A39B shl AX,1
100D:A39D les SI,word ptr DS:[0xAA72]
100D:A3A1 add SI,AX
100D:A3A3 mov SI,word ptr ES:[SI-2]
100D:A3A7 call near 0xA30B
100D:A3AA mov DX,AX
100D:A3AC lods AL,byte ptr ES:[SI]
100D:A3AE cmp AL,0xFF
100D:A3B0 je short 0xA3CB
100D:A3CB mov SI,SP
100D:A3CD cmp SI,BP
100D:A3CF je short 0xA3E2
100D:A3E2 add SP,0x0032
100D:A3E5 or DX,DX
100D:A3E7 ret near
100D:A637 test word ptr DS:[0xDBC8],4
100D:A63D jne short 0xA644
100D:A63F mov byte ptr DS:[0x288E],0xFF
100D:A644 mov AL,byte ptr DS:[0x288E]
100D:A647 mov AH,byte ptr DS:[0x28A6]
100D:A64B call far dword ptr DS:[0x39A5]
100D:A64F ret near
100D:A650 test word ptr DS:[0xDBC8],0x0400
100D:A656 jne short 0xA660
100D:A660 mov AH,byte ptr DS:[0x28AE]
100D:A664 mov AL,byte ptr DS:[0x2896]
100D:A667 cmp AL,4
100D:A669 jae short 0xA66D
100D:A66D call far dword ptr DS:[0x3985]
100D:A671 ret near
100D:A788 ret near
100D:A7A5 mov SI,0xA7C2
100D:A7A8 call near 0xDA5F
100D:A7AB mov word ptr DS:[0xDC26],0
100D:A7B1 call near 0xD61D
100D:A7B4 call near 0xABCC
100D:A7B7 je short 0xA788
100D:A87E pushf
100D:A87F sti
100D:A880 call near 0xAE2F
100D:A883 je short 0xA8AF
100D:A8AF popf
100D:A8B0 ret near
100D:ABCC cmp byte ptr DS:[0xDC2B],0
100D:ABD1 ret near
100D:AC30 call far dword ptr DS:[0x3999]
100D:AC34 ret near
100D:AD57 call near 0xAEB7
100D:AD5A mov AL,6
100D:AD5C jmp short 0xAD95
100D:AD95 xor AH,AH
100D:AD97 call near 0xAEC6
100D:AD9A jb short 0xADBD
100D:AD9C cmp AL,byte ptr DS:[0xDBCB]
100D:ADA0 je short 0xADBD
100D:ADA2 call near 0xAE62
100D:ADA5 mov byte ptr DS:[0xDBCB],AL
100D:ADA8 les SI,word ptr DS:[0xDBB6]
100D:ADAC mov AL,byte ptr DS:[0x3810]
100D:ADAF and AL,1
100D:ADB1 call far dword ptr DS:[0x3971]
100D:ADB5 mov byte ptr DS:[0xDBCD],AL
100D:ADB8 xor AX,AX
100D:ADBA mov word ptr DS:[0xDBD2],AX
100D:ADBD ret near
100D:AE28 test word ptr DS:[0xDBC8],0x0100
100D:AE2E ret near
100D:AE2F push AX
100D:AE30 push DS
100D:AE31 mov AX,0x1F58
100D:AE34 mov DS,AX
100D:AE36 test word ptr DS:[0xDBC8],1
100D:AE3C pop DS
100D:AE3D pop AX
100D:AE3E ret near
100D:AE3F call near 0xAE28
100D:AE42 je short 0xAE3E
100D:AE44 mov DI,0xDBB6
100D:AE47 mov AX,word ptr DS:[DI]
100D:AE49 or AX,word ptr DS:[DI+2]
100D:AE4C jne short 0xAE3E
100D:AE4E mov CX,0x9C40
100D:AE51 jmp near 0xF0F6
100D:AE54 call near 0xAE2F
100D:AE57 je short 0xAE3E
100D:AE62 cmp AL,byte ptr DS:[0xDBCA]
100D:AE66 je short 0xAE84
100D:AE68 call near 0xAEB7
100D:AE6B mov byte ptr DS:[0xDBCA],AL
100D:AE6E push AX
100D:AE6F add AX,0x00A4
100D:AE72 mov SI,AX
100D:AE74 les DI,word ptr DS:[0xDBB6]
100D:AE78 mov AX,ES
100D:AE7A cmp AX,word ptr DS:[0xCE68]
100D:AE7E jae short 0xAE85
100D:AE80 call near 0xF0B9
100D:AE83 pop AX
100D:AE84 ret near
100D:AEB7 push AX
100D:AEB8 mov byte ptr DS:[0xDBCB],0
100D:AEBD call far dword ptr DS:[0x3975]
100D:AEC1 mov byte ptr DS:[0xDBCD],AL
100D:AEC4 pop AX
100D:AEC5 ret near
100D:AEC6 test byte ptr DS:[0x2943],0x10
100D:AECB jne short 0xAED4
100D:AECD call near 0xAE28
100D:AED0 je short 0xAED4
100D:AED2 clc
100D:AED3 ret near
100D:B17A mov AL,byte ptr DS:[0x00C6]
100D:B17D push AX
100D:B17E or AL,0x80
100D:B180 mov byte ptr DS:[0x00C6],AL
100D:B183 call near 0x96B5
100D:B186 pop AX
100D:B187 mov byte ptr DS:[0x00C6],AL
100D:B18A ret near
100D:B58B call near 0xB5A0
100D:B58E les DI,word ptr DS:[0xDCFE]
100D:B592 add DI,AX
100D:B594 mov AX,BP
100D:B596 mul DX
100D:B598 shl AX,1
100D:B59A adc DX,0
100D:B59D add DI,DX
100D:B59F ret near
100D:B5A0 push BX
100D:B5A1 shl BX,1
100D:B5A3 shl BX,1
100D:B5A5 shl BX,1
100D:B5A7 jns short 0xB5B9
100D:B5A9 neg BX
100D:B5AB mov AX,word ptr DS:[BX+0x4948]
100D:B5AF neg AX
100D:B5B1 mov BP,word ptr DS:[BX+0x494A]
100D:B5B5 shl BP,1
100D:B5B7 pop BX
100D:B5B8 ret near
100D:B5B9 mov AX,word ptr DS:[BX+0x4948]
100D:B5BD mov BP,word ptr DS:[BX+0x494A]
100D:B5C1 shl BP,1
100D:B5C3 pop BX
100D:B5C4 ret near
100D:B5C5 call near 0xB58B
100D:B5C8 xor AX,AX
100D:B5CA div BP
100D:B5CC mov DX,AX
100D:B5CE ret near
100D:B930 mov byte ptr DS:[0xDD03],0
100D:B935 mov SI,0xB9AE
100D:B938 call near 0xDA5F
100D:B93B mov SI,0xBE57
100D:B93E jmp near 0xDA5F
100D:C07C push word ptr DS:[0xDBD6]
100D:C080 pop word ptr DS:[0xDBDA]
100D:C084 ret near
100D:C08E push word ptr DS:[0xDBD8]
100D:C092 pop word ptr DS:[0xDBDA]
100D:C096 ret near
100D:C097 call near 0xC07C
100D:C09A push word ptr DS:[0xDBD8]
100D:C09E push word ptr DS:[0xDBD6]
100D:C0A2 pop word ptr DS:[0xDBD8]
100D:C0A6 call near BP
100D:C0AD mov ES,word ptr DS:[0xDBDA]
100D:C0B1 call far dword ptr DS:[0x38D5]
100D:C0B5 ret near
100D:C137 xor AX,AX
100D:C139 jmp short 0xC13E
100D:C13E or AX,AX
100D:C140 js short 0xC1A9
100D:C142 push BX
100D:C143 mov BX,AX
100D:C145 xchg BX,word ptr DS:[0x2784]
100D:C149 cmp AX,BX
100D:C14B je short 0xC1A8
100D:C14D push SI
100D:C14E push DI
100D:C14F shl BX,1
100D:C151 js short 0xC15B
100D:C153 mov SI,word ptr DS:[0xCE7B]
100D:C157 mov word ptr DS:[BX-9588],SI
100D:C15B mov SI,AX
100D:C15D shl SI,1
100D:C15F shl SI,1
100D:C161 add SI,0xD844
100D:C165 les DI,word ptr DS:[SI]
100D:C167 mov BX,ES
100D:C169 or BX,BX
100D:C16B je short 0xC177
100D:C177 push CX
100D:C178 push DX
100D:C179 push BP
100D:C17A push SI
100D:C17B mov SI,AX
100D:C17D call near 0xF0B9
100D:C180 cmp word ptr ES:[DI],2
100D:C184 jbe short 0xC189
100D:C189 pop SI
100D:C18A mov DI,word ptr ES:[DI]
100D:C18D sub CX,DI
100D:C18F mov word ptr DS:[SI],DI
100D:C191 mov word ptr DS:[SI+2],ES
100D:C194 mov AX,word ptr DS:[0x2784]
100D:C197 call far dword ptr DS:[0x3905]
100D:C19B pop BP
100D:C19C pop DX
100D:C19D pop CX
100D:C19E mov word ptr DS:[0xDBB0],DI
100D:C1A2 mov word ptr DS:[0xDBB2],ES
100D:C1A6 pop DI
100D:C1A7 pop SI
100D:C1A8 pop BX
100D:C1A9 ret near
100D:C1BA push CX
100D:C1BB push DX
100D:C1BC push DI
100D:C1BD lods AX,word ptr ES:[SI]
100D:C1BF cmp AX,0x0100
100D:C1C2 jne short 0xC1C9
100D:C1C9 mov BX,AX
100D:C1CB inc AX
100D:C1CC je short 0xC1F0
100D:C1F0 pop DI
100D:C1F1 pop DX
100D:C1F2 pop CX
100D:C1F3 ret near
100D:C412 push DS
100D:C413 mov ES,word ptr DS:[0xDBDE]
100D:C417 mov DS,word ptr DS:[0xDBDA]
100D:C41B call far dword ptr SS:[0x38E1]
100D:C420 pop DS
100D:C421 ret near
100D:C85B mov AX,word ptr DS:[0xCE7A]
100D:C85E mov word ptr DS:[0x476E],AX
100D:C861 mov word ptr DS:[0x4772],0x1770
100D:C867 ret near
100D:C921 mov BX,0x33A3
100D:C924 add BX,AX
100D:C926 add BX,AX
100D:C928 mov BX,word ptr DS:[BX]
100D:C92A ret near
100D:C92B mov word ptr DS:[0xDC00],AX
100D:C92E call near 0xCA01
100D:C931 call near 0xCE1A
100D:C934 mov byte ptr DS:[0xDBE7],0
100D:C939 call near 0xCE01
100D:C93C mov AX,word ptr DS:[0xDC00]
100D:C93F mov word ptr DS:[0xDC02],AX
100D:C942 call near 0xC921
100D:C945 mov AX,word ptr DS:[BX]
100D:C947 mov word ptr DS:[0xDBFE],AX
100D:C94A lea DX,BX+2
100D:C94D call near 0xF229
100D:C950 mov word ptr DS:[0x35A6],BX
100D:C954 mov word ptr DS:[0xDC04],AX
100D:C957 mov word ptr DS:[0xDC06],DX
100D:C95B mov word ptr DS:[0xDC08],CX
100D:C95F mov word ptr DS:[0xDC0A],BP
100D:C963 push word ptr DS:[0xDC1A]
100D:C967 push word ptr DS:[0xDC0C]
100D:C96B call near 0xCD8F
100D:C96E jb short 0xC988
100D:C970 add SI,AX
100D:C972 jb short 0xC97A
100D:C974 cmp SI,word ptr DS:[0xCE74]
100D:C978 jbe short 0xC980
100D:C980 sub AX,2
100D:C983 mov CX,AX
100D:C985 call near 0xCDBF
100D:C988 pop word ptr DS:[0xDC0C]
100D:C98C pop word ptr DS:[0xDC1A]
100D:C990 jb short 0xC9E7
100D:C992 les SI,word ptr DS:[0xDC0C]
100D:C996 lods AX,word ptr ES:[SI]
100D:C998 add AX,SI
100D:C99A jb short 0xC9A2
100D:C99C cmp AX,word ptr DS:[0xCE74]
100D:C9A0 jbe short 0xC9A4
100D:C9A4 mov byte ptr DS:[0xDBB4],0xFF
100D:C9A9 call near 0xC1BA
100D:C9AC dec SI
100D:C9AD inc SI
100D:C9AE cmp byte ptr ES:[SI],0xFF
100D:C9B2 je short 0xC9AD
100D:C9B4 xor BX,BX
100D:C9B6 test byte ptr DS:[0xDBFE],4
100D:C9BB je short 0xC9BF
100D:C9BF mov CX,word ptr ES:[BX+SI]
100D:C9C2 mov BX,word ptr ES:[BX+SI+2]
100D:C9C6 mov AX,word ptr DS:[0xDC04]
100D:C9C9 add AX,CX
100D:C9CB mov word ptr DS:[0xDBF6],AX
100D:C9CE mov AX,word ptr DS:[0xDC06]
100D:C9D1 adc AX,BX
100D:C9D3 mov word ptr DS:[0xDBF8],AX
100D:C9D6 mov AX,word ptr DS:[0xDC08]
100D:C9D9 sub AX,CX
100D:C9DB mov word ptr DS:[0xDBFA],AX
100D:C9DE mov AX,word ptr DS:[0xDC0A]
100D:C9E1 sbb AX,BX
100D:C9E3 mov word ptr DS:[0xDBFC],AX
100D:C9E6 clc
100D:C9E7 ret near
100D:CA01 xor BX,BX
100D:CA03 xchg BX,word ptr DS:[0x35A6]
100D:CA07 or BX,BX
100D:CA09 je short 0xCA18
100D:CA0B call near 0xCE01
100D:CA0E cmp BX,word ptr DS:[0xDBBA]
100D:CA12 je short 0xCA18
100D:CA14 mov AH,0x3E
100D:CA16 int 0x21
100D:CA18 xor CX,CX
100D:CA1A ret near
100D:CA1B call near 0xC92B
100D:CAA0 cmp word ptr DS:[0xDC16],0
100D:CAA5 ja short 0xCAD3
100D:CAA7 mov CX,word ptr DS:[0xDC1A]
100D:CAAB stc
100D:CAAC jcxz short 0xCAD3
100D:CAD3 ret near
100D:CD8F mov CX,2
100D:CD92 call near 0xCDBF
100D:CD95 jb short 0xCD9F
100D:CD97 les SI,word ptr DS:[0xDC0C]
100D:CD9B mov AX,word ptr ES:[SI-2]
100D:CD9F ret near
100D:CDBF mov BX,word ptr DS:[0x35A6]
100D:CDC3 cmp BX,1
100D:CDC6 jb short 0xCE00
100D:CDC8 push CX
100D:CDC9 mov CX,word ptr DS:[0xDC06]
100D:CDCD mov DX,word ptr DS:[0xDC04]
100D:CDD1 mov AX,0x4200
100D:CDD4 int 0x21
100D:CDD6 pop CX
100D:CDD7 push DS
100D:CDD8 lds DX,word ptr DS:[0xDC0C]
100D:CDDC mov AH,0x3F
100D:CDDE int 0x21
100D:CDE0 pop DS
100D:CDE1 cmp AX,CX
100D:CDE3 jb short 0xCDC8
100D:CDE5 sub word ptr DS:[0xDC08],AX
100D:CDE9 sbb word ptr DS:[0xDC0A],0
100D:CDEE add word ptr DS:[0xDC04],AX
100D:CDF2 adc word ptr DS:[0xDC06],0
100D:CDF7 add word ptr DS:[0xDC0C],AX
100D:CDFB add word ptr DS:[0xDC1A],AX
100D:CDFF clc
100D:CE00 ret near
100D:CE01 mov word ptr DS:[0xDBE8],0
100D:CE07 mov word ptr DS:[0xDBEA],0
100D:CE0D mov word ptr DS:[0xDBEC],0xFFFF
100D:CE13 mov word ptr DS:[0xDBEE],0xFFFF
100D:CE19 ret near
100D:CE1A mov AX,word ptr DS:[0xDBDE]
100D:CE1D mov word ptr DS:[0xDC0E],AX
100D:CE20 mov word ptr DS:[0xDC12],AX
100D:CE23 xor AX,AX
100D:CE25 mov word ptr DS:[0xDC0C],AX
100D:CE28 mov word ptr DS:[0xDC10],AX
100D:CE2B mov word ptr DS:[0xDC1A],AX
100D:CE2E mov word ptr DS:[0xDC20],AX
100D:CE31 mov word ptr DS:[0xDC16],AX
100D:CE34 mov AX,word ptr DS:[0xCE74]
100D:CE37 mov word ptr DS:[0xDC18],AX
100D:CE3A ret near
100D:CE6C test byte ptr DS:[0x2943],2
100D:CE71 jne short 0xCE7B
100D:CE73 cmp word ptr DS:[0x39A9],0x015E
100D:CE79 jae short 0xCE8A
100D:CE7B mov AX,2
100D:CE7E call near 0xC921
100D:CE81 and byte ptr DS:[BX],0xFB
100D:CE84 inc AX
100D:CE85 cmp AX,9
100D:CE88 jb short 0xCE7E
100D:CE8A test byte ptr DS:[0x2943],3
100D:CE8F je short 0xCE9F
100D:CE9F mov AX,2
100D:CEA2 push AX
100D:CEA3 call near 0xCEB0
100D:CEA6 pop AX
100D:CEA7 inc AX
100D:CEA8 cmp AX,8
100D:CEAB jb short 0xCEA2
100D:CEAD jmp near 0xCA01
100D:CEB0 call near 0xC921
100D:CEB3 push BX
100D:CEB4 call near 0xC92B
100D:CEB7 pop DI
100D:CEB8 jb short 0xCEC8
100D:CEBA test byte ptr DS:[DI],8
100D:CEBD je short 0xCEC8
100D:CEBF sub DI,8
100D:CEC2 mov SI,0xDBF6
100D:CEC5 call near 0x5B99
100D:CEC8 ret near
100D:CEC9 pushf
100D:CECA push BX
100D:CECB push CX
100D:CECC push DX
100D:CECD push SI
100D:CECE push DI
100D:CECF push BP
100D:CED0 push ES
100D:CED1 xor AX,AX
100D:CED3 xchg AL,byte ptr DS:[0xDBB5]
100D:CED7 sti
100D:CED8 push AX
100D:CED9 call near 0xCAA0
100D:CEDC jbe short 0xCEEF
100D:CEDE mov AX,word ptr DS:[0xDC1E]
100D:CEE1 inc AX
100D:CEE2 jne short 0xCEEF
100D:CEEF pop AX
100D:CEF0 mov byte ptr DS:[0xDBB5],AL
100D:CEF3 pop ES
100D:CEF4 pop BP
100D:CEF5 pop DI
100D:CEF6 pop SI
100D:CEF7 pop DX
100D:CEF8 pop CX
100D:CEF9 pop BX
100D:CEFA popf
100D:CEFB ret near
100D:CFB9 xor BX,BX
100D:CFBB mov DI,0xD7F4
100D:CFBE push DS
100D:CFBF pop ES
100D:CFC0 mov SI,word ptr DS:[BX-21898]
100D:CFC4 cmp word ptr DS:[SI],-1
100D:CFC7 jne short 0xCFCE
100D:CFC9 add BX,2
100D:CFCC jmp short 0xCFC0
100D:CFCE mov AX,word ptr DS:[SI+2]
100D:CFD1 xchg AL,AH
100D:CFD3 and AX,0x03FF
100D:CFD6 dec AX
100D:CFD7 stos word ptr ES:[DI],AX
100D:CFD8 and BX,-16
100D:CFDB add BX,0x0010
100D:CFDE cmp BX,0x0110
100D:CFE2 jb short 0xCFC0
100D:CFE4 mov AL,byte ptr DS:[0xCEEB]
100D:CFE7 mov SI,0x00BB
100D:CFEA cmp AL,6
100D:CFEC jne short 0xCFF1
100D:CFF1 mov DI,0xCEEC
100D:CFF4 push DS
100D:CFF5 pop ES
100D:CFF6 call near 0xF0B9
100D:CFF9 mov AL,0xC0
100D:CFFB add AL,byte ptr DS:[0xCEEB]
100D:CFFF xor AH,AH
100D:D001 mov SI,AX
100D:D003 les DI,word ptr DS:[0x47AC]
100D:D007 call near 0xF0B9
100D:D00A call near 0x0098
100D:D00D jmp short 0xD01A
100D:D01A mov AL,0x9A
100D:D01C add AL,byte ptr DS:[0xCEEB]
100D:D020 cmp AL,byte ptr DS:[0x477E]
100D:D024 je short 0xD03B
100D:D026 push SI
100D:D027 mov byte ptr DS:[0x477E],AL
100D:D02A xor AH,AH
100D:D02C mov SI,AX
100D:D02E les DI,word ptr DS:[0x47B0]
100D:D032 call near 0xF0B9
100D:D035 push CX
100D:D036 call near 0x0098
100D:D039 pop CX
100D:D03A pop SI
100D:D03B ret near
100D:D41B mov BP,word ptr DS:[0x21DA]
100D:D41F mov BP,word ptr SS:[BP]
100D:D422 ret near
100D:D61D push AX
100D:D61E mov AX,0x009F
100D:D621 call near 0xE270
100D:D624 call near 0xD41B
100D:D627 mov SI,0x1F7E
100D:D62A cmp word ptr DS:[SI+2],AX
100D:D62D mov word ptr DS:[SI+2],AX
100D:D630 je short 0xD649
100D:D632 cmp BP,SI
100D:D634 jne short 0xD649
100D:D649 call near 0xE283
100D:D64C pop AX
100D:D64D ret near
100D:DA53 mov word ptr DS:[0xDC6A],0
100D:DA59 mov byte ptr DS:[0x46D7],0
100D:DA5E ret near
100D:DA5F mov DI,0xDC6A
100D:DA62 mov CX,word ptr DS:[DI]
100D:DA64 jcxz short 0xDA72
100D:DA72 ret near
100D:DAE3 test byte ptr DS:[0x2942],0x40
100D:DAE8 jne short 0xDB02
100D:DAEA mov AX,word ptr DS:[0xDC36]
100D:DAED mov DX,word ptr DS:[0xDC38]
100D:DAF1 mov CX,word ptr DS:[0x2580]
100D:DAF5 shl AX,CL
100D:DAF7 mov CL,CH
100D:DAF9 shl DX,CL
100D:DAFB mov CX,AX
100D:DAFD mov AX,4
100D:DB00 int 0x33
100D:DB02 ret near
100D:DB03 call near 0xDBB2
100D:DB06 mov word ptr DS:[0xDC36],DX
100D:DB0A mov word ptr DS:[0xDC38],BX
100D:DB0E call near 0xDAE3
100D:DB11 jmp near 0xDBEC
100D:DB14 mov DI,0xDC3A
100D:DB17 mov word ptr DS:[DI],CX
100D:DB19 mov word ptr DS:[DI+2],DX
100D:DB1C mov word ptr DS:[DI+4],AX
100D:DB1F mov word ptr DS:[DI+6],BX
100D:DB22 test byte ptr DS:[0x2942],0x40
100D:DB27 jne short 0xDB43
100D:DB29 push AX
100D:DB2A push BX
100D:DB2B mov AL,byte ptr DS:[0x2580]
100D:DB2E call near 0xDB44
100D:DB31 mov AX,7
100D:DB34 int 0x33
100D:DB36 pop DX
100D:DB37 pop CX
100D:DB38 mov AL,byte ptr DS:[0x2581]
100D:DB3B call near 0xDB44
100D:DB3E mov AX,8
100D:DB41 int 0x33
100D:DB43 ret near
100D:DB44 xchg CX,AX
100D:DB45 shl AX,CL
100D:DB47 shl DX,CL
100D:DB49 mov CX,AX
100D:DB4B ret near
100D:DBB2 push AX
100D:DBB3 mov AL,byte ptr DS:[0xDC46]
100D:DBB6 dec byte ptr DS:[0xDC46]
100D:DBBA js short 0xDBC0
100D:DBC0 or AL,AL
100D:DBC2 js short 0xDBC8
100D:DBC8 pop AX
100D:DBC9 ret near
100D:DBEC inc byte ptr DS:[0xDC46]
100D:DBF0 js short 0xDC1A
100D:DC1A ret near
100D:DE07 push AX
100D:DE08 or AL,1
100D:DE0A pop AX
100D:DE0B ret near
100D:DE0C cmp byte ptr DS:[0xDBCD],0
100D:DE11 jns short 0xDE07
100D:DE54 mov byte ptr DS:[0xCEE9],0
100D:DE59 cmp byte ptr DS:[0xCEE8],1
100D:DE5E jne short 0xDE67
100D:DE67 ret near
100D:E270 push BX
100D:E271 push CX
100D:E272 push DX
100D:E273 push SI
100D:E274 push DI
100D:E275 push BP
100D:E276 mov BP,SP
100D:E278 xchg AX,word ptr SS:[BP+0x0C]
100D:E27B push AX
100D:E27C mov AX,word ptr SS:[BP+0x0C]
100D:E27F mov BP,word ptr SS:[BP]
100D:E282 ret near
100D:E283 pop AX
100D:E284 mov BP,SP
100D:E286 xchg AX,word ptr SS:[BP+0x0C]
100D:E289 pop BP
100D:E28A pop DI
100D:E28B pop SI
100D:E28C pop DX
100D:E28D pop CX
100D:E28E pop BX
100D:E28F ret near
100D:E4AD mov SI,0x0080
100D:E4B0 lods AL,byte ptr DS:[SI]
100D:E4B1 xor AH,AH
100D:E4B3 mov BP,AX
100D:E4B5 add BP,SI
100D:E4B7 push CS
100D:E4B8 pop ES
100D:E4B9 call near 0xE56B
100D:E4BC jb short 0xE4E5
100D:E4BE je short 0xE4B9
100D:E4C0 mov DL,AL
100D:E4C2 call near 0xE56B
100D:E4C5 jbe short 0xE542
100D:E4C7 mov AH,AL
100D:E4C9 call near 0xE56B
100D:E4CC jbe short 0xE542
100D:E4CE xchg AL,DL
100D:E4D0 mov DI,0xE40C
100D:E4D3 mov CX,0x0017
100D:E4D6 scas AX,word ptr ES:[DI]
100D:E4D7 jne short 0xE4DE
100D:E4D9 cmp DL,byte ptr ES:[DI]
100D:E4DC je short 0xE4E6
100D:E4DE add DI,5
100D:E4E1 loop 0xE4D6
100D:E4E5 ret near
100D:E4E6 mov AX,0x1F58
100D:E4E9 mov ES,AX
100D:E4EB mov BL,byte ptr CS:[DI+1]
100D:E4EF xor BH,BH
100D:E4F1 add BX,0x2942
100D:E4F5 mov AL,byte ptr CS:[DI+2]
100D:E4F9 or byte ptr ES:[BX],AL
100D:E4FC mov BX,word ptr CS:[DI+3]
100D:E500 or BX,BX
100D:E502 je short 0xE542
100D:E504 call near 0xE56B
100D:E507 jb short 0xE4E5
100D:E509 je short 0xE542
100D:E50B dec SI
100D:E50C cmp BX,0x3826
100D:E510 je short 0xE54D
100D:E512 xor DX,DX
100D:E514 call near 0xE56B
100D:E517 mov AH,AL
100D:E519 jbe short 0xE537
100D:E51B sub AL,0x30
100D:E51D jb short 0xE537
100D:E51F cmp AL,9
100D:E521 jbe short 0xE52B
100D:E52B shl DX,1
100D:E52D shl DX,1
100D:E52F shl DX,1
100D:E531 shl DX,1
100D:E533 or DL,AL
100D:E535 jmp short 0xE514
100D:E537 mov word ptr ES:[BX],DX
100D:E53A add BX,2
100D:E53D cmp AH,0x20
100D:E540 ja short 0xE512
100D:E542 dec SI
100D:E543 call near 0xE56B
100D:E546 jb short 0xE4E5
100D:E548 jne short 0xE543
100D:E56B mov AL,0x0D
100D:E56D cmp SI,BP
100D:E56F jae short 0xE578
100D:E571 lods AL,byte ptr DS:[SI]
100D:E572 cmp AL,0x61
100D:E574 jb short 0xE578
100D:E578 cmp AL,0x20
100D:E57A ret near
100D:E57B push CX
100D:E57C push SI
100D:E57D add AX,0x00C8
100D:E580 mov SI,AX
100D:E582 call near 0xF0B9
100D:E585 pop SI
100D:E586 pop CX
100D:E587 mov AX,ES
100D:E589 sub AX,0x0010
100D:E58C mov word ptr DS:[SI],AX
100D:E58E add SI,4
100D:E591 loop 0xE58C
100D:E593 ret near
100D:E594 mov AX,0x1F58
100D:E597 mov ES,AX
100D:E599 mov CX,0xDD1D
100D:E59C mov DI,0x3CBC
100D:E59F sub CX,DI
100D:E5A1 cld
100D:E5A2 xor AX,AX
100D:E5A4 rep stos byte ptr ES:[DI],AL
100D:E5A6 mov AX,word ptr DS:[2]
100D:E5A9 push ES
100D:E5AA pop DS
100D:E5AB mov word ptr DS:[0xCE68],AX
100D:E5AE mov CX,0xDD1D
100D:E5B1 call near 0xF0FF
100D:E5B4 mov AX,0x4C6F
100D:E5B7 mov CL,4
100D:E5B9 shr AX,CL
100D:E5BB mov CX,DS
100D:E5BD add AX,CX
100D:E5BF mov word ptr DS:[0xDC32],AX
100D:E5C2 mov AH,0x19
100D:E5C4 int 0x21
100D:E5C6 mov byte ptr DS:[0xCE76],AL
100D:E5C9 mov byte ptr DS:[0xCE77],AL
100D:E5CC mov AX,0x3301
100D:E5CF int 0x21
100D:E5D1 mov byte ptr DS:[0x2941],DL
100D:E5D5 mov AX,0x3301
100D:E5D8 xor DX,DX
100D:E5DA int 0x21
100D:E5DC call near 0xE675
100D:E5DF mov AL,byte ptr DS:[0x2942]
100D:E5E2 and AX,1
100D:E5E5 mov SI,0x38B7
100D:E5E8 mov CX,0x002E
100D:E5EB call near 0xE57B
100D:E5EE call far dword ptr DS:[0x38B9]
100D:E5F2 mov word ptr DS:[0xDBD8],AX
100D:E5F5 call near 0xC08E
100D:E5F8 mov word ptr DS:[0xCE74],CX
100D:E5FC mov DI,0xDBDC
100D:E5FF call near 0xF0F6
100D:E602 mov word ptr DS:[0xDBD6],BP
100D:E606 or BP,BP
100D:E608 jne short 0xE610
100D:E60A mov DI,0xDBD4
100D:E60D call near 0xF0F6
100D:E610 call far dword ptr DS:[0x38B5]
100D:E614 mov AL,byte ptr DS:[0x2942]
100D:E617 push AX
100D:E618 shr AL,1
100D:E61A shr AL,1
100D:E61C and AL,7
100D:E61E mov byte ptr DS:[0xCEEB],AL
100D:E621 pop AX
100D:E622 or AL,AL
100D:E624 jns short 0xE62B
100D:E62B test AL,0x40
100D:E62D jne short 0xE632
100D:E62F call near 0xE97A
100D:E632 call near 0xE85C
100D:E635 call near 0xEA7B
100D:E638 mov AL,byte ptr DS:[0x2942]
100D:E63B and AL,2
100D:E63D mov BP,0xCE7A
100D:E640 call far dword ptr DS:[0x3925]
100D:E644 mov word ptr DS:[0xDC48],0x271C
100D:E64A mov byte ptr DS:[0xDC46],0xFF
100D:E64F xor AX,AX
100D:E651 mov BX,0x00C7
100D:E654 xor CX,CX
100D:E656 mov DX,0x013F
100D:E659 call near 0xDB14
100D:E65C mov BX,0x00AB
100D:E65F mov DX,0x00ED
100D:E662 call near 0xDB03
100D:E665 call near 0xE76A
100D:E668 call near 0xCE6C
100D:E66B call near 0xC07C
100D:E66E call near 0xC0AD
100D:E671 jmp near 0xC412
100D:E675 mov DX,0x37F2
100D:E678 call near 0xF1FB
100D:E67B jb short 0xE692
100D:E692 mov SI,0x37F7
100D:E695 inc byte ptr DS:[SI]
100D:E697 cmp byte ptr DS:[SI],0x39
100D:E69A jbe short 0xE675
100D:E69C mov DX,0x37E9
100D:E69F mov AX,0x3D00
100D:E6A2 int 0x21
100D:E6A4 jb short 0xE674
100D:E6A6 mov word ptr DS:[0xDBBA],AX
100D:E6A9 call near 0xE741
100D:E6AC mov SI,DI
100D:E6AE mov BP,ES
100D:E6B0 les DI,word ptr DS:[0x39B7]
100D:E6B4 mov word ptr DS:[0xDBBC],DI
100D:E6B8 mov word ptr DS:[0xDBBE],ES
100D:E6BC mov AX,0x0145
100D:E6BF stos word ptr ES:[DI],AX
100D:E6C0 mov CX,0x014D
100D:E6C3 mov AL,0xFF
100D:E6C5 rep stos byte ptr ES:[DI],AL
100D:E6C7 mov word ptr DS:[0xD820],DI
100D:E6CB push DS
100D:E6CC mov DS,BP
100D:E6CE lods AX,word ptr DS:[SI]
100D:E6CF push SI
100D:E6D0 call near 0xF314
100D:E6D3 pop SI
100D:E6D4 jb short 0xE702
100D:E6D6 call near 0xF3A7
100D:E6D9 je short 0xE6F9
100D:E6DB push AX
100D:E6DC push DX
100D:E6DD push SI
100D:E6DE push DI
100D:E6DF mov CX,word ptr SS:[0xD820]
100D:E6E4 mov SI,CX
100D:E6E6 sub CX,DI
100D:E6E8 sub SI,2
100D:E6EB lea DI,SI+0x0A
100D:E6EE shr CX,1
100D:E6F0 std
100D:E6F1 rep movs word ptr ES:[DI],word ptr ES:[SI]
100D:E6F4 cld
100D:E6F5 pop DI
100D:E6F6 pop SI
100D:E6F7 pop DX
100D:E6F8 pop AX
100D:E6F9 call near 0xE75B
100D:E6FC add word ptr SS:[0xD820],0x000A
100D:E702 add SI,0x0019
100D:E705 cmp byte ptr DS:[SI],0
100D:E708 jne short 0xE6CF
100D:E70A pop DS
100D:E70B mov SI,0x0145
100D:E70E mov AX,word ptr DS:[0xD820]
100D:E711 sub AX,SI
100D:E713 xor DX,DX
100D:E715 mov CX,0x0280
100D:E718 div CX
100D:E71A mov DX,0x000A
100D:E71D mul DX
100D:E71F mov DX,AX
100D:E721 les DI,word ptr SS:[0xDBBC]
100D:E726 add DI,2
100D:E729 add SI,DX
100D:E72B push SI
100D:E72C movs word ptr ES:[DI],word ptr ES:[SI]
100D:E72E movs byte ptr ES:[DI],byte ptr ES:[SI]
100D:E730 pop SI
100D:E731 mov AX,SI
100D:E733 stos word ptr ES:[DI],AX
100D:E734 cmp DI,0x0140
100D:E738 jb short 0xE729
100D:E73A mov CX,word ptr DS:[0xD820]
100D:E73E jmp near 0xF0FF
100D:E741 xor AX,AX
100D:E743 xor DX,DX
100D:E745 call near 0xF2D6
100D:E748 mov AX,word ptr DS:[0x39B9]
100D:E74B add AX,0x0800
100D:E74E mov ES,AX
100D:E750 xor DI,DI
100D:E752 mov CX,0xFFFF
100D:E755 call near 0xF2EA
100D:E758 jb short 0xE741
100D:E75A ret near
100D:E75B push SI
100D:E75C stos word ptr ES:[DI],AX
100D:E75D mov AL,DL
100D:E75F stos byte ptr ES:[DI],AL
100D:E760 add SI,0x0010
100D:E763 movs word ptr ES:[DI],word ptr DS:[SI]
100D:E764 movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:E765 inc SI
100D:E766 movs word ptr ES:[DI],word ptr DS:[SI]
100D:E767 movs word ptr ES:[DI],word ptr DS:[SI]
100D:E768 pop SI
100D:E769 ret near
100D:E76A mov AL,byte ptr DS:[0x2944]
100D:E76D mov CL,4
100D:E76F shr AL,CL
100D:E771 add AL,7
100D:E773 xor AH,AH
100D:E775 mov SI,0x398B
100D:E778 mov CX,8
100D:E77B call near 0xE57B
100D:E77E mov AX,word ptr DS:[0x39B5]
100D:E781 call far dword ptr DS:[0x3989]
100D:E785 mov word ptr DS:[0xDBC8],BX
100D:E789 call near 0xA637
100D:E78C call near 0xAE54
100D:E78F call near 0xE851
100D:E792 jb short 0xE7BC
100D:E7BC mov AX,word ptr DS:[0x3813]
100D:E7BF mov word ptr DS:[0x381B],AX
100D:E7C2 call near 0xA87E
100D:E7C5 mov AL,byte ptr DS:[0x2944]
100D:E7C8 and AX,0x000F
100D:E7CB add AX,2
100D:E7CE mov SI,0x396F
100D:E7D1 mov CX,7
100D:E7D4 call near 0xE57B
100D:E7D7 mov BP,0x3349
100D:E7DA mov CX,0x000A
100D:E7DD mov AX,word ptr DS:[0x39B3]
100D:E7E0 call far dword ptr DS:[0x396D]
100D:E7E4 or word ptr DS:[0xDBC8],BX
100D:E7E8 call near 0xA650
100D:E7EB call near 0xAE3F
100D:E7EE call near 0xE851
100D:E7F1 jb short 0xE818
100D:E818 call near 0xAE28
100D:E81B je short 0xE825
100D:E81D call near 0xE826
100D:E820 and byte ptr DS:[0x2943],0xEF
100D:E825 ret near
100D:E826 cmp word ptr DS:[0xDBBA],0
100D:E82B je short 0xE850
100D:E82D call near 0xE741
100D:E830 push DS
100D:E831 mov SI,DI
100D:E833 push ES
100D:E834 pop DS
100D:E835 lods AX,word ptr DS:[SI]
100D:E836 mov CX,0x00FA
100D:E839 push CX
100D:E83A push SI
100D:E83B call near 0xF314
100D:E83E pop SI
100D:E83F jb short 0xE849
100D:E841 call near 0xF3A7
100D:E844 jne short 0xE849
100D:E846 call near 0xE75B
100D:E849 add SI,0x0019
100D:E84C pop CX
100D:E84D loop 0xE839
100D:E84F pop DS
100D:E850 ret near
100D:E851 mov AX,word ptr DS:[0x39B9]
100D:E854 add AX,0x2F13
100D:E857 cmp AX,word ptr DS:[0xCE68]
100D:E85B ret near
100D:E85C cli
100D:E85D call near 0xE913
100D:E860 xor AX,AX
100D:E862 mov ES,AX
100D:E864 mov DI,0x0020
100D:E867 mov word ptr ES:[DI],0xE8B8
100D:E86C pushf
100D:E86D sti
100D:E86E cmp byte ptr CS:[0xE8D4],0
100D:E874 je short 0xE86E
100D:E876 popf
100D:E877 mov word ptr ES:[DI],0xEF6A
100D:E87C mov AX,word ptr CS:[0xE8D2]
100D:E880 or AH,AH
100D:E882 je short 0xE8A5
100D:E884 or AL,AL
100D:E886 je short 0xE8A5
100D:E888 xor DX,DX
100D:E88A mov CX,0x1745
100D:E88D div CX
100D:E88F shl DX,1
100D:E891 cmp DX,CX
100D:E893 jb short 0xE896
100D:E895 inc AX
100D:E896 dec AX
100D:E897 jns short 0xE89A
100D:E89A cmp AX,0x000A
100D:E89D jb short 0xE8A1
100D:E8A1 mov byte ptr CS:[0xEFD9],AL
100D:E8A5 mov AX,0x1745
100D:E8A8 pushf
100D:E8A9 push AX
100D:E8AA cli
100D:E8AB mov AL,0x36
100D:E8AD out 0x43,AL
100D:E8AF pop AX
100D:E8B0 out 0x40,AL
100D:E8B2 mov AL,AH
100D:E8B4 out 0x40,AL
100D:E8B6 popf
100D:E8B7 ret near
100D:E8B8 push AX
100D:E8B9 mov AL,0x36
100D:E8BB out 0x43,AL
100D:E8BD in AL,0x40
100D:E8BF mov AH,AL
100D:E8C1 in AL,0x40
100D:E8C3 xchg AH,AL
100D:E8C5 mov word ptr CS:[0xE8D2],AX
100D:E8C9 inc byte ptr CS:[0xE8D4]
100D:E8CE pop AX
100D:E8CF jmp near 0xEF6A
100D:E8D5 cmp word ptr CS:[0xEE8A],0
100D:E8DB je short 0xE8E2
100D:E8E2 cmp word ptr CS:[0xED3A],0
100D:E8E8 je short 0xE8EF
100D:E8EF mov DX,word ptr CS:[0xED3E]
100D:E8F4 or DX,DX
100D:E8F6 je short 0xE8FD
100D:E8FD xor AX,AX
100D:E8FF call near 0xE8A8
100D:E902 mov DL,byte ptr DS:[0x2941]
100D:E906 mov AX,0x3301
100D:E909 int 0x21
100D:E90B cmp byte ptr DS:[0xCE73],0
100D:E910 jne short 0xE913
100D:E913 xor byte ptr DS:[0xCE73],0xFF
100D:E918 mov SI,0x2913
100D:E91B pushf
100D:E91C cli
100D:E91D lods AX,word ptr DS:[SI]
100D:E91E mov DI,AX
100D:E920 lods AX,word ptr DS:[SI]
100D:E921 xchg DI,AX
100D:E922 push SI
100D:E923 mov SI,AX
100D:E925 shl SI,1
100D:E927 shl SI,1
100D:E929 xor AX,AX
100D:E92B mov ES,AX
100D:E92D mov AX,word ptr CS:[DI]
100D:E930 xchg AX,word ptr ES:[SI]
100D:E933 mov word ptr CS:[DI],AX
100D:E936 mov AX,word ptr CS:[DI+2]
100D:E93A xchg AX,word ptr ES:[SI+2]
100D:E93E mov word ptr CS:[DI+2],AX
100D:E942 pop SI
100D:E943 lods AX,word ptr DS:[SI]
100D:E944 or AX,AX
100D:E946 jns short 0xE91E
100D:E948 popf
100D:E949 ret near
100D:E97A mov AX,0x3533
100D:E97D int 0x21
100D:E97F mov AX,ES
100D:E981 or AX,BX
100D:E983 je short 0xE9F3
100D:E985 mov AX,0
100D:E988 int 0x33
100D:E98A inc AX
100D:E98B jne short 0xE9F3
100D:E98D xor CX,CX
100D:E98F xor DX,DX
100D:E991 mov AX,4
100D:E994 int 0x33
100D:E996 inc byte ptr DS:[0x2580]
100D:E99A js short 0xE9B3
100D:E99C mov CL,byte ptr DS:[0x2580]
100D:E9A0 mov AX,1
100D:E9A3 shl AX,CL
100D:E9A5 mov CX,AX
100D:E9A7 mov AX,4
100D:E9AA int 0x33
100D:E9AC mov AX,3
100D:E9AF int 0x33
100D:E9B1 jcxz short 0xE996
100D:E9B3 inc byte ptr DS:[0x2581]
100D:E9B7 js short 0xE9D0
100D:E9B9 mov CL,byte ptr DS:[0x2581]
100D:E9BD mov DX,1
100D:E9C0 shl DX,CL
100D:E9C2 mov AX,4
100D:E9C5 int 0x33
100D:E9C7 mov AX,3
100D:E9CA int 0x33
100D:E9CC or DX,DX
100D:E9CE je short 0xE9B3
100D:E9D0 mov AX,0x0010
100D:E9D3 mov DX,AX
100D:E9D5 and word ptr DS:[0x2580],0x7F7F
100D:E9DB mov CX,word ptr DS:[0x2580]
100D:E9DF shr AX,CL
100D:E9E1 mov CL,CH
100D:E9E3 shr DX,CL
100D:E9E5 mov CX,AX
100D:E9E7 mov AX,0x000F
100D:E9EA push DX
100D:E9EB int 0x33
100D:E9ED pop DX
100D:E9EE mov AX,0x0013
100D:E9F1 int 0x33
100D:E9F3 ret near
100D:EA7B test byte ptr DS:[0x2943],0x80
100D:EA80 je short 0xEA85
100D:EA85 test byte ptr DS:[0x2943],0x48
100D:EA8A je short 0xEA8F
100D:EA8F test byte ptr DS:[0x2943],0xE8
100D:EA94 je short 0xEAB6
100D:EAB6 ret near
100D:EF6A push AX
100D:EF6B push DS
100D:EF6C push ES
100D:EF6D mov AX,0x1F58
100D:EF70 mov DS,AX
100D:EF72 cld
100D:EF73 cmp byte ptr DS:[0xCEEA],0
100D:EF78 jg short 0xEFA2
100D:EF7A inc word ptr DS:[0xCE7A]
100D:EF7E jne short 0xEF84
100D:EF84 cmp byte ptr DS:[0x2788],0
100D:EF89 jne short 0xEF9F
100D:EF9F call near 0xEFBA
100D:EFA2 pop ES
100D:EFA3 dec byte ptr DS:[0xCE72]
100D:EFA7 js short 0xEFD5
100D:EFA9 mov AL,0x20
100D:EFAB out 0x20,AL
100D:EFAD cmp byte ptr DS:[0xDBB5],0
100D:EFB2 je short 0xEFB7
100D:EFB4 call near 0xCEC9
100D:EFB7 pop DS
100D:EFB8 pop AX
100D:EFB9 iret
100D:EFBA push BX
100D:EFBB test byte ptr DS:[0x2943],0x10
100D:EFC0 jne short 0xEFD3
100D:EFC2 push CX
100D:EFC3 call far dword ptr DS:[0x3981]
100D:EFC7 mov byte ptr DS:[0xDBCD],AL
100D:EFCA mov word ptr DS:[0xDBCE],BX
100D:EFCE mov word ptr DS:[0xDBD0],CX
100D:EFD2 pop CX
100D:EFD3 pop BX
100D:EFD4 ret near
100D:EFD5 mov byte ptr DS:[0xCE72],0x0A
100D:EFDA pop DS
100D:EFDB pop AX
100D:EFDC jmp far 0800:0006
100D:F0A0 push DI
100D:F0A1 push ES
100D:F0A2 inc byte ptr DS:[0xCE71]
100D:F0A6 push DS
100D:F0A7 pop ES
100D:F0A8 mov DI,0x4C60
100D:F0AB call near 0xF0B9
100D:F0AE dec byte ptr DS:[0xCE71]
100D:F0B2 mov SI,DI
100D:F0B4 pop ES
100D:F0B5 pop DI
100D:F0B6 jmp near 0xF403
100D:F0B9 mov word ptr DS:[0xCE78],SI
100D:F0BD shl SI,1
100D:F0BF mov SI,word ptr DS:[SI+0x31FF]
100D:F0C3 lods AX,word ptr DS:[SI]
100D:F0C4 mov DX,SI
100D:F0C6 or AX,AX
100D:F0C8 je short 0xF0D6
100D:F0CA mov CX,AX
100D:F0CC push DX
100D:F0CD call near 0xF11C
100D:F0D0 pop DX
100D:F0D1 call near 0xF0D6
100D:F0D4 jmp short 0xF0FF
100D:F0D6 mov AX,word ptr DS:[0xCE78]
100D:F0D9 cmp AL,byte ptr DS:[0xCE70]
100D:F0DD jae short 0xF0E4
100D:F0E4 call near 0xF244
100D:F0E7 mov AX,word ptr DS:[0xCE78]
100D:F0EA cmp AL,byte ptr DS:[0xCE70]
100D:F0EE jae short 0xF0F3
100D:F0F3 jmp near 0xF3D3
100D:F0F6 les SI,word ptr DS:[0x39B7]
100D:F0FA mov word ptr DS:[DI],SI
100D:F0FC mov word ptr DS:[DI+2],ES
100D:F0FF mov AX,CX
100D:F101 add AX,0x000F
100D:F104 rcr AX,1
100D:F106 shr AX,1
100D:F108 shr AX,1
100D:F10A shr AX,1
100D:F10C add word ptr DS:[0x39B9],AX
100D:F110 push AX
100D:F111 mov AX,word ptr DS:[0x39B9]
100D:F114 cmp AX,word ptr DS:[0xCE68]
100D:F118 pop AX
100D:F119 ja short 0xF131
100D:F11B ret near
100D:F11C les DI,word ptr DS:[0x39B7]
100D:F120 mov AX,ES
100D:F122 add AX,CX
100D:F124 cmp AX,word ptr DS:[0xCE68]
100D:F128 jae short 0xF12B
100D:F12A ret near
100D:F1FB push DX
100D:F1FC call near 0xF2A7
100D:F1FF pop SI
100D:F200 jae short 0xF228
100D:F202 mov DX,SI
100D:F204 push DX
100D:F205 call near 0xF2FC
100D:F208 mov AX,0x3D00
100D:F20B int 0x21
100D:F20D pop DX
100D:F20E jb short 0xF228
100D:F228 ret near
100D:F229 call near 0xF1FB
100D:F22C jb short 0xF22F
100D:F22E ret near
100D:F22F mov SI,DX
100D:F231 mov DI,0x36C4
100D:F234 mov CX,0x000C
100D:F237 push DS
100D:F238 pop ES
100D:F239 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:F23B mov word ptr DS:[0x3CBC],0x36B4
100D:F241 jmp near 0x003A
100D:F244 push DX
100D:F245 call near 0xF229
100D:F248 pop DX
100D:F249 cmp BX,word ptr DS:[0xDBBA]
100D:F24D jne short 0xF260
100D:F24F call near 0xF2EA
100D:F252 jb short 0xF244
100D:F254 ret near
100D:F2A7 push DI
100D:F2A8 push ES
100D:F2A9 cmp word ptr DS:[0xDBBA],1
100D:F2AE jb short 0xF2D3
100D:F2B0 mov SI,DX
100D:F2B2 call near 0xF314
100D:F2B5 jb short 0xF2D3
100D:F2B7 call near 0xF3A7
100D:F2BA jb short 0xF2D3
100D:F2BC xor CX,CX
100D:F2BE mov CL,byte ptr ES:[DI+5]
100D:F2C2 mov BP,CX
100D:F2C4 mov CX,word ptr ES:[DI+3]
100D:F2C8 mov AX,word ptr ES:[DI+6]
100D:F2CC mov DX,word ptr ES:[DI+8]
100D:F2D0 call near 0xF2D6
100D:F2D3 pop ES
100D:F2D4 pop DI
100D:F2D5 ret near
100D:F2D6 push CX
100D:F2D7 mov BX,word ptr SS:[0xDBBA]
100D:F2DC mov CX,DX
100D:F2DE mov DX,AX
100D:F2E0 mov AX,0x4200
100D:F2E3 int 0x21
100D:F2E5 pop CX
100D:F2E6 ret near
100D:F2EA push DS
100D:F2EB push ES
100D:F2EC pop DS
100D:F2ED mov BX,word ptr SS:[0xDBBA]
100D:F2F2 mov DX,DI
100D:F2F4 mov AH,0x3F
100D:F2F6 int 0x21
100D:F2F8 cmp AX,CX
100D:F2FA pop DS
100D:F2FB ret near
100D:F2FC push SI
100D:F2FD push DI
100D:F2FE mov SI,DX
100D:F300 mov DI,word ptr DS:[0x38A6]
100D:F304 mov AL,byte ptr DS:[SI]
100D:F306 inc SI
100D:F307 mov byte ptr DS:[DI],AL
100D:F309 inc DI
100D:F30A or AL,AL
100D:F30C jne short 0xF304
100D:F30E pop DI
100D:F30F pop SI
100D:F310 mov DX,0x3826
100D:F313 ret near
100D:F314 push SS
100D:F315 pop ES
100D:F316 cmp word ptr DS:[SI+2],0x505C
100D:F31B je short 0xF36C
100D:F31D push SI
100D:F31E mov CX,0x0010
100D:F321 mov DX,CX
100D:F323 lods AL,byte ptr DS:[SI]
100D:F324 or AL,AL
100D:F326 loopne 0xF323
100D:F328 jne short 0xF32B
100D:F32A inc CX
100D:F32B sub CX,0x0010
100D:F32E neg CX
100D:F330 pop SI
100D:F331 xor DX,DX
100D:F333 mov AX,word ptr DS:[0xCE78]
100D:F336 mov DI,AX
100D:F338 shl DI,1
100D:F33A mov DI,word ptr DS:[DI+0x31FF]
100D:F33E add DI,2
100D:F341 push CX
100D:F342 push SI
100D:F343 repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
100D:F345 pop SI
100D:F346 pop CX
100D:F347 je short 0xF3A5
100D:F349 mov BX,0x31FF
100D:F34C mov BP,0x00F7
100D:F34F mov DI,word ptr ES:[BX]
100D:F352 mov AX,BX
100D:F354 sub AX,0x31FF
100D:F357 shr AX,1
100D:F359 add BX,2
100D:F35C add DI,2
100D:F35F push CX
100D:F360 push SI
100D:F361 repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
100D:F363 pop SI
100D:F364 pop CX
100D:F365 je short 0xF3A5
100D:F367 dec BP
100D:F368 jne short 0xF34F
100D:F36A stc
100D:F36B ret near
100D:F36C add SI,4
100D:F36F lods AL,byte ptr DS:[SI]
100D:F370 sub AL,0x40
100D:F372 mov DL,AL
100D:F374 xor BX,BX
100D:F376 mov CX,3
100D:F379 lods AL,byte ptr DS:[SI]
100D:F37A cmp AL,0x41
100D:F37C jb short 0xF380
100D:F37E sub AL,7
100D:F380 and AL,0x0F
100D:F382 shl BX,1
100D:F384 shl BX,1
100D:F386 shl BX,1
100D:F388 shl BX,1
100D:F38A or BL,AL
100D:F38C loop 0xF379
100D:F38E lods AL,byte ptr DS:[SI]
100D:F38F cmp AL,0x4F
100D:F391 cmc
100D:F392 rcl DL,1
100D:F394 lods AL,byte ptr DS:[SI]
100D:F395 sub AL,0x41
100D:F397 jb short 0xF3A3
100D:F399 shl AL,1
100D:F39B shl AL,1
100D:F39D shl AL,1
100D:F39F shl AL,1
100D:F3A1 or BH,AL
100D:F3A3 mov AX,BX
100D:F3A5 clc
100D:F3A6 ret near
100D:F3A7 les DI,word ptr SS:[0xDBBC]
100D:F3AC sub DI,5
100D:F3AF add DI,5
100D:F3B2 cmp DL,byte ptr ES:[DI+4]
100D:F3B6 jne short 0xF3BC
100D:F3B8 cmp AX,word ptr ES:[DI+2]
100D:F3BC ja short 0xF3AF
100D:F3BE mov DI,word ptr ES:[DI]
100D:F3C1 sub DI,0x000A
100D:F3C4 add DI,0x000A
100D:F3C7 cmp DL,byte ptr ES:[DI+2]
100D:F3CB jne short 0xF3D0
100D:F3CD cmp AX,word ptr ES:[DI]
100D:F3D0 ja short 0xF3C4
100D:F3D2 ret near
100D:F3D3 cmp byte ptr DS:[0xCE71],0
100D:F3D8 jne short 0xF402
100D:F3DA push CX
100D:F3DB push DI
100D:F3DC push DS
100D:F3DD push ES
100D:F3DE pop DS
100D:F3DF mov DX,DI
100D:F3E1 add DX,CX
100D:F3E3 mov CX,6
100D:F3E6 mov SI,DI
100D:F3E8 xor AX,AX
100D:F3EA lods AL,byte ptr DS:[SI]
100D:F3EB add AH,AL
100D:F3ED loop 0xF3EA
100D:F3EF cmp AH,0xAB
100D:F3F2 jne short 0xF3FE
100D:F3F4 mov SI,DI
100D:F3F6 lods AX,word ptr DS:[SI]
100D:F3F7 mov DI,AX
100D:F3F9 lods AL,byte ptr DS:[SI]
100D:F3FA or AL,AL
100D:F3FC je short 0xF40D
100D:F3FE stc
100D:F3FF pop DS
100D:F400 pop DI
100D:F401 pop CX
100D:F402 ret near
100D:F403 push CX
100D:F404 push DI
100D:F405 push DS
100D:F406 add SI,6
100D:F409 xor BP,BP
100D:F40B jmp short 0xF435
100D:F40D lods AX,word ptr DS:[SI]
100D:F40E mov CX,AX
100D:F410 sub SI,5
100D:F413 mov BP,SI
100D:F415 add DI,SI
100D:F417 add DI,0x0040
100D:F41A add SI,CX
100D:F41C dec SI
100D:F41D dec DI
100D:F41E sub CX,6
100D:F421 std
100D:F422 shr CX,1
100D:F424 jae short 0xF427
100D:F426 movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:F427 dec SI
100D:F428 dec DI
100D:F429 rep movs word ptr ES:[DI],word ptr DS:[SI]
100D:F42B cld
100D:F42C mov SI,DI
100D:F42E add SI,2
100D:F431 mov DI,BP
100D:F433 xor BP,BP
100D:F435 shr BP,1
100D:F437 je short 0xF43E
100D:F439 jae short 0xF446
100D:F43B movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:F43C jmp short 0xF435
100D:F43E lods AX,word ptr DS:[SI]
100D:F43F mov BP,AX
100D:F441 stc
100D:F442 rcr BP,1
100D:F444 jb short 0xF43B
100D:F446 xor CX,CX
100D:F448 shr BP,1
100D:F44A jne short 0xF452
100D:F44C lods AX,word ptr DS:[SI]
100D:F44D mov BP,AX
100D:F44F stc
100D:F450 rcr BP,1
100D:F452 jb short 0xF482
100D:F454 shr BP,1
100D:F456 jne short 0xF45E
100D:F458 lods AX,word ptr DS:[SI]
100D:F459 mov BP,AX
100D:F45B stc
100D:F45C rcr BP,1
100D:F45E rcl CX,1
100D:F460 shr BP,1
100D:F462 jne short 0xF46A
100D:F464 lods AX,word ptr DS:[SI]
100D:F465 mov BP,AX
100D:F467 stc
100D:F468 rcr BP,1
100D:F46A rcl CX,1
100D:F46C lods AL,byte ptr DS:[SI]
100D:F46D mov AH,0xFF
100D:F46F add AX,DI
100D:F471 xchg SI,AX
100D:F472 mov BX,DS
100D:F474 mov DX,ES
100D:F476 mov DS,DX
100D:F478 inc CX
100D:F479 inc CX
100D:F47A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:F47C mov DS,BX
100D:F47E mov SI,AX
100D:F480 jmp short 0xF435
100D:F482 lods AX,word ptr DS:[SI]
100D:F483 mov CL,AL
100D:F485 shr AX,1
100D:F487 shr AX,1
100D:F489 shr AX,1
100D:F48B or AH,0xE0
100D:F48E and CL,7
100D:F491 jne short 0xF46F
100D:F493 mov BX,AX
100D:F495 lods AL,byte ptr DS:[SI]
100D:F496 mov CL,AL
100D:F498 mov AX,BX
100D:F49A or CL,CL
100D:F49C jne short 0xF46F
100D:F49E stc
100D:F49F mov CX,DI
100D:F4A1 pop DS
100D:F4A2 pop DI
100D:F4A3 add SP,2
100D:F4A6 sub CX,DI
100D:F4A8 ret near
3358:0100 jmp near 0x0967
3358:0103 jmp near 0x09D9
3358:0118 jmp near 0x19F7
3358:0121 jmp near 0x1B7C
3358:013C ret far
3358:0154 jmp near 0x0975
3358:0163 jmp near 0x0C06
3358:017B jmp near 0x0A68
3358:0967 mov AH,0x0F
3358:0969 int 0x10
3358:096B cmp AL,0x13
3358:096D je short 0x0974
3358:096F mov AX,0x0013
3358:0972 int 0x10
3358:0974 ret far
3358:0975 mov byte ptr CS:[0x01BD],AL
3358:0979 pushf
3358:097A sti
3358:097B mov AX,0x0040
3358:097E mov ES,AX
3358:0980 mov DX,word ptr ES:[0x0063]
3358:0985 add DL,6
3358:0988 mov word ptr CS:[0x019F],DX
3358:098D in DX,AL
3358:098E and AL,8
3358:0990 call near 0x09B8
3358:0993 jae short 0x09B4
3358:0995 call near 0x09B8
3358:0998 jae short 0x09B4
3358:099A mov DI,SI
3358:099C mov byte ptr CS:[0x01A2],AH
3358:09A1 call near 0x09B8
3358:09A4 jae short 0x09B4
3358:09A6 cmp SI,DI
3358:09A8 not byte ptr CS:[0x01A1]
3358:09AD jae short 0x09B4
3358:09AF mov byte ptr CS:[0x01A2],AH
3358:09B4 popf
3358:09B5 jmp near 0x0B0C
3358:09B8 mov AH,AL
3358:09BA xor SI,SI
3358:09BC mov BX,word ptr SS:[BP]
3358:09BF inc SI
3358:09C0 jne short 0x09C3
3358:09C3 in DX,AL
3358:09C4 and AL,8
3358:09C6 cmp AL,AH
3358:09C8 jne short 0x09D7
3358:09CA push AX
3358:09CB mov AX,word ptr SS:[BP]
3358:09CE sub AX,BX
3358:09D0 cmp AX,0x0064
3358:09D3 pop AX
3358:09D4 jb short 0x09BF
3358:09D7 stc
3358:09D8 ret near
3358:09D9 mov AX,0xA000
3358:09DC mov CX,0xFA00
3358:09DF xor BP,BP
3358:09E1 ret far
3358:0A58 push CS
3358:0A59 push CS
3358:0A5A pop DS
3358:0A5B pop ES
3358:0A5C mov SI,0x05BF
3358:0A5F mov DI,0x02BF
3358:0A62 mov CX,0x0180
3358:0A65 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:0A67 ret near
3358:0A68 push CX
3358:0A69 push SI
3358:0A6A push DI
3358:0A6B push DS
3358:0A6C push ES
3358:0A6D call near 0x0A58
3358:0A70 pop ES
3358:0A71 pop DS
3358:0A72 pop DI
3358:0A73 pop SI
3358:0A74 pop CX
3358:0A75 ret far
3358:0B0C cmp byte ptr CS:[0x01BE],0
3358:0B12 je short 0x0B67
3358:0B14 mov byte ptr CS:[0x01BE],0
3358:0B1A push AX
3358:0B1B push BX
3358:0B1C push CX
3358:0B1D push DX
3358:0B1E push SI
3358:0B1F push DI
3358:0B20 push BP
3358:0B21 push ES
3358:0B22 push CS
3358:0B23 pop ES
3358:0B24 mov DI,0x01BF
3358:0B27 mov CX,0x0100
3358:0B2A xor AL,AL
3358:0B2C repe scas AL,byte ptr ES:[DI]
3358:0B2E je short 0x0B55
3358:0B30 dec DI
3358:0B31 inc CX
3358:0B32 mov BX,CX
3358:0B34 repne scas AL,byte ptr ES:[DI]
3358:0B36 push CX
3358:0B37 jne short 0x0B3A
3358:0B3A sub CX,BX
3358:0B3C neg CX
3358:0B3E mov DX,0x0100
3358:0B41 sub DX,BX
3358:0B43 mov BX,DX
3358:0B45 add DX,DX
3358:0B47 add DX,BX
3358:0B49 add DX,0x05BF
3358:0B4D call near 0x0B68
3358:0B50 pop CX
3358:0B51 or CX,CX
3358:0B53 jne short 0x0B2A
3358:0B55 mov DI,0x01BF
3358:0B58 mov CX,0x0080
3358:0B5B xor AX,AX
3358:0B5D rep stos word ptr ES:[DI],AX
3358:0B5F pop ES
3358:0B60 pop BP
3358:0B61 pop DI
3358:0B62 pop SI
3358:0B63 pop DX
3358:0B64 pop CX
3358:0B65 pop BX
3358:0B66 pop AX
3358:0B67 ret far
3358:0B68 push SI
3358:0B69 push DS
3358:0B6A push ES
3358:0B6B pop DS
3358:0B6C mov SI,DX
3358:0B6E pushf
3358:0B6F cmp byte ptr DS:[0x01A1],0
3358:0B74 je short 0x0B83
3358:0B76 mov DX,word ptr DS:[0x019F]
3358:0B7A in DX,AL
3358:0B7B and AL,8
3358:0B7D cmp AL,byte ptr DS:[0x01A2]
3358:0B81 jne short 0x0B7A
3358:0B83 cli
3358:0B84 mov DX,0x03C8
3358:0B87 mov AL,BL
3358:0B89 out DX,AL
3358:0B8A jmp short 0x0B8C
3358:0B8C jmp short 0x0B8E
3358:0B8E jmp short 0x0B90
3358:0B90 jmp short 0x0B92
3358:0B92 inc DX
3358:0B93 cmp byte ptr CS:[0x01BD],0
3358:0B99 jne short 0x0BA9
3358:0B9B mov AX,CX
3358:0B9D add CX,CX
3358:0B9F add CX,AX
3358:0BA1 lods AL,byte ptr DS:[SI]
3358:0BA2 out DX,AL
3358:0BA3 loop 0x0BA1
3358:0BA5 popf
3358:0BA6 pop DS
3358:0BA7 pop SI
3358:0BA8 ret near
3358:0C06 mov DX,0x0140
3358:0C09 mul DX
3358:0C0B mov word ptr CS:[0x01A3],AX
3358:0C0F ret far
3358:19F7 push AX
3358:19F8 push CX
3358:19F9 push DI
3358:19FA xor DI,DI
3358:19FC xor AX,AX
3358:19FE mov CX,0x7D00
3358:1A01 rep stos word ptr ES:[DI],AX
3358:1A03 pop DI
3358:1A04 pop CX
3358:1A05 pop AX
3358:1A06 ret far
3358:1B7C push CX
3358:1B7D push SI
3358:1B7E push DI
3358:1B7F xor SI,SI
3358:1B81 mov DI,SI
3358:1B83 mov CX,0x7D00
3358:1B86 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:1B88 pop DI
3358:1B89 pop SI
3358:1B8A pop CX
3358:1B8B ret far
5642:0100 jmp short 0x017B
5642:0103 jmp near 0x0185
5642:010C jmp short 0x0185
5642:0115 jmp short 0x0185
5642:017B push CS
5642:017C call near 0x0182
5642:017F xor BX,BX
5642:0181 ret far
5642:0182 call near 0x0188
5642:0185 xor AL,AL
5642:0187 ret far
5642:0188 in AL,0x61
5642:018A and AL,0xFC
5642:018C out 0x61,AL
5642:018E ret near
