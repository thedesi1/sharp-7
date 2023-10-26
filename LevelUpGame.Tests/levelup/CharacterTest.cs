using NUnit.Framework;
using levelup;
using System;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;

        [SetUp]
        public void SetUp()
        {
            String testName = "Bob";
            testObj = new Character(testName);
        }

        [Test]
        public void TestCharacterCreate()
        {
            Assert.AreEqual(testObj.Name, "Bob");
        }

         [Test]
        public void TestEnterMap()
        {
            //testObj.EnterMap(GameMap map);
            //Position newPosition = testObj.GetPosition();
        }
    }


}