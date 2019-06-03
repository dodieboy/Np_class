#Q3A
description = ["Apple Pie", "Chicken Pie", "Apple Tart", "Egg Tart", "Durian Tart"]
price = [1.8, 2.9, .85, .95, 1.1]     
quantity = [3, 5, 9, 12, 30] 

#Q3B
total = 0

for i in range(len(price)):
    total += (price[i] * quantity[i])

print("Total cost is {:.2f}".format(total))

#Q3C
print("{:<15} {:<13} {:<11}".format("Item", "Unit Price", "Quantity"))
print("{:<15} {:<13} {:<11}".format("====", "==========", "==========="))

for i in range(len(price)):
    if description[i].find('Tart') != -1:
        print("{:<15} {:<13} {:<11}".format(description[i], price[i], quantity[i]))