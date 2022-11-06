using System;

[Serializable]
public class ObjBossEggmanFeverParameter : SpawnableParameter
{
	public int m_hp;
	public int m_distance;
	public int m_tblId;
	public float m_downSpeed;
	public float m_attackInterspaceMin;
	public float m_attackInterspaceMax;
	public float m_boundParamMin;
	public float m_boundParamMax;
	public int m_boundMaxRand;
	public float m_shotSpeed;
	public float m_bumperFirstSpeed;
	public float m_bumperOutOfcontrol;
	public float m_bumperSpeedup;
	public float m_ballSpeed;
}
