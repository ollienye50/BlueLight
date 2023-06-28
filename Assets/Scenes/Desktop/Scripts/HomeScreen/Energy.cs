using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public int energy;
    public Text enerStat;
    public bool canDoThing = false;
    // Start is called before the first frame update
    
    void OnEnable()
    {
        EventManagerTestLiam.instance.energyUseWork.AddListener(ActivityWork);
        EventManagerTestLiam.instance.energyUseStream.AddListener(ActivityStream);
        EventManagerTestLiam.instance.dayPassed.AddListener(DayStart);
    }

    void Ondisable()
    {
        EventManagerTestLiam.instance.energyUseWork.RemoveListener(ActivityWork);
        EventManagerTestLiam.instance.energyUseStream.RemoveListener(ActivityStream);
        EventManagerTestLiam.instance.dayPassed.RemoveListener(DayStart);
    }

    void Start()
    {
        canDoThing = true;
        DayStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DayStart()
    {
        energy = 3;
        enerStat.text = energy.ToString();
        Debug.Log("Energy:" + energy);
        canDoThing = true;
    }

    void ActivityWork()
    {
        if (canDoThing==true&&energy > 0) 
        {
            energy--;
            enerStat.text = energy.ToString();
            EventManagerTestLiam.instance.GoToWork();
        }
        else
        {
            canDoThing=false;
            Debug.Log("nope");
        }

    }

    void ActivityStream()
    {
        if (canDoThing == true && energy > 0)
        {
            energy--;
            enerStat.text = energy.ToString();
            EventManagerTestLiam.instance.GoLive();
        }
        else
        {
            canDoThing = false;
            Debug.Log("nope");
        }

    }
}
