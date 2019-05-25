#Programming I

#######################################
#            Mission 3.2              #
#   Calculate Daily Total Energy Cost #
#######################################

#Background
#==========
#The total energy cost is calculated using this formula: 
#Total Energy Cost ($) = Total Energy consumed (kW) x 0.2356

#Write a Python program that displays a table of energy in watts/hour
#for various appliances and prompt user to enter the daily hours for
#each appliance. The program then displays the table again with the
#daily hours and calculated value of the total daily energy cost.


#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST (at least) use the following variables:
#   - appliance_list
#   - hr_list
#   - hrs_input
#   - total_energy_cost

#START CODING FROM HERE
#======================
#Create a list named appliance_list with the 3 appliances
#shown in the screenshot in Coursemology
#appliance_list = 

#Prompt and obtain input for average daily consumption for appliances
#hrs_input =

#Perform Calculation of Total Daily Energy Cost
def calculateEnergyCost(appliance_list,hrs_input):
    #Code to parse the input string in hrs_input (Hint: Use the split() function)
    hr_list = hrs_input.split(";")
    app_hr = []

    print(appliance_list + hr_list) #Modify to display list of appliances and daily hours used
    
    for x in appliance_list:
        app_hr.append(x[1])

    total_energy = 0

    i = 0
    while i < len(hr_list):
        total_energy += int(app_hr[i])*int(hr_list[i])
        i += 1
    total_energy = total_energy / 1000
    
    total_energy_cost = total_energy * 0.2356#Formula to calculate total energy cost
    
    print(total_energy) #Modify to display the daily energy consumed
    print("{:.2f}".format(total_energy_cost)) #Modify to display the calculated total energy cost

    return total_energy_cost #Do not remove this line

    
#Do not remove the next line
calculateEnergyCost(appliance_list,hrs_input)
#calculateEnergyCost([['Electric Fan',70],['Air Con', 1200],['Refrigerator', 200]],'5;4;24')

#input [['Electric Fan',70],['Air Con', 1200],['Refrigerator', 200]],'5;4;24' output 2.34422










'''
#Programming I
#######################################
#            Mission 3.2              #
#   Calculate Daily Total Energy Cost #
#######################################
#Background
#==========
#The total energy cost is calculated using this formula: 
#Total Energy Cost ($) = Total Energy consumed (kW) x 0.2356
#Write a Python program that displays a table of energy in watts/hour
#for various appliances and prompt user to enter the daily hours for
#each appliance. The program then displays the table again with the
#daily hours and calculated value of the total daily energy cost.
#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST (at least) use the following variables:
#   - appliance_list
#   - hr_list
#   - hrs_input
#   - total_energy_cost
#START CODING FROM HERE
#======================
#Create a list named appliance_list with the 3 appliances
#shown in the screenshot in Coursemology
appliance_list = [
    ["Electric Fan", 70],
    ["Air Con", 1200],
    ["Refrigerator", 200]
]
print("""List of Electrical Appliances with Energy in Watts/Hr:
Name          Energy(Watts/Hr)""")
for appliance in appliance_list:
    print(appliance[0], appliance[1])
#Prompt and obtain input for average daily consumption for appliances
# hrs_input = input("Enter hours daily for the above appliances separated by ';' :")
#Perform Calculation of Total Daily Energy Cost
def calculateEnergyCost(appliance_list,hrs_input):
    #Code to parse the input string in hrs_input (Hint: Use the split() function)
    hr_list = list(map(int,hrs_input.split(';')))
    print("""List of Electrical Appliances with Energy in Watts/Hr:
    Name          Energy(Watts/Hr)          Daily Hrs Used""")
    for count, appliance in enumerate(appliance_list):
        print(appliance[0], appliance[1], hrs_input[count]) #Modify to display list of appliances and daily hours used
    
    total_energy = sum([x[1] * hr_list[i] / 1000 for i, x in enumerate(appliance_list)])#Calculate total energy of all appliances
    
    total_energy_cost = round(total_energy *  0.2356, 2) #Formula to calculate total energy cost
    
    print("Total daily energy consumed (kW):", total_energy) #Modify to display the daily energy consumed
    print("Total daily energy cost ($):", total_energy_cost) #Modify to display the calculated total energy cost
    return total_energy_cost #Do not remove this line
    
#Do not remove the next line
calculateEnergyCost(appliance_list,hrs_input)
#input [["Electric Fan",70],["Air Con", 1200],["Refrigerator", 200]],"5;4;24" output 2.34422
'''