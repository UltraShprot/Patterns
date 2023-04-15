using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine 
{
    public State state { get;  set; }

    public void InitState(State initState)
    {
        state = initState;
        state.Enter();
    }
    public void ChangeState(State newState)
    {
        state.Exit();
        state = newState;
        state.Enter();
    }
}
