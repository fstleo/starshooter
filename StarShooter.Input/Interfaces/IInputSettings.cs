using UnityEngine;

namespace StarShooter.Input.Interfaces
{
    public interface IInputSettings
    {
        KeyCode[] GetKeys();

        int GetControl(KeyCode code);
    }
}
