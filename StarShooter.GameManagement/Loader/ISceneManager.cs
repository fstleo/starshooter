using System.Threading.Tasks;

namespace StarShooter.GameManagement.Loader
{
    public interface ISceneManager
    {
        Task LoadScene(string name);
    }
}
