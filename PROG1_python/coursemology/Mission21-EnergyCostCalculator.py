#Programming I

###############################
#       Mission 2.1           #
#    Energy Cost Calculator   #
###############################

#Background
#==========
#Ever wonder the energy cost of running an appliance or electronic device?
#Here is a simple calculation to get that figure.

#Step 1:
#Monthly electricity consumption =
#   (Power rating [Watts] of device * Number of hours used per day)/1000

#Step 2:
#Cost = Monthly electricity consumption * Electricity tariff
#                                         ($0.2156 as of 20 April 2018)

#Laptop computers may peak at a maximum draw of only 60 watts,
#whereas common desktops may peak around 175 watts.

#Write a Python program to create an Energy Cost Calculator.
#The program is to prompt user for the power rating of a device and 
#the number of hours used per day. After which, display the calculated cost.

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST (at least) use the following variables:
#   - power_rating
#   - hours

#START CODING FROM HERE
#======================




#Perform monthly energy cost calculation 
def calculate_cost(power_rating,hours):
    consumption = power_rating * hours/1000
    cost = consumption * 0.2156
    print(cost)

    return cost #Do not remove this line

#Do not remove the next line
calculate_cost(500,8) 
calculate_cost(60,10) 
calculate_cost(175,2) 

#input 500,8   output 0.8624
#input 60,10   output 0.12936
#input 175,2   output 0.07546

