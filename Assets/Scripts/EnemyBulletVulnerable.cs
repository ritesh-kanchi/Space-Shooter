using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyBulletVulnerable : MonoBehaviour {
    private NavMeshAgent agent;
    private Transform target;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();	
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Score.score += 5;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
