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
    call RandomRange
    mov score, eax
    mov edx, score
    call writeDec
    mov  edx,OFFSET titleGrade
    call WriteString
    call GradeCalc
    mov edx,0
    mov grade,al
    mov edx, OFFSET grade
    call WriteChar
    exit
main ENDP

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

END main