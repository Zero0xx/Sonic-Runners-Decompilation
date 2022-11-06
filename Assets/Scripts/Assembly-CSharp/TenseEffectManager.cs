using UnityEngine;

public class TenseEffectManager : MonoBehaviour
{
	public enum Type
	{
		TENSE_A = 0,
		TENSE_B = 1,
	}

	[SerializeField]
	private Type m_nowType;
}
