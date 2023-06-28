using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenuButton : MonoBehaviour
{
    public void loadScene(string MainMenu)
    {
        SceneManager.LoadScene(0);
    }
    
}
