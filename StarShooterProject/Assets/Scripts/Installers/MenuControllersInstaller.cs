using StarShooter.GameManagement;
using StarShooter.GameManagement.AppStateControl;
using StarShooter.Unity.Controllers.MainMenu;
using StarShooter.Unity.Controllers.OptionsMenu;
using Zenject;

namespace StarShooter.Unity.Installers
{
    public class MenuControllersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IMainMenuController>().To<MainMenuController>().AsSingle();
            Container.Bind<IOptionsMenuController>().To<OptionsMenuController>().AsSingle();     
        }
    }
}
