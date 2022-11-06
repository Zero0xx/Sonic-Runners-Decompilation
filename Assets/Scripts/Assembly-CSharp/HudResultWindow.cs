using UnityEngine;
using System;

public class HudResultWindow : MonoBehaviour
{
	[Serializable]
	private class ScoreInfo
	{
		[SerializeField]
		public UILabel m_score;
		[SerializeField]
		public UILabel m_ring;
		[SerializeField]
		public UILabel m_animal;
		[SerializeField]
		public UILabel m_distance;
	}

	[Serializable]
	private class TexInfo
	{
		[SerializeField]
		public UITexture m_scoreTex;
		[SerializeField]
		public UITexture m_ringTex;
		[SerializeField]
		public UITexture m_animalTex;
		[SerializeField]
		public UITexture m_distanceTex;
	}

	[Serializable]
	private class SprInfo
	{
		[SerializeField]
		public UISprite m_scoreTex;
		[SerializeField]
		public UISprite m_ringTex;
		[SerializeField]
		public UISprite m_animalTex;
		[SerializeField]
		public UISprite m_distanceTex;
	}

	[SerializeField]
	private ScoreInfo[] m_scoreInfos;
	[SerializeField]
	private TexInfo m_chao1TexInfos;
	[SerializeField]
	private TexInfo m_chao2TexInfos;
	[SerializeField]
	private SprInfo m_chara1TexInfos;
	[SerializeField]
	private SprInfo m_chara2TexInfos;
	[SerializeField]
	private UILabel m_totalScore;
}
