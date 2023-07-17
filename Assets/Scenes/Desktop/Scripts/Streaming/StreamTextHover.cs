using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StreamTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text StreamText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		StreamText.text = "Hovering";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		StreamText.text = " ";
	}
}