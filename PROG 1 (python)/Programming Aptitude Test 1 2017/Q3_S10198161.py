ic = input('Enter the IC to be validated: ')
#can do in 2 way

#First way (remove ''' for the code to work)
'''
cal = int(ic[1])*2 + int(ic[2])*7 + int(ic[3])*6 + int(ic[4])*5  + int(ic[5])*4 + int(ic[6])*3 + int(ic[7])*2 +4
remainder = cal % 11
'''

#Second way (remove ''' for the code to work)
'''
num = (2,7,6,5,4,3,2)

cal = 0
for i in range(1, 8):
    cal += int(ic[i]) * num[i-1]
cal += 4
remainder = cal % 11
'''

last_alphabet = ('J','Z','I','H','G','F','E','D','C','B','A')

if last_alphabet[remainder] == ic[8]:
    print('Validity of the IC: True')
else:
    print('Validity of the IC: False')
