using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPunchVulnerable : MonoBehaviour{
    private NavMeshAgent agent;
    private Transform target;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Punch"))
        {
            Score.score += 10;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
