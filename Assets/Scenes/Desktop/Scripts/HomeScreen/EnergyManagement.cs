using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManagement : MonoBehaviour
{
    // public TestStream potat;
    //public Energy energyScript;
    public int day;
    public int money;
    public int happiness;
    public Text monStat;
    public Text HappStat;
    public Text dayStat;


    // Start is called before the first frame update

    void OnEnable()
    {
        EventManagerTestLiam.workShift += Shift;
        EventManagerTestLiam.streamSession += Live;
        EventManagerTestLiam.dayPassed += DayStart;
    }

    void OnDisable()
    {
        EventManagerTestLiam.workShift -= Shift;
        EventManagerTestLiam.streamSession += Live;
        EventManagerTestLiam.dayPassed -= DayStart;
    }

    void Start()
    {
        DayStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DayStart()
    {
        day++;
        dayStat.text = day.ToString();
    }

    void Shift()
    {
        money += 5;
        monStat.text = money.ToString();
        happiness -= 5;
        HappStat.text = happiness.ToString();
        EventManagerTestLiam.EnergySupply();
    }

    void Live()
    {
        money -= 5;
        monStat.text = money.ToString();
        happiness += 5;
        HappStat.text = happiness.ToString();
        EventManagerTestLiam.EnergySupply();
    }

}
