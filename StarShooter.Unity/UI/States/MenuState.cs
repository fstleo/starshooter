using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.UI.States
{
    public class MenuState : MonoBehaviour
    {
        [SerializeField]
        private AppState State;

        private IAppStateManager _appStateManager;
        [Inject]
        private void Init(IAppStateManager appStateManager)
        {
            _appStateManager = appStateManager;
            _appStateManager.OnStateChange += CheckActivity;
            CheckActivity(_appStateManager.CurrentState);
        }

        private void CheckActivity(AppState obj)
        {
            if (obj != State)
            {
                Disable();
                return;
            }
            Enable();            
        }

        protected virtual void Disable()
        {
            gameObject.SetActive(false);
        }

        protected virtual void Enable()
        {
            gameObject.SetActive(true);
        }
    }
}
