names = ["John Tan", "Tom Ong", "Jane Lim", "Jim Ng", "Mary Choo", "Steve Goh", "Anne Lee"]
marks = [100, 75, 80, 20, 50, 70, 95]

print("{:<12} {:<4}".format('Names', 'Marks'))

average = 0
for i in range(len(names)):
    print("{:<12} {:<4}".format(names[i], marks[i]))
    average += marks[i]

average = average/len(names)
print('\nThe average marks for these students is {} mark'.format(average))

#code to show marks of surname 'Goh'
for i in range(len(names)):
    if names[i].find('Goh') != -1:
        print("\nThe marks of the student whose surname is 'Goh' is {}".format(marks[i]))