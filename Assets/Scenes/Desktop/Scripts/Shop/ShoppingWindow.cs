using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShoppingWindow : MonoBehaviour
{
    public GameObject ShopWindow;
    
    // Start is called before the first frame update
    void Start()
    {
        ShopWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleOn()
    {
        print("open");
        ShopWindow.SetActive(true);
        //turn off any buttons from being pressed
        
    }

    public void ToggleOff()
    {
        print("close");
        ShopWindow.SetActive(false);
        //turn on any buttons from being pressed
    }
}
