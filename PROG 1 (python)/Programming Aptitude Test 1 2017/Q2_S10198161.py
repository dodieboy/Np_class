volume = float(input('Enter the volume of fuel (litres): '))

dieselCarbon = 2.6391 * volume
pertolCarbon = 2.3035 * volume

print('The diesel produce ' + "{:.2f}".format(dieselCarbon) + ' kg of carbon dioxide')
print('The petrol produce ' + "{:.2f}".format(pertolCarbon) + ' kg of carbon dioxide')