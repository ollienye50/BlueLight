using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LolipopButton : MonoBehaviour
{
    public bool isLolipopPurchased = false;
    public Button lolipopButt;
    public GameObject item5Sold;
    public GameObject item5Buy;
    public GameObject lolipopText;

    // Start is called before the first frame update
    void Awake()
    {
        isLolipopPurchased = false;
        item5Sold.SetActive(false);
    }

    public void LolipopBuy()
    {
        Debug.Log("pressed butt");
        isLolipopPurchased = true;
        lolipopButt.enabled = false;
        EnergyManagement.instance.money -= 10;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 2;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
        item5Sold.SetActive(true);
        item5Buy.SetActive(false);
        lolipopText.SetActive(false);
    }
}
