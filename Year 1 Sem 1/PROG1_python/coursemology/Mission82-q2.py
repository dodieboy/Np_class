from sense_hat import SenseHat

s = SenseHat()
s.clear()
s.low_light = True

#color code
green = (0, 255, 0)
blue = (0, 0, 255)
nothing = (0,0,0)

col = 1 #1 to 8 only
row = 7 #0 to 7 only

def cross():
    G = green
    B = blue
    X = nothing

    outputs = [
    X, X, X, X, X, X, X, X,
    X, B, X, X, X, X, B, X,
    X, X, B, X, X, B, X, X,
    X, X, X, B, B, X, X, X,
    X, X, X, B, B, X, X, X,
    X, X, B, X, X, B, X, X,
    X, B, X, X, X, X, B, X,
    X, X, X, X, X, X, X, X
    ]

    s.set_pixels(outputs)

    return

def tick():
    G = green
    B = blue
    X = nothing

    outputs = [
    X, X, X, X, X, X, X, X,
    X, X, X, X, X, X, X, G,
    X, X, X, X, X, X, G, X,
    X, X, X, X, X, G, X, X,
    G, X, X, X, G, X, X, X,
    X, G, X, G, X, X, X, X,
    X, X, G, X, X, X, X, X,
    X, X, X, X, X, X, X, X
    ]

    s.set_pixels(outputs)
    
    return


inputs = int(input("Please key in an integer number: "))

five = False
six = False

if inputs % 5 == 0:
    five = True
if inputs % 6 == 0:
    six = True
if five == True and six == True:
    print("{} is divisible by 5 and 6".format(inputs))
    tick()
else:
    print("{} is not divisible by 5 and 6".format(inputs))
    cross()