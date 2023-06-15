using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerTestLiam : MonoBehaviour
{
    public delegate void workDay();
    public static event workDay workShift;
        // Start is called before the first frame update

    public static void GoToWork()
    {
        workShift();
    }

    public delegate void streamDay();
    public static event streamDay streamSession;

    public static void GoLive()
    {
        streamSession();
    }

    public delegate void day();
    public static event day dayPassed;

    public static void NextDay()
    {
        dayPassed();
    }

}
