using System.Linq;
using System.Threading.Tasks;
using StarShooter.GameManagement;
using StarShooter.GameManagement.Data;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace StarShooter.UI
{
    public class GameSelectMenu : MonoBehaviour
    {
        [SerializeField] private Dropdown gamesSelectionDropdown;

        [Inject]
        private IGamesListSource _gamesListSource;

        [Inject]
        private IGameLoader _gameLoader;

        private GameInfo[] _gamesList;

        private async void Start()
        {            
            await LoadGameList();
        }

        public async Task LoadGameList()
        {
            _gamesList = await _gamesListSource.GetGamesList();
            gamesSelectionDropdown.AddOptions(_gamesList.Select(game => game.Name).ToList());
        }

        public void OnPlayButtonClick()
        {
            _gameLoader.LoadGame(_gamesList[gamesSelectionDropdown.value]);
        }

    }
}
