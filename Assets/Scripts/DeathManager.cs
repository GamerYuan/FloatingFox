using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public static DeathManager instance;
    [SerializeField] private GameObject redCrossPrefab;
    private GameObject cross;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void OnDeath(Vector3 pos)
    {
        cross = Instantiate(redCrossPrefab, pos, Quaternion.identity);
        cross.transform.SetParent(gameObject.transform);
    }

    public void OnClear()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
