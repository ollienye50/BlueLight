using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextDay : MonoBehaviour
{
    [SerializeField]
    AudioSource ShutDownSFX;
    public float waiting;

    public void SkipDay()
    {
        StartCoroutine(DayEnd());
    }

    IEnumerator DayEnd()
    {
        FadeControl.instance.HideBackground();
        Cursor.lockState = CursorLockMode.Locked;
        yield return new WaitForSeconds(waiting);
        ShutDownSFX.Play();
        Debug.Log("Fade Out");
        yield return new WaitForSeconds(1);
        Cursor.lockState = CursorLockMode.None;

        EventManagerTestLiam.instance.NextDay();
    }
}
