using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public Transform SpawnLocation;
    public Text WaveNumber;
    bool IsPlayerReady;
    int CurrentWave;
    int ran;
    public float time;

    public GameObject[] Wave;

    void Start()
    {
        IsPlayerReady = false;
        CurrentWave = 1;
        ran = 0;
        time = 0;
    }

    void Update ()
    {
        if(GameManager.AIWin == false)
        {
            if (time > 32f)
            {
                IsPlayerReady = false;
                CancelInvoke("SpawnEnemies");
                time = 0f;
                CurrentWave += 1;
            }
        }
		
        if(IsPlayerReady == false)
        {
            WaveNumber.text = "Wave: Wave ended!";
        }
        else
        {
            WaveNumber.text = "Wave: " + CurrentWave;
        }
        
        if(CurrentWave >= 4)
        {
            GameManager.PlayerWin = true;
        }
	}

    void FixedUpdate()
    {
        if(IsPlayerReady == true)
        {
            time += 1f * Time.deltaTime;
        }
    }

    public void PlayerIsReady()
    {
        IsPlayerReady = true;
        InvokeRepeating("SpawnEnemies", 0f, 4f);
    }

    void SpawnEnemies()
    {
        ran = Random.Range(0, Wave.Length);
        Instantiate(Wave[ran], SpawnLocation.position, SpawnLocation.rotation);
    }
}
