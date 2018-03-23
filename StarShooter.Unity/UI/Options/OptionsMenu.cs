using StarShooter.Audio.Interfaces;
using StarShooter.Unity.Controllers.OptionsMenu;
using UnityEngine;
using Zenject;

namespace StarShooter.UI.Options
{
    public class OptionsMenu : MonoBehaviour
    {

        [SerializeField] private VolumeSettingsPanel audioPanel;
        [SerializeField] private VolumeSettingsPanel musicPanel;

        private IOptionsMenuController _optionsMenuController;

        [Inject]
        private void Init(IOptionsMenuController optionsMenuController)
        {
            _optionsMenuController = optionsMenuController;

            audioPanel.SetValue(_optionsMenuController.AudioVolume);
            audioPanel.SetValue(_optionsMenuController.MusicVolume);

            audioPanel.OnValueChange += (value) => _optionsMenuController.AudioVolume = value;
            audioPanel.OnMute += muted => _optionsMenuController.SetAudioMute(muted);

            musicPanel.OnValueChange += (value) => _optionsMenuController.MusicVolume = value;
            musicPanel.OnMute += muted => _optionsMenuController.SetMusicMute(muted);
        }

        public void OnBackButtonClick()
        {
            
        }

    }

    
}
