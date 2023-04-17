using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSteering : MonoBehaviour
{
    public float wheelAngle;

    private void Update()
    {
        wheelAngle = GameObject.Find("wheel1").GetComponent<XRSteeringWheel>().wheelAngle;

        if (wheelAngle < -0.09)
        {
            transform.Rotate(0, -0.01f, 0);
        }
        else if (wheelAngle > 0.09)
        {
            transform.Rotate(0, 0.01f, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
    }

    
}
