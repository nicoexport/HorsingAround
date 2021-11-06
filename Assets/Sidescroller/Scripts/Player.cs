using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    public Rigidbody2D rb; 
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    


    public GroundedState groundedState;
    public JumpingState jumpingState;


    private StateMachine movementSM;
    [SerializeField]   
    private PlayerData playerData;

    private void Start()
    {
        movementSM = new StateMachine();
        groundedState = new GroundedState(movementSM, this);
        jumpingState = new JumpingState(movementSM, this);
        movementSM.Initialize(groundedState); 
        if(!rb) rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movementSM.CurrentState.HandleInput();
    }

    private void FixedUpdate()
    {
        movementSM.CurrentState.LogicUpdate();
        movementSM.CurrentState.PhysicsUpdate();
    }

    public void Move(float speed)
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime * 10f, rb.velocity.y);
    }

    public bool CheckCollisionOverlap(Vector3 point, float radius)
    {
        return Physics2D.OverlapCircle(point, radius, whatIsGround);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
    
}
