using System;
using UnityEngine;
using UnityEngine.UI;

namespace StarShooter.UI.Options
{
    public class VolumeSettingsPanel : MonoBehaviour
    {
        public event Action<float> OnValueChange;
        public event Action<bool> OnMute;

        [SerializeField]
        private Slider volumeSlider;

        [SerializeField]
        private Toggle muteToggle;

        private void Awake()
        {            
            volumeSlider.onValueChanged.AddListener(SetValue);
            muteToggle.onValueChanged.AddListener(MuteEvent);     
        }

        private void MuteEvent(bool value)
        {
            OnMute?.Invoke(value);
        }

        public void SetValue(float value)
        {
            OnValueChange?.Invoke(value);
            muteToggle.isOn = value < 0.01f;
        }

    }

}
