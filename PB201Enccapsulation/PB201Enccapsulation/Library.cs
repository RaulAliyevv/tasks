using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PB201Enccapsulation
{
    public class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book book) 
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length-1] = book;
        }

        public Book[] GetFilteredBooks(string genreName) 
        {
            Book[] filteredBooks = Array.Empty<Book>();

            foreach (var book in Books) 
            {
                if (book.Genre.ToLower() == genreName.ToLower()) 
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length -1] = book;

                }
            }

            return filteredBooks;

        }
    }
}
