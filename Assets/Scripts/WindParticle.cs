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
    public float desTime;

    public GameObject playerPrefab;

    private float deltaRad;

    Rigidbody2D rb;

    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        deltaRad = delta * Mathf.Deg2Rad;
    }

    void Update()
    {
        float x;
        float y;
        
        if (deltaRad != 0)
        {
            x = CalculateX(WindManager.instance.VelY(), WindManager.instance.VelX(), deltaRad);
            y = CalculateY(WindManager.instance.VelY(), WindManager.instance.VelX(), deltaRad);
        } 
        else
        {
            x = WindManager.instance.VelX();
            y = WindManager.instance.VelY();
        }

        rb.velocity = new Vector2(x * speed, y * speed);

        Destroy(gameObject, desTime);

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
