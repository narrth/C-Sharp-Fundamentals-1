using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        //static methods can not be instance and must be directly called
        //there is only one in existance unlike objects that have mukltiple existances
        static void Main(string[] args)
        {
            var book = new Book($"Narr's Gradebook");
            book.AddGrade(87.1);
            book.AddGrade(60.7);
            book.AddGrade(90.4);
            book.ShowStatistics();

            /*var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.2);
            //press "crtl" + "." beside and error to see suggestions then selct one
            //list is a unique array with many built in functions, it requires an 
            //addition parameter indicating the type of list in "<" and ">" brackets*/

            

        }
    }
}
