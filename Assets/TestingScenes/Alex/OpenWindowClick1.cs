using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class OpenWindowClick : MonoBehaviour
{
    public GameObject WindowTab;
    public GameObject DesktopIcon;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        WindowTab.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Click");
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
                if (DesktopIcon == hit.transform.gameObject)
                {
                    WindowTab.gameObject.SetActive(true);
                    Debug.Log("Window Spawn");
                }
                
            }
        }

    }
}
