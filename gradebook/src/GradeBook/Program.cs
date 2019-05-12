using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Pavlo's Grade Book");
            book.AddGrade(13.6);
            book.AddGrade(3.14);
            book.AddGrade(56.9);
            book.ShowStatistics();
        }
    }
}
