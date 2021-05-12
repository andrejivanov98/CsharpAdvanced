using System;
using System.Collections.Generic;
using Exercise_01.Interfaces;


namespace Exercise_01.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string username, string password, List<int>grades) : base(id, name, username, password)
        {
            Grades = grades;
        }

        public void PrintUser(List<int> grades)
        {
            foreach(int grade in grades)
            {
                Console.WriteLine($"{grade}");
            }
        }
    }
}
