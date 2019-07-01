#function 1
'''
#var
module = ['CM', 'Prog1', 'CSF']
cm = [75, 30, 70, 90 ,95]
prg1 = [45, 80, 75, 50, 95]
csf = [80, 65, 70, 70, 95]

#average function
def average(marks):
    total = 0
    for num in marks:
        total += num
    result = total/len(marks)
    return result

#display average of all module function
def display(name_list, marks_list):
    for i in range(len(name_list)):
        print(name_list[i], average(marks_list[i]))
        
#function caller
display(module, [cm, prg1, csf])
'''
#activity 1
'''
import random

num1 = random.randint(1,25)
num2 = random.randint(1,25)
num3 = random.randint(1,25)
num4 = random.randint(1,25)
print(num1, num2, num3, num4)

def find_larger(num1, num2):
    if num1 > num2:
        return num1
    else:
        return num2

final = find_larger(find_larger(num1, num2), find_larger(num3, num4))

print(final)
'''
'''
#activity 2
num_list = [10, -13, 50, 5, 7, 24, 65, -40, 44, 70]

def is_even(num):
    if num % 2 == 0:
        return True
    else:
        return False

for i in range(len(num_list)):
    if is_even(num_list[i]) == True:
        print("{} is an event number".format(num_list[i]))
    else:
        print("{} is an odd number".format(num_list[i]))
'''
'''
#activity 4
def integar_power(base: int, exponent: int) -> int:
    result = 1

    for i in range(exponent):
        result *= base

    return result

print(integar_power(3, 4))
'''