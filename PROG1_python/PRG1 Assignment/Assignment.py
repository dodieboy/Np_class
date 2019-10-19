import os, re, copy, time
os.chdir(os.path.dirname(os.path.abspath(__file__)))
maze_list=[]
sensehat = True
try:
    from sense_hat import SenseHat
    s = SenseHat()
    s.low_light = True
except ModuleNotFoundError:
    sensehat = False
def box_formatting(messages): #To align words to center
    if((64-len(messages))/2) == int((64-len(messages))/2):
        output = (" "* int((64-len(messages))/2)) + messages + (" "*int((64-len(messages))/2)) 
    else:
        output = (" "* int((64-len(messages))/2)) + messages + (" "*(int((64-len(messages))/2)+1)) 
    return output
def gui_menu(title, messages, action, need_input): #Print a box with game name, tile and message to show the user
    clears()
    print(u"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n┃"+box_formatting("")+u'\u2503\n\u2503'+box_formatting("⌗  The Maze Game Main Menu ⌗")+u'\u2503\n\u2503'+box_formatting("")+u'\u2503\n\u2503'+box_formatting(title)+u'\u2503\n\u2503'+box_formatting(messages)+u'\u2503\n\u2503'+box_formatting("")+u'\u2503\n\u2503'+box_formatting("<"+action+">")+u'\u2503\n\u2503'+box_formatting("")+u"┃\n┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛")
    if need_input:
        input('')
        clears()
def clears(): #To remove the old interface that is not needed
    print("\n" * 40)
def menu(): #Print game main menu and get user option
    inputs = input(u"\n┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n┃                                                            ┃\n┃               ⌗  The Maze Game Main Menu ⌗                 ┃\n┃              ════════════════════════════════              ┃\n┃               1. Read and load maze from file              ┃\n┃               2. View maze map                             ┃\n┃               3. Play maze game                            ┃\n┃               4. Configure current maze                    ┃\n┃               5. Export maze to file                       ┃\n┃               6. create new maze                           ┃\n┃               7. Play maze using SenseHAT                  ┃\n┃               8. View Leaderboard                          ┃\n┃                                                            ┃\n┃               0 Exit Game                                  ┃\n┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n\nEnter your option: ")
    clears()
    return inputs
def maps(map): #Print the loaded map
    for i in range(len(map)):
        print(map[i])
def load(): #Load game file to a list
    try:
        maze_list = []
        print("Option [1] Read and load maze from file\n═════════════════════════════════════════════════\n")
        file = open(input("Enter the name of the data file: ")) #ask user to select file to open than open the file
        for line in file: #Format string to list
            maze_list.append(list(line.strip("\n"))) #remove "\n" than split the word to letter and but each letter in each list
        file.close()
        print("Number of lines read: {}".format(len(maze_list))) #Print the number of line (Row) in the map file
        return maze_list
    except FileNotFoundError: #Print error if cannot find the file
        gui_menu('!! ERROR !!','File is not found', "Press enter to go to continue", True)
        return maze_list
    except OSError: #Print error if user key invalid file name or format
        gui_menu('!! ERROR !!','File is not found', "Press enter to go to continue", True)
        return maze_list
def map_viewer(maze_list): #Option 2
    print("option [2]: View Maze\n═════════════════════════════════════════════════\n")
    if game_check("V", maze_list, '', '') == True: #check did the user load a map
        maps(maze_list) #print the map
        input("\n<Press ENTER to return>")
def game_check(types, maze_lists, a, b): #Game checker
    game = False
    if len(maze_lists) != 0: #Check if there is any map loaded
        if types == "V": #Return true if it want to view
            game = True
        elif types == "S" and (len(a) > 8 or len(b) > 8): #Print error if it is for sense hat and the map is more than 64 pixel
            gui_menu("!! ERROR !!", "Invalid Maze, maze is too big for sense hat", "Press enter to go to continue", True)
        elif len(a) == 0 or len(b) == 0: #Print error if a or b coord is not found in the map
            gui_menu("!! ERROR !!", "Invalid Maze, no start or end point", "Press enter to go to continue", True)
        else: #If everything is ok, return true
            game = True
    else: #Print error if the map is loaded
        gui_menu("!! ERROR !!", "No Maze file loaded", "Press enter to go to continue", True)
    return game
