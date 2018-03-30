using System;

namespace StarShooter.Unity.Game.Interfaces
{
    public interface ILivesController
    {
        event Action OnDie;
        event Action<int> OnLivesCountChange;
        int Lives { get; set; }
    }
}
