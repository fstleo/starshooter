using System;
using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using UnityEngine;
using Zenject;
using UnityEngine.EventSystems;

namespace StarShooter.Unity.InputSystem
{
    public class UnityInput : INativeInput, ITickable
    {
        public event Action OnTick;

        public KeyState GetKeyState(int code)
        {
            if (UnityEngine.Input.GetKeyDown((KeyCode)code))
            {
                return KeyState.Down;
            }
            if (UnityEngine.Input.GetKey((KeyCode)code))
            {
                return KeyState.Pressed;
            }
            if (UnityEngine.Input.GetKeyUp((KeyCode)code))
            {
                return KeyState.Up;
            }
            return KeyState.Released;
        }

        public void Tick()
        {              
            OnTick?.Invoke();
        }
    }
}
