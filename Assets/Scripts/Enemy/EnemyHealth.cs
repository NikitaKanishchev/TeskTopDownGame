using System;
using Logic;
using UnityEngine;

namespace Enemy
{
    public class EnemyHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private float _current;

        [SerializeField] private float _max;

        private EnemyCount _count;

        public event Action HealthChanged;

        public float Current
        {
            get => _current;
            set => _current = value;
        }

        public float Max
        {
            get => _max;
            set => _max = value;
        }

        private void Start()
        {
            _count = FindObjectOfType<EnemyCount>();
        }

        public void TakeDamage(float damage)
        {
            Current -= damage;
            HealthChanged?.Invoke();

            if (_current <= 0)
            {
                _count.Kill();
                Destroy(gameObject);
            }
        }
    }
}
