using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Cinemachine;

public class FirePoint : MonoBehaviour
{

    public GameObject wind;

    private bool toggle = true;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KeyToggle();
        }
    }

    void FixedUpdate()
    {
        
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float x = cursorPos.x;
        float y = cursorPos.y;

        transform.position = new Vector2(x, y);

        if (toggle)
        {

            Instantiate(wind, transform.position, transform.rotation);
            Instantiate(wind, new Vector3(x + 0.15f, y + 0.1f, transform.position.z), transform.rotation);
            Instantiate(wind, new Vector3(x - 0.15f, y - 0.1f, transform.position.z), transform.rotation);

        }
    }

    private void KeyToggle()
    {
        if (toggle)
        {
            toggle = false;
        } else
        {
            toggle = true;
        }
    }

}
