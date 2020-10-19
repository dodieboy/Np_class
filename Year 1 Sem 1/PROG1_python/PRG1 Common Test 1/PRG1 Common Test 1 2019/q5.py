name_list = ['Sharon','Mic','Josh','Hannah','Hansel']
height_list = [172,166,187,200,166]
weight_list = [59.5,65.6,49.8,64.2,47.5]
size_list = ['M','L','S','M','S']

bmi_list = []
predicted_list = []
for i in range(len(name_list)):
    bmi = weight_list[i]/((height_list[i]/100)**2)
    bmi_list.append('{:.2f}'.format(bmi))

    if bmi <= 18:
        predicted_list.append('S')
    elif bmi <=21:
        predicted_list.append('M')
    else:
        predicted_list.append('L')

print("{:<10} {:<8} {:<5} {:<10}".format('Name','BMI','Size', 'Predicted'))

for i in range(len(name_list)):
    print("{:<10} {:<8} {:<5} {:<10}".format(name_list[i],bmi_list[i],size_list[i],predicted_list[i]))

temp = len(predicted_list)
for i in range(len(predicted_list)):
    if predicted_list[i] != size_list[i]:
        temp -= 1
accuracy = temp / len(predicted_list) * 100
print('Accuracy rate is {:.2f}'.format(accuracy))