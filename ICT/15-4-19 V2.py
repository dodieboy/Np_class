import math

age= 17
pi= 3.14
print(type(age),age)
print(type(pi),pi)

print(math.pi)

salary = float(input('Salary: ')) #float convert text(string) to number with decimal place
bonus = float(input('Bouns: '))
Income = salary * 12 + bonus
print('Your monthly is $' + str(Income)) #'' or "" is use to define string
print('Your monthly is $', Income) #we can use + or , to more than one value but , will auto add a space and auto convert indentifier/var


# # is comment
''' is also comment '''