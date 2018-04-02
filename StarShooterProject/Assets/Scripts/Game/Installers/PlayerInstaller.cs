using StarShooter.Unity.Game.Controls;
using StarShooter.Unity.Game.Interfaces;
using StarShooter.Unity.Game.Move;
using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller<PlayerInstaller>
{
    [SerializeField]
    private GameObject playerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Rigidbody2D>().FromComponentInNewPrefab(playerPrefab).WhenInjectedInto<SimpleMove>();
        Container.Bind<IControl>().To<ShipControl>().AsSingle().WhenInjectedInto<SimpleMove>();       
        Container.Bind<IFixedTickable>().To<SimpleMove>().AsSingle().NonLazy();
        
    }
}