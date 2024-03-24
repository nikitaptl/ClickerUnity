using System;
using System.Collections;
using System.Collections.Generic;

namespace _Source.Core
{
    public class ProductionLevels
    {
        private readonly Dictionary<GameResource, int> _levels = new Dictionary<GameResource, int>()
        {
            {GameResource.Humans, 10},
            {GameResource.Food, 10},
            {GameResource.Wood, 10},
            {GameResource.Stone, 10},
            {GameResource.Gold, 10},
        };
    
        public void ChangeLevel(GameResource resource, int value)
        {
            if (_levels[resource] + value < 100)
            {
                _levels[resource] += value;
            }
        }

        public int GetLevel(GameResource resource)
        {
            return _levels[resource];
        }
    }

}