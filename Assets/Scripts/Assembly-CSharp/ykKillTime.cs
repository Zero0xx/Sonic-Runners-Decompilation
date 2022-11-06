using UnityEngine;

public class ykKillTime : MonoBehaviour
{
	public enum ykKillType
	{
		destroy = 0,
		hide = 1,
		deactivate = 2,
	}

	public float killTime;
	public ykKillType killType;
}
