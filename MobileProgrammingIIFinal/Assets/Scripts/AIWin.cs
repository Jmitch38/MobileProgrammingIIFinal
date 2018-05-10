using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Vechical")
        {
            GameManager.AIWin = true;
        }
    }
}
