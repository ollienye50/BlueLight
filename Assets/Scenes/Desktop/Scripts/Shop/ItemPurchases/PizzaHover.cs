using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PizzaHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text PizzaText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        PizzaText.text = "-1E, -10M, +2H";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        PizzaText.text = " ";
    }
}
