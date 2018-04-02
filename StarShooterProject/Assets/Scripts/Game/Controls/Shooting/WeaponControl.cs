using StarShooter.Input.Enums;
using StarShooter.Input.Interfaces;
using StarShooter.Unity.Game.Controls;
using System;
using Zenject;

namespace StarShooter.Game.Controls.Shooting
{
    public class WeaponControl : IWeaponControl, ITickable
    {
        public event Action OnShot;
        private readonly IInputManager _inputManager;
        private bool _isShooting;

        public WeaponControl(IInputManager inputManager)
        {
            _inputManager = inputManager;
            inputManager.AddKeyListener((int)GameActions.Shot, ShotKeyStateChange);
        }

        ~WeaponControl()
        {
            _inputManager.RemoveKeyListener((int)GameActions.Shot, ShotKeyStateChange);
        }

        private void ShotKeyStateChange(KeyState state)
        {
            _isShooting = state != KeyState.Released;
        }

        public void Tick()
        {
            
        }
    }
}
