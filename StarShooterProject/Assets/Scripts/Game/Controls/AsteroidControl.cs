using StarShooter.Unity.Game.Interfaces;
using UnityEngine;

namespace StarShooter.Unity.Game.Controls
{
    public class AsteroidControl : IControl
    {
        public Vector2 MoveVector { get; } = new Vector2(1,0);
    }
}
