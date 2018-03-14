using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StarShooter.GameManagement;
using StarShooter.GameManagement.Data;
using StarShooter.GameManagement.Loader;

namespace StarShooter.Tests.GameManagementTests
{
    [TestClass]
    public class GameLoaderTest
    {
        private string testSceneName = "test_scene";

        [TestMethod]
        public void GameLoader_LoadGame_NormalLoad()
        {
            GameInfo info = new GameInfo(1, "test_name");

            var bundlesManagerMock = new Mock<IBundlesManager>();
            bundlesManagerMock.Setup(m => m.LoadBundle(info.Id)).Returns(Task.FromResult(new [] {testSceneName}));

            var sceneManagerMock = new Mock<ISceneManager>();

            string loadedSceneName = "";
            sceneManagerMock.Setup(c => c.LoadScene(It.IsAny<string>()))
                .Callback<string>((name) => loadedSceneName = name);

            IGameLoader gameLoader = new GameLoader(sceneManagerMock.Object, bundlesManagerMock.Object);
            gameLoader.LoadGame(info);

            sceneManagerMock.Verify(c => c.LoadScene(It.IsAny<string>()), Times.Once());
            
            Assert.AreEqual(loadedSceneName, testSceneName);
        }
      
    }
}
