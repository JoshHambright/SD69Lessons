using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals
{
    public class Sloth : Animal

    {
        public bool IsSlow
        {
            get {return true;}
        }

        public Sloth()
        {
            Console.WriteLine("Sloth Constructor");
        }

        public override void SayFurColor()
        {
            Console.WriteLine("My fur is brown.");
        }

    }
}
