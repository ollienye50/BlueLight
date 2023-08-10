using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoodlesButton : MonoBehaviour
{
    public bool isNoodlesPurchased = false;
    public Button noodlesButt;
    public GameObject item6Sold;
    public GameObject item6Buy;
    public GameObject noodlesText;

    public static NoodlesButton instance;

    [SerializeField]
    AudioSource purchaseSFX;

    // Start is called before the first frame update
    void Awake()
    {
        isNoodlesPurchased = false;
        item6Sold.SetActive(false);

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void NoodlesBuy()
    {
        Energy.instance.ShopNoodles();
    }

    public void NoodlesBought()
    {
        Debug.Log("pressed butt");
        purchaseSFX.Play();
        isNoodlesPurchased = true;
        noodlesButt.enabled = false;
        EnergyManagement.instance.money -= 10;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 2;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
        item6Sold.SetActive(true);
        item6Buy.SetActive(false);
        noodlesText.SetActive(false);
    }
}
