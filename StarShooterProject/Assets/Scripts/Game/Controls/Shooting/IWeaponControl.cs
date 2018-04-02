using System;

namespace StarShooter.Game.Controls.Shooting
{
    public interface IWeaponControl
    {
        event Action OnShot;
    }
}