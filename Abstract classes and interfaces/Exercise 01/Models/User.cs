using Exercise_01.Interfaces;
using System;

namespace Exercise_01.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public void PrintUser(int Id, string name, string username)
        {
            Console.WriteLine($"User ID is: {Id}. Users name is: {name}. Users username is: {username}.");
        }

    }
}
