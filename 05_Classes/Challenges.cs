using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void MaryPoppins()
        {
            string super = "Supercalifragilisticexpialidocious";
            int letterCount = super.Length;

            for (int i = 0; i < letterCount; i++)
            {
                char currentLetter = super[i];

                if (currentLetter == 'i')
                {

                    Console.WriteLine(currentLetter);
                }
                else if (currentLetter == 'l')
                {
                    Console.WriteLine(currentLetter);

                }
                {
                    Console.WriteLine("Not an I or an L");
                }
            }

            Console.WriteLine(super + " is " + letterCount + " letters long.");
            //while (int i)

        }
    }
}
