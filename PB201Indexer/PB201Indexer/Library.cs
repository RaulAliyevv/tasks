using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Indexer
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get
            {
                return books[index];
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            return books.FindAll(book => book.Name.Contains(value));
        }

        public Book FindBookByCode(string code)
        {
            return books.Find(book => book.Code == code);
        }

        public void RemoveAllBooksByName(string value)
        {
            books.RemoveAll(book => book.Name.Contains(value));
        }

        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(book =>
                book.Name.Contains(value) ||
                book.AuthorName.Contains(value) ||
                book.PageCount.ToString().Contains(value)
            );
        }

        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            return books.FindAll(book => book.PageCount >= minPageCount && book.PageCount <= maxPageCount);
        }

        public void RemoveBookByCode(string code)
        {
            books.RemoveAll(book => book.Code == code);
        }
    }
}

