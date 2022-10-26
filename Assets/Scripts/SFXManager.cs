using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource pop;
    public AudioSource fan;
    public AudioSource victory;
    public AudioSource floating;

    public static SFXManager instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance);
    }

    public void playPop()
    {
        pop.Play();
    }
    public void playFan()
    {
        fan.Play();
    }
    public void stopFan()
    {
        fan.Stop();
    }
    public void playVictory()
    {
        victory.Play();
    }
    public void playFloat()
    {
        floating.Play();
    }

}
