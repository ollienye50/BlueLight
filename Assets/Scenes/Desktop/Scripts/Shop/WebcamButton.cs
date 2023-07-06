using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class WebcamButton : MonoBehaviour
{
    public bool PurchasedCam = false;
    public GameObject WebcamButt;
    public GameObject Webcam;
    
    // Start is called before the first frame update
    void Start()
    {
        PurchasedCam = false;
        Webcam.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("pressed butt");
        PurchasedCam = true;
        WebcamButt.GetComponent<BoxCollider>().enabled = false;
        Webcam.SetActive(true);
        EnergyManagement.instance.money -= 10;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 5;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
