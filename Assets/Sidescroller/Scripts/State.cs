using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class State
{
    public StateMachine stateMachine;
    public Player player;


    // Constructor for the state taking in a stateMachine its assigned to and a character its manipulating
    public State(StateMachine stateMachine, Player player)
    {
        this.stateMachine = stateMachine;
        this.player = player;
    }

    // Method getting called by the SM when entering the state
    public virtual void Enter()
    {
    
    }

    // Method getting called by the SM when exiting the state
    public virtual void Exit()
    {

    }

    // Method used to handle input getting called in the Update() method of the character
    public virtual void HandleInput()
    {

    }

    // Method used for updating the logic of the SM getting called in the Update() method of the character (change states here)
    public virtual void LogicUpdate()
    {

    }

    // Method used to manipulate the physics of the character. getting called in the FixedUpdate() method in the character
    public virtual void PhysicsUpdate()
    {

    }
}

