using System;

namespace StarShooter.Unity.Game.Interfaces
{
    public interface IScoresManager
    {        
        event Action<int> OnScoresChange;
        int TopScore { get; }
        int Scores { get; set; }
    }
}
