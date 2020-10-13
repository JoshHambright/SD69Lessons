using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UserClassTests()
        {
            User josh = new User("Josh", "Hambright", new DateTime(1984, 11, 12), 666);
            Console.WriteLine(josh.AgeInYears);
            Console.WriteLine(josh.FullName);
            Console.WriteLine("User ID: " + josh.UserID);
        }
    }


}
