using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float fallMultiplier = 1.025f;
    public float riseSpeed;
    public float drag = 0.1f;

    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (rb.velocity.y < 0)
        //{
        //    rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        //}
        if (rb.velocity.y < riseSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + (riseSpeed * drag));
        } 
    }
}
