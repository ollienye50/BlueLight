using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LolipopHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text LolipopText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LolipopText.text = "-1E, -10M, +2H";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LolipopText.text = " ";
    }
}
