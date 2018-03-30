using StarShooter.GameManagement.GamesListSource;
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
