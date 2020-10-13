using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class Examples
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //Write a method that takes in a number and a string, and returns a combined result
        public string GuineaPigs(string name, int num)
        {
            // string combined = $"Hi I'm {name} and I have {num} guinea pigs";
            // return combined;
            return "Hi I'm " + name + " and I have " + num + " guinea pigs";
           
        }

        // Write a method that takes a number and writes to the console if its odd or even

        public void isEven(int num)
        {
            int remainder = num % 2;
            if (remainder == 0)
            {
                Console.WriteLine("Number is Even!");
            }
            else
            {
                Console.WriteLine("Number is ODD!");
            }
        }
        
        public enum Flavor { Vanilla, Chocolate, Skunks, Strawberry, Pistachio, Sewage,Bubblegum};
        //Switch Case 
        //Ice cream flavor return if I like it or not
        public bool DoesAndrewLikeTheIceCreamFlavor(Flavor flav)
        {
            switch (flav)
            {
                case Flavor.Vanilla:
                case Flavor.Strawberry:
                case Flavor.Chocolate:
                case Flavor.Pistachio:
                    return true;
                case Flavor.Sewage:
                case Flavor.Skunks:
                case Flavor.Bubblegum:
                    return false;
                default:  // Needs a default in case there is another case or a null
                    return false;

            }
        }


    }
}
