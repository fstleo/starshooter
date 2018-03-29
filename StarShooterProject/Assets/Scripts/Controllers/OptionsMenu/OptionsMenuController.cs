using StarShooter.Audio.Interfaces;

namespace StarShooter.Unity.Controllers.OptionsMenu
{
    public class OptionsMenuController : IOptionsMenuController
    {

        private readonly IAudioSettingsController _audioSettingsController;

        public OptionsMenuController(IAudioSettingsController audioSettingsController)
        {
            _audioSettingsController = audioSettingsController;
        }
    
        public float AudioVolume
        {
            get { return _audioSettingsController.AudioVolume; }
            set { _audioSettingsController.AudioVolume = value; }
        }
        public float MusicVolume
        {
            get { return _audioSettingsController.MusicVolume; }
            set { _audioSettingsController.MusicVolume = value; }
        }

        public void SetAudioMute(bool muted)
        {
            _audioSettingsController.AudioMuted = muted;
        }

        public void SetMusicMute(bool muted)
        {
            _audioSettingsController.MusicMuted = muted;
        }

    }
}
