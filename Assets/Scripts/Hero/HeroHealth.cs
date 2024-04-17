using System;
using Logic;
using UnityEngine;

namespace Hero
{
    public class HeroHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private float _maxHealth = 5f;
        [SerializeField] private float _currentHealth = 5f;
        
        private IHealth _healthImplementation;

        public event Action HealthChanged;

        public float Current
        {
            get => _currentHealth;
            set => _currentHealth = value;
        }

        public float Max
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }


        public void TakeDamage(float damage)
        {
            Current -= damage;

            HealthChanged?.Invoke();
        }

        public void SetHealt(int bonusHealth)
        {
            _currentHealth += bonusHealth;
            if (_currentHealth > _maxHealth)
                _currentHealth = _maxHealth;
        }
    }
}

