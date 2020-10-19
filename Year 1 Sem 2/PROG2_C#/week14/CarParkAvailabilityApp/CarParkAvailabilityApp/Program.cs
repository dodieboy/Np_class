/*
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
SPDX-Short-Identifier: MIT
*/
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarParkAvailabilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPark CarParkList;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.data.gov.sg");
                Task<HttpResponseMessage> responseTask = client.GetAsync("/v1/transport/carpark-availability");
                responseTask.Wait();
                HttpResponseMessage result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    string data = readTask.Result;
                    CarParkList = JsonConvert.DeserializeObject<CarPark>(data);
                    foreach (Carpark_Data c in CarParkList.items[0].carpark_data)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", c.carpark_info[0].total_lots, c.carpark_info[0].lot_type, c.carpark_info[0].lots_available, c.carpark_number, c.update_datetime.ToString("dd/MM/yyyy H:mm"));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
