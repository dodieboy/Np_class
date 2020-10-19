INCLUDE Irvine32.inc

.data
    N sdword 10
    A sdword 10
    B sdword 10

.code
main PROC
    mov eax, n
    mov ebx, a
    mov ecx, b

    whileloop:
        cmp eax, 0
        jle exits
        cmp eax, 3
        je L3
        jmp L1
        L1:
            cmp eax, ebx
            jl L2
            cmp eax, ecx
            jg L2
            jmp L3
        L2:
            sub eax, 2
            jmp whileloop
        L3:
            sub eax, 1
            jmp whileloop
    exits:
    exit
main ENDP
END main