using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappinessLayers : MonoBehaviour
{
    public GameObject Layer1;
    public GameObject Layer2;
    public GameObject Layer3;

    void Start()
    {
        Layer1.SetActive(false);
        Layer2.SetActive(false);
        Layer3.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(EnergyManagement.instance.happiness >= 10)
        {
            Layer1.SetActive(false);
            Layer2.SetActive(false);
            Layer3.SetActive(false);
        }
    
        if(EnergyManagement.instance.happiness <= 10 && EnergyManagement.instance.happiness >= 5)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(false);
            Layer3.SetActive(false);
        }

        if(EnergyManagement.instance.happiness <= 4 && EnergyManagement.instance.happiness >= 3)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(true);
            Layer3.SetActive(false);
        }

        if(EnergyManagement.instance.happiness <= 2 && EnergyManagement.instance.happiness >= 1)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(true);
            Layer3.SetActive(true);
        }
    }
}
