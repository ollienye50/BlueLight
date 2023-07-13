using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public int streamMon;
    public Text monStat;
    public Text HappStat;
    public Text dayStat;
    public Text rentStat;


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
        monStat.text = money.ToString();
        dayStat.text = day.ToString();
        rentStat.text = RentCounter.instance.rentCount.ToString();
        MoneyCheck();
        DayCheck();
    }

    void Shift()
    {
        money += 75;
        monStat.text = money.ToString();
        happiness -= 3;
        HappStat.text = happiness.ToString();
        HappinessCheck();
    }

    void Live()
    {
        monStat.text = money.ToString();
        happiness += 2;
        streamMon += 5;
        money += streamMon;
        monStat.text = money.ToString();
        HappStat.text = happiness.ToString();
    }

    public void HappinessCheck()
    {
        if(happiness <=0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void MoneyCheck()
    {
        if (money <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void DayCheck()
    {
        if (day >= 22)
        {
            SceneManager.LoadScene(3);
        }
    }

}
