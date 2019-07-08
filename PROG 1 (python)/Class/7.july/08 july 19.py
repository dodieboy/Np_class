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
#activity 3
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