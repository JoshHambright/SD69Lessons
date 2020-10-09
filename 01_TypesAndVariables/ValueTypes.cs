using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // ThisIsPascalCase
            // thisIsCamelCase
            // this-is-kebab-case
            // this_is_snake_case

            // declare a variable:
            bool IsDeclared;

            // initialize a variable (assign a value)
            IsDeclared = true;



        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char specialCharacter = '\n';
            // CR = Carriage Return
            // LF = Line Feed
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte signedByteExample = 127;
            short shortExample = 32767;
            int intMin = -2147483648;
            Int32 intMax = 2147483647; // Int32 and int are the same
            long longExample = 9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.0438383727292248382727f;
            Console.WriteLine(1.398293282394273094823094820934802982098420938402984f);

            double doubleExample = 1.9483095840980932482309482309842309482309838473928472309d;
            Console.WriteLine(doubleExample);

            decimal decimalExample = 1.459830954809585094598309423094823094823098850938m;
            Console.WriteLine(decimalExample);


        }

        enum PastryType { Cake, Croissant, Cookie, Scone, Danish, Baguette };

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            Console.WriteLine(myPastry);
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(1984, 11, 12);
            Console.WriteLine(birthday);

            TimeSpan age = today - birthday;
            Console.WriteLine(age);
        }
    }
}
