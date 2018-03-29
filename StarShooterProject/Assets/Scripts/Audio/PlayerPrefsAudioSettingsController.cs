using UnityEngine;
using StarShooter.Audio.Settings;

namespace StarShooter.Unity.Audio
{
    public class PlayerPrefsAudioSettingsController : BasicAudioSettingsController
    {
        private const string AudioVolumeKey = "audio_volume";
        private const string MusicVolumeKey = "music_volume";

        protected override float _audioVolume
        {
            get
            {
                return PlayerPrefs.GetFloat(AudioVolumeKey, 1);
            }
            set
            {
                PlayerPrefs.SetFloat(AudioVolumeKey, value);
            }
        }

        protected override float _musicVolume
        {
            get
            {
                return PlayerPrefs.GetFloat(MusicVolumeKey, 1);
            }
            set
            {
                PlayerPrefs.SetFloat(MusicVolumeKey, value);
            }
        }

    }
}
