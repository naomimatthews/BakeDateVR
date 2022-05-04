using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class Pouring : MonoBehaviour
{

    [SerializeField] public GameObject milk;
    [SerializeField] public GameObject pourEffect;

    bool pouring = false;
    bool triggerValue;

    Vector3 oldRotation;

    void Start()
    {
        oldRotation = milk.transform.rotation.eulerAngles;
    }

    void Update()
    {
        if (oldRotation == milk.transform.rotation.eulerAngles)
        {
            // no rotation
        }
        else
        {
            Pour();

        }
    }

    private void Pour()
    {
        pourEffect = Instantiate(pourEffect, transform.position, transform.rotation);
        
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
