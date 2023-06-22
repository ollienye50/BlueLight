using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class OpenWindowClick : MonoBehaviour
{
    public GameObject windowTab;
    public GameObject desktopIcon;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        windowTab.gameObject.SetActive(false);
    }

    IEnumerator WindowTabOpenClose()
    {
        windowTab.gameObject.SetActive(true);
        Debug.Log("wait");
        yield return new WaitForSeconds(3f);
        windowTab.gameObject.SetActive(false);
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
                if (desktopIcon == hit.transform.gameObject)
                {
                    StartCoroutine(WindowTabOpenClose());
                }
                
            }
        }

    }
}
