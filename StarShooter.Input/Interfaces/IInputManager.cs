using System;
using StarShooter.Input.Enums;

namespace StarShooter.Input.Interfaces
{
    public interface IInputManager
    {
        void AddInputListener(int key, Action<KeyState> callback);
        void RemoveInputListener(int key, Action<KeyState> callback);
    }
    
}
