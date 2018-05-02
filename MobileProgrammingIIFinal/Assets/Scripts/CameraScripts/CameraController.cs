using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public static float CamSpeedUpandDown;
    public static float CamSpeedLeftandRight;

    void Update()
    {
        transform.Translate(Vector3.forward * CamSpeedLeftandRight * Time.deltaTime);
        transform.Translate(Vector3.right * CamSpeedUpandDown * Time.deltaTime);
    }
}
