using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public static DeathCounter instance;
    [SerializeField] private TMP_Text _deathCounter;
    private int death;
    
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance);
        death = 0;
    }

    void OnLevelWasLoaded()
    {
        _deathCounter.text = "Death: " + death;
    }

    // Update is called once per frame
    public void addDeathCount()
    {
        death += 1;
        Debug.Log("Death = " + death);
    }

    public void resetDeathCount()
    {
        death = 0;
        Debug.Log("Death reset");
    }
}
