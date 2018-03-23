using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.UI
{
    public class MenuState : MonoBehaviour
    {
        [SerializeField]
        private AppState State;

        [Inject]
        private void Init(IAppStateManager appStateManager)
        {
            appStateManager.OnStateChange += CheckActivity;
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
