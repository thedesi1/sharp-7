using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? gameControllerToTest;

        [SetUp]
        public void SetUp()
        {
            gameControllerToTest = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(gameControllerToTest.GetStatus());
        }

        [Test]
        public void CreateCharacterInitsChar()
        {
            gameControllerToTest.CreateCharacter("ARBITRARY NAME");
            Assert.AreEqual("ARBITRARY NAME", gameControllerToTest.character.Name);
            Assert.AreEqual("ARBITRARY NAME", gameControllerToTest.GetStatus().characterName);
        }

         [Test]
        public void StartGameCreatesMap()
        {
            gameControllerToTest.StartGame();
            Assert.NotNull(gameControllerToTest.gameMap);
        }

        [Test]
        public void StartGameEntersMapAndUpdatesStatus() 
        {
            FakeGameMap fakeMap = new FakeGameMap();
            gameControllerToTest.gameMap = fakeMap;
            gameControllerToTest.StartGame();
            Assert.AreEqual(fakeMap.startingPosition.x, gameControllerToTest.GetStatus().currentPosition.x);
            Assert.AreEqual(fakeMap.startingPosition.y, gameControllerToTest.GetStatus().currentPosition.y);
        }
        
        [Test]
        public void MoveDelegatesToCharacter()
        {
            MockCharacter mockChar = new MockCharacter("");
            gameControllerToTest.character = mockChar;
            gameControllerToTest.Move(GameController.DIRECTION.EAST);
            mockChar = (MockCharacter) gameControllerToTest.character;
            Assert.AreEqual(GameController.DIRECTION.EAST, mockChar.lastDirectionCalled);
            Assert.AreEqual(1, mockChar.timesCalled);
        }

        [Test]
        public void MoveUpdatesStatus()
        {
            MockCharacter mockChar = new MockCharacter("");
            gameControllerToTest.character = mockChar;
            gameControllerToTest.Move(GameController.DIRECTION.WEST);
            mockChar = (MockCharacter)gameControllerToTest.character;
            Assert.AreEqual(mockChar.Position, gameControllerToTest.GetStatus().currentPosition);
            Assert.AreEqual(mockChar.moveCount, gameControllerToTest.GetStatus().moveCount);
        }
    }
}