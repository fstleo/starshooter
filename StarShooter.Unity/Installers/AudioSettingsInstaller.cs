using StarShooter.Audio.Interfaces;
using StarShooter.Unity.Audio;
using Zenject;

namespace StarShooter.Unity.Installers
{
    public class AudioSettingsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IAudioSettingsController>().To<PlayerPrefsAudioSettingsController>().AsSingle();
        }
    }
}
