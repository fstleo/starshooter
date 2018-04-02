using System;
using System.Linq;
using StarShooter.Input.Interfaces;
using StarShooter.Unity.Game.Controls;
using StarShooter.Unity.Utils;
using UnityEngine;

namespace StarShooter.Input
{

    [Serializable]
    public class InputKeysDictionary : SerializableDictionary<KeyCode, GameActions> { }
    [CreateAssetMenu(fileName = "InputSettings", menuName = "Games/Create input settings"), Serializable]
    public  class InputSettings : ScriptableObject, IInputSettings
    {
        [SerializeField]
        private InputKeysDictionary _keysDictionary = new InputKeysDictionary();

        public int[] GetKeys()
        {
            return Array.ConvertAll(_keysDictionary.Keys.ToArray(), value => (int)value);
        }

        public int GetControl(int code)
        {
            KeyCode unityCode = (KeyCode)code;
            if (_keysDictionary.ContainsKey(unityCode))
            {
                return (int) _keysDictionary[unityCode];
            }
            return -1;
        }
    }
}
