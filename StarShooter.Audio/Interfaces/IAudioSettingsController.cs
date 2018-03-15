namespace StarShooter.Audio.Interfaces
{
    public interface IAudioSettingsController
    {

        float AudioVolume { get; set; }
        float MusicVolume { get; set; }
        bool AudioMuted { get; set; }
        bool MusicMuted { get; set; }
    }
}
