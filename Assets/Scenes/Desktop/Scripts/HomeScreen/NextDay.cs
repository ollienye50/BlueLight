using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextDay : MonoBehaviour
{
    [SerializeField]
    AudioSource ShutDownSFX;

    public void SkipDay()
    {
        StartCoroutine(DayEnd());
    }

    IEnumerator DayEnd()
    {
        ShutDownSFX.Play();
        FadeControl.instance.HideBackground();
        Debug.Log("Fade Out");
        yield return new WaitForSeconds(1);
        EventManagerTestLiam.instance.NextDay();
    }
}
