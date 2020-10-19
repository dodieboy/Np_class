
INCLUDE Irvine32.inc

COUNT = 3
.data
val1 SDWORD ?
val2 SDWORD ?
str1 BYTE "Enter an length: ",0
str4 BYTE "Enter an width: ",0
str2 BYTE "The sum is:       ",0
str3 BYTE "Press any key...  ",0

area  SDWORD 0
l  SDWORD ?
w  SDWORD ?
row  BYTE ?
col  BYTE ?

.code
main PROC
	mov  ecx,count

; Input multiple integers, using a loop
L1:
	call ClrScr
	mov  area,0		; reset sum each time loop is repeated
	mov  row,8
	mov  col,20
	call Locate

; input the two integers
	call Input
	mov  l,eax
	add  row,2
	call Input2
	mov  w,eax
	mul  l
	mov area,eax

	call DisplaySum
	call WaitForKey
	
	loop L1
	exit
main ENDP

; input an integer
Input PROC
	call Locate
	mov  edx,OFFSET str1
	call WriteString
	call ReadInt
	ret
Input ENDP

Input2 PROC
	call Locate
	mov  edx,OFFSET str4
	call WriteString
	call ReadInt
	ret
Input2 ENDP

; locate the cursor
Locate PROC
	mov  dh,row
	mov  dl,col
	call Gotoxy
	ret
Locate ENDP

DisplaySum PROC
	add  row,2
	call Locate
	mov  edx,OFFSET str2
	call WriteString
	mov  eax,area
	call WriteInt
	ret
DisplaySum ENDP

; Display "Press any key..." and wait for input
WaitForKey PROC
	add  row,2
	call Locate
	mov  edx,OFFSET str3
	call WriteString
	call Readchar
	ret
WaitForKey ENDP

END main