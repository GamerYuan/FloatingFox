using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource.Play();
        DontDestroyOnLoad(gameObject);
    }

}
