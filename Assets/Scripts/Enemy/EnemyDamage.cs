using Hero;
using UnityEngine;

namespace Enemy
{
    public class EnemyDamage : MonoBehaviour
    {
        [SerializeField] private float _damage;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.TryGetComponent(out HeroHealth heroHealth))
            {
                heroHealth.TakeDamage(_damage);
            }
        }
    }
}
