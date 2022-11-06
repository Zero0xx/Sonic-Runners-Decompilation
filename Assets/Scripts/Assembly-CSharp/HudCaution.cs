using UnityEngine;
using System;

public class HudCaution : MonoBehaviour
{
	[Serializable]
	private class AnimInfo
	{
		[SerializeField]
		public Animation m_animation;
		[SerializeField]
		public string m_clipName;
		[SerializeField]
		public UILabel m_label;
		[SerializeField]
		public string m_labelStringFormat;
		[SerializeField]
		public UISlider m_slider;
		[SerializeField]
		public UISprite m_sprite;
		[SerializeField]
		public UISprite m_sprite2;
		[SerializeField]
		public bool m_finishDisable;
	}

	[SerializeField]
	private GameObject m_playerAnchorGameObject;
	[SerializeField]
	private GameObject m_enemyAnchorGameObject;
	[SerializeField]
	private AnimInfo[] m_animInfos;
	[SerializeField]
	private UISprite m_bossAttenion;
	[SerializeField]
	private UISprite m_raidBossAttenion;
}
