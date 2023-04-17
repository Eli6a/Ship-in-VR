using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHand : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = this.transform.GetComponent<Animator>();
    }

        // Update is called once per frame
        void Update()
    {
        switch (Input.inputString)
        {
            case "1":
                print("ThumbStickForward");
                animator.Play("ThumbStickForward");
                break;
            case "2":
                print("ThumbStickLeft");
                animator.Play("ThumbStickLeft");
                break;
            case "3":
                print("ThumbStickRight");
                animator.Play("ThumbStickRight");
                break;
            case "4":
                print("BumperPressed");
                animator.Play("BumperPressed");
                break;
            case "5":
                print("TriggerPressed");
                animator.Play("TriggerPressed");
                break;
            case " ":
                print("ResetAnimation");
                animator.Play("ResetAnimation");
                break;

        }
    }
}