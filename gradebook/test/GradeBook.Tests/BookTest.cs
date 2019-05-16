using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            var book = new Book("");
            book.AddGrade(9.5);
            book.AddGrade(4.23);

            book.ShowStatistics();
        }
    }
}
