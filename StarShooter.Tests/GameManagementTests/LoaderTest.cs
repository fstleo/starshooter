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
using UnityEngine;

namespace StarShooter.Tests.GameManagementTests
{
    [TestClass]
    public class LoaderTest
    {
        private string testSceneName = "test_scene";

        [TestMethod]
        public void LoadSceneTest()
        {
            GameInfo info = new GameInfo(1, "test_name");

            var bundlesManagerMock = new Mock<IBundlesManager>();
            bundlesManagerMock.Setup(m => m.LoadBundle(info.Id)).Returns(Task.FromResult(new [] {testSceneName}));

            var sceneManagerMock = new Mock<ISceneManager>();

            string calledSceneName = "";
            sceneManagerMock.Setup(c => c.LoadScene(It.IsAny<string>()))
                .Callback<string>((name) => calledSceneName = name);

            IGameLoader gameLoader = new GameLoader(sceneManagerMock.Object, bundlesManagerMock.Object);
            gameLoader.LoadGame(info);

            sceneManagerMock.Verify(c => c.LoadScene(It.IsAny<string>()), Times.Once());
            
            Assert.AreEqual(calledSceneName, testSceneName);
        }
    }
}
