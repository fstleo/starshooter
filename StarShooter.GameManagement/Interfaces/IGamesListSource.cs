using StarShooter.GameManagement.Data;
using System.Threading.Tasks;

namespace StarShooter.GameManagement
{    
    public interface IGamesListSource
    {
        Task<GameInfo[]> GetGamesList();
    }
}
