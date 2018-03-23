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
            Container.Bind<IInputSettings>().FromScriptableObjectResource("Settings/InputSettings").AsSingle();
        }
    }
}
