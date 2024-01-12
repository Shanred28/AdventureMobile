﻿using CodeBase.Infrastructure.ServiceLocator;
using CodeBase.Infrastructure.StateMachines;

namespace CodeBase.Infrastructure.Service.GameStates
{
    public interface IGameStateSwither : IService
    { 
        object CurrentState { get; }

        void AddState<TState>(TState state) where TState : class, IState;
        void EnterState<TState>() where TState : class, IState;
        void ExitState<TState>() where TState : class, IState;
        void RemoveState<TState>() where TState : class, IState;
        void UpdateTick();
    }
}