using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PosterHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text PosterText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		PosterText.text = "+1E, -20M, +1H";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		PosterText.text = " ";
	}
}
