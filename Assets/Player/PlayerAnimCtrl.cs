using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimCtrl : MonoBehaviour
{
    [SerializeField]
    private string currentAnimState;

    private Animator animator;

    const string idle = "Idle";
    const string running = "Run";
    const string falling = "Fall";
    const string jumping = "Jump";
    const string pause = "Dead";

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetAnimationeState(State state, float horizontalVelocity, float verticalVelocity)
    {
        string newAnimState = idle;

        switch (state.ToString())
        {
            case "GroundedState":
                if (Mathf.Abs(horizontalVelocity) >= 0.1f) newAnimState = running;
                else newAnimState = idle;
                break;


            case "JumpingState":
                if (verticalVelocity > 0f) newAnimState = jumping;
                else newAnimState = falling;
                break;
            
            case "PauseState":
                newAnimState = pause;
                break;

            default:
                newAnimState = idle;
                break;
        }

        if (newAnimState == currentAnimState) return;
        animator.Play(newAnimState, 0);
        currentAnimState = newAnimState;
    }
}
