using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowClick : MonoBehaviour
{
    public GameObject WindowTab;
    public GameObject DesktopIcon;
    public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //Checking for pressing the mouse button
        if (Input.GetMouseButtonDown(0))
        {
            WindowTab.SetActive(true);
            Debug.Log("Icon Clicked");
        }
        else
        {
            WindowTab.SetActive(false);
        } 
    }
 
}
