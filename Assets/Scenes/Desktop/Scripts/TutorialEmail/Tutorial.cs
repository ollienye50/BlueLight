using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{

    public GameObject tutorial;

    public Button StreamButton;
    public Button WorkButton;
    public Button NextDayButton;
    public Button ShoppingButton;

    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(false);
    }

    public void CloseTutorial()
    {
        tutorial.SetActive(false);
        StreamButton.enabled = true;
        WorkButton.enabled = true;
        NextDayButton.enabled = true;
        ShoppingButton.enabled = true;
    }
}
