using System;
using Logic;
using UnityEngine;

namespace Animation
{
    public class AnimationLogic : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private Animator _animator;

        private static readonly int PlayerWalk = Animator.StringToHash("Walking");
        private static readonly int PlayerDeath = Animator.StringToHash("Die");

        private readonly int _walkingStateHash = Animator.StringToHash("Run");
        private readonly int _deathStateHash = Animator.StringToHash("Die");

        public event Action<AnimatorState> StateEntered;

        public AnimatorState State { get; private set; }

        private void Update() =>
            _animator.SetFloat(PlayerWalk, _rigidbody2D.velocity.magnitude, 0.1f, Time.deltaTime);

        public void PlayDeath() =>
            _animator.SetTrigger(PlayerDeath);

        public void EnteredState(int stateHash)
        {
            State = StateFor(stateHash);
            StateEntered?.Invoke(State);
        }

        private AnimatorState StateFor(int stateHash)
        {
            AnimatorState state;

            if (stateHash == _walkingStateHash)
            {
                state = AnimatorState.Walking;
            }
            else if (stateHash == _deathStateHash)
            {
                state = AnimatorState.Died;
            }
            else
            {
                state = AnimatorState.Unknown;
            }

            return state;
        }
    }
}