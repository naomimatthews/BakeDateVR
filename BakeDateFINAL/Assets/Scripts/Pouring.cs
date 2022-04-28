using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class Pouring : MonoBehaviour
{

    [SerializeField] public GameObject smallMilk;
    [SerializeField] public GameObject mediumMilk;
    [SerializeField] public GameObject bigMilk;
    [SerializeField] public GameObject pourEffect;

    bool pouring = false;
    bool triggerValue;

    Vector3 oldRotation;


    private void Awake()
    {
  
    }

    void Start()
    {

    }

    private void TriggerPressed()
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
