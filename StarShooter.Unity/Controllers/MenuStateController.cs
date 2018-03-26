using StarShooter.Unity.UI;

namespace StarShooter.Unity.Controllers
{
    public class MenuStateController
    {
        private IAppStateManager _appStateManager;

        public MenuStateController(IAppStateManager appStateManager)
        {
            _appStateManager = appStateManager;
        }

        private void SetState(AppState state)
        {
            _appStateManager.CurrentState = state;
        }

        public void SetMainMenu()
        {
            SetState(AppState.MainMenu);
        }

        public void SetGamePause()
        {
            SetState(AppState.GamePause);
        }

        public void SetGameOverState()
        {
            SetState(AppState.GameOver);
        }

        public void SetGameState()
        {
            SetState(AppState.Game);
        }

        public void SetOptionsState()
        {
            SetState(AppState.Options);
        }
    }
}
