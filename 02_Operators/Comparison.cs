using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 35;
            string name = "Josh";
            bool isForty = age == 40;
            bool isAndrew = name.ToLower() == "andrew";

            Console.WriteLine("Am I exactly 40? " + isForty + " is my name Andrew? " + isAndrew);

            bool isNotEighteen = age != 18;

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;

            Console.WriteLine(listsAreEqual);

            bool isOverOneHundred = age > 100;

            bool trueValue = true;
            bool falseValue = false;
            
            bool andValue = trueValue && falseValue;
            bool orValue = trueValue || falseValue;

            bool isFive = 5 == Int32.Parse("5");

            // Arithmetic

            int remainder = 10 % 3;
            Console.WriteLine(remainder);

        }
    }
}
