using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    //under any circumstance DO NOT TOUCH THIS CODE
    #region
    private List<Transform> targets = new List<Transform>();
    private Transform _primaryTarget;
    //finds an important target to focus on and caches the reference
    public Transform Target
    {
        get
        {
            if (_primaryTarget == null)
            {
                // clean the targets list by removing each target transform
                // that is nulled due to the gameobject already being destroyed
                targets.RemoveAll(eachTarget => { return eachTarget == null; });

                if (targets.Count > 0)
                {
                    // find the first element that would cause the lambada to return true
                    // you can change this later to allow the tower to prioritize different targets
                    _primaryTarget = targets.Find(target => { return true; });
                }
            }
            return _primaryTarget;
        }
    }
    #endregion 

    [Header("--Turret Stats--")]
    public int Health;
    public float TurnSpeed;
    public float ReloadTimer;

    [Header("--Lasers--")]
    public Transform[] LaserSpots;
    public GameObject Laser; 

    void Update()
    {
        TurnEnemy();
        FireAssholes();
    }

    void TurnEnemy()
    {
        Vector3 direction = (Target.transform.position - transform.position).normalized;
        Quaternion lookRot = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Time.deltaTime * TurnSpeed);
    }

    void FireAssholes()
    {
        if (ReloadTimer <= 0)
        {
            for (int i = 0; i < LaserSpots.Length; i++)
            {
                Instantiate(Laser, LaserSpots[i].transform.position, LaserSpots[i].transform.rotation);
            }
            ReloadTimer += 5;
        }
    }

    void FixedUpdate()
    {
        if (ReloadTimer > 0)
        {
            ReloadTimer -= 1 * Time.deltaTime;
        }
        else
        {
            ReloadTimer = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vechical"))
        {
            targets.Add(other.transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //in case it was the primary target that leaves the Tower's range
        if (ReferenceEquals(_primaryTarget, other.transform))
        {
            _primaryTarget = null;
        }
        targets.Remove(other.transform);
    }
}
