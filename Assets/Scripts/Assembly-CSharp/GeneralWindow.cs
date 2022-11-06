using System;
using UnityEngine;

public class GeneralWindow : WindowBase
{
	[Serializable]
	private class FaceWindowUI
	{
		[SerializeField]
		public string m_windowKey;
		[SerializeField]
		public GameObject m_faceWindowGameObject;
		[SerializeField]
		public UITexture m_faceTexture;
		[SerializeField]
		public GameObject m_namePlateGameObject;
		[SerializeField]
		public UILabel m_nameLabel;
		[SerializeField]
		public GameObject m_balloonArrow;
		[SerializeField]
		public GameObject m_disableFilter;
		[SerializeField]
		public Animation m_fadeAnimation;
		[SerializeField]
		public Animation m_vibrateAnimation;
		[SerializeField]
		public Animation[] m_faceAnimations;
	}

	[SerializeField]
	private GameObject[] m_textViews;
	[SerializeField]
	private GameObject m_imgView;
	[SerializeField]
	private GameObject m_imgItem;
	[SerializeField]
	private GameObject m_imgChao;
	[SerializeField]
	private UILabel m_imgName;
	[SerializeField]
	private UILabel m_imgCount;
	[SerializeField]
	private GameObject m_imgDecoEff;
	[SerializeField]
	private GameObject[] m_eventViews;
	[SerializeField]
	private UILabel[] m_eventTexts;
	[SerializeField]
	private GameObject m_eventOkButton;
	[SerializeField]
	private GameObject m_eventNextButton;
	[SerializeField]
	private GameObject m_eventAllSkipButton;
	[SerializeField]
	private GameObject m_spEventOkButton;
	[SerializeField]
	private GameObject m_spEventNextButton;
	[SerializeField]
	private UIScrollBar m_eventScrollBar;
	[SerializeField]
	private FaceWindowUI[] m_singleFaceWindowUis;
	[SerializeField]
	private FaceWindowUI[] m_twinFaceWindowUis;
	[SerializeField]
	public UITexture m_eventWindowBgTexture;
}
