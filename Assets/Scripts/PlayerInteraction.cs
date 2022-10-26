using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{

    private Rigidbody2D rb;
    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Pop")) 
        {
            Debug.Log("Die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SFXManager.instance.playPop();
        }

        if (other.gameObject.CompareTag("Finished"))
        {
            Debug.Log("Stage Clear");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SFXManager.instance.playVictory();
        }
    }
}
