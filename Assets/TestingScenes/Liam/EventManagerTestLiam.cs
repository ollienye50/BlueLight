using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerTestLiam : MonoBehaviour
{
    public delegate void energyTotal();
    public static event energyTotal energyUsed;
        // Start is called before the first frame update

    public static void ConsumeEnergy()
    {
        energyUsed();
    }

    public delegate void day();
    public static event day dayPassed;

    public static void NextDay()
    {
        dayPassed();
    }

}
