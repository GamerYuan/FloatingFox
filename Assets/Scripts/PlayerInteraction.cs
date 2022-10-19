using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody2D rb;
    private float direcX, direcY;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        direcX = Input.GetAxisRaw("Horizontal");
        direcY = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(direcX * moveSpeed, direcY * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Pop")) 
        {
            Debug.Log("Die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
