using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarShooter.Audio.Interfaces;
using StarShooter.Audio.Settings;

namespace StarShooter.Tests.GameManagementTests
{
    [TestClass]
    public class AudioSettingsTest
    {
        [TestMethod]
        public void AudioSettingsController_CreateController_DefaultValues()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();

            Assert.IsTrue(ValuesAreNear(controller.AudioVolume, 1));
        }

        [TestMethod]
        public void AudioSettingsController_ChangeVolume_NormalChange()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();
            controller.AudioVolume = 0.5f;
            Assert.IsTrue(ValuesAreNear(controller.AudioVolume, 0.5f));
        }

        [TestMethod]
        public void AudioSettingsController_ChangeVolume_OverRangeChange()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();
            controller.AudioVolume = 100;
            Assert.IsTrue(ValuesAreNear(controller.AudioVolume, 1));
        }


        [TestMethod]
        public void AudioSettingsController_Mute_VolumeChange()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();

            controller.AudioMuted = true;
            controller.MusicMuted = true;

            Assert.IsTrue(ValuesAreNear(controller.AudioVolume, 0));
            Assert.IsTrue(ValuesAreNear(controller.MusicVolume, 0));
        }

        [TestMethod]
        public void AudioSettingsController_Unmute_VolumeChange()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();

            controller.AudioMuted = true;
            controller.MusicMuted = true;

            controller.AudioMuted = false;
            controller.MusicMuted = false;

            Assert.IsTrue(ValuesAreNear(controller.AudioVolume, 1));
            Assert.IsTrue(ValuesAreNear(controller.MusicVolume, 1));
        }

        [TestMethod]
        public void AudioSettingsController_MuteOnLowVolume_CheckMute()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();

            controller.AudioVolume = 0.0f;
            controller.MusicVolume = 0.0f;

            Assert.IsTrue(controller.AudioMuted);
            Assert.IsTrue(controller.MusicMuted);
        }

        [TestMethod]
        public void AudioSettingsController_UnmuteOnVolumeChange_CheckUnmute()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();

            controller.AudioVolume = 0.0f;
            controller.MusicVolume = 0.0f;
            controller.AudioVolume = 0.1f;
            controller.MusicVolume = 0.1f;

            Assert.IsFalse(controller.AudioMuted);
            Assert.IsFalse(controller.MusicMuted);
        }


        [TestMethod]
        public void AudioSettingsController_UnmuteFromZero_CheckLevel()
        {
            IAudioSettingsController controller = new BasicAudioSettingsController();
            
            controller.AudioVolume = 0.0f;
            controller.MusicVolume = 0.0f;
            controller.AudioMuted = false;
            controller.MusicMuted = false;

            Assert.IsTrue(ValuesAreNear(controller.AudioVolume, 0.75f));
            Assert.IsTrue(ValuesAreNear(controller.MusicVolume, 0.75f));
        }

        private bool ValuesAreNear(float value1, float value2)
        {
            return Math.Abs(value1 - value2) < 0.01f;
        }
    }
}
