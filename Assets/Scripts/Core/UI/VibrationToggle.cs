using Core.Vibrations;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public class VibrationToggle : MonoBehaviour, IContextToggle
    {
        [SerializeField] [Required] private Image _turnedOnImage;
        [SerializeField] [Required] private Button _button;
        private VibrationsReproducer _vibrationsReproducer;

        public void Construct(VibrationsReproducer vibrationsReproducer)
        {
            _vibrationsReproducer = vibrationsReproducer;
        }

        private void Start()
        {
            UpdateImage();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(Toggle);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(Toggle);
        }

        public void Toggle()
        {
            _vibrationsReproducer.Enabled = !_vibrationsReproducer.Enabled;
            UpdateImage();
        }

        private void UpdateImage()
        {
            _turnedOnImage.gameObject.SetActive(_vibrationsReproducer.Enabled);
        }
    }
}