import random
print('Welcome to Number Guessing Game')
num = random.randint(1, 10)
i = 0
x = True
while i < 5 and x == True:
    i += 1
    temp = int(input('Try '+ str(i) + ': Enter a number between 1 and 100 (or -1 to end): '))
    if temp == -1:
        i = 5
        x = False
    elif temp == num:
        print("Bingo, you've got it right!")
        x = False
    elif temp > num:
        print(str(temp) + ' is to high')
    elif temp < num:
        print(str(temp) + ' is to low')
if i == 5 and x == True:
    print('Game over')