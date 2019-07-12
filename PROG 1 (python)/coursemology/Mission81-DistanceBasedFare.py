#Programming I

###########################
#      Mission 8          #
#   Distance Based Fare   #   
###########################

#Background
#==========
#Distance-Based Fares (DBF) is a fare payment scheme currently used across public buses and MRT/LRT trains in Singapore.
#Fares are charged based on the total distance travelled (regardless if it is on a bus or train).
#The distance-based fare calculation is available in the distance-based-fare.csv file provided.
#Based on the route details of bus service 174 (bus_174.csv), write a program to meet the following requirements:

#a) Calculate the distance travelled based on the boarding and alighting bus stop
#b) Calculate the payable fare

#Return the result of the above answers in a list of two items (e.g., [29.0,1.90])

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   board, alight, distance, fare

#board = int(input('Enter boarding busstop: '))
#alight = int(input('Enter alighting busstop: '))

#board CODING FROM HERE
#======================

#Create your function here
def calculate_fare(board,alight):
    file = open("distance-based-fare.csv")
    fare_list=[]
    for line in file:
        formats = line.replace("\n","").split(",")
        fare_list.append(formats)
    fare_list.pop(0)

    file = open("bus_174.csv")
    busstop_list=[]
    for line in file:
        formats = line.replace("\n","").split(",")
        busstop_list.append(formats)
    busstop_list.pop(0)

    distance = 0
    fare = 0

    #Step a
    temp = [0,0]
    for i in range(len(busstop_list)):
        if int(busstop_list[i][1]) == board:
            temp[0] = float(busstop_list[i][0])
        if int(busstop_list[i][1]) == alight:
            temp[1] = float(busstop_list[i][0])

    distance = temp[1] - temp[0]
    #Step b
    for i in range(len(fare_list)):
        if distance > float(fare_list[i][0]):
            fare = float(fare_list[i+1][1])/100

    print(distance,fare)
    return [distance, fare]

#Do not remove the next line
calculate_fare(board, alight)
#calculate_fare(42089,10041)

#input 22009,10499 output [29.0, 1.9]
#input 28169,42059 output [9.2, 1.29]
#input 42089,10041 output [16.9, 1.61]