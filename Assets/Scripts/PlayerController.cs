using GameInput;
using UnityEngine;
using UnityEngine.UIElements;
namespace PlayerController
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private UserInput _userInput;
        [SerializeField] private GameObject _playerView;
        [SerializeField] private float _flySpeed;

        private void Update()
        {
            _userInput.OnAKeyPressedAction += OnAKeyPressedActionHandler;
            _userInput.OnDKeyPressedAction += OnDKeyPressedActionHandler;
            _userInput.OnSpaceKeyPressedAction += OnSpaceKeyPressedActionHandler;
        }
        
        private void OnAKeyPressedActionHandler()
        {
            Debug.Log($"A Key Pressed");
        }
        private void OnDKeyPressedActionHandler()
        {
            Debug.Log($"D Key Pressed");
        }
        private void OnSpaceKeyPressedActionHandler()
        {
            Debug.Log($"Pew Pew");
        }   
    }
}