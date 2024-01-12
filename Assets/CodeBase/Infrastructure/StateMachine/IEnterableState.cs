namespace CodeBase.Infrastructure.StateMachines
{
    public interface IEnterableState : IState
    {
        void Enter();
    }
}