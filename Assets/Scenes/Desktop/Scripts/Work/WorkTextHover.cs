using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WorkTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text WorkText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		WorkText.text = "Work (+85 M, -3 H, -2 E)";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		WorkText.text = " ";
	}
}
