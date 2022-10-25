using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //Automatically assign components to the player
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Animator))]

//declaring all the variables
public class TempMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed; //[SerializeField] allows for adjustment directly from the editor 

    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    private float horizontal;
    private float vertical;
    
    //Run before update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); //assign player as rigidBody
        boxCollider = GetComponent<BoxCollider2D>(); //assign player as BoxCollider2D
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //Get input from the arrow keys for horizontal movement
        vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizontal * moveSpeed, vertical* moveSpeed); //define player velocity as vector form
    }
}