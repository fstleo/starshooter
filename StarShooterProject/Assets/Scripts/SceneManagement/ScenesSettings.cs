using System;
using System.Collections.Generic;
using StarShooter.Unity.Utils;
using UnityEditor;
using UnityEngine;

namespace StarShooter.GameManagement.SceneManagement
{
    [Serializable]
    public class StatesScenesDictionary : SerializableDictionary<AppState, string> { }
    [CreateAssetMenu(fileName = "ScenesSettings", menuName = "Games/Create scenes list"), Serializable]
    public class ScenesSettings : ScriptableObject, IScenesStatesSettings
    {
        [SerializeField]
        private StatesScenesDictionary scenesList;

        public string GetScene(AppState state)
        {
            return scenesList.ContainsKey(state) ? scenesList[state] : "";
        }
    }
}
