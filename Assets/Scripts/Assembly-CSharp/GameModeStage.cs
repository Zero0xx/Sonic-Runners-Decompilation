using UnityEngine;

public class GameModeStage : MonoBehaviour
{
	public bool m_isCreatespawnableManager;
	public bool m_isCreateTerrainPlacementManager;
	public bool m_notPlaceTerrain;
	public bool m_showBlockInfo;
	public bool m_randomBlock;
	public bool m_useTemporarySet;
	public int m_blockNumOfNotPlaceTerrain;
	public bool m_bossStage;
	public int m_debugBossLevel;
	public BossType m_bossType;
	public bool m_useCharaInInspector;
	public bool m_noStartHud;
	[SerializeField]
	private bool m_tutorialStage;
	[SerializeField]
	private bool m_eventStage;
	[SerializeField]
	private string m_stageName;
	[SerializeField]
	private TenseType m_stageTenseType;
	[SerializeField]
	private CharaType m_mainChara;
	[SerializeField]
	private CharaType m_subChara;
	[SerializeField]
	private int m_numEnableContinue;
	[SerializeField]
	private float m_defaultTimeScale;
}
