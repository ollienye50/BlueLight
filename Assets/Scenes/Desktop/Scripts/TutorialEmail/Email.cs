using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Email : MonoBehaviour
{

    public GameObject rentEmail;
    public GameObject tutorial;

    public GameObject StreamButton;
    public GameObject WorkButton;
    public GameObject ShutDownButton;
    public GameObject ShoppingButton;

    // Start is called before the first frame update
    void Awake()
    {
        StreamButton.GetComponent<BoxCollider>().enabled = false;
        WorkButton.GetComponent<BoxCollider>().enabled = false;
        ShutDownButton.GetComponent<BoxCollider>().enabled = false;
        ShoppingButton.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        rentEmail.SetActive(false);
        tutorial.SetActive(true);
    }
}
