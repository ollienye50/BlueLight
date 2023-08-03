using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public Animator layer1;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        layer1.SetTrigger("Layer1FadeOut");
        yield return new WaitForSeconds(waitTime);
        //layer1.SetTrigger("Layer1FadeIn");
    }
}
