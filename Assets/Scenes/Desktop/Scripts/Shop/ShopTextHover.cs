using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public Text ShopText;

	public void OnPointerEnter (PointerEventData eventData)
	{
		ShopText.text = "Shop (1 Energy)";
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		ShopText.text = " ";
	}
}
