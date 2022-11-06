using UnityEngine;

public class UIRectItemStorage : MonoBehaviour
{
	public enum ActiveType
	{
		ACTIVE = 0,
		NOT_ACTTIVE = 1,
		DEFAULT = 2,
	}

	public bool isPlaceVertical;
	public int maxItemCount;
	public int maxRows;
	public int maxColumns;
	public GameObject template;
	public UIWidget background;
	public int spacing_x;
	public int spacing_y;
	public int padding;
	public ActiveType m_activeType;
}
