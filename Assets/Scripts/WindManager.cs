using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    public GameObject playerPrefab;

    public static WindManager instance;

    private float x_diff;
    private float y_diff;
    private float hypo;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        // Finds player object every frame with its name
        GameObject player = GameObject.Find(playerPrefab.name);

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 playerPos = player.transform.position;

        // Updates distance of player to cursor in X and Y axes every frame
        x_diff = playerPos.x - cursorPos.x;

        y_diff = playerPos.y - cursorPos.y;

        // Calculates hypoteneuse with pythagoras theorem
        hypo = Mathf.Sqrt(x_diff * x_diff + y_diff * y_diff);

    }

    public float VelX()
    {
        // Calculates vector proportion in horizontal direction
        return x_diff / hypo;
    }

    public float VelY()
    {
        // Calculates vector proportion in vertical direction
        return y_diff / hypo;
    }
}
