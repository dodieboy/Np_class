#Programming I

#######################
#     Mission 6.2     #
#       Digipet       #
#######################

#Background
#==========
#With the Pokémon going all rage these days, Tom wants to create
#his own digital pet. In the digital pet, there are options to
#check the status of the pet, feed the pet, play with the pet, or
#let the pet rests. In the status section, player can see the pet’s
#level of hungriness, happiness, and energy. Each status can have
#a maximum level of 5 stars indicating full, or minimum 5 dots if
#the level is empty. If the player feeds the pet, the hungriness
#level will go up by 1 star, meanwhile causing the other 2 status
#to drop by 1 star. If the player plays with the pet, the happiness
#will go up by 1 star, while the other 2 will go down by 1 star.
#Likewise, if the player let the pet rests, the energy goes up by
#1 star, and the other 2 indicators will drop by 1 star.
#
#Write a Python program that allows the player to interact with
#the digital pet as described above. 


#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST use the following variables




#START CODING FROM HERE
#======================

def start_pet():
    hungry = 3
    happiness = 3
    energy = 3
    bar = ['.....','*....','**...','***..','****.','*****']

    print('Digipet')

    while True:
        print('(1) Feed\n(2) Play\n(3) Rest\n(4) Status')
        inputs = int(input('Please select an option: '))

        if inputs == 1:
            if hungry < 5:
                hungry += 1
            happiness -= 1
            energy -= 1
            print('Nom Nom Nom')
        elif inputs == 2:
            if happiness < 5:
                happiness += 1
            hungry -= 1
            energy -= 1
            print('XD')
        elif inputs == 3:
            if energy < 5:
                energy += 1
            hungry -= 1
            happiness -= 1
            print('Zzzzz')
        elif inputs == 4:
            print(('{:<9}{:<5}').format('hungry',bar[hungry]))
            print(('{:<9}{:<5}').format('happiness',bar[happiness]))
            print(('{:<9}{:<5}').format('energy',bar[energy]))


#Do not remove the next line
start_pet()



