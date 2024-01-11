namespace CodeBase.Infrastructure.StateMachine
{
    public partial class StateMachine
    {
        public interface ITickableState : IState
        {
            void Tick();
        }
    }
}