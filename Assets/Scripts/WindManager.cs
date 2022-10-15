using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject playerPrefab;

    public float x_diff;
    public float y_diff;
    public float hypo;
    public static WindManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find(playerPrefab.name);

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 playerPos = player.transform.position;

        x_diff = playerPos.x - cursorPos.x;

        y_diff = playerPos.y - cursorPos.y;

        Debug.Log("Wind Manager" + x_diff);

        hypo = Mathf.Sqrt(x_diff * x_diff + y_diff * y_diff);

    }

    public float VelX()
    {
        return x_diff / hypo;
    }

    public float VelY()
    {
        return y_diff / hypo;
    }
}
