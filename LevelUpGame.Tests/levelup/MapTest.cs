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
        public void IsGameResultInitialized()
        {
            //Arrange
            Point test = new();
            //Act

            //Assert
            Assert.IsNotNull(testObj.isPositionValid(test));
        }

        
    }
}