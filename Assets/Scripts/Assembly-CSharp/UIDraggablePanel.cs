using UnityEngine;

public class UIDraggablePanel : MonoBehaviour
{
	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2,
	}

	public enum ShowCondition
	{
		Always = 0,
		OnlyIfNeeded = 1,
		WhenDragging = 2,
	}

	public DragEffect dragEffect;
	public bool restrictWithinPanel;
	public bool disableDragIfFits;
	public bool smoothDragStart;
	public bool repositionClipping;
	public bool iOSDragEmulation;
	public float scrollWheelFactor;
	public float momentumAmount;
	public UIScrollBar horizontalScrollBar;
	public UIScrollBar verticalScrollBar;
	public ShowCondition showScrollBars;
	public Vector3 scale;
	public Vector2 relativePositionOnReset;
}
