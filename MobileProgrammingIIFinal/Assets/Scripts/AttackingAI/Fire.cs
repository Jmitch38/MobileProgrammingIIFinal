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
        ResetReloadTimer();
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
            Instantiate(Laser, FiringSpots[0].transform.position, FiringSpots[0].transform.rotation);
            Instantiate(Laser, FiringSpots[1].transform.position, FiringSpots[1].transform.rotation);
            ReloadTimer += 5;
        }
    }

    void ResetReloadTimer()
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
