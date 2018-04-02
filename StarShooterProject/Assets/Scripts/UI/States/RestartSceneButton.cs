namespace StarShooter.Unity.UI.States
{
    public class RestartSceneButton : MenuChangeStateButton
    {
        protected override void CallChangeState()
        {
            _stateManager.CurrentState = GameManagement.AppState.MainMenu;
            base.CallChangeState();
        }
    }
}
