#act 1
'''
tempureture = int(input('Enter outside temperture: '))

if tempureture <=-5:
    print('Go bowling')
elif tempureture <=0:
    print('Go Skiing')
elif tempureture <=20:
    print('Go Jogging')
elif tempureture <=25:
    print('Play tennis; wear while clothes')
elif tempureture <=30:
    print('Go Sun-tanning in the park')
else:
    print('Go Swimming')
'''

#act 2
'''
mark = 25
#mark = -10
#mark = 70
#mark = 101
if mark > 0 :
    if mark >= 50:
        print('You have passed')
        print('Good job done')
    else:
        print('You have failed')
else:
    print ('Invalid mark')
'''

#act 3
'''
pages = 600
if pages <= 100:
    cost = pages * .03
elif pages <= 300:
    cost = 100 *.03 + (pages - 100) * .02
else:
    cost = 100 * .03 + 200 * .02 + (pages - 300) * .01

print(cost)
'''

'''
number = 20
count = 1
total = 0
while count <= number:
    if count % 2 == 0:
        total = total + count 
    count = count + 1
print('Total of even number: ' + str(count))
'''