using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StreamTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text StreamText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		StreamText.text = "Stream (+5 M, +2 H, -2 E)";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		StreamText.text = " ";
	}
}