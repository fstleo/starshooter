using StarShooter.Unity.Game.Interfaces;
using UnityEngine;
using Zenject;

namespace StarShooter.Unity.Game.ScoresManagement.Installer
{
    public class ScoresManagementInstaller : MonoInstaller<ScoresManagementInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IScoresManager>().To<PlayerPrefsScoresManager>().AsTransient();
        }
    }
}