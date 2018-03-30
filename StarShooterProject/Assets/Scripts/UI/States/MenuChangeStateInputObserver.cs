using System;
using System.Collections.Generic;
using StarShooter.GameManagement;
using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using StarShooter.Unity.Game.Controls;
using StarShooter.Unity.Utils;
using UnityEngine;
using Zenject;

namespace StarShooter.UI.States
{

    [Serializable]
    public class MenuTransitionsDictionary : SerializableDictionary<AppState, AppState> { }

    public class MenuChangeStateInputObserver : MonoBehaviour
    {
        [SerializeField]
        private MenuTransitionsDictionary stateTransitions;

        private IInputManager _inputManager;
        private IAppStateManager _appStateManager;

        [Inject]
        public void Init(IAppStateManager appStateManager, IInputManager inputManager)
        {
            _appStateManager = appStateManager;
            _inputManager = inputManager;
            _inputManager.AddKeyListener((int)GameActions.Escape, Back);
        }

        private void OnDestroy()
        {
            _inputManager.RemoveKeyListener((int)GameActions.Escape, Back);
        }

        private void Back(KeyState keyState)
        {
            if (keyState != KeyState.Down)
            {
                return;
            }
            _appStateManager.CurrentState = stateTransitions[_appStateManager.CurrentState];
        }

    }
}
