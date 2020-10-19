#Q1
num = int(input('Please key in an integer number: '))
if num % 5 == 0:
    print(str(num) + " is divisible by 5 and 6")
elif num % 6 == 0:
    print(str(num) + " is divisible by 5 and 6")
else:
    print(str(num) + " is not divisible by 5 and 6")

#Q2
sale = int(input('Enter monthly sales of sales agent: '))

if sale >= 10000:
    rate = 10
else:
    rate = 5

paid = sale * rate/100

print('The commission rate is: ' + str(rate) + '%')
print('The commission paid is: $' +str(paid))

#Q3
ta = float(input('Please enter the outside tempearture in Fahrenheit: '))
v = float(input('Please enter the wind speed in miles per hour: '))

if ta >= -58 and ta <= 41:
    twc = 35.74 + 0.6215 * ta - 35.75 * (v ** 0.16) + 0.4275 * ta * (v**0.16)
    print("The wind-chill index is "+"{:.2f}".format(twc))
else:
    print("Incorrect input")

#Q4
import math
sideA = float(input('Enter length of Side A: '))
sideB = float(input('Enter length of Side B: '))
sideC = float(input('Enter length of Side C: '))

if sideA == sideB or sideA == sideC or sideB == sideC:
    s1 = (sideA + sideB + sideC)/2
    areas = math.sqrt(s1*(s1 - sideA)*(s1 - sideB)*(s1 - sideC))
    print('Input lengths can from a triangle of area ' + "{:.2f}".format(areas) + ' square units')

else:
    print('Input lengths cannot form a triangle')

#Q5
print('Car Insurance Calculator')
print('========================')
gender = input('Enter gendder [M/F]: ')
age = int(input('Enter age: '))
accident = input('Have you been in a traffic accident before? [Y/N] ')

base = 800
ap = 0

def annual_premium(acc, nap):
    if acc == 'Y':
        new_ap = nap + 300
    else:
        new_ap = nap
    print('Your annual premium is: ' + "{:.1f}".format(new_ap))

if gender == 'M':
    if age > 64:
        ap = 800 * 1.7
    elif age >= 55:
        ap = 800 * 1.4
    elif age >= 45:
        ap = 800 * 1.0
    elif age >= 35:
        ap = 800 * 1.2
    elif age >= 25:
        ap = 800 * 1.5
    elif age < 25:
        ap = 800 * 1.8
    annual_premium(accident, ap)
elif gender == 'F':
    if age > 64:
        ap = 800 * 1.4
    elif age >= 55:
        ap = 800 * 1.2
    elif age >= 45:
        ap = 800 * 0.9
    elif age >= 35:
        ap = 800 * 1.1
    elif age >= 25:
        ap = 800 * 1.3
    elif age < 25:
        ap = 800 * 1.4
    annual_premium(accident, ap)
else:
    print('Invild input')