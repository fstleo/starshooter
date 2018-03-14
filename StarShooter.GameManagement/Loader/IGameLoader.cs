using System.Threading.Tasks;
using StarShooter.GameManagement.Data;

namespace StarShooter.GameManagement
{
    public interface IGameLoader
    {
        /// <summary>
        /// Load game 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        Task LoadGame(GameInfo info);
    }
}
