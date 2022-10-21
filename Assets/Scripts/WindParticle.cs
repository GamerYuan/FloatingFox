using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class WindParticle : MonoBehaviour
{

    public float speed = 10f;
    public float delta;
    public float desTime;

    private float deltaRad;

    Rigidbody2D rb;

    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // Mathf defaults to Radian as unit of angle
        deltaRad = delta * Mathf.Deg2Rad;
    }

    void Start()
    {
        float x;
        float y;
        
        if (deltaRad != 0)
        {
            // Only used if there is spread for wind particle
            x = CalculateX(WindManager.instance.VelY(), WindManager.instance.VelX(), deltaRad);
            y = CalculateY(WindManager.instance.VelY(), WindManager.instance.VelX(), deltaRad);
        } 
        else
        {
            x = WindManager.instance.VelX();
            y = WindManager.instance.VelY();
        }

        // Calculates initial velocity vector of wind particles
        rb.velocity = new Vector2(x * speed, y * speed);

        // Destroys after set time to remove disruptance and ease system resources
        Destroy(gameObject, desTime);

    }

    float CalculateX(float sinei, float cosinei, float d)
    {
        // Calculates cos(i + d)
        return cosinei * Mathf.Cos(d) - sinei * Mathf.Sin(d);
    }

    float CalculateY(float sinei, float cosinei, float d)
    {
        // Calculates sin(i + d)
        return cosinei * Mathf.Sin(d) + sinei * Mathf.Cos(d);
    }

}
