using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 3f;
    public float playerFeetRadius = 0.2f;
    private float direction = 0f;
    private bool isGrounded = false;

    public Transform playerFeet;
    public LayerMask groundLayer;
    private Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get directoin keypress from use
        direction = Input.GetAxis("Horizontal");

        //Move the player
        if (direction != 0)
        {
            playerRb.velocity = new Vector2(direction * speed, playerRb.velocity.y);
        }
        else
        {
            playerRb.velocity = new Vector2(0, playerRb.velocity.y);
        }

        //Character to face correct direction
        if (direction > 0) //moving right
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else if (direction < 0) //moving left
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }

        //Check if player is grounded
        isGrounded = Physics2D.OverlapCircle(playerFeet.position, playerFeetRadius, groundLayer);

        //Handle player jumping, player jumps when jump key is pressed and its not midair
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }
    }
}
