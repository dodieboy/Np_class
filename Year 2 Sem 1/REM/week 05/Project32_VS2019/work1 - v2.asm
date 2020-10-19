INCLUDE Irvine32.inc

.data
score SDWORD ?,0
titleScore BYTE "Score:",0
titleGrade BYTE " Grade:",0
grade BYTE ?,0
grA BYTE "A",0
grB BYTE "B",0
grC BYTE "C",0
grD BYTE "D",0
grF BYTE "F",0
out_of_range BYTE "The integer is not <= 100 and >= 0",0

.code
main PROC
    call Randomize
    mov eax,101  ;set random range from 0 to 100
    mov  edx,OFFSET titleScore
    call WriteString
    ;call RandomRange
    mov eax, 111
    mov score, eax
    mov edx, score
    call writeDec
    mov  edx,OFFSET titleGrade
    call WriteString
    call GradeCalc
    mov edx,0
    mov grade,al
    mov edx, OFFSET grade
    call WriteString
    exit
main ENDP

GradeCalc PROC
   .IF (eax <= 100 && eax >= 0)
       .IF (eax <= 100) && (eax > 89)
           mov al,grA
       .ELSEIF (eax < 90) && (eax > 79)
           mov al,grB
       .ELSEIF (eax < 80) && (eax > 69)
           mov al,grC
       .ELSE
           mov al,grF
       .ENDIF
   .ELSE
       mov edx,OFFSET out_of_range
       call WriteString
       call Crlf
       ret
   .ENDIF
   ret
GradeCalc ENDP

END main