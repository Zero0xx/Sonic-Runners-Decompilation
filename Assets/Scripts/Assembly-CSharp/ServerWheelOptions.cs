using System;

public class ServerWheelOptions
{
	public int m_nextSpinCost;
	public int[] m_items;
	public int[] m_itemQuantities;
	public int[] m_itemWeight;
	public int m_itemWon;
	public int m_spinCost;
	public RouletteUtility.WheelRank m_rouletteRank;
	public int m_numRouletteToken;
	public int m_numJackpotRing;
	public int m_numRemaining;
	public DateTime m_nextFreeSpin;
}
