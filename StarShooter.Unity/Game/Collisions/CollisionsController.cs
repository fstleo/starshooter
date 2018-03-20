using StarShooter.Unity.Game.Interfaces;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.Game.Collisions
{
    public class CollisionsController : MonoBehaviour
    {
        private ILivesController _livesController;

        [Inject]
        public void Init(ILivesController livesController)
        {
            _livesController = livesController;
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            _livesController.Lives--;
        }
    }
}
