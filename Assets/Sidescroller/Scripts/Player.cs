using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private StateMachine movementSM;

    private void Update()
    {
        movementSM.CurrentState.HandleInput();
    }

    private void FixedUpdate()
    {
        movementSM.CurrentState.LogicUpdate();
        movementSM.CurrentState.PhysicsUpdate();
    }
}
