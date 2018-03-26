using System;

namespace StarShooter.Unity.UI
{
    public interface IAppStateManager
    {

        event Action<AppState> OnStateChange;
        AppState CurrentState { get; set; }
    }
}