using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject tutorial;
    
    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        tutorial.SetActive(false);
    }
}
