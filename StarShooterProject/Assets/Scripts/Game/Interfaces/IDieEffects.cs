using System;

namespace StarShooter.Unity.Game.Interfaces
{
    public interface IDieEffects
    {
        event Action OnFinish;
        void Play();
    }
}
