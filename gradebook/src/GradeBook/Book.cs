using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

        private List<double> grades;

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach(var number in grades){
                highGrade = Math.Max(number,highGrade);
                lowestGrade = Math.Min(number,lowestGrade);
                result += number;
            }
            result /= grades.Count; 
            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }

        private string name;
    }
}