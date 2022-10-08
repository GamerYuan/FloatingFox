using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class WindParticle : MonoBehaviour
{

    public float speed = 10f;

    Rigidbody2D rb;

    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GameObject player = GameObject.Find("TestPlayer");

        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 playerPos = player.transform.position;

        float x_diff = playerPos.x - cursorPos.x;

        float y_diff = playerPos.y - cursorPos.y;

        float hypo = Mathf.Sqrt(x_diff * x_diff + y_diff * y_diff);

        rb.velocity = new Vector2(x_diff / hypo * speed, y_diff / hypo * speed);

        Destroy(gameObject, 0.4f);

    }

}
