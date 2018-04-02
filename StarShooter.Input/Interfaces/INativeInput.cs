using System;
using StarShooter.Input.Enums;

namespace StarShooter.Input.Interfaces
{
    public interface INativeInput
    {
        event Action OnTick;
        KeyState GetKeyState(int code);
    }
}
