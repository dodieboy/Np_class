import math
var1 = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z']
inputs = input('Plaintext: ').replace(' ','').upper()
key = input('Key: ').replace(' ','').upper()
col = math.ceil(len(inputs)/len(key))

#vaildating key
def invalidKey():
    print('Invalid key')
    exit()

#asign number to key
if key.isdigit() == False:
    newKey = []
    temp = 0
    for i in range(len(key)):
        newKey.append(0)
    for j in range(len(var1)):
        for i in range(len(key)):
            if key[i] == var1[j]:
                temp += 1
                newKey[i] = temp

#formatting part 1
newInputs = []
temp = 0
for i in range(col):
    newInputs.append([])
for i in range(len(key)):
    for j in range(col):
        if temp >= len(inputs):
            break
        newInputs[j].append(inputs[temp])
        temp += 1

#reorder
temp = 0
temp1 = []
for i in range(col):
    temp1.append([])
    for j in range(len(newKey)):
        temp1[i].append("")
for i in range(len(key)):
    for j in range(len(newKey)):
        if newKey[j] == i+1:
            for k in range(col):
                temp1[k][i] = newInputs[k][j]
            break

#output
output = ""
for i in range(len(temp1)):
    for j in range(len(temp1[i])):
        output += temp1[i][j]
print(output)