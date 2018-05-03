using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    public static int GateHealth1;
    public static int GateHealth2;
    public static bool TowerSize;

    public void SmallTower()
    {
        TowerSize = true;
    }

    public void LargeTower()
    {
        TowerSize = false;
    }
}
