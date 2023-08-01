using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WebcamButton : MonoBehaviour
{
    public bool isWebcamPurchased = false;
    public Button webcamButt;
    public GameObject webcam;
    
    // Start is called before the first frame update
    void Awake()
    {
        isWebcamPurchased = false;
        webcam.SetActive(false);
    }

    public void WebcamBuy()
    {
        Debug.Log("pressed butt");
        isWebcamPurchased = true;
        webcamButt.enabled = false;
        webcam.SetActive(true);
        EnergyManagement.instance.money -= 60;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 2;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        EnergyManagement.instance.streamMon += 5;
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
