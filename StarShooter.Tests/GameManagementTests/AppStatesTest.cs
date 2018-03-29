using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarShooter.GameManagement;
using StarShooter.GameManagement.AppStateControl;

namespace StarShooter.Tests.AppStates
{
    [TestClass]
    public class AppStateManagerTest
    {
        IAppStateManager appStateManager;

        [TestInitialize]
        public void Init()
        {
            appStateManager = new AppStatesController();
        }

        [TestMethod]
        public void AppStateManager_ChangeState_StateChanged()
        {
            Assert.AreEqual(appStateManager.CurrentState, AppState.Preload);
            appStateManager.CurrentState = AppState.MainMenu;
            Assert.AreEqual(appStateManager.CurrentState, AppState.MainMenu);
        }

        [TestMethod]
        public void AppStateManager_ChangeState_EventFired()
        {
            AppState appState = AppState.GameOver;            
            appStateManager.OnStateChange += (state) => appState = state;
            appStateManager.CurrentState = AppState.MainMenu;
            Assert.AreEqual(appState, appStateManager.CurrentState);
        }
    }
}
