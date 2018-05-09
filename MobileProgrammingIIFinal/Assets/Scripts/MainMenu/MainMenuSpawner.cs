using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSpawner : MonoBehaviour
{
    public GameObject[] Vechicals;
    public Transform SpawnPoint;

    void Start()
    {
        InvokeRepeating("SpawnVechicals", 1f, 4f);    
    }

    void SpawnVechicals()
    {
        int Ran = Random.Range(0, Vechicals.Length);
        Instantiate(Vechicals[Ran], transform.position, transform.rotation);
    }
}
