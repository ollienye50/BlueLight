using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class OpenWindowClick : MonoBehaviour
{
    public GameObject StreamWindow;
    public GameObject StreamButton;
    public GameObject WorkWindow;
    public GameObject WorkButton;
    public GameObject ShutDownButton;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        StreamWindow.gameObject.SetActive(false);
        WorkWindow.gameObject.SetActive(false);
    }

    IEnumerator StreamTabOpenClose()
    {
        StreamButton.GetComponent<BoxCollider>().enabled = false;
        WorkButton.GetComponent<BoxCollider>().enabled = false;
        ShutDownButton.GetComponent<BoxCollider>().enabled = false;
        StreamWindow.gameObject.SetActive(true);
        Debug.Log("wait");
        yield return new WaitForSeconds(3f);
        StreamWindow.gameObject.SetActive(false);
        WorkButton.GetComponent<BoxCollider>().enabled = true;
        StreamButton.GetComponent<BoxCollider>().enabled=true;
        ShutDownButton.GetComponent<BoxCollider>().enabled = true;
        yield break;

    }

    IEnumerator WorkTabOpenClose()
    {
        StreamButton.GetComponent<BoxCollider>().enabled = false;
        WorkButton.GetComponent<BoxCollider>().enabled = false;
        ShutDownButton.GetComponent<BoxCollider>().enabled = false;
        WorkWindow.gameObject.SetActive(true);
        Debug.Log("wait");
        yield return new WaitForSeconds(3f);
        WorkWindow.gameObject.SetActive(false);
        WorkButton.GetComponent<BoxCollider>().enabled = true;
        StreamButton.GetComponent<BoxCollider>().enabled = true;
        ShutDownButton.GetComponent<BoxCollider>().enabled = true;
        yield break;

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Click");
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
                if (StreamButton == hit.transform.gameObject)
                {
                    StartCoroutine(StreamTabOpenClose());
                }
                if (WorkButton == hit.transform.gameObject)
                {
                    StartCoroutine(WorkTabOpenClose());
                }

            }
        }

    }
}
