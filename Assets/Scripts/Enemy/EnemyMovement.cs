using Hero;
using UnityEngine;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        private Transform target;

        private void Start()
        {
            target = FindObjectOfType<HeroHealth>().GetComponent<Transform>();
        }

        private void FixedUpdate()
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position,
                _speed * Time.fixedDeltaTime);
        }
    }
}
