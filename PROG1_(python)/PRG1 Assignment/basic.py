''' 
THIS IS NOT PART OF THE CODE
============================================================================
SPDX-Short-Identifier: MIT
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
============================================================================
'''



import os, copy
os.chdir(r"C:\Users\Alan\Desktop\Np_Prog_assign")

maze_list=[]

def menu():
    print('MAIN MENU')
    print('===============================================')
    print('[1] Read and load maze from file')
    print('[2] View maze')
    print('[3] Play maze game')
    print('[4] Configure current maze')
    print('[5] Export maze to file')
    print('[6] Create new maze')
    print('[7] Play maze using SenseHAT')
    print('[8] View Leaderboard')
    print('\n[0] Exit Maze')
    inputs = input('Enter your option: ')
    return inputs
def file_load():
    maze_list.clear()
    num_line = 0
    print("Option [1] Read and load maze from file")
    print("===============================================")
    file = open(input("Enter the name of the data file: "))
    for line in file:
        num_line +=1 #to count number of line
        line = line.replace("\n","") #remove \n from the file
        line = list(line) #split each character
        maze_list.append(line) #add to a list
    file.close()
    print("Number of lines read: {}".format(num_line))
def maps(map):
    print("option [2]: View Maze\n===============================================\n")
    for i in range(len(map)):
        print(map[i])
def start_game(maze_lists):
    game_list = copy.deepcopy(maze_lists)
    A_cord = [] #row,col
    B_cord = [] #row,col
    game = True
    for i in range(len(game_list)):
        for j in range(len(game_list[i])):
            if game_list[i][j] == 'A':
                A_cord = [i,j]
                game_list[i][j] = 'O'
            elif game_list[i][j] == 'B':
                B_cord = [i,j]
    while game == True:
        game_list[A_cord[0]][A_cord[1]] = "A"
        print(u"option [3]: Play Maze game\n===============================================")
        for i in range(len(map)):
            print(map[i])
        print("Location of Start (A) = (Row {}, Column {})".format(A_cord[0]+1, A_cord[1]+1))
        print("Location of Start (B) = (Row {}, Column {})".format(B_cord[0]+1, B_cord[1]+1))
        inputs = input("Press 'W' for UP, 'A' for LEFT, 'S' for DOWN, 'D' for RIGHT, 'M' for Main Menu: ").upper()
        if inputs == 'M':
            game = False
        elif inputs == 'W':
            if A_cord[0] != 0 and game_list[A_cord[0]-1][A_cord[1]] != "X":
                game_map[A_cord[0]][A_cord[1]] = "O"
                A_cord[0] -= 1
            else:
                print('Invaild movement, Please try agian')
        elif inputs == 'S':
            if A_cord[0] != len(game_list) and game_list[A_cord[0]+1][A_cord[1]] != "X":
                game_map[A_cord[0]][A_cord[1]] = "O"
                A_cord[0] += 1
            else:
                print('Invaild movement, Please try agian')
        elif inputs == 'A':
            if A_cord[1] != 0 and game_list[A_cord[0]][A_cord[1]-1] != "X":
                game_map[A_cord[0]][A_cord[1]] = "O"
                A_cord[1] -= 1
            else:
                print('Invaild movement, Please try agian')
        elif inputs == 'D':
            if A_cord[1] != len(game_list[0]) and game_list[A_cord[0]][A_cord[1]+1] != "X":
                game_map[A_cord[0]][A_cord[1]] = "O"
                A_cord[1] += 1
            else:
                print('Invaild movement, Please try agian')
        if A_cord == B_cord:
            print('You have completed the maze!!!')
            game = False
def config_maze(inputs, values ,types):
    if types == 'point':
        for i in range(len(maze_list)):
            for j in range(len(maze_list[i])):
                if maze_list[i][j] == values:
                    maze_list[i][j] = 'X'
    formats = inputs.split(",")
    maze_list[int(formats[0])-1][int(formats[1])-1] = values
