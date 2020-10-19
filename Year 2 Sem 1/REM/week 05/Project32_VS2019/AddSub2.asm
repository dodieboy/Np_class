TITLE Add and Subtract, Version 2         (AddSub2.asm)

; This program adds and subtracts 32-bit integers
; and stores the sum in a variable.

INCLUDE Irvine32.inc

.data
    area  SDWORD 0
    l  SDWORD 30
    w  SDWORD 20

.code
main PROC
    mov  eax,l
    mul  w
    mov area,eax
    INVOKE ExitProcess,0 ; program ends
main ENDP


END main