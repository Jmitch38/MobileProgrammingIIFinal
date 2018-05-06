using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToAgent : MonoBehaviour
{
    GameObject Gate1;
    GameObject Gate2;
    GameObject End;
    public int Health;
    NavMeshAgent agent;
    public AudioClip SmallExplosion;
    public AudioClip LargeExplosion;

	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        Gate1 = GameObject.FindGameObjectWithTag("Gate1");
        Gate2 = GameObject.FindGameObjectWithTag("Gate2");
        End = GameObject.FindGameObjectWithTag("End");
    }

    void Update()
    {
        if (Health <= 0)
        {
            GameManager.Money += 150;
            Destroy(gameObject);
        }

        if (GameManager.GateHealth1 > 0)
        {
            agent.destination = Gate1.transform.position;
        }
        else if (GameManager.GateHealth1 <= 0 && GameManager.GateHealth2 >= 1)
        {
            agent.destination = Gate2.transform.position;
        }
        else
        {
            agent.destination = End.transform.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LLaserRed")
        {
            Health -= 3;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "MLaserRed")
        {
            AudioSource.PlayClipAtPoint(LargeExplosion, transform.position);
            Health -= 2;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "SLaserRed")
        {
            AudioSource.PlayClipAtPoint(SmallExplosion, transform.position);
            Health -= 1;
            Destroy(other.gameObject);
        }
    }
}
