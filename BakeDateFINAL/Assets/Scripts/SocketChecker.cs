using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketChecker : MonoBehaviour
{
    public int maxChildSockets = 0;

    [SerializeField] public int countSocketsPlaced = 0;

    public GameObject light;

    public void OnSocketPlaced()
    {
        countSocketsPlaced++;
        if (countSocketsPlaced == maxChildSockets)
        {
            light.SetActive(true);
        }
    }
}
