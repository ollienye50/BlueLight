using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyText : MonoBehaviour
{
    public GameObject IconText;
    // Start is called before the first frame update
    void Start()
    {
        IconText.SetActive(false);
    }

    public void OnMouseOver()
    {
        IconText.SetActive(true);
    }

    public void OnMouseExit()
    {
        IconText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
