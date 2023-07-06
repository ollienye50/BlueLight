using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicButton : MonoBehaviour
{
    public bool PurchasedMic = false;
    public GameObject MicButt;
    public GameObject Microphone;

    // Start is called before the first frame update
    void Start()
    {
        PurchasedMic = false;
        Microphone.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("pressed butt");
        PurchasedMic = true;
        MicButt.GetComponent<BoxCollider>().enabled = false;
        Microphone.SetActive(true);
        EnergyManagement.instance.money -= 20;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 8;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
