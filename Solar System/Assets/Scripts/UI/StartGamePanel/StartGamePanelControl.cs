using System;
using UnityEngine;
using UnityEngine.UI;

namespace Test.UI.StartGamePanel
{
    public class StartGamePanelControl : MonoBehaviour
    {
        [SerializeField] private Button startGameButton;

        [SerializeField] private GameObject gamePanelGameObject;
        
        private void Awake()
        {
            startGameButton.onClick.AddListener(OnButtonClicked);
        }

        private void OnEnable()
        {
            ChangeTimeScale(0f);
        }

        private void OnButtonClicked()
        {
            gameObject.SetActive(false);
            gamePanelGameObject.SetActive(true);
        }

        private void ChangeTimeScale(float value)
        {
            Time.timeScale = value;
        }

        private void OnDisable()
        {
            ChangeTimeScale(1f);
        }
    }
}