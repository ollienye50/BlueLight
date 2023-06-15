using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowClick : MonoBehaviour
{
    public GameObject WindowTab;
    public GameObject DesktopIcon;
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
            //if over A
            //if (RaycastHit2D)
                //World to screen (A)
                    //Compare mouse position
                // OR Screen to ray, raycast against A

                //instatiate
            Debug.Log("Mouse Click");
            //Transposing the mouse position into the world.
            //Vector2 CursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Spawning a 'window tab' object at the cursor position
            // Instantiate(WindowTab, new Vector2(5, 2), Quaternion.identity);
            DesktopIcon.SetActive(true);
        }  
    }
}
