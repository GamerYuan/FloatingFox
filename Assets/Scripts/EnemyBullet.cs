using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float dieTime;

    void Start()
    {
        StartCoroutine(CountDownTimer());
    }

    void OnCollisionEnter2D(Collision2D col) {
        Destroy(gameObject);
    }


    IEnumerator CountDownTimer() {
        yield return new WaitForSeconds(dieTime);

        Destroy(gameObject);
    }
}
