using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManagement : MonoBehaviour
{
    public int energy;
    // Start is called before the first frame update
    
    void OnEnable()
    {
        EventManagerTestLiam.energyUsed += Action;
        EventManagerTestLiam.dayPassed += DayStart;
    }

    void OnDisable()
    {
        EventManagerTestLiam.energyUsed -= Action;
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

    void Action()
    {
        energy--;
    }

}
