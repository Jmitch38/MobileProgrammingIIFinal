using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    Transform CurrentTarget;

    public int Health;
    public float TurnSpeed;
    public float ReloadTimer;

	void Update ()
    {
        LookAtEnemy();
        TargetEnemy();
	}

    void LookAtEnemy()
    {
        Vector3 direction = (CurrentTarget.transform.position - transform.position).normalized;
        Quaternion lookRot = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Time.deltaTime * TurnSpeed);
    }

    void TargetEnemy()
    {

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
}
