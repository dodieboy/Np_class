
card1 = int(input('Enter card 1: '))
card2 = int(input('Enter card 2: '))
card3 = int(input('Enter card 3: '))

total = 0
ace = 0

for i in range(1, 14):
    if card1 == i:
        if i == 11 or i == 12 or i == 13:
            total += 10
        elif i == 1:
            total += 11
            ace += 1
        else:
            total += i
    if card2 == i:
        if i == 11 or i == 12 or i == 13:
            total += 10
        elif i == 1:
            total += 11
            ace += 1
        else:
            total += i
    if card3 == i:
        if i == 11 or i == 12 or i == 13:
            total += 10
        elif i == 1:
            total += 11
            ace += 1
        else:
            total += i

if ace > 0:
    if total > 21:
        total = total - (ace * 10)

print(total)