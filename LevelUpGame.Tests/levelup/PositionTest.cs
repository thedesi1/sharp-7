using NUnit.Framework;
using levelup;
using System;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            int xCoordinate = 0;
            int yCoordinate = 0;

            testObj = new Position(xCoordinate, yCoordinate);
        }

        [Test]
        public void TestPositionCreate()
        {
         //   Assert.AreEqual(testObj.coordinates.X, 0);
          //  Assert.AreEqual(testObj.coordinates.Y, 0);
        }
    }
}