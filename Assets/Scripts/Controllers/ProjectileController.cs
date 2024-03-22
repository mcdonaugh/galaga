using System.Collections;
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
            StartCoroutine(DestroyProjectile());
        }

        IEnumerator DestroyProjectile()
        {
            yield return new WaitForSeconds(_projectileData.MaxDuration);
            gameObject.SetActive(false); 
            gameObject.transform.position = new Vector3(0,0,0);
        }
        
    }
}