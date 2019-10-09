using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    class Book
    {
        //constructor methods are completed in methods with names matching the class
        //constructor methods are used to allocate memory for variables, but do not create the variables yet
        public Book(string name)    //the brackets "name" allow us to pass a variable in the form string to the method
        {

            grades = new List<double>();
            this.name = name;
        }

        //"new" is not needed for non-object type variables
        //"this." allows us to reffer directly to a member of the class instead of the string"name" with the same name

        public void AddGrade(double grade)
        {
            grades.Add(grade); 
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            //var is a blank type variable , the console will recognize what type I need


            foreach (var number in grades) //can use array(numbers) or list(grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($" The lowest grade is {lowestGrade:N1}");
            Console.WriteLine($" The highest grade is {highGrade:N1}");
            Console.WriteLine($" The average is {result:N1}");
            //"$" is used for odd string outputs
            //":N#" allows us to format numbers with the desired truncation
        }

        private List<double> grades;
        private string name;
    }

}
