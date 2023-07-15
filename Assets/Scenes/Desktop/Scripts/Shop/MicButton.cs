using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicButton : MonoBehaviour
{
    public bool isMicPurchased = false;
    public Button micButt;
    public GameObject microphone;

    // Start is called before the first frame update
    void Awake()
    {
        isMicPurchased = false;
        microphone.SetActive(false);
    }

    public void MicrophoneBuy()
    {
        Debug.Log("pressed butt");
        isMicPurchased = true;
        micButt.enabled = false;
        microphone.SetActive(true);
        EnergyManagement.instance.money -= 20;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 8;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
