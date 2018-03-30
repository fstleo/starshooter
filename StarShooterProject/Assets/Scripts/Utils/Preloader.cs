using StarShooter.GameManagement;
using UnityEngine;
using Zenject;

public class Preloader : MonoBehaviour
{

    [Inject]
    void Init(IAppStateManager stateManager)
    {
        stateManager.CurrentState = AppState.MainMenu;
    }
}
