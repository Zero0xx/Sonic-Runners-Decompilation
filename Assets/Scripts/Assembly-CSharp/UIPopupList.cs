using System.Collections.Generic;
using UnityEngine;

public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto = 0,
		Above = 1,
		Below = 2,
	}

	public UIAtlas atlas;
	public UIFont font;
	public UILabel textLabel;
	public string backgroundSprite;
	public string highlightSprite;
	public Position position;
	public List<string> items;
	public Vector2 padding;
	public float textScale;
	public Color textColor;
	public Color backgroundColor;
	public Color highlightColor;
	public bool isAnimated;
	public bool isLocalized;
	public List<EventDelegate> onChange;
	[SerializeField]
	private string mSelectedItem;
	[SerializeField]
	private GameObject eventReceiver;
	[SerializeField]
	private string functionName;
}
