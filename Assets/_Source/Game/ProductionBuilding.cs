using System.Collections;
using _Source.Core;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _Source.Game
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;
        [SerializeField] private GameResource gameResource;

        public Button button;
        public Slider slider;
        private readonly float _productionTime = 3f;

        void Start()
        {
            slider.gameObject.SetActive(false);
        }

        public void Increase()
        {
            StartCoroutine(Coroutine());
        }

        IEnumerator Coroutine()
        {
            slider.gameObject.SetActive(true);
            button.interactable = false;

            float start = 0f;
            float prodTime = _productionTime;
            while (start < prodTime)
            {
                start += Time.deltaTime;
                float progress = start / prodTime;
                slider.value = progress;

                yield return null;
            }

            gameManager.ResourceBank.ChangeResource(gameResource, 1);
            button.interactable = true;

            slider.gameObject.SetActive(false);
        }
    }
}