using StarShooter.Unity.Game.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace StarShooter.Unity.UI.Game
{
    public class GamePlayMenu : MonoBehaviour
    {

        [SerializeField] private Text LivesCountLabel;
        [SerializeField] private Text ScoresLabel;

        [Inject]
        public void Init(ILivesController livesManager, IScoresManager scoresManager)
        {
            scoresManager.OnScoresChange += UpdateScoresLabel;
            livesManager.OnLivesCountChange += UpdateLivesCountLabel;
            UpdateLivesCountLabel(livesManager.Lives);
            UpdateScoresLabel(scoresManager.Scores);
        }

        private void UpdateScoresLabel(int scores)
        {
            ScoresLabel.text = scores.ToString();
        }

        private void UpdateLivesCountLabel(int count)
        {
            LivesCountLabel.text = count.ToString();
        }

    }
}