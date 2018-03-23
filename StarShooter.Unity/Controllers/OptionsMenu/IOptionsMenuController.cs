namespace StarShooter.Unity.Controllers.OptionsMenu
{
    public interface IOptionsMenuController
    {
        float AudioVolume { get; set; }
        float MusicVolume { get; set; }

        void SetAudioMute(bool muted);        
        void SetMusicMute(bool muted);
        void GoToMenu();
    }
}