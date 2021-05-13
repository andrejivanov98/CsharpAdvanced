using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }


        public Fish(string name, int age, string color, int size) : base(name, TypeEnum.Fish, age)
        {
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"My name is {Name} and I am a {TypeEnum.Fish}.";
        }
    }
}
