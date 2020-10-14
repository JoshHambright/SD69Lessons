using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals
{
    public class Frog : Animal
    {
        public bool canJump { get { return true; }  }
        public Frog()
        {
            Console.WriteLine("This is a frog Constructor!");
        }
    }
}
