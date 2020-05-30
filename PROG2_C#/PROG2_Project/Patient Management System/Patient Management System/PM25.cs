//============================================================
// Student Number	: S10194833D, S10198161D
// Student Name	: Do Li Fang Sarah, Tan Jia Shun
// Module  Group	: P07 //============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Patient_Management_System
{

    public class Rootobject
    {
        public Api_Info api_info { get; set; }
        public Region_Metadata[] region_metadata { get; set; }
        public Item[] items { get; set; }
    }

    public class Api_Info
    {
        public string status { get; set; }
    }

    public class Region_Metadata
    {
        public string name { get; set; }
        public Label_Location label_location { get; set; }
    }

    public class Label_Location
    {
        public float longitude { get; set; }
        public float latitude { get; set; }
    }

    public class Item
    {
        public DateTime update_timestamp { get; set; }
        public DateTime timestamp { get; set; }
        public Readings readings { get; set; }
    }

    public class Readings
    {
        public Pm25_One_Hourly pm25_one_hourly { get; set; }
    }

    public class Pm25_One_Hourly
    {
        public int national { get; set; }
        public int north { get; set; }
        public int south { get; set; }
        public int east { get; set; }
        public int west { get; set; }
        public int central { get; set; }
    }

}
