using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.5f;
    private Rigidbody2D rb;
    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Pop")) 
        {
            Debug.Log("Die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.CompareTag("Finished"))
        {
            Debug.Log("Stage Clear");
            //Load Next Level
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

}
