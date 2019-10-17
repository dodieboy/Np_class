L = float(input('Enter loan amount: '))
A = float(input('Enter annual income: '))
C = float(input('Enter current loans: '))
S = float(input('Enter total saving: '))
Y = float(input('Enter years to pay back loan: '))

interest = (L + C) / (S + A * Y)

print('Your interest rate is {:.1f}%'.format(interest))