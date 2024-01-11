using CodeBase.Infrastructure.ServiceLocator;
using UnityEngine;

namespace CodeBase.GamePlay.Hero
{
    public class HeroInput : MonoBehaviour
    {
        [SerializeField] private HeroMovement _heroMovement;

        private IInputServices _inputServices;

        private void Start()
        {
            _inputServices = AllServices.SrvContainer.Single<IInputServices>();
        }

        public void Update()
        {
            _heroMovement.SetMoveDirection(_inputServices.MovementAxis);
        }
    }
}

