using Leopotam.Ecs;
using UnityEngine;

namespace Client
{
    internal class CreatePlayerSystem : IEcsRunSystem
    {
        private EcsFilter<Player>.Exclude<PlayerViewRef> _filter;
        private Configuration _configuration;
        public void Run()
        {
            foreach (var index in _filter)
            {
                ref var player = ref _filter.Get1(index);
                var playerView = Object.Instantiate(_configuration.PlayerView);
                _filter.GetEntity(index).Get<PlayerViewRef>().value = playerView;
            }            
        }
    }
}