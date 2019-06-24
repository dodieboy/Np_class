#Programming I

#######################
#    Mission 6.2      #
#      Calendar       #
#######################

#Background
#==========
#Tom wants to print his own calendar. Write a Python program to
#print the month view of a calendar
#Prompt the user for the number of days in the month and which
#day of the week does the first day of the month falls on. 


#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables
#   -   days
#   -   day_of_week

#START CODING FROM HERE
#======================
#Prompt user to enter number of days and first day of the week
days = int(input('Enter number of days: '))
day_of_week = input('The first day of the week(M,T,W,TH,F,SA,SU): ')

def print_calendar(days,day_of_week):
    formats = ['SU','M','T','W','TH','F','SU']
    start = 0
    week = []

    if day_of_week not in formats:
        print('Invaild day of the week!!!')
        return
    else:
        for i in range(len(formats)):
            if day_of_week == formats[i]:
                start = i + 1
    days += (start-1)

    print(('{:<3}{:<3}{:<3}{:<3}{:<3}{:<3}{:<3}').format('SU','M','T','W','TH','F','SA'))
    for i in range(1, (days+1)):
        if i < start:
            week.append(' ')
        else:
            week.append(i-(start-1))
        if len(week) == 7:
            print(('{:<3}{:<3}{:<3}{:<3}{:<3}{:<3}{:<3}').format(week[0],week[1],week[2],week[3],week[4],week[5],week[6]))
            week = []
        elif i == days:
            for x in range(8-len(week)):
                week.append(' ')
            print(('{:<3}{:<3}{:<3}{:<3}{:<3}{:<3}{:<3}').format(week[0],week[1],week[2],week[3],week[4],week[5],week[6]))


#Do not remove the next line
print_calendar(days,day_of_week)
