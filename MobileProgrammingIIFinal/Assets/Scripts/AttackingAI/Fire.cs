using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //Targeting
    public Transform[] Gates;
    public Transform Currenttarget;
    public float speed;

    //where lasers come from
    public Transform[] FiringSpots;
    public GameObject Laser;
    public float ReloadTimer;

    void Update()
    {
        LookAtEnemy();
        WhichGateisAlive();
        KeepFiringAssholes();
    }

    void LookAtEnemy() //gun mount turns towards enemy
    {
        Vector3 direction = (Currenttarget.transform.position - transform.position).normalized;
        Quaternion lookRot = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Time.deltaTime * speed);
    }

    void WhichGateisAlive()
    {

    }

    void KeepFiringAssholes()
    {
        float Distance = Vector3.Distance(Currenttarget.position, transform.position);
        if(Distance <= 5 && ReloadTimer <= 0)
        {
            for (int i = 0; i < FiringSpots.Length; i++)
            {
                Instantiate(Laser, FiringSpots[i].transform.position, FiringSpots[i].transform.rotation);
            }
            ReloadTimer += 5;
        }
    }

    void FixedUpdate()
    {
        if(ReloadTimer > 0)
        {
            ReloadTimer -= 1 * Time.deltaTime;
        }
        else
        {
            ReloadTimer = 0;
        }
    }
}
