using UnityEngine;

public class ChaoPartsObjectMagnet : MonoBehaviour
{
	public enum HitType
	{
		RING = 0,
		CRYSTAL = 1,
	}

	public float m_colliRadius;
	public float m_magnetRadius;
	public string m_effectName;
	public string m_hitLayer;
	public HitType m_hitType;
}
