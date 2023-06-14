using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowClick : MonoBehaviour
{
    public GameObject WindowTab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Click");
            Vector2 CursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(WindowTab, new Vector2(CursorPos.x, CursorPos.y), Quaternion.identity);
        }  
    }
}
