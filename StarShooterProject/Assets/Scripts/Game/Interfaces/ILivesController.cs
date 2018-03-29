using System;

namespace StarShooter.Unity.Game.Interfaces
{
    public interface ILivesController
    {
        event Action OnDie;
        int Lives { get; set; }
    }
}
