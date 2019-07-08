prompt user for card1
get card1
prompt user for card2
get card2
prompt user for card3
get card3

if jack or queen or king is in card1 or card2 or card3
    then total = total + 10
else if ace is in card1 or card2 or card3
    then total = total + 11
else
    then total = total + card number

if total is more than 21
    than total = total - (number of ace * 10)

output total  