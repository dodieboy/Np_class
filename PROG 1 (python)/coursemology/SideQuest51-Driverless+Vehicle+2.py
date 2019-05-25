#Programming I

#############################
#     Side Quest 5.1        #
#   Driverless Vehicle 2    #
#############################

#Background
#==========
#Tom would like to enhance the safety of his driverless vehicle by applying braking when
#the vehicle is less than 50 meters from an object. 

#Write a Python program that prompts the user to enter a set of round trip times
#(similar to previous question, each value to be separated by commas, and speed of sound at 344 m/s),
#and returns True if the vehicle is too near an object or False if the vehicle is within safe margin of other objects.





#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   - roundTrips
#   - tooNear



#START CODING FROM HERE
#======================

#Prompt user to enter a minimum of 5 round trip times separated with commas
roundTrips =


#Check closest object
def fail_safety_distance(roundTrips):
    #Perform the parsing of roundTrips input here

            
    print('Object detected within safety distance:',tooNear) #Modify to display if there is an object that is too near
    
    return tooNear#Do not remove this line

    
#Do not remove the next line
fail_safety_distance(roundTrips)


#input 0.5,2.1,0.3,1.8,2.3  output False
#input 0.1,2.0,1.6,.5,1     output True
