using UnityEngine;
using System;

public class ChaoSetUI : MonoBehaviour
{
	[Serializable]
	private class ChaoSerializeFields
	{
		[SerializeField]
		public UISprite m_chaoSprite;
		[SerializeField]
		public UITexture m_chaoTexture;
		[SerializeField]
		public UISprite m_chaoRankSprite;
		[SerializeField]
		public UILabel m_chaoNameLabel;
		[SerializeField]
		public UILabel m_chaoLevelLabel;
		[SerializeField]
		public UISprite m_chaoTypeSprite;
		[SerializeField]
		public UISprite m_bonusTypeSprite;
		[SerializeField]
		public UILabel m_bonusLabel;
	}

	[Serializable]
	private class RouletteButtonUI
	{
		[SerializeField]
		public GameObject m_alertBadgeGameObject;
		[SerializeField]
		public GameObject m_eqqBadgeGameObject;
		[SerializeField]
		public GameObject m_spinCountBadgeGameObject;
		[SerializeField]
		public UILabel m_spinCountLabel;
	}

	[SerializeField]
	private bool isDebugRondomSetChao;
	[SerializeField]
	private int[] m_chaoCountNumber;
	[SerializeField]
	private UILabel m_getChaoCountLabel;
	[SerializeField]
	private UILabel m_getChaoCountShadowLabel;
	[SerializeField]
	private UISprite m_getChaoSprite;
	[SerializeField]
	private UILabel m_getChaoBonusLabel;
	[SerializeField]
	private ChaoSerializeFields[] m_chaosSerializeFields;
	[SerializeField]
	private RouletteButtonUI m_rouletteButtonUI;
	[SerializeField]
	private UISprite m_sortLeveUp;
	[SerializeField]
	private UISprite m_sortRareUp;
	[SerializeField]
	private GameObject m_specialEggIconObj;
	[SerializeField]
	private GameObject m_freeSpinIconObj;
	[SerializeField]
	private UILabel m_freeSpinCountLabel;
	[SerializeField]
	private GameObject m_saleIconObj;
	[SerializeField]
	private GameObject m_eventIconObj;
}