def game_move(dlt, dlt_value, a, row, col, game_map, move, types): #Checking and setting the new "A" location when move
    if a[dlt] != dlt_value and game_map[a[0]+row][a[1]+col] != "X": #Check if the next location is not out of map and is not a wall ("X")
        game_map[a[0]][a[1]] = "O" #Set the current "A" location to "O"
        a[0] += row #Set new "A" row coord
        a[1] += col #Set new "A" col coord
        if types == "C": #Do clear() if it is a console game
            clears()
    elif types == "C": #Print hit wall error if it is a console game
        gui_menu('!! ERROR !!','You have hit a wall, Please try again', "Press enter to go to continue", True)
    move += 1 #Add 1 more to move
    return a, game_map, move
def game_over(scoring):
    while True:
        gui_menu('Game Over', 'You have completed the maze!!!', "Please enter a name below", False) 
        name = input("Please enter a name with less than 25 letter: ") #ask player for name to put in leaderboard
        if len(name) == 0 or len(name) > 26: #If no name is key or is longer than 26 letter
            gui_menu('!! ERROR !!','Invalid name. Please try again', "Press enter to try again", True)
        else:
            leaderboard('add', name, (scoring[0]*100)-(scoring[1]*5), scoring[3]-scoring[2]) #send information to leaderboard()
            clears()
            game = False #end the game
            return game
def play_game(maze_lists, sensehat, types): #To start game for console and sense hat
    game_map = copy.deepcopy(maze_lists) #Duplicate the maze_list
    A_coord = [] #row,col
    B_coord = [] #row,col
    scoring = [0, 0, 0, 0] #number of path,move taken,start time , end time
    for i in range(len(game_map)):
        for j in range(len(game_map[i])):
            if game_map[i][j] == 'A': #To check "A" coord
                A_coord = [i,j]
                game_map[i][j] = 'O' #Replace "A" to "O" and "A" will be set later
            elif game_map[i][j] == 'B': #Tocheck "B coord"
                B_coord = [i,j]
            if game_map[i][j] == 'O': #Check number of path in the map
                scoring[0] += 1
    if types == "C": #If it is a console game
        game = game_check('C', maze_list, A_coord, B_coord) #Check if it is ready to play
        scoring[2] = time.time() #Set start time
        while game:
            game_map[A_coord[0]][A_coord[1]] = "A" #Set "A" to the location set
            print(u"option [3]: Play Maze game\n═════════════════════════════════════════════════")
            maps(game_map) #Print map
            inputs2 = input("\nLocation of Start (A) = (Row {}, Column {})\nLocation of End (B) = (Row {}, Column {})\nPress 'W' for UP, 'A' for LEFT, 'S' for DOWN, 'D' for RIGHT, 'M' for Main Menu: ".format(A_coord[0], A_coord[1],B_coord[0],B_coord[1])).upper() #Ask player on what to do
            if inputs2 == 'M': #Stop the game if input "M"
                game = False
            elif inputs2 == 'W': #Move "A" up
                A_coord, game_map, scoring[1] = game_move(0, 0, A_coord, -1, 0, game_map, scoring[1], "C")
            elif inputs2 == 'S': #Move "A" down
                A_coord, game_map, scoring[1] = game_move(0, len(game_map), A_coord, 1, 0, game_map, scoring[1], "C")
            elif inputs2 == 'A': #Move "A" left
                A_coord, game_map, scoring[1] = game_move(1, 0, A_coord, 0, -1, game_map, scoring[1], "C")
            elif inputs2 == 'D': #Move "A" right
                A_coord, game_map, scoring[1] = game_move(1, len(game_map[0]), A_coord, 0, 1, game_map, scoring[1], "C")
            else: #Print error if invalid input
                gui_menu('!! ERROR !!','Invalid input. Please try again', "Press enter to continue", True)
            if A_coord == B_coord: #When "A" reach "B" coord
                scoring[3] = time.time() #Set end time
                game = game_over(scoring)
    elif types == "S" and sensehat == True: #If it is a sense hat game
        game = game_check('S', maze_list, A_coord, B_coord)
        scoring[2] = time.time() #Set start time
        gui_menu("Have started on your SenseHAT","Use the joystick the play the game", "Middle click the joystick to exit the game", False)
        while game: 
            s.set_pixels(sensehat_map(A_coord, game_map)) #print the map to sensehat
            if A_coord == B_coord: #When "A" reach "B" coord
                scoring[3] = time.time() #Set end time
                s.show_message("Game over", text_colour=[255, 255, 255], back_colour=[0, 255, 0], scroll_speed=0.08) #show game 
                s.clear()
                game = game_over(scoring)
            for event in s.stick.get_events(): #Check for senshat joystick event
                if event.direction == "up" and event.action == "pressed": #If up
                    A_coord, game_map, scoring[1] = game_move(0, 0, A_coord, -1, 0, game_map, scoring[1], "S")
                elif event.direction == "down" and event.action == "pressed": #If down
                    A_coord, game_map, scoring[1] = game_move(0, len(game_map), A_coord, 1, 0, game_map, scoring[1], "S")
                elif event.direction == "left" and event.action == "pressed": #if left
                    A_coord, game_map, scoring[1] = game_move(1, 0, A_coord, 0, -1, game_map, scoring[1], "S")
                elif event.direction == "right" and event.action == "pressed": #if right
                    A_coord, game_map, scoring[1] = game_move(1, len(game_map[0]), A_coord, 0, 1, game_map, scoring[1], "S")
                elif event.direction == "middle" and event.action == "pressed": #if middle
                    s.clear()
                    game = False #End the game
                    clears()
    elif sensehat == False: #If cannot detect sensehat, print error
        gui_menu("!! ERROR !!","Cannot detect Sense Hat module", "Press enter to go to main menu", True)
