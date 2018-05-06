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
    public static float HideLowMoney;

    void Start()
    {
        LowMoney.enabled = false;
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
