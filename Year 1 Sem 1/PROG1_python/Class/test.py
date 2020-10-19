inputs = input('Plaintext: ')
key = input('Key: ')

inputs = inputs.replace(' ','').upper()
testKey = list(key)
process = []

#vaildating key
for i in range(1, len(key)+1):
    if str(i) not in testKey:
        print('Invalid key')
        exit()

#rearrange
for i in range(1, len(key)+1):
    temp = ''
    for j in range(round(len(inputs)/len(key)+0.5)):
        if (i + j*len(key)-1 < len(inputs)):
            temp += inputs[i + j*len(key)-1]
        else:
            pass
    process.append(temp)
#shuffle
print('Output:', end=' ')
for i in range(0, len(key)):
    print(process[int(testKey[i])-1], end=' ')