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
    public float day;
    public float money;
    public float happiness;
    public float streamMon;
    public Text monStat;
    public Text HappStat;
    public Text dayStat;
    public Text rentStat;
    public float streamRev = 0f;
    public float viewers = 0f;
    public bool happy;
    public bool sad;
    public bool depressed;


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
        happy = true;
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
        money += 85;
        monStat.text = money.ToString();
        happiness -= 3;
        HappStat.text = happiness.ToString();
        HappinessCheck();
    }

    void Live()
    {
        if(streamMon <= 20)
        {
            streamRev = Random.Range(-5, 5);
            viewers = streamRev + 5;
        }
        else if(streamMon > 20 && streamMon <= 40)
        {
            streamRev = Random.Range(-10, 10);
            viewers = streamRev + 10;
        }
        else if (streamMon > 40 && streamMon <= 70)
        {
            streamRev = Random.Range(-15, 15);
            viewers = streamRev + 15;
        }
        else
        {
            streamRev = Random.Range(-20, 20);
            viewers = streamRev + 20;
        }
        monStat.text = money.ToString();
        happiness += 2;
        streamMon += 5;
        money += streamMon + streamRev;
        monStat.text = money.ToString();
        HappStat.text = happiness.ToString();
        Recovery();
    }

    public void Recovery()
    {
        if (happiness >= 5)
        {
            if(depressed == true)
            {
                AudioControl.instance.Recover();
                sad = true;
                depressed = false;
            }
        }
        if (happiness >= 9)
        {
            if(sad == true)
            {
                AudioControl.instance.GoodDay();
                happy = true;
                sad = false;
            }
        }
    }

    public void HappinessCheck()
    {
        if(happiness <=7)
        {
            if(happy == true)
            {
                AudioControl.instance.Sad();
                sad = true;
                happy = false;
            }
        }
        if (happiness <= 3)
        {
            if(sad == true)
            {
                AudioControl.instance.Depressed();
                depressed = true;
                sad = false;
            }
        }
        if (happiness <=0)
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
