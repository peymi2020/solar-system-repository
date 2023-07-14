using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Test.UI.PausePanel
{
    public class PausePanelControl : MonoBehaviour
    {
        [SerializeField] private Button continueButton;
        [SerializeField] private Button restartButton;

        [SerializeField] private GameObject gamePanelGameObject;

        private void Awake()
        {
            continueButton.onClick.AddListener(OnContinueButtonClicked);
            restartButton.onClick.AddListener(OnRestartButtonClicked);
        }

        private void OnEnable()
        {
            ChangeTimeScale(0f);
        }

        private void OnContinueButtonClicked()
        {
            gameObject.SetActive(false);
            gamePanelGameObject.SetActive(true);
        }

        private void OnRestartButtonClicked()
        {
            int buildIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(buildIndex);
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