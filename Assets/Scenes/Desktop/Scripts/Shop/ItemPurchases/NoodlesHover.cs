using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NoodlesHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text NoodlesText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        NoodlesText.text = "-1E, -10M, +2H";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        NoodlesText.text = " ";
    }
}
