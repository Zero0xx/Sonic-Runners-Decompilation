using UnityEngine;

public class TerrainXmlData : MonoBehaviour
{
	[SerializeField]
	private TextAsset m_terrainBlock;
	[SerializeField]
	private TextAsset m_sideViewPath;
	[SerializeField]
	private TextAsset m_loopPath;
	[SerializeField]
	private TextAsset[] m_setData;
	[SerializeField]
	private TextAsset m_itemTableData;
	[SerializeField]
	private TextAsset m_rareEnemyTableData;
	[SerializeField]
	private TextAsset m_bossTableData;
	[SerializeField]
	private TextAsset m_bossMap3TableData;
	[SerializeField]
	private TextAsset m_objectPartTableData;
	[SerializeField]
	private TextAsset m_EnemyExtendItemTableData;
	[SerializeField]
	private int m_moveTrapBooRand;
}
