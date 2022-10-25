using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollisionEntered;
    
    private Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        switch (other.gameObject.tag) {
            case "Pop":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;

            case "Finish":
                Debug.Log("Stage Clear");
                break;

            case "Key":
                onCollisionEntered?.Invoke();
                break;
        }
    }
}
