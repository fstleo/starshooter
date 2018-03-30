using Zenject;

namespace StarShooter.GameManagement.SceneManagement.Installer
{
    public class SceneManagementInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISceneManager>().To<UnitySceneManager>().AsSingle();
        }
    }
}
