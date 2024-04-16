using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }


        public static int Count = 1;

        public int Id { get; set; }
       
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            Id = Count++;
        }

    }
}