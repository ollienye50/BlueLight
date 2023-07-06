using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class CatButton : MonoBehaviour
{
    public bool isCatPurchased = false;
    public GameObject catButt;
    public GameObject catPoster;

    // Start is called before the first frame update
    void Awake()
    {
        isCatPurchased = false;
        catPoster.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("pressed butt");
        isCatPurchased = true;
        catButt.GetComponent<BoxCollider>().enabled = false;
        catPoster.SetActive(true);
        EnergyManagement.instance.money -= 5;
        EnergyManagement.instance.monStat.text = EnergyManagement.instance.money.ToString();
        EnergyManagement.instance.happiness += 3;
        EnergyManagement.instance.HappStat.text = EnergyManagement.instance.happiness.ToString();
        Energy.instance.energy -= 1;
        Energy.instance.enerStat.text = Energy.instance.energy.ToString();
    }
}
