using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton : MonoBehaviour
{
    public void Credits()
    {
        SceneManager.LoadSceneAsync(4);
    }

}

