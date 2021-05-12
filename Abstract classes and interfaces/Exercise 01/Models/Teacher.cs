using System;
using Exercise_01.Interfaces;

namespace Exercise_01.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher()
        {

        }

        public Teacher(int id, string name, string username, string password, string subject) : base(id, name, username, password)
        {
            Subject = subject;
        }

        public void PrintUser(string subject)
        {
            Console.WriteLine($"The teacher {Name} is teaching the subject {subject}.");
        }
    }
}
