using StarShooter.Input.InputManager;
using StarShooter.Input.Interfaces;
using Zenject;

namespace Assets.Scripts.Input
{
    public class UpdateInputManager : InputManager, ITickable
    {
        public UpdateInputManager(IInputSettings settings, INativeInput input) : base(settings, input) { }

        public void Tick()
        {
            CheckKeys();
        }
    }
}
