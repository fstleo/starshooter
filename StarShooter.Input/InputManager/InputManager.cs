using System;
using System.Collections.Generic;
using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using UnityEngine;

namespace StarShooter.Input.InputManager
{
    public class InputManager : IInputManager
    {
        protected Dictionary<int, Action<KeyState>> _listeners = new Dictionary<int, Action<KeyState>>();
        protected Dictionary<KeyCode, KeyState> _keyStates = new Dictionary<KeyCode, KeyState>();

        private readonly IInputSettings _inputSettings;
        private readonly INativeInput _input;
        private readonly KeyCode[] _keys;

        public InputManager(IInputSettings settings, INativeInput input)
        {
            _inputSettings = settings;            
            _input = input;
            foreach (var key in _inputSettings.GetKeys())
            {
                _keyStates.Add(key, KeyState.Released);
            }
            _keys = _inputSettings.GetKeys();
        }

        public void CheckKeys()
        {            
            foreach (var key in _keys)
            {
                var state = _input.GetKeyState(key);
                if (state != _keyStates[key])
                {
                    _listeners[_inputSettings.GetControl(key)]?.Invoke(state);
                }
                _keyStates[key] = state;
            }
        }

        public void AddInputListener(int key, Action<KeyState> callback)
        {
            if (!_listeners.ContainsKey(key))
            {
                _listeners.Add(key, callback);
            }
            else
            {
                _listeners[key] += callback;
            }
        }

        public void RemoveInputListener(int key, Action<KeyState> callback)
        {
            if (!_listeners.ContainsKey(key))
            {
                return;
            }
            if (callback != null)
            {
                _listeners[key] -= callback;
            }
        }

    }


}
