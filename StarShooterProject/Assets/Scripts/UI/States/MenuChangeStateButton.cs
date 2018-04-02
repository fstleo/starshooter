using StarShooter.GameManagement;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace StarShooter.Unity.UI.States
{
    public class MenuChangeStateButton : MonoBehaviour
    {
        [SerializeField]
        private AppState State;

        protected IAppStateManager _stateManager;

        [Inject]
        private void Init(IAppStateManager stateManager)
        {
            _stateManager = stateManager;
            GetComponent<Button>().onClick.AddListener(CallChangeState);
        }

        protected virtual void CallChangeState()
        {
            _stateManager.CurrentState = State;
        }
    }
}
