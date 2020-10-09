using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Josh";
            string lastName = "Hambright";

            // concatenation
            string concatenatedFullName = firstName + " " + lastName;
            
            Console.WriteLine(concatenatedFullName);

            // compositing
            string compositeName = string.Format("my name is {0} {1} {2}", firstName, lastName, " Hello World!");
            Console.WriteLine(compositeName);

            // interpolation
            string interpolatedName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedName);
        }

        [TestMethod]
        public void Classes()
        {
            Random randy = new Random(); //Randy is now an object of type/class Random
            int randomNumber = randy.Next(1, 11); //random interget between 1 and 10
            Console.WriteLine(randomNumber);
            int otherRandomNumber = randy.Next(1, 11); //random interget between 1 and 10
            Console.WriteLine(otherRandomNumber);

        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";
            // [] defines an array
            string[] stringArray = { "Hello", "world!", "Why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2]; // counting starts at 0
            Console.WriteLine(thirdItem);

            stringArray[0] = "Hello there";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("hello");

            List<int> listOfInts = new List<int>();
            listOfInts.Add(456);

            int firstInt = listOfInts[0];

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next!");
            string firstItem = firstInFirstOut.Dequeue();
            string nextItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(nextItem);

            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
            keyAndValue.Add("name", "Josh");

            string name = keyAndValue["name"];
            Console.WriteLine(name);

            Dictionary<string, double> imporantNumbers = new Dictionary<string, double>();
            imporantNumbers.Add("pi", 3.14159);
            imporantNumbers.Add("e", 2.57);


            // SortedList
            // HashSet
            // Stack

        }
    }
}
