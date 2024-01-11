namespace CodeBase.Infrastructure.StateMachine
{
    public partial class StateMachine
    {
        public interface IEnterableState : IState
        {
            void Enter();
        }
    }
}