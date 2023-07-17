using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MicrophoneHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text MicrophoneText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		MicrophoneText.text = "Microphone (-1E, -100M, +5H)";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		MicrophoneText.text = " ";
	}
}
