using Leopotam.Ecs;
using UnityEngine;

namespace Client
{
    internal class PlayerInitializeSystem : IEcsInitSystem
    {
        private EcsWorld _world;
        public void Init()
        {
            var playerEntity = _world.NewEntity();
            playerEntity.Get<Player>();
            playerEntity.Get<Position>().value = new Vector3(1, 1, 1);
        }
    }
}