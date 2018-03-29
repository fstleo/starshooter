using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace StarShooter.GameManagement.SceneManagement
{
    internal class UnitySceneManager : ISceneManager
    {
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
