using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Vector2 movement;
    Rigidbody2D playerRigid;
    Vector2 speed = new Vector2(5, 10);

    // Start is called before the first frame update
    void Start ()
    {
        playerRigid = GetComponent<Rigidbody2D> ();
    }
    void Update ()
    {
        float inputX = Input.GetAxis ("Horizontal");
        float inputY = Input.GetAxis ("Vertical");
        movement = new Vector2 (
            speed.x * inputX,
            speed.y * inputY);
        playerRigid.velocity = movement;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        print("Enter");
        if(other.gameObject.tag == "Hazards")
        {
            print("restart");
            SceneManager.LoadScene("SampleLevel2");
            playerRigid.velocity = new Vector2(0, 0);
        }
    }
}
