using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWork : MonoBehaviour
{
    public int test;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        test++;
        EventManagerTestLiam.instance.GoToWork();
    }
}
