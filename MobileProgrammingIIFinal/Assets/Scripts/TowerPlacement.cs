using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    public GameObject SmallTower;
    public GameObject LargeTower;

    private LayerMask lm;
    private RaycastHit hit;

    private void Start()
    {
        lm = 1 << 8;
    }
    void Update()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, lm))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.gameObject == this.gameObject)
                {
                    if (GameManager.TowerSize == true)
                    {
                        if(GameManager.Money < 200)
                        {
                            UIManager.HideLowMoney += 5;
                        }
                        else
                        {
                            SmallTower = Instantiate(SmallTower, transform.position, transform.rotation);
                            GameManager.Money -= 200;
                        }
                        
                    }
                    else if (GameManager.TowerSize == false)
                    {
                        if(GameManager.Money < 350)
                        {
                            UIManager.HideLowMoney += 5;
                        }
                        else
                        {
                            LargeTower = Instantiate(LargeTower, transform.position, transform.rotation);
                            GameManager.Money -= 350;
                        }                     
                    }
                }
            }
        }
    }
}
