using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float range;
    [SerializeField] private Transform playerCharacter;
    [SerializeField] private Transform gun;

    private float disToPlayer; 
    private bool canShoot;
    private Vector2 direction;
    private Vector2 moveDirection;

    public Transform shootPos;
    public float timeBTWShots, shootSpeed;

    void Start()
    {
        canShoot = true;
    }

    void FixedUpdate() {
        disToPlayer = Vector2.Distance(transform.position, playerCharacter.position);

        direction = (playerCharacter.transform.position - transform.position);

        if (disToPlayer <= range) {
            if (canShoot) {
                StartCoroutine(Shoot());
            }
            rotateGun();
        }
    }

    private void rotateGun()
    {
        float rotationZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if (rotationZ < -90 || rotationZ > 90)
        {
            if (gun.transform.eulerAngles.y == 0)
            {
                gun.transform.rotation = Quaternion.Euler(180, 0f, -rotationZ);
            }
        }
    }

    IEnumerator Shoot() {
        canShoot = false;

        yield return new WaitForSeconds(timeBTWShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);

        moveDirection = direction.normalized * shootSpeed;

        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(moveDirection.x, moveDirection.y);
        canShoot = true;
    }
}
