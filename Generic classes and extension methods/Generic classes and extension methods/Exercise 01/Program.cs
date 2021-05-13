using System;
using Models;
using System.Collections.Generic;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogsStore = new PetStore<Dog>();
            PetStore<Cat> catsStore = new PetStore<Cat>();
            PetStore<Fish> fishStore = new PetStore<Fish>();


            dogsStore.Insert(new Dog("Bobs", 3, true, "meat"));
            dogsStore.Insert(new Dog("Jacky", 5, false, "bread"));

            catsStore.Insert(new Cat("Jenny", 2, false, 6));
            catsStore.Insert(new Cat("Jane", 4, true, 3));

            fishStore.Insert(new Fish("Nemo", 1, "blue", 4));
            fishStore.Insert(new Fish("Mui", 2, "green", 7));


            dogsStore.BuyPet("Bobs");
            catsStore.BuyPet("Mia");

            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("These are the available pets in the stores:");
            dogsStore.PrintPets();
            catsStore.PrintPets();
            fishStore.PrintPets();
            

            
        }
    }
}
