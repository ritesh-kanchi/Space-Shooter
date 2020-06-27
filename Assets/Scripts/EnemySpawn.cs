using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemySpawnZone;
    public GameObject enemy;
    public bool spawning;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!spawning)
        {
            StartCoroutine(spawnEnemy());
        }
    }

    IEnumerator spawnEnemy()
    {
        spawning = true;
        Instantiate(enemy, enemySpawnZone.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(7f);
        spawning = false;
    }
}
