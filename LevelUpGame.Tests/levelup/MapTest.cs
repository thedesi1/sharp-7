using NUnit.Framework;
using levelup;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private Map? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Map();
        }

        [Test]
        public void IsPositionValid()
        {
            //Arrange
            Point test = new();
            //Act

            //Assert
            Assert.IsNotNull(testObj.isPositionValid(test));
        }

        [Test]
        public void getPositions()
    {
            //Assert
            Assert.IsNotNull(testObj.numPosition);

    }}
}