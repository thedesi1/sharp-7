using System.Xml.Serialization;
using levelup;
using NUnit.Framework;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? characterBeingTested;
        string arbitraryName = "Arbitrary Name";

        [SetUp]
        public void SetUp()
        {
            characterBeingTested = new Character(arbitraryName);
        }

        [Test]
        public void CharacterHasNameAndMoveCountWhenInitialized()
        {
            int moveCountWhenCaracterIsCreated = 0;
            Assert.AreEqual(characterBeingTested.Name, arbitraryName);
            Assert.AreEqual(moveCountWhenCaracterIsCreated, characterBeingTested.moveCount);
        }

        [Test]
        public void CharacterHasNewPositionOnEnterMap()
        {
            FakeGameMap m = new FakeGameMap();
            characterBeingTested.EnterMap(m);
            Assert.AreEqual(m.startingPosition, characterBeingTested.Position);
            Assert.AreEqual(m, characterBeingTested.gameMap);
        }

        [Test]
        public void CharacterHasNewPositionOnMove()
        {
            FakeGameMap m = new FakeGameMap();
            characterBeingTested.gameMap = m;
            characterBeingTested.Move(GameController.DIRECTION.NORTH);
            Assert.AreEqual(m.stubbedPosition, characterBeingTested.Position);
        }

        [Test]
        public void CharacterIncrementsMoveCountOnMove()
        {
            characterBeingTested.gameMap = new FakeGameMap();
            characterBeingTested.Move(GameController.DIRECTION.SOUTH);
            Assert.AreEqual(1, characterBeingTested.moveCount);
        }
        
    }
}