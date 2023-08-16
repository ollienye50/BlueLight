using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{
    // [SerializeField] private CanvasGroup background;
    // [SerializeField] private bool fadeIn = false;
    // [SerializeField] private bool fadeOut = false;
    public Animator canvas;
    public float waitTime;
    public static FadeControl instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    public void ShowBackground()
    {
        StartCoroutine(FadeIn());



        /*   fadeIn = true;
        if (fadeIn = true)
        {
            if (background.alpha < 1)
            {
                background.alpha += Time.deltaTime;
                if (background.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        } */
    }
   
    public void HideBackground()
    {

        StartCoroutine(FadeOut());
        
        
        /* fadeOut = true;
        if (fadeOut = true)
        {
            if (background.alpha >= 0)
            {
                background.alpha -= Time.deltaTime;
                if (background.alpha == 1)
                {
                    fadeOut = false;
                }
            }
        } */
    }

    void update()
    {
     
        
        
        
        /*  if (fadeIn = true)
        {
            if(background.alpha < 1)
            {
                background.alpha += Time.deltaTime;
                if(background.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }

        if (fadeOut = true)
        {
            if (background.alpha >= 0)
            {
                background.alpha -= Time.deltaTime;
                if (background.alpha == 1)
                {
                    fadeOut = false;
                }
            }
        } */
    }

    IEnumerator FadeIn()
    {
        canvas.SetTrigger("FadeIn");
        yield return new WaitForSeconds(waitTime);
        canvas.SetTrigger("Idle");
        
    }

    IEnumerator FadeOut()
    {
        canvas.SetTrigger("FadeOut");
        yield return new WaitForSeconds(waitTime);
        canvas.SetTrigger("Off");
    }
}
