using UnityEngine;

namespace Galaga.Data
{
    [CreateAssetMenu(fileName = "New Actor Data", menuName = "Galaga/New Actor Data")]
    public class ActorData : ScriptableObject
    {

        public float MaxSpeed => _maxSpeed;
        public int MaxHealth => _maxHealth;
        public Sprite ActorSprite => _actorSprite;

        [SerializeField] private float _maxSpeed;
        [SerializeField] private int _maxHealth;
        [SerializeField] private Sprite _actorSprite; 
    }
}