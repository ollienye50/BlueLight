using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShoppingWindow : MonoBehaviour
{
    public GameObject ShopWindow;
    public GameObject StreamButton;
    public GameObject WorkButton;
    public GameObject ShutDownButton;
    public GameObject ShoppingButton;

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
        StreamButton.GetComponent<BoxCollider>().enabled = false;
        WorkButton.GetComponent<BoxCollider>().enabled = false;
        ShutDownButton.GetComponent<BoxCollider>().enabled = false;
        ShoppingButton.GetComponent<BoxCollider>().enabled = false;
    }

    public void ToggleOff()
    {
        print("close");
        ShopWindow.SetActive(false);
        //turn on any buttons from being pressed
        StreamButton.GetComponent<BoxCollider>().enabled = true;
        WorkButton.GetComponent<BoxCollider>().enabled = true;
        ShutDownButton.GetComponent<BoxCollider>().enabled = true;
        ShoppingButton.GetComponent<BoxCollider>().enabled = true;
    }
}
