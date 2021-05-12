using System;
using System.Collections.Generic;



namespace Models
{
    public static class DogsShelter
    {
        public static List<Dog> Dogs = new List<Dog>()
        {
                new Dog(1, "Charlie", "Black"),
                new Dog(2, "Buddy", "Brown"),
                new Dog(3, "Max", "Olive"),
        };

                public static void PrintAll(List<Dog> dogs)
                {
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"This is the dog {dog.Name} with color {dog.Color} and with ID number: {dog.Id}.");
            }
                }
    };
    }




 