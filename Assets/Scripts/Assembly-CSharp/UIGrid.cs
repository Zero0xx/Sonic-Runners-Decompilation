public class UIGrid : UIWidgetContainer
{
	public enum Arrangement
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public Arrangement arrangement;
	public int maxPerLine;
	public float cellWidth;
	public float cellHeight;
	public bool repositionNow;
	public bool sorted;
	public bool hideInactive;
}
