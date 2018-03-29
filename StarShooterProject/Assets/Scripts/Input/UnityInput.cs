using System;
using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.Input
{
    public class UnityInput : INativeInput, ITickable
    {
        public event Action OnAnyKeyPress;

        public KeyState GetKeyState(KeyCode code)
        {
            if (UnityEngine.Input.GetKeyDown(code))
            {
                return KeyState.Down;
            }
            if (UnityEngine.Input.GetKey(code))
            {
                return KeyState.Pressed;
            }
            if (UnityEngine.Input.GetKeyUp(code))
            {
                return KeyState.Up;
            }
            return KeyState.Released;
        }

        public void Tick()
        {
            if (UnityEngine.Input.anyKey)
            {
                OnAnyKeyPress?.Invoke();
            }
        }
    }
}
