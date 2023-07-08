using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Phil_s_Lending_Library
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Department { get; }
        public int Relasing { get; }
        public int NumberOfPages { get; }
       public  string firstName { get; }  
        public    string lastName { get; }
        public Book(string title, string author, int numberOfPages)
        {
Title = title;
Author = firstName+lastName;
            NumberOfPages = numberOfPages;

        }

    }
}
