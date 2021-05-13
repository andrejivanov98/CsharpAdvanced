using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, int age, bool goodBoi, string favoriteFood) : base(name, TypeEnum.Dog, age)
        {
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override string PrintInfo()
        {
            return $"My name is {Name} and I am a {TypeEnum.Dog}.";
        }
    }
}
