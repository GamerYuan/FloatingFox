using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float dieTime;
    public float damage;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownTimer());
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col) {
        Destroy(gameObject);
    }


    IEnumerator CountDownTimer() {
        yield return new WaitForSeconds(dieTime);

        Destroy(gameObject);
    }
}
