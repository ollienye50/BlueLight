using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManagement : MonoBehaviour
{
    public int energy;
    public int money;
    public int happiness;
    public Text monStat;
    public Text HappStat;
    public Text dayStat;
   // public string monString = money.ToString();

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
        energy = 5;
        Debug.Log("Energy:" +energy);
    }

    void Shift()
    {

        energy--;
        money += 5;
        monStat.text = money.ToString();
        happiness -= 5;
        HappStat.text = happiness.ToString();
    }

    void Live()
    {
        energy--;
        money -= 5;
        monStat.text = money.ToString();
        happiness += 5;
        HappStat.text = happiness.ToString();
    }

}
