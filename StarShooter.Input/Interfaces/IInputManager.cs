using System;
using StarShooter.Input.Enums;

namespace StarShooter.Input.Interfaces
{
    public interface IInputManager
    {
        void AddKeyListener(int key, Action<KeyState> callback);
        void RemoveKeyListener(int key, Action<KeyState> callback);
    }
    
}
