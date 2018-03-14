using StarShooter.GameManagement.Data;
using System.Threading.Tasks;

namespace StarShooter.GameManagement.Selection
{
    public interface IGamesListSource
    {
        Task<GameInfo[]> GetGamesList();
    }
}
