using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public static AudioControl instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Animator layer1;
    public Animator layer2;
    public Animator layer3;
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
            StartCoroutine(OneToTwo());
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            StartCoroutine(TwoToThree());
        }
    }

    public void Sad()
    {
        StartCoroutine(OneToTwo());
    }

    public void GoodDay()
    {
        StartCoroutine(TwoToOne());
    }

    public void Depressed()
    {
        StartCoroutine(TwoToThree());
    }

    public void Recover()
    {
        StartCoroutine(ThreeToTwo());
    }

    IEnumerator OneToTwo()
    {
        layer1.SetTrigger("Layer1FadeOut");
        layer2.SetTrigger("Layer2FadeIn");
        yield return new WaitForSeconds(waitTime);
        layer1.SetTrigger("Layer1IdleOff");
        layer2.SetTrigger("Layer2IdleOn");
    }

    IEnumerator TwoToOne()
    {
        layer2.SetTrigger("Layer2FadeOut");
        layer1.SetTrigger("Layer1FadeIn");
        yield return new WaitForSeconds(waitTime);
        layer2.SetTrigger("Layer2IdleOff");
        layer1.SetTrigger("Layer1IdleOn");
    }

    IEnumerator TwoToThree()
    {
        layer2.SetTrigger("Layer2FadeOut");
        layer3.SetTrigger("Layer3FadeIn");
        yield return new WaitForSeconds(waitTime);
        layer2.SetTrigger("Layer2IdleOff");
        layer3.SetTrigger("Layer3IdleOn");
    }

    IEnumerator ThreeToTwo()
    {
        layer3.SetTrigger("Layer3FadeOut");
        layer2.SetTrigger("Layer2FadeIn");
        yield return new WaitForSeconds(waitTime);
        layer3.SetTrigger("Layer3IdleOff");
        layer2.SetTrigger("Layer2IdleOn");
    }
}
