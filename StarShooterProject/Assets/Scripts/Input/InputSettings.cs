using System;
using System.Linq;
using StarShooter.Input.Interfaces;
using StarShooter.Unity.Game.Controls;
using StarShooter.Unity.Utils;
using UnityEngine;

namespace StarShooter.GameManagement.GamesListSource
{

    [Serializable]
    public class InputKeysDictionary : SerializableDictionary<KeyCode, GameActions> { }
    [CreateAssetMenu(fileName = "InputSettings", menuName = "Games/Create input settings")]
    public  class InputSettings : ScriptableObject, IInputSettings
    {
        [SerializeField]
        private InputKeysDictionary _keysDictionary = new InputKeysDictionary();

        public KeyCode[] GetKeys()
        {
            return _keysDictionary.Keys.ToArray();
        }

        public int GetControl(KeyCode code)
        {
            if (_keysDictionary.ContainsKey(code))
            {
                return (int) _keysDictionary[code];
            }
            return -1;
        }
    }
}
