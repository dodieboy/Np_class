inputs = input('Please enter your program in a string: ')

bracket = 0

for i in inputs:
    if i == "(":
        bracket += 1
    elif i == ")":
        bracket -= 1

    # if it start with ) first, end the loop
    if bracket < 0:
        break

if bracket == 0:
    print("The program has balanced delimeters.")
else:
    print("The program does not have balanced delimeters.")