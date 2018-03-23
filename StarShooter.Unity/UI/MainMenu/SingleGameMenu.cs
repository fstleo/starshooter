using StarShooter.Unity.Controllers.MainMenu;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.UI.MainMenu
{
    public class SingleGameMenu : MonoBehaviour
    {
        [Inject] private IMainMenuController _mainMenuController;

        public void OnOptionButtonClick()
        {
            _mainMenuController.ShowOptions();
        }

        public void OnPlayButtonClick()
        {
            _mainMenuController.PlayGame();
        }
    }
}
