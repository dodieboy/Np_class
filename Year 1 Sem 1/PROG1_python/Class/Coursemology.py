from sense_hat import SenseHat
import time

s = SenseHat()
s.low_light = True

green = (0, 255, 0)
white = (255,255,255)
nothing = (0,0,0)
light_level = 8

def trinket_logo(light_level):
    G = green
    W = white
    O = nothing


    logo = []

    for i in range(8):
        if i == light_level:
            for k in range(8):
                logo.append(G)
        else:
            for k in range(8):
                logo.append(W)
    return logo

images = [trinket_logo]

while True: 
    s.set_pixels(images[0](light_level))
    time.sleep(.5)
    for event in s.stick.get_events():
        if event.direction == "up":
            light_level -= 1