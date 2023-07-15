using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Email : MonoBehaviour
{

    public GameObject rentEmail;
    public GameObject tutorial;

    public Button StreamButton;
    public Button WorkButton;
    public Button NextDayButton;
    public Button ShoppingButton;

    // Start is called before the first frame update
    void Awake()
    {
        StreamButton.enabled = false;
        WorkButton.enabled = false;
        NextDayButton.enabled = false;
        ShoppingButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseEmail()
    {
        rentEmail.SetActive(false);
        tutorial.SetActive(true);
    }
}
