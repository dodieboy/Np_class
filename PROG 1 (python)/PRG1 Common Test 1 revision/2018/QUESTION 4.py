#Q4a
def main():
    num = int(input('Enter a number between 1 and 100: '))
    cal(num)
def cal(number):
    if 1 <= number <= 100:
        for i in range(1,101):
            if i % number == 0:
                print('skip')
            else:
                print(i)
    else:
        main()

#Run this funtion when code start
main()