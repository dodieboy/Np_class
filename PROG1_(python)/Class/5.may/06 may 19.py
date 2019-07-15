#practice quusetion 2 Q1
'''
diesel = input('Litres of diesel: ')
petrol = input('Litres of pertol: ')

dieselCarbon = 2.6391 * diesel
petrolCarbon = 2.3035 * petrol

print('The diesel produce ' + "{:.2f}".format(dieselCarbon) + ' kg of carbon dioxide')
print('The petrol produce ' + "{:.2f}".format(petrolCarbon) + ' kg of carbon dioxide')
'''
'''
volume = input('Enter voulme of litres: ')

dieselCarbon = 2.6391 * volume
petrolCarbon = 2.3035 * volume

print('The diesel produce ' + "{:.2f}".format(dieselCarbon) + ' kg of carbon dioxide')
print('The petrol produce ' + "{:.2f}".format(petrolCarbon) + ' kg of carbon dioxide')
'''
#practice quusetion 2 Q1
'''
amount = int(input('Enter amount to withdraw: $'))

dollar50 = amount // 50
dollar10 = (amount % 50) // 10
print(str(dollar50) + ' $50 notes ' + str(dollar10) + ' $10 notes')
'''

#condition 1
'''
age = 15
if age>= 16:
    print('con watch NC 16 movies')
else:
    print('cannot watch NC 16 movies')
'''
#activity1
'''
sale = int(input('Enter monthly sales of sales agent: '))

if sale >= 10000:
    rate = 10
else:
    rate = 5

paid = sale * rate/100

print('The commission rate is: ' + str(rate) + '%')
print('The commission paid is: $' +str(paid))
'''
#activity 2
'''
import random
num1 = random.randint(0, 100)
num2 = random.randint(0, 100)

ans = int(input('Enter the sum of ' + str(num1) + ' and ' + str(num2) + ': '))
cAns = num1 + num2
if ans == cAns:
    print('Your answer is correct')
else:
    print('Your answer is wrong')
    print('The correct answer is ' + str(cAns))
'''