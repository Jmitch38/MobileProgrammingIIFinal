using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDamage : MonoBehaviour
{
    public int GateHealth;

    void Update()
    {
        GameManager.GateHealth1 = GateHealth;
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
}
