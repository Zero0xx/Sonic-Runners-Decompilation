using UnityEngine;

public class SpringPosition : MonoBehaviour
{
	public Vector3 target;
	public float strength;
	public bool worldSpace;
	public bool ignoreTimeScale;
	public GameObject eventReceiver;
	public string callWhenFinished;
}
