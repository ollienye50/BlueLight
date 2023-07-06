using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject tutorial;

    public GameObject StreamButton;
    public GameObject WorkButton;
    public GameObject ShutDownButton;
    public GameObject ShoppingButton;

    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(false);
    }

    private void OnMouseDown()
    {
        tutorial.SetActive(false);
        StreamButton.GetComponent<BoxCollider>().enabled = true;
        WorkButton.GetComponent<BoxCollider>().enabled = true;
        ShutDownButton.GetComponent<BoxCollider>().enabled = true;
        ShoppingButton.GetComponent<BoxCollider>().enabled = true;
    }
}
