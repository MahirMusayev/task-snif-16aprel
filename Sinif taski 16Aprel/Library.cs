using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal class Library
    {
        Book[] books = new Book[0];
        public void AddBook(Book book)
        {

            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }

        public Book this[int Id]
        {
            get
            {
                foreach (Book book in books)
                {
                    if (book.Id == Id) return book;
                }
                return null;
            }
        
        
        }
    }
}