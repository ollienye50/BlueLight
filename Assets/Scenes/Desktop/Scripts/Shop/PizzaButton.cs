using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaButton : MonoBehaviour
{
    public bool isPizzaPurchased = false;
    public Button pizzaButt;
    public GameObject item7Sold;
    public GameObject item7Buy;
    public GameObject pizzaText;

    public static PizzaButton instance;

    [SerializeField]
    AudioSource purchaseSFX;

    // Start is called before the first frame update
    void Awake()
    {
        isPizzaPurchased = false;
        item7Sold.SetActive(false);

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void PizzaBuy()
    {
        Energy.instance.ShopPizza();
    }

    public void PizzaBought()
    {
        Debug.Log("pressed butt");
        purchaseSFX.Play();
        isPizzaPurchased = true;
        pizzaButt.enabled = false;
        EnergyManagement.instance.money -= 10;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 2;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
        item7Sold.SetActive(true);
        item7Buy.SetActive(false);
        pizzaText.SetActive(false);
    }
}