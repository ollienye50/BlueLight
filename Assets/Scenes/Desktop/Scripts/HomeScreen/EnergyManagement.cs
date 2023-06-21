using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManagement : MonoBehaviour
{
    public static EnergyManagement instance;
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

    // public TestStream potat;
    //public Energy energyScript;
    public int day;
    public int money;
    public int happiness;
    public Text monStat;
    public Text HappStat;
    public Text dayStat;


    // Start is called before the first frame update

    /*void OnEnable()
    {
        EventManagerTestLiam.instance.workShift.AddListener(Shift);
        EventManagerTestLiam.instance.streamSession.AddListener(Live);
        EventManagerTestLiam.instance.dayPassed.AddListener(DayStart);
    }*/

    /*void OnDisable()
    {
        EventManagerTestLiam.instance.workShift.RemoveListener(Shift);
        EventManagerTestLiam.instance.streamSession.RemoveListener(Live);
        EventManagerTestLiam.instance.dayPassed.RemoveListener(DayStart);
    }*/

    void Start()
    {
        DayStart();
        EventManagerTestLiam.instance.workShift.AddListener(Shift);
        EventManagerTestLiam.instance.streamSession.AddListener(Live);
        EventManagerTestLiam.instance.dayPassed.AddListener(DayStart);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DayStart()
    {
        day++;
        RentCounter.instance.rentCount-=1;
        RentCounter.instance.RentCheck();
        dayStat.text = day.ToString();
    }

    void Shift()
    {
        money += 5;
        monStat.text = money.ToString();
        happiness -= 5;
        HappStat.text = happiness.ToString();
        EventManagerTestLiam.instance.EnergySupply();
    }

    void Live()
    {
        money -= 5;
        monStat.text = money.ToString();
        happiness += 5;
        HappStat.text = happiness.ToString();
        EventManagerTestLiam.instance.EnergySupply();
    }

}
