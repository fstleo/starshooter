using StarShooter.Input.Enums;
using UnityEngine;

namespace StarShooter.Input.Interfaces
{
    public interface INativeInput
    {
        KeyState GetKeyState(KeyCode code);
    }
}
