using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class WebcamButton : MonoBehaviour
{
    public bool isWebcamPurchased = false;
    public GameObject webcamButt;
    public GameObject webcam;
    
    // Start is called before the first frame update
    void Awake()
    {
        isWebcamPurchased = false;
        webcam.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("pressed butt");
        isWebcamPurchased = true;
        webcamButt.GetComponent<BoxCollider>().enabled = false;
        webcam.SetActive(true);
        EnergyManagement.instance.money -= 10;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 5;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
