using StarShooter.Input;
using StarShooter.Unity.Game.Controls;
using UnityEditor;
using UnityEngine;

namespace StarShooter.Editor.Input
{
    [CustomPropertyDrawer(typeof(InputKeysDictionary))]
    public class InputSDDrawer : DictionaryDrawer<KeyCode, GameActions>
    {
    }
}
