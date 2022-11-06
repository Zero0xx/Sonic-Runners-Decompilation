using UnityEngine;

public class SysFontText : MonoBehaviour
{
	public enum PivotAlignment
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8,
	}

	[SerializeField]
	protected SysFontTexture _texture;
	[SerializeField]
	protected Color _fontColor;
	[SerializeField]
	protected PivotAlignment _pivot;
}
