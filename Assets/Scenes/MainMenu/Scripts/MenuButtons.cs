using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public Animator canvas;
    public float waitTime;

    public void PlayGame()
    {
        StartCoroutine(Begin());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator Begin()
    {
        canvas.SetTrigger("FadeOut");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Desktop");
    }

}

