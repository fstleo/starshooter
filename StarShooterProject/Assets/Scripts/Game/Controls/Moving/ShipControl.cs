using System;
using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using StarShooter.Unity.Game.Interfaces;
using UnityEngine;

namespace StarShooter.Unity.Game.Controls
{
    internal class AxisControl
    {
        public event Action<float> OnChange;
        private float _currentValue = 0;
        private float CurrentValue
        {
            get { return _currentValue; }

            set
            {
                _currentValue = value;
                OnChange?.Invoke(_currentValue);
            }
        }
        private readonly IInputManager _inputManager;
        private readonly GameActions _negativeAction;
        private readonly GameActions _positiveAction;

        internal AxisControl(IInputManager inputManager, GameActions negative, GameActions positive)
        {
            _inputManager = inputManager;
            _negativeAction = negative;
            _positiveAction = positive;
            _inputManager.AddKeyListener((int)_negativeAction, ProcessNegative);
            _inputManager.AddKeyListener((int)_positiveAction, ProcessPositive);
        }

        ~AxisControl()
        {
            _inputManager.RemoveKeyListener((int)_negativeAction, ProcessNegative);
            _inputManager.RemoveKeyListener((int)_positiveAction, ProcessPositive);
        }

        public void ProcessNegative(KeyState state)
        {
            if (state == KeyState.Down)
            {
                CurrentValue -= 1;
            }
            if (state == KeyState.Up)
            {
                CurrentValue += 1;
            }
        }

        public void ProcessPositive(KeyState state)
        {
            if (state == KeyState.Down)
            {
                CurrentValue += 1;
            }
            if (state == KeyState.Up)
            {
                CurrentValue -= 1;
            }            
        }
    }

    public class ShipControl : IControl
    {
        private Vector2 _moveVector = Vector2.zero;

        public Vector2 MoveVector => _moveVector;

        private readonly IInputManager _inputManager;

        public ShipControl(IInputManager inputManager)
        {
            _inputManager = inputManager;
            new AxisControl(inputManager, GameActions.Down, GameActions.Up).OnChange += ProcessYAxis;
            new AxisControl(inputManager, GameActions.Left, GameActions.Right).OnChange += ProcessXAxis;

        }

        private void ProcessYAxis(float y)
        {
            _moveVector.y = y;
        }

        private void ProcessXAxis(float x)
        {
            _moveVector.x = x;
        }
    }


}
