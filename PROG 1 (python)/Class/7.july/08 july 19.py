#file importing
'''
import os
os.chdir(r'C:\\Users\\Alan\\Desktop\\school\\Np\\Np_class\\PROG 1 (python)\\Class\\7.july')
print(os.getcwd()) #check current dir

f = open('d:\\test\\testing.txt','r') #read file
#ws = open('d:\\test\\testing.txt','w') #write file
#a = open('d:\\test\\testing.txt','a') #appending file

for line in f:
    print(line, end='')

f.close()
#ws.close()
#a.close()
'''
#file importing 2
'''
import os
os.chdir(r'C:\\Users\\Alan\\Desktop\\school\\Np\\Np_class\\PROG 1 (python)\\Class\\7.july')
print(os.getcwd()) #check current dir
f = open('testing.txt','w') #read file

list1 = ['A','B','C']
for line in list1:
    f.write(line + '\n')
f.close()
'''
#week 13 activity 3
'''
filename = "receipt.txt"

file = open(filename, "w")

items = ['shoe','sock','gloves']
quantity = [10,5,32]

file.write('{:<10}{:<10}{:<10}\n'.format('S/N','Items','Quantity'))
file.write('{:<10}{:<10}{:<10}\n'.format('----------','----------','----------'))

for i in range(len(items)):
    file.write('{:<10}{:<10}{:<10}\n'.format(i+1,items[i],quantity[i]))
'''

#week 12 activty 1
def obtain_grade(mark):
    if mark >= 84.5 and mark <= 100:
        grade = 'A+'
    elif mark >= 79.5:
        grade = 'A'
    elif mark >= 74.5:
        grade = 'B+'
    elif mark >= 69.5:
        grade = 'B'
    elif mark >= 64.5:
        grade = 'C+'
    elif mark >= 59.5:
        grade = 'C'
    elif mark >= 54.5:
        grade = 'D+'
    elif mark >= 49.5:
        grade = 'D'
    else:
        grade = 'F'
    return grade


student_marks = [['Mary', 90.5], ['Charles', 60.4],['John', 70.5], ['Javier', 32.0], ['Luke', 46.7]]
print('{:<10}{:<10}{:<10}'.format('Student', 'Marks', 'Grade'))
for i in range(len(student_marks)):
    print(print(('{:<10}{:<10}{:<10}').format(student_marks[i][0], str(student_marks[i][1]),obtain_grade(float(student_marks[i][1])))))