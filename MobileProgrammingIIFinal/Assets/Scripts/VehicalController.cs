using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicalController : MonoBehaviour
{
    int CurrentWayPoint;

    public float speed;
    public float turnspeed;

    void Start()
    {
        Transform[] Road = GameObject.Find("Manager's").GetComponent<WayPoint>().WayPoints;
        CurrentWayPoint = 0;
    }

    void Update()
    {
        if (gameObject.transform.position != Road[CurrentWayPoint])
        {
            MoveTowards();
        }
    }

    void MoveTowards()
    {

    }
}
