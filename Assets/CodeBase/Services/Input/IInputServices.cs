using UnityEngine;

namespace CodeBase.Infrastructure.ServiceLocator
{
    public interface IInputServices : IService
    {
        bool Enable { get; set; }
        Vector2 MovementAxis { get; }
    }
}