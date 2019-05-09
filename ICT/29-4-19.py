'''
#string 1
s = 'hello'
print(s[0]) #output h
print(s[4]) #output o
#negitive index start from the right when positve start from the left
print(s[-1]) #output 0
print(s[-3]) #output l
#[start:less than value]
print(s[0:2]) #output he
print(s[:2]) #if no input, it auto input 0
print(s[:]) #if less than is empty, it use the max length
'''
'''
#string math
s = 'hello'
name = 'Jun Hao'
print((s + '') * 2 + name)

#set
print('a' in s)
print('h' not in s)
'''
'''
#string 2
#length
print(len('test')) # output 4

message = 'Welcome to ICT'
print(len(message))
print(message.find('ict'))
print(message.replace('ICT','NP'))
print(message[10])
print(message[11:14])
print('NP' in message)
print(message[22])
'''
'''
#string 3
s1 = 'Programming 1'
s2 = 'PRG1'

print(len(s1))
print(len(s1) % 2 == 0)
print(s1.replace('g','z'))
s1 = s1 + '' + s2
print(s1)
print(s1[0] == s1[-1])
'''
'''
#deleteString.py
originalString = input('Enter original string: ')
deleteString = input('Sunstring to delete: ')

index = originalString.find(deleteString)

leftString = originalString[0:index]
rightString = originalString[index + len(deleteString) + 1 : len(originalString)]

print(rightString)

newString = leftString + rightString
print('\nThe modified string is: {0}'.format(newString))
'''
'''
#list (array)
list1 = [1,2,3,4,5]
list2 = ['a','b','c']
list3 = [6, 7]
list4 = []
list5 = [1, 2, [3, 4]]
print(list5[0:3])
print(list2 == ['a','b','c'])
print(min(list1))
print(max(list1))

list4.append('tom') #add to list
list4.append('jerry')
print(list4)
'''