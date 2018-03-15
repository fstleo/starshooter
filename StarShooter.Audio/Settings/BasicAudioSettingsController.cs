using StarShooter.Audio.Interfaces;
using UnityEngine;

namespace StarShooter.Audio.Settings
{
    public class BasicAudioSettingsController : IAudioSettingsController
    {
        protected virtual float _audioVolume { get; set; }
        protected virtual float _musicVolume { get; set; }

        public float AudioVolume
        {
            get
            {
                return _audioMuted ? 0 : _audioVolume;
            }
            set
            {
                _audioVolume = Mathf.Clamp01(value);
                _audioMuted = _audioVolume < 0.01f;
            }
        }

        public float MusicVolume
        {
            get
            {
                return _musicMuted ? 0 : _musicVolume;
            }
            set
            {
                _musicVolume = Mathf.Clamp01(value);
                _musicMuted = _musicVolume < 0.01f;
            }
        }

        protected virtual bool _audioMuted { get; set; }
        public bool AudioMuted
        {
            get { return _audioMuted; }
            set
            {
                _audioMuted = value;
                if (!value && (AudioVolume < 0.01f))
                {
                    AudioVolume = 0.75f;
                }
            }
        }

        protected virtual bool _musicMuted { get; set; }

        public bool MusicMuted
        {
            get { return _musicMuted; }
            set
            {
                _musicMuted = value;
                if (!value && (MusicVolume < 0.01f))
                {
                    MusicVolume = 0.75f;
                }
            }
        }

        public BasicAudioSettingsController()
        {
            _musicVolume = 1;
            _audioVolume = 1;
        }
    }
}
