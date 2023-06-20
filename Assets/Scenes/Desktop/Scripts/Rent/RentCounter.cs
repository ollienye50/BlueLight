using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RentCounter : MonoBehaviour
{
    public static int rentCount = 7;
    public static int rentCost = 10;

    public static void RentCheck()
    {
        if(rentCount <= 0)
        {
            EnergyManagement.money -= rentCost;
            rentCount = 7;
            print("rent has been deducted by " + rentCost);
        }
    }
}
