using StarShooter.GameManagement;
using UnityEngine;
using Zenject;

public class Preloader : MonoBehaviour
{

    [Inject]
    void Init(IAppStateManager stateManager, ISceneManager sceneManager)
    {
        stateManager.CurrentState = AppState.MainMenu;
        sceneManager.LoadScene("1. MainMenu");
    }
}