def config_menu():
    config1 = True
    while config1 == True:
        print("option [4]: CONFIGURATION MENU\n===============================================\n")
        for i in range(len(map)):
            print(map[i])
        print("1.Create wall")
        print("2.Create passageway")
        print("3.Create start point")
        print("4.Create end point")
        print("\n0.Exit")
        inputs = input("Enter your options: ")
        if inputs =="0":
            config = False
        elif inputs == "1":
            config2 = True
            while config2 == True:
                print("Create wall\n===============================================")
                for i in range(len(map)):
                    print(map[i])
                print("\nEnter the coordinate of the item you wish to change to wall E.g. Row, Column")
                print("Press 'B' to return to Configure Menu")
                print("Press 'M' to return to Main Menu")
                inputs3 = input("Enter your options: ").upper()
                if inputs3 == "B":
                    config2 = False
                elif inputs3 == "M":
                    config1 = False
                    config2 = False
                elif inputs3.replace(",","").isdigit() == True:
                    config_maze(inputs3, 'X', 'path')
                else:
                    print("Invaild input")
        elif inputs == "2":
            config2 = True
            while config2 == True:
                print("Create passageway\n===============================================\n")
                for i in range(len(map)):
                    print(map[i])
                print("\nEnter the coordinate of the item you wish to change to passageway E.g. Row, Column")
                print("Press 'B' to return to Configure Menu")
                print("Press 'M' to return to Main Menu")
                inputs3 = input("Enter your options: ").upper()
                if inputs3 == "B":
                    config2 = False
                elif inputs3 == "M":
                    config1 = False
                    config2 = False
                elif inputs3.replace(",","").isdigit() == True:
                    config_maze(inputs3, 'O', 'path')
                else:
                    print("Invaild input")
        elif inputs == "3":
            config2 = True
            while config2 == True:
                print("Create start point\n===============================================\n")
                for i in range(len(map)):
                    print(map[i])
                print("\nEnter the coordinate of the item you wish to change to start point E.g. Row, Column")
                print("Press 'B' to return to Configure Menu")
                print("Press 'M' to return to Main Menu")
                inputs3 = input("Enter your options: ").upper()
                if inputs3 == "B":
                    config2 = False
                elif inputs3 == "M":
                    config1 = False
                    config2 = False
                elif inputs3.replace(",","").isdigit() == True:
                    config_maze(inputs3, 'A', 'point')
                else:
                    print("Invaild input")
        elif inputs == "4":
            config2 = True
            while config2 == True:
                print("Create end point\n===============================================\n")
                for i in range(len(map)):
                    print(map[i])
                print("\nEnter the coordinate of the item you wish to change to end point E.g. Row, Column")
                print("Press 'B' to return to Configure Menu")
                print("Press 'M' to return to Main Menu")
                inputs3 = input("Enter your options: ").upper()
                if inputs3 == "B":
                    config2 = False
                elif inputs3 == "M":
                    config1 = False
                    config2 = False
                elif inputs3.replace(",","").isdigit() == True:
                    config_maze(inputs3, 'B', 'point')
                else:
                    print("Invaild input")
def export():
    print("Option [5] Export maze to file\n")
    file = open(input("Enter filename to save to: "),"w+")
    temp = ""
    for i in range(len(maze_list)):
        for j in range(len(maze_list[i])):
            temp += maze_list[i][j]
        temp+="\n"
    file.write(temp)
    file.close()
def create_map():
    print("Option [6] create new maze\n")
    inputs2 = input("This will emptey the current maze. Are you sure?(Y or N): ").upper()
    if inputs2 == "Y":
        inputs2 = input("Enter the dimension of the maze (row,colum): ").split(",")
        maze_list.clear()
        for i in range(int(inputs2[0])):
            maze_list.append([])
            for j in range(int(inputs2[1])):
                maze_list[i].append('x')
        print("\nA new maze of {} by {} has been created.".format(inputs2[0],inputs2[1]))
        print("Please run configure maze to start cinfiguring new maze")
#main code
while True:
    inputs = menu()
    if inputs == "0":
        exit()
    elif inputs == "1":
        file_load()
    elif inputs == "2":
        maps(maze_list)
    elif inputs == "3":
        start_game(maze_list)
    elif inputs == "4":
        config_menu()
    elif inputs == "5":
        export()
    elif inputs == "6":
        create_map()