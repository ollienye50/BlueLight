using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicButton : MonoBehaviour
{
    public bool isMicPurchased = false;
    public Button micButt;
    public GameObject microphone;
    public GameObject item2Sold;
    public GameObject item2Buy;
    public GameObject microphoneText;

    public static MicButton instance;

    [SerializeField]
    AudioSource purchaseSFX;

    // Start is called before the first frame update
    void Awake()
    {
        isMicPurchased = false;
        microphone.SetActive(false);
        item2Sold.SetActive(false);

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void MicrophoneBuy()
    {
        Energy.instance.ShopMic();
    }

    public void MicBought()
    {
        Debug.Log("pressed butt");
        purchaseSFX.Play();
        isMicPurchased = true;
        micButt.enabled = false;
        microphone.SetActive(true);
        EnergyManagement.instance.money -= 100;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 5;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        EnergyManagement.instance.streamMon += 10;
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
        item2Sold.SetActive(true);
        item2Buy.SetActive(false);
        microphoneText.SetActive(false);
    }
}
