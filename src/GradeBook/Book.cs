
using System.Collections.Generic;

namespace GradeBook
{
    class Book  //if u donot specify an access modifier, it would be given that of internal
//meaning that the Book class can only be used in this same project
    {
        public Book(string name) //public is called access modifiers
        //meaning code outside this class can asses the book
        {
            grades = new List<double>();
            Name = name;
        }
          public void AddGrade(double grade) //this is an instance member/method of a class Book
        {
            grades.Add(grade); //on this object, go tothe grades field and add a newgrade
        }


        //encapsulation and abstraction

             //returns an object with the type statistics
            public Statistics GetStatistics()  //we use that class identifier here. The return type or object it would return is statistics
            //it could have returned double,int, List<double>
            {

            var result =  new Statistics();
            result.Average = 0.0;
            // var highGrade = double.MinValue;
            result.High = double.MinValue;
            //   var lowGrade = double.MaxValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                // if(number >  highGrade) {
                //     highGrade = number;
                // }
                result.low=Math.Min(grade, result.low);
                result.High  = Math.Max(grade, result.High);
                result.Average += grade;

            }
               result.Average /= grades.Count;

                  return result;


            }

        //instance fields associated with class book
         private List<double> grades; // we cannot use implicit typing here like var.It is a field
         public string Name; //public member has an uppercase name
    }
}
