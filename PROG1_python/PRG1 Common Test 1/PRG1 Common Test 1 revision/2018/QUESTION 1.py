timing = input("Enter timing taken of 3 rounds separated by \';\'(seconds): ")
timing_list = timing.split(';')
speed_in_km_per_hr = 1.2 /((int(timing_list[0]) + int(timing_list[1]) + int(timing_list[2])) / (60*60))
print("Tom's average speed is {:.1f} km/h".format(speed_in_km_per_hr))
first_round_min = int(timing_list[0]) // 60
first_round_sec = int(timing_list[0]) % 60
print('Tom took {} min and {} seconds for the first round'.format(first_round_min,first_round_sec))