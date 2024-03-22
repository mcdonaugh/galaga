using UnityEngine;

namespace Galaga.Data
{
    [CreateAssetMenu(fileName = "New Projectile Data", menuName = "Galaga/New Projectile Data")]
    public class ProjectileData : ScriptableObject
    {
        public float MaxSpeed => _maxSpeed;
        public int MaxDamage => _maxDamage;
        public float MaxDuration => _maxDamage;
        public Sprite Sprite => _sprite;

        [SerializeField] private float _maxSpeed;
        [SerializeField] private int _maxDamage;
        [SerializeField] private float _maxDuration;
        [SerializeField] private Sprite _sprite;
    }
}