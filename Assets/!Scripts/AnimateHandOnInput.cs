using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimAction;
    public InputActionProperty gripAnimAction;

    public Animator HandAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimAction.action.ReadValue<float>();
        float gripValue = gripAnimAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", triggerValue);
        HandAnimator.SetFloat(name: "Grip", gripValue);
        Debug.Log(triggerValue);
    }
}
