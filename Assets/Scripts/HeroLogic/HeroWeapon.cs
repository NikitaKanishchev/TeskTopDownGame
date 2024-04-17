using System;
using UnityEngine;

namespace HeroLogic
{
    public class HeroWeapon : MonoBehaviour
    {
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _firePoint = null;
        [SerializeField] private float _bulletForce = 10f;
        [SerializeField] private AudioSource _audio;
        [SerializeField] private AudioClip _audioShoot;


        private void Start() => 
            _audio = GetComponent<AudioSource>();

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Fire();
                if(_audio)
                    _audio.PlayOneShot(_audioShoot);
            }
        }

        public void Fire()
        {
            GameObject bullet = Instantiate(_bullet, _firePoint.position, _firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(_firePoint.up * _bulletForce, ForceMode2D.Impulse);
        }
    }
}