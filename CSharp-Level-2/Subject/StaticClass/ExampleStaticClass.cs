﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.StaticClass
{
    class ExampleStaticClass
    {

    }

    class Book
    {
        public string Title { get; set; }

        public double Price { get; set; }
    }
    
    static class BookComparer
    {
        public static bool IsBookTitleEqual(Book book1, Book book2)
        {
            if (book1.Title == book2.Title)
                return true;
            else
                return false;
        }

        public static bool IsBookPriceEqual(Book book1, Book book2)
        {
            if (book1.Price == book2.Price)
                return true;
            else
                return false;
        }
    }
}