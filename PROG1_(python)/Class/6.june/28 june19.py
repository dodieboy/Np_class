'''
for i in range(1,6):
    for j in range(i,5):
        print('.', end=' ')
    for k in range(0, i):
        print(i, end=' ')
    print()
'''

'''
for i in range(1,6):
    for j in range(1, 6-i):
        print('.', end=' ')
    for k in range(i):
        print(i, end=' ')
    print()
'''

'''
for i in range(1,6):
    for j in range(5):
        if 5 - i > j:
            print('.', end=' ')
        else:
            print(i, end=' ')
    print()
'''

