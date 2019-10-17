#Programming I

#####################################
#      Mission 3.1                  #
#     Electrical Cost Calculator    #
#####################################

#Background
#==========
#Write a program that prompts user to enter the
#electricity cost for 3 months in a line, separated by ‘;’
#and displays the average electricity cost in 2 decimal places.


#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST (at least) use the following variables:
#   - mthly_cost
#   - total
#   - average

#START CODING FROM HERE
#======================
#Prompt for input of electrical costs and store in mthlyCost


#Do not edit the next line
def calculate_average(mthly_cost):
    #Parse the string, extract the electrical cost, and add to the total
    #Hint: Use a combination of the find built-in string method and
    #      index to extract each month's cost, then add it into total
    list1 = mthly_cost.split(";")
    total = float(list1[0]) + float(list1[1]) + float(list1[2])  #Compute the total electrical costs over 3 months
    average = float(total) / len(list1)  #Compute the average cost
    
    print(average) #Modify to display the average cost

    return average #Do not edit/remove this line

#Do not edit/remove the next line
calculate_average(mthly_cost)

#input '30.5;40.5;20' output 30.333333333333332
#input '25;30;35' output 30.0
