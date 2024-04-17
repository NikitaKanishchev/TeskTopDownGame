using Hero;
using UnityEngine;

namespace Logic.Medicine
{
    public class MedicineScript : MonoBehaviour
    {
        public int CollisionHeal = 1;
        public string collisionTag;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == collisionTag)
            {
                HeroHealth health = collision.gameObject.GetComponent<HeroHealth>();
                health.SetHealt(CollisionHeal);
                Destroy(gameObject);
            }
        }
    }
}