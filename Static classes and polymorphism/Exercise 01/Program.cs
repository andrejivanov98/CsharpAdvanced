using System;
using Models;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dogs validation:");
            Dog.Validate(DogsShelter.Dogs[0]);
            Dog.Validate(DogsShelter.Dogs[1]);
            Dog.Validate(DogsShelter.Dogs[2]);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("These are the dogs:");
            DogsShelter.PrintAll(DogsShelter.Dogs);






        }
    }
}
