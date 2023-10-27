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


        
    }
}