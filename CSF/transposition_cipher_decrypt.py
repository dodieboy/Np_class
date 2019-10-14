import math
var1 = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z']
inputs = input('Plaintext: ').replace(' ','').upper()
key = input('Key: ').replace(' ','').upper()
col = math.ceil(len(inputs)/len(key))
#asign number to key
newKey, temp = [], 0
for i in range(len(key)):
    newKey.append(0)
if key.isdigit() == True:
    for i in range(len(key)):
        newKey[i] = int(key[i])
else:
    for j in range(len(var1)):
        for i in range(len(key)):
            if key[i] == var1[j]:
                temp += 1
                newKey[i] = temp
#initialization
newInputs, reorder = [], []
for i in range(col):
    newInputs.append([])
    reorder.append([])
    for j in range(len(newKey)):
        reorder[i].append("")
#formatting
temp = 0
for i in range(len(newKey)):
    for j in range(col):
        if temp >= len(inputs):
            break
        newInputs[j].append(inputs[temp])
        temp += 1
#reordering
for i in range(len(newKey)):
    for j in range(len(newKey)):
        if newKey[j] == i+1:
            for k in range(col):
                reorder[k][i] = newInputs[k][j]
            break
#output
output = ""
for i in range(len(reorder)):
    for j in range(len(reorder[i])):
        output += reorder[i][j]
print(output)