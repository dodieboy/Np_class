
INCLUDE Irvine32.inc

.data
val1 SDWORD ?
in1 BYTE "Enter an value: ",0
out1 BYTE "The output is:       ",0
end1 BYTE "Press any key...  ",0

output1  BYTE 0
value1  SDWORD ?
row  BYTE 0
col  BYTE 0

grA BYTE "A",0
grB BYTE "B",0
grC BYTE "C",0
grD BYTE "D",0
grF BYTE "F",0
out_of_range BYTE "The integer is not <= 100 and >= 0",0

.code
main PROC
	call Input
	mov  value1,eax
    call GradeCalc
    mov  output1,al
	call Display
	call WaitForKey
	
	exit
main ENDP

; input an integer
Input PROC
	add  row,1
	call Locate
	mov  edx,OFFSET in1
	call WriteString
	call ReadInt
	ret
Input ENDP

; locate the cursor
Locate PROC
	mov  dh,row
	mov  dl,col
	call Gotoxy
	ret
Locate ENDP

GradeCalc PROC
    cmp eax,100
    jl Check1
    jnle Error1
    Check1:
        cmp eax,80
        jl Check2
        mov al,grA
        ret
    Check2:
        cmp eax,70
        jl Check3
        mov al,grB
        ret
    Check3:
        cmp eax,60
        jl Check4
        mov al,grC
        ret
    Check4:
        cmp eax,50
        jl Check5
        mov al,grD
        ret
    Check5:
        cmp eax,0
        jl Error1
        mov al,grF
        ret
    Error1:
        mov edx,OFFSET out_of_range
        call WriteString
        call Crlf
        ret
GradeCalc ENDP

Display PROC
	add  row,2
	call Locate
	mov  edx,OFFSET out1
	call WriteString
    mov edx,0
	mov  edx,OFFSET output1
	call writeChar
	ret
Display ENDP

; Display "Press any key..." and wait for input
WaitForKey PROC
	add  row,2
	call Locate
	mov  edx,OFFSET end1
	call WriteString
	call Readchar
	ret
WaitForKey ENDP

END main