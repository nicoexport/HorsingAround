using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Player : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public float stamina = 100f;
    [SerializeField]
    private float staminaDecrease = 1f;

    public UnityEvent onDie;

    public GroundedState groundedState;
    public JumpingState jumpingState;


    private StateMachine movementSM;
    [SerializeField]
    private PlayerAnimCtrl animCtrl;
    [SerializeField]
    private PlayerData playerData;

    private void Start()
    {
        InitializeStates();
        ReadPlayerData();
        if (!rb) rb = GetComponent<Rigidbody2D>();
        if (!animCtrl) animCtrl = GetComponent<PlayerAnimCtrl>();
    }

    private void Update()
    {
        movementSM.CurrentState.HandleInput();
        animCtrl.SetAnimationeState(movementSM.CurrentState, rb.velocity.x, rb.velocity.y);
    }

    private void FixedUpdate()
    {
        movementSM.CurrentState.LogicUpdate();
        movementSM.CurrentState.PhysicsUpdate();

    }

    public void Move(float speed)
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime * 10f, rb.velocity.y);
        if (stamina > 0) stamina -= staminaDecrease;
        else onDie.Invoke();
        Debug.Log("Stamina: " + stamina);
    }



    public bool CheckCollisionOverlap(Vector3 point, float radius)
    {
        return Physics2D.OverlapCircle(point, radius, whatIsGround);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }

    private void InitializeStates()
    {
        movementSM = new StateMachine();
        groundedState = new GroundedState(movementSM, this);
        jumpingState = new JumpingState(movementSM, this);
        movementSM.Initialize(groundedState);
    }

    private void ReadPlayerData()
    {
        foreach (ItemSO item in playerData.items)
        {
            moveSpeed *= item.moveSpeedMulti;
            jumpForce *= item.jumpForceMulti;
            stamina += item.staminaGain;
        }
    }
}
