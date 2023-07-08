using Lab08_Phil_s_Lending_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Phil_s_Lending_Library
{


    public class Library : ILibrary
    {
        private Dictionary<string, Book> books;

        public Library()
        {
            books = new Dictionary<string, Book>();
        }

        public int Count => books.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            string author = $"{firstName} {lastName}";
            Book book = new Book( title, author , numberOfPages);
            books[title] = book;
        }

        public Book Borrow(string title)
        {
            if (books.ContainsKey(title))
            {
                Book book = books[title];
                books.Remove(title);
                return book;
            }

            return null;
        }

        public void Return(Book book)
        {
            books[book.Title] = book;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
