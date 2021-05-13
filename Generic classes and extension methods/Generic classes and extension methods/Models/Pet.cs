using System;

namespace Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public TypeEnum Type { get; set; }
        public int Age { get; set; }

        public Pet()
        {

        }

        public Pet(string name, TypeEnum type, int age)
        {
            Name = name;
            Type = type;
            Age = age;

        }

        public abstract string PrintInfo();
        
    }
}
