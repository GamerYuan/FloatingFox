using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField] private UnityEvent onCollisionEntered;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Pop":
                Debug.Log("Die");
                LevelChanger.instance.FadeToLevel(SceneManager.GetActiveScene().buildIndex);
                SFXManager.instance.playPop();
                DeathCounter.instance.addDeathCount();
                break;

            case "Finished":
                Debug.Log("Stage Clear");
                LevelChanger.instance.FadeToNextLevel();
                SFXManager.instance.playVictory();
                break;

            case "Key":
                onCollisionEntered?.Invoke();
                break;
        }
    }

}
