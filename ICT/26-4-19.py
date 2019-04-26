#boolen 1
'''
x=1
y=4
z=14
print(x<=1 and y==3)
print(x<= 1 or  y==3)
print(not(x>1))
print(not x>1)
print(not(x<=1 or y==3))
print(x<=1 or y>1 and z<1)
print((x<= 1 or y>1) and z<1)
'''

#boolen 2
'''
age=16
gender='male'
pi=3.14
print(age, type(age))
s = str(age)
print(s, type(s))
num = float(age)
print(num, type(num))
print(pi, type(pi))
'''
#boolen 3
'''
age= input('Enter age: ')
gender= input('Enter gnder (male/female): ')
print(age, gender)
'''

#math
'''
import math
num = float(input('Enter number: '))
print(math.sqrt(num))
print(math.pow(num, 2))
print(math.trunc(3.123))
'''

#math 2
'''
import math
sec = int(input('Enter seconds: '))
hours = sec // (60 *60)
minutes = (sec % (60*60)) //60
seconds = (sec % (60*60)) % 60
print(hours, minutes, seconds)
'''
print(5 == 5.0)
#Answer: true

print(5 == "5")
#Answer: false

print(True or False and False)
#Answer: true

print((True or False) and False)
#Answer: false

print(True and (False or not True))
#Answer: false

print(str(53) + str(True))
#Answer: false