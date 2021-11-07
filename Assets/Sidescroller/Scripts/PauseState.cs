using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : State
{
    public PauseState(StateMachine stateMachine, Player player) : base(stateMachine, player)
    {

    }

    public override void Enter()
    {
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void HandleInput()
    {
        base.HandleInput();
   
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
     
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
