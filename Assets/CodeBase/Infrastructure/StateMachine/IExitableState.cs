namespace CodeBase.Infrastructure.StateMachines
{
    public interface IExitableState : IState
    {
        void Exit();
    }
}