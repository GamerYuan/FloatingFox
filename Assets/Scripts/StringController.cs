using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringController : MonoBehaviour
{
    private GameObject target;
    private bool attached = false;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(attached){
            float dst = Vector3.Distance(gameObject.transform.position, target.transform.position);
            if(dst > distance){
                Vector3 vect = target.transform.position - gameObject.transform.position;
                vect = vect.normalized;
                vect *= (dst - distance);
                target.transform.position -= vect;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            target = other.gameObject;
            attached = true;
            distance = Vector3.Distance(this.gameObject.transform.position, target.transform.position);
        }
    }
}
