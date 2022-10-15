using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FirePoint : MonoBehaviour
{

    public GameObject wind1;
    public GameObject wind2;
    public GameObject wind3;

    private bool toggle = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KeyToggle();
        }

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float x = cursorPos.x;
        float y = cursorPos.y;

        transform.position = new Vector2(x, y);
    }

    void FixedUpdate()
    {

        if (toggle)
        {
            // Toggle on/off wind particles
            Instantiate(wind1, transform.position, transform.rotation);
            Instantiate(wind2, transform.position, transform.rotation);
            Instantiate(wind3, transform.position, transform.rotation);
        }
    }

    private void KeyToggle()
    {
        if (toggle)
        {
            toggle = false;
        } 
        else
        {
            toggle = true;
        }
    }

}
