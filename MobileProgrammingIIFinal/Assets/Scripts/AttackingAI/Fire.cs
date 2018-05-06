using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //Targeting
    GameObject Gate1;
    GameObject Gate2;
    GameObject End;
    Vector3 Currenttarget;
    public float speed;

    //where lasers come from
    public Transform[] FiringSpots;
    public GameObject Laser;
    public float ReloadTimer;

    void Start()
    {
        Gate1 = GameObject.FindGameObjectWithTag("Gate1");
        Gate2 = GameObject.FindGameObjectWithTag("Gate2");
        End = GameObject.FindGameObjectWithTag("End");
    }

    void Update()
    {
        LookAtEnemy();
        WhichGateisAlive();
        KeepFiringAssholes();
    }

    void LookAtEnemy() //gun mount turns towards enemy
    {
        Vector3 direction = (Currenttarget - transform.position).normalized;
        Quaternion lookRot = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Time.deltaTime * speed);
    }

    void WhichGateisAlive()
    {
        if(GameManager.GateHealth1 > 0)
        {
            Currenttarget = Gate1.transform.position;
        }
        else if (GameManager.GateHealth1 <= 0 && GameManager.GateHealth2 > 1)
        {
            Currenttarget = Gate2.transform.position;
        }
        else
        {
            Currenttarget = End.transform.position;
        }
    }

    void KeepFiringAssholes()
    {
        float Distance = Vector3.Distance(Currenttarget, transform.position);
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
