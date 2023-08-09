using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WebcamHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text WebcamText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		WebcamText.text = "-1E, -60M, +2H";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		WebcamText.text = " ";
	}
}
