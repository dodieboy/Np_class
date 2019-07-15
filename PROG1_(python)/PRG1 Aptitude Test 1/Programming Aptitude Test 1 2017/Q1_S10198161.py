speed = float(input('Enter aeroplane speed: '))
acceleration = float(input('Enter aeroplane acceleration: '))

length = (speed**2)/(2*acceleration)
print('The minimum runway length is '+ str(length))