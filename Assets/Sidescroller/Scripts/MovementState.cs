using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    public bool grounded;
    public float speed;

    public MovementState(StateMachine stateMachine, Player player) : base(stateMachine, player)
    {

    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log(stateMachine.CurrentState);
        speed = player.moveSpeed; 
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void HandleInput()
    {
        base.HandleInput();
        grounded = player.CheckCollisionOverlap(player.groundCheck.position, player.groundCheckRadius);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        player.Move(speed);  
    }
}
