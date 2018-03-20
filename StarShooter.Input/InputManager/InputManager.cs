using System;
using System.Collections.Generic;
using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using UnityEngine;

namespace StarShooter.Input.InputManager
{
    public sealed class InputManager : IInputManager
    {
        private readonly Dictionary<int, Action<KeyState>> _keyListeners = new Dictionary<int, Action<KeyState>>();       
        private readonly Dictionary<KeyCode, KeyState> _keyStates = new Dictionary<KeyCode, KeyState>();

        private readonly IInputSettings _inputSettings;
        private readonly INativeInput _input;
        private readonly KeyCode[] _keys;

        public InputManager(IInputSettings settings, INativeInput input)
        {
            _inputSettings = settings;            
            _input = input;
            _input.OnAnyKeyPress += CheckKeys;
            foreach (var key in _inputSettings.GetKeys())
            {
                _keyStates.Add(key, KeyState.Released);
            }
            _keys = _inputSettings.GetKeys();
        }

        private void CheckKeys()
        {            
            foreach (var key in _keys)
            {
                var state = _input.GetKeyState(key);
                if (state != _keyStates[key])
                {
                    _keyListeners[_inputSettings.GetControl(key)]?.Invoke(state);
                }
                _keyStates[key] = state;
            }
        }

        public void AddKeyListener(int key, Action<KeyState> callback)
        {
            if (!_keyListeners.ContainsKey(key))
            {
                _keyListeners.Add(key, callback);
            }
            else
            {
                _keyListeners[key] += callback;
            }
        }

        public void RemoveKeyListener(int key, Action<KeyState> callback)
        {
            if (!_keyListeners.ContainsKey(key))
            {
                return;
            }
            if (callback != null)
            {
                _keyListeners[key] -= callback;
            }
        }

    }


}
