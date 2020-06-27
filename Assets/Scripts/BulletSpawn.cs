using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bulletSpawnZone;
    public GameObject bullet;
    public int bulletSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject currentBullet = Instantiate(bullet, bulletSpawnZone.transform.position, Quaternion.identity) as GameObject;
            currentBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
            Destroy(currentBullet, 2);
        }
    }
}
