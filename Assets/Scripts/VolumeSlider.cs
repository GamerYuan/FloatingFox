using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioSource musicVolume;
    [SerializeField] private AudioSource[] sfxVolume;

    private float musicVol;
    private float sfxVol;
    
    // Start is called before the first frame update
    void Awake()
    {
        musicVol = musicVolume.volume;
        sfxVol = sfxVolume[1].volume;
    }

    // Update is called once per frame
    public void SetMusicVolume(float sliderValue)
    {
        musicVol = sliderValue;
        musicVolume.volume = musicVol;
    }

    public void SetSFXVolume(float sliderValue)
    {
        sfxVol = sliderValue;
        for (int i = 0; i < sfxVolume.Length; i++)
        {
            sfxVolume[i].volume = sfxVol;
        }
    }
}
