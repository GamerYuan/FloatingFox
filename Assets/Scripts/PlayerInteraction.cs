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

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Pop":
                Vector3 pos = other.GetContact(0).point;
                DeathManager.instance.OnDeath(pos);
                LevelChanger.instance.FadeToLevel(SceneManager.GetActiveScene().buildIndex);
                SFXManager.instance.PlayPop();
                SFXManager.instance.StopFall();
                DeathCounter.instance.AddDeathCount();
                break;

            case "Finished":
                LevelChanger.instance.FadeToNextLevel();
                SFXManager.instance.PlayVictory();
                DeathManager.instance.OnClear();
                break;
        }
    }
}
