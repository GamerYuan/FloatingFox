using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.InputManagerEntry;

public class WindParticle : MonoBehaviour
{

    public float speed = 10f;
    public float delta;
    private float deltaRad;

    public GameObject playerPrefab;

    Rigidbody2D rb;

    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        deltaRad = delta * Mathf.Deg2Rad;
}

    void Update()
    {
        GameObject player = GameObject.Find(playerPrefab.name);

        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 playerPos = player.transform.position;

        float x_diff = playerPos.x - cursorPos.x;

        float y_diff = playerPos.y - cursorPos.y;

        float hypo = Mathf.Sqrt(x_diff * x_diff + y_diff * y_diff);

        float cosine = x_diff / hypo;
        float sine = y_diff / hypo;

        float x = CalculateX(sine, cosine, deltaRad);
        float y = CalculateY(sine, cosine, deltaRad);

        rb.velocity = new Vector2(x * speed, y * speed);

        Destroy(gameObject, 0.4f);

    }

    float CalculateX(float sinei, float cosinei, float d)
    {
        return cosinei * Mathf.Cos(d) - sinei * Mathf.Sin(d);
    }

    float CalculateY(float sinei, float cosinei, float d)
    {
        return cosinei * Mathf.Sin(d) + sinei * Mathf.Cos(d);
    }

}
