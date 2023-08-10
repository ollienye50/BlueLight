using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkButton : MonoBehaviour
{
    public bool isDrinkPurchased = false;
    public Button drinkButt;
    public GameObject item4Sold;
    public GameObject item4Buy;
    public GameObject drinkText;

    public static DrinkButton instance;

    [SerializeField]
    AudioSource purchaseSFX;

    // Start is called before the first frame update
    void Awake()
    {
        isDrinkPurchased = false;
        item4Sold.SetActive(false);

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void DrinkBuy()
    {
        Energy.instance.ShopDrink();
    }

    public void DrinkBought()
    {
        Debug.Log("pressed butt");
        purchaseSFX.Play();
        isDrinkPurchased = true;
        drinkButt.enabled = false;
        EnergyManagement.instance.money -= 10;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 1;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        item4Sold.SetActive(true);
        item4Buy.SetActive(false);
        drinkText.SetActive(false);
    }
}
