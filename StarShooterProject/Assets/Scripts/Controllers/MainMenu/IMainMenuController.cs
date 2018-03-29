using System.Threading.Tasks;

namespace StarShooter.Unity.Controllers.MainMenu
{
    internal interface IMainMenuController
    {
        Task PlayGame();
        void ShowOptions();
    }
}