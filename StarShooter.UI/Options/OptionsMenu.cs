using StarShooter.Audio.Interfaces;
using UnityEngine;
using Zenject;

namespace StarShooter.UI.Options
{
    public class OptionsMenu : MonoBehaviour
    {

        [SerializeField] private VolumeSettingsPanel audioPanel;
        [SerializeField] private VolumeSettingsPanel musicPanel;
        
        private IAudioSettingsController _audioSettingsController;

        [Inject]
        private void Init(IAudioSettingsController audioSettingsController)
        {
            _audioSettingsController = audioSettingsController;

            audioPanel.SetValue(_audioSettingsController.AudioVolume);
            audioPanel.SetValue(_audioSettingsController.MusicVolume);

            audioPanel.OnValueChange += (value) => audioSettingsController.AudioVolume = value;
            audioPanel.OnMute += muted => audioSettingsController.AudioMuted = muted;

            musicPanel.OnValueChange += (value) => audioSettingsController.MusicVolume = value;            
            musicPanel.OnMute += muted => audioSettingsController.MusicMuted = muted;        
        }
    }

    
}
