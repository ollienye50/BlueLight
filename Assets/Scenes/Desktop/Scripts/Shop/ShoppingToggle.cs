using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingToggle : MonoBehaviour
{
    private ShoppingWindow window;

    // Start is called before the first frame update
    void Awake()
    {
        window = FindObjectOfType<ShoppingWindow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        window.ToggleOn();
    }
}
