using UnityEngine;
using System;

public class ui_mm_mileage_page : MonoBehaviour
{
	[Serializable]
	private class RouteObjects
	{
		[SerializeField]
		public UISprite m_lineSprite;
		[SerializeField]
		public GameObject m_lineEffectGameObject;
		[SerializeField]
		public GameObject m_bonusRootGameObject;
		[SerializeField]
		public UISprite m_bonusTypeSprite;
		[SerializeField]
		public UILabel m_bonusValueLabel;
		[SerializeField]
		public TweenPosition m_bonusTweenPosition;
	}

	[Serializable]
	private class BalloonObjects
	{
		[SerializeField]
		public GameObject m_gameObject;
		[SerializeField]
		public UITexture m_texture;
		[SerializeField]
		public GameObject m_effectGameObject;
		[SerializeField]
		public GameObject m_normalFrameObject;
		[SerializeField]
		public GameObject m_timerFrameObject;
		[SerializeField]
		public GameObject m_timerLimitObject;
		[SerializeField]
		public GameObject m_timerWordObject;
	}

	[SerializeField]
	private bool m_disabled;
	[SerializeField]
	private float m_playerRunSpeed;
	[SerializeField]
	private float m_eventWait;
	[SerializeField]
	private GameObject m_playerGameObject;
	[SerializeField]
	private UISprite m_playerSprite;
	[SerializeField]
	private UISpriteAnimation[] m_playerSpriteAnimations;
	[SerializeField]
	private UISlider m_playerSlider;
	[SerializeField]
	private GameObject m_playerEffGameObject;
	[SerializeField]
	private UISprite[] m_waypointsSprite;
	[SerializeField]
	private RouteObjects[] m_routesObjects;
	[SerializeField]
	private BalloonObjects[] m_balloonsObjects;
	[SerializeField]
	private UILabel m_scenarioNumberLabel;
	[SerializeField]
	private UILabel m_titleLabel;
	[SerializeField]
	private UILabel m_distanceLabel;
	[SerializeField]
	private UILabel m_advanceDistanceLabel;
	[SerializeField]
	private GameObject m_advanceDistanceGameObject;
	[SerializeField]
	private GameObject m_patternNextObject;
	[SerializeField]
	private GameObject m_btnNextObject;
	[SerializeField]
	private GameObject m_btnSkipObject;
	[SerializeField]
	private GameObject m_btnPlayObject;
	[SerializeField]
	private UITexture m_stageBGTex;
}
