using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToAgent : MonoBehaviour
{
    public Transform Gate;

	void Start ()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Gate.position;
    }

}
