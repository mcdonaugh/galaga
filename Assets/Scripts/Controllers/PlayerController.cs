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
        private Vector3 _movementSpeed;
        private Vector3 _playerLocation;
        private float _leftBound;
        private float _rightBound;

        private void Awake()
        {
            _movementSpeed = transform.right * _actorData.MaxSpeed * Time.deltaTime;
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
                _playerView.transform.position -= _movementSpeed;  
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
                _playerView.transform.position += _movementSpeed;  
            } 
            else
            {
                return;
            }
        }
        private void OnFireKeyActionHandler()
        {   
            _playerLocation = _playerView.transform.position;
            _projectilePoolController.GetProjectile(_playerLocation);
        } 
    }
}