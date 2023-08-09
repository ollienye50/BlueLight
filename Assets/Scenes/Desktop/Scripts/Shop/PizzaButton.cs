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

    // Start is called before the first frame update
    void Awake()
    {
        isPizzaPurchased = false;
        item7Sold.SetActive(false);
    }

    public void PizzaBuy()
    {
        Debug.Log("pressed butt");
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