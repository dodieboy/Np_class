inputs = input('Plaintext: ').replace(' ','').upper()
key = input('Key: ').replace(' ','')

testKey = list(key)
process = []

#vaildating key
def invalidKey():
    print('Invalid key')
    exit()

if key.isdigit() == False:
    invalidKey()

for i in range(1, len(key)+1):
    if testKey.count(str(i)) != 1:
        invalidKey()

#rearrange
for i in range(1, len(key)+1):
    temp = ''
    for j in range(round(len(inputs)/len(key)+0.5)):
        if (i + j*len(key)-1 < len(inputs)):
            temp += inputs[i + j*len(key)-1]
        else:
            break
    process.append(temp)

#shuffle
print('Output:', end=' ')
for i in range(0, len(key)):
    print(process[int(testKey[i])-1], end=' ')