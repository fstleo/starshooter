using System;
using System.Threading.Tasks;
using StarShooter.GameManagement.AppStateControl;
using UnityEngine.SceneManagement;

namespace StarShooter.GameManagement.SceneManagement
{
    internal class UnityStateManager : AppStatesController, ISceneManager
    {
        private readonly IScenesStatesSettings _scenesSettings;

        public UnityStateManager(IScenesStatesSettings scenesSettings)
        {
            _scenesSettings = scenesSettings;
            OnStateChange += CheckSceneChange;
        }

        private void CheckSceneChange(AppState state)
        {
            string requiredSceneName = _scenesSettings.GetScene(state);
            if (string.IsNullOrEmpty(requiredSceneName))
            {
                throw new Exception($"Can't find scene for game state {state}");
            }
            if (SceneManager.GetActiveScene().name != requiredSceneName)
            {
                LoadScene(requiredSceneName);
            }
        }

        public async Task LoadScene(string name)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            var loadingOperation = SceneManager.LoadSceneAsync(name);

            loadingOperation.completed +=
                operation =>
                {
                    tcs.SetResult(operation.isDone);
                };            
            await tcs.Task;            
        }

    }
}
