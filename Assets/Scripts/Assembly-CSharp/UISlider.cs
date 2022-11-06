using UnityEngine;
using System.Collections.Generic;

public class UISlider : UIWidgetContainer
{
	public enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public Transform foreground;
	public Transform thumb;
	public Direction direction;
	public int numberOfSteps;
	public List<EventDelegate> onChange;
	[SerializeField]
	private float rawValue;
	[SerializeField]
	private GameObject eventReceiver;
	[SerializeField]
	private string functionName;
}
