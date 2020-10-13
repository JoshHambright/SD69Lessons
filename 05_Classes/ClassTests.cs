using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greeter greeter = new Greeter();
            greeter.SayHello("Josh");

            string greeting = greeter.GetRandomGreeting();

            greeting = "Random greeting: " + greeting;
            greeter.SaySomething(greeting);

            greeter.SaySomething(greeter.GetRandomGreeting());
        }

        [TestMethod]
        public void CalculatorTest()
        {
            Calculator calculator = new Calculator();
            int x = 5;
            int y = 3;
            double a = 5.848;
            double b = 3.979;

            Console.WriteLine("Lets Play with the ints: " + x + " and " + y);
            int n = calculator.Add(x, y);
            Console.WriteLine(x + " + " + y + " = " + n);

            Console.WriteLine(x + " - " + y + " = " + calculator.Sub(x,y));
            Console.WriteLine(x + " * " + y + " = " + calculator.Mult(x, y));
            Console.WriteLine(x + " / " + y + " = " + calculator.Div(x, y) + " with a remainder of " + calculator.Remainder(x, y));
            Console.WriteLine(x + " ^ " + y + " = " + calculator.Power(x, y));
            Console.WriteLine("Now lets Play with the doubles: " + a + " and " + b);
            Console.WriteLine(a + " + " + b + " = " + calculator.Add(a, b));
            Console.WriteLine(a + " - " + b + " = " + calculator.Sub(a, b));
            Console.WriteLine(a + " * " + b + " = " + calculator.Mult(a, b));
            Console.WriteLine(a + " / " + b + " = " + calculator.Div(a, b) + " with a remainder of " + calculator.Remainder(a, b));
            Console.WriteLine(a + " ^ " + b + " = " + calculator.Power(a, b));
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "blah";
            vehicle.SetModel("blahblah 2.0");

            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.GetModel());

            vehicle.TurnOn();
            vehicle.TurnOn();
            vehicle.TurnOff();
        }

        [TestMethod]
        public void PersonTest()
        {
            Person josh = new Person("Josh", "Hambright", new DateTime(1984, 11, 12));
            Vehicle car = new Vehicle(VehicleType.Car, "Spark");
            josh.Transport = car;

            Console.WriteLine(josh.FullName);
            Console.WriteLine(josh.Age);
            Console.WriteLine(josh.Transport.TypeOfVehicle);

        }

        [TestMethod]
        public void FizzBuzz(int aNumber)
        {
            int i = 1;
            int isThree;
            int isFive;
            while (i <= aNumber)
            {
                isThree = i % 3;
                isFive = i % 5;
                if (isThree == 0 && isFive == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    i++;
                }
                else if (isThree == 0)
                {
                    Console.WriteLine("Fizz");
                    i++;
                }
                else if (isFive == 0)
                {
                    Console.WriteLine("Buzz");
                    i++;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }
            }


            /*
//1
int number = 100;
int isThree = 1;
int isFive = 1;
//2
for (int i = 1; i <= number; i++) //i is the loop control variable
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
  */
        }
    }
}
