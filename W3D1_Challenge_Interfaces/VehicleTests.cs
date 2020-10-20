using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W3D1_Challenge_Interfaces.Vehicles;

namespace W3D1_Challenge_Interfaces
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            SUV tahoe = new SUV();
            tahoe.Make = "Chevy";
            tahoe.Model = "Tahoe";
            Console.WriteLine(tahoe.Start());
            Console.WriteLine(tahoe.Drive());
            Console.WriteLine(tahoe.CloseDoors());
            Console.WriteLine(tahoe.Drive());
            
        }
    }
}