def config_menu(maze_list):
    config = game_check("V", maze_list, '', '') #check did the user load a map
    while config:
        print("option [4]: CONFIGURATION MENU\n═════════════════════════════════════════════════\n")
        maps(maze_list) #Print map
        print(u"\n1. Create wall\n2. Create passageway\n3. Create start point\n4. Create end point\n\n0. Exit to Main Menu\n")
        inputs = input("Enter your options: ") #Ask user what they want to config
        clears()
        if inputs =="0":
            break
        elif inputs == "1": #if config wall
            config = config_option('wall', 'X' , 'path', maze_list)
        elif inputs == "2": #if config passageway
            config = config_option('passageway', 'O' , 'path', maze_list)
        elif inputs == "3": #if config start point
            config = config_option('start points', 'A' , 'point', maze_list)
        elif inputs == "4": #if config end point
            config = config_option('end points', 'B' , 'point', maze_list)
        else:
            gui_menu('!! ERROR !!','Invalid input', "Press enter to return back", True)
    return maze_list
def config_option(option, values ,types, maze_list):
    while True:
        print("Create "+ option +"\n═════════════════════════════════════════════════")
        maps(maze_list) #Print map
        print("\nEnter the coordinate of the item you wish to change to "+ option +" E.g. Row, Column\nPress 'B' to return to Configure Menu\nPress 'M' to return to Main Menu")
        inputs = input("Enter your options: ").upper() #Ask user what coord to do the change
        if inputs == "B" or inputs == "M": #To exit to config menu or main menu
            clears()
            config = True
            if inputs == "M":
                config = False
            return config
        elif inputs.replace(",","").isdigit() == True and inputs.count(',') == 1: #check if the input is format correctly
            inputs = inputs.split(",") #format to input into a list [row,col]
            if int(inputs[0]) >= len(maze_list)-1 or int(inputs[0]) < 0 or int(inputs[1]) >= len(maze_list[0]) or int(inputs[1]) < 0: #check if it is out of range
                gui_menu("!! ERROR !!","Invalid input", "Press enter to try again", True)
            else:
                maze_list = config_maze(inputs, values, types, maze_list)
        else: #when format is wrong, print error
            gui_menu("!! ERROR !!","Invalid input", "Press enter to return back", True)
    return maze_list
def config_maze(inputs, values ,types, maze_list): #Set change done by config
    if types == 'point': #If is it changing "A" or "B" point
        for i in range(len(maze_list)):
            for j in range(len(maze_list[i])):
                if maze_list[i][j] == values: 
                    maze_list[i][j] = 'X' #Set the current "A" or "B" point to "X"
    maze_list[int(inputs[0])][int(inputs[1])] = values #place the new "A" or "B" location
    clears()
    print("The change have been make.") #Inform the use the change is done
    return maze_list
def export(maze_list): #Export current loaded map to a file
    print("Option [5] Export maze to file\n")
    file = open(input("Enter filename to save to: "),"w+") #Ask user for filename
    temp = ""
    for i in range(len(maze_list)):
        for j in range(len(maze_list[i])):
            temp += maze_list[i][j] #Reformat list to string
        temp+="\n"
    file.write(temp) #Write the string to a file
    file.close()
    gui_menu("Game File", "Exported succesfully", "Press enter to go to continue", True) #Inform the the export is done
