using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    public GameObject laserPrefab;

    public float laserSpeed = 500f;

    public Transform laserPos;

    public bool canShoot = true;

    public float seconds = 0.5f;

    public void Fire()
    {
        if (canShoot)
        {
            GameObject laser = Instantiate(laserPrefab, laserPos.position, transform.rotation);
            Rigidbody2D laserRB = laser.GetComponent<Rigidbody2D>();
            laserRB.AddForce(transform.up * laserSpeed);
            StartCoroutine(SlowShooting());


        }

    }

    public void Update()
    {  
        if (Input.GetKeyDown("space"))
        {
            Fire();
        }
    }

    public IEnumerator SlowShooting()
    {
        canShoot = false;
        yield return new WaitForSeconds(seconds);
        canShoot = true;
    }
}
