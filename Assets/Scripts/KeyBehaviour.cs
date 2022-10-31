using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyBehaviour : MonoBehaviour
{
    [SerializeField] private UnityEvent onTriggerEnter;

    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            onTriggerEnter?.Invoke();
        }
    }
}
