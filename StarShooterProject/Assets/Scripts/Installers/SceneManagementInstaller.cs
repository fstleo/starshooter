using Zenject;

namespace StarShooter.GameManagement.SceneManagement.Installer
{
    public class SceneManagementInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IAppStateManager>().To<UnityStateManager>().AsSingle();
            Container.Bind<IScenesStatesSettings>().To<ScenesSettings>().FromScriptableObjectResource("Settings/ScenesSettings").AsSingle();
        }
    }
}
