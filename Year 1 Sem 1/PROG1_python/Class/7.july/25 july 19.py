#week 14
#act 1
'''
import math
print("{:<6} {:<7} {:<7} {:7}".format("Degree","Redians","Sin","Cos"))
print("==================================")
for i in range(0,37):
    print("{:<6.0f} {:<7.4f} {:<7.4f} {:<7.4f}".format(i*10,math.radians(i*10),math.sin(i*10),math.cos(i*10)))
'''
#act 2 WIP
'''
import math
a = input('a here: ').split(" ")
b = input('b here: ').split(" ")

print(a)
print(b)

d = 6371.01 * math.acos(math.radians((math.sin(float(a[0]))*math.sin(float(b[0])))+(math.cos(float(a[0]))*math.cos(float(b[0]))*math.cos(float(a[1])-float(b[1])))))

print(d)
'''
'''
room1 = [1,2]
room2 = [2,2]
room3 = [3,1]

for room1item, room2item, room3item in zip(room1, room2, room3):
    print(room1item, room2item, room3item)
'''