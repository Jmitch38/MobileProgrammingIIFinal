using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //Targeting
    public Transform[] Gates;
    public Transform target;
    public GameObject Laser;
    float speed = 1f;

    //where lasers come from
    public Transform[] FiringSpots;  

    void Update()
    {
        LookAtEnemy();
        WhichGateisAlive();
        KeepFiringAssholes();
    }

    void LookAtEnemy() //gun mount turns towards enemy
    {
        Vector3 targetDir = target.position - transform.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        // Move our position a step closer to the target.
        transform.rotation = Quaternion.LookRotation(newDir);
    }

    void WhichGateisAlive()
    {

    }

    void KeepFiringAssholes()
    {

    }
}
