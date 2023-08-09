using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappinessLayers : MonoBehaviour
{
    public GameObject Layer1;
    public GameObject Layer2;
    public GameObject Layer3;
    public GameObject Layer4;
    public GameObject Layer5;

    void Start()
    {
        Layer1.SetActive(false);
        Layer2.SetActive(false);
        Layer3.SetActive(false);
        Layer4.SetActive(false);
        Layer5.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(EnergyManagement.instance.happiness >= 10)
        {
            Layer1.SetActive(false);
            Layer2.SetActive(false);
            Layer3.SetActive(false);
            Layer4.SetActive(false);
            Layer5.SetActive(false);
        }
    
        if(EnergyManagement.instance.happiness <= 9 && EnergyManagement.instance.happiness >= 8)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(false);
            Layer3.SetActive(false);
            Layer4.SetActive(false);
            Layer5.SetActive(false);
        }

        if(EnergyManagement.instance.happiness <= 7 && EnergyManagement.instance.happiness >= 6)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(true);
            Layer3.SetActive(false);
            Layer4.SetActive(false);
            Layer5.SetActive(false);
        }

        if(EnergyManagement.instance.happiness <= 5 && EnergyManagement.instance.happiness >= 3)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(true);
            Layer3.SetActive(true);
            Layer4.SetActive(false);
            Layer5.SetActive(false);
        }

        if (EnergyManagement.instance.happiness == 2)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(true);
            Layer3.SetActive(true);
            Layer4.SetActive(true);
            Layer5.SetActive(false);
        }

        if (EnergyManagement.instance.happiness == 1)
        {
            Layer1.SetActive(true);
            Layer2.SetActive(true);
            Layer3.SetActive(true);
            Layer4.SetActive(true);
            Layer5.SetActive(true);
        }
    }
}
