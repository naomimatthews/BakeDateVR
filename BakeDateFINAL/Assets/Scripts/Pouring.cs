using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouring : MonoBehaviour
{

    [SerializeField] public GameObject smallMilk;
    [SerializeField] public GameObject mediumMilk;
    [SerializeField] public GameObject bigMilk;
    [SerializeField] public GameObject liquid;

    bool pouring = false;
    bool triggerValue;

    void Start()
    {
        var gameControllers = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesWithRole(UnityEngine.XR.InputDeviceRole.GameController.gameControllers);

        if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValue) && triggerValue)
        {
            Debug.Log("Trigger button is pressed!");

            // GameObject newLiquid = Instantiate(liquid, trnsform.down, transform.rotation);
            //newLiquid.GetComponent<Rigidbody>().AddForce(transform.down, ForceMode.Impulse);
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
