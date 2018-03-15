using System.Threading.Tasks;

namespace StarShooter.GameManagement
{
    public interface IBundlesManager
    {
        /// <summary>
        /// Load bundle for the game with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of the loaded scenes</returns>
        Task<string[]> LoadBundle(int id);
    }
}
