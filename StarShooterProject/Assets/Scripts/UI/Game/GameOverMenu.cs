using StarShooter.Unity.Game.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace StarShooter.Unity.UI.Game
{
    public class GameOverMenu : MonoBehaviour
    {

        [SerializeField] private Text TopScoresLabel;
        [SerializeField] private Text ScoresLabel;
    
        private IScoresManager _scoresManager;

        [Inject]
        public void Init(IScoresManager scoresManager)
        {
            _scoresManager = scoresManager;
        }

        private void OnEnable()
        {
            ScoresLabel.text = _scoresManager.Scores.ToString();
            TopScoresLabel.text = _scoresManager.TopScore.ToString();
        }

    }
}