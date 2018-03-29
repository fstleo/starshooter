using System.Threading.Tasks;
using StarShooter.GameManagement;
using StarShooter.GameManagement.Data;
using StarShooter.Unity.UI;

namespace StarShooter.Unity.Controllers.MainMenu
{
    internal class MainMenuController : IMainMenuController
    {
        
        private readonly IGameLoader _gameLoader;
        private readonly IAppStateManager _appStateManager;

        public MainMenuController(IAppStateManager appStateManager, IGameLoader gameLoader)
        {
            _appStateManager = appStateManager;
            _gameLoader = gameLoader;
        }

        public void ShowOptions()
        {
            _appStateManager.CurrentState = AppState.Options;
        }

        public async Task PlayGame()
        {
            _appStateManager.CurrentState = AppState.Loading;
            await _gameLoader.LoadGame(new GameInfo(0, ""));
            _appStateManager.CurrentState = AppState.Game;
        }
    }
}
