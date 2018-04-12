using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDamage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LLaserBlue")
        {
            GameManager.GM.GateHealth1 -= 3;
        }
        if(other.gameObject.tag == "MLaserBlue")
        {
            GameManager.GM.GateHealth1 -= 2;
        }
        if (other.gameObject.tag == "SLaserBlue")
        {
            GameManager.GM.GateHealth1 -= 1;
        }
    }
}
