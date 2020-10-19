/*
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
SPDX-Short-Identifier: MIT
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkAvailabilityApp
{

    public class CarPark
    {
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public DateTime timestamp { get; set; }
        public List<Carpark_Data> carpark_data { get; set; }
    }

    public class Carpark_Data
    {
        public List<Carpark_Info> carpark_info { get; set; }
        public string carpark_number { get; set; }
        public DateTime update_datetime { get; set; }
    }

    public class Carpark_Info
    {
        public string total_lots { get; set; }
        public string lot_type { get; set; }
        public string lots_available { get; set; }
    }

}
