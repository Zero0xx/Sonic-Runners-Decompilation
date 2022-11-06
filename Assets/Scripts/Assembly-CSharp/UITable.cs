using UnityEngine;

public class UITable : UIWidgetContainer
{
	public enum Direction
	{
		Down = 0,
		Up = 1,
	}

	public int columns;
	public Direction direction;
	public bool sorted;
	public bool hideInactive;
	public bool keepWithinPanel;
	public bool repositionNow;
	public Vector2 padding;
}
