using System.Threading.Tasks;

namespace StarShooter.GameManagement.SceneManager
{
    internal class UnitySceneManager : ISceneManager
    {
        public async Task LoadScene(string name)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            var loadingOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(name);

            loadingOperation.completed +=
                operation =>
                {
                    tcs.SetResult(operation.isDone);
                };            
            await tcs.Task;            
        }
    }
}
