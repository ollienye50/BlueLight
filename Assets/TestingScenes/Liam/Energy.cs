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
        EventManagerTestLiam.energyUse += Activity;
        EventManagerTestLiam.dayPassed += DayStart;
    }

    void Ondisable()
    {
        EventManagerTestLiam.energyUse -= Activity;
        EventManagerTestLiam.dayPassed -= DayStart;
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
        energy = 5;
        enerStat.text = energy.ToString();
        Debug.Log("Energy:" + energy);
        canDoThing = true;
    }

    void Activity()
    {
        if (canDoThing==true&&energy > 0) 
        {
            energy--;
            enerStat.text = energy.ToString();
        }
        else
        {
            canDoThing=false;
            Debug.Log("nope");
        }

    }
}
