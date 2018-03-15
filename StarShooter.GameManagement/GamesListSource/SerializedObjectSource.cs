using System.Threading.Tasks;
using StarShooter.GameManagement.Data;
using UnityEngine;

namespace StarShooter.GameManagement.GamesListSource
{
    [CreateAssetMenu(fileName = "GamesList", menuName = "Games/Create list")]
    internal class SerializedObjectSource : ScriptableObject, IGamesListSource
    {

        public GameInfo[] Infos;

        public Task<GameInfo[]> GetGamesList()
        {
            return Task.FromResult(Infos);
        }
    }
}
