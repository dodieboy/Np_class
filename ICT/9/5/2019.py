#Activity 2
'''
num = int(input("Enter an integer number: "))
if num % 5 == 0:
    print(str(num) + " is divisible by 5 and 6")
elif num % 6 == 0:
    print(str(num) + " is divisible by 5 and 6")
else:
    print(str(num) + " is not divisible by 5 and 6")
'''
#Activity 3

import math
sideA = float(input('Enter length of Side A: '))
sideB = float(input('Enter length of Side B: '))
sideC = float(input('Enter length of Side C: '))

s1 = (sideA + sideB + sideC)/2
areas = math.sqrt(s1*(s1 - sideA)*(s1 - sideB)*(s1 - sideC))

print("{:.2f}".format(areas))