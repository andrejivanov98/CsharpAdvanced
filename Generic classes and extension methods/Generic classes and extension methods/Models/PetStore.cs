using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class  PetStore<T> where T : Pet
    {
        public List<T> Pets;

        public PetStore()
        {
            Pets = new List<T>();
        }



        public void PrintPets() 
        {
            foreach(T pet in Pets)
            {
                
                Console.WriteLine($"{pet.PrintInfo()}");
            }
        }

        public void Insert(T item)
        {
            Pets.Add(item);
            
        }

        public void BuyPet(string name)
        {
            T boughtPet = Pets.FirstOrDefault(x => x.Name == name);
            if(boughtPet == null)
            {
                Console.WriteLine($"There is no such a pet with that name.");
            }
            else
            {
                Pets.Remove(boughtPet);
                Console.WriteLine($"The {boughtPet.Type} {boughtPet.Name} is yours now.");
            }
        }

    }
}
