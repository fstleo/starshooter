using System;
using System.Collections.Generic;
using StarShooter.GameManagement;
using StarShooter.GameManagement.SceneManagement;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StarShooter.Editor.Input
{
    [CustomPropertyDrawer(typeof(StatesScenesDictionary))]
    public class AppStatesSettingsDrawer : DictionaryDrawer<AppState, string>
    {
        private List<string> scenes = new List<string>();

        protected override T DoField<T>(Rect rect, Type type, T value)
        {
            if (typeof(T) != typeof(string))
            {
                return base.DoField(rect, type, value);
            }
            
            if (scenes.Count == 0)
            {
                InitScenes();
            }
            var s = (string)(object)value;
            int selected = scenes.IndexOf(s);
            selected = Mathf.Max(0, selected);
            selected = EditorGUI.Popup(rect, selected, scenes.ToArray());
            
            return (T)(object)scenes[selected];
        }

        private void InitScenes()
        {            
            for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
            {
                scenes.Add(EditorBuildSettings.scenes[i].path);
                scenes[i] = scenes[i].Remove(scenes[i].Length - 6).Remove(0, scenes[i].LastIndexOf('/') + 1);
            }
        }
    }
}
