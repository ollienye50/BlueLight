using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WebcamHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text WebcamText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		WebcamText.text = "Webcam (-1E, -80M, +2H)";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		WebcamText.text = " ";
	}
}
