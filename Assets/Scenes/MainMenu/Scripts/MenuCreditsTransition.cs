using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCreditsTransition : MonoBehaviour
{
    public GameObject mainMenu;
    private Animator creditsScroll;

    void Start()
    {
        creditsScroll = GetComponent<Animator>();
    }

    public void SetCredits()
    {
        mainMenu.SetActive(false);
        //creditsScroll.Play;
    }

    public void SetMenu()
    {
        mainMenu.SetActive(true);
    }
}
