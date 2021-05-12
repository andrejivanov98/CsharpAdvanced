using System;
using Exercise_01.Interfaces;
using Exercise_01.Models;
using System.Collections.Generic;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there.");

            Student firstStudent = new Student(1, "Andrej", "andrejivanov", "pass123", new List<int>() { 4, 4, 5, 2, 3 });
            Student secondStudent = new Student(2, "Filip", "filippetrov", "pass456", new List<int>() { 5, 5, 1, 2, 3 });

            Teacher firstTeacher = new Teacher(3, "Risto", "ristopanchevski", "password", "Csharp");
            Teacher secondTeacher = new Teacher(4, "Radmila", "radmilakochovska", "password1", "CsharpAdvanced");

            Console.Write("These are students grades: \n");
            firstStudent.PrintUser(new List<int>() { 4, 4, 5, 2, 3 });
            secondStudent.PrintUser(new List<int>() { 5, 5, 1, 2, 3 });

            Console.WriteLine("These are teachers subjects: ");
            firstTeacher.PrintUser(firstTeacher.Subject);
            secondTeacher.PrintUser(secondTeacher.Subject);




        }
    }
}
