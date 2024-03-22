using Galaga.Data;
using UnityEngine;

namespace Galaga.Controllers
{
    public class ProjectileController : MonoBehaviour
    {
        [SerializeField] private ProjectileData _projectileData;
        
        private void Update()
        {
            MoveForward();
        }

        private void MoveForward()
        {
            Vector3 movement = transform.up * _projectileData.MaxSpeed * Time.deltaTime;
            transform.position += movement;   
        }
        
    }
}