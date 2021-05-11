using System;

namespace Models
{
    public class Human
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; private set; }
        public Human (string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
           

        }

        public Human Login(string username, string password)
        {
            if (Username != username)
            {
                return null;
            }


            if (Password != password)
            {
                throw new Exception("Wrong password");
            }

            return this;
        }

        public void Logoff()
        {
            Console.Clear();
        }


    }
}
