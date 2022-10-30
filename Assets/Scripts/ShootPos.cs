using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ShootPos : MonoBehaviour
{

    [SerializeField] private float range;
    private float disToPlayer;

    private Vector2 currentPos;
    private Vector2 playerPos;

    void Start()
    {
        currentPos = transform.position;
    }

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        playerPos = player.transform.position;
        disToPlayer = Vector2.Distance(currentPos, playerPos);

        if (disToPlayer <= range)
        {
            posRotate();
        }

    }

    private float calcAngle(float x, float y)
    {
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg;
    }

    private void posRotate()
    {
        float angle = calcAngle(playerPos.x - currentPos.x, playerPos.y - currentPos.y);

        if (angle >= 90 || angle <= -90)
        {
            transform.rotation = Quaternion.Euler(0, 180, 180 - angle);
        }
        else if (angle <= 90 || angle >= -90)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
