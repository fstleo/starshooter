using System;
using StarShooter.Unity.Game.Interfaces;

namespace StarShooter.Unity.Game.LifeManagement
{
    public class LifeManager : ILivesController
    {
        public event Action OnDie;
        public event Action<int> OnLivesCountChange;

        private int _lives;

        public int Lives
        {
            get { return _lives; }
            set
            {
                if (value < 0)
                {
                    OnDieEvent();
                }
                else
                {
                    _lives = value;
                    OnLivesCountChange?.Invoke(value);
                }                
            }
        }

        public LifeManager(int lives)
        {
            _lives = lives;
        }

        protected virtual void OnDieEvent()
        {
            OnDie?.Invoke();
        }
    }
}
