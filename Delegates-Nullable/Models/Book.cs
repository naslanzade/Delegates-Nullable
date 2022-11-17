using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_Nullable.Models
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }

        public Book(string bookname,string bookauthor)
        {
            BookName = bookname;
            BookAuthor = bookauthor;
        }


    }



    
}
