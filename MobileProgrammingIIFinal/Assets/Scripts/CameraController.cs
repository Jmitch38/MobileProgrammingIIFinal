using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float Speed = 0.1f;

	void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across Z plane
            transform.Translate(-touchDeltaPosition.x * 0, -touchDeltaPosition.y * 0, -touchDeltaPosition.z * Speed);
        }
    }
}
