using System;
using System.Collections.Generic;
using Inheritance.Animals;
using Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            Person me = new Person();
            me.FirstName = "Andrew";
            me.LastName = "Gorg";
            Console.WriteLine(me.Name);

            Employee dwight = new Employee(12345);
            dwight.FirstName = "Dwight";
            dwight.LastName = "Schrute";
            Console.WriteLine(dwight.Name);
            Console.WriteLine(dwight.EmployeeNumber);

            SalaryEmployee jim = new SalaryEmployee(12333, 600000);
            jim.FirstName = "Jim";
            Console.WriteLine(jim.FirstName);
            Console.WriteLine(jim.EmployeeNumber);
            Console.WriteLine(jim.Salary);
        }

        [TestMethod]
        public void AnimalTests()
        {
           // Animal animal = new Animal();
           Sloth sloth = new Sloth();
            Console.WriteLine(sloth.IsSlow);
            sloth.Move();
            sloth.HasFur = true;
            Console.WriteLine(sloth.HasFur);

            sloth.SayFurColor();
            Frog frog = new Frog();
            Console.WriteLine(frog.CanJump);
            Console.WriteLine(frog.HasFur);
            frog.frogColor = FrogColor.Green;
            Console.WriteLine(frog.frogColor);
        }
    }
}
