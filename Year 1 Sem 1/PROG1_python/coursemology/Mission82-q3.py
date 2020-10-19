from sense_hat import SenseHat

s = SenseHat()
s.clear()

T = (s.get_temperature() * 9/5) + 32
RH = s.get_humidity()

HI = -42.38 + 2.05*T + 10.14*RH - 0.225*T*RH - 0.007*(T**2) - 0.0548*(RH**2) + 0.00123*(T**2)*RH + 0.00085*T*(RH**2)- 0.000002*(T**2)*(RH**2)

if HI <= 90:
    s.show_message("{}".format(HI), text_colour=[255, 255, 255], back_colour=[0, 255, 0])
elif HI <= 103:
    s.show_message("{}".format(HI), text_colour=[255, 255, 255], back_colour=[255, 255, 0])
elif HI <= 125:
    s.show_message("{}".format(HI), text_colour=[255, 255, 255], back_colour=[255, 165, 0])
else:
    s.show_message("{}".format(HI), text_colour=[255, 255, 255], back_colour=[255, 0, 0])