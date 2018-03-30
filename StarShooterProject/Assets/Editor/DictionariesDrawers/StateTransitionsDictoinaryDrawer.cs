using StarShooter.GameManagement;
using StarShooter.GameManagement.GamesListSource;
using StarShooter.UI.States;
using StarShooter.Unity.Game.Controls;
using UnityEditor;
using UnityEngine;

namespace StarShooter.Editor.Input
{
    [CustomPropertyDrawer(typeof(MenuTransitionsDictionary))]
    public class StateTransitionsDictoinaryDrawer : DictionaryDrawer<AppState, AppState>
    {
    }
}
