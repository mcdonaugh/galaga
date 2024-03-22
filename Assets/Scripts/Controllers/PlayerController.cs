using Galaga.GameInput;
using Galaga.Data;
using UnityEngine;

namespace Galaga.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private UserInput _userInput;
        [SerializeField] private GameObject _playerView;
        [SerializeField] private ActorData _actorData;
        [SerializeField] private ProjectilePoolController _projectilePoolController;
        private Vector3 _movement;
        private float _leftBound;
        private float _rightBound;

        private void Awake()
        {
            _movement = transform.right * _actorData.MaxSpeed * Time.deltaTime;
            _leftBound = -1.2f;
            _rightBound = 1.2f;
        }
        
        private void OnEnable()
        {
            _userInput.OnLeftKeyPressed += OnLeftKeyActionHandler;
            _userInput.OnRightKeyPressed += OnRightKeyActionHandler;
            _userInput.OnFireKeyPressed += OnFireKeyActionHandler;
        }
        
        private void OnLeftKeyActionHandler()
        {

            if (_playerView.transform.position.x >= _leftBound)
            {   
                _playerView.transform.position -= _movement;  
            } 
            else
            {
                return;
            }
        }
        private void OnRightKeyActionHandler()
        {
            if (_playerView.transform.position.x <= _rightBound)
            {   
                _playerView.transform.position += _movement;  
            } 
            else
            {
                return;
            }
        }
        private void OnFireKeyActionHandler()
        {
            _projectilePoolController.GetProjectile();
        } 
    }
}