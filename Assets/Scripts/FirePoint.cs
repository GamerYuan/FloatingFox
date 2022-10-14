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
        } else
        {
            toggle = true;
        }
    }

}
