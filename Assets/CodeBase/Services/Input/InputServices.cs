using UnityEngine;

namespace CodeBase.Infrastructure.ServiceLocator
{
    public class InputServices : IInputServices
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";

        private bool _enable = true;

        public Vector2 MovementAxis
        {
            get
            {
                return GetMovementAxis();
            }
        }

        public bool Enable { get => _enable; set => _enable = value; }

        private Vector2 GetMovementAxis()
        {
            if (VirtualJoystick.Value != Vector2.zero)
                return VirtualJoystick.Value;

            return new Vector2(Input.GetAxis(HorizontalAxisName), Input.GetAxis(VerticalAxisName));

        }
    }
}

