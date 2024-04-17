using System.Collections;
using Enemy;
using UnityEngine;

namespace BulletScript
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _bulletRigidbody = null;

        private void Start() =>
            StartCoroutine(ChangeVisibleAfterTime());

        public void ShootIntoPosition(Transform firePoint, float speed) =>
            _bulletRigidbody.AddForce(firePoint.up * speed, ForceMode2D.Impulse);

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out EnemyHealth enemyHealt))
                enemyHealt.TakeDamage(1);
        }

        private IEnumerator ChangeVisibleAfterTime()
        {
            yield return new WaitForSeconds(2f);
            gameObject.SetActive(false);
        }
    }
}