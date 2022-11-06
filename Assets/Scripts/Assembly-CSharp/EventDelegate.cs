using System;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[SerializeField]
	private MonoBehaviour mTarget;
	[SerializeField]
	private string mMethodName;
	public bool oneShot;
}
