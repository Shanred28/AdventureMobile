using System;
using System.Collections.Generic;

namespace CodeBase.Infrastructure.StateMachine
{
    public partial class StateMachine
    {
        private Dictionary<Type, object> _states;
        private object _currentState;

        public StateMachine()
        {
            _states = new Dictionary<Type, object>();
        }

        public void AddState<TState>(TState state) where TState : class, IState
        {
            _states.Add(state.GetType(), state);
        }

        public void RemoveState<TState>() where TState : class, IState
        {
            _states.Remove(typeof(TState));
        }

        public void EnterState<TState>() where TState : class, IState
        {
            if (_currentState != null && typeof(TState) == _currentState.GetType()) return;

            if(_currentState is IExitableState exitableState) exitableState.Exit();

            TState state = _states[typeof(TState)] as TState;
            _currentState = state;

            if (_currentState is IEnterableState enterabletate) enterabletate.Enter();
        }

        public void ExitState<TState>() where TState : class, IState
        {
            if (_currentState is IExitableState exitableState) exitableState.Exit();

            _currentState = null;
        }

        public void UpdateTick()
        {
            if (_currentState is ITickableState tickabletate) tickabletate.Tick();
        }
    }
}