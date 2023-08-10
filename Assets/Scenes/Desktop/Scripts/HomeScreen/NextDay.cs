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
        ShutDownSFX.Play();
        EventManagerTestLiam.instance.NextDay();
    }
}
