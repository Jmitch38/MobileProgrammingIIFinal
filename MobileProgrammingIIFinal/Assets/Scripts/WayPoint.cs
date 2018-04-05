using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public static WayPoint WP;
    public GameObject[] Waypoint;

    private void Awake()
    {
        if (!WP) WP = this;
        else Destroy(this);
    }


    private void Start()
    {
        Waypoint = GameObject.FindGameObjectsWithTag("Waypoint");
    }
    
}
