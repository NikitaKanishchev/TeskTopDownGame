using System;
using HeroLogic;
using UnityEngine;

namespace Hero
{
    public class HeroDeath : MonoBehaviour
    {
        public HeroHealth Health;

        public HeroMovement _move;
        public HeroWeapon _attack;
        public Action PlayerDeath;

        private bool _isDead;

        private void Start()
        {
            Health.HealthChanged += HealthChanged;
        }

        private void OnDestroy()
        {
            Health.HealthChanged -= HealthChanged;
        }

        private void HealthChanged()
        {
            if (!_isDead && Health.Current <= 0)
                Die();
        }

        private void Die()
        {
            _isDead = true;
            _move.enabled = false;
            _attack.enabled = false;
            PlayerDeath.Invoke();
            Destroy(gameObject);
        }
    }
}