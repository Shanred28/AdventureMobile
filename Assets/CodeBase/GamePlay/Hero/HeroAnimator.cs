using UnityEngine;

namespace CodeBase.GamePlay.Hero
{
   public class HeroAnimator : MonoBehaviour
    {
        private const string ISMOVING = "IsMoving";
        private const string ATTACKTRIGGER = "Attack";
        private const float MOVEMENTRESHOLD = 0.05f;

        [SerializeField] private CharacterController _characterController;
        [SerializeField] private Animator _animator;

        private void Update()
        {
            _animator.SetBool(ISMOVING, _characterController.velocity.magnitude >= MOVEMENTRESHOLD);
        }

        public void Attack()
        {
            _animator.SetTrigger(ATTACKTRIGGER);
        }
    }
}

