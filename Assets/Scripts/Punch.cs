using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public GameObject punchSpawnZone;
    public GameObject punch;
    public int punchSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject currentPunch = Instantiate(punch, punchSpawnZone.transform.position, Quaternion.identity) as GameObject;
            currentPunch.GetComponent<Rigidbody>().AddForce(transform.forward * punchSpeed, ForceMode.Impulse);
            Destroy(currentPunch, 2);
        }
    }
}
