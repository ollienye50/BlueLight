using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCreditsTransition : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;
    
    public void Awake()
    {
        credits.SetActive(false);
    }

    public void SetCredits()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void SetMenu()
    {
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }
}
