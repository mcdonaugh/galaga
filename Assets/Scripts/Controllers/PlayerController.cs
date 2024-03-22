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

        private void OnEnable()
        {
            _userInput.OnLeftKeyPressed += OnLeftKeyActionHandler;
            _userInput.OnRightKeyPressed += OnRightKeyActionHandler;
            _userInput.OnFireKeyPressed += OnFireKeyActionHandler;
        }
        
        private void OnLeftKeyActionHandler()
        {
            Debug.Log($"Move Left");
        }
        private void OnRightKeyActionHandler()
        {
            Debug.Log($"Move Right");
        }
        private void OnFireKeyActionHandler()
        {
            _projectilePoolController.GetProjectile();
        } 
    }
}