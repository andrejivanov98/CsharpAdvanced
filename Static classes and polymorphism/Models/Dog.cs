using System;

namespace Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static void Validate(Dog dog)
        {
            if(dog.Id == 0 || dog.Name == null || dog.Color == null )
            {
                Console.WriteLine("You do not have all parameters.");
            }
            else if(dog.Id < 0 || dog.Name.Length < 2)
            {
                Console.WriteLine("Your ID or Name is not correct.");
            }
            else
            {
                Console.WriteLine($"Everything is fine with you {dog.Name}. Welcome.");
            }

        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public Dog()
        {

        }
    }
}
