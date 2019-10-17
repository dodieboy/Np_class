#Programming I

#########################
#      Mission 8        #
#   HDB Resale Prices   #   
#########################

#Background
#==========
#Tom is conducting some research into HDB resale prices as part of his part-time work for a real estate agency.
#Write a program to find out the following:

#a) The 2017 average price for the 4-room flat type (in 2 decimal places)
#b) The number of transactions above the average resale prices in part (a)
#c) The town with the highest resale price for the 5-room flat type in 2017

#Return the result of the three parts in a list of 3 items (e.g., [34535.35,20,'Hougang']

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   four_room_average, above_average, town_highest
filename = "median-resale-prices-for-registered-applications-by-town-and-flat-type.csv"

#START CODING FROM HERE
#======================

#Create your function here
def ReadCSV(filename):
    #comment if uploading to coursemology
    import os
     #pls change to the location with the csv file
    os.chdir(r"C:\Users\Alan\Desktop\school\Np\Np_class\PROG 1 (python)\coursemology")
    
    file = open(filename)
    tempList = []
    
    #to convert csv data to list
    for line in file:
        formats = line.replace("\n","").split(",")
        tempList.append(formats)
    tempList.pop(0)

    #Part a
    four_room_average = 0
    temp = 0
    for i in range(len(tempList)):
        if tempList[i][2] == "4-room":
            if tempList[i][3] == "na" or tempList[i][3] == "-":
                pass
            else:
                temp += 1
                four_room_average += int(tempList[i][3])
    four_room_average = round(four_room_average/temp, 2)

    #Part b
    above_average = 0
    for i in range(len(tempList)):
        if tempList[i][2] == "4-room":
            if tempList[i][3] == "na" or tempList[i][3] == "-":
                pass
            else:
                if int(tempList[i][3]) > four_room_average:
                    above_average += 1

    #Part c
    town_highest = ""
    temp = 0
    for i in range(len(tempList)):
        if tempList[i][2] == "5-room":
            if tempList[i][3] == "na" or tempList[i][3] == "-":
                pass
            else:
                if int(tempList[i][3]) > temp:
                    temp = int(tempList[i][3])
                    town_highest = tempList[i][1]
    return [four_room_average, above_average, town_highest]

#Do not remove the next line
ReadCSV(filename)

#output [459567.74, 33, 'Toa Payoh']