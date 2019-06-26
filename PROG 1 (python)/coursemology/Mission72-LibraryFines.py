#Programming I

#######################
#     Mission 7.1     #
#    Library Fines    #
#######################

#Background
#==========
# Fines are imposed on late return of library books.
# Define a function called lib_fines() that calculates
# the total fines for an overdue book according to the
# following rules:


# Rule 1: $0.10 fine per day for a book overdue within 7 days 
# Rule 2: $0.20 fine per day for a book overdue more than 7 days 

#The function is to return the total fine for a given overdue book.

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   - overdueDays



#START CODING FROM HERE
#======================
#Prompt user to enter the number of days overdue
#overdue_days = int(input('Enter number of days overdue:'))

#Create your function here
price = 0

def lib_fines(overdue_days):
    if overdue_days <= 7:
        price = overdue_days * 0.1
        print(price)
    else:
        price =overdue_days * 0.2
        print(price)
    return price



    
#Do not remove the next line
lib_fines(overdue_days)
#round(lib_fines(6),2)

#3) For testing, write a print statement with 2 decimal place
#   - Comment out before submitting




