using System;

namespace StarShooter.Unity.UI
{
    internal interface IAppStateManager
    {

        event Action<AppState> OnStateChange;
        AppState CurrentState { get; set; }
    }
}