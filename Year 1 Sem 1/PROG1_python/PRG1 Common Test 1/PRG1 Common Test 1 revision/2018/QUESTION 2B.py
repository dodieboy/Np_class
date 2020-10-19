weight = float(input("Enter weight of parecel in kg: "))
express_service = input("Is express service required (y/n) : ")

final_price = 0

if weight < 1:
    final_price += 10
elif weight < 5:
    final_price += 15
else:
    final_price += 20

if express_service == 'y':
    final_price += 10.50

print("The cost is {:.2f}".format(final_price))