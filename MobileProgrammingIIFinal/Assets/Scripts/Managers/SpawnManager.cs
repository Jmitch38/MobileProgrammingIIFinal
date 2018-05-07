using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform SpawnLocation;
    int CurrentWave;
    float SpawnTimer;
    public bool IsPlayerReady;
    int arrayLength;

    public GameObject[] Wave;

    void Start()
    {
        IsPlayerReady = false;
        arrayLength = 0;
        SpawnTimer = 0;
    }
    void Update ()
    {
		if(IsPlayerReady == true && SpawnTimer <= 0)
        {
            if (arrayLength < Wave.Length)
            {
                Instantiate(Wave[arrayLength], SpawnLocation.transform.position, SpawnLocation.transform.rotation);
                SpawnTimer += 3;
                arrayLength += 1;
            }
            else if (arrayLength > Wave.Length)
            {
                IsPlayerReady = false;
                arrayLength = 0;
            }
        }
	}

    void FixedUpdate()
    {
        if(SpawnTimer > 0)
        {
            SpawnTimer -= 1 * Time.deltaTime;
        }
        else
        {
            SpawnTimer = 0;
        }
    }

    public void PlayerIsReady()
    {
        IsPlayerReady = true;
    }
}
