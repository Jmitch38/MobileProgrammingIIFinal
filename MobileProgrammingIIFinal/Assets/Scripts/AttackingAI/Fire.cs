using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //Targeting
    public Transform[] Gates;
    public Transform target;  
    float speed = 15f;

    //where lasers come from
    public Transform[] FiringSpots;
    public GameObject Laser;

    void Update()
    {
        LookAtEnemy();
        WhichGateisAlive();
        KeepFiringAssholes();
    }

    void LookAtEnemy() //gun mount turns towards enemy
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion lookRot = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Time.deltaTime * speed);
    }

    void WhichGateisAlive()
    {

    }

    void KeepFiringAssholes()
    {

    }
}
