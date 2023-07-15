using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingWindow : MonoBehaviour
{
    public GameObject ShopWindow;
    public Button StreamButt;
    public Button WorkButt;
    public Button NextDayButt;
    public Button ShopButt;

    // Start is called before the first frame update
    void Start()
    {
        ShopWindow.SetActive(false);
    }

    public void ToggleOn()
    {
        print("open");
        ShopWindow.SetActive(true);
        //turn off any buttons from being pressed
        StreamButt.enabled = false;
        WorkButt.enabled = false;
        ShopButt.enabled = false;
        NextDayButt.enabled = false;
    }

    public void ToggleOff()
    {
        print("close");
        ShopWindow.SetActive(false);
        //turn on any buttons from being pressed
        StreamButt.enabled = true;
        WorkButt.enabled = true;
        ShopButt.enabled = true;
        NextDayButt.enabled = true;
    }
}
