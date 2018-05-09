using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVechical : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Vechical")
        {
            Destroy(other.gameObject);
        }
    }
}
