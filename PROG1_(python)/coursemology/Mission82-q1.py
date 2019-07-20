from sense_hat import SenseHat

s = SenseHat()
s.low_light = True

#color code
green = (0, 255, 0)
nothing = (0,0,0)

col = 1 #1 to 8 only
row = 7 #0 to 7 only

def images(row,col):
    G = green
    O = nothing

    logo = []
    for i in range(64):
        logo.append(O)
    
    logo[col+row*8-1] = G
    return logo

while True: 
    s.set_pixels(images(row,col))
    for event in s.stick.get_events():
        if event.direction == "up" and event.action == "pressed":
            if row != 0:
                row-=1
        if event.direction == "down" and event.action == "pressed":
            if row != 7:
                row+=1
        if event.direction == "left" and event.action == "pressed":
            if col != 1:
                col-=1
        if event.direction == "right" and event.action == "pressed":
            if col != 8:
                col+=1