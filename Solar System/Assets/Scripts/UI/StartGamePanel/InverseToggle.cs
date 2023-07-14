using UnityEngine;
using UnityEngine.UI;

namespace Test.UI.StartGamePanel
{
    public class InverseToggle : MonoBehaviour
    {
        [SerializeField] private Toggle toggle;

        [SerializeField] private RectTransform musicOnRect;

        private void OnEnable()
        {
            OnValueChanged(toggle.isOn);

            toggle.onValueChanged.AddListener(OnValueChanged);
        }

        private void OnValueChanged(bool value)
        {
            musicOnRect.gameObject.SetActive(!value);
        }

        private void OnDisable()
        {
            toggle.onValueChanged.RemoveListener(OnValueChanged);
        }
    }
}