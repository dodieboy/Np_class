weight = float(input('Total weiht of baggage (kg): '))
if weight <= 30:
    print('You do not have to pay for your baggage.')
else:
    overweight = weight - 30
    pay = overweight * 12
    print('Your baggage is {}kg more than the limit of 30kg.'.format(overweight))
    print('You will have to pay ${:.2f}'.format(pay))