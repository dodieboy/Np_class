#Programming I

#####################################
#            Mission 2.1            #
#    Compound Interest Calculator   #
#####################################

#Background
#==========
#Tom won a lottery amounting to $10000, and he is deciding if he should
#deposit it into a bank account to accumulate interest.

#Tom wishes to find out how much he will have in the bank account after
#a specified number of years, given his input.

#Requirements
#============
#1) Write pseudocode that sets the principal amount of $10000 to variable p,
#   annual nominal interest rate of 8% to variable r, number of times the
#   interest is compounded per year of 12 to variable n. The number of years
#   that the money will be compounded, t, is given by the user. Calculate
#   and print the final amount after t years.
#   Note: Refer to the question in Coursemology for the formula.

#2) Write a Python program to solve the problem.

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) Include the pseudocode that you have developed as comments at the
#   beginning of the next section.
#3) You MUST (at least) use the following variables:
#   - p (principal amount)
#   - r (annual nominal interest rate [as a decimal])
#   - n (number of times the interest is compounded per year)
#   - t (number of years)

#START DEVELOPING PSEUDOCODE AND CODE FROM HERE
#==============================================




#Perform calculation for final amount 
def calculate_final_amount(p,r,n,t):
     
    amount = p*(1+(r/n))**(n*t)
    print(amount)

    return amount #Do not remove this line

#Do not remove the next line
calculate_final_amount(10000,0.08,12,5)
calculate_final_amount(10000,0.08,12,1)

#input 10000,0.08,12,5    output 14898.45708301605
#input 10000,0.08,12,1    output 10829.995068075097
