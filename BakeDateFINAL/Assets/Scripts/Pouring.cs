using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class Pouring : MonoBehaviour
{

    [SerializeField] public GameObject milk;
    [SerializeField] public GameObject pourEffect;
    [SerializeField] public Transform pourPoint;

    bool pouring = false;
    bool triggerValue;

    private float pourTime = 2.0f;
    private float timer = 0.0f;

    Vector3 rotationEuler;

    void Start()
    {
        pourEffect.SetActive(false);
        rotationEuler = gameObject.transform.localRotation.eulerAngles;
    }

    void Update()
    {
        if (gameObject.transform.localRotation.eulerAngles.z > 90.0f 
            || gameObject.transform.localRotation.eulerAngles.z < -90.0f 
            || gameObject.transform.localRotation.eulerAngles.x > 90.0f 
            || gameObject.transform.localRotation.eulerAngles.x < -90.0f)
        {
            Pour();
        }
        else
        {
            pourEffect.SetActive(false);
        }
    }

     void Pour()
    {
        pourEffect.SetActive(true);

        //timer += Time.deltaTime;

        //if (timer > pourTime)
        //{

        //}

    }

     void OnCollisionEnter(Collision collision)
     {
        
     }
}
