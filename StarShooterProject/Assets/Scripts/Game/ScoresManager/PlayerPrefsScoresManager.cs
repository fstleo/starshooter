using System;
using System.Collections;
using System.Collections.Generic;
using StarShooter.Unity.Game.Interfaces;
using UnityEngine;

namespace StarShooter.Unity.Game.ScoresManagement
{

    public class PlayerPrefsScoresManager : IScoresManager
    {
        private const string TopScoresKey = "Scores";

        public event Action<int> OnScoresChange;

        public int TopScore
        {
            get { return PlayerPrefs.GetInt(TopScoresKey, 0); }
            private set
            {
                PlayerPrefs.SetInt(TopScoresKey, value);
            }
        }

        private int _scores;

        public int Scores
        {
            get { return _scores; }
            set
            {
                _scores = value;
                if (value > TopScore)
                {
                    TopScore = value;
                }
                OnScoresChange?.Invoke(_scores);
            }
        }
    }
}