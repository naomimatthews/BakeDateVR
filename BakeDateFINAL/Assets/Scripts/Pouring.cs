using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Pouring : MonoBehaviour
{

    [SerializeField] public GameObject smallMilk;
    [SerializeField] public GameObject mediumMilk;
    [SerializeField] public GameObject bigMilk;
    [SerializeField] public GameObject pourEffect;

    bool pouring = false;
    bool triggerValue;

    Vector3 oldRotation;

    GenericXRController inputActions;

    private void Awake()
    {
        inputActions = new GenericXRController();
        inputActions.Enable();
    }

    void Start()
    {
        SteamVR_Actions.default_GrabPinch.AddOnStateDownListener(TriggerPressed, SteamVR_Input_Sources.Any);
        oldRotation = GameObject.transform.rotation.eulerAngles;
    }

    foreach (var device in inputDevices)
    {
        Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
    }

    private void TriggerPressed(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {

        if(oldRotation == GameObject.transform.rotation.eulerAngles)
        {
            // no change
        }
        else
        {
            oldRotation = GameObject.transform.rotation.eulerAngles;
            pourEffect = Instantiate(pourEffect, transform.position, transform.rotation);
        }
    }

    public void smallMilkPouring()
    {
    
    }

    public void mediumMilkPouring()
    {

    }

    public void bigMilkPouring()
    {

    }
}
