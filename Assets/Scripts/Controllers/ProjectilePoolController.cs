using System.Collections;
using UnityEngine;

namespace Galaga.Controllers
{
    public class ProjectilePoolController : MonoBehaviour
    {
        [SerializeField] private ProjectileController _projectileController;
        [SerializeField] private int _maxProjectiles;
        private ProjectileController[] _projectileArray;
        private int projectileDuration;

        private void Awake()
        {
            _projectileArray = new ProjectileController[_maxProjectiles];

            for (int i = 0; i < _maxProjectiles; i++)
            {
                ProjectileController newProjectile = Instantiate(_projectileController, transform.position, Quaternion.identity);
                newProjectile.gameObject.SetActive(false);
                _projectileArray[i] = newProjectile;

            }
        }

        public ProjectileController GetProjectile()
        {
            foreach (var projectile in _projectileArray)
            {
                if(!projectile.gameObject.activeInHierarchy)
                {
                    projectile.gameObject.SetActive(true);
                    return projectile;
                }
            }
            return null;
        }
        
        
    }
}