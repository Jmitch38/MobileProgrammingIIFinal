using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool XorZ;
    public float SpeedSet;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(XorZ == true)
        {
            CameraController.CamSpeedUpandDown = SpeedSet;
        }

        if(XorZ == false)
        {
            CameraController.CamSpeedLeftandRight = SpeedSet;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        CameraController.CamSpeedLeftandRight = 0;
        CameraController.CamSpeedUpandDown = 0;
    }
}
