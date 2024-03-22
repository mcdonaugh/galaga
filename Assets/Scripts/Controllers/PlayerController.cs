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

        private void Awake()
        {
            _movement = transform.right * _actorData.MaxSpeed * Time.deltaTime;
        }
        
        private void OnEnable()
        {
            _userInput.OnLeftKeyPressed += OnLeftKeyActionHandler;
            _userInput.OnRightKeyPressed += OnRightKeyActionHandler;
            _userInput.OnFireKeyPressed += OnFireKeyActionHandler;
        }
        
        private void OnLeftKeyActionHandler()
        {
            _playerView.transform.position -= _movement;
        }
        private void OnRightKeyActionHandler()
        {
            _playerView.transform.position += _movement;
        }
        private void OnFireKeyActionHandler()
        {
            _projectilePoolController.GetProjectile();
        } 
    }
}