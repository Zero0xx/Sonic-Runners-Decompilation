using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
	[Serializable]
	public class DebugRaidBoss
	{
		[SerializeField]
		public int m_id;
		[SerializeField]
		public int m_level;
		[SerializeField]
		public int m_rarity;
		[SerializeField]
		public int m_hp;
		[SerializeField]
		public int m_hpMax;
		[SerializeField]
		public string m_discovererName;
		[SerializeField]
		public int m_endTimeMinutes;
		[SerializeField]
		public int m_state;
		[SerializeField]
		public bool m_findMyself;
		[SerializeField]
		public bool m_validFlag;
	}

	[Serializable]
	public class DebugRaidBossInfo
	{
		[SerializeField]
		public int m_raidBossRingNum;
		[SerializeField]
		public int m_raidBossKillNum;
		[SerializeField]
		public int m_raidBossChallengeNum;
		[SerializeField]
		public int m_raidBossUseChallengeNum;
		[SerializeField]
		public EventManager.DebugRaidBoss[] m_debugRaidBossDatas;
		[SerializeField]
		public int m_debugCurrentRaidBossDataIndex;
		[SerializeField]
		public bool m_debugRaidBossDescentFlag;
	}

	[SerializeField]
	private bool m_debugFlag;
	[SerializeField]
	private int m_eventId;
	[SerializeField]
	private int m_startTimeHours;
	[SerializeField]
	private int m_startTimeMinutes;
	[SerializeField]
	private int m_startTimeSeconds;
	[SerializeField]
	private int m_endTimeHours;
	[SerializeField]
	private int m_endTimeMinutes;
	[SerializeField]
	private int m_endTimeSeconds;
	[SerializeField]
	private int m_closeTimeHours;
	[SerializeField]
	private int m_closeTimeMinutes;
	[SerializeField]
	private int m_closeTimeSeconds;
	[SerializeField]
	private int m_endPlayingTimeMinutes;
	[SerializeField]
	private int m_endResultTimeMinutes;
	[SerializeField]
	private DebugRaidBossInfo m_debugRaidBossInfo;
}
