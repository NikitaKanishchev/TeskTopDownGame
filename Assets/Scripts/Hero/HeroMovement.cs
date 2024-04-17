using Services.App;
using Services.Input;
using UnityEngine;

namespace Hero
{
    public class HeroMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _heroRigidbody2D;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private float _rotateSpeed;

        private Vector2 _moveDirection;

        private IInputService _inputService;
        private GameBootstrap _gameBootstrap;

        private void Awake()
        {
            _gameBootstrap = FindObjectOfType<GameBootstrap>();
            _inputService = _gameBootstrap.InputService;
        }

        private void Update()
        {
            _moveDirection = Vector2.zero;

            if (_inputService.Axis.sqrMagnitude > 0.00001f)
            {
                _moveDirection = new Vector2(_inputService.Axis.x, _inputService.Axis.y).normalized;

                Quaternion moveRotation = Quaternion.LookRotation(Vector3.forward, _moveDirection);
                transform.rotation = Quaternion.Lerp(transform.rotation, moveRotation, _rotateSpeed * Time.deltaTime);
            }
        }

        private void FixedUpdate()
        {
            _heroRigidbody2D.velocity =
                new Vector2(_moveDirection.x * _movementSpeed, _moveDirection.y * _movementSpeed);
        }
    }
}