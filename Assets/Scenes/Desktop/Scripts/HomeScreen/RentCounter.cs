using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RentCounter : MonoBehaviour
{
    public static RentCounter instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public int rentCount = 7;
    public int rentCost = 1000;

    public void RentCheck()
    {
        if(rentCount <= 0)
        {
            EnergyManagement.instance.money -= rentCost;
            rentCount = 7;
            print("rent has been deducted by " + rentCost);
        }
    }
}
