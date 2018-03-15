using System.Threading.Tasks;

namespace StarShooter.GameManagement
{
    public interface ISceneManager
    {
        Task LoadScene(string name);
    }
}
