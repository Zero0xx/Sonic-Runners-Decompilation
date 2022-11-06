using UnityEngine;
using System.Collections.Generic;

public class DebugGameObject : SingletonGameObject<DebugGameObject>
{
	public enum DEBUG_CHECK_TYPE
	{
		DRAW_CALL = 0,
		LOAD_ATLAS = 1,
		NONE = 2,
	}

	public enum MOUSE_R_CLICK
	{
		PAUSED = 0,
		ATLAS = 1,
		HI_SPEED = 2,
		LOW_SPEED = 3,
		NONE = 4,
	}

	public enum LOADING_SUFFIXE
	{
		DEBUG_JA = 0,
		DEBUG_DE = 1,
		DEBUG_EN = 2,
		DEBUG_ES = 3,
		DEBUG_FR = 4,
		DEBUG_IT = 5,
		DEBUG_KO = 6,
		DEBUG_PT = 7,
		DEBUG_RU = 8,
		DEBUG_ZH = 9,
		DEBUG_ZHJ = 10,
		NONE = 11,
	}

	[SerializeField]
	public bool m_debugActive;
	[SerializeField]
	public bool m_debugNetworkActive;
	[SerializeField]
	public bool m_debugTestBtn;
	[SerializeField]
	public DEBUG_CHECK_TYPE m_debugCheckType;
	[SerializeField]
	public MOUSE_R_CLICK m_mouseRightClick;
	[SerializeField]
	public bool m_mouseWheelUseSpeed;
	[SerializeField]
	public ItemType m_mouseWheelUseItem;
	[SerializeField]
	public float m_currentTimeScale;
	[SerializeField]
	private bool m_titleFirstLogin;
	[SerializeField]
	private LOADING_SUFFIXE m_titleLoadingSuffixe;
	[SerializeField]
	private string m_suffixeBaseText;
	[SerializeField]
	private bool m_rankingDebug;
	[SerializeField]
	private RankingUtil.RankingRankerType m_targetRankingRankerType;
	[SerializeField]
	private RankingUtil.RankingScoreType m_rivalRankingScoreType;
	[SerializeField]
	private RankingUtil.RankingScoreType m_spRankingScoreType;
	[SerializeField]
	private bool m_rankingLog;
	[SerializeField]
	private int m_currentScore;
	[SerializeField]
	private int m_currentScoreEvent;
	[SerializeField]
	private int m_msgMax;
	[SerializeField]
	private bool m_crypt;
	[SerializeField]
	private int m_updateCost;
	[SerializeField]
	private List<string> m_updateCostList;
	[SerializeField]
	private RouletteCategory m_rouletteDummyCategory;
	[SerializeField]
	private bool m_rouletteTutorial;
	[SerializeField]
	private float m_rouletteConectTime;
	[SerializeField]
	private List<ServerItem.Id> m_rouletteDataPremium;
	[SerializeField]
	private List<ServerItem.Id> m_rouletteDataSpecial;
	[SerializeField]
	private List<ServerItem.Id> m_rouletteDataItem;
	[SerializeField]
	private List<ServerItem.Id> m_rouletteDataRaid;
	[SerializeField]
	private List<ServerItem.Id> m_rouletteDataDefault;
	[SerializeField]
	private int m_rouletteDummyError;
	[SerializeField]
	private List<Constants.Campaign.emType> m_debugCampaign;
}
