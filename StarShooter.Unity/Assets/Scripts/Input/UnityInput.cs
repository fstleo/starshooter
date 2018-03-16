using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using UnityEngine;

namespace StarShooter.Unity.Input
{
    public class UnityInput : MonoBehaviour, INativeInput
    {
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
    }
}
