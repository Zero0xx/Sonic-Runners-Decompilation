using System;
using UnityEngine;

[Serializable]
public class StageBlockManager : MonoBehaviour
{
	[Serializable]
	public class DebugBlockInfo
	{
		public int block;
		public int layer;
	}

	[Serializable]
	public class BlockLevelData
	{
		public int numBlock;
		public int numPlacement;
		public int layerNum;
		public int repeatNum;
		public int fixedLayerNo;
	}

	[Serializable]
	public class StartingBlockInfo
	{
		public int fixedBlockNo;
		public int startingLayerNum;
	}

	[SerializeField]
	public DebugBlockInfo[] m_debugBlockInfo;
	[SerializeField]
	private BlockLevelData[] m_blockLevelData;
	[SerializeField]
	private BlockLevelData[] m_blockLevelDataForQuickMode;
	[SerializeField]
	private int m_apeearCheckPointNumber;
	[SerializeField]
	private StartingBlockInfo m_startingBlockInfo;
	[SerializeField]
	private bool m_useDebugOrder;
}
