using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class CatButton : MonoBehaviour
{
    public bool isCatPurchased = false;
    public Button catButt;
    public GameObject catPoster;

    // Start is called before the first frame update
    void Awake()
    {
        isCatPurchased = false;
        catPoster.SetActive(false);
    }

    public void PosterBuy()
    {
        Debug.Log("pressed butt");
        isCatPurchased = true;
        catButt.enabled = false;
        catPoster.SetActive(true);
        EnergyManagement.instance.money -= 20;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 1;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy += 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
