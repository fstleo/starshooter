using StarShooter.Unity.Game.Interfaces;
using UnityEngine;

namespace StarShooter.Unity.Game.Move
{
    public class SimpleMove : IMove
    {        
        private readonly IControl _control;

        private readonly Rigidbody2D _cachedRigidbody;

        private float _speed;

        public SimpleMove(IControl control, Rigidbody2D rigidbody)
        {
            _control = control;
            _cachedRigidbody = rigidbody;
        }

        public void Init(float speed)
        {            
            _speed = speed;
        }

        public void ProcessMove()
        {
            _cachedRigidbody.MovePosition(_control.MoveVector * _speed);
        }
        
    }
}
