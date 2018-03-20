using System;
using StarShooter.Input.Enums;
using UnityEngine;

namespace StarShooter.Input.Interfaces
{
    public interface INativeInput
    {
        event Action OnAnyKeyPress;
        KeyState GetKeyState(KeyCode code);
    }
}
