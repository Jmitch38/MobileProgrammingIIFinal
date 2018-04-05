using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicalController : MonoBehaviour
{
    int CurrentWayPoint;
    Vector3 Temp;
    public float speed;
    public float turnspeed;

    void Start()
    {
        CurrentWayPoint = 0;
    }

    void Update()
    {
        Vector3 Temp = WayPoint.WP.Waypoint[CurrentWayPoint].transform.position;
        if (this.gameObject.transform.position != Temp)
        {
            MoveTowards();
        }
    }

    void MoveTowards()
    {
        transform.position += Vector3.forward * -speed * Time.deltaTime;
        Vector3.RotateTowards(transform.forward, Temp, 360,turnspeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Waypoint")
        {
            CurrentWayPoint += 1;
            print(CurrentWayPoint);
            print(Temp);
        }
    }
}
