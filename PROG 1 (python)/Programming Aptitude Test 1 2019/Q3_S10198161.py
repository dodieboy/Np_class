plate = input('Enter the vehicle number to be validates: ')

num = (9,4,5,4,3,2)
alphabet = ('A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z')
last_alphabet = ('A','Z','Y','X','U','T','S','R','P','M','L','K','J','H','G','E','D','C','B')

#way 1
'''
for i in range(0, len(alphabet)):
    if plate[1] == alphabet[i]:
        temp = str(i + 1)

for i in range(0, len(alphabet)):
    if plate[2] == alphabet[i]:
        temp = temp + str(i + 1)
temp = temp + plate[3] + plate[4] + plate[5] + plate[6]
'''

#way2
for i in range(0, len(alphabet)):
    if plate[1] == alphabet[i]:
        A = str(i + 1)
    if plate[2] == alphabet[i]:
        B = str(i + 1)
temp = A + B + plate[3] + plate[4] + plate[5] + plate[6]

cal = 0
for i in range(0, 6):
    cal += int(temp[i]) * num[i]
remainder = cal % 19

if last_alphabet[remainder] == plate[7]:
    print('Validity of the vehicle number: Valid')
else:
    print('Validity of the vehicle number: Invalid')