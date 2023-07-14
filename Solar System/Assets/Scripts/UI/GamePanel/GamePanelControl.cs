using UnityEngine;
using UnityEngine.UI;

namespace Test.UI.GamePanel
{
    public class GamePanelControl : MonoBehaviour
    {
        [SerializeField] private Button pauseButton;

        [SerializeField] private GameObject pausePanelGameObject;

        private void Awake()
        {
            pauseButton.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            gameObject.SetActive(false);
            pausePanelGameObject.SetActive(true);
        }
    }
}