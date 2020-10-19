name_list= ['Sharon','Mic','Josh','Hannah','Hansel']
height_list = [172,166,187,200,166]
weight_list = [59.5,65.6,49.8,64.2,47.5]
size_list = ['M','L','S','M','S']

bmi_list = []
for i in range(len(name_list)):
    bmi = weight_list[i]/((height_list[i]/100)**2)
    bmi_list.append('{:.2f}'.format(bmi))

print("{:<10} {:<8} {:<8} {:<8} {:<5}".format('Name','Weight','Height','BMI','Size'))

for i in range(len(name_list)):
    print("{:<10} {:<8} {:<8} {:<8} {:<5}".format(name_list[i], weight_list[i],height_list[i],bmi_list[i],size_list[i]))