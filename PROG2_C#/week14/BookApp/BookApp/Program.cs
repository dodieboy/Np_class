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

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ictonejourney.com");
                Task<HttpResponseMessage> responseTask = client.GetAsync("/api/books");
                responseTask.Wait();
                HttpResponseMessage result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    string data = readTask.Result;
                    bookList = JsonConvert.DeserializeObject<List<Book>>(data);
                    foreach (Book b in bookList)
                    {
                        Console.WriteLine("{0,2}  {1,13}  {2,-65}  {3,-20}  {4,4}  {5,3}",
                                           b.Id, b.Isbn, b.Title, b.Author, b.Pages, b.Qty);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
