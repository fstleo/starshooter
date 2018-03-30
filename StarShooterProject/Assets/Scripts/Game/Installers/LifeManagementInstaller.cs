using StarShooter.Unity.Game.Interfaces;
using Zenject;

namespace StarShooter.Unity.Game.LifeManagement
{
    public class LifeManagementInstaller : MonoInstaller<LifeManagementInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInstance(3).WhenInjectedInto<LifeManager>();
            Container.Bind<ILivesController>().To<LifeManager>().AsTransient();
        }
    }
}