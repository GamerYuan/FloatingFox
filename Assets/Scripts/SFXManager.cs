using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] private AudioSource pop;
    [SerializeField] private AudioSource fan;
    [SerializeField] private AudioSource victory;
    [SerializeField] private AudioSource floating;
    [SerializeField] private AudioSource shoot;
    [SerializeField] private AudioSource fall;
    

    public static SFXManager instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance);
    }

    public void PlayPop()
    {
        pop.Play();
    }
    public void PlayFan()
    {
        fan.Play();
    }
    public void StopFan()
    {
        fan.Stop();
    }
    public void PlayVictory()
    {
        victory.Play();
    }
    public void PlayFloat()
    {
        floating.Play();
    }
    public void PlayShoot()
    {
        shoot.Play();
    }
    public void PlayFall()
    {
        fall.Play();
    }
    public void StopFall()
    {
        fall.Stop();
    }
}
