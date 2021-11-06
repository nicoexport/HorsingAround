using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BareMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(5f, 0f);
        
    }
}
