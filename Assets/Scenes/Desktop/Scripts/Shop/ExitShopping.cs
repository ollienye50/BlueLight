using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class ExitShopping : MonoBehaviour
{
    private ShoppingWindow window;

    // Start is called before the first frame update
    void Start()
    {
        window = FindObjectOfType<ShoppingWindow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        window.ToggleOff();
    }
}
