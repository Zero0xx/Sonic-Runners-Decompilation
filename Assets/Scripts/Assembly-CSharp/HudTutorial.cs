using UnityEngine;
using System;

public class HudTutorial : MonoBehaviour
{
	[Serializable]
	private class ExplanPattern
	{
		[SerializeField]
		public GameObject m_gameObject;
		[SerializeField]
		public UILabel m_label;
		[SerializeField]
		public UITexture m_texture;
	}

	[SerializeField]
	private GameObject m_captionGameObject;
	[SerializeField]
	private UILabel m_captionLabel;
	[SerializeField]
	private GameObject m_explanGameObject;
	[SerializeField]
	private ExplanPattern[] m_explanPatterns;
	[SerializeField]
	private GameObject m_successGameObject;
	[SerializeField]
	private GameObject m_retryGameObject;
	[SerializeField]
	private GameObject m_anchorObj;
}
