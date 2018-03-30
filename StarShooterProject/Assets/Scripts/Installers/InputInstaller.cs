using StarShooter.GameManagement.GamesListSource;
using StarShooter.Input.InputManager;
using StarShooter.Input.Interfaces;
using StarShooter.Unity.Input;
using Zenject;

namespace StarShooter.Unity.Installers
{
    public class InputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<INativeInput>().To<UnityInput>().AsSingle();
            Container.Bind<ITickable>().To<UnityInput>().AsSingle();
            Container.Bind<IInputSettings>().To<InputSettings>().FromScriptableObjectResource("Settings/InputSettings").AsSingle();
            Container.Bind<IInputManager>().To<InputManager>().AsSingle();
        }
    }
}
