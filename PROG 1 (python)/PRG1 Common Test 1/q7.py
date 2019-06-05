num = int(input('Enter a number between 0 and 5000: '))

temp1 = ((num**2) + num)/2

temp = 0
isTriangle = False
while temp <= num:
    if num == (((temp**2) + temp)/2):
        isTriangle = True
        break
    temp += 1

if isTriangle:
    print('{:.0f} is a trangular number and it is the {:.0f}th number.'.format(num, temp))
else:
    print('{:.0f} is NOT a trangular number.'.format(num))