using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void RoomTester()
        {
            Room testRoom = new Room(10,11,12);
            testRoom.roomLength = 10;
            testRoom.roomWidth = 11;
            testRoom.roomHeight = 12;
            Console.WriteLine(testRoom.roomLength);
            Console.WriteLine(testRoom.roomWidth);
            Console.WriteLine(testRoom.roomHeight);
            Console.WriteLine(testRoom.GetRoomArea);
        }
    }
}