def create_map(): #Create a empty map
    print("Option [6] create new maze\n")
    inputs2 = input("This will empty the current maze. Are you sure?(Y or N): ").upper() #To confirm with user as it wil overwrite the old map
    if inputs2 == "Y": #If user agree
        inputs2 = input("Enter the dimension of the maze (row,colum): ") #Ask user the map size in "row,col"
        if inputs2.replace(",","").isdigit() == True and inputs2.count(',') == 1: #Check if the input format is correct
            inputs2 = inputs2.split(",")
            maze_list.clear() #Remove old map
            for i in range(int(inputs2[0])): #Create the new map
                maze_list.append([])
                for j in range(int(inputs2[1])):
                    maze_list[i].append('X')
            print("\nA new maze of {} by {} has been created.\nPlease run configure maze to start cinfiguring new maze".format(inputs2[0],inputs2[1])) #Inform the user the map the created
        else: #when format is wrong, print error
            gui_menu("!! ERROR !!","Invalid input", "Press enter to back to main menu", True)
    elif inputs2 == "N":
        pass
    else: #print error when invalid input
        gui_menu("!! ERROR !!","Invalid input", "Press enter to back to try again", True)
        create_map()
    return maze_list
def leaderboard(type, name, score, time): #For show and add leaderboard
    board = []
    if os.path.exists('Leaderboard.csv') == False: #Check is there leaderboard.csv
        file = open("Leaderboard.csv","w+") #Create leaderboard.csv if not found
    file = open("Leaderboard.csv","r") #Read the leaderboard.csv
    for line in file: #Format string to list
        temp = (line.strip("\n").split(","))
        temp[1] = int(temp[1])
        temp[2] = float(temp[2])
        board.append(temp)
    if type == "show": #To show the leaderboard
        print("Option [8] Leaderboard\n")
        print("{:>4}{:<2}{:<25}{:<3}{:<10}{:<3}{:<8}".format("Rank","","Player name","","Score","","Time"))
        for i in range(len(board)):
            print("{:>4}{:<2}{:<25}{:<3}{:<10}{:<3}{:<8.2f}".format(i+1,"",board[i][0],"",board[i][1],"",board[i][2]))
        input("<Press ENTER to go back menu>")
    elif type == "add": #To add new record to leaderboard
        file = open("Leaderboard.csv","w+")
        board.append([name,score,time])
        board.sort(key = lambda x: x[1], reverse = True) #Resort the leaderboard to top 10 score
        if len(board) > 10: #Remove any score below top 10
            for i in range(10,len(board)):
                board.pop(i)
        temp = ""
        for i in range(len(board)): #Format the list to string
            temp += str(board[i][0]) + "," + str(board[i][1]) + "," + str(board[i][2]) + "\n"
        file.write(temp) #Output the leaderboard to leaderboard.csv
    file.close()
def sensehat_map(a, game_map): #Format the map to fit senshat
    O = [0, 0, 0]  # Black
    X = [255, 0, 0]  # Red
    A = [0, 255, 0] # Green
    B = [0, 0, 255] #blue
    maps = []
    for i in range(8):
        if len(game_map) != 8:
            game_map.append([])
        for j in range(8):
            if len(game_map[i]) != 8:
                game_map[i].append('X')
            if i == a[0] and j == a[1]:
                maps.append(A)
            elif game_map[i][j] == 'B':
                maps.append(B)
            elif game_map[i][j] == 'O':
                maps.append(O)
            elif game_map[i][j] == 'X':
                maps.append(X)
    return maps
while True:
    inputs = menu()
    if inputs == "0": #When user input 0 in main menu
        exit()
    elif inputs == "1": #When user input 1 in main menu
        maze_list = load()
    elif inputs == "2": #When user input 2 in main menu
        map_viewer(maze_list)
    elif inputs == "3": #When user input 3 in main menu
        play_game(maze_list, sensehat, "C")
    elif inputs == "4": #When user input 4 in main menu
        config_menu(maze_list)
    elif inputs == "5": #When user input 5 in main menu
        export(maze_list)
    elif inputs == "6": #When user input 6 in main menu
        maze_list = create_map()
    elif inputs == "7": #When user input 7 in main menu
        play_game(maze_list, sensehat, "S")
    elif inputs == "8": #When user input 8 in main menu
        leaderboard('show', '', '', '')
    else: #When user input invalid input in main menu
        gui_menu('!! ERROR !!','Invalid input. Please try again', "Press enter to return back", True)