using System.Collections;
using _Source.Core;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _Source.Game
{
    public class ShopBuilding : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;
        [SerializeField] private GameResource gameResource;
        
        public void Increase()
        {
            gameManager.ProductionLevels.ChangeLevel(gameResource, 1);
        }
    }
}