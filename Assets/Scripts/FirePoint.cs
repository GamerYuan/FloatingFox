using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FirePoint : MonoBehaviour
{

    public GameObject wind1;
    public GameObject wind2;
    public GameObject wind3;
    
    private Animator anim;

    public bool toggle;

    void Awake()
    {
        toggle = true;
        // SFXManager.instance.stopFan();
        SFXManager.instance.playFan();
        anim = GetComponent<Animator>();
        anim.StopPlayback();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KeyToggle();
        }

        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float x = cursorPos.x;
        float y = cursorPos.y;

        transform.position = new Vector2(cursorPos.x, cursorPos.y);
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
            SFXManager.instance.stopFan();
            anim.StartPlayback();            
        } 
        else
        {
            toggle = true;
            SFXManager.instance.playFan();
            anim.StopPlayback();
        }
    }

}
