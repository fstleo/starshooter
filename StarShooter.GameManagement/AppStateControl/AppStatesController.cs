using System;

namespace StarShooter.GameManagement.AppStateControl
{
    public class AppStatesController : IAppStateManager
    {
        public event Action<AppState> OnStateChange;

        private AppState _currentState = AppState.Preload;
        public AppState CurrentState
        {
            get { return _currentState; }
            set
            {
                if (value == _currentState)
                {
                    return;
                }
                _currentState = value;
                OnStateChange?.Invoke(value);
            }
        }
    }
}
