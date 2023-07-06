using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManagerTestLiam : MonoBehaviour
{
    public static EventManagerTestLiam instance;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        } 
        else
        {
            instance = this;
            Debug.Log(instance.name);
        }
    }

    //public delegate void workDay();
    public UnityEvent workShift;
        // Start is called before the first frame update

    public void GoToWork()
    {
        workShift.Invoke();
    }

   // public delegate void streamDay();
    public UnityEvent streamSession;

    public void GoLive()
    {
        streamSession.Invoke();
    }

    //public delegate void day();
    public UnityEvent dayPassed;

    public void NextDay()
    {
        dayPassed.Invoke();
    }

   // public delegate void energyStatistic();
    public UnityEvent energyUseWork;

    public void EnergySupplyWork()
    {
        energyUseWork.Invoke();
    }

    public UnityEvent energyUseStream;

    public void EnergySupplyStream()
    {
        energyUseStream.Invoke();
    }

    public UnityEvent camPurchased;

    public void BuyWebcam()
    {
        camPurchased.Invoke();
    }
}
