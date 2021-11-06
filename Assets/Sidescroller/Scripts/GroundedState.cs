using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GroundedState : MovementState
{
    private bool jump;
  
    public GroundedState(StateMachine stateMachine, Player player) : base(stateMachine, player)
    {

    }

    public override void Enter()
    {
        base.Enter();
        jump = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void HandleInput()
    {
        base.HandleInput();
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(jump) stateMachine.ChangeState(player.jumpingState);
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
