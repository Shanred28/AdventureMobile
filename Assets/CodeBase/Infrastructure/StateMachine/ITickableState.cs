namespace CodeBase.Infrastructure.StateMachines
{
    public interface ITickableState : IState
    {
        void Tick();
    }
}