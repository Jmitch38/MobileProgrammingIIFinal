using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDamage : MonoBehaviour
{
    int GateHealth;

    void Start()
    {
        GateHealth = GameManager.GM.GateHealth1;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LLaserBlue")
        {
            GateHealth -= 3;
        }
        if(other.gameObject.tag == "MLaserBlue")
        {
            GateHealth -= 2;
        }
        if (other.gameObject.tag == "SLaserBlue")
        {
            GateHealth -= 1;
        }
    }

    void Update()
    {
        GameManager.GM.GateHealth1 = GateHealth;
    }
}
