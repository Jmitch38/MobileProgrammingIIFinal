using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllLasers : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LLaserBlue")
        {
            Destroy(other.gameObject);
        }
        if(other.tag == "SLaserBLue")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "MLaserBLue")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "LLaserRed")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "SLaserRed")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "MLaserRed")
        {
            Destroy(other.gameObject);
        }
    }
}
