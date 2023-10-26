using NUnit.Framework;
using levelup;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
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
        public void getnumPositionIsNotNull()
        {
            //Assert
            Assert.IsNotNull(testObj.numPosition);

        }

        [Test]
        public void getPositionsIsNotNull()
        {
            
            //Act
            var test = testObj.getPositions();

            //Assert
            Assert.IsNotNull(test);

        }


        [Test]
        public void getTotalPositions()
        {
            //Assert
            Assert.IsNotNull(null);

        }


    }
}
