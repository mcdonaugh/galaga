using UnityEngine;

namespace Galaga.Data
{
    [CreateAssetMenu(fileName = "New Projectile Data", menuName = "Galaga/New Projectile Data")]
    public class ProjectileData : ScriptableObject
    {
        public float MaxSpeed => _maxSpeed;
        public float MaxDamage => _maxDamage;
        public Sprite ProjectileSprite => _projectileSprite;

        [SerializeField] private float _maxSpeed;
        [SerializeField] private int _maxDamage;
        [SerializeField] private Sprite _projectileSprite;
    }
}