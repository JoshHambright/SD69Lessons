using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals
{
    public enum FrogColor { Green = 1, Yellow, Orange, Blue }
    public class Frog : Animal
    {
        public FrogColor frogColor { get; set;}
        public bool CanJump { get { return true; }  }
        public Frog()
        {
            Console.WriteLine("This is a frog Constructor!");
            HasFur = false;
            NumberOfLegs = 4;
        }
    }
}
