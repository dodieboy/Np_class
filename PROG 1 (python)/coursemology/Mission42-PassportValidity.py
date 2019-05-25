#Programming I

#########################
#      Mission 4.2      #
#   Passport Validity   #
#########################

#Background
#==========
#All countries around the world require a valid passport for entry and insist
#on travellers having a minimum of six months left on their passport for entry.

#Write a Python program to check whether a person's passport is valid for entry.
#
#The program is to prompt user for the number of months left before his passport
#expires and also the number of months to his intended travel date.
#Display whether he needs to renew his passport or not.

#Return the Boolean True if renewal is required, False if not required.

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   - months_left
#   - months_to_entry


#START CODING FROM HERE
#======================

# Prompt and accept data from user.

#Check Validity
def check_validity(months_left, months_to_entry):

    if months_left - months_to_entry < 6 :        #Check if user's passport is valid for entry 
        print('User need to renew your passport') #Modify to display that user's passport is valid for entry
        return True #Modify accordingly
    else:
        print('User passport is valid') #Modify to display that user needs to renew his passport        
        return False #Modify accordingly

    
#Do not remove the next line
check_validity(months_left, months_to_entry) 

#input 50,9 output False
#input 12,9 output True
