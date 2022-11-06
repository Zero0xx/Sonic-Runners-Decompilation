using System.Collections.Generic;
using UnityEngine;

public class UIScrollBar : UIWidgetContainer
{
	public enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public List<EventDelegate> onChange;
	[SerializeField]
	private UISprite mBG;
	[SerializeField]
	private UISprite mFG;
	[SerializeField]
	private Direction mDir;
	[SerializeField]
	private bool mInverted;
	[SerializeField]
	private float mScroll;
	[SerializeField]
	private float mSize;
}
