using System.Threading.Tasks;
using UnityEngine;

namespace StarShooter.GameManagement.Loader
{
    public interface IBundlesManager
    {
        /// <summary>
        /// Load bundle for the game with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of scenes</returns>
        Task<string[]> LoadBundle(int id);
    }
}
