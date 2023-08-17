using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCreditsTransition : MonoBehaviour
{
    public GameObject mainMenu;

    public void SetCredits()
    {
        mainMenu.SetActive(false);
    }

    public void SetMenu()
    {
        mainMenu.SetActive(true);
    }
}
