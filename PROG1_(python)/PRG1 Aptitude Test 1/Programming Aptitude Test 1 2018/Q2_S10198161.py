amount = int(input('Enter amount to withdraw: '))

dollar50 = amount / 50
dollar10 = amount % 50 / 10

print('{:.0f}'.format(dollar50) + ' $50 notes and ' + '{:.0f}'.format(dollar10) + ' $10 notes')