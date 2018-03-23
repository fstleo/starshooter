using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarShooter.Unity.UI;

namespace StarShooter.Unity.AppStateControl
{
    public class AppStatesController : IAppStateManager
    {
        public event Action<AppState> OnStateChange;

        private AppState _currentState;
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
