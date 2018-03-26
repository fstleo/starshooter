using StarShooter.Unity.AppStateControl;
using StarShooter.Unity.Controllers.MainMenu;
using StarShooter.Unity.Controllers.OptionsMenu;
using StarShooter.Unity.UI;
using Zenject;

namespace StarShooter.Unity.Installers
{
    public class MenuControllersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IMainMenuController>().To<MainMenuController>().AsSingle();
            Container.Bind<IOptionsMenuController>().To<OptionsMenuController>().AsSingle();
            Container.Bind<IAppStateManager>().To<AppStatesController>().AsSingle();
        }
    }
}
