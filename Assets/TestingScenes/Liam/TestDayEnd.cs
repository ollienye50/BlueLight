using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDayEnd : MonoBehaviour
{
    public int day;
    public Text dayStat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        day++;
        dayStat.text = day.ToString();
        EventManagerTestLiam.NextDay();
    }
}
