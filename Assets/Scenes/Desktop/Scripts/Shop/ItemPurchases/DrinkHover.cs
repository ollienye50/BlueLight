using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrinkHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text DrinkText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        DrinkText.text = "-10M, +1H";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DrinkText.text = " ";
    }
}
