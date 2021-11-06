using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : MovementState
{
    private float force;
    

    public JumpingState(StateMachine stateMachine, Player player) : base (stateMachine, player)
    {

    }

    private void Jump(float force)
    {
        player.transform.Translate(new Vector2(0f, player.groundCheckRadius + 0.1f));
        var forceVector = new Vector2(0, force);
        player.rb.AddForce(forceVector, ForceMode2D.Impulse);
    }

    public override void Enter()
    {
        base.Enter();
        grounded = false;
        force = player.jumpForce;
        Jump(force);
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
        if(grounded)stateMachine.ChangeState(player.groundedState);
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
