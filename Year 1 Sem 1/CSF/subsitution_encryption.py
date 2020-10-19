inputs = input("Enter: ")

var1 = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z']
var2 = ['Z','Y','X','W','V','U','T','S','R','Q','P','O','N','M','L','K','J','I','H','G','F','E','D','C','B','A']

new = ''

for i in range(len(inputs)):
    for x in range(len(var1)):
        if inputs[i] == var1[x]:
            new += var2[x]

print(new)