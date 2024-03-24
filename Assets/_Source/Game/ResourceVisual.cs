using _Source.Core;
using TMPro;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] private GameResource gameResource;

        [SerializeField] private GameManager gameManager;

        [SerializeField] private TextMeshProUGUI textMesh;

        void Start()
        {
            UpdateValue(gameManager.ResourceBank.GetResource(gameResource).Value);
            gameManager.ResourceBank.GetResource(gameResource).OnValueChanged += UpdateValue;
        }

        void UpdateValue(int value)
        {
            textMesh.text = value.ToString();
        }
    }
}