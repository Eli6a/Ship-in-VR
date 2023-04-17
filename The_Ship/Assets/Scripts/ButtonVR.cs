using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{

    public GameObject button;
    Vector3 initialPosition; // Vector3(0, 0.8191676f, 0);
    public Vector3 buttonMovement;
    Vector3 pressedPosition; // Vector3(0, 0.82f, 0)
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;

    void Start()
    {
        isPressed = false;
        initialPosition = button.gameObject.transform.localPosition;
        if (buttonMovement == Vector3.zero)
        {
            buttonMovement = new Vector3(0, -0.01f, 0);
        }
        pressedPosition = initialPosition + buttonMovement;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = pressedPosition;
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = initialPosition;
            onRelease.Invoke();
            isPressed = false;
        }
    }

}
