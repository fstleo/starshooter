using System;

namespace StarShooter.GameManagement
{
    public interface IAppStateManager
    {

        event Action<AppState> OnStateChange;
        AppState CurrentState { get; set; }
    }
}