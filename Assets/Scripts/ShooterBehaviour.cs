using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float range;
    [SerializeField] private Transform playerCharacter;

    private float disToPlayer; 
    private bool canShoot;
    private Vector2 moveDirection;

    public Transform shootPos;
    public float timeBTWShots, shootSpeed;

    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        disToPlayer = Vector2.Distance(transform.position, playerCharacter.position);

        if (disToPlayer <= range) {
            if (canShoot) {
                StartCoroutine(Shoot());
            }
        }
    }

    IEnumerator Shoot() {
        canShoot = false;

        yield return new WaitForSeconds(timeBTWShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);

        moveDirection = (playerCharacter.transform.position - transform.position).normalized * shootSpeed;

        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(moveDirection.x, moveDirection.y);
        canShoot = true;
    }
}
