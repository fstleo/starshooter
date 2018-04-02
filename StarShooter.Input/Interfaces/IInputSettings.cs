namespace StarShooter.Input.Interfaces
{
    public interface IInputSettings
    {
        int[] GetKeys();

        int GetControl(int code);
    }
}
