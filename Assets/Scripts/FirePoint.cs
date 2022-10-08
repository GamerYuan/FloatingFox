using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FirePoint : MonoBehaviour
{

    public GameObject wind;
    public GameObject player;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float x = cursorPos.x;
        float y = cursorPos.y;

        transform.position = new Vector2(x, y);

        Instantiate(wind, transform.position, transform.rotation);
        Instantiate(wind, new Vector3(x + 0.15f, y + 0.1f, transform.position.z), transform.rotation);
        Instantiate(wind, new Vector3(x - 0.15f, y - 0.1f, transform.position.z), transform.rotation);

    }

}
