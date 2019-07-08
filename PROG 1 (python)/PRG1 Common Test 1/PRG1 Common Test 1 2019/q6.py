name_list= ['Sharon','Mic','Josh','Hannah','Hansel']
height_list = [172,166,187,200,166]
weight_list = [59.5,65.6,49.8,64.2,47.5]
size_list = ['M','L','S','M','S']\

details_list = [['Sharon', 'F', 33], ['Mic', 'M', 24], ['Josh', 'M', 25 ], ['Hannah', 'F', 30], ['Hanzel', 'M', 26]]

gender = []
age = []
bmi_list = []
bmr_list = []
for i in range(len(name_list)):
    bmi = weight_list[i]/((height_list[i]/100)**2)
    bmi_list.append('{:.2f}'.format(bmi))

    temp = details_list[i]
    gender.append(temp[1])
    age.append(temp[2])

    if gender[i] == 'M':
        bmr = 66.47 + (13.7*weight_list[i]+(5*height_list[i])-(6.8*age[i]))
        bmr_list.append('{:.2f}'.format(bmr))
    else:
        bmr = 655.1 + (9.6*weight_list[i]+(1.8*height_list[i])-(4.7*age[i]))
        bmr_list.append('{:.2f}'.format(bmr))

print("{:<10} {:<8} {:<8} {:<8} {:<8} {:<5} {:<10}".format('Name','Weight','Height','BMI','Gender','Age','BMR'))

for i in range(len(name_list)):
    print("{:<10} {:<8} {:<8} {:<8} {:<8} {:<5} {:<10}".format(name_list[i], weight_list[i],height_list[i],bmi_list[i],gender[i],age[i],bmr_list[i]))