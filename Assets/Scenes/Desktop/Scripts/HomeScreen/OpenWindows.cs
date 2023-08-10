using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindows : MonoBehaviour
{
    

    //list all game objects
    public Button StreamButt;
    public Button WorkButt;
    public Button ShopButt;
    public Button NextDayButt;
    public GameObject StreamWindow;
    public GameObject WorkWindow;
    public Camera camera;

    [SerializeField]
    AudioSource mouseClick;
    [SerializeField]
    AudioSource workSFX;
    [SerializeField]
    AudioSource streamSFX;

    void Start()
    {
        //set stream and work windows to false
        StreamWindow.gameObject.SetActive(false);
        WorkWindow.gameObject.SetActive(false);
        
        EventManagerTestLiam.instance.workShift.AddListener(Shift);
        EventManagerTestLiam.instance.streamSession.AddListener(Live);
    }

    IEnumerator StreamWindowOpenClose()
    {
        //set all buttons to false
        StreamButt.enabled = false;
        WorkButt.enabled = false;
        ShopButt.enabled = false;
        NextDayButt.enabled = false;
        StreamWindow.gameObject.SetActive(true);
        Debug.Log("wait");
        streamSFX.Play();
        //wait a few seconds
        yield return new WaitForSeconds(5f);
        StreamWindow.gameObject.SetActive(false);
        //set all buttons to true
        StreamButt.enabled = true;
        WorkButt.enabled = true;
        ShopButt.enabled = true;
        NextDayButt.enabled = true;
        yield break;
    }

    IEnumerator WorkWindowOpenClose()
    {
        //set all buttons to false
        StreamButt.enabled = false;
        WorkButt.enabled = false;
        ShopButt.enabled = false;
        NextDayButt.enabled = false;
        WorkWindow.gameObject.SetActive(true);
        Debug.Log("wait");
        workSFX.Play();
        //wait a few seconds
        yield return new WaitForSeconds(5f);
        WorkWindow.gameObject.SetActive(false);
        //set all buttons to true
        StreamButt.enabled = true;
        WorkButt.enabled = true;
        ShopButt.enabled = true;
        NextDayButt.enabled = true;
        yield break;
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
            Debug.Log("Mouse Click");
            mouseClick.Play();
      }
    }

    public void Stream()
    {
        EventManagerTestLiam.instance.EnergySupplyStream();
    }

    public void Work()
    {
        EventManagerTestLiam.instance.EnergySupplyWork();
    }

    void Shift()
    {
        StartCoroutine(WorkWindowOpenClose());
    }

    void Live()
    {
        StartCoroutine(StreamWindowOpenClose());
    }

}
