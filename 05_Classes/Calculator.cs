using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        // Add
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        // Overloading = making more than one version of a method
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        // Challenge:

        //Subtract
        public int Sub(int numOne, int numTwo)
        {
            int diff = numOne - numTwo;
            return diff;
        }
        public double Sub(double numOne, double numTwo)
        {
            double diff = numOne - numTwo;
            return diff;
        }

        // Multiply
        public int Mult(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }
        public double Mult(double numOne, double numTwo)
        {
            double product = numOne * numTwo;
            return product;
        }

    // Divide
        public int Div(int numOne, int numTwo)
        {
            int dividend = numOne / numTwo;
            return dividend;
        }

        public double Div(double numOne, double numTwo)
        {
            double dividend = numOne / numTwo;
            return dividend;
        }

        //Power/Exponent (x^y)
        public int Power(int numOne, int numTwo)
        {
            int result = numOne;
            for (int i = 1; i < numTwo; i++)
            {
                result *= numOne;
            }
            return result;
        }

        public double Power(double numOne, double numTwo)
        {
            double result = numOne;
            for (int i = 1; i < numTwo; i++)
            {
                result *= numOne;
            }
            return result;
        }

        // Calculate Remainder

        public int Remainder(int numOne, int numTwo)
        {
            int rem = numOne % numTwo;
            return rem;
        }
        public double Remainder(double numOne, double numTwo)
        {
            double rem = numOne % numTwo;
            return rem;
        }
    }
}
