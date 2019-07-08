main = input('Please enter the main string: ')
target = input('Please enter the target string: ')

score = 0
for i in range(0, 4):
    if main[i] != target[i]:
        score += 1

print('String Dissimilarity Score: ' + str(score))

if score < 2:
    print('High Similarity')
else:
    print('Low Similarity')