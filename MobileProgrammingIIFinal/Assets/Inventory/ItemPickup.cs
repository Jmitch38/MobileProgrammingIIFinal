using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(this.gameObject);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if(Input.GetKey(KeyCode.E))
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
