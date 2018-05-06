using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDamage2 : MonoBehaviour
{
    int health;
    public bool Gate1orGate2;
    public AudioClip Siren;

    void Start()
    {
        health = 4;
        GameManager.GateHealth1 = 4;
        GameManager.GateHealth2 = 4;
    }

    void Update()
    {
        if(Gate1orGate2 == true)
        {
            GameManager.GateHealth1 = health;
        }
        else if(Gate1orGate2 == false)
        {
            GameManager.GateHealth2 = health;
        }

        if(health <= 0)
        {
            AudioSource.PlayClipAtPoint(Siren, transform.position);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SLaserBlue")
        {
            health -= 1;
            Destroy(other.gameObject);
        }
        if(other.tag == "MLaserBlue")
        {
            health -= 2;
            Destroy(other.gameObject);
        }
        if(other.tag == "LLaserBlue")
        {
            health -= 3;
            Destroy(other.gameObject);
        }
    }
}
