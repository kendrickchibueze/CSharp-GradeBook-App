// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace GradeBook // Note: actual namespace depends on the project name.
{


    internal class Program
    {
        static void Main(string[] args) //static members/method like Main are not associated with object instance
         //they are only associated with the type that they are defined  inside of
        {


            var book = new Book("kendrick's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

             var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");



        }
    }
}