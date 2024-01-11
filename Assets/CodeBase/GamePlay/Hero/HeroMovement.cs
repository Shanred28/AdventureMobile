using UnityEngine;

namespace CodeBase.GamePlay.Hero
{
    public class HeroMovement : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private Transform _viewTransform;
        [SerializeField] private float _movementSpeed;

        private Vector3 _directionControl;

        private void Update()
        {
            if (_directionControl.magnitude > 0)
            {
                _characterController.Move(_directionControl * _movementSpeed * Time.deltaTime);
                _viewTransform.rotation = Quaternion.LookRotation(_directionControl);
            }
            else
            {
                _characterController.Move(Vector3.zero);
            }
        }

        public void SetMoveDirection(Vector2 moveDireection)
        {
            _directionControl.x = moveDireection.x;
            _directionControl.z = moveDireection.y;
            _directionControl.Normalize();
        }
    }
}

