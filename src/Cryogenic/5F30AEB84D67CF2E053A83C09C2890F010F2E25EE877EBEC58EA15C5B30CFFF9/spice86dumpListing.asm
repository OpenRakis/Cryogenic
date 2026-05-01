0800:0000 callback 0x0010
0800:0004 iret
0800:0005 iret
0800:0006 callback 8
0800:000A int 0x1C
0800:000C callback 0x0101
0800:0010 iret
0800:0011 callback 9
0800:0015 iret
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
100D:05F1 call near 0x093F
100D:05F4 or AX,AX
100D:05F6 je short 0x0592
100D:05F8 call near 0xDDF0
100D:05FB jae short 0x0592
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
100D:063C cmp byte ptr DS:[0xDBCB],0
100D:0641 je short 0x0646
100D:0643 call near 0xAEB7
100D:0646 call near 0xCC85
100D:0649 je short 0x0628
100D:064B clc
100D:064C ret near
100D:064D mov AL,0x0A
100D:064F call near 0xAD95
100D:0652 mov AX,0x0016
100D:0655 jmp near 0xCA1B
100D:0658 call near 0xC0AD
100D:065B mov AX,0x0017
100D:065E jmp near 0xCA1B
100D:0661 call near 0xC07C
100D:0664 call near 0xDD63
100D:0667 jb short 0x064C
100D:0669 call near 0xC9F4
100D:066C je short 0x0664
100D:066E call near 0xC4CD
100D:0671 call near 0xCC85
100D:0674 je short 0x0664
100D:0676 clc
100D:0677 ret near
100D:0678 call near 0x0579
100D:067B call near 0xC0AD
100D:067E mov AX,0x0018
100D:0681 jmp near 0xCA1B
100D:0684 jmp short 0x06BD
100D:06BD call near 0x0579
100D:06C0 call near 0xC08E
100D:06C3 call near 0xC9E8
100D:06C6 jb short 0x06BC
100D:06C8 call near 0xCC85
100D:06CB je short 0x06C3
100D:06CD ret near
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
100D:127C cmp AL,4
100D:127E jne short 0x128D
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
100D:17D1 mov BP,0x1E76
100D:17D4 mov SI,0xCD9E
100D:17D7 mov ES,word ptr DS:[0xDBD6]
100D:17DB call far dword ptr DS:[0x391D]
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
100D:180A cmp byte ptr DS:[0x00E8],0
100D:180F je short 0x181D
100D:1811 mov byte ptr DS:[0xCE66],1
100D:1816 call near 0x181E
100D:1819 dec byte ptr DS:[0xCE66]
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
100D:1B06 call near 0xC85B
100D:1B09 call near 0xC868
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
100D:1E01 cmp byte ptr DS:[0x002A],0x5D
100D:1E06 jne short 0x1E3E
100D:1E3E clc
100D:1E3F ret near
100D:1F64 cmp byte ptr DS:[0x002A],0x3C
100D:1F69 jae short 0x1F79
100D:1F6B mov AX,word ptr DS:[2]
100D:1F6E sub AX,word ptr DS:[0x1154]
100D:1F72 jb short 0x1F91
100D:1F91 ret near
100D:20A4 test byte ptr DS:[0x00BF],0x80
100D:20A9 je short 0x20D1
100D:20D1 ret near
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
100D:2F13 mov SI,0x220C
100D:2F16 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2F17 movs word ptr ES:[DI],word ptr DS:[SI]
100D:2F18 cmp DL,1
100D:2F1B jne short 0x2F58
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
100D:2FF7 xor AX,AX
100D:2FF9 stos word ptr ES:[DI],AX
100D:2FFA ret near
100D:2FFB cmp byte ptr DS:[0x002B],0
100D:3000 jne short 0x301A
100D:3002 test byte ptr DS:[0x11C9],3
100D:3007 je short 0x3020
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
100D:35AC ret near
100D:35AD cmp byte ptr DS:[0x11C9],0
100D:35B2 jne short 0x35E9
100D:35B4 xor AX,AX
100D:35B6 mov byte ptr DS:[0x001A],AL
100D:35B9 mov byte ptr DS:[0x47A7],AL
100D:35BC xchg AL,byte ptr DS:[0x47A6]
100D:35C0 or AL,AL
100D:35C2 jne short 0x35AC
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
100D:38E0 ret near
100D:38E1 cmp byte ptr DS:[0x46DF],0
100D:38E6 je short 0x38E0
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
100D:3A20 pop AX
100D:3A21 call near 0x3B59
100D:3A24 cmp byte ptr DS:[0x46DF],0
100D:3A29 je short 0x3A7C
100D:3A7C call near 0x39E6
100D:3A7F mov AX,word ptr DS:[4]
100D:3A82 cmp AL,4
100D:3A84 jne short 0x3A94
100D:3A94 ret near
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
100D:4ACA mov byte ptr DS:[0x11CA],1
100D:4ACF ret near
100D:4D00 mov SI,0x4BB9
100D:4D03 jmp near 0xDA5F
100D:4F0C cmp byte ptr DS:[0x4727],0
100D:4F11 je short 0x4F33
100D:4F33 ret near
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
100D:5194 neg AL
100D:5196 clc
100D:5197 ret near
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
100D:5E4F mov CL,byte ptr DS:[SI+8]
100D:5E52 cmp CL,0x20
100D:5E55 jb short 0x5E6A
100D:5E57 inc AX
100D:5E58 cmp CL,0x21
100D:5E5B jb short 0x5E6A
100D:5E6A ret near
100D:5F79 xor AX,AX
100D:5F7B xchg AX,word ptr DS:[0x46F8]
100D:5F7F or AX,AX
100D:5F81 je short 0x5F90
100D:5F90 ret near
100D:63F0 cmp byte ptr DS:[0x46DE],0
100D:63F5 je short 0x642D
100D:642D ret near
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
100D:7F5D pop DI
100D:7F5E ret near
100D:8770 cmp byte ptr DS:[0x1954],0
100D:8775 je short 0x878B
100D:878B ret near
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
100D:88E1 lods AL,byte ptr DS:[SI]
100D:88E2 or AL,AL
100D:88E4 js short 0x88F0
100D:88E6 dec SI
100D:88E7 call near 0x8B11
100D:88EA cmp byte ptr DS:[SI],0xFE
100D:88ED jae short 0x88F0
100D:88F0 ret near
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
100D:8B11 push SI
100D:8B12 call near 0x8C8A
100D:8B15 pop SI
100D:8B16 call near 0x8CCD
100D:8B19 jb short 0x8B10
100D:8B1B call near 0x8F28
100D:8B1E call near 0x8DF0
100D:8B21 mov DX,word ptr DS:[0x4791]
100D:8B25 mov BX,word ptr DS:[0x4793]
100D:8B29 call near 0xD04E
100D:8B2C mov BP,0xA9D0
100D:8B2F mov word ptr DS:[0x479A],0x000A
100D:8B35 mov AL,byte ptr DS:[0x4799]
100D:8B38 and AL,0x0C
100D:8B3A je short 0x8B8B
100D:8B3C cmp AL,8
100D:8B3E jae short 0x8B66
100D:8B66 pushf
100D:8B67 mov AX,word ptr SS:[BP]
100D:8B6A mov AH,0x0A
100D:8B6C mul AH
100D:8B6E mov BX,word ptr DS:[0x478D]
100D:8B72 sub BX,AX
100D:8B74 jae short 0x8B78
100D:8B78 mov word ptr DS:[0x478D],AX
100D:8B7B popf
100D:8B7C jne short 0x8B80
100D:8B7E shr BX,1
100D:8B80 mov DX,word ptr DS:[0xD82C]
100D:8B84 add BX,word ptr DS:[0xD82E]
100D:8B88 call near 0xD04E
100D:8B8B mov DX,word ptr SS:[BP]
100D:8B8E add BP,2
100D:8B91 push DX
100D:8B92 mov CX,word ptr SS:[BP]
100D:8B95 add BP,2
100D:8B98 mov DX,word ptr SS:[BP]
100D:8B9B mov BX,word ptr SS:[BP+2]
100D:8B9E add BP,4
100D:8BA1 jcxz short 0x8C0C
100D:8BA3 test byte ptr DS:[0x4799],2
100D:8BA8 je short 0x8BD1
100D:8BD1 pop AX
100D:8BD2 push AX
100D:8BD3 cmp AX,1
100D:8BD6 je short 0x8BDF
100D:8BD8 test byte ptr DS:[0x4799],1
100D:8BDD jne short 0x8BE5
100D:8BDF mov DX,6
100D:8BE2 mov BX,0
100D:8BE5 mov word ptr DS:[0x479C],BX
100D:8BE9 lods AL,byte ptr DS:[SI]
100D:8BEA or AL,AL
100D:8BEC js short 0x8C26
100D:8BEE cmp AL,0x20
100D:8BF0 je short 0x8C19
100D:8BF2 cmp AL,0x0D
100D:8BF4 je short 0x8C19
100D:8BF6 cmp AL,6
100D:8BF8 je short 0x8C0F
100D:8BFA cmp AL,8
100D:8BFC je short 0x8C14
100D:8BFE cmp AL,1
100D:8C00 jne short 0x8C41
100D:8C19 cmp byte ptr DS:[SI],0x20
100D:8C1C je short 0x8C23
100D:8C1E cmp byte ptr DS:[SI],0x0D
100D:8C21 jne short 0x8C26
100D:8C26 dec CX
100D:8C27 je short 0x8C47
100D:8C29 push DX
100D:8C2A add DX,word ptr DS:[0xD82C]
100D:8C2E cmp word ptr DS:[0x479C],0
100D:8C33 je short 0x8C3A
100D:8C35 inc DX
100D:8C36 dec word ptr DS:[0x479C]
100D:8C3A mov word ptr DS:[0xD82C],DX
100D:8C3E pop DX
100D:8C3F jmp short 0x8BE9
100D:8C41 call near word ptr DS:[0x2518]
100D:8C45 jmp short 0x8BE9
100D:8C47 mov DX,word ptr DS:[0xD830]
100D:8C4B mov BX,word ptr DS:[0xD832]
100D:8C4F mov AX,word ptr DS:[0x479A]
100D:8C52 add BX,AX
100D:8C54 sub word ptr DS:[0x478D],AX
100D:8C58 jae short 0x8C60
100D:8C60 call near 0xD04E
100D:8C63 pop DX
100D:8C64 dec DX
100D:8C65 je short 0x8C6A
100D:8C67 jmp near 0x8B91
100D:8C6A mov DX,word ptr DS:[0xD830]
100D:8C6E mov BX,word ptr DS:[0xD832]
100D:8C72 mov word ptr DS:[0x4791],DX
100D:8C76 mov word ptr DS:[0x4793],BX
100D:8C7A dec SI
100D:8C7B cmp word ptr DS:[0x479E],0x223C
100D:8C81 jne short 0x8C89
100D:8C83 call near 0x9046
100D:8C86 jmp near 0xC07C
100D:8C89 ret near
100D:8C8A xor AX,AX
100D:8C8C xchg AX,word ptr DS:[0x479E]
100D:8C90 cmp AX,2
100D:8C93 jb short 0x8CCC
100D:8C95 mov SI,0x1470
100D:8C98 cmp byte ptr DS:[0x28E7],0
100D:8C9D je short 0x8CB5
100D:8C9F mov BP,0x1BE2
100D:8CA2 mov SI,0x4C60
100D:8CA5 mov ES,word ptr DS:[0xDBDE]
100D:8CA9 call far dword ptr DS:[0x391D]
100D:8CAD mov SI,0x1BE2
100D:8CB0 mov word ptr DS:[SI+8],0
100D:8CB5 call near 0xC446
100D:8CB8 mov SI,word ptr DS:[0x47C8]
100D:8CBC or SI,SI
100D:8CBE je short 0x8CC9
100D:8CC0 mov word ptr DS:[0x4540],0
100D:8CC6 call near 0x9BAC
100D:8CC9 call near 0xC4DD
100D:8CCC ret near
100D:8CCD mov byte ptr DS:[0x4799],9
100D:8CD2 mov word ptr DS:[0xDBE4],0x00F0
100D:8CD8 cmp byte ptr DS:[0x46EB],0
100D:8CDD je short 0x8CFB
100D:8CFB cmp word ptr DS:[0x47C4],-1
100D:8D00 jne short 0x8D1B
100D:8D1B cmp byte ptr DS:[0x00C6],0
100D:8D20 je short 0x8D43
100D:8D43 cmp byte ptr DS:[0x227D],0
100D:8D48 je short 0x8D62
100D:8D62 cmp byte ptr DS:[0x28E7],0
100D:8D67 jne short 0x8D8A
100D:8D69 mov byte ptr DS:[0x4799],1
100D:8D6E mov byte ptr DS:[0xDBE4],0x0F
100D:8D73 mov BP,0x223C
100D:8D76 xor AX,AX
100D:8D78 mov word ptr DS:[0x478A],AX
100D:8D7B inc AX
100D:8D7C mov word ptr DS:[0x4788],AX
100D:8D7F mov AX,0x0010
100D:8D82 mov word ptr DS:[0x4784],AX
100D:8D85 mov word ptr DS:[0x4786],AX
100D:8D88 jmp short 0x8DDB
100D:8D8A mov BP,0x2224
100D:8D8D mov CX,3
100D:8D90 mov AX,word ptr SS:[BP+4]
100D:8D93 sub AX,word ptr DS:[0x4784]
100D:8D97 sub AX,word ptr DS:[0x4786]
100D:8D9B mov word ptr DS:[0x478F],AX
100D:8D9E push SI
100D:8D9F push CX
100D:8DA0 call near 0x8E16
100D:8DA3 pop CX
100D:8DA4 pop SI
100D:8DA5 mov AX,word ptr DS:[0xA9D0]
100D:8DA8 mov AH,0x0A
100D:8DAA mul AH
100D:8DAC add AX,word ptr DS:[0x4788]
100D:8DB0 add AX,word ptr DS:[0x478A]
100D:8DB4 cmp AX,word ptr SS:[BP+6]
100D:8DB7 jb short 0x8DCD
100D:8DB9 add BP,8
100D:8DBC loop 0x8D90
100D:8DCD dec CX
100D:8DCE je short 0x8DEE
100D:8DD0 mov BX,1
100D:8DD3 call near 0xE3B7
100D:8DD6 je short 0x8DEE
100D:8DDB mov AX,word ptr SS:[BP+4]
100D:8DDE sub AX,word ptr DS:[0x4784]
100D:8DE2 sub AX,word ptr DS:[0x4786]
100D:8DE6 mov word ptr DS:[0x478F],AX
100D:8DE9 push SI
100D:8DEA call near 0x8E16
100D:8DED pop SI
100D:8DEE clc
100D:8DEF ret near
100D:8DF0 test byte ptr DS:[0x4799],1
100D:8DF5 je short 0x8E15
100D:8DF7 push SI
100D:8DF8 mov SI,0xA9D0
100D:8DFB lods AX,word ptr DS:[SI]
100D:8DFC mov CX,AX
100D:8DFE lods AX,word ptr DS:[SI]
100D:8DFF or AX,AX
100D:8E01 je short 0x8E08
100D:8E03 cmp word ptr DS:[SI],0x001E
100D:8E06 jae short 0x8E0F
100D:8E08 add SI,4
100D:8E0B loop 0x8DFE
100D:8E0D pop SI
100D:8E0E ret near
100D:8E0F and byte ptr DS:[0x4799],0xFE
100D:8E14 pop SI
100D:8E15 ret near
100D:8E16 push DS
100D:8E17 pop ES
100D:8E18 mov byte ptr DS:[0x478C],0
100D:8E1D mov DI,0xA9D2
100D:8E20 xor DH,DH
100D:8E22 mov BX,word ptr DS:[0x478F]
100D:8E26 xor DL,DL
100D:8E28 mov AL,byte ptr DS:[SI]
100D:8E2A or AL,AL
100D:8E2C js short 0x8E74
100D:8E2E cmp AL,0x0D
100D:8E30 je short 0x8E39
100D:8E32 cmp AL,0x20
100D:8E34 jne short 0x8E4B
100D:8E36 inc SI
100D:8E37 jmp short 0x8E28
100D:8E4B call near 0x8ED3
100D:8E4E or CX,CX
100D:8E50 je short 0x8E28
100D:8E52 add CX,6
100D:8E55 sub BX,CX
100D:8E57 jb short 0x8E5D
100D:8E59 inc DL
100D:8E5B jmp short 0x8E28
100D:8E5D add BX,6
100D:8E60 js short 0x8E69
100D:8E62 inc DL
100D:8E64 call near 0x8E9E
100D:8E67 jmp short 0x8E28
100D:8E69 or DL,DL
100D:8E6B je short 0x8E97
100D:8E6D add BX,CX
100D:8E6F call near 0x8E9E
100D:8E72 jmp short 0x8E55
100D:8E74 or DL,DL
100D:8E76 je short 0x8E7B
100D:8E78 call near 0x8E9E
100D:8E7B mov word ptr DS:[DI-4],6
100D:8E80 mov word ptr DS:[DI-2],0
100D:8E85 mov word ptr DS:[DI],0
100D:8E89 mov word ptr DS:[DI+2],0
100D:8E8E xor DL,DL
100D:8E90 xchg DH,DL
100D:8E92 mov word ptr DS:[0xA9D0],DX
100D:8E96 ret near
100D:8E9E mov AX,DX
100D:8EA0 xor AH,AH
100D:8EA2 stos word ptr ES:[DI],AX
100D:8EA3 add byte ptr DS:[0x478C],AL
100D:8EA7 or AX,AX
100D:8EA9 je short 0x8ECA
100D:8EAB push DX
100D:8EAC mov AX,BX
100D:8EAE mov BX,DX
100D:8EB0 xor BH,BH
100D:8EB2 xor DX,DX
100D:8EB4 dec BX
100D:8EB5 je short 0x8EB9
100D:8EB7 div BX
100D:8EB9 add AX,6
100D:8EBC stos word ptr ES:[DI],AX
100D:8EBD mov AX,DX
100D:8EBF stos word ptr ES:[DI],AX
100D:8EC0 pop DX
100D:8EC1 inc DH
100D:8EC3 xor DL,DL
100D:8EC5 mov BX,word ptr DS:[0x478F]
100D:8EC9 ret near
100D:8ED3 xor CX,CX
100D:8ED5 push BX
100D:8ED6 mov BX,word ptr DS:[0x47A0]
100D:8EDA lods AL,byte ptr DS:[SI]
100D:8EDB cmp AL,0x20
100D:8EDD je short 0x8F25
100D:8EDF cmp AL,0x0D
100D:8EE1 je short 0x8F25
100D:8EE3 or AL,AL
100D:8EE5 je short 0x8EED
100D:8EE7 cmp AL,9
100D:8EE9 jb short 0x8F09
100D:8EEB js short 0x8F25
100D:8EED cmp word ptr DS:[0x2518],0xD0FF
100D:8EF3 jne short 0x8F04
100D:8F04 xlat byte ptr DS:[BX+AL]
100D:8F05 add CL,AL
100D:8F07 jmp short 0x8EDA
100D:8F25 dec SI
100D:8F26 pop BX
100D:8F27 ret near
100D:8F28 mov word ptr DS:[0x479E],BP
100D:8F2C mov DI,0x1BE2
100D:8F2F push DS
100D:8F30 pop ES
100D:8F31 mov AX,word ptr SS:[BP]
100D:8F34 stos word ptr ES:[DI],AX
100D:8F35 mov DX,AX
100D:8F37 add AX,word ptr DS:[0x4784]
100D:8F3B mov word ptr DS:[0x4791],AX
100D:8F3E mov word ptr DS:[0x4795],AX
100D:8F41 mov AX,word ptr SS:[BP+2]
100D:8F44 stos word ptr ES:[DI],AX
100D:8F45 mov BX,AX
100D:8F47 add AX,word ptr DS:[0x4788]
100D:8F4B mov word ptr DS:[0x4793],AX
100D:8F4E mov word ptr DS:[0x4797],AX
100D:8F51 mov AX,word ptr SS:[BP+4]
100D:8F54 add DX,AX
100D:8F56 sub AX,word ptr DS:[0x4784]
100D:8F5A sub AX,word ptr DS:[0x4786]
100D:8F5E mov word ptr DS:[0x478F],AX
100D:8F61 mov AX,word ptr SS:[BP+6]
100D:8F64 add BX,AX
100D:8F66 sub AX,word ptr DS:[0x4788]
100D:8F6A sub AX,word ptr DS:[0x478A]
100D:8F6E mov word ptr DS:[0x478D],AX
100D:8F71 mov AX,DX
100D:8F73 cmp AX,0x0140
100D:8F76 jb short 0x8F7B
100D:8F78 mov AX,0x0140
100D:8F7B stos word ptr ES:[DI],AX
100D:8F7C mov AX,BX
100D:8F7E stos word ptr ES:[DI],AX
100D:8F7F cmp byte ptr DS:[0x46EB],0
100D:8F84 jne short 0x8FD1
100D:8F86 cmp byte ptr DS:[0x00C6],0
100D:8F8B jne short 0x8FF5
100D:8F8D cmp byte ptr DS:[0x227D],0
100D:8F92 jne short 0x8FD0
100D:8F94 cmp byte ptr DS:[0x46D9],0
100D:8F99 jne short 0x8FD0
100D:8F9B cmp byte ptr DS:[0x28E7],0
100D:8FA0 je short 0x900B
100D:8FA2 push SI
100D:8FA3 mov SI,0x4C60
100D:8FA6 mov BP,0x1BE2
100D:8FA9 mov AX,0x0080
100D:8FAC mov word ptr SS:[BP+8],AX
100D:8FAF mov word ptr DS:[0x1C06],AX
100D:8FB2 mov word ptr SS:[BP+0x0C],0x9468
100D:8FB7 mov ES,word ptr DS:[0xDBDE]
100D:8FBB call far dword ptr DS:[0x3919]
100D:8FBF call near 0xC137
100D:8FC2 mov SI,0x1BE2
100D:8FC5 mov ES,word ptr DS:[0xDBD6]
100D:8FC9 mov AX,0x001C
100D:8FCC call near 0xC370
100D:8FCF pop SI
100D:8FD0 ret near
100D:900B mov DI,0x4C60
100D:900E mov CX,0x5960
100D:9011 push DS
100D:9012 pop ES
100D:9013 xor AL,AL
100D:9015 rep stos byte ptr ES:[DI],AL
100D:9017 mov AX,0x4C6F
100D:901A and AL,0xF0
100D:901C mov word ptr DS:[0x22FC],AX
100D:901F call near 0xC085
100D:9022 jmp near 0x8895
100D:9025 mov CX,word ptr DS:[0x4793]
100D:9029 mov BX,0x0092
100D:902C sub BX,CX
100D:902E xor DX,DX
100D:9030 mov CH,0xFF
100D:9032 mov DI,0x0140
100D:9035 mov SI,word ptr DS:[0x22FC]
100D:9039 mov ES,word ptr DS:[0xDBDA]
100D:903D mov word ptr DS:[0x4782],BX
100D:9041 call far dword ptr DS:[0x38C9]
100D:9045 ret near
100D:9046 push DS
100D:9047 pop ES
100D:9048 mov AX,word ptr DS:[0x4793]
100D:904B mul word ptr DS:[0x2240]
100D:904F mov CX,AX
100D:9051 mov DI,word ptr DS:[0x22FC]
100D:9055 mov AX,0xF00F
100D:9058 xor BX,BX
100D:905A cmp byte ptr DS:[0x00EA],0
100D:905F jle short 0x9063
100D:9063 repne scas AL,byte ptr ES:[DI]
100D:9065 jne short 0x908B
100D:9067 cmp byte ptr DS:[DI-2],BL
100D:906A jne short 0x906F
100D:906C mov byte ptr DS:[DI-2],AH
100D:906F cmp byte ptr DS:[DI],BL
100D:9071 jne short 0x9075
100D:9073 mov byte ptr DS:[DI],AH
100D:9075 cmp byte ptr DS:[DI-321],BL
100D:9079 jne short 0x907F
100D:907B mov byte ptr DS:[DI-321],AH
100D:907F cmp byte ptr DS:[DI+0x013F],BL
100D:9083 jne short 0x9063
100D:9085 mov byte ptr DS:[DI+0x013F],AH
100D:9089 jmp short 0x9063
100D:908B ret near
100D:908C mov AX,word ptr DS:[0xD83A]
100D:908F cmp AX,word ptr DS:[0x4782]
100D:9093 jbe short 0x90BC
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
100D:92A9 loop 0x9291
100D:92AB mov AX,word ptr DS:[0x472D]
100D:92AE or AX,AX
100D:92B0 je short 0x92C8
100D:92C8 ret near
100D:92C9 xor CX,CX
100D:92CB mov CL,byte ptr DS:[0x1152]
100D:92CF cmp CL,0xFF
100D:92D2 je short 0x9281
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
100D:97C5 call near 0x9025
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
100D:99E8 mov SI,word ptr DS:[0x47C6]
100D:99EC mov ES,word ptr DS:[0xDBB2]
100D:99F0 cmp byte ptr ES:[SI],0xFF
100D:99F4 je short 0x9A1D
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
100D:9A1D cmp word ptr DS:[0x47CE],0
100D:9A22 js short 0x9A3B
100D:9A24 mov SI,word ptr DS:[0x47CA]
100D:9A28 mov ES,word ptr DS:[0xDBB2]
100D:9A2C call near 0x994F
100D:9A2F add SI,word ptr ES:[BP+SI]
100D:9A32 call near 0x996C
100D:9A35 mov word ptr DS:[0x47C6],SI
100D:9A39 jmp short 0x99F0
100D:9A3B or byte ptr DS:[0x47D1],0x10
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
100D:9EFC ret near
100D:9EFD mov AL,byte ptr DS:[0x47DC]
100D:9F00 mov byte ptr DS:[0x47DD],AL
100D:9F03 mov AX,word ptr DS:[0x4780]
100D:9F06 mov BX,word ptr DS:[0x47C4]
100D:9F0A call near 0xA6CC
100D:9F0D jae short 0x9EFC
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
100D:A04F xor AH,AH
100D:A051 push SI
100D:A052 dec AX
100D:A053 shl AX,1
100D:A055 mov BX,0xA107
100D:A058 add BX,AX
100D:A05A call near word ptr CS:[BX]
100D:A05D pop SI
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
100D:A0A7 mov SI,0xFFFF
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
100D:A103 ret near
100D:A1E8 inc byte ptr DS:[0x47A8]
100D:A1EC ret near
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
100D:A334 and BX,0x001F
100D:A337 jmp near word ptr CS:[BX-23690]
100D:A342 and DX,AX
100D:A344 ret near
100D:A345 or DX,AX
100D:A347 ret near
100D:A348 cmp DX,AX
100D:A34A je short 0xA372
100D:A34C xor DX,DX
100D:A34E ret near
100D:A34F cmp DX,AX
100D:A351 jb short 0xA372
100D:A356 cmp DX,AX
100D:A358 ja short 0xA372
100D:A35A xor DX,DX
100D:A35C ret near
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
100D:A3F0 mov AX,0x1AD6
100D:A3F3 call near 0xD95E
100D:A3F6 call near 0xD2BD
100D:A3F9 push word ptr DS:[0xDBDA]
100D:A3FD call near 0xC08E
100D:A400 mov AX,0x0055
100D:A403 call near 0xC13E
100D:A406 xor AX,AX
100D:A408 mov DX,word ptr DS:[0x2886]
100D:A40C mov BX,word ptr DS:[0x2888]
100D:A410 call near 0xC22F
100D:A413 pop word ptr DS:[0xDBDA]
100D:A417 call near 0xA4C6
100D:A41A call near 0xA47D
100D:A41D call near 0xA42C
100D:A420 call near 0xA44C
100D:A423 call near 0xAC3A
100D:A426 mov BX,0xA541
100D:A429 jmp near 0xD32F
100D:A42C mov AX,0x0055
100D:A42F call near 0xC13E
100D:A432 mov AL,byte ptr DS:[0xCEEB]
100D:A435 push word ptr DS:[0xDBDA]
100D:A439 call near 0xC08E
100D:A43C cbw
100D:A43D call near 0xA465
100D:A440 shl AX,1
100D:A442 add AL,0x1C
100D:A444 call near 0xC22F
100D:A447 pop word ptr DS:[0xDBDA]
100D:A44B ret near
100D:A44C mov AL,byte ptr DS:[0x28E7]
100D:A44F add AL,8
100D:A451 jmp short 0xA435
100D:A453 sub DX,word ptr DS:[0x2886]
100D:A457 sub BX,word ptr DS:[0x2888]
100D:A45B ret near
100D:A45C add DX,word ptr DS:[0x2886]
100D:A460 add BX,word ptr DS:[0x2888]
100D:A464 ret near
100D:A465 push AX
100D:A466 mov DX,word ptr DS:[0x28C7]
100D:A46A mov BX,0x28DC
100D:A46D xlat byte ptr DS:[BX+AL]
100D:A46E mov BL,7
100D:A470 mul BL
100D:A472 mov BX,AX
100D:A474 add BX,word ptr DS:[0x28C9]
100D:A478 call near 0xA45C
100D:A47B pop AX
100D:A47C ret near
100D:A47D test word ptr DS:[0xDBC8],8
100D:A483 je short 0xA48B
100D:A48B test word ptr DS:[0xDBC8],0x0800
100D:A491 je short 0xA4C5
100D:A493 mov SI,0x28AE
100D:A496 call near 0xA49C
100D:A499 mov SI,0x28B6
100D:A49C push word ptr DS:[0xDBDA]
100D:A4A0 call near 0xC08E
100D:A4A3 mov AX,0x0055
100D:A4A6 call near 0xC13E
100D:A4A9 lods AL,byte ptr DS:[SI]
100D:A4AA aam
100D:A4AC mov AL,AH
100D:A4AE xor AH,AH
100D:A4B0 add AL,3
100D:A4B2 mov byte ptr DS:[SI],1
100D:A4B5 inc SI
100D:A4B6 mov DX,word ptr DS:[SI]
100D:A4B8 mov BX,word ptr DS:[SI+2]
100D:A4BB call near 0xA45C
100D:A4BE call near 0xC22F
100D:A4C1 pop word ptr DS:[0xDBDA]
100D:A4C5 ret near
100D:A4C6 call near 0xAE2F
100D:A4C9 je short 0xA4DE
100D:A4DE call near 0xAE28
100D:A4E1 je short 0xA540
100D:A4E3 mov SI,0x2896
100D:A4E6 call near 0xA502
100D:A4E9 mov SI,0x289E
100D:A4EC call near 0xA502
100D:A4EF test word ptr DS:[0xDBC8],0x0400
100D:A4F5 jne short 0xA540
100D:A502 push word ptr DS:[0xDBDA]
100D:A506 call near 0xC08E
100D:A509 push SI
100D:A50A mov AX,0x0055
100D:A50D call near 0xC13E
100D:A510 mov DX,word ptr DS:[SI+2]
100D:A513 mov BX,0x0022
100D:A516 call near 0xA45C
100D:A519 mov AX,1
100D:A51C call near 0xC2FD
100D:A51F pop SI
100D:A520 lods AL,byte ptr DS:[SI]
100D:A521 mov byte ptr DS:[SI],1
100D:A524 not AX
100D:A526 shr AL,1
100D:A528 shr AL,1
100D:A52A cbw
100D:A52B add AX,BX
100D:A52D mov BX,AX
100D:A52F sub AX,word ptr DS:[0x2888]
100D:A533 mov word ptr DS:[SI+3],AX
100D:A536 mov AX,2
100D:A539 call near 0xC22F
100D:A53C pop word ptr DS:[0xDBDA]
100D:A540 ret near
100D:A541 mov AL,byte ptr DS:[0x28E7]
100D:A544 mov byte ptr DS:[0x28E8],AL
100D:A547 call near 0xDAA3
100D:A54A call near 0xD95B
100D:A54D mov SI,0x2886
100D:A550 jmp near 0xC4F0
100D:A576 mov DI,0x2886
100D:A579 call near 0xD6FE
100D:A57C jb short 0xA581
100D:A581 call near 0xA453
100D:A584 mov DI,0x28BF
100D:A587 call near 0xD6FE
100D:A58A jb short 0xA553
100D:A58C mov DI,0x28C7
100D:A58F call near 0xD6FE
100D:A592 jb short 0xA5B0
100D:A5AA mov byte ptr DS:[0x28BE],0
100D:A5AF ret near
100D:A5B0 sub BX,word ptr DS:[DI+2]
100D:A5B3 mov AX,BX
100D:A5B5 mov BL,7
100D:A5B7 div BL
100D:A5B9 mov BX,0x28CF
100D:A5BC xlat byte ptr DS:[BX+AL]
100D:A5BD cmp AL,7
100D:A5BF jb short 0xA5CA
100D:A5C1 je short 0xA5DE
100D:A5C3 sub AL,8
100D:A5C5 mov byte ptr DS:[0x28E7],AL
100D:A5C8 jmp short 0xA5DB
100D:A5CA cmp AL,byte ptr DS:[0xCEEB]
100D:A5CE je short 0xA5DE
100D:A5D0 and byte ptr DS:[0x28E7],0xFD
100D:A5D5 mov byte ptr DS:[0xCEEB],AL
100D:A5D8 call near 0xCFE4
100D:A5DB jmp near 0xA3F9
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
100D:A74A xor byte ptr DS:[0x37E2],6
100D:A74F call near 0xA83F
100D:A752 jae short 0xA75B
100D:A75B ret near
100D:A788 ret near
100D:A7A5 mov SI,0xA7C2
100D:A7A8 call near 0xDA5F
100D:A7AB mov word ptr DS:[0xDC26],0
100D:A7B1 call near 0xD61D
100D:A7B4 call near 0xABCC
100D:A7B7 je short 0xA788
100D:A7C2 call near 0xABCC
100D:A7C5 je short 0xA788
100D:A83F mov word ptr DS:[0xDC26],0
100D:A845 call near 0xAE2F
100D:A848 je short 0xA87D
100D:A87D ret near
100D:A87E pushf
100D:A87F sti
100D:A880 call near 0xAE2F
100D:A883 je short 0xA8AF
100D:A8AF popf
100D:A8B0 ret near
100D:A8B1 and AL,0x0F
100D:A8B3 add AL,0x30
100D:A8B5 cmp AL,0x39
100D:A8B7 jbe short 0xA8BB
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
100D:A9A1 xor BX,BX
100D:A9A3 xchg BX,word ptr DS:[0x3821]
100D:A9A7 or BX,BX
100D:A9A9 je short 0xA9B7
100D:A9B7 clc
100D:A9B8 ret near
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
100D:AAEF cmp DH,0x20
100D:AAF2 jae short 0xAB08
100D:AB08 mov AL,0x0C
100D:AB0A jne short 0xAB14
100D:AB0C dec AX
100D:AB0D cmp DL,3
100D:AB10 jne short 0xAB14
100D:AB14 ret near
100D:ABA3 cmp word ptr DS:[0x3821],0
100D:ABA8 ret near
100D:ABCC cmp byte ptr DS:[0xDC2B],0
100D:ABD1 ret near
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
100D:AC3A mov BP,0x201A
100D:AC3D or byte ptr SS:[BP+3],0x40
100D:AC41 or byte ptr SS:[BP+7],0x40
100D:AC45 or byte ptr SS:[BP+0x0B],0x40
100D:AC49 mov CL,0xFF
100D:AC4B call near 0xAE28
100D:AC4E je short 0xAC6D
100D:AC50 and byte ptr SS:[BP+3],0xBF
100D:AC54 and byte ptr SS:[BP+7],0xBF
100D:AC58 and byte ptr SS:[BP+0x0B],0xBF
100D:AC5C xor CX,CX
100D:AC5E test byte ptr DS:[0x2943],0x10
100D:AC63 jne short 0xAC6D
100D:AC65 mov CL,byte ptr DS:[0x3810]
100D:AC69 and CL,1
100D:AC6C inc CX
100D:AC6D ret near
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
100D:AD89 and AL,0x3F
100D:AD8B mov byte ptr DS:[0xDBCC],AL
100D:AD8E cmp AL,byte ptr DS:[0xDBCB]
100D:AD92 jne short 0xADBE
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
100D:AE04 call near 0xAEC6
100D:AE07 jb short 0xADBD
100D:AE09 test byte ptr DS:[0x3810],1
100D:AE0E jne short 0xADBD
100D:AE10 cmp byte ptr DS:[0xDBCD],0
100D:AE15 jns short 0xAE1E
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
100D:C2FD push BX
100D:C2FE push DX
100D:C2FF call near 0xC22F
100D:C302 pop DX
100D:C303 pop BX
100D:C304 ret near
100D:C370 push DS
100D:C371 push DS
100D:C372 push AX
100D:C373 push SI
100D:C374 call far dword ptr DS:[0x38D9]
100D:C378 pop SI
100D:C379 pop AX
100D:C37A pop DS
100D:C37B mov DX,word ptr DS:[SI]
100D:C37D push DX
100D:C37E mov BX,word ptr DS:[SI+2]
100D:C381 push BX
100D:C382 mov CX,word ptr DS:[SI+4]
100D:C385 sub CX,DX
100D:C387 push CX
100D:C388 mov CX,word ptr DS:[SI+6]
100D:C38B sub CX,BX
100D:C38D push CX
100D:C38E lds SI,word ptr DS:[0xDBB0]
100D:C392 mov BP,AX
100D:C394 shl BP,1
100D:C396 add SI,word ptr DS:[BP+SI]
100D:C399 lods AX,word ptr DS:[SI]
100D:C39A mov DI,AX
100D:C39C and AX,0x01FF
100D:C39F push AX
100D:C3A0 lods AX,word ptr DS:[SI]
100D:C3A1 mov CX,AX
100D:C3A3 xor AH,AH
100D:C3A5 push AX
100D:C3A6 call far dword ptr SS:[0x38C9]
100D:C3AB push ES
100D:C3AC pop DS
100D:C3AD mov BP,SP
100D:C3AF mov DX,word ptr SS:[BP+0x0A]
100D:C3B2 mov BX,word ptr SS:[BP+8]
100D:C3B5 push BX
100D:C3B6 push DX
100D:C3B7 push word ptr SS:[BP]
100D:C3BA push word ptr SS:[BP+2]
100D:C3BD push BX
100D:C3BE push DX
100D:C3BF mov BP,SP
100D:C3C1 mov DX,word ptr SS:[BP+0x12]
100D:C3C4 sub DX,word ptr SS:[BP+4]
100D:C3C7 mov AX,word ptr SS:[BP+4]
100D:C3CA add word ptr SS:[BP+8],AX
100D:C3CD sub DX,AX
100D:C3CF jae short 0xC3D4
100D:C3D1 add word ptr SS:[BP+4],DX
100D:C3D4 push DX
100D:C3D5 call far dword ptr SS:[0x3931]
100D:C3DA pop DX
100D:C3DB cmp DX,0
100D:C3DE jg short 0xC3C7
100D:C3E0 mov AX,word ptr SS:[BP+0x12]
100D:C3E3 mov word ptr SS:[BP+4],AX
100D:C3E6 mov AX,word ptr SS:[BP]
100D:C3E9 mov word ptr SS:[BP+8],AX
100D:C3EC mov BX,word ptr SS:[BP+0x10]
100D:C3EF sub BX,word ptr SS:[BP+6]
100D:C3F2 je short 0xC40D
100D:C3F4 mov AX,word ptr SS:[BP+6]
100D:C3F7 add word ptr SS:[BP+0x0A],AX
100D:C3FA sub BX,AX
100D:C3FC jae short 0xC401
100D:C3FE add word ptr SS:[BP+6],BX
100D:C401 push BX
100D:C402 call far dword ptr SS:[0x3931]
100D:C407 pop BX
100D:C408 cmp BX,0
100D:C40B jg short 0xC3F4
100D:C40D add SP,0x0018
100D:C410 pop DS
100D:C411 ret near
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
100D:C85B mov AX,word ptr DS:[0xCE7A]
100D:C85E mov word ptr DS:[0x476E],AX
100D:C861 mov word ptr DS:[0x4772],0x1770
100D:C867 ret near
100D:C868 call near 0xABCC
100D:C86B jne short 0xC8C0
100D:C86D mov SI,word ptr DS:[0x22A6]
100D:C871 cmp SI,0x0011
100D:C875 jae short 0xC8C0
100D:C877 shl SI,1
100D:C879 shl SI,1
100D:C87B mov DX,word ptr DS:[SI+0x27B6]
100D:C87F mov BX,word ptr DS:[SI+0x27B8]
100D:C883 mov AX,BX
100D:C885 or AX,DX
100D:C887 je short 0xC8C0
100D:C889 mov SI,0x2792
100D:C88C cmp byte ptr DS:[0x227D],0
100D:C891 jne short 0xC8A3
100D:C893 push BX
100D:C894 mov BX,1
100D:C897 call near 0xE3B7
100D:C89A pop BX
100D:C89B mov SI,0x2789
100D:C89E je short 0xC8A3
100D:C8A0 mov SI,0x278E
100D:C8A3 lods AL,byte ptr DS:[SI]
100D:C8A4 or AL,AL
100D:C8A6 je short 0xC8BD
100D:C8A8 jns short 0xC8B2
100D:C8AA mov AX,0x012C
100D:C8AD call near 0xE387
100D:C8B0 jmp short 0xC8A3
100D:C8B2 push SI
100D:C8B3 xor AH,AH
100D:C8B5 mov BP,AX
100D:C8B7 call near 0xC8C1
100D:C8BA pop SI
100D:C8BB jmp short 0xC8A3
100D:C8BD call near 0xC4DD
100D:C8C0 ret near
100D:C8C1 push BX
100D:C8C2 push DX
100D:C8C3 push word ptr DS:[0xCE7A]
100D:C8C7 mov SI,BP
100D:C8C9 shl SI,1
100D:C8CB shl SI,1
100D:C8CD sub DX,word ptr DS:[SI+0x2796]
100D:C8D1 jae short 0xC8D5
100D:C8D3 xor DX,DX
100D:C8D5 sub BX,word ptr DS:[SI+0x2798]
100D:C8D9 jae short 0xC8DD
100D:C8DB xor BX,BX
100D:C8DD push DS
100D:C8DE mov ES,word ptr DS:[0xDBD8]
100D:C8E2 mov DS,word ptr DS:[0xDBD6]
100D:C8E6 call far dword ptr SS:[0x3949]
100D:C8EB pop DS
100D:C8EC pop BX
100D:C8ED mov AX,word ptr DS:[0xCE7A]
100D:C8F0 sub AX,BX
100D:C8F2 cmp AL,byte ptr DS:[0xDBE6]
100D:C8F6 jb short 0xC8ED
100D:C8F8 pop DX
100D:C8F9 pop BX
100D:C8FA ret near
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
100D:C9E8 call near 0xCA60
100D:C9EB call near 0xDD63
100D:C9EE jb short 0xC9F1
100D:C9F0 ret near
100D:C9F1 jmp near 0xDE4E
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
100D:CA86 call near 0xCE3B
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
100D:CB4C or byte ptr DS:[0xDBE7],1
100D:CB51 cmp word ptr DS:[0xDC1A],0
100D:CB56 jne short 0xCB60
100D:CB58 or byte ptr DS:[0xDBE7],2
100D:CB5D call near 0xCA01
100D:CB60 ret near
100D:CB61 test byte ptr DS:[0xDBFE],1
100D:CB66 je short 0xCB4C
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
100D:CC8C cmp byte ptr DS:[0xDBE7],1
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
100D:CCBB mov ES,word ptr DS:[0xDBDA]
100D:CCBF mov BX,word ptr DS:[0xDC00]
100D:CCC3 mov DS,BP
100D:CCC5 lods AX,word ptr DS:[SI]
100D:CCC6 and AH,0xF9
100D:CCC9 mov DI,AX
100D:CCCB lods AX,word ptr DS:[SI]
100D:CCCC mov CX,AX
100D:CCCE or CL,CL
100D:CCD0 je short 0xCCE1
100D:CCD2 lods AX,word ptr DS:[SI]
100D:CCD3 mov DX,AX
100D:CCD5 lods AX,word ptr DS:[SI]
100D:CCD6 xchg BX,AX
100D:CCD7 cmp AX,0x0019
100D:CCDA jae short 0xCCE3
100D:CCDC call far dword ptr SS:[0x38C9]
100D:CCE1 pop DS
100D:CCE2 ret near
100D:CCE3 call far dword ptr CS:[0xCC92]
100D:CCE8 pop DS
100D:CCE9 ret near
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
100D:CD13 call near 0xAE2F
100D:CD16 je short 0xCD1C
100D:CD1C lods AX,word ptr ES:[SI]
100D:CD1E sub AX,4
100D:CD21 add SI,AX
100D:CD23 lods AX,word ptr ES:[SI]
100D:CD25 cmp AX,0x6C70
100D:CD28 jne short 0xCD37
100D:CD2A lods AX,word ptr ES:[SI]
100D:CD2C mov word ptr DS:[0xDC1E],SI
100D:CD30 sub AX,4
100D:CD33 add SI,AX
100D:CD35 jmp short 0xCD0C
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
100D:CD72 stos word ptr ES:[DI],AX
100D:CD73 xchg CX,AX
100D:CD74 stos word ptr ES:[DI],AX
100D:CD75 jcxz short 0xCD7F
100D:CD77 test CH,2
100D:CD7A je short 0xCD81
100D:CD7C call near 0xF403
100D:CD7F pop DS
100D:CD80 ret near
100D:CD81 sub SI,4
100D:CD84 mov AX,DS
100D:CD86 pop DS
100D:CD87 mov word ptr DS:[0xDC14],SI
100D:CD8B mov word ptr DS:[0xDC16],AX
100D:CD8E ret near
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
100D:CE3B les SI,word ptr DS:[0xDC0C]
100D:CE3F mov SI,word ptr DS:[0xDC1E]
100D:CE43 call near 0xC1BA
100D:CE46 call far dword ptr DS:[0x3935]
100D:CE4A ret near
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
100D:CEFC mov AX,0x0069
100D:CEFF add AL,byte ptr DS:[0xCEEB]
100D:CF03 call near 0xC13E
100D:CF06 mov word ptr DS:[0x3622],0x35A8
100D:CF0C xor AX,AX
100D:CF0E call far dword ptr DS:[0x3939]
100D:CF12 call near 0xC0AD
100D:CF15 mov AX,0x0019
100D:CF18 jmp near 0xCA1B
100D:CF1B push word ptr DS:[0xDBDA]
100D:CF1F call near 0xC08E
100D:CF22 mov SI,word ptr DS:[0x3622]
100D:CF26 lods AX,word ptr DS:[SI]
100D:CF27 cmp AX,word ptr DS:[0xDBE8]
100D:CF2B ja short 0xCF30
100D:CF30 call near 0xC9E8
100D:CF33 jb short 0xCF3B
100D:CF35 call near 0xCC85
100D:CF38 je short 0xCF22
100D:CF3B pushf
100D:CF3C call near 0xCA01
100D:CF3F call near 0xAC14
100D:CF42 call near 0xAD57
100D:CF45 popf
100D:CF46 pop word ptr DS:[0xDBDA]
100D:CF4A ret near
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
100D:CFEE mov SI,0x00C7
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
100D:D096 push AX
100D:D097 push BX
100D:D098 push CX
100D:D099 push DX
100D:D09A push SI
100D:D09B push DI
100D:D09C push BP
100D:D09D push ES
100D:D09E xor AH,AH
100D:D0A0 mov SI,AX
100D:D0A2 shl SI,1
100D:D0A4 shl SI,1
100D:D0A6 shl SI,1
100D:D0A8 add SI,AX
100D:D0AA add SI,word ptr DS:[0x2514]
100D:D0AE mov BX,0xCEEC
100D:D0B1 xlat byte ptr DS:[BX+AL]
100D:D0B2 call near 0xD05F
100D:D0B5 add word ptr DS:[0xD82C],AX
100D:D0B9 mov CL,AL
100D:D0BB mov CH,9
100D:D0BD mov AX,word ptr DS:[0xDBE4]
100D:D0C0 mov ES,word ptr DS:[0xDBDA]
100D:D0C4 call far dword ptr DS:[0x38D1]
100D:D0C8 pop ES
100D:D0C9 pop BP
100D:D0CA pop DI
100D:D0CB pop SI
100D:D0CC pop DX
100D:D0CD pop CX
100D:D0CE pop BX
100D:D0CF pop AX
100D:D0D0 ret near
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
100D:D32F call near 0xD316
100D:D332 call near 0xD33A
100D:D335 jmp near 0xD280
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
100D:D38D shl CX,1
100D:D38F shl CX,1
100D:D391 mov BX,CX
100D:D393 or byte ptr DS:[BX+SI+3],0x80
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
100D:D3C0 cmp byte ptr DS:[0xDCE4],0
100D:D3C5 jne short 0xD3CD
100D:D3C7 cmp word ptr DS:[SI+4],0
100D:D3CB je short 0xD3D9
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
100D:D3ED jmp short 0xD410
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
100D:D42F mov CX,4
100D:D432 jmp short 0xD445
100D:D434 mov CX,3
100D:D437 jmp short 0xD445
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
100D:D6CC sub CX,5
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
100D:DA90 dec CX
100D:DA91 je short 0xDA72
100D:DAA3 mov word ptr DS:[0xDC58],0
100D:DAA9 ret near
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
100D:DDB0 call near 0xE270
100D:DDB3 push AX
100D:DDB4 mov byte ptr DS:[0xCEE8],0
100D:DDB9 cmp byte ptr DS:[0x227D],0
100D:DDBE jne short 0xDDC3
100D:DDC3 mov SI,0xFFFF
100D:DDC6 mov DI,SI
100D:DDC8 pop CX
100D:DDC9 sti
100D:DDCA push word ptr DS:[0xCE7A]
100D:DDCE push CX
100D:DDCF call near 0xDD63
100D:DDD2 pop CX
100D:DDD3 pop AX
100D:DDD4 jb short 0xDDE7
100D:DDD6 mov BX,AX
100D:DDD8 mov AX,BX
100D:DDDA sub AX,word ptr SS:[0xCE7A]
100D:DDDF je short 0xDDD8
100D:DDE1 add CX,AX
100D:DDE3 jb short 0xDDCA
100D:DDE5 or AL,1
100D:DDE7 pushf
100D:DDE8 call near 0xDE4E
100D:DDEB popf
100D:DDEC call near 0xE283
100D:DDEF ret near
100D:DDF0 cmp byte ptr DS:[0xDBCD],0
100D:DDF5 js short 0xDE07
100D:DDF7 call near 0xABA3
100D:DDFA je short 0xDDB0
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
100D:DE41 push BX
100D:DE42 call near 0xDD63
100D:DE45 pop BX
100D:DE46 jb short 0xDDE7
100D:DE48 jmp short 0xDE20
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
100D:F049 pop DS
100D:F04A pop DI
100D:F04B pop CX
100D:F04C pop AX
100D:F04D jmp far 0800:0011
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
3358:0133 jmp near 0x1BCA
3358:0139 jmp near 0x1A07
3358:013C ret far
3358:014B jmp near 0x1C46
3358:014E jmp near 0x1C76
3358:0151 jmp near 0x25E7
3358:0154 jmp near 0x0975
3358:015A jmp near 0x3200
3358:015D jmp near 0x19C9
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
3358:0E12 add DI,0x0140
3358:0E16 mov BX,word ptr CS:[0x0D83]
3358:0E1B add BX,BP
3358:0E1D mov word ptr CS:[0x0D83],BX
3358:0E22 loop 0x0DDD
3358:0E24 cld
3358:0E25 ret far
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
3358:0E5E inc DI
3358:0E5F loop 0x0E41
3358:0E61 or BP,BP
3358:0E63 ja short 0x0E35
3358:0E65 dec BX
3358:0E66 jne short 0x0E2D
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
3358:0E83 add DI,CX
3358:0E85 or BP,BP
3358:0E87 ja short 0x0E35
3358:0E89 dec BX
3358:0E8A jne short 0x0E2D
3358:0E8C jmp short 0x0E50
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
3358:0FD6 jmp near 0x0C46
3358:0FD9 mov word ptr CS:[0x0CD6],BP
3358:0FDE test AX,0x2000
3358:0FE1 je short 0x0FFB
3358:0FFB add DI,word ptr CS:[0x0D81]
3358:1000 dec DI
3358:1001 std
3358:1002 jmp near 0x0CE0
3358:100A or DI,DI
3358:100C js short 0x1064
3358:100E mov BP,DI
3358:1010 and BP,0x01FF
3358:1014 mov AX,DI
3358:1016 call near 0x0C10
3358:1019 mov BX,CX
3358:101B xor BH,BH
3358:101D cmp CH,0xFF
3358:1020 je short 0x1043
3358:1022 shr BP,1
3358:1024 mov AX,DI
3358:1026 jb short 0x1035
3358:1028 mov CX,BP
3358:102A mov DI,AX
3358:102C rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:102E add AX,0x0140
3358:1031 dec BX
3358:1032 jne short 0x1028
3358:1034 ret far
3358:1043 mov DX,DI
3358:1045 mov CX,BP
3358:1047 mov DI,DX
3358:1049 lods AL,byte ptr DS:[SI]
3358:104A or AL,AL
3358:104C je short 0x1059
3358:104E stos byte ptr ES:[DI],AL
3358:104F loop 0x1049
3358:1051 add DX,0x0140
3358:1055 dec BX
3358:1056 jne short 0x1045
3358:1058 ret far
3358:1059 inc DI
3358:105A loop 0x1049
3358:105C add DX,0x0140
3358:1060 dec BX
3358:1061 jne short 0x1045
3358:1063 ret far
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
3358:1204 or DL,DL
3358:1206 js short 0x1235
3358:1208 jmp short 0x1218
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
3358:1302 stos byte ptr ES:[DI],AL
3358:1303 inc DI
3358:1304 loop 0x1302
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
3358:19C9 mov DX,word ptr SS:[BP]
3358:19CC mov BX,word ptr SS:[BP+2]
3358:19CF call near 0x0C10
3358:19D2 mov SI,DI
3358:19D4 mov DX,word ptr SS:[BP+8]
3358:19D7 mov BX,word ptr SS:[BP+0x0A]
3358:19DA call near 0x0C10
3358:19DD mov DX,word ptr SS:[BP+4]
3358:19E0 mov BX,word ptr SS:[BP+6]
3358:19E3 mov CX,DX
3358:19E5 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:19E7 sub SI,DX
3358:19E9 sub DI,DX
3358:19EB add SI,0x0140
3358:19EF add DI,0x0140
3358:19F3 dec BX
3358:19F4 jne short 0x19E3
3358:19F6 ret far
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
3358:1ADC push DI
3358:1ADD push SI
3358:1ADE or BX,BX
3358:1AE0 jne short 0x1AE5
3358:1AE2 jmp near 0x1A3A
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
3358:1BCA mov BP,DI
3358:1BCC and BP,0x01FF
3358:1BD0 call near 0x0C10
3358:1BD3 mov DX,CX
3358:1BD5 xor DH,DH
3358:1BD7 mov CX,BP
3358:1BD9 push DI
3358:1BDA movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:1BDB inc DI
3358:1BDC loop 0x1BDA
3358:1BDE pop DI
3358:1BDF add DI,0x0280
3358:1BE3 dec DX
3358:1BE4 jne short 0x1BD7
3358:1BE6 ret far
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
3358:1C1F mov CL,DL
3358:1C21 lods AL,byte ptr DS:[SI]
3358:1C22 mov AH,AL
3358:1C24 mov AL,BL
3358:1C26 shl AH,1
3358:1C28 jb short 0x1C38
3358:1C2A inc DI
3358:1C2B loop 0x1C26
3358:1C2D add BP,0x0140
3358:1C31 mov DI,BP
3358:1C33 dec DH
3358:1C35 jne short 0x1C1F
3358:1C37 ret far
3358:1C38 stos byte ptr ES:[DI],AL
3358:1C39 loop 0x1C26
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
3358:1C76 mov DX,word ptr SS:[BP]
3358:1C79 mov BX,word ptr SS:[BP+2]
3358:1C7C call near 0x0C10
3358:1C7F mov CX,word ptr SS:[BP+4]
3358:1C82 mov AX,word ptr SS:[BP+6]
3358:1C85 sub CX,DX
3358:1C87 sub AX,BX
3358:1C89 mov DX,0x0140
3358:1C8C sub DX,CX
3358:1C8E push CX
3358:1C8F shr CX,1
3358:1C91 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:1C93 adc CX,CX
3358:1C95 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:1C97 pop CX
3358:1C98 add DI,DX
3358:1C9A dec AX
3358:1C9B jne short 0x1C8E
3358:1C9D push SS
3358:1C9E pop DS
3358:1C9F ret far
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
3358:2757 push CS
3358:2758 call near 0x0B0C
3358:275B mov DI,word ptr CS:[0x01A3]
3358:2760 mov SI,DI
3358:2762 mov CX,0x5F00
3358:2765 rep movs word ptr ES:[DI],word ptr DS:[SI]
3358:2767 ret far
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
3358:3A9D mov BX,0x0032
3358:3AA0 mov CX,0x006A
3358:3AA3 push CX
3358:3AA4 lods AL,byte ptr DS:[SI]
3358:3AA5 mov AH,AL
3358:3AA7 stos word ptr ES:[DI],AX
3358:3AA8 movs byte ptr ES:[DI],byte ptr DS:[SI]
3358:3AA9 loop 0x3AA4
3358:3AAB lods AL,byte ptr DS:[SI]
3358:3AAC mov AH,AL
3358:3AAE stos word ptr ES:[DI],AX
3358:3AAF pop CX
3358:3AB0 add SI,CX
3358:3AB2 inc SI
3358:3AB3 lods AL,byte ptr DS:[SI]
3358:3AB4 mov AH,AL
3358:3AB6 mov word ptr ES:[DI+0x0140],AX
3358:3ABB stos word ptr ES:[DI],AX
3358:3ABC lods AL,byte ptr DS:[SI]
3358:3ABD mov byte ptr ES:[DI+0x0140],AL
3358:3AC2 stos byte ptr ES:[DI],AL
3358:3AC3 loop 0x3AB3
3358:3AC5 lods AL,byte ptr DS:[SI]
3358:3AC6 mov AH,AL
3358:3AC8 mov word ptr ES:[DI+0x0140],AX
3358:3ACD stos word ptr ES:[DI],AX
3358:3ACE add SI,0x006B
3358:3AD1 add DI,0x0140
3358:3AD5 dec BX
3358:3AD6 jne short 0x3AA0
3358:3AD8 ret far
3358:3AD9 mov BX,0x004C
3358:3ADC mov CX,0x00A0
3358:3ADF lods AL,byte ptr DS:[SI]
3358:3AE0 mov AH,AL
3358:3AE2 mov word ptr ES:[DI+0x0140],AX
3358:3AE7 stos word ptr ES:[DI],AX
3358:3AE8 loop 0x3ADF
3358:3AEA add SI,0x00A0
3358:3AEE add DI,0x0140
3358:3AF2 dec BX
3358:3AF3 jne short 0x3ADC
3358:3AF5 ret far
3358:3AF6 mov BX,0x0032
3358:3AF9 mov CX,0x006A
3358:3AFC lods AL,byte ptr DS:[SI]
3358:3AFD mov AH,AL
3358:3AFF stos word ptr ES:[DI],AX
3358:3B00 stos byte ptr ES:[DI],AL
3358:3B01 add DI,0x013D
3358:3B05 stos word ptr ES:[DI],AX
3358:3B06 stos byte ptr ES:[DI],AL
3358:3B07 add DI,0x013D
3358:3B0B stos word ptr ES:[DI],AX
3358:3B0C stos byte ptr ES:[DI],AL
3358:3B0D sub DI,0x0280
3358:3B11 loop 0x3AFC
3358:3B13 lods AL,byte ptr DS:[SI]
3358:3B14 mov AH,AL
3358:3B16 stos word ptr ES:[DI],AX
3358:3B17 add DI,0x013E
3358:3B1B stos word ptr ES:[DI],AX
3358:3B1C add DI,0x013E
3358:3B20 stos word ptr ES:[DI],AX
3358:3B21 add SI,0x00D5
3358:3B25 dec BX
3358:3B26 jne short 0x3AF9
3358:3B28 mov CX,0x006A
3358:3B2B lods AL,byte ptr DS:[SI]
3358:3B2C mov AH,AL
3358:3B2E stos word ptr ES:[DI],AX
3358:3B2F stos byte ptr ES:[DI],AL
3358:3B30 add DI,0x013D
3358:3B34 stos word ptr ES:[DI],AX
3358:3B35 stos byte ptr ES:[DI],AL
3358:3B36 sub DI,0x0140
3358:3B3A loop 0x3B2B
3358:3B3C lods AL,byte ptr DS:[SI]
3358:3B3D mov AH,AL
3358:3B3F stos word ptr ES:[DI],AX
3358:3B40 add DI,0x013E
3358:3B44 stos word ptr ES:[DI],AX
3358:3B45 ret far
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
5642:0100 jmp short 0x017B
5642:0109 jmp short 0x0185
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
564B:0100 jmp near 0x04FF
564B:0103 jmp near 0x0626
564B:0106 jmp near 0x0561
564B:010C jmp near 0x05BE
564B:010F jmp near 0x06F6
564B:0112 jmp near 0x05AB
564B:04DC push SS
564B:04DD pop ES
564B:04DE mov SI,BP
564B:04E0 lods AX,word ptr ES:[SI]
564B:04E2 add AX,2
564B:04E5 mov DI,AX
564B:04E7 push CX
564B:04E8 mov CX,9
564B:04EB mov AL,0x2E
564B:04ED repne scas AL,byte ptr ES:[DI]
564B:04EF pop CX
564B:04F0 jne short 0x04FC
564B:04F2 mov AX,word ptr CS:[0x04D9]
564B:04F6 stos word ptr ES:[DI],AX
564B:04F7 mov AL,byte ptr CS:[0x04DB]
564B:04FB stos byte ptr ES:[DI],AL
564B:04FC loop 0x04E0
564B:04FE ret near
564B:04FF or AX,AX
564B:0501 je short 0x051C
564B:0503 mov word ptr CS:[0x0115],AX
564B:0507 add AX,2
564B:050A mov word ptr CS:[0x0117],AX
564B:050E add AX,2
564B:0511 mov word ptr CS:[0x0119],AX
564B:0515 add AX,2
564B:0518 mov word ptr CS:[0x011B],AX
564B:051C mov AL,0xFE
564B:051E mov DX,word ptr CS:[0x0117]
564B:0523 out DX,AL
564B:0524 call near 0x04DC
564B:0527 mov AX,0x2001
564B:052A call near 0x1112
564B:052D mov AX,0x00BD
564B:0530 call near 0x1112
564B:0533 mov AX,0x4008
564B:0536 call near 0x1112
564B:0539 mov AX,0x0105
564B:053C call near 0x1109
564B:053F mov AX,4
564B:0542 call near 0x1109
564B:0545 call near 0x1185
564B:0548 push CS
564B:0549 call near 0x0561
564B:054C mov BX,0x0F00
564B:054F ret far
564B:0561 pushf
564B:0562 cli
564B:0563 call near 0x0EBA
564B:0566 xor AX,AX
564B:0568 mov byte ptr CS:[0x01DE],AL
564B:056C popf
564B:056D ret far
564B:056E push BX
564B:056F push DX
564B:0570 shr AL,1
564B:0572 shr AL,1
564B:0574 shr AL,1
564B:0576 mov DX,AX
564B:0578 mov BX,0xF078
564B:057B cmp AH,BL
564B:057D jbe short 0x0581
564B:0581 xor AL,AL
564B:0583 div BH
564B:0585 mul DL
564B:0587 xchg AH,DH
564B:0589 sub AH,BH
564B:058B neg AH
564B:058D cmp AH,BL
564B:058F jbe short 0x0593
564B:0591 mov AH,BL
564B:0593 xor AL,AL
564B:0595 div BH
564B:0597 mul DL
564B:0599 shr AX,1
564B:059B shr AX,1
564B:059D shr AX,1
564B:059F shr AX,1
564B:05A1 mov AH,DH
564B:05A3 and AX,0x0FF0
564B:05A6 or AL,AH
564B:05A8 pop DX
564B:05A9 pop BX
564B:05AA ret near
564B:05AB call near 0x056E
564B:05AE mov byte ptr CS:[0x04D8],AL
564B:05B2 mov byte ptr CS:[0x04D7],AL
564B:05B6 mov word ptr CS:[0x01E0],0xFFFF
564B:05BD ret far
564B:05BE push AX
564B:05BF mov AX,BX
564B:05C1 call near 0x056E
564B:05C4 mov byte ptr CS:[0x04D7],AL
564B:05C8 pop AX
564B:05C9 mov BX,0xFFFF
564B:05CC cmp AX,0x0060
564B:05CF jb short 0x05EB
564B:05D1 mov BX,0xAAAA
564B:05D4 cmp AX,0x00C0
564B:05D7 jb short 0x05EB
564B:05D9 mov BX,0x8888
564B:05DC cmp AX,0x0180
564B:05DF jb short 0x05EB
564B:05EB mov word ptr CS:[0x01E0],BX
564B:05F0 mov AL,byte ptr CS:[0x01DE]
564B:05F4 or AL,AL
564B:05F6 jns short 0x05FE
564B:05FE ret far
564B:0626 push DS
564B:0627 push CS
564B:0628 pop DS
564B:0629 mov byte ptr DS:[0x01DF],AL
564B:062C mov AX,word ptr ES:[SI]
564B:062F mov DI,0x061C
564B:0632 mov word ptr DS:[DI],SI
564B:0634 mov word ptr DS:[DI+2],ES
564B:0637 mov word ptr DS:[DI+4],AX
564B:063A mov AX,word ptr ES:[SI+0x4000]
564B:063F mov word ptr DS:[DI+6],AX
564B:0642 mov AX,word ptr ES:[SI-32768]
564B:0647 mov word ptr DS:[DI+8],AX
564B:064A add SI,2
564B:064D mov word ptr DS:[0x011E],SI
564B:0651 mov word ptr DS:[0x0120],ES
564B:0655 sub SI,2
564B:0658 add SI,word ptr ES:[SI]
564B:065B mov word ptr DS:[0x0122],SI
564B:065F mov word ptr DS:[0x0124],ES
564B:0663 call near 0x0F53
564B:0666 call near 0x0F78
564B:0669 call near 0x068A
564B:066C mov AL,byte ptr DS:[0x04D8]
564B:066F mov byte ptr DS:[0x04D6],AL
564B:0672 call near 0x0F21
564B:0675 mov byte ptr DS:[0x04D7],AL
564B:0678 xor AX,AX
564B:067A mov word ptr DS:[0x0126],AX
564B:067D mov word ptr DS:[0x012C],AX
564B:0680 call near 0x0756
564B:0683 mov AL,0x80
564B:0685 mov byte ptr DS:[0x01DE],AL
564B:0688 pop DS
564B:0689 ret far
564B:068A push DS
564B:068B push DS
564B:068C pop ES
564B:068D lds SI,word ptr DS:[0x011E]
564B:0691 mov BP,SI
564B:0693 mov DI,0x022A
564B:0696 mov CX,0x0012
564B:0699 lods AX,word ptr DS:[SI]
564B:069A or AX,AX
564B:069C je short 0x06A0
564B:069E add AX,BP
564B:06A0 stos word ptr ES:[DI],AX
564B:06A1 loop 0x0699
564B:06A3 pop DS
564B:06A4 mov DI,0x024E
564B:06A7 mov CL,0x12
564B:06A9 mov AX,0x00FF
564B:06AC rep stos word ptr ES:[DI],AX
564B:06AE mov DI,0x0296
564B:06B1 mov CL,0x12
564B:06B3 rep stos word ptr ES:[DI],AX
564B:06B5 les SI,word ptr DS:[0x011E]
564B:06B9 mov word ptr DS:[0x0128],1
564B:06BF mov word ptr DS:[0x012A],0x0060
564B:06C5 mov CX,0x0012
564B:06C8 mov DI,0x01E2
564B:06CB mov SI,word ptr DS:[DI+0x48]
564B:06CE mov word ptr DS:[DI+0x24],SI
564B:06D1 mov word ptr DS:[DI],0xFFFF
564B:06D5 mov word ptr DS:[DI+0x021C],0
564B:06DB or SI,SI
564B:06DD je short 0x06E8
564B:06DF mov AX,CX
564B:06E1 call near 0x0E7E
564B:06E4 inc word ptr DS:[DI]
564B:06E6 mov CX,AX
564B:06E8 add DI,2
564B:06EB loop 0x06CB
564B:06ED xor AX,AX
564B:06EF mov word ptr DS:[0x013E],AX
564B:06F2 mov word ptr DS:[0x0140],AX
564B:06F5 ret near
564B:06F6 push DS
564B:06F7 mov AX,CS
564B:06F9 mov DS,AX
564B:06FB mov AL,byte ptr DS:[0x01DE]
564B:06FE or AL,AL
564B:0700 jns short 0x0723
564B:0702 dec byte ptr DS:[0x0127]
564B:0706 jns short 0x071A
564B:0708 call near 0x0730
564B:070B jne short 0x0723
564B:070D push DX
564B:070E push SI
564B:070F push DI
564B:0710 push BP
564B:0711 push ES
564B:0712 call near 0x0756
564B:0715 pop ES
564B:0716 pop BP
564B:0717 pop DI
564B:0718 pop SI
564B:0719 pop DX
564B:071A rol word ptr DS:[0x01E0],1
564B:071E jae short 0x0723
564B:0720 call near 0x0ECC
564B:0723 mov AL,byte ptr DS:[0x01DE]
564B:0726 mov BX,word ptr DS:[0x0128]
564B:072A mov CX,word ptr DS:[0x012A]
564B:072E pop DS
564B:072F ret far
564B:0730 push SI
564B:0731 push ES
564B:0732 les SI,word ptr DS:[0x061C]
564B:0736 mov AX,word ptr ES:[SI]
564B:0739 cmp word ptr DS:[0x0620],AX
564B:073D jne short 0x0753
564B:073F mov AX,word ptr ES:[SI+0x4000]
564B:0744 cmp word ptr DS:[0x0622],AX
564B:0748 jne short 0x0753
564B:074A mov AX,word ptr ES:[SI-32768]
564B:074F cmp word ptr DS:[0x0624],AX
564B:0753 pop ES
564B:0754 pop SI
564B:0755 ret near
564B:0756 les BX,word ptr DS:[0x011E]
564B:075A mov AX,word ptr ES:[BX+0x30]
564B:075E add word ptr DS:[0x0126],AX
564B:0762 mov DI,0x01E2
564B:0765 call near 0x07DA
564B:0768 mov CX,0x0012
564B:076B dec word ptr DS:[DI]
564B:076D jne short 0x07AD
564B:076F mov SI,word ptr DS:[DI+0x24]
564B:0772 or SI,SI
564B:0774 je short 0x0798
564B:0776 push CX
564B:0777 push DI
564B:0778 lods AX,word ptr ES:[SI]
564B:077A mov DX,DI
564B:077C sub DX,0x01E2
564B:0780 shr DX,1
564B:0782 mov BX,AX
564B:0784 and BX,0x0070
564B:0787 shr BX,1
564B:0789 shr BX,1
564B:078B shr BX,1
564B:078D call near word ptr DS:[BX+0x012E]
564B:0791 pop DI
564B:0792 pop CX
564B:0793 cmp word ptr DS:[DI],0
564B:0796 je short 0x076F
564B:0798 add DI,2
564B:079B loop 0x076B
564B:079D dec byte ptr DS:[0x012A]
564B:07A1 jne short 0x07AC
564B:07A3 mov byte ptr DS:[0x012A],0x60
564B:07A8 inc word ptr DS:[0x0128]
564B:07AC ret near
564B:07AD cmp byte ptr DS:[DI+0x00B4],0
564B:07B2 je short 0x0798
564B:07B4 mov SI,word ptr DS:[DI+0x24]
564B:07B7 or SI,SI
564B:07B9 je short 0x0798
564B:07BB push CX
564B:07BC push DI
564B:07BD dec byte ptr DS:[DI+0x00B4]
564B:07C1 mov AX,word ptr DS:[DI+0x00D8]
564B:07C5 add AL,AH
564B:07C7 mov byte ptr DS:[DI+0x00D8],AL
564B:07CB mov DX,DI
564B:07CD sub DX,0x01E2
564B:07D1 shr DX,1
564B:07D3 call near 0x0D8B
564B:07D6 pop DI
564B:07D7 pop CX
564B:07D8 jmp short 0x0798
564B:07DA cmp word ptr DS:[0x012C],0
564B:07DF jne short 0x080C
564B:07E1 mov AX,word ptr ES:[BX+0x2A]
564B:07E5 cmp AX,word ptr DS:[0x0128]
564B:07E9 jne short 0x080B
564B:07EB cmp word ptr DS:[0x012A],0x0060
564B:07F0 jne short 0x080B
564B:07F2 push DI
564B:07F3 push ES
564B:07F4 mov SI,DI
564B:07F6 add DI,0x01D4
564B:07FA push DS
564B:07FB pop ES
564B:07FC mov CX,0x0024
564B:07FF rep movs word ptr ES:[DI],word ptr DS:[SI]
564B:0801 pop ES
564B:0802 pop DI
564B:0803 mov AX,word ptr ES:[BX+0x2E]
564B:0807 dec AX
564B:0808 mov word ptr DS:[0x012C],AX
564B:080B ret near
564B:080C mov AX,word ptr ES:[BX+0x2C]
564B:0810 cmp AX,word ptr DS:[0x0128]
564B:0814 jne short 0x080B
564B:0816 dec word ptr DS:[0x012C]
564B:081A push DI
564B:081B push ES
564B:081C lea SI,DI+0x01D4
564B:0820 push DS
564B:0821 pop ES
564B:0822 mov CX,0x0024
564B:0825 rep movs word ptr ES:[DI],word ptr DS:[SI]
564B:0827 pop ES
564B:0828 pop DI
564B:0829 mov AX,word ptr ES:[BX+0x2A]
564B:082D mov word ptr DS:[0x0128],AX
564B:0830 ret near
564B:0831 call near 0x0E7E
564B:0834 mov byte ptr DS:[DI+0x6C],AH
564B:0837 mov AL,0x28
564B:0839 mul AH
564B:083B les SI,word ptr DS:[0x0122]
564B:083F add SI,AX
564B:0841 call near 0x090D
564B:0844 mov AX,word ptr ES:[SI+0x21]
564B:0848 mov word ptr DS:[DI+0x0090],AX
564B:084C mov AH,byte ptr ES:[SI+0x17]
564B:0850 mov AL,byte ptr ES:[SI+0x0A]
564B:0854 mov BH,byte ptr ES:[SI+2]
564B:0858 mov BL,byte ptr ES:[SI+0x0F]
564B:085C and BX,0x0303
564B:0860 ror BX,1
564B:0862 ror BX,1
564B:0864 or AX,BX
564B:0866 mov word ptr DS:[DI+0x0120],AX
564B:086A mov AX,word ptr ES:[SI+0x1E]
564B:086E mov word ptr DS:[DI+0x00FC],AX
564B:0872 mov AX,word ptr ES:[SI+0x26]
564B:0876 mov word ptr DS:[DI+0x018C],AX
564B:087A mov AH,byte ptr ES:[SI+4]
564B:087E mov BL,byte ptr ES:[SI+0x11]
564B:0882 shl BL,1
564B:0884 shl BL,1
564B:0886 shl BL,1
564B:0888 or AH,BL
564B:088A mov AL,byte ptr ES:[SI+0x0E]
564B:088E not AL
564B:0890 ror AL,1
564B:0892 shl AX,1
564B:0894 mov AL,byte ptr ES:[SI+0x20]
564B:0898 mov word ptr DS:[DI+0x0168],AX
564B:089C mov AL,byte ptr ES:[SI+0x1B]
564B:08A0 mov word ptr DS:[DI+0x01B0],AX
564B:08A4 mov AX,word ptr ES:[SI+0x23]
564B:08A8 mov byte ptr DS:[DI+0x00D9],AH
564B:08AC mov AH,AL
564B:08AE xor AL,AL
564B:08B0 mov word ptr DS:[DI+0x00B4],AX
564B:08B4 mov AL,byte ptr ES:[SI]
564B:08B7 mov byte ptr DS:[DI+0x02D0],AL
564B:08BB cmp AL,4
564B:08BD jne short 0x08ED
564B:08ED jmp near 0x0F95
564B:090D mov BP,word ptr DS:[0x013E]
564B:0911 mov CX,word ptr DS:[0x0140]
564B:0915 mov AX,word ptr DS:[DI+0x021C]
564B:0919 not AX
564B:091B or AX,AX
564B:091D js short 0x0923
564B:091F and CX,AX
564B:0921 jmp short 0x0925
564B:0923 and BP,AX
564B:0925 mov AL,byte ptr ES:[SI]
564B:0928 cmp AL,4
564B:092A jne short 0x0967
564B:0967 mov BX,BP
564B:0969 not BX
564B:096B and BX,0x01C0
564B:096F jne short 0x0999
564B:0971 mov BX,CX
564B:0973 not BX
564B:0975 test BX,0x01C0
564B:0979 je short 0x09CD
564B:097B and BX,0x01C0
564B:097F shr BX,1
564B:0981 shr BX,1
564B:0983 shr BX,1
564B:0985 shr BX,1
564B:0987 mov AX,word ptr DS:[BX+0x08ED]
564B:098B mov BX,word ptr DS:[BX+0x08EF]
564B:098F or AX,0x8080
564B:0992 or CX,BX
564B:0994 or BH,0x80
564B:0997 jmp short 0x09AB
564B:0999 shr BX,1
564B:099B shr BX,1
564B:099D shr BX,1
564B:099F shr BX,1
564B:09A1 mov AX,word ptr DS:[BX+0x08ED]
564B:09A5 mov BX,word ptr DS:[BX+0x08EF]
564B:09A9 or BP,BX
564B:09AB mov word ptr DS:[DI+0x021C],BX
564B:09AF mov word ptr DS:[0x013E],BP
564B:09B3 mov word ptr DS:[0x0140],CX
564B:09B7 mov BX,DX
564B:09B9 mov byte ptr DS:[BX+0x017F],AH
564B:09BD mov byte ptr DS:[BX+0x01A3],AL
564B:09C1 add AX,0x0303
564B:09C4 mov byte ptr DS:[BX+0x0191],AH
564B:09C8 mov byte ptr DS:[BX+0x01B5],AL
564B:09CC ret near
564B:09CD mov BH,BL
564B:09CF shr BH,1
564B:09D1 shr BH,1
564B:09D3 shr BH,1
564B:09D5 xor BH,BL
564B:09D7 and BH,7
564B:09DA jne short 0x0A2E
564B:09DC mov AX,BP
564B:09DE mov AH,AL
564B:09E0 shr AH,1
564B:09E2 shr AH,1
564B:09E4 shr AH,1
564B:09E6 xor AL,AH
564B:09E8 and AL,7
564B:09EA jne short 0x0A38
564B:09EC and BX,0x003F
564B:09EF jne short 0x0A46
564B:0A2E shr BH,1
564B:0A30 jb short 0x0A52
564B:0A32 shr BH,1
564B:0A34 jb short 0x0A62
564B:0A36 jmp short 0x0A72
564B:0A46 test BX,0x0024
564B:0A4A jne short 0x0A72
564B:0A4C test BX,0x0012
564B:0A50 jne short 0x0A62
564B:0A62 mov AX,0x8181
564B:0A65 and BX,2
564B:0A68 jne short 0x0A7F
564B:0A6A mov AX,0x8489
564B:0A6D mov BL,0x10
564B:0A6F jmp near 0x0992
564B:0A72 mov AX,0x8282
564B:0A75 and BX,4
564B:0A78 jne short 0x0A7F
564B:0A7A mov AX,0x858A
564B:0A7D mov BL,0x20
564B:0A7F jmp near 0x0992
564B:0A82 lods AL,byte ptr ES:[SI]
564B:0A84 call near 0x0E7E
564B:0A87 push AX
564B:0A88 call near 0x0C47
564B:0A8B cmp byte ptr DS:[DI+0x6D],0
564B:0A8F je short 0x0A96
564B:0A91 xor AX,AX
564B:0A93 call near 0x10E0
564B:0A96 pop AX
564B:0A97 mov AL,AH
564B:0A99 add AL,byte ptr DS:[DI+0x0091]
564B:0A9D xor AH,AH
564B:0A9F mov byte ptr DS:[DI+0x6D],AL
564B:0AA2 sub AX,0x0048
564B:0AA5 mov CL,byte ptr DS:[DI+0x00B5]
564B:0AA9 mov byte ptr DS:[DI+0x00B4],CL
564B:0AAD mov byte ptr DS:[DI+0x00D8],0x40
564B:0AB2 jmp near 0x10A9
564B:0AB5 inc SI
564B:0AB6 call near 0x0E7E
564B:0AB9 add AH,byte ptr DS:[DI+0x0091]
564B:0ABD cmp byte ptr DS:[DI+0x6D],AH
564B:0AC0 jne short 0x0ACC
564B:0AC2 mov byte ptr DS:[DI+0x6D],0
564B:0AC6 call near 0x0ACD
564B:0AC9 jmp near 0x10D8
564B:0ACC ret near
564B:0ACD cmp word ptr DS:[DI],0x0030
564B:0AD0 jb short 0x0ACC
564B:0AD2 mov AL,byte ptr ES:[SI]
564B:0AD5 cmp AL,0xFF
564B:0AD7 je short 0x0ADF
564B:0AD9 and AL,0xF0
564B:0ADB cmp AL,0xC0
564B:0ADD jne short 0x0ACC
564B:0ADF xor AX,AX
564B:0AE1 xchg AX,word ptr DS:[DI+0x021C]
564B:0AE5 not AX
564B:0AE7 or AX,AX
564B:0AE9 js short 0x0AF0
564B:0AEB and word ptr DS:[0x0140],AX
564B:0AEF ret near
564B:0AF0 and word ptr DS:[0x013E],AX
564B:0AF4 ret near
564B:0AF5 mov word ptr DS:[DI],0xFFFF
564B:0AF9 sub byte ptr DS:[DI+0x24],2
564B:0AFD or DX,DX
564B:0AFF jne short 0x0ADF
564B:0B01 dec byte ptr DS:[0x01DF]
564B:0B05 je short 0x0B1D
564B:0B07 jns short 0x0B0D
564B:0B09 inc byte ptr DS:[0x01DF]
564B:0B0D call near 0x06B9
564B:0B10 les BX,word ptr DS:[0x011E]
564B:0B14 mov DI,0x01E2
564B:0B17 call near 0x07DA
564B:0B1A dec word ptr DS:[DI]
564B:0B1C ret near
564B:0B1D mov AX,0xFFFF
564B:0B20 push ES
564B:0B21 push DS
564B:0B22 pop ES
564B:0B23 mov CX,0x0012
564B:0B26 rep stos word ptr ES:[DI],AX
564B:0B28 pop ES
564B:0B29 push CS
564B:0B2A call near 0x0561
564B:0B2D ret near
564B:0B2E call near 0x0E7E
564B:0B31 mov AL,0x80
564B:0B33 sub AL,AH
564B:0B35 xchg AL,AH
564B:0B37 mov BX,word ptr DS:[DI+0x0144]
564B:0B3B mov CX,word ptr DS:[DI+0x018C]
564B:0B3F or CL,CL
564B:0B41 je short 0x0B72
564B:0B43 push AX
564B:0B44 jns short 0x0B4A
564B:0B4A sub CL,4
564B:0B4D neg CL
564B:0B4F shr AL,CL
564B:0B51 mov AH,BL
564B:0B53 and AH,0x3F
564B:0B56 sub AH,AL
564B:0B58 jae short 0x0B5C
564B:0B5A xor AH,AH
564B:0B5C and BL,0xC0
564B:0B5F or AH,BL
564B:0B61 mov SI,BX
564B:0B63 mov BX,0x01A3
564B:0B66 add BX,DX
564B:0B68 mov BL,byte ptr DS:[BX]
564B:0B6A mov AL,0x40
564B:0B6C call near 0x1101
564B:0B6F mov BX,SI
564B:0B71 pop AX
564B:0B72 or CH,CH
564B:0B74 je short 0x0BA0
564B:0BA0 cmp byte ptr DS:[DI+0x02D0],4
564B:0BA5 jne short 0x0C16
564B:0C16 mov CX,word ptr DS:[DI+0x01B0]
564B:0C1A or CL,CL
564B:0C1C jne short 0x0C1F
564B:0C1E ret near
564B:0C1F jns short 0x0C25
564B:0C25 sub CL,6
564B:0C28 neg CL
564B:0C2A shr AL,CL
564B:0C2C mov AH,CH
564B:0C2E and AX,0x0FFE
564B:0C31 add AL,AH
564B:0C33 cmp AL,0x0F
564B:0C35 jbe short 0x0C3B
564B:0C3B mov AH,AL
564B:0C3D and CH,0x30
564B:0C40 or AH,CH
564B:0C42 mov AL,0xC0
564B:0C44 jmp near 0x10ED
564B:0C47 mov AH,AL
564B:0C49 mov AL,0x80
564B:0C4B sub AL,AH
564B:0C4D mov BX,word ptr DS:[DI+0x0120]
564B:0C51 mov CX,word ptr DS:[DI+0x00FC]
564B:0C55 or CL,CL
564B:0C57 je short 0x0C8D
564B:0C59 push AX
564B:0C5A jns short 0x0C60
564B:0C60 sub CL,4
564B:0C63 neg CL
564B:0C65 shr AL,CL
564B:0C67 mov AH,BL
564B:0C69 and AH,0x3F
564B:0C6C add AH,AL
564B:0C6E cmp AH,0x3F
564B:0C71 jbe short 0x0C75
564B:0C73 mov AH,0x3F
564B:0C75 and BL,0xC0
564B:0C78 or BL,AH
564B:0C7A mov AH,BL
564B:0C7C mov SI,BX
564B:0C7E mov BX,0x01A3
564B:0C81 add BX,DX
564B:0C83 mov BL,byte ptr DS:[BX]
564B:0C85 mov AL,0x40
564B:0C87 call near 0x1101
564B:0C8A mov BX,SI
564B:0C8C pop AX
564B:0C8D or CH,CH
564B:0C8F je short 0x0CC2
564B:0C91 push AX
564B:0C92 jns short 0x0C98
564B:0C98 mov CL,4
564B:0C9A sub CL,CH
564B:0C9C shr AL,CL
564B:0C9E mov AH,BH
564B:0CA0 and AH,0x3F
564B:0CA3 add AH,AL
564B:0CA5 cmp AH,0x3F
564B:0CA8 jbe short 0x0CAC
564B:0CAC and BH,0xC0
564B:0CAF or BH,AH
564B:0CB1 mov AH,BH
564B:0CB3 push BX
564B:0CB4 mov BX,0x01B5
564B:0CB7 add BX,DX
564B:0CB9 mov BL,byte ptr DS:[BX]
564B:0CBB mov AL,0x40
564B:0CBD call near 0x1101
564B:0CC0 pop BX
564B:0CC1 pop AX
564B:0CC2 mov word ptr DS:[DI+0x0144],BX
564B:0CC6 cmp byte ptr DS:[DI+0x02D0],4
564B:0CCB jne short 0x0D4C
564B:0D4C mov CX,word ptr DS:[DI+0x0168]
564B:0D50 or CL,CL
564B:0D52 jne short 0x0D59
564B:0D54 mov byte ptr DS:[DI+0x01B1],CH
564B:0D58 ret near
564B:0D59 jns short 0x0D5F
564B:0D5B neg CL
564B:0D5D mov AL,AH
564B:0D5F sub CL,6
564B:0D62 neg CL
564B:0D64 shr AL,CL
564B:0D66 mov AH,CH
564B:0D68 and AX,0x0FFE
564B:0D6B add AL,AH
564B:0D6D cmp AL,0x0F
564B:0D6F jbe short 0x0D75
564B:0D75 mov AH,AL
564B:0D77 and CH,0x30
564B:0D7A or AH,CH
564B:0D7C mov byte ptr DS:[DI+0x01B1],AH
564B:0D80 mov AL,0xC0
564B:0D82 jmp near 0x10ED
564B:0D85 ret near
564B:0D86 mov AL,AH
564B:0D88 call near 0x0E7E
564B:0D8B mov CL,byte ptr DS:[DI+0x6D]
564B:0D8E xor CH,CH
564B:0D90 jcxz short 0x0D85
564B:0D92 mov AH,CH
564B:0D94 xchg CX,AX
564B:0D95 sub AL,0x18
564B:0D97 mov BH,0x0C
564B:0D99 div BH
564B:0D9B xchg CX,AX
564B:0D9C cmp byte ptr DS:[DI+0x0090],0
564B:0DA1 jne short 0x0E02
564B:0DA3 sub AX,0x0040
564B:0DA6 jae short 0x0DDF
564B:0DA8 neg AX
564B:0DAA ror AX,1
564B:0DAC ror AX,1
564B:0DAE ror AX,1
564B:0DB0 ror AX,1
564B:0DB2 ror AX,1
564B:0DB4 sub CH,AL
564B:0DB6 jae short 0x0DC1
564B:0DC1 mov AL,CH
564B:0DC3 mov BX,0x01C7
564B:0DC6 xlat byte ptr DS:[BX+AL]
564B:0DC7 mul AH
564B:0DC9 mov AL,AH
564B:0DCB xchg AL,CH
564B:0DCD xor AH,AH
564B:0DCF add AX,AX
564B:0DD1 mov SI,AX
564B:0DD3 mov AX,word ptr DS:[SI+0x0142]
564B:0DD7 sub AL,CH
564B:0DD9 sbb AH,0
564B:0DDC jmp near 0x0E6A
564B:0DDF inc AX
564B:0DE0 ror AX,1
564B:0DE2 ror AX,1
564B:0DE4 ror AX,1
564B:0DE6 ror AX,1
564B:0DE8 ror AX,1
564B:0DEA add CH,AL
564B:0DEC cmp CH,0x0C
564B:0DEF jb short 0x0DF6
564B:0DF6 mov AL,CH
564B:0DF8 mov BX,0x01C8
564B:0DFB xlat byte ptr DS:[BX+AL]
564B:0DFC mul AH
564B:0DFE mov AL,AH
564B:0E00 jmp short 0x0E59
564B:0E02 sub AX,0x0040
564B:0E05 jae short 0x0E3B
564B:0E07 neg AX
564B:0E09 mov BH,5
564B:0E0B div BH
564B:0E0D sub CH,AL
564B:0E0F jae short 0x0E1A
564B:0E11 add CH,0x0C
564B:0E14 dec CL
564B:0E16 jns short 0x0E1A
564B:0E1A mov AL,AH
564B:0E1C mov BX,0x01D4
564B:0E1F cmp CH,6
564B:0E22 jb short 0x0E27
564B:0E24 add BX,5
564B:0E27 xlat byte ptr DS:[BX+AL]
564B:0E28 xchg AL,CH
564B:0E2A xor AH,AH
564B:0E2C add AX,AX
564B:0E2E mov SI,AX
564B:0E30 mov AX,word ptr DS:[SI+0x0142]
564B:0E34 sub AL,CH
564B:0E36 sbb AH,0
564B:0E39 jmp short 0x0E6A
564B:0E3B mov BH,5
564B:0E3D div BH
564B:0E3F add CH,AL
564B:0E41 cmp CH,0x0C
564B:0E44 jb short 0x0E4B
564B:0E46 sub CH,0x0C
564B:0E49 inc CL
564B:0E4B mov AL,AH
564B:0E4D mov BX,0x01D4
564B:0E50 cmp CH,6
564B:0E53 jb short 0x0E58
564B:0E55 add BX,5
564B:0E58 xlat byte ptr DS:[BX+AL]
564B:0E59 xchg AL,CH
564B:0E5B xor AH,AH
564B:0E5D add AX,AX
564B:0E5F mov SI,AX
564B:0E61 mov AX,word ptr DS:[SI+0x0142]
564B:0E65 add AL,CH
564B:0E67 adc AH,0
564B:0E6A shl CL,1
564B:0E6C shl CL,1
564B:0E6E or AH,CL
564B:0E70 mov SI,DX
564B:0E72 add SI,SI
564B:0E74 mov word ptr DS:[SI+0x015A],AX
564B:0E78 or AH,0x20
564B:0E7B jmp near 0x10E0
564B:0E7E push AX
564B:0E7F xor AX,AX
564B:0E81 lods AL,byte ptr ES:[SI]
564B:0E83 or AL,AL
564B:0E85 jns short 0x0EB3
564B:0E87 xor CX,CX
564B:0E89 mov CH,CL
564B:0E8B mov CL,AH
564B:0E8D mov AH,AL
564B:0E8F lods AL,byte ptr ES:[SI]
564B:0E91 or AL,AL
564B:0E93 js short 0x0E89
564B:0E95 and AX,0x7F7F
564B:0E98 and CX,0x7F7F
564B:0E9C shl CL,1
564B:0E9E shr CX,1
564B:0EA0 shl AL,1
564B:0EA2 shl AX,1
564B:0EA4 shr CX,1
564B:0EA6 rcr AX,1
564B:0EA8 shr CX,1
564B:0EAA rcr AX,1
564B:0EAC or CX,CX
564B:0EAE je short 0x0EB3
564B:0EB3 mov word ptr DS:[DI],AX
564B:0EB5 mov word ptr DS:[DI+0x24],SI
564B:0EB8 pop AX
564B:0EB9 ret near
564B:0EBA push DS
564B:0EBB push CS
564B:0EBC pop DS
564B:0EBD mov CX,0x0012
564B:0EC0 push CX
564B:0EC1 mov DX,CX
564B:0EC3 dec DX
564B:0EC4 call near 0x10D8
564B:0EC7 pop CX
564B:0EC8 loop 0x0EC0
564B:0ECA pop DS
564B:0ECB ret near
564B:0ECC mov AL,byte ptr DS:[0x04D6]
564B:0ECF cmp AL,byte ptr DS:[0x04D7]
564B:0ED3 jne short 0x0EE1
564B:0ED5 mov word ptr DS:[0x01E0],1
564B:0EDB and byte ptr DS:[0x01DE],0xBF
564B:0EE0 ret near
564B:0F21 mov AL,byte ptr CS:[0x04D6]
564B:0F25 push AX
564B:0F26 pushf
564B:0F27 cli
564B:0F28 call near 0x1176
564B:0F2B push AX
564B:0F2C and AL,0xF0
564B:0F2E mov AH,AL
564B:0F30 shr AH,1
564B:0F32 shr AH,1
564B:0F34 shr AH,1
564B:0F36 or AH,0x81
564B:0F39 mov AL,9
564B:0F3B call near 0x1158
564B:0F3E pop AX
564B:0F3F and AL,0x0F
564B:0F41 mov AH,AL
564B:0F43 shl AH,1
564B:0F45 or AH,0x81
564B:0F48 mov AL,0x0A
564B:0F4A call near 0x1158
564B:0F4D call near 0x116E
564B:0F50 popf
564B:0F51 pop AX
564B:0F52 ret near
564B:0F53 mov CX,0x0016
564B:0F56 mov AH,0xFF
564B:0F58 mov AL,CL
564B:0F5A dec AX
564B:0F5B cmp AL,6
564B:0F5D je short 0x0F75
564B:0F5F cmp AL,7
564B:0F61 je short 0x0F75
564B:0F63 cmp AL,0x0E
564B:0F65 je short 0x0F75
564B:0F67 cmp AL,0x0F
564B:0F69 je short 0x0F75
564B:0F6B add AL,0x80
564B:0F6D push AX
564B:0F6E call near 0x1112
564B:0F71 pop AX
564B:0F72 call near 0x1109
564B:0F75 loop 0x0F58
564B:0F77 ret near
564B:0F78 pushf
564B:0F79 cli
564B:0F7A call near 0x1176
564B:0F7D les SI,word ptr DS:[0x011E]
564B:0F81 add SI,0x0032
564B:0F84 lods AL,byte ptr ES:[SI]
564B:0F86 mov AH,AL
564B:0F88 mov AL,8
564B:0F8A call near 0x1158
564B:0F8D call near 0x11C4
564B:0F90 call near 0x116E
564B:0F93 popf
564B:0F94 ret near
564B:0F95 mov BX,DX
564B:0F97 mov AL,byte ptr DS:[BX+0x01A3]
564B:0F9B mov AH,byte ptr DS:[BX+0x01B5]
564B:0F9F mov BX,AX
564B:0FA1 call near 0x1002
564B:0FA4 xchg BH,BL
564B:0FA6 mov AH,byte ptr ES:[SI+0x1D]
564B:0FAA add SI,0x000D
564B:0FAD call near 0x102C
564B:0FB0 test BH,0x10
564B:0FB3 jne short 0x0FF4
564B:0FB5 mov CL,BH
564B:0FB7 and CL,3
564B:0FBA or BH,BH
564B:0FBC jns short 0x0FC1
564B:0FBE add CL,3
564B:0FC1 mov AH,1
564B:0FC3 shl AH,CL
564B:0FC5 mov AL,byte ptr DS:[0x017E]
564B:0FC8 cmp byte ptr ES:[SI-13],4
564B:0FCD jne short 0x0FF5
564B:0FF4 ret near
564B:0FF5 not AH
564B:0FF7 and AH,AL
564B:0FF9 mov byte ptr DS:[0x017E],AH
564B:0FFD mov AL,4
564B:0FFF jmp near 0x1109
564B:1002 mov AH,byte ptr ES:[SI+0x0E]
564B:1006 shr AX,1
564B:1008 mov AH,byte ptr ES:[SI+4]
564B:100C not AL
564B:100E shl AX,1
564B:1010 mov AL,byte ptr ES:[SI+0x11]
564B:1014 shl AL,1
564B:1016 shl AL,1
564B:1018 shl AL,1
564B:101A shl AL,1
564B:101C and AX,0x0F30
564B:101F or AH,AL
564B:1021 mov AL,0xC0
564B:1023 push BX
564B:1024 call near 0x10ED
564B:1027 pop BX
564B:1028 mov AH,byte ptr ES:[SI+0x1C]
564B:102C and AH,7
564B:102F mov AL,0xE0
564B:1031 call near 0x1101
564B:1034 mov AH,byte ptr ES:[SI+0x0A]
564B:1038 mov AL,byte ptr ES:[SI+2]
564B:103C shl AH,1
564B:103E shl AH,1
564B:1040 ror AX,1
564B:1042 ror AX,1
564B:1044 mov AL,0x40
564B:1046 call near 0x1101
564B:1049 mov AH,byte ptr ES:[SI+5]
564B:104D mov AL,byte ptr ES:[SI+8]
564B:1051 shl AL,1
564B:1053 shl AL,1
564B:1055 shl AL,1
564B:1057 shl AL,1
564B:1059 shl AX,1
564B:105B shl AX,1
564B:105D shl AX,1
564B:105F shl AX,1
564B:1061 mov AL,0x60
564B:1063 call near 0x1101
564B:1066 mov AH,byte ptr ES:[SI+6]
564B:106A mov AL,byte ptr ES:[SI+9]
564B:106E shl AL,1
564B:1070 shl AL,1
564B:1072 shl AL,1
564B:1074 shl AL,1
564B:1076 shl AX,1
564B:1078 shl AX,1
564B:107A shl AX,1
564B:107C shl AX,1
564B:107E mov AL,0x80
564B:1080 call near 0x1101
564B:1083 mov AL,byte ptr ES:[SI+0x0D]
564B:1087 ror AX,1
564B:1089 mov AL,byte ptr ES:[SI+7]
564B:108D ror AX,1
564B:108F mov AL,byte ptr ES:[SI+0x0C]
564B:1093 ror AX,1
564B:1095 mov AL,byte ptr ES:[SI+0x0B]
564B:1099 ror AX,1
564B:109B mov AL,byte ptr ES:[SI+3]
564B:109F and AX,0xF00F
564B:10A2 or AH,AL
564B:10A4 mov AL,0x20
564B:10A6 jmp short 0x1101
564B:10A9 add AX,0x0030
564B:10AC cmp AX,0x0060
564B:10AF jb short 0x10B3
564B:10B1 xor AX,AX
564B:10B3 mov BL,0x0C
564B:10B5 div BL
564B:10B7 mov CL,AL
564B:10B9 xchg AH,AL
564B:10BB xor AH,AH
564B:10BD add AX,AX
564B:10BF mov SI,AX
564B:10C1 mov AX,word ptr DS:[SI+0x0142]
564B:10C5 shl CL,1
564B:10C7 shl CL,1
564B:10C9 or AH,CL
564B:10CB mov SI,DX
564B:10CD add SI,SI
564B:10CF mov word ptr DS:[SI+0x015A],AX
564B:10D3 or AH,0x20
564B:10D6 jmp short 0x10E0
564B:10D8 mov SI,DX
564B:10DA add SI,SI
564B:10DC mov AX,word ptr DS:[SI+0x015A]
564B:10E0 mov CX,AX
564B:10E2 mov AL,0xA0
564B:10E4 mov AH,CL
564B:10E6 call near 0x10ED
564B:10E9 mov AL,0xB0
564B:10EB mov AH,CH
564B:10ED mov BL,DL
564B:10EF xor BH,BH
564B:10F1 add BX,0x017F
564B:10F5 mov BL,byte ptr DS:[BX]
564B:10F7 add AL,BL
564B:10F9 or BL,BL
564B:10FB jns short 0x1112
564B:10FD xor AL,0x80
564B:10FF jmp short 0x1109
564B:1101 add AL,BL
564B:1103 or BL,BL
564B:1105 jns short 0x1112
564B:1107 xor AL,0x80
564B:1109 push DX
564B:110A mov DX,word ptr CS:[0x0117]
564B:110F out DX,AL
564B:1110 jmp short 0x1119
564B:1112 push DX
564B:1113 mov DX,word ptr CS:[0x0115]
564B:1118 out DX,AL
564B:1119 in DX,AL
564B:111A in DX,AL
564B:111B in DX,AL
564B:111C in DX,AL
564B:111D in DX,AL
564B:111E in DX,AL
564B:111F in DX,AL
564B:1120 inc DX
564B:1121 mov AL,AH
564B:1123 out DX,AL
564B:1124 in DX,AL
564B:1125 in DX,AL
564B:1126 in DX,AL
564B:1127 in DX,AL
564B:1128 in DX,AL
564B:1129 in DX,AL
564B:112A in DX,AL
564B:112B in DX,AL
564B:112C in DX,AL
564B:112D in DX,AL
564B:112E in DX,AL
564B:112F in DX,AL
564B:1130 in DX,AL
564B:1131 in DX,AL
564B:1132 in DX,AL
564B:1133 in DX,AL
564B:1134 in DX,AL
564B:1135 in DX,AL
564B:1136 in DX,AL
564B:1137 in DX,AL
564B:1138 in DX,AL
564B:1139 in DX,AL
564B:113A in DX,AL
564B:113B in DX,AL
564B:113C in DX,AL
564B:113D in DX,AL
564B:113E in DX,AL
564B:113F in DX,AL
564B:1140 in DX,AL
564B:1141 in DX,AL
564B:1142 in DX,AL
564B:1143 in DX,AL
564B:1144 in DX,AL
564B:1145 in DX,AL
564B:1146 in DX,AL
564B:1147 pop DX
564B:1148 ret near
564B:1149 push AX
564B:114A push DX
564B:114B mov DX,word ptr CS:[0x0117]
564B:1150 in DX,AL
564B:1151 and AL,0xC0
564B:1153 jne short 0x1150
564B:1155 pop DX
564B:1156 pop AX
564B:1157 ret near
564B:1158 push AX
564B:1159 push DX
564B:115A mov DX,word ptr CS:[0x0117]
564B:115F push AX
564B:1160 in DX,AL
564B:1161 and AL,0xC0
564B:1163 jne short 0x1160
564B:1165 pop AX
564B:1166 out DX,AL
564B:1167 inc DX
564B:1168 mov AL,AH
564B:116A out DX,AL
564B:116B pop DX
564B:116C pop AX
564B:116D ret near
564B:116E call near 0x1149
564B:1171 push AX
564B:1172 mov AL,0xFE
564B:1174 jmp short 0x1179
564B:1176 push AX
564B:1177 mov AL,0xFF
564B:1179 push CX
564B:117A push DX
564B:117B mov DX,word ptr CS:[0x0117]
564B:1180 out DX,AL
564B:1181 pop DX
564B:1182 pop CX
564B:1183 pop AX
564B:1184 ret near
564B:1185 pushf
564B:1186 cli
564B:1187 call near 0x1176
564B:118A mov AX,0xFB06
564B:118D call near 0x1158
564B:1190 mov AX,0xF707
564B:1193 call near 0x1158
564B:1196 mov AX,0xF704
564B:1199 call near 0x1158
564B:119C inc AX
564B:119D call near 0x1158
564B:11A0 mov AX,0xFF09
564B:11A3 call near 0x1158
564B:11A6 inc AX
564B:11A7 call near 0x1158
564B:11AA call near 0x1149
564B:11AD mov AL,0
564B:11AF mov DX,word ptr CS:[0x0117]
564B:11B4 out DX,AL
564B:11B5 inc DX
564B:11B6 in DX,AL
564B:11B7 not AL
564B:11B9 and AL,0x20
564B:11BB mov byte ptr CS:[0x011D],AL
564B:11BF call near 0x116E
564B:11C2 popf
564B:11C3 ret near
564B:11C4 cmp byte ptr CS:[0x011D],0
564B:11CA je short 0x11F3
564B:11CC pushf
564B:11CD cli
564B:11CE xor DX,DX
564B:11D0 mov AL,DL
564B:11D2 xor AH,AH
564B:11D4 call near 0x11F4
564B:11D7 or AH,4
564B:11DA mov AL,0x18
564B:11DC call near 0x1158
564B:11DF lods AL,byte ptr ES:[SI]
564B:11E1 call near 0x11F4
564B:11E4 and AH,0xFB
564B:11E7 mov AL,0x18
564B:11E9 call near 0x1158
564B:11EC inc DX
564B:11ED cmp DL,0x1F
564B:11F0 jb short 0x11D0
564B:11F2 popf
564B:11F3 ret near
564B:11F4 mov BL,AL
564B:11F6 mov AL,0x18
564B:11F8 mov CX,8
564B:11FB and AH,0xFD
564B:11FE call near 0x1158
564B:1201 xor BH,BH
564B:1203 shl BX,1
564B:1205 and AH,0xFE
564B:1208 or AH,BH
564B:120A call near 0x1158
564B:120D or AH,2
564B:1210 call near 0x1158
564B:1213 loop 0x11FB
564B:1215 ret near
