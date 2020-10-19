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

namespace BookApp
{
    class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Qty { get; set; }

        public Book() { }

        public override string ToString()
        {
            return "Id: " + Id + "\tIsbn: " + Isbn +
                   "\tTitle: " + Title + "\tAuthor: " + Author +
                   "\tPages: " + Pages + "\tQty: " + Qty+ "\n";
        }
    }
}
