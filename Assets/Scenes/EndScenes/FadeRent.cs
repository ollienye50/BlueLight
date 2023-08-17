using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeRent : MonoBehaviour
{
    public Animator canvas;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        canvas.SetTrigger("Off");
        yield return new WaitForSeconds(waitTime);
        
    }
}
