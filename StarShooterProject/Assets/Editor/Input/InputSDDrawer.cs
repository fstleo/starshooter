using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarShooter.GameManagement.GamesListSource;
using StarShooter.Unity.Game;
using StarShooter.Unity.Utils;
using UnityEditor;
using UnityEngine;

namespace StarShooter.Editor.Input
{
    [CustomPropertyDrawer(typeof(InputKeysDictionary))]
    public class InputSDDrawer : DictionaryDrawer<KeyCode, GameActions>
    {
    }
}
