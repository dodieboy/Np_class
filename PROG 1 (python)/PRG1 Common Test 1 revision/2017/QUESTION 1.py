import math

radius_Sphere = float(input("Radius of the sphere: "))
height_Column = float(input("Height of the column: "))
width_Cube = float(input("Width of the cube: "))
surfacearea_Sphere = 4 * math.pi * math.pow(radius_Sphere, 2)
surfacearea_Column = (2 * math.pi * (radius_Sphere/2) * height_Column) + (2 * math.pi * (radius_Sphere/2) ** 2)
surfacearea_Cube = 6 * (width_Cube ** 2)
total_SurfaceArea = surfacearea_Sphere + surfacearea_Column + surfacearea_Cube
print("The total surface area of the Time Capsule is {:.2f}".format(total_SurfaceArea))
