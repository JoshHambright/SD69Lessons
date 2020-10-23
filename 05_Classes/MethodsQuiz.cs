using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class MethodsQuiz
    {

        public double Divider(int a, int b)
        {
            double quotient = a / b;
            return quotient;
        }

        public void Greeter(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public int StringParser(string aString)
        {
            return Int32.Parse(aString);
        }

        public void Age(DateTime birthDate)
        {
            TimeSpan ageSpan = DateTime.Now - birthDate;
            double totalAgeInYears = ageSpan.TotalDays / 365.241;
            Console.WriteLine(Convert.ToInt32(Math.Floor(totalAgeInYears)));

        }

        public void FizzBang(int number)
        {
            int isThree = 1;
            int isFive = 1;
            for (int i = 1; i <= number; i++)
            {
                isThree = i % 3;
                isFive = i % 5;
                if ((isThree == 0) && (isFive == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    i = i + 1;
                }
                else if (isThree == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (isFive == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public double Largest(double a, double b)
        {
            if(a > b)
            {
                return a;
            }
            else { return b; }
        }
    }
}
