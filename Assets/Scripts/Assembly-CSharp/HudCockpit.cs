using UnityEngine;
using System;

public class HudCockpit : MonoBehaviour
{
	[Serializable]
	private class ScoreColor
	{
		public int red;
		public int green;
		public int blue;
		public int score;
	}

	[SerializeField]
	private ScoreColor[] m_scoreColors;
}
