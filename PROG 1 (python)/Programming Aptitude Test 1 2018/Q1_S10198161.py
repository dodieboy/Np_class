payment = float(input('Enter payment amount: $'))
interest = float(input('Enter interest rate: '))
years = float(input('Enter number of years: '))

discount = payment / (1 + interest)**years

print('The discounted value is $' + "{:.2f}".format(discount))