using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpikeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveTime;

    private bool moveYet;

    Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        moveYet = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") && moveYet == false) {
            moveYet = true;
            StartCoroutine(moveSpike());
        }
    }

     void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "Platform" && moveYet) {
            moveSpeed = 0;
        }
    }
    //Use rb.velocity but change orientation of the object
    IEnumerator moveSpike() {
        while (moveTime >= 0) {
            moveTime -= Time.deltaTime;
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            yield return null;
        }
    }
}
