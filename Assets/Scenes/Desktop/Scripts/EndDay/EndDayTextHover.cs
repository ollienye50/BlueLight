using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndDayTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text EndDayText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		EndDayText.text = "End Day";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		EndDayText.text = " ";
	}
}