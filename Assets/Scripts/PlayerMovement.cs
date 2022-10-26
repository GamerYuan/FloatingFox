using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float riseSpeed;
    public float stopSpeed;
    public float drag = 0.1f;

    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Dampens player downward motion and allows levitation
        if (rb.velocity.y < riseSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + (riseSpeed * drag));
        }
        if (rb.velocity.y > riseSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - (riseSpeed * drag));
        }
        if (rb.velocity.x < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x + (stopSpeed * drag), rb.velocity.y);
        }
        if (rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x - (stopSpeed * drag), rb.velocity.y);
        }
    }
}
