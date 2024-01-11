namespace CodeBase.Infrastructure.StateMachine
{
    public partial class StateMachine
    {
        public interface IExitableState : IState
        {
            void Exit();
        }
    }
}