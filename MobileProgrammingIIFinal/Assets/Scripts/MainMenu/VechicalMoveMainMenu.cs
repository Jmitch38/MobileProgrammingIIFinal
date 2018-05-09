using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VechicalMoveMainMenu : MonoBehaviour
{
    public AudioClip SmallExplosion;
    public AudioClip LargeExplosion;
    public int Health;

    void Update()
    {
        transform.Translate(Vector3.forward * 1f * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LLaserRed")
        {
            Health -= 3;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "MLaserRed")
        {
            AudioSource.PlayClipAtPoint(LargeExplosion, transform.position);
            Health -= 2;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "SLaserRed")
        {
            AudioSource.PlayClipAtPoint(SmallExplosion, transform.position);
            Health -= 1;
            Destroy(other.gameObject);
        }
    }
}
