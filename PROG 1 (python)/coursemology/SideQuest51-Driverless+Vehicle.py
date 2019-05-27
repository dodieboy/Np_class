#Programming I

###########################
#     Side Quest 5.1      #
#   Driverless Vehicle    #
###########################

#Background
#==========
#Tom decided to start his own company to create a driverless vehicle. He is programming
#the collision avoidance system of the vehicle. The vehicle uses sonar sensor to measure
#distance between objects. It measures distance by sending out a sound wave and listening
#for that sound wave to bounce back. By recording the round trip time (seconds) from the
#sound wave being generated, to the sound wave bouncing back, it is possible to calculate
#the distance between the vehicle and the object.

#Given that sound travels through the air at 344 m/s, write a Python program that will
#find the closest object to the vehicle and return a list containing the index and the distance of the object.
#1.	Prompt the user to enter minimum 5 round trip times, each value separated by comma
#       (e.g. user should input in the format of 0.5, 2.1, 0.3, 1.8, 2.3)
#2.	If the user enters lesser than 5 timings, the program should prompt and error and return a list with the value [-1,-1]
#3.	Calculate the distance and find the closest object.
#4.	Print and return the index of the object in the user input, and the distance of this object.



#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   - roundTrips
#   - closestObject



#START CODING FROM HERE
#======================

#Prompt user to enter a minimum of 5 round trip times separated with commas
#roundTrips = 

#Check closest object
def closest_object(roundTrips):
    #Perform the parsing of roundTrips input here
    roundTrips = roundTrips.replace(' ', '')
    roundTrips = roundTrips.split(',')
    i = 0
    oj_index = 0
    while i < 5:
        if len(roundTrips) < 5:
            closestObject = [-1, -1]
        else:
            short = roundTrips[0]
            for x in range(len(roundTrips)):
                if short > roundTrips[x]:
                    short = roundTrips[x]
                    oj_index = x
            distance = 344 * (float(short) / 2)
            closestObject = [oj_index, distance]
        i += 1

    print('The closest object is',closestObject) #Modify to display the closest object
    
    return closestObject#Do not remove this line

#Do not remove the next line
closest_object(roundTrips)
#closest_object('0.1,2.0,1.6,0.05')
#closest_object('0.5, 2.1, 0.3, 1.8, 2.3')

#input 0.5,2.1,0.3,1.8,2.3  output [2, 51.6]
#input 0.1,2.0,1.6,0.05     output [-1,-1]
#input 0.1,2.0,1.6,.5,1     output [0, 17.2]
