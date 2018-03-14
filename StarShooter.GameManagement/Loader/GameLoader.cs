using System.Threading.Tasks;
using StarShooter.GameManagement.Data;

namespace StarShooter.GameManagement.Loader
{
    public class GameLoader : IGameLoader
    {

        private readonly ISceneManager _sceneManager;
        private readonly IBundlesManager _bundlesManager;

        public GameLoader(ISceneManager sceneManager, IBundlesManager bundlesManager)
        {
            _sceneManager = sceneManager;
            _bundlesManager = bundlesManager;
        }

        public async Task LoadGame(GameInfo game)
        {
            var scenes = await _bundlesManager.LoadBundle(game.Id);
            foreach (var scene in scenes)
            {
                await _sceneManager.LoadScene(scene);
            }
            
        }
    }
}
