using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager UI;
    public Text Money;
    public Text YouLose;
    public Text YouWin;
    public Text LowMoney;
    public Button Retry;
    public Button Exit;
    public Button LightTower;
    public Button HeavyTower;
    public Button start;
    public static float HideLowMoney;

    void Start()
    {
        LowMoney.enabled = false;      
        YouLose.enabled = false;
        YouWin.enabled = false;
        Retry.interactable = false;
    }

    void Update()
    {
        Money.text = "Credits: " + GameManager.Money;
        if(HideLowMoney > 0)
        {
            LowMoney.enabled = true;
        }
        else
        {
            LowMoney.enabled = false;
        }

        if (GameManager.TowerSize == true)
        {
            LightTower.interactable = false;
            HeavyTower.interactable = true;
        }
        else if (GameManager.TowerSize == false)
        {
            LightTower.interactable = true;
            HeavyTower.interactable = false;
        }

        if (GameManager.AIWin == true)
        {
            YouLose.enabled = true;
            Retry.interactable = true;
            start.interactable = false;
        }

        if(GameManager.PlayerWin == true)
        {
            YouWin.enabled = true;
            start.interactable = false;
            Retry.interactable = true;
        }
    }

    void FixedUpdate()
    {
        if(HideLowMoney > 0)
        {
            HideLowMoney -= 1 * Time.deltaTime;
        }
        else
        {
            HideLowMoney = 0;
        }
    }
}
