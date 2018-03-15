using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StarShooter.GameManagement.Data;
using System.Threading.Tasks;
using StarShooter.GameManagement.Selection;

namespace StarShooter.Tests.GameManagementTests
{
    [TestClass]
    public class GamesListTest
    {
        [TestMethod]
        public void GamesList_GetList_SuccessGet()
        {
            GameInfo[] infos = new[]
            {
                new GameInfo(0, "test_game0"),
                new GameInfo(1, "test_game1"),
                new GameInfo(2, "test_game2")
            };

            var gamesListSource = new Mock<IGamesListSource>();
            gamesListSource.Setup(list => list.GetGamesList()).Returns(Task.FromResult(infos));

            var gamesList = gamesListSource.Object.GetGamesList().Result;
            Assert.AreEqual(gamesList.Length, infos.Length);

        }
    }
}
