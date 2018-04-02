using StarShooter.Unity.Game.Interfaces;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.Game.Move
{
    public class SimpleMove : IFixedTickable
    {        
        private readonly IControl _control;

        private readonly Rigidbody2D _cachedRigidbody;

        private float _speed = 3;

        public SimpleMove(IControl control, Rigidbody2D rigidbody)
        {
            _control = control;
            _cachedRigidbody = rigidbody;
        }

        public void FixedTick()
        {
            ProcessMove();
        }

        private void ProcessMove()
        {
            _cachedRigidbody.MovePosition(_cachedRigidbody.position + _control.MoveVector * _speed * Time.fixedDeltaTime);
        }
    }
}
