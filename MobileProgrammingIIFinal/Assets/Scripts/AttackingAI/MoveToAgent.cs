using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToAgent : MonoBehaviour
{
    public Transform Gate;
    public int Health;

	void Start ()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Gate.position;
    }

    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LLaserRed")
        {
            Health -= 3;
        }
        if(other.gameObject.tag == "MLaserRed")
        {
            Health -= 2;
        }
        if(other.gameObject.tag == "SLaserRed")
        {
            Health -= 1;
        }
    }
}
