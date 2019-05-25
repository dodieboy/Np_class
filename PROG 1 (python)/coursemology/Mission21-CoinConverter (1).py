#Programming I

#####################################
#            Mission 2.1            #
#           Coin Converter          #
#####################################

#Background
#==========
#Tom needs to count and total up his coins.

#Requirements
#============
#Develop a pseudocode to solve the following problem:
#   -Given a number of 50-cent coins, 20-cent coins, 10-cent coins
#    and 5-cent coins, calculate and display the amount in dollars

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting (if any).
#2) Include the pseudocode that you have developed as comments at the
#   beginning of the next section.
#3) You MUST (at least) use the following variables:
#   - cent50 (number of 50-cent coins)
#   - cent20 (number of 20-cent coins)
#   - cent10 (number of 10-cent coins)
#   - cent5  (number of 5-cent coins)


#START DEVELOPING PSEUDOCODE AND CODE FROM HERE
#==============================================


#Perform calculation for final amount 
def calculate_final_amount(cent50,cent20,cent10,cent5):

    total = cent50*0.5 + cent20*0.2 + cent10*0.1 + cent5*0.05

    return round(total,2) #Do not remove this line

#TEST CASES
print(calculate_final_amount(5,4,3,2)) #Expected output 3.7
print(calculate_final_amount(0,0,10,30)) #Expected output 2.5
print(calculate_final_amount(90,80,0,0)) #Expected output 61.0
