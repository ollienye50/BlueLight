using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class CatButton : MonoBehaviour
{
    public bool PurchasedCat = false;
    public GameObject CatButt;
    public GameObject CatPoster;

    // Start is called before the first frame update
    void Start()
    {
        PurchasedCat = false;
        CatPoster.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("pressed butt");
        PurchasedCat = true;
        CatButt.GetComponent<BoxCollider>().enabled = false;
        CatPoster.SetActive(true);
        EnergyManagement.instance.money -= 5;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 3;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
