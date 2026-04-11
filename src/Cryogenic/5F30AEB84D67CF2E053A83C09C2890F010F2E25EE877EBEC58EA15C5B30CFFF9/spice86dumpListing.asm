0800:0000 callback 0x0010
0800:0004 iret
0800:0005 iret
0800:0006 callback 8
0800:000A int 0x1C
0800:000C callback 0x0101
0800:0010 iret
0800:004E call far 0800:00AE
0800:0053 callback 0x0074
0800:0057 iret
0800:0080 callback 0x0021
0800:0084 iret
0800:00A8 callback 0x0033
0800:00AC iret
0800:00AD ret far
0800:00AE callback 0x010A
0800:00B2 call far 0800:00AD
0800:00B7 callback 0x010B
0800:00BB ret far
100D:0000 mov AX,0xDD1D
100D:0003 call near 0xE4AD
100D:0006 call near 0xE594
100D:0009 call near 0x00B0
100D:000C sti
100D:000D call near 0x0580
100D:0010 call near 0x0309
100D:0013 call near 0x021C
100D:0016 call near 0xAEB7
100D:0019 mov byte ptr DS:[0x3810],0
100D:001E mov word ptr DS:[2],2
100D:0024 call near 0x0083
100D:0027 mov CL,0xFF
100D:0029 call near 0xB389
100D:002C call near 0x1860
100D:002F mov byte ptr DS:[0xCE80],0xFF
100D:0034 call near 0xB2BE
100D:0037 call near 0xD815
100D:0083 call near 0xCFA0
100D:0086 call near 0xC07C
100D:0089 call near 0xC0AD
100D:008C mov SI,0x1AE4
100D:008F mov BP,0xD1EF
100D:0092 call near 0xC097
100D:0095 jmp near 0x1797
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
100D:021C mov byte ptr DS:[0x289E],0x8C
100D:0221 mov byte ptr DS:[0x28E7],1
100D:0226 je short 0x0292
100D:0292 mov ES,word ptr DS:[0xDBD8]
100D:0296 call far dword ptr DS:[0x38D5]
100D:029A call near 0xAC14
100D:029D mov byte ptr DS:[0x227D],0
100D:02A2 mov byte ptr DS:[0x00C5],0
100D:02A7 call near 0x0911
100D:02AA mov byte ptr DS:[0x28E7],0
100D:02AF mov byte ptr DS:[0xDBE6],6
100D:02B4 inc byte ptr DS:[0x0115]
100D:02B8 mov DX,0x200A
100D:02BB mov BX,0x0180
100D:02BE jmp near 0x08F0
100D:0309 je short 0x0331
100D:0331 pushf
100D:0332 call near 0x0579
100D:0335 popf
100D:0336 ret near
100D:0579 xor AX,AX
100D:057B call far dword ptr DS:[0x3939]
100D:057F ret near
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
100D:05B7 and byte ptr DS:[0x47D1],0x7F
100D:05BC call near 0x39E6
100D:05BF call near 0x093F
100D:05C2 mov BX,AX
100D:05C4 call near 0xDE0C
100D:05C7 jb short 0x05FD
100D:05C9 call near 0x093F
100D:05CC or AX,AX
100D:05CE js short 0x05DC
100D:05D0 mov BP,0x0F66
100D:05D3 call near 0xC108
100D:05D6 call near 0xC0F4
100D:05D9 call near 0x3A7C
100D:05DC call near 0xC07C
100D:05DF or byte ptr DS:[0x47D1],0x80
100D:05E4 call near 0xDD63
100D:05E7 jb short 0x05FD
100D:05E9 call near 0x093F
100D:05EC clc
100D:05ED call near AX
100D:05EF jb short 0x05FD
100D:05FD pushf
100D:05FE call near 0x9985
100D:0601 mov ES,word ptr DS:[0xDBD8]
100D:0605 call far dword ptr DS:[0x38D5]
100D:0609 popf
100D:060A pushf
100D:060B call near 0x0579
100D:060E call near 0xCA01
100D:0611 mov word ptr DS:[2],2
100D:0617 call near 0x0911
100D:061A popf
100D:061B ret near
100D:061C call near 0xAD57
100D:061F mov AX,0x0015
100D:0622 jmp near 0xCA1B
100D:0625 call near 0xC07C
100D:0628 call near 0xDD63
100D:062B jb short 0x064C
100D:062D call near 0xC9F4
100D:0630 je short 0x0628
100D:0632 call near 0xC4CD
100D:0635 cmp word ptr DS:[0xDBCE],8
100D:063A jb short 0x0646
100D:0646 call near 0xCC85
100D:0649 je short 0x0628
100D:064C ret near
100D:08F0 xor AL,AL
100D:08F2 mov byte ptr DS:[0x47A4],AL
100D:08F5 mov byte ptr DS:[0x46DF],AL
100D:08F8 mov word ptr DS:[4],DX
100D:08FC mov word ptr DS:[6],BX
100D:0900 mov byte ptr DS:[8],DH
100D:0904 mov AL,0x1C
100D:0906 mul BH
100D:0908 add AX,0x00E4
100D:090B mov word ptr DS:[0x114E],AX
100D:090E jmp near 0x2D74
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
100D:0B37 cmp byte ptr DS:[0x00FB],0
100D:0B3C js short 0x0B44
100D:0B3E mov word ptr DS:[0x3CBE],0
100D:0B44 ret near
100D:0F66 ret near
100D:0FD9 mov byte ptr DS:[0x46DA],1
100D:0FDE call near 0xB2BE
100D:0FE1 or CX,CX
100D:0FE3 jle short 0x1005
100D:0FE5 push CX
100D:0FE6 mov AX,word ptr DS:[0x146E]
100D:0FE9 mov word ptr DS:[0x46DB],AX
100D:0FEC cmp byte ptr DS:[0x46DD],0
100D:0FF1 je short 0x0FF6
100D:0FF6 inc word ptr DS:[2]
100D:0FFA mov byte ptr DS:[0x46DD],1
100D:0FFF call near 0x1B23
100D:1002 pop CX
100D:1003 loop 0x0FD9
100D:1005 mov byte ptr DS:[0x46DA],0
100D:100A ret near
100D:127C cmp AL,4
100D:127E jne short 0x128D
100D:1280 cmp byte ptr DS:[0x002A],0x15
100D:1285 jb short 0x128D
100D:128D clc
100D:128E ret near
100D:1797 push word ptr DS:[0x2784]
100D:179B call near 0xC137
100D:179E mov DX,0x007E
100D:17A1 mov BX,0x0094
100D:17A4 mov AX,0x000F
100D:17A7 call near 0xC22F
100D:17AA mov AX,0x0010
100D:17AD add AL,byte ptr DS:[0x00E8]
100D:17B1 mov DX,0x0096
100D:17B4 mov BX,0x0089
100D:17B7 call near 0xC22F
100D:17BA pop AX
100D:17BB jmp near 0xC13E
100D:17BE call near 0xC07C
100D:17C1 mov SI,0x1E6E
100D:17C4 push SI
100D:17C5 cmp byte ptr DS:[0xCE66],0
100D:17CA jne short 0x17D1
100D:17CC call near 0xC446
100D:17CF jmp short 0x17DF
100D:17DF call near 0x1797
100D:17E2 pop SI
100D:17E3 jmp near 0xC4F0
100D:17E6 cmp byte ptr DS:[0x11C9],0
100D:17EB jne short 0x181D
100D:17ED cmp byte ptr DS:[0x00E8],0x0A
100D:17F2 je short 0x181D
100D:17F4 inc byte ptr DS:[0x00E8]
100D:17F8 call near 0x17BE
100D:17FB mov AX,8
100D:17FE call near 0xE387
100D:1801 jmp short 0x17E6
100D:1803 cmp byte ptr DS:[0x28E7],0
100D:1808 jne short 0x181D
100D:181D ret near
100D:181E cmp byte ptr DS:[0x00E8],0
100D:1823 je short 0x181D
100D:1825 dec byte ptr DS:[0x00E8]
100D:1829 call near 0x17BE
100D:182C mov AX,8
100D:182F call near 0xE387
100D:1832 jmp short 0x181E
100D:1834 mov SI,0xCD9E
100D:1837 mov BP,0x1E76
100D:183A mov ES,word ptr DS:[0xDBD6]
100D:183E call far dword ptr DS:[0x3919]
100D:1842 ret near
100D:1843 cmp byte ptr DS:[0x00E8],0
100D:1848 je short 0x181D
100D:1860 cmp byte ptr DS:[0x11C9],0
100D:1865 je short 0x1868
100D:1868 call near 0x1843
100D:186B call near 0xDAA3
100D:186E neg byte ptr DS:[0x00FB]
100D:1872 jns short 0x1877
100D:1877 call near 0xD2BD
100D:187A call near 0x5ADF
100D:187D mov AL,byte ptr DS:[0x28E8]
100D:1880 mov byte ptr DS:[0x28E7],AL
100D:1883 call near 0xB930
100D:1886 mov word ptr DS:[0x1C14],0x0080
100D:188C mov word ptr DS:[0x1C22],0x0080
100D:1892 mov BP,0xD75A
100D:1895 call near 0xC097
100D:1898 mov AL,0x34
100D:189A mov BP,0x2DB1
100D:189D cmp byte ptr DS:[0x46D9],0
100D:18A2 je short 0x18A6
100D:18A6 xor DX,DX
100D:18A8 call near 0xC108
100D:18AB call near 0xC07C
100D:18AE call near 0xAE04
100D:18B1 mov AX,word ptr DS:[0xCE7A]
100D:18B4 mov word ptr DS:[0xDC5A],AX
100D:18B7 jmp near 0x17E6
100D:1A0F cmp word ptr DS:[0x1AFE],0
100D:1A14 jne short 0x1A33
100D:1A16 call near 0xDBB2
100D:1A19 push word ptr DS:[0x2784]
100D:1A1D call near 0xC137
100D:1A20 mov SI,0x1AF4
100D:1A23 call near 0xD200
100D:1A26 call near 0x1A34
100D:1A29 mov SI,0x1F06
100D:1A2C call near 0xC4AA
100D:1A2F pop AX
100D:1A30 call near 0xC13E
100D:1A33 ret near
100D:1A34 cmp word ptr DS:[0x1AFE],0
100D:1A39 jne short 0x1A33
100D:1A3B push word ptr DS:[0xDBDA]
100D:1A3F call near 0xC08E
100D:1A42 mov AX,word ptr DS:[2]
100D:1A45 and AX,0x000F
100D:1A48 shl AX,1
100D:1A4A shl AX,1
100D:1A4C shl AX,1
100D:1A4E add AX,0x1E7E
100D:1A51 mov SI,AX
100D:1A53 mov AX,0x004A
100D:1A56 call near 0x1A9B
100D:1A59 mov AX,0x004B
100D:1A5C call near 0x1A9B
100D:1A5F call near 0xD075
100D:1A62 mov word ptr DS:[0xDBE4],0xF1FA
100D:1A68 call near 0x1AD1
100D:1A6B mov BX,0x016D
100D:1A6E add AX,BX
100D:1A70 sub AX,BX
100D:1A72 cmp AX,BX
100D:1A74 jae short 0x1A70
100D:1A76 inc AX
100D:1A77 mov DX,0x000B
100D:1A7A mov BX,0x00BE
100D:1A7D cmp AX,0x0064
100D:1A80 jae short 0x1A8D
100D:1A82 sub DL,2
100D:1A85 cmp AX,0x000A
100D:1A88 jae short 0x1A8D
100D:1A8A sub DL,2
100D:1A8D call near 0xE290
100D:1A90 mov AL,0x20
100D:1A92 call near word ptr DS:[0x2518]
100D:1A96 pop word ptr DS:[0xDBDA]
100D:1A9A ret near
100D:1A9B push AX
100D:1A9C lods AX,word ptr DS:[SI]
100D:1A9D mov DX,AX
100D:1A9F lods AX,word ptr DS:[SI]
100D:1AA0 mov BX,AX
100D:1AA2 pop AX
100D:1AA3 or DX,DX
100D:1AA5 je short 0x1AC4
100D:1AA7 push SI
100D:1AA8 call near 0xC1F4
100D:1AAB push DS
100D:1AAC push ES
100D:1AAD mov ES,word ptr DS:[0xDBD8]
100D:1AB1 pop DS
100D:1AB2 lods AX,word ptr DS:[SI]
100D:1AB3 mov DI,AX
100D:1AB5 lods AX,word ptr DS:[SI]
100D:1AB6 mov CX,AX
100D:1AB8 xor CH,CH
100D:1ABA mov BP,0x1EFE
100D:1ABD call far dword ptr SS:[0x38CD]
100D:1AC2 pop DS
100D:1AC3 pop SI
100D:1AC4 ret near
100D:1AC5 mov AX,word ptr DS:[2]
100D:1AC8 shr AX,1
100D:1ACA shr AX,1
100D:1ACC shr AX,1
100D:1ACE shr AX,1
100D:1AD0 ret near
100D:1AD1 mov AX,word ptr DS:[2]
100D:1AD4 add AX,3
100D:1AD7 shr AX,1
100D:1AD9 shr AX,1
100D:1ADB shr AX,1
100D:1ADD shr AX,1
100D:1ADF ret near
100D:1AE0 mov AX,word ptr DS:[2]
100D:1AE3 and AX,0x000F
100D:1AE6 ret near
100D:1AE7 call near 0xD41B
100D:1AEA cmp BP,0x1F7E
100D:1AEE jne short 0x1B0C
100D:1AF0 mov AX,word ptr DS:[0xCE7A]
100D:1AF3 cmp AX,word ptr DS:[0x4770]
100D:1AF7 je short 0x1B0C
100D:1AF9 mov word ptr DS:[0x4770],AX
100D:1AFC sub AX,word ptr DS:[0x476E]
100D:1B00 cmp AX,word ptr DS:[0x4772]
100D:1B04 jb short 0x1B0C
100D:1B0C ret near
100D:1B0D call near 0xABCC
100D:1B10 jne short 0x1B0C
100D:1B12 cmp byte ptr DS:[0x2788],0
100D:1B17 jne short 0x1B0C
100D:1B19 cmp byte ptr DS:[0x002A],0xC8
100D:1B1E jae short 0x1B0C
100D:1B20 call near 0x2B2A
100D:1B23 cmp byte ptr DS:[0x46DD],0
100D:1B28 je short 0x1B0C
100D:1B2A mov byte ptr DS:[0x46DD],0
100D:1B2F mov AL,byte ptr DS:[0x00F4]
100D:1B32 dec AL
100D:1B34 cmp AL,0x10
100D:1B36 jge short 0x1B3D
100D:1B38 xor AL,AL
100D:1B3A mov byte ptr DS:[0x00F5],AL
100D:1B3D mov byte ptr DS:[0x00F4],AL
100D:1B40 call near 0x1A0F
100D:1B43 call near 0x38E1
100D:1B46 mov AX,word ptr DS:[2]
100D:1B49 mov CX,AX
100D:1B4B xchg AX,word ptr DS:[0x1174]
100D:1B4F and AL,0xF0
100D:1B51 and CL,0xF0
100D:1B54 sub AL,CL
100D:1B56 mov byte ptr DS:[0x46DE],AL
100D:1B59 je short 0x1B5E
100D:1B5B call near 0x1C46
100D:1B5E cmp byte ptr DS:[0x00C2],7
100D:1B63 jae short 0x1BB2
100D:1B65 call near 0x1D9F
100D:1B68 push word ptr DS:[0x11F7]
100D:1B6C push word ptr DS:[0x11CE]
100D:1B70 call near 0x6C6F
100D:1B73 call near 0x63F0
100D:1B76 call near 0x1AE0
100D:1B79 shl AX,1
100D:1B7B mov SI,AX
100D:1B7D call near word ptr CS:[SI+0x1DB3]
100D:1B82 call near 0x1C18
100D:1B85 pop DI
100D:1B86 call near 0x331E
100D:1B89 pop word ptr DS:[0x11F7]
100D:1B8D call near 0x1BEC
100D:1B90 cmp byte ptr DS:[0x46D9],0
100D:1B95 jne short 0x1BB2
100D:1B97 cmp byte ptr DS:[0x46EC],0
100D:1B9C je short 0x1BA1
100D:1BA1 mov DI,word ptr DS:[0x114E]
100D:1BA5 or DI,DI
100D:1BA7 je short 0x1BB2
100D:1BA9 cmp byte ptr DS:[0x473B],0
100D:1BAE js short 0x1BD2
100D:1BB0 ja short 0x1BB8
100D:1BB2 mov byte ptr DS:[0x473B],0
100D:1BB7 ret near
100D:1BEC cmp byte ptr DS:[0x002B],0
100D:1BF1 je short 0x1C17
100D:1C17 ret near
100D:1C18 cmp byte ptr DS:[0x46EB],0
100D:1C1D jns short 0x1C39
100D:1C39 jne short 0x1C45
100D:1C3B cmp byte ptr DS:[0x00FB],0
100D:1C40 jns short 0x1C45
100D:1C45 ret near
100D:1C46 mov AL,byte ptr DS:[0x002A]
100D:1C49 mov AH,AL
100D:1C4B xchg AL,byte ptr DS:[0x00FE]
100D:1C4F cmp AL,AH
100D:1C51 je short 0x1C58
100D:1C58 inc byte ptr DS:[0x00FF]
100D:1C5C call near 0x1D66
100D:1C5F call near 0x1E43
100D:1C62 mov AL,byte ptr DS:[0x00D5]
100D:1C65 inc AL
100D:1C67 cmp AL,2
100D:1C69 jb short 0x1C6E
100D:1C6E xor AX,AX
100D:1C70 xchg AX,word ptr DS:[0x1172]
100D:1C74 mov BX,word ptr DS:[0x00A0]
100D:1C78 add AX,BX
100D:1C7A xchg BX,word ptr DS:[0x1170]
100D:1C7E sub AX,BX
100D:1C80 jae short 0x1C84
100D:1C84 mov word ptr DS:[0x00A6],AX
100D:1C87 xchg AX,word ptr DS:[0x00AE]
100D:1C8B xor BX,BX
100D:1C8D sub AX,word ptr DS:[0x00A6]
100D:1C91 jae short 0x1C96
100D:1C96 mov word ptr DS:[0x00B2],AX
100D:1C99 mov word ptr DS:[0x00B0],BX
100D:1C9D call near 0x1CDA
100D:1CA0 call near 0xC02E
100D:1CA3 call near 0xBF26
100D:1CA6 call near 0xE3CC
100D:1CA9 mov BX,AX
100D:1CAB mov SI,0x10D8
100D:1CAE test byte ptr DS:[SI+2],8
100D:1CB2 je short 0x1CD1
100D:1CD1 add SI,0x0011
100D:1CD4 cmp byte ptr DS:[SI],0x14
100D:1CD7 jb short 0x1CAE
100D:1CD9 ret near
100D:1CDA mov DI,0x0100
100D:1CDD xor CX,CX
100D:1CDF xor DX,DX
100D:1CE1 call near 0x5D36
100D:1CE4 jb short 0x1CF4
100D:1CE6 inc DX
100D:1CE7 mov AL,byte ptr DS:[DI+0x12]
100D:1CEA shr AL,1
100D:1CEC shr AL,1
100D:1CEE shr AL,1
100D:1CF0 xor AH,AH
100D:1CF2 add CX,AX
100D:1CF4 add DI,0x001C
100D:1CF7 cmp byte ptr DS:[DI],0xFF
100D:1CFA jne short 0x1CE1
100D:1CFC mov BX,CX
100D:1CFE shr BX,1
100D:1D00 shr BX,1
100D:1D02 shr BX,1
100D:1D04 shr BX,1
100D:1D06 call near 0xE3DF
100D:1D09 add CX,AX
100D:1D0B mov word ptr DS:[0x00A8],CX
100D:1D0F ret near
100D:1D10 rol word ptr DS:[0],1
100D:1D14 jae short 0x1D34
100D:1D34 ret near
100D:1D66 mov SI,0x0FD8
100D:1D69 mov CX,0x000C
100D:1D6C mov AX,word ptr DS:[SI+2]
100D:1D6F cmp AL,0x80
100D:1D71 jne short 0x1D99
100D:1D73 cmp AH,0xFF
100D:1D76 je short 0x1D99
100D:1D78 mov AL,0x1C
100D:1D7A mul AH
100D:1D7C add AX,0x00E4
100D:1D7F mov DI,AX
100D:1D81 mov AX,word ptr DS:[SI]
100D:1D83 mov BL,byte ptr DS:[DI+8]
100D:1D86 cmp AH,BL
100D:1D88 jne short 0x1D93
100D:1D8A xor BH,BH
100D:1D8C cmp AL,byte ptr CS:[BX+0x1D35]
100D:1D91 jbe short 0x1D99
100D:1D99 add SI,0x0010
100D:1D9C loop 0x1D6C
100D:1D9E ret near
100D:1D9F test word ptr DS:[0x0012],0x0080
100D:1DA5 jne short 0x1DB2
100D:1DA7 mov SI,0x1048
100D:1DAA call near 0x1E01
100D:1DAD jae short 0x1DB2
100D:1DB2 ret near
100D:1DD3 ret near
100D:1DD4 jmp near 0x20A4
100D:1DD7 jmp near 0x1F64
100D:1DDA test byte ptr DS:[0x00BF],0x10
100D:1DDF je short 0x1DFD
100D:1DFD ret near
100D:1DFE jmp near 0x1D10
100D:1E01 cmp byte ptr DS:[0x002A],0x5D
100D:1E06 jne short 0x1E3E
100D:1E3E clc
100D:1E3F ret near
100D:1E43 call near 0x1AC5
100D:1E46 cmp AX,word ptr DS:[0x1156]
100D:1E4A jb short 0x1EA8
100D:1EA8 ret near
100D:1F64 cmp byte ptr DS:[0x002A],0x3C
100D:1F69 jae short 0x1F79
100D:1F6B mov AX,word ptr DS:[2]
100D:1F6E sub AX,word ptr DS:[0x1154]
100D:1F72 jb short 0x1F91
100D:1F91 ret near
100D:20A4 test byte ptr DS:[0x00BF],0x80
100D:20A9 je short 0x20D1
100D:20D1 ret near
100D:2170 call near 0xE270
100D:2173 mov SI,0x0FD8
100D:2176 mov CX,9
100D:2179 test byte ptr DS:[SI+0x0F],0x40
100D:217D jne short 0x21F1
100D:217F mov DX,word ptr DS:[SI]
100D:2181 mov BX,word ptr DS:[SI+2]
100D:2184 cmp SI,0x1008
100D:2188 jne short 0x2194
100D:218A cmp BX,0x0180
100D:218E jne short 0x2194
100D:2194 cmp BL,0x80
100D:2197 jne short 0x21EE
100D:2199 cmp DL,1
100D:219C jne short 0x21DC
100D:21DC cmp SI,0x1028
100D:21E0 jb short 0x21F1
100D:21E2 cmp BH,1
100D:21E5 jne short 0x21F1
100D:21F1 add SI,0x0010
100D:21F4 loop 0x2179
100D:21F6 call near 0xE283
100D:21F9 ret near
100D:2AAF push SI
100D:2AB0 mov SI,0x1190
100D:2AB3 xor CX,CX
100D:2AB5 mov CL,byte ptr DS:[SI]
100D:2AB7 jcxz short 0x2ACD
100D:2ACD pop SI
100D:2ACE clc
100D:2ACF ret near
100D:2B2A mov AL,byte ptr DS:[0x46D9]
100D:2B2D or AL,byte ptr DS:[0x4774]
100D:2B31 or AL,byte ptr DS:[0x11C9]
100D:2B35 jne short 0x2B8F
100D:2B37 call near 0xD41B
100D:2B3A cmp BP,0x1F0E
100D:2B3E jne short 0x2B8F
100D:2B40 cmp byte ptr DS:[0x00FB],0
100D:2B45 js short 0x2B8F
100D:2B47 mov AX,word ptr DS:[0xCE7A]
100D:2B4A cmp byte ptr DS:[0x002A],0x14
100D:2B4F jb short 0x2B8F
100D:2B8F ret near
100D:2D74 mov SI,word ptr DS:[0x114E]
100D:2D78 cmp SI,0x0100
100D:2D7C jb short 0x2DB0
100D:2D7E xor AX,AX
100D:2D80 call near 0x5E4F
100D:2D83 cmp AX,2
100D:2D86 jae short 0x2D8F
100D:2D88 test byte ptr DS:[0x4732],1
100D:2D8D jne short 0x2DB0
100D:2D8F cmp AX,4
100D:2D92 ja short 0x2DB0
100D:2D94 jne short 0x2D97
100D:2D97 cmp byte ptr DS:[0x144C],AL
100D:2D9B je short 0x2DB0
100D:2D9D mov byte ptr DS:[0x144C],AL
100D:2DA0 add AX,0x00A1
100D:2DA3 push DS
100D:2DA4 pop ES
100D:2DA5 mov DI,0xBC6E
100D:2DA8 mov SI,AX
100D:2DAA call near 0xF0B9
100D:2DAD call near 0x0098
100D:2DB0 ret near
100D:2DB1 mov BP,0xD717
100D:2DB4 call near 0xC097
100D:2DB7 call near 0xD95B
100D:2DBA mov byte ptr DS:[0x47A6],0xFF
100D:2DBF call near 0x2D74
100D:2DC2 xor AX,AX
100D:2DC4 mov byte ptr DS:[0xDCE6],AL
100D:2DC7 mov byte ptr DS:[0x47A4],AL
100D:2DCA mov word ptr DS:[0x47AA],AX
100D:2DCD mov BP,0x2EB2
100D:2DD0 call near 0xC097
100D:2DD3 cmp byte ptr DS:[0x002B],0
100D:2DD8 je short 0x2DFB
100D:2DFB test byte ptr DS:[0x4732],1
100D:2E00 je short 0x2E05
100D:2E05 xor AX,AX
100D:2E07 mov word ptr DS:[0x0014],AX
100D:2E0A mov byte ptr DS:[0x46DF],AL
100D:2E0D call near 0xC07C
100D:2E10 call near 0x5BA0
100D:2E13 call near 0x37B2
100D:2E16 test byte ptr DS:[0x11C9],3
100D:2E1B jne short 0x2E20
100D:2E1D call near 0xC412
100D:2E20 call near 0xAD5E
100D:2E23 call near 0x1834
100D:2E26 call near 0x1797
100D:2E29 mov AL,byte ptr DS:[0x46DF]
100D:2E2C mov AH,AL
100D:2E2E xchg AL,byte ptr DS:[0x46E0]
100D:2E32 cmp AL,AH
100D:2E34 je short 0x2E4C
100D:2E36 mov AX,word ptr DS:[0xDBD6]
100D:2E39 cmp AX,word ptr DS:[0xDBD8]
100D:2E3D je short 0x2E52
100D:2E3F mov AL,0x10
100D:2E41 mov BP,0x0F66
100D:2E44 call near 0xC108
100D:2E47 call near 0xAE04
100D:2E4A jmp short 0x2E52
100D:2E4C call near 0xC0F4
100D:2E4F call near 0xC4CD
100D:2E52 call near 0x35AD
100D:2E55 mov AX,word ptr DS:[0xCE7A]
100D:2E58 mov word ptr DS:[0xDC5A],AX
100D:2E5B cmp byte ptr DS:[0x47A7],0
100D:2E60 jne short 0x2E97
100D:2E62 mov AL,byte ptr DS:[0x4735]
100D:2E65 or AL,AL
100D:2E67 jns short 0x2E6C
100D:2E6C cmp byte ptr DS:[8],0xFF
100D:2E71 je short 0x2E7D
100D:2E73 cmp byte ptr DS:[0x4774],0
100D:2E78 jne short 0x2E97
100D:2E7A jmp near 0x17E6
100D:2E7D cmp byte ptr DS:[0x11C9],0
100D:2E82 jne short 0x2E97
100D:2E97 ret near
100D:2E98 mov word ptr DS:[0x47E6],DI
100D:2E9C xor AH,AH
100D:2E9E mov AL,byte ptr DS:[DI]
100D:2EA0 add AX,0
100D:2EA3 mov word ptr DS:[0x11ED],AX
100D:2EA6 mov AL,byte ptr DS:[DI+1]
100D:2EA9 xor AH,AH
100D:2EAB add AX,0x000C
100D:2EAE mov word ptr DS:[0x11EF],AX
100D:2EB1 ret near
100D:2EB2 cmp byte ptr DS:[0x4774],0
100D:2EB7 je short 0x2EC9
100D:2EC9 mov DI,word ptr DS:[0x114E]
100D:2ECD call near 0x2E98
100D:2ED0 call near 0x2EFB
100D:2ED3 cmp byte ptr DS:[0x11C9],0
100D:2ED8 jne short 0x2EDD
100D:2EDA call near 0x3090
100D:2EDD mov AX,word ptr DS:[0xDC38]
100D:2EE0 cmp AX,0x0074
100D:2EE3 jb short 0x2EEC
100D:2EE5 mov AX,0xDBEC
100D:2EE8 push AX
100D:2EE9 call near 0xDBB2
100D:2EEC call near 0x2FFB
100D:2EEF call near 0xD763
100D:2EF2 mov BP,0x1F0E
100D:2EF5 mov BX,0x0F66
100D:2EF8 jmp near 0xD338
100D:2EFB push DS
100D:2EFC pop ES
100D:2EFD mov DI,0x1F0F
100D:2F00 xor AL,AL
100D:2F02 stos byte ptr ES:[DI],AL
100D:2F03 mov BX,word ptr DS:[6]
100D:2F07 mov DX,word ptr DS:[4]
100D:2F0B cmp BL,0x80
100D:2F0E je short 0x2F13
100D:2F10 jmp near 0x2FAA
100D:2F13 mov SI,0x220C
100D:2F16 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2F17 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2F18 cmp DL,1
100D:2F1B jne short 0x2F58
100D:2F1D cmp byte ptr DS:[0x002B],0
100D:2F22 je short 0x2F3D
100D:2F3D push DI
100D:2F3E mov DI,word ptr DS:[0x114E]
100D:2F42 call near 0x7F27
100D:2F45 pop DI
100D:2F46 mov SI,0x21DC
100D:2F49 lods AX,word ptr DS:[SI]
100D:2F4A cmp byte ptr DS:[0x46FF],1
100D:2F4F sbb AH,AH
100D:2F51 and AH,0x40
100D:2F54 stos word ptr ES:[DI],AX
100D:2F55 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2F56 jmp short 0x2FA3
100D:2F58 cmp BH,1
100D:2F5B jne short 0x2FA3
100D:2F5D cmp DL,8
100D:2F60 jne short 0x2F99
100D:2F99 cmp DL,9
100D:2F9C jne short 0x2FA3
100D:2FA3 mov SI,0x21F4
100D:2FA6 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2FA7 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2FA8 jmp short 0x2FF7
100D:2FAA test byte ptr DS:[0x11C9],3
100D:2FAF jne short 0x2FD7
100D:2FD7 mov SI,0x21FC
100D:2FDA cmp byte ptr DS:[0x11CB],0
100D:2FDF je short 0x2FF0
100D:2FF0 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2FF1 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2FF2 mov SI,0x21F8
100D:2FF5 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2FF6 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2FF7 xor AX,AX
100D:2FF9 stos word ptr ES:[DI],AX
100D:2FFA ret near
100D:2FFB cmp byte ptr DS:[0x002B],0
100D:3000 jne short 0x301A
100D:3002 test byte ptr DS:[0x11C9],3
100D:3007 je short 0x3020
100D:3009 cmp byte ptr DS:[0x11CA],0
100D:300E jne short 0x301A
100D:3010 mov SI,0x1D72
100D:3013 cmp byte ptr DS:[0x11CB],0
100D:3018 jne short 0x301D
100D:301A mov SI,0x1D1E
100D:301D jmp near 0xD72B
100D:3020 mov BX,word ptr DS:[6]
100D:3024 cmp BL,0x80
100D:3027 jne short 0x3073
100D:3029 mov DX,word ptr DS:[4]
100D:302D cmp DH,0x21
100D:3030 je short 0x3073
100D:3032 call near 0x3EFE
100D:3035 inc SI
100D:3036 mov DI,0x1B96
100D:3039 mov AL,0x20
100D:303B cmp word ptr DS:[0x114E],0x0100
100D:3041 jne short 0x3045
100D:3043 mov AL,0x80
100D:3045 mov BX,0x0021
100D:3048 cmp DL,1
100D:304B jne short 0x3050
100D:304D inc BX
100D:304E mov AL,0x20
100D:3050 mov word ptr DS:[DI+2],BX
100D:3053 mov byte ptr DS:[DI+0x46],AL
100D:3056 mov byte ptr DS:[0x1CC4],AL
100D:3059 mov CX,4
100D:305C lods AL,byte ptr DS:[SI]
100D:305D add DI,0x000E
100D:3060 mov AH,0x20
100D:3062 or AL,AL
100D:3064 je short 0x306C
100D:3066 cmp AL,0xFB
100D:3068 jl short 0x306C
100D:306A mov AH,0x80
100D:306C mov byte ptr DS:[DI],AH
100D:306E loop 0x305C
100D:3070 jmp near 0xD735
100D:3090 call near 0x98E6
100D:3093 call near 0x3127
100D:3096 mov DI,0x1F0C
100D:3099 add DI,4
100D:309C cmp word ptr DS:[DI],0
100D:309F jne short 0x3099
100D:30A1 mov word ptr DS:[0x0012],0
100D:30A7 push DS
100D:30A8 pop ES
100D:30A9 mov BP,0x30B9
100D:30AC call near 0x36EE
100D:30AF mov BP,0x3120
100D:30B2 call near 0x36EE
100D:30B5 xor AX,AX
100D:30B7 stos word ptr ES:[DI],AX
100D:30B8 ret near
100D:30B9 test byte ptr DS:[SI+0x0F],0x40
100D:30BD jne short 0x311F
100D:30BF cmp word ptr DS:[0x47AA],0
100D:30C4 jne short 0x30CA
100D:30C6 mov word ptr DS:[0x47AA],SI
100D:30CA mov AL,byte ptr DS:[SI+0x0E]
100D:30CD mov CL,AL
100D:30CF xor AH,AH
100D:30D1 add AX,0x0078
100D:30D4 stos word ptr ES:[DI],AX
100D:30D5 mov AX,1
100D:30D8 shl AX,CL
100D:30DA or word ptr DS:[0x0012],AX
100D:30DE mov AX,word ptr DS:[SI+4]
100D:30E1 stos word ptr ES:[DI],AX
100D:30E2 cmp CL,0x0F
100D:30E5 jne short 0x311F
100D:311F ret near
100D:3120 test byte ptr DS:[SI+0x0F],0x40
100D:3124 jne short 0x30CA
100D:3126 ret near
100D:3127 mov byte ptr DS:[0x476B],0
100D:312C mov byte ptr DS:[0x476A],0
100D:3131 mov AX,0x7F80
100D:3134 mov word ptr DS:[0x10CA],AX
100D:3137 mov word ptr DS:[0x10BA],AX
100D:313A mov word ptr DS:[0x10AA],AX
100D:313D mov word ptr DS:[0x109A],AX
100D:3140 mov BX,word ptr DS:[6]
100D:3144 cmp BL,0x80
100D:3147 jne short 0x316D
100D:3149 mov DI,word ptr DS:[0x114E]
100D:314D mov DX,word ptr DS:[4]
100D:3151 mov BP,0x316E
100D:3154 call near 0x6603
100D:3157 cmp byte ptr DS:[DI+8],0x21
100D:315B jne short 0x316A
100D:316A call near 0x331E
100D:316D ret near
100D:316E mov AL,byte ptr DS:[SI+3]
100D:3171 mov AH,2
100D:3173 test AL,0x20
100D:3175 je short 0x3181
100D:3181 test byte ptr DS:[SI+0x10],0x80
100D:3185 jne short 0x316D
100D:3187 cmp byte ptr DS:[0x002B],0
100D:318C je short 0x3190
100D:3190 cmp AH,DL
100D:3192 jne short 0x316D
100D:3194 test byte ptr DS:[SI+0x10],0x80
100D:3198 jne short 0x31C9
100D:319A mov BP,0x10B8
100D:319D mov DI,0x4756
100D:31A0 cmp AL,0x80
100D:31A2 jae short 0x31ED
100D:31ED mov word ptr DS:[DI],SI
100D:31EF mov word ptr SS:[BP],DX
100D:31F2 mov word ptr SS:[BP+2],BX
100D:31F5 ret near
100D:31F6 call near 0xE270
100D:31F9 mov DI,word ptr DS:[SI+4]
100D:31FC mov word ptr DS:[0x002C],DI
100D:3200 mov AL,byte ptr DS:[SI]
100D:3202 mov byte ptr DS:[0x002E],AL
100D:3205 mov AL,byte ptr DS:[SI+3]
100D:3208 mov byte ptr DS:[0x0030],AL
100D:320B and AX,0x000F
100D:320E mov byte ptr DS:[0x002F],AL
100D:3211 add AX,0x0018
100D:3214 mov word ptr DS:[0x11F3],AX
100D:3217 call near 0x32C7
100D:321A call near 0x329D
100D:321D mov word ptr DS:[0x0048],AX
100D:3220 mov AX,word ptr DS:[SI+0x10]
100D:3223 mov word ptr DS:[0x0032],AX
100D:3226 mov AX,word ptr DS:[SI+0x12]
100D:3229 mov word ptr DS:[0x0034],AX
100D:322C and AX,0x000F
100D:322F mov byte ptr DS:[0x0031],AL
100D:3232 add AX,0
100D:3235 mov word ptr DS:[0x11FF],AX
100D:3238 call near 0x6EFD
100D:323B mov byte ptr DS:[0x0036],AL
100D:323E mov AL,byte ptr DS:[SI+0x16]
100D:3241 mov byte ptr DS:[0x0038],AL
100D:3244 call near 0x3310
100D:3247 mov word ptr DS:[0x11F7],AX
100D:324A mov AL,byte ptr DS:[SI+0x17]
100D:324D mov byte ptr DS:[0x0039],AL
100D:3250 call near 0x3310
100D:3253 mov word ptr DS:[0x11F9],AX
100D:3256 mov AL,byte ptr DS:[SI+0x18]
100D:3259 mov byte ptr DS:[0x003A],AL
100D:325C call near 0x3310
100D:325F mov word ptr DS:[0x11FB],AX
100D:3262 mov AX,word ptr DS:[SI+0x0C]
100D:3265 mov word ptr DS:[0x0044],AX
100D:3268 mov AX,word ptr DS:[SI+0x0E]
100D:326B mov word ptr DS:[0x0046],AX
100D:326E xor AH,AH
100D:3270 add AX,0x00E8
100D:3273 mov word ptr DS:[0x11F1],AX
100D:3276 call near 0x693B
100D:3279 mov BP,AX
100D:327B mov AL,byte ptr SS:[BP+SI+0x16]
100D:327E mov byte ptr DS:[0x0037],AL
100D:3281 mov AL,byte ptr DS:[SI+0x19]
100D:3284 mov byte ptr DS:[0x003B],AL
100D:3287 mov AL,byte ptr DS:[SI+0x1A]
100D:328A mov byte ptr DS:[0x003C],AL
100D:328D call near 0x1AC5
100D:3290 sub AL,byte ptr DS:[SI+0x14]
100D:3293 mov byte ptr DS:[0x0040],AL
100D:3296 call near 0x331E
100D:3299 call near 0xE283
100D:329C ret near
100D:329D cmp byte ptr DS:[SI+3],0
100D:32A1 je short 0x32AA
100D:32A3 xor AX,AX
100D:32A5 and word ptr DS:[SI+0x10],-13
100D:32A9 ret near
100D:32C7 mov AX,word ptr DS:[2]
100D:32CA sub AX,word ptr DS:[SI+0x0A]
100D:32CD mov word ptr DS:[0x0042],AX
100D:32D0 mov DX,AX
100D:32D2 mov CL,4
100D:32D4 shr AX,CL
100D:32D6 mov byte ptr DS:[0x0041],AL
100D:32D9 mov AX,0x0074
100D:32DC test byte ptr DS:[SI+3],0x10
100D:32E0 jne short 0x330C
100D:32E2 mov AX,0x0070
100D:32E5 cmp DX,3
100D:32E8 jb short 0x330C
100D:32EA inc AX
100D:32EB cmp DX,0x0010
100D:32EE jb short 0x330C
100D:330C mov word ptr DS:[0x11F5],AX
100D:330F ret near
100D:3310 xor AH,AH
100D:3312 shr AX,1
100D:3314 shr AX,1
100D:3316 shr AX,1
100D:3318 shr AX,1
100D:331A add AX,0x00D1
100D:331D ret near
100D:331E mov word ptr DS:[0x11CE],DI
100D:3322 push SI
100D:3323 push DI
100D:3324 mov AH,byte ptr DS:[DI]
100D:3326 mov AL,byte ptr DS:[DI+1]
100D:3329 mov word ptr DS:[0x004E],AX
100D:332C mov BX,0x1141
100D:332F xlat byte ptr DS:[BX+AL]
100D:3330 mov byte ptr DS:[0x0050],AL
100D:3333 mov AL,byte ptr DS:[DI+0x0A]
100D:3336 mov byte ptr DS:[0x0051],AL
100D:3339 mov AL,byte ptr DS:[DI+0x12]
100D:333C mov byte ptr DS:[0x0052],AL
100D:333F mov AL,byte ptr DS:[DI+0x1B]
100D:3342 mov byte ptr DS:[0x0054],AL
100D:3345 mov AL,byte ptr DS:[DI+8]
100D:3348 mov byte ptr DS:[0x004D],AL
100D:334B push DS
100D:334C pop ES
100D:334D push DI
100D:334E lea SI,DI+0x14
100D:3351 mov DI,0x0055
100D:3354 mov CX,7
100D:3357 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:3359 pop DI
100D:335A call near 0x33BE
100D:335D call near 0x34A5
100D:3360 call near 0x7F27
100D:3363 mov DI,0x46FE
100D:3366 mov AL,0xFF
100D:3368 mov CX,7
100D:336B cmp byte ptr DS:[DI],1
100D:336E rcl AL,1
100D:3370 inc DI
100D:3371 loop 0x336B
100D:3373 not AL
100D:3375 mov CL,1
100D:3377 shl AL,CL
100D:3379 mov byte ptr DS:[0x0053],AL
100D:337C pop DI
100D:337D call near 0x3385
100D:3380 call near 0x5274
100D:3383 pop SI
100D:3384 ret near
100D:3385 mov byte ptr DS:[0x00F7],0
100D:338A cmp DI,word ptr DS:[0x1150]
100D:338E je short 0x33BD
100D:33BD ret near
100D:33BE xor AX,AX
100D:33C0 mov word ptr DS:[0x0094],AX
100D:33C3 mov word ptr DS:[0x0096],AX
100D:33C6 mov word ptr DS:[0x005C],AX
100D:33C9 mov word ptr DS:[0x005E],AX
100D:33CC mov BP,0x3406
100D:33CF call near 0x6603
100D:33D2 call near 0x33D9
100D:33D5 mov byte ptr DS:[0x009C],AL
100D:33D8 ret near
100D:33D9 mov AX,word ptr DS:[0x0096]
100D:33DC mov DX,word ptr DS:[0x0094]
100D:33E0 cmp AX,DX
100D:33E2 pushf
100D:33E3 jae short 0x33E6
100D:33E6 mov CX,DX
100D:33E8 jcxz short 0x33FD
100D:33FD mov AX,0x00FC
100D:3400 popf
100D:3401 jae short 0x3405
100D:3405 ret near
100D:3406 test byte ptr DS:[SI+3],0x20
100D:340A jne short 0x342C
100D:340C call near 0x342D
100D:340F test byte ptr DS:[SI+0x10],0x80
100D:3413 jne short 0x3428
100D:3415 add word ptr DS:[0x0096],AX
100D:3419 mov AX,word ptr DS:[SI+0x10]
100D:341C or word ptr DS:[0x005C],AX
100D:3420 mov AX,word ptr DS:[SI+0x12]
100D:3423 or word ptr DS:[0x005E],AX
100D:3427 ret near
100D:342D call near 0x6EFD
100D:3430 xor AH,AH
100D:3432 add AL,AL
100D:3434 add AL,byte ptr DS:[SI+0x17]
100D:3437 jae short 0x343B
100D:343B mul byte ptr DS:[SI+0x1A]
100D:343E shr AX,1
100D:3440 shr AX,1
100D:3442 shr AX,1
100D:3444 shr AX,1
100D:3446 mov DX,AX
100D:3448 mov BL,byte ptr DS:[SI+0x19]
100D:344B shl BL,1
100D:344D shl BL,1
100D:344F shl DX,1
100D:3451 shl BL,1
100D:3453 jae short 0x3459
100D:3459 shl DX,1
100D:345B shl BL,1
100D:345D jae short 0x3463
100D:3463 shl DX,1
100D:3465 shl BL,1
100D:3467 jae short 0x346D
100D:346D shl DX,1
100D:346F shl BL,1
100D:3471 jae short 0x347A
100D:347A mov AL,AH
100D:347C xor AH,AH
100D:347E or AX,AX
100D:3480 jne short 0x3489
100D:3489 ret near
100D:34A5 push SI
100D:34A6 push DS
100D:34A7 pop ES
100D:34A8 push DI
100D:34A9 mov DI,0x0060
100D:34AC mov CX,0x0033
100D:34AF xor AL,AL
100D:34B1 rep stos byte ptr ES:[DI],AL
100D:34B3 pop DI
100D:34B4 mov BP,0x34D0
100D:34B7 call near 0x6639
100D:34BA mov AL,byte ptr DS:[0x0060]
100D:34BD add AL,byte ptr DS:[0x007E]
100D:34C1 mov byte ptr DS:[0x0091],AL
100D:34C4 mov AL,byte ptr DS:[0x0061]
100D:34C7 add AL,byte ptr DS:[0x007F]
100D:34CB mov byte ptr DS:[0x0092],AL
100D:34CE pop SI
100D:34CF ret near
100D:34D0 test byte ptr DS:[SI+3],0x20
100D:34D4 jne short 0x351A
100D:34D6 mov AL,byte ptr DS:[SI+3]
100D:34D9 mov DX,0x0061
100D:34DC test AL,0x40
100D:34DE je short 0x34E3
100D:34E3 mov BX,DX
100D:34E5 test byte ptr DS:[SI+0x10],0x80
100D:34E9 jne short 0x34F0
100D:34EB dec BX
100D:34EC cmp AL,0x80
100D:34EE je short 0x351B
100D:351B inc byte ptr DS:[0x0090]
100D:351F ret near
100D:3520 cmp byte ptr DS:[0x47A7],0
100D:3525 jne short 0x351A
100D:3527 mov AL,byte ptr DS:[SI+0x0E]
100D:352A xor AH,AH
100D:352C push SI
100D:352D call near 0x96F1
100D:3530 pop SI
100D:3531 jae short 0x3542
100D:3533 mov AX,word ptr DS:[0x47C4]
100D:3536 mov DI,word ptr DS:[0x114E]
100D:353A call near 0x2AAF
100D:353D jae short 0x35AC
100D:35AC ret near
100D:35AD cmp byte ptr DS:[0x11C9],0
100D:35B2 jne short 0x35E9
100D:35B4 xor AX,AX
100D:35B6 mov byte ptr DS:[0x001A],AL
100D:35B9 mov byte ptr DS:[0x47A7],AL
100D:35BC xchg AL,byte ptr DS:[0x47A6]
100D:35C0 or AL,AL
100D:35C2 jne short 0x35AC
100D:35C4 inc byte ptr DS:[0x001A]
100D:35C8 cmp byte ptr DS:[0x000B],8
100D:35CD jne short 0x35E3
100D:35E3 mov BP,0x3520
100D:35E6 jmp near 0x36EE
100D:35E9 xor AX,AX
100D:35EB mov byte ptr DS:[0x001A],AL
100D:35EE mov byte ptr DS:[0x47A7],AL
100D:35F1 mov byte ptr DS:[0x0023],AL
100D:35F4 xchg AL,byte ptr DS:[0x47A6]
100D:35F8 or AL,AL
100D:35FA jne short 0x35AC
100D:35FC cmp word ptr DS:[0x1152],-1
100D:3601 je short 0x3637
100D:3636 ret near
100D:3637 call near 0x4182
100D:363A cmp byte ptr DS:[0x0023],0
100D:363F je short 0x3636
100D:36D3 cmp byte ptr DS:[0x0023],0
100D:36D8 je short 0x36ED
100D:36DA call near 0x98B2
100D:36DD mov byte ptr DS:[0x47A7],0
100D:36E2 mov BP,0x3520
100D:36E5 call near 0x36EE
100D:36E8 mov byte ptr DS:[0x0023],0
100D:36ED ret near
100D:36EE push BX
100D:36EF push DX
100D:36F0 mov SI,0x0FD8
100D:36F3 mov CX,0x0010
100D:36F6 mov BX,word ptr DS:[6]
100D:36FA mov DX,word ptr DS:[4]
100D:36FE cmp BX,word ptr DS:[SI+2]
100D:3701 jne short 0x371B
100D:3703 cmp DX,word ptr DS:[SI]
100D:3705 jne short 0x371B
100D:3707 pop DX
100D:3708 pop BX
100D:3709 push BX
100D:370A push DX
100D:370B push CX
100D:370C push SI
100D:370D push BP
100D:370E call near BP
100D:3710 pop BP
100D:3711 pop SI
100D:3712 pop CX
100D:3713 mov BX,word ptr DS:[6]
100D:3717 mov DX,word ptr DS:[4]
100D:371B add SI,0x0010
100D:371E loop 0x36FE
100D:3720 pop DX
100D:3721 pop BX
100D:3722 ret near
100D:37B2 call near 0x98E6
100D:37B5 call near 0x4D00
100D:37B8 mov word ptr DS:[0x472D],0
100D:37BE call near 0x5BA8
100D:37C1 call near 0xC432
100D:37C4 mov AX,0xFFFF
100D:37C7 cmp byte ptr DS:[8],AL
100D:37CB je short 0x37D5
100D:37CD mov DX,word ptr DS:[4]
100D:37D1 call near 0x3EFE
100D:37D4 lods AL,byte ptr DS:[SI]
100D:37D5 or AX,AX
100D:37D7 js short 0x37DC
100D:37D9 jmp near 0x39EC
100D:37DC call near 0x3AE9
100D:37DF or byte ptr DS:[0x47A4],1
100D:37E4 test byte ptr DS:[0x11C9],3
100D:37E9 jne short 0x37F4
100D:37EB call near 0x380C
100D:37EE call near 0x4E12
100D:37F1 jmp near 0x4D06
100D:37F4 mov byte ptr DS:[0x4728],0
100D:37F9 call near 0x4988
100D:37FC call near 0x4A5A
100D:37FF mov AX,word ptr DS:[0x487E]
100D:3802 call near 0xCA1B
100D:3805 call far dword ptr DS:[0x3959]
100D:3809 jmp near 0x388D
100D:380C mov byte ptr DS:[0x22E3],1
100D:3811 call near 0x388D
100D:3814 mov SI,word ptr DS:[0x1150]
100D:3818 mov AX,0x1972
100D:381B call near 0x5E4F
100D:381E mov BX,AX
100D:3820 mov DX,word ptr DS:[4]
100D:3824 mov AX,word ptr DS:[6]
100D:3827 cmp AL,0x80
100D:3829 mov AL,0
100D:382B je short 0x3834
100D:3834 cmp AL,byte ptr DS:[BX+5]
100D:3837 jae short 0x384A
100D:3839 add AL,byte ptr DS:[BX]
100D:383B cmp AL,0x7F
100D:383D jne short 0x3847
100D:3847 jmp near 0xC2F2
100D:388D mov byte ptr DS:[0x46DF],1
100D:3892 call near 0x395C
100D:3895 cmp byte ptr DS:[0x46D7],0
100D:389A je short 0x38AD
100D:38AD call near 0x3971
100D:38B0 call near 0x398C
100D:38B3 ret near
100D:38B4 call near 0x388D
100D:38B7 mov AX,0x0028
100D:38BA call near 0xC13E
100D:38BD xor AX,AX
100D:38BF mov BP,0x0014
100D:38C2 xor BX,BX
100D:38C4 mov CX,4
100D:38C7 xor DX,DX
100D:38C9 push CX
100D:38CA push BP
100D:38CB push AX
100D:38CC call near 0xC2FD
100D:38CF pop AX
100D:38D0 add DX,0x0028
100D:38D3 cmp DX,0x0140
100D:38D7 jb short 0x38CB
100D:38D9 pop BP
100D:38DA pop CX
100D:38DB inc AX
100D:38DC add BX,BP
100D:38DE loop 0x38C7
100D:38E0 ret near
100D:38E1 cmp byte ptr DS:[0x46DF],0
100D:38E6 je short 0x38E0
100D:38E8 call near 0x395C
100D:38EB cmp byte ptr DS:[0x46D6],BL
100D:38EF je short 0x38E0
100D:395C mov AX,word ptr DS:[2]
100D:395F mov AH,AL
100D:3961 shr AH,1
100D:3963 shr AH,1
100D:3965 and AX,0x1C0F
100D:3968 mov BX,0x2280
100D:396B xlat byte ptr DS:[BX+AL]
100D:396C add AL,AH
100D:396E mov BL,AL
100D:3970 ret near
100D:3971 mov AX,0x0028
100D:3974 add AL,byte ptr DS:[0x22E3]
100D:3978 mov byte ptr DS:[0xDBB4],AL
100D:397B call near 0xC13E
100D:397E mov AL,BL
100D:3980 xor AH,AH
100D:3982 mov byte ptr DS:[0x46D6],AL
100D:3985 call near 0xC1F4
100D:3988 lea DX,SI+6
100D:398B ret near
100D:398C mov CX,0x01C5
100D:398F mov BX,0x00DB
100D:3992 cmp byte ptr DS:[0x22E3],0
100D:3997 jne short 0x399F
100D:399F push CX
100D:39A0 call far dword ptr DS:[0x38BD]
100D:39A4 pop CX
100D:39A5 add DX,CX
100D:39A7 cmp byte ptr DS:[0x227D],0
100D:39AC jne short 0x39B8
100D:39AE mov CX,0x0030
100D:39B1 mov BX,0x02D0
100D:39B4 call far dword ptr DS:[0x38BD]
100D:39B8 ret near
100D:39E6 mov SI,0xC0B6
100D:39E9 jmp near 0xDA5F
100D:39EC mov byte ptr DS:[0x22E3],1
100D:39F1 push AX
100D:39F2 call near 0x3AE9
100D:39F5 mov AX,word ptr DS:[4]
100D:39F8 cmp AX,0x2005
100D:39FB je short 0x3A1D
100D:39FD cmp AX,0x1005
100D:3A00 je short 0x3A18
100D:3A02 dec AL
100D:3A04 jne short 0x3A20
100D:3A06 cmp AH,0x21
100D:3A09 jne short 0x3A13
100D:3A13 call near 0x37EB
100D:3A16 jmp short 0x3A20
100D:3A20 pop AX
100D:3A21 call near 0x3B59
100D:3A24 cmp byte ptr DS:[0x46DF],0
100D:3A29 je short 0x3A7C
100D:3A2B cmp byte ptr DS:[4],1
100D:3A30 jne short 0x3A7C
100D:3A32 cmp byte ptr DS:[0x4731],0xFF
100D:3A37 je short 0x3A7B
100D:3A39 mov CL,byte ptr DS:[0x46FF]
100D:3A3D xor CH,CH
100D:3A3F jcxz short 0x3A7B
100D:3A41 mov AX,0x388D
100D:3A44 push AX
100D:3A45 mov byte ptr DS:[0x4731],0
100D:3A4A test byte ptr DS:[0x47A4],0x81
100D:3A4F jne short 0x3A7B
100D:3A51 mov AX,0x0033
100D:3A54 call near 0xC13E
100D:3A57 call near 0x3A95
100D:3A5A mov AX,DX
100D:3A5C add AX,0x000C
100D:3A5F mov word ptr DS:[0x472D],AX
100D:3A62 mov AX,BX
100D:3A64 add AX,8
100D:3A67 mov word ptr DS:[0x472F],AX
100D:3A6A push CX
100D:3A6B push BX
100D:3A6C push DX
100D:3A6D call near 0x3AA9
100D:3A70 pop DX
100D:3A71 pop BX
100D:3A72 pop CX
100D:3A73 add DX,0x0046
100D:3A76 add BX,0x000A
100D:3A79 loop 0x3A6A
100D:3A7B ret near
100D:3A7C call near 0x39E6
100D:3A7F mov AX,word ptr DS:[4]
100D:3A82 cmp AL,4
100D:3A84 jne short 0x3A94
100D:3A86 cmp AH,0x20
100D:3A89 jae short 0x3A94
100D:3A94 ret near
100D:3A95 mov DX,0x0095
100D:3A98 mov BX,0x0039
100D:3A9B cmp byte ptr DS:[5],0x20
100D:3AA0 jb short 0x3AA8
100D:3AA2 mov DX,0x00CA
100D:3AA5 mov BX,0x0049
100D:3AA8 ret near
100D:3AA9 xor AX,AX
100D:3AAB call near 0xC305
100D:3AAE add DX,6
100D:3AB1 add BX,0x001E
100D:3AB4 mov AX,1
100D:3AB7 call near 0xC305
100D:3ABA sub DX,2
100D:3ABD add BX,0x0014
100D:3AC0 mov AL,byte ptr DS:[0x4731]
100D:3AC3 xor AH,AH
100D:3AC5 push AX
100D:3AC6 sub AL,0x0F
100D:3AC8 jae short 0x3ACC
100D:3ACA xor AX,AX
100D:3ACC cmp AL,5
100D:3ACE jbe short 0x3AD2
100D:3AD0 mov AL,5
100D:3AD2 add AL,2
100D:3AD4 call near 0xC305
100D:3AD7 sub DX,0x0055
100D:3ADA sub BX,0x0035
100D:3ADD pop AX
100D:3ADE cmp AL,0x0E
100D:3AE0 jb short 0x3AE4
100D:3AE2 mov AL,0x0E
100D:3AE4 add AL,8
100D:3AE6 jmp near 0xC30D
100D:3AE9 push AX
100D:3AEA push DS
100D:3AEB pop ES
100D:3AEC mov CX,0x002E
100D:3AEF mov AX,0xFFFF
100D:3AF2 mov DI,0x47F8
100D:3AF5 rep stos word ptr ES:[DI],AX
100D:3AF7 pop AX
100D:3AF8 ret near
100D:3AF9 cmp byte ptr DS:[0x002B],0
100D:3AFE je short 0x3B03
100D:3B03 cmp byte ptr DS:[0x47A4],0
100D:3B08 js short 0x3B58
100D:3B0A mov AX,word ptr DS:[0x47C4]
100D:3B0D cmp AL,0x0F
100D:3B0F jne short 0x3B15
100D:3B15 mov DI,AX
100D:3B17 shl DI,1
100D:3B19 shl DI,1
100D:3B1B mov DX,word ptr DS:[DI+0x47F8]
100D:3B1F or DX,DX
100D:3B21 js short 0x3B58
100D:3B23 push word ptr DS:[DI+0x47FA]
100D:3B27 push DX
100D:3B28 or byte ptr DS:[0x47A4],0x80
100D:3B2D call near 0x37B5
100D:3B30 pop DX
100D:3B31 pop BX
100D:3B32 cmp DX,0x00F0
100D:3B36 jb short 0x3B3B
100D:3B3B cmp BX,0x0071
100D:3B3E jb short 0x3B43
100D:3B43 mov ES,word ptr DS:[0xDBDE]
100D:3B47 push DS
100D:3B48 mov DS,word ptr DS:[0xDBDA]
100D:3B4C mov BP,6
100D:3B4F call far dword ptr SS:[0x3949]
100D:3B54 pop DS
100D:3B55 jmp near 0xC43E
100D:3B58 ret near
100D:3B59 sub SP,0x0018
100D:3B5C mov word ptr DS:[0x47F6],SP
100D:3B60 xor AH,AH
100D:3B62 dec AX
100D:3B63 push AX
100D:3B64 mov CL,4
100D:3B66 shr AX,CL
100D:3B68 je short 0x3B70
100D:3B6A add AX,0x0013
100D:3B6D call near 0xC13E
100D:3B70 pop AX
100D:3B71 and AX,0x000F
100D:3B74 shl AX,1
100D:3B76 mov SI,0xBC6E
100D:3B79 add SI,AX
100D:3B7B mov SI,word ptr DS:[SI]
100D:3B7D call near 0x3D83
100D:3B80 lods AX,word ptr DS:[SI]
100D:3B81 cmp AX,0xFFFF
100D:3B84 je short 0x3BB5
100D:3B86 js short 0x3BBF
100D:3B88 mov DI,AX
100D:3B8A shr AH,1
100D:3B8C and AH,1
100D:3B8F lods AL,byte ptr DS:[SI]
100D:3B90 mov DX,AX
100D:3B92 lods AL,byte ptr DS:[SI]
100D:3B93 xor AH,AH
100D:3B95 mov BX,AX
100D:3B97 lods AL,byte ptr DS:[SI]
100D:3B98 push SI
100D:3B99 mov byte ptr CS:[0xC21A],AL
100D:3B9D mov AX,DI
100D:3B9F and AX,0xFDFF
100D:3BA2 dec AX
100D:3BA3 and DI,0x01FF
100D:3BA7 cmp DI,1
100D:3BAA jne short 0x3BAF
100D:3BAC jmp near 0x3D12
100D:3BAF call near 0xC22F
100D:3BB2 pop SI
100D:3BB3 jmp short 0x3B80
100D:3BB5 mov byte ptr CS:[0xC21A],0
100D:3BBB add SP,0x0018
100D:3BBE ret near
100D:3BBF cmp AH,0xC0
100D:3BC2 je short 0x3BC9
100D:3BC4 call near 0x3BE9
100D:3BC7 jmp short 0x3B80
100D:3BC9 push AX
100D:3BCA mov ES,word ptr DS:[0xDBDA]
100D:3BCE lods AX,word ptr DS:[SI]
100D:3BCF mov DX,AX
100D:3BD1 lods AX,word ptr DS:[SI]
100D:3BD2 mov BX,AX
100D:3BD4 lods AX,word ptr DS:[SI]
100D:3BD5 mov DI,AX
100D:3BD7 lods AX,word ptr DS:[SI]
100D:3BD8 mov CX,AX
100D:3BDA pop AX
100D:3BDB push SI
100D:3BDC mov BP,0xFFFF
100D:3BDF mov SI,0x1470
100D:3BE2 call far dword ptr DS:[0x3901]
100D:3BE6 pop SI
100D:3BE7 jmp short 0x3B80
100D:3BE9 mov word ptr DS:[0x22D9],0x4C60
100D:3BEF push DS
100D:3BF0 pop ES
100D:3BF1 mov AL,byte ptr DS:[SI-2]
100D:3BF4 mov byte ptr DS:[0x47ED],AL
100D:3BF7 mov AL,byte ptr DS:[SI-1]
100D:3BFA mov byte ptr DS:[0x47EC],AL
100D:3BFD lods AL,byte ptr DS:[SI]
100D:3BFE cbw
100D:3BFF shl AX,1
100D:3C01 shl AX,1
100D:3C03 shl AX,1
100D:3C05 shl AX,1
100D:3C07 mov word ptr DS:[0x22DB],AX
100D:3C0A lods AL,byte ptr DS:[SI]
100D:3C0B cbw
100D:3C0C shl AX,1
100D:3C0E shl AX,1
100D:3C10 shl AX,1
100D:3C12 shl AX,1
100D:3C14 mov word ptr DS:[0x22DD],AX
100D:3C17 lods AX,word ptr DS:[SI]
100D:3C18 mov DX,AX
100D:3C1A lods AX,word ptr DS:[SI]
100D:3C1B mov BX,AX
100D:3C1D mov word ptr DS:[0x47EE],DX
100D:3C21 mov word ptr DS:[0x47F0],BX
100D:3C25 lods AX,word ptr DS:[SI]
100D:3C26 push AX
100D:3C27 and AX,0x3FFF
100D:3C2A mov DI,AX
100D:3C2C lods AX,word ptr DS:[SI]
100D:3C2D mov CX,AX
100D:3C2F call near 0x3E13
100D:3C32 mov DX,DI
100D:3C34 mov BX,CX
100D:3C36 pop AX
100D:3C37 test AX,0x4000
100D:3C3A je short 0x3C25
100D:3C3C mov word ptr DS:[0x47F2],DI
100D:3C40 mov word ptr DS:[0x47F4],CX
100D:3C44 mov DX,word ptr DS:[0x47EE]
100D:3C48 mov BX,word ptr DS:[0x47F0]
100D:3C4C mov word ptr DS:[0x22D9],0x4C62
100D:3C52 test AX,0x8000
100D:3C55 jne short 0x3C71
100D:3C57 lods AX,word ptr DS:[SI]
100D:3C58 push AX
100D:3C59 and AX,0x3FFF
100D:3C5C mov DI,AX
100D:3C5E lods AX,word ptr DS:[SI]
100D:3C5F mov CX,AX
100D:3C61 call near 0x3E13
100D:3C64 mov DX,DI
100D:3C66 mov BX,CX
100D:3C68 pop AX
100D:3C69 or AX,AX
100D:3C6B jns short 0x3C57
100D:3C6D mov DX,DI
100D:3C6F mov BX,CX
100D:3C71 mov DI,word ptr DS:[0x47F2]
100D:3C75 mov CX,word ptr DS:[0x47F4]
100D:3C79 call near 0x3E13
100D:3C7C mov ES,word ptr DS:[0xDBDA]
100D:3C80 push SI
100D:3C81 mov BX,word ptr DS:[0x47F0]
100D:3C85 mov BP,word ptr DS:[0x47F4]
100D:3C89 sub BP,BX
100D:3C8B lea SI,0x4C60
100D:3C8F mov CX,BP
100D:3C91 mov BP,0
100D:3C94 mov AH,byte ptr DS:[0x47EC]
100D:3C98 and AH,0x3E
100D:3C9B je short 0x3CA0
100D:3C9D mov BP,1
100D:3CA0 mov AL,2
100D:3CA2 mov word ptr DS:[0x22DF],AX
100D:3CA5 mov AH,byte ptr DS:[0x47ED]
100D:3CA9 xor AL,AL
100D:3CAB test byte ptr DS:[0x47EC],1
100D:3CB0 jne short 0x3CE0
100D:3CB2 push CX
100D:3CB3 push AX
100D:3CB4 lods AX,word ptr DS:[SI]
100D:3CB5 mov DX,AX
100D:3CB7 lods AX,word ptr DS:[SI]
100D:3CB8 mov CX,AX
100D:3CBA pop AX
100D:3CBB cmp DX,CX
100D:3CBD jb short 0x3CC1
100D:3CBF xchg DX,CX
100D:3CC1 inc CX
100D:3CC2 sub CX,DX
100D:3CC4 je short 0x3CD6
100D:3CC6 push SI
100D:3CC7 push BX
100D:3CC8 mov SI,word ptr DS:[0x22DF]
100D:3CCC mov DI,word ptr DS:[0x22DB]
100D:3CD0 call far dword ptr DS:[0x3945]
100D:3CD4 pop BX
100D:3CD5 pop SI
100D:3CD6 add AX,word ptr DS:[0x22DD]
100D:3CDA inc BX
100D:3CDB pop CX
100D:3CDC loop 0x3CB2
100D:3CDE pop SI
100D:3CDF ret near
100D:3CE0 push CX
100D:3CE1 push AX
100D:3CE2 lods AX,word ptr DS:[SI]
100D:3CE3 mov DX,AX
100D:3CE5 lods AX,word ptr DS:[SI]
100D:3CE6 mov CX,AX
100D:3CE8 pop AX
100D:3CE9 cmp DX,CX
100D:3CEB jae short 0x3CEF
100D:3CEF dec CX
100D:3CF0 sub CX,DX
100D:3CF2 je short 0x3D08
100D:3CF4 neg CX
100D:3CF6 push SI
100D:3CF7 push BX
100D:3CF8 mov SI,word ptr DS:[0x22DF]
100D:3CFC mov DI,word ptr DS:[0x22DB]
100D:3D00 std
100D:3D01 call far dword ptr DS:[0x3945]
100D:3D05 pop BX
100D:3D06 pop SI
100D:3D07 cld
100D:3D08 add AX,word ptr DS:[0x22DD]
100D:3D0C inc BX
100D:3D0D pop CX
100D:3D0E loop 0x3CE0
100D:3D10 pop SI
100D:3D11 ret near
100D:3D12 test byte ptr DS:[0x47A4],0x81
100D:3D17 jne short 0x3D2B
100D:3D19 mov DI,word ptr DS:[0x47F6]
100D:3D1D dec word ptr DS:[0x47F6]
100D:3D21 cmp byte ptr DS:[DI],0xFF
100D:3D24 je short 0x3D2B
100D:3D26 mov AL,byte ptr DS:[DI]
100D:3D28 call near 0x3D2F
100D:3D2B pop SI
100D:3D2C jmp near 0x3B80
100D:3D2F push word ptr DS:[0x2784]
100D:3D33 push AX
100D:3D34 xor AH,AH
100D:3D36 mov DI,AX
100D:3D38 shl DI,1
100D:3D3A shl DI,1
100D:3D3C mov word ptr DS:[DI+0x47F8],DX
100D:3D40 mov word ptr DS:[DI+0x47FA],BX
100D:3D44 mov AX,0x0026
100D:3D47 call near 0xC13E
100D:3D4A pop AX
100D:3D4B mov CH,AH
100D:3D4D cmp AL,0x0F
100D:3D4F jb short 0x3D58
100D:3D58 call near 0x9123
100D:3D5B call near 0x127C
100D:3D5E jae short 0x3D65
100D:3D65 cmp AL,0x0C
100D:3D67 jne short 0x3D72
100D:3D72 mov AH,CH
100D:3D74 shl AL,1
100D:3D76 push AX
100D:3D77 call near 0xC2FD
100D:3D7A pop AX
100D:3D7B inc AX
100D:3D7C call near 0xC22F
100D:3D7F pop AX
100D:3D80 jmp near 0xC13E
100D:3D83 push DS
100D:3D84 pop ES
100D:3D85 mov AX,0xFFFF
100D:3D88 mov CX,0x0017
100D:3D8B mov DI,word ptr DS:[0x47F6]
100D:3D8F rep stos byte ptr ES:[DI],AL
100D:3D91 mov DI,word ptr DS:[0x47F6]
100D:3D95 cmp byte ptr DS:[0x4774],0
100D:3D9A je short 0x3DB0
100D:3DB0 mov DX,word ptr DS:[0x0012]
100D:3DB4 xor DX,word ptr DS:[0x0010]
100D:3DB8 mov CL,byte ptr DS:[SI]
100D:3DBA or CL,CL
100D:3DBC je short 0x3DE5
100D:3DBE mov CH,byte ptr DS:[0x00C5]
100D:3DC2 and CH,0x0F
100D:3DC5 mov AX,0xFFFF
100D:3DC8 inc AX
100D:3DC9 shr DX,1
100D:3DCB jae short 0x3DD0
100D:3DCD call near 0x3DF4
100D:3DD0 or DX,DX
100D:3DD2 jne short 0x3DC8
100D:3DD4 mov DL,byte ptr DS:[0x476A]
100D:3DD8 dec DX
100D:3DD9 jle short 0x3DE5
100D:3DE5 lods AL,byte ptr DS:[SI]
100D:3DE6 xor AH,AH
100D:3DE8 mov DI,word ptr DS:[0x47F6]
100D:3DEC dec AX
100D:3DED add DI,AX
100D:3DEF mov word ptr DS:[0x47F6],DI
100D:3DF3 ret near
100D:3DF4 mov BX,AX
100D:3DF6 add BL,CH
100D:3DF8 sub BL,CL
100D:3DFA jae short 0x3DF8
100D:3DFC add BL,CL
100D:3DFE cmp byte ptr DS:[BX+DI],0xFF
100D:3E01 je short 0x3E10
100D:3E10 mov byte ptr DS:[BX+DI],AL
100D:3E12 ret near
100D:3E13 push BX
100D:3E14 push CX
100D:3E15 push DX
100D:3E16 push DI
100D:3E17 mov word ptr DS:[0x47E8],DX
100D:3E1B mov word ptr DS:[0x47EA],BX
100D:3E1F sub BX,CX
100D:3E21 sub DX,DI
100D:3E23 neg BX
100D:3E25 neg DX
100D:3E27 call near 0x3E80
100D:3E2A pop DI
100D:3E2B pop DX
100D:3E2C pop CX
100D:3E2D pop BX
100D:3E2E ret near
100D:3E2F mov BX,word ptr DS:[0x47EA]
100D:3E33 mov CX,DX
100D:3E35 mov DX,word ptr DS:[0x47E8]
100D:3E39 add word ptr DS:[0x47E8],CX
100D:3E3D jae short 0x3E41
100D:3E3F add DX,CX
100D:3E41 mov DI,word ptr DS:[0x22D9]
100D:3E45 mov AX,DX
100D:3E47 stos word ptr ES:[DI],AX
100D:3E48 add DI,2
100D:3E4B mov word ptr DS:[0x22D9],DI
100D:3E4F pop SI
100D:3E50 pop DI
100D:3E51 ret near
100D:3E52 mov CX,BX
100D:3E54 mov BX,word ptr DS:[0x47EA]
100D:3E58 mov DX,word ptr DS:[0x47E8]
100D:3E5C or AX,AX
100D:3E5E jns short 0x3E68
100D:3E68 add word ptr DS:[0x47EA],CX
100D:3E6C inc CX
100D:3E6D mov DI,word ptr DS:[0x22D9]
100D:3E71 mov AX,DX
100D:3E73 stos word ptr ES:[DI],AX
100D:3E74 add DI,2
100D:3E77 loop 0x3E73
100D:3E79 mov word ptr DS:[0x22D9],DI
100D:3E7D pop SI
100D:3E7E pop DI
100D:3E7F ret near
100D:3E80 push DI
100D:3E81 push SI
100D:3E82 or BX,BX
100D:3E84 je short 0x3E2F
100D:3E86 mov AX,1
100D:3E89 jns short 0x3E8F
100D:3E8F or DX,DX
100D:3E91 je short 0x3E52
100D:3E93 mov CX,1
100D:3E96 jns short 0x3E9C
100D:3E98 neg CX
100D:3E9A neg DX
100D:3E9C push AX
100D:3E9D push CX
100D:3E9E push AX
100D:3E9F push CX
100D:3EA0 mov BP,SP
100D:3EA2 mov SI,BX
100D:3EA4 mov DI,DX
100D:3EA6 xor AX,AX
100D:3EA8 cmp DX,BX
100D:3EAA jbe short 0x3EB1
100D:3EAC mov word ptr SS:[BP+2],AX
100D:3EAF jmp short 0x3EBA
100D:3EB1 or BX,BX
100D:3EB3 je short 0x3EF8
100D:3EB5 xchg DI,SI
100D:3EB7 mov word ptr SS:[BP],AX
100D:3EBA mov AX,DI
100D:3EBC mov CX,DI
100D:3EBE shr AX,1
100D:3EC0 add AX,SI
100D:3EC2 cmp AX,DI
100D:3EC4 jb short 0x3ED0
100D:3EC6 sub AX,DI
100D:3EC8 mov DX,word ptr SS:[BP+4]
100D:3ECB mov BX,word ptr SS:[BP+6]
100D:3ECE jmp short 0x3ED6
100D:3ED0 mov DX,word ptr SS:[BP]
100D:3ED3 mov BX,word ptr SS:[BP+2]
100D:3ED6 add DX,word ptr DS:[0x47E8]
100D:3EDA cmp BX,1
100D:3EDD jne short 0x3EF2
100D:3EDF push DI
100D:3EE0 push AX
100D:3EE1 mov DI,word ptr DS:[0x22D9]
100D:3EE5 mov AX,word ptr DS:[0x47E8]
100D:3EE8 stos word ptr ES:[DI],AX
100D:3EE9 add DI,2
100D:3EEC mov word ptr DS:[0x22D9],DI
100D:3EF0 pop AX
100D:3EF1 pop DI
100D:3EF2 mov word ptr DS:[0x47E8],DX
100D:3EF6 loop 0x3EC0
100D:3EF8 add SP,8
100D:3EFB pop SI
100D:3EFC pop DI
100D:3EFD ret near
100D:3EFE mov AL,DH
100D:3F00 xor AH,AH
100D:3F02 shl AX,1
100D:3F04 mov SI,AX
100D:3F06 mov SI,word ptr DS:[SI+0x13C4]
100D:3F0A mov AL,DL
100D:3F0C dec AL
100D:3F0E mov AH,5
100D:3F10 mul AH
100D:3F12 add SI,AX
100D:3F14 ret near
100D:3F15 mov BP,1
100D:3F18 jmp short 0x3F27
100D:3F1F mov BP,3
100D:3F22 jmp short 0x3F27
100D:3F27 push BP
100D:3F28 call near 0xD2BD
100D:3F2B call near 0xAC30
100D:3F2E call near 0xA7A5
100D:3F31 pop BP
100D:3F32 mov byte ptr DS:[0x47A9],0
100D:3F37 mov byte ptr DS:[0x0026],0
100D:3F3C mov DX,word ptr DS:[4]
100D:3F40 mov BX,word ptr DS:[6]
100D:3F44 cmp BL,0x80
100D:3F47 je short 0x3F67
100D:3F67 call near 0x3EFE
100D:3F6A mov DL,byte ptr SS:[BP+SI]
100D:3F6C or DL,DL
100D:3F6E je short 0x3F14
100D:3F70 js short 0x3FD2
100D:3F72 cmp byte ptr DS:[0x000B],1
100D:3F77 jne short 0x3F84
100D:3F79 call near 0xE270
100D:3F7C mov CL,2
100D:3F7E call near 0xB389
100D:3F81 call near 0xE283
100D:3F84 mov SI,word ptr DS:[0x114E]
100D:3F88 test byte ptr DS:[SI+0x0A],0x10
100D:3F8C jne short 0x3FAA
100D:3F8E or byte ptr DS:[SI+0x0A],0x10
100D:3F92 cmp DH,0x20
100D:3F95 adc byte ptr DS:[0x0025],0
100D:3F9A mov byte ptr DS:[0x0026],0xFF
100D:3F9F call near 0xE270
100D:3FA2 mov CL,3
100D:3FA4 call near 0xB389
100D:3FA7 call near 0xE283
100D:3FAA mov byte ptr DS:[0x000C],DL
100D:3FAE mov byte ptr DS:[0x0023],1
100D:3FB3 call near 0xA1C4
100D:3FB6 push BX
100D:3FB7 push DX
100D:3FB8 call near 0x36D3
100D:3FBB pop DX
100D:3FBC pop BX
100D:3FBD call near 0xA1E2
100D:3FC0 je short 0x3FC3
100D:3FC3 push BX
100D:3FC4 push DX
100D:3FC5 call near 0xABD5
100D:3FC8 pop DX
100D:3FC9 pop BX
100D:3FCA mov byte ptr DS:[0x0023],5
100D:3FCF jmp near 0x4057
100D:4002 mov AX,BX
100D:4004 cbw
100D:4005 mov BX,AX
100D:4007 call near 0xB532
100D:400A xor BH,BH
100D:400C test AL,0x40
100D:400E je short 0x4057
100D:4010 call near 0x409A
100D:4013 jne short 0x4057
100D:4015 cmp DX,word ptr DS:[SI+2]
100D:4018 jne short 0x4057
100D:401A mov AX,BX
100D:401C cbw
100D:401D mov BX,AX
100D:401F mov byte ptr DS:[0x4735],0
100D:4024 mov word ptr DS:[0x114E],SI
100D:4028 mov word ptr DS:[0x1150],SI
100D:402C mov DI,SI
100D:402E call near 0x503C
100D:4031 mov word ptr DS:[0x009A],0
100D:4037 mov word ptr DS:[0x0098],0
100D:403D call near 0x425B
100D:4040 call near 0x40AE
100D:4043 mov byte ptr DS:[8],DH
100D:4047 mov byte ptr DS:[9],BH
100D:404B cmp DH,0x20
100D:404E jb short 0x4054
100D:4054 call near 0x2170
100D:4057 call near 0x40C3
100D:405A mov word ptr DS:[4],DX
100D:405E mov AL,DL
100D:4060 xchg AL,byte ptr DS:[0x000B]
100D:4064 mov byte ptr DS:[0x000D],AL
100D:4067 mov word ptr DS:[6],BX
100D:406B cmp byte ptr DS:[0x46EB],0
100D:4070 js short 0x4099
100D:4072 cmp DX,0x3002
100D:4076 jne short 0x407B
100D:407B jmp near 0x2DBF
100D:407E mov DX,word ptr DS:[4]
100D:4082 mov BX,word ptr DS:[6]
100D:4086 cmp BL,0x80
100D:4089 jne short 0x4096
100D:408B mov SI,word ptr DS:[0x114E]
100D:408F mov DX,word ptr DS:[SI+2]
100D:4092 mov BX,word ptr DS:[SI+4]
100D:4095 ret near
100D:4096 xchg BX,AX
100D:4097 cbw
100D:4098 xchg BX,AX
100D:4099 ret near
100D:409A mov SI,0x00E4
100D:409D add SI,0x001C
100D:40A0 cmp word ptr DS:[SI],-1
100D:40A3 je short 0x40AB
100D:40A5 cmp DI,word ptr DS:[SI+6]
100D:40A8 jne short 0x409D
100D:40AA ret near
100D:40AE mov AX,DI
100D:40B0 sub AX,0x0100
100D:40B3 mov BL,0x1C
100D:40B5 div BL
100D:40B7 mov BH,AL
100D:40B9 inc BH
100D:40BB mov BL,0x80
100D:40BD mov DH,byte ptr DS:[DI+8]
100D:40C0 mov DL,1
100D:40C2 ret near
100D:40C3 mov BP,0x40C9
100D:40C6 jmp near 0x36EE
100D:40C9 test byte ptr DS:[SI+0x0F],0x40
100D:40CD je short 0x40D4
100D:40D4 ret near
100D:40D5 mov byte ptr DS:[0x0023],7
100D:40DA call near 0x36D3
100D:40DD call near 0x4AC4
100D:40E0 mov BP,0x40E6
100D:40E3 jmp near 0x36EE
100D:4182 mov AL,byte ptr DS:[0x11C9]
100D:4185 and AL,3
100D:4187 dec AL
100D:4189 jne short 0x4181
100D:418B cmp byte ptr DS:[0x11CB],0
100D:4190 jne short 0x419B
100D:4192 mov DI,word ptr DS:[0x11C5]
100D:4196 call near 0x5D36
100D:4199 jb short 0x41C5
100D:41C5 mov byte ptr DS:[0x4726],0
100D:41CA xor AL,AL
100D:41CC mov byte ptr DS:[0x21FD],AL
100D:41CF cmp word ptr DS:[0x1F12],0x4FFB
100D:41D5 jne short 0x41DA
100D:41D7 mov byte ptr DS:[0x1F11],AL
100D:41DA ret near
100D:41E1 cmp byte ptr DS:[0x196C],0
100D:41E6 jne short 0x41DB
100D:41E8 mov AL,byte ptr DS:[0x11C7]
100D:41EB add AL,0x20
100D:41ED test AL,0x40
100D:41EF mov CX,1
100D:41F2 mov AX,8
100D:41F5 je short 0x41F8
100D:41F8 call near 0xB56C
100D:41FB mov CX,8
100D:41FE lods AL,byte ptr DS:[SI]
100D:41FF test AL,0x40
100D:4201 jne short 0x420A
100D:4203 add SI,2
100D:4206 loop 0x41FE
100D:4208 clc
100D:4209 ret near
100D:425B test byte ptr DS:[DI+0x0A],0x80
100D:425F je short 0x4284
100D:4284 ret near
100D:42E9 call near 0x98B2
100D:42EC call near 0x38E1
100D:42EF mov AX,0x0024
100D:42F2 call near 0xC13E
100D:42F5 mov byte ptr DS:[0x473E],1
100D:42FA mov byte ptr DS:[0x11C9],4
100D:42FF mov word ptr DS:[0x487E],2
100D:4305 mov BP,0x212E
100D:4308 call near 0x49EA
100D:430B mov BX,0x4415
100D:430E call near 0xD323
100D:4311 mov AX,0x1AC8
100D:4314 call near 0xD95E
100D:4317 call near 0x4ACA
100D:431A mov word ptr DS:[0x46FC],0
100D:4320 call near 0x5B5D
100D:4323 mov byte ptr DS:[0x46EB],1
100D:4328 mov SI,0x1CCA
100D:432B call near 0xD72B
100D:432E mov SI,0x149C
100D:4331 mov DI,0x46E3
100D:4334 call near 0xDAAA
100D:4337 call near 0x5B99
100D:433A call near 0x439F
100D:433D mov AX,0x02BC
100D:4340 call near 0xAB4F
100D:4343 call near 0x4658
100D:4346 mov word ptr DS:[0x46ED],0x4377
100D:434C call near 0x5B93
100D:434F call near 0xB6C3
100D:4352 call near 0xC137
100D:4355 call near 0x5DCE
100D:4358 cmp byte ptr DS:[0x473E],0
100D:435D je short 0x436E
100D:435F mov AX,0x0024
100D:4362 call near 0xC13E
100D:4365 mov SI,0x14C0
100D:4368 call near 0xC21B
100D:436B call near 0xC0F4
100D:436E call near 0xC4DD
100D:4371 call near 0x445D
100D:4374 jmp near 0xD280
100D:439F call near 0xC07C
100D:43A2 cmp byte ptr DS:[0x473E],0
100D:43A7 jne short 0x43CC
100D:43CC cmp byte ptr DS:[0x002B],0
100D:43D1 jne short 0x43D6
100D:43D3 call near 0x38B4
100D:43D6 mov AX,0x0024
100D:43D9 call near 0xC13E
100D:43DC mov SI,0x14B4
100D:43DF call near 0xC21B
100D:43E2 ret near
100D:43E3 cmp byte ptr DS:[0x473E],0
100D:43E8 jne short 0x43FC
100D:43FC cmp byte ptr DS:[6],0x80
100D:4401 jne short 0x440F
100D:4403 call near 0x388D
100D:4406 call near 0xC43E
100D:4409 call near 0xC4DD
100D:440C jmp near 0xC0F4
100D:440F call near 0x4ABE
100D:4412 jmp near 0xC0F4
100D:4415 xor AL,AL
100D:4417 xchg AL,byte ptr DS:[0x46EB]
100D:441B or AL,AL
100D:441D jne short 0x4420
100D:4420 mov word ptr DS:[0xA5C0],0
100D:4426 call near 0xDAA3
100D:4429 mov SI,0x44AB
100D:442C call near 0xDA5F
100D:442F call near 0x469B
100D:4432 call near 0x5BA0
100D:4435 call near 0x43E3
100D:4438 call near 0xC0F4
100D:443B cmp word ptr DS:[0x11C5],0
100D:4440 jne short 0x4447
100D:4447 call near 0xD95B
100D:444A call near 0xD717
100D:444D call near 0x2FFB
100D:4450 cmp byte ptr DS:[0x4728],0
100D:4455 jle short 0x445A
100D:445A jmp near 0x4AC4
100D:445D mov SI,0x44AB
100D:4460 call near 0xDA5F
100D:4463 call near 0x407E
100D:4466 call near 0x62D6
100D:4469 jae short 0x4472
100D:4472 call near 0xC137
100D:4475 mov AX,0x004C
100D:4478 call near 0xC1F4
100D:447B lods AX,word ptr ES:[SI]
100D:447D and AH,0x0F
100D:4480 mov BP,AX
100D:4482 lods AX,word ptr ES:[SI]
100D:4484 xor AH,AH
100D:4486 sub BX,AX
100D:4488 sub DX,0x000D
100D:448B add BP,DX
100D:448D add AX,BX
100D:448F mov DI,0x4749
100D:4492 mov word ptr DS:[DI],DX
100D:4494 mov word ptr DS:[DI+2],BX
100D:4497 mov word ptr DS:[DI+4],BP
100D:449A mov word ptr DS:[DI+6],AX
100D:449D mov SI,0x44AB
100D:44A0 mov BP,0x012C
100D:44A3 call near 0xDA25
100D:44A6 mov byte ptr DS:[0x4751],0
100D:44AB inc byte ptr DS:[0x4751]
100D:44AF push word ptr DS:[0xDBDA]
100D:44B3 call near 0xC08E
100D:44B6 call near 0x5B93
100D:44B9 call near 0xC137
100D:44BC mov SI,0x4749
100D:44BF call near 0xDB74
100D:44C2 mov DX,word ptr DS:[SI]
100D:44C4 mov BX,word ptr DS:[SI+2]
100D:44C7 mov BP,word ptr DS:[SI+4]
100D:44CA mov AX,word ptr DS:[SI+6]
100D:44CD mov SI,0xD834
100D:44D0 cmp BP,word ptr DS:[SI+4]
100D:44D3 jb short 0x44D8
100D:44D8 cmp AX,word ptr DS:[SI+6]
100D:44DB jb short 0x44E0
100D:44E0 cmp DX,word ptr DS:[SI]
100D:44E2 jae short 0x44E6
100D:44E6 cmp BX,word ptr DS:[SI+2]
100D:44E9 jae short 0x44EE
100D:44EE call near 0xC4FB
100D:44F1 mov BL,byte ptr DS:[0x4751]
100D:44F5 shr BL,1
100D:44F7 jae short 0x4507
100D:44F9 mov AX,0x004C
100D:44FC mov DX,word ptr DS:[0x4749]
100D:4500 mov BX,word ptr DS:[0x474B]
100D:4504 call near 0xC30D
100D:4507 pop word ptr DS:[0xDBDA]
100D:450B jmp near 0xDB67
100D:450E test byte ptr DS:[0x11C9],0x0F
100D:4513 je short 0x4533
100D:4515 push BX
100D:4516 push DX
100D:4517 call near 0x4586
100D:451A pop DX
100D:451B pop BX
100D:451C mov DI,word ptr DS:[0x46FC]
100D:4520 or DI,DI
100D:4522 je short 0x4533
100D:4524 js short 0x4534
100D:4526 test byte ptr DS:[0x11C9],3
100D:452B jne short 0x4534
100D:452D cmp DI,word ptr DS:[0x114E]
100D:4531 jne short 0x4534
100D:4534 push BX
100D:4535 push DX
100D:4536 push DI
100D:4537 call near 0x456C
100D:453A call near 0xAB45
100D:453D pop DI
100D:453E mov CX,9
100D:4541 push CX
100D:4542 push DI
100D:4543 mov AX,0x0014
100D:4546 call near 0xE3A0
100D:4549 push DI
100D:454A xor DI,DI
100D:454C call near 0x45DE
100D:454F pop DI
100D:4550 mov AX,0x000A
100D:4553 call near 0xE3A0
100D:4556 call near 0x45DE
100D:4559 pop DI
100D:455A pop CX
100D:455B loop 0x4541
100D:455D push DI
100D:455E call near 0xABA9
100D:4561 pop DI
100D:4562 pop DX
100D:4563 pop BX
100D:4564 mov byte ptr DS:[0x4732],0x80
100D:4569 jmp near 0x4703
100D:456C mov AX,DI
100D:456E cmp AH,0xFF
100D:4571 je short 0x4582
100D:4573 mov AX,word ptr DS:[DI]
100D:4575 dec AX
100D:4576 shl AL,1
100D:4578 shl AL,1
100D:457A shl AL,1
100D:457C shl AL,1
100D:457E or AL,AH
100D:4580 xor AH,AH
100D:4582 add AX,0x02BC
100D:4585 ret near
100D:4586 call near 0x5D1D
100D:4589 mov DI,0
100D:458C jae short 0x45D3
100D:458E mov AL,0xFF
100D:4590 call near 0x5E6D
100D:4593 cmp AX,9
100D:4596 jb short 0x45D3
100D:4598 mov DI,0xFFFF
100D:459B mov DX,word ptr DS:[0x4749]
100D:459F or DX,DX
100D:45A1 je short 0x45D3
100D:45A3 add DX,0x000B
100D:45A6 sub DX,word ptr DS:[0xDC36]
100D:45AA neg DX
100D:45AC mov BX,word ptr DS:[0xDC38]
100D:45B0 sub BX,word ptr DS:[0x474F]
100D:45B4 call near 0x514E
100D:45B7 add AL,3
100D:45B9 mov AH,AL
100D:45BB and AH,0x1F
100D:45BE cmp AH,6
100D:45C1 mov DI,0xFFFF
100D:45C4 jae short 0x45D3
100D:45C6 rol AL,1
100D:45C8 rol AL,1
100D:45CA rol AL,1
100D:45CC and AL,7
100D:45CE or AX,0xFFF0
100D:45D1 mov DI,AX
100D:45D3 mov AX,DI
100D:45D5 xchg AX,word ptr DS:[0x46FC]
100D:45D9 cmp AX,DI
100D:45DB jne short 0x45DE
100D:45DD ret near
100D:45DE push word ptr DS:[0xDBDA]
100D:45E2 call near 0xC08E
100D:45E5 call near 0xDBB2
100D:45E8 call near 0xD075
100D:45EB mov DX,0x0055
100D:45EE mov BX,0x0022
100D:45F1 mov CX,0xF5FE
100D:45F4 cmp byte ptr DS:[0x473E],0
100D:45F9 je short 0x4600
100D:45FB add BX,4
100D:45FE mov CH,0x20
100D:4600 or DI,DI
100D:4602 je short 0x462A
100D:4604 call near 0x469B
100D:4607 cmp DI,-16
100D:460A jb short 0x4636
100D:460C mov AX,0x00A4
100D:460F call near 0xD194
100D:4612 sub DI,-16
100D:4615 cmp DI,8
100D:4618 jae short 0x4641
100D:461A mov AL,0x20
100D:461C call near word ptr DS:[0x2518]
100D:4620 mov AX,DI
100D:4622 add AX,0x00DA
100D:4625 call near 0xD19B
100D:4628 jmp short 0x4641
100D:462A call near 0x4658
100D:462D mov word ptr DS:[0xDBE4],CX
100D:4631 call near 0xD04E
100D:4634 jmp short 0x4641
100D:4636 push CX
100D:4637 call near 0x629D
100D:463A call near 0xD05F
100D:463D pop CX
100D:463E call near 0x62A6
100D:4641 cmp word ptr DS:[0xD82C],0x00ED
100D:4647 ja short 0x4651
100D:4649 mov AL,0x20
100D:464B call near word ptr DS:[0x2518]
100D:464F jmp short 0x4641
100D:4651 pop word ptr DS:[0xDBDA]
100D:4655 jmp near 0xDBEC
100D:4658 cmp word ptr DS:[0x473F],0
100D:465D jne short 0x469A
100D:465F call near 0xE270
100D:4662 mov SI,0x0057
100D:4665 call near 0xCF70
100D:4668 mov word ptr DS:[0x4741],ES
100D:466C mov word ptr DS:[0x473F],SI
100D:4670 mov word ptr DS:[0x4743],0x0055
100D:4676 mov CX,0xF561
100D:4679 mov AX,0x0022
100D:467C cmp byte ptr DS:[0x473E],0
100D:4681 je short 0x4687
100D:4683 add AL,4
100D:4685 mov CH,0x20
100D:4687 mov word ptr DS:[0x4745],AX
100D:468A mov word ptr DS:[0x4747],CX
100D:468E mov SI,0x46B5
100D:4691 mov BP,0x0018
100D:4694 call near 0xDA25
100D:4697 call near 0xE283
100D:469A ret near
100D:469B cmp word ptr DS:[0x473F],0
100D:46A0 je short 0x46B4
100D:46A2 mov word ptr DS:[0x473F],0
100D:46A8 call near 0xE270
100D:46AB mov SI,0x46B5
100D:46AE call near 0xDA5F
100D:46B1 call near 0xE283
100D:46B4 ret near
100D:46B5 les SI,word ptr DS:[0x473F]
100D:46B9 mov AL,byte ptr ES:[SI]
100D:46BC or AL,AL
100D:46BE js short 0x4702
100D:46C0 inc word ptr DS:[0x473F]
100D:46C4 mov SI,0x14A4
100D:46C7 call near 0xDB74
100D:46CA push word ptr DS:[0xDBDA]
100D:46CE call near 0xC08E
100D:46D1 mov DX,word ptr DS:[0x4743]
100D:46D5 mov BX,word ptr DS:[0x4745]
100D:46D9 call near 0xD04E
100D:46DC mov CX,word ptr DS:[0x4747]
100D:46E0 mov word ptr DS:[0xDBE4],CX
100D:46E4 call near 0xD075
100D:46E7 push AX
100D:46E8 call near 0xD12F
100D:46EB call near 0xD05F
100D:46EE mov word ptr DS:[0x4743],DX
100D:46F2 mov word ptr DS:[0x4745],BX
100D:46F6 pop AX
100D:46F7 pop word ptr DS:[0xDBDA]
100D:46FB call near 0xDB67
100D:46FE cmp AL,0x20
100D:4700 je short 0x46B5
100D:4702 ret near
100D:4703 call near 0x4944
100D:4706 call near 0x38E1
100D:4709 mov AL,byte ptr DS:[0x11C9]
100D:470C push AX
100D:470D shr AL,1
100D:470F shr AL,1
100D:4711 or byte ptr DS:[0x11C9],AL
100D:4715 call near 0xAD5E
100D:4718 cmp byte ptr DS:[0x002B],0
100D:471D je short 0x4727
100D:4727 call near 0xD2EA
100D:472A call near 0x4D00
100D:472D pop AX
100D:472E test AL,3
100D:4730 jne short 0x478F
100D:4732 mov word ptr DS:[0x472B],0
100D:4738 push AX
100D:4739 call near 0x41C5
100D:473C mov AL,byte ptr DS:[0x11C9]
100D:473F and AL,3
100D:4741 dec AL
100D:4743 jne short 0x4748
100D:4745 call near 0x181E
100D:4748 call near 0xC474
100D:474B call near 0x40D5
100D:474E pop AX
100D:474F mov BL,byte ptr DS:[0x11C7]
100D:4753 push BX
100D:4754 call near 0x4795
100D:4757 pop AX
100D:4758 mov byte ptr DS:[0x11C7],AL
100D:475B mov byte ptr DS:[8],0xFF
100D:4760 call near 0x4B3B
100D:4763 mov word ptr DS:[0x114E],0
100D:4769 mov word ptr DS:[0x4729],0
100D:476F cmp byte ptr DS:[0x46EB],0
100D:4774 js short 0x4779
100D:4776 call near 0x2DBF
100D:4779 call near 0x4AB8
100D:477C mov AL,byte ptr DS:[0x11C9]
100D:477F and AL,3
100D:4781 dec AL
100D:4783 jne short 0x478F
100D:4785 mov DI,word ptr DS:[0x1150]
100D:4789 dec byte ptr DS:[DI+0x15]
100D:478C jmp near 0xAC14
100D:4795 cmp byte ptr DS:[0x46EB],0
100D:479A js short 0x47CD
100D:479C cmp AL,4
100D:479E je short 0x47CE
100D:47CE call near 0xCE53
100D:47D1 xor AL,AL
100D:47D3 xchg AL,byte ptr DS:[0x4732]
100D:47D7 shl AL,1
100D:47D9 jae short 0x47CD
100D:47DB call near 0x181E
100D:47DE mov byte ptr DS:[0x4731],0xFF
100D:47E3 call near 0xC07C
100D:47E6 call near 0x37B2
100D:47E9 call near 0xC412
100D:47EC call near 0x5BA0
100D:47EF mov byte ptr DS:[0x4731],0
100D:47F4 mov AL,6
100D:47F6 call near 0xAB15
100D:47F9 mov CL,1
100D:47FB mov BP,0x4821
100D:47FE mov AX,0x0014
100D:4801 call near 0xE353
100D:4804 add byte ptr DS:[0x4731],CL
100D:4808 mov AL,byte ptr DS:[0x4731]
100D:480B cmp AL,0x1A
100D:480D jne short 0x4816
100D:480F or CL,CL
100D:4811 js short 0x4816
100D:4813 call near 0xAC30
100D:4816 call near 0xAE04
100D:4819 cmp byte ptr DS:[0x4731],0x21
100D:481E jb short 0x47FB
100D:4820 ret near
100D:4821 push CX
100D:4822 call near 0xC43E
100D:4825 mov AX,0x002A
100D:4828 call near 0xC13E
100D:482B call near 0xC0F4
100D:482E call near 0xC07C
100D:4831 call near 0x3A95
100D:4834 mov AL,byte ptr DS:[0x4731]
100D:4837 cmp AL,0x0D
100D:4839 jne short 0x4840
100D:483B push AX
100D:483C call near 0xAC30
100D:483F pop AX
100D:4840 sub AL,0x0E
100D:4842 jbe short 0x485D
100D:4844 pop CX
100D:4845 push CX
100D:4846 or CL,CL
100D:4848 mov CX,5
100D:484B jns short 0x484F
100D:484F mov AH,AL
100D:4851 sub DX,CX
100D:4853 dec AH
100D:4855 jne short 0x4851
100D:4857 mul AL
100D:4859 sar AX,1
100D:485B sub BX,AX
100D:485D call near 0x3AA9
100D:4860 call near 0x3A95
100D:4863 mov CL,byte ptr DS:[0x46FF]
100D:4867 xor CH,CH
100D:4869 jcxz short 0x487B
100D:486B mov AL,byte ptr DS:[0x4731]
100D:486E push AX
100D:486F mov byte ptr DS:[0x4731],0
100D:4874 call near 0x3A73
100D:4877 pop AX
100D:4878 mov byte ptr DS:[0x4731],AL
100D:487B call near 0xC4DD
100D:487E cmp byte ptr DS:[0x46D7],0
100D:4883 je short 0x4888
100D:4888 pop CX
100D:4889 ret near
100D:4944 call near 0x50BE
100D:4947 cmp DI,-16
100D:494A jb short 0x4965
100D:4965 call near 0x5124
100D:4968 xor CX,CX
100D:496A mov word ptr DS:[0x11C5],DI
100D:496E mov byte ptr DS:[0x11C8],CL
100D:4972 mov byte ptr DS:[0x11C7],0
100D:4977 jmp near 0x5119
100D:497A call near 0x98E6
100D:497D mov BP,0x212E
100D:4980 mov byte ptr DS:[0x4728],1
100D:4985 jmp near 0x430B
100D:4988 mov word ptr DS:[0x46FC],0
100D:498E call near 0x5B5D
100D:4991 mov SI,0x148A
100D:4994 mov DI,0x46E3
100D:4997 call near 0x5B99
100D:499A mov word ptr DS:[0x46ED],0x49A0
100D:49A0 call near 0xC085
100D:49A3 call near 0x5B93
100D:49A6 mov byte ptr DS:[0x46EB],1
100D:49AB call near 0xB6C3
100D:49AE call near 0x5B69
100D:49B1 call near 0xC137
100D:49B4 call near 0x5DCE
100D:49B7 mov SI,word ptr DS:[0x11C5]
100D:49BB or SI,SI
100D:49BD je short 0x49CC
100D:49BF call near 0x62C9
100D:49C2 jb short 0x49CC
100D:49C4 dec BX
100D:49C5 dec DX
100D:49C6 mov AX,0x002E
100D:49C9 call near 0xC22F
100D:49CC mov byte ptr DS:[0x46EB],0
100D:49D1 jmp near 0xC07C
100D:49EA mov byte ptr DS:[0x4728],0
100D:49EF push CS
100D:49F0 pop ES
100D:49F1 mov DI,0xE40C
100D:49F4 mov AX,0x0800
100D:49F7 stos word ptr ES:[DI],AX
100D:49F8 stos word ptr ES:[DI],AX
100D:49F9 cmp DI,0xE85C
100D:49FD jb short 0x49F7
100D:49FF ret near
100D:4A00 push CS
100D:4A01 pop ES
100D:4A02 mov DI,word ptr DS:[0x149A]
100D:4A06 mov AX,DX
100D:4A08 stos word ptr ES:[DI],AX
100D:4A09 mov AX,BX
100D:4A0B stos word ptr ES:[DI],AX
100D:4A0C cmp DI,0xE85C
100D:4A10 jb short 0x4A15
100D:4A15 mov word ptr DS:[0x149A],DI
100D:4A19 ret near
100D:4A1A cmp byte ptr DS:[0x4728],0
100D:4A1F js short 0x4A59
100D:4A21 mov SI,0x148A
100D:4A24 call near 0xDB74
100D:4A27 mov SI,word ptr DS:[0x149A]
100D:4A2B cmp SI,0xE40C
100D:4A2F jne short 0x4A34
100D:4A31 mov SI,0xE85C
100D:4A34 sub SI,4
100D:4A37 lods AX,word ptr CS:[SI]
100D:4A39 mov DX,AX
100D:4A3B lods AX,word ptr CS:[SI]
100D:4A3D mov BX,AX
100D:4A3F dec AH
100D:4A41 jns short 0x4A59
100D:4A59 ret near
100D:4A5A call near 0xC137
100D:4A5D push word ptr DS:[0xDBDA]
100D:4A61 call near 0xC085
100D:4A64 mov SI,word ptr DS:[0x149A]
100D:4A68 lods AX,word ptr CS:[SI]
100D:4A6A mov DX,AX
100D:4A6C lods AX,word ptr CS:[SI]
100D:4A6E mov BX,AX
100D:4A70 dec AH
100D:4A72 jns short 0x4A99
100D:4A74 push SI
100D:4A75 call near 0x62D6
100D:4A78 jb short 0x4A98
100D:4A7A dec BX
100D:4A7B dec DX
100D:4A7C cmp DX,0x00CC
100D:4A80 jl short 0x4A98
100D:4A82 cmp BX,4
100D:4A85 jl short 0x4A98
100D:4A87 cmp DX,0x013A
100D:4A8B jge short 0x4A98
100D:4A8D cmp BX,0x003A
100D:4A90 jge short 0x4A98
100D:4A92 mov AX,0x002F
100D:4A95 call near 0xC22F
100D:4A98 pop SI
100D:4A99 cmp SI,0xE85C
100D:4A9D jb short 0x4AA2
100D:4A9F mov SI,0xE40C
100D:4AA2 cmp SI,word ptr DS:[0x149A]
100D:4AA6 jne short 0x4A68
100D:4AA8 pop word ptr DS:[0xDBDA]
100D:4AAC ret near
100D:4AB8 mov byte ptr DS:[0x4727],0xFF
100D:4ABD ret near
100D:4ABE call near 0x37F4
100D:4AC1 call near 0xC4DD
100D:4AC4 mov byte ptr DS:[0x11CA],0
100D:4AC9 ret near
100D:4ACA mov byte ptr DS:[0x11CA],1
100D:4ACF ret near
100D:4AFD cmp byte ptr DS:[0x227D],0
100D:4B02 jne short 0x4B16
100D:4B04 call near 0x4B2B
100D:4B07 mov ES,word ptr DS:[0xDBD8]
100D:4B0B mov SI,word ptr DS:[0xDBD6]
100D:4B0F call far dword ptr DS:[0x38FD]
100D:4B13 jmp near 0xDBE3
100D:4B2B cmp byte ptr DS:[0x4728],0
100D:4B30 js short 0x4B38
100D:4B32 mov SI,0x1492
100D:4B35 call near 0xC46F
100D:4B38 jmp near 0xDBCA
100D:4B3B inc word ptr DS:[0x472B]
100D:4B3F test word ptr DS:[0x472B],0x000F
100D:4B45 jne short 0x4B4D
100D:4B47 mov CX,1
100D:4B4A call near 0x0FD9
100D:4B4D call near 0x407E
100D:4B50 call near 0x5206
100D:4B53 call near 0x40C3
100D:4B56 mov word ptr DS:[4],DX
100D:4B5A mov word ptr DS:[6],BX
100D:4B5E ret near
100D:4D00 mov SI,0x4BB9
100D:4D03 jmp near 0xDA5F
100D:4D06 mov byte ptr DS:[0x00F6],0
100D:4D0B mov DI,word ptr DS:[0x1150]
100D:4D0F mov DX,word ptr DS:[DI+2]
100D:4D12 cmp DX,word ptr DS:[4]
100D:4D16 jne short 0x4D56
100D:4D56 ret near
100D:4E12 mov word ptr DS:[0x4733],0
100D:4E18 call near 0x407E
100D:4E1B call near 0xB532
100D:4E1E push AX
100D:4E1F call near 0x4EC6
100D:4E22 mov word ptr DS:[0x196A],0
100D:4E28 pop AX
100D:4E29 test AL,0x40
100D:4E2B je short 0x4E78
100D:4E2D call near 0x409A
100D:4E30 jne short 0x4E78
100D:4E32 cmp byte ptr DS:[6],0x80
100D:4E37 je short 0x4E78
100D:4E78 mov AX,word ptr DS:[0x196A]
100D:4E7B or AX,AX
100D:4E7D je short 0x4E8C
100D:4E8C ret near
100D:4E8E mov DX,word ptr DS:[4]
100D:4E92 mov BX,word ptr DS:[6]
100D:4E96 push word ptr DS:[0x11CC]
100D:4E9A call near 0x5206
100D:4E9D call near 0x5206
100D:4EA0 call near 0x5206
100D:4EA3 call near 0x5206
100D:4EA6 call near 0x5206
100D:4EA9 call near 0x5206
100D:4EAC call near 0xB532
100D:4EAF push AX
100D:4EB0 call near 0x5206
100D:4EB3 pop AX
100D:4EB4 pop word ptr DS:[0x11CC]
100D:4EB8 push AX
100D:4EB9 call near 0xB532
100D:4EBC push AX
100D:4EBD call near 0x41E1
100D:4EC0 pop AX
100D:4EC1 pop BX
100D:4EC2 add AL,BL
100D:4EC4 shr AL,1
100D:4EC6 push BX
100D:4EC7 mov BX,word ptr DS:[0x487E]
100D:4ECB cmp BX,2
100D:4ECE jb short 0x4EED
100D:4ED0 and AL,0x0F
100D:4ED2 cmp AL,8
100D:4ED4 mov AX,word ptr DS:[0xDC00]
100D:4ED7 jae short 0x4EF3
100D:4ED9 cmp AX,2
100D:4EDC jbe short 0x4EED
100D:4EDE mov BX,5
100D:4EE1 cmp AX,4
100D:4EE4 jbe short 0x4EED
100D:4EE6 mov BX,2
100D:4EE9 mov word ptr DS:[0x487E],BX
100D:4EED mov word ptr DS:[0xDC02],BX
100D:4EF1 pop BX
100D:4EF2 ret near
100D:4EF3 mov BX,3
100D:4EF6 cmp AX,2
100D:4EF9 jbe short 0x4F03
100D:4F03 mov word ptr DS:[0xDC02],BX
100D:4F07 pop BX
100D:4F08 ret near
100D:4F0C cmp byte ptr DS:[0x4727],0
100D:4F11 je short 0x4F33
100D:4F13 cmp byte ptr DS:[0x11CA],0
100D:4F18 jne short 0x4F33
100D:4F1A mov word ptr DS:[0x1C06],0x0080
100D:4F20 mov AX,0xDBEC
100D:4F23 push AX
100D:4F24 call near 0xCA60
100D:4F27 mov AX,word ptr DS:[0xCE7A]
100D:4F2A sub AX,word ptr DS:[0x4729]
100D:4F2E cmp AX,0x0300
100D:4F31 jae short 0x4F34
100D:4F33 ret near
100D:4F34 mov AX,word ptr DS:[0xCE7A]
100D:4F37 mov word ptr DS:[0x4729],AX
100D:4F3A call near 0x4B3B
100D:4F3D call near 0x4A1A
100D:4F40 call near 0x407E
100D:4F43 call near 0x4A00
100D:4F46 call near 0xB58B
100D:4F49 mov SI,word ptr DS:[0x11C5]
100D:4F4D cmp DI,word ptr DS:[SI+6]
100D:4F50 je short 0x4FB0
100D:4F52 call near 0x2E52
100D:4F55 cmp byte ptr DS:[0x47A7],0
100D:4F5A jne short 0x4F33
100D:4F5C cmp byte ptr DS:[0x4728],0
100D:4F61 js short 0x4FAD
100D:4F63 je short 0x4F70
100D:4F70 call near 0x407E
100D:4F73 call near 0x62D6
100D:4F76 jb short 0x4FAD
100D:4F78 cmp DX,0x00D6
100D:4F7C jl short 0x4F8E
100D:4F7E cmp BX,0x000A
100D:4F81 jl short 0x4F8E
100D:4F83 cmp DX,0x0132
100D:4F87 jge short 0x4F8E
100D:4F89 cmp BX,0x0036
100D:4F8C jl short 0x4F95
100D:4F95 cmp byte ptr DS:[0x11CA],0
100D:4F9A jne short 0x4FAD
100D:4F9C dec BX
100D:4F9D dec DX
100D:4F9E call near 0xC137
100D:4FA1 mov AX,0x0030
100D:4FA4 call near 0xC085
100D:4FA7 call near 0xC22F
100D:4FAA call near 0xC07C
100D:4FAD jmp near 0x4E8E
100D:4FC3 call near 0xE3CC
100D:4FC6 mov byte ptr DS:[0x00C5],AL
100D:4FC9 xor AL,AL
100D:4FCB mov byte ptr DS:[0x4727],AL
100D:4FCE xchg AL,byte ptr DS:[0x11C9]
100D:4FD2 and AL,3
100D:4FD4 dec AL
100D:4FD6 jne short 0x4FDF
100D:4FD8 mov DI,word ptr DS:[0x11C5]
100D:4FDC inc byte ptr DS:[DI+0x15]
100D:4FDF call near 0x4AC4
100D:4FE2 call near 0xDBB2
100D:4FE5 call near 0xD717
100D:4FE8 mov DI,word ptr DS:[0x11C5]
100D:4FEC mov BX,word ptr DS:[DI+4]
100D:4FEF mov DX,word ptr DS:[DI+2]
100D:4FF2 mov word ptr DS:[0x11C5],0
100D:4FF8 jmp near 0x4002
100D:4FFB mov word ptr DS:[0x1C06],0
100D:5001 call near 0xCA01
100D:5004 mov byte ptr DS:[0x11C8],0
100D:5009 mov CX,0x00C8
100D:500C push CX
100D:500D call near 0x4B3B
100D:5010 call near 0x407E
100D:5013 call near 0xB58B
100D:5016 mov SI,word ptr DS:[0x11C5]
100D:501A cmp DI,word ptr DS:[SI+6]
100D:501D je short 0x5039
100D:501F mov byte ptr DS:[0x0023],0
100D:5024 call near 0x4182
100D:5027 cmp byte ptr DS:[0x0023],0
100D:502C pop CX
100D:502D loope 0x500C
100D:5039 pop CX
100D:503A jmp short 0x4FC3
100D:503C mov byte ptr DS:[0x00FD],0
100D:5041 mov byte ptr DS:[0x002B],0
100D:5046 test byte ptr DS:[DI+0x0A],2
100D:504A jne short 0x5058
100D:504C call near 0x5D36
100D:504F jb short 0x5081
100D:5081 ret near
100D:50BE mov byte ptr DS:[0x11CB],0
100D:50C3 ret near
100D:5119 add byte ptr DS:[0x11C7],AL
100D:511D mov word ptr DS:[0x11CC],0x0080
100D:5123 ret near
100D:5124 push DI
100D:5125 call near 0x407E
100D:5128 mov CX,word ptr DS:[DI+4]
100D:512B mov DI,word ptr DS:[DI+2]
100D:512E call near 0x5133
100D:5131 pop DI
100D:5132 ret near
100D:5133 sub BX,CX
100D:5135 neg BX
100D:5137 sub DX,DI
100D:5139 neg DX
100D:513B cmp BX,-128
100D:513E jl short 0x5146
100D:5140 cmp BX,0x0080
100D:5144 jl short 0x514A
100D:5146 sar BX,1
100D:5148 sar DX,1
100D:514A mov BH,BL
100D:514C xor BL,BL
100D:514E or BX,BX
100D:5150 mov AX,BX
100D:5152 jns short 0x5156
100D:5154 neg AX
100D:5156 or DX,DX
100D:5158 mov DI,DX
100D:515A mov CX,DX
100D:515C jns short 0x5160
100D:515E neg CX
100D:5160 cmp CX,AX
100D:5162 jb short 0x5180
100D:5164 cmp CX,1
100D:5167 jb short 0x517F
100D:5169 mov AX,0x0020
100D:516C mov CX,DX
100D:516E imul BX
100D:5170 idiv CX
100D:5172 mov DX,DI
100D:5174 or CX,CX
100D:5176 js short 0x517C
100D:5178 add AL,0x40
100D:517A clc
100D:517B ret near
100D:517C add AL,0xC0
100D:517E clc
100D:517F ret near
100D:5180 cmp AX,1
100D:5183 jb short 0x517F
100D:5185 mov AX,0x0020
100D:5188 imul DX
100D:518A idiv BX
100D:518C mov DX,DI
100D:518E or BX,BX
100D:5190 js short 0x5194
100D:5192 sub AL,0x80
100D:5194 neg AL
100D:5196 clc
100D:5197 ret near
100D:5198 mov BX,AX
100D:519A add BL,0x20
100D:519D mov BH,BL
100D:519F and BH,0x7F
100D:51A2 cmp BH,0x40
100D:51A5 jb short 0x51BA
100D:51A7 mov DX,0x0020
100D:51AA sub AL,0x40
100D:51AC or BL,BL
100D:51AE jns short 0x51B6
100D:51B6 cbw
100D:51B7 mov BX,AX
100D:51B9 ret near
100D:51BA or BL,BL
100D:51BC mov BX,0xFFE0
100D:51BF jns short 0x51C7
100D:51C1 sub AL,0x80
100D:51C3 neg AL
100D:51C5 neg BX
100D:51C7 cbw
100D:51C8 mov DX,AX
100D:51CA ret near
100D:51CB cmp byte ptr DS:[0x11CB],0
100D:51D0 jne short 0x51D9
100D:51D2 cmp byte ptr DS:[0x11C8],0
100D:51D7 je short 0x51F5
100D:51F5 mov DI,word ptr DS:[0x11C5]
100D:51F9 push BX
100D:51FA push DX
100D:51FB call near 0x5124
100D:51FE pop DX
100D:51FF pop BX
100D:5200 jb short 0x5205
100D:5202 mov byte ptr DS:[0x11C7],AL
100D:5205 ret near
100D:5206 call near 0x51CB
100D:5209 mov AL,byte ptr DS:[0x11C7]
100D:520C push DX
100D:520D push BX
100D:520E shl BX,1
100D:5210 jns short 0x5214
100D:5212 neg BX
100D:5214 mov BP,word ptr DS:[BX+0x4880]
100D:5218 call near 0x5198
100D:521B mov CX,0x0020
100D:521E mov AX,BP
100D:5220 imul DX
100D:5222 idiv CX
100D:5224 xchg BX,AX
100D:5225 imul BP
100D:5227 idiv CX
100D:5229 mov DX,BX
100D:522B mov BX,AX
100D:522D or AX,AX
100D:522F jns short 0x5233
100D:5233 add AX,word ptr DS:[0x11CC]
100D:5237 cmp AH,1
100D:523A jbe short 0x524E
100D:524E mov byte ptr DS:[0x11CC],AL
100D:5251 mov AL,AH
100D:5253 cbw
100D:5254 or BX,BX
100D:5256 jns short 0x525A
100D:525A pop BX
100D:525B add BX,AX
100D:525D pop AX
100D:525E add DX,AX
100D:5260 mov AX,BX
100D:5262 add AX,0x0060
100D:5265 cmp AX,0x00C0
100D:5268 jb short 0x5273
100D:5273 ret near
100D:5274 mov DX,word ptr DS:[DI+2]
100D:5277 mov BX,word ptr DS:[DI+4]
100D:527A push SI
100D:527B mov AX,0xFFFF
100D:527E mov word ptr DS:[0x00CA],AX
100D:5281 mov word ptr DS:[0x00D0],AX
100D:5284 mov word ptr DS:[0x00D6],AX
100D:5287 mov word ptr DS:[0x00DC],AX
100D:528A mov word ptr DS:[0x00E2],AX
100D:528D mov SI,0x0100
100D:5290 cmp word ptr DS:[SI],-1
100D:5293 je short 0x52FB
100D:5295 cmp SI,DI
100D:5297 je short 0x52F6
100D:5299 mov CX,word ptr DS:[SI+2]
100D:529C sub CX,DX
100D:529E jns short 0x52A2
100D:52A0 neg CX
100D:52A2 mov AX,word ptr DS:[SI+4]
100D:52A5 sub AX,BX
100D:52A7 jns short 0x52AB
100D:52A9 neg AX
100D:52AB mov CL,CH
100D:52AD xor CH,CH
100D:52AF cmp CL,AL
100D:52B1 jae short 0x52B5
100D:52B3 mov CX,AX
100D:52B5 cmp byte ptr DS:[SI+8],0x28
100D:52B9 jb short 0x52C9
100D:52BB mov BP,0x00E2
100D:52BE test byte ptr DS:[SI+0x0A],0x80
100D:52C2 jne short 0x52DD
100D:52C4 mov BP,0x00DC
100D:52C7 jmp short 0x52DD
100D:52C9 mov BP,0x00D0
100D:52CC test byte ptr DS:[SI+0x0A],0x80
100D:52D0 je short 0x52DD
100D:52D2 mov AL,byte ptr DS:[0x002A]
100D:52D5 cmp AL,byte ptr DS:[SI+0x0B]
100D:52D8 jb short 0x52F6
100D:52DD cmp CX,word ptr SS:[BP]
100D:52E0 jae short 0x52E8
100D:52E2 mov word ptr SS:[BP],CX
100D:52E5 mov word ptr SS:[BP+2],SI
100D:52E8 cmp CX,word ptr DS:[0x00CA]
100D:52EC jae short 0x52F6
100D:52EE mov word ptr DS:[0x00CA],CX
100D:52F2 mov word ptr DS:[0x00CC],SI
100D:52F6 add SI,0x001C
100D:52F9 jmp short 0x5290
100D:52FB push DI
100D:52FC mov BP,0x00DE
100D:52FF call near 0x5323
100D:5302 mov BP,0x00E4
100D:5305 call near 0x5323
100D:5308 mov BP,0x00D8
100D:530B call near 0x5323
100D:530E add AX,0x00DA
100D:5311 mov word ptr DS:[0x11FD],AX
100D:5314 mov BP,0x00CC
100D:5317 call near 0x5323
100D:531A mov BP,0x00D2
100D:531D call near 0x5323
100D:5320 pop DI
100D:5321 pop SI
100D:5322 ret near
100D:5323 push BX
100D:5324 push DX
100D:5325 mov DI,word ptr SS:[BP]
100D:5328 mov CX,word ptr DS:[DI+4]
100D:532B mov DI,word ptr DS:[DI+2]
100D:532E push BP
100D:532F call near 0x5133
100D:5332 pop BP
100D:5333 add AL,0x10
100D:5335 rol AL,1
100D:5337 rol AL,1
100D:5339 rol AL,1
100D:533B and AX,7
100D:533E mov byte ptr SS:[BP+2],AL
100D:5341 pop DX
100D:5342 pop BX
100D:5343 ret near
100D:5ADF call near 0x7B36
100D:5AE2 xor AX,AX
100D:5AE4 mov byte ptr DS:[0x46EB],AL
100D:5AE7 mov byte ptr DS:[0x46F3],AL
100D:5AEA mov word ptr DS:[0x3CBE],AX
100D:5AED mov word ptr DS:[0xA5C0],AX
100D:5AF0 mov word ptr DS:[0xDBE0],AX
100D:5AF3 mov word ptr DS:[0xDBE2],AX
100D:5AF6 mov word ptr DS:[0x1954],AX
100D:5AF9 mov word ptr DS:[0x2786],0xC827
100D:5AFF mov SI,0x6B34
100D:5B02 jmp near 0xDA5F
100D:5B5D call near 0x407E
100D:5B60 mov word ptr DS:[0x197E],BX
100D:5B64 mov word ptr DS:[0x197C],DX
100D:5B68 ret near
100D:5B69 mov SI,0x46E3
100D:5B6C mov AL,0xFC
100D:5B6E mov DX,word ptr DS:[SI]
100D:5B70 mov BX,word ptr DS:[SI+2]
100D:5B73 mov DI,word ptr DS:[SI+4]
100D:5B76 mov CX,word ptr DS:[SI+6]
100D:5B79 mov BP,4
100D:5B7C push AX
100D:5B7D push BP
100D:5B7E dec DX
100D:5B7F dec BX
100D:5B80 call near 0xC560
100D:5B83 pop BP
100D:5B84 pop AX
100D:5B85 inc DI
100D:5B86 inc CX
100D:5B87 sub AL,2
100D:5B89 dec BP
100D:5B8A jne short 0x5B7C
100D:5B8C ret near
100D:5B93 mov DI,0xD834
100D:5B96 mov SI,0x46E3
100D:5B99 push DS
100D:5B9A pop ES
100D:5B9B movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9C movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9D movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9E movs word ptr ES:[DI],word ptr DS:[SI]
100D:5B9F ret near
100D:5BA0 mov SI,0x1470
100D:5BA3 mov DI,0xD83C
100D:5BA6 jmp short 0x5B99
100D:5BA8 mov SI,0x1470
100D:5BAB mov DI,0xD834
100D:5BAE jmp short 0x5B99
100D:5D1D cmp DX,word ptr DS:[0x46E3]
100D:5D21 cmc
100D:5D22 jae short 0x5D35
100D:5D24 cmp DX,word ptr DS:[0x46E7]
100D:5D28 jae short 0x5D35
100D:5D2A cmp BX,word ptr DS:[0x46E5]
100D:5D2E cmc
100D:5D2F jae short 0x5D35
100D:5D31 cmp BX,word ptr DS:[0x46E9]
100D:5D35 ret near
100D:5D36 cmp byte ptr DS:[DI+8],0x28
100D:5D3A jb short 0x5D43
100D:5D3C test byte ptr DS:[DI+0x0A],8
100D:5D40 je short 0x5D43
100D:5D43 ret near
100D:5DCE mov AL,byte ptr DS:[0x46EB]
100D:5DD1 or AL,AL
100D:5DD3 jns short 0x5DDA
100D:5DDA mov DI,0xA5C0
100D:5DDD and AL,0x40
100D:5DDF je short 0x5DF1
100D:5DF1 mov SI,0x0100
100D:5DF4 cmp word ptr DS:[SI],-1
100D:5DF7 je short 0x5E3D
100D:5DF9 test byte ptr DS:[SI+0x0A],0x80
100D:5DFD jne short 0x5E38
100D:5DFF call near 0x62C9
100D:5E02 jb short 0x5E38
100D:5E04 mov word ptr DS:[DI],SI
100D:5E06 mov word ptr DS:[DI+2],DX
100D:5E09 mov BH,byte ptr DS:[0x46EB]
100D:5E0D mov word ptr DS:[DI+4],BX
100D:5E10 xor BH,BH
100D:5E12 call near 0x5E42
100D:5E15 cmp CL,0x20
100D:5E18 jae short 0x5E2E
100D:5E1A push AX
100D:5E1B push BX
100D:5E1C push DX
100D:5E1D push SI
100D:5E1E call near 0x7C8F
100D:5E21 cmp AX,word ptr DS:[0x1176]
100D:5E25 pop SI
100D:5E26 pop DX
100D:5E27 pop BX
100D:5E28 pop AX
100D:5E29 jbe short 0x5E2E
100D:5E2B add AX,5
100D:5E2E push SI
100D:5E2F push DI
100D:5E30 call near 0xC343
100D:5E33 pop DI
100D:5E34 pop SI
100D:5E35 add DI,6
100D:5E38 add SI,0x001C
100D:5E3B jmp short 0x5DF4
100D:5E3D mov word ptr DS:[DI],0
100D:5E41 ret near
100D:5E42 mov AX,0x003A
100D:5E45 test byte ptr DS:[0x46EB],0x80
100D:5E4A je short 0x5E4F
100D:5E4F mov CL,byte ptr DS:[SI+8]
100D:5E52 cmp CL,0x20
100D:5E55 jb short 0x5E6A
100D:5E57 inc AX
100D:5E58 cmp CL,0x21
100D:5E5B jb short 0x5E6A
100D:5E6A ret near
100D:5E6D push SI
100D:5E6E mov BP,SP
100D:5E70 sub SP,8
100D:5E73 mov word ptr SS:[BP-8],0xFFFF
100D:5E78 mov word ptr SS:[BP-6],DX
100D:5E7B mov word ptr SS:[BP-4],BX
100D:5E7E mov word ptr SS:[BP-2],0
100D:5E83 mov SI,0xA5BA
100D:5E86 add SI,6
100D:5E89 mov DI,word ptr DS:[SI]
100D:5E8B or DI,DI
100D:5E8D je short 0x5EBF
100D:5E8F cmp byte ptr DS:[DI+8],AL
100D:5E92 jae short 0x5E86
100D:5E94 mov BX,word ptr DS:[SI+4]
100D:5E97 cmp BH,byte ptr DS:[0x46EB]
100D:5E9B jne short 0x5E86
100D:5E9D xor BH,BH
100D:5E9F mov DX,word ptr DS:[SI+2]
100D:5EA2 sub DX,word ptr SS:[BP-6]
100D:5EA5 jns short 0x5EA9
100D:5EA7 neg DX
100D:5EA9 sub BX,word ptr SS:[BP-4]
100D:5EAC jns short 0x5EB0
100D:5EAE neg BX
100D:5EB0 add DX,BX
100D:5EB2 cmp DX,word ptr SS:[BP-8]
100D:5EB5 jae short 0x5E86
100D:5EB7 mov word ptr SS:[BP-8],DX
100D:5EBA mov word ptr SS:[BP-2],DI
100D:5EBD jmp short 0x5E86
100D:5EBF mov DI,word ptr SS:[BP-2]
100D:5EC2 mov AX,word ptr SS:[BP-8]
100D:5EC5 mov DX,word ptr SS:[BP-6]
100D:5EC8 mov BX,word ptr SS:[BP-4]
100D:5ECB add SP,8
100D:5ECE pop SI
100D:5ECF ret near
100D:5F79 xor AX,AX
100D:5F7B xchg AX,word ptr DS:[0x46F8]
100D:5F7F or AX,AX
100D:5F81 je short 0x5F90
100D:5F90 ret near
100D:6231 push BX
100D:6232 mov BL,byte ptr DS:[DI+8]
100D:6235 xor AX,AX
100D:6237 cmp BL,0x20
100D:623A jb short 0x6250
100D:6250 pop BX
100D:6251 ret near
100D:629D call near 0x6231
100D:62A0 add AX,0x0044
100D:62A3 jmp near 0xD194
100D:62A6 mov AL,byte ptr DS:[DI]
100D:62A8 xor AH,AH
100D:62AA add AX,0
100D:62AD call near 0xD194
100D:62B0 cmp byte ptr DS:[DI+1],3
100D:62B4 mov AL,0x20
100D:62B6 jb short 0x62BA
100D:62B8 mov AL,0x2D
100D:62BA call near word ptr DS:[0x2518]
100D:62BE mov AL,byte ptr DS:[DI+1]
100D:62C1 xor AH,AH
100D:62C3 add AX,0x000C
100D:62C6 jmp near 0xD19B
100D:62C9 cmp byte ptr DS:[0x46EB],1
100D:62CE jb short 0x62F1
100D:62D0 mov DX,word ptr DS:[SI+2]
100D:62D3 mov BX,word ptr DS:[SI+4]
100D:62D6 call near 0xB647
100D:62D9 cmp DX,word ptr DS:[0x46E3]
100D:62DD jb short 0x62F1
100D:62DF cmp DX,word ptr DS:[0x46E7]
100D:62E3 cmc
100D:62E4 jb short 0x62F1
100D:62E6 cmp BX,word ptr DS:[0x46E5]
100D:62EA jb short 0x62F1
100D:62EC cmp BX,word ptr DS:[0x46E9]
100D:62F0 cmc
100D:62F1 ret near
100D:63F0 cmp byte ptr DS:[0x46DE],0
100D:63F5 je short 0x642D
100D:63F7 mov ES,word ptr DS:[0xDD00]
100D:63FB mov DI,0x0100
100D:63FE mov AL,byte ptr DS:[DI+0x0A]
100D:6401 test AL,0x20
100D:6403 je short 0x6422
100D:6405 mov BL,byte ptr DS:[DI+0x1B]
100D:6408 mov BH,0xFA
100D:640A cmp BL,BH
100D:640C jae short 0x6422
100D:640E mov SI,word ptr DS:[DI+6]
100D:6411 call near 0x642E
100D:6414 shr DX,1
100D:6416 inc DX
100D:6417 add BL,DL
100D:6419 cmp BL,BH
100D:641B jb short 0x641F
100D:641F mov byte ptr DS:[DI+0x1B],BL
100D:6422 add DI,0x001C
100D:6425 cmp word ptr DS:[DI],-1
100D:6428 jne short 0x63FE
100D:642A jmp near 0x65B6
100D:642D ret near
100D:642E mov CX,3
100D:6431 dec SI
100D:6432 xor DX,DX
100D:6434 lods AX,word ptr ES:[SI]
100D:6436 and AX,0x3030
100D:6439 cmp AH,0x10
100D:643C jne short 0x643F
100D:643F cmp AL,0x10
100D:6441 jne short 0x6444
100D:6444 loop 0x6434
100D:6446 ret near
100D:65B6 mov ES,word ptr DS:[0xDD00]
100D:65BA mov SI,word ptr CS:[0x65B4]
100D:65BF xor BP,BP
100D:65C1 mov CX,0x0046
100D:65C4 shr SI,1
100D:65C6 jae short 0x65CC
100D:65C8 xor SI,0x0402
100D:65CC mov DI,SI
100D:65CE mov AL,byte ptr ES:[DI]
100D:65D1 mov AH,AL
100D:65D3 and AH,0x30
100D:65D6 cmp AH,0x10
100D:65D9 jne short 0x65E2
100D:65E2 add DI,0x07FF
100D:65E6 cmp DI,0xC5F9
100D:65EA jb short 0x65CE
100D:65EC loop 0x65C4
100D:65EE mov word ptr CS:[0x65B4],SI
100D:65F3 or BP,BP
100D:65F5 je short 0x6602
100D:6602 ret near
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
100D:6639 call near 0x6603
100D:663C push SI
100D:663D mov SI,0x08AA
100D:6640 mov AL,byte ptr DS:[SI+3]
100D:6643 test AL,0x40
100D:6645 je short 0x6665
100D:6665 add SI,0x001B
100D:6668 cmp SI,0x0FBB
100D:666C jb short 0x6640
100D:666E pop SI
100D:666F ret near
100D:6906 mov SI,AX
100D:6908 dec AL
100D:690A mov AH,0x1B
100D:690C mul AH
100D:690E add AX,0x08AA
100D:6911 xchg SI,AX
100D:6912 cmp byte ptr DS:[SI+3],0x80
100D:6916 ret near
100D:693B mov AL,byte ptr DS:[SI+3]
100D:693E and AX,0x000F
100D:6941 shr AX,1
100D:6943 shr AX,1
100D:6945 ret near
100D:6C46 mov AL,byte ptr DS:[0x002A]
100D:6C49 sub AL,0x2D
100D:6C4B cmp AL,3
100D:6C4D jae short 0x6C6E
100D:6C6E ret near
100D:6C6F xor SI,SI
100D:6C71 mov AX,word ptr DS:[0x101A]
100D:6C74 cmp AL,0x80
100D:6C76 jne short 0x6C83
100D:6C78 mov AL,0x1C
100D:6C7A dec AH
100D:6C7C mul AH
100D:6C7E add AX,0x0100
100D:6C81 mov SI,AX
100D:6C83 mov word ptr DS:[0x473C],SI
100D:6C87 call near 0x6C46
100D:6C8A mov byte ptr DS:[0x4737],0
100D:6C8F mov SI,0x08AA
100D:6C92 test word ptr DS:[SI+0x12],0x0430
100D:6C97 jne short 0x6CD3
100D:6C99 cmp byte ptr DS:[SI+0x1A],0x14
100D:6C9D jae short 0x6CA4
100D:6C9F call near 0x6D19
100D:6CA2 jb short 0x6CC3
100D:6CA4 mov AL,byte ptr DS:[SI+3]
100D:6CA7 test AL,0xA0
100D:6CA9 jne short 0x6CC3
100D:6CC3 add SI,0x001B
100D:6CC6 cmp SI,0x0FBB
100D:6CCA jb short 0x6C92
100D:6CCC mov AL,byte ptr DS:[0x4737]
100D:6CCF mov byte ptr DS:[0x00FA],AL
100D:6CD2 ret near
100D:6D19 test byte ptr DS:[SI+3],0xE3
100D:6D1D jne short 0x6D5E
100D:6D5E ret near
100D:6EFD mov AH,byte ptr DS:[SI+3]
100D:6F00 and AH,0x0F
100D:6F03 mov AL,byte ptr DS:[SI+0x15]
100D:6F06 cmp byte ptr DS:[0x00FA],0
100D:6F0B je short 0x6F0F
100D:6F0F cmp AH,6
100D:6F12 jne short 0x6F23
100D:6F23 and AH,0xFE
100D:6F26 cmp AH,8
100D:6F29 je short 0x6F2F
100D:6F2B cmp AL,0x64
100D:6F2D jb short 0x6F31
100D:6F31 cmp byte ptr DS:[0x002A],0x64
100D:6F36 jb short 0x6F47
100D:6F47 ret near
100D:79DB jmp near 0xC07C
100D:79DE xor AX,AX
100D:79E0 xchg AX,word ptr DS:[0x46FA]
100D:79E4 or AX,AX
100D:79E6 je short 0x79DB
100D:7B36 push SI
100D:7B37 push DI
100D:7B38 mov byte ptr DS:[0x46D8],1
100D:7B3D mov byte ptr DS:[0xDCE6],0x80
100D:7B42 call near 0x8770
100D:7B45 call near 0x5F79
100D:7B48 call near 0x79DE
100D:7B4B mov byte ptr DS:[0xDCE6],0
100D:7B50 mov byte ptr DS:[0x46F4],0
100D:7B55 pop DI
100D:7B56 pop SI
100D:7B57 ret near
100D:7C8F push SI
100D:7C90 call near 0x407E
100D:7C93 pop SI
100D:7C94 mov BP,BX
100D:7C96 shl BP,1
100D:7C98 jns short 0x7C9C
100D:7C9A neg BP
100D:7C9C mov BP,word ptr SS:[BP+0x4880]
100D:7CA0 mov AX,word ptr DS:[SI+2]
100D:7CA3 sub AX,DX
100D:7CA5 jns short 0x7CA9
100D:7CA9 xor DX,DX
100D:7CAB div BP
100D:7CAD sub BX,word ptr DS:[SI+4]
100D:7CB0 jns short 0x7CB4
100D:7CB2 neg BX
100D:7CB4 cmp AX,BX
100D:7CB6 jae short 0x7CBA
100D:7CB8 mov AX,BX
100D:7CBA ret near
100D:7F27 mov BX,0x46FE
100D:7F2A push DI
100D:7F2B push DS
100D:7F2C pop ES
100D:7F2D mov AL,byte ptr DS:[DI+9]
100D:7F30 lea SI,DI+0x14
100D:7F33 mov DI,BX
100D:7F35 mov CX,7
100D:7F38 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:7F3A or AL,AL
100D:7F3C je short 0x7F5D
100D:7F3E call near 0x6906
100D:7F41 mov AL,byte ptr DS:[SI+0x19]
100D:7F44 mov DI,BX
100D:7F46 shl AL,1
100D:7F48 jae short 0x7F51
100D:7F51 inc DI
100D:7F52 shl AL,1
100D:7F54 jb short 0x7F4A
100D:7F56 jne short 0x7F51
100D:7F58 mov AL,byte ptr DS:[SI+1]
100D:7F5B jmp short 0x7F3A
100D:7F5D pop DI
100D:7F5E ret near
100D:8770 cmp byte ptr DS:[0x1954],0
100D:8775 je short 0x878B
100D:878B ret near
100D:8888 cmp byte ptr DS:[0x46D9],0
100D:888D jne short 0x88E1
100D:888F mov word ptr DS:[0x479E],1
100D:8895 mov AL,byte ptr DS:[0x00FB]
100D:8898 not AL
100D:889A and AL,0x80
100D:889C mov byte ptr DS:[0x1C06],AL
100D:889F push DS
100D:88A0 pop ES
100D:88A1 mov DI,0x1BE2
100D:88A4 xor AX,AX
100D:88A6 stos word ptr ES:[DI],AX
100D:88A7 stos word ptr ES:[DI],AX
100D:88A8 stos word ptr ES:[DI],AX
100D:88A9 stos word ptr ES:[DI],AX
100D:88AA mov AL,0x80
100D:88AC stos word ptr ES:[DI],AX
100D:88AD ret near
100D:88AF or AX,AX
100D:88B1 je short 0x88AE
100D:88B3 mov word ptr DS:[0x4780],AX
100D:88B6 mov byte ptr DS:[0x47E0],0
100D:88BB test byte ptr DS:[0x46EB],0x40
100D:88C0 je short 0x88CA
100D:88CA mov SI,AX
100D:88CC call near 0xCF70
100D:88CF call near 0x88F1
100D:88D2 mov DI,0xA6B0
100D:88D5 push DI
100D:88D6 call near 0x8944
100D:88D9 pop SI
100D:88DA cmp byte ptr DS:[0x28E7],2
100D:88DF jae short 0x8888
100D:88F1 push DS
100D:88F2 push ES
100D:88F3 pop DS
100D:88F4 pop ES
100D:88F5 mov DI,0xA840
100D:88F8 lods AL,byte ptr DS:[SI]
100D:88F9 cmp AL,0xFF
100D:88FB je short 0x893D
100D:88FD cmp AL,0xFE
100D:88FF je short 0x8905
100D:8901 cmp AL,0xE0
100D:8903 jae short 0x8910
100D:8905 stos byte ptr ES:[DI],AL
100D:8906 mov AL,0xFF
100D:8908 cmp DI,0xA9CF
100D:890C jae short 0x893D
100D:890E jmp short 0x88F8
100D:893D stos byte ptr ES:[DI],AL
100D:893E mov SI,0xA840
100D:8941 push SS
100D:8942 pop DS
100D:8943 ret near
100D:8944 sub SP,0x0032
100D:8947 mov BP,SP
100D:8949 push DS
100D:894A pop ES
100D:894B cmp byte ptr DS:[SI],0x20
100D:894E jne short 0x8953
100D:8953 lods AL,byte ptr DS:[SI]
100D:8954 or AL,AL
100D:8956 js short 0x895B
100D:8958 stos byte ptr ES:[DI],AL
100D:8959 jmp short 0x8953
100D:895B mov byte ptr DS:[0x477F],AL
100D:895E cmp AL,0xF0
100D:8960 jae short 0x89B0
100D:89B0 mov BX,SP
100D:89B2 cmp BP,BX
100D:89B4 je short 0x89C1
100D:89C1 stos byte ptr ES:[DI],AL
100D:89C2 cmp AL,0xFF
100D:89C4 jne short 0x89C8
100D:89C6 xor SI,SI
100D:89C8 mov word ptr DS:[0x47B6],SI
100D:89CC mov word ptr DS:[0x47B8],DS
100D:89D0 add SP,0x0032
100D:89D3 test byte ptr DS:[0x47DE],0x10
100D:89D8 je short 0x89E3
100D:89E3 ret near
100D:8C8A xor AX,AX
100D:8C8C xchg AX,word ptr DS:[0x479E]
100D:8C90 cmp AX,2
100D:8C93 jb short 0x8CCC
100D:8CCC ret near
100D:908C mov AX,word ptr DS:[0xD83A]
100D:908F cmp AX,word ptr DS:[0x4782]
100D:9093 jbe short 0x90BC
100D:9095 cmp word ptr DS:[0x479E],0x223C
100D:909B jne short 0x90BC
100D:90BC ret near
100D:90BD mov AL,byte ptr DS:[SI+0x0E]
100D:90C0 cmp AL,0x0C
100D:90C2 je short 0x90D9
100D:90C4 test word ptr DS:[0x0012],0x1000
100D:90CA je short 0x90D9
100D:90D9 cmp AL,0x0F
100D:90DB mov BX,0x0093
100D:90DE mov DX,0x5A03
100D:90E1 je short 0x9111
100D:90E3 cmp AL,0x0E
100D:90E5 jne short 0x90F7
100D:90F7 mov CL,byte ptr DS:[SI+0x0F]
100D:90FA mov BX,0x4091
100D:90FD test CL,0x80
100D:9100 jne short 0x9111
100D:9102 and BH,0xBF
100D:9105 mov DX,0x95E2
100D:9108 test CL,0x40
100D:910B je short 0x9111
100D:9111 mov BP,0x1F7E
100D:9114 mov word ptr SS:[BP+6],BX
100D:9117 mov word ptr SS:[BP+8],DX
100D:911A call near 0xD316
100D:911D mov BX,0x97CF
100D:9120 jmp near 0xD338
100D:9123 cmp AL,0x11
100D:9125 jae short 0x917A
100D:9127 xor AH,AH
100D:9129 cmp AL,0x0D
100D:912B jb short 0x9173
100D:912D jne short 0x913B
100D:913B mov SI,word ptr DS:[0x4756]
100D:913F cmp AL,0x0E
100D:9141 je short 0x9155
100D:9155 mov AL,byte ptr DS:[SI]
100D:9157 push DX
100D:9158 mov DL,3
100D:915A div DL
100D:915C mov DL,0x0F
100D:915E or AH,AH
100D:9160 je short 0x9164
100D:9162 mov DL,0x11
100D:9164 cmp AL,DL
100D:9166 jb short 0x916C
100D:916C pop DX
100D:916D xchg AL,AH
100D:916F add AL,0x0E
100D:9171 inc AH
100D:9173 mov byte ptr DS:[0x47D0],AH
100D:9177 xor AH,AH
100D:9179 ret near
100D:9197 mov AX,word ptr DS:[0x47C4]
100D:919A cmp AX,0xFFFF
100D:919D jne short 0x91A0
100D:91A0 mov word ptr DS:[0x00F0],0
100D:91A6 cmp AX,0x000C
100D:91A9 jne short 0x91B8
100D:91B8 call near 0x9123
100D:91BB cmp AX,word ptr DS:[0x22A6]
100D:91BF je short 0x920F
100D:91C1 push AX
100D:91C2 call near 0x98B2
100D:91C5 pop AX
100D:91C6 mov word ptr DS:[0x22A6],AX
100D:91C9 mov SI,AX
100D:91CB call near 0x920F
100D:91CE mov AL,byte ptr DS:[SI+0x22A8]
100D:91D2 xor AH,AH
100D:91D4 mov word ptr DS:[0x2224],AX
100D:91D7 mov word ptr DS:[0x222C],AX
100D:91DA mov word ptr DS:[0x2234],AX
100D:91DD push DS
100D:91DE push DS
100D:91DF pop ES
100D:91E0 lds SI,word ptr DS:[0xDBB0]
100D:91E4 mov BX,word ptr DS:[SI]
100D:91E6 add SI,word ptr DS:[BX+SI-2]
100D:91E9 add SI,4
100D:91EC mov DI,0x1BF0
100D:91EF movs word ptr ES:[DI],word ptr DS:[SI]
100D:91F0 movs word ptr ES:[DI],word ptr DS:[SI]
100D:91F1 movs word ptr ES:[DI],word ptr DS:[SI]
100D:91F2 movs word ptr ES:[DI],word ptr DS:[SI]
100D:91F3 mov AX,SI
100D:91F5 add AX,2
100D:91F8 mov word ptr SS:[0x47CC],AX
100D:91FC add SI,word ptr DS:[SI]
100D:91FE mov BX,word ptr DS:[SI]
100D:9200 mov DI,SI
100D:9202 add DI,word ptr DS:[BX+SI-2]
100D:9205 pop DS
100D:9206 mov word ptr DS:[0x47CA],SI
100D:920A mov word ptr DS:[0x47D2],DI
100D:920E ret near
100D:920F add AX,2
100D:9212 jmp near 0xC13E
100D:9215 call near 0xD41B
100D:9218 cmp BP,0x1F0E
100D:921C jne short 0x9248
100D:9248 cmp BP,0x1F7E
100D:924C jne short 0x9281
100D:9281 ret near
100D:9285 cmp BX,0x0098
100D:9289 jae short 0x92C9
100D:928B mov SI,0x47F8
100D:928E mov CX,0x0017
100D:9291 lods AX,word ptr DS:[SI]
100D:9292 mov DI,AX
100D:9294 lods AX,word ptr DS:[SI]
100D:9295 mov BP,AX
100D:9297 or DI,DI
100D:9299 js short 0x92A9
100D:929B sub DI,DX
100D:929D cmp DI,-32
100D:92A0 jb short 0x92A9
100D:92A2 sub BP,BX
100D:92A4 cmp BP,-80
100D:92A7 jae short 0x92EB
100D:92A9 loop 0x9291
100D:92AB mov AX,word ptr DS:[0x472D]
100D:92AE or AX,AX
100D:92B0 je short 0x92C8
100D:92C8 ret near
100D:92C9 xor CX,CX
100D:92CB mov CL,byte ptr DS:[0x1152]
100D:92CF cmp CL,0xFF
100D:92D2 je short 0x9281
100D:92EB sub CX,0x0017
100D:92EE neg CX
100D:92F0 stc
100D:92F1 ret near
100D:92F2 xor AL,AL
100D:92F4 jmp near 0x93AA
100D:93AA xor AH,AH
100D:93AC mov word ptr DS:[0x47E1],0
100D:93B2 push AX
100D:93B3 mov word ptr DS:[0x47C4],AX
100D:93B6 call near 0x91A0
100D:93B9 call near 0x3AF9
100D:93BC call near 0x9197
100D:93BF call near 0x9908
100D:93C2 mov SI,word ptr DS:[0x47C8]
100D:93C6 mov word ptr DS:[0x4540],0
100D:93CC call near 0x9BAC
100D:93CF call near 0x1834
100D:93D2 call near 0xC0F4
100D:93D5 call near 0xC4DD
100D:93D8 pop AX
100D:93D9 call near 0x93DF
100D:93DC jmp near 0x9472
100D:93DF mov CL,AL
100D:93E1 shl AL,1
100D:93E3 shl AL,1
100D:93E5 shl AL,1
100D:93E7 mov word ptr DS:[0x47BE],AX
100D:93EA mov AX,1
100D:93ED shl AX,CL
100D:93EF or word ptr DS:[0x000E],AX
100D:93F3 or word ptr DS:[0x0014],AX
100D:93F7 mov AL,0x10
100D:93F9 mul CL
100D:93FB add AX,0x0FD8
100D:93FE mov word ptr DS:[0x47A2],AX
100D:9401 mov SI,AX
100D:9403 mov word ptr DS:[0x47BA],0
100D:9409 call near 0x90BD
100D:940C mov word ptr DS:[0x47B6],0
100D:9412 mov byte ptr DS:[0x47C2],0x80
100D:9417 mov byte ptr DS:[0x0019],0
100D:941C ret near
100D:9472 call near 0x9F40
100D:9475 mov byte ptr DS:[0x226D],0x0A
100D:947A mov byte ptr DS:[0x001B],0
100D:947F cmp word ptr DS:[0x47B6],0
100D:9484 jne short 0x94DD
100D:9486 mov SI,word ptr DS:[0x47BA]
100D:948A or SI,SI
100D:948C jne short 0x949A
100D:948E mov SI,word ptr DS:[0x47BE]
100D:9492 mov AX,SI
100D:9494 shl SI,1
100D:9496 mov SI,word ptr DS:[SI-21898]
100D:949A cmp SI,-1
100D:949D je short 0x94B9
100D:949F call near 0x9B49
100D:94A2 call near 0x9F9E
100D:94A5 mov word ptr DS:[0x47BA],SI
100D:94A9 jae short 0x94DA
100D:94AB mov AX,word ptr DS:[0x47BE]
100D:94AE inc AX
100D:94AF mov word ptr DS:[0x47BE],AX
100D:94B2 mov SI,AX
100D:94B4 and AX,3
100D:94B7 jne short 0x9492
100D:94DA jmp near 0xD280
100D:94F3 cmp word ptr DS:[0x47C4],0x0010
100D:94F8 jae short 0x9532
100D:94FA push SI
100D:94FB mov SI,word ptr DS:[0x47A2]
100D:94FF mov AL,byte ptr DS:[SI+0x0F]
100D:9502 mov byte ptr DS:[0x0018],AL
100D:9505 test AL,0x40
100D:9507 mov AX,word ptr DS:[SI+8]
100D:950A jne short 0x950F
100D:950C mov AX,word ptr DS:[SI+0x0A]
100D:950F sub AX,word ptr DS:[2]
100D:9513 neg AX
100D:9515 mov word ptr DS:[0x0016],AX
100D:9518 pop SI
100D:9519 cmp byte ptr DS:[0x002A],0x64
100D:951E jae short 0x9532
100D:9520 cmp word ptr DS:[0x47C4],9
100D:9525 jae short 0x9532
100D:9527 mov DI,word ptr DS:[0x11DB]
100D:952B or DI,DI
100D:952D je short 0x9532
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
100D:96F1 mov word ptr DS:[0x47C4],AX
100D:96F4 cmp AL,0x0E
100D:96F6 jne short 0x9702
100D:96F8 mov SI,word ptr DS:[0x4756]
100D:96FC call near 0x31F6
100D:96FF mov AX,0x000E
100D:9702 shl AX,1
100D:9704 shl AX,1
100D:9706 shl AX,1
100D:9708 or AX,4
100D:970B mov SI,AX
100D:970D shl SI,1
100D:970F mov SI,word ptr DS:[SI-21898]
100D:9713 call near 0x9F40
100D:9716 jmp near 0x9F8B
100D:978E call near 0x4ACA
100D:9791 mov AX,word ptr DS:[0x47C4]
100D:9794 cmp AX,0xFFFF
100D:9797 je short 0x97CE
100D:9799 call near 0x91A0
100D:979C call near 0x9908
100D:979F cmp word ptr DS:[0x479E],0
100D:97A4 je short 0x97AC
100D:97A6 mov SI,0x1BE2
100D:97A9 call near 0xC477
100D:97AC mov SI,word ptr DS:[0x47C8]
100D:97B0 or SI,SI
100D:97B2 je short 0x97C8
100D:97B4 mov word ptr DS:[0x4540],0
100D:97BA call near 0x9BAC
100D:97BD cmp word ptr DS:[0x479E],0x223C
100D:97C3 jne short 0x97C8
100D:97C8 call near 0xC0F4
100D:97CB jmp near 0xC4DD
100D:97CF call near 0xA7A5
100D:97D2 cmp word ptr DS:[0x47C4],-1
100D:97D7 je short 0x97CE
100D:97D9 mov SI,word ptr DS:[0x47A2]
100D:97DD or byte ptr DS:[SI+0x0F],0x20
100D:97E1 and byte ptr DS:[SI+0x0F],0xFB
100D:97E5 mov word ptr DS:[0x47E1],0
100D:97EB cmp byte ptr DS:[0x11C9],0
100D:97F0 je short 0x980C
100D:980C call near 0x8C8A
100D:980F cmp byte ptr DS:[0x47A4],0
100D:9814 mov SI,word ptr DS:[0x47A2]
100D:9818 js short 0x9849
100D:9849 mov word ptr DS:[0x1C06],0
100D:984F test byte ptr DS:[SI+0x0F],0x40
100D:9853 je short 0x9858
100D:9858 xor AX,AX
100D:985A mov word ptr DS:[0x4540],AX
100D:985D mov word ptr DS:[0x479E],AX
100D:9860 and byte ptr DS:[0x47D1],0x3F
100D:9865 mov word ptr DS:[0x47C8],AX
100D:9868 and byte ptr DS:[0x47A4],0x7F
100D:986D call near 0x9B8B
100D:9870 mov AL,byte ptr DS:[0x0023]
100D:9873 sub AL,0x64
100D:9875 cmp AL,0x10
100D:9877 jb short 0x9898
100D:9879 call near 0x2EFB
100D:987C cmp byte ptr DS:[0x11C9],0
100D:9881 jne short 0x9886
100D:9883 call near 0x3090
100D:9886 call near 0x37B2
100D:9889 call near 0xC412
100D:988C call near 0xC0F4
100D:988F call near 0x1834
100D:9892 call near 0xC4DD
100D:9895 jmp near 0x17E6
100D:98B2 cmp byte ptr DS:[0x47C3],0
100D:98B7 jne short 0x98E5
100D:98B9 xor AX,AX
100D:98BB mov word ptr DS:[0x4540],AX
100D:98BE and byte ptr DS:[0x47D1],0x3F
100D:98C3 xchg AX,word ptr DS:[0x47C8]
100D:98C7 or AX,AX
100D:98C9 je short 0x98E5
100D:98E5 ret near
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
100D:9908 mov SI,word ptr DS:[0x47CA]
100D:990C mov ES,word ptr DS:[0xDBB2]
100D:9910 call near 0x994F
100D:9913 mov byte ptr DS:[0x47D1],0xC0
100D:9918 mov AL,byte ptr DS:[0x478C]
100D:991B xor AH,AH
100D:991D shl AX,1
100D:991F shl AX,1
100D:9921 mov word ptr DS:[0x47CE],AX
100D:9924 add SI,word ptr ES:[BP+SI]
100D:9927 call near 0x996C
100D:992A mov word ptr DS:[0x47C8],SI
100D:992E xchg SI,word ptr DS:[0x47C6]
100D:9932 or SI,SI
100D:9934 jne short 0x994E
100D:9936 cmp byte ptr DS:[0x00EA],0
100D:993B jg short 0x994E
100D:993D mov AX,word ptr DS:[0x47C4]
100D:9940 call near 0x127C
100D:9943 jb short 0x994E
100D:9945 mov SI,0x99BE
100D:9948 mov BP,0x0010
100D:994B call near 0xDA25
100D:994E ret near
100D:994F mov AL,byte ptr DS:[0x47D0]
100D:9952 or AL,AL
100D:9954 jne short 0x9963
100D:9956 mov BX,6
100D:9959 call near 0xE3B7
100D:995C mov BP,AX
100D:995E add BP,word ptr DS:[0x00F0]
100D:9962 ret near
100D:996C cmp byte ptr DS:[0x47D0],0
100D:9971 je short 0x9981
100D:9981 ret near
100D:9985 test word ptr DS:[0x47CE],7
100D:998B jne short 0x9982
100D:998D ret near
100D:99BE cmp byte ptr DS:[0x47C3],0
100D:99C3 je short 0x99DA
100D:99DA call near 0x9197
100D:99DD mov AL,byte ptr DS:[0x47D1]
100D:99E0 or AL,AL
100D:99E2 jns short 0x9A1C
100D:99E4 test AL,0x10
100D:99E6 jne short 0x9A40
100D:99F6 dec word ptr DS:[0x47CE]
100D:99FA mov word ptr DS:[0x47C8],SI
100D:99FE call near 0x9BB1
100D:9A01 mov word ptr DS:[0x47C6],SI
100D:9A05 cmp word ptr DS:[0xD834],0x013F
100D:9A0B je short 0x9A1C
100D:9A0D call near 0x908C
100D:9A10 mov SI,0xD834
100D:9A13 call near 0xDB74
100D:9A16 call near 0xC4F0
100D:9A19 jmp near 0xDB67
100D:9A1C ret near
100D:9A40 mov SI,word ptr DS:[0x47C6]
100D:9A44 mov ES,word ptr DS:[0xDBB2]
100D:9A48 cmp word ptr DS:[0x47CE],0
100D:9A4D jg short 0x99F6
100D:9A4F call near 0x9AB4
100D:9A52 jb short 0x99F6
100D:9A54 call near 0x9A7B
100D:9A57 or AH,AH
100D:9A59 jne short 0x9A1C
100D:9A5B call near 0x9A60
100D:9A5E jmp short 0x99F6
100D:9A60 or AL,AL
100D:9A62 je short 0x9A74
100D:9A64 mov BX,AX
100D:9A66 xor AL,AL
100D:9A68 mov CX,0xFFFF
100D:9A6B mov DI,SI
100D:9A6D repne scas AL,byte ptr ES:[DI]
100D:9A6F dec BX
100D:9A70 jne short 0x9A6D
100D:9A72 mov SI,DI
100D:9A74 mov word ptr DS:[0x47CE],8
100D:9A7A ret near
100D:9A7B mov AL,byte ptr DS:[0x47D0]
100D:9A7E mov BX,0x0F18
100D:9A81 or AL,AL
100D:9A83 jne short 0x9A9A
100D:9A85 mov AL,5
100D:9A87 mov BX,0x0F38
100D:9A8A cmp word ptr DS:[0x47C4],7
100D:9A8F jne short 0x9A9A
100D:9A9A dec AL
100D:9A9C xor AH,AH
100D:9A9E shl AX,1
100D:9AA0 mov BP,AX
100D:9AA2 add BP,word ptr DS:[0x00F0]
100D:9AA6 mov SI,word ptr DS:[0x47CA]
100D:9AAA mov ES,word ptr DS:[0xDBB2]
100D:9AAE add SI,word ptr ES:[BP+SI]
100D:9AB1 jmp near 0xE3B7
100D:9AB4 mov AL,byte ptr DS:[0x47E1]
100D:9AB7 or AL,AL
100D:9AB9 je short 0x9B08
100D:9B08 ret near
100D:9B49 mov AX,word ptr DS:[0x47E1]
100D:9B4C cmp AL,0x80
100D:9B4E jne short 0x9B84
100D:9B84 mov word ptr DS:[0x47E1],0
100D:9B8A ret near
100D:9B8B call near 0xA7A5
100D:9B8E xor AX,AX
100D:9B90 mov byte ptr DS:[0x47C3],0
100D:9B95 mov word ptr DS:[0x47CE],AX
100D:9B98 and byte ptr DS:[0x47D1],0x7F
100D:9B9D xchg AX,word ptr DS:[0x47C6]
100D:9BA1 or AX,AX
100D:9BA3 je short 0x9BAB
100D:9BA5 mov SI,0x99BE
100D:9BA8 jmp near 0xDA5F
100D:9BAB ret near
100D:9BAC push SI
100D:9BAD call near 0x9197
100D:9BB0 pop SI
100D:9BB1 call near 0x9BEE
100D:9BB4 push SI
100D:9BB5 cmp word ptr DS:[0x4540],0
100D:9BBA jne short 0x9BCC
100D:9BBC mov SI,0x1BF0
100D:9BBF mov DI,0xD834
100D:9BC2 call near 0x5B99
100D:9BC5 mov word ptr DS:[SI],0x0080
100D:9BC9 jmp short 0x9BD7
100D:9BCC call near 0x9C2D
100D:9BCF cmp word ptr DS:[0xD834],0x013F
100D:9BD5 je short 0x9BEC
100D:9BD7 mov SI,0xD834
100D:9BDA cmp word ptr DS:[SI+6],0x0098
100D:9BDF jb short 0x9BE6
100D:9BE1 mov word ptr DS:[SI+6],0x0098
100D:9BE6 call near 0xC446
100D:9BE9 call near 0x9D16
100D:9BEC pop SI
100D:9BED ret near
100D:9BEE xor CX,CX
100D:9BF0 push DS
100D:9BF1 pop ES
100D:9BF2 mov DS,word ptr SS:[0xDBB2]
100D:9BF7 mov DI,0x460A
100D:9BFA lods AL,byte ptr DS:[SI]
100D:9BFB xor AH,AH
100D:9BFD or AL,AL
100D:9BFF je short 0x9C25
100D:9C01 cmp AL,1
100D:9C03 jne short 0x9C08
100D:9C08 push SI
100D:9C09 sub AX,2
100D:9C0C shl AX,1
100D:9C0E mov BP,AX
100D:9C10 mov SI,word ptr SS:[0x47CC]
100D:9C15 add SI,word ptr DS:[BP+SI]
100D:9C18 lods AL,byte ptr DS:[SI]
100D:9C19 or AL,AL
100D:9C1B je short 0x9C22
100D:9C1D stos byte ptr ES:[DI],AL
100D:9C1E movs word ptr ES:[DI],word ptr DS:[SI]
100D:9C1F inc CX
100D:9C20 jmp short 0x9C18
100D:9C22 pop SI
100D:9C23 jmp short 0x9BFA
100D:9C25 mov word ptr SS:[0x4608],CX
100D:9C2A push SS
100D:9C2B pop DS
100D:9C2C ret near
100D:9C2D mov word ptr DS:[0xD834],0x013F
100D:9C33 mov word ptr DS:[0xD836],0x00C7
100D:9C39 xor AX,AX
100D:9C3B mov word ptr DS:[0xD838],AX
100D:9C3E mov word ptr DS:[0xD83A],AX
100D:9C41 mov AX,DS
100D:9C43 mov ES,AX
100D:9C45 mov SI,0x4540
100D:9C48 mov DI,0x4608
100D:9C4B call near 0x9C54
100D:9C4E mov SI,0x4608
100D:9C51 mov DI,0x4540
100D:9C54 lods AX,word ptr DS:[SI]
100D:9C55 mov CX,AX
100D:9C57 push CX
100D:9C58 push DI
100D:9C59 mov CX,word ptr DS:[DI]
100D:9C5B add DI,2
100D:9C5E cmps word ptr DS:[SI],word ptr ES:[DI]
100D:9C5F lahf
100D:9C60 cmps byte ptr DS:[SI],byte ptr ES:[DI]
100D:9C61 mov AL,AH
100D:9C63 lahf
100D:9C64 and AL,AH
100D:9C66 test AL,0x40
100D:9C68 jne short 0x9C75
100D:9C6A sub SI,3
100D:9C6D loop 0x9C5E
100D:9C6F call near 0x9CC6
100D:9C72 add SI,3
100D:9C75 pop DI
100D:9C76 pop CX
100D:9C77 loop 0x9C57
100D:9C79 cmp byte ptr DS:[0x47E1],0x81
100D:9C7E je short 0x9CA6
100D:9C80 call near 0xABCC
100D:9C83 je short 0x9CA6
100D:9C85 mov AX,word ptr DS:[0x47C4]
100D:9C88 cmp AL,9
100D:9C8A je short 0x9CC5
100D:9C8C cmp AL,0x0C
100D:9C8E je short 0x9CC5
100D:9C90 mov SI,word ptr DS:[0xDC28]
100D:9C94 mov AX,word ptr DS:[SI+2]
100D:9C97 cmp AX,word ptr DS:[0xD83A]
100D:9C9B jae short 0x9CA6
100D:9CA6 cmp byte ptr DS:[0x47E1],0x80
100D:9CAB jne short 0x9CC5
100D:9CC5 ret near
100D:9CC6 push SI
100D:9CC7 push DS
100D:9CC8 xor AH,AH
100D:9CCA lods AL,byte ptr DS:[SI]
100D:9CCB mov BP,AX
100D:9CCD dec BP
100D:9CCE lods AL,byte ptr DS:[SI]
100D:9CCF mov DX,AX
100D:9CD1 add DX,word ptr DS:[0x1BF0]
100D:9CD5 lods AL,byte ptr DS:[SI]
100D:9CD6 mov BX,AX
100D:9CD8 add BX,word ptr DS:[0x1BF2]
100D:9CDC lds SI,word ptr DS:[0xDBB0]
100D:9CE0 shl BP,1
100D:9CE2 add SI,word ptr DS:[BP+SI]
100D:9CE5 mov BP,0xD834
100D:9CE8 cmp word ptr SS:[BP],DX
100D:9CEB jb short 0x9CF0
100D:9CED mov word ptr SS:[BP],DX
100D:9CF0 cmp word ptr SS:[BP+2],BX
100D:9CF3 jb short 0x9CF8
100D:9CF5 mov word ptr SS:[BP+2],BX
100D:9CF8 lods AX,word ptr DS:[SI]
100D:9CF9 and AX,0x01FF
100D:9CFC add DX,AX
100D:9CFE lods AX,word ptr DS:[SI]
100D:9CFF xor AH,AH
100D:9D01 add BX,AX
100D:9D03 cmp word ptr SS:[BP+4],DX
100D:9D06 jae short 0x9D0B
100D:9D08 mov word ptr SS:[BP+4],DX
100D:9D0B cmp word ptr SS:[BP+6],BX
100D:9D0E jae short 0x9D13
100D:9D10 mov word ptr SS:[BP+6],BX
100D:9D13 pop DS
100D:9D14 pop SI
100D:9D15 ret near
100D:9D16 push DS
100D:9D17 pop ES
100D:9D18 mov DI,0x4540
100D:9D1B mov SI,0x4608
100D:9D1E mov CX,word ptr DS:[SI]
100D:9D20 push SI
100D:9D21 mov AX,CX
100D:9D23 shl CX,1
100D:9D25 add CX,AX
100D:9D27 add CX,2
100D:9D2A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:9D2C pop SI
100D:9D2D lods AX,word ptr DS:[SI]
100D:9D2E mov CX,AX
100D:9D30 push CX
100D:9D31 lods AL,byte ptr DS:[SI]
100D:9D32 xor AH,AH
100D:9D34 mov BP,AX
100D:9D36 lods AL,byte ptr DS:[SI]
100D:9D37 mov DX,AX
100D:9D39 lods AL,byte ptr DS:[SI]
100D:9D3A mov BX,AX
100D:9D3C add DX,word ptr DS:[0x1BF0]
100D:9D40 add BX,word ptr DS:[0x1BF2]
100D:9D44 push SI
100D:9D45 dec BP
100D:9D46 mov ES,word ptr DS:[0xDBDA]
100D:9D4A lds SI,word ptr DS:[0xDBB0]
100D:9D4E shl BP,1
100D:9D50 add SI,word ptr DS:[BP+SI]
100D:9D53 lods AX,word ptr DS:[SI]
100D:9D54 mov DI,AX
100D:9D56 lods AX,word ptr DS:[SI]
100D:9D57 xor AH,AH
100D:9D59 mov CX,AX
100D:9D5B mov BP,0xD834
100D:9D5E call far dword ptr SS:[0x38CD]
100D:9D63 push SS
100D:9D64 pop DS
100D:9D65 pop SI
100D:9D66 pop CX
100D:9D67 loop 0x9D30
100D:9D69 ret near
100D:9DE3 cmp word ptr DS:[0x47C4],0x0010
100D:9DE8 jae short 0x9D93
100D:9DEA push AX
100D:9DEB push SI
100D:9DEC call near 0x9197
100D:9DEF pop SI
100D:9DF0 pop AX
100D:9DF1 cmp byte ptr DS:[0x46EB],0
100D:9DF6 js short 0x9E75
100D:9DF8 mov DI,0xD834
100D:9DFB call near 0x5B99
100D:9DFE mov DX,word ptr DS:[0x1BF0]
100D:9E02 mov BX,word ptr DS:[0x1BF2]
100D:9E06 add word ptr DS:[DI-8],DX
100D:9E09 add word ptr DS:[DI-6],BX
100D:9E0C add word ptr DS:[DI-4],DX
100D:9E0F add word ptr DS:[DI-2],BX
100D:9E12 mov SI,word ptr DS:[0x47D2]
100D:9E16 mov AH,byte ptr DS:[0x47D0]
100D:9E1A dec AH
100D:9E1C js short 0x9E2D
100D:9E2D xor AH,AH
100D:9E2F shl AX,1
100D:9E31 add SI,AX
100D:9E33 call near 0x9BEE
100D:9E36 mov SI,0x4608
100D:9E39 cmp byte ptr DS:[0x00EA],0
100D:9E3E jg short 0x9E74
100D:9E40 cmp word ptr DS:[SI],2
100D:9E43 jb short 0x9E57
100D:9E45 call near 0x9D2D
100D:9E48 call near 0x908C
100D:9E4B mov SI,0xD834
100D:9E4E call near 0xDB74
100D:9E51 call near 0xC4F0
100D:9E54 jmp near 0xDB67
100D:9EFD mov AL,byte ptr DS:[0x47DC]
100D:9F00 mov byte ptr DS:[0x47DD],AL
100D:9F03 mov AX,word ptr DS:[0x4780]
100D:9F06 mov BX,word ptr DS:[0x47C4]
100D:9F0A call near 0xA6CC
100D:9F0D jae short 0x9EFC
100D:9F0F cmp word ptr DS:[0x47C4],0x0010
100D:9F14 jae short 0x9F19
100D:9F16 call near 0x9F1C
100D:9F19 jmp near 0xA75C
100D:9F1C call near 0x9197
100D:9F1F or byte ptr DS:[0x47D1],0x10
100D:9F24 call near 0x9A7B
100D:9F27 xor AH,AH
100D:9F29 call near 0x9A60
100D:9F2C mov word ptr DS:[0x47C6],SI
100D:9F30 ret near
100D:9F40 mov AX,word ptr DS:[0x47C4]
100D:9F43 cmp AX,2
100D:9F46 jne short 0x9F56
100D:9F56 mov CL,0x10
100D:9F58 mul CL
100D:9F5A add AX,0x0FD8
100D:9F5D mov word ptr DS:[0x47A2],AX
100D:9F60 cmp byte ptr DS:[0x46EB],0
100D:9F65 jne short 0x9F82
100D:9F67 call near 0xC07C
100D:9F6A mov word ptr DS:[0x4784],0x0028
100D:9F70 mov word ptr DS:[0x4786],0x0010
100D:9F76 mov word ptr DS:[0x4788],0x0010
100D:9F7C mov word ptr DS:[0x478A],0x0010
100D:9F82 mov word ptr DS:[0xDBE4],0x00F0
100D:9F88 jmp near 0xD068
100D:9F8B push word ptr DS:[0x47C2]
100D:9F8F mov byte ptr DS:[0x47C2],0x20
100D:9F94 call near 0x9F9E
100D:9F97 pop word ptr DS:[0x47C2]
100D:9F9B ret near
100D:9F9C stc
100D:9F9D ret near
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
100D:9FE7 push SI
100D:9FE8 push AX
100D:9FE9 call near 0xA0F1
100D:9FEC call near 0x1803
100D:9FEF call near 0x3AF9
100D:9FF2 pop AX
100D:9FF3 call near 0x91A0
100D:9FF6 pop SI
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
100D:A03B call near 0x88AF
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
100D:A0B8 push SI
100D:A0B9 call near 0x978E
100D:A0BC pop SI
100D:A0BD cmp byte ptr DS:[0x4774],0
100D:A0C2 je short 0xA0C9
100D:A0C9 cmp byte ptr DS:[0x00EA],0
100D:A0CE jg short 0xA0E2
100D:A0D0 call near 0xE270
100D:A0D3 call near 0x9EFD
100D:A0D6 mov AX,0x0F66
100D:A0D9 xchg AX,word ptr DS:[0x227E]
100D:A0DD call near AX
100D:A0DF call near 0xE283
100D:A0E2 cmp byte ptr DS:[0x00FB],0
100D:A0E7 js short 0xA0EF
100D:A0E9 mov AL,byte ptr DS:[0x28E8]
100D:A0EC mov byte ptr DS:[0x28E7],AL
100D:A0EF clc
100D:A0F0 ret near
100D:A0F1 cmp byte ptr DS:[0x28E7],2
100D:A0F6 jne short 0xA103
100D:A0F8 test byte ptr DS:[SI+2],0x10
100D:A0FC je short 0xA104
100D:A104 jmp near 0x8C8A
100D:A1C4 mov byte ptr DS:[0x47A5],0xFF
100D:A1C9 ret near
100D:A1E2 cmp byte ptr DS:[0x47A5],0xFF
100D:A1E7 ret near
100D:A30B lods AL,byte ptr ES:[SI]
100D:A30D cmp AL,0x80
100D:A30F jae short 0xA32A
100D:A311 push BX
100D:A312 mov BL,byte ptr ES:[SI]
100D:A315 inc SI
100D:A316 xor BH,BH
100D:A318 cmp AL,1
100D:A31A je short 0xA322
100D:A31C mov AX,word ptr DS:[BX]
100D:A320 pop BX
100D:A321 ret near
100D:A322 mov AL,byte ptr DS:[BX]
100D:A326 xor AH,AH
100D:A328 pop BX
100D:A329 ret near
100D:A32A jne short 0xA331
100D:A32C lods AL,byte ptr ES:[SI]
100D:A32E xor AH,AH
100D:A330 ret near
100D:A331 lods AX,word ptr ES:[SI]
100D:A333 ret near
100D:A334 and BX,0x001F
100D:A337 jmp near word ptr CS:[BX-23690]
100D:A33F sub DX,AX
100D:A341 ret near
100D:A342 and DX,AX
100D:A344 ret near
100D:A348 cmp DX,AX
100D:A34A je short 0xA372
100D:A34C xor DX,DX
100D:A34E ret near
100D:A34F cmp DX,AX
100D:A351 jb short 0xA372
100D:A353 xor DX,DX
100D:A355 ret near
100D:A356 cmp DX,AX
100D:A358 ja short 0xA372
100D:A35A xor DX,DX
100D:A35C ret near
100D:A35D cmp DX,AX
100D:A35F jne short 0xA372
100D:A372 mov DX,0xFFFF
100D:A375 ret near
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
100D:A3B2 test AL,0x80
100D:A3B4 jne short 0xA3C0
100D:A3B6 mov BL,AL
100D:A3B8 call near 0xA30B
100D:A3BB call near 0xA334
100D:A3BE jmp short 0xA3AC
100D:A3C0 mov word ptr SS:[BP],DX
100D:A3C3 mov word ptr SS:[BP+2],AX
100D:A3C6 add BP,4
100D:A3C9 jmp short 0xA3A7
100D:A3CB mov SI,SP
100D:A3CD cmp SI,BP
100D:A3CF je short 0xA3E2
100D:A3D1 mov word ptr SS:[BP],DX
100D:A3D4 lods AX,word ptr DS:[SI]
100D:A3D5 mov DX,AX
100D:A3D7 lods AX,word ptr DS:[SI]
100D:A3D8 mov BX,AX
100D:A3DA lods AX,word ptr DS:[SI]
100D:A3DB call near 0xA334
100D:A3DE cmp SI,BP
100D:A3E0 jb short 0xA3D7
100D:A3E2 add SP,0x0032
100D:A3E5 or DX,DX
100D:A3E7 ret near
100D:A637 test word ptr DS:[0xDBC8],4
100D:A63D jne short 0xA644
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
100D:A6CC cmp BX,-1
100D:A6CF jne short 0xA6E6
100D:A6E6 push BX
100D:A6E7 cmp BL,0x0E
100D:A6EA jb short 0xA6EE
100D:A6EE and AH,0xF3
100D:A6F1 cmp byte ptr DS:[0x47DC],0
100D:A6F6 je short 0xA701
100D:A701 cmp byte ptr DS:[0x227D],0
100D:A706 jne short 0xA710
100D:A708 shl BX,1
100D:A70A sub AX,word ptr DS:[BX-10252]
100D:A70E shr BX,1
100D:A710 cmp BL,0x0E
100D:A713 jne short 0xA727
100D:A727 call near 0xA8BC
100D:A72A call near 0xA7A5
100D:A72D pop AX
100D:A72E call near 0x9123
100D:A731 shl AX,1
100D:A733 shl AX,1
100D:A735 shl AX,1
100D:A737 add AX,0x27FA
100D:A73A mov SI,AX
100D:A73C mov word ptr DS:[0xDC28],SI
100D:A740 mov byte ptr DS:[0xDC2A],0xFF
100D:A745 call near 0xA83F
100D:A748 jb short 0xA754
100D:A754 call near 0xADE0
100D:A757 call near 0xD617
100D:A75A stc
100D:A75B ret near
100D:A75C call near 0x9197
100D:A75F mov BP,0
100D:A762 mov SI,0xA7C2
100D:A765 call near 0xDA25
100D:A768 mov byte ptr DS:[0xDC2B],1
100D:A76D mov SI,0x3811
100D:A770 call far dword ptr DS:[0x3991]
100D:A774 mov AX,word ptr DS:[0xCE7A]
100D:A777 mov word ptr DS:[0xDC2C],AX
100D:A77A mov word ptr DS:[0xDC2E],0x8000
100D:A780 call near 0xA814
100D:A783 jae short 0xA788
100D:A785 call near 0xA82E
100D:A788 ret near
100D:A7A5 mov SI,0xA7C2
100D:A7A8 call near 0xDA5F
100D:A7AB mov word ptr DS:[0xDC26],0
100D:A7B1 call near 0xD61D
100D:A7B4 call near 0xABCC
100D:A7B7 je short 0xA788
100D:A7B9 call near 0xABC6
100D:A7BC call near 0xA9A1
100D:A7BF jmp near 0xADED
100D:A7C2 call near 0xABCC
100D:A7C5 je short 0xA788
100D:A7C7 cmp word ptr DS:[0xDC26],0
100D:A7CC jne short 0xA7D5
100D:A7D5 mov DX,word ptr DS:[0xCE7A]
100D:A7D9 xor DI,DI
100D:A7DB mov BX,word ptr DS:[0xDC2C]
100D:A7DF mov BP,word ptr DS:[0xDC2E]
100D:A7E3 mov CX,word ptr DS:[0x2882]
100D:A7E7 mov SI,word ptr DS:[0x2884]
100D:A7EB add BP,SI
100D:A7ED adc BX,CX
100D:A7EF sub DX,BX
100D:A7F1 js short 0xA811
100D:A7F3 push DI
100D:A7F4 call near 0xA814
100D:A7F7 pop DI
100D:A7F8 jae short 0xA789
100D:A7FA sub DI,SI
100D:A7FC sbb DX,CX
100D:A7FE jb short 0xA806
100D:A806 mov word ptr DS:[0xDC2C],BX
100D:A80A mov word ptr DS:[0xDC2E],BP
100D:A80E call near 0xA82E
100D:A811 jmp near 0xA9B9
100D:A814 mov DI,word ptr DS:[0xDC26]
100D:A818 or DI,DI
100D:A81A je short 0xA82D
100D:A81C mov ES,word ptr DS:[0x3813]
100D:A820 mov AL,byte ptr ES:[DI]
100D:A823 cmp AL,0xFF
100D:A825 jae short 0xA82D
100D:A827 inc DI
100D:A828 mov word ptr DS:[0xDC26],DI
100D:A82C stc
100D:A82D ret near
100D:A82E cmp AL,byte ptr DS:[0xDC2A]
100D:A832 je short 0xA83E
100D:A834 mov byte ptr DS:[0xDC2A],AL
100D:A837 mov SI,word ptr DS:[0xDC28]
100D:A83B jmp near 0x9DE3
100D:A83E ret near
100D:A83F mov word ptr DS:[0xDC26],0
100D:A845 call near 0xAE2F
100D:A848 je short 0xA87D
100D:A84A call near 0xAC14
100D:A84D call near 0xA90B
100D:A850 cmc
100D:A851 jae short 0xA87D
100D:A853 les DI,word ptr DS:[0x3811]
100D:A857 add DI,0x001A
100D:A85A cmp byte ptr ES:[DI],5
100D:A85E jne short 0xA871
100D:A860 mov CX,word ptr ES:[DI+1]
100D:A864 add DI,4
100D:A867 mov AX,DI
100D:A869 add AX,2
100D:A86C mov word ptr DS:[0xDC26],AX
100D:A86F add DI,CX
100D:A871 mov word ptr DS:[0x3811],DI
100D:A875 sub word ptr DS:[0x3815],DI
100D:A879 call near 0xA9B9
100D:A87C stc
100D:A87D ret near
100D:A87E pushf
100D:A87F sti
100D:A880 call near 0xAE2F
100D:A883 je short 0xA8AF
100D:A885 call near 0xAC14
100D:A888 mov AL,0x0B
100D:A88A call near 0xABE9
100D:A88D mov SI,0x3811
100D:A890 call far dword ptr DS:[0x3991]
100D:A894 push word ptr DS:[0xCE7A]
100D:A898 call near 0xA9E7
100D:A89B je short 0xA898
100D:A89D mov AX,word ptr DS:[0xCE7A]
100D:A8A0 pop BX
100D:A8A1 sub AX,BX
100D:A8A3 mov CX,0x0800
100D:A8A6 mul CX
100D:A8A8 mov word ptr DS:[0x2882],DX
100D:A8AC mov word ptr DS:[0x2884],AX
100D:A8AF popf
100D:A8B0 ret near
100D:A8B1 and AL,0x0F
100D:A8B3 add AL,0x30
100D:A8B5 cmp AL,0x39
100D:A8B7 jbe short 0xA8BB
100D:A8B9 add AL,7
100D:A8BB ret near
100D:A8BC mov DI,0x37DB
100D:A8BF push DS
100D:A8C0 pop ES
100D:A8C1 push AX
100D:A8C2 mov AL,BL
100D:A8C4 add AL,0x41
100D:A8C6 stos byte ptr ES:[DI],AL
100D:A8C7 inc DI
100D:A8C8 inc DI
100D:A8C9 stos byte ptr ES:[DI],AL
100D:A8CA pop BX
100D:A8CB mov CL,4
100D:A8CD mov AL,BH
100D:A8CF call near 0xA8B1
100D:A8D2 stos byte ptr ES:[DI],AL
100D:A8D3 mov AL,BL
100D:A8D5 shr AL,CL
100D:A8D7 call near 0xA8B1
100D:A8DA stos byte ptr ES:[DI],AL
100D:A8DB mov AL,BL
100D:A8DD call near 0xA8B1
100D:A8E0 stos byte ptr ES:[DI],AL
100D:A8E1 mov AL,0x4F
100D:A8E3 cmp byte ptr DS:[0x00EA],0
100D:A8E8 jg short 0xA8FA
100D:A8EA cmp byte ptr DS:[6],0x80
100D:A8EF jne short 0xA8FA
100D:A8F1 cmp byte ptr DS:[4],1
100D:A8F6 je short 0xA8FA
100D:A8F8 mov AL,0x49
100D:A8FA stos byte ptr ES:[DI],AL
100D:A8FB mov AL,0x20
100D:A8FD shr BH,CL
100D:A8FF or BH,byte ptr DS:[0x47E0]
100D:A903 je short 0xA909
100D:A909 stos byte ptr ES:[DI],AL
100D:A90A ret near
100D:A90B mov DX,0x37DA
100D:A90E xor AX,AX
100D:A910 mov word ptr DS:[0x3811],AX
100D:A913 mov word ptr DS:[0x3817],AX
100D:A916 mov word ptr DS:[0x381F],AX
100D:A919 mov byte ptr DS:[0x3823],AL
100D:A91C call near 0xF1FB
100D:A91F jb short 0xA90A
100D:A921 mov word ptr DS:[0x3821],BX
100D:A925 sub CX,1
100D:A928 sbb BP,0
100D:A92B mov word ptr DS:[0xDBC4],CX
100D:A92F mov word ptr DS:[0xDBC6],BP
100D:A933 mov word ptr DS:[0xDBC0],AX
100D:A936 mov word ptr DS:[0xDBC2],DX
100D:A93A mov SI,0x3811
100D:A93D les DX,word ptr DS:[SI]
100D:A93F push DX
100D:A940 mov DX,word ptr DS:[0xDBC0]
100D:A944 mov CX,word ptr DS:[0xDBC2]
100D:A948 mov AX,0x4200
100D:A94B int 0x21
100D:A94D pop DX
100D:A94E push SI
100D:A94F push DS
100D:A950 mov CX,0x2000
100D:A953 mov AX,word ptr DS:[0xDBC4]
100D:A956 sub word ptr DS:[0xDBC4],CX
100D:A95A sbb word ptr DS:[0xDBC6],0
100D:A95F jae short 0xA964
100D:A961 mov CX,AX
100D:A963 inc CX
100D:A964 push ES
100D:A965 pop DS
100D:A966 mov AH,0x3F
100D:A968 int 0x21
100D:A96A pop DS
100D:A96B pop SI
100D:A96C mov word ptr DS:[SI+4],AX
100D:A96F jb short 0xA9B8
100D:A971 add word ptr DS:[0xDBC0],AX
100D:A975 adc word ptr DS:[0xDBC2],0
100D:A97A mov byte ptr DS:[0x376A],0xFF
100D:A97F mov byte ptr DS:[SI+6],1
100D:A983 mov BL,byte ptr DS:[0x3823]
100D:A987 cmp BL,0x3F
100D:A98A jae short 0xA992
100D:A98C inc byte ptr DS:[0x3823]
100D:A990 inc BL
100D:A992 mov byte ptr DS:[SI+7],BL
100D:A995 cmp word ptr DS:[0xDBC6],0
100D:A99A clc
100D:A99B jns short 0xA9B8
100D:A99D or byte ptr DS:[SI+7],0x80
100D:A9A1 xor BX,BX
100D:A9A3 xchg BX,word ptr DS:[0x3821]
100D:A9A7 or BX,BX
100D:A9A9 je short 0xA9B7
100D:A9AB cmp BX,word ptr DS:[0xDBBA]
100D:A9AF je short 0xA9B7
100D:A9B7 clc
100D:A9B8 ret near
100D:A9B9 call near 0xABA3
100D:A9BC je short 0xA9E6
100D:A9BE mov SI,0x3811
100D:A9C1 cmp byte ptr DS:[0x3817],0
100D:A9C6 je short 0xA9D2
100D:A9C8 cmp byte ptr DS:[0x381F],0
100D:A9CD jne short 0xA9E6
100D:A9CF mov SI,0x3819
100D:A9D2 mov BX,word ptr DS:[0x3821]
100D:A9D6 les DX,word ptr DS:[SI]
100D:A9D8 add DX,6
100D:A9DB push SI
100D:A9DC call near 0xA93F
100D:A9DF pop SI
100D:A9E0 jb short 0xA9E6
100D:A9E2 call far dword ptr DS:[0x39A1]
100D:A9E6 ret near
100D:A9E7 cmp byte ptr DS:[0x3817],3
100D:A9EC je short 0xA9F3
100D:A9EE cmp byte ptr DS:[0x381F],3
100D:A9F3 ret near
100D:AA0E ret near
100D:AA0F mov AX,word ptr DS:[0xDC1C]
100D:AA12 inc AX
100D:AA13 je short 0xAA0E
100D:AA96 xor AX,AX
100D:AA98 cmp byte ptr DS:[0x4774],AH
100D:AA9C je short 0xAAA7
100D:AAA7 mov AL,0x0D
100D:AAA9 cmp byte ptr DS:[0x46D9],AH
100D:AAAD jne short 0xAB14
100D:AAAF mov AL,1
100D:AAB1 cmp byte ptr DS:[0xDD03],AH
100D:AAB5 jne short 0xAB14
100D:AAB7 inc AX
100D:AAB8 cmp byte ptr DS:[0x00FB],AH
100D:AABC js short 0xAB14
100D:AABE inc AX
100D:AABF cmp byte ptr DS:[0x00C6],AH
100D:AAC3 jne short 0xAB14
100D:AAC5 inc AX
100D:AAC6 cmp byte ptr DS:[0x00EA],AH
100D:AACA jg short 0xAB14
100D:AACC inc AX
100D:AACD mov DX,word ptr DS:[4]
100D:AAD1 mov BX,word ptr DS:[6]
100D:AAD5 cmp BL,0x80
100D:AAD8 jne short 0xAADF
100D:AADA cmp DL,1
100D:AADD jne short 0xAAEF
100D:AADF mov BL,byte ptr DS:[0x11C9]
100D:AAE3 and BL,3
100D:AAE6 je short 0xAB14
100D:AAE8 inc AX
100D:AAE9 dec BL
100D:AAEB je short 0xAB14
100D:AAEF cmp DH,0x20
100D:AAF2 jae short 0xAB08
100D:AAF4 mov AL,9
100D:AAF6 cmp DH,7
100D:AAF9 sbb AL,0
100D:AAFB cmp byte ptr DS:[0x002A],0x48
100D:AB00 jb short 0xAB14
100D:AB08 mov AL,0x0C
100D:AB0A jne short 0xAB14
100D:AB0C dec AX
100D:AB0D cmp DL,3
100D:AB10 jne short 0xAB14
100D:AB14 ret near
100D:AB15 call near 0xABCC
100D:AB18 jne short 0xAB44
100D:AB1A call near 0xAE2F
100D:AB1D je short 0xAB44
100D:AB1F push ES
100D:AB20 call near 0xE270
100D:AB23 cmp AL,byte ptr DS:[0x376A]
100D:AB27 je short 0xAB35
100D:AB29 call near 0xAC14
100D:AB2C or AL,AL
100D:AB2E je short 0xAB40
100D:AB30 call near 0xABE9
100D:AB33 jmp short 0xAB39
100D:AB39 mov SI,0x3811
100D:AB3C call far dword ptr DS:[0x3991]
100D:AB40 call near 0xE283
100D:AB43 pop ES
100D:AB44 ret near
100D:AB45 call near 0xAE2F
100D:AB48 je short 0xAB44
100D:AB4A push AX
100D:AB4B call near 0xADE0
100D:AB4E pop AX
100D:AB4F mov byte ptr DS:[0x47E0],0
100D:AB54 mov BX,0x0019
100D:AB57 call near 0xA8BC
100D:AB5A mov byte ptr DS:[0x37E2],0x49
100D:AB5F call near 0xABCC
100D:AB62 jne short 0xAB44
100D:AB64 call near 0xAE2F
100D:AB67 je short 0xAB44
100D:AB69 push ES
100D:AB6A call near 0xE270
100D:AB6D call near 0xAC14
100D:AB70 call near 0xA90B
100D:AB73 jb short 0xAB8D
100D:AB75 add word ptr DS:[0x3811],0x001A
100D:AB7A call near 0xA9B9
100D:AB7D mov SI,0xAB92
100D:AB80 mov BP,1
100D:AB83 call near 0xDA25
100D:AB86 mov SI,0x3811
100D:AB89 call far dword ptr DS:[0x3991]
100D:AB8D call near 0xE283
100D:AB90 pop ES
100D:AB91 ret near
100D:AB92 call near 0xA9B9
100D:AB95 call near 0xABA3
100D:AB98 jne short 0xAB44
100D:AB9A call near 0xADED
100D:AB9D mov SI,0xAB92
100D:ABA0 jmp near 0xDA5F
100D:ABA3 cmp word ptr DS:[0x3821],0
100D:ABA8 ret near
100D:ABA9 call near 0xAE2F
100D:ABAC je short 0xAB44
100D:ABAE mov BX,word ptr DS:[0xCE7A]
100D:ABB2 push BX
100D:ABB3 call near 0xAB92
100D:ABB6 call near 0xABA3
100D:ABB9 pop BX
100D:ABBA je short 0xABC6
100D:ABC6 mov byte ptr DS:[0xDC2B],0
100D:ABCB ret near
100D:ABCC cmp byte ptr DS:[0xDC2B],0
100D:ABD1 ret near
100D:ABD5 call near 0xABCC
100D:ABD8 jne short 0xABD2
100D:ABDA ret near
100D:ABE9 mov word ptr DS:[0x3811],0
100D:ABEF les DI,word ptr DS:[0x3811]
100D:ABF3 add word ptr DS:[0x3811],0x001A
100D:ABF8 xor AH,AH
100D:ABFA mov SI,AX
100D:ABFC add SI,0x00AE
100D:AC00 mov byte ptr DS:[0x376A],AL
100D:AC03 call near 0xF0B9
100D:AC06 sub CX,0x001A
100D:AC09 mov word ptr DS:[0x3815],CX
100D:AC0D mov word ptr DS:[0x3817],0x8101
100D:AC13 ret near
100D:AC14 push AX
100D:AC15 push BX
100D:AC16 push CX
100D:AC17 push SI
100D:AC18 push DI
100D:AC19 push BP
100D:AC1A push ES
100D:AC1B mov SI,0xAB92
100D:AC1E call near 0xDA5F
100D:AC21 call near 0xA9A1
100D:AC24 call far dword ptr DS:[0x3995]
100D:AC28 pop ES
100D:AC29 pop BP
100D:AC2A pop DI
100D:AC2B pop SI
100D:AC2C pop CX
100D:AC2D pop BX
100D:AC2E pop AX
100D:AC2F ret near
100D:AC30 call far dword ptr DS:[0x3999]
100D:AC34 ret near
100D:ACE6 call near 0xABCC
100D:ACE9 jne short 0xAD36
100D:ACEB test byte ptr DS:[0x3810],1
100D:ACF0 je short 0xAD37
100D:ACF2 cmp byte ptr DS:[0x227D],0
100D:ACF7 jne short 0xAD36
100D:AD36 ret near
100D:AD37 call near 0xAEC6
100D:AD3A jb short 0xAD36
100D:AD3C cmp byte ptr DS:[0xDBCD],0
100D:AD41 js short 0xAD36
100D:AD43 mov AL,byte ptr DS:[0xDBCC]
100D:AD46 mov byte ptr DS:[0xDBCB],0
100D:AD4B or AL,AL
100D:AD4D jne short 0xAD95
100D:AD57 call near 0xAEB7
100D:AD5A mov AL,6
100D:AD5C jmp short 0xAD95
100D:AD5E call near 0xAEC6
100D:AD61 jb short 0xAD74
100D:AD63 call near 0xAA96
100D:AD66 cmp byte ptr DS:[0x3810],0
100D:AD6B je short 0xAD75
100D:AD75 mov BX,0x375C
100D:AD78 xlat byte ptr DS:[BX+AL]
100D:AD79 or AL,AL
100D:AD7B je short 0xADBD
100D:AD7D or AL,AL
100D:AD7F js short 0xAD89
100D:AD81 mov byte ptr DS:[0xDBCC],AL
100D:AD84 call far dword ptr DS:[0x3979]
100D:AD88 ret near
100D:AD89 and AL,0x3F
100D:AD8B mov byte ptr DS:[0xDBCC],AL
100D:AD8E cmp AL,byte ptr DS:[0xDBCB]
100D:AD92 jne short 0xADBE
100D:AD94 ret near
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
100D:ADBE call near 0xAEC6
100D:ADC1 jb short 0xADBD
100D:ADC3 test byte ptr DS:[0x3810],1
100D:ADC8 jne short 0xADBD
100D:ADCA test byte ptr DS:[0xDBCD],0x40
100D:ADCF jne short 0xADBD
100D:ADD1 push BX
100D:ADD2 mov AX,0x012C
100D:ADD5 xor BX,BX
100D:ADD7 call far dword ptr DS:[0x397D]
100D:ADDB mov byte ptr DS:[0xDBCD],AL
100D:ADDE pop BX
100D:ADDF ret near
100D:ADE0 mov AX,0x0064
100D:ADE3 mov BL,byte ptr DS:[0x289E]
100D:ADE7 mov BH,byte ptr DS:[0x28B6]
100D:ADEB jmp short 0xADF8
100D:ADED mov AX,0x0190
100D:ADF0 mov BL,byte ptr DS:[0x2896]
100D:ADF4 mov BH,byte ptr DS:[0x28AE]
100D:ADF8 cmp BL,4
100D:ADFB jae short 0xADFF
100D:ADFF call far dword ptr DS:[0x397D]
100D:AE03 ret near
100D:AE04 call near 0xAEC6
100D:AE07 jb short 0xADBD
100D:AE09 test byte ptr DS:[0x3810],1
100D:AE0E jne short 0xADBD
100D:AE10 cmp byte ptr DS:[0xDBCD],0
100D:AE15 jns short 0xAE1E
100D:AE17 test byte ptr DS:[0xDBCD],0x40
100D:AE1C je short 0xADBD
100D:AE1E call near 0xE270
100D:AE21 call near 0xAD43
100D:AE24 call near 0xE283
100D:AE27 ret near
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
100D:AE59 mov DI,0x3811
100D:AE5C mov CX,0x4E20
100D:AE5F jmp near 0xF0F6
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
100D:B2BE mov byte ptr DS:[0x2788],0
100D:B2C3 ret near
100D:B389 add CL,0x31
100D:B38C mov byte ptr DS:[0x38AF],CL
100D:B390 call near 0xB427
100D:B393 mov AX,word ptr DS:[2]
100D:B396 push DS
100D:B397 push ES
100D:B398 pop DS
100D:B399 mov SI,DI
100D:B39B xor DI,DI
100D:B39D stos word ptr ES:[DI],AX
100D:B39E call near 0xB4EA
100D:B3A1 pop DS
100D:B3A2 mov DX,0x38A8
100D:B3A5 call near 0xF2FC
100D:B3A8 xor DI,DI
100D:B3AA add CX,2
100D:B3AD jmp near 0xF27C
100D:B427 mov CX,0x0578
100D:B42A call near 0xF11C
100D:B42D mov DI,0x0100
100D:B430 push DI
100D:B431 push ES
100D:B432 push DS
100D:B433 lds SI,word ptr DS:[0xDCFE]
100D:B437 xor SI,SI
100D:B439 mov CX,0xC5FC
100D:B43C shr CX,1
100D:B43E shr CX,1
100D:B440 mov AH,3
100D:B442 lods AL,byte ptr DS:[SI]
100D:B443 shl AL,1
100D:B445 shl AL,1
100D:B447 shl AX,1
100D:B449 shl AX,1
100D:B44B jae short 0xB442
100D:B44D mov AL,AH
100D:B44F stos byte ptr ES:[DI],AL
100D:B450 loop 0xB440
100D:B452 push CS
100D:B453 pop DS
100D:B454 mov SI,0x00AA
100D:B457 mov CX,0x00A2
100D:B45A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:B45C pop DS
100D:B45D mov SI,0xAA76
100D:B460 mov CX,0x11F8
100D:B463 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:B465 mov SI,0
100D:B468 mov CX,0x1261
100D:B46B rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:B46D pop ES
100D:B46E pop DI
100D:B46F mov CX,0x567A
100D:B472 ret near
100D:B4EA mov DL,0xF7
100D:B4EC push DI
100D:B4ED add DI,4
100D:B4F0 xor DH,DH
100D:B4F2 lods AL,byte ptr DS:[SI]
100D:B4F3 inc DH
100D:B4F5 cmp AL,byte ptr DS:[SI]
100D:B4F7 jne short 0xB504
100D:B4F9 cmp DH,0xFF
100D:B4FC je short 0xB504
100D:B4FE dec CX
100D:B4FF or CX,CX
100D:B501 jne short 0xB4F2
100D:B503 inc CX
100D:B504 cmp AL,DL
100D:B506 je short 0xB512
100D:B508 cmp DH,1
100D:B50B je short 0xB51C
100D:B50D cmp DH,2
100D:B510 je short 0xB52F
100D:B512 mov AH,AL
100D:B514 mov AL,DL
100D:B516 stos byte ptr ES:[DI],AL
100D:B517 mov AL,DH
100D:B519 stos byte ptr ES:[DI],AL
100D:B51A mov AL,AH
100D:B51C stos byte ptr ES:[DI],AL
100D:B51D loop 0xB4F0
100D:B51F mov CX,DI
100D:B521 xor AX,AX
100D:B523 stos word ptr ES:[DI],AX
100D:B524 pop DI
100D:B525 sub CX,DI
100D:B527 mov word ptr ES:[DI],DX
100D:B52A mov word ptr ES:[DI+2],CX
100D:B52E ret near
100D:B52F stos byte ptr ES:[DI],AL
100D:B530 jmp short 0xB51C
100D:B532 push DX
100D:B533 call near 0xB58B
100D:B536 pop DX
100D:B537 mov AL,byte ptr ES:[DI]
100D:B53A ret near
100D:B53B push BX
100D:B53C push CX
100D:B53D push DX
100D:B53E push AX
100D:B53F call near 0xB58B
100D:B542 pop AX
100D:B543 mov CX,AX
100D:B545 shr AX,1
100D:B547 sub DI,AX
100D:B549 sub DX,AX
100D:B54B jae short 0xB551
100D:B551 mov AL,byte ptr ES:[DI]
100D:B554 mov byte ptr DS:[SI],AL
100D:B556 mov word ptr DS:[SI+1],DI
100D:B559 add SI,3
100D:B55C inc DI
100D:B55D inc DX
100D:B55E cmp DX,BP
100D:B560 jb short 0xB566
100D:B566 loop 0xB551
100D:B568 pop DX
100D:B569 pop CX
100D:B56A pop BX
100D:B56B ret near
100D:B56C push CX
100D:B56D mov SI,CX
100D:B56F shr SI,1
100D:B571 sub BX,SI
100D:B573 cmp BX,-98
100D:B576 jge short 0xB57B
100D:B57B mov SI,0x9E68
100D:B57E push AX
100D:B57F call near 0xB53B
100D:B582 pop AX
100D:B583 inc BX
100D:B584 loop 0xB57E
100D:B586 mov SI,0x9E68
100D:B589 pop CX
100D:B58A ret near
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
100D:B647 xor CX,CX
100D:B649 test byte ptr DS:[0x46EB],0x80
100D:B64E je short 0xB652
100D:B652 mov BP,BX
100D:B654 sub BX,word ptr DS:[0x197E]
100D:B658 shl BX,CL
100D:B65A add BX,word ptr DS:[0xDCF8]
100D:B65E shl BP,1
100D:B660 shl BP,1
100D:B662 shl BP,1
100D:B664 jns short 0xB668
100D:B666 neg BP
100D:B668 mov BP,word ptr SS:[BP+0x494A]
100D:B66C add BP,BP
100D:B66E sub DX,word ptr DS:[0x197C]
100D:B672 mov AX,DX
100D:B674 imul BP
100D:B676 jcxz short 0xB67E
100D:B67E add DX,word ptr DS:[0xDCF6]
100D:B682 ret near
100D:B6C3 test byte ptr DS:[0x46EB],0x80
100D:B6C8 je short 0xB714
100D:B714 mov DI,0x4C60
100D:B717 mov AX,word ptr DS:[0x46E7]
100D:B71A sub AX,word ptr DS:[0x46E3]
100D:B71E mov DX,AX
100D:B720 shr DX,1
100D:B722 add DX,word ptr DS:[0x46E3]
100D:B726 mov word ptr DS:[0xDCF6],DX
100D:B72A mov word ptr DS:[0xDCF2],AX
100D:B72D mov AX,word ptr DS:[0x46E9]
100D:B730 sub AX,word ptr DS:[0x46E5]
100D:B734 dec AX
100D:B735 mov BX,AX
100D:B737 shr BX,1
100D:B739 add BX,word ptr DS:[0x46E5]
100D:B73D mov word ptr DS:[0xDCF8],BX
100D:B741 inc AX
100D:B742 mov word ptr DS:[0xDCF4],AX
100D:B745 dec AX
100D:B746 shr AX,1
100D:B748 mov CX,AX
100D:B74A mov BX,0x0056
100D:B74D sub BX,AX
100D:B74F mov AX,word ptr DS:[0x197E]
100D:B752 or AX,AX
100D:B754 mov DX,AX
100D:B756 jns short 0xB75A
100D:B758 neg AX
100D:B75A cmp AX,BX
100D:B75C jb short 0xB769
100D:B769 mov BP,0x4948
100D:B76C mov DX,word ptr DS:[0x197C]
100D:B770 mov AX,word ptr DS:[0x197E]
100D:B773 sub AX,CX
100D:B775 push AX
100D:B776 mov CX,word ptr DS:[0xDCF4]
100D:B77A shl AX,1
100D:B77C shl AX,1
100D:B77E shl AX,1
100D:B780 jns short 0xB79C
100D:B782 neg AX
100D:B784 add BP,AX
100D:B786 push CX
100D:B787 mov CX,word ptr SS:[BP]
100D:B78A mov BX,word ptr SS:[BP+2]
100D:B78D neg CX
100D:B78F je short 0xB7A5
100D:B791 call near 0xB7D2
100D:B794 sub BP,8
100D:B797 pop CX
100D:B798 loop 0xB786
100D:B79E push CX
100D:B79F mov CX,word ptr SS:[BP]
100D:B7A2 mov BX,word ptr SS:[BP+2]
100D:B7A5 call near 0xB7D2
100D:B7A8 add BP,8
100D:B7AB pop CX
100D:B7AC loop 0xB79E
100D:B7AE mov ES,word ptr DS:[0xDBDA]
100D:B7B2 mov DI,word ptr DS:[0xDCF2]
100D:B7B6 mov CX,word ptr DS:[0xDCF4]
100D:B7BA mov DX,word ptr DS:[0x46E3]
100D:B7BE mov BX,word ptr DS:[0x46E5]
100D:B7C2 mov SI,0x4C60
100D:B7C5 pop AX
100D:B7C6 test byte ptr DS:[0x46EB],0x40
100D:B7CB jne short 0xB7D1
100D:B7CD call far dword ptr DS:[0x390D]
100D:B7D1 ret near
100D:B7D2 push DX
100D:B7D3 push DI
100D:B7D4 push DS
100D:B7D5 lds SI,word ptr DS:[0xDCFE]
100D:B7D9 push SS
100D:B7DA pop ES
100D:B7DB add SI,CX
100D:B7DD add BX,BX
100D:B7DF mov AX,DX
100D:B7E1 mul BX
100D:B7E3 mov word ptr SS:[BP+6],DX
100D:B7E6 mov AX,DX
100D:B7E8 mov DX,word ptr SS:[0xDCF2]
100D:B7ED cmp BX,DX
100D:B7EF jae short 0xB7FB
100D:B7FB mov CX,DX
100D:B7FD shr CX,1
100D:B7FF sub AX,CX
100D:B801 jns short 0xB805
100D:B803 add AX,BX
100D:B805 mov CX,DX
100D:B807 sub BX,AX
100D:B809 sub CX,BX
100D:B80B jns short 0xB813
100D:B813 xchg BX,CX
100D:B815 push SI
100D:B816 add SI,AX
100D:B818 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:B81A pop SI
100D:B81B xchg BX,CX
100D:B81D rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:B81F pop DS
100D:B820 pop DI
100D:B821 pop DX
100D:B822 add DI,0x00C8
100D:B826 ret near
100D:B930 mov byte ptr DS:[0xDD03],0
100D:B935 mov SI,0xB9AE
100D:B938 call near 0xDA5F
100D:B93B mov SI,0xBE57
100D:B93E jmp near 0xDA5F
100D:BF26 mov DI,0x115E
100D:BF29 mov BP,0x116A
100D:BF2C mov SI,0x00C4
100D:BF2F call near 0xCF70
100D:BF32 mov AX,word ptr DS:[0x00A4]
100D:BF35 call near 0xBF73
100D:BF38 mov AX,word ptr DS:[0x00A2]
100D:BF3B call near 0xBF73
100D:BF3E mov AX,word ptr DS:[0x00A8]
100D:BF41 call near 0xBF61
100D:BF44 mov AX,word ptr DS:[0x00A6]
100D:BF47 call near 0xBF61
100D:BF4A mov AX,word ptr DS:[0x00AC]
100D:BF4D call near 0xBF61
100D:BF50 mov AX,word ptr DS:[0x00AA]
100D:BF53 jmp short 0xBF61
100D:BF61 push DI
100D:BF62 push AX
100D:BF63 call near 0xD03C
100D:BF66 dec SI
100D:BF67 mov byte ptr ES:[SI],0x30
100D:BF6B pop AX
100D:BF6C push AX
100D:BF6D call near 0xE31C
100D:BF70 inc SI
100D:BF71 jmp short 0xBF7D
100D:BF73 push DI
100D:BF74 push AX
100D:BF75 call near 0xD03C
100D:BF78 pop AX
100D:BF79 push AX
100D:BF7A call near 0xE2E3
100D:BF7D pop AX
100D:BF7E pop DI
100D:BF7F mov DX,AX
100D:BF81 xchg AX,word ptr DS:[DI]
100D:BF83 cmp DX,AX
100D:BF85 mov AL,3
100D:BF87 jne short 0xBF99
100D:BF89 mov AX,word ptr DS:[2]
100D:BF8C and AX,0xFFF0
100D:BF8F cmp word ptr DS:[0x115C],AX
100D:BF93 je short 0xBFA2
100D:BF95 mov AL,3
100D:BF97 jmp short 0xBF9F
100D:BF99 mov AL,2
100D:BF9B jb short 0xBF9F
100D:BF9D dec AL
100D:BF9F mov byte ptr SS:[BP],AL
100D:BFA2 add DI,2
100D:BFA5 inc BP
100D:BFA6 ret near
100D:BFE3 push DS
100D:BFE4 xor BX,BX
100D:BFE6 xor DX,DX
100D:BFE8 mov CX,0xC5F9
100D:BFEB xor SI,SI
100D:BFED mov DS,word ptr DS:[0xDD00]
100D:BFF1 lods AL,byte ptr DS:[SI]
100D:BFF2 and AL,0x30
100D:BFF4 je short 0xBFFC
100D:BFF6 inc DX
100D:BFF7 cmp AL,0x30
100D:BFF9 je short 0xBFFC
100D:BFFB inc BX
100D:BFFC loop 0xBFF1
100D:BFFE sub DX,BX
100D:C000 xor AX,AX
100D:C002 sub SI,0x0188
100D:C006 inc SI
100D:C007 div SI
100D:C009 mov DX,0x0064
100D:C00C mul DX
100D:C00E add AX,AX
100D:C010 adc DX,0
100D:C013 xchg DX,BX
100D:C015 xor AX,AX
100D:C017 div SI
100D:C019 mov DX,0x0064
100D:C01C mul DX
100D:C01E add AX,AX
100D:C020 adc DX,0
100D:C023 inc DX
100D:C024 pop DS
100D:C025 mov word ptr DS:[0x00A2],DX
100D:C029 mov word ptr DS:[0x00A4],BX
100D:C02D ret near
100D:C02E call near 0xBFE3
100D:C031 mov AX,word ptr DS:[0x00A0]
100D:C034 add AX,word ptr DS:[0x1172]
100D:C038 sub AX,word ptr DS:[0x1170]
100D:C03C jae short 0xC040
100D:C040 cmp AX,word ptr DS:[0x00A6]
100D:C044 jb short 0xC049
100D:C046 mov word ptr DS:[0x00A6],AX
100D:C049 xor AX,AX
100D:C04B mov word ptr DS:[0x00AA],AX
100D:C04E mov word ptr DS:[0x00AC],AX
100D:C051 mov SI,0x08AA
100D:C054 mov AL,byte ptr DS:[SI+0x1A]
100D:C057 test byte ptr DS:[SI+3],0x20
100D:C05B jne short 0xC073
100D:C05D test byte ptr DS:[SI+0x10],0x80
100D:C061 je short 0xC069
100D:C063 add word ptr DS:[0x00AC],AX
100D:C067 jmp short 0xC073
100D:C069 test byte ptr DS:[SI+3],0x80
100D:C06D jne short 0xC073
100D:C073 add SI,0x001B
100D:C076 cmp byte ptr DS:[SI],0
100D:C079 jne short 0xC054
100D:C07B ret near
100D:C07C push word ptr DS:[0xDBD6]
100D:C080 pop word ptr DS:[0xDBDA]
100D:C084 ret near
100D:C085 push word ptr DS:[0xDC32]
100D:C089 pop word ptr DS:[0xDBDA]
100D:C08D ret near
100D:C08E push word ptr DS:[0xDBD8]
100D:C092 pop word ptr DS:[0xDBDA]
100D:C096 ret near
100D:C097 call near 0xC07C
100D:C09A push word ptr DS:[0xDBD8]
100D:C09E push word ptr DS:[0xDBD6]
100D:C0A2 pop word ptr DS:[0xDBD8]
100D:C0A6 call near BP
100D:C0A8 pop word ptr DS:[0xDBD8]
100D:C0AC ret near
100D:C0AD mov ES,word ptr DS:[0xDBDA]
100D:C0B1 call far dword ptr DS:[0x38D5]
100D:C0B5 ret near
100D:C0D5 push DS
100D:C0D6 mov ES,word ptr DS:[0xDBD8]
100D:C0DA mov DS,word ptr DS:[0xDBD6]
100D:C0DE mov BP,0xCE7A
100D:C0E1 call far dword ptr SS:[0x392D]
100D:C0E6 pop DS
100D:C0E7 ret near
100D:C0F4 mov AX,word ptr DS:[0xDBD6]
100D:C0F7 cmp AX,word ptr DS:[0xDBD8]
100D:C0FB je short 0xC101
100D:C0FD call far dword ptr DS:[0x3935]
100D:C101 ret near
100D:C108 mov byte ptr DS:[0xDCE6],0x80
100D:C10D push AX
100D:C10E push DX
100D:C10F call near 0xC097
100D:C112 pop DX
100D:C113 pop AX
100D:C114 push DS
100D:C115 mov SI,word ptr DS:[0xDBDE]
100D:C119 mov ES,word ptr DS:[0xDBD8]
100D:C11D mov DS,word ptr DS:[0xDBD6]
100D:C121 mov BP,0xCE7A
100D:C124 call far dword ptr SS:[0x3921]
100D:C129 pop DS
100D:C12A call near 0xC4CD
100D:C12D call far dword ptr DS:[0x3935]
100D:C131 mov byte ptr DS:[0xDCE6],0
100D:C136 ret near
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
100D:C16D cmp DI,2
100D:C170 jbe short 0xC19E
100D:C172 call near 0xC1AA
100D:C175 jmp short 0xC19E
100D:C177 push CX
100D:C178 push DX
100D:C179 push BP
100D:C17A push SI
100D:C17B mov SI,AX
100D:C17D call near 0xF0B9
100D:C180 cmp word ptr ES:[DI],2
100D:C184 jbe short 0xC189
100D:C186 call near 0xC1AA
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
100D:C1AA mov AX,word ptr DS:[0x2784]
100D:C1AD mov AH,AL
100D:C1AF xchg AL,byte ptr DS:[0xDBB4]
100D:C1B3 cmp AL,AH
100D:C1B5 je short 0xC1A9
100D:C1B7 mov SI,2
100D:C1BA push CX
100D:C1BB push DX
100D:C1BC push DI
100D:C1BD lods AX,word ptr ES:[SI]
100D:C1BF cmp AX,0x0100
100D:C1C2 jne short 0xC1C9
100D:C1C4 add SI,3
100D:C1C7 jmp short 0xC1BD
100D:C1C9 mov BX,AX
100D:C1CB inc AX
100D:C1CC je short 0xC1F0
100D:C1CE mov CL,BH
100D:C1D0 xor BH,BH
100D:C1D2 and CX,0x00FF
100D:C1D6 jne short 0xC1DA
100D:C1DA mov AX,BX
100D:C1DC add BX,BX
100D:C1DE add BX,AX
100D:C1E0 mov AX,CX
100D:C1E2 add CX,CX
100D:C1E4 add CX,AX
100D:C1E6 mov DX,SI
100D:C1E8 add SI,CX
100D:C1EA call far dword ptr DS:[0x38BD]
100D:C1EE jmp short 0xC1BD
100D:C1F0 pop DI
100D:C1F1 pop DX
100D:C1F2 pop CX
100D:C1F3 ret near
100D:C1F4 push BX
100D:C1F5 les SI,word ptr DS:[0xDBB0]
100D:C1F9 mov BX,AX
100D:C1FB shl BX,1
100D:C1FD add SI,word ptr ES:[BX+SI]
100D:C200 pop BX
100D:C201 ret near
100D:C21B lods AX,word ptr DS:[SI]
100D:C21C cmp AX,0xFFFF
100D:C21F je short 0xC26A
100D:C221 mov BX,AX
100D:C223 lods AX,word ptr DS:[SI]
100D:C224 mov DX,AX
100D:C226 lods AX,word ptr DS:[SI]
100D:C227 xchg BX,AX
100D:C228 push SI
100D:C229 call near 0xC22F
100D:C22C pop SI
100D:C22D jmp short 0xC21B
100D:C22F mov ES,word ptr DS:[0xDBDA]
100D:C233 lds SI,word ptr DS:[0xDBB0]
100D:C237 mov BP,AX
100D:C239 and BP,0x01FF
100D:C23D shl BP,1
100D:C23F add SI,word ptr DS:[BP+SI]
100D:C242 mov CX,AX
100D:C244 push AX
100D:C245 lods AX,word ptr DS:[SI]
100D:C246 and CH,0x60
100D:C249 or AH,CH
100D:C24B mov DI,AX
100D:C24D lods AX,word ptr DS:[SI]
100D:C24E mov CX,AX
100D:C250 cmp byte ptr CS:[0xC21A],0
100D:C256 je short 0xC25D
100D:C258 mov CH,byte ptr CS:[0xC21A]
100D:C25D pop AX
100D:C25E and AX,0x1C00
100D:C261 jne short 0xC26B
100D:C263 call far dword ptr SS:[0x38C9]
100D:C268 push SS
100D:C269 pop DS
100D:C26A ret near
100D:C26B xchg AH,AL
100D:C26D mov BP,AX
100D:C26F shr BP,1
100D:C271 mov BP,word ptr SS:[BP+0x2774]
100D:C275 mov AX,DI
100D:C277 and AX,0x01FF
100D:C27A push DX
100D:C27B xchg AH,AL
100D:C27D xor DX,DX
100D:C27F div BP
100D:C281 pop DX
100D:C282 push AX
100D:C283 mov AX,CX
100D:C285 xor AH,AH
100D:C287 push DX
100D:C288 xchg AH,AL
100D:C28A xor DX,DX
100D:C28C div BP
100D:C28E pop DX
100D:C28F mov CL,AL
100D:C291 pop AX
100D:C292 or DI,DI
100D:C294 jns short 0xC299
100D:C296 call near 0xC2A1
100D:C299 call far dword ptr SS:[0x3941]
100D:C29E push SS
100D:C29F pop DS
100D:C2A0 ret near
100D:C2A1 push AX
100D:C2A2 push BX
100D:C2A3 push CX
100D:C2A4 push DI
100D:C2A5 push ES
100D:C2A6 push BP
100D:C2A7 push SS
100D:C2A8 pop ES
100D:C2A9 mov BP,DI
100D:C2AB mov DI,0x4C60
100D:C2AE and BP,0x01FF
100D:C2B2 add BP,3
100D:C2B5 shr BP,1
100D:C2B7 shr BP,1
100D:C2B9 shl BP,1
100D:C2BB mov CX,word ptr DS:[SI-2]
100D:C2BE xor CH,CH
100D:C2C0 push CX
100D:C2C1 mov BX,BP
100D:C2C3 lods AL,byte ptr DS:[SI]
100D:C2C4 test AL,0x80
100D:C2C6 jne short 0xC2D6
100D:C2C8 mov CL,1
100D:C2CA add CL,AL
100D:C2CC xor CH,CH
100D:C2CE sub BX,CX
100D:C2D0 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
100D:C2D2 jne short 0xC2C3
100D:C2D4 jmp short 0xC2E3
100D:C2D6 mov CL,1
100D:C2D8 sub CL,AL
100D:C2DA xor CH,CH
100D:C2DC sub BX,CX
100D:C2DE lods AL,byte ptr DS:[SI]
100D:C2DF rep stos byte ptr ES:[DI],AL
100D:C2E1 jne short 0xC2C3
100D:C2E3 pop CX
100D:C2E4 loop 0xC2C0
100D:C2E6 mov SI,0x4C60
100D:C2E9 push SS
100D:C2EA pop DS
100D:C2EB pop BP
100D:C2EC pop ES
100D:C2ED pop DI
100D:C2EE pop CX
100D:C2EF pop BX
100D:C2F0 pop AX
100D:C2F1 ret near
100D:C2F2 xor AH,AH
100D:C2F4 call near 0xC13E
100D:C2F7 xor AX,AX
100D:C2F9 xor BX,BX
100D:C2FB xor DX,DX
100D:C2FD push BX
100D:C2FE push DX
100D:C2FF call near 0xC22F
100D:C302 pop DX
100D:C303 pop BX
100D:C304 ret near
100D:C305 push BX
100D:C306 push DX
100D:C307 call near 0xC30D
100D:C30A pop DX
100D:C30B pop BX
100D:C30C ret near
100D:C30D mov ES,word ptr DS:[0xDBDA]
100D:C311 lds SI,word ptr DS:[0xDBB0]
100D:C315 mov BP,AX
100D:C317 shl BP,1
100D:C319 add SI,word ptr DS:[BP+SI]
100D:C31C lods AX,word ptr DS:[SI]
100D:C31D mov DI,AX
100D:C31F lods AX,word ptr DS:[SI]
100D:C320 xor AH,AH
100D:C322 mov CX,AX
100D:C324 mov BP,0xD834
100D:C327 call far dword ptr SS:[0x38CD]
100D:C32C push SS
100D:C32D pop DS
100D:C32E ret near
100D:C343 mov ES,word ptr DS:[0xDBDA]
100D:C347 lds SI,word ptr DS:[0xDBB0]
100D:C34B mov BP,AX
100D:C34D shl BP,1
100D:C34F add SI,word ptr DS:[BP+SI]
100D:C352 lods AX,word ptr DS:[SI]
100D:C353 mov DI,AX
100D:C355 and AH,0x0F
100D:C358 shr AX,1
100D:C35A sub DX,AX
100D:C35C lods AX,word ptr DS:[SI]
100D:C35D xor AH,AH
100D:C35F mov CX,AX
100D:C361 shr AX,1
100D:C363 sub BX,AX
100D:C365 mov BP,0xD834
100D:C368 call far dword ptr SS:[0x38CD]
100D:C36D push SS
100D:C36E pop DS
100D:C36F ret near
100D:C412 push DS
100D:C413 mov ES,word ptr DS:[0xDBDE]
100D:C417 mov DS,word ptr DS:[0xDBDA]
100D:C41B call far dword ptr SS:[0x38E1]
100D:C420 pop DS
100D:C421 ret near
100D:C432 mov SI,0x1470
100D:C435 mov ES,word ptr DS:[0xDBDA]
100D:C439 call far dword ptr DS:[0x38D9]
100D:C43D ret near
100D:C43E mov SI,0x1470
100D:C441 jmp short 0xC446
100D:C446 mov AX,word ptr DS:[0xDBDE]
100D:C449 push CX
100D:C44A mov CX,AX
100D:C44C mov DX,word ptr DS:[SI]
100D:C44E mov BX,word ptr DS:[SI+2]
100D:C451 mov BP,word ptr DS:[SI+4]
100D:C454 mov AX,word ptr DS:[SI+6]
100D:C457 sub BP,DX
100D:C459 jbe short 0xC46D
100D:C45B sub AX,BX
100D:C45D jbe short 0xC46D
100D:C45F mov ES,word ptr DS:[0xDBD6]
100D:C463 push SI
100D:C464 push DS
100D:C465 mov SI,CX
100D:C467 call far dword ptr DS:[0x38ED]
100D:C46B pop DS
100D:C46C pop SI
100D:C46D pop CX
100D:C46E ret near
100D:C46F mov AX,word ptr DS:[0xDC32]
100D:C472 jmp short 0xC449
100D:C474 mov SI,0x1470
100D:C477 mov DX,word ptr DS:[SI]
100D:C479 mov BX,word ptr DS:[SI+2]
100D:C47C mov BP,word ptr DS:[SI+4]
100D:C47F mov AX,word ptr DS:[SI+6]
100D:C482 sub BP,DX
100D:C484 jbe short 0xC499
100D:C486 sub AX,BX
100D:C488 jbe short 0xC499
100D:C48A mov ES,word ptr DS:[0xDBDE]
100D:C48E push DS
100D:C48F mov DS,word ptr DS:[0xDBD6]
100D:C493 call far dword ptr SS:[0x38E5]
100D:C498 pop DS
100D:C499 ret near
100D:C4AA mov DX,word ptr DS:[SI]
100D:C4AC mov BX,word ptr DS:[SI+2]
100D:C4AF mov BP,word ptr DS:[SI+4]
100D:C4B2 mov AX,word ptr DS:[SI+6]
100D:C4B5 sub BP,DX
100D:C4B7 jbe short 0xC4CC
100D:C4B9 sub AX,BX
100D:C4BB jbe short 0xC4CC
100D:C4BD push DS
100D:C4BE mov ES,word ptr DS:[0xDBD6]
100D:C4C2 mov DS,word ptr DS:[0xDBD8]
100D:C4C6 call far dword ptr SS:[0x38F5]
100D:C4CB pop DS
100D:C4CC ret near
100D:C4CD push DS
100D:C4CE mov ES,word ptr DS:[0xDBD8]
100D:C4D2 mov DS,word ptr DS:[0xDBD6]
100D:C4D6 call far dword ptr SS:[0x38F1]
100D:C4DB pop DS
100D:C4DC ret near
100D:C4DD mov AX,word ptr DS:[0xDC38]
100D:C4E0 cmp AX,0x0098
100D:C4E3 jae short 0xC4E8
100D:C4E5 call near 0xDBB2
100D:C4E8 mov SI,0x1470
100D:C4EB jmp short 0xC4F0
100D:C4F0 mov DX,word ptr DS:[SI]
100D:C4F2 mov BX,word ptr DS:[SI+2]
100D:C4F5 mov BP,word ptr DS:[SI+4]
100D:C4F8 mov AX,word ptr DS:[SI+6]
100D:C4FB cmp byte ptr DS:[0x227D],0
100D:C500 jne short 0xC51E
100D:C502 cmp AX,0x0089
100D:C505 jl short 0xC51E
100D:C507 cmp BP,0x007E
100D:C50B jl short 0xC51E
100D:C50D cmp DX,0x00C2
100D:C511 jge short 0xC51E
100D:C513 push AX
100D:C514 push BX
100D:C515 push DX
100D:C516 push BP
100D:C517 call near 0x1797
100D:C51A pop BP
100D:C51B pop DX
100D:C51C pop BX
100D:C51D pop AX
100D:C51E sub BP,DX
100D:C520 jbe short 0xC53D
100D:C522 sub AX,BX
100D:C524 jbe short 0xC53D
100D:C526 cmp word ptr DS:[0x2570],0x1AD6
100D:C52C je short 0xC53D
100D:C52E push DS
100D:C52F mov ES,word ptr DS:[0xDBD8]
100D:C533 mov DS,word ptr DS:[0xDBD6]
100D:C537 call far dword ptr SS:[0x38F5]
100D:C53C pop DS
100D:C53D ret near
100D:C53E mov SI,0x276A
100D:C541 mov BP,word ptr DS:[0x2772]
100D:C545 mov AL,byte ptr DS:[0xDBE4]
100D:C548 mov ES,word ptr DS:[0xDBDA]
100D:C54C call far dword ptr DS:[0x3901]
100D:C550 ret near
100D:C560 mov byte ptr DS:[0xDBE4],AL
100D:C563 push BX
100D:C564 push CX
100D:C565 push DX
100D:C566 push DI
100D:C567 mov CX,BX
100D:C569 call near 0xC53E
100D:C56C mov BP,SP
100D:C56E mov CX,word ptr SS:[BP+4]
100D:C571 mov BX,CX
100D:C573 call near 0xC53E
100D:C576 mov BP,SP
100D:C578 mov DI,DX
100D:C57A mov BX,word ptr SS:[BP+6]
100D:C57D call near 0xC53E
100D:C580 pop DI
100D:C581 mov DX,DI
100D:C583 call near 0xC53E
100D:C586 pop DX
100D:C587 pop CX
100D:C588 pop BX
100D:C589 ret near
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
100D:C9F4 push word ptr DS:[0xDBE8]
100D:C9F8 call near 0xCA60
100D:C9FB pop AX
100D:C9FC cmp AX,word ptr DS:[0xDBE8]
100D:CA00 ret near
100D:CA01 xor BX,BX
100D:CA03 xchg BX,word ptr DS:[0x35A6]
100D:CA07 or BX,BX
100D:CA09 je short 0xCA18
100D:CA0B call near 0xCE01
100D:CA0E cmp BX,word ptr DS:[0xDBBA]
100D:CA12 je short 0xCA18
100D:CA18 xor CX,CX
100D:CA1A ret near
100D:CA1B call near 0xC92B
100D:CA1E jb short 0xCA01
100D:CA20 call near 0xCDA0
100D:CA23 jb short 0xCA01
100D:CA25 mov byte ptr DS:[0xDCE6],0
100D:CA2A les SI,word ptr DS:[0xDC10]
100D:CA2E lods AX,word ptr ES:[SI]
100D:CA30 mov BP,word ptr DS:[0xDBDE]
100D:CA34 call near 0xCCF4
100D:CA37 call near 0xAA0F
100D:CA3A call near 0xCC96
100D:CA3D call near 0xCE1A
100D:CA40 inc word ptr DS:[0xDBE8]
100D:CA44 inc word ptr DS:[0xDBEA]
100D:CA48 test byte ptr DS:[0xDBFE],0x40
100D:CA4D jne short 0xCA59
100D:CA4F mov CX,0x0032
100D:CA52 push CX
100D:CA53 call near 0xCB1A
100D:CA56 pop CX
100D:CA57 loop 0xCA52
100D:CA59 mov AX,word ptr DS:[0xCE7A]
100D:CA5C mov word ptr DS:[0xDC22],AX
100D:CA5F ret near
100D:CA60 cmp word ptr DS:[0x35A6],0
100D:CA65 je short 0xCA9A
100D:CA67 cmp byte ptr DS:[0xDBFE],0
100D:CA6C jns short 0xCA71
100D:CA6E call near 0xCA8F
100D:CA71 call near 0xCAA0
100D:CA74 jae short 0xCA7B
100D:CA7B call near 0xCAD4
100D:CA7E jb short 0xCA8F
100D:CA80 mov AX,word ptr DS:[0xDC1E]
100D:CA83 inc AX
100D:CA84 je short 0xCA89
100D:CA89 call near 0xCC96
100D:CA8C call near 0xCC4E
100D:CA8F mov AL,byte ptr DS:[0xDBFE]
100D:CA92 and AL,0x80
100D:CA94 mov byte ptr DS:[0xDBB5],AL
100D:CA97 call near 0xCB1A
100D:CA9A mov byte ptr DS:[0xDBB5],0
100D:CA9F ret near
100D:CAA0 cmp word ptr DS:[0xDC16],0
100D:CAA5 ja short 0xCAD3
100D:CAA7 mov CX,word ptr DS:[0xDC1A]
100D:CAAB stc
100D:CAAC jcxz short 0xCAD3
100D:CAAE les SI,word ptr DS:[0xDC10]
100D:CAB2 lods AX,word ptr ES:[SI]
100D:CAB4 cmp word ptr ES:[SI],0x6D6D
100D:CAB9 je short 0xCABF
100D:CABB cmp CX,AX
100D:CABD jb short 0xCAD3
100D:CABF mov BP,word ptr DS:[0xDBD6]
100D:CAC3 test byte ptr DS:[0xDBFE],0x40
100D:CAC8 je short 0xCACE
100D:CACE call near 0xCCF4
100D:CAD1 xor AX,AX
100D:CAD3 ret near
100D:CAD4 mov AX,word ptr DS:[0xDC1C]
100D:CAD7 inc AX
100D:CAD8 jne short 0xCAF0
100D:CADA mov AX,word ptr DS:[0xCE7A]
100D:CADD sub AX,word ptr DS:[0xDC22]
100D:CAE1 or AH,AH
100D:CAE3 jne short 0xCAEB
100D:CAE5 cmp AL,byte ptr DS:[0xDBFF]
100D:CAE9 jb short 0xCAEF
100D:CAEB call near 0xCA59
100D:CAEE clc
100D:CAEF ret near
100D:CB00 mov AX,word ptr DS:[0xDBEA]
100D:CB03 cmp AX,word ptr DS:[0xDBEE]
100D:CB07 je short 0xCB61
100D:CB09 mov AX,word ptr DS:[0xDC08]
100D:CB0C or AX,word ptr DS:[0xDC0A]
100D:CB10 je short 0xCB61
100D:CB12 call near 0xCD8F
100D:CB15 jb short 0xCB44
100D:CB17 call near 0xCC0C
100D:CB1A mov CX,word ptr DS:[0xDC20]
100D:CB1E jcxz short 0xCB00
100D:CB20 cmp byte ptr DS:[0xDBFE],0
100D:CB25 js short 0xCB38
100D:CB27 mov AX,word ptr DS:[0xDC04]
100D:CB2A neg AX
100D:CB2C and AX,0x07FF
100D:CB2F add AH,8
100D:CB32 cmp AX,CX
100D:CB34 jae short 0xCB38
100D:CB36 mov CX,AX
100D:CB38 call near 0xCC2B
100D:CB3B jb short 0xCB44
100D:CB3D sub word ptr DS:[0xDC20],CX
100D:CB41 jmp near 0xCDBF
100D:CB44 ret near
100D:CC0C add SI,AX
100D:CC0E jb short 0xCC16
100D:CC10 cmp SI,word ptr DS:[0xCE74]
100D:CC14 jbe short 0xCC20
100D:CC16 xor CX,CX
100D:CC18 xchg CX,word ptr DS:[0xDC0C]
100D:CC1C mov word ptr DS:[0xDC18],CX
100D:CC20 sub AX,2
100D:CC23 mov word ptr DS:[0xDC20],AX
100D:CC26 inc word ptr DS:[0xDBEA]
100D:CC2A ret near
100D:CC2B mov AX,word ptr DS:[0xDC0C]
100D:CC2E mov BX,word ptr DS:[0xDC10]
100D:CC32 cmp AX,BX
100D:CC34 jae short 0xCC3F
100D:CC36 add AX,CX
100D:CC38 add AX,0x0012
100D:CC3B cmp BX,AX
100D:CC3D jb short 0xCC4D
100D:CC3F mov AX,word ptr DS:[0xDC1A]
100D:CC42 add AX,0x000A
100D:CC45 add AX,CX
100D:CC47 jb short 0xCC4D
100D:CC49 cmp word ptr DS:[0xDC18],AX
100D:CC4D ret near
100D:CC4E les SI,word ptr DS:[0xDC10]
100D:CC52 lods AX,word ptr ES:[SI]
100D:CC54 sub word ptr DS:[0xDC1A],AX
100D:CC58 add SI,AX
100D:CC5A jb short 0xCC62
100D:CC5C cmp SI,word ptr DS:[0xCE74]
100D:CC60 jbe short 0xCC6A
100D:CC62 sub AX,2
100D:CC65 mov word ptr DS:[0xDC10],AX
100D:CC68 xor AX,AX
100D:CC6A add word ptr DS:[0xDC10],AX
100D:CC6E mov AX,word ptr DS:[0xDBE8]
100D:CC71 inc AX
100D:CC72 cmp AX,word ptr DS:[0xDBEC]
100D:CC76 jbe short 0xCC81
100D:CC81 mov word ptr DS:[0xDBE8],AX
100D:CC84 ret near
100D:CC85 cmp byte ptr DS:[0xDBE7],0
100D:CC8A je short 0xCC91
100D:CC91 ret near
100D:CC96 mov AX,word ptr DS:[0x38FB]
100D:CC99 mov word ptr CS:[0xCC94],AX
100D:CC9D xor BP,BP
100D:CC9F xchg BP,word ptr DS:[0xDC16]
100D:CCA3 or BP,BP
100D:CCA5 je short 0xCC4D
100D:CCA7 mov SI,word ptr DS:[0xDC14]
100D:CCAB mov AL,byte ptr DS:[0xDBFE]
100D:CCAE test AL,0x30
100D:CCB0 jne short 0xCCEA
100D:CCB2 push DS
100D:CCB3 test word ptr DS:[0xDC24],0x0400
100D:CCB9 jne short 0xCCE1
100D:CCE1 pop DS
100D:CCE2 ret near
100D:CCEA test AL,0x20
100D:CCEC jne short 0xCCF1
100D:CCEE jmp near 0x4AFD
100D:CCF4 mov word ptr DS:[0xDC1C],0xFFFF
100D:CCFA mov word ptr DS:[0xDC1E],0xFFFF
100D:CD00 add AX,SI
100D:CD02 jb short 0xCD0A
100D:CD04 cmp AX,word ptr DS:[0xCE74]
100D:CD08 jbe short 0xCD0C
100D:CD0A xor SI,SI
100D:CD0C lods AX,word ptr ES:[SI]
100D:CD0E cmp AX,0x6473
100D:CD11 jne short 0xCD25
100D:CD25 cmp AX,0x6C70
100D:CD28 jne short 0xCD37
100D:CD37 cmp AX,0x6D6D
100D:CD3A jne short 0xCD4E
100D:CD4E push DS
100D:CD4F push ES
100D:CD50 mov ES,BP
100D:CD52 xor DI,DI
100D:CD54 test AH,4
100D:CD57 je short 0xCD5D
100D:CD59 mov ES,word ptr DS:[0xDBDA]
100D:CD5D mov word ptr DS:[0xDC16],ES
100D:CD61 mov word ptr DS:[0xDC14],DI
100D:CD65 mov word ptr DS:[0xDC24],AX
100D:CD68 pop DS
100D:CD69 mov CX,AX
100D:CD6B lods AX,word ptr DS:[SI]
100D:CD6C xchg CX,AX
100D:CD6D test AH,4
100D:CD70 jne short 0xCD7C
100D:CD7C call near 0xF403
100D:CD7F pop DS
100D:CD80 ret near
100D:CD8F mov CX,2
100D:CD92 call near 0xCDBF
100D:CD95 jb short 0xCD9F
100D:CD97 les SI,word ptr DS:[0xDC0C]
100D:CD9B mov AX,word ptr ES:[SI-2]
100D:CD9F ret near
100D:CDA0 call near 0xCE1A
100D:CDA3 call near 0xCD8F
100D:CDA6 jb short 0xCE00
100D:CDA8 mov DI,word ptr DS:[0xCE74]
100D:CDAC sub DI,AX
100D:CDAE sub DI,2
100D:CDB1 mov word ptr DS:[0xDC10],DI
100D:CDB5 stos word ptr ES:[DI],AX
100D:CDB6 mov word ptr DS:[0xDC0C],DI
100D:CDBA mov CX,AX
100D:CDBC sub CX,2
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
100D:CE53 test byte ptr DS:[0x3403],4
100D:CE58 je short 0xCE6B
100D:CE6B ret near
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
100D:CEE4 call near 0xCAD4
100D:CEE7 jb short 0xCEEF
100D:CEE9 call near 0xCC96
100D:CEEC call near 0xCC4E
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
100D:CF70 push BX
100D:CF71 dec SI
100D:CF72 test SI,0x0800
100D:CF76 je short 0xCF95
100D:CF78 call near 0xD00F
100D:CF7B les BX,word ptr DS:[0x47B0]
100D:CF7F and SI,0x07FF
100D:CF83 shl SI,1
100D:CF85 mov SI,word ptr ES:[BX+SI]
100D:CF88 mov BX,word ptr ES:[BX]
100D:CF8B mov BX,word ptr ES:[BX-2]
100D:CF8F mov word ptr DS:[0x47B4],BX
100D:CF93 pop BX
100D:CF94 ret near
100D:CF95 shl SI,1
100D:CF97 les BX,word ptr DS:[0x47AC]
100D:CF9B mov SI,word ptr ES:[BX+SI]
100D:CF9E pop BX
100D:CF9F ret near
100D:CFA0 call near 0xAE2F
100D:CFA3 je short 0xCFB8
100D:CFA5 mov AL,byte ptr DS:[0xCEEB]
100D:CFA8 or AL,AL
100D:CFAA je short 0xCFB0
100D:CFB0 mov AL,2
100D:CFB2 mov byte ptr DS:[0x28E7],AL
100D:CFB5 mov byte ptr DS:[0x28E8],AL
100D:CFB8 ret near
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
100D:D00F mov AX,word ptr DS:[0x477C]
100D:D012 cmp AX,word ptr DS:[0xAAD6]
100D:D016 mov AL,0x93
100D:D018 jb short 0xD01C
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
100D:D03C lods AL,byte ptr ES:[SI]
100D:D03E sub AL,0x30
100D:D040 cmp AL,9
100D:D042 ja short 0xD03C
100D:D044 lods AL,byte ptr ES:[SI]
100D:D046 sub AL,0x30
100D:D048 cmp AL,9
100D:D04A jbe short 0xD044
100D:D04C dec SI
100D:D04D ret near
100D:D04E mov word ptr DS:[0xD82C],DX
100D:D052 mov word ptr DS:[0xD82E],BX
100D:D056 mov word ptr DS:[0xD830],DX
100D:D05A mov word ptr DS:[0xD832],BX
100D:D05E ret near
100D:D05F mov DX,word ptr DS:[0xD82C]
100D:D063 mov BX,word ptr DS:[0xD82E]
100D:D067 ret near
100D:D068 mov word ptr DS:[0x2518],0xD096
100D:D06E mov word ptr DS:[0x47A0],0xCEEC
100D:D074 ret near
100D:D075 mov word ptr DS:[0x2518],0xD12F
100D:D07B mov word ptr DS:[0x47A0],0xCF6C
100D:D081 ret near
100D:D12F push AX
100D:D130 push BX
100D:D131 push CX
100D:D132 push DX
100D:D133 push SI
100D:D134 push DI
100D:D135 push BP
100D:D136 push ES
100D:D137 xor AH,AH
100D:D139 mov SI,AX
100D:D13B shl SI,1
100D:D13D shl SI,1
100D:D13F shl SI,1
100D:D141 sub SI,AX
100D:D143 add SI,word ptr DS:[0x2516]
100D:D147 mov BX,0xCF6C
100D:D14A xlat byte ptr DS:[BX+AL]
100D:D14B call near 0xD05F
100D:D14E add word ptr DS:[0xD82C],AX
100D:D152 mov CL,AL
100D:D154 mov CH,7
100D:D156 mov AX,word ptr DS:[0xDBE4]
100D:D159 mov ES,word ptr DS:[0xDBDA]
100D:D15D call far dword ptr DS:[0x38D1]
100D:D161 pop ES
100D:D162 pop BP
100D:D163 pop DI
100D:D164 pop SI
100D:D165 pop DX
100D:D166 pop CX
100D:D167 pop BX
100D:D168 pop AX
100D:D169 ret near
100D:D194 mov word ptr DS:[0xDBE4],CX
100D:D198 call near 0xD04E
100D:D19B push SI
100D:D19C mov SI,AX
100D:D19E call near 0xCF70
100D:D1A1 call near 0xD1BB
100D:D1A4 pop SI
100D:D1A5 ret near
100D:D1BB lods AL,byte ptr ES:[SI]
100D:D1BD cmp AL,0xFF
100D:D1BF je short 0xD1A5
100D:D1C1 cmp AL,0x0D
100D:D1C3 je short 0xD1D1
100D:D1C5 or AL,AL
100D:D1C7 jns short 0xD1CB
100D:D1CB call near word ptr DS:[0x2518]
100D:D1CF jmp short 0xD1BB
100D:D1EF lods AX,word ptr DS:[SI]
100D:D1F0 mov CX,AX
100D:D1F2 call near 0xC137
100D:D1F5 push CX
100D:D1F6 call near 0xD200
100D:D1F9 pop CX
100D:D1FA add SI,0x000E
100D:D1FD loop 0xD1F5
100D:D1FF ret near
100D:D200 push word ptr DS:[0xDBDA]
100D:D204 call near 0xC08E
100D:D207 push SI
100D:D208 test byte ptr DS:[SI+8],0x40
100D:D20C je short 0xD218
100D:D218 test byte ptr DS:[SI+8],0x20
100D:D21C jne short 0xD233
100D:D21E lods AX,word ptr DS:[SI]
100D:D21F mov DX,AX
100D:D221 lods AX,word ptr DS:[SI]
100D:D222 mov BX,AX
100D:D224 lods AX,word ptr DS:[SI]
100D:D225 mov DI,AX
100D:D227 lods AX,word ptr DS:[SI]
100D:D228 mov CX,AX
100D:D22A lods AX,word ptr DS:[SI]
100D:D22B lods AX,word ptr DS:[SI]
100D:D22C inc AX
100D:D22D je short 0xD233
100D:D22F dec AX
100D:D230 call near 0xC22F
100D:D233 pop SI
100D:D234 pop word ptr DS:[0xDBDA]
100D:D238 ret near
100D:D239 mov CH,2
100D:D23B jmp short 0xD23F
100D:D23D xor CX,CX
100D:D23F mov SI,0x1AF4
100D:D242 mov AX,word ptr DS:[SI+0x0A]
100D:D245 sub AX,0
100D:D248 mov CL,3
100D:D24A div CL
100D:D24C cmp CH,AH
100D:D24E je short 0xD27F
100D:D250 mov AX,1
100D:D253 jae short 0xD257
100D:D255 neg AX
100D:D257 push AX
100D:D258 push SI
100D:D259 add word ptr DS:[SI+0x0A],AX
100D:D25C add word ptr DS:[SI+0x18],AX
100D:D25F mov CX,2
100D:D262 call near 0xD1F2
100D:D265 call near 0x1A34
100D:D268 mov AX,0x000A
100D:D26B call near 0xE387
100D:D26E pop SI
100D:D26F pop AX
100D:D270 add word ptr DS:[SI+0x0A],AX
100D:D273 add word ptr DS:[SI+0x18],AX
100D:D276 mov CX,2
100D:D279 call near 0xD1F2
100D:D27C call near 0x1A34
100D:D27F ret near
100D:D280 cmp byte ptr DS:[0xDCE6],0
100D:D285 jle short 0xD2BC
100D:D287 call near 0xE270
100D:D28A mov byte ptr DS:[0xDCE6],0
100D:D28F call near 0xD239
100D:D292 mov CX,0x0011
100D:D295 push CX
100D:D296 push word ptr DS:[0xCE7A]
100D:D29A mov SI,word ptr DS:[0xDBDE]
100D:D29E mov AL,0x18
100D:D2A0 call near 0xC0D5
100D:D2A3 pop BX
100D:D2A4 push BX
100D:D2A5 call near 0xA7C2
100D:D2A8 pop BX
100D:D2A9 mov AX,word ptr DS:[0xCE7A]
100D:D2AC sub AX,BX
100D:D2AE cmp AX,6
100D:D2B1 jb short 0xD2A4
100D:D2B3 pop CX
100D:D2B4 loop 0xD295
100D:D2B6 call near 0xD23D
100D:D2B9 call near 0xE283
100D:D2BC ret near
100D:D2BD mov AL,byte ptr DS:[0xDCE6]
100D:D2C0 push AX
100D:D2C1 mov byte ptr DS:[0xDCE6],0x80
100D:D2C6 mov SI,word ptr DS:[0x21DA]
100D:D2CA mov SI,word ptr DS:[SI]
100D:D2CC lods AL,byte ptr DS:[SI]
100D:D2CD cmp AL,0xFF
100D:D2CF je short 0xD2DA
100D:D2D1 and AL,0x0F
100D:D2D3 je short 0xD2DA
100D:D2D5 call near 0xD2EA
100D:D2D8 jmp short 0xD2C1
100D:D2DA pop AX
100D:D2DB mov byte ptr DS:[0xDCE6],AL
100D:D2DE ret near
100D:D2E2 call near 0xD316
100D:D2E5 call near 0xD2EA
100D:D2E8 jmp short 0xD280
100D:D2EA mov SI,word ptr DS:[0x21DA]
100D:D2EE mov DI,word ptr DS:[SI]
100D:D2F0 mov AL,byte ptr DS:[DI]
100D:D2F2 and AL,0x0F
100D:D2F4 cmp AL,0x0F
100D:D2F6 je short 0xD315
100D:D2F8 mov AX,word ptr DS:[SI+2]
100D:D2FB call near AX
100D:D2FD mov SI,word ptr DS:[0x21DA]
100D:D301 cmp SI,0x21BE
100D:D305 je short 0xD315
100D:D307 sub SI,4
100D:D30A mov word ptr DS:[0x21DA],SI
100D:D30E mov BP,word ptr DS:[SI]
100D:D310 mov CL,0xFF
100D:D312 call near 0xD36D
100D:D315 ret near
100D:D316 cmp word ptr DS:[0x35A6],0
100D:D31B jne short 0xD322
100D:D31D or byte ptr DS:[0xDCE6],1
100D:D322 ret near
100D:D323 call near 0xD316
100D:D326 call near 0xD338
100D:D329 call near 0xD280
100D:D32C jmp near 0xD410
100D:D338 mov CL,0xFF
100D:D33A mov SI,word ptr DS:[0x21DA]
100D:D33E mov DI,word ptr DS:[SI]
100D:D340 mov AL,byte ptr SS:[BP]
100D:D343 cmp AL,byte ptr DS:[DI]
100D:D345 je short 0xD368
100D:D347 jb short 0xD35B
100D:D35B cmp SI,0x21D6
100D:D35F je short 0xD368
100D:D361 add SI,4
100D:D364 mov word ptr DS:[0x21DA],SI
100D:D368 mov word ptr DS:[SI],BP
100D:D36A mov word ptr DS:[SI+2],BX
100D:D36D mov SI,word ptr DS:[0x21DA]
100D:D371 mov word ptr DS:[SI],BP
100D:D373 mov SI,BP
100D:D375 add BP,2
100D:D378 cmp word ptr SS:[BP],0
100D:D37C je short 0xD388
100D:D37E and word ptr SS:[BP],0x7FFF
100D:D383 add BP,4
100D:D386 jmp short 0xD378
100D:D388 cmp CX,5
100D:D38B jae short 0xD397
100D:D397 mov byte ptr DS:[0xDCE7],0xFF
100D:D39C mov SI,word ptr DS:[0x21DA]
100D:D3A0 mov SI,word ptr DS:[SI]
100D:D3A2 inc SI
100D:D3A3 lods AL,byte ptr DS:[SI]
100D:D3A4 mov byte ptr DS:[0xDCE4],AL
100D:D3A7 cbw
100D:D3A8 add SI,AX
100D:D3AA xor CX,CX
100D:D3AC mov byte ptr DS:[0xDCE8],CL
100D:D3B0 mov byte ptr DS:[0xDCE5],0xFF
100D:D3B5 mov AX,word ptr DS:[SI]
100D:D3B7 or AX,AX
100D:D3B9 je short 0xD3EF
100D:D3BB cmp CL,4
100D:D3BE jb short 0xD3D9
100D:D3D9 add SI,4
100D:D3DC push CX
100D:D3DD push SI
100D:D3DE inc byte ptr DS:[0xDCE8]
100D:D3E2 call near 0xD48A
100D:D3E5 pop SI
100D:D3E6 pop CX
100D:D3E7 inc CX
100D:D3E8 cmp CL,5
100D:D3EB jb short 0xD3B5
100D:D3EF cmp byte ptr DS:[0xDCE4],0
100D:D3F4 je short 0xD403
100D:D403 xor AX,AX
100D:D405 push CX
100D:D406 call near 0xD48A
100D:D409 pop CX
100D:D40A inc CX
100D:D40B cmp CL,5
100D:D40E jb short 0xD403
100D:D410 mov DX,word ptr DS:[0xDC36]
100D:D414 mov BX,word ptr DS:[0xDC38]
100D:D418 jmp near 0xD50F
100D:D41B mov BP,word ptr DS:[0x21DA]
100D:D41F mov BP,word ptr SS:[BP]
100D:D422 ret near
100D:D439 mov CX,2
100D:D43C jmp short 0xD445
100D:D43E mov CX,1
100D:D441 jmp short 0xD445
100D:D443 xor CX,CX
100D:D445 call near 0xD454
100D:D448 or BX,BX
100D:D44A je short 0xD453
100D:D44C test AH,0x40
100D:D44F jne short 0xD453
100D:D451 jmp near BX
100D:D454 mov SI,word ptr DS:[0x21DA]
100D:D458 mov SI,word ptr DS:[SI]
100D:D45A inc SI
100D:D45B xor CH,CH
100D:D45D cmp CL,byte ptr DS:[0xDCE5]
100D:D461 je short 0xD475
100D:D463 lods AL,byte ptr DS:[SI]
100D:D464 cbw
100D:D465 add SI,AX
100D:D467 mov AX,CX
100D:D469 shl AX,1
100D:D46B shl AX,1
100D:D46D add SI,AX
100D:D46F mov AX,word ptr DS:[SI]
100D:D471 mov BX,word ptr DS:[SI+2]
100D:D474 ret near
100D:D48A push word ptr DS:[0xDBDA]
100D:D48E call near 0xC08E
100D:D491 cmp byte ptr DS:[0xDCE6],0
100D:D496 jle short 0xD49B
100D:D498 call near 0xC07C
100D:D49B call near 0xD075
100D:D49E mov SI,AX
100D:D4A0 mov AL,0x0E
100D:D4A2 mul CL
100D:D4A4 mov DI,AX
100D:D4A6 add DI,0x1B48
100D:D4AA mov BX,word ptr DS:[DI+2]
100D:D4AD inc BX
100D:D4AE mov DX,0x005D
100D:D4B1 call near 0xD04E
100D:D4B4 mov byte ptr DS:[0xDBE5],0xF3
100D:D4B9 and byte ptr DS:[DI+8],0x7F
100D:D4BD mov AX,SI
100D:D4BF and SI,0x3FFF
100D:D4C3 je short 0xD4E9
100D:D4C5 mov AL,0xF5
100D:D4C7 test AH,0x40
100D:D4CA jne short 0xD4DA
100D:D4CC or byte ptr DS:[DI+8],0x80
100D:D4D0 mov AL,0xFA
100D:D4D2 or AH,AH
100D:D4D4 jns short 0xD4DA
100D:D4D6 xchg AL,byte ptr DS:[0xDBE5]
100D:D4DA mov byte ptr DS:[0xDBE4],AL
100D:D4DD call near 0xCF70
100D:D4E0 mov AL,0x20
100D:D4E2 call near word ptr DS:[0x2518]
100D:D4E6 call near 0xD1BB
100D:D4E9 call near 0xD05F
100D:D4EC mov SI,0xDCE9
100D:D4EF mov word ptr DS:[SI],DX
100D:D4F1 mov word ptr DS:[SI+2],BX
100D:D4F4 mov word ptr DS:[SI+4],0x00E3
100D:D4F9 add BX,7
100D:D4FC mov word ptr DS:[SI+6],BX
100D:D4FF mov AL,byte ptr DS:[0xDBE5]
100D:D502 mov ES,word ptr DS:[0xDBDA]
100D:D506 call far dword ptr DS:[0x38DD]
100D:D50A pop word ptr DS:[0xDBDA]
100D:D50E ret near
100D:D50F push BX
100D:D510 push CX
100D:D511 push DX
100D:D512 push SI
100D:D513 push DI
100D:D514 push BP
100D:D515 cmp byte ptr DS:[0x4774],0
100D:D51A je short 0xD523
100D:D523 call near 0xD41B
100D:D526 cmp BP,0x1F0E
100D:D52A jne short 0xD575
100D:D52C cmp byte ptr DS:[0x11C9],0
100D:D531 jne short 0xD575
100D:D533 mov DI,0x1BF0
100D:D536 cmp byte ptr DS:[DI+8],0
100D:D53A jns short 0xD545
100D:D545 push BP
100D:D546 call near 0x9285
100D:D549 pop BP
100D:D54A jae short 0xD575
100D:D54C mov AL,CL
100D:D54E sub AL,0x0F
100D:D550 jb short 0xD55D
100D:D55D mov BP,CX
100D:D55F add BP,0x0078
100D:D563 xor CX,CX
100D:D565 call near 0xD454
100D:D568 cmp AX,BP
100D:D56A je short 0xD5DD
100D:D56C inc CX
100D:D56D cmp CL,byte ptr DS:[0xDCE8]
100D:D571 jb short 0xD565
100D:D575 cmp BP,0x1F7E
100D:D579 jne short 0xD5B1
100D:D57B mov DI,0x1BE2
100D:D57E cmp byte ptr DS:[DI+8],0
100D:D582 jns short 0xD593
100D:D584 xor CX,CX
100D:D586 call near 0xD6FE
100D:D589 jb short 0xD5DD
100D:D58B mov DI,0x1BF0
100D:D58E call near 0xD6FE
100D:D591 jb short 0xD5DD
100D:D593 cmp byte ptr DS:[0x1BF8],0
100D:D598 jns short 0xD5B1
100D:D59A mov DI,0x1BFE
100D:D59D call near 0xD6FE
100D:D5A0 mov CL,3
100D:D5A2 jb short 0xD5DD
100D:D5A4 call near 0x92C9
100D:D5A7 jae short 0xD5B1
100D:D5B1 cmp BX,0x0098
100D:D5B5 jb short 0xD5DB
100D:D5B7 mov CL,0xFF
100D:D5B9 mov DI,0x1B48
100D:D5BC cmp DX,word ptr DS:[DI]
100D:D5BE jb short 0xD5DD
100D:D5C0 cmp DX,word ptr DS:[DI+4]
100D:D5C3 jae short 0xD5DD
100D:D5C5 xor CX,CX
100D:D5C7 cmp BX,word ptr DS:[DI+2]
100D:D5CA jbe short 0xD5DB
100D:D5CC cmp BX,word ptr DS:[DI+6]
100D:D5CF jbe short 0xD5DD
100D:D5D1 add DI,0x000E
100D:D5D4 inc CX
100D:D5D5 cmp CL,byte ptr DS:[0xDCE8]
100D:D5D9 jb short 0xD5C7
100D:D5DB mov CL,0xFF
100D:D5DD mov AL,CL
100D:D5DF xchg CL,byte ptr DS:[0xDCE7]
100D:D5E3 cmp AL,CL
100D:D5E5 je short 0xD610
100D:D5E7 call near 0xDBB2
100D:D5EA or CL,CL
100D:D5EC js short 0xD5FC
100D:D5EE cmp CL,byte ptr DS:[0xDCE8]
100D:D5F2 jae short 0xD5FC
100D:D5F4 push AX
100D:D5F5 call near 0xD454
100D:D5F8 call near 0xD48A
100D:D5FB pop AX
100D:D5FC cmp AL,byte ptr DS:[0xDCE8]
100D:D600 jae short 0xD60D
100D:D602 mov CX,AX
100D:D604 call near 0xD454
100D:D607 or AH,0x80
100D:D60A call near 0xD48A
100D:D60D call near 0xDBEC
100D:D610 pop BP
100D:D611 pop DI
100D:D612 pop SI
100D:D613 pop DX
100D:D614 pop CX
100D:D615 pop BX
100D:D616 ret near
100D:D617 push AX
100D:D618 mov AX,0x0090
100D:D61B jmp short 0xD621
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
100D:D636 call near 0xDBB2
100D:D639 xor CX,CX
100D:D63B call near 0xD454
100D:D63E call near 0xD48A
100D:D641 mov byte ptr DS:[0xDCE7],0xFF
100D:D646 call near 0xDBEC
100D:D649 call near 0xE283
100D:D64C pop AX
100D:D64D ret near
100D:D65A test byte ptr DS:[DI+9],0x20
100D:D65E je short 0xD676
100D:D676 ret near
100D:D694 mov AX,word ptr DS:[0x2582]
100D:D697 mov DI,0x1B9C
100D:D69A cmp AX,0x260C
100D:D69D je short 0xD6B5
100D:D69F add DI,0x000E
100D:D6A2 cmp AX,0x2650
100D:D6A5 je short 0xD6B5
100D:D6A7 add DI,0x000E
100D:D6AA cmp AX,0x2694
100D:D6AD je short 0xD6B5
100D:D6AF add DI,0x000E
100D:D6B2 cmp AX,0x26D8
100D:D6B5 stc
100D:D6B6 ret near
100D:D6B7 call near 0xD694
100D:D6BA je short 0xD6FD
100D:D6BC mov DI,0x1AE4
100D:D6BF mov CX,word ptr DS:[DI]
100D:D6C1 add DI,2
100D:D6C4 cmp word ptr DS:[0x2570],0x1AD6
100D:D6CA jne short 0xD6CF
100D:D6CF cmp byte ptr DS:[0x46D9],0
100D:D6D4 je short 0xD6DC
100D:D6DC cmp byte ptr DS:[DI+8],0
100D:D6E0 jns short 0xD6F7
100D:D6E2 cmp DX,word ptr DS:[DI]
100D:D6E4 jbe short 0xD6F7
100D:D6E6 cmp DX,word ptr DS:[DI+4]
100D:D6E9 jae short 0xD6F7
100D:D6EB cmp BX,word ptr DS:[DI+2]
100D:D6EE jbe short 0xD6F7
100D:D6F0 dec BX
100D:D6F1 cmp BX,word ptr DS:[DI+6]
100D:D6F4 inc BX
100D:D6F5 jb short 0xD6FD
100D:D6F7 add DI,0x000E
100D:D6FA loop 0xD6DC
100D:D6FC clc
100D:D6FD ret near
100D:D6FE cmp DX,word ptr DS:[DI]
100D:D700 jbe short 0xD710
100D:D702 cmp DX,word ptr DS:[DI+4]
100D:D705 jae short 0xD710
100D:D707 cmp BX,word ptr DS:[DI+2]
100D:D70A jbe short 0xD710
100D:D70C cmp BX,word ptr DS:[DI+6]
100D:D70F ret near
100D:D710 clc
100D:D711 ret near
100D:D717 cmp byte ptr DS:[0x46EB],0
100D:D71C jne short 0xD712
100D:D71E mov SI,0x1C76
100D:D721 test byte ptr DS:[0x11C9],3
100D:D726 je short 0xD72B
100D:D728 mov SI,0x1D72
100D:D72B push DS
100D:D72C pop ES
100D:D72D mov DI,0x1B8E
100D:D730 mov CX,0x002A
100D:D733 rep movs word ptr ES:[DI],word ptr DS:[SI]
100D:D735 call near 0xD741
100D:D738 mov SI,0x1B8E
100D:D73B mov CX,6
100D:D73E jmp near 0xD1F2
100D:D741 mov AX,word ptr DS:[0x1B0C]
100D:D744 sub AX,3
100D:D747 cmp AX,3
100D:D74A jae short 0xD759
100D:D74C mov SI,0x2458
100D:D74F mov ES,word ptr DS:[0xDBD8]
100D:D753 mov AL,0xF0
100D:D755 call far dword ptr DS:[0x38DD]
100D:D759 ret near
100D:D75A mov SI,0x1C36
100D:D75D call near 0xD795
100D:D760 call near 0x1A34
100D:D763 mov SI,0x1C0C
100D:D766 mov AX,0x0040
100D:D769 mov word ptr DS:[SI+0x0A],AX
100D:D76C mov word ptr DS:[SI+0x18],AX
100D:D76F mov CX,2
100D:D772 call near 0xD1F2
100D:D775 mov SI,0x1C0C
100D:D778 mov AL,byte ptr DS:[0x1152]
100D:D77B cbw
100D:D77C add AX,0x0041
100D:D77F mov word ptr DS:[SI+0x0A],AX
100D:D782 mov AL,byte ptr DS:[0x1153]
100D:D785 cbw
100D:D786 add AX,0x0041
100D:D789 mov word ptr DS:[SI+0x18],AX
100D:D78C mov CX,2
100D:D78F jmp near 0xD1F2
100D:D795 push DS
100D:D796 pop ES
100D:D797 mov DI,0x1AEE
100D:D79A mov CX,4
100D:D79D movs word ptr ES:[DI],word ptr DS:[SI]
100D:D79E movs word ptr ES:[DI],word ptr DS:[SI]
100D:D79F add DI,0x000A
100D:D7A2 loop 0xD79D
100D:D7A4 mov SI,0x1AE6
100D:D7A7 mov CX,3
100D:D7AA jmp near 0xD1F2
100D:D7B7 mov AX,word ptr DS:[0xCE7A]
100D:D7BA shl AX,1
100D:D7BC shl AX,1
100D:D7BE cmp AH,byte ptr DS:[0xDCF1]
100D:D7C2 je short 0xD814
100D:D7C4 mov byte ptr DS:[0xDCF1],AH
100D:D7C8 mov AX,word ptr DS:[0x2222]
100D:D7CB or AX,AX
100D:D7CD je short 0xD814
100D:D814 ret near
100D:D815 mov AX,word ptr DS:[0xCE7A]
100D:D818 mov word ptr DS:[0xDC68],AX
100D:D81B mov byte ptr DS:[0xDC4B],0
100D:D820 cmp byte ptr DS:[0xCEE8],0x2F
100D:D825 jne short 0xD831
100D:D831 cmp byte ptr DS:[0x46D9],0
100D:D836 jne short 0xD83E
100D:D838 call near 0xD7B7
100D:D83B call near 0x1B0D
100D:D83E call near 0xD9D2
100D:D841 cmp byte ptr DS:[0x46D9],0
100D:D846 je short 0xD84B
100D:D84B call near 0xE3CC
100D:D84E mov word ptr DS:[0],AX
100D:D851 call near 0x4F0C
100D:D854 cmp byte ptr DS:[0xDC4B],0
100D:D859 je short 0xD860
100D:D860 call near 0xDF1E
100D:D863 call near 0xDB4C
100D:D866 call near 0xDC20
100D:D869 mov DI,DX
100D:D86B xchg DI,word ptr DS:[0xDC62]
100D:D86F mov CX,BX
100D:D871 xchg CX,word ptr DS:[0xDC64]
100D:D875 sub DI,DX
100D:D877 sub CX,BX
100D:D879 neg DI
100D:D87B neg CX
100D:D87D mov SI,word ptr DS:[0x2570]
100D:D881 and AX,0x000F
100D:D884 jne short 0xD893
100D:D886 call near 0xD50F
100D:D889 mov AX,CX
100D:D88B or AX,DI
100D:D88D je short 0xD88F
100D:D88F call near word ptr DS:[SI]
100D:D891 jmp short 0xD820
100D:D893 mov BP,word ptr DS:[0xCE7A]
100D:D897 mov word ptr DS:[0xDC5A],BP
100D:D89B cmp byte ptr DS:[0x4774],0
100D:D8A0 je short 0xD8B1
100D:D8B1 test AL,5
100D:D8B3 jne short 0xD8BA
100D:D8BA and AL,5
100D:D8BC dec AL
100D:D8BE jne short 0xD8F4
100D:D8C0 mov BP,word ptr DS:[0xDC5C]
100D:D8C4 or BP,BP
100D:D8C6 jne short 0xD8DA
100D:D8C8 mov AX,CX
100D:D8CA or AX,DI
100D:D8CC je short 0xD8D7
100D:D8CE call near 0xDBB2
100D:D8D1 mov AL,byte ptr DS:[0xDC35]
100D:D8D4 call near word ptr DS:[SI+0x0A]
100D:D8D7 jmp near 0xD820
100D:D8F4 call near 0xDBB2
100D:D8F7 call near 0xE26F
100D:D8FA sub AL,3
100D:D8FC je short 0xD944
100D:D8FE cmp SI,word ptr DS:[0x2570]
100D:D902 jne short 0xD90E
100D:D904 call near 0xD6B7
100D:D907 jb short 0xD918
100D:D909 push SI
100D:D90A call near 0x9215
100D:D90D pop SI
100D:D90E mov AL,byte ptr DS:[0xDC35]
100D:D911 call near word ptr DS:[SI+2]
100D:D914 jmp near 0xD820
100D:D917 ret near
100D:D918 mov word ptr DS:[0xDC60],DI
100D:D91C call near 0xD65A
100D:D91F test byte ptr DS:[DI+9],0x40
100D:D923 je short 0xD92B
100D:D92B mov byte ptr DS:[0xCE9D],0
100D:D930 mov byte ptr DS:[0xCEBA],0
100D:D935 mov AX,word ptr DS:[0xCE7A]
100D:D938 mov word ptr DS:[0xDC5E],AX
100D:D93B mov AL,byte ptr DS:[0xDC35]
100D:D93E call near word ptr DS:[DI+0x0C]
100D:D941 jmp near 0xD820
100D:D944 mov DI,word ptr DS:[0xDC5C]
100D:D948 mov word ptr DS:[0xDC5C],0
100D:D94E or DI,DI
100D:D950 jne short 0xD92B
100D:D952 mov AL,byte ptr DS:[0xDC35]
100D:D955 call near word ptr DS:[SI+6]
100D:D958 jmp near 0xD820
100D:D95B mov AX,0x2572
100D:D95E mov word ptr DS:[0x2570],AX
100D:D961 ret near
100D:D9D2 call near 0xACE6
100D:D9D5 mov AX,word ptr DS:[0xCE7A]
100D:D9D8 mov CX,AX
100D:D9DA mov BX,AX
100D:D9DC mov SI,0xDC68
100D:D9DF xchg CX,word ptr DS:[SI]
100D:D9E1 sub BX,CX
100D:D9E3 mov CX,word ptr DS:[SI+2]
100D:D9E6 jcxz short 0xDA03
100D:D9E8 add SI,4
100D:D9EB lods AX,word ptr DS:[SI]
100D:D9EC mov BP,AX
100D:D9EE mov AX,BX
100D:D9F0 add AX,word ptr DS:[SI]
100D:D9F2 cmp AX,BP
100D:D9F4 jae short 0xDA04
100D:D9F6 mov word ptr DS:[SI],AX
100D:D9F8 add SI,4
100D:D9FB loop 0xD9EB
100D:D9FD mov word ptr DS:[0xDC66],0
100D:DA03 ret near
100D:DA04 or BP,BP
100D:DA06 je short 0xDA0E
100D:DA08 xor DX,DX
100D:DA0A div BP
100D:DA0C mov word ptr DS:[SI],DX
100D:DA0E sub SI,2
100D:DA11 push BX
100D:DA12 push CX
100D:DA13 push SI
100D:DA14 mov word ptr DS:[0xDC66],SP
100D:DA18 call near word ptr DS:[SI+4]
100D:DA1B pop SI
100D:DA1C pop CX
100D:DA1D pop BX
100D:DA1E add SI,6
100D:DA21 loop 0xD9EB
100D:DA23 jmp short 0xD9FD
100D:DA25 push DS
100D:DA26 pop ES
100D:DA27 mov DI,0xDC6A
100D:DA2A mov AX,word ptr DS:[DI]
100D:DA2C inc AX
100D:DA2D cmp AX,0x0014
100D:DA30 ja short 0xDA52
100D:DA32 stos word ptr ES:[DI],AX
100D:DA33 dec AX
100D:DA34 add AX,AX
100D:DA36 mov BX,AX
100D:DA38 add AX,AX
100D:DA3A add AX,BX
100D:DA3C add DI,AX
100D:DA3E mov AX,BP
100D:DA40 stos word ptr ES:[DI],AX
100D:DA41 xor AX,AX
100D:DA43 stos word ptr ES:[DI],AX
100D:DA44 mov AX,SI
100D:DA46 stos word ptr ES:[DI],AX
100D:DA47 mov BP,word ptr DS:[0xDC66]
100D:DA4B or BP,BP
100D:DA4D je short 0xDA52
100D:DA52 ret near
100D:DA53 mov word ptr DS:[0xDC6A],0
100D:DA59 mov byte ptr DS:[0x46D7],0
100D:DA5E ret near
100D:DA5F mov DI,0xDC6A
100D:DA62 mov CX,word ptr DS:[DI]
100D:DA64 jcxz short 0xDA72
100D:DA66 add DI,6
100D:DA69 cmp word ptr DS:[DI],SI
100D:DA6B je short 0xDA73
100D:DA6D add DI,6
100D:DA70 loop 0xDA69
100D:DA72 ret near
100D:DA73 sub DI,4
100D:DA76 dec word ptr DS:[0xDC6A]
100D:DA7A mov BP,word ptr DS:[0xDC66]
100D:DA7E or BP,BP
100D:DA80 je short 0xDA90
100D:DA82 cmp DI,word ptr SS:[BP]
100D:DA85 ja short 0xDA8D
100D:DA87 sub word ptr SS:[BP],6
100D:DA8B jmp short 0xDA90
100D:DA90 dec CX
100D:DA91 je short 0xDA72
100D:DA93 mov AX,CX
100D:DA95 add CX,CX
100D:DA97 add CX,AX
100D:DA99 mov SI,DI
100D:DA9B add SI,6
100D:DA9E push DS
100D:DA9F pop ES
100D:DAA0 rep movs word ptr ES:[DI],word ptr DS:[SI]
100D:DAA2 ret near
100D:DAA3 mov word ptr DS:[0xDC58],0
100D:DAA9 ret near
100D:DAAA mov word ptr DS:[0xDC58],SI
100D:DAAE ret near
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
100D:DB4C mov AX,word ptr DS:[0xDC34]
100D:DB4F and AL,3
100D:DB51 mov byte ptr DS:[0xDC35],AL
100D:DB54 xor AH,AL
100D:DB56 add AH,AH
100D:DB58 add AH,AH
100D:DB5A or AL,AH
100D:DB5C xor AH,AH
100D:DB5E mov DX,word ptr DS:[0xDC36]
100D:DB62 mov BX,word ptr DS:[0xDC38]
100D:DB66 ret near
100D:DB67 cmp byte ptr DS:[0xDC47],0
100D:DB6C jns short 0xDBAB
100D:DB74 cmp byte ptr DS:[0xDC46],0
100D:DB79 js short 0xDBAB
100D:DB7B push BX
100D:DB7C push DX
100D:DB7D mov BX,word ptr DS:[0x2582]
100D:DB81 mov DX,word ptr DS:[0xDC42]
100D:DB85 sub DX,word ptr DS:[BX]
100D:DB87 mov BX,word ptr DS:[BX+2]
100D:DB8A neg BX
100D:DB8C add BX,word ptr DS:[0xDC44]
100D:DB90 cmp DX,word ptr DS:[SI+4]
100D:DB93 jge short 0xDBA9
100D:DB95 cmp BX,word ptr DS:[SI+6]
100D:DB98 jge short 0xDBA9
100D:DBA9 pop DX
100D:DBAA pop BX
100D:DBAB ret near
100D:DBB2 push AX
100D:DBB3 mov AL,byte ptr DS:[0xDC46]
100D:DBB6 dec byte ptr DS:[0xDC46]
100D:DBBA js short 0xDBC0
100D:DBC0 or AL,AL
100D:DBC2 js short 0xDBC8
100D:DBC4 call far dword ptr DS:[0x38C5]
100D:DBC8 pop AX
100D:DBC9 ret near
100D:DBCA mov AX,word ptr DS:[0xDC44]
100D:DBCD cmp AX,0x0098
100D:DBD0 jae short 0xDBE2
100D:DBD2 cmp AX,0x0088
100D:DBD5 jae short 0xDBB2
100D:DBD7 dec byte ptr DS:[0xDC46]
100D:DBDB js short 0xDBE2
100D:DBE2 ret near
100D:DBE3 mov AX,word ptr DS:[0xDC44]
100D:DBE6 cmp AX,0x0098
100D:DBE9 jb short 0xDBEC
100D:DBEB ret near
100D:DBEC inc byte ptr DS:[0xDC46]
100D:DBF0 js short 0xDC1A
100D:DBF2 jne short 0xDC1B
100D:DBF4 push AX
100D:DBF5 push BX
100D:DBF6 push CX
100D:DBF7 push DX
100D:DBF8 push SI
100D:DBF9 push DI
100D:DBFA push BP
100D:DBFB mov DX,word ptr DS:[0xDC36]
100D:DBFF mov BX,word ptr DS:[0xDC38]
100D:DC03 mov word ptr DS:[0xDC42],DX
100D:DC07 mov word ptr DS:[0xDC44],BX
100D:DC0B mov SI,word ptr DS:[0x2582]
100D:DC0F call far dword ptr DS:[0x38C1]
100D:DC13 pop BP
100D:DC14 pop DI
100D:DC15 pop SI
100D:DC16 pop DX
100D:DC17 pop CX
100D:DC18 pop BX
100D:DC19 pop AX
100D:DC1A ret near
100D:DC1B dec byte ptr DS:[0xDC46]
100D:DC1F ret near
100D:DC20 push AX
100D:DC21 push BX
100D:DC22 push CX
100D:DC23 push DX
100D:DC24 push SI
100D:DC25 push DI
100D:DC26 push BP
100D:DC27 mov DX,word ptr DS:[0xDC36]
100D:DC2B mov BX,word ptr DS:[0xDC38]
100D:DC2F call near 0xDC6A
100D:DC32 mov SI,BP
100D:DC34 xchg BP,word ptr DS:[0x2582]
100D:DC38 xor AL,AL
100D:DC3A xchg AL,byte ptr DS:[0xDC46]
100D:DC3E or AL,AL
100D:DC40 js short 0xDC56
100D:DC42 cmp DX,word ptr DS:[0xDC42]
100D:DC46 jne short 0xDC52
100D:DC48 cmp BX,word ptr DS:[0xDC44]
100D:DC4C jne short 0xDC52
100D:DC4E cmp SI,BP
100D:DC50 je short 0xDC62
100D:DC52 call far dword ptr DS:[0x38C5]
100D:DC56 mov word ptr DS:[0xDC42],DX
100D:DC5A mov word ptr DS:[0xDC44],BX
100D:DC5E call far dword ptr DS:[0x38C1]
100D:DC62 pop BP
100D:DC63 pop DI
100D:DC64 pop SI
100D:DC65 pop DX
100D:DC66 pop CX
100D:DC67 pop BX
100D:DC68 pop AX
100D:DC69 ret near
100D:DC6A cmp byte ptr DS:[0x28BE],0
100D:DC6F mov BP,0x25C8
100D:DC72 jne short 0xDCDF
100D:DC74 mov BP,0x2584
100D:DC77 cmp byte ptr DS:[0x4723],0
100D:DC7C jne short 0xDCDF
100D:DC7E mov DI,word ptr DS:[0xDC58]
100D:DC82 or DI,DI
100D:DC84 je short 0xDCDF
100D:DC86 cmp BX,0x009B
100D:DC8A jge short 0xDCDF
100D:DC8C call near 0xD6FE
100D:DC8F mov BP,0x25C8
100D:DC92 jb short 0xDCDF
100D:DCDF ret near
100D:DD63 call near 0xDE7B
100D:DD66 call near 0xDE54
100D:DD69 je short 0xDDAE
100D:DD6B cmp byte ptr DS:[0xCEE8],0
100D:DD70 jne short 0xDDAE
100D:DD72 test byte ptr DS:[0x2942],0x40
100D:DD77 jne short 0xDD89
100D:DD79 mov AX,3
100D:DD7C int 0x33
100D:DD7E xchg BX,SI
100D:DD80 xor BX,SI
100D:DD82 and BX,SI
100D:DD84 and BL,7
100D:DD87 jne short 0xDDAE
100D:DD89 test byte ptr DS:[0x2942],0x80
100D:DD8E je short 0xDD9E
100D:DD9E push SI
100D:DD9F push DI
100D:DDA0 call near 0xE3CC
100D:DDA3 mov word ptr DS:[0],AX
100D:DDA6 call near 0xD9D2
100D:DDA9 pop DI
100D:DDAA pop SI
100D:DDAB or AL,1
100D:DDAD ret near
100D:DDAE stc
100D:DDAF ret near
100D:DDE7 pushf
100D:DDE8 call near 0xDE4E
100D:DDEB popf
100D:DDEC call near 0xE283
100D:DDEF ret near
100D:DE07 push AX
100D:DE08 or AL,1
100D:DE0A pop AX
100D:DE0B ret near
100D:DE0C cmp byte ptr DS:[0xDBCD],0
100D:DE11 jns short 0xDE07
100D:DE13 call near 0xE270
100D:DE16 mov byte ptr DS:[0xCEE8],0
100D:DE1B mov SI,0xFFFF
100D:DE1E mov DI,SI
100D:DE20 mov AX,0x0060
100D:DE23 sub AX,word ptr DS:[0xDBD0]
100D:DE27 xor AH,AH
100D:DE29 mov DL,6
100D:DE2B div DL
100D:DE2D and AL,0x0F
100D:DE2F mov DX,word ptr DS:[0xDBCE]
100D:DE33 shl DX,1
100D:DE35 shl DX,1
100D:DE37 shl DX,1
100D:DE39 shl DX,1
100D:DE3B or DL,AL
100D:DE3D cmp BX,DX
100D:DE3F jbe short 0xDE4A
100D:DE4A or AL,1
100D:DE4C jmp short 0xDDE7
100D:DE4E mov byte ptr DS:[0xCEE8],0
100D:DE53 ret near
100D:DE54 mov byte ptr DS:[0xCEE9],0
100D:DE59 cmp byte ptr DS:[0xCEE8],1
100D:DE5E jne short 0xDE67
100D:DE60 mov byte ptr DS:[0xCEE9],1
100D:DE65 jmp short 0xDE4E
100D:DE67 ret near
100D:DE7A ret near
100D:DE7B cmp byte ptr DS:[0xCE9A],0
100D:DE80 je short 0xDE7A
100D:DF1E call near 0xDE7B
100D:DF21 xor AL,AL
100D:DF23 test byte ptr DS:[0x2942],0x40
100D:DF28 jne short 0xDF49
100D:DF2A mov AX,3
100D:DF2D int 0x33
100D:DF2F mov AX,CX
100D:DF31 mov CX,word ptr DS:[0x2580]
100D:DF35 shr AX,CL
100D:DF37 mov CL,CH
100D:DF39 shr DX,CL
100D:DF3B mov CX,AX
100D:DF3D mov AL,BL
100D:DF3F and AL,3
100D:DF41 mov word ptr DS:[0xDC36],CX
100D:DF45 mov word ptr DS:[0xDC38],DX
100D:DF49 mov byte ptr DS:[0xDC34],AL
100D:DF4C test byte ptr DS:[0x2942],0x80
100D:DF51 je short 0xDF56
100D:DF56 mov SI,0xCEC8
100D:DF59 mov DI,word ptr DS:[0xDC48]
100D:DF5D xor DX,DX
100D:DF5F mov BX,DX
100D:DF61 mov AX,DX
100D:DF63 mov CX,0x000D
100D:DF66 lods AL,byte ptr DS:[SI]
100D:DF67 or AL,byte ptr DS:[SI+0x12]
100D:DF6A je short 0xDF74
100D:DF74 add DI,6
100D:DF77 loop 0xDF66
100D:DF79 mov AL,byte ptr DS:[0xCEBA]
100D:DF7C or AL,byte ptr DS:[0xCE9D]
100D:DF80 or AL,byte ptr DS:[0xCEE6]
100D:DF84 and AL,1
100D:DF86 mov AH,AL
100D:DF88 xchg AL,byte ptr DS:[0xDC57]
100D:DF8C not AL
100D:DF8E and AL,byte ptr DS:[0xDC34]
100D:DF92 or AL,AH
100D:DF94 mov byte ptr DS:[0xDC34],AL
100D:DF97 mov AX,DX
100D:DF99 or AX,BX
100D:DF9B jne short 0xDFB7
100D:DF9D mov word ptr DS:[0xDC51],AX
100D:DFA0 mov word ptr DS:[0xDC53],AX
100D:DFA3 mov word ptr DS:[0xDC55],AX
100D:DFA6 ret near
100D:E26F ret near
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
100D:E290 call near 0xD04E
100D:E293 jmp short 0xE297
100D:E297 push CX
100D:E298 mov CX,0x0064
100D:E29B div CL
100D:E29D add AL,0x30
100D:E29F cmp AL,0x30
100D:E2A1 jne short 0xE2A7
100D:E2A3 mov AL,0x20
100D:E2A5 dec CH
100D:E2A7 call near word ptr DS:[0x2518]
100D:E2AB mov AL,AH
100D:E2AD aam
100D:E2AF xchg AL,AH
100D:E2B1 add AX,0x3030
100D:E2B4 or CH,CH
100D:E2B6 je short 0xE2BE
100D:E2B8 cmp AL,0x30
100D:E2BA jne short 0xE2BE
100D:E2BC mov AL,0x20
100D:E2BE call near word ptr DS:[0x2518]
100D:E2C2 mov AL,AH
100D:E2C4 call near word ptr DS:[0x2518]
100D:E2C8 pop CX
100D:E2C9 ret near
100D:E2E3 push BX
100D:E2E4 push CX
100D:E2E5 mov CX,0x0064
100D:E2E8 mov BX,CX
100D:E2EA cmp AX,0x03E8
100D:E2ED jb short 0xE2F2
100D:E2F2 div CL
100D:E2F4 add AL,0x30
100D:E2F6 cmp AL,0x30
100D:E2F8 jne short 0xE2FE
100D:E2FA mov AL,0x20
100D:E2FC xor BX,BX
100D:E2FE mov byte ptr ES:[SI-3],AL
100D:E302 mov AL,AH
100D:E304 aam
100D:E306 xchg AL,AH
100D:E308 add AX,0x3030
100D:E30B or BX,BX
100D:E30D jne short 0xE315
100D:E30F cmp AL,0x30
100D:E311 jne short 0xE315
100D:E313 mov AL,0x20
100D:E315 mov word ptr ES:[SI-2],AX
100D:E319 pop CX
100D:E31A pop BX
100D:E31B ret near
100D:E31C push BX
100D:E31D push CX
100D:E31E mov CX,0x03E8
100D:E321 mov BX,CX
100D:E323 xor DX,DX
100D:E325 div CX
100D:E327 aam
100D:E329 xchg AL,AH
100D:E32B add AX,0x3030
100D:E32E cmp AL,0x30
100D:E330 jne short 0xE33D
100D:E332 mov AL,0x20
100D:E334 cmp AH,0x30
100D:E337 jne short 0xE33D
100D:E339 mov AH,AL
100D:E33B xor BX,BX
100D:E33D mov word ptr ES:[SI-5],AX
100D:E341 mov AX,DX
100D:E343 xor DX,DX
100D:E345 mov CX,0x0064
100D:E348 div CL
100D:E34A add AL,0x30
100D:E34C or BX,BX
100D:E34E jne short 0xE2FE
100D:E350 inc BX
100D:E351 jmp short 0xE2F6
100D:E353 push AX
100D:E354 push word ptr DS:[0xCE7A]
100D:E358 call near BP
100D:E35A pop BX
100D:E35B pop BP
100D:E35C cmp byte ptr DS:[0x227D],0
100D:E361 je short 0xE378
100D:E378 call near 0xDE7B
100D:E37B mov AX,word ptr DS:[0xCE7A]
100D:E37E sub AX,BX
100D:E380 cmp AX,BP
100D:E382 jb short 0xE35C
100D:E384 or AL,1
100D:E386 ret near
100D:E387 push AX
100D:E388 push CX
100D:E389 mov CX,AX
100D:E38B jcxz short 0xE39D
100D:E38D pushf
100D:E38E sti
100D:E38F mov AX,word ptr SS:[0xCE7A]
100D:E393 cmp AX,word ptr SS:[0xCE7A]
100D:E398 je short 0xE393
100D:E39A loop 0xE38F
100D:E39C popf
100D:E39D pop CX
100D:E39E pop AX
100D:E39F ret near
100D:E3A0 mov CX,AX
100D:E3A2 mov AX,word ptr DS:[0xCE7A]
100D:E3A5 cmp AX,word ptr DS:[0xCE7A]
100D:E3A9 je short 0xE3A5
100D:E3AB call near 0xE270
100D:E3AE call near 0xD9D2
100D:E3B1 call near 0xE283
100D:E3B4 loop 0xE3A2
100D:E3B6 ret near
100D:E3B7 push DX
100D:E3B8 mov AX,word ptr DS:[0xD824]
100D:E3BB mov DX,0xE56D
100D:E3BE mul DX
100D:E3C0 inc AX
100D:E3C1 mov word ptr DS:[0xD824],AX
100D:E3C4 mov AL,AH
100D:E3C6 mov AH,DL
100D:E3C8 and AX,BX
100D:E3CA pop DX
100D:E3CB ret near
100D:E3CC push DX
100D:E3CD mov AX,word ptr DS:[0xD826]
100D:E3D0 mov DX,0xCBD1
100D:E3D3 mul DX
100D:E3D5 inc AX
100D:E3D6 mov word ptr DS:[0xD826],AX
100D:E3D9 mov AL,AH
100D:E3DB mov AH,DL
100D:E3DD pop DX
100D:E3DE ret near
100D:E3DF push CX
100D:E3E0 push DX
100D:E3E1 mov AX,BX
100D:E3E3 or AX,AX
100D:E3E5 je short 0xE408
100D:E3E7 mov CX,0xFFFF
100D:E3EA shl CX,1
100D:E3EC shr AX,1
100D:E3EE jne short 0xE3EA
100D:E3F0 not CX
100D:E3F2 mov AX,word ptr DS:[0xD828]
100D:E3F5 mov DX,0xCBD1
100D:E3F8 mul DX
100D:E3FA inc AX
100D:E3FB mov word ptr DS:[0xD828],AX
100D:E3FE mov AL,AH
100D:E400 mov AH,DL
100D:E402 and AX,CX
100D:E404 cmp AX,BX
100D:E406 ja short 0xE3F2
100D:E408 pop DX
100D:E409 pop CX
100D:E40A ret near
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
100D:E54A jmp near 0xE4B7
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
100D:EF80 inc word ptr DS:[0xCE7C]
100D:EF84 cmp byte ptr DS:[0x2788],0
100D:EF89 jne short 0xEF9F
100D:EF8B dec word ptr DS:[0x46DB]
100D:EF8F jns short 0xEF9F
100D:EF91 mov AX,word ptr DS:[0x146E]
100D:EF94 mov word ptr DS:[0x46DB],AX
100D:EF97 inc word ptr DS:[2]
100D:EF9B inc byte ptr DS:[0x46DD]
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
100D:EFD5 mov byte ptr DS:[0xCE72],byte ptr [0x0001F0A9]
100D:EFDA pop DS
100D:EFDB pop AX
100D:EFDC jmp far 0800:0006
100D:EFE7 push AX
100D:EFE8 push CX
100D:EFE9 push DI
100D:EFEA push DS
100D:EFEB mov AX,0x1F58
100D:EFEE mov DS,AX
100D:EFF0 cld
100D:EFF1 in AL,0x60
100D:EFF3 cmp AL,0xFF
100D:EFF5 je short 0xEFE1
100D:EFF7 mov DI,AX
100D:EFF9 and DI,0x007F
100D:EFFC cmp DI,0x005A
100D:EFFF jae short 0xF031
100D:F001 add DI,0xCE81
100D:F005 cbw
100D:F006 not AH
100D:F008 xchg AL,AH
100D:F00A mov byte ptr DS:[DI],AL
100D:F00C or AL,AL
100D:F00E je short 0xF031
100D:F010 mov AL,AH
100D:F012 mov byte ptr DS:[0xCEE8],AL
100D:F015 cmp AL,0x53
100D:F017 jne short 0xF026
100D:F026 cmp AL,0x2E
100D:F028 jne short 0xF031
100D:F031 cmp AL,0x70
100D:F033 jae short 0xF049
100D:F035 in AL,0x61
100D:F037 or AL,0x80
100D:F039 out 0x61,AL
100D:F03B and AL,0x7F
100D:F03D out 0x61,AL
100D:F03F mov AL,0x20
100D:F041 cli
100D:F042 out 0x20,AL
100D:F044 pop DS
100D:F045 pop DI
100D:F046 pop CX
100D:F047 pop AX
100D:F048 iret
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
100D:F12B call near 0xF13F
100D:F12E jmp short 0xF11C
100D:F13F push CX
100D:F140 mov BP,word ptr DS:[2]
100D:F144 mov SI,0xD844
100D:F147 mov DI,0xDA8C
100D:F14A mov CX,0x0091
100D:F14D xor DX,DX
100D:F14F mov BX,DX
100D:F151 add DI,2
100D:F154 add SI,4
100D:F157 mov AX,word ptr DS:[SI+2]
100D:F15A or AX,AX
100D:F15C je short 0xF16A
100D:F15E mov AX,BP
100D:F160 sub AX,word ptr DS:[DI]
100D:F162 cmp AX,DX
100D:F164 jb short 0xF16A
100D:F166 mov DX,AX
100D:F168 mov BX,SI
100D:F16A loop 0xF151
100D:F16C or BX,BX
100D:F16E je short 0xF130
100D:F170 mov AX,BX
100D:F172 sub AX,0xD844
100D:F175 shr AX,1
100D:F177 shr AX,1
100D:F179 cmp AX,word ptr DS:[0x2784]
100D:F17D jne short 0xF185
100D:F185 xor DX,DX
100D:F187 xchg DX,word ptr DS:[BX+2]
100D:F18A mov SI,0xD84A
100D:F18D mov CX,0x0091
100D:F190 mov BX,0x8000
100D:F193 lods AX,word ptr DS:[SI]
100D:F194 add SI,2
100D:F197 sub AX,DX
100D:F199 jb short 0xF1A1
100D:F19B cmp AX,BX
100D:F19D jae short 0xF1A1
100D:F19F mov BX,AX
100D:F1A1 loop 0xF193
100D:F1A3 or BX,BX
100D:F1A5 js short 0xF1F5
100D:F1A7 mov SI,0xD846
100D:F1AA mov CX,0x0091
100D:F1AD add SI,4
100D:F1B0 cmp word ptr DS:[SI],DX
100D:F1B2 jb short 0xF1B6
100D:F1B4 sub word ptr DS:[SI],BX
100D:F1B6 loop 0xF1AD
100D:F1B8 mov SI,0xDBB2
100D:F1BB cmp word ptr DS:[SI],DX
100D:F1BD jb short 0xF1C1
100D:F1BF sub word ptr DS:[SI],BX
100D:F1C1 mov ES,DX
100D:F1C3 add DX,BX
100D:F1C5 mov DS,DX
100D:F1C7 xor SI,SI
100D:F1C9 mov DI,SI
100D:F1CB mov AX,word ptr SS:[0x39B9]
100D:F1CF sub AX,DX
100D:F1D1 cmp AX,0x1000
100D:F1D4 jbe short 0xF1E3
100D:F1D6 mov CX,0x8000
100D:F1D9 rep movs word ptr ES:[DI],word ptr DS:[SI]
100D:F1DB mov DX,ES
100D:F1DD add DX,0x1000
100D:F1E1 jmp short 0xF1C1
100D:F1E3 mov CX,AX
100D:F1E5 shl CX,1
100D:F1E7 shl CX,1
100D:F1E9 shl CX,1
100D:F1EB rep movs word ptr ES:[DI],word ptr DS:[SI]
100D:F1ED push SS
100D:F1EE pop DS
100D:F1EF sub word ptr DS:[0x39B9],BX
100D:F1F3 pop CX
100D:F1F4 ret near
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
100D:F244 push DX
100D:F245 call near 0xF229
100D:F248 pop DX
100D:F249 cmp BX,word ptr DS:[0xDBBA]
100D:F24D jne short 0xF260
100D:F24F call near 0xF2EA
100D:F252 jb short 0xF244
100D:F254 ret near
100D:F27C push CX
100D:F27D mov AH,0x3C
100D:F27F xor CX,CX
100D:F281 int 0x21
100D:F283 pop CX
100D:F284 jb short 0xF29A
100D:F286 mov BX,AX
100D:F288 push DS
100D:F289 push ES
100D:F28A pop DS
100D:F28B mov DX,DI
100D:F28D mov AH,0x40
100D:F28F int 0x21
100D:F291 pop DS
100D:F292 sub AX,CX
100D:F294 pushf
100D:F295 mov AH,0x3E
100D:F297 int 0x21
100D:F299 popf
100D:F29A ret near
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
3358:0106 jmp near 0x09E2
3358:0109 jmp near 0x1888
3358:010C jmp near 0x1940
3358:010F jmp near 0x0F5B
3358:0112 jmp near 0x1452
3358:0115 jmp near 0x1BF5
3358:0118 jmp near 0x19F7
3358:011B jmp near 0x1979
3358:011E jmp near 0x197B
3358:0121 jmp near 0x1B7C
3358:0124 jmp near 0x1B8E
3358:012A jmp near 0x1B8C
3358:012D jmp near 0x1B7C
3358:0130 jmp near 0x1B8E
3358:0136 jmp near 0x1BE7
3358:0139 jmp near 0x1A07
3358:013C ret far
3358:0142 jmp near 0x23EB
3358:014B jmp near 0x1C46
3358:0151 jmp near 0x25E7
3358:0154 jmp near 0x0975
3358:015A jmp near 0x3200
3358:0160 jmp near 0x0B0C
3358:0163 jmp near 0x0C06
3358:0169 jmp near 0x0D85
3358:016C jmp near 0x39E9
3358:016F jmp near 0x3A14
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
3358:09E2 push AX
3358:09E3 push BX
3358:09E4 push CX
3358:09E5 push SI
3358:09E6 push DI
3358:09E7 push DS
3358:09E8 push ES
3358:09E9 push ES
3358:09EA pop DS
3358:09EB push CS
3358:09EC pop ES
3358:09ED mov DI,0x05BF
3358:09F0 add DI,BX
3358:09F2 mov AX,CX
3358:09F4 mov SI,DX
3358:09F6 repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
3358:09F8 je short 0x0A19
3358:09FA mov byte ptr CS:[0x01BE],1
3358:0A00 mov DI,0x05BF
3358:0A03 add DI,BX
3358:0A05 mov SI,DX
3358:0A07 mov CX,AX
3358:0A09 push CX
3358:0A0A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:0A0C pop CX
3358:0A0D call near 0x0A21
3358:0A10 mov DI,0x01BF
3358:0A13 add DI,BX
3358:0A15 mov AL,1
3358:0A17 rep stos byte ptr ES:[DI],AL
3358:0A19 pop ES
3358:0A1A pop DS
3358:0A1B pop DI
3358:0A1C pop SI
3358:0A1D pop CX
3358:0A1E pop BX
3358:0A1F pop AX
3358:0A20 ret far
3358:0A21 push DX
3358:0A22 mov AX,BX
3358:0A24 mov DL,3
3358:0A26 div DL
3358:0A28 xor AH,AH
3358:0A2A mov BX,AX
3358:0A2C mov AX,CX
3358:0A2E cmp AX,0x0300
3358:0A31 jae short 0x0A3B
3358:0A33 div DL
3358:0A35 xor AH,AH
3358:0A37 mov CX,AX
3358:0A39 pop DX
3358:0A3A ret near
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
3358:0B39 inc CX
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
3358:0C10 cmp BX,0x00C8
3358:0C14 jb short 0x0C19
3358:0C19 xchg BH,BL
3358:0C1B mov DI,BX
3358:0C1D shr DI,1
3358:0C1F shr DI,1
3358:0C21 add DI,BX
3358:0C23 xchg BH,BL
3358:0C25 add DI,DX
3358:0C27 add DI,word ptr CS:[0x01A3]
3358:0C2C ret near
3358:0C3B mov BP,word ptr [0x000341BC]
3358:0C3E sub DI,BP
3358:0C40 sub DI,BP
3358:0C42 selector
3358:0C42 sub DI,0x0140
3358:0C42 add DI,0x0140
3358:0C46 lods AL,byte ptr DS:[SI]
3358:0C47 or AL,AL
3358:0C49 js short 0x0C85
3358:0C4B mov CX,AX
3358:0C4D xor CH,CH
3358:0C4F inc CX
3358:0C50 sub BP,CX
3358:0C52 lods AL,byte ptr DS:[SI]
3358:0C53 mov AH,AL
3358:0C55 and AL,DL
3358:0C57 je short 0x0C7B
3358:0C59 add AL,DH
3358:0C5B stos byte ptr ES:[DI],AL
3358:0C5C shr AH,1
3358:0C5E shr AH,1
3358:0C60 shr AH,1
3358:0C62 shr AH,1
3358:0C64 je short 0x0C80
3358:0C66 mov AL,AH
3358:0C68 add AL,DH
3358:0C6A stos byte ptr ES:[DI],AL
3358:0C6B loop 0x0C52
3358:0C6D or BP,BP
3358:0C6F ja short 0x0C46
3358:0C71 dec BX
3358:0C72 jne short 0x0C3B
3358:0C74 mov byte ptr CS:[0x0C43],0xC7
3358:0C7A ret far
3358:0C7B inc DI
3358:0C7C shr AH,1
3358:0C7E jne short 0x0C5E
3358:0C80 inc DI
3358:0C81 loop 0x0C52
3358:0C83 jmp short 0x0C6D
3358:0C85 mov CX,0x0101
3358:0C88 xor AH,AH
3358:0C8A sub CX,AX
3358:0C8C sub BP,CX
3358:0C8E lods AL,byte ptr DS:[SI]
3358:0C8F shl AX,1
3358:0C91 je short 0x0CB6
3358:0C93 shl AX,1
3358:0C95 shl AX,1
3358:0C97 shl AX,1
3358:0C99 shr AL,1
3358:0C9B je short 0x0CC0
3358:0C9D shr AL,1
3358:0C9F shr AL,1
3358:0CA1 shr AL,1
3358:0CA3 add AL,DH
3358:0CA5 or AH,AH
3358:0CA7 je short 0x0CCF
3358:0CA9 add AH,DH
3358:0CAB rep stos word ptr ES:[DI],AX
3358:0CAD or BP,BP
3358:0CAF ja short 0x0C46
3358:0CB1 dec BX
3358:0CB2 jne short 0x0C3B
3358:0CB6 shl CX,1
3358:0CB8 add DI,CX
3358:0CBA or BP,BP
3358:0CBC ja short 0x0C46
3358:0CBE jmp short 0x0CB1
3358:0CC0 mov AL,AH
3358:0CC2 add AL,DH
3358:0CC4 inc DI
3358:0CC5 stos byte ptr ES:[DI],AL
3358:0CC6 loop 0x0CC4
3358:0CC8 or BP,BP
3358:0CCA jbe short 0x0CB1
3358:0CCC jmp near 0x0C46
3358:0CCF stos byte ptr ES:[DI],AL
3358:0CD0 inc DI
3358:0CD1 loop 0x0CCF
3358:0CD3 jmp short 0x0CAD
3358:0CD5 mov BP,word ptr [0x00034256]
3358:0CD8 add DI,BP
3358:0CDA add DI,BP
3358:0CDC selector
3358:0CDC sub DI,0x0140
3358:0CDC add DI,0x0140
3358:0CE0 mov AL,byte ptr DS:[SI]
3358:0CE2 inc SI
3358:0CE3 or AL,AL
3358:0CE5 js short 0x0D51
3358:0CE7 mov CX,AX
3358:0CE9 xor CH,CH
3358:0CEB inc CX
3358:0CEC sub BP,CX
3358:0CEE mov AL,byte ptr DS:[SI]
3358:0CF0 inc SI
3358:0CF1 mov AH,AL
3358:0CF3 and AL,DL
3358:0CF5 je short 0x0D1A
3358:0CF7 add AL,DH
3358:0CF9 stos byte ptr ES:[DI],AL
3358:0CFA shr AH,1
3358:0CFC shr AH,1
3358:0CFE shr AH,1
3358:0D00 shr AH,1
3358:0D02 je short 0x0D1F
3358:0D04 mov AL,AH
3358:0D06 add AL,DH
3358:0D08 stos byte ptr ES:[DI],AL
3358:0D09 loop 0x0CEE
3358:0D0B or BP,BP
3358:0D0D ja short 0x0CE0
3358:0D0F dec BX
3358:0D10 jne short 0x0CD5
3358:0D12 cld
3358:0D13 mov byte ptr CS:[0x0CDD],0xC7
3358:0D19 ret far
3358:0D1A dec DI
3358:0D1B shr AH,1
3358:0D1D jne short 0x0CFC
3358:0D1F dec DI
3358:0D20 loop 0x0CEE
3358:0D22 jmp short 0x0D0B
3358:0D24 shl CX,1
3358:0D26 sub DI,CX
3358:0D28 or BP,BP
3358:0D2A ja short 0x0CE0
3358:0D2C jmp short 0x0D46
3358:0D2F mov AL,AH
3358:0D31 add AL,DH
3358:0D33 dec DI
3358:0D34 stos byte ptr ES:[DI],AL
3358:0D35 loop 0x0D33
3358:0D37 or BP,BP
3358:0D39 ja short 0x0CE0
3358:0D3E stos byte ptr ES:[DI],AL
3358:0D3F dec DI
3358:0D40 loop 0x0D3E
3358:0D42 or BP,BP
3358:0D44 ja short 0x0CE0
3358:0D46 dec BX
3358:0D47 jne short 0x0CD5
3358:0D49 cld
3358:0D4A mov byte ptr CS:[0x0CDD],0xC7
3358:0D50 ret far
3358:0D51 mov CX,0x0101
3358:0D54 xor AH,AH
3358:0D56 sub CX,AX
3358:0D58 sub BP,CX
3358:0D5A mov AL,byte ptr DS:[SI]
3358:0D5C inc SI
3358:0D5D shl AX,1
3358:0D5F je short 0x0D24
3358:0D61 shl AX,1
3358:0D63 shl AX,1
3358:0D65 shl AX,1
3358:0D67 shr AL,1
3358:0D69 je short 0x0D2F
3358:0D6B shr AL,1
3358:0D6D shr AL,1
3358:0D6F shr AL,1
3358:0D71 add AL,DH
3358:0D73 or AH,AH
3358:0D75 je short 0x0D3E
3358:0D77 add AH,DH
3358:0D79 dec DI
3358:0D7A xchg AH,AL
3358:0D7C rep stos word ptr ES:[DI],AX
3358:0D7E inc DI
3358:0D7F jmp short 0x0D42
3358:0D85 mov byte ptr CS:[0x019E],CH
3358:0D8A xor CH,CH
3358:0D8C and AX,0x03FF
3358:0D8F mov word ptr CS:[0x0D81],AX
3358:0D93 mov AX,DI
3358:0D95 and DI,0x01FF
3358:0D99 add DI,3
3358:0D9C shr DI,1
3358:0D9E shr DI,1
3358:0DA0 shl DI,1
3358:0DA2 mov word ptr CS:[0x0DDE],DI
3358:0DA7 mov byte ptr CS:[0x0E13],0xC7
3358:0DAD test AX,0x2000
3358:0DB0 je short 0x0DBB
3358:0DB2 mov byte ptr CS:[0x0E13],0xEF
3358:0DB8 add BX,CX
3358:0DBA dec BX
3358:0DBB mov byte ptr CS:[0x0E26],0x47
3358:0DC1 test AX,0x4000
3358:0DC4 je short 0x0DD3
3358:0DC6 mov byte ptr CS:[0x0E26],0x4F
3358:0DCC add DX,word ptr CS:[0x0D81]
3358:0DD1 dec DX
3358:0DD2 std
3358:0DD3 call near 0x0C10
3358:0DD6 xor BX,BX
3358:0DD8 mov word ptr CS:[0x0D83],BX
3358:0DDD mov AX,word ptr [0x0003435E]
3358:0DE0 push SI
3358:0DE1 mul BH
3358:0DE3 add SI,AX
3358:0DE5 push DI
3358:0DE6 push CX
3358:0DE7 xor DX,DX
3358:0DE9 mov BX,SI
3358:0DEB mov CX,word ptr CS:[0x0D81]
3358:0DF0 mov AH,byte ptr CS:[0x019E]
3358:0DF5 mov AL,DH
3358:0DF7 shr AL,1
3358:0DF9 xlat byte ptr DS:[BX+AL]
3358:0DFA jae short 0x0E04
3358:0DFC shr AL,1
3358:0DFE shr AL,1
3358:0E00 shr AL,1
3358:0E02 shr AL,1
3358:0E04 and AL,0x0F
3358:0E06 je short 0x0E26
3358:0E08 add AL,AH
3358:0E0A stos byte ptr ES:[DI],AL
3358:0E0B add DX,BP
3358:0E0D loop 0x0DF5
3358:0E0F pop CX
3358:0E10 pop DI
3358:0E11 pop SI
3358:0E12 selector
3358:0E12 sub DI,0x0140
3358:0E12 add DI,0x0140
3358:0E16 mov BX,word ptr CS:[0x0D83]
3358:0E1B add BX,BP
3358:0E1D mov word ptr CS:[0x0D83],BX
3358:0E22 loop 0x0DDD
3358:0E24 cld
3358:0E25 ret far
3358:0E26 selector
3358:0E26 inc DI
3358:0E26 dec DI
3358:0E27 add DX,BP
3358:0E29 loop 0x0DF5
3358:0E2B jmp short 0x0E0F
3358:0E2D mov BP,DX
3358:0E2F sub DI,BP
3358:0E31 add DI,0x0140
3358:0E35 lods AL,byte ptr DS:[SI]
3358:0E36 or AL,AL
3358:0E38 js short 0x0E6A
3358:0E3A mov CX,AX
3358:0E3C xor CH,CH
3358:0E3E inc CX
3358:0E3F sub BP,CX
3358:0E41 lods AL,byte ptr DS:[SI]
3358:0E42 or AL,AL
3358:0E44 je short 0x0E5E
3358:0E46 stos byte ptr ES:[DI],AL
3358:0E47 loop 0x0E41
3358:0E49 or BP,BP
3358:0E4B ja short 0x0E35
3358:0E4D dec BX
3358:0E4E jne short 0x0E2D
3358:0E50 cld
3358:0E51 mov byte ptr CS:[0x0E32],0xC7
3358:0E57 mov byte ptr CS:[0x0EF0],0xC7
3358:0E5D ret far
3358:0E6A mov CX,0x0101
3358:0E6D xor AH,AH
3358:0E6F sub CX,AX
3358:0E71 sub BP,CX
3358:0E73 lods AL,byte ptr DS:[SI]
3358:0E74 or AL,AL
3358:0E76 je short 0x0E83
3358:0E78 rep stos byte ptr ES:[DI],AL
3358:0E7A or BP,BP
3358:0E7C ja short 0x0E35
3358:0E7E dec BX
3358:0E7F jne short 0x0E2D
3358:0E81 jmp short 0x0E50
3358:0F5B cmp CH,0xFE
3358:0F5E jb short 0x0F63
3358:0F60 jmp near 0x100A
3358:0F63 or DI,DI
3358:0F65 js short 0x0F8E
3358:0F67 mov AX,DI
3358:0F69 mov BP,0x0100
3358:0F6C test AX,0x6000
3358:0F6F je short 0x0F74
3358:0F71 jmp near 0x0D85
3358:0F74 and AX,0x01FF
3358:0F77 add AX,3
3358:0F7A shr AX,1
3358:0F7C shr AX,1
3358:0F7E mov word ptr CS:[0x158B],AX
3358:0F82 call near 0x0C10
3358:0F85 mov DH,CH
3358:0F87 xor CH,CH
3358:0F89 mov DL,0x0F
3358:0F8B jmp near 0x158A
3358:0F8E mov AX,DI
3358:0F90 and AX,0x01FF
3358:0F93 mov word ptr CS:[0x0D81],AX
3358:0F97 add AX,3
3358:0F9A shr AX,1
3358:0F9C shr AX,1
3358:0F9E shl AX,1
3358:0FA0 mov BP,AX
3358:0FA2 mov AX,DI
3358:0FA4 call near 0x0C10
3358:0FA7 mov DH,CH
3358:0FA9 xor CH,CH
3358:0FAB mov DL,0x0F
3358:0FAD mov BX,CX
3358:0FAF test AX,0x4000
3358:0FB2 jne short 0x0FD9
3358:0FB4 mov word ptr CS:[0x0C3C],BP
3358:0FB9 test AX,0x2000
3358:0FBC je short 0x0FD6
3358:0FBE mov byte ptr CS:[0x0C43],0xEF
3358:0FC4 mov AH,BL
3358:0FC6 dec AH
3358:0FC8 mov CH,AH
3358:0FCA xor CL,CL
3358:0FCC mov AL,CL
3358:0FCE shr CX,1
3358:0FD0 shr CX,1
3358:0FD2 add DI,AX
3358:0FD4 add DI,CX
3358:0FD6 jmp near 0x0C46
3358:0FD9 mov word ptr CS:[0x0CD6],BP
3358:0FDE test AX,0x2000
3358:0FE1 je short 0x0FFB
3358:0FE3 mov byte ptr CS:[0x0CDD],0xEF
3358:0FE9 mov AH,BL
3358:0FEB dec AH
3358:0FED mov CH,AH
3358:0FEF xor CL,CL
3358:0FF1 mov AL,CL
3358:0FF3 shr CX,1
3358:0FF5 shr CX,1
3358:0FF7 add DI,AX
3358:0FF9 add DI,CX
3358:0FFB add DI,word ptr CS:[0x0D81]
3358:1000 dec DI
3358:1001 std
3358:1002 jmp near 0x0CE0
3358:100A or DI,DI
3358:100C js short 0x1064
3358:1064 mov BP,DI
3358:1066 and BP,0x01FF
3358:106A mov AX,DI
3358:106C call near 0x0C10
3358:106F mov BX,CX
3358:1071 xor BH,BH
3358:1073 test AX,0x4000
3358:1076 jne short 0x10A8
3358:1078 test AX,0x2000
3358:107B je short 0x109B
3358:109B mov DX,BP
3358:109D cmp CH,0xFF
3358:10A0 je short 0x10A5
3358:10A5 jmp near 0x0E35
3358:11EE mov BP,word ptr CS:[0x10DE]
3358:11F3 or BP,BP
3358:11F5 jne short 0x11FF
3358:11F7 mov BP,word ptr CS:[0x10E0]
3358:11FC jmp short 0x1266
3358:11FF shr BP,1
3358:1201 pushf
3358:1202 jcxz short 0x120C
3358:120A add SI,CX
3358:120C lods AL,byte ptr DS:[SI]
3358:120D xor AH,AH
3358:120F mov DL,AL
3358:1211 or AL,AL
3358:1213 js short 0x122F
3358:1215 mov CX,AX
3358:1217 inc CX
3358:1218 sub BP,CX
3358:121A jae short 0x120A
3358:121C add CX,BP
3358:121E add SI,CX
3358:1220 mov CX,BP
3358:1222 neg CX
3358:1224 mov BP,word ptr CS:[0x10E0]
3358:1229 popf
3358:122A jae short 0x1266
3358:122C lods AL,byte ptr DS:[SI]
3358:122D jmp short 0x124A
3358:122F mov CX,0x0101
3358:1232 sub CX,AX
3358:1234 inc SI
3358:1235 sub BP,CX
3358:1237 jae short 0x120C
3358:1239 xor AH,AH
3358:123B mov CX,BP
3358:123D neg CX
3358:123F mov BP,word ptr CS:[0x10E0]
3358:1244 popf
3358:1245 jae short 0x1266
3358:1247 mov AL,byte ptr DS:[SI-1]
3358:124A shr AL,1
3358:124C shr AL,1
3358:124E shr AL,1
3358:1250 shr AL,1
3358:1252 je short 0x1259
3358:1254 add AL,DH
3358:1256 mov byte ptr ES:[DI],AL
3358:1259 inc DI
3358:125A dec CX
3358:125B dec BP
3358:125C jne short 0x1266
3358:1266 shr BP,1
3358:1268 pushf
3358:1269 jcxz short 0x1272
3358:126B or DL,DL
3358:126D jns short 0x127E
3358:126F jmp short 0x12C7
3358:1272 lods AL,byte ptr DS:[SI]
3358:1273 xor AH,AH
3358:1275 mov DL,AL
3358:1277 or AL,AL
3358:1279 js short 0x12C1
3358:127B mov CX,AX
3358:127D inc CX
3358:127E sub BP,CX
3358:1280 jae short 0x1286
3358:1282 add CX,BP
3358:1284 je short 0x12A1
3358:1286 lods AL,byte ptr DS:[SI]
3358:1287 mov AH,AL
3358:1289 and AL,0x0F
3358:128B je short 0x12B7
3358:128D add AL,DH
3358:128F stos byte ptr ES:[DI],AL
3358:1290 shr AH,1
3358:1292 shr AH,1
3358:1294 shr AH,1
3358:1296 shr AH,1
3358:1298 je short 0x12BC
3358:129A mov AL,AH
3358:129C add AL,DH
3358:129E stos byte ptr ES:[DI],AL
3358:129F loop 0x1286
3358:12A1 or BP,BP
3358:12A3 jns short 0x1272
3358:12A5 mov CX,BP
3358:12A7 neg CX
3358:12A9 mov BP,word ptr CS:[0x10DC]
3358:12AE xor AH,AH
3358:12B0 popf
3358:12B1 jae short 0x132C
3358:12B3 lods AL,byte ptr DS:[SI]
3358:12B4 jmp short 0x131E
3358:12B7 inc DI
3358:12B8 shr AH,1
3358:12BA jne short 0x1292
3358:12BC inc DI
3358:12BD loop 0x1286
3358:12BF jmp short 0x12A1
3358:12C1 mov CX,0x0101
3358:12C4 sub CX,AX
3358:12C6 inc SI
3358:12C7 sub BP,CX
3358:12C9 jae short 0x12CF
3358:12CB add CX,BP
3358:12CD je short 0x1306
3358:12CF mov AL,byte ptr DS:[SI-1]
3358:12D2 shl AX,1
3358:12D4 je short 0x12F2
3358:12D6 shl AX,1
3358:12D8 shl AX,1
3358:12DA shl AX,1
3358:12DC shr AL,1
3358:12DE je short 0x12F8
3358:12E0 shr AL,1
3358:12E2 shr AL,1
3358:12E4 shr AL,1
3358:12E6 add AL,DH
3358:12E8 or AH,AH
3358:12EA je short 0x1302
3358:12EC add AH,DH
3358:12EE rep stos word ptr ES:[DI],AX
3358:12F0 jmp short 0x1306
3358:12F2 shl CX,1
3358:12F4 add DI,CX
3358:12F6 jmp short 0x1306
3358:1306 or BP,BP
3358:1308 js short 0x130D
3358:130A jmp near 0x1272
3358:130D xor AH,AH
3358:130F mov CX,BP
3358:1311 neg CX
3358:1313 mov BP,word ptr CS:[0x10DC]
3358:1318 popf
3358:1319 jae short 0x132C
3358:131B mov AL,byte ptr DS:[SI-1]
3358:131E and AL,0x0F
3358:1320 je short 0x1327
3358:1322 add AL,DH
3358:1324 mov byte ptr ES:[DI],AL
3358:1327 inc DI
3358:1328 dec CX
3358:1329 dec BP
3358:132A je short 0x1362
3358:132C shr BP,1
3358:132E jcxz short 0x1338
3358:1330 or DL,DL
3358:1332 js short 0x1358
3358:1334 jmp short 0x1344
3358:1336 add SI,CX
3358:1338 lods AL,byte ptr DS:[SI]
3358:1339 xor AH,AH
3358:133B mov DL,AL
3358:133D or AL,AL
3358:133F js short 0x1352
3358:1341 mov CX,AX
3358:1343 inc CX
3358:1344 sub BP,CX
3358:1346 jae short 0x1336
3358:1348 add CX,BP
3358:134A add SI,CX
3358:134C mov CX,BP
3358:134E neg CX
3358:1350 jmp short 0x1362
3358:1352 mov CX,0x0101
3358:1355 sub CX,AX
3358:1357 inc SI
3358:1358 sub BP,CX
3358:135A jae short 0x1338
3358:135C xor AH,AH
3358:135E mov CX,BP
3358:1360 neg CX
3358:1362 sub DI,word ptr CS:[0x10E0]
3358:1367 add DI,0x0140
3358:136B dec BX
3358:136C je short 0x1371
3358:136E jmp near 0x11EE
3358:1371 ret far
3358:1372 mov AL,byte ptr DS:[SI-1]
3358:1375 mov byte ptr CS:[0x019E],AL
3358:1379 and DI,0x1FFF
3358:137D mov word ptr CS:[0x158B],DI
3358:1382 add DI,3
3358:1385 shr DI,1
3358:1387 shr DI,1
3358:1389 shl DI,1
3358:138B mov AX,word ptr SS:[BP+2]
3358:138E sub AX,BX
3358:1390 jle short 0x13BE
3358:1392 sub CX,AX
3358:1394 jbe short 0x13F1
3358:1396 add BX,AX
3358:1398 push DX
3358:1399 push CX
3358:139A push BP
3358:139B mul DI
3358:139D mov BP,AX
3358:139F xor AH,AH
3358:13A1 lods AL,byte ptr DS:[SI]
3358:13A2 or AL,AL
3358:13A4 js short 0x13B1
3358:13A6 mov CX,AX
3358:13A8 inc CX
3358:13A9 add SI,CX
3358:13AB sub BP,CX
3358:13AD jne short 0x13A1
3358:13AF jmp short 0x13BB
3358:13B1 mov CX,0x0101
3358:13B4 sub CX,AX
3358:13B6 inc SI
3358:13B7 sub BP,CX
3358:13B9 jne short 0x13A1
3358:13BB pop BP
3358:13BC pop CX
3358:13BD pop DX
3358:13BE mov AX,BX
3358:13C0 add AX,CX
3358:13C2 sub AX,word ptr SS:[BP+6]
3358:13C5 jbe short 0x13CB
3358:13C7 sub CX,AX
3358:13C9 jbe short 0x13F1
3358:13CB mov AX,DX
3358:13CD add AX,DI
3358:13CF add AX,DI
3358:13D1 sub AX,word ptr SS:[BP+4]
3358:13D4 jg short 0x1419
3358:13D6 mov AX,word ptr SS:[BP]
3358:13D9 sub AX,DX
3358:13DB jg short 0x13F2
3358:13DD mov word ptr CS:[0x0C3C],DI
3358:13E2 mov BP,DI
3358:13E4 call near 0x0C10
3358:13E7 mov BX,CX
3358:13E9 mov DX,word ptr CS:[0x019D]
3358:13EE jmp near 0x0C46
3358:13F1 ret far
3358:1419 shl DI,1
3358:141B sub DI,AX
3358:141D jle short 0x13F1
3358:141F mov word ptr CS:[0x10DC],AX
3358:1423 mov word ptr CS:[0x10DE],0
3358:142A mov AX,word ptr SS:[BP]
3358:142D sub AX,DX
3358:142F jle short 0x143B
3358:1431 mov word ptr CS:[0x10DE],AX
3358:1435 sub DI,AX
3358:1437 jle short 0x13F1
3358:1439 add DX,AX
3358:143B mov word ptr CS:[0x10E0],DI
3358:1440 call near 0x0C10
3358:1443 mov DX,word ptr CS:[0x019D]
3358:1448 mov BX,CX
3358:144A xor CX,CX
3358:144C jmp near 0x11EE
3358:1452 cmp CH,0xFE
3358:1455 jae short 0x144F
3358:1457 or DI,DI
3358:1459 jns short 0x145E
3358:145B jmp near 0x1372
3358:145E mov AL,byte ptr DS:[SI-1]
3358:1461 mov byte ptr CS:[0x019E],AL
3358:1465 mov word ptr CS:[0x158B],DI
3358:146A add DI,3
3358:146D shr DI,1
3358:146F shr DI,1
3358:1471 shl DI,1
3358:1473 mov AX,word ptr SS:[BP+2]
3358:1476 sub AX,BX
3358:1478 jle short 0x1485
3358:1485 mov AX,BX
3358:1487 add AX,CX
3358:1489 sub AX,word ptr SS:[BP+6]
3358:148C jbe short 0x1492
3358:148E sub CX,AX
3358:1490 jbe short 0x14B8
3358:1492 mov AX,DX
3358:1494 add AX,word ptr CS:[0x158B]
3358:1499 sub AX,word ptr SS:[BP+4]
3358:149C jg short 0x14FD
3358:149E mov AX,word ptr SS:[BP]
3358:14A1 sub AX,DX
3358:14A3 jg short 0x14B9
3358:14A5 mov AX,DI
3358:14A7 shr AX,1
3358:14A9 mov word ptr CS:[0x158B],AX
3358:14AD call near 0x0C10
3358:14B0 mov DX,word ptr CS:[0x019D]
3358:14B5 jmp near 0x158A
3358:14B8 ret far
3358:158A mov BP,word ptr [0x00034B0B]
3358:158D push DI
3358:158E lods AX,word ptr DS:[SI]
3358:158F mov BL,AL
3358:1591 and AL,DL
3358:1593 je short 0x15CA
3358:1595 add AL,DH
3358:1597 stos byte ptr ES:[DI],AL
3358:1598 shr BL,1
3358:159A shr BL,1
3358:159C shr BL,1
3358:159E shr BL,1
3358:15A0 je short 0x15D9
3358:15A2 mov AL,BL
3358:15A4 add AL,DH
3358:15A6 stos byte ptr ES:[DI],AL
3358:15A7 mov AL,AH
3358:15A9 and AL,DL
3358:15AB je short 0x15EE
3358:15AD add AL,DH
3358:15AF stos byte ptr ES:[DI],AL
3358:15B0 shr AH,1
3358:15B2 shr AH,1
3358:15B4 shr AH,1
3358:15B6 shr AH,1
3358:15B8 je short 0x15F5
3358:15BA mov AL,AH
3358:15BC add AL,DH
3358:15BE stos byte ptr ES:[DI],AL
3358:15BF dec BP
3358:15C0 jne short 0x158E
3358:15C2 pop DI
3358:15C3 add DI,0x0140
3358:15C7 loop 0x158A
3358:15C9 ret far
3358:15CA inc DI
3358:15CB or AL,BL
3358:15CD je short 0x15D9
3358:15CF shr AL,1
3358:15D1 shr AL,1
3358:15D3 shr AL,1
3358:15D5 shr AL,1
3358:15D7 jmp short 0x15A4
3358:15D9 inc DI
3358:15DA mov AL,AH
3358:15DC or AL,AL
3358:15DE jne short 0x15A9
3358:15E0 add DI,2
3358:15E3 dec BP
3358:15E4 jne short 0x158E
3358:15E6 pop DI
3358:15E7 add DI,0x0140
3358:15EB loop 0x158A
3358:15ED ret far
3358:15EE shr AH,1
3358:15F0 je short 0x15E0
3358:15F2 inc DI
3358:15F3 jmp short 0x15B2
3358:15F5 inc DI
3358:15F6 dec BP
3358:15F7 jne short 0x158E
3358:15F9 jmp short 0x15E6
3358:1888 lods AX,word ptr DS:[SI]
3358:1889 sub DX,AX
3358:188B jae short 0x188F
3358:188F lods AX,word ptr DS:[SI]
3358:1890 sub BX,AX
3358:1892 jae short 0x1896
3358:1896 mov CX,0x0010
3358:1899 cmp BX,0x00B8
3358:189D jbe short 0x18A4
3358:189F mov CX,0x00C8
3358:18A2 sub CX,BX
3358:18A4 call near 0x0C10
3358:18A7 mov AX,0xA000
3358:18AA mov ES,AX
3358:18AC sub DX,0x0140
3358:18B0 neg DX
3358:18B2 cmp DX,0x0010
3358:18B5 jbe short 0x18BA
3358:18B7 mov DX,0x0010
3358:18BA mov word ptr CS:[0x018C],DX
3358:18BF mov word ptr CS:[0x018E],CX
3358:18C4 mov word ptr CS:[0x018A],DI
3358:18C9 mov BX,0xFA00
3358:18CC shr DX,1
3358:18CE mov word ptr CS:[0x0190],DX
3358:18D3 mov word ptr CS:[0x0192],CX
3358:18D8 mov CX,word ptr CS:[0x0190]
3358:18DD mov BP,word ptr DS:[SI+0x20]
3358:18E0 lods AX,word ptr DS:[SI]
3358:18E1 mov DX,AX
3358:18E3 jcxz short 0x1911
3358:18E5 mov AX,word ptr ES:[DI]
3358:18E8 mov word ptr ES:[BX],AX
3358:18EB add BX,2
3358:18EE rol BP,1
3358:18F0 add DX,DX
3358:18F2 jb short 0x18FE
3358:18F4 xor AL,AL
3358:18F6 test BP,1
3358:18FA je short 0x18FE
3358:18FC mov AL,0x0F
3358:18FE rol BP,1
3358:1900 add DX,DX
3358:1902 jb short 0x190E
3358:1904 xor AH,AH
3358:1906 test BP,1
3358:190A je short 0x190E
3358:190C mov AH,0x0F
3358:190E stos word ptr ES:[DI],AX
3358:190F loop 0x18E5
3358:1911 test byte ptr CS:[0x018C],1
3358:1917 je short 0x192F
3358:1919 mov AL,byte ptr ES:[DI]
3358:191C mov byte ptr ES:[BX],AL
3358:191F inc BX
3358:1920 inc DI
3358:1921 add DX,DX
3358:1923 jb short 0x192F
3358:1925 xor AL,AL
3358:1927 add BP,BP
3358:1929 jae short 0x192D
3358:192B mov AL,0x0F
3358:192D dec DI
3358:192E stos byte ptr ES:[DI],AL
3358:192F sub DI,word ptr CS:[0x018C]
3358:1934 add DI,0x0140
3358:1938 dec word ptr CS:[0x0192]
3358:193D jne short 0x18D8
3358:193F ret far
3358:1940 push AX
3358:1941 push BX
3358:1942 push CX
3358:1943 push DX
3358:1944 push SI
3358:1945 push DI
3358:1946 push BP
3358:1947 push DS
3358:1948 push ES
3358:1949 mov BP,word ptr CS:[0x018A]
3358:194E mov BX,word ptr CS:[0x018C]
3358:1953 mov DX,word ptr CS:[0x018E]
3358:1958 mov AX,0xA000
3358:195B mov ES,AX
3358:195D mov DS,AX
3358:195F mov SI,0xFA00
3358:1962 mov DI,BP
3358:1964 mov CX,BX
3358:1966 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:1968 add BP,0x0140
3358:196C dec DX
3358:196D jne short 0x1962
3358:196F pop ES
3358:1970 pop DS
3358:1971 pop BP
3358:1972 pop DI
3358:1973 pop SI
3358:1974 pop DX
3358:1975 pop CX
3358:1976 pop BX
3358:1977 pop AX
3358:1978 ret far
3358:1979 xor AX,AX
3358:197B mov AH,AL
3358:197D push AX
3358:197E lods AX,word ptr DS:[SI]
3358:197F mov DX,AX
3358:1981 lods AX,word ptr DS:[SI]
3358:1982 mov BX,AX
3358:1984 call near 0x0C10
3358:1987 lods AX,word ptr DS:[SI]
3358:1988 mov BP,AX
3358:198A sub BP,DX
3358:198C jbe short 0x19C7
3358:198E lods AX,word ptr DS:[SI]
3358:198F sub BX,AX
3358:1991 jae short 0x19C7
3358:1993 neg BX
3358:1995 pop AX
3358:1996 mov SI,DI
3358:1998 shr BP,1
3358:199A jb short 0x19AC
3358:199C je short 0x19C6
3358:199E mov DI,SI
3358:19A0 mov CX,BP
3358:19A2 rep stos word ptr ES:[DI],AX
3358:19A4 add SI,0x0140
3358:19A8 dec BX
3358:19A9 jne short 0x199E
3358:19AB ret far
3358:19AC je short 0x19BD
3358:19AE mov DI,SI
3358:19B0 mov CX,BP
3358:19B2 rep stos word ptr ES:[DI],AX
3358:19B4 stos byte ptr ES:[DI],AL
3358:19B5 add SI,0x0140
3358:19B9 dec BX
3358:19BA jne short 0x19AE
3358:19BC ret far
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
3358:1A07 mov word ptr CS:[0x019A],BP
3358:1A0C mov word ptr CS:[0x0198],SI
3358:1A11 mov byte ptr CS:[0x019C],AL
3358:1A15 push AX
3358:1A16 push BX
3358:1A17 push CX
3358:1A18 push DX
3358:1A19 push DI
3358:1A1A mov word ptr CS:[0x0194],DX
3358:1A1F mov word ptr CS:[0x0196],BX
3358:1A24 sub BX,CX
3358:1A26 sub DX,DI
3358:1A28 neg BX
3358:1A2A neg DX
3358:1A2C call near 0x1ADC
3358:1A2F mov BP,word ptr CS:[0x019A]
3358:1A34 pop DI
3358:1A35 pop DX
3358:1A36 pop CX
3358:1A37 pop BX
3358:1A38 pop AX
3358:1A39 ret far
3358:1A3A mov BX,word ptr CS:[0x0196]
3358:1A3F mov CX,DX
3358:1A41 mov AX,word ptr CS:[0x0194]
3358:1A45 mov DX,AX
3358:1A47 add AX,CX
3358:1A49 cmp AX,DX
3358:1A4B jg short 0x1A51
3358:1A51 mov DI,word ptr CS:[0x0198]
3358:1A56 cmp BX,word ptr DS:[DI+2]
3358:1A59 jl short 0x1A83
3358:1A5B cmp BX,word ptr DS:[DI+6]
3358:1A5E jge short 0x1A83
3358:1A60 call near 0x0C10
3358:1A63 inc CX
3358:1A64 mov AL,byte ptr CS:[0x019C]
3358:1A68 mov SI,word ptr CS:[0x0198]
3358:1A6D rol word ptr CS:[0x019A],1
3358:1A72 jae short 0x1A7F
3358:1A74 cmp DX,word ptr DS:[SI]
3358:1A76 jl short 0x1A7F
3358:1A78 cmp DX,word ptr DS:[SI+4]
3358:1A7B jge short 0x1A7F
3358:1A7D stos byte ptr ES:[DI],AL
3358:1A7E dec DI
3358:1A7F inc DI
3358:1A80 inc DX
3358:1A81 loop 0x1A6D
3358:1A83 pop SI
3358:1A84 pop DI
3358:1A85 ret near
3358:1A86 mov CX,BX
3358:1A88 mov BX,word ptr CS:[0x0196]
3358:1A8D mov DX,word ptr CS:[0x0194]
3358:1A92 or AX,AX
3358:1A94 jns short 0x1A98
3358:1A98 cmp BX,0x00C8
3358:1A9C jb short 0x1AA4
3358:1AA4 mov DI,word ptr CS:[0x0198]
3358:1AA9 cmp DX,word ptr DS:[DI]
3358:1AAB jl short 0x1AD9
3358:1AAD cmp DX,word ptr DS:[DI+4]
3358:1AB0 jge short 0x1AD9
3358:1AB2 call near 0x0C10
3358:1AB5 inc CX
3358:1AB6 mov AL,byte ptr CS:[0x019C]
3358:1ABA mov SI,word ptr CS:[0x0198]
3358:1ABF rol word ptr CS:[0x019A],1
3358:1AC4 jae short 0x1AD2
3358:1AC6 cmp BX,word ptr DS:[SI+2]
3358:1AC9 jl short 0x1AD2
3358:1ACB cmp BX,word ptr DS:[SI+6]
3358:1ACE jge short 0x1AD2
3358:1AD0 stos byte ptr ES:[DI],AL
3358:1AD1 dec DI
3358:1AD2 inc BX
3358:1AD3 add DI,0x0140
3358:1AD7 loop 0x1ABF
3358:1AD9 pop SI
3358:1ADA pop DI
3358:1ADB ret near
3358:1ADC push DI
3358:1ADD push SI
3358:1ADE or BX,BX
3358:1AE0 jne short 0x1AE5
3358:1AE2 jmp near 0x1A3A
3358:1AE5 mov AX,1
3358:1AE8 jns short 0x1AEE
3358:1AEA neg BX
3358:1AEC neg AX
3358:1AEE or DX,DX
3358:1AF0 je short 0x1A86
3358:1AF2 mov CX,1
3358:1AF5 jns short 0x1AFB
3358:1AF7 neg CX
3358:1AF9 neg DX
3358:1AFB push AX
3358:1AFC push CX
3358:1AFD push AX
3358:1AFE push CX
3358:1AFF mov BP,SP
3358:1B01 mov SI,BX
3358:1B03 mov DI,DX
3358:1B05 xor AX,AX
3358:1B07 cmp DX,BX
3358:1B09 jbe short 0x1B10
3358:1B0B mov word ptr SS:[BP+2],AX
3358:1B0E jmp short 0x1B19
3358:1B19 mov AX,DI
3358:1B1B mov CX,DI
3358:1B1D shr AX,1
3358:1B1F add AX,SI
3358:1B21 cmp AX,DI
3358:1B23 jb short 0x1B2F
3358:1B25 sub AX,DI
3358:1B27 mov DX,word ptr SS:[BP+4]
3358:1B2A mov BX,word ptr SS:[BP+6]
3358:1B2D jmp short 0x1B35
3358:1B2F mov DX,word ptr SS:[BP]
3358:1B32 mov BX,word ptr SS:[BP+2]
3358:1B35 add DX,word ptr CS:[0x0194]
3358:1B3A add BX,word ptr CS:[0x0196]
3358:1B3F mov word ptr CS:[0x0194],DX
3358:1B44 mov word ptr CS:[0x0196],BX
3358:1B49 push AX
3358:1B4A push DI
3358:1B4B rol word ptr CS:[0x019A],1
3358:1B50 jae short 0x1B72
3358:1B52 mov DI,word ptr CS:[0x0198]
3358:1B57 cmp DX,word ptr DS:[DI]
3358:1B59 jl short 0x1B72
3358:1B5B cmp BX,word ptr DS:[DI+2]
3358:1B5E jl short 0x1B72
3358:1B60 cmp DX,word ptr DS:[DI+4]
3358:1B63 jge short 0x1B72
3358:1B65 cmp BX,word ptr DS:[DI+6]
3358:1B68 jge short 0x1B72
3358:1B6A call near 0x0C10
3358:1B6D mov AL,byte ptr CS:[0x019C]
3358:1B71 stos byte ptr ES:[DI],AL
3358:1B72 pop DI
3358:1B73 pop AX
3358:1B74 loop 0x1B1F
3358:1B76 add SP,8
3358:1B79 pop SI
3358:1B7A pop DI
3358:1B7B ret near
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
3358:1B8C mov DS,SI
3358:1B8E call near 0x0C10
3358:1B91 shr BP,1
3358:1B93 jb short 0x1BA9
3358:1B95 je short 0x1BBD
3358:1B97 mov DX,DI
3358:1B99 mov SI,DX
3358:1B9B mov DI,SI
3358:1B9D mov CX,BP
3358:1B9F rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:1BA1 add DX,0x0140
3358:1BA5 dec AX
3358:1BA6 jne short 0x1B99
3358:1BA8 ret far
3358:1BA9 je short 0x1BBE
3358:1BAB mov DX,DI
3358:1BAD mov SI,DX
3358:1BAF mov DI,SI
3358:1BB1 mov CX,BP
3358:1BB3 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:1BB5 movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:1BB6 add DX,0x0140
3358:1BBA dec AX
3358:1BBB jne short 0x1BAD
3358:1BBD ret far
3358:1BE7 push DS
3358:1BE8 mov DS,SI
3358:1BEA xor SI,SI
3358:1BEC mov DI,SI
3358:1BEE mov CX,0x5F00
3358:1BF1 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:1BF3 pop DS
3358:1BF4 ret far
3358:1BF5 call near 0x0C10
3358:1BF8 mov BX,AX
3358:1BFA mov DX,CX
3358:1BFC xor CX,CX
3358:1BFE mov BP,DI
3358:1C00 or BH,BH
3358:1C02 je short 0x1C1F
3358:1C04 mov CL,DL
3358:1C06 lods AL,byte ptr DS:[SI]
3358:1C07 mov AH,AL
3358:1C09 mov AL,BL
3358:1C0B shl AH,1
3358:1C0D jb short 0x1C11
3358:1C0F mov AL,BH
3358:1C11 stos byte ptr ES:[DI],AL
3358:1C12 loop 0x1C09
3358:1C14 add BP,0x0140
3358:1C18 mov DI,BP
3358:1C1A dec DH
3358:1C1C jne short 0x1C04
3358:1C1E ret far
3358:1C46 mov DX,word ptr SS:[BP]
3358:1C49 mov BX,word ptr SS:[BP+2]
3358:1C4C call near 0x0C10
3358:1C4F mov CX,word ptr SS:[BP+4]
3358:1C52 mov AX,word ptr SS:[BP+6]
3358:1C55 sub CX,DX
3358:1C57 sub AX,BX
3358:1C59 xchg DI,SI
3358:1C5B mov DX,0x0140
3358:1C5E sub DX,CX
3358:1C60 push DS
3358:1C61 push ES
3358:1C62 pop DS
3358:1C63 pop ES
3358:1C64 push CX
3358:1C65 shr CX,1
3358:1C67 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:1C69 adc CX,CX
3358:1C6B rep movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:1C6D pop CX
3358:1C6E add SI,DX
3358:1C70 dec AX
3358:1C71 jne short 0x1C64
3358:1C73 push SS
3358:1C74 pop DS
3358:1C75 ret far
3358:2396 xor DX,DX
3358:2398 or AX,AX
3358:239A jns short 0x239E
3358:239C neg AX
3358:239E sub AX,0x0046
3358:23A1 jb short 0x23CB
3358:23CB ret near
3358:23D7 jcxz short 0x23EA
3358:23EA ret near
3358:23EB push DI
3358:23EC mov DI,CX
3358:23EE dec DI
3358:23EF add BX,DI
3358:23F1 add AX,DI
3358:23F3 push AX
3358:23F4 push DX
3358:23F5 mov AX,0x00C8
3358:23F8 mul DI
3358:23FA add SI,AX
3358:23FC pop DX
3358:23FD pop AX
3358:23FE call near 0x0C10
3358:2401 pop DX
3358:2402 xchg CX,DX
3358:2404 call near 0x2413
3358:2407 sub SI,0x00C8
3358:240B sub DI,0x0140
3358:240F dec DX
3358:2410 jne short 0x2404
3358:2412 ret far
3358:2413 push AX
3358:2414 push CX
3358:2415 push DX
3358:2416 push SI
3358:2417 push DI
3358:2418 call near 0x2396
3358:241B push DX
3358:241C mov BP,0x0F0F
3358:241F mov DX,0x1010
3358:2422 shr CX,1
3358:2424 jae short 0x242C
3358:242C jcxz short 0x2436
3358:242E lods AX,word ptr DS:[SI]
3358:242F and AX,BP
3358:2431 add AX,DX
3358:2433 stos word ptr ES:[DI],AX
3358:2434 loop 0x242E
3358:2436 pop CX
3358:2437 call near 0x23D7
3358:243A pop DI
3358:243B pop SI
3358:243C pop DX
3358:243D pop CX
3358:243E pop AX
3358:243F dec AX
3358:2440 ret near
3358:254F push DX
3358:2550 mov DX,word ptr CS:[0x019F]
3358:2555 in DX,AL
3358:2556 and AL,8
3358:2558 cmp AL,byte ptr CS:[0x01A2]
3358:255D jne short 0x2555
3358:255F pop DX
3358:2560 mov BX,word ptr SS:[BP]
3358:2563 ret near
3358:2572 cmp byte ptr CS:[0x01A1],0
3358:2578 jne short 0x254F
3358:25E7 mov word ptr CS:[0x2768],8
3358:25EE mov word ptr CS:[0x276A],1
3358:25F5 mov word ptr CS:[0x2535],SI
3358:25FA mov word ptr CS:[0x2537],DS
3358:25FF mov word ptr CS:[0x2539],ES
3358:2604 mov CX,0x0098
3358:2607 and AX,0x00FE
3358:260A cmp AX,0x003E
3358:260D jb short 0x2614
3358:2614 mov BX,AX
3358:2616 jmp near word ptr CS:[BX+0x25A9]
3358:261D cmp byte ptr DS:[0x01A1],0
3358:2622 jne short 0x2627
3358:2627 ret near
3358:264D mov DS,word ptr CS:[0x2537]
3358:2652 mov ES,word ptr CS:[0x2539]
3358:2657 push CS
3358:2658 call near 0x1B7C
3358:265B push CS
3358:265C push CS
3358:265D pop DS
3358:265E pop ES
3358:265F xor BX,BX
3358:2661 push BX
3358:2662 push CX
3358:2663 push DX
3358:2664 push word ptr SS:[BP]
3358:2667 mov DI,0x05BF
3358:266A add DI,BX
3358:266C lea SI,DI-768
3358:2670 push BX
3358:2671 push CX
3358:2672 push DI
3358:2673 lods AL,byte ptr DS:[SI]
3358:2674 sub AL,byte ptr DS:[DI]
3358:2676 je short 0x2690
3358:2678 mov BL,AL
3358:267A xor AH,AH
3358:267C div DH
3358:267E xchg AL,AH
3358:2680 inc AH
3358:2682 or AL,AL
3358:2684 jne short 0x268A
3358:2686 dec AH
3358:2688 mov AL,DH
3358:268A cmp AH,DL
3358:268C jb short 0x2690
3358:268E add byte ptr DS:[DI],AL
3358:2690 inc DI
3358:2691 loop 0x2673
3358:2693 pop DX
3358:2694 pop CX
3358:2695 pop BX
3358:2696 call near 0x0A21
3358:2699 call near 0x0B68
3358:269C pop BX
3358:269D call near 0x261D
3358:26A0 pop DX
3358:26A1 pop CX
3358:26A2 pop BX
3358:26A3 add BX,CX
3358:26A5 cmp BX,0x02FD
3358:26A9 jb short 0x2661
3358:26AB dec DL
3358:26AD jne short 0x265F
3358:26AF ret far
3358:26E3 mov word ptr CS:[0x261B],AX
3358:26E7 xor BX,BX
3358:26E9 push BX
3358:26EA push DX
3358:26EB push word ptr SS:[BP]
3358:26EE mov SI,0x05BF
3358:26F1 add SI,BX
3358:26F3 add SI,BX
3358:26F5 add SI,BX
3358:26F7 mov DI,SI
3358:26F9 mov AX,word ptr CS:[0x261B]
3358:26FD push AX
3358:26FE mov CX,AX
3358:2700 add CX,CX
3358:2702 add CX,AX
3358:2704 mov AL,byte ptr DS:[SI]
3358:2706 sub AL,DH
3358:2708 jns short 0x270C
3358:270A xor AL,AL
3358:270C mov byte ptr DS:[SI],AL
3358:270E inc SI
3358:270F loop 0x2704
3358:2711 pop CX
3358:2712 mov DX,DI
3358:2714 call near 0x0B68
3358:2717 pop BX
3358:2718 call near 0x261D
3358:271B pop DX
3358:271C pop BX
3358:271D mov AX,word ptr CS:[0x261B]
3358:2721 add BX,AX
3358:2723 cmp BX,0x00FF
3358:2727 jb short 0x26E9
3358:2729 dec DL
3358:272B jne short 0x26E7
3358:272D ret near
3358:272E push CS
3358:272F push CS
3358:2730 pop DS
3358:2731 pop ES
3358:2732 mov SI,0x05C2
3358:2735 mov DI,0x02C2
3358:2738 mov CX,0x017D
3358:273B mov AX,word ptr DS:[DI]
3358:273D xchg AX,word ptr DS:[SI]
3358:273F stos word ptr ES:[DI],AX
3358:2740 add SI,2
3358:2743 loop 0x273B
3358:2745 mov AX,0x0055
3358:2748 mov DX,0x0316
3358:274B call near 0x26E3
3358:274E mov CX,0x00FF
3358:2751 mov DX,0x0316
3358:2754 jmp near 0x264D
3358:2DC0 mov CX,0x00C8
3358:2DC3 mov BX,word ptr SS:[BP]
3358:2DC6 mov SI,0x2FD7
3358:2DC9 shr CX,1
3358:2DCB shr CX,1
3358:2DCD lods AX,word ptr CS:[SI]
3358:2DCF or AX,AX
3358:2DD1 js short 0x2DF7
3358:2DD3 push CX
3358:2DD4 push SI
3358:2DD5 add AX,word ptr CS:[0x01A3]
3358:2DDA mov DI,AX
3358:2DDC xor AX,AX
3358:2DDE push DI
3358:2DDF mov DX,0x0050
3358:2DE2 stos byte ptr ES:[DI],AL
3358:2DE3 add DI,3
3358:2DE6 dec DX
3358:2DE7 jne short 0x2DE2
3358:2DE9 pop DI
3358:2DEA add DI,0x0500
3358:2DEE loop 0x2DDE
3358:2DF0 call near 0x2572
3358:2DF3 pop SI
3358:2DF4 pop CX
3358:2DF5 jmp short 0x2DCD
3358:2DF7 push CS
3358:2DF8 call near 0x0B0C
3358:2DFB mov BX,word ptr SS:[BP]
3358:2DFE mov SI,0x2FD7
3358:2E01 lods AX,word ptr CS:[SI]
3358:2E03 or AX,AX
3358:2E05 js short 0x2E2B
3358:2E07 push CX
3358:2E08 push SI
3358:2E09 add AX,word ptr CS:[0x01A3]
3358:2E0E mov DI,AX
3358:2E10 push DI
3358:2E11 mov DX,0x0050
3358:2E14 mov SI,DI
3358:2E16 movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:2E17 add DI,3
3358:2E1A dec DX
3358:2E1B jne short 0x2E14
3358:2E1D pop DI
3358:2E1E add DI,0x0500
3358:2E22 loop 0x2E10
3358:2E24 call near 0x2572
3358:2E27 pop SI
3358:2E28 pop CX
3358:2E29 jmp short 0x2E01
3358:2E2B ret far
3358:3200 mov word ptr CS:[0x2535],SI
3358:3205 mov word ptr CS:[0x2537],DS
3358:320A mov word ptr CS:[0x2539],ES
3358:320F and AX,0x00FE
3358:3212 cmp AX,0x001A
3358:3215 jb short 0x321C
3358:321C mov BX,AX
3358:321E jmp near word ptr CS:[BX+0x31E6]
3358:3280 mov DI,0xC71C
3358:3283 mov DX,0x0010
3358:3286 mov AX,0xFEFE
3358:3289 mov CX,0x0044
3358:328C rep stos word ptr ES:[DI],AX
3358:328E add DI,0x00B8
3358:3292 dec DX
3358:3293 jne short 0x3289
3358:3295 mov DX,8
3358:3298 mov AX,0xF208
3358:329B mov CX,0x0044
3358:329E rep stos word ptr ES:[DI],AX
3358:32A0 add DI,0x00B8
3358:32A4 xchg AL,AH
3358:32A6 dec DX
3358:32A7 jne short 0x329B
3358:32A9 mov DX,0x0010
3358:32AC mov AX,0xFEFE
3358:32AF mov CX,0x0044
3358:32B2 rep stos word ptr ES:[DI],AX
3358:32B4 add DI,0x00B8
3358:32B8 dec DX
3358:32B9 jne short 0x32AF
3358:32BB mov DS,word ptr CS:[0x2537]
3358:32C0 ret near
3358:32C1 cmp CL,9
3358:32C4 je short 0x3280
3358:32C6 mov word ptr CS:[0x3116],CX
3358:32CB mov word ptr CS:[0x3114],AX
3358:32CF mov DI,0xE01C
3358:32D2 lea BP,DI-320
3358:32D6 mov CX,0x0044
3358:32D9 mov SI,DI
3358:32DB rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:32DD add DI,0x00B8
3358:32E1 mov SI,DI
3358:32E3 mov BX,BP
3358:32E5 mov DX,0x0014
3358:32E8 jmp short 0x32FA
3358:32EA sub SI,0x01C8
3358:32EE sub DI,0x01C8
3358:32F2 add BX,0x00B8
3358:32F6 add BP,0x00B8
3358:32FA dec DX
3358:32FB js short 0x3330
3358:32FD mov CX,0x0044
3358:3300 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:3302 xchg DI,BP
3358:3304 xchg SI,BX
3358:3306 mov CX,0x0044
3358:3309 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:330B xchg DI,BP
3358:330D xchg SI,BX
3358:330F dec AL
3358:3311 jne short 0x32EA
3358:3313 mov CX,0x0140
3358:3316 sub DL,AH
3358:3318 jbe short 0x3328
3358:331A sub SI,CX
3358:331C add BX,CX
3358:331E dec AH
3358:3320 jne short 0x331A
3358:3322 mov AX,word ptr CS:[0x3114]
3358:3326 jmp short 0x32EA
3358:3328 sub DI,0x01C8
3358:332C add BP,0x00B8
3358:3330 mov BX,0xFEFE
3358:3333 mov AX,0xF208
3358:3336 mov DX,word ptr CS:[0x3116]
3358:333B cmp DX,9
3358:333E jb short 0x3346
3358:3340 sub DX,0x0012
3358:3343 neg DX
3358:3345 xchg BX,AX
3358:3346 mov CX,0x0044
3358:3349 xchg BX,AX
3358:334A xchg BP,DI
3358:334C rep stos word ptr ES:[DI],AX
3358:334E xchg BX,AX
3358:334F xchg BP,DI
3358:3351 mov CL,0x44
3358:3353 rep stos word ptr ES:[DI],AX
3358:3355 xchg AL,AH
3358:3357 xchg BL,BH
3358:3359 sub DI,0x01C8
3358:335D add BP,0x00B8
3358:3361 dec DX
3358:3362 jne short 0x3346
3358:3364 mov AX,0xFEFE
3358:3367 mov CL,0x44
3358:3369 xchg BP,DI
3358:336B rep stos word ptr ES:[DI],AX
3358:336D xchg BP,DI
3358:336F mov CL,0x44
3358:3371 rep stos word ptr ES:[DI],AX
3358:3373 sub DI,0x01C8
3358:3377 add BP,0x00B8
3358:337B cmp DI,0xC6C0
3358:337F jae short 0x3367
3358:3381 ret near
3358:3382 cmp CX,0x0011
3358:3385 jne short 0x33A3
3358:3387 push CX
3358:3388 push SI
3358:3389 push DS
3358:338A push ES
3358:338B push ES
3358:338C push SI
3358:338D pop ES
3358:338E pop DS
3358:338F mov DX,0x005C
3358:3392 mov BX,0x009F
3358:3395 mov BP,0x0088
3358:3398 mov AX,0x0029
3358:339B push CS
3358:339C call near 0x1B8E
3358:339F pop ES
3358:33A0 pop DS
3358:33A1 pop SI
3358:33A2 pop CX
3358:33A3 cmp CL,9
3358:33A6 jb short 0x33AA
3358:33A8 push SI
3358:33A9 pop DS
3358:33AA push CX
3358:33AB mov BX,CX
3358:33AD shl BX,1
3358:33AF mov AX,word ptr CS:[BX+0x30F0]
3358:33B4 call near 0x32C1
3358:33B7 pop CX
3358:33B8 loop 0x33C9
3358:33BA mov DX,0x005C
3358:33BD mov BX,0x009F
3358:33C0 mov BP,0x0088
3358:33C3 mov AX,0x0029
3358:33C6 jmp near 0x1B8E
3358:33C9 ret far
3358:39E9 push AX
3358:39EA push DI
3358:39EB call near 0x0C10
3358:39EE pop BX
3358:39EF mov DX,AX
3358:39F1 shr BP,1
3358:39F3 jae short 0x39F7
3358:39F5 xor BP,SI
3358:39F7 mov AX,BP
3358:39F9 and AX,3
3358:39FC dec AX
3358:39FD add AL,DH
3358:39FF stos byte ptr ES:[DI],AL
3358:3A00 add DX,BX
3358:3A02 loop 0x39F1
3358:3A04 pop AX
3358:3A05 ret far
3358:3A14 call near 0x0C10
3358:3A17 mov SI,DI
3358:3A19 mov DI,word ptr CS:[0x01A3]
3358:3A1E shl BP,1
3358:3A20 jmp near word ptr CS:[BP+0x3A04]
3358:3B46 mov BX,0x0026
3358:3B49 mov CX,0x0050
3358:3B4C lods AL,byte ptr DS:[SI]
3358:3B4D mov AH,AL
3358:3B4F mov BP,4
3358:3B52 stos word ptr ES:[DI],AX
3358:3B53 stos word ptr ES:[DI],AX
3358:3B54 add DI,0x013C
3358:3B58 dec BP
3358:3B59 jne short 0x3B52
3358:3B5B sub DI,0x04FC
3358:3B5F loop 0x3B4C
3358:3B61 add SI,0x00F0
3358:3B65 add DI,0x03C0
3358:3B69 dec BX
3358:3B6A jne short 0x3B49
3358:3B6C ret far
5642:0100 jmp short 0x0120
5642:0106 jmp near 0x01DE
5642:0109 jmp near 0x01C2
5642:010C jmp near 0x01CB
5642:0112 jmp near 0x0217
5642:0115 jmp near 0x01A7
5642:0120 or AX,AX
5642:0122 je short 0x0144
5642:0124 push AX
5642:0125 and AL,0x0F
5642:0127 mov BX,2
5642:012A call near 0x082B
5642:012D pop AX
5642:012E shr AX,1
5642:0130 shr AX,1
5642:0132 shr AX,1
5642:0134 shr AX,1
5642:0136 push AX
5642:0137 mov BX,1
5642:013A call near 0x082B
5642:013D pop AX
5642:013E mov BX,0x000D
5642:0141 call near 0x082B
5642:0144 mov BX,3
5642:0147 call near 0x082B
5642:014A mov word ptr CS:[0x011C],0x0100
5642:0151 mov word ptr CS:[0x011E],CS
5642:0156 mov word ptr CS:[0x0118],0x0100
5642:015D mov word ptr CS:[0x011A],CS
5642:0162 push CS
5642:0163 call near 0x01C2
5642:0166 mov BX,0x000F
5642:0169 ret far
5642:016A push BX
5642:016B push DX
5642:016C shr AL,1
5642:016E shr AL,1
5642:0170 shr AL,1
5642:0172 mov DX,AX
5642:0174 mov BX,0xF078
5642:0177 cmp AH,BL
5642:0179 jbe short 0x017D
5642:017D xor AL,AL
5642:017F div BH
5642:0181 mul DL
5642:0183 xchg AH,DH
5642:0185 sub AH,BH
5642:0187 neg AH
5642:0189 cmp AH,BL
5642:018B jbe short 0x018F
5642:018D mov AH,BL
5642:018F xor AL,AL
5642:0191 div BH
5642:0193 mul DL
5642:0195 shr AX,1
5642:0197 shr AX,1
5642:0199 shr AX,1
5642:019B shr AX,1
5642:019D mov AH,DH
5642:019F and AX,0x0FF0
5642:01A2 or AL,AH
5642:01A4 pop DX
5642:01A5 pop BX
5642:01A6 ret near
5642:01A7 call near 0x016A
5642:01AA mov AH,4
5642:01AC call near 0x01B0
5642:01AF ret far
5642:01B0 push DX
5642:01B1 mov DX,word ptr CS:[0x0285]
5642:01B6 add DL,4
5642:01B9 xchg AL,AH
5642:01BB out DX,AL
5642:01BC inc DX
5642:01BD xchg AL,AH
5642:01BF out DX,AL
5642:01C0 pop DX
5642:01C1 ret near
5642:01C2 push BX
5642:01C3 mov BX,8
5642:01C6 call near 0x082B
5642:01C9 pop BX
5642:01CA ret far
5642:01CB push AX
5642:01CC xor AX,AX
5642:01CE push BX
5642:01CF mov BX,0x000C
5642:01D2 call near 0x082B
5642:01D5 pop BX
5642:01D6 pop AX
5642:01D7 ret far
5642:01DE push ES
5642:01DF mov word ptr CS:[0x0118],SI
5642:01E4 mov word ptr CS:[0x011A],DS
5642:01E9 les DI,word ptr DS:[SI]
5642:01EB mov BX,word ptr DS:[SI+4]
5642:01EE or byte ptr DS:[SI+6],3
5642:01F2 mov byte ptr ES:[BX+DI],0
5642:01F6 sub BX,4
5642:01F9 cmp byte ptr ES:[DI+3],0
5642:01FE jne short 0x0206
5642:0200 cmp word ptr ES:[DI+1],BX
5642:0204 jb short 0x020F
5642:0206 mov word ptr ES:[DI+1],BX
5642:020A mov byte ptr ES:[DI+3],0
5642:020F mov BX,6
5642:0212 call near 0x082B
5642:0215 pop ES
5642:0216 ret far
5642:0217 push ES
5642:0218 mov word ptr CS:[0x011C],SI
5642:021D mov word ptr CS:[0x011E],DS
5642:0222 les DI,word ptr DS:[SI]
5642:0224 mov BX,word ptr DS:[SI+4]
5642:0227 cmp byte ptr DS:[SI+7],0
5642:022B jns short 0x0232
5642:022D or BX,BX
5642:022F je short 0x0232
5642:0231 dec BX
5642:0232 mov byte ptr ES:[BX+DI+6],0
5642:0237 mov byte ptr ES:[DI+2],2
5642:023C mov word ptr ES:[DI+3],BX
5642:0240 mov byte ptr ES:[DI+5],0
5642:0245 mov byte ptr DS:[SI+6],2
5642:0249 cmp byte ptr CS:[0x0292],0
5642:024F jne short 0x0281
5642:0251 cmp byte ptr CS:[0x02FE],0
5642:0257 jne short 0x0281
5642:0259 lds SI,word ptr CS:[0x011C]
5642:025E les DI,word ptr DS:[SI]
5642:0260 add word ptr DS:[SI+4],6
5642:0264 mov byte ptr ES:[DI],1
5642:0268 mov byte ptr ES:[DI+3],1
5642:026D mov AL,byte ptr CS:[0x02FC]
5642:0271 mov byte ptr ES:[DI+4],AL
5642:0275 mov AL,byte ptr CS:[0x02FD]
5642:0279 mov byte ptr ES:[DI+5],AL
5642:027D push CS
5642:027E call near 0x01DE
5642:0281 pop ES
5642:0282 ret far
5642:02FF push CX
5642:0300 mov CX,0x0200
5642:0303 mov AH,AL
5642:0305 in DX,AL
5642:0306 or AL,AL
5642:0308 jns short 0x030F
5642:030F mov AL,AH
5642:0311 out DX,AL
5642:0312 clc
5642:0313 pop CX
5642:0314 ret near
5642:0315 push CX
5642:0316 push DX
5642:0317 mov DX,word ptr DS:[0x0285]
5642:031B add DL,0x0E
5642:031E mov CX,0x0200
5642:0321 in DX,AL
5642:0322 or AL,AL
5642:0324 js short 0x032B
5642:032B sub DL,4
5642:032E in DX,AL
5642:032F clc
5642:0330 pop DX
5642:0331 pop CX
5642:0332 ret near
5642:0333 mov DX,word ptr DS:[0x0285]
5642:0337 add DL,0x0C
5642:033A mov AH,AL
5642:033C mov AL,0xF0
5642:033E in DX,AL
5642:033F or AL,AL
5642:0341 js short 0x033E
5642:0343 mov AL,AH
5642:0345 out DX,AL
5642:0346 ret near
5642:0347 push DX
5642:0348 mov DX,word ptr DS:[0x0285]
5642:034C add DL,0x0E
5642:034F xor AL,AL
5642:0351 in DX,AL
5642:0352 or AL,AL
5642:0354 jns short 0x0351
5642:0356 sub DL,4
5642:0359 in DX,AL
5642:035A pop DX
5642:035B ret near
5642:035C mov DX,word ptr DS:[0x0285]
5642:0360 add DL,6
5642:0363 mov AL,1
5642:0365 out DX,AL
5642:0366 in DX,AL
5642:0367 in DX,AL
5642:0368 in DX,AL
5642:0369 in DX,AL
5642:036A xor AL,AL
5642:036C out DX,AL
5642:036D mov BL,0x10
5642:036F call near 0x0315
5642:0372 cmp AL,0xAA
5642:0374 je short 0x0380
5642:0380 xor AX,AX
5642:0382 or AX,AX
5642:0384 ret near
5642:0385 mov BX,2
5642:0388 mov AL,0xE0
5642:038A mov DX,word ptr DS:[0x0285]
5642:038E add DL,0x0C
5642:0391 call near 0x02FF
5642:0394 jb short 0x03A8
5642:0396 mov AL,0xAA
5642:0398 call near 0x02FF
5642:039B jb short 0x03A8
5642:039D call near 0x0315
5642:03A0 jb short 0x03A8
5642:03A2 cmp AL,0x55
5642:03A4 jne short 0x03A8
5642:03A6 xor BX,BX
5642:03A8 mov AX,BX
5642:03AA or AX,AX
5642:03AC ret near
5642:03AD push AX
5642:03AE push DX
5642:03AF mov DX,word ptr CS:[0x0285]
5642:03B4 add DL,0x0E
5642:03B7 in DX,AL
5642:03B8 mov byte ptr CS:[0x028E],1
5642:03BE mov AL,0x20
5642:03C0 cmp byte ptr CS:[0x0287],8
5642:03C6 jb short 0x03CC
5642:03CC out 0x20,AL
5642:03CE pop DX
5642:03CF pop AX
5642:03D0 iret
5642:03D1 mov byte ptr DS:[0x028E],0
5642:03D6 mov AX,0x03AD
5642:03D9 call near 0x04D8
5642:03DC mov DX,CS
5642:03DE mov AX,0x0291
5642:03E1 call near 0x048A
5642:03E4 xor CX,CX
5642:03E6 mov DH,0x48
5642:03E8 call near 0x0450
5642:03EB mov AL,0x40
5642:03ED call near 0x0333
5642:03F0 mov AL,0x64
5642:03F2 call near 0x033A
5642:03F5 mov AL,0x14
5642:03F7 call near 0x033A
5642:03FA xor AL,AL
5642:03FC call near 0x033A
5642:03FF xor AL,AL
5642:0401 call near 0x033A
5642:0404 xor AX,AX
5642:0406 mov CX,0xFFFF
5642:0409 cmp byte ptr DS:[0x028E],0
5642:040E jne short 0x0414
5642:0414 push AX
5642:0415 call near 0x0524
5642:0418 pop AX
5642:0419 or AX,AX
5642:041B ret near
5642:041C mov AL,0xE1
5642:041E call near 0x033A
5642:0421 call near 0x0347
5642:0424 mov AH,AL
5642:0426 call near 0x0347
5642:0429 cmp AX,0x0103
5642:042C mov AX,0
5642:042F adc AL,AH
5642:0431 ret near
5642:0432 pushf
5642:0433 mov CX,0x0064
5642:0436 mov DX,word ptr DS:[0x0285]
5642:043A add DL,0x0C
5642:043D sti
5642:043E cmp byte ptr DS:[0x0292],0
5642:0443 je short 0x044E
5642:0445 cli
5642:0446 in DX,AL
5642:0447 test AL,0x80
5642:0449 loopne 0x043D
5642:044B mov AL,0xD0
5642:044D out DX,AL
5642:044E popf
5642:044F ret near
5642:0450 push BX
5642:0451 mov BX,AX
5642:0453 mov AH,DL
5642:0455 mov AL,byte ptr CS:[0x0288]
5642:0459 mov DL,AL
5642:045B or AL,4
5642:045D out 0x0A,AL
5642:045F xor AL,AL
5642:0461 out 0x0C,AL
5642:0463 mov AL,DH
5642:0465 or AL,DL
5642:0467 out 0x0B,AL
5642:0469 xor DH,DH
5642:046B shl DX,1
5642:046D mov AL,BL
5642:046F out DX,AL
5642:0470 mov AL,BH
5642:0472 out DX,AL
5642:0473 mov AL,CL
5642:0475 inc DX
5642:0476 out DX,AL
5642:0477 mov AL,CH
5642:0479 out DX,AL
5642:047A mov DL,byte ptr CS:[0x0289]
5642:047F mov AL,AH
5642:0481 out DX,AL
5642:0482 mov AL,byte ptr CS:[0x0288]
5642:0486 out 0x0A,AL
5642:0488 pop BX
5642:0489 ret near
5642:048A push CX
5642:048B mov CL,4
5642:048D rol DX,CL
5642:048F mov CX,DX
5642:0491 and DX,0x000F
5642:0494 and CX,-16
5642:0497 add AX,CX
5642:0499 adc DX,0
5642:049C pop CX
5642:049D ret near
5642:049E mov DX,word ptr DS:[0x0295]
5642:04A2 add AX,word ptr DS:[0x0293]
5642:04A6 jae short 0x04AB
5642:04AB ret near
5642:04AC push ES
5642:04AD push DI
5642:04AE les DI,word ptr DS:[0x0293]
5642:04B2 mov AX,word ptr ES:[DI+1]
5642:04B6 xor DX,DX
5642:04B8 mov DL,byte ptr ES:[DI+3]
5642:04BC pop DI
5642:04BD pop ES
5642:04BE ret near
5642:04BF mov AL,byte ptr DS:[0x0287]
5642:04C2 add AL,8
5642:04C4 cmp AL,0x10
5642:04C6 jb short 0x04CA
5642:04CA xor AH,AH
5642:04CC shl AX,1
5642:04CE shl AX,1
5642:04D0 mov BX,AX
5642:04D2 xor AX,AX
5642:04D4 mov ES,AX
5642:04D6 cli
5642:04D7 ret near
5642:04D8 pushf
5642:04D9 push BX
5642:04DA push CX
5642:04DB push DX
5642:04DC mov DX,AX
5642:04DE push ES
5642:04DF call near 0x04BF
5642:04E2 mov AX,CS
5642:04E4 xchg DX,word ptr ES:[BX]
5642:04E7 mov word ptr DS:[0x0297],DX
5642:04EB xchg AX,word ptr ES:[BX+2]
5642:04EF mov word ptr DS:[0x0299],AX
5642:04F2 pop ES
5642:04F3 mov CL,byte ptr DS:[0x0287]
5642:04F7 cmp CL,8
5642:04FA jb short 0x0510
5642:0510 mov AH,1
5642:0512 shl AH,CL
5642:0514 not AH
5642:0516 in AL,0x21
5642:0518 mov byte ptr DS:[0x029B],AL
5642:051B and AL,AH
5642:051D out 0x21,AL
5642:051F pop DX
5642:0520 pop CX
5642:0521 pop BX
5642:0522 popf
5642:0523 ret near
5642:0524 pushf
5642:0525 push BX
5642:0526 push ES
5642:0527 call near 0x04BF
5642:052A mov AX,word ptr DS:[0x0297]
5642:052D mov word ptr ES:[BX],AX
5642:0530 mov AX,word ptr DS:[0x0299]
5642:0533 mov word ptr ES:[BX+2],AX
5642:0537 pop ES
5642:0538 cmp byte ptr DS:[0x0287],8
5642:053D jb short 0x0544
5642:0544 mov AL,byte ptr DS:[0x029B]
5642:0547 out 0x21,AL
5642:0549 pop BX
5642:054A popf
5642:054B ret near
5642:054C push DS
5642:054D push SI
5642:054E lds SI,word ptr DS:[0x0293]
5642:0552 lods AL,byte ptr DS:[SI]
5642:0553 pop SI
5642:0554 pop DS
5642:0555 ret near
5642:0556 mov CX,AX
5642:0558 call near 0x049E
5642:055B call near 0x048A
5642:055E mov byte ptr DS:[0x029D],DL
5642:0562 mov word ptr DS:[0x029E],AX
5642:0565 call near 0x04AC
5642:0568 sub CX,4
5642:056B sub AX,CX
5642:056D sbb DX,0
5642:0570 mov word ptr DS:[0x02A0],AX
5642:0573 mov word ptr DS:[0x02A2],DX
5642:0577 sub AX,1
5642:057A sbb DX,0
5642:057D add AX,word ptr DS:[0x029E]
5642:0581 adc DL,byte ptr DS:[0x029D]
5642:0585 mov word ptr DS:[0x02A4],AX
5642:0588 sub DL,byte ptr DS:[0x029D]
5642:058C mov byte ptr DS:[0x02A6],DL
5642:0590 ret near
5642:0591 push DS
5642:0592 push ES
5642:0593 push AX
5642:0594 push BX
5642:0595 push CX
5642:0596 push DX
5642:0597 push SI
5642:0598 push DI
5642:0599 push BP
5642:059A cld
5642:059B mov AX,CS
5642:059D mov DS,AX
5642:059F mov ES,AX
5642:05A1 mov AL,0x20
5642:05A3 cmp byte ptr CS:[0x0287],8
5642:05A9 jb short 0x05AF
5642:05AF out 0x20,AL
5642:05B1 mov DX,word ptr DS:[0x0285]
5642:05B5 add DL,0x0E
5642:05B8 in DX,AL
5642:05B9 sti
5642:05BA mov AX,word ptr DS:[0x02A0]
5642:05BD or AX,word ptr DS:[0x02A2]
5642:05C1 jne short 0x05D5
5642:05C3 call near 0x0677
5642:05C6 call near 0x065F
5642:05C9 cmp byte ptr DS:[0x02A7],0
5642:05CE je short 0x05D8
5642:05D0 call near 0x0640
5642:05D3 jmp short 0x05D8
5642:05D8 pop BP
5642:05D9 pop DI
5642:05DA pop SI
5642:05DB pop DX
5642:05DC pop CX
5642:05DD pop BX
5642:05DE pop AX
5642:05DF pop ES
5642:05E0 pop DS
5642:05E1 iret
5642:05E2 mov CX,0xFFFF
5642:05E5 cmp byte ptr DS:[0x02A6],0
5642:05EA jne short 0x05F4
5642:05EC inc byte ptr DS:[0x02A6]
5642:05F0 mov CX,word ptr DS:[0x02A4]
5642:05F4 sub CX,word ptr DS:[0x029E]
5642:05F8 mov word ptr DS:[0x02A8],CX
5642:05FC inc CX
5642:05FD je short 0x060A
5642:05FF sub word ptr DS:[0x02A0],CX
5642:0603 sbb word ptr DS:[0x02A2],0
5642:0608 jmp short 0x060E
5642:060E mov DH,0x48
5642:0610 mov DL,byte ptr DS:[0x029D]
5642:0614 mov AX,word ptr DS:[0x029E]
5642:0617 mov CX,word ptr DS:[0x02A8]
5642:061B call near 0x0450
5642:061E dec byte ptr DS:[0x02A6]
5642:0622 inc byte ptr DS:[0x029D]
5642:0626 mov word ptr DS:[0x029E],0
5642:062C mov CX,word ptr DS:[0x02A8]
5642:0630 mov AL,byte ptr DS:[0x02AA]
5642:0633 call near 0x0333
5642:0636 mov AL,CL
5642:0638 call near 0x033A
5642:063B mov AL,CH
5642:063D jmp near 0x033A
5642:0640 mov AL,byte ptr CS:[0x0288]
5642:0644 or AL,4
5642:0646 out 0x0A,AL
5642:0648 call near 0x0524
5642:064B xor AX,AX
5642:064D mov byte ptr DS:[0x0292],AL
5642:0650 mov word ptr DS:[0x02AB],AX
5642:0653 mov word ptr DS:[0x0283],AX
5642:0656 mov DX,word ptr DS:[0x0285]
5642:065A add DL,0x0E
5642:065D in DX,AL
5642:065E ret near
5642:065F call near 0x054C
5642:0662 cmp AL,8
5642:0664 jae short 0x0672
5642:0666 cbw
5642:0667 mov BX,AX
5642:0669 shl BX,1
5642:066B call near word ptr DS:[BX+0x02D0]
5642:066F jb short 0x065F
5642:0671 ret near
5642:0677 push ES
5642:0678 push AX
5642:0679 push BX
5642:067A push DX
5642:067B les BX,word ptr DS:[0x0293]
5642:067F mov AX,word ptr ES:[BX+1]
5642:0683 xor DX,DX
5642:0685 mov DL,byte ptr ES:[BX+3]
5642:0689 add AX,4
5642:068C adc DX,0
5642:068F add AX,word ptr DS:[0x0293]
5642:0693 adc DX,0
5642:0696 ror DX,1
5642:0698 ror DX,1
5642:069A ror DX,1
5642:069C ror DX,1
5642:069E add DX,word ptr DS:[0x0295]
5642:06A2 mov BX,AX
5642:06A4 shr BX,1
5642:06A6 shr BX,1
5642:06A8 shr BX,1
5642:06AA shr BX,1
5642:06AC add DX,BX
5642:06AE and AX,0x000F
5642:06B1 mov word ptr DS:[0x0295],DX
5642:06B5 mov word ptr DS:[0x0293],AX
5642:06B8 pop DX
5642:06B9 pop BX
5642:06BA pop AX
5642:06BB pop ES
5642:06BC ret near
5642:06BD push AX
5642:06BE shr AX,1
5642:06C0 shr AX,1
5642:06C2 shr AX,1
5642:06C4 shr AX,1
5642:06C6 add DX,AX
5642:06C8 pop AX
5642:06C9 and AX,0x000F
5642:06CC ret near
5642:06CD push ES
5642:06CE les SI,word ptr DS:[0x0118]
5642:06D2 mov byte ptr ES:[SI+6],0
5642:06D7 mov AL,byte ptr ES:[SI+7]
5642:06DB shl AL,1
5642:06DD jb short 0x0733
5642:06DF les SI,word ptr DS:[0x011C]
5642:06E3 cmp byte ptr ES:[SI+6],2
5642:06E8 je short 0x070F
5642:06EA shl AL,1
5642:06EC jae short 0x0738
5642:070F mov word ptr DS:[0x0118],SI
5642:0713 mov word ptr DS:[0x011A],ES
5642:0717 mov byte ptr ES:[SI+6],3
5642:071C cmp word ptr ES:[SI+4],3
5642:0721 jb short 0x06CE
5642:0723 les AX,word ptr ES:[SI]
5642:0726 add AX,2
5642:0729 mov word ptr DS:[0x0293],AX
5642:072C mov word ptr DS:[0x0295],ES
5642:0730 pop ES
5642:0731 stc
5642:0732 ret near
5642:0733 mov byte ptr DS:[0x02FE],1
5642:0738 mov byte ptr DS:[0x02A7],1
5642:073D pop ES
5642:073E clc
5642:073F ret near
5642:0740 push ES
5642:0741 les DI,word ptr DS:[0x0293]
5642:0745 mov AL,0x40
5642:0747 call near 0x0333
5642:074A mov AL,byte ptr ES:[DI+4]
5642:074E mov byte ptr DS:[0x02FC],AL
5642:0751 call near 0x033A
5642:0754 mov AL,byte ptr ES:[DI+5]
5642:0758 mov byte ptr DS:[0x02FD],AL
5642:075B mov BX,0x02C5
5642:075E xlat byte ptr DS:[BX+AL]
5642:075F mov byte ptr DS:[0x02AA],AL
5642:0762 pop ES
5642:0763 mov AX,6
5642:0766 call near 0x0556
5642:0769 call near 0x05E2
5642:076C call near 0x0771
5642:076F clc
5642:0770 ret near
5642:0771 mov AL,byte ptr DS:[0x02AA]
5642:0774 cmp AL,0x61
5642:0776 jb short 0x0782
5642:0782 and byte ptr DS:[0x02AA],0xFE
5642:0787 ret near
5642:0788 mov AX,4
5642:078B call near 0x0556
5642:078E call near 0x0771
5642:0791 call near 0x05E2
5642:0794 clc
5642:0795 ret near
5642:0796 mov AL,0x40
5642:0798 call near 0x0333
5642:079B push ES
5642:079C les BX,word ptr DS:[0x0293]
5642:07A0 mov AL,byte ptr ES:[BX+6]
5642:07A4 call near 0x033A
5642:07A7 mov AX,word ptr ES:[BX+4]
5642:07AB pop ES
5642:07AC mov BX,AX
5642:07AE mov AL,0x80
5642:07B0 call near 0x033A
5642:07B3 mov AL,BL
5642:07B5 call near 0x033A
5642:07B8 mov AL,BH
5642:07BA call near 0x033A
5642:07BD clc
5642:07BE ret near
5642:07D0 push DS
5642:07D1 lds BX,word ptr DS:[0x0293]
5642:07D5 mov AX,word ptr DS:[BX+4]
5642:07D8 pop DS
5642:07D9 add word ptr DS:[0x02AB],2
5642:07DE mov BX,word ptr DS:[0x02AB]
5642:07E2 mov word ptr DS:[BX+0x02AB],AX
5642:07E6 push BX
5642:07E7 call near 0x0677
5642:07EA mov SI,0x0293
5642:07ED mov DI,0x02B3
5642:07F0 pop BX
5642:07F1 add DI,BX
5642:07F3 add DI,BX
5642:07F5 movs word ptr ES:[DI],word ptr DS:[SI]
5642:07F6 movs word ptr ES:[DI],word ptr DS:[SI]
5642:07F7 stc
5642:07F8 ret near
5642:07F9 mov BX,word ptr DS:[0x02AB]
5642:07FD or BX,BX
5642:07FF je short 0x0826
5642:0801 cmp word ptr DS:[BX+0x02AB],0
5642:0806 je short 0x0821
5642:0808 mov DI,0x0293
5642:080B mov SI,0x02B3
5642:080E add SI,BX
5642:0810 add SI,BX
5642:0812 movs word ptr ES:[DI],word ptr DS:[SI]
5642:0813 movs word ptr ES:[DI],word ptr DS:[SI]
5642:0814 cmp word ptr DS:[BX+0x02AB],-1
5642:0819 je short 0x0829
5642:081B dec word ptr DS:[BX+0x02AB]
5642:081F jmp short 0x0829
5642:0821 sub word ptr DS:[0x02AB],2
5642:0826 call near 0x0677
5642:0829 stc
5642:082A ret near
5642:082B push CX
5642:082C push DX
5642:082D push SI
5642:082E push DI
5642:082F push BP
5642:0830 push DS
5642:0831 push ES
5642:0832 push CS
5642:0833 pop DS
5642:0834 mov word ptr DS:[0x028F],ES
5642:0838 push CS
5642:0839 pop ES
5642:083A cmp BX,0x000E
5642:083D jae short 0x0858
5642:083F cmp BL,4
5642:0842 jb short 0x0850
5642:0844 cmp BL,0x0D
5642:0847 je short 0x0850
5642:0849 cmp byte ptr DS:[0x028E],0
5642:084E je short 0x0858
5642:0850 shl BX,1
5642:0852 call near word ptr DS:[BX+0x02E0]
5642:0856 jmp short 0x085B
5642:085B pop ES
5642:085C pop DS
5642:085D pop BP
5642:085E pop DI
5642:085F pop SI
5642:0860 pop DX
5642:0861 pop CX
5642:0862 ret near
5642:0867 and AX,0xFFF8
5642:086A mov BX,AX
5642:086C sub AX,0x0210
5642:086F cmp AX,0x0050
5642:0872 ja short 0x08B0
5642:0874 mov word ptr DS:[0x0285],BX
5642:0878 xor AX,AX
5642:087A ret near
5642:087B cmp AL,0x0A
5642:087D je short 0x088F
5642:087F cmp AL,7
5642:0881 je short 0x088F
5642:088F mov byte ptr DS:[0x0287],AL
5642:0892 xor AX,AX
5642:0894 ret near
5642:0895 and AL,7
5642:0897 dec AL
5642:0899 cmp AL,3
5642:089B ja short 0x08B0
5642:089D cmp AL,2
5642:089F je short 0x08B0
5642:08A1 mov byte ptr DS:[0x0288],AL
5642:08A4 push BX
5642:08A5 mov BX,0x028A
5642:08A8 xlat byte ptr DS:[BX+AL]
5642:08A9 mov byte ptr DS:[0x0289],AL
5642:08AC pop BX
5642:08AD xor AX,AX
5642:08AF ret near
5642:08B4 pushf
5642:08B5 sti
5642:08B6 call near 0x035C
5642:08B9 jne short 0x08D1
5642:08BB call near 0x0385
5642:08BE jne short 0x08D1
5642:08C0 call near 0x041C
5642:08C3 jne short 0x08D1
5642:08C5 call near 0x03D1
5642:08C8 jne short 0x08D1
5642:08CA mov AL,1
5642:08CC call near 0x08D3
5642:08CF xor AX,AX
5642:08D1 popf
5642:08D2 ret near
5642:08D3 mov DX,word ptr DS:[0x0285]
5642:08D7 add DL,0x0C
5642:08DA or AL,AL
5642:08DC mov AL,0xD1
5642:08DE jne short 0x08E2
5642:08E2 call near 0x033A
5642:08E5 xor AX,AX
5642:08E7 ret near
5642:08E8 cmp byte ptr DS:[0x0292],0
5642:08ED jne short 0x08B0
5642:08EF inc byte ptr DS:[0x0292]
5642:08F3 mov DX,word ptr DS:[0x028F]
5642:08F7 mov AX,DI
5642:08F9 call near 0x06BD
5642:08FC mov word ptr DS:[0x0295],DX
5642:0900 mov word ptr DS:[0x0293],AX
5642:0903 xor AX,AX
5642:0905 mov byte ptr DS:[0x02A7],AL
5642:0908 mov word ptr DS:[0x02AB],AX
5642:090B mov word ptr DS:[0x02AD],AX
5642:090E mov AX,0x0591
5642:0911 call near 0x04D8
5642:0914 mov word ptr DS:[0x0283],0xFFFF
5642:091A call near 0x065F
5642:091D mov byte ptr DS:[0x02FE],0
5642:0922 xor AX,AX
5642:0924 ret near
5642:0925 mov AX,1
5642:0928 cmp byte ptr DS:[0x0292],0
5642:092D je short 0x0937
5642:092F call near 0x0432
5642:0932 call near 0x0640
5642:0935 xor AX,AX
5642:0937 mov byte ptr DS:[0x02FE],1
5642:093C ret near
5642:095F mov CX,AX
5642:0961 mov AX,1
5642:0964 pushf
5642:0965 cli
5642:0966 mov BX,word ptr DS:[0x02AB]
5642:096A or BX,BX
5642:096C je short 0x0990
5642:096E xor AX,AX
5642:0970 mov word ptr DS:[BX+0x02AB],AX
5642:0974 jcxz short 0x098E
5642:098E xor AX,AX
5642:0990 popf
5642:0991 ret near
