using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    public static int GateHealth1;
    public static int GateHealth2;
    public static bool TowerSize;
    public static int Money;
    public static bool AIWin = false;

    void Start()
    {
        Money = 1000;
    }

    void Update()
    {
        
    }

    public void SmallTower()
    {
        TowerSize = true;
    }

    public void LargeTower()
    {
        TowerSize = false;
    }
}
